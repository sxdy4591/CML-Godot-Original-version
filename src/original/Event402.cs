using EventsForDLC;
using UnityEngine;

public class Event402 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1151];
		if (a.empires[0].now_leader == 1)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1153], "\n");
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[1152], "\n");
		}
		if (GlobalScript.inst.gameState.completedDecisions[17] && a.empires[0].now_leader == 1 && a.influencePRC >= 500)
		{
			text += "| 话 又 说 回 来 ， 既 然 我 们 已 经 和 美 国 当 地 的 华 人 黑 帮 建 立 了 稳 定 的 合 作 关 系 ， 而 中 国 又 已 经 成 为 国 际 舞 台 上 一 股 举 足 轻 重 的 力 量 ， 那 这 似 乎 意 味 着 我 们 可 以 尝 试 对 大 选 进 行 一 些 小 小 的 “ 干 涉 ” ？";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (GlobalScript.inst.gameState.completedDecisions[17] && a.empires[0].now_leader == 1 && a.influencePRC >= 500)
		{
			kolvo_variant = 3;
			button_text[0] = " 不 介 入";
			button_text[1] = " 暗 中 支 持 民 主 党 人";
			button_text[2] = " 暗 中 支 持 共 和 党 人";
		}
		else
		{
			kolvo_variant = 1;
			button_text[0] = GlobalScript.inst.new_events_text[1154];
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1151];
		int num = 0;
		int num2 = 0;
		if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
		{
			num += 7;
		}
		if (a.empires[0].power > a.empires[1].power)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.empires[0].power > a.influencePRC)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[1].Gosstroy == 3)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[85].isNATO)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[92].isNATO)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[17].isNATO)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[21].isNATO)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[84].isNATO)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (a.allcountries[1].isSEV)
		{
			num2--;
		}
		else
		{
			num--;
		}
		if (a.allcountries[1].isOVD)
		{
			num2--;
		}
		else
		{
			num--;
		}
		if (a.allcountries[15].cw)
		{
			num2++;
		}
		if (a.empires[1].now_leader == 3)
		{
			num2++;
		}
		if (a.allcountries[1].isASEAN)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.ingamewars[5].is_going)
		{
			num++;
		}
		if (a.allcountries[2].puppetOf == 7)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
		{
			num2++;
		}
		switch (result_num)
		{
		case 1:
			num2++;
			break;
		case 2:
			num++;
			break;
		}
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		if (a.empires[0].now_leader != 0 && (a.allcountries[7].isNATO || num <= num2))
		{
			text = string.Format(GlobalScript.inst.new_events_text[1157], "\n");
			a.empires[0].now_leader = 3;
			GlobalScript.inst.gameState.data[143] += 3;
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(137);
			}
			return;
		}
		GlobalScript.inst.gameState.data[143] -= 5;
		if (a.empires[0].now_leader == 1)
		{
			a.empires[0].now_leader = 2;
		}
		a.allcountries[51].SubGosstroy = 12;
		if (a.empires[0].now_leader == 0)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1155], "\n");
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[1156], "\n");
		}
	}
}
