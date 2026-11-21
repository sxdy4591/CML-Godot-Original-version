using EventsForDLC;
using UnityEngine;

public class Event61 : EventsSecond
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
		name = " 国 歌 问 题";
		if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ！ 如 你 所 知 ， 自1949 年 以 来 我 们 的 国 歌 一 直 是 由 田 汉 作 词 ， 聂 耳 作 曲 的 《 义 勇 军 进 行 曲 》 。 然 而 ， 在 所 谓 的 “ 文 化 大 革 命 ” 期 间 ， 田 汉 因 诬 告 被 捕 并 死 于 狱 中 ， 歌 颂 已 故 毛 泽 东 主 席 的 流 行 歌 曲 《 东 方 红 》 成 为 了 事 实 上 的 国 歌 。 现 在 ， 当 我 们 终 止 了 “ 文 化 大 革 命 ” ， 并 恢 复 了 田 汉 的 名 誉 ， 以 及 国 家 局 势 的 正 常 化 ， 国 歌 的 问 题 出 现 了 。 一 大 批 党 员 提 议 把 《 义 勇 军 进 行 曲 》 恢 复 为 正 式 的 国 歌 ， 但 是 ， 你 们 的 同 事 在 原 则 上 同 意 这 一 点 ， 但 认 为 应 该 修 改 这 首 歌 的 歌 词 ， 增 加 提 及 毛 主 席 和 中 国 共 产 党 的 段 落 。 这 两 个 选 择 都 需 要 一 笔 预 算 去 调 整 。 与 此 同 时 ， 在 党 内 的 毛 派 激 进 分 子 写 信 给 你 ， 他 们 在 信 中 提 议 正 式 赋 予 东 方 红 国 歌 地 位 。";
		}
		else if (GlobalScript.inst.gameState.modifies[3].active)
		{
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ！ 如 你 所 知 ， 自1949 年 以 来 我 们 的 国 歌 一 直 是 由 田 汉 作 词 ， 聂 耳 作 曲 的 《 义 勇 军 进 行 曲 》 。 然 而 ， 在1968 年 ， 田 汉 因 诬 告 被 捕 并 死 于 狱 中 ， 歌 颂 已 故 毛 泽 东 主 席 的 流 行 歌 曲 《 东 方 红 》 成 为 了 事 实 上 的 国 歌 。 现 在 ， 当 我 们 恢 复 了 田 汉 的 名 誉 ， 以 及 文 革 局 势 的 正 常 化 ， 国 歌 的 问 题 出 现 了 。 一 大 批 党 员 提 议 把 《 义 勇 军 进 行 曲 》 恢 复 为 正 式 的 国 歌 ， 但 是 ， 你 们 的 同 事 在 原 则 上 同 意 这 一 点 ， 但 认 为 应 该 修 改 这 首 歌 的 歌 词 ， 增 加 提 及 毛 主 席 和 中 国 共 产 党 的 段 落 。 这 两 个 选 择 都 需 要 一 笔 预 算 去 调 整 。 与 此 同 时 ， 在 党 内 的 毛 派 激 进 分 子 写 信 给 你 ， 他 们 在 信 中 提 议 正 式 赋 予 东 方 红 国 歌 地 位 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 恢 复 原 版 义 勇 军 进 行 曲 （ 需 要1 百 万 元 预 算 ）";
		if (GlobalScript.inst.gameState.modifies[3].active)
		{
			button_text[1] = " 批 准 《 东 方 红 》 为 国 歌";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 文 化 大 革 命 永 不 翻 案 ！";
		}
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 恢 复 改 词 版 的 《 义 勇 军 进 行 曲 》 （ 需 要1 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 多 此 一 举 ， 毫 无 必 要 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 国 歌 问 题";
		switch (result_num)
		{
		case 0:
		{
			text = " 全 国 人 大 常 委 会 最 后 决 定 恢 复 《 义 勇 军 进 行 曲 》 的 国 歌 地 位 。 同 时 还 通 过 了 规 范 国 歌 使 用 的 法 律 （ 电 台 和 电 视 以 国 歌 开 始 每 天 的 放 送 ， 国 旗 伴 着 国 歌 升 起 ， 人 大 会 议 和 党 的 会 议 开 幕 时 应 奏 唱 国 歌 ） 。 党 和 群 众 对 此 感 到 满 意 。";
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.data[1] += 70;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 1)
				{
					politic2.power += 50;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.power += 50;
				}
			}
			break;
		}
		case 1:
		{
			text = " 今 天 ， 北 京 人 民 广 播 电 台 像 十 年 前 一 样 使 用 《 东 方 红 》 作 为 开 场 曲 目 ， 随 后 的 第 一 条 新 闻 就 是 全 国 人 大 常 委 会 正 式 宣 布 《 东 方 红 》 为 《 中 华 人 民 共 和 国 国 歌 》 ， 总 的 来 说 ， 人 民 对 此 很 高 兴 。 但 是 党 内 一 些 人 批 评 我 们 妄 图 复 刻 “ 极 左 恐 怖 ” ， 美 苏 对 此 也 持 否 定 态 度 ， 但 是 他 们 明 面 上 并 未 说 什 么 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.data[3] += 40;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power += 50;
				}
			}
			break;
		}
		case 2:
			text = " 今 天 ， 北 京 人 民 广 播 电 台 以 《 义 勇 军 进 行 曲 》 开 始 放 送 ， 但 歌 词 却 是 修 改 过 的 ， 歌 词 包 括 “ 伟 大 的 共 产 党 ” 、 “ 共 产 主 义 明 天 ” 、 “ 毛 泽 东 旗 帜 ” 等 。 这 一 版 本 被 批 准 为 中 国 国 歌 。 这 造 成 了 党 内 一 些 不 满 ， 但 是 绝 大 多 数 群 众 都 接 受 了 新 歌 词 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[6] += 5;
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.data[3] += 10;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
