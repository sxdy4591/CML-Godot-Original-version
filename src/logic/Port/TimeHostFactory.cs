// ============================================================
// 逻辑层 — TimeHostFactory: 原版时钟宿主
//
// 原版时间推进完全由 TimeScript 承担（Update 驱动 6200 行 Repaint）。
// 它在 Unity 场景里靠序列化字段引用一堆兄弟对象；移植版必须把这些
// 替身造出来，原版 Awake/Update 才能完整执行。
//
// 这里只做对象图装配：字段绑定、组件挂载、对象命名。
// 不含任何数值钳制、异常吞没或状态修补 —— 缺件就让异常暴露出来。
// ============================================================
using System;
using System.Reflection;
using UnityEngine;
using AchievementsAlias = achievements;

namespace CML.Logic.Port;

public static class TimeHostFactory
{
    // 造出 TimeScript 需要的场景对象图, 返回待泵送的时钟实例.
    public static TimeScript Create()
    {
        var mapGo = Create("MapChanges", typeof(MapChangesScript));
        var map = mapGo.GetComponent<MapChangesScript>();
        map.parts = new GameObject[5];
        for (var i = 0; i < map.parts.Length; i++)
        {
            map.parts[i] = new GameObject($"{i:D3}_0");
        }

        Create("Button (0)", typeof(SpeedScript), typeof(SpriteRenderer));
        Create("Button (2)", typeof(EvetnnashScript), typeof(SpriteRenderer));
        Create("Button (4)", typeof(EvetnnashScript), typeof(SpriteRenderer));
        var achGo = Create("Ach(Clone)", typeof(AchievementsAlias));
        AchievementCenter.Register(achGo.GetComponent<AchievementsAlias>());
        Create("SteamManager", typeof(SteamManager));
        new GameObject("Global(Clone)");

        // 时钟不再进泵: 原版 TimeScript 是 Diplomacy 场景对象, 切到经济/政治等界面时随场景卸载,
        // 时间与事件倒计时都会停. 这里由 GameHost.Tick 只在外交/地图界面调用它的 Update.
        // 对象名必须与原版场景一致(Text_time): in1992_script.Awake 靠 Find("Text_time") 取它.
        var timeStub = Stub.Take<TimeScript>("Text_time", Lifecycle.Scene);
        timeStub.Go.AddComponent<TextMesh>();
        var achievements = Stub.Attach<AchievementsAlias>(timeStub.Go);
        var time = timeStub.Typed<TimeScript>();

        StubTimeFields(time);
        EnsureAchievementSlots(achievements);

        map.events = new GameObject[] { time.events[0] };
        // 字段(events/re_war/alarmIcons/goto_economy…)齐了再跑 Awake→Start
        timeStub.Activate();
        return time;
    }

    private static GameObject Create(string name, params Type[] components)
    {
        var go = new GameObject(name);
        foreach (var type in components)
        {
            Stub.Attach(go, type);
            // EvetnnashScript.Awake 里 map1 = Find("MapChanges"); 不跑 Awake 的话
            // in1992_script 的"功成身退"走到 Button (4).OnMouseDown() 第一句
            // map1.EventRead() 就是空引用, 结局根本切不出去.
            if (type == typeof(EvetnnashScript))
                Stub.On(go, type, Lifecycle.Scene).Activate();
        }
        return go;
    }

    private static void StubTimeFields(TimeScript time)
    {
        time.probel = MakeSpeedButton("probel", 0);
        time.firstS = MakeSpeedButton("firstS", 1);
        time.secondS = MakeSpeedButton("secondS", 2);
        time.thirdS = MakeSpeedButton("thirdS", 3);
        LinkSpeedButtons(time);

        time.thisText = new TextMesh { name = "thisText" };
        // Scene: TimeScript 是直接调 goto_economy.OnMouseDown()(不经过 Stub), Lazy 永远不会被触发,
        // Awake 里 map1 = Find("MapChanges") 就留在 null, 预算为负时 map1.EventRead() 抛 NRE, 不会跳经济面板.
        var economyStub = Stub.Take<EvetnnashScript>("goto_economy", Lifecycle.Scene);
        economyStub.Set("new_scene", "Economy");
        economyStub.Activate();
        time.goto_economy = economyStub.Typed<EvetnnashScript>();

        time.ending = new GameObject("ending");
        time.dlc_button = new GameObject("dlc_button");
        time.dlc_button2 = new GameObject("dlc_button2");
        time.crisis_show = new GameObject("crisis_show");

        time.alarmIcons = new GameObject[6];
        for (var i = 0; i < time.alarmIcons.Length; i++)
        {
            var go = new GameObject("alarmIcons" + i);
            Stub.Attach<OkoshkoScript>(go);
            go.SetActive(false); // 原版场景里警报图标初始关闭, 由 AlarmIconChange 逐个打开
            time.alarmIcons[i] = go;
        }

        time.crisis = new SpriteRenderer[8];
        time.crisis_color = new TextMesh[8];
        for (var i = 0; i < time.crisis.Length; i++)
        {
            time.crisis[i] = new SpriteRenderer { name = "crisis" + i };
            time.crisis_color[i] = new TextMesh { name = "crisis_color" + i };
        }

        time.re_war = new at_war_script[11];
        for (var i = 0; i < time.re_war.Length; i++)
        {
            var stub = Stub.Take<at_war_script>("re_war" + i, Lifecycle.None);
            stub.Also<SpriteRenderer>();
            // 原版场景里 11 个战争图标各序列化一个 this_num(0..10), Repaint 靠它决定显示哪场战争
            stub.Set("this_num", i);
            time.re_war[i] = stub.Typed<at_war_script>();
        }

        time.events = new GameObject[26];
        for (var i = 0; i < time.events.Length; i++)
        {
            // Scene: 倒计时/超时由 GameHost.TickEventMarker 驱动(TimeScript 日阈值被调过),
            // 但 Awake 必须跑(绑 global1/map1, 超时分支的 EventRead 依赖 map1).
            var stub = Stub.Take<EventScript>("event_marker" + i, Lifecycle.Scene);
            stub.Set("sp", stub.Also<SpriteRenderer>());
            stub.Activate();
            stub.Go.SetActive(false);
            time.events[i] = stub.Go;
        }

        // 同上: 自动存档/读档也是 TimeScript 直接调 OnMouseDown, 必须先把 Awake 跑掉
        time.Autosavej = Stub.Take<Savescript>("Autosave", Lifecycle.Scene).Activate().Typed<Savescript>();
        time.Autoloadej = Stub.Take<LoadInScript>("Autoload", Lifecycle.Scene).Activate().Typed<LoadInScript>();
    }

    // 原版 achievements 的 ach_this 由 Ach.prefab 序列化为 1000 长; 代码初值只有 100.
    // 扩到 1000 并登记: 界面按"任一实例解锁"聚合读取.
    static void EnsureAchievementSlots(AchievementsAlias achievements) => AchievementCenter.Register(achievements);

    private static GameObject MakeSpeedButton(string name, int number)
    {
        // Scene: Awake 里 Find("MapChanges") 绑 map1/goto_economy, 依赖建好后才起生命周期
        var stub = Stub.Take<SpeedScript>(name, Lifecycle.Scene);
        stub.Also<SpriteRenderer>();
        stub.Set("this_number", number);
        return stub.Activate().Go;
    }

    private static void LinkSpeedButtons(TimeScript time)
    {
        var pause = time.probel.GetComponent<SpeedScript>();
        var first = time.firstS.GetComponent<SpeedScript>();
        var second = time.secondS.GetComponent<SpeedScript>();
        var third = time.thirdS.GetComponent<SpeedScript>();
        pause.other = new[] { first, second, third };
        first.other = new[] { pause, second, third };
        second.other = new[] { pause, first, third };
        third.other = new[] { pause, first, second };
    }
}
