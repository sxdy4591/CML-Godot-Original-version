using EventsForDLC;
using UnityEngine;

public class Event451 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 中 南 半 岛 的 独 裁 者";
		text = " 尽 管 柬 埔 寨 共 产 党 掌 权 的 波 尔 布 特 集 团 和 我 们 保 持 了 良 好 的 关 系 ， 但 是 他 们 并 不 太 听 取 我 们 的 建 议 。 他 们 在 柬 埔 寨 革 命 后 一 直 采 取 偏 激 的 政 策 — — 宣 扬 大 高 棉 主 义 ， 迫 害 柬 埔 寨 的 各 个 少 数 民 族 （ 包 括 华 人 ） ， 在 柬 越 边 境 制 造 摩 擦 ， 拒 绝 使 用 货 币 ， 将 人 民 粗 暴 地 划 分 为 新 人 和 旧 人 ， 对 柬 共 的 党 组 织 进 行 保 密 以 及 在 国 内 扩 大 化 清 洗 制 造 恐 怖 — — 这 引 起 了 党 内 干 部 和 群 众 的 不 满 。 根 据 我 们 的 情 报 ， 军 队 内 部 分 军 官 对 波 尔 布 特 集 团 的 暴 虐 感 到 担 忧 ； 而 同 时 ， 北 部 大 区 书 记 贵 敦 和 东 部 大 区 书 记 索 平 正 在 各 自 组 建 密 谋 团 体 反 对 波 尔 布 特 集 团 ， 或 许 我 们 可 以 尝 试 串 联 他 们 反 对 波 尔 布 特 集 团 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.data[56] < 2 || GlobalScript.inst.gameState.data[56] > 3)
		{
			button_text[0] = " 让 我 们 推 翻 波 尔 布 特 集 团 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 波 尔 布 特 是 我 们 的 老 朋 友 ！";
		}
		if (GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 1)
		{
			button_text[1] = " 我 们 有 波 尔 布 特 就 够 了 。 ";
		}
		else if (GlobalScript.inst.gameState.data[56] != 2 && GlobalScript.inst.gameState.data[56] != 3 && GlobalScript.inst.gameState.data[56] != 1)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 支 持 独 裁 者 ！";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 中 南 半 岛 的 独 裁 者";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 的 特 工 的 帮 助 下 ， 两 个 密 谋 集 团 实 现 了 串 联 ， 扩 大 后 的 密 谋 网 络 联 系 了 其 他 大 区 中 对 波 尔 布 特 不 满 的 温 和 派 干 部 、 亲 华 派 党 员 和 军 方 反 对 派 的 成 员 。 最 后 ， 在 我 们 的 特 工 从 金 边 接 出 亲 华 派 和 温 和 派 的 高 层 干 部 后 ， 柬 埔 寨 革 命 共 产 党 成 立 了 。 该 组 织 以 “ 结 束 少 数 民 族 迫 害 ， 放 松 政 治 经 济 控 制 ， 恢 复 国 民 经 济 ， 结 束 饥 荒 ” 为 口 号 发 起 了 一 场 全 国 大 起 义 ， 起 义 伊 始 ， 组 织 就 获 得 了 大 批 民 众 、 少 数 民 族 和 部 分 干 部 甚 至 是 军 人 的 支 持 。 在 我 们 和 越 南 的 支 援 下 ， 柬 埔 寨 革 命 共 产 党 赢 得 了 内 战 。 毛 派 分 子 胡 宁 和 蒲 才 在 我 们 的 支 持 下 分 别 当 选 为 改 组 后 的 柬 共 总 书 记 和 新 的 政 府 总 理 ， 并 开 始 大 规 模 调 整 国 家 政 策 。 波 尔 布 特 集 团 被 改 组 后 的 中 央 委 员 会 设 立 的 特 别 法 庭 在 金 边 公 审 后 枪 决 。 由 于 新 的 柬 埔 寨 政 府 有 不 少 成 员 与 越 南 方 面 有 良 好 关 系 ， 也 许 在 这 种 情 况 下 ， 越 南 和 柬 埔 寨 的 关 系 能 够 达 成 缓 和 ？ ";
			a.data[9] -= 30;
			a.data[8] -= 30;
			a.allcountries[23].Gosstroy = 1;
			a.allcountries[23].SubGosstroy = 17;
			a.influencePRC += 50;
			a.allcountries[23].stab = 1;
			GlobalScript.inst.gameState.allcountries[23].prcpower = 1000;
			break;
		case 1:
			text = " 索 平 和 贵 敦 各 自 的 密 谋 都 失 败 了 ， 他 们 谋 划 的 起 义 甚 至 都 没 有 成 功 发 动 ， 大 量 被 怀 疑 涉 及 此 案 的 党 员 和 军 官 都 被 安 全 部 队 逮 捕 。 不 满 的 军 官 多 次 试 图 暗 杀 波 尔 布 特 ， 但 阴 谋 都 被 挫 败 了 。 不 久 后 ， 就 连 以 胡 宁 为 首 的 柬 共 中 意 识 形 态 最 接 近 我 们 的 毛 派 分 子 也 被 清 洗 。 波 尔 布 特 集 团 消 灭 了 他 们 所 认 为 的 一 切 敌 人 ， 真 正 树 立 了 他 们 的 统 治 地 位 。 柬 共 仍 然 维 持 着 他 们 的 偏 激 政 策 。 柬 埔 寨 领 导 人 继 续 担 心 他 们 所 认 为 的 越 南 扩 张 主 义 ； 但 同 时 ， 柬 埔 寨 共 产 党 掌 权 的 波 尔 布 特 集 团 也 持 有 大 高 棉 主 义 的 思 想 。 1 9 7 7 年 4 月 3 0 日 ， 他 们 对 越 南 发 动 了 另 一 次 重 大 军 事 进 攻 。 越 南 对 柬 埔 寨 的 袭 击 感 到 震 惊 ， 于 1 9 7 7 年 底 发 动 报 复 性 打 击 ， 试 图 迫 使 柬 埔 寨 政 府 进 行 谈 判 。 越 南 军 队 于 1 9 7 8 年 1 月 撤 出 ， 尽 管 其 政 治 目 标 尚 未 实 现 ； 柬 埔 寨 仍 然 不 愿 意 认 真 谈 判 。 越 南 方 面 多 次 试 图 交 流 ， 但 柬 埔 寨 方 面 仍 然 不 愿 意 认 真 谈 判 。 我 们 试 图 开 展 调 解 双 方 之 间 关 系 的 和 平 谈 判 ， 然 而 ， 两 国 政 府 未 能 达 成 妥 协 ， 双 方 关 系 仍 在 恶 化 。 柬 埔 寨 未 来 的 命 运 如 何 ， 仍 未 可 知 。 ";
			break;
		}
	}
}
