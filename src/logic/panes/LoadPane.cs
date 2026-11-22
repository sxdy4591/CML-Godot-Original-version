// 读档界面: 槽位列表 + 读取/删除/复制/恢复备份/导入导出.
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class LoadPane : IPanel
{
    public string Name => "读档";

    static string _message = "";

    public Dictionary<string, object> Snapshot()
    {
        var (auto, slots) = SaveActions.列表();
        return new PanelSnapshot()
            .Put("auto", auto)
            .Put("slots", slots)
            .Put("message", _message)
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "读取":
                GameHost.ReplaceState(SaveService.Load(SavePaths.Slot((int)(long)args[0])));
                UiEvents.RequestScene("Diplomacy");
                break;
            default:
                _message = SaveActions.Act(action, args);
                break;
        }
    }
}
