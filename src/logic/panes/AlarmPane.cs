// 预警图标: 直接读原版 TimeScript.alarmIcons 的激活状态.
// 开/关全部由原版 TimeScript.Update 维护 —— 科研溢出(alarmIcons[0])、
// PlotPlayerCause(alarmIcons[1] 阴谋)、PlotPolitics(alarmIcons[2] 政治局缺员)、
// DLC 事件(alarmIcons[3..5]). 这里只读, 不能再调 AlarmIconChange:
// 原版那个方法只点亮不熄灭, 每次快照重调会把原版的 false 分支盖掉。
using System.Collections.Generic;

namespace CML.Logic.Panes;

public sealed class AlarmPane : IPanel
{
    public string Name => "预警";

    public Dictionary<string, object> Snapshot()
    {
        var clock = GameHost.Clock;

        var icons = new List<object>();
        for (var i = 0; i < 3; i++) icons.Add(Read(clock, i));
        var events = new List<object>();
        for (var i = 3; i < clock.alarmIcons.Length; i++) events.Add(Read(clock, i));

        return new PanelSnapshot()
            .Put("icons", icons)
            .Put("events", events)
            .Put("event_marker", EventMarker())
            .Build();
    }

    // 地图事件图标(原版 EventScript): 预警场景的"事件提示"按钮显示它与倒计时
    static Dictionary<string, object> EventMarker()
    {
        var marker = GameHost.Clock.events[0];
        var script = marker.GetComponent<EventScript>();
        return new Dictionary<string, object>
        {
            ["active"] = marker.activeSelf,
            ["number"] = script.this_event,
            ["time"] = script.time,
        };
    }

    static Dictionary<string, object> Read(TimeScript clock, int index)
    {
        var go = clock.alarmIcons[index];
        var ok = go.GetComponent<OkoshkoScript>();
        return new Dictionary<string, object>
        {
            ["visible"] = go.activeSelf,
            ["text"] = ok.text ?? ok.text_en ?? "",
        };
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "打开事件":
                GameHost.OpenEventIcon();
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "预警面板没有该动作");
        }
    }
}
