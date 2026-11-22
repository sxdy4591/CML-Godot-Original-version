// ============================================================
// 逻辑层 — OverviewPane: 概览界面（六页：交易/影响/领土/形势/凝聚力/盟友）
//
// 六页内容全部由原版 modify_choose.OnMouseDown 逐字生成（含文案、百分比、
// 增减量），这里只负责：造替身 → 调原版 → 把 TextMesh 里的结果读出来。
// 不复制任何公式。
//
// 快照契约：
//   page_count   int        页数（固定 6）
//   chinese_page int        原版 ChinesePage（0=世界影响力/老朋友，1=苏美资金/非洲联盟）
//   pages        Array[Dictionary]  每页 { columns: Array[{name, text}] }
//                                    columns 已按原版"空串=该列未用"过滤
// 动作：
//   toggle_page             切换 ChinesePage（原版 modify_choose 末尾的翻页）
// ============================================================
using System.Collections.Generic;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class OverviewPane : IPanel
{
    public string Name => "概览";

    // 概览页序号 -> 原版 modify_choose.num_this.
    static readonly int[] PageIds = { 0, 1, 2, 4, 5, 6 };

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        var snapshot = new PanelSnapshot()
            .Put("page_count", PageIds.Length)
            .Put("chinese_page", state.ChinesePage);

        var pages = new List<object>(PageIds.Length);
        for (var i = 0; i < PageIds.Length; i++)
        {
            pages.Add(BuildPage(i));
        }
        snapshot.Put("pages", pages);
        snapshot.Put("modifiers", BuildModifiers(state));
        return snapshot.Build();
    }

    // 原版 Modify_iconsScript.CreateModifies(33-150) 的列表: 概览只显示这些编号的修正,
    // 顺序就是原版 Add 的顺序. 原版用 conditionOn 在"已生效/未生效"两个视图间切换,
    // 移植版同屏列出, 已生效在前. 不在白名单里的 modifies(焦点/事件直接写 active 的)
    // 原版概览不显示 —— 之前按全量 modifies 装配, 会把这类条目也列出来, 且编号 > 60 的
    // 条目在 ChangeText 里取 old_modify_texts[num] 会越界.
    static readonly int[] 概览修正 =
    {
        15, 0, 2, 3, 6, 11, 8, 59, 50, 47, 48,
        28, 29, 30, 31, 46,
        1, 4, 5, 7, 9, 10, 12, 13,
        16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
        33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44,
        49, 51, 52, 53, 54, 55, 56, 57, 60,
    };

    // 原版 ModifyButtonScript.ChangeText(24-584): 名称/描述占位符由原版 string.Format 生成;
    // 这里只把 okno1 里的 "名称|描述" 读出来, 不复制任何公式.
    static List<object> BuildModifiers(GameState state)
    {
        var modifiers = new List<object>(概览修正.Length);
        foreach (var pass in new[] { true, false })
        {
            foreach (var i in 概览修正)
            {
                var active = state.modifies[i].active;
                if (active != pass) continue;
                var (name, desc) = ModifierText(i, active);
                modifiers.Add(new Dictionary<string, object>
                {
                    ["id"] = i,
                    ["active"] = active ? 1 : 0,
                    ["icon"] = ModifierIcon(state, i, active),
                    ["name"] = name,
                    ["desc"] = desc,
                });
            }
        }
        return modifiers;
    }

    static readonly Dictionary<int, Stub> ModifierStubs = new();

    // 原版 ModifyButtonScript.ChangeText 写入 okno1 的 "名称|描述"
    static (string Name, string Desc) ModifierText(int num, bool active)
    {
        if (!ModifierStubs.TryGetValue(num, out var stub))
        {
            stub = Stub.Take<ModifyButtonScript>("Modifier" + num, Lifecycle.Lazy);
            var okno = new OkoshkoScript();
            Stub.Detach(okno);
            stub.Set("okno1", okno);

            ModifierStubs[num] = stub;
        }
        stub.Invoke("ChangeText", num, active);
        var okno1 = (OkoshkoScript)stub.Get("okno1");
        var full = okno1.text;
        var sep = full.IndexOf('|');
        return sep >= 0 ? (full[..sep], full[(sep + 1)..]) : (full, "");
    }

    // 原版 ModifyButtonScript.ChangeIcon(586-616) 的资源名规则
    static string ModifierIcon(GameState state, int num, bool active)
    {
        if (num == 44 && state.YugAgree) return active ? "15_1" : "55_1";
        if (num == 46 && state.allcountries[30].Gosstroy == 1 && active) return "";
        if (num == 28 && state.event_done[326] && state.resultOfEvents[326] == 0
            && state.modifies[3].active && state.modifies[6].active
            && state.data[50] <= 25 && state.data[15] == 6 && state.data[16] <= 11 && active)
        {
            return "";
        }
        return num <= 65 ? num + "_" + (active ? 0 : 1) : "";
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "toggle_page":
                // 原版 modify_choose.OnMouseDown 末尾按 ChinesePage 切换影响页/盟友页
                var state = GameHost.State;
                state.ChinesePage = state.ChinesePage == 1 ? 0 : 1;
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "概览面板没有该动作");
        }
    }

    static readonly Dictionary<int, Stub> PageStubs = new();

    private static Dictionary<string, object> BuildPage(int page)
    {
        if (!PageStubs.TryGetValue(page, out var stub))
        {
            stub = Stub.Take<modify_choose>("OverviewStub_" + page, Lifecycle.Lazy);
            stub.Also<SpriteRenderer>();
            stub.BindTexts(TextFieldNames());
            stub.Set("num_this", PageIds[page]);
            PageStubs[page] = stub;
        }
        stub.Invoke("OnMouseDown");

        // 原版用空串表示"该列本次未使用"，这里只做列装配，不改写文案。
        var columns = new List<object>(3);
        for (var i = 0; i < 3; i++)
        {
            var name = stub.ReadText($"Name_{i + 1}");
            var text = stub.ReadText($"Text_{i + 1}");
            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(text)) continue;
            columns.Add(new Dictionary<string, object>
            {
                ["name"] = name,
                ["text"] = text,
            });
        }
        return new PanelSnapshot().Put("columns", columns).Build();
    }

    private static string[] _textFieldNames;

    private static string[] TextFieldNames()
        => _textFieldNames ??= new[] { "Name_1", "Name_2", "Name_3", "Text_1", "Text_2", "Text_3" };
}
