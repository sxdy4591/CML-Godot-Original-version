using EventsForDLC;
using UnityEngine;

public class Event326 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[233];
		text = "毛 主 席 逝 世 了 ， 因 此 ， 我 们 的 国 家 需 要 选 定 一 条 通 往 未 来 的 道 路 。 显 然 ， 这 应 当 反 映 在 宪 法 中 。 来 自 多 个 党 派 不 同 代 表 的 数 百 份 提 案 已 经 送 达 ， 但 若 是 从 总 体 上 来 看 ， ";
		if (GlobalScript.inst.gameState.modifies[3].active)
		{
			text += "我 们 有 四 个 选 择 ， 分 别 来 自 极 左 派 、 保 守 派 和 温 和 派 、 改 革 派 和 其 他 温 和 派 以 及 自 由 派 。 当 然 ， 通 过 任 何 版 本 的 宪 法 都 会 让 提 出 宪 法 草 案 的 派 别 一 时 风 头 无 二 。 极 左 派 想 要 开 始 继 续 毛 和 文 化 大 革 命 的 事 业 ， 提 出 了 一 系 列 在 其 他 人 眼 里 相 当 “ 疯 狂 ” 的 提 案 。 保 守 派 主 张 维 持 现 行 制 度 ， 但 要 进 行 渐 进 的 社 会 主 义 改 革 。 改 革 派 支 持 一 定 程 度 的 经 济 自 由 化 和 私 营 企 业 的 扩 张 。 至 于 自 由 派 ...... 自 不 必 说 ， 是 回 归 资 本 主 义 。 那 么 ， 中 国 将 往 何 处 去 ？";
		}
		else
		{
			text += "我 们 有 三 个 选 择 ， 分 别 来 自 保 守 派 与 温 和 派 、 改 革 派 与 其 他 温 和 派 以 及 自 由 派 。 当 然 ， 通 过 任 何 版 本 的 宪 法 都 会 让 提 出 宪 法 草 案 的 派 别 一 时 风 头 无 二 。 保 守 派 主 张 维 持 现 行 制 度 ， 但 要 进 行 渐 进 的 社 会 主 义 改 革 。 改 革 派 支 持 一 定 程 度 的 经 济 自 由 化 和 私 营 企 业 的 扩 张 。 至 于 自 由 派 ...... 自 不 必 说 ， 是 回 归 资 本 主 义 。 那 么 ， 中 国 将 往 何 处 去 ？";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active)
		{
			button_text[0] = GlobalScript.inst.new_events_text[235];
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_texts[191]);
		}
		if (GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2)
		{
			button_text[1] = GlobalScript.inst.new_events_text[236];
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_texts[192]);
		}
		if (GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3)
		{
			button_text[2] = GlobalScript.inst.new_events_text[237];
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = string.Format(GlobalScript.inst.new_texts[193]);
		}
		if (GlobalScript.inst.gameState.data[56] == 4)
		{
			button_text[3] = GlobalScript.inst.new_events_text[238];
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_texts[194]);
		}
		button_text[4] = GlobalScript.inst.new_events_text[239];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[233];
		switch (result_num)
		{
		case 0:
		{
			text = GlobalScript.inst.new_events_text[240];
			GlobalScript.inst.gameState.party_number[0] += 50;
			GlobalScript.inst.gameState.data[6] += 50;
			GlobalScript.inst.gameState.influencePRC++;
			GlobalScript.inst.gameState.modifies[28].active = true;
			if (GlobalScript.inst.gameState.event_done[326] && GlobalScript.inst.gameState.resultOfEvents[326] == 0 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[50] <= 25 && GlobalScript.inst.gameState.data[15] == 6 && GlobalScript.inst.gameState.data[16] <= 11)
			{
				GlobalScript.inst.old_modify_texts[28] = "无 产 阶 级 宪 法";
				GlobalScript.inst.old_modify_desc[28] = " 极 左 派+3 ， 极 左 派 力 量+3 ， 党 内 支 持 度-0.5 ， 人 民 支 持 度+1.5 ， 思 想 自 由 化-1.5 ， 腐 败-0.2 ， 预 算+0.3 ， 特 工 网 络+0.3";
			}
			else
			{
				GlobalScript.inst.old_modify_texts[28] = "75 宪 法";
				GlobalScript.inst.old_modify_desc[28] = " 极 左 派 、 保 守 派+1 ， 极 左 派 、 保 守 派 力 量+1 ， 党 内 支 持 度-0.2 ， 人 民 支 持 度+0.2 ， 思 想 自 由 化-0.2 ， 腐 败-0.2 ， 特 工 网 络+0.2";
			}
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality = 1000;
					politic.power += 500;
				}
				if (politic.traits[0] == 20)
				{
					politic.power -= 200;
				}
				if (politic.traits[0] == 1)
				{
					politic.loyality = 300;
					politic.power -= 300;
				}
				if (politic.traits[0] == 2)
				{
					politic.loyality = 0;
					politic.power -= 400;
				}
				if (politic.traits[0] == 3)
				{
					politic.loyality = 0;
					politic.power -= 500;
				}
			}
			if (GlobalScript.inst.gameState.data[17] < 18)
			{
				GlobalScript.inst.gameState.data[17]++;
			}
			GlobalScript.inst.gameState.data[15] = 6;
			if (GlobalScript.inst.gameState.data[16] > 11)
			{
				GlobalScript.inst.gameState.data[16] = 11;
			}
			if (GlobalScript.inst.gameState.data[50] > 25)
			{
				GlobalScript.inst.gameState.data[50] = 24;
			}
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[4] -= 100;
			GlobalScript.inst.gameState.data[26] -= 5;
			GlobalScript.inst.gameState.data[8] += 2;
			GlobalScript.inst.gameState.data[9] += 2;
			break;
		}
		case 1:
			text = GlobalScript.inst.new_events_text[241];
			GlobalScript.inst.gameState.party_number[1] += 50;
			GlobalScript.inst.gameState.party_number[2] += 50;
			GlobalScript.inst.gameState.data[3] += 25;
			GlobalScript.inst.gameState.data[4] += 15;
			GlobalScript.inst.gameState.data[17] += ((GlobalScript.inst.gameState.data[17] <= 18) ? 1 : (-1));
			GlobalScript.inst.gameState.modifies[28].active = false;
			GlobalScript.inst.gameState.data[15] -= ((GlobalScript.inst.gameState.data[15] > 7) ? (-1) : 0);
			GlobalScript.inst.gameState.modifies[29].active = true;
			if (GlobalScript.inst.gameState.data[15] > 7)
			{
				GlobalScript.inst.gameState.data[15] = 7;
			}
			break;
		case 2:
			text = GlobalScript.inst.new_events_text[242];
			GlobalScript.inst.gameState.party_number[2] += 50;
			GlobalScript.inst.gameState.party_number[3] += 50;
			GlobalScript.inst.gameState.data[4] += 15;
			GlobalScript.inst.gameState.data[17] += ((GlobalScript.inst.gameState.data[17] < 18) ? 1 : 0);
			GlobalScript.inst.gameState.data[16] += ((GlobalScript.inst.gameState.data[16] < 15) ? 1 : 0);
			GlobalScript.inst.gameState.data[6] -= 100;
			GlobalScript.inst.gameState.modifies[28].active = false;
			GlobalScript.inst.gameState.modifies[30].active = true;
			GlobalScript.inst.gameState.data[89] = 2;
			if (GlobalScript.inst.gameState.data[16] == 11)
			{
				GlobalScript.inst.gameState.data[16] = 12;
			}
			else if (GlobalScript.inst.gameState.data[16] < 13)
			{
				GlobalScript.inst.gameState.data[16] = 13;
			}
			break;
		case 3:
			text = GlobalScript.inst.new_events_text[243];
			GlobalScript.inst.gameState.party_number[4] += 50;
			GlobalScript.inst.gameState.data[16] += ((GlobalScript.inst.gameState.data[16] < 15) ? 1 : 0);
			GlobalScript.inst.gameState.data[15] += ((GlobalScript.inst.gameState.data[15] < 8) ? 1 : 0);
			GlobalScript.inst.gameState.data[6] -= 250;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.modifies[28].active = false;
			GlobalScript.inst.gameState.modifies[31].active = true;
			GlobalScript.inst.gameState.data[89] = 2;
			if (GlobalScript.inst.gameState.data[16] < 14)
			{
				GlobalScript.inst.gameState.data[16] = 14;
			}
			if (GlobalScript.inst.gameState.data[17] < 17)
			{
				GlobalScript.inst.gameState.data[17] = 17;
			}
			break;
		case 4:
			text = GlobalScript.inst.new_events_text[244];
			GlobalScript.inst.gameState.data[1] += 50;
			break;
		}
	}
}
