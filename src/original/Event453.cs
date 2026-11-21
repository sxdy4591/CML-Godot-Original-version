using EventsForDLC;
using UnityEngine;

public class Event453 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 缅 甸 的 新 局 势";
		text = " 过 去 ， 我 们 在 中 缅 边 境 援 助 了 缅 甸 共 产 党 （ 即 白 旗 派 ） 和 部 分 民 族 地 方 武 装 以 支 持 缅 甸 的 共 产 主 义 运 动 。 如 今 ， 我 们 对 他 们 的 支 持 已 经 越 来 越 保 守 化 — — 为 了 维 持 与 缅 甸 政 府 的 关 系 ， 对 缅 共 的 支 持 逐 渐 让 步 于 现 实 外 交 。 但 是 ， 1 9 7 6 年 以 来 ， 缅 甸 进 入 了 一 个 新 的 较 为 动 荡 的 时 期 — — 在 社 会 上 ， 学 校 再 次 爆 发 了 学 生 运 动 ； 在 执 政 党 内 ， 吸 纳 的 左 翼 分 子 逐 渐 与 军 事 派 系 不 和 ； 军 队 内 ， 反 对 派 军 官 酝 酿 了 对 奈 温 的 未 遂 阴 谋 。 主 席 同 志 ， 或 许 这 是 一 次 新 的 机 会 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 让 我 们 在 缅 甸 布 下 些 许 暗 线";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 缅 甸 的 新 局 势";
		if (result_num == 0)
		{
			text = " 在 我 们 的 干 预 下 ， 左 翼 民 族 地 方 武 装 、 红 旗 共 产 党 余 部 最 终 达 成 了 和 解 ， 同 缅 甸 共 产 党 合 并 ， 他 们 使 用 我 们 的 新 支 援 的 武 器 挫 败 了 缅 军 的 围 剿 ， 并 新 占 领 了 一 些 根 据 地 ； 同 时 ， 我 们 的 特 工 也 为 学 生 运 动 送 去 了 武 器 支 持 ， 并 帮 助 他 们 将 学 生 运 动 与 工 人 运 动 联 合 起 来 ； 我 们 也 秘 密 与 处 于 地 下 活 动 的 民 主 派 建 立 了 联 系 ， 为 他 们 送 去 了 援 助 。 更 多 的 反 对 派 加 入 了 缅 共 领 导 的 民 族 民 主 团 结 阵 线 。 军 政 府 对 局 势 的 恶 化 很 不 高 兴 。";
		}
	}
}
