using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Politic_Manager : MonoBehaviour
{
	public Politic_Show_Data[] data;

	private GlobalScript global1;

	public string[] traits_ru = new string[20];

	public string[] traits_en = new string[21];

	public string[] first_names = new string[GlobalScript.inst.gameState.names1.Length];

	public string[] second_names = new string[GlobalScript.inst.gameState.names2.Length];

	public Politic_Script[] first = new Politic_Script[3];

	public Politic_Script[] second = new Politic_Script[4];

	public Politic_Script[] third = new Politic_Script[5];

	public Politic_Script[] forth = new Politic_Script[6];

	public Button_Pol_Script[] buttons = new Button_Pol_Script[14];

	public TextMesh t_zagovor;

	public TextMesh[] traits = new TextMesh[3];

	public TextMesh name_pol;

	public GameObject buttons_obj;

	public GameObject button_lead_obj;

	public byte selected_politic = 200;

	public byte politic_to_display_loyality = 200;

	public Sprite[] stateDolzh = new Sprite[4];

	public void Awake()
	{
		first_names = new string[GlobalScript.inst.gameState.names1.Length];
		second_names = new string[GlobalScript.inst.gameState.names2.Length];
		for (int i = 0; i < GlobalScript.inst.gameState.names1.Length; i++)
		{
			first_names[i] = GlobalScript.inst.gameState.names1[i];
		}
		for (int j = 0; j < GlobalScript.inst.gameState.names2.Length; j++)
		{
			second_names[j] = GlobalScript.inst.gameState.names2[j];
		}
		GameObject.Find("Bearu(0)").GetComponent<BeurocratsScript>().Repaint();
		GameObject.Find("Bearu(1)").GetComponent<BeurocratsScript>().Repaint();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadSceneAsync("Diplomacy");
		}
	}

	public void RepaintData()
	{
		Politic_Show_Data[] array = data;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Repaint();
		}
	}

	public void Politic_Selected(byte num)
	{
		selected_politic = num;
		if (num != 200 && num != 150)
		{
			buttons_obj.SetActive(value: true);
			button_lead_obj.SetActive(value: false);
			Button_Pol_Script[] array = buttons;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Repaint();
			}
			name_pol.text = $"{first_names[GlobalScript.inst.gameState.politics[num].name_1]} {second_names[GlobalScript.inst.gameState.politics[num].name_2]} ({GlobalScript.inst.gameState.politics[num].age})";
			StringBuilder stringBuilder = new StringBuilder();
			if (PlayerPrefs.GetInt("language") == 0)
			{
				for (int j = 0; j < traits.Length; j++)
				{
					traits[j].text = traits_en[GlobalScript.inst.gameState.politics[num].traits[j]];
				}
				if (GlobalScript.inst.gameState.faction_leader[0] == num)
				{
					stringBuilder.Append($"<color=red>极 左 派 领 袖</color>|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[1] == num)
				{
					stringBuilder.Append($"<color=purple>保 守 派 领 袖</color>|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[2] == num)
				{
					stringBuilder.Append($"<color=fuchsia>温 和 派 领 袖</color>|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[3] == num)
				{
					stringBuilder.Append($"<color=green>改 革 派 领 袖</color>|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[4] == num)
				{
					stringBuilder.Append($"<color=aqua>自 由 派 领 袖</color>|");
				}
				stringBuilder.Append("职 务 ：");
				if (GlobalScript.inst.gameState.politics_dolshnost[0] == num)
				{
					stringBuilder.Append("<color=orange> 国务院总理</color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[1] == num)
				{
					stringBuilder.Append("<color=orange> 中央军委主席</color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[2] == num)
				{
					stringBuilder.Append("<color=orange> 外交部长</color>；");
				}
				stringBuilder.Append("|主 管 ：");
				if (GlobalScript.inst.gameState.politics_dolshnost[3] == num)
				{
					stringBuilder.Append("<color=yellow> 京 畿 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[4] == num)
				{
					stringBuilder.Append("<color=yellow> 华 北 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[5] == num)
				{
					stringBuilder.Append("<color=yellow> 华 西 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[6] == num)
				{
					stringBuilder.Append("<color=yellow> 华 南 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[7] == num)
				{
					stringBuilder.Append("<color=yellow> 华 东 </color>；");
				}
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].is_sledstvie)
				{
					stringBuilder.Append($"距 纪 律 审 查 结 束 ：<color=green>{7 - GlobalScript.inst.gameState.politics[num].sled_slej}</color> 个 月");
				}
				else
				{
					stringBuilder.Append("尚 未 被 纪 律 审 查");
				}
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].is_sleshka)
				{
					stringBuilder.Append($"已 处 于 监 察 调 查 ：<color=green>{GlobalScript.inst.gameState.politics[num].days_sleshka}</color> 个 月|留 置 后 的 影 响 ：{GlobalScript.inst.gameState.ChangeOfKilling(num) * 100f}%");
				}
				else
				{
					stringBuilder.Append("尚 未 被 监 察 调 查 |留 置 后 的 影 响 未 知");
				}
				stringBuilder.Append('|');
				stringBuilder.Append($"影 响 力 ：{GlobalScript.inst.gameState.politics[num].power / 10}.{Mathf.Abs(GlobalScript.inst.gameState.politics[num].power % 10)} ");
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].power <= 250)
				{
					stringBuilder.Append("<color=green>无 影 响 力</color>");
				}
				else if (GlobalScript.inst.gameState.politics[num].power <= 500)
				{
					stringBuilder.Append("<color=pink>弱 影 响 力</color>");
				}
				else if (GlobalScript.inst.gameState.politics[num].power <= 700)
				{
					stringBuilder.Append("<color=yellow>略 有 影 响</color>");
				}
				else
				{
					stringBuilder.Append("<color=red>强 影 响 力</color>");
				}
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].you_fall)
				{
					stringBuilder.Append("<color=red>不 成 功 的 暗 杀 尝 试</color>");
				}
				if (GlobalScript.inst.gameState.politics[num].is_sleshka)
				{
					if (GlobalScript.inst.gameState.politics[num].is_sagovor)
					{
						stringBuilder.Append("<color=red>处 于 阴 谋 的 威 胁 下</color>");
					}
					if (((GlobalScript.inst.gameState.politics[num].loyality < 450 && GlobalScript.inst.gameState.politics[num].traits[2] == 16) || GlobalScript.inst.gameState.politics[num].you_fall || (GlobalScript.inst.gameState.politics[num].loyality < 300 && GlobalScript.inst.gameState.politics[num].traits[2] != 9) || (GlobalScript.inst.gameState.politics[num].loyality < 150 && GlobalScript.inst.gameState.politics[num].traits[2] == 9)) && GlobalScript.inst.gameState.politics[num].traits[2] != 17 && GlobalScript.inst.gameState.politics[num].traits[2] != 19 && !GlobalScript.inst.gameState.politics[num].is_sledstvie)
					{
						stringBuilder.Append("|<color=green>正 在 阴 谋 反 对 你 ！</color>");
					}
				}
			}
			else
			{
				for (int k = 0; k < traits.Length; k++)
				{
					traits[k].text = traits_ru[GlobalScript.inst.gameState.politics[num].traits[k]];
				}
				if (GlobalScript.inst.gameState.faction_leader[0] == num)
				{
					stringBuilder.Append($"Лидер леворадикалов|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[1] == num)
				{
					stringBuilder.Append($"Лидер консерваторов|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[2] == num)
				{
					stringBuilder.Append($"Лидер умеренных|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[3] == num)
				{
					stringBuilder.Append($"Лидер реформаторов|");
				}
				else if (GlobalScript.inst.gameState.faction_leader[4] == num)
				{
					stringBuilder.Append($"Лидер либералов|");
				}
				stringBuilder.Append("<color=red>Портфели</color>: ");
				if (GlobalScript.inst.gameState.politics_dolshnost[0] == num)
				{
					stringBuilder.Append("Премьер; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[1] == num)
				{
					stringBuilder.Append("Председатель Военсовета; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[2] == num)
				{
					stringBuilder.Append("Министр ИД; ");
				}
				stringBuilder.Append("|<color=green>Председатель</color>: ");
				if (GlobalScript.inst.gameState.politics_dolshnost[3] == num)
				{
					stringBuilder.Append("Столицы; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[4] == num)
				{
					stringBuilder.Append("Сев. Региона; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[5] == num)
				{
					stringBuilder.Append("Зап. Региона; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[6] == num)
				{
					stringBuilder.Append("Южн. Региона; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[7] == num)
				{
					stringBuilder.Append("Вост. Региона; ");
				}
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].is_sledstvie)
				{
					stringBuilder.Append($"До окончания следствия: <color=green>{7 - GlobalScript.inst.gameState.politics[num].sled_slej}</color> месяцев");
				}
				else
				{
					stringBuilder.Append("Не под следствием");
				}
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].is_sleshka)
				{
					stringBuilder.Append($"Слежка ещё <color=green>{GlobalScript.inst.gameState.politics[num].days_sleshka}</color> месяцев. Шанс устранения: {GlobalScript.inst.gameState.ChangeOfKilling(num) * 100f}%");
				}
				else
				{
					stringBuilder.Append("Не под слежкой. Шанс устранения неизвестен.");
				}
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].power <= 250)
				{
					stringBuilder.Append("<color=green>Невлиятельный</color>");
				}
				else if (GlobalScript.inst.gameState.politics[num].power <= 500)
				{
					stringBuilder.Append("<color=pink>Маловлиятельный</color>");
				}
				else if (GlobalScript.inst.gameState.politics[num].power <= 700)
				{
					stringBuilder.Append("<color=yellow>Влиятельный</color>");
				}
				else
				{
					stringBuilder.Append("<color=red>Очень влиятельный</color>");
				}
				stringBuilder.Append('|');
				if (GlobalScript.inst.gameState.politics[num].you_fall)
				{
					stringBuilder.Append("<color=red>Неудачная попытка убийства</color>");
				}
				if (GlobalScript.inst.gameState.politics[num].is_sleshka)
				{
					if (GlobalScript.inst.gameState.politics[num].is_sagovor)
					{
						stringBuilder.Append("<color=red>Под угрозой заговора</color>");
					}
					if (((GlobalScript.inst.gameState.politics[num].loyality < 450 && GlobalScript.inst.gameState.politics[num].traits[2] == 16) || GlobalScript.inst.gameState.politics[num].you_fall || (GlobalScript.inst.gameState.politics[num].loyality < 300 && GlobalScript.inst.gameState.politics[num].traits[2] != 9) || (GlobalScript.inst.gameState.politics[num].loyality < 150 && GlobalScript.inst.gameState.politics[num].traits[2] == 9)) && GlobalScript.inst.gameState.politics[num].traits[2] != 17 && GlobalScript.inst.gameState.politics[num].traits[2] != 19 && !GlobalScript.inst.gameState.politics[num].is_sledstvie)
					{
						stringBuilder.Append("|<color=green>В заговоре против Вас!</color>");
					}
				}
			}
			string text = stringBuilder.ToString();
			t_zagovor.text = Text(text, 30);
		}
		else if (num == 150)
		{
			buttons_obj.SetActive(value: false);
			name_pol.text = $"{first_names[GlobalScript.inst.gameState.leader.name_1]} {second_names[GlobalScript.inst.gameState.leader.name_2]}";
			StringBuilder stringBuilder2 = new StringBuilder();
			if (PlayerPrefs.GetInt("language") == 0)
			{
				for (int l = 0; l < traits.Length; l++)
				{
					traits[l].text = traits_en[GlobalScript.inst.gameState.leader.traits[l]];
				}
				stringBuilder2.Append(" 国 家 主 席");
				stringBuilder2.Append("|职 务 ：");
				if (GlobalScript.inst.gameState.politics_dolshnost[0] == num)
				{
					stringBuilder2.Append("<color=orange> 国务院总理</color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[1] == num)
				{
					stringBuilder2.Append("<color=orange> 中央军委主席</color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[2] == num)
				{
					stringBuilder2.Append("<color=orange> 外交部长</color>；");
				}
				stringBuilder2.Append("|主 管 ：");
				if (GlobalScript.inst.gameState.politics_dolshnost[3] == num)
				{
					stringBuilder2.Append("<color=yellow> 京 畿 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[4] == num)
				{
					stringBuilder2.Append("<color=yellow> 华 北 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[5] == num)
				{
					stringBuilder2.Append("<color=yellow> 华 西 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[6] == num)
				{
					stringBuilder2.Append("<color=yellow> 华 南 </color>；");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[7] == num)
				{
					stringBuilder2.Append("<color=yellow> 华 东 </color>；");
				}
			}
			else
			{
				stringBuilder2.Append("Лидер Китая");
				for (int m = 0; m < traits.Length; m++)
				{
					traits[m].text = traits_ru[GlobalScript.inst.gameState.leader.traits[m]];
				}
				stringBuilder2.Append("|<color=red>Портфели</color>: ");
				if (GlobalScript.inst.gameState.politics_dolshnost[0] == num)
				{
					stringBuilder2.Append("Премьер; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[1] == num)
				{
					stringBuilder2.Append("Председатель Военсовета; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[2] == num)
				{
					stringBuilder2.Append("Министр ИД; ");
				}
				stringBuilder2.Append("|<color=green>Председатель</color>: ");
				if (GlobalScript.inst.gameState.politics_dolshnost[3] == num)
				{
					stringBuilder2.Append("Столицы; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[4] == num)
				{
					stringBuilder2.Append("Сев. Региона; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[5] == num)
				{
					stringBuilder2.Append("Зап. Региона; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[6] == num)
				{
					stringBuilder2.Append("Южн. Региона; ");
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[7] == num)
				{
					stringBuilder2.Append("Вост. Региона; ");
				}
			}
			string text2 = stringBuilder2.ToString();
			t_zagovor.text = Text(text2, 30);
		}
		else
		{
			buttons_obj.SetActive(value: false);
			button_lead_obj.SetActive(value: false);
			name_pol.text = null;
			for (int n = 0; n < traits.Length; n++)
			{
				traits[n].text = null;
			}
			t_zagovor.text = null;
		}
	}

	public void ResetPolitics()
	{
		for (int i = 0; i < forth.Length; i++)
		{
			forth[i].this_number = GlobalScript.inst.gameState.p_forth[i];
		}
		for (int j = 0; j < third.Length; j++)
		{
			third[j].this_number = GlobalScript.inst.gameState.p_third[j];
		}
		for (int k = 0; k < second.Length; k++)
		{
			second[k].this_number = GlobalScript.inst.gameState.p_second[k];
		}
		for (int l = 0; l < first.Length; l++)
		{
			first[l].this_number = GlobalScript.inst.gameState.p_first[l];
		}
		RepaintAll();
	}

	private void Start()
	{
		global1 = GlobalScript.inst;
		ResetPolitics();
	}

	public void RepaintAll()
	{
		for (int i = 0; i < forth.Length; i++)
		{
			forth[i].Repaint();
		}
		for (int j = 0; j < third.Length; j++)
		{
			third[j].Repaint();
		}
		for (int k = 0; k < second.Length; k++)
		{
			second[k].Repaint();
		}
		for (int l = 0; l < first.Length; l++)
		{
			first[l].Repaint();
		}
	}

	public void RepaintOnlyShkal()
	{
		for (int i = 0; i < forth.Length; i++)
		{
			forth[i].RepaintShkal();
		}
		for (int j = 0; j < third.Length; j++)
		{
			third[j].RepaintShkal();
		}
		for (int k = 0; k < second.Length; k++)
		{
			second[k].RepaintShkal();
		}
		for (int l = 0; l < first.Length; l++)
		{
			first[l].RepaintShkal();
		}
	}

	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		text = text.Replace("<color=green>", "<g>");
		text = text.Replace("<color=red>", "<r>");
		text = text.Replace("<color=yellow>", "<y>");
		text = text.Replace("<color=brown>", "<p>");
		text = text.Replace("</color>", "<c>");
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == char.Parse("|"))
			{
				num = 0;
				text2 += "\n";
			}
			else if (num >= col)
			{
				if (text[i] == char.Parse(" "))
				{
					num = 0;
					text2 += "\n";
					continue;
				}
				text2 += text[i];
				for (int num2 = i; num2 >= 0; num2--)
				{
					if (text2[num2] == char.Parse(" "))
					{
						text2 = text2.Substring(0, num2) + "\n" + text2.Substring(num2 + 1, text2.Length - 1 - (num2 + 1) + 1);
						num = text2.Length - 1 - (num2 + 1) + 1;
						break;
					}
				}
			}
			else
			{
				text2 += text[i];
				num++;
			}
		}
		text2 = text2.Replace("<g>", "<color=green>");
		text2 = text2.Replace("<r>", "<color=red>");
		text2 = text2.Replace("<y>", "<color=yellow>");
		text2 = text2.Replace("<p>", "<color=brown>");
		return text2.Replace("<c>", "</color>");
	}
}
