using UnityEngine;
using UnityEngine.SceneManagement;

public class Show_diplomacy_data_script : MonoBehaviour
{
	private GlobalScript global1;

	public int num;

	public int plankas;

	private TextMesh text;

	private OkoshkoScript okno;

	public bool olyga;

	public bool reserve;

	public bool ne_nushon;

	public bool gosdolg;

	public bool planka_gosdolg;

	public bool corruption;

	public bool planka;

	public bool red_t;

	private string name_ru;

	private string name_en;

	private void Awake()
	{
		global1 = GlobalScript.inst;
		text = GetComponent<TextMesh>();
		okno = GetComponent<OkoshkoScript>();
		if (!ne_nushon && !gosdolg && !corruption && !planka && !reserve)
		{
			name_ru = okno.text;
			name_en = okno.text_en;
			Repaint();
		}
		else if (gosdolg)
		{
			Repaint_dolg();
		}
		else if (olyga)
		{
			Repaint_olyga();
		}
		else if (planka)
		{
			MakePlankaReady();
		}
		else if (reserve)
		{
			ReserveRepaint();
		}
		else
		{
			Repaint2();
		}
	}

	private void Update()
	{
		if (!ne_nushon && !gosdolg && !corruption)
		{
			Repaint();
		}
		else if (gosdolg)
		{
			Repaint_dolg();
		}
		else if (corruption)
		{
			Repaint_corrupt();
		}
		else if (olyga)
		{
			Repaint_olyga();
		}
		else if (planka)
		{
			Repaint_planka();
		}
		else if (reserve)
		{
			ReserveRepaint();
		}
		else
		{
			Repaint2();
		}
	}

	public void Repaint2()
	{
		text.text = (((GlobalScript.inst.gameState.data[num] < 0) ? "-" : "") + Mathf.Abs(GlobalScript.inst.gameState.data[num] / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.data[num] % 10);
	}

	public void MakePlankaReady()
	{
		plankas = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36];
		for (int i = 71; i <= 81; i++)
		{
			plankas += GlobalScript.inst.gameState.data[i];
		}
		plankas /= 6;
		if (GlobalScript.inst.gameState.data[16] > 12)
		{
			plankas -= (GlobalScript.inst.gameState.data[16] - 12) * (plankas / 10);
		}
		Repaint_planka();
	}

	public void Repaint_planka()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text.text = " 最 大 投 资 :\n" + Mathf.Abs(plankas / 10 + 1) + "." + Mathf.Abs(plankas % 10);
		}
		else
		{
			text.text = "Максимальный вклад:\n" + Mathf.Abs(plankas / 10 + 1) + "." + Mathf.Abs(plankas % 10);
		}
	}

	public void ReserveRepaint()
	{
		int num = 0;
		int num2 = 0;
		if (GlobalScript.inst.gameState.data[21] < 1980)
		{
			if (GlobalScript.inst.gameState.data[16] == 13)
			{
				num2 -= GlobalScript.inst.gameState.data[36] / 400;
				num = ((GlobalScript.inst.gameState.data[36] >= 600) ? (num + 1) : (num - (3 - GlobalScript.inst.gameState.data[36] / 150)));
			}
			else if (GlobalScript.inst.gameState.data[16] >= 14)
			{
				num2 -= GlobalScript.inst.gameState.data[36] / 200;
				num = ((GlobalScript.inst.gameState.data[36] >= 750) ? (num + 1) : (num - (4 - GlobalScript.inst.gameState.data[36] / 150)));
			}
		}
		else if (GlobalScript.inst.gameState.data[16] == 13)
		{
			num2 -= GlobalScript.inst.gameState.data[36] / 600;
			num = ((GlobalScript.inst.gameState.data[36] >= 750) ? (num + 1) : (num - (4 - GlobalScript.inst.gameState.data[36] / 150)));
		}
		else if (GlobalScript.inst.gameState.data[16] == 14)
		{
			num2 -= GlobalScript.inst.gameState.data[36] / 400;
			num = ((GlobalScript.inst.gameState.data[36] >= 1500) ? (num + 3) : (num - (7 - GlobalScript.inst.gameState.data[36] / 150)));
		}
		else if (GlobalScript.inst.gameState.data[16] == 15)
		{
			num2 -= GlobalScript.inst.gameState.data[36] / 200;
			num -= 13 - GlobalScript.inst.gameState.data[36] / 150;
		}
		else if (GlobalScript.inst.gameState.data[16] == 12)
		{
			num2 -= GlobalScript.inst.gameState.data[36] / 200;
			num = ((GlobalScript.inst.gameState.data[36] >= 600) ? (num + 1) : (num - (3 - GlobalScript.inst.gameState.data[36] / 150)));
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (num >= 10)
			{
				text.text = " 储 备 金 的 影 响 :\n 第 三 产 业 ，工 业 与 生 活 水 平 : +" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10);
			}
			else if (num <= -10)
			{
				text.text = " 储 备 金 的 影 响 :\n 第 三 产 业 ，工 业 与 生 活 水 平 : -" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10);
			}
			else if (num < 0)
			{
				text.text = " 储 备 金 的 影 响 :\n 第 三 产 业 ，工 业 与 生 活 水 平 : -0." + Mathf.Abs(num);
			}
			else
			{
				text.text = " 储 备 金 的 影 响 :\n 第 三 产 业 ，工 业 与 生 活 水 平 : +0." + num;
			}
			TextMesh textMesh = text;
			textMesh.text = textMesh.text + "\n 腐 败 : -0." + Mathf.Abs(num2);
			TextMesh textMesh2 = text;
			textMesh2.text = textMesh2.text + "\n 盟 国 政 权 稳 定 度 : +" + (float)GlobalScript.inst.gameState.data[36] / 1500f;
		}
		else
		{
			if (num >= 10)
			{
				text.text = "Влияние резерва:\nУслуги, Пром., УрЖ: +" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10);
			}
			else if (num <= -10)
			{
				text.text = "Влияние резерва:\nУслуги, Пром., УрЖ: -" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10);
			}
			else if (num < 0)
			{
				text.text = "Влияние резерва:\nУслуги, Пром., УрЖ: -0." + Mathf.Abs(num);
			}
			else
			{
				text.text = "Влияние резерва:\nУслуги, Пром., УрЖ: +0." + num;
			}
			TextMesh textMesh3 = text;
			textMesh3.text = textMesh3.text + "\nКоррупция -0." + Mathf.Abs(num2);
			TextMesh textMesh4 = text;
			textMesh4.text = textMesh4.text + "\nСтабильность альянса +" + (float)GlobalScript.inst.gameState.data[36] / 1500f;
		}
	}

	public void Repaint_olyga()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (GlobalScript.inst.gameState.data[108] < 18)
			{
				text.text = " 国 内 寡 头 无 立 锥 之 地\n 其 影 响 力 为 : " + GlobalScript.inst.gameState.data[108] + "/100";
			}
			else if (GlobalScript.inst.gameState.data[108] < 36)
			{
				text.text = " 国 内 寡 头 无 足 轻 重\n 其 影 响 力 为 : " + GlobalScript.inst.gameState.data[108] + "/100";
			}
			else if (GlobalScript.inst.gameState.data[108] < 54)
			{
				text.text = " 国 内 寡 头 方 兴 未 艾\n 其 影 响 力 为 : " + GlobalScript.inst.gameState.data[108] + "/100";
			}
			else if (GlobalScript.inst.gameState.data[108] < 72)
			{
				text.text = " 国 内 寡 头 如 日 中 天\n 其 影 响 力 为 : " + GlobalScript.inst.gameState.data[108] + "/100";
			}
			else
			{
				text.text = " 国 内 寡 头 权 倾 朝 野\n 其 影 响 力 为 : " + GlobalScript.inst.gameState.data[108] + "/100";
			}
		}
		else if (GlobalScript.inst.gameState.data[108] < 18)
		{
			text.text = "Олигархов нет\nВлияние: " + GlobalScript.inst.gameState.data[108] + "/100";
		}
		else if (GlobalScript.inst.gameState.data[108] < 36)
		{
			text.text = "Зарождение олигархии\nВлияние: " + GlobalScript.inst.gameState.data[108] + "/100";
		}
		else if (GlobalScript.inst.gameState.data[108] < 54)
		{
			text.text = "Олигархия средней силы\nВлияние: " + GlobalScript.inst.gameState.data[108] + "/100";
		}
		else if (GlobalScript.inst.gameState.data[108] < 72)
		{
			text.text = "Сильная олигархия\nВлияние: " + GlobalScript.inst.gameState.data[108] + "/100";
		}
		else
		{
			text.text = "Засилье олигархии\nВлияние: " + GlobalScript.inst.gameState.data[108] + "/100";
		}
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadSceneAsync("Diplomacy");
		}
	}

	public void Repaint_dolg()
	{
		if (!planka_gosdolg)
		{
			int num = GlobalScript.inst.gameState.data[69] / 40;
			if (num <= 0 && GlobalScript.inst.gameState.data[69] > 0)
			{
				num = 1;
			}
			if (GlobalScript.inst.gameState.data[21] >= 1983 && GlobalScript.inst.gameState.data[69] > 0)
			{
				num += 2;
			}
			else if (GlobalScript.inst.gameState.data[21] >= 1980 && GlobalScript.inst.gameState.data[69] > 0)
			{
				num++;
			}
			if (PlayerPrefs.GetInt("language") == 0)
			{
				text.text = " 债 务 损 耗 : \n 预 算 -" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10);
			}
			else
			{
				text.text = "Потери от долга:\nБюджет -" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10);
			}
		}
		else
		{
			int num2 = (GlobalScript.inst.gameState.empires[0].relations + GlobalScript.inst.gameState.empires[1].relations) / 5;
			if (PlayerPrefs.GetInt("language") == 0)
			{
				text.text = " 债 务 限 额 : \\n" + Mathf.Abs(num2 / 10) + "." + Mathf.Abs(num2 % 10);
			}
			else
			{
				text.text = "Максимальный долг:\n" + Mathf.Abs(num2 / 10) + "." + Mathf.Abs(num2 % 10);
			}
		}
	}

	public void Repaint_corrupt()
	{
		int num = GlobalScript.inst.gameState.data[26] / 10;
		int num2 = GlobalScript.inst.gameState.data[26] / 50;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text.text = " 贪 腐 损 耗 : \n 预 算 -" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10) + "\n 生 活 水 平 : -" + Mathf.Abs(num2 / 10) + "." + Mathf.Abs(num2 % 10);
		}
		else
		{
			text.text = "Потери от коррупции\nБюджет -" + Mathf.Abs(num / 10) + "." + Mathf.Abs(num % 10) + "\nУровень жизни: -" + Mathf.Abs(num2 / 10) + "." + Mathf.Abs(num2 % 10);
		}
	}

	public void Repaint()
	{
		if (num == 28)
		{
			this.text.text = (((GlobalScript.inst.gameState.empires[0].relations < 0) ? "-" : "") + Mathf.Abs(GlobalScript.inst.gameState.empires[0].relations / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[0].relations % 10);
		}
		else if (num == 29)
		{
			this.text.text = (((GlobalScript.inst.gameState.empires[1].relations < 0) ? "-" : "") + Mathf.Abs(GlobalScript.inst.gameState.empires[1].relations / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[1].relations % 10);
		}
		else if (num == 7)
		{
			this.text.text = (((GlobalScript.inst.gameState.influencePRC < 0) ? "-" : "") + Mathf.Abs(GlobalScript.inst.gameState.influencePRC / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.influencePRC % 10);
		}
		else
		{
			this.text.text = (((GlobalScript.inst.gameState.data[num] < 0) ? "-" : "") + Mathf.Abs(GlobalScript.inst.gameState.data[num] / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.data[num] % 10);
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			string text = name_en + ": " + (((GlobalScript.inst.gameState.data_old[num] < 0) ? "-" : "+") + Mathf.Abs(GlobalScript.inst.gameState.data_old[num] / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.data_old[num] % 10);
			if (okno.text_en != text)
			{
				okno.text_en = text;
			}
		}
		else
		{
			string text2 = name_ru + ": " + (((GlobalScript.inst.gameState.data_old[num] < 0) ? "-" : "+") + Mathf.Abs(GlobalScript.inst.gameState.data_old[num] / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.data_old[num] % 10);
			if (okno.text != text2)
			{
				okno.text = text2;
			}
		}
		if (num != 6)
		{
			if (red_t)
			{
				if (GlobalScript.inst.gameState.data[5] < 200)
				{
					this.text.color = Color.red;
				}
				else if (GlobalScript.inst.gameState.data[5] < (GlobalScript.inst.gameState.data[16] - 10) * 100 && GlobalScript.inst.gameState.data[16] > 12)
				{
					this.text.color = Color.red;
				}
				else
				{
					this.text.color = Color.white;
				}
			}
		}
		else if (PlayerPrefs.GetInt("language") == 0)
		{
			if (GlobalScript.inst.gameState.data[6] > 900)
			{
				OkoshkoScript okoshkoScript = okno;
				okoshkoScript.text_en += "\n<color=red> 威 权 派</color>";
			}
			else if (GlobalScript.inst.gameState.data[6] > 790)
			{
				OkoshkoScript okoshkoScript2 = okno;
				okoshkoScript2.text_en += "\n<color=purple> 保 守 派</color>";
			}
			else if (GlobalScript.inst.gameState.data[6] > 590)
			{
				OkoshkoScript okoshkoScript3 = okno;
				okoshkoScript3.text_en += "\n<color=fuchsia> 温 和 派</color>";
			}
			else if (GlobalScript.inst.gameState.data[6] > 390)
			{
				OkoshkoScript okoshkoScript4 = okno;
				okoshkoScript4.text_en += "\n<color=green> 改 革 派</color>";
			}
			else if (GlobalScript.inst.gameState.data[6] > 190)
			{
				OkoshkoScript okoshkoScript5 = okno;
				okoshkoScript5.text_en += "\n<color=aqua> 自 由 派</color>";
			}
			else
			{
				OkoshkoScript okoshkoScript6 = okno;
				okoshkoScript6.text_en += "\n<color=blue> 西 渐 派</color>";
			}
		}
		else if (GlobalScript.inst.gameState.data[6] > 900)
		{
			OkoshkoScript okoshkoScript7 = okno;
			okoshkoScript7.text += "\n<color=red>Авторитарист</color>";
		}
		else if (GlobalScript.inst.gameState.data[6] > 790)
		{
			OkoshkoScript okoshkoScript8 = okno;
			okoshkoScript8.text += "\n<color=red>Консерватор</color>";
		}
		else if (GlobalScript.inst.gameState.data[6] > 590)
		{
			OkoshkoScript okoshkoScript9 = okno;
			okoshkoScript9.text += "\n<color=green>Умеренный</color>";
		}
		else if (GlobalScript.inst.gameState.data[6] > 390)
		{
			OkoshkoScript okoshkoScript10 = okno;
			okoshkoScript10.text += "\n<color=green>Реформист</color>";
		}
		else if (GlobalScript.inst.gameState.data[6] > 190)
		{
			OkoshkoScript okoshkoScript11 = okno;
			okoshkoScript11.text += "\n<color=yellow>Либерал</color>";
		}
		else
		{
			OkoshkoScript okoshkoScript12 = okno;
			okoshkoScript12.text += "\n<color=yellow>Западник</color>";
		}
	}
}
