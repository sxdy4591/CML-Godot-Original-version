using EventsForDLC;
using UnityEngine;

public class Event23 : EventsSecond
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
		name = " 唐 山 大 地 震";
		text = "7 月28 日 ，3 时42 分 ， 河 北 省 唐 山 市 发 生 了 震 级8.2 级 的 地 震 ， 完 全 摧 毁 了 整 个 城 市 。 距 唐 山 西140 公 里 的 天 津 和 北 京 也 遭 到 破 坏 。 最 高 震 级 为7.1 级 的 几 波 余 震 ， 导 致 了 更 高 的 伤 亡 。 根 据 初 步 数 据 ， 有20 —60 万 人 死 于 地 震 。 据 上 海 市 地 震 局 局 长 张 俊 所 讲 ， 巨 大 破 坏 的 主 要 原 因 是 建 筑 建 造 时 缺 乏 必 要 的 抗 震 措 施 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = "从 预 算 中 拨 款 支 持 重 建 （ 需 要3 百 万 预 算 ）";
		if (GlobalScript.inst.gameState.empires[0].relations >= 600 || GlobalScript.inst.gameState.empires[1].relations >= 600)
		{
			button_text[1] = " 请 求 外 国 的 人 道 主 义 救 援";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 外 国 人 不 会 给 我 们 帮 助";
		}
		button_text[2] = " 分 配 资 金 支 持 重 建 并 开 发 防 震 系 统 （ 需 要5 百 万 预 算 ）";
		button_text[3] = " 让 省 政 府 自 行 解 决";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 唐 山 大 地 震";
		switch (result_num)
		{
		case 0:
			text = " 从 中 央 预 算 中 拨 出 的 资 金 立 即 被 用 于 开 展 救 援 和 重 建 工 作 ， 这 使 得 地 震 带 来 的 后 续 影 响 得 到 了 削 弱 。 今 日 发 生 在 唐 山 的 地 震 ， 是1556 年 陕 西 地 震 之 后 ， 历 史 上 遇 难 者 第 二 多 的 地 震 。";
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[8] -= 30;
			break;
		case 1:
			text = " 国 际 社 会 和 慈 善 组 织 评 估 了 灾 难 的 规 模 ， 同 意 以 无 偿 贷 款 和 派 遣 志 愿 者 的 形 式 向 我 们 提 供 协 助 ， 这 使 得 地 震 的 影 响 得 到 了 缓 解 。 今 日 发 生 在 唐 山 的 地 震 ， 是1556 年 陕 西 地 震 之 后 ， 历 史 上 遇 难 者 第 二 多 的 地 震 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.influencePRC -= 5;
			GlobalScript.inst.gameState.data[4] += 50;
			break;
		case 2:
			text = " 从 中 央 预 算 中 拨 出 的 资 金 立 即 被 用 于 开 展 救 援 和 重 建 工 作 ， 这 使 得 地 震 带 来 的 后 续 影 响 得 到 了 削 弱 。 今 日 发 生 在 唐 山 的 地 震 ， 是1556 年 陕 西 地 震 之 后 ， 历 史 上 遇 难 者 第 二 多 的 地 震 。 我 们 提 供 了 额 外 的 资 金 用 于 在 灾 害 多 发 的 地 区 建 造 抗 震 建 筑 ， 并 进 行 了 大 量 关 于 现 有 建 筑 适 用 性 的 测 试 ， 这 揭 露 出 了 许 多 违 规 的 操 作 。 我 们 希 望 在 未 来 这 能 有 助 于 减 少 同 样 的 灾 难 中 的 受 害 者 。";
			GlobalScript.inst.gameState.data[5] += 50;
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.data[8] -= 50;
			break;
		case 3:
			text = " 中 央 对 河 北 省 的 问 题 置 之 不 理 ， 这 对 善 后 处 理 造 成 了 困 难 ， 也 让 人 民 产 生 了 不 满 ， 但 地 方 当 局 还 是 以 某 种 方 式 成 功 的 应 对 了 灾 区 的 形 势 。 今 日 发 生 在 唐 山 的 地 震 ， 是1556 年 陕 西 地 震 之 后 ， 历 史 上 遇 难 者 第 二 多 的 地 震 。";
			GlobalScript.inst.gameState.data[5] -= 50;
			GlobalScript.inst.gameState.data[3] -= 40;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[4] += 30;
			break;
		}
	}
}
