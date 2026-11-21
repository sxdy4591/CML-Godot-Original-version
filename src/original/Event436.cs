using EventsForDLC;
using UnityEngine;

public class Event436 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1656];
		text = GlobalScript.inst.new_events_text[1657];
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = GlobalScript.inst.new_events_text[1658];
		button_text[1] = GlobalScript.inst.new_events_text[1659];
		button_text[2] = GlobalScript.inst.new_events_text[1660];
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1656];
		Leader leader;
		int support = (leader = GlobalScript.inst.gameState.empires[1].leaders[2]).support;
		leader.support = support + 1;
		switch (result_num)
		{
		case 0:
		{
			text = GlobalScript.inst.new_events_text[1661];
			GlobalScript.inst.gameState.data[8] -= 5;
			GlobalScript.inst.gameState.data[3] += 25;
			GlobalScript.inst.gameState.data[4] -= 25;
			GlobalScript.inst.gameState.data[5] += 25;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 5;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality -= 100;
				}
				else
				{
					politic2.loyality += 50;
				}
			}
			break;
		}
		case 1:
		{
			text = GlobalScript.inst.new_events_text[1662];
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection -= 5;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality += 100;
					politic.power += 25;
				}
				else
				{
					politic.loyality -= 50;
				}
			}
			break;
		}
		case 2:
			text = GlobalScript.inst.new_events_text[1663];
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
