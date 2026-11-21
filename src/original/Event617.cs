using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event617 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 终 得 复 仇";
		text = " 在 喀 麦 隆 独 立 之 前 ， 喀 麦 隆 人 民 联 盟 便 开 始 为 反 抗 法 国 而 进 行 武 装 斗 争 ， 尽 管 武 装 斗 争 持 续 到 1 9 6 4 年 被 法 国 和 喀 麦 隆 联 合 镇 压 而 结 束 ， 但 是 喀 麦 隆 人 民 联 盟 并 未 随 着 武 装 斗 争 的 失 败 而 被 解 散 。 在 我 们 和 我 们 非 洲 盟 友 的 帮 助 下 ， 喀 麦 隆 人 民 联 盟 得 以 重 建 喀 麦 隆 民 族 解 放 军 ， 并 逐 渐 扩 大 了 自 己 的 根 据 地 。 现 在 ， 喀 麦 隆 民 族 解 放 军 已 经 大 到 足 够 发 动 起 义 了 ， 与 此 同 时 ， 喀 麦 隆 军 队 也 在 进 行 反 游 击 作 战 ， 正 试 图 削 弱 喀 麦 隆 民 族 解 放 军 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 让 我 们 看 看 事 情 的 发 展";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 终 得 复 仇";
		if (result_num == 0)
		{
			text = "在 喀 麦 隆 军 队 日 益 加 剧 的 围 剿 下 ， 喀 麦 隆 人 民 联 盟 并 未 选 择 坐 以 待 毙 ， 而 是 主 动 出 击 ， 全 国 范 围 内 的 起 义 出 现 ， 喀 麦 隆 宣 布 进 入 紧 急 状 态 " + ((a.allcountries[21].Gosstroy == 3) ? "并 呼 叫 法 军 前 来 增 援" : null) + " 。 喀 麦 隆 内 战 就 此 打 响 。";
			a.allcountries[66].parts[0] = true;
			a.empires[0].relations -= 150;
			a.ingamewars[63] = new War().Name(" 喀 麦 隆 内 战").Attacker(" 喀 麦 隆").Defender(" 喀 麦 隆 民 族 解 放 军")
				.AttackerInfluence(600)
				.DefenderInfluence(400)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
	}
}
