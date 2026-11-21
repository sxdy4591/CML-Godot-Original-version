using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Science_Script : MonoBehaviour
{
	public Politic_Show_Data data_sh;

	public GlobalScript global1;

	public int number;

	public int number_zavisimost;

	public int days;

	public int money;

	public int data;

	public int working = -1;

	public bool is_working_here;

	public SpriteRenderer galka;

	public SpriteRenderer shkala;

	public TextMesh text;

	private Material shkala_mat;

	public string name_ru;

	public string name_en;

	public string desc_ru;

	public string desc_en;

	public GameObject Plashka;

	public GameObject scienceForDlc02;

	public TextMesh T1;

	public TextMesh T2;

	public TextMesh T3;

	public Sprite yes;

	public Sprite no;

	private void Update()
	{
		if (number == 0 && Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadSceneAsync("Diplomacy");
		}
	}

	private void Awake()
	{
		CheckToDestroy();
		global1 = GlobalScript.inst;
		if (GlobalScript.inst.gameState.science_need_time[number] != days)
		{
			GlobalScript.inst.gameState.science_need_time[number] = days;
		}
		shkala_mat = shkala.material;
		text.text = data.ToString();
		Repaint();
		for (int i = 0; i < GlobalScript.inst.gameState.science_in_progress.Length; i++)
		{
			if (GlobalScript.inst.gameState.science_in_progress[i] && !GlobalScript.inst.gameState.science[i])
			{
				working = i;
				Debug.Log(working.ToString());
			}
			else if (i == working && GlobalScript.inst.gameState.science[i])
			{
				working = -1;
				Debug.Log(working.ToString());
			}
		}
	}

	private void CheckToDestroy()
	{
		if (!GlobalScript.inst.dlc[2] && number == 27)
		{
			Object.Destroy(scienceForDlc02);
		}
	}

	private void Repaint()
	{
		text.text = data.ToString();
		if (number_zavisimost == -1 || GlobalScript.inst.gameState.science[number_zavisimost])
		{
			galka.sprite = yes;
		}
		else
		{
			galka.sprite = no;
		}
		if (GlobalScript.inst.gameState.science_time[number] <= 0)
		{
			shkala_mat.SetFloat("_M", 0f);
			return;
		}
		float num = (float)GlobalScript.inst.gameState.science_time[number] / (float)days;
		if (num > 0f)
		{
			shkala_mat.SetFloat("_M", num);
		}
		else
		{
			shkala_mat.SetFloat("_M", 0f);
		}
	}

	private void OnMouseEnter()
	{
		Plashka.SetActive(value: true);
		RepaintPlashka();
	}

	private void RepaintPlashka()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			T1.text = GlobalScript.inst.new_texts[593 + number];
			int[] array = new int[40];
			if (GlobalScript.inst.gameState.modifies[51].active)
			{
				array[2] = 1;
				array[3] = 1;
				array[6] = 1;
				array[8] = 1;
				array[7] = 1;
				array[10] = 1;
				array[11] = 1;
				array[13] = 1;
				array[14] = 1;
			}
			T3.text = Text(string.Format((array[number] > 0) ? "{0}{1}{2}, {3}" : "{0}{1}{2}", GlobalScript.inst.other_text[356 + number], '\n', GlobalScript.inst.other_text[390 + number], (array[number] > 0) ? GlobalScript.inst.other_text[433 + number] : null), 99);
			if (GlobalScript.inst.gameState.science[number])
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> 资 金 | <color=green> 研 究 完 成 </color>";
			}
			else if (number == 17 && GlobalScript.inst.gameState.data[118] == 0)
			{
				T2.text = string.Format("<color=red> 我 们 尚 未 宣 告 建 设 全 面 自 动 化 </color>", (float)money / 10f, GlobalScript.inst.gameState.science_time[number], days);
			}
			else if (GlobalScript.inst.gameState.science_in_progress[number])
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> 资 金 | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} 科 研 点 | <color=green> 研 究 中 ... </color>";
			}
			else if (working != -1)
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> 资 金 | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} 科 研 点 | <color=red> 只 能 研 究 单 个 项 目 </color>";
			}
			else if (GlobalScript.inst.gameState.data[21] >= data && (number_zavisimost == -1 || GlobalScript.inst.gameState.science[number_zavisimost]) && working == -1)
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> 资 金 | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} 科 研 点 | <color=red> 可 研 究 </color>";
			}
			else if (GlobalScript.inst.gameState.data[21] < data && (number_zavisimost == -1 || GlobalScript.inst.gameState.science[number_zavisimost]) && working == -1)
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> 资 金 | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} 科 研 点 | <color=red> 超 前 惩 罚 ： +{days * (data - GlobalScript.inst.gameState.data[21]) - GlobalScript.inst.gameState.data[20] * (days / 12)} 科 研 点 </color>";
			}
			else
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> 资 金 | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} 科 研 点 | <color=red> 不 可 研 究 </color>";
			}
		}
		else
		{
			T1.text = GlobalScript.inst.new_texts[593 + number];
			int[] array2 = new int[40];
			if (GlobalScript.inst.gameState.modifies[51].active)
			{
				array2[2] = 1;
				array2[3] = 1;
				array2[6] = 1;
				array2[8] = 1;
				array2[7] = 1;
				array2[10] = 1;
				array2[11] = 1;
				array2[13] = 1;
				array2[14] = 1;
			}
			T3.text = Text(string.Format((array2[number] > 0) ? "{0}{1}{2}, {3}" : "{0}{1}{2}", GlobalScript.inst.other_text[356 + number], '\n', GlobalScript.inst.other_text[390 + number], (array2[number] > 0) ? GlobalScript.inst.other_text[433 + number] : null), 99);
			if (GlobalScript.inst.gameState.science[number])
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> денег | <color=green> Исследовано </color>";
			}
			else if (number == 17 && GlobalScript.inst.gameState.data[118] == 0)
			{
				T2.text = string.Format("<color=red> Мы ещё не заявили о полномасштабной автоматизации </color>", (float)money / 10f, GlobalScript.inst.gameState.science_time[number], days);
			}
			else if (GlobalScript.inst.gameState.science_in_progress[number])
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> денег | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} очков науки | <color=green> В прогрессе... </color>";
			}
			else if (working != -1)
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> денег | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} очков науки | <color=red> Один за раз </color>";
			}
			else if (GlobalScript.inst.gameState.data[21] >= data && (number_zavisimost == -1 || GlobalScript.inst.gameState.science[number_zavisimost]) && working == -1)
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> денег | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} очков науки | <color=red> Доступно </color>";
			}
			else if (GlobalScript.inst.gameState.data[21] < data && (number_zavisimost == -1 || GlobalScript.inst.gameState.science[number_zavisimost]) && working == -1)
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> денег | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} очков науки | <color=red> Штраф: +{days * (data - GlobalScript.inst.gameState.data[21]) - GlobalScript.inst.gameState.data[20] * (days / 12)} очков науки </color>";
			}
			else
			{
				T2.text = $"<color=red>{(float)money / 10f}</color> денег | <color=blue>{GlobalScript.inst.gameState.science_time[number]}</color>/{days} очков науки | <color=red> Не доступно </color>";
			}
		}
	}

	private void OnMouseExit()
	{
		Plashka.SetActive(value: false);
	}

	private void OnMouseDown()
	{
		for (int i = 0; i < GlobalScript.inst.gameState.science_in_progress.Length; i++)
		{
			if (GlobalScript.inst.gameState.science_in_progress[i] && !GlobalScript.inst.gameState.science[i])
			{
				working = i;
				Debug.Log(working.ToString());
			}
			else if (i == working && GlobalScript.inst.gameState.science[i])
			{
				working = -1;
				Debug.Log(working.ToString());
			}
		}
		if (((number == 17 && GlobalScript.inst.gameState.data[118] != 0) || number != 17) && !GlobalScript.inst.gameState.science_in_progress[number] && working == -1 && !GlobalScript.inst.gameState.science[number] && GlobalScript.inst.gameState.science_time[number] <= 0)
		{
			if (number_zavisimost == -1 || GlobalScript.inst.gameState.science[number_zavisimost])
			{
				GlobalScript.inst.gameState.science_time[number] += GlobalScript.inst.gameState.data[11];
				if (GlobalScript.inst.gameState.data[21] < data)
				{
					GlobalScript.inst.gameState.science_time[number] -= days * (data - GlobalScript.inst.gameState.data[21]) - GlobalScript.inst.gameState.data[20] * (days / 12);
				}
				GlobalScript.inst.gameState.data[11] = 0;
				GlobalScript.inst.gameState.science_in_progress[number] = true;
				Repaint();
				RepaintPlashka();
				GlobalScript.inst.gameState.data[8] -= money;
				GlobalScript.inst.gameState.leader.is_sleshka = false;
			}
		}
		else
		{
			RepaintPlashka();
		}
		data_sh.Repaint();
	}

	private static string Text(string text, int col)
	{
		int num = 0;
		List<int> list = new List<int>();
		for (int i = 0; i < text.Length; i++)
		{
			if (num >= col)
			{
				if (text[i] == char.Parse(" "))
				{
					num = 0;
					list.Add(i);
					continue;
				}
				for (int num2 = i; num2 >= 0; num2--)
				{
					if (text[num2] == char.Parse(" "))
					{
						list.Add(num2);
						num = i - num2;
						break;
					}
				}
			}
			else
			{
				num++;
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num3 = 0;
		foreach (int item in list)
		{
			stringBuilder.Append(text.Substring(num3, item - num3));
			stringBuilder.Append("\n");
			num3 = item + 1;
		}
		stringBuilder.Append(text.Substring(num3));
		return stringBuilder.ToString();
	}
}
