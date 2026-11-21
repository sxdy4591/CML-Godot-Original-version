using EventsForDLC;
using UnityEngine;

public class Event308 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[85];
		if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			text = string.Format(GlobalScript.inst.new_events_text[86]);
		}
		else if (GlobalScript.inst.gameState.modifies[3].active)
		{
			text = " 文 革 的 混 乱 时 期 ， 全 国 一 些 地 区 的 造 反 派 被 大 规 模 镇 压 ， 其 中 就 有 一 批 在 广 州 的 造 反 派 出 逃 到 了 港 澳 地 区 。 如 今 ， 他 们 在 香 港 成 立 了 犯 罪 集 团 ， 其 在 东 南 亚 和 北 美 国 家 的 影 响 力 也 愈 发 强 大 。 我 们 可 以 与 他 们 建 立 合 作 关 系 ， 以 更 好 地 影 响 外 国 政 策 。 当 然 ， 天 上 不 会 掉 馅 饼 ， 黑 手 党 也 会 想 干 涉 我 党 事 务 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = GlobalScript.inst.new_events_text[87];
		if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50 && GlobalScript.inst.gameState.data[56] <= 2)
		{
			button_text[1] = GlobalScript.inst.new_events_text[88];
		}
		else if (GlobalScript.inst.gameState.data[56] > 2)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[89]);
		}
		else if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] < 50)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[122]);
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[85];
		switch (result_num)
		{
		case 0:
			text = GlobalScript.inst.new_events_text[90];
			GlobalScript.inst.gameState.data[8] += 50;
			break;
		case 1:
			text = GlobalScript.inst.new_events_text[91];
			GlobalScript.inst.gameState.data[7] += 100;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.party_number[0] += 50;
			break;
		}
	}
}
