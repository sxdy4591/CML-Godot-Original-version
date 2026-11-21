// 读档界面: 槽位元信息与读取.
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class LoadPane : IPanel
{
    public string Name => "读档";

    static string _importMessage = "";

    public Dictionary<string, object> Snapshot()
    {
        var slots = new List<object>();
        slots.Add(SavePane.SlotInfo(SavePaths.AutoSlot));
        for (var i = 1; i <= 5; i++) slots.Add(SavePane.SlotInfo(i));
        return new PanelSnapshot()
            .Put("slots", slots)
            .Put("import_message", _importMessage)
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "读取":
                var slot = (int)(long)args[0];
                GameHost.ReplaceState(SaveService.Load(SavePaths.Slot(slot)));
                UiEvents.RequestScene("Diplomacy");
                break;
            case "导入Unity":
                var count = UnitySaveImporter.ImportAll();
                _importMessage = count > 0
                    ? $"已从 Unity 版导入 {count} 个存档"
                    : "未找到 Unity 版存档(NewData/*.save)";
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "读档面板没有该动作");
        }
    }
}
