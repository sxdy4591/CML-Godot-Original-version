using EventsForDLC;
using UnityEngine;

public class Event392 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1070];
		text = string.Format(GlobalScript.inst.new_events_text[1071], "\n", (a.allcountries[85].inflCh > 0 || a.resultOfEvents[391] == 4) ? GlobalScript.inst.new_events_text[1072] : GlobalScript.inst.new_events_text[1073]);
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = GlobalScript.inst.new_events_text[1074];
		if (a.data[9] >= 90 && (a.allcountries[85].inflNATO > 0 || a.allcountries[85].inflCh > 0))
		{
			button_text[1] = string.Format((a.allcountries[85].inflCh > 0 || a.resultOfEvents[391] == 4) ? GlobalScript.inst.new_events_text[1075] : GlobalScript.inst.new_events_text[1076], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.allcountries[85].inflNATO <= 0 && a.allcountries[85].inflCh <= 0)
		{
			button_text[1] = GlobalScript.inst.new_events_text[1082];
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[566], 9f);
		}
		button_text[2] = GlobalScript.inst.new_events_text[1079];
		button_text[3] = GlobalScript.inst.new_events_text[1080];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1070];
		switch (result_num)
		{
		case 0:
			text = string.Format((a.allcountries[85].inflCh > 0 || a.resultOfEvents[391] == 4) ? GlobalScript.inst.new_events_text[1077] : GlobalScript.inst.new_events_text[1078], "\n");
			if (a.resultOfEvents[391] == 4)
			{
				text += " 社 会 舆 论 也 纷 纷 倒 向 右 翼 ， 并 自 觉 远 离 包 括 <color=#8B0000>意 大 利 共 产 党</color> 在 内 的 左 派 力 量 。 从 而 空 前 巩 固 了 <color=#0027FF>天 主 教 民 主 党</color> 保 守 派 的 国 内 霸 权 。 “ 铅 弹 岁 月 ” 的 高 潮 已 经 落 幕 ， 预 计 右 翼 将 在 接 下 来 的 政 治 活 动 中 畅 通 无 阻 。";
			}
			if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO <= 0)
			{
				a.allcountries[85].inflCh = 2;
			}
			else if (a.allcountries[85].inflCh <= 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 2;
				a.allcountries[85].prcpower += 100;
			}
			else if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 3;
				a.allcountries[85].inflCh = 3;
			}
			a.allcountries[87].spec -= 5;
			break;
		case 1:
			if (a.allcountries[85].inflNATO > 0 || a.allcountries[85].inflCh > 0)
			{
				text = string.Format((a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO > 0) ? GlobalScript.inst.new_events_text[1083] : GlobalScript.inst.new_events_text[1084], "\n");
				if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO <= 0)
				{
					a.allcountries[85].inflCh = 5;
				}
				else if (a.allcountries[85].inflCh <= 0 && a.allcountries[85].inflNATO > 0)
				{
					a.allcountries[85].inflNATO = 5;
				}
				else if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO > 0)
				{
					a.allcountries[85].inflNATO = 4;
					a.allcountries[85].inflCh = 4;
				}
				a.data[9] -= 90;
				a.data[6] -= 20;
				break;
			}
			text = string.Format(GlobalScript.inst.new_events_text[1085], "\n", (a.allcountries[85].inflCh > 0 || a.resultOfEvents[391] == 4) ? GlobalScript.inst.new_events_text[1077] : GlobalScript.inst.new_events_text[1078]);
			if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO <= 0)
			{
				a.allcountries[85].inflCh = 2;
			}
			else if (a.allcountries[85].inflCh <= 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 2;
			}
			else if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 3;
				a.allcountries[85].inflCh = 3;
			}
			a.data[6] -= 10;
			a.allcountries[87].spec -= 5;
			a.empires[1].relations += 80;
			a.empires[0].relations += 80;
			break;
		case 2:
			text = string.Format(GlobalScript.inst.new_events_text[1086], "\n", (a.allcountries[85].inflCh > 0 || a.resultOfEvents[391] == 4) ? GlobalScript.inst.new_events_text[1077] : GlobalScript.inst.new_events_text[1078]);
			if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO <= 0)
			{
				a.allcountries[85].inflCh = 2;
			}
			else if (a.allcountries[85].inflCh <= 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 2;
			}
			else if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 3;
				a.allcountries[85].inflCh = 3;
			}
			a.data[6] += 10;
			a.allcountries[87].spec -= 5;
			a.empires[0].relations -= 150;
			a.empires[0].power -= 15;
			a.empires[1].relations += 50;
			break;
		default:
			text = string.Format(GlobalScript.inst.new_events_text[1087], "\n", (a.allcountries[85].inflCh > 0 || a.resultOfEvents[391] == 4) ? GlobalScript.inst.new_events_text[1077] : GlobalScript.inst.new_events_text[1078]);
			if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO <= 0)
			{
				a.allcountries[85].inflCh = 2;
			}
			else if (a.allcountries[85].inflCh <= 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 2;
			}
			else if (a.allcountries[85].inflCh > 0 && a.allcountries[85].inflNATO > 0)
			{
				a.allcountries[85].inflNATO = 3;
				a.allcountries[85].inflCh = 3;
			}
			a.empires[1].relations -= 150;
			a.empires[1].power -= 15;
			a.empires[0].relations += 50;
			a.allcountries[87].spec -= 5;
			break;
		}
	}
}
