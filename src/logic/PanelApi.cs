// 面板协议: 快照容器 / 面板接口 / 反射注册.
using System.Collections.Generic;

namespace CML.Logic;

public sealed class PanelSnapshot
{
    readonly Dictionary<string, object> _data = new();

    public PanelSnapshot Put(string key, object value) { _data[key] = value; return this; }
    public PanelSnapshot Put(string key, int value) => Put(key, (object)value);
    public PanelSnapshot Put(string key, bool value) => Put(key, (object)value);
    public PanelSnapshot Put(string key, string value) => Put(key, (object)value);

    public Dictionary<string, object> Build() => _data;
}

public interface IPanel
{
    string Name { get; }
    Dictionary<string, object> Snapshot();
    void Act(string action, List<object> args);
}

public static class PanelRouter
{
    static readonly Dictionary<string, IPanel> Panels = new();

    public static void Register(IPanel panel) => Panels[panel.Name] = panel;

    public static bool TryGet(string name, out IPanel panel)
        => Panels.TryGetValue(name, out panel);

    public static IEnumerable<string> Names => Panels.Keys;

    public static void RegisterAll()
    {
        var contract = typeof(IPanel);
        foreach (var type in contract.Assembly.GetTypes())
        {
            if (type.IsAbstract || !contract.IsAssignableFrom(type)) continue;
            Register((IPanel)System.Activator.CreateInstance(type));
        }
    }
}
