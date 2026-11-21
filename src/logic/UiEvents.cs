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

    public static void RequestScene(string unitySceneName)
    {
        Godot.GD.Print($"[RequestScene] {unitySceneName} 映射={SceneRouter.TryGetScenePath(unitySceneName, out var path)} 订阅={(SceneRequested != null)}");
        if (SceneRouter.TryGetScenePath(unitySceneName, out path)) SceneRequested?.Invoke(path);
        else UnhandledSceneRequested?.Invoke(unitySceneName);
    }

    public static void RequestScenePath(string godotPath) => SceneRequested?.Invoke(godotPath);

    public static void Toast(string text) => ToastRequested?.Invoke(text);

    public static void RequestEventMusic(string name) => EventMusicRequested?.Invoke(name);
}
