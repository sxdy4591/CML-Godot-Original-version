using EventsForDLC;
using UnityEngine;

public class Event494 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 防 患 于 未 然 ？";
		text = " 主 席 同 志 ， 在 大 规 模 推 广 自 动 化 生 产 后 ， 一 些 科 研 人 员 担 心 我 们 的 自 动 化 经 济 系 统 可 能 会 遭 到 敌 人 入 侵 ， 用 来 破 坏 我 们 最 新 的 社 会 主 义 现 代 化 经 济 成 果 。 不 过 得 益 于 我 们 已 经 研 究 了 信 息 化 时 代 的 战 争 方 式 ， 或 许 我 们 应 该 给 I E C S 系 统 研 究 一 种 “ 防 火 墙 ” ， 来 抵 御 未 来 潜 在 的 威 胁 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[8] + a.data[36] >= 100)
		{
			button_text[0] = " 好 ， 就 这 么 办 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 可 惜 我 们 没 有 这 么 多 钱";
		}
		button_text[1] = " 多 一 事 不 如 少 一 事";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 防 患 于 未 然 ？";
		if (result_num == 0)
		{
			a.data[8] -= 100;
			text = " 我 们 的 科 研 人 员 正 在 着 手 开 发 基 于 I E C S 的 网 络 防 火 墙 。 在 此 期 间 ， 我 们 的 科 研 人 员 不 断 扮 演 着 网 络 攻 击 者 与 防 御 者 ， 这 使 得 我 们 发 现 了 I E C S 网 络 系 统 的 大 量 潜 在 漏 洞 ， 我 们 的 科 研 人 员 也 借 此 收 获 颇 丰 ， 得 到 了 大 量 的 关 于 计 算 机 网 络 系 统 攻 防 的 实 战 经 验 。";
			a.data[11] += 300;
		}
		if (result_num == 1)
		{
			text = " 我 们 认 为 就 算 是 美 苏 也 不 至 于 采 用 最 先 进 的 信 息 化 技 术 战 术 来 从 这 个 角 度 进 攻 我 们 ， 所 以 这 个 天 马 行 空 的 计 划 被 搁 置 了 。";
		}
	}
}
