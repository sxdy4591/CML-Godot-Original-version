using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event604 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 十 八 岁 的 我 只 想 活 下 去";
		text = " 今 天 ， 素 有 “ 行 走 大 洋 国 ” 之 称 的 南 非 人 民 邦 宣 布 将 在 非 洲 南 部 地 区 发 起 “ 德 拉 雷 ” 维 和 特 别 军 事 行 动 。 根 据 南 非 人 民 邦 发 言 人 的 说 法 ， 该 行 动 将 “ 彻 底 解 决 侵 犯 南 非 领 土 主 权 ” 的 敌 对 行 动 。 全 副 武 装 的 南 非 部 队 已 开 始 向 其 边 界 邻 国 进 军 ， 并 将 炮 口 瞄 准 安 哥 拉 、 博 茨 瓦 纳 " + ((a.allcountries[127].puppetOf < 0) ? "、 津 巴 布 韦" : null) + "和 莫 桑 比 克 境 内 的 反 对 派 。 上 述 非 洲 国 家 在 战 争 初 便 惨 遭 化 学 武 器 和 白 磷 弹 打 击 ， 沦 陷 区 内 尸 横 遍 野 。 国 际 社 会 对 南 非 部 队 的 暴 行 空 前 震 惊 ， 并 纷 纷 谴 责 南 非 纵 容 新 纳 粹 主 义 ， 重 走 殖 民 主 义 老 路 。 美 苏 两 国 已 开 始 向 非 洲 南 部 各 国 派 发 军 事 援 助 以 抵 御 布 尔 人 怒 火 ， 而 坦 桑 尼 亚 等 持 泛 非 主 义 立 场 的 政 权 更 是 号 召 组 织 非 洲 纵 队 全 面 援 助 抗 击 人 民 邦 的 战 事 。|| 究 竟 谁 能 够 胜 利 ？ “ 文 明 ” 还 是 良 知 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 天 哪 ， 天 — —";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 十 八 岁 的 我 只 想 活 下 去";
		if (result_num == 0)
		{
			text = " 决 定 南 部 非 洲 的 命 运 的 战 争 已 然 打 响 … …";
			a.ingamewars[56] = new War().Name("南 非 - 安 哥 拉 之 战").Attacker(" 安 哥 拉").Defender(" 南 非")
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportAttacker.CreateWar;
			a.allcountries[131].parts[2] = true;
			a.ingamewars[57] = new War().Name("南 非 - 博 茨 瓦 纳 之 战").Attacker(" 博 茨 瓦 纳").Defender(" 南 非")
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportAttacker.CreateWar;
			a.allcountries[131].parts[3] = true;
			a.ingamewars[58] = new War().Name("南 非 - 莫 桑 比 克 之 战").Attacker(" 莫 桑 比 克").Defender(" 南 非")
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportAttacker.CreateWar;
			a.allcountries[131].parts[4] = true;
			a.ingamewars[59] = new War().Name("南 非 - 津 巴 布 韦 之 战").Attacker(" 津 巴 布 韦").Defender(" 南 非")
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportAttacker.CreateWar;
			a.allcountries[127].parts[0] = true;
		}
	}
}
