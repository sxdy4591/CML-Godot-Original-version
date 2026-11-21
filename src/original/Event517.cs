using EventsForDLC;
using UnityEngine;

public class Event517 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 我 爱 祖 国 的 蓝 天";
		text = " 最 高 领 导 人 同 志 ， 正 如 你 所 知 ， 1 9 6 4 年 航 空 研 究 院 就 提 出 了 要 在 米 格 - 2 1 基 础 上 研 制 高 空 高 速 歼 击 机 。 1 9 6 5 年 5 月 1 7 日 ， 罗 瑞 卿 同 志 就 批 准 新 歼 的 战 技 指 标 和 研 制 任 务 ， 并 正 式 命 名 为 歼 - 8 。 由 沈 阳 飞 机 设 计 研 究 所 承 担 具 体 任 务 。 1 9 6 8 年 7 月 ， 首 批 2 架 歼 - 8 总 装 完 毕 。 1 9 6 9 年 7 月 5 日 ， 原 型 机 由 尹 玉 焕 驾 驶 首 飞 成 功 。 但 是 由 于 未 能 满 足 创 立 之 初 的 目 标 ： 超 视 距 空 战 而 长 期 被 搁 置 。 随 着 我 们 技 术 的 进 一 步 提 升 ， 列 装 这 类 飞 机 已 变 为 可 能 。 但 问 题 也 在 于 此 ， 美 国 空 军 早 在 1 9 7 6 年 就 开 始 列 装 更 为 先 进 的 F - 1 5 战 斗 机 ， 如 果 我 们 想 要 和 他 们 做 好 竞 争 的 准 备 ， 应 该 现 在 就 研 发 更 好 更 新 的 歼 击 机 。 同 时 ， 空 军 也 在 抱 怨 强 - 5 过 于 老 旧 ， 而 轰 - 六 又 是 个 十 足 的 油 老 虎 ， 应 当 对 这 些 机 型 进 行 改 进 。 这 肯 定 会 是 项 漫 长 的 工 程 ， 无 论 如 何 ， 中 央 军 事 委 员 会 希 望 听 听 您 的 意 见 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[12] >= 600)
		{
			button_text[0] = " 我 们 应 当 开 始 研 发 新 的 歼 击 机";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 的 工 业 水 平 不 支 持 我 们 做 这 些";
		}
		if (a.data[12] >= 600)
		{
			button_text[1] = " 别 忘 了 研 发 轰 炸 机 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 的 工 业 水 平 不 支 持 我 们 做 这 些";
		}
		if (a.data[12] >= 800)
		{
			button_text[2] = " 我 全 都 要 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 的 工 业 水 平 不 支 持 我 们 做 这 些";
		}
		button_text[3] = " 用 我 们 现 在 的 就 够 了 。";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 爱 祖 国 的 蓝 天";
		if (result_num == 0)
		{
			text = " 在 中 央 军 事 委 员 会 的 特 别 会 议 上 ， 会 议 决 定 开 始 研 发 新 型 的 第 三 代 战 斗 机 ， 假 想 敌 为 美 军 的 F - 1 5 和 苏 联 的 m i g - 2 9 战 斗 机 。 中 国 航 空 研 究 院 6 0 6 所 紧 锣 密 鼓 的 为 其 研 制 了 涡 扇 - 1 0 型 轮 扇 发 动 机 和 配 套 的 全 权 数 字 发 动 机 控 制 系 统 。 能 提 供 惊 人 的 8 9 . 1 7 千 牛 顿 力 。 更 大 的 弹 仓 和 更 快 的 速 度 决 定 了 它 的 优 势 。 该 型 飞 机 被 命 名 为 歼 1 0 。 在 不 久 的 将 来 ， 也 许 会 彻 底 取 代 歼 8 在 中 国 人 民 解 放 军 空 军 中 的 地 位 ， 但 这 都 是 后 话 了 。";
			if (GlobalScript.inst.gameState.leader.name_1 == 13 && GlobalScript.inst.gameState.leader.name_2 == 13)
			{
				text += " 可 惜 的 是 ， 我 们 尊 敬 的 ";
				text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
				text += " ";
				text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
				text += " 同 志 因 为 身 高 原 因 不 能 够 亲 自 试 着 驾 驶 而 只 能 作 为 乘 客 体 验 这 架 飞 机 ， 试 飞 过 程 中 他 一 言 不 发 ， 看 上 去 好 像 很 不 高 兴 。";
			}
			else
			{
				text += " 令 人 意 外 的 是 ， ";
				text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
				text += " ";
				text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
				text += " 同 志 也 试 着 驾 驶 了 这 架 飞 机 ， “ 太 快 了 ！ ” 是 他 唯 一 的 评 语 。";
			}
			a.data[8] -= 50;
			a.data[22] += 50;
			a.data[1] += 50;
			a.data[3] += 50;
			a.influencePRC += 20;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 新 式 歼 击 机 ：</color>| 军 力+0.3 ， 人 民 支 持 度+0.2 ， 预 算-0.2 ， 军 武 援 助 效 果+1";
		}
		if (result_num == 1)
		{
			text = " 在 中 央 军 事 委 员 会 的 特 别 会 议 上 ， 会 议 决 定 要 研 究 更 新 更 好 的 战 略 轰 炸 机 和 战 术 轰 炸 机 用 来 满 足 战 略 目 标 。 早 在 七 十 年 代 早 期 就 有 了 关 于 研 发 高 速 战 术 轰 炸 机 的 计 划 。 该 类 飞 机 要 具 有 良 好 的 飞 行 性 能 、 在 现 代 防 空 兵 器 对 抗 下 有 较 强 的 战 场 生 存 能 力 、 在 战 术 战 役 纵 深 内 完 成 轰 炸 任 务 ， 达 到 欧 洲 “ 龙 卷 风 ” 式 战 斗 轰 炸 机 的 性 能 ， 不 仅 要 能 投 掷 常 规 航 空 炸 弹 ， 还 要 能 发 射 制 导 武 器 与 战 术 核 武 器 。 对 此 ， 南 昌 制 造 厂 的 强 - 6 型 歼 击 轰 炸 机 赢 得 了 竞 标 。 而 西 安 6 0 3 研 究 所 的 轰 1 0 型 超 音 速 战 略 轰 炸 机 得 到 了 军 委 的 青 睐 。 早 在 上 个 十 年 西 安 军 工 厂 就 提 出 了 一 款 取 代 轰 - 6 的 新 设 计 方 案 ， 这 个 设 计 案 也 获 得 我 国 空 军 指 战 员 的 大 力 支 持 。 设 计 案 的 需 求 为 航 程 至 少 5 0 0 0 公 里 ， 高 空 速 率 最 少 2 马 赫 ， 低 空 穿 透 速 率 至 少 1 马 赫 ， 载 弹 量 2 0 公 吨 ， 并 且 能 够 在 刚 刚 整 备 完 成 的 前 进 机 场 操 作 。 这 个 方 案 得 到 了 我 们 的 倾 力 支 持 ， 配 套 的 空 射 导 弹 系 统 也 被 提 上 了 日 程 。";
			a.data[8] -= 50;
			a.data[22] += 50;
			a.data[1] += 50;
			a.data[3] += 50;
			a.influencePRC += 30;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 新 式 轰 炸 机 ：</color>| 军 力+0.5 ， 预 算-0.2 ，与 美 苏 关 系-0.2 ， 军 武 援 助 效 果+1";
		}
		if (result_num == 2)
		{
			text = " 在 中 央 军 事 委 员 会 的 特 别 会 议 上 ， 会 议 决 定 开 始 全 面 升 级 空 中 力 量 ， 谋 求 赶 上 苏 联 ， 争 取 和 美 国 的 差 距 不 超 过 五 年 。 新 式 战 斗 机 的 假 想 敌 为 美 军 的 F - 1 5 和 苏 联 的 m i g - 2 9 战 斗 机 。 中 国 航 空 研 究 院 6 0 6 所 紧 锣 密 鼓 的 为 其 研 制 了 涡 扇 - 1 0 型 轮 扇 发 动 机 和 配 套 的 全 权 数 字 发 动 机 控 制 系 统 。 能 提 供 惊 人 的 8 9 . 1 7 千 牛 顿 力 。 更 大 的 弹 仓 和 更 快 的 速 度 决 定 了 它 的 优 势 。 该 型 飞 机 被 命 名 为 歼 1 0 。 在 不 久 的 将 来 ， 也 许 会 彻 底 取 代 歼 8 在 中 国 人 民 解 放 军 空 军 中 的 地 位 ， 但 这 都 是 后 话 了 。||早 在 七 十 年 代 早 期 就 有 了 关 于 研 发 高 速 战 术 轰 炸 机 的 计 划 。 该 类 飞 机 要 具 有 良 好 的 飞 行 性 能 、 在 现 代 防 空 兵 器 对 抗 下 有 较 强 的 战 场 生 存 能 力 、 在 战 术 战 役 纵 深 内 完 成 轰 炸 任 务 ， 达 到 欧 洲 “ 龙 卷 风 ” 式 战 斗 轰 炸 机 的 性 能 ， 不 仅 要 能 投 掷 常 规 航 空 炸 弹 ， 还 要 能 发 射 制 导 武 器 与 战 术 核 武 器 。 对 此 ， 南 昌 制 造 厂 的 强 - 6 型 歼 击 轰 炸 机 赢 得 了 竞 标 。 而 西 安 6 0 3 研 究 所 的 轰 1 0 型 超 音 速 战 略 轰 炸 机 得 到 了 军 委 的 青 睐 。 早 在 上 个 十 年 西 安 军 工 厂 就 提 出 了 一 款 取 代 轰 - 6 的 新 设 计 方 案 ， 这 个 设 计 案 也 获 得 我 国 空 军 指 战 员 的 大 力 支 持 。 设 计 案 的 需 求 为 航 程 至 少 5 0 0 0 公 里 ， 高 空 速 率 最 少 2 马 赫 ， 低 空 穿 透 速 率 至 少 1 马 赫 ， 载 弹 量 2 0 公 吨 ， 并 且 能 够 在 刚 刚 整 备 完 成 的 前 进 机 场 操 作 。 这 个 方 案 得 到 了 我 们 的 倾 力 支 持 ， 配 套 的 空 射 导 弹 系 统 也 被 提 上 了 日 程 。 ";
			a.data[8] -= 80;
			a.data[22] += 80;
			a.data[1] += 100;
			a.data[6] += 5;
			a.data[3] += 100;
			a.data[57] += 50;
			a.influencePRC += 50;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 新 式 歼 击 机 与 轰 炸 机 ：</color>| 军 力+1.0 ， 人 民 支 持 度+0.2 ， 预 算-0.3 ，与 美 苏 关 系-0.2 ， 军 武 援 助 效 果+2";
		}
		if (result_num == 3)
		{
			text = " 我 们 有 歼 八 就 够 了 ， 大 不 了 再 研 究 些 空 空 导 弹 就 行 了 嘛 ！";
		}
	}
}
