// ============================================================
// 地图界面: 着色取原版材质双色 CountryScript.Repaint 的 _MainColor/_MainColor2,
// 单色近似规则与旧项目一致(主色为默认黑时取副色), 避免只取主色导致大片发黑.
// 领土块 = 原版 Country.parts[]; 战争图标 = 原版 at_war_script.Repaint.
// index_map 是原版 Repaint 内部的历史变体映射(只读 GameState).
// ============================================================
using System.Collections.Generic;
using Godot;
using UnityEngine;
using Color = Godot.Color;

namespace CML.Logic.Panes;

public sealed class MapPane : IPanel
{
    public string Name => "地图";

    const int AntarcticaIndex = 162;

    static Stub _probe;
    static long _cachedKey = -1;
    static List<object> _cachedColors;
    static List<object> _cachedIndexMap;

    // ===== 可互动国家(地图淡金脉冲高亮) =====
    // 判据同原版: 该国面板里有一个可点击的"特殊互动"按钮(排除通用外交按钮 24/10/19).
    // 扫描由桥层每帧泵送(UiBridge._Process → Tick): 每帧最多 12 国, 约 0.25s 扫完一轮.
    // 只在地图场景里跑(Active), 结果有变化时经 map_highlight 信号推给视图.
    // 用的是 DiploHost.Scan 这套独立替身, 与玩家打开的国家面板(Ui)互不干扰,
    // 所以面板打开期间照常扫描、不清空高亮 —— "按钮不可用仍在地图上闪"的旧问题,
    // 靠每轮重新判定解决, 而不是停扫.
    static readonly HashSet<int> Interactive = new();
    static int _scanCursor;
    static bool _dirty;

    // 地图场景在用时为 true; 切到别的界面就停扫(不白烧 CPU, 保留上一轮结果)
    public static bool Active;

    // 桥层每帧调用
    public static void Tick()
    {
        if (!Active || !GameHost.Booted) return;
        TickOnce(GameHost.State, 12);
    }

    // 逐国推进扫描. budget = 本次最多扫几个"自己"(别名索引跳过, 不计入).
    // 同时限 3ms/帧(至少推进 1 国), 与 Automation 的分帧节流同档, 避免快照外的每帧扫描卡帧.
    static void TickOnce(GameState state, int budget)
    {
        var total = System.Math.Min(state.allcountries.Length, 200);
        if (total <= 0) return;
        var deadline = Godot.Time.GetTicksUsec() + 3000;
        var speed = GameHost.Global.speed;
        var scanned = 0;
        var guard = 0;
        while (scanned < budget && guard < total)
        {
            guard++;
            if (_scanCursor >= total) _scanCursor = 0;
            var idx = _scanCursor;
            _scanCursor = (_scanCursor + 1) % total;
            // 别名索引(111→92 等)在地图上点出来显示的是目标国, 这里只扫"自己":
            // 否则同一个国家会被两套 this_number 各判一次, 高亮与面板对不上.
            if (ResolveCountry(state, idx) != idx) continue;
            scanned++;

            var icons = new List<object>();
            var buttons = new List<object>();
            Port.DiploHost.Show(Port.DiploHost.Scan, idx, icons, buttons, out _);
            if (HasSpecialInteractive(buttons))
            {
                if (Interactive.Add(idx)) _dirty = true;
            }
            else if (Interactive.Remove(idx)) _dirty = true;
            if (Godot.Time.GetTicksUsec() >= deadline) break;
        }
        GameHost.Global.speed = speed;
    }

    // "可点击"= is_active 且 uslovie_bool 全真(同原版 OnMouseDown 开头的守卫).
    // 24 发展贸易 / 10 经济合作 / 19 军事同盟 是每个国家都有的通用项, 不算可互动,
    // 否则整张地图都会亮.
    static bool HasSpecialInteractive(List<object> buttons)
    {
        foreach (var item in buttons)
        {
            var button = (Dictionary<string, object>)item;
            if (!(bool)button["active"]) continue;
            var type = (int)button["type"];
            if (type == 24 || type == 10 || type == 19) continue;
            var allOk = true;
            foreach (var condition in (List<object>)button["conditions"])
            {
                if (!(bool)condition)
                {
                    allOk = false;
                    break;
                }
            }
            if (allOk) return true;
        }
        return false;
    }

    // 桥层在 Tick 之后取"这一帧高亮集合有没有变", 变了才推信号, 避免每帧全量重设 modulate
    public static bool ConsumeDirty()
    {
        var dirty = _dirty;
        _dirty = false;
        return dirty;
    }

    public static List<object> HighlightList() => InteractiveList();

    // 互动(发展贸易/经济合作等)会改原版 CountryScript.Repaint 的着色,
    // 但日期/地图模式没变, 缓存不失效就会一直用旧颜色 —— 动作后由调用方清掉.
    public static void InvalidateColors() => _cachedKey = -1;

    static List<object> InteractiveList()
    {
        var list = new List<object>(Interactive.Count);
        foreach (var index in Interactive) list.Add(index);
        return list;
    }

    // 调试控制台 highlight 命令: 打印当前判定的可互动国家集合
    public static string InteractiveText()
    {
        var names = new List<string>();
        foreach (var index in Interactive)
        {
            names.Add(index + ":" + GameHost.State.allcountries[index].name);
        }
        names.Sort();
        return names.Count == 0 ? "无可互动国家" : string.Join("; ", names);
    }

    // 调试控制台 highlight <国家号>: 打印该国每个可见互动按钮的类型与条件标记,
    // 用来核对"面板里看着可点、地图却不亮"到底是哪条判定没通过(通用项也会列出来).
    public static string ButtonDetail(int index)
    {
        var state = GameHost.State;
        if (index < 0 || index >= state.allcountries.Length) return "国家号越界";
        var icons = new List<object>();
        var buttons = new List<object>();
        Port.DiploHost.Show(Port.DiploHost.Scan, index, icons, buttons, out _);
        var lines = new List<string>();
        foreach (var item in buttons)
        {
            var button = (Dictionary<string, object>)item;
            if (!(bool)button["active"]) continue;
            var marks = new List<string>();
            foreach (var condition in (List<object>)button["conditions"]) marks.Add((bool)condition ? "✓" : "✗");
            var mark = marks.Count == 0 ? "无" : string.Join("", marks);
            lines.Add($"类型{button["type"]}「{button["text"]}」条件[{mark}]");
        }
        var head = $"{index}:{state.allcountries[index].name}";
        return lines.Count == 0 ? head + " → 无可见互动按钮" : head + " → " + string.Join("; ", lines);
    }
    static readonly List<(int Num, bool Special)> WarIcons = new();
    static readonly List<Stub> WarProbes = new();

    public Dictionary<string, object> Snapshot()
    {
        var global = GameHost.Global;
        var state = GameHost.State;
        var mode = global.map_type;
        // 进场景/切地图模式时先推一批, 快照里就有初步高亮; 其余国家由每帧 Tick 补齐
        TickOnce(state, 12);

        // 200 国逐个跑原版 Repaint 很重(进外交场景会卡一下); 颜色只随"日期+地图模式"变化,
        // 同一日期内复用缓存, 切场景/重进外交直接命中.
        var dayKey = state.data[21] * 10000 + state.data[20] * 100 + state.data[19];
        var cacheKey = mode * 100000000L + dayKey;
        if (_cachedKey != cacheKey)
        {
            _cachedColors = new List<object>(state.allcountries.Length);
            _cachedIndexMap = new List<object>(state.allcountries.Length);
            for (var i = 0; i < state.allcountries.Length; i++)
            {
                _cachedIndexMap.Add(ResolveCountry(state, i));
                var pair = ColorsOf(state, i);
                _cachedColors.Add(new Dictionary<string, object>
                {
                    ["main"] = pair.Main,
                    ["minus"] = pair.Minus,
                });
            }
            _cachedKey = cacheKey;
        }

        return new PanelSnapshot()
            .Put("mode", mode)
            .Put("colors", _cachedColors)
            .Put("index_map", _cachedIndexMap)
            .Put("parts", BuildVisibleParts(state))
            .Put("wars", BuildVisibleWars(state))
            .Put("highlight", InteractiveList())
            // 分裂出来的小国(南苏丹/达尔富尔等)在场景里只是母国的一个 part 块,
            // 视图按名字把 part 归到真正的国家索引(上色/点击都用它).
            .Put("names", CountryNames(state))
            .Build();
    }

    static List<object> CountryNames(GameState state)
    {
        var names = new List<object>(state.allcountries.Length);
        for (var i = 0; i < state.allcountries.Length; i++) names.Add(state.allcountries[i].name ?? "");
        return names;
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "设置模式":
                GameHost.Global.map_type = (int)(long)args[0];
                break;
            case "激活":
                // 地图场景进出: 进场景清掉上一轮的旧判定, 立刻扫一批让随后那份快照带上当前结果
                Active = (bool)args[0];
                if (Active && GameHost.Booted)
                {
                    Interactive.Clear();
                    _scanCursor = 0;
                    _dirty = false;
                    TickOnce(GameHost.State, 12);
                }
                break;
            case "登记战争图标":
                RegisterWarIcons((List<object>)args[0]);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "地图面板没有该动作");
        }
    }

    // 原版 CountryScript.Repaint 写 _MainColor / _MainColor2(双色 shader),
    // 视图用 国家着色.gdshader 逐像素算 out = t + t*(main-minus) - 0.09.
    static (Color Main, Color Minus) ColorsOf(GameState state, int index)
    {
        if (_probe == null)
        {
            Port.DiploHost.Ensure();
            _probe = Stub.Take<CountryScript>("MapColorProbe", Lifecycle.None);
            _probe.Also<SpriteRenderer>();
            _probe.Set("grey", new Sprite { name = "grey" });
        }
        _probe.Set("this_number", index);
        _probe.Invoke("Repaint");
        var renderer = _probe.Also<SpriteRenderer>();
        var main = renderer.material.GetColor("_MainColor");
        var minus = renderer.material.GetColor("_MainColor2");
        return (new Color(main.r, main.g, main.b, 1f), new Color(minus.r, minus.g, minus.b, 1f));
    }

    // ================= 领土块 =================

    private static List<object> BuildVisibleParts(GameState state)
    {
        var parts = new List<object>();
        for (var country = 0; country < state.allcountries.Length; country++)
        {
            var slots = state.allcountries[country].parts;
            for (var part = 0; part < slots.Length; part++)
            {
                if (!slots[part]) continue;
                // 原版：南极洲(162) 的领土块整体隐藏
                if (country == AntarcticaIndex) continue;
                parts.Add(new Dictionary<string, object>
                {
                    ["country"] = country,
                    ["part"] = part,
                });
            }
        }
        return parts;
    }

    // ================= 战争图标 =================

    // 视图把节点上的 (war_num, special) 登记进来; 每个图标跑原版 at_war_script.Repaint 判显隐.
    static void RegisterWarIcons(List<object> icons)
    {
        WarIcons.Clear();
        WarProbes.Clear();
        foreach (var item in icons)
        {
            var icon = (Dictionary<string, object>)item;
            var num = (int)(long)icon["war"];
            var special = (bool)icon["special"];
            WarIcons.Add((num, special));

            var probe = Stub.Take<at_war_script>("WarIcon" + WarProbes.Count, Lifecycle.None);
            probe.Also<SpriteRenderer>();
            probe.Set("this_num", num);
            probe.Set("special", special);
            probe.Set("war", new Sprite { name = "war" });
            // 视图给的是 Godot 坐标(tscn 里 war_ogon 节点的 position = 原版世界坐标 *100, y 取反,
            // 父级 AllWars 偏移 -6.7373/2.933、缩放 0.128 已折算在内).
            // 反推回原版 localPosition, Repaint 才会在"未迁移"时原样留着、迁移时给出新坐标.
            var px = (float)(double)icon["x"];
            var py = (float)(double)icon["y"];
            probe.Go.transform.localPosition = new UnityEngine.Vector3(
                (px + 673.73f) / 12.8f, -(py + 293.3f) / 12.8f, 0f);
            WarProbes.Add(probe);
        }
    }

    private static List<object> BuildVisibleWars(GameState state)
    {
        var wars = new List<object>(WarIcons.Count);
        for (var i = 0; i < WarIcons.Count; i++)
        {
            var probe = WarProbes[i];
            // Repaint 会把 this_num 迁到别的战争号(2→34, 4→37, 16→71…), 不重置会跨帧漂移.
            probe.Set("this_num", WarIcons[i].Num);
            probe.Set("special", WarIcons[i].Special);
            probe.Invoke("Repaint");
            var renderer = probe.Also<SpriteRenderer>();
            if (renderer.sprite == null) continue;
            // 原版 Repaint 会把图标搬去新的 localPosition(如叙利亚内战 37 征用 3/8/29 号节点),
            // 这里把搬完的位置一起给视图, 否则图标永远停在初始国家上.
            var local = probe.Go.transform.localPosition;
            wars.Add(new Dictionary<string, object>
            {
                ["war"] = WarIcons[i].Num,
                ["special"] = WarIcons[i].Special,
                ["x"] = 12.8 * local.x - 673.73,
                ["y"] = -12.8 * local.y - 293.3,
            });
        }
        return wars;
    }

    // 原版 Repaint 里的国家变体映射(历史事件改变国旗与国名归属).
    // 地图着色、点选命中、自动化的扫描范围都用这一份, 不要各写一遍.
    internal static int ResolveCountry(GameState state, int index)
    {
        var n = index;

        if (n == 10 && state.data[83] == 2) n = 46;
        else if (n == 46 && state.data[83] == 1) n = 10;
        else if (n == 38 && state.completedDecisions[7]) n = 1;
        else if ((n == 54 || n == 55 || n == 18 || n == 14 || n == 35 || n == 30 || n == 13 || n == 40)
                 && state.completedDecisions[20]
                 && state.allcountries[30].parts[0]
                 && state.allcountries[30].parts[1]
                 && state.allcountries[30].parts[2])
        {
            n = 30;
        }

        if (n == 111)
        {
            if (state.allcountries[49].parts[0]) n = 49;
            else if (!state.event_done[118]) n = 92;
        }

        if (n == 142) n = AfterDate(state, 1981, 9, 21) ? 142 : 92;
        if (n == 161) n = AfterDate(state, 1978, 7, 7) ? 161 : 92;

        if (n == 106)
        {
            n = state.event_done[585] ? 106 : 21;
            if (n == 106 && state.allcountries[41].parts[1]) n = 41;
        }

        if (n == -2) n = state.BritLost ? 71 : 92;
        if (n == 18) n = state.allcountries[54].parts[0] ? 54 : 18;
        if (n == 22) n = state.allcountries[11].parts[0] ? 11 : 22;
        if (n == 42) n = (state.allcountries[41].parts[0] || state.allcountries[41].parts[1]) ? 41 : 42;
        if (n == 23) n = state.allcountries[11].parts[0] ? 11 : 23;
        if (n == 168) n = state.allcountries[168].cw ? 168 : 51;

        return n;
    }

    private static bool AfterDate(GameState state, int year, int month, int day)
    {
        var y = state.data[21];
        var m = state.data[20];
        var d = state.data[19];
        return y > year
            || (y == year && m > month)
            || (y == year && m == month && d >= day);
    }
}
