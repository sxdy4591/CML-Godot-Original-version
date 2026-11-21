using EventsForDLC;
using UnityEngine;

public class Event6 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 低 生 活 水 平";
		text = " 你 的 政 策 导 致 了 这 个 国 家 的 生 活 水 平 的 灾 难 性 下 降 ， 人 民 生 活 在 恶 劣 的 条 件 下 ， 绝 大 多 数 人 甚 至 没 有 能 力 购 买 基 本 必 需 品 。 当 然 ， 这 导 致 了 许 多 抗 议 并 要 求 我 们 解 决 这 场 危 机 。 由 于 士 兵 们 非 常 不 乐 意 去 逮 捕 抗 议 者 ， 所 以 我 们 不 能 指 望 军 队 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 为 社 会 项 目 紧 急 拨 款";
		if ((GlobalScript.inst.gameState.empires[0].relations >= 500 && !GlobalScript.inst.gameState.allcountries[1].isSEV) || (GlobalScript.inst.gameState.empires[1].relations >= 500 && !GlobalScript.inst.gameState.allcountries[51].Torg && !GlobalScript.inst.gameState.allcountries[1].econ))
		{
			button_text[1] = " 请 求 外 国 的 人 道 主 义 救 援";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 无 法 寻 求 帮 助";
		}
		if (GlobalScript.inst.gameState.data[16] >= 13)
		{
			button_text[2] = " 软 硬 兼 施 地 号 召 企 业 解 决 社 会 问 题";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 能 号 召 企 业 ， 因 为 我 们 根 本 没 有 企 业";
		}
		if (GlobalScript.inst.gameState.data[1] >= 500)
		{
			button_text[3] = " 牺 牲 党 和 官 员 的 利 益 ， 安 排 慈 善 活 动";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 白 花 花 的 银 子 就 这 样 花 出 去 ？ 党 绝 不 允 许 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 低 生 活 水 平";
		if (result_num == 0)
		{
			text = " 预 算 中 大 量 资 金 被 紧 急 拨 给 社 会 事 业 、 住 房 建 设 和 援 助 贫 困 人 口 。 社 会 问 题 正 在 逐 步 得 到 解 决 ， 人 民 对 此 感 到 满 意 。";
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[5] = 300;
		}
		if (result_num == 1)
		{
			text = " 我 们 要 求 外 国 提 供 人 道 主 义 援 助 。 来 自 不 同 国 家 和 联 合 国 的 志 愿 者 免 费 分 发 食 物 ， 并 为 人 们 提 供 住 房 。 然 而 ， 这 些 行 动 向 我 国 人 民 和 国 际 社 会 表 明 ， 我 们 无 法 独 自 处 理 这 一 人 道 主 义 危 机 ， 这 大 大 损 害 了 我 们 的 声 誉 。";
			GlobalScript.inst.gameState.data[4] += 200;
			GlobalScript.inst.gameState.influencePRC -= 100;
			GlobalScript.inst.gameState.data[5] = 300;
		}
		if (result_num == 2)
		{
			text = " 通 过 制 定 劳 动 法 、 政 府 命 令 和 软 硬 兼 施 ， 我 们 成 功 地 迫 使 我 们 的 商 人 为 人 民 提 供 社 会 支 持 ， 改 善 工 作 条 件 和 住 房 条 件 。 然 而 ， 他 们 并 不 特 别 乐 意 与 人 分 享 他 们 的 财 富 ， 并 且 利 用 他 们 与 高 层 的 关 系 向 你 施 加 压 力 。";
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[1] -= 500;
			GlobalScript.inst.gameState.data[5] = 300;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 3 || politic.traits[0] == 2)
				{
					politic.loyality -= 100;
				}
			}
		}
		if (result_num == 3)
		{
			text = " 在 党 的 特 别 会 议 上 ， 你 向 党 的 最 高 领 导 层 解 释 了 形 势 的 严 重 性 ， 并 决 定 拨 款 解 决 党 的 社 会 需 求 ， 带 头 吸 引 党 员 、 干 部 参 加 慈 善 活 动 。 这 提 高 了 人 民 的 生 活 水 平 ， 但 党 并 不 满 意 。";
			GlobalScript.inst.gameState.data[1] = 0;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[5] = 300;
			Politic[] politics2 = GlobalScript.inst.gameState.politics;
			for (int j = 0; j < politics2.Length; j++)
			{
				politics2[j].loyality -= 300;
			}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
