// 原版 achievements 是挂在各场景对象上的组件(时钟/外交按钮/事件类), Set(n) 只写各自实例的 ach_this[];
// 这里把所有实例登记起来, 界面按"任一实例解锁"聚合读取, 不复制任何判定逻辑.
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic;

public static class AchievementCenter
{
    // 原版 Ach.prefab 序列化的 ach_this 长度是 1000(覆盖代码里 new bool[100] 的初值);
    // 自建成就沿用 dh-4591 扩展包的 1976 编号, 所以容量扩到 2048.
    public const int Slots = 2048;

    static readonly List<achievements> Instances = new();

    public static achievements Register(achievements ach)
    {
        if (ach.ach_this.Length < Slots)
        {
            var old = ach.ach_this;
            ach.ach_this = new bool[Slots];
            System.Array.Copy(old, ach.ach_this, old.Length);
        }
        if (!Instances.Contains(ach)) Instances.Add(ach);
        ApplyKnown(ach);
        return ach;
    }

    // 自建成就(非原版 Set 调用)的解锁入口: 写所有实例的 ach_this, 由差分检测弹出提示.
    public static void Unlock(int number)
    {
        foreach (var ach in Instances) ach.ach_this[number] = true;
    }

    static readonly bool[] Known = new bool[Slots];

    // 移植版没有 Steam: 解锁记录写 playerprefs [ui] achievements(逗号串), 桥层负责读写,
    // 启动时 Restore 灌回所有实例; 解锁状态跨重启/读档保留.
    public static void Restore(string text)
    {
        foreach (var part in text.Split(',', System.StringSplitOptions.RemoveEmptyEntries))
            Known[int.Parse(part)] = true;
        foreach (var ach in Instances) ApplyKnown(ach);
    }

    public static string SaveString()
    {
        var list = new List<string>();
        for (var i = 0; i < Slots; i++) if (Known[i]) list.Add(i.ToString());
        return string.Join(",", list);
    }

    // 调试控制台 achreset: 清空全部解锁记录(内存 + playerprefs 落盘).
    public static void ResetAll()
    {
        System.Array.Clear(Known, 0, Known.Length);
        foreach (var ach in Instances) System.Array.Clear(ach.ach_this, 0, ach.ach_this.Length);
        var cfg = new Godot.ConfigFile();
        cfg.Load("user://playerprefs.ini");
        cfg.SetValue("ui", "achievements", "");
        cfg.Save("user://playerprefs.ini");
    }

    static void ApplyKnown(achievements ach)
    {
        for (var i = 0; i < Slots; i++) if (Known[i]) ach.ach_this[i] = true;
    }

    // 每帧调用: 返回"上一帧还没有、现在有"的成就编号(原版 Set 与自建 Unlock 都会走到这里)
    public static List<int> DrainNewUnlocks()
    {
        var list = new List<int>();
        for (var i = 0; i < Slots; i++)
        {
            var on = false;
            foreach (var ach in Instances)
                if (ach.ach_this[i]) { on = true; break; }
            if (on && !Known[i]) list.Add(i);
            Known[i] = on;
        }
        return list;
    }

    public static bool Unlocked(int number)
    {
        foreach (var ach in Instances) if (ach.ach_this[number]) return true;
        return false;
    }

    public static int UnlockedCount()
    {
        var count = 0;
        for (var i = 0; i < AchievementCatalog.Count; i++)
            if (Unlocked(AchievementCatalog.Numbers[i])) count++;
        return count;
    }
}
