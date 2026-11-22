// ============================================================
// 逻辑层 — DiploHost: 外交面板接管原版组件层
//
// 原版 CountryScript.OnMouseDown 既算图标槽又给 4 个 DiploButtonScript 配置按钮;
// 这里把 MapChanges / okno / 4 按钮的替身对象图搭好, 然后原样调用它并读回结果。
// 不复制任何外交判定.
//
// 对象图可以搭多套: 面板用 "" (沿用 TimeHostFactory 造的 MapChanges), 自动化用 "Auto"。
// 4 个 DiploButtonScript 的 is_active / uslovie_bool 是"最后一次 Show"的状态,
// 两套必须分开, 否则自动扫描会把玩家面板的按钮顶掉。
// ============================================================
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace CML.Logic.Port;

public sealed class DiploSet
{
    public MapChangesScript Map;
    public DiploButtonScript[] Buttons = new DiploButtonScript[4];
    public CountryScript Probe;
}

public static class DiploHost
{
    const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

    static DiploSet _ui;
    static DiploSet _scan;

    public static DiploSet Ui => _ui ??= Build("");

    // 地图"可互动淡金高亮"的逐国扫描用这套: 它每帧都会重配 4 个按钮,
    // 和外交面板共用一套会把玩家正在看的按钮顶成别的国家。
    public static DiploSet Scan => _scan ??= Build("Scan");

    public static void Ensure() => _ = Ui;

    public static DiploSet Build(string tag)
    {
        var mapStub = FindOrCreate<MapChangesScript>("MapChanges" + tag, Lifecycle.Scene);
        var map = mapStub.Typed<MapChangesScript>();
        var set = new DiploSet { Map = map };
        map.dont_need = true;
        map.znachki = MakeSprites("znachki_", 35);
        map.sub_znachki = MakeSprites("sub_znachki_", 23);
        // ShowParts 直接解析 parts[i].name 的 "NNN_P" 格式, 名字不能加后缀;
        // 两套图同名只影响 GameObject.Find 注册表, 而 parts 只经数组访问, 无碍.
        map.parts = new GameObject[5];
        for (var i = 0; i < map.parts.Length; i++) map.parts[i] = new GameObject($"{i:D3}_0");
        map.speed = new GameObject[4];
        for (var i = 0; i < 4; i++)
        {
            var speedGo = new GameObject("speed_" + tag + i);
            Stub.On<SpeedScript>(speedGo, Lifecycle.None);
            map.speed[i] = speedGo;
        }

        var okno = new GameObject("okno" + tag);
        okno.SetActive(false); // 原版国家窗口初始关闭(SpeedScript.OnMouseDown 以 !okno.active 判定可调速)
        map.okno = okno;
        AddText(okno, "Text (0)");
        AddText(okno, "Text (1)");
        AddText(okno, "Text_opis_country");
        for (var i = 0; i < 4; i++)
        {
            var text = AddText(okno, "TextIf (" + i + ")");
            var ifGo = new GameObject("If");
            ifGo.AddComponent<SpriteRenderer>();
            ifGo.transform.SetParent(text.transform);
        }
        for (var i = 0; i < 6; i++)
        {
            var znach = new GameObject("Znach (" + i + ")");
            znach.AddComponent<SpriteRenderer>();
            Stub.Attach<OkoshkoScript>(znach);
            znach.transform.SetParent(okno.transform);
        }

        map.buttons = new GameObject[4];
        for (var i = 0; i < 4; i++)
        {
            var buttonGo = new GameObject("Button" + tag + " (" + i + ")");
            buttonGo.AddComponent<SpriteRenderer>();
            AchievementCenter.Register(Stub.Attach<achievements>(buttonGo));
            var buttonStub = Stub.On<DiploButtonScript>(buttonGo, Lifecycle.Scene);
            AddText(buttonGo, "Text");
            map.buttons[i] = buttonGo;
            // Awake 里 map1 = Find("MapChanges"), 会指到面板那套; 按钮执行末尾要
            // UpdateMap / ShowHideOcno(false), 必须落在自己这套图上.
            buttonStub.Activate().Set("map1", map);
            set.Buttons[i] = buttonStub.Typed<DiploButtonScript>();
        }

        mapStub.Activate();

        var countryGo = new GameObject("CountryProbe" + tag);
        countryGo.AddComponent<SpriteRenderer>();
        AchievementCenter.Register(Stub.Attach<achievements>(countryGo));
        set.Probe = Stub.On<CountryScript>(countryGo, Lifecycle.None).Typed<CountryScript>();

        return set;
    }

    // 显示某个国家: 原版 CountryScript.Repaint + OnMouseDown, 读回 6 图标槽与 4 按钮
    public static void Show(int index, List<object> icons, List<object> buttons, out string opis)
        => Show(Ui, index, icons, buttons, out opis);

    public static void Show(DiploSet set, int index, List<object> icons, List<object> buttons, out string opis)
    {
        // 按钮 Awake 缓存的私有字段 a 指向旧 gameState(读档后整体替换), 每次重指;
        // is_active 也清掉: 共享替身连续扫描不同国家时, 上一国残留的 true 会把别国误判成"可互动".
        foreach (var button in set.Buttons)
        {
            typeof(DiploButtonScript).GetField("a", Flags).SetValue(button, GameHost.State);
            typeof(DiploButtonScript).GetField("is_active", Flags).SetValue(button, false);
        }
        // 原版 ShowHideOcno 会把时间清零; 快照只是读数据, 调用后恢复原速度
        var speed = GameHost.Global.speed;
        // 原版 ChangeIcons 对"没有该图标"的国家只置 nonono, 不清 OkoshkoScript.text;
        // 同一套 okno 连续看不同国家时会残留上一国的文案(南斯拉夫面板显示"白人南非的傀儡国").
        // 每国 Repaint 前清空一次, 由本次 ChangeIcons 自己写.
        for (var i = 0; i < 6; i++)
        {
            var znach = set.Map.okno.transform.Find("Znach (" + i + ")").GetComponent<OkoshkoScript>();
            znach.text = "";
            znach.text_en = "";
            znach.nonono = false;
        }
        set.Probe.this_number = index;
        set.Probe.Repaint();
        // Repaint 第一句就是 map1 = Find("MapChanges"), 会指到面板那套; 重指回本套
        typeof(CountryScript).GetField("map1", Flags).SetValue(set.Probe, set.Map);
        ClearSlots(set);
        typeof(CountryScript).GetMethod("OnMouseDown", Flags).Invoke(set.Probe, null);
        GameHost.Global.speed = speed;
        // 原版 ShowHideOcno(true) 会把 okno 置为激活; SpeedScript.OnMouseDown 以
        // !okno.active 判定"可调速", 不关回去会导致时间永远停在 0(无报错).
        set.Map.okno.SetActive(false);

        // 原版 CountryScript.Repaint 对南美(71..83)等国家写 Text_opis_country
        // (政体/选举日期/发展度/稳定度), 这里一并读回.
        opis = set.Map.okno.transform.Find("Text_opis_country").GetComponent<TextMesh>().text ?? "";

        for (var i = 0; i < 6; i++)
        {
            var znach = set.Map.okno.transform.Find("Znach (" + i + ")");
            var sprite = znach.GetComponent<SpriteRenderer>().sprite;
            // 原版多数分支写 text, 少数只写 text_en; 两个都清空后再取, 取到谁算谁
            var okoshko = znach.GetComponent<OkoshkoScript>();
            var tooltip = string.IsNullOrEmpty(okoshko.text) ? okoshko.text_en : okoshko.text;
            icons.Add(new Dictionary<string, object>
            {
                ["sprite"] = sprite == null ? "" : sprite.name,
                ["text"] = tooltip ?? "",
            });
        }

        for (var i = 0; i < 4; i++)
        {
            var button = set.Buttons[i];
            var conditions = new List<object>();
            var conditionTexts = new List<object>();
            var count = (int)button.GetType().GetField("number_uslovie", Flags).GetValue(button);
            var flags = (bool[])button.GetType().GetField("uslovie_bool", Flags).GetValue(button);
            var texts = (string[])button.GetType().GetField("uslovie_text", Flags).GetValue(button);
            for (var j = 0; j < count; j++)
            {
                conditions.Add(flags[j]);
                conditionTexts.Add(texts[j]);
            }
            var active = (bool)button.GetType().GetField("is_active", Flags).GetValue(button);
            var label = button.transform.Find("Text").GetComponent<TextMesh>().text;
            buttons.Add(new Dictionary<string, object>
            {
                ["active"] = active,
                ["type"] = (int)button.GetType().GetField("this_type", Flags).GetValue(button),
                ["opis"] = (string)button.GetType().GetField("this_opis", Flags).GetValue(button),
                ["text"] = active && label != null ? label : "",
                ["conditions"] = conditions,
                ["condition_texts"] = conditionTexts,
            });
        }
    }

    public static void Activate(int index) => Activate(Ui, index);

    public static void Activate(DiploSet set, int index)
    {
        // OnMouseDown 末尾的 ShowHideOcno(false) 会把速度恢复成 save_speed, 保留速度
        var speed = GameHost.Global.speed;
        typeof(DiploButtonScript).GetMethod("OnMouseDown", Flags).Invoke(set.Buttons[index], null);
        GameHost.Global.speed = speed;
    }

    // 原版 OnMouseDown 只写命中分支的槽位文本; 不先清空会让上一个国家的文案漏进来
    static void ClearSlots(DiploSet set)
    {
        foreach (var name in new[] { "Text (1)", "Text_opis_country" })
        {
            set.Map.okno.transform.Find(name).GetComponent<TextMesh>().text = null;
        }
        foreach (var button in set.Buttons) button.Hide();
    }

    static Stub FindOrCreate<T>(string name, Lifecycle lifecycle) where T : Component, new()
    {
        var go = GameObject.Find(name);
        if (go != null) return Stub.Wrap<T>(go, lifecycle);
        return Stub.On<T>(new GameObject(name), lifecycle);
    }

    static TextMesh AddText(GameObject parent, string name)
    {
        var go = new GameObject(name);
        var text = go.AddComponent<TextMesh>();
        go.transform.SetParent(parent.transform);
        return text;
    }

    static Sprite[] MakeSprites(string prefix, int count)
    {
        var sprites = new Sprite[count];
        for (var i = 0; i < count; i++) sprites[i] = new Sprite { name = prefix + i };
        return sprites;
    }
}
