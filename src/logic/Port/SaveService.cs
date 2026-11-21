// 存档: 反射遍历 GameState 图写二进制, 读回保持共享引用.
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CML.Logic.Port;

public static class SaveService
{
    const int Magic = 0x434D4C53;
    const int Version = 1;

    const byte TNull = 0, TBool = 1, TInt = 2, TFloat = 3, TString = 4;
    const byte TByte = 5, TDateTime = 6, TArray = 7, TObject = 8, TRef = 9;

    const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    public static void Save(GameState state, string path)
    {
        using var stream = new FileStream(path, FileMode.Create, FileAccess.Write);
        using var writer = new BinaryWriter(stream);
        writer.Write(Magic);
        writer.Write(Version);
        Write(writer, state, new Dictionary<object, int>(ReferenceEqualityComparer.Instance));
    }

    public static GameState Load(string path)
    {
        using var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
        using var reader = new BinaryReader(stream);
        if (reader.ReadInt32() != Magic) throw new InvalidDataException("不是本移植版存档");
        if (reader.ReadInt32() != Version) throw new InvalidDataException("存档版本不匹配");
        return (GameState)Read(reader, new Dictionary<int, object>());
    }

    static void Write(BinaryWriter w, object value, Dictionary<object, int> seen)
    {
        if (value == null) { w.Write(TNull); return; }
        var type = value.GetType();
        if (type.IsEnum) { w.Write(TInt); w.Write(Convert.ToInt32(value)); return; }
        switch (value)
        {
            case bool b: w.Write(TBool); w.Write(b); return;
            case int i: w.Write(TInt); w.Write(i); return;
            case float f: w.Write(TFloat); w.Write(f); return;
            case string s: w.Write(TString); w.Write(s); return;
            case byte by: w.Write(TByte); w.Write(by); return;
            case DateTime dt: w.Write(TDateTime); w.Write(dt.Ticks); return;
            case Array array: WriteArray(w, array, seen); return;
        }
        WriteObject(w, value, seen);
    }

    static void WriteArray(BinaryWriter w, Array array, Dictionary<object, int> seen)
    {
        if (seen.TryGetValue(array, out var id)) { w.Write(TRef); w.Write(id); return; }
        seen[array] = seen.Count;
        w.Write(TArray);
        w.Write(array.GetType().GetElementType().AssemblyQualifiedName);
        w.Write(array.Length);
        foreach (var item in array) Write(w, item, seen);
    }

    static void WriteObject(BinaryWriter w, object value, Dictionary<object, int> seen)
    {
        if (seen.TryGetValue(value, out var id)) { w.Write(TRef); w.Write(id); return; }
        seen[value] = seen.Count;
        w.Write(TObject);
        w.Write(value.GetType().AssemblyQualifiedName);
        var fields = SerializableFields(value.GetType());
        w.Write(fields.Length);
        foreach (var field in fields)
        {
            w.Write(field.Name);
            Write(w, field.GetValue(value), seen);
        }
    }

    static object Read(BinaryReader r, Dictionary<int, object> refs)
    {
        var tag = r.ReadByte();
        switch (tag)
        {
            case TNull: return null;
            case TBool: return r.ReadBoolean();
            case TInt: return r.ReadInt32();
            case TFloat: return r.ReadSingle();
            case TString: return r.ReadString();
            case TByte: return r.ReadByte();
            case TDateTime: return new DateTime(r.ReadInt64());
            case TArray: return ReadArray(r, refs);
            case TObject: return ReadObject(r, refs);
            case TRef: return refs[r.ReadInt32()];
            default: throw new InvalidDataException($"未知标签 {tag}");
        }
    }

    static object ReadArray(BinaryReader r, Dictionary<int, object> refs)
    {
        var elementType = 类型(r.ReadString());
        var length = r.ReadInt32();
        var array = Array.CreateInstance(elementType, length);
        refs[refs.Count] = array;
        for (var i = 0; i < length; i++) array.SetValue(Read(r, refs), i);
        return array;
    }

    static object ReadObject(BinaryReader r, Dictionary<int, object> refs)
    {
        var type = 类型(r.ReadString());
        // 原版类里有只带默认参数的构造函数(如 Modifiers), Activator 找不到无参构造;
        // 字段全部由存档赋值, 用未初始化实例绕开构造函数.
        var instance = System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(type);
        refs[refs.Count] = instance;
        var count = r.ReadInt32();
        for (var i = 0; i < count; i++)
        {
            var name = r.ReadString();
            var value = Read(r, refs);
            var field = type.GetField(name, Flags);
            field.SetValue(instance, 字段转换(field.FieldType, value));
        }
        return instance;
    }

    // 存档里写的是 AssemblyQualifiedName; 本工程程序集名带方括号("中国-毛的遗产[godot二版]"),
    // Type.GetType 会把方括号当类型语法解析失败, 直接到本程序集里按短名找.
    static Type 类型(string name)
    {
        var type = typeof(GameState).Assembly.GetType(name.Split(',')[0]);
        return type != null ? type : Type.GetType(name);
    }

    // 类型改过的字段(如 Politic.name_1 由 byte 改 int)读旧档时值类型不一致, 统一转一次.
    static object 字段转换(Type target, object value)
    {
        if (value == null) return null;
        if (target.IsInstanceOfType(value)) return value;
        return Convert.ChangeType(value, target);
    }

    static FieldInfo[] SerializableFields(Type type)
    {
        var all = type.GetFields(Flags);
        var list = new List<FieldInfo>();
        foreach (var field in all)
        {
            if (field.IsStatic || field.IsNotSerialized) continue;
            list.Add(field);
        }
        return list.ToArray();
    }
}
