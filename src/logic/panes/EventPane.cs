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
    // 原版结算是切到结果页, 不会重算事件正文; 而 TextOfEvents 依赖"正在进行的战争编号"
    // data[82], 该编号在 ResultsOfEvents 里就被复位成 -10(见 GameState.xxx)。
    // 结算后再调一次 TextOfEvents 会 ingamewars[-10] 越界(事件 18 战争结束必现),
    // 所以正文只在未结算时取一次, 结果页复用.
    string _title = "";
    string _body = "";
    // 事件类 Awake 把 GameState 缓存在字段 a 里; 读档/重开换掉 gameState 后,
    // 同编号事件若复用旧脚本, 文本与结果都会写进上一档的对象.
    GameState _state;

    // 控制台 event n 选项 直接结算后取结果文本
    public string Result => _result;

    // 控制台 events 检索: 事件正文只存在于 Event{N}.TextOfEvents 里, 没有静态表可查,
    // 只能按编号实例化跑一次(结果缓存, 同一局反复翻页不重复跑).
    static readonly Dictionary<int, string> ProbeTexts = new();

    public static string TextOf(int number)
    {
        if (ProbeTexts.TryGetValue(number, out var cached)) return cached;
        var type = typeof(Event1).Assembly.GetType("Event" + number);
        var stub = Stub.Take(type, "EventProbe" + number, Lifecycle.Scene);
        AchievementCenter.Register(stub.Also<achievements>());
        var script = stub.Activate().Typed<Component>();
        // 与 EnsureScript 同一条规矩: 事件类的 GameState 缓存在 a, 不灌就整页空文本
        var stateField = type.GetField("a",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
        if (stateField != null) stateField.SetValue(script, GameHost.State);
        var args = new object[] { "", "" };
        // 检索口径: 事件正文用 data[82](正在进行的战争编号) 取战争名, 控制台没有战场可报,
        // 先给 0 让正文走"无战争"分支, 跑完原样还回去 —— 只影响这一句文本, 不动存档状态.
        var state = GameHost.State;
        var war = state.data[82];
        state.data[82] = 0;
        type.GetMethod("TextOfEvents").Invoke(script, args);
        state.data[82] = war;
        var text = (args[0] + " " + args[1]).Replace("\n", " ").Trim();
        ProbeTexts[number] = text;
        return text;
    }

    public Dictionary<string, object> Snapshot()
    {
        var state = GameHost.State;
        EnsureScript(state.number_event);

        if (_result.Length == 0)
        {
            var args = new object[] { "", "" };
            _script.GetType().GetMethod("TextOfEvents").Invoke(_script, args);
            _title = (string)args[0];
            _body = (string)args[1];
        }

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
            .Put("title", _title)
            .Put("body", _body)
            .Put("options", options)
            .Put("result", _result)
            .Put("number", state.number_event)
            .Build();
    }

    public void Act(string action, List<object> args)
    {
        switch (action)
        {
            // 原版每次进事件场景都新建 EventN 对象(doneventscript.Awake);
            // 新事件可能沿用同一编号(战争结束 18 反复出现), 必须按"进场景"重建状态.
            case "进入":
                _script = null;
                _number = -1;
                _result = "";
                _title = "";
                _body = "";
                break;
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
        // 原版中文结果页 Results_text.Azkaba: 事件类 ResultsOfEvents 之后一定跟一步 Pereraschyot,
        // 它把 party_change 落到 party_ideology/party_number 并重算执政派系 data[56].
        ResultsStub().Invoke("Pereraschyot");
        // 毛主席逝世(事件 3): 解锁自建成就 1976 并播放事件音乐, 与 dh-4591 扩展包的约定一致
        if (state.number_event == 3)
        {
            AchievementCenter.Unlock(CustomMaoDeath);
            UiEvents.RequestEventMusic("mao_dead");
        }
    }

    // 自建成就编号: 避开 Steam ACH_1..211, 沿用 dh-4591 扩展包的 1976
    const int CustomMaoDeath = 1976;

    static Stub _results;

    static Stub ResultsStub()
    {
        if (_results != null) return _results;
        _results = Stub.Take<Results_text>("ResultsText", Lifecycle.None);
        _results.Set("global1", GameHost.Global);
        _results.Set("achieves", GameObject.Find("Ach(Clone)"));
        _results.Set("party_change", new float[5]);
        return _results;
    }

    // 原版结果页是 Results_text: 点击 → LoadScene(load_scene_after_click), 默认 Diplomacy;
    // 事件类自己的 Update 只在特定结果把目标改成结局/链式事件(LoadScene 的参数才是唯一可靠下一站).
    // Godot 按钮在释放后触发, 这里合成"左键按住"让原版收尾逻辑执行,
    // 并用 SuppressLoadScene 捕获它请求的场景, 没请求就按原版默认回外交.
    void Close()
    {
        // 事件类的收尾 Update 是 private(隐藏 MonoBehaviour 的 public virtual 空实现), 必须按
        // 具体类型逐层找; 用带 Public 的 GetMethod 会命中基类空实现或抛歧义, 结局/链式事件
        // 就会静默回外交(四人帮"不要干预"正是这条路).
        var update = Stub.FindLifecycle(_script.GetType(), "Update");
        if (update == null)
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
        // 设置页「事件结束后自动暂停」: 原版 TimeScript 随事件场景卸载、回来续跑;
        // 玩家要求停表时在这里把 speed 归零(只改速度, 不动任何数值).
        if (GameHost.EventPauseAfter) GameHost.PauseTime();
    }

    void EnsureScript(int number)
    {
        var state = GameHost.State;
        // 同一档里同一事件编号才复用; 换档(读档/重开)必须重建, 否则事件类 Awake 缓存的
        // GameState 引用还指向上一个档.
        if (_script != null && _number == number && _state == state) return;
        // 原版事件场景 doneventscript.Awake 的第一件事: 把当前事件记成已发生.
        // 由地图事件图标进来时 EventScript.OnMouseDown 已经写过一次; 但外交按钮 / 决议
        // 直接 LoadScene("Event") 不经过 EventScript, 这一行就是它唯一的落地处 ——
        // 漏掉后所有"事件结束后才出现的进一步按钮/决议条件"永远不满足.
        if (state.number_event != 60000) state.event_done[state.number_event] = true;
        var type = typeof(Event1).Assembly.GetType("Event" + number);
        // 原版 doneventscript.Awake 用 thisObject.AddComponent(EventN), Unity 负责跑 Awake;
        // 事件类把 GameState 缓存(a)与结算用的派生数值都放在 Awake 里, 不跑就:
        //   TextOfEvents/VariantsOfEvents → a.* 空引用 → 事件页整页空白;
        //   ResultsOfEvents → 文案与扣款全跳过(选完不扣钱).
        // Scene = 依赖场景兄弟对象的驱动: 字段就位后立刻 Activate, 不靠"记得调 Awake".
        var stub = Stub.Take(type, "Event" + number, Lifecycle.Scene);
        // 原版事件类的 Set(n) 走 gameObject.GetComponent<achievements>(), 事件对象必须挂组件
        AchievementCenter.Register(stub.Also<achievements>());
        _script = stub.Activate().Typed<Component>();
        // 318 个用 a 缓存 GameState 的事件类里, 只有 Event1 漏写了 Awake(a 永远 null),
        // 原版靠 Unity 吞异常把选举结论静默跳过; 移植版没有那层兜底会整页报错.
        // 其余事件类之后重复赋同一个值, 无副作用.
        var stateField = _script.GetType().GetField("a",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic);
        if (stateField != null) stateField.SetValue(_script, state);
        _number = number;
        _state = state;
        _result = "";
        _title = "";
        _body = "";
    }
}
