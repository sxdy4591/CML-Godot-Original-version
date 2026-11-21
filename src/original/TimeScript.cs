using System;
using System.Collections.Generic;
using System.Linq;
using KGFocus;
using KGWar;
using ModifiesInfluenceSpace;
using ReqEventsDLC02;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
	public GameObject ending;

	public bool is_showed;

	private int save_speed;

	private int this_num_event;

	private int this_num_place;

	private GlobalScript global1;

	private GameState global2;

	public float now_time;

	public EvetnnashScript goto_economy;

	private SpeedScript goto_pause;

	public GameObject dlc_button;

	public GameObject dlc_button2;

	public GameObject[] alarmIcons = new GameObject[6];

	public GameObject probel;

	public GameObject firstS;

	public GameObject secondS;

	public GameObject thirdS;

	public SpriteRenderer[] crisis = new SpriteRenderer[8];

	public TextMesh[] crisis_color = new TextMesh[8];

	public TextMesh thisText;

	public bool vybory;

	private GameObject achieves;

	public GameObject crisis_show;

	private bool donedone;

	public at_war_script[] re_war = new at_war_script[11];

	public Savescript Autosavej;

	public LoadInScript Autoloadej;

	public int ch_support;

	public int ch_profit;

	public int ch_lib;

	private bool event44;

	private MapChangesScript map1;

	public GameObject[] events = new GameObject[26];

	public void Awake()
	{
		global2 = GlobalScript.inst.gameState;
		map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		global1 = GlobalScript.inst;
		goto_pause = GameObject.Find("Button (0)").GetComponent<SpeedScript>();
		achieves = GameObject.Find("Ach(Clone)");
		Repaint(need_to_pluse: false);
		for (int i = 0; i < re_war.Length; i++)
		{
			re_war[i].Repaint();
		}
		AlarmIconChange();
		if (!global1.dlc[0])
		{
			dlc_button.SetActive(value: false);
		}
		if (!global1.dlc[1] && !global1.dlc[3])
		{
			dlc_button2.SetActive(value: false);
		}
	}

	private void AlarmIconChange()
	{
		for (int i = 0; i < global2.politics_dolshnost.Length; i++)
		{
			if (global2.politics_dolshnost[i] == 200)
			{
				alarmIcons[2].SetActive(value: true);
				break;
			}
		}
		if (global2.leader.is_sagovor || global2.data[1] - 70 <= 300 + global2.data[4] / 5 - (global2.data[3] - 500) / 5)
		{
			alarmIcons[1].SetActive(value: true);
		}
		if (global2.leader.is_sleshka)
		{
			alarmIcons[0].SetActive(value: true);
		}
		if ((global2.modifies[16].active && global2.allcountries[1].isSEV && GlobalScript.inst.dlc[3]) || (global2.data[139] > 0 && global2.data[140] > 0))
		{
			alarmIcons[3].GetComponent<OkoshkoScript>().text_en = (alarmIcons[3].GetComponent<OkoshkoScript>().text = string.Format(GlobalScript.inst.other_text[250], global2.data[139]));
			alarmIcons[3].SetActive(value: true);
		}
		else
		{
			alarmIcons[3].SetActive(value: false);
		}
		if ((global2.modifies[17].active && global2.allcountries[1].isASEAN && GlobalScript.inst.dlc[3]) || (global2.data[139] > 0 && global2.data[140] > 0))
		{
			alarmIcons[4].GetComponent<OkoshkoScript>().text_en = (alarmIcons[4].GetComponent<OkoshkoScript>().text = string.Format(GlobalScript.inst.other_text[251], global2.data[139]));
			alarmIcons[4].SetActive(value: true);
			Debug.Log("ХУЙ ХУЙ ХУЙ");
		}
		else
		{
			alarmIcons[4].SetActive(value: false);
		}
		if (global2.data[141] > 0 && GlobalScript.inst.dlc[3] && (global2.allcountries[1].isOVD || global2.allcountries[1].isSEATO))
		{
			alarmIcons[5].GetComponent<OkoshkoScript>().text_en = (alarmIcons[5].GetComponent<OkoshkoScript>().text = string.Format(global2.allcountries[1].isOVD ? GlobalScript.inst.other_text[290] : GlobalScript.inst.other_text[291], global2.allcountries[global2.data[141]].name, global2.data[142]));
			alarmIcons[5].SetActive(value: true);
		}
		else
		{
			alarmIcons[5].SetActive(value: false);
		}
	}

	private void AutoSaveMethod()
	{
		Autosavej.number = global1.savePlace;
		Autosavej.OnMouseDown();
		thisText.text = GlobalScript.inst.new_texts[662];
	}

	private void AutoLoadMethod()
	{
		Autoloadej.number = global1.savePlace;
		Autoloadej.OnMouseDown();
		thisText.text = GlobalScript.inst.new_texts[663];
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !is_showed)
		{
			probel.GetComponent<SpeedScript>().Probel();
		}
		if (Input.GetKeyDown(KeyCode.W) && !is_showed)
		{
			SceneManager.LoadScene("War");
		}
		if (GlobalScript.inst.gameState.diff == 0)
		{
			if (Input.GetKey(KeyCode.LeftControl) && !is_showed)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1) && !is_showed)
				{
					GlobalScript.inst.gameState.data[1] += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha2) && !is_showed)
				{
					GlobalScript.inst.gameState.data[3] += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha3) && !is_showed)
				{
					GlobalScript.inst.gameState.data[4] += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha4) && !is_showed)
				{
					GlobalScript.inst.gameState.data[5] += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha5) && !is_showed)
				{
					GlobalScript.inst.gameState.data[6] -= 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha6) && !is_showed)
				{
					GlobalScript.inst.gameState.influencePRC += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha7) && !is_showed)
				{
					GlobalScript.inst.gameState.data[8] += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha8) && !is_showed)
				{
					GlobalScript.inst.gameState.data[9] += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha9) && !is_showed)
				{
					GlobalScript.inst.gameState.data[22] += 100;
				}
				if (Input.GetKeyDown(KeyCode.Alpha0) && !is_showed)
				{
					GlobalScript.inst.gameState.empires[0].relations += 100;
					GlobalScript.inst.gameState.empires[1].relations += 100;
				}
				if (Input.GetKeyDown(KeyCode.A) && !is_showed)
				{
					if (GlobalScript.inst.gameState.relres)
					{
						GlobalScript.inst.gameState.relres = false;
					}
					else
					{
						GlobalScript.inst.gameState.relres = true;
					}
				}
			}
		}
		else if (Input.GetKeyDown(KeyCode.Alpha1) && !is_showed)
		{
			firstS.GetComponent<SpeedScript>().FirstSpeed();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha2) && !is_showed)
		{
			secondS.GetComponent<SpeedScript>().FirstSpeed();
		}
		else if (Input.GetKeyDown(KeyCode.Alpha3) && !is_showed)
		{
			thirdS.GetComponent<SpeedScript>().FirstSpeed();
		}
		else if (Input.GetKeyDown(KeyCode.F5) && !is_showed)
		{
			AutoSaveMethod();
		}
		else if (Input.GetKeyDown(KeyCode.F9) && !is_showed)
		{
			AutoLoadMethod();
		}
		now_time += (float)global1.speed * Time.deltaTime;
		// 移植调整: 原版 8f → 最快档(4速) 0.3 秒一天; 1速 1.2 秒一天.
		if (now_time >= 1.2f)
		{
			now_time = 0f;
			Repaint(need_to_pluse: true);
			KumihaRepaint();
		}
	}

	private void KumihaRepaint()
	{
		global2.data[28] = global2.empires[0].relations;
		global2.data[29] = global2.empires[1].relations;
		global2.data[7] = global2.influencePRC;
	}

	public void Reborn()
	{
		if (!is_showed)
		{
			ending.SetActive(value: true);
			is_showed = true;
			save_speed = global1.speed;
			global1.speed = 0;
		}
		else
		{
			is_showed = false;
			ending.SetActive(value: false);
		}
	}

	private void Reelect(int event_n)
	{
		if (event_n == 2)
		{
			vybory = false;
			global2.is_elect = true;
		}
		global1.speed = 0;
		global2.event_done[event_n] = true;
		global2.number_event = event_n;
		SceneManager.LoadScene("Event");
	}

	private void ToEnding(int ending_n)
	{
		global1.speed = 0;
		global2.data[35] = ending_n;
		SceneManager.LoadScene("Ending");
	}

	private void PlotPlayer()
	{
		if (global2.data[38] < 100)
		{
			return;
		}
		for (int i = 0; i < global2.politics.Length; i++)
		{
			if (global2.politics.Where((Politic pol) => ((pol.loyality < 300 && pol.traits[2] == 16) || pol.you_fall || (pol.loyality < 150 && pol.traits[2] != 9) || (pol.loyality < 50 && pol.traits[2] == 9)) && pol.traits[2] != 17 && pol.traits[2] != 19 && !pol.is_sledstvie).Sum((Politic pol) => pol.power) / 5 > global2.data[1])
			{
				Reelect(4);
			}
		}
	}

	private void PlotPlayerCause()
	{
		for (int i = 0; i < global2.politics.Length; i++)
		{
			if (global2.politics.Where((Politic pol) => ((pol.loyality < 300 && pol.traits[2] == 16) || pol.you_fall || (pol.loyality < 150 && pol.traits[2] != 9) || (pol.loyality < 50 && pol.traits[2] == 9)) && pol.traits[2] != 17 && pol.traits[2] != 19 && !pol.is_sledstvie).Sum((Politic pol) => pol.power) / 5 > global2.data[1] / 4 * 3)
			{
				alarmIcons[1].SetActive(value: true);
				global2.leader.is_sagovor = true;
			}
			else
			{
				alarmIcons[1].SetActive(value: false);
				global2.leader.is_sagovor = false;
			}
		}
	}

	private void PlotPolitics()
	{
		if (global2.data[38] < 100)
		{
			return;
		}
		Func<Politic, bool> func = null;
		int i;
		for (i = 0; i < global2.politics.Length; i++)
		{
			if (global2.politics[i].power <= 250 && global2.gamerules[4] != 1)
			{
				continue;
			}
			double num = 0.0;
			if (!global1.dlc[0] || global2.gamerules[4] < 2)
			{
				Politic[] politics = global2.politics;
				Func<Politic, bool> predicate;
				if ((predicate = func) == null)
				{
					predicate = (func = (Politic pol) => ((pol.loyality_to_other[i] < 450 && pol.traits[2] == 16) || (pol.loyality_to_other[i] < 300 && pol.traits[2] != 9) || (pol.loyality_to_other[i] < 150 && pol.traits[2] == 9)) && pol.traits[2] != 17 && pol.traits[2] != 19 && !pol.is_sledstvie);
				}
				num = politics.Where(predicate).Sum((Politic pol) => pol.power);
			}
			else if (global1.dlc[0] && global2.gamerules[4] == 2)
			{
				num = global2.politics.Where((Politic pol) => pol.traits[2] == 16 && !pol.is_sledstvie).Sum((Politic pol) => pol.power);
			}
			double num2 = 3.0;
			if (global2.politics[i].traits[2] == 14 || global2.politics[i].traits[2] == 13)
			{
				num2 = 5.0;
			}
			else if (global2.politics[i].traits[2] == 12 || global2.politics[i].traits[1] == 6)
			{
				num2 = 2.0;
			}
			if (global2.politics_dolshnost[0] == i)
			{
				num2 += 2.0;
			}
			if (global2.politics_dolshnost[1] == i)
			{
				num2 += 1.0;
			}
			if (global2.politics_dolshnost[2] == i)
			{
				num2 += 1.0;
			}
			if (num > num2 * (double)global2.politics[i].power)
			{
				global2.politics[i].is_sagovor = true;
				if (UnityEngine.Random.Range(0, 11) <= global2.data[57] / 100 || UnityEngine.Random.Range(0, 22) <= global2.data[57] / 50 || UnityEngine.Random.Range(0, 44) <= global2.data[57] / 25)
				{
					continue;
				}
				if (num > num2 * 4.0 * (double)global2.politics[i].power && ((i > 5 && i != 7 && (i < 11 || i > 15) && i != 17) || (global2.event_done[25] && global2.data[84] != 3 && (i < 12 || i > 15)) || (global2.event_done[26] && (global2.leader.name_1 != 0 || i == 1)) || (global2.data[21] >= 1978 && !global2.event_done[80] && global2.modifies[3].active && i > 4) || (global2.data[21] >= 1978 && (global2.event_done[80] || !global2.modifies[3].active)) || (global2.event_done[25] && global2.data[84] == 3 && (i < 1 || i > 4))) && (i > 4 || !global2.modifies[3].active))
				{
					if (global2.politics_dolshnost[0] != i && global2.politics_dolshnost[1] != i && global2.politics_dolshnost[2] != i)
					{
						Debug.Log("УБИТ");
						global2.KillPerson(i);
						continue;
					}
					Debug.Log("СНЯТ С ПОСТА");
					if (global2.politics_dolshnost[0] == i)
					{
						global2.politics_dolshnost[0] = 200;
					}
					if (global2.politics_dolshnost[1] == i)
					{
						global2.politics_dolshnost[1] = 200;
					}
					if (global2.politics_dolshnost[2] == i)
					{
						global2.politics_dolshnost[2] = 200;
					}
					global2.politics[i].power = 100;
				}
				else
				{
					Debug.Log("ПОНИЖЕН");
					global2.politics[i].power -= global2.politics[i].power / 10;
				}
			}
			else
			{
				global2.politics[i].is_sagovor = false;
			}
		}
	}

	private void DeathPolitics()
	{
		if (global2.data[38] < 100)
		{
			return;
		}
		for (int i = 0; i < global2.politics.Length; i++)
		{
			if (global2.politics[i].age >= (byte)UnityEngine.Random.Range(91, 95) && (!global1.dlc[0] || (global1.dlc[0] && global2.gamerules[6] <= 1)))
			{
				global2.KillPerson(i);
			}
			else if (((global2.politics[i].age >= (byte)UnityEngine.Random.Range(80, 84) && global2.politics[i].traits[0] != 2) || (global2.politics[i].age >= (byte)UnityEngine.Random.Range(85, 89) && global2.politics[i].traits[0] == 2)) && global2.politics[i].traits[2] != 19)
			{
				global2.politics[i].traits[2] = 19;
			}
			else if (global1.dlc[0] && global2.gamerules[6] == 1)
			{
				if (global2.politics[i].in_power >= 5)
				{
					global2.KillPerson(i);
				}
				else if (global2.data[19] == 1 && global2.data[20] == 1)
				{
					Politic politic = global2.politics[i];
					politic.in_power++;
				}
			}
		}
	}

	private void Repaint(bool need_to_pluse)
	{
		if (need_to_pluse)
		{
			ref int reference = ref global2.data[36];
			if (global2.data[8] < 0)
			{
				if (global2.data[36] + (global2.data[8] + global2.data[36]) >= 0)
				{
					global2.data[36] += global2.data[8];
					global2.data[8] = 0;
				}
				else
				{
					global2.data[8] += global2.data[36];
					global2.data[36] = 0;
					if (global2.data[8] < 0)
					{
						global1.speed = 0;
						goto_economy.OnMouseDown();
					}
				}
			}
			bool flag = false;
			for (int i = 0; i < global2.politics_dolshnost.Length; i++)
			{
				if (global2.politics_dolshnost[i] == 200)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				alarmIcons[2].SetActive(value: true);
			}
			else
			{
				alarmIcons[2].SetActive(value: false);
			}
			_ = global2.data[34];
			int[] array = new int[global2.data_old.Length];
			for (int j = 1; j < global2.data_old.Length; j++)
			{
				array[j] = global2.data[j];
			}
			array[28] = global2.empires[0].relations;
			array[29] = global2.empires[1].relations;
			array[7] = global2.influencePRC;
			thisText.text = null;
			if (is_showed)
			{
				save_speed = global1.speed;
				global1.speed = 0;
			}
			global2.data[19]++;
			if ((global2.data[20] == 2 && global2.data[19] == 29 && ((global2.data[21] % 4 != 0 && global2.data[21] % 400 != 0) || global2.data[21] % 100 == 0)) || (global2.data[20] == 2 && global2.data[19] == 30 && ((global2.data[21] % 4 == 0 && global2.data[21] % 100 != 0) || global2.data[21] % 400 == 0)) || (global2.data[19] == 31 && (global2.data[20] == 4 || global2.data[20] == 6 || global2.data[20] == 9 || global2.data[20] == 11)) || (global2.data[19] == 32 && (global2.data[20] == 1 || global2.data[20] == 3 || global2.data[20] == 5 || global2.data[20] == 7 || global2.data[20] == 8 || global2.data[20] == 10 || global2.data[20] == 12)))
			{
				global2.data[19] = 1;
				global2.data[20]++;
				global2.bylo = false;
			}
			if (global2.data[20] == 13)
			{
				global2.data[20] = 1;
				global2.data[21]++;
				global2.data[119] = UnityEngine.Random.Range(1, 7);
				global2.data[121] = UnityEngine.Random.Range(7, 13);
				for (int k = 0; k < global2.politics.Length; k++)
				{
					Politic politic = global2.politics[k];
					Politic politic2 = politic;
					politic2.age++;
				}
				if (global2.data[15] > 7)
				{
					global2.data[125]++;
				}
				global2.is_elect = false;
				global2.data[24] += global2.ImportChange(global2);
				if (global2.diff == 4)
				{
					global2.data[24] += 5;
				}
				if (global2.data[106] > 1 && (global2.data[15] == 8 || global2.data[15] == 7))
				{
					global2.data[106] = global2.data[106] / 2;
				}
			}
			WorldWarsDone();
			if (!global2.allcountries[136].cw && global2.data[21] == 1984)
			{
				global2.allcountries[136].SubGosstroy = 4;
			}
			else if (!global2.allcountries[136].cw && global2.data[21] == 1978)
			{
				global2.allcountries[136].SubGosstroy = 6;
			}
			if (global2.data[19] == 4 && global2.data[20] == 12 && global2.data[21] == 1976 && !global2.event_done[582])
			{
				global2.allcountries[65].name = "中 非 帝 国";
			}
			if (global2.data[19] == 1 && global2.data[20] == 11 && global2.data[21] == 1979)
			{
				global2.allcountries[57].Gosstroy = 3;
				global2.allcountries[57].SubGosstroy = 5;
				global2.allcountries[57].puppetOf = -1;
			}
			if (global2.data[19] == 16 && global2.data[20] == 12 && global2.data[21] == 1980 && global2.resultOfEvents[512] != 2)
			{
				global2.allcountries[57].Gosstroy = 0;
				global2.allcountries[57].SubGosstroy = 10;
				global2.allcountries[57].puppetOf = 13;
			}
			if (global2.data[19] == 1 && global2.data[20] == 9 && global2.data[21] == 1981 && global2.allcountries[65].puppetOf == 21 && !global2.event_done[583])
			{
				global2.allcountries[65].Gosstroy = 0;
				global2.allcountries[65].SubGosstroy = 7;
			}
			if (GlobalScript.inst.gameState.event_done[326] && GlobalScript.inst.gameState.resultOfEvents[326] == 0 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[50] <= 25 && GlobalScript.inst.gameState.data[15] == 6 && GlobalScript.inst.gameState.data[16] <= 11)
			{
				GlobalScript.inst.old_modify_texts[28] = "无 产 阶 级 宪 法";
				GlobalScript.inst.old_modify_desc[28] = " 极 左 派+3 ， 极 左 派 力 量+3 ， 党 内 支 持 度-0.5 ， 人 民 支 持 度+1.5 ， 思 想 自 由 化-1.5 ， 腐 败-0.2 ， 预 算+0.3 ， 特 工 网 络+0.3";
			}
			else
			{
				GlobalScript.inst.old_modify_texts[28] = "75 宪 法";
				GlobalScript.inst.old_modify_desc[28] = " 极 左 派 、 保 守 派+1 ， 极 左 派 、 保 守 派 力 量+1 ， 党 内 支 持 度-0.2 ， 人 民 支 持 度+0.2 ， 思 想 自 由 化-0.2 ， 腐 败-0.2 ， 特 工 网 络+0.2";
			}
			if (GlobalScript.inst.gameState.modifies[6].active)
			{
				GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
				GlobalScript.inst.gameState.doctr[8] = "人 民 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = "协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = "经 典 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = "中 式 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = "国 家 监 护 资 本 主 义";
				GlobalScript.inst.gameState.doctr[14] = "社 会 主 义 导 向 市 场";
				GlobalScript.inst.gameState.doctr[15] = "左 翼 小 政 府";
				GlobalScript.inst.gameState.doctr[21] = "改 良 区 域 自 治 制 度";
				GlobalScript.inst.gameState.doctr[22] = "联 邦 制";
				GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
			}
			else
			{
				GlobalScript.inst.gameState.doctr[6] = " 一 党 制 共 和 国";
				GlobalScript.inst.gameState.doctr[7] = "一 党 独 大 式 民 主";
				GlobalScript.inst.gameState.doctr[8] = " 宪 政 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = " 协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = " 中 央 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = " 分 权 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = " 鸟 笼 经 济";
				GlobalScript.inst.gameState.doctr[14] = " “ 社 会 ” 市 场 经 济";
				GlobalScript.inst.gameState.doctr[15] = " 最 小 干 预";
				GlobalScript.inst.gameState.doctr[21] = " 联 邦 制";
				GlobalScript.inst.gameState.doctr[22] = " 联 省 自 治";
				GlobalScript.inst.gameState.doctr[24] = " 破 除 传 统";
			}
			if (GlobalScript.inst.gameState.resultOfEvents[444] == 0 && GlobalScript.inst.gameState.event_done[444])
			{
				GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
				GlobalScript.inst.gameState.doctr[19] = "自 由 境 界";
				GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
			}
			if (GlobalScript.inst.gameState.modifies[11].active)
			{
				GlobalScript.inst.gameState.doctr[10] = GlobalScript.inst.new_events_text[360];
				GlobalScript.inst.gameState.doctr[11] = GlobalScript.inst.new_events_text[361];
			}
			if (GlobalScript.inst.gameState.modifies[46].active && GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
			{
				GlobalScript.inst.old_modify_texts[46] = " 阿 拉 伯 革 命 社 会 主 义 共 和 国 联 盟";
			}
			if (GlobalScript.inst.gameState.allcountries[159].puppetOf == 21)
			{
				GlobalScript.inst.gameState.allcountries[159].Gosstroy = GlobalScript.inst.gameState.allcountries[21].Gosstroy;
				GlobalScript.inst.gameState.allcountries[159].SubGosstroy = GlobalScript.inst.gameState.allcountries[21].SubGosstroy;
			}
			if (GlobalScript.inst.gameState.allcountries[154].puppetOf == 21)
			{
				GlobalScript.inst.gameState.allcountries[154].Gosstroy = GlobalScript.inst.gameState.allcountries[21].Gosstroy;
				GlobalScript.inst.gameState.allcountries[154].SubGosstroy = GlobalScript.inst.gameState.allcountries[21].SubGosstroy;
			}
			if (GlobalScript.inst.gameState.IsSocialism(yes: true, 21) && GlobalScript.inst.gameState.allcountries[154].puppetOf == 21 && !GlobalScript.inst.gameState.event_done[483])
			{
				GlobalScript.inst.gameState.allcountries[154].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[154].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[154].LeaveAlliances();
				if (GlobalScript.inst.gameState.allcountries[154].cw)
				{
					GlobalScript.inst.gameState.allcountries[154].proprc = true;
					GlobalScript.inst.gameState.allcountries[154].Torg = true;
				}
			}
			if (!GlobalScript.inst.gameState.IsSocialism(yes: true, 149) && GlobalScript.inst.gameState.allcountries[149].Gosstroy != 2 && GlobalScript.inst.gameState.allcountries[149].level_of_unstab > 500 && !global2.ingamewars[64].is_going)
			{
				global2.ingamewars[64] = new War().Name("危 地 马 拉 内 战").Attacker("军 政 府").Defender("U R N G")
					.AttackerInfluence(500)
					.DefenderInfluence(500)
					.TickTime(24)
					.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
				GlobalScript.inst.gameState.allcountries[149].parts[1] = true;
			}
			if ((GlobalScript.inst.gameState.IsSocialism(yes: true, 149) || GlobalScript.inst.gameState.allcountries[149].Gosstroy == 2) && GlobalScript.inst.gameState.allcountries[149].level_of_unstab < 500 && !global2.ingamewars[64].is_going)
			{
				global2.ingamewars[64] = new War().Name("危 地 马 拉 内 战").Attacker("军 政 府").Defender("U R N G")
					.AttackerInfluence(500)
					.DefenderInfluence(500)
					.TickTime(24)
					.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
				GlobalScript.inst.gameState.allcountries[149].parts[1] = true;
			}
			if ((GlobalScript.inst.gameState.IsSocialism(yes: true, 147) || GlobalScript.inst.gameState.allcountries[147].Gosstroy == 2) && GlobalScript.inst.gameState.allcountries[147].level_of_unstab < 500 && !global2.ingamewars[67].is_going)
			{
				global2.ingamewars[67] = new War().Name("尼 加 拉 瓜 内 战").Attacker("康 特 拉").Defender("F S L N")
					.AttackerInfluence(500)
					.DefenderInfluence(500)
					.TickTime(24)
					.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
				GlobalScript.inst.gameState.allcountries[147].parts[0] = true;
			}
			if (!GlobalScript.inst.gameState.allcountries[123].cw && GlobalScript.inst.gameState.allcountries[123].prcpower >= 900 && GlobalScript.inst.gameState.allcountries[123].sovpower > 0 && GlobalScript.inst.gameState.allcountries[123].usapower > 0 && !global2.ingamewars[68].is_going)
			{
				GlobalScript.inst.gameState.allcountries[123].prcpower = 1000;
				GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
				GlobalScript.inst.gameState.allcountries[123].usapower = 0;
				global2.ingamewars[68] = new War().Name("安 哥 拉 内 战").Attacker("安 人 运").Defender("安 盟 - 安 解 阵")
					.AttackerInfluence(700)
					.DefenderInfluence(300)
					.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
				GlobalScript.inst.gameState.allcountries[123].parts[0] = true;
			}
			if (!GlobalScript.inst.gameState.allcountries[123].cw && GlobalScript.inst.gameState.allcountries[123].sovpower >= 900 && GlobalScript.inst.gameState.allcountries[123].prcpower > 0 && GlobalScript.inst.gameState.allcountries[123].usapower > 0 && !global2.ingamewars[68].is_going)
			{
				GlobalScript.inst.gameState.allcountries[123].sovpower = 1000;
				GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
				GlobalScript.inst.gameState.allcountries[123].usapower = 0;
				global2.ingamewars[68] = new War().Name("安 哥 拉 内 战").Attacker("安 盟").Defender("安 人 运")
					.AttackerInfluence(600)
					.DefenderInfluence(400)
					.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
				GlobalScript.inst.gameState.allcountries[123].parts[0] = true;
			}
			if (!GlobalScript.inst.gameState.allcountries[123].cw && GlobalScript.inst.gameState.allcountries[123].usapower >= 900 && GlobalScript.inst.gameState.allcountries[123].prcpower > 0 && GlobalScript.inst.gameState.allcountries[123].sovpower > 0 && !global2.ingamewars[68].is_going)
			{
				GlobalScript.inst.gameState.allcountries[123].usapower = 1000;
				GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
				GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
				global2.ingamewars[68] = new War().Name("安 哥 拉 内 战").Attacker("安 解 阵").Defender("安 人 运 - 安 盟")
					.AttackerInfluence(500)
					.DefenderInfluence(500)
					.SovietSupportDefender.AmericanSupportDefender.CreateWar;
				GlobalScript.inst.gameState.allcountries[123].parts[0] = true;
			}
			if (global2.data[19] == 1 && global2.data[20] == 1 && global2.data[21] == 1986)
			{
				Debug.Log("it just works");
				Reborn();
			}
			else if (global2.data[19] == 1 && global2.data[20] == 1 && global2.data[21] == 1980)
			{
				if (global2.iron_and_blood)
				{
					if (global2.data[34] >= 10000)
					{
						achieves.GetComponent<achievements>().Set(63);
					}
					if (global2.data[12] >= 700 && global2.data[13] >= 700 && global2.data[68] >= 700)
					{
						achieves.GetComponent<achievements>().Set(62);
					}
				}
			}
			else if (global2.data[19] == 1 && global2.data[20] == 1 && global2.data[21] == 1983)
			{
				Leader leader = global2.empires[1].leaders[5];
				leader.support++;
			}
			if (global2.data[34] < 6671)
			{
				ToEnding(4);
			}
			if (global2.data[15] > 7 && global2.data[19] == 1 && global2.data[20] == 10)
			{
				vybory = true;
				global2.is_elect = true;
				Reelect(1);
			}
			if (global2.allcountries[12].isSEV && global2.allcountries[12].Vyshi)
			{
				global2.allcountries[12].Vyshi = false;
			}
			if (global2.data[21] >= 1978 && !global2.event_done[44])
			{
				int num = 0;
				int num2 = 0;
				for (int l = 0; l < global2.politics.Length; l++)
				{
					if (global2.politics[l].traits[0] == 2)
					{
						num += global2.politics[l].power;
					}
					else if (global2.politics[l].traits[0] == 0)
					{
						num2 += global2.politics[l].power;
					}
					else if (global2.politics[l].traits[0] == 20)
					{
						num2 += global2.politics[l].power;
						num2 -= global2.politics[l].power / 3;
					}
				}
				if (num >= num2)
				{
					event44 = true;
				}
			}
			if (global2.data[19] == 1 && global2.data[20] == 1)
			{
				if (global2.empires[1].money >= 200 && UnityEngine.Random.Range(0, 5) == 1)
				{
					Empire empire = global2.empires[1];
					empire.money -= 100;
					global2.data[160] += 500;
				}
				if (global2.empires[0].money >= 200 && UnityEngine.Random.Range(0, 5) == 1)
				{
					Empire empire = global2.empires[0];
					empire.money -= 100;
					global2.data[161] += 500;
				}
				global2.allcountries[1].dev = 0;
				global2.allcountries[92].spec = 0;
				global2.allcountries[21].spec = 0;
				Country country;
				if (global2.allcountries[24].prcpower > 0 && global2.allcountries[24].prcpower < 100)
				{
					country = global2.allcountries[24];
					country.prcpower -= 10;
				}
				if (global2.allcountries[149].level_of_unstab > 0 && global2.allcountries[149].level_of_unstab < 1000)
				{
					country = global2.allcountries[149];
					country.level_of_unstab += 10;
					if (global2.IsSocialism(yes: true, 149) || global2.allcountries[149].Gosstroy == 2)
					{
						country = global2.allcountries[149];
						country.level_of_unstab -= 10;
						if (global2.allcountries[141].Vyshi)
						{
							country = global2.allcountries[149];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[140].Vyshi)
						{
							country = global2.allcountries[149];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[148].Vyshi)
						{
							country = global2.allcountries[149];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[147].Vyshi)
						{
							country = global2.allcountries[149];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[146].Vyshi)
						{
							country = global2.allcountries[149];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[144].Vyshi)
						{
							country = global2.allcountries[149];
							country.level_of_unstab -= 10;
						}
					}
					if (global2.IsSocialism(yes: true, 147) || global2.allcountries[147].Gosstroy == 2)
					{
						country = global2.allcountries[149];
						country.level_of_unstab += 25;
					}
					if (global2.IsSocialism(yes: true, 148) || global2.allcountries[148].Gosstroy == 2)
					{
						country = global2.allcountries[149];
						country.level_of_unstab += 25;
					}
					if (global2.allcountries[138].proprc)
					{
						country = global2.allcountries[149];
						country.level_of_unstab += 25;
					}
					if (global2.allcountries[141].proprc)
					{
						country = global2.allcountries[149];
						country.level_of_unstab += 25;
					}
				}
				if (global2.allcountries[147].level_of_unstab > 0 && global2.allcountries[147].level_of_unstab < 1000)
				{
					country = global2.allcountries[147];
					country.level_of_unstab += 10;
					if (global2.IsSocialism(yes: true, 147) || global2.allcountries[147].Gosstroy == 2)
					{
						country = global2.allcountries[147];
						country.level_of_unstab -= 10;
						if (global2.allcountries[141].Vyshi)
						{
							country = global2.allcountries[147];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[140].Vyshi)
						{
							country = global2.allcountries[147];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[148].Vyshi)
						{
							country = global2.allcountries[147];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[147].Vyshi)
						{
							country = global2.allcountries[147];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[146].Vyshi)
						{
							country = global2.allcountries[147];
							country.level_of_unstab -= 10;
						}
						if (global2.allcountries[144].Vyshi)
						{
							country = global2.allcountries[147];
							country.level_of_unstab -= 10;
						}
					}
					if (global2.IsSocialism(yes: true, 149) || global2.allcountries[149].Gosstroy == 2)
					{
						country = global2.allcountries[147];
						country.level_of_unstab += 25;
					}
					if (global2.IsSocialism(yes: true, 148) || global2.allcountries[148].Gosstroy == 2)
					{
						country = global2.allcountries[147];
						country.level_of_unstab += 25;
					}
					if (global2.allcountries[138].proprc)
					{
						country = global2.allcountries[147];
						country.level_of_unstab += 25;
					}
					if (global2.allcountries[141].proprc)
					{
						country = global2.allcountries[147];
						country.level_of_unstab += 25;
					}
				}
				if (global2.allcountries[14].prcpower > 0)
				{
					country = global2.allcountries[14];
					country.prcpower -= 10;
				}
				if (global2.allcountries[44].prcpower > 0)
				{
					country = global2.allcountries[44];
					country.prcpower -= 10;
				}
				if (global2.allcountries[44].prcinfl > 0)
				{
					country = global2.allcountries[44];
					country.prcinfl -= 5;
				}
				if (global2.allcountries[112].level_of_unstab > 0)
				{
					country = global2.allcountries[112];
					country.level_of_unstab -= 100;
				}
				if (global2.data[21] != 1976)
				{
					country = global2.allcountries[87];
					country.spec += 5;
				}
				global2.allcountries[1].inflNATO = 0;
				global2.allcountries[1].inflCh = 0;
				global2.allcountries[1].based = false;
				global2.allcountries[87].based = false;
				if (global2.data[21] == 1986)
				{
					if (global2.allcountries[86].Gosstroy == 3 && global2.allcountries[0].isEU)
					{
						global2.allcountries[86].JoinEU();
					}
					if (global2.allcountries[87].Gosstroy == 3 && global2.allcountries[0].isEU)
					{
						global2.allcountries[87].JoinEU();
					}
				}
				if (global2.allcountries[1].isSEATO)
				{
					for (int m = 0; m < global2.allcountries.Length; m++)
					{
						if (global2.allcountries[m].isSEATO)
						{
							global2.allcountries[1].cw = false;
						}
					}
				}
				for (int n = 0; n < global2.allcountries.Length; n++)
				{
					global2.allcountries[n].perevorot = false;
				}
				global2.allcountries[11].stab = 0;
				global2.allcountries[19].stab = 0;
				global2.allcountries[12].stab = 0;
				global2.allcountries[21].stab = 0;
				global2.allcountries[47].stab = 0;
				global2.allcountries[51].stab = 0;
				global2.allcountries[19].prcpower = 0;
				country = global2.allcountries[60];
				country.prcpower -= 5;
				global2.allcountries[33].cw = false;
				country = global2.allcountries[33];
				country.inflCh -= 5;
				global2.war_active[0] = false;
				global2.war_active[1] = false;
				GlobalScript.inst.gameState.data[106] /= 10;
				GlobalScript.inst.gameState.party_number[0] /= 10;
				GlobalScript.inst.gameState.party_number[1] /= 10;
				GlobalScript.inst.gameState.party_number[2] /= 10;
				GlobalScript.inst.gameState.party_number[3] /= 10;
				GlobalScript.inst.gameState.party_number[4] /= 10;
			}
			if (global2.data[60] == 0 && global2.allcountries[20].proprc && (global2.data[14] > 3 || global2.data[15] > 7 || global2.data[16] > 13 || global2.data[50] > 28 || global2.data[52] > 36 || global2.allcountries[1].isSEATO))
			{
				global2.allcountries[20].proprc = false;
				global2.allcountries[20].Torg = false;
				global2.allcountries[20].econ = false;
				global2.allcountries[20].okb = false;
			}
			for (int num3 = 0; num3 < GlobalScript.inst.gameState.allcountries.Length; num3++)
			{
				if (num3 != 1 && global2.allcountries[num3].proprc && (((global2.data[14] > 3 || global2.data[15] > 7 || global2.data[16] > 13 || global2.data[50] > 28 || global2.allcountries[1].isSEATO) && GlobalScript.inst.gameState.allcountries[num3].SubGosstroy == 17) || ((global2.data[14] > 3 || global2.data[15] > 7 || global2.data[16] > 13 || global2.data[50] > 28 || global2.data[52] > 36 || global2.allcountries[1].isSEATO) && GlobalScript.inst.gameState.allcountries[num3].SubGosstroy == 0)))
				{
					GlobalScript.inst.gameState.allcountries[num3].proprc = false;
				}
			}
			if (GlobalScript.inst.gameState.allcountries[24].parts[0] && GlobalScript.inst.gameState.allcountries[24].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[24].proprc && (global2.data[14] > 3 || global2.data[15] > 7 || global2.data[16] > 13 || global2.data[50] > 28 || global2.data[52] > 36 || global2.allcountries[1].isSEATO))
			{
				GlobalScript.inst.gameState.allcountries[24].proprc = false;
			}
			if (global2.data[60] == 0 && !global2.allcountries[20].proprc && (global2.allcountries[20].econ || global2.allcountries[20].okb))
			{
				global2.allcountries[20].econ = false;
				global2.allcountries[20].okb = false;
			}
			global2.data[25] = 0;
			global2.data[23] = global2.data[70];
			for (int num4 = 0; num4 < global2.allcountries.Length; num4++)
			{
				if (global2.allcountries[num4].isSEV && global2.allcountries[1].isSEV)
				{
					if (num4 == 51 || num4 == 7)
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy > 0)
						{
							global2.data[23] += 12 * (2 + (3 - global2.allcountries[num4].Gosstroy));
						}
						else
						{
							global2.data[23] += 36;
						}
						continue;
					}
					if (num4 == 17 || num4 == 16 || num4 == 92 || num4 == 21 || num4 == 85 || num4 == 19 || num4 == 8 || (num4 == 30 && (global2.allcountries[30].parts[0] || global2.allcountries[30].parts[1] || global2.allcountries[30].parts[2])) || num4 == 135 || num4 == 137 || num4 == 44 || num4 == 73 || num4 == 71 || num4 == 28 || num4 == 91)
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy > 0)
						{
							global2.data[23] += 8 * (2 + (3 - global2.allcountries[num4].Gosstroy));
						}
						else
						{
							global2.data[23] += 24;
						}
						continue;
					}
					if (num4 == 90 || num4 == 37 || num4 == 20 || num4 == 29 || num4 == 27 || num4 == 39 || num4 == 89 || num4 == 88 || num4 == 5 || num4 == 6 || num4 == 45 || num4 == 15 || num4 == 30 || num4 == 13 || num4 == 35 || num4 == 34 || num4 == 14 || num4 == 11 || num4 == 50 || num4 == 47 || num4 == 46 || num4 == 10 || num4 == 36 || num4 == 101 || num4 == 102 || num4 == 103 || num4 == 104 || num4 == 105 || num4 == 31 || num4 == 131 || num4 == 140 || num4 == 2 || num4 == 4 || num4 == 3 || num4 == 98 || num4 == 84 || num4 == 86 || num4 == 138 || num4 == 49 || num4 == 26 || num4 == 74 || num4 == 83 || num4 == 75 || num4 == 117 || (num4 == 24 && global2.allcountries[24].parts[0]) || (num4 == 25 && global2.allcountries[25].parts[0]))
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy > 0)
						{
							global2.data[23] += 5 * (2 + (3 - global2.allcountries[num4].Gosstroy));
						}
						else
						{
							global2.data[23] += 15;
						}
						continue;
					}
					switch (num4)
					{
					case 24:
					case 25:
					case 32:
					case 33:
					case 38:
					case 40:
					case 41:
					case 54:
					case 55:
					case 60:
					case 76:
					case 80:
					case 82:
					case 87:
					case 95:
					case 96:
					case 119:
					case 122:
					case 123:
					case 124:
					case 126:
					case 127:
					case 136:
					case 141:
						if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 2 * (2 + (3 - global2.allcountries[num4].Gosstroy));
							}
							else
							{
								global2.data[23] += 6;
							}
						}
						else
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 4 * (2 + (3 - global2.allcountries[num4].Gosstroy));
							}
							else
							{
								global2.data[23] += 12;
							}
						}
						break;
					default:
						if (num4 != 141 && num4 != 79 && num4 != 81 && num4 != 77 && num4 != 78 && num4 != 43 && num4 != 97 && num4 != 72 && num4 != 12 && num4 != 69 && num4 != 70 && num4 != 149 && num4 != 150)
						{
							if (global2.allcountries[num4].stab < 300)
							{
								global2.data[25]++;
								global2.data[23] -= 2;
								Country country = global2.allcountries[num4];
								country.stab += 50;
							}
							else if (global2.allcountries[num4].stab < 600)
							{
								global2.data[25]++;
								global2.data[23]--;
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else if (global2.allcountries[num4].stab < 800)
							{
								global2.data[25]++;
								if (global2.allcountries[num4].Gosstroy > 0)
								{
									global2.data[23] += 2 + (3 - global2.allcountries[num4].Gosstroy);
								}
								else
								{
									global2.data[23] += 3;
								}
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else
							{
								global2.data[25]++;
								if (global2.allcountries[num4].Gosstroy > 0)
								{
									global2.data[23] += 3 * (2 + (3 - global2.allcountries[num4].Gosstroy));
								}
								else
								{
									global2.data[23] += 9;
								}
							}
							break;
						}
						goto case 22;
					case 22:
					case 23:
					case 128:
						if (global2.allcountries[num4].stab < 300)
						{
							global2.data[25]++;
							global2.data[23] -= 2;
							Country country = global2.allcountries[num4];
							country.stab += 50;
						}
						else if (global2.allcountries[num4].stab < 600)
						{
							global2.data[25]++;
							global2.data[23]--;
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 2 + (3 - global2.allcountries[num4].Gosstroy);
							}
							else
							{
								global2.data[23] += 3;
							}
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 3 * (2 + (3 - global2.allcountries[num4].Gosstroy));
							}
							else
							{
								global2.data[23] += 9;
							}
						}
						break;
					}
				}
				else if (global2.allcountries[num4].econ && global2.allcountries[1].econ)
				{
					if (num4 == 51 || num4 == 7)
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy > 0)
						{
							global2.data[23] += 12 * (2 + (3 - global2.allcountries[num4].Gosstroy));
						}
						else
						{
							global2.data[23] += 36;
						}
						continue;
					}
					if (num4 == 17 || num4 == 16 || num4 == 92 || num4 == 21 || num4 == 85 || num4 == 19 || num4 == 8 || (num4 == 30 && (global2.allcountries[30].parts[0] || global2.allcountries[30].parts[1] || global2.allcountries[30].parts[2])) || num4 == 135 || num4 == 137 || num4 == 44 || num4 == 73 || num4 == 71 || num4 == 28 || num4 == 91)
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy > 0)
						{
							global2.data[23] += 8 * (2 + (3 - global2.allcountries[num4].Gosstroy));
						}
						else
						{
							global2.data[23] += 24;
						}
						continue;
					}
					if (num4 == 90 || num4 == 37 || num4 == 20 || num4 == 29 || num4 == 27 || num4 == 39 || num4 == 89 || num4 == 88 || num4 == 5 || num4 == 6 || num4 == 45 || num4 == 15 || num4 == 30 || num4 == 13 || num4 == 35 || num4 == 34 || num4 == 14 || num4 == 11 || num4 == 50 || num4 == 47 || num4 == 46 || num4 == 10 || num4 == 36 || num4 == 101 || num4 == 102 || num4 == 103 || num4 == 104 || num4 == 105 || num4 == 31 || num4 == 131 || num4 == 140 || num4 == 2 || num4 == 4 || num4 == 3 || num4 == 98 || num4 == 84 || num4 == 86 || num4 == 138 || num4 == 49 || num4 == 26 || num4 == 74 || num4 == 83 || num4 == 75 || num4 == 117 || (num4 == 24 && global2.allcountries[24].parts[0]) || (num4 == 25 && global2.allcountries[25].parts[0]))
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy > 0)
						{
							global2.data[23] += 5 * (2 + (3 - global2.allcountries[num4].Gosstroy));
						}
						else
						{
							global2.data[23] += 15;
						}
						continue;
					}
					switch (num4)
					{
					case 24:
					case 25:
					case 32:
					case 33:
					case 38:
					case 40:
					case 41:
					case 54:
					case 55:
					case 60:
					case 76:
					case 80:
					case 82:
					case 87:
					case 95:
					case 96:
					case 119:
					case 122:
					case 123:
					case 124:
					case 126:
					case 127:
					case 136:
					case 141:
						if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 2 * (2 + (3 - global2.allcountries[num4].Gosstroy));
							}
							else
							{
								global2.data[23] += 6;
							}
						}
						else
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 4 * (2 + (3 - global2.allcountries[num4].Gosstroy));
							}
							else
							{
								global2.data[23] += 12;
							}
						}
						break;
					default:
						if (num4 != 141 && num4 != 79 && num4 != 81 && num4 != 77 && num4 != 78 && num4 != 43 && num4 != 97 && num4 != 72 && num4 != 12 && num4 != 69 && num4 != 70 && num4 != 149 && num4 != 150)
						{
							if (global2.allcountries[num4].stab < 300)
							{
								global2.data[25]++;
								global2.data[23] -= 2;
								Country country = global2.allcountries[num4];
								country.stab += 50;
							}
							else if (global2.allcountries[num4].stab < 600)
							{
								global2.data[25]++;
								global2.data[23]--;
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else if (global2.allcountries[num4].stab < 800)
							{
								global2.data[25]++;
								if (global2.allcountries[num4].Gosstroy > 0)
								{
									global2.data[23] += 2 + (3 - global2.allcountries[num4].Gosstroy);
								}
								else
								{
									global2.data[23] += 3;
								}
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else
							{
								global2.data[25]++;
								if (global2.allcountries[num4].Gosstroy > 0)
								{
									global2.data[23] += 3 * (2 + (3 - global2.allcountries[num4].Gosstroy));
								}
								else
								{
									global2.data[23] += 9;
								}
							}
							break;
						}
						goto case 22;
					case 22:
					case 23:
					case 128:
						if (global2.allcountries[num4].stab < 300)
						{
							global2.data[25]++;
							global2.data[23] -= 2;
							Country country = global2.allcountries[num4];
							country.stab += 50;
						}
						else if (global2.allcountries[num4].stab < 600)
						{
							global2.data[25]++;
							global2.data[23]--;
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 2 + (3 - global2.allcountries[num4].Gosstroy);
							}
							else
							{
								global2.data[23] += 3;
							}
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy > 0)
							{
								global2.data[23] += 3 * (2 + (3 - global2.allcountries[num4].Gosstroy));
							}
							else
							{
								global2.data[23] += 9;
							}
						}
						break;
					}
				}
				else if ((global2.allcountries[num4].isASEAN || global2.allcountries[num4].Vyshi) && global2.allcountries[1].isASEAN)
				{
					if (num4 == 51 || num4 == 7)
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
						{
							global2.data[23] += 24;
						}
						else if (global2.allcountries[num4].Gosstroy == 3)
						{
							global2.data[23] += 36;
						}
						continue;
					}
					if (num4 == 17 || num4 == 16 || num4 == 92 || num4 == 21 || num4 == 85 || num4 == 19 || num4 == 8 || (num4 == 30 && (global2.allcountries[30].parts[0] || global2.allcountries[30].parts[1] || global2.allcountries[30].parts[2])) || num4 == 135 || num4 == 137 || num4 == 44 || num4 == 73 || num4 == 71 || num4 == 28 || num4 == 91)
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
						{
							global2.data[23] += 16;
						}
						else if (global2.allcountries[num4].Gosstroy == 3)
						{
							global2.data[23] += 24;
						}
						continue;
					}
					if (num4 == 90 || num4 == 37 || num4 == 20 || num4 == 29 || num4 == 27 || num4 == 39 || num4 == 89 || num4 == 88 || num4 == 5 || num4 == 6 || num4 == 45 || num4 == 15 || num4 == 30 || num4 == 13 || num4 == 35 || num4 == 34 || num4 == 14 || num4 == 11 || num4 == 50 || num4 == 47 || num4 == 46 || num4 == 10 || num4 == 36 || num4 == 101 || num4 == 102 || num4 == 103 || num4 == 104 || num4 == 105 || num4 == 31 || num4 == 131 || num4 == 140 || num4 == 2 || num4 == 4 || num4 == 3 || num4 == 98 || num4 == 84 || num4 == 86 || num4 == 138 || num4 == 49 || num4 == 26 || num4 == 74 || num4 == 83 || num4 == 75 || num4 == 117 || (num4 == 24 && global2.allcountries[24].parts[0]) || (num4 == 25 && global2.allcountries[25].parts[0]))
					{
						global2.data[25]++;
						if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
						{
							global2.data[23] += 10;
						}
						else if (global2.allcountries[num4].Gosstroy == 3)
						{
							global2.data[23] += 15;
						}
						continue;
					}
					switch (num4)
					{
					case 24:
					case 25:
					case 32:
					case 33:
					case 38:
					case 40:
					case 41:
					case 54:
					case 55:
					case 60:
					case 76:
					case 80:
					case 82:
					case 87:
					case 95:
					case 96:
					case 119:
					case 122:
					case 123:
					case 124:
					case 126:
					case 127:
					case 136:
					case 141:
						if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
							{
								global2.data[23] += 4;
							}
							else if (global2.allcountries[num4].Gosstroy == 3)
							{
								global2.data[23] += 6;
							}
						}
						else if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
						{
							global2.data[23] += 8;
						}
						else if (global2.allcountries[num4].Gosstroy == 3)
						{
							global2.data[23] += 12;
						}
						break;
					default:
						if (num4 != 141 && num4 != 79 && num4 != 81 && num4 != 77 && num4 != 78 && num4 != 43 && num4 != 97 && num4 != 72 && num4 != 12 && num4 != 69 && num4 != 70 && num4 != 149 && num4 != 150)
						{
							if (global2.allcountries[num4].stab < 300)
							{
								global2.data[25]++;
								global2.data[23] -= 2;
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else if (global2.allcountries[num4].stab < 600)
							{
								global2.data[25]++;
								global2.data[23]--;
								Country country = global2.allcountries[num4];
								country.stab += 100;
							}
							else if (global2.allcountries[num4].stab < 800)
							{
								global2.data[25]++;
								if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
								{
									global2.data[23] += 2;
								}
								else if (global2.allcountries[num4].Gosstroy == 3)
								{
									global2.data[23] += 3;
								}
								Country country = global2.allcountries[num4];
								country.stab += 100;
							}
							else
							{
								global2.data[25]++;
								if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
								{
									global2.data[23] += 6;
								}
								else if (global2.allcountries[num4].Gosstroy == 3)
								{
									global2.data[23] += 9;
								}
							}
							break;
						}
						goto case 22;
					case 22:
					case 23:
					case 128:
						if (global2.allcountries[num4].stab < 300)
						{
							global2.data[25]++;
							global2.data[23] -= 2;
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else if (global2.allcountries[num4].stab < 600)
						{
							global2.data[25]++;
							global2.data[23]--;
							Country country = global2.allcountries[num4];
							country.stab += 100;
						}
						else if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
							{
								global2.data[23] += 2;
							}
							else if (global2.allcountries[num4].Gosstroy == 3)
							{
								global2.data[23] += 3;
							}
							Country country = global2.allcountries[num4];
							country.stab += 100;
						}
						else
						{
							global2.data[25]++;
							if (global2.allcountries[num4].Gosstroy == 0 || global2.allcountries[num4].Gosstroy == 2)
							{
								global2.data[23] += 6;
							}
							else if (global2.allcountries[num4].Gosstroy == 3)
							{
								global2.data[23] += 9;
							}
						}
						break;
					}
				}
				else if (global2.allcountries[num4].proprc)
				{
					if (num4 == 51 || num4 == 7)
					{
						global2.data[25]++;
						global2.data[23] += 24;
						continue;
					}
					if (num4 == 17 || num4 == 16 || num4 == 92 || num4 == 21 || num4 == 85 || num4 == 19 || num4 == 8 || (num4 == 30 && (global2.allcountries[30].parts[0] || global2.allcountries[30].parts[1] || global2.allcountries[30].parts[2])) || num4 == 135 || num4 == 137 || num4 == 44 || num4 == 73 || num4 == 71 || num4 == 28 || num4 == 91)
					{
						global2.data[25]++;
						global2.data[23] += 16;
						continue;
					}
					if (num4 == 90 || num4 == 37 || num4 == 20 || num4 == 29 || num4 == 27 || num4 == 39 || num4 == 89 || num4 == 88 || num4 == 5 || num4 == 6 || num4 == 45 || num4 == 15 || num4 == 30 || num4 == 13 || num4 == 35 || num4 == 34 || num4 == 14 || num4 == 11 || num4 == 50 || num4 == 47 || num4 == 46 || num4 == 10 || num4 == 36 || num4 == 101 || num4 == 102 || num4 == 103 || num4 == 104 || num4 == 105 || num4 == 31 || num4 == 131 || num4 == 140 || num4 == 2 || num4 == 4 || num4 == 3 || num4 == 98 || num4 == 84 || num4 == 86 || num4 == 138 || num4 == 49 || num4 == 26 || num4 == 74 || num4 == 83 || num4 == 75 || num4 == 117 || (num4 == 24 && global2.allcountries[24].parts[0]) || (num4 == 25 && global2.allcountries[25].parts[0]))
					{
						global2.data[25]++;
						global2.data[23] += 10;
						continue;
					}
					switch (num4)
					{
					case 24:
					case 25:
					case 32:
					case 33:
					case 38:
					case 40:
					case 41:
					case 54:
					case 55:
					case 60:
					case 76:
					case 80:
					case 82:
					case 87:
					case 95:
					case 96:
					case 119:
					case 122:
					case 123:
					case 124:
					case 126:
					case 127:
					case 136:
					case 141:
						if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							global2.data[23] += 4;
						}
						else
						{
							global2.data[25]++;
							global2.data[23] += 8;
						}
						break;
					default:
						if (num4 != 141 && num4 != 79 && num4 != 81 && num4 != 77 && num4 != 78 && num4 != 43 && num4 != 97 && num4 != 72 && num4 != 12 && num4 != 69 && num4 != 70 && num4 != 149 && num4 != 150)
						{
							if (global2.allcountries[num4].stab < 300)
							{
								global2.data[25]++;
								global2.data[23] -= 2;
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else if (global2.allcountries[num4].stab < 600)
							{
								global2.data[25]++;
								global2.data[23]--;
								Country country = global2.allcountries[num4];
								country.stab += 100;
							}
							else if (global2.allcountries[num4].stab < 800)
							{
								global2.data[25]++;
								global2.data[23] += 2;
								Country country = global2.allcountries[num4];
								country.stab += 100;
							}
							else
							{
								global2.data[25]++;
								global2.data[23] += 6;
							}
							break;
						}
						goto case 22;
					case 22:
					case 23:
					case 128:
						if (global2.allcountries[num4].stab < 300)
						{
							global2.data[25]++;
							global2.data[23] -= 2;
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else if (global2.allcountries[num4].stab < 600)
						{
							global2.data[25]++;
							global2.data[23]--;
							Country country = global2.allcountries[num4];
							country.stab += 100;
						}
						else if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							global2.data[23] += 2;
							Country country = global2.allcountries[num4];
							country.stab += 100;
						}
						else
						{
							global2.data[25]++;
							global2.data[23] += 6;
						}
						break;
					}
				}
				else
				{
					if (!global2.allcountries[num4].Torg)
					{
						continue;
					}
					if (num4 == 51 || num4 == 7)
					{
						global2.data[25]++;
						global2.data[23] += 12;
						continue;
					}
					if (num4 == 17 || num4 == 16 || num4 == 92 || num4 == 21 || num4 == 85 || num4 == 19 || num4 == 8 || (num4 == 30 && (global2.allcountries[30].parts[0] || global2.allcountries[30].parts[1] || global2.allcountries[30].parts[2])) || num4 == 135 || num4 == 137 || num4 == 44 || num4 == 73 || num4 == 71 || num4 == 28 || num4 == 91)
					{
						global2.data[25]++;
						global2.data[23] += 8;
						continue;
					}
					if (num4 == 90 || num4 == 37 || num4 == 20 || num4 == 29 || num4 == 27 || num4 == 39 || num4 == 89 || num4 == 88 || num4 == 5 || num4 == 6 || num4 == 45 || num4 == 15 || num4 == 30 || num4 == 13 || num4 == 35 || num4 == 34 || num4 == 14 || num4 == 11 || num4 == 50 || num4 == 47 || num4 == 46 || num4 == 10 || num4 == 36 || num4 == 101 || num4 == 102 || num4 == 103 || num4 == 104 || num4 == 105 || num4 == 31 || num4 == 131 || num4 == 140 || num4 == 2 || num4 == 4 || num4 == 3 || num4 == 98 || num4 == 84 || num4 == 86 || num4 == 138 || num4 == 49 || num4 == 26 || num4 == 74 || num4 == 83 || num4 == 75 || num4 == 117 || (num4 == 24 && global2.allcountries[24].parts[0]) || (num4 == 25 && global2.allcountries[25].parts[0]))
					{
						global2.data[25]++;
						global2.data[23] += 5;
						continue;
					}
					switch (num4)
					{
					case 24:
					case 25:
					case 32:
					case 33:
					case 38:
					case 40:
					case 41:
					case 54:
					case 55:
					case 60:
					case 76:
					case 80:
					case 82:
					case 87:
					case 95:
					case 96:
					case 119:
					case 122:
					case 123:
					case 124:
					case 126:
					case 127:
					case 136:
					case 141:
						if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							global2.data[23] += 2;
						}
						else
						{
							global2.data[25]++;
							global2.data[23] += 4;
						}
						break;
					default:
						if (num4 != 141 && num4 != 79 && num4 != 81 && num4 != 77 && num4 != 78 && num4 != 43 && num4 != 97 && num4 != 72 && num4 != 12 && num4 != 69 && num4 != 70 && num4 != 149 && num4 != 150)
						{
							if (global2.allcountries[num4].stab < 300)
							{
								global2.data[25]++;
								global2.data[23] -= 2;
								Country country = global2.allcountries[num4];
								country.stab += 50;
							}
							else if (global2.allcountries[num4].stab < 600)
							{
								global2.data[25]++;
								global2.data[23]--;
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else if (global2.allcountries[num4].stab < 800)
							{
								global2.data[25]++;
								global2.data[23]++;
								Country country = global2.allcountries[num4];
								country.stab += 80;
							}
							else
							{
								global2.data[25]++;
								global2.data[23] += 3;
							}
							break;
						}
						goto case 22;
					case 22:
					case 23:
					case 128:
						if (global2.allcountries[num4].stab < 300)
						{
							global2.data[25]++;
							global2.data[23] -= 2;
							Country country = global2.allcountries[num4];
							country.stab += 50;
						}
						else if (global2.allcountries[num4].stab < 600)
						{
							global2.data[25]++;
							global2.data[23]--;
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else if (global2.allcountries[num4].stab < 800)
						{
							global2.data[25]++;
							global2.data[23]++;
							Country country = global2.allcountries[num4];
							country.stab += 80;
						}
						else
						{
							global2.data[25]++;
							global2.data[23] += 3;
						}
						break;
					}
				}
			}
			if (global2.data[15] > 7 && global2.data[125] == 4)
			{
				global2.data[125] = 0;
			}
			if (global2.data[37] >= 1000 && !global2.allcountries[47].proprc && !global2.event_done[441])
			{
				global2.allcountries[47].proprc = true;
				global2.allcountries[47].Gosstroy = 1;
				global2.allcountries[47].isASEAN = false;
				global2.allcountries[47].SubGosstroy = 17;
				global2.allcountries[47].Vyshi = false;
				GlobalScript.inst.gameState.number_event = 441;
				SceneManager.LoadScene("Event");
			}
			AfricanBotSupport();
			if (global2.empires[0].relations <= 500 && global2.allcountries[51].Torg)
			{
				global2.allcountries[51].Torg = false;
			}
			if (global2.empires[1].relations <= 500 && global2.relres)
			{
				global2.relres = false;
			}
			int[] array2 = new int[5];
			int[] array3 = new int[5];
			if (global2.faction_leader[0] == 200 || global2.faction_leader[1] == 200 || global2.faction_leader[2] == 200 || global2.faction_leader[3] == 200 || global2.faction_leader[4] == 200)
			{
				array2[0] = 0;
				array2[1] = 0;
				array2[2] = 0;
				array2[3] = 0;
				array2[4] = 0;
				array3[0] = 200;
				array3[1] = 200;
				array3[2] = 200;
				array3[3] = 200;
				array3[4] = 200;
			}
			for (int num5 = 0; num5 < global2.politics.Length; num5++)
			{
				if (global2.faction_leader[0] == 200 && global2.politics[num5].traits[0] == 0 && global2.politics[num5].power > array2[0])
				{
					array2[0] = global2.politics[num5].power;
					array3[0] = num5;
				}
				if (global2.faction_leader[1] == 200 && global2.politics[num5].traits[0] == 20 && global2.politics[num5].power > array2[1])
				{
					array2[1] = global2.politics[num5].power;
					array3[1] = num5;
				}
				if (global2.faction_leader[2] == 200 && global2.politics[num5].traits[0] == 1 && global2.politics[num5].power > array2[2])
				{
					array2[2] = global2.politics[num5].power;
					array3[2] = num5;
				}
				if (global2.faction_leader[3] == 200 && global2.politics[num5].traits[0] == 2 && global2.politics[num5].power > array2[3])
				{
					array2[3] = global2.politics[num5].power;
					array3[3] = num5;
				}
				if (global2.faction_leader[4] == 200 && global2.politics[num5].traits[0] == 3 && global2.politics[num5].power > array2[4])
				{
					array2[4] = global2.politics[num5].power;
					array3[4] = num5;
				}
			}
			if (global2.faction_leader[0] == 200)
			{
				global2.faction_leader[0] = array3[0];
			}
			if (global2.faction_leader[1] == 200)
			{
				global2.faction_leader[1] = array3[1];
			}
			if (global2.faction_leader[2] == 200)
			{
				global2.faction_leader[2] = array3[2];
			}
			if (global2.faction_leader[3] == 200)
			{
				global2.faction_leader[3] = array3[3];
			}
			if (global2.faction_leader[4] == 200)
			{
				global2.faction_leader[4] = array3[4];
			}
			int[] array4 = new int[global2.party_ideology.Length];
			global2.data[53] = 0;
			for (int num6 = 0; num6 < global2.party_number.Length; num6++)
			{
				if (!global2.is_party_enabled[num6])
				{
					global2.data[53]++;
				}
			}
			if (global2.data[15] > 7 && global2.data[53] >= 4)
			{
				global2.data[15] = 6;
			}
			if (global2.data[15] <= 7)
			{
				for (int num7 = 0; num7 < global2.party_number.Length; num7++)
				{
					if (global2.party_ideology[num7] > 0 && !global2.is_party_enabled[num7])
					{
						if (num7 + 1 < global2.is_party_enabled.Length)
						{
							for (int num8 = num7 + 1; num8 < global2.is_party_enabled.Length; num8++)
							{
								if (global2.is_party_enabled[num8])
								{
									array4[num8] = global2.party_ideology[num7];
									break;
								}
							}
							continue;
						}
						for (int num9 = num7 - 1; num9 > 0; num9--)
						{
							if (global2.is_party_enabled[num9])
							{
								global2.party_number[num9] += global2.party_ideology[num7];
								break;
							}
						}
					}
					else if (global2.party_ideology[num7] > 0 && global2.is_party_enabled[num7])
					{
						global2.party_number[num7] = global2.party_ideology[num7] + array4[num7];
					}
					else if (global2.party_ideology[num7] < 0)
					{
						global2.party_ideology[num7] = 0;
					}
				}
			}
			if (global2.data[15] <= 7)
			{
				if (global2.party_number[0] >= global2.party_number[1] && global2.party_number[0] >= global2.party_number[2] && global2.party_number[0] >= global2.party_number[3] && global2.party_number[0] >= global2.party_number[4])
				{
					global2.data[56] = 0;
				}
				else if (global2.party_number[0] <= global2.party_number[1] && global2.party_number[1] >= global2.party_number[2] && global2.party_number[1] >= global2.party_number[3] && global2.party_number[1] >= global2.party_number[4])
				{
					global2.data[56] = 1;
				}
				else if (global2.party_number[2] >= global2.party_number[1] && global2.party_number[0] <= global2.party_number[2] && global2.party_number[2] >= global2.party_number[3] && global2.party_number[2] >= global2.party_number[4])
				{
					global2.data[56] = 2;
				}
				else if (global2.party_number[3] >= global2.party_number[1] && global2.party_number[3] >= global2.party_number[2] && global2.party_number[0] <= global2.party_number[3] && global2.party_number[3] >= global2.party_number[4])
				{
					global2.data[56] = 3;
				}
				else if (global2.party_number[4] >= global2.party_number[1] && global2.party_number[4] >= global2.party_number[2] && global2.party_number[4] >= global2.party_number[3] && global2.party_number[0] <= global2.party_number[4])
				{
					global2.data[56] = 4;
				}
			}
			else
			{
				int num10 = global2.party_number[1];
				for (int num11 = 0; num11 < global2.is_party_ally.Length; num11++)
				{
					if (global2.is_party_ally[num11] && global2.is_party_enabled[num11] && num11 != 1)
					{
						num10 += global2.party_number[num11];
					}
				}
				if (num10 >= global2.party_number[0] && num10 >= global2.party_number[2] && num10 >= global2.party_number[3] && num10 >= global2.party_number[4])
				{
					global2.data[56] = 1;
				}
				else if (!global2.is_party_ally[0] && global2.is_party_enabled[0] && num10 <= global2.party_number[0] && global2.party_number[0] >= global2.party_number[2] && global2.party_number[0] >= global2.party_number[3] && global2.party_number[0] >= global2.party_number[4])
				{
					global2.data[56] = 0;
				}
				else if (!global2.is_party_ally[2] && global2.is_party_enabled[2] && global2.party_number[2] >= global2.party_number[0] && num10 <= global2.party_number[2] && global2.party_number[2] >= global2.party_number[3] && global2.party_number[2] >= global2.party_number[4])
				{
					global2.data[56] = 2;
				}
				else if (!global2.is_party_ally[3] && global2.is_party_enabled[3] && global2.party_number[3] >= global2.party_number[0] && global2.party_number[3] >= global2.party_number[2] && num10 <= global2.party_number[3] && global2.party_number[3] >= global2.party_number[4])
				{
					global2.data[56] = 3;
				}
				else if (!global2.is_party_ally[4] && global2.is_party_enabled[4] && global2.party_number[4] >= global2.party_number[0] && global2.party_number[4] >= global2.party_number[2] && global2.party_number[4] >= global2.party_number[3] && num10 <= global2.party_number[4])
				{
					global2.data[56] = 4;
				}
				int num12 = global2.party_number[0] + global2.party_number[1] + global2.party_number[2] + global2.party_number[3] + global2.party_number[4];
				int num13 = num10 * 100 / num12;
				if (num13 > 66)
				{
					global2.is_konst_max = true;
				}
				else
				{
					global2.is_konst_max = false;
				}
			}
			if (global2.data[33] <= 250)
			{
				global2.data[52] = 34;
			}
			else if (global2.data[33] <= 500)
			{
				global2.data[52] = 35;
			}
			else if (global2.data[33] <= 750)
			{
				global2.data[52] = 36;
			}
			else
			{
				global2.data[52] = 37;
			}
			if (global2.data[55] <= 250)
			{
				global2.data[54] = 38;
			}
			else if (global2.data[55] <= 500)
			{
				global2.data[54] = 39;
			}
			else if (global2.data[55] <= 750)
			{
				global2.data[54] = 40;
			}
			else
			{
				global2.data[54] = 41;
			}
			int num14 = 5;
			if (GlobalScript.inst.gameState.data[16] == 10)
			{
				num14--;
			}
			if (GlobalScript.inst.gameState.data[16] == 15 || GlobalScript.inst.gameState.data[16] == 14)
			{
				if (GlobalScript.inst.gameState.data[17] > 17)
				{
					num14++;
				}
				else
				{
					num14--;
				}
			}
			if (GlobalScript.inst.gameState.data[15] == 6)
			{
				num14--;
			}
			if (GlobalScript.inst.gameState.data[15] == 8)
			{
				num14++;
			}
			if (GlobalScript.inst.gameState.data[15] == 9)
			{
				num14 += 2;
			}
			if (GlobalScript.inst.gameState.data[17] == 16)
			{
				num14--;
			}
			if (GlobalScript.inst.gameState.data[17] == 18)
			{
				num14++;
			}
			if (GlobalScript.inst.gameState.data[17] == 19)
			{
				num14 += 3;
			}
			if (GlobalScript.inst.gameState.data[50] == 24 || GlobalScript.inst.gameState.data[50] == 29)
			{
				num14 -= 2;
			}
			if (GlobalScript.inst.gameState.data[50] == 25 || GlobalScript.inst.gameState.data[50] == 28)
			{
				num14--;
			}
			if (GlobalScript.inst.gameState.data[50] == 27)
			{
				num14++;
			}
			if (GlobalScript.inst.gameState.data[18] == 20 && GlobalScript.inst.gameState.data[51] == 30)
			{
				num14--;
			}
			if (GlobalScript.inst.gameState.data[18] >= 22 && GlobalScript.inst.gameState.data[51] == 33)
			{
				num14++;
			}
			if (GlobalScript.inst.gameState.data[18] == 23)
			{
				num14++;
			}
			if (GlobalScript.inst.gameState.modifies[40].active || GlobalScript.inst.gameState.modifies[38].active)
			{
				num14--;
			}
			if (GlobalScript.inst.gameState.event_done[502] && GlobalScript.inst.gameState.resultOfEvents[502] != 3)
			{
				num14 -= 2;
			}
			if (num14 <= 0)
			{
				GlobalScript.inst.gameState.data[14] = 0;
				global2.allcountries[1].Gosstroy = 0;
			}
			else if (num14 <= 3 && GlobalScript.inst.gameState.data[16] <= 11)
			{
				GlobalScript.inst.gameState.data[14] = 1;
				global2.allcountries[1].Gosstroy = 1;
			}
			else if (num14 <= 6)
			{
				if (GlobalScript.inst.gameState.data[16] <= 13)
				{
					GlobalScript.inst.gameState.data[14] = 2;
					global2.allcountries[1].Gosstroy = 1;
				}
				else
				{
					GlobalScript.inst.gameState.data[14] = 3;
					global2.allcountries[1].Gosstroy = 2;
				}
			}
			else if (num14 <= 9)
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
					global2.allcountries[1].Gosstroy = 2;
				}
				else
				{
					GlobalScript.inst.gameState.data[14] = 4;
					global2.allcountries[1].Gosstroy = 3;
				}
			}
			else if (num14 <= 12)
			{
				if (GlobalScript.inst.gameState.data[16] <= 13)
				{
					if (GlobalScript.inst.gameState.data[16] <= 11)
					{
						GlobalScript.inst.gameState.data[14] = 3;
						global2.allcountries[1].Gosstroy = 2;
					}
					else
					{
						GlobalScript.inst.gameState.data[14] = 4;
						global2.allcountries[1].Gosstroy = 3;
					}
				}
				else
				{
					GlobalScript.inst.gameState.data[14] = 5;
					global2.allcountries[1].Gosstroy = 3;
				}
			}
			else if (GlobalScript.inst.gameState.data[16] > 12)
			{
				GlobalScript.inst.gameState.data[14] = 5;
				global2.allcountries[1].Gosstroy = 3;
			}
			else if (GlobalScript.inst.gameState.data[16] > 11)
			{
				GlobalScript.inst.gameState.data[14] = 4;
				global2.allcountries[1].Gosstroy = 3;
			}
			else
			{
				GlobalScript.inst.gameState.data[14] = 3;
				global2.allcountries[1].Gosstroy = 2;
			}
			global2.allcountries[1].SubGosstroy = global2.ChineseSubGosstroy();
			PlotPlayerCause();
			if (global2.data[1] <= 300 + global2.data[4] / 5 - (global2.data[3] - 500) / 5)
			{
				Reelect(4);
			}
			global2.data[11] += global2.data[73] / 40;
			if (global2.data[16] <= 12 && global2.event_done[92])
			{
				if (global2.data[102] == 1)
				{
					global2.data[11]--;
				}
				else if (global2.data[102] == 2)
				{
					global2.data[11]--;
				}
				else if (global2.data[102] == 3)
				{
					global2.data[11]--;
				}
				else if (global2.data[102] == 4)
				{
					global2.data[11]++;
				}
			}
			if (global2.data[19] == 1 && global2.data[20] % 3 == 0)
			{
				global2.allcountries[8].stab = 0;
				global2.allcountries[24].stab = 0;
				global2.allcountries[7].dev = 0;
				global2.allcountries[118].cw = false;
				global2.allcountries[112].cw = false;
				if (global2.allcountries[66].level_of_unstab > 0)
				{
					Country country = global2.allcountries[66];
					country.level_of_unstab -= 100;
				}
			}
			if (global2.data[19] == 1 && global2.data[20] % 6 == 0)
			{
				global2.allcountries[14].stab = 0;
				global2.allcountries[126].cw = false;
				global2.allcountries[149].cw = false;
				global2.allcountries[147].cw = false;
				global2.allcountries[60].based = false;
				global2.event_done[671] = false;
			}
			if (global2.data[19] == 1 && (global2.data[20] == global2.data[119] || global2.data[20] == global2.data[121]))
			{
				global2.bad_done = false;
			}
			if (global2.data[19] == 1)
			{
				if (global2.event_done[659] && !global2.event_done[661] && !global2.ingamewars[81].is_going)
				{
					Country country = global2.allcountries[118];
					country.inflCh += 15;
					country = global2.allcountries[118];
					country.prcinfl += 2;
					country = global2.allcountries[118];
					country.sovinfl--;
					if (global2.allcountries[118].inflNATO >= 1000)
					{
						global2.ingamewars[81].infl2 = 1000;
						global2.data[82] = 81;
						Reelect(661);
					}
					if (global2.allcountries[118].prcinfl > 700)
					{
						global2.allcountries[118].parts[0] = true;
						global2.ingamewars[81] = new War().Name("乌 干 达 内 战").Attacker("阿 明 残 军").Defender("政 府 军")
							.AttackerInfluence(600)
							.DefenderInfluence(400)
							.CreateWar;
					}
					if (global2.allcountries[118].sovinfl > 700)
					{
						global2.allcountries[118].parts[0] = true;
						global2.ingamewars[81] = new War().Name("乌 干 达 内 战").Attacker("布 干 达 武 装").Defender("政 府 军")
							.AttackerInfluence(600)
							.DefenderInfluence(400)
							.CreateWar;
					}
				}
				global2.bad_debuff = false;
				int num15 = global2.data[34];
				GlobalScript.inst.gameState.allcountries[1].level_of_unstab = 10;
				for (int num16 = 0; num16 < global2.desnull.Length; num16++)
				{
					if (global2.desnull[num16] > 0)
					{
						global2.desnull[num16]--;
					}
					if ((num16 == 24 || num16 == 25 || num16 == 26 || num16 == 27 || num16 == 28 || num16 == 29 || num16 == 30 || num16 == 31 || num16 == 32 || num16 == 34) && global2.desnull[num16] <= 0 && global2.completedDecisions[num16])
					{
						global2.completedDecisions[num16] = false;
					}
				}
				if (global2.allcountries[1].isOVD && global2.allcountries[1].isSEATO)
				{
					global2.data[141] = 0;
					global2.data[142] = 0;
				}
				if (global2.data[144] > 0)
				{
					global2.data[144]--;
				}
				if (global2.data[145] > 0)
				{
					global2.data[145]--;
				}
				if (global2.data[142] > 0)
				{
					global2.data[142]--;
				}
				if (global2.data[150] > 0)
				{
					global2.data[150]--;
				}
				if (global2.data[151] > 0)
				{
					global2.data[151]--;
				}
				if (global2.empires[1].money >= 200 && global2.data[150] <= 0 && global2.empires[1].power - 200 >= global2.empires[0].power && global2.empires[1].power - 200 >= global2.influencePRC && global2.data[143] < 50)
				{
					global2.data[143]++;
					Empire empire = global2.empires[1];
					empire.money -= 200;
					global2.data[150] = 6;
				}
				if (global2.empires[0].money >= 200 && global2.data[151] <= 0 && global2.empires[0].power - 200 >= global2.empires[1].power && global2.empires[0].power - 200 >= global2.influencePRC && global2.data[143] > 10)
				{
					global2.data[143]--;
					Empire empire = global2.empires[0];
					empire.money -= 200;
					global2.data[151] = 6;
				}
				if (global2.allcountries[36].sovinfl > 0)
				{
					Country country = global2.allcountries[36];
					country.sovinfl--;
				}
				if (global2.allcountries[36].usainfl > 0)
				{
					Country country = global2.allcountries[36];
					country.usainfl--;
				}
				if (global2.allcountries[36].prcinfl > 0)
				{
					Country country = global2.allcountries[36];
					country.prcinfl--;
				}
				if (global2.allcountries[123].sovinfl > 0)
				{
					Country country = global2.allcountries[123];
					country.sovinfl--;
				}
				if (global2.allcountries[123].usainfl > 0)
				{
					Country country = global2.allcountries[123];
					country.usainfl--;
				}
				if (global2.allcountries[123].prcinfl > 0)
				{
					Country country = global2.allcountries[123];
					country.prcinfl--;
				}
				for (int num17 = 101; num17 < 106; num17++)
				{
					if (num17 != 104 && global2.allcountries[num17].inflCh >= 1000 && !global2.allcountries[num17].proprc && !global2.event_done[568])
					{
						global2.allcountries[num17].proprc = true;
					}
				}
				if (global2.allcountries[36].inflCh >= 1000 && !global2.allcountries[36].proprc && !global2.event_done[568])
				{
					global2.allcountries[36].proprc = true;
				}
				for (int num18 = 101; num18 < 106; num18++)
				{
					if (global2.allcountries[num18].sovinfl > 0)
					{
						Country country = global2.allcountries[num18];
						country.sovinfl--;
					}
					if (global2.allcountries[num18].usainfl > 0)
					{
						Country country = global2.allcountries[num18];
						country.usainfl--;
					}
					if (global2.allcountries[num18].prcinfl > 0)
					{
						Country country = global2.allcountries[num18];
						country.prcinfl--;
					}
				}
				if (global2.allcountries[36].inflNATO > 0)
				{
					Country country = global2.allcountries[36];
					country.inflNATO--;
				}
				if (global2.event_done[418])
				{
					int num19 = 0;
					int num20 = 0;
					int num21 = 0;
					Country country;
					if (global2.empires[0].money >= 250)
					{
						if (global2.allcountries[14].Vyshi)
						{
							num19 += 5;
						}
						if (global2.allcountries[8].Vyshi)
						{
							num19 += 5;
						}
						if (global2.allcountries[30].Vyshi)
						{
							num19 += 5;
						}
						if (global2.allcountries[37].Vyshi)
						{
							num19 += 5;
						}
						if (global2.allcountries[35].Vyshi)
						{
							num19 += 5;
						}
						if (global2.allcountries[40].Vyshi)
						{
							num19 += 5;
						}
						if (global2.allcountries[36].proprc)
						{
							if (global2.empires[0].money >= 300)
							{
								num19 += global2.empires[0].power / 25;
								country = global2.allcountries[36];
								country.inflCh -= num19;
								Empire empire = global2.empires[0];
								empire.money -= 300;
							}
						}
						else if (!global2.allcountries[36].proprc && global2.allcountries[36].inflCh > 200)
						{
							num19 += global2.empires[0].power / 15;
							country = global2.allcountries[36];
							country.inflCh -= num19;
							Empire empire = global2.empires[0];
							empire.money -= 250;
						}
						for (int num22 = 101; num22 < 106; num22++)
						{
							if (global2.allcountries[num22].proprc)
							{
								if (global2.empires[0].money >= 300)
								{
									num19 += global2.empires[0].power / 25;
									country = global2.allcountries[num22];
									country.inflCh -= num19;
									Empire empire = global2.empires[0];
									empire.money -= 300;
								}
							}
							else if (!global2.allcountries[num22].proprc && global2.allcountries[num22].inflCh > 200)
							{
								num19 += global2.empires[0].power / 15;
								country = global2.allcountries[num22];
								country.inflCh -= num19;
								Empire empire = global2.empires[0];
								empire.money -= 250;
							}
						}
					}
					if (global2.empires[1].money >= 250)
					{
						if (global2.allcountries[14].prosov)
						{
							num20 += 5;
						}
						if (global2.allcountries[8].prosov)
						{
							num20 += 5;
						}
						if (global2.allcountries[30].prosov)
						{
							num20 += 5;
						}
						if (global2.allcountries[37].prosov)
						{
							num20 += 5;
						}
						if (global2.allcountries[35].prosov)
						{
							num20 += 5;
						}
						if (global2.allcountries[40].prosov)
						{
							num20 += 5;
						}
						if (global2.allcountries[36].proprc)
						{
							if (global2.empires[1].money >= 300)
							{
								num20 += global2.empires[1].power / 25;
								country = global2.allcountries[36];
								country.inflCh -= num20;
								Empire empire = global2.empires[1];
								empire.money -= 300;
							}
						}
						else if (!global2.allcountries[36].proprc && global2.allcountries[36].inflCh > 200)
						{
							num20 += global2.empires[1].power / 15;
							country = global2.allcountries[36];
							country.inflCh -= num20;
							Empire empire = global2.empires[1];
							empire.money -= 250;
						}
						for (int num23 = 101; num23 < 106; num23++)
						{
							if (global2.allcountries[num23].proprc)
							{
								if (global2.empires[1].money >= 300)
								{
									num20 += global2.empires[1].power / 25;
									country = global2.allcountries[num23];
									country.inflCh -= num20;
									Empire empire = global2.empires[1];
									empire.money -= 300;
								}
							}
							else if (!global2.allcountries[num23].proprc && global2.allcountries[num23].inflCh > 200)
							{
								num20 += global2.empires[1].power / 15;
								country = global2.allcountries[num23];
								country.inflCh -= num20;
								Empire empire = global2.empires[1];
								empire.money -= 250;
							}
						}
					}
					if (global2.allcountries[14].proprc)
					{
						num21 += 15;
					}
					if (global2.allcountries[8].proprc)
					{
						num21 += 15;
					}
					if (global2.allcountries[30].proprc)
					{
						num21 += 15;
					}
					if (global2.allcountries[37].proprc)
					{
						num21 += 15;
					}
					if (global2.allcountries[35].proprc)
					{
						num21 += 15;
					}
					if (global2.allcountries[40].proprc)
					{
						num21 += 15;
					}
					if (global2.allcountries[14].econ)
					{
						num21 += 5;
					}
					if (global2.allcountries[8].econ)
					{
						num21 += 5;
					}
					if (global2.allcountries[30].econ)
					{
						num21 += 5;
					}
					if (global2.allcountries[37].econ)
					{
						num21 += 5;
					}
					if (global2.allcountries[35].econ)
					{
						num21 += 5;
					}
					if (global2.allcountries[40].econ)
					{
						num21 += 5;
					}
					for (int num24 = 101; num24 < 106; num24++)
					{
						country = global2.allcountries[num24];
						country.inflCh += num21;
					}
					country = global2.allcountries[36];
					country.inflCh += num21;
					for (int num25 = 101; num25 < 106; num25++)
					{
						if (global2.allcountries[num25].inflCh > 1000)
						{
							global2.allcountries[num25].inflCh = 1000;
						}
						else if (global2.allcountries[num25].inflCh < 0)
						{
							global2.allcountries[num25].inflCh = 0;
						}
					}
					if (global2.allcountries[36].inflCh > 1000)
					{
						global2.allcountries[36].inflCh = 1000;
					}
					else if (global2.allcountries[36].inflCh < 0)
					{
						global2.allcountries[36].inflCh = 0;
					}
					for (int num26 = 101; num26 < 106; num26++)
					{
						if (global2.allcountries[num26].proprc && global2.allcountries[num26].inflCh < 250)
						{
							global2.allcountries[num26].proprc = false;
						}
					}
					if (global2.allcountries[36].proprc && global2.allcountries[36].inflCh < 250)
					{
						global2.allcountries[36].proprc = false;
					}
				}
				if (global2.data[146] > 0)
				{
					global2.data[8] -= global2.data[146];
					global2.data[9] -= global2.data[146];
					global2.data[22] -= global2.data[146];
					for (int num27 = 0; num27 < global2.allcountries.Length; num27++)
					{
						if (global2.allcountries[num27].dota)
						{
							Country country;
							if (global2.allcountries[1].isOVD)
							{
								country = global2.allcountries[num27];
								country.sovinfl -= 10;
							}
							else
							{
								country = global2.allcountries[num27];
								country.usainfl -= 10;
							}
							country = global2.allcountries[num27];
							country.prcinfl += 5;
						}
					}
				}
				if (global2.allcountries[92].spec > 1)
				{
					global2.allcountries[92].spec = 1;
				}
				if (global2.data[21] == 1981 && global2.data[20] == 1 && global2.allcountries[45].Gosstroy == 3)
				{
					global2.allcountries[45].isEU = true;
					Empire empire = global2.empires[0];
					empire.power += 10;
				}
				if (global2.allcountries[51].spec > 0)
				{
					Country country = global2.allcountries[51];
					country.spec--;
				}
				if (global2.allcountries[7].spec > 0)
				{
					Country country = global2.allcountries[7];
					country.spec--;
				}
				if (!global2.allcountries[1].parts[0] && !global2.allcountries[1].parts[1] && !global2.allcountries[1].parts[2] && !global2.allcountries[1].parts[3] && !global2.allcountries[1].parts[4] && !global2.allcountries[1].parts[5] && !global2.allcountries[1].parts[6] && !global2.allcountries[1].parts[7] && !global2.allcountries[1].parts[8] && !global2.allcountries[1].parts[9] && !global2.allcountries[1].parts[10])
				{
					global2.allcountries[1].ILoveSuckCocks();
				}
				if (global2.data[21] == 1979 && global2.data[20] == 5 && !GlobalScript.inst.dlc[3])
				{
					Empire empire = global2.empires[0];
					empire.power += 10;
					global2.allcountries[92].SubGosstroy = 12;
				}
				if (global2.data[6] >= 850 || global2.data[131] == 1 || global2.data[131] == 2 || !global2.allcountries[30].Vyshi || global2.allcountries[8].Gosstroy == 1 || global2.allcountries[8].SubGosstroy == 9 || global2.allcountries[1].isSEV)
				{
					global2.modifies[41].active = false;
				}
				if ((global2.allcountries[1].Gosstroy != 1 || global2.allcountries[1].isASEAN || !global2.relres) && global2.allcountries[16].prosov)
				{
					global2.modifies[53].active = false;
					global2.allcountries[16].Torg = false;
				}
				if (global2.allcountries[16].proprc && (global2.allcountries[1].Gosstroy != 1 || global2.allcountries[1].isASEAN))
				{
					global2.modifies[53].active = false;
					global2.allcountries[16].Torg = false;
				}
				if ((global2.allcountries[1].Gosstroy != 1 || global2.allcountries[1].isASEAN) && global2.allcountries[17].parts[0] && global2.allcountries[17].Gosstroy == 1)
				{
					global2.modifies[53].active = false;
					global2.allcountries[17].Torg = false;
				}
				if (!global2.allcountries[1].isSEV)
				{
					for (int num28 = 2; num28 < 7; num28++)
					{
						if (global2.allcountries[num28].prosov)
						{
							global2.allcountries[num28].Torg = false;
						}
					}
				}
				if (global2.allcountries[92].Gosstroy == 1 || global2.allcountries[92].SubGosstroy == 3)
				{
					global2.allcountries[31].isSENTO = false;
					global2.allcountries[8].isSENTO = false;
				}
				if (global2.data[139] > 0)
				{
					global2.data[139]--;
				}
				if (((!global2.modifies[16].active && global2.allcountries[1].isSEV && global2.data[140] <= 0) || (!global2.modifies[17].active && global2.allcountries[1].isASEAN && global2.data[140] <= 0) || (global2.data[140] == 1 && global2.allcountries[1].isSEV && global2.allcountries[1].Gosstroy != 3 && global2.data[52] != 37) || (global2.data[140] == 2 && global2.allcountries[1].isASEAN && global2.allcountries[1].Gosstroy != 1 && global2.data[52] != 34)) && global2.data[139] > 0)
				{
					global2.data[139] = 0;
				}
				if (global2.data[139] <= 0 && ((global2.allcountries[1].isSEV && global2.modifies[16].active && global2.data[140] <= 0) || (global2.allcountries[1].isASEAN && global2.modifies[17].active && global2.data[140] <= 0) || global2.data[140] > 0))
				{
					Debug.Log("Вас выгнали!");
					if (global2.allcountries[1].isASEAN)
					{
						Empire empire = global2.empires[0];
						empire.relations -= 300;
					}
					else
					{
						Empire empire = global2.empires[1];
						empire.relations -= 300;
						global2.allcountries[7].Torg = false;
					}
					global2.data[140] = 0;
					if (global2.data[135] > 0)
					{
						global2.modifies[47].active = true;
						global2.data[135] = 0;
					}
					if (global2.data[136] > 0)
					{
						global2.modifies[48].active = true;
						global2.data[136] = 0;
					}
					global2.data[139] = 0;
					global2.allcountries[7].spec = 0;
					global2.allcountries[51].spec = 0;
					for (int num29 = 2; num29 < global2.allcountries.Length; num29++)
					{
						if (global2.allcountries[num29].proprc)
						{
							if (global2.allcountries[1].isASEAN)
							{
								global2.allcountries[num29].LeaveASEAN().LeaveSEATO();
								Empire empire = global2.empires[0];
								empire.power -= 5;
							}
							else
							{
								global2.allcountries[num29].LeaveWP().LeaveComecon();
								Empire empire = global2.empires[1];
								empire.power -= 5;
							}
						}
					}
					if (global2.data[137] > 0)
					{
						for (int num30 = 0; num30 < global2.allcountries.Length; num30++)
						{
							global2.data[137] = 0;
							if (global2.allcountries[num30].proprc)
							{
								global2.allcountries[num30].JoinECON();
							}
						}
					}
					if (global2.data[138] > 0)
					{
						for (int num31 = 0; num31 < global2.allcountries.Length; num31++)
						{
							global2.data[138] = 0;
							if (global2.allcountries[num31].proprc)
							{
								global2.allcountries[num31].JoinOKB();
							}
						}
					}
					global2.allcountries[1].LeaveWP().LeaveASEAN().LeaveComecon()
						.LeaveSEATO();
				}
				if (global2.data[21] == 1983 && global2.data[20] == 6 && !GlobalScript.inst.dlc[3])
				{
					Empire empire = global2.empires[0];
					empire.power += 10;
					global2.allcountries[21].SubGosstroy = 12;
				}
				if (global2.allcountries[7].isNATO)
				{
					for (int num32 = 0; num32 < global2.ingamewars.Length; num32++)
					{
						if (global2.ingamewars[num32].is_going && num32 != 5)
						{
							if (global2.ingamewars[num32].diplo_done[0])
							{
								global2.ingamewars[num32].usa_place = 1;
								global2.ingamewars[num32].ussr_place = 1;
							}
							else if (global2.ingamewars[num32].diplo_done[1])
							{
								global2.ingamewars[num32].usa_place = 0;
								global2.ingamewars[num32].ussr_place = 0;
							}
						}
					}
				}
				if (global2.data[21] > 1976 && !GlobalScript.inst.dlc[3])
				{
					global2.allcountries[87].SubGosstroy = 6;
					global2.allcountries[87].Gosstroy = 3;
					global2.allcountries[86].SubGosstroy = 5;
					global2.allcountries[86].Gosstroy = 3;
				}
				if (GlobalScript.inst.dlc[3] && global2.allcountries[84].SubGosstroy == 7 && global2.data[21] == 1984)
				{
					global2.allcountries[84].SubGosstroy = 6;
					global2.allcountries[84].Gosstroy = 3;
				}
				if (global2.OAR && global2.allcountries[30].Gosstroy != 1)
				{
					if ((global2.allcountries[14].okb || global2.allcountries[14].isOVD || global2.allcountries[14].isNATO) && global2.allcountries[14].oar)
					{
						global2.allcountries[14].oar = true;
						global2.allcountries[14].okb = false;
						global2.allcountries[14].isOVD = false;
						global2.allcountries[14].isNATO = false;
					}
					if ((global2.allcountries[35].okb || global2.allcountries[35].isOVD || global2.allcountries[35].isNATO) && global2.allcountries[35].oar)
					{
						global2.allcountries[35].oar = true;
						global2.allcountries[35].okb = false;
						global2.allcountries[35].isOVD = false;
						global2.allcountries[35].isNATO = false;
					}
					if ((global2.allcountries[40].okb || global2.allcountries[40].isOVD || global2.allcountries[40].isNATO) && global2.allcountries[40].oar)
					{
						global2.allcountries[40].oar = true;
						global2.allcountries[40].okb = false;
						global2.allcountries[40].isOVD = false;
						global2.allcountries[40].isNATO = false;
					}
					if ((global2.allcountries[30].okb || global2.allcountries[30].isOVD || global2.allcountries[30].isNATO) && global2.allcountries[30].oar)
					{
						global2.allcountries[30].oar = true;
						global2.allcountries[30].okb = false;
						global2.allcountries[30].isOVD = false;
						global2.allcountries[30].isNATO = false;
					}
					if ((global2.allcountries[13].okb || global2.allcountries[13].isOVD || global2.allcountries[13].isNATO) && global2.allcountries[13].oar)
					{
						global2.allcountries[13].oar = true;
						global2.allcountries[13].okb = false;
						global2.allcountries[13].isOVD = false;
						global2.allcountries[13].isNATO = false;
					}
				}
				if (global2.data[21] == 1982 && global2.data[20] == 5 && global2.allcountries[86].SubGosstroy == 5 && !GlobalScript.inst.dlc[3])
				{
					global2.allcountries[86].isNATO = true;
				}
				if (global2.allcountries[84].SubGosstroy == 9 && !global2.allcountries[84].Vyshi && !global2.allcountries[84].isNATO && !global2.allcountries[84].proprc && !global2.allcountries[14].proprc && !global2.allcountries[8].proprc && !global2.allcountries[35].proprc && !global2.allcountries[94].proprc && global2.allcountries[35].SubGosstroy == 9 && global2.allcountries[14].SubGosstroy == 9 && global2.allcountries[8].SubGosstroy == 9 && global2.allcountries[94].SubGosstroy == 9)
				{
					global2.allcountries[84].name = GlobalScript.inst.new_events_text[784];
				}
				DaysInSouthAmerica();
				if (global2.data[16] > 13)
				{
					if (global2.data[16] == 14 && global2.data[21] < 1980)
					{
						global2.data[108] += 5;
					}
					else if (global2.data[16] == 14)
					{
						global2.data[108]++;
					}
					else if (global2.data[16] == 15 && global2.data[21] < 1980)
					{
						global2.data[108] += 10;
					}
					else if (global2.data[16] == 15)
					{
						global2.data[108] += 4;
					}
					if (global2.data[15] <= 7)
					{
						global2.data[108] += 2;
					}
					else if (global2.data[15] == 8)
					{
						global2.data[108]++;
					}
					else if (global2.data[15] == 9)
					{
						global2.data[108]--;
					}
					if (global2.data[17] <= 16)
					{
						global2.data[108] += 2;
					}
					else if (global2.data[17] == 17)
					{
						global2.data[108]++;
					}
					else if (global2.data[17] == 19)
					{
						global2.data[108]--;
					}
					if (global2.data[18] == 21)
					{
						global2.data[108]++;
					}
					else if (global2.data[18] == 22)
					{
						global2.data[108] += 2;
					}
					else if (global2.data[18] == 23)
					{
						global2.data[108] += 3;
					}
					if (global2.data[50] == 24)
					{
						global2.data[108]++;
					}
					else if (global2.data[50] == 25)
					{
						global2.data[108]--;
					}
					else if (global2.data[50] == 28)
					{
						global2.data[108]++;
					}
					else if (global2.data[50] == 29)
					{
						global2.data[108] += 3;
					}
					if (global2.data[51] == 30)
					{
						global2.data[108] += 2;
					}
					else if (global2.data[51] == 31)
					{
						global2.data[108]++;
					}
					if (global2.modifies[7].active)
					{
						global2.data[108]--;
					}
					if (global2.modifies[13].active)
					{
						global2.data[108] -= 2;
					}
					if (global2.modifies[5].active)
					{
						global2.data[108] += 3;
					}
				}
				else if (global2.data[16] == 13)
				{
					if (global2.data[16] == 13 && global2.data[21] < 1980)
					{
						global2.data[108]++;
					}
					if (global2.data[15] == 9)
					{
						global2.data[108]--;
					}
					if (global2.data[17] == 19)
					{
						global2.data[108]--;
					}
					if (global2.data[18] == 21)
					{
						global2.data[108]++;
					}
					else if (global2.data[18] == 22)
					{
						global2.data[108] += 2;
					}
					else if (global2.data[18] == 23)
					{
						global2.data[108] += 3;
					}
					if (global2.data[50] == 24)
					{
						global2.data[108]++;
					}
					else if (global2.data[50] == 25)
					{
						global2.data[108]--;
					}
					else if (global2.data[50] == 28)
					{
						global2.data[108]++;
					}
					else if (global2.data[50] == 29)
					{
						global2.data[108] += 3;
					}
					if (global2.modifies[7].active)
					{
						global2.data[108]--;
					}
					if (global2.modifies[13].active)
					{
						global2.data[108] -= 2;
					}
					if (global2.modifies[5].active)
					{
						global2.data[108] += 3;
					}
				}
				else if (global2.data[16] == 12)
				{
					if (global2.data[108] > 50)
					{
						global2.data[1] -= (global2.data[108] - 50) * 10;
						Empire empire = global2.empires[0];
						empire.relations -= (global2.data[108] - 50) * 5;
						global2.data[5] += (global2.data[108] - 50) * 5;
						global2.data[6] += (global2.data[108] - 50) * 5;
						global2.data[9] -= (global2.data[108] - 50) * 5;
						global2.data[108] = 50;
					}
					if (global2.data[15] == 9)
					{
						global2.data[108]--;
					}
					if (global2.data[17] == 19)
					{
						global2.data[108]--;
					}
					if (global2.data[50] == 24)
					{
						global2.data[108]++;
					}
					else if (global2.data[50] == 25)
					{
						global2.data[108]--;
					}
					else if (global2.data[50] == 28)
					{
						global2.data[108]++;
					}
					else if (global2.data[50] == 29)
					{
						global2.data[108] += 3;
					}
					global2.data[108] -= 3;
					if (global2.modifies[5].active)
					{
						global2.data[108] += 3;
					}
				}
				else if (global2.data[108] > 0)
				{
					global2.data[1] -= global2.data[108] * 10;
					Empire empire = global2.empires[0];
					empire.relations -= global2.data[108] * 5;
					global2.data[5] += global2.data[108] * 5;
					global2.data[6] += global2.data[108] * 5;
					global2.data[9] -= global2.data[108] * 5;
					global2.data[108] = 0;
				}
				if (global2.data[89] == 2 && !global2.event_done[54])
				{
					global2.data[28]++;
				}
				if (global2.data[20] == 7 && global2.data[21] == 1983 && global2.allcountries[2].Gosstroy == 0 && global2.allcountries[2].prosov)
				{
					global2.allcountries[2].Gosstroy = 1;
					global2.allcountries[2].SubGosstroy = 1;
				}
				if (global2.war == 2)
				{
					if (global2.data[40] >= 1000)
					{
						GameState gameState = global2;
						gameState.influencePRC += 10;
						global2.data[62] = 2;
						global2.allcountries[1].ILoveSuckCocks();
						global2.data[34] += 434;
						global2.war = 0;
						global2.number_event = 443;
						SceneManager.LoadScene("Event");
					}
					global2.data[34] -= 2;
					if (global2.data[40] >= 50)
					{
						global2.data[40] -= 50;
					}
					else if (global2.influencePRC >= 20)
					{
						GameState gameState = global2;
						gameState.influencePRC -= 20;
					}
					if (global2.data[40] <= 0)
					{
						GameState gameState = global2;
						gameState.influencePRC -= 20;
						global2.war = 0;
					}
				}
				global2.allcountries[39].dev = 0;
				global2.allcountries[11].stab = 0;
				global2.allcountries[19].stab = 0;
				global2.allcountries[138].dev = 0;
				global2.allcountries[19].prcpower = 0;
				global2.allcountries[66].cw = false;
				if (global2.allcountries[126].parts[0])
				{
					Country country = global2.allcountries[126];
					country.level_of_unstab -= global2.empires[0].power / 100;
					country = global2.allcountries[126];
					country.level_of_unstab += global2.empires[1].power / 100;
				}
				if (global2.iranrev && !GlobalScript.inst.gameState.event_done[58])
				{
					global2.data[42] += global2.empires[1].power / 25 + 30;
					global2.data[43] += global2.empires[0].power / 30;
					global2.data[44] += global2.empires[0].power / 35;
				}
				for (int num33 = 0; num33 < global2.politics.Length; num33++)
				{
					if (global2.politics[num33].is_sledstvie && global2.politics[num33].sled_slej < 7)
					{
						Politic politic2 = global2.politics[num33];
						politic2.sled_slej++;
					}
					else if (global2.politics[num33].sled_slej >= 7)
					{
						global2.politics[num33].sled_slej = 0;
						global2.politics[num33].is_sledstvie = false;
					}
					if (global2.politics[num33].is_sleshka && global2.politics[num33].days_sleshka < 7)
					{
						Politic politic2 = global2.politics[num33];
						politic2.days_sleshka++;
					}
					else if (global2.politics[num33].days_sleshka >= 7)
					{
						global2.politics[num33].days_sleshka = 0;
						global2.politics[num33].is_sleshka = false;
					}
					if (global2.politics[num33].autosupport == 10)
					{
						global2.data[8]--;
						global2.data[1] -= 20;
						global2.data[9] -= 5;
						Politic politic2 = global2.politics[num33];
						politic2.power += (1976 - global2.data[21]) * 5;
						politic2 = global2.politics[num33];
						politic2.loyality += 50;
						politic2 = global2.politics[num33];
						politic2.power += global2.politics[num33].power / 10;
					}
					else if (global2.politics[num33].autohound == 10)
					{
						global2.data[8]--;
						global2.data[1] -= 20;
						global2.data[9] -= 20;
						Politic politic2 = global2.politics[num33];
						politic2.loyality -= 250;
						politic2 = global2.politics[num33];
						politic2.power -= (1976 - global2.data[21]) * 5;
						if (global2.politics[num33].power >= 10)
						{
							politic2 = global2.politics[num33];
							politic2.power -= global2.politics[num33].power / 10;
						}
					}
					if (global2.politics_dolshnost[4] == num33 || global2.politics_dolshnost[5] == num33 || global2.politics_dolshnost[6] == num33 || global2.politics_dolshnost[7] == num33)
					{
						Politic politic2 = global2.politics[num33];
						politic2.power += 10;
					}
					else if (global2.politics_dolshnost[3] == num33)
					{
						Politic politic2 = global2.politics[num33];
						politic2.power += 15;
					}
					else if (global2.politics_dolshnost[2] == num33 || global2.politics_dolshnost[1] == num33 || global2.politics_dolshnost[0] == num33)
					{
						Politic politic2 = global2.politics[num33];
						politic2.power += 20;
					}
					else if (global2.politics[num33].traits[2] == 18)
					{
						Politic politic2 = global2.politics[num33];
						politic2.power += 4;
					}
					else if (global2.politics[num33].traits[2] == 19)
					{
						Politic politic2 = global2.politics[num33];
						politic2.power -= 20;
					}
					else if (global2.politics[num33].traits[2] == 16)
					{
						Politic politic2 = global2.politics[num33];
						politic2.power++;
						politic2 = global2.politics[num33];
						politic2.power += global2.data[26] / 50;
					}
					else
					{
						Politic politic2 = global2.politics[num33];
						politic2.power++;
					}
					if (global2.data[21] > 1977)
					{
						Politic politic2 = global2.politics[num33];
						politic2.power += (1976 - global2.data[21]) / 2;
					}
				}
				AfricanCoups();
				if (global2.data[19] == 1 && (global2.data[20] == 7 || global2.data[20] == 1))
				{
					global2.event_done[5] = false;
					global2.event_done[7] = false;
					global2.event_done[8] = false;
					global2.event_done[9] = false;
					global2.event_done[10] = false;
				}
				if (global2.allcountries[39].dev == 1)
				{
					global2.allcountries[39].dev = 0;
				}
				if (global2.data[13] < 250)
				{
					global2.data[34] -= 15;
				}
				else if (global2.data[13] < 410)
				{
					global2.data[34] -= 8;
				}
				if (global2.data[68] < 250)
				{
					global2.data[34] -= 4;
				}
				if (global2.data[12] < 250)
				{
					global2.data[34] -= 8;
				}
				else if (global2.data[12] < 410)
				{
					global2.data[34] -= 4;
				}
				if (global2.data[17] == 18)
				{
					global2.data[34] -= 4;
				}
				else if (global2.data[17] == 19)
				{
					global2.data[34] -= 9;
				}
				if (global2.data[50] == 28)
				{
					global2.data[34] += global2.data[105];
				}
				else if (global2.data[50] == 29)
				{
					global2.data[34] += 2 * global2.data[105];
				}
				if (global2.data[16] == 11)
				{
					global2.data[12] += global2.data[34] / 5000;
				}
				else if (global2.data[16] == 10)
				{
					global2.data[12] += global2.data[34] / 5000;
				}
				else if (global2.data[16] == 14 && !global2.modifies[13].active)
				{
					global2.data[3] -= global2.data[34] / 4000;
				}
				else if (global2.data[16] == 15 && !global2.modifies[13].active)
				{
					global2.data[3] -= global2.data[34] / 4000;
				}
				global2.data[34] += global2.data[5] / 60 * global2.data[105];
				if (global2.data[14] <= 0 && global2.data[5] <= 500)
				{
					global2.data[34] += 6 * global2.data[105];
				}
				else if (global2.data[14] <= 3 && global2.data[5] <= 400)
				{
					global2.data[34] += 2 * global2.data[105];
				}
				else if (global2.data[14] == 4 && global2.data[5] >= 850)
				{
					global2.data[34] -= 11;
				}
				else if (global2.data[14] == 4 && global2.data[5] >= 650)
				{
					global2.data[34] -= 9;
				}
				else if (global2.data[14] == 5 && global2.data[5] >= 850)
				{
					global2.data[34] -= 13;
				}
				else if (global2.data[14] == 5 && global2.data[5] >= 650)
				{
					global2.data[34] -= 11;
				}
				global2.data_old[34] = global2.data[34] - num15;
			}
			if (global2.data[19] % 7 == 0)
			{
				for (int num34 = 0; num34 < global2.politics.Length; num34++)
				{
					if (global2.politics[num34].is_sledstvie && global2.politics[num34].sled_slej < 7)
					{
						Politic politic2 = global2.politics[num34];
						politic2.power -= 5;
					}
					else if (global2.politics[num34].power > 1000 && (global2.politics[num34].name_1 != 1 || global2.politics[num34].name_2 != 1))
					{
						global2.politics[num34].power = 1000;
					}
				}
				if (global2.data[117] == 9 && global2.allcountries[14].proprc)
				{
					global2.data[117] = 0;
				}
				if (global2.data[15] <= 7)
				{
					for (int num35 = 0; num35 < global2.is_party_enabled.Length; num35++)
					{
						if (global2.is_party_ally[num35])
						{
							global2.party_ideology[num35] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 100;
							global2.data[8]--;
							global2.data[9] -= 2;
						}
					}
				}
				for (int num36 = 0; num36 < global2.allcountries.Length; num36++)
				{
					if (global2.allcountries[num36].puppetOf >= 0)
					{
						if (global2.allcountries[global2.allcountries[num36].puppetOf].Vyshi)
						{
							global2.allcountries[num36].EstablishGovernment(Government.ProAmerican);
						}
						else if (global2.allcountries[global2.allcountries[num36].puppetOf].prosov)
						{
							global2.allcountries[num36].EstablishGovernment(Government.ProSoviet);
						}
						else if (global2.allcountries[global2.allcountries[num36].puppetOf].proprc)
						{
							global2.allcountries[num36].EstablishGovernment(Government.ProChina);
						}
						else
						{
							global2.allcountries[num36].EstablishGovernment(Government.ProNeuthral);
						}
					}
				}
			}
			if (global2.data[19] % 14 == 0)
			{
				GameObject gameObject = GameObject.Find("Ach(Clone)");
				ch_support = global2.data[3];
				ch_profit = global2.data[8];
				ch_lib = global2.data[4];
				int[] array5 = new int[global2.data_old.Length];
				for (int num37 = 0; num37 < global2.data_old.Length; num37++)
				{
					if (num37 != 34)
					{
						array5[num37] = global2.data[num37];
					}
				}
				array5[28] = global2.empires[0].relations;
				array5[29] = global2.empires[1].relations;
				array5[7] = global2.influencePRC;
				GlobalScript.inst.gameState.FixSubs();
				GlobalScript.inst.gameState.FixAlliances();
				if (global2.data[131] == 1 && global2.allcountries[44].SubGosstroy == 9 && global2.allcountries[86].SubGosstroy == 9 && global2.allcountries[85].SubGosstroy == 9 && global2.allcountries[87].SubGosstroy == 7 && GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(131);
				}
				for (int num38 = 0; num38 < global2.allcountries.Length; num38++)
				{
					if (((num38 >= 53 && num38 < 69) || (num38 > 105 && num38 < 109) || (num38 > 111 && num38 < 134)) && global2.allcountries[num38].proprc && global2.allcountries[num38].econ && !global2.allcountries[num38].africaOff)
					{
						global2.allcountries[num38].stab = 1000;
						global2.allcountries[num38].dev = 1000;
					}
					else if (((num38 >= 53 && num38 < 69) || (num38 > 105 && num38 < 109) || (num38 > 111 && num38 < 134) || global2.allcountries[num38].econ) && global2.allcountries[num38].proprc && global2.allcountries[num38].stab != 0 && global2.allcountries[num38].dev != 0 && global2.allcountries[num38].prcpower != 0 && global2.allcountries[num38].Torg && !global2.allcountries[num38].africaOff)
					{
						Country country = global2.allcountries[num38];
						country.stab -= 2;
						country = global2.allcountries[num38];
						country.dev--;
					}
				}
				Empire empire;
				if (global2.SOV_PRC_PartiesConnection > 0)
				{
					empire = global2.empires[1];
					empire.relations += global2.SOV_PRC_PartiesConnection / 10;
				}
				if (!global2.allcountries[51].isNATO && global2.empires[0].power > 0)
				{
					global2.empires[0].power = 0;
				}
				if (!global2.allcountries[7].isOVD && global2.empires[1].power > 0)
				{
					global2.empires[1].power = 0;
				}
				if ((global2.data[64] == 2 || global2.completedDecisions[7]) && global2.allcountries[51].cw && global2.data[157] > 0)
				{
					gameObject.GetComponent<achievements>().Set(155);
				}
				if (global2.data[143] <= 10 && global2.modifies[51].active)
				{
					gameObject.GetComponent<achievements>().Set(158);
				}
				if (global2.data[143] >= 60 && global2.modifies[51].active)
				{
					gameObject.GetComponent<achievements>().Set(157);
				}
				if (global2.allcountries[36].proprc && global2.allcountries[101].proprc && global2.allcountries[102].proprc && global2.allcountries[103].proprc && global2.allcountries[105].proprc)
				{
					gameObject.GetComponent<achievements>().Set(156);
				}
				if (global2.data[143] < 10)
				{
					global2.data[143] = 10;
				}
				if (global2.data[143] > 60 && !global2.ingamewars[43].is_going && !global2.ingamewars[37].is_going && !global2.ingamewars[38].is_going)
				{
					global2.data[143] = 60;
				}
				if (global2.ingamewars[43].is_going)
				{
					global2.data[143] += 8;
				}
				if (global2.ingamewars[37].is_going)
				{
					global2.data[143] += 5;
				}
				if (global2.ingamewars[38].is_going)
				{
					global2.data[143] += 3;
				}
				if (global2.allcountries[87].spec > 100)
				{
					global2.allcountries[87].spec = 100;
				}
				else if (global2.allcountries[87].spec < 0)
				{
					global2.allcountries[87].spec = 0;
				}
				if (!GlobalScript.inst.gameState.allcountries[123].cw && global2.allcountries[123].prcpower > 0 && global2.allcountries[123].prcpower < 900 && global2.event_done[638] && !global2.ingamewars[68].is_going)
				{
					if (global2.empires[1].power > 0)
					{
						Country country = global2.allcountries[123];
						country.prcpower += global2.empires[1].power * 3 / 100;
					}
					if (global2.resultOfEvents[638] == 0)
					{
						Country country = global2.allcountries[123];
						country.prcpower += 10;
					}
				}
				if (!GlobalScript.inst.gameState.allcountries[123].cw && global2.allcountries[123].sovpower > 0 && global2.allcountries[123].sovpower < 900 && global2.event_done[638] && !global2.ingamewars[68].is_going)
				{
					if (global2.empires[0].power > 0)
					{
						Country country = global2.allcountries[123];
						country.sovpower += global2.empires[0].power * 3 / 100;
					}
					if (global2.resultOfEvents[638] == 1)
					{
						Country country = global2.allcountries[123];
						country.sovpower += 10;
					}
				}
				if (!GlobalScript.inst.gameState.allcountries[123].cw && global2.allcountries[123].usapower > 0 && global2.allcountries[123].usapower < 900 && global2.event_done[638] && !global2.ingamewars[68].is_going)
				{
					if (global2.empires[0].power > 0)
					{
						Country country = global2.allcountries[123];
						country.usapower += global2.empires[0].power * 3 / 100;
					}
					if (global2.resultOfEvents[638] == 2)
					{
						Country country = global2.allcountries[123];
						country.usapower += 10;
					}
				}
				if ((global2.allcountries[17].parts[0] || global2.allcountries[7].isNATO) && global2.allcountries[17].Gosstroy != 1)
				{
					global2.modifies[53].active = false;
				}
				global2.data[0] += global2.data[81] / 50;
				bool flag2 = false;
				warinwars[] ingamewars = global2.ingamewars;
				foreach (warinwars warinwars2 in ingamewars)
				{
					if (warinwars2.is_going)
					{
						flag2 = true;
						break;
					}
				}
				if (global2.data[146] > 0)
				{
					global2.modifies[52].active = true;
				}
				else if (global2.data[146] <= 0 || (!global2.allcountries[1].isOVD && !global2.allcountries[1].isSEATO))
				{
					global2.modifies[52].active = false;
					for (int num40 = 0; num40 < global2.allcountries.Length; num40++)
					{
						global2.allcountries[num40].dota = false;
					}
				}
				if (global2.allcountries[7].isNATO && !global2.ingamewars[17].is_going)
				{
					int num41 = (global2.empires[0].power + global2.empires[1].power) / 10;
					for (int num42 = 0; num42 < 10; num42++)
					{
						if (!global2.allcountries[num42].okb && global2.allcountries[num42].isOVD && global2.allcountries[num42].Vyshi && !global2.allcountries[num42].prosov && global2.allcountries[num42].inflNATO < 1000 && (num42 == 2 || num42 == 4 || num42 == 6 || num42 == 98))
						{
							Country country = global2.allcountries[num42];
							country.inflNATO += num41;
							country = global2.allcountries[num42];
							country.inflCh -= num41;
							if (!global2.allcountries[num42].econ)
							{
								country = global2.allcountries[num42];
								country.inflNATO += 50;
								country = global2.allcountries[num42];
								country.inflCh -= 50;
							}
							else if (!global2.allcountries[num42].based)
							{
								country = global2.allcountries[num42];
								country.inflNATO += 30;
								country = global2.allcountries[num42];
								country.inflCh -= 30;
							}
							else if (!global2.allcountries[num42].okb)
							{
								country = global2.allcountries[num42];
								country.inflNATO += 10;
								country = global2.allcountries[num42];
								country.inflCh -= 10;
							}
						}
						if (global2.allcountries[num42].inflNATO < 1000 || global2.allcountries[num42].isNATO || (num42 != 2 && num42 != 4 && num42 != 6 && num42 != 98))
						{
							continue;
						}
						global2.allcountries[num42].isOVD = false;
						global2.allcountries[num42].based = false;
						global2.allcountries[num42].econ = false;
						global2.allcountries[num42].proprc = false;
						global2.allcountries[num42].isNATO = true;
						global2.allcountries[num42].Torg = false;
						if (global2.empires[0].power >= global2.empires[1].power)
						{
							global2.allcountries[num42].isEU = true;
							global2.allcountries[num42].Vyshi = true;
							global2.allcountries[num42].Gosstroy = global2.allcountries[51].Gosstroy;
							global2.allcountries[num42].SubGosstroy = global2.allcountries[51].SubGosstroy;
							continue;
						}
						if (global2.allcountries[7].isEU)
						{
							global2.allcountries[num42].isEU = true;
						}
						else
						{
							global2.allcountries[num42].isSEV = true;
						}
						global2.allcountries[num42].prosov = true;
						global2.allcountries[num42].Gosstroy = global2.allcountries[7].Gosstroy;
						global2.allcountries[num42].SubGosstroy = global2.allcountries[7].SubGosstroy;
					}
				}
				if (((global2.allcountries[47].isSEV && global2.allcountries[1].isSEV) || (global2.allcountries[47].isSEATO && global2.allcountries[1].isSEATO) || (global2.allcountries[47].econ && global2.allcountries[1].econ)) && global2.data[37] < 1000)
				{
					global2.data[37] = 0;
				}
				if (global2.allcountries[1].isOVD || global2.allcountries[1].isSEATO)
				{
					int num43 = 0;
					int num44 = global2.influencePRC / 100 * 2;
					int num45 = global2.empires[1].power / 100;
					int num46 = global2.empires[0].power / 100;
					for (int num47 = 0; num47 < global2.allcountries.Length; num47++)
					{
						if (global2.allcountries[num47].proprc && num47 != 1)
						{
							num43++;
						}
						if (global2.allcountries[num47].sovinfl < 0)
						{
							global2.allcountries[num47].sovinfl = 0;
						}
						if (global2.allcountries[num47].prcinfl < 0)
						{
							global2.allcountries[num47].prcinfl = 0;
						}
						if (global2.allcountries[num47].usainfl < 0)
						{
							global2.allcountries[num47].usainfl = 0;
						}
						if (global2.allcountries[num47].sovinfl > 1000)
						{
							global2.allcountries[num47].sovinfl = 1000;
						}
						if (global2.allcountries[num47].prcinfl > 1000)
						{
							global2.allcountries[num47].prcinfl = 1000;
						}
						if (global2.allcountries[num47].usainfl > 1000)
						{
							global2.allcountries[num47].usainfl = 1000;
						}
					}
					if (global2.allcountries[1].isOVD)
					{
						int num48 = 0;
						for (int num49 = 0; num49 < global2.allcountries.Length; num49++)
						{
							if (global2.allcountries[num49].prosov && num49 != 7)
							{
								num48++;
							}
						}
						for (int num50 = 0; num50 < global2.allcountries.Length; num50++)
						{
							if (global2.allcountries[num50].isOVD && (num50 == 8 || num50 == 11 || num50 == 14 || num50 == 12 || num50 == 31 || num50 == 32 || num50 == 22 || num50 == 43 || num50 == 42 || num50 == 23 || num50 == 33 || num50 == 35 || num50 == 96 || num50 == 97 || num50 == 98 || num50 == 95 || num50 == 49 || num50 == 50))
							{
								Country country = global2.allcountries[num50];
								country.sovinfl += num45;
								country = global2.allcountries[num50];
								country.sovinfl += num48 / 2;
								if (global2.empires[1].now_leader == 4)
								{
									country = global2.allcountries[num50];
									country.sovinfl += 10;
								}
								if (global2.empires[1].now_leader == 3)
								{
									country = global2.allcountries[num50];
									country.sovinfl += 5;
								}
								if (global2.allcountries[num50].Gosstroy != global2.allcountries[7].Gosstroy)
								{
									country = global2.allcountries[num50];
									country.sovinfl += 2;
								}
								if (global2.allcountries[num50].SubGosstroy != global2.allcountries[7].SubGosstroy)
								{
									country = global2.allcountries[num50];
									country.sovinfl++;
								}
								country = global2.allcountries[num50];
								country.prcinfl += num44;
								country = global2.allcountries[num50];
								country.prcinfl += num43 / 2;
								country = global2.allcountries[num50];
								country.prcinfl += global2.data[81] / 10 / 5 * 3;
								if (global2.allcountries[num50].Gosstroy != global2.allcountries[1].Gosstroy)
								{
									country = global2.allcountries[num50];
									country.prcinfl += 2;
								}
								if (global2.allcountries[num50].SubGosstroy != global2.allcountries[1].SubGosstroy)
								{
									country = global2.allcountries[num50];
									country.prcinfl++;
								}
							}
						}
					}
					else
					{
						int num51 = 0;
						for (int num52 = 0; num52 < global2.allcountries.Length; num52++)
						{
							if (global2.allcountries[num52].Vyshi && num52 != 51)
							{
								num51++;
							}
						}
						for (int num53 = 0; num53 < global2.allcountries.Length; num53++)
						{
							if (global2.allcountries[num53].isSEATO)
							{
								Country country = global2.allcountries[num53];
								country.usainfl += num46;
								country = global2.allcountries[num53];
								country.usainfl += num51 / 2;
								if (global2.empires[0].now_leader == 0 || global2.empires[0].now_leader == 2)
								{
									country = global2.allcountries[num53];
									country.usainfl += 10;
								}
								if (global2.modifies[41].active)
								{
									country = global2.allcountries[num53];
									country.usainfl -= 5;
								}
								if (global2.allcountries[num53].Gosstroy != global2.allcountries[51].Gosstroy)
								{
									country = global2.allcountries[num53];
									country.sovinfl += 2;
								}
								if (global2.allcountries[num53].SubGosstroy != global2.allcountries[51].SubGosstroy)
								{
									country = global2.allcountries[num53];
									country.sovinfl++;
								}
								country = global2.allcountries[num53];
								country.prcinfl += num44;
								country = global2.allcountries[num53];
								country.prcinfl += num43 / 2;
								country = global2.allcountries[num53];
								country.prcinfl += global2.data[81] / 10 / 5 * 2;
								if (global2.allcountries[num53].Gosstroy != global2.allcountries[1].Gosstroy)
								{
									country = global2.allcountries[num53];
									country.prcinfl += 2;
								}
								if (global2.allcountries[num53].SubGosstroy != global2.allcountries[1].SubGosstroy)
								{
									country = global2.allcountries[num53];
									country.prcinfl++;
								}
							}
						}
					}
					if (global2.empires[1].money >= 250 && global2.allcountries[1].isOVD && GlobalScript.inst.dlc[3] && global2.data[142] <= 0 && global2.data[144] <= 0)
					{
						for (int num54 = 8; num54 < global2.allcountries.Length; num54++)
						{
							if (global2.allcountries[num54].sovinfl >= 800 && global2.data[141] <= 0 && !global2.allcountries[num54].prosov && num54 != 9)
							{
								global2.data[141] = num54;
								global2.data[142] = 4;
								global2.data[144] = 8;
							}
						}
					}
					if (global2.empires[0].money >= 250 && global2.allcountries[1].isSEATO && GlobalScript.inst.dlc[3] && global2.data[142] <= 0 && global2.data[145] <= 0)
					{
						for (int num55 = 8; num55 < global2.allcountries.Length; num55++)
						{
							if (global2.allcountries[num55].usainfl >= 800 && global2.data[141] <= 0 && !global2.allcountries[num55].Vyshi)
							{
								global2.data[141] = num55;
								global2.data[142] = 4;
								global2.data[145] = 8;
							}
						}
					}
					if ((global2.data[141] > 0) & (global2.data[142] <= 0))
					{
						if (global2.allcountries[1].isOVD)
						{
							empire = global2.empires[1];
							empire.money -= 250;
							empire = global2.empires[1];
							empire.power += 10;
							global2.allcountries[global2.data[141]].EstablishGovernment(Government.ProSoviet);
							global2.allcountries[global2.data[141]].Gosstroy = global2.allcountries[7].Gosstroy;
							global2.allcountries[global2.data[141]].SubGosstroy = global2.allcountries[7].SubGosstroy;
							global2.allcountries[global2.data[141]].sovinfl = 500;
							global2.allcountries[global2.data[141]].prcinfl = 0;
							global2.data[141] = 0;
						}
						else
						{
							empire = global2.empires[0];
							empire.money -= 250;
							empire = global2.empires[0];
							empire.power += 10;
							global2.allcountries[global2.data[141]].EstablishGovernment(Government.ProAmerican);
							global2.allcountries[global2.data[141]].Gosstroy = global2.allcountries[51].Gosstroy;
							global2.allcountries[global2.data[141]].SubGosstroy = global2.allcountries[51].SubGosstroy;
							global2.allcountries[global2.data[141]].usainfl = 500;
							global2.allcountries[global2.data[141]].prcinfl = 0;
							global2.data[141] = 0;
						}
					}
					if (global2.data[141] > 0)
					{
						if (global2.allcountries[1].isOVD && (global2.allcountries[global2.data[141]].sovinfl <= 700 || global2.empires[1].money < 250))
						{
							global2.data[141] = 0;
							global2.data[142] = 0;
						}
						if (global2.allcountries[1].isSEATO && (global2.allcountries[global2.data[141]].usainfl <= 700 || global2.empires[0].money < 250))
						{
							global2.data[141] = 0;
							global2.data[142] = 0;
						}
					}
				}
				for (int num56 = 2; num56 < global2.allcountries.Length; num56++)
				{
					if (global2.allcountries[num56].isASEAN && (global2.allcountries[num56].prosov || global2.allcountries[num56].Gosstroy == 1))
					{
						global2.allcountries[num56].LeaveASEAN().LeaveSEATO();
					}
				}
				if ((global2.allcountries[8].isSEATO || global2.allcountries[8].isASEAN) && global2.allcountries[8].SubGosstroy == 9)
				{
					global2.allcountries[8].LeaveASEAN().LeaveASEAN();
				}
				if (flag2)
				{
					global2.data[0] += global2.influencePRC / 12;
				}
				if (global2.data[16] <= 12)
				{
					if (global2.data[102] == 1)
					{
						global2.data[12] += 3;
					}
					else if (global2.data[102] == 2)
					{
						global2.data[13] += 3;
					}
					else if (global2.data[102] == 3)
					{
						global2.data[68] += 3;
					}
					else if (global2.data[102] == 4)
					{
						global2.data[12]--;
						global2.data[13]--;
						global2.data[68]--;
					}
					else if (global2.data[102] == 5)
					{
						global2.data[12]++;
						global2.data[13]++;
						global2.data[68]++;
					}
				}
				if (global2.data[5] > (global2.data[12] + global2.data[13] + global2.data[68] - global2.data[26]) / 3 + 20)
				{
					global2.data[5] -= ((global2.data[12] + global2.data[13] + global2.data[68] - global2.data[26]) / 3 + 20) / 10;
				}
				if (global2.allcountries[15].cw)
				{
					if (global2.empires[1].relations < 700)
					{
						empire = global2.empires[1];
						empire.relations += 5;
					}
					if (global2.empires[0].relations < 700)
					{
						empire = global2.empires[0];
						empire.relations += 5;
					}
					global2.data[8] -= 2;
					if (global2.data[6] > 600)
					{
						global2.data[6] -= 2;
					}
					else if (global2.data[6] < 400)
					{
						global2.data[6] += 2;
					}
				}
				if (global2.data[14] >= 4 && global2.data[16] >= 14)
				{
					global2.data[26]--;
				}
				if (global2.allcountries[85].inflCh == 6)
				{
					if (global2.data[134] <= 1000 && global2.data[134] > 0)
					{
						global2.data[134] -= 50;
					}
					if (global2.data[134] > 1000)
					{
						global2.data[134] = 1000;
					}
					if (global2.data[134] < 0)
					{
						global2.data[134] = 0;
					}
				}
				if (global2.data[21] < 1980)
				{
					if (global2.data[16] == 13)
					{
						global2.data[26] -= global2.data[36] / 400;
						if (global2.data[36] < 600)
						{
							global2.data[5] -= 3 - global2.data[36] / 150;
							global2.data[68] -= 3 - global2.data[36] / 150;
							global2.data[12] -= 3 - global2.data[36] / 150;
						}
						else
						{
							global2.data[5]++;
							global2.data[68]++;
							global2.data[12]++;
						}
					}
					else if (global2.data[16] >= 14)
					{
						global2.data[26] -= global2.data[36] / 200;
						if (global2.data[36] < 750)
						{
							global2.data[5] -= 4 - global2.data[36] / 150;
							global2.data[68] -= 4 - global2.data[36] / 150;
							global2.data[12] -= 4 - global2.data[36] / 150;
						}
						else
						{
							global2.data[5]++;
							global2.data[68]++;
							global2.data[12]++;
						}
					}
				}
				else if (global2.data[16] == 13)
				{
					global2.data[26] -= global2.data[36] / 600;
					if (global2.data[36] < 750)
					{
						global2.data[5] -= 4 - global2.data[36] / 150;
						global2.data[68] -= 4 - global2.data[36] / 150;
						global2.data[12] -= 4 - global2.data[36] / 150;
					}
					else
					{
						global2.data[5]++;
						global2.data[68]++;
						global2.data[12]++;
					}
				}
				else if (global2.data[16] == 14)
				{
					global2.data[26] -= global2.data[36] / 400;
					if (global2.data[36] < 1500)
					{
						global2.data[5] -= 7 - global2.data[36] / 150;
						global2.data[68] -= 7 - global2.data[36] / 150;
						global2.data[12] -= 7 - global2.data[36] / 150;
					}
					else
					{
						global2.data[5] += 3;
						global2.data[68] += 3;
						global2.data[12] += 3;
					}
				}
				else if (global2.data[16] == 15)
				{
					global2.data[26] -= global2.data[36] / 200;
					global2.data[5] -= 13 - global2.data[36] / 150;
					global2.data[68] -= 13 - global2.data[36] / 150;
					global2.data[12] -= 13 - global2.data[36] / 150;
				}
				else if (global2.data[16] == 12)
				{
					global2.data[26] -= global2.data[36] / 200;
					if (global2.data[36] < 600)
					{
						global2.data[5] -= 3 - global2.data[36] / 150;
						global2.data[68] -= 3 - global2.data[36] / 150;
						global2.data[12] -= 3 - global2.data[36] / 150;
					}
					else
					{
						global2.data[5]++;
						global2.data[68]++;
						global2.data[12]++;
					}
				}
				int num57 = UnityEngine.Random.Range(-10, 30);
				int num58 = 0;
				for (int num59 = 0; num59 < global2.allcountries.Length; num59++)
				{
					bool flag3 = (num59 == 19 || num59 == 52 || num59 == 48 || num59 == 50 || num59 == 96 || num59 == 49 || num59 == 47 || num59 == 46 || num59 == 11 || num59 == 22 || num59 == 23 || num59 == 34 || num59 == 33 || num59 == 32 || num59 == 97 || num59 == 43 || num59 == 31 || num59 == 12 || num59 == 8 || num59 == 14 || num59 == 35 || (num59 >= 53 && num59 < 69) || (num59 >= 106 && num59 < 109) || (num59 >= 111 && num59 < 134) || (num59 >= 111 && num59 < 134)) && global2.allcountries[num59].puppetOf != 1;
					if (global2.allcountries[num59].econ && !flag3)
					{
						global2.allcountries[num59].soc_stab = 1000;
					}
					else
					{
						if ((num59 >= 53 && num59 < 69) || num59 == 1 || num59 == 20 || num59 == 45 || num59 == 10 || (num59 == 30 && global2.OAR) || ((num59 == 14 || num59 == 35 || num59 == 13) && global2.allcountries[num59].dev == 1) || (!global2.allcountries[num59].econ && !global2.allcountries[num59].okb))
						{
							continue;
						}
						num58++;
						Country country;
						if (global2.data[22] < global2.empires[1].money)
						{
							country = global2.allcountries[num59];
							country.soc_stab += (global2.data[22] - global2.empires[1].money) / 20;
						}
						else if (global2.data[22] > global2.empires[1].money && global2.allcountries[1].okb)
						{
							country = global2.allcountries[num59];
							country.soc_stab += 10;
						}
						if (global2.data[22] < global2.empires[0].money)
						{
							country = global2.allcountries[num59];
							country.soc_stab += (global2.data[22] - global2.empires[0].money) / 20;
						}
						else if (global2.data[22] > global2.empires[0].money && global2.allcountries[1].okb)
						{
							country = global2.allcountries[num59];
							country.soc_stab += 10;
						}
						if (global2.allcountries[num59].soc_stab > 1000)
						{
							global2.allcountries[num59].soc_stab = 1000;
						}
						if (global2.allcountries[num59].prosov)
						{
							global2.allcountries[num59].prosov = false;
							global2.allcountries[num59].proprc = false;
						}
						country = global2.allcountries[num59];
						country.soc_stab += global2.data[36] / 150;
						if (global2.allcountries[num59].soc_stab > 250 && (num59 < 71 || num59 >= 84))
						{
							if (global2.allcountries[num59].usalliance || global2.allcountries[num59].sovalliance)
							{
								country = global2.allcountries[num59];
								country.soc_stab -= 25;
								country = global2.allcountries[num59];
								country.soc_stab -= (global2.allcountries[num59].usalliance ? (global2.empires[0].power / 60) : (global2.empires[1].power / 60));
								country = global2.allcountries[num59];
								country.soc_stab -= global2.allcountries[num59].soc_stab / 60;
							}
							else
							{
								if (num59 < num57)
								{
									continue;
								}
								int min = ((global2.empires[1].power <= global2.empires[0].power) ? global2.empires[0].power : global2.empires[1].power);
								if (((num59 >= 53 && num59 < 69) || global2.allcountries[num59].econ) && !global2.bad_done && UnityEngine.Random.Range(min, 1500 - global2.allcountries[num59].soc_stab) > global2.influencePRC && global2.allcountries[num59].prcpower < 1000)
								{
									if (UnityEngine.Random.Range(min, 1000) > global2.influencePRC)
									{
										int num60 = 4;
										if (global2.influencePRC > global2.empires[1].power)
										{
											num60--;
										}
										if (global2.influencePRC > global2.empires[0].power)
										{
											num60--;
										}
										if (global2.influencePRC > global2.empires[1].power / 2)
										{
											num60--;
										}
										if (global2.influencePRC > global2.empires[0].power / 2)
										{
											num60--;
										}
										if (!global2.allcountries[num59].proprc && num60 <= 2)
										{
											num60 = 2;
										}
										if (global2.allcountries[num59].soc_stab < 500 && num60 <= 2)
										{
											num60 = 2;
										}
										else if (global2.allcountries[num59].soc_stab < 500)
										{
											num60++;
										}
										Debug.Log("ra " + num60 + "i " + num59);
										global2.allcountries[num59].proprc = false;
										if (UnityEngine.Random.Range(num60, 7) > 4)
										{
											if (global2.empires[0].power >= global2.empires[1].power)
											{
												if (UnityEngine.Random.Range(0, 3) > 1)
												{
													global2.allcountries[num59].usalliance = true;
												}
												else
												{
													global2.allcountries[num59].sovalliance = true;
												}
											}
											else if (UnityEngine.Random.Range(0, 3) > 1)
											{
												global2.allcountries[num59].sovalliance = true;
											}
											else
											{
												global2.allcountries[num59].usalliance = true;
											}
										}
										global2.bad_done = true;
									}
									else if (global2.allcountries[num59].proprc)
									{
										global2.bad_done = true;
										global2.allcountries[num59].proprc = false;
									}
								}
								else if (!global2.bad_debuff && UnityEngine.Random.Range(min, 2000 - global2.allcountries[num59].soc_stab) > global2.influencePRC)
								{
									global2.bad_debuff = true;
									country = global2.allcountries[num59];
									country.soc_stab -= 200;
									if (!global2.allcountries[num59].proprc)
									{
										country = global2.allcountries[num59];
										country.soc_stab += 50;
									}
								}
							}
						}
						else if (global2.allcountries[num59].soc_stab <= 250 && global2.data[120] <= 0 && num59 >= num57 && (global2.allcountries[num59].SubGosstroy != 17 || global2.allcountries[num59].proprc))
						{
							global2.data[120] = num59;
						}
					}
				}
				if (global2.allcountries[69].cw)
				{
					global2.data[8] -= 10;
					if (global2.allcountries[69].dev <= 30 || (global2.allcountries[69].dev <= 60 && global2.allcountries[69].Torg) || (global2.allcountries[69].proprc && global2.allcountries[69].dev <= 100))
					{
						Country country = global2.allcountries[69];
						country.dev += 4;
					}
				}
				if (global2.allcountries[70].cw)
				{
					global2.data[8] -= 10;
					if (global2.allcountries[70].dev <= 30 || (global2.allcountries[70].dev <= 60 && global2.allcountries[70].Torg) || (global2.allcountries[70].proprc && global2.allcountries[70].dev <= 100))
					{
						Country country = global2.allcountries[70];
						country.dev += 4;
					}
				}
				if (global2.war == 1)
				{
					global2.data[34]--;
				}
				if (global2.data[39] >= 1000 && global2.war == 1)
				{
					global2.allcountries[11].prosov = false;
					global2.allcountries[11].proprc = true;
					global2.allcountries[11].puppetOf = 1;
					global2.allcountries[11].isSEV = false;
					global2.allcountries[11].Gosstroy = global2.allcountries[1].Gosstroy;
					global2.allcountries[11].SubGosstroy = global2.allcountries[1].SubGosstroy;
					global2.allcountries[23].prosov = false;
					global2.allcountries[23].proprc = true;
					global2.allcountries[23].isSEV = false;
					global2.allcountries[23].puppetOf = -1;
					global2.allcountries[23].Gosstroy = global2.allcountries[1].Gosstroy;
					global2.allcountries[23].SubGosstroy = global2.allcountries[1].SubGosstroy;
					global2.war = 0;
					global2.data[39] = 0;
				}
				else if (global2.data[39] <= 0 && global2.war == 1)
				{
					GameState gameState = global2;
					gameState.influencePRC -= 100;
					global2.war = 0;
					global2.data[39] = 0;
				}
				if (global2.modifies[12].active)
				{
					int num61 = global2.data[23];
					global2.data[23] -= num61 / 6;
				}
				if (global2.data[23] > global2.data[24])
				{
					global2.data[8] += (global2.data[23] - global2.data[24]) / 10;
					global2.data[3] += (global2.data[23] - global2.data[24]) / 15;
				}
				else
				{
					global2.data[8] -= (global2.data[23] - global2.data[24]) / 10;
					global2.data[3] -= (global2.data[23] - global2.data[24]) / 15;
					global2.data[5] -= (global2.data[23] - global2.data[24]) / 20;
				}
				if (global2.data[25] <= 10)
				{
					global2.data[4] -= -9 + global2.data[25];
					global2.data[9] -= -9 + global2.data[25];
				}
				else if (global2.data[25] > 18)
				{
					global2.data[4] += global2.data[25] - 18;
				}
				if (global2.data[31] > 700)
				{
					global2.data[5] -= (global2.data[31] - 500) / 100;
					global2.data[1] += (global2.data[31] - 500) / 100;
					global2.data[9] += (global2.data[31] - 500) / 100;
					if (global2.data[6] < 500)
					{
						global2.data[6] += 5;
					}
				}
				else if (global2.data[31] < 400 || global2.data[31] > 700)
				{
					global2.data[4] += (500 - global2.data[31]) / 100;
					global2.data[1] += (500 - global2.data[31]) / 100;
					global2.data[9] -= (global2.data[31] - 500) / 100;
					empire = global2.empires[0];
					empire.relations += (500 - global2.data[31]) / 100;
					empire = global2.empires[1];
					empire.relations += (500 - global2.data[31]) / 100;
				}
				Country[] allcountries = global2.allcountries;
				foreach (Country country2 in allcountries)
				{
					if (country2.isOVD)
					{
						empire = global2.empires[1];
						empire.power += 12;
					}
					else if (country2.isSEV)
					{
						empire = global2.empires[1];
						empire.power += 7;
					}
					if (country2.prosov)
					{
						empire = global2.empires[1];
						empire.power += 7;
					}
					if (country2.isNATO)
					{
						empire = global2.empires[0];
						empire.power += 6;
					}
					if (country2.isSEATO)
					{
						empire = global2.empires[0];
						empire.power += 5;
					}
					if (country2.isSENTO)
					{
						empire = global2.empires[0];
						empire.power += 5;
					}
					if (country2.isEU)
					{
						empire = global2.empires[0];
						empire.power += 3;
					}
					if (country2.isASEAN)
					{
						empire = global2.empires[0];
						empire.power += 3;
					}
					if (country2.Vyshi)
					{
						empire = global2.empires[0];
						empire.power += 3;
					}
				}
				empire = global2.empires[1];
				empire.power -= global2.influencePRC / 15;
				empire = global2.empires[0];
				empire.power -= global2.influencePRC / 15;
				empire = global2.empires[1];
				empire.power -= global2.empires[1].power / 9;
				empire = global2.empires[0];
				empire.power -= global2.empires[0].power / 9;
				empire = global2.empires[0];
				empire.power -= global2.empires[0].power / 10;
				empire = global2.empires[1];
				empire.power -= global2.empires[1].power / 10;
				if (global2.empires[1].power > 0)
				{
					empire = global2.empires[1];
					empire.money += global2.empires[1].power / 50;
				}
				if (global2.empires[0].power > 0)
				{
					empire = global2.empires[0];
					empire.money += global2.empires[0].power / 50;
				}
				for (int num62 = 0; num62 < global2.ingamewars.Length; num62++)
				{
					if (!global2.ingamewars[num62].is_going)
					{
						continue;
					}
					empire = global2.empires[0];
					empire.money -= global2.empires[0].money / 9;
					empire = global2.empires[1];
					empire.money -= global2.empires[1].money / 9;
					if (global2.ingamewars[num62].diplo_done[0])
					{
						if (global2.ingamewars[num62].usa_place == 0)
						{
							empire = global2.empires[0];
							empire.relations += 2;
							empire = global2.empires[1];
							empire.relations--;
						}
						if (global2.ingamewars[num62].ussr_place == 0)
						{
							empire = global2.empires[1];
							empire.relations += 2;
							empire = global2.empires[0];
							empire.relations--;
						}
					}
					else if (global2.ingamewars[num62].diplo_done[1])
					{
						if (global2.ingamewars[num62].usa_place == 1)
						{
							empire = global2.empires[0];
							empire.relations += 2;
							empire = global2.empires[1];
							empire.relations--;
						}
						if (global2.ingamewars[num62].ussr_place == 1)
						{
							empire = global2.empires[1];
							empire.relations += 2;
							empire = global2.empires[0];
							empire.relations--;
						}
					}
				}
				if (global2.data[69] > 7)
				{
					empire = global2.empires[0];
					empire.money += global2.data[69] / 7;
				}
				if (!global1.dlc[0])
				{
					if (global2.empires[1].now_leader == 0)
					{
						empire = global2.empires[1];
						empire.money += 20;
						if (!global2.relres && !global2.allcountries[1].isSEV)
						{
							empire = global2.empires[0];
							empire.relations += 5;
							global2.data[57] -= 2;
						}
					}
					else if (global2.empires[1].now_leader == 1)
					{
						if (!global2.relres && !global2.allcountries[1].isSEV)
						{
							empire = global2.empires[0];
							empire.relations += 5;
						}
						else
						{
							Politic[] politics = GlobalScript.inst.gameState.politics;
							foreach (Politic politic3 in politics)
							{
								if (politic3.traits[0] == 2)
								{
									Politic politic2 = politic3;
									politic2.power += 5;
								}
							}
						}
					}
					else if (global2.empires[1].now_leader == 2)
					{
						empire = global2.empires[1];
						empire.relations += 5;
						if (global2.relres || global2.allcountries[1].isSEV)
						{
							Politic[] politics = GlobalScript.inst.gameState.politics;
							foreach (Politic politic4 in politics)
							{
								if (politic4.traits[0] == 1)
								{
									Politic politic2 = politic4;
									politic2.power += 5;
								}
							}
						}
					}
					else if (global2.empires[1].now_leader == 3)
					{
						if (!global2.relres && !global2.allcountries[1].isSEV)
						{
							empire = global2.empires[0];
							empire.relations += 5;
							global2.data[57] -= 2;
						}
						else
						{
							empire = global2.empires[1];
							empire.relations += 5;
						}
					}
					else if (global2.empires[1].now_leader == 6)
					{
						empire = global2.empires[1];
						empire.money -= 20;
						empire = global2.empires[1];
						empire.relations += 5;
						global2.data[4] += 5;
						Politic[] politics = GlobalScript.inst.gameState.politics;
						foreach (Politic politic5 in politics)
						{
							if (politic5.traits[0] == 3)
							{
								Politic politic2 = politic5;
								politic2.power += 5;
							}
						}
					}
					else if (global2.empires[1].now_leader == 5)
					{
						empire = global2.empires[1];
						empire.relations += 5;
						if (global2.relres || global2.allcountries[1].isSEV)
						{
							Politic[] politics = GlobalScript.inst.gameState.politics;
							foreach (Politic politic6 in politics)
							{
								if (politic6.traits[0] == 2)
								{
									Politic politic2 = politic6;
									politic2.power += 5;
								}
							}
						}
					}
					else if (global2.empires[1].now_leader == 4)
					{
						if (!global2.relres && !global2.allcountries[1].isSEV)
						{
							global2.data[9] -= 5;
						}
						else
						{
							empire = global2.empires[1];
							empire.relations += 5;
							global2.data[9] += 5;
						}
					}
					else if (global2.empires[1].now_leader == 8)
					{
						empire = global2.empires[1];
						empire.money -= 20;
						empire = global2.empires[1];
						empire.relations += 5;
						global2.data[4] += 5;
					}
					if (global2.data[21] >= 1981 && global2.empires[0].now_leader <= 0)
					{
						empire = global2.empires[0];
						empire.money += 5;
						global2.data[4] += 5;
					}
					else if (global2.empires[0].now_leader == 1 || (global2.data[21] >= 1977 && global2.data[21] < 1981))
					{
						empire = global2.empires[0];
						empire.relations += 10;
					}
					else if (global2.empires[0].now_leader == 2)
					{
						empire = global2.empires[0];
						empire.money += 5;
						if (!global2.allcountries[1].isOVD && !global2.allcountries[1].okb)
						{
							empire = global2.empires[0];
							empire.relations += 5;
						}
					}
					else if (global2.empires[0].now_leader == 3)
					{
						empire = global2.empires[0];
						empire.relations += 10;
					}
				}
				else
				{
					EmpireModifiesChanges(global2.empires[0], 0);
					EmpireModifiesChanges(global2.empires[1], 1);
					if (global2.gamerules[8] > 0)
					{
						empire = global2.empires[0];
						empire.relations -= ((global2.empires[0].relations > 500) ? (global2.empires[0].relations / 50) : 0);
						empire = global2.empires[1];
						empire.relations -= ((global2.empires[1].relations > 500) ? (global2.empires[1].relations / 50) : 0);
						global2.data[26] += (1000 - global2.data[26]) / 200;
						global2.data[26] -= ((global2.data[26] > 500) ? (global2.data[26] / 25) : 0);
					}
				}
				WorldWarsInfluenceChanges();
				if (global2.allcountries[51].dev == 1)
				{
					if (global2.empires[0].relations < 800 || global2.data[6] > 600)
					{
						global2.allcountries[51].dev = 0;
						global2.data[4] += 200;
						empire = global2.empires[1];
						empire.power += 20;
					}
					else
					{
						global2.data[9] += 10;
						global2.data[4] -= 5;
					}
				}
				if ((global2.data[34] - 9307) / 200 > 0)
				{
					global2.data[9] -= (global2.data[34] - 9307) / 200;
				}
				if (global2.data[16] == 11)
				{
					global2.data[8]++;
					global2.data[4] -= 2;
					global2.data[5] += 2;
					global2.data[12] += 2;
					global2.data[26] -= 2;
					if (global2.data[52] > 34)
					{
						global2.data[33] -= 50;
					}
				}
				else if (global2.data[16] == 10)
				{
					global2.data[5] += 2;
					global2.data[4]++;
					global2.data[68]--;
					global2.data[12]++;
					global2.data[26]++;
					if (global2.data[52] > 34)
					{
						global2.data[33] -= 50;
					}
				}
				else if (global2.data[16] == 12)
				{
					global2.data[13]++;
					global2.data[8]++;
					global2.data[68]++;
					global2.data[5] -= 2;
					global2.data[4] -= 2;
					global2.data[26]++;
					if (global2.data[54] < 40)
					{
						global2.data[26]++;
					}
					if (global2.data[52] > 35)
					{
						global2.data[33] -= 20;
					}
					else if (global2.data[52] < 35)
					{
						global2.data[33] += 30;
					}
				}
				else if (global2.data[16] == 13)
				{
					global2.data[8] += 2;
					global2.data[68]++;
					global2.data[5] -= 4;
					global2.data[4]++;
					global2.data[26]++;
					if (global2.data[54] < 40)
					{
						global2.data[26] += 2;
					}
					if (global2.data[52] > 36)
					{
						global2.data[33] -= 40;
					}
					else if (global2.data[52] < 36)
					{
						global2.data[33] += 30;
					}
				}
				else if (global2.data[16] == 14)
				{
					global2.data[8] += 2;
					global2.data[68] += 2;
					global2.data[5] -= 5;
					global2.data[4] += 2;
					global2.data[12]--;
					global2.data[26] += 2;
					if (global2.data[54] < 40)
					{
						global2.data[26] += 4;
					}
					if (global2.data[52] < 37)
					{
						global2.data[33] += 40;
					}
				}
				else if (global2.data[16] == 15)
				{
					global2.data[13]--;
					global2.data[68] += 3;
					global2.data[5] -= 7;
					global2.data[4] += 4;
					global2.data[12] -= 2;
					global2.data[26] += 2;
					if (global2.data[54] < 40)
					{
						global2.data[26] += 5;
					}
					if (global2.data[52] < 37)
					{
						global2.data[33] += 50;
					}
				}
				if (global2.data[15] == 6)
				{
					if (global2.data[54] > 38)
					{
						global2.data[55] -= 10;
					}
				}
				else if (global2.data[15] == 7)
				{
					if (global2.data[54] > 39)
					{
						global2.data[55] -= 20;
					}
					else if (global2.data[54] < 39)
					{
						global2.data[55] += 20;
					}
				}
				else if (global2.data[15] == 8)
				{
					if (global2.data[54] > 40)
					{
						global2.data[55] -= 20;
					}
					else if (global2.data[54] < 40)
					{
						global2.data[55] += 20;
					}
				}
				else if (global2.data[15] == 9 && global2.data[54] < 41)
				{
					global2.data[55] += 30;
				}
				if (global2.data[17] == 16)
				{
					if (global2.data[54] > 38)
					{
						global2.data[55] -= 10;
					}
				}
				else if (global2.data[17] == 17)
				{
					if (global2.data[54] > 39)
					{
						global2.data[55] -= 20;
					}
					else if (global2.data[54] < 39)
					{
						global2.data[55] += 20;
					}
				}
				else if (global2.data[17] == 18)
				{
					if (global2.data[54] > 40)
					{
						global2.data[55] -= 20;
					}
					else if (global2.data[54] < 40)
					{
						global2.data[55] += 20;
					}
				}
				else if (global2.data[17] == 19 && global2.data[54] < 41)
				{
					global2.data[55] += 30;
				}
				if (global2.data[50] == 24)
				{
					if (global2.data[54] > 38)
					{
						global2.data[55] -= 15;
					}
				}
				else if (global2.data[50] == 25)
				{
					if (global2.data[54] > 38)
					{
						global2.data[55] -= 15;
					}
				}
				else if (global2.data[50] == 28)
				{
					if (global2.data[54] < 40)
					{
						global2.data[55] += 10;
					}
				}
				else if (global2.data[50] == 29 && global2.data[54] > 39)
				{
					global2.data[55] -= 15;
				}
				if (global2.data[18] == 20)
				{
					global2.data[8]--;
					global2.data[3] -= 2;
					global2.data[4] -= 4;
					global2.data[57]++;
					if (global2.data[54] > 39)
					{
						global2.data[55] -= 10;
					}
				}
				else if (global2.data[18] == 21)
				{
					global2.data[1] -= 2;
					global2.data[4]--;
					if (global2.data[54] < 40)
					{
						global2.data[55] += 20;
					}
				}
				else if (global2.data[18] == 22)
				{
					global2.data[1] -= 3;
					global2.data[3]--;
					global2.data[4] += 2;
					global2.data[57] -= 2;
					if (global2.data[54] > 40)
					{
						global2.data[55] -= 20;
					}
					else if (global2.data[54] < 40)
					{
						global2.data[55] += 20;
					}
				}
				else if (global2.data[18] == 23)
				{
					global2.data[57] -= 4;
					global2.data[4] += 5;
					global2.data[3] -= 2;
					global2.data[1] -= 5;
					if (global2.data[54] < 41)
					{
						global2.data[55] += 30;
					}
				}
				if (global2.data[51] == 30)
				{
					if (global2.data[34] - 9307 > 99)
					{
						global2.data[8] -= (global2.data[34] - 9307) / 100;
						global2.data[22] += (global2.data[34] - 9307) / 100;
					}
					if (global2.data[54] > 38)
					{
						global2.data[55] -= 10;
					}
				}
				else if (global2.data[51] == 31)
				{
					if (global2.data[34] - 9307 > 199)
					{
						global2.data[8] -= (global2.data[34] - 9307) / 200;
						global2.data[22] += (global2.data[34] - 9307) / 200;
					}
				}
				else if (global2.data[51] == 32)
				{
					if (global2.data[34] - 9307 > 299)
					{
						global2.data[8] -= (global2.data[34] - 9307) / 300;
						global2.data[22] += (global2.data[34] - 9307) / 300;
					}
				}
				else if (global2.data[51] == 33)
				{
					if (global2.data[34] - 9307 > 149)
					{
						if (global2.data[5] < 500)
						{
							global2.data[8] -= (global2.data[34] - 9307) / 150;
							global2.data[22] += (global2.data[34] - 9307) / 250;
						}
						else if (global2.data[5] < 700)
						{
							global2.data[8] -= (global2.data[34] - 9307) / 150;
							global2.data[22] += (global2.data[34] - 9307) / 300;
						}
						else
						{
							global2.data[8] -= (global2.data[34] - 9307) / 500;
							global2.data[22] += (global2.data[34] - 9307) / 500;
						}
					}
					if (global2.data[54] < 40)
					{
						global2.data[55] += 10;
					}
					if (global2.data[52] < 36)
					{
						global2.data[33] += 10;
					}
				}
				if (global2.data[20] == 11 && global2.data[21] == 1977 && global2.allcountries[32].prosov)
				{
					global2.allcountries[32].prosov = false;
				}
				for (int num63 = 0; num63 < global2.politics.Length; num63++)
				{
					if (global2.modifies[14].active)
					{
						if (global2.politics[num63].traits[0] == 2)
						{
							Politic politic2 = global2.politics[num63];
							politic2.power += 10;
						}
						else if (global2.politics[num63].traits[0] == 3 && global2.faction_leader[4] != num63)
						{
							Politic politic2 = global2.politics[num63];
							politic2.power += 5;
						}
					}
					if (global2.faction_leader[0] == num63)
					{
						Politic politic2 = global2.politics[num63];
						politic2.power += 20;
					}
					else if (global2.faction_leader[1] == num63)
					{
						Politic politic2 = global2.politics[num63];
						politic2.power += 20;
					}
					else if (global2.faction_leader[2] == num63)
					{
						Politic politic2 = global2.politics[num63];
						politic2.power += 20;
					}
					else if (global2.faction_leader[3] == num63)
					{
						Politic politic2 = global2.politics[num63];
						politic2.power += 20;
					}
					else if (global2.faction_leader[4] == num63)
					{
						Politic politic2 = global2.politics[num63];
						politic2.power += 20;
					}
					if (global1.dlc[0])
					{
						if (global2.gamerules[7] == 1)
						{
							if (global2.politics[num63].power < 150 * (global2.data[21] - 1976))
							{
								Politic politic2 = global2.politics[num63];
								politic2.power += 25 * (global2.data[21] - 1976);
							}
						}
						else if (global2.gamerules[7] == 2 && global2.politics[num63].power > 500 * (global2.data[21] - 1976))
						{
							Politic politic2 = global2.politics[num63];
							politic2.power += 25 * (global2.data[21] - 1976);
						}
						if (global2.gamerules[8] > 0)
						{
							if (global2.politics[num63].traits[2] == 18)
							{
								Politic politic2 = global2.politics[num63];
								politic2.power += 20;
							}
							else if (global2.politics[num63].traits[2] == 16)
							{
								Politic politic2 = global2.politics[num63];
								politic2.power += 50;
							}
						}
					}
					if (global2.politics_dolshnost[3] == num63 || global2.politics_dolshnost[4] == num63 || global2.politics_dolshnost[5] == num63 || global2.politics_dolshnost[6] == num63 || global2.politics_dolshnost[7] == num63)
					{
						if (global2.politics[num63].traits[0] == 0)
						{
							global2.data[5]--;
							empire = global2.empires[1];
							empire.relations += 2;
							if (global2.data[56] != 0)
							{
								global2.data[1] -= 2;
							}
							global2.data[68]--;
							global2.data[26] -= 2;
						}
						else if (global2.politics[num63].traits[0] == 20)
						{
							global2.data[4]++;
							empire = global2.empires[1];
							empire.relations += 3;
							if (global2.data[56] != 1)
							{
								global2.data[1]--;
							}
							global2.data[1]++;
							global2.data[68]--;
							global2.data[26]--;
						}
						else if (global2.politics[num63].traits[0] == 1)
						{
							global2.data[5]++;
							global2.data[4]++;
							if (global2.data[56] != 2)
							{
								global2.data[1]--;
							}
							global2.data[1] += 2;
						}
						else if (global2.politics[num63].traits[0] == 2)
						{
							global2.data[5] -= 2;
							global2.data[4] += 2;
							if (global2.data[56] != 3)
							{
								global2.data[1]--;
							}
							global2.data[1] += 5;
						}
						else if (global2.politics[num63].traits[0] == 3)
						{
							global2.data[5] -= 5;
							global2.data[4] += 7;
							if (global2.data[56] != 4)
							{
								global2.data[1]--;
							}
							global2.data[1] += 10;
							global2.data[8]++;
						}
						if (global2.politics[num63].traits[1] == 4)
						{
							global2.data[26]--;
							global2.data[4] -= 5;
							global2.data[1] -= 2;
						}
						else if (global2.politics[num63].traits[1] == 5)
						{
							global2.data[1] += 2;
						}
						else if (global2.politics[num63].traits[1] == 6)
						{
							global2.data[26]++;
							global2.data[4] += 5;
							global2.data[1] += 5;
						}
						else if (global2.politics[num63].traits[1] == 7)
						{
							global2.data[11] += 2;
						}
						if (global2.politics[num63].traits[2] == 7)
						{
							global2.data[11] += 2;
						}
						else if (global2.politics[num63].traits[2] == 8)
						{
							global2.data[4] -= 10;
							global2.data[1] -= 5;
						}
						else if (global2.politics[num63].traits[2] == 9)
						{
							global2.data[4] += 2;
							global2.data[1] += 2;
						}
						else if (global2.politics[num63].traits[2] == 10)
						{
							global2.data[1] -= 2;
						}
						else if (global2.politics[num63].traits[2] == 11)
						{
							global2.data[8]++;
						}
						else if (global2.politics[num63].traits[2] == 12)
						{
							global2.data[4] += 3;
							global2.data[1] -= 5;
						}
						else if (global2.politics[num63].traits[2] == 13)
						{
							global2.data[1] += 5;
						}
						else if (global2.politics[num63].traits[2] == 14)
						{
							global2.data[4] += 3;
							global2.data[31] += 5;
						}
						else if (global2.politics[num63].traits[2] == 15)
						{
							global2.data[4] += 3;
							global2.data[31] -= 5;
						}
						else if (global2.politics[num63].traits[2] == 16)
						{
							global2.data[1] += 2;
						}
						else if (global2.politics[num63].traits[2] == 17)
						{
							global2.data[4] += 2;
						}
						else if (global2.politics[num63].traits[2] == 18)
						{
							global2.data[26] += 2;
							global2.data[1] += 5;
							global2.data[8]--;
						}
						else if (global2.politics[num63].traits[2] == 19)
						{
							global2.data[4] += 2;
						}
					}
					if (global2.politics_dolshnost[2] == num63)
					{
						if (global2.politics[num63].traits[0] == 0)
						{
							empire = global2.empires[0];
							empire.relations -= 10;
							if (global2.data[6] < 700)
							{
								global2.data[6] += 2;
							}
							else if (global2.data[6] < 900)
							{
								global2.data[6]++;
							}
							global2.party_ideology[0] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 666;
							global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 1000;
						}
						else if (global2.politics[num63].traits[0] == 20)
						{
							empire = global2.empires[1];
							empire.relations += 5;
							empire = global2.empires[0];
							empire.relations += 2;
							if (global2.data[6] < 500)
							{
								global2.data[6] += 3;
							}
							else if (global2.data[6] < 700)
							{
								global2.data[6] += 2;
							}
							else if (global2.data[6] > 1000)
							{
								global2.data[6]--;
							}
							global2.party_ideology[2] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 1000;
							global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
						}
						else if (global2.politics[num63].traits[0] == 1)
						{
							empire = global2.empires[1];
							empire.relations += 10;
							empire = global2.empires[0];
							empire.relations -= 3;
							if (global2.data[6] < 500)
							{
								global2.data[6] += 2;
							}
							else if (global2.data[6] < 700)
							{
								global2.data[6]++;
							}
							else if (global2.data[6] > 900)
							{
								global2.data[6]--;
							}
							global2.party_ideology[2] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
							global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 666;
							global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 2000;
						}
						else if (global2.politics[num63].traits[0] == 2)
						{
							empire = global2.empires[1];
							empire.relations -= 3;
							empire = global2.empires[0];
							empire.relations += 5;
							if (global2.data[6] < 300)
							{
								global2.data[6]++;
							}
							else if (global2.data[6] > 700)
							{
								global2.data[6] -= 2;
							}
							else if (global2.data[6] > 500)
							{
								global2.data[6]--;
							}
							global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 666;
							global2.party_ideology[4] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 666;
						}
						else if (global2.politics[num63].traits[0] == 3)
						{
							empire = global2.empires[1];
							empire.relations -= 10;
							empire = global2.empires[0];
							empire.relations += 12;
							if (global2.data[6] > 700)
							{
								global2.data[6] -= 3;
							}
							else if (global2.data[6] > 500)
							{
								global2.data[6] -= 2;
							}
							else if (global2.data[6] > 300)
							{
								global2.data[6]--;
							}
							global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 666;
							global2.party_ideology[4] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 666;
						}
						if (global2.politics[num63].traits[1] == 4)
						{
							empire = global2.empires[1];
							empire.relations -= 3;
							empire = global2.empires[0];
							empire.relations -= 3;
						}
						else if (global2.politics[num63].traits[1] == 5)
						{
							empire = global2.empires[1];
							empire.relations += 5;
							empire = global2.empires[0];
							empire.relations += 5;
							if (global2.data[6] < 700)
							{
								global2.data[6]++;
							}
							else if (global2.data[6] > 700)
							{
								global2.data[6]--;
							}
						}
						else if (global2.politics[num63].traits[1] == 6)
						{
							empire = global2.empires[1];
							empire.relations += 6;
							empire = global2.empires[0];
							empire.relations += 6;
							if (global2.data[6] > 600)
							{
								global2.data[6]--;
							}
						}
						else if (global2.politics[num63].traits[1] == 7)
						{
							global2.data[11] += 2;
						}
						if (global2.politics[num63].traits[2] == 7)
						{
							global2.data[11] += 2;
						}
						else if (global2.politics[num63].traits[2] == 8)
						{
							empire = global2.empires[1];
							empire.relations -= 3;
							empire = global2.empires[0];
							empire.relations -= 3;
							if (global2.data[6] < 500)
							{
								global2.data[6] += 2;
							}
							else if (global2.data[6] < 700)
							{
								global2.data[6]++;
							}
						}
						else if (global2.politics[num63].traits[2] == 9)
						{
							empire = global2.empires[1];
							empire.relations += 4;
							empire = global2.empires[0];
							empire.relations += 4;
							if (global2.data[6] > 700)
							{
								global2.data[6]--;
							}
						}
						else if (global2.politics[num63].traits[2] == 10)
						{
							empire = global2.empires[1];
							empire.relations -= 3;
							empire = global2.empires[0];
							empire.relations -= 3;
							global2.data[6]++;
						}
						else if (global2.politics[num63].traits[2] == 11)
						{
							global2.data[8]++;
							empire = global2.empires[1];
							empire.relations--;
							empire = global2.empires[0];
							empire.relations--;
						}
						else if (global2.politics[num63].traits[2] == 12)
						{
							empire = global2.empires[1];
							empire.relations--;
							empire = global2.empires[0];
							empire.relations--;
							global2.data[6]++;
						}
						else if (global2.politics[num63].traits[2] == 13)
						{
							global2.data[1] += 3;
						}
						else if (global2.politics[num63].traits[2] == 14)
						{
							empire = global2.empires[1];
							empire.relations -= 3;
							empire = global2.empires[0];
							empire.relations -= 3;
							if (global2.data[6] < 500)
							{
								global2.data[6] += 2;
							}
							else if (global2.data[6] < 800)
							{
								global2.data[6]++;
							}
							else if (global2.data[6] > 900)
							{
								global2.data[6]--;
							}
						}
						else if (global2.politics[num63].traits[2] == 15)
						{
							empire = global2.empires[1];
							empire.relations -= 6;
							empire = global2.empires[0];
							empire.relations += 6;
							global2.data[6]--;
						}
						else if (global2.politics[num63].traits[2] == 16)
						{
							empire = global2.empires[1];
							empire.relations += 4;
							empire = global2.empires[0];
							empire.relations += 4;
						}
						else if (global2.politics[num63].traits[2] == 17)
						{
							global2.data[4]++;
						}
						else if (global2.politics[num63].traits[2] == 18)
						{
							global2.data[8]--;
						}
						else if (global2.politics[num63].traits[2] == 19)
						{
							empire = global2.empires[0];
							empire.relations -= 2;
							empire = global2.empires[1];
							empire.relations -= 2;
						}
					}
					if (global2.politics_dolshnost[1] == num63)
					{
						if (global2.politics[num63].traits[0] == 0)
						{
							global2.data[5] += 6;
							empire = global2.empires[1];
							empire.relations += 3;
							if (global2.data[56] != 0)
							{
								global2.data[1] -= 3;
							}
							global2.data[1] -= 3;
							global2.data[68]--;
							global2.party_ideology[0] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
							global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 500;
						}
						else if (global2.politics[num63].traits[0] == 20)
						{
							global2.data[5] += 4;
							global2.data[4]++;
							empire = global2.empires[1];
							empire.relations += 5;
							if (global2.data[56] != 1)
							{
								global2.data[1]--;
							}
							global2.data[1] += 5;
							global2.party_ideology[2] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 2000;
							global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
						}
						else if (global2.politics[num63].traits[0] == 1)
						{
							global2.data[5] += 2;
							global2.data[4] += 3;
							if (global2.data[56] != 2)
							{
								global2.data[1]--;
							}
							global2.data[1] += 5;
							global2.party_ideology[2] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
							global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
							global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 2000;
						}
						else if (global2.politics[num63].traits[0] == 2)
						{
							global2.data[5] -= 3;
							global2.data[4] += 5;
							if (global2.data[56] != 3)
							{
								global2.data[1]--;
							}
							global2.data[1] += 7;
							global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
							global2.party_ideology[4] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
						}
						else if (global2.politics[num63].traits[0] == 3)
						{
							global2.data[5] -= 7;
							global2.data[4] += 5;
							if (global2.data[56] != 4)
							{
								global2.data[1]--;
							}
							global2.data[1] += 5;
							global2.data[8] += 2;
							global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
							global2.party_ideology[4] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
						}
						if (global2.politics[num63].traits[1] == 4)
						{
							global2.data[26]--;
							global2.data[4] -= 7;
							global2.data[1] -= 3;
						}
						else if (global2.politics[num63].traits[1] == 5)
						{
							global2.data[1] += 3;
						}
						else if (global2.politics[num63].traits[1] == 6)
						{
							global2.data[26]++;
							global2.data[4] += 7;
							global2.data[1] += 7;
						}
						else if (global2.politics[num63].traits[1] == 7)
						{
							global2.data[11] += 3;
						}
						if (global2.politics[num63].traits[2] == 7)
						{
							global2.data[11] += 3;
						}
						else if (global2.politics[num63].traits[2] == 8)
						{
							global2.data[4] -= 15;
							global2.data[1] -= 7;
						}
						else if (global2.politics[num63].traits[2] == 9)
						{
							global2.data[4] += 2;
							global2.data[1] += 3;
						}
						else if (global2.politics[num63].traits[2] == 10)
						{
							global2.data[1] -= 3;
						}
						else if (global2.politics[num63].traits[2] == 11)
						{
							global2.data[8]++;
						}
						else if (global2.politics[num63].traits[2] == 12)
						{
							global2.data[4] += 3;
							global2.data[1] -= 7;
						}
						else if (global2.politics[num63].traits[2] == 13)
						{
							global2.data[1] += 7;
						}
						else if (global2.politics[num63].traits[2] == 14)
						{
							global2.data[4] += 3;
							global2.data[31] += 7;
						}
						else if (global2.politics[num63].traits[2] == 15)
						{
							global2.data[4] += 3;
							global2.data[31] -= 7;
						}
						else if (global2.politics[num63].traits[2] == 16)
						{
							global2.data[1] += 3;
						}
						else if (global2.politics[num63].traits[2] == 17)
						{
							global2.data[4] += 2;
						}
						else if (global2.politics[num63].traits[2] == 18)
						{
							global2.data[26] += 3;
							global2.data[1] += 7;
							global2.data[8]--;
						}
						else if (global2.politics[num63].traits[2] == 19)
						{
							global2.data[1]++;
							global2.data[22]--;
						}
					}
					if (global2.politics_dolshnost[0] != num63)
					{
						continue;
					}
					if (global2.politics[num63].traits[0] == 0)
					{
						global2.data[5] += 6;
						empire = global2.empires[1];
						empire.relations += 4;
						if (global2.data[56] != 0)
						{
							global2.data[1] -= 3;
						}
						global2.data[1] -= 3;
						global2.data[68]--;
						global2.party_ideology[0] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
						global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 500;
					}
					else if (global2.politics[num63].traits[0] == 20)
					{
						global2.data[5] += 4;
						global2.data[4] += 2;
						empire = global2.empires[1];
						empire.relations += 7;
						if (global2.data[56] != 1)
						{
							global2.data[1]--;
						}
						global2.data[1]++;
						global2.party_ideology[2] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 1000;
						global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
					}
					else if (global2.politics[num63].traits[0] == 1)
					{
						global2.data[5] += 2;
						global2.data[4] += 5;
						if (global2.data[56] != 2)
						{
							global2.data[1]--;
						}
						global2.data[1] += 5;
						global2.party_ideology[2] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
						global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
						global2.party_ideology[1] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 1000;
					}
					else if (global2.politics[num63].traits[0] == 2)
					{
						global2.data[5] -= 5;
						global2.data[4] += 5;
						if (global2.data[56] != 3)
						{
							global2.data[1]--;
						}
						global2.data[1] += 10;
						global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
						global2.party_ideology[4] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
					}
					else if (global2.politics[num63].traits[0] == 3)
					{
						global2.data[5] -= 10;
						global2.data[4] += 15;
						if (global2.data[56] != 4)
						{
							global2.data[1] -= 2;
						}
						global2.data[1] += 20;
						global2.data[8] += 3;
						global2.party_ideology[3] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 333;
						global2.party_ideology[4] += (global2.party_ideology[0] + global2.party_ideology[1] + global2.party_ideology[2] + global2.party_ideology[3] + global2.party_ideology[4]) / 222;
					}
					if (global2.politics[num63].traits[1] == 4)
					{
						global2.data[26]--;
						global2.data[4] -= 10;
						global2.data[1] -= 5;
					}
					else if (global2.politics[num63].traits[1] == 5)
					{
						global2.data[1] += 5;
					}
					else if (global2.politics[num63].traits[1] == 6)
					{
						global2.data[26]++;
						global2.data[4] += 10;
						global2.data[1] += 10;
					}
					else if (global2.politics[num63].traits[1] == 7)
					{
						global2.data[11] += 5;
					}
					if (global2.politics[num63].traits[2] == 7)
					{
						global2.data[11] += 5;
					}
					else if (global2.politics[num63].traits[2] == 8)
					{
						global2.data[4] -= 15;
						global2.data[1] -= 10;
					}
					else if (global2.politics[num63].traits[2] == 9)
					{
						global2.data[4] += 3;
						global2.data[1] += 5;
					}
					else if (global2.politics[num63].traits[2] == 10)
					{
						global2.data[1] -= 5;
					}
					else if (global2.politics[num63].traits[2] == 11)
					{
						global2.data[8]++;
					}
					else if (global2.politics[num63].traits[2] == 12)
					{
						global2.data[4] += 5;
						global2.data[1] -= 10;
					}
					else if (global2.politics[num63].traits[2] == 13)
					{
						global2.data[1] += 10;
					}
					else if (global2.politics[num63].traits[2] == 14)
					{
						global2.data[4] += 5;
						global2.data[31] += 10;
					}
					else if (global2.politics[num63].traits[2] == 15)
					{
						global2.data[4] += 5;
						global2.data[31] -= 10;
					}
					else if (global2.politics[num63].traits[2] == 16)
					{
						global2.data[1] += 5;
					}
					else if (global2.politics[num63].traits[2] == 17)
					{
						global2.data[4] += 3;
					}
					else if (global2.politics[num63].traits[2] == 18)
					{
						global2.data[26] += 5;
						global2.data[1] += 10;
						global2.data[8]--;
					}
					else if (global2.politics[num63].traits[2] == 19)
					{
						global2.data[4] += 2;
						global2.data[1] += 2;
						global2.data[22]--;
						empire = global2.empires[0];
						empire.relations--;
						empire = global2.empires[1];
						empire.relations--;
						global2.data[8]--;
					}
					if (global2.politics[num63].traits[0] == 0)
					{
						empire = global2.empires[1];
						empire.relations -= 2;
						empire = global2.empires[0];
						empire.relations -= 4;
					}
					else if (global2.politics[num63].traits[0] == 20)
					{
						empire = global2.empires[1];
						empire.relations += 4;
						empire = global2.empires[0];
						empire.relations -= 2;
					}
					else if (global2.politics[num63].traits[0] == 1)
					{
						empire = global2.empires[1];
						empire.relations += 6;
						empire = global2.empires[0];
						empire.relations -= 3;
					}
					else if (global2.politics[num63].traits[0] == 2)
					{
						empire = global2.empires[1];
						empire.relations -= 3;
						empire = global2.empires[0];
						empire.relations += 5;
						global2.data[6]--;
					}
					else if (global2.politics[num63].traits[0] == 3)
					{
						empire = global2.empires[1];
						empire.relations -= 10;
						empire = global2.empires[0];
						empire.relations += 12;
						global2.data[6]--;
					}
					if (global2.politics[num63].traits[1] == 4)
					{
						empire = global2.empires[1];
						empire.relations -= 3;
						empire = global2.empires[0];
						empire.relations -= 3;
					}
					else if (global2.politics[num63].traits[1] == 5)
					{
						empire = global2.empires[1];
						empire.relations += 5;
						empire = global2.empires[0];
						empire.relations += 5;
					}
					else if (global2.politics[num63].traits[1] == 6)
					{
						empire = global2.empires[1];
						empire.relations += 6;
						empire = global2.empires[0];
						empire.relations += 6;
						if (global2.data[6] > 600)
						{
							global2.data[6]--;
						}
					}
					else if (global2.politics[num63].traits[1] == 7)
					{
						global2.data[11] += 2;
					}
					if (global2.politics[num63].traits[2] == 7)
					{
						global2.data[11] += 2;
					}
					else if (global2.politics[num63].traits[2] == 8)
					{
						empire = global2.empires[1];
						empire.relations -= 3;
						empire = global2.empires[0];
						empire.relations -= 3;
						global2.data[6] += global2.data[6] / 166;
					}
					else if (global2.politics[num63].traits[2] == 9)
					{
						empire = global2.empires[1];
						empire.relations += 4;
						empire = global2.empires[0];
						empire.relations += 4;
					}
					else if (global2.politics[num63].traits[2] == 10)
					{
						empire = global2.empires[1];
						empire.relations -= 3;
						empire = global2.empires[0];
						empire.relations -= 3;
					}
					else if (global2.politics[num63].traits[2] == 11)
					{
						global2.data[8]++;
						empire = global2.empires[1];
						empire.relations--;
						empire = global2.empires[0];
						empire.relations--;
					}
					else if (global2.politics[num63].traits[2] == 12)
					{
						empire = global2.empires[1];
						empire.relations--;
						empire = global2.empires[0];
						empire.relations--;
					}
					else if (global2.politics[num63].traits[2] == 13)
					{
						global2.data[1] += 3;
					}
					else if (global2.politics[num63].traits[2] == 14)
					{
						empire = global2.empires[1];
						empire.relations -= 3;
						empire = global2.empires[0];
						empire.relations -= 3;
						global2.data[6] += global2.data[6] / 200;
					}
					else if (global2.politics[num63].traits[2] == 15)
					{
						empire = global2.empires[1];
						empire.relations -= 6;
						empire = global2.empires[0];
						empire.relations += 6;
						global2.data[6] -= global2.data[6] / 166;
					}
					else if (global2.politics[num63].traits[2] == 16)
					{
						empire = global2.empires[1];
						empire.relations += 4;
						empire = global2.empires[0];
						empire.relations += 4;
					}
					else if (global2.politics[num63].traits[2] == 17)
					{
						global2.data[4] += 3;
					}
					else if (global2.politics[num63].traits[2] == 18)
					{
						global2.data[26]++;
						global2.data[8]--;
					}
					else if (global2.politics[num63].traits[2] == 19)
					{
						empire = global2.empires[0];
						empire.relations -= 2;
						empire = global2.empires[1];
						empire.relations -= 2;
					}
					if (global2.politics[num63].traits[0] == 0)
					{
						global2.data[5]--;
						empire = global2.empires[1];
						empire.relations -= 2;
						if (global2.data[56] != 0)
						{
							global2.data[1] -= 3;
						}
						global2.data[68]--;
						global2.data[26]--;
					}
					else if (global2.politics[num63].traits[0] == 20)
					{
						global2.data[4]++;
						if (global2.data[56] != 1)
						{
							global2.data[1]--;
						}
						global2.data[1]++;
					}
					else if (global2.politics[num63].traits[0] == 1)
					{
						global2.data[5]++;
						global2.data[4] += 2;
						if (global2.data[56] != 2)
						{
							global2.data[1]--;
						}
						global2.data[1] += 2;
					}
					else if (global2.politics[num63].traits[0] == 2)
					{
						global2.data[5] -= 2;
						global2.data[4] += 3;
						if (global2.data[56] != 3)
						{
							global2.data[1]--;
						}
						global2.data[1] += 5;
					}
					else if (global2.politics[num63].traits[0] == 3)
					{
						global2.data[5] -= 5;
						global2.data[4] += 7;
						if (global2.data[56] != 4)
						{
							global2.data[1]--;
						}
						global2.data[1] += 10;
						global2.data[8]++;
					}
					if (global2.politics[num63].traits[1] == 4)
					{
						global2.data[26]--;
						global2.data[4] -= 5;
						global2.data[1] -= 2;
					}
					else if (global2.politics[num63].traits[1] == 5)
					{
						global2.data[1] += 2;
					}
					else if (global2.politics[num63].traits[1] == 6)
					{
						global2.data[26]++;
						global2.data[4] += 5;
						global2.data[1] += 5;
					}
					else if (global2.politics[num63].traits[1] == 7)
					{
						global2.data[11] += 2;
					}
					if (global2.politics[num63].traits[2] == 7)
					{
						global2.data[11] += 2;
					}
					else if (global2.politics[num63].traits[2] == 8)
					{
						global2.data[4] -= 10;
						global2.data[1] -= 5;
					}
					else if (global2.politics[num63].traits[2] == 9)
					{
						global2.data[4] += 2;
						global2.data[1] += 2;
					}
					else if (global2.politics[num63].traits[2] == 10)
					{
						global2.data[1] -= 2;
					}
					else if (global2.politics[num63].traits[2] == 11)
					{
						global2.data[8]++;
					}
					else if (global2.politics[num63].traits[2] == 12)
					{
						global2.data[4] += 3;
						global2.data[1] -= 5;
					}
					else if (global2.politics[num63].traits[2] == 13)
					{
						global2.data[1] += 5;
					}
					else if (global2.politics[num63].traits[2] == 14)
					{
						global2.data[4] += 3;
						global2.data[31] += 5;
					}
					else if (global2.politics[num63].traits[2] == 15)
					{
						global2.data[4] += 5;
						global2.data[31] -= 5;
					}
					else if (global2.politics[num63].traits[2] == 16)
					{
						global2.data[1] += 2;
					}
					else if (global2.politics[num63].traits[2] == 17)
					{
						global2.data[4] += 2;
					}
					else if (global2.politics[num63].traits[2] == 18)
					{
						global2.data[26] += 2;
						global2.data[1] += 5;
						global2.data[8]--;
					}
					else if (global2.politics[num63].traits[2] == 19)
					{
						global2.data[4] += 2;
					}
				}
				if (global2.science[0])
				{
					global2.data[5] += 2;
					global2.data[13]++;
				}
				if (global2.science[1])
				{
					global2.data[13] += 2;
				}
				if (global2.science[2])
				{
					global2.data[5]++;
					global2.data[13]++;
					global2.data[8]++;
				}
				if (global2.science[3])
				{
					global2.data[5] += 2;
					global2.data[13]++;
				}
				if (global2.science[4])
				{
					global2.data[5] += 4;
					global2.data[13] += 5;
				}
				if (global2.science[5])
				{
					global2.data[5] += 2;
					global2.data[11] += 10;
				}
				if (global2.science[6])
				{
					global2.data[5] += 2;
					global2.data[13]++;
				}
				if (global2.science[7])
				{
					global2.data[5] += 2;
					global2.data[8]++;
				}
				if (global2.science[8])
				{
					global2.data[13] += 2;
				}
				if (global2.science[9])
				{
					global2.data[8]++;
					global2.data[12] += 2;
				}
				if (global2.science[10])
				{
					global2.data[8]++;
					global2.data[22] += 4;
					global2.data[12] += 2;
				}
				if (global2.science[11])
				{
					global2.data[5] += 2;
				}
				if (global2.science[12])
				{
					global2.data[8] += 2;
					global2.data[12]++;
				}
				if (global2.science[13])
				{
					global2.data[5] += 3;
				}
				if (global2.science[14])
				{
					global2.data[5] += 2;
					global2.data[8]++;
					global2.data[12] += 2;
				}
				if (global2.science[15])
				{
					global2.data[5] += 2;
					global2.data[8] += 2;
					global2.data[12]++;
					global2.data[13]++;
				}
				if (global2.science[16])
				{
					global2.data[8] += 2;
					global2.data[5] += 3;
					global2.data[11] += 5;
					global2.data[57] += 4;
				}
				if (global2.science[17])
				{
					global2.data[5] += 3;
					global2.data[8] += 3;
				}
				if (global2.science[18])
				{
					global2.data[22] += 2;
				}
				if (global2.science[19])
				{
					global2.data[9] += 3;
					global2.data[4] -= 3;
				}
				if (global2.science[20])
				{
					global2.data[9] += 2;
					global2.data[4] -= 2;
					global2.data[3] += 2;
				}
				if (global2.science[21])
				{
					global2.data[22] += 2;
					global2.data[1] += 3;
					global2.data[3]++;
				}
				if (global2.science[22])
				{
					global2.data[3] += 2;
					global2.data[4] -= 2;
					global2.data[1] += 2;
				}
				if (global2.science[23])
				{
					global2.data[22] += 4;
				}
				if (global2.science[24])
				{
					global2.data[22] += 4;
					global2.data[3] += 2;
				}
				if (global2.science[25])
				{
					global2.data[9] += 2;
					global2.data[4] -= 2;
					global2.data[1] += 3;
				}
				if (global2.science[26])
				{
					global2.data[22] += 4;
					global2.data[4] -= 2;
				}
				if (global2.science[27])
				{
					global2.data[8] += 2;
					global2.data[5] += 2;
					global2.data[3] += 2;
				}
				if (global2.science[28])
				{
					global2.data[22] += 5;
					global2.data[9] += 5;
				}
				if (global2.science[29])
				{
					global2.data[22] += 10;
					empire = global2.empires[0];
					empire.relations -= 5;
					empire = global2.empires[1];
					empire.relations -= 5;
				}
				if (global2.science[30])
				{
					global2.data[3] += 3;
					empire = global2.empires[0];
					empire.power--;
					empire = global2.empires[1];
					empire.relations--;
				}
				if (global2.science[31])
				{
					global2.data[22] += 5;
					global2.data[11] += 5;
				}
				if (global2.science[32])
				{
					global2.data[13] += 5;
					global2.data[5] += 5;
				}
				if (global2.science[33])
				{
					global2.data[22] += 5;
					global2.data[12] += 5;
					empire = global2.empires[0];
					empire.relations -= 5;
					empire = global2.empires[1];
					empire.relations -= 5;
				}
				InfluenceFromInvestments();
				MutualRelationsChange();
				if (global2.data[5] < 200)
				{
					global2.modifies[4].active = true;
					global2.data[4] += 2;
					global2.data[57] -= 3;
					global2.data[12] -= (250 - global2.data[5]) / 40;
				}
				else if (global2.data[5] < (global2.data[16] - 10) * 100 && global2.data[16] > 12)
				{
					global2.modifies[4].active = true;
					global2.data[12] -= ((global2.data[16] - 10) * 100 - global2.data[5]) / 40;
					global2.data[26]++;
					global2.data[57] -= 3;
				}
				else
				{
					global2.modifies[4].active = false;
				}
				if (global2.data[16] <= 11)
				{
					if (global2.data[21] < 1980)
					{
						global2.data[4] += (1000 - global2.data[5]) / 50;
					}
					else
					{
						global2.data[4] += (1000 - global2.data[5]) / 40;
					}
				}
				else if (global2.data[16] == 12)
				{
					if (global2.data[21] < 1980)
					{
						global2.data[4] += (1000 - global2.data[5]) / 70;
					}
					else
					{
						global2.data[4] += (1000 - global2.data[5]) / 60;
					}
				}
				if (global2.data[12] < 250)
				{
					global2.data[12] -= 2;
					global2.data[1] -= 10;
					global2.data[5] -= 5;
					global2.data[22] -= 5;
				}
				else if (global2.data[12] < 410)
				{
					global2.data[12] -= 3;
					global2.data[1] -= 5;
					global2.data[5] -= 2;
					global2.data[22] -= 2;
				}
				else if (global2.data[12] < 610)
				{
					global2.data[12] -= 8;
					global2.data[1]--;
				}
				else if (global2.data[12] < 710)
				{
					global2.data[12] -= 18;
				}
				else if (global2.data[12] < 810)
				{
					global2.data[12] -= 25;
				}
				else if (global2.data[12] < 1100)
				{
					global2.data[12] -= 40;
					global2.data[9] += 5;
				}
				else
				{
					global2.data[12] -= 80;
					global2.data[9] += 10;
				}
				if (global2.data[16] < 13)
				{
					if (global2.data[13] < 300)
					{
						global2.data[12] -= 4;
					}
					else if (global2.data[13] < 500)
					{
						global2.data[12] -= 2;
					}
				}
				global2.data[8] += global2.data[12] / 50;
				if (global2.data[68] < 250)
				{
					global2.data[68]--;
					global2.data[1] -= 10;
					global2.data[5] -= 5;
				}
				else if (global2.data[68] < 410)
				{
					global2.data[68] -= 3;
					global2.data[1] -= 5;
					global2.data[5] -= 2;
				}
				else if (global2.data[68] < 610)
				{
					global2.data[68] -= 8;
					global2.data[1]--;
				}
				else if (global2.data[68] < 710)
				{
					global2.data[68] -= 18;
				}
				else if (global2.data[68] < 810)
				{
					global2.data[68] -= 25;
				}
				else if (global2.data[68] < 1100)
				{
					global2.data[68] -= 40;
					global2.data[5] += 5;
				}
				else
				{
					global2.data[68] -= 80;
					global2.data[5] += 10;
				}
				if (global2.data[16] < 13)
				{
					if (global2.data[13] < 300)
					{
						global2.data[68] -= 5;
					}
					else if (global2.data[13] < 500)
					{
						global2.data[68] -= 2;
					}
				}
				global2.data[8] += global2.data[68] / 50;
				if (global2.data[13] < 250)
				{
					global2.data[13] -= 2;
					global2.data[1] -= 10;
					global2.data[5] -= 5;
				}
				else if (global2.data[13] < 410)
				{
					global2.data[13] -= 5;
					global2.data[1] -= 5;
					global2.data[5] -= 2;
				}
				else if (global2.data[13] < 610)
				{
					global2.data[13] -= 9;
					global2.data[1]--;
				}
				else if (global2.data[13] < 710)
				{
					global2.data[13] -= 19;
				}
				else if (global2.data[13] < 810)
				{
					global2.data[13] -= 26;
				}
				else if (global2.data[13] < 1100)
				{
					global2.data[13] -= 40;
					global2.data[22] += 5;
				}
				else
				{
					global2.data[13] -= 80;
					global2.data[22] += 10;
				}
				global2.data[8] += global2.data[13] / 100;
				if (global2.empires[0].now_leader != 3 || (global2.empires[0].now_leader == 3 && global2.data[20] % 2 == 0))
				{
					if (global2.data[69] / 40 <= 0 && global2.data[69] > 0)
					{
						global2.data[8]--;
						if (global2.data[21] >= 1983)
						{
							global2.data[8] -= 2;
						}
						else if (global2.data[21] >= 1980)
						{
							global2.data[8]--;
						}
						if (global2.data[69] > 10)
						{
							global2.data[69]--;
						}
						if (global2.allcountries[1].isSEV)
						{
							empire = global2.empires[1];
							empire.relations -= 2;
						}
					}
					else if (global2.data[69] > 0)
					{
						global2.data[8] -= global2.data[69] / 40;
						if (global2.data[21] >= 1983)
						{
							global2.data[8]--;
						}
						else if (global2.data[21] >= 1983)
						{
							global2.data[8] -= 2;
						}
						if (global2.allcountries[1].isSEV)
						{
							empire = global2.empires[1];
							empire.relations -= global2.data[69] / 20;
						}
						if (global2.data[69] > 10)
						{
							global2.data[69] -= global2.data[69] / 40 / 2 + 1;
						}
					}
				}
				else if (global2.empires[0].now_leader == 3)
				{
					if (global2.data[69] / 40 <= 0 && global2.data[69] > 0)
					{
						if (global2.data[69] > 10)
						{
							global2.data[69]--;
						}
						if (global2.allcountries[1].isSEV)
						{
							empire = global2.empires[1];
							empire.relations -= 2;
						}
					}
					else if (global2.data[69] > 0)
					{
						if (global2.allcountries[1].isSEV)
						{
							empire = global2.empires[1];
							empire.relations -= global2.data[69] / 20;
						}
						if (global2.data[69] > 10)
						{
							global2.data[69] -= global2.data[69] / 40 / 2 + 1;
						}
					}
				}
				bool flag4 = false;
				for (int num64 = 0; num64 < global2.science_in_progress.Length; num64++)
				{
					if (global2.science_in_progress[num64] && global2.science_time[num64] < global2.science_need_time[num64] && !global2.science[num64])
					{
						flag4 = true;
						if (global2.science_time[num64] + global2.data[11] <= global2.science_need_time[num64])
						{
							global2.science_time[num64] += global2.data[11];
							global2.data[11] = 0;
						}
						else
						{
							global2.science_time[num64] += global2.science_need_time[num64] - global2.science_time[num64];
							global2.data[11] -= global2.science_need_time[num64] - global2.science_time[num64];
						}
					}
					else if (global2.science_time[num64] >= global2.science_need_time[num64] && global2.science_in_progress[num64] && !global2.science[num64])
					{
						global2.science_in_progress[num64] = false;
						global2.science[num64] = true;
						switch (num64)
						{
						case 0:
							global2.data[24] -= 15;
							break;
						case 1:
							global2.data[24] -= 10;
							break;
						case 2:
						{
							GameState gameState = global2;
							gameState.influencePRC += 10;
							break;
						}
						case 3:
							global2.data[24] -= 15;
							GlobalScript.inst.old_modify_desc[15] += "<color=red>| 农 业 机 械 化 ：</color>| 农 业+0.6 ， 工 业+0.4";
							break;
						case 4:
							global2.data[24] -= 10;
							break;
						case 6:
							GlobalScript.inst.old_modify_desc[15] += "<color=red>| 普 及 化 肥 与 杀 虫 剂 ：</color>| 农 业+0.3 ， 生 活 水 平+0.4";
							break;
						case 7:
							global2.data[24] -= 10;
							GlobalScript.inst.old_modify_desc[15] += "<color=red>| 转 基 因 技 术 ：</color>| 农 业+0.2 ， 工 业+0.2 ， 生 活 水 平+0.5 ， 预 算+0.2";
							break;
						case 10:
						{
							global2.data[24] -= 10;
							GameState gameState = global2;
							gameState.influencePRC += 5;
							break;
						}
						case 12:
							global2.data[24] -= 10;
							break;
						case 13:
							global2.data[24] -= 10;
							break;
						case 14:
							global2.data[24] -= 10;
							break;
						case 23:
						{
							GameState gameState = global2;
							gameState.influencePRC += 5;
							break;
						}
						case 28:
							global2.data[24] -= 10;
							break;
						case 30:
						{
							GameState gameState = global2;
							gameState.influencePRC += 10;
							break;
						}
						case 31:
						{
							GameState gameState = global2;
							gameState.influencePRC += 5;
							break;
						}
						case 32:
						{
							GameState gameState = global2;
							gameState.influencePRC += 5;
							break;
						}
						case 33:
						{
							GameState gameState = global2;
							gameState.influencePRC += 10;
							break;
						}
						}
					}
					else if (global2.science_time[num64] < global2.science_need_time[num64] && global2.science[num64])
					{
						global2.science_time[num64] = global2.science_need_time[num64];
					}
				}
				if (!flag4)
				{
					alarmIcons[0].SetActive(value: true);
					global2.leader.is_sleshka = true;
				}
				else
				{
					alarmIcons[0].SetActive(value: false);
					global2.leader.is_sleshka = false;
				}
				bool flag5 = true;
				for (int num65 = 0; num65 < GlobalScript.inst.gameState.science.Length; num65++)
				{
					if (!GlobalScript.inst.gameState.science[num65])
					{
						flag5 = false;
					}
				}
				if (flag5)
				{
					alarmIcons[0].SetActive(value: false);
					global2.leader.is_sleshka = false;
				}
				if (global2.data[11] > 300 && !flag4)
				{
					global2.data[11] = 300;
				}
				if (global2.diff == 0)
				{
					global2.data[1] += 5;
					global2.data[3] += 5;
					global2.data[4] -= 5;
					global2.data[5] += 5;
					global2.data[8] += 50;
					global2.data[9] += 50;
					if (global2.data[26] > 200)
					{
						global2.data[26] -= 30;
					}
					else if (global2.data[26] > 100)
					{
						global2.data[26] -= 20;
					}
					else
					{
						global2.data[26] -= 10;
					}
				}
				else if (global2.diff == 1)
				{
					global2.data[1] += 3;
					global2.data[3] += 3;
					global2.data[4] -= 3;
					global2.data[5] += 3;
					global2.data[8] += 3;
					global2.data[9] += 3;
				}
				else if (global2.diff == 2)
				{
					if (global2.data[26] < 50)
					{
						global2.data[26] += 8;
					}
					else if (global2.data[26] < 100)
					{
						global2.data[26] += 5;
					}
				}
				else if (global2.diff == 3)
				{
					global2.data[1] -= 6;
					global2.data[3] -= 7;
					global2.data[4] += 7;
					global2.data[5] -= 7;
					global2.data[8] -= 7;
					global2.data[9] -= 7;
					if (global2.data[26] < 50)
					{
						global2.data[26] += 10;
					}
					else if (global2.data[26] < 100)
					{
						global2.data[26] += 6;
					}
					else
					{
						global2.data[26]++;
					}
				}
				else if (global2.diff == 4)
				{
					global2.data[1] -= global2.data[14] * 3;
					global2.data[3] -= global2.data[14] * 3;
					empire = global2.empires[0];
					empire.relations -= 5;
					empire = global2.empires[1];
					empire.relations -= 5;
					if (global2.data[38] == 100)
					{
						for (int num66 = 0; num66 < global2.politics.Length; num66++)
						{
							if (global2.politics[num66].traits[0] == 0)
							{
								Politic politic2 = global2.politics[num66];
								politic2.power += 50;
							}
							else
							{
								Politic politic2 = global2.politics[num66];
								politic2.loyality -= 10;
							}
						}
					}
				}
				if (global2.data[31] >= 700)
				{
					global2.data[31] -= array5[31] / 40;
				}
				if (global2.data[57] >= 700)
				{
					global2.data[57] -= array5[57] / 40;
				}
				for (int num67 = 0; num67 < global2.politics_dolshnost.Length; num67++)
				{
					if (global2.politics_dolshnost[num67] == 200)
					{
						global2.data[1] -= 5;
						global2.data[4] += 5;
						global2.data[8]--;
						global2.data[9] -= 5;
					}
				}
				DeathPolitics();
				PlotPolitics();
				PlotPlayer();
				ModifiesInfuence.ModifiesChanges(ch_support, ch_lib);
				if (global2.data[8] - ch_profit > 50)
				{
					if (global2.data[8] - ch_profit > 50)
					{
						global2.data[8] -= (global2.data[8] - ch_profit) / 4;
					}
					else if (global2.data[8] - ch_profit > 75)
					{
						global2.data[8] -= (global2.data[8] - ch_profit) / 3;
					}
					else if (global2.data[8] - ch_profit > 100)
					{
						global2.data[8] -= (global2.data[8] - ch_profit) / 2;
					}
					global2.data[8] -= global2.data[8] / 20;
				}
				if (global2.data[16] == 13)
				{
					global2.data[8] += Mathf.RoundToInt((float)(global2.data[34] - 9037) / 3000f + 1f);
				}
				else if (global2.data[16] == 14)
				{
					global2.data[8] += Mathf.RoundToInt((float)(global2.data[34] - 9037) / 2000f + 1f);
				}
				else if (global2.data[16] == 15)
				{
					global2.data[8] += Mathf.RoundToInt((float)(global2.data[34] - 9037) / 1000f + 1f);
				}
				for (int num68 = 0; num68 < global2.data_old.Length; num68++)
				{
					if (num68 != 34)
					{
						global2.data_old[num68] = global2.data[num68] - array5[num68];
					}
				}
				global2.data_old[28] = global2.empires[0].relations - array5[28];
				global2.data_old[29] = global2.empires[1].relations - array5[29];
				global2.data_old[7] = global2.influencePRC - array5[7];
				GameState gameState2 = global2;
				List<byte> politics_to_generate = new List<byte>();
				gameState2.BalancePolitic(politics_to_generate);
			}
			if (global1.dlc[0])
			{
				FocusesResearching();
			}
			EventsRequirements();
			if (global2.iron_and_blood && global2.data[113] == 9 && global2.data[114] == 9 && global2.data[115] == 9 && global2.data[116] == 9)
			{
				achieves.GetComponent<achievements>().Set(28);
			}
			if (global2.leader.name_1 == 2 && global2.leader.name_2 == 2)
			{
				global2.checking[0] = true;
			}
			else if (global2.leader.name_1 == 13 && global2.leader.name_2 == 13)
			{
				global2.checking[1] = true;
			}
			else if (global2.leader.traits[0] == 1 && global2.leader.name_2 == 16)
			{
				global2.checking[2] = true;
			}
			else if (global2.leader.traits[0] == 3)
			{
				global2.checking[4] = true;
			}
			else if (global2.event_done[124])
			{
				global2.checking[3] = true;
			}
			if (global2.event_done[92] && global2.data[21] == 1981 && global2.data[19] == 1 && global2.data[20] == 1)
			{
				global2.event_done[92] = false;
			}
			if (global2.data[103] != 15 && global2.data[21] == 1981 && global2.data[19] == UnityEngine.Random.Range(1, 30) && global2.data[20] == 11)
			{
				global2.data[103] = 15;
				global2.allcountries[61].dev = 100;
				global2.allcountries[61].prcpower = 0;
				global2.allcountries[61].sovpower = 0;
				global2.allcountries[61].usapower = 0;
				global2.allcountries[61].stab = 1000;
				global2.allcountries[61].Gosstroy = 0;
				global2.allcountries[61].SubGosstroy = 7;
			}
			if (global2.completedDecisions[12])
			{
				if (global2.data[108] > 70)
				{
					global2.data[108] = 70;
				}
				else if (global2.data[108] < 40)
				{
					global2.data[108] = 40;
				}
			}
			AlarmIconChange();
			BoundsOfVariables();
			for (int num69 = 0; num69 < re_war.Length; num69++)
			{
				re_war[num69].Repaint();
			}
			map1.UpdateMap();
			if (global1.autosavej > 0)
			{
				if (global1.autosavej == 1 && global2.data[19] == 1)
				{
					AutoSaveMethod();
				}
				else if (global1.autosavej == 2 && global2.data[19] == 1 && global2.data[20] % 6 == 0)
				{
					AutoSaveMethod();
				}
			}
		}
		GetComponent<TextMesh>().text = global2.data[19] + "." + global2.data[20] + "." + global2.data[21];
	}

	private void DaysInSouthAmerica()
	{
		for (int i = 71; i < 84; i++)
		{
			global2.WhatToDevelop(i);
			global2.WantToLeave(i);
			if (global2.data[20] == 6 || global2.data[20] == 12)
			{
				global2.AmericanHelp(i);
			}
		}
	}

	private void EmpireModifiesChanges(Empire empires, int num)
	{
		int[] modifies = empires.modifies;
		for (int i = 0; i < modifies.Length; i++)
		{
			switch (modifies[i])
			{
			case 0:
				empires.relations += 5;
				if (num == 1)
				{
					if (global2.empires[0].relations > 900 && empires.relations > 500)
					{
						empires.relations -= 30;
					}
					else if (global2.empires[0].relations > 800 && empires.relations > 400)
					{
						empires.relations -= 20;
					}
					else if (global2.empires[0].relations >= 750 && empires.relations > 300)
					{
						empires.relations -= 10;
					}
				}
				else if (global2.empires[1].relations > 800 && empires.relations > 500)
				{
					empires.relations -= 30;
				}
				else if (global2.empires[1].relations >= 750 && empires.relations > 350)
				{
					empires.relations -= 20;
				}
				else if (global2.empires[1].relations >= 750)
				{
					empires.relations -= 10;
				}
				break;
			case 2:
				empires.money += 5;
				empires.power++;
				break;
			case 7:
				empires.money += 20;
				break;
			}
		}
	}

	private void BoundsOfVariables()
	{
		if (global2.data[12] > 1500)
		{
			global2.data[12] = 1500;
		}
		if (global2.data[13] > 1500)
		{
			global2.data[13] = 1500;
		}
		if (global2.data[68] > 1500)
		{
			global2.data[68] = 1500;
		}
		if (global2.data[3] > 1000)
		{
			global2.data[3] = 1000;
		}
		if (global2.data[4] > 1000)
		{
			global2.data[4] = 1000;
		}
		if (global2.data[1] > 1000)
		{
			global2.data[1] = 1000;
		}
		if (global2.empires[0].relations > 1000)
		{
			global2.empires[0].relations = 1000;
		}
		else if (global2.empires[0].relations < 0)
		{
			global2.empires[0].relations = 0;
		}
		if (global2.empires[1].relations > 1000)
		{
			global2.empires[1].relations = 1000;
		}
		else if (global2.empires[1].relations < 0)
		{
			global2.empires[1].relations = 0;
		}
		if (GlobalScript.inst.gameState.party_number[0] < 0)
		{
			GlobalScript.inst.gameState.party_number[0] = 0;
		}
		if (GlobalScript.inst.gameState.party_number[1] < 0)
		{
			GlobalScript.inst.gameState.party_number[1] = 0;
		}
		if (GlobalScript.inst.gameState.party_number[2] < 0)
		{
			GlobalScript.inst.gameState.party_number[2] = 0;
		}
		if (GlobalScript.inst.gameState.party_number[3] < 0)
		{
			GlobalScript.inst.gameState.party_number[3] = 0;
		}
		if (GlobalScript.inst.gameState.party_number[4] < 0)
		{
			GlobalScript.inst.gameState.party_number[4] = 0;
		}
		if (global2.data[4] < 0)
		{
			global2.data[4] = 0;
		}
		if (global2.data[26] < 0)
		{
			global2.data[26] = 0;
		}
		if (global2.data[5] < 0)
		{
			global2.data[5] = 0;
		}
		else if (global2.data[5] > 1500)
		{
			global2.data[5] = 1500;
		}
		if (global2.data[108] < 0)
		{
			global2.data[108] = 0;
		}
		else if (global2.data[108] > 100)
		{
			global2.data[108] = 100;
		}
		if (global2.data[6] < -50)
		{
			global2.data[6] = -50;
		}
		else if (global2.data[6] > 1100)
		{
			global2.data[6] = 1100;
		}
	}

	private void AfricanBotSupport()
	{
		for (int i = 53; i < 109; i++)
		{
			if ((i >= 69 && i <= 105) || global2.allcountries[i].africaOff)
			{
				continue;
			}
			if (global2.allcountries[i].proprc)
			{
				if (global2.allcountries[i].stab < 1000)
				{
					global2.allcountries[i].stab += ((!global2.science[32]) ? (global2.data[81] / 3) : (global2.data[81] / 2));
				}
				if (global2.allcountries[i].usapower > 0)
				{
					global2.allcountries[i].usapower -= ((!global2.science[32]) ? (global2.data[81] / 3) : (global2.data[81] / 2));
				}
				if (global2.allcountries[i].sovpower > 0)
				{
					global2.allcountries[i].sovpower -= ((!global2.science[32]) ? (global2.data[81] / 3) : (global2.data[81] / 2));
				}
				if (global2.data[22] > global2.empires[1].money && global2.allcountries[i].stab < 1000)
				{
					global2.allcountries[i].stab += 25;
				}
				if (global2.data[22] > global2.empires[0].money && global2.allcountries[i].stab < 1000)
				{
					global2.allcountries[i].stab += 25;
				}
			}
			else if (global2.data[81] < 50 && global2.allcountries[i].prcpower >= 500 && !global2.science[32])
			{
				global2.allcountries[i].prcpower -= 60 - global2.data[81];
			}
		}
		int[] array = new int[5];
		int[] array2 = new int[5];
		array[0] = 0;
		array[1] = 0;
		array[2] = 0;
		array[3] = 0;
		array[4] = 0;
		array2[0] = 0;
		array2[1] = 0;
		array2[2] = 0;
		array2[3] = 0;
		array2[4] = 0;
		int num = UnityEngine.Random.Range(53, 69);
		if (num - 53 < global2.allcountries.Length - num)
		{
			for (int num2 = global2.allcountries.Length - 1; num2 >= num; num2--)
			{
				if (!global2.allcountries[num2].africaOff && (global2.data[103] != 15 || num2 != 61) && num2 != 58 && num2 != 55 && num2 != 69 && num2 != 70 && (num2 != 54 || (GlobalScript.inst.gameState.event_done[463] && GlobalScript.inst.gameState.allcountries[num2].stab != 10)))
				{
					if (global2.allcountries[num2].prosov && array2[0] == 0 && global2.allcountries[num2].stab < 500)
					{
						array2[0] = num2;
					}
					else if (global2.allcountries[num2].prosov && array2[4] == 0 && global2.allcountries[num2].stab < 500)
					{
						array2[4] = num2;
					}
					else if (global2.allcountries[num2].Vyshi && array2[1] == 0 && global2.allcountries[num2].sovpower < 1000 - global2.empires[1].power / 2)
					{
						array2[1] = num2;
					}
					else if (global2.allcountries[num2].proprc && array2[2] == 0 && global2.allcountries[num2].sovpower < 1000 - global2.empires[1].power / 2)
					{
						array2[2] = num2;
					}
					else if (!global2.allcountries[num2].proprc && !global2.allcountries[num2].Vyshi && !global2.allcountries[num2].prosov && array2[3] == 0 && global2.allcountries[num2].sovpower < 1000 - global2.empires[1].power / 2)
					{
						array2[3] = num2;
					}
					else if (global2.allcountries[num2].Vyshi && array[0] == 0 && global2.allcountries[num2].stab < 500)
					{
						array[0] = num2;
					}
					else if (global2.allcountries[num2].Vyshi && array[4] == 0 && global2.allcountries[num2].stab < 500)
					{
						array[4] = num2;
					}
					else if (global2.allcountries[num2].prosov && array[1] == 0 && global2.allcountries[num2].usapower < 1000 - global2.empires[0].power / 2)
					{
						array[1] = num2;
					}
					else if (global2.allcountries[num2].proprc && array[2] == 0 && global2.allcountries[num2].usapower < 1000 - global2.empires[0].power / 2)
					{
						array[2] = num2;
					}
					else if (!global2.allcountries[num2].proprc && !global2.allcountries[num2].Vyshi && !global2.allcountries[num2].prosov && array[3] == 0 && global2.allcountries[num2].usapower < 1000 - global2.empires[0].power / 2)
					{
						array[3] = num2;
					}
				}
			}
		}
		else
		{
			for (int j = 53; j <= num; j++)
			{
				if ((global2.data[103] != 15 || j != 61) && j != 58 && j != 55 && j != 69 && j != 70 && !global2.allcountries[j].africaOff && (j != 54 || (GlobalScript.inst.gameState.event_done[463] && GlobalScript.inst.gameState.allcountries[j].stab != 10)))
				{
					if (global2.allcountries[j].prosov && array2[0] == 0 && global2.allcountries[j].stab < 500)
					{
						array2[0] = j;
					}
					else if (global2.allcountries[j].prosov && array2[4] == 0 && global2.allcountries[j].stab < 500)
					{
						array2[4] = j;
					}
					else if (global2.allcountries[j].Vyshi && array2[1] == 0 && global2.allcountries[j].sovpower < 1000 - global2.empires[1].power / 2)
					{
						array2[1] = j;
					}
					else if (global2.allcountries[j].proprc && array2[2] == 0 && global2.allcountries[j].sovpower < 1000 - global2.empires[1].power / 2)
					{
						array2[2] = j;
					}
					else if (!global2.allcountries[j].proprc && !global2.allcountries[j].Vyshi && !global2.allcountries[j].prosov && array2[3] == 0 && global2.allcountries[j].sovpower < 1000 - global2.empires[1].power / 2)
					{
						array2[3] = j;
					}
					else if (global2.allcountries[j].Vyshi && array[0] == 0 && global2.allcountries[j].stab < 500)
					{
						array[0] = j;
					}
					else if (global2.allcountries[j].Vyshi && array[4] == 0 && global2.allcountries[j].stab < 500)
					{
						array[4] = j;
					}
					else if (global2.allcountries[j].prosov && array[1] == 0 && global2.allcountries[j].usapower < 1000 - global2.empires[0].power / 2)
					{
						array[1] = j;
					}
					else if (global2.allcountries[j].proprc && array[2] == 0 && global2.allcountries[j].usapower < 1000 - global2.empires[0].power / 2)
					{
						array[2] = j;
					}
					else if (!global2.allcountries[j].proprc && !global2.allcountries[j].Vyshi && !global2.allcountries[j].prosov && array[3] == 0 && global2.allcountries[j].usapower < 1000 - global2.empires[0].power / 2)
					{
						array[3] = j;
					}
				}
			}
		}
		if (array2[0] > 0 && global2.empires[1].money >= 200)
		{
			global2.allcountries[array2[0]].stab += 100;
			global2.allcountries[array2[0]].dev += 100;
			if (global2.allcountries[array2[0]].usapower >= 50)
			{
				global2.allcountries[array2[0]].usapower -= 50;
			}
			if (global2.allcountries[array2[0]].prcpower >= 50)
			{
				global2.allcountries[array2[0]].prcpower -= 50;
			}
			global2.empires[1].money -= 200;
		}
		if (array2[4] > 0 && global2.empires[1].money >= 200)
		{
			global2.allcountries[array2[4]].stab += 100;
			global2.allcountries[array2[4]].dev += 100;
			if (global2.allcountries[array2[4]].usapower >= 50)
			{
				global2.allcountries[array2[4]].usapower -= 50;
			}
			if (global2.allcountries[array2[4]].prcpower >= 50)
			{
				global2.allcountries[array2[4]].prcpower -= 50;
			}
			global2.empires[1].money -= 200;
		}
		if (array2[1] > 0 && global2.empires[1].money >= 100)
		{
			global2.allcountries[array2[1]].sovpower += 100;
			global2.empires[1].money -= 100;
		}
		if (array2[3] > 0 && global2.empires[1].money >= 50)
		{
			global2.allcountries[array2[3]].sovpower += 50;
			global2.empires[1].money -= 50;
		}
		if (array2[2] > 0 && global2.empires[1].money >= 100)
		{
			global2.allcountries[array2[2]].sovpower += 100;
			global2.empires[1].money -= 100;
		}
		if (array[0] > 0 && global2.empires[0].money >= 200)
		{
			global2.allcountries[array[0]].stab += 100;
			global2.allcountries[array[0]].dev += 100;
			if (global2.allcountries[array[0]].sovpower >= 50)
			{
				global2.allcountries[array[0]].sovpower -= 50;
			}
			if (global2.allcountries[array[0]].prcpower >= 50)
			{
				global2.allcountries[array[0]].prcpower -= 50;
			}
			global2.empires[0].money -= 200;
		}
		if (array[4] > 0 && global2.empires[0].money >= 200)
		{
			global2.allcountries[array[4]].stab += 100;
			global2.allcountries[array[4]].dev += 100;
			if (global2.allcountries[array[4]].sovpower >= 50)
			{
				global2.allcountries[array[4]].sovpower -= 50;
			}
			if (global2.allcountries[array[4]].prcpower >= 50)
			{
				global2.allcountries[array[4]].prcpower -= 50;
			}
			global2.empires[0].money -= 200;
		}
		if (array[1] > 0 && global2.empires[0].money >= 100)
		{
			global2.allcountries[array[1]].usapower += 100;
			global2.empires[0].money -= 100;
		}
		if (array[3] > 0 && global2.empires[0].money >= 100)
		{
			global2.allcountries[array[3]].usapower += 50;
			global2.empires[0].money -= 50;
		}
		if (array[2] > 0 && global2.empires[0].money >= 100)
		{
			global2.allcountries[array[2]].usapower += 100;
			global2.empires[0].money -= 100;
		}
	}

	private void AfricanCoups()
	{
		for (int i = 53; i < 153; i++)
		{
			if ((i >= 69 && (i <= 105 || i >= 109) && (i <= 111 || i >= 134)) || global2.allcountries[i].africaOff || (global2.data[103] == 15 && i == 61) || (i == 54 && (!GlobalScript.inst.gameState.event_done[463] || GlobalScript.inst.gameState.allcountries[i].stab == 10)) || i == 58 || i == 128 || i == 55 || i == 69 || i == 70)
			{
				continue;
			}
			if (!global2.allcountries[i].Vyshi && global2.allcountries[i].Gosstroy != 3 && !global2.allcountries[i].prosov && !global2.allcountries[i].proprc && global2.allcountries[i].sovpower > 300 && global2.allcountries[i].sovpower >= global2.allcountries[i].usapower)
			{
				int num = UnityEngine.Random.Range(80, 100);
				if (num >= 50 && num <= global2.allcountries[i].sovpower / 10)
				{
					global2.allcountries[i].prosov = true;
					global2.allcountries[i].Torg = false;
					global2.empires[1].power++;
				}
			}
			else if (!global2.allcountries[i].Vyshi && global2.allcountries[i].Gosstroy != 1 && !global2.allcountries[i].prosov && !global2.allcountries[i].proprc && global2.allcountries[i].usapower > 300 && global2.allcountries[i].sovpower < global2.allcountries[i].usapower)
			{
				int num2 = UnityEngine.Random.Range(80, 100);
				Debug.Log(num2 + " " + i + " " + global2.allcountries[i].usapower / 10);
				if (num2 >= 50 && num2 <= global2.allcountries[i].usapower / 10)
				{
					global2.allcountries[i].Vyshi = true;
					global2.allcountries[i].Torg = false;
					global2.empires[0].power++;
				}
			}
			else if (!global2.allcountries[i].prosov && global2.allcountries[i].sovpower > 300 && global2.allcountries[i].sovpower >= global2.allcountries[i].usapower)
			{
				global2.allcountries[i].stab -= global2.allcountries[i].sovpower;
				if ((global2.allcountries[i].stab < -200 && global2.allcountries[i].proprc) || global2.allcountries[i].stab < -300 || (global2.allcountries[i].stab < -200 && global2.allcountries[i].Vyshi && global2.empires[1].power > global2.empires[0].power))
				{
					if (global2.allcountries[i].Vyshi)
					{
						global2.empires[0].power -= 5;
						global2.allcountries[i].Vyshi = false;
					}
					if (global2.allcountries[i].proprc)
					{
						global2.influencePRC -= 5;
						global2.allcountries[i].proprc = false;
					}
					global2.allcountries[i].Gosstroy = UnityEngine.Random.Range(0, 3);
					global2.allcountries[i].SubGosstroy = global2.AfricanSubGosstroy(global2.allcountries[i].Gosstroy);
					global2.allcountries[i].prosov = true;
					global2.allcountries[i].Torg = false;
					global2.allcountries[i].stab = 100;
					global2.allcountries[i].dev -= 200;
					global2.allcountries[i].usapower -= global2.allcountries[i].usapower / 2;
					global2.allcountries[i].prcpower -= global2.allcountries[i].prcpower / 2;
					global2.empires[1].power += 5;
				}
			}
			else
			{
				if (global2.allcountries[i].Vyshi || global2.allcountries[i].usapower <= 300 || global2.allcountries[i].sovpower >= global2.allcountries[i].usapower)
				{
					continue;
				}
				global2.allcountries[i].stab -= global2.allcountries[i].usapower;
				if ((global2.allcountries[i].stab < -200 && global2.allcountries[i].proprc) || global2.allcountries[i].stab < -300 || (global2.allcountries[i].stab < -200 && global2.allcountries[i].prosov && global2.empires[0].power > global2.empires[1].power))
				{
					if (global2.allcountries[i].prosov)
					{
						global2.empires[1].power -= 5;
						global2.allcountries[i].prosov = false;
					}
					if (global2.allcountries[i].proprc)
					{
						global2.influencePRC -= 5;
						global2.allcountries[i].proprc = false;
					}
					global2.allcountries[i].Gosstroy = UnityEngine.Random.Range(0, 3);
					if (global2.allcountries[i].Gosstroy == 1)
					{
						global2.allcountries[i].Gosstroy = 3;
					}
					global2.allcountries[i].SubGosstroy = global2.AfricanSubGosstroy(global2.allcountries[i].Gosstroy);
					global2.allcountries[i].Vyshi = true;
					global2.allcountries[i].stab = 100;
					global2.allcountries[i].Torg = false;
					global2.allcountries[i].dev -= 200;
					global2.allcountries[i].sovpower -= global2.allcountries[i].sovpower / 2;
					global2.allcountries[i].prcpower -= global2.allcountries[i].prcpower / 2;
					global2.empires[0].power += 5;
				}
			}
		}
	}

	private void WorldWarsDone()
	{
		if ((global2.ingamewars[1].fortnight_go >= 72 || global2.ingamewars[1].infl1 >= 1000 || global2.ingamewars[1].infl2 >= 1000) && global2.ingamewars[1].is_going && global2.data[82] < 0)
		{
			Debug.Log("Свершилось1");
			global2.data[82] = 1;
			Reelect(18);
		}
		else if ((global2.ingamewars[2].fortnight_go >= 96 || global2.ingamewars[2].infl1 >= 1000 || global2.ingamewars[2].infl2 >= 1000) && global2.ingamewars[2].is_going && global2.data[82] < 0)
		{
			Debug.Log("Свершилось2");
			global2.data[82] = 2;
			Reelect(18);
		}
		else if ((global2.ingamewars[3].fortnight_go >= 192 || global2.ingamewars[3].infl1 >= 1000 || global2.ingamewars[3].infl2 >= 1000 || (global2.allcountries[8].Gosstroy == 1 && global2.allcountries[14].Gosstroy == 1)) && global2.ingamewars[3].is_going && global2.data[82] < 0)
		{
			Debug.Log("Свершилось3");
			global2.data[82] = 3;
			Reelect(18);
		}
		else if ((global2.ingamewars[5].infl1 >= 1000 || global2.ingamewars[5].infl2 >= 1000) && global2.ingamewars[5].is_going && global2.data[82] < 0)
		{
			Debug.Log("Свершилось5");
			global2.data[82] = 5;
			Reelect(18);
		}
		else if ((global2.ingamewars[4].fortnight_go >= 24 || global2.ingamewars[4].infl1 >= 1000 || global2.ingamewars[4].infl2 >= 1000) && global2.ingamewars[4].is_going && global2.data[82] < 0)
		{
			Debug.Log("Свершилось4");
			global2.data[82] = 4;
			Reelect(18);
		}
		else if ((global2.ingamewars[6].fortnight_go >= 24 || global2.ingamewars[6].infl1 >= 1000 || global2.ingamewars[6].infl2 >= 1000) && global2.ingamewars[6].is_going && global2.data[82] < 0)
		{
			Debug.Log("Свершилось6");
			global2.data[82] = 6;
			Reelect(18);
		}
		else if ((global2.ingamewars[0].fortnight_go >= 48 || global2.ingamewars[0].infl1 >= 1000 || global2.ingamewars[0].infl2 >= 1000) && global2.ingamewars[0].is_going && global2.data[82] < 0)
		{
			Debug.Log("Свершилось0");
			global2.data[82] = 0;
			Reelect(18);
		}
		else if (global2.WarCheck(7))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 7;
			Reelect(18);
		}
		else if (global2.WarCheck(8) && global2.data[82] < 0 && (global2.ingamewars[8].infl1 >= 1000 || global2.ingamewars[8].infl2 >= 1000 || global2.ingamewars[8].fortnight_go >= 20))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 8;
			Reelect(18);
		}
		else if (global2.WarCheck(9) && global2.data[82] < 0 && (global2.ingamewars[9].infl1 >= 1000 || global2.ingamewars[9].infl2 >= 1000 || global2.ingamewars[9].fortnight_go >= 12))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 9;
			Reelect(18);
		}
		else if (global2.WarCheck(10) && global2.data[82] < 0 && (global2.ingamewars[10].infl1 >= 1000 || global2.ingamewars[10].infl2 >= 1000 || global2.ingamewars[10].fortnight_go >= 12))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 10;
			Reelect(18);
		}
		else if (global2.WarCheck(11) && global2.data[82] < 0 && (global2.ingamewars[11].infl1 >= 1000 || global2.ingamewars[11].infl2 >= 1000 || global2.ingamewars[11].fortnight_go >= 10))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 11;
			Reelect(18);
		}
		else if (global2.WarCheck(12) && global2.data[82] < 0 && (global2.ingamewars[12].infl1 >= 1000 || global2.ingamewars[12].infl2 >= 1000 || global2.ingamewars[12].fortnight_go >= 12))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 12;
			Reelect(18);
		}
		else if (global2.WarCheck(36) && global2.data[82] < 0 && (global2.ingamewars[36].infl1 >= 1000 || global2.ingamewars[36].infl2 >= 1000 || global2.ingamewars[36].fortnight_go >= 12))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 36;
			Reelect(18);
		}
		else if (global2.WarCheck(14) && global2.data[82] < 0 && (global2.ingamewars[14].infl1 >= 1000 || global2.ingamewars[14].infl2 >= 1000 || global2.ingamewars[14].fortnight_go >= 10))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 14;
			Reelect(18);
		}
		else if (global2.WarCheck(15) && global2.data[82] < 0 && (global2.ingamewars[15].infl1 >= 1000 || global2.ingamewars[15].infl2 >= 1000 || global2.ingamewars[15].fortnight_go >= 16))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 15;
			Reelect(18);
		}
		else if (global2.WarCheck(16))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 16;
			Reelect(18);
		}
		else if (global2.WarCheck(17) && global2.data[82] < 0 && (global2.ingamewars[17].infl1 >= 1000 || global2.ingamewars[17].infl2 >= 1000 || global2.ingamewars[17].fortnight_go >= 20 || (global2.data[20] == 1 && global2.data[21] == 1984)))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 17;
			Reelect(18);
		}
		else if (global2.WarCheck(18) && global2.data[82] < 0 && (global2.ingamewars[18].infl1 >= 1000 || global2.ingamewars[18].infl2 >= 1000 || (global2.ingamewars[18].fortnight_go >= 20 && global2.resultOfEvents[382] == 0) || (global2.resultOfEvents[382] == 1 && global2.ingamewars[18].fortnight_go >= 8)))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 18;
			Reelect(18);
		}
		else if (global2.WarCheck(19) && global2.data[82] < 0 && (global2.ingamewars[19].infl1 >= 1000 || global2.ingamewars[19].infl2 >= 1000 || global2.ingamewars[19].fortnight_go >= 11))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 19;
			Reelect(18);
		}
		else if (global2.WarCheck(20) && global2.data[82] < 0 && (global2.ingamewars[20].infl1 >= 1000 || global2.ingamewars[20].infl2 >= 1000))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 20;
			Reelect(18);
		}
		else if (global2.WarCheck(21) && global2.data[82] < 0 && (global2.ingamewars[21].infl1 >= 1000 || global2.ingamewars[21].infl2 >= 1000 || global2.ingamewars[21].fortnight_go >= 20))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 21;
			Reelect(18);
		}
		else if (global2.WarCheck(22) && global2.data[82] < 0 && (global2.ingamewars[22].infl1 >= 1000 || global2.ingamewars[22].infl2 >= 1000))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 22;
			Reelect(18);
		}
		else if (global2.WarCheck(23) && global2.data[82] < 0 && (global2.ingamewars[23].infl1 >= 1000 || global2.ingamewars[23].infl2 >= 1000 || global2.ingamewars[23].fortnight_go >= 30))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 23;
			Reelect(18);
		}
		else if (global2.WarCheck(24) && global2.data[82] < 0 && (global2.ingamewars[24].infl1 >= 1000 || global2.ingamewars[24].infl2 >= 1000))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 24;
			Reelect(18);
		}
		else if (global2.WarCheck(25) && global2.data[82] < 0 && (global2.ingamewars[25].infl1 >= 1000 || global2.ingamewars[25].infl2 >= 1000 || global2.ingamewars[25].fortnight_go >= 20))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 25;
			Reelect(18);
		}
		else if (global2.WarCheck(26) && global2.data[82] < 0 && (global2.ingamewars[26].infl1 >= 1000 || global2.ingamewars[26].infl2 >= 1000 || global2.ingamewars[26].fortnight_go >= 20))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 26;
			Reelect(18);
		}
		else if (global2.WarCheck(27) && global2.data[82] < 0 && (global2.ingamewars[27].infl1 >= 1000 || global2.ingamewars[27].infl2 >= 1000 || global2.ingamewars[27].fortnight_go >= 30))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 27;
			Reelect(18);
		}
		else if (global2.WarCheck(28) && global2.data[82] < 0 && (global2.ingamewars[28].infl1 >= 1000 || global2.ingamewars[28].infl2 >= 1000 || global2.ingamewars[28].fortnight_go >= 25))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 28;
			Reelect(18);
		}
		else if (global2.WarCheck(29) && global2.data[82] < 0 && (global2.ingamewars[29].infl1 >= 1000 || global2.ingamewars[29].infl2 >= 1000 || global2.ingamewars[29].fortnight_go >= 15))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 29;
			Reelect(18);
		}
		else if (global2.WarCheck(30) && global2.data[82] < 0 && (global2.ingamewars[30].infl1 >= 1000 || global2.ingamewars[30].infl2 >= 1000 || global2.data[21] == 1983))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 30;
			Reelect(18);
		}
		else if (global2.WarCheck(31) && global2.data[82] < 0 && (global2.ingamewars[31].infl1 >= 1000 || global2.ingamewars[31].infl2 >= 1000))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 31;
			Reelect(18);
		}
		else if (global2.WarCheck(32) && global2.data[82] < 0 && (global2.ingamewars[32].infl1 >= 1000 || global2.ingamewars[32].infl2 >= 1000))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 32;
			Reelect(18);
		}
		else if (global2.WarCheck(33) || (global2.allcountries[8].Gosstroy == 1 && global2.ingamewars[33].is_going))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 33;
			Reelect(18);
		}
		else if (global2.WarCheck(34))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 34;
			Reelect(18);
		}
		else if (global2.WarCheck(35))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 35;
			Reelect(18);
		}
		else if (global2.WarCheck(37))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 37;
			Reelect(18);
		}
		else if (global2.WarCheck(38))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 38;
			Reelect(18);
		}
		else if (global2.WarCheck(39))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 39;
			Reelect(18);
		}
		else if (global2.WarCheck(40))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 40;
			Reelect(18);
		}
		else if (global2.WarCheck(41))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 41;
			Reelect(18);
		}
		else if (global2.WarCheck(42))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 42;
			Reelect(18);
		}
		else if (global2.WarCheck(43))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 43;
			Reelect(18);
		}
		else if (global2.WarCheck(44))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 44;
			Reelect(18);
		}
		else if (global2.WarCheck(45))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 45;
			Reelect(18);
		}
		else if (global2.WarCheck(46))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 46;
			Reelect(18);
		}
		else if (global2.WarCheck(47))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 47;
			Reelect(18);
		}
		else if (global2.WarCheck(48))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 48;
			Reelect(18);
		}
		else if (global2.WarCheck(49))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 49;
			Reelect(18);
		}
		else if (global2.WarCheck(50))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 50;
			Reelect(18);
		}
		else if (global2.WarCheck(51))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 51;
			Reelect(18);
		}
		else if (global2.WarCheck(52))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 52;
			Reelect(18);
		}
		else if (global2.WarCheck(53))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 53;
			Reelect(18);
		}
		else if (global2.WarCheck(54))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 54;
			Reelect(18);
		}
		else if (global2.WarCheck(55))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 55;
			Reelect(18);
		}
		else if (global2.WarCheck(56))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 56;
			Reelect(18);
		}
		else if (global2.WarCheck(57))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 57;
			Reelect(18);
		}
		else if (global2.WarCheck(58))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 58;
			Reelect(18);
		}
		else if (global2.WarCheck(59))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 59;
			Reelect(18);
		}
		else if (global2.WarCheck(60))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 60;
			Reelect(18);
		}
		else if (global2.WarCheck(61))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 61;
			Reelect(18);
		}
		else if (global2.WarCheck(62))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 62;
			Reelect(18);
		}
		else if (global2.WarCheck(63))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 63;
			Reelect(18);
		}
		else if (global2.WarCheck(64))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 64;
			Reelect(18);
		}
		else if (global2.WarCheck(65))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 65;
			Reelect(18);
		}
		else if (global2.WarCheck(66))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 66;
			Reelect(18);
		}
		else if (global2.WarCheck(67))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 67;
			Reelect(18);
		}
		else if ((GlobalScript.inst.gameState.ingamewars[68].infl1 >= 1000 || GlobalScript.inst.gameState.ingamewars[68].infl2 >= 1000) && GlobalScript.inst.gameState.ingamewars[68].is_going && GlobalScript.inst.gameState.data[82] < 0)
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 68;
			Reelect(18);
		}
		else if (global2.WarCheck(69))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 69;
			Reelect(18);
		}
		else if (global2.WarCheck(70))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 70;
			Reelect(18);
		}
		else if (global2.WarCheck(71))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 71;
			Reelect(18);
		}
		else if (global2.WarCheck(72))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 72;
			Reelect(18);
		}
		else if (global2.WarCheck(73))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 73;
			Reelect(18);
		}
		else if (global2.WarCheck(74))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 74;
			Reelect(18);
		}
		else if (global2.WarCheck(75))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 75;
			Reelect(18);
		}
		else if (global2.WarCheck(76))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 76;
			Reelect(18);
		}
		else if (global2.WarCheck(77))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 77;
			Reelect(18);
		}
		else if (global2.WarCheck(78))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 78;
			Reelect(18);
		}
		else if (global2.WarCheck(79))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 79;
			Reelect(18);
		}
		else if (global2.WarCheck(80))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 80;
			Reelect(18);
		}
		else if (global2.WarCheck(81))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 81;
			Reelect(661);
		}
		else if (global2.WarCheck(82))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 82;
			Reelect(18);
		}
		else if (global2.WarCheck(83))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 83;
			Reelect(18);
		}
		else if (global2.WarCheck(84))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 84;
			Reelect(18);
		}
		else if (global2.WarCheck(85))
		{
			Debug.Log("Свершилось7");
			global2.data[82] = 85;
			Reelect(18);
		}
		else if ((global2.allcountries[126].level_of_unstab >= 1000 || global2.allcountries[126].level_of_unstab <= 0) && !global2.event_done[625] && global2.allcountries[126].parts[0])
		{
			Debug.Log("Свершилось7");
			Reelect(625);
		}
		else
		{
			global2.data[82] = -10;
		}
	}

	private void WorldWarsInfluenceChanges()
	{
		if (global2.ingamewars[1].is_going)
		{
			global2.ingamewars[1].fortnight_go++;
			if (global2.ingamewars[1].infl1 >= 1000 || global2.ingamewars[1].infl2 <= 0)
			{
				global2.ingamewars[1].infl1 = 1000;
				global2.ingamewars[1].infl2 = 0;
			}
			else if (global2.ingamewars[1].infl2 >= 1000 || global2.ingamewars[1].infl1 <= 0)
			{
				global2.ingamewars[1].infl2 = 1000;
				global2.ingamewars[1].infl1 = 0;
			}
			else if (global2.resultOfEvents[15] == 0 && GlobalScript.inst.gameState.war == 0)
			{
				if (global2.ingamewars[1].infl1 < 1000)
				{
					global2.ingamewars[1].infl1 -= 15;
				}
				if (global2.ingamewars[1].infl2 > 0)
				{
					global2.ingamewars[1].infl2 += 15;
				}
			}
			else if (global2.resultOfEvents[15] == 1 && GlobalScript.inst.gameState.war == 0)
			{
				if (global2.ingamewars[1].infl1 < 1000)
				{
					global2.ingamewars[1].infl1 -= 10;
				}
				if (global2.ingamewars[1].infl2 > 0)
				{
					global2.ingamewars[1].infl2 += 10;
				}
			}
			else if (global2.resultOfEvents[56] == 1 && GlobalScript.inst.gameState.war == 1)
			{
				if (global2.ingamewars[1].infl1 < 1000)
				{
					global2.ingamewars[1].infl1 += 10;
				}
				if (global2.ingamewars[1].infl2 > 0)
				{
					global2.ingamewars[1].infl2 -= 10;
				}
			}
		}
		if (global2.ingamewars[0].is_going)
		{
			global2.ingamewars[0].fortnight_go++;
			if (global2.ingamewars[0].infl1 >= 1000 || global2.ingamewars[0].infl2 <= 0)
			{
				global2.ingamewars[0].infl1 = 1000;
				global2.ingamewars[0].infl2 = 0;
			}
			else if (global2.ingamewars[0].infl2 >= 1000 || global2.ingamewars[0].infl1 <= 0)
			{
				global2.ingamewars[0].infl2 = 1000;
				global2.ingamewars[0].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[0].infl1 < 1000)
				{
					global2.ingamewars[0].infl1 -= 7;
				}
				if (global2.ingamewars[0].infl2 > 0)
				{
					global2.ingamewars[0].infl2 += 7;
				}
				if (!global2.allcountries[10].proprc)
				{
					global2.ingamewars[0].infl1 -= 2;
					global2.ingamewars[0].infl2 += 2;
				}
			}
		}
		if (global2.ingamewars[7].is_going)
		{
			global2.ingamewars[7].fortnight_go++;
			if (global2.ingamewars[7].infl1 >= 1000 || global2.ingamewars[7].infl2 <= 0)
			{
				global2.ingamewars[7].infl1 = 1000;
				global2.ingamewars[7].infl2 = 0;
			}
			else if (global2.ingamewars[7].infl2 >= 1000 || global2.ingamewars[7].infl1 <= 0)
			{
				global2.ingamewars[7].infl2 = 1000;
				global2.ingamewars[7].infl1 = 0;
			}
			else if (global2.allcountries[19].numberOfSpecialEnding == 0)
			{
				if (global2.ingamewars[7].infl1 < 1000)
				{
					global2.ingamewars[7].infl1 -= 3;
				}
				if (global2.ingamewars[7].infl2 > 0)
				{
					global2.ingamewars[7].infl2 += 3;
				}
			}
			else if (global2.allcountries[19].numberOfSpecialEnding == 1)
			{
				if (global2.ingamewars[7].infl2 < 1000)
				{
					global2.ingamewars[7].infl2 -= 3;
				}
				if (global2.ingamewars[7].infl1 > 0)
				{
					global2.ingamewars[7].infl1 += 3;
				}
			}
		}
		if (global2.ingamewars[8].is_going)
		{
			global2.ingamewars[8].fortnight_go++;
			if (global2.ingamewars[8].infl1 >= 1000 || global2.ingamewars[8].infl2 <= 0)
			{
				global2.ingamewars[8].infl1 = 1000;
				global2.ingamewars[8].infl2 = 0;
			}
			else if (global2.ingamewars[8].infl2 >= 1000 || global2.ingamewars[8].infl1 <= 0)
			{
				global2.ingamewars[8].infl2 = 1000;
				global2.ingamewars[8].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[8].infl1 > 0)
				{
					global2.ingamewars[8].infl1 += 8;
				}
				if (global2.ingamewars[8].infl2 < 1000)
				{
					global2.ingamewars[8].infl2 -= 8;
				}
			}
		}
		if (global2.ingamewars[9].is_going)
		{
			global2.ingamewars[9].fortnight_go++;
			if (global2.ingamewars[9].infl1 >= 1000 || global2.ingamewars[9].infl2 <= 0)
			{
				global2.ingamewars[9].infl1 = 1000;
				global2.ingamewars[9].infl2 = 0;
			}
			else if (global2.ingamewars[9].infl2 >= 1000 || global2.ingamewars[9].infl1 <= 0)
			{
				global2.ingamewars[9].infl2 = 1000;
				global2.ingamewars[9].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[9].infl1 > 0)
				{
					global2.ingamewars[9].infl1 += 5;
				}
				if (global2.ingamewars[9].infl2 < 1000)
				{
					global2.ingamewars[9].infl2 -= 5;
				}
			}
		}
		if (global2.ingamewars[10].is_going)
		{
			global2.ingamewars[10].fortnight_go++;
			if (global2.ingamewars[10].infl1 >= 1000 || global2.ingamewars[10].infl2 <= 0)
			{
				global2.ingamewars[10].infl1 = 1000;
				global2.ingamewars[10].infl2 = 0;
			}
			else if (global2.ingamewars[10].infl2 >= 1000 || global2.ingamewars[10].infl1 <= 0)
			{
				global2.ingamewars[10].infl2 = 1000;
				global2.ingamewars[10].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[10].infl1 > 0)
				{
					if (global2.ingamewars[10].usa_place == 0 || global2.allcountries[84].isNATO)
					{
						global2.ingamewars[10].infl1 += 20;
					}
					else
					{
						global2.ingamewars[10].infl1 += 5;
					}
				}
				if (global2.ingamewars[10].infl2 < 1000)
				{
					if (global2.ingamewars[10].usa_place == 0 || global2.allcountries[84].isNATO)
					{
						global2.ingamewars[10].infl2 -= 20;
					}
					else
					{
						global2.ingamewars[10].infl2 -= 5;
					}
				}
			}
		}
		if (global2.ingamewars[11].is_going)
		{
			global2.ingamewars[11].fortnight_go++;
			if (global2.ingamewars[11].infl1 >= 1000 || global2.ingamewars[11].infl2 <= 0)
			{
				global2.ingamewars[11].infl1 = 1000;
				global2.ingamewars[11].infl2 = 0;
			}
			else if (global2.ingamewars[11].infl2 >= 1000 || global2.ingamewars[11].infl1 <= 0)
			{
				global2.ingamewars[11].infl2 = 1000;
				global2.ingamewars[11].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[11].infl1 > 0)
				{
					if (global2.ingamewars[11].usa_place == 0 || global2.allcountries[84].isNATO)
					{
						global2.ingamewars[11].infl1 += 20;
					}
					else
					{
						global2.ingamewars[11].infl1 += 5;
					}
				}
				if (global2.ingamewars[11].infl2 < 1000)
				{
					if (global2.ingamewars[11].usa_place == 0 || global2.allcountries[84].isNATO)
					{
						global2.ingamewars[11].infl2 -= 20;
					}
					else
					{
						global2.ingamewars[11].infl2 -= 5;
					}
				}
			}
		}
		if (global2.ingamewars[12].is_going)
		{
			global2.ingamewars[12].fortnight_go++;
			if (global2.ingamewars[12].infl1 >= 1000 || global2.ingamewars[12].infl2 <= 0)
			{
				global2.ingamewars[12].infl1 = 1000;
				global2.ingamewars[12].infl2 = 0;
			}
			else if (global2.ingamewars[12].infl2 >= 1000 || global2.ingamewars[12].infl1 <= 0)
			{
				global2.ingamewars[12].infl2 = 1000;
				global2.ingamewars[12].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[12].infl1 > 0)
				{
					if (global2.ingamewars[12].usa_place == 0 || global2.allcountries[84].isNATO)
					{
						global2.ingamewars[12].infl1 += 20;
					}
					else
					{
						global2.ingamewars[12].infl1 += 5;
					}
				}
				if (global2.ingamewars[12].infl2 < 1000)
				{
					if (global2.ingamewars[12].usa_place == 0 || global2.allcountries[84].isNATO)
					{
						global2.ingamewars[12].infl2 -= 20;
					}
					else
					{
						global2.ingamewars[12].infl2 -= 5;
					}
				}
			}
		}
		if (global2.ingamewars[36].is_going)
		{
			global2.ingamewars[36].fortnight_go++;
			if (global2.ingamewars[36].infl1 >= 1000 || global2.ingamewars[36].infl2 <= 0)
			{
				global2.ingamewars[36].infl1 = 1000;
				global2.ingamewars[36].infl2 = 0;
			}
			else if (global2.ingamewars[36].infl2 >= 1000 || global2.ingamewars[36].infl1 <= 0)
			{
				global2.ingamewars[36].infl2 = 1000;
				global2.ingamewars[36].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[36].infl1 > 0)
				{
					global2.ingamewars[36].infl1 += 30;
				}
				if (global2.ingamewars[36].infl2 < 1000)
				{
					global2.ingamewars[36].infl2 -= 30;
				}
			}
		}
		if (global2.ingamewars[37].is_going)
		{
			global2.ingamewars[37].fortnight_go++;
			if (global2.ingamewars[37].infl1 >= 1000 || global2.ingamewars[37].infl2 <= 0)
			{
				global2.ingamewars[37].infl1 = 1000;
				global2.ingamewars[37].infl2 = 0;
			}
			else if (global2.ingamewars[37].infl2 >= 1000 || global2.ingamewars[37].infl1 <= 0)
			{
				global2.ingamewars[37].infl2 = 1000;
				global2.ingamewars[37].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[37].infl1 > 0)
				{
					global2.ingamewars[37].infl1 -= 5;
				}
				if (global2.ingamewars[37].infl2 < 1000)
				{
					global2.ingamewars[37].infl2 += 5;
				}
			}
		}
		if (global2.ingamewars[39].is_going)
		{
			global2.ingamewars[39].fortnight_go++;
			if (global2.ingamewars[39].infl1 >= 1000 || global2.ingamewars[39].infl2 <= 0)
			{
				global2.ingamewars[39].infl1 = 1000;
				global2.ingamewars[39].infl2 = 0;
			}
			else if (global2.ingamewars[39].infl2 >= 1000 || global2.ingamewars[39].infl1 <= 0)
			{
				global2.ingamewars[39].infl2 = 1000;
				global2.ingamewars[39].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[39].infl1 > 0)
				{
					global2.ingamewars[39].infl1 += 3;
				}
				if (global2.ingamewars[39].infl2 < 1000)
				{
					global2.ingamewars[39].infl2 -= 3;
				}
			}
		}
		if (global2.ingamewars[40].is_going)
		{
			global2.ingamewars[40].fortnight_go++;
			if (global2.ingamewars[40].infl1 >= 1000 || global2.ingamewars[40].infl2 <= 0)
			{
				global2.ingamewars[40].infl1 = 1000;
				global2.ingamewars[40].infl2 = 0;
			}
			else if (global2.ingamewars[40].infl2 >= 1000 || global2.ingamewars[40].infl1 <= 0)
			{
				global2.ingamewars[40].infl2 = 1000;
				global2.ingamewars[40].infl1 = 0;
			}
			else
			{
				if (global2.resultOfEvents[563] == 0)
				{
					if (global2.ingamewars[40].infl1 > 0)
					{
						global2.ingamewars[40].infl1 += 10;
					}
					if (global2.ingamewars[40].infl2 < 1000)
					{
						global2.ingamewars[40].infl2 -= 10;
					}
				}
				if (global2.resultOfEvents[563] == 1)
				{
					if (global2.ingamewars[40].infl1 > 0)
					{
						global2.ingamewars[40].infl1 += 6;
					}
					if (global2.ingamewars[40].infl2 < 1000)
					{
						global2.ingamewars[40].infl2 -= 6;
					}
				}
				if (global2.resultOfEvents[563] == 2)
				{
					if (global2.ingamewars[40].infl1 > 0)
					{
						global2.ingamewars[40].infl1 += 6;
					}
					if (global2.ingamewars[40].infl2 < 1000)
					{
						global2.ingamewars[40].infl2 -= 6;
					}
				}
			}
		}
		if (global2.ingamewars[41].is_going)
		{
			global2.ingamewars[41].fortnight_go++;
			if (global2.ingamewars[41].infl1 >= 1000 || global2.ingamewars[41].infl2 <= 0)
			{
				global2.ingamewars[41].infl1 = 1000;
				global2.ingamewars[41].infl2 = 0;
			}
			else if (global2.ingamewars[41].infl2 >= 1000 || global2.ingamewars[41].infl1 <= 0)
			{
				global2.ingamewars[41].infl2 = 1000;
				global2.ingamewars[41].infl1 = 0;
			}
			else
			{
				if (global2.resultOfEvents[565] == 0)
				{
					if (global2.ingamewars[41].infl1 > 0)
					{
						global2.ingamewars[41].infl1 += 10;
					}
					if (global2.ingamewars[41].infl2 < 1000)
					{
						global2.ingamewars[41].infl2 -= 10;
					}
				}
				if (global2.resultOfEvents[565] == 1)
				{
					if (global2.ingamewars[41].infl1 > 0)
					{
						global2.ingamewars[41].infl1 += 6;
					}
					if (global2.ingamewars[41].infl2 < 1000)
					{
						global2.ingamewars[41].infl2 -= 6;
					}
				}
				if (global2.resultOfEvents[565] == 2)
				{
					if (global2.ingamewars[41].infl1 > 0)
					{
						global2.ingamewars[41].infl1 += 4;
					}
					if (global2.ingamewars[41].infl2 < 1000)
					{
						global2.ingamewars[41].infl2 -= 4;
					}
				}
			}
		}
		if (global2.ingamewars[42].is_going)
		{
			global2.ingamewars[42].fortnight_go++;
			if (global2.ingamewars[42].infl1 >= 1000 || global2.ingamewars[42].infl2 <= 0)
			{
				global2.ingamewars[42].infl1 = 1000;
				global2.ingamewars[42].infl2 = 0;
			}
			else if (global2.ingamewars[42].infl2 >= 1000 || global2.ingamewars[42].infl1 <= 0)
			{
				global2.ingamewars[42].infl2 = 1000;
				global2.ingamewars[42].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[42].infl1 > 0)
				{
					global2.ingamewars[42].infl1 += 6;
				}
				if (global2.ingamewars[42].infl2 < 1000)
				{
					global2.ingamewars[42].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[43].is_going)
		{
			global2.ingamewars[43].fortnight_go++;
			if (global2.ingamewars[43].infl1 >= 1000 || global2.ingamewars[43].infl2 <= 0)
			{
				global2.ingamewars[43].infl1 = 1000;
				global2.ingamewars[43].infl2 = 0;
			}
			else if (global2.ingamewars[43].infl2 >= 1000 || global2.ingamewars[43].infl1 <= 0)
			{
				global2.ingamewars[43].infl2 = 1000;
				global2.ingamewars[43].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[43].infl1 > 0)
				{
					global2.ingamewars[43].infl1 += 6;
				}
				if (global2.ingamewars[43].infl2 < 1000)
				{
					global2.ingamewars[43].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[44].is_going)
		{
			global2.ingamewars[44].fortnight_go++;
			if (global2.ingamewars[44].infl1 >= 1000 || global2.ingamewars[44].infl2 <= 0)
			{
				global2.ingamewars[44].infl1 = 1000;
				global2.ingamewars[44].infl2 = 0;
			}
			else if (global2.ingamewars[44].infl2 >= 1000 || global2.ingamewars[44].infl1 <= 0)
			{
				global2.ingamewars[44].infl2 = 1000;
				global2.ingamewars[44].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[44].infl1 > 0)
				{
					global2.ingamewars[44].infl1 += 6;
				}
				if (global2.ingamewars[44].infl2 < 1000)
				{
					global2.ingamewars[44].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[45].is_going)
		{
			global2.ingamewars[45].fortnight_go++;
			if (global2.ingamewars[45].infl1 >= 1000 || global2.ingamewars[45].infl2 <= 0)
			{
				global2.ingamewars[45].infl1 = 1000;
				global2.ingamewars[45].infl2 = 0;
			}
			else if (global2.ingamewars[45].infl2 >= 1000 || global2.ingamewars[45].infl1 <= 0)
			{
				global2.ingamewars[45].infl2 = 1000;
				global2.ingamewars[45].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[45].infl1 > 0)
				{
					global2.ingamewars[45].infl1 += 6;
				}
				if (global2.ingamewars[45].infl2 < 1000)
				{
					global2.ingamewars[45].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[46].is_going)
		{
			global2.ingamewars[46].fortnight_go++;
			if (global2.ingamewars[46].infl1 >= 1000 || global2.ingamewars[46].infl2 <= 0)
			{
				global2.ingamewars[46].infl1 = 1000;
				global2.ingamewars[46].infl2 = 0;
			}
			else if (global2.ingamewars[46].infl2 >= 1000 || global2.ingamewars[46].infl1 <= 0)
			{
				global2.ingamewars[46].infl2 = 1000;
				global2.ingamewars[46].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[46].infl1 > 0)
				{
					global2.ingamewars[46].infl1 += 6;
				}
				if (global2.ingamewars[46].infl2 < 1000)
				{
					global2.ingamewars[46].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[47].is_going)
		{
			global2.ingamewars[47].fortnight_go++;
			if (global2.ingamewars[47].infl1 >= 1000 || global2.ingamewars[47].infl2 <= 0)
			{
				global2.ingamewars[47].infl1 = 1000;
				global2.ingamewars[47].infl2 = 0;
			}
			else if (global2.ingamewars[47].infl2 >= 1000 || global2.ingamewars[47].infl1 <= 0)
			{
				global2.ingamewars[47].infl2 = 1000;
				global2.ingamewars[47].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[47].infl1 > 0)
				{
					global2.ingamewars[47].infl1 += 6;
				}
				if (global2.ingamewars[47].infl2 < 1000)
				{
					global2.ingamewars[47].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[48].is_going)
		{
			global2.ingamewars[48].fortnight_go++;
			if (global2.ingamewars[48].infl1 >= 1000 || global2.ingamewars[48].infl2 <= 0)
			{
				global2.ingamewars[48].infl1 = 1000;
				global2.ingamewars[48].infl2 = 0;
			}
			else if (global2.ingamewars[48].infl2 >= 1000 || global2.ingamewars[48].infl1 <= 0)
			{
				global2.ingamewars[48].infl2 = 1000;
				global2.ingamewars[48].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[48].infl1 > 0)
				{
					global2.ingamewars[48].infl1 += 6;
				}
				if (global2.ingamewars[48].infl2 < 1000)
				{
					global2.ingamewars[48].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[49].is_going)
		{
			global2.ingamewars[49].fortnight_go++;
			if (global2.ingamewars[49].infl1 >= 1000 || global2.ingamewars[49].infl2 <= 0)
			{
				global2.ingamewars[49].infl1 = 1000;
				global2.ingamewars[49].infl2 = 0;
			}
			else if (global2.ingamewars[49].infl2 >= 1000 || global2.ingamewars[49].infl1 <= 0)
			{
				global2.ingamewars[49].infl2 = 1000;
				global2.ingamewars[49].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[49].infl1 > 0)
				{
					global2.ingamewars[49].infl1 += 6;
				}
				if (global2.ingamewars[49].infl2 < 1000)
				{
					global2.ingamewars[49].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[50].is_going)
		{
			global2.ingamewars[50].fortnight_go++;
			if (global2.ingamewars[50].infl1 >= 1000 || global2.ingamewars[50].infl2 <= 0)
			{
				global2.ingamewars[50].infl1 = 1000;
				global2.ingamewars[50].infl2 = 0;
			}
			else if (global2.ingamewars[50].infl2 >= 1000 || global2.ingamewars[50].infl1 <= 0)
			{
				global2.ingamewars[50].infl2 = 1000;
				global2.ingamewars[50].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[50].infl1 > 0)
				{
					global2.ingamewars[50].infl1 += 6;
				}
				if (global2.ingamewars[50].infl2 < 1000)
				{
					global2.ingamewars[50].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[51].is_going)
		{
			global2.ingamewars[51].fortnight_go++;
			if (global2.ingamewars[51].infl1 >= 1000 || global2.ingamewars[51].infl2 <= 0)
			{
				global2.ingamewars[51].infl1 = 1000;
				global2.ingamewars[51].infl2 = 0;
			}
			else if (global2.ingamewars[51].infl2 >= 1000 || global2.ingamewars[51].infl1 <= 0)
			{
				global2.ingamewars[51].infl2 = 1000;
				global2.ingamewars[51].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[51].infl1 > 0)
				{
					global2.ingamewars[51].infl1 += 6;
				}
				if (global2.ingamewars[51].infl2 < 1000)
				{
					global2.ingamewars[51].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[52].is_going)
		{
			global2.ingamewars[52].fortnight_go++;
			if (global2.ingamewars[52].infl1 >= 1000 || global2.ingamewars[52].infl2 <= 0)
			{
				global2.ingamewars[52].infl1 = 1000;
				global2.ingamewars[52].infl2 = 0;
			}
			else if (global2.ingamewars[52].infl2 >= 1000 || global2.ingamewars[52].infl1 <= 0)
			{
				global2.ingamewars[52].infl2 = 1000;
				global2.ingamewars[52].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[52].infl1 > 0)
				{
					global2.ingamewars[52].infl1 -= 6;
				}
				if (global2.ingamewars[52].infl2 < 1000)
				{
					global2.ingamewars[52].infl2 += 6;
				}
			}
		}
		if (global2.ingamewars[53].is_going)
		{
			global2.ingamewars[53].fortnight_go++;
			if (global2.ingamewars[53].infl1 >= 1000 || global2.ingamewars[53].infl2 <= 0)
			{
				global2.ingamewars[53].infl1 = 1000;
				global2.ingamewars[53].infl2 = 0;
			}
			else if (global2.ingamewars[53].infl2 >= 1000 || global2.ingamewars[53].infl1 <= 0)
			{
				global2.ingamewars[53].infl2 = 1000;
				global2.ingamewars[53].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[53].infl1 > 0)
				{
					global2.ingamewars[53].infl1 += 6;
				}
				if (global2.ingamewars[53].infl2 < 1000)
				{
					global2.ingamewars[53].infl2 -= 6;
				}
			}
		}
		if (global2.ingamewars[55].is_going)
		{
			global2.ingamewars[55].fortnight_go++;
			if (global2.ingamewars[55].infl1 >= 1000 || global2.ingamewars[55].infl2 <= 0)
			{
				global2.ingamewars[55].infl1 = 1000;
				global2.ingamewars[55].infl2 = 0;
			}
			else if (global2.ingamewars[55].infl2 >= 1000 || global2.ingamewars[55].infl1 <= 0)
			{
				global2.ingamewars[55].infl2 = 1000;
				global2.ingamewars[55].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[55].infl1 > 0)
				{
					global2.ingamewars[55].infl2 += 6;
				}
				if (global2.ingamewars[55].infl2 < 1000)
				{
					global2.ingamewars[55].infl1 -= 6;
				}
			}
		}
		if (global2.ingamewars[56].is_going)
		{
			global2.ingamewars[56].fortnight_go++;
			if (global2.ingamewars[56].infl1 >= 1000 || global2.ingamewars[56].infl2 <= 0)
			{
				global2.ingamewars[56].infl1 = 1000;
				global2.ingamewars[56].infl2 = 0;
			}
			else if (global2.ingamewars[56].infl2 >= 1000 || global2.ingamewars[56].infl1 <= 0)
			{
				global2.ingamewars[56].infl2 = 1000;
				global2.ingamewars[56].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[56].infl1 > 0)
				{
					global2.ingamewars[56].infl2 += 10;
				}
				if (global2.ingamewars[56].infl2 < 1000)
				{
					global2.ingamewars[56].infl1 -= 10;
				}
			}
		}
		if (global2.ingamewars[57].is_going)
		{
			global2.ingamewars[57].fortnight_go++;
			if (global2.ingamewars[57].infl1 >= 1000 || global2.ingamewars[57].infl2 <= 0)
			{
				global2.ingamewars[57].infl1 = 1000;
				global2.ingamewars[57].infl2 = 0;
			}
			else if (global2.ingamewars[57].infl2 >= 1000 || global2.ingamewars[57].infl1 <= 0)
			{
				global2.ingamewars[57].infl2 = 1000;
				global2.ingamewars[57].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[57].infl1 > 0)
				{
					global2.ingamewars[57].infl2 += 10;
				}
				if (global2.ingamewars[57].infl2 < 1000)
				{
					global2.ingamewars[57].infl1 -= 10;
				}
			}
		}
		if (global2.ingamewars[58].is_going)
		{
			global2.ingamewars[58].fortnight_go++;
			if (global2.ingamewars[58].infl1 >= 1000 || global2.ingamewars[58].infl2 <= 0)
			{
				global2.ingamewars[58].infl1 = 1000;
				global2.ingamewars[58].infl2 = 0;
			}
			else if (global2.ingamewars[58].infl2 >= 1000 || global2.ingamewars[58].infl1 <= 0)
			{
				global2.ingamewars[58].infl2 = 1000;
				global2.ingamewars[58].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[58].infl1 > 0)
				{
					global2.ingamewars[58].infl2 += 10;
				}
				if (global2.ingamewars[58].infl2 < 1000)
				{
					global2.ingamewars[58].infl1 -= 10;
				}
			}
		}
		if (global2.ingamewars[59].is_going)
		{
			global2.ingamewars[59].fortnight_go++;
			if (global2.ingamewars[59].infl1 >= 1000 || global2.ingamewars[59].infl2 <= 0)
			{
				global2.ingamewars[59].infl1 = 1000;
				global2.ingamewars[59].infl2 = 0;
			}
			else if (global2.ingamewars[59].infl2 >= 1000 || global2.ingamewars[59].infl1 <= 0)
			{
				global2.ingamewars[59].infl2 = 1000;
				global2.ingamewars[59].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[59].infl1 > 0)
				{
					global2.ingamewars[59].infl2 += 10;
				}
				if (global2.ingamewars[59].infl2 < 1000)
				{
					global2.ingamewars[59].infl1 -= 10;
				}
			}
		}
		if (global2.ingamewars[60].is_going)
		{
			global2.ingamewars[60].fortnight_go++;
			if (global2.ingamewars[60].infl1 >= 1000 || global2.ingamewars[60].infl2 <= 0)
			{
				global2.ingamewars[60].infl1 = 1000;
				global2.ingamewars[60].infl2 = 0;
			}
			else if (global2.ingamewars[60].infl2 >= 1000 || global2.ingamewars[60].infl1 <= 0)
			{
				global2.ingamewars[60].infl2 = 1000;
				global2.ingamewars[60].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[60].infl1 > 0)
				{
					global2.ingamewars[60].infl2 += 10;
				}
				if (global2.ingamewars[60].infl2 < 1000)
				{
					global2.ingamewars[60].infl1 -= 10;
				}
			}
		}
		if (global2.ingamewars[61].is_going)
		{
			global2.ingamewars[61].fortnight_go++;
			if (global2.ingamewars[61].infl1 >= 1000 || global2.ingamewars[61].infl2 <= 0)
			{
				global2.ingamewars[61].infl1 = 1000;
				global2.ingamewars[61].infl2 = 0;
			}
			else if (global2.ingamewars[61].infl2 >= 1000 || global2.ingamewars[61].infl1 <= 0)
			{
				global2.ingamewars[61].infl2 = 1000;
				global2.ingamewars[61].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[61].infl1 > 0)
				{
					global2.ingamewars[61].infl2 += 10;
				}
				if (global2.ingamewars[61].infl2 < 1000)
				{
					global2.ingamewars[61].infl1 -= 10;
				}
			}
		}
		if (global2.ingamewars[63].is_going)
		{
			global2.ingamewars[63].fortnight_go++;
			if (global2.ingamewars[63].infl1 >= 1000 || global2.ingamewars[63].infl2 <= 0)
			{
				global2.ingamewars[63].infl1 = 1000;
				global2.ingamewars[63].infl2 = 0;
			}
			else if (global2.ingamewars[63].infl2 >= 1000 || global2.ingamewars[63].infl1 <= 0)
			{
				global2.ingamewars[63].infl2 = 1000;
				global2.ingamewars[63].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[63].infl1 > 0)
				{
					global2.ingamewars[63].infl2 += 10;
				}
				if (global2.ingamewars[63].infl2 < 1000)
				{
					global2.ingamewars[63].infl1 -= 10;
				}
			}
		}
		if (global2.ingamewars[64].is_going)
		{
			global2.ingamewars[64].fortnight_go++;
			if (global2.ingamewars[64].infl1 >= 1000 || global2.ingamewars[64].infl2 <= 0)
			{
				global2.ingamewars[64].infl1 = 1000;
				global2.ingamewars[64].infl2 = 0;
			}
			else if (global2.ingamewars[64].infl2 >= 1000 || global2.ingamewars[64].infl1 <= 0)
			{
				global2.ingamewars[64].infl2 = 1000;
				global2.ingamewars[64].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[64].infl1 > 0)
				{
					global2.ingamewars[64].infl1 += 10;
				}
				if (global2.ingamewars[64].infl2 < 1000)
				{
					global2.ingamewars[64].infl2 -= 10;
				}
			}
		}
		if (global2.ingamewars[65].is_going)
		{
			global2.ingamewars[65].fortnight_go++;
			if (global2.ingamewars[65].infl1 >= 1000 || global2.ingamewars[65].infl2 <= 0)
			{
				global2.ingamewars[65].infl1 = 1000;
				global2.ingamewars[65].infl2 = 0;
			}
			else if (global2.ingamewars[65].infl2 >= 1000 || global2.ingamewars[65].infl1 <= 0)
			{
				global2.ingamewars[65].infl2 = 1000;
				global2.ingamewars[65].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[65].infl1 > 0)
				{
					global2.ingamewars[65].infl1 += 10;
				}
				if (global2.ingamewars[65].infl2 < 1000)
				{
					global2.ingamewars[65].infl2 -= 10;
				}
			}
		}
		if (global2.ingamewars[66].is_going)
		{
			global2.ingamewars[66].fortnight_go++;
			if (global2.ingamewars[66].infl1 >= 1000 || global2.ingamewars[66].infl2 <= 0)
			{
				global2.ingamewars[66].infl1 = 1000;
				global2.ingamewars[66].infl2 = 0;
			}
			else if (global2.ingamewars[66].infl2 >= 1000 || global2.ingamewars[66].infl1 <= 0)
			{
				global2.ingamewars[66].infl2 = 1000;
				global2.ingamewars[66].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[66].infl1 > 0)
				{
					global2.ingamewars[66].infl1 += 10;
				}
				if (global2.ingamewars[66].infl2 < 1000)
				{
					global2.ingamewars[66].infl2 -= 10;
				}
			}
		}
		if (global2.ingamewars[67].is_going)
		{
			global2.ingamewars[67].fortnight_go++;
			if (global2.ingamewars[67].infl1 >= 1000 || global2.ingamewars[67].infl2 <= 0)
			{
				global2.ingamewars[67].infl1 = 1000;
				global2.ingamewars[67].infl2 = 0;
			}
			else if (global2.ingamewars[67].infl2 >= 1000 || global2.ingamewars[67].infl1 <= 0)
			{
				global2.ingamewars[67].infl2 = 1000;
				global2.ingamewars[67].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[67].infl1 > 0)
				{
					global2.ingamewars[67].infl1 += 10;
				}
				if (global2.ingamewars[67].infl2 < 1000)
				{
					global2.ingamewars[67].infl2 -= 10;
				}
			}
		}
		if (global2.ingamewars[68].is_going)
		{
			global2.ingamewars[68].fortnight_go++;
			if (global2.ingamewars[68].infl1 >= 1000 || global2.ingamewars[68].infl2 <= 0)
			{
				global2.ingamewars[68].infl1 = 1000;
				global2.ingamewars[68].infl2 = 0;
			}
			else if (global2.ingamewars[68].infl2 >= 1000 || global2.ingamewars[68].infl1 <= 0)
			{
				global2.ingamewars[68].infl2 = 1000;
				global2.ingamewars[68].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[68].infl1 > 0)
				{
					global2.ingamewars[68].infl1++;
				}
				if (global2.ingamewars[68].infl2 < 1000)
				{
					global2.ingamewars[68].infl2--;
				}
			}
		}
		if (global2.ingamewars[69].is_going)
		{
			global2.ingamewars[69].fortnight_go++;
			if (global2.ingamewars[69].infl1 >= 1000 || global2.ingamewars[69].infl2 <= 0)
			{
				global2.ingamewars[69].infl1 = 1000;
				global2.ingamewars[69].infl2 = 0;
			}
			else if (global2.ingamewars[69].infl2 >= 1000 || global2.ingamewars[69].infl1 <= 0)
			{
				global2.ingamewars[69].infl2 = 1000;
				global2.ingamewars[69].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[69].infl1 > 0)
				{
					global2.ingamewars[69].infl1 -= 10;
				}
				if (global2.ingamewars[69].infl2 < 1000)
				{
					global2.ingamewars[69].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[70].is_going)
		{
			global2.ingamewars[70].fortnight_go++;
			if (global2.ingamewars[70].infl1 >= 1000 || global2.ingamewars[70].infl2 <= 0)
			{
				global2.ingamewars[70].infl1 = 1000;
				global2.ingamewars[70].infl2 = 0;
			}
			else if (global2.ingamewars[70].infl2 >= 1000 || global2.ingamewars[70].infl1 <= 0)
			{
				global2.ingamewars[70].infl2 = 1000;
				global2.ingamewars[70].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[70].infl1 > 0)
				{
					global2.ingamewars[70].infl1 -= 10;
				}
				if (global2.ingamewars[70].infl2 < 1000)
				{
					global2.ingamewars[70].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[71].is_going)
		{
			global2.ingamewars[71].fortnight_go++;
			if (global2.ingamewars[71].infl1 >= 1000 || global2.ingamewars[71].infl2 <= 0)
			{
				global2.ingamewars[71].infl1 = 1000;
				global2.ingamewars[71].infl2 = 0;
			}
			else if (global2.ingamewars[71].infl2 >= 1000 || global2.ingamewars[71].infl1 <= 0)
			{
				global2.ingamewars[71].infl2 = 1000;
				global2.ingamewars[71].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[71].infl1 > 0)
				{
					global2.ingamewars[71].infl1 -= 10;
				}
				if (global2.ingamewars[71].infl2 < 1000)
				{
					global2.ingamewars[71].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[72].is_going)
		{
			global2.ingamewars[72].fortnight_go++;
			if (global2.ingamewars[72].infl1 >= 1000 || global2.ingamewars[72].infl2 <= 0)
			{
				global2.ingamewars[72].infl1 = 1000;
				global2.ingamewars[72].infl2 = 0;
			}
			else if (global2.ingamewars[72].infl2 >= 1000 || global2.ingamewars[72].infl1 <= 0)
			{
				global2.ingamewars[72].infl2 = 1000;
				global2.ingamewars[72].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[72].infl1 > 0)
				{
					global2.ingamewars[72].infl1 -= 10;
				}
				if (global2.ingamewars[72].infl2 < 1000)
				{
					global2.ingamewars[72].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[73].is_going)
		{
			global2.ingamewars[73].fortnight_go++;
			if (global2.ingamewars[73].infl1 >= 1000 || global2.ingamewars[73].infl2 <= 0)
			{
				global2.ingamewars[73].infl1 = 1000;
				global2.ingamewars[73].infl2 = 0;
			}
			else if (global2.ingamewars[73].infl2 >= 1000 || global2.ingamewars[73].infl1 <= 0)
			{
				global2.ingamewars[73].infl2 = 1000;
				global2.ingamewars[73].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[73].infl1 > 0)
				{
					global2.ingamewars[73].infl1 -= 10;
				}
				if (global2.ingamewars[73].infl2 < 1000)
				{
					global2.ingamewars[73].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[74].is_going)
		{
			global2.ingamewars[74].fortnight_go++;
			if (global2.ingamewars[74].infl1 >= 1000 || global2.ingamewars[74].infl2 <= 0)
			{
				global2.ingamewars[74].infl1 = 1000;
				global2.ingamewars[74].infl2 = 0;
			}
			else if (global2.ingamewars[74].infl2 >= 1000 || global2.ingamewars[74].infl1 <= 0)
			{
				global2.ingamewars[74].infl2 = 1000;
				global2.ingamewars[74].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[74].infl1 > 0)
				{
					global2.ingamewars[74].infl1 -= 10;
				}
				if (global2.ingamewars[74].infl2 < 1000)
				{
					global2.ingamewars[74].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[75].is_going)
		{
			global2.ingamewars[75].fortnight_go++;
			if (global2.ingamewars[75].infl1 >= 1000 || global2.ingamewars[75].infl2 <= 0)
			{
				global2.ingamewars[75].infl1 = 1000;
				global2.ingamewars[75].infl2 = 0;
			}
			else if (global2.ingamewars[75].infl2 >= 1000 || global2.ingamewars[75].infl1 <= 0)
			{
				global2.ingamewars[75].infl2 = 1000;
				global2.ingamewars[75].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[75].infl1 > 0)
				{
					global2.ingamewars[75].infl1 -= 10;
				}
				if (global2.ingamewars[75].infl2 < 1000)
				{
					global2.ingamewars[75].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[76].is_going)
		{
			global2.ingamewars[76].fortnight_go++;
			if (global2.ingamewars[76].infl1 >= 1000 || global2.ingamewars[76].infl2 <= 0)
			{
				global2.ingamewars[76].infl1 = 1000;
				global2.ingamewars[76].infl2 = 0;
			}
			else if (global2.ingamewars[76].infl2 >= 1000 || global2.ingamewars[76].infl1 <= 0)
			{
				global2.ingamewars[76].infl2 = 1000;
				global2.ingamewars[76].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[76].infl1 > 0)
				{
					global2.ingamewars[76].infl1 -= 10;
				}
				if (global2.ingamewars[76].infl2 < 1000)
				{
					global2.ingamewars[76].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[77].is_going)
		{
			global2.ingamewars[77].fortnight_go++;
			if (global2.ingamewars[77].infl1 >= 1000 || global2.ingamewars[77].infl2 <= 0)
			{
				global2.ingamewars[77].infl1 = 1000;
				global2.ingamewars[77].infl2 = 0;
			}
			else if (global2.ingamewars[77].infl2 >= 1000 || global2.ingamewars[77].infl1 <= 0)
			{
				global2.ingamewars[77].infl2 = 1000;
				global2.ingamewars[77].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[77].infl1 > 0)
				{
					global2.ingamewars[77].infl1 -= 4;
				}
				if (global2.ingamewars[77].infl2 < 1000)
				{
					global2.ingamewars[77].infl2 += 4;
				}
			}
		}
		if (global2.ingamewars[78].is_going)
		{
			global2.ingamewars[78].fortnight_go++;
			if (global2.ingamewars[78].infl1 >= 1000 || global2.ingamewars[78].infl2 <= 0)
			{
				global2.ingamewars[78].infl1 = 1000;
				global2.ingamewars[78].infl2 = 0;
			}
			else if (global2.ingamewars[78].infl2 >= 1000 || global2.ingamewars[78].infl1 <= 0)
			{
				global2.ingamewars[78].infl2 = 1000;
				global2.ingamewars[78].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[78].infl1 > 0)
				{
					global2.ingamewars[78].infl1 -= 2;
				}
				if (global2.ingamewars[78].infl2 < 1000)
				{
					global2.ingamewars[78].infl2 += 2;
				}
			}
		}
		if (global2.ingamewars[79].is_going)
		{
			global2.ingamewars[79].fortnight_go++;
			if (global2.ingamewars[79].infl1 >= 1000 || global2.ingamewars[79].infl2 <= 0)
			{
				global2.ingamewars[79].infl1 = 1000;
				global2.ingamewars[79].infl2 = 0;
			}
			else if (global2.ingamewars[79].infl2 >= 1000 || global2.ingamewars[79].infl1 <= 0)
			{
				global2.ingamewars[79].infl2 = 1000;
				global2.ingamewars[79].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[79].infl1 > 0)
				{
					global2.ingamewars[79].infl1 -= 4;
				}
				if (global2.ingamewars[79].infl2 < 1000)
				{
					global2.ingamewars[79].infl2 += 4;
				}
			}
		}
		if (global2.ingamewars[80].is_going)
		{
			global2.ingamewars[80].fortnight_go++;
			if (global2.ingamewars[80].infl1 >= 1000 || global2.ingamewars[80].infl2 <= 0)
			{
				global2.ingamewars[80].infl1 = 1000;
				global2.ingamewars[80].infl2 = 0;
			}
			else if (global2.ingamewars[80].infl2 >= 1000 || global2.ingamewars[80].infl1 <= 0)
			{
				global2.ingamewars[80].infl2 = 1000;
				global2.ingamewars[80].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[80].infl1 > 0)
				{
					global2.ingamewars[80].infl1 -= 4;
				}
				if (global2.ingamewars[80].infl2 < 1000)
				{
					global2.ingamewars[80].infl2 += 4;
				}
			}
		}
		if (global2.ingamewars[81].is_going)
		{
			global2.ingamewars[81].fortnight_go++;
			if (global2.ingamewars[81].infl1 >= 1000 || global2.ingamewars[81].infl2 <= 0)
			{
				global2.ingamewars[81].infl1 = 1000;
				global2.ingamewars[81].infl2 = 0;
			}
			else if (global2.ingamewars[81].infl2 >= 1000 || global2.ingamewars[81].infl1 <= 0)
			{
				global2.ingamewars[81].infl2 = 1000;
				global2.ingamewars[81].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[81].infl1 > 0)
				{
					global2.ingamewars[81].infl1 -= 4;
				}
				if (global2.ingamewars[81].infl2 < 1000)
				{
					global2.ingamewars[81].infl2 += 4;
				}
			}
		}
		if (global2.ingamewars[82].is_going)
		{
			global2.ingamewars[82].fortnight_go++;
			if (global2.ingamewars[82].infl1 >= 1000 || global2.ingamewars[82].infl2 <= 0)
			{
				global2.ingamewars[82].infl1 = 1000;
				global2.ingamewars[82].infl2 = 0;
			}
			else if (global2.ingamewars[82].infl2 >= 1000 || global2.ingamewars[82].infl1 <= 0)
			{
				global2.ingamewars[82].infl2 = 1000;
				global2.ingamewars[82].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[82].infl1 > 0)
				{
					global2.ingamewars[82].infl1 -= 2;
				}
				if (global2.ingamewars[82].infl2 < 1000)
				{
					global2.ingamewars[82].infl2 += 2;
				}
			}
		}
		if (global2.ingamewars[83].is_going)
		{
			global2.ingamewars[83].fortnight_go++;
			if (global2.ingamewars[83].infl1 >= 1000 || global2.ingamewars[83].infl2 <= 0)
			{
				global2.ingamewars[83].infl1 = 1000;
				global2.ingamewars[83].infl2 = 0;
			}
			else if (global2.ingamewars[83].infl2 >= 1000 || global2.ingamewars[83].infl1 <= 0)
			{
				global2.ingamewars[83].infl2 = 1000;
				global2.ingamewars[83].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[83].infl1 > 0)
				{
					global2.ingamewars[83].infl1 -= 2;
				}
				if (global2.ingamewars[83].infl2 < 1000)
				{
					global2.ingamewars[83].infl2 += 2;
				}
			}
		}
		if (global2.ingamewars[85].is_going)
		{
			int num = 0;
			num = (((global2.allcountries[63].Gosstroy != 2 && !global2.IsSocialism(yes: true, 63)) || !global2.allcountries[63].proprc) ? (num - 10) : (num + 10));
			num = (((global2.allcountries[64].Gosstroy != 2 && !global2.IsSocialism(yes: true, 64)) || !global2.allcountries[64].proprc) ? (num - 10) : (num + 10));
			num = (((global2.allcountries[108].Gosstroy != 2 && !global2.IsSocialism(yes: true, 108)) || !global2.allcountries[108].proprc) ? (num - 10) : (num + 10));
			global2.ingamewars[85].fortnight_go++;
			if (global2.ingamewars[85].infl1 >= 1000 || global2.ingamewars[85].infl2 <= 0)
			{
				global2.ingamewars[85].infl1 = 1000;
				global2.ingamewars[85].infl2 = 0;
			}
			else if (global2.ingamewars[85].infl2 >= 1000 || global2.ingamewars[85].infl1 <= 0)
			{
				global2.ingamewars[85].infl2 = 1000;
				global2.ingamewars[85].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[85].infl1 > 0)
				{
					global2.ingamewars[85].infl1 -= num;
				}
				if (global2.ingamewars[85].infl2 < 1000)
				{
					global2.ingamewars[85].infl2 += num;
				}
			}
		}
		if (global2.ingamewars[14].is_going)
		{
			global2.ingamewars[14].fortnight_go++;
			if (global2.ingamewars[14].infl1 >= 1000 || global2.ingamewars[14].infl2 <= 0)
			{
				global2.ingamewars[14].infl1 = 1000;
				global2.ingamewars[14].infl2 = 0;
			}
			else if (global2.ingamewars[14].infl2 >= 1000 || global2.ingamewars[14].infl1 <= 0)
			{
				global2.ingamewars[14].infl2 = 1000;
				global2.ingamewars[14].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[14].ussr_place != 1)
				{
					if (global2.ingamewars[14].infl1 > 0)
					{
						global2.ingamewars[14].infl1 += 5;
					}
					if (global2.ingamewars[14].infl2 < 1000)
					{
						global2.ingamewars[14].infl2 -= 5;
					}
				}
				else
				{
					if (global2.ingamewars[14].infl1 > 0)
					{
						global2.ingamewars[14].infl1 -= 5;
					}
					if (global2.ingamewars[14].infl2 < 1000)
					{
						global2.ingamewars[14].infl2 += 5;
					}
				}
				if (global2.allcountries[94].isNATO)
				{
					if (global2.ingamewars[14].infl1 > 0)
					{
						global2.ingamewars[14].infl1 -= 5;
					}
					if (global2.ingamewars[14].infl2 < 1000)
					{
						global2.ingamewars[14].infl2 += 7;
					}
				}
				else
				{
					if (global2.ingamewars[14].infl1 > 0)
					{
						global2.ingamewars[14].infl1 += 4;
					}
					if (global2.ingamewars[14].infl2 < 1000)
					{
						global2.ingamewars[14].infl2 -= 4;
					}
				}
				if (global2.ingamewars[14].infl1 > 0)
				{
					global2.ingamewars[14].infl1 += 7;
				}
				if (global2.ingamewars[14].infl2 < 1000)
				{
					global2.ingamewars[14].infl2 -= 7;
				}
			}
		}
		if (global2.ingamewars[15].is_going)
		{
			global2.ingamewars[15].fortnight_go++;
			if (global2.ingamewars[15].infl1 >= 1000 || global2.ingamewars[15].infl2 <= 0)
			{
				global2.ingamewars[15].infl1 = 1000;
				global2.ingamewars[15].infl2 = 0;
			}
			else if (global2.ingamewars[15].infl2 >= 1000 || global2.ingamewars[15].infl1 <= 0)
			{
				global2.ingamewars[15].infl2 = 1000;
				global2.ingamewars[15].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[15].infl1 > 0)
				{
					global2.ingamewars[15].infl1 -= 3;
				}
				if (global2.ingamewars[15].infl2 < 1000)
				{
					global2.ingamewars[15].infl2 += 3;
				}
			}
		}
		if (global2.ingamewars[16].is_going)
		{
			global2.ingamewars[16].fortnight_go++;
			if (global2.ingamewars[16].infl1 >= 1000 || global2.ingamewars[16].infl2 <= 0)
			{
				global2.ingamewars[16].infl1 = 1000;
				global2.ingamewars[16].infl2 = 0;
			}
			else if (global2.ingamewars[16].infl2 >= 1000 || global2.ingamewars[16].infl1 <= 0)
			{
				global2.ingamewars[16].infl2 = 1000;
				global2.ingamewars[16].infl1 = 0;
			}
			else
			{
				int num2 = 0;
				if (global2.guns)
				{
					num2 = 3;
				}
				if (global2.ingamewars[16].infl2 < 1000)
				{
					global2.ingamewars[16].infl2 += 7;
					global2.ingamewars[16].infl2 += num2;
					global2.ingamewars[16].infl1 -= 7;
					global2.ingamewars[16].infl1 -= num2;
				}
			}
		}
		if (global2.ingamewars[17].is_going)
		{
			global2.ingamewars[17].fortnight_go++;
			if (global2.ingamewars[17].infl1 >= 1000 || global2.ingamewars[17].infl2 <= 0)
			{
				global2.ingamewars[17].infl1 = 1000;
				global2.ingamewars[17].infl2 = 0;
			}
			else if (global2.ingamewars[17].infl2 >= 1000 || global2.ingamewars[17].infl1 <= 0)
			{
				global2.ingamewars[17].infl2 = 1000;
				global2.ingamewars[17].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[15].infl1 > 0)
				{
					global2.ingamewars[15].infl1 -= 8;
				}
				if (global2.ingamewars[15].infl2 < 1000)
				{
					global2.ingamewars[15].infl2 += 8;
				}
			}
		}
		if (global2.ingamewars[18].is_going)
		{
			global2.ingamewars[18].fortnight_go++;
			if (global2.ingamewars[18].infl1 >= 1000 || global2.ingamewars[18].infl2 <= 0)
			{
				global2.ingamewars[18].infl1 = 1000;
				global2.ingamewars[18].infl2 = 0;
			}
			else if (global2.ingamewars[18].infl2 >= 1000 || global2.ingamewars[18].infl1 <= 0)
			{
				global2.ingamewars[18].infl2 = 1000;
				global2.ingamewars[18].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[18].infl1 > 0 && global2.resultOfEvents[382] == 0)
				{
					global2.ingamewars[18].infl1 -= 15;
				}
				else
				{
					global2.ingamewars[18].infl1 -= 25;
				}
				if (global2.ingamewars[18].infl2 < 1000 && global2.resultOfEvents[382] == 1)
				{
					global2.ingamewars[18].infl2 += 15;
				}
				else
				{
					global2.ingamewars[18].infl2 += 25;
				}
			}
		}
		if (global2.ingamewars[19].is_going)
		{
			global2.ingamewars[19].fortnight_go++;
			if (global2.ingamewars[19].infl1 >= 1000 || global2.ingamewars[19].infl2 <= 0)
			{
				global2.ingamewars[19].infl1 = 1000;
				global2.ingamewars[19].infl2 = 0;
			}
			else if (global2.ingamewars[19].infl2 >= 1000 || global2.ingamewars[19].infl1 <= 0)
			{
				global2.ingamewars[19].infl2 = 1000;
				global2.ingamewars[19].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[19].infl1 > 0 && global2.ingamewars[19].usa_place == 1 && global2.ingamewars[19].ussr_place == 1)
				{
					global2.ingamewars[19].infl1 -= 25;
				}
				else
				{
					global2.ingamewars[19].infl1 -= 2;
				}
				if (global2.ingamewars[19].infl2 < 1000 && global2.ingamewars[19].usa_place == 1 && global2.ingamewars[19].ussr_place == 1)
				{
					global2.ingamewars[19].infl2 += 25;
				}
				else
				{
					global2.ingamewars[19].infl2 += 2;
				}
			}
		}
		if (global2.ingamewars[20].is_going)
		{
			global2.ingamewars[20].fortnight_go++;
			if (global2.ingamewars[20].infl1 >= 1000 || global2.ingamewars[20].infl2 <= 0)
			{
				global2.ingamewars[20].infl1 = 1000;
				global2.ingamewars[20].infl2 = 0;
			}
			else if (global2.ingamewars[20].infl2 >= 1000 || global2.ingamewars[20].infl1 <= 0)
			{
				global2.ingamewars[20].infl2 = 1000;
				global2.ingamewars[20].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[20].infl1 > 0)
				{
					global2.ingamewars[20].infl1++;
				}
				if (global2.ingamewars[20].infl2 < 1000)
				{
					global2.ingamewars[20].infl2--;
				}
			}
		}
		if (global2.ingamewars[21].is_going)
		{
			global2.ingamewars[21].fortnight_go++;
			if (global2.ingamewars[21].infl1 >= 1000 || global2.ingamewars[21].infl2 <= 0)
			{
				global2.ingamewars[21].infl1 = 1000;
				global2.ingamewars[21].infl2 = 0;
			}
			else if (global2.ingamewars[21].infl2 >= 1000 || global2.ingamewars[21].infl1 <= 0)
			{
				global2.ingamewars[21].infl2 = 1000;
				global2.ingamewars[21].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[21].infl1 > 0)
				{
					global2.ingamewars[21].infl1 -= 5;
				}
				if (global2.ingamewars[21].infl2 < 1000)
				{
					global2.ingamewars[21].infl2 += 5;
				}
			}
		}
		if (global2.ingamewars[22].is_going)
		{
			global2.ingamewars[22].fortnight_go++;
			if (global2.ingamewars[22].infl1 >= 1000 || global2.ingamewars[22].infl2 <= 0)
			{
				global2.ingamewars[22].infl1 = 1000;
				global2.ingamewars[22].infl2 = 0;
			}
			else if (global2.ingamewars[22].infl2 >= 1000 || global2.ingamewars[22].infl1 <= 0)
			{
				global2.ingamewars[22].infl2 = 1000;
				global2.ingamewars[22].infl1 = 0;
			}
			else if (global2.ingamewars[22].infl2 < 1000)
			{
				if (global2.ingamewars[22].usa_place == 0)
				{
					global2.ingamewars[22].infl2 += 15;
					global2.ingamewars[22].infl1 -= 15;
				}
				else
				{
					global2.ingamewars[22].infl2 += 25;
					global2.ingamewars[22].infl1 -= 25;
				}
			}
		}
		if (global2.ingamewars[23].is_going)
		{
			global2.ingamewars[23].fortnight_go++;
			if (global2.ingamewars[23].infl1 >= 1000 || global2.ingamewars[23].infl2 <= 0)
			{
				global2.ingamewars[23].infl1 = 1000;
				global2.ingamewars[23].infl2 = 0;
			}
			else if (global2.ingamewars[23].infl2 >= 1000 || global2.ingamewars[23].infl1 <= 0)
			{
				global2.ingamewars[23].infl2 = 1000;
				global2.ingamewars[23].infl1 = 0;
			}
			else if (global2.ingamewars[23].infl2 < 1000)
			{
				if (global2.ingamewars[23].ussr_place == 1)
				{
					global2.ingamewars[23].infl2 += 20;
					global2.ingamewars[23].infl1 -= 20;
				}
				else
				{
					global2.ingamewars[23].infl2 += 15;
					global2.ingamewars[23].infl1 -= 15;
				}
			}
		}
		if (global2.ingamewars[24].is_going)
		{
			global2.ingamewars[24].fortnight_go++;
			if (global2.ingamewars[24].infl1 >= 1000 || global2.ingamewars[24].infl2 <= 0)
			{
				global2.ingamewars[24].infl1 = 1000;
				global2.ingamewars[24].infl2 = 0;
			}
			else if (global2.ingamewars[24].infl2 >= 1000 || global2.ingamewars[24].infl1 <= 0)
			{
				global2.ingamewars[24].infl2 = 1000;
				global2.ingamewars[24].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[24].infl1 > 0)
				{
					global2.ingamewars[24].infl1 += 5;
				}
				if (global2.ingamewars[24].infl2 < 1000)
				{
					global2.ingamewars[24].infl2 -= 5;
				}
			}
		}
		if (global2.ingamewars[25].is_going)
		{
			global2.ingamewars[25].fortnight_go++;
			if (global2.ingamewars[25].infl1 >= 1000 || global2.ingamewars[25].infl2 <= 0)
			{
				global2.ingamewars[25].infl1 = 1000;
				global2.ingamewars[25].infl2 = 0;
			}
			else if (global2.ingamewars[25].infl2 >= 1000 || global2.ingamewars[25].infl1 <= 0)
			{
				global2.ingamewars[25].infl2 = 1000;
				global2.ingamewars[25].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[25].infl1 > 0)
				{
					global2.ingamewars[25].infl1 += 5;
				}
				if (global2.ingamewars[25].infl2 < 1000)
				{
					global2.ingamewars[25].infl2 -= 5;
				}
			}
		}
		if (global2.ingamewars[26].is_going)
		{
			global2.ingamewars[26].fortnight_go++;
			if (global2.ingamewars[26].infl1 >= 1000 || global2.ingamewars[26].infl2 <= 0)
			{
				global2.ingamewars[26].infl1 = 1000;
				global2.ingamewars[26].infl2 = 0;
			}
			else if (global2.ingamewars[26].infl2 >= 1000 || global2.ingamewars[26].infl1 <= 0)
			{
				global2.ingamewars[26].infl2 = 1000;
				global2.ingamewars[26].infl1 = 0;
			}
			else if (global2.event_done[434])
			{
				if (global2.ingamewars[26].infl1 > 2)
				{
					global2.ingamewars[26].infl1 += 2;
				}
				if (global2.ingamewars[26].infl2 < 999)
				{
					global2.ingamewars[26].infl2 -= 2;
				}
			}
			else
			{
				if (global2.ingamewars[26].infl1 > 5)
				{
					global2.ingamewars[26].infl1 += 5;
				}
				if (global2.ingamewars[26].infl2 < 996)
				{
					global2.ingamewars[26].infl2 -= 5;
				}
			}
		}
		if (global2.ingamewars[27].is_going)
		{
			global2.ingamewars[27].fortnight_go++;
			if (global2.ingamewars[27].infl1 >= 1000 || global2.ingamewars[27].infl2 <= 0)
			{
				global2.ingamewars[27].infl1 = 1000;
				global2.ingamewars[27].infl2 = 0;
			}
			else if (global2.ingamewars[27].infl2 >= 1000 || global2.ingamewars[27].infl1 <= 0)
			{
				global2.ingamewars[27].infl2 = 1000;
				global2.ingamewars[27].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[27].infl1 > 0)
				{
					global2.ingamewars[27].infl1 += 5;
				}
				if (global2.ingamewars[27].infl2 < 1000)
				{
					global2.ingamewars[27].infl2 -= 5;
				}
			}
		}
		if (global2.ingamewars[28].is_going)
		{
			global2.ingamewars[28].fortnight_go++;
			if (global2.ingamewars[28].infl1 >= 1000 || global2.ingamewars[28].infl2 <= 0)
			{
				global2.ingamewars[28].infl1 = 1000;
				global2.ingamewars[28].infl2 = 0;
			}
			else if (global2.ingamewars[28].infl2 >= 1000 || global2.ingamewars[28].infl1 <= 0)
			{
				global2.ingamewars[28].infl2 = 1000;
				global2.ingamewars[28].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[28].infl1 > 0)
				{
					global2.ingamewars[28].infl1 -= 5;
				}
				if (global2.ingamewars[28].infl2 < 1000)
				{
					global2.ingamewars[28].infl2 += 5;
				}
			}
		}
		if (global2.ingamewars[29].is_going)
		{
			global2.ingamewars[29].fortnight_go++;
			if (global2.ingamewars[29].infl1 >= 1000 || global2.ingamewars[29].infl2 <= 0)
			{
				global2.ingamewars[29].infl1 = 1000;
				global2.ingamewars[29].infl2 = 0;
			}
			else if (global2.ingamewars[29].infl2 >= 1000 || global2.ingamewars[29].infl1 <= 0)
			{
				global2.ingamewars[29].infl2 = 1000;
				global2.ingamewars[29].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[29].infl1 > 0)
				{
					global2.ingamewars[29].infl1 -= 10;
				}
				if (global2.ingamewars[29].infl2 < 1000)
				{
					global2.ingamewars[29].infl2 += 10;
				}
				if (global2.ingamewars[29].ussr_place == 1 && global2.ingamewars[29].usa_place == 1)
				{
					if (global2.ingamewars[29].infl1 > 0)
					{
						global2.ingamewars[29].infl1 -= 20;
					}
					if (global2.ingamewars[29].infl2 < 1000)
					{
						global2.ingamewars[29].infl2 += 20;
					}
				}
			}
		}
		if (global2.ingamewars[30].is_going)
		{
			global2.ingamewars[30].fortnight_go++;
			if (global2.ingamewars[30].infl1 >= 1000 || global2.ingamewars[30].infl2 <= 0)
			{
				global2.ingamewars[30].infl1 = 1000;
				global2.ingamewars[30].infl2 = 0;
			}
			else if (global2.ingamewars[30].infl2 >= 1000 || global2.ingamewars[30].infl1 <= 0)
			{
				global2.ingamewars[30].infl2 = 1000;
				global2.ingamewars[30].infl1 = 0;
			}
			else if (global2.ingamewars[30].infl1 > 900)
			{
				global2.ingamewars[30].infl1 -= 50;
				global2.ingamewars[30].infl2 += 50;
			}
			else if (global2.ingamewars[30].infl1 > 800)
			{
				global2.ingamewars[30].infl1 -= 30;
				global2.ingamewars[30].infl2 += 30;
			}
			else if (global2.ingamewars[30].infl1 > 700)
			{
				global2.ingamewars[30].infl1 -= 20;
				global2.ingamewars[30].infl2 += 20;
			}
			else if (global2.ingamewars[30].infl1 > 600)
			{
				global2.ingamewars[30].infl1 -= 10;
				global2.ingamewars[30].infl2 += 10;
			}
			else if (global2.ingamewars[30].infl2 > 900)
			{
				global2.ingamewars[30].infl2 -= 50;
				global2.ingamewars[30].infl1 += 50;
			}
			else if (global2.ingamewars[30].infl2 > 800)
			{
				global2.ingamewars[30].infl2 -= 30;
				global2.ingamewars[30].infl1 += 30;
			}
			else if (global2.ingamewars[30].infl2 > 700)
			{
				global2.ingamewars[30].infl2 -= 20;
				global2.ingamewars[30].infl1 += 20;
			}
			else if (global2.ingamewars[30].infl2 > 600)
			{
				global2.ingamewars[30].infl2 -= 10;
				global2.ingamewars[30].infl1 += 10;
			}
			else
			{
				if (global2.ingamewars[30].infl1 < 1000)
				{
					global2.ingamewars[30].infl1 -= 5;
				}
				if (global2.ingamewars[30].infl2 < 1000)
				{
					global2.ingamewars[30].infl2 += 5;
				}
			}
		}
		if (global2.ingamewars[31].is_going)
		{
			global2.ingamewars[31].fortnight_go++;
			if (global2.ingamewars[31].infl1 >= 1000 || global2.ingamewars[31].infl2 <= 0)
			{
				global2.ingamewars[31].infl1 = 1000;
				global2.ingamewars[31].infl2 = 0;
			}
			else if (global2.ingamewars[31].infl2 >= 1000 || global2.ingamewars[31].infl1 <= 0)
			{
				global2.ingamewars[31].infl2 = 1000;
				global2.ingamewars[31].infl1 = 0;
			}
			else if (global2.ingamewars[30].is_going)
			{
				if (global2.ingamewars[31].infl1 > 0)
				{
					global2.ingamewars[31].infl1 -= 5;
				}
				if (global2.ingamewars[31].infl2 < 1000)
				{
					global2.ingamewars[31].infl2 += 5;
				}
			}
			else
			{
				if (global2.ingamewars[31].infl1 > 0)
				{
					global2.ingamewars[31].infl1 -= 15;
				}
				if (global2.ingamewars[31].infl2 < 1000)
				{
					global2.ingamewars[31].infl2 += 15;
				}
			}
		}
		if (global2.ingamewars[32].is_going)
		{
			global2.ingamewars[32].fortnight_go++;
			if (global2.ingamewars[32].infl1 >= 1000 || global2.ingamewars[32].infl2 <= 0)
			{
				global2.ingamewars[32].infl1 = 1000;
				global2.ingamewars[32].infl2 = 0;
			}
			else if (global2.ingamewars[32].infl2 >= 1000 || global2.ingamewars[32].infl1 <= 0)
			{
				global2.ingamewars[32].infl2 = 1000;
				global2.ingamewars[32].infl1 = 0;
			}
			else if (global2.ingamewars[30].is_going)
			{
				if (global2.ingamewars[32].infl1 > 0)
				{
					global2.ingamewars[32].infl1 -= 5;
				}
				if (global2.ingamewars[32].infl2 < 1000)
				{
					global2.ingamewars[32].infl2 += 5;
				}
			}
			else
			{
				if (global2.ingamewars[32].infl1 > 0)
				{
					global2.ingamewars[32].infl1 -= 15;
				}
				if (global2.ingamewars[32].infl2 < 1000)
				{
					global2.ingamewars[32].infl2 += 15;
				}
			}
		}
		if (global2.ingamewars[33].is_going)
		{
			global2.ingamewars[33].fortnight_go++;
			if (global2.ingamewars[33].infl1 >= 1000 || global2.ingamewars[33].infl2 <= 0)
			{
				global2.ingamewars[33].infl1 = 1000;
				global2.ingamewars[33].infl2 = 0;
			}
			else if (global2.ingamewars[33].infl2 >= 1000 || global2.ingamewars[33].infl1 <= 0)
			{
				global2.ingamewars[33].infl2 = 1000;
				global2.ingamewars[33].infl1 = 0;
			}
			if (global2.ingamewars[33].infl1 > 0)
			{
				global2.ingamewars[33].infl1 -= 3;
			}
			if (global2.ingamewars[33].infl2 < 1000)
			{
				global2.ingamewars[33].infl2 += 3;
			}
		}
		if (global2.ingamewars[34].is_going)
		{
			global2.ingamewars[34].fortnight_go++;
			if (global2.ingamewars[34].infl1 >= 1000 || global2.ingamewars[34].infl2 <= 0)
			{
				global2.ingamewars[34].infl1 = 1000;
				global2.ingamewars[34].infl2 = 0;
			}
			else if (global2.ingamewars[34].infl2 >= 1000 || global2.ingamewars[34].infl1 <= 0)
			{
				global2.ingamewars[34].infl2 = 1000;
				global2.ingamewars[34].infl1 = 0;
			}
			if (global2.ingamewars[34].infl1 > 0)
			{
				global2.ingamewars[34].infl1 -= 20;
			}
			if (global2.ingamewars[34].infl2 < 1000)
			{
				global2.ingamewars[34].infl2 += 20;
			}
		}
		if (global2.ingamewars[35].is_going)
		{
			global2.ingamewars[35].fortnight_go++;
			if (global2.ingamewars[35].infl1 >= 1000 || global2.ingamewars[35].infl2 <= 0)
			{
				global2.ingamewars[35].infl1 = 1000;
				global2.ingamewars[35].infl2 = 0;
			}
			else if (global2.ingamewars[35].infl2 >= 1000 || global2.ingamewars[35].infl1 <= 0)
			{
				global2.ingamewars[35].infl2 = 1000;
				global2.ingamewars[35].infl1 = 0;
			}
			if (global2.ingamewars[35].infl1 > 0)
			{
				global2.ingamewars[35].infl1 -= 20;
			}
			if (global2.ingamewars[35].infl2 < 1000)
			{
				global2.ingamewars[35].infl2 += 20;
			}
		}
		if (global2.allcountries[7].isNATO)
		{
			for (int i = 0; i < global2.ingamewars.Length; i++)
			{
				if (global2.ingamewars[i].is_going && global2.ingamewars[i].infl1 <= 1000 && global2.ingamewars[i].infl2 <= 1000 && i != 5)
				{
					if (global2.ingamewars[i].usa_place == 1 && global2.ingamewars[i].ussr_place == 1)
					{
						global2.ingamewars[i].infl2 += 25;
						global2.ingamewars[i].infl1 -= 25;
					}
					else if (global2.ingamewars[i].usa_place == 0 && global2.ingamewars[i].ussr_place == 0)
					{
						global2.ingamewars[i].infl2 -= 25;
						global2.ingamewars[i].infl1 += 25;
					}
				}
			}
		}
		if (global2.ingamewars[4].is_going)
		{
			if (!global2.event_done[371])
			{
				global2.ingamewars[4].fortnight_go++;
				if (global2.ingamewars[4].infl1 >= 1000 || global2.ingamewars[4].infl2 <= 0)
				{
					global2.ingamewars[4].infl1 = 1000;
					global2.ingamewars[4].infl2 = 0;
				}
				else if (global2.ingamewars[4].infl2 >= 1000 || global2.ingamewars[4].infl1 <= 0)
				{
					global2.ingamewars[4].infl2 = 1000;
					global2.ingamewars[4].infl1 = 0;
				}
				else
				{
					if (global2.ingamewars[4].infl1 > 0)
					{
						global2.ingamewars[4].infl1 += 5;
					}
					if (global2.ingamewars[4].infl2 < 1000)
					{
						global2.ingamewars[4].infl2 -= 5;
					}
				}
			}
			else
			{
				global2.ingamewars[4].fortnight_go++;
				if (global2.ingamewars[4].infl1 >= 1000 || global2.ingamewars[4].infl2 <= 0)
				{
					global2.ingamewars[4].infl1 = 1000;
					global2.ingamewars[4].infl2 = 0;
				}
				else if (global2.ingamewars[4].infl2 >= 1000 || global2.ingamewars[4].infl1 <= 0)
				{
					global2.ingamewars[4].infl2 = 1000;
					global2.ingamewars[4].infl1 = 0;
				}
				else
				{
					if (global2.ingamewars[4].infl1 > 0)
					{
						global2.ingamewars[4].infl1 += 20;
					}
					if (global2.ingamewars[4].infl2 < 1000)
					{
						global2.ingamewars[4].infl2 -= 20;
					}
				}
			}
		}
		if (global2.ingamewars[6].is_going)
		{
			global2.ingamewars[6].fortnight_go++;
			if (global2.ingamewars[6].infl1 >= 1000 || global2.ingamewars[6].infl2 <= 0)
			{
				global2.ingamewars[6].infl1 = 1000;
				global2.ingamewars[6].infl2 = 0;
			}
			else if (global2.ingamewars[6].infl2 >= 1000 || global2.ingamewars[6].infl1 <= 0)
			{
				global2.ingamewars[6].infl2 = 1000;
				global2.ingamewars[6].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[6].infl1 < 1000)
				{
					global2.ingamewars[6].infl1 -= 10;
				}
				if (global2.ingamewars[6].infl2 > 0)
				{
					global2.ingamewars[6].infl2 += 10;
				}
			}
		}
		if (global2.ingamewars[2].is_going)
		{
			global2.ingamewars[2].fortnight_go++;
			if (global2.ingamewars[2].infl1 >= 1000 || global2.ingamewars[2].infl2 <= 0)
			{
				global2.ingamewars[2].infl1 = 1000;
				global2.ingamewars[2].infl2 = 0;
			}
			else if (global2.ingamewars[2].infl2 >= 1000 || global2.ingamewars[2].infl1 <= 0)
			{
				global2.ingamewars[2].infl2 = 1000;
				global2.ingamewars[2].infl1 = 0;
			}
			else
			{
				if (global2.ingamewars[2].infl1 < 1000)
				{
					global2.ingamewars[2].infl1 -= 5;
				}
				if (global2.ingamewars[2].infl1 > 0)
				{
					global2.ingamewars[2].infl2 += 5;
				}
			}
		}
		if (global2.ingamewars[3].is_going)
		{
			global2.ingamewars[3].fortnight_go++;
			if (global2.ingamewars[3].infl1 >= 1000 || global2.ingamewars[3].infl2 <= 0)
			{
				global2.ingamewars[3].infl1 = 1000;
				global2.ingamewars[3].infl2 = 0;
			}
			else if (global2.ingamewars[3].infl2 >= 1000 || global2.ingamewars[3].infl1 <= 0)
			{
				global2.ingamewars[3].infl2 = 1000;
				global2.ingamewars[3].infl1 = 0;
			}
			else if (global2.data[21] < 1982)
			{
				if (global2.ingamewars[3].infl1 < 1000)
				{
					global2.ingamewars[3].infl1--;
				}
				if (global2.ingamewars[3].infl2 > 0)
				{
					global2.ingamewars[3].infl2++;
				}
			}
			else if (!global2.event_done[450])
			{
				if (global2.ingamewars[3].infl1 > 0)
				{
					global2.ingamewars[3].infl1++;
				}
				if (global2.ingamewars[3].infl2 < 1000)
				{
					global2.ingamewars[3].infl2--;
				}
			}
			else if (global2.event_done[450] && global2.resultOfEvents[450] == 0)
			{
				if (global2.ingamewars[3].infl1 > 0)
				{
					warinwars obj = global2.ingamewars[3];
					int infl = obj.infl1;
					obj.infl1 = infl + 60;
				}
				if (global2.ingamewars[3].infl2 < 1000)
				{
					warinwars obj2 = global2.ingamewars[3];
					int infl = obj2.infl2;
					obj2.infl2 = infl - 60;
				}
			}
			else if (global2.event_done[450] && global2.resultOfEvents[450] == 1)
			{
				if (global2.ingamewars[3].infl1 > 0)
				{
					warinwars obj3 = global2.ingamewars[3];
					int infl = obj3.infl1;
					obj3.infl1 = infl + 100;
				}
				if (global2.ingamewars[3].infl2 < 1000)
				{
					warinwars obj4 = global2.ingamewars[3];
					int infl = obj4.infl2;
					obj4.infl2 = infl - 100;
				}
			}
		}
		for (int j = 0; j < global2.ingamewars.Length; j++)
		{
			if (global2.ingamewars[j].is_going && global2.ingamewars[j].infl1 <= 1000 && global2.ingamewars[j].infl2 <= 1000 && j != 3 && j != 68)
			{
				if (global2.ingamewars[j].usa_place == 1)
				{
					global2.ingamewars[j].infl2 += global2.empires[0].power / 100;
					global2.ingamewars[j].infl1 -= global2.empires[0].power / 100;
				}
				if (global2.ingamewars[j].ussr_place == 1)
				{
					global2.ingamewars[j].infl2 += global2.empires[1].power / 100;
					global2.ingamewars[j].infl1 -= global2.empires[1].power / 100;
				}
				if (global2.ingamewars[j].usa_place == 0)
				{
					global2.ingamewars[j].infl2 -= global2.empires[0].power / 100;
					global2.ingamewars[j].infl1 += global2.empires[0].power / 100;
				}
				if (global2.ingamewars[j].ussr_place == 0)
				{
					global2.ingamewars[j].infl2 -= global2.empires[1].power / 100;
					global2.ingamewars[j].infl1 += global2.empires[1].power / 100;
				}
			}
		}
		if (!global2.ingamewars[5].is_going)
		{
			return;
		}
		global2.ingamewars[5].fortnight_go++;
		if (global2.ingamewars[5].infl1 >= 1000 || global2.ingamewars[5].infl2 <= 0)
		{
			global2.ingamewars[5].infl1 = 1000;
			global2.ingamewars[5].infl2 = 0;
			return;
		}
		if (global2.ingamewars[5].infl2 >= 1000 || global2.ingamewars[5].infl1 <= 0)
		{
			global2.ingamewars[5].infl2 = 1000;
			global2.ingamewars[5].infl1 = 0;
			return;
		}
		if (global2.ingamewars[5].infl1 < 1000)
		{
			global2.ingamewars[5].infl1--;
		}
		if (global2.ingamewars[5].infl2 > 0)
		{
			global2.ingamewars[5].infl2++;
		}
		if (global2.ingamewars[5].ussr_place == 1)
		{
			if (global2.ingamewars[5].infl1 < 1000)
			{
				global2.ingamewars[5].infl1 -= 50;
			}
			if (global2.ingamewars[5].infl2 > 0)
			{
				global2.ingamewars[5].infl2 += 50;
			}
			if (global2.data[94] == 1)
			{
				if (global2.ingamewars[5].infl1 > 0)
				{
					global2.ingamewars[5].infl1 += 4;
				}
				if (global2.ingamewars[5].infl2 < 1000)
				{
					global2.ingamewars[5].infl2 -= 4;
					return;
				}
			}
			else if (global2.data[94] == 3)
			{
				if (global2.ingamewars[5].infl1 > 0)
				{
					global2.ingamewars[5].infl1 += 6;
				}
				if (global2.ingamewars[5].infl2 < 1000)
				{
					global2.ingamewars[5].infl2 -= 6;
					return;
				}
			}
		}
		if (global2.data[94] == 2)
		{
			if (global2.ingamewars[5].infl1 < 1000)
			{
				global2.ingamewars[5].infl1 -= 2;
			}
			if (global2.ingamewars[5].infl2 > 0)
			{
				global2.ingamewars[5].infl2 += 2;
				return;
			}
		}
		if (global2.completedDecisions[10])
		{
			if (global2.ingamewars[5].infl1 < 1000)
			{
				global2.ingamewars[5].infl1 += 50;
			}
			if (global2.ingamewars[5].infl2 > 0)
			{
				global2.ingamewars[5].infl2 -= 50;
			}
		}
	}

	private void InfluenceFromInvestments()
	{
		global2.data[22] += (global2.data[71] - (global2.data[21] - 1976 + 6) * 10) / 10;
		if (global2.data[71] < 80 && global2.data[5] < 500)
		{
			global2.data[5] -= (90 - global2.data[71]) / 20;
		}
		if (global2.data[71] < 80)
		{
			global2.data[12] -= (90 - global2.data[71]) / 20;
		}
		global2.data[57] += global2.data[71] / 150;
		global2.data[57] += global2.data[76] / 150;
		if (global2.data[76] < 50)
		{
			global2.data[57] -= (50 - global2.data[76]) / 20;
		}
		global2.data[4] -= global2.data[71] / 80;
		global2.data[26] += global2.data[71] / 50;
		global2.data[12] += global2.data[71] / 90;
		if (global2.data[5] < 500)
		{
			global2.data[5] += global2.data[71] / 50;
		}
		global2.data[9] += global2.data[72] / 10;
		global2.data[4] -= global2.data[72] / 50 + global2.data[72] / 90 * 2 + global2.data[72] / 100 * 2;
		global2.data[3] -= global2.data[72] / 90 * 2 + global2.data[72] / 100;
		global2.data[1] -= global2.data[72] / 90 * 2 + global2.data[72] / 100;
		if (global2.data[5] < 500)
		{
			global2.data[5] += global2.data[72] / 80;
		}
		if (global2.data[72] >= global2.data[9] && global2.data[72] <= 150)
		{
			global2.data[26] -= global2.data[72] / 50 + global2.data[72] / 100;
		}
		else if (global2.data[9] > 0 && global2.data[9] <= 150 && global2.data[72] <= 150)
		{
			global2.data[26] -= global2.data[9] / 50 + global2.data[72] / 100;
		}
		else if (global2.data[9] > 0 && global2.data[9] <= 150 && global2.data[72] > 150)
		{
			global2.data[26] -= global2.data[9] / 50 + 1;
		}
		else if (global2.data[72] > 150)
		{
			global2.data[26] -= 4;
		}
		global2.data[26] += global2.data[73] / 50;
		global2.data[26] -= global2.data[74] / 20;
		global2.data[1] += global2.data[74] / 25;
		global2.data[5] += global2.data[74] / 70;
		global2.data[26] += global2.data[75] / 25;
		global2.data[1] += (global2.data[75] - 61) / 5;
		global2.data[26] -= global2.data[76] / 100;
		global2.data[57] += global2.data[76] / 150;
		global2.data[26] += global2.data[76] / 150;
		global2.data[4] -= global2.data[76] / 100;
		global2.data[3] += (global2.data[76] - 70) / 10;
		if (global2.data[76] < 50)
		{
			global2.data[26] += (50 - global2.data[76]) / 20;
			global2.data[3] -= (50 - global2.data[76]) / 20;
		}
		global2.data[26] += global2.data[77] / 80;
		global2.data[13] += global2.data[77] / 15;
		global2.data[5] += global2.data[77] / 100;
		if (global2.data[77] < 40)
		{
			global2.data[13] += (global2.data[77] - 40) / 10;
		}
		global2.data[26] += global2.data[78] / 80;
		global2.data[12] += global2.data[78] / 10;
		global2.data[5] += global2.data[78] / 80;
		if (global2.data[78] < 70)
		{
			global2.data[12] += (global2.data[78] - 70) / 10;
		}
		global2.data[26] += global2.data[79] / 50;
		global2.data[68] += global2.data[79] / 10;
		global2.data[5] += global2.data[79] / 40;
		if (global2.data[79] < 40)
		{
			global2.data[68] += (global2.data[79] - 40) / 10;
		}
		global2.data[5] += (global2.data[80] - 40) / 5;
		if (global2.data[16] < 13)
		{
			global2.data[26] += global2.data[80] / 80;
		}
		else
		{
			global2.data[26] += global2.data[80] / 50;
		}
		global2.data[3] += global2.data[80] / 80;
		if (global2.data[81] < 60 && global2.data[81] > 0)
		{
			global2.data[6]--;
		}
		else if (global2.data[81] <= 0)
		{
			global2.data[6] -= 2;
		}
		global2.data[8] -= global2.data[26] / 10;
		global2.data[5] -= global2.data[26] / 50;
	}

	private void MutualRelationsChange()
	{
		if (global2.allcountries[1].isOVD && global2.empires[0].relations > 650)
		{
			global2.empires[0].relations += ((!global2.science[32]) ? (global2.data[81] / 45) : (global2.data[81] / 40));
		}
		else if ((global2.allcountries[1].isSEV || global2.allcountries[1].okb) && global2.empires[0].relations > 650)
		{
			global2.empires[0].relations += ((!global2.science[32]) ? (global2.data[81] / 40) : (global2.data[81] / 35));
		}
		else if (global2.empires[1].relations > 750 && !global2.modifies[17].active)
		{
			global2.empires[0].relations += ((!global2.science[32]) ? (global2.data[81] / 30) : (global2.data[81] / 25));
		}
		else if (global2.empires[0].relations < 200 && global2.modifies[17].active)
		{
			global2.empires[0].relations += ((!global2.science[32]) ? (global2.data[81] / 15) : (global2.data[81] / 10));
		}
		else if (global2.empires[0].relations < 400)
		{
			global2.empires[0].relations += ((!global2.science[32]) ? (global2.data[81] / 20) : (global2.data[81] / 15));
		}
		else
		{
			global2.empires[0].relations += ((!global2.science[32]) ? (global2.data[81] / 25) : (global2.data[81] / 20));
		}
		if ((global2.allcountries[1].Vyshi || global2.allcountries[51].dev == 1) && global2.empires[1].relations > 650)
		{
			global2.empires[1].relations += ((!global2.science[32]) ? (global2.data[81] / 45) : (global2.data[81] / 40));
		}
		else if ((global2.allcountries[51].Torg || global2.allcountries[1].okb) && global2.empires[1].relations > 650)
		{
			global2.empires[1].relations += ((!global2.science[32]) ? (global2.data[81] / 40) : (global2.data[81] / 35));
		}
		else if (global2.empires[0].relations > 750 && !global2.modifies[17].active)
		{
			global2.empires[1].relations += ((!global2.science[32]) ? (global2.data[81] / 30) : (global2.data[81] / 25));
		}
		else if (global2.empires[1].relations < 200 && global2.modifies[17].active)
		{
			global2.empires[1].relations += ((!global2.science[32]) ? (global2.data[81] / 15) : (global2.data[81] / 10));
		}
		else if (global2.empires[1].relations < 400)
		{
			global2.empires[1].relations += ((!global2.science[32]) ? (global2.data[81] / 20) : (global2.data[81] / 15));
		}
		else
		{
			global2.empires[1].relations += ((!global2.science[32]) ? (global2.data[81] / 25) : (global2.data[81] / 20));
		}
		if (!global1.dlc[0])
		{
			if (global2.empires[0].relations > 900 && global2.empires[1].relations > 500)
			{
				global2.empires[1].relations -= 30;
			}
			else if (global2.empires[0].relations > 800 && global2.empires[1].relations > 400)
			{
				global2.empires[1].relations -= 20;
			}
			else if (global2.empires[0].relations > 700 && global2.empires[1].relations > 300)
			{
				global2.empires[1].relations -= 10;
			}
			else if (global2.empires[0].relations > 650)
			{
				global2.empires[1].relations -= 5;
			}
			if (global2.empires[1].relations > 800 && global2.empires[0].relations > 500)
			{
				global2.empires[0].relations -= 30;
			}
			else if (global2.empires[1].relations > 650 && global2.empires[0].relations > 350)
			{
				global2.empires[0].relations -= 20;
			}
			else if (global2.empires[1].relations > 650)
			{
				global2.empires[0].relations -= 10;
			}
		}
		else
		{
			if (global2.empires[0].relations < 750 && global2.empires[0].relations > 700 && global2.empires[1].relations > 300)
			{
				global2.empires[1].relations -= 10;
			}
			else if (global2.empires[0].relations > 650)
			{
				global2.empires[1].relations -= 5;
			}
			if (global2.empires[1].relations < 750 && global2.empires[1].relations > 650 && global2.empires[0].relations > 350)
			{
				global2.empires[0].relations -= 20;
			}
			else if (global2.empires[1].relations < 750 && global2.empires[1].relations > 650)
			{
				global2.empires[0].relations -= 10;
			}
		}
		if (global2.empires[0].relations < 700)
		{
			global2.empires[0].relations += global2.data[69] / 20;
		}
	}

	private void EventsRequirements()
	{
		if (((global2.data[20] >= 10 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && !global2.event_done[791] && !events[0].activeSelf)
		{
			this_num_event = 791;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (((global2.data[19] >= 9 && global2.data[20] >= 9 && global2.data[21] >= 1976) || global2.data[20] >= 10) && !global2.event_done[3] && !events[0].activeSelf)
		{
			this_num_event = 3;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (((global2.data[19] >= 6 && global2.data[20] >= 7 && global2.data[21] >= 1976) || global2.data[20] >= 8) && !global2.event_done[676] && !events[0].activeSelf)
		{
			this_num_event = 676;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if ((global2.data[3] - global2.data[4] < -50 || global2.data[3] < 100 || global2.data[4] >= 1200) && !global2.event_done[5] && !events[0].activeSelf && (!GlobalScript.inst.gameState.event_done[444] || GlobalScript.inst.gameState.resultOfEvents[444] != 0) && GlobalScript.inst.gameState.resultOfEvents[503] != 0)
		{
			this_num_event = 5;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.data[5] < 10 && !events[0].activeSelf)
		{
			this_num_event = 6;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.empires[0].relations <= 0 && !events[0].activeSelf && !global2.event_done[7] && !global2.event_done[421])
		{
			this_num_event = 7;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.empires[1].relations <= 0 && !events[0].activeSelf && !global2.event_done[8] && !global2.event_done[473])
		{
			this_num_event = 8;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.data[57] <= 300 && !global2.completedDecisions[4] && !global2.completedDecisions[3] && global2.data[66] == 0 && !events[0].activeSelf && !global2.event_done[10] && !global2.is_gkchp && !global2.IndOpp)
		{
			this_num_event = 10;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.data[57] <= 400 && !global2.completedDecisions[2] && !global2.completedDecisions[1] && global2.data[67] == 0 && !events[0].activeSelf && !global2.event_done[9] && !global2.is_gkchp && !global2.IndOpp)
		{
			this_num_event = 9;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.data[12] <= 0 && !events[0].activeSelf)
		{
			this_num_event = 11;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.data[13] <= 0 && !events[0].activeSelf)
		{
			this_num_event = 12;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.data[68] <= 0 && !events[0].activeSelf)
		{
			this_num_event = 13;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (global2.data[8] + global2.data[81] + global2.data[80] + global2.data[79] + global2.data[78] + global2.data[77] + global2.data[76] + global2.data[75] + global2.data[74] + global2.data[73] + global2.data[72] + global2.data[71] < 800 && global2.data[8] < 300 && !events[0].activeSelf)
		{
			this_num_event = 14;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (!GlobalScript.inst.gameState.vietnampeace && !global2.allcountries[23].isSEV && !global2.allcountries[23].econ && !global2.event_done[15] && ((global2.data[19] >= 25 && global2.data[20] >= 12 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && !events[0].activeSelf)
		{
			this_num_event = 15;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (((global2.data[20] >= 1 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[435] && !events[0].activeSelf)
		{
			this_num_event = 435;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (((global2.data[20] >= 10 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[436] && !events[0].activeSelf)
		{
			this_num_event = 436;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (((global2.data[20] >= 4 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && !global2.event_done[16] && !events[0].activeSelf)
		{
			this_num_event = 16;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (((global2.data[20] >= 10 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && !global2.event_done[17] && !events[0].activeSelf)
		{
			this_num_event = 17;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
			return;
		}
		if (((global2.data[20] >= 2 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && !global2.event_done[19] && !events[0].activeSelf)
		{
			this_num_event = 19;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		if (((global2.data[20] >= 2 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && global2.event_done[19] && !global2.event_done[20] && !events[0].activeSelf)
		{
			this_num_event = 20;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 25 && global2.data[20] >= 3 && global2.data[21] >= 1976) || (global2.data[20] >= 4 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && !global2.event_done[21] && !events[0].activeSelf)
		{
			this_num_event = 21;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 5 && global2.data[20] >= 4 && global2.data[21] >= 1976) || (global2.data[20] >= 5 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && !global2.event_done[22] && !events[0].activeSelf)
		{
			this_num_event = 22;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 8 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && !global2.event_done[23] && !events[0].activeSelf)
		{
			this_num_event = 23;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 12 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && GlobalScript.inst.gameState.data[84] != 3 && !global2.event_done[24] && !events[0].activeSelf)
		{
			this_num_event = 24;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 12 && global2.data[20] >= 8 && global2.data[21] >= 1977) || (global2.data[20] >= 9 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && GlobalScript.inst.gameState.data[84] == 3 && !global2.event_done[240] && !events[0].activeSelf)
		{
			this_num_event = 240;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.event_done[240] && !global2.event_done[241] && !events[0].activeSelf)
		{
			this_num_event = 241;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 10 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && !global2.event_done[25] && !events[0].activeSelf)
		{
			this_num_event = 25;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 11 && global2.data[21] >= 1976) || global2.data[21] >= 1977) && global2.data[84] == 3 && !global2.event_done[26] && !events[0].activeSelf)
		{
			this_num_event = 26;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 7 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[33] && !events[0].activeSelf)
		{
			this_num_event = 33;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 2 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && global2.data[84] != 3 && !global2.event_done[34] && !events[0].activeSelf)
		{
			this_num_event = 34;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 5 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.modifies[3].active && global2.data[8] != 2 && !global2.event_done[35] && !events[0].activeSelf)
		{
			this_num_event = 35;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 12 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[36] && !events[0].activeSelf)
		{
			this_num_event = 36;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 18 && global2.data[20] >= 1 && global2.data[21] >= 1977) || (global2.data[20] >= 2 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[37] && !events[0].activeSelf)
		{
			this_num_event = 37;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 4 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && global2.data[16] != 10 && !global2.event_done[38] && !events[0].activeSelf)
		{
			this_num_event = 38;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 3 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && global2.data[87] != 2 && !global2.modifies[3].active && !global2.event_done[39] && !events[0].activeSelf)
		{
			this_num_event = 39;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 22 && global2.data[20] >= 10 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && global2.allcountries[69].numberOfSpecialEnding != 5 && global2.allcountries[69].numberOfSpecialEnding != 6 && global2.data[50] != 28 && !global2.event_done[40] && !events[0].activeSelf)
		{
			this_num_event = 40;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 3 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[41] && !events[0].activeSelf)
		{
			this_num_event = 41;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[15] > 7 && global2.data[125] <= 0 && !events[0].activeSelf)
		{
			this_num_event = 1;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 8 && global2.data[20] >= 1 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && !global2.event_done[42] && !events[0].activeSelf)
		{
			this_num_event = 42;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 11 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && !global2.event_done[43] && !events[0].activeSelf)
		{
			this_num_event = 43;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[21] >= 1978 && global2.data[89] == 0 && global2.data[69] >= 150 && global2.data[12] <= 900 && global2.faction_leader[3] != 200 && event44 && !global2.event_done[44] && (!GlobalScript.inst.gameState.event_done[444] || GlobalScript.inst.gameState.resultOfEvents[444] != 0) && !events[0].activeSelf)
		{
			this_num_event = 44;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 1 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && global2.data[89] == 1 && !global2.event_done[45] && !events[0].activeSelf)
		{
			this_num_event = 45;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 11 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[46] && !events[0].activeSelf)
		{
			this_num_event = 46;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 6 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && global2.data[89] == 0 && !global2.event_done[47] && !events[0].activeSelf)
		{
			this_num_event = 47;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[21] >= 1979 && !global2.event_done[668] && !events[0].activeSelf)
		{
			this_num_event = 668;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 5 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && !global2.event_done[63] && !events[0].activeSelf)
		{
			this_num_event = 63;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 16 && global2.data[20] >= 9 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && global2.data[48] > global2.data[49] && !global2.event_done[48] && !events[0].activeSelf)
		{
			this_num_event = 48;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 1 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.allcountries[12].Gosstroy == 0 && !global2.allcountries[12].econ && !global2.event_done[49] && !events[0].activeSelf)
		{
			this_num_event = 49;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 1 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.event_done[49] && global2.resultOfEvents[49] != 1 && global2.allcountries[12].Gosstroy == 1 && !global2.allcountries[12].econ && !global2.event_done[50] && !events[0].activeSelf)
		{
			this_num_event = 50;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 1 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.allcountries[8].Gosstroy != 0 && !global2.allcountries[31].Vyshi && !global2.allcountries[8].Vyshi && global2.data[48] == global2.data[49] && !global2.event_done[49] && !global2.event_done[51] && !events[0].activeSelf)
		{
			this_num_event = 51;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 1 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.ingamewars[5].is_going && global2.allcountries[31].proprc && !global2.event_done[52] && !events[0].activeSelf)
		{
			this_num_event = 52;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 1 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && !global2.event_done[53] && !events[0].activeSelf)
		{
			this_num_event = 53;
			GlobalScript.inst.old_modify_desc[15] = " 根 据 农 业 发 展 情 况 获 得 效 果";
			if (GlobalScript.inst.gameState.science[3])
			{
				string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
				int num = 15;
				old_modify_desc[num] += "<color=red>| 农 业 机 械 化 ：</color>| 农 业+0.6 ， 工 业+0.4";
			}
			if (GlobalScript.inst.gameState.science[6])
			{
				string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
				int num2 = 15;
				old_modify_desc2[num2] += "<color=red>| 普 及 化 肥 与 杀 虫 剂 ：</color>| 农 业+0.3 ， 生 活 水 平+0.4";
			}
			if (GlobalScript.inst.gameState.science[7])
			{
				string[] old_modify_desc3 = GlobalScript.inst.old_modify_desc;
				int num3 = 15;
				old_modify_desc3[num3] += "<color=red>| 转 基 因 技 术 ：</color>| 农 业+0.2 ， 工 业+0.2 ， 生 活 水 平+0.5 ， 预 算+0.3";
			}
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.event_done[45] && global2.data[16] > 11 && !global2.event_done[54] && !events[0].activeSelf)
		{
			this_num_event = 54;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 10 && global2.data[20] >= 8 && global2.data[21] >= 1980) || (global2.data[20] >= 9 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && !global2.event_done[55] && !events[0].activeSelf)
		{
			this_num_event = 55;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 2 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && !global2.event_done[56] && !GlobalScript.inst.gameState.vietnampeace && GlobalScript.inst.gameState.ingamewars[1].is_going && !events[0].activeSelf)
		{
			this_num_event = 56;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 2 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && !global2.event_done[58] && !events[0].activeSelf)
		{
			this_num_event = 58;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 5 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && (global2.allcountries[23].proprc || global2.allcountries[34].proprc || global2.allcountries[20].proprc || global2.allcountries[31].proprc) && !global2.event_done[59] && !events[0].activeSelf && !global2.allcountries[1].isASEAN)
		{
			this_num_event = 59;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 6 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && global2.allcountries[1].econ && !global2.event_done[60] && !events[0].activeSelf)
		{
			this_num_event = 60;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 4 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && global2.data[82] != 2 && !global2.event_done[61] && !events[0].activeSelf)
		{
			this_num_event = 61;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 8 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && global2.data[82] != 2 && !global2.event_done[62] && !events[0].activeSelf)
		{
			this_num_event = 62;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 8 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.allcountries[30].Gosstroy == 2 && !global2.allcountries[1].isASEAN && !global2.event_done[64] && !events[0].activeSelf)
		{
			this_num_event = 64;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 1 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && !global2.event_done[65] && !events[0].activeSelf)
		{
			this_num_event = 65;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 5 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && !global2.event_done[66] && !events[0].activeSelf)
		{
			this_num_event = 66;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 10 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && !global2.event_done[67] && !events[0].activeSelf)
		{
			this_num_event = 67;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 15 && global2.data[20] >= 8 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.allcountries[46].SubGosstroy == 7 && !global2.event_done[68] && !events[0].activeSelf)
		{
			this_num_event = 68;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 2 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.data[89] > 0 && !global2.event_done[69] && !events[0].activeSelf)
		{
			this_num_event = 69;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 2 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.data[89] == 0 && global2.modifies[14].active && !global2.event_done[70] && !events[0].activeSelf)
		{
			this_num_event = 70;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[32] >= 500 && !global2.event_done[71] && !events[0].activeSelf)
		{
			this_num_event = 71;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 7 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && global2.data[91] >= 1 && global2.data[91] <= 2 && !global2.event_done[72] && !events[0].activeSelf)
		{
			this_num_event = 72;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 15 && global2.data[20] >= 9 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && !global2.allcountries[8].Vyshi && !global2.allcountries[8].okb && !global2.allcountries[8].isSEV && global2.allcountries[8].puppetOf <= 0 && global2.allcountries[14].puppetOf <= 0 && !global2.allcountries[8].econ && global2.allcountries[8].Gosstroy == 0 && global2.allcountries[8].SubGosstroy == 9 && !global2.event_done[73] && !events[0].activeSelf)
		{
			this_num_event = 73;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 7 && global2.data[21] >= 1981) || global2.data[21] >= 1982) && global2.event_done[39] && !global2.event_done[74] && !events[0].activeSelf)
		{
			this_num_event = 74;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 8 && global2.data[21] >= 1981) || global2.data[21] >= 1982) && (global2.data[117] != 9 || global2.allcountries[8].Vyshi || global2.allcountries[8].Gosstroy != 0) && global2.allcountries[14].dev == 0 && global2.allcountries[14].puppetOf < 0 && !global2.IsSocialism(yes: true, 14) && !global2.event_done[75] && !events[0].activeSelf)
		{
			this_num_event = 75;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if ((global2.ingamewars[3].is_going || global2.allcountries[14].prcpower >= 100) && global2.allcountries[14].prcpower > 50 && global2.event_done[36] && global2.resultOfEvents[36] == 3 && !global2.event_done[566] && !events[0].activeSelf)
		{
			this_num_event = 566;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 3 && global2.data[21] >= 1981) || global2.data[21] >= 1982) && !global2.allcountries[15].Torg && global2.data[60] == 0 && !global2.event_done[76] && !events[0].activeSelf)
		{
			this_num_event = 76;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 11 && global2.data[21] >= 1981) || global2.data[21] >= 1982) && global2.data[60] < 1 && global2.allcountries[20].SubGosstroy != 11 && !global2.allcountries[20].econ && !global2.event_done[77] && !events[0].activeSelf)
		{
			this_num_event = 77;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 6 && global2.data[21] >= 1981) || global2.data[21] >= 1982) && !global2.allcountries[1].isASEAN && !global2.allcountries[47].okb && !global2.allcountries[47].isSEV && !global2.allcountries[47].econ && global2.allcountries[47].Gosstroy == 0 && !global2.event_done[78] && !events[0].activeSelf)
		{
			this_num_event = 78;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 9 && global2.data[21] >= 1981) || global2.data[21] >= 1982) && (global2.allcountries[8].dev != 0 || !global2.allcountries[8].Vyshi || global2.allcountries[8].Gosstroy != 0) && global2.resultOfEvents[382] != 2 && !global2.event_done[79] && !events[0].activeSelf)
		{
			this_num_event = 79;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 9 && global2.data[21] >= 1982) || global2.data[21] >= 1983) && (global2.data[90] == 1 || global2.data[90] == 2) && !global2.event_done[80] && !events[0].activeSelf)
		{
			this_num_event = 80;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 9 && global2.data[21] >= 1982) || global2.data[21] >= 1983) && global2.modifies[3].active && global2.leader.name_1 == 2 && global2.leader.name_2 == 2 && global2.NumberOfPolitician(0, 0) >= 0 && global2.NumberOfPolitician(3, 3) >= 0 && global2.NumberOfPolitician(4, 4) >= 0 && global2.NumberOfPolitician(5, 5) >= 0 && !global2.event_done[80] && !events[0].activeSelf)
		{
			this_num_event = 80;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 4 && global2.data[21] >= 1982) || global2.data[21] >= 1983) && global2.allcountries[4].Gosstroy == 2 && (global2.allcountries[20].proprc || global2.relres) && !global2.event_done[81] && !events[0].activeSelf)
		{
			this_num_event = 81;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 2 && global2.data[20] >= 4 && global2.data[21] >= 1982) || global2.data[21] >= 1983) && (global2.allcountries[71].Gosstroy == 0 || global2.allcountries[71].SubGosstroy == 0 || global2.allcountries[71].SubGosstroy >= 7) && !global2.event_done[82] && !events[0].activeSelf)
		{
			this_num_event = 82;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 4 && global2.data[20] >= 7 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[83] && !events[0].activeSelf)
		{
			this_num_event = 83;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 4 && global2.data[20] >= 10 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && global2.empires[1].now_leader == 0 && (global2.resultOfEvents[83] == 0 || global2.data[149] == 1) && !global2.event_done[84] && !events[0].activeSelf)
		{
			this_num_event = 84;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 6 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && global2.empires[1].now_leader == 0 && (global2.resultOfEvents[84] == 0 || global2.data[149] == 2) && !global2.event_done[85] && !events[0].activeSelf)
		{
			this_num_event = 85;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 7 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && global2.empires[1].now_leader == 0 && (global2.resultOfEvents[85] == 0 || global2.data[149] == 3) && !global2.event_done[86] && !events[0].activeSelf)
		{
			this_num_event = 86;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 6 && global2.data[20] >= 6 && global2.data[21] >= 1982) || global2.data[21] >= 1983) && !global2.event_done[87] && !events[0].activeSelf)
		{
			this_num_event = 87;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 10 && global2.data[20] >= 3 && global2.data[21] >= 1978) || (global2.data[20] >= 4 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && !global2.event_done[88] && !events[0].activeSelf)
		{
			this_num_event = 88;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 12 && global2.data[21] >= 1979) || global2.data[21] >= 1980) && !global2.event_done[880] && !events[0].activeSelf)
		{
			this_num_event = 880;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 18 && global2.data[20] >= 4 && global2.data[21] >= 1980) || (global2.data[20] >= 5 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && !global2.event_done[881] && !events[0].activeSelf)
		{
			this_num_event = 881;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 10 && global2.data[20] >= 11 && global2.data[21] >= 1982) || global2.data[21] >= 1983) && !global2.event_done[89] && !events[0].activeSelf)
		{
			this_num_event = 89;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 12 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && global2.data[65] == 1 && !global2.event_done[90] && !events[0].activeSelf)
		{
			this_num_event = 90;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 9 && global2.data[20] >= 10 && global2.data[21] >= 1983) || global2.data[21] >= 1984) && global2.allcountries[46].Gosstroy == 0 && global2.allcountries[46].SubGosstroy == 7 && !global2.event_done[91] && !events[0].activeSelf)
		{
			this_num_event = 91;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[16] <= 11 && global2.event_done[38] && !global2.event_done[92] && !events[0].activeSelf)
		{
			this_num_event = 92;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 11 && global2.data[21] >= 1977) || global2.data[21] >= 1978) && !global2.event_done[93] && !events[0].activeSelf)
		{
			this_num_event = 93;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 18 && global2.data[20] >= 10 && global2.data[21] >= 1981) || (global2.data[20] >= 11 && global2.data[21] >= 1981) || global2.data[21] >= 1982) && !global2.event_done[931] && !events[0].activeSelf)
		{
			this_num_event = 931;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 2 && global2.data[20] >= 6 && global2.data[21] >= 1985) || (global2.data[20] >= 7 && global2.data[21] >= 1985) || global2.data[21] >= 1986) && !global2.event_done[932] && global2.allcountries[45].Gosstroy != 0 && !events[0].activeSelf)
		{
			this_num_event = 932;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[92] >= 90 && global2.data[21] >= 1983 && !global2.event_done[94] && (!GlobalScript.inst.gameState.event_done[444] || GlobalScript.inst.gameState.resultOfEvents[444] != 0) && !events[0].activeSelf)
		{
			this_num_event = 94;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[107] == 1 && !global2.event_done[95] && global2.event_done[94] && !events[0].activeSelf)
		{
			this_num_event = 95;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[107] == 1 && !global2.event_done[96] && global2.event_done[95] && !events[0].activeSelf)
		{
			this_num_event = 96;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.science[17] && (global2.data[16] == 10 || global2.data[16] == 11) && !global2.event_done[97] && !events[0].activeSelf)
		{
			this_num_event = 97;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 8 && global2.data[21] >= 1983) || global2.data[21] >= 1984) && !global2.event_done[98] && !events[0].activeSelf)
		{
			this_num_event = 98;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 11 && global2.data[21] >= 1980) || global2.data[21] >= 1981) && !global2.event_done[114] && !events[0].activeSelf)
		{
			this_num_event = 114;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 9 && global2.data[20] >= 2 && global2.data[21] >= 1984) || global2.data[21] >= 1985) && global2.empires[1].now_leader == 1 && global2.empires[1].now_leader != 7 && !global2.event_done[117] && !events[0].activeSelf)
		{
			this_num_event = 117;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 9 && global2.data[20] >= 1 && global2.data[21] >= 1984) || (global2.data[20] >= 2 && global2.data[21] >= 1984) || global2.data[21] >= 1985) && !global2.event_done[118] && !global2.allcountries[49].parts[0] && !events[0].activeSelf)
		{
			this_num_event = 118;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 10 && global2.data[20] >= 12 && global2.data[21] >= 1978) || global2.data[21] >= 1979) && !global2.event_done[99] && !events[0].activeSelf)
		{
			this_num_event = 99;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 10 && global2.data[20] >= 12 && global2.data[21] >= 1983) || global2.data[21] >= 1984) && !global2.event_done[100] && !events[0].activeSelf)
		{
			this_num_event = 100;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 10 && global2.data[20] >= 3 && global2.data[21] >= 1985) || global2.data[21] >= 1986) && (global2.empires[1].now_leader == 1 || global2.empires[1].now_leader == 2) && global2.empires[1].now_leader != 7 && !global2.event_done[102] && !events[0].activeSelf)
		{
			this_num_event = 102;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 7 && global2.data[21] >= 1985) || global2.data[21] >= 1986) && global2.event_done[541] && global2.resultOfEvents[541] == 0 && !global2.event_done[104] && !events[0].activeSelf)
		{
			this_num_event = 104;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[19] >= 13 && global2.data[20] >= 4 && global2.data[21] >= 1985) || global2.data[21] >= 1986) && global2.data[60] == 0 && global2.allcountries[20].SubGosstroy != 11 && !global2.event_done[105] && !events[0].activeSelf)
		{
			this_num_event = 105;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 6 && global2.data[21] >= 1985) || global2.data[21] >= 1986) && !global2.event_done[106] && !global2.allcountries[7].isNATO && global2.allcountries[51].isNATO && !global2.is_gkchp && !global2.IndOpp && !events[0].activeSelf)
		{
			this_num_event = 106;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!global2.event_done[587] && !events[0].activeSelf && ((global2.data[19] >= 3 && global2.data[20] >= 2 && global2.data[21] >= 1977) || (global2.data[20] >= 3 && global2.data[21] >= 1977) || global2.data[21] >= 1978))
		{
			this_num_event = 587;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!global2.event_done[109] && !events[0].activeSelf && !global2.allcountries[42].parts[0] && !global2.allcountries[42].parts[2] && !global2.ingamewars[15].is_going && ((global2.data[19] >= 9 && global2.data[20] >= 4 && global2.data[21] >= 1978) || (global2.data[20] >= 5 && global2.data[21] >= 1978) || global2.data[21] >= 1979))
		{
			this_num_event = 109;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!global2.event_done[588] && !events[0].activeSelf && ((!global2.allcountries[42].prosov && global2.allcountries[41].prosov) || (!global2.allcountries[42].prosov && global2.allcountries[41].proprc) || (global2.allcountries[42].prosov && global2.allcountries[41].proprc)) && !global2.allcountries[42].parts[0] && !global2.allcountries[42].parts[2] && global2.allcountries[42].SubGosstroy == 10 && ((global2.data[19] >= 1 && global2.data[20] >= 6 && global2.data[21] >= 1982) || (global2.data[20] >= 7 && global2.data[21] >= 1982) || global2.data[21] >= 1983))
		{
			this_num_event = 588;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!global2.event_done[589] && !global2.event_done[403] && !events[0].activeSelf && global2.allcountries[42].proprc && global2.allcountries[41].proprc && global2.allcountries[42].Gosstroy != 0 && global2.allcountries[41].Gosstroy != 0 && !global2.allcountries[42].parts[0] && !global2.allcountries[42].parts[1] && !global2.allcountries[42].parts[2] && global2.modifies[6].active && (global2.allcountries[1].Gosstroy == 1 || global2.allcountries[1].SubGosstroy == 0))
		{
			this_num_event = 589;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!global2.event_done[594] && !events[0].activeSelf && global2.allcountries[42].SubGosstroy == 10 && ((global2.data[20] >= 11 && global2.data[21] >= 1980) || global2.data[21] >= 1981))
		{
			this_num_event = 594;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!global2.event_done[595] && !events[0].activeSelf && ((global2.data[19] >= 15 && global2.data[20] >= 7 && global2.data[21] >= 1982) || (global2.data[20] >= 8 && global2.data[21] >= 1982) || global2.data[21] >= 1983))
		{
			this_num_event = 595;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!global2.event_done[596] && !events[0].activeSelf && ((global2.data[19] >= 10 && global2.data[20] >= 2 && global2.data[21] >= 1984) || (global2.data[20] >= 3 && global2.data[21] >= 1984) || global2.data[21] >= 1985) && global2.allcountries[119].Gosstroy != 1 && !global2.allcountries[42].parts[1] && !global2.allcountries[42].parts[2] && (global2.allcountries[42].proprc || global2.allcountries[42].prosov) && global2.allcountries[42].SubGosstroy == 10)
		{
			this_num_event = 596;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 2 && global2.data[21] >= 1983) || global2.data[21] >= 1984) && !global2.allcountries[15].isEU && global2.allcountries[15].SubGosstroy == 11 && global2.allcountries[20].SubGosstroy != 11 && !global2.event_done[113] && !events[0].activeSelf)
		{
			this_num_event = 113;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[21] >= 1982 && global2.allcountries[33].Torg && !global2.allcountries[33].proprc && global2.allcountries[34].Torg && global2.allcountries[22].Torg && !global2.event_done[115] && !events[0].activeSelf)
		{
			this_num_event = 115;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[21] >= 1985 && global2.data[107] == 1 && !global2.event_done[116] && global2.allcountries[38].dev == 0 && global2.event_done[95] && global2.event_done[96] && !events[0].activeSelf && global2.data[64] <= 0 && !global2.completedDecisions[6] && !global2.completedDecisions[7] && !GlobalScript.inst.gameState.event_done[461])
		{
			this_num_event = 116;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[21] >= 1980 && !global2.modifies[12].active && global2.science[15] && global2.data[16] <= 11 && !global2.event_done[110] && !events[0].activeSelf)
		{
			this_num_event = 110;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.science[15] && global2.data[21] >= 1983 && global2.modifies[11].active && !global2.event_done[111] && !events[0].activeSelf)
		{
			this_num_event = 111;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.modifies[11].active && global2.allcountries[1].okb && global2.data[21] >= 1984 && !global2.event_done[112] && global2.event_done[110] && global2.event_done[111] && global2.event_done[97] && !events[0].activeSelf)
		{
			this_num_event = 112;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[20] >= 7 && global2.data[21] >= 1985) || global2.data[21] >= 1986) && (global2.allcountries[0].isEU || (global2.allcountries[21].isSocEU && !global2.allcountries[0].isEU)) && global2.allcountries[1].econ && !global2.event_done[103] && !events[0].activeSelf)
		{
			this_num_event = 103;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.data[120] > 0 && global2.allcountries[1].econ && !events[0].activeSelf)
		{
			this_num_event = 107;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1977 && global2.data[20] >= 3 && global2.data[19] >= 15) || (global2.data[21] >= 1977 && global2.data[20] >= 4) || global2.data[21] >= 1978) && !global2.event_done[696] && !events[0].activeSelf)
		{
			this_num_event = 696;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1979 && global2.data[20] >= 2) || global2.data[21] >= 1980) && global2.event_done[696] && global2.resultOfEvents[696] == 2 && !global2.event_done[496] && !events[0].activeSelf)
		{
			this_num_event = 496;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1984 && global2.data[20] >= 10 && global2.data[19] >= 17) || (global2.data[21] >= 1984 && global2.data[20] >= 11) || global2.data[21] >= 1985) && global2.allcountries[52].Gosstroy == 1 && !global2.event_done[497] && !events[0].activeSelf)
		{
			this_num_event = 497;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1980 && global2.data[20] >= 4 && global2.data[19] >= 12) || (global2.data[21] >= 1980 && global2.data[20] >= 5) || global2.data[21] >= 1981) && !global2.event_done[649] && !events[0].activeSelf)
		{
			this_num_event = 649;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1985 && global2.data[20] >= 10) || global2.data[21] >= 1986) && global2.event_done[696] && !global2.event_done[650] && !events[0].activeSelf)
		{
			this_num_event = 650;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1982 && global2.data[20] >= 5) || global2.data[21] >= 1983) && !global2.event_done[651] && !events[0].activeSelf)
		{
			this_num_event = 651;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1985 && global2.data[20] >= 4) || global2.data[21] >= 1986) && global2.allcountries[107].SubGosstroy != 12 && !global2.event_done[652] && !events[0].activeSelf)
		{
			this_num_event = 652;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1979 && global2.data[20] >= 7) || global2.data[21] >= 1980) && !global2.event_done[653] && !events[0].activeSelf)
		{
			this_num_event = 653;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1983 && global2.data[20] >= 8) || global2.data[21] >= 1984) && !global2.event_done[654] && !events[0].activeSelf)
		{
			this_num_event = 654;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1983 && global2.data[20] >= 12 && global2.data[19] >= 31) || global2.data[21] >= 1984) && !global2.event_done[655] && !events[0].activeSelf)
		{
			this_num_event = 655;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1981 && global2.data[20] >= 10 && global2.data[19] >= 29) || (global2.data[21] >= 1981 && global2.data[20] >= 11) || global2.data[21] >= 1982) && !global2.event_done[658] && !events[0].activeSelf)
		{
			this_num_event = 658;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1981 && global2.data[20] >= 2 && global2.data[19] >= 20) || (global2.data[21] >= 1981 && global2.data[20] >= 3) || global2.data[21] >= 1982) && !global2.event_done[659] && !events[0].activeSelf)
		{
			this_num_event = 659;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((((global2.data[21] >= 1985 && global2.data[20] >= 7 && global2.data[19] >= 30) || (global2.data[21] >= 1985 && global2.data[20] >= 8) || global2.data[21] >= 1986) && global2.resultOfEvents[659] < 3) || global2.allcountries[118].inflCh > 800) && !global2.event_done[660] && !events[0].activeSelf)
		{
			this_num_event = 660;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if ((global2.allcountries[33].inflCh >= 70 || global2.allcountries[33].inflCh < 40) && !global2.event_done[662] && !events[0].activeSelf)
		{
			this_num_event = 662;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (global2.allcountries[33].inflCh >= 100 && !global2.event_done[663] && !events[0].activeSelf)
		{
			this_num_event = 663;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1985 && global2.data[20] >= 6 && global2.data[19] >= 1) || (global2.data[21] >= 1985 && global2.data[20] >= 6) || global2.data[21] >= 1986) && global2.allcountries[33].SubGosstroy == 11 && !global2.event_done[664] && !events[0].activeSelf)
		{
			this_num_event = 664;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1981 && global2.data[20] >= 7 && global2.data[19] >= 31) || (global2.data[21] >= 1981 && global2.data[20] >= 8) || global2.data[21] >= 1982) && !global2.event_done[665] && !events[0].activeSelf)
		{
			this_num_event = 665;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1985 && global2.data[20] >= 1 && global2.data[19] >= 1) || (global2.data[21] >= 1985 && global2.data[20] >= 2) || global2.data[21] >= 1985) && (global2.empires[0].now_leader == 0 || global2.empires[0].now_leader == 2) && !global2.allcountries[141].isSEV && !global2.event_done[667] && !events[0].activeSelf)
		{
			this_num_event = 667;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1978 && global2.data[20] >= 6 && global2.data[19] >= 14) || (global2.data[21] >= 1978 && global2.data[20] >= 7) || global2.data[21] >= 1979) && !global2.event_done[498] && !events[0].activeSelf)
		{
			this_num_event = 498;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (((global2.data[21] >= 1983 && global2.data[20] >= 9 && global2.data[19] >= 1) || (global2.data[21] >= 1983 && global2.data[20] >= 10) || global2.data[21] >= 1984) && !global2.event_done[499] && !events[0].activeSelf)
		{
			this_num_event = 499;
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!events[0].activeSelf && GlobalScript.inst.dlc[2] && ReqEventForDLC02.RequrementsDLC02(ref this_num_event, global2))
		{
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!events[0].activeSelf && GlobalScript.inst.dlc[3] && ReqEventForDLC02.RequrementsDLC03(ref this_num_event, global2))
		{
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
		else if (!events[0].activeSelf && GlobalScript.inst.dlc[1] && ReqEventForDLC02.RequrementsDLC01(ref this_num_event, global2))
		{
			events[0].GetComponent<EventScript>().Reset(this_num_event);
			events[0].SetActive(value: true);
		}
	}

	public void FocusesResearching()
	{
		Empire[] empires = global2.empires;
		for (int i = 1; i < empires.Length; i++)
		{
			if (empires[i].now_focus > -1)
			{
				if (FocusManager.all_trees[empires[i].active_tree][empires[i].now_layer][empires[i].now_focus].overtime >= FocusManager.all_trees[empires[i].active_tree][empires[i].now_layer][empires[i].now_focus].time)
				{
					FocusManager.all_trees[empires[i].active_tree][empires[i].now_layer][empires[i].now_focus].active();
					empires[i].now_focus = -1;
					empires[i].now_layer++;
				}
				else
				{
					FocusManager.all_trees[empires[i].active_tree][empires[i].now_layer][empires[i].now_focus].overtime++;
				}
			}
			else
			{
				FocusesAIMethod(i);
			}
		}
	}

	private void FocusesAIMethod(int country)
	{
		// [移植修复] "Start Focus" 共 8 层, 最后一层完成后 now_layer == 层数,
		// 原版直接查 all_trees[..][now_layer] 抛 ArgumentOutOfRange 并每 tick 刷屏.
		// 树研究完就是研究完了, AI 保持 now_focus = -1.
		if (global2.empires[country].now_layer >= FocusManager.all_trees[global2.empires[country].active_tree].Count) return;
		List<int> list = new List<int>();
		Empire[] empires = global2.empires;
		for (int i = 0; i < FocusManager.all_trees[empires[country].active_tree][global2.empires[country].now_layer].Count; i++)
		{
			Debug.Log($"{FocusManager.all_trees[empires[country].active_tree][global2.empires[country].now_layer][i]}");
			if (FocusManager.all_trees[empires[country].active_tree][global2.empires[country].now_layer][i].condition())
			{
				list.Add(i);
				FocusManager.all_trees[empires[country].active_tree][global2.empires[country].now_layer][i].blocked = true;
			}
			else
			{
				FocusManager.all_trees[empires[country].active_tree][global2.empires[country].now_layer][i].blocked = true;
			}
		}
		if (list.Count > 1)
		{
			global2.empires[country].now_focus = list[UnityEngine.Random.Range(0, list.Count)];
			FocusManager.all_trees[empires[country].active_tree][global2.empires[country].now_layer][global2.empires[country].now_focus].blocked = false;
		}
		else if (list.Count == 1)
		{
			global2.empires[country].now_focus = list[0];
			FocusManager.all_trees[empires[country].active_tree][global2.empires[country].now_layer][list[0]].blocked = false;
		}
		Debug.Log("СЕЙЧАС ИЗУЧАЕТ: " + global2.empires[country].now_focus);
	}
}
