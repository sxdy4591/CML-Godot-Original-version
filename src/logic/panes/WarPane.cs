// 战争界面: 进行中战争列表 + 8 种干预.
// 可用性 = 原版 WarButtonScript.CheckButtonAvailable, 执行 = 原版 OnMouseDown;
// 这里只装配按钮对象图(WarScriptBack + 每个战争一组 8 个按钮)并搬运数据.
using System.Collections.Generic;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class WarPane : IPanel
{
    public string Name => "战争";

    static WarsScript _wars;
    static readonly Dictionary<int, Stub[]> Buttons = new();

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        var wars = new List<object>();
        for (var i = 0; i < state.ingamewars.Length; i++)
        {
            var w = state.ingamewars[i];
            if (!w.is_going) continue;
            LocalizeKnownWar(w);
            var can = new List<object>(8);
            foreach (var button in Ensure(i))
            {
                button.Invoke("CheckButtonAvailable");
                can.Add(button.Typed<WarButtonScript>().enabled);
            }
            wars.Add(new Dictionary<string, object>
            {
                ["index"] = i,
                ["name"] = Newlines(w.name_war),
                ["left"] = Newlines(w.side1),
                ["right"] = Newlines(w.side2),
                ["left_value"] = (w.infl1 / 10).ToString(),
                ["right_value"] = (w.infl2 / 10).ToString(),
                ["usa_side"] = w.usa_place,
                ["ussr_side"] = w.ussr_place,
                ["can_action"] = can,
            });
        }

        return new PanelSnapshot()
            .Put("intervention", Fixed(state.data[0]))
            .Put("wars", wars)
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "支援":
                var war = (int)(long)args[0];
                var button = (int)(long)args[1];
                Ensure(war)[button].Invoke("OnMouseDown");
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "战争面板没有该动作");
        }
    }

    // 原版 WarsScript 的场景替身: WarButtonScript.Start 靠 GameObject.Find("WarScriptBack") 取它.
    static void EnsureWars()
    {
        if (_wars != null) return;
        _wars = Stub.Take<WarsScript>("WarScriptBack", Lifecycle.None).Typed<WarsScript>();
    }

    // 一个战争编号 → 8 个原版按钮. our_wars 预置为战争编号,
    // CheckButtonAvailable 就走"直接读 ingamewars[our_wars]"这一支, 不依赖 WarsScript.active_wars.
    static Stub[] Ensure(int war)
    {
        if (Buttons.TryGetValue(war, out var cached)) return cached;
        EnsureWars();
        var root = new GameObject(war.ToString());
        root.transform.name = war.ToString();
        var list = new Stub[8];
        for (var i = 0; i < 8; i++)
        {
            var stub = Stub.Take<WarButtonScript>("WarButton" + i, Lifecycle.Scene);
            stub.Go.transform.SetParent(root.transform);
            stub.Also<SpriteRenderer>();
            var textGo = new GameObject("Text");
            textGo.transform.SetParent(stub.Go.transform);
            textGo.AddComponent<TextMesh>();
            stub.Set("war_number", war);
            stub.Set("this_number", i);
            stub.Set("our_wars", war);
            stub.Set("place_1", new TextMesh());
            stub.Set("place_2", new TextMesh());
            stub.Set("navel", new Sprite { name = "navel" });
            stub.Set("nenavel", new Sprite { name = "nenavel" });
            // 字段就位后起原版生命周期(Start 会校验父对象编号并写按钮文字)
            stub.Activate();
            list[i] = stub;
        }
        Buttons[war] = list;
        return list;
    }

    // 原版战争名/势力名的 "|" 是换行符(WarsScript 119-121)
    static string Newlines(string text) => text.Replace("|", "\n");

    static string Fixed(int value)
    {
        var a = System.Math.Abs(value);
        return (value < 0 ? "-" : "") + a / 10 + "." + a % 10;
    }

    // 作者 DLC 未做中文本地化的遗留(数据表有权威译名)
    static void LocalizeKnownWar(warinwars w)
    {
        if (w.name_war == "Война за Огаден") w.name_war = " 欧加登战争";
        if (w.side1 == "Сомали") w.side1 = " 索马里";
        if (w.side2 == "Эфиопия") w.side2 = " 埃塞俄比亚";
    }
}
