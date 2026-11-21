using EventsForDLC;
using UnityEngine;

public class Event400 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1133];
		text = string.Format(GlobalScript.inst.new_events_text[1134], "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = string.Format(GlobalScript.inst.new_events_text[1135], "\n", a.names1[a.politics[a.politics_dolshnost[2]].name_1], a.names2[a.politics[a.politics_dolshnost[2]].name_2]);
		button_text[1] = GlobalScript.inst.new_events_text[1136];
		button_text[2] = GlobalScript.inst.new_events_text[1137];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1133];
		switch (result_num)
		{
		case 0:
		{
			if ((a.event_done[425] && a.resultOfEvents[425] != 0) || !a.event_done[425])
			{
				text = string.Format(GlobalScript.inst.new_events_text[1138], "\n", a.names1[a.politics[a.politics_dolshnost[2]].name_1], a.names2[a.politics[a.politics_dolshnost[2]].name_2]);
			}
			else
			{
				text = " <color=#8B0000>恩 里 科 · 贝 林 格</color> 的 葬 礼 于 6 月 1 3 日 在 罗 马 举 行 ， 期 间 超 过 百 万 人 参 与 — — 这 在 意 大 利 共 和 国 的 历 史 上 前 所 未 闻 。 来 自 世 界 各 地 的 多 位 国 家 领 导 人 与 政 治 家 出 席 仪 式 ， 如 米 哈 伊 尔 · 戈 尔 巴 乔 夫 、 亚 西 尔 · 阿 拉 法 特 、 乔 治 · 马 歇 。 同 时 出 席 仪 式 的 还 有 由 中 国 外 交 部 长" + a.names1[a.politics[a.politics_dolshnost[2]].name_1] + a.names2[a.politics[a.politics_dolshnost[2]].name_2] + " 领 导 的 代 表 团 。||同 时 出 席 葬 礼 的 有 意 大 利 总 统 <color=#006400>山 德 罗 · 佩 尔 蒂 尼</color> ， 人 们 记 住 了 有 关 他 的 感 人 时 刻 — — 总 统 俯 下 额 头 ， 在 棺 材 前 亲 吻 了 一 下 逝 者 。 <color=#006400>意 大 利 社 会 党</color> 领 导 人 <color=#006400>贝 蒂 诺 · 克 拉 克 西</color> 也 出 席 了 仪 式 。 其 中 ， 最 出 乎 意 料 的 来 宾 则 是 来 自 <color=#8B4513>意 大 利 社 会 运 动</color> 的 领 导 人 <color=#8B4513>乔 治 · 阿 尔 米 兰 特</color> 。||<color=#8B0000>阿 雷 桑 德 罗 · 纳 塔</color> 则 从 <color=#8B0000>贝 林 格</color> 手 中 接 过 了 意 大 利 党 与 国 家 的 舵 手 之 位 。";
			}
			a.data[6] -= 10;
			a.empires[0].relations -= 150;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.power -= 200;
				}
				else if (politic2.traits[0] > 1)
				{
					politic2.loyality += 200;
				}
			}
			if (a.IsFactionLeadeng(0))
			{
				a.data[1] -= 300;
			}
			else
			{
				a.data[1] += 200;
			}
			break;
		}
		default:
			if ((a.event_done[425] && a.resultOfEvents[425] != 0) || !a.event_done[425])
			{
				text = string.Format(GlobalScript.inst.new_events_text[1140], "\n");
			}
			else
			{
				text = " <color=#8B0000>恩 里 科 · 贝 林 格</color> 的 葬 礼 于 6 月 1 3 日 在 罗 马 举 行 ， 期 间 超 过 百 万 人 参 与 — — 这 在 意 大 利 共 和 国 的 历 史 上 前 所 未 闻 。 来 自 世 界 各 地 的 多 位 国 家 领 导 人 与 政 治 家 出 席 仪 式 ， 如 米 哈 伊 尔 · 戈 尔 巴 乔 夫 、 亚 西 尔 · 阿 拉 法 特 、 乔 治 · 马 歇 。||同 时 出 席 葬 礼 的 有 意 大 利 总 统 <color=#006400>山 德 罗 · 佩 尔 蒂 尼</color> ， 人 们 记 住 了 有 关 他 的 感 人 时 刻 — — 总 统 俯 下 额 头 ， 在 棺 材 前 亲 吻 了 一 下 逝 者 。 <color=#006400>意 大 利 社 会 党</color> 领 导 人 <color=#006400>贝 蒂 诺 · 克 拉 克 西</color> 也 出 席 了 仪 式 。 其 中 ， 最 出 乎 意 料 的 来 宾 则 是 来 自 <color=#8B4513>意 大 利 社 会 运 动</color> 的 领 导 人 <color=#8B4513>乔 治 · 阿 尔 米 兰 特</color> 。||<color=#8B0000>阿 雷 桑 德 罗 · 纳 塔</color> 则 从 <color=#8B0000>贝 林 格</color> 手 中 接 过 了 意 大 利 党 与 国 家 的 舵 手 之 位 。";
			}
			break;
		case 1:
		{
			if ((a.event_done[425] && a.resultOfEvents[425] != 0) || !a.event_done[425])
			{
				text = string.Format(GlobalScript.inst.new_events_text[1139], "\n");
			}
			else
			{
				text = " <color=#8B0000>恩 里 科 · 贝 林 格</color> 的 葬 礼 于 6 月 1 3 日 在 罗 马 举 行 ， 期 间 超 过 百 万 人 参 与 — — 这 在 意 大 利 共 和 国 的 历 史 上 前 所 未 闻 。 来 自 世 界 各 地 的 多 位 国 家 领 导 人 与 政 治 家 出 席 仪 式 ， 如 米 哈 伊 尔 · 戈 尔 巴 乔 夫 、 亚 西 尔 · 阿 拉 法 特 、 乔 治 · 马 歇 。 中 国 外 交 部 对 此 表 示 了 慰 问 。||同 时 出 席 葬 礼 的 有 意 大 利 总 统 <color=#006400>山 德 罗 · 佩 尔 蒂 尼</color> ， 人 们 记 住 了 有 关 他 的 感 人 时 刻 — — 总 统 俯 下 额 头 ， 在 棺 材 前 亲 吻 了 一 下 逝 者 。 <color=#006400>意 大 利 社 会 党</color> 领 导 人 <color=#006400>贝 蒂 诺 · 克 拉 克 西</color> 也 出 席 了 仪 式 。 其 中 ， 最 出 乎 意 料 的 来 宾 则 是 来 自 <color=#8B4513>意 大 利 社 会 运 动</color> 的 领 导 人 <color=#8B4513>乔 治 · 阿 尔 米 兰 特</color> 。||<color=#8B0000>阿 雷 桑 德 罗 · 纳 塔</color> 则 从 <color=#8B0000>贝 林 格</color> 手 中 接 过 了 意 大 利 党 与 国 家 的 舵 手 之 位 。";
			}
			a.empires[0].relations -= 50;
			a.data[6] -= 5;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power -= 100;
				}
				else if (politic.traits[0] > 1)
				{
					politic.loyality += 100;
				}
			}
			if (a.IsFactionLeadeng(0))
			{
				a.data[1] -= 200;
			}
			else
			{
				a.data[1] += 100;
			}
			break;
		}
		}
	}
}
