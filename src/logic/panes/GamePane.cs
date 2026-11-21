// ============================================================
// 逻辑层 — GamePane: 全局游戏动作（开局 / 日期 / 速度）
//
// 只把动作转发给原版入口，快照只读原版状态。
// 主菜单/设置等系统界面不经过这里（它们纯 GDScript）。
//
// 快照契约：
//   booted   bool    原版内核是否已就绪
//   year     int
//   month    int
//   day      int
//   speed    int     0=暂停，1..4
// ============================================================
using System.Collections.Generic;

namespace CML.Logic.Panes;

public sealed class GamePane : IPanel
{
    public string Name => "游戏";

    public Dictionary<string, object> Snapshot()
    {
        // 快照只读: 时间/事件推进已统一到 GameHost.Tick(UI 刷新频率不再影响逻辑)
        var state = GameHost.State;
        return new PanelSnapshot()
            .Put("booted", GameHost.Booted)
            .Put("speed", GameHost.Speed)
            .Put("date", $"{state.data[21]}年{state.data[20]}月{state.data[19]}日")
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "开始新游戏":
                GameHost.StartNewGame(1);
                break;
            case "设置速度":
                GameHost.SetSpeed((int)(long)args[0]);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "游戏面板没有该动作");
        }
    }
}
