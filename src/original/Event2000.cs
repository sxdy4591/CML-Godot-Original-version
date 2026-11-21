using EventsForDLC;
using UnityEngine;

public class Event2000 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 测 试";
		text = " 测 试 事 件";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 6;
		button_text[0] = " 测 试";
		button_text[1] = " 测 试";
		button_text[2] = " 测 试";
		button_text[3] = " 测 试";
		button_text[4] = " 测 试";
		button_text[5] = " 测 试";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 测 试";
		if (result_num == 0)
		{
			text = " 测 试";
			a.allcountries[1].SubGosstroy = 0;
		}
		if (result_num == 1)
		{
			text = " 测 试";
			a.allcountries[1].SubGosstroy = 1;
		}
		if (result_num == 2)
		{
			text = " 测 试";
			a.allcountries[1].SubGosstroy = 2;
		}
		if (result_num == 3)
		{
			text = " 测 试";
			a.allcountries[1].SubGosstroy = 3;
		}
		if (result_num == 4)
		{
			text = " 测 试";
			a.allcountries[1].SubGosstroy = 4;
		}
		if (result_num == 5)
		{
			text = " 测 试";
			a.allcountries[1].SubGosstroy = 5;
		}
	}
}
