// C# 数据结构 -> Godot Variant 的纯类型转换.
using System.Collections;
using System.Collections.Generic;
using Godot;

namespace CML.Bridge;

public static class UiVariant
{
    public static Variant ToVariant(object value)
    {
        switch (value)
        {
            case null: return default;
            case Variant v: return v;
            case string s: return s;
            case bool b: return b;
            case int i: return i;
            case long l: return l;
            case float f: return f;
            case double d: return d;
            case Color c: return c;
            case Vector2 v2: return v2;
            case Vector2I v2i: return v2i;
            case StringName sn: return sn;
            case IEnumerable<KeyValuePair<string, object>> map: return ToDictionary(map);
            case IEnumerable seq: return ToArray(seq);
            default: throw new System.ArgumentOutOfRangeException(nameof(value), value.GetType(), "不支持的类型");
        }
    }

    public static Godot.Collections.Dictionary ToDictionary(IEnumerable<KeyValuePair<string, object>> map)
    {
        var result = new Godot.Collections.Dictionary();
        foreach (var kv in map) result[kv.Key] = ToVariant(kv.Value);
        return result;
    }

    public static Godot.Collections.Array ToArray(IEnumerable seq)
    {
        var result = new Godot.Collections.Array();
        foreach (var item in seq) result.Add(ToVariant(item));
        return result;
    }

    public static List<object> FromArray(Godot.Collections.Array array)
    {
        var list = new List<object>(array.Count);
        foreach (var item in array) list.Add(FromVariant(item));
        return list;
    }

    public static object FromVariant(Variant value)
    {
        switch (value.VariantType)
        {
            case Variant.Type.Nil: return null;
            case Variant.Type.Bool: return value.AsBool();
            case Variant.Type.Int: return value.AsInt64();
            case Variant.Type.Float: return value.AsDouble();
            case Variant.Type.String: return value.AsString();
            case Variant.Type.Array: return FromArray(value.AsGodotArray());
            case Variant.Type.Dictionary: return FromDictionary(value.AsGodotDictionary());
            default: throw new System.ArgumentOutOfRangeException(nameof(value), value.VariantType, "不支持的 Variant 类型");
        }
    }

    public static Dictionary<string, object> FromDictionary(Godot.Collections.Dictionary dict)
    {
        var result = new Dictionary<string, object>();
        foreach (var key in dict.Keys) result[key.AsString()] = FromVariant(dict[key]);
        return result;
    }
}
