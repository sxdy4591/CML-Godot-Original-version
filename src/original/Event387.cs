using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event387 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1008];
		if (GlobalScript.inst.gameState.allcountries[24].proprc)
		{
			text = " 北 也 门 与 南 也 门 曾 在 1 9 7 2 年 爆 发 了 一 场 冲 突 。 最 终 ， 对 抗 以 双 方 签 署 《 开 罗 合 约 》 结 束 ， 并 在 合 约 中 表 达 了 两 国 实 现 统 一 的 愿 望 。 然 而 ， 在 接 下 来 的 数 年 内 ， 两 国 均 没 有 为 统 一 采 取 决 定 性 的 行 动 。||而 现 在 ， 北 也 门 政 府 正 控 诉 其 南 方 邻 居 正 支 持 名 为 “ 民 族 民 主 阵 线 ” 的 革 命 组 织 。 而 在 双 方 的 边 界 上 ， 时 常 能 够 听 到 枪 声 ， 看 起 来 这 场 冲 突 将 发 展 为 一 场 全 面 战 争 。 既 然 南 也 门 已 经 加 强 了 与 我 们 的 合 作， 那 么 一 个 由 南 方 主 导 统 一 的 也 门 对 我 们 是 有 利 的 。 另 外 ， 自 2 0 世 纪 6 0 年 代 以 来 ， 苏 联 便 已 经 在 南 也 门 这 里 派 驻 部 队 ， 并 建 立 了 海 军 基 地 ， 如 果 战 争 爆 发 ， 苏 联 人 显 然 会 帮 助 南 也 门 。";
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[1009], "\n");
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[9] >= 50 && a.data[22] >= 100)
		{
			if (!GlobalScript.inst.gameState.allcountries[24].proprc)
			{
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[1010], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (GlobalScript.inst.gameState.allcountries[24].proprc)
			{
				Object.Destroy(button[0]);
				button_text[0] = " 背 叛 盟 友 ？ 你 疯 了 吗 ？！";
			}
		}
		else if (a.data[9] < 50)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[776], 10f);
		}
		if (a.data[9] >= 50 && a.data[22] >= 100)
		{
			if (!GlobalScript.inst.gameState.allcountries[25].proprc)
			{
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[1011], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (GlobalScript.inst.gameState.allcountries[25].proprc)
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 忙 活 这 么 久 ， 不 能 让 M S S 的 血 白 流 了";
			}
		}
		else if (a.data[9] < 50)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[776], 10f);
		}
		if (a.allcountries[25].proprc && GlobalScript.inst.gameState.allcountries[24].proprc)
		{
			button_text[2] = " 也 门 人 不 打 也 门 人 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 没 人 愿 意 坐 下 来 谈";
		}
		button_text[3] = GlobalScript.inst.new_events_text[1012];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1008];
		if (result_num == 0)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1013], "\n");
			a.data[143]++;
			a.ingamewars[21] = new War().Name(GlobalScript.inst.new_events_text[1016]).Attacker(GlobalScript.inst.new_events_text[1017]).Defender(GlobalScript.inst.new_events_text[1018])
				.AttackerInfluence(600)
				.DefenderInfluence(400)
				.TickTime(20)
				.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
			a.empires[0].relations += 100;
			a.empires[1].relations -= 100;
			a.data[6] += 10;
			a.data[9] -= 50;
			a.data[22] -= 100;
		}
		if (result_num == 1)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1014], "\n");
			a.data[143]++;
			a.ingamewars[21] = new War().Name(GlobalScript.inst.new_events_text[1016]).Attacker(GlobalScript.inst.new_events_text[1017]).Defender(GlobalScript.inst.new_events_text[1018])
				.AttackerInfluence(400)
				.DefenderInfluence(600)
				.TickTime(20)
				.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
			a.empires[0].relations -= 100;
			a.empires[1].relations += 100;
			a.data[6] += 10;
			a.data[9] -= 50;
			a.data[22] -= 100;
		}
		if (result_num == 2)
		{
			text = " 在 我 们 的 支 持 下 ， 北 也 门 总 统 加 什 米 和 南 也 门 最 高 人 民 委 员 会 主 席 鲁 巴 伊 决 定 坐 下 来 ， 就 也 门 的 未 来 进 行 商 讨 。 经 过 我 们 的 指 导 ， 双 方 决 定 了 成 立 阿 拉 伯 也 门 民 主 联 邦 的 计 划 。 北 也 门 与 南 也 门 保 持 一 段 时 间 的 联 邦 制 政 府 ， 行 政 中 心 在 萨 那 ， 但 首 都 在 亚 丁 。 双 方 就 成 立 也 门 人 民 革 命 党 也 达 成 了 协 议 ， 原 北 也 门 和 南 也 门 的 政 府 官 员 各 占 一 半 。 北 也 门 和 南 也 门 继 续 发 行 自 己 的 货 币 ， 但 将 协 调 各 项 资 源 。 两 国 的 和 平 与 统 一 得 到 了 世 界 的 认 可 。";
			GlobalScript.inst.gameState.allcountries[25].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[24].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[24].proprc = true;
			GlobalScript.inst.gameState.allcountries[24].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[24].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[24].Torg = true;
			GlobalScript.inst.gameState.allcountries[24].name = " 统 一 也 门";
			a.data[8] -= 30;
			a.data[9] -= 40;
			a.influencePRC += 20;
		}
		if (result_num == 3)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1015], "\n");
		}
	}
}
