using UnityEngine;

public class Party_zapret : MonoBehaviour
{
	private GlobalScript global1;

	public int this_number;

	public Sprite on;

	public Sprite off;

	public Doctrine_script doctr1;

	private void Awake()
	{
		global1 = GlobalScript.inst;
		Repaint();
	}

	public void Repaint()
	{
		if (GlobalScript.inst.gameState.is_party_enabled[this_number])
		{
			GetComponent<SpriteRenderer>().sprite = on;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = off;
		}
	}

	private void OnMouseEnter()
	{
		if ((GlobalScript.inst.gameState.is_party_enabled[this_number] && GlobalScript.inst.gameState.data[53] < 4 && GlobalScript.inst.gameState.data[15] > 7 && this_number == 1) || (this_number == GlobalScript.inst.gameState.leader.traits[0] && GlobalScript.inst.gameState.leader.traits[0] == 0) || (this_number == 1 && GlobalScript.inst.gameState.leader.traits[0] == 20) || (this_number == GlobalScript.inst.gameState.leader.traits[0] + 1 && GlobalScript.inst.gameState.leader.traits[0] >= 1 && GlobalScript.inst.gameState.leader.traits[0] <= 3))
		{
			GetComponent<SpriteRenderer>().sprite = on;
			GetComponent<OkoshkoScript>().text = "Наша партия";
		}
		else if (GlobalScript.inst.gameState.is_party_enabled[this_number] && GlobalScript.inst.gameState.data[53] < 4 && GlobalScript.inst.gameState.data[1] > 0)
		{
			GetComponent<SpriteRenderer>().sprite = off;
			GetComponent<OkoshkoScript>().text = "Запретить";
		}
		else if (!GlobalScript.inst.gameState.is_party_enabled[this_number])
		{
			GetComponent<SpriteRenderer>().sprite = on;
			GetComponent<OkoshkoScript>().text = "Разрешить";
		}
	}

	private void OnMouseExit()
	{
		if (GlobalScript.inst.gameState.is_party_enabled[this_number])
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
		if (GlobalScript.inst.gameState.is_party_enabled[this_number] && GlobalScript.inst.gameState.data[1] > 0 && GlobalScript.inst.gameState.data[53] < 4 && ((this_number != GlobalScript.inst.gameState.leader.traits[0] && GlobalScript.inst.gameState.leader.traits[0] == 0) || (this_number != 1 && GlobalScript.inst.gameState.leader.traits[0] == 20) || (this_number != GlobalScript.inst.gameState.leader.traits[0] + 1 && GlobalScript.inst.gameState.leader.traits[0] >= 1 && GlobalScript.inst.gameState.leader.traits[0] <= 3)) && (GlobalScript.inst.gameState.data[15] <= 7 || GlobalScript.inst.gameState.data[15] <= 7 || (GlobalScript.inst.gameState.data[15] > 7 && this_number != 1)))
		{
			float num = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
			int num2 = (int)((float)(GlobalScript.inst.gameState.party_number[this_number] * 100) / num);
			GlobalScript.inst.gameState.data[53]++;
			if (GlobalScript.inst.gameState.data[15] > 7)
			{
				if (GlobalScript.inst.gameState.is_party_ally[this_number])
				{
					GlobalScript.inst.gameState.data[1] -= 250;
					GlobalScript.inst.gameState.data[6] += 30;
				}
				else
				{
					GlobalScript.inst.gameState.data[6] += 10;
				}
				GlobalScript.inst.gameState.data[3] -= num2 * 20;
				GlobalScript.inst.gameState.data[4] += num2 * 30;
				if (GlobalScript.inst.gameState.data[53] >= 4)
				{
					GlobalScript.inst.gameState.data[15] = 6;
					for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
					{
						if (GlobalScript.inst.gameState.is_party_ally[i] && i != 1)
						{
							GlobalScript.inst.gameState.is_party_ally[i] = false;
						}
						if (!GlobalScript.inst.gameState.is_party_enabled[i])
						{
							GlobalScript.inst.gameState.is_party_enabled[i] = true;
							if (GlobalScript.inst.gameState.party_number[i] <= 5)
							{
								int num3 = Random.Range(0, 10);
								GlobalScript.inst.gameState.party_number[i] = 10 + num3;
								GlobalScript.inst.gameState.party_ideology[i] = GlobalScript.inst.gameState.party_number[i];
							}
						}
						GlobalScript.inst.gameState.is_party_enabled[4] = false;
						GlobalScript.inst.gameState.party_number[4] = 0;
						GlobalScript.inst.gameState.party_number[3] += GlobalScript.inst.gameState.party_ideology[4];
						GlobalScript.inst.gameState.data[53] = 0;
					}
					GameObject.Find("Kr").GetComponent<Crushok_politic>().Repaint();
					for (int j = 1; j <= 5; j++)
					{
						GameObject.Find("Parties (" + j + ")").transform.Find("Text").GetComponent<Politic_party_name_show>().Repaint();
						GameObject.Find("Parties (" + j + ")").transform.Find("Znack").GetComponent<Party_ally_script>().Repaint();
						GameObject.Find("Parties (" + j + ")").transform.Find("Znakc (1)").GetComponent<Party_zapret>().Repaint();
					}
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[4] += num2 * 20;
				GlobalScript.inst.gameState.data[1] -= num2 * 30;
				if (GlobalScript.inst.gameState.party_ideology[this_number] > 0)
				{
					if (this_number + 1 < GlobalScript.inst.gameState.is_party_enabled.Length)
					{
						for (int k = this_number + 1; k < GlobalScript.inst.gameState.is_party_enabled.Length; k++)
						{
							if (GlobalScript.inst.gameState.is_party_enabled[k])
							{
								GlobalScript.inst.gameState.party_number[k] += GlobalScript.inst.gameState.party_ideology[this_number];
								break;
							}
						}
					}
					else
					{
						for (int num4 = this_number - 1; num4 > 0; num4--)
						{
							if (GlobalScript.inst.gameState.is_party_enabled[num4])
							{
								GlobalScript.inst.gameState.party_number[num4] += GlobalScript.inst.gameState.party_ideology[this_number];
								break;
							}
						}
					}
				}
			}
			GlobalScript.inst.gameState.is_party_enabled[this_number] = false;
			GlobalScript.inst.gameState.party_number[this_number] = 0;
			GlobalScript.inst.gameState.is_party_ally[this_number] = false;
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
			}
			else
			{
				int num5 = GlobalScript.inst.gameState.party_number[1];
				for (int l = 0; l < GlobalScript.inst.gameState.is_party_ally.Length; l++)
				{
					if (GlobalScript.inst.gameState.is_party_ally[l] && GlobalScript.inst.gameState.is_party_enabled[l] && l != 1)
					{
						num5 += GlobalScript.inst.gameState.party_number[l];
					}
				}
				if (num5 >= GlobalScript.inst.gameState.party_number[0] && num5 >= GlobalScript.inst.gameState.party_number[2] && num5 >= GlobalScript.inst.gameState.party_number[3] && num5 >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 1;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[0] && GlobalScript.inst.gameState.is_party_enabled[0] && num5 <= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 0;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[2] && GlobalScript.inst.gameState.is_party_enabled[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[0] && num5 <= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 2;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[3] && GlobalScript.inst.gameState.is_party_enabled[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[2] && num5 <= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 3;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[4] && GlobalScript.inst.gameState.is_party_enabled[4] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[3] && num5 <= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 4;
				}
			}
			Repaint();
		}
		else if (!GlobalScript.inst.gameState.is_party_enabled[this_number] && (GlobalScript.inst.gameState.data[15] <= 7 || GlobalScript.inst.gameState.data[15] <= 7 || (GlobalScript.inst.gameState.data[15] > 7 && this_number != 1)))
		{
			if (GlobalScript.inst.gameState.data[15] > 7)
			{
				GlobalScript.inst.gameState.data[3] += 40;
				GlobalScript.inst.gameState.data[4] += 60;
			}
			else
			{
				GlobalScript.inst.gameState.data[1] -= 150;
				if (GlobalScript.inst.gameState.party_ideology[this_number] > 0)
				{
					if (this_number + 1 < GlobalScript.inst.gameState.is_party_enabled.Length)
					{
						for (int m = this_number + 1; m < GlobalScript.inst.gameState.is_party_enabled.Length; m++)
						{
							if (GlobalScript.inst.gameState.is_party_enabled[m])
							{
								GlobalScript.inst.gameState.party_number[m] -= GlobalScript.inst.gameState.party_ideology[this_number];
								if (GlobalScript.inst.gameState.party_number[m] < GlobalScript.inst.gameState.party_ideology[m])
								{
									GlobalScript.inst.gameState.party_number[m] = GlobalScript.inst.gameState.party_ideology[m];
								}
								break;
							}
						}
					}
					else
					{
						for (int num6 = this_number - 1; num6 > 0; num6--)
						{
							if (GlobalScript.inst.gameState.is_party_enabled[num6])
							{
								GlobalScript.inst.gameState.party_number[num6] -= GlobalScript.inst.gameState.party_ideology[this_number];
								if (GlobalScript.inst.gameState.party_number[num6] < GlobalScript.inst.gameState.party_ideology[num6])
								{
									GlobalScript.inst.gameState.party_number[num6] = GlobalScript.inst.gameState.party_ideology[num6];
								}
								break;
							}
						}
					}
				}
			}
			GlobalScript.inst.gameState.data[53]--;
			GlobalScript.inst.gameState.is_party_enabled[this_number] = true;
			if (GlobalScript.inst.gameState.party_ideology[this_number] > 0 && GlobalScript.inst.gameState.data[15] <= 7)
			{
				GlobalScript.inst.gameState.party_number[this_number] = GlobalScript.inst.gameState.party_ideology[this_number];
			}
			else
			{
				GlobalScript.inst.gameState.party_number[this_number] = 0;
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
			}
			else
			{
				int num7 = GlobalScript.inst.gameState.party_number[1];
				for (int n = 0; n < GlobalScript.inst.gameState.is_party_ally.Length; n++)
				{
					if (GlobalScript.inst.gameState.is_party_ally[n] && GlobalScript.inst.gameState.is_party_enabled[n] && n != 1)
					{
						num7 += GlobalScript.inst.gameState.party_number[n];
					}
				}
				if (num7 >= GlobalScript.inst.gameState.party_number[0] && num7 >= GlobalScript.inst.gameState.party_number[2] && num7 >= GlobalScript.inst.gameState.party_number[3] && num7 >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 1;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[0] && GlobalScript.inst.gameState.is_party_enabled[0] && num7 <= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 0;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[2] && GlobalScript.inst.gameState.is_party_enabled[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[0] && num7 <= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 2;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[3] && GlobalScript.inst.gameState.is_party_enabled[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[2] && num7 <= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 3;
				}
				else if (!GlobalScript.inst.gameState.is_party_ally[4] && GlobalScript.inst.gameState.is_party_enabled[4] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[3] && num7 <= GlobalScript.inst.gameState.party_number[4])
				{
					GlobalScript.inst.gameState.data[56] = 4;
				}
			}
			Repaint();
		}
		doctr1.ShowHideOcno();
		GameObject.Find("Kr").GetComponent<Crushok_politic>().Repaint();
	}
}
