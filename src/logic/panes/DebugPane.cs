// 调试控制台: 命令解析与执行在逻辑层, 视图只负责输入/显示.
// 数值口径与原版 GameState.data 一致(×10 内部单位), 命令输入的 ±值按显示单位换算.
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class DebugPane : IPanel
{
    public string Name => "调试";

    // 事件选项前置条件开关: 开启后 EventPane 忽略原版 VariantsOfEvents 里被 Destroy 掉的选项,
    // 全部按可点展示; 结算仍走事件类自己的 ResultsOfEvents, 文案由原版给出.
    public static bool ForceEventOptions;

    static readonly List<object> Lines = new();

    static void Log(string text)
    {
        Lines.Add(text);
        if (Lines.Count > 300) Lines.RemoveAt(0);
    }

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        return new PanelSnapshot()
            .Put("lines", Lines)
            .Put("date", $"{state.data[21]}年{state.data[20]}月{state.data[19]}日")
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "执行":
                Run((string)args[0]);
                break;
            case "作弊":
                Cheat((int)(long)args[0]);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, "调试面板没有该动作");
        }
    }

    // ================= 命令 =================

    static void Run(string raw)
    {
        var cmd = raw.Trim();
        if (cmd.Length == 0) return;
        Log("> " + cmd);
        var p = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var state = GameHost.State;
        switch (p[0].ToLowerInvariant())
        {
            case "help":
                Help();
                break;
            case "clear":
                Lines.Clear();
                break;
            case "date":
                state.data[19] = int.Parse(p[1]);
                state.data[20] = int.Parse(p[2]);
                state.data[21] = int.Parse(p[3]);
                Log($"日期 = {state.data[21]}-{state.data[20]}-{state.data[19]}");
                break;
            case "speed":
                GameHost.SetSpeed(int.Parse(p[1]));
                Log($"速度 = {GameHost.Speed}");
                break;
            case "event":
                Event(state, p);
                break;
            case "events":
            case "list_events":
                Events(p);
                break;
            case "evopt":
                ForceEventOptions = int.Parse(p[1]) != 0;
                Log($"事件选项前置条件限制 = {(ForceEventOptions ? "已解除(所有选项都能点)" : "恢复默认")}");
                break;
            case "money":
            case "party":
            case "people":
            case "thought":
            case "living":
            case "prestige":
            case "agents":
                Add(state, SlotOf(p[0]), int.Parse(p[1]));
                break;
            case "army":
                Add(state, 22, int.Parse(p[1]));
                break;
            case "influence":
                Add(state, 7, int.Parse(p[1]));
                break;
            case "rel":
                var empire = state.empires[int.Parse(p[1])];
                empire.relations = int.Parse(p[2]);
                // 关系值每天会被 KumihaRepaint 镜像进 data[28]/[29], 这里顺手写一份,
                // 免得改完当下事件条件还读着旧镜像值
                state.data[28 + int.Parse(p[1])] = empire.relations;
                Log($"关系[{p[1]}] = {empire.relations}");
                break;
            case "mod":
                state.modifies[int.Parse(p[1])].active = int.Parse(p[2]) != 0;
                Log($"修正 {p[1]} = {state.modifies[int.Parse(p[1])].active}");
                break;
            case "diff":
                state.diff = int.Parse(p[1]);
                Log($"难度 = {state.diff}");
                break;
            case "ironman":
                state.iron_and_blood = int.Parse(p[1]) != 0;
                Log($"铁人 = {state.iron_and_blood}");
                break;
            case "war":
                state.ingamewars[int.Parse(p[1])].is_going = true;
                Log($"战争 {p[1]} 已开启");
                break;
            case "list_wars":
                ListWars(state);
                break;
            case "terr":
            case "part":
                Territory(state, p);
                break;
            case "parts":
                Parts(state, int.Parse(p[1]));
                break;
            case "ideo":
                Ideology(state, p);
                break;
            case "ideos":
                Ideologies();
                break;
            case "doctr":
                Doctrine(state, p);
                break;
            case "doctrs":
                Doctrines(state);
                break;
            case "kill":
                Kill(state, p);
                break;
            case "pol":
                Politicians(state, p);
                break;
            case "save":
                Port.SaveService.Save(state, Port.SavePaths.Slot(int.Parse(p[1])));
                Log($"已保存到槽位 {p[1]}");
                break;
            case "load":
                GameHost.ReplaceState(Port.SaveService.Load(Port.SavePaths.Slot(int.Parse(p[1]))));
                UiEvents.RequestScene("Diplomacy");
                break;
            case "map":
                Log($"国家 {state.allcountries.Length} | 地图模式 {GameHost.Global.map_type} | 人口 {state.data[34]}");
                break;
            case "highlight":
                Log(MapPane.InteractiveText());
                break;
            case "faction":
                Faction(state);
                break;
            case "fac":
                FactionEdit(state, p);
                break;
            case "mods":
                LogMods(state);
                break;
            case "wars":
                LogWars(state);
                break;
            case "audio":
                AudioDiag();
                break;
            case "achreset":
                AchievementCenter.ResetAll();
                Log("成就解锁状态已重置(内存 + playerprefs)");
                break;
            case "cheat":
                Cheat(int.Parse(p[1]));
                break;
            case "gold":
                ShortcutPane.Run(231);
                Log($"金手指 = {ShortcutPane.GoldFinger}");
                break;
            case "pop":
                ShortcutPane.Run(230);
                Log($"人口 data[34] = {state.data[34]}");
                break;
            case "key":
                ShortcutPane.Run(int.Parse(p[1]));
                Log($"快捷键动作 {p[1]} 已执行");
                break;
            case "data":
                Data(state, p);
                break;
            case "field":
                Field(state, p);
                break;
            case "auto":
                Auto(p);
                break;
            default:
                Log($"未知命令: {p[0]}（输入 help）");
                break;
        }
    }

    static int SlotOf(string name) => name switch
    {
        "money" => 8,
        "party" => 1,
        "people" => 3,
        "thought" => 4,
        "living" => 5,
        "prestige" => 6,
        "agents" => 9,
        _ => throw new ArgumentOutOfRangeException(nameof(name), name, "没有该数值"),
    };

    static void Add(GameState state, int slot, int displayValue)
    {
        state.data[slot] += displayValue * 10;
        Log($"data[{slot}] = {state.data[slot]}（{state.data[slot] / 10f:0.0}）");
    }

    // ================= 强制触发事件 =================

    // event 编号: 原版政策/按钮链在 number_event 里写的那个数(Event{N} 类名同号).
    // 不带选项 = 照原版切进事件场景; 带选项 = 在此直接跑原版结算, 再跑原版结果页收尾.
    static void Event(GameState state, string[] p)
    {
        var number = int.Parse(p[1]);
        state.number_event = number;
        if (p.Length == 2)
        {
            UiEvents.RequestScene("Event");
            Log($"触发事件 {number}");
            return;
        }
        Settle(number, int.Parse(p[2]));
    }

    static void Settle(int number, int choice)
    {
        PanelRouter.TryGet("事件", out var panel);
        var events = (EventPane)panel;
        events.Snapshot();
        events.Act("选择", new List<object> { (long)choice });
        Log($"事件 {number} 选项 {choice} 结算: {Short(events.Result)}");
        events.Act("关闭", new List<object>());
    }

    // 事件文本只存在于 Event{N}.TextOfEvents 方法体里, 没有静态表; 检索只能实例化跑一次.
    // 编号不连续(2000 槽里只存在一部分类), 所以先用类型名建一张编号表.
    // 只收普通事件(EventsSecond 继承链): Event343 这类结局类没有 TextOfEvents 实现, 不在此列.
    static readonly HashSet<int> EventNumbers = CollectEventNumbers();

    static HashSet<int> CollectEventNumbers()
    {
        var set = new HashSet<int>();
        foreach (var type in typeof(Event1).Assembly.GetTypes())
        {
            if (!typeof(EventsForDLC.EventsSecond).IsAssignableFrom(type)) continue;
            var match = Regex.Match(type.Name, "^Event([0-9]+)$");
            if (match.Success) set.Add(int.Parse(match.Groups[1].Value));
        }
        return set;
    }

    static void Events(string[] p)
    {
        var start = p.Length > 1 ? int.Parse(p[1]) : 0;
        var keyword = p.Length > 2 ? p[2] : "";
        var end = start + 30;
        var hit = 0;
        for (var number = start; number < end; number++)
        {
            if (!EventNumbers.Contains(number)) continue;
            var text = EventPane.TextOf(number);
            if (keyword.Length > 0 && !text.Contains(keyword)) continue;
            Log($"[{number}] {Short(text)}");
            hit++;
        }
        Log($"事件 {start}..{end - 1} 命中 {hit} 条（events 起始号 关键字 继续翻）");
    }

    // ================= 领土块 =================

    // 领土块 = 原版 Country.parts[]: 一块 = 地图上一块领土贴图.
    // 改完标脏, 地图按新归属重算着色与显隐.
    static void Territory(GameState state, string[] p)
    {
        var country = int.Parse(p[1]);
        var parts = state.allcountries[country].parts;
        if (p.Length == 2)
        {
            var on = new List<string>();
            for (var i = 0; i < parts.Length; i++) if (parts[i]) on.Add(i.ToString());
            Log($"{country} {state.allcountries[country].name} 领土块({parts.Length}): {(on.Count == 0 ? "无" : string.Join(",", on))}");
            return;
        }
        var part = int.Parse(p[2]);
        parts[part] = p[3] == "on" || p[3] == "1";
        MapPane.Touch();
        Log($"{country} parts[{part}] = {parts[part]}（地图已按新归属刷新）");
    }

    static void Parts(GameState state, int country)
    {
        var parts = state.allcountries[country].parts;
        var on = new List<string>();
        for (var i = 0; i < parts.Length; i++) if (parts[i]) on.Add(i.ToString());
        Log($"国家 {country} parts: {string.Join(",", on)}");
    }

    // ================= 国家意识形态 =================

    // 国体 = Country.Gosstroy(0威权/1社会主义/2改良主义/3自由主义, 见原版 PoliticalSystems 与 other_text 表);
    // 意识形态 = Country.SubGosstroy(0..19, 原版 CountryScript.ChangeSubIcons 的 other_text 下标规则).
    static void Ideology(GameState state, string[] p)
    {
        var country = state.allcountries[int.Parse(p[1])];
        if (p.Length == 2)
        {
            Log($"{p[1]} {country.name} | 国体 {country.Gosstroy}={IdeologyText(country.Gosstroy)} | 意识形态 {country.SubGosstroy}={SubIdeologyText(country.SubGosstroy)} | 亲中 {country.proprc} 亲苏 {country.prosov} 亲美 {country.Vyshi}");
            return;
        }
        country.SetSystem(int.Parse(p[2]));
        if (p.Length > 3) country.SubGosstroy = int.Parse(p[3]);
        MapPane.Touch();
        Log($"{p[1]} 国体 {country.Gosstroy}={IdeologyText(country.Gosstroy)} 意识形态 {country.SubGosstroy}={SubIdeologyText(country.SubGosstroy)}");
    }

    static string IdeologyText(int gosstroy) => Clean(GameHost.Global.other_text[gosstroy]);

    static string SubIdeologyText(int sub)
        => Clean(GameHost.Global.other_text[sub < 10 ? sub + 13 : sub + 82]);

    static void Ideologies()
    {
        var text = GameHost.Global.other_text;
        var gosstroy = new List<string>();
        for (var i = 0; i < 4; i++) gosstroy.Add($"{i}={Clean(text[i])}");
        var sub = new List<string>();
        for (var i = 0; i < 20; i++) sub.Add($"{i}={Clean(text[i < 10 ? i + 13 : i + 82])}");
        Log("国体 Gosstroy: " + string.Join(" | ", gosstroy));
        Log("意识形态 SubGosstroy: " + string.Join(" | ", sub));
        Log("-> ideo 国家 [国体] [意识形态] 设置; 不给参数就是查看");
    }

    // ================= 政体政策 =================

    // 7 个政策槽 = 原版 Doctrine_script 的 this_number(= GameState.data 下标),
    // 每个槽的可选值 = 原版 Doctrine_script.Show(...) 里写死的那几个 doctr[] 下标.
    static readonly (int Slot, int From, int To)[] DoctrineSlots =
    {
        (15, 6, 9),    // 政体
        (16, 10, 15),  // 经济
        (17, 16, 19),  // 言论
        (18, 20, 23),  // 国家结构
        (50, 24, 29),  // 宗教
        (51, 30, 33),  // 军事
        (52, 34, 37),  // 战略
    };

    static string DoctrineText(GameState state, int value) => Clean(state.doctr[value].Replace("|", ""));

    static void Doctrine(GameState state, string[] p)
    {
        if (p.Length == 1)
        {
            var lines = new List<string>();
            foreach (var slot in DoctrineSlots)
                lines.Add($"[{slot.Slot}]={state.data[slot.Slot]} {DoctrineText(state, state.data[slot.Slot])}");
            Log("当前政策: " + string.Join(" | ", lines));
            return;
        }
        var index = int.Parse(p[1]);
        state.data[index] = int.Parse(p[2]);
        Log($"data[{index}] = {state.data[index]}（{DoctrineText(state, state.data[index])}）");
    }

    static void Doctrines(GameState state)
    {
        foreach (var slot in DoctrineSlots)
        {
            var options = new List<string>();
            for (var value = slot.From; value <= slot.To; value++)
                options.Add($"{value} {DoctrineText(state, value)}");
            Log($"[{slot.Slot}] {string.Join(" / ", options)}");
        }
        Log("-> doctr 槽位 值 直接改写(跳过预算与前置条件)");
    }

    // ================= 政治人物 =================

    // 原始库 KillPerson: 清职位(politics_dolshnost)/派系领袖/卡片排名, 再 BalancePolitic 重排.
    static void Kill(GameState state, string[] p)
    {
        var who = int.Parse(p[1]);
        state.KillPerson(who);
        Log($"已杀死人物 {who}（{PoliticianName(state, who)}）: 职位/派系领袖/排名已按原版 KillPerson 清理");
    }

    static void Politicians(GameState state, string[] p)
    {
        if (p.Length == 1 || p[1] == "list")
        {
            for (var i = 0; i < state.politics.Length; i++)
            {
                var pol = state.politics[i];
                Log($"[{i}] {PoliticianName(state, i)} 派系={PoliticTexts.Trait(pol.traits[0])} 权力={pol.power} 忠诚={pol.loyality} 年龄={pol.age} 职位={PostText(state, i)}");
            }
            return;
        }
        if (p[1] == "names1" || p[1] == "names2")
        {
            Names(state, p);
            return;
        }
        var who = int.Parse(p[1]);
        if (p.Length == 2)
        {
            DumpPolitician(state, who);
            return;
        }
        SetPolitician(state, who, p);
    }

    static void DumpPolitician(GameState state, int who)
    {
        var pol = state.politics[who];
        Log($"[{who}] {PoliticianName(state, who)}");
        Log($"  派系 traits[0]={pol.traits[0]}={PoliticTexts.Trait(pol.traits[0])} traits[1]={pol.traits[1]}={PoliticTexts.Trait(pol.traits[1])} traits[2]={pol.traits[2]}={PoliticTexts.Trait(pol.traits[2])}");
        Log($"  权力={pol.power} 忠诚={pol.loyality} 年龄={pol.age} 意向职位={pol.wantedDolzh} 在朝={pol.in_power} 职位={PostText(state, who)}");
        Log($"  name_1={pol.name_1} name_2={pol.name_2} autosupport={pol.autosupport} autohound={pol.autohound}");
        Log($"  loyality_to_other[0..17]={string.Join(",", pol.loyality_to_other)}");
        Log("-> pol 人物 字段 值 | 字段: loyality power age name1 name2 trait0 trait1 trait2 wanted in_power dolzh 位置 l2o 目标 值 autosupport autohound");
    }

    static void SetPolitician(GameState state, int who, string[] p)
    {
        var pol = state.politics[who];
        switch (p[2])
        {
            case "loyality": pol.loyality = int.Parse(p[3]); break;
            case "power": pol.power = int.Parse(p[3]); break;
            case "age": pol.age = (byte)int.Parse(p[3]); break;
            case "name1": pol.name_1 = int.Parse(p[3]); break;
            case "name2": pol.name_2 = int.Parse(p[3]); break;
            case "trait0": pol.traits[0] = (byte)int.Parse(p[3]); break;
            case "trait1": pol.traits[1] = (byte)int.Parse(p[3]); break;
            case "trait2": pol.traits[2] = (byte)int.Parse(p[3]); break;
            case "wanted": pol.wantedDolzh = int.Parse(p[3]); break;
            case "in_power": pol.in_power = (byte)int.Parse(p[3]); break;
            case "dolzh": state.politics_dolshnost[int.Parse(p[3])] = (byte)who; break;
            case "l2o": pol.loyality_to_other[int.Parse(p[3])] = int.Parse(p[4]); break;
            case "autosupport": pol.autosupport = int.Parse(p[3]); break;
            case "autohound": pol.autohound = int.Parse(p[3]); break;
            default: throw new ArgumentOutOfRangeException(nameof(p), p[2], "没有该人物字段");
        }
        Log($"[{who}] {PoliticianName(state, who)} {p[2]} = {p[3]}");
    }

    static void Names(GameState state, string[] p)
    {
        var table = p[1] == "names1" ? state.names1 : state.names2;
        var start = p.Length > 2 ? int.Parse(p[2]) : 0;
        var end = Math.Min(start + 40, table.Length);
        var line = new List<string>();
        for (var i = start; i < end; i++) line.Add($"{i}={Clean(table[i])}");
        Log($"{(p[1] == "names1" ? "名字表1" : "名字表2")} {start}..{end - 1}/{table.Length}: " + string.Join(" | ", line));
    }

    static string PoliticianName(GameState state, int index)
        => Clean(state.names1[state.politics[index].name_1]) + " " + Clean(state.names2[state.politics[index].name_2]);

    static string PostText(GameState state, int index)
    {
        for (var i = 0; i < state.politics_dolshnost.Length; i++)
            if (state.politics_dolshnost[i] == index) return PoliticTexts.Posts[i];
        return "无";
    }

    static string Clean(string text) => text.Replace(" ", "").Replace("\n", " ");

    static string Short(string text) => text.Length <= 120 ? text : text[..120] + "…";

    // ================= 诊断 =================

    static void ListWars(GameState state)
    {
        var going = new List<string>();
        for (var i = 0; i < state.ingamewars.Length; i++)
        {
            if (state.ingamewars[i].is_going) going.Add(i + ":" + state.ingamewars[i].name_war);
        }
        Log(going.Count == 0 ? "没有进行中的战争" : string.Join("; ", going));
    }

    // ================= data 全字段 =================
    // data 是 200 槽(0..199)的整数数组, 游戏内几乎全部数值都住在这里:
    // 预算/特工/军力/人口/工业/农业/服务业/腐败/财政分配/日期/战争编号/政策槽...
    // 槽位名见 Port.DataSlots(逐条取自原版源码读写点); 未知槽按 data[n] 显示.
    //   data            列出 0..19
    //   data 起始        从该槽起列出 20 个
    //   data 槽          查看(缓存槽会一并打印真值字段)
    //   data 槽 值       直接改写(内部原值, 不乘 10)
    //   data 槽 +值/-值  增减
    // 缓存槽 7/28/29 由 TimeScript.KumihaRepaint 每天用真值覆盖, 写它们等于白写:
    // 这里写完同步写真值, 界面立刻跟着变(下次 KumihaRepaint 也不会把它盖回去).
    static void Data(GameState state, string[] p)
    {
        if (p.Length == 1)
        {
            ListData(state, 0);
            return;
        }
        var slot = int.Parse(p[1]);
        if (p.Length == 2)
        {
            Log($"[{slot}] {槽名(slot)} = {state.data[slot]}（显示 {Port.DataSlots.Text(slot, state.data[slot])}）");
            var 真值 = Port.DataSlots.Mirror(slot);
            if (真值 != null) Log($"  该槽是每日缓存, 真值 {真值} = {ReadField(state, 真值)}");
            return;
        }
        var 值 = p[2];
        if (值[0] == '+' || 值[0] == '-') state.data[slot] += int.Parse(值);
        else state.data[slot] = int.Parse(值);
        var 镜像 = Port.DataSlots.Mirror(slot);
        if (镜像 != null)
        {
            WriteField(state, 镜像, state.data[slot].ToString());
            Log($"[{slot}] {槽名(slot)} = {state.data[slot]}（显示 {Port.DataSlots.Text(slot, state.data[slot])}）→ 已同步真值 {镜像} = {ReadField(state, 镜像)}");
            return;
        }
        Log($"[{slot}] {槽名(slot)} = {state.data[slot]}（显示 {Port.DataSlots.Text(slot, state.data[slot])}）");
    }

    static void ListData(GameState state, int start)
    {
        var end = Math.Min(start + 20, state.data.Length);
        for (var i = start; i < end; i++)
            Log($"[{i}] {槽名(i)} = {state.data[i]}（{Port.DataSlots.Text(i, state.data[i])}）");
        Log($"data {start}..{end - 1}/{state.data.Length}；继续输入 data {end}");
    }

    static string 槽名(int slot) => Port.DataSlots.Known(slot) ? Port.DataSlots.Name(slot) : $"data[{slot}]";

    // ================= 任意字段 =================
    // data 之外的字段(engines: influencePRC / SOV_PRC_PartiesConnection / leader.power /
    // empires[0].relations / allcountries[1].Gosstroy / politics[3].loyality ...).
    // 路径用 '.' 分段, 支持 Name[i] 下标; 只写 int/bool/byte/float/string 四种标量.
    static void Field(GameState state, string[] p)
    {
        if (p.Length == 2)
        {
            var 值 = ReadField(state, p[1]);
            Log($"{p[1]} = {值}");
            return;
        }
        WriteField(state, p[1], p[2]);
        // 写的是缓存槽对应的真值(影响力/美苏关系)时, 把缓存槽一起刷新,
        // 免得概览/事件的 data 镜像在下一次 KumihaRepaint 前还是旧值
        var slot = Port.DataSlots.MirrorSlot(p[1]);
        if (slot >= 0) state.data[slot] = (int)ReadField(state, p[1]);
        Log($"{p[1]} = {ReadField(state, p[1])}" + (slot >= 0 ? $"（同步缓存 data[{slot}]）" : ""));
    }

    static object ReadField(object root, string path)
    {
        var current = root;
        foreach (var part in path.Split('.'))
        {
            var (name, index) = ParsePart(part);
            var type = current.GetType();
            var field = type.GetField(name, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
            current = index >= 0 ? ((Array)field.GetValue(current)).GetValue(index) : field.GetValue(current);
        }
        return current;
    }

    static void WriteField(object root, string path, string raw)
    {
        var parts = path.Split('.');
        var current = root;
        for (var i = 0; i < parts.Length - 1; i++)
        {
            var (name, index) = ParsePart(parts[i]);
            var field = current.GetType().GetField(name, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
            current = index >= 0 ? ((Array)field.GetValue(current)).GetValue(index) : field.GetValue(current);
        }
        var (leaf, leafIndex) = ParsePart(parts[^1]);
        var leafField = current.GetType().GetField(leaf, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
        object 目标;
        Type 类型;
        if (leafIndex >= 0)
        {
            var array = (Array)leafField.GetValue(current);
            目标 = array;
            类型 = array.GetType().GetElementType();
            array.SetValue(解析值(raw, 类型), leafIndex);
            return;
        }
        类型 = leafField.FieldType;
        leafField.SetValue(current, 解析值(raw, 类型));
    }

    static (string Name, int Index) ParsePart(string part)
    {
        var open = part.IndexOf('[');
        if (open < 0) return (part, -1);
        return (part[..open], int.Parse(part[(open + 1)..^1]));
    }

    static object 解析值(string raw, Type type)
    {
        if (type == typeof(int)) return int.Parse(raw);
        if (type == typeof(bool)) return raw == "1" || raw == "true" || raw == "on";
        if (type == typeof(byte)) return (byte)int.Parse(raw);
        if (type == typeof(float)) return float.Parse(raw);
        if (type == typeof(string)) return raw;
        throw new ArgumentOutOfRangeException(nameof(type), type, "field 只支持 int/bool/byte/float/string");
    }

    // ================= 自动化日志 =================
    // 逻辑层 Automation 每轮结束把"汇总 + 逐条明细"写进 Recent; 这里列最近 20 条.
    static void Auto(string[] p)
    {
        var count = p.Length > 1 ? int.Parse(p[1]) : 20;
        if (Automation.Recent.Count == 0)
        {
            Log("本轮还没有自动动作(检查国家面板的自动勾是否打开)");
            return;
        }
        var from = Math.Max(0, Automation.Recent.Count - count);
        for (var i = from; i < Automation.Recent.Count; i++) Log(Automation.Recent[i]);
        Log($"最近 {Automation.Recent.Count - from} 条 / 共 {Automation.Recent.Count} 条");
    }

    static void Help()
    {
        Log("help / clear");
        Log("date d m y | speed 0-4 | money/party/people/thought/living/prestige/agents/army/influence ±值");
        Log("rel 0|1 值 | mod n 0|1 | diff 0-4 | ironman 0|1 | war n | list_wars | wars");
        Log("terr 国家 [part on|off]     领土块: 不给参数查看着该国各块状态");
        Log("ideo 国家 [国体] [意识形态]  不给参数查看; ideos 列出可选值");
        Log("event n                    强制触发事件(切事件场景)");
        Log("event n 选项               触发并立即按原版结算该选项");
        Log("events [起始号] [关键字]   检索事件正文(每次 30 个)");
        Log("evopt 0|1                  事件选项无视前置条件(1=所有选项都能点, 结果仍走原版结算)");
        Log("kill 人物                  杀死政治人物");
        Log("pol list | pol 人物 | pol 人物 字段 值 | pol names1|names2 [起始]");
        Log("doctr                      查看当前政体政策");
        Log("doctr 槽位 值              直接改写(15政体 16经济 17言论 18结构 50宗教 51军事 52战略)");
        Log("doctrs                     列出每个槽位的可选值");
        Log("fac                        派系诊断(席位/领袖/执政/联盟)");
        Log("fac seats 派系 值           改席位 party_number（0极左 1保守 2温和 3改革 4自由）");
        Log("fac leader 派系 人物号      改派系领袖 faction_leader");
        Log("part 国家 下标 on|off | parts 国家 | map | highlight 国家 | faction");
        Log("save 槽位 | load 槽位 | cheat 0-12 | gold | pop | key 动作号");
        Log("data [起始]                 列出 data 全字段(每次 20 个, 0..199)");
        Log("data 槽 [值|+值|-值]        查看/改写 data 槽(共 200 槽, 名称见 data 列表)");
        Log("                           缓存槽 7/28/29 写入会自动同步真值(influencePRC / 美苏关系)");
        Log("field 路径 [值]             任意状态字段: influencePRC / leader.power / empires[0].relations /");
        Log("                            politics[3].loyality / allcountries[1].Gosstroy / data[8] ...");
        Log("auto [条数]                 最近自动动作明细(干了什么、资源扣在哪)");
        Log("mods | achreset | audio");
    }

    // 修正(buff)诊断: 读档前后各跑一次, 对比 active 与文本长度就能看出是数据丢了还是文案模板丢了.
    static void LogMods(GameState state)
    {
        var global = GameHost.Global;
        var 数 = 0;
        for (var i = 0; i < state.modifies.Length; i++)
        {
            if (!state.modifies[i].active) continue;
            数++;
            var 名 = i < global.old_modify_texts.Length ? global.old_modify_texts[i].Replace(" ", "") : "?";
            var 描述 = i < global.old_modify_desc.Length ? global.old_modify_desc[i] : "?";
            Log($"[{i}] {名} | desc={描述[..Math.Min(30, 描述.Length)]}");
        }
        Log($"生效 {数} 个 | 文本表 old_modify_text={global.old_modify_texts.Length} old_modify_desc={global.old_modify_desc.Length}");
    }

    // 战争诊断: 两条同名战争会在这里看到不同的索引与双方, 据此定位是哪条重复/多余.
    static void LogWars(GameState state)
    {
        var 数 = 0;
        for (var i = 0; i < state.ingamewars.Length; i++)
        {
            var w = state.ingamewars[i];
            if (!w.is_going) continue;
            数++;
            Log($"[{i}] {w.name_war} : {w.side1} vs {w.side2}");
        }
        Log($"进行中 {数} 场战争");
    }

    // 音乐诊断: 手机上没有 adb 时, 靠这条命令看权限与候选路径到底缺在哪.
    static void AudioDiag()
    {
        Log($"平台 {Godot.OS.GetName()} | 已授权限 [{string.Join(",", Godot.OS.GetGrantedPermissions())}]");
        Log($"EXTERNAL_STORAGE={Godot.OS.GetEnvironment("EXTERNAL_STORAGE")}");
        Log($"user={Godot.OS.GetUserDataDir()}");
        var 内置 = Godot.DirAccess.Open("res://assets/audio/music");
        Log($"内置 res://assets/audio/music: {(内置 != null ? "有" : "无")}");
        内置?.Dispose();
        var 名们 = new[] { "专辑", "音乐", "Albums", "Music" };
        var 候选 = new List<string>();
        foreach (var 名 in 名们) 候选.Add(Godot.OS.GetUserDataDir() + "/" + 名);
        foreach (var 系统 in new[] { Godot.OS.SystemDir.Downloads, Godot.OS.SystemDir.Music, Godot.OS.SystemDir.Documents })
        {
            var 根 = Godot.OS.GetSystemDir(系统);
            if (string.IsNullOrEmpty(根)) continue;
            foreach (var 名 in 名们) 候选.Add(根 + "/" + 名);
        }
        foreach (var 路径 in 候选)
        {
            var 目录 = Godot.DirAccess.Open(路径);
            Log($"{(目录 != null ? "有" : "无")} {路径}");
            目录?.Dispose();
        }
    }

    // 主导派系排查: data[56] 由原版 Results_text.Pereraschyot 在事件结算时算,
    // 这里按同一套规则复算一遍, 方便定位"席位最多却不是执政"落在哪条分支.
    static void Faction(GameState state)
    {
        var 席位 = "";
        for (var i = 0; i < state.party_number.Length; i++)
            席位 += $" [{i}]{state.party_number[i]}{(state.is_party_enabled[i] ? "" : "(未启用)")}{(state.is_party_ally[i] ? "(盟友)" : "")}";
        Log($"data[15]={state.data[15]} 执政=data[56]={state.data[56]} 满足现状=data[106]={state.data[106]} |{席位}");
        var 领袖 = "";
        for (var i = 0; i < state.faction_leader.Length; i++)
            领袖 += $" [{i}]{(state.faction_leader[i] < state.politics.Length ? PoliticianName(state, state.faction_leader[i]) : "空缺")}";
        Log($"派系领袖:{领袖}");
        var 最大 = 0;
        for (var i = 1; i < state.party_number.Length; i++)
            if (state.party_number[i] > state.party_number[最大]) 最大 = i;
        var 联盟 = state.party_number[1];
        for (var i = 0; i < state.is_party_ally.Length; i++)
            if (state.is_party_ally[i] && state.is_party_enabled[i] && i != 1) 联盟 += state.party_number[i];
        Log($"单党最多={最大}({state.party_number[最大]}) 派系1+盟友={联盟} 宪法多数={state.is_konst_max}");
    }

    // 派系只开两个写入口: 席位 party_number / 派系领袖 faction_leader(原版政治界面直接读它们).
    // 派系号 = 界面行序 0极左 1保守 2温和 3改革 4自由(FactionPane.Snapshot 的 i).
    static void FactionEdit(GameState state, string[] p)
    {
        if (p.Length == 1)
        {
            Faction(state);
            return;
        }
        var index = int.Parse(p[2]);
        switch (p[1])
        {
            case "seats": state.party_number[index] = int.Parse(p[3]); break;
            case "leader": state.faction_leader[index] = int.Parse(p[3]); break;
            default: throw new ArgumentOutOfRangeException(nameof(p), p[1], "派系只有 seats / leader");
        }
        Faction(state);
    }

    // ================= 作弊 =================
    // 13 条的实现唯一放在 ShortcutPane(设置页/手机面板/调试台共用一份), 这里只转发.
    static void Cheat(int action)
    {
        ShortcutPane.Cheat(action);
        Log($"[作弊] 动作 {action} 已执行");
    }
}
