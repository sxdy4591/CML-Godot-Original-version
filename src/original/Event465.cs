using EventsForDLC;
using UnityEngine;

public class Event465 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 荣 耀 归 你 ， 阿 拉 伯 之 旗";
		text = " 多 亏 了 我 们 的 帮 助 ， 阿 拉 伯 国 家 之 间 的 合 作 越 发 紧 密 。 泛 阿 拉 伯 主 义 从 近 乎 无 法 实 现 的 幻 想 ， 变 成 了 现 实 。 在 最 近 的 阿 拉 伯 社 会 主 义 同 盟 代 表 大 会 上 ， 阿 拉 伯 共 和 国 联 邦 主 席 阿 里 · 萨 布 里 宣 布 将 “ 把 阿 拉 伯 共 和 国 联 邦 转 化 为 中 东 地 区 革 命 的 堡 垒 ， 一 劳 永 逸 驱 逐 帝 国 主 义 者 的 干 涉 ” 。 而 我 们 在 中 东 地 区 的 布 局 也 来 到 了 最 为 关 键 的 一 步 — — 组 建 一 个 统 一 的 阿 拉 伯 共 和 国 ， 这 将 会 对 世 界 革 命 事 业 和 第 三 世 界 的 独 立 献 上 最 好 的 祝 福 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 为 我 们 的 国 际 主 义 同 志 们 敬 一 杯 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 荣 耀 归 你 ， 阿 拉 伯 之 旗";
		if (result_num != 0)
		{
			return;
		}
		text = " 很 快 ， 利 比 亚 ， 叙 利 亚 ， 伊 拉 克 等 阿 拉 伯 共 和 国 联 邦 成 员 国 齐 聚 开 罗 。 各 地 的 复 兴 党 ， 民 族 解 放 阵 线 和 革 命 党 就 组 建 一 个 联 邦 性 质 的 国 家 达 成 了 共 识 ： 邦 联 将 改 组 为 阿 拉 伯 联 合 共 和 国 。 新 生 的 联 邦 性 政 权 将 会 组 由 阿 拉 伯 革 命 委 员 会 建 统 一 调 度 的 军 队 和 警 察 机 构 ， 阿 拉 伯 革 命 委 员 会 大 部 分 成 员 由 各 成 员 国 的 高 层 担 任 ， 地 方 保 持 较 高 的 自 治 ； 完 善 货 币 体 系 ， 就 调 整 各 地 的 发 展 情 况 ， 进 行 统 制 经 济 ， 对 沙 特 ， 阿 曼 等 尚 未 加 入 联 邦 的 地 区 进 行 宣 称 并 宣 布 未 来 会 进 行 一 系 列 行 动 来 收 复 失 地 。 当 联 邦 的 成 员 遭 到 外 界 侵 犯 的 时 候 ， 将 被 视 为 对 全 体 联 邦 各 国 的 侵 犯 。 当 联 邦 成 员 无 法 妥 善 处 理 自 身 危 机 时 ， 联 邦 当 局 有 权 采 取 果 决 的 干 涉 行 动 。 对 内 将 加 大 学 术 性 的 交 流 ， 并 就 敏 感 话 题 进 行 商 讨 ， 例 如 首 都 问 题 ， 对 其 他 阿 拉 伯 国 家 的 态 度 ， 以 及 客 观 上 东 西 发 展 的 不 均 衡 。 |外 界 对 此 的 态 度 不 同 ， 第 三 世 界 国 家 普 遍 将 其 视 为 一 个 令 人 振 奋 的 决 定 。 这 是 第 一 次 在 中 东 出 现 了 具 有 支 配 地 位 的 地 区 性 强 国 ， 这 无 疑 会 为 中 东 的 乱 象 画 上 休 止 符 。 华 盛 顿 对 此 的 评 价 是 “ 令 人 担 忧 的 颠 覆 性 霸 权 ” “ 潜 在 的 火 药 桶 ” 。 新 政 权 由 于 具 有 阿 拉 伯 和 非 洲 国 家 的 双 面 性 ， 阿 拉 伯 联 盟 和 非 洲 统 一 组 织 仍 然 接 纳 其 为 成 员 。 联 合 国 也 在 考 虑 是 否 要 将 其 与 澳 大 利 亚 纳 入 新 的 联 合 国 常 任 理 事 国 体 系 。 也 有 传 言 称 ， 新 生 的 阿 拉 伯 联 合 共 和 国 正 在 谋 求 加 入 核 俱 乐 部 。 | 和 上 次 失 败 的 尝 试 不 同 ， 这 次 阿 拉 伯 各 国 团 结 一 心 。 泛 阿 拉 伯 主 义 的 旗 帜 将 会 在 中 东 世 界 的 上 空 飘 扬 ， 直 到 永 远 … … 对 吧 ？";
		GlobalScript.inst.gameState.data[6] += 50;
		GlobalScript.inst.gameState.influencePRC += 100;
		GlobalScript.inst.gameState.empires[0].relations -= 200;
		GlobalScript.inst.gameState.allcountries[54].parts[0] = true;
		GlobalScript.inst.gameState.allcountries[30].proprc = false;
		for (int i = 17; i < 56; i++)
		{
			if (i == 55 || i == 54 || i == 18)
			{
				GlobalScript.inst.gameState.allcountries[i].prosov = false;
				GlobalScript.inst.gameState.allcountries[i].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[i].proprc = false;
				GlobalScript.inst.gameState.allcountries[i].isSEV = false;
				GlobalScript.inst.gameState.allcountries[i].isOVD = false;
				GlobalScript.inst.gameState.allcountries[i].okb = false;
				GlobalScript.inst.gameState.allcountries[i].econ = false;
				GlobalScript.inst.gameState.allcountries[i].Torg = false;
				GlobalScript.inst.gameState.allcountries[i].oar = false;
			}
		}
	}
}
