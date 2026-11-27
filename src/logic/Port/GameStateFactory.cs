// 复刻原版 Unity 预设序列化的对象图(不是数值修正).
using System;
using System.Collections.Generic;
using System.Reflection;

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

	// 旧版本(Unity 版)存档里的数组比 1.132 口径短: 原版预设 allcountries 只有 99、
	// data 只有 150、parts 只有 6 槽. 读这种档再开新局时, 地图按 168 国取、
	// GameStartScript 按 Country_en 的 167 行写、外交按 200 槽摆, 全部立刻 IndexOutOfRange.
	// 这里按模板(填充后的新 GameState)的尺寸把每个数组与元素内部数组补齐,
	// 已有内容一律保留, 只往尾巴上补新槽.
	public static void EnsureCapacity(GameState state)
	{
		foreach (var field in 数组字段(typeof(GameState)))
		{
			// names1/names2 的槽数来自 polit_names1/2 文本行数(GameStartScript 载入时确定),
			// 没有固定口径, 模板里就是 null, 不参与补齐
			var 模板 = (Array)field.GetValue(模板实例);
			if (模板 == null) continue;
			var 当前 = (Array)field.GetValue(state);
			if (当前 == null)
			{
				field.SetValue(state, 按模板复制(模板));
				continue;
			}
			if (当前.Length < 模板.Length)
			{
				当前 = 扩容(当前, 模板);
				field.SetValue(state, 当前);
			}
			for (var i = 0; i < 当前.Length; i++)
			{
				var 模板元素 = i < 模板.Length ? 模板.GetValue(i) : null;
				补齐元素(当前, i, 模板元素);
			}
		}
		// leader 是单个对象而不是数组, 上面这圈覆盖不到(旧档缺这个字段时给个空的)
		state.leader ??= new Politic();
		补齐对象内部数组(state.leader, 模板实例.leader);
	}

	static readonly Dictionary<Type, FieldInfo[]> 字段缓存 = new();

	static FieldInfo[] 数组字段(Type type)
	{
		if (字段缓存.TryGetValue(type, out var cached)) return cached;
		var list = new List<FieldInfo>();
		for (var current = type; current != typeof(object); current = current.BaseType)
			foreach (var field in current.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
				if (field.FieldType.IsArray) list.Add(field);
		var result = list.ToArray();
		字段缓存[type] = result;
		return result;
	}

	static readonly GameState 模板实例 = 建模板();

	static GameState 建模板()
	{
		var state = new GameState();
		Fill(state);
		return state;
	}

	static void 补齐元素(Array 数组, int i, object 模板元素)
	{
		var 元素 = 数组.GetValue(i);
		if (元素 == null)
		{
			数组.SetValue(新元素(模板元素), i);
			return;
		}
		if (模板元素 != null) 补齐对象内部数组(元素, 模板元素);
	}

	static void 补齐对象内部数组(object 目标, object 模板元素)
	{
		foreach (var field in 数组字段(模板元素.GetType()))
		{
			var 模板 = (Array)field.GetValue(模板元素);
			if (模板 == null) continue;
			var 当前 = (Array)field.GetValue(目标);
			if (当前 == null)
			{
				field.SetValue(目标, 按模板复制(模板));
				continue;
			}
			if (当前.Length < 模板.Length) field.SetValue(目标, 扩容(当前, 模板));
		}
	}

	static Array 按模板复制(Array 模板)
	{
		var 结果 = Array.CreateInstance(模板.GetType().GetElementType()!, 模板.Length);
		for (var i = 0; i < 结果.Length; i++) 结果.SetValue(新元素(模板.GetValue(i)), i);
		return 结果;
	}

	static Array 扩容(Array 当前, Array 模板)
	{
		var 结果 = Array.CreateInstance(当前.GetType().GetElementType()!, 模板.Length);
		Array.Copy(当前, 结果, 当前.Length);
		for (var i = 当前.Length; i < 结果.Length; i++)
			结果.SetValue(新元素(i < 模板.Length ? 模板.GetValue(i) : null), i);
		return 结果;
	}

	// 引用类型按模板元素的类型新建(不能共享模板实例, 否则内部数组会被各槽互相改写)
	static object 新元素(object 模板元素)
	{
		if (模板元素 == null) return null;
		var type = 模板元素.GetType();
		if (type.IsValueType || type == typeof(string)) return 模板元素;
		var 元素 = Activator.CreateInstance(type);
		补齐对象内部数组(元素, 模板元素);
		return 元素;
	}

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
