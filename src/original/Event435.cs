using EventsForDLC;
using UnityEngine;

public class Event435 : EventsSecond
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
		name = GlobalScript.inst.new_events_text[1647];
		text = GlobalScript.inst.new_events_text[1648];
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[2] = GlobalScript.inst.new_events_text[1651];
		if (GlobalScript.inst.gameState.data[9] >= 10 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50)
		{
			button_text[0] = GlobalScript.inst.new_events_text[1649];
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = GlobalScript.inst.new_events_text[1652];
		}
		button_text[1] = GlobalScript.inst.new_events_text[1650];
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1647];
		switch (result_num)
		{
		case 0:
		{
			text = GlobalScript.inst.new_events_text[1653];
			Leader leader2;
			int support2 = (leader2 = GlobalScript.inst.gameState.empires[1].leaders[6]).support;
			leader2.support = support2 - 1;
			Leader leader3;
			support2 = (leader3 = GlobalScript.inst.gameState.empires[1].leaders[4]).support;
			leader3.support = support2 - 1;
			Leader leader4;
			support2 = (leader4 = GlobalScript.inst.gameState.empires[1].leaders[1]).support;
			leader4.support = support2 - 1;
			GlobalScript.inst.gameState.empires[1].leaders[3].support -= 2;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[9] -= 100;
			break;
		}
		case 1:
		{
			text = GlobalScript.inst.new_events_text[1654];
			Leader leader;
			int support = (leader = GlobalScript.inst.gameState.empires[1].leaders[3]).support;
			leader.support = support + 1;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 5;
			break;
		}
		case 2:
			text = GlobalScript.inst.new_events_text[1655];
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
