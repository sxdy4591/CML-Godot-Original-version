using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Savescript : MonoBehaviour
{
	public int number;

	public GlobalScript global1;

	public TextMesh Opis;

	public Sprite navel;

	public Sprite nenavel;

	public bool from_string(string str)
	{
		return str == "True";
	}

	private void Awake()
	{
		global1 = GlobalScript.inst;
	}

	public void OnMouseDown()
	{
		if (number == 5)
		{
			PlayerPrefs.SetString("iron" + (number + 10), GlobalScript.inst.gameState.iron_and_blood.ToString());
		}
		else
		{
			PlayerPrefs.SetString("iron" + (number + 10), "False");
		}
		PlayerPrefs.SetInt("save_diff" + (number + 10), GlobalScript.inst.gameState.diff);
		PlayerPrefs.SetInt("data" + 14 + (number + 10), GlobalScript.inst.gameState.data[14]);
		PlayerPrefs.SetInt("data" + 19 + (number + 10), GlobalScript.inst.gameState.data[19]);
		PlayerPrefs.SetInt("data" + 20 + (number + 10), GlobalScript.inst.gameState.data[20]);
		PlayerPrefs.SetInt("data" + 21 + (number + 10), GlobalScript.inst.gameState.data[21]);
		WriteYugoSave(number);
		if (PlayerPrefs.GetInt("language") == 0)
		{
			Opis.text = " 已 保 存";
		}
		else
		{
			Opis.text = "СОХРАНЕНО";
		}
	}

	private void WriteYugoSave(int num)
	{
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		if (!Directory.Exists("NewData"))
		{
			Directory.CreateDirectory("NewData");
		}
		using FileStream serializationStream = File.Create($"NewData{Path.DirectorySeparatorChar}{num}.save");
		binaryFormatter.Serialize(serializationStream, GlobalScript.inst.gameState);
	}

	private void OnMouseEnter()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (number == 5)
			{
				Opis.text = " 可 解 锁 成 就";
			}
			else
			{
				Opis.text = " 不 可 解 锁 成 就";
			}
			if (PlayerPrefs.HasKey("data14" + (number + 10)))
			{
				TextMesh opis = Opis;
				opis.text = opis.text + "\n 体 制 ：" + GlobalScript.inst.gameState.doctr[PlayerPrefs.GetInt("data14" + (number + 10))];
				TextMesh opis2 = Opis;
				opis2.text = opis2.text + "\n 日 期 ：" + PlayerPrefs.GetInt("data19" + (number + 10)) + "." + PlayerPrefs.GetInt("data20" + (number + 10)) + "." + PlayerPrefs.GetInt("data21" + (number + 10));
				Opis.text += "\n 难 度 ：";
				if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 0)
				{
					Opis.text += " 牛 棚 小 酌";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 1)
				{
					Opis.text += " 上 山 下 乡";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 2)
				{
					Opis.text += " 斗 私 批 修";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 3)
				{
					Opis.text += " 造 反 有 理";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 4)
				{
					Opis.text += " 浩 荡 文 革";
				}
				Opis.text += "\n 成 就 ：";
				if (from_string(PlayerPrefs.GetString("iron" + (number + 10))))
				{
					Opis.text += "<color=red> 可 解 锁 </color>";
				}
				else
				{
					Opis.text += "<color=red> 不 可 解 锁 </color>";
				}
			}
			else
			{
				Opis.text += "\n 空 档 位";
			}
		}
		else
		{
			if (number == 5)
			{
				Opis.text = "С Достижениями";
			}
			else
			{
				Opis.text = "Без Достижений";
			}
			if (PlayerPrefs.HasKey("data14" + (number + 10)))
			{
				TextMesh opis3 = Opis;
				opis3.text = opis3.text + "\nГосстрой: " + GlobalScript.inst.gameState.doctr[PlayerPrefs.GetInt("data14" + (number + 10))];
				TextMesh opis4 = Opis;
				opis4.text = opis4.text + "\nДата: " + PlayerPrefs.GetInt("data19" + (number + 10)) + "." + PlayerPrefs.GetInt("data20" + (number + 10)) + "." + PlayerPrefs.GetInt("data21" + (number + 10));
				Opis.text += "\nСложность: ";
				if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 0)
				{
					Opis.text += "Песочница";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 1)
				{
					Opis.text += "Лёгкий";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 2)
				{
					Opis.text += "Стандарт";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 3)
				{
					Opis.text += "Тяжёлый";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 4)
				{
					Opis.text += "Культурная революция";
				}
				Opis.text += "\nДостижения: ";
				if (from_string(PlayerPrefs.GetString("iron" + (number + 10))))
				{
					Opis.text += "<color=red>Доступны</color>";
				}
				else
				{
					Opis.text += "<color=red>Недоступны</color>";
				}
			}
			else
			{
				Opis.text += "\nПустой слот";
			}
		}
		GetComponent<SpriteRenderer>().sprite = navel;
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = nenavel;
		Opis.text = "";
	}
}
