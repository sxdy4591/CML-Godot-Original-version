using EventsForDLC;
using UnityEngine;

public class Event307 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[77];
		if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			text = string.Format(GlobalScript.inst.new_events_text[78]);
		}
		else if (GlobalScript.inst.gameState.modifies[3].active)
		{
			text = " 文 革 前 十 年 的 后 期 ， 由 于 保 守 势 力 的 反 扑 ， 许 多 造 反 派 红 卫 兵 被 送 进 了 监 狱 。 但 在 文 革 局 势 逐 渐 稳 定 下 来 之 后 ， 一 些 党 员 提 出 要 为 之 前 蒙 冤 入 狱 的 造 反 派 平 反 ， 这 些 造 反 派 中 也 不 乏 有 用 的 专 家 ， 人 民 对 造 反 派 的 看 法 也 早 有 改 观 ， 释 放 他 们 会 让 我 们 更 受 支 持 。 但 是 ， 我 们 是 应 该 不 带 有 色 眼 镜 把 他 们 当 作 正 常 人 去 对 待 并 给 他 们 分 配 工 作 ， 还 是 仅 仅 做 个 “ 人 道 ” 的 样 子 但 在 暗 中 仍 然 排 挤 他 们 ？ 这 决 定 了 我 们 是 把 文 化 大 革 命 当 作 一 场 真 正 的 人 民 运 动 还 是 被 粉 饰 成 “ 人 民 运 动 ” 的 清 洗 活 动。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = GlobalScript.inst.new_events_text[79];
		button_text[1] = GlobalScript.inst.new_events_text[80];
		if (GlobalScript.inst.gameState.modifies[3].active)
		{
			button_text[2] = GlobalScript.inst.new_events_text[81];
		}
		else if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			Object.Destroy(button[2]);
			button_text[2] = "";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[77];
		switch (result_num)
		{
		case 0:
			text = GlobalScript.inst.new_events_text[82];
			GlobalScript.inst.gameState.data[1] += 15;
			break;
		case 1:
			text = GlobalScript.inst.new_events_text[83];
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[1] -= 15;
			GlobalScript.inst.gameState.data[4] += 50;
			break;
		case 2:
		{
			text = GlobalScript.inst.new_events_text[84];
			GlobalScript.inst.gameState.party_number[0] += 300;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[6] += 100;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] > 0 && politic.traits[0] != 20)
				{
					politic.loyality -= 500;
					politic.power -= 500;
				}
				if (politic.traits[0] == 20)
				{
					politic.loyality -= 100;
				}
			}
			GlobalScript.inst.gameState.modifies[32].active = true;
			break;
		}
		}
	}
}
