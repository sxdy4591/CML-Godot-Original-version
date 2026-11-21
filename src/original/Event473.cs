using EventsForDLC;
using UnityEngine;

public class Event473 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 经 互 会 的 最 后 一 日";
		text = " 随 着 苏 联 内 部 危 机 的 进 一 步 加 剧 ， 戈 尔 巴 乔 夫 无 力 继 续 担 当 “ 社 会 主 义 大 家 庭 ” 的 家 长 这 一 任 务 。 在 宣 布 苏 联 军 队 撤 出 东 欧 国 家 之 后 ， 经 互 会 的 去 留 也 被 提 上 了 日 程 。 在 布 达 佩 斯 召 开 的 大 会 上 ， 苏 联 领 导 人 米 哈 伊 尔 · 戈 尔 巴 乔 夫 宣 布 了 惊 人 的 消 息 ： 经 互 会 将 解 散 ， 各 个 成 员 国 将 自 行 寻 找 处 理 未 来 。 也 许 我 们 可 以 趁 机 做 点 什 么 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 趁 机 招 揽 经 互 会 前 成 员 国";
		if (a.data[56] <= 0)
		{
			button_text[1] = " 这 就 是 和 修 正 主 义 者 沆 瀣 一 气 的 下 场 ！";
		}
		else if (a.data[56] == 1 || a.data[56] == 2)
		{
			button_text[1] = " 我 们 只 能 惊 恐 的 看 着 老 朋 友 的 离 去";
		}
		else if (a.data[56] == 3)
		{
			button_text[1] = " 或 许 他 们 也 和 我 们 一 样 改 革 的 话 就 好 了";
		}
		else if (a.data[56] >= 4)
		{
			button_text[1] = " 这 就 是 “ 共 惨 主 义 ” 的 下 场 ！";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 经 互 会 的 最 后 一 日";
		a.empires[1].leaders[6].support--;
		switch (result_num)
		{
		case 0:
		{
			text = " 在 我 们 的 提 议 下 ， 剩 下 的 经 济 互 助 委 员 会 成 员 国 学 习 了 罗 马 尼 亚 ， 波 兰 和 匈 牙 利 的 经 验 ， 公 开 转 向 中 华 人 民 共 和 国 的 怀 抱 。 中 华 人 民 共 和 国 的 实 力 将 允 许 我 们 接 手 戈 尔 巴 乔 夫 无 法 掌 握 的 力 量 。 我 们 将 提 供 足 够 的 资 金 ，";
			if (a.data[56] <= 2)
			{
				text += " 为 他 们 的 经 济 去 改 革 计 划 作 准 备 。";
			}
			else if (a.data[56] > 2)
			{
				text += " 为 他 们 的 经 济 改 革 计 划 作 准 备 。";
			}
			for (int k = 0; k < a.allcountries.Length; k++)
			{
				if (a.allcountries[k].isSEV)
				{
					a.allcountries[k].isSEV = false;
					a.allcountries[k].prosov = false;
					if (k != 7 && k != 138)
					{
						a.allcountries[k].econ = true;
						a.allcountries[k].proprc = true;
					}
				}
			}
			for (int l = 0; l < a.allcountries.Length; l++)
			{
				if (a.allcountries[l].prosov && l != 7)
				{
					a.allcountries[l].prosov = false;
				}
			}
			if (a.empires[1].power > 0)
			{
				a.empires[1].power = 0;
			}
			a.empires[1].power -= 500;
			a.influencePRC += 300;
			break;
		}
		case 1:
		{
			text = " 很 快 ， 东 欧 国 家 的 经 济 或 多 或 少 陷 入 了 衰 退 ， 尤 其 是 那 些 高 度 依 赖 苏 联 援 助 的 国 家 。 我 们 和 苏 联 的 贸 易 或 多 或 少 受 到 了 些 冲 击 。 但 这 也 是 他 们 自 找 的 路 。";
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].isSEV)
				{
					a.allcountries[i].isSEV = false;
				}
			}
			for (int j = 0; j < a.allcountries.Length; j++)
			{
				if (a.allcountries[j].prosov)
				{
					a.allcountries[j].prosov = false;
				}
			}
			if (a.empires[1].power > 0)
			{
				a.empires[1].power = 0;
			}
			a.empires[1].power -= 500;
			break;
		}
		}
	}
}
