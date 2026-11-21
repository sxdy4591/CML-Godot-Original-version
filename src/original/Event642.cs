using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event642 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "红 星 照 我 去 战 斗";
		text = "华 国 锋 同 志 ， 是 时 候 了 ， 当 你 做 出 这 个 决 定 的 时 候 就 表 明 您 已 经 下 定 了 决 心 。 总 参 谋 部 提 出 了 诸 多 计 划 ， 其 中 都 旨 在 各 个 阵 线 上 或 多 或 少 的 挫 败 我 们 的 敌 人 。 这 是 其 中 的 一 些 计 划 ， 还 请 您 过 目 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 6;
		if (a.allcountries[11].puppetOf != 1)
		{
			button_text[0] = "中 南 半 岛 是 迫 在 眉 睫 的 问 题";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "我 们 用 四 百 亿 买 到 了 值 得 的 东 西";
		}
		if (a.allcountries[10].puppetOf != 1)
		{
			button_text[1] = "跨 过 鸭 绿 江 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = "我 们 不 再 有 关 于 天 池 的 问 题 了";
		}
		if (a.allcountries[47].puppetOf != 1 && a.allcountries[50].puppetOf != 1 && a.allcountries[134].puppetOf != 1 && a.allcountries[34].proprc && a.allcountries[34].okb)
		{
			button_text[2] = "下 南 洋 ， 再 一 次";
		}
		else if (!a.allcountries[34].proprc || !a.allcountries[34].okb)
		{
			Object.Destroy(button[2]);
			button_text[2] = "我 们 无 能 为 力 ";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = "南 海 已 经 是 我 们 的 内 海 了";
		}
		if (a.allcountries[19].puppetOf != 1 && a.allcountries[31].proprc)
		{
			button_text[3] = "翻 过 喜 马 拉 雅 山";
		}
		else if (!a.allcountries[31].proprc)
		{
			Object.Destroy(button[3]);
			button_text[3] = "1962只 是 撞 大 运 了 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = "南 亚 是 我 们 的 老 朋 友";
		}
		if (a.allcountries[19].puppetOf == 1 && a.allcountries[47].puppetOf == 1 && a.allcountries[10].puppetOf == 1 && a.allcountries[11].puppetOf == 1 && !a.allcountries[1].parts[11] && a.data[22] >= 5000)
		{
			button_text[4] = "针 对 社 会 帝 国 主 义 的 最 后 一 战";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = "卧 薪 尝 胆 … … 苏 联 会 为 自 己 的 轻 率 付 出 代 价 ！";
		}
		button_text[5] = "我 只 是 不 小 心 按 到 了 传 呼 铃 而 已 ， 给 我 杯 茶 吧 。";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "红 星 照 我 去 战 斗";
		if (result_num == 0)
		{
			text = "华 国 锋 同 志 ， 如 您 所 料 ， 越 南 黎 笋 修 正 主 义 集 团 贼 心 不 死 ， 胃 口 堪 比 沙 皇 。 他 们 在 将 老 挝 、 柬 埔 寨 纳 入 其 势 力 范 围 ， 拼 凑 其 所 谓 “ 印 度 支 那 联 邦 ” 后 便 得 陇 望 蜀 ， 抛 出 了 组 建 东 南 亚 版 苏 联 的 狼 子 野 心 ，" + (a.IsSocialism(yes: true, 34) ? "而 在 不 久 前 背 叛 我 们 的 白 眼 狼 泰 国 共 产 党 也 深 受 与 越 南 的 边 境 冲 突 之 扰 ，" : "泰 国 政 府 也 深 受 与 越 南 的 边 境 冲 突 之 扰 ；") + (a.IsSocialism(yes: true, 33) ? "缅 共 在 我 们 的 支 持 下 获 得 了 缅 甸 的 控 制 权 ， 但 很 快 他 们 也 和 泰 共 一 样 变 成 了 白 眼 狼 。" : "另 一 方 面 ， 缅 甸 军 政 府 仍 然 在 其 东 北 部 山 区 与 我 们 支 持 的 缅 共 以 及 民 地 武 进 行 作 战 。") + " 我 们 是 时 候 给 他 们 屁 股 上 狠 狠 来 一 脚 了 ！|我 会 给 军 区 首 长 们 传 达 您 的 指 令 ， 各 个 军 工 厂 已 经 开 始 全 速 运 转 ， 各 地 民 兵 ， 入 伍 和 复 员 工 作 也 在 有 条 不 紊 的 进 行 中 。 但 是 我 还 是 想 提 醒 您 ， 由 于 先 军 政 策 及 民 族 主 义 宣 传 的 影 响 ， 我 们 的 战 争 机 器 一 旦 开 动 起 来 ， 就 很 难 再 刹 得 住 车 。||<color=red>我 们 再 见 了 亲 爱 的 妈 妈 ， 请 你 吻 别 您 的 儿 子 吧 … …</color>";
			a.ingamewars[71] = new War().Name("东 南 亚 之 征").Attacker("中 华 人 民 共 和 国").Defender("东 南 亚 诸 国")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.TickTime(12)
				.SovietSupportDefender.AmericanSupportDefender.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] += 150;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.data[22] -= 200;
			a.data[34] += 2;
			a.empires[1].relations -= 500;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 500;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
		if (result_num == 1)
		{
			text = "华 国 锋 同 志 ， 现 在 让 我 们 将 目 光 移 到 我 国 东 部 ， 放 向 我 们 的 “ 盟 友 ” — — 朝 鲜 。 自 从 金 日 成 清 洗 掉 国 内 的 亲 苏 派 、 亲 华 派 ， 独 掌 大 权 之 后 ， 朝 鲜 国 内 对 他 的 个 人 崇 拜 也 愈 发 高 涨 。 基 于 对 其 “ 白 头 山 天 降 血 脉 ” 的 建 构 ， 朝 鲜 不 止 一 次 通 过 或 官 方 或 私 下 的 途 径 向 我 国 索 取 整 个 长 白 山 的 控 制 权 ， 并 以 退 出 同 盟 相 要 挟 。 此 举 堪 称 忘 恩 负 义 、 贪 得 无 厌 ：1962 年 ， 为 了 中 朝 两 国 友 好 ， 伟 大 领 袖 毛 泽 东 同 志 就 已 经 将 半 个 天 池 让 与 朝 鲜 。1964 年 ， “ 刘 邓 叶 许 反 革 命 集 团 ” 的 大 头 目 ， 叛 徒 邓 小 平 跟 随 代 表 团 赶 赴 朝 鲜 ， 他 与 朝 鲜 阴 谋 串 联 ， 泄 露 我 方 试 图 收 回 整 个 天 池 的 战 略 意 图 ， 最 终 导 致 此 事 不 了 了 之 。 看 来 朝 鲜 已 经 忘 记 了 是 谁 在 联 合 国 军 的 威 胁 下 将 其 拖 出 火 海 了 。 小 孩 子 不 听 话 ， 是 时 候 让 他 们 得 到 些 许 教 训 了 ！|我 会 给 军 区 首 长 们 传 达 您 的 指 令 ， 各 个 军 工 厂 已 经 开 始 全 速 运 转 ， 各 地 民 兵 ， 入 伍 和 复 员 工 作 也 在 有 条 不 紊 的 进 行 中 。 但 是 我 还 是 想 提 醒 您 ， 由 于 先 军 政 策 及 民 族 主 义 宣 传 的 影 响 ， 我 们 的 战 争 机 器 一 旦 开 动 起 来 ， 就 很 难 再 刹 得 住 车 。||<color=red>我 们 再 见 了 亲 爱 的 妈 妈 ， 请 你 吻 别 您 的 儿 子 吧 … …</color>";
			a.ingamewars[72] = new War().Name("中 朝 之 战").Attacker("中 华 人 民 共 和 国").Defender("朝 鲜")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.TickTime(12)
				.SovietSupportDefender.AmericanSupportDefender.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] += 150;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.data[22] -= 200;
			a.data[34] += 2;
			a.empires[1].relations -= 500;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 500;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
		if (result_num == 2)
		{
			text = "华 国 锋 同 志 ， 让 我 们 将 目 光 移 到 我 国 南 方 ， 放 向 南 洋 诸 国 。 长 期 以 来 ， 南 洋 诸 国 背 信 弃 义 ， 屡 次 侵 犯 我 们 的 利 益 ： 他 们 垄 断 海 上 贸 易 航 线 ， 对 我 国 商 船 征 收 高 额 关 税 ， 甚 至 放 任 海 盗 劫 掠 我 们 的 货 物 ， 残 害 我 们 的 同 胞 ； 他 们 还 公 然 侵 占 我 们 的 领 土 和 资 源 ， 强 占 我 们 的 岛 屿 ， 掠 夺 我 们 的 矿 产 。 这 种 赤 裸 裸 的 侵 略 行 为 ， 已 经 威 胁 到 我 们 的 国 家 主 权 和 未 来 发 展 ！|我 会 给 军 区 首 长 们 传 达 您 的 指 令 ， 各 个 军 工 厂 已 经 开 始 全 速 运 转 ， 各 地 民 兵 ， 入 伍 和 复 员 工 作 也 在 有 条 不 紊 的 进 行 中 。 但 是 我 还 是 想 提 醒 您 ， 由 于 先 军 政 策 及 民 族 主 义 宣 传 的 影 响 ， 我 们 的 战 争 机 器 一 旦 开 动 起 来 ， 就 很 难 再 刹 得 住 车 。||<color=red>我 们 再 见 了 亲 爱 的 妈 妈 ， 请 你 吻 别 您 的 儿 子 吧 … …</color>";
			a.ingamewars[73] = new War().Name("南 洋 之 征").Attacker("中 华 人 民 共 和 国").Defender("南 洋 诸 国")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.TickTime(12)
				.SovietSupportDefender.AmericanSupportDefender.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] += 150;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.data[22] -= 200;
			a.data[34] += 2;
			a.empires[1].relations -= 500;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 500;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
		if (result_num == 3)
		{
			text = "华 国 锋 同 志 ， 印 度 和 我 国 素 有 间 隙 ， 与 我 国 的 友 好 邻 邦 巴 基 斯 坦 更 是 冲 突 不 断 。 更 何 况 ， 印 度 曾 以 《 西 姆 拉 条 约 》 为 由 占 领 着 我 国 的 神 圣 领 土 藏 南 ， 这 片 富 饶 的 西 藏 江 南 ， 虽 然 我 们 已 经 夺 回 藏 南 ， 但 印 度 曾 犯 下 的 罪 行 不 容 忽 视 ！ 此 外 ， 印 度 在1975 年 吞 并 了 锡 金 ， 并 把 持 着 不 丹 的 外 交 。 我 想 要 提 醒 您 ， 这 两 地 与 藏 区 素 有 联 系 ， 甚 至 可 以 说 是 西 藏 的 分 支 。 印 度 虽 然 现 在 势 力 不 强 ， 但 仍 有 成 为 一 个 强 国 的 潜 质 ， 这 对 于 我 们 实 现 伟 大 复 兴 的 计 划 是 一 个 不 小 的 隐 患 。 印 度 素 有 散 装 之 称 ， 在 英 国 到 来 之 前 甚 至 没 有 一 个 统 一 国 家 的 概 念 ， 所 以 我 们 的 计 划 是 彻 底 废 掉 印 度 ！|我 会 给 军 区 首 长 们 传 达 您 的 指 令 ， 各 个 军 工 厂 已 经 开 始 全 速 运 转 ， 各 地 民 兵 ， 入 伍 和 复 员 工 作 也 在 有 条 不 紊 的 进 行 中 。 但 是 我 还 是 想 提 醒 您 ， 由 于 先 军 政 策 及 民 族 主 义 宣 传 的 影 响 ， 我 们 的 战 争 机 器 一 旦 开 动 起 来 ， 就 很 难 再 刹 得 住 车 。||<color=red>我 们 再 见 了 亲 爱 的 妈 妈 ， 请 你 吻 别 您 的 儿 子 吧 … …</color>";
			a.ingamewars[74] = new War().Name("南 亚 之 征").Attacker("中 华 人 民 共 和 国").Defender("印 度 及 其 卫 星 国")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.TickTime(12)
				.SovietSupportDefender.AmericanSupportDefender.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] += 150;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.data[22] -= 200;
			a.data[34] += 2;
			a.empires[1].relations -= 500;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 500;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
		if (result_num == 4)
		{
			text = "华 国 锋 同 志 ， 让 我 们 看 看 我 们 北 方 的 邻 居 ， 我 们 的 “ 老 大 哥 ” ， 苏 联 吧 。 自 从 斯 大 林 同 志 去 世 ， 赫 鲁 晓 夫 上 台 以 来 ， 中 苏 关 系 就 陷 入 冰 点 。 原 本 我 们 是 好 同 志 ， 自 然 可 以 搁 置 所 有 的 领 土 争 端 ， 但 今 时 不 同 往 日 ， 苏 联 已 经 变 成 了 社 会 帝 国 主 义 国 家 ， 甚 至 有 时 与 美 帝 国 主 义 狼 狈 为 奸 。 再 加 上 蒙 古 问 题 ， 苏 联 的 坦 克 只 需 要 几 个 小 时 就 能 从 中 蒙 边 界 杀 到 北 京 ， 卧 榻 之 侧 岂 容 他 人 酣 睡 ， 这 对 我 国 的 国 防 安 全 是 极 大 的 威 胁 。 现 在 是 时 候 让 这 群 老 毛 子 们 见 识 一 下 我 们 的 厉 害 了 ！|我 会 给 军 区 首 长 们 传 达 您 的 指 令 ， 各 个 军 工 厂 已 经 开 始 全 速 运 转 ， 各 地 民 兵 ， 入 伍 和 复 员 工 作 也 在 有 条 不 紊 的 进 行 中 。 但 是 我 还 是 想 提 醒 您 ， 由 于 先 军 政 策 及 民 族 主 义 宣 传 的 影 响 ， 我 们 的 战 争 机 器 一 旦 开 动 起 来 ， 就 很 难 再 刹 得 住 车 。||<color=red>我 们 再 见 了 亲 爱 的 妈 妈 ， 请 你 吻 别 您 的 儿 子 吧 … …</color>";
			a.ingamewars[70] = new War().Name("雪 耻 之 战").Attacker("中 华 人 民 共 和 国").Defender("苏 联 及 蒙 古")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.TickTime(12)
				.SovietSupportDefender.AmericanSupportDefender.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] += 150;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.data[22] -= 200;
			a.data[34] += 2;
			a.empires[1].relations -= 500;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 500;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
		if (result_num == 5)
		{
			text = "我 会 让 服 务 生 同 志 给 您 送 上 一 杯 茶 的 ， 希 望 您 真 的 没 有 想 到 去 做 什 么 疯 狂 的 事 情 … …";
			a.completedDecisions[37] = false;
		}
	}
}
