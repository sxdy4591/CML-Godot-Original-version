using EventsForDLC;
using UnityEngine;

public class Event321 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[183];
		text = string.Format(GlobalScript.inst.new_events_text[184]);
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = GlobalScript.inst.new_events_text[185];
		if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50 && GlobalScript.inst.gameState.data[12] >= 500)
		{
			button_text[1] = GlobalScript.inst.new_events_text[186];
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Format(GlobalScript.inst.new_events_text[187]);
		}
		if (GlobalScript.inst.gameState.data[6] >= 700 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50)
		{
			button_text[2] = GlobalScript.inst.new_events_text[188];
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = string.Format(GlobalScript.inst.new_events_text[189]);
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[183];
		switch (result_num)
		{
		case 0:
			text = GlobalScript.inst.new_events_text[190];
			break;
		case 1:
			text = GlobalScript.inst.new_events_text[191];
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[12] -= 50;
			GlobalScript.inst.gameState.data[13] += 75;
			if (!GlobalScript.inst.gameState.science[6])
			{
				GlobalScript.inst.gameState.science[6] = true;
				string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
				int num = 15;
				old_modify_desc[num] += "<color=red>| 普 及 化 肥 与 杀 虫 剂 ：</color>| 农 业+0.3 ， 生 活 水 平+0.4";
			}
			break;
		case 2:
			text = GlobalScript.inst.new_events_text[192];
			GlobalScript.inst.gameState.data[6] += 100;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[13] += 50;
			break;
		}
	}
}
