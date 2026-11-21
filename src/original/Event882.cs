using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event882 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 罗 德 斯 与 伊 安 的 土 地";
		text = " 最 终 ， 独 立 的 津 巴 布 韦 最 担 心 的 事 情 还 是 发 生 了 。 随 着 南 非 状 态 在 多 方 驰 援 之 下 不 断 的 稳 定 下 来 了 ， 越 来 越 多 的 部 队 开 始 越 境 袭 扰 津 巴 布 韦 的 定 居 点 ， 在 放 一 把 火 或 掠 夺 一 番 后 便 班 师 回 朝 。 如 果 仅 仅 是 这 样 ， 津 巴 布 韦 的 武 装 力 量 尚 能 反 制 ， 那 么 当 南 非 大 军 压 境 ， 他 们 还 能 做 什 么 呢 ？ 而 这 样 的 噩 梦 已 经 成 真 了 。 就 在 最 近 ， 南 非 外 交 部 对 外 宣 布 发 起 “ 石 英 ” 行 动 ， 名 义 上 是 打 击 在 藏 身 于 津 巴 布 韦 南 部 的 黑 人 游 击 队 ， 事 实 上 就 是 针 对 津 巴 布 韦 现 政 权 的 军 事 行 动 。 许 多 车 上 同 时 挂 着 绿 白 旗 和 橙 白 蓝 的 南 非 国 旗 ， 许 多 士 兵 喊 着 “ 为 1 9 8 0 复 仇 ” 之 类 的 口 号 ， 冲 着 前 往 布 拉 瓦 约 和 哈 拉 雷 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 情 况 会 好 下 来 的 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 罗 德 斯 与 伊 安 的 土 地";
		if (result_num == 0)
		{
			text = " 赞 比 亚 和 坦 桑 尼 亚 惊 恐 的 看 着 津 巴 布 韦 的 现 状 ， 并 呼 吁 联 合 国 介 入 。 但 在 如 此 多 的 “ 神 秘 人 ” 的 帮 助 下 ， 谁 还 能 阻 挡 伟 大 的 白 人 酋 长 们 呢 ？";
			a.allcountries[127].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[126].level_of_unstab -= 200;
			int num = 0;
			if (a.resultOfEvents[609] == 0)
			{
				num = 50;
			}
			a.ingamewars[44] = new War().Name(" 南 非 入 侵 津 巴 布 韦").Attacker(" 南 非").Defender(" 津 巴 布 韦")
				.AttackerInfluence(700 - num)
				.DefenderInfluence(300 + num)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
	}
}
