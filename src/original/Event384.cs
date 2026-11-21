using EventsForDLC;
using UnityEngine;

public class Event384 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[936];
		if (a.YugAgree)
		{
			text = "自 上 次 总 统 选 举 以 来 ， 法 国 国 内 的 政 治 局 势 发 生 了 显 著 变 化 。|| 由 <color=green>法 国 社 会 党</color> 领 导 人 <color=green>弗 朗 索 瓦 · 密 特 朗</color> 与 <color=red>法 国 共 产 党</color> 前 领 导 人 <color=red>乔 治 · 马 歇</color> 在 1 9 7 2 年 建 立 的 左 翼 总 纲 领 联 盟 已 经 成 了 徒 有 其 表 的 联 合 。 在 接 下 来 的 选 举 中 ， 法 国 左 派 只 能 各 自 为 战 ， 且 无 法 提 名 单 一 候 选 人 。 在 这 一 情 况 下 ， <color=red>法 国 共 产 党</color> 新 任 总 书 记 正 尝 试 与 <color=green>社 会 党</color> 及 其 左 翼 达 成 更 深 入 的 合 作 ， 以 追 求 “ 共 同 反 对 资 本 主 义 ” 的 目 标 促 进 左 翼 力 量 的 壮 大 和 团 结 ， 以 追 求 社 会 变 革 。|| 法 国 右 翼 一 方 的 局 势 也 并 不 明 朗 。 由 <color=#0027FF>法 国 民 主 联 盟</color> 提 名 的 现 任 总 统 <color=#0027FF>瓦 莱 里 · 吉 斯 卡 尔 · 德 斯 坦</color> ， 将 与 身 为 戴 高 乐 主 义 者 ， 来 自 <color=#000080>保 卫 共 和 联 盟</color> 的 前 总 理 <color=#000080>雅 克 · 希 拉 克</color> 对 垒 。|| 现 在 ， 是 时 候 让 我 们 寻 找 最 值 得 支 持 的 棋 子 了 。 首 位 候 选 人 <color=green>密 特 朗</color> 因 其 可 疑 的 观 点 ， 以 及 同 样 阴 云 密 布 的 过 去 而 并 不 受 左 派 欢 迎 。 <color=red>罗 兰 · 勒 罗 伊</color> 领 导 的 <color=red>法 共</color> 新 任 领 导 层 表 现 出 的 革 新 以 及 与 <color=green>社 会 党</color> 的 团 结 态 度 也 吸 引 了 一 部 分 支 持 者 。|| <color=#0027FF>瓦 莱 里 · 吉 斯 卡 尔 · 德 斯 坦</color> 则 在 其 任 期 中 选 择 同 勃 列 日 涅 夫 交 好 ， 但 更 倾 向 于 奉 行 亲 美 政 策 ， 并 带 领 法 国 完 全 回 归 北 约 。 这 让 他 同 试 图 延 续 戴 高 乐 政 策 的 <color=#000080>雅 克 · 希 拉 克</color> 格 格 不 入 。|| 我 们 应 当 支 持 谁 ？ ";
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[937], "\n");
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (a.data[9] >= 50 && a.data[8] + a.data[36] >= 30)
		{
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[939], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 30)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
		}
		if (a.YugAgree)
		{
			if (a.data[9] >= 50 && a.data[8] + a.data[36] >= 30)
			{
				button_text[1] = " 我 们 选 择 支 持 勒 罗 伊";
			}
			else if (a.data[8] + a.data[36] < 30)
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
			}
		}
		else if (a.data[9] >= 50 && a.data[8] + a.data[36] >= 30)
		{
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[940], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 30)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
		}
		if (a.data[9] >= 50 && a.data[8] + a.data[36] >= 30)
		{
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[941], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 30)
		{
			Object.Destroy(button[2]);
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
		}
		if (a.data[9] >= 50 && a.data[8] + a.data[36] >= 30)
		{
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[942], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 30)
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
		}
		button_text[4] = GlobalScript.inst.new_events_text[943];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[936];
		if (result_num < 4)
		{
			a.data[9] -= 50;
			a.data[8] -= 30;
		}
		if (!a.YugAgree || result_num != 1)
		{
			text = string.Format(GlobalScript.inst.new_events_text[945 + result_num], "\n");
		}
		else
		{
			text = " 我 们 为 <color=#8B0000>罗 兰 · 勒 罗 伊</color> 开 展 竞 选 活 动 提 供 了 赞 助 ， 让 我 们 瞧 瞧 法 国 人 有 没 有 把 这 笔 钱 花 在 刀 刃 上 。 首 轮 选 举 将 在 四 月 举 行 ， 第 二 轮 选 举 （ 如 果 没 有 候 选 人 获 得 超 过 5 0 % 的 选 票 ， 则 进 行 此 轮 选 举 ） 则 被 安 排 在 五 月 。";
		}
	}
}
