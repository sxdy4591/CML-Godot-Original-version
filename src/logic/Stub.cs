// 替身工厂: 接管原版组件的唯一入口.
// Unity 里组件的 Awake/Start/Update 由引擎按场景自动驱动; 移植后每个替身必须声明谁驱动它,
// 否则就会出现"文案空/数值不刷/按钮不动, 但也没有任何报错"这一类问题.
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace CML.Logic;

public enum Lifecycle
{
    // 纯数据替身: 不跑生命周期, 只反射调方法(界面里的按钮/文本对象).
    None,
    // 交给 UnityRuntime 泵: Awake/Start/Update 按原版顺序每帧驱动(时间推进/事件倒计时).
    Pump,
    // 装配期只建对象; 第一次 Invoke 前跑一次 Awake/Start —— 此时字段已由 Set 绑齐.
    Lazy,
    // Awake 依赖场景里的兄弟对象: 由装配者在依赖建好后调 Activate(); 没激活就 Invoke 直接抛.
    Scene,
}

public sealed class Stub
{
    const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
    readonly Dictionary<string, FieldInfo> _fields = new();

    public GameObject Go { get; }
    public Component Component { get; }
    Lifecycle _lifecycle;
    bool _ready;

    Stub(GameObject go, Component component, Lifecycle lifecycle)
    {
        Go = go;
        Component = component;
        _lifecycle = lifecycle;
        _ready = lifecycle == Lifecycle.None || lifecycle == Lifecycle.Pump;
    }

    public static Stub Take<T>(string name, Lifecycle lifecycle) where T : Component, new()
        => Take(typeof(T), name, lifecycle);

    public static Stub Take(Type type, string name, Lifecycle lifecycle)
    {
        var go = new GameObject(name);
        var component = (Component)go.AddComponent(type);
        if (lifecycle != Lifecycle.Pump) Detach(component);
        return new Stub(go, component, lifecycle);
    }

    // 对象和组件都已经在(原版场景里的既有实例), 只接管生命周期.
    public static Stub Wrap<T>(GameObject go, Lifecycle lifecycle) where T : Component
    {
        var component = go.GetComponent<T>();
        if (lifecycle != Lifecycle.Pump) Detach(component);
        return new Stub(go, component, lifecycle);
    }

    // 对象已经存在(原版场景里本来就有的 GameObject), 只把组件接管过来.
    public static Stub On(GameObject go, Type type, Lifecycle lifecycle)
    {
        var component = (Component)go.AddComponent(type);
        if (lifecycle != Lifecycle.Pump) Detach(component);
        return new Stub(go, component, lifecycle);
    }

    public static Stub On<T>(GameObject go, Lifecycle lifecycle) where T : Component, new()
        => On(go, typeof(T), lifecycle);

    public static void Detach(Component c)
    {
        if (c is MonoBehaviour m) UnityRuntime.UnregisterMonoBehaviour(m);
    }

    // Scene 驱动的组件在这里显式起生命周期(Unity 的 Awake → Start 顺序, 各一次)
    public Stub Activate()
    {
        if (_lifecycle == Lifecycle.None) throw new InvalidOperationException($"[Stub] {Name} 声明 None, 不跑生命周期");
        if (_lifecycle == Lifecycle.Pump) throw new InvalidOperationException($"[Stub] {Name} 声明 Pump, 由 UnityRuntime 驱动");
        if (_ready) return this;
        _ready = true;
        InvokeLifecycle("Awake");
        InvokeLifecycle("Start");
        return this;
    }

    void InvokeLifecycle(string method)
    {
        var info = Component.GetType().GetMethod(method, Flags);
        if (info != null) info.Invoke(Component, null);
    }

    void EnsureReady()
    {
        if (_ready) return;
        if (_lifecycle == Lifecycle.Lazy) { Activate(); return; }
        throw new InvalidOperationException($"[Stub] {Name} 声明 Scene 驱动, 依赖没建好就调了原版方法");
    }

    string Name => Component == null ? "?" : Component.GetType().Name;

    // 在已有对象上挂"场景兄弟组件"(原版同一 GameObject 上的其他脚本), 不跑生命周期.
    public static T Attach<T>(GameObject go) where T : Component, new()
    {
        var added = go.AddComponent<T>();
        Detach(added);
        return added;
    }

    public static Component Attach(GameObject go, Type type)
    {
        var added = go.AddComponent(type);
        Detach(added);
        return added;
    }

    // 同一对象上同一个组件只挂一个(装配工具自己的幂等, 不是业务兜底).
    public T Also<T>() where T : Component, new() => Go.GetComponent<T>() ?? Attach<T>(Go);

    public T Typed<T>() where T : class => (T)(object)Component;

    public TextMesh BindText(string field)
    {
        var go = new GameObject(field);
        var text = go.AddComponent<TextMesh>();
        Set(field, text);
        return text;
    }

    public Stub BindTexts(params string[] fields)
    {
        foreach (var f in fields) BindText(f);
        return this;
    }

    public string ReadText(string field) => ((TextMesh)Get(field)).text;

    public object Get(string field) => Find(field).GetValue(Component);

    public T Get<T>(string field) where T : class => (T)Get(field);

    public Stub Set(string field, object value)
    {
        Find(field).SetValue(Component, value);
        return this;
    }

    public object Invoke(string method, params object[] args)
    {
        EnsureReady();
        return Component.GetType().GetMethod(method, Flags).Invoke(Component, args);
    }

    FieldInfo Find(string field) => Component.GetType().GetField(field, Flags);
}
