// 逻辑层 -> 视图层的一次性通知.
using System;
using UnityEngine.SceneManagement;

namespace CML.Logic;

public static class UiEvents
{
    public static event Action<string> SceneRequested;
    public static event Action<string> ToastRequested;
    public static event Action<string> UnhandledSceneRequested;
    // 指定事件触发时要播的事件音乐(assets/audio/eventmusic/<name>.mp3)
    public static event Action<string> EventMusicRequested;
    // 事件界面选项的键盘动作: 240..245 = 勾选选项 1..6, 246 = 上一个, 247 = 下一个
    public static event Action<int> EventShortcutRequested;
    // 领土块/国家意识形态被改动: 地图着色与显隐要按新数据重取一次快照
    public static event Action MapDirty;

    public static void RequestScene(string unitySceneName)
    {
        Godot.GD.Print($"[RequestScene] {unitySceneName} 映射={SceneRouter.TryGetScenePath(unitySceneName, out var path)} 订阅={(SceneRequested != null)}");
        if (SceneRouter.TryGetScenePath(unitySceneName, out path)) SceneRequested?.Invoke(path);
        else UnhandledSceneRequested?.Invoke(unitySceneName);
    }

    public static void RequestScenePath(string godotPath) => SceneRequested?.Invoke(godotPath);

    public static void Toast(string text) => ToastRequested?.Invoke(text);

    public static void RequestEventMusic(string name) => EventMusicRequested?.Invoke(name);

    public static void RequestEventShortcut(int code) => EventShortcutRequested?.Invoke(code);

    public static void RequestMapDirty() => MapDirty?.Invoke();

}
