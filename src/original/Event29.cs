using EventsForDLC;
using UnityEngine;

public class Event29 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 中 国 帝 国 主 义";
		text = " 长 期 以 来 ， 朝 鲜 已 经 摆 脱 了 马 克 思 列 宁 主 义 ， 用 独 创 的 包 含 神 秘 主 义 、 传 统 主 义 和 对 金 日 成 个 人 崇 拜 元 素 的 主 体 思 想 取 而 代 之 。 所 有 这 些 都 伴 随 着 对 金 日 成 政 治 对 手 的 周 期 性 镇 压 。 朝 鲜 的 经 济 在 很 大 程 度 上 依 赖 于 与 中 国 的 接 触 和 我 们 的 帮 助 ， 因 此 我 们 最 近 的 制 裁 对 它 是 一 个 沉 重 的 打 击 。 因 此 ， 我 们 可 以 要 求 朝 鲜 政 府 做 出 某 些 让 步 。 但 别 忘 了 苏 联 也 向 朝 鲜 提 供 援 助 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 要 求 有 限 政 治 自 由 化";
		button_text[1] = " 要 求 高 度 的 政 治 经 济 改 革";
		if (GlobalScript.inst.gameState.data[16] >= 13)
		{
			button_text[2] = " 要 求 为 中 国 公 司 开 放 经 济 特 区";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 会 也 不 能 以 帝 国 主 义 的 方 式 行 事";
		}
		button_text[3] = " 要 求 最 大 规 模 的 民 主 化";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 中 国 帝 国 主 义";
		switch (result_num)
		{
		case 0:
		{
			text = " 不 想 面 对 严 重 的 经 济 问 题 ， 金 日 成 不 情 愿 地 同 意 了 我 们 的 要 求 ， 放 松 了 党 国 一 体 的 控 制 ， 对 为 部 分 过 去 遭 到 镇 压 的 人 平 反 ， 并 与 日 本 和 韩 国 进 行 了 小 规 模 接 触 。";
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[0].relations += 70;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] <= 1)
				{
					politic4.loyality -= 50;
				}
				else
				{
					politic4.loyality += 50;
				}
			}
			break;
		}
		case 1:
			if (GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[1].power)
			{
				text = " 金 日 成 不 愿 向 我 们 做 出 让 步 ， 起 初 他 想 完 全 倒 向 苏 联 一 边 ， 以 换 取 苏 联 的 帮 助 ， 但 我 们 的 影 响 力 要 大 得 多 ， 他 不 愿 与 我 们 对 抗 ， 最 终 同 意 了 我 们 的 要 求 。 朝 鲜 进 行 了 大 规 模 的 改 革 — — 放 松 了 党 和 国 家 在 媒 体 上 的 控 制 并 引 入 了 言 论 自 由 体 制 ， 在 引 入 成 本 核 算 和 公 司 自 治 的 基 础 上 开 始 了 经 济 改 革 。 对 此 ， 日 本 、 韩 国 和 美 国 都 给 予 了 我 们 积 极 的 评 价 。 美 国 总 统 指 出 ， 中 国 为 世 界 民 主 斗 争 作 出 了 突 出 贡 献 。";
				GlobalScript.inst.gameState.influencePRC += 10;
				GlobalScript.inst.gameState.empires[0].relations += 100;
				GlobalScript.inst.gameState.empires[1].relations -= 100;
				GlobalScript.inst.gameState.empires[0].power += 30;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic2 in politics)
				{
					if (politic2.traits[0] <= 1)
					{
						politic2.loyality -= 100;
					}
					else
					{
						politic2.loyality += 100;
					}
				}
				GlobalScript.inst.gameState.allcountries[10].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 8;
			}
			else
			{
				text = " 金 日 成 不 愿 向 我 们 做 出 让 步 ， 所 以 他 向 苏 联 求 助 。 苏 联 很 高 兴 地 增 加 了 对 朝 鲜 的 物 资 援 助 ， 并 向 朝 鲜 派 遣 了 一 支 小 分 队 以 建 立 军 事 基 地 。 朝 鲜 以 前 在 中 国 和 苏 联 间 保 持 中 立 ， 但 他 们 现 在 已 坚 定 地 进 入 苏 联 的 势 力 范 围 。";
				GlobalScript.inst.gameState.empires[1].power += 20;
				GlobalScript.inst.gameState.influencePRC -= 20;
				GlobalScript.inst.gameState.data[1] -= 100;
				GlobalScript.inst.gameState.allcountries[10].prosov = true;
				GlobalScript.inst.gameState.allcountries[10].proprc = false;
				GlobalScript.inst.gameState.allcountries[10].Torg = false;
			}
			break;
		case 2:
		{
			text = " 不 想 面 对 严 重 的 经 济 问 题 ， 金 日 成 不 情 愿 地 同 意 了 我 们 的 要 求 ， 同 意 开 放 外 资 企 业 可 以 经 营 的 经 济 特 区 ， 中 方 也 将 享 受 优 惠 条 件 。 我 们 的 企 业 家 非 常 满 意 ， 我 们 已 经 期 待 着 获 得 新 的 利 润 。";
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[8] += 40;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] >= 1)
				{
					politic3.loyality += 100;
				}
			}
			break;
		}
		case 3:
		{
			if (GlobalScript.inst.gameState.allcountries[7].isSEV)
			{
				text = " 金 日 成 不 愿 向 我 们 做 出 让 步 ， 所 以 他 向 苏 联 求 助 。 苏 联 很 高 兴 地 增 加 了 对 朝 鲜 的 物 资 援 助 ， 并 向 朝 鲜 派 遣 了 一 支 小 分 队 以 建 立 军 事 基 地 。 朝 鲜 以 前 在 中 国 和 苏 联 间 保 持 中 立 ， 但 他 们 现 在 已 坚 定 地 进 入 苏 联 的 势 力 范 围 。";
				GlobalScript.inst.gameState.empires[1].power += 20;
				GlobalScript.inst.gameState.influencePRC -= 20;
				GlobalScript.inst.gameState.data[1] -= 100;
				GlobalScript.inst.gameState.allcountries[10].prosov = true;
				GlobalScript.inst.gameState.allcountries[10].proprc = false;
				GlobalScript.inst.gameState.allcountries[10].Torg = false;
				break;
			}
			text = " 金 日 成 十 分 不 情 愿 ， 但 是 苦 于 苏 联 此 时 忙 于 改 革 ， 无 暇 东 顾 ， 只 能 被 迫 接 受 我 国 意 见 ， 但 是 仍 然 以 保 障 退 休 为 条 件 来 换 取 下 台 让 金 永 春 接 班 。 金 永 春 上 台 之 后 进 行 了 温 和 的 去 金 化 改 革 ， 包 括 调 整 经 济 制 度 为 国 家 管 控 资 本 主 义 ， 释 放 劳 改 营 里 的 政 治 犯 ， 逐 步 平 反 南 方 派 和 延 安 派 ， 与 西 方 国 家 缓 和 关 系 ， 甚 至 对 南 边 的 宣 传 火 药 味 也 淡 了 下 来 。";
			GlobalScript.inst.gameState.influencePRC += 30;
			GlobalScript.inst.gameState.empires[0].relations += 150;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] < 1)
				{
					politic.loyality -= 120;
				}
				else
				{
					politic.loyality += 120;
				}
			}
			GlobalScript.inst.gameState.allcountries[10].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 3;
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
