// 派系界面: 接管原版组件层.
//   Doctrine_script / Doctrine_button_script → 六类政策选项与切换
//   Party_ally_script / Party_zapret           → 支持/禁止
//   ChildScript                                → 生育政策
//   ElectScript / speechscript                 → 选举 / 同盟 / 演讲
//   Crushko                                    → 饼图角度与颜色
// 显示文本: Politic_doctr_script 的 doctr[data[槽位]] 口径(经 Doctr 读取).
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using CML.Logic.Port;

namespace CML.Logic.Panes;

public sealed class FactionPane : IPanel
{
    public string Name => "派系";

    const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    // 政策类别号 = 原版 Doctrine_script.this_number = 原版 data 槽位
    static readonly int[] PolicyCategories = { 16, 15, 17, 18, 50, 51 };
    static readonly string[] PolicyCategoryNames = { "economy", "party", "human_rights", "state_system", "tradition", "military" };

    static Stub _doctrine;
    static Stub[] _policyButtons;
    static readonly Stub[] Allies = new Stub[5];
    static readonly Stub[] Bans = new Stub[5];
    static Stub[] _birth;
    static Stub _elect;
    static Stub _econAlliance;
    static Stub _milAlliance;
    static Stub _speech;
    static Stub _crushko;
    static bool _ready;

    // 原版 Crushko._Col 由 Unity 预设序列化提供(极左红/保守紫/温和粉/改革绿/自由蓝/满意灰)
    static readonly Color[] CrushColors =
    {
        new(0.725f, 0.008f, 0.008f),
        new(0.588f, 0.102f, 0.984f),
        new(0.980f, 0.337f, 0.325f),
        new(0f, 0.659f, 0.043f),
        new(0f, 0.502f, 0.737f),
        new(0.368f, 0.368f, 0.368f),
    };

    public Dictionary<string, object> Snapshot()
    {
        EnsureStubs();
        var state = GameHost.State;
        var multi = state.data[15] > 7;
        var factions = new List<object>(5);
        for (var i = 0; i < 5; i++)
        {
            factions.Add(new Dictionary<string, object>
            {
                ["index"] = i,
                ["name"] = state.party_name[multi ? i + 5 : i].Trim(),
                ["seats"] = state.party_number[i],
                ["ally"] = state.is_party_ally[i],
                ["enabled"] = state.is_party_enabled[i],
            });
        }

        return new PanelSnapshot()
            .Put("economy", Doctr(state, 16))
            .Put("party", Doctr(state, 15))
            .Put("human_rights", Doctr(state, 17))
            .Put("state_system", Doctr(state, 18))
            .Put("tradition", Doctr(state, 50))
            .Put("military", Doctr(state, 51))
            .Put("regime", Doctr(state, 14))
            .Put("route", Doctr(state, 52) + "\n" + Doctr(state, 54))
            .Put("title", Title())
            .Put("leading", LeadingFaction(state, multi))
            .Put("factions", factions)
            .Put("birth_policy", state.data[105])
            .Put("army_power", (state.data[22] / 10f).ToString("0.0"))
            .Put("policy_options", BuildPolicyOptions())
            .Put("pie", BuildPie())
            .Put("can_elect", ElectAvailable())
            .Put("can_econ", AllianceAvailable(false))
            .Put("can_mil", AllianceAvailable(true))
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        EnsureStubs();
        switch (action)
        {
            case "结盟":
                ToggleAlly((int)(long)args[0]);
                break;
            case "禁止派系":
                ToggleBan((int)(long)args[0]);
                break;
            case "生育政策":
                SetBirthPolicy((int)(long)args[0]);
                break;
            case "政策":
                ApplyPolicy((int)(long)args[0], (int)(long)args[1]);
                break;
            case "选举":
                PressAndSwitch(_elect);
                break;
            case "经济同盟":
                PressAndSwitch(_econAlliance);
                break;
            case "军事同盟":
                PressAndSwitch(_milAlliance);
                break;
            case "演讲":
                PressAndSwitch(_speech);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "派系面板没有该动作");
        }
    }

    // 原版 ElectScript/speechscript 用 SceneManager.LoadScene("Event");
    // 由 GameHost 捕获后转成 Godot 场景请求.
    static void PressAndSwitch(Stub stub)
    {
        stub.Invoke("OnMouseDown");
    }

    // 原版 Politic_doctr_script 口径: doctr[data[槽位]]
    static string Doctr(GameState state, int slot) => state.doctr[state.data[slot]].Replace("|", "\n");

    static void EnsureStubs()
    {
        if (_ready) return;
        _ready = true;

        var kr = new GameObject("Kr");
        kr.AddComponent<SpriteRenderer>();
        _crushko = Stub.Take<Crushko>("Crushko", Lifecycle.None);
        _crushko.Also<SpriteRenderer>();
        _crushko.Set("_DegEnd", new float[6]);
        _crushko.Set("_Col", (Color[])CrushColors.Clone());
        var crushok = Stub.On<Crushok_politic>(kr, Lifecycle.None).Typed<Crushok_politic>();
        crushok.cruj_script = _crushko.Typed<Crushko>();

        for (var m = 1; m <= 5; m++)
        {
            var parties = new GameObject("Parties (" + m + ")");
            var text = new GameObject("Text");
            Stub.Attach<Politic_party_name_show>(text);
            text.transform.SetParent(parties.transform);
            var znack = new GameObject("Znack");
            znack.AddComponent<SpriteRenderer>();
            Stub.On<Party_ally_script>(znack, Lifecycle.None);
            znack.transform.SetParent(parties.transform);
            var znakc = new GameObject("Znakc (1)");
            znakc.AddComponent<SpriteRenderer>();
            Stub.On<Party_zapret>(znakc, Lifecycle.None);
            znakc.transform.SetParent(parties.transform);
        }

        _doctrine = Stub.Take<Doctrine_script>("Doctrine", Lifecycle.Lazy);
        _doctrine.Also<SpriteRenderer>();
        var buttonObjects = new GameObject[6];
        _policyButtons = new Stub[6];
        for (var i = 0; i < 6; i++)
        {
            var stub = Stub.Take<Doctrine_button_script>("PolicyButton" + i, Lifecycle.Lazy);
            var text = new GameObject("Text");
            var mesh = text.AddComponent<TextMesh>();
            text.transform.SetParent(stub.Go.transform);
            stub.Also<SpriteRenderer>();
            stub.Set("doctr1", _doctrine.Typed<Doctrine_script>());
            stub.Set("opisannya", mesh);

            // OnMouseEnter/OnMouseExit 会写 4 个条件槽(文本 + If/If (1) 图标)
            var uslovie = new GameObject[4];
            for (var j = 0; j < 4; j++)
            {
                var slot = new GameObject("IfText" + j);
                slot.AddComponent<TextMesh>();
                var if0 = new GameObject("If");
                if0.AddComponent<SpriteRenderer>();
                if0.transform.SetParent(slot.transform);
                var if1 = new GameObject("If (1)");
                if1.AddComponent<SpriteRenderer>();
                if1.transform.SetParent(slot.transform);
                slot.transform.SetParent(stub.Go.transform);
                uslovie[j] = slot;
            }
            stub.Set("uslovie", uslovie);
            stub.Set("on", new Sprite { name = "on" });
            stub.Set("off", new Sprite { name = "off" });
            stub.Set("usl_on", new Sprite { name = "usl_on" });
            stub.Set("usl_off", new Sprite { name = "usl_off" });

            _policyButtons[i] = stub;
            buttonObjects[i] = stub.Go;
        }
        _doctrine.Set("buttons", buttonObjects);

        for (var i = 0; i < 5; i++)
        {
            var ally = Stub.Take<Party_ally_script>("Ally" + i, Lifecycle.Lazy);
            ally.Also<SpriteRenderer>();
            ally.Set("this_number", i);
            ally.Set("doctr1", _doctrine.Typed<Doctrine_script>());
            ally.Set("on", new Sprite { name = "on" });
            ally.Set("off", new Sprite { name = "off" });
            Allies[i] = ally;

            var ban = Stub.Take<Party_zapret>("Ban" + i, Lifecycle.Lazy);
            ban.Also<SpriteRenderer>();
            ban.Set("this_number", i);
            ban.Set("doctr1", _doctrine.Typed<Doctrine_script>());
            ban.Set("on", new Sprite { name = "on" });
            ban.Set("off", new Sprite { name = "off" });
            Bans[i] = ban;
        }

        _birth = new Stub[3];
        for (var i = 0; i < 3; i++)
        {
            var child = Stub.Take<ChildScript>("Birth" + i, Lifecycle.Lazy);
            child.Also<SpriteRenderer>();
            child.Set("this_number", i);
            child.Set("text1", new TextMesh());
            child.Set("on", new Sprite { name = "on" });
            child.Set("off", new Sprite { name = "off" });
            _birth[i] = child;
        }
        _birth[0].Set("a1", _birth[1].Typed<ChildScript>());
        _birth[0].Set("a2", _birth[2].Typed<ChildScript>());
        _birth[1].Set("a1", _birth[0].Typed<ChildScript>());
        _birth[1].Set("a2", _birth[2].Typed<ChildScript>());
        _birth[2].Set("a1", _birth[0].Typed<ChildScript>());
        _birth[2].Set("a2", _birth[1].Typed<ChildScript>());

        _elect = Stub.Take<ElectScript>("Elect", Lifecycle.Lazy);
        _elect.Also<SpriteRenderer>();
        _elect.Set("on", new Sprite { name = "on" });
        _elect.Set("off", new Sprite { name = "off" });
        _elect.Set("text_part", new TextMesh());

        _econAlliance = Stub.Take<ElectScript>("EconAlliance", Lifecycle.Lazy);
        _econAlliance.Also<SpriteRenderer>();
        _econAlliance.Set("on", new Sprite { name = "on" });
        _econAlliance.Set("off", new Sprite { name = "off" });
        _econAlliance.Set("is_alliance", true);
        _econAlliance.Set("military", false);

        _milAlliance = Stub.Take<ElectScript>("MilAlliance", Lifecycle.Lazy);
        _milAlliance.Also<SpriteRenderer>();
        _milAlliance.Set("on", new Sprite { name = "on" });
        _milAlliance.Set("off", new Sprite { name = "off" });
        _milAlliance.Set("is_alliance", true);
        _milAlliance.Set("military", true);

        _speech = Stub.Take<speechscript>("Speech", Lifecycle.Lazy);
        _speech.Also<SpriteRenderer>();
        _speech.Set("on", new Sprite { name = "on" });
        _speech.Set("off", new Sprite { name = "off" });
    }

    // 原版 ElectScript.Repaint 写入 text_part 的派系区标题
    // 主导派系 = 席位最多的派系(原版派系界面显示的执政/主导派)
    static string LeadingFaction(GameState state, bool multi)
    {
        var leading = 0;
        for (var i = 1; i < 5; i++)
        {
            if (state.party_number[i] > state.party_number[leading]) leading = i;
        }
        return state.party_name[multi ? leading + 5 : leading].Trim();
    }

    static string Title()
    {
        _elect.Invoke("Repaint");
        return ((TextMesh)_elect.Get("text_part")).text;
    }

    // 原版 ElectScript.Repaint 的可用性(off = 可点)
    static bool ElectAvailable()
    {
        _elect.Invoke("Repaint");
        return SpriteName(_elect) == "off";
    }

    static bool AllianceAvailable(bool military)
    {
        var stub = military ? _milAlliance : _econAlliance;
        stub.Invoke("Reapint_alliance");
        return SpriteName(stub) == "off";
    }

    static string SpriteName(Stub stub) => ((SpriteRenderer)stub.Also<SpriteRenderer>()).sprite?.name ?? "";

    // 原版 Party_ally_script.OnMouseDown / Party_zapret.OnMouseDown
    static void ToggleAlly(int index) => Allies[index].Invoke("OnMouseDown");
    static void ToggleBan(int index) => Bans[index].Invoke("OnMouseDown");

    // 原版 ChildScript.OnMouseDown
    static void SetBirthPolicy(int policy) => _birth[policy].Invoke("OnMouseDown");

    // 政策类别: 原版 Doctrine_script.OnMouseDown 构建选项, 点中目标按钮执行切换
    static void RefreshPolicyButtons(int catNum)
    {
        // neutral_leading 只在 Show 里置 true、永不复位(原版每轮新建按钮对象)
        foreach (var button in _policyButtons) button.Set("neutral_leading", false);
        _doctrine.Set("this_number", catNum);
        _doctrine.Invoke("OnMouseDown");
    }

    static List<object> OptionsFor(int catNum)
    {
        RefreshPolicyButtons(catNum);
        var options = new List<object>();
        var activeCount = 0;
        foreach (var button in _policyButtons)
        {
            // 原版用 GameObject.SetActive 表示该槽是否有选项(is_active 字段从未被赋值)
            if (button.Go.activeSelf) activeCount++;
        }
        if (activeCount == 0)
        {
            var state = GameHost.State;
            var diag = new System.Text.StringBuilder();
            diag.Append($"类别 {catNum} 没有可选政策按钮(Doctrine_script 未 Show); this_number={_doctrine.Get("this_number")}");
            diag.Append($"; modifies11={state.modifies[11].active}; decisions18={state.completedDecisions[18]}");
            diag.Append($"; result503={state.resultOfEvents[503]}; modifies6={state.modifies[6].active}");
            for (var i = 0; i < _policyButtons.Length; i++)
            {
                diag.Append($"; b{i}: active={_policyButtons[i].Go.activeSelf} number={_policyButtons[i].Get("number")} text={((TextMesh)_policyButtons[i].Go.transform.Find("Text").GetComponent<TextMesh>()).text}");
            }
            throw new System.InvalidOperationException(diag.ToString());
        }
        for (var i = 0; i < _policyButtons.Length; i++)
        {
            var stub = _policyButtons[i];
            var active = stub.Go.activeSelf;
            if (!active) continue;
            var number = (int)stub.Get("number");
            var count = (int)stub.Get("number_uslovie");
            var flags = (bool[])stub.Get("uslovie_bool");
            var texts = (string[])stub.Get("uslovie_text");
            var label = stub.Go.transform.Find("Text").GetComponent<TextMesh>().text;
            stub.Invoke("OnMouseEnter");

            var conditions = new List<object>();
            var conditionTexts = new List<object>();
            var enabled = true;
            for (var j = 0; j < count; j++)
            {
                conditions.Add(flags[j]);
                conditionTexts.Add(texts[j]);
                if (!flags[j]) enabled = false;
            }

            options.Add(new Dictionary<string, object>
            {
                ["id"] = number,
                ["text"] = label ?? "",
                ["opis"] = (string)stub.Get("fake_text") ?? "",
                ["enabled"] = enabled,
                ["conditions"] = conditions,
                ["condition_texts"] = conditionTexts,
            });
        }
        return options;
    }

    static Dictionary<string, object> BuildPolicyOptions()
    {
        var result = new Dictionary<string, object>();
        for (var i = 0; i < PolicyCategories.Length; i++)
        {
            result[PolicyCategoryNames[i]] = OptionsFor(PolicyCategories[i]);
        }
        return result;
    }

    static void ApplyPolicy(int catNum, int target)
    {
        RefreshPolicyButtons(catNum);
        foreach (var stub in _policyButtons)
        {
            if (!stub.Go.activeSelf) continue;
            if ((int)stub.Get("number") != target) continue;
            stub.Invoke("OnMouseDown");
            return;
        }
        throw new System.ArgumentException($"类别 {catNum} 没有编号 {target} 的政策选项");
    }

    // 原版 Crushko.Repaint: 6 段累计终点角(度), -1 = 隐藏
    static List<object> BuildPie()
    {
        _crushko.Invoke("Repaint");
        var degrees = (float[])_crushko.Get("_DegEnd");
        var segments = new List<object>(6);
        for (var i = 0; i < degrees.Length; i++)
        {
            segments.Add(new Dictionary<string, object>
            {
                ["angle"] = degrees[i],
                ["color"] = new Godot.Color(CrushColors[i].r, CrushColors[i].g, CrushColors[i].b, 1f),
            });
        }
        return segments;
    }
}
