using System.IO;
using UnityEngine;

public class CreateScript : MonoBehaviour
{
	public GameObject un;

	public GameObject ach;

	public GameObject rules;

	public GameObject[] dlcs = new GameObject[2];

	public Sprite[] dlc_sprites = new Sprite[2];

	private void Awake()
	{
		if (GameObject.Find("Global(Clone)") == null)
		{
			Object.Instantiate(un);
			GameObject gameObject = GameObject.Find("Global(Clone)");
			Object.DontDestroyOnLoad(gameObject);
			gameObject.GetComponent<GlobalScript>().Init();
		}
		GlobalScript inst = GlobalScript.inst;
		if (GameObject.Find("Ach(Clone)") == null)
		{
			Object.Instantiate(ach);
			Object.DontDestroyOnLoad(GameObject.Find("Ach(Clone)"));
		}
		GlobalScript.inst.gameState.turn_on = true;
		if (inst.dlc[0])
		{
			rules.SetActive(value: true);
			for (int i = 0; i < GlobalScript.inst.gameState.gamerules.Length; i++)
			{
				PlayerPrefs.GetInt("gamerules" + i);
				GlobalScript.inst.gameState.gamerules[i] = PlayerPrefs.GetInt("gamerules" + i);
			}
		}
		else
		{
			rules.SetActive(value: false);
		}
		CheckDLC();
	}

	private void CheckDLC()
	{
		try
		{
			if (Application.platform == RuntimePlatform.WindowsPlayer)
			{
				if (File.Exists(Application.dataPath + "\\BD01.txt") && File.Exists(Application.dataPath + "\\BD01.png"))
				{
					GlobalScript.inst.dlc[1] = true;
					dlcs[0].GetComponent<SpriteRenderer>().sprite = dlc_sprites[0];
					dlcs[0].GetComponent<OkoshkoScript>().text_en = "《 捐 躯 赴 国 难 》 已 激 活";
					dlcs[0].GetComponent<OkoshkoScript>().text = "\"Родина или Смерть\" включен";
				}
				else
				{
					GlobalScript.inst.dlc[1] = false;
					dlcs[0].GetComponent<OkoshkoScript>().text_en = "需 要 《 捐 躯 赴 国 难 》";
					dlcs[0].GetComponent<OkoshkoScript>().text = "\"Родина или Смерть\" не куплен";
				}
				if (File.Exists(Application.dataPath + "\\BD22.txt") && File.Exists(Application.dataPath + "\\BD02.png"))
				{
					GlobalScript.inst.dlc[2] = true;
					dlcs[1].GetComponent<SpriteRenderer>().sprite = dlc_sprites[1];
					dlcs[1].GetComponent<OkoshkoScript>().text_en = "《 炮 打 司 令 部 》 已 激 活";
					dlcs[1].GetComponent<OkoshkoScript>().text = "\"Огонь по штабам\" включен";
				}
				else
				{
					GlobalScript.inst.dlc[2] = false;
					dlcs[1].GetComponent<OkoshkoScript>().text_en = "需 要 《 炮 打 司 令 部 》";
					dlcs[1].GetComponent<OkoshkoScript>().text = "\"Огонь по штабам\" не куплен";
				}
				if (File.Exists(Application.dataPath + "\\FE0323.txt") && File.Exists(Application.dataPath + "\\070323.png"))
				{
					GlobalScript.inst.dlc[3] = true;
					dlcs[2].GetComponent<SpriteRenderer>().sprite = dlc_sprites[2];
					dlcs[2].GetComponent<OkoshkoScript>().text_en = "《 白 头 鹰 之 殇 》 已 激 活";
					dlcs[2].GetComponent<OkoshkoScript>().text = "\"Падший Орёл\" включен";
				}
				else
				{
					GlobalScript.inst.dlc[3] = false;
					dlcs[2].GetComponent<OkoshkoScript>().text_en = "需 要 《 白 头 鹰 之 殇 》";
					dlcs[2].GetComponent<OkoshkoScript>().text = "\"Падший Орёл\" не куплен";
				}
			}
			else
			{
				if (File.Exists(Application.dataPath + "/BD01.txt") && File.Exists(Application.dataPath + "/BD01.png"))
				{
					GlobalScript.inst.dlc[1] = true;
					dlcs[0].GetComponent<SpriteRenderer>().sprite = dlc_sprites[0];
					dlcs[0].GetComponent<OkoshkoScript>().text_en = "《 捐 躯 赴 国 难 》 已 激 活";
					dlcs[0].GetComponent<OkoshkoScript>().text = "\"Родина или Смерть\" включен";
				}
				else
				{
					GlobalScript.inst.dlc[1] = false;
					dlcs[0].GetComponent<OkoshkoScript>().text_en = "需 要 《 捐 躯 赴 国 难 》";
					dlcs[0].GetComponent<OkoshkoScript>().text = "\"Родина или Смерть\" не куплен";
				}
				if (File.Exists(Application.dataPath + "/BD22.txt") && File.Exists(Application.dataPath + "/BD02.png"))
				{
					GlobalScript.inst.dlc[2] = true;
					dlcs[1].GetComponent<SpriteRenderer>().sprite = dlc_sprites[1];
					dlcs[1].GetComponent<OkoshkoScript>().text_en = "《 炮 打 司 令 部 》 已 激 活";
					dlcs[1].GetComponent<OkoshkoScript>().text = "\"Огонь по штабам\" включен";
				}
				else
				{
					GlobalScript.inst.dlc[2] = false;
					dlcs[1].GetComponent<OkoshkoScript>().text_en = "需 要 《 炮 打 司 令 部 》";
					dlcs[1].GetComponent<OkoshkoScript>().text = "\"Огонь по штабам\" не куплен";
				}
				if (File.Exists(Application.dataPath + "/FE0323.txt") && File.Exists(Application.dataPath + "/070323.png"))
				{
					GlobalScript.inst.dlc[3] = true;
					dlcs[2].GetComponent<SpriteRenderer>().sprite = dlc_sprites[2];
					dlcs[2].GetComponent<OkoshkoScript>().text_en = "《 白 头 鹰 之 殇 》 已 激 活";
					dlcs[2].GetComponent<OkoshkoScript>().text = "\"Падший Орёл\" включен";
				}
				else
				{
					GlobalScript.inst.dlc[3] = false;
					dlcs[2].GetComponent<OkoshkoScript>().text_en = "需 要 《 白 头 鹰 之 殇 》";
					dlcs[2].GetComponent<OkoshkoScript>().text = "\"Падший Орёл\" не куплен";
				}
			}
		}
		catch
		{
			GlobalScript.inst.dlc[1] = false;
			GlobalScript.inst.dlc[2] = false;
			dlcs[0].GetComponent<OkoshkoScript>().text_en = "未 购 买 《 捐 躯 赴 国 难 》";
			dlcs[0].GetComponent<OkoshkoScript>().text = "\"Родина или Смерть\" не куплена";
		}
	}
}
