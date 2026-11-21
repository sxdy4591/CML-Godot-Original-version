using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event563 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " “ 拯 救 ” 的 悲 剧";
		text = " 自 本 · 杰 迪 德 接 任 布 迈 丁 成 为 阿 尔 及 利 亚 新 总 统 后 ， 阿 尔 及 利 亚 便 开 始 进 行 一 系 列 去 布 迈 丁 化 的 改 革 ， 但 是 随 着 解 冻 带 来 的 并 不 是 经 济 的 腾 飞 亦 或 者 民 生 的 改 善 ， 而 是 腐 败 、 国 有 资 产 流 失 、 通 货 膨 胀 和 社 会 福 利 的 下 降 ， 阿 尔 及 利 亚 民 族 解 放 阵 线 （FLN ） 的 一 党 制 政 府 所 做 的 已 经 离 他 们 口 中 奉 行 的 “ 社 会 主 义 ” 越 来 越 远 了 。||本 · 杰 迪 德 失 败 的 改 革 带 来 了 一 系 列 社 会 问 题 ， 随 着 碳 氢 化 合 物 的 价 格 的 下 降 ， 维 持 着FLN 最 后 一 点 “ 社 会 主 义 ” 牌 面 的 福 利 政 策 无 法 持 续 ， 民 众 生 活 成 本 上 升 、 工 人 阶 级 的 失 业 以 及FLN 的 寡 头 政 治 让 人 民 越 来 越 不 满 ， 使 得80 年 代 的 阿 尔 及 利 亚 并 不 太 平 — —1980 年 、1982 年 和1984 年 该 国 就 已 爆 发 过 多 次 地 方 性 的 骚 乱 ， 而 反 对 派 也 随 之 崛 起 ， 社 会 正 走 向 撕 裂 。 在 我 们 的 特 工 秘 密 散 发 了 关 于 阿 尔 及 利 亚 将 进 行 新 一 轮 改 革 削 减 福 利 和 社 会 投 入 的 传 单 后 ， 随 后 引 发 了 小 型 的 示 威 ， 在 军 队 维 持 秩 序 时 ， 一 名 士 兵 失 火 击 伤 了 群 众 ， 使 得 局 势 一 发 不 可 收 拾 。 动 乱 从 各 大 高 校 和 工 人 阶 级 社 区 为 起 点 ， 向 外 蔓 延 ， 群 众 运 动 的 火 焰 烧 遍 了 该 国 北 部 的 各 大 主 要 城 市 ， 人 们 借 鉴 前 几 次 运 动 的 经 验 ， 筑 起 街 垒 ， 占 领 各 大 重 要 的 公 共 建 筑 同FLN 当 局 进 行 对 抗 ， 并 喊 着 各 种 口 号 — — “ 本 · 贝 拉 ” 、 “ 布 迈 丁 ” 、 “ 社 会 主 义 革 命 ” 以 及 “ 圣 战 ” — — 反 对 派 并 未 形 成 一 派 核 心 ， 其 主 要 以 近 期 崛 起 的 伊 斯 兰 救 世 阵 线 、 松 散 的 各 类 泛 自 由 派 团 体 、 共 产 主 义 的 社 会 主 义 先 锋 党 和 本 · 贝 拉 的 左 翼 政 党 阿 尔 及 利 亚 民 主 运 动 以 及 柏 柏 尔 人 的 温 和 左 翼 政 党 社 会 主 义 力 量 阵 线 为 首 。||与 此 同 时 ， 由 于 局 势 混 乱 ， 军 队 内 的 不 满 本 · 杰 迪 德 的 异 见 者 同FLN 保 守 派 的 乌 季 达 帮 的 残 余 分 子 串 联 起 来 ， 希 望 用 乌 季 达 帮 的 布 迈 丁 象 征 平 息 骚 乱 ， 遂 发 动 了 一 场 政 变 ， 但 很 快 ， 本 · 杰 迪 德 便 带 领 忠 于 他 的 军 队 进 行 了 一 场 反 政 变 ， 并 在 随 后 宣 布 国 家 进 入 紧 急 状 态 ， 开 始 镇 压 民 众 起 义 。 改 变 的 最 后 希 望 已 经 消 失 了 ， 而 反 对 派 开 始 各 自 将 群 众 组 织 起 来 ， 对 抗 政 府 的 镇 压 一 场 内 战 开 始 了 ！ 我 们 将 可 以 干 预 其 中 ， 帮 助 其 中 的 某 一 派 成 为 反 对 派 的 主 导 力 量 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] > 0 && a.data[50] == 29 && a.data[31] >= 700)
		{
			button_text[0] = " 我 们 将 支 持 伊 斯 兰 救 世 阵 线 的 伟 大 圣 战 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 宗 教 分 子 的 统 治 和 F L N 有 很 大 区 别 吗 ？";
		}
		if (a.data[56] >= 2)
		{
			button_text[1] = " 我 们 将 支 持 阿 尔 及 利 亚 人 民 追 求 真 正 的 自 由 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 把 运 动 交 给 资 产 阶 级 ！";
		}
		if (a.data[56] < 2)
		{
			button_text[2] = " 我 们 将 支 持 阿 尔 及 利 亚 人 民 重 新 开 展 人 民 革 命 ！";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = " 这 是 不 是 另 一 个 布 迈 丁 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " “ 拯 救 ” 的 悲 剧";
		a.allcountries[40].Gosstroy = 0;
		a.allcountries[40].SubGosstroy = 7;
		a.allcountries[40].Torg = false;
		if (result_num == 0)
		{
			text = " 得 益 于 本 · 杰 迪 德 的 伊 斯 兰 化 政 策 ， 我 们 利 用 民 众 的 不 满 和 部 分 极 端 保 守 的 情 绪 ， 让 伊 斯 兰 救 世 阵 线 在 运 动 中 迅 速 获 得 了 主 导 权 。 救 世 阵 线 开 始 将 积 极 参 与 群 众 运 动 的 民 众 组 织 成 民 兵 ， 并 将 其 与 此 前 组 织 的 伊 斯 兰 主 义 的 地 下 武 装 一 起 改 编 为 伊 斯 兰 救 世 军 ， 向FLN 发 动 “ 圣 战 ” 。 阿 尔 及 利 亚 内 战 开 始 了 。";
			a.ingamewars[40] = new War().Name(" 阿 尔 及 利 亚 内 战").Attacker(" F L N").Defender(" 伊 斯 兰 救 世 阵 线")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(20)
				.AmericanSupportAttacker.SovietSupportAttacker.CreateWar;
			a.empires[0].relations -= 500;
			a.empires[1].relations -= 500;
		}
		if (result_num == 1)
		{
			text = " 出 于 运 动 中 并 未 出 现 一 个 合 格 的 统 一 自 由 派 组 织 的 现 状 ， 我 们 决 定 帮 助 早 在 F L N 建 国 初 期 就 反 对 建 立 一 党 制 而 出 走 另 建 新 党 社 会 主 义 革 命 党 而 被 迫 害 流 亡 的 民 主 社 会 主 义 者 和 建 国 元 勋 — — 穆 罕 默 德 · 布 迪 亚 夫 ， 他 成 功 将 支 持 多 党 制 的 柏 柏 尔 人 温 和 左 翼 社 会 主 义 力 量 阵 线 和 各 个 分 散 的 泛 自 由 派 团 体 联 合 起 来 ， 组 成 了 全 国 民 主 联 盟 。 全 国 民 主 联 盟 打 出 了 “ 面 包 和 自 由 ” 的 口 号 ， 将 运 动 中 的 人 民 聚 集 到 它 的 周 围 。 武 装 的 民 兵 开 始 与FLN 交 战 。 阿 尔 及 利 亚 内 战 开 始 了 。";
			a.ingamewars[40] = new War().Name(" 阿 尔 及 利 亚 内 战").Attacker(" F L N").Defender(" 全 国 民 主 联 盟")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(20)
				.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			a.empires[0].relations += 150;
			a.empires[1].relations -= 500;
		}
		if (result_num == 2)
		{
			text = " 我 们 帮 助 社 会 主 义 先 锋 党 、 阿 尔 及 利 亚 民 主 运 动 和 社 会 主 义 力 量 阵 线 组 成 了 阿 尔 及 利 亚 人 民 民 主 爱 国 阵 线 。 得 益 于 大 量 的 工 人 阶 级 对 运 动 的 参 与 ， 通 过 阿 尔 及 利 亚 社 会 主 义 先 锋 党 的 工 会 组 织 网 络 和 本 · 贝 拉 的 阿 尔 及 利 亚 民 主 运 动 发 起 的 重 建 F L N 早 期 的 社 会 主 义 形 式 的 口 号 ， 左 翼 得 以 动 员 大 批 同 情 马 克 思 主 义 的 知 识 分 子 和 怀 念 社 会 主 义 的 民 众 ， 并 且 争 取 了 同 为 左 翼 的 柏 柏 尔 人 的 社 会 主 义 力 量 阵 线 ， 动 员 了 反 对FLN 压 迫 的 持 左 翼 立 场 的 柏 柏 尔 人 ， 组 织 起 民 兵 与FLN 交 战 。 革 命 开 始 了 。";
			a.ingamewars[40] = new War().Name(" 阿 尔 及 利 亚 内 战").Attacker(" F L N").Defender(" 人 民 民 主 爱 国 阵 线")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(20)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
			a.empires[1].relations += 150;
			a.empires[0].relations -= 500;
		}
	}
}
