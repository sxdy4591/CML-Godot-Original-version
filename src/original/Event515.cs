using EventsForDLC;
using UnityEngine;

public class Event515 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 来 自 未 来 ？";
		text = " 1 9 7 3 年 的 赎 罪 日 战 争 中 ， 以 色 列 的 新 型 武 器 在 战 场 上 大 放 异 彩 ， 这 就 是 遥 控 飞 行 器 。 看 起 来 像 个 玩 具 ， 却 能 做 到 侦 查 的 效 果 。 而 这 样 的 武 器 获 得 了 不 少 观 察 员 的 认 同 ， 认 为 这 样 的 武 器 会 在 未 来 发 挥 作 用 。 也 有 人 不 这 么 认 为 ， 对 于 现 在 我 国 的 电 子 业 来 说 ， 还 是 太 复 杂 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[8] + a.data[36] >= 50)
		{
			button_text[0] = " 投 入 资 金 研 究 无 人 机";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 无 论 是 刀 还 是 刀 乐 ， 总 之 就 是 —— 没 有";
		}
		button_text[1] = " 转 行 研 究 航 模";
		button_text[2] = " 算 了 吧";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 来 自 未 来 ？";
		if (result_num == 0)
		{
			text = " 我 们 决 定 将 资 金 投 资 在 刀 刃 上 ， 开 始 着 手 研 究 无 人 飞 行 器 ， 这 对 我 们 的 电 子 业 提 出 了 巨 大 的 要 求 。 但 成 果 是 显 著 的 ， 绰 号 “ 红 小 兵 ” 的 无 人 侦 察 飞 行 器 除 开 噪 声 问 题 外 ， 没 有 过 分 的 烦 恼 。 而 这 个 问 题 将 会 在 未 来 得 到 解 决 ， 我 们 的 侦 察 和 测 绘 能 力 显 著 增 强 了 ， 而 具 有 察 打 一 体 的 型 号 正 在 研 发 中 。 也 许 在 未 来 ， 农 民 也 可 以 在 拖 拉 机 站 领 到 农 用 无 人 机 ， 这 将 显 著 的 解 放 生 产 力 和 劳 作 精 力 。";
			a.data[8] -= 50;
			a.data[9] += 50;
			a.data[22] += 50;
			a.data[1] += 50;
			a.data[6] += 5;
			a.data[3] += 50;
			a.influencePRC += 20;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 无 人 飞 行 器 ：</color>| 军 力+0.2 ， 特 工 网 络 + 0.1";
		}
		if (result_num == 1)
		{
			text = " 我 们 决 定 把 这 项 技 术 用 在 研 究 航 模 上 ， 事 实 证 明 这 是 个 极 为 正 确 的 决 定 。 我 们 的 “ 耐 摔 王 ” 型 无 人 飞 行 器 很 快 成 为 了 全 国 孩 子 都 梦 寐 以 求 的 儿 童 节 礼 物 。 其 中 模 仿 三 叉 戟 客 机 的 一 款 销 量 尤 其 高 ， 这 是 什 么 原 因 呢 ？";
			a.data[1] += 50;
			a.data[3] += 100;
		}
		if (result_num == 2)
		{
			text = " 没 有 必 要 研 究 这 种 武 器 ， 我 们 的 战 士 无 比 英 勇 ， 用 无 人 机 的 是 一 等 一 的 孬 种 ！";
			a.data[31] += 50;
			a.data[57] += 50;
		}
	}
}
