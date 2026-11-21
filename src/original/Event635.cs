using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event635 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "Belice\u00a0de\u00a0Guatemala";
		text = "伯 利 兹 ， 或 称 英 属 洪 都 拉 斯 ， 一 直 以 来 都 是 危 地 马 拉 方 面 力 图 收 复 的 领 土 。 十 七 世 纪 ， 英 国 无 视 西 班 牙 的 领 土 要 求 侵 吞 蚕 食 了 这 一 地 区 ， 而 中 美 洲 联 邦 解 体 后 由 英 国 所 扶 持 的 危 地 马 拉 “ 独 立 之 父 ” 则 在1859 年 与 英 国 签 订 了 条 约 ， 正 式 将 伯 利 兹 地 区 的 主 权 所 出 卖 ， 使 英 国 彻 底 占 领 了 这 片 地 区 。 尽 管 伯 利 兹 已 经 于1981 年 独 立 ， 但 英 国 还 是 在 该 国 保 留 了 一 支 一 千 五 百 人 的 部 队 。||为 了 转 移 国 民 对 日 益 加 剧 的 社 会 动 荡 的 注 意 力 ， 危 地 马 拉 军 政 府 选 择 了 声 索 伯 利 兹 领 土 ， 这 一 直 以 来 都 受 到 大 半 个 拉 丁 美 洲 的 反 对 。 不 过 ， 英 国 在 马 尔 维 纳 斯 群 岛 的 这 场 耻 辱 性 大 败 彻 底 将 这 个 昔 日 的 日 不 落 帝 国 的 颜 面 丢 的 一 干 二 净 ， 这 使 又 一 个 野 心 家 将 自 己 的 目 光 投 向 了 英 国 的 势 力 范 围 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = "这 究 竟 会 是 马 岛 战 争 的 重 演 ， 还 是 又 一 场 丑 角 表 演 的 滑 稽 喜 剧 ？";
		button_text[1] = " 帮 助 伯 利 兹 抵 抗 危 地 马 拉 的 侵 略";
		button_text[2] = " 支 持 军 政 府 收 复 故 土";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "Belice\u00a0de\u00a0Guatemala";
		a.allcountries[149].parts[2] = true;
		if (result_num == 0)
		{
			text = "以 凯 比 尔 （kaibil ） 特 种 兵 为 主 力 ， 危 地 马 拉 军 队 迅 速 跨 过 两 国 边 境 ， 一 场 战 争 打 响 了 。";
			a.ingamewars[66] = new War().Name("危 地 马 拉 统 一 战 争").Attacker("危 地 马 拉").Defender("伯 利 兹")
				.AttackerInfluence(600)
				.DefenderInfluence(400)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
		if (result_num == 1)
		{
			text = "以 凯 比 尔 （kaibil ） 特 种 兵 为 主 力 ， 危 地 马 拉 军 队 迅 速 跨 过 两 国 边 境 ， 一 场 战 争 打 响 了 。||我 们 大 力 支 持 了 伯 利 兹 抵 抗 危 地 马 拉 军 政 府 侵 略 的 行 动 ， 向 英 国 提 供 了 军 事 支 持 。 在 新 一 期 人 民 日 报 的 头 版 上 ， 大 幅 刊 登 了 伯 利 兹 的 反 侵 略 战 争 ， 盛 赞 了 伯 利 兹 人 民 抗 击 危 地 马 拉 扩 张 主 义 侵 略 的 英 勇 举 动 和 英 军 千 里 迢 迢 赶 来 帮 助 伯 利 兹 人 民 反 击 侵 略 的 国 际 主 义 精 神 。";
			a.data[8] -= 20;
			a.data[4] += 50;
			a.empires[0].power += 5;
			a.ingamewars[66] = new War().Name("危 地 马 拉 统 一 战 争").Attacker("危 地 马 拉").Defender("伯 利 兹")
				.AttackerInfluence(550)
				.DefenderInfluence(450)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
		if (result_num == 2)
		{
			text = "以 凯 比 尔 （kaibil ） 特 种 兵 为 主 力 ， 危 地 马 拉 军 队 迅 速 跨 过 两 国 边 境 ， 一 场 战 争 打 响 了 。||我 们 大 力 支 持 了 危 地 马 拉 收 复 故 土 的 行 动 ， 向 其 提 供 了 军 事 支 持 。 在 新 一 期 人 民 日 报 的 头 版 上 ， 大 幅 刊 登 了 危 地 马 拉 统 一 战 争 ， 盛 赞 了 军 政 府 不 畏 强 暴 、 敢 于 直 面 英 帝 而 发 动 统 一 战 争 的 魄 力 ， 而 伯 利 兹 也 在 文 中 被 类 比 为 “ 危 地 马 拉 的 台 湾 ” 。";
			a.data[4] -= 50;
			a.empires[0].power += 5;
			a.data[8] -= 20;
			a.allcountries[149].Torg = true;
			a.empires[0].power += 5;
			a.empires[0].relations += 80;
			a.ingamewars[66] = new War().Name("危 地 马 拉 统 一 战 争").Attacker("危 地 马 拉").Defender("伯 利 兹")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
	}
}
