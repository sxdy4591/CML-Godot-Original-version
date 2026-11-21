// ============================================================
// 逻辑层 — PoliticsHost: 政治界面接管原版组件层
//
// 原版政治动作的全部结算都在 Button_Pol_Script.OnMouseDown 里; 它依赖
// Politic_Manager(卡组/按钮/左栏标签) 与 BeurocratsScript(职位栏).
// 这里把这套对象图搭出来, 动作与左栏状态都直接调原版, 不复制公式.
// ============================================================
using System.Collections.Generic;
using CML.Logic;
using UnityEngine;

namespace CML.Logic.Port;

public static class PoliticsHost
{
    public const int ButtonCount = 17;

    static Stub _managerStub;
    static Politic_Manager _manager;
    static readonly Stub[] Buttons = new Stub[ButtonCount];
    static readonly Politic_Script[] Cards = new Politic_Script[18];
    static BeurocratsScript _bear1;
    static BeurocratsScript _bear2;
    static bool _ready;

    public static void Ensure()
    {
        if (_ready) return;
        _ready = true;

        _managerStub = Stub.Take<Politic_Manager>("PoliticsManager", Lifecycle.Scene);
        _manager = _managerStub.Typed<Politic_Manager>();
        _manager.buttons_obj = new GameObject("PoliticsButtons");
        _manager.button_lead_obj = new GameObject("PoliticsLeaderButton");
        _manager.name_pol = new TextMesh();
        _manager.t_zagovor = new TextMesh();
        _manager.traits = new[] { new TextMesh(), new TextMesh(), new TextMesh() };
        // 原版 Politic_Manager.Awake 的装配: 姓名表与特质表从游戏状态/序列化拷进 manager
        _manager.first_names = (string[])GameHost.State.names1.Clone();
        _manager.second_names = (string[])GameHost.State.names2.Clone();
        _manager.traits_en = PoliticTexts.Traits;
        _manager.stateDolzh = new Sprite[4];
        for (var i = 0; i < 4; i++) _manager.stateDolzh[i] = new Sprite { name = "dolzh_" + i };
        _manager.data = new Politic_Show_Data[0];

        for (var i = 0; i < Cards.Length; i++)
        {
            var stub = Stub.Take<Politic_Script>("PoliticCard" + i, Lifecycle.None);
            stub.Also<SpriteRenderer>();
            Stub.Attach<OkoshkoScript>(stub.Go);
            var card = stub.Typed<Politic_Script>();
            card.this_number = (byte)i;
            card.manager = _manager;
            card.name = new TextMesh();
            card.T1 = new TextMesh();
            card.T2 = new TextMesh();
            card.T3 = new TextMesh();
            card.dolzh = new SpriteRenderer();
            card.face_obj = new[] { new GameObject("Face0_" + i), new GameObject("Face1_" + i) };
            card.face = new[] { MakeFace("FaceR0_" + i), MakeFace("FaceR1_" + i) };
            Cards[i] = card;
        }
        _manager.first = Slice(0, 3);
        _manager.second = Slice(3, 4);
        _manager.third = Slice(7, 5);
        _manager.forth = Slice(12, 6);

        for (var i = 0; i < Buttons.Length; i++)
        {
            var stub = Stub.Take<Button_Pol_Script>("PoliticsAction" + i, Lifecycle.Lazy);
            stub.Also<SpriteRenderer>();
            Stub.Attach<OkoshkoScript>(stub.Go);
            var textGo = new GameObject("Text");
            textGo.AddComponent<TextMesh>();
            textGo.transform.SetParent(stub.Go.transform);
            stub.Set("num", (byte)i);
            stub.Set("manager", _manager);
            stub.Set("bear1", _bear1 = EnsureBear("Bearu(0)", true));
            stub.Set("bear2", _bear2 = EnsureBear("Bearu(1)", false));
            // 原版 Button_Pol_Script 政治动作里用 achieves.GetComponent<achievements>().Set(n)
            stub.Set("achieves", GameObject.Find("Ach(Clone)"));
            Buttons[i] = stub;
        }
        _manager.buttons = new Button_Pol_Script[14];
        for (var i = 0; i < 14; i++) _manager.buttons[i] = Buttons[i].Typed<Button_Pol_Script>();
        // 场景兄弟(Bearu/卡片/按钮)齐了再起原版 Awake: 它要从 GameObject.Find 拿两个职位栏并重绘
        _managerStub.Activate();
    }

    static Politic_Script[] Slice(int start, int count)
    {
        var array = new Politic_Script[count];
        for (var i = 0; i < count; i++) array[i] = Cards[start + i];
        return array;
    }

    static Politic_Face_Renderer MakeFace(string name)
    {
        var face = Stub.Take<Politic_Face_Renderer>(name, Lifecycle.None).Typed<Politic_Face_Renderer>();
        face.parts = new SpriteRenderer[9];
        for (var i = 0; i < 9; i++) face.parts[i] = new SpriteRenderer();
        face.s_0 = Sprites("s0_");
        face.s_1 = Sprites("s1_");
        face.s_2 = Sprites("s2_");
        face.s_3 = Sprites("s3_");
        face.s_4 = Sprites("s4_");
        face.s_5 = Sprites("s5_");
        face.s_6 = Sprites("s6_");
        face.s_7 = Sprites("s7_");
        face.jacket = Sprites("jacket_");
        return face;
    }

    static Sprite[] Sprites(string prefix)
    {
        var array = new Sprite[32];
        for (var i = 0; i < array.Length; i++) array[i] = new Sprite { name = prefix + i };
        return array;
    }

    static BeurocratsScript EnsureBear(string name, bool small)
    {
        var existing = GameObject.Find(name);
        if (existing != null) return existing.GetComponent<BeurocratsScript>();
        var stub = Stub.Take<BeurocratsScript>(name, Lifecycle.Scene);
        stub.Also<SpriteRenderer>();
        stub.Set("small", small);
        stub.Set("this_text", new TextMesh());
        stub.Set("manager", _manager);
        return stub.Activate().Typed<BeurocratsScript>();
    }

    // 原版 Politic_Manager.ResetPolitics: 把 GameState.p_first/p_second/p_third/p_forth
    // (BalancePolitic 按 politics[].power 降序写的排名) 抄到 18 张卡的 this_number 并整页重绘.
    // 政治界面卡片顺序 = 这个顺序; 每次快照都重算, 动作/事件改权力后立即生效.
    public static int[] CardOrder()
    {
        Ensure();
        _managerStub.Invoke("ResetPolitics");
        var order = new int[Cards.Length];
        for (var i = 0; i < Cards.Length; i++) order[i] = Cards[i].this_number;
        return order;
    }

    public static int Selected
    {
        set => _manager.selected_politic = (byte)value;
    }

    // 选一个人: 让原版 Politic_Selected 生成左栏姓名/特质/状态文本, 读回状态栏
    public static string Select(int index, out string nameLine, out string[] traits)
    {
        Ensure();
        _manager.selected_politic = (byte)index;
        foreach (var button in _manager.buttons) button.Repaint();
        _manager.Politic_Selected((byte)index);
        nameLine = _manager.name_pol.text;
        traits = new[]
        {
            _manager.traits[0].text,
            _manager.traits[1].text,
            _manager.traits[2].text,
        };
        return _manager.t_zagovor.text;
    }

    public static List<object> EnabledActions(int index)
    {
        Ensure();
        _manager.selected_politic = (byte)index;
        var enabled = new List<object>(ButtonCount);
        for (var i = 0; i < ButtonCount; i++)
        {
            Buttons[i].Invoke("Repaint");
            enabled.Add((bool)Buttons[i].Get("enbaled"));
        }
        return enabled;
    }

    // 原版 Button_Pol_Script.OnMouseDown: 先按当前 enbaled 门控, 再执行
    public static bool DoAction(int index, int num)
    {
        Ensure();
        _manager.selected_politic = (byte)index;
        Buttons[num].Invoke("Repaint");
        if (!(bool)Buttons[num].Get("enbaled")) return false;
        Buttons[num].Invoke("OnMouseDown");
        return true;
    }
}
