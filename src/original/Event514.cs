using EventsForDLC;
using UnityEngine;

public class Event514 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 一 颗 红 星 头 上 戴 ， 革 命 红 旗 挂 两 边";
		text = " 随 着 军 队 的 装 备 进 一 步 发 展 ， 另 一 个 问 题 开 始 浮 现 ： 6 5 式 军 装 实 在 是 太 不 军 装 了 。 客 观 上 来 说 ， 这 件 衣 服 确 实 极 有 革 命 性 ， 但 作 战 能 力 实 在 堪 忧 。 无 法 起 到 迷 彩 的 功 能 不 说 ， 在 分 工 极 强 的 军 队 容 易 造 成 指 挥 系 统 的 混 乱 。 因 此 很 多 人 提 议 研 发 一 款 作 战 服 以 取 代 6 5 式 军 装 。 也 有 人 支 持 保 留 革 命 的 象 征 — — 6 5 式 军 装 和 5 6 式 半 自 动 步 枪 已 经 成 为 了 世 人 对 中 国 的 固 有 印 象 。 也 有 人 建 议 加 速 废 除 6 5 式 军 装 ， 坚 定 的 和 过 去 切 割 。 很 明 显 ， 这 将 会 决 定 我 们 武 装 力 量 的 未 来 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 2)
		{
			button_text[0] = " 开 始 研 发 迷 彩 ， 但 保 留 6 5 式";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 总 得 变 点 什 么";
		}
		if (a.data[56] >= 2)
		{
			button_text[1] = " 加 速 研 发 新 军 装";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 这 东 西 的 审 美 似 乎 不 符 合 我 们 的 标 准";
		}
		if (a.data[56] <= 2)
		{
			button_text[2] = " 保 留 旧 设 计";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = " 旧 时 代 已 经 过 去 了 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 一 颗 红 星 头 上 戴 ， 革 命 红 旗 挂 两 边";
		if (result_num == 0)
		{
			text = " 在 意 识 到 军 人 需 要 更 实 用 的 军 装 的 情 况 下 ， 我 们 决 定 着 手 研 发 8 0 式 迷 彩 服 ， 将 用 于 发 配 海 陆 双 军 的 士 兵 们 。 这 套 军 服 将 更 注 重 实 用 性 ， 也 为 未 来 可 能 的 改 装 做 好 了 准 备 。 但 6 5 式 军 装 将 作 为 常 服 配 发 给 一 般 士 兵 ， 在 日 常 和 阅 兵 式 上 ， 6 5 式 军 装 仍 然 是 解 放 军 战 士 的 象 征 。";
			a.data[8] -= 20;
			a.data[1] += 50;
			a.data[6] += 5;
			a.data[3] += 50;
			a.influencePRC += 10;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 新 式 军 装 ：</color>| 人 民 支 持 度+0.1 ， 思 想 自 由 化-0.1 ， 国 际 声 望 高 于90/ 低 于 70 时 ， 国 际 声 望-0.1/ +0.1";
		}
		if (result_num == 1)
		{
			text = " 我 们 决 定 和 过 去 做 坚 决 的 割 裂 。 在 本 年 度 的 军 需 单 中 ， 不 再 配 发 6 5 式 军 装 ， 8 0 式 迷 彩 服 和 8 0 式 军 装 将 取 代 他 们 。 这 一 系 列 军 装 更 强 调 实 用 性 和 外 观 ， 有 不 少 人 需 要 花 时 间 去 习 惯 大 檐 帽 ， 帽 徽 和 西 式 礼 服 。 但 他 们 总 归 会 习 惯 的 。";
			a.data[8] -= 10;
			a.influencePRC += 5;
			a.data[6] -= 30;
			a.data[22] += 80;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 西 式 军 装 ：</color>| 人 民 支 持 度+0.1 ， 思 想 自 由 化+0.1 ， 国 际 声 望-0.2";
		}
		if (result_num == 2)
		{
			text = " 中 国 人 民 解 放 军 的 军 服 还 是 像 过 去 一 样 ， 没 有 什 么 特 别 的 变 化 ， 也 没 人 有 意 见 。";
			a.data[6] += 10;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 65 式 军 装 ：</color>| 人 民 支 持 度+0.1 ， 思 想 自 由 化-0.2 ， 国 际 声 望+0.2";
		}
	}
}
