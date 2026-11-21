// 原版(Unity 版)存档导入: NewData/{n}.save 是 BinaryFormatter(MS-NRBF) 序列化的 GameState.
// 用 NrbfReader 解成中立树, 再按字段名灌进本工程类 —— 不走 BinaryFormatter
// (它在 .NET 9+ 已被移除, 安卓导出目标 net10 同样不可用).
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CML.Logic.Port;

public static class UnitySaveImporter
{
    const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    // 原版 Savescript.WriteYugoSave 写到工作目录 NewData/{num}.save
    public static string UnityPath(int slot) =>
        Path.Combine(Directory.GetCurrentDirectory(), "NewData", slot + ".save");

    // 返回成功导入的槽数; 没有文件/不是原版存档时直接抛.
    public static int ImportAll()
    {
        var count = 0;
        for (var slot = 1; slot <= 5; slot++)
        {
            if (!File.Exists(UnityPath(slot))) continue;
            var tree = (NrbfClass)NrbfReader.Parse(UnityPath(slot));
            if (tree.TypeName != nameof(GameState))
                throw new InvalidDataException($"根对象是 {tree.TypeName}, 不是 GameState");
            var state = (GameState)转换(typeof(GameState), tree);
            SaveService.Save(state, SavePaths.Slot(slot));
            count++;
        }
        return count;
    }

    // 中立树 → 本工程类: 只按字段名对应, 类型不同时转换(NRBF 里的 int 字段可能对应 byte).
    static object 转换(Type target, object node)
    {
        if (node == null) return target.IsValueType ? Activator.CreateInstance(target) : null;
        if (target == typeof(string)) return node;
        if (target.IsEnum) return Enum.ToObject(target, node);
        // MS-NRBF 里 DateTime/TimeSpan 是 ticks(long) 的基元值, 不是对象.
        if (target == typeof(DateTime)) return new DateTime((long)node);
        if (target == typeof(TimeSpan)) return new TimeSpan((long)node);
        if (target.IsPrimitive || target == typeof(decimal)) return Convert.ChangeType(node, target);
        if (target.IsArray)
        {
            var source = (Array)node;
            var element = target.GetElementType();
            var result = Array.CreateInstance(element, source.Length);
            for (var i = 0; i < source.Length; i++) result.SetValue(转换(element, source.GetValue(i)), i);
            return result;
        }

        var instance = RuntimeHelpers.GetUninitializedObject(target);
        var source2 = (NrbfClass)node;
        foreach (var field in 字段(target))
            if (source2.Fields.TryGetValue(field.Name, out var raw))
                field.SetValue(instance, 转换(field.FieldType, raw));
        return instance;
    }

    static IEnumerable<FieldInfo> 字段(Type type)
    {
        for (var current = type; current != typeof(object); current = current.BaseType)
            foreach (var field in current.GetFields(Flags | BindingFlags.DeclaredOnly))
            {
                if (field.IsStatic) continue;
                yield return field;
            }
    }
}
