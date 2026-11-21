using UnityEngine;

public class Party_ally_script : MonoBehaviour
{
	private GlobalScript global1;

	public int this_number;

	public Sprite on;

	public Sprite off;

	public Doctrine_script doctr1;

	private void Awake()
	{
		global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		Repaint();
	}

	public void Repaint()
	{
		if (GlobalScript.inst.gameState.is_party_ally[this_number])
		{
			GetComponent<SpriteRenderer>().sprite = on;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = off;
		}
	}

	private void OnMouseDown()
	{
		doctr1.ShowHideOcno();
		if (GlobalScript.inst.gameState.data[15] > 7)
		{
			int num = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
			int num2 = GlobalScript.inst.gameState.party_number[this_number] * 100 / num;
			if (!GlobalScript.inst.gameState.is_party_ally[this_number] && GlobalScript.inst.gameState.data[9] >= num2 && GlobalScript.inst.gameState.data[8] >= num2)
			{
				int num3 = (GlobalScript.inst.gameState.data[33] + GlobalScript.inst.gameState.data[55]) / 2;
				if (GlobalScript.inst.gameState.is_party_enabled[this_number] && ((this_number == 4 && num3 >= 700) || (this_number == 3 && num3 >= 550 && num3 <= 750) || (this_number == 2 && num3 >= 400 && num3 <= 600) || (this_number == 0 && num3 <= 250)))
				{
					GlobalScript.inst.gameState.is_party_ally[this_number] = true;
					if (num2 > 10)
					{
						GlobalScript.inst.gameState.data[1] -= num2 * 5;
						GlobalScript.inst.gameState.data[3] -= num2;
						GlobalScript.inst.gameState.data[6] -= 10;
						GlobalScript.inst.gameState.data[8] -= num2;
						GlobalScript.inst.gameState.data[9] -= num2;
						GlobalScript.inst.gameState.data[4] -= num2;
					}
					else
					{
						GlobalScript.inst.gameState.data[1] -= 50;
						GlobalScript.inst.gameState.data[3] -= 10;
						GlobalScript.inst.gameState.data[6] -= 10;
						GlobalScript.inst.gameState.data[8] -= 10;
						GlobalScript.inst.gameState.data[9] -= 10;
						GlobalScript.inst.gameState.data[4] -= 10;
					}
					Repaint();
				}
			}
		}
		else if (!GlobalScript.inst.gameState.is_party_ally[this_number] && GlobalScript.inst.gameState.is_party_enabled[this_number])
		{
			GlobalScript.inst.gameState.is_party_ally[this_number] = true;
		}
		else
		{
			GlobalScript.inst.gameState.is_party_ally[this_number] = false;
		}
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			if (GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 0;
			}
			else if (GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[1] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[1] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[1] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 1;
			}
			else if (GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 2;
			}
			else if (GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 3;
			}
			else if (GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 4;
			}
			return;
		}
		int num4 = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num4 += GlobalScript.inst.gameState.party_number[i];
			}
		}
		if (num4 >= GlobalScript.inst.gameState.party_number[0] && num4 >= GlobalScript.inst.gameState.party_number[2] && num4 >= GlobalScript.inst.gameState.party_number[3] && num4 >= GlobalScript.inst.gameState.party_number[4])
		{
			GlobalScript.inst.gameState.data[56] = 1;
		}
		else if (!GlobalScript.inst.gameState.is_party_ally[0] && GlobalScript.inst.gameState.is_party_enabled[0] && num4 <= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[4])
		{
			GlobalScript.inst.gameState.data[56] = 0;
		}
		else if (!GlobalScript.inst.gameState.is_party_ally[2] && GlobalScript.inst.gameState.is_party_enabled[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[0] && num4 <= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[4])
		{
			GlobalScript.inst.gameState.data[56] = 2;
		}
		else if (!GlobalScript.inst.gameState.is_party_ally[3] && GlobalScript.inst.gameState.is_party_enabled[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[2] && num4 <= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[4])
		{
			GlobalScript.inst.gameState.data[56] = 3;
		}
		else if (!GlobalScript.inst.gameState.is_party_ally[4] && GlobalScript.inst.gameState.is_party_enabled[4] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[3] && num4 <= GlobalScript.inst.gameState.party_number[4])
		{
			GlobalScript.inst.gameState.data[56] = 4;
		}
	}

	private void OnMouseEnter()
	{
		if (GlobalScript.inst.gameState.data[15] > 7)
		{
			GetComponent<OkoshkoScript>().text = "Союз";
			GetComponent<OkoshkoScript>().text_en = " 同 盟";
			int num = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
			int num2 = GlobalScript.inst.gameState.party_number[this_number] * 100 / num;
			if (!GlobalScript.inst.gameState.is_party_ally[this_number] && GlobalScript.inst.gameState.data[9] >= num2 && GlobalScript.inst.gameState.data[8] >= num2)
			{
				int num3 = (GlobalScript.inst.gameState.data[33] + GlobalScript.inst.gameState.data[55]) / 2;
				if (GlobalScript.inst.gameState.is_party_enabled[this_number] && ((this_number == 4 && num3 >= 700) || (this_number == 3 && num3 >= 550 && num3 <= 750) || (this_number == 2 && num3 >= 400 && num3 <= 600) || (this_number == 0 && num3 <= 250)))
				{
					GetComponent<SpriteRenderer>().sprite = on;
				}
			}
		}
		else
		{
			GetComponent<OkoshkoScript>().text = "Поддержать";
			GetComponent<OkoshkoScript>().text_en = " 支 持";
			if (GlobalScript.inst.gameState.is_party_ally[this_number] || !GlobalScript.inst.gameState.is_party_enabled[this_number])
			{
				GetComponent<SpriteRenderer>().sprite = off;
			}
			else
			{
				GetComponent<SpriteRenderer>().sprite = on;
			}
		}
	}

	private void OnMouseExit()
	{
		if (GlobalScript.inst.gameState.data[15] > 7)
		{
			if (!GlobalScript.inst.gameState.is_party_ally[this_number])
			{
				GetComponent<SpriteRenderer>().sprite = off;
			}
		}
		else if (!GlobalScript.inst.gameState.is_party_ally[this_number])
		{
			GetComponent<SpriteRenderer>().sprite = off;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = on;
		}
	}
}
