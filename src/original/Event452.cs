using EventsForDLC;
using UnityEngine;

public class Event452 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 印 度 支 那 的 和 平 ？";
		text = " 主 席 同 志 ！ 波 尔 布 特 被 成 功 推 翻 后 ， 印 度 支 那 的 和 平 有 了 很 大 的 希 望 。 起 义 的 其 中 一 位 密 谋 者 索 平 在 过 去 是 柬 共 亲 越 派 的 一 位 重 要 成 员 ， 越 南 人 曾 希 望 他 能 领 导 一 场 反 对 波 尔 布 特 的 起 义 — — 而 这 件 事 已 经 在 我 们 和 越 南 的 共 同 支 持 下 做 到 了 。 新 的 柬 埔 寨 领 导 层 已 经 结 束 了 过 激 政 策 ， 两 国 正 在 开 始 尝 试 寻 求 真 正 的 和 解 。 而 在 推 翻 波 尔 布 特 的 政 策 上 ， 我 们 与 越 南 在 此 前 已 经 达 成 共 识 并 进 行 过 合 作 ， 这 或 许 也 是 解 决 我 们 和 越 南 之 间 冲 突 的 机 会 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 尝 试 开 展 推 进 印 支 和 平 谈 判";
		button_text[1] = " 我 们 无 能 为 力";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 印 度 支 那 的 和 平 ？";
		switch (result_num)
		{
		case 0:
			if (a.empires[1].relations >= 500)
			{
				text = " 由 于 新 的 柬 埔 寨 政 府 有 不 少 成 员 与 越 南 方 面 有 良 好 关 系 ， 以 及 我 们 同 苏 联 关 系 的 回 暖 ， 在 我 们 的 斡 旋 下 ， 新 柬 埔 寨 政 府 和 越 南 最 终 达 成 了 和 解 ， 并 签 订 了 边 界 协 定 和 几 项 合 作 条 约 ， 两 国 关 系 得 以 正 常 化 ， 柬 埔 寨 真 正 开 始 了 恢 复 和 发 展 。 同 时 由 于 越 共 亲 华 派 的 努 力 和 苏 联 寻 求 解 冻 中 苏 关 系 的 施 压 ， 我 们 和 越 南 之 间 也 成 功 达 成 了 和 平 ， 越 南 的 排 华 政 策 和 双 方 的 边 境 冲 突 都 结 束 了 ， 华 人 被 允 许 自 愿 回 国 ， 越 南 也 同 我 们 签 订 了 几 项 合 作 协 定 。";
				a.data[1] -= 100;
				GlobalScript.inst.gameState.influencePRC += 10;
				a.empires[1].relations += 200;
				GlobalScript.inst.gameState.allcountries[11].Torg = true;
				GlobalScript.inst.gameState.vietnampeace = true;
				GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 40;
			}
			else if (a.empires[1].relations < 500)
			{
				text = " 虽 然 新 的 柬 埔 寨 政 府 有 不 少 成 员 与 越 南 方 面 有 良 好 关 系 ， 但 是 我 们 在 柬 越 之 间 组 织 的 谈 判 并 未 成 功 — — 新 柬 埔 寨 的 领 导 人 是 亲 中 的 毛 派 分 子 ， 越 共 认 为 这 还 是 会 威 胁 到 他 们 ； 以 及 越 南 统 治 集 团 的 亲 苏 路 线 和 我 们 同 苏 联 的 恶 劣 关 系 不 容 。 我 们 和 越 南 的 缓 和 谈 判 也 因 为 缺 乏 谈 判 基 础 而 失 败 了 。 柬 埔 寨 真 正 开 始 了 恢 复 和 发 展 ， 但 是 战 争 的 阴 云 仍 未 散 去 。";
				GlobalScript.inst.gameState.influencePRC -= 10;
			}
			break;
		case 1:
			text = " 虽 然 新 的 柬 埔 寨 政 府 有 不 少 成 员 与 越 南 方 面 有 良 好 关 系 ， 但 是 柬 越 之 间 的 自 行 组 织 的 谈 判 并 未 成 功 — — 新 柬 埔 寨 的 领 导 人 是 亲 中 的 毛 派 分 子 ， 越 共 认 为 这 还 是 会 威 胁 到 他 们 ； 以 及 越 南 统 治 集 团 的 亲 苏 路 线 和 柬 共 新 领 导 层 的 毛 主 义 路 线 不 容 。 柬 埔 寨 真 正 开 始 了 恢 复 和 发 展 ， 但 是 战 争 的 阴 云 仍 未 散 去 。";
			GlobalScript.inst.gameState.influencePRC -= 10;
			break;
		}
	}
}
