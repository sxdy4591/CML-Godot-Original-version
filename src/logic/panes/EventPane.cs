// 事件界面: 调原版 Event{N} 的 TextOfEvents / VariantsOfEvents / ResultsOfEvents.
using System.Collections.Generic;
using UnityEngine;

namespace CML.Logic.Panes;

public sealed class EventPane : IPanel
{
    public string Name => "事件";

    const string EventNamespace = "Assembly-CSharp";

    Component _script;
    int _number = -1;
    string _result = "";

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        EnsureScript(state.number_event);

        var name = "";
        var body = "";
        var args = new object[] { name, body };
        _script.GetType().GetMethod("TextOfEvents").Invoke(_script, args);
        name = (string)args[0];
        body = (string)args[1];

        var options = new List<object>();
        var kolvo = 0;
        var fake = new string[6];
        var buttons = new GameObject[6];
        for (var i = 0; i < buttons.Length; i++) buttons[i] = new GameObject("EventOption" + i);
        var variantArgs = new object[] { kolvo, fake, buttons };
        _script.GetType().GetMethod("VariantsOfEvents").Invoke(_script, variantArgs);
        kolvo = (int)variantArgs[0];
        fake = (string[])variantArgs[1];
        buttons = (GameObject[])variantArgs[2];
        for (var i = 0; i < kolvo; i++)
        {
            options.Add(new Dictionary<string, object>
            {
                ["text"] = fake[i],
                ["enabled"] = !buttons[i].Destroyed,
            });
        }

        return new PanelSnapshot()
            .Put("title", name)
            .Put("body", body)
            .Put("options", options)
            .Put("result", _result)
            .Put("number", state.number_event)
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            case "选择":
                Pick((int)(long)args[0]);
                break;
            case "关闭":
                Close();
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(action), action, "事件面板没有该动作");
        }
    }

    void Pick(int index)
    {
        var state = GameHost.State;
        // 原版 Results_text.Azkaba 开头: 结果落地时确保 1 号党(中共)启用
        state.is_party_enabled[1] = true;
        // 原版 Results_text.Awake: resultOfEvents[number_event] = number_otvet - 1
        state.resultOfEvents[state.number_event] = index;
        state.number_otvet = index + 1;
        // 原版 Results_text.Azkaban: ResultsOfEvents(ref title, ref text, number_otvet - 1)
        var name = "";
        var text = "";
        var resultArgs = new object[] { name, text, index };
        _script.GetType().GetMethod("ResultsOfEvents").Invoke(_script, resultArgs);
        _result = (string)resultArgs[1];
    }

    // 原版结果页是 Results_text: 点击 → LoadScene(load_scene_after_click), 默认 Diplomacy;
    // 事件类自己的 Update 只在特定结果把目标改成结局/链式事件(LoadScene 的参数才是唯一可靠下一站).
    // Godot 按钮在释放后触发, 这里合成"左键按住"让原版收尾逻辑执行,
    // 并用 SuppressLoadScene 捕获它请求的场景, 没请求就按原版默认回外交.
    void Close()
    {
        var update = _script.GetType().GetMethod("Update",
            System.Reflection.BindingFlags.Instance
            | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
        if (update == null || update.DeclaringType == typeof(UnityEngine.MonoBehaviour))
        {
            UiEvents.RequestScene("Diplomacy");
            return;
        }
        var previousClick = UnityEngine.Input.SimulateLeftClickPressed;
        var previousSuppress = UnityEngine.SceneManagement.SceneRouter.SuppressLoadScene;
        UnityEngine.Input.SimulateLeftClickPressed = true;
        UnityEngine.SceneManagement.SceneRouter.SuppressLoadScene = true;
        UnityEngine.SceneManagement.SceneRouter.ClearCapturedScene();
        update.Invoke(_script, null);
        UnityEngine.SceneManagement.SceneRouter.SuppressLoadScene = previousSuppress;
        UnityEngine.Input.SimulateLeftClickPressed = previousClick;
        UiEvents.RequestScene(
            UnityEngine.SceneManagement.SceneRouter.ConsumeCapturedScene() ?? "Diplomacy");
    }

    void EnsureScript(int number)
    {
        if (_script != null && _number == number) return;
        var type = typeof(Event1).Assembly.GetType("Event" + number);
        // 原版 doneventscript.Awake 用 thisObject.AddComponent(EventN), Unity 负责跑 Awake;
        // 事件类把 GameState 缓存(a)与结算用的派生数值都放在 Awake 里, 不跑就:
        //   TextOfEvents/VariantsOfEvents → a.* 空引用 → 事件页整页空白;
        //   ResultsOfEvents → 文案与扣款全跳过(选完不扣钱).
        // Scene = 依赖场景兄弟对象的驱动: 字段就位后立刻 Activate, 不靠"记得调 Awake".
        _script = Stub.Take(type, "Event" + number, Lifecycle.Scene).Activate().Typed<Component>();
        _number = number;
        _result = "";
    }
}
