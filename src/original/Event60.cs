using EventsForDLC;
using UnityEngine;

public class Event60 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 军 事 同 盟";
		text = " 在 愉 快 地 创 建 了 我 们 自 己 的 经 济 联 盟 后 ， 一 些 党 员 提 议 将 所 有 对 我 们 友 好 的 国 家 组 成 一 个 军 事 同 盟 以 巩 固 我 们 的 胜 利 果 实 ， 并 在 欧 洲 的 北 约 和 苏 联 的 华 约 的 军 事 基 地 的 包 围 中 占 据 一 席 之 地 。 但 追 求 实 用 主 义 的 党 员 建 议 搁 置 这 个 提 议 ， 称 我 们 考 虑 欠 妥 ， 这 激 进 的 行 为 会 导 致 新 的 一 轮 有 第 三 方 力 量 参 加 的 冷 战 。 但 是 ， 我 国 现 在 比 以 往 更 为 强 大 ， 额 外 的 盟 友 也 不 会 有 什 么 影 响 ， 对 吗 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.data[22] >= 300 && GlobalScript.inst.gameState.data[9] >= 100 && !GlobalScript.inst.gameState.allcountries[1].isOVD)
		{
			button_text[0] = " 建 立 军 事 联 盟 （ 需 要5 百 万 元 预 算 ，30 军 事 实 力 ，10 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 还 没 有 准 备 好 （ 需 要5 百 万 元 预 算 ，30 军 事 实 力 ，10 特 工 网 络 ）";
		}
		button_text[1] = " 什 么 都 不 做";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 军 事 同 盟";
		switch (result_num)
		{
		case 0:
		{
			text = " 今 天 在 上 海 ， 签 署 了 一 项 关 于 建 立 集 体 安 全 联 盟 （CRA ） 的 协 议 ， 这 是 一 个 军 事 政 治 组 织 ， 将 中 国 所 有 的 盟 国 在 一 个 军 事 集 团 的 旗 帜 下 团 结 起 来 。 集 体 安 全 联 盟 的 目 的 是 建 立 一 个 共 同 反 对 其 他 军 事 联 盟 （ 华 约 和 北 约 ） 的 互 助 防 御 体 系 。 新 成 立 的 组 织 的 成 员 为 中 华 人 民 共 和 国 ";
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 200;
			GlobalScript.inst.gameState.empires[1].relations -= 200;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[22] -= 300;
			GlobalScript.inst.gameState.allcountries[15].cw = false;
			GlobalScript.inst.gameState.allcountries[1].okb = true;
			GlobalScript.inst.gameState.modifies[59].active = true;
			for (int i = 7; i < 53; i++)
			{
				if (GlobalScript.inst.gameState.allcountries[i].proprc && GlobalScript.inst.gameState.allcountries[i].econ && i != 52 && i != 45 && i != 35 && i != 40 && i != 30 && i != 14 && i != 13 && i != 36 && i != 54 && i != 55 && i != 18 && i != 21 && !GlobalScript.inst.gameState.allcountries[i].Vyshi && !GlobalScript.inst.gameState.allcountries[i].prosov)
				{
					if (GlobalScript.inst.gameState.allcountries[i].soc_stab <= 0)
					{
						GlobalScript.inst.gameState.allcountries[i].soc_stab = 1000;
					}
					text = text + ", " + GlobalScript.inst.gameState.allcountries[i].name;
					GlobalScript.inst.gameState.allcountries[i].okb = true;
					if (GlobalScript.inst.gameState.allcountries[i].isSEV)
					{
						GlobalScript.inst.gameState.allcountries[i].isSEV = false;
						GlobalScript.inst.gameState.allcountries[i].econ = true;
					}
				}
			}
			text += " 。 苏 联 和 美 国 对 中 国 影 响 力 的 扩 大 做 出 了 负 面 反 应 ， 称 这 一 新 的 联 盟 “ 是 缓 和 国 际 紧 张 局 势 的 障 碍 ” 和 “ 和 平 共 处 的 毁 灭 者 ” 。 反 过 来 ， 党 和 人 民 对 中 华 人 民 共 和 国 声 望 的 提 高 充 满 了 热 情 和 钦 佩 。 似 乎 国 际 舞 台 上 出 现 了 第 三 支 力 量 ， 希 望 一 切 向 好 。";
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality += 100;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality += 100;
				}
				else if (politic.traits[0] == 2)
				{
					politic.loyality += 100;
				}
				else if (politic.traits[0] == 3)
				{
					politic.loyality += 100;
				}
			}
			if (!GlobalScript.inst.gameState.modifies[59].active)
			{
				break;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (!GlobalScript.inst.gameState.allcountries[1].okb)
			{
				break;
			}
			for (int k = 0; k < GlobalScript.inst.gameState.allcountries.Length; k++)
			{
				if (GlobalScript.inst.gameState.allcountries[k].okb)
				{
					num++;
					if (((k > 53 && k < 69) || (k > 105 && k < 109) || (k > 111 && k < 134) || k == 41 || k == 42 || k == 52 || k == 99 || k == 100) && k != 55 && k != 54 && k != 128 && GlobalScript.inst.gameState.allcountries[k].proprc && (GlobalScript.inst.gameState.allcountries[k].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[k].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						num3++;
					}
				}
				if (GlobalScript.inst.gameState.allcountries[k].oar)
				{
					num2++;
				}
			}
			GlobalScript.inst.old_modify_desc[59] = string.Format("{0}{1}{2}", new object[3]
			{
				GlobalScript.inst.gameState.allcountries[1].okb ? (" 集 体 安 全 联 盟 ：|军 事 力 量+" + num * 3 / 10 + "." + Mathf.Abs(num * 3 % 10) + " ；特 工 网 络+" + num * 2 / 10 + "." + Mathf.Abs(num * 2 % 10) + " ；干 涉 点 数+" + num / 10 + "." + Mathf.Abs(num % 10)) : null,
				(GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0) ? (" |非 洲 联 盟 : |军 事 力 量 +" + num3 * 3 / 10 + "." + Mathf.Abs(num3 * 3 % 10) + " ；特 工 网 络+" + num3 * 2 / 10 + "." + Mathf.Abs(num3 * 2 % 10) + " ；干 涉 点 数+" + num3 / 10 + "." + Mathf.Abs(num3 % 10)) : null,
				(!GlobalScript.inst.gameState.allcountries[30].oar) ? null : ((GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1) ? (" |阿 拉 伯 革 命 同 盟 :| 军 事 力 量 +" + num2 * 3 / 10 + "." + Mathf.Abs(num2 * 3 % 10) + " ；特 工 网 络+" + num2 * 2 / 10 + "." + Mathf.Abs(num2 * 2 % 10) + " ；干 涉 点 数+" + num2 / 10 + "." + Mathf.Abs(num2 % 10)) : (" |阿 拉 伯 联 合 共 和 国 :| 军 事 力 量 +" + num2 * 3 / 10 + "." + Mathf.Abs(num2 * 3 % 10) + " ；特 工 网 络+" + num2 * 2 / 10 + "." + Mathf.Abs(num2 * 2 % 10) + " ；干 涉 点 数+" + num2 / 10 + "." + Mathf.Abs(num2 % 10)))
			});
			break;
		}
		case 1:
			text = " 中 国 继 续 脱 离 军 事 同 盟 。 地 球 上 的 和 平 — — 和 平 高 于 一 切 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
