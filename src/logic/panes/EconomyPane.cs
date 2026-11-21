// 经济界面: 直接接管原版 Unity 组件层.
//   显示 = Show_diplomacy_data_script 替身(按 num/标志调原版 Repaint*), 读回 TextMesh;
//   动作 = Plusmisnus_script 替身(预算 71..81 / 贷款 69 / 储蓄金 36)调原版 OnMouseDown.
// 这里不复制任何数值公式.
using System.Collections.Generic;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class EconomyPane : IPanel
{
    public string Name => "经济";

    // 原版 data[71..81] 的十一项预算分配(界面按钮顺序).
    static readonly int[] BudgetSlots =
    {
        71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81,
    };

    // 显示项: 键 → (data 索引, 原版 Repaint 方法, planka_gosdolg)
    static readonly (string Key, int Num, string Method, bool PlankaGosdolg)[] Displays =
    {
        ("industry", 12, "Repaint2", false),
        ("agriculture", 13, "Repaint2", false),
        ("service", 68, "Repaint2", false),
        ("corruption", 26, "Repaint2", false),
        ("loan", 69, "Repaint2", false),
        ("savings", 36, "Repaint2", false),
        ("debt_loss", 0, "Repaint_dolg", false),
        ("debt_limit", 0, "Repaint_dolg", true),
        ("corruption_loss", 0, "Repaint_corrupt", false),
        ("max_investment", 0, "MakePlankaReady", false),
        ("savings_influence", 0, "ReserveRepaint", false),
        ("oligarch", 0, "Repaint_olyga", false),
    };

    static readonly Dictionary<string, Stub> DisplaysCache = new();
    static Stub _plankaCheck;

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        EnsureHost();

        var snapshot = new PanelSnapshot();
        foreach (var display in Displays)
        {
            snapshot.Put(display.Key, ReadDisplay(display.Key, display.Num, display.Method, display.PlankaGosdolg));
        }

        // 11 项预算按界面按钮顺序给文本(下标即按钮顺序, 视图不再做编号映射)
        var budgetTexts = new List<object>(BudgetSlots.Length);
        for (var i = 0; i < BudgetSlots.Length; i++)
        {
            budgetTexts.Add(ReadDisplay("budget" + i, BudgetSlots[i], "Repaint2", false));
        }
        snapshot.Put("budget_texts", budgetTexts);
        snapshot.Put("tips", BuildTips(state));
        return snapshot.Build();
    }

    // 原版经济界面的悬停提示: 数值项显示"两周内变化"(data_old),
    // 预算项显示 other_text[339..349] 的预算说明({0} 为原版换行占位).
    static Dictionary<string, object> BuildTips(GameState state)
    {
        var tips = new Dictionary<string, object>
        {
            ["industry"] = "两周内: " + Fixed(state.data_old[12]),
            ["agriculture"] = "两周内: " + Fixed(state.data_old[13]),
            ["service"] = "两周内: " + Fixed(state.data_old[68]),
            ["corruption"] = "两周内: " + Fixed(state.data_old[26]),
            ["loan"] = "两周内: " + Fixed(state.data_old[69]),
            ["savings"] = "两周内: " + Fixed(state.data_old[36]),
        };
        var other = GameHost.Global.other_text;
        for (var i = 0; i < BudgetSlots.Length; i++)
        {
            tips["budget" + i] = (other[339 + i] ?? "").Replace("{0}", "\n");
        }
        return tips;
    }

    static string Fixed(int value)
    {
        var a = System.Math.Abs(value);
        return (value < 0 ? "-" : "") + a / 10 + "." + a % 10;
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "预算":
                Press((int)(long)args[0], (bool)args[1], 71);
                break;
            case "贷款":
                Press(69, (bool)args[0], 69, gosdolg: true);
                break;
            case "储蓄金":
                Press(36, (bool)args[0], 36, reserv: true);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "经济面板没有该动作");
        }
    }

    // 原版 Plusmisnus_script 替身: this_number = data 下标, minus/gosdolg/reserv/payment 按场景配置.
    static void Press(int index, bool minus, int baseSlot, bool gosdolg = false, bool reserv = false)
    {
        EnsureHost();
        var stub = Stub.Take<Plusmisnus_script>("Budget_" + baseSlot + "_" + index + "_" + minus, Lifecycle.Lazy);
        stub.Also<SpriteRenderer>();
        stub.Set("this_number", gosdolg || reserv ? baseSlot : 71 + index);
        stub.Set("minus", minus);
        stub.Set("gosdolg", gosdolg);
        stub.Set("reserv", reserv);
        stub.Set("payment", !gosdolg && !reserv && baseSlot + index == 75);

        stub.Invoke("OnMouseDown");
    }

    // Plusmisnus_script.Awake 用 GameObject.Find("planka_dolg(clone)") 取显示脚本:
    // 必须先把这个原版对象替身放进场景.
    static void EnsureHost()
    {
        if (_plankaCheck != null) return;
        // 原版 Awake 里 text/okno 都用 GetComponent 取, 场景对象必须挂这两个组件,
        // 否则 Awake 内 Repaint 对 null text 写入会直接 NRE(整个经济面板快照失败, 界面停在 .tscn 占位值).
        _plankaCheck = Stub.Take<Show_diplomacy_data_script>("planka_dolg(clone)", Lifecycle.Scene);
        _plankaCheck.Set("text", _plankaCheck.Also<TextMesh>());
        _plankaCheck.Also<OkoshkoScript>();
        _plankaCheck.Activate();
    }

    static string ReadDisplay(string key, int num, string method, bool plankaGosdolg)
    {
        if (!DisplaysCache.TryGetValue(key, out var stub))
        {
            // 同上: 先挂 TextMesh/OkoshkoScript 再起 Awake, 让原版 Repaint* 有 text 可写
            stub = Stub.Take<Show_diplomacy_data_script>("Show_" + key, Lifecycle.Scene);
            stub.Set("text", stub.Also<TextMesh>());
            stub.Also<OkoshkoScript>();
            stub.Set("num", num);
            stub.Set("planka_gosdolg", plankaGosdolg);
            stub.Set("gosdolg", method == "Repaint_dolg");
            stub.Set("corruption", method == "Repaint_corrupt");
            stub.Set("planka", method == "MakePlankaReady");
            stub.Set("reserve", method == "ReserveRepaint");
            stub.Set("olyga", method == "Repaint_olyga");
            stub.Activate();
            DisplaysCache[key] = stub;
        }
        stub.Invoke(method);
        return ((TextMesh)stub.Get("text")).text;
    }
}
