using EventsForDLC;
using UnityEngine;

public class Event82 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 福 克 兰 群 岛 战 争";
		text = " 英 国 最 近 正 在 经 历 困 难 时 刻 ， 失 去 了 它 曾 经 显 赫 的 影 响 力 。 由 莱 奥 波 尔 多 · 加 尔 铁 里 领 导 的 阿 根 廷 军 政 府 决 定 利 用 这 一 机 会 发 动 “ 小 规 模 胜 利 战 争 ” 。4 月2 日 ， 阿 根 廷 伞 兵 登 陆 英 属 福 克 兰 群 岛 ， 群 岛 的 归 属 长 期 受 阿 根 廷 挑 战 ， 但 小 规 模 英 国 驻 军 的 抵 抗 很 快 就 被 击 溃 了 。 作 为 回 应 ， 英 国 向 群 岛 派 出 舰 队 ， 意 在 封 锁 群 岛 。 看 起 来 世 界 上 又 要 爆 发 新 的 冲 突 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 谁 会 赢 ？ 阿 根 廷 的 军 政 府 ， 还 是 虚 弱 而 遥 远 的 英 国 ？";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 福 克 兰 群 岛 战 争";
		if (result_num == 0)
		{
			text = "4 月3 日 ， 联 合 国 安 理 会 通 过 了 第502 号 决 议 ， 要 求 阿 根 廷 军 队 撤 出 这 些 岛 屿 ， 但 尽 管 如 此 ， 似 乎 没 有 人 相 信 英 国 会 胜 利 。 但 也 许 为 了 再 次 打 击 殖 民 主 义 的 目 的 ， 我 们 应 该 帮 助 阿 根 廷 ， 即 使 那 里 当 道 的 是 残 忍 的 反 共 独 裁 者 ？";
			GlobalScript.inst.gameState.ingamewars[6].name_war = " 福 克 兰 群 岛 战 争";
			GlobalScript.inst.gameState.ingamewars[6].is_going = true;
			GlobalScript.inst.gameState.ingamewars[6].side1 = " 阿 根 廷";
			GlobalScript.inst.gameState.ingamewars[6].side2 = " 联 合 王 国";
			GlobalScript.inst.gameState.ingamewars[6].ussr_place = -1;
			GlobalScript.inst.gameState.ingamewars[6].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[6].infl1 = 400;
			GlobalScript.inst.gameState.ingamewars[6].infl2 = 600;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
