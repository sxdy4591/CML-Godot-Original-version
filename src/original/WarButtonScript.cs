using UnityEngine;

public class WarButtonScript : MonoBehaviour
{
	private GlobalScript global1;

	public WarsScript warsc;

	public Sprite navel;

	public Sprite nenavel;

	public int war_number;

	public int this_number;

	public int our_wars;

	public new bool enabled;

	public TextMesh place_1;

	public TextMesh place_2;

	private void Start()
	{
		global1 = GlobalScript.inst;
		warsc = GameObject.Find("WarScriptBack").GetComponent<WarsScript>();
		war_number = int.Parse(base.transform.parent.name);
		CheckButtonAvailable();
	}

	private void CheckButtonAvailable()
	{
		if (our_wars < 0)
		{
			our_wars = warsc.active_wars[war_number];
		}
		else
		{
			place_1.text = ((float)GlobalScript.inst.gameState.ingamewars[our_wars].infl1 / 10f).ToString();
			place_2.text = ((float)GlobalScript.inst.gameState.ingamewars[our_wars].infl2 / 10f).ToString();
		}
		if (this_number == 0)
		{
			enabled = GlobalScript.inst.gameState.data[0] >= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 20 && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 > 0;
		}
		else if (this_number == 1)
		{
			enabled = GlobalScript.inst.gameState.data[0] >= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10 && GlobalScript.inst.gameState.data[9] >= 20 && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 > 0;
		}
		else if (this_number == 2)
		{
			enabled = GlobalScript.inst.gameState.data[0] >= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10 && GlobalScript.inst.gameState.data[22] >= 30 && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 > 0;
		}
		else if (this_number == 3)
		{
			enabled = our_wars != 22 && our_wars != 16 && our_wars != 69 && our_wars != 70 && (our_wars <= 68 || our_wars >= 76) && !GlobalScript.inst.gameState.ingamewars[our_wars].diplo_done[0] && !GlobalScript.inst.gameState.ingamewars[our_wars].diplo_done[1] && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 > 0;
		}
		else if (this_number == 4)
		{
			enabled = our_wars != 22 && our_wars != 29 && our_wars != 16 && our_wars != 69 && our_wars != 70 && (our_wars <= 68 || our_wars >= 76) && (GlobalScript.inst.gameState.war != 1 || our_wars != 1) && GlobalScript.inst.gameState.data[0] >= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10 && GlobalScript.inst.gameState.data[9] >= 20 && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 > 0;
		}
		else if (this_number == 5)
		{
			enabled = our_wars != 22 && our_wars != 29 && our_wars != 16 && our_wars != 69 && our_wars != 70 && (our_wars <= 68 || our_wars >= 76) && (our_wars <= 68 || our_wars >= 76) && (GlobalScript.inst.gameState.war != 1 || our_wars != 1) && GlobalScript.inst.gameState.data[0] >= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 20 && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 > 0;
		}
		else if (this_number == 6)
		{
			enabled = our_wars != 22 && our_wars != 29 && our_wars != 16 && our_wars != 69 && our_wars != 70 && (our_wars <= 68 || our_wars >= 76) && (GlobalScript.inst.gameState.war != 1 || our_wars != 1) && GlobalScript.inst.gameState.data[0] >= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10 && GlobalScript.inst.gameState.data[22] >= 30 && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 > 0;
		}
		else if (this_number == 7)
		{
			enabled = our_wars != 22 && our_wars != 29 && our_wars != 16 && our_wars != 69 && our_wars != 70 && (our_wars <= 68 || our_wars >= 76) && (GlobalScript.inst.gameState.war != 1 || our_wars != 1) && !GlobalScript.inst.gameState.ingamewars[our_wars].diplo_done[1] && !GlobalScript.inst.gameState.ingamewars[our_wars].diplo_done[0] && GlobalScript.inst.gameState.ingamewars[our_wars].infl2 < 1000 && GlobalScript.inst.gameState.ingamewars[our_wars].infl1 > 0;
		}
		if (!enabled)
		{
			GetComponent<SpriteRenderer>().sprite = navel;
		}
		if (GlobalScript.inst.gameState.ingamewars[our_wars].infl1 > 1000)
		{
			GlobalScript.inst.gameState.ingamewars[our_wars].infl1 = 1000;
		}
		else if (GlobalScript.inst.gameState.ingamewars[our_wars].infl1 < 0)
		{
			GlobalScript.inst.gameState.ingamewars[our_wars].infl1 = 0;
		}
		if (GlobalScript.inst.gameState.ingamewars[our_wars].infl2 > 1000)
		{
			GlobalScript.inst.gameState.ingamewars[our_wars].infl2 = 1000;
		}
		else if (GlobalScript.inst.gameState.ingamewars[our_wars].infl2 < 0)
		{
			GlobalScript.inst.gameState.ingamewars[our_wars].infl2 = 0;
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this_number == 0 || this_number == 5)
			{
				base.transform.Find("Text").GetComponent<TextMesh>().text = " 人 力 增 援";
			}
			else if (this_number == 1 || this_number == 4)
			{
				base.transform.Find("Text").GetComponent<TextMesh>().text = " 特 战 支 援";
			}
			else if (this_number == 2 || this_number == 6)
			{
				base.transform.Find("Text").GetComponent<TextMesh>().text = " 军 武 援 助";
			}
			else if (this_number == 3 || this_number == 7)
			{
				base.transform.Find("Text").GetComponent<TextMesh>().text = " 外 交 声 援";
			}
		}
	}

	private void OnMouseDown()
	{
		CheckButtonAvailable();
		if (this_number == 0 && enabled)
		{
			GlobalScript.inst.gameState.data[8] -= 20;
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 1)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 5;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 1)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 5;
			}
			if (GlobalScript.inst.gameState.event_done[548])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 30;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 30;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 50;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 50;
				}
			}
			else
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 20;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 20;
			}
			if (GlobalScript.inst.gameState.event_done[545])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
				{
					GlobalScript.inst.gameState.data[0] -= 8 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
				{
					GlobalScript.inst.gameState.data[0] -= 5 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else
				{
					GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
			}
			GlobalScript.inst.gameState.allcountries[1].level_of_unstab += 8;
		}
		else if (this_number == 1 && enabled)
		{
			GlobalScript.inst.gameState.data[9] -= 30;
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 1)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 5;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 1)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 5;
			}
			if (GlobalScript.inst.gameState.event_done[548])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 10;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 30;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 30;
				}
			}
			if (GlobalScript.inst.gameState.science[24])
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 10;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 10;
			}
			GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 30;
			GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 30;
			if (GlobalScript.inst.gameState.event_done[545])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
				{
					GlobalScript.inst.gameState.data[0] -= 8 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
				{
					GlobalScript.inst.gameState.data[0] -= 5 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else
				{
					GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
			}
			GlobalScript.inst.gameState.allcountries[1].level_of_unstab += 8;
		}
		else if (this_number == 2 && enabled)
		{
			GlobalScript.inst.gameState.data[22] -= 30;
			GlobalScript.inst.gameState.data[8] += 3;
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 1)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 5;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 1)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 5;
			}
			if (GlobalScript.inst.gameState.science[23])
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 40;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 40;
			}
			else
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 30;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 30;
			}
			if (GlobalScript.inst.gameState.event_done[517])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[517] == 0 || GlobalScript.inst.gameState.resultOfEvents[517] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 10;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[517] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 20;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 20;
				}
			}
			if (GlobalScript.inst.gameState.event_done[521])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[521] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 10;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[521] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 20;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 20;
				}
			}
			if (GlobalScript.inst.gameState.event_done[548] && GlobalScript.inst.gameState.resultOfEvents[548] == 2)
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 20;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 20;
			}
			if (GlobalScript.inst.gameState.event_done[545])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
				{
					GlobalScript.inst.gameState.data[0] -= 8 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
				{
					GlobalScript.inst.gameState.data[0] -= 5 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else
				{
					GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
			}
			GlobalScript.inst.gameState.allcountries[1].level_of_unstab += 8;
		}
		else if (this_number == 3 && enabled)
		{
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 0)
			{
				GlobalScript.inst.gameState.empires[0].relations += 30;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 0)
			{
				GlobalScript.inst.gameState.empires[1].relations += 30;
			}
			if (GlobalScript.inst.gameState.event_done[548])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 110;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 110;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 140;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 140;
				}
			}
			else
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 += 80;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 -= 80;
			}
			GlobalScript.inst.gameState.ingamewars[our_wars].diplo_done[0] = true;
		}
		else if (this_number == 7 && enabled)
		{
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 1)
			{
				GlobalScript.inst.gameState.empires[0].relations += 30;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 1)
			{
				GlobalScript.inst.gameState.empires[1].relations += 30;
			}
			if (GlobalScript.inst.gameState.event_done[548])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 110;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 110;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 140;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 140;
				}
			}
			else
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 80;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 80;
			}
			GlobalScript.inst.gameState.ingamewars[our_wars].diplo_done[1] = true;
		}
		else if (this_number == 6 && enabled)
		{
			GlobalScript.inst.gameState.data[22] -= 30;
			GlobalScript.inst.gameState.data[8] += 3;
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 0)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 5;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 0)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 5;
			}
			if (GlobalScript.inst.gameState.science[23])
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 40;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 40;
			}
			else
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 30;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 30;
			}
			if (GlobalScript.inst.gameState.event_done[517])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[517] == 0 || GlobalScript.inst.gameState.resultOfEvents[517] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 10;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[517] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 20;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 20;
				}
			}
			if (GlobalScript.inst.gameState.event_done[521])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[521] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 10;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[521] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 20;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 20;
				}
			}
			if (GlobalScript.inst.gameState.event_done[548] && GlobalScript.inst.gameState.resultOfEvents[548] == 2)
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 20;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 20;
			}
			if (GlobalScript.inst.gameState.event_done[545])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
				{
					GlobalScript.inst.gameState.data[0] -= 8 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
				{
					GlobalScript.inst.gameState.data[0] -= 5 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else
				{
					GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
			}
			GlobalScript.inst.gameState.allcountries[1].level_of_unstab += 8;
		}
		else if (this_number == 4 && enabled)
		{
			GlobalScript.inst.gameState.data[9] -= 30;
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 0)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 5;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 0)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 5;
			}
			if (GlobalScript.inst.gameState.event_done[548])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 10;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 30;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 30;
				}
			}
			if (GlobalScript.inst.gameState.science[24])
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 10;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 10;
			}
			GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 30;
			GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 30;
			if (GlobalScript.inst.gameState.event_done[545])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
				{
					GlobalScript.inst.gameState.data[0] -= 8 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
				{
					GlobalScript.inst.gameState.data[0] -= 5 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else
				{
					GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
			}
			GlobalScript.inst.gameState.allcountries[1].level_of_unstab += 8;
		}
		else if (this_number == 5 && enabled)
		{
			GlobalScript.inst.gameState.data[8] -= 20;
			if (GlobalScript.inst.gameState.ingamewars[our_wars].usa_place == 0)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 5;
			}
			if (GlobalScript.inst.gameState.ingamewars[our_wars].ussr_place == 0)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 5;
			}
			if (GlobalScript.inst.gameState.event_done[548])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 30;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 30;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 50;
					GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 50;
				}
			}
			else
			{
				GlobalScript.inst.gameState.ingamewars[our_wars].infl2 += 20;
				GlobalScript.inst.gameState.ingamewars[our_wars].infl1 -= 20;
			}
			if (GlobalScript.inst.gameState.event_done[545])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
				{
					GlobalScript.inst.gameState.data[0] -= 8 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
				{
					GlobalScript.inst.gameState.data[0] -= 5 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
				else
				{
					GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[0] -= 10 * GlobalScript.inst.gameState.allcountries[1].level_of_unstab / 10;
			}
			GlobalScript.inst.gameState.allcountries[1].level_of_unstab += 8;
		}
		CheckButtonAvailable();
	}

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = navel;
	}

	private void OnMouseExit()
	{
		if (enabled)
		{
			GetComponent<SpriteRenderer>().sprite = nenavel;
		}
	}
}
