using EventsForDLC;
using UnityEngine;

public class Event420 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1357];
		text = string.Format(GlobalScript.inst.new_events_text[1358], "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		int num = 100 - a.allcountries[87].spec;
		num /= 2;
		if (a.data[8] + a.data[36] >= 200 - num && a.data[9] >= 250 - num)
		{
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[1359], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 200)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 20f);
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[567], 25f);
		}
		if (a.data[8] + a.data[36] >= 200 - num && a.data[9] >= 250 - num)
		{
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[1360], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 200)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[566], 20f);
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[567], 25f);
		}
		button_text[2] = GlobalScript.inst.new_events_text[1361];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1357];
		int num = 0;
		int num2 = 0;
		int num3 = 100 - a.allcountries[87].spec;
		num3 /= 2;
		switch (result_num)
		{
		case 0:
			num += 2;
			a.data[8] -= 200 - num3;
			a.data[9] -= 250 - num3;
			break;
		case 1:
			num2 += 2;
			a.data[8] -= 200 - num3;
			a.data[9] -= 250 - num3;
			break;
		}
		if (a.resultOfEvents[478] == 2)
		{
			num2++;
		}
		else if (a.event_done[478] && a.resultOfEvents[478] != 3)
		{
			num++;
		}
		if (a.data[131] == 2)
		{
			num += 2;
		}
		else if (a.data[131] != 1)
		{
			num2 = ((a.data[131] != 3) ? (num2 + 1) : (num2 + 2));
		}
		else
		{
			num++;
		}
		if (a.allcountries[45].isNATO)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[85].Gosstroy == 2)
		{
			num++;
		}
		else if (a.allcountries[85].Gosstroy == 0)
		{
			num2++;
		}
		if (a.allcountries[84].Gosstroy == 2)
		{
			num++;
		}
		else if (a.allcountries[84].Gosstroy == 0)
		{
			num2++;
		}
		if (a.allcountries[86].Gosstroy == 2)
		{
			num++;
		}
		else if (a.allcountries[86].Gosstroy == 0)
		{
			num2 += 2;
		}
		if (a.empires[1].power >= a.empires[0].power)
		{
			num += 2;
		}
		else
		{
			num2 += 2;
		}
		if (num >= num2)
		{
			if (a.resultOfEvents[478] != 1)
			{
				text = " 里 斯 本 爆 发 政 变 ！ 根 据 《 1 9 7 6 年 宪 法 》 ， 在 革 命 委 员 会 有 权 宣 布 一 切 法 案 违 宪 的 情 况 下 。 为 了 应 对 政 府 颁 布 的 有 关 解 散 革 命 委 员 会 的 法 令 。 委 员 会 宣 称 “ 政 府 背 叛 了 1 9 7 4 年 革 命 的 理 想 ， 站 在 反 革 命 营 垒 中 ， 试 图 摧 毁 革 命 为 该 国 带 来 的 社 会 主 义 成 就 ” 。 在 <color=red>共 产 党</color> 领 导 的 工 会 和 军 队 内 左 翼 的 支 持 下 ， 军 方 拿 下 了 首 都 的 主 要 行 政 建 筑 ， 宣 布 推 翻 政 府 ， 并 逮 捕 了 那 些 没 能 逃 出 本 国 的 行 政 部 长 们 。\n 军 队 内 左 翼 最 终 与 <color=red>葡 萄 牙 共 产 党</color> 合 并 改 组 成 了 新 的 <color=red>葡 萄 牙 共 产 党</color> ， 该 国 军 队 开 始 改 组 为 人 民 军 ， 并 将 彻 底 清 洗 右 翼 分 子 。 新 的 革 命 政 府 则 由 <color=red>瓦 斯 科 · 贡 萨 尔 维 斯</color> 和 葡 共 总 书 记 <color=red>阿 尔 瓦 罗 · 库 尼 亚 尔</color> 共 同 领 导 。\n 葡 萄 牙 新 当 局 宣 布 将 在 国 内 建 设 社 会 主 义 、 实 行 民 主 改 革 并 加 强 与 苏 东 阵 营 的 合 作 。 第 一 步 便 是 完 全 退 出 北 大 西 洋 公 约 组 织 的 军 事 与 政 治 框 架 。 ";
				a.allcountries[87].Gosstroy = 1;
				a.allcountries[87].Vyshi = false;
				a.allcountries[87].SubGosstroy = 1;
				a.allcountries[87].prosov = true;
				a.allcountries[87].isNATO = false;
			}
			else
			{
				text = " 里 斯 本 爆 发 政 变 ！ 根 据 《 1 9 7 6 年 宪 法 》 ， 在 革 命 委 员 会 有 权 宣 布 一 切 法 案 违 宪 的 情 况 下 。 为 了 应 对 政 府 颁 布 的 有 关 解 散 革 命 委 员 会 的 法 令 。 委 员 会 宣 称 “ 政 府 背 叛 了 1 9 7 4 年 革 命 的 理 想 ， 站 在 反 革 命 营 垒 中 ， 试 图 摧 毁 革 命 为 该 国 带 来 的 社 会 主 义 成 就 ” 。 在 <color=red>“ 全 球 项 目 ”</color> 领 导 的 城 市 游 击 队 和 工 会 以 及 军 队 内 左 翼 的 支 持 下 ， 军 方 拿 下 了 首 都 的 主 要 行 政 建 筑 ， 宣 布 推 翻 政 府 ， 并 逮 捕 了 那 些 没 能 逃 出 本 国 的 行 政 部 长 们 。\n 军 队 内 左 翼 最 终 与 <color=red>“ 全 球 项 目 ”</color> 合 并 改 组 成 了 新 的 <color=red>葡 萄 牙 革 命 共 产 党</color> ， 该 国 军 队 开 始 改 组 为 人 民 军 ， 并 将 彻 底 清 洗 右 翼 分 子 。 新 的 革 命 政 府 则 由 <color=red>萨 赖 瓦 · 德 · 卡 瓦 略</color> 和 葡 萄 牙 反 修 派 资 深 理 论 家 <color=red>弗 朗 西 斯 科 · 马 丁 斯</color> 共 同 领 导 。\n 葡 萄 牙 新 当 局 宣 布 将 在 国 内 建 设 社 会 主 义 、 实 行 民 主 改 革 。 第 一 步 便 是 完 全 退 出 北 大 西 洋 公 约 组 织 的 军 事 与 政 治 框 架 。";
				a.allcountries[87].Gosstroy = 1;
				a.allcountries[87].Vyshi = false;
				a.allcountries[87].proprc = true;
				a.allcountries[87].SubGosstroy = 1;
				a.allcountries[87].isNATO = false;
			}
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[1363], "\n");
			a.allcountries[87].Gosstroy = 0;
			if (a.resultOfEvents[478] == 2)
			{
				a.allcountries[87].Vyshi = false;
			}
			a.allcountries[87].SubGosstroy = 7;
			a.allcountries[87].isNATO = false;
		}
	}
}
