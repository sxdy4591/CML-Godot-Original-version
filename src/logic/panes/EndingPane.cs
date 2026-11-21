// 结局面板: 原版 EndingScript 生成坏结局/胜利后日谈, 原版 EndingN 生成三个地区卷宗.
using System;
using System.Collections.Generic;
using System.Reflection;
using EndingsDLCDraft;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class EndingPane : IPanel
{
    public string Name => "结局";

    const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    // 原版 SwitchEndingScript.num = 0..3: 0 本篇 / 1..3 三个 DLC 卷宗.
    // 页数: 本篇 15(EndingScript.OnMouseDown 的 0..14), 卷宗 8/7/7,
    // 卷宗类号: Ending1-8 / Ending10-16 / Ending17-23.
    static readonly string[] 卷宗名 = { "本篇", "中东非洲", "美洲亚太", "欧洲" };
    static readonly int[] 卷宗页数 = { 15, 8, 7, 7 };
    static readonly int[] 卷宗首类 = { 0, 1, 10, 17 };

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        var number = state.data[35];
        // 原版 BadEnding 只实现 data[35] = 1..13, 其余值走胜利判定(原版 DoneEnding 的 <= 0 分支)
        var bad = number >= 1 && number <= 13;

        var panels = new List<object> { Panel(0, true, 本篇(bad)) };
        if (!bad)
            for (var panel = 1; panel < 4; panel++)
                panels.Add(Panel(panel, GameHost.Global.dlc[panel], 卷宗(panel)));

        return new PanelSnapshot()
            .Put("bad", bad)
            .Put("number", number)
            .Put("panels", panels)
            .Build();
    }

    public void Act(string action, List<object> args)
        => throw new ArgumentOutOfRangeException(nameof(action), action, "结局面板没有动作");

    static Dictionary<string, object> Panel(int index, bool enabled, List<object> pages) => new()
    {
        ["name"] = 卷宗名[index],
        ["enabled"] = enabled,
        ["pages"] = pages,
    };

    static List<object> 本篇(bool bad)
    {
        var stub = 造脚本();
        var script = stub.Typed<EndingScript>();
        var pages = new List<object>();

        if (bad)
        {
            stub.Invoke("BadEnding");
            pages.Add(页(stub, 0, 1));
            return pages;
        }

        for (var page = 0; page < 卷宗页数[0]; page++)
        {
            script.number_of_e = page;
            stub.Invoke("OnMouseDown");
            pages.Add(页(stub, page, 卷宗页数[0]));
        }
        return pages;
    }

    static List<object> 卷宗(int panel)
    {
        var pages = new List<object>();
        var count = 卷宗页数[panel];
        for (var page = 0; page < count; page++)
        {
            var type = typeof(EndingsSecond).Assembly.GetType("Ending" + (卷宗首类[panel] + page));
            // 结局类: Awake 在字段就位后由 Activate 起(与 doneventscript 的 AddComponent 语义一致)
            var script = Stub.Take(type, "结局卷宗", Lifecycle.Scene).Activate().Typed<Component>();

            var title = "";
            var body = "";
            var args = new object[] { title, body };
            type.GetMethod("TextOfEnding").Invoke(script, args);
            pages.Add(new Dictionary<string, object>
            {
                ["title"] = ((string)args[0]).Trim(),
                ["body"] = (string)args[1],
                ["label"] = $"{page + 1}/{count}",
            });
        }
        return pages;
    }

    static Dictionary<string, object> 页(Stub stub, int index, int count) => new()
    {
        ["title"] = stub.ReadText("name").Trim(),
        ["body"] = (string)stub.Get("fake_text"),
        ["label"] = $"{index + 1}/{count}",
    };

    // 原版 EndingScript 的替身: Awake 里 global1/achieves/startTextPosition 由场景提供,
    // 这里补齐 MakeScrollable 与成就写入需要的对象图, 直接调原版方法.
    static Stub 造脚本()
    {
        var stub = Stub.Take<EndingScript>("结局正文", Lifecycle.Lazy);
        stub.BindTexts("name", "text_t");
        stub.Set("scrollComponent", 造滚动条());
        stub.Set("achieves", 造成就());
        // 原版场景里 fon 是背景 SpriteRenderer、fon_win 是胜利背景图,
        // DoneEnding 的胜利分支会写 fon.sprite = fon_win(缺了就 NRE, 整段结局文本都不生成).
        stub.Set("fon", stub.Also<SpriteRenderer>());
        stub.Set("fon_win", new Sprite { name = "fon_win" });
        return stub;
    }

    static GameObject 造滚动条()
    {
        var go = new GameObject("结局滚动");
        var scroll = Stub.On<ScrollScript>(go, Lifecycle.None).Typed<ScrollScript>();

        scroll.up = new GameObject("上");
        scroll.down = new GameObject("下");
        return go;
    }

    static GameObject 造成就()
    {
        var go = new GameObject("Ach(Clone)");
        var ach = Stub.Attach<achievements>(go);

        ach.ach_this = new bool[1000];
        return go;
    }
}
