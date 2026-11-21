// 调试控制台: 命令解析与执行在逻辑层, 视图只负责输入/显示.
// 数值口径与原版 GameState.data 一致(×10 内部单位), 命令输入的 ±值按显示单位换算.
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CML.Logic.Panes;

public sealed class DebugPane : IPanel
{
    public string Name => "调试";

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
                state.number_event = int.Parse(p[1]);
                UiEvents.RequestScene("Event");
                Log($"触发事件 {state.number_event}");
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
            case "list_events":
                ListEvents(state);
                break;
            case "part":
                var country = state.allcountries[int.Parse(p[1])];
                country.parts[int.Parse(p[2])] = p.Length < 4 || p[3] != "off";
                Log($"国家 {p[1]} parts[{p[2]}] = {country.parts[int.Parse(p[2])]}");
                break;
            case "parts":
                Parts(state, int.Parse(p[1]));
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
            case "cheat":
                Cheat(int.Parse(p[1]));
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

    static void ListWars(GameState state)
    {
        var going = new List<string>();
        for (var i = 0; i < state.ingamewars.Length; i++)
        {
            if (state.ingamewars[i].is_going) going.Add(i + ":" + state.ingamewars[i].name_war);
        }
        Log(going.Count == 0 ? "没有进行中的战争" : string.Join("; ", going));
    }

    static void ListEvents(GameState state)
    {
        var count = 0;
        foreach (var type in typeof(Event1).Assembly.GetTypes())
        {
            if (Regex.IsMatch(type.Name, "^Event[0-9]+$")) count++;
        }
        Log($"事件类 {count} 个 | 当前 number_event = {state.number_event}");
    }

    static void Parts(GameState state, int country)
    {
        var parts = state.allcountries[country].parts;
        var on = new List<string>();
        for (var i = 0; i < parts.Length; i++) if (parts[i]) on.Add(i.ToString());
        Log($"国家 {country} parts: {string.Join(",", on)}");
    }

    static void Help()
    {
        Log("help / clear / close");
        Log("date d m y | speed 0-4 | event n | list_events");
        Log("money/party/people/thought/living/prestige/agents/army/influence ±值");
        Log("rel 0|1 值 | mod n 0|1 | diff 0-4 | ironman 0|1");
        Log("war n | list_wars | part 国家 下标 on|off | parts 国家 | map");
        Log("save 槽位 | load 槽位 | cheat 0-12");
    }

    // ================= 作弊(与自定义页 13 条顺序一致) =================

    static void Cheat(int action)
    {
        var state = GameHost.State;
        switch (action)
        {
            case 0: state.data[1] += 100; break;
            case 1: state.data[3] += 100; break;
            case 2: state.data[4] += 100; break;
            case 3: state.data[5] += 100; break;
            case 4: state.data[6] += 100; break;
            case 5: state.data[7] += 100; break;
            case 6: state.data[8] += 100; break;
            case 7: state.data[9] += 100; break;
            case 8: state.data[22] += 100; break;
            case 9:
                state.empires[0].relations += 100;
                state.empires[1].relations += 100;
                break;
            case 10:
                state.relres = !state.relres;
                break;
            case 11:
                state.data[6] -= 100;
                break;
            case 12:
                state.data[0] += 100;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, "作弊动作只有 0-12");
        }
        Log($"[作弊] 动作 {action} 已执行");
    }
}
