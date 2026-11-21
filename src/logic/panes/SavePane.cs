// 存档界面: 槽位元信息与写入.
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class SavePane : IPanel
{
    public string Name => "存档";

    public Dictionary<string, object> Snapshot()
    {
        var slots = new List<object>();
        for (var i = 1; i <= 5; i++) slots.Add(SlotInfo(i));
        return new PanelSnapshot().Put("slots", slots).Build();
    }

    public void Act(string action, List<object> args)
    {
        var slot = (int)(long)args[0];
        switch (action)
        {
            case "保存":
                SaveService.Save(GameHost.State, SavePaths.Slot(slot));
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "存档面板没有该动作");
        }
    }

    internal static Dictionary<string, object> SlotInfo(int slot)
    {
        var exists = SavePaths.Exists(slot);
        var state = exists ? SaveService.Load(SavePaths.Slot(slot)) : null;
        return new Dictionary<string, object>
        {
            ["slot"] = slot,
            ["exists"] = exists,
            ["date"] = exists ? $"{state.data[21]}年{state.data[20]}月{state.data[19]}日" : "",
        };
    }
}
