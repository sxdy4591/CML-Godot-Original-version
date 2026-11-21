using EventsForDLC;
using UnityEngine;

public class Event518 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 人 民 空 军 ， 勇 敢 去 闯 荡";
		text = " 随 着 我 们 工 业 体 系 ， 尤 其 是 航 空 电 子 科 技 的 进 一 步 发 展 ， 一 个 大 胆 的 计 划 正 在 酝 酿 。 我 们 的 科 学 家 和 工 程 师 正 在 研 究 电 子 层 面 的 低 可 侦 测 型 涂 装 ， 这 将 会 是 一 件 非 常 烧 钱 的 计 划 ， 但 其 回 报 将 是 超 出 我 们 想 象 的 ： 要 是 在 将 来 爆 发 战 争 ， 我 们 的 空 军 将 会 有 难 以 匹 敌 的 优 势 。 这 款 飞 机 的 雷 达 系 统 和 数 字 化 控 制 系 统 将 会 超 出 我 们 所 有 人 的 预 料 ， 远 远 的 把 同 级 的 F 1 5 ， M i g - 2 9 甩 在 身 后 。 最 高 领 导 人 同 志 ， 您 的 意 向 如 何 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.resultOfEvents[517] >= 0)
		{
			button_text[0] = " 投 资 研 发 歼 - 1 8 型 隐 身 歼 击 机";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 的 航 空 器 技 术 还 是 不 太 行 啊 … …";
		}
		if (a.resultOfEvents[517] >= 1)
		{
			button_text[1] = " 投 资 研 发 轰 - 1 5 型 隐 身 战 略 轰 炸 机";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 的 航 空 器 技 术 还 是 不 太 行 啊 … …";
		}
		if (a.resultOfEvents[517] == 2)
		{
			button_text[2] = " 我 全 都 要 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 的 航 空 器 技 术 还 是 不 太 行 啊 … …";
		}
		button_text[3] = " 我 们 用 现 在 的 飞 机 就 足 够 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 人 民 空 军 ， 勇 敢 去 闯 荡";
		if (result_num == 0)
		{
			text = " 中 央 军 事 委 员 会 决 定 研 究 J - 1 8 歼 击 机 。 该 机 型 采 取 了 不 同 以 往 的 布 局 系 统 ， 采 用 了 双 发 ， 鸭 式 气 动 布 局 的 新 格 局 。 最 新 的 航 电 系 统 允 许 其 搭 载 超 视 距 的 霹 雳 1 0 等 空 空 导 弹 。 隐 形 性 能 大 概 在 0 . 0 0 0 1 左 右 ， 这 已 经 是 相 当 好 的 数 据 了 。 类 似 的 系 统 将 会 被 搭 载 在 歼 2 0 上 ， 预 计 在 本 世 纪 末 之 前 完 成 理 论 实 验 和 风 洞 测 试 。";
			a.data[8] -= 50;
			a.data[22] += 50;
			a.data[1] += 50;
			a.data[3] += 50;
			a.influencePRC += 20;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 隐 身 歼 击 机 ：</color>| 军 力+0.2 ， 人 民 支 持 度+0.2 ， 预 算-0.2 ， 干 预 点 数+1.0";
		}
		if (result_num == 1)
		{
			text = " 中 央 军 事 委 员 会 决 定 投 资 轰 - 1 5 战 略 轰 炸 机 。 和 过 去 轰 炸 机 最 大 的 不 同 便 是 其 强 大 的 隐 身 性 能 ， 代 价 便 是 其 载 弹 量 显 著 小 于 我 们 现 役 的 任 何 一 种 战 略 轰 炸 机 。 不 过 我 们 只 要 能 突 破 敌 人 的 第 一 道 防 线 ， 也 算 是 达 成 战 略 目 的 了 。 配 套 的 “ 井 冈 山 ” 型 精 确 制 导 炸 弹 和 红 鸟 - 4 远 程 巡 航 导 弹 也 在 研 发 中 。 我 们 的 “ 三 位 一 体 ” 核 打 击 能 力 大 大 加 强 了 。";
			a.data[8] -= 50;
			a.data[22] += 50;
			a.data[1] += 50;
			a.data[3] += 50;
			a.influencePRC += 30;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 隐 身 轰 炸 机 ：</color>| 军 力+0.3 ， 预 算-0.2 ，与 美 苏 关 系-0.1 ，干 预 点 数+1.0";
		}
		if (result_num == 2)
		{
			text = " 中 国 空 军 正 在 向 着 超 一 流 的 水 平 发 展 ， 其 中 必 不 可 少 的 便 是 全 面 研 发 先 进 航 空 器 。||J - 1 8 歼 击 机 项 目 上 马 了 。 该 机 型 采 取 了 不 同 以 往 的 布 局 系 统 ， 采 用 了 双 发 ， 鸭 式 气 动 布 局 的 新 格 局 。 最 新 的 航 电 系 统 允 许 其 搭 载 超 视 距 的 霹 雳 1 0 等 空 空 导 弹 。 隐 形 性 能 大 概 在 0 . 0 0 0 1 左 右 ， 这 已 经 是 相 当 好 的 数 据 了 。 类 似 的 系 统 将 会 被 搭 载 在 歼 2 0 上 ， 预 计 在 本 世 纪 末 之 前 完 成 理 论 实 验 和 风 洞 测 试 。||轰 - 1 5 战 略 轰 炸 机 也 是 个 不 可 忽 视 的 大 项 目 。 和 过 去 轰 炸 机 最 大 的 不 同 便 是 其 强 大 的 隐 身 性 能 ， 代 价 便 是 其 载 弹 量 显 著 小 于 我 们 现 役 的 任 何 一 种 战 略 轰 炸 机 。 不 过 我 们 只 要 能 突 破 敌 人 的 第 一 道 防 线 ， 也 算 是 达 成 战 略 目 的 了 。 配 套 的 “ 井 冈 山 ” 型 精 确 制 导 炸 弹 和 红 鸟 - 4 远 程 巡 航 导 弹 也 在 研 发 中 。 我 们 的 “ 三 位 一 体 ” 核 打 击 能 力 大 大 加 强 了 。||保 卫 领 空 ， 抵 御 侵 略 。 迎 着 新 世 纪 的 曙 光 去 飞 翔 ， 飞 翔 ， 飞 翔 ！";
			a.data[8] -= 80;
			a.data[22] += 80;
			a.data[1] += 100;
			a.data[6] += 5;
			a.data[3] += 100;
			a.data[57] += 50;
			a.influencePRC += 50;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 隐 身 歼 击 机 与 轰 炸 机 ：</color>| 军 力+0.8 ， 人 民 支 持 度+0.2 ， 预 算-0.3 ，与 美 苏 关 系-0.1 ， 干 预 点 数+2.0";
		}
		if (result_num == 3)
		{
			text = " 现 在 的 飞 机 已 经 足 够 对 付 外 在 的 侵 略 了 ， 我 们 可 以 在 下 次 会 议 上 讨 论 这 个 问 题 。";
		}
	}
}
