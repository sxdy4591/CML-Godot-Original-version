// GDScript 与逻辑层之间唯一的门面: 查表 + 类型转换 + 信号.
// GDScript 侧统一用 snake_case: request / act / panel_snapshot / map_highlight / scene_requested / toast.
using CML.Logic;
using CML.Logic.Panes;
using CML.Logic.Port;
using Godot;

namespace CML.Bridge;

public partial class UiBridge : Node
{
    public static UiBridge Instance { get; private set; }

    const string PanelSnapshotSignal = "panel_snapshot";
    const string MapHighlightSignal = "map_highlight";
    const string SceneRequestedSignal = "scene_requested";
    const string ToastSignal = "toast";
    // 任何面板动作都可能改数值; 常驻顶栏靠这个信号即时刷新, 不必等自己的轮询窗口
    const string DataChangedSignal = "data_changed";
    // 成就解锁提示 / 事件内指定音乐(音频总管监听)
    const string AchievementSignal = "achievement_unlocked";
    const string EventMusicSignal = "event_music";

    // 原版 TimeScript 只存在于外交场景(含地图模式); 其它界面里时间与事件倒计时都停
    const string DiplomacyScene = "res://scenes/外交/外交.tscn";

    // 信号必须在任何场景脚本 _ready 连接之前注册, 放 _EnterTree 比 _Ready 更早.
    public override void _EnterTree()
    {
        AddUserSignal(PanelSnapshotSignal, new Godot.Collections.Array { "panel", "data" });
        AddUserSignal(MapHighlightSignal, new Godot.Collections.Array { "indices" });
        AddUserSignal(SceneRequestedSignal, new Godot.Collections.Array { "path" });
        AddUserSignal(ToastSignal, new Godot.Collections.Array { "text" });
        AddUserSignal(DataChangedSignal, new Godot.Collections.Array());
        AddUserSignal(AchievementSignal, new Godot.Collections.Array { "number" });
        AddUserSignal(EventMusicSignal, new Godot.Collections.Array { "name" });
    }

    public override void _Ready()
    {
        Instance = this;
        UiEvents.SceneRequested += OnScene;
        UiEvents.ToastRequested += OnToast;
        UiEvents.UnhandledSceneRequested += OnUnhandledScene;
        UiEvents.EventMusicRequested += OnEventMusic;
        // 原版 SceneManager.LoadScene 的出口: compat 只发原始场景名, 由桥层转成场景请求
        UnityEngine.SceneManagement.SceneRouter.Requested += UiEvents.RequestScene;
        // 设置页的难度([ui] difficulty)必须在 Boot 之前落到原版的 our_diff_in,
        // GameState.diff 才会在 Global.Init 里读对, 开局数据/难度系数才按模式区分.
        GameHost.SetDifficulty(ReadDifficulty());
        GameHost.Boot();        GD.Print($"[UiBridge] 内核启动完成, 已注册面板: {string.Join(",", PanelRouter.Names)}");
    }

    public override void _ExitTree()
    {
        UiEvents.SceneRequested -= OnScene;
        UiEvents.ToastRequested -= OnToast;
        UiEvents.UnhandledSceneRequested -= OnUnhandledScene;
        UiEvents.EventMusicRequested -= OnEventMusic;
        Instance = null;
    }

    public override void _Process(double delta)
    {
        if (!GameHost.Booted) return;
        // 场景切换有两条路(原版 LoadScene 与 全局管理.request_scene_change), 所以每帧按当前场景判定,
        // 不依赖 OnScene: 只有外交场景(含地图模式)推进时间.
        GameHost.SetMainScene(GetTree().CurrentScene?.SceneFilePath == DiplomacyScene);
        // 自动存档/战争去重/自动化/地图扫描/事件倒计时全在逻辑层按时序推进;
        // 桥层只剩两件事: 每帧叫一次, 把"高亮集合变了"翻成信号.
        GameHost.Tick(delta);
        // 原版 Set(n) 与自建 Unlock 都只是写 ach_this, 这里做差分把"新解锁"翻成信号
        foreach (var number in AchievementCenter.DrainNewUnlocks()) EmitSignal(AchievementSignal, number);
        if (MapPane.ConsumeDirty()) EmitSignal(MapHighlightSignal, UiVariant.ToArray(MapPane.HighlightList()));
    }

    // 桥层自己读 playerprefs 的 [ui] difficulty: UISettings 的 _cfg 要等它自己的 _Ready 才建,
    // 这里在 Boot 之前调用会拿到 null.
    static int ReadDifficulty()
    {
        var cfg = new Godot.ConfigFile();
        cfg.Load("user://playerprefs.ini");
        return (int)cfg.GetValue("ui", "difficulty", 2);
    }

    // GDScript 入口
    public void request(string panel)
    {
        PanelRouter.TryGet(panel, out var handler);
        EmitSignal(PanelSnapshotSignal, panel, UiVariant.ToDictionary(handler.Snapshot()));
    }

    // 自动化类别勾选由 GDScript 落盘(playerprefs), 启动/切场景时再推回来.
    // 勾选真值在逻辑层 Automation, bridge 只搬运.
    public void set_auto_types(string text) => Automation.SetTypesString(text);

    // 周期型决议的自动勾选: 逐条独立(下标清单 "24,25"), 没有总开关
    public void set_auto_decisions(string text) => Automation.SetDecisionTypesString(text);

    // 1986 抉择的入口是否出现: 原版 CascadScrupt 判定(1986 年后), 桥层只转发结果
    public bool retire_available() => RetirePane.Available();

    // 自动存档开关(0关/1每月/2半年)与保存槽位(1..5): 设置页落盘在 playerprefs,
    // 原版真值在 GlobalScript.autosavej / savePlace, 进游玩场景时推回.
    public void set_save_options(int autosave, int saveplace)
        => GameHost.SetSaveOptions(autosave, saveplace);

    // 成就提示弹窗只需标题/描述: 桥层做一次查表转发, 不让视图去拉整页快照.
    public Godot.Collections.Array achievement_text(int number)
    {
        var result = new Godot.Collections.Array();
        for (var i = 0; i < AchievementCatalog.Count; i++)
        {
            if (AchievementCatalog.Numbers[i] != number) continue;
            result.Add(AchievementCatalog.Titles[i]);
            result.Add(AchievementCatalog.Descs[i].Replace("|", "\n"));
            return result;
        }
        return result;
    }

    public void act(string panel, string action, Godot.Collections.Array args)
    {
        PanelRouter.TryGet(panel, out var handler);
        handler.Act(action, UiVariant.FromArray(args));
        EmitSignal(DataChangedSignal);
    }

    // 场景切换由桥层直接执行: 原版 LoadScene 的唯一出口.
    // 事件请求发生在快照/泵回调中, 同步 ChangeSceneToFile 会释放当前场景,
    // 因此统一延迟到帧末执行.
    void OnScene(string path)
    {
        GD.Print($"[OnScene] 切场景: {path}");
        EmitSignal(SceneRequestedSignal, path);
        GetTree().CallDeferred("change_scene_to_file", path);
    }
    void OnToast(string text) => EmitSignal(ToastSignal, text);
    void OnEventMusic(string name) => EmitSignal(EventMusicSignal, name);
    void OnUnhandledScene(string name) => GD.PushError($"原版场景未映射: {name}");
}
