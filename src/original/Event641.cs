using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event641 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "若 列 宁 可 见 今 日";
		text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 ， 我 们 似 乎 获 得 了 削 弱 那 该 死 的 安 德 罗 波 夫 - 卡 特 协 定 的 良 机 ： 由 于 苏 联 向 西 看 齐 的 政 策 完 全 是 权 宜 之 计 ， 内 部 自 有 许 多 不 足 之 处 。 雅 科 夫 列 夫 的 改 革 与 对 苏 共 内 部 的 果 断 清 洗 只 会 让 问 题 进 一 步 激 化 ： 保 守 派 的 离 任 导 致 许 多 官 僚 机 构 内 青 黄 不 接 ， 对 民 族 地 区 的 洗 牌 也 自 然 导 致 了 本 地 利 益 集 团 的 抗 议 ， 而 向 市 场 社 会 主 义 转 型 的 尝 试 则 开 始 持 续 破 坏 计 划 经 济 框 架 ， 并 为 西 方 投 资 、 多 种 合 营 管 理 与 地 下 交 易 形 式 开 了 绿 灯 ： 苏 联 业 已 成 为 匈 牙 利 模 式 的 大 型 试 验 田 。 其 欧 洲 部 分 也 正 因 近 水 楼 台 ， 接 受 主 要 西 方 国 家 支 持 而 通 过 经 济 特 区 与 自 贸 区 形 式 快 速 崛 起 ； 但 其 疏 远 发 达 地 带 ， 且 同 时 作 为 冷 战 前 线 的 中 亚 与 远 东 则 是 另 一 派 光 景 ： 自 筹 资 金 改 革 与 放 权 政 策 只 会 让 当 地 直 面 破 产 风 险 与 经 济 萧 条 ， 并 不 得 不 仰 仗 更 加 竭 泽 而 渔 的 开 发 政 策 — — 这 便 是 苏 联 亚 洲 部 分 内 人 口 流 动 频 繁 ， 边 界 管 控 松 懈 ， 且 大 量 苏 联 侨 民 开 始 越 过 苏 联 边 界 口 岸 逃 往 我 国 的 原 因 。 我 们 当 然 可 利 用 这 一 状 况 ， 一 雪 伊 塔 事 件 之 耻 ， 一 面 用 弃 暗 投 明 的 前 苏 联 公 民 充 实 我 边 疆 建 设 事 业 ， 一 面 则 向 全 世 界 展 示 苏 联 改 革 政 策 的 失 败 。 不 过 ， 我 们 也 可 以 更 进 一 步 — — 考 虑 到 苏 联 边 界 防 御 事 实 上 趋 于 松 懈 ， 为 何 不 试 着 对 列 宁 时 代 的 “ 否 认 中 俄 间 一 切 不 平 等 条 约 ” 故 事 重 提 ， 并 以 “ 保 护 ” 我 国 在 苏 联 侨 胞 为 由 ， 直 接 让 曾 被 沙 俄 侵 占 的 外 东 北 和 外 西 北 地 区 回 归 我 中 华 民 族 大 家 庭 呢 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[8] + a.data[36] >= 100 && a.data[5] >= 800)
		{
			button_text[0] = "以 眼 还 眼 ： 我 们 将 把 伊 犁 与 哈 尔 滨 变 为 东 方 的 西 柏 林";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "我 们 可 没 本 钱 安 置 这 么 多 人";
		}
		if (a.data[22] >= 2000 && a.data[9] >= 750 && a.data[31] >= 700 && a.data[57] >= 700 && a.data[6] >= 1000 && GlobalScript.inst.gameState.science[26] && GlobalScript.inst.gameState.science[22] && a.data[130] == 1 && a.allcountries[1].parts[0] && !GlobalScript.inst.gameState.allcountries[1].parts[9] && !GlobalScript.inst.gameState.allcountries[1].parts[7] && !GlobalScript.inst.gameState.allcountries[1].parts[8] && a.allcountries[8].proprc && a.allcountries[8].okb && a.allcountries[12].proprc && a.allcountries[12].okb && a.allcountries[44].proprc && a.allcountries[44].okb)
		{
			button_text[1] = "以 牙 还 牙 ： 为 什 么 不 把 战 线 向 北 推 呢 ？ … …";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = "我 们 真 做 好 了 同 有 核 国 家 开 战 的 打 算 ？";
		}
		button_text[2] = "让 苏 联 人 自 己 应 付 那 些 麻 烦 罢";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "若 列 宁 可 见 今 日";
		if (result_num == 0)
		{
			text = "依 托 位 于 阿 拉 木 图 、 伏 龙 芝 与 杜 尚 别 的 使 馆 和 代 办 处 ， 我 们 很 快 便 向 西 亚 地 区 分 发 了 大 量 的 中 国 “ 侨 胞 证 ” 与 有 关 中 苏 社 会 与 生 活 对 比 的 发 放 材 料 ， 并 揭 露 了 苏 联 政 府 肆 意 抓 捕 少 数 民 族 成 员 用 以 做 秘 密 实 验 ； 以 当 地 民 族 协 会 ， 中 苏 友 好 协 会 和 文 化 协 会 等 组 织 为 掩 护 输 送 线 人 ， 在 中 亚 的 少 数 民 族 内 做 有 利 于 我 方 的 工 作 。 位 于 伊 犁 与 哈 尔 滨 的 广 播 电 台 都 已 全 力 开 动 ， 以 俄 语 ， 哈 萨 克 语 ， 吉 尔 吉 斯 语 等 多 语 言 形 式 对 中 亚 与 远 东 地 区 的 苏 联 人 民 “ 晓 之 以 情 ， 动 之 以 理 ” ： 并 将 雅 科 夫 列 夫 描 绘 为 “ 大 俄 罗 斯 沙 文 主 义 者 ” ， “ 冷 战 时 代 的 斯 托 雷 平 ” ， “ 试 图 以 民 主 与 经 济 改 革 为 旗 摧 毁 当 地 传 统 生 活 方 式 ” 。 很 快 ， 我 们 的 工 作 便 取 得 了 成 效 ： 中 苏 西 北 与 东 北 边 界 乱 作 一 团 ， 部 分 地 区 的 地 方 政 府 在 混 乱 内 遗 失 了 机 密 文 件 与 政 府 公 章 ， 海 参 崴 政 府 大 楼 更 是 被 高 举 “ 回 黑 龙 江 去 ” 横 幅 的 队 伍 给 焚 为 废 墟 。 而 边 界 的 人 民 解 放 军 部 队 则 为 起 义 者 们 提 供 了 方 便 ： 借 着 混 乱 局 势 ， 我 们 动 用 了 相 当 人 力 为 中 华 民 族 带 回 了 新 一 批 同 胞 ， 并 在 苏 联 安 插 了 又 一 批 线 人 ， 相 关 事 宜 在 国 内 被 视 为 同 土 尔 扈 特 部 东 归 般 的 大 事 。 狠 狠 地 给 全 国 人 民 出 了 口 恶 气 ： 当 然 ， 这 只 会 让 苏 联 人 不 满 。 以 雅 科 夫 列 夫 为 首 的 苏 共 领 导 核 心 对 东 方 表 示 “ 极 度 愤 慨 ” ， 并 怒 斥 我 国 事 实 上 奉 行 “ 社 会 帝 国 主 义 政 策 ” 。";
			a.data[1] += 50;
			a.data[3] += 100;
			a.data[4] -= 100;
			a.data[6] += 10;
			a.data[8] -= 100;
			a.data[9] -= 50;
			a.data[34] += 2;
			a.empires[1].relations -= 200;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 50;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
		if (result_num == 1)
		{
			text = "依 托 位 于 阿 拉 木 图 、 伏 龙 芝 与 杜 尚 别 的 使 馆 ， 我 们 很 快 便 向 西 亚 地 区 分 发 了 大 量 的 中 国 “ 侨 胞 证 ” 与 有 关 中 苏 社 会 与 生 活 对 比 的 发 放 材 料 ， 并 以 当 地 民 族 协 会 、 文 化 协 会 等 组 织 为 掩 护 输 送 线 人 ， 在 中 亚 的 少 数 民 族 内 做 有 利 于 我 方 的 工 作 。 位 于 伊 犁 与 哈 尔 滨 的 广 播 电 台 都 已 全 力 开 动 ， 以 俄 语 ， 哈 萨 克 语 ， 吉 尔 吉 斯 语 等 多 语 言 形 式 对 中 亚 与 远 东 地 区 的 苏 联 人 民 “ 晓 之 以 情 ， 动 之 以 理 ” ： 并 将 雅 科 夫 列 夫 描 绘 为 “ 大 俄 罗 斯 沙 文 主 义 者 ” ， “ 冷 战 时 代 的 斯 托 雷 平 ” ， “ 试 图 以 民 主 与 经 济 改 革 为 旗 摧 毁 当 地 传 统 生 活 方 式 ” 。 很 快 ， 我 们 的 工 作 便 取 得 了 成 效 ： 中 苏 西 北 与 东 北 边 界 乱 作 一 团 ， 部 分 地 区 的 地 方 政 府 在 混 战 内 遗 失 了 机 密 文 件 与 政 府 公 章 ， 海 参 崴 政 府 大 楼 更 是 被 高 举 “ 回 黑 龙 江 去 ” 横 幅 的 队 伍 给 焚 为 废 墟 。 而 边 界 的 人 民 解 放 军 部 队 则 为 起 义 者 们 提 供 了 方 便 ： 借 着 混 乱 局 势 ， 我 们 成 功 将 一 名 中 国 边 防 士 兵 伪 造 死 亡 ， 并 由 此 彻 底 引 爆 了 国 内 爱 国 主 义 情 绪 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 就 此 顺 藤 摸 瓜 ， 以 绝 对 优 势 批 准 了 对 苏 特 别 军 事 行 动 “ 击 毁 T 6 2 ” 计 划 ： 预 计 将 在 短 时 间 内 基 本 捣 毁 苏 联 亚 洲 防 线 ， 以 原 清 代 版 图 为 原 型 建 立 外 东 北 、 外 西 北 安 全 区 并 彻 底 终 结 沙 俄 时 代 签 署 的 不 平 等 条 约 ： 新 疆 地 区 的 解 放 军 部 队 将 同 伊 朗 与 阿 富 汗 的 同 志 一 道 压 制 苏 联 中 亚 军 区 ， 远 东 地 区 的 中 日 联 合 舰 队 则 将 在 击 溃 苏 联 远 东 边 防 的 同 时 策 应 海 军 陆 战 队 对 远 东 军 区 进 行 去 军 事 化 ， 与 此 同 时 ， 我 们 还 将 调 动 蒙 古 地 区 的 武 装 力 量 直 取 贝 加 尔 湖 地 区 的 重 镇 伊 尔 库 茨 克 并 筹 备 武 装 布 里 亚 特 蒙 古 人 ， 旨 在 以 最 快 速 度 终 结 苏 方 抵 抗 。 中 国 龙 的 复 仇 就 此 开 始 … …";
			a.ingamewars[70] = new War().Name("雪 耻 之 战").Attacker("中 华 人 民 共 和 国").Defender("苏 联")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.TickTime(4)
				.SovietSupportDefender.AmericanSupportDefender.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] = 1100;
			a.data[8] -= 50;
			a.data[9] -= 750;
			a.data[22] -= 2000;
			a.data[34] += 2;
			a.empires[1].relations -= 500;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 500;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
		if (result_num == 2)
		{
			text = "无 事 发 生 ， 除 却 时 不 时 出 现 的 中 亚 人 口 外 流 问 题 外 ， 苏 联 的 红 色 资 本 主 义 发 展 照 常 ： 不 久 后 ， 雅 科 夫 列 夫 的 办 公 室 洗 牌 也 跟 着 来 到 了 这 些 地 区 ， 改 革 春 风 就 此 不 可 阻 挡 … …";
		}
	}
}
