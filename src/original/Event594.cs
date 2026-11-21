using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event594 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 加 里 萨 大 屠 杀";
		text = " 在 索 马 里 人 聚 居 区 被 欧 美 列 强 和 埃 塞 俄 比 亚 帝 国 瓜 分 之 后 ， 以 索 马 里 人 为 主 的 东 北 省 便 纳 入 英 属 肯 尼 亚 领 土 中 ， 在 索 马 里 独 立 之 后 ， 北 部 边 界 区 便 强 烈 要 求 分 离 出 来 加 入 索 马 里 。 自 肯 尼 亚 独 立 尤 其 是 1 9 6 7 年 盗 匪 战 争 （ 肯 尼 亚 称 索 马 里 分 离 势 力 为 盗 匪 ） 结 束 以 来 ， 肯 尼 亚 对 于 东 北 省 予 以 打 压 ， 甚 至 不 惜 为 东 北 省 单 独 立 法 来 加 强 管 控 。 1 9 8 0 年 1 1 月 ， 在 一 名 土 匪 的 袭 击 下 ， 有 六 名 政 府 官 员 死 亡 ， 肯 尼 亚 军 队 随 即 在 东 北 省 加 里 萨 镇 进 行 报 复 性 行 为 ， 烧 毁 庄 园 ， 强 奸 ， 放 火 杀 人 ， 把 当 地 镇 民 赶 到 幼 儿 园 作 为 小 型 集 中 营 关 押 ， 放 走 除 了 索 马 里 人 以 外 的 其 他 人 并 断 绝 他 们 的 水 源 和 食 物 。 至 少 有 三 千 余 人 死 于 这 场 屠 杀 。||索 马 里 政 府 对 此 十 分 不 满 ， 并 要 求 肯 尼 亚 政 府 停 止 种 族 屠 杀 ， 否 则 将 会 推 翻 现 政 权 并 进 行 占 领 。" + ((a.allcountries[42].SubGosstroy == 10) ? " 主 席 同 志 ， 我 们 或 许 可 以 借 此 机 会 帮 助 索 马 里 人 完 成 大 索 马 里 之 梦 ， 或 者 帮 肯 尼 亚 一 忙 ， 解 决 掉 他 们 的 心 头 之 患 ？ 总 之 选 择 权 在 你 。" : null);
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
		name = " 加 里 萨 大 屠 杀";
		if (result_num == 0)
		{
			text = " 在 肯 尼 亚 未 作 出 回 应 之 前 ， 新 华 社 发 表 社 论 支 持 索 马 里 人 民 反 抗 肯 尼 亚 反 动 政 权 并 回 到 索 马 里 的 斗 争 ， 北 部 省 人 民 进 步 党 这 个 曾 经 试 图 让 北 部 省 重 新 加 入 索 马 里 的 组 织 重 组 了 起 来 并 在 我 们 特 工 的 协 助 下 在 东 北 省 进 行 袭 扰 战 ， 与 此 同 时 ， 索 马 里 也 宣 布 对 肯 尼 亚 再 次 发 动 战 争 并 试 图 收 复 东 北 省 ， 大 量 来 自 东 方 的 货 轮 正 在 摩 加 迪 沙 港 卸 下 “ 拖 拉 机 ” 等 “ 农 业 设 备 ”， " + (a.allcountries[42].prosov ? " 古 巴 雇 佣 兵 又 一 次 踏 上 了 东 非 这 片 土 地 ，" : null) + " 而 来 自 英 国 军 火 和 西 方 的 雇 佣 兵 开 始 在 肯 尼 亚 出 现 。 索 马 里 和 肯 尼 亚 又 一 次 爆 发 了 战 争 。";
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
