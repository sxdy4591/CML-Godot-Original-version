using EventsForDLC;
using UnityEngine;

public class Event38 : EventsSecond
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
		name = " 回 归 本 源";
		text = " 在50 年 代 后 期 的 大 跃 进 运 动 以 来 ， 为 了 应 对 当 时 的 形 势 ， 加 上 当 时 国 家 事 实 上 无 法 负 担 中 央 计 划 经 济 ， 原 本 属 于 中 央 的 经 济 权 力 被 下 放 到 地 方 ， 逐 渐 形 成 了 分 权 式 的 计 划 经 济 体 制 。  现 在 我 们 到 达 了 一 个 新 的 历 史 节 点 ， 党 内 对 经 济 体 制 的 讨 论 也 增 加 了 。 部 分 党 员 认 为 我 们 应 该 再 次 集 权 化 ， 恢 复 中 央 计 划 经 济 体 制 ， 这 能 让 我 们 的 经 济 更 好 地 协 调 发 展 ； 而 改 革 派 认 为 经 济 需 要 像 刘 少 奇 掌 权 时 期 那 样 进 行 一 定 放 松 甚 至 是 进 一 步 并 且 深 化 改 革 ； 当 然 ， 也 有 人 认 为 经 过 了 实 践 考 验 的 分 权 式 计 划 是 当 前 的 最 好 模 式 。 我 们 应 该 如 何 选 择 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		int num = 0;
		if (GlobalScript.inst.gameState.data[87] != 4)
		{
			button_text[1] = "  恢 复 中 央 计 划 经 济 体 系 （ 需 要1 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 党 会 在 你 的 领 导 下 走 向 改 革 ， 而 不 是 重 蹈 覆 辙 ！";
			num++;
		}
		if (GlobalScript.inst.gameState.data[87] != 2 && GlobalScript.inst.gameState.data[87] != 1 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[2] = " 为 了 社 会 主 义 现 代 化 ， 让 我 们 准 备 改 革 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 打 倒 修 正 主 义 ！";
			num++;
		}
		if (GlobalScript.inst.gameState.data[87] != 4 || num >= 2)
		{
			button_text[0] = " 我 们 需 要 维 持 并 深 化 分 权 计 划 经 济 体 系 ";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 旧 制 度 已 经 过 时 了 ！";
			num++;
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 回 归 本 源";
		switch (result_num)
		{
		case 0:
			text = " 由 中 央 、 生 产 单 位 和 地 方 政 府 共 同 协 作 的 的 分 权 式 计 划 经 济 再 次 被 强 调 。 不 久 后 ， 经 中 共 中 央 和 国 务 院 批 准 ， 国 家 计 委 下 达 了 从1974 年 便 开 始 编 订 的 第 五 个 五 年 计 划 和 国 民 经 济 发 展 十 年 规 划 。";
			break;
		case 1:
		{
			text = " 在 之 后 的 政 治 局 会 议 上 ， 我 们 决 定 重 建 在 大 跃 进 开 展 后 逐 渐 被 改 革 的 中 央 计 划 经 济 体 制 ， 国 家 计 委 的 权 力 再 次 扩 大 ， 新 的 经 济 和 数 学 等 方 面 的 专 家 被 邀 请 加 入 计 委 。 不 久 后 ， 经 中 共 中 央 和 国 务 院 的 批 准 ， 国 家 计 委 加 强 了 经 济 集 权 化 ， 随 后 计 委 下 达 了 从1974 年 开 始 编 订 的 第 五 个 五 年 计 划 和 国 民 经 济 发 展 十 年 规 划 。 用 于 转 型 和 成 立 管 理 机 构 的 资 金 已 经 分 配 下 去 ， 鉴 于 苏 联 斯 大 林 时 期 的 经 济 制 度 和 劳 动 纪 律 正 在 被 恢 复 ， 地 方 上 对 经 济 权 力 的 收 回 和 服 从 上 级 的 纪 律 规 章 的 强 化 有 所 不 满 。";
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[3] -= 40;
			GlobalScript.inst.gameState.empires[0].relations -= 70;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.data[16] = 10;
			party_change[0] = 2.5f;
			party_change[1] = 2.5f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality -= 30;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality -= 100;
				}
			}
			break;
		}
		case 2:
		{
			text = " 在 宣 布 对 我 国 的 经 济 体 制 进 行 改 革 之 后 ， 您 和 最 显 赫 的 改 革 派 联 合 组 成 了 一 个 特 别 小 组 ， 并 以 刘 少 奇 的 经 验 制 定 了 未 来 的 经 济 改 革 章 程 ， 全 党 （ 或 者 说 只 是 中 派 和 右 派 ） 正 在 等 待 着 小 组 的 决 定 。 经 济 上 的 “ 解 冻 ” 已 经 开 始 ， 过 去 国 家 对 经 济 方 面 的 压 力 正 在 放 松 ， 并 缩 小 了 对 个 体 经 营 的 限 制 ； 在 部 分 农 村 地 区 ， 新 “ 三 自 一 包 ” 的 行 为 也 被 默 许 。 不 久 后 ， 经 中 共 中 央 和 国 务 院 批 准 ， 随 后 计 委 下 达 了 从1974 年 开 始 编 订 的 第 五 个 五 年 计 划 和 国 民 经 济 发 展 十 年 规 划 ， 但 内 容 却 变 得 不 再 详 细 ， 仅 仅 是 在 大 方 向 上 做 了 一 些 模 糊 的 指 示 。 中 央 的 保 守 派 和 部 分 地 方 干 部 对 这 种 “ 走 资 ” 的 政 策 有 所 不 满 ， 群 众 也 对 此 有 所 疑 虑 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[4] += 20;
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.empires[1].relations -= 70;
			GlobalScript.inst.gameState.empires[0].relations += 80;
			GlobalScript.inst.gameState.data[16] = 12;
			party_change[2] = 4.5f;
			party_change[3] = 4.5f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 2)
				{
					politic.loyality += 150;
					politic.power += 100;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality += 70;
					politic.power += 50;
				}
				else if (politic.traits[0] == 0)
				{
					politic.loyality -= 170;
					politic.power -= 100;
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
