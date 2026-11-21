using EventsForDLC;
using UnityEngine;

public class Event97 : EventsSecond
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
		name = " 自 动 化 ？";
		text = " 这 是 我 们 最 伟 大 的 科 学 突 破 － 最 近 以 来 我 们 与 经 济 完 全 落 后 的 情 况 斗 争 ， 现 在 我 们 的 科 学 家 在 基 于 计 算 机 系 统 开 发 自 动 化 经 济 计 划 的 机 制 方 面 取 得 了 杰 出 成 就 ， 并 开 始 开 发 允 许 自 动 化 计 划 和 调 节 全 国 企 业 的 系 统 。 距 离 系 统 的 全 面 实 施 仍 有 相 当 距 离 ， 但 现 在 如 果 我 们 想 取 得 自 动 化 经 济 的 成 功 的 话 ， 我 们 可 以 并 也 应 该 引 入 基 层 地 区 的 系 统 和 协 作 。 但 是 ， 许 多 官 员 和 党 员 ， 认 为 引 入 这 样 一 个 不 熟 悉 的 系 统 太 匆 忙 了 ， 他 们 显 然 不 喜 欢 它 …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 我 们 开 始 大 规 模 实 施 自 动 化 系 统";
		button_text[1] = " 急 于 求 成 不 会 有 好 结 果 ， 要 循 序 渐 进 ， 不 要 想 一 蹴 而 就 。";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 自 动 化 ？";
		switch (result_num)
		{
		case 0:
		{
			text = " 我 国 的 经 济 规 划 自 动 化 项 目 现 在 已 正 式 启 动 ， 区 域 性 计 算 机 中 枢 正 在 积 极 建 设 和 投 入 运 行 ， 各 计 算 中 枢 之 间 的 协 调 网 络 正 在 逐 步 建 立 。 统 计 部 门 已 经 预 测 我 们 的 生 产 力 会 有 大 幅 度 的 提 高 ， 供 给 也 会 得 到 改 善 ， 但 是 并 不 是 所 有 的 党 员 都 对 你 们 的 创 新 感 到 满 意 。";
			GlobalScript.inst.gameState.data[1] = 0;
			GlobalScript.inst.gameState.data[8] -= 50;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality += 1000;
				}
				else
				{
					politic.loyality -= 500;
				}
			}
			GlobalScript.inst.gameState.modifies[11].active = true;
			GlobalScript.inst.gameState.doctr[10] = GlobalScript.inst.new_events_text[360];
			GlobalScript.inst.gameState.doctr[11] = GlobalScript.inst.new_events_text[361];
			break;
		}
		case 1:
			text = " 有 人 指 出 有 必 要 逐 步 和 谨 慎 地 采 用 这 种 新 技 术 。 基 层 规 划 部 门 的 自 动 化 进 程 极 其 缓 慢 ， 且 饱 受 官 僚 主 义 的 打 压 。 按 照 这 个 速 度 下 去 ， 预 期 的 生 产 率 增 长 将 不 会 很 快 实 现 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
