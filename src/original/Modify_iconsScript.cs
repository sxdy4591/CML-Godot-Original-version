using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modify_iconsScript : MonoBehaviour
{
	private GlobalScript global1;

	public GameObject start;

	public GameObject size_y;

	public GameObject all_focuses;

	public GameObject[] focuses;

	public GameObject focusPrefab;

	public GameObject scroll_here;

	public Sprite vkl;

	public Sprite vykl;

	public bool conditionOn = true;

	private void CreateModifies()
	{
		float num = 0f;
		float num2 = Mathf.Abs(start.transform.position.x) * 0.415f;
		List<int> list = new List<int>();
		if (conditionOn)
		{
			if (GlobalScript.inst.gameState.modifies[15].active)
			{
				list.Add(15);
			}
			if (GlobalScript.inst.gameState.modifies[0].active)
			{
				list.Add(0);
			}
			if (GlobalScript.inst.gameState.modifies[2].active)
			{
				list.Add(2);
			}
			if (GlobalScript.inst.gameState.modifies[3].active)
			{
				list.Add(3);
			}
			if (GlobalScript.inst.gameState.modifies[6].active)
			{
				list.Add(6);
			}
			if (GlobalScript.inst.gameState.modifies[11].active)
			{
				list.Add(11);
			}
			if (GlobalScript.inst.gameState.modifies[8].active)
			{
				list.Add(8);
			}
			if (GlobalScript.inst.gameState.modifies[59].active)
			{
				list.Add(59);
			}
			if (GlobalScript.inst.gameState.modifies[50].active)
			{
				list.Add(50);
			}
			if (GlobalScript.inst.gameState.modifies[47].active)
			{
				list.Add(47);
			}
			if (GlobalScript.inst.gameState.modifies[48].active)
			{
				list.Add(48);
			}
			for (int i = 28; i < 32; i++)
			{
				if (GlobalScript.inst.gameState.modifies[i].active)
				{
					list.Add(i);
				}
			}
			if (GlobalScript.inst.gameState.modifies[46].active)
			{
				list.Add(46);
			}
			if (GlobalScript.inst.gameState.modifies[1].active)
			{
				list.Add(1);
			}
			if (GlobalScript.inst.gameState.modifies[4].active)
			{
				list.Add(4);
			}
			if (GlobalScript.inst.gameState.modifies[5].active)
			{
				list.Add(5);
			}
			if (GlobalScript.inst.gameState.modifies[7].active)
			{
				list.Add(7);
			}
			if (GlobalScript.inst.gameState.modifies[9].active)
			{
				list.Add(9);
			}
			if (GlobalScript.inst.gameState.modifies[10].active)
			{
				list.Add(10);
			}
			for (int j = 12; j < 14; j++)
			{
				if (GlobalScript.inst.gameState.modifies[j].active)
				{
					list.Add(j);
				}
			}
			for (int k = 16; k < 27; k++)
			{
				if (GlobalScript.inst.gameState.modifies[k].active)
				{
					list.Add(k);
				}
			}
			for (int l = 33; l < 45; l++)
			{
				if (GlobalScript.inst.gameState.modifies[l].active)
				{
					list.Add(l);
				}
			}
			if (GlobalScript.inst.gameState.modifies[49].active)
			{
				list.Add(49);
			}
			for (int m = 51; m < 58; m++)
			{
				if (GlobalScript.inst.gameState.modifies[m].active)
				{
					list.Add(m);
				}
			}
			if (GlobalScript.inst.gameState.modifies[60].active)
			{
				list.Add(60);
			}
		}
		else
		{
			if (!GlobalScript.inst.gameState.modifies[15].active)
			{
				list.Add(15);
			}
			if (!GlobalScript.inst.gameState.modifies[0].active)
			{
				list.Add(0);
			}
			if (!GlobalScript.inst.gameState.modifies[2].active)
			{
				list.Add(2);
			}
			if (!GlobalScript.inst.gameState.modifies[3].active)
			{
				list.Add(3);
			}
			if (!GlobalScript.inst.gameState.modifies[6].active)
			{
				list.Add(6);
			}
			if (!GlobalScript.inst.gameState.modifies[11].active)
			{
				list.Add(11);
			}
			if (!GlobalScript.inst.gameState.modifies[8].active)
			{
				list.Add(8);
			}
			if (!GlobalScript.inst.gameState.modifies[59].active)
			{
				list.Add(59);
			}
			if (!GlobalScript.inst.gameState.modifies[50].active)
			{
				list.Add(50);
			}
			if (!GlobalScript.inst.gameState.modifies[47].active)
			{
				list.Add(47);
			}
			if (!GlobalScript.inst.gameState.modifies[48].active)
			{
				list.Add(48);
			}
			if (!GlobalScript.inst.gameState.modifies[46].active)
			{
				list.Add(46);
			}
			if (!GlobalScript.inst.gameState.modifies[1].active)
			{
				list.Add(1);
			}
			if (!GlobalScript.inst.gameState.modifies[4].active)
			{
				list.Add(4);
			}
			if (!GlobalScript.inst.gameState.modifies[5].active)
			{
				list.Add(5);
			}
			if (!GlobalScript.inst.gameState.modifies[7].active)
			{
				list.Add(7);
			}
			if (!GlobalScript.inst.gameState.modifies[9].active)
			{
				list.Add(9);
			}
			if (!GlobalScript.inst.gameState.modifies[10].active)
			{
				list.Add(10);
			}
			for (int n = 12; n < 14; n++)
			{
				if (!GlobalScript.inst.gameState.modifies[n].active)
				{
					list.Add(n);
				}
			}
			for (int num3 = 16; num3 < 27; num3++)
			{
				if (!GlobalScript.inst.gameState.modifies[num3].active)
				{
					list.Add(num3);
				}
			}
			for (int num4 = 33; num4 < 45; num4++)
			{
				if (!GlobalScript.inst.gameState.modifies[num4].active)
				{
					list.Add(num4);
				}
			}
			if (!GlobalScript.inst.gameState.modifies[49].active)
			{
				list.Add(49);
			}
			for (int num5 = 51; num5 < 58; num5++)
			{
				if (!GlobalScript.inst.gameState.modifies[num5].active)
				{
					list.Add(num5);
				}
			}
		}
		Array.Resize(ref focuses, list.Count);
		for (int num6 = 0; num6 < list.Count; num6++)
		{
			if (num6 % 3 == 0 && num6 != 0)
			{
				num = (focuses[num6 - 1].GetComponent<BoxCollider2D>().bounds.max.y - focuses[num6 - 1].GetComponent<BoxCollider2D>().bounds.min.y) * 1.1f * (float)(num6 / 3);
			}
			focuses[num6] = UnityEngine.Object.Instantiate(focusPrefab, new Vector3((num6 % 3 != 0) ? (focuses[num6 - 1].transform.position.x + num2) : start.transform.position.x, start.transform.position.y - num, -1f), Quaternion.identity);
			focuses[num6].transform.parent = all_focuses.transform;
			focuses[num6].GetComponent<ModifyButtonScript>().ChangeIcon(list[num6], GlobalScript.inst.gameState.modifies[list[num6]].active);
			focuses[num6].GetComponent<ModifyButtonScript>().ChangeText(list[num6], GlobalScript.inst.gameState.modifies[list[num6]].active);
		}
	}

	private void DeleteAll()
	{
		for (int i = 0; i < all_focuses.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(all_focuses.transform.GetChild(i).gameObject);
		}
	}

	private void Awake()
	{
		global1 = GlobalScript.inst;
		CreateModifies();
		scroll_here.GetComponent<ScrollScript>().MakeThings(focuses[0].transform.position.y, focuses[focuses.Length - 1].transform.position.y);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadSceneAsync("Diplomacy");
		}
	}

	private void OnMouseDown()
	{
		if (conditionOn)
		{
			GetComponent<SpriteRenderer>().sprite = vykl;
			conditionOn = false;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = vkl;
			conditionOn = true;
		}
		DeleteAll();
		CreateModifies();
		scroll_here.GetComponent<ScrollScript>().MakeThings(focuses[0].transform.position.y, focuses[focuses.Length - 1].transform.position.y);
	}

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().color = new Color(0.57f, 0.57f, 0.57f);
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
	}
}
