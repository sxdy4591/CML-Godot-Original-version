// 政治界面: 政客卡片数据 + 政治动作(逐行对照原版 Button_Pol_Script.OnMouseDown).
using System.Collections.Generic;
using CML.Logic.Port;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class PoliticsPane : IPanel
{
    public string Name => "政治";

    // 原版 politics_dolshnost 的两个哨兵: 200=空缺, 150=实权领袖本人(华国锋不在 politics[] 里)
    const int Vacant = 200;
    const int LeaderSentinel = 150;

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        // 卡片顺序取原版 ResetPolitics 的排名(p_first/p_second/p_third/p_forth, 权力降序),
        // 不是 politics[] 下标 —— 政治动作会调 BalancePolitic 重排, 快照必须跟着变.
        var list = new List<object>();
        foreach (var index in PoliticsHost.CardOrder()) list.Add(Card(state, index));

        return new PanelSnapshot()
            .Put("politicians", list)
            .Put("leader", Card(state, -1))
            .Put("posts", Posts(state))
            // 原版 Politic_Data_Show_Script: data/10 + "." + data%10(预算 8 / 特工 9 同口径)
            .Put("budget", Fixed(state.data[8]))
            .Put("agents", Fixed(state.data[9]))
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        var num = (int)(long)args[0];
        var selected = (int)(long)args[1];
        switch (action)
        {
            case "政治动作":
                PoliticsHost.DoAction(selected, num);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "政治面板没有该动作");
        }
    }

    // 原版派系色: traits[0] 0极左红 / 20保守紫 / 1温和粉 / 2改革绿 / 3自由蓝
    static readonly Dictionary<int, Godot.Color> FactionColors = new()
    {
        [0] = new Godot.Color(0.725f, 0.008f, 0.008f),
        [20] = new Godot.Color(0.588f, 0.102f, 0.984f),
        [1] = new Godot.Color(0.980f, 0.337f, 0.325f),
        [2] = new Godot.Color(0f, 0.659f, 0.043f),
        [3] = new Godot.Color(0f, 0.502f, 0.737f),
    };

    static Dictionary<string, object> Card(GameState state, int index)
    {
        var p = index < 0 ? state.leader : state.politics[index];
        var post = Post(state, index);
        var card = new Dictionary<string, object>
        {
            ["index"] = index,
            ["age"] = (int)p.age,
            ["faction_color"] = FactionColors[p.traits[0]],
            ["power"] = p.power,
            ["loyalty"] = p.loyality,
            ["post"] = post < 0 ? "" : PoliticTexts.Posts[post],
            ["face_type"] = (int)p.face_type,
            ["face_parts"] = ToInts(p.face_parts),
            ["jacket"] = (int)p.jacket,
            ["status_flag"] = IsConspirator(state, p) ? "阴谋" : p.is_sledstvie ? "审查" : "",
            ["tooltip"] = index < 0 ? "" : Tooltip(p),
        };
        if (index < 0)
        {
            card["name"] = LeaderName(state);
            card["faction"] = PoliticTexts.Trait(p.traits[0]);
            card["trait1"] = PoliticTexts.Trait(p.traits[1]);
            card["trait2"] = PoliticTexts.Trait(p.traits[2]);
            card["status"] = "";
            card["actions"] = new List<object>();
            return card;
        }

        // 姓名/特质用本工程姓名表(原版 Politic_Selected 的 name_pol 偶发未写入);
        // 左栏状态文本仍取原版 t_zagovor.
        var status = PoliticsHost.Select(index, out _, out _);
        card["name"] = PoliticianName(state, index);
        card["faction"] = PoliticTexts.Trait(p.traits[0]);
        card["trait1"] = PoliticTexts.Trait(p.traits[1]);
        card["trait2"] = PoliticTexts.Trait(p.traits[2]);
        card["status"] = status ?? "";
        card["actions"] = PoliticsHost.EnabledActions(index);
        return card;
    }

    // 卡片悬浮提示: 逐字对齐原版 Politic_Script.Repaint:
    //   string.Format(other_text[350], other_text[351 + wantedDolzh], loyality / 10f, age)
    // 350 是"意向职位/忠诚度/年龄"模板, 351..355 是 5 种意向职位名(取自 other_text 数据表).
    static string Tooltip(Politic p)
    {
        var other = GameHost.Global.other_text;
        return string.Format(other[350], other[351 + p.wantedDolzh], p.loyality / 10f, p.age);
    }

    static string PoliticianName(GameState state, int index)
        => state.names1[state.politics[index].name_1] + " " + state.names2[state.politics[index].name_2];

    // 卡片"阴谋"角标: 原版引擎自己认定的密谋者, 判据逐条对齐
    //   TimeScript.PlotPlayer / PlotPlayerCause / Event4.ResultsOfEvents 三处同一条件.
    // 不能直接用 Politic.is_sagovor —— 那是"被阴谋威胁", 由 PlotPolitics 在领袖逝世后
    // (data[38] >= 100) 大面积置位(实测几乎人人成立), 原版界面从不把它铺成角标.
    // data[38] 开局为 5(毛泽东在世), 只有事件 3(逝世)才置 100; 那之前引擎不存在密谋者.
    static bool IsConspirator(GameState state, Politic p)
    {
        if (state.data[38] < 100) return false;
        var t2 = p.traits[2];
        var plotting = (p.loyality < 300 && t2 == 16) || p.you_fall
            || (p.loyality < 150 && t2 != 9) || (p.loyality < 50 && t2 == 9);
        return plotting && t2 != 17 && t2 != 19 && !p.is_sledstvie;
    }

    // 原版 BeurocratsScript.Repaint: 150 显示实权领袖, 200 显示 "-"
    static string LeaderName(GameState state)
        => state.names1[state.leader.name_1] + " " + state.names2[state.leader.name_2];

    static int Post(GameState state, int index)
    {
        for (var i = 0; i < state.politics_dolshnost.Length; i++)
        {
            if (state.politics_dolshnost[i] == index) return i;
        }
        return -1;
    }

    static List<object> Posts(GameState state)
    {
        var posts = new List<object>();
        foreach (var who in state.politics_dolshnost)
        {
            posts.Add(who == Vacant ? "-" : who == LeaderSentinel ? LeaderName(state) : PoliticianName(state, who));
        }
        return posts;
    }

    static int[] ToInts(byte[] source)
    {
        var result = new int[source.Length];
        for (var i = 0; i < source.Length; i++) result[i] = source[i];
        return result;
    }

    static string Fixed(int value)
    {
        var a = System.Math.Abs(value);
        return (value < 0 ? "-" : "") + a / 10 + "." + a % 10;
    }
}
