using UnityEngine;

public class Doctrine_script : MonoBehaviour
{
	public GlobalScript global1;

	public int this_number;

	public Sprite navel;

	public Sprite nenavel;

	public GameObject[] buttons = new GameObject[6];

	private bool is_active;

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = navel;
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = nenavel;
	}

	public void ShowHideOcno()
	{
		for (int i = 0; i < 6; i++)
		{
			buttons[i].SetActive(value: false);
		}
	}

	private void OnMouseDown()
	{
		int num = 0;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this_number == 16)
			{
				if (!GlobalScript.inst.gameState.modifies[11].active)
				{
					if (!GlobalScript.inst.gameState.completedDecisions[18])
					{
						if (GlobalScript.inst.gameState.resultOfEvents[503] == 0)
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("中央\n计划经济", 10, this_number);
							num = 0;
						}
						else if (GlobalScript.inst.gameState.modifies[6].active)
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("经典\n计划经济", 10, this_number);
							buttons[1].GetComponent<Doctrine_button_script>().Show("中式\n计划经济", 11, this_number);
							buttons[2].GetComponent<Doctrine_button_script>().Show("国家垄断\n资本主义", 12, this_number);
							buttons[3].GetComponent<Doctrine_button_script>().Show("国家监护\n资本主义", 13, this_number);
							if (!GlobalScript.inst.gameState.completedDecisions[13])
							{
								buttons[4].GetComponent<Doctrine_button_script>().Show("社会主义\n导向市场", 14, this_number);
								buttons[5].GetComponent<Doctrine_button_script>().Show("左翼小政府", 15, this_number);
								num = 5;
							}
							else
							{
								num = 3;
							}
						}
						else
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("中央\n计划经济", 10, this_number);
							buttons[1].GetComponent<Doctrine_button_script>().Show("分权\n计划经济", 11, this_number);
							buttons[2].GetComponent<Doctrine_button_script>().Show("国家垄断\n资本主义", 12, this_number);
							buttons[3].GetComponent<Doctrine_button_script>().Show("鸟笼经济", 13, this_number);
							if (!GlobalScript.inst.gameState.completedDecisions[13])
							{
								buttons[4].GetComponent<Doctrine_button_script>().Show("混合经济", 14, this_number);
								buttons[5].GetComponent<Doctrine_button_script>().Show("最小干预", 15, this_number);
								num = 5;
							}
							else
							{
								num = 3;
							}
						}
					}
					else
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("国家垄断\n资本主义", 12, this_number);
						num = 0;
					}
				}
				else
				{
					buttons[0].GetComponent<Doctrine_button_script>().Show("国家信息\n自动化系统", 10, this_number);
					buttons[1].GetComponent<Doctrine_button_script>().Show("赛博协同\n控制工程", 11, this_number);
					num = 1;
				}
			}
			else if (this_number == 15)
			{
				if (!GlobalScript.inst.gameState.event_done[444] || GlobalScript.inst.gameState.resultOfEvents[444] != 0)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[503] == 0)
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("一党专政", 6, this_number);
						num = 0;
					}
					else if (GlobalScript.inst.gameState.modifies[6].active)
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("无产阶级专政", 6, this_number);
						buttons[1].GetComponent<Doctrine_button_script>().Show("新民主主义制度", 7, this_number);
						if (!GlobalScript.inst.gameState.completedDecisions[13] && !GlobalScript.inst.gameState.modifies[24].active && !GlobalScript.inst.gameState.completedDecisions[16])
						{
							buttons[2].GetComponent<Doctrine_button_script>().Show("人民民主制度", 8, this_number);
							buttons[3].GetComponent<Doctrine_button_script>().Show("协和民主体制", 9, this_number);
							num = 3;
						}
						else
						{
							num = 1;
						}
					}
					else
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("一党专政\n党内民主", 6, this_number);
						buttons[1].GetComponent<Doctrine_button_script>().Show("一党独大式民主", 7, this_number);
						if (!GlobalScript.inst.gameState.completedDecisions[13] && !GlobalScript.inst.gameState.modifies[24].active && !GlobalScript.inst.gameState.completedDecisions[16])
						{
							buttons[2].GetComponent<Doctrine_button_script>().Show("宪政民主制度", 8, this_number);
							buttons[3].GetComponent<Doctrine_button_script>().Show("协和民主体制", 9, this_number);
							num = 3;
						}
						else
						{
							num = 1;
						}
					}
				}
				else
				{
					buttons[0].GetComponent<Doctrine_button_script>().Show("无产阶级专政", 6, this_number);
					num = 0;
				}
			}
			else if (this_number == 17)
			{
				if (!GlobalScript.inst.gameState.event_done[444] || GlobalScript.inst.gameState.resultOfEvents[444] != 0)
				{
					buttons[0].GetComponent<Doctrine_button_script>().Show("舆论一律", 16, this_number);
					if (!GlobalScript.inst.gameState.modifies[26].active && GlobalScript.inst.gameState.resultOfEvents[503] != 0)
					{
						buttons[1].GetComponent<Doctrine_button_script>().Show("纪律约束", 17, this_number);
						buttons[2].GetComponent<Doctrine_button_script>().Show("自然限制", 18, this_number);
						buttons[3].GetComponent<Doctrine_button_script>().Show("多元自由", 19, this_number);
						num = 3;
					}
					else
					{
						num = 0;
					}
				}
				else
				{
					buttons[0].GetComponent<Doctrine_button_script>().Show("自由境界", 19, this_number);
					num = 0;
				}
			}
			else if (this_number == 18)
			{
				if (GlobalScript.inst.gameState.event_done[551] && GlobalScript.inst.gameState.resultOfEvents[551] == 3)
				{
					if (GlobalScript.inst.gameState.modifies[6].active)
					{
						if (GlobalScript.inst.gameState.resultOfEvents[550] == 0)
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("美国模式\n联邦制", 21, this_number);
						}
						else if (GlobalScript.inst.gameState.resultOfEvents[550] == 1)
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("苏联模式\n联邦制", 21, this_number);
						}
						else
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("改良区域\n自治制度", 21, this_number);
						}
						buttons[1].GetComponent<Doctrine_button_script>().Show("联邦制", 22, this_number);
						buttons[2].GetComponent<Doctrine_button_script>().Show("自治联盟", 23, this_number);
						num = 2;
					}
					else
					{
						if (GlobalScript.inst.gameState.resultOfEvents[550] == 0)
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("美国模式\n联邦制", 21, this_number);
						}
						else if (GlobalScript.inst.gameState.resultOfEvents[550] == 1)
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("苏联模式\n联邦制", 21, this_number);
						}
						else
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("联邦制", 21, this_number);
						}
						buttons[1].GetComponent<Doctrine_button_script>().Show("联省自治", 22, this_number);
						buttons[2].GetComponent<Doctrine_button_script>().Show("自治联盟", 23, this_number);
						num = 2;
					}
				}
				else if (GlobalScript.inst.gameState.event_done[550] && (GlobalScript.inst.gameState.resultOfEvents[550] == 2 || GlobalScript.inst.gameState.resultOfEvents[550] == 3))
				{
					if (GlobalScript.inst.gameState.resultOfEvents[550] == 2)
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("中国特色\n联邦制", 21, this_number);
						num = 0;
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[550] == 3)
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("单一制", 20, this_number);
						num = 0;
					}
				}
				else
				{
					if (GlobalScript.inst.gameState.modifies[6].active)
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("单一制", 20, this_number);
						if (GlobalScript.inst.gameState.resultOfEvents[550] == 0)
						{
							buttons[1].GetComponent<Doctrine_button_script>().Show("美国模式\n联邦制", 21, this_number);
						}
						else if (GlobalScript.inst.gameState.resultOfEvents[550] == 1)
						{
							buttons[1].GetComponent<Doctrine_button_script>().Show("苏联模式\n联邦制", 21, this_number);
						}
						else
						{
							buttons[1].GetComponent<Doctrine_button_script>().Show("改良区域\n自治制度", 21, this_number);
						}
						buttons[2].GetComponent<Doctrine_button_script>().Show("联邦制", 22, this_number);
						buttons[3].GetComponent<Doctrine_button_script>().Show("自治联盟", 23, this_number);
					}
					else
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("单一制", 20, this_number);
						if (GlobalScript.inst.gameState.resultOfEvents[550] == 0)
						{
							buttons[1].GetComponent<Doctrine_button_script>().Show("美国模式\n联邦制", 21, this_number);
						}
						else if (GlobalScript.inst.gameState.resultOfEvents[550] == 1)
						{
							buttons[1].GetComponent<Doctrine_button_script>().Show("苏联模式\n联邦制", 21, this_number);
						}
						else
						{
							buttons[1].GetComponent<Doctrine_button_script>().Show("联邦制", 21, this_number);
						}
						buttons[2].GetComponent<Doctrine_button_script>().Show("联省自治", 22, this_number);
						buttons[3].GetComponent<Doctrine_button_script>().Show("自治联盟", 23, this_number);
					}
					num = 3;
				}
			}
			else if (this_number == 50)
			{
				if (!GlobalScript.inst.gameState.event_done[444] || GlobalScript.inst.gameState.resultOfEvents[444] != 0)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[503] == 0)
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("政教协定", 29, this_number);
						num = 0;
					}
					else if (!GlobalScript.inst.gameState.modifies[25].active && !GlobalScript.inst.gameState.completedDecisions[16])
					{
						if (GlobalScript.inst.gameState.modifies[6].active)
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("文化革命", 24, this_number);
							buttons[1].GetComponent<Doctrine_button_script>().Show("无神国家", 25, this_number);
							buttons[2].GetComponent<Doctrine_button_script>().Show("民宗管制", 26, this_number);
							buttons[3].GetComponent<Doctrine_button_script>().Show("世俗主义", 27, this_number);
							buttons[4].GetComponent<Doctrine_button_script>().Show("尊崇传统", 28, this_number);
							buttons[5].GetComponent<Doctrine_button_script>().Show("政教协定", 29, this_number);
							num = 5;
						}
						else
						{
							buttons[0].GetComponent<Doctrine_button_script>().Show("破除传统", 24, this_number);
							buttons[1].GetComponent<Doctrine_button_script>().Show("无神国家", 25, this_number);
							buttons[2].GetComponent<Doctrine_button_script>().Show("民宗管制", 26, this_number);
							buttons[3].GetComponent<Doctrine_button_script>().Show("世俗主义", 27, this_number);
							buttons[4].GetComponent<Doctrine_button_script>().Show("尊崇传统", 28, this_number);
							buttons[5].GetComponent<Doctrine_button_script>().Show("政教协定", 29, this_number);
							num = 5;
						}
					}
					else
					{
						buttons[0].GetComponent<Doctrine_button_script>().Show("尊崇传统", 28, this_number);
						buttons[1].GetComponent<Doctrine_button_script>().Show("政教协定", 29, this_number);
						num = 1;
					}
				}
				else
				{
					buttons[0].GetComponent<Doctrine_button_script>().Show("文化革命", 24, this_number);
					num = 0;
				}
			}
			else if (this_number == 51)
			{
				buttons[0].GetComponent<Doctrine_button_script>().Show("全民皆兵", 30, this_number);
				buttons[1].GetComponent<Doctrine_button_script>().Show("积极建军", 31, this_number);
				buttons[2].GetComponent<Doctrine_button_script>().Show("建设国防", 32, this_number);
				buttons[3].GetComponent<Doctrine_button_script>().Show("合同兵制", 33, this_number);
				num = 3;
			}
		}
		else if (this_number == 16)
		{
			if (!GlobalScript.inst.gameState.completedDecisions[18])
			{
				buttons[0].GetComponent<Doctrine_button_script>().Show("Государственное\nпланирование", 10, this_number);
				buttons[1].GetComponent<Doctrine_button_script>().Show("Автоматизация", 11, this_number);
				buttons[2].GetComponent<Doctrine_button_script>().Show("Государственный\nмонополизм", 12, this_number);
				buttons[3].GetComponent<Doctrine_button_script>().Show("Птичья\nклетка", 13, this_number);
				if (!GlobalScript.inst.gameState.completedDecisions[13])
				{
					buttons[4].GetComponent<Doctrine_button_script>().Show("Смешанная\nэкономика", 14, this_number);
					buttons[5].GetComponent<Doctrine_button_script>().Show("Минимальное\nрегулирование", 15, this_number);
					num = 5;
				}
				else
				{
					num = 3;
				}
			}
			else
			{
				buttons[0].GetComponent<Doctrine_button_script>().Show("Государственный\nмонополизм", 12, this_number);
				num = 0;
			}
		}
		else if (this_number == 15)
		{
			buttons[0].GetComponent<Doctrine_button_script>().Show("Однопартийная\nдемократия", 6, this_number);
			buttons[1].GetComponent<Doctrine_button_script>().Show("Новая\nдемократия", 7, this_number);
			if (!GlobalScript.inst.gameState.completedDecisions[13] && !GlobalScript.inst.gameState.modifies[24].active && !GlobalScript.inst.gameState.completedDecisions[16])
			{
				buttons[2].GetComponent<Doctrine_button_script>().Show("Контроль над\nпартиями", 8, this_number);
				buttons[3].GetComponent<Doctrine_button_script>().Show("Многопартийная\nдемократия", 9, this_number);
				num = 3;
			}
			else
			{
				num = 1;
			}
		}
		else if (this_number == 17)
		{
			buttons[0].GetComponent<Doctrine_button_script>().Show("Борьба с\nинакомыслием", 16, this_number);
			if (!GlobalScript.inst.gameState.modifies[26].active)
			{
				buttons[1].GetComponent<Doctrine_button_script>().Show("Ограниченные", 17, this_number);
				buttons[2].GetComponent<Doctrine_button_script>().Show("Малый контроль", 18, this_number);
				buttons[3].GetComponent<Doctrine_button_script>().Show("Полная\nлиберализация", 19, this_number);
				num = 3;
			}
			else
			{
				num = 0;
			}
		}
		else if (this_number == 18)
		{
			buttons[0].GetComponent<Doctrine_button_script>().Show("Унитаризм", 20, this_number);
			buttons[1].GetComponent<Doctrine_button_script>().Show("Федерация", 21, this_number);
			buttons[2].GetComponent<Doctrine_button_script>().Show("Конфедерация", 22, this_number);
			buttons[3].GetComponent<Doctrine_button_script>().Show("Союз автономий", 23, this_number);
			num = 3;
		}
		else if (this_number == 50)
		{
			if (!GlobalScript.inst.gameState.modifies[25].active && !GlobalScript.inst.gameState.completedDecisions[16])
			{
				buttons[0].GetComponent<Doctrine_button_script>().Show("Борьба с\nтрадициями", 24, this_number);
				buttons[1].GetComponent<Doctrine_button_script>().Show("Поддержка\nатеизма", 25, this_number);
				buttons[2].GetComponent<Doctrine_button_script>().Show("Надзор за\nверующими", 26, this_number);
				buttons[3].GetComponent<Doctrine_button_script>().Show("Светское\nгосударство", 27, this_number);
				buttons[4].GetComponent<Doctrine_button_script>().Show("Опора на\nтрадиции", 28, this_number);
				buttons[5].GetComponent<Doctrine_button_script>().Show("Конкордат", 29, this_number);
				num = 5;
			}
			else
			{
				buttons[0].GetComponent<Doctrine_button_script>().Show("Опора на\nтрадиции", 28, this_number);
				buttons[1].GetComponent<Doctrine_button_script>().Show("Конкордат", 29, this_number);
				num = 1;
			}
		}
		else if (this_number == 51)
		{
			buttons[0].GetComponent<Doctrine_button_script>().Show("Полная\nмилитаризация", 30, this_number);
			buttons[1].GetComponent<Doctrine_button_script>().Show("Наращивание\nмощи", 31, this_number);
			buttons[2].GetComponent<Doctrine_button_script>().Show("Оборонительная\nармия", 32, this_number);
			buttons[3].GetComponent<Doctrine_button_script>().Show("Контрактная\nармия", 33, this_number);
			num = 3;
		}
		for (int i = 0; i < 6; i++)
		{
			if (i <= num)
			{
				buttons[i].SetActive(value: true);
				buttons[i].GetComponent<Doctrine_button_script>().doctr1 = GetComponent<Doctrine_script>();
			}
			else
			{
				buttons[i].SetActive(value: false);
			}
		}
	}
}
