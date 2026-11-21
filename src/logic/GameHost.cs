// 原版内核宿主: 立起 GlobalScript / GameState / TimeScript, 开局, 速度.
using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using CML.Logic.Port;

namespace CML.Logic;

public static class GameHost
{
    public static GlobalScript Global { get; private set; }
    public static TimeScript Clock { get; private set; }
    public static GameState State => Global.gameState;
    public static int Speed => Global.speed;
    public static bool Booted => Global != null;

    public static void Boot()
    {
        PanelRouter.RegisterAll();

        var state = new GameState();
        // GlobalScript 不是场景对象: 生命周期由本类按原版顺序手动驱动(Init), 不进泵.
        Global = new GlobalScript { gameState = state };
        Stub.Detach(Global);
        Global.Init();
        for (var i = 0; i < Global.dlc.Length; i++) Global.dlc[i] = true;

        GameStateFactory.Fill(state);
        StartNewGame(1);
        // decisions 的文案来自 new_texts, 必须等 GameStartScript 载入文本后才建
        Global.CreateDecisions();
        Clock = TimeHostFactory.Create();
        // 首局也要清: 替身组件在进程内复用, 上一局的图标/计时不能带进新局
        ResetTimeHostState();
    }

    public static void StartNewGame(int number)
    {
        // 焦点树是静态字典, 重开局必须清空, 否则 CreateTree 会因同名 key 抛重复键异常
        KGFocus.FocusManager.all_trees.Clear();
        NewGameSetup.Reset(Global.gameState);
        ResetRoundState();
        // 重开局时时钟已存在; 首局由 Boot 在 Create 之后调用
        ResetTimeHostState();

        var starter = Stub.Take<GameStartScript>("GameStarter", Lifecycle.Lazy);
        starter.Set("number", number);
        starter.Invoke("OnMouseDown");
        DataContract.Verify(Global.gameState);
        NewGameSetup.ApplyOpeningData(Global.gameState);

        // GameStartScript 会按 Country_data 重建国家数组(长度与 parts 槽都会缩水)
        EnsureCountryCapacity(Global.gameState);
    }

    // 原版预设里国家 200 个、parts 至少 12 槽; 开局重建后要补回来, 地图与外交才不越界
    static void EnsureCountryCapacity(GameState state)
    {
        if (state.allcountries.Length < GameStateFactory.CountrySlots)
        {
            var old = state.allcountries;
            state.allcountries = new Country[GameStateFactory.CountrySlots];
            System.Array.Copy(old, state.allcountries, old.Length);
            for (var i = old.Length; i < state.allcountries.Length; i++) state.allcountries[i] = new Country();
        }
        foreach (var country in state.allcountries)
        {
            if (country.parts.Length >= GameStateFactory.CountryPartSlots) continue;
            var parts = new bool[GameStateFactory.CountryPartSlots];
            System.Array.Copy(country.parts, parts, country.parts.Length);
            country.parts = parts;
        }
    }

    public static void SetSpeed(int speed)
    {
        // SpeedScript.OnMouseDown 会读 map1.okno.active; okno 由外交宿主装配
        Port.DiploHost.Ensure();
        Clock.probel.GetComponent<SpeedScript>().adad(speed);
    }

    // 读档: 换掉 gameState 并重链时钟.
    public static void ReplaceState(GameState state)
    {
        Global.gameState = state;
        Global.CreateDecisions();
        typeof(TimeScript).GetField("global2", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
            .SetValue(Clock, state);
        ResetRoundState();
        ResetTimeHostState();
    }

    // 新局/读档共用: 清掉"每局重新开始"的静态缓存与一次性计时,
    // 否则上一档的状态会延续到新档(地图颜色缓存、事件需求日、战争去重月、自动化进度).
    static void ResetRoundState()
    {
        _autoSaveDay = -1;
        _eventRequirementsDay = -1;
        _warDedupMonth = -1;
        Automation.Reset();
        Panes.MapPane.InvalidateColors();
    }

    // 时钟替身是进程内单例: 警报图标一旦被 SetActive(true) 就不会自己熄灭(原版 AlarmIconChange 只亮不灭).
    // 首局由 Boot 在创建时钟后调用; 重开/读档在这里关掉全部图标, 再交给原版的月度判定重新点亮.
    static void ResetTimeHostState()
    {
        if (Clock == null) return;
        foreach (var icon in Clock.alarmIcons) icon.SetActive(false);
    }

    // 原版 TimeScript 是 Diplomacy 场景对象: 切到经济/政治/事件等独立场景时它随场景卸载,
    // 时间与事件倒计时全部停住. 移植后时钟常驻, 由桥层按当前场景开关这里.
    static bool _mainScene;
    public static void SetMainScene(bool active) => _mainScene = active;

    static readonly System.Reflection.MethodInfo ClockUpdateMethod =
        typeof(TimeScript).GetMethod("Update",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

    // ================= 每帧推进 =================
    // 桥层只负责每帧叫一次 + 把"高亮集合变了"翻译成信号; 是否推进由当前场景决定.
    public static void Tick(double delta)
    {
        if (!_mainScene) return;
        MaybeAutoSave();
        TickWarDedup();
        Automation.Tick();
        Panes.MapPane.Tick();
        // 原版 Update: 时间推进 + 每日事件需求挂载 + 事件图标超时(会自动切事件场景)
        ClockUpdateMethod.Invoke(Clock, null);
        TickEventMarker(delta);
    }

    // ================= 地图事件图标 =================
    // 原版流程: TimeScript.EventsRequirements() 在每日结算里把事件挂到 events[0],
    // 之后由 EventScript.Update 倒计时, 到 0 或点击进入事件场景.
    // 移植后两者都由 GameHost.Tick 按游戏时间推进, 与视图刷新频率无关.
    static readonly System.Reflection.MethodInfo EventsRequirementsMethod =
        typeof(TimeScript).GetMethod("EventsRequirements",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
    static readonly System.Reflection.MethodInfo EventUpdateMethod =
        typeof(EventScript).GetMethod("Update",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
    static readonly System.Reflection.MethodInfo EventMouseDownMethod =
        typeof(EventScript).GetMethod("OnMouseDown",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
    static int _eventRequirementsDay = -1;

    public static void TickEventMarker(double delta)
    {
        // 事件只在时间推进时结算
        if (Global.speed <= 0) return;
        // 原版按"每天一次"挂事件; 这里按游戏日门控, 不每帧把几百条条件重算一遍.
        var day = Global.gameState.data[21] * 10000 + Global.gameState.data[20] * 100 + Global.gameState.data[19];
        if (day != _eventRequirementsDay)
        {
            _eventRequirementsDay = day;
            EventsRequirementsMethod.Invoke(Clock, null);
        }

        var marker = Clock.events[0];
        if (!marker.activeSelf)
        {
            return;
        }
        var script = marker.GetComponent<EventScript>();
        // 超时结算(扣预算/特工、记 event_done、停表、切场景)全在 EventScript.Update 里,
        // TimeHostFactory 已停掉泵, 这里把时间压到阈值内直接调原版, 不复制它的结算.
        if (script.time <= 0.1f)
        {
            script.time = 0.05f;
            EventUpdateMethod.Invoke(script, null);
            return;
        }
        // 原版 EventScript 倒计时以"游戏时间"计: 每游戏日 8 单位(TimeScript 的日阈值),
        // 本端口日阈值是 1.2, 按比例换算, 否则日期跑快了, 事件会被推迟好几个月.
        script.time -= (float)delta * Global.speed * (8f / 1.2f);
    }

    // 原版 EventScript.OnMouseDown: 点击地图事件图标进入事件场景
    public static void OpenEventIcon()
    {
        var marker = Clock.events[0];
        if (!marker.activeSelf) return;
        EventMouseDownMethod.Invoke(marker.GetComponent<EventScript>(), null);
    }

    // ================= 战争去重 =================
    // 原版 KGWars.Wars.O 是进程级静态单例, War.DecleredWar() 每次都往 ingamewars 末尾追加
    // (没有"已宣战"检查). 移植版是长驻进程: 焦点层在 active() 抛异常时会整层重跑,
    // 存档/读档边界也可能让同一层再执行, 结果同一场欧加登战争被追加两条(同引用).
    // 这里每月按引用去重一次, 同一场战争只保留一条 is_going.
    static int _warDedupMonth = -1;

    public static void TickWarDedup()
    {
        var state = Global.gameState;
        var month = state.data[21] * 100 + state.data[20];
        if (month == _warDedupMonth) return;
        _warDedupMonth = month;
        var seen = new HashSet<warinwars>();
        for (var i = 0; i < state.ingamewars.Length; i++)
        {
            var war = state.ingamewars[i];
            if (!war.is_going) continue;
            if (!seen.Add(war)) war.is_going = false;
        }
    }

    // ================= 自动存档 =================
    // 原版 Savescript 写 NewData/*.save(旧格式), 与存档界面的 SaveService 不互通,
    // 且槽位取全局 savePlace(会覆盖手动档)。这里由逻辑层接管: 按原版时间条件
    // (每月 1 日 / 每 6 个月 1 日) 写独立的 0 号自动槽, 界面与手动档同格式.
    static int _autoSaveDay = -1;

    public static void MaybeAutoSave()
    {
        var s = Global.gameState;
        if (Global.speed <= 0 || Global.autosavej <= 0) return;
        if (s.data[19] != 1) return;
        if (Global.autosavej == 2 && s.data[20] % 6 != 0) return;
        var key = s.data[21] * 10000 + s.data[20] * 100 + s.data[19];
        if (key == _autoSaveDay) return;
        _autoSaveDay = key;
        Port.SaveService.Save(s, Port.SavePaths.Slot(Port.SavePaths.AutoSlot));
    }
}
