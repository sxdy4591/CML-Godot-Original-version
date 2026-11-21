using EventsForDLC;
using UnityEngine;

public class Event345 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "肩 上 的 那 块 牌 子";
		text = " 随 着 我 国 军 队 的 进 一 步 发 展 ， 也 许 是 时 候 谈 谈 一 个 被 遗 忘 的 问 题 了 。 主 席 同 志 ， 作 为 中 央 军 委 的 一 员 ， 您 应 该 知 晓 我 国 军 队 与 他 国 军 队 的 一 个 显 著 特 征 ： 我 国 没 有 军 衔 的 概 念 ， 至 少 在 过 去 的 一 段 时 间 内 没 有 。 在1955 年 开 始 ， 我 国 短 暂 的 实 行 过 军 衔 制 ， 效 法 苏 联 设 立 了 多 个 军 种 和 军 衔 。 但 随 着 我 国 在 各 个 方 向 上 试 图 击 溃 苏 联 所 代 表 的 一 切 ， 军 衔 自 然 作 为 修 正 主 义 的 一 部 分 被 打 倒 。 毛 泽 东 主 席 在 讲 话 中 多 次 强 调 ， 高 级 干 部 要 注 意 学 习 马 列 主 义 ， 防 止 脱 离 群 众 , 加 强 干 部 特 别 是 高 级 干 部 的 革 命 化 建 设 。1964 年 前 后 ， 他 认 为 ， 军 队 高 级 干 部 工 资 过 高 ， 和 一 般 干 部 和 人 民 群 众 差 距 太 大 ， 难 以 体 验 人 民 群 众 的 疾 苦 ， 容 易 脱 离 群 众 ， 产 生 资 产 阶 级 思 想 ， 因 此 提 出 了 军 队 高 级 干 部 减 薪 问 题 ， 以 此 作 为 防 止 修 正 主 义 的 一 项 措 施 。||在 林 彪 取 代 彭 德 怀 主 持 军 委 工 作 后 ， 大 力 宣 扬 “ 突 出 政 治 ” 。 在 这 种 观 念 影 响 下 ， 一 些 人 认 为 ， 军 衔 制 等 级 分 明 ， 不 符 合 人 民 解 放 军 官 兵 一 致 的 原 则 ， 不 利 于 干 部 和 士 兵 打 成 一 片 ， 因 此 也 不 利 于 继 承 光 荣 传 统 。 这 种 对 “ 革 命 化 ” 建 设 的 片 面 理 解 ， 加 之 人 民 军 队 几 十 年 战 争 时 期 没 有 军 衔 制 度 而 取 得 革 命 的 胜 利 ， 也 使 许 多 人 认 为 实 行 军 衔 制 并 无 必 要 。||";
		if (GlobalScript.inst.gameState.vietnampeace && GlobalScript.inst.gameState.resultOfEvents[378] != 2 && GlobalScript.inst.gameState.allcountries[10].puppetOf != 1)
		{
			text += "在 我 国 回 到 了 世 界 舞 台 后 ， 大 量 的 军 事 代 表 团 也 曾 来 我 国 访 问 。 他 们 对 于 我 们 缺 少 军 衔 这 一 点 感 到 十 分 不 解 。 解 放 军 的 空 军 大 校 在 会 见 伊 朗 空 军 代 表 团 时 曾 被 问 到 “ 你 的 上 级 呢 ？ ” 这 样 让 人 啼 笑 皆 非 的 问 题 ， 险 些 导 致 外 交 纠 纷 。 因 此 ， 有 些 同 志 认 为 我 们 该 考 虑 恢 复 军 衔 了 。";
		}
		else
		{
			text += "而 事 实 证 明 ， 我 们 在 一 定 程 度 上 是 错 误 的 。 军 队 并 非 一 个 “ 一 个 阶 级 压 迫 另 一 个 阶 级 ” 的 小 社 会 ， 而 是 相 互 协 作 的 大 学 校 。 在 战 场 上 ， 任 何 一 个 地 方 出 现 的 问 题 都 会 导 致 战 术 上 的 错 误 ， 而 牺 牲 是 不 可 避 免 但 难 以 接 受 的 。 而 我 们 缺 乏 区 分 度 和 军 衔 导 致 了 我 方 命 令 的 混 乱 ， 许 多 同 志 提 议 我 们 恢 复 军 衔 。 ";
		}
		text += "||但 仍 然 有 不 少 同 志 认 为 ， 现 行 制 度 没 有 什 么 不 好 的 ， 毕 竟 现 行 制 度 体 现 了 官 军 平 等 的 思 想 ，这 也 是 在 大 会 上 由 军 队 上 下 选 举 所 得 到 的 结 果 。所 以 ， 您 怎 么 看 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if ((GlobalScript.inst.gameState.data[56] <= 2 && GlobalScript.inst.gameState.resultOfEvents[514] != 1) || GlobalScript.inst.gameState.resultOfEvents[514] == 2)
		{
			button_text[0] = "我 就 是 看 不 惯 那 两 块 牌 牌 ， 讨 嫌 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "这 套 理 论 过 时 啦 ！";
		}
		if ((GlobalScript.inst.gameState.data[56] >= 2 && GlobalScript.inst.gameState.resultOfEvents[514] != 2) || GlobalScript.inst.gameState.resultOfEvents[514] == 1 || !GlobalScript.inst.gameState.modifies[6].active)
		{
			button_text[1] = "好 吗 ， 我 觉 得 就 该 恢 复 军 衔 了 ！";
			return;
		}
		Object.Destroy(button[1]);
		button_text[1] = "我 们 的 军 队 可 不 是 什 么 资 产 阶 级 大 学 校";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "肩 上 的 那 块 牌 子";
		switch (result_num)
		{
		case 0:
		{
			text = "最 终 ， 我 国 决 定 继 续 保 持 过 去 的 设 计 。 毕 竟 时 间 和 实 践 已 经 证 明 了 我 们 的 正 确 性 。 过 去 没 有 军 衔 ， 也 一 样 打 胜 仗 。 这 种 制 度 不 符 合 我 军 的 优 良 传 统 ， 它 是 一 种 资 产 阶 级 法 权 ， 等 级 表 面 化 ， 助 长 了 个 人 名 位 思 想 和 等 级 观 念 。 不 利 于 我 军 的 革 命 化 建 设 ， 不 利 于 同 志 之 间 、 上 下 级 之 间 和 军 民 之 间 的 团 结 。 同 时 增 加 了 各 级 党 委 和 政 治 机 关 不 少 繁 琐 事 务 。||我 军 是 中 国 共 产 党 和 毛 主 席 缔 造 ， 领 导 的 人 民 军 队 。 官 兵 一 致 ， 上 下 一 致 ， 军 民 一 致 是 我 军 固 有 的 优 良 传 统 。 我 们 的 干 部 和 战 士 ， 都 是 亲 密 的 战 友 和 阶 级 兄 弟 。 我 们 军 队 和 人 民 血 肉 相 连 ， 鱼 水 相 亲 。 在 过 去 长 期 的 革 命 战 争 中 ， 我 军 是 没 有 军 衔 制 度 的 。 全 国 胜 利 以 后 ， 在1955 年 才 开 始 实 行 。 十 年 的 实 践 证 明 ， 实 行 军 衔 制 度 ， 与 我 军 的 光 荣 传 统 是 不 相 符 合 的 ， 与 官 兵 之 间 ， 上 下 级 之 间 ， 军 民 之 间 的 亲 密 关 系 也 是 不 相 适 应 的 。 我 军 的 建 设 ， 最 根 本 的 是 以 毛 泽 东 思 想 为 指 针 ， 加 强 政 治 思 想 工 作 ， 提 高 全 体 指 战 员 的 阶 级 觉 悟 ， 培 养 优 良 作 风 ， 提 高 军 事 素 质 ， 使 我 军 更 加 无 产 阶 级 化 ， 更 加 战 斗 化 。 因 此 ， 取 消 军 衔 制 度 是 完 全 正 确 的 、 完 全 必 要 的 。 取 消 军 衔 制 度 ， 有 利 于 官 兵 之 间 、 上 下 级 之 间 、 军 民 之 间 的 团 结 ， 有 利 于 进 一 步 发 扬 我 军 的 光 荣 传 统 。 就 像 毛 泽 东 主 席 曾 经 说 过 的 那 样 ： “ 取 消 ！ 搞 掉 那 块 牌 牌 ！ ”";
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.power += 25;
					politic2.loyality += 50;
				}
			}
			GlobalScript.inst.gameState.data[57] += 15;
			GlobalScript.inst.gameState.data[6] += 25;
			string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
			int num2 = 50;
			old_modify_desc2[num2] += "<color=red>| 没 有 军 衔 的 军 队：</color>| 人 民 支 持 度+0.3 ， 军 力+0.2 ， 干 涉 点 数+0.2";
			break;
		}
		case 1:
		{
			text = "我 们 最 终 决 定 恢 复 过 去 的 军 衔 制 ， 事 实 上 早 在1979 年9 月 ， 总 政 治 部 最 早 提 出 恢 复 军 衔 制 ， 该 部 在 全 军 干 部 工 作 会 上 提 交 《 恢 复 军 衔 制 度 的 初 步 方 案 》 。 经 过 会 议 讨 论 ， 军 队 拟 改 革 和 完 善 六 项 制 度 ， 其 中 第 五 项 就 是 军 衔 制 度 。 该 次 会 议 结 束 后 ， 总 政 治 部 于 同 年11 月 向 中 央 军 委 呈 报 《 关 于 加 强 干 部 队 伍 建 设 若 干 问 题 的 请 示 报 告 》 ， 正 式 以 文 字 形 式 提 出 “ 恢 复 军 衔 制 ” 的 建 议 。 但 当 时 我 们 并 没 有 多 加 考 虑 ， 事 实 证 明 我 们 非 常 有 必 要 这 么 做 ： 据 一 位 退 伍 军 人 的 回 忆 录 所 述 ， 某 次 在 公 路 上 几 支 不 同 部 队 挤 在 了 一 起 ， 谁 也 不 愿 让 其 他 人 先 过 ， 导 致 行 军 速 度 极 慢 、 秩 序 也 非 常 混 乱 ， 这 时 一 名 师 长 就 爬 到 了 一 辆 坦 克 上 ， 大 声 喊 自 己 是 师 长 ， 让 卡 车 靠 左 ， 坦 克 靠 右 ， 战 士 从 中 间 走 。 但 他 佩 戴 的 红 领 章 、 红 帽 徽 与 其 他 人 都 一 样 ， 没 有 人 相 信 他 的 话 ， 依 然 还 是 挤 成 一 团 ， 费 了 很 多 时 间 各 部 才 得 以 通 过 。 这 是 在 行 军 还 算 好 ， 如 果 遇 到 敌 人 偷 袭 呢 ？ 没 有 一 个 军 衔 高 的 出 来 指 挥 ， 大 家 还 是 会 各 自 作 战 ， 后 果 不 堪 设 想 。||";
			if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 19)
			{
				text += " 和1955 年 的 规 划 相 比 ， 我 国 不 再 设 有 一 级 上 将 以 上 的 职 位 。 在 人 民 大 会 堂 ， 主 席 同 志 亲 自 为30 位 解 放 军 各 阶 层 的 官 员 授 予 了 军 衔 。";
			}
			else
			{
				text += "英 明 的 领 袖 就 要 做 出 英 明 的 决 策 ， 华 国 锋 同 志 决 定 彻 底 恢 复1955 年 的 军 衔 制 度 。 并 追 授 给 我 们 永 远 的 导 师 毛 泽 东 主 席 为 大 元 帅 ， 而 华 国 锋 同 志 和 其 余30 多 位 同 志 一 起 在 人 民 大 会 堂 内 参 加 了 军 衔 制 恢 复 以 来 第 一 次 的 授 衔 仪 式 。 华 国 锋 同 志 则 被 授 予 了 元 帅 军 衔 ， 这 是 他 应 得 的 ！";
			}
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power -= 25;
					politic.loyality -= 50;
				}
			}
			GlobalScript.inst.gameState.empires[0].relations += 25;
			GlobalScript.inst.gameState.data[57] += 15;
			string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
			int num = 50;
			old_modify_desc[num] += "<color=red>| 恢 复 军 衔 ：</color>| 军 力+0.5 ， 干 涉 点 数+0.2 ， 腐 败+0.2 ， 资 金-0.1";
			break;
		}
		}
	}
}
