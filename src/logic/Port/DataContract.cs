// 启动契约: data/*.txt 与 src/original 的 1.132 口径必须对得上.
// 混版本(例如把 1.2.0 的 polit_names 塞进 1.132 的 Politics_inf)会让下标整体错位,
// 表现成"陈云→陶云"这种没有堆栈的错误, 所以在开局时就显式失败.
using System;

namespace CML.Logic.Port;

public static class DataContract
{
    public static void Verify(GameState state)
    {
        if (state.politics.Length != GameStateFactory.PoliticSlots)
            throw new InvalidOperationException(
                $"politics 有 {state.politics.Length} 槽, 1.132 口径是 {GameStateFactory.PoliticSlots} 位");

        foreach (var politic in state.politics)
        {
            CheckName(state, politic.name_1, politic.name_2);
            CheckTrait(politic.traits[0]);
            CheckTrait(politic.traits[1]);
            CheckTrait(politic.traits[2]);
        }
        CheckName(state, state.leader.name_1, state.leader.name_2);
    }

    static void CheckName(GameState state, int first, int second)
    {
        if (first >= state.names1.Length)
            throw new InvalidOperationException(
                $"polit_names1_en 只有 {state.names1.Length} 项, 政客用了下标 {first}(data 与 original 不是同一版本)");
        if (second >= state.names2.Length)
            throw new InvalidOperationException(
                $"polit_names2_en 只有 {state.names2.Length} 项, 政客用了下标 {second}(data 与 original 不是同一版本)");
    }

    static void CheckTrait(byte trait)
    {
        if (trait >= PoliticTexts.Traits.Length)
            throw new InvalidOperationException(
                $"特质值 {trait} 超出 traits_en 长度 {PoliticTexts.Traits.Length}(Politic_Manager 序列化口径)");
    }
}
