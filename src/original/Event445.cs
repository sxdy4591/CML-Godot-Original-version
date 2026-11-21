using EventsForDLC;
using UnityEngine;

public class Event445 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 老 挝 的 命 运";
		text = " 由 于 越 南 亲 华 派 的 上 位 ， 越 南 调 整 了 对 外 关 系 ， 对 老 挝 的 援 助 任 务 现 在 落 到 了 我 们 头 上 。 也 许 我 们 应 该 重 新 审 视 老 挝 同 越 南 和 我 们 的 关 系 ， 让 他 们 适 当 调 整 政 策 以 和 我 们 步 调 一 致 ， 或 者 我 们 可 以 先 把 精 力 放 在 别 处 ： 毕 竟 ， 越 南 和 柬 埔 寨 已 经 确 定 和 我 们 步 调 一 致 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 向 老 挝 政 府 施 压 以 建 立 关 系";
		button_text[1] = " 我 们 稍 后 再 议";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 老 挝 的 命 运";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 和 越 南 的 施 压 下 ， 凯 山 · 丰 威 汉 承 认 在 过 去 他 的 政 策 “ 有 重 大 的 失 误 ” 后 辞 去 了 老 挝 人 民 革 命 党 总 书 记 和 政 府 总 理 的 的 职 务 ， 仅 保 留 了 政 治 局 委 员 职 务 。 苏 发 努 冯 被 选 为 新 的 老 挝 人 民 革 命 党 总 书 记 和 政 府 总 理 ， 富 米 · 冯 维 希 当 选 为 新 的 老 挝 国 家 主 席 和 最 高 人 民 议 会 主 席 。 老 挝 新 领 导 层 同 我 们 和 越 南 重 新 签 订 了 合 作 协 议 。 原 本 老 挝 政 府 中 大 量 的 越 南 顾 问 撤 回 了 越 南 国 内 ； 同 时 ， 我 们 给 老 挝 发 放 了 大 批 无 息 贷 款 ， 转 让 了 一 批 工 业 设 施 ， 他 们 的 社 会 主 义 经 济 正 在 稳 步 发 展 。";
			a.influencePRC += 10;
			a.data[9] -= 30;
			a.allcountries[22].stab = 1;
			a.allcountries[22].puppetOf = -1;
			a.allcountries[22].isSEV = false;
			a.allcountries[22].prosov = false;
			a.allcountries[22].proprc = true;
			a.allcountries[22].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[22].SubGosstroy = a.allcountries[1].SubGosstroy;
			GlobalScript.inst.gameState.allcountries[22].prcpower = 1000;
			break;
		case 1:
			text = " 有 了 越 南 ， 我 们 已 经 在 中 南 半 岛 有 了 立 足 之 地 ， 所 以 我 们 可 以 先 把 目 光 放 在 别 处 ， 暂 时 不 管 老 挝 的 事 ......";
			break;
		}
	}
}
