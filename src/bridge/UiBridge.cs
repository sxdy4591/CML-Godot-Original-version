// GDScript 与逻辑层之间唯一的门面: 查表 + 类型转换 + 信号.
// GDScript 侧统一用 snake_case: request / act / panel_snapshot / map_highlight / scene_requested / toast.
using CML.Logic;
using CML.Logic.Panes;
using Godot;

namespace CML.Bridge;

public partial class UiBridge : Node
{
    public static UiBridge Instance { get; private set; }

    const string PanelSnapshotSignal = "panel_snapshot";
    const string MapHighlightSignal = "map_highlight";
    const string SceneRequestedSignal = "scene_requested";
    const string ToastSignal = "toast";

    // 信号必须在任何场景脚本 _ready 连接之前注册, 放 _EnterTree 比 _Ready 更早.
    public override void _EnterTree()
    {
        AddUserSignal(PanelSnapshotSignal, new Godot.Collections.Array { "panel", "data" });
        AddUserSignal(MapHighlightSignal, new Godot.Collections.Array { "indices" });
        AddUserSignal(SceneRequestedSignal, new Godot.Collections.Array { "path" });
        AddUserSignal(ToastSignal, new Godot.Collections.Array { "text" });
    }

    public override void _Ready()
    {
        Instance = this;
        UiEvents.SceneRequested += OnScene;
        UiEvents.ToastRequested += OnToast;
        UiEvents.UnhandledSceneRequested += OnUnhandledScene;
        // 原版 SceneManager.LoadScene 的出口: compat 只发原始场景名, 由桥层转成场景请求
        UnityEngine.SceneManagement.SceneRouter.Requested += UiEvents.RequestScene;
        GameHost.Boot();        GD.Print($"[UiBridge] 内核启动完成, 已注册面板: {string.Join(",", PanelRouter.Names)}");
    }

    public override void _ExitTree()
    {
        UiEvents.SceneRequested -= OnScene;
        UiEvents.ToastRequested -= OnToast;
        UiEvents.UnhandledSceneRequested -= OnUnhandledScene;
        Instance = null;
    }

    public override void _Process(double delta)
    {
        if (!GameHost.Booted) return;
        // 自动存档/战争去重/自动化/地图扫描/事件倒计时全在逻辑层按时序推进;
        // 桥层只剩两件事: 每帧叫一次, 把"高亮集合变了"翻成信号.
        GameHost.Tick(delta);
        if (MapPane.ConsumeDirty()) EmitSignal(MapHighlightSignal, UiVariant.ToArray(MapPane.HighlightList()));
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

    public void set_auto_decision(bool on) => Automation.SetDecision(on);

    // 自动存档开关(0关/1每月/2半年)与保存槽位(1..5): 设置页落盘在 playerprefs,
    // 原版真值在 GlobalScript.autosavej / savePlace, 进游玩场景时推回.
    public void set_save_options(int autosave, int saveplace)
    {
        GameHost.Global.autosavej = autosave;
        GameHost.Global.savePlace = saveplace;
    }

    public void act(string panel, string action, Godot.Collections.Array args)
    {
        PanelRouter.TryGet(panel, out var handler);
        handler.Act(action, UiVariant.FromArray(args));
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
    void OnUnhandledScene(string name) => GD.PushError($"原版场景未映射: {name}");
}
