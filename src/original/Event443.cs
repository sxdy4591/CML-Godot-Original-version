using EventsForDLC;
using UnityEngine;

public class Event443 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 收 复 藏 南 ！";
		text = " 我 们 最 终 结 束 了 与 印 度 长 期 存 在 的 领 土 争 端 — — 我 们 对 印 度 迅 速 而 具 有 决 定 性 的 特 别 军 事 行 动 使 得 藏 南 地 区 （ 即 伪 阿 鲁 纳 恰 尔 邦 ） 完 整 的 回 归 中 国 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 庆 祝 藏 南 的 回 归 ！ ";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 收 复 藏 南 ！";
		if (result_num == 0)
		{
			text = " 在 解 放 军 的 猛 烈 攻 势 下 ， 印 度 军 队 终 究 没 能 守 得 住 战 线 ， 开 始 溃 退 。 解 放 军 在 挺 进 到 地 图 上 的 国 境 线 后 便 不 再 有 大 规 模 军 事 行 动 ， 而 是 开 通 新 的 稳 定 补 给 路 线 。 印 度 东 北 部 地 区 则 出 现 了 大 规 模 的 叛 乱 ， 印 度 因 此 忙 于 平 叛 ， 无 暇 顾 及 藏 南 地 区 。 由 于 这 次 印 军 的 失 利 ， 该 届 印 度 政 府 垮 台 ， 新 一 届 的 印 度 政 府 开 始 进 一 步 反 华 ， 更 加 亲 美 亲 苏 ， 与 美 苏 订 立 了 更 多 的 军 事 订 单 ， 可 能 会 在 中 印 边 境 开 展 新 一 轮 的 边 境 冲 突 ...... ";
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			GlobalScript.inst.gameState.empires[1].power -= 100;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.CBIndia = false;
		}
	}
}
