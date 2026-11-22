// 保存界面: 槽位列表 + 写入/新建/删除/复制/恢复备份/导入导出.
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class SavePane : IPanel
{
    public string Name => "存档";

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
        => _message = SaveActions.Act(action, args);
}
