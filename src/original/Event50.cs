using EventsForDLC;
using UnityEngine;

public class Event50 : EventsSecond
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
		name = " 穷 山 恶 水";
		text = " 在 最 近 导 致 阿 富 汗 局 势 恶 化 的 事 件 之 后 ， 美 国 支 持 的 伊 斯 兰 主 义 者 和 其 他 反 动 派 的 长 期 起 义 进 入 了 白 热 化 阶 段 。 根 据 最 近 通 过 的 计 划 ， 苏 联 应 民 主 共 和 国 政 府 的 要 求 向 阿 富 汗 增 兵 ， 这 已 经 在 西 方 引 起 了 一 波 愤 怒 。 尽 管 民 众 最 初 与 苏 联 军 队 的 接 触 相 当 友 好 ， 但 对 他 们 的 武 装 分 子 袭 击 事 件 却 越 来 越 频 繁 。 与 此 同 时 ， 最 初 只 包 括 保 护 重 要 目 标 的 有 限 分 遣 队 的 任 务 正 在 逐 步 扩 大 ， 而 且 似 乎 最 终 将 充 分 参 与 敌 对 行 动 。 阿 富 汗 战 争 已 经 开 始 ， 我 们 需 要 决 定 我 们 将 支 持 谁 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 谁 都 不 管 ， 这 可 不 关 我 们 的 事";
		if (GlobalScript.inst.gameState.relres)
		{
			button_text[1] = " 援 助 阿 富 汗 民 主 共 和 国 ， 交 换 条 件 是 将 毛 派 政 党 纳 入 与 人 民 民 主 党 的 联 盟";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 苏 联 不 允 许 我 们 进 行 如 此 深 入 的 介 入";
		}
		button_text[2] = " 援 助 阿 富 汗 民 主 共 和 国";
		button_text[3] = " 援 助 毛 主 义 起 义 者";
		button_text[4] = " 向 武 装 反 对 派 出 售 枪 支 ， 美 国 人 愿 意 为 之 付 钱";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 穷 山 恶 水";
		GlobalScript.inst.gameState.allcountries[12].Vyshi = false;
		switch (result_num)
		{
		case 0:
			text = " 我 们 决 定 不 参 与 阿 富 汗 事 务 。 与 此 同 时 ， 在 这 个 国 家 ， 内 战 正 如 火 如 荼 般 的 进 行 着 ， 没 有 人 能 预 料 到 战 争 的 结 果 。";
			GlobalScript.inst.gameState.ingamewars[5].name_war = " 阿 富 汗 内 战";
			GlobalScript.inst.gameState.ingamewars[5].is_going = true;
			GlobalScript.inst.gameState.ingamewars[5].side1 = " 阿 富 汗 民 主 共 和 国";
			GlobalScript.inst.gameState.ingamewars[5].side2 = " 圣 战 者";
			GlobalScript.inst.gameState.ingamewars[5].ussr_place = 0;
			GlobalScript.inst.gameState.ingamewars[5].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[5].infl1 = 750;
			GlobalScript.inst.gameState.ingamewars[5].infl2 = 250;
			if (GlobalScript.inst.gameState.allcountries[31].Vyshi)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 100;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 100;
			}
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 50;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 50;
			}
			if (GlobalScript.inst.gameState.data[107] == 9)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 += 25;
				GlobalScript.inst.gameState.ingamewars[5].infl2 -= 25;
			}
			break;
		case 1:
			text = " 由 于 我 们 与 苏 联 的 关 系 ， 我 们 能 够 与 阿 富 汗 民 主 共 和 国 谈 判 。 为 了 换 取 我 们 的 支 持 ， 他 们 停 止 了 对 前 反 对 派 毛 派 的 迫 害 ， 并 与 他 们 组 成 了 一 个 对 抗 伊 斯 兰 主 义 和 美 帝 国 主 义 的 进 步 力 量 联 盟 ， 只 要 毛 派 自 己 放 下 武 器 （ 他 们 不 情 愿 ， 但 同 意 了 ） 。 这 是 我 们 的 外 交 胜 利 ！ 与 此 同 时 ， 在 这 个 国 家 ， 内 战 正 如 火 如 荼 般 的 进 行 着 ， 没 有 人 能 预 料 到 战 争 的 结 果 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[46] = 80;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 250;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.ingamewars[5].name_war = " 阿 富 汗 内 战";
			GlobalScript.inst.gameState.ingamewars[5].is_going = true;
			GlobalScript.inst.gameState.ingamewars[5].side1 = " 阿 富 汗 民 主 共 和 国";
			GlobalScript.inst.gameState.ingamewars[5].side2 = " 圣 战 者";
			GlobalScript.inst.gameState.ingamewars[5].ussr_place = 0;
			GlobalScript.inst.gameState.ingamewars[5].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[5].infl1 = 770;
			GlobalScript.inst.gameState.ingamewars[5].infl2 = 230;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 30;
			if (GlobalScript.inst.gameState.allcountries[31].Vyshi)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 100;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 100;
			}
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 50;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 50;
			}
			if (GlobalScript.inst.gameState.data[107] == 9)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 += 25;
				GlobalScript.inst.gameState.ingamewars[5].infl2 -= 25;
			}
			break;
		case 2:
			text = " 在 政 治 局 进 行 了 长 时 间 的 讨 论 后 ， 个 别 党 员 顽 固 地 抗 议 支 持 亲 苏 的 阿 富 汗 民 主 共 和 国 政 权 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 仍 然 坚 持 支 持 阿 富 汗 民 主 共 和 国 的 策 略 （ 至 少 是 口 头 上 ） ， 这 样 的 话 他 们 绝 对 不 会 介 意 。 与 此 同 时 ， 在 这 个 国 家 ， 内 战 正 如 火 如 荼 般 的 进 行 着 ， 没 有 人 能 预 料 到 战 争 的 结 果 。";
			GlobalScript.inst.gameState.data[1] -= 70;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 300;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.ingamewars[5].name_war = " 阿 富 汗 内 战";
			GlobalScript.inst.gameState.ingamewars[5].is_going = true;
			GlobalScript.inst.gameState.ingamewars[5].side1 = " 阿 富 汗 民 主 共 和 国";
			GlobalScript.inst.gameState.ingamewars[5].side2 = " 圣 战 者";
			GlobalScript.inst.gameState.ingamewars[5].ussr_place = 0;
			GlobalScript.inst.gameState.ingamewars[5].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[5].infl1 = 760;
			GlobalScript.inst.gameState.ingamewars[5].infl2 = 240;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 20;
			if (GlobalScript.inst.gameState.allcountries[31].Vyshi)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 100;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 100;
			}
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 50;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 50;
			}
			if (GlobalScript.inst.gameState.data[107] == 9)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 += 25;
				GlobalScript.inst.gameState.ingamewars[5].infl2 -= 25;
			}
			break;
		case 3:
			text = " 由 于 担 心 苏 联 势 力 的 扩 大 ， 我 们 决 定 支 持 阿 富 汗 的 毛 派 组 织 同 民 主 共 和 国 和 伊 斯 兰 主 义 者 进 行 武 装 斗 争 。 当 然 ， 无 论 是 苏 联 还 是 美 国 都 不 喜 欢 这 样 ， 而 且 阿 富 汗 毛 主 义 者 并 不 代 表 着 一 支 特 别 强 大 的 力 量 ， 所 以 我 们 的 许 多 力 量 将 被 派 去 支 持 他 们 … … 与 此 同 时 ， 在 这 个 国 家 ， 内 战 正 如 火 如 荼 般 的 进 行 着 ， 没 有 人 能 预 料 到 战 争 的 结 果 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.empires[1].power -= 30;
			GlobalScript.inst.gameState.data[6] += 30;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.ingamewars[5].name_war = " 阿 富 汗 毛 派 起 义";
			GlobalScript.inst.gameState.ingamewars[5].is_going = true;
			GlobalScript.inst.gameState.ingamewars[5].side1 = " 毛 派";
			GlobalScript.inst.gameState.ingamewars[5].side2 = " 联 合 反 对 派";
			GlobalScript.inst.gameState.ingamewars[5].ussr_place = 1;
			GlobalScript.inst.gameState.ingamewars[5].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[5].infl1 = 50;
			GlobalScript.inst.gameState.ingamewars[5].infl2 = 950;
			break;
		case 4:
			text = " 后 来 ， 美 中 以 “ 发 展 经 贸 合 作 ” 为 名 ， 出 人 意 料 地 迅 速 举 行 峰 会 ， 但 实 际 目 的 完 全 不 同 。 在 秘 密 谈 判 中 ， 美 国 代 表 团 向 中 国 提 供 了 一 份 购 买 武 器 的 合 同 ， 并 将 这 些 武 器 越 过 中 国 边 境 运 送 到 邻 国 阿 富 汗 ， 以 支 持 圣 战 者 反 对 苏 联 侵 略 ， 并 对 阿 富 汗 民 主 共 和 国 伪 政 权 造 成 强 力 打 击 。 中 方 接 受 了 美 方 的 建 议 ， 第 一 批 武 器 计 划 在 未 来 三 个 月 内 部 署 ， 但 我 们 只 会 从 中 受 益 ， 我 们 的 成 本 将 由 我 们 的 新 战 略 盟 友 承 担 。";
			GlobalScript.inst.gameState.empires[1].power -= 30;
			GlobalScript.inst.gameState.ingamewars[5].name_war = " 阿 富 汗 内 战";
			GlobalScript.inst.gameState.ingamewars[5].is_going = true;
			GlobalScript.inst.gameState.ingamewars[5].side1 = " 阿 富 汗 民 主 共 和 国";
			GlobalScript.inst.gameState.ingamewars[5].side2 = " 圣 战 者";
			GlobalScript.inst.gameState.ingamewars[5].ussr_place = 0;
			GlobalScript.inst.gameState.ingamewars[5].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[5].infl1 = 700;
			GlobalScript.inst.gameState.ingamewars[5].infl2 = 300;
			GlobalScript.inst.gameState.data[8] += 50;
			GlobalScript.inst.gameState.empires[0].relations += 200;
			GlobalScript.inst.gameState.empires[1].relations -= 200;
			if (GlobalScript.inst.gameState.allcountries[31].Vyshi)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 100;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 100;
			}
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 50;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 50;
			}
			if (GlobalScript.inst.gameState.data[107] == 9)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 += 25;
				GlobalScript.inst.gameState.ingamewars[5].infl2 -= 25;
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
