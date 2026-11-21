using EventsForDLC;
using UnityEngine;

public class Event11 : EventsSecond
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
		name = " 工 业 衰 退";
		text = " 我 们 的 工 业 正 处 于 前 所 未 有 的 衰 退 之 中 — 一 些 工 厂 闲 置 ， 一 些 工 厂 即 将 关 闭 ， 所 有 工 厂 都 在 使 用 过 时 的 设 备 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 紧 急 拨 款 用 于 发 展";
		if (GlobalScript.inst.gameState.empires[0].relations >= 60 && (GlobalScript.inst.gameState.data[16] >= 13 || GlobalScript.inst.gameState.SEZ))
		{
			button_text[1] = " 吸 引 外 国 投 资";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 投 资 者 嫌 弃 我 们";
		}
		if (GlobalScript.inst.gameState.empires[1].relations >= 70 || GlobalScript.inst.gameState.relres)
		{
			button_text[2] = " 请 求 苏 联 的 帮 助";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 需 要 修 正 主 义 者 的 施 舍 ！";
		}
		if (GlobalScript.inst.gameState.data[13] >= 500)
		{
			button_text[3] = " 以 牺 牲 农 业 为 代 价 促 进 发 展";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 农 业 的 处 境 也 好 不 到 哪 里 去";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 工 业 衰 退";
		switch (result_num)
		{
		case 0:
			text = " 大 量 资 金 被 紧 急 从 预 算 中 拨 出 ， 用 于 工 业 现 代 化 、 引 进 这 一 领 域 的 技 术 和 专 家 。 问 题 开 始 被 解 决 了 。";
			GlobalScript.inst.gameState.data[12] += 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			return;
		case 1:
			text = " 我 们 的 招 商 引 资 活 动 非 常 成 功 ！ 外 国 人 全 资 建 造 和 现 代 化 我 们 的 工 厂 ， 我 们 没 有 从 预 算 里 花 半 毛 钱 。 诚 然 ， 为 此 ， 我 们 有 必 要 降 低 工 人 最 低 工 资 、 安 全 生 产 要 求 等 劳 动 法 规 的 要 求 ， 但 没 关 系 ， 人 民 会 承 受 住 的 。";
			GlobalScript.inst.gameState.data[12] += 100;
			GlobalScript.inst.gameState.data[5] -= 50;
			GlobalScript.inst.gameState.data[4] -= 50;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			break;
		case 2:
		{
			text = " 苏 联 同 意 像 过 去 帮 助 我 们 那 样 使 我 们 现 在 实 现 工 业 现 代 化 。 然 而 ， 他 们 并 没 有 像 从 前 一 样 为 我 们 无 偿 派 遣 专 家 和 机 器 ， 我 们 对 苏 联 仍 有 一 些 依 赖 。";
			GlobalScript.inst.gameState.data[12] += 100;
			GlobalScript.inst.gameState.empires[1].power += 10;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 3 || politic.traits[0] == 2)
				{
					politic.loyality -= 100;
				}
			}
			break;
		}
		case 3:
			text = " 通 过 对 企 业 预 算 资 金 和 收 入 的 再 分 配 ， 我 们 能 够 将 农 业 的 力 量 引 导 到 工 业 的 发 展 。 这 对 工 业 有 帮 助 ， 但 农 业 遭 受 了 巨 大 打 击 。";
			GlobalScript.inst.gameState.data[12] += 100;
			GlobalScript.inst.gameState.data[13] -= 100;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
