using EventsForDLC;
using UnityEngine;

public class Event100 : EventsSecond
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
		name = " 政 府 危 机";
		text = " 在 没 完 没 了 的 政 变 后 ， 孟 加 拉 国 的 军 权 暂 时 稳 定 了 ， “ 元 老 ” 侯 赛 因 · 穆 罕 默 德 · 艾 尔 沙 德 成 功 拿 下 总 统 宝 座 。 在 两 年 的 右 翼 独 裁 政 权 下 ， 针 对 自 由 派 和 社 会 主 义 者 的 大 规 模 压 迫 开 始 了 ， 他 们 大 部 分 都 是 左 翼 党 派 人 民 联 盟 的 成 员 。 同 时 ， 国 内 耕 者 无 其 田 与 高 层 权 力 腐 败 始 终 没 解 决 。 由 此 ， 难 对 付 的 反 政 府 示 威 在 全 国 开 始 了 ， 诉 求 之 一 就 是 启 动 大 选 程 序 。 依 我 之 见 如 果 我 们 支 持 努 力 改 善 对 华 关 系 的 政 府 ， 我 们 就 能 稳 定 东 南 亚 的 政 变 温 床 ， 但 是 如 果 我 们 能 更 激 烈 地 催 化 示 威 并 组 织 反 对 派 对 抗 艾 尔 沙 德 ， 忠 诚 于 我 们 的 人 就 能 掌 权 ， 但 是 全 世 界 会 怎 么 看? 还 是 我 们 干 脆 不 要 介 入 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.influencePRC >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[0] = " 通 过 支 持 反 对 派 来 煽 动 反 政 府 集 会";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 足 够 的 力 量";
		}
		button_text[1] = " 我 们 在 国 内 有 自 己 的 问 题";
		if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 拨 款 支 持 政 府";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 能 支 持 他 们";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 政 府 危 机";
		switch (result_num)
		{
		case 0:
			text = " 由 于 我 们 的 情 报 部 门 的 协 调 工 作 ， 关 于 由 于 不 断 增 长 的 金 融 危 机 会 引 起 裁 员 和 工 资 下 降 的 谣 言 在 孟 加 拉 国 首 都 的 几 个 最 大 的 工 厂 传 播 开 来 。 就 在 第 二 天 ， 整 个 城 市 因 罢 工 和 工 人 与 武 装 警 察 之 间 的 冲 突 而 陷 入 瘫 痪 ， 一 些 地 区 还 听 到 枪 声 。 然 而 ， 由 于 公 众 的 压 力 和 不 断 增 长 的 动 乱 ， 总 统 不 得 不 宣 布 提 前 举 行 议 会 选 举 ， 在 我 们 的 帮 助 下 ， 左 翼 联 盟 赢 得 了 选 举 ， 谢 赫 · 哈 西 娜 · 瓦 吉 德 成 为 了 新 总 理 。 新 一 届 政 府 宣 布 启 动 经 济 社 会 改 革 ， 扩 大 中 孟 贸 易 。 总 的 来 说 ， 国 际 社 会 忽 视 了 政 府 的 更 迭 ， 但 美 国 怀 疑 我 们 参 与 了 这 一 事 件 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 70;
			GlobalScript.inst.gameState.allcountries[32].proprc = true;
			GlobalScript.inst.gameState.allcountries[32].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[32].Torg = true;
			GlobalScript.inst.gameState.allcountries[32].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[32].SubGosstroy = 3;
			break;
		case 1:
			text = " 孟 加 拉 国 政 府 继 续 控 制 局 势 ， 及 时 镇 压 了 罢 工 。";
			break;
		case 2:
			text = " 艾 尔 沙 德 总 统 感 谢 我 们 的 帮 助 ， 并 建 议 在 中 国 和 孟 加 拉 国 之 间 举 行 一 次 关 于 扩 大 贸 易 和 经 济 合 作 的 峰 会 。 在 谈 判 中 ， 两 国 关 系 得 到 恢 复 ， 中 国 正 式 承 认 孟 加 拉 国 脱 离 巴 基 斯 坦 独 立 ， 并 签 署 了 新 的 贸 易 合 同 。";
			GlobalScript.inst.gameState.data[8] -= 80;
			GlobalScript.inst.gameState.allcountries[32].Torg = true;
			GlobalScript.inst.gameState.empires[1].relations -= 70;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
