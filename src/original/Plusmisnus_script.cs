using UnityEngine;

public class Plusmisnus_script : MonoBehaviour
{
	private GlobalScript global1;

	public bool minus;

	public bool gosdolg;

	public bool reserv;

	public bool payment;

	public int this_number;

	public Sprite on;

	public Sprite off;

	public int planka;

	public int planka2;

	public Show_diplomacy_data_script planka_check;

	private void Awake()
	{
		global1 = GlobalScript.inst;
		planka_check = GameObject.Find("planka_dolg(clone)").GetComponent<Show_diplomacy_data_script>();
		if (gosdolg)
		{
			planka = (GlobalScript.inst.gameState.empires[0].relations + GlobalScript.inst.gameState.empires[1].relations) / 5;
		}
		if (!gosdolg && !reserv)
		{
			CheckPlanka();
		}
	}

	private void CheckPlanka()
	{
		planka2 = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36];
		for (int i = 71; i <= 81; i++)
		{
			planka2 += GlobalScript.inst.gameState.data[i];
		}
		if (GlobalScript.inst.gameState.data[16] > 12)
		{
			planka2 -= (GlobalScript.inst.gameState.data[16] - 12) * (planka2 / 10);
		}
	}

	private void OnMouseDown()
	{
		CheckPlanka();
		if (!gosdolg && !reserv)
		{
			if (minus)
			{
				if (Input.GetKey(KeyCode.LeftShift))
				{
					if (GlobalScript.inst.gameState.data[this_number] >= 50)
					{
						GlobalScript.inst.gameState.data[this_number] -= 50;
						GlobalScript.inst.gameState.data[8] += 50;
						if (payment)
						{
							GlobalScript.inst.gameState.data[1] -= 200;
						}
					}
				}
				else if (Input.GetKey(KeyCode.LeftControl))
				{
					if (GlobalScript.inst.gameState.data[this_number] >= 100)
					{
						GlobalScript.inst.gameState.data[this_number] -= 100;
						GlobalScript.inst.gameState.data[8] += 100;
						if (payment)
						{
							GlobalScript.inst.gameState.data[1] -= 400;
						}
					}
				}
				else if (GlobalScript.inst.gameState.data[this_number] >= 10)
				{
					GlobalScript.inst.gameState.data[this_number] -= 10;
					GlobalScript.inst.gameState.data[8] += 10;
					if (payment)
					{
						GlobalScript.inst.gameState.data[1] -= 40;
					}
				}
				CheckPlanka();
			}
			else if (!minus)
			{
				if (Input.GetKey(KeyCode.LeftShift))
				{
					if (GlobalScript.inst.gameState.data[8] >= 50 && GlobalScript.inst.gameState.data[this_number] + 50 <= planka2 / 6)
					{
						GlobalScript.inst.gameState.data[this_number] += 50;
						GlobalScript.inst.gameState.data[8] -= 50;
					}
				}
				else if (Input.GetKey(KeyCode.LeftControl))
				{
					if (GlobalScript.inst.gameState.data[8] >= 100 && GlobalScript.inst.gameState.data[this_number] + 100 <= planka2 / 6)
					{
						GlobalScript.inst.gameState.data[this_number] += 100;
						GlobalScript.inst.gameState.data[8] -= 100;
					}
				}
				else if (GlobalScript.inst.gameState.data[8] >= 10 && GlobalScript.inst.gameState.data[this_number] <= planka2 / 6)
				{
					GlobalScript.inst.gameState.data[this_number] += 10;
					GlobalScript.inst.gameState.data[8] -= 10;
				}
				CheckPlanka();
			}
		}
		else if (reserv)
		{
			if (!minus)
			{
				if (Input.GetKey(KeyCode.LeftShift))
				{
					if (GlobalScript.inst.gameState.data[8] >= 50)
					{
						GlobalScript.inst.gameState.data[this_number] += 50;
						GlobalScript.inst.gameState.data[8] -= 50;
					}
				}
				else if (Input.GetKey(KeyCode.LeftControl))
				{
					if (GlobalScript.inst.gameState.data[8] >= 100)
					{
						GlobalScript.inst.gameState.data[this_number] += 100;
						GlobalScript.inst.gameState.data[8] -= 100;
					}
				}
				else if (GlobalScript.inst.gameState.data[8] >= 10)
				{
					GlobalScript.inst.gameState.data[this_number] += 10;
					GlobalScript.inst.gameState.data[8] -= 10;
				}
			}
			else if (minus)
			{
				if (Input.GetKey(KeyCode.LeftShift))
				{
					if (GlobalScript.inst.gameState.data[this_number] >= 50)
					{
						GlobalScript.inst.gameState.data[this_number] -= 50;
						GlobalScript.inst.gameState.data[8] += 50;
						GlobalScript.inst.gameState.data[1] -= 50;
						GlobalScript.inst.gameState.data[3] -= 50;
					}
				}
				else if (Input.GetKey(KeyCode.LeftControl))
				{
					if (GlobalScript.inst.gameState.data[this_number] >= 100)
					{
						GlobalScript.inst.gameState.data[this_number] -= 100;
						GlobalScript.inst.gameState.data[8] += 100;
						GlobalScript.inst.gameState.data[1] -= 100;
						GlobalScript.inst.gameState.data[3] -= 100;
					}
				}
				else if (GlobalScript.inst.gameState.data[this_number] >= 10)
				{
					GlobalScript.inst.gameState.data[this_number] -= 10;
					GlobalScript.inst.gameState.data[8] += 10;
					GlobalScript.inst.gameState.data[1] -= 10;
					GlobalScript.inst.gameState.data[3] -= 10;
				}
			}
		}
		else if (minus && GlobalScript.inst.gameState.data[this_number] >= 10)
		{
			GlobalScript.inst.gameState.data[this_number] -= 10;
			if (GlobalScript.inst.gameState.diff < 2)
			{
				GlobalScript.inst.gameState.data[8] -= 10;
			}
			else if (GlobalScript.inst.gameState.diff == 3)
			{
				GlobalScript.inst.gameState.data[8] -= 30;
			}
			else
			{
				GlobalScript.inst.gameState.data[8] -= 20;
			}
			GlobalScript.inst.gameState.data[1] += 5;
			GlobalScript.inst.gameState.influencePRC++;
			planka = (GlobalScript.inst.gameState.empires[0].relations + GlobalScript.inst.gameState.empires[1].relations) / 5;
		}
		else if (minus && GlobalScript.inst.gameState.data[this_number] > 0)
		{
			if (GlobalScript.inst.gameState.diff < 2)
			{
				GlobalScript.inst.gameState.data[8] -= GlobalScript.inst.gameState.data[this_number];
			}
			else if (GlobalScript.inst.gameState.diff == 3)
			{
				GlobalScript.inst.gameState.data[8] -= GlobalScript.inst.gameState.data[this_number] * 3;
			}
			else
			{
				GlobalScript.inst.gameState.data[8] -= GlobalScript.inst.gameState.data[this_number] * 2;
			}
			GlobalScript.inst.gameState.data[this_number] = 0;
			GlobalScript.inst.gameState.data[1] += 5;
			planka = (GlobalScript.inst.gameState.empires[0].relations + GlobalScript.inst.gameState.empires[1].relations) / 5;
		}
		else if (!minus && GlobalScript.inst.gameState.data[this_number] < planka)
		{
			GlobalScript.inst.gameState.data[this_number] += 10;
			GlobalScript.inst.gameState.data[8] += 10;
			GlobalScript.inst.gameState.data[1] -= 10;
			GlobalScript.inst.gameState.influencePRC--;
			GlobalScript.inst.gameState.data[4] += 10;
			planka = (GlobalScript.inst.gameState.empires[0].relations + GlobalScript.inst.gameState.empires[1].relations) / 5;
		}
		planka_check.MakePlankaReady();
	}

	private void OnMouseEnter()
	{
		CheckPlanka();
		if ((!gosdolg && minus) || (!gosdolg && !minus && GlobalScript.inst.gameState.data[this_number] <= planka2 / 6) || (gosdolg && minus) || GlobalScript.inst.gameState.data[this_number] <= planka)
		{
			GetComponent<SpriteRenderer>().sprite = on;
		}
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = off;
	}
}
