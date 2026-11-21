// 1986 抉择: 功成身退走原版 in1992_script; 入口可用性走原版 CascadScrupt.
using System.Collections.Generic;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class RetirePane : IPanel
{
    public string Name => "1986抉择";

    public Dictionary<string, object> Snapshot() => new PanelSnapshot().Build();

    static Stub _cascad;
    static GameObject _postExit;
    static SpeedScript[] _speeds;

    // 原版 ESC 菜单(CascadScrupt)在 1986 年后才把 PostExit 打开. 这里直接调原版判定,
    // 桥层/视图都不复制年份条件; 只把"能不能结束"交给菜单显隐.
    public static bool Available()
    {
        if (_cascad == null)
        {
            var cascad = new GameObject("RetireMenuProbe");
            _postExit = new GameObject("RetirePostExitProbe");
            _speeds = new SpeedScript[4];
            for (var i = 0; i < _speeds.Length; i++)
            {
                var go = new GameObject("RetireSpeedProbe" + i);
                go.AddComponent<SpriteRenderer>();
                var speedStub = Stub.On<SpeedScript>(go, Lifecycle.None);
                speedStub.Set("global1", GameHost.Global);
                speedStub.Set("this_number", i);
                speedStub.Set("on", new Sprite { name = "on" });
                speedStub.Set("off", new Sprite { name = "off" });
                _speeds[i] = speedStub.Typed<SpeedScript>();
            }
            _cascad = Stub.Take<CascadScrupt>("RetireCascadProbe", Lifecycle.None);
            _cascad.Also<SpriteRenderer>();
            _cascad.Set("global1", GameHost.Global);
            _cascad.Set("menu", true);
            _cascad.Set("Cascad", cascad);
            _cascad.Set("PostExit", _postExit);
            _cascad.Set("other", _speeds);
        }
        _cascad.Set("turn_on", false);
        _postExit.SetActive(false);
        var speed = GameHost.Speed;
        _cascad.Invoke("OnMouseDown");
        GameHost.Global.speed = speed;
        return _postExit.activeSelf;
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "功成身退":
                var stub = Stub.Take<in1992_script>("RetireProbe", Lifecycle.Lazy);
                stub.Invoke("OnMouseDown");
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "1986抉择没有该动作");
        }
    }
}
