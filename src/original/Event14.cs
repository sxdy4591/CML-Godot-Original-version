using EventsForDLC;
using UnityEngine;

public class Event14 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

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
		name = " 我 们 没 有 钱 ， 但 是 你 要 撑 住 啊 ！";
		text = " 我 们 的 预 算 和 储 备 金 太 少 了 。 如 果 继 续 这 样 下 去 ， 我 们 很 快 就 无 法 维 持 我 们 国 家 的 正 常 工 作 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		int num = 0;
		if (GlobalScript.inst.gameState.data[16] >= 13 && GlobalScript.inst.gameState.data[5] >= 500)
		{
			button_text[0] = " 提 高 税 收 和 削 减 社 会 项 目";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "";
			num++;
		}
		if (GlobalScript.inst.gameState.data[16] >= 14)
		{
			button_text[1] = " 提 高 奢 侈 品 税 和 巨 富 税";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 国 没 有 寡 头 可 被 榨 油 水";
			num++;
		}
		if (GlobalScript.inst.gameState.data[16] <= 14 && GlobalScript.inst.gameState.data[56] != 0 && (GlobalScript.inst.gameState.data[15] > 7 || GlobalScript.inst.gameState.data[56] != 1))
		{
			button_text[3] = " 加 快 国 有 企 业 私 有 化";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 不 能 进 一 步 推 动 私 有 化";
			num++;
		}
		if (GlobalScript.inst.gameState.empires[0].relations > 500 || (GlobalScript.inst.gameState.empires[1].relations > 500 && GlobalScript.inst.gameState.influencePRC >= 50) || num >= 3)
		{
			button_text[2] = " 接 受 外 国 贷 款";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 没 人 愿 意 借 钱 给 我 们";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 们 没 有 钱 ， 但 是 你 要 撑 住 啊 ！";
		switch (result_num)
		{
		case 0:
			text = " 税 率 和 费 用 已 经 增 长 ， 且 服 务 大 众 的 社 会 福 利 项 目 拨 款 也 随 之 减 少 。 这 个 当 然 是 有 利 于 减 少 赤 字 的 ， 但 是 谁 喜 欢 这 样 啊 ？";
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[8] += 100;
			GlobalScript.inst.gameState.data[5] -= 300;
			break;
		case 1:
			text = " 奢 侈 品 税 和 富 人 税 已 经 增 长 ， 这 使 得 我 们 可 以 在 不 伤 害 普 通 民 众 的 基 础 上 减 小 赤 字 。 但 是 寡 头 们 开 始 利 用 他 们 的 影 响 力 来 向 群 众 哭 诉 “ 党 是 如 何 掠 夺 勤 劳 致 富 的 人 ” 的 ， 而 且 党 内 高 层 也 有 一 些 人 赞 同 这 一 意 见 。";
			GlobalScript.inst.gameState.data[8] += 100;
			GlobalScript.inst.gameState.data[1] -= 500;
			GlobalScript.inst.gameState.data[4] += 300;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.data[108] -= 5;
			break;
		case 2:
			text = " 我 国 的 外 债 逐 渐 攀 升 ， 这 使 得 我 们 能 够 继 续 减 小 我 们 的 赤 字 ， 但 是 这 会 对 我 们 的 国 际 影 响 力 造 成 负 面 结 果 。 而 且 我 们 还 是 要 还 钱 ， 只 不 过 晚 了 一 会 而 已........";
			GlobalScript.inst.gameState.data[8] += 100;
			GlobalScript.inst.gameState.data[69] += 100;
			GlobalScript.inst.gameState.influencePRC -= 50;
			break;
		case 3:
			text = " 许 多 国 有 企 业 最 后 变 成 了 私 人 财 产 ， 这 使 得 我 国 的 生 活 标 准 下 降 并 使 得 我 们 的 经 济 体 制 开 始 被 慢 慢 瓦 解 。 但 我 们 的 赤 字 减 少 了 。";
			GlobalScript.inst.gameState.data[5] -= 100;
			GlobalScript.inst.gameState.data[8] += 100;
			GlobalScript.inst.gameState.data[12] -= 50;
			GlobalScript.inst.gameState.data[13] -= 50;
			GlobalScript.inst.gameState.data[68] -= 50;
			GlobalScript.inst.gameState.data[108] += 20;
			if (GlobalScript.inst.gameState.data[16] <= 12)
			{
				GlobalScript.inst.gameState.data[16] = 13;
			}
			else if (GlobalScript.inst.gameState.data[16] <= 14)
			{
				int[] data = GlobalScript.inst.gameState.data;
				int num = 16;
				ref int reference = ref data[num];
				int num2 = data[num];
				reference = num2 + 1;
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
