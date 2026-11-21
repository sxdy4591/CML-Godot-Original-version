using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event571 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "阿 拉 伯 联 合 共 和 国 入 侵 科 威 特 ";
		text = " 数 年 前 在 伊 拉 克 上 台 的 萨 达 姆 · 侯 赛 因 ， 几 乎 是 在 掌 权 同 时 便 将 自 己 打 扮 为 新 的 贾 迈 勒 · 阿 卜 杜 勒 · 纳 赛 尔 ， 并 试 图 将 伊 拉 克 打 造 为 第 三 世 界 的 领 头 羊 。 在 1 9 7 9 年 时 ， 他 甚 至 保 证 提 供 与 世 界 油 价 挂 钩 的 无 息 贷 款 。 ||而 在 阿 拉 伯 联 合 共 和 国 成 立 后 ， 萨 达 姆 被 自 己 国 内 外 的 巨 大 声 望 冲 昏 了 头 脑 。 为 了 进 一 步 巩 固 自 己 的 地 位 ， 他 对 邻 国 科 威 特 的 油 田 动 了 歪 脑 筋 。 因 此 ， 他 谴 责 科 威 特 政 府 在 临 近 两 国 边 界 的 的 鲁 米 利 亚 地 区 内 盗 采 石 油 ， 并 以 此 为 由 在 阿 拉 伯 国 家 国 务 委 员 会 议 上 提 出 了 为 维 护 新 生 共 和 国 利 益 而 向 科 威 特 进 行 特 别 军 事 行 动 的 议 题 ， 议 题 被 全 票 通 过 ， 很 快 ， 阿 联 共 便 向 与 科 威 特 的 边 界 派 出 部 队 并 要 求 科 威 特 政 府 谈 判 。 在 第 二 天 举 行 的 谈 判 失 败 后 ， 阿 联 共 便 开 始 向 科 威 特 领 土 进 发 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 出 乎 意 料 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1312];
		text = "  国 际 社 会 一 致 谴 责 阿 联 共 对 科 威 特 的 入 侵 。 苏 联 与 美 国 拒 绝 承 认 侯 赛 因 的 领 土 宣 称 ， 在 对 阿 联 共 引 入 制 裁 的 同 时 ， 以 联 合 国 的 名 义 建 立 了 国 际 联 合 军 。 然 而 现 在 依 然 难 说 科 威 特 这 个 弹 丸 小 国 的 最 终 命 运 ， 不 知 能 不 能 扛 得 住 阿 联 共 的 百 万 大 军 。";
		a.data[143] += 3;
		a.ingamewars[28] = new War().Name(" 阿 联 共 入 侵 科 威 特 ").Attacker("阿 联 共").Defender("科 威 特")
			.AttackerInfluence(950)
			.DefenderInfluence(50)
			.TickTime(25)
			.SovietSupportDefender.AmericanSupportDefender.CreateWar;
	}
}
