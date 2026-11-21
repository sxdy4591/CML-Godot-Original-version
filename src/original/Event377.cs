using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event377 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[801];
		if (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0 && a.allcountries[6].proprc)
		{
			text = string.Format(GlobalScript.inst.new_events_text[802], "\n", (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0 && a.allcountries[6].proprc) ? " 波 兰 、 罗 马 尼 亚 、 匈 牙 利 、 保 加 利 亚 与 蒙 古" : GlobalScript.inst.new_events_text[804]);
		}
		else if (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0)
		{
			text = string.Format(GlobalScript.inst.new_events_text[802], "\n", (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0) ? GlobalScript.inst.new_events_text[803] : GlobalScript.inst.new_events_text[804]);
		}
		else if (a.allcountries[6].proprc)
		{
			text = string.Format(GlobalScript.inst.new_events_text[802], "\n", a.allcountries[6].proprc ? " 波 兰 、 罗 马 尼 亚 、 匈 牙 利 与 保 加 利 亚" : GlobalScript.inst.new_events_text[804]);
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[802], "\n", (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0) ? GlobalScript.inst.new_events_text[803] : GlobalScript.inst.new_events_text[804]);
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = GlobalScript.inst.new_events_text[805];
		button_text[1] = GlobalScript.inst.new_events_text[806];
		if (a.relres && a.influencePRC >= 750 && a.data[22] >= 750 && a.IsFactionLeadeng(0) && !GlobalScript.inst.gameState.ingamewars[22].is_going && GlobalScript.inst.gameState.data[133] == 0)
		{
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[807], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (!a.relres && a.influencePRC >= 950 && a.data[22] >= 750)
		{
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[808], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.influencePRC < 750)
		{
			Object.Destroy(button[2]);
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[620], 95f);
		}
		else if (a.data[22] < 750)
		{
			Object.Destroy(button[2]);
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[776], 75f);
		}
		else if (GlobalScript.inst.gameState.ingamewars[22].is_going)
		{
			Object.Destroy(button[2]);
			button_text[2] = GlobalScript.inst.new_events_text[1037];
		}
		else if (GlobalScript.inst.gameState.data[133] != 0)
		{
			Object.Destroy(button[2]);
			button_text[2] = GlobalScript.inst.new_events_text[1038];
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = GlobalScript.inst.new_events_text[1031];
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[801];
		switch (result_num)
		{
		case 0:
			if (!a.allcountries[6].proprc)
			{
				text = string.Format(GlobalScript.inst.new_events_text[810], "\n", (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0) ? GlobalScript.inst.new_events_text[813] : null);
				a.data[1] -= 550;
			}
			else
			{
				text = string.Format(" 苏 军 从 民 主 德 国 与 捷 克 斯 洛 伐 克 的 领 土 出 发 ， 并 向 “ 不 听 话 的 社 会 主 义 各 国 ” 派 遣 部 队 。 尽 管 那 些 国 家 的 领 导 人 试 图 组 织 抵 抗 ， 但 他 们 还 是 因 自 己 不 得 人 心 的 政 策 而 无 能 为 力 。 尽 管 各 国 市 民 对 苏 联 的 入 侵 已 有 模 糊 的 印 象 （ 毕 竟 有 1 9 5 6 年 事 件 与 1 9 6 8 年 事 件 的 先 例 ） ， 但 他 们 还 是 认 为 苏 军 坦 克 上 的 新 政 权 ， 还 是 不 可 能 和 当 地 政 权 那 样 威 权 且 糟 糕 。||在 各 国 政 府 均 被 推 翻 后 ， 上 述 国 家 的 共 产 党 与 社 会 党 均 被 解 散 ， 并 被 二 度 改 组 。 然 而 ， 前 党 员 并 没 有 被 自 动 加 入 到 新 组 织 中 ， 这 导 致 他 们 需 要 重 新 入 党 。||因 此 ， 新 的 共 产 党 成 为 了 温 和 派 主 导 的 组 织 ， 而 温 和 派 又 仅 在 党 内 的 主 要 职 位 上 任 职 。 从 而 打 破 了 党 员 在 议 会 与 政 府 内 均 任 最 高 领 导 人 的 旧 有 传 统 。||苏 联 领 导 人 认 为 ， 这 一 改 组 足 以 让 各 国 回 归 “ 集 体 领 导 ” 原 则 。||罗 马 尼 亚 共 产 党 的 领 导 人 伊 利 耶 · 维 尔 德 茨 ， 匈 牙 利 共 产 党 的 领 导 人 ， 前 匈 牙 利 驻 苏 联 大 使 蒂 尔 默 · 久 洛 、 波 兰 共 产 党 领 导 人 卡 奇 米 日 · 巴 尔 奇 科 夫 斯 基 与 保 加 利 亚 共 产 党 的 领 导 人 格 里 沙 · 菲 利 波 夫 纷 纷 就 位 ， 领 导 各 自 的 祖 国 。||新 政 府 开 始 以 苏 联 社 会 主 义 为 样 板 推 行 国 内 政 策 。||{1}", "\n", (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0) ? GlobalScript.inst.new_events_text[813] : null);
				a.data[1] -= 600;
			}
			break;
		case 1:
			if (!a.allcountries[6].proprc)
			{
				text = string.Format(GlobalScript.inst.new_events_text[811], "\n", (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0) ? GlobalScript.inst.new_events_text[813] : null);
				a.data[1] -= 250;
				a.empires[1].relations -= 500;
				a.empires[0].relations += 100;
				a.data[6] -= 50;
			}
			else
			{
				text = string.Format(" 中 国 外 交 部 长 对 此 发 出 严 厉 指 责 ： “ 苏 联 正 积 极 推 行 社 会 帝 国 主 义 政 策 ， 从 而 使 冷 战 局 势 再 度 升 级 ， 威 胁 世 纪 和 平 发 展 。 用 武 力 推 动 主 权 国 家 政 权 更 迭 的 方 式 来 解 决 问 题 是 万 万 不 行 的 。 ”||苏 军 从 民 主 德 国 与 捷 克 斯 洛 伐 克 的 领 土 出 发 ， 并 向 “ 不 听 话 的 社 会 主 义 各 国 ” 派 遣 部 队 。 尽 管 那 些 国 家 的 领 导 人 试 图 组 织 抵 抗 ， 但 他 们 还 是 因 自 己 不 得 人 心 的 政 策 而 无 能 为 力 。 尽 管 各 国 市 民 对 苏 联 的 入 侵 已 有 模 糊 的 印 象 （ 毕 竟 有 1 9 5 6 年 事 件 与 1 9 6 8 年 事 件 的 先 例 ） ， 但 他 们 还 是 认 为 苏 军 坦 克 上 的 新 政 权 ， 还 是 不 可 能 和 当 地 政 权 那 样 威 权 且 糟 糕 。||在 各 国 政 府 均 被 推 翻 后 ， 上 述 国 家 的 共 产 党 与 社 会 党 均 被 解 散 ， 并 被 二 度 改 组 。 然 而 ， 前 党 员 并 没 有 被 自 动 加 入 到 新 组 织 中 ， 这 导 致 他 们 需 要 重 新 入 党 。||因 此 ， 新 的 共 产 党 成 为 了 温 和 派 主 导 的 组 织 ， 而 温 和 派 又 仅 在 党 内 的 主 要 职 位 上 任 职 。 从 而 打 破 了 党 员 在 议 会 与 政 府 内 均 任 最 高 领 导 人 的 旧 有 传 统 。||苏 联 领 导 人 认 为 ， 这 一 改 组 足 以 让 各 国 回 归 “ 集 体 领 导 ” 原 则 。||罗 马 尼 亚 共 产 党 的 领 导 人 伊 利 耶 · 维 尔 德 茨 ， 匈 牙 利 共 产 党 的 领 导 人 ， 前 匈 牙 利 驻 苏 联 大 使 蒂 尔 默 · 久 洛 、 波 兰 共 产 党 领 导 人 卡 奇 米 日 · 巴 尔 奇 科 夫 斯 基 与 保 加 利 亚 共 产 党 的 领 导 人 格 里 沙 · 菲 利 波 夫 纷 纷 就 位 ， 领 导 各 自 的 祖 国 。||新 政 府 开 始 以 苏 联 社 会 主 义 为 样 板 推 行 国 内 政 策 。||{1}", "\n", (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0) ? GlobalScript.inst.new_events_text[813] : null);
				a.data[1] -= 250;
				a.empires[1].relations -= 500;
				a.empires[0].relations += 100;
				a.data[6] -= 50;
			}
			break;
		case 2:
		{
			text = string.Format(GlobalScript.inst.new_events_text[812], "\n", a.relres ? GlobalScript.inst.new_events_text[809] : null);
			a.empires[1].relations = 0;
			GameObject gameObject = GameObject.Find("Ach(Clone)");
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(142);
			}
			a.ingamewars[22] = new War().Name(GlobalScript.inst.new_events_text[1032]).Attacker(GlobalScript.inst.new_events_text[1033]).Defender(GlobalScript.inst.new_events_text[1034])
				.AttackerInfluence(250)
				.DefenderInfluence(750)
				.TickTime(500)
				.CreateWar;
			if (a.allcountries[51].Torg)
			{
				a.ingamewars[22].usa_place = 0;
			}
			a.allcountries[7].Torg = false;
			a.data[1] += 300;
			a.data[22] -= 750;
			break;
		}
		}
		a.allcountries[6].LeaveAlliances();
		a.allcountries[2].EstablishGovernment(Government.ProSoviet);
		a.allcountries[4].EstablishGovernment(Government.ProSoviet);
		a.allcountries[5].EstablishGovernment(Government.ProSoviet);
		a.allcountries[6].EstablishGovernment(Government.ProSoviet);
		a.allcountries[6].isSEV = true;
		a.allcountries[6].isOVD = true;
		if (a.allcountries[9].proprc && !a.allcountries[9].okb && a.data[132] <= 0)
		{
			a.allcountries[9].Gosstroy = a.allcountries[7].Gosstroy;
			a.allcountries[9].EstablishGovernment(Government.ProSoviet);
			a.allcountries[9].SubGosstroy = 16;
			a.allcountries[9].puppetOf = 7;
			a.influencePRC -= 50;
			a.allcountries[9].Torg = false;
		}
		a.allcountries[2].Gosstroy = a.allcountries[7].Gosstroy;
		a.allcountries[4].Gosstroy = a.allcountries[7].Gosstroy;
		a.allcountries[5].Gosstroy = a.allcountries[7].Gosstroy;
		a.allcountries[6].Gosstroy = a.allcountries[7].Gosstroy;
		a.allcountries[2].SubGosstroy = 16;
		a.allcountries[4].SubGosstroy = 16;
		a.allcountries[5].SubGosstroy = 16;
		a.allcountries[6].SubGosstroy = 16;
		a.allcountries[2].Torg = false;
		a.allcountries[4].Torg = false;
		a.allcountries[5].Torg = false;
		a.allcountries[6].Torg = false;
		a.allcountries[2].puppetOf = 7;
		a.allcountries[4].puppetOf = 7;
		a.allcountries[5].puppetOf = 7;
		a.allcountries[6].puppetOf = 7;
		a.influencePRC -= 150;
		a.empires[1].power += 200;
	}
}
