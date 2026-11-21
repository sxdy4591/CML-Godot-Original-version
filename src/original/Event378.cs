using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event378 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[816];
		text = string.Format(GlobalScript.inst.new_events_text[817], "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 6;
		if (a.data[14] < 4)
		{
			button_text[0] = GlobalScript.inst.new_events_text[818];
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = GlobalScript.inst.new_events_text[823];
		}
		if (a.data[14] < 4)
		{
			button_text[1] = GlobalScript.inst.new_events_text[819];
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = GlobalScript.inst.new_events_text[823];
		}
		if ((a.allcountries[1].okb || a.allcountries[1].isSEATO) && !a.allcountries[10].okb && a.data[22] >= 250 && ((GlobalScript.inst.gameState.modifies[6].active && a.IsFactionLeadeng(0)) || a.allcountries[1].Gosstroy == 3))
		{
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[820], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (!a.allcountries[1].okb && !a.allcountries[1].isSEATO)
		{
			Object.Destroy(button[2]);
			button_text[2] = GlobalScript.inst.new_events_text[824];
		}
		else if (a.allcountries[10].okb)
		{
			Object.Destroy(button[2]);
			button_text[2] = GlobalScript.inst.new_events_text[854];
		}
		else if (a.data[22] < 250)
		{
			Object.Destroy(button[2]);
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[776], 25f);
		}
		else if (!GlobalScript.inst.gameState.modifies[6].active || !a.IsFactionLeadeng(0))
		{
			if (!GlobalScript.inst.gameState.modifies[6].active)
			{
				Object.Destroy(button[2]);
				button_text[2] = GlobalScript.inst.new_events_text[825];
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = GlobalScript.inst.new_events_text[826];
			}
		}
		else if (a.data[51] >= 32 && a.allcountries[1].Gosstroy != 3)
		{
			Object.Destroy(button[2]);
			button_text[2] = GlobalScript.inst.new_events_text[827];
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = GlobalScript.inst.new_events_text[828];
		}
		if (!a.allcountries[46].Torg && (a.data[16] > 13 || a.data[14] >= 4))
		{
			button_text[3] = GlobalScript.inst.new_events_text[821];
		}
		else if (a.allcountries[46].Torg)
		{
			Object.Destroy(button[3]);
			button_text[3] = GlobalScript.inst.new_events_text[829];
		}
		else if (a.data[16] <= 13)
		{
			Object.Destroy(button[3]);
			button_text[3] = GlobalScript.inst.new_events_text[830];
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = GlobalScript.inst.new_events_text[831];
		}
		if (a.allcountries[1].isSEV && a.allcountries[1].SubGosstroy == 16 && a.data[9] >= 100)
		{
			button_text[4] = string.Format(GlobalScript.inst.new_events_text[867], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (!a.allcountries[1].isSEV)
		{
			Object.Destroy(button[4]);
			button_text[4] = GlobalScript.inst.new_events_text[868];
		}
		else if (a.allcountries[1].SubGosstroy != 16)
		{
			Object.Destroy(button[4]);
			button_text[4] = GlobalScript.inst.new_events_text[869];
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = string.Format(GlobalScript.inst.new_events_text[567], 15f);
		}
		button_text[5] = GlobalScript.inst.new_events_text[822];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[816];
		a.allcountries[10].Gosstroy = 0;
		a.allcountries[10].SubGosstroy = 10;
		if (a.IsFactionLeadeng(0))
		{
			a.data[1] += 100;
		}
		else
		{
			a.data[1] -= 200;
		}
		switch (result_num)
		{
		case 0:
		{
			text = string.Format(GlobalScript.inst.new_events_text[832], "\n");
			a.data[6] += 50;
			a.empires[0].relations -= 100;
			a.empires[1].relations -= 100;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 0)
				{
					politic4.loyality -= 250;
				}
				else if (politic4.traits[0] > 1)
				{
					politic4.loyality -= 200;
				}
			}
			break;
		}
		case 1:
		{
			text = string.Format(GlobalScript.inst.new_events_text[833], "\n");
			if (a.IsFactionLeadeng(0))
			{
				a.data[1] += 300;
			}
			else
			{
				a.data[1] += 200;
			}
			a.data[6] -= 30;
			a.empires[0].relations += 50;
			a.empires[1].relations += 50;
			a.allcountries[10].Torg = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic5 in politics)
			{
				if (politic5.traits[0] == 0)
				{
					politic5.loyality += 50;
				}
				else if (politic5.traits[0] == 1)
				{
					politic5.loyality += 200;
				}
				else
				{
					politic5.loyality -= 50;
				}
			}
			break;
		}
		case 2:
		{
			text = string.Format(GlobalScript.inst.new_events_text[834], "\n");
			int num = 0;
			if (a.guns)
			{
				num += 100;
			}
			a.data[6] += 70;
			a.data[1] -= 300;
			a.influencePRC -= 100;
			a.empires[0].relations -= 250;
			a.empires[1].relations -= 250;
			a.allcountries[10].Torg = false;
			a.empires[1].power += 20;
			a.allcountries[10].EstablishGovernment(Government.ProSoviet);
			a.allcountries[10].inflNATO = 1;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.power += 300;
					politic2.loyality += 250;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality += 250;
				}
				else
				{
					politic2.loyality -= 100;
				}
			}
			a.ingamewars[16] = new War().Name(GlobalScript.inst.new_events_text[837]).Attacker(GlobalScript.inst.new_events_text[839]).Defender(GlobalScript.inst.new_events_text[838])
				.AttackerInfluence(700 - num)
				.DefenderInfluence(300 + num)
				.TickTime(40)
				.SovietSupportDefender.CreateWar;
			break;
		}
		case 3:
		{
			if (a.IsFactionLeadeng(0))
			{
				a.data[1] -= 300;
			}
			else if (a.IsFactionLeadeng(1))
			{
				a.data[1] += 50;
			}
			else
			{
				a.data[1] += 200;
			}
			text = string.Format(GlobalScript.inst.new_events_text[835], "\n");
			a.data[6] -= 70;
			a.empires[0].relations += 150;
			a.empires[1].relations -= 100;
			a.allcountries[46].Torg = true;
			a.data[11] += 1000;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.power -= 500;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality -= 100;
				}
				else
				{
					politic3.loyality += 100;
				}
			}
			break;
		}
		case 4:
		{
			text = string.Format(GlobalScript.inst.new_events_text[870], "\n");
			a.allcountries[10].Gosstroy = 1;
			a.allcountries[10].SubGosstroy = 1;
			a.allcountries[10].isSEV = true;
			a.data[6] -= 20;
			a.empires[1].relations += 100;
			if (a.IsFactionLeadeng(0))
			{
				a.data[1] -= 300;
			}
			else if (a.IsFactionLeadeng(1))
			{
				a.data[1] += 50;
			}
			else
			{
				a.data[1] += 200;
			}
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power -= 150;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality += 100;
				}
			}
			break;
		}
		default:
			text = string.Format(GlobalScript.inst.new_events_text[836], "\n");
			break;
		}
	}
}
