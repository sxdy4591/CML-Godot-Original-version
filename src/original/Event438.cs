using EventsForDLC;
using UnityEngine;

public class Event438 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 脆 弱 的 革 命";
		text = " 在 毛 主 席 死 后 ， 我 们 仍 然 设 法 维 持 了 他 的 遗 产 之 一 —— 文 化 大 革 命 ， 并 持 续 至 今 ， 但 我 们 近 期 的 一 些 政 策 似 乎 加 剧 了 党 和 人 民 的 不 满 ：";
		if (GlobalScript.inst.gameState.data[15] >= 8)
		{
			text += " 在 党 政 中 引 入 过 多 的 反 对 派 政 党 ，";
		}
		if (GlobalScript.inst.gameState.data[16] >= 14)
		{
			text += " 经 济 上 私 有 化 程 度 的 加 剧 ，";
		}
		if (GlobalScript.inst.gameState.data[17] >= 19)
		{
			text += " 对 言 论 的 管 制 过 于 放 松 导 致 资 产 阶 级 反 动 言 论 的 音 量 越 来 越 大 ，";
		}
		if (GlobalScript.inst.gameState.data[50] >= 27)
		{
			text += " 对 宗 教 的 管 控 不 力 导 致 一 些 反 党 邪 教 的 兴 起 ，";
		}
		text += " ......；已 经 有 越 来 越 多 反 对 文 化 大 革 命 继 续 进 行 的 声 音 了 ， 对 此 ， 我 们 是 要 承 认 应 该 要 让 这 一 奇 特 的 运 动 盖 棺 定 论 ， 还 是 修 改 一 些 政 策 使 其 继 续 进 行 下 去 呢 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 是 时 候 盖 棺 定 论 了";
		button_text[1] = " 调 整 一 部 分 政 策 使 文 化 大 革 命 继 续 下 去";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 脆 弱 的 革 命";
		switch (result_num)
		{
		case 0:
		{
			text = " 你 说 文 化 大 革 命 已 经 完 成 了 它 的 历 史 任 务 ， 所 以 你 开 始 消 灭 文 化 大 革 命 的 最 后 遗 产 ， 在 全 国 各 地 苟 延 残 喘 至 今 的 相 关 活 动 开 始 被 逐 步 地 大 规 模 地 取 消 ， 这 当 然 使 中 国 人 民 高 兴 了 ， 但 党 内 的 一 些 激 进 左 派 分 子 非 常 愤 怒 ， 因 为 这 意 味 着 毛 主 席 自 认 为 一 生 中 唯 二 做 过 的 事 之 一 被 彻 底 地 盖 棺 定 论 了 ......";
			GlobalScript.inst.gameState.modifies[3].active = false;
			GlobalScript.inst.gameState.data[4] += 200;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.data[6] -= 10;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 100;
				}
				else if (politic.traits[0] > 1)
				{
					politic.loyality += 100;
				}
			}
			break;
		}
		case 1:
		{
			text = " 我 们 做 出 了 一 些 政 策 上 的 调 整 ， 让 文 化 大 革 命 得 以 继 续 维 系 下 去 ， 党 和 人 民 仍 然 是 有 些 不 满 的 ， 但 也 仅 限 于 牢 骚 的 程 度 ， 不 会 发 展 到 失 控 的 局 面 —— 至 少 在 目 前 看 来 是 如 此 ......";
			GlobalScript.inst.gameState.data[4] += 150;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[6] += 10;
			int num = 0;
			if (GlobalScript.inst.gameState.data[15] >= 8)
			{
				GlobalScript.inst.gameState.data[15] = 7;
				num++;
			}
			if (GlobalScript.inst.gameState.data[16] >= 14)
			{
				GlobalScript.inst.gameState.data[16] = 13;
				num++;
			}
			if (GlobalScript.inst.gameState.data[17] >= 19)
			{
				GlobalScript.inst.gameState.data[17] = 18;
				num++;
			}
			if (GlobalScript.inst.gameState.data[50] >= 27)
			{
				GlobalScript.inst.gameState.data[50] = 26;
				num++;
			}
			if (GlobalScript.inst.gameState.data[14] >= 4)
			{
				GlobalScript.inst.gameState.data[14] = 3;
			}
			GlobalScript.inst.gameState.data[8] -= num * 10;
			break;
		}
		}
	}
}
