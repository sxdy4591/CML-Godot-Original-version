using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event556 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " “ 火 热 之 秋 ” 的 重 临";
		text = " 随 着 流 水 线 的 引 入 ， 南 方 农 民 工 涌 入 城 市 ， 新 一 代 工 人 阶 级 也 随 之 而 变 。 可 以 <color=#006400>意 大 利 共 产 党</color> 与 <color=#0027FF>天 主 教 民 主 党</color> 为 代 表 的 建 制 派 却 显 然 没 有 意 识 到 这 代 表 什 么 ： 既 有 政 党 的 反 复 更 迭 、 社 会 改 革 的 缓 步 走 与 随 之 而 来 的 政 治 混 乱 加 剧 了 该 国 工 人 的 不 满 ， 最 终 导 致 各 种 形 式 的 共 产 主 义 力 量 也 因 此 增 长 ： <color=#DE3163>“ 工 人 自 主 ”</color>、<color=#DE3163>“ 继 续 斗 争 ”</color>与<color=#DE3163>“ 前 线 ”</color> 等 激 进 主 义 组 织 甚 至 已 能 在 部 分 地 区 接 收 倒 戈 的 <color=#8B0000>意 大 利 共 产 党</color> 基 层 组 织 与 活 跃 分 子 ， 并 在 工 厂 地 区 形 成 强 大 的 影 响 力 。 意 大 利 当 局 则 因 激 进 武 装 团 体 <color=#8B0000>“ 红 色 旅 ”</color> 的 持 续 打 击 而 不 堪 其 扰 ， 越 加 难 以 把 握 对 国 内 局 势 的 控 制 权 。 罗 马 、 都 灵 、 米 兰 、 博 洛 尼 亚 等 工 业 重 镇 均 陷 入 罢 工 与 夺 厂 运 动 中 ， 地 方 自 治 小 组 已 开 始 筹 建 类 似 俄 国 苏 维 埃 的 组 织 夺 权 。 如 今 ， 恐 怖 主 义 与 共 产 主 义 终 于 实 现 了 合 流 ， 并 在 所 谓 “ 工 人 主 义 ” 学 者 <color=#DE3163>安 东 尼 奥 · 奈 格 里</color> 的 旗 下 组 织 起 独 立 于 意 大 利 当 局 外 的 “ 国 中 之 国 ” ： 他 们 开 始 依 托 工 人 委 员 会 与 地 方 公 社 建 立 新 体 制 ， 并 将 失 业 工 人 、 激 进 学 生 与 左 翼 组 织 为 城 市 游 击 队 。 意 大 利 全 国 就 此 进 入 紧 急 状 态 ： 当 局 与 北 约 军 队 已 开 赴 各 地 镇 压 叛 乱 ， 建 制 派 们 已 响 应 <color=#006400>恩 里 科 · 贝 林 格</color> 及 其 拥 护 者 要 求 建 立 <color=#0027FF>“ 民 族 团 结 政 府 ”</color> 共 同 抵 抗 恐 怖 主 义 的 呼 吁 ， 事 实 上 拉 开 了 欧 洲 大 国 的 内 战 序 幕 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 于 是 革 命 就 这 样 开 始 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " “ 火 热 之 秋 ” 的 重 临";
		if (result_num == 0)
		{
			text = " 起 义 势 不 可 挡 ， 看 起 来 激 进 派 绝 不 会 轻 易 在 此 止 步 。 美 国 与 苏 联 已 经 开 始 呼 吁 建 立 一 个 足 以 镇 压 恐 怖 分 子 起 义 的 民 主 政 府 。 北 约 组 织 各 成 员 国 已 开 始 向 意 大 利 派 送 援 助 。 而 意 大 利 国 内 政 治 版 图 已 犬 牙 交 错 ， 激 进 分 子 纷 纷 筑 起 街 垒 ， 与 政 府 军 展 开 漫 长 而 持 久 的 拉 锯 战 。";
			a.empires[0].power -= 10;
			a.ingamewars[23] = new War().Name("意 大 利 内 战").Attacker("左 翼 激 进 派").Defender("民 族 团 结 政 府")
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.TickTime(30)
				.AmericanSupportDefender.CreateWar;
			if (!a.allcountries[1].isSEV)
			{
				GlobalScript.inst.gameState.ingamewars[23].ussr_place = 1;
			}
		}
	}
}
