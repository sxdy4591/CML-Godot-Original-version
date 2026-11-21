// 顶部状态栏: 原版 GameState.data 的十项数值(×10 内部单位 → x.x 文本).
// 口径: 党内支持度 data[1] / 人民支持度 data[3] / 思想自由度 data[4] /
// 生活水平 data[5] / 国际声望 data[6] / 国际影响力 data[7] / 预算 data[8] /
// 特工网络 data[9] / 美国关系 empires[0].relations / 苏联关系 empires[1].relations.
// tooltip: 当前值 + 上期结算变化(data_old)推出的"预计下次结算".
using System.Collections.Generic;

namespace CML.Logic.Panes;

public sealed class TopStatePane : IPanel
{
    public string Name => "状态栏";

    // 关系值的差分在 data_old[28]/[29](原版 TimeScript.KumihaRepaint 每 tick 镜像)
    const int AmericaDeltaSlot = 28;
    const int SovietDeltaSlot = 29;

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        var d = state.data;
        var old = state.data_old;
        return new PanelSnapshot()
            .Put("party_support", Item(d[1], old[1]))
            .Put("people_support", Item(d[3], old[3]))
            .Put("freedom", Item(d[4], old[4]))
            .Put("living", Item(d[5], old[5]))
            .Put("prestige", Item(d[6], old[6]))
            .Put("influence", Item(d[7], old[7]))
            .Put("budget", Item(d[8], old[8]))
            .Put("agents", Item(d[9], old[9]))
            .Put("american", Item(state.empires[0].relations, old[AmericaDeltaSlot]))
            .Put("soviet", Item(state.empires[1].relations, old[SovietDeltaSlot]))
            .Build();
    }

    public void Act(string action, List<object> args)
        => throw new System.ArgumentOutOfRangeException(nameof(action), action, "状态栏没有动作");

    static Dictionary<string, object> Item(int value, int delta)
    {
        var text = Fixed(value);
        var sign = delta < 0 ? "" : "+";
        return new Dictionary<string, object>
        {
            ["text"] = text,
            ["tip"] = $"{Fixed(value + delta)} ({sign}{Fixed(delta)})",
        };
    }

    // ×10 内部单位 → "x.y"(负号在外)
    static string Fixed(int value)
    {
        var a = System.Math.Abs(value);
        return (value < 0 ? "-" : "") + a / 10 + "." + a % 10;
    }
}
