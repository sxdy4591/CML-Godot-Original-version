// 存档库: 槽位扫描/元信息/删除/复制/恢复备份/导入导出.
// 槽位号 = user://save_{n}.dat 的 n; 0 号是自动存档(独立一栏), 手动槽从 1 开始, 可无限追加.
// 元信息按 (mtime, 长度) 缓存: 打开存档界面/每次动作刷新时不重复反序列化全部存档.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CML.Logic.Port;

public sealed class SaveMeta
{
    public int Slot;
    public bool Auto;
    public bool Exists;
    public bool 损坏;
    public string Date = "";
    public string Leader = "";
    public int Difficulty;
    public string Time = "";
    public bool HasBackup;
}

public static class SaveLibrary
{
    const int Magic = 0x434D4C53;
    const int Version = 1;
    static readonly Regex 档名 = new(@"^save_(\d+)\.dat$");
    static readonly Dictionary<int, (long Ticks, long Length, SaveMeta Meta)> 缓存 = new();

    public static string 备份路径(int slot) => SavePaths.Slot(slot) + ".bak";

    // 扫描 user:// 下所有存档槽(含 0 号自动档), 按槽号排序; 不是本移植版格式的文件跳过.
    public static List<SaveMeta> List()
    {
        var 结果 = new List<SaveMeta>();
        var 目录 = Path.GetDirectoryName(SavePaths.Slot(0));
        foreach (var 文件 in Directory.GetFiles(目录, "save_*.dat"))
        {
            var 匹配 = 档名.Match(Path.GetFileName(文件));
            if (!匹配.Success) continue;
            var 元 = Read(int.Parse(匹配.Groups[1].Value));
            if (!元.损坏) 结果.Add(元);
        }
        结果.Sort((a, b) => a.Slot.CompareTo(b.Slot));
        return 结果;
    }

    // 读一个槽的元信息; 文件不存在/不是本移植版存档都返回空项(损坏 = true).
    public static SaveMeta Read(int slot)
    {
        var 路径 = SavePaths.Slot(slot);
        var 元 = new SaveMeta
        {
            Slot = slot,
            Auto = slot == SavePaths.AutoSlot,
            HasBackup = File.Exists(备份路径(slot)),
        };
        if (!File.Exists(路径)) return 元;
        var 信息 = new FileInfo(路径);
        if (缓存.TryGetValue(slot, out var 旧)
            && 旧.Ticks == 信息.LastWriteTimeUtc.Ticks && 旧.Length == 信息.Length)
        {
            旧.Meta.HasBackup = 元.HasBackup;
            return 旧.Meta;
        }
        元.Exists = true;
        if (!是Godot存档(路径))
        {
            元.损坏 = true;
            return 元;
        }
        var state = SaveService.Load(路径);
        元.Date = $"{state.data[21]}年{state.data[20]}月{state.data[19]}日";
        元.Leader = state.names1[state.leader.name_1].Trim() + state.names2[state.leader.name_2].Trim();
        元.Difficulty = state.diff;
        var 时间 = 信息.LastWriteTime;
        // 工程字体里半角空格的宽度为 0, "日期 时间" 会粘成 "11-2100:28";
        // 用可见的 "/" 分隔, 不依赖空格字形. 冒号也逐段拼(自定义格式里的 ":" 是文化相关的分隔符占位符).
        元.Time = $"{时间.Year}-{时间.Month:D2}-{时间.Day:D2} / {时间.Hour:D2}:{时间.Minute:D2}";
        缓存[slot] = (信息.LastWriteTimeUtc.Ticks, 信息.Length, 元);
        return 元;
    }

    static bool 是Godot存档(string 路径)
    {
        using var stream = File.OpenRead(路径);
        if (stream.Length < 8) return false;
        using var reader = new BinaryReader(stream);
        return reader.ReadInt32() == Magic && reader.ReadInt32() == Version;
    }

    // 下一个空槽(从 1 开始; 自动槽 0 永远不参与手动保存).
    public static int NextFreeSlot()
    {
        var slot = 1;
        while (File.Exists(SavePaths.Slot(slot))) slot++;
        return slot;
    }

    public static void Delete(int slot)
    {
        var 路径 = SavePaths.Slot(slot);
        if (File.Exists(路径)) File.Delete(路径);
        缓存.Remove(slot);
    }

    // 复制到下一个空槽, 返回新槽号.
    public static int Copy(int slot)
    {
        var 新槽 = NextFreeSlot();
        File.Copy(SavePaths.Slot(slot), SavePaths.Slot(新槽));
        return 新槽;
    }

    // 用 .bak 覆盖当前槽(调用方负责确认).
    public static void RestoreBackup(int slot)
    {
        File.Copy(备份路径(slot), SavePaths.Slot(slot), true);
        缓存.Remove(slot);
    }

    // 导出到玩家选的文件.
    public static void Export(int slot, string 目标) => File.Copy(SavePaths.Slot(slot), 目标, true);

    // 导入 Godot 格式存档: 先校验文件头, 覆盖前把现有档备份成 .bak.
    public static void ImportGodot(string 源, int slot)
    {
        if (!是Godot存档(源))
            throw new InvalidDataException($"{源} 不是本移植版的存档文件");
        if (File.Exists(SavePaths.Slot(slot))) File.Copy(SavePaths.Slot(slot), 备份路径(slot), true);
        File.Copy(源, SavePaths.Slot(slot), true);
        缓存.Remove(slot);
    }

    // 导入 Unity 格式存档(MS-NRBF): 转换后按 Godot 格式写入, 覆盖前备份.
    public static void ImportUnity(string 源, int slot)
    {
        var tree = NrbfReader.Parse(源) as NrbfClass;
        if (tree == null || tree.TypeName != nameof(GameState))
            throw new InvalidDataException($"{源} 不是 Unity 版 GameState 存档");
        var state = (GameState)UnitySaveImporter.转换(typeof(GameState), tree);
        // 顺手补齐旧口径的数组, 导入后的槽位文件就是当前口径, 之后每次读档都不用再赌
        GameStateFactory.EnsureCapacity(state);
        if (File.Exists(SavePaths.Slot(slot))) File.Copy(SavePaths.Slot(slot), 备份路径(slot), true);
        SaveService.Save(state, SavePaths.Slot(slot));
        缓存.Remove(slot);
    }
}
