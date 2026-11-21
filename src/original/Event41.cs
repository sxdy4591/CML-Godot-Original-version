using EventsForDLC;
using UnityEngine;

public class Event41 : EventsSecond
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
		name = " 印 度 大 选";
		text = " 自1966 年 就 任 的 前 印 度 总 理 ， 国 大 党 党 首 ， 英 迪 拉 · 甘 地 ， 在 她 执 政 期 间 在 社 会 经 济 领 域 积 极 地 开 展 了 左 派 改 革 ， 这 甚 至 激 起 了 国 大 党 内 的 分 裂 ， 和 党 内 右 翼 的 退 出 。 她 执 政 期 间 取 得 了 经 济 成 功 ， 有 效 解 决 贫 困 问 题 ， 但 自1971 年 宣 布 国 家 紧 急 状 态 以 来 ， 反 对 派 人 民 党 开 始 掌 握 优 势 ， 该 党 指 责 甘 地 腐 败 ， 搞 裙 带 关 系 ， 和 威 权 主 义 。 在 这 些 情 况 下 ， 甘 地 决 定 举 行 早 期 议 会 选 举 。 考 虑 到 甘 地 一 直 在 支 持 亲 苏 政 策 和 对 我 们 不 友 好 的 外 交 政 策 ， 还 和 与 我 们 关 系 友 好 的 巴 基 斯 坦 冲 突 ， 直 到 最 近 关 系 才 缓 和 ， 也 许 反 对 派 当 选 可 以 增 强 我 们 的 影 响 力 ？ 人 民 党 团 结 不 同 观 点 的 群 体 ， 从 社 会 主 义 者 到 保 守 主 义 者 ， 并 且 没 有 明 确 的 党 纲 ， 但 这 有 助 于 我 们 更 好 地 掌 控 他 们 。 尽 管 也 许 如 果 我 们 帮 助 英 迪 拉 ， 她 也 许 会 记 得 我 们 的 好 ， 并 推 动 关 系 的 重 建 ？ …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 保 持 距 离";
		if (GlobalScript.inst.gameState.data[9] >= 50)
		{
			button_text[1] = " 支 持 反 对 派";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 足 够 的 力 量";
		}
		if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.data[56] != 0)
		{
			button_text[2] = " 支 持 英 迪 拉 · 甘 地";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 支 持 甘 地 ？ 甚 至 可 能 把 西 藏 领 土 给 她 ？";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 印 度 大 选";
		switch (result_num)
		{
		case 0:
			text = " 因 为 甘 地 和 国 大 党 失 去 人 气 ， 也 因 为 人 民 把 对 抗 国 家 紧 急 状 态 的 人 民 党 和 为 印 度 从 英 国 占 领 中 解 放 出 来 的 自 由 斗 士 联 系 起 来 ， 人 民 党 超 过 了 国 大 党 。 莫 拉 尔 吉 · 德 赛 当 选 了 新 任 总 理 。 他 组 建 的 政 府 恢 复 了 与 我 国 的 关 系 ， 与 巴 基 斯 坦 改 善 关 系 ， 保 卫 印 度 在 世 界 舞 台 上 的 核 政 策 。 成 立 了 一 个 用 以 调 查 国 家 紧 急 状 态 期 间 滥 用 权 力 的 特 殊 法 庭 ， 但 甘 地 却 逃 过 一 劫 。 但 是 ， 在 新 执 政 党 内 部 ， 成 员 间 在 关 于 国 家 发 展 未 来 发 展 方 向 上 ， 已 经 出 现 明 显 的 分 裂 。";
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[91] = 2;
			GlobalScript.inst.gameState.allcountries[19].Torg = true;
			break;
		case 1:
			text = " 因 为 甘 地 和 国 大 党 失 去 人 气 ， 也 因 为 人 民 把 对 抗 国 家 紧 急 状 态 的 人 民 党 和 为 印 度 从 英 国 占 领 中 解 放 出 来 的 自 由 斗 士 联 系 起 来 ， 人 民 党 超 过 了 国 大 党 。 莫 拉 尔 吉 · 德 赛 当 选 了 新 任 总 理 。 他 组 建 的 政 府 恢 复 了 与 我 国 的 关 系 ， 与 巴 基 斯 坦 改 善 关 系 ， 保 卫 印 度 在 世 界 舞 台 上 的 核 政 策 。 成 立 了 一 个 用 以 调 查 国 家 紧 急 状 态 期 间 滥 用 权 力 的 特 殊 法 庭 ， 但 甘 地 却 逃 过 一 劫 。 但 是 ， 在 新 执 政 党 内 部 ， 成 员 间 在 关 于 国 家 发 展 未 来 发 展 方 向 上 ， 已 经 出 现 明 显 的 分 裂 。 我 们 希 望 我 们 与 人 民 党 的 良 好 关 系 可 以 帮 助 其 免 于 垮 台 。";
			GlobalScript.inst.gameState.data[1] += 70;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[91] = 1;
			GlobalScript.inst.gameState.empires[1].relations -= 70;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.allcountries[19].Torg = true;
			GlobalScript.inst.gameState.allcountries[19].prosov = false;
			break;
		case 2:
			text = " 尽 管 过 去 与 我 们 有 过 分 歧 ， 甘 地 还 是 很 感 激 地 接 受 了 我 们 的 帮 助 ， 这 要 归 功 于 印 度 国 大 党 成 功 地 击 败 了 对 手 并 赢 得 胜 利 。 英 迪 拉 · 甘 地 继 续 担 任 总 理 ， 中 印 外 交 关 系 恢 复 ， 但 我 们 之 间 仍 有 明 显 的 紧 张 关 系 ， 领 土 争 端 仍 未 解 决 。 希 望 印 度 国 大 党 能 和 我 们 进 一 步 和 睦 相 处 ， 而 苏 联 不 会 阻 止 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[91] = 3;
			GlobalScript.inst.gameState.empires[1].power += 20;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 30;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
