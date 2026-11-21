using EventsForDLC;
using UnityEngine;

public class Event120 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_texts[235];
		if (GlobalScript.inst.gameState.allcountries[10].parts[0])
		{
			text = GlobalScript.inst.new_texts[234];
		}
		else
		{
			text = " 在 我 们 的 帮 助 下 ， 韩 国 被 内 部 左 翼 分 子 推 翻 ， 并 与 朝 鲜 和 平 统 一 ， 但 是 按 照 协 定 ， 朝 鲜 半 岛 将 会 进 行 一 场 宪 政 大 会 ， 在 这 场 大 会 上 的 获 胜 者 将 会 统 领 朝 鲜 。 由 于 我 们 为 半 岛 的 社 会 主 义 事 业 做 的 巨 大 贡 献 ， 我 们 在 这 场 大 会 上 拥 有 举 足 轻 重 的 话 语 权 ， 我 们 可 以 决 定 谁 来 统 领 朝 鲜 半 岛 。 这 次 大 会 我 们 有 六 个 人 选 。 第 一 个 是 北 朝 鲜 内 部 主 管 意 识 形 态 方 面 的 黄 长 烨 。 第 二 个 是 南 韩 的 左 翼 温 和 政 治 家 金 哲 。 第 三 个 则 是 金 日 成 接 班 人 之 一 的 金 英 柱 。 第 四 个 是 南 韩 著 名 劳 工 运 动 者 和 工 人 诗 人 朴 劳 解 。 第 五 个 是 来 自 南 韩 的 反 对 主 体 思 想 的 马 克 思 主 义 理 论 家 蔡 万 洙 。 第 六 个 人 是 南 韩 马 克 思 主 义 经 济 学 教 授 尹 素 英 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (GlobalScript.inst.gameState.allcountries[10].parts[0])
		{
			kolvo_variant = 4;
			button_text[0] = GlobalScript.inst.new_texts[230];
			if (GlobalScript.inst.gameState.data[9] >= 250 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 250)
			{
				button_text[1] = GlobalScript.inst.new_texts[231];
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_texts[236], 25);
			}
			button_text[2] = GlobalScript.inst.new_texts[232];
			if (GlobalScript.inst.gameState.data[9] >= 50 && !GlobalScript.inst.gameState.modifies[6].active && !GlobalScript.inst.gameState.modifies[3].active)
			{
				button_text[3] = GlobalScript.inst.new_texts[233];
				return;
			}
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_texts[237], 5);
			return;
		}
		kolvo_variant = 6;
		if (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] != 0)
		{
			button_text[0] = " 支 持 黄 长 烨 的 温 和 主 体 思 想";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 有 文 化 大 革 命 ， 非 极 左 派 主 导";
		}
		if (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] > 1)
		{
			button_text[1] = " 支 持 金 哲 的 进 步 派 系";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 有 文 化 大 革 命 ， 非 极 左 / 保 守 派 主 导";
		}
		if (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] < 3)
		{
			button_text[2] = " 支 持 金 英 柱 的 正 统 派";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 没 有 文 化 大 革 命 ， 非 改 革 / 自 由 派 主 导";
		}
		if (GlobalScript.inst.gameState.data[56] < 2)
		{
			button_text[3] = " 支 持 朴 劳 解 的 半 岛 式 社 会 主 义";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 极 左 / 保 守 派 主 导";
		}
		if (GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] < 3)
		{
			button_text[4] = " 支 持 蔡 万 洙 的 正 统 列 宁 主 义";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 有 文 化 大 革 命 ， 极 左 / 保 守 派 主 导";
		}
		if (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] > 1)
		{
			button_text[5] = " 支 持 尹 素 英 的 马 克 思 主 义 新 实 验";
		}
		else
		{
			Object.Destroy(button[5]);
			button_text[5] = " 没 有 文 化 大 革 命 ， 非 极 左 / 保 守 派 主 导";
		}
		if ((!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] != 0) || (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] > 1) || (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] < 3) || GlobalScript.inst.gameState.data[56] < 2 || (GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] < 3) || (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] > 1))
		{
			string[] array = button_text;
			int num = 5;
			array[num] = array[num] ?? "";
		}
		else
		{
			string[] obj = button_text;
			int num2 = 5;
			obj[num2] += "||按 <color=red>D</color> 退 出 该 界 面";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_texts[235];
		if (GlobalScript.inst.gameState.allcountries[10].parts[0])
		{
			switch (result_num)
			{
			case 0:
				text = GlobalScript.inst.new_texts[238];
				GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 0;
				break;
			case 1:
				text = GlobalScript.inst.new_texts[239];
				GlobalScript.inst.gameState.data[9] -= 250;
				GlobalScript.inst.gameState.data[8] -= 250;
				GlobalScript.inst.gameState.data[7] += 5;
				GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 1;
				GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true);
				break;
			case 2:
				text = GlobalScript.inst.new_texts[240];
				GlobalScript.inst.gameState.data[6] += 50;
				GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 2;
				break;
			case 3:
				text = GlobalScript.inst.new_texts[241];
				GlobalScript.inst.gameState.data[6] -= 50;
				GlobalScript.inst.gameState.data[9] -= 50;
				GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 3;
				GlobalScript.inst.gameState.allcountries[10].JoinOurEconomicAlliance(yes: true);
				break;
			}
			return;
		}
		switch (result_num)
		{
		case 0:
			text = " 黄 长 烨 支 持 主 体 思 想 ， 但 是 认 为 苏 东 集 团 的 市 场 化 改 革 和 党 内 民 主 是 社 会 主 义 的 出 路 。 在 我 们 的 帮 助 下 ， 黄 长 烨 将 会 带 领 朝 鲜 实 行 类 似 卡 达 尔 匈 牙 利 的 经 济 体 制 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 0;
			GlobalScript.inst.gameState.allcountries[10].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 15;
			GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[10].cw = true;
			break;
		case 1:
			text = " 金 哲 是 韩 国 被 解 散 的 政 党 统 一 社 会 党 的 党 首 ， 统 一 社 会 党 曾 加 入 过 社 会 党 国 际 ， 而 金 哲 本 人 也 一 直 支 持 和 传 播 民 主 社 会 主 义 。 在 我 们 的 帮 助 下 ， 朝 鲜 将 会 实 现 民 主 与 社 会 主 义 的 统 一 ， 摆 脱 主 体 思 想 的 束 缚 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 1;
			GlobalScript.inst.gameState.allcountries[10].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[10].cw = true;
			break;
		case 2:
			text = " 金 英 柱 虽 然 也 支 持 主 体 思 想 ， 与 黄 长 烨 不 同 ， 金 英 柱 支 持 计 划 经 济 的 同 时 强 调 自 立 更 生 ， 他 将 会 继 续 进 行 先 军 政 策 和 反 美 主 义 并 继 续 神 话 金 日 成 家 族 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 2;
			GlobalScript.inst.gameState.allcountries[10].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 10;
			GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[10].cw = true;
			break;
		case 3:
			text = " 朴 劳 解 将 与 左 翼 学 生 运 动 中 的 制 宪 会 议 派 （ C A ） 进 行 合 作 ， 制 宪 会 议 派 比 较 支 持 列 宁 主 义 和 民 族 解 放 的 结 合 。 在 我 们 的 帮 助 下 ， 朝 鲜 开 始 探 索 本 土 式 社 会 主 义 的 道 路 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 3;
			GlobalScript.inst.gameState.allcountries[10].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[10].cw = true;
			break;
		case 4:
			text = " 蔡 万 洙 支 持 斯 大 林 主 义 ， 反 对 苏 联 修 正 主 义 ， 比 较 认 可 朝 鲜 的 建 设 成 果 但 对 主 体 思 想 持 负 面 态 度 。 在 我 们 的 帮 助 下 ， 蔡 万 洙 将 彻 底 实 行 列 宁 主 义 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 4;
			GlobalScript.inst.gameState.allcountries[10].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 2;
			GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[10].cw = true;
			break;
		case 5:
			text = " 尹 素 英 支 持 阿 尔 都 塞 主 义 ， 并 认 为 国 家 资 本 主 义 是 一 种 官 僚 主 义 ， 因 此 应 当 实 行 工 人 自 治 与 类 似 新 经 济 政 策 的 经 济 制 度 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding = 5;
			GlobalScript.inst.gameState.allcountries[10].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[10].SubGosstroy = 11;
			GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[10].cw = true;
			break;
		}
	}
}
