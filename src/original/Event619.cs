using EventsForDLC;
using UnityEngine;

public class Event619 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 加 蓬 之 变";
		text = "自1968 年 奥 马 尔 · 邦 戈 成 为 加 蓬 总 统 以 来 ， 加 蓬 的 经 济 逐 渐 开 始 衰 落 ， 伴 随 着 经 济 困 难 而 来 的 是 反 对 派 势 力 的 崛 起 ， 但 是 在 亲 法 政 府 的 镇 压 下 ， 反 对 派 势 力 始 终 未 能 掀 起 风 浪 。 在 邻 国 喀 麦 隆 和 刚 果 （ 布 ） 的 封 锁 下 ， 加 蓬 经 济 遭 受 打 击 ， 由 我 们 支 持 的 数 个 左 翼 团 体 和 政 党 （ 包 括 加 蓬 民 族 团 结 党 ， 流 亡 学 生 活 动 家 组 成 的 亲 中 左 翼 团 体 加 蓬 学 生 总 协 会 ） 组 成 的 加 蓬 劳 动 党 影 响 力 逐 渐 增 加 ， 被 加 蓬 劳 动 党 组 织 起 来 的 工 人 和 学 生 开 始 上 街 抗 议 邦 戈 的 统 治 并 要 求 下 台 ， 现 在 的 加 蓬 到 了 革 命 之 日 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 让 我 们 看 看 事 情 的 发 展";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 加 蓬 之 变";
		if (result_num == 0)
		{
			text = "在 首 都 利 伯 维 尔 的 一 次 工 人 和 学 生 游 行 中 ， 一 名 军 人 不 幸 走 火 ， 现 场 打 死 数 十 名 游 行 群 众 ， 消 息 传 开 后 ， 全 国 性 的 反 对 邦 戈 运 动 开 始 了 ， 在 我 们 和 喀 麦 隆 ， 刚 果 （ 布 ） 等 国 的 施 压 下 邦 戈 被 迫 下 台 流 亡 海 外 。 加 蓬 劳 动 党 顺 利 夺 取 政 权 ， 并 成 立 加 蓬 人 民 民 主 共 和 国 ， 新 政 府 宣 布 将 会 对 外 资 企 业 和 大 型 私 有 企 业 进 行 国 有 化 ， 与 喀 麦 隆 ， 刚 果 （ 布 ） 和 以 中 国 为 首 的 革 命 阵 营 交 好 并 以 中 国 为 他 们 社 会 主 义 建 设 的 目 标 。";
			a.allcountries[116].Gosstroy = 1;
			a.allcountries[116].SubGosstroy = 1;
			a.allcountries[116].LeaveAlliances();
			a.allcountries[116].Torg = true;
			a.allcountries[116].proprc = true;
			a.empires[0].relations -= 150;
		}
	}
}
