using EventsForDLC;
using UnityEngine;

public class Event365 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[576];
		text = string.Format(GlobalScript.inst.new_events_text[577], "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.allcountries[1].isSEV && a.influencePRC >= 300 && a.data[14] > 1 && a.data[8] + a.data[36] >= 100 && a.data[9] >= 100)
		{
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[578], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (!a.allcountries[1].isSEV)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[579]);
		}
		else if (a.data[14] <= 1)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[580]);
		}
		else if (a.influencePRC < 300)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[581]);
		}
		else if (a.data[9] < 100)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[582]);
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[583]);
		}
		if (a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && !a.relres && (a.influencePRC >= 150 || a.allcountries[51].dev > 0))
		{
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[585], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.influencePRC < 150 && a.allcountries[51].dev <= 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[584]);
		}
		else if (a.relres)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[586]);
		}
		else if (a.data[9] < 100)
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[582]);
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[583]);
		}
		button_text[2] = GlobalScript.inst.new_events_text[587];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[576];
		switch (result_num)
		{
		case 0:
			text = string.Format(GlobalScript.inst.new_events_text[588], "\n");
			a.allcountries[26].SubGosstroy = 3;
			a.influencePRC += 10;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.allcountries[26].isSEV = true;
			a.data[6] -= 30;
			a.empires[1].power += 10;
			if (a.data[52] < 35)
			{
				a.data[1] -= 100;
			}
			else
			{
				a.data[1] += 50;
			}
			break;
		case 1:
			text = string.Format(GlobalScript.inst.new_events_text[589], "\n");
			a.allcountries[26].Gosstroy = 3;
			a.allcountries[26].SubGosstroy = 6;
			a.allcountries[26].prosov = false;
			a.allcountries[26].Torg = true;
			a.influencePRC += 20;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[6] -= 60;
			if (a.data[52] < 36)
			{
				a.data[1] -= 100;
			}
			else
			{
				a.data[1] += 50;
			}
			a.empires[1].power -= 20;
			break;
		case 2:
			text = string.Format(GlobalScript.inst.new_events_text[590], "\n");
			break;
		}
	}
}
