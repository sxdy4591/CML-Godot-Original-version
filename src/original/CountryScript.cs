using System;
using System.IO;
using UnityEngine;

public class CountryScript : MonoBehaviour
{
	private static Color[] colors;

	public GlobalScript global1;

	public int this_number;

	public Sprite grey;

	public Sprite special;

	private MapChangesScript map1;

	private SpriteRenderer sp;

	public bool on_mouse_it;

	static CountryScript()
	{
		colors = new Color[20];
		colors[0] = new Color(0.4f, 0.4f, 0.4f);
		colors[1] = new Color(0f, 0f, 0f);
		colors[2] = new Color(0f, 1f, 1f);
		colors[3] = new Color(0f, 0f, 0.46f);
		colors[4] = new Color(1f, 0.48f, 0f);
		colors[5] = new Color(0f, 0f, 0.72f);
		colors[6] = new Color(0f, 0f, 0.4f);
		colors[7] = new Color(1f, 0f, 1f);
		colors[8] = new Color32(byte.MaxValue, 140, 0, byte.MaxValue);
		colors[9] = new Color(0f, 0f, 0.5f);
		colors[10] = new Color(0f, 1f, 0.1f);
		colors[11] = new Color(1f, 0.1f, 0f);
		colors[12] = new Color(0.1717331f, 0.4433962f, 0f);
		colors[13] = new Color(89f / 106f, 89f / 106f, 89f / 106f);
		colors[14] = new Color(0.4f, 0f, 0f);
		colors[15] = new Color(0.17f, 0.69f, 1f);
		colors[16] = new Color(0.22f, 0.81f, 0f);
		colors[17] = new Color(0f, 0.22f, 0.6431f);
		colors[18] = new Color(0.16862f, 0.101f, 0f);
		colors[19] = new Color(1f, 0.1367925f, 0.1367925f);
	}

	private void OnMouseEnter()
	{
		Repaint();
		if (grey != null || (this_number != 69 && this_number != 70) || (this_number == 69 && GlobalScript.inst.gameState.data[67] != 0) || (this_number == 70 && GlobalScript.inst.gameState.data[66] != 0))
		{
			sp.material.SetColor("_MainColor", colors[0]);
		}
		on_mouse_it = true;
	}

	private void OnMouseExit()
	{
		if ((this_number != 69 && this_number != 70) || (this_number == 69 && GlobalScript.inst.gameState.data[67] != 0) || (this_number == 70 && GlobalScript.inst.gameState.data[66] != 0))
		{
			Repaint();
			on_mouse_it = false;
		}
	}

	private void ChangeSubIcons(Country Cou)
	{
		map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[Cou.SubGosstroy];
		if (Cou.SubGosstroy < 18)
		{
			map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text_en = GlobalScript.inst.other_text[(Cou.SubGosstroy < 10) ? (Cou.SubGosstroy + 13) : (Cou.SubGosstroy + 82)];
			map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text = GlobalScript.inst.other_text[(Cou.SubGosstroy < 10) ? (Cou.SubGosstroy + 13) : (Cou.SubGosstroy + 82)];
		}
		else
		{
			if (Cou.SubGosstroy == 18)
			{
				if (this_number == 162)
				{
					map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text_en = "托 洛 茨 基 外 星 红 军";
					map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text = "托 洛 茨 基 外 星 红 军";
				}
				else
				{
					map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text_en = GlobalScript.inst.other_text[182];
					map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text = GlobalScript.inst.other_text[182];
				}
			}
			if (Cou.SubGosstroy == 19)
			{
				map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text_en = " 封 建 社 会 主 义";
				map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().text = GlobalScript.inst.other_text[182];
			}
		}
		if (this_number > 70 && this_number < 84)
		{
			string text = ColorUtility.ToHtmlStringRGB(new Color(1f / (float)(4 - Cou.Gosstroy), 0f, 1f / (float)(4 - Cou.Gosstroy)));
			string text2 = ColorUtility.ToHtmlStringRGB(new Color((Cou.SubGosstroy < 4) ? (1f / (float)Cou.SubGosstroy) : 0f, (Cou.SubGosstroy > 6) ? (1f / (float)(Cou.SubGosstroy - 6)) : 0f, (Cou.SubGosstroy > 3 && Cou.SubGosstroy < 7) ? (1f / (float)(Cou.SubGosstroy - 3)) : 0f));
			map1.okno.transform.Find("Text_opis_country").GetComponent<TextMesh>().text = string.Format(GlobalScript.inst.other_text[23], '\n', GlobalScript.inst.other_text[Cou.Gosstroy], GlobalScript.inst.other_text[(Cou.SubGosstroy < 10) ? (Cou.SubGosstroy + 13) : (Cou.SubGosstroy + 82)], (Cou.next_elections != GlobalScript.inst.gameState.allcountries[0].next_elections) ? (Cou.next_elections.Day + "." + Cou.next_elections.Month + "." + Cou.next_elections.Year) : GlobalScript.inst.other_text[24], Cou.level_of_dev, Cou.level_of_unstab, text, text2);
		}
	}

	private void ChangeIcons()
	{
		OkoshkoScript[] array = new OkoshkoScript[6]
		{
			map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>(),
			map1.okno.transform.Find("Znach (1)").GetComponent<OkoshkoScript>(),
			map1.okno.transform.Find("Znach (2)").GetComponent<OkoshkoScript>(),
			map1.okno.transform.Find("Znach (3)").GetComponent<OkoshkoScript>(),
			map1.okno.transform.Find("Znach (4)").GetComponent<OkoshkoScript>(),
			map1.okno.transform.Find("Znach (5)").GetComponent<OkoshkoScript>()
		};
		if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1)
		{
			map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = map1.znachki[1];
			array[0].text_en = GlobalScript.inst.other_text[1];
			array[0].text = GlobalScript.inst.other_text[1];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 2)
		{
			map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[4];
			array[0].text_en = GlobalScript.inst.other_text[2];
			array[0].text = GlobalScript.inst.other_text[2];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 3)
		{
			map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[6];
			array[0].text_en = GlobalScript.inst.other_text[3];
			array[0].text = GlobalScript.inst.other_text[3];
		}
		else
		{
			map1.okno.transform.Find("Znach (0)").GetComponent<SpriteRenderer>().sprite = map1.znachki[8];
			array[0].text_en = GlobalScript.inst.other_text[0];
			array[0].text = GlobalScript.inst.other_text[0];
		}
		if (this_number == 162)
		{
			map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[9];
			array[1].text_en = "新 纳 粹 残 党";
			array[1].text = "新 纳 粹 残 党";
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isOVD)
		{
			map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[2];
			array[1].text_en = GlobalScript.inst.other_text[4];
			array[1].text = GlobalScript.inst.other_text[4];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].okb)
		{
			if (((this_number > 53 && this_number < 69) || (this_number > 105 && this_number < 109) || (this_number > 111 && this_number < 134) || this_number == 41 || this_number == 42 || this_number == 52 || this_number == 99 || this_number == 100 || this_number == 150 || this_number == 151 || this_number == 153 || this_number == 155 || this_number == 158) && this_number != 55 && this_number != 54 && this_number != 128 && GlobalScript.inst.gameState.allcountries[this_number].proprc && (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
			{
				map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[24];
				array[1].text_en = " 非 洲 联 盟";
				array[1].text = " 非 洲 联 盟";
			}
			else if (GlobalScript.inst.gameState.completedDecisions[10] && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.IsSocialism(yes: true, this_number))
			{
				map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[25];
				array[1].text_en = " 革 命 国 际";
				array[1].text = " 革 命 国 际";
			}
			else if (!GlobalScript.inst.gameState.modifies[49].active)
			{
				map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[6];
				array[1].text_en = GlobalScript.inst.other_text[5];
				array[1].text = GlobalScript.inst.other_text[5];
			}
			else
			{
				map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[22];
				array[1].text_en = GlobalScript.inst.other_text[355];
				array[1].text = GlobalScript.inst.other_text[355];
			}
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isNATO)
		{
			map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[13];
			array[1].text_en = GlobalScript.inst.other_text[55];
			array[1].text = GlobalScript.inst.other_text[55];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isSEATO)
		{
			if (!GlobalScript.inst.gameState.allcountries[51].cw)
			{
				array[1].text_en = GlobalScript.inst.other_text[201];
				array[1].text = GlobalScript.inst.other_text[201];
				map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[17];
			}
			else
			{
				array[1].text_en = GlobalScript.inst.other_text[217];
				array[1].text = GlobalScript.inst.other_text[217];
				map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[19];
			}
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isSENTO)
		{
			array[1].text_en = GlobalScript.inst.other_text[254];
			array[1].text = GlobalScript.inst.other_text[254];
			map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = map1.znachki[18];
		}
		else
		{
			map1.okno.transform.Find("Znach (1)").GetComponent<SpriteRenderer>().sprite = null;
			array[1].nonono = true;
		}
		if (this_number == 162)
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[3];
			array[2].text_en = "民 主 社 会 主 义 南 极 北 极 熊 联 军";
			array[2].text = "民 主 社 会 主 义 南 极 北 极 熊 联 军";
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isSEV)
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = map1.znachki[5];
			array[2].text_en = GlobalScript.inst.other_text[7];
			array[2].text = GlobalScript.inst.other_text[7];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].econ)
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = map1.znachki[7];
			array[2].text_en = GlobalScript.inst.other_text[8];
			array[2].text = GlobalScript.inst.other_text[8];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isOil)
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = map1.znachki[20];
			array[2].text_en = GlobalScript.inst.other_text[292];
			array[2].text = GlobalScript.inst.other_text[292];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isSocEU)
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = map1.znachki[21];
			array[2].text_en = GlobalScript.inst.other_text[323];
			array[2].text = GlobalScript.inst.other_text[323];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isEU)
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = map1.znachki[14];
			array[2].text_en = GlobalScript.inst.other_text[54];
			array[2].text = GlobalScript.inst.other_text[54];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].isASEAN)
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = map1.znachki[16];
			if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				array[2].text_en = GlobalScript.inst.other_text[195];
				array[2].text = GlobalScript.inst.other_text[195];
			}
			else
			{
				array[2].text_en = GlobalScript.inst.other_text[205];
				array[2].text = GlobalScript.inst.other_text[205];
			}
		}
		else
		{
			map1.okno.transform.Find("Znach (2)").GetComponent<SpriteRenderer>().sprite = null;
			array[2].nonono = true;
		}
		if (this_number == 162)
		{
			map1.okno.transform.Find("Znach (3)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[7];
			array[3].text_en = "马 化 腾 安 那 其 资 本 主 义 同 盟";
			array[3].text = "马 化 腾 安 那 其 资 本 主 义 同 盟";
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].Torg)
		{
			map1.okno.transform.Find("Znach (3)").GetComponent<SpriteRenderer>().sprite = map1.znachki[9];
			array[3].text_en = GlobalScript.inst.other_text[9];
			array[3].text = GlobalScript.inst.other_text[9];
		}
		else
		{
			map1.okno.transform.Find("Znach (3)").GetComponent<SpriteRenderer>().sprite = null;
			array[3].nonono = true;
		}
		if (this_number == 162)
		{
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[0];
			array[4].text_en = "企 鹅 公 社 解 放 阵 线";
			array[4].text = "企 鹅 公 社 解 放 阵 线";
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 21 || (this_number == 21 && !GlobalScript.inst.gameState.allcountries[21].proprc && !GlobalScript.inst.gameState.allcountries[21].prosov && !GlobalScript.inst.gameState.allcountries[21].Vyshi))
		{
			map1.znachki[15] = Resources.Load<Sprite>(string.Format("PuppetIcons{0}21", Path.DirectorySeparatorChar, GlobalScript.inst.gameState.allcountries[this_number].puppetOf));
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = map1.znachki[15];
			if (this_number == 159)
			{
				array[4].text_en = "英 - 法 共 同 托 管";
				array[4].text = "英 - 法 共 同 托 管";
			}
			else if (this_number == 154)
			{
				array[4].text_en = "法 国 的 一 部 分";
				array[4].text = "法 国 的 一 部 分";
			}
			else
			{
				array[4].text_en = "在 法 国 影 响 下";
				array[4].text = "在 法 国 影 响 下";
			}
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].Vyshi || ((this_number < 53 || this_number >= 69) && this_number != 61 && GlobalScript.inst.gameState.allcountries[this_number].usalliance))
		{
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = map1.znachki[0];
			array[4].text_en = GlobalScript.inst.other_text[10];
			array[4].text = GlobalScript.inst.other_text[10];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].prosov || ((this_number < 53 || this_number >= 69) && this_number != 61 && GlobalScript.inst.gameState.allcountries[this_number].sovalliance))
		{
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = map1.znachki[10];
			array[4].text_en = GlobalScript.inst.other_text[11];
			array[4].text = GlobalScript.inst.other_text[11];
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
		{
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = map1.znachki[11];
			array[4].text_en = GlobalScript.inst.other_text[12];
			array[4].text = GlobalScript.inst.other_text[12];
		}
		else
		{
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = null;
			array[4].nonono = true;
		}
		if (this_number == 162)
		{
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.sub_znachki[4];
			array[5].text_en = "南 极 磷 虾 社 民 党 反 抗 军";
			array[5].text = "南 极 磷 虾 社 民 党 反 抗 军";
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 30 && GlobalScript.inst.gameState.completedDecisions[20])
		{
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[12];
			array[5].text_en = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			array[5].text = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 7)
		{
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = map1.znachki[10];
			array[4].text_en = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			array[4].text = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = null;
			array[5].nonono = true;
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 51)
		{
			map1.okno.transform.Find("Znach (4)").GetComponent<SpriteRenderer>().sprite = map1.znachki[0];
			array[4].text_en = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			array[4].text = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = null;
			array[5].nonono = true;
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 135)
		{
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[26];
			array[5].text_en = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			array[5].text = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 1 && this_number == 38)
		{
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[28];
			array[5].text_en = " 北 京 实 控";
			array[5].text = " 北 京 实 控";
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 131)
		{
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[27];
			array[5].text_en = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			array[5].text = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf >= 0 && GlobalScript.inst.gameState.allcountries[this_number].puppetOf != 21)
		{
			map1.znachki[15] = Resources.Load<Sprite>($"PuppetIcons{Path.DirectorySeparatorChar}{GlobalScript.inst.gameState.allcountries[this_number].puppetOf}");
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[15];
			array[5].text_en = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
			array[5].text = string.Format(GlobalScript.inst.other_text[154], GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.allcountries[this_number].puppetOf].name);
		}
		else if (GlobalScript.inst.gameState.allcountries[20].spec == 1 && (this_number == 20 || this_number == 15 || this_number == 5 || (this_number == 45 && GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.allcountries[this_number].proprc) || (this_number == 6 && ((GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.allcountries[this_number].proprc) || GlobalScript.inst.gameState.resultOfEvents[492] == 1))))
		{
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[29];
			array[5].text_en = " 巴 尔 干 联 邦";
		}
		else if (this_number == 30 && GlobalScript.inst.gameState.OAR)
		{
			if (GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
			{
				map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[23];
				array[5].text_en = " 阿 拉 伯 革 命 社 会 主 义 共 和 国 联 盟";
				array[5].text = GlobalScript.inst.other_text[6];
			}
			else
			{
				map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[12];
				array[5].text_en = GlobalScript.inst.other_text[6];
				array[5].text = GlobalScript.inst.other_text[6];
			}
		}
		else if (GlobalScript.inst.gameState.allcountries[this_number].oar)
		{
			if (GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
			{
				map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[23];
				array[5].text_en = " 阿 拉 伯 革 命 社 会 主 义 共 和 国 联 盟";
				array[5].text = GlobalScript.inst.other_text[6];
			}
			else
			{
				map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = map1.znachki[12];
				array[5].text_en = GlobalScript.inst.other_text[6];
				array[5].text = GlobalScript.inst.other_text[6];
			}
		}
		else
		{
			map1.okno.transform.Find("Znach (5)").GetComponent<SpriteRenderer>().sprite = null;
			array[5].nonono = true;
		}
		if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy >= 0)
		{
			ChangeSubIcons(GlobalScript.inst.gameState.allcountries[this_number]);
		}
	}

	private void OnMouseDown()
	{
		if ((this_number == 69 || this_number == 70) && (this_number != 69 || GlobalScript.inst.gameState.data[67] == 0) && (this_number != 70 || GlobalScript.inst.gameState.data[66] == 0))
		{
			return;
		}
		map1.ShowHideOcno(active: true);
		try
		{
			map1.okno.transform.Find("Text (0)").GetComponent<TextMesh>().text = GlobalScript.inst.gameState.allcountries[this_number].name;
			map1.okno.transform.Find("Znach (0)").GetComponent<OkoshkoScript>().nonono = false;
			map1.okno.transform.Find("Znach (1)").GetComponent<OkoshkoScript>().nonono = false;
			map1.okno.transform.Find("Znach (2)").GetComponent<OkoshkoScript>().nonono = false;
			map1.okno.transform.Find("Znach (3)").GetComponent<OkoshkoScript>().nonono = false;
			map1.okno.transform.Find("Znach (4)").GetComponent<OkoshkoScript>().nonono = false;
			map1.okno.transform.Find("Znach (5)").GetComponent<OkoshkoScript>().nonono = false;
		}
		catch (Exception)
		{
			Debug.Log($"{this_number} {GlobalScript.inst.gameState.allcountries[this_number]} {GlobalScript.inst.gameState.allcountries}");
		}
		ChangeIcons();
		for (int i = 0; i < 4; i++)
		{
			map1.buttons[i].GetComponent<DiploButtonScript>().Hide();
			map1.buttons[i].GetComponent<DiploButtonScript>().selected_country = this_number;
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this_number == 7)
			{
				if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.ingamewars[22].is_going && GlobalScript.inst.gameState.data[133] != 1 && GlobalScript.inst.gameState.data[133] != 3 && !GlobalScript.inst.gameState.modifies[49].active && !GlobalScript.inst.gameState.is_gkchp && !GlobalScript.inst.gameState.IndOpp)
				{
					if (!GlobalScript.inst.gameState.relres)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("恢 复 关 系", 4);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("科 技 交 易", 81);
					}
					if ((GlobalScript.inst.gameState.allcountries[7].Torg || GlobalScript.inst.gameState.allcountries[1].isSEV) && GlobalScript.inst.gameState.allcountries[7].isSEV)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 互 会", 5);
					}
					else if (GlobalScript.inst.gameState.allcountries[7].isSEV)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("申 请 列 席", 74);
					}
					if (GlobalScript.inst.gameState.allcountries[7].isOVD)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("华 沙 条 约", 6);
					}
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("两 国 修 好", 7);
				}
			}
			else if (this_number == 2 || this_number == 4 || this_number == 98)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					if (GlobalScript.inst.gameState.allcountries[4].SubGosstroy == 19 && GlobalScript.inst.gameState.allcountries[4].proprc && !GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("促进“改革”", 70);
					}
					else if (GlobalScript.inst.gameState.allcountries[7].isNATO && GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.ingamewars[17].is_going)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[119], 103);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[120], 104);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[121], 105);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[131], 106);
					}
					else if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.ingamewars[17].is_going && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[this_number].isSEV)
					{
						if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
						{
							map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 极 左 派", 1);
						}
						else
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[226], 123);
						}
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					}
				}
			}
			else if (this_number == 5)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					if (GlobalScript.inst.gameState.allcountries[7].isNATO && GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.ingamewars[17].is_going)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[119], 103);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[120], 104);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[121], 105);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[131], 106);
					}
					else if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.ingamewars[17].is_going && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[this_number].isSEV)
					{
						if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
						{
							map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 极 左 派", 1);
						}
						else
						{
							map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[226], 123);
						}
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("联 络 反 对 派", 1012);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("煽 动 局 势", 1011);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("联 络 反 对 派", 1012);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("煽 动 局 势", 1011);
					}
				}
			}
			else if (this_number == 6)
			{
				if (GlobalScript.inst.gameState.allcountries[4].SubGosstroy == 19 && GlobalScript.inst.gameState.allcountries[4].proprc && !GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("促进“改革”", 70);
				}
				else if (GlobalScript.inst.gameState.allcountries[7].isNATO && GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.ingamewars[17].is_going)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[119], 103);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[120], 104);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[121], 105);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[131], 106);
				}
				else if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.ingamewars[17].is_going && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[this_number].isSEV)
				{
					if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 极 左 派", 1);
					}
					else
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[226], 123);
					}
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					if (GlobalScript.inst.gameState.allcountries[6].SubGosstroy == 17)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 1)
			{
				if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[183], 114);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[184], 115);
				}
				if (GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.allcountries[1].isASEAN)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[234], 124);
				}
				if (GlobalScript.inst.gameState.event_done[464] && GlobalScript.inst.gameState.resultOfEvents[464] == 2)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 东 方 申 根 协 定", 1008);
				}
				if (GlobalScript.inst.gameState.event_done[464] && GlobalScript.inst.gameState.resultOfEvents[464] != 2 && GlobalScript.inst.gameState.allcountries[21].okb && (GlobalScript.inst.gameState.allcountries[16].okb | GlobalScript.inst.gameState.allcountries[17].okb))
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 合 作", 1063);
				}
			}
			else if (this_number == 3)
			{
				if (GlobalScript.inst.gameState.allcountries[4].SubGosstroy == 19 && GlobalScript.inst.gameState.allcountries[4].proprc && !GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("促进“改革”", 70);
				}
				else if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[7].isNATO)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[106], 100);
				}
				if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("扶 持 极 左 派", 1);
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[226], 123);
				}
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
			}
			else if (this_number == 8)
			{
				if (GlobalScript.inst.gameState.allcountries[8].prcpower != 1000)
				{
					if (!GlobalScript.inst.gameState.event_done[58])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 友 方 派 系", 8);
					}
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
				else if (GlobalScript.inst.gameState.allcountries[8].prcpower == 1000 && GlobalScript.inst.gameState.allcountries[8].econ)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("整 饬 内 政", 80);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				else if (GlobalScript.inst.gameState.allcountries[8].prcpower == 1000)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 9)
			{
				if (!GlobalScript.inst.gameState.ingamewars[22].is_going && GlobalScript.inst.gameState.data[133] != 1 && GlobalScript.inst.gameState.data[133] != 3 && !GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.allcountries[9].isOVD)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("联 络 反 对 派", 11);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
				else if (GlobalScript.inst.gameState.allcountries[7].isNATO && GlobalScript.inst.gameState.allcountries[2].okb && GlobalScript.inst.gameState.allcountries[4].okb && GlobalScript.inst.gameState.allcountries[5].okb && GlobalScript.inst.gameState.allcountries[98].okb && GlobalScript.inst.gameState.allcountries[9].isEU)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("特 别 军 事 行 动", 1052);
				}
			}
			else if (this_number == 10)
			{
				if (GlobalScript.inst.gameState.resultOfEvents[495] != 1)
				{
					if (!GlobalScript.inst.gameState.allcountries[this_number].econ && !GlobalScript.inst.gameState.allcountries[this_number].isSEV)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 13);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					if (GlobalScript.inst.gameState.data[158] <= 0 && !GlobalScript.inst.gameState.allcountries[10].parts[0] && GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("实 施 制 裁", 14);
					}
					if (GlobalScript.inst.gameState.allcountries[this_number].isSEATO || GlobalScript.inst.gameState.allcountries[this_number].isOVD || GlobalScript.inst.gameState.allcountries[this_number].okb)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("挑 起 战 争", 15);
						if (!GlobalScript.inst.gameState.guns)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("提 供 军 援", 16);
						}
						else if (GlobalScript.inst.gameState.data[158] <= 0 && !GlobalScript.inst.gameState.allcountries[10].parts[0] && GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("实 施 制 裁", 14);
						}
					}
					if (!GlobalScript.inst.gameState.allcountries[this_number].isSEATO && !GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.allcountries[this_number].okb)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("挑 起 战 争", 15);
					}
					if (!GlobalScript.inst.gameState.allcountries[this_number].isSEATO && !GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.allcountries[this_number].okb)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("提 供 军 援", 16);
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
				}
			}
			else if (this_number == 11)
			{
				if (!GlobalScript.inst.gameState.event_done[454])
				{
					if (GlobalScript.inst.gameState.allcountries[11].prosov && GlobalScript.inst.gameState.allcountries[11].isSEV && !GlobalScript.inst.gameState.allcountries[1].isOVD)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 17);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 18);
					}
					else if (!GlobalScript.inst.gameState.event_done[535] || GlobalScript.inst.gameState.resultOfEvents[535] == 0)
					{
						if (GlobalScript.inst.gameState.allcountries[11].econ && GlobalScript.inst.gameState.allcountries[11].puppetOf < 0)
						{
							map1.buttons[0].GetComponent<DiploButtonScript>().Show("组 织 政 变", 1000);
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 18);
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
						else if (GlobalScript.inst.gameState.war <= 0)
						{
							map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 17);
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 18);
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
					}
					else if (GlobalScript.inst.gameState.event_done[535] && GlobalScript.inst.gameState.resultOfEvents[535] == 1)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("整 饬 内 政", 80);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 18);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 12)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 68);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
			}
			else if (this_number == 13)
			{
				if (GlobalScript.inst.gameState.allcountries[13].Gosstroy == 1)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[13].Gosstroy != 3 && GlobalScript.inst.gameState.allcountries[13].SubGosstroy != 7)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 卡 扎 菲", 22);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("联 络 反 对 派", 23);
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
					}
				}
			}
			else if (this_number == 14)
			{
				if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[36].cw && GlobalScript.inst.gameState.allcountries[14].Gosstroy != 1)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[293], 133);
				}
				if (GlobalScript.inst.gameState.event_done[36] && GlobalScript.inst.gameState.resultOfEvents[36] == 3 && !GlobalScript.inst.gameState.event_done[566])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("援 助 革 命 力 量", 56);
				}
				else if (GlobalScript.inst.gameState.OAR)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 25);
				}
				if (GlobalScript.inst.gameState.allcountries[14].proprc)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				else if (!GlobalScript.inst.gameState.allcountries[36].cw && GlobalScript.inst.gameState.resultOfEvents[36] != 3)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				if ((GlobalScript.inst.gameState.allcountries[14].proprc || GlobalScript.inst.gameState.allcountries[14].Vyshi) && GlobalScript.inst.gameState.allcountries[1].isASEAN)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
				}
			}
			else if (this_number == 15)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("签 署 友 好 协 定", 26);
				if (!GlobalScript.inst.gameState.allcountries[85].isSocEU)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("支 持 共 产 主 义", 27);
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("促 进 欧 洲 团 结", 27);
				}
				if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.allcountries[2].okb && !GlobalScript.inst.gameState.allcountries[4].okb && !GlobalScript.inst.gameState.allcountries[5].okb && !GlobalScript.inst.gameState.allcountries[98].okb)
				{
					if (!GlobalScript.inst.gameState.allcountries[15].cw)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("不 结 盟 运 动", 72);
					}
					else
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("退 出", 73);
					}
				}
				else
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 16)
			{
				if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[this_number].isNATO)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[310], 135);
				}
				else if (!GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
				}
				if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[7].isNATO)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 统 一", 116);
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc && GlobalScript.inst.gameState.allcountries[16].parts[0])
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 17)
			{
				if (!GlobalScript.inst.gameState.allcountries[17].parts[0])
				{
					if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 极 左 派", 1);
					}
					if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[7].isNATO)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 统 一", 116);
						if (GlobalScript.inst.gameState.allcountries[17].Gosstroy != 1 && GlobalScript.inst.gameState.allcountries[17].Gosstroy != 2)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 禁 运", 137);
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 煽 动", 138);
						}
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[17].Gosstroy == 1)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 安 全 局", 135);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				else if (GlobalScript.inst.gameState.allcountries[17].SubGosstroy == 9 && (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9))
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 18)
			{
				if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
					}
				}
			}
			else if (this_number == 19)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 纳 萨 尔 派", 28);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("重 建 外 交 关 系", 29);
				if (GlobalScript.inst.gameState.war != 2 && !GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("策 动 边 界 战 争", 30);
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].proprc && (GlobalScript.inst.gameState.allcountries[this_number].okb || GlobalScript.inst.gameState.allcountries[this_number].isOVD))
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("投 资 换 领 土", 89);
				}
				else
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("增 兵 助 战", 71);
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					if (!GlobalScript.inst.gameState.allcountries[this_number].isSEV && !GlobalScript.inst.gameState.allcountries[this_number].econ)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					}
					else
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 20)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].parts[1])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 31);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("复 交 苏 联", 32);
				}
			}
			else if (this_number == 21)
			{
				if (!GlobalScript.inst.gameState.event_done[483])
				{
					if (!GlobalScript.inst.dlc[3])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("签 署 友 好 协 定", 33);
					}
					else if (!GlobalScript.inst.gameState.allcountries[21].Torg)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("签 署 友 好 协 定", 33);
					}
					else if (GlobalScript.inst.gameState.data[131] == 3)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[262], 127);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("签 署 友 好 协 定", 33);
					}
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("吸 引 该 国 投 资", 34);
					if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
					{
						if (GlobalScript.inst.gameState.allcountries[21].soc_stab < 40)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("法 共 正 统 派", 1009);
						}
						else
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("党 内 政 变", 1010);
						}
					}
					if (GlobalScript.inst.dlc[3])
					{
						if (GlobalScript.inst.gameState.allcountries[21].Gosstroy != 1)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[140], 107);
						}
						if (GlobalScript.inst.gameState.allcountries[21].Gosstroy == 1)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						}
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					if (GlobalScript.inst.gameState.allcountries[21].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[21].SubGosstroy == 10 || ((GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7) && GlobalScript.inst.gameState.allcountries[21].SubGosstroy == 9))
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 22)
			{
				if (GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[22].puppetOf >= 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				else if (!GlobalScript.inst.gameState.event_done[454])
				{
					if (!GlobalScript.inst.gameState.allcountries[1].isSEATO)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("关 系", 35);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[244], 126);
					}
					if (GlobalScript.inst.gameState.allcountries[22].puppetOf < 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 36);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 23 && !GlobalScript.inst.gameState.allcountries[23].prosov)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
			}
			else if (this_number == 24 || this_number == 25)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 102);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 121);
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].parts[0] && GlobalScript.inst.gameState.OAR)
				{
					if (!GlobalScript.inst.gameState.allcountries[this_number].oar)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
					}
					else
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("重 建 阿 湾 人 阵", 1021);
					}
				}
			}
			else if (this_number == 26)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 50);
				if (!GlobalScript.inst.gameState.allcountries[26].prosov && !GlobalScript.inst.gameState.allcountries[7].isSEV && GlobalScript.inst.gameState.allcountries[26].Gosstroy != 3 && !GlobalScript.inst.gameState.allcountries[85].isSocEU)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[477], 148);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[478], 149);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[38], 53);
				}
				else if (GlobalScript.inst.gameState.allcountries[85].isSocEU)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 促 进 欧 洲 团 结", 148);
				}
			}
			else if (this_number > 26 && this_number <= 29)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 50);
			}
			else if (this_number == 30)
			{
				if (!GlobalScript.inst.gameState.completedDecisions[20])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 纳 赛 尔 派", 38);
				}
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 39);
				if (GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 31)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 40);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 41);
			}
			else if (this_number == 32 || this_number == 42)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 32)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
			}
			else if (this_number == 33)
			{
				if (GlobalScript.inst.gameState.resultOfEvents[55] != 2 && !GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 反 对 派", 42);
					if (GlobalScript.inst.gameState.resultOfEvents[662] != 1 && GlobalScript.inst.gameState.allcountries[33].inflCh > 0 && GlobalScript.inst.gameState.allcountries[33].SubGosstroy != 11)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("缅 甸 共 产 党", 1061);
					}
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 34)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("泰 国 共 产 党", 43);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 44);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
			}
			else if (this_number == 35)
			{
				if (!GlobalScript.inst.gameState.event_done[564])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("联 络 反 对 派", 1016);
				}
				else
				{
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 45);
					}
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.Israellost || GlobalScript.inst.gameState.allcountries[93].puppetOf == 37)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("组 织 谈 判", 1001);
					}
				}
			}
			else if (this_number == 37)
			{
				if (GlobalScript.inst.gameState.data[85] == 3 && GlobalScript.inst.gameState.OAR)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 45);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("协 商 巴 以 问 题", 46);
				}
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
			}
			else if (this_number == 38)
			{
				if (!GlobalScript.inst.gameState.allcountries[1].isASEAN && !GlobalScript.inst.gameState.event_done[461])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("解 放 金 马 澎", 48);
					if (GlobalScript.inst.gameState.event_done[460] && GlobalScript.inst.gameState.resultOfEvents[460] != 2 && !GlobalScript.inst.gameState.completedDecisions[6] && (GlobalScript.inst.gameState.resultOfEvents[116] == 0 || !GlobalScript.inst.gameState.event_done[116]) && GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 9 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 7 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 10 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 12 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 13)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("施 压", 1005);
					}
				}
				else if (GlobalScript.inst.gameState.event_done[461] && GlobalScript.inst.gameState.allcountries[38].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
				}
			}
			else if (this_number == 39)
			{
				if (GlobalScript.inst.gameState.allcountries[39].Gosstroy != 1)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("拨 款 海 外 账 户", 49);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("信 用 合 作 社", 49);
				}
			}
			else if (this_number == 40)
			{
				if (GlobalScript.inst.gameState.allcountries[40].SubGosstroy == 5)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("联 络 反 对 派", 1019);
					if (GlobalScript.inst.gameState.allcountries[40].cw)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("煽 动 反 对 派", 1020);
					}
				}
				if (GlobalScript.inst.gameState.allcountries[40].SubGosstroy == 10)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 45);
					}
				}
				if (GlobalScript.inst.gameState.allcountries[40].SubGosstroy != 7 && GlobalScript.inst.gameState.event_done[563])
				{
					if (GlobalScript.inst.gameState.allcountries[40].SubGosstroy != 1)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					}
					else
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.OAR)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 45);
						}
					}
				}
			}
			else if (this_number == 41)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (GlobalScript.inst.gameState.resultOfEvents[403] == 0 && GlobalScript.inst.gameState.event_done[403] && !GlobalScript.inst.gameState.ingamewars[24].is_going)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 101);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 112);
					if (GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1 && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
					}
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[157], 110);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[158], 111);
				}
				else if (GlobalScript.inst.gameState.allcountries[41].proprc)
				{
					if (GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
					else
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19 && !GlobalScript.inst.gameState.allcountries[42].parts[0] && GlobalScript.inst.gameState.event_done[376])
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 马 里 亚 姆 王 朝", 70);
						}
					}
				}
			}
			else if (this_number == 43 || this_number == 96 || this_number == 97)
			{
				if (GlobalScript.inst.dlc[3] && GlobalScript.inst.dlc[1])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[73], 97);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 98);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 99);
				}
			}
			else if (this_number == 44)
			{
				if (GlobalScript.inst.gameState.event_done[522] && GlobalScript.inst.gameState.resultOfEvents[522] == 2)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 亲 华 派", 1014);
				}
				if (GlobalScript.inst.gameState.event_done[523] && GlobalScript.inst.gameState.resultOfEvents[523] == 0 && !GlobalScript.inst.gameState.event_done[538])
				{
					if (GlobalScript.inst.gameState.event_done[532] && GlobalScript.inst.gameState.resultOfEvents[532] == 0)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 援 革 命", 51);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 赤 军", 51);
					}
				}
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 52);
				if (GlobalScript.inst.gameState.event_done[532] && GlobalScript.inst.gameState.resultOfEvents[532] == 0 && GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 6)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 动 革 命", 1015);
				}
				if (GlobalScript.inst.gameState.allcountries[44].proprc && !GlobalScript.inst.gameState.allcountries[44].isSocEU)
				{
					if (GlobalScript.inst.gameState.allcountries[1].isASEAN)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
					}
					else
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
					}
					if (GlobalScript.inst.gameState.allcountries[44].Gosstroy == 1)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 45)
			{
				if (!GlobalScript.inst.gameState.ingamewars[19].is_going || (GlobalScript.inst.gameState.allcountries[45].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[45].SubGosstroy != 0))
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (!GlobalScript.inst.gameState.allcountries[45].isSocEU && GlobalScript.inst.gameState.allcountries[45].Gosstroy != 1 && !GlobalScript.inst.gameState.allcountries[45].isEU && !GlobalScript.inst.gameState.allcountries[45].cw)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 54);
					}
					else if (GlobalScript.inst.gameState.allcountries[45].Gosstroy == 1)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[45].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
					}
				}
			}
			else if (this_number == 46)
			{
				if (!GlobalScript.inst.gameState.allcountries[46].parts[0])
				{
					if (!GlobalScript.inst.gameState.event_done[31])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("外 交 施 压", 55);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("和 平 统 一", 1013);
					}
				}
				if (!GlobalScript.inst.gameState.allcountries[46].isSEATO)
				{
					if (!GlobalScript.inst.gameState.event_done[31])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("外 交 施 压", 55);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("和 平 统 一", 1013);
					}
				}
				else if (!GlobalScript.inst.gameState.allcountries[10].isASEAN && GlobalScript.inst.gameState.allcountries[46].isASEAN)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[225], 122);
				}
			}
			else if (this_number == 47)
			{
				if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 毛 派", 56);
				}
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 44);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
			}
			else if (this_number == 48)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (GlobalScript.inst.gameState.allcountries[48].Gosstroy != 3)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 52)
			{
				if (GlobalScript.inst.gameState.event_done[497] || GlobalScript.inst.gameState.allcountries[52].SubGosstroy == 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					if (GlobalScript.inst.gameState.resultOfEvents[497] != 2)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[52].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 49)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
				if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 50)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 9)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("实 施 制 裁", 58);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
					}
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
				}
			}
			else if (this_number == 128)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
			}
			else if (this_number >= 2 && this_number <= 6 && this_number != 3 && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[this_number].isSEV)
			{
				if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.ingamewars[17].is_going)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 24);
					if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("扶 持 极 左 派", 1);
					}
					else
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[226], 123);
					}
				}
			}
			else if (this_number == 51)
			{
				if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.modifies[49].active)
				{
					if (!GlobalScript.inst.gameState.allcountries[51].Torg)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("签 署 友 好 协 定", 60);
					}
					else if (GlobalScript.inst.dlc[3])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[195], 117);
					}
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("吸 引 该 国 投 资", 34);
					if (GlobalScript.inst.gameState.allcountries[51].dev <= 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("中 央 情 报 局", 61);
					}
					else if (GlobalScript.inst.dlc[3])
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[201], 118);
					}
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("科 技 交 易", 75);
				}
			}
			else if (this_number == 53)
			{
				if (!GlobalScript.inst.gameState.event_done[499])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("反 抗", 1058);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("复 兴 主 义", 1059);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("世 界 第 三 理 论", 1060);
				}
				if (GlobalScript.inst.gameState.event_done[499] && GlobalScript.inst.gameState.allcountries[this_number].proprc && GlobalScript.inst.gameState.allcountries[this_number].Gosstroy != 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, 53))
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
					}
				}
			}
			else if (this_number == 150)
			{
				if (GlobalScript.inst.gameState.event_done[499] && GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 151)
			{
				if (GlobalScript.inst.gameState.event_done[499] && GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 54)
			{
				if (GlobalScript.inst.gameState.allcountries[54].Gosstroy == 0 && !GlobalScript.inst.gameState.event_done[560])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("摩 人 盟", 1006);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("西 撒 人 阵", 1007);
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[54].SubGosstroy != 11 && GlobalScript.inst.gameState.allcountries[54].Gosstroy != 3)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.OAR)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
						}
					}
				}
				if (GlobalScript.inst.gameState.event_done[560] && GlobalScript.inst.gameState.allcountries[54].Gosstroy == 0 && GlobalScript.inst.gameState.data[16] > 12)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 55)
			{
				if (GlobalScript.inst.gameState.allcountries[55].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[55].Gosstroy == 2)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.OAR)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
					}
				}
			}
			else if (this_number == 56)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("萨 瓦 巴", 1024);
					if (GlobalScript.inst.gameState.allcountries[this_number].cw)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("革 命", 1032);
					}
				}
			}
			else if (this_number == 57)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[80].is_going)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("维 和 与 革 命 行 动", 1056);
				}
			}
			else if (this_number == 58)
			{
				if (!GlobalScript.inst.gameState.event_done[458])
				{
					if (!GlobalScript.inst.gameState.allcountries[58].proprc)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("三 人 集 团", 1003);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[58].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
				if (GlobalScript.inst.gameState.resultOfEvents[458] == 0 && GlobalScript.inst.gameState.allcountries[61].SubGosstroy == 7 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("人 民 民 主 化", 1004);
				}
			}
			else if (this_number == 59)
			{
				if (GlobalScript.inst.gameState.allcountries[59].SubGosstroy == 15)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("敦 促 改 革", 1032);
				}
				else if (GlobalScript.inst.gameState.IsSocialism(yes: true, 59))
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[59].SubGosstroy == 7)
				{
					if (!GlobalScript.inst.gameState.allcountries[59].cw)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("毛 塔 民 主 联 盟", 1043);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("世 界 第 三 理 论", 1044);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("复 兴 党", 1045);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[59].SubGosstroy == 10)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[59].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 60)
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (GlobalScript.inst.gameState.resultOfEvents[653] == 3 && !GlobalScript.inst.gameState.allcountries[164].parts[0])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("援 助 革 命 派", 1054);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 动 革 命", 1055);
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].cw)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("援 助 扬 塔 特 斯 尼", 1054);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 动 圣 战", 1055);
				}
				if (GlobalScript.inst.gameState.allcountries[60].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 61)
			{
				if (GlobalScript.inst.gameState.allcountries[61].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 62)
			{
				if (GlobalScript.inst.gameState.allcountries[62].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 63 && GlobalScript.inst.gameState.allcountries[this_number].africaOff)
			{
				if (GlobalScript.inst.gameState.allcountries[63].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 64)
			{
				if (!GlobalScript.inst.gameState.allcountries[64].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("推 翻", 1032);
					if (GlobalScript.inst.gameState.allcountries[21].Torg && GlobalScript.inst.gameState.data[16] > 12)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 65)
			{
				if (GlobalScript.inst.gameState.allcountries[65].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[65].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
						}
					}
					if (GlobalScript.inst.gameState.allcountries[65].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("输 出 革 命 经 验", 70);
					}
				}
			}
			else if (this_number == 66)
			{
				if (GlobalScript.inst.gameState.resultOfEvents[618] != 1 && GlobalScript.inst.gameState.resultOfEvents[618] != 0 && !GlobalScript.inst.gameState.allcountries[66].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("支 持 喀 人 联", 1024);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("发 动 起 义", 1032);
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[618] == 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
				}
				else if (GlobalScript.inst.gameState.allcountries[66].puppetOf < 0 && GlobalScript.inst.gameState.resultOfEvents[618] != 1)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[66].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
						}
					}
				}
			}
			else if (this_number == 68)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].Vyshi)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
						}
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 69 || this_number == 70)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 帮 扶", 76);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("组 织 政 变", 77);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("建 立 军 事 基 地", 78);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("实 现 再 统 一", 79);
			}
			else if (((this_number >= 53 && this_number < 69) || (this_number > 105 && this_number < 109) || (this_number > 111 && this_number < 134)) && this_number != 55 && this_number != 54 && !GlobalScript.inst.gameState.allcountries[this_number].africaOff && (GlobalScript.inst.gameState.data[103] != 15 || this_number != 61))
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 亲 中 派", 62);
				if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("勾 结 苏 联", 63);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("勾 结 美 国", 64);
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc && !GlobalScript.inst.gameState.allcountries[this_number].prosov && !GlobalScript.inst.gameState.allcountries[this_number].Vyshi)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("资 源 开 发 区", 66);
				}
				else
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("组 织 政 变", 65);
				}
			}
			else if (this_number >= 71 && this_number <= 83)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[25], 82);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[28], 85);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[27], 84);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[36], 86);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[37], 87);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[38], 88);
				}
			}
			else if (((this_number > 141 && this_number < 149) || this_number == 139) && this_number != 145 && this_number != 147 && this_number != 142)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("煽 动", 1036);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 84)
			{
				if (GlobalScript.inst.dlc[3])
				{
					if (GlobalScript.inst.gameState.data[21] < 1981 && !GlobalScript.inst.gameState.event_done[367])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[56], 91);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[57], 92);
					}
					if (GlobalScript.inst.gameState.allcountries[84].Gosstroy == 2 || (GlobalScript.inst.gameState.allcountries[84].Gosstroy == 3 && GlobalScript.inst.gameState.data[21] > 1983) || GlobalScript.inst.gameState.allcountries[84].Gosstroy == 1)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						if (!GlobalScript.inst.gameState.allcountries[84].isSocEU && GlobalScript.inst.gameState.event_done[489])
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
							if (GlobalScript.inst.gameState.allcountries[84].proprc)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							}
						}
					}
					if (GlobalScript.inst.gameState.data[124] > 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[65], 94);
					}
				}
			}
			else if (this_number == 85)
			{
				if (GlobalScript.inst.dlc[3])
				{
					if (GlobalScript.inst.gameState.allcountries[85].prosov && GlobalScript.inst.gameState.allcountries[85].Gosstroy == 2)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("意 共 正 统 派", 1018);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						return;
					}
					if (GlobalScript.inst.gameState.event_done[391] && GlobalScript.inst.gameState.resultOfEvents[391] == 1 && !GlobalScript.inst.gameState.allcountries[85].prosov)
					{
						if (!GlobalScript.inst.gameState.event_done[556])
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("援 助 激 进 派", 1017);
						}
						if (GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 0)
						{
							map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
					}
					if (GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 10 || GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 17 || (GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 9 && (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7)))
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[148], 108);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[149], 109);
					}
					if ((GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 10 || GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 17 || (GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 9 && (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7))) && GlobalScript.inst.gameState.event_done[481])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[148], 108);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[149], 109);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					else if ((GlobalScript.inst.gameState.event_done[398] && GlobalScript.inst.gameState.resultOfEvents[398] < 3) || (GlobalScript.inst.gameState.event_done[401] && GlobalScript.inst.gameState.resultOfEvents[401] < 3))
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					else if (GlobalScript.inst.gameState.allcountries[85].inflCh == 6)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[148], 108);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[149], 109);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
				}
			}
			else if ((this_number > 87 && this_number < 92) || this_number == 0)
			{
				if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 86)
			{
				if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("联 系 分 离 分 子", 136);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[86].Gosstroy == 1)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[86].proprc)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
					}
				}
			}
			else if (this_number == 87)
			{
				if (GlobalScript.inst.gameState.data[65] == 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("特 别 军 事 行 动", 2);
					if (!GlobalScript.inst.gameState.allcountries[87].Vyshi || GlobalScript.inst.gameState.allcountries[87].Gosstroy != 0)
					{
						if (GlobalScript.inst.gameState.data[65] != 2 && !GlobalScript.inst.gameState.allcountries[1].isSEV)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("组 织 统 一 谈 判", 3);
						}
						if (GlobalScript.inst.dlc[3])
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[263], 128);
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						}
					}
				}
				else if (!GlobalScript.inst.gameState.allcountries[87].Vyshi || GlobalScript.inst.gameState.allcountries[87].Gosstroy != 0)
				{
					if (!GlobalScript.inst.gameState.event_done[420] && !GlobalScript.inst.gameState.event_done[419])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[263], 128);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						if (GlobalScript.inst.gameState.allcountries[87].Torg && (GlobalScript.inst.gameState.allcountries[87].Gosstroy == 1 || (GlobalScript.inst.gameState.allcountries[87].Gosstroy == 0 && !GlobalScript.inst.gameState.allcountries[87].Vyshi && (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9))))
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
							if (GlobalScript.inst.gameState.allcountries[87].proprc)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 92)
			{
				if (GlobalScript.inst.gameState.data[65] == 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("特 别 军 事 行 动", 2);
					if (GlobalScript.inst.gameState.allcountries[92].Gosstroy != 0)
					{
						if (GlobalScript.inst.gameState.data[65] != 2 && !GlobalScript.inst.gameState.allcountries[1].isSEV)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("组 织 统 一 谈 判", 3);
						}
						if (GlobalScript.inst.dlc[3])
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
							if (!GlobalScript.inst.gameState.event_done[404])
							{
								map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[176], 113);
							}
						}
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[92].Gosstroy != 0)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (!GlobalScript.inst.gameState.event_done[404])
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[176], 113);
					}
					if (GlobalScript.inst.gameState.allcountries[92].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[92].Torg && GlobalScript.inst.gameState.allcountries[92].SubGosstroy != 18)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					if (GlobalScript.inst.gameState.allcountries[92].SubGosstroy == 18)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("重 建 第 四 国 际", 10000);
					}
				}
			}
			else if (this_number == 93)
			{
				if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[37], 93);
					if ((GlobalScript.inst.gameState.Israellost && !GlobalScript.inst.gameState.event_done[440]) || GlobalScript.inst.gameState.resultOfEvents[440] == 2)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("谈 判 结 束 内 战", 1002);
					}
					if (GlobalScript.inst.gameState.allcountries[93].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
						}
					}
				}
			}
			else if (this_number == 94)
			{
				if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[65], 95);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
				}
			}
			else if (this_number == 95)
			{
				if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[37], 96);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if ((this_number == 36 || (this_number > 100 && this_number < 106 && this_number != 104)) && GlobalScript.inst.gameState.modifies[51].active)
			{
				if (this_number == 101 && GlobalScript.inst.gameState.allcountries[102].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[36].Gosstroy != 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 起 革 命", 1023);
				}
				if (GlobalScript.inst.gameState.event_done[567] && this_number > 101 && this_number < 106 && this_number != 104)
				{
					if (GlobalScript.inst.gameState.allcountries[24].prcpower < 100)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 阿 湾 人 阵", 1022);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 起 革 命", 1022);
					}
				}
				else if (!GlobalScript.inst.gameState.event_done[568])
				{
					if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[457], 142);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[458], 143);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[459], 144);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[465], 145);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[466], 146);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[458], 143);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[459], 144);
					}
				}
			}
			else if (this_number == 99)
			{
				if (GlobalScript.inst.gameState.allcountries[99].puppetOf < 0)
				{
					if ((!GlobalScript.inst.gameState.allcountries[99].based && !GlobalScript.inst.gameState.ingamewars[26].is_going) || GlobalScript.inst.gameState.allcountries[99].econ || GlobalScript.inst.gameState.allcountries[99].isSEV || (GlobalScript.inst.gameState.allcountries[99].SubGosstroy == 10 && !GlobalScript.inst.gameState.ingamewars[26].is_going) || (GlobalScript.inst.gameState.allcountries[99].SubGosstroy == 7 && !GlobalScript.inst.gameState.ingamewars[26].is_going))
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 101);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 112);
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[165], 110);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[166], 111);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[99].proprc)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
				}
			}
			else if (this_number == 100)
			{
				if (GlobalScript.inst.gameState.allcountries[99].puppetOf < 0)
				{
					if ((!GlobalScript.inst.gameState.allcountries[100].based && !GlobalScript.inst.gameState.ingamewars[25].is_going) || GlobalScript.inst.gameState.allcountries[99].econ || GlobalScript.inst.gameState.allcountries[99].isSEV || (GlobalScript.inst.gameState.allcountries[100].Gosstroy == 3 && !GlobalScript.inst.gameState.ingamewars[25].is_going) || (GlobalScript.inst.gameState.allcountries[100].Gosstroy == 1 && !GlobalScript.inst.gameState.ingamewars[25].is_going))
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 101);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 112);
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[161], 110);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[162], 111);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[100].proprc)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[this_number].proprc && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
				}
			}
			else if (this_number == 104 && GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[485], 9);
				if (!GlobalScript.inst.gameState.IsAuthoritarianism(104))
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[104].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("阿 拉 伯 联 合", 67);
						}
					}
				}
			}
			else if (this_number == 106)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[41].parts[0] && GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 17)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("非 洲 之 角", 1035);
					}
				}
			}
			else if (this_number == 107)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 10)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("革 命 左 翼", 1053);
				}
			}
			else if (this_number == 108)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("制 裁", 1032);
					if (GlobalScript.inst.gameState.allcountries[21].Torg && GlobalScript.inst.gameState.data[16] > 12)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 109 || this_number == 110)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
			}
			else if (this_number == 119 && GlobalScript.inst.gameState.allcountries[this_number].africaOff)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 9)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("协 助 左 派", 1032);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 112)
			{
				if (!GlobalScript.inst.gameState.event_done[616])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].level_of_unstab < 1000 && GlobalScript.inst.gameState.resultOfEvents[615] == 2)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("支持极左翼", 1024);
					}
					else
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("发动革命", 1032);
					}
				}
				else if (!GlobalScript.inst.gameState.IsAuthoritarianism(this_number))
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 113 && GlobalScript.inst.gameState.allcountries[this_number].africaOff)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 114)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 115)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy == 9)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
					else
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("特 别 解 放 行 动", 1032);
					}
					if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19 && GlobalScript.inst.gameState.event_done[621])
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 邀 请 学 习 经 验", 70);
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
					else
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("特 别 解 放 行 动", 1032);
					}
				}
			}
			else if (this_number == 116)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
					}
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("串 联 反 对 派", 1024);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 封 锁", 1032);
				}
			}
			else if (this_number == 117)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 9)
				{
					if (!GlobalScript.inst.gameState.allcountries[163].parts[0])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
						if ((GlobalScript.inst.gameState.allcountries[117].SubGosstroy == 9 || GlobalScript.inst.gameState.allcountries[117].SubGosstroy == 7) && GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 扎 伊 尔 化", 70);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 10)
					{
						if (GlobalScript.inst.gameState.resultOfEvents[613] == 0)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("施 压", 1041);
						}
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("掀 起 革 命", 1042);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 扎 伊 尔 化", 70);
					}
				}
			}
			else if (this_number == 118)
			{
				if (GlobalScript.inst.gameState.event_done[659] && !GlobalScript.inst.gameState.event_done[661])
				{
					if (GlobalScript.inst.gameState.resultOfEvents[659] == 1)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("民 族 解 放 军", 1057);
					}
					if (GlobalScript.inst.gameState.resultOfEvents[659] == 2)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("全 国 抵 抗 军", 1057);
					}
					if (GlobalScript.inst.gameState.resultOfEvents[659] == 3)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("阿 明 残 军", 1057);
					}
					if (GlobalScript.inst.gameState.resultOfEvents[659] == 4)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 布 干 达 武 装", 1057);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].proprc && !GlobalScript.inst.gameState.IsAuthoritarianism(118))
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 122)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[this_number].Gosstroy != 3 && GlobalScript.inst.gameState.event_done[598] && !GlobalScript.inst.gameState.ingamewars[53].is_going)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 123)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (!GlobalScript.inst.gameState.event_done[638])
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("支 持 毛 派", 1047);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("阿 尔 维 斯 集 团", 1048);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("下 注", 1049);
					}
					else if (!GlobalScript.inst.gameState.allcountries[this_number].cw && !GlobalScript.inst.gameState.ingamewars[68].is_going)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("出 售 军 火", 142);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("资 金 援 助", 143);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("打 压 对 手", 144);
					}
					else if (!GlobalScript.inst.gameState.ingamewars[68].is_going)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 124)
			{
				if (GlobalScript.inst.gameState.allcountries[124].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[124].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[124].Gosstroy != 3 && GlobalScript.inst.gameState.event_done[581])
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[124].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 125)
			{
				if (GlobalScript.inst.gameState.allcountries[125].puppetOf < 0)
				{
					if (GlobalScript.inst.gameState.IsAuthoritarianism(125))
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("施 压", 1032);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 126)
			{
				if (GlobalScript.inst.gameState.event_done[623])
				{
					if (GlobalScript.inst.gameState.allcountries[126].parts[0])
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 莫 解 阵", 1043);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("支 持 莫 抵 运", 1044);
						if (GlobalScript.inst.gameState.event_done[500])
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("非 联 革 治 安 军", 1045);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[126].SubGosstroy != 9)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 127)
			{
				if (GlobalScript.inst.gameState.allcountries[127].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[127].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[127].Gosstroy != 3)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[127].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
							if (GlobalScript.inst.gameState.allcountries[127].SubGosstroy == 15 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
							{
								map1.buttons[3].GetComponent<DiploButtonScript>().Show(" “ 快 车 道 ”", 70);
							}
						}
					}
				}
			}
			else if (this_number == 129)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].proprc && GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0 && GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 7)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("左 派", 1043);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("训 练", 1044);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("起 义", 1045);
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0 && GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy == 7)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("扶 持 亲 中 派", 62);
					if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("勾 结 苏 联", 63);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("勾 结 美 国", 64);
					}
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc && !GlobalScript.inst.gameState.allcountries[this_number].prosov && !GlobalScript.inst.gameState.allcountries[this_number].Vyshi)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("资 源 开 发 区", 66);
					}
					else
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("组 织 政 变", 65);
					}
				}
			}
			else if (this_number == 130)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].cw)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("推 翻 君 主 制", 1038);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
				}
			}
			else if (this_number == 131)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 9)
				{
					if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 7)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
					if (GlobalScript.inst.gameState.IsAuthoritarianism(this_number))
					{
						if (!GlobalScript.inst.gameState.allcountries[this_number].cw)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("支 持 抗 议 运 动", 57);
						}
						else
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show("促 使 激 进 化", 57);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy != 3)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
			}
			else if (this_number == 132)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (!GlobalScript.inst.gameState.allcountries[this_number].cw)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 援 助 阿 扎 尼 亚 派", 1037);
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 援 助 毛 派", 1037);
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
				}
			}
			else if (this_number == 153)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 2)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("支 持 左 翼", 1039);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("支 持 右 翼", 1040);
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
						}
					}
				}
			}
			else if (this_number == 133)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
				if (GlobalScript.inst.gameState.allcountries[133].proprc)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (GlobalScript.inst.gameState.allcountries[133].Gosstroy == 1 && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
					}
				}
			}
			else if (this_number == 134)
			{
				if (GlobalScript.inst.gameState.allcountries[135].proprc || GlobalScript.inst.gameState.allcountries[135].prosov)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 推 动 改 革", 1024);
					if (GlobalScript.inst.gameState.allcountries[134].puppetOf < 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[135].proprc)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
					}
				}
				if (GlobalScript.inst.gameState.allcountries[50].Gosstroy == 1 && !GlobalScript.inst.gameState.allcountries[135].Vyshi)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 巴 布 亚", 1025);
					if (GlobalScript.inst.gameState.allcountries[134].puppetOf < 0)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[134].proprc)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						}
					}
				}
			}
			else if (this_number == 135)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (!GlobalScript.inst.gameState.allcountries[135].Vyshi)
				{
					if (GlobalScript.inst.gameState.allcountries[135].proprc || (GlobalScript.inst.gameState.allcountries[135].Gosstroy != 3 && GlobalScript.inst.gameState.allcountries[135].Gosstroy != 0))
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					}
					if (GlobalScript.inst.gameState.allcountries[135].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 136)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (!GlobalScript.inst.gameState.allcountries[51].isNATO)
				{
					if (GlobalScript.inst.gameState.allcountries[136].proprc)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 支 持", 1024);
				}
			}
			else if (this_number == 137)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
			}
			else if (this_number == 138)
			{
				if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.is_gkchp)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].Torg)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("进 口 雪 茄", 49);
					}
					if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						if (!GlobalScript.inst.gameState.allcountries[this_number].prosov && !GlobalScript.inst.gameState.allcountries[this_number].Vyshi && GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 7)
						{
							map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 援 助 古 巴", 1033);
						}
						if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 协 助 入 侵", 1034);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					if (GlobalScript.inst.gameState.allcountries[this_number].cw && (GlobalScript.inst.gameState.allcountries[this_number].prosov || GlobalScript.inst.gameState.allcountries[this_number].Vyshi))
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Hide();
						map1.buttons[1].GetComponent<DiploButtonScript>().Hide();
						map1.buttons[2].GetComponent<DiploButtonScript>().Hide();
						map1.buttons[3].GetComponent<DiploButtonScript>().Hide();
					}
				}
			}
			else if (this_number == 140)
			{
				if (!GlobalScript.inst.gameState.allcountries[140].proprc)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 支 持 左 翼 反 对 派", 1026);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 支 持 右 翼 反 对 派", 1027);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 141)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				if (!GlobalScript.inst.gameState.allcountries[141].cw)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 运 河", 1062);
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 145)
			{
				if (!GlobalScript.inst.gameState.allcountries[145].cw)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 支 持 霍 查 派", 1028);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 支 持 毛 派", 1029);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 支 持 正 统 派", 1030);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(" 支 持 托 派", 1031);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
			}
			else if (this_number == 147)
			{
				if (!GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.allcountries[this_number].Gosstroy != 2)
				{
					if (GlobalScript.inst.gameState.allcountries[this_number].level_of_unstab < 1000 && GlobalScript.inst.gameState.allcountries[this_number].level_of_unstab > 0)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 桑 解 阵", 1043);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].level_of_unstab < 1000 && GlobalScript.inst.gameState.allcountries[this_number].level_of_unstab > 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 桑 解 阵", 1043);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 康 特 拉", 1044);
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[637] != 3)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 149)
			{
				if (!GlobalScript.inst.gameState.IsSocialism(yes: true, 149) && GlobalScript.inst.gameState.allcountries[149].Gosstroy != 2)
				{
					if (GlobalScript.inst.gameState.allcountries[149].level_of_unstab < 1000 && GlobalScript.inst.gameState.allcountries[149].level_of_unstab > 0)
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show(" 左 翼 游 击 队", 1043);
						map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 镇 压 左 翼", 1044);
					}
					else
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[149].level_of_unstab < 1000 && GlobalScript.inst.gameState.allcountries[149].level_of_unstab > 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("镇 压 右 翼", 1043);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (!GlobalScript.inst.gameState.allcountries[149].parts[0] && !GlobalScript.inst.gameState.ingamewars[66].is_going)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("特 别 军 事 行 动", 1045);
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					if (!GlobalScript.inst.gameState.allcountries[149].parts[0] && !GlobalScript.inst.gameState.ingamewars[66].is_going)
					{
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("特 别 军 事 行 动", 1045);
					}
				}
			}
			else if (this_number == 152)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy != 0)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("邀 请 乐 队", 49);
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc && !GlobalScript.inst.gameState.IsSocialism(yes: true, this_number))
					{
						map1.buttons[0].GetComponent<DiploButtonScript>().Show("学 习 古 巴", 1032);
					}
					else if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
				}
			}
			else if (this_number == 154)
			{
				if (!GlobalScript.inst.gameState.event_done[630])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("F L N K S", 1032);
					if (GlobalScript.inst.gameState.modifies[42].active || GlobalScript.inst.gameState.modifies[43].active || GlobalScript.inst.gameState.modifies[44].active)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("“ 风 暴 ”", 1046);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
					}
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("度 假", 49);
				}
			}
			else if (this_number == 155)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 157)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 53);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 158)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
							if (GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								map1.buttons[2].GetComponent<DiploButtonScript>().Show(" 非 洲 联 盟", 19);
							}
						}
					}
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
				}
			}
			else if (this_number == 159)
			{
				if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf < 0)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 展 贸 易", 9);
					if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
						map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show("F L N K S", 1045);
					}
				}
				else if (!GlobalScript.inst.gameState.event_done[629])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("瓦 努 阿 库 党", 1043);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("援 助", 1044);
				}
			}
			else if (this_number == 160)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("左 翼", 1050);
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				if (GlobalScript.inst.gameState.IsAuthoritarianism(1))
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("复 辟", 1051);
				}
			}
			else if (this_number == 161)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("马 西 纳 运 动", 1050);
				if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("军 事 同 盟", 19);
				}
				if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 3)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("支 持 政 府", 1051);
				}
			}
			if ((this_number == 27 || this_number == 39 || this_number == 88 || this_number == 0 || this_number == 29 || this_number == 89 || this_number == 90 || this_number == 91 || this_number == 28) && GlobalScript.inst.dlc[3])
			{
				if (!GlobalScript.inst.gameState.allcountries[85].isSocEU)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[477], 148);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[478], 149);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[38], 53);
				}
				else if (GlobalScript.inst.gameState.allcountries[85].isSocEU)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(" 促 进 欧 洲 团 结", 148);
				}
			}
			if (GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				if (this_number == 31 || this_number == 32)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
				}
				else if (this_number == 43 || this_number == 96 || this_number == 97 || this_number == 12 || this_number == 11 || this_number == 23 || this_number == 49 || this_number == 33 || (this_number == 22 && (GlobalScript.inst.gameState.allcountries[22].proprc || GlobalScript.inst.gameState.allcountries[22].Vyshi)) || this_number == 95)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
				}
				else if (this_number == 34 || this_number == 47 || this_number == 50 || (this_number == 35 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 35) || (this_number == 8 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 9) || this_number == 37 || this_number == 46 || (this_number == 93 && GlobalScript.inst.gameState.allcountries[93].puppetOf == 37))
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
				}
				else if (this_number == 19)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
				}
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
			{
				if (this_number == 31 || this_number == 32)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
				}
				else if (this_number == 43 || this_number == 96 || this_number == 97 || this_number == 12 || this_number == 11 || this_number == 23 || this_number == 49 || this_number == 33 || (this_number == 22 && (GlobalScript.inst.gameState.allcountries[22].proprc || GlobalScript.inst.gameState.allcountries[22].Vyshi)) || this_number == 95)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
				}
				else if (this_number == 34 || this_number == 44 || this_number == 47 || this_number == 46 || this_number == 50 || (this_number == 35 && !GlobalScript.inst.gameState.allcountries[35].oar) || (this_number == 8 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 9) || this_number == 37 || (this_number == 93 && GlobalScript.inst.gameState.allcountries[93].puppetOf == 37))
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
				}
				else if (this_number == 19 && GlobalScript.inst.gameState.allcountries[19].isASEAN)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
				}
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
			{
				for (int j = 2; j < GlobalScript.inst.gameState.allcountries.Length; j++)
				{
					if (!GlobalScript.inst.gameState.allcountries[j].isSEATO || j == 51)
					{
						continue;
					}
					if (!GlobalScript.inst.gameState.allcountries[j].proprc)
					{
						if (this_number == j)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[277], 131);
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 125);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[j].proprc && this_number == j)
					{
						if (!GlobalScript.inst.gameState.allcountries[j].dota)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[308], 134);
						}
						else
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[476], 134);
						}
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 132);
					}
				}
			}
			if (GlobalScript.inst.gameState.allcountries[1].isOVD && GlobalScript.inst.dlc[3])
			{
				for (int k = 8; k < GlobalScript.inst.gameState.allcountries.Length; k++)
				{
					if (!GlobalScript.inst.gameState.allcountries[k].isOVD || ((k != 11 || GlobalScript.inst.gameState.allcountries[11].parts[0]) && k != 12 && k != 31 && k != 32 && k != 96 && k != 97 && k != 98))
					{
						continue;
					}
					if (!GlobalScript.inst.gameState.allcountries[k].proprc)
					{
						if (this_number == k)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[277], 130);
						}
						if (this_number == k)
						{
							map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 125);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[k].proprc && this_number == k)
					{
						if (!GlobalScript.inst.gameState.allcountries[k].dota)
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[308], 134);
						}
						else
						{
							map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[476], 134);
						}
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 132);
					}
				}
			}
			else if (((this_number > 53 && this_number < 69) || (this_number > 105 && this_number < 109) || (this_number > 111 && this_number < 134) || this_number == 42) && this_number != 55 && this_number != 54 && this_number != 106 && GlobalScript.inst.gameState.allcountries[this_number].proprc && !GlobalScript.inst.gameState.allcountries[this_number].africaOff)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("经 济 合 作", 10);
				if ((GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("非 洲 联 盟", 19);
				}
				if (((this_number > 53 && this_number < 69) || (this_number > 105 && this_number < 109)) && (GlobalScript.inst.gameState.data[103] != 15 || this_number != 61))
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("资 源 开 发 区", 66);
				}
			}
			if (GlobalScript.inst.gameState.allcountries[this_number].econ && (this_number != 30 || !GlobalScript.inst.gameState.OAR) && !GlobalScript.inst.gameState.allcountries[this_number].oar && (this_number == 19 || this_number == 48 || this_number == 96 || this_number == 49 || this_number == 47 || this_number == 46 || this_number == 22 || this_number == 23 || this_number == 34 || this_number == 32 || this_number == 97 || this_number == 43 || this_number == 31 || this_number == 12 || (this_number > 53 && this_number < 69 && this_number != 54 && this_number != 55 && !GlobalScript.inst.gameState.allcountries[this_number].africaOff) || (this_number >= 106 && this_number < 109 && !GlobalScript.inst.gameState.allcountries[this_number].africaOff)))
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("整 饬 内 政", 80);
			}
			return;
		}
		if (this_number == 7)
		{
			if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.ingamewars[22].is_going && GlobalScript.inst.gameState.data[133] != 1 && GlobalScript.inst.gameState.data[133] != 3 && !GlobalScript.inst.gameState.modifies[49].active)
			{
				if (!GlobalScript.inst.gameState.relres)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("Отношения", 4);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("Технологии", 81);
				}
				if (GlobalScript.inst.gameState.allcountries[7].Torg || GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("СЭВ", 5);
				}
				else
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("Партнёр", 74);
				}
				if (GlobalScript.inst.gameState.allcountries[7].isOVD)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("ОВД", 6);
				}
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Поддержка", 7);
			}
		}
		else if (this_number == 2 || this_number == 4 || this_number == 6 || this_number == 5 || this_number == 98)
		{
			if (GlobalScript.inst.gameState.allcountries[7].isNATO && GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.ingamewars[17].is_going)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[119], 103);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[120], 104);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[121], 105);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[131], 106);
			}
			else if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.ingamewars[17].is_going && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[this_number].isSEV)
			{
				if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("Маоисты", 1);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[226], 123);
				}
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			}
		}
		else if (this_number == 1)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[183], 114);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[184], 115);
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[234], 124);
			}
		}
		else if (this_number == 3)
		{
			if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[106], 100);
			}
			if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Маоисты", 1);
			}
			else
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[226], 123);
			}
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Торговля", 24);
		}
		else if (this_number == 8)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Поддержка", 8);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 9)
		{
			if (!GlobalScript.inst.gameState.ingamewars[22].is_going && GlobalScript.inst.gameState.data[133] != 1 && GlobalScript.inst.gameState.data[133] != 3 && !GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.allcountries[9].isOVD)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Волнения", 11);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Переворот", 12);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			}
		}
		else if (this_number == 10)
		{
			if (!GlobalScript.inst.gameState.allcountries[this_number].econ && !GlobalScript.inst.gameState.allcountries[this_number].isSEV)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 13);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Альянс", 19);
			}
			if (GlobalScript.inst.gameState.data[158] <= 0)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Санкции", 14);
			}
			if (GlobalScript.inst.gameState.allcountries[this_number].isSEATO || GlobalScript.inst.gameState.allcountries[this_number].isOVD || GlobalScript.inst.gameState.allcountries[this_number].okb)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Война", 15);
				if (!GlobalScript.inst.gameState.guns)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("Оружие", 16);
				}
				else if (GlobalScript.inst.gameState.data[158] <= 0)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("Санкции", 14);
				}
			}
			if (!GlobalScript.inst.gameState.allcountries[this_number].isSEATO && !GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.allcountries[this_number].okb)
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Война", 15);
			}
			if (!GlobalScript.inst.gameState.allcountries[this_number].isSEATO && !GlobalScript.inst.gameState.allcountries[this_number].isOVD && !GlobalScript.inst.gameState.allcountries[this_number].okb)
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Оружие", 16);
			}
		}
		else if (this_number == 11)
		{
			if (GlobalScript.inst.gameState.war <= 0)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 17);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 18);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 19);
			}
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Армия", 20);
		}
		else if (this_number == 12)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 68);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 13)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Поддержать", 22);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 23);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("ОАР", 67);
		}
		else if (this_number == 14)
		{
			if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[36].cw)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[293], 133);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("ОАР", 25);
			}
			if (!GlobalScript.inst.gameState.allcountries[36].cw)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 53);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
			}
			if ((GlobalScript.inst.gameState.allcountries[14].proprc || GlobalScript.inst.gameState.allcountries[14].Vyshi) && GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
			}
		}
		else if (this_number == 15)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Договор", 26);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Поддержка", 27);
			if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.allcountries[2].okb && !GlobalScript.inst.gameState.allcountries[4].okb && !GlobalScript.inst.gameState.allcountries[5].okb && !GlobalScript.inst.gameState.allcountries[98].okb)
			{
				if (!GlobalScript.inst.gameState.allcountries[15].cw)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("Движение", 72);
				}
				else
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("Выход", 73);
				}
			}
			else
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 10);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
			}
		}
		else if (this_number == 16)
		{
			if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[this_number].isNATO)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[310], 135);
			}
			else if (!GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			}
			if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[324], 116);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[329], 137);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[334], 138);
			}
		}
		else if (this_number == 17)
		{
			if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Маоисты", 1);
			}
			if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[324], 116);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[329], 137);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[334], 138);
			}
		}
		else if (this_number == 18)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[424], 139);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[425], 140);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[426], 141);
			}
		}
		else if (this_number == 19)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Наксалиты", 28);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Отношения", 29);
			if (GlobalScript.inst.gameState.war != 2 && !GlobalScript.inst.gameState.allcountries[this_number].proprc)
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Война", 30);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].proprc && (GlobalScript.inst.gameState.allcountries[this_number].okb || GlobalScript.inst.gameState.allcountries[this_number].isOVD))
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Договор", 89);
			}
			else
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Подкрепления", 71);
			}
			if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
			{
				if (!GlobalScript.inst.gameState.allcountries[this_number].isSEV && !GlobalScript.inst.gameState.allcountries[this_number].econ)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 10);
				}
				else
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
				}
			}
		}
		else if (this_number == 20)
		{
			if (!GlobalScript.inst.gameState.allcountries[this_number].parts[1])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 31);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Альянс", 19);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("СССР", 32);
			}
		}
		else if (this_number == 21)
		{
			if (!GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Договор", 33);
			}
			else if (!GlobalScript.inst.gameState.allcountries[21].Torg)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Договор", 33);
			}
			else if (GlobalScript.inst.gameState.data[131] == 3)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[262], 127);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Договор", 33);
			}
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Инвестиции", 34);
			if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Маоисты", 1);
			}
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[140], 107);
			}
			if (GlobalScript.inst.gameState.allcountries[21].Gosstroy == 1)
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 10);
			}
		}
		else if (this_number == 22)
		{
			if (!GlobalScript.inst.gameState.allcountries[1].isSEATO)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Отношения", 35);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[244], 126);
			}
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 36);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 23 && !GlobalScript.inst.gameState.allcountries[23].prosov)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Мятеж", 37);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 24 || this_number == 25)
		{
			if (GlobalScript.inst.dlc[3] && !GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 102);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 121);
			}
		}
		else if (this_number >= 26 && this_number <= 29)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 50);
		}
		else if (this_number == 30)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Вмешаться", 38);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 39);
		}
		else if (this_number == 31)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 40);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Альянс", 41);
		}
		else if (this_number == 32 || this_number == 42)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 33)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Помощь", 42);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 34)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("КПТ", 43);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 44);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 35)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("ОАР", 45);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 53);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 37)
		{
			if (GlobalScript.inst.gameState.data[85] == 3 && GlobalScript.inst.gameState.allcountries[14].okb && GlobalScript.inst.gameState.allcountries[8].okb && GlobalScript.inst.gameState.allcountries[12].okb && GlobalScript.inst.gameState.allcountries[31].okb)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Склонить", 80);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Переговоры", 46);
			}
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 38)
		{
			if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Вторжение", 48);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
			}
		}
		else if (this_number == 39)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Банк", 49);
		}
		else if (this_number == 40)
		{
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("ОАР", 45);
		}
		else if (this_number == 41)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[403] == 0 && GlobalScript.inst.gameState.event_done[403] && !GlobalScript.inst.gameState.ingamewars[24].is_going)
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 101);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 112);
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[157], 110);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[158], 111);
			}
		}
		else if (this_number == 43 || this_number == 96 || this_number == 97)
		{
			if (GlobalScript.inst.dlc[3] && GlobalScript.inst.dlc[1])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[73], 97);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 98);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 99);
			}
		}
		else if (this_number == 44)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("КПЯ", 51);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 52);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 53);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Aльянс", 19);
		}
		else if (this_number == 45)
		{
			if (!GlobalScript.inst.gameState.ingamewars[19].is_going || (GlobalScript.inst.gameState.allcountries[45].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[45].SubGosstroy != 0))
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
				if (!GlobalScript.inst.gameState.allcountries[84].isSocEU)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 54);
				}
			}
		}
		else if (this_number == 46)
		{
			if (!GlobalScript.inst.gameState.allcountries[46].parts[0])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Давление", 55);
			}
			if (!GlobalScript.inst.gameState.allcountries[46].isSEATO)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			}
			else if (!GlobalScript.inst.gameState.allcountries[10].isASEAN && GlobalScript.inst.gameState.allcountries[46].isASEAN)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[225], 122);
			}
		}
		else if (this_number == 47)
		{
			if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Маоисты", 56);
			}
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 44);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
		}
		else if (this_number == 48)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			if (GlobalScript.inst.gameState.allcountries[48].Gosstroy != 3)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 10);
			}
		}
		else if (this_number == 52)
		{
			GlobalScript.inst.gameState.allcountries[this_number].name = GlobalScript.inst.other_text[475];
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			if (!GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				if (GlobalScript.inst.gameState.allcountries[52].spec <= 0)
				{
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("Санкции", 58);
				}
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Переворот", 147);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Союз", 44);
			}
		}
		else if (this_number == 49)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 24);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Aльянс", 19);
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[270], 129);
			}
		}
		else if (this_number == 50)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Санкции", 58);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 10);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Торговля", 24);
		}
		else if (this_number == 51)
		{
			if (!GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.modifies[49].active)
			{
				if (!GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("Дружба", 60);
				}
				else if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[195], 117);
				}
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Инвестиции", 34);
				if (GlobalScript.inst.gameState.allcountries[51].dev <= 0)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("ЦРУ", 61);
				}
				else if (GlobalScript.inst.dlc[3])
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[201], 118);
				}
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Технологии", 75);
			}
		}
		else if (this_number == 69 || this_number == 70)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Преференции", 76);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Смещение", 77);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("База", 78);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show("Возвращение", 79);
		}
		else if (((this_number >= 53 && this_number < 69) || (this_number > 105 && this_number < 109)) && !GlobalScript.inst.gameState.allcountries[this_number].africaOff && (GlobalScript.inst.gameState.data[103] != 15 || this_number != 61))
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Поддержать", 62);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("СССР", 63);
			map1.buttons[2].GetComponent<DiploButtonScript>().Show("США", 64);
			if (GlobalScript.inst.gameState.allcountries[this_number].Torg || GlobalScript.inst.gameState.allcountries[this_number].proprc)
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Ресурсы", 66);
			}
			else
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Переворот", 65);
			}
		}
		else if (this_number >= 71 && this_number <= 83)
		{
			if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[25], 82);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[28], 85);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[27], 84);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[36], 86);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[37], 87);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[38], 88);
			}
		}
		else if (this_number == 84)
		{
			if (GlobalScript.inst.dlc[3])
			{
				if (GlobalScript.inst.gameState.data[21] < 1981)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[56], 91);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[57], 92);
				}
				if (GlobalScript.inst.gameState.allcountries[84].Gosstroy == 2 || (GlobalScript.inst.gameState.allcountries[84].Gosstroy == 3 && GlobalScript.inst.gameState.data[21] > 1983))
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
					if (!GlobalScript.inst.gameState.allcountries[84].isSocEU)
					{
						map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 53);
					}
				}
				if (GlobalScript.inst.gameState.data[124] > 0)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[65], 94);
				}
			}
		}
		else if (this_number == 85)
		{
			if (GlobalScript.inst.dlc[3])
			{
				if (GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 10)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[148], 108);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[149], 109);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 53);
					map1.buttons[3].GetComponent<DiploButtonScript>().Show("Альянс", 19);
				}
				else if ((GlobalScript.inst.gameState.event_done[398] && GlobalScript.inst.gameState.resultOfEvents[398] < 3) || (GlobalScript.inst.gameState.event_done[401] && GlobalScript.inst.gameState.resultOfEvents[401] < 3))
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 10);
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 19);
				}
				else if (GlobalScript.inst.gameState.allcountries[85].inflCh == 6)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[148], 108);
					map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[149], 109);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
				}
			}
		}
		else if ((this_number > 87 && this_number < 92) || this_number == 0)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			}
		}
		else if (this_number == 86)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show("Сепаратисты", 136);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Tорговля", 9);
				if (GlobalScript.inst.gameState.allcountries[86].Gosstroy == 1)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 10);
				}
			}
		}
		else if (this_number == 87)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Операция", 2);
			if (GlobalScript.inst.gameState.data[65] != 2 && !GlobalScript.inst.gameState.allcountries[1].isSEV)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Переговоры", 3);
			}
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[263], 128);
				if (GlobalScript.inst.gameState.allcountries[87].Gosstroy == 1)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show("Союз", 10);
				}
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			}
		}
		else if (this_number == 92)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Операция", 2);
			if (GlobalScript.inst.gameState.data[65] != 2 && !GlobalScript.inst.gameState.allcountries[1].isSEV)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Переговоры", 3);
			}
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[176], 113);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			}
		}
		else if (this_number == 93)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[37], 93);
			}
		}
		else if (this_number == 94)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[65], 95);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 53);
			}
		}
		else if (this_number == 95)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[37], 96);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 53);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show("Альянс", 19);
			}
		}
		else if (this_number == 99)
		{
			if (((!GlobalScript.inst.gameState.allcountries[99].based && !GlobalScript.inst.gameState.ingamewars[26].is_going) || GlobalScript.inst.gameState.allcountries[99].econ || GlobalScript.inst.gameState.allcountries[99].isSEV || (GlobalScript.inst.gameState.allcountries[99].SubGosstroy == 10 && !GlobalScript.inst.gameState.ingamewars[26].is_going) || (GlobalScript.inst.gameState.allcountries[99].SubGosstroy == 7 && !GlobalScript.inst.gameState.ingamewars[26].is_going)) && !GlobalScript.inst.gameState.event_done[434])
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 101);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 112);
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[165], 110);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[166], 111);
			}
		}
		else if (this_number == 100)
		{
			if ((!GlobalScript.inst.gameState.allcountries[100].based && !GlobalScript.inst.gameState.ingamewars[25].is_going) || GlobalScript.inst.gameState.allcountries[99].econ || GlobalScript.inst.gameState.allcountries[99].isSEV || (GlobalScript.inst.gameState.allcountries[100].Gosstroy == 3 && !GlobalScript.inst.gameState.ingamewars[25].is_going) || (GlobalScript.inst.gameState.allcountries[100].Gosstroy == 1 && !GlobalScript.inst.gameState.ingamewars[25].is_going))
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 101);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 112);
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[161], 110);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[162], 111);
			}
		}
		else if (this_number == 104)
		{
			if (GlobalScript.inst.dlc[3])
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[485], 9);
			}
		}
		else if (this_number == 109 || this_number == 110)
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Торговля", 9);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show("Союз", 10);
		}
		else if ((this_number == 36 || (this_number > 100 && this_number < 106 && this_number != 104)) && GlobalScript.inst.gameState.modifies[51].active && !GlobalScript.inst.gameState.allcountries[105].Vyshi)
		{
			if (GlobalScript.inst.gameState.event_done[567] && this_number > 101 && this_number < 106 && this_number != 104)
			{
				if (GlobalScript.inst.gameState.allcountries[24].prcpower < 100)
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("支 持 阿 湾 人 阵", 1022);
				}
				else
				{
					map1.buttons[0].GetComponent<DiploButtonScript>().Show("发 起 革 命", 1022);
				}
			}
			else if (!GlobalScript.inst.gameState.allcountries[this_number].proprc)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[457], 142);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[458], 143);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[459], 144);
			}
			else
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[465], 145);
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[466], 146);
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[458], 143);
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[459], 144);
			}
		}
		if ((this_number == 27 || this_number == 39 || this_number == 88 || this_number == 29 || this_number == 0 || this_number == 89 || this_number == 90 || this_number == 91 || this_number == 28) && GlobalScript.inst.dlc[3])
		{
			map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[477], 148);
			map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[478], 149);
			map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[38], 53);
		}
		if (GlobalScript.inst.gameState.allcountries[this_number].econ && (this_number != 30 || !GlobalScript.inst.gameState.OAR) && !GlobalScript.inst.gameState.allcountries[this_number].oar && (this_number == 19 || this_number == 52 || this_number == 48 || this_number == 50 || this_number == 96 || this_number == 49 || this_number == 47 || this_number == 46 || this_number == 11 || this_number == 22 || this_number == 23 || this_number == 34 || this_number == 33 || this_number == 32 || this_number == 97 || this_number == 43 || this_number == 31 || this_number == 12 || this_number == 8 || this_number == 14 || this_number == 35 || (this_number >= 53 && this_number < 69) || (this_number >= 106 && this_number < 109)))
		{
			map1.buttons[0].GetComponent<DiploButtonScript>().Show("Склонить", 80);
		}
		if (GlobalScript.inst.gameState.allcountries[1].isASEAN)
		{
			if (this_number == 31 || this_number == 32)
			{
				map1.buttons[0].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
			}
			else if (this_number == 43 || this_number == 96 || this_number == 97 || this_number == 12 || this_number == 11 || this_number == 23 || this_number == 49 || this_number == 52 || this_number == 33 || (this_number == 22 && (GlobalScript.inst.gameState.allcountries[22].proprc || GlobalScript.inst.gameState.allcountries[22].Vyshi)) || this_number == 95)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
			}
			else if (this_number == 34 || this_number == 44 || this_number == 47 || this_number == 50 || (this_number == 35 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 35) || (this_number == 8 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 9) || this_number == 37 || this_number == 46 || (this_number == 93 && GlobalScript.inst.gameState.allcountries[93].puppetOf == 37))
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
			}
			else if (this_number == 19)
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[79], 119);
			}
		}
		if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
		{
			if (this_number == 31 || this_number == 32)
			{
				map1.buttons[1].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
			}
			else if (this_number == 43 || this_number == 96 || this_number == 97 || this_number == 12 || this_number == 11 || this_number == 23 || this_number == 49 || this_number == 33 || (this_number == 22 && (GlobalScript.inst.gameState.allcountries[22].proprc || GlobalScript.inst.gameState.allcountries[22].Vyshi)) || this_number == 95)
			{
				map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
			}
			else if (this_number == 34 || this_number == 44 || this_number == 47 || this_number == 46 || this_number == 50 || (this_number == 35 && !GlobalScript.inst.gameState.allcountries[35].oar) || (this_number == 8 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 9) || this_number == 37 || (this_number == 93 && GlobalScript.inst.gameState.allcountries[93].puppetOf == 37))
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
			}
			else if (this_number == 19 && GlobalScript.inst.gameState.allcountries[19].isASEAN)
			{
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[80], 120);
			}
		}
		if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
		{
			for (int l = 2; l < GlobalScript.inst.gameState.allcountries.Length; l++)
			{
				if (!GlobalScript.inst.gameState.allcountries[l].isSEATO || l == 51)
				{
					continue;
				}
				if (!GlobalScript.inst.gameState.allcountries[l].proprc)
				{
					if (this_number == l)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[277], 131);
						map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 125);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[l].proprc && this_number == l)
				{
					if (!GlobalScript.inst.gameState.allcountries[l].dota)
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[308], 134);
					}
					else
					{
						map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[476], 134);
					}
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 132);
				}
			}
		}
		if (!GlobalScript.inst.gameState.allcountries[1].isOVD || !GlobalScript.inst.dlc[3])
		{
			return;
		}
		for (int m = 8; m < GlobalScript.inst.gameState.allcountries.Length; m++)
		{
			if (!GlobalScript.inst.gameState.allcountries[m].isOVD || (m != 8 && m != 11 && m != 14 && m != 12 && m != 31 && m != 43 && m != 42 && m != 22 && m != 37 && m != 34 && m != 47 && m != 23 && m != 32 && m != 33 && m != 35 && m != 96 && m != 97 && m != 98 && m != 95 && m != 49 && m != 50))
			{
				continue;
			}
			if (!GlobalScript.inst.gameState.allcountries[m].proprc)
			{
				if (this_number == m)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[277], 130);
				}
				if (this_number == m)
				{
					map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 125);
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[m].proprc && this_number == m)
			{
				if (!GlobalScript.inst.gameState.allcountries[m].dota)
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[308], 134);
				}
				else
				{
					map1.buttons[2].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[476], 134);
				}
				map1.buttons[3].GetComponent<DiploButtonScript>().Show(GlobalScript.inst.other_text[238], 132);
			}
		}
	}

	public void Repaint_forTimes()
	{
		if (!on_mouse_it)
		{
			Repaint();
		}
	}

	public void Repaint()
	{
		map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		global1 = GlobalScript.inst;
		sp = GetComponent<SpriteRenderer>();
		if (grey == null || (this_number == 69 && GlobalScript.inst.gameState.data[67] == 0) || (this_number == 70 && GlobalScript.inst.gameState.data[66] == 0))
		{
			return;
		}
		if (GlobalScript.inst.gameState.completedDecisions[19])
		{
			if (!GlobalScript.inst.gameState.event_done[551] || GlobalScript.inst.gameState.resultOfEvents[551] != 0)
			{
				GlobalScript.inst.gameState.allcountries[9].prosov = false;
				GlobalScript.inst.gameState.allcountries[9].proprc = true;
				GlobalScript.inst.gameState.allcountries[9].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[9].isNATO = false;
				GlobalScript.inst.gameState.allcountries[9].isOVD = false;
				GlobalScript.inst.gameState.allcountries[9].okb = false;
				GlobalScript.inst.gameState.allcountries[9].isSEV = false;
				GlobalScript.inst.gameState.allcountries[9].econ = false;
				GlobalScript.inst.gameState.allcountries[9].isEU = false;
				GlobalScript.inst.gameState.data[130] = 1;
				GlobalScript.inst.gameState.allcountries[1].ILoveSuckCocks();
			}
			else
			{
				GlobalScript.inst.gameState.data[130] = 0;
			}
		}
		if (GlobalScript.inst.gameState.completedDecisions[6] || GlobalScript.inst.gameState.completedDecisions[7])
		{
			GlobalScript.inst.gameState.allcountries[1].ILoveSuckCocks();
		}
		else if (this_number == 69 && GlobalScript.inst.gameState.data[62] >= 2)
		{
			sp.sprite = special;
		}
		else if (sp.sprite != special)
		{
			sp.sprite = grey;
		}
		if (this_number == 10 && GlobalScript.inst.gameState.data[83] == 2)
		{
			this_number = 46;
			GlobalScript.inst.gameState.allcountries[10].prosov = GlobalScript.inst.gameState.allcountries[46].prosov;
			GlobalScript.inst.gameState.allcountries[10].proprc = GlobalScript.inst.gameState.allcountries[46].proprc;
		}
		else if (this_number == 46 && GlobalScript.inst.gameState.data[83] == 1)
		{
			this_number = 10;
			GlobalScript.inst.gameState.allcountries[46].prosov = GlobalScript.inst.gameState.allcountries[10].prosov;
			GlobalScript.inst.gameState.allcountries[46].proprc = GlobalScript.inst.gameState.allcountries[10].proprc;
		}
		else if (this_number == 38 && GlobalScript.inst.gameState.completedDecisions[7])
		{
			this_number = 1;
		}
		else if ((this_number == 54 || this_number == 55 || this_number == 18 || this_number == 14 || this_number == 35 || this_number == 30 || this_number == 13 || this_number == 40) && GlobalScript.inst.gameState.completedDecisions[20] && GlobalScript.inst.gameState.allcountries[30].parts[0] && GlobalScript.inst.gameState.allcountries[30].parts[1] && GlobalScript.inst.gameState.allcountries[30].parts[2])
		{
			this_number = 30;
		}
		if (this_number == 111)
		{
			if (GlobalScript.inst.gameState.allcountries[49].parts[0])
			{
				this_number = 49;
			}
			else if (!GlobalScript.inst.gameState.event_done[118])
			{
				this_number = 92;
			}
			else
			{
				this_number = 111;
			}
		}
		if (this_number == 142)
		{
			if ((GlobalScript.inst.gameState.data[21] >= 1981 && GlobalScript.inst.gameState.data[20] >= 9 && GlobalScript.inst.gameState.data[19] >= 21) || (GlobalScript.inst.gameState.data[21] >= 1981 && GlobalScript.inst.gameState.data[20] >= 10) || GlobalScript.inst.gameState.data[21] >= 1982)
			{
				this_number = 142;
			}
			else
			{
				this_number = 92;
			}
		}
		if (this_number == 161)
		{
			if ((GlobalScript.inst.gameState.data[21] >= 1978 && GlobalScript.inst.gameState.data[20] >= 7 && GlobalScript.inst.gameState.data[19] >= 7) || (GlobalScript.inst.gameState.data[21] >= 1978 && GlobalScript.inst.gameState.data[20] >= 8) || GlobalScript.inst.gameState.data[21] >= 1979)
			{
				this_number = 161;
			}
			else
			{
				this_number = 92;
			}
		}
		if (this_number == 106)
		{
			if (!GlobalScript.inst.gameState.event_done[585])
			{
				this_number = 21;
			}
			else
			{
				this_number = 106;
			}
		}
		if (this_number == -2)
		{
			if (!GlobalScript.inst.gameState.BritLost)
			{
				this_number = 92;
			}
			else
			{
				this_number = 71;
			}
		}
		if (this_number == 18)
		{
			if (GlobalScript.inst.gameState.allcountries[54].parts[0])
			{
				this_number = 54;
			}
			else
			{
				this_number = 18;
			}
		}
		if (this_number == 22)
		{
			if (GlobalScript.inst.gameState.allcountries[11].parts[0])
			{
				this_number = 11;
			}
			else
			{
				this_number = 22;
			}
		}
		if (this_number == 42)
		{
			if (GlobalScript.inst.gameState.allcountries[41].parts[0] || GlobalScript.inst.gameState.allcountries[41].parts[1])
			{
				this_number = 41;
			}
			else
			{
				this_number = 42;
			}
		}
		if (this_number == 106)
		{
			if (GlobalScript.inst.gameState.allcountries[41].parts[1])
			{
				this_number = 41;
			}
			else
			{
				this_number = 106;
			}
		}
		if (this_number == 23)
		{
			if (GlobalScript.inst.gameState.allcountries[11].parts[0])
			{
				this_number = 11;
			}
			else
			{
				this_number = 23;
			}
		}
		sp.material.SetColor("_MainColor", colors[1]);
		sp.material.SetColor("_MainColor2", colors[1]);
		if (global1.map_type == 0)
		{
			if (GlobalScript.inst.gameState.allcountries[this_number].isNATO)
			{
				sp.material.SetColor("_MainColor", colors[3]);
				sp.material.SetColor("_MainColor2", colors[4]);
			}
			if (GlobalScript.inst.gameState.allcountries[this_number].isSEATO)
			{
				sp.material.SetColor("_MainColor", colors[3]);
				sp.material.SetColor("_MainColor2", colors[14]);
			}
			if (GlobalScript.inst.gameState.allcountries[this_number].isSENTO)
			{
				sp.material.SetColor("_MainColor", colors[3]);
				sp.material.SetColor("_MainColor2", colors[14]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isOVD)
			{
				sp.material.SetColor("_MainColor2", colors[2]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].oar)
			{
				sp.material.SetColor("_MainColor", colors[12]);
				sp.material.SetColor("_MainColor2", colors[13]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].okb)
			{
				if (((this_number > 53 && this_number < 69) || (this_number > 105 && this_number < 109) || (this_number > 111 && this_number < 134) || this_number == 41 || this_number == 42 || this_number == 52 || this_number == 99 || this_number == 100 || this_number == 150 || this_number == 151 || this_number == 153) && this_number != 55 && this_number != 54 && this_number != 128 && GlobalScript.inst.gameState.allcountries[this_number].proprc && (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
				{
					sp.material.SetColor("_MainColor2", colors[9]);
					return;
				}
				sp.material.SetColor("_MainColor", colors[8]);
				sp.material.SetColor("_MainColor2", colors[9]);
			}
			return;
		}
		if (global1.map_type == 2)
		{
			if (GlobalScript.inst.gameState.allcountries[20].spec == 1 && (this_number == 20 || this_number == 15 || this_number == 5 || (this_number == 45 && GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.allcountries[this_number].proprc) || (this_number == 6 && ((GlobalScript.inst.gameState.IsSocialism(yes: true, this_number) && GlobalScript.inst.gameState.allcountries[this_number].proprc) || GlobalScript.inst.gameState.resultOfEvents[492] == 1))))
			{
				sp.material.SetColor("_MainColor", new Color(0.5f, 0.25f, 0.5f));
				sp.material.SetColor("_MainColor2", colors[9]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isEU && GlobalScript.inst.gameState.allcountries[this_number].Torg)
			{
				sp.material.SetColor("_MainColor2", colors[11]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isASEAN && GlobalScript.inst.gameState.allcountries[this_number].Torg)
			{
				sp.material.SetColor("_MainColor", colors[17]);
				sp.material.SetColor("_MainColor2", colors[18]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isEU)
			{
				sp.material.SetColor("_MainColor", colors[3]);
				sp.material.SetColor("_MainColor2", colors[4]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isSocEU && GlobalScript.inst.gameState.allcountries[this_number].Torg)
			{
				sp.material.SetColor("_MainColor", colors[19]);
				sp.material.SetColor("_MainColor2", colors[9]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isSocEU)
			{
				sp.material.SetColor("_MainColor", colors[19]);
				sp.material.SetColor("_MainColor2", colors[1]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isOil)
			{
				sp.material.SetColor("_MainColor", colors[15]);
				sp.material.SetColor("_MainColor2", colors[16]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isASEAN)
			{
				sp.material.SetColor("_MainColor", colors[3]);
				sp.material.SetColor("_MainColor2", colors[14]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isSEV && GlobalScript.inst.gameState.allcountries[this_number].Torg)
			{
				sp.material.SetColor("_MainColor2", colors[10]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].isSEV)
			{
				sp.material.SetColor("_MainColor2", colors[2]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].econ)
			{
				sp.material.SetColor("_MainColor", colors[8]);
				sp.material.SetColor("_MainColor2", colors[9]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].Torg)
			{
				sp.material.SetColor("_MainColor", colors[5]);
				sp.material.SetColor("_MainColor2", colors[7]);
			}
			return;
		}
		if (global1.map_type == 3)
		{
			if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 21 || (this_number == 21 && !GlobalScript.inst.gameState.allcountries[21].proprc && !GlobalScript.inst.gameState.allcountries[21].prosov && !GlobalScript.inst.gameState.allcountries[21].Vyshi))
			{
				sp.material.SetColor("_MainColor2", colors[11]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 131 || (this_number == 131 && !GlobalScript.inst.gameState.allcountries[131].proprc && !GlobalScript.inst.gameState.allcountries[131].prosov && !GlobalScript.inst.gameState.allcountries[131].Vyshi))
			{
				sp.material.SetColor("_MainColor2", new Color(0.25f, 0.25f, 0.25f));
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].puppetOf == 85 || (this_number == 85 && !GlobalScript.inst.gameState.allcountries[85].proprc && GlobalScript.inst.gameState.allcountries[85].SubGosstroy == 9 && !GlobalScript.inst.gameState.allcountries[85].prosov && !GlobalScript.inst.gameState.allcountries[85].Vyshi))
			{
				sp.material.SetColor("_MainColor2", new Color(0.255f, 0.55f, 1f));
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].Vyshi || ((this_number < 53 || this_number >= 69) && this_number != 61 && GlobalScript.inst.gameState.allcountries[this_number].usalliance))
			{
				sp.material.SetColor("_MainColor", colors[3]);
				sp.material.SetColor("_MainColor2", colors[4]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].prosov || ((this_number < 53 || this_number >= 69) && this_number != 61 && GlobalScript.inst.gameState.allcountries[this_number].sovalliance))
			{
				sp.material.SetColor("_MainColor2", colors[2]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].proprc)
			{
				sp.material.SetColor("_MainColor", colors[8]);
				sp.material.SetColor("_MainColor2", colors[9]);
			}
			return;
		}
		try
		{
			if (GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy == 19)
			{
				sp.material.SetColor("_MainColor2", new Color(0.65f, 0.65f, 0.65f));
			}
			else if ((GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 0 && GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy != 0) || (this_number == 30 && GlobalScript.inst.gameState.allcountries[this_number].cw && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 0))
			{
				sp.material.SetColor("_MainColor2", colors[1]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[this_number].SubGosstroy == 0 || (this_number == 30 && GlobalScript.inst.gameState.allcountries[this_number].cw && (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)))
			{
				sp.material.SetColor("_MainColor2", colors[2]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 2 || (this_number == 30 && GlobalScript.inst.gameState.allcountries[this_number].cw && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2))
			{
				sp.material.SetColor("_MainColor", colors[5]);
				sp.material.SetColor("_MainColor2", colors[7]);
			}
			else if (GlobalScript.inst.gameState.allcountries[this_number].Gosstroy == 3 || (this_number == 30 && GlobalScript.inst.gameState.allcountries[this_number].cw && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3))
			{
				sp.material.SetColor("_MainColor", colors[3]);
				sp.material.SetColor("_MainColor2", colors[4]);
			}
		}
		catch (Exception)
		{
			Debug.Log($"РАЗМЕР МАССИВА СТРАН {GlobalScript.inst.gameState.allcountries.Length}");
			Debug.Log($"НОМЕР {this_number} СТРАНА {GlobalScript.inst.gameState.allcountries[this_number]}");
		}
	}
}
