using UnityEngine;

public class ModifyButtonScript : MonoBehaviour
{
	public OkoshkoScript okno1;

	public int num;

	public SpriteRenderer focus_sprite;

	private GameState a;

	public Sprite[] znachki = new Sprite[0];

	public Sprite[] sub_znachki = new Sprite[0];

	public Sprite[] special = new Sprite[1];

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public void ChangeText(int num, bool activated)
	{
		okno1.needAutoText = true;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		if (GlobalScript.inst.gameState.data[21] < 1981)
		{
			if (GlobalScript.inst.gameState.empires[0].power > GlobalScript.inst.gameState.empires[1].power)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.empires[0].power > GlobalScript.inst.gameState.influencePRC)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[1].power)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.OAR)
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.allcountries[15].cw)
			{
				num4++;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				num4++;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
			{
				num4++;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
			{
				num4++;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[46] == 2)
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.ingamewars[5].is_going)
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.allcountries[84].Gosstroy == 0)
			{
				num3++;
			}
			else
			{
				num4++;
			}
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 3 || GlobalScript.inst.gameState.allcountries[8].Vyshi)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.event_done[455] && GlobalScript.inst.gameState.resultOfEvents[455] == 0)
			{
				num4++;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[455] == 1)
			{
				num4 += 2;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[455] == 2)
			{
				num4 -= 2;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[455] == 3)
			{
				num4--;
			}
		}
		else
		{
			if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
			{
				num3 += 7;
			}
			if (a.empires[0].power > a.empires[1].power)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.empires[0].power > a.influencePRC)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.allcountries[1].Gosstroy == 3)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.allcountries[85].isNATO)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.allcountries[92].isNATO)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.allcountries[21].isNATO)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.allcountries[84].isNATO)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.allcountries[17].isNATO)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (!a.allcountries[1].isSEV)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (!a.allcountries[1].isOVD)
			{
				num4++;
			}
			else
			{
				num3++;
			}
			if (a.allcountries[15].cw)
			{
				num4++;
			}
			if (a.empires[1].now_leader == 3)
			{
				num4++;
			}
			if (a.allcountries[1].isASEAN)
			{
				num4++;
			}
			if (GlobalScript.inst.gameState.ingamewars[5].is_going)
			{
				num3++;
			}
			if (a.allcountries[2].puppetOf == 7)
			{
				num3++;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
			{
				num4++;
			}
		}
		int[] array = new int[4];
		if (a.resultOfEvents[384] == 1)
		{
			array[0] += 2;
		}
		if (a.data[49] > a.data[48])
		{
			array[0] += 2;
		}
		if (a.resultOfEvents[49] == 1)
		{
			array[0]++;
		}
		if (a.resultOfEvents[50] == 3)
		{
			array[0]--;
		}
		if (a.allcountries[2].puppetOf == 7)
		{
			array[0]--;
		}
		if (a.allcountries[4].Gosstroy == 1)
		{
			array[0]++;
		}
		if (a.allcountries[45].Gosstroy == 2)
		{
			array[0]++;
		}
		if (a.allcountries[8].Gosstroy == 1)
		{
			array[0]++;
		}
		if (a.allcountries[1].isOVD)
		{
			array[0]++;
		}
		if (a.allcountries[1].isSEV)
		{
			array[0]++;
		}
		if (a.empires[1].power > a.empires[0].power)
		{
			array[0]++;
		}
		if (a.empires[1].power > a.data[7])
		{
			array[0]++;
		}
		if (a.modifies[16].active)
		{
			array[0]++;
		}
		if (a.resultOfEvents[384] == 2)
		{
			array[1] += 2;
		}
		if (a.data[132] == 2)
		{
			array[1]++;
		}
		if (a.allcountries[51].dev > 0)
		{
			array[1]++;
		}
		if (a.allcountries[1].isSEATO)
		{
			array[1]++;
		}
		if (a.allcountries[1].isASEAN)
		{
			array[1]++;
		}
		if (a.resultOfEvents[50] == 4 || a.resultOfEvents[52] == 2)
		{
			array[1]++;
		}
		if (a.allcountries[1].okb)
		{
			array[1]++;
		}
		if (a.allcountries[8].Gosstroy == 3)
		{
			array[1]++;
		}
		if (!a.allcountries[12].proprc && a.allcountries[12].Gosstroy == 0)
		{
			array[1]++;
		}
		if (a.empires[0].power > a.empires[1].power)
		{
			array[1]++;
		}
		if (a.empires[0].power > a.data[7])
		{
			array[1]++;
		}
		if (a.modifies[17].active)
		{
			array[1]++;
		}
		if (a.resultOfEvents[46] == 2)
		{
			array[1]--;
		}
		if (a.influencePRC > a.empires[0].power && a.influencePRC > a.empires[1].power)
		{
			array[2]++;
		}
		if (a.resultOfEvents[384] == 3)
		{
			array[2] += 2;
		}
		if (a.allcountries[15].cw)
		{
			array[2]++;
		}
		if (a.allcountries[8].Vyshi && a.allcountries[8].Gosstroy == 0)
		{
			array[2]++;
		}
		if (a.modifies[3].active)
		{
			array[2]++;
		}
		if (a.allcountries[87].SubGosstroy == 5)
		{
			array[2]++;
		}
		if (a.allcountries[86].Gosstroy == 2)
		{
			array[2]++;
		}
		if (a.allcountries[11].proprc)
		{
			array[2]++;
		}
		if (a.allcountries[23].proprc)
		{
			array[2]++;
		}
		if (a.empires[0].relations < 500)
		{
			array[2]++;
		}
		if (a.allcountries[1].isSEV || a.allcountries[1].isASEAN)
		{
			array[2] -= 2;
		}
		if (a.allcountries[4].Gosstroy == 2)
		{
			array[3]++;
		}
		if (a.resultOfEvents[384] == 0 && a.event_done[384])
		{
			array[3] += 2;
		}
		if (a.allcountries[8].Gosstroy == 0 && a.allcountries[8].SubGosstroy == 9)
		{
			array[3]++;
		}
		if (!a.allcountries[1].okb && !a.allcountries[1].isOVD && !a.allcountries[1].isSEATO)
		{
			array[3]++;
		}
		if (a.ingamewars[5].is_going)
		{
			array[3]++;
		}
		if (a.allcountries[51].SubGosstroy == 12)
		{
			array[3]++;
		}
		if (a.allcountries[85].SubGosstroy == 6)
		{
			array[3]++;
		}
		if (a.allcountries[87].SubGosstroy == 6)
		{
			array[3]++;
		}
		if (a.allcountries[86].SubGosstroy == 6)
		{
			array[3]++;
		}
		if (a.allcountries[30].Gosstroy == 3)
		{
			array[3]++;
		}
		if (a.ingamewars[3].is_going)
		{
			array[3]++;
		}
		if (a.allcountries[1].Gosstroy == 2)
		{
			array[3]++;
		}
		for (int i = 0; i < a.allcountries.Length; i++)
		{
			if (a.allcountries[i].okb)
			{
				num2++;
			}
		}
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		bool flag = false;
		bool flag2 = false;
		if (GlobalScript.inst.gameState.empires[0].now_leader == 1)
		{
			num8++;
		}
		if (a.data[65] > 0)
		{
			flag2 = true;
		}
		if (GlobalScript.inst.gameState.BritLost)
		{
			flag = true;
		}
		if (a.resultOfEvents[46] != 2 && a.resultOfEvents[67] != 3 && !a.ingamewars[5].is_going)
		{
			num8++;
		}
		int num9 = 0;
		if (a.allcountries[21].Gosstroy == 2 || a.allcountries[21].Gosstroy == 1)
		{
			num9++;
		}
		if (a.allcountries[85].Gosstroy == 2 || a.allcountries[85].Gosstroy == 1)
		{
			num9++;
		}
		if (a.allcountries[86].Gosstroy == 2 || a.allcountries[86].Gosstroy == 1)
		{
			num9++;
		}
		if (a.allcountries[87].Gosstroy == 2 || a.allcountries[87].Gosstroy == 1)
		{
			num9++;
		}
		if (num9 > 1)
		{
			num8++;
		}
		if (a.allcountries[92].based)
		{
			num5 += num8;
			if (flag2)
			{
				num5++;
			}
			if (flag)
			{
				num5++;
			}
		}
		else
		{
			if (flag2)
			{
				num5++;
			}
			if (flag)
			{
				num5++;
			}
		}
		if (a.allcountries[92].based)
		{
			if (a.allcountries[92].based)
			{
				num6++;
			}
			if (flag2)
			{
				num6++;
			}
			if (flag)
			{
				num6++;
			}
		}
		int num10 = ((!flag2 && !flag) ? 10 : 0);
		if (flag2 || flag)
		{
			num7 += 2;
		}
		if (a.allcountries[92].based)
		{
			num7++;
		}
		float num11 = GlobalScript.inst.gameState.data[143];
		if (GlobalScript.inst.gameState.modifies[58].active && !GlobalScript.inst.gameState.modifies[16].active && GlobalScript.inst.gameState.data[153] <= 0)
		{
			num11 -= 15f;
		}
		if (GlobalScript.inst.gameState.allcountries[14].proprc)
		{
			num11 -= 1f;
		}
		if (GlobalScript.inst.gameState.allcountries[8].proprc)
		{
			num11 -= 1f;
		}
		if (GlobalScript.inst.gameState.allcountries[35].proprc)
		{
			num11 -= 1f;
		}
		if (GlobalScript.inst.gameState.allcountries[40].proprc)
		{
			num11 -= 1f;
		}
		if (GlobalScript.inst.gameState.allcountries[30].proprc)
		{
			num11 -= 1f;
		}
		if (GlobalScript.inst.gameState.allcountries[83].proprc)
		{
			num11 -= 1f;
		}
		if (GlobalScript.inst.gameState.allcountries[52].proprc)
		{
			num11 -= 1f;
		}
		if (num11 < 10f)
		{
			num11 = 10f;
		}
		float num12 = ((!(GlobalScript.inst.gameState.OilEat - GlobalScript.inst.gameState.OilProd > 0f)) ? ((float)GlobalScript.inst.gameState.data[143] * 7.7f * (GlobalScript.inst.gameState.OilEat - GlobalScript.inst.gameState.OilProd) / 10000f) : (num11 * 7.7f * (GlobalScript.inst.gameState.OilEat - GlobalScript.inst.gameState.OilProd) / 10000f));
		int num13 = 0;
		int num14 = 0;
		if (GlobalScript.inst.gameState.data[143] - 50 > 0)
		{
			num13 -= (GlobalScript.inst.gameState.data[143] - 10) / 3;
			num14 += (GlobalScript.inst.gameState.data[143] - 10) / 3;
		}
		else if (GlobalScript.inst.gameState.data[143] - 20 > 0 && GlobalScript.inst.gameState.data[143] - 50 <= 0)
		{
			num13 += (GlobalScript.inst.gameState.data[143] - 10) / 3;
			num14 += (GlobalScript.inst.gameState.data[143] - 10) / 3;
		}
		else if (GlobalScript.inst.gameState.data[21] < 1980)
		{
			num13 += (GlobalScript.inst.gameState.data[143] - 10) / 2;
			num14 -= (GlobalScript.inst.gameState.data[143] - 10) / 2;
		}
		else
		{
			num13 += GlobalScript.inst.gameState.data[143] - 10;
			num14 -= (GlobalScript.inst.gameState.data[143] - 10) * 2;
		}
		string text = string.Format(GlobalScript.inst.old_modify_desc[num], (float)(num2 * 2) / 10f, (num2 < 7) ? 1 : ((num2 < 14) ? 2 : 3), (float)num2 / 10f, (a.data[85] == 3) ? "已 建 成 巴 以 联 盟 国 家" : ((a.data[85] == 2) ? "巴 勒 斯 坦 建 立 阿 拉 伯 国" : ((a.data[85] == 1) ? "阿 拉 伯 人 自 治 区" : "巴 以 问 题 尚 未 解 决")), (a.data[54] > 39 && !a.modifies[17].active && a.allcountries[21].Torg) ? GlobalScript.inst.new_events_text[1310] : GlobalScript.inst.new_events_text[1311], (a.allcountries[21].Torg && !GlobalScript.inst.gameState.allcountries[1].isSEATO && !a.allcountries[1].okb && !a.allcountries[1].isOVD && (a.allcountries[1].Gosstroy == 2 || a.allcountries[1].Gosstroy == 3)) ? GlobalScript.inst.new_events_text[1310] : GlobalScript.inst.new_events_text[1311], (a.allcountries[21].Torg && a.data[52] < 36 && !a.modifies[16].active) ? GlobalScript.inst.new_events_text[1310] : GlobalScript.inst.new_events_text[1311], (a.allcountries[21].Torg && a.allcountries[1].okb && a.data[7] >= 500) ? GlobalScript.inst.new_events_text[1310] : GlobalScript.inst.new_events_text[1311], a.data[143], (float)a.data[146] / 10f, a.allcountries[1].isOVD ? a.allcountries[7].name : a.allcountries[51].name, GlobalScript.inst.gameState.empires[1].leaders[6].support, GlobalScript.inst.gameState.empires[1].leaders[4].support, GlobalScript.inst.gameState.empires[1].leaders[5].support, GlobalScript.inst.gameState.empires[1].leaders[1].support, (GlobalScript.inst.gameState.empires[1].now_leader == 0) ? GlobalScript.inst.new_events_text[1607] : null, (GlobalScript.inst.gameState.empires[1].now_leader == 0) ? GlobalScript.inst.gameState.empires[1].leaders[2].support.ToString() : null, (GlobalScript.inst.gameState.empires[1].now_leader == 0) ? GlobalScript.inst.new_events_text[1608] : null, (GlobalScript.inst.gameState.empires[1].now_leader == 0) ? GlobalScript.inst.gameState.empires[1].leaders[3].support.ToString() : null, num3, num4, array[1], array[3], array[0], array[2], num5, num10, num7, num6, a.OilProd, a.OilEat, num12 / 10f * -1f, (num12 / 10f * -1f > 0f) ? "lime" : "#DC143C", (num12 / 10f * -1f > 0f) ? "+" : null, num11, GlobalScript.inst.gameState.data[153], (GlobalScript.inst.gameState.data[153] > 0) ? GlobalScript.inst.new_events_text[1609] : GlobalScript.inst.new_events_text[1610], (float)num14 / 10f, (float)num13 / 10f, (num14 > 0) ? "+" : null, (num13 > 0) ? "+" : null);
		okno1.text = (okno1.text_en = $"<color=red>{GlobalScript.inst.old_modify_texts[num]}</color>|{(activated ? text : GlobalScript.inst.new_texts[229])}");
	}

	public void ChangeIcon(int num, bool activated)
	{
		this.num = num;
		if (this.num == 44 && GlobalScript.inst.gameState.YugAgree)
		{
			focus_sprite.sprite = Resources.Load<Sprite>(string.Format("modify_sp\\{0}_{1}", activated ? "15" : "55", 1));
		}
		else if (this.num == 46 && GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1 && activated)
		{
			focus_sprite.sprite = special[0];
		}
		else if (this.num == 28 && GlobalScript.inst.gameState.event_done[326] && GlobalScript.inst.gameState.resultOfEvents[326] == 0 && GlobalScript.inst.gameState.event_done[326] && GlobalScript.inst.gameState.resultOfEvents[326] == 0 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[50] <= 25 && GlobalScript.inst.gameState.data[15] == 6 && GlobalScript.inst.gameState.data[16] <= 11 && activated)
		{
			focus_sprite.sprite = special[1];
		}
		else if (this.num <= 58)
		{
			focus_sprite.sprite = Resources.Load<Sprite>(string.Format("modify_sp\\{0}_{1}", num, activated ? "0" : "1"));
		}
		else if (activated)
		{
			focus_sprite.sprite = znachki[num - 59];
		}
		else
		{
			focus_sprite.sprite = sub_znachki[num - 59];
		}
		if (focus_sprite.sprite == null)
		{
			focus_sprite.sprite = Resources.Load<Sprite>(string.Format("modify_sp\\{0}_{1}", 7, activated ? "0" : "1"));
		}
	}
}
