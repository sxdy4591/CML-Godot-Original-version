// 国家面板: 接管原版 CountryScript + DiploButtonScript(见 Port/DiploHost).
using System.Collections.Generic;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class CountryPanelPane : IPanel
{
    public string Name => "国家面板";

    int _index;
    readonly int[] _types = { -1, -1, -1, -1 };
    readonly int[] _groups = { -1, -1, -1, -1 };

    public Dictionary<string, object> Snapshot()
    {
        DiploHost.Ensure();
        var state = GameHost.State;
        var icons = new List<object>();
        var buttons = new List<object>();
        DiploHost.Show(_index, icons, buttons, out var opis);

        // 每个槽能否自动、当前是否自动: 判定全在 Automation, 这里只搬运。
        // "自动"是类别级开关(一个 this_type 一个勾), 与设置页那份列表是同一份数据。
        for (var i = 0; i < buttons.Count; i++)
        {
            var info = (Dictionary<string, object>)buttons[i];
            var type = (int)info["type"];
            var group = Automation.DiplomacyGroup(type);
            _types[i] = type;
            _groups[i] = group;
            info["autoable"] = Automation.IsAutoable(type) && (bool)info["active"];
            info["auto"] = group >= 0 ? Automation.IsDiplomacyEnabled(group) : Automation.IsEnabled(type);
        }

        return new PanelSnapshot()
            .Put("index", _index)
            .Put("name", state.allcountries[_index].name)
            .Put("puppet_of", state.allcountries[_index].puppetOf)
            .Put("opis", opis)
            .Put("icons", icons)
            .Put("buttons", buttons)
            .Put("auto_types", Automation.TypesString())
            .Put("auto_diplo", Automation.DiplomacyString())
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "查看":
                _index = (int)(long)args[0];
                break;
            case "关闭":
                // 地图高亮用 MapPane 的独立替身扫描, 关面板不需要额外处理
                break;
            case "互动":
                DiploHost.Activate((int)(long)args[0]);
                // 贸易/经合/同盟等会改地图着色, 让下一次地图快照重算颜色
                MapPane.InvalidateColors();
                break;
            case "切换自动":
                var 槽 = (int)(long)args[0];
                if (_groups[槽] >= 0) Automation.ToggleDiplomacy(_groups[槽]);
                else Automation.ToggleType(_types[槽]);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "国家面板没有该动作");
        }
    }
}
