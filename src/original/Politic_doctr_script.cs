using UnityEngine;
using UnityEngine.SceneManagement;

public class Politic_doctr_script : MonoBehaviour
{
	private GlobalScript global1;

	public int doctr;

	public bool party_line;

	public bool gosstroy;

	private string text;

	public int hooray;

	private void Awake()
	{
		global1 = GlobalScript.inst;
		text = GlobalScript.inst.gameState.doctr[GlobalScript.inst.gameState.data[doctr]].Replace("|", "\n");
		if (!party_line)
		{
			GetComponent<TextMesh>().text = text;
		}
		else
		{
			GetComponent<TextMesh>().text = GlobalScript.inst.gameState.doctr[GlobalScript.inst.gameState.data[doctr]];
			TextMesh component = GetComponent<TextMesh>();
			component.text = component.text + "\n" + GlobalScript.inst.gameState.doctr[GlobalScript.inst.gameState.data[doctr + 2]];
		}
		ChineseStateSystem();
	}

	private void ChineseStateSystem()
	{
		hooray = 5;
		if (GlobalScript.inst.gameState.data[16] == 10)
		{
			hooray--;
		}
		if (GlobalScript.inst.gameState.data[16] == 15 || GlobalScript.inst.gameState.data[16] == 14)
		{
			if (GlobalScript.inst.gameState.data[17] > 17)
			{
				hooray++;
			}
			else
			{
				hooray--;
			}
		}
		if (GlobalScript.inst.gameState.data[15] == 6)
		{
			hooray--;
		}
		if (GlobalScript.inst.gameState.data[15] == 8)
		{
			hooray++;
		}
		if (GlobalScript.inst.gameState.data[15] == 9)
		{
			hooray += 2;
		}
		if (GlobalScript.inst.gameState.data[17] == 16)
		{
			hooray--;
		}
		if (GlobalScript.inst.gameState.data[17] == 18)
		{
			hooray++;
		}
		if (GlobalScript.inst.gameState.data[17] == 19)
		{
			hooray += 3;
		}
		if (GlobalScript.inst.gameState.data[50] == 24 || GlobalScript.inst.gameState.data[50] == 29)
		{
			hooray -= 2;
		}
		if (GlobalScript.inst.gameState.data[50] == 25 || GlobalScript.inst.gameState.data[50] == 28)
		{
			hooray--;
		}
		if (GlobalScript.inst.gameState.data[50] == 27)
		{
			hooray++;
		}
		if (GlobalScript.inst.gameState.data[18] == 20 && GlobalScript.inst.gameState.data[51] == 30)
		{
			hooray--;
		}
		if (GlobalScript.inst.gameState.data[18] >= 22 && GlobalScript.inst.gameState.data[51] == 33)
		{
			hooray++;
		}
		if (GlobalScript.inst.gameState.data[18] == 23)
		{
			hooray++;
		}
		if (GlobalScript.inst.gameState.modifies[40].active || GlobalScript.inst.gameState.modifies[38].active)
		{
			hooray--;
		}
		if (GlobalScript.inst.gameState.event_done[502] && GlobalScript.inst.gameState.resultOfEvents[502] != 3)
		{
			hooray -= 2;
		}
		if (hooray <= 0)
		{
			GlobalScript.inst.gameState.data[14] = 0;
		}
		else if (hooray <= 3 && GlobalScript.inst.gameState.data[16] <= 11)
		{
			GlobalScript.inst.gameState.data[14] = 1;
		}
		else if (hooray <= 6)
		{
			if (GlobalScript.inst.gameState.data[16] <= 13)
			{
				GlobalScript.inst.gameState.data[14] = 2;
			}
			else
			{
				GlobalScript.inst.gameState.data[14] = 3;
			}
		}
		else if (hooray <= 9)
		{
			if (GlobalScript.inst.gameState.data[16] <= 13)
			{
				if (GlobalScript.inst.gameState.data[16] <= 11)
				{
					GlobalScript.inst.gameState.data[14] = 2;
				}
				else
				{
					GlobalScript.inst.gameState.data[14] = 3;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[14] = 4;
			}
		}
		else if (hooray <= 12)
		{
			if (GlobalScript.inst.gameState.data[16] <= 13)
			{
				if (GlobalScript.inst.gameState.data[16] <= 11)
				{
					GlobalScript.inst.gameState.data[14] = 3;
				}
				else
				{
					GlobalScript.inst.gameState.data[14] = 4;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[14] = 5;
			}
		}
		else if (GlobalScript.inst.gameState.data[16] > 12)
		{
			GlobalScript.inst.gameState.data[14] = 5;
		}
		else if (GlobalScript.inst.gameState.data[16] > 11)
		{
			GlobalScript.inst.gameState.data[14] = 4;
		}
		else
		{
			GlobalScript.inst.gameState.data[14] = 3;
		}
		GlobalScript.inst.gameState.allcountries[1].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
	}

	private void Update()
	{
		text = GlobalScript.inst.gameState.doctr[GlobalScript.inst.gameState.data[doctr]].Replace("|", "\n");
		if (!party_line)
		{
			GetComponent<TextMesh>().text = text;
			return;
		}
		GetComponent<TextMesh>().text = GlobalScript.inst.gameState.doctr[GlobalScript.inst.gameState.data[doctr]];
		TextMesh component = GetComponent<TextMesh>();
		component.text = component.text + "\n" + GlobalScript.inst.gameState.doctr[GlobalScript.inst.gameState.data[doctr + 2]];
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadSceneAsync("Diplomacy");
		}
	}
}
