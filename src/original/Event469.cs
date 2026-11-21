using EventsForDLC;
using UnityEngine;

public class Event469 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 红 色 香 江";
		text = " 在1967 年5 月 7 日 ， 距 今 约 十 五 年 ， 由 九 龙 一 家 胶 花 厂 的 劳 资 纠 纷 发 展 而 成 的 震 动 整 个 香 港 的 五 月 风 暴 。 香 港 的 同 志 们 一 直 坚 持 了 七 个 多 月 ， 我 们 也 曾 为 他 们 的 斗 争 进 行 倾 力 援 助 。 然 而 ， 随 着 抗 英 斗 争 的 激 化 ， 香 港 的 左 派 愈 发 开 始 倾 向 于 与 港 英 当 局 进 行 公 开 斗 争 ， 甚 至 于 通 过 炸 弹 恐 怖 袭 击 的 方 式 来 对 抗 港 英 当 局 的 反 动 镇 压 。 最 终 ， 在 时 任 总 理 周 恩 来 的 直 接 命 令 下 ， 香 港 的 左 派 同 志 最 终 停 止 了 这 场 抵 抗 英 国 暴 政 的 活 动 。\n 现 在 ， 随 着 英 国 在 马 岛 战 争 的 失 利 ， 日 不 落 帝 国 正 在 走 向 落 幕 。 部 分 同 志 已 经 开 始 提 出 要 重 启 对 香 港 同 志 们 的 援 助 。 这 无 疑 是 一 个 耗 资 巨 大 且 短 时 间 内 不 一 定 看 到 成 效 的 事 情 ， 却 能 在 很 大 程 度 上 向 世 界 展 示 我 们 对 固 有 领 土 和 世 界 革 命 的 态 度 ， 但 一 些 不 那 么 激 进 党 员 有 所 顾 虑 ， 认 为 这 么 做 会 严 重 损 害 我 们 和 西 方 世 界 的 外 交 关 系 。 又 或 者 说 ， 我 们 应 该 用 更 稳 妥 的 方 式 来 处 理 港 澳 问 题 ? ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.data[56] <= 1)
		{
			button_text[0] = " 重 启 对 香 港 同 志 的 援 助 活 动 ， 让 帝 国 主 义 者 看 看 我 们 的 决 心 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 自 己 都 不 放 心 党 内 的 左 派 ！";
		}
		button_text[1] = "  我 们 应 该 冷 静 一 些 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 红 色 香 江";
		if (result_num == 0)
		{
			text = " 在" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 的 直 接 指 示 下 ， 我 们 开 始 重 启 对 香 港 左 派 同 志 们 的 援 助 工 作 。 在 深 圳 河 畔 ， 广 东 的 军 事 基 地 向 香 港 方 面 大 量 输 送 武 器 、 装 备 ， 甚 至 越 境 协 助 香 港 同 志 们 的 斗 争 。 很 快 ， 香 港 就 陷 入 了 新 一 轮 的 罢 工 潮 ， 原 本 稳 定 下 来 的 形 势 如 今 对 港 英 政 府 而 言 正 在 向 愈 发 严 重 的 方 向 一 路 狂 奔 。 尽 管 我 们 目 前 还 不 能 举 行 正 式 的 武 装 起 义 彻 底 夺 回 香 港 ， 但 新 的 斗 争 无 疑 证 明 了 我 们 要 收 回 香 港 的 决 心 和 我 们 对 革 命 事 业 的 支 持 。 当 然 ， 伦 敦 和 华 盛 顿 不 会 忘 记 这 些 武 器 是 从 哪 里 来 的 … …";
			GlobalScript.inst.gameState.empires[0].relations -= 300;
			GlobalScript.inst.gameState.data[1] += 300;
			GlobalScript.inst.gameState.data[3] += 300;
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.data[9] -= 10;
			GlobalScript.inst.gameState.data[22] -= 30;
		}
		if (result_num == 1)
		{
			text = " 什 么 都 没 发 生 ， 或 许 有 一 天 ， 我 们 能 够 通 过 另 一 种 形 式 来 收 回 香 港 ， 或 许 吧 … …";
		}
	}
}
