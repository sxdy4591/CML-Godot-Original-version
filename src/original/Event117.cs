using EventsForDLC;
using UnityEngine;

public class Event117 : EventsSecond
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
		name = " 五 年 修 葬";
		text = " 来 自 苏 联 的 消 息 — — 二 月 九 日 ， 苏 共 中 央 总 书 记 尤 里 · 安 德 罗 波 夫 因 肾 衰 去 世 ， 享 年69 岁 。 自1983 年 末 他 已 病 魔 缠 身 ， 在 克 里 米 亚 感 的 冒 终 于 带 走 了 他 。 任 期 内 ， 安 德 罗 波 夫 非 常 关 心 苏 联 经 济 的 改 善 — — 一 场 加 强 劳 动 纪 律 的 运 动 开 始 了 ， 经 济 流 通 中 的 非 法 瞒 报 被 大 规 模 打 击 。 同 时 ， 安 德 罗 波 夫 积 极 提 拔 年 轻 的 改 革 家 并 要 求 戈 尔 巴 乔 夫 、 雷 日 科 夫 、 阿 巴 尔 金 、 多 尔 吉 赫 准 备 苏 联 境 内 大 规 模 的 经 济 改 革 计 划 。 有 鉴 于 愈 发 激 烈 的 政 治 斗 争 ， 妥 协 者 契 尔 年 科 很 有 可 能 会 接 过 总 书 记 的 职 位 。2 月14 日 预 定 举 行 安 德 罗 波 夫 的 葬 礼 ， 各 国 代 表 估 计 都 要 来 露 个 脸 ， 不 管 是 苏 联 的 盟 国 还 是 别 的 。 那 么 ， 我 们 要 做 什 么 呢?";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (!GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[0] = " 什 么 都 不 做 ， 我 们 没 有 被 邀 请";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 必 须 去";
		}
		if (GlobalScript.inst.gameState.relres || GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[1] = " 派 遣 中 国 代 表 团 参 加 葬 礼";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 人 会 让 我 们 进 去";
		}
		if (GlobalScript.inst.gameState.relres || GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[2] = " 我 们 的 领 导 人 将 亲 自 去 和 尤 里 · 弗 拉 基 米 罗 维 奇 告 别";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 你 不 能 亲 自 去!";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 五 年 修 葬";
		switch (result_num)
		{
		case 0:
			text = " 安 德 罗 波 夫 的 葬 礼 于1984 年2 月14 日12 点 在 莫 斯 科 红 场 克 里 姆 林 宫 附 近 举 行 。 多 国 国 家 元 首 和 政 府 首 脑 出 席 了 葬 礼 及 告 别 仪 式 。 ";
			GlobalScript.inst.gameState.empires[1].now_leader = 2;
			if (GlobalScript.inst.gameState.relres)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 100;
			}
			if (GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				GlobalScript.inst.gameState.empires[1].now_leader = 7;
				text += "|| 出 乎 预 料 的 是 ， 亚 历 山 大 · 雅 科 夫 列 夫 当 选 为 苏 共 中 央 委 员 会 总 书 记 ， 他 被 誉 为 正 统 马 克 思 主 义 者 ， 同 时 也 是 数 十 年 坚 持 反 民 族 主 义 立 场 的 文 化 斗 士 。 而 他 在 加 拿 大 的 外 交 经 历 ， 也 为 自 己 同 一 些 西 方 政 治 精 英 建 立 牢 不 可 破 的 联 盟 提 供 了 可 能 ， 这 些 精 英 则 极 有 可 能 成 为 “ 苏 联 与 西 方 蜜 月 ” 的 伴 郎 。 苏 联 国 内 也 将 迎 来 新 面 孔 。 根 据 我 们 所 知 ， 列 昂 尼 德 · 阿 巴 尔 金 已 开 始 谋 求 部 长 会 议 主 席 之 位 ， 而 最 高 苏 维 埃 主 席 团 很 可 能 由 米 哈 伊 尔 · 戈 尔 巴 乔 夫 领 导 。";
			}
			else
			{
				GlobalScript.inst.gameState.empires[1].now_leader = 2;
				text += "|| 不 出 所 料 ， 康 斯 坦 丁 · 契 尔 年 科 当 选 为 总 书 记 。 然 而 ， 考 虑 到 他 年 事 已 高 ， 他 在 这 个 职 位 上 呆 不 了 多 久 。";
			}
			break;
		case 1:
			text = " 苏 联 感 谢 我 们 的 慰 问 ， 并 接 待 了 中 国 代 表 团 。 安 德 罗 波 夫 的 葬 礼 于1984 年2 月14 日12 点 在 莫 斯 科 红 场 克 里 姆 林 宫 附 近 举 行 。 多 国 国 家 元 首 和 政 府 首 脑 出 席 了 葬 礼 及 告 别 仪 式 。 ";
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.empires[1].now_leader = 2;
			if (GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				GlobalScript.inst.gameState.empires[1].now_leader = 7;
				text += "|| 出 乎 预 料 的 是 ， 亚 历 山 大 · 雅 科 夫 列 夫 当 选 为 苏 共 中 央 委 员 会 总 书 记 ， 他 被 誉 为 正 统 马 克 思 主 义 者 ， 同 时 也 是 数 十 年 坚 持 反 民 族 主 义 立 场 的 文 化 斗 士 。 而 他 在 加 拿 大 的 外 交 经 历 ， 也 为 自 己 同 一 些 西 方 政 治 精 英 建 立 牢 不 可 破 的 联 盟 提 供 了 可 能 ， 这 些 精 英 则 极 有 可 能 成 为 “ 苏 联 与 西 方 蜜 月 ” 的 伴 郎 。 苏 联 国 内 也 将 迎 来 新 面 孔 。 根 据 我 们 所 知 ， 列 昂 尼 德 · 阿 巴 尔 金 已 开 始 谋 求 部 长 会 议 主 席 之 位 ， 而 最 高 苏 维 埃 主 席 团 很 可 能 由 米 哈 伊 尔 · 戈 尔 巴 乔 夫 领 导 。";
			}
			else
			{
				GlobalScript.inst.gameState.empires[1].now_leader = 2;
				text += "|| 不 出 所 料 ， 康 斯 坦 丁 · 契 尔 年 科 当 选 为 总 书 记 。 然 而 ， 考 虑 到 他 年 事 已 高 ， 他 在 这 个 职 位 上 呆 不 了 多 久 。";
			}
			break;
		case 2:
			text = " 我 们 的 领 导 人 亲 自 带 领 中 国 代 表 团 ， 并 在 苏 联 受 到 热 烈 欢 迎 。 安 德 罗 波 夫 的 葬 礼 于1984 年2 月14 日12 点 在 莫 斯 科 红 场 克 里 姆 林 宫 附 近 举 行 。 多 国 国 家 元 首 和 政 府 首 脑 出 席 了 葬 礼 及 告 别 仪 式 。 ";
			GlobalScript.inst.gameState.empires[1].now_leader = 2;
			GlobalScript.inst.gameState.empires[1].relations += 150;
			if (GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				GlobalScript.inst.gameState.empires[1].now_leader = 7;
				text += "|| 出 乎 预 料 的 是 ， 亚 历 山 大 · 雅 科 夫 列 夫 当 选 为 苏 共 中 央 委 员 会 总 书 记 ， 他 被 誉 为 正 统 马 克 思 主 义 者 ， 同 时 也 是 数 十 年 坚 持 反 民 族 主 义 立 场 的 文 化 斗 士 。 而 他 在 加 拿 大 的 外 交 经 历 ， 也 为 自 己 同 一 些 西 方 政 治 精 英 建 立 牢 不 可 破 的 联 盟 提 供 了 可 能 ， 这 些 精 英 则 极 有 可 能 成 为 “ 苏 联 与 西 方 蜜 月 ” 的 伴 郎 。 苏 联 国 内 也 将 迎 来 新 面 孔 。 根 据 我 们 所 知 ， 列 昂 尼 德 · 阿 巴 尔 金 已 开 始 谋 求 部 长 会 议 主 席 之 位 ， 而 最 高 苏 维 埃 主 席 团 很 可 能 由 米 哈 伊 尔 · 戈 尔 巴 乔 夫 领 导 。";
			}
			else
			{
				GlobalScript.inst.gameState.empires[1].now_leader = 2;
				text += "|| 不 出 所 料 ， 康 斯 坦 丁 · 契 尔 年 科 当 选 为 总 书 记 。 然 而 ， 考 虑 到 他 年 事 已 高 ， 他 在 这 个 职 位 上 呆 不 了 多 久 。";
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
