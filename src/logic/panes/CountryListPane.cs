// 国家列表: 地图上点不到的三个小国.
using System.Collections.Generic;

namespace CML.Logic.Panes;

public sealed class CountryListPane : IPanel
{
    public string Name => "国家列表";

    // 原版外交界面右缘常驻的三面国旗(地图上点不到的小国).
    static readonly int[] Countries = { 48, 155, 158 };

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        var list = new List<object>();
        foreach (var index in Countries)
        {
            list.Add(new Dictionary<string, object>
            {
                ["index"] = index,
                ["name"] = state.allcountries[index].name,
            });
        }
        return new PanelSnapshot().Put("countries", list).Build();
    }

    public void Act(string action, List<object> args)
        => throw new System.ArgumentOutOfRangeException(nameof(action), action, "国家列表没有动作");
}
