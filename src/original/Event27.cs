using EventsForDLC;
using UnityEngine;

public class Event27 : EventsSecond
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
		name = " 港 澳 之 命 运";
		text = " 长 期 以 来 ， 中 国 的 香 港 、 澳 门 一 直 处 于 英 葡 的 殖 民 统 治 之 下 。 然 而 ， 葡 萄 牙 的 法 西 斯 政 权 “ 新 国 家 体 制 ” 于1974 年 被 推 翻 ， 英 国 与 香 港 毗 邻 的 新 界 的99 年 租 期 即 将 到 期 ， 两 国 都 受 到1960 年 《 联 合 国 非 殖 民 化 宣 言 》 的 压 力 ， 所 以 他 们 准 备 妥 协 ， 这 是 我 们 得 到 理 应 属 于 我 们 的 东 西 的 机 会 。 当 然 ， 如 果 他 们 不 相 信 自 己 和 外 国 公 民 的 财 产 是 不 可 侵 犯 的 ， 他 们 就 决 不 会 主 动 交 出 殖 民 地 ， 也 不 会 试 图 实 现 港 澳 的 广 泛 自 治 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 同 意 交 还 港 澳 ， 并 实 施 高 度 自 治";
		button_text[1] = " 同 意 交 还 港 澳 ， 维 持 适 当 自 治";
		button_text[2] = " 要 求 完 全 交 还 港 澳 ， 只 保 留 外 国 人 的 财 产 权";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 港 澳 之 命 运";
		switch (result_num)
		{
		case 0:
			text = " 经 过 长 时 间 的 谈 判 ， 你 们 终 于 和 英 国 、 葡 萄 牙 的 代 表 签 署 了 一 项 协 议 ， 根 据 协 议 ， 香 港 将 于1997 年 于 新 界 租 期 结 束 的 时 候 移 交 给 中 国 ， 澳 门 则 是 在1999 年 。 这 两 个 前 殖 民 地 将 获 得 广 泛 的 自 治 ， 保 留 对 法 律 和 经 济 领 域 的 控 制 权 ， 而 中 华 人 民 共 和 国 中 央 政 府 将 只 处 理 国 防 和 外 交 政 策 问 题 。 当 然 ， 这 将 导 致 权 力 集 中 在 当 地 的 商 业 精 英 手 中 ， 但 这 已 经 无 关 紧 要 了 ， 因 为 我 们 期 待 已 久 的 兄 弟 团 聚 很 快 就 会 来 临 了 ！";
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[65] = 1;
			return;
		case 1:
			if ((GlobalScript.inst.gameState.data[6] <= 600 || GlobalScript.inst.gameState.influencePRC >= 150) && GlobalScript.inst.gameState.empires[0].relations >= 800)
			{
				text = " 经 过 长 时 间 的 谈 判 ， 你 们 终 于 和 英 国 、 葡 萄 牙 的 代 表 签 署 了 一 项 协 议 ， 根 据 协 议 ， 香 港 将 于1997 年 于 新 界 租 期 结 束 的 时 候 移 交 给 中 国 ， 澳 门 则 是 在1999 年 。 这 两 个 前 殖 民 地 将 获 得 有 限 的 自 治 权 ， 同 时 保 留 对 经 济 和 部 分 法 律 领 域 的 控 制 权 。 行 政 权 力 将 由 地 方 选 举 管 理 机 构 和 中 国 共 产 党 的 监 督 机 构 共 同 行 使 。 这 是 我 们 外 交 上 的 胜 利 ！";
				GlobalScript.inst.gameState.data[3] += 100;
				GlobalScript.inst.gameState.influencePRC += 50;
				GlobalScript.inst.gameState.data[1] += 100;
				GlobalScript.inst.gameState.data[65] = 1;
			}
			else
			{
				text = " 经 过 长 时 间 的 谈 判 ， 英 国 和 葡 萄 牙 拒 绝 了 我 们 的 条 件 ， 认 为 这 是 不 可 接 受 的 ， 这 给 党 和 人 民 带 来 了 极 大 的 挫 折 。 看 来 殖 民 地 的 回 归 问 题 被 无 限 期 地 推 迟 了 。 至 少 ， 在 这 样 的 情 况 下 ， 英 国 仍 准 备 在1997 年 或 者 其 他 的 时 候 返 还 新 界 。";
				GlobalScript.inst.gameState.data[3] -= 50;
				GlobalScript.inst.gameState.data[4] += 50;
				GlobalScript.inst.gameState.influencePRC -= 30;
				GlobalScript.inst.gameState.data[1] -= 100;
			}
			break;
		}
		if (result_num == 2)
		{
			if ((GlobalScript.inst.gameState.data[6] <= 500 || GlobalScript.inst.gameState.influencePRC >= 250) && GlobalScript.inst.gameState.empires[0].relations >= 800)
			{
				text = " 经 过 长 时 间 的 谈 判 ， 你 们 终 于 和 英 国 、 葡 萄 牙 的 代 表 签 署 了 一 项 协 议 ， 根 据 协 议 ， 香 港 将 于1997 年 于 新 界 租 期 结 束 的 时 候 移 交 给 中 国 ， 澳 门 则 是 在1999 年 。 这 两 个 前 殖 民 地 将 完 全 处 于 中 华 人 民 共 和 国 的 控 制 之 下 ， 只 保 留 一 些 地 方 自 治 的 形 式 。 外 国 公 民 的 私 有 财 产 将 继 续 在 将 设 立 的 经 济 特 区 的 框 架 内 工 作 ， 行 政 机 构 的 费 用 将 在 殖 民 地 转 移 时 从 英 国 和 葡 萄 牙 转 由 中 国 承 担 。 党 和 人 民 正 在 庆 祝 我 们 外 交 上 的 巨 大 胜 利 ！";
				GlobalScript.inst.gameState.data[3] += 120;
				GlobalScript.inst.gameState.data[1] += 200;
				GlobalScript.inst.gameState.influencePRC += 100;
				GlobalScript.inst.gameState.data[65] = 2;
			}
			else
			{
				text = " 经 过 长 时 间 的 谈 判 ， 英 国 和 葡 萄 牙 拒 绝 了 我 们 的 条 件 ， 认 为 这 是 不 可 接 受 的 ， 这 给 党 和 人 民 带 来 了 极 大 的 挫 折 。 看 来 殖 民 地 的 回 归 问 题 被 无 限 期 地 推 迟 了 。 至 少 ， 在 这 样 的 情 况 下 ， 英 国 仍 准 备 在1997 年 或 者 其 他 的 时 候 返 还 新 界 。";
				GlobalScript.inst.gameState.data[3] -= 50;
				GlobalScript.inst.gameState.data[4] += 50;
				GlobalScript.inst.gameState.influencePRC -= 30;
				GlobalScript.inst.gameState.data[1] -= 100;
			}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
