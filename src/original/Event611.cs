using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event611 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "沙 巴 战 争 ， 又 一 次 ？";
		if (!a.allcountries[163].parts[0])
		{
			text = "在 第 一 次 沙 巴 战 争 惨 痛 的 失 败 后 ，FNLC 的 成 员 痛 定 思 痛 ， 决 心 攻 占 科 卢 维 齐 这 一 重 地 作 为 前 进 的 跳 板 。 在 古 巴 的 支 持 下 ，6500 名FNLC 士 兵 又 一 次 越 过 边 界 突 袭 该 国 。 起 义 军 已 经 攻 下 了 边 境 的 数 个 军 火 库 和 哨 站 ， 似 乎 这 次 他 们 的 赢 面 很 大 ？";
		}
		else
		{
			text = "在 刚 果 民 族 解 放 阵 线 站 稳 了 脚 跟 后 ， 加 丹 加 人 民 共 和 国 一 直 尽 力 渗 透 着 扎 伊 尔 政 权 。 而 今 天 ， 塔 纳 尔 · 姆 奔 巴 宣 布 发 起 又 一 次 冲 锋 ， 他 们 将 会 彻 底 击 溃 孱 弱 的 扎 伊 尔 政 权 。 很 明 显 ， 一 边 是 士 气 高 昂 的 解 放 战 士 ， 另 一 边 是 依 赖 巫 医 ， 金 钱 和 外 国 人 的 国 防 军 ， 胜 利 的 天 平 似 乎 已 经 开 始 倾 斜 了 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 支 持 扎 伊 尔 人 民 反 抗 苏 联 社 会 帝 国 主 义 的 斗 争";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "沙 巴 战 争 ， 又 一 次 ？";
		a.allcountries[117].parts[0] = true;
		if (result_num == 0)
		{
			if (!a.allcountries[163].parts[0])
			{
				text = "我 们 像 过 去 的 那 样 呼 吁 各 方 冷 静 下 来 并 停 火 ， 但 谁 会 在 乎 我 们 的 话 呢 ？ 古 巴 人 仍 然 在 一 波 又 一 波 的 开 往 加 丹 加 地 区 。";
				a.ingamewars[61] = new War().Name("第 二 次 沙 巴 战 争").Attacker("扎 伊 尔").Defender(" 刚 果 民 族 解 放 阵 线")
					.AttackerInfluence(700)
					.DefenderInfluence(300)
					.TickTime(9)
					.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
			}
			else
			{
				text = "在 古 巴 人 的 大 力 支 持 下 ， 如 潮 水 般 的 刚 果 民 族 解 放 阵 线 士 兵 开 始 冲 向 北 方 ， 他 们 的 主 要 目 标 是 拿 下 金 沙 萨 和 基 桑 加 尼 。 当 然 ， 具 体 问 题 仍 然 需 要 具 体 分 析 。 如 果 他 们 有 这 般 武 勇 ， 为 什 么 没 有 趁 蒙 博 托 政 权 不 稳 之 时 就 推 翻 他 呢 ？";
				a.ingamewars[61] = new War().Name("第 二 次 沙 巴 战 争").Attacker("扎 伊 尔").Defender(" 刚 果 民 族 解 放 阵 线")
					.AttackerInfluence(500)
					.DefenderInfluence(500)
					.TickTime(9)
					.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
			}
		}
	}
}
