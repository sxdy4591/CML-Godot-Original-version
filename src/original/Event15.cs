using EventsForDLC;
using UnityEngine;

public class Event15 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 柬 越 战 争";
		text = " 越 共 对 印 度 支 那 地 区 的 共 产 主 义 运 动 一 直 存 在 “ 老 子 党 ” 情 结 — — 老 挝 党 和 早 期 的 柬 埔 寨 党 一 直 都 处 于 越 南 的 控 制 之 下 。 而 高 棉 劳 动 党 在 重 建 以 来 一 直 在 执 行 独 立 路 线 ， 和 “ 听 话 的 ” 老 挝 截 然 不 同 ， 这 令 越 南 很 不 高 兴 — — 越 共 一 直 想 恢 复 对 柬 埔 寨 共 产 党 的 控 制 ， 建 立 一 个 统 一 的 社 会 主 义 印 支 。 看 起 来 越 南 的 耐 心 也 到 头 了 — — 最 近 越 南 军 队 对 柬 埔 寨 发 起 了 全 面 侵 略 ， 以 推 翻 民 主 柬 埔 寨 政 权 ， 利 用 包 括 高 棉 左 翼 异 见 者 和 流 亡 的 亲 越 派 的 柬 埔 寨 民 族 救 亡 阵 线 作 为 掩 盖 。 考 虑 到 民 主 柬 埔 寨 一 直 是 我 们 忠 实 的 盟 友 ， 帮 助 他 们 是 值 得 的 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 我 们 无 能 为 力";
		if (((GlobalScript.inst.gameState.data[56] < 2 || GlobalScript.inst.gameState.data[56] > 3) && GlobalScript.inst.gameState.allcountries[23].stab == 1) || (GlobalScript.inst.gameState.data[56] >= 1 && GlobalScript.inst.gameState.data[56] <= 3 && GlobalScript.inst.gameState.allcountries[23].stab != 1))
		{
			button_text[1] = " 支 持 民 主 柬 埔 寨";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 人 愿 意 帮 助 他 们";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 柬 埔 寨 － 越 南 战 争";
		GlobalScript.inst.gameState.ingamewars[1].name_war = " 柬 埔 寨 － 越 南 战 争";
		GlobalScript.inst.gameState.ingamewars[1].is_going = true;
		GlobalScript.inst.gameState.ingamewars[1].side1 = " 柬 埔 寨";
		GlobalScript.inst.gameState.ingamewars[1].side2 = " 越 南";
		GlobalScript.inst.gameState.ingamewars[1].ussr_place = 1;
		switch (result_num)
		{
		case 0:
			if (GlobalScript.inst.gameState.allcountries[23].stab != 1)
			{
				text = " 我 们 决 定 不 介 入 这 场 冲 突 。 波 尔 布 特 和 红 色 高 棉 领 导 人 当 然 对 此 非 常 不 满 ， 但 他 们 似 乎 也 活 不 了 多 久 了 — — 越 南 军 队 行 动 迅 速 ， 柬 埔 寨 士 兵 开 始 集 体 叛 逃 。 波 尔 布 特 政 权 的 垮 台 似 乎 只 是 个 时 间 问 题 。";
			}
			else if (GlobalScript.inst.gameState.allcountries[23].stab == 1)
			{
				text = " 我 们 决 定 不 介 入 这 场 冲 突 。 民 主 柬 埔 寨 领 导 人 当 然 对 此 非 常 不 满 ， 但 他 们 似 乎 也 坚 持 不 了 多 久 — — 柬 埔 寨 的 经 济 仍 未 从 战 后 恢 复 过 来 ， 也 并 没 有 太 多 的 资 源 和 产 业 能 用 于 抵 抗 越 南 的 侵 略 。";
			}
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.ingamewars[1].infl1 = 300;
			GlobalScript.inst.gameState.ingamewars[1].infl2 = 700;
			break;
		case 1:
			text = " 我 们 决 定 对 我 们 的 老 朋 友 民 主 柬 埔 寨 提 供 支 持 。 双 方 之 间 的 战 争 仍 在 进 行 ， 越 南 和 苏 联 对 我 们 的 行 动 并 不 满 意 ， 他 们 很 可 能 会 加 强 合 作 并 损 害 我 们 的 利 益 。";
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.ingamewars[1].infl1 = 450;
			GlobalScript.inst.gameState.ingamewars[1].infl2 = 550;
			party_change[2] = 1f;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
