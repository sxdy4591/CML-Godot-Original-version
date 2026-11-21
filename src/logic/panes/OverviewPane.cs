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

    // 修正列表: 激活项在前, 其余按槽号补到 60 条(旧版概览上限).
    // 名称/描述 = 原版 ModifyButtonScript.ChangeText(含动态数值与颜色);
    // 图标名 = 原版 ChangeIcon 的资源名规则.
    static List<object> BuildModifiers(GameState state)
    {
        var shown = new List<int>();
        for (var i = 0; i < state.modifies.Length; i++)
        {
            if (state.modifies[i].active) shown.Add(i);
        }
        for (var i = 0; i < state.modifies.Length && shown.Count < 60; i++)
        {
            if (!state.modifies[i].active) shown.Add(i);
        }

        var modifiers = new List<object>(shown.Count);
        foreach (var i in shown)
        {
            var active = state.modifies[i].active;
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
