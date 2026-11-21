using EventsForDLC;
using UnityEngine;

public class Event96 : EventsSecond
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
		name = " 改 革 ！ 民 主 ！ 开 放 ！";
		text = " 现 在 ， 党 组 织 上 问 题 结 束 了 ， 我 们 需 要 履 行 我 们 对 人 民 关 于 按 照 西 方 模 式 对 国 家 民 主 化 的 诺 言 。 人 民 要 求 停 止 对 宗 教 和 教 士 施 压 ， 基 于 西 方 国 家 模 式 扩 大 民 权 和 自 由 ， 更 重 要 的 是 ， 解 散 “ 爱 国 统 一 战 线 ” ， 进 行 人 大 内 和 各 地 方 的 自 由 选 举 。 如 果 我 们 不 能 避 免 选 举 的 到 来 ， 只 要 我 们 满 足 了 人 民 其 他 的 要 求 ， 就 能 使 他 们 得 到 我 们 所 需 要 的 “ 自 由 选 举 ” 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 我 们 正 在 筹 备 全 国 人 大 的 自 由 选 举 ， 所 以 我 们 要 尽 可 能 限 制 其 他 政 党 ， 同 时 还 必 须 满 足 人 民 的 要 求";
		button_text[1] = " 选 举 并 没 有 让 资 产 阶 级 “ 自 由 ” 那 么 可 怕 。 不 用 理 它";
		button_text[2] = " 选 举 并 没 有 让 宗 教 自 由 那 么 可 怕 。 不 用 管 它";
		button_text[3] = " 如 果 我 们 想 让 人 们 爱 我 们 ， 我 们 必 须 满 足 它 的 所 有 要 求";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 改 革 ！ 民 主 ！ 开 放 ！";
		switch (result_num)
		{
		case 0:
			text = " 爱 国 统 一 战 线 及 其 统 战 机 构 已 被 解 散 ， 各 地 正 在 建 立 大 选 机 关 ， 但 我 们 的 选 举 法 将 会 有 效 的 为 那 些 想 要 谋 朝 篡 位 的 宵 小 之 徒 提 供 足 够 的 阻 碍 — — 选 举 法 对 执 政 方 有 着 天 然 优 势 ， 我 们 已 经 禁 止 了 一 切 可 能 威 胁 国 体 的 政 党 ， 剩 下 的 合 法 政 党 也 有 着 一 大 堆 程 序 要 走 才 能 和 我 们 同 台 竞 技 。 不 过 过 去 的 严 格 媒 体 审 核 和 无 情 镇 压 则 被 一 种 新 的 公 开 性 和 自 由 所 冲 淡 。";
			GlobalScript.inst.gameState.data[15] = 8;
			GlobalScript.inst.gameState.data[50] = 27;
			GlobalScript.inst.gameState.data[57] -= 80;
			if (GlobalScript.inst.gameState.data[17] < 19)
			{
				ref int reference2 = ref GlobalScript.inst.gameState.data[17];
				int num2 = reference2;
				reference2 = num2 + 1;
			}
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.data[4] += 80;
			break;
		case 1:
			text = " 爱 国 统 一 战 线 及 其 统 战 机 构 已 被 解 散 ， 各 地 正 在 建 立 大 选 机 关 ， 我 们 将 起 草 全 世 界 最 自 由 ， 最 公 正 的 《 选 举 法 》 ！ 但 另 一 方 面 ， 这 种 大 选 临 近 的 狂 热 的 情 绪 使 得 我 们 可 以 不 必 进 行 大 规 模 自 由 化 ， 尽 管 我 们 不 得 不 放 松 了 对 宗 教 的 压 力 。";
			GlobalScript.inst.gameState.data[15] = 9;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[57] -= 50;
			GlobalScript.inst.gameState.data[50] = 27;
			GlobalScript.inst.gameState.data[4] += 80;
			GlobalScript.inst.gameState.data[6] -= 20;
			break;
		case 2:
			text = " 爱 国 统 一 战 线 及 其 统 战 机 构 已 被 解 散 ， 各 地 正 在 建 立 大 选 机 关 ， 我 们 将 起 草 全 世 界 最 自 由 ， 最 公 正 的 《 选 举 法 》 ！ 但 另 一 方 面 ， 这 种 大 选 临 近 的 狂 热 的 情 绪 和 公 共 生 活 的 自 由 化 有 助 于 我 们 延 续 我 们 的 宗 教 政 策 — — 的 确 ， 虽 然 对 宗 教 组 织 的 管 理 名 义 上 简 化 了 ， 但 是 各 类 宗 教 机 构 仍 然 被 地 方 政 府 和 国 安 部 牢 牢 地 盯 着 。";
			GlobalScript.inst.gameState.data[15] = 9;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[57] -= 70;
			if (GlobalScript.inst.gameState.data[17] < 19)
			{
				ref int reference3 = ref GlobalScript.inst.gameState.data[17];
				int num3 = reference3;
				reference3 = num3 + 1;
			}
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[6] -= 20;
			break;
		case 3:
			text = " 一 切 放 缓 经 济 重 组 和 民 主 化 的 提 案 都 被 我 们 的 领 导 人 狠 狠 地 反 驳 了 回 去 。 爱 国 统 一 战 线 和 统 战 组 织 已 经 被 解 散 ， 各 地 正 在 建 立 大 选 机 关 ， 我 们 将 起 草 全 世 界 最 自 由 ， 最 公 正 的 《 选 举 法 》 ！ 同 时 公 共 生 活 的 逐 步 自 由 化 也 使 得 大 众 欢 庆 鼓 舞 ， 但 是 这 能 持 续 多 久 呢 ？";
			GlobalScript.inst.gameState.data[15] = 9;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[57] -= 120;
			if (GlobalScript.inst.gameState.data[17] < 19)
			{
				ref int reference = ref GlobalScript.inst.gameState.data[17];
				int num = reference;
				reference = num + 1;
			}
			GlobalScript.inst.gameState.data[4] += 120;
			GlobalScript.inst.gameState.data[6] -= 40;
			GlobalScript.inst.gameState.data[50] = 27;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
