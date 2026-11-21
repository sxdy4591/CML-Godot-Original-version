using EventsForDLC;
using UnityEngine;

public class Event489 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 左 翼 联 合 政 府 的 分 裂";
		text = " 土 耳 其 在 内 战 后 左 翼 联 合 政 府 的 团 结 与 政 治 合 作 的 时 期 已 经 结 束 。 自 1 9 7 7 年 以 来 ， 土 耳 其 就 没 有 举 行 过 选 举 。 该 国 政 府 仍 处 于 左 翼 的 共 同 领 导 之 下 ， 右 翼 与 极 右 翼 政 党 实 际 已 经 被 清 理 出 局 ， 初 步 的 左 翼 改 革 实 施 完 毕 ， 土 耳 其 此 前 的 问 题 已 经 基 本 解 决 ， 使 得 左 翼 在 社 会 上 相 当 受 欢 迎 。 如 今 ， 土 耳 其 左 翼 各 派 的 共 同 目 标 已 经 消 失 ， 由 于 他 们 对 左 翼 改 革 的 愿 景 各 不 相 同 ， 联 合 政 府 事 实 上 已 经 陷 入 了 分 裂 。 土 耳 其 左 翼 联 合 政 府 实 际 上 已 经 分 化 为 三 派 ： 在 比 伦 特 · 埃 杰 维 特 领 导 下 转 向 民 主 社 会 主 义 的 <color=#006400>共 和 人 民 党</color> 、 亲 苏 的 正 统 派 <color=#FF0000>土 耳 其 联 合 共 产 党</color> 和 由 各 个 激 进 派 共 产 主 义 组 织 统 一 而 成 的 <color=#8B0000>土 耳 其 人 民 共 产 党</color> 。 为 了 避 免 国 家 滑 向 大 规 模 政 治 暴 力 ， 三 党 最 终 选 择 举 行 新 的 选 举 ， 以 决 定 最 后 的 赢 家 。 目 前 尚 不 清 楚 谁 将 执 掌 土 耳 其 。 国 际 与 国 内 的 局 势 将 决 定 这 场 选 举 的 最 终 结 果 。 当 然 ， 我 们 也 有 了 干 涉 这 一 选 举 以 达 成 有 利 于 我 们 的 结 果 的 机 会 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 支 持 共 和 人 民 党";
		button_text[1] = " 支 持 联 合 共 产 党";
		button_text[2] = " 支 持 人 民 共 产 党";
		button_text[3] = " 不 闻 不 问";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 左 翼 联 合 政 府 的 分 裂";
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		switch (result_num)
		{
		case 0:
			a.data[8] -= 100;
			a.data[9] -= 250;
			num += 2;
			break;
		case 1:
			a.data[8] -= 100;
			a.data[9] -= 250;
			num2 += 2;
			break;
		case 2:
			a.data[8] -= 100;
			a.data[9] -= 250;
			num3 += 2;
			break;
		}
		if (a.allcountries[86].Gosstroy == 1)
		{
			num3 += 2;
			num2++;
		}
		else if (a.allcountries[86].Gosstroy == 3)
		{
			num += 2;
		}
		if (a.data[131] == 2)
		{
			num3++;
			num2++;
		}
		else if (a.data[131] == 1)
		{
			num2++;
		}
		else
		{
			num += 2;
		}
		if (a.allcountries[45].Gosstroy == 2)
		{
			num2 += 2;
			num3++;
		}
		else if (a.allcountries[45].Gosstroy == 1)
		{
			num3 += 2;
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[92].Gosstroy == 1)
		{
			num3++;
			num2++;
		}
		else if (a.allcountries[92].Gosstroy == 2)
		{
			num2++;
			num3++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[85].Gosstroy == 3)
		{
			num++;
		}
		else if (a.allcountries[85].Gosstroy == 2)
		{
			num2++;
		}
		else if (a.allcountries[85].Gosstroy == 1)
		{
			num3++;
		}
		if (a.allcountries[21].isSocEU)
		{
			num += 999;
		}
		if (num2 >= num3 && num2 >= num)
		{
			text = " 选 举 结 果 表 明 ， <color=#FF0000>联 合 共 产 党</color> 赢 得 多 数 选 票 。 新 政 府 宣 布 国 家 将 向 社 会 主 义 过 渡 ， 同 苏 东 阵 营 展 开 合 作 ， 并 要 “ 解 决 一 切 过 去 遗 留 的 历 史 问 题 ” 。 他 们 承 认 了 土 耳 其 历 史 上 的 亚 美 尼 亚 种 族 灭 绝 事 件 ， 同 时 表 示 要 尊 重 库 尔 德 民 族 自 决 — — 土 耳 其 控 制 下 的 库 尔 德 人 聚 集 区 被 赋 予 了 自 治 权 。 苏 东 阵 营 欢 迎 新 的 兄 弟 加 入 他 们 的 阵 营 。";
			a.allcountries[84].Gosstroy = 1;
			a.allcountries[84].SubGosstroy = 16;
			a.allcountries[84].LeaveAlliances();
			a.allcountries[84].prosov = true;
			GlobalScript.inst.gameState.empires[1].leaders[4].support++;
			if (result_num == 1)
			{
				a.data[6] += 100;
				a.allcountries[84].Torg = true;
				a.empires[1].relations += 100;
				a.empires[0].relations -= 100;
				a.influencePRC += 20;
			}
			a.empires[1].power += 50;
		}
		else if (num3 >= num2 && num3 >= num)
		{
			text = " 选 举 结 果 表 明 ， <color=#8B0000>人 民 共 产 党</color> 赢 得 多 数 选 票 。 新 政 府 宣 布 国 家 将 向 社 会 主 义 过 渡 ， 并 解 决 一 切 历 史 遗 留 问 题 。 他 们 承 认 了 土 耳 其 历 史 上 的 亚 美 尼 亚 种 族 灭 绝 事 件 ； 与 此 同 时 ， 土 耳 其 控 制 下 的 库 尔 德 人 聚 集 区 被 赋 予 了 自 治 权 。 新 政 府 宣 布 土 耳 其 将 向 世 界 上 革 命 的 革 命 阵 营 靠 拢 ， 谴 责 一 切 修 正 主 义 。";
			a.allcountries[84].Gosstroy = 1;
			a.allcountries[84].SubGosstroy = 1;
			a.allcountries[84].LeaveAlliances();
			if (result_num == 2)
			{
				a.data[6] += 100;
				a.allcountries[84].proprc = true;
				a.allcountries[84].Torg = true;
				a.allcountries[84].JoinAllOurAlliances(yes: true);
				a.empires[0].relations -= 150;
				a.influencePRC += 50;
			}
		}
		else
		{
			text = " 选 举 结 果 表 明 ， <color=#006400>共 和 人 民 党</color> 赢 得 多 数 选 票 。 新 政 府 将 推 进 土 耳 其 式 民 主 社 会 主 义 的 构 建 ， 并 推 进 国 家 的 民 主 化 进 程 。";
			a.allcountries[84].Gosstroy = 2;
			a.allcountries[84].SubGosstroy = 3;
			a.allcountries[84].LeaveAlliances();
			if (a.allcountries[21].isSocEU)
			{
				a.allcountries[84].isSocEU = true;
			}
			if (result_num == 0)
			{
				a.data[6] += 50;
				a.allcountries[84].Torg = true;
				a.influencePRC += 30;
			}
		}
	}
}
