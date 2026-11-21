using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event612 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "赤 道 战 鼓";
		text = "一 天 又 一 天 ， 游 击 队 在 刚 果 东 方 的 密 林 里 训 练 ， 一 天 又 一 天 ， 无 数 的 好 男 儿 为 崇 高 的 理 想 献 身 ， 一 天 又 一 天 ， 更 多 的 “ 墨 路 波 ” 们 加 入 游 击 队 ， 为 自 由 的 刚 果 献 上 一 切 。 就 在 今 日 ，" + ((a.resultOfEvents[610] == 2) ? " 刚 果 人 民 革 命 组 织 第 一 书 记 安 德 烈 · 基 萨 斯" : " 刚 果 人 民 革 命 党 第 一 书 记 洛 朗 - 德 雷 西 · 卡 比 拉") + " 在 多 方 支 持 下 正 式 宣 布 发 动 革 命 战 争 ， 目 标 直 指 扎 伊 尔 首 都 金 沙 萨 。 现 在 ， 是 时 候 让 熊 熊 烈 火 吞 噬 那 位 “ 从 烈 火 中 走 出 明 路 ” 的 扎 伊 尔 国 父 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 太 阳 从 东 方 升 起 ， 为 了 刚 果 ， 也 是 为 了 人 民 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "赤 道 战 鼓";
		a.allcountries[117].parts[1] = true;
		if (result_num == 0)
		{
			text = "在 卢 旺 达 ， 乌 干 达 ， 刚 果 人 民 共 和 国 （ 布 拉 柴 维 尔 ） 等 国 的 支 持 下 ， 各 路 革 命 人 马 将 自 己 所 掌 握 的 武 装 力 量 与 受 革 命 思 想 影 响 的 军 人 改 编 为 由 该 组 织 中 央 统 一 指 挥 的 刚 果 民 族 解 放 军 ， 东 非 的 社 会 主 义 国 家 将 为 他 们 提 供 他 们 所 需 要 的 一 切 支 持 。||蒙 博 托 陷 入 了 极 度 的 惊 慌 中 ， 除 了 呼 吁 国 际 社 会 的 调 停 并 再 次 召 唤 了 联 合 国 军 下 场 外 ， 他 本 人 也 做 好 了 战 斗 的 准 备 ， 大 量 的 战 车 也 被 调 往 东 部 平 叛 ， 刚 果 人 自 己 的 战 争 还 是 爆 发 了 。";
			a.allcountries[117].Torg = false;
			a.empires[1].relations -= 150;
			a.empires[0].relations -= 150;
			a.ingamewars[62] = new War().Name(" 刚 果 革 命").Attacker(" 扎 伊 尔").Defender(" 刚 果 革 命 军")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportAttacker.CreateWar;
		}
	}
}
