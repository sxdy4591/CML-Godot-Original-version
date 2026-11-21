using System.Collections.Generic;
using UnityEngine;

public class Button_Pol_Script : MonoBehaviour
{
	public TextMesh text;

	public Politic_Manager manager;

	public BeurocratsScript bear1;

	public BeurocratsScript bear2;

	private GameObject achieves;

	private GlobalScript global1;

	public byte num;

	private bool enbaled;

	private void NeedToUpEn()
	{
		if (num == 0 || num == 15)
		{
			GetComponent<OkoshkoScript>().text_en = " 花 费 1 资 金 与\n0.5 特 工 网 络";
		}
		else if (num == 1 || num == 16)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text_en = " 伟 大 的 舵 手 万 岁 ！";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 花 费 1 资 金 与\n2 特 工 网 络";
			}
		}
		else if (num == 2)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text_en = " 伟 大 的 舵 手 万 岁 ！";
			}
			else if (((manager.selected_politic <= 5 || manager.selected_politic == 7 || (manager.selected_politic >= 11 && manager.selected_politic <= 15) || manager.selected_politic == 17) && (!GlobalScript.inst.gameState.event_done[25] || GlobalScript.inst.gameState.data[84] == 3 || (manager.selected_politic >= 12 && manager.selected_politic <= 15)) && (!GlobalScript.inst.gameState.event_done[26] || (GlobalScript.inst.gameState.leader.name_1 == 0 && manager.selected_politic != 1)) && GlobalScript.inst.gameState.data[21] < 1978 && (!GlobalScript.inst.gameState.event_done[25] || GlobalScript.inst.gameState.data[84] != 3 || (manager.selected_politic >= 1 && manager.selected_politic <= 4))) || (manager.selected_politic <= 4 && GlobalScript.inst.gameState.modifies[3].active && !GlobalScript.inst.gameState.event_done[80]))
			{
				GetComponent<OkoshkoScript>().text_en = " 等 待 事 件";
			}
			else if (manager.selected_politic <= 4 && manager.selected_politic != 2 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.event_done[80])
			{
				GetComponent<OkoshkoScript>().text_en = " 我 们 正 走 在 正 确 的 道 路 上 ！";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 花 费 2 资 金 与\n6 特 工 网 络";
			}
		}
		else if (num == 3)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text_en = " 伟 大 的 舵 手 万 岁 ！";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 花 费 2 特 工 网 络";
			}
		}
		else if (num == 4)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text_en = " 伟 大 的 舵 手 万 岁 ！";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sleshka)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 监 察 调 查";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 花 费 3 特 工 网 络";
			}
		}
		else if (num == 5)
		{
			if (GlobalScript.inst.gameState.data[38] != 100)
			{
				GetComponent<OkoshkoScript>().text_en = " 伟 大 的 舵 手 万 岁 ！";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[1] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
			}
		}
		else if (num == 6)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[2] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
			}
		}
		else if (num == 7)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[0] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
			}
		}
		else if (num == 8)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[3] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
			}
		}
		else if (num == 9)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[4] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
			}
		}
		else if (num == 10)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[6] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
			}
		}
		else if (num == 11)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[5] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
			}
		}
		else if (num != 12)
		{
			if (num != 13)
			{
				if (num == 14)
				{
					if (GlobalScript.inst.gameState.data[38] != 100)
					{
						GetComponent<OkoshkoScript>().text_en = " 伟 大 的 舵 手 万 岁 ！";
					}
					else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
					{
						GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
					}
					else if (GlobalScript.inst.gameState.faction_leader[0] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[1] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[2] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[3] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[4] == manager.selected_politic)
					{
						GetComponent<OkoshkoScript>().text_en = " 已 任 命";
					}
					else if (GlobalScript.inst.gameState.data[8] < 100 || GlobalScript.inst.gameState.data[9] < 100)
					{
						GetComponent<OkoshkoScript>().text_en = " 花 费 10 资 金 与\n10 特 工 网 络";
					}
					else
					{
						GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
					}
				}
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[7] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text_en = " 已 任 命";
			}
			else
			{
				GetComponent<OkoshkoScript>().text_en = " 是 ，当 然 可 以";
			}
		}
		else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
		{
			GetComponent<OkoshkoScript>().text_en = " 正 被 纪 律 审 查";
		}
		else if (GlobalScript.inst.gameState.politics_dolshnost[7] == manager.selected_politic)
		{
			GetComponent<OkoshkoScript>().text_en = " 已 任 命";
		}
		else
		{
			GetComponent<OkoshkoScript>().text_en = " 足 够 显 赫 的\n 政 治 地 位";
		}
	}

	private void NeedToUp()
	{
		if (num == 0 || num == 15)
		{
			GetComponent<OkoshkoScript>().text = "Нужны деньги\n0.5 агентов";
		}
		else if (num == 1 || num == 16)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text = "Слава Кормчему!";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Нужны деньги\n2.0 агентов";
			}
		}
		else if (num == 2)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text = "Слава Кормчему!";
			}
			else if ((manager.selected_politic <= 5 || manager.selected_politic == 7 || (manager.selected_politic >= 11 && manager.selected_politic <= 15) || manager.selected_politic == 17) && (!GlobalScript.inst.gameState.event_done[25] || GlobalScript.inst.gameState.data[84] == 3 || (manager.selected_politic >= 12 && manager.selected_politic <= 15)) && (!GlobalScript.inst.gameState.event_done[26] || (GlobalScript.inst.gameState.leader.name_1 == 0 && manager.selected_politic != 1)) && GlobalScript.inst.gameState.data[21] < 1978 && (!GlobalScript.inst.gameState.event_done[25] || GlobalScript.inst.gameState.data[84] != 3 || (manager.selected_politic >= 2 && manager.selected_politic <= 4)))
			{
				GetComponent<OkoshkoScript>().text = "Дождитесь события";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "2.0 денег\n6.0 агентов";
			}
		}
		else if (num == 3)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text = "Слава Кормчему!";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "2.0 агентов";
			}
		}
		else if (num == 4)
		{
			if (GlobalScript.inst.gameState.data[38] != 100 && manager.selected_politic == 0)
			{
				GetComponent<OkoshkoScript>().text = "Слава Кормчему!";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sleshka)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся слежка";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "3.0 агентов";
			}
		}
		else if (num == 5)
		{
			if (GlobalScript.inst.gameState.data[38] != 100)
			{
				GetComponent<OkoshkoScript>().text = "Слава Кормчему!";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[1] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 6)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[2] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 7)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[0] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 8)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[3] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 9)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[4] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 10)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[6] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 11)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[5] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 12)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[7] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
		else if (num == 13)
		{
			GetComponent<OkoshkoScript>().text = "Да, ты можешь";
		}
		else if (num == 14)
		{
			if (GlobalScript.inst.gameState.data[38] != 100)
			{
				GetComponent<OkoshkoScript>().text = "Слава Кормчему!";
			}
			else if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GetComponent<OkoshkoScript>().text = "Ведётся следствие";
			}
			else if (GlobalScript.inst.gameState.faction_leader[0] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[1] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[2] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[3] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[4] == manager.selected_politic)
			{
				GetComponent<OkoshkoScript>().text = "Уже назначен";
			}
			else if (GlobalScript.inst.gameState.data[8] < 100 || GlobalScript.inst.gameState.data[9] < 100)
			{
				GetComponent<OkoshkoScript>().text = "10.0 агентов и денег";
			}
			else
			{
				GetComponent<OkoshkoScript>().text = "Соответствование\nиерархии";
			}
		}
	}

	public void Repaint()
	{
		if (achieves == null)
		{
			achieves = GameObject.Find("Ach(Clone)");
		}
		int num = 1;
		for (int i = 0; i < GlobalScript.inst.gameState.p_forth.Length; i++)
		{
			if (GlobalScript.inst.gameState.p_forth[i] == manager.selected_politic)
			{
				num = 4;
				break;
			}
		}
		for (int j = 0; j < GlobalScript.inst.gameState.p_third.Length; j++)
		{
			if (GlobalScript.inst.gameState.p_third[j] == manager.selected_politic)
			{
				num = 3;
				break;
			}
		}
		switch (this.num)
		{
		case 0:
			enbaled = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 1 && GlobalScript.inst.gameState.data[9] >= 5 && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie;
			break;
		case 1:
			enbaled = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 1 && GlobalScript.inst.gameState.data[9] >= 20 && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2) && (GlobalScript.inst.gameState.data[38] == 100 || manager.selected_politic > 0);
			break;
		case 2:
			enbaled = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 20 && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && GlobalScript.inst.gameState.data[9] >= 60 && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2) && ((manager.selected_politic > 5 && manager.selected_politic != 7 && (manager.selected_politic < 11 || manager.selected_politic > 15) && manager.selected_politic != 17) || (GlobalScript.inst.gameState.event_done[25] && GlobalScript.inst.gameState.data[84] != 3 && (manager.selected_politic < 12 || manager.selected_politic > 15)) || (GlobalScript.inst.gameState.event_done[26] && (GlobalScript.inst.gameState.leader.name_1 != 0 || manager.selected_politic == 1)) || GlobalScript.inst.gameState.data[21] >= 1978 || (GlobalScript.inst.gameState.event_done[25] && GlobalScript.inst.gameState.data[84] == 3 && (manager.selected_politic < 1 || manager.selected_politic > 4))) && (GlobalScript.inst.gameState.data[38] == 100 || manager.selected_politic > 0) && (manager.selected_politic > 4 || !GlobalScript.inst.gameState.modifies[3].active || GlobalScript.inst.gameState.event_done[80]) && (manager.selected_politic > 4 || manager.selected_politic == 2 || !GlobalScript.inst.gameState.modifies[3].active || !GlobalScript.inst.gameState.event_done[80]);
			break;
		case 3:
			enbaled = GlobalScript.inst.gameState.data[9] >= 20 && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2) && (GlobalScript.inst.gameState.data[38] == 100 || manager.selected_politic > 0);
			break;
		case 4:
			enbaled = GlobalScript.inst.gameState.data[9] >= 30 && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sleshka && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2) && (GlobalScript.inst.gameState.data[38] == 100 || manager.selected_politic > 0);
			break;
		case 5:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[1] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 2 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2) && GlobalScript.inst.gameState.data[38] == 100;
			break;
		case 6:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[2] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 2 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2);
			break;
		case 7:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[0] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 2 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2);
			break;
		case 8:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[3] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2);
			break;
		case 9:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[4] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2);
			break;
		case 10:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[6] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2);
			break;
		case 11:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[5] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2);
			break;
		case 12:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[7] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2);
			break;
		case 13:
			enbaled = GlobalScript.inst.gameState.politics_dolshnost[1] != manager.selected_politic && manager.selected_politic == 150 && GlobalScript.inst.gameState.data[38] == 100;
			break;
		case 14:
			enbaled = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 100 && GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.faction_leader[0] != manager.selected_politic && GlobalScript.inst.gameState.faction_leader[1] != manager.selected_politic && GlobalScript.inst.gameState.faction_leader[2] != manager.selected_politic && GlobalScript.inst.gameState.faction_leader[3] != manager.selected_politic && GlobalScript.inst.gameState.faction_leader[4] != manager.selected_politic && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && num <= 2 && GlobalScript.inst.gameState.data[38] == 100;
			break;
		case 15:
			enbaled = GlobalScript.inst.gameState.politics[manager.selected_politic].autosupport == 10 || (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 1 && GlobalScript.inst.gameState.data[9] >= 5 && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie);
			base.gameObject.transform.GetChild(0).GetComponent<TextMesh>().color = new Color(0.04f, GlobalScript.inst.gameState.politics[manager.selected_politic].autosupport, 0f);
			break;
		case 16:
			enbaled = GlobalScript.inst.gameState.politics[manager.selected_politic].autohound == 10 || (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 1 && GlobalScript.inst.gameState.data[9] >= 20 && !GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie && (num <= 3 || (GlobalScript.inst.gameState.politics[manager.selected_politic].loyality >= 700 && GlobalScript.inst.gameState.gamerules[5] == 1) || GlobalScript.inst.gameState.gamerules[5] == 2) && (GlobalScript.inst.gameState.data[38] == 100 || manager.selected_politic > 0));
			base.gameObject.transform.GetChild(0).GetComponent<TextMesh>().color = new Color(0.04f, GlobalScript.inst.gameState.politics[manager.selected_politic].autohound, 0f);
			break;
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			NeedToUpEn();
		}
		else
		{
			NeedToUp();
		}
		if (enbaled)
		{
			GetComponent<SpriteRenderer>().color = Color.white;
		}
		else
		{
			GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 0.3f, 1f);
		}
	}

	private void OnMouseDown()
	{
		if (!enbaled)
		{
			return;
		}
		if (this.num == 0)
		{
			GlobalScript.inst.gameState.data[8]--;
			GlobalScript.inst.gameState.data[1] -= 20;
			GlobalScript.inst.gameState.data[9] -= 5;
			GlobalScript.inst.gameState.politics[manager.selected_politic].power += (GlobalScript.inst.gameState.data[21] - 1976) * 5;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 50;
			GlobalScript.inst.gameState.politics[manager.selected_politic].power += Mathf.Abs(GlobalScript.inst.gameState.politics[manager.selected_politic].power / 10);
		}
		else if (this.num == 1)
		{
			GlobalScript.inst.gameState.data[8]--;
			GlobalScript.inst.gameState.data[1] -= 20;
			GlobalScript.inst.gameState.data[9] -= 20;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality -= 50;
			GlobalScript.inst.gameState.politics[manager.selected_politic].power -= (GlobalScript.inst.gameState.data[21] - 1976) * 5;
			GlobalScript.inst.gameState.politics[manager.selected_politic].power -= Mathf.Abs(GlobalScript.inst.gameState.politics[manager.selected_politic].power / 10);
		}
		else if (this.num == 15)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].autosupport == 0)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].autosupport = 10;
			}
			else
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].autosupport = 0;
			}
			base.gameObject.transform.GetChild(0).GetComponent<TextMesh>().color = new Color(0.04f, GlobalScript.inst.gameState.politics[manager.selected_politic].autosupport, 0f);
		}
		else if (this.num == 16)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].autohound == 0)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].autohound = 10;
			}
			else
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].autohound = 0;
			}
			base.gameObject.transform.GetChild(0).GetComponent<TextMesh>().color = new Color(0.04f, GlobalScript.inst.gameState.politics[manager.selected_politic].autohound, 0f);
		}
		else if (this.num == 2)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie)
			{
				GlobalScript.inst.gameState.data[9] -= 60;
			}
			else
			{
				GlobalScript.inst.gameState.data[9] -= 100;
			}
			GlobalScript.inst.gameState.data[8] -= 20;
			if (Random.Range(0f, 1f) <= GlobalScript.inst.gameState.ChangeOfKilling(manager.selected_politic))
			{
				GlobalScript.inst.gameState.data[4] += 100;
				if (GlobalScript.inst.gameState.faction_leader[0] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[1] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[2] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[3] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[4] == manager.selected_politic)
				{
					Politic[] politics = GlobalScript.inst.gameState.politics;
					foreach (Politic politic in politics)
					{
						if (politic.traits[0] == GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0])
						{
							politic.loyality -= 300;
						}
					}
				}
				else
				{
					Politic[] politics = GlobalScript.inst.gameState.politics;
					foreach (Politic politic2 in politics)
					{
						if (politic2.traits[0] == GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0])
						{
							politic2.loyality -= 5;
						}
					}
				}
				GlobalScript.inst.gameState.data[110]++;
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.data[110] >= 44)
				{
					achieves.GetComponent<achievements>().Set(24);
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[0] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.data[114] = 9;
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[1] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.data[115] = 9;
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[2] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.data[116] = 9;
				}
				GlobalScript.inst.gameState.KillPerson(manager.selected_politic);
				manager.ResetPolitics();
			}
			else
			{
				GlobalScript.inst.gameState.data[4] += 100;
				Politic[] politics2 = GlobalScript.inst.gameState.politics;
				for (int j = 0; j < politics2.Length; j++)
				{
					politics2[j].loyality -= 100;
				}
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality -= 400;
				GlobalScript.inst.gameState.politics[manager.selected_politic].you_fall = true;
			}
		}
		else if (this.num == 3)
		{
			GlobalScript.inst.gameState.politics[manager.selected_politic].is_sledstvie = true;
			GlobalScript.inst.gameState.politics[manager.selected_politic].sled_slej = 0;
			GlobalScript.inst.gameState.data[9] -= 20;
			if (GlobalScript.inst.gameState.faction_leader[0] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[1] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[2] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[3] == manager.selected_politic || GlobalScript.inst.gameState.faction_leader[4] == manager.selected_politic)
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic3 in politics)
				{
					if (politic3.traits[0] == GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0])
					{
						politic3.loyality -= 1000;
					}
				}
			}
			else
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic4 in politics)
				{
					if (politic4.traits[0] == GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0])
					{
						politic4.loyality -= 100;
					}
				}
			}
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality -= 2000;
		}
		else if (this.num == 4)
		{
			GlobalScript.inst.gameState.politics[manager.selected_politic].is_sleshka = true;
			GlobalScript.inst.gameState.politics[manager.selected_politic].days_sleshka = 0;
			GlobalScript.inst.gameState.data[9] -= 30;
		}
		else if (this.num == 13)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[1] < 100)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].loyality -= 1000;
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].loyality_to_other[manager.selected_politic] -= 500;
			}
			GlobalScript.inst.gameState.politics_dolshnost[1] = manager.selected_politic;
			for (int k = 3; k < GlobalScript.inst.gameState.politics_dolshnost.Length; k++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[k] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[k] = 200;
				}
			}
		}
		else if (this.num == 5)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[1] < 100)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].loyality -= 700 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].wantedDolzh == 1) ? 400 : 0);
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].loyality_to_other[manager.selected_politic] -= 300 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].wantedDolzh == 1) ? 400 : 0);
			}
			GlobalScript.inst.gameState.politics_dolshnost[1] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 350;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 1)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
			if (GlobalScript.inst.gameState.politics_dolshnost[2] == manager.selected_politic)
			{
				GlobalScript.inst.gameState.politics_dolshnost[2] = 200;
			}
			for (int l = 3; l < GlobalScript.inst.gameState.politics_dolshnost.Length; l++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[l] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[l] = 200;
				}
			}
		}
		else if (this.num == 6)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[2] < 100)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[2]].loyality -= 600 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[2]].wantedDolzh == 2) ? 400 : 0);
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[2]].loyality_to_other[manager.selected_politic] -= 250 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[2]].wantedDolzh == 2) ? 400 : 0);
			}
			GlobalScript.inst.gameState.politics_dolshnost[2] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 350;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 2)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
			if (GlobalScript.inst.gameState.politics_dolshnost[1] == manager.selected_politic)
			{
				GlobalScript.inst.gameState.politics_dolshnost[1] = 200;
			}
			for (int m = 3; m < GlobalScript.inst.gameState.politics_dolshnost.Length; m++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[m] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[m] = 200;
				}
			}
		}
		else if (this.num == 7)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[0] < 100)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[0]].loyality -= 800 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[0]].wantedDolzh == 0) ? 400 : 0);
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[0]].loyality_to_other[manager.selected_politic] -= 400 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[0]].wantedDolzh == 0) ? 400 : 0);
			}
			GlobalScript.inst.gameState.politics_dolshnost[0] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 400;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 0)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
			for (int n = 1; n < GlobalScript.inst.gameState.politics_dolshnost.Length; n++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[n] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[n] = 200;
				}
			}
		}
		else if (this.num == 8)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[3] < 100)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[3]].loyality -= 250 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[3]].wantedDolzh == 3) ? 400 : 0);
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[3]].loyality_to_other[manager.selected_politic] -= 50 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[3]].wantedDolzh == 3) ? 400 : 0);
			}
			for (int num = 3; num < GlobalScript.inst.gameState.politics_dolshnost.Length; num++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[num] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[num] = 200;
				}
			}
			GlobalScript.inst.gameState.politics_dolshnost[3] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 300;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 3)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
		}
		else if (this.num == 9)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[4] < 100)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[4]].loyality -= 150 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[4]].wantedDolzh == 4) ? 400 : 0);
			}
			for (int num2 = 3; num2 < GlobalScript.inst.gameState.politics_dolshnost.Length; num2++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[num2] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[num2] = 200;
				}
			}
			GlobalScript.inst.gameState.politics_dolshnost[4] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 4)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
		}
		else if (this.num == 10)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[6] != 200 && GlobalScript.inst.gameState.politics_dolshnost[6] != 150)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[6]].loyality -= 150 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[6]].wantedDolzh == 6) ? 400 : 0);
			}
			for (int num3 = 3; num3 < GlobalScript.inst.gameState.politics_dolshnost.Length; num3++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[num3] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[num3] = 200;
				}
			}
			GlobalScript.inst.gameState.politics_dolshnost[6] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 6)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
		}
		else if (this.num == 11)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[5] != 200 && GlobalScript.inst.gameState.politics_dolshnost[5] != 150)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[5]].loyality -= 150 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[5]].wantedDolzh == 5) ? 400 : 0);
			}
			for (int num4 = 3; num4 < GlobalScript.inst.gameState.politics_dolshnost.Length; num4++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[num4] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[num4] = 200;
				}
			}
			GlobalScript.inst.gameState.politics_dolshnost[5] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 5)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
		}
		else if (this.num == 12)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[7] != 200 && GlobalScript.inst.gameState.politics_dolshnost[7] != 150)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[7]].loyality -= 150 + ((GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[7]].wantedDolzh == 7) ? 400 : 0);
			}
			for (int num5 = 3; num5 < GlobalScript.inst.gameState.politics_dolshnost.Length; num5++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[num5] == manager.selected_politic)
				{
					GlobalScript.inst.gameState.politics_dolshnost[num5] = 200;
				}
			}
			GlobalScript.inst.gameState.politics_dolshnost[7] = manager.selected_politic;
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].wantedDolzh == 7)
			{
				GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 250;
			}
		}
		else if (this.num == 14)
		{
			if (GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0] > 0)
			{
				if (GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0] != 20)
				{
					GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0] + 1]].loyality -= 1000;
					GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0] + 1]].loyality_to_other[manager.selected_politic] -= 500;
					GlobalScript.inst.gameState.faction_leader[GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0] + 1] = manager.selected_politic;
				}
				else
				{
					GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[1]].loyality -= 1000;
					GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[1]].loyality_to_other[manager.selected_politic] -= 500;
					GlobalScript.inst.gameState.faction_leader[1] = manager.selected_politic;
				}
			}
			else
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0]]].loyality -= 1000;
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0]]].loyality_to_other[manager.selected_politic] -= 500;
				GlobalScript.inst.gameState.faction_leader[GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0]] = manager.selected_politic;
			}
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic5 in politics)
			{
				if (politic5.traits[0] == GlobalScript.inst.gameState.politics[manager.selected_politic].traits[0])
				{
					politic5.loyality -= 100;
				}
			}
			GlobalScript.inst.gameState.politics[manager.selected_politic].loyality += 400;
		}
		GlobalScript.inst.gameState.BalancePolitic(new List<byte>());
		manager.ResetPolitics();
		GetComponent<OkoshkoScript>().OnMouseExit();
		manager.Politic_Selected(200);
		manager.RepaintData();
		bear1.Repaint();
		bear2.Repaint();
	}

	private void Awake()
	{
		global1 = GlobalScript.inst;
	}
}
