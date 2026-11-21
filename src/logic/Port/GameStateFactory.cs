// 复刻原版 Unity 预设序列化的对象图(不是数值修正).
namespace CML.Logic.Port;

public static class GameStateFactory
{
    public const int CountrySlots = 200;
    // 原版 GameState.politics / Politic.loyality_to_other 都是 18;
    // Politics_inf 只有 18 段, 卡片 3+4+5+6=18。多出来的槽会被原版
    // "for i < politics.Length" 循环当真人统计, 派系/政治全线错乱。
    public const int PoliticSlots = 18;
    public const int DataSlots = 200;
    public const int CountryPartSlots = 12;

    public static void Fill(GameState state)
    {
        state.modifies = FillAll(state.modifies, () => new Modifiers());
        state.empires = FillAll(state.empires ?? new Empire[2], () => new Empire());
        state.ingamewars = FillAll(state.ingamewars, () => new warinwars());
        state.allcountries = CreateCountries();
        state.politics = CreatePolitics();
        state.completedDecisions = new bool[40];
        state.data = Grow(state.data, DataSlots);
        state.data_old = Grow(state.data_old, DataSlots);
        state.leader.loyality_to_other = GrowTo(state.leader.loyality_to_other, PoliticSlots);
    }

    static Country[] CreateCountries()
    {
        var countries = new Country[CountrySlots];
        for (var i = 0; i < countries.Length; i++)
        {
            var country = new Country();
            var parts = new bool[CountryPartSlots];
            System.Array.Copy(country.parts, parts, System.Math.Min(country.parts.Length, parts.Length));
            country.parts = parts;
            countries[i] = country;
        }
        return countries;
    }

    static Politic[] CreatePolitics()
    {
        var politics = new Politic[PoliticSlots];
        for (var i = 0; i < politics.Length; i++)
        {
            var politic = new Politic();
            politic.loyality_to_other = GrowTo(politic.loyality_to_other, PoliticSlots);
            politics[i] = politic;
        }
        return politics;
    }

    static int[] GrowTo(int[] source, int length)
    {
        var result = new int[length];
        System.Array.Copy(source, result, System.Math.Min(source.Length, result.Length));
        return result;
    }

    static int[] Grow(int[] source, int length)
    {
        if (source.Length >= length) return source;
        var result = new int[length];
        System.Array.Copy(source, result, source.Length);
        return result;
    }

    // 原版这些类型的构造函数带默认参数, 没有真正的无参构造, 故用工厂委托填充.
    static T[] FillAll<T>(T[] array, System.Func<T> factory) where T : class
    {
        for (var i = 0; i < array.Length; i++) array[i] ??= factory();
        return array;
    }
}
