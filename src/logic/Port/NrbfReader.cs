// 原版 Unity 存档(MS-NRBF / BinaryFormatter 流)只读解析.
// 解成一棵中立树: NrbfClass(字段名→值) / 数组 / 基元 / string.
// 不依赖 BinaryFormatter —— .NET 9+ 已移除它(安卓导出目标 net10 也在其中).
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CML.Logic.Port;

public sealed class NrbfClass
{
    public string TypeName;
    public readonly Dictionary<string, object> Fields = new();
}

public static class NrbfReader
{
    // 记录类型 (MS-NRBF 2.1.1)
    const byte Header = 0, ClassWithId = 1, SystemClassWithMembers = 2, ClassWithMembers = 3;
    const byte SystemClassWithMembersAndTypes = 4, ClassWithMembersAndTypes = 5;
    const byte BinaryObjectString = 6, BinaryArray = 7, MemberPrimitiveTyped = 8, MemberReference = 9;
    const byte ObjectNull = 10, MessageEnd = 11, BinaryLibrary = 12;
    const byte ObjectNullMultiple256 = 13, ObjectNullMultiple = 14;
    const byte ArraySinglePrimitive = 15, ArraySingleObject = 16, ArraySingleString = 17;

    // 基元类型 (MS-NRBF 2.1.2.2, 值等于 .NET InternalPrimitiveTypeE)
    const byte PBoolean = 1, PByte = 2, PChar = 3, PCurrency = 4, PDecimal = 5, PDouble = 6;
    const byte PInt16 = 7, PInt32 = 8, PInt64 = 9, PSByte = 10, PSingle = 11, PTimeSpan = 12;
    const byte PDateTime = 13, PUInt16 = 14, PUInt32 = 15, PUInt64 = 16;

    // 成员声明类型 (MS-NRBF 2.1.2.3)
    const byte KPrimitive = 0, KSystemClass = 3, KCls = 4, KPrimitiveArray = 7;

    sealed class Meta
    {
        public string Name;
        public string[] Members;
        public int Id;
        public byte[] Kinds;
        public object[] Infos;
    }

    sealed class State
    {
        public BinaryReader Reader;
        public readonly Dictionary<int, object> Objects = new();
        public readonly Dictionary<int, Meta> Meta = new();
        // 前向引用(成员引用尚未出现的对象): 先置 null, 整条流读完再回填.
        public readonly List<Action> Fixups = new();
    }

    public static object Parse(string path)
    {
        using var stream = File.OpenRead(path);
        using var memory = new MemoryStream();
        stream.CopyTo(memory);
        return Parse(memory.ToArray());
    }

    public static object Parse(byte[] bytes)
    {
        var state = new State { Reader = new BinaryReader(new MemoryStream(bytes), Encoding.UTF8) };
        object root = null;
        while (state.Reader.BaseStream.Position < state.Reader.BaseStream.Length)
        {
            var record = state.Reader.ReadByte();
            if (record == MessageEnd) break;
            var value = 读记录(state, record);
            if ((record == Header || record == BinaryLibrary) == false && root == null) root = value;
        }
        foreach (var fixup in state.Fixups) fixup();
        return root;
    }

    // ================= 记录 =================

    static object 读记录(State state, byte record)
    {
        var reader = state.Reader;
        switch (record)
        {
            case Header:
                reader.ReadInt32(); reader.ReadInt32(); reader.ReadInt32(); reader.ReadInt32();
                return null;

            case BinaryLibrary:
                reader.ReadInt32();
                reader.ReadString();
                return null;

            case SystemClassWithMembers:
            case ClassWithMembers:
            {
                var meta = 读类信息(state);
                if (record == ClassWithMembers) reader.ReadInt32();
                var value = 读成员(state, meta);
                state.Objects[meta.Id] = value;
                return value;
            }

            case SystemClassWithMembersAndTypes:
            case ClassWithMembersAndTypes:
            {
                var meta = 读类信息(state);
                读成员类型(state, meta);
                if (record == ClassWithMembersAndTypes) reader.ReadInt32();
                var value = 读成员(state, meta);
                state.Objects[meta.Id] = value;
                return value;
            }

            case ClassWithId:
            {
                var id = reader.ReadInt32();
                var meta = state.Meta[reader.ReadInt32()];
                var value = 读成员(state, meta);
                state.Objects[id] = value;
                return value;
            }

            case BinaryObjectString:
            {
                var id = reader.ReadInt32();
                var text = reader.ReadString();
                state.Objects[id] = text;
                return text;
            }

            case MemberReference:
            {
                var id = reader.ReadInt32();
                return state.Objects[id];
            }

            case ObjectNull:
                return null;

            case MemberPrimitiveTyped:
                return 读基元(reader, reader.ReadByte());

            case ArraySinglePrimitive:
            {
                var id = reader.ReadInt32();
                var length = reader.ReadInt32();
                var type = reader.ReadByte();
                var array = 建基元数组(type, length);
                for (var i = 0; i < length; i++)
                    array.SetValue(读基元(reader, type), i);
                state.Objects[id] = array;
                return array;
            }

            case ArraySingleObject:
            case ArraySingleString:
            {
                var id = reader.ReadInt32();
                var length = reader.ReadInt32();
                var array = new object[length];
                state.Objects[id] = array;
                读元素(state, array, 0, length);
                return array;
            }

            case BinaryArray:
                return 读二进制数组(state);

            default:
                throw new InvalidDataException($"未知 NRBF 记录 {record}");
        }
    }

    static Meta 读类信息(State state)
    {
        var reader = state.Reader;
        var meta = new Meta
        {
            Id = reader.ReadInt32(),
            Name = reader.ReadString(),
        };
        var count = reader.ReadInt32();
        meta.Members = new string[count];
        for (var i = 0; i < count; i++) meta.Members[i] = reader.ReadString();
        state.Meta[meta.Id] = meta;
        return meta;
    }

    static void 读成员类型(State state, Meta meta)
    {
        var reader = state.Reader;
        var count = meta.Members.Length;
        meta.Kinds = new byte[count];
        meta.Infos = new object[count];
        for (var i = 0; i < count; i++) meta.Kinds[i] = reader.ReadByte();
        for (var i = 0; i < count; i++)
        {
            switch (meta.Kinds[i])
            {
                case KPrimitive:
                case KPrimitiveArray:
                    meta.Infos[i] = reader.ReadByte();
                    break;
                case KSystemClass:
                    meta.Infos[i] = reader.ReadString();
                    break;
                case KCls:
                    meta.Infos[i] = reader.ReadString();
                    reader.ReadInt32();
                    break;
            }
        }
    }

    static NrbfClass 读成员(State state, Meta meta)
    {
        var value = new NrbfClass { TypeName = meta.Name };
        for (var i = 0; i < meta.Members.Length; i++)
        {
            // 声明成基元的成员是裸值, 没有记录标记; 其余成员各带一条记录.
            if (meta.Kinds != null && meta.Kinds[i] == KPrimitive)
            {
                value.Fields[meta.Members[i]] = 读基元(state.Reader, (byte)meta.Infos[i]);
                continue;
            }
            value.Fields[meta.Members[i]] = 读成员值(state, value, meta.Members[i]);
        }
        return value;
    }

    static object 读成员值(State state, NrbfClass owner, string field)
    {
        var reader = state.Reader;
        var record = reader.ReadByte();
        switch (record)
        {
            case ObjectNull:
                return null;
            case ObjectNullMultiple256:
                reader.ReadByte();
                return null;
            case ObjectNullMultiple:
                reader.ReadInt32();
                return null;
            case MemberPrimitiveTyped:
                return 读基元(reader, reader.ReadByte());
            case MemberReference:
            {
                var id = reader.ReadInt32();
                if (state.Objects.TryGetValue(id, out var known)) return known;
                state.Fixups.Add(() => owner.Fields[field] = state.Objects[id]);
                return null;
            }
            default:
                return 读记录(state, record);
        }
    }

    static Array 读二进制数组(State state)
    {
        var reader = state.Reader;
        var id = reader.ReadInt32();
        var arrayType = reader.ReadByte();
        var rank = reader.ReadInt32();
        if (arrayType != 0 && rank != 1)
            throw new InvalidDataException($"不支持的数组形状: type={arrayType} rank={rank}");
        var length = reader.ReadInt32();
        var element = reader.ReadByte();
        byte primitive = 0;
        switch (element)
        {
            case KPrimitive:
            case KPrimitiveArray:
                primitive = reader.ReadByte();
                break;
            case KSystemClass:
            case KCls:
                reader.ReadString();
                if (element == KCls) reader.ReadInt32();
                break;
        }

        var array = element == KPrimitive || element == KPrimitiveArray
            ? 建基元数组(primitive, length)
            : new object[length];
        state.Objects[id] = array;
        if (array is object[] objects) 读元素(state, objects, 0, length);
        else
            for (var i = 0; i < length; i++)
                array.SetValue(读基元(reader, primitive), i);
        return array;
    }

    // 对象数组元素: 每条元素前有记录标记, ObjectNullMultiple* 表示连续多个 null.
    static void 读元素(State state, object[] array, int from, int to)
    {
        var reader = state.Reader;
        for (var i = from; i < to; i++)
        {
            var record = reader.ReadByte();
            switch (record)
            {
                case ObjectNull:
                    array[i] = null;
                    break;
                case ObjectNullMultiple256:
                    i += reader.ReadByte() - 1;
                    break;
                case ObjectNullMultiple:
                    i += reader.ReadInt32() - 1;
                    break;
                case MemberPrimitiveTyped:
                    array[i] = 读基元(reader, reader.ReadByte());
                    break;
                case MemberReference:
                {
                    var id = reader.ReadInt32();
                    if (state.Objects.TryGetValue(id, out var known)) array[i] = known;
                    else
                    {
                        var index = i;
                        state.Fixups.Add(() => array[index] = state.Objects[id]);
                    }
                    break;
                }
                default:
                    array[i] = 读记录(state, record);
                    break;
            }
        }
    }

    // ================= 基元 =================

    static object 读基元(BinaryReader reader, byte type) => type switch
    {
        PBoolean => reader.ReadBoolean(),
        PByte => reader.ReadByte(),
        PChar => reader.ReadChar(),
        PCurrency => reader.ReadInt64(),
        PDecimal => reader.ReadDecimal(),
        PDouble => reader.ReadDouble(),
        PInt16 => reader.ReadInt16(),
        PInt32 => reader.ReadInt32(),
        PInt64 => reader.ReadInt64(),
        PSByte => reader.ReadSByte(),
        PSingle => reader.ReadSingle(),
        PTimeSpan => reader.ReadInt64(),
        PDateTime => reader.ReadInt64(),
        PUInt16 => reader.ReadUInt16(),
        PUInt32 => reader.ReadUInt32(),
        PUInt64 => reader.ReadUInt64(),
        _ => throw new InvalidDataException($"未知基元类型 {type}"),
    };

    static Array 建基元数组(byte type, int length) => type switch
    {
        PBoolean => new bool[length],
        PByte => new byte[length],
        PChar => new char[length],
        PCurrency => new long[length],
        PDecimal => new decimal[length],
        PDouble => new double[length],
        PInt16 => new short[length],
        PInt32 => new int[length],
        PInt64 => new long[length],
        PSByte => new sbyte[length],
        PSingle => new float[length],
        PTimeSpan => new long[length],
        PDateTime => new long[length],
        PUInt16 => new ushort[length],
        PUInt32 => new uint[length],
        PUInt64 => new ulong[length],
        _ => throw new InvalidDataException($"未知基元数组类型 {type}"),
    };
}
