using EventsForDLC;
using UnityEngine;

public class Event406 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1198];
		text = string.Format(GlobalScript.inst.new_events_text[1199], "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = GlobalScript.inst.new_events_text[1192];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1198];
		int num = 0;
		bool flag = false;
		bool flag2 = false;
		if (GlobalScript.inst.gameState.empires[0].now_leader == 1)
		{
			num++;
		}
		if (a.data[65] > 0)
		{
			flag2 = true;
		}
		if (GlobalScript.inst.gameState.BritLost)
		{
			flag = true;
		}
		if (GlobalScript.inst.gameState.allcountries[2].puppetOf != 7 && GlobalScript.inst.gameState.allcountries[4].puppetOf != 7 && !a.ingamewars[5].is_going)
		{
			num++;
		}
		int num2 = 0;
		if (a.allcountries[21].Gosstroy == 2 || a.allcountries[21].Gosstroy == 1)
		{
			num2++;
		}
		if (a.allcountries[85].Gosstroy == 2 || a.allcountries[85].Gosstroy == 1)
		{
			num2++;
		}
		if (a.allcountries[86].Gosstroy == 2 || a.allcountries[86].Gosstroy == 1)
		{
			num2++;
		}
		if (a.allcountries[87].Gosstroy == 2 || a.allcountries[87].Gosstroy == 1)
		{
			num2++;
		}
		if (a.allcountries[85].Gosstroy == 0)
		{
			num2++;
		}
		if (a.allcountries[86].Gosstroy == 0)
		{
			num2++;
		}
		if (a.allcountries[87].Gosstroy == 0)
		{
			num2++;
		}
		if (num2 > 1)
		{
			num++;
		}
		a.modifies[57].active = false;
		if (flag && num >= 3 && flag2 && a.allcountries[92].based)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1200], "\n");
			a.allcountries[92].Gosstroy = 1;
			a.allcountries[92].SubGosstroy = 18;
			a.allcountries[92].LeaveAlliances();
			a.allcountries[92].EstablishGovernment(Government.ProNeuthral);
			a.data[147] = 1;
			a.empires[0].power -= 80;
		}
		else if (a.allcountries[92].based && flag && flag2)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1287], "\n");
			a.allcountries[92].Gosstroy = 3;
			a.allcountries[92].SubGosstroy = 5;
			a.data[147] = 2;
		}
		else if (flag && flag2)
		{
			if (!GlobalScript.inst.gameState.allcountries[92].cw)
			{
				text = string.Format(GlobalScript.inst.new_events_text[1201], "\n", a.allcountries[86].isSocEU ? GlobalScript.inst.new_events_text[1453] : null);
				a.allcountries[92].Gosstroy = 2;
				a.allcountries[92].SubGosstroy = 3;
				a.allcountries[92].isEU = false;
				a.empires[0].power -= 50;
				a.allcountries[92].EstablishGovernment(Government.ProNeuthral);
				a.data[147] = 3;
				if (a.allcountries[86].isSocEU)
				{
					a.allcountries[92].isSocEU = true;
					a.allcountries[92].isNATO = false;
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[92].cw)
			{
				text = " <color=red>工 党</color> 成 功 赢 得 本 年 大 选 。 撒 切 尔 政 府 的 外 交 失 败 连 同 破 产 的 新 自 由 主 义 经 济 改 革 一 起 ， 使 保 守 党 的 支 持 率 严 重 下 滑 。\n <color=red>迈 克 尔 · 富 特</color> 与 <color=red>托 尼 · 本 恩</color> 开 始 领 导 这 个 国 家 ， 并 宣 布 英 国 社 会 即 将 在 社 会 主 义 的 基 础 上 ， 开 启 它 的 大 转 变 。 新 政 府 已 经 在 起 草 相 关 法 案 ， 开 始 实 行 大 型 企 业 的 国 有 化 ， 推 倒 撒 切 尔 夫 人 的 改 革 政 策 ， 并 成 立 协 调 国 家 经 济 工 作 的 国 家 经 济 计 划 委 员 会 以 确 保 国 家 竞 争 力 ； 一 些 工 团 主 义 的 元 素 也 被 引 入 经 济 生 活 领 域 ， 工 业 民 主 被 建 立 了 ， 政 府 将 在 经 济 管 理 中 实 现 民 主 化 ， 工 会 活 动 得 到 国 家 鼓 励 ， 工 会 被 允 许 参 与 到 企 业 的 生 产 计 划 乃 至 国 家 计 划 的 管 理 之 中 ； 同 时 ， 改 革 公 务 员 制 度 ， 让 他 们 能 够 更 加 深 刻 的 贯 彻 政 府 的 政 策 ； 媒 体 政 策 也 将 改 订 ， 由 政 府 资 助 媒 体 ， 让 他 们 必 须 倾 向 工 人 阶 级 ， 而 不 是 实 业 家 和 银 行 家 。\n 在 外 交 政 策 方 面 ， 新 的 工 党 政 府 宣 布 退 出 北 约 ， <color=red>本 恩</color> 评 价 道 ： “ 这 是 个 帝 国 主 义 战 争 机 构 ” ； 并 开 始 将 布 鲁 塞 尔 所 袭 夺 的 一 切 ， 悉 数 归 还 给 威 斯 敏 斯 特 宫 — — 退 出 欧 洲 经 济 共 同 体 。\n 英 国 右 翼 和 保 守 派 对 新 的 工 党 政 府 并 不 满 意 ， 他 们 认 为 工 党 已 经 成 为 “ 极 权 主 义 的 特 洛 伊 木 马 ” 。 ";
				a.allcountries[92].Gosstroy = 2;
				a.allcountries[92].SubGosstroy = 3;
				a.allcountries[92].isEU = false;
				a.allcountries[92].isNATO = false;
				a.empires[0].power -= 80;
				a.allcountries[92].EstablishGovernment(Government.ProNeuthral);
				a.data[147] = 6;
			}
		}
		else if (flag || flag2)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1202], "\n");
			a.allcountries[92].Gosstroy = 2;
			a.allcountries[92].SubGosstroy = 8;
			a.data[147] = 4;
			a.empires[0].power -= 20;
			a.allcountries[92].EstablishGovernment(Government.ProNeuthral);
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[1203], "\n");
			a.data[147] = 5;
			a.empires[0].power += 50;
		}
	}
}
