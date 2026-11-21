using EventsForDLC;
using UnityEngine;

public class Event430 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1438];
		text = string.Format(GlobalScript.inst.new_events_text[1439], "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = GlobalScript.inst.new_events_text[1440];
		button_text[1] = GlobalScript.inst.new_events_text[1441];
		button_text[2] = GlobalScript.inst.new_events_text[1442];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		name = GlobalScript.inst.new_events_text[1438];
		bool flag = false;
		bool flag2 = false;
		int num = 0;
		bool flag3 = false;
		if (flag && flag2)
		{
			num = 1443;
		}
		else if (flag)
		{
			num = 1444;
		}
		else if (flag2)
		{
			num = 1445;
		}
		if (a.allcountries[21].isNATO || a.allcountries[86].isNATO || a.allcountries[85].isNATO)
		{
			flag3 = true;
		}
		if (GlobalScript.inst.gameState.iron_and_blood)
		{
			gameObject.GetComponent<achievements>().Set(127);
		}
		a.allcountries[21].LeaveAlliances();
		a.allcountries[86].LeaveAlliances();
		a.allcountries[85].LeaveAlliances();
		a.allcountries[85].isSocEU = true;
		a.allcountries[21].isSocEU = true;
		a.allcountries[86].isSocEU = true;
		a.empires[1].leaders[6].support += 999;
		if (a.allcountries[87].SubGosstroy == 3 && !a.allcountries[87].econ && !a.allcountries[87].isEU && !a.allcountries[87].okb && !a.allcountries[87].isSEV)
		{
			a.allcountries[87].LeaveAlliances();
			a.allcountries[87].isSocEU = true;
		}
		a.empires[0].power -= 100;
		text = string.Format(GlobalScript.inst.new_events_text[1447 + result_num], "\n", (num > 0) ? GlobalScript.inst.new_events_text[num] : null, flag3 ? GlobalScript.inst.new_events_text[1446] : null);
		if (a.allcountries[87].isSocEU)
		{
			text += " 此 外 ， 在 葡 萄 牙 ，不 久 前 刚 刚 上 台 的 社 会 党 与 联 合 人 民 联 盟 组 成 社 会 主 义 联 合 政 府 也 表 示 ， 决 定 申 请 加 入 社 会 主 义 联 盟 。 鉴 于 其 最 近 宣 布 的 政 策 和 道 路 与 社 会 主 义 联 盟 的 理 念 十 分 贴 近 ， 申 请 很 快 就 会 通 过 。";
		}
		if (a.allcountries[85].isSocEU && a.data[147] == 3)
		{
			text += "||刚 刚 赢 得 大 选 的 英 国 工 党 政 府 看 到 了 新 兴 社 会 主 义 联 盟 潜 力 ， 为 更 好 贯 彻 “ 重 建 福 利 国 家 ” 的 政 策 ， 主 动 申 请 加 入 社 会 主 义 联 盟 以 寻 求 经 济 帮 助 。";
			a.allcountries[92].isSocEU = true;
			a.allcountries[92].isNATO = false;
		}
		switch (result_num)
		{
		case 0:
		{
			a.empires[0].relations -= 500;
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].isSocEU)
				{
					a.allcountries[i].Torg = true;
				}
			}
			break;
		}
		case 1:
			a.empires[0].relations += 300;
			break;
		}
	}
}
