// ============================================================
// 逻辑层 — NewGameSetup: 新局装配(原版 Unity 预设的"全新 GameState")
//
// 原版每次新游戏都是反序列化出的全新 GameState; 移植版复用同一实例,
// 而 GameStartScript.OnMouseDown 对 politics[].loyality 用 += 且不清零,
// 直接重开会让忠诚/权力/阴谋状态跨局叠加。
// 这里只把"每局必须重新开始"的政客/领袖/派系状态恢复到构造默认值,
// 其余数组由原版 GameStartScript 自己重置。
// ============================================================
namespace CML.Logic.Port;

public static class NewGameSetup
{
    public static void Reset(GameState state)
    {
        for (var i = 0; i < state.politics.Length; i++) state.politics[i] = new Politic();
        state.leader = new Politic();
        state.faction_leader = new int[5];
        state.politics_dolshnost = new byte[8];
        state.is_elect = false;
        state.is_speech = false;
        state.is_konst_max = true;
        state.number_event = -1;
        // 焦点进度是 Empire 上的每局状态; 不重置会让新局接着上局的层, 上局宣过的
        // 焦点(含 Wars.O 战争)在新局里被再执行一次.
        for (var i = 0; i < state.empires.Length; i++)
        {
            state.empires[i].now_layer = 0;
            state.empires[i].now_focus = -1;
        }
    }

    // 开局数据口径: 原版 GameStartScript 把 data[105] 写成 2(无限制), 但开局实际
    // 人口政策应为二胎制(1)。这一条由项目所有者确认, 登记在 docs/重构契约.md §5.
    public static void ApplyOpeningData(GameState state) => state.data[105] = 1;
}
