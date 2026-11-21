using EventsForDLC;
using UnityEngine;

public class Event35 : EventsSecond
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
		name = " 革 命 的 结 束";
		text = " 在 毛 泽 东 死 后 ， 你 采 取 了 遏 制 文 化 大 革 命 的 措 施 ， 取 得 了 一 定 的 成 果 — — 现 在 已 经 看 不 到 群 众 运 动 了 。 但 自 从 文 化 大 革 命 以 来 ， 国 家 的 高 压 统 治 还 没 有 减 弱 ， 改 革 派 和 人 民 现 在 要 求 “ 拧 松 螺 母 ” 。 除 了 对 公 民 自 由 的 要 求 ， 许 多 人 认 为 有 必 要 减 轻 对 传 统 和 宗 教 的 压 力 ， 文 化 大 革 命 期 间 ， 对 传 统 和 宗 教 的 压 力 成 倍 增 加 。 一 些 人 只 主 张 停 止 反 传 统 主 义 的 言 论 ， 仍 然 保 留 国 家 无 神 论 ， 另 一 些 人 则 根 据 苏 联 模 式 ， 主 张 名 义 上 的 良 心 自 由 ， 同 时 将 宗 教 机 构 和 教 士 置 于 严 格 的 国 家 控 制 之 下 。 由 你 决 定 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 什 么 也 不 做 ， 让 步 够 多 了";
		button_text[1] = " 小 幅 的 自 由 化";
		button_text[2] = " 放 松 控 制 并 继 续 打 压 传 统";
		if (GlobalScript.inst.gameState.data[56] != 0)
		{
			button_text[3] = " 放 松 控 制 ， 只 保 留 对 宗 教 的 监 视";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 不 能 如 此 的 自 由 化 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 革 命 的 结 束";
		switch (result_num)
		{
		case 0:
		{
			text = " 尽 管 文 化 大 革 命 已 经 结 束 ， 但 似 乎 没 有 进 一 步 的 自 由 化 运 动 。 人 民 和 改 革 派 都 很 失 望 。";
			GlobalScript.inst.gameState.data[4] += 40;
			GlobalScript.inst.gameState.data[3] -= 60;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] >= 1)
				{
					politic4.loyality -= 100;
				}
			}
			break;
		}
		case 1:
		{
			text = " 作 为 继 续 与 文 化 大 革 命 的 暴 行 进 行 斗 争 的 一 部 分 ， 中 国 对 人 民 的 压 制 性 逐 渐 略 有 减 弱 。 人 民 和 改 革 者 们 都 很 满 意 ， 但 是 如 果 发 生 了 什 么 的 话 … …";
			GlobalScript.inst.gameState.data[3] += 60;
			GlobalScript.inst.gameState.data[4] += 20;
			GlobalScript.inst.gameState.data[57] -= 30;
			if (GlobalScript.inst.gameState.data[17] < 17)
			{
				GlobalScript.inst.gameState.data[17] = 17;
			}
			GlobalScript.inst.gameState.data[6] -= 20;
			party_change[3] = 1.5f;
			party_change[2] = 2f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] >= 1)
				{
					politic2.loyality += 50;
					politic2.power += 30;
				}
			}
			break;
		}
		case 2:
		{
			text = " 作 为 继 续 与 文 化 大 革 命 的 暴 行 进 行 斗 争 的 一 部 分 ， 中 国 对 人 民 的 压 制 性 逐 渐 略 有 减 弱 ， 对 传 统 的 积 极 斗 争 也 停 止 了 ， 这 代 表 着 对 宗 教 的 控 制 减 轻 了 。 然 而 ， 国 家 无 神 论 的 原 则 并 没 有 削 弱 。 尽 管 有 一 些 地 下 反 政 府 的 牧 师 在 布 道 ， 但 总 的 来 说 ， 人 民 还 是 很 高 兴 的 。 希 望 这 不 会 导 致 什 么 问 题 。";
			GlobalScript.inst.gameState.data[3] += 70;
			GlobalScript.inst.gameState.data[4] += 40;
			GlobalScript.inst.gameState.data[6] -= 30;
			if (GlobalScript.inst.gameState.data[17] < 17)
			{
				GlobalScript.inst.gameState.data[17] = 17;
			}
			if (GlobalScript.inst.gameState.data[50] < 25)
			{
				GlobalScript.inst.gameState.data[50] = 25;
			}
			party_change[3] = 1.5f;
			party_change[2] = 2f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] >= 1)
				{
					politic3.loyality += 80;
					politic3.power += 30;
				}
			}
			break;
		}
		case 3:
		{
			text = " 作 为 继 续 与 文 化 大 革 命 的 暴 行 进 行 斗 争 的 一 部 分 ， 中 国 对 人 民 的 压 制 性 逐 渐 略 有 减 弱 ， 对 传 统 的 积 极 斗 争 也 停 止 了 ， 信 仰 自 由 也 得 到 了 承 认 ， 但 同 时 国 家 保 留 无 神 论 的 课 程 与 宣 传 并 继 续 了 对 宗 教 机 构 的 控 制 。 尽 管 有 一 些 地 下 反 政 府 的 牧 师 在 布 道 ， 但 是 往 往 很 快 就 能 被 镇 压 ， 但 总 的 来 说 ， 人 民 还 是 很 高 兴 的 。 我 们 希 望 这 不 会 导 致 中 国 人 民 之 间 出 现 什 么 问 题 和 冲 突 。";
			GlobalScript.inst.gameState.data[3] += 90;
			GlobalScript.inst.gameState.data[4] += 60;
			GlobalScript.inst.gameState.data[6] -= 40;
			if (GlobalScript.inst.gameState.data[17] < 17)
			{
				GlobalScript.inst.gameState.data[17] = 17;
			}
			if (GlobalScript.inst.gameState.data[50] < 26)
			{
				GlobalScript.inst.gameState.data[50] = 26;
			}
			party_change[3] = 1.5f;
			party_change[2] = 2f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] >= 1)
				{
					politic.loyality += 80;
					politic.power += 50;
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
