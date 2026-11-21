using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event634 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "Belice\u00a0de\u00a0Guatemala";
		text = "伯 利 兹 ， 或 称 英 属 洪 都 拉 斯 ， 这 片 中 美 洲 人 口 最 稀 少 的 土 地 ， 本 就 是 玛 雅 乃 至 危 地 马 拉 神 圣 而 不 可 分 割 的 一 部 分 。 十 七 世 纪 ， 英 国 无 视 西 班 牙 的 领 土 要 求 侵 吞 蚕 食 了 这 一 地 区 ， 而 中 美 洲 联 邦 解 体 后 由 英 国 所 扶 持 的 危 地 马 拉 “ 独 立 之 父 ” 则 在 1 8 5 9 年 与 英 国 签 订 了 条 约 ， 正 式 将 伯 利 兹 地 区 的 主 权 所 出 卖 ， 使 英 国 彻 底 占 领 了 这 片 地 区 。 尽 管 伯 利 兹 已 经 于 1 9 8 1 年 独 立 ， 但 英 国 还 是 在 该 国 保 留 了 一 支 一 千 五 百 人 的 部 队 。||而 在 危 地 马 拉 革 命 胜 利 后 的 今 天 ， 也 是 时 候 把 目 光 放 到 这 片 曾 被 帝 国 主 义 所 窃 取 、 只 有 十 余 万 人 的 土 地 ， 终 结 帝 国 主 义 所 铸 造 的 裂 痕 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = "游 子 该 归 乡 了 。";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "Belice\u00a0de\u00a0Guatemala";
		if (result_num == 0)
		{
			if (a.allcountries[92].Gosstroy == 1)
			{
				text = "危 地 马 拉 与 英 国 双 方 都 向 伯 利 兹 施 加 了 压 力 ， 很 快 ， 伯 利 兹 就 陷 入 了 物 资 短 缺 、 经 济 崩 溃 。 U R N G 的 伯 利 兹 部 分 和 中 美 洲 工 人 革 命 党 伯 利 兹 支 部 也 趁 机 鼓 动 罢 工 和 游 行 ， 而 政 府 调 集 宪 兵 镇 压 示 威 的 举 措 反 而 成 了 加 速 自 己 倒 台 的 催 化 剂 。 在 种 种 内 外 压 力 的 逼 迫 下 ， 伯 利 兹 总 理 宣 布 辞 职 ， 共 产 主 义 者 夺 取 了 伯 利 兹 的 政 权 。 随 后 ， 伯 利 兹 宣 布 以 自 治 形 式 加 入 社 会 主 义 危 地 马 拉 。 很 快 当 地 便 开 展 了 轰 轰 烈 烈 的 社 会 主 义 改 造 。 外 国 公 司 与 银 行 被 收 归 国 有 ， 原 住 民 权 益 得 到 保 障 ， 链 接 该 地 区 的 铁 路 与 公 路 网 也 开 始 建 设 ， 尽 管 使 用 该 语 言 的 人 口 微 乎 其 微 ， 但 英 语 与 伯 利 兹 克 里 奥 尔 语 却 也 被 列 为 合 法 语 言 。";
				a.allcountries[149].level_of_unstab += 50;
				a.allcountries[149].parts[0] = true;
				a.influencePRC += 5;
				a.empires[0].power -= 5;
				a.empires[0].relations -= 50;
			}
			else
			{
				text = "新 生 的 危 地 马 拉 革 命 军 迅 速 跨 过 两 国 边 境 ， 一 场 战 争 打 响 了 。";
				a.allcountries[149].parts[2] = true;
				a.empires[0].relations -= 50;
				a.ingamewars[65] = new War().Name("危 地 马 拉 统 一 战 争").Attacker("危 地 马 拉").Defender("伯 利 兹")
					.AttackerInfluence(600)
					.DefenderInfluence(400)
					.TickTime(24)
					.SovietSupportAttacker.CreateWar;
			}
		}
	}
}
