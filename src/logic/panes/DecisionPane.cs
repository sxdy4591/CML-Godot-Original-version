// 决议界面: 文本/图标/可执行性/执行全部走原版 DecisionButtonScript, 这里只装配按钮对象图.
using System.Collections.Generic;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class DecisionPane : IPanel
{
    public string Name => "决议";

    static GameObject _back;
    static DecisionButtonScript[] _buttons;

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        EnsureBack();
        // 原版决议场景每次打开都走 FocusesScript.Awake → CreateDecisions(), 执行后也走
        // Repaint() → CreateDecisions(): 决议池是按"当前局势"重新构造的(阵营领袖/修正/
        // 傀儡这类三元分支在构造时定型). 只建一次就会把开局那版分支固化, 条件看起来
        // 满足却永远不亮、选了效果也不是当前局势该有的那套.
        GameHost.Global.CreateDecisions();
        if (_buttons == null || _buttons.Length != state.decisions.Length)
            _buttons = new DecisionButtonScript[state.decisions.Length];

        var list = new List<object>();
        for (var i = 0; i < state.decisions.Length; i++)
        {
            var button = Ensure(i, state.decisions[i]);
            list.Add(new Dictionary<string, object>
            {
                ["index"] = i,
                ["name"] = state.decisions[i].name,
                ["desc"] = state.decisions[i].desc,
                ["req"] = state.decisions[i].req,
                ["result"] = state.decisions[i].result,
                // 原版 ChangeCondition: completed → done / condition 假 → unready / 否则 ready
                ["available"] = button.background_sprite.sprite == button.ready,
                ["completed"] = state.completedDecisions[i],
                ["icon"] = button.focus_sprite.sprite == null ? "" : button.focus_sprite.sprite.name,
                // 每个周期型决议一条自己的开关(原版没有总开关)
                ["autoable"] = Automation.IsAutoableDecision(i),
                ["auto"] = Automation.IsDecisionEnabled(i),
            });
        }
        return new PanelSnapshot()
            .Put("decisions", list)
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        var index = (int)(long)args[0];
        switch (action)
        {
            case "执行":
                // 原版 OnMouseDown 自己守"背景 == ready", 执行完还会重建决议池
                Ensure(index, GameHost.State.decisions[index]).OnMouseDown();
                break;
            case "切换自动":
                // 每条决议独立开关
                Automation.ToggleDecision((int)(long)args[0]);
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "决议面板没有该动作");
        }
    }

    // 原版 DecisionButtonScript.OnMouseDown 结尾 Find("Back").Repaint() 重建决议池
    static void EnsureBack()
    {
        if (_back != null) return;
        // 原版 FocusesScript.Awake 会按 prefab 造 36 张卡; 这里只借它的 Repaint 重建决议池,
        // 所以声明 None: 不跑 Awake/Start, focuses 留空数组.
        var stub = Stub.Take<FocusesScript>("Back", Lifecycle.None);
        stub.Set("focuses", new GameObject[0]);
        _back = stub.Go;
        // 原版 ChangeIcon 用 Resources.Load<Sprite>("decision_sp\\D{n}") 与 special/znachki 数组,
        // 贴图由视图按 sprite 名加载; 这里注册占位 Sprite 让原版把资源名写进 sprite.name.
        for (var i = 0; i < 54; i++)
        {
            var name = "D" + i;
            GameDataRegistry.RegisterFactory("decision_sp\\D" + i, () => new Sprite { name = name });
        }
    }

    static DecisionButtonScript Ensure(int index, Decision decision)
    {
        EnsureBack();
        var button = _buttons[index];
        if (button == null)
        {
            var stub = Stub.Take<DecisionButtonScript>("Decision" + index, Lifecycle.None);
            stub.Also<SpriteRenderer>();
            stub.Set("num", index);
            stub.Set("text", new TextMesh());
            stub.Set("okno1", Stub.Take<OkoshkoScript>("DecisionOkno" + index, Lifecycle.None).Typed<OkoshkoScript>());
            stub.Set("focus_sprite", new SpriteRenderer());
            stub.Set("background_sprite", new SpriteRenderer());
            stub.Set("ready", new Sprite { name = "ready" });
            stub.Set("done", new Sprite { name = "done" });
            stub.Set("unready", new Sprite { name = "unready" });
            stub.Set("on", new Sprite { name = "on" });
            stub.Set("off", new Sprite { name = "off" });
            stub.Set("special", new[] { new Sprite { name = "D20-special" } });
            var znachki = new Sprite[54 - 36];
            for (var z = 0; z < znachki.Length; z++) znachki[z] = new Sprite { name = "D" + (36 + z) };
            stub.Set("znachki", znachki);
            button = stub.Typed<DecisionButtonScript>();
            _buttons[index] = button;
        }
        button.ChangeText(decision);
        button.ChangeIcon(index);
        button.ChangeCondition();
        return button;
    }
}
