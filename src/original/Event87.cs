using EventsForDLC;
using UnityEngine;

public class Event87 : EventsSecond
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
		name = " 加 利 利 的 和 平";
		text = " 由 于 黎 巴 嫩 领 导 层 的 软 弱 ， 自1975 年 以 来 内 战 一 直 在 黎 巴 嫩 境 内 继 续 ， 再 加 上 阿 拉 伯 国 家 的 积 极 援 助 ， 使 得 巴 勒 斯 坦 解 放 组 织 能 够 在 黎 巴 嫩 南 部 部 署 一 个 不 受 政 府 控 制 的 与 以 色 列 作 战 的 据 点 。 双 方 不 断 地 相 互 开 火 ， 但 现 在 冲 突 似 乎 进 入 了 白 热 化 阶 段 。6 月3 日 ， 以 色 列 大 使 在 伦 敦 遇 刺 （ 结 果 ， 其 实 是 另 一 个 巴 勒 斯 坦 组 织 对 此 负 有 责 任 ， 与 巴 解 组 织 没 有 任 何 关 系 ） ， 这 成 为 以 色 列 大 规 模 轰 炸 黎 巴 嫩 的 借 口 ，6 月6 日 ， 以 色 列 军 队 越 过 黎 巴 嫩 边 界 ， 与 巴 解 组 织 的 军 队 激 战 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 另 一 场 在 中 东 的 战 争 …";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 加 利 利 的 和 平";
		if (result_num == 0)
		{
			text = " 以 色 列 宣 布 开 始 “ 加 利 利 和 平 行 动 ” ， 据 以 色 列 代 表 称 ， 这 项 行 动 的 目 的 是 消 灭 巴 解 组 织 的 基 地 ， 并 在 黎 巴 嫩 南 部 建 立 一 个 非 军 事 区 。 以 色 列 已 经 宣 布 ， 它 不 会 攻 击 叙 利 亚 在 黎 巴 嫩 的 武 装 部 队 ， 而 叙 利 亚 本 身 也 在 避 免 战 斗 ， 但 鉴 于 叙 利 亚 控 制 了 黎 巴 嫩 的 大 部 分 地 区 ， 他 们 与 以 色 列 国 防 军 之 间 的 冲 突 似 乎 只 是 时 间 问 题 。 值 得 注 意 的 是 ， 传 统 上 支 持 以 色 列 的 美 国 反 应 相 当 克 制 ， 并 没 有 特 别 欣 赏 其 “ 维 和 ” 的 冲 动 。";
			GlobalScript.inst.gameState.ingamewars[4].name_war = " 黎 巴 嫩 战 争";
			GlobalScript.inst.gameState.ingamewars[4].is_going = true;
			GlobalScript.inst.gameState.ingamewars[4].side1 = " 以 色 列";
			GlobalScript.inst.gameState.ingamewars[4].side2 = " 巴 解 组 织";
			GlobalScript.inst.gameState.ingamewars[4].ussr_place = 1;
			GlobalScript.inst.gameState.ingamewars[4].usa_place = 0;
			GlobalScript.inst.gameState.ingamewars[4].infl1 = 650;
			GlobalScript.inst.gameState.ingamewars[4].infl2 = 350;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
