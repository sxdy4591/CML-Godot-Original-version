using EventsForDLC;
using UnityEngine;

public class Event30 : EventsSecond
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
		name = " 冲 突 结 束 ？";
		text = " 自 从1948 年 以 色 列 在 前 英 属 巴 勒 斯 坦 领 土 上 建 国 以 来 ， 那 里 的 阿 拉 伯 人 民 实 际 上 被 剥 夺 了 自 决 权 ， 受 到 以 色 列 当 局 的 歧 视 ， 他 们 为 摧 毁 以 色 列 和 在 巴 勒 斯 坦 建 立 一 个 阿 拉 伯 国 家 而 战 斗 ， 他 们 得 到 阿 拉 伯 邻 国 的 支 持 。 这 一 切 导 致 了 几 场 中 东 战 争 ， 巴 勒 斯 坦 解 放 组 织 不 断 炮 击 ， 对 以 色 列 进 行 恐 怖 袭 击 ， 以 色 列 军 队 也 予 以 回 击 。 最 后 一 次 是 在 黎 巴 嫩 ， 以 色 列 完 全 失 败 ， 甚 至 没 有 得 到 美 国 的 支 持 ， 现 在 以 色 列 准 备 与 巴 解 组 织 就 巴 勒 斯 坦 人 的 地 位 进 行 谈 判 ， 我 们 可 以 在 谈 判 中 充 当 中 间 人 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 提 出 在 巴 勒 斯 坦 建 立 阿 拉 伯 国";
		button_text[1] = " 提 出 在 进 一 步 解 决 危 机 前 建 立 阿 拉 伯 人 自 治 区";
		button_text[2] = " 建 议 建 立 阿 拉 伯 人 与 犹 太 人 的 联 合 国 家";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 冲 突 结 束 ？";
		switch (result_num)
		{
		case 0:
			if (GlobalScript.inst.gameState.influencePRC >= 150)
			{
				text = " 会 谈 结 束 后 ， 巴 解 组 织 领 导 人 亚 西 尔 · 阿 拉 法 特 同 意 停 止 恐 怖 袭 击 ， 谴 责 恐 怖 分 子 ， 并 承 认 以 色 列 的 生 存 权 ， 以 色 列 则 同 意 在 约 旦 河 西 岸 、 加 沙 和 东 耶 路 撒 冷 大 部 分 地 区 逐 步 建 立 巴 勒 斯 坦 国 （ 尽 管 后 者 的 问 题 仍 然 是 激 烈 辩 论 的 议 题 ） 同 时 以 色 列 军 队 将 逐 渐 撤 出 上 述 区 域 。 许 多 激 进 的 阿 拉 伯 组 织 称 这 一 协 议 为 背 叛 ， 并 决 定 继 续 斗 争 直 到 以 色 列 彻 底 毁 灭 。 然 而 ， 这 是 阿 拉 伯 世 界 的 一 次 伟 大 胜 利 ， 也 标 志 着 阿 拉 伯 世 界 与 以 色 列 关 系 正 常 化 的 开 始 。";
				GlobalScript.inst.gameState.influencePRC += 10;
				GlobalScript.inst.gameState.empires[1].relations += 100;
				GlobalScript.inst.gameState.empires[0].relations -= 50;
				GlobalScript.inst.gameState.data[85] = 2;
				GlobalScript.inst.gameState.allcountries[37].Vyshi = false;
			}
			else
			{
				text = " 尽 管 我 们 作 出 了 所 有 努 力 ， 但 各 方 未 能 达 成 妥 协 ， 我 们 的 建 议 遭 到 拒 绝 ， 谈 判 失 败 。 新 一 轮 的 暴 力 似 乎 即 将 开 始 。";
				GlobalScript.inst.gameState.empires[0].relations -= 100;
				GlobalScript.inst.gameState.influencePRC -= 20;
				GlobalScript.inst.gameState.data[1] -= 100;
			}
			break;
		case 1:
			text = " 会 谈 结 束 后 ， 巴 解 组 织 领 导 人 亚 西 尔 · 阿 拉 法 特 同 意 停 止 恐 怖 袭 击 ， 谴 责 恐 怖 分 子 ， 并 承 认 以 色 列 的 生 存 权 ， 而 以 色 列 则 同 意 建 立 一 个 以 西 岸 和 加 沙 地 带 为 基 础 的 巴 勒 斯 坦 国 政 府 ， 该 政 府 将 在 巴 勒 斯 坦 阿 拉 伯 人 的 地 位 得 到 确 定 之 前 执 行 自 治 权 ， 至 于 阿 拉 伯 人 的 地 位 则 将 在5 年 内 决 定 。 许 多 激 进 的 阿 拉 伯 组 织 称 这 一 协 议 为 背 叛 ， 并 决 定 继 续 斗 争 直 到 以 色 列 彻 底 毁 灭 。 然 而 ， 我 们 希 望 这 些 协 议 最 终 能 够 解 决 冲 突 。";
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.data[85] = 1;
			break;
		case 2:
			if (GlobalScript.inst.gameState.influencePRC >= 200 && GlobalScript.inst.gameState.OAR)
			{
				text = " 会 谈 结 束 后 ， 巴 解 组 织 领 导 人 亚 西 尔 · 阿 拉 法 特 同 意 停 止 恐 怖 袭 击 ， 谴 责 恐 怖 主 义 分 子 ， 并 承 认 以 色 列 的 生 存 权 利 。 然 而 ， 会 谈 达 成 的 进 一 步 的 进 展 完 全 出 乎 了 世 界 各 国 的 意 料 — — 双 方 同 意 建 立 一 个 巴 勒 斯 坦 和 以 色 列 之 间 的 联 合 国 家 ， 该 国 将 组 织 联 合 的 军 队 ， 行 政 语 言 双 语 化 ， 实 施 广 泛 的 地 方 自 治 和 坚 定 的 外 交 中 立 。 目 前 ， 部 分 激 进 的 组 织 称 这 是 一 种 背 叛 ， 但 大 多 数 人 决 定 停 止 进 行 恐 怖 袭 击 。 当 然 ， 建 立 一 个 新 的 国 家 本 身 将 是 困 难 的 ， 同 时 还 有 许 多 冲 突 有 待 解 决 ， 但 建 立 一 个 新 国 家 的 决 定 本 身 就 表 明 双 方 朝 着 期 待 已 久 的 和 平 迈 出 了 坚 定 的 步 伐 。";
				GlobalScript.inst.gameState.influencePRC += 30;
				GlobalScript.inst.gameState.empires[0].relations -= 50;
				GlobalScript.inst.gameState.empires[1].relations += 100;
				GlobalScript.inst.gameState.data[85] = 3;
				GlobalScript.inst.gameState.allcountries[37].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[37].proprc = true;
				GlobalScript.inst.gameState.allcountries[37].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
				GlobalScript.inst.gameState.allcountries[37].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
				if (PlayerPrefs.GetInt("language") == 0)
				{
					GlobalScript.inst.gameState.allcountries[37].name = " 巴 以 联 盟 国 家";
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[37].name = "Союзное Гос-во";
				}
			}
			else
			{
				text = " 尽 管 我 们 作 出 了 所 有 努 力 ， 但 各 方 未 能 达 成 妥 协 ， 我 们 的 建 议 遭 到 拒 绝 ， 谈 判 失 败 。 新 一 轮 的 暴 力 似 乎 即 将 开 始 。";
				GlobalScript.inst.gameState.empires[0].relations -= 100;
				GlobalScript.inst.gameState.influencePRC -= 20;
				GlobalScript.inst.gameState.data[1] -= 100;
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
