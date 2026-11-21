using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event596 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 瓦 加 拉 大 屠 杀 ";
		text = " 1 9 8 4 年 2 月 ， 肯 尼 亚 东 北 省 的 瓦 吉 尔 镇 爆 发 了 一 次 部 族 冲 突 ， 肯 尼 亚 国 防 军 奉 命 制 止 冲 突 ， 随 后 将 五 千 余 名 当 地 人 赶 到 瓦 加 拉 机 场 的 跑 道 上 ， 一 周 之 内 断 绝 了 他 们 的 水 源 和 粮 食 并 开 枪 随 意 射 杀 。 索 马 里 当 局 对 此 十 分 不 满 ， 并 要 求 肯 尼 亚 政 府 停 止 种 族 屠 杀 ， 否 则 将 会 推 翻 现 政 权 并 进 行 占 领 。 " + ((a.allcountries[42].SubGosstroy == 10) ? " 我 们 是 否 可 以 借 此 机 会 彻 底 打 击 肯 尼 亚 的 种 族 灭 绝 行 为 ， 或 者 对 拥 有 着 大 索 马 里 美 梦 的 索 马 里 进 行 一 次 打 击 ？ " : null);
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (a.allcountries[42].SubGosstroy == 10)
		{
			kolvo_variant = 3;
			if (a.data[56] <= 2 && (a.allcountries[42].proprc || (a.allcountries[42].prosov && a.allcountries[1].isSEV)))
			{
				button_text[0] = " 为 索 马 里 盟 友 提 供 顾 问";
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = " 他 们 不 愿 意 听 我 们 的 话";
			}
			if (a.data[56] >= 2 && (!a.allcountries[42].proprc || (a.allcountries[42].prosov && !a.allcountries[1].isSEV)))
			{
				button_text[1] = " 帮 助 肯 尼 亚 保 卫 领 土 完 整";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 支 持 他 ？ 这 是 给 我 们 的 敌 人 递 子 弹 ！";
			}
			button_text[2] = " 这 只 是 普 通 的 非 洲 国 家 之 间 的 争 端 罢 了";
		}
		else
		{
			kolvo_variant = 3;
			Object.Destroy(button[0]);
			button_text[0] = "";
			Object.Destroy(button[1]);
			button_text[1] = "";
			button_text[2] = " 这 只 是 普 通 的 非 洲 国 家 之 间 的 争 端 罢 了";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 瓦 加 拉 大 屠 杀 ";
		if (result_num == 0)
		{
			text = " 在 肯 尼 亚 未 作 出 回 应 之 前 ， 新 华 社 发 表 社 论 支 持 索 马 里 人 民 反 抗 肯 尼 亚 反 动 政 权 并 回 到 索 马 里 的 斗 争 ， 东 北 省 人 民 进 步 党 这 个 曾 经 试 图 让 东 北 省 重 新 加 入 索 马 里 的 组 织 重 组 了 起 来 并 在 我 们 特 工 的 协 助 下 在 东 北 省 进 行 袭 扰 战 ， 与 此 同 时 ， 索 马 里 也 宣 布 对 肯 尼 亚 再 次 发 动 战 争 并 试 图 收 复 东 北 省 ， 大 量 来 自 东 方 的 货 轮 正 在 摩 加 迪 沙 港 卸 下 “ 拖 拉 机 ” 等 “ 农 业 设 备 ” ， " + (a.allcountries[42].prosov ? " 古 巴 雇 佣 兵 又 一 次 踏 上 了 东 非 这 片 土 地 ，" : null) + " 而 来 自 英 国 军 火 和 西 方 的 雇 佣 兵 开 始 在 肯 尼 亚 出 现 。 索 马 里 和 肯 尼 亚 又 一 次 爆 发 了 战 争 。";
			if (a.allcountries[42].prosov)
			{
				a.ingamewars[50] = new War().Name("索 马 里 - 肯 尼 亚 战 争").Attacker("索 马 里").Defender("肯 尼 亚")
					.AttackerInfluence(750)
					.DefenderInfluence(250)
					.TickTime(24)
					.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			}
			else
			{
				a.ingamewars[50] = new War().Name("索 马 里 - 肯 尼 亚 战 争").Attacker("索 马 里").Defender("肯 尼 亚")
					.AttackerInfluence(700)
					.DefenderInfluence(300)
					.TickTime(24)
					.AmericanSupportDefender.CreateWar;
			}
			a.allcountries[119].parts[0] = true;
			a.data[9] -= 50;
			a.data[22] -= 80;
		}
		if (result_num == 1)
		{
			text = " 在 我 们 的 大 力 支 持 下 ， 肯 尼 亚 宣 布 拒 绝 接 受 索 马 里 的 条 件 ， 并 提 前 在 边 境 地 区 做 好 准 备 以 痛 击 来 侵 之 敌 。 大 量 来 自 东 方 的 货 轮 正 在 蒙 巴 萨 港 卸 下 “ 拖 拉 机 ” 等 “ 农 业 设 备 ” ， 来 自 英 国 军 火 和 西 方 的 雇 佣 兵 开 始 在 肯 尼 亚 出 现 ，" + (a.allcountries[42].prosov ? " 索 马 里 开 始 对 肯 尼 亚 宣 战 ， 古 巴 的 雇 佣 兵 和 苏 联 的 顾 问 又 一 次 踏 上 了 东 非 的 土 地 。" : ((!a.allcountries[42].proprc) ? "索 马 里 在 内 部 混 乱 之 下 仓 促 宣 战 。" : null)) + " 索 马 里 和 肯 尼 亚 又 一 次 爆 发 了 战 争 。 ";
			if (a.allcountries[42].prosov)
			{
				a.ingamewars[50] = new War().Name("索 马 里 - 肯 尼 亚 战 争").Attacker("索 马 里").Defender("肯 尼 亚")
					.AttackerInfluence(550)
					.DefenderInfluence(450)
					.TickTime(24)
					.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			}
			else
			{
				a.ingamewars[50] = new War().Name("索 马 里 - 肯 尼 亚 战 争").Attacker("索 马 里").Defender("肯 尼 亚")
					.AttackerInfluence(450)
					.DefenderInfluence(550)
					.TickTime(24)
					.AmericanSupportDefender.CreateWar;
			}
			a.allcountries[119].parts[0] = true;
			a.data[9] -= 50;
			a.data[22] -= 80;
		}
		if (result_num == 2)
		{
			text = " 肯 尼 亚 被 迫 答 应 了 要 求 ， 释 放 了 被 押 的 索 马 里 人 。 即 将 到 来 的 索 肯 大 战 也 随 之 消 逝 。 ";
		}
	}
}
