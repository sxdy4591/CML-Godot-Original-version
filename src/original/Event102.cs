using EventsForDLC;
using UnityEngine;

public class Event102 : EventsSecond
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
		name = " 变 革 之 风 ？";
		text = " 来 自 苏 联 的 紧 急 消 息 ！1985 年3 月10 日19 时20 分 ， 苏 共 中 央 总 书 记 康 斯 坦 丁 · 乌 斯 季 诺 维 奇 · 契 尔 年 科 死 于 心 脏 骤 停 。 在 人 民 哀 悼 时 ， 环 绕 新 任 总 书 记 的 竞 争 在 克 里 姆 林 宫 的 长 廊 里 展 开 了 。 候 选 者 有: 米 哈 伊 尔 · 戈 尔 巴 乔 夫 ， 一 位 年 轻 而 可 靠 的 党 员 ， 曾 是 安 德 罗 波 夫 的 人 马 ， 以 改 革 思 维 著 称 。 格 里 戈 里 · 罗 曼 诺 夫 ， 有 活 力 而 适 于 探 索 ， 一 位 年 轻 但 经 验 丰 富 的 管 理 者 ， 曾 是 列 宁 格 勒 州 委 书 记 ， 以 铁 腕 保 证 了 列 宁 格 勒 的 繁 荣 与 经 济 发 展 。 以 及 维 克 托 · 格 里 申 ， 上 个 时 代 政 治 局 的 代 表 ， 保 守 派 的 最 爱 ， 莫 斯 科 市 委 书 记 ， 勃 列 日 涅 夫 对 内 对 外 政 策 的 支 持 者 ， 在 这 些 年 里 在 苏 联 上 下 发 展 了 巨 大 的 关 系 网 （ 以 及 腐 败 网 ） 。| 我 们 要 支 持 谁? 如 果 我 们 能 支 持 的 话 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
		{
			button_text[0] = " 支 持 戈 尔 巴 乔 夫";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
		}
		if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
		{
			button_text[1] = " 支 持 罗 曼 诺 夫";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
		}
		if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
		{
			button_text[2] = " 支 持 格 里 申";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
		}
		button_text[3] = " 不 要 介 入 ， 静 待 结 果";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 变 革 之 风 ？";
		switch (result_num)
		{
		case 0:
			GlobalScript.inst.gameState.empires[1].leaders[6].support += 3;
			GlobalScript.inst.gameState.data[9] -= 100;
			break;
		case 1:
			GlobalScript.inst.gameState.empires[1].leaders[4].support += 3;
			GlobalScript.inst.gameState.data[9] -= 100;
			break;
		case 2:
			GlobalScript.inst.gameState.empires[1].leaders[5].support += 3;
			GlobalScript.inst.gameState.data[9] -= 100;
			break;
		}
		if (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power)
		{
			GlobalScript.inst.gameState.empires[1].leaders[4].support += 2;
		}
		if (GlobalScript.inst.gameState.allcountries[15].Gosstroy == 0 && GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 0)
		{
			GlobalScript.inst.gameState.empires[1].leaders[6].support--;
		}
		if (GlobalScript.inst.gameState.empires[1].leaders[6].support >= GlobalScript.inst.gameState.empires[1].leaders[5].support && GlobalScript.inst.gameState.empires[1].leaders[6].support >= GlobalScript.inst.gameState.empires[1].leaders[4].support)
		{
			text = " 结 果 ， 米 哈 伊 尔 · 戈 尔 巴 乔 夫 被 选 为 苏 共 中 央 委 员 会 总 书 记 。 他 惊 人 地 迅 速 组 织 了 一 次 代 表 大 会 ， 并 通 过 军 机 确 保 政 治 局 成 员 的 顺 利 交 接 ， 而 没 有 让 他 的 对 手 罗 曼 诺 夫 说 任 何 话 。 在 葛 罗 米 柯 和 温 和 派 的 支 持 下 ， 他 以 极 低 的 得 票 率 领 导 了 共 产 党 。 等 待 苏 联 的 是 什 么?";
			GlobalScript.inst.gameState.empires[1].now_leader = 6;
			GlobalScript.inst.gameState.empires[1].power -= 250;
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[4].support >= GlobalScript.inst.gameState.empires[1].leaders[5].support && GlobalScript.inst.gameState.empires[1].leaders[4].support >= GlobalScript.inst.gameState.empires[1].leaders[6].support)
		{
			text = " 结 果 ， 格 里 戈 里 · 罗 曼 诺 夫 被 选 为 苏 共 中 央 委 员 会 总 书 记 ， 他 得 知 契 尔 年 科 的 死 讯 后 ， 立 即 飞 往 莫 斯 科 ， 在 那 里 他 成 功 地 团 结 了 保 守 派 和 温 和 派 人 士 。 有 趣 的 事 等 待 着 苏 联 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 4;
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[5].support + 1 > GlobalScript.inst.gameState.empires[1].leaders[4].support && GlobalScript.inst.gameState.empires[1].leaders[5].support + 1 > GlobalScript.inst.gameState.empires[1].leaders[6].support)
		{
			text = " 结 果 ， 维 克 托 · 格 里 申 当 选 为 苏 共 中 央 委 员 会 总 书 记 。 在 保 守 的 多 数 派 的 支 持 下 ， 他 成 功 地 领 导 了 苏 共 ， 这 没 有 任 何 问 题 。 苏 联 希 望 拥 有 几 年 的 勃 列 日 涅 夫 式 稳 定 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 5;
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[6].support > GlobalScript.inst.gameState.empires[1].leaders[4].support)
		{
			text = " 尽 管 有 很 多 争 论 ， 结 果 ， 米 哈 伊 尔 · 戈 尔 巴 乔 夫 被 选 为 苏 共 中 央 委 员 会 总 书 记 。 他 惊 人 地 迅 速 组 织 了 一 次 代 表 大 会 ， 并 通 过 军 机 确 保 政 治 局 成 员 的 顺 利 交 接 ， 而 没 有 让 他 的 对 手 罗 曼 诺 夫 说 任 何 话 。 在 葛 罗 米 柯 和 温 和 派 的 支 持 下 ， 他 以 极 低 的 得 票 率 领 导 了 共 产 党 。 等 待 苏 联 的 是 什 么?";
			GlobalScript.inst.gameState.empires[1].now_leader = 6;
			GlobalScript.inst.gameState.empires[1].power -= 250;
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[6].support < GlobalScript.inst.gameState.empires[1].leaders[4].support)
		{
			text = " 尽 管 有 很 多 争 论 ， 结 果 ， 格 里 戈 里 · 罗 曼 诺 夫 被 选 为 苏 共 中 央 委 员 会 总 书 记 ， 他 得 知 契 尔 年 科 的 死 讯 后 ， 立 即 飞 往 莫 斯 科 ， 在 那 里 他 成 功 地 团 结 了 保 守 派 和 温 和 派 人 士 。 有 趣 的 事 等 待 着 苏 联 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 4;
		}
		else
		{
			text = " 尽 管 有 很 多 争 议 ， 结 果 ， 维 克 托 · 格 里 申 当 选 为 苏 共 中 央 委 员 会 总 书 记 。 在 保 守 的 多 数 派 的 支 持 下 ， 他 成 功 地 领 导 了 苏 共 ， 这 没 有 任 何 问 题 。 苏 联 预 期 将 拥 有 几 年 的 勃 列 日 涅 夫 式 稳 定 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 5;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
