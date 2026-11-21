// ============================================================
// 逻辑层 — Automation: 周期型互动按钮 / 决议的自动执行
//
// 玩家反馈: 外交面板的互动按钮、决议列表里有一批"每 N 月/年可再做一次"的条目,
// 忘了按就永久错过窗口。这里在时间推进时替玩家按一遍。
//
// 判定全部来自原版, 本文件不含任何数值/条件公式:
//   · 互动按钮: DiploButtonScript.Show() 算出的 is_active + uslovie_bool[],
//     以及 OnMouseDown() 开头(7419 行起)自带的同一组守卫。
//   · 决议:     Decision.condition()(原版 DecisionButtonScript.ChangeCondition 的判定)
//     + completedDecisions[](原版 DecisionButtonScript.OnMouseDown 的判定)。
//   · 冷却:     TimeScript.cs:2227 起每月递减 desnull[]、按 %3/%6 复位按钮门禁,
//     归零后把 completedDecisions 复位; 本文件不记任何计时器, 只跟着原版走。
//
// 开关是"类别"级的(见 Categories): 设置页的勾列表和外交面板按钮旁的勾是同一份数据,
// 默认全关, 玩家勾了才跑; 勾选结果由 GDScript 侧写进 playerprefs(逻辑层不读配置)。
//
// 触发时机: 月份变化(原版在月初 1 号的日结算里复位按钮门禁、递减决议冷却),
// 每月只跑一轮; 一轮扫描按 12 国/帧 分帧, 允许跨天扫完。
//
// 防呆(玩家原话: 所需资源不够了还一直自动化):
//   · 每个国家都是 Show → 读条件 → 全 true 才 Activate 的原子操作, 不绕过原版守卫;
//   · 一轮扫描里每个(国家, 槽位)最多执行一次, 绝不"循环点到失败";
//   · 会切场景 / 会开战的 type 不在 Categories 里, 连勾都勾不到。
// ============================================================
using System.Collections.Generic;

namespace CML.Logic;

public static class Automation
{
    // 可自动的类别 = 原版 DiploButtonScript 的一个 this_type。
    // 收进来的都是"有次数门禁、不做就错过"的那批: 每三月 / 每半年 / 每年 / 本月 / 本年。
    // 逐条依据是 Show() 里 uslovie_text 的字面量 + TimeScript 月初复位的那几个字段:
    //   7 恢复被破坏的沟通机构(每三月, allcountries[7].dev)
    //   8 支持伊朗革命中所选派系(每三月, allcountries[8].stab)
    //   20 派遣解放军增援前线-越南(本月未达三次)
    //   21 支持阿富汗所选势力(每三月, allcountries[24].stab, 原版文案写的"本年")
    //   28 支持东部游击武装(本月尚未支持)
    //   34 邀请外国投资者(本年尚未吸引)
    //   56 支持毛派游击武装 / 支持伊拉克武装反对派(本年+半年)
    //   71 派遣解放军增援前线-印度(本月未达三次)
    //   1009 支持法国共产党内部的正统派(一年一次)
    //   1024 督促社会改革/支持工党左派等(半年/一年一次, allcountries[112].cw)
    //   1043 支持拉美非洲左翼游击: 危地马拉左翼游击队、桑地诺人民革命、莫桑比克解放阵线等(半年)
    //   1044 支持拉美非洲右翼武装: 莫桑比克全国抵抗运动、上帝祖国民主等(半年)
    //   1057 干预乌干达内战(每年一次)
    //   1061 援助缅甸共产主义游击队(每年一次)
    // 刻意收不进来(执行会 LoadScene 或直接开战):
    //   1 支持毛派组织(置 war_active), 2 武力占领港澳, 3/14/35/46/49/55/58/70/94/95/109/114/115/116/138
    //   与 1000..1063 里的切场景档(含 1022 阿湾人阵、1063 缅甸), 15/30/122/123 直接开战。
    static readonly int[] Categories =
    {
        7, 8, 20, 21, 28, 34, 56, 71, 1009, 1024, 1043, 1044, 1057, 1061,
    };

    // 周期型决议(GlobalScript.CreateDecisions 的数组下标): Oncein/DoTimer(6 个月) 那 10 条,
    // 冷却归零后由 TimeScript 复位 completedDecisions; 都不含 StartEvent, 不会把玩家拽进事件场景。
    static readonly HashSet<int> AutoDecisions = new() { 24, 25, 26, 27, 28, 29, 30, 31, 32, 34 };

    // 玩家勾上的类别; 默认空 = 全关(玩家原话: 自动化默认关闭, 勾选后持久保存)
    static readonly HashSet<int> Enabled = new();

    static Port.DiploSet _set;
    static int _lastMonth = -1;
    static bool _scanning;
    static int _cursor;

    // 本轮已执行的条数, 供 UI 显示"自动化干了什么"
    public static int Launched { get; private set; }

    public static bool DecisionEnabled { get; private set; }

    public static bool IsAutoable(int type) => System.Array.IndexOf(Categories, type) >= 0;

    public static bool IsAutoableDecision(int index) => AutoDecisions.Contains(index);

    public static bool IsEnabled(int type) => Enabled.Contains(type);

    public static void ToggleType(int type)
    {
        if (!Enabled.Remove(type)) Enabled.Add(type);
    }

    public static void ToggleDecision() => DecisionEnabled = !DecisionEnabled;

    // 勾选状态的真值在本类; GDScript 只是把它抄到 playerprefs, 启动时再抄回来
    public static string TypesString() => string.Join(",", Enabled);

    public static void SetTypesString(string text)
    {
        Enabled.Clear();
        foreach (var part in text.Split(',', System.StringSplitOptions.RemoveEmptyEntries))
            Enabled.Add(int.Parse(part));
    }

    public static void SetDecision(bool on) => DecisionEnabled = on;

    public static void Reset()
    {
        _lastMonth = -1;
        _scanning = false;
        _cursor = 0;
        Launched = 0;
    }

    public static void Tick()
    {
        var state = GameHost.State;
        if (GameHost.Speed <= 0) return;
        if (Enabled.Count == 0 && !DecisionEnabled) return;

        // 原版按钮门禁在月初 1 号的日结算里复位(TimeScript.cs:2227 三的倍数 / 2240 六的倍数),
        // 决议冷却也每月递减并复位 completedDecisions(2289 起)。用"月份变化"触发:
        // 掉帧或暂停跨过 1 号, 恢复后仍会补上这一轮; 扫慢跨到 2 号也行 —— 门禁复位后
        // 要三个月才再关上。每月只触发一次, 同一批按钮不会在一轮里被按两遍。
        var month = state.data[21] * 100 + state.data[20];
        if (month != _lastMonth)
        {
            _lastMonth = month;
            _scanning = false;
            StartRound();
            return;
        }
        if (_scanning) ScanStep();
    }

    static void StartRound()
    {
        Launched = 0;
        // 决议先跑: 冷却 6 个月, 窗口比互动按钮(每月/每三月)稀有, 先吃满资源门槛。
        RunDecisions();
        _cursor = 0;
        _scanning = Enabled.Count > 0;
        if (!_scanning) LogRound();
    }

    static void ScanStep()
    {
        var state = GameHost.State;
        // 与地图"可互动淡金高亮"的分帧节流同档(见 MapPane.ScanInteractive): 每帧 12 国, 兼顾 3ms 上限
        var deadline = Godot.Time.GetTicksUsec() + 3000;
        var done = 0;
        while (_cursor < state.allcountries.Length)
        {
            var index = _cursor++;
            // 只扫"地图点得到的自己": 别名索引(111→92 等)在 地图.gd 里已被解析,
            // 重复扫会把同一个国家的按钮按两遍。
            if (Panes.MapPane.ResolveCountry(state, index) == index)
            {
                ScanCountry(index);
                done++;
            }
            if (done >= 12 || Godot.Time.GetTicksUsec() >= deadline) return;
        }
        _scanning = false;
        LogRound();
    }

    // 一轮一条: 让玩家(和排查)确认本月到底跑没跑、按掉了几项
    static void LogRound()
    {
        var state = GameHost.State;
        Godot.GD.Print($"[Automation] {state.data[21]}年{state.data[20]}月 自动执行 {Launched} 项");
    }

    static void ScanCountry(int index)
    {
        _set ??= Port.DiploHost.Build("Auto");
        var icons = new List<object>();
        var buttons = new List<object>();
        Port.DiploHost.Show(_set, index, icons, buttons, out _);

        for (var slot = 0; slot < buttons.Count; slot++)
        {
            var info = (Dictionary<string, object>)buttons[slot];
            if (!(bool)info["active"]) continue;
            var type = (int)info["type"];
            if (!Enabled.Contains(type)) continue;
            if (!AllConditionsMet((List<object>)info["conditions"])) continue;
            // 原版 OnMouseDown 会拿同一组 is_active/uslovie_bool 再验一次; 这里不重写它。
            Port.DiploHost.Activate(_set, slot);
            Launched++;
        }
    }

    static bool AllConditionsMet(List<object> conditions)
    {
        foreach (var condition in conditions) if (!(bool)condition) return false;
        return true;
    }

    static void RunDecisions()
    {
        if (!DecisionEnabled) return;
        var state = GameHost.State;
        var global = GameHost.Global;
        for (var i = 0; i < state.decisions.Length; i++)
        {
            if (!AutoDecisions.Contains(i)) continue;
            if (state.completedDecisions[i]) continue;
            var decision = state.decisions[i];
            if (!global.dlc[decision.version]) continue;
            if (!decision.condition()) continue;
            decision.active();
            state.completedDecisions[i] = true;
            Launched++;
        }
    }
}
