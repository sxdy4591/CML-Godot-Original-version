// 存档/读档两个界面共用的槽位动作(保存/删除/复制/恢复备份/导入导出).
// 面板只负责转发参数并把返回的一句话写进界面提示.
using System;
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public static class SaveActions
{
    public static string Act(string action, List<object> args)
    {
        switch (action)
        {
            case "保存":
            {
                var slot = (int)(long)args[0];
                SaveService.Save(GameHost.State, SavePaths.Slot(slot));
                return $"已保存到槽位 {slot}";
            }
            case "新建":
            {
                var slot = SaveLibrary.NextFreeSlot();
                SaveService.Save(GameHost.State, SavePaths.Slot(slot));
                return $"已保存到新槽位 {slot}";
            }
            case "删除":
            {
                var slot = (int)(long)args[0];
                SaveLibrary.Delete(slot);
                return $"已删除槽位 {slot}";
            }
            case "复制":
            {
                var slot = (int)(long)args[0];
                return $"已复制到槽位 {SaveLibrary.Copy(slot)}";
            }
            case "恢复备份":
            {
                var slot = (int)(long)args[0];
                SaveLibrary.RestoreBackup(slot);
                return $"槽位 {slot} 已从备份恢复";
            }
            case "导出":
            {
                var slot = (int)(long)args[0];
                SaveLibrary.Export(slot, (string)args[1]);
                return $"槽位 {slot} 已导出";
            }
            case "导入Godot":
            {
                var 源 = (string)args[0];
                var slot = (int)(long)args[1];
                if (slot < 0) slot = SaveLibrary.NextFreeSlot();
                SaveLibrary.ImportGodot(源, slot);
                return $"已从 Godot 存档导入到槽位 {slot}";
            }
            case "导入Unity":
            {
                var 源 = (string)args[0];
                var slot = (int)(long)args[1];
                if (slot < 0) slot = SaveLibrary.NextFreeSlot();
                SaveLibrary.ImportUnity(源, slot);
                return $"已从 Unity 存档导入到槽位 {slot}";
            }
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, "没有该存档动作");
        }
    }

    // 槽位列表快照: 自动存档不再固定 0 号槽, 而是 GameHost.AutoSaveSlot 指定的普通槽
    // (0=关闭); Auto 返回该槽的元信息, Slots 是全部槽, 每项带 auto 标记供行按钮显示.
    public static (Dictionary<string, object> Auto, List<object> Slots) 列表()
    {
        var 自动槽 = GameHost.AutoSaveSlot;
        var 自动 = 空槽(自动槽);
        var 槽们 = new List<object>();
        foreach (var 元 in SaveLibrary.List())
        {
            var 项 = 信息(元);
            项["auto"] = 自动槽 > 0 && 元.Slot == 自动槽;
            if (自动槽 > 0 && 元.Slot == 自动槽) 自动 = 项;
            槽们.Add(项);
        }
        return (自动, 槽们);
    }

    public static Dictionary<string, object> 空槽(int slot) => new()
    {
        ["slot"] = slot,
        ["exists"] = false,
        ["date"] = "",
        ["leader"] = "",
        ["difficulty"] = 0,
        ["time"] = "",
        ["has_backup"] = false,
        ["auto"] = false,
    };

    static Dictionary<string, object> 信息(SaveMeta 元) => new()
    {
        ["slot"] = 元.Slot,
        ["exists"] = true,
        ["date"] = 元.Date,
        ["leader"] = 元.Leader,
        ["difficulty"] = 元.Difficulty,
        ["time"] = 元.Time,
        ["has_backup"] = 元.HasBackup,
    };
}
