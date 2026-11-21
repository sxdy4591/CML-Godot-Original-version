// 科学界面: 接管原版 Science_Script 组件.
//   显示 = 原版 Repaint / RepaintPlashka 写出的 T1/T2/T3 与 galka 贴图(读回);
//   启动 = 原版 Science_Script.OnMouseDown.
// 元数据表(天/钱/年份/依赖)是原版 Science.unity 场景序列化值, 由 Port/ScienceData 提供.
using System;
using System.Collections.Generic;
using UnityEngine;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class SciencePane : IPanel
{
    public string Name => "科学";

    static readonly Stub[] Entries = new Stub[ScienceData.Count];
    static Stub _budgetDisplay;
    static Stub _dataDisplay;

    public Dictionary<string, object> Snapshot()
    {
        EnsureEntries();
        var items = new List<object>(ScienceData.Count);
        for (var i = 0; i < ScienceData.Count; i++)
        {
            var entry = Entries[i];
            // 原版: galka(可研究标记)只在 Repaint 里按依赖是否完成设置, 文案/进度在 RepaintPlashka;
            // 只调后者的结果是所有条目都停在 Awake 当时的"否".
            entry.Invoke("Repaint");
            entry.Invoke("RepaintPlashka");
            var done = GameHost.State.science[i];
            var inProgress = GameHost.State.science_in_progress[i] && !done;
            // 进度条分母取原版实际需求(science_need_time, 面板创建时已被 Awake 同步),
            // 已完成的项目按原版语义必然是"达到需求", 直接给满值 ——
            // 旧档里 science_time 小于后来同步的 need_time 时, 不会再出现"条没满却显示已完成".
            // 原版 Science_Script.Awake 会在进入界面时把 need_time 同步成面板需求;
            // 新局 GameStartScript 会把 need_time 清零, 而条目替身跨局复用、Awake 不会再跑,
            // 不补这一步就会出现"需求为 0 / 进度条空 / 点一下立刻完成"。
            if (GameHost.State.science_need_time[i] != ScienceData.Days[i])
                GameHost.State.science_need_time[i] = ScienceData.Days[i];
            var need = GameHost.State.science_need_time[i];
            var spent = GameHost.State.science_time[i];
            var available = CanStart(i);
            items.Add(new Dictionary<string, object>
            {
                ["index"] = i,
                ["completed"] = done,
                ["in_progress"] = inProgress,
                ["available"] = available,
                ["progress_max"] = need,
                ["progress_value"] = done ? need : spent,
                ["status"] = done ? "已完成" : inProgress ? "研究中" : ScienceData.Year[i].ToString(),
                // 勾 = 已完成 / 研究中 / 已投入 / 现在就能开始研究(依赖已满足); 叉 = 还不能研究.
                // 原版 galka 就是"依赖是否满足", 没研究但可开的也会打勾;
                // 能不能点仍由 available 决定, 不满足的原因写在 tip 里.
                ["galka"] = done || inProgress || spent > 0 || available ? "yes" : "no",
                ["tip"] = StatusTip(i, done, inProgress, available),
                ["name"] = ((TextMesh)entry.Get("T1")).text,
                ["cost"] = ((TextMesh)entry.Get("T2")).text,
                ["desc"] = ((TextMesh)entry.Get("T3")).text,
            });
        }

        _budgetDisplay.Invoke("Repaint");
        return new PanelSnapshot()
            .Put("budget", ((TextMesh)_budgetDisplay.Get("text")).text)
            .Put("science_points", GameHost.State.data[11].ToString())
            .Put("items", items)
            .Put("dependencies", Dependencies())
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        var index = (int)(long)args[0];
        switch (action)
        {
            case "开始研究":
                EnsureEntries();
                Entries[index].Invoke("OnMouseDown");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, "科学面板没有该动作");
        }
    }

    // 原版 RepaintPlashka 的"可研究"判据(与 OnMouseDown 前置一致)
    // 条目悬停文案: 为什么现在不能研究(原版 OnMouseDown 的前置条件)
    static string StatusTip(int index, bool done, bool inProgress, bool available)
    {
        var state = GameHost.State;
        if (done) return "研究完成";
        if (inProgress) return "研究中";
        if (state.science_time[index] > 0) return "已投入科研点，等待继续";
        if (index == 17 && state.data[118] == 0) return "需先宣告建设全面自动化";
        for (var i = 0; i < state.science_in_progress.Length; i++)
            if (state.science_in_progress[i] && !state.science[i]) return "同时只能研究一项（已有项目在研）";
        if (ScienceData.Dependency[index] >= 0 && !state.science[ScienceData.Dependency[index]])
            return "需先完成前置科技";
        return available ? "可研究，点击开始" : "";
    }

    static bool CanStart(int index)
    {
        var state = GameHost.State;
        if (state.science[index] || state.science_in_progress[index] || state.science_time[index] > 0) return false;
        if (index == 17 && state.data[118] == 0) return false;
        for (var i = 0; i < state.science_in_progress.Length; i++)
        {
            if (state.science_in_progress[i] && !state.science[i]) return false;
        }
        var dep = ScienceData.Dependency[index];
        return dep < 0 || state.science[dep];
    }

    static void EnsureEntries()
    {
        if (Entries[0] != null) return;

        // 原版 Science_Script.OnMouseDown 结尾调用 data_sh.Repaint();
        // Politic_Show_Data.Start 会用 GetComponent<TextMesh>() 覆盖 text, 这里自己给 text, 所以声明 None.
        _dataDisplay = Stub.Take<Politic_Show_Data>("ScienceData", Lifecycle.None);
        _dataDisplay.Set("num", 8);
        _dataDisplay.Set("text", new TextMesh());

        // 顶部预算 = Politic_Show_Data(num=8), 原版 /10.0 F1
        _budgetDisplay = Stub.Take<Politic_Show_Data>("ScienceBudget", Lifecycle.None);
        _budgetDisplay.Set("num", 8);
        _budgetDisplay.Set("text", new TextMesh());

        for (var i = 0; i < ScienceData.Count; i++)
        {
            // Lazy: 首次 Invoke 前跑原版 Awake(shkala_mat/text 已绑), 不靠调用方记得补.
            var entry = Stub.Take<Science_Script>("Science" + i, Lifecycle.Lazy);
            entry.Set("number", i);
            entry.Set("days", ScienceData.Days[i]);
            entry.Set("money", ScienceData.Money[i]);
            entry.Set("data", ScienceData.Year[i]);
            entry.Set("number_zavisimost", ScienceData.Dependency[i]);
            entry.Set("text", new TextMesh());
            entry.Set("T1", new TextMesh());
            entry.Set("T2", new TextMesh());
            entry.Set("T3", new TextMesh());
            entry.Set("galka", new SpriteRenderer());
            entry.Set("shkala", new SpriteRenderer());
            entry.Set("yes", new Sprite { name = "yes" });
            entry.Set("no", new Sprite { name = "no" });
            entry.Set("data_sh", dataDisplayComponent());
            Entries[i] = entry;
        }
    }

    static Politic_Show_Data dataDisplayComponent() => _dataDisplay.Typed<Politic_Show_Data>();

    static List<object> Dependencies()
    {
        var list = new List<object>();
        for (var i = 0; i < ScienceData.Count; i++)
        {
            var dependency = ScienceData.Dependency[i];
            if (dependency < 0) continue;
            list.Add(new Dictionary<string, object>
            {
                ["from"] = dependency,
                ["to"] = i,
            });
        }
        return list;
    }
}
