using System;
using KGWar;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiploButtonScript : MonoBehaviour
{
	public Sprite usl_off;

	public Sprite usl_on;

	private bool is_active;

	private GameState a;

	public GameObject opis;

	public GameObject[] uslovie = new GameObject[4];

	private bool[] uslovie_bool = new bool[4];

	private int number_uslovie;

	private string[] uslovie_text = new string[4];

	private string this_opis;

	public GlobalScript global1;

	private MapChangesScript map1;

	public Sprite on;

	public Sprite off;

	private int this_type = -1;

	private GameObject achieves;

	public int selected_country = -1;

	public void Awake()
	{
		a = GlobalScript.inst.gameState;
		map1 = GameObject.Find("MapChanges").GetComponent<MapChangesScript>();
		achieves = GameObject.Find("Ach(Clone)");
	}

	public void Hide()
	{
		base.transform.Find("Text").GetComponent<TextMesh>().text = null;
		is_active = false;
		GetComponent<SpriteRenderer>().sprite = null;
	}

	public void Show(string text, int number)
	{
		is_active = true;
		this_type = number;
		GetComponent<SpriteRenderer>().sprite = off;
		base.transform.Find("Text").GetComponent<TextMesh>().text = text;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (this_type == 2)
			{
				this_opis = " 准 备 武 力 占 领 港 澳 地 区";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[65] == 0;
				uslovie_text[0] = " 港 澳 未 被 我 方 控 制";
				if (a.resultOfEvents[469] == 1 || !a.event_done[469])
				{
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
					uslovie_text[1] = " 至 少 5 百 万 预 算";
					uslovie_bool[2] = a.data[22] >= 100;
					uslovie_text[2] = " 至 少 10 军 事 实 力";
				}
				else
				{
					uslovie_bool[1] = a.data[8] + a.data[36] >= 30;
					uslovie_text[1] = " 至 少 3 百 万 预 算";
					uslovie_bool[2] = a.data[22] >= 50;
					uslovie_text[2] = " 至 少 5 军 事 实 力";
				}
				uslovie_bool[3] = a.BritLost;
				uslovie_text[3] = " 英 国 输 掉 了 马 岛 战 争";
				return;
			}
			if (this_type == 1)
			{
				this_opis = " 支 持 毛 派 组 织";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 30;
				uslovie_text[0] = " 至 少 5 特 工 网 络 和 3 百 万 预 算";
				uslovie_bool[1] = a.modifies[6].active;
				uslovie_text[1] = " 我 们 始 终 坚 持 伟 大 的 毛 泽 东 思 想 ！";
				uslovie_bool[2] = a.data[6] > 750;
				uslovie_text[2] = " 外 交 声 誉 高 于 75";
				if (selected_country == 92 || selected_country == 21 || selected_country == 17)
				{
					uslovie_bool[3] = !a.war_active[0];
					uslovie_text[3] = " 西 欧 ： 每 年 一 次";
				}
				else
				{
					uslovie_bool[3] = !a.war_active[1];
					uslovie_text[3] = " 东 欧 ： 每 年 一 次";
				}
				return;
			}
			if (this_type == 3)
			{
				this_opis = " 与 英 国 和 葡 萄 牙 谈 判 收 回 港 澳 地 区";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 20;
				uslovie_text[0] = " 至 少 2 特 工 网 络";
				uslovie_bool[1] = a.data[21] >= 1980;
				uslovie_text[1] = " 不 早 于 1980 年";
				if (!GlobalScript.inst.dlc[3])
				{
					uslovie_bool[2] = a.data[6] < 700;
					uslovie_text[2] = " 外 交 声 誉 低 于 70";
				}
				else
				{
					uslovie_bool[2] = a.data[6] < 700 && a.allcountries[87].Gosstroy != 0;
					uslovie_text[2] = GlobalScript.inst.other_text[309];
				}
				uslovie_bool[3] = a.allcountries[0].dev == 0;
				uslovie_text[3] = " 尚 未 进 行 过 商 谈";
				return;
			}
			if (this_type == 4)
			{
				if (a.data[21] < 1979 || (a.data[20] < 4 && a.data[21] == 1979))
				{
					this_opis = " 深 化 《 中 苏 友 好 同 盟 互 助 条 约 》";
				}
				else
				{
					this_opis = " 中 苏 关 系 正 常 化";
				}
				number_uslovie = 4;
				uslovie_bool[0] = a.data[21] >= 1979;
				uslovie_text[0] = " 不 早 于 1979 年";
				if (a.data[21] < 1979 || (a.data[20] < 4 && a.data[21] == 1979))
				{
					if (a.leader.traits[0] == 0 && a.leader.traits[1] == 4 && a.leader.traits[2] == 8)
					{
						uslovie_bool[1] = a.data[1] >= 900 && a.SOV_PRC_PartiesConnection >= 100;
						uslovie_text[1] = " 党 内 团 结 度 至 少 90\n 联 络 机 构 的 规 模 至 少 为 10";
					}
					else
					{
						uslovie_bool[1] = a.data[1] >= 700 && a.SOV_PRC_PartiesConnection >= 200;
						uslovie_text[1] = " 党 内 团 结 度 至 少 70\n 联 络 机 构 的 规 模 至 少 为 20";
					}
				}
				else
				{
					uslovie_bool[1] = a.data[1] >= 900 && a.SOV_PRC_PartiesConnection >= 250;
					uslovie_text[1] = " 党 内 团 结 度 至 少 90\n 联 络 机 构 的 规 模 至 少 为 25";
				}
				uslovie_bool[2] = a.vietnampeace;
				uslovie_text[2] = "未 与 越 南 开 战";
				if (!a.relres)
				{
					uslovie_bool[3] = a.empires[1].relations >= 700;
					uslovie_text[3] = " 中 苏 关 系 至 少 为 70";
				}
				else
				{
					uslovie_bool[3] = !a.relres;
					uslovie_text[3] = " 尚 未 恢 复 关 系";
				}
				return;
			}
			if (this_type == 5)
			{
				this_opis = " 加 入 经 济 互 助 委 员 会";
				number_uslovie = 4;
				if (!a.relres)
				{
					uslovie_bool[0] = a.relres;
					uslovie_text[0] = " 中 苏 关 系 已 实 现 正 常 化";
				}
				else if (!a.event_done[380])
				{
					uslovie_bool[0] = !a.modifies[6].active || a.influencePRC < 300;
					uslovie_text[0] = " 不 再 坚 持 毛 泽 东 思 想\n 或 世 界 影 响 力 低 于 30";
				}
				else
				{
					uslovie_bool[0] = a.event_done[380];
					uslovie_text[0] = " 苏 联 已 经 再 斯 大 林 化";
				}
				uslovie_bool[1] = !a.allcountries[51].Torg;
				uslovie_text[1] = " 没 有 同 美 国 建 立 友 好 关 系";
				uslovie_bool[2] = a.data[6] > 690;
				uslovie_text[2] = " 外 交 声 誉 高 于 69";
				uslovie_bool[3] = !a.allcountries[1].isSEV;
				uslovie_text[3] = " 尚 未 参 与 同 类 组 织";
				return;
			}
			if (this_type == 74)
			{
				this_opis = " 成 为 经 济 互 助 委 员 会 的 观 察 员 国";
				number_uslovie = 3;
				uslovie_bool[0] = a.relres;
				uslovie_text[0] = " 中 苏 关 系 正 常 化";
				uslovie_bool[1] = !a.allcountries[51].Torg;
				uslovie_text[1] = " 没 有 同 美 国 维 持 友 好 关 系";
				uslovie_bool[2] = a.data[6] > 600;
				uslovie_text[2] = " 外 交 声 誉 高 于 60";
				return;
			}
			if (this_type == 6)
			{
				this_opis = " 加 入 华 沙 条 约 组 织";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[1].isSEV;
				uslovie_text[0] = " 已 加 入 经 互 会";
				uslovie_bool[1] = a.data[6] > 690;
				uslovie_text[1] = " 外 交 声 誉 高 于 69";
				uslovie_bool[2] = !a.allcountries[1].isOVD;
				uslovie_text[2] = " 尚 未 参 与 同 类 组 织";
				uslovie_bool[3] = !a.allcountries[15].cw;
				uslovie_text[3] = " 未 加 入 不 结 盟 运 动";
				return;
			}
			if (this_type == 7)
			{
				this_opis = " 恢 复 被 破 坏 的 沟 通 机 构| 规 模 ：" + a.SOV_PRC_PartiesConnection / 10 + "." + Mathf.Abs(a.SOV_PRC_PartiesConnection % 10);
				number_uslovie = 3;
				uslovie_bool[0] = a.data[9] >= a.SOV_PRC_PartiesConnection / 2;
				uslovie_text[0] = " 至 少" + a.SOV_PRC_PartiesConnection / 20 + "." + Mathf.Abs(a.SOV_PRC_PartiesConnection / 2 % 10) + "  特 工 网 络";
				uslovie_bool[1] = a.data[8] + a.data[36] >= a.SOV_PRC_PartiesConnection / 4;
				uslovie_text[1] = " 预 算 拨 款 ： " + a.SOV_PRC_PartiesConnection / 40 + "." + Mathf.Abs(a.SOV_PRC_PartiesConnection / 4 % 10);
				uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
				uslovie_text[2] = " 每 三 月 一 次";
				return;
			}
			if (this_type == 8)
			{
				this_opis = " 支 持 伊 朗 革 命 中 所 选 派 系";
				number_uslovie = 4;
				if (a.allcountries[selected_country].dev == 0 && a.data[43] < 1000)
				{
					uslovie_bool[0] = a.data[9] >= 90;
					uslovie_text[0] = " 至 少 9 特 工 网 络";
				}
				else if (a.allcountries[selected_country].dev == 1 && a.data[42] < 1000)
				{
					uslovie_bool[0] = a.data[9] >= 90;
					uslovie_text[0] = " 至 少 9 特 工 网 络";
				}
				else if (a.allcountries[selected_country].dev == 2 && a.data[44] < 1000)
				{
					uslovie_bool[0] = a.data[9] >= 90;
					uslovie_text[0] = " 至 少 9 特 工 网 络";
				}
				else if (a.data[45] < 1000)
				{
					uslovie_bool[0] = a.data[9] >= 90;
					uslovie_text[0] = " 至 少 9 特 工 网 络";
				}
				else
				{
					uslovie_bool[0] = a.data[9] < -5000;
					uslovie_text[0] = " 拉 我 们 支 持 的 兄 弟 一 把";
				}
				uslovie_bool[1] = a.data[8] + a.data[36] >= 60;
				uslovie_text[1] = " 至 少 6 百 万 预 算";
				uslovie_bool[2] = a.allcountries[selected_country].stab == 0 && a.allcountries[8].dev != 4;
				uslovie_text[2] = " 每 三 月 一 次";
				uslovie_bool[3] = a.iranrev;
				uslovie_text[3] = " 示 威 引 爆 内 乱 ， 革 命 仍 在 继 续";
				return;
			}
			if (this_type == 9)
			{
				if (selected_country == 104)
				{
					this_opis = " 建 立 正 式 外 交 关 系 并 深 化 经 贸 关 系";
				}
				else
				{
					this_opis = " 深 化 经 贸 关 系";
				}
				number_uslovie = 3;
				if (a.IsAuthoritarianism(selected_country))
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 80 之 间";
				}
				else if (a.IsSocialism(yes: true, selected_country))
				{
					uslovie_bool[0] = a.data[6] > 690;
					uslovie_text[0] = " 外 交 声 誉 高 于 69";
				}
				else if (a.allcountries[selected_country].Gosstroy == 2)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
				}
				else
				{
					uslovie_bool[0] = a.data[6] < 500;
					uslovie_text[0] = " 外 交 声 誉 低 于 50";
				}
				if (selected_country == 34 && a.ingamewars[2].is_going)
				{
					uslovie_bool[1] = !a.ingamewars[2].is_going;
					uslovie_text[1] = " 没 有 内 战";
				}
				else if (selected_country == 109 && a.ingamewars[31].is_going)
				{
					uslovie_bool[1] = !a.ingamewars[31].is_going;
					uslovie_text[1] = " 没 有 内 战";
				}
				else if (selected_country == 110 && a.ingamewars[32].is_going)
				{
					uslovie_bool[1] = !a.ingamewars[32].is_going;
					uslovie_text[1] = " 没 有 内 战";
				}
				else
				{
					uslovie_bool[1] = !a.allcountries[selected_country].Torg;
					uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
				}
				if (a.allcountries[selected_country].proprc)
				{
					uslovie_bool[2] = a.data[12] >= 300;
					uslovie_text[2] = " 工 业 不 低 于 30";
				}
				else if (selected_country == 92 || selected_country == 85 || selected_country == 136 || selected_country == 135 || selected_country == 137 || (selected_country > 87 && selected_country < 92) || selected_country == 0)
				{
					uslovie_bool[2] = a.data[12] >= 700;
					uslovie_text[2] = " 工 业 不 低 于 70";
				}
				else
				{
					uslovie_bool[2] = a.data[12] >= 500;
					uslovie_text[2] = " 工 业 不 低 于 50";
				}
				if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[7].isNATO;
					uslovie_text[3] = GlobalScript.inst.other_text[105];
				}
				return;
			}
			if (this_type == 10)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 3;
				if (selected_country != 35 && selected_country != 14)
				{
					uslovie_bool[0] = a.allcountries[selected_country].Torg || a.allcountries[selected_country].proprc;
					uslovie_text[0] = " 已 深 化 经 贸 关 系 或 该 国 持 亲 中 立 场";
				}
				else
				{
					uslovie_bool[0] = a.allcountries[selected_country].proprc;
					uslovie_text[0] = " 该 国 持 亲 中 立 场";
				}
				uslovie_bool[1] = a.allcountries[1].isSEV || a.allcountries[1].econ;
				uslovie_text[1] = " 中 国 已 建 立 经 合 组 织 ， 或 中 国 已 加 入 经 互 会";
				uslovie_bool[2] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isASEAN;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				if (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].usalliance)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].Vyshi && !a.allcountries[selected_country].usalliance;
					uslovie_text[3] = " 该 国 不 受 美 国 的 影 响";
				}
				else if ((a.allcountries[selected_country].prosov || a.allcountries[selected_country].sovalliance) && !a.allcountries[1].isSEV)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].sovalliance;
					uslovie_text[3] = " 该 国 不 受 苏 联 的 影 响";
				}
				else if (a.allcountries[selected_country].isSocEU)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].isSocEU;
					uslovie_text[3] = " 该 国 不 在 社 会 主 义 联 盟";
				}
				else if (selected_country == 8 && (a.ingamewars[3].is_going || a.ingamewars[5].is_going))
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.ingamewars[3].is_going && !a.ingamewars[5].is_going;
					uslovie_text[3] = " 伊 朗 与 阿 富 汗 均 无 战 事";
				}
				else if (selected_country == 8)
				{
					if (a.allcountries[selected_country].Gosstroy == 0)
					{
						uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
						uslovie_text[0] = " 外 交 声 誉 在 39 到 80 之 间";
					}
					else if (a.allcountries[selected_country].Gosstroy == 1)
					{
						uslovie_bool[0] = a.data[6] > 690;
						uslovie_text[0] = " 外 交 声 誉 高 于 69";
					}
					else if (a.allcountries[selected_country].Gosstroy == 2)
					{
						uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
						uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
					}
					else
					{
						uslovie_bool[0] = a.data[6] < 500;
						uslovie_text[0] = " 外 交 声 誉 低 于 50";
					}
				}
				return;
			}
			if (this_type == 11)
			{
				this_opis = " 为 被 泽 登 巴 尔 清 洗 的 蒙 人 党 党 内 反 对 派 提 供 政 治 庇 护 和 支 持";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[9] >= 100;
				uslovie_text[0] = " 至 少 10 特 工 网 络";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = " 至 少 5 百 万 预 算";
				uslovie_bool[2] = !a.allcountries[selected_country].cw;
				uslovie_text[2] = " 尚 未 提 供 支 持";
				return;
			}
			if (this_type == 12)
			{
				this_opis = " 在 其 党 内 煽 动 亲 华 派 势 力 政 变";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 100 && a.data[8] + a.data[36] >= 80;
				uslovie_text[0] = " 至 少 10 特 工 网 络 和 8 百 万 预 算";
				uslovie_bool[1] = a.data[6] > 690;
				uslovie_text[1] = " 外 交 声 誉 高 于 69";
				uslovie_bool[2] = a.allcountries[selected_country].stab != 0;
				uslovie_text[2] = " 已 经 引 发 动 乱";
				if (a.allcountries[selected_country].puppetOf != 7)
				{
					uslovie_bool[3] = !a.allcountries[selected_country].proprc;
					uslovie_text[3] = " 没 有 煽 动 政 变";
				}
				else
				{
					uslovie_bool[3] = a.allcountries[selected_country].puppetOf != 7;
					uslovie_text[3] = " 没 有 被 苏 联 傀 儡";
				}
				return;
			}
			if (this_type == 13)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 4;
				if (GlobalScript.inst.dlc[3])
				{
					uslovie_bool[0] = a.allcountries[selected_country].inflCh <= 0 && a.guns && a.allcountries[selected_country].inflNATO <= 0;
					uslovie_text[0] = GlobalScript.inst.other_text[102];
				}
				else
				{
					uslovie_bool[0] = a.allcountries[selected_country].inflCh <= 0 && a.guns;
					uslovie_text[0] = " 提 供 军 援 ， 且 没 有 实 施 制 裁";
				}
				uslovie_bool[1] = a.allcountries[1].isSEV || a.allcountries[1].econ;
				uslovie_text[1] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				uslovie_bool[2] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				if (a.allcountries[selected_country].Gosstroy <= 1)
				{
					uslovie_bool[3] = a.data[6] > 890;
					uslovie_text[3] = " 外 交 声 誉 高 于 89";
				}
				else
				{
					uslovie_bool[3] = a.data[6] > 490 && a.data[6] < 890;
					uslovie_text[3] = " 外 交 声 誉 在 49 到 89 之 间";
				}
				return;
			}
			if (this_type == 14)
			{
				this_opis = " 实 施 全 面 制 裁";
				if (!GlobalScript.inst.dlc[3])
				{
					number_uslovie = 2;
				}
				else
				{
					number_uslovie = 3;
				}
				uslovie_bool[0] = a.allcountries[selected_country].inflCh <= 0;
				uslovie_text[0] = " 尚 未 实 施 制 裁";
				uslovie_bool[1] = a.data[6] < 800;
				uslovie_text[1] = " 外 交 声 誉 低 于 80";
				if (GlobalScript.inst.dlc[3])
				{
					uslovie_bool[2] = a.allcountries[10].dev <= 0;
					uslovie_text[2] = GlobalScript.inst.other_text[101];
					if (a.ingamewars[16].is_going)
					{
						uslovie_bool[2] = !a.ingamewars[16].is_going;
						uslovie_text[2] = " 未 入 侵 朝 鲜";
					}
				}
				return;
			}
			if (this_type == 15)
			{
				this_opis = " 煽 动 一 场 新 的 朝 鲜 战 争";
				number_uslovie = 4;
				if (a.IsSocialism(yes: false, 46))
				{
					uslovie_bool[0] = a.guns && a.data[9] >= 100 && a.data[8] + a.data[36] >= 50;
					uslovie_text[0] = " 已 提 供 军 援\n 至 少 10 特 工 网 络 和 5 百 万 预 算";
				}
				else
				{
					uslovie_bool[0] = a.IsSocialism(yes: false, 46);
					uslovie_text[0] = " 韩 国 不 为 社 会 主 义";
				}
				if (!a.allcountries[1].isASEAN)
				{
					if (GlobalScript.inst.dlc[3])
					{
						uslovie_bool[1] = a.event_done[91] && a.allcountries[46].Gosstroy == 0 && a.allcountries[10].dev <= 0;
						uslovie_text[1] = GlobalScript.inst.other_text[103];
					}
					else
					{
						uslovie_bool[1] = a.event_done[91] && a.allcountries[46].Gosstroy == 0;
						uslovie_text[1] = " 全 斗 焕 遇 刺";
					}
				}
				else
				{
					uslovie_bool[1] = a.event_done[91];
					uslovie_text[1] = " 全 斗 焕 遇 刺";
				}
				uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
				uslovie_text[2] = " 尚 未 煽 动 战 争";
				uslovie_bool[3] = a.data[6] > 790;
				uslovie_text[3] = " 外 交 声 誉 高 于 79";
				return;
			}
			if (this_type == 16)
			{
				this_opis = " 提 供 军 事 物 资 ， 派 遣 技 术 专 家";
				if (!GlobalScript.inst.dlc[3])
				{
					number_uslovie = 3;
				}
				else
				{
					number_uslovie = 4;
				}
				uslovie_bool[0] = !a.guns;
				uslovie_text[0] = " 尚 未 提 供 军 援";
				uslovie_bool[1] = a.data[22] >= 50;
				uslovie_text[1] = " 至 少 5 军 事 实 力";
				uslovie_bool[2] = a.data[8] + a.data[36] >= 20;
				uslovie_text[2] = " 至 少 2 百 万 预 算";
				if (GlobalScript.inst.dlc[3])
				{
					uslovie_bool[3] = a.allcountries[10].dev <= 0;
					uslovie_text[3] = GlobalScript.inst.other_text[101];
				}
				return;
			}
			if (this_type == 17)
			{
				this_opis = " 深 化 经 贸 关 系";
				number_uslovie = 3;
				if (!a.allcountries[selected_country].proprc)
				{
					uslovie_bool[0] = a.vietnampeace;
					uslovie_text[0] = " 未 与 越 南 开 战";
				}
				else
				{
					uslovie_bool[0] = a.allcountries[selected_country].proprc;
					uslovie_text[0] = " 越 南 受 中 国 的 影 响";
				}
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
				uslovie_bool[2] = a.data[6] > 690 || a.allcountries[selected_country].proprc;
				uslovie_text[2] = " 外 交 声 誉 高 于 69 或 越 南 持 亲 中 立 场";
				if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[7].isNATO;
					uslovie_text[3] = GlobalScript.inst.other_text[105];
					return;
				}
				if (GlobalScript.inst.gameState.data[21] != 197)
				{
					number_uslovie = 4;
				}
				if (a.allcountries[selected_country].puppetOf < 0)
				{
					uslovie_bool[3] = !GlobalScript.inst.gameState.event_done[15];
					uslovie_text[3] = " 柬 越 未 开 战";
				}
				return;
			}
			if (this_type == 18)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 3;
				uslovie_bool[0] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ;
				uslovie_text[0] = " 越 南 未 加 入 我 们 的 经 合 组 织 或 经 互 会";
				uslovie_bool[1] = a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 已 深 化 经 贸 关 系";
				uslovie_bool[2] = a.allcountries[1].econ || a.allcountries[1].isSEV;
				uslovie_text[2] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				if (a.allcountries[selected_country].Vyshi)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
					uslovie_text[3] = " 该 国 不 受 美 国 的 影 响";
				}
				return;
			}
			if (this_type == 19)
			{
				this_opis = " 邀 请 该 国 参 与 我 国 军 事 联 盟 ， 实 现 合 作 无 上 限 ， 保 障 地 区 安 全 稳 定";
				number_uslovie = 4;
				uslovie_bool[1] = a.data[22] >= 20;
				uslovie_text[1] = " 至 少 2 军 事 实 力";
				uslovie_bool[3] = a.data[6] > 790;
				uslovie_text[3] = " 外 交 声 誉 高 于 79";
				uslovie_bool[0] = a.allcountries[selected_country].isSEV || a.allcountries[selected_country].econ;
				uslovie_text[0] = " 他 们 已 加 入 经 合 组 织 或 经 互 会";
				if (!a.allcountries[selected_country].oar)
				{
					uslovie_bool[2] = (!a.allcountries[selected_country].isOVD && a.allcountries[1].isOVD && !a.allcountries[selected_country].isSEATO) || (!a.allcountries[selected_country].okb && a.allcountries[1].okb && !a.allcountries[selected_country].isOVD && !a.allcountries[selected_country].isSEATO);
					uslovie_text[2] = " 他 们 未 参 与 军 事 联 盟| 中 国 已 成 立 集 安 组 织 或 已 加 入 华 约";
				}
				else if (a.allcountries[30].Gosstroy == 1)
				{
					uslovie_bool[2] = (!a.allcountries[selected_country].isOVD && a.allcountries[1].isOVD && !a.allcountries[selected_country].isSEATO) || (!a.allcountries[selected_country].okb && a.allcountries[1].okb && !a.allcountries[selected_country].isOVD && !a.allcountries[selected_country].isSEATO);
					uslovie_text[2] = " 他 们 未 参 与 军 事 联 盟| 中 国 已 成 立 集 安 组 织 或 已 加 入 华 约";
				}
				else
				{
					uslovie_bool[2] = !a.allcountries[selected_country].oar;
					uslovie_text[2] = GlobalScript.inst.other_text[104];
				}
				if (((selected_country > 53 && selected_country < 69) || (selected_country > 105 && selected_country < 109) || (selected_country > 111 && selected_country < 134) || selected_country == 41 || selected_country == 42 || selected_country == 52 || selected_country == 99 || selected_country == 100 || selected_country == 150 || selected_country == 151 || selected_country == 153 || selected_country == 155 || selected_country == 158) && selected_country != 55 && selected_country != 54 && selected_country != 128 && GlobalScript.inst.gameState.allcountries[selected_country].proprc && (GlobalScript.inst.gameState.allcountries[selected_country].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[selected_country].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0 && a.allcountries[1].okb)
				{
					this_opis = " 邀 请 该 国 加 入 非 洲 联 盟 ，投 身 于 非 洲 革 命 与 解 放 的 伟 大 事 业 中";
					number_uslovie = 4;
					uslovie_bool[0] = GlobalScript.inst.gameState.IsSocialism(yes: true, selected_country) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0;
					uslovie_text[0] = " 非 洲 联 盟 已 建 立";
					uslovie_bool[1] = a.data[22] >= 20;
					uslovie_text[1] = " 至 少 2 军 事 实 力";
					uslovie_bool[2] = !a.allcountries[selected_country].okb && a.allcountries[1].okb;
					uslovie_text[2] = " 他 们 未 加 入 非 洲 联 盟";
					uslovie_bool[3] = a.data[6] > 790;
					uslovie_text[3] = " 外 交 声 誉 高 于 79";
				}
				return;
			}
			if (this_type == 20)
			{
				if (selected_country == 11)
				{
					this_opis = " 派 遣 解 放 军 增 援 前 线| 我 方 军 力 强 度 ：" + a.data[39] / 10 + "." + Mathf.Abs(a.data[39] % 10);
				}
				else if (selected_country == 19)
				{
					this_opis = " 派 遣 解 放 军 增 援 前 线| 我 方 军 力 强 度 ：" + a.data[40] / 10 + "." + Mathf.Abs(a.data[40] % 10);
				}
				number_uslovie = 3;
				uslovie_bool[0] = a.war == 1;
				uslovie_text[0] = " 与 越 南 爆 发 战 争";
				uslovie_bool[1] = a.data[22] >= 70;
				uslovie_text[1] = " 至 少 7 军 事 实 力";
				uslovie_bool[2] = a.allcountries[selected_country].stab != 3;
				uslovie_text[2] = " 本 月 增 兵 未 达 三 次";
				return;
			}
			if (this_type == 21)
			{
				this_opis = " 在 争 取 权 力 的 和 平 斗 争 中 支 持 我 们 所 选 择 的 势 力";
				number_uslovie = 4;
				uslovie_bool[0] = a.DRAagree;
				uslovie_text[0] = " 同 阿 富 汗 和 苏 联 达 成 了 协 议";
				uslovie_bool[1] = a.data[9] >= 40;
				uslovie_text[1] = " 至 少 4 特 工 网 络";
				uslovie_bool[2] = a.data[8] + a.data[36] >= 30;
				uslovie_text[2] = " 至 少 3 百 万 预 算";
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
				uslovie_text[3] = " 本 年 尚 未 支 持";
				return;
			}
			if (this_type == 68)
			{
				this_opis = " 接 纳 加 入 经 济 互 助 委 员 会 ，联 合 力 量 ，促 进 发 展";
				number_uslovie = 4;
				uslovie_bool[0] = !a.ingamewars[5].is_going;
				uslovie_text[0] = " 国 家 状 态 没 有 内 战";
				uslovie_bool[1] = a.allcountries[selected_country].proprc || (a.allcountries[1].isSEV && a.allcountries[selected_country].prosov);
				uslovie_text[1] = " 阿 富 汗 持 亲 中 或 亲 苏 立 场\n 中 国 已 加 入 经 互 会";
				uslovie_bool[2] = a.allcountries[selected_country].Torg && (a.allcountries[1].econ || a.allcountries[1].isSEV);
				uslovie_text[2] = " 已 深 化 经 贸 关 系";
				uslovie_bool[3] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].isASEAN;
				uslovie_text[3] = " 该 国 未 加 入 经 合 组 织";
				return;
			}
			if (this_type == 22)
			{
				this_opis = " 向 卡 扎 菲 政 府 提 供 经 济 援 助";
				number_uslovie = 2;
				uslovie_bool[0] = a.allcountries[selected_country].stab == 0;
				uslovie_text[0] = " 尚 未 进 行 资 助";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = " 至 少 5 百 万 预 算";
				return;
			}
			if (this_type == 23)
			{
				this_opis = " 开 始 联 络 利 比 亚 国 内 的 反 对 派";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[9] >= 50;
				uslovie_text[0] = " 至 少 5 点 特 工 网 络";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = " 至 少 5 百 万 预 算";
				uslovie_bool[2] = !a.allcountries[selected_country].cw;
				uslovie_text[2] = " 尚 未 联 络 过";
				return;
			}
			if (this_type == 67)
			{
				this_opis = " 促 成 该 国 加 入 阿 拉 伯 联 合 共 和 国 ，实 现 阿 拉 伯 世 界 的 政 治 统 一";
				number_uslovie = 2;
				uslovie_bool[0] = a.OAR;
				uslovie_text[0] = " 阿 拉 伯 联 合 共 和 国 已 经 成 立";
				if (a.allcountries[30].Gosstroy == 1)
				{
					uslovie_bool[1] = !a.allcountries[selected_country].oar;
					uslovie_text[1] = " 该 国 未 加 入 阿 拉 伯 联 合 共 和 国";
				}
				else
				{
					uslovie_bool[1] = !a.allcountries[selected_country].oar && !a.allcountries[selected_country].isNATO && !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD;
					uslovie_text[1] = " 该 国 未 加 入 阿 拉 伯 联 合 共 和 国\n 且 未 参 与 军 事 联 盟";
				}
				if (a.allcountries[30].Gosstroy == 1)
				{
					if (selected_country == 13)
					{
						number_uslovie = 3;
						uslovie_bool[2] = a.allcountries[13].Gosstroy == 1;
						uslovie_text[2] = " 卡 扎 菲 已 被 推 翻 并 建 成 社 会 主 义 政 权";
					}
					else
					{
						number_uslovie = 3;
						uslovie_bool[2] = a.IsSocialism(yes: true, selected_country);
						uslovie_text[2] = " 该 国 为 社 会 主 义";
					}
				}
				else if (selected_country == 13)
				{
					number_uslovie = 3;
					uslovie_bool[2] = !a.allcountries[13].parts[1];
					uslovie_text[2] = "利 比 亚 与 乍 得 未 合 并";
				}
				else
				{
					number_uslovie = 3;
					uslovie_bool[2] = a.allcountries[selected_country].Gosstroy == 2 || a.allcountries[selected_country].SubGosstroy == 10;
					uslovie_text[2] = " 该 国 为 改 良 主 义 或 左 翼 民 族 主 义";
				}
				return;
			}
			if (this_type == 24)
			{
				this_opis = " 深 化 经 贸 关 系";
				number_uslovie = 3;
				if (a.allcountries[selected_country].Gosstroy == 0)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 80 之 间";
				}
				else if (a.allcountries[selected_country].Gosstroy == 1)
				{
					uslovie_bool[0] = a.data[6] > 690;
					uslovie_text[0] = " 外 交 声 誉 高 于 69";
				}
				else if (a.allcountries[selected_country].Gosstroy == 2)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
				}
				else
				{
					uslovie_bool[0] = a.data[6] < 500;
					uslovie_text[0] = " 外 交 声 誉 低 于 50";
				}
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
				uslovie_bool[2] = a.data[12] >= 700;
				uslovie_text[2] = " 工 业 不 低 于 70";
				if (selected_country == 52)
				{
					number_uslovie = 4;
					uslovie_bool[3] = a.allcountries[52].stab <= 0;
					uslovie_text[3] = GlobalScript.inst.other_text[473];
				}
				if (selected_country == 14)
				{
					number_uslovie = 4;
					uslovie_bool[3] = a.allcountries[14].puppetOf != 8;
					uslovie_text[3] = " 该 国 不 受 伊 朗 人 的 摆 布";
				}
				else if (((selected_country >= 2 && selected_country <= 6) || selected_country == 16) && a.allcountries[1].isSEV)
				{
					number_uslovie = 4;
					uslovie_bool[3] = a.allcountries[1].isSEV;
					uslovie_text[3] = " 中 国 已 加 入 经 互 会";
				}
				else if ((selected_country >= 2 && selected_country <= 6) || selected_country == 16)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].prosov;
					uslovie_text[3] = " 该 国 不 受 苏 联 的 影 响";
				}
				return;
			}
			if (this_type == 50)
			{
				this_opis = " 深 化 经 贸 关 系";
				number_uslovie = 3;
				if (a.allcountries[selected_country].Gosstroy == 0)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 80 之 间";
				}
				else if (a.allcountries[selected_country].Gosstroy == 1)
				{
					uslovie_bool[0] = a.data[6] > 690;
					uslovie_text[0] = " 外 交 声 誉 高 于 69";
				}
				else if (a.allcountries[selected_country].Gosstroy == 2)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
				}
				else
				{
					uslovie_bool[0] = a.data[6] < 500;
					uslovie_text[0] = " 外 交 声 誉 低 于 50";
				}
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
				uslovie_bool[2] = a.data[12] >= 700;
				uslovie_text[2] = " 工 业 不 低 于 70";
				if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[7].isNATO;
					uslovie_text[3] = GlobalScript.inst.other_text[105];
				}
				return;
			}
			if (this_type == 69)
			{
				this_opis = " 同 当 地 共 产 主 义 者 建 立 联 系 并 给 予 支 持";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[6] > 790;
				uslovie_text[0] = " 外 交 声 誉 高 于 79";
				uslovie_bool[1] = a.data[9] >= 30;
				uslovie_text[1] = " 至 少 3 特 工 网 络";
				uslovie_bool[2] = a.event_done[3];
				uslovie_text[2] = " 萨 达 姆 正 大 肆 镇 压 共 产 主 义 者";
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
				uslovie_text[3] = " 尚 未 提 供 支 持";
				return;
			}
			if (this_type == 25)
			{
				this_opis = " 促 成 该 国 加 入 阿 拉 伯 联 合 共 和 国 ，实 现 阿 拉 伯 世 界 的 政 治 统 一";
				number_uslovie = 4;
				uslovie_bool[0] = a.OAR;
				uslovie_text[0] = " 阿 拉 伯 联 合 共 和 国 已 经 成 立";
				if (a.allcountries[30].Gosstroy == 1)
				{
					uslovie_bool[1] = !a.allcountries[selected_country].oar;
					uslovie_text[1] = " 该 国 未 加 入 阿 拉 伯 联 合 共 和 国";
				}
				else
				{
					uslovie_bool[1] = !a.allcountries[selected_country].oar && !a.allcountries[selected_country].isNATO && !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD;
					uslovie_text[1] = " 该 国 未 加 入 阿 拉 伯 联 合 共 和 国\n 且 未 参 与 军 事 联 盟";
				}
				if (a.allcountries[30].Gosstroy == 1)
				{
					number_uslovie = 3;
					uslovie_bool[2] = a.IsSocialism(yes: true, selected_country);
					uslovie_text[2] = " 该 国 为 社 会 主 义";
				}
				else
				{
					number_uslovie = 3;
					uslovie_bool[2] = a.allcountries[selected_country].Gosstroy == 2 || a.allcountries[selected_country].SubGosstroy == 10;
					uslovie_text[2] = " 该 国 为 改 良 主 义 或 左 翼 民 族 主 义";
				}
				if (a.allcountries[14].Vyshi)
				{
					uslovie_bool[3] = !a.allcountries[14].Vyshi;
					uslovie_text[3] = " 该 国 不 受 美 国 的 影 响";
				}
				else if (a.allcountries[8].Gosstroy == 0)
				{
					uslovie_bool[3] = a.allcountries[8].SubGosstroy != 9;
					uslovie_text[3] = " 伊 朗 不 是 伊 斯 兰 主 义 者 当 政";
				}
				else
				{
					uslovie_bool[3] = a.data[117] != 9;
					uslovie_text[3] = " 不 受 伊 朗 人 的 摆 布";
				}
				return;
			}
			if (this_type == 26)
			{
				this_opis = " 签 署 一 份 友 好 合 作 协 定";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 900;
				uslovie_text[0] = " 外 交 声 誉 在 39 到 90 之 间";
				uslovie_bool[1] = (a.data[20] >= 5 && a.data[21] >= 1980) || a.data[21] >= 1981;
				uslovie_text[1] = " 铁 托 去 世";
				uslovie_bool[2] = !a.allcountries[selected_country].Torg;
				uslovie_text[2] = " 尚 未 签 署 协 定";
				return;
			}
			if (this_type == 75)
			{
				this_opis = " 向 美 国 人 分 享 科 技";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[11] >= 100;
				uslovie_text[0] = " 至 少 10 科 研 点";
				uslovie_bool[1] = a.data[56] != 0;
				uslovie_text[1] = " 极 左 派 不 占 主 导 地 位";
				uslovie_bool[2] = a.empires[0].power < 600;
				uslovie_text[2] = " 美 国 的 世 界 影 响 力 低 于 60";
				return;
			}
			if (this_type == 81)
			{
				this_opis = " 向 苏 联 人 转 售 科 技";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[11] >= 100;
				uslovie_text[0] = " 至 少 10 科 研 点";
				uslovie_bool[1] = a.allcountries[1].isSEV || a.allcountries[7].Torg;
				uslovie_text[1] = " 是 经 互 会 的 观 察 员 国 或 成 员 国";
				uslovie_bool[2] = a.empires[1].power < 600;
				uslovie_text[2] = " 苏 联 的 世 界 影 响 力 低 于 60";
				uslovie_bool[3] = a.allcountries[51].Torg;
				uslovie_text[3] = " 已 与 美 国 签 署 友 好 合 作 协 定";
				return;
			}
			if (this_type == 76)
			{
				this_opis = " 对 当 地 金 融 运 转 和 债 务 流 通 施 行 优 待 政 策";
				number_uslovie = 2;
				uslovie_bool[0] = a.data[36] >= 200;
				uslovie_text[0] = " 储 备 金 －20 百 万";
				uslovie_bool[1] = !a.allcountries[selected_country].cw;
				uslovie_text[1] = " 尚 未 施 行 帮 扶 政 策";
				return;
			}
			if (this_type == 77)
			{
				this_opis = "针 对 民 族 分 离 主 义 政 府| 组 织 不 留 血 政 变";
				this_opis = this_opis + "|Our influence: " + a.allcountries[selected_country].dev + "%";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].cw;
				uslovie_text[0] = " 经 济 上 紧 密 联 结";
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 组 织 罢 免";
				uslovie_bool[2] = a.allcountries[selected_country].dev >= 30;
				uslovie_text[2] = " 我 们 对 当 地 的 影 响 力 达 到 30";
				uslovie_bool[3] = a.data[9] >= 80;
				uslovie_text[3] = " 特 工 网 络 －8";
				return;
			}
			if (this_type == 78)
			{
				this_opis = " 在 此 设 立 军 事 基 地 以 保 护 主 权 不 受 侵 害";
				this_opis = this_opis + "| 我 们 的 影 响 力 ：" + a.allcountries[selected_country].dev + "%";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[selected_country].proprc;
				uslovie_text[0] = " 尚 未 设 立 军 事 基 地";
				uslovie_bool[1] = a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 民 族 分 离 主 义 政 府 被 罢 免";
				uslovie_bool[2] = a.allcountries[selected_country].dev >= 60;
				uslovie_text[2] = " 我 们 对 当 地 的 影 响 力 达 到 60";
				uslovie_bool[3] = a.data[9] >= 60 && a.data[22] >= 100;
				uslovie_text[3] = " 特 工 网 络 －6 ， 军 事 实 力 －10";
				return;
			}
			if (this_type == 79)
			{
				this_opis = " 在 当 地 组 织 一 场 呼 吁 回 归 祖 国 的 公 投";
				this_opis = this_opis + "| 我 们 的 影 响 力 ：" + a.allcountries[selected_country].dev + "%";
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = " 在 此 设 有 军 事 基 地";
				uslovie_bool[1] = a.allcountries[selected_country].dev >= 100;
				uslovie_text[1] = " 我 们 对 当 地 的 影 响 力 达 到 100";
				uslovie_bool[2] = a.data[9] >= 80;
				uslovie_text[2] = " 特 工 网 络 - 8";
				return;
			}
			if (this_type == 80)
			{
				this_opis = " 参 照 我 国 制 度 整 饬 他 们 的 政 体";
				this_opis = this_opis + "| 目 前 该 国 政 体 为 ：" + ((a.ChineseSubGosstroy() < 19) ? GlobalScript.inst.other_text[(a.ChineseSubGosstroy() < 10) ? (a.ChineseSubGosstroy() + 13) : (a.ChineseSubGosstroy() + 82)] : "封 建 社 会 主 义");
				number_uslovie = 4;
				if (a.allcountries[1].okb && a.allcountries[selected_country].proprc && a.allcountries[selected_country].SubGosstroy != a.ChineseSubGosstroy())
				{
					uslovie_bool[0] = a.allcountries[selected_country].SubGosstroy != a.ChineseSubGosstroy();
					uslovie_text[0] = " 我 们 的 国 体 不 一 致";
				}
				else if (a.allcountries[1].okb && (!a.allcountries[selected_country].proprc || a.allcountries[selected_country].prosov || a.allcountries[selected_country].Vyshi))
				{
					uslovie_bool[0] = !a.allcountries[selected_country].proprc || a.allcountries[selected_country].prosov || a.allcountries[selected_country].Vyshi;
					uslovie_text[0] = " 不 在 我 们 影 响 下";
				}
				else
				{
					uslovie_bool[0] = a.allcountries[1].okb;
					uslovie_text[0] = " 我 们 有 自 己 的 军 事 同 盟";
				}
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = " 预 算 ： 5";
				uslovie_bool[2] = a.data[9] >= 50;
				uslovie_text[2] = " 特 工 网 络 ： 5";
				uslovie_bool[3] = a.data[22] >= 50;
				uslovie_text[3] = " 军 事 实 力 ： 5";
				return;
			}
			if (this_type == 27)
			{
				if (!a.allcountries[85].isSocEU)
				{
					this_opis = " 同 当 地 共 产 主 义 者 建 立 联 系 并 给 予 支 持";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[6] > 590;
					uslovie_text[0] = " 外 交 声 誉 高 于 59";
					uslovie_bool[1] = a.data[9] >= 40;
					uslovie_text[1] = " 至 少 4 特 工 网 络";
					uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
					uslovie_text[2] = " 尚 未 提 供 支 持";
				}
				else
				{
					this_opis = " 邀 请 该 国 加 入 欧 洲 社 会 主 义 联 盟 ， 推 进 建 设 人 道 、 民 主 的 社 会 主 义";
					number_uslovie = 3;
					uslovie_bool[0] = a.resultOfEvents[113] == 1 && a.event_done[113];
					uslovie_text[0] = " 帮 助 南 斯 拉 夫 偿 还 了 外 债";
					uslovie_bool[1] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 50;
					uslovie_text[1] = " 至 少 5 特 工 网 络 与 5 百 万 预 算";
					uslovie_bool[2] = a.allcountries[selected_country].dev != 2;
					uslovie_text[2] = " 尚 未 提 供 支 持";
				}
				return;
			}
			if (this_type == 72)
			{
				this_opis = " 加 入 不 结 盟 运 动";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[1].isOVD && !a.allcountries[1].okb && !a.allcountries[1].isSEATO;
				uslovie_text[0] = " 我 们 未 参 与 任 何 军 事 联 盟";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 20;
				uslovie_text[1] = " 至 少 2 百 万 预 算";
				uslovie_bool[2] = !a.allcountries[15].cw;
				uslovie_text[2] = " 未 加 入 不 结 盟 运 动";
				uslovie_bool[3] = a.war <= 0;
				uslovie_text[3] = " 我 们 没 有 战 争";
				return;
			}
			if (this_type == 73)
			{
				this_opis = " 退 出 不 结 盟 运 动";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[1] > 750;
				uslovie_text[0] = " 党 内 团 结 度 至 少 75";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = " 至 少 5 百 万 预 算";
				uslovie_bool[2] = a.allcountries[15].cw;
				uslovie_text[2] = " 已 加 入 不 结 盟 运 动";
				return;
			}
			if (this_type == 28)
			{
				this_opis = " 支 持 东 部 游 击 武 装| 毛 主 义 者 力 量 ：" + a.data[32] / 10 + "." + Mathf.Abs(a.data[32] % 10);
				number_uslovie = 4;
				uslovie_bool[0] = a.data[6] > 790;
				uslovie_text[0] = " 外 交 声 誉 高 于 79";
				uslovie_bool[1] = a.data[9] >= 30 && a.data[22] >= 30;
				uslovie_text[1] = " 至 少 3 特 工 网 络 和 军 事 实 力";
				uslovie_bool[2] = !a.allcountries[selected_country].Torg;
				uslovie_text[2] = " 尚 未 推 动 中 印 关 系 正 常 化";
				if (a.data[32] <= 500 || GlobalScript.inst.dlc[1])
				{
					uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
					uslovie_text[3] = " 本 月 尚 未 支 持";
				}
				else
				{
					uslovie_bool[3] = a.allcountries[selected_country].stab == 0 && a.data[32] <= 500;
					uslovie_text[3] = " 尚 未 达 到 其 最 大 军 事 实 力";
				}
				return;
			}
			if (this_type == 29)
			{
				this_opis = " 推 动 中 印 关 系 正 常 化";
				number_uslovie = 4;
				uslovie_bool[0] = (a.data[91] == 1 || a.data[91] == 2 || a.data[91] == 3) && (!a.allcountries[31].Torg || a.allcountries[31].Gosstroy == 2 || a.allcountries[31].Gosstroy == 1);
				uslovie_text[0] = " 帮 助 英 迪 拉 ， 且 未 与 巴 基 斯 坦 建 立 友 好 关 系| 或 布 托 是 巴 基 斯 坦 总 理";
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 建 立 友 好 关 系";
				uslovie_bool[2] = a.allcountries[selected_country].dev == 0 && a.war == 0 && a.data[62] < 2;
				uslovie_text[2] = " 尚 未 发 动 战 争";
				uslovie_bool[3] = a.data[62] == 0;
				uslovie_text[3] = " 领 土 争 端 仍 悬 而 未 决";
				return;
			}
			if (this_type == 30)
			{
				this_opis = " 以 领 土 争 端 为 由 ， 发 动 边 境 战 争";
				number_uslovie = 4;
				uslovie_bool[0] = a.CBIndia;
				uslovie_text[0] = " 拥 有 战 争 理 由";
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 建 立 友 好 关 系";
				uslovie_bool[2] = a.allcountries[selected_country].dev == 0 && a.war == 0 && a.data[62] < 2;
				uslovie_text[2] = " 尚 未 发 动 战 争";
				uslovie_bool[3] = !a.allcountries[15].cw;
				uslovie_text[3] = " 未 加 入 不 结 盟 运 动";
				return;
			}
			if (this_type == 89)
			{
				this_opis = " 以 我 国 投 资 为 筹 码 ， 收 回 藏 南 地 区 ";
				number_uslovie = 3;
				uslovie_bool[0] = a.influencePRC >= 500;
				uslovie_text[0] = " 中 国 的 世 界 影 响 力 不 低 于 50";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 250;
				uslovie_text[1] = " 至 少 25 百 万 预 算";
				uslovie_bool[2] = a.CBIndia;
				uslovie_text[2] = " 领 土 争 端 仍 悬 而 未 决";
				return;
			}
			if (this_type == 71)
			{
				if (selected_country == 11)
				{
					this_opis = " 派 遣 解 放 军 增 援 前 线| 我 方 军 力 强 度 ：" + a.data[39] / 10 + "." + Mathf.Abs(a.data[39] % 10);
				}
				else if (selected_country == 19)
				{
					this_opis = " 派 遣 解 放 军 增 援 前 线| 我 方 军 力 强 度 ：" + a.data[40] / 10 + "." + Mathf.Abs(a.data[40] % 10);
				}
				number_uslovie = 3;
				uslovie_bool[0] = a.war == 2;
				uslovie_text[0] = " 与 印 度 爆 发 战 争";
				uslovie_bool[1] = a.data[22] >= 70;
				uslovie_text[1] = " 至 少 7 军 事 实 力";
				uslovie_bool[2] = a.allcountries[selected_country].prcpower != 3;
				uslovie_text[2] = " 本 月 增 兵 未 达 三 次";
				return;
			}
			if (this_type == 31)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = " 阿 尔 巴 尼 亚 持 亲 中 立 场";
				uslovie_bool[1] = a.allcountries[1].econ || (a.allcountries[1].isSEV && a.SovAlb);
				uslovie_text[1] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会| 且 其 与 苏 联 已 恢 复 外 交";
				uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				if (a.allcountries[selected_country].Vyshi)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
					uslovie_text[3] = " 该 国 不 受 美 国 的 影 响";
				}
				return;
			}
			if (this_type == 32)
			{
				this_opis = " 从 中 斡 旋 ，使 苏 联 与 阿 尔 巴 尼 亚 关 系 正 常 化";
				number_uslovie = 4;
				uslovie_bool[0] = a.relres;
				uslovie_text[0] = " 中 苏 关 系 正 常 化";
				uslovie_bool[1] = a.data[6] > 790 || a.allcountries[7].Torg;
				uslovie_text[1] = " 外 交 声 誉 高 于 79| 或 我 们 是 经 互 会 的 观 察 员 国";
				uslovie_bool[2] = a.data[60] > 0;
				uslovie_text[2] = " 霍 查 去 世 或 被 推 翻";
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
				uslovie_text[3] = " 他 们 未 与 苏 联 恢 复 外 交";
				return;
			}
			if (this_type == 33)
			{
				this_opis = " 签 署 一 份 友 好 合 作 协 定";
				number_uslovie = 2;
				if (a.allcountries[selected_country].Gosstroy == 3)
				{
					uslovie_bool[0] = a.data[6] < 800;
					uslovie_text[0] = " 外 交 声 誉 低 于 80";
				}
				else if (a.allcountries[selected_country].Gosstroy == 2)
				{
					uslovie_bool[0] = a.data[6] < 900;
					uslovie_text[0] = " 外 交 声 誉 低 于 90";
				}
				else if (a.allcountries[selected_country].Gosstroy == 1)
				{
					uslovie_bool[0] = a.data[6] > 700;
					uslovie_text[0] = " 外 交 声 誉 高 于 70";
				}
				else if (a.allcountries[selected_country].Gosstroy == 0)
				{
					uslovie_bool[0] = a.data[6] < 800;
					uslovie_text[0] = " 外 交 声 誉 低 于 80";
				}
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 签 署 协 定";
				if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
				{
					number_uslovie = 3;
					uslovie_bool[2] = !a.allcountries[7].isNATO;
					uslovie_text[2] = GlobalScript.inst.other_text[105];
				}
				return;
			}
			if (this_type == 34)
			{
				this_opis = " 邀 请 外 国 投 资 者";
				number_uslovie = 3;
				if (a.allcountries[21].Gosstroy == 1 && selected_country == 21)
				{
					uslovie_bool[0] = a.data[6] >= 600;
					uslovie_text[0] = " 外 交 声 誉 高 于 60";
				}
				else
				{
					uslovie_bool[0] = a.data[6] < 600;
					uslovie_text[0] = " 外 交 声 誉 低 于 60";
				}
				if (a.allcountries[21].Gosstroy == 1 && selected_country == 21)
				{
					uslovie_bool[1] = a.data[16] < 13 || a.SEZ;
					uslovie_text[1] = "经 济 模 式 为 \" 国 家 垄 断 资 本 主 义\" 或 更 偏 社 会 主 义 的 政 策| 或 开 放 自 由 贸 易 区";
				}
				else
				{
					uslovie_bool[1] = a.data[16] >= 13 || a.SEZ;
					uslovie_text[1] = "经 济 模 式 为 \" 鸟 笼 经 济 \" 或 更 偏 自 由 主 义 的 政 策| 或 开 放 经 济 特 区";
				}
				uslovie_bool[2] = a.allcountries[selected_country].stab == 0;
				uslovie_text[2] = " 本 年 尚 未 吸 引 外 国 投 资";
				return;
			}
			if (this_type == 35)
			{
				this_opis = " 建 立 紧 密 关 系";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[6] > 690;
				uslovie_text[0] = " 外 交 声 誉 高 于 69";
				uslovie_bool[1] = a.data[9] >= 30;
				uslovie_text[1] = " 至 少 3 特 工 网 络";
				uslovie_bool[2] = a.allcountries[11].proprc;
				uslovie_text[2] = " 越 南 持 亲 中 立 场";
				uslovie_bool[3] = !a.allcountries[selected_country].proprc;
				uslovie_text[3] = " 尚 未 融 合 为 一";
				return;
			}
			if (this_type == 36)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = " 老 挝 持 亲 中 立 场";
				uslovie_bool[1] = a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 已 深 化 经 贸 关 系";
				uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
				uslovie_text[3] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				return;
			}
			if (this_type == 37)
			{
				this_opis = " 挑 起 军 事 政 变 ， 以 推 翻 波 尔 布 特";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = " 柬 埔 寨 持 亲 中 立 场";
				uslovie_bool[1] = a.data[38] == 100;
				uslovie_text[1] = " 毛 主 席 已 离 世";
				uslovie_bool[2] = a.allcountries[selected_country].stab == 0 && a.allcountries[selected_country].Gosstroy != 1;
				uslovie_text[2] = " 尚 未 挑 起 军 事 政 变";
				uslovie_bool[3] = a.data[8] + a.data[9] >= 30;
				uslovie_text[3] = " 至 少 3 特 工 网 络 和 3 百 万 预 算";
				return;
			}
			if (this_type == 38)
			{
				this_opis = " 支 持 纳 赛 尔 主 义 者";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[6] > 690;
				uslovie_text[0] = " 外 交 声 誉 高 于 69";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = " 至 少 5 百 万 预 算";
				uslovie_bool[2] = !a.event_done[37];
				uslovie_text[2] = " 趁 我 们 还 来 得 及";
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
				uslovie_text[3] = " 尚 未 提 供 支 持";
				return;
			}
			if (this_type == 39)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].Torg;
				uslovie_text[0] = " 已 深 化 经 贸 关 系";
				uslovie_bool[1] = a.OAR;
				uslovie_text[1] = " 阿 拉 伯 联 合 共 和 国 已 经 成 立";
				uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
				uslovie_text[3] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				return;
			}
			if (this_type == 40)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[0] = " 巴 基 斯 坦 未 持 亲 美 立 场";
				uslovie_bool[1] = !a.allcountries[19].Torg || a.allcountries[selected_country].proprc;
				uslovie_text[1] = " 中 印 关 系 尚 未 正 常 化 或 布 托 是 总 理";
				uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].isASEAN;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
				uslovie_text[3] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				return;
			}
			if (this_type == 41)
			{
				this_opis = " 邀 请 该 国 参 与 我 国 军 事 联 盟 ， 实 现 合 作 无 上 限 ， 保 障 地 区 安 全 稳 定";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[22] >= 20;
				uslovie_text[0] = " 至 少 2 军 事 实 力";
				uslovie_bool[1] = (a.allcountries[selected_country].econ || a.allcountries[selected_country].isSEV) && (a.allcountries[1].okb || a.allcountries[1].isOVD);
				uslovie_text[1] = " 巴 基 斯 坦 持 亲 中 立 场| 中 国 已 成 立 集 安 组 织 或 已 加 入 华 约";
				uslovie_bool[2] = !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD && !a.allcountries[selected_country].isSEATO && !a.allcountries[selected_country].isSENTO;
				uslovie_text[2] = " 巴 基 斯 坦 尚 未 参 与 军 事 联 盟";
				uslovie_bool[3] = a.allcountries[selected_country].econ || a.allcountries[selected_country].isSEV;
				uslovie_text[3] = " 巴 基 斯 坦 已 加 入 经 合 组 织";
				return;
			}
			if (this_type == 42)
			{
				this_opis = " 打 入 缅 甸 社 会 主 义 纲 领 党 政 府 并 支 持 体 制 内 反 对 派";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 80;
				uslovie_text[0] = " 至 少 3 百 万 预 算";
				uslovie_bool[1] = a.data[9] >= 30;
				uslovie_text[1] = " 至 少 3 特 工 网 络";
				uslovie_bool[2] = a.allcountries[selected_country].stab == 0;
				uslovie_text[2] = " 尚 未 援 助";
				return;
			}
			if (this_type == 43)
			{
				this_opis = " 支 持 泰 国 共 产 党";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 40;
				uslovie_text[0] = " 至 少 4 特 工 网 络";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 20;
				uslovie_text[1] = " 至 少 2 百 万 预 算";
				uslovie_bool[2] = !a.TaiCoup;
				uslovie_text[2] = " 泰 国 尚 未 发 生 政 变";
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
				uslovie_text[3] = " 尚 未 提 供 支 持";
				return;
			}
			if (this_type == 44)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 4;
				if (selected_country == 52)
				{
					uslovie_bool[0] = a.allcountries[selected_country].spec > 0;
					uslovie_text[0] = GlobalScript.inst.other_text[474];
				}
				else
				{
					uslovie_bool[0] = a.allcountries[selected_country].Gosstroy == 1;
					uslovie_text[0] = " 共 产 党 获 胜";
				}
				uslovie_bool[1] = a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 已 深 化 经 贸 关 系";
				uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
				uslovie_text[3] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				return;
			}
			if (this_type == 45)
			{
				this_opis = " 促 成 该 国 加 入 阿 拉 伯 联 合 共 和 国 ，实 现 阿 拉 伯 世 界 的 政 治 统 一";
				number_uslovie = 4;
				uslovie_bool[0] = a.OAR;
				uslovie_text[0] = " 阿 拉 伯 联 合 共 和 国 已 经 成 立";
				if (a.allcountries[30].Gosstroy == 1)
				{
					uslovie_bool[1] = !a.allcountries[selected_country].oar;
					uslovie_text[1] = " 该 国 未 加 入 阿 拉 伯 联 合 共 和 国";
				}
				else
				{
					uslovie_bool[1] = !a.allcountries[selected_country].oar && !a.allcountries[selected_country].isNATO && !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD;
					uslovie_text[1] = " 该 国 未 加 入 阿 拉 伯 联 合 共 和 国\n 且 未 参 与 军 事 联 盟";
				}
				uslovie_bool[2] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[2] = GlobalScript.inst.other_text[91];
				if (a.allcountries[30].Gosstroy == 1)
				{
					uslovie_bool[3] = a.IsSocialism(yes: true, selected_country);
					uslovie_text[3] = " 该 国 为 社 会 主 义";
				}
				else
				{
					uslovie_bool[3] = a.allcountries[selected_country].Gosstroy == 2 || a.allcountries[selected_country].SubGosstroy == 10;
					uslovie_text[3] = " 该 国 为 改 良 主 义 或 左 翼 民 族 主 义";
				}
				return;
			}
			if (this_type == 46)
			{
				this_opis = " 为 解 决 巴 勒 斯 坦 问 题 组 织 双 方 调 解";
				number_uslovie = 2;
				uslovie_bool[0] = a.Israellost;
				uslovie_text[0] = " 以 色 列 输 掉 了 黎 巴 嫩 战 争";
				uslovie_bool[1] = a.allcountries[selected_country].dev == 0;
				uslovie_text[1] = " 尚 未 组 织 调 解";
				return;
			}
			if (this_type == 47)
			{
				this_opis = " 为 双 边 关 系 正 常 化 搭 建 磋 商 平 台";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[6] < 550;
				uslovie_text[0] = " 外 交 声 誉 低 于 55";
				uslovie_bool[1] = a.allcountries[51].Torg;
				uslovie_text[1] = "已 与 美 国 签 署 友 好 合 作 协 定";
				uslovie_bool[2] = !a.allcountries[selected_country].Torg;
				uslovie_text[2] = " 尚 未 进 行 磋 商";
				return;
			}
			if (this_type == 48)
			{
				this_opis = " 发 动 战 略 进 攻 ， 解 放 台 海 岛 屿";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[22] >= 500;
				uslovie_text[0] = " 至 少 50 军 事 实 力";
				uslovie_bool[1] = !a.allcountries[51].Torg;
				uslovie_text[1] = " 尚 未 关 系 正 常 化";
				uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
				uslovie_text[2] = " 尚 未 发 动 进 攻";
				return;
			}
			if (this_type == 49)
			{
				if (selected_country == 39)
				{
					if (a.allcountries[39].Gosstroy != 1)
					{
						this_opis = " 将 钱 汇 入 中 国 共 产 党 的 海 外 秘 密 账 户";
					}
					else
					{
						this_opis = " 将 钱 汇 入 瑞 士 农 村 信 用 合 作 社";
					}
					number_uslovie = 2;
					if (!a.allcountries[selected_country].proprc)
					{
						uslovie_bool[0] = a.data[8] + a.data[36] >= 100;
						uslovie_text[0] = " 至 少 10 百 万 预 算";
					}
					else
					{
						uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
						uslovie_text[0] = " 至 少 5 百 万 预 算";
					}
					uslovie_bool[1] = a.allcountries[39].dev == 0;
					uslovie_text[1] = " 每 月 限 一 次";
				}
				if (selected_country == 138)
				{
					this_opis = " 从 古 巴 进 口 高 档 雪 茄";
					number_uslovie = 3;
					if (!a.allcountries[selected_country].proprc)
					{
						uslovie_bool[0] = a.data[8] + a.data[36] >= 100;
						uslovie_text[0] = " 至 少 10 百 万 预 算";
					}
					else
					{
						uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
						uslovie_text[0] = " 至 少 5 百 万 预 算";
					}
					uslovie_bool[1] = a.allcountries[138].dev == 0;
					uslovie_text[1] = " 每 月 限 一 次";
					uslovie_bool[2] = a.allcountries[138].Torg;
					uslovie_text[2] = " 与 古 巴 有 贸 易";
				}
				if (selected_country == 154)
				{
					this_opis = "  夏 日 ， 阳 光 ， 度 假 ！|为 我 国 的 先 进 份 子 提 供 疗 养 地 ， 在 风 景 如 画 的 小 岛 上 享 受 人 生 ";
					number_uslovie = 3;
					if (!a.allcountries[selected_country].proprc)
					{
						uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
						uslovie_text[0] = " 至 少 5 百 万 预 算";
					}
					else
					{
						uslovie_bool[0] = a.data[8] + a.data[36] >= 20;
						uslovie_text[0] = " 至 少 2 百 万 预 算";
					}
					uslovie_bool[1] = a.data[1] < 1000;
					uslovie_text[1] = " 党 支 持 度 低 于 1 0 0 ";
					uslovie_bool[2] = a.allcountries[154].puppetOf < 0;
					uslovie_text[2] = " 卡 纳 克 已 独 立";
				}
				if (selected_country == 152)
				{
					this_opis = " 邀 请 乐 队 访 华";
					number_uslovie = 2;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 30;
					uslovie_text[0] = " 至 少 3 百 万 预 算";
					uslovie_bool[1] = !a.allcountries[152].cw;
					uslovie_text[1] = " 未 邀 请 过";
				}
				return;
			}
			if (this_type == 51)
			{
				if (GlobalScript.inst.gameState.event_done[532] && GlobalScript.inst.gameState.resultOfEvents[532] == 0)
				{
					this_opis = $" 支 援 日 本 革 命 共 产 党 。{'\n'}影 响 力： {a.allcountries[selected_country].prcpower}";
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 80;
					uslovie_text[0] = " 至 少 8 特 工 网 络";
					uslovie_bool[1] = a.data[22] >= 80;
					uslovie_text[1] = " 至 少 8 点 军 事 力 量";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 80;
					uslovie_text[2] = " 至 少 8 点 预 算";
					uslovie_bool[3] = a.data[6] >= 690;
					uslovie_text[3] = " 外 交 声 誉 高 于 69";
				}
				else
				{
					this_opis = $" 支 持 日 本 共 产 主 义 抵 抗 者 同 盟。{'\n'}影 响 力： {a.allcountries[selected_country].prcpower}";
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 50;
					uslovie_text[0] = " 至 少 5 特 工 网 络";
					uslovie_bool[1] = a.data[22] >= 50;
					uslovie_text[1] = " 至 少 5 点 军 事 力 量";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 50;
					uslovie_text[2] = " 至 少 5 点 预 算";
					uslovie_bool[3] = a.data[6] >= 690;
					uslovie_text[3] = " 外 交 声 誉 高 于 69";
				}
				return;
			}
			if (this_type == 52)
			{
				this_opis = " 深 化 经 贸 关 系";
				number_uslovie = 3;
				if (a.allcountries[selected_country].Gosstroy == 1)
				{
					uslovie_bool[0] = a.data[6] >= 800;
					uslovie_text[0] = " 外 交 声 誉 不 低 于 80";
				}
				else if (a.allcountries[selected_country].Gosstroy <= 2)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
				}
				else if (a.allcountries[selected_country].Gosstroy == 3)
				{
					uslovie_bool[0] = a.data[6] < 500;
					uslovie_text[0] = " 外 交 声 誉 低 于 50";
				}
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
				uslovie_bool[2] = a.data[12] >= 800;
				uslovie_text[2] = " 工 业 不 低 于 80";
				if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[7].isNATO;
					uslovie_text[3] = GlobalScript.inst.other_text[105];
				}
				return;
			}
			if (this_type == 53)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 3;
				if (selected_country != 94 && selected_country != 95 && selected_country != 84 && selected_country != 14 && selected_country != 35)
				{
					uslovie_bool[0] = a.allcountries[selected_country].Torg && a.allcountries[selected_country].proprc;
					uslovie_text[0] = " 已 深 化 经 贸 关 系| 且 由 持 亲 中 立 场 的 政 府 执 政";
				}
				else
				{
					uslovie_bool[0] = a.allcountries[selected_country].Torg;
					uslovie_text[0] = " 已 深 化 经 贸 关 系";
				}
				if (selected_country == 26 || selected_country == 27 || selected_country == 39 || selected_country == 88 || selected_country == 0 || selected_country == 29 || selected_country == 89 || selected_country == 90 || selected_country == 91 || selected_country == 28)
				{
					uslovie_bool[0] = a.allcountries[selected_country].cw;
					uslovie_text[0] = " 已 对 某 一 派 系 施 以 援 手";
				}
				uslovie_bool[1] = a.allcountries[1].econ || a.allcountries[1].isSEV;
				uslovie_text[1] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				if (selected_country == 94)
				{
					number_uslovie = 4;
					uslovie_bool[3] = a.data[127] == 100 && a.resultOfEvents[374] == 0;
					uslovie_text[3] = GlobalScript.inst.other_text[118];
				}
				if (selected_country == 14 || selected_country == 35)
				{
					if (a.IsSocialism(yes: true, selected_country))
					{
						number_uslovie = 4;
						uslovie_bool[3] = a.IsSocialism(yes: true, selected_country) || a.allcountries[selected_country].proprc;
						uslovie_text[3] = GlobalScript.inst.other_text[313];
					}
					else
					{
						number_uslovie = 4;
						uslovie_bool[3] = a.allcountries[selected_country].proprc;
						uslovie_text[3] = "该 国 持 亲 中 立 场";
					}
				}
				if (a.allcountries[selected_country].Vyshi)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
					uslovie_text[3] = " 该 国 不 受 美 国 的 影 响";
				}
				return;
			}
			if (this_type == 54)
			{
				this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[selected_country].Gosstroy == 2;
				uslovie_text[0] = " 左 翼 阵 线 掌 权";
				uslovie_bool[1] = a.allcountries[1].econ || a.allcountries[1].isSEV;
				uslovie_text[1] = " 中 国 已 成 立 经 合 组 织 或 已 加 入 经 互 会";
				uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
				uslovie_text[2] = " 该 国 未 加 入 经 合 组 织";
				if (a.allcountries[selected_country].Vyshi)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
					uslovie_text[3] = " 该 国 不 受 美 国 的 影 响";
				}
				return;
			}
			if (this_type == 55)
			{
				this_opis = " 同 时 施 加 政 治 和 经 济 压 力";
				number_uslovie = 4;
				uslovie_bool[0] = (a.allcountries[11].econ && a.allcountries[34].econ && a.allcountries[47].econ) || (a.allcountries[11].isSEV && a.allcountries[34].isSEV && a.allcountries[47].isSEV) || (a.allcountries[11].isASEAN && a.allcountries[34].isASEAN && a.allcountries[47].isASEAN);
				uslovie_text[0] = " 越 南 ， 泰 国 ， 菲 律 宾| 与 我 们 在 同 一 经 济 联 盟 中";
				uslovie_bool[1] = a.data[9] >= 40;
				uslovie_text[1] = " 至 少 4 特 工 网 络";
				uslovie_bool[2] = a.SKRebel && a.resultOfEvents[474] == 0;
				uslovie_text[2] = " 支 持 釜 山 起 义 和 光 州 起 义";
				if (a.allcountries[46].Gosstroy == 1)
				{
					uslovie_bool[3] = a.allcountries[46].Gosstroy != 1;
					uslovie_text[3] = " 左 翼 分 子 尚 未 在 韩 国 掌 权";
				}
				else if (a.ingamewars[0].is_going)
				{
					uslovie_bool[3] = !a.ingamewars[0].is_going;
					uslovie_text[3] = " 该 国 当 前 没 有 战 争";
				}
				else
				{
					uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
					uslovie_text[3] = " 尚 未 进 行 施 压";
				}
				return;
			}
			if (this_type == 56)
			{
				if (selected_country == 47)
				{
					this_opis = " 支 持 毛 派 游 击 武 装| 毛 主 义 者 力 量 ：" + a.data[37] / 10 + "." + Mathf.Abs(a.data[37] % 10);
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 40;
					uslovie_text[0] = " 至 少 4 特 工 网 络";
					uslovie_bool[1] = a.data[22] >= 30;
					uslovie_text[1] = " 至 少 3 军 事 实 力";
					uslovie_bool[2] = a.data[6] >= 750;
					uslovie_text[2] = " 外 交 声 誉 高 于 75";
					uslovie_bool[3] = a.allcountries[selected_country].stab == 0 && a.data[37] < 1000;
					uslovie_text[3] = " 本 年 尚 未 支 持";
				}
				else if (selected_country == 14)
				{
					this_opis = " 支 持 伊 拉 克 武 装 反 对 派| 反 对 派 力 量 ：" + a.allcountries[14].prcpower;
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 40;
					uslovie_text[0] = " 至 少 4 特 工 网 络";
					uslovie_bool[1] = a.data[22] >= 30;
					uslovie_text[1] = " 至 少 3 军 事 实 力";
					uslovie_bool[2] = a.data[6] >= 750;
					uslovie_text[2] = " 外 交 声 誉 高 于 75";
					uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
					uslovie_text[3] = " 半 年 一 次";
				}
				return;
			}
			if (this_type == 57)
			{
				if (!a.allcountries[selected_country].cw)
				{
					this_opis = " 支 持 抗 议 种 族 隔 离 的 民 众 示 威 运 动";
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 特 工 网 络";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 100;
					uslovie_text[1] = " 至 少 10 百 万 预 算";
					uslovie_bool[2] = a.data[21] >= 1980;
					uslovie_text[2] = " 不 早 于 1980 年";
					uslovie_bool[3] = !a.allcountries[selected_country].cw;
					uslovie_text[3] = " 尚 未 推 波 助 澜";
				}
				else
				{
					this_opis = " 继 续 支 持 西 南 非 洲 民 族 联 盟 争 取 纳 米 比 亚 民 族 独 立 的 斗 争";
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 50;
					uslovie_text[0] = " 至 少 5 特 工 网 络 与 5 百 万 预 算";
					uslovie_bool[1] = a.modifies[6].active;
					uslovie_text[1] = " 我 们 仍 坚 持 毛 泽 东 思 想";
					uslovie_bool[2] = !a.allcountries[123].Vyshi && a.allcountries[123].puppetOf < 0;
					uslovie_text[2] = " 安 哥 拉 没 有 亲 美 立 场 且 不 是 南 非 傀 儡";
					uslovie_bool[3] = !a.allcountries[153].cw;
					uslovie_text[3] = " 尚 未 支 持";
				}
				return;
			}
			if (this_type == 58)
			{
				this_opis = " 对 该 国 右 翼 独 裁 政 权 实 施 制 裁";
				number_uslovie = 3;
				if (selected_country == 52)
				{
					uslovie_bool[0] = (a.allcountries[47].econ && a.allcountries[50].econ && a.allcountries[49].econ) || (a.allcountries[47].isSEV && a.allcountries[50].isSEV && a.allcountries[49].isSEV) || (a.allcountries[47].isASEAN && a.allcountries[50].isASEAN && a.allcountries[49].isASEAN);
					uslovie_text[0] = " 印 度 尼 西 亚 ， 菲 律 宾 ， 马 来 西 亚| 在 同 一 经 合 组 织 中";
				}
				else
				{
					uslovie_bool[0] = (a.allcountries[11].econ && a.allcountries[34].econ && a.allcountries[49].econ && a.allcountries[47].econ) || (a.allcountries[11].isSEV && a.allcountries[34].isSEV && a.allcountries[49].isSEV && a.allcountries[47].isSEV) || (a.allcountries[11].isASEAN && a.allcountries[34].isASEAN && a.allcountries[49].isASEAN && a.allcountries[47].isASEAN);
					uslovie_text[0] = " 越 南 ， 泰 国 ， 马 来 西 亚 ， 菲 律 宾| 在 同 一 经 合 组 织 中";
				}
				if (selected_country == 52)
				{
					uslovie_bool[1] = a.data[8] + a.data[36] >= 80;
					uslovie_text[1] = " 至 少 8 百 万 预 算";
				}
				else
				{
					uslovie_bool[1] = a.data[8] + a.data[36] >= 40;
					uslovie_text[1] = " 至 少 4 百 万 预 算";
				}
				uslovie_bool[2] = a.allcountries[selected_country].stab == 0;
				uslovie_text[2] = " 尚 未 进 行 施 压";
				if (selected_country == 52)
				{
					number_uslovie = 4;
					uslovie_bool[3] = a.influencePRC >= 700 && ((a.allcountries[1].isSEV && !a.allcountries[52].isSEV) || (a.allcountries[1].econ && !a.allcountries[52].econ) || (a.allcountries[1].isASEAN && !a.allcountries[52].isASEAN));
					uslovie_text[3] = GlobalScript.inst.other_text[467];
				}
				return;
			}
			if (this_type == 60)
			{
				this_opis = " 签 署 一 份 友 好 合 作 协 定";
				number_uslovie = 3;
				uslovie_bool[0] = a.empires[0].relations > 700;
				uslovie_text[0] = " 中 美 关 系 至 少 为 70";
				uslovie_bool[1] = a.data[6] < 500;
				uslovie_text[1] = " 外 交 声 誉 低 于 50";
				uslovie_bool[2] = !a.allcountries[selected_country].Torg;
				uslovie_text[2] = " 尚 未 签 署 协 定";
				return;
			}
			if (this_type == 61)
			{
				this_opis = " 同 美 国 中 央 情 报 局 （ CIA ） 开 展 合 作";
				number_uslovie = 3;
				uslovie_bool[0] = a.empires[0].relations > 800;
				uslovie_text[0] = " 中 美 关 系 至 少 为 80";
				uslovie_bool[1] = a.data[6] < 600;
				uslovie_text[1] = " 外 交 声 誉 低 于 60";
				uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
				uslovie_text[2] = " 尚 未 开 展 合 作";
				return;
			}
			if (this_type == 62)
			{
				number_uslovie = 4;
				if (a.allcountries[selected_country].proprc)
				{
					this_opis = " 帮 助 我 们 的 朋 友";
					uslovie_bool[2] = a.allcountries[selected_country].stab < 1000;
					uslovie_text[2] = " 政 权 稳 定 度 低 于 100";
					this_opis = this_opis + "| 稳 定 度 ：" + a.allcountries[selected_country].stab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].stab % 10);
					uslovie_bool[0] = a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 特 工 网 络";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 40;
					uslovie_text[1] = " 至 少 4 百 万 预 算";
					uslovie_bool[3] = a.data[22] >= 80;
					uslovie_text[3] = " 至 少 8 军 事 实 力";
				}
				else
				{
					this_opis = " 在 当 地 扶 持 亲 中 势 力";
					uslovie_bool[2] = a.allcountries[selected_country].prcpower < 1000;
					uslovie_text[2] = " 亲 中 势 力 规 模 低 于 100";
					this_opis = this_opis + "| 亲 中 势 力 规 模 ：" + a.allcountries[selected_country].prcpower / 10 + "." + Mathf.Abs(a.allcountries[selected_country].prcpower % 10);
					uslovie_bool[0] = a.data[9] >= 80;
					uslovie_text[0] = " 至 少 8 特 工 网 络";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 40;
					uslovie_text[1] = " 至 少 4 百 万 预 算";
					uslovie_bool[3] = a.data[22] >= 100;
					uslovie_text[3] = " 至 少 10 军 事 实 力";
				}
				return;
			}
			if (this_type == 63)
			{
				this_opis = " 同 亲 苏 势 力 进 行 联 合 ， 共 同 反 美";
				this_opis = this_opis + "| 亲 苏 势 力 规 模 ：" + a.allcountries[selected_country].sovpower / 10 + "." + Mathf.Abs(a.allcountries[selected_country].sovpower % 10);
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 20;
				uslovie_text[0] = " 至 少 2 特 工 网 络";
				uslovie_bool[1] = a.data[6] > 690;
				uslovie_text[1] = " 外 交 声 誉 高 于 69";
				uslovie_bool[2] = !a.allcountries[selected_country].usalliance && !a.allcountries[selected_country].sovalliance;
				uslovie_text[2] = " 尚 未 进 行 联 合";
				uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].proprc;
				uslovie_text[3] = " 该 国 未 持 亲 苏 或 亲 中 立 场";
				return;
			}
			if (this_type == 64)
			{
				this_opis = " 同 亲 美 势 力 进 行 联 合 ， 共 同 反 苏";
				this_opis = this_opis + "| 亲 美 势 力 规 模 ：" + a.allcountries[selected_country].usapower / 10 + "." + Mathf.Abs(a.allcountries[selected_country].usapower % 10);
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 20;
				uslovie_text[0] = " 至 少 2 特 工 网 络";
				uslovie_bool[1] = a.data[6] < 500;
				uslovie_text[1] = " 外 交 声 誉 低 于 50";
				uslovie_bool[2] = !a.allcountries[selected_country].usalliance && !a.allcountries[selected_country].sovalliance;
				uslovie_text[2] = " 尚 未 进 行 联 合";
				uslovie_bool[3] = !a.allcountries[selected_country].Vyshi && !a.allcountries[selected_country].proprc;
				uslovie_text[3] = " 该 国 未 持 亲 美 或 亲 中 立 场";
				return;
			}
			if (this_type == 65)
			{
				this_opis = " 给 乱 局 火 上 浇 油 ， 颠 覆 现 政 府";
				number_uslovie = 2;
				uslovie_bool[0] = a.allcountries[selected_country].prcpower > 300 || a.allcountries[selected_country].stab > 300;
				uslovie_text[0] = " 亲 中 势 力 规 模 超 过 30";
				uslovie_bool[1] = !a.allcountries[selected_country].proprc || a.allcountries[selected_country].prosov || a.allcountries[selected_country].Vyshi;
				uslovie_text[1] = " 该 国 未 持 亲 中 立 场";
				return;
			}
			if (this_type == 66)
			{
				if (!a.allcountries[selected_country].Torg)
				{
					this_opis = "要 求 在 该 国 圈 地 ， 建 立 独 占 资 源 开 发 区";
				}
				else
				{
					this_opis = "关 闭 我 们 位 于 该 国 的 独 占 资 源 开 发 区";
				}
				this_opis = this_opis + "| 稳 定 度 ：" + a.allcountries[selected_country].stab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].stab % 10);
				number_uslovie = 1;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = " 该 国 持 亲 中 立 场";
				return;
			}
			if (this_type == 70)
			{
				if (selected_country == 41)
				{
					this_opis = " 稍 稍 帮 助 马 里 亚 姆 完 成 自 己 的 伟 大 理 想";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 百 万 预 算 与 10 特 勤";
					uslovie_bool[1] = a.allcountries[1].SubGosstroy == 19;
					uslovie_text[1] = " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论";
					uslovie_bool[2] = !a.event_done[590];
					uslovie_text[2] = " 埃 塞 俄 比 亚 尚 未 被 邀 请 去 参 加 “ 世 界 野 餐 ”";
				}
				if (selected_country == 65)
				{
					this_opis = " 邀 请 博 卡 萨 同 志 来 精 进 革 命 理 论 ";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 百 万 预 算 与 10 特 勤";
					uslovie_bool[1] = a.allcountries[1].SubGosstroy == 19;
					uslovie_text[1] = " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论";
					uslovie_bool[2] = !a.event_done[644];
					uslovie_text[2] = " 尚 未 对 中 非 传 授 经 验";
				}
				if (selected_country == 117)
				{
					this_opis = " 为 扎 伊 尔 共 和 国 送 上 我 们 的 百 亿 补 贴 ， 给 他 们 带 来 真 正 的 社 会 主 义";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 百 万 预 算 与 10 特 勤";
					uslovie_bool[1] = a.allcountries[1].SubGosstroy == 19;
					uslovie_text[1] = " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论";
					uslovie_bool[2] = a.allcountries[117].SubGosstroy != 19;
					uslovie_text[2] = " 尚 未 教 授 他 们 方 法";
				}
				if (selected_country == 127)
				{
					this_opis = " 让 我 们 教 教 津 巴 布 韦 的 同 志 们 怎 么 建 设 社 会 主 义";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 百 万 预 算 与 10 特 勤";
					uslovie_bool[1] = a.allcountries[1].SubGosstroy == 19;
					uslovie_text[1] = " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论";
					uslovie_bool[2] = !a.event_done[883];
					uslovie_text[2] = " 尚 未 教 授 他 们 方 法";
				}
				if (selected_country == 115)
				{
					this_opis = " 让 我 们 为 赤 道 几 内 亚 的 同 志 们 引 入 真 正 的 社 会 主 义";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 百 万 预 算 与 10 特 勤";
					uslovie_bool[1] = a.allcountries[1].SubGosstroy == 19;
					uslovie_text[1] = " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论";
					uslovie_bool[2] = !a.event_done[622];
					uslovie_text[2] = " 尚 未 教 授 他 们 方 法";
				}
				if (selected_country == 2 || selected_country == 3 || selected_country == 6)
				{
					this_opis = " 向 东 欧 国 家 施 压 ， 换 取 “ 改 革 ”";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[0] = " 至 少 10 百 万 预 算 与 10 特 勤";
					uslovie_bool[1] = a.allcountries[1].SubGosstroy == 19;
					uslovie_text[1] = " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论";
					uslovie_bool[2] = a.allcountries[selected_country].SubGosstroy != 19;
					uslovie_text[2] = " 他 们 尚 未 “ 改 革 ”";
				}
			}
			if (this_type == 82)
			{
				this_opis = GlobalScript.inst.other_text[29];
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[selected_country].level_of_unstab - a.allcountries[selected_country].level_of_dev > 0;
				uslovie_text[0] = GlobalScript.inst.other_text[33];
				uslovie_bool[1] = !a.allcountries[selected_country].proprc;
				uslovie_text[1] = GlobalScript.inst.other_text[34];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
				uslovie_text[2] = GlobalScript.inst.other_text[35];
				return;
			}
			if (this_type == 83)
			{
				this_opis = GlobalScript.inst.other_text[30];
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = GlobalScript.inst.other_text[39];
				uslovie_bool[1] = a.allcountries[selected_country].Gosstroy == 2;
				uslovie_text[1] = GlobalScript.inst.other_text[40];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
				uslovie_text[2] = GlobalScript.inst.other_text[35];
				return;
			}
			if (this_type == 84)
			{
				this_opis = GlobalScript.inst.other_text[31];
				number_uslovie = 3;
				uslovie_bool[0] = a.science[19];
				uslovie_text[0] = GlobalScript.inst.other_text[42];
				uslovie_bool[1] = !a.allcountries[selected_country].proprc;
				uslovie_text[1] = GlobalScript.inst.other_text[34];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 20 && a.data[9] >= 20 && a.data[22] >= 20;
				uslovie_text[2] = GlobalScript.inst.other_text[53];
				return;
			}
			if (this_type == 85)
			{
				this_opis = GlobalScript.inst.other_text[32];
				number_uslovie = 3;
				uslovie_bool[0] = a.science[20];
				uslovie_text[0] = GlobalScript.inst.other_text[43];
				uslovie_bool[1] = !a.allcountries[selected_country].proprc;
				uslovie_text[1] = GlobalScript.inst.other_text[34];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 20 && a.data[9] >= 20 && a.data[22] >= 20;
				uslovie_text[2] = GlobalScript.inst.other_text[53];
				return;
			}
			if (this_type == 86)
			{
				this_opis = GlobalScript.inst.other_text[47];
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = GlobalScript.inst.other_text[39];
				uslovie_bool[1] = a.allcountries[selected_country].Torg;
				uslovie_text[1] = GlobalScript.inst.other_text[46];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 35 && a.data[9] >= 35 && a.data[22] >= 35;
				uslovie_text[2] = GlobalScript.inst.other_text[41];
				return;
			}
			if (this_type == 87)
			{
				this_opis = GlobalScript.inst.other_text[48];
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = GlobalScript.inst.other_text[39];
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = GlobalScript.inst.other_text[44];
				uslovie_bool[2] = a.data[12] >= 500 && a.data[13] >= 500;
				uslovie_text[2] = GlobalScript.inst.other_text[45];
				return;
			}
			if (this_type == 88)
			{
				this_opis = GlobalScript.inst.other_text[49];
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = GlobalScript.inst.other_text[39];
				uslovie_bool[1] = a.allcountries[selected_country].Torg;
				uslovie_text[1] = GlobalScript.inst.other_text[46];
				uslovie_bool[2] = a.influencePRC >= 150 && a.allcountries[selected_country].level_of_dev - a.allcountries[selected_country].level_of_unstab >= 30;
				uslovie_text[2] = GlobalScript.inst.other_text[50];
				uslovie_bool[3] = (a.allcountries[1].econ || a.allcountries[1].isSEV) && !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
				uslovie_text[3] = ((a.allcountries[1].econ || a.allcountries[1].isSEV) ? GlobalScript.inst.other_text[51] : GlobalScript.inst.other_text[52]);
				return;
			}
			if (this_type == 91)
			{
				this_opis = GlobalScript.inst.other_text[58];
				number_uslovie = 4;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
				uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 5);
				uslovie_bool[1] = a.data[9] >= 30;
				uslovie_text[1] = string.Format(GlobalScript.inst.other_text[61], 3);
				if (!a.event_done[366])
				{
					uslovie_bool[2] = (a.data[20] > 4 && a.data[21] >= 1977) || a.data[21] > 1977;
					uslovie_text[2] = GlobalScript.inst.other_text[62];
				}
				else
				{
					uslovie_bool[2] = !a.event_done[367];
					uslovie_text[2] = GlobalScript.inst.other_text[63];
				}
				if (!a.event_done[366])
				{
					uslovie_bool[3] = !a.event_done[366];
					uslovie_text[3] = GlobalScript.inst.other_text[64];
				}
				else
				{
					uslovie_bool[3] = a.resultOfEvents[366] != 0 && a.resultOfEvents[366] != 1;
					uslovie_text[3] = GlobalScript.inst.other_text[64];
				}
				return;
			}
			if (this_type == 92)
			{
				this_opis = GlobalScript.inst.other_text[59];
				number_uslovie = 4;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
				uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 5);
				uslovie_bool[1] = a.data[9] >= 30;
				uslovie_text[1] = string.Format(GlobalScript.inst.other_text[61], 3);
				if (!a.event_done[366])
				{
					uslovie_bool[2] = (a.data[20] > 4 && a.data[21] >= 1977) || a.data[21] > 1977;
					uslovie_text[2] = GlobalScript.inst.other_text[62];
				}
				else
				{
					uslovie_bool[2] = !a.event_done[367];
					uslovie_text[2] = GlobalScript.inst.other_text[63];
				}
				if (!a.event_done[366])
				{
					uslovie_bool[3] = !a.event_done[366];
					uslovie_text[3] = GlobalScript.inst.other_text[64];
				}
				else
				{
					uslovie_bool[3] = a.resultOfEvents[366] != 0 && a.resultOfEvents[366] != 1;
					uslovie_text[3] = GlobalScript.inst.other_text[64];
				}
				return;
			}
			if (this_type == 93)
			{
				this_opis = " 深 化 经 贸 关 系";
				number_uslovie = 4;
				if (a.allcountries[selected_country].Gosstroy == 1)
				{
					uslovie_bool[0] = a.data[6] >= 800;
					uslovie_text[0] = " 外 交 声 誉 不 低 于 80";
				}
				else if (a.allcountries[selected_country].Gosstroy <= 2)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
					uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
				}
				else
				{
					uslovie_bool[0] = a.data[6] < 500;
					uslovie_text[0] = " 外 交 声 誉 低 于 50";
				}
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
				uslovie_bool[2] = a.data[12] >= 500;
				uslovie_text[2] = " 工 业 不 低 于 50";
				uslovie_bool[3] = a.Israellost;
				uslovie_text[3] = " 以 色 列 输 掉 了 黎 巴 嫩 战 争";
				return;
			}
			if (this_type == 94)
			{
				this_opis = GlobalScript.inst.other_text[66];
				number_uslovie = 2;
				uslovie_bool[0] = a.data[124] >= 1;
				uslovie_text[0] = GlobalScript.inst.other_text[67];
				uslovie_bool[1] = a.data[124] != 100;
				uslovie_text[1] = GlobalScript.inst.other_text[68];
				return;
			}
			if (this_type == 95)
			{
				this_opis = GlobalScript.inst.other_text[69];
				number_uslovie = 3;
				uslovie_bool[0] = a.data[127] >= 1 || a.allcountries[84].Gosstroy == 2 || a.allcountries[84].Gosstroy == 1;
				uslovie_text[0] = " 土 耳 其 为 改 良 或 社 会 主 义 或 其 输 掉 了 塞 浦 路 斯 战 争";
				uslovie_bool[1] = a.data[127] != 100;
				uslovie_text[1] = GlobalScript.inst.other_text[68];
				uslovie_bool[2] = a.data[21] >= 1983;
				uslovie_text[2] = GlobalScript.inst.other_text[71];
				uslovie_bool[3] = !a.ingamewars[8].is_going;
				uslovie_text[3] = GlobalScript.inst.other_text[72];
				return;
			}
			if (this_type == 96)
			{
				this_opis = " 深 化 经 贸 关 系";
				number_uslovie = 3;
				number_uslovie = 3;
				uslovie_bool[0] = !a.allcountries[selected_country].Torg;
				uslovie_text[0] = " 尚 未 深 化 经 贸 关 系";
				uslovie_bool[1] = a.data[12] >= 500;
				uslovie_text[1] = " 工 业 不 低 于 50";
				uslovie_bool[2] = !a.ingamewars[8].is_going;
				uslovie_text[2] = GlobalScript.inst.other_text[72];
				return;
			}
			if (this_type == 97)
			{
				this_opis = GlobalScript.inst.other_text[74];
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[19].proprc && ((a.allcountries[19].okb && a.allcountries[19].econ) || (a.allcountries[19].isSEV && a.allcountries[19].isOVD) || a.allcountries[19].isNATO);
				uslovie_text[0] = GlobalScript.inst.other_text[75];
				uslovie_bool[1] = a.influencePRC > 600;
				uslovie_text[1] = GlobalScript.inst.other_text[76];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
				uslovie_text[2] = GlobalScript.inst.other_text[77];
				uslovie_bool[3] = !a.allcountries[selected_country].proprc;
				uslovie_text[3] = GlobalScript.inst.other_text[78];
				return;
			}
			if (this_type == 98)
			{
				this_opis = GlobalScript.inst.other_text[81];
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].Torg;
				uslovie_text[0] = GlobalScript.inst.other_text[83];
				uslovie_bool[1] = a.influencePRC > 700;
				uslovie_text[1] = GlobalScript.inst.other_text[86];
				uslovie_bool[2] = a.allcountries[1].isSEV || a.allcountries[1].econ;
				uslovie_text[2] = GlobalScript.inst.other_text[84];
				uslovie_bool[3] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].isASEAN;
				uslovie_text[3] = GlobalScript.inst.other_text[88];
				return;
			}
			if (this_type == 99)
			{
				this_opis = GlobalScript.inst.other_text[82];
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].isSEV || a.allcountries[selected_country].econ;
				uslovie_text[0] = GlobalScript.inst.other_text[90];
				uslovie_bool[1] = a.influencePRC > 800;
				uslovie_text[1] = GlobalScript.inst.other_text[87];
				uslovie_bool[2] = a.allcountries[1].isSEV || a.allcountries[1].econ || a.allcountries[1].isNATO;
				uslovie_text[2] = GlobalScript.inst.other_text[84];
				uslovie_bool[3] = !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isSEATO && !a.allcountries[selected_country].isOVD;
				uslovie_text[3] = GlobalScript.inst.other_text[89];
				return;
			}
			if (this_type == 100)
			{
				number_uslovie = 3;
				this_opis = GlobalScript.inst.other_text[107];
				uslovie_bool[0] = a.influencePRC >= 700;
				uslovie_text[0] = GlobalScript.inst.other_text[86];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 150 && a.data[9] >= 150;
				uslovie_text[1] = GlobalScript.inst.other_text[108];
				uslovie_bool[2] = a.allcountries[selected_country].dev <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[109];
				if (a.allcountries[7].isNATO)
				{
					number_uslovie = 4;
					uslovie_bool[3] = !a.allcountries[7].isNATO;
					uslovie_text[3] = GlobalScript.inst.other_text[105];
				}
				return;
			}
			if (this_type == 101)
			{
				number_uslovie = 4;
				this_opis = GlobalScript.inst.other_text[81];
				uslovie_bool[0] = a.allcountries[selected_country].based;
				uslovie_text[0] = GlobalScript.inst.other_text[169];
				uslovie_bool[1] = a.allcountries[selected_country].Torg;
				uslovie_text[1] = GlobalScript.inst.other_text[83];
				uslovie_bool[2] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ;
				uslovie_text[2] = GlobalScript.inst.other_text[88];
				uslovie_bool[3] = a.allcountries[1].isSEV || a.allcountries[1].econ;
				uslovie_text[3] = GlobalScript.inst.other_text[84];
				return;
			}
			if (this_type == 102)
			{
				this_opis = " 深 化 经 贸 关 系";
				if (!a.allcountries[selected_country].proprc)
				{
					number_uslovie = 4;
					if (a.allcountries[selected_country].Gosstroy == 1)
					{
						uslovie_bool[0] = a.data[6] >= 690;
						uslovie_text[0] = " 外 交 声 誉 高 于 69";
					}
					else if (a.allcountries[selected_country].Gosstroy <= 2)
					{
						uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
						uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
					}
					else if (a.allcountries[selected_country].Gosstroy == 3)
					{
						uslovie_bool[0] = a.data[6] < 500;
						uslovie_text[0] = " 外 交 声 誉 低 于 50";
					}
					uslovie_bool[1] = !a.allcountries[selected_country].Torg;
					uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
					uslovie_bool[2] = a.data[12] >= 500;
					uslovie_text[2] = " 工 业 不 低 于 50";
					uslovie_bool[3] = a.allcountries[selected_country].parts[0];
					uslovie_text[3] = GlobalScript.inst.other_text[117];
					return;
				}
				if (a.allcountries[selected_country].proprc)
				{
					number_uslovie = 3;
					if (a.allcountries[selected_country].Gosstroy == 1)
					{
						uslovie_bool[0] = a.data[6] >= 690;
						uslovie_text[0] = " 外 交 声 誉 高 于 69";
					}
					else if (a.allcountries[selected_country].Gosstroy <= 2)
					{
						uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
						uslovie_text[0] = " 外 交 声 誉 在 39 到 85 之 间";
					}
					else if (a.allcountries[selected_country].Gosstroy == 3)
					{
						uslovie_bool[0] = a.data[6] < 500;
						uslovie_text[0] = " 外 交 声 誉 低 于 50";
					}
					uslovie_bool[1] = !a.allcountries[selected_country].Torg;
					uslovie_text[1] = " 尚 未 深 化 经 贸 关 系";
					uslovie_bool[2] = a.data[12] >= 500;
					uslovie_text[2] = " 工 业 不 低 于 50";
					return;
				}
			}
			if (this_type == 103)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[122], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].inflCh < 1000;
				uslovie_text[0] = GlobalScript.inst.other_text[127];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 100;
				uslovie_text[1] = GlobalScript.inst.other_text[128];
				uslovie_bool[2] = a.data[9] >= 50;
				uslovie_text[2] = GlobalScript.inst.other_text[129];
				uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = GlobalScript.inst.other_text[130];
				return;
			}
			if (this_type == 104)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[126], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].inflCh >= 350;
				uslovie_text[0] = GlobalScript.inst.other_text[125];
				uslovie_bool[1] = !a.allcountries[selected_country].econ;
				uslovie_text[1] = GlobalScript.inst.other_text[88];
				uslovie_bool[2] = a.allcountries[selected_country].Torg;
				uslovie_text[2] = GlobalScript.inst.other_text[83];
				uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = GlobalScript.inst.other_text[130];
				return;
			}
			if (this_type == 105)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[132], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].inflCh >= 600;
				uslovie_text[0] = GlobalScript.inst.other_text[133];
				uslovie_bool[1] = !a.allcountries[selected_country].based && a.allcountries[selected_country].econ;
				uslovie_text[1] = GlobalScript.inst.other_text[134];
				uslovie_bool[2] = a.data[22] >= 250;
				uslovie_text[2] = GlobalScript.inst.other_text[135];
				uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = GlobalScript.inst.other_text[130];
				return;
			}
			if (this_type == 106)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[136], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].inflCh >= 900;
				uslovie_text[0] = GlobalScript.inst.other_text[138];
				uslovie_bool[1] = a.allcountries[selected_country].based && !a.allcountries[selected_country].okb;
				uslovie_text[1] = GlobalScript.inst.other_text[137];
				uslovie_bool[2] = a.data[7] > a.empires[0].power + a.empires[1].power;
				uslovie_text[2] = GlobalScript.inst.other_text[139];
				uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = GlobalScript.inst.other_text[130];
				return;
			}
			if (this_type == 107)
			{
				if (!a.modifies[41].active)
				{
					this_opis = GlobalScript.inst.other_text[141];
					number_uslovie = 4;
					uslovie_bool[0] = a.data[6] < 600 && a.data[21] > 1979;
					uslovie_text[0] = GlobalScript.inst.other_text[142];
					uslovie_bool[1] = a.allcountries[30].Vyshi && (a.allcountries[8].Gosstroy == 3 || a.allcountries[8].Vyshi);
					uslovie_text[1] = GlobalScript.inst.other_text[143];
					uslovie_bool[2] = !a.allcountries[1].isSEV && a.science[19];
					uslovie_text[2] = GlobalScript.inst.other_text[144];
					uslovie_bool[3] = (a.data[131] == 0 || a.data[131] == 3) && !a.modifies[41].active;
					uslovie_text[3] = GlobalScript.inst.other_text[145];
				}
				else
				{
					this_opis = GlobalScript.inst.other_text[146];
					number_uslovie = 1;
					uslovie_bool[0] = a.modifies[41].active;
					uslovie_text[0] = GlobalScript.inst.other_text[147];
				}
				return;
			}
			if (this_type == 108)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[152], '\n', (float)a.data[134] / 10f);
				number_uslovie = 4;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
				uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 5);
				uslovie_bool[1] = a.data[22] >= 50;
				uslovie_text[1] = string.Format(GlobalScript.inst.other_text[156], 5);
				uslovie_bool[2] = a.data[134] < 1000 && a.data[134] >= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[150];
				uslovie_bool[3] = !a.event_done[396];
				uslovie_text[3] = GlobalScript.inst.other_text[303];
				return;
			}
			if (this_type == 109)
			{
				this_opis = GlobalScript.inst.other_text[153];
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 150;
				uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 15);
				uslovie_bool[1] = a.data[22] >= 150;
				uslovie_text[1] = string.Format(GlobalScript.inst.other_text[156], 15);
				uslovie_bool[2] = a.data[134] >= 1000;
				uslovie_text[2] = GlobalScript.inst.other_text[155];
				uslovie_bool[3] = !a.event_done[396] && a.empires[0].power + a.empires[1].power < 350;
				uslovie_text[3] = GlobalScript.inst.other_text[151];
				return;
			}
			if (this_type == 110)
			{
				number_uslovie = 4;
				if (selected_country == 41)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[159], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
				}
				else if (selected_country == 99)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[167], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
				}
				else if (selected_country == 100)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[163], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
				}
				uslovie_bool[0] = a.allcountries[selected_country].inflCh < 1000;
				uslovie_text[0] = GlobalScript.inst.other_text[170];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = GlobalScript.inst.other_text[171];
				uslovie_bool[2] = a.data[22] >= 50;
				uslovie_text[2] = GlobalScript.inst.other_text[172];
				uslovie_bool[3] = !a.allcountries[selected_country].based;
				uslovie_text[3] = GlobalScript.inst.other_text[173];
				return;
			}
			if (this_type == 111)
			{
				number_uslovie = 4;
				if (selected_country == 41)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[160], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
				}
				else if (selected_country == 99)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[168], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
				}
				else if (selected_country == 100)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[164], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
				}
				uslovie_bool[0] = a.allcountries[selected_country].inflNATO < 1000;
				uslovie_text[0] = GlobalScript.inst.other_text[174];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = GlobalScript.inst.other_text[171];
				uslovie_bool[2] = a.data[22] >= 50;
				uslovie_text[2] = GlobalScript.inst.other_text[172];
				uslovie_bool[3] = !a.allcountries[selected_country].based;
				uslovie_text[3] = GlobalScript.inst.other_text[173];
				return;
			}
			if (this_type == 112)
			{
				number_uslovie = 3;
				this_opis = GlobalScript.inst.other_text[82];
				uslovie_bool[0] = a.allcountries[selected_country].isSEV || a.allcountries[selected_country].econ;
				uslovie_text[0] = GlobalScript.inst.other_text[90];
				uslovie_bool[1] = a.allcountries[selected_country].Torg && a.allcountries[selected_country].proprc;
				uslovie_text[1] = GlobalScript.inst.other_text[175];
				uslovie_bool[2] = !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD && (a.allcountries[1].isOVD || a.allcountries[1].okb);
				uslovie_text[2] = GlobalScript.inst.other_text[85];
				return;
			}
			if (this_type == 113)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[177], '\n', a.allcountries[selected_country].inflNATO);
				uslovie_bool[0] = a.data[8] + a.data[36] >= 30 && a.data[9] >= 30;
				uslovie_text[0] = GlobalScript.inst.other_text[178];
				uslovie_bool[1] = !a.modifies[3].active;
				uslovie_text[1] = GlobalScript.inst.other_text[179];
				uslovie_bool[2] = a.allcountries[selected_country].spec <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[180];
				uslovie_bool[3] = a.data[21] < 1981;
				uslovie_text[3] = GlobalScript.inst.other_text[181];
				return;
			}
			if (this_type == 114)
			{
				number_uslovie = 3;
				this_opis = string.Format(GlobalScript.inst.other_text[185], '\n');
				uslovie_bool[0] = a.modifies[48].active;
				uslovie_text[0] = GlobalScript.inst.other_text[187];
				uslovie_bool[1] = a.allcountries[1].inflNATO <= 0;
				uslovie_text[1] = GlobalScript.inst.other_text[180];
				uslovie_bool[2] = a.allcountries[1].dev <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[189];
				return;
			}
			if (this_type == 115)
			{
				number_uslovie = 3;
				this_opis = string.Format(GlobalScript.inst.other_text[186], '\n');
				uslovie_bool[0] = a.modifies[47].active;
				uslovie_text[0] = GlobalScript.inst.other_text[188];
				uslovie_bool[1] = a.allcountries[1].inflCh <= 0;
				uslovie_text[1] = GlobalScript.inst.other_text[180];
				uslovie_bool[2] = a.allcountries[1].dev <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[189];
				return;
			}
			if (this_type == 116)
			{
				number_uslovie = 4;
				this_opis = " 让 我 们 一 劳 永 逸 的 解 决 两 德 之 间 的 问 题";
				uslovie_bool[0] = a.resultOfEvents[484] == 3 || !a.event_done[484];
				uslovie_text[0] = " 两 德 尚 未 统 一";
				uslovie_bool[1] = a.data[21] >= 1985;
				uslovie_text[1] = " 1985 年 后";
				uslovie_bool[2] = a.influencePRC >= 800;
				uslovie_text[2] = " 中 国 影 响 力 大 于 80";
				uslovie_bool[3] = a.allcountries[17].Gosstroy != 0;
				uslovie_text[3] = " 西 德 没 有 处 于 军 事 管 制";
				return;
			}
			if (this_type == 117)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[196], '\n');
				uslovie_bool[0] = a.allcountries[1].Gosstroy != 1 && a.data[52] > 34;
				uslovie_text[0] = GlobalScript.inst.other_text[197];
				uslovie_bool[1] = !a.allcountries[1].isSEV && !a.allcountries[1].econ;
				uslovie_text[1] = GlobalScript.inst.other_text[198];
				uslovie_bool[2] = !a.allcountries[1].isASEAN;
				uslovie_text[2] = GlobalScript.inst.other_text[199];
				uslovie_bool[3] = a.data[21] > 1978;
				uslovie_text[3] = GlobalScript.inst.other_text[200];
				return;
			}
			if (this_type == 118)
			{
				number_uslovie = 3;
				this_opis = string.Format(GlobalScript.inst.other_text[202], '\n');
				uslovie_bool[0] = a.allcountries[1].isASEAN;
				uslovie_text[0] = GlobalScript.inst.other_text[203];
				uslovie_bool[1] = !a.allcountries[15].cw;
				uslovie_text[1] = GlobalScript.inst.other_text[204];
				uslovie_bool[2] = !a.allcountries[1].isSEATO;
				uslovie_text[2] = GlobalScript.inst.other_text[199];
				return;
			}
			if (this_type == 119)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[206], '\n');
				uslovie_bool[0] = a.allcountries[1].isASEAN;
				uslovie_text[0] = GlobalScript.inst.other_text[203];
				uslovie_bool[1] = !a.allcountries[selected_country].prosov;
				uslovie_text[1] = GlobalScript.inst.other_text[207];
				uslovie_bool[2] = !a.allcountries[selected_country].isASEAN && !a.allcountries[selected_country].isSEV;
				uslovie_text[2] = GlobalScript.inst.other_text[208];
				if (selected_country != 38)
				{
					uslovie_bool[3] = a.allcountries[selected_country].Gosstroy != 1;
					uslovie_text[3] = GlobalScript.inst.other_text[209];
				}
				else
				{
					uslovie_bool[3] = a.data[64] == 1 || a.completedDecisions[6];
					uslovie_text[3] = GlobalScript.inst.other_text[233];
				}
				return;
			}
			if (this_type == 120)
			{
				number_uslovie = 3;
				if (!a.allcountries[51].cw)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[210], '\n');
				}
				else
				{
					this_opis = string.Format(GlobalScript.inst.other_text[211], '\n');
				}
				uslovie_bool[0] = a.allcountries[1].isASEAN;
				if (!a.allcountries[51].cw)
				{
					uslovie_text[0] = GlobalScript.inst.other_text[212];
				}
				else
				{
					uslovie_text[0] = GlobalScript.inst.other_text[213];
				}
				uslovie_bool[1] = a.allcountries[selected_country].isASEAN;
				uslovie_text[1] = GlobalScript.inst.other_text[214];
				uslovie_bool[2] = !a.allcountries[selected_country].isSEATO && !a.allcountries[selected_country].isOVD;
				uslovie_text[2] = GlobalScript.inst.other_text[215];
				if (selected_country == 8 || selected_country == 12 || selected_country == 14 || selected_country == 35 || selected_country == 36 || selected_country == 31 || selected_country == 37 || selected_country == 25)
				{
					number_uslovie = 4;
					uslovie_bool[3] = a.allcountries[51].cw;
					uslovie_text[3] = GlobalScript.inst.other_text[216];
				}
				return;
			}
			if (this_type == 121)
			{
				if (selected_country == 24)
				{
					if (!a.allcountries[selected_country].proprc)
					{
						this_opis = GlobalScript.inst.other_text[218];
					}
					else if (a.allcountries[selected_country].proprc)
					{
						this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
					}
				}
				else if (!a.allcountries[selected_country].proprc)
				{
					this_opis = GlobalScript.inst.other_text[206];
				}
				else if (a.allcountries[selected_country].proprc)
				{
					this_opis = " 允 许 该 国 加 入 我 国 经 济 联 盟 ，建 立 全 面 战 略 合 作 伙 伴 关 系";
				}
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].Torg;
				uslovie_text[0] = GlobalScript.inst.other_text[83];
				if (selected_country == 24)
				{
					if (!a.allcountries[selected_country].proprc)
					{
						uslovie_bool[1] = a.allcountries[1].isSEV;
						uslovie_text[1] = GlobalScript.inst.other_text[220];
					}
					else if (a.allcountries[selected_country].proprc)
					{
						uslovie_bool[1] = a.allcountries[1].econ;
						uslovie_text[1] = " 中 国 已 建 立 经 济 联 盟";
					}
				}
				else if (!a.allcountries[selected_country].proprc)
				{
					uslovie_bool[1] = a.allcountries[1].isASEAN;
					uslovie_text[1] = GlobalScript.inst.other_text[203];
				}
				else if (a.allcountries[selected_country].proprc)
				{
					uslovie_bool[1] = a.allcountries[1].econ;
					uslovie_text[1] = " 中 国 已 建 立 经 济 联 盟";
				}
				uslovie_bool[2] = !a.allcountries[selected_country].isASEAN && !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ;
				uslovie_text[2] = GlobalScript.inst.other_text[88];
				uslovie_bool[3] = a.allcountries[selected_country].parts[0];
				uslovie_text[3] = GlobalScript.inst.other_text[219];
				return;
			}
			if (this_type == 122)
			{
				this_opis = GlobalScript.inst.other_text[221];
				number_uslovie = 3;
				uslovie_bool[0] = a.data[9] >= 100 && a.data[8] + a.data[36] >= 300;
				uslovie_text[0] = GlobalScript.inst.other_text[222];
				uslovie_bool[1] = a.event_done[91] && a.allcountries[46].Gosstroy == 0;
				uslovie_text[1] = GlobalScript.inst.other_text[223];
				uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
				uslovie_text[2] = GlobalScript.inst.other_text[224];
				return;
			}
			if (this_type == 123)
			{
				this_opis = GlobalScript.inst.other_text[227];
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 30;
				uslovie_text[0] = GlobalScript.inst.other_text[228];
				uslovie_bool[1] = !a.modifies[6].active;
				uslovie_text[1] = GlobalScript.inst.other_text[229];
				uslovie_bool[2] = a.data[6] <= 750;
				uslovie_text[2] = GlobalScript.inst.other_text[230];
				if (a.empires[1].power < 50)
				{
					uslovie_bool[3] = a.empires[1].power >= 50;
					uslovie_text[3] = GlobalScript.inst.other_text[231];
				}
				else
				{
					uslovie_bool[3] = !a.war_active[1];
					uslovie_text[3] = GlobalScript.inst.other_text[232];
				}
				return;
			}
			if (this_type == 124)
			{
				number_uslovie = 2;
				this_opis = GlobalScript.inst.other_text[235];
				uslovie_bool[0] = a.allcountries[1].isSEV || a.allcountries[1].isASEAN;
				uslovie_text[0] = GlobalScript.inst.other_text[236];
				uslovie_bool[1] = !a.allcountries[1].based;
				uslovie_text[1] = GlobalScript.inst.other_text[237];
				return;
			}
			if (this_type == 125)
			{
				number_uslovie = 4;
				if (a.allcountries[1].isSEATO)
				{
					this_opis = GlobalScript.inst.other_text[239];
				}
				else
				{
					this_opis = GlobalScript.inst.other_text[252];
				}
				uslovie_bool[0] = a.allcountries[selected_country].prcinfl >= 800;
				uslovie_text[0] = GlobalScript.inst.other_text[284];
				uslovie_bool[1] = a.data[9] >= 100 && a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = GlobalScript.inst.other_text[241];
				if (a.allcountries[1].isSEATO)
				{
					uslovie_bool[2] = a.empires[0].relations >= 700;
					uslovie_text[2] = GlobalScript.inst.other_text[242];
				}
				else
				{
					uslovie_bool[2] = a.empires[1].relations >= 700;
					uslovie_text[2] = GlobalScript.inst.other_text[253];
				}
				uslovie_bool[3] = !a.allcountries[selected_country].perevorot;
				uslovie_text[3] = GlobalScript.inst.other_text[237];
				return;
			}
			if (this_type == 126)
			{
				number_uslovie = 4;
				this_opis = GlobalScript.inst.other_text[245];
				uslovie_bool[0] = a.allcountries[11].isSEATO && a.allcountries[34].isSEATO && a.allcountries[23].isSEATO;
				uslovie_text[0] = GlobalScript.inst.other_text[246];
				uslovie_bool[1] = a.influencePRC + a.empires[0].power >= a.empires[1].power;
				uslovie_text[1] = GlobalScript.inst.other_text[247];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 250;
				uslovie_text[2] = GlobalScript.inst.other_text[248];
				uslovie_bool[3] = !a.allcountries[selected_country].cw;
				uslovie_text[3] = GlobalScript.inst.other_text[249];
				return;
			}
			if (this_type == 127)
			{
				number_uslovie = 4;
				this_opis = GlobalScript.inst.other_text[257];
				uslovie_bool[0] = a.data[131] == 3;
				uslovie_text[0] = GlobalScript.inst.other_text[258];
				uslovie_bool[1] = a.influencePRC >= a.empires[0].power;
				uslovie_text[1] = GlobalScript.inst.other_text[259];
				uslovie_bool[2] = !a.allcountries[85].isNATO && !a.allcountries[45].isNATO && !a.allcountries[87].isNATO && !a.allcountries[85].isEU && !a.allcountries[45].isEU && !a.allcountries[87].isEU;
				uslovie_text[2] = GlobalScript.inst.other_text[260];
				uslovie_bool[3] = a.allcountries[21].isNATO;
				uslovie_text[3] = GlobalScript.inst.other_text[261];
				return;
			}
			if (this_type == 128)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[264], '\n', a.allcountries[87].spec);
				uslovie_bool[0] = a.allcountries[87].spec < 100;
				uslovie_text[0] = GlobalScript.inst.other_text[266];
				uslovie_bool[1] = a.data[8] + a.data[36] >= a.allcountries[87].inflCh && a.data[9] >= a.allcountries[87].inflNATO;
				uslovie_text[1] = string.Format(GlobalScript.inst.other_text[267], (float)a.allcountries[87].inflNATO / 10f, (float)a.allcountries[87].inflCh / 10f);
				uslovie_bool[2] = a.allcountries[87].Gosstroy != 3;
				uslovie_text[2] = GlobalScript.inst.other_text[269];
				if (!a.event_done[414])
				{
					uslovie_bool[3] = a.event_done[414];
					uslovie_text[3] = GlobalScript.inst.other_text[268];
				}
				else
				{
					uslovie_bool[3] = a.data[21] < 1982 && !a.allcountries[87].based;
					uslovie_text[3] = GlobalScript.inst.other_text[265];
				}
				return;
			}
			if (this_type == 129)
			{
				number_uslovie = 4;
				this_opis = GlobalScript.inst.other_text[271];
				uslovie_bool[0] = (a.allcountries[1].econ && a.allcountries[11].econ && a.allcountries[34].econ && a.allcountries[47].econ) || (a.allcountries[1].isSEV && a.allcountries[11].isSEV && a.allcountries[34].isSEV && a.allcountries[47].isSEV) || (a.allcountries[1].isASEAN && a.allcountries[11].isASEAN && a.allcountries[34].isASEAN && a.allcountries[47].isASEAN);
				uslovie_text[0] = GlobalScript.inst.other_text[272];
				uslovie_bool[1] = !a.allcountries[1].isASEAN;
				uslovie_text[1] = GlobalScript.inst.other_text[273];
				uslovie_bool[2] = a.allcountries[49].isASEAN;
				uslovie_text[2] = GlobalScript.inst.other_text[274];
				if (!a.allcountries[1].isSEV)
				{
					uslovie_bool[3] = a.influencePRC >= 300 && a.data[8] + a.data[36] >= 150;
					uslovie_text[3] = GlobalScript.inst.other_text[275];
				}
				else
				{
					uslovie_bool[3] = a.influencePRC + a.empires[1].power >= 300 && a.data[8] + a.data[36] >= 150;
					uslovie_text[3] = GlobalScript.inst.other_text[276];
				}
				return;
			}
			if (this_type == 130)
			{
				number_uslovie = 3;
				if (a.allcountries[selected_country].sovinfl > 1000)
				{
					a.allcountries[selected_country].sovinfl = 1000;
				}
				if (a.allcountries[selected_country].sovinfl < 0)
				{
					a.allcountries[selected_country].sovinfl = 0;
				}
				if (a.allcountries[selected_country].prcinfl > 1000)
				{
					a.allcountries[selected_country].prcinfl = 1000;
				}
				if (a.allcountries[selected_country].prcinfl < 0)
				{
					a.allcountries[selected_country].prcinfl = 0;
				}
				this_opis = string.Format(GlobalScript.inst.other_text[278], '\n', (float)a.allcountries[selected_country].sovinfl / 10f, (float)a.allcountries[selected_country].prcinfl / 10f);
				uslovie_bool[0] = a.allcountries[selected_country].prosov || (!a.allcountries[selected_country].proprc && !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi);
				uslovie_text[0] = GlobalScript.inst.other_text[279];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 80;
				uslovie_text[1] = GlobalScript.inst.other_text[280];
				uslovie_bool[2] = a.allcountries[selected_country].prcinfl < 1000;
				uslovie_text[2] = GlobalScript.inst.other_text[281];
				return;
			}
			if (this_type == 131)
			{
				number_uslovie = 3;
				if (a.allcountries[selected_country].usainfl > 1000)
				{
					a.allcountries[selected_country].usainfl = 1000;
				}
				if (a.allcountries[selected_country].usainfl < 0)
				{
					a.allcountries[selected_country].usainfl = 0;
				}
				if (a.allcountries[selected_country].prcinfl > 1000)
				{
					a.allcountries[selected_country].prcinfl = 1000;
				}
				if (a.allcountries[selected_country].prcinfl < 0)
				{
					a.allcountries[selected_country].prcinfl = 0;
				}
				this_opis = string.Format(GlobalScript.inst.other_text[282], '\n', (float)a.allcountries[selected_country].usainfl / 10f, (float)a.allcountries[selected_country].prcinfl / 10f);
				uslovie_bool[0] = a.allcountries[selected_country].Vyshi || (!a.allcountries[selected_country].proprc && !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi);
				uslovie_text[0] = GlobalScript.inst.other_text[283];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 80;
				uslovie_text[1] = GlobalScript.inst.other_text[280];
				uslovie_bool[2] = a.allcountries[selected_country].prcinfl < 1000;
				uslovie_text[2] = GlobalScript.inst.other_text[281];
				return;
			}
			if (this_type == 132)
			{
				number_uslovie = 3;
				this_opis = GlobalScript.inst.other_text[286];
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = GlobalScript.inst.other_text[287];
				uslovie_bool[1] = a.allcountries[selected_country].SubGosstroy != a.allcountries[1].SubGosstroy;
				uslovie_text[1] = GlobalScript.inst.other_text[288];
				uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[2] = GlobalScript.inst.other_text[289];
				return;
			}
			if (this_type == 133)
			{
				number_uslovie = 4;
				this_opis = GlobalScript.inst.other_text[294];
				uslovie_bool[0] = a.allcountries[36].cw && a.allcountries[14].puppetOf <= 0;
				uslovie_text[0] = GlobalScript.inst.other_text[295];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 250 && a.data[9] >= 150 && a.data[22] >= 350;
				uslovie_text[1] = GlobalScript.inst.other_text[296];
				if (a.allcountries[1].okb)
				{
					uslovie_bool[2] = a.influencePRC >= a.empires[0].power + a.empires[1].power;
					uslovie_text[2] = GlobalScript.inst.other_text[297];
				}
				else if (a.allcountries[1].isOVD)
				{
					uslovie_bool[2] = a.influencePRC + a.empires[1].power >= a.empires[0].power;
					uslovie_text[2] = GlobalScript.inst.other_text[300];
				}
				else if (a.allcountries[1].isSEATO)
				{
					uslovie_bool[2] = a.influencePRC + a.empires[0].power >= a.empires[1].power;
					uslovie_text[2] = GlobalScript.inst.other_text[301];
				}
				else
				{
					uslovie_bool[2] = a.allcountries[1].okb || a.allcountries[1].isSEATO || a.allcountries[1].isOVD;
					uslovie_text[2] = GlobalScript.inst.other_text[302];
				}
				uslovie_bool[3] = !a.allcountries[14].cw;
				uslovie_text[3] = GlobalScript.inst.other_text[298];
				return;
			}
			if (this_type == 134)
			{
				if (!a.allcountries[selected_country].dota)
				{
					number_uslovie = 2;
					this_opis = string.Format("{0}{1}{3}:{2}; {5}: {4}", GlobalScript.inst.other_text[304], '\n', a.allcountries[1].isSEATO ? ((float)a.allcountries[selected_country].usainfl / 10f) : ((float)a.allcountries[selected_country].sovinfl / 10f), a.allcountries[1].isSEATO ? GlobalScript.inst.new_texts[167] : GlobalScript.inst.new_texts[168], (float)a.allcountries[selected_country].prcinfl / 10f, GlobalScript.inst.new_events_text[1214]);
					uslovie_bool[0] = a.allcountries[selected_country].proprc;
					uslovie_text[0] = GlobalScript.inst.other_text[287];
					uslovie_bool[1] = !a.allcountries[selected_country].dota;
					uslovie_text[1] = GlobalScript.inst.other_text[305];
				}
				else
				{
					number_uslovie = 1;
					this_opis = string.Format("{0}{1}{3}: {2}; {5}: {4}", GlobalScript.inst.other_text[306], '\n', a.allcountries[1].isSEATO ? ((float)a.allcountries[selected_country].usainfl / 10f) : ((float)a.allcountries[selected_country].sovinfl), a.allcountries[1].isSEATO ? GlobalScript.inst.new_texts[167] : GlobalScript.inst.new_texts[168], (float)a.allcountries[selected_country].prcinfl / 10f, GlobalScript.inst.new_events_text[1214]);
					uslovie_bool[0] = a.allcountries[selected_country].proprc;
					uslovie_text[0] = GlobalScript.inst.other_text[307];
				}
				return;
			}
			if (this_type == 135)
			{
				if (selected_country == 17)
				{
					this_opis = " 与 革 命 保 卫 办 公 室 建 立 合 作 关 系";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[1].Gosstroy == 1 || a.allcountries[selected_country].proprc;
					uslovie_text[0] = GlobalScript.inst.other_text[313];
					uslovie_bool[1] = !a.allcountries[1].isASEAN && a.science[19];
					uslovie_text[1] = GlobalScript.inst.other_text[315];
					uslovie_bool[2] = !a.modifies[41].active;
					uslovie_text[2] = " 未 和 狩 猎 俱 乐 部 合 作";
					uslovie_bool[3] = !a.modifies[53].active;
					uslovie_text[3] = GlobalScript.inst.other_text[314];
				}
				else if (selected_country == 16)
				{
					if (a.allcountries[selected_country].prosov)
					{
						if (!a.modifies[53].active)
						{
							this_opis = GlobalScript.inst.other_text[311];
							number_uslovie = 4;
							uslovie_bool[0] = a.relres;
							uslovie_text[0] = GlobalScript.inst.other_text[312];
							uslovie_bool[1] = a.allcountries[1].Gosstroy == 1;
							uslovie_text[1] = GlobalScript.inst.other_text[313];
							uslovie_bool[2] = !a.allcountries[1].isASEAN && a.science[19];
							uslovie_text[2] = GlobalScript.inst.other_text[315];
							uslovie_bool[3] = !a.modifies[41].active;
							uslovie_text[3] = GlobalScript.inst.other_text[314];
						}
						else
						{
							this_opis = GlobalScript.inst.other_text[316];
							number_uslovie = 1;
							uslovie_bool[0] = a.modifies[53].active;
							uslovie_text[0] = GlobalScript.inst.other_text[317];
						}
					}
					else if (!a.modifies[53].active)
					{
						this_opis = GlobalScript.inst.other_text[311];
						number_uslovie = 3;
						uslovie_bool[0] = a.allcountries[1].Gosstroy == 1 || a.allcountries[selected_country].proprc;
						uslovie_text[0] = GlobalScript.inst.other_text[313];
						uslovie_bool[1] = !a.allcountries[1].isASEAN && a.science[19];
						uslovie_text[1] = GlobalScript.inst.other_text[315];
						uslovie_bool[2] = !a.modifies[41].active;
						uslovie_text[2] = GlobalScript.inst.other_text[314];
					}
					else
					{
						this_opis = GlobalScript.inst.other_text[316];
						number_uslovie = 1;
						uslovie_bool[0] = a.modifies[53].active;
						uslovie_text[0] = GlobalScript.inst.other_text[317];
					}
				}
				else if (!a.modifies[53].active)
				{
					this_opis = GlobalScript.inst.other_text[311];
					number_uslovie = 3;
					uslovie_bool[0] = a.allcountries[1].Gosstroy == 1 || a.allcountries[selected_country].proprc;
					uslovie_text[0] = GlobalScript.inst.other_text[313];
					uslovie_bool[1] = !a.allcountries[1].isASEAN && a.science[19];
					uslovie_text[1] = GlobalScript.inst.other_text[315];
					uslovie_bool[2] = !a.modifies[41].active;
					uslovie_text[2] = GlobalScript.inst.other_text[314];
				}
				return;
			}
			if (this_type == 136)
			{
				this_opis = GlobalScript.inst.other_text[318];
				number_uslovie = 3;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[0] = GlobalScript.inst.other_text[319];
				uslovie_bool[1] = a.data[21] < 1978 || (a.data[21] == 1978 && a.data[20] < 11);
				uslovie_text[1] = GlobalScript.inst.other_text[320];
				uslovie_bool[2] = !a.allcountries[86].based;
				uslovie_text[2] = GlobalScript.inst.other_text[321];
				return;
			}
			if (this_type == 137)
			{
				number_uslovie = 4;
				this_opis = " 让 我 们 给 这 群 不 知 好 歹 的 德 国 佬 一 点 教 训";
				uslovie_bool[0] = !a.allcountries[0].Vyshi && !a.allcountries[88].Vyshi && !a.allcountries[89].Vyshi && !a.allcountries[90].Vyshi;
				uslovie_text[0] = " 西 德 没 有 亲 美 的 邻 国";
				uslovie_bool[1] = !a.allcountries[17].cw;
				uslovie_text[1] = " 西 德 尚 未 被 禁 运";
				uslovie_bool[2] = !a.allcountries[0].isEU;
				uslovie_text[2] = " 欧 共 体 已 解 散";
				uslovie_bool[3] = !a.event_done[485];
				uslovie_text[3] = " 尚 未 煽 动 西 德 局 势";
				return;
			}
			if (this_type == 138)
			{
				number_uslovie = 4;
				this_opis = " 是 时 候 了 ， 行 动 ！";
				uslovie_bool[0] = (a.event_done[486] && a.resultOfEvents[486] == 0) || a.resultOfEvents[487] != 0;
				uslovie_text[0] = " 我 们 支 持 过 德 国 的 反 对 派";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200 && a.data[22] >= 200;
				uslovie_text[1] = " 我 们 有 20 点 军 力 、 2 0 点 特 勤 和 20 点 预 算";
				uslovie_bool[2] = a.allcountries[17].cw;
				uslovie_text[2] = " 西 德 被 禁 运 中";
				uslovie_bool[3] = !a.event_done[485] || a.resultOfEvents[485] == 2;
				uslovie_text[3] = " 政 府 尚 未 被 推 翻";
				return;
			}
			if (this_type == 139)
			{
				number_uslovie = 3;
				this_opis = string.Format(GlobalScript.inst.other_text[427], '\n');
				uslovie_bool[0] = a.influencePRC >= a.empires[0].power + a.empires[1].power || a.influencePRC >= 800;
				uslovie_text[0] = GlobalScript.inst.other_text[428];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 150;
				uslovie_text[1] = GlobalScript.inst.other_text[429];
				uslovie_bool[2] = a.allcountries[18].spec <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[430];
				return;
			}
			if (this_type == 140)
			{
				number_uslovie = 3;
				this_opis = string.Format(GlobalScript.inst.other_text[431], '\n');
				uslovie_bool[0] = a.influencePRC >= a.empires[0].power + a.empires[1].power || a.influencePRC >= 800;
				uslovie_text[0] = GlobalScript.inst.other_text[428];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 150;
				uslovie_text[1] = GlobalScript.inst.other_text[429];
				uslovie_bool[2] = a.allcountries[18].spec <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[430];
				return;
			}
			if (this_type == 141)
			{
				number_uslovie = 3;
				this_opis = string.Format(GlobalScript.inst.other_text[432], '\n');
				uslovie_bool[0] = a.influencePRC >= a.empires[0].power + a.empires[1].power || a.influencePRC >= 800;
				uslovie_text[0] = GlobalScript.inst.other_text[428];
				uslovie_bool[1] = a.data[8] + a.data[36] >= 150;
				uslovie_text[1] = GlobalScript.inst.other_text[429];
				uslovie_bool[2] = a.allcountries[18].spec <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[430];
				return;
			}
			if (this_type == 142)
			{
				if (selected_country == 123)
				{
					number_uslovie = 2;
					this_opis = "为 我 们 选 择 了 的 派 系 提 供 军 事 援 助|安 人 运 力 量：" + a.allcountries[123].prcpower / 10 + "." + Mathf.Abs(a.allcountries[123].prcpower % 10) + "安 盟 力 量：" + a.allcountries[123].sovpower / 10 + "." + Mathf.Abs(a.allcountries[123].sovpower % 10) + "安 解 阵 力 量：" + a.allcountries[123].usapower / 10 + "." + Mathf.Abs(a.allcountries[123].usapower % 10);
					uslovie_bool[0] = a.data[22] >= 100;
					uslovie_text[0] = "至 少10 军 事 力 量";
					uslovie_bool[1] = a.allcountries[selected_country].sovinfl <= 0;
					uslovie_text[1] = GlobalScript.inst.other_text[450];
				}
				else
				{
					number_uslovie = 4;
					this_opis = string.Format(GlobalScript.inst.other_text[448], '\n', GlobalScript.inst.gameState.allcountries[selected_country].name, (float)GlobalScript.inst.gameState.allcountries[selected_country].inflCh / 10f);
					uslovie_bool[0] = a.data[22] >= 50;
					uslovie_text[0] = GlobalScript.inst.other_text[449];
					uslovie_bool[1] = a.allcountries[selected_country].sovinfl <= 0;
					uslovie_text[1] = GlobalScript.inst.other_text[450];
					uslovie_bool[2] = a.allcountries[selected_country].inflCh < 1000;
					uslovie_text[2] = GlobalScript.inst.other_text[452];
					uslovie_bool[3] = a.event_done[418];
					uslovie_text[3] = GlobalScript.inst.other_text[451];
				}
				return;
			}
			if (this_type == 143)
			{
				if (selected_country == 123)
				{
					number_uslovie = 2;
					this_opis = "为 我 们 选 择 的 派 系 提 供 资 金 援 助|安 人 运 力 量：" + a.allcountries[123].prcpower / 10 + "." + Mathf.Abs(a.allcountries[123].prcpower % 10) + "安 盟 力 量：" + a.allcountries[123].sovpower / 10 + "." + Mathf.Abs(a.allcountries[123].sovpower % 10) + "安 解 阵 力 量：" + a.allcountries[123].usapower / 10 + "." + Mathf.Abs(a.allcountries[123].usapower % 10);
					uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
					uslovie_text[0] = "至 少5 百 万 预 算";
					uslovie_bool[1] = a.allcountries[selected_country].usainfl <= 0;
					uslovie_text[1] = GlobalScript.inst.other_text[450];
				}
				else
				{
					number_uslovie = 4;
					this_opis = string.Format(GlobalScript.inst.other_text[453], '\n', GlobalScript.inst.gameState.allcountries[selected_country].name, (float)GlobalScript.inst.gameState.allcountries[selected_country].inflCh / 10f);
					uslovie_bool[0] = a.data[9] >= 50;
					uslovie_text[0] = GlobalScript.inst.other_text[454];
					uslovie_bool[1] = a.allcountries[selected_country].usainfl <= 0;
					uslovie_text[1] = GlobalScript.inst.other_text[450];
					uslovie_bool[2] = a.allcountries[selected_country].inflCh < 1000;
					uslovie_text[2] = GlobalScript.inst.other_text[452];
					uslovie_bool[3] = a.event_done[418];
					uslovie_text[3] = GlobalScript.inst.other_text[451];
				}
				return;
			}
			if (this_type == 144)
			{
				if (selected_country == 123)
				{
					number_uslovie = 2;
					this_opis = "散 播 其 余 派 系 的 黑 材 料|安 人 运 力 量：" + a.allcountries[123].prcpower / 10 + "." + Mathf.Abs(a.allcountries[123].prcpower % 10) + "安 盟 力 量：" + a.allcountries[123].sovpower / 10 + "." + Mathf.Abs(a.allcountries[123].sovpower % 10) + "安 解 阵 力 量：" + a.allcountries[123].usapower / 10 + "." + Mathf.Abs(a.allcountries[123].usapower % 10);
					uslovie_bool[0] = a.data[9] >= 50;
					uslovie_text[0] = "至 少5 特 工 网 络";
					uslovie_bool[1] = a.allcountries[selected_country].prcinfl <= 0;
					uslovie_text[1] = GlobalScript.inst.other_text[450];
				}
				else
				{
					number_uslovie = 4;
					this_opis = string.Format(GlobalScript.inst.other_text[455], '\n', GlobalScript.inst.gameState.allcountries[selected_country].name, (float)GlobalScript.inst.gameState.allcountries[selected_country].inflCh / 10f);
					uslovie_bool[0] = a.data[8] + a.data[36] >= 30;
					uslovie_text[0] = GlobalScript.inst.other_text[456];
					uslovie_bool[1] = a.allcountries[selected_country].prcinfl <= 0;
					uslovie_text[1] = GlobalScript.inst.other_text[450];
					uslovie_bool[2] = a.allcountries[selected_country].inflCh < 1000;
					uslovie_text[2] = GlobalScript.inst.other_text[452];
					uslovie_bool[3] = a.event_done[418];
					uslovie_text[3] = GlobalScript.inst.other_text[451];
				}
				return;
			}
			if (this_type == 145)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[460], '\n', (a.data[143] + 5 <= 60) ? (a.data[143] + 5) : 60);
				int num = 0;
				for (int i = 101; i < 107; i++)
				{
					if (a.allcountries[i].proprc)
					{
						num++;
					}
				}
				if (a.allcountries[36].proprc)
				{
					num++;
				}
				uslovie_bool[0] = num >= 3;
				uslovie_text[0] = GlobalScript.inst.other_text[461];
				uslovie_bool[1] = a.data[9] >= 50;
				uslovie_text[1] = GlobalScript.inst.other_text[454];
				uslovie_bool[2] = a.allcountries[36].inflNATO <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[450];
				uslovie_bool[3] = a.data[143] < 60;
				uslovie_text[3] = GlobalScript.inst.other_text[462];
				return;
			}
			if (this_type == 146)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[463], '\n', (a.data[143] - 5 >= 10) ? (a.data[143] - 5) : 10);
				int num2 = 0;
				for (int j = 101; j < 107; j++)
				{
					if (a.allcountries[j].proprc)
					{
						num2++;
					}
				}
				if (a.allcountries[36].proprc)
				{
					num2++;
				}
				uslovie_bool[0] = num2 >= 3;
				uslovie_text[0] = GlobalScript.inst.other_text[461];
				uslovie_bool[1] = a.data[9] >= 50;
				uslovie_text[1] = GlobalScript.inst.other_text[454];
				uslovie_bool[2] = a.allcountries[36].inflNATO <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[450];
				uslovie_bool[3] = a.data[143] > 10;
				uslovie_text[3] = GlobalScript.inst.other_text[464];
				return;
			}
			if (this_type == 147)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[468], '\n');
				uslovie_bool[0] = a.data[8] + a.data[36] >= 100;
				uslovie_text[0] = GlobalScript.inst.other_text[469];
				uslovie_bool[1] = a.data[9] >= 50 && a.data[22] >= 100;
				uslovie_text[1] = GlobalScript.inst.other_text[470];
				uslovie_bool[2] = a.allcountries[selected_country].stab > 0;
				uslovie_text[2] = GlobalScript.inst.other_text[471];
				uslovie_bool[3] = a.allcountries[selected_country].spec <= 0;
				uslovie_text[3] = GlobalScript.inst.other_text[472];
				return;
			}
			if (this_type == 148)
			{
				number_uslovie = 4;
				if (!a.allcountries[85].isSocEU)
				{
					this_opis = string.Format(GlobalScript.inst.other_text[479], '\n');
					uslovie_bool[0] = a.data[8] + a.data[36] >= 200;
					uslovie_text[0] = GlobalScript.inst.other_text[481];
					uslovie_bool[1] = a.data[9] >= 200;
					uslovie_text[1] = GlobalScript.inst.other_text[482];
					uslovie_bool[2] = !a.allcountries[0].isNATO && !a.allcountries[0].isEU;
					uslovie_text[2] = GlobalScript.inst.other_text[483];
					uslovie_bool[3] = !a.allcountries[selected_country].cw;
					uslovie_text[3] = GlobalScript.inst.other_text[484];
				}
				else
				{
					this_opis = " 邀 请 该 国 加 入 欧 洲 社 会 主 义 联 盟 ， 推 进 建 设 人 道 、 民 主 的 社 会 主 义";
					uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
					uslovie_text[0] = " 5 百 万 预 算";
					uslovie_bool[1] = a.data[9] >= 50;
					uslovie_text[1] = " 5 特 工 网 络 ";
					uslovie_bool[2] = !a.allcountries[0].isNATO && !a.allcountries[0].isEU;
					uslovie_text[2] = GlobalScript.inst.other_text[483];
					uslovie_bool[3] = !a.allcountries[selected_country].cw;
					uslovie_text[3] = " 还 未 邀 请";
				}
				return;
			}
			if (this_type == 149)
			{
				number_uslovie = 4;
				this_opis = string.Format(GlobalScript.inst.other_text[480], '\n');
				uslovie_bool[0] = a.data[8] + a.data[36] >= 200;
				uslovie_text[0] = GlobalScript.inst.other_text[481];
				uslovie_bool[1] = a.data[9] >= 200;
				uslovie_text[1] = GlobalScript.inst.other_text[482];
				uslovie_bool[2] = !a.allcountries[0].isNATO && !a.allcountries[0].isEU;
				uslovie_text[2] = GlobalScript.inst.other_text[483];
				uslovie_bool[3] = !a.allcountries[selected_country].cw;
				uslovie_text[3] = GlobalScript.inst.other_text[484];
			}
			if (this_type == 1000)
			{
				this_opis = " 挑 起 政 变 ， 以 推 翻 黎 笋 政 权";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[selected_country].SubGosstroy == 10;
				uslovie_text[0] = " 黎 笋 尚 未 被 推 翻";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 40;
				uslovie_text[1] = " 至 少 4 特 工 网 络 和 4 百 万 预 算";
				uslovie_bool[2] = !a.allcountries[selected_country].prosov;
				uslovie_text[2] = " 该 国 不 受 苏 联 影 响";
				uslovie_bool[3] = a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0;
				uslovie_text[3] = " 我 国 体 制 为 社 会 主 义";
				return;
			}
			if (this_type == 1001)
			{
				this_opis = " 就 戈 兰 高 地 的 归 属 问 题 组 织 谈 判";
				number_uslovie = 3;
				uslovie_bool[0] = a.Israellost || GlobalScript.inst.gameState.allcountries[93].puppetOf == 37;
				uslovie_text[0] = " 黎 巴 嫩 战 争 已 结 束";
				uslovie_bool[1] = !GlobalScript.inst.gameState.event_done[439] || GlobalScript.inst.gameState.resultOfEvents[439] == 3;
				uslovie_text[1] = " 还 未 组 织 谈 判";
				uslovie_bool[2] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[2] = " 叙 利 亚 不 受 美 国 影 响";
				return;
			}
			if (this_type == 1002)
			{
				this_opis = " 尝 试 利 用 我 们 的 影 响 力 结 束 黎 巴 嫩 内 战";
				number_uslovie = 3;
				uslovie_bool[0] = a.Israellost;
				uslovie_text[0] = " 以 色 列 输 掉 了 黎 巴 嫩 战 争";
				uslovie_bool[1] = !GlobalScript.inst.gameState.event_done[440];
				uslovie_text[1] = " 还 未 组 织 谈 判";
				uslovie_bool[2] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[2] = " 黎 巴 嫩 不 受 美 国 影 响";
				return;
			}
			if (this_type == 1003)
			{
				this_opis = " 支 持 建 制 内 健 康 力 量 反 对 特 拉 奥 雷";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[6] >= 790;
				uslovie_text[0] = " 声 誉 大 于 等 于79";
				uslovie_bool[1] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 50;
				uslovie_text[1] = " 至 少 5 特 工 网 络 和 5 百 万 预 算";
				uslovie_bool[2] = !GlobalScript.inst.gameState.allcountries[58].cw;
				uslovie_text[2] = " 没 有 支 持 过";
				uslovie_bool[3] = !GlobalScript.inst.gameState.event_done[458];
				uslovie_text[3] = " 趁 我 们 还 来 得 及";
				return;
			}
			if (this_type == 1004)
			{
				this_opis = " 让 马 里 走 向 真 正 的 人 民 民 主";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
				uslovie_text[0] = " 至 少 10 百 万 预 算 与 10 特 勤";
				uslovie_bool[1] = a.allcountries[1].SubGosstroy == 19;
				uslovie_text[1] = " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论";
				uslovie_bool[2] = a.allcountries[58].SubGosstroy != 19;
				uslovie_text[2] = " 尚 未 向 马 里 传 授 经 验";
				return;
			}
			if (this_type == 1005)
			{
				this_opis = " 封 锁 制 裁 台 湾 当 局 ， 以 促 使 将 伪 政 权 倒 台";
				number_uslovie = 2;
				uslovie_bool[0] = GlobalScript.inst.gameState.event_done[460] && GlobalScript.inst.gameState.resultOfEvents[460] != 2;
				uslovie_text[0] = " 已 支 持 台 湾 美 丽 岛 运 动";
				uslovie_bool[1] = !GlobalScript.inst.gameState.allcountries[38].Vyshi;
				uslovie_text[1] = " 美 国 已 失 去 对 台 湾 的 掌 控";
				return;
			}
			if (this_type == 1006)
			{
				this_opis = " 秘 密 联 络 拉 巴 特 派 ， 为 将 来 作 准 备";
				number_uslovie = 3;
				uslovie_bool[0] = !a.event_done[463];
				uslovie_text[0] = " 趁 我 们 还 来 得 及";
				uslovie_bool[1] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 30;
				uslovie_text[1] = " 至 少 5 特 工 网 络 和 3 百 万 预 算";
				uslovie_bool[2] = !GlobalScript.inst.gameState.allcountries[54].cw;
				uslovie_text[2] = " 尚 未 提 供 援 助";
				return;
			}
			if (this_type == 1007)
			{
				this_opis = " 向 玻 里 沙 里 欧 阵 线 出 售 军 火 ， 支 持 他 们 的 武 装 斗 争";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[22] >= 50;
				uslovie_text[0] = " 需 要 5 军 力";
				uslovie_bool[1] = GlobalScript.inst.gameState.science[18];
				uslovie_text[1] = " 科 技 《 加 强 军 备 开 发 》 研 发 完 毕";
				uslovie_bool[2] = !GlobalScript.inst.gameState.allcountries[18].cw;
				uslovie_text[2] = " 我 们 没 有 出 售 过 军 火";
				return;
			}
			if (this_type == 1008)
			{
				this_opis = " 重 新 讨 论 关 于 东 方 申 根 协 定 的 事 宜";
				number_uslovie = 1;
				uslovie_bool[0] = GlobalScript.inst.gameState.resultOfEvents[464] != 1 && GlobalScript.inst.gameState.resultOfEvents[464] != 0;
				uslovie_text[0] = " 还 未 签 订";
				return;
			}
			if (this_type == 1009)
			{
				this_opis = " 支 持 法 国 共 产 党 内 部 的 正 统 派";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 30 && a.data[9] >= 30;
				uslovie_text[0] = " 3 百 万 预 算 和 3 特 工 网 络";
				uslovie_bool[1] = a.allcountries[selected_country].spec <= 0;
				uslovie_text[1] = " 一 年 一 次";
				uslovie_bool[2] = !a.modifies[3].active;
				uslovie_text[2] = " 文 化 大 革 命 已 结 束";
				uslovie_bool[3] = a.data[21] < 1981;
				uslovie_text[3] = " 早 于 1 9 8 1 年";
				return;
			}
			if (this_type == 1010)
			{
				this_opis = " 支 持 法 共 正 统 派 发 起 政 变";
				number_uslovie = 4;
				uslovie_bool[0] = a.relres;
				uslovie_text[0] = " 与 苏 联 和 解";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
				uslovie_text[1] = " 10 百 万 预 算 和 10 特 工 网 络";
				uslovie_bool[2] = !a.event_done[482] || a.resultOfEvents[482] != 1;
				uslovie_text[2] = " 尚 未 推 翻 马 歇";
				uslovie_bool[3] = a.data[21] < 1981;
				uslovie_text[3] = " 早 于 1 9 8 1 年";
				return;
			}
			if (this_type == 1012)
			{
				if (a.allcountries[1].Gosstroy == 1 || a.allcountries[1].Gosstroy == 0)
				{
					this_opis = " 秘 密 联 络 米 利 塔 鲁 与 流 亡 海 外 的 阿 波 斯 托 尔 ， 促 成 联 合 。";
				}
				else
				{
					this_opis = " 秘 密 联 络 米 利 塔 鲁 与 流 亡 海 外 的 伊 利 埃 斯 库 ， 促 成 联 合 。";
				}
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[5].spec <= 0;
				uslovie_text[0] = " 还 未 促 成 联 合";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 100;
				uslovie_text[1] = " 5 百 万 预 算 和 10 特 工 网 络";
				uslovie_bool[2] = a.data[21] < 1981;
				uslovie_text[2] = " 早 于 1 9 8 1 年";
				return;
			}
			if (this_type == 1011)
			{
				this_opis = " 煽 动 罗 马 尼 亚 局 势 ， 推 翻 “ 吸 血 鬼 ” 的 统 治";
				number_uslovie = 4;
				uslovie_bool[0] = !a.event_done[490];
				uslovie_text[0] = " 尚 未 掀 起 罗 马 尼 亚 革 命";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 50;
				uslovie_text[1] = " 10 百 万 预 算 和 5 特 工 网 络";
				uslovie_bool[2] = a.data[21] >= 1983;
				uslovie_text[2] = " 晚 于 1 9 8 3 年";
				uslovie_bool[3] = a.allcountries[5].spec > 0;
				uslovie_text[3] = " 已 联 络 罗 马 尼 亚 反 对 派";
				return;
			}
			if (this_type == 1013)
			{
				this_opis = " 试 图 将 已 经 民 主 化 的 朝 鲜 和 韩 国 整 合 成 一 个 统 一 的 国 家";
				number_uslovie = 2;
				uslovie_bool[0] = a.resultOfEvents[495] != 1;
				uslovie_text[0] = " 尚 未 推 进 统 一";
				uslovie_bool[1] = ((a.allcountries[46].Gosstroy == 3 && !a.allcountries[46].Vyshi) || a.allcountries[46].Gosstroy == 2) && a.allcountries[10].Gosstroy == 2;
				uslovie_text[1] = " 韩 国 和 朝 鲜 都 已 民 主 化";
				return;
			}
			if (this_type == 1014)
			{
				this_opis = $" 支 持 自 民 党 中 的 亲 华 派 。{'\n'}影 响 力： {a.allcountries[selected_country].prcinfl}";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 50;
				uslovie_text[0] = " 至 少 8 特 工 网 络";
				uslovie_bool[1] = a.data[22] >= 50;
				uslovie_text[1] = " 至 少 8 点 军 事 力 量";
				uslovie_bool[2] = a.data[8] + a.data[36] >= 50;
				uslovie_text[2] = " 至 少 8 点 预 算";
				uslovie_bool[3] = a.data[6] <= 690;
				uslovie_text[3] = " 外 交 声 誉 低 于 69";
			}
			if (this_type == 1015)
			{
				this_opis = " 发 动 反 自 民 党 政 府 的 赤 色 革 命";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 150 && a.data[9] >= 150 && a.data[22] >= 150;
				uslovie_text[0] = " 预 算 、 特 工 网 络 、 军 事 力 量 均 大 于 15";
				uslovie_bool[1] = (a.data[21] <= 1984 && a.data[20] <= 7) || a.data[21] <= 1983;
				uslovie_text[1] = " 不 晚 于 1984 年 7 月";
				uslovie_bool[2] = a.allcountries[44].prcpower >= 200;
				uslovie_text[2] = " 日 本 革 命 共 产 党 的 力 量 强 于 200";
				uslovie_bool[3] = !a.event_done[538] && !a.allcountries[44].based;
				uslovie_text[3] = " 尚 未 发 动 革 命";
			}
			if (this_type == 1016)
			{
				this_opis = " 联 络 叙 利 亚 反 对 阿 萨 德 的 反 对 派";
				number_uslovie = 2;
				uslovie_bool[0] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 50 && a.data[22] >= 50;
				uslovie_text[0] = " 预 算 不 少 于 10百万 ，特 工 网 络 不 少 于 5 ， 军 力 不 少 于5";
				uslovie_bool[1] = !a.allcountries[35].cw;
				uslovie_text[1] = " 尚 未 联 络 过";
			}
			if (this_type == 1017)
			{
				this_opis = $" 向 意 大 利 反 建 制 激 进 左 翼 发 送 援 助 {'\n'} 激 进 左 翼 力 量 ： {a.allcountries[selected_country].prcpower / 10}.{a.allcountries[selected_country].prcpower % 10}";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[6] >= 800;
				uslovie_text[0] = " 外 交 声 誉 不 低 于 80";
				uslovie_bool[1] = a.data[21] <= 1984;
				uslovie_text[1] = " 不 晚 于 1984 年";
				uslovie_bool[2] = a.allcountries[1].SubGosstroy == 0 || a.allcountries[1].Gosstroy == 1;
				uslovie_text[2] = " 中 国 为 社 会 主 义";
				uslovie_bool[3] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
				uslovie_text[3] = " 预 算 、 特 工 网 络 、 军 事 力 量 均 不 少 于 5";
			}
			if (this_type == 1018)
			{
				this_opis = " 与 苏 联 同 志 一 道 施 压 ， 支 持 意 大 利 共 产 党 内 的 正 统 社 会 主 义 者";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[85].Gosstroy != 1;
				uslovie_text[0] = " 意 大 利 尚 未 左 转";
				uslovie_bool[1] = a.empires[1].now_leader != 6 && a.empires[1].now_leader != 8 && a.empires[1].now_leader != 7;
				uslovie_text[1] = " 苏 联 领 导 人 不 为 戈 尔 巴 乔 夫 、 雅 科 夫 列 夫 、 利 加 乔 夫";
				uslovie_bool[2] = a.allcountries[1].isSEV;
				uslovie_text[2] = " 中 国 加 入 了 经 互 会";
				uslovie_bool[3] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 50;
				uslovie_text[3] = " 预 算 不 少 于 10百万 ，特 工 网 络 不 少 于 5";
			}
			if (this_type == 1019)
			{
				this_opis = " 联 络 阿 尔 及 利 亚 的 反 对 派";
				number_uslovie = 2;
				uslovie_bool[0] = !a.allcountries[40].cw;
				uslovie_text[0] = " 尚 未 联 络";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百万 ，特 工 网 络 不 少 于 5";
			}
			if (this_type == 1020)
			{
				this_opis = " 煽 动 阿 尔 及 利 亚 的 反 对 派 ， 试 图 颠 覆 现 有 政 府";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[13].proprc;
				uslovie_text[0] = " 利 比 亚 已 建 成 亲 中 政 权";
				uslovie_bool[3] = !a.event_done[563];
				uslovie_text[3] = " 尚 未 煽 动";
				uslovie_bool[2] = a.data[21] >= 1984;
				uslovie_text[2] = " 不 早 于 1984年";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 150 && a.data[9] >= 150 && a.data[22] >= 150;
				uslovie_text[1] = " 预 算 不 少 于 15百万 ，特 工 网 络 不 少 于 15 ， 军 力 不 少 于15";
			}
			if (this_type == 1021)
			{
				if (selected_country == 24)
				{
					this_opis = " 协 助 阿 湾 人 阵 进 行 重 建 工 作";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[24].parts[0];
					uslovie_text[0] = " 也 门 已 统 一";
					if (a.allcountries[24].proprc && a.allcountries[24].Gosstroy == 1)
					{
						uslovie_bool[1] = a.allcountries[24].Gosstroy == 1 && a.allcountries[24].proprc && a.allcountries[30].Gosstroy == 1 && a.OAR;
						uslovie_text[1] = " 也 门 为 亲 中 红 色 政 权 且 阿 拉 伯 革 命 同 盟 已 建 成";
					}
					else if (a.allcountries[24].Gosstroy == 2)
					{
						this_opis = " 协 助 阿 湾 人 阵 进 行 重 建 工 作";
						number_uslovie = 4;
						uslovie_bool[0] = a.allcountries[25].parts[0];
						uslovie_text[0] = " 也 门 已 统 一";
						uslovie_bool[1] = a.allcountries[25].Gosstroy == 2 && a.allcountries[25].proprc && a.allcountries[30].Gosstroy == 2;
						uslovie_text[1] = " 也 门 为 亲 中 改 良 主 义 且 埃 及 为 纳 赛 尔 主 义 者";
						uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 100;
						uslovie_text[2] = " 预 算 不 少 于 10百 万 ，特 工 网 络 不 少 于 10 ， 军 力 不 少 于10";
						uslovie_bool[3] = !a.event_done[567];
						uslovie_text[3] = " 尚 未 重 建";
					}
					else
					{
						uslovie_bool[1] = a.allcountries[24].Gosstroy == 1 && a.allcountries[24].prosov && a.allcountries[1].isOVD;
						uslovie_text[1] = " 也 门 为 亲 苏 红 色 政 权 且 中 国 在 华 约";
					}
					uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 100;
					uslovie_text[2] = " 预 算 不 少 于 10百 万 ，特 工 网 络 不 少 于 10 ， 军 力 不 少 于 10";
					uslovie_bool[3] = !a.event_done[567];
					uslovie_text[3] = " 尚 未 重 建";
				}
				if (selected_country == 25)
				{
					this_opis = " 协 助 阿 湾 人 阵 进 行 重 建 工 作";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[25].parts[0];
					uslovie_text[0] = " 也 门 已 统 一";
					uslovie_bool[1] = a.allcountries[25].Gosstroy == 2 && a.allcountries[25].proprc && a.allcountries[30].Gosstroy == 2;
					uslovie_text[1] = " 也 门 为 亲 中 改 良 主 义 且 埃 及 为 纳 赛 尔 主 义 者";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 100;
					uslovie_text[2] = " 预 算 不 少 于 10百 万 ，特 工 网 络 不 少 于 10 ， 军 力 不 少 于10";
					uslovie_bool[3] = !a.event_done[567];
					uslovie_text[3] = " 尚 未 重 建";
				}
			}
			if (this_type == 1022)
			{
				if (a.allcountries[24].prcpower < 100)
				{
					this_opis = " 支 持 阿 拉 伯 湾 国 家 的 阿 湾 人 阵|阿 湾 人 阵 力 量 ：" + a.allcountries[24].prcpower;
					number_uslovie = 4;
					uslovie_bool[0] = a.event_done[567];
					uslovie_text[0] = " 已 协 助 重 建 阿 湾 人 阵";
					uslovie_bool[1] = a.allcountries[24].prcpower < 100;
					uslovie_text[1] = " 阿 湾 人 阵 力 量 小 于100";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[2] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5 ， 军 力 不 少 于5";
					uslovie_bool[3] = a.allcountries[24].stab == 0;
					uslovie_text[3] = " 三 月 一 次";
				}
				else
				{
					this_opis = " 推 动 阿 拉 伯 湾 国 家 的 阿 湾 人 阵 发 起 革 命 推 翻 君 主 统 治";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[24].prcpower >= 100;
					uslovie_text[0] = " 阿 湾 人 阵 力 量 不 低 于100";
					uslovie_bool[1] = a.allcountries[8].Gosstroy == 1 || a.allcountries[8].Gosstroy == 2 || a.allcountries[8].SubGosstroy == 0;
					uslovie_text[1] = " 伊 朗 为 亲 中 绿 色 或 红 色 政 权";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 150 && a.data[9] >= 150 && a.data[22] >= 150;
					uslovie_text[2] = " 预 算 不 少 于 15百 万 ，特 工 网 络 不 少 于 15 ， 军 力 不 少 于15";
					uslovie_bool[3] = !a.event_done[568];
					uslovie_text[3] = " 尚 未 推 动 革 命";
				}
			}
			if (this_type == 1023)
			{
				this_opis = " 发 起 一 场 把 阿 拉 伯 半 岛 上 最 后 的 王 爷 送 入 坟 墓 的 革 命";
				number_uslovie = 4;
				uslovie_bool[0] = a.event_done[421];
				uslovie_text[0] = " 美 国 已 衰 落";
				uslovie_bool[1] = !a.IsAuthoritarianism(102) && !a.IsAuthoritarianism(104);
				uslovie_text[1] = " 阿 拉 伯 湾 和 约 旦 的 革 命 都 已 胜 利";
				uslovie_bool[2] = a.data[6] > 790;
				uslovie_text[2] = " 外 交 声 誉 高 于 79";
				uslovie_bool[3] = !a.event_done[569];
				uslovie_text[3] = " 尚 未 策 动 革 命";
			}
			if (this_type == 1024)
			{
				if (selected_country == 134)
				{
					this_opis = " 督 促 社 会 改 革";
					number_uslovie = 3;
					uslovie_bool[0] = a.allcountries[135].proprc || a.allcountries[135].prosov;
					uslovie_text[0] = " 澳 大 利 亚 已 倒 向 社 会 主 义 阵 容";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
					uslovie_bool[2] = !a.allcountries[134].cw;
					uslovie_text[2] = " 尚 未 督 促";
				}
				else if (selected_country == 136)
				{
					if (a.data[56] == 0 || a.data[56] == 1)
					{
						this_opis = " 支 持 工 党 左 派 和 共 产 主 义 者 联 合 政 府 上 台";
					}
					else if (a.data[56] == 2)
					{
						this_opis = " 支 持 工 党 进 行 社 会 改 革";
					}
					else if (a.data[56] == 3)
					{
						this_opis = " 支 持 社 会 信 用 党 上 台";
					}
					else if (a.data[56] == 4)
					{
						this_opis = " 支 持 新 西 兰 党 上 台";
					}
					number_uslovie = 3;
					uslovie_bool[0] = a.event_done[421];
					uslovie_text[0] = " 美 国 已 衰 落";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
					uslovie_text[1] = " 预 算 不 少 于 20百 万 ，特 工 网 络 不 少 于 20";
					uslovie_bool[2] = !a.allcountries[136].cw;
					uslovie_text[2] = " 尚 未 支 持";
				}
				else if (selected_country == 56)
				{
					this_opis = " 开 始 复 苏 萨 瓦 巴 党 在 该 国 内 的 行 动 ， 并 提 供 理 论 指 导";
					number_uslovie = 3;
					uslovie_bool[0] = a.modifies[6].active;
					uslovie_text[0] = " 我 们 始 终 坚 持 战 无 不 胜 的 毛 泽 东 思 想 ！";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
					uslovie_bool[2] = !a.allcountries[56].cw;
					uslovie_text[2] = " 尚 未 支 持";
				}
				else if (selected_country == 112)
				{
					this_opis = " 支 持 塞 共 / 马 列 ， 力 量 ：" + a.allcountries[112].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[112].level_of_unstab % 10);
					number_uslovie = 3;
					uslovie_bool[0] = a.modifies[6].active;
					uslovie_text[0] = " 我 们 始 终 坚 持 战 无 不 胜 的 毛 泽 东 思 想 ！";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
					uslovie_bool[2] = !a.allcountries[112].cw;
					uslovie_text[2] = " 三 月 一 次";
				}
				else if (selected_country == 66)
				{
					this_opis = "  为 喀 麦 隆 人 民 联 盟 提 供 武 器 ， 力 量 ：" + a.allcountries[66].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[66].level_of_unstab % 10);
					number_uslovie = 3;
					uslovie_bool[0] = a.data[6] >= 790;
					uslovie_text[0] = " 国 际 声 望 高 于 7 9";
					uslovie_bool[1] = a.data[22] >= 100 && a.data[9] >= 50;
					uslovie_text[1] = "特 工 网 络 不 少 于 5 且 军 力 不 少 于 10 ";
					uslovie_bool[2] = !a.allcountries[66].cw;
					uslovie_text[2] = " 一 月 一 次";
				}
				else if (selected_country == 116)
				{
					this_opis = " 与 加 蓬 反 对 派 取 得 联 络";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[6] >= 790;
					uslovie_text[0] = " 国 际 声 望 高 于 7 9";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
					uslovie_bool[2] = !a.allcountries[116].cw;
					uslovie_text[2] = " 尚 未 联 络";
				}
			}
			if (this_type == 1025)
			{
				this_opis = " 巴 布 亚 人 建 国";
				number_uslovie = 3;
				uslovie_bool[0] = a.allcountries[50].Gosstroy == 1 && !a.allcountries[135].Vyshi;
				uslovie_text[0] = " 印 度 尼 西 亚 与 澳 大 利 亚 均 持 积 极 态 度";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
				uslovie_bool[2] = !a.allcountries[134].parts[0];
				uslovie_text[2] = " 还 未 推 动";
				return;
			}
			if (this_type == 1026)
			{
				this_opis = " 支 持 墨 西 哥 的 左 翼 反 对 派";
				number_uslovie = 3;
				uslovie_bool[2] = a.allcountries[140].stab == 0;
				uslovie_text[2] = " 尚 未 支 持 过 反 对 派";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
				uslovie_bool[0] = GlobalScript.inst.gameState.science[20];
				uslovie_text[0] = " 科 技 《 新 式 间 谍 装 备 》 研 发 完 毕";
				return;
			}
			if (this_type == 1027)
			{
				this_opis = " 支 持 墨 西 哥 的 右 翼 反 对 派";
				number_uslovie = 3;
				uslovie_bool[2] = a.allcountries[140].stab == 0;
				uslovie_text[2] = " 尚 未 支 持 反 对 派";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
				uslovie_bool[0] = GlobalScript.inst.gameState.science[20];
				uslovie_text[0] = " 科 技 《 新 式 间 谍 装 备 》 研 发 完 毕";
				return;
			}
			if (this_type == 1028)
			{
				this_opis = " 支 持 南 方 解 放 军 中 的 墨 西 哥 共 产 党";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[145].cw;
				uslovie_text[0] = " 尚 未 支 持 任 一 左 翼 激 进 派";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
				uslovie_bool[2] = a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0;
				uslovie_text[2] = " 我 国 为 社 会 主 义";
				uslovie_bool[3] = (a.data[60] == 0 || a.data[60] == 3) && a.allcountries[20].proprc;
				uslovie_text[3] = " 我 们 未 与 霍 查 决 裂";
				return;
			}
			if (this_type == 1029)
			{
				this_opis = " 支 持 南 方 解 放 军 中 的 墨 西 哥 无 产 阶 级 革 命 党";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[145].cw;
				uslovie_text[0] = " 尚 未 支 持 任 一 左 翼 激 进 派";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
				uslovie_bool[2] = a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0;
				uslovie_text[2] = " 我 国 为 社 会 主 义";
				uslovie_bool[3] = a.modifies[6].active;
				uslovie_text[3] = " 我 们 仍 信 奉 毛 主 义";
				return;
			}
			if (this_type == 1030)
			{
				this_opis = " 支 持 南 方 解 放 军 中 的 墨 西 哥 统 一 社 会 党";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[145].cw;
				uslovie_text[0] = " 尚 未 支 持 任 一 左 翼 激 进 派";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
				uslovie_bool[2] = a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0;
				uslovie_text[2] = " 我 国 为 社 会 主 义";
				uslovie_bool[3] = a.relres;
				uslovie_text[3] = " 我 国 与 苏 联 有 友 好 关 系";
				return;
			}
			if (this_type == 1031)
			{
				this_opis = " 支 持 南 方 解 放 军 中 的 革 命 工 人 党";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[145].cw;
				uslovie_text[0] = " 尚 未 支 持 任 一 左 翼 激 进 派";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5";
				uslovie_bool[2] = a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0;
				uslovie_text[2] = " 我 国 为 社 会 主 义";
				uslovie_bool[3] = a.allcountries[1].SubGosstroy == 18 && a.modifies[49].active;
				uslovie_text[3] = " 我 国 为 托 洛 茨 基 主 义 且 加 入 了 第 四 国 际";
				return;
			}
			if (this_type == 1032)
			{
				if (selected_country == 125)
				{
					this_opis = " 我 们 已 经 有 了 封 锁 马 拉 维 能 力 ， 是 时 候 推 翻 这 个 小 号 反 共 堡 垒 了";
					number_uslovie = 4;
					uslovie_bool[0] = a.event_done[500];
					uslovie_text[0] = " 非 洲 联 盟 已 成 立";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万";
					uslovie_bool[2] = a.allcountries[127].proprc && a.IsSocialism(yes: true, 127) && a.allcountries[124].proprc && a.IsSocialism(yes: true, 124) && a.allcountries[122].proprc && a.IsSocialism(yes: true, 122) && a.allcountries[126].proprc && a.IsSocialism(yes: true, 126);
					uslovie_text[2] = " 津 巴 布 韦 ， 赞 比 亚 ， 坦 桑 尼 亚 ， 莫 桑 比 克 均 亲 中 且 为 社 会 主 义";
					uslovie_bool[3] = !a.event_done[584];
					uslovie_text[3] = " 尚 未 封 锁";
				}
				if (selected_country == 119)
				{
					this_opis = " 帮 助 肯 尼 亚 社 会 主 义 者 组 建 新 党";
					number_uslovie = 2;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 30;
					uslovie_text[0] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 3";
					uslovie_bool[1] = !a.allcountries[119].cw;
					uslovie_text[1] = " 尚 未 重 组";
				}
				if (selected_country == 108)
				{
					this_opis = " 埃 亚 德 马 需 要 对 自 己 的 身 份 有 点 认 识";
					number_uslovie = 3;
					uslovie_bool[0] = a.allcountries[62].proprc && a.IsSocialism(yes: true, 62) && a.allcountries[63].proprc && (a.allcountries[63].Gosstroy == 1 || a.allcountries[63].SubGosstroy == 0);
					uslovie_text[0] = " 贝 宁 和 加 纳 愿 意 听 我 们 的 话 且 为 社 会 主 义";
					uslovie_bool[1] = a.influencePRC >= 300;
					uslovie_text[1] = " 国 际 影 响 力 超 过 30";
					uslovie_bool[2] = !a.event_done[593];
					uslovie_text[2] = " 尚 未 制 裁";
				}
				if (selected_country == 64)
				{
					this_opis = " 时 机 已 到 ， 该 敲 打 敲 打 他 了";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[68].proprc && a.allcountries[63].proprc && a.allcountries[61].proprc;
					uslovie_text[0] = " 几 内 亚 ， 布 基 纳 法 索 和 加 纳 亲 中";
					uslovie_bool[1] = a.influencePRC >= 300;
					uslovie_text[1] = " 国 际 影 响 力 超 过 30";
					uslovie_bool[2] = a.event_done[500];
					uslovie_text[2] = " 非 洲 联 盟 已 成 立";
					uslovie_bool[3] = !a.event_done[592];
					uslovie_text[3] = " 尚 未 制 裁";
					return;
				}
				if (selected_country == 56)
				{
					this_opis = " 给 尼 日 尔 掀 个 底 朝 天 ！";
					number_uslovie = 4;
					uslovie_bool[0] = a.IsSocialism(yes: true, 58) && a.IsSocialism(yes: true, 61) && a.IsSocialism(yes: true, 62) && a.allcountries[58].proprc && a.allcountries[61].proprc && a.allcountries[62].proprc;
					uslovie_text[0] = " 马 里 ， 布 基 纳 法 索 和 贝 宁 已 经 建 成 了 亲 中 社 会 主 义 政 权";
					uslovie_bool[1] = a.event_done[500];
					uslovie_text[1] = " 非 洲 联 盟 成 立";
					uslovie_bool[2] = a.data[22] >= 100;
					uslovie_text[2] = " 至 少 拥 有 10 军 力";
					uslovie_bool[3] = !a.event_done[606];
					uslovie_text[3] = " 尚 未 发 动 革 命";
				}
				if (selected_country == 112)
				{
					this_opis = " 时 机 已 到 ， 是 时 候 发 动 革 命 了";
					number_uslovie = 4;
					uslovie_bool[0] = a.resultOfEvents[597] == 1 && !GlobalScript.inst.gameState.allcountries[112].parts[1] && !GlobalScript.inst.gameState.ingamewars[52].is_going;
					uslovie_text[0] = " 塞 内 加 尔 在 冈 比 亚 战 争 中 失 败";
					uslovie_bool[1] = a.allcountries[112].level_of_unstab >= 1000;
					uslovie_text[1] = " 反 对 派 力 量 到 达100";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 100;
					uslovie_text[2] = " 至 少 拥 有10 百 万 预 算 、10 特 工 网 络 与 10 军 力";
					uslovie_bool[3] = !a.event_done[616];
					uslovie_text[3] = " 尚 未 发 动 革 命";
				}
				if (selected_country == 66)
				{
					this_opis = " 时 机 已 到 ， 是 时 候 发 动 一 场 起 义 了";
					number_uslovie = 4;
					uslovie_bool[0] = (a.IsSocialism(yes: true, 60) && a.allcountries[60].proprc) || (a.IsSocialism(yes: true, 57) && a.allcountries[57].proprc) || (a.IsSocialism(yes: true, 65) && a.allcountries[65].proprc) || (a.IsSocialism(yes: true, 52) && a.allcountries[52].proprc) || (a.IsSocialism(yes: true, 115) && a.allcountries[115].proprc) || (a.IsSocialism(yes: true, 116) && a.allcountries[116].proprc);
					uslovie_text[0] = " 喀 麦 隆 至 少 一 个 邻 国 为 亲 中 社 会 主 义 政 权";
					uslovie_bool[1] = a.allcountries[66].level_of_unstab >= 1000;
					uslovie_text[1] = " 喀 人 联 力 量 到 达100";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 100;
					uslovie_text[2] = " 至 少 拥 有10 特 工 网 络 与 10 军 力";
					uslovie_bool[3] = !a.event_done[617];
					uslovie_text[3] = " 尚 未 发 动 革 命";
				}
				if (selected_country == 116)
				{
					this_opis = " 对 加 蓬 进 行 封 锁";
					number_uslovie = 4;
					uslovie_bool[0] = a.IsSocialism(yes: true, 66) && a.allcountries[66].proprc && a.IsSocialism(yes: true, 52) && a.allcountries[52].proprc;
					uslovie_text[0] = " 喀 麦 隆 ， 刚 果 （ 布 ） 为 亲 中 社 会 主 义 政 权";
					uslovie_bool[1] = a.allcountries[116].cw;
					uslovie_text[1] = " 串 联 过 反 对 派";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 100;
					uslovie_text[2] = " 至 少 拥 有10 特 工 网 络 与 10 军 力";
					uslovie_bool[3] = !a.event_done[619];
					uslovie_text[3] = " 尚 未 封 锁";
				}
				if (selected_country == 115)
				{
					this_opis = " 对 赤 道 几 内 亚 进 行 特 别 解 放 行 动";
					number_uslovie = 4;
					uslovie_bool[0] = a.IsSocialism(yes: true, 66) && a.allcountries[66].proprc && a.IsSocialism(yes: true, 116) && a.allcountries[116].proprc;
					uslovie_text[0] = " 喀 麦 隆 ， 加 蓬 为 亲 中 社 会 主 义 政 权";
					uslovie_bool[1] = a.allcountries[116].okb && a.allcountries[66].okb && a.event_done[500];
					uslovie_text[1] = " 喀 麦 隆 ， 加 蓬 在 非 盟 中";
					uslovie_bool[2] = a.data[22] >= 100;
					uslovie_text[2] = " 至 少 拥 有10 军 力";
					uslovie_bool[3] = !a.event_done[620];
					uslovie_text[3] = " 尚 未 解 放";
				}
				if (selected_country == 59)
				{
					this_opis = " 敦 促 达 达 赫 政 府 加 大 社 会 主 义 改 革 力 度";
					number_uslovie = 4;
					uslovie_bool[0] = a.modifies[6].active;
					uslovie_text[0] = " 我 们 坚 持 战 无 不 胜 的 毛 泽 东 思 想";
					uslovie_bool[1] = a.event_done[500] && a.IsSocialism(yes: true, 54) && a.allcountries[54].proprc && a.IsSocialism(yes: true, 40) && a.allcountries[40].proprc && a.IsSocialism(yes: true, 58) && a.allcountries[58].proprc && a.IsSocialism(yes: true, 112) && a.allcountries[112].proprc;
					uslovie_text[1] = " 非 洲 联 盟 成 立 且 摩 洛 哥 、 阿 尔 及 利 亚 、 马 里 和 塞 内 加 尔 是 亲 中 的 社 会 主 义 国 家 ；";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 150 && a.data[9] >= 100;
					uslovie_text[2] = " 至 少15 百 万 预 算 与10 特 工 网 络";
					uslovie_bool[3] = !a.event_done[627];
					uslovie_text[3] = " 尚 未 敦 促";
				}
				if (selected_country == 154)
				{
					this_opis = " 支 持 人 民 的 斗 争";
					number_uslovie = 4;
					uslovie_bool[0] = a.event_done[629] && a.allcountries[159].puppetOf < 0;
					uslovie_text[0] = " 瓦 努 阿 图 已 独 立";
					uslovie_bool[1] = !a.allcountries[51].Torg;
					uslovie_text[1] = " 我 们 依 然 支 持 第 三 世 界 的 民 族 解 放 , 未 与 美 帝 国 主 义 眉 来 眼 去";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
					uslovie_text[2] = " 至 少5 百 万 预 算 与5 特 工 网 络";
					uslovie_bool[3] = !a.allcountries[154].cw;
					uslovie_text[3] = " 尚 未 支 持";
				}
				if (selected_country == 152)
				{
					this_opis = " 为 牙 买 加 送 去 援 助 ， 让 他 们 学 习 古 巴 经 验";
					number_uslovie = 3;
					uslovie_bool[0] = a.allcountries[138].proprc && a.IsSocialism(yes: true, 138);
					uslovie_text[0] = " 古 巴 为 亲 中 社 会 主 义 政 权";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
					uslovie_text[1] = " 至 少5 百 万 预 算";
					uslovie_bool[2] = !a.IsSocialism(yes: true, 152);
					uslovie_text[2] = " 尚 未 援 助";
				}
				return;
			}
			if (this_type == 1033)
			{
				this_opis = " 为 危 难 之 际 的 社 会 主 义 古 巴 送 上 我 们 的 支 持";
				number_uslovie = 3;
				uslovie_bool[0] = !a.allcountries[138].prosov && !a.allcountries[138].Vyshi && !a.allcountries[138].proprc;
				uslovie_text[0] = " 古 巴 中 立";
				uslovie_bool[1] = a.influencePRC > a.empires[1].power;
				uslovie_text[1] = " 中 国 影 响 力 大 于 苏 联";
				uslovie_bool[2] = !a.event_done[591];
				uslovie_text[2] = " 尚 未 支 持";
				return;
			}
			if (this_type == 1034)
			{
				this_opis = " 协 助 美 国 入 侵 古 巴";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[48].Vyshi;
				uslovie_text[0] = " 格 林 纳 达 亲 美";
				uslovie_bool[1] = a.allcountries[1].isSEATO;
				uslovie_text[1] = " 中 国 与 美 国 在 同 一 阵 容 内";
				uslovie_bool[2] = a.data[8] + a.data[36] >= 150 && a.data[9] >= 150 && a.data[22] >= 150;
				uslovie_text[2] = " 预 算 不 少 于 15百 万 ，特 工 网 络 不 少 于 15 ， 军 力 不 少 于15";
				uslovie_bool[3] = !a.allcountries[138].cw;
				uslovie_text[3] = " 尚 未 策 划 入 侵";
				return;
			}
			if (this_type == 1035)
			{
				this_opis = " 督 促 吉 布 提 加 入 非 洲 之 角 联 邦";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[41].parts[0] && a.allcountries[41].SubGosstroy == 17;
				uslovie_text[0] = " 非 洲 之 角 已 成 立";
				uslovie_bool[1] = a.allcountries[106].Gosstroy == 1 || a.allcountries[106].SubGosstroy == 0;
				uslovie_text[1] = " 吉 布 提 为 社 会 主 义";
				uslovie_bool[2] = a.data[8] + a.data[36] >= 100;
				uslovie_text[2] = " 预 算 不 少 于 10百 万 ";
				uslovie_bool[3] = !a.allcountries[41].parts[1];
				uslovie_text[3] = " 尚 未 推 动 合 并";
				return;
			}
			if (this_type == 1036)
			{
				int num3 = 0;
				for (int k = 71; k < 84; k++)
				{
					if (a.allcountries[k].proprc)
					{
						num3++;
					}
				}
				this_opis = " 煽 动 当 地 推 翻 政 府";
				number_uslovie = 4;
				uslovie_bool[0] = num3 >= 5;
				uslovie_text[0] = " 南 美 洲 至 少 有 五 个 亲 中 国 家";
				uslovie_bool[1] = a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0;
				uslovie_text[1] = " 我 们 为 社 会 主 义";
				uslovie_bool[2] = a.data[8] + a.data[36] >= 100;
				uslovie_text[2] = " 预 算 不 少 于 10百 万 ";
				uslovie_bool[3] = !a.allcountries[selected_country].proprc;
				uslovie_text[3] = " 尚 未 煽 动";
				return;
			}
			if (this_type == 1037)
			{
				if (!a.allcountries[selected_country].cw)
				{
					this_opis = " 为 阿 扎 尼 亚 大 会 的 革 命 根 据 地 提 供 物 资";
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 100 && a.data[8] + a.data[36] >= 100;
					uslovie_text[0] = " 至 少 10 特 工 网 络 和 10 百 万 预 算";
					uslovie_bool[1] = a.data[6] > 790;
					uslovie_text[1] = " 国 际 声 誉 高 于 7 9";
					uslovie_bool[2] = a.allcountries[127].proprc;
					uslovie_text[2] = "津 巴 布 韦 亲 华";
					uslovie_bool[3] = !a.allcountries[selected_country].cw;
					uslovie_text[3] = " 尚 未 支 援";
				}
				else
				{
					this_opis = " 帮 助 阿 扎 尼 亚 大 会 内 的 毛 主 义 派 系 掌 权";
					number_uslovie = 4;
					uslovie_bool[0] = a.data[9] >= 100 && a.data[22] >= 100 && a.data[8] + a.data[36] >= 50;
					uslovie_text[0] = " 至 少 10 特 工 网 络 、10 军 事 力 量 和 5 百 万 预 算";
					uslovie_bool[1] = a.data[6] > 790 && a.modifies[6].active;
					uslovie_text[1] = " 国 际 声 誉 高 于 7 9 且 坚 持 毛 泽 东 思 想";
					uslovie_bool[2] = a.data[21] < 1981;
					uslovie_text[2] = " 1981年 前";
					uslovie_bool[3] = a.allcountries[153].Gosstroy == 0;
					uslovie_text[3] = " 尚 未 帮 助";
				}
				return;
			}
			if (this_type == 1038)
			{
				this_opis = "  推 翻 斯 威 士 兰 君 主 制 政 权";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 100 && a.data[22] >= 100 && a.data[8] + a.data[36] >= 100;
				uslovie_text[0] = " 至 少 10 特 工 网 络 、10 军 事 力 量 和 10 百 万 预 算";
				uslovie_bool[1] = a.data[6] > 790;
				uslovie_text[1] = " 国 际 声 誉 高 于 7 9";
				uslovie_bool[2] = a.allcountries[126].proprc && a.allcountries[131].SubGosstroy != 7 && a.allcountries[131].SubGosstroy != 9;
				uslovie_text[2] = " 南 非 种 族 隔 离 政 权 垮 台 且 莫 桑 比 克 亲 中";
				uslovie_bool[3] = !a.allcountries[selected_country].cw;
				uslovie_text[3] = " 尚 未 推 翻";
				return;
			}
			if (this_type == 1039)
			{
				this_opis = "  支 持 左 翼";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 100 && a.data[22] >= 100 && a.data[8] + a.data[36] >= 100;
				uslovie_text[0] = " 至 少 10 特 工 网 络 、10 军 事 力 量 和 10 百 万 预 算";
				uslovie_bool[1] = a.data[6] > 790;
				uslovie_text[1] = " 国 际 声 誉 高 于 7 9";
				uslovie_bool[2] = a.allcountries[153].parts[0];
				uslovie_text[2] = " 纳 米 比 亚 已 独 立";
				uslovie_bool[3] = a.allcountries[selected_country].Gosstroy == 2;
				uslovie_text[3] = " 尚 未 支 持";
				return;
			}
			if (this_type == 1040)
			{
				this_opis = "  支 持 右 翼";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[9] >= 100 && a.data[22] >= 100 && a.data[8] + a.data[36] >= 100;
				uslovie_text[0] = " 至 少 10 特 工 网 络 、10 军 事 力 量 和 10 百 万 预 算";
				uslovie_bool[1] = a.data[6] > 790;
				uslovie_text[1] = " 国 际 声 誉 高 于 7 9";
				uslovie_bool[2] = a.allcountries[153].parts[0];
				uslovie_text[2] = " 纳 米 比 亚 已 独 立";
				uslovie_bool[3] = a.allcountries[selected_country].Gosstroy == 2;
				uslovie_text[3] = " 尚 未 支 持";
				return;
			}
			if (this_type == 1041)
			{
				this_opis = " 蒙 博 托 坐 的 太 久 了 ， 我 们 将 帮 助 刚 果 人 民 换 一 位 领 袖";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[1].Gosstroy == 3;
				uslovie_text[0] = " 我 们 顺 应 了 时 代 潮 流 成 为 自 由 世 界 的 一 员";
				uslovie_bool[1] = a.allcountries[117].Torg;
				uslovie_text[1] = " 我 们 还 没 有 和 蒙 博 托 撕 破 脸";
				uslovie_bool[2] = a.resultOfEvents[613] == 0;
				uslovie_text[2] = " UDPS 被 建 立 起 来 了 ";
				uslovie_bool[3] = a.allcountries[selected_country].Gosstroy == 3;
				uslovie_text[3] = " 尚 未 支 持";
				return;
			}
			if (this_type == 1042)
			{
				this_opis = " 蒙 博 托 坐 的 太 久 了 ， 我 们 将 帮 助 刚 果 人 民 换 一 位 领 袖";
				number_uslovie = 4;
				uslovie_bool[0] = a.data[21] >= 1983;
				uslovie_text[0] = " 1 9 8 3 年 以 后";
				uslovie_bool[1] = a.allcountries[122].proprc && a.allcountries[124].proprc && a.allcountries[120].proprc && a.allcountries[118].proprc && a.allcountries[123].proprc && a.allcountries[52].proprc;
				uslovie_text[1] = " 赞 比 亚 ， 坦 桑 尼 亚 ， 卢 旺 达 ， 安 哥 拉 ， 刚 果 布 与 乌 干 达 亲 中";
				uslovie_bool[2] = a.data[9] >= 100 && a.data[22] >= 200;
				uslovie_text[2] = " 至 少 10 特 工 网 络 和 20 军 事 力 量";
				uslovie_bool[3] = !a.event_done[612];
				uslovie_text[3] = " 尚 未 掀 起 革 命";
				return;
			}
			if (this_type == 1043)
			{
				if (selected_country == 126)
				{
					this_opis = " 为 莫 桑 比 克 解 放 阵 线 送 去 援 助|控 制 度 ：" + a.allcountries[126].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[126].level_of_unstab % 10);
					number_uslovie = 4;
					uslovie_bool[0] = a.data[6] >= 790;
					uslovie_text[0] = " 国 际 声 望 高 于 7 9";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[22] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，军 力 不 少 于 5";
					uslovie_bool[2] = a.allcountries[126].level_of_unstab > 0 && a.allcountries[126].level_of_unstab < 1000;
					uslovie_text[2] = " 控 制 度 低 于100 %且 不 为 0";
					uslovie_bool[3] = !a.allcountries[126].cw;
					uslovie_text[3] = " 半 年 内 尚 未 支 持 任 一 派 系";
				}
				else if (selected_country == 59)
				{
					this_opis = " 和 摩 洛 哥 一 起 为 达 达 赫 总 统 组 织 的 毛 里 塔 尼 亚 民 主 联 盟 的 打 入 行 动 提 供 助 力 ， 促 使 军 政 府 内 形 成 毛 里 塔 尼 亚 民 主 联 盟 多 数 格 局 ， 以 恢 复 多 党 民 主";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[54].Torg || ((a.allcountries[54].Gosstroy == 3 || a.allcountries[54].SubGosstroy == 11) && a.allcountries[54].proprc);
					uslovie_text[0] = " 我 们 与 自 由 的 摩 洛 哥 有 密 切 联 系";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[1] = " 预 算 不 少 于 10百 万 ，特 工 网 络 不 少 于 10";
					uslovie_bool[2] = (a.data[21] >= 1980 && a.data[20] >= 5) || a.data[21] >= 1981;
					uslovie_text[2] = " 进 入 1 9 8 0 年 5 月 及 以 后";
					uslovie_bool[3] = !a.allcountries[59].cw;
					uslovie_text[3] = " 没 有 联 络 过 其 他 反 对 派";
				}
				else if (selected_country == 129)
				{
					this_opis = " 我 们 将 在 社 会 主 义 和 独 立 的 大 旗 下 组 建 博 茨 瓦 纳 争 取 社 会 主 义 运 动";
					number_uslovie = 2;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 80 && a.data[9] >= 30;
					uslovie_text[0] = " 预 算 不 少 于 8百 万 ，特 工 网 络 不 少 于 3";
					uslovie_bool[1] = a.allcountries[129].level_of_unstab < 200;
					uslovie_text[1] = " 尚 未 完 全 促 成 团 结";
				}
				else if (selected_country == 159)
				{
					this_opis = " 邀 请 该 党 领 导 人 沃 尔 特 · 利 尼 前 来 我 国 学 习 建 党 经 验";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[1].Gosstroy == 2 || a.IsSocialism(yes: true, 1);
					uslovie_text[0] = " 我 们 是 社 会 主 义 或 改 良 主 义";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ";
					uslovie_bool[2] = a.data[21] >= 1977 && ((a.data[21] <= 1980 && a.data[20] <= 6 && a.data[19] <= 30) || (a.data[21] <= 1980 && a.data[20] <= 5) || a.data[21] <= 1979);
					uslovie_text[2] = " 不 早 于1977 年1 月 ， 不 晚 于1980 年6 月30 日";
					uslovie_bool[3] = a.allcountries[159].level_of_unstab <= 0;
					uslovie_text[3] = " 尚 未 邀 请";
				}
				else if (selected_country == 149)
				{
					if (a.allcountries[149].Gosstroy != 0 && a.allcountries[149].Gosstroy != 3)
					{
						this_opis = " 镇 压 右 翼 叛 乱|控 制 度 ：" + a.allcountries[149].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[149].level_of_unstab % 10);
						number_uslovie = 3;
						uslovie_bool[0] = a.allcountries[149].proprc || a.allcountries[149].prosov;
						uslovie_text[0] = " 危 地 马 拉 为 亲 中 或 亲 苏 政 权";
						uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
						uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5 ， 军 事 力 量 不 少 于5 ";
						uslovie_bool[2] = !a.allcountries[149].cw;
						uslovie_text[2] = " 半 年 一 次";
					}
					else
					{
						this_opis = " 支 持 左 翼 游 击 队|控 制 度 ：" + a.allcountries[149].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[149].level_of_unstab % 10);
						number_uslovie = 4;
						uslovie_bool[0] = a.IsSocialism(yes: true, 1);
						uslovie_text[0] = " 我 们 是 社 会 主 义";
						uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
						uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5 ， 军 事 力 量 不 少 于5 ";
						uslovie_bool[2] = a.allcountries[147].proprc || a.allcountries[147].prosov;
						uslovie_text[2] = " 尼 加 拉 瓜 为 亲 中 或 亲 苏 政 权";
						uslovie_bool[3] = !a.allcountries[149].cw;
						uslovie_text[3] = " 半 年 一 次";
					}
				}
				else if (selected_country == 147)
				{
					if (!a.IsAuthoritarianism(selected_country) && a.allcountries[selected_country].Gosstroy != 3)
					{
						this_opis = " 自 由 祖 国 或 死 亡 ！|控 制 度 ：" + a.allcountries[selected_country].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].level_of_unstab % 10);
						number_uslovie = 3;
						uslovie_bool[0] = a.allcountries[selected_country].proprc || a.allcountries[selected_country].prosov;
						uslovie_text[0] = " 尼 加 拉 瓜 为 亲 中 或 亲 苏 政 权";
						uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
						uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5 ， 军 事 力 量 不 少 于5 ";
						uslovie_bool[2] = !a.allcountries[147].cw;
						uslovie_text[2] = " 半 年 一 次";
					}
					else
					{
						this_opis = " 支 持 桑 地 诺 人 民 革 命|控 制 度 ：" + a.allcountries[selected_country].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].level_of_unstab % 10);
						number_uslovie = 3;
						uslovie_bool[0] = a.IsSocialism(yes: true, 1);
						uslovie_text[0] = " 我 们 是 社 会 主 义";
						uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
						uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5 ， 军 事 力 量 不 少 于5 ";
						uslovie_bool[2] = !a.allcountries[selected_country].cw;
						uslovie_text[2] = " 半 年 一 次";
					}
				}
				return;
			}
			if (this_type == 1044)
			{
				if (selected_country == 126)
				{
					this_opis = " 为 莫 桑 比 克 全 国 抵 抗 运 动 送 去 援 助|控 制 度 ：" + a.allcountries[126].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[126].level_of_unstab % 10);
					number_uslovie = 4;
					uslovie_bool[0] = a.resultOfEvents[623] == 1;
					uslovie_text[0] = " 已 与 莫 抵 运 取 得 联 系";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[22] >= 50 && a.data[9] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，军 力 不 少 于 5 ，特 工 网 络 不 少 于 5";
					uslovie_bool[2] = a.allcountries[126].level_of_unstab > 0 && a.allcountries[126].level_of_unstab < 1000;
					uslovie_text[2] = " 控 制 度 高 于 0且 不 为 100 %";
					uslovie_bool[3] = !a.allcountries[126].cw;
					uslovie_text[3] = " 半 年 内 尚 未 支 持 任 一 派 系";
				}
				else if (selected_country == 59)
				{
					this_opis = " 和 利 比 亚 一 起 为 卡 扎 菲 主 义 者 的 打 入 行 动 提 供 助 力 ， 促 使 军 政 府 内 形 成 卡 扎 菲 主 义 者 多 数 格 局 ， 以 输 出 民 众 革 命";
					number_uslovie = 4;
					uslovie_bool[0] = (a.allcountries[13].SubGosstroy == 15 || a.allcountries[13].SubGosstroy == 10) && a.allcountries[13].Torg;
					uslovie_text[0] = " 利 比 亚 是 卡 扎 菲 执 政 ， 且 支 持 过 利 比 亚";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[1] = " 预 算 不 少 于 10百 万 ，特 工 网 络 不 少 于 10";
					uslovie_bool[2] = a.data[21] >= 1980;
					uslovie_text[2] = " 进 入 1 9 8 0 年 后";
					uslovie_bool[3] = !a.allcountries[59].cw;
					uslovie_text[3] = " 没 有 联 络 过 其 他 反 对 派";
				}
				else if (selected_country == 129)
				{
					int num4 = 0;
					if (a.IsSocialism(yes: true, 127))
					{
						num4++;
					}
					if (a.IsSocialism(yes: true, 131))
					{
						num4++;
					}
					if (a.IsSocialism(yes: true, 124))
					{
						num4++;
					}
					if (a.IsSocialism(yes: true, 123))
					{
						num4++;
					}
					this_opis = " 我 们 将 在 博 茨 瓦 纳 周 边 开 设 训 练 营 地";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[22] >= 50 && a.data[9] >= 50;
					uslovie_text[0] = " 特 工 网 络 不 少 于 5 ，军 事 力 量 不 少 于 5";
					uslovie_bool[1] = num4 >= 2;
					uslovie_text[1] = " 博 茨 瓦 纳 有 两 个 邻 国 为 亲 中 社 会 主 义 政 权";
					uslovie_bool[2] = !a.allcountries[129].cw;
					uslovie_text[2] = " 尚 未 训 练";
				}
				else if (selected_country == 159)
				{
					this_opis = " 为 利 尼 的 党 提 供 经 济 支 持";
					number_uslovie = 2;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 100;
					uslovie_text[0] = " 预 算 不 少 于 10百 万 ";
					uslovie_bool[1] = !a.allcountries[159].cw;
					uslovie_text[1] = " 没 有 联 络 过 其 他 反 对 派";
				}
				else if (selected_country == 149)
				{
					this_opis = " 镇 压 左 翼 叛 乱|控 制 度 ：" + a.allcountries[149].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[149].level_of_unstab % 10);
					number_uslovie = 3;
					uslovie_bool[0] = !a.IsSocialism(yes: true, 1);
					uslovie_text[0] = " 我 们 不 是 社 会 主 义";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5 ， 军 事 力 量 不 少 于5 ";
					uslovie_bool[2] = !a.allcountries[149].cw;
					uslovie_text[2] = " 半 年 一 次";
				}
				else if (selected_country == 147)
				{
					this_opis = " 上 帝 ， 祖 国 ， 民 主 。|控 制 度 ：" + a.allcountries[selected_country].level_of_unstab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].level_of_unstab % 10);
					number_uslovie = 4;
					uslovie_bool[0] = !a.IsSocialism(yes: true, 1);
					uslovie_text[0] = " 我 们 不 是 社 会 主 义";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ，特 工 网 络 不 少 于 5 ， 军 事 力 量 不 少 于5 ";
					uslovie_bool[2] = a.IsSocialism(yes: true, selected_country) || a.allcountries[selected_country].Gosstroy == 2;
					uslovie_text[2] = " 尼 加 拉 瓜 为 社 会 主 义 或 改 良 主 义 政 体";
					uslovie_bool[3] = !a.allcountries[147].cw;
					uslovie_text[3] = " 半 年 一 次";
				}
				return;
			}
			if (this_type == 1045)
			{
				if (selected_country == 126)
				{
					this_opis = " 组 织 非 洲 联 合 革 命 治 安 军 帮 助 莫 解 阵";
					number_uslovie = 3;
					uslovie_bool[0] = a.event_done[500];
					uslovie_text[0] = " 非 洲 联 盟 已 建 立";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 100 && a.data[22] >= 100;
					uslovie_text[1] = " 预 算 不 少 于 10百 万 ，军 力 不 少 于 10";
					uslovie_bool[2] = a.allcountries[126].level_of_unstab > 0 && a.allcountries[126].level_of_unstab < 1000;
					uslovie_text[2] = " 控 制 度 高 于 0且 不 为 100 %";
				}
				else if (selected_country == 59)
				{
					this_opis = " 和 伊 拉 克 一 起 为 复 兴 党 的 打 入 行 动 提 供 助 力 ， 促 使 军 政 府 内 形 成 复 兴 党 多 数 格 局 ， 以 助 力 泛 阿 拉 伯 事 业";
					number_uslovie = 3;
					uslovie_bool[0] = (a.allcountries[14].SubGosstroy == 15 || a.allcountries[14].SubGosstroy == 10) && a.allcountries[14].proprc;
					uslovie_text[0] = " 伊 拉 克 复 兴 党 政 权 存 在 且 亲 中";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100;
					uslovie_text[1] = " 预 算 不 少 于 10百 万 ，特 工 网 络 不 少 于 10";
					uslovie_bool[2] = !a.allcountries[59].cw;
					uslovie_text[2] = " 没 有 联 络 过 其 他 反 对 派";
				}
				else if (selected_country == 129)
				{
					this_opis = " 吉 时 已 到 ， 是 时 候 开 展 行 动 了";
					number_uslovie = 3;
					uslovie_bool[0] = a.data[22] >= 100;
					uslovie_text[0] = " 特 工 网 络 不 少 于 10";
					uslovie_bool[1] = a.allcountries[129].level_of_unstab > 0;
					uslovie_text[1] = " 该 国 左 派 已 统 一";
					uslovie_bool[2] = !a.event_done[628];
					uslovie_text[2] = " 尚 未 起 义";
				}
				else if (selected_country == 159)
				{
					this_opis = " 在 瓦 努 阿 图 为FLNKS 提 供 帮 助";
					number_uslovie = 3;
					uslovie_bool[0] = a.allcountries[154].cw;
					uslovie_text[0] = " F L N K S 已 组 建";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 100;
					uslovie_text[1] = " 预 算 不 少 于 5百 万 ， 特 工 网 络 不 少 于10";
					uslovie_bool[2] = a.allcountries[154].level_of_unstab <= 0;
					uslovie_text[2] = " 尚 未 提 供 帮 助";
				}
				else if (selected_country == 149)
				{
					this_opis = " 危 地 马 拉 ， 一 寸 也 不 能 少 ！";
					number_uslovie = 4;
					uslovie_bool[0] = a.allcountries[149].proprc || a.allcountries[149].prosov;
					uslovie_text[0] = " 危 地 马 拉 为 亲 中 或 亲 苏 政 权";
					uslovie_bool[1] = a.BritLost;
					uslovie_text[1] = " 英 国 输 掉 了 马 岛 战 争 ";
					uslovie_bool[2] = a.data[22] >= 80;
					uslovie_text[2] = " 军 事 力 量 不 少 于 8";
					uslovie_bool[3] = !a.event_done[634];
					uslovie_text[3] = " 尚 未 收 复";
				}
				return;
			}
			if (this_type == 1046)
			{
				this_opis = " 支 持 左 派 对 新 喀 里 多 尼 亚 政 府 的 全 面 夺 权";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[154].cw && a.allcountries[154].level_of_unstab > 0;
				uslovie_text[0] = " 已 组 建 并 支 持 F L N K S";
				uslovie_bool[1] = a.data[22] >= 100 && a.data[9] >= 100;
				uslovie_text[1] = " 军 事 力 量 不 少 于 10 ， 特 工 网 络 不 少 于10";
				uslovie_bool[2] = a.data[21] >= 1984;
				uslovie_text[2] = " 不 早 于1984 年";
				uslovie_bool[3] = !a.event_done[630];
				uslovie_text[3] = " 尚 未 发 动 起 义";
				return;
			}
			if (this_type == 1047)
			{
				this_opis = " 支 持 安 哥 拉 国 内 的 左 派 发 动 政 变 ， 借 此 夺 取 安 人 运 内 部 领 导 权";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[9] >= 100;
				uslovie_text[0] = " 特 工 网 络 不 少 于10";
				uslovie_bool[1] = a.data[21] < 1978;
				uslovie_text[1] = "  早 于1978 年";
				uslovie_bool[2] = a.allcountries[123].level_of_unstab == 0;
				uslovie_text[2] = " 尚 未 支 持";
				return;
			}
			if (this_type == 1048)
			{
				this_opis = " 支 持 安 人 运 内 的 “ 强 硬 派 ” 夺 权";
				number_uslovie = 3;
				uslovie_bool[0] = a.data[9] >= 100;
				uslovie_text[0] = " 特 工 网 络 不 少 于10";
				uslovie_bool[1] = a.data[21] < 1978;
				uslovie_text[1] = "  早 于1978 年";
				uslovie_bool[2] = a.allcountries[123].level_of_unstab == 0;
				uslovie_text[2] = " 尚 未 支 持";
				return;
			}
			if (this_type == 1049)
			{
				this_opis = " 我 们 已 经 做 好 入 局 安 哥 拉 的 准 备 了";
				number_uslovie = 2;
				uslovie_bool[0] = (a.data[21] >= 1979 && a.data[20] >= 9 && a.data[19] >= 10) || (a.data[21] >= 1979 && a.data[20] >= 10) || a.data[21] >= 1980;
				uslovie_text[0] = " 1979年9月10日以后";
				uslovie_bool[1] = !a.event_done[638];
				uslovie_text[1] = " 尚 未 决 定 ";
				return;
			}
			if (this_type == 1050)
			{
				if (selected_country == 161)
				{
					this_opis = " 从 所 罗 门 群 岛 全 国 工 人 联 盟 中 吸 纳 支 持 者 ， 复 兴 马 西 纳 运 动 ， 彻 底 打 倒 殖 民 主 义 ！";
					number_uslovie = 4;
					uslovie_bool[0] = (a.IsSocialism(yes: true, 159) || a.allcountries[159].Gosstroy == 2) && a.allcountries[154].puppetOf < 0 && (a.IsSocialism(yes: true, 135) || a.allcountries[135].Gosstroy == 2) && a.allcountries[135].SubGosstroy != 8;
					uslovie_text[0] = " 利 尼 在 瓦 努 阿 图 掌 权 ， 新 喀 里 多 尼 亚 已 解 放 ，澳 大 利 亚 是 社 会 主 义 或 改 良 主 义 政 体 且 不 为 左 倾 保 守 主 义";
					uslovie_bool[1] = a.influencePRC >= 800;
					uslovie_text[1] = "国 际 影 响 力 高 于 80";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
					uslovie_text[2] = " 至 少 2 0 百 万 预 算 和 2 0 特 工 网 络";
					uslovie_bool[3] = !a.allcountries[selected_country].cw;
					uslovie_text[3] = "  没 有 支 持 过";
				}
				else if (selected_country == 160)
				{
					this_opis = " 支 持 全 国 联 邦 党 和 斐 济 工 会 大 会 成 立 联 合 政 府";
					number_uslovie = 4;
					uslovie_bool[0] = a.IsSocialism(yes: true, 159) || a.allcountries[159].Gosstroy == 2;
					uslovie_text[0] = " 利 尼 在 瓦 努 阿 图 掌 权 ";
					uslovie_bool[1] = a.influencePRC >= 800;
					uslovie_text[1] = "国 际 影 响 力 高 于 80";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
					uslovie_text[2] = " 至 少 2 0 百 万 预 算 和 2 0 特 工 网 络";
					uslovie_bool[3] = !a.event_done[639];
					uslovie_text[3] = "  没 有 支 持 过";
				}
				return;
			}
			if (this_type == 1051)
			{
				if (selected_country == 161)
				{
					this_opis = " 为 所 罗 门 群 岛 当 地 政 府 送 去 援 助 ， 我 们 能 开 出 比 台 湾 当 局 更 高 的 价 格 … …";
					number_uslovie = 4;
					uslovie_bool[0] = a.IsSocialism(yes: true, 159) || a.allcountries[159].Gosstroy == 2 || a.allcountries[154].proprc || a.allcountries[135].proprc || a.allcountries[136].proprc;
					uslovie_text[0] = " 利 尼 在 瓦 努 阿 图 掌 权 或 我 们 在 大 洋 洲 有 势 力 存 在 ";
					uslovie_bool[1] = !a.allcountries[135].Vyshi && !a.IsAuthoritarianism(135) && a.allcountries[135].SubGosstroy != 8;
					uslovie_text[1] = "澳 大 利 亚 不 亲 美 ， 不 为 威 权 主 义 和 左 倾 保 守 主 义";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
					uslovie_text[2] = " 至 少 2 0 百 万 预 算 和 2 0 特 工 网 络";
					uslovie_bool[3] = !a.allcountries[selected_country].Torg;
					uslovie_text[3] = "  没 有 支 持 过";
				}
				else if (selected_country == 160)
				{
					this_opis = " 支 持 斐 济 国 王 的 后 裔 乔 治 · 卡 达 武 莱 武 · 卡 科 鲍 阁 下 重 建 斐 济 王 国";
					number_uslovie = 4;
					uslovie_bool[0] = !a.allcountries[135].Vyshi;
					uslovie_text[0] = " 澳 大 利 亚 不 亲 美 ";
					uslovie_bool[1] = a.IsAuthoritarianism(1);
					uslovie_text[1] = "中 国 是 威 权 主 义";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
					uslovie_text[2] = " 至 少 2 0 百 万 预 算 和 2 0 特 工 网 络";
					uslovie_bool[3] = a.allcountries[160].Gosstroy != 0 || !a.allcountries[160].proprc;
					uslovie_text[3] = "  没 有 支 持 过";
				}
				return;
			}
			if (this_type == 1052)
			{
				if (selected_country == 9)
				{
					this_opis = " 对 蒙 古 进 行 特 别 军 事 行 动";
					number_uslovie = 3;
					uslovie_bool[0] = a.influencePRC > 1000 && a.empires[1].power < 150;
					uslovie_text[0] = " 中 国 影 响 力 大 于100 ， 苏 联 影 响 力 低 于15";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 200 && a.data[22] >= 800;
					uslovie_text[1] = " 至 少 2 0 百 万 预 算 和80 军 事 力 量";
					uslovie_bool[2] = a.allcountries[selected_country].puppetOf < 0 && !a.ingamewars[69].is_going;
					uslovie_text[2] = " 尚 未 入 侵 蒙 古";
				}
				else if (selected_country == 7)
				{
					this_opis = " 支 持 斐 济 国 王 的 后 裔 乔 治 · 卡 达 武 莱 武 · 卡 科 鲍 阁 下 重 建 斐 济 王 国";
					number_uslovie = 4;
					uslovie_bool[0] = !a.allcountries[135].Vyshi;
					uslovie_text[0] = " 澳 大 利 亚 不 亲 美 ";
					uslovie_bool[1] = a.IsAuthoritarianism(1);
					uslovie_text[1] = "中 国 是 威 权 主 义";
					uslovie_bool[2] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
					uslovie_text[2] = " 至 少 2 0 百 万 预 算 和 2 0 特 工 网 络";
					uslovie_bool[3] = a.allcountries[160].Gosstroy != 0 || !a.allcountries[160].proprc;
					uslovie_text[3] = "  没 有 支 持 过";
				}
				return;
			}
			if (this_type == 1053)
			{
				this_opis = " 整 合 塞 拉 利 昂 的 革 命 左 翼 ， 为 推 翻 政 府 做 准 备";
				number_uslovie = 4;
				uslovie_bool[0] = a.event_done[500];
				uslovie_text[0] = " 非 洲 联 盟 已 经 成 立 ";
				uslovie_bool[1] = a.data[21] >= 1982;
				uslovie_text[1] = "1982 年 后";
				uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[2] = " 至 少 5 百 万 预 算 和 5 特 工 网 络";
				uslovie_bool[3] = !a.allcountries[107].cw;
				uslovie_text[3] = " 尚 未 整 合";
				return;
			}
			if (this_type == 1054)
			{
				if (a.allcountries[60].cw)
				{
					this_opis = " 援 助 扬 塔 特 斯 尼|力 量 ：" + a.allcountries[60].prcpower;
					number_uslovie = 3;
					uslovie_bool[0] = !a.allcountries[60].based;
					uslovie_text[0] = " 一 年 二 次";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[1] = " 至 少 5 百 万 预 算 ， 5 特 工 网 络 和 5 军 力";
					uslovie_bool[2] = a.data[6] > 390 && a.data[6] < 800;
					uslovie_text[2] = " 国 际 声 誉 在 39 到 80 之 间";
				}
				else
				{
					this_opis = " 援 助 革 命 派|力 量 ：" + a.allcountries[60].prcpower;
					number_uslovie = 3;
					uslovie_bool[0] = !a.allcountries[60].based;
					uslovie_text[0] = " 一 年 二 次";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[1] = " 至 少 5 百 万 预 算 ， 5 特 工 网 络 和 5 军 力";
					uslovie_bool[2] = a.data[6] >= 690;
					uslovie_text[2] = " 国 际 声 誉 大 于 69";
				}
				return;
			}
			if (this_type == 1055)
			{
				if (a.allcountries[60].cw)
				{
					this_opis = " 发 动 圣 战";
					number_uslovie = 3;
					uslovie_bool[0] = a.allcountries[60].prcpower >= 100;
					uslovie_text[0] = " 力 量 大 于 100";
					uslovie_bool[1] = a.event_done[655];
					uslovie_text[1] = "尼 日 利 亚 选 举 已 经 尘 埃 落 地";
					uslovie_bool[2] = !a.event_done[657];
					uslovie_text[2] = " 尚 未 发 动";
					return;
				}
				int num5 = 0;
				for (int l = 0; l < a.allcountries.Length; l++)
				{
					if (a.IsSocialism(yes: true, l) && (l == 59 || l == 112 || l == 113 || l == 114 || l == 68 || l == 107 || l == 67 || l == 64 || l == 63 || l == 62 || l == 108 || l == 61 || l == 62 || l == 56 || l == 58))
					{
						num5++;
					}
				}
				this_opis = " 发 动 革 命";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[60].prcpower >= 100;
				uslovie_text[0] = " 力 量 大 于 100";
				uslovie_bool[1] = a.event_done[655];
				uslovie_text[1] = "尼 日 利 亚 选 举 已 经 尘 埃 落 地";
				uslovie_bool[2] = a.allcountries[60].Gosstroy != 2 && num5 >= 5;
				uslovie_text[2] = " 尼 日 利 亚 不 是 民 选 左 翼 政 府 且 西 非 至 少 有5 个 社 会 主 义 国 家";
				uslovie_bool[3] = !a.event_done[656];
				uslovie_text[3] = " 尚 未 发 动";
				return;
			}
			if (this_type == 1056)
			{
				this_opis = " 是 时 候 终 结 乍 得 的 乱 象 了 ！";
				number_uslovie = 4;
				uslovie_bool[0] = a.IsSocialism(yes: true, 56) && a.IsSocialism(yes: true, 13) && (a.IsSocialism(yes: true, 53) || a.IsSocialism(yes: true, 150)) && a.IsSocialism(yes: true, 65) && a.IsSocialism(yes: true, 66) && a.allcountries[56].okb && a.allcountries[13].okb && (a.allcountries[53].okb || a.allcountries[150].okb) && a.allcountries[65].okb && a.allcountries[66].okb && a.event_done[500];
				uslovie_text[0] = " 尼 日 尔 ， 利 比 亚 ， 苏 丹 ， 中 非 ， 喀 麦 隆 是 社 会 主 义 且 是 非 盟 成 员";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[22] >= 100;
				uslovie_text[1] = " 至 少 10 百 万 预 算 ，10 特 工 网 络 和 10 军 力";
				uslovie_bool[2] = a.IsSocialism(yes: true, 1);
				uslovie_text[2] = " 中 国 是 社 会 主 义 ";
				uslovie_bool[3] = !a.event_done[386];
				uslovie_text[3] = " 尚 未 发 动";
				return;
			}
			if (this_type == 1057)
			{
				if (GlobalScript.inst.gameState.resultOfEvents[659] == 1)
				{
					this_opis = " 在 内 战 中 支 持 乌 干 达 民 族 解 放 军 粉 碎 反 政 府 武 装|力 量 对 比 ： 政 府 军" + a.allcountries[118].inflNATO / 10 + "." + Mathf.Abs(a.allcountries[118].inflNATO % 10) + "全 国 抵 抗 军" + a.allcountries[118].inflCh / 10 + "." + Mathf.Abs(a.allcountries[118].inflCh % 10) + "阿 明 残 军" + a.allcountries[118].prcinfl / 10 + "." + Mathf.Abs(a.allcountries[118].prcinfl % 10) + "乌 干 达 自 由 军" + a.allcountries[118].sovinfl / 10 + "." + Mathf.Abs(a.allcountries[118].sovinfl % 10);
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[0] = " 至 少 5 百 万 预 算 ，5 特 工 网 络 和 5 军 力";
					uslovie_bool[1] = GlobalScript.inst.gameState.resultOfEvents[659] < 2;
					uslovie_text[1] = " 我 们 没 有 支 持 叛 乱 分 子";
					uslovie_bool[2] = !a.allcountries[118].cw;
					uslovie_text[2] = " 三 月 一 次";
				}
				if (GlobalScript.inst.gameState.resultOfEvents[659] == 2)
				{
					this_opis = " 支 持 穆 塞 韦 尼 和 他 在 卢 韦 罗 三 角 地 带 发 动 的 人 民 战 争|力 量 对 比 ： 政 府 军" + a.allcountries[118].inflNATO / 10 + "." + Mathf.Abs(a.allcountries[118].inflNATO % 10) + "全 国 抵 抗 军" + a.allcountries[118].inflCh / 10 + "." + Mathf.Abs(a.allcountries[118].inflCh % 10) + "阿 明 残 军" + a.allcountries[118].prcinfl / 10 + "." + Mathf.Abs(a.allcountries[118].prcinfl % 10) + "乌 干 达 自 由 军" + a.allcountries[118].sovinfl / 10 + "." + Mathf.Abs(a.allcountries[118].sovinfl % 10);
					number_uslovie = 4;
					uslovie_bool[0] = a.data[56] <= 1;
					uslovie_text[0] = " 极 左 至 保 守 派 主 导";
					uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[1] = " 至 少 5 百 万 预 算 ，5 特 工 网 络 和 5 军 力";
					uslovie_bool[2] = GlobalScript.inst.gameState.resultOfEvents[659] == 2;
					uslovie_text[2] = " 东 方 的 风 将 芥 菜 种 子 带 向 了 四 方 ";
					uslovie_bool[3] = !a.allcountries[118].cw;
					uslovie_text[3] = " 三 月 一 次";
				}
				if (GlobalScript.inst.gameState.resultOfEvents[659] == 3)
				{
					this_opis = " 与 扎 伊 尔 、 苏 丹 和 沙 特 一 道 向 前 乌 干 达 国 民 军 与 乌 干 达 民 族 拯 救 阵 线 提 供 支 持|力 量 对 比 ： 政 府 军" + a.allcountries[118].inflNATO / 10 + "." + Mathf.Abs(a.allcountries[118].inflNATO % 10) + "全 国 抵 抗 军" + a.allcountries[118].inflCh / 10 + "." + Mathf.Abs(a.allcountries[118].inflCh % 10) + "阿 明 残 军" + a.allcountries[118].prcinfl / 10 + "." + Mathf.Abs(a.allcountries[118].prcinfl % 10) + "乌 干 达 自 由 军" + a.allcountries[118].sovinfl / 10 + "." + Mathf.Abs(a.allcountries[118].sovinfl % 10);
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[0] = " 至 少 5 百 万 预 算 ，5 特 工 网 络 和 5 军 力";
					uslovie_bool[1] = GlobalScript.inst.gameState.allcountries[117].Torg;
					uslovie_text[1] = " 我 们 与 扎 伊 尔 有 贸 易";
					uslovie_bool[2] = !a.allcountries[118].cw;
					uslovie_text[2] = " 三 月 一 次";
				}
				if (GlobalScript.inst.gameState.resultOfEvents[659] == 4)
				{
					this_opis = " 支 持 乌 干 达 自 由 运 动 等 布 干 达 人 的 武 装 组 织|力 量 对 比 ： 政 府 军" + a.allcountries[118].inflNATO / 10 + "." + Mathf.Abs(a.allcountries[118].inflNATO % 10) + "全 国 抵 抗 军" + a.allcountries[118].inflCh / 10 + "." + Mathf.Abs(a.allcountries[118].inflCh % 10) + "阿 明 残 军" + a.allcountries[118].prcinfl / 10 + "." + Mathf.Abs(a.allcountries[118].prcinfl % 10) + "乌 干 达 自 由 军" + a.allcountries[118].sovinfl / 10 + "." + Mathf.Abs(a.allcountries[118].sovinfl % 10);
					number_uslovie = 3;
					uslovie_bool[0] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
					uslovie_text[0] = " 至 少 5 百 万 预 算 ，5 特 工 网 络 和 5 军 力";
					uslovie_bool[1] = a.data[56] > 1 && a.data[56] < 4;
					uslovie_text[1] = " 温 和 至 改 革 主 导";
					uslovie_bool[2] = !a.allcountries[118].cw;
					uslovie_text[2] = " 三 月 一 次";
				}
			}
			if (this_type == 1058)
			{
				this_opis = " 援 助 苏 丹 的 革 命 者 ， 伺 机 推 翻 尼 迈 里";
				number_uslovie = 3;
				uslovie_bool[0] = a.science[18];
				uslovie_text[0] = " 已 完 成 “ 加 强 军 备 开 发”";
				uslovie_bool[1] = a.data[22] >= 150;
				uslovie_text[1] = " 至 少 有 1 5 军 力";
				uslovie_bool[2] = !a.allcountries[53].cw;
				uslovie_text[2] = " 我 们 还 没 有 援 助 过 他 们";
			}
			if (this_type == 1059)
			{
				this_opis = " 和 伊 拉 克 人 合 作 ， 在 苏 丹 培 植 复 兴 主 义 者";
				number_uslovie = 4;
				uslovie_bool[0] = (a.allcountries[14].SubGosstroy == 10 || a.allcountries[14].Gosstroy == 2) && a.allcountries[14].proprc;
				uslovie_text[0] = " 萨 达 姆 未 被 推 翻 且 亲 中";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 至 少 有 5 百 万 预 算 和 5 特 工 网 络";
				uslovie_bool[2] = a.data[21] < 1983;
				uslovie_text[2] = " 早 于1983 年";
				uslovie_bool[3] = a.allcountries[53].prcinfl == 0;
				uslovie_text[3] = " 我 们 还 没 有 支 持 过 其 中 之 一";
			}
			if (this_type == 1060)
			{
				this_opis = " 联 络 苏 丹 境 内 的 亲 利 比 亚 势 力 ， 为 民 众 革 命 做 准 备";
				number_uslovie = 4;
				uslovie_bool[0] = a.allcountries[13].SubGosstroy == 10;
				uslovie_text[0] = " 卡 扎 菲 未 被 推 翻";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
				uslovie_text[1] = " 至 少 有 5 百 万 预 算 和 5 特 工 网 络";
				uslovie_bool[2] = a.data[21] < 1983;
				uslovie_text[2] = " 早 于1983 年";
				uslovie_bool[3] = a.allcountries[53].prcinfl == 0;
				uslovie_text[3] = " 我 们 还 没 有 支 持 过 其 中 之 一";
			}
			if (this_type == 1061)
			{
				this_opis = " 援 助 缅 甸 共 产 主 义 游 击 队|力量：" + a.allcountries[33].inflCh;
				number_uslovie = 3;
				uslovie_bool[0] = (a.modifies[6].active && a.IsSocialism(yes: true, 1)) || (a.resultOfEvents[662] == 4 && a.allcountries[1].SubGosstroy == 18);
				uslovie_text[0] = " 我 们 还 坚 持 输 出 革 命 的 方 针";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
				uslovie_text[1] = " 至 少 有 5 百 万 预 算 ， 5 特 工 网 络 和 5 军 事 力 量";
				uslovie_bool[2] = !a.allcountries[33].cw;
				uslovie_text[2] = " 每 年 一 次";
			}
			if (this_type == 1062)
			{
				this_opis = " 要 巴 拿 马 ， 不 要 第 五 十 二 颗 星 星 ！";
				number_uslovie = 4;
				uslovie_bool[0] = !a.allcountries[51].isNATO || (a.event_done[667] && !a.ingamewars[84].is_going && !a.allcountries[141].Vyshi);
				uslovie_text[0] = " 美 国 已 衰 落 或 遭 受 了 耻 辱 性 的 大 败";
				uslovie_bool[1] = a.influencePRC >= 5000;
				uslovie_text[1] = " 中 国 影 响 力 高 于500";
				uslovie_bool[2] = a.allcountries[141].proprc && a.allcountries[147].proprc && a.allcountries[75].proprc;
				uslovie_text[2] = " 巴 拿 马 ， 哥 伦 比 亚 和 尼 加 拉 瓜 亲 中";
				uslovie_bool[3] = !a.allcountries[141].cw;
				uslovie_text[3] = " 尚 未 接 管 运 河";
			}
			if (this_type == 1063)
			{
				this_opis = " 和 我 们 的 欧 洲 伙 伴 一 起 取 长 补 短";
				number_uslovie = 1;
				uslovie_bool[0] = !a.event_done[671];
				uslovie_text[0] = " 半 年 一 次";
			}
			if (this_type == 10000)
			{
				this_opis = " 再 次 协 商 重 建 第 四 国 际 事 宜";
				number_uslovie = 3;
				uslovie_bool[0] = a.event_done[407];
				uslovie_text[0] = " 已 宣 布 将 复 兴 第 四 国 际";
				uslovie_bool[1] = a.allcountries[1].Gosstroy == 1;
				uslovie_text[1] = " 我 国 体 制 为 社 会 主 义";
				uslovie_bool[2] = !a.modifies[49].active;
				uslovie_text[2] = " 还 未 重 建 第 四 国 际";
			}
		}
		else if (this_type == 2)
		{
			this_opis = "Начать операцию по захвату Гонконга и Макао";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[65] == 0;
			uslovie_text[0] = "Территории в иностранном владении";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = "В бюджете не менее 5 миллионов";
			uslovie_bool[2] = a.data[22] >= 100;
			uslovie_text[2] = "Сила армии не менее 10";
			uslovie_bool[3] = a.BritLost;
			uslovie_text[3] = "Британия проиграла Фолклендскую войну";
		}
		else if (this_type == 1)
		{
			this_opis = "Поддержать маоистские организации";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 30;
			uslovie_text[0] = "Не менее 5 агентурных сетей и 3 миллионов в бюджете";
			uslovie_bool[1] = a.modifies[6].active;
			uslovie_text[1] = "Мы - гордые маоисты";
			uslovie_bool[2] = a.data[6] > 750;
			uslovie_text[2] = "Дипрепутация больше 75";
			if (selected_country == 92 || selected_country == 21 || selected_country == 17)
			{
				if (a.empires[0].power < 50)
				{
					uslovie_bool[3] = a.empires[0].power >= 50;
					uslovie_text[3] = "Западная Европа: Слишком сложно";
				}
				else
				{
					uslovie_bool[3] = !a.war_active[0];
					uslovie_text[3] = "Западная Европа: Ежегодно";
				}
			}
			else if (a.empires[1].power < 50)
			{
				uslovie_bool[3] = a.empires[1].power >= 50;
				uslovie_text[3] = "Восточная Европа: Слишком сложно";
			}
			else
			{
				uslovie_bool[3] = !a.war_active[1];
				uslovie_text[3] = "Восточная Европа: Ежегодно";
			}
		}
		else if (this_type == 3)
		{
			this_opis = "Провести переговоры с Британией и Португалией о передаче Гонконга и Макао";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 20;
			uslovie_text[0] = "Не менее 2 агентурных сетей";
			uslovie_bool[1] = a.data[21] >= 1980;
			uslovie_text[1] = "Не раньше 1980 года";
			if (!GlobalScript.inst.dlc[3])
			{
				uslovie_bool[2] = a.data[6] < 700;
				uslovie_text[2] = "Дипрепутация меньше 70 ";
			}
			else
			{
				uslovie_bool[2] = a.data[6] < 700 && a.allcountries[87].Gosstroy != 0;
				uslovie_text[2] = GlobalScript.inst.other_text[309];
			}
			uslovie_bool[3] = a.allcountries[0].dev == 0;
			uslovie_text[3] = "Не провели переговоры";
		}
		else if (this_type == 4)
		{
			if (a.data[21] < 1979 || (a.data[20] < 4 && a.data[21] == 1979))
			{
				this_opis = "Продлить договор о дружбе";
			}
			else
			{
				this_opis = "Восстановить дружеские отношения";
			}
			number_uslovie = 4;
			uslovie_bool[0] = a.data[21] >= 1979;
			uslovie_text[0] = "Не раньше 1979 года";
			if (a.data[21] < 1979 || (a.data[20] < 4 && a.data[21] == 1979))
			{
				if (a.leader.traits[0] == 0 && a.leader.traits[1] == 4 && a.leader.traits[2] == 8)
				{
					uslovie_bool[1] = a.data[1] >= 900 && a.SOV_PRC_PartiesConnection >= 100;
					uslovie_text[1] = "Поддержка Партии не менее 90 и структуры связи восстановлены (не менее 10)";
				}
				else
				{
					uslovie_bool[1] = a.data[1] >= 700 && a.SOV_PRC_PartiesConnection >= 200;
					uslovie_text[1] = "Поддержка Партии не менее 70 и структуры связи восстановлены (не менее 20)";
				}
			}
			else
			{
				uslovie_bool[1] = a.data[1] >= 900 && a.SOV_PRC_PartiesConnection >= 250;
				uslovie_text[1] = "Поддержка Партии не менее 90 и структуры связи восстановлены (не менее 25)";
			}
			uslovie_bool[2] = a.vietnampeace;
			uslovie_text[2] = "Не спровоцировали войну с Вьетнамом";
			if (!a.relres)
			{
				uslovie_bool[3] = a.empires[1].relations >= 700;
				uslovie_text[3] = "Отношения не менее 70";
			}
			else
			{
				uslovie_bool[3] = !a.relres;
				uslovie_text[3] = "Не восстановили отношения";
			}
		}
		else if (this_type == 5)
		{
			this_opis = "Вступить в СЭВ";
			number_uslovie = 4;
			if (!a.relres)
			{
				uslovie_bool[0] = a.relres;
				uslovie_text[0] = "Отношения восстановлены";
			}
			else
			{
				uslovie_bool[0] = !a.modifies[6].active || a.influencePRC < 300;
				uslovie_text[0] = "Мы не маоисты ИЛИ наше влияние меньше 30.0";
			}
			uslovie_bool[1] = !a.allcountries[51].Torg;
			uslovie_text[1] = "Нет тесных связей с США ";
			uslovie_bool[2] = a.data[6] > 690;
			uslovie_text[2] = "Дипрепутация выше 69";
			uslovie_bool[3] = !a.allcountries[1].isSEV;
			uslovie_text[3] = "Не вступили";
		}
		else if (this_type == 74)
		{
			this_opis = "Стать наблюдателем в СЭВ";
			number_uslovie = 3;
			uslovie_bool[0] = a.relres;
			uslovie_text[0] = "Отношения восстановлены";
			uslovie_bool[1] = !a.allcountries[51].Torg;
			uslovie_text[1] = "Нет тесных связей с США ";
			uslovie_bool[2] = a.data[6] > 600;
			uslovie_text[2] = "Дипрепутация выше 60";
		}
		else if (this_type == 6)
		{
			this_opis = "Вступить в ОВД";
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[1].isSEV;
			uslovie_text[0] = "Вступили в СЭВ";
			uslovie_bool[1] = a.data[6] > 690;
			uslovie_text[1] = "Дипрепутация выше 69";
			uslovie_bool[2] = !a.allcountries[1].isOVD;
			uslovie_text[2] = "Не вступили";
			uslovie_bool[3] = !a.allcountries[15].cw;
			uslovie_text[3] = "Не в Движении неприсоединения";
		}
		else if (this_type == 7)
		{
			this_opis = "Восстановление разрушенных структур связи|Восстановлено: " + a.SOV_PRC_PartiesConnection / 10 + "." + Mathf.Abs(a.SOV_PRC_PartiesConnection % 10);
			number_uslovie = 3;
			uslovie_bool[0] = a.data[9] >= a.SOV_PRC_PartiesConnection / 2;
			uslovie_text[0] = "Необходимо " + a.SOV_PRC_PartiesConnection / 20 + "." + Mathf.Abs(a.SOV_PRC_PartiesConnection / 2 % 10) + " агентурные сети";
			uslovie_bool[1] = a.data[8] + a.data[36] >= a.SOV_PRC_PartiesConnection / 4;
			uslovie_text[1] = "В бюджете: " + a.SOV_PRC_PartiesConnection / 40 + "." + Mathf.Abs(a.SOV_PRC_PartiesConnection / 4 % 10);
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
			uslovie_text[2] = "Каждый квартал";
		}
		else if (this_type == 8)
		{
			this_opis = "Поддержать выбранную силу в иранской революции";
			number_uslovie = 4;
			if (a.allcountries[selected_country].dev == 0 && a.data[43] < 1000)
			{
				uslovie_bool[0] = a.data[9] >= 60;
				uslovie_text[0] = "Необходимо 6 агентурных сетей";
			}
			else if (a.allcountries[selected_country].dev == 1 && a.data[42] < 1000)
			{
				uslovie_bool[0] = a.data[9] >= 60;
				uslovie_text[0] = "Необходимо 6 агентурных сетей";
			}
			else if (a.allcountries[selected_country].dev == 2 && a.data[44] < 1000)
			{
				uslovie_bool[0] = a.data[9] >= 60;
				uslovie_text[0] = "Необходимо 6 агентурных сетей";
			}
			else if (a.data[45] < 1000)
			{
				uslovie_bool[0] = a.data[9] >= 60;
				uslovie_text[0] = "Необходимо 6 агентурных сетей";
			}
			else
			{
				uslovie_bool[0] = a.data[9] <= -5000;
				uslovie_text[0] = "Нужна помощь";
			}
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = "5 миллионов в бюджете";
			uslovie_bool[2] = a.allcountries[selected_country].stab == 0 && a.allcountries[8].dev != 4;
			uslovie_text[2] = "Каждые 3 месяца";
			uslovie_bool[3] = a.iranrev;
			uslovie_text[3] = "Протесты начались и революция не завершилась";
		}
		else if (this_type == 9)
		{
			if (selected_country == 104)
			{
				this_opis = "Установить дипломатические отношения и начать углублённую торговлю";
			}
			else
			{
				this_opis = "Начать углублённую торговлю";
			}
			number_uslovie = 3;
			if (a.allcountries[selected_country].Gosstroy == 0)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
				uslovie_text[0] = "Дипрепутация между 39 и 80";
			}
			else if (a.allcountries[selected_country].Gosstroy == 1)
			{
				uslovie_bool[0] = a.data[6] > 690;
				uslovie_text[0] = "Дипрепутация больше 69";
			}
			else if (a.allcountries[selected_country].Gosstroy == 2)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
				uslovie_text[0] = "Дипрепутация между 39 и 85";
			}
			else
			{
				uslovie_bool[0] = a.data[6] < 500;
				uslovie_text[0] = "Дипрепутация меньше 50";
			}
			if (selected_country == 34 && a.ingamewars[2].is_going)
			{
				uslovie_bool[1] = !a.ingamewars[2].is_going;
				uslovie_text[1] = "Нет гражданской войны";
			}
			else if (selected_country == 109 && a.ingamewars[31].is_going)
			{
				uslovie_bool[1] = !a.ingamewars[31].is_going;
				uslovie_text[1] = "Нет гражданской войны";
			}
			else if (selected_country == 110 && a.ingamewars[32].is_going)
			{
				uslovie_bool[1] = !a.ingamewars[32].is_going;
				uslovie_text[1] = "Нет гражданской войны";
			}
			else
			{
				uslovie_bool[1] = !a.allcountries[selected_country].Torg;
				uslovie_text[1] = "Торговля не ведётся";
			}
			if (a.allcountries[selected_country].proprc && a.allcountries[selected_country].SubGosstroy == 17)
			{
				uslovie_bool[2] = a.data[12] < 300;
				uslovie_text[2] = "Промышленность ниже 30";
			}
			else if (a.allcountries[selected_country].proprc)
			{
				uslovie_bool[2] = a.data[12] >= 300;
				uslovie_text[2] = "Промышленность не ниже 30";
			}
			else if (selected_country == 92 || selected_country == 85 || (selected_country > 87 && selected_country < 92) || selected_country == 0)
			{
				uslovie_bool[2] = a.data[12] >= 700;
				uslovie_text[2] = "Промышленность не ниже 70";
			}
			else
			{
				uslovie_bool[2] = a.data[12] >= 500;
				uslovie_text[2] = "Промышленность не ниже 50";
			}
			if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[7].isNATO;
				uslovie_text[3] = GlobalScript.inst.other_text[105];
			}
		}
		else if (this_type == 10)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 3;
			if (selected_country != 35 && selected_country != 14)
			{
				uslovie_bool[0] = a.allcountries[selected_country].Torg || a.allcountries[selected_country].proprc;
				uslovie_text[0] = "Идёт торговля или прокитайский";
			}
			else
			{
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = "Страна под влиянием КНР";
			}
			if (selected_country == 48 && a.allcountries[48].prosov)
			{
				uslovie_bool[1] = a.allcountries[1].isSEV;
				uslovie_text[1] = "Китай в СЭВ";
			}
			else
			{
				uslovie_bool[1] = a.allcountries[1].isSEV || a.allcountries[1].econ;
				uslovie_text[1] = "Союз основан или Китай в СЭВ";
			}
			uslovie_bool[2] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isASEAN;
			uslovie_text[2] = "Они не состоят в экономическом союзе";
			if ((a.allcountries[selected_country].Vyshi && selected_country != 48) || (a.allcountries[selected_country].usalliance && selected_country != 48))
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[selected_country].Vyshi && !a.allcountries[selected_country].usalliance;
				uslovie_text[3] = "Страна не под влиянием США";
			}
			else if (((a.allcountries[selected_country].prosov && selected_country != 48) || (a.allcountries[selected_country].sovalliance && selected_country != 48)) && !a.allcountries[1].isSEV)
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].sovalliance;
				uslovie_text[3] = "Страна не под влиянием СССР";
			}
			else if (selected_country == 8 && (a.ingamewars[3].is_going || a.ingamewars[5].is_going))
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.ingamewars[3].is_going && !a.ingamewars[5].is_going;
				uslovie_text[3] = "Не воюет и нет войны в Афганистане";
			}
			else if (selected_country == 8)
			{
				if (a.allcountries[selected_country].Gosstroy == 0)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
					uslovie_text[0] = "Дипрепутация между 39 и 80";
				}
				else if (a.allcountries[selected_country].Gosstroy == 1)
				{
					uslovie_bool[0] = a.data[6] > 690;
					uslovie_text[0] = "Дипрепутация больше 69";
				}
				else if (a.allcountries[selected_country].Gosstroy == 2)
				{
					uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
					uslovie_text[0] = "Дипрепутация между 39 и 85";
				}
				else
				{
					uslovie_bool[0] = a.data[6] < 500;
					uslovie_text[0] = "Дипрепутация меньше 50";
				}
			}
		}
		else if (this_type == 11)
		{
			this_opis = "Спровоцировать волнения за умеренные реформы";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 100;
			uslovie_text[0] = "10 агентурных сетей";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = "5 миллионов в бюджете";
			uslovie_bool[2] = a.empires[1].now_leader > 0;
			uslovie_text[2] = "Брежнев умер";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Волнения не спровоцированы";
		}
		else if (this_type == 12)
		{
			this_opis = "Спровоцировать переворот в партии в пользу прокитайских сил";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 100 && a.data[8] + a.data[36] >= 80;
			uslovie_text[0] = "10 агентурных сетей и 8 миллионов в бюджете";
			uslovie_bool[1] = a.data[6] > 690;
			uslovie_text[1] = "Дипрепутация выше 69";
			uslovie_bool[2] = a.allcountries[selected_country].stab != 0;
			uslovie_text[2] = "Волнения спровоцированы";
			uslovie_bool[3] = !a.allcountries[selected_country].proprc;
			uslovie_text[3] = "Переворот не осуществлён";
		}
		else if (this_type == 13)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 4;
			if (GlobalScript.inst.dlc[3])
			{
				uslovie_bool[0] = a.allcountries[selected_country].inflCh <= 0 && a.guns && a.allcountries[selected_country].inflNATO <= 0;
				uslovie_text[0] = GlobalScript.inst.other_text[102];
			}
			else
			{
				uslovie_bool[0] = a.allcountries[selected_country].inflCh == 0 && a.guns;
				uslovie_text[0] = "Отправили оружие и не наложили санкции";
			}
			uslovie_bool[1] = a.allcountries[1].isSEV || a.allcountries[1].econ;
			uslovie_text[1] = "Союз основан или Китай в СЭВ";
			uslovie_bool[2] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ;
			uslovie_text[2] = "Они не состоят в экономическом союзе";
			if (a.allcountries[selected_country].Gosstroy <= 1)
			{
				uslovie_bool[3] = a.data[6] > 890;
				uslovie_text[3] = "Дипрепутация больше 89";
			}
			else
			{
				uslovie_bool[3] = a.data[6] > 490 && a.data[6] < 890;
				uslovie_text[3] = "Дипрепутация между 49 и 89";
			}
		}
		else if (this_type == 14)
		{
			this_opis = "Наложить санкции";
			if (!GlobalScript.inst.dlc[3])
			{
				number_uslovie = 2;
			}
			else
			{
				number_uslovie = 3;
			}
			uslovie_bool[0] = a.allcountries[selected_country].inflCh <= 0;
			uslovie_text[0] = "Не накладывали санкции";
			uslovie_bool[1] = a.data[6] < 500;
			uslovie_text[1] = "Дипрепутация ниже 50";
			if (GlobalScript.inst.dlc[3])
			{
				uslovie_bool[2] = a.allcountries[10].dev <= 0;
				uslovie_text[2] = GlobalScript.inst.other_text[101];
			}
		}
		else if (this_type == 15)
		{
			this_opis = "Спровоцировать новую корейскую войну";
			number_uslovie = 4;
			uslovie_bool[0] = a.guns && a.data[9] >= 100 && a.data[8] + a.data[36] >= 50;
			uslovie_text[0] = "Отправили оружие, есть 10 агентурных сетей и 5 миллионов в бюджете";
			if (!a.allcountries[1].isASEAN)
			{
				if (GlobalScript.inst.dlc[3])
				{
					uslovie_bool[1] = a.event_done[91] && a.allcountries[46].Gosstroy == 0 && a.allcountries[10].dev <= 0;
					uslovie_text[1] = GlobalScript.inst.other_text[103];
				}
				else
				{
					uslovie_bool[1] = a.event_done[91] && a.allcountries[46].Gosstroy == 0;
					uslovie_text[1] = "Покушение на Чон Ду Хвана состоялось";
				}
			}
			else
			{
				uslovie_bool[1] = a.event_done[91];
				uslovie_text[1] = "Покушение на Чон Ду Хвана состоялось";
			}
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
			uslovie_text[2] = "Война не спровоцирована";
			uslovie_bool[3] = a.data[6] > 790;
			uslovie_text[3] = "Дипрепутация больше 79";
		}
		else if (this_type == 16)
		{
			this_opis = "Направить вооружение и специалистов";
			if (!GlobalScript.inst.dlc[3])
			{
				number_uslovie = 3;
			}
			else
			{
				number_uslovie = 4;
			}
			uslovie_bool[0] = !a.guns;
			uslovie_text[0] = "Не отправили оружие";
			uslovie_bool[1] = a.data[22] >= 50;
			uslovie_text[1] = "Сила армии не менее 5";
			uslovie_bool[2] = a.data[8] + a.data[36] >= 20;
			uslovie_text[2] = "2 миллиона в бюджете";
			if (GlobalScript.inst.dlc[3])
			{
				uslovie_bool[3] = a.allcountries[10].dev <= 0;
				uslovie_text[3] = GlobalScript.inst.other_text[101];
			}
		}
		else if (this_type == 17)
		{
			this_opis = "Начать углублённую торговлю";
			number_uslovie = 3;
			if (!a.allcountries[selected_country].proprc)
			{
				uslovie_bool[0] = a.vietnampeace;
				uslovie_text[0] = "Не начинали войну с Вьетнамом";
			}
			else
			{
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = "Вьетнам - под влиянием КНР";
			}
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Торговля не ведётся";
			uslovie_bool[2] = a.data[6] > 690 || a.allcountries[selected_country].proprc;
			uslovie_text[2] = "Дипрепутация больше 69 или Вьетнам прокитайский";
			if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[7].isNATO;
				uslovie_text[3] = GlobalScript.inst.other_text[105];
			}
		}
		else if (this_type == 18)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 3;
			uslovie_bool[0] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ;
			uslovie_text[0] = "Вьетнам не в нашем союзе и не в СЭВ";
			uslovie_bool[1] = a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Торговля ведётся";
			uslovie_bool[2] = a.allcountries[1].econ || a.allcountries[1].isSEV;
			uslovie_text[2] = "Союз основан или мы в СЭВ";
			if (a.allcountries[selected_country].Vyshi)
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = "Страна не под влиянием США";
			}
		}
		else if (this_type == 19)
		{
			this_opis = "Принять в военный альянс";
			number_uslovie = 4;
			if (selected_country != 40)
			{
				uslovie_bool[0] = a.allcountries[selected_country].isSEV || a.allcountries[selected_country].econ;
				uslovie_text[0] = "Они в ОЭС или в СЭВ";
			}
			else
			{
				uslovie_bool[0] = (a.allcountries[selected_country].isSEV || a.allcountries[selected_country].econ) && !a.allcountries[selected_country].oar;
				uslovie_text[0] = "Они в ОЭС или в СЭВ и не в ОАР";
			}
			uslovie_bool[1] = a.data[22] >= 20;
			uslovie_text[1] = "Сила армии не менее 2";
			if (!a.allcountries[selected_country].oar)
			{
				uslovie_bool[2] = (!a.allcountries[selected_country].isOVD && a.allcountries[1].isOVD && !a.allcountries[selected_country].isSEATO) || (!a.allcountries[selected_country].okb && a.allcountries[1].okb && !a.allcountries[selected_country].isOVD && !a.allcountries[selected_country].isSEATO);
				uslovie_text[2] = "Они не в альянсе, АКБ основан или Китай в ОВД";
			}
			else
			{
				uslovie_bool[2] = !a.allcountries[selected_country].oar;
				uslovie_text[2] = GlobalScript.inst.other_text[104];
			}
			uslovie_bool[3] = a.data[6] > 790;
			uslovie_text[3] = "Дипрепутация больше 79";
		}
		else if (this_type == 20)
		{
			if (selected_country == 11)
			{
				this_opis = "Направить подкрепления НОАК на войну|Сила наступления: " + a.data[39] / 10 + "." + Mathf.Abs(a.data[39] % 10);
			}
			else if (selected_country == 19)
			{
				this_opis = "Направить подкрепления НОАК на войну|Сила наступления: " + a.data[40] / 10 + "." + Mathf.Abs(a.data[40] % 10);
			}
			number_uslovie = 3;
			uslovie_bool[0] = a.war == 1;
			uslovie_text[0] = "Идёт война";
			uslovie_bool[1] = a.data[22] >= 70;
			uslovie_text[1] = "Сила армии не менее 7";
			uslovie_bool[2] = a.allcountries[selected_country].stab == 0;
			uslovie_text[2] = "Не отправляли в этом месяце";
		}
		else if (this_type == 21)
		{
			this_opis = "Поддержать выбранную силу в мирной борьбе за власть";
			number_uslovie = 4;
			uslovie_bool[0] = a.DRAagree;
			uslovie_text[0] = "Договорились с ДРА и СССР";
			uslovie_bool[1] = a.data[9] >= 40;
			uslovie_text[1] = "Не менее 4 агентурных сетей";
			uslovie_bool[2] = a.data[8] + a.data[36] >= 30;
			uslovie_text[2] = "3 миллиона в бюджете";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Не поддержали в этом году";
		}
		else if (this_type == 68)
		{
			this_opis = "Принять в СЭВ";
			number_uslovie = 4;
			uslovie_bool[0] = !a.ingamewars[5].is_going;
			uslovie_text[0] = "Не идёт гражданская война";
			uslovie_bool[1] = a.allcountries[selected_country].proprc || (a.allcountries[1].isSEV && a.allcountries[selected_country].prosov);
			uslovie_text[1] = "Афганистан прокитайский или просоветский и Китай в СЭВ";
			uslovie_bool[2] = a.allcountries[selected_country].Torg && (a.allcountries[1].econ || a.allcountries[1].isSEV);
			uslovie_text[2] = "Торгуем и в союзе";
			uslovie_bool[3] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].isASEAN;
			uslovie_text[3] = "Они не в экономическом союзе";
		}
		else if (this_type == 22)
		{
			this_opis = "Отправить деньги в помощь Каддафи";
			number_uslovie = 2;
			uslovie_bool[0] = a.allcountries[selected_country].stab == 0;
			uslovie_text[0] = "Не отправляли";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = "5 миллионов в бюджете";
		}
		else if (this_type == 23)
		{
			this_opis = "Начать активную торговлю";
			number_uslovie = 3;
			uslovie_bool[0] = !a.allcountries[selected_country].Torg;
			uslovie_text[0] = "Торговля не ведётся";
			uslovie_bool[1] = a.data[6] > 590;
			uslovie_text[1] = "Дипрепутация больше 59";
			uslovie_bool[2] = a.allcountries[selected_country].stab == 1;
			uslovie_text[2] = "Отправили деньги Каддафи";
		}
		else if (this_type == 67)
		{
			this_opis = "Провести переговоры о вступлении страны в ОАР";
			number_uslovie = 2;
			uslovie_bool[0] = a.OAR;
			uslovie_text[0] = "ОАР основана";
			uslovie_bool[1] = !a.allcountries[selected_country].oar;
			uslovie_text[1] = "Страна не в ОАР";
			if (selected_country == 14)
			{
				number_uslovie = 3;
				uslovie_bool[2] = a.allcountries[14].puppetOf != 8;
				uslovie_text[2] = GlobalScript.inst.other_text[116];
			}
			if (selected_country == 13 && GlobalScript.inst.dlc[3])
			{
				number_uslovie = 3;
				uslovie_bool[2] = a.data[132] == 2;
				uslovie_text[2] = GlobalScript.inst.other_text[115];
			}
		}
		else if (this_type == 24)
		{
			this_opis = "Начать углублённую торговлю";
			number_uslovie = 3;
			if (a.allcountries[selected_country].Gosstroy == 0)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
				uslovie_text[0] = "Дипрепутация между 39 и 80";
			}
			else if (a.allcountries[selected_country].Gosstroy == 1)
			{
				uslovie_bool[0] = a.data[6] > 690;
				uslovie_text[0] = "Дипрепутация больше 69";
			}
			else if (a.allcountries[selected_country].Gosstroy == 2)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
				uslovie_text[0] = "Дипрепутация между 39 и 85";
			}
			else
			{
				uslovie_bool[0] = a.data[6] < 500;
				uslovie_text[0] = "Дипрепутация меньше 50";
			}
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Торговля не ведётся";
			uslovie_bool[2] = a.data[12] >= 700;
			uslovie_text[2] = "Промышленность не ниже 70";
			if (selected_country == 52)
			{
				number_uslovie = 4;
				uslovie_bool[3] = a.allcountries[52].stab <= 0;
				uslovie_text[3] = GlobalScript.inst.other_text[473];
			}
			if (selected_country == 14)
			{
				number_uslovie = 4;
				uslovie_bool[3] = a.allcountries[14].puppetOf != 8;
				uslovie_text[3] = "Ирак не марионетка Ирана";
			}
			else if (((selected_country >= 2 && selected_country <= 6) || selected_country == 16) && a.allcountries[1].isSEV)
			{
				number_uslovie = 4;
				uslovie_bool[3] = a.allcountries[1].isSEV;
				uslovie_text[3] = "Китай состоит в СЭВ";
			}
			else if ((selected_country >= 2 && selected_country <= 6) || selected_country == 16)
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[selected_country].prosov;
				uslovie_text[3] = "Страна не под советским влиянием";
			}
		}
		else if (this_type == 50)
		{
			this_opis = "Начать углублённую торговлю";
			number_uslovie = 3;
			if (a.allcountries[selected_country].Gosstroy == 0)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 800;
				uslovie_text[0] = "Дипрепутация между 39 и 80";
			}
			else if (a.allcountries[selected_country].Gosstroy == 1)
			{
				uslovie_bool[0] = a.data[6] > 690;
				uslovie_text[0] = "Дипрепутация больше 69";
			}
			else if (a.allcountries[selected_country].Gosstroy == 2)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
				uslovie_text[0] = "Дипрепутация между 39 и 85";
			}
			else
			{
				uslovie_bool[0] = a.data[6] < 500;
				uslovie_text[0] = "Дипрепутация меньше 50";
			}
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Торговля не ведётся";
			uslovie_bool[2] = a.data[12] >= 700;
			uslovie_text[2] = "Промышленность не ниже 70";
			if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[7].isNATO;
				uslovie_text[3] = GlobalScript.inst.other_text[105];
			}
		}
		else if (this_type == 69)
		{
			this_opis = "Установить связи с коммунистами и поддержать их";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[6] > 790;
			uslovie_text[0] = "Дипрепутация больше 79";
			uslovie_bool[1] = a.data[9] >= 30;
			uslovie_text[1] = "Не менее 3 агентурных сетей";
			uslovie_bool[2] = a.event_done[3];
			uslovie_text[2] = "Саддам начал репрессии против коммунистов";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Не поддержали";
		}
		else if (this_type == 25)
		{
			this_opis = "Провести переговоры о вступлении страны в ОАР";
			number_uslovie = 4;
			uslovie_bool[0] = a.OAR;
			uslovie_text[0] = "ОАР основана";
			uslovie_bool[1] = !a.allcountries[selected_country].oar && !a.allcountries[selected_country].isSEATO && !a.allcountries[selected_country].isNATO && !a.allcountries[selected_country].isNATO && !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD;
			uslovie_text[1] = "Страна не в ОАР и не состоит в военных блоках";
			uslovie_bool[2] = a.allcountries[14].Gosstroy != 0;
			uslovie_text[2] = "Государственный строй - не авторитаризм";
			if (a.allcountries[14].Vyshi)
			{
				uslovie_bool[3] = !a.allcountries[14].Vyshi;
				uslovie_text[3] = "Страна не под влиянием США";
			}
			else if (a.allcountries[8].Gosstroy == 0)
			{
				uslovie_bool[3] = a.allcountries[8].SubGosstroy != 9;
				uslovie_text[3] = "Иран не под исламистами";
			}
			else
			{
				uslovie_bool[3] = a.allcountries[14].puppetOf != 8;
				uslovie_text[3] = "Ирак не марионетка Ирана";
			}
		}
		else if (this_type == 26)
		{
			this_opis = "Подписать договор о дружбе";
			number_uslovie = 3;
			uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 900;
			uslovie_text[0] = "Дипрепутация между 39 и 90";
			uslovie_bool[1] = (a.data[20] >= 5 && a.data[21] >= 1980) || a.data[21] >= 1981;
			uslovie_text[1] = "Тито умер";
			uslovie_bool[2] = !a.allcountries[selected_country].Torg;
			uslovie_text[2] = "Не подписали";
		}
		else if (this_type == 75)
		{
			this_opis = "Продать технологии американцам";
			number_uslovie = 3;
			uslovie_bool[0] = a.data[11] >= 100;
			uslovie_text[0] = "Есть 10 очков науки";
			uslovie_bool[1] = a.data[56] != 0;
			uslovie_text[1] = "Не леворадикалы";
			uslovie_bool[2] = a.empires[0].power < 600;
			uslovie_text[2] = "Мировое влияние США менее 60";
		}
		else if (this_type == 81)
		{
			this_opis = "Продать американские технологии";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[11] >= 100;
			uslovie_text[0] = "Есть 10 очков науки";
			uslovie_bool[1] = a.allcountries[1].isSEV || a.allcountries[7].Torg;
			uslovie_text[1] = "Наблюдатель или член СЭВ";
			uslovie_bool[2] = a.empires[1].power < 600;
			uslovie_text[2] = "Мировое влияние СССР менее 60";
			uslovie_bool[3] = a.allcountries[51].Torg;
			uslovie_text[3] = "Подписан договор о дружбе с США";
		}
		else if (this_type == 76)
		{
			this_opis = "Начать политику экономических преференций и кредитования";
			number_uslovie = 2;
			uslovie_bool[0] = a.data[36] >= 200;
			uslovie_text[0] = "Резерв не менее 20";
			uslovie_bool[1] = !a.allcountries[selected_country].cw;
			uslovie_text[1] = "Не начали";
		}
		else if (this_type == 77)
		{
			this_opis = "Осуществить бескровное смещение правительства националистов";
			this_opis = this_opis + "|Влияние на страну: " + a.allcountries[selected_country].dev + "%";
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].cw;
			uslovie_text[0] = "Привязали экономически";
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Не сместили";
			uslovie_bool[2] = a.allcountries[selected_country].dev >= 30;
			uslovie_text[2] = "Влияние: 30";
			uslovie_bool[3] = a.data[9] >= 80;
			uslovie_text[3] = "Агентурных сетей не менее 8";
		}
		else if (this_type == 78)
		{
			this_opis = "Разместить военную базу для защиты их суверенитета";
			this_opis = this_opis + "|Влияние на страну: " + a.allcountries[selected_country].dev + "%";
			number_uslovie = 4;
			uslovie_bool[0] = !a.allcountries[selected_country].proprc;
			uslovie_text[0] = "Нет военной базы";
			uslovie_bool[1] = a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Сместили националистов";
			uslovie_bool[2] = a.allcountries[selected_country].dev >= 60;
			uslovie_text[2] = "Влияние: 60";
			uslovie_bool[3] = a.data[9] >= 60 && a.data[22] >= 100;
			uslovie_text[3] = "Агентурных сетей - 6 и сила армии 10";
		}
		else if (this_type == 79)
		{
			this_opis = "Провести референдум о вхождении страны в состав КНР";
			this_opis = this_opis + "|Влияние на страну: " + a.allcountries[selected_country].dev + "%";
			number_uslovie = 3;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = "Есть военная база";
			uslovie_bool[1] = a.allcountries[selected_country].dev >= 100;
			uslovie_text[1] = "Влияние: 100";
			uslovie_bool[2] = a.data[9] >= 80;
			uslovie_text[2] = "Агентурных сетей - 8";
		}
		else if (this_type == 80)
		{
			this_opis = "Склонить к смене системы по нашему образцу";
			this_opis = this_opis + "|Они получат Государственный строй: " + GlobalScript.inst.other_text[(a.ChineseSubGosstroy() < 10) ? (a.ChineseSubGosstroy() + 13) : (a.ChineseSubGosstroy() + 82)];
			number_uslovie = 4;
			if (a.allcountries[1].okb)
			{
				uslovie_bool[0] = a.allcountries[selected_country].SubGosstroy != a.ChineseSubGosstroy();
				uslovie_text[0] = "У нас разные госстрои";
			}
			else
			{
				uslovie_bool[0] = a.allcountries[1].okb;
				uslovie_text[0] = "У нас есть свой собственный военный союз";
			}
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = "Бюджет: 5";
			uslovie_bool[2] = a.data[9] >= 50;
			uslovie_text[2] = "Агентурных сетей: 5";
			uslovie_bool[3] = a.data[22] >= 50;
			uslovie_text[3] = "Сила армии: 5";
		}
		else if (this_type == 27)
		{
			this_opis = "Установить связи с коммунистами и поддержать их";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[6] > 590;
			uslovie_text[0] = "Дипрепутация больше 59";
			uslovie_bool[1] = a.data[9] >= 40;
			uslovie_text[1] = "Не менее 4 агентурных сетей";
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
			uslovie_text[2] = "Не поддержали";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 1 || a.allcountries[selected_country].Torg;
			uslovie_text[3] = "Подписали договор";
		}
		else if (this_type == 72)
		{
			this_opis = "Вступить в Движение неприсоединения";
			number_uslovie = 4;
			uslovie_bool[0] = !a.allcountries[1].isOVD && !a.allcountries[1].okb && !a.allcountries[1].isSEATO;
			uslovie_text[0] = "Не состоим в альянсах";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 20;
			uslovie_text[1] = "2 миллиона в бюджете";
			uslovie_bool[2] = !a.allcountries[15].cw;
			uslovie_text[2] = "Мы не в Движении сейчас";
			uslovie_bool[3] = a.war <= 0;
			uslovie_text[3] = "Не ведём войн";
		}
		else if (this_type == 73)
		{
			this_opis = "Выйти из Движения неприсоединения";
			number_uslovie = 3;
			uslovie_bool[0] = a.data[1] > 750;
			uslovie_text[0] = "Поддержка Партии больше чем 75.0";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = "5 миллионов в бюджете";
			uslovie_bool[2] = a.allcountries[15].cw;
			uslovie_text[2] = "Мы состоим в Движении";
		}
		else if (this_type == 28)
		{
			this_opis = "Поддержать повстанцев на востоке|Сила маоистов: " + a.data[32] / 10 + "." + Mathf.Abs(a.data[32] % 10);
			number_uslovie = 4;
			uslovie_bool[0] = a.data[6] > 790;
			uslovie_text[0] = "Дипрепутация больше 79";
			uslovie_bool[1] = a.data[9] >= 30 && a.data[22] >= 30;
			uslovie_text[1] = "Не менее 3 агентурных сетей и силы армии";
			uslovie_bool[2] = !a.allcountries[selected_country].Torg;
			uslovie_text[2] = "Не наладили отношения";
			if (a.data[32] <= 500 || GlobalScript.inst.dlc[1])
			{
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
				uslovie_text[3] = "Не поддерживали в этом месяце";
			}
			else
			{
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0 && a.data[32] <= 500;
				uslovie_text[3] = "Не достигли их максимума возможностей";
			}
		}
		else if (this_type == 29)
		{
			this_opis = "Нормализовать отношения";
			number_uslovie = 4;
			uslovie_bool[0] = (a.data[91] == 1 || a.data[91] == 2 || a.data[91] == 3) && (!a.allcountries[31].Torg || a.allcountries[31].Gosstroy == 2 || a.allcountries[31].Gosstroy == 1);
			uslovie_text[0] = "Помогли Индире, нет дружбы с Пакистаном или Бхутто - премьер Пакистана";
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Не наладили отношения";
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0 && a.war == 0 && a.data[62] < 2;
			uslovie_text[2] = "Не начинали войну";
			uslovie_bool[3] = a.data[62] == 0;
			uslovie_text[3] = "Территориальный спор не урегулирован";
		}
		else if (this_type == 30)
		{
			this_opis = "Начать новую пограничную войну за спорные территории";
			number_uslovie = 4;
			uslovie_bool[0] = a.CBIndia;
			uslovie_text[0] = "Есть повод для войны";
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Не наладили отношения";
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0 && a.war == 0 && a.data[62] < 2;
			uslovie_text[2] = "Не начинали войну";
			uslovie_bool[3] = !a.allcountries[15].cw;
			uslovie_text[3] = "Не в Движении неприсоединения";
		}
		else if (this_type == 89)
		{
			this_opis = "Обменять Аруначал Прадеш на денежные инвестиции";
			number_uslovie = 3;
			uslovie_bool[0] = a.influencePRC >= 500;
			uslovie_text[0] = "Влияние КНР не менее 50.0";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 250;
			uslovie_text[1] = "Денег в бюджете не менее 25.0";
			uslovie_bool[2] = a.CBIndia;
			uslovie_text[2] = "Есть нерешённый территориальный вопрос";
		}
		else if (this_type == 71)
		{
			if (selected_country == 11)
			{
				this_opis = "Направить подкрепления НОАК на войну|Сила наступления: " + a.data[39] / 10 + "." + Mathf.Abs(a.data[39] % 10);
			}
			else if (selected_country == 19)
			{
				this_opis = "Направить подкрепления НОАК на войну|Сила наступления: " + a.data[40] / 10 + "." + Mathf.Abs(a.data[40] % 10);
			}
			number_uslovie = 3;
			uslovie_bool[0] = a.war == 2;
			uslovie_text[0] = "Идёт война с Индией";
			uslovie_bool[1] = a.data[22] >= 70;
			uslovie_text[1] = "Сила армии не менее 7";
			uslovie_bool[2] = a.allcountries[selected_country].prcpower == 0;
			uslovie_text[2] = "Не отправляли в этом месяце";
		}
		else if (this_type == 31)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 3;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = "Албания прокитайская";
			uslovie_bool[1] = a.allcountries[1].econ || (a.allcountries[1].isSEV && a.SovAlb);
			uslovie_text[1] = "Союз основан или Китай в СЭВ и советско-албанские отношения восстановлены";
			uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = "Они не в экономическом союзе";
			if (a.allcountries[selected_country].Vyshi)
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = "Страна не под влиянием США";
			}
		}
		else if (this_type == 32)
		{
			this_opis = "Склонить к восстановлению отношений с СССР";
			number_uslovie = 4;
			uslovie_bool[0] = a.relres;
			uslovie_text[0] = "Советско-китайские отношения восстановлены";
			uslovie_bool[1] = a.data[6] > 790 || a.allcountries[7].Torg;
			uslovie_text[1] = "Дипрепутация больше 79 ИЛИ мы - наблюдатель в СЭВ";
			uslovie_bool[2] = a.data[60] > 0;
			uslovie_text[2] = "Ходжа умер или смещён";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Их отношения не восстановлены";
		}
		else if (this_type == 33)
		{
			this_opis = "Подписать договор о дружбе";
			number_uslovie = 2;
			uslovie_bool[0] = a.data[6] < 800;
			uslovie_text[0] = "Дипрепутация меньше 80";
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Не подписали";
			if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
			{
				number_uslovie = 3;
				uslovie_bool[2] = !a.allcountries[7].isNATO;
				uslovie_text[2] = GlobalScript.inst.other_text[105];
			}
		}
		else if (this_type == 34)
		{
			this_opis = "Пригласить иностранных инвесторов";
			number_uslovie = 3;
			if (a.allcountries[21].Gosstroy == 1 && selected_country == 21)
			{
				uslovie_bool[0] = a.data[6] >= 600;
				uslovie_text[0] = "Дипрепутация больше 60";
			}
			else
			{
				uslovie_bool[0] = a.data[6] < 600;
				uslovie_text[0] = "Дипрепутация меньше 60";
			}
			if (a.allcountries[21].Gosstroy == 1 && selected_country == 21)
			{
				uslovie_bool[1] = a.data[16] < 13 || a.SEZ;
				uslovie_text[1] = "Экономика - \"Государственный монополизм\" и социалистичней или открыли СЭЗ";
			}
			else
			{
				uslovie_bool[1] = a.data[16] >= 13 || a.SEZ;
				uslovie_text[1] = "Экономика - \"птичья клетка\" и либеральнее или открыли СЭЗ";
			}
			uslovie_bool[2] = a.allcountries[selected_country].stab == 0;
			uslovie_text[2] = "Не привлекали в этом году";
		}
		else if (this_type == 35)
		{
			this_opis = "Установить близкие дружеские отношения";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[6] > 690;
			uslovie_text[0] = "Дипрепутация больше 69";
			uslovie_bool[1] = a.data[9] >= 30;
			uslovie_text[1] = "Не менее 3 агентурных сетей";
			if (!a.allcountries[11].proprc)
			{
				uslovie_bool[2] = a.allcountries[11].Torg && a.vietnampeace;
				uslovie_text[2] = "Не спровоцировали войну с Вьетнамом и ведём с ним торговлю";
			}
			else
			{
				uslovie_bool[2] = a.allcountries[11].proprc && a.allcountries[34].proprc && a.allcountries[23].proprc;
				uslovie_text[2] = "Вьетнам, Кампучия и Таиланд - прокитайские";
			}
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Не сближались";
		}
		else if (this_type == 36)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = "Лаос прокитайский";
			uslovie_bool[1] = a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Идёт торговля";
			uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = "Они не в экономическом союзе";
			uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
			uslovie_text[3] = "Союз основан или Китай в СЭВ";
		}
		else if (this_type == 37)
		{
			this_opis = "Поддержать мятежи военных с целью свержения Пол Пота";
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = "Кампучия прокитайская";
			uslovie_bool[1] = a.data[38] == 100;
			uslovie_text[1] = "Мао умер";
			uslovie_bool[2] = a.allcountries[selected_country].stab == 0 && a.allcountries[selected_country].Gosstroy != 1;
			uslovie_text[2] = "Не поддерживали мятеж";
			uslovie_bool[3] = a.data[8] + a.data[9] >= 30;
			uslovie_text[3] = "Агентурных сетей и денег в бюджете не менее 3";
		}
		else if (this_type == 38)
		{
			this_opis = "Поддержать сторонников старого президента Насера";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[6] > 690;
			uslovie_text[0] = "Дипрепутация больше 69";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = "5 миллионов в бюджете";
			uslovie_bool[2] = !a.event_done[37];
			uslovie_text[2] = "Пока ещё можно";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Не поддержали";
		}
		else if (this_type == 39)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].Torg;
			uslovie_text[0] = "Идёт торговля";
			uslovie_bool[1] = a.OAR;
			uslovie_text[1] = "ОАР основана";
			uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = "Они не в экономическом союзе";
			uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
			uslovie_text[3] = "Союз основан или Китай в СЭВ";
		}
		else if (this_type == 40)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 4;
			uslovie_bool[0] = !a.allcountries[selected_country].Vyshi;
			uslovie_text[0] = "Пакистан не проамериканский";
			uslovie_bool[1] = !a.allcountries[19].Torg || a.allcountries[selected_country].proprc;
			uslovie_text[1] = "Не нормализовали отношения с Индией или Бхутто - премьер";
			uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].isASEAN;
			uslovie_text[2] = "Они не в экономическом союзе";
			uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
			uslovie_text[3] = "Союз основан или Китай в СЭВ";
		}
		else if (this_type == 41)
		{
			this_opis = "Принять в военный альянс";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[22] >= 20;
			uslovie_text[0] = "Сила армии не менее 2";
			uslovie_bool[1] = (a.allcountries[selected_country].econ || a.allcountries[selected_country].isSEV) && (a.allcountries[1].okb || a.allcountries[1].isOVD);
			uslovie_text[1] = "Пакистан в экономическом союзе, альянс основан или мы в ОВД";
			uslovie_bool[2] = !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD && !a.allcountries[selected_country].isSEATO && !a.allcountries[selected_country].isSENTO;
			uslovie_text[2] = "Они не в военном союзе";
			uslovie_bool[3] = a.allcountries[selected_country].econ || a.allcountries[selected_country].isSEV;
			uslovie_text[3] = "Они в экономическом союзе";
		}
		else if (this_type == 42)
		{
			this_opis = "Выделить помощь для восстановления экономики";
			number_uslovie = 2;
			uslovie_bool[0] = a.data[8] + a.data[36] >= 80;
			uslovie_text[0] = "8 миллионов в бюджете";
			uslovie_bool[1] = a.allcountries[selected_country].stab == 0;
			uslovie_text[1] = "Не направляли помощь";
		}
		else if (this_type == 43)
		{
			this_opis = "Поддержать тайских коммунистов";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 40;
			uslovie_text[0] = "4 агентурные сети";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 20;
			uslovie_text[1] = "2 миллиона в бюджете";
			uslovie_bool[2] = !a.TaiCoup;
			uslovie_text[2] = "Переворот в Таиланде ещё не осуществился";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Не поддержали";
		}
		else if (this_type == 44)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 4;
			if (selected_country == 52)
			{
				uslovie_bool[0] = a.allcountries[selected_country].spec > 0;
				uslovie_text[0] = GlobalScript.inst.other_text[474];
			}
			else
			{
				uslovie_bool[0] = a.allcountries[selected_country].Gosstroy == 1;
				uslovie_text[0] = "Коммунисты победили";
			}
			uslovie_bool[1] = a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Идёт торговля";
			uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = "Они не в экономическом союзе";
			uslovie_bool[3] = a.allcountries[1].econ || a.allcountries[1].isSEV;
			uslovie_text[3] = "Союз основан или Китай в СЭВ";
		}
		else if (this_type == 45)
		{
			this_opis = "Провести переговоры о вступлении страны в ОАР";
			if (selected_country != 40 && selected_country != 35)
			{
				number_uslovie = 2;
			}
			else
			{
				number_uslovie = 4;
			}
			uslovie_bool[0] = a.OAR;
			uslovie_text[0] = "ОАР основана";
			uslovie_bool[1] = !a.allcountries[selected_country].oar;
			uslovie_text[1] = "Страна не в ОАР";
			if (selected_country == 40 || selected_country == 35)
			{
				uslovie_bool[2] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[2] = GlobalScript.inst.other_text[91];
				uslovie_bool[3] = !a.allcountries[selected_country].isOVD && !a.allcountries[selected_country].okb;
				uslovie_text[3] = GlobalScript.inst.other_text[322];
			}
		}
		else if (this_type == 46)
		{
			this_opis = "Провести переговоры о статусе палестинцев при нашем посредничестве";
			number_uslovie = 2;
			uslovie_bool[0] = a.Israellost;
			uslovie_text[0] = "Израиль проиграл ливанскую войну";
			uslovie_bool[1] = a.allcountries[selected_country].dev == 0;
			uslovie_text[1] = "Переговоры не проводились";
		}
		else if (this_type == 47)
		{
			this_opis = "Провести переговоры с целью нормализации отношений";
			number_uslovie = 3;
			uslovie_bool[0] = a.data[6] < 550;
			uslovie_text[0] = "Дипрепутация ниже 55";
			uslovie_bool[1] = a.allcountries[51].Torg;
			uslovie_text[1] = "Есть договор с США";
			uslovie_bool[2] = !a.allcountries[selected_country].Torg;
			uslovie_text[2] = "Не проводили переговоры";
		}
		else if (this_type == 48)
		{
			this_opis = "Начать освобождение приграничных островов";
			number_uslovie = 3;
			uslovie_bool[0] = a.data[22] >= 500;
			uslovie_text[0] = "Сила армии не менее 50";
			uslovie_bool[1] = !a.allcountries[51].Torg;
			uslovie_text[1] = "Не нормализовали отношения";
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
			uslovie_text[2] = "Не устраивали вторжение";
		}
		else if (this_type == 49)
		{
			this_opis = "Положить деньги на тайный счёт КПК";
			number_uslovie = 2;
			if (!a.allcountries[selected_country].proprc)
			{
				uslovie_bool[0] = a.data[8] + a.data[36] >= 100;
				uslovie_text[0] = "10 миллионов в бюджете";
			}
			else
			{
				uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
				uslovie_text[0] = "5 миллионов в бюджете";
			}
			uslovie_bool[1] = a.allcountries[39].dev == 0;
			uslovie_text[1] = "Раз в месяц";
		}
		else if (this_type == 51)
		{
			this_opis = "Устранить Кендзи Миямото и вернуть контроль над КПЯ";
			number_uslovie = 3;
			uslovie_bool[0] = a.data[9] >= 50;
			uslovie_text[0] = "5 агентурных сетей";
			uslovie_bool[1] = a.data[6] >= 690;
			uslovie_text[1] = "Дипрепутация больше 69";
			uslovie_bool[2] = a.allcountries[selected_country].stab == 0;
			uslovie_text[2] = "Не устранили";
		}
		else if (this_type == 52)
		{
			this_opis = "Начать углублённую торговлю";
			number_uslovie = 3;
			if (a.allcountries[selected_country].Gosstroy == 1)
			{
				uslovie_bool[0] = a.data[6] >= 800;
				uslovie_text[0] = "Дипрепутация не ниже 80";
			}
			else if (a.allcountries[selected_country].Gosstroy <= 2)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
				uslovie_text[0] = "Дипрепутация между 39 и 85";
			}
			else if (a.allcountries[selected_country].Gosstroy == 3)
			{
				uslovie_bool[0] = a.data[6] < 500;
				uslovie_text[0] = "Дипрепутация меньше 50";
			}
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Торговля не ведётся";
			uslovie_bool[2] = a.data[12] >= 800;
			uslovie_text[2] = "Промышленность не ниже 80";
			if (a.allcountries[7].isNATO && (a.allcountries[selected_country].Vyshi || a.allcountries[selected_country].prosov || a.allcountries[selected_country].isNATO))
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[7].isNATO;
				uslovie_text[3] = GlobalScript.inst.other_text[105];
			}
		}
		else if (this_type == 53)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 3;
			if (selected_country != 94 && selected_country != 95 && selected_country != 84 && selected_country != 14 && selected_country != 35)
			{
				uslovie_bool[0] = a.allcountries[selected_country].Torg && a.allcountries[selected_country].Gosstroy <= 2;
				uslovie_text[0] = "Идёт торговля и прокитайские силы у власти";
			}
			else
			{
				uslovie_bool[0] = a.allcountries[selected_country].Torg;
				uslovie_text[0] = "Идёт торговля";
			}
			if (selected_country == 27 || selected_country == 39 || selected_country == 88 || selected_country == 29 || selected_country == 89 || selected_country == 0 || selected_country == 90 || selected_country == 91 || selected_country == 28)
			{
				uslovie_bool[0] = a.allcountries[selected_country].cw;
				uslovie_text[0] = "Поддержали одну из фракций";
			}
			uslovie_bool[1] = a.allcountries[1].econ || a.allcountries[1].isSEV;
			uslovie_text[1] = "Союз основан или Китай в СЭВ";
			uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = "Они не в экономическом союзе";
			if (selected_country == 94)
			{
				number_uslovie = 4;
				uslovie_bool[3] = a.allcountries[selected_country].SubGosstroy == 4;
				uslovie_text[3] = GlobalScript.inst.other_text[118];
			}
			if (selected_country == 14 || selected_country == 35)
			{
				number_uslovie = 4;
				uslovie_bool[3] = a.allcountries[selected_country].Gosstroy == 1 || a.allcountries[selected_country].proprc;
				uslovie_text[3] = GlobalScript.inst.other_text[313];
			}
			if (a.allcountries[selected_country].Vyshi)
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = "Страна не под влиянием США";
			}
		}
		else if (this_type == 54)
		{
			this_opis = "Принять в экономический союз";
			number_uslovie = 3;
			uslovie_bool[0] = a.allcountries[selected_country].Gosstroy == 2;
			uslovie_text[0] = "Левая коалиция у власти";
			uslovie_bool[1] = a.allcountries[1].econ || a.allcountries[1].isSEV;
			uslovie_text[1] = "Союз основан или Китай в СЭВ";
			uslovie_bool[2] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = "Они не в экономическом союзе";
			if (a.allcountries[selected_country].Vyshi)
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[selected_country].Vyshi;
				uslovie_text[3] = "Страна не под влиянием США";
			}
		}
		else if (this_type == 55)
		{
			this_opis = "Оказать экономическое и политическое давление";
			number_uslovie = 4;
			uslovie_bool[0] = (a.allcountries[11].econ && a.allcountries[34].econ && a.allcountries[47].econ) || (a.allcountries[11].isSEV && a.allcountries[34].isSEV && a.allcountries[47].isSEV) || (a.allcountries[11].isASEAN && a.allcountries[34].isASEAN && a.allcountries[47].isASEAN);
			uslovie_text[0] = "Вьетнам, Таиланд и Филиппины в том же альянсе, что и мы";
			uslovie_bool[1] = a.data[9] >= 40;
			uslovie_text[1] = "Не менее 4 агентурных сетей";
			uslovie_bool[2] = a.SKRebel;
			uslovie_text[2] = "Поддержали восстание в Кванджу";
			if (a.ingamewars[0].is_going)
			{
				uslovie_bool[3] = !a.ingamewars[0].is_going;
				uslovie_text[3] = "Страна не в войне";
			}
			else
			{
				uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
				uslovie_text[3] = "Не оказывали давление";
			}
		}
		else if (this_type == 56)
		{
			this_opis = "Поддержать маоистов.|Сила маоистов: " + a.data[37] / 10 + "." + Mathf.Abs(a.data[37] % 10);
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 40;
			uslovie_text[0] = "4 агентурные сети";
			uslovie_bool[1] = a.data[22] >= 30;
			uslovie_text[1] = "Сила армии не менее 3";
			uslovie_bool[2] = a.data[6] >= 750;
			uslovie_text[2] = "Дипрепутация больше 75";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0 && a.data[37] < 1000;
			uslovie_text[3] = "Не поддержали в этом году";
		}
		else if (this_type == 57)
		{
			this_opis = "Разжечь усиленные протесты против апартеида";
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 100;
			uslovie_text[0] = "9 агентурных сетей";
			uslovie_bool[1] = a.data[8] + a.data[36] >= 100;
			uslovie_text[1] = "10 миллионов в бюджете";
			uslovie_bool[2] = a.data[21] >= 1980;
			uslovie_text[2] = "Не раньше 1980 года";
			uslovie_bool[3] = a.allcountries[selected_country].stab == 0;
			uslovie_text[3] = "Не разожгли протесты";
		}
		else if (this_type == 58)
		{
			this_opis = "Наложить санкции на правую диктатуру";
			number_uslovie = 3;
			if (selected_country == 52)
			{
				uslovie_bool[0] = (a.allcountries[47].econ && a.allcountries[50].econ && a.allcountries[49].econ) || (a.allcountries[47].isSEV && a.allcountries[50].isSEV && a.allcountries[49].isSEV) || (a.allcountries[11].isASEAN && a.allcountries[34].isASEAN && a.allcountries[49].isASEAN);
				uslovie_text[0] = "Индонезия, Филиппины и Малайзия в одном экономическом союзе с нами";
			}
			else
			{
				uslovie_bool[0] = (a.allcountries[11].econ && a.allcountries[34].econ && a.allcountries[49].econ) || (a.allcountries[11].isSEV && a.allcountries[34].isSEV && a.allcountries[49].isSEV) || (a.allcountries[11].isASEAN && a.allcountries[34].isASEAN && a.allcountries[49].isASEAN);
				uslovie_text[0] = "Вьетнам, Таиланд и Малайзия в одном экономическом союзе с нами";
			}
			if (selected_country == 52)
			{
				uslovie_bool[1] = a.data[8] + a.data[36] >= 80;
				uslovie_text[1] = "Не менее 8 миллионов";
			}
			else
			{
				uslovie_bool[1] = a.data[8] + a.data[36] >= 40;
				uslovie_text[1] = "Не менее 4 миллионов";
			}
			uslovie_bool[2] = a.allcountries[selected_country].stab == 0;
			uslovie_text[2] = "Не оказывали давление";
			if (selected_country == 52)
			{
				number_uslovie = 4;
				uslovie_bool[3] = a.influencePRC >= 700 && ((a.allcountries[1].isSEV && !a.allcountries[52].isSEV) || (a.allcountries[1].econ && !a.allcountries[52].econ) || (a.allcountries[1].isASEAN && !a.allcountries[52].isASEAN));
				uslovie_text[3] = GlobalScript.inst.other_text[467];
			}
		}
		else if (this_type == 60)
		{
			this_opis = "Подписать договор о дружбе и сотрудничестве";
			number_uslovie = 3;
			uslovie_bool[0] = a.empires[0].relations > 700;
			uslovie_text[0] = "Отношения с США больше 70";
			uslovie_bool[1] = a.data[6] < 500;
			uslovie_text[1] = "Дипрепутация меньше 50";
			uslovie_bool[2] = !a.allcountries[selected_country].Torg;
			uslovie_text[2] = "Не подписали";
		}
		else if (this_type == 61)
		{
			this_opis = "Начать сотрудничество с ЦРУ";
			number_uslovie = 3;
			uslovie_bool[0] = a.empires[0].relations > 800;
			uslovie_text[0] = "Отношения с США больше 80";
			uslovie_bool[1] = a.data[6] < 600;
			uslovie_text[1] = "Дипрепутация меньше 60";
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
			uslovie_text[2] = "Не начали сотрудничество";
		}
		else if (this_type == 62)
		{
			number_uslovie = 4;
			if (a.allcountries[selected_country].proprc)
			{
				this_opis = "Финансировать режим";
				uslovie_bool[2] = a.allcountries[selected_country].stab < 1200;
				uslovie_text[2] = "Стабильность менее 100";
				this_opis = this_opis + "|Стабильность: " + a.allcountries[selected_country].stab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].stab % 10);
				uslovie_bool[0] = a.data[9] >= 100;
				uslovie_text[0] = "10 агентурных сетей";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 40;
				uslovie_text[1] = "4 миллиона в бюджете";
				uslovie_bool[3] = a.data[22] >= 80;
				uslovie_text[3] = "8 военных группы";
			}
			else
			{
				this_opis = "Поддержать прокитайские силы";
				uslovie_bool[2] = a.allcountries[selected_country].prcpower < 1200;
				uslovie_text[2] = "Прокитайские силы менее 100";
				this_opis = this_opis + "|сила прокитайских: " + a.allcountries[selected_country].prcpower / 10 + "." + Mathf.Abs(a.allcountries[selected_country].prcpower % 10);
				uslovie_bool[0] = a.data[9] >= 80;
				uslovie_text[0] = "8 агентурных сетей";
				uslovie_bool[1] = a.data[8] + a.data[36] >= 40;
				uslovie_text[1] = "4 миллиона в бюджете";
				uslovie_bool[3] = a.data[22] >= 100;
				uslovie_text[3] = "10 военных групп";
			}
		}
		else if (this_type == 63)
		{
			this_opis = "Организовать союз с просоветскими силами";
			this_opis = this_opis + "|сила просоветских: " + a.allcountries[selected_country].sovpower / 10 + "." + Mathf.Abs(a.allcountries[selected_country].sovpower % 10);
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 20;
			uslovie_text[0] = "2 агентурные сети";
			uslovie_bool[1] = a.data[6] > 690;
			uslovie_text[1] = "Дипрепутация больше 69";
			uslovie_bool[2] = !a.allcountries[selected_country].usalliance && !a.allcountries[selected_country].sovalliance;
			uslovie_text[2] = "Нет союза";
			uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].proprc;
			uslovie_text[3] = "Страна не просоветская и не прокитайская";
		}
		else if (this_type == 64)
		{
			this_opis = "Организовать союз с проамериканскими силами";
			this_opis = this_opis + "|сила американских: " + a.allcountries[selected_country].usapower / 10 + "." + Mathf.Abs(a.allcountries[selected_country].usapower % 10);
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 20;
			uslovie_text[0] = "2 агентурные сети";
			uslovie_bool[1] = a.data[6] < 500;
			uslovie_text[1] = "Дипрепутация меньше 50";
			uslovie_bool[2] = !a.allcountries[selected_country].usalliance && !a.allcountries[selected_country].sovalliance;
			uslovie_text[2] = "Нет союза";
			uslovie_bool[3] = !a.allcountries[selected_country].Vyshi && !a.allcountries[selected_country].proprc;
			uslovie_text[3] = "Страна не проамериканская и не прокитайская";
		}
		else if (this_type == 65)
		{
			this_opis = "Разжечь волнения, дабы свергнуть правительство";
			this_opis = this_opis + "|Стабильность: " + a.allcountries[selected_country].stab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].stab % 10);
			number_uslovie = 2;
			uslovie_bool[0] = a.allcountries[selected_country].prcpower > 300;
			uslovie_text[0] = "Прокитайские силы больше 30";
			uslovie_bool[1] = !a.allcountries[selected_country].proprc;
			uslovie_text[1] = "Страна не прокитайская";
		}
		else if (this_type == 66)
		{
			if (!a.allcountries[selected_country].Torg)
			{
				this_opis = "Начать добычу ресурсов с эксклюзивными правами";
			}
			else
			{
				this_opis = "Прекратить добычу ресурсов с эксклюзивными правами";
			}
			this_opis = this_opis + "|Стабильность: " + a.allcountries[selected_country].stab / 10 + "." + Mathf.Abs(a.allcountries[selected_country].stab % 10);
			number_uslovie = 1;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = "Страна прокитайская";
		}
		else if (this_type == 70)
		{
			this_opis = "Оказать помощь ЗАНУ";
			number_uslovie = 3;
			uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
			uslovie_text[0] = "5 миллионов в бюджете";
			uslovie_bool[1] = a.event_done[88];
			uslovie_text[1] = "ЗАНУ победила на выборах";
			uslovie_bool[2] = !a.allcountries[selected_country].Torg;
			uslovie_text[2] = "Не оказали помощь";
		}
		else if (this_type == 82)
		{
			this_opis = GlobalScript.inst.other_text[29];
			number_uslovie = 3;
			uslovie_bool[0] = a.allcountries[selected_country].level_of_unstab - a.allcountries[selected_country].level_of_dev > 0;
			uslovie_text[0] = GlobalScript.inst.other_text[33];
			uslovie_bool[1] = !a.allcountries[selected_country].proprc;
			uslovie_text[1] = GlobalScript.inst.other_text[34];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
			uslovie_text[2] = GlobalScript.inst.other_text[35];
		}
		else if (this_type == 83)
		{
			this_opis = GlobalScript.inst.other_text[30];
			number_uslovie = 3;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = GlobalScript.inst.other_text[39];
			uslovie_bool[1] = a.allcountries[selected_country].Gosstroy == 2;
			uslovie_text[1] = GlobalScript.inst.other_text[40];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 50;
			uslovie_text[2] = GlobalScript.inst.other_text[35];
		}
		else if (this_type == 84)
		{
			this_opis = GlobalScript.inst.other_text[31];
			number_uslovie = 3;
			uslovie_bool[0] = a.science[19];
			uslovie_text[0] = GlobalScript.inst.other_text[42];
			uslovie_bool[1] = !a.allcountries[selected_country].proprc;
			uslovie_text[1] = GlobalScript.inst.other_text[34];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 20 && a.data[9] >= 20 && a.data[22] >= 20;
			uslovie_text[2] = GlobalScript.inst.other_text[53];
		}
		else if (this_type == 85)
		{
			this_opis = GlobalScript.inst.other_text[32];
			number_uslovie = 3;
			uslovie_bool[0] = a.science[20];
			uslovie_text[0] = GlobalScript.inst.other_text[43];
			uslovie_bool[1] = !a.allcountries[selected_country].proprc;
			uslovie_text[1] = GlobalScript.inst.other_text[34];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 20 && a.data[9] >= 20 && a.data[22] >= 20;
			uslovie_text[2] = GlobalScript.inst.other_text[53];
		}
		else if (this_type == 86)
		{
			this_opis = GlobalScript.inst.other_text[47];
			number_uslovie = 3;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = GlobalScript.inst.other_text[39];
			uslovie_bool[1] = a.allcountries[selected_country].Torg;
			uslovie_text[1] = GlobalScript.inst.other_text[46];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 35 && a.data[9] >= 35 && a.data[22] >= 35;
			uslovie_text[2] = GlobalScript.inst.other_text[41];
		}
		else if (this_type == 87)
		{
			this_opis = GlobalScript.inst.other_text[48];
			number_uslovie = 3;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = GlobalScript.inst.other_text[39];
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = GlobalScript.inst.other_text[44];
			uslovie_bool[2] = a.data[12] >= 500 && a.data[13] >= 500;
			uslovie_text[2] = GlobalScript.inst.other_text[45];
		}
		else if (this_type == 88)
		{
			this_opis = GlobalScript.inst.other_text[49];
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = GlobalScript.inst.other_text[39];
			uslovie_bool[1] = a.allcountries[selected_country].Torg;
			uslovie_text[1] = GlobalScript.inst.other_text[46];
			uslovie_bool[2] = a.influencePRC >= 150 && a.allcountries[selected_country].level_of_dev - a.allcountries[selected_country].level_of_unstab >= 30;
			uslovie_text[2] = GlobalScript.inst.other_text[50];
			uslovie_bool[3] = (a.allcountries[1].econ || a.allcountries[1].isSEV) && !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV;
			uslovie_text[3] = ((a.allcountries[1].econ || a.allcountries[1].isSEV) ? GlobalScript.inst.other_text[51] : GlobalScript.inst.other_text[52]);
		}
		else if (this_type == 91)
		{
			this_opis = GlobalScript.inst.other_text[58];
			number_uslovie = 4;
			uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
			uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 5);
			uslovie_bool[1] = a.data[9] >= 30;
			uslovie_text[1] = string.Format(GlobalScript.inst.other_text[61], 3);
			if (!a.event_done[366])
			{
				uslovie_bool[2] = (a.data[20] > 4 && a.data[21] >= 1977) || a.data[21] > 1977;
				uslovie_text[2] = GlobalScript.inst.other_text[62];
			}
			else
			{
				uslovie_bool[2] = !a.event_done[367];
				uslovie_text[2] = GlobalScript.inst.other_text[63];
			}
			if (!a.event_done[366])
			{
				uslovie_bool[3] = !a.event_done[366];
				uslovie_text[3] = GlobalScript.inst.other_text[64];
			}
			else
			{
				uslovie_bool[3] = a.resultOfEvents[366] != 0 && a.resultOfEvents[366] != 1;
				uslovie_text[3] = GlobalScript.inst.other_text[64];
			}
		}
		else if (this_type == 92)
		{
			this_opis = GlobalScript.inst.other_text[59];
			number_uslovie = 4;
			uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
			uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 5);
			uslovie_bool[1] = a.data[9] >= 30;
			uslovie_text[1] = string.Format(GlobalScript.inst.other_text[61], 3);
			if (!a.event_done[366])
			{
				uslovie_bool[2] = (a.data[20] > 4 && a.data[21] >= 1977) || a.data[21] > 1977;
				uslovie_text[2] = GlobalScript.inst.other_text[62];
			}
			else
			{
				uslovie_bool[2] = !a.event_done[367];
				uslovie_text[2] = GlobalScript.inst.other_text[63];
			}
			if (!a.event_done[366])
			{
				uslovie_bool[3] = !a.event_done[366];
				uslovie_text[3] = GlobalScript.inst.other_text[64];
			}
			else
			{
				uslovie_bool[3] = a.resultOfEvents[366] != 0 && a.resultOfEvents[366] != 1;
				uslovie_text[3] = GlobalScript.inst.other_text[64];
			}
		}
		else if (this_type == 93)
		{
			this_opis = "Начать углублённую торговлю";
			number_uslovie = 4;
			if (a.allcountries[selected_country].Gosstroy == 1)
			{
				uslovie_bool[0] = a.data[6] >= 800;
				uslovie_text[0] = "Дипрепутация не ниже 80";
			}
			else if (a.allcountries[selected_country].Gosstroy <= 2)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
				uslovie_text[0] = "Дипрепутация между 39 и 85";
			}
			else
			{
				uslovie_bool[0] = a.data[6] < 500;
				uslovie_text[0] = "Дипрепутация меньше 50";
			}
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Торговля не ведётся";
			uslovie_bool[2] = a.data[12] >= 500;
			uslovie_text[2] = "Промышленность не ниже 50";
			uslovie_bool[3] = a.Israellost;
			uslovie_text[3] = "Израиль проиграл Ливанскую войну";
		}
		else if (this_type == 94)
		{
			this_opis = GlobalScript.inst.other_text[66];
			number_uslovie = 2;
			uslovie_bool[0] = a.data[124] >= 1;
			uslovie_text[0] = GlobalScript.inst.other_text[67];
			uslovie_bool[1] = a.data[124] != 100;
			uslovie_text[1] = GlobalScript.inst.other_text[68];
		}
		else if (this_type == 95)
		{
			this_opis = GlobalScript.inst.other_text[69];
			number_uslovie = 3;
			uslovie_bool[0] = a.data[127] >= 1 || a.allcountries[84].Gosstroy == 2;
			uslovie_text[0] = GlobalScript.inst.other_text[70];
			uslovie_bool[1] = a.data[127] != 100;
			uslovie_text[1] = GlobalScript.inst.other_text[68];
			uslovie_bool[2] = a.data[21] >= 1983;
			uslovie_text[2] = GlobalScript.inst.other_text[71];
		}
		else if (this_type == 96)
		{
			this_opis = "Начать углублённую торговлю";
			number_uslovie = 3;
			uslovie_bool[0] = !a.allcountries[selected_country].Torg;
			uslovie_text[0] = "Торговля не ведётся";
			uslovie_bool[1] = a.data[12] >= 500;
			uslovie_text[1] = "Промышленность не ниже 50";
			uslovie_bool[2] = !a.ingamewars[8].is_going;
			uslovie_text[2] = GlobalScript.inst.other_text[72];
		}
		else if (this_type == 97)
		{
			this_opis = GlobalScript.inst.other_text[74];
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[19].proprc && ((a.allcountries[19].okb && a.allcountries[19].econ) || (a.allcountries[19].isSEV && a.allcountries[19].isOVD) || a.allcountries[19].isNATO);
			uslovie_text[0] = GlobalScript.inst.other_text[75];
			uslovie_bool[1] = a.influencePRC > 600;
			uslovie_text[1] = GlobalScript.inst.other_text[76];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 200 && a.data[9] >= 200;
			uslovie_text[2] = GlobalScript.inst.other_text[77];
			uslovie_bool[3] = !a.allcountries[selected_country].proprc;
			uslovie_text[3] = GlobalScript.inst.other_text[78];
		}
		else if (this_type == 98)
		{
			this_opis = GlobalScript.inst.other_text[81];
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].Torg;
			uslovie_text[0] = GlobalScript.inst.other_text[83];
			uslovie_bool[1] = a.influencePRC > 700;
			uslovie_text[1] = GlobalScript.inst.other_text[86];
			uslovie_bool[2] = a.allcountries[1].isSEV || a.allcountries[1].econ;
			uslovie_text[2] = GlobalScript.inst.other_text[84];
			uslovie_bool[3] = !a.allcountries[selected_country].econ && !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].isASEAN;
			uslovie_text[3] = GlobalScript.inst.other_text[88];
		}
		else if (this_type == 99)
		{
			this_opis = GlobalScript.inst.other_text[82];
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].isSEV || a.allcountries[selected_country].econ;
			uslovie_text[0] = GlobalScript.inst.other_text[90];
			uslovie_bool[1] = a.influencePRC > 800;
			uslovie_text[1] = GlobalScript.inst.other_text[87];
			uslovie_bool[2] = a.allcountries[1].isSEV || a.allcountries[1].econ || a.allcountries[1].isNATO;
			uslovie_text[2] = GlobalScript.inst.other_text[84];
			uslovie_bool[3] = !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isSEATO && !a.allcountries[selected_country].isOVD;
			uslovie_text[3] = GlobalScript.inst.other_text[89];
		}
		else if (this_type == 100)
		{
			number_uslovie = 3;
			this_opis = GlobalScript.inst.other_text[107];
			uslovie_bool[0] = a.influencePRC >= 700;
			uslovie_text[0] = GlobalScript.inst.other_text[86];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 150 && a.data[9] >= 150;
			uslovie_text[1] = GlobalScript.inst.other_text[108];
			uslovie_bool[2] = a.allcountries[selected_country].dev <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[109];
			if (a.allcountries[7].isNATO)
			{
				number_uslovie = 4;
				uslovie_bool[3] = !a.allcountries[7].isNATO;
				uslovie_text[3] = GlobalScript.inst.other_text[105];
			}
		}
		else if (this_type == 101)
		{
			number_uslovie = 4;
			this_opis = GlobalScript.inst.other_text[81];
			uslovie_bool[0] = a.allcountries[selected_country].based;
			uslovie_text[0] = GlobalScript.inst.other_text[169];
			uslovie_bool[1] = a.allcountries[selected_country].Torg;
			uslovie_text[1] = GlobalScript.inst.other_text[83];
			uslovie_bool[2] = !a.allcountries[selected_country].isSEV && !a.allcountries[selected_country].econ;
			uslovie_text[2] = GlobalScript.inst.other_text[88];
			uslovie_bool[3] = a.allcountries[1].isSEV || a.allcountries[1].econ;
			uslovie_text[3] = GlobalScript.inst.other_text[84];
		}
		else if (this_type == 102)
		{
			this_opis = "Начать углублённую торговлю";
			number_uslovie = 4;
			if (a.allcountries[selected_country].Gosstroy == 1)
			{
				uslovie_bool[0] = a.data[6] >= 690;
				uslovie_text[0] = "Дипрепутация больше 69";
			}
			else if (a.allcountries[selected_country].Gosstroy <= 2)
			{
				uslovie_bool[0] = a.data[6] > 390 && a.data[6] < 850;
				uslovie_text[0] = "Дипрепутация между 39 и 85";
			}
			else if (a.allcountries[selected_country].Gosstroy == 3)
			{
				uslovie_bool[0] = a.data[6] < 500;
				uslovie_text[0] = "Дипрепутация меньше 50";
			}
			uslovie_bool[1] = !a.allcountries[selected_country].Torg;
			uslovie_text[1] = "Торговля не ведётся";
			uslovie_bool[2] = a.data[12] >= 500;
			uslovie_text[2] = "Промышленность не ниже 50";
			uslovie_bool[3] = a.allcountries[selected_country].parts[0];
			uslovie_text[3] = GlobalScript.inst.other_text[117];
		}
		else if (this_type == 103)
		{
			this_opis = string.Format(GlobalScript.inst.other_text[122], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].inflCh < 1000;
			uslovie_text[0] = GlobalScript.inst.other_text[127];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 100;
			uslovie_text[1] = GlobalScript.inst.other_text[128];
			uslovie_bool[2] = a.data[9] >= 50;
			uslovie_text[2] = GlobalScript.inst.other_text[129];
			uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
			uslovie_text[3] = GlobalScript.inst.other_text[130];
		}
		else if (this_type == 104)
		{
			this_opis = string.Format(GlobalScript.inst.other_text[126], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].inflCh >= 350;
			uslovie_text[0] = GlobalScript.inst.other_text[125];
			uslovie_bool[1] = !a.allcountries[selected_country].econ;
			uslovie_text[1] = GlobalScript.inst.other_text[88];
			uslovie_bool[2] = a.allcountries[selected_country].Torg;
			uslovie_text[2] = GlobalScript.inst.other_text[83];
			uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
			uslovie_text[3] = GlobalScript.inst.other_text[130];
		}
		else if (this_type == 105)
		{
			this_opis = string.Format(GlobalScript.inst.other_text[132], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].inflCh >= 600;
			uslovie_text[0] = GlobalScript.inst.other_text[133];
			uslovie_bool[1] = !a.allcountries[selected_country].based && a.allcountries[selected_country].econ;
			uslovie_text[1] = GlobalScript.inst.other_text[134];
			uslovie_bool[2] = a.data[22] >= 250;
			uslovie_text[2] = GlobalScript.inst.other_text[135];
			uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
			uslovie_text[3] = GlobalScript.inst.other_text[130];
		}
		else if (this_type == 106)
		{
			this_opis = string.Format(GlobalScript.inst.other_text[136], GlobalScript.inst.other_text[123], (float)a.allcountries[selected_country].inflCh / 10f, GlobalScript.inst.other_text[124], (float)a.allcountries[selected_country].inflNATO / 10f, '\n');
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].inflCh >= 900;
			uslovie_text[0] = GlobalScript.inst.other_text[138];
			uslovie_bool[1] = a.allcountries[selected_country].based && !a.allcountries[selected_country].okb;
			uslovie_text[1] = GlobalScript.inst.other_text[137];
			uslovie_bool[2] = a.data[7] > a.empires[0].power + a.empires[1].power;
			uslovie_text[2] = GlobalScript.inst.other_text[139];
			uslovie_bool[3] = !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi;
			uslovie_text[3] = GlobalScript.inst.other_text[130];
		}
		else if (this_type == 107)
		{
			if (!a.modifies[41].active)
			{
				this_opis = GlobalScript.inst.other_text[141];
				number_uslovie = 4;
				uslovie_bool[0] = a.data[6] < 600 && a.data[21] > 1979;
				uslovie_text[0] = GlobalScript.inst.other_text[142];
				uslovie_bool[1] = a.allcountries[30].Vyshi && (a.allcountries[8].Gosstroy == 3 || a.allcountries[8].Vyshi);
				uslovie_text[1] = GlobalScript.inst.other_text[143];
				uslovie_bool[2] = !a.allcountries[1].isSEV && a.science[19];
				uslovie_text[2] = GlobalScript.inst.other_text[144];
				uslovie_bool[3] = (a.data[131] == 0 || a.data[131] == 3) && !a.modifies[41].active;
				uslovie_text[3] = GlobalScript.inst.other_text[145];
			}
			else
			{
				this_opis = GlobalScript.inst.other_text[146];
				number_uslovie = 1;
				uslovie_bool[0] = a.modifies[41].active;
				uslovie_text[0] = GlobalScript.inst.other_text[147];
			}
		}
		else if (this_type == 108)
		{
			this_opis = string.Format(GlobalScript.inst.other_text[152], '\n', (float)a.data[134] / 10f);
			number_uslovie = 4;
			uslovie_bool[0] = a.data[8] + a.data[36] >= 50;
			uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 5);
			uslovie_bool[1] = a.data[22] >= 50;
			uslovie_text[1] = string.Format(GlobalScript.inst.other_text[156], 5);
			uslovie_bool[2] = a.data[134] < 1000 && a.data[134] >= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[150];
			uslovie_bool[3] = !a.event_done[396];
			uslovie_text[3] = GlobalScript.inst.other_text[303];
		}
		else if (this_type == 109)
		{
			this_opis = GlobalScript.inst.other_text[153];
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 150;
			uslovie_text[0] = string.Format(GlobalScript.inst.other_text[60], 15);
			uslovie_bool[1] = a.data[22] >= 150;
			uslovie_text[1] = string.Format(GlobalScript.inst.other_text[156], 15);
			uslovie_bool[2] = a.data[134] >= 1000;
			uslovie_text[2] = GlobalScript.inst.other_text[155];
			uslovie_bool[3] = !a.event_done[396] && a.empires[0].power + a.empires[1].power < 350;
			uslovie_text[3] = GlobalScript.inst.other_text[151];
		}
		else if (this_type == 110)
		{
			number_uslovie = 4;
			if (selected_country == 41)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[159], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
			}
			else if (selected_country == 99)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[167], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
			}
			else if (selected_country == 100)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[163], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
			}
			uslovie_bool[0] = a.allcountries[selected_country].inflCh < 1000;
			uslovie_text[0] = GlobalScript.inst.other_text[170];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = GlobalScript.inst.other_text[171];
			uslovie_bool[2] = a.data[22] >= 50;
			uslovie_text[2] = GlobalScript.inst.other_text[172];
			uslovie_bool[3] = !a.allcountries[selected_country].based;
			uslovie_text[3] = GlobalScript.inst.other_text[173];
		}
		else if (this_type == 111)
		{
			number_uslovie = 4;
			if (selected_country == 41)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[160], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
			}
			else if (selected_country == 99)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[168], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
			}
			else if (selected_country == 100)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[164], '\n', (float)a.allcountries[selected_country].inflCh / 10f, (float)a.allcountries[selected_country].inflNATO / 10f);
			}
			uslovie_bool[0] = a.allcountries[selected_country].inflNATO < 1000;
			uslovie_text[0] = GlobalScript.inst.other_text[174];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = GlobalScript.inst.other_text[171];
			uslovie_bool[2] = a.data[22] >= 50;
			uslovie_text[2] = GlobalScript.inst.other_text[172];
			uslovie_bool[3] = !a.allcountries[selected_country].based;
			uslovie_text[3] = GlobalScript.inst.other_text[173];
		}
		else if (this_type == 112)
		{
			number_uslovie = 3;
			this_opis = GlobalScript.inst.other_text[82];
			uslovie_bool[0] = a.allcountries[selected_country].isSEV || a.allcountries[selected_country].econ;
			uslovie_text[0] = GlobalScript.inst.other_text[90];
			uslovie_bool[1] = a.allcountries[selected_country].Torg && a.allcountries[selected_country].proprc;
			uslovie_text[1] = GlobalScript.inst.other_text[175];
			uslovie_bool[2] = !a.allcountries[selected_country].okb && !a.allcountries[selected_country].isOVD && (a.allcountries[1].isOVD || a.allcountries[1].okb);
			uslovie_text[2] = GlobalScript.inst.other_text[85];
		}
		else if (this_type == 113)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[177], '\n', a.allcountries[selected_country].inflNATO);
			uslovie_bool[0] = a.data[8] + a.data[36] >= 30 && a.data[9] >= 30;
			uslovie_text[0] = GlobalScript.inst.other_text[178];
			uslovie_bool[1] = !a.modifies[3].active;
			uslovie_text[1] = GlobalScript.inst.other_text[179];
			uslovie_bool[2] = a.allcountries[selected_country].spec <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[180];
			uslovie_bool[3] = a.data[21] < 1981;
			uslovie_text[3] = GlobalScript.inst.other_text[181];
		}
		else if (this_type == 114)
		{
			number_uslovie = 3;
			this_opis = string.Format(GlobalScript.inst.other_text[185], '\n');
			uslovie_bool[0] = a.modifies[48].active;
			uslovie_text[0] = GlobalScript.inst.other_text[187];
			uslovie_bool[1] = a.allcountries[1].inflNATO <= 0;
			uslovie_text[1] = GlobalScript.inst.other_text[180];
			uslovie_bool[2] = a.allcountries[1].dev <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[189];
		}
		else if (this_type == 115)
		{
			number_uslovie = 3;
			this_opis = string.Format(GlobalScript.inst.other_text[186], '\n');
			uslovie_bool[0] = a.modifies[47].active;
			uslovie_text[0] = GlobalScript.inst.other_text[188];
			uslovie_bool[1] = a.allcountries[1].inflCh <= 0;
			uslovie_text[1] = GlobalScript.inst.other_text[180];
			uslovie_bool[2] = a.allcountries[1].dev <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[189];
		}
		else if (this_type == 116)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[325], '\n');
			uslovie_bool[0] = a.influencePRC + a.empires[0].power >= a.empires[1].power || a.influencePRC >= 1000;
			uslovie_text[0] = GlobalScript.inst.other_text[326];
			uslovie_bool[1] = !a.allcountries[2].isOVD && !a.allcountries[5].isOVD && !a.allcountries[4].isOVD;
			uslovie_text[1] = GlobalScript.inst.other_text[327];
			uslovie_bool[2] = a.empires[1].now_leader == 6;
			uslovie_text[2] = GlobalScript.inst.other_text[328];
			uslovie_bool[3] = a.allcountries[17].dev <= 0;
			uslovie_text[3] = GlobalScript.inst.other_text[194];
		}
		else if (this_type == 117)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[196], '\n');
			uslovie_bool[0] = a.allcountries[1].Gosstroy != 1 && a.data[52] > 34;
			uslovie_text[0] = GlobalScript.inst.other_text[197];
			uslovie_bool[1] = !a.allcountries[1].isSEV && !a.allcountries[1].econ;
			uslovie_text[1] = GlobalScript.inst.other_text[198];
			uslovie_bool[2] = !a.allcountries[1].isASEAN;
			uslovie_text[2] = GlobalScript.inst.other_text[199];
			uslovie_bool[3] = a.data[21] > 1978;
			uslovie_text[3] = GlobalScript.inst.other_text[200];
		}
		else if (this_type == 118)
		{
			number_uslovie = 3;
			this_opis = string.Format(GlobalScript.inst.other_text[202], '\n');
			uslovie_bool[0] = a.allcountries[1].isASEAN;
			uslovie_text[0] = GlobalScript.inst.other_text[203];
			uslovie_bool[1] = !a.allcountries[15].cw;
			uslovie_text[1] = GlobalScript.inst.other_text[204];
			uslovie_bool[2] = !a.allcountries[1].isSEATO;
			uslovie_text[2] = GlobalScript.inst.other_text[199];
		}
		else if (this_type == 119)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[206], '\n');
			uslovie_bool[0] = a.allcountries[1].isASEAN;
			uslovie_text[0] = GlobalScript.inst.other_text[203];
			uslovie_bool[1] = !a.allcountries[selected_country].prosov;
			uslovie_text[1] = GlobalScript.inst.other_text[207];
			uslovie_bool[2] = !a.allcountries[selected_country].isASEAN && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = GlobalScript.inst.other_text[208];
			if (selected_country != 38)
			{
				uslovie_bool[3] = a.allcountries[selected_country].Gosstroy != 1;
				uslovie_text[3] = GlobalScript.inst.other_text[209];
			}
			else
			{
				uslovie_bool[3] = a.data[64] == 1 || a.completedDecisions[6];
				uslovie_text[3] = GlobalScript.inst.other_text[233];
			}
		}
		else if (this_type == 120)
		{
			number_uslovie = 3;
			if (!a.allcountries[51].cw)
			{
				this_opis = string.Format(GlobalScript.inst.other_text[210], '\n');
			}
			else
			{
				this_opis = string.Format(GlobalScript.inst.other_text[211], '\n');
			}
			uslovie_bool[0] = a.allcountries[1].isASEAN;
			if (!a.allcountries[51].cw)
			{
				uslovie_text[0] = GlobalScript.inst.other_text[212];
			}
			else
			{
				uslovie_text[0] = GlobalScript.inst.other_text[213];
			}
			uslovie_bool[1] = a.allcountries[selected_country].isASEAN;
			uslovie_text[1] = GlobalScript.inst.other_text[214];
			uslovie_bool[2] = !a.allcountries[selected_country].isSEATO && !a.allcountries[selected_country].isOVD;
			uslovie_text[2] = GlobalScript.inst.other_text[215];
			if (selected_country == 8 || selected_country == 12 || selected_country == 14 || selected_country == 35 || selected_country == 31 || selected_country == 37 || selected_country == 36 || selected_country == 25)
			{
				number_uslovie = 4;
				uslovie_bool[3] = a.allcountries[51].cw;
				uslovie_text[3] = GlobalScript.inst.other_text[216];
			}
		}
		else if (this_type == 121)
		{
			if (selected_country == 24)
			{
				this_opis = GlobalScript.inst.other_text[218];
			}
			else
			{
				this_opis = GlobalScript.inst.other_text[206];
			}
			number_uslovie = 4;
			uslovie_bool[0] = a.allcountries[selected_country].Torg;
			uslovie_text[0] = GlobalScript.inst.other_text[83];
			if (selected_country == 24)
			{
				uslovie_bool[1] = a.allcountries[1].isSEV;
				uslovie_text[1] = GlobalScript.inst.other_text[220];
			}
			else
			{
				uslovie_bool[1] = a.allcountries[1].isASEAN;
				uslovie_text[1] = GlobalScript.inst.other_text[203];
			}
			uslovie_bool[2] = !a.allcountries[selected_country].isASEAN && !a.allcountries[selected_country].isSEV;
			uslovie_text[2] = GlobalScript.inst.other_text[88];
			uslovie_bool[3] = a.allcountries[selected_country].parts[0];
			uslovie_text[3] = GlobalScript.inst.other_text[219];
		}
		else if (this_type == 122)
		{
			this_opis = GlobalScript.inst.other_text[221];
			number_uslovie = 3;
			uslovie_bool[0] = a.data[9] >= 100 && a.data[8] + a.data[36] >= 300;
			uslovie_text[0] = GlobalScript.inst.other_text[222];
			uslovie_bool[1] = a.event_done[91] && a.allcountries[46].Gosstroy == 0;
			uslovie_text[1] = GlobalScript.inst.other_text[223];
			uslovie_bool[2] = a.allcountries[selected_country].dev == 0;
			uslovie_text[2] = GlobalScript.inst.other_text[224];
		}
		else if (this_type == 123)
		{
			this_opis = GlobalScript.inst.other_text[227];
			number_uslovie = 4;
			uslovie_bool[0] = a.data[9] >= 50 && a.data[8] + a.data[36] >= 30;
			uslovie_text[0] = GlobalScript.inst.other_text[228];
			uslovie_bool[1] = !a.modifies[6].active;
			uslovie_text[1] = GlobalScript.inst.other_text[229];
			uslovie_bool[2] = a.data[6] <= 750;
			uslovie_text[2] = GlobalScript.inst.other_text[230];
			if (a.empires[1].power < 50)
			{
				uslovie_bool[3] = a.empires[1].power >= 50;
				uslovie_text[3] = GlobalScript.inst.other_text[231];
			}
			else
			{
				uslovie_bool[3] = !a.war_active[1];
				uslovie_text[3] = GlobalScript.inst.other_text[232];
			}
		}
		else if (this_type == 124)
		{
			number_uslovie = 2;
			this_opis = GlobalScript.inst.other_text[235];
			uslovie_bool[0] = a.allcountries[1].isSEV || a.allcountries[1].isASEAN;
			uslovie_text[0] = GlobalScript.inst.other_text[236];
			uslovie_bool[1] = !a.allcountries[1].based;
			uslovie_text[1] = GlobalScript.inst.other_text[237];
		}
		else if (this_type == 125)
		{
			number_uslovie = 4;
			if (a.allcountries[1].isSEATO)
			{
				this_opis = GlobalScript.inst.other_text[239];
			}
			else
			{
				this_opis = GlobalScript.inst.other_text[252];
			}
			uslovie_bool[0] = a.allcountries[selected_country].prcinfl >= 800;
			uslovie_text[0] = GlobalScript.inst.other_text[284];
			uslovie_bool[1] = a.data[9] >= 100 && a.data[8] + a.data[36] >= 50;
			uslovie_text[1] = GlobalScript.inst.other_text[241];
			if (a.allcountries[1].isSEATO)
			{
				uslovie_bool[2] = a.empires[0].relations >= 700;
				uslovie_text[2] = GlobalScript.inst.other_text[242];
			}
			else
			{
				uslovie_bool[2] = a.empires[1].relations >= 700;
				uslovie_text[2] = GlobalScript.inst.other_text[253];
			}
			uslovie_bool[3] = !a.allcountries[selected_country].perevorot;
			uslovie_text[3] = GlobalScript.inst.other_text[237];
		}
		else if (this_type == 126)
		{
			number_uslovie = 4;
			this_opis = GlobalScript.inst.other_text[245];
			uslovie_bool[0] = a.allcountries[11].isSEATO && a.allcountries[34].isSEATO && a.allcountries[23].isSEATO;
			uslovie_text[0] = GlobalScript.inst.other_text[246];
			uslovie_bool[1] = a.influencePRC + a.empires[0].power >= a.empires[1].power;
			uslovie_text[1] = GlobalScript.inst.other_text[247];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 100 && a.data[9] >= 100 && a.data[2] >= 250;
			uslovie_text[2] = GlobalScript.inst.other_text[248];
			uslovie_bool[3] = !a.allcountries[selected_country].cw;
			uslovie_text[3] = GlobalScript.inst.other_text[249];
		}
		else if (this_type == 127)
		{
			number_uslovie = 4;
			this_opis = GlobalScript.inst.other_text[257];
			uslovie_bool[0] = a.data[131] == 3;
			uslovie_text[0] = GlobalScript.inst.other_text[258];
			uslovie_bool[1] = a.influencePRC >= a.empires[0].power;
			uslovie_text[1] = GlobalScript.inst.other_text[259];
			uslovie_bool[2] = !a.allcountries[85].isNATO && !a.allcountries[45].isNATO && !a.allcountries[87].isNATO && !a.allcountries[85].isEU && !a.allcountries[45].isEU && !a.allcountries[87].isEU;
			uslovie_text[2] = GlobalScript.inst.other_text[260];
			uslovie_bool[3] = a.allcountries[21].isNATO;
			uslovie_text[3] = GlobalScript.inst.other_text[261];
		}
		else if (this_type == 128)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[264], '\n', a.allcountries[87].spec);
			uslovie_bool[0] = a.allcountries[87].spec < 100;
			uslovie_text[0] = GlobalScript.inst.other_text[266];
			uslovie_bool[1] = a.data[8] + a.data[36] >= a.allcountries[87].inflCh && a.data[9] >= a.allcountries[87].inflNATO;
			uslovie_text[1] = string.Format(GlobalScript.inst.other_text[267], (float)a.allcountries[87].inflNATO / 10f, (float)a.allcountries[87].inflCh / 10f);
			uslovie_bool[2] = a.allcountries[87].Gosstroy != 3;
			uslovie_text[2] = GlobalScript.inst.other_text[269];
			if (!a.event_done[414])
			{
				uslovie_bool[3] = a.event_done[414];
				uslovie_text[3] = GlobalScript.inst.other_text[268];
			}
			else
			{
				uslovie_bool[3] = a.data[21] < 1982 && !a.allcountries[87].based;
				uslovie_text[3] = GlobalScript.inst.other_text[265];
			}
		}
		else if (this_type == 129)
		{
			number_uslovie = 4;
			this_opis = GlobalScript.inst.other_text[271];
			uslovie_bool[0] = (a.allcountries[1].econ && a.allcountries[11].econ && a.allcountries[34].econ && a.allcountries[47].econ) || (a.allcountries[1].isSEV && a.allcountries[11].isSEV && a.allcountries[34].isSEV && a.allcountries[47].isSEV) || (a.allcountries[1].isASEAN && a.allcountries[11].isASEAN && a.allcountries[34].isASEAN && a.allcountries[47].isASEAN);
			uslovie_text[0] = GlobalScript.inst.other_text[272];
			uslovie_bool[1] = !a.allcountries[1].isASEAN;
			uslovie_text[1] = GlobalScript.inst.other_text[273];
			uslovie_bool[2] = a.allcountries[49].isASEAN;
			uslovie_text[2] = GlobalScript.inst.other_text[274];
			if (!a.allcountries[1].isSEV)
			{
				uslovie_bool[3] = a.influencePRC >= 300 && a.data[8] + a.data[36] >= 150;
				uslovie_text[3] = GlobalScript.inst.other_text[275];
			}
			else
			{
				uslovie_bool[3] = a.influencePRC + a.empires[1].power >= 300 && a.data[8] + a.data[36] >= 150;
				uslovie_text[3] = GlobalScript.inst.other_text[276];
			}
		}
		else if (this_type == 130)
		{
			number_uslovie = 3;
			if (a.allcountries[selected_country].sovinfl > 1000)
			{
				a.allcountries[selected_country].sovinfl = 1000;
			}
			if (a.allcountries[selected_country].sovinfl < 0)
			{
				a.allcountries[selected_country].sovinfl = 0;
			}
			if (a.allcountries[selected_country].prcinfl > 1000)
			{
				a.allcountries[selected_country].prcinfl = 1000;
			}
			if (a.allcountries[selected_country].prcinfl < 0)
			{
				a.allcountries[selected_country].prcinfl = 0;
			}
			this_opis = string.Format(GlobalScript.inst.other_text[278], '\n', (float)a.allcountries[selected_country].sovinfl / 10f, (float)a.allcountries[selected_country].prcinfl / 10f);
			uslovie_bool[0] = a.allcountries[selected_country].prosov || (!a.allcountries[selected_country].proprc && !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi);
			uslovie_text[0] = GlobalScript.inst.other_text[279];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 80;
			uslovie_text[1] = GlobalScript.inst.other_text[280];
			uslovie_bool[2] = a.allcountries[selected_country].prcinfl < 1000;
			uslovie_text[2] = GlobalScript.inst.other_text[281];
		}
		else if (this_type == 131)
		{
			number_uslovie = 3;
			if (a.allcountries[selected_country].usainfl > 1000)
			{
				a.allcountries[selected_country].usainfl = 1000;
			}
			if (a.allcountries[selected_country].usainfl < 0)
			{
				a.allcountries[selected_country].usainfl = 0;
			}
			if (a.allcountries[selected_country].prcinfl > 1000)
			{
				a.allcountries[selected_country].prcinfl = 1000;
			}
			if (a.allcountries[selected_country].prcinfl < 0)
			{
				a.allcountries[selected_country].prcinfl = 0;
			}
			this_opis = string.Format(GlobalScript.inst.other_text[282], '\n', (float)a.allcountries[selected_country].usainfl / 10f, (float)a.allcountries[selected_country].prcinfl / 10f);
			uslovie_bool[0] = a.allcountries[selected_country].Vyshi || (!a.allcountries[selected_country].proprc && !a.allcountries[selected_country].prosov && !a.allcountries[selected_country].Vyshi);
			uslovie_text[0] = GlobalScript.inst.other_text[283];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[22] >= 80;
			uslovie_text[1] = GlobalScript.inst.other_text[280];
			uslovie_bool[2] = a.allcountries[selected_country].prcinfl < 1000;
			uslovie_text[2] = GlobalScript.inst.other_text[281];
		}
		else if (this_type == 132)
		{
			number_uslovie = 3;
			this_opis = GlobalScript.inst.other_text[286];
			uslovie_bool[0] = a.allcountries[selected_country].proprc;
			uslovie_text[0] = GlobalScript.inst.other_text[287];
			uslovie_bool[1] = a.allcountries[selected_country].SubGosstroy != a.allcountries[1].SubGosstroy;
			uslovie_text[1] = GlobalScript.inst.other_text[288];
			uslovie_bool[2] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
			uslovie_text[2] = GlobalScript.inst.other_text[289];
		}
		else if (this_type == 133)
		{
			number_uslovie = 4;
			this_opis = GlobalScript.inst.other_text[294];
			uslovie_bool[0] = a.allcountries[36].cw && a.allcountries[14].puppetOf <= 0;
			uslovie_text[0] = GlobalScript.inst.other_text[295];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 250 && a.data[9] >= 150 && a.data[22] >= 350;
			uslovie_text[1] = GlobalScript.inst.other_text[296];
			if (a.allcountries[1].okb)
			{
				uslovie_bool[2] = a.influencePRC >= a.empires[0].power + a.empires[1].power;
				uslovie_text[2] = GlobalScript.inst.other_text[297];
			}
			else if (a.allcountries[1].isOVD)
			{
				uslovie_bool[2] = a.influencePRC + a.empires[1].power >= a.empires[0].power;
				uslovie_text[2] = GlobalScript.inst.other_text[300];
			}
			else if (a.allcountries[1].isSEATO)
			{
				uslovie_bool[2] = a.influencePRC + a.empires[0].power >= a.empires[1].power;
				uslovie_text[2] = GlobalScript.inst.other_text[301];
			}
			else
			{
				uslovie_bool[2] = a.allcountries[1].okb || a.allcountries[1].isSEATO || a.allcountries[1].isOVD;
				uslovie_text[2] = GlobalScript.inst.other_text[302];
			}
			uslovie_bool[3] = !a.allcountries[14].cw;
			uslovie_text[3] = GlobalScript.inst.other_text[298];
		}
		else if (this_type == 134)
		{
			if (a.allcountries[selected_country].usainfl > 1000)
			{
				a.allcountries[selected_country].usainfl = 1000;
			}
			if (a.allcountries[selected_country].prcinfl > 1000)
			{
				a.allcountries[selected_country].prcinfl = 1000;
			}
			if (a.allcountries[selected_country].sovinfl > 1000)
			{
				a.allcountries[selected_country].sovinfl = 1000;
			}
			if (a.allcountries[selected_country].usainfl < 0)
			{
				a.allcountries[selected_country].usainfl = 0;
			}
			if (a.allcountries[selected_country].prcinfl < 0)
			{
				a.allcountries[selected_country].prcinfl = 0;
			}
			if (a.allcountries[selected_country].sovinfl < 0)
			{
				a.allcountries[selected_country].sovinfl = 0;
			}
			if (!a.allcountries[selected_country].dota)
			{
				number_uslovie = 2;
				this_opis = string.Format("{0}{1}{3}: {2}; {5}: {4}", GlobalScript.inst.other_text[304], '\n', a.allcountries[1].isSEATO ? ((float)a.allcountries[selected_country].usainfl / 10f) : ((float)a.allcountries[selected_country].sovinfl / 10f), a.allcountries[1].isSEATO ? GlobalScript.inst.new_texts[167] : GlobalScript.inst.new_texts[168], (float)a.allcountries[selected_country].prcinfl / 10f, GlobalScript.inst.new_events_text[1214]);
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = GlobalScript.inst.other_text[287];
				uslovie_bool[1] = !a.allcountries[selected_country].dota;
				uslovie_text[1] = GlobalScript.inst.other_text[305];
			}
			else
			{
				number_uslovie = 1;
				this_opis = string.Format("{0}{1}{3}:{2}; {5}: {4}", GlobalScript.inst.other_text[306], '\n', a.allcountries[1].isSEATO ? ((float)a.allcountries[selected_country].usainfl / 10f) : ((float)a.allcountries[selected_country].sovinfl), a.allcountries[1].isSEATO ? GlobalScript.inst.new_texts[167] : GlobalScript.inst.new_texts[168], (float)a.allcountries[selected_country].prcinfl / 10f, GlobalScript.inst.new_events_text[1214]);
				uslovie_bool[0] = a.allcountries[selected_country].proprc;
				uslovie_text[0] = GlobalScript.inst.other_text[307];
			}
		}
		else if (this_type == 135)
		{
			if (!a.modifies[53].active)
			{
				this_opis = GlobalScript.inst.other_text[311];
				number_uslovie = 4;
				uslovie_bool[0] = a.relres;
				uslovie_text[0] = GlobalScript.inst.other_text[312];
				uslovie_bool[1] = a.allcountries[1].Gosstroy == 1;
				uslovie_text[1] = GlobalScript.inst.other_text[313];
				uslovie_bool[2] = !a.allcountries[1].isASEAN && a.science[19];
				uslovie_text[2] = GlobalScript.inst.other_text[315];
				uslovie_bool[3] = !a.modifies[41].active;
				uslovie_text[3] = GlobalScript.inst.other_text[314];
			}
			else
			{
				this_opis = GlobalScript.inst.other_text[316];
				number_uslovie = 1;
				uslovie_bool[0] = a.modifies[53].active;
				uslovie_text[0] = GlobalScript.inst.other_text[317];
			}
		}
		else if (this_type == 136)
		{
			this_opis = GlobalScript.inst.other_text[318];
			number_uslovie = 3;
			uslovie_bool[0] = a.data[8] + a.data[36] >= 50 && a.data[9] >= 50;
			uslovie_text[0] = GlobalScript.inst.other_text[319];
			uslovie_bool[1] = a.data[21] < 1978 || (a.data[21] == 1978 && a.data[20] < 11);
			uslovie_text[1] = GlobalScript.inst.other_text[320];
			uslovie_bool[2] = !a.allcountries[86].based;
			uslovie_text[2] = GlobalScript.inst.other_text[321];
		}
		else if (this_type == 137)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[330], '\n');
			uslovie_bool[0] = a.influencePRC >= a.empires[0].power + a.empires[1].power;
			uslovie_text[0] = GlobalScript.inst.other_text[331];
			uslovie_bool[1] = !a.modifies[17].active && !a.modifies[16].active && a.empires[0].relations >= 900 && a.empires[1].relations >= 900;
			uslovie_text[1] = GlobalScript.inst.other_text[332];
			uslovie_bool[2] = (a.empires[1].now_leader == 6 && a.empires[0].now_leader == 3) || a.allcountries[21].isSocEU;
			uslovie_text[2] = GlobalScript.inst.other_text[333];
			uslovie_bool[3] = a.allcountries[17].dev <= 0;
			uslovie_text[3] = GlobalScript.inst.other_text[194];
		}
		else if (this_type == 138)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[335], '\n');
			int num6 = 0;
			if (a.allcountries[21].Gosstroy == 1)
			{
				num6++;
			}
			if (a.allcountries[85].Gosstroy == 1)
			{
				num6++;
			}
			if (a.allcountries[86].Gosstroy == 1)
			{
				num6++;
			}
			if (a.allcountries[87].Gosstroy == 1)
			{
				num6++;
			}
			if (a.allcountries[92].Gosstroy == 1)
			{
				num6++;
			}
			uslovie_bool[0] = num6 >= 3;
			uslovie_text[0] = GlobalScript.inst.other_text[336];
			uslovie_bool[1] = a.relres;
			uslovie_text[1] = GlobalScript.inst.other_text[337];
			uslovie_bool[2] = !a.allcountries[17].isNATO && !a.allcountries[17].isEU;
			uslovie_text[2] = GlobalScript.inst.other_text[338];
			uslovie_bool[3] = a.allcountries[17].dev <= 0;
			uslovie_text[3] = GlobalScript.inst.other_text[194];
		}
		else if (this_type == 139)
		{
			number_uslovie = 3;
			this_opis = string.Format(GlobalScript.inst.other_text[427], '\n');
			uslovie_bool[0] = a.influencePRC >= a.empires[0].power + a.empires[1].power || a.influencePRC >= 800;
			uslovie_text[0] = GlobalScript.inst.other_text[428];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 150;
			uslovie_text[1] = GlobalScript.inst.other_text[429];
			uslovie_bool[2] = a.allcountries[18].spec <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[430];
		}
		else if (this_type == 140)
		{
			number_uslovie = 3;
			this_opis = string.Format(GlobalScript.inst.other_text[431], '\n');
			uslovie_bool[0] = a.influencePRC >= a.empires[0].power + a.empires[1].power || a.influencePRC >= 800;
			uslovie_text[0] = GlobalScript.inst.other_text[428];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 150;
			uslovie_text[1] = GlobalScript.inst.other_text[429];
			uslovie_bool[2] = a.allcountries[18].spec <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[430];
		}
		else if (this_type == 141)
		{
			number_uslovie = 3;
			this_opis = string.Format(GlobalScript.inst.other_text[432], '\n');
			uslovie_bool[0] = a.influencePRC >= a.empires[0].power + a.empires[1].power || a.influencePRC >= 800;
			uslovie_text[0] = GlobalScript.inst.other_text[428];
			uslovie_bool[1] = a.data[8] + a.data[36] >= 150;
			uslovie_text[1] = GlobalScript.inst.other_text[429];
			uslovie_bool[2] = a.allcountries[18].spec <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[430];
		}
		else if (this_type == 142)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[448], '\n', GlobalScript.inst.gameState.allcountries[selected_country].name, (float)GlobalScript.inst.gameState.allcountries[selected_country].inflCh / 10f);
			uslovie_bool[0] = a.data[22] >= 50;
			uslovie_text[0] = GlobalScript.inst.other_text[449];
			uslovie_bool[1] = a.allcountries[selected_country].sovinfl <= 0;
			uslovie_text[1] = GlobalScript.inst.other_text[450];
			uslovie_bool[2] = a.allcountries[selected_country].inflCh < 1000;
			uslovie_text[2] = GlobalScript.inst.other_text[452];
			uslovie_bool[3] = a.event_done[418];
			uslovie_text[3] = GlobalScript.inst.other_text[451];
		}
		else if (this_type == 143)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[453], '\n', GlobalScript.inst.gameState.allcountries[selected_country].name, (float)GlobalScript.inst.gameState.allcountries[selected_country].inflCh / 10f);
			uslovie_bool[0] = a.data[9] >= 50;
			uslovie_text[0] = GlobalScript.inst.other_text[454];
			uslovie_bool[1] = a.allcountries[selected_country].usainfl <= 0;
			uslovie_text[1] = GlobalScript.inst.other_text[450];
			uslovie_bool[2] = a.allcountries[selected_country].inflCh < 1000;
			uslovie_text[2] = GlobalScript.inst.other_text[452];
			uslovie_bool[3] = a.event_done[418];
			uslovie_text[3] = GlobalScript.inst.other_text[451];
		}
		else if (this_type == 144)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[455], '\n', GlobalScript.inst.gameState.allcountries[selected_country].name, (float)GlobalScript.inst.gameState.allcountries[selected_country].inflCh / 10f);
			uslovie_bool[0] = a.data[8] + a.data[36] >= 30;
			uslovie_text[0] = GlobalScript.inst.other_text[456];
			uslovie_bool[1] = a.allcountries[selected_country].prcinfl <= 0;
			uslovie_text[1] = GlobalScript.inst.other_text[450];
			uslovie_bool[2] = a.allcountries[selected_country].inflCh < 1000;
			uslovie_text[2] = GlobalScript.inst.other_text[452];
			uslovie_bool[3] = a.event_done[418];
			uslovie_text[3] = GlobalScript.inst.other_text[451];
		}
		else if (this_type == 145)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[460], '\n', (a.data[143] + 5 <= 60) ? (a.data[143] + 5) : 60);
			int num7 = 0;
			for (int m = 101; m < 107; m++)
			{
				if (a.allcountries[m].proprc)
				{
					num7++;
				}
			}
			if (a.allcountries[36].proprc)
			{
				num7++;
			}
			uslovie_bool[0] = num7 >= 3;
			uslovie_text[0] = GlobalScript.inst.other_text[461];
			uslovie_bool[1] = a.data[9] >= 50;
			uslovie_text[1] = GlobalScript.inst.other_text[454];
			uslovie_bool[2] = a.allcountries[36].inflNATO <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[450];
			uslovie_bool[3] = a.data[143] < 60;
			uslovie_text[3] = GlobalScript.inst.other_text[462];
		}
		else if (this_type == 146)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[463], '\n', (a.data[143] - 5 >= 10) ? (a.data[143] - 5) : 10);
			int num8 = 0;
			for (int n = 101; n < 107; n++)
			{
				if (a.allcountries[n].proprc)
				{
					num8++;
				}
			}
			if (a.allcountries[36].proprc)
			{
				num8++;
			}
			uslovie_bool[0] = num8 >= 3;
			uslovie_text[0] = GlobalScript.inst.other_text[461];
			uslovie_bool[1] = a.data[9] >= 50;
			uslovie_text[1] = GlobalScript.inst.other_text[454];
			uslovie_bool[2] = a.allcountries[36].inflNATO <= 0;
			uslovie_text[2] = GlobalScript.inst.other_text[450];
			uslovie_bool[3] = a.data[143] > 10;
			uslovie_text[3] = GlobalScript.inst.other_text[464];
		}
		else if (this_type == 147)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[468], '\n');
			uslovie_bool[0] = a.data[8] + a.data[36] >= 100;
			uslovie_text[0] = GlobalScript.inst.other_text[469];
			uslovie_bool[1] = a.data[9] >= 50 && a.data[22] >= 100;
			uslovie_text[1] = GlobalScript.inst.other_text[470];
			uslovie_bool[2] = a.allcountries[selected_country].stab > 0;
			uslovie_text[2] = GlobalScript.inst.other_text[471];
			uslovie_bool[3] = a.allcountries[selected_country].spec <= 0;
			uslovie_text[3] = GlobalScript.inst.other_text[472];
		}
		else if (this_type == 148)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[479], '\n');
			uslovie_bool[0] = a.data[8] + a.data[36] >= 200;
			uslovie_text[0] = GlobalScript.inst.other_text[481];
			uslovie_bool[1] = a.data[9] >= 200;
			uslovie_text[1] = GlobalScript.inst.other_text[482];
			uslovie_bool[2] = !a.allcountries[0].isNATO && !a.allcountries[0].isEU;
			uslovie_text[2] = GlobalScript.inst.other_text[483];
			uslovie_bool[3] = !a.allcountries[selected_country].cw;
			uslovie_text[3] = GlobalScript.inst.other_text[484];
		}
		else if (this_type == 149)
		{
			number_uslovie = 4;
			this_opis = string.Format(GlobalScript.inst.other_text[480], '\n');
			uslovie_bool[0] = a.data[8] + a.data[36] >= 200;
			uslovie_text[0] = GlobalScript.inst.other_text[481];
			uslovie_bool[1] = a.data[9] >= 200;
			uslovie_text[1] = GlobalScript.inst.other_text[482];
			uslovie_bool[2] = !a.allcountries[0].isNATO && !a.allcountries[0].isEU;
			uslovie_text[2] = GlobalScript.inst.other_text[483];
			uslovie_bool[3] = !a.allcountries[selected_country].cw;
			uslovie_text[3] = GlobalScript.inst.other_text[484];
		}
	}

	private void OnMouseDown()
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		if (!is_active || (number_uslovie != 0 && (number_uslovie != 1 || !uslovie_bool[0]) && (number_uslovie != 2 || !uslovie_bool[0] || !uslovie_bool[1]) && (number_uslovie != 3 || !uslovie_bool[0] || !uslovie_bool[1] || !uslovie_bool[2]) && (number_uslovie != 4 || !uslovie_bool[0] || !uslovie_bool[1] || !uslovie_bool[2] || !uslovie_bool[3])))
		{
			return;
		}
		if (this_type == 2)
		{
			a.empires[0].relations -= 500;
			a.empires[0].power -= 70;
			if (a.resultOfEvents[469] == 1 || !a.event_done[469])
			{
				a.data[22] -= 100;
				a.data[8] -= 50;
			}
			else
			{
				a.data[22] -= 50;
				a.data[8] -= 30;
			}
			a.data[65] = 2;
			a.data[6] += 500;
			a.data[34] += 45;
			a.allcountries[92].Torg = false;
			a.allcountries[87].Torg = false;
			a.allcountries[0].prcpower = 1;
			if (a.iron_and_blood && a.data[63] == 1)
			{
				gameObject.GetComponent<achievements>().Set(11);
			}
		}
		else if (this_type == 1)
		{
			if (selected_country == 92 || selected_country == 21 || selected_country == 17)
			{
				if (a.empires[0].now_leader == 3)
				{
					a.empires[0].power -= 75;
				}
				else
				{
					a.empires[0].power -= 50;
				}
				a.empires[0].relations -= 200;
				a.war_active[0] = true;
				if (a.completedDecisions[8])
				{
					a.influencePRC += 10;
				}
				if (a.completedDecisions[10])
				{
					a.influencePRC += 25;
				}
			}
			else
			{
				a.empires[1].power -= 50;
				a.empires[1].relations -= 200;
				a.war_active[1] = true;
				if (a.completedDecisions[9])
				{
					a.influencePRC += 25;
				}
			}
			a.data[9] -= 50;
			a.data[8] -= 30;
			a.data[22] -= 50;
		}
		else if (this_type == 3)
		{
			a.data[9] -= 20;
			a.data[8] -= 20;
			a.allcountries[0].dev = 1;
			GlobalScript.inst.speed = 0;
			a.number_event = 27;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 4)
		{
			a.empires[1].relations += 50;
			a.empires[0].relations -= 50;
			a.relres = true;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 5)
		{
			a.data[1] -= 100;
			a.influencePRC -= 30;
			a.empires[1].relations += 200;
			a.empires[0].relations -= 200;
			a.empires[1].power += 30;
			a.data[4] += 100;
			a.modifies[47].active = false;
			a.modifies[48].active = false;
			if (a.allcountries[1].econ)
			{
				a.data[137] = 1;
			}
			a.allcountries[selected_country].Torg = false;
			a.allcountries[1].isSEV = true;
			if (a.data[60] == 0 && !a.event_done[380])
			{
				a.allcountries[20].proprc = false;
				a.allcountries[20].econ = false;
				a.allcountries[20].Torg = false;
				a.allcountries[20].okb = false;
			}
			a.ingamewars[1].infl2 = 1500;
			if (!a.allcountries[16].Torg && a.modifies[53].active)
			{
				a.allcountries[16].Torg = true;
			}
			Country[] allcountries = a.allcountries;
			foreach (Country country in allcountries)
			{
				if (country.econ && (country.prosov || country.sovalliance || country.proprc || country.Gosstroy == 1 || (country.Gosstroy == 2 && !country.usalliance && !country.Vyshi)))
				{
					country.econ = false;
					country.isSEV = true;
				}
				else
				{
					country.econ = false;
				}
			}
			Politic[] politics = a.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 2)
				{
					politic.loyality -= 250;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality -= 250;
				}
				else if (politic.traits[0] == 0)
				{
					politic.loyality -= 250;
				}
			}
		}
		else if (this_type == 74)
		{
			a.allcountries[selected_country].Torg = true;
			a.empires[0].relations -= 50;
			a.empires[1].relations += 50;
		}
		else if (this_type == 6)
		{
			a.empires[0].relations -= 200;
			a.empires[1].relations += 150;
			a.empires[1].power += 30;
			a.data[6] += 200;
			a.data[143] += 5;
			a.influencePRC -= 50;
			if (a.modifies[47].active)
			{
				a.modifies[47].active = false;
				a.data[135] = 1;
			}
			if (a.modifies[48].active)
			{
				a.modifies[48].active = false;
				a.data[136] = 1;
			}
			if (a.allcountries[1].okb)
			{
				a.data[138] = 1;
			}
			a.allcountries[1].isOVD = true;
			Country[] allcountries = a.allcountries;
			foreach (Country country2 in allcountries)
			{
				if (country2.okb && (country2.prosov || country2.sovalliance || country2.proprc || country2.Gosstroy == 1 || (country2.Gosstroy == 2 && !country2.usalliance && !country2.Vyshi)))
				{
					country2.okb = false;
					country2.isOVD = true;
				}
				else
				{
					country2.okb = false;
				}
			}
			for (int j = 0; j < a.allcountries.Length; j++)
			{
				if (a.allcountries[j].isOVD && (j == 8 || j == 11 || j == 14 || j == 12 || j == 31 || j == 43 || j == 37 || j == 42 || j == 22 || j == 23 || j == 35 || j == 96 || j == 97 || j == 98 || j == 95 || j == 49 || j == 50))
				{
					if (a.allcountries[j].proprc)
					{
						a.allcountries[j].prcinfl = 500;
					}
					else if (a.allcountries[j].prosov)
					{
						a.allcountries[j].sovinfl = 500;
					}
				}
			}
			if (a.data[60] == 0 && !a.event_done[380])
			{
				a.allcountries[20].proprc = false;
				a.allcountries[20].econ = false;
				a.allcountries[20].Torg = false;
				a.allcountries[20].okb = false;
			}
		}
		else if (this_type == 7)
		{
			a.data[9] -= a.SOV_PRC_PartiesConnection / 2;
			a.data[8] -= a.SOV_PRC_PartiesConnection / 4;
			a.SOV_PRC_PartiesConnection += 30;
			a.empires[1].relations += 50;
			a.allcountries[selected_country].dev = 1;
		}
		else if (this_type == 8)
		{
			bool num = a.allcountries[selected_country].dev == 0;
			_ = a.data[43];
			if (num)
			{
				a.data[43] += 120;
			}
			else if (a.allcountries[selected_country].dev == 1)
			{
				a.data[42] += 120;
			}
			else if (a.allcountries[selected_country].dev == 2)
			{
				a.data[44] += 120;
			}
			else
			{
				a.data[45] += 120;
			}
			a.data[9] -= 60;
			a.data[8] -= 50;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 9)
		{
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 10)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.data[3] += 20;
				a.influencePRC += 20;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
				a.data[1] += 30;
			}
		}
		else if (this_type == 11)
		{
			a.data[9] -= 100;
			a.data[8] -= 50;
			a.allcountries[selected_country].cw = true;
		}
		else if (this_type == 12)
		{
			a.empires[1].relations -= 50;
			a.empires[1].power -= 200;
			a.influencePRC += 20;
			a.data[9] -= 100;
			a.data[8] -= 80;
			a.allcountries[9].prosov = false;
			a.allcountries[9].proprc = true;
		}
		else if (this_type == 13)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 10;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 14)
		{
			a.allcountries[selected_country].inflCh = 1;
			GlobalScript.inst.speed = 0;
			a.number_event = 29;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 15)
		{
			a.allcountries[selected_country].dev = 1;
			a.data[9] -= 100;
			a.data[8] -= 50;
			a.data[6] += 100;
			if (PlayerPrefs.GetInt("language") == 0)
			{
				a.ingamewars[0].name_war = " 第 二 次 朝 鲜 战 争";
				a.ingamewars[0].is_going = true;
				a.ingamewars[0].side1 = " 朝 鲜";
				a.ingamewars[0].side2 = " 韩 国";
			}
			else
			{
				a.ingamewars[0].name_war = "Вторая Корейская война";
				a.ingamewars[0].is_going = true;
				a.ingamewars[0].side1 = "КНДР";
				a.ingamewars[0].side2 = "РК";
			}
			if (!a.allcountries[10].proprc)
			{
				a.ingamewars[0].ussr_place = 0;
			}
			else
			{
				a.ingamewars[0].ussr_place = -1;
			}
			a.ingamewars[0].usa_place = 1;
			a.ingamewars[0].infl1 = 600;
			a.ingamewars[0].infl2 = 400;
		}
		else if (this_type == 16)
		{
			a.guns = true;
			a.data[22] -= 50;
			a.data[8] -= 20;
			a.data[6] += 50;
		}
		else if (this_type == 17)
		{
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 18)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 19)
		{
			if (a.allcountries[1].isOVD)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isOVD = true;
				if (a.allcountries[selected_country].proprc)
				{
					a.allcountries[selected_country].prcinfl = 500;
				}
				else if (a.allcountries[selected_country].prosov)
				{
					a.allcountries[selected_country].sovinfl = 500;
				}
			}
			else
			{
				a.influencePRC += 20;
				a.allcountries[selected_country].okb = true;
				if (a.allcountries[selected_country].soc_stab <= 0)
				{
					a.allcountries[selected_country].soc_stab = 1000;
				}
			}
		}
		else if (this_type == 20)
		{
			a.data[39] += 100;
			a.data[22] -= 50;
			a.allcountries[selected_country].stab++;
		}
		else if (this_type == 21)
		{
			bool num2 = a.allcountries[selected_country].dev == 0;
			_ = a.data[46];
			if (num2)
			{
				a.data[46] += 100;
			}
			else if (a.allcountries[selected_country].dev == 1)
			{
				a.data[57] += 100;
			}
			else if (a.allcountries[selected_country].dev == 2)
			{
				a.empires[1].now_leader += 100;
			}
			else
			{
				a.data[60] += 100;
			}
			a.data[9] -= 40;
			a.data[8] -= 30;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 68)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 22)
		{
			a.allcountries[selected_country].stab = 1;
			a.data[8] -= 50;
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 23)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[selected_country].cw = true;
		}
		else if (this_type == 67)
		{
			a.allcountries[selected_country].oar = true;
			a.influencePRC += 10;
		}
		else if (this_type == 24)
		{
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 69)
		{
			a.data[9] -= 30;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 25)
		{
			a.allcountries[selected_country].oar = true;
			a.influencePRC += 10;
		}
		else if (this_type == 26)
		{
			a.allcountries[selected_country].stab = 1;
			a.influencePRC += 10;
			if (a.data[60] == 0)
			{
				a.allcountries[20].proprc = false;
				a.allcountries[20].econ = false;
				a.allcountries[20].Torg = false;
				a.allcountries[20].okb = false;
			}
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 76)
		{
			a.allcountries[selected_country].cw = true;
		}
		else if (this_type == 77)
		{
			a.allcountries[selected_country].Torg = true;
			a.data[9] -= 80;
		}
		else if (this_type == 78)
		{
			a.allcountries[selected_country].proprc = true;
			a.data[9] -= 60;
			a.data[22] -= 100;
		}
		else if (this_type == 79)
		{
			a.allcountries[selected_country].Gosstroy = 0;
			a.allcountries[selected_country].cw = false;
			a.allcountries[selected_country].Torg = false;
			a.allcountries[selected_country].proprc = false;
			a.allcountries[selected_country].prosov = false;
			a.allcountries[selected_country].Vyshi = false;
			a.allcountries[selected_country].dev = 0;
			a.data[57] += 200;
			a.data[9] -= 80;
			a.influencePRC += 10;
			if (selected_country == 70)
			{
				a.event_done[10] = false;
				a.data[66] = 0;
				a.allcountries[1].parts[9] = false;
			}
			else if (selected_country == 69)
			{
				a.event_done[9] = false;
				a.data[67] = 0;
				a.allcountries[1].parts[7] = false;
				a.allcountries[1].parts[8] = false;
			}
		}
		else if (this_type == 80)
		{
			a.allcountries[selected_country].soc_stab += 250;
			if (!a.allcountries[selected_country].usalliance && !a.allcountries[selected_country].sovalliance)
			{
				a.allcountries[selected_country].usalliance = false;
				a.allcountries[selected_country].sovalliance = false;
				a.allcountries[selected_country].soc_stab -= 500;
			}
			a.allcountries[selected_country].prosov = false;
			a.allcountries[selected_country].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[selected_country].sovalliance = false;
			GlobalScript.inst.gameState.allcountries[selected_country].usalliance = false;
			a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
			a.allcountries[selected_country].proprc = true;
			if (a.allcountries[selected_country].puppetOf != 1)
			{
				a.allcountries[selected_country].puppetOf = -1;
			}
			a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[selected_country].SubGosstroy = a.ChineseSubGosstroy();
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.data[22] -= 50;
			if (selected_country == 14 || selected_country == 8)
			{
				a.data[117] = 0;
			}
		}
		else if (this_type == 75)
		{
			a.data[11] -= 100;
			a.data[1] -= 50;
			a.data[8] += 4;
			a.empires[0].power += 2;
			a.empires[1].relations -= 10;
		}
		else if (this_type == 81)
		{
			a.data[11] -= 100;
			a.data[1] -= 50;
			a.data[8] += 5;
			a.empires[1].power += 2;
			a.empires[0].relations -= 25;
		}
		else if (this_type == 27)
		{
			if (!a.allcountries[85].isSocEU)
			{
				a.data[9] -= 40;
				a.allcountries[selected_country].dev = 1;
			}
			else
			{
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.allcountries[selected_country].dev = 2;
				a.influencePRC += 10;
				a.allcountries[selected_country].Gosstroy = 2;
				a.allcountries[selected_country].SubGosstroy = 8;
				a.allcountries[selected_country].isSocEU = true;
			}
		}
		else if (this_type == 72)
		{
			a.data[1] -= 300;
			a.data[8] -= 20;
			a.influencePRC -= 20;
			a.allcountries[selected_country].cw = true;
		}
		else if (this_type == 73)
		{
			a.data[1] -= 300;
			a.data[8] -= 50;
			if (a.data[6] >= 600)
			{
				a.empires[0].relations -= 300;
			}
			else if (a.data[6] <= 600)
			{
				a.empires[1].relations -= 300;
			}
			if (a.data[6] >= 500)
			{
				a.data[6] += 200;
			}
			else
			{
				a.data[6] -= 200;
			}
			a.allcountries[selected_country].cw = false;
		}
		else if (this_type == 28)
		{
			a.data[32] += 100;
			a.empires[1].relations -= 50;
			a.data[22] -= 30;
			a.data[9] -= 30;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 29)
		{
			a.allcountries[selected_country].Torg = true;
			a.data[62] = 1;
		}
		else if (this_type == 30)
		{
			a.war = 2;
			a.empires[1].relations -= 100;
			a.empires[0].relations -= 50;
			a.allcountries[selected_country].dev = 1;
		}
		else if (this_type == 89)
		{
			a.CBIndia = false;
			a.data[62] = 3;
			a.allcountries[1].ILoveSuckCocks();
			a.data[8] -= 250;
			map1.UpdateMap();
		}
		else if (this_type == 31)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.data[3] += 20;
				a.data[1] += 30;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 32)
		{
			a.SovAlb = true;
			a.empires[1].relations += 50;
			a.empires[1].power += 5;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 33)
		{
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 34)
		{
			a.data[8] += 50;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 35)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 445;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 36)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.data[3] += 20;
				a.data[1] += 30;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 37)
		{
			a.allcountries[selected_country].Gosstroy = 1;
			a.allcountries[selected_country].SubGosstroy = 1;
			a.allcountries[selected_country].stab = 1;
			a.data[9] -= 30;
			a.data[8] -= 30;
		}
		else if (this_type == 50)
		{
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 38)
		{
			a.data[8] -= 50;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 39)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.data[3] += 20;
				a.data[1] += 30;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 71)
		{
			a.data[40] += 100;
			a.data[22] -= 50;
			a.allcountries[selected_country].prcpower++;
		}
		else if (this_type == 40)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.empires[0].relations -= 50;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.data[3] += 20;
				a.data[1] += 30;
				a.empires[0].relations -= 50;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 41)
		{
			if (a.allcountries[1].isOVD)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isOVD = true;
			}
			else
			{
				a.influencePRC += 20;
				a.allcountries[selected_country].okb = true;
				if (a.allcountries[selected_country].soc_stab <= 0)
				{
					a.allcountries[selected_country].soc_stab = 1000;
				}
			}
		}
		else if (this_type == 42)
		{
			a.data[8] -= 80;
			a.data[9] -= 50;
			a.influencePRC += 10;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 43)
		{
			a.data[9] -= 40;
			a.data[8] -= 20;
			a.data[41] = 100;
			a.allcountries[selected_country].stab = 1;
		}
		else if (this_type == 44)
		{
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.data[3] += 20;
				a.data[1] += 30;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 45)
		{
			a.allcountries[selected_country].oar = true;
			a.influencePRC += 10;
		}
		else if (this_type == 46)
		{
			a.allcountries[selected_country].dev = 1;
			GlobalScript.inst.speed = 0;
			a.number_event = 30;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 47)
		{
			a.empires[0].relations += 200;
			a.influencePRC -= 10;
			a.empires[0].power += 10;
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 48)
		{
			a.data[22] -= 500;
			a.empires[0].relations = 0;
			a.empires[0].power -= 50;
			a.data[4] -= 500;
			a.influencePRC += 50;
			a.data[3] += 100;
			a.data[1] += 200;
			a.data[6] += 200;
			a.data[63] = 1;
			if (a.iron_and_blood && a.data[65] == 2)
			{
				Debug.Log(gameObject);
				gameObject.GetComponent<achievements>().Set(11);
			}
			a.allcountries[selected_country].dev = 1;
		}
		else if (this_type == 49)
		{
			if (selected_country == 39)
			{
				if (!a.allcountries[selected_country].proprc)
				{
					a.data[1] += 200;
					a.data[8] -= 100;
				}
				else
				{
					a.data[1] += 400;
					a.data[8] -= 50;
				}
				a.allcountries[39].dev = 1;
				if (!a.allcountries[selected_country].proprc)
				{
					a.data[26] += 10;
				}
			}
			if (selected_country == 138)
			{
				a.data[26] += 10;
				if (!a.allcountries[selected_country].proprc)
				{
					a.data[1] += 200;
					a.data[3] += 100;
					a.data[5] += 50;
					a.data[8] -= 100;
				}
				else
				{
					a.data[1] += 200;
					a.data[3] += 100;
					a.data[5] += 50;
					a.data[8] -= 50;
				}
				a.allcountries[138].dev = 1;
			}
			if (selected_country == 154)
			{
				a.data[1] += 50;
				if (!a.allcountries[selected_country].proprc)
				{
					a.data[8] -= 50;
				}
				else
				{
					a.data[8] -= 20;
				}
				int num3 = 900;
				for (int k = 0; k < a.allcountries.Length; k++)
				{
					if (a.allcountries[k].Torg)
					{
						num3++;
					}
					if (!a.allcountries[k].Torg)
					{
						num3--;
					}
					if (a.allcountries[k].proprc)
					{
						num3 += 5;
					}
					if (!a.allcountries[k].proprc)
					{
						num3 -= 5;
					}
					if (a.IsSocialism(yes: true, k) && !a.modifies[6].active)
					{
						num3 -= 10;
					}
					if (a.IsSocialism(yes: true, k) && a.modifies[6].active)
					{
						num3 += 10;
					}
				}
				if (!a.relres)
				{
					num3 -= 100;
				}
				if (!a.allcountries[51].Torg)
				{
					num3 -= 100;
				}
				if (a.empires[0].relations < 500)
				{
					num3 -= 150;
				}
				if (a.empires[1].relations < 500)
				{
					num3 -= 150;
				}
				num3 -= a.allcountries[selected_country].prcinfl;
				if (num3 > 900)
				{
					num3 = 900;
				}
				int num4 = UnityEngine.Random.Range(0, 1000);
				if (num3 <= num4)
				{
					GlobalScript.inst.gameState.data[35] = 10;
					SceneManager.LoadScene("Ending");
				}
				a.allcountries[selected_country].prcinfl += 100;
			}
			if (selected_country == 152)
			{
				a.data[8] -= 30;
				a.data[3] += 50;
				a.allcountries[152].cw = true;
			}
		}
		else if (this_type == 51)
		{
			if (GlobalScript.inst.gameState.event_done[532] && GlobalScript.inst.gameState.resultOfEvents[532] == 0)
			{
				a.empires[0].relations -= 20;
				a.data[8] -= 80;
				a.data[9] -= 80;
				a.data[22] -= 80;
				a.allcountries[selected_country].prcpower += 15;
			}
			else
			{
				a.empires[0].relations -= 20;
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[selected_country].prcpower += 10;
			}
		}
		else if (this_type == 52)
		{
			a.data[1] += 50;
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 53)
		{
			a.influencePRC += 30;
			a.data[1] -= 50;
			a.allcountries[selected_country].stab = 1000;
			a.allcountries[selected_country].soc_stab = 1000;
			if (a.allcountries[1].isSEV)
			{
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 54)
		{
			a.allcountries[selected_country].stab = 1000;
			a.allcountries[selected_country].soc_stab = 1000;
			if (a.allcountries[1].isSEV)
			{
				a.empires[1].power += 20;
				a.influencePRC += 10;
				a.allcountries[selected_country].isSEV = true;
			}
			else
			{
				a.influencePRC += 20;
				a.data[3] += 20;
				a.data[1] += 30;
				a.allcountries[selected_country].econ = true;
				a.allcountries[selected_country].soc_stab = 1000;
			}
		}
		else if (this_type == 55)
		{
			a.data[9] -= 40;
			a.empires[0].relations -= 100;
			a.allcountries[selected_country].stab = 1;
			GlobalScript.inst.speed = 0;
			a.number_event = 31;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 56)
		{
			a.data[6] += 10;
			a.data[9] -= 40;
			a.data[22] -= 30;
			if (selected_country == 47)
			{
				a.data[37] += 100;
				a.allcountries[selected_country].stab = 1;
			}
			else if (selected_country == 14)
			{
				a.allcountries[14].prcpower += 15;
				a.allcountries[selected_country].stab = 1;
			}
		}
		else if (this_type == 57)
		{
			if (!a.allcountries[selected_country].cw)
			{
				a.data[9] -= 100;
				a.data[8] -= 100;
				a.allcountries[selected_country].cw = true;
			}
			else
			{
				a.data[9] -= 50;
				a.data[8] -= 50;
				a.allcountries[153].cw = true;
			}
		}
		else if (this_type == 58)
		{
			if (selected_country == 52)
			{
				a.data[8] -= 80;
				a.allcountries[selected_country].stab = 1;
				a.allcountries[selected_country].Torg = false;
				a.empires[0].relations -= 150;
				a.empires[0].power += 50;
				a.allcountries[selected_country].Vyshi = true;
			}
			else
			{
				a.data[8] -= 40;
				a.empires[0].relations -= 50;
				a.allcountries[selected_country].stab = 1;
				GlobalScript.inst.speed = 0;
				a.number_event = 28;
				SceneManager.LoadScene("Event");
			}
		}
		else if (this_type == 60)
		{
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 61)
		{
			a.influencePRC -= 50;
			a.empires[1].power -= 20;
			a.empires[0].power += 50;
			a.allcountries[selected_country].dev = 1;
		}
		else if (this_type == 62)
		{
			if (a.allcountries[selected_country].proprc)
			{
				a.data[9] -= 100;
				a.data[8] -= 40;
				a.data[22] -= 80;
				a.allcountries[selected_country].stab += 200;
				a.allcountries[selected_country].dev += 80;
				a.allcountries[selected_country].usapower -= 200;
				a.allcountries[selected_country].sovpower -= 200;
				if (a.allcountries[selected_country].stab > 1000)
				{
					a.allcountries[selected_country].stab = 1000;
					a.allcountries[selected_country].dev = 1000;
				}
				if (a.allcountries[selected_country].dev > 1000)
				{
					a.allcountries[selected_country].dev = 1000;
				}
				if (a.allcountries[selected_country].usapower < 0)
				{
					a.allcountries[selected_country].usapower = 0;
				}
				if (a.allcountries[selected_country].sovpower < 0)
				{
					a.allcountries[selected_country].sovpower = 0;
				}
			}
			else
			{
				a.allcountries[selected_country].prcpower += 200;
				if (a.allcountries[selected_country].prcpower > 1000)
				{
					a.allcountries[selected_country].prcpower = 1000;
				}
				a.data[9] -= 80;
				a.data[8] -= 40;
				a.data[22] -= 100;
			}
		}
		else if (this_type == 63)
		{
			a.allcountries[selected_country].sovalliance = true;
			a.data[9] -= 20;
		}
		else if (this_type == 64)
		{
			a.allcountries[selected_country].usalliance = true;
			a.data[9] -= 20;
		}
		else if (this_type == 65)
		{
			if (a.allcountries[selected_country].stab >= 1000)
			{
				a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
				a.allcountries[selected_country].proprc = true;
				a.allcountries[selected_country].SubGosstroy = a.ChineseSubGosstroy();
				a.allcountries[selected_country].prosov = false;
				a.allcountries[selected_country].Vyshi = false;
				a.allcountries[selected_country].puppetOf = -1;
				a.influencePRC += 5;
				a.allcountries[selected_country].stab = 100;
				a.allcountries[selected_country].dev -= 200;
				a.allcountries[selected_country].sovalliance = false;
				a.allcountries[selected_country].usalliance = false;
				a.allcountries[selected_country].Vyshi = false;
				a.allcountries[selected_country].prosov = false;
				a.allcountries[selected_country].usapower = (a.allcountries[selected_country].usapower + 1) / 2;
				a.allcountries[selected_country].sovpower = (a.allcountries[selected_country].sovpower + 1) / 2;
			}
			if (a.allcountries[selected_country].usalliance)
			{
				a.allcountries[selected_country].stab -= a.allcountries[selected_country].prcpower + a.allcountries[selected_country].usapower + 100;
			}
			else if (a.allcountries[selected_country].sovalliance)
			{
				a.allcountries[selected_country].stab -= a.allcountries[selected_country].prcpower + a.allcountries[selected_country].sovpower + 100;
			}
			else
			{
				a.allcountries[selected_country].stab -= a.allcountries[selected_country].prcpower + 100;
			}
			if (a.allcountries[selected_country].stab < -200)
			{
				if (a.allcountries[selected_country].usalliance && a.allcountries[selected_country].usapower > a.allcountries[selected_country].prcpower)
				{
					a.allcountries[selected_country].Gosstroy = 3;
					a.allcountries[selected_country].SubGosstroy = a.AfricanSubGosstroy(a.allcountries[selected_country].Gosstroy);
					a.allcountries[selected_country].Vyshi = true;
					a.allcountries[selected_country].puppetOf = -1;
					a.allcountries[selected_country].prosov = false;
					a.allcountries[selected_country].stab = 100;
					a.allcountries[selected_country].dev -= 200;
					a.allcountries[selected_country].usalliance = false;
					a.allcountries[selected_country].sovpower = (a.allcountries[selected_country].sovpower + 1) / 2;
					a.empires[0].power += 10;
				}
				else if (a.allcountries[selected_country].sovalliance && a.allcountries[selected_country].sovpower > a.allcountries[selected_country].prcpower)
				{
					a.allcountries[selected_country].Gosstroy = 1;
					a.allcountries[selected_country].SubGosstroy = a.AfricanSubGosstroy(a.allcountries[selected_country].Gosstroy);
					a.allcountries[selected_country].prosov = true;
					a.allcountries[selected_country].puppetOf = -1;
					a.allcountries[selected_country].Vyshi = false;
					a.allcountries[selected_country].stab = 100;
					a.allcountries[selected_country].dev -= 200;
					a.allcountries[selected_country].sovalliance = false;
					a.allcountries[selected_country].usapower = (a.allcountries[selected_country].usapower + 1) / 2;
					a.empires[1].power += 10;
				}
				else if (a.allcountries[selected_country].usalliance)
				{
					a.allcountries[selected_country].Gosstroy = 3;
					a.allcountries[selected_country].proprc = true;
					a.allcountries[selected_country].puppetOf = -1;
					a.allcountries[selected_country].SubGosstroy = a.AfricanSubGosstroy(a.allcountries[selected_country].Gosstroy);
					a.allcountries[selected_country].prosov = false;
					a.allcountries[selected_country].Vyshi = false;
					a.allcountries[selected_country].stab = 100;
					a.allcountries[selected_country].dev -= 200;
					a.allcountries[selected_country].usalliance = false;
					a.allcountries[selected_country].usapower = (a.allcountries[selected_country].usapower + 1) / 2;
					a.allcountries[selected_country].sovpower = (a.allcountries[selected_country].sovpower + 1) / 2;
					a.empires[0].power += 5;
					a.influencePRC += 5;
				}
				else if (a.allcountries[selected_country].sovalliance)
				{
					a.allcountries[selected_country].Gosstroy = 1;
					a.allcountries[selected_country].proprc = true;
					a.allcountries[selected_country].puppetOf = -1;
					a.allcountries[selected_country].SubGosstroy = a.AfricanSubGosstroy(a.allcountries[selected_country].Gosstroy);
					a.allcountries[selected_country].prosov = false;
					a.allcountries[selected_country].Vyshi = false;
					a.allcountries[selected_country].stab = 100;
					a.allcountries[selected_country].dev -= 200;
					a.allcountries[selected_country].sovalliance = false;
					a.allcountries[selected_country].usapower = (a.allcountries[selected_country].usapower + 1) / 2;
					a.allcountries[selected_country].sovpower = (a.allcountries[selected_country].sovpower + 1) / 2;
					a.empires[1].power += 5;
					a.influencePRC += 5;
				}
				else
				{
					a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
					a.allcountries[selected_country].proprc = true;
					a.allcountries[selected_country].puppetOf = -1;
					a.allcountries[selected_country].SubGosstroy = a.ChineseSubGosstroy();
					a.allcountries[selected_country].prosov = false;
					a.allcountries[selected_country].Vyshi = false;
					a.influencePRC += 5;
					a.allcountries[selected_country].stab = 100;
					a.allcountries[selected_country].dev -= 200;
					a.allcountries[selected_country].sovalliance = false;
					a.allcountries[selected_country].usalliance = false;
					a.allcountries[selected_country].Vyshi = false;
					a.allcountries[selected_country].prosov = false;
					a.allcountries[selected_country].puppetOf = -1;
					a.allcountries[selected_country].usapower = (a.allcountries[selected_country].usapower + 1) / 2;
					a.allcountries[selected_country].sovpower = (a.allcountries[selected_country].sovpower + 1) / 2;
				}
			}
			else if (a.allcountries[selected_country].stab >= -200 && a.allcountries[selected_country].stab <= 100)
			{
				a.allcountries[selected_country].stab = 0;
				a.allcountries[selected_country].dev -= 400;
				a.allcountries[selected_country].prcpower = 100;
				a.allcountries[selected_country].usapower = 100;
				a.allcountries[selected_country].sovpower = 100;
			}
			else
			{
				a.allcountries[selected_country].stab -= 200;
				a.allcountries[selected_country].dev -= 100;
				a.allcountries[selected_country].prcpower = 0;
			}
		}
		else if (this_type == 66)
		{
			if (!a.allcountries[selected_country].Torg)
			{
				a.allcountries[selected_country].Torg = true;
			}
			else
			{
				a.allcountries[selected_country].Torg = false;
			}
		}
		else if (this_type == 82)
		{
			if (a.allcountries[selected_country].Vyshi)
			{
				a.empires[0].power -= 10;
				a.empires[0].relations -= 150;
			}
			else if (a.allcountries[selected_country].prosov)
			{
				a.empires[1].power -= 10;
				a.empires[1].relations -= 150;
			}
			a.allcountries[selected_country].Vyshi = false;
			a.allcountries[selected_country].prosov = false;
			a.allcountries[selected_country].proprc = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.influencePRC += 5;
			a.empires[0].power -= 10;
			a.empires[0].relations -= 250;
			a.rev_done = true;
			a.allcountries[selected_country].SubGosstroy = a.GetSubGosstory();
			a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[selected_country].next_elections = new DateTime(2222, 2, 22);
		}
		else if (this_type == 83)
		{
			if (a.allcountries[selected_country].Vyshi)
			{
				a.empires[0].power -= 10;
				a.empires[0].relations -= 150;
			}
			else if (a.allcountries[selected_country].prosov)
			{
				a.empires[1].power -= 10;
				a.empires[1].relations -= 150;
			}
			a.allcountries[selected_country].Vyshi = false;
			a.allcountries[selected_country].prosov = false;
			a.allcountries[selected_country].proprc = true;
			a.allcountries[selected_country].Torg = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.influencePRC += 5;
			a.empires[0].power -= 10;
			a.empires[0].relations -= 250;
			a.allcountries[selected_country].SubGosstroy = a.GetSubGosstory();
			a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[selected_country].next_elections = new DateTime(2222, 2, 22);
		}
		else if (this_type == 84)
		{
			if (a.allcountries[selected_country].Vyshi)
			{
				a.empires[0].relations -= 10;
			}
			else if (a.allcountries[selected_country].prosov)
			{
				a.empires[1].relations -= 10;
			}
			a.allcountries[selected_country].level_of_unstab += 10;
			a.data[8] -= 20;
			a.data[9] -= 20;
			a.data[22] -= 20;
		}
		else if (this_type == 85)
		{
			if (a.allcountries[selected_country].Vyshi)
			{
				a.empires[0].relations -= 10;
			}
			else if (a.allcountries[selected_country].prosov)
			{
				a.empires[1].relations -= 10;
			}
			a.allcountries[selected_country].level_of_dev -= 10;
			a.data[8] -= 20;
			a.data[9] -= 20;
			a.data[22] -= 20;
		}
		else if (this_type == 86)
		{
			a.empires[0].relations -= 15;
			a.allcountries[selected_country].level_of_unstab -= 10;
			a.allcountries[selected_country].level_of_dev += 10;
			a.data[8] -= 35;
			a.data[9] -= 35;
			a.data[22] -= 35;
		}
		else if (this_type == 87)
		{
			a.empires[0].relations -= 15;
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 88)
		{
			if (a.allcountries[1].isSEV || a.allcountries[1].econ)
			{
				a.empires[0].relations -= 250;
				a.allcountries[selected_country].isSEV = a.allcountries[1].isSEV;
				a.allcountries[selected_country].econ = a.allcountries[1].econ;
				a.influencePRC += 5;
			}
		}
		else if (this_type == 91)
		{
			a.data[6] += 20;
			a.data[8] -= 50;
			a.data[9] -= 30;
			a.resultOfEvents[366] = 0;
		}
		else if (this_type == 92)
		{
			a.data[6] += 2;
			a.data[8] -= 50;
			a.data[9] -= 30;
			a.resultOfEvents[366] = 1;
		}
		else if (this_type == 93)
		{
			a.allcountries[93].Torg = true;
		}
		else if (this_type == 94)
		{
			a.data[124] = 10;
			GlobalScript.inst.speed = 0;
			a.number_event = 372;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 95)
		{
			a.data[127] = 10;
			GlobalScript.inst.speed = 0;
			a.number_event = 374;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 96)
		{
			a.allcountries[95].Torg = true;
		}
		else if (this_type == 97)
		{
			a.allcountries[selected_country].Torg = true;
			a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
			a.data[8] -= 200;
			a.data[9] -= 200;
			a.influencePRC += 10;
			a.data[6] += 10;
			a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[selected_country].SubGosstroy = a.ChineseSubGosstroy();
		}
		else if (this_type == 98)
		{
			if (a.allcountries[1].econ)
			{
				a.allcountries[selected_country].econ = true;
			}
			else
			{
				a.allcountries[selected_country].isSEV = true;
			}
			a.influencePRC += 5;
		}
		else if (this_type == 99)
		{
			if (a.allcountries[1].okb)
			{
				a.allcountries[selected_country].okb = true;
			}
			else if (a.allcountries[1].isNATO)
			{
				a.allcountries[selected_country].isNATO = true;
			}
			else
			{
				a.allcountries[selected_country].isOVD = true;
			}
			a.influencePRC += 5;
			a.allcountries[selected_country].soc_stab = 900;
		}
		else if (this_type == 100)
		{
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.allcountries[selected_country].dev = 1;
		}
		else if (this_type == 101)
		{
			if (a.allcountries[1].econ)
			{
				a.allcountries[selected_country].econ = true;
			}
			else
			{
				a.allcountries[selected_country].isSEV = true;
			}
		}
		else if (this_type == 102)
		{
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 103)
		{
			a.empires[0].relations -= 20;
			a.empires[1].relations -= 20;
			a.allcountries[selected_country].inflCh += 150;
			a.allcountries[selected_country].inflNATO -= 150;
			if (a.allcountries[selected_country].inflNATO < 0)
			{
				a.allcountries[selected_country].inflNATO = 0;
			}
			a.data[8] -= 100;
			a.data[9] -= 50;
		}
		else if (this_type == 104)
		{
			a.empires[0].relations -= 200;
			a.empires[1].relations -= 200;
			a.data[7] += 10;
			a.allcountries[selected_country].econ = true;
		}
		else if (this_type == 105)
		{
			a.empires[0].relations -= 400;
			a.empires[1].relations -= 400;
			a.data[7] += 15;
			a.allcountries[selected_country].proprc = true;
			a.allcountries[selected_country].based = true;
			a.data[22] -= 250;
		}
		else if (this_type == 106)
		{
			a.empires[0].relations -= 500;
			a.empires[1].relations -= 500;
			a.allcountries[selected_country].okb = true;
			a.allcountries[selected_country].isOVD = false;
			a.data[7] += 30;
		}
		else if (this_type == 107)
		{
			if (!a.modifies[41].active)
			{
				a.modifies[41].active = true;
			}
			else
			{
				a.modifies[41].active = false;
			}
		}
		else if (this_type == 108)
		{
			a.data[22] -= 50;
			a.data[8] -= 50;
			a.data[134] += 150;
			if (a.data[134] > 1000)
			{
				a.data[134] = 1000;
			}
		}
		else if (this_type == 109)
		{
			GlobalScript.inst.speed = 0;
			a.data[9] -= 150;
			a.data[8] -= 150;
			a.allcountries[85].based = true;
			a.number_event = 396;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 110)
		{
			a.data[8] -= 50;
			a.data[22] -= 50;
			a.allcountries[selected_country].inflCh += 100;
			a.allcountries[selected_country].inflNATO -= 100;
			if (a.allcountries[selected_country].inflCh >= 1000)
			{
				a.allcountries[selected_country].based = true;
				if (selected_country == 41)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
					a.allcountries[selected_country].Gosstroy = 1;
					a.allcountries[selected_country].SubGosstroy = 2;
					a.allcountries[selected_country].Torg = true;
				}
				else if (selected_country == 99)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
					a.allcountries[selected_country].Gosstroy = 0;
					a.allcountries[selected_country].SubGosstroy = 10;
					a.allcountries[selected_country].Torg = true;
				}
				else if (selected_country == 100)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
					a.allcountries[selected_country].Gosstroy = 1;
					a.allcountries[selected_country].SubGosstroy = 1;
					a.allcountries[selected_country].Torg = true;
				}
			}
		}
		else if (this_type == 111)
		{
			a.data[8] -= 50;
			a.data[22] -= 50;
			a.allcountries[selected_country].inflNATO += 100;
			a.allcountries[selected_country].inflCh -= 100;
			if (a.allcountries[selected_country].inflNATO >= 1000)
			{
				a.allcountries[selected_country].based = true;
				if (selected_country == 41)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
					a.allcountries[selected_country].Gosstroy = 3;
					a.allcountries[selected_country].SubGosstroy = 6;
					a.allcountries[selected_country].Torg = true;
				}
				else if (selected_country == 99)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
					a.allcountries[selected_country].Gosstroy = 0;
					a.allcountries[selected_country].SubGosstroy = 7;
					a.allcountries[selected_country].Torg = true;
				}
				else if (selected_country == 100)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
					a.allcountries[selected_country].Gosstroy = 3;
					a.allcountries[selected_country].SubGosstroy = 5;
					a.allcountries[selected_country].Torg = true;
				}
			}
		}
		else if (this_type == 112)
		{
			if (a.allcountries[1].okb)
			{
				a.allcountries[selected_country].okb = true;
			}
			else
			{
				a.allcountries[selected_country].isOVD = true;
			}
		}
		else if (this_type == 113)
		{
			a.allcountries[92].inflNATO += 10;
			a.data[8] -= 30;
			a.data[9] -= 30;
			a.allcountries[92].spec = 1;
		}
		else if (this_type == 114)
		{
			a.allcountries[selected_country].dev = 1;
			a.number_event = 408;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 115)
		{
			a.allcountries[selected_country].dev = 1;
			a.number_event = 409;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 116)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 484;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 117)
		{
			a.influencePRC -= 20;
			a.empires[0].power += 100;
			a.empires[1].relations -= 350;
			a.empires[0].relations += 350;
			if (a.allcountries[1].econ)
			{
				a.data[137] = 1;
			}
			for (int l = 0; l < a.allcountries.Length; l++)
			{
				if (a.allcountries[l].econ)
				{
					a.allcountries[l].econ = false;
					a.allcountries[l].isASEAN = true;
					a.empires[0].power += 10;
					a.influencePRC += 5;
				}
			}
			a.allcountries[1].JoinASEAN();
		}
		else if (this_type == 118)
		{
			a.influencePRC -= 20;
			a.empires[0].power += 100;
			a.data[143] += 5;
			a.empires[1].relations -= 500;
			a.empires[0].relations += 350;
			if (a.modifies[47].active)
			{
				a.modifies[47].active = false;
				a.data[135] = 1;
			}
			if (a.modifies[48].active)
			{
				a.modifies[48].active = false;
				a.data[136] = 1;
			}
			if (a.allcountries[1].okb)
			{
				a.data[138] = 1;
			}
			for (int m = 0; m < a.allcountries.Length; m++)
			{
				if (a.allcountries[m].okb)
				{
					a.allcountries[m].okb = false;
					a.allcountries[m].isSEATO = true;
					a.empires[0].power += 10;
					a.influencePRC += 5;
				}
				if (a.allcountries[m].proprc)
				{
					a.allcountries[m].prcinfl = 500;
				}
				else if (a.allcountries[m].Vyshi)
				{
					a.allcountries[m].usainfl = 500;
				}
			}
			a.allcountries[1].JoinSEATO();
		}
		else if (this_type == 119)
		{
			a.empires[0].power += 10;
			a.influencePRC += 5;
			a.empires[0].relations += 50;
			a.allcountries[selected_country].isASEAN = true;
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 120)
		{
			a.empires[0].power += 10;
			a.influencePRC += 5;
			if (selected_country == 47)
			{
				a.data[37] = 0;
			}
			a.empires[0].relations += 50;
			a.allcountries[selected_country].isSENTO = false;
			a.allcountries[selected_country].isSEATO = true;
			if (a.allcountries[selected_country].proprc)
			{
				a.allcountries[selected_country].prcinfl = 500;
			}
			else if (a.allcountries[selected_country].Vyshi)
			{
				a.allcountries[selected_country].usainfl = 500;
			}
		}
		else if (this_type == 121)
		{
			if (selected_country == 24)
			{
				if (!a.allcountries[selected_country].proprc)
				{
					a.empires[1].power += 10;
					a.empires[1].relations += 50;
					a.allcountries[selected_country].isSEV = true;
				}
				else if (a.allcountries[selected_country].proprc)
				{
					a.influencePRC += 10;
					a.empires[1].relations -= 50;
					a.allcountries[selected_country].econ = true;
				}
			}
			else if (!a.allcountries[selected_country].proprc)
			{
				a.empires[0].power += 10;
				a.empires[0].relations += 50;
				a.allcountries[selected_country].isASEAN = true;
			}
			else if (a.allcountries[selected_country].proprc)
			{
				a.influencePRC += 10;
				a.empires[0].relations -= 50;
				a.allcountries[selected_country].econ = true;
			}
		}
		else if (this_type == 122)
		{
			a.allcountries[selected_country].dev = 1;
			a.data[9] -= 100;
			a.data[8] -= 50;
			a.data[6] += 100;
			if (PlayerPrefs.GetInt("language") == 0)
			{
				a.ingamewars[0].name_war = " 第 二 次 朝 鲜 战 争";
				a.ingamewars[0].is_going = true;
				a.ingamewars[0].side1 = " 朝 鲜";
				a.ingamewars[0].side2 = " 韩 国";
			}
			else
			{
				a.ingamewars[0].name_war = "Вторая Корейская война";
				a.ingamewars[0].is_going = true;
				a.ingamewars[0].side1 = "КНДР";
				a.ingamewars[0].side2 = "РК";
			}
			if (!a.allcountries[10].proprc)
			{
				a.ingamewars[0].ussr_place = 0;
			}
			else
			{
				a.ingamewars[0].ussr_place = -1;
			}
			a.ingamewars[0].usa_place = 1;
			a.ingamewars[0].infl1 = 400;
			a.ingamewars[0].infl2 = 600;
		}
		else if (this_type == 123)
		{
			a.empires[1].power -= 50;
			a.empires[1].relations -= 200;
			a.war_active[1] = true;
			if (a.completedDecisions[9])
			{
				a.influencePRC += 25;
			}
			a.data[9] -= 50;
			a.data[8] -= 30;
			a.data[22] -= 50;
		}
		else if (this_type == 124)
		{
			a.allcountries[1].based = true;
			if (a.allcountries[1].isASEAN)
			{
				a.empires[0].relations -= 300;
			}
			else
			{
				a.empires[1].relations -= 300;
				a.allcountries[7].Torg = false;
			}
			a.allcountries[7].spec = 0;
			a.data[143] -= 5;
			a.allcountries[51].spec = 0;
			a.data[140] = 0;
			if (a.data[135] > 0)
			{
				a.modifies[47].active = true;
				a.data[135] = 0;
			}
			if (a.data[136] > 0)
			{
				a.modifies[48].active = true;
				a.data[136] = 0;
			}
			a.data[139] = 0;
			if (!GlobalScript.inst.gameState.completedDecisions[9])
			{
				for (int n = 0; n < a.allcountries.Length; n++)
				{
					if (a.allcountries[n].proprc && n != 1 && n != 2 && n != 5 && n != 9)
					{
						if (a.allcountries[1].isASEAN)
						{
							a.allcountries[n].LeaveASEAN().LeaveSEATO();
							a.empires[0].power -= 5;
						}
						else
						{
							a.allcountries[n].LeaveWP().LeaveComecon();
							a.empires[1].power -= 5;
						}
					}
				}
				if (a.data[137] > 0)
				{
					for (int num5 = 0; num5 < a.allcountries.Length; num5++)
					{
						if (num5 != 2 && num5 != 5 && num5 != 9)
						{
							a.data[137] = 0;
							if (a.allcountries[num5].proprc && num5 != 2 && num5 != 5 && num5 != 9)
							{
								a.allcountries[num5].JoinECON();
							}
						}
					}
				}
				if (a.data[138] > 0)
				{
					for (int num6 = 0; num6 < a.allcountries.Length; num6++)
					{
						if (num6 != 2 && num6 != 5 && num6 != 9)
						{
							a.data[138] = 0;
							if (a.allcountries[num6].proprc)
							{
								a.allcountries[num6].JoinOKB();
							}
						}
					}
				}
			}
			else if (GlobalScript.inst.gameState.completedDecisions[9])
			{
				for (int num7 = 0; num7 < a.allcountries.Length; num7++)
				{
					if (a.allcountries[num7].proprc && num7 != 1 && num7 != 9)
					{
						if (a.allcountries[1].isASEAN)
						{
							a.allcountries[num7].LeaveASEAN().LeaveSEATO();
							a.empires[0].power -= 5;
						}
						else
						{
							a.allcountries[num7].LeaveWP().LeaveComecon();
							a.empires[1].power -= 5;
						}
					}
				}
				if (a.data[137] > 0)
				{
					for (int num8 = 0; num8 < a.allcountries.Length; num8++)
					{
						if (num8 != 9)
						{
							a.data[137] = 0;
							if (a.allcountries[num8].proprc)
							{
								a.allcountries[num8].JoinECON();
							}
						}
					}
				}
				if (a.data[138] > 0)
				{
					for (int num9 = 0; num9 < a.allcountries.Length; num9++)
					{
						if (num9 != 9)
						{
							a.data[138] = 0;
							if (a.allcountries[num9].proprc)
							{
								a.allcountries[num9].JoinOKB();
							}
						}
					}
				}
			}
			a.allcountries[1].LeaveWP().LeaveASEAN().LeaveComecon()
				.LeaveSEATO();
		}
		else if (this_type == 125)
		{
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.allcountries[selected_country].perevorot = true;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			num10 += a.allcountries[selected_country].sovinfl / 100;
			num11 += a.allcountries[selected_country].usainfl / 100;
			num12 += a.allcountries[selected_country].prcinfl / 100;
			num10 += a.empires[1].power / 100;
			num11 += a.empires[0].power / 100;
			num12 += a.influencePRC / 100;
			if (a.allcountries[1].isSEATO)
			{
				if (num12 >= num11)
				{
					if (!a.allcountries[selected_country].proprc)
					{
						a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
						a.influencePRC += 5;
					}
					a.empires[0].power -= 5;
					a.allcountries[selected_country].usainfl = 0;
					a.allcountries[selected_country].prcinfl = 500;
					a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
					a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
				}
				else
				{
					if (!a.allcountries[selected_country].Vyshi)
					{
						a.allcountries[selected_country].EstablishGovernment(Government.ProAmerican);
						a.empires[0].power += 5;
					}
					a.allcountries[selected_country].usainfl = 500;
					a.allcountries[selected_country].prcinfl = 0;
					a.allcountries[selected_country].Gosstroy = a.allcountries[51].Gosstroy;
					a.allcountries[selected_country].SubGosstroy = a.allcountries[51].SubGosstroy;
				}
			}
			else if (num12 >= num10)
			{
				if (!a.allcountries[selected_country].proprc)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
					a.influencePRC += 5;
				}
				a.empires[1].power -= 5;
				a.allcountries[selected_country].sovinfl = 0;
				a.allcountries[selected_country].prcinfl = 500;
				a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
				a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
			}
			else
			{
				if (!a.allcountries[selected_country].prosov)
				{
					a.allcountries[selected_country].EstablishGovernment(Government.ProSoviet);
				}
				a.allcountries[selected_country].sovinfl = 500;
				a.allcountries[selected_country].prcinfl = 0;
				a.empires[1].power += 5;
				a.allcountries[selected_country].Gosstroy = a.allcountries[7].Gosstroy;
				a.allcountries[selected_country].SubGosstroy = a.allcountries[7].SubGosstroy;
			}
		}
		else if (this_type == 126)
		{
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
			a.allcountries[22].cw = true;
			a.empires[1].relations -= 250;
			a.ingamewars[27] = new War().Name(GlobalScript.inst.new_events_text[1237]).Attacker(GlobalScript.inst.new_events_text[1238]).Defender(GlobalScript.inst.new_events_text[1239])
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(30)
				.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
		}
		else if (this_type == 127)
		{
			a.empires[0].power -= 70;
			a.allcountries[21].isNATO = false;
			a.allcountries[21].isEU = false;
		}
		else if (this_type == 128)
		{
			a.data[8] -= a.allcountries[87].inflNATO;
			a.data[9] -= a.allcountries[87].inflCh;
			a.allcountries[87].based = true;
			a.allcountries[87].spec -= 10;
			a.allcountries[87].inflCh += 20;
			a.allcountries[87].inflNATO += 20;
		}
		else if (this_type == 129)
		{
			a.allcountries[49].isASEAN = false;
			a.data[8] -= 150;
			if (a.allcountries[1].isSEV)
			{
				if (a.empires[1].power > a.influencePRC)
				{
					a.allcountries[49].prosov = true;
					a.empires[1].power += 40;
					a.allcountries[49].Gosstroy = a.allcountries[7].Gosstroy;
					a.allcountries[49].SubGosstroy = a.allcountries[7].SubGosstroy;
				}
				else
				{
					a.allcountries[49].proprc = true;
					a.influencePRC += 40;
					a.allcountries[49].Gosstroy = a.allcountries[1].Gosstroy;
					a.allcountries[49].SubGosstroy = a.allcountries[1].SubGosstroy;
				}
			}
			else
			{
				a.allcountries[49].proprc = true;
				a.influencePRC += 40;
				a.allcountries[49].Gosstroy = a.allcountries[1].Gosstroy;
				a.allcountries[49].SubGosstroy = a.allcountries[1].SubGosstroy;
			}
		}
		else if (this_type == 130)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.empires[1].relations -= 10;
			a.data[22] -= 80;
			a.allcountries[selected_country].prcinfl += 200;
			a.allcountries[selected_country].sovinfl -= 400;
			if (a.allcountries[selected_country].prcinfl > 1000)
			{
				a.allcountries[selected_country].prcinfl = 1000;
			}
		}
		else if (this_type == 131)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.empires[0].relations -= 10;
			a.data[22] -= 80;
			a.allcountries[selected_country].prcinfl += 200;
			if (a.allcountries[selected_country].prcinfl > 1000)
			{
				a.allcountries[selected_country].prcinfl = 1000;
			}
			a.allcountries[selected_country].usainfl -= 400;
		}
		else if (this_type == 132)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			if (a.allcountries[1].isSEATO)
			{
				a.empires[0].relations -= 50;
			}
			else
			{
				a.empires[1].relations -= 50;
			}
			a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
		}
		else if (this_type == 133)
		{
			a.data[8] -= 250;
			a.data[9] -= 150;
			a.data[22] -= 350;
			a.allcountries[14].cw = true;
			int num13 = 0;
			if (a.allcountries[1].isOVD)
			{
				if (a.allcountries[30].Gosstroy != 3)
				{
					num13 += 50;
				}
				if (a.allcountries[35].proprc || a.allcountries[35].prosov)
				{
					num13 += 50;
				}
				if (a.allcountries[8].isOVD)
				{
					num13 += 50;
				}
				if (a.allcountries[37].isOVD)
				{
					num13 += 50;
				}
				a.empires[0].relations -= 350;
				a.ingamewars[29] = new War().Name(GlobalScript.inst.new_events_text[1320]).Attacker(GlobalScript.inst.new_events_text[1321]).Defender(GlobalScript.inst.new_events_text[1322])
					.AttackerInfluence(500 + num13)
					.DefenderInfluence(500 - num13)
					.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
			}
			else if (a.allcountries[1].isSEATO)
			{
				a.empires[1].relations -= 350;
				if (a.allcountries[30].Gosstroy == 3)
				{
					num13 += 50;
				}
				if (a.allcountries[35].proprc || a.allcountries[35].Vyshi)
				{
					num13 += 50;
				}
				if (a.allcountries[8].isSEATO)
				{
					num13 += 50;
				}
				if (a.allcountries[37].isSEATO)
				{
					num13 += 50;
				}
				a.ingamewars[29] = new War().Name(GlobalScript.inst.new_events_text[1323]).Attacker(GlobalScript.inst.new_events_text[1324]).Defender(GlobalScript.inst.new_events_text[1322])
					.AttackerInfluence(500 + num13)
					.DefenderInfluence(500 - num13)
					.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
			}
			else
			{
				a.empires[0].relations -= 350;
				a.empires[1].relations -= 350;
				if (a.allcountries[30].Gosstroy == 2)
				{
					num13 += 50;
				}
				if (a.allcountries[35].proprc)
				{
					num13 += 50;
				}
				if (a.allcountries[8].okb)
				{
					num13 += 50;
				}
				if (a.allcountries[37].okb)
				{
					num13 += 50;
				}
				num13 -= 150;
				a.ingamewars[29] = new War().Name(GlobalScript.inst.new_events_text[1325]).Attacker(GlobalScript.inst.new_events_text[1326]).Defender(GlobalScript.inst.new_events_text[1322])
					.AttackerInfluence(500 + num13)
					.DefenderInfluence(500 - num13)
					.TickTime(15)
					.AmericanSupportDefender.SovietSupportDefender.CreateWar;
			}
		}
		else if (this_type == 134)
		{
			if (!a.allcountries[selected_country].dota)
			{
				a.allcountries[selected_country].dota = true;
				int[] data = a.data;
				int num14 = 146;
				ref int reference = ref data[num14];
				int num15 = data[num14];
				reference = num15 + 1;
			}
			else
			{
				a.allcountries[selected_country].dota = false;
				int[] data2 = a.data;
				int num16 = 146;
				ref int reference2 = ref data2[num16];
				int num17 = data2[num16];
				reference2 = num17 - 1;
			}
		}
		else if (this_type == 70)
		{
			if (selected_country == 41)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 590;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 65)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 644;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 127)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 883;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 115)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 622;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 117)
			{
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.allcountries[117].SubGosstroy = 19;
			}
			else if (selected_country == 2 || selected_country == 3 || selected_country == 6)
			{
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.allcountries[selected_country].Gosstroy = 0;
				a.allcountries[selected_country].SubGosstroy = 19;
			}
		}
		else if (this_type == 135)
		{
			if (selected_country == 16)
			{
				a.modifies[53].active = true;
			}
			else if (!a.modifies[53].active)
			{
				a.modifies[53].active = true;
				if (a.allcountries[1].isSEV)
				{
					a.allcountries[16].Torg = true;
				}
			}
			else
			{
				a.modifies[53].active = false;
				a.allcountries[16].Torg = false;
			}
		}
		else if (this_type == 136)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[86].based = true;
		}
		else if (this_type == 137)
		{
			a.allcountries[17].cw = true;
			a.data[6] += 100;
			a.influencePRC -= 20;
			a.allcountries[17].Gosstroy = 0;
			a.allcountries[17].SubGosstroy = 7;
		}
		else if (this_type == 138)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 485;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 139)
		{
			a.allcountries[18].Torg = true;
			a.allcountries[18].spec = 1;
			a.allcountries[18].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[18].SubGosstroy = a.allcountries[1].SubGosstroy;
			a.allcountries[18].name = GlobalScript.inst.other_text[424];
			a.influencePRC += 20;
			a.empires[0].relations -= 150;
			a.empires[1].relations -= 150;
			a.allcountries[18].proprc = true;
			if (a.allcountries[1].isSEV)
			{
				a.allcountries[18].isSEV = true;
			}
			else if (a.allcountries[1].econ)
			{
				a.allcountries[18].econ = true;
			}
		}
		else if (this_type == 140)
		{
			a.allcountries[54].africaOff = true;
			a.allcountries[54].Torg = true;
			a.allcountries[18].spec = 1;
			a.allcountries[54].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[54].SubGosstroy = a.allcountries[1].SubGosstroy;
			a.influencePRC += 20;
			a.empires[0].relations -= 150;
			a.empires[1].relations -= 150;
			a.allcountries[54].proprc = true;
			a.allcountries[54].parts[0] = true;
			if (a.allcountries[1].isSEV)
			{
				a.allcountries[54].isSEV = true;
			}
			else if (a.allcountries[1].econ)
			{
				a.allcountries[54].econ = true;
			}
		}
		else if (this_type == 141)
		{
			a.allcountries[59].africaOff = true;
			a.allcountries[59].Torg = true;
			a.allcountries[18].spec = 1;
			a.allcountries[59].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[59].SubGosstroy = a.allcountries[1].SubGosstroy;
			a.influencePRC += 20;
			a.empires[0].relations -= 150;
			a.empires[1].relations -= 150;
			a.allcountries[59].proprc = true;
			a.allcountries[59].parts[0] = true;
			if (a.allcountries[1].isSEV)
			{
				a.allcountries[59].isSEV = true;
			}
			else if (a.allcountries[1].econ)
			{
				a.allcountries[59].econ = true;
			}
		}
		else if (this_type > 141 && this_type < 145)
		{
			if (this_type == 142)
			{
				if (selected_country == 123)
				{
					a.data[22] -= 100;
					a.allcountries[selected_country].sovinfl = 3;
					if (a.resultOfEvents[638] == 0)
					{
						a.allcountries[123].prcpower += 25;
					}
					else if (a.resultOfEvents[638] == 1)
					{
						a.allcountries[123].sovpower += 25;
					}
					else if (a.resultOfEvents[638] == 2)
					{
						a.allcountries[123].usapower += 25;
					}
				}
				else
				{
					a.data[22] -= 50;
					a.allcountries[selected_country].sovinfl = 3;
				}
			}
			else if (this_type == 143)
			{
				if (selected_country == 123)
				{
					a.data[8] -= 50;
					a.allcountries[selected_country].usainfl = 3;
					if (a.resultOfEvents[638] == 0)
					{
						a.allcountries[123].prcpower += 15;
					}
					else if (a.resultOfEvents[638] == 1)
					{
						a.allcountries[123].sovpower += 15;
					}
					else if (a.resultOfEvents[638] == 2)
					{
						a.allcountries[123].usapower += 15;
					}
				}
				else
				{
					a.data[9] -= 50;
					a.allcountries[selected_country].usainfl = 3;
				}
			}
			else if (selected_country == 123)
			{
				a.data[9] -= 50;
				a.allcountries[selected_country].prcinfl = 3;
				if (a.resultOfEvents[638] == 0)
				{
					if (a.allcountries[123].sovpower > 10)
					{
						a.allcountries[123].sovpower -= 10;
					}
					if (a.allcountries[123].usapower > 10)
					{
						a.allcountries[123].usapower -= 10;
					}
				}
				else if (a.resultOfEvents[638] == 1)
				{
					if (a.allcountries[123].prcpower > 10)
					{
						a.allcountries[123].prcpower -= 10;
					}
					if (a.allcountries[123].usapower > 10)
					{
						a.allcountries[123].usapower -= 10;
					}
				}
				else if (a.resultOfEvents[638] == 2)
				{
					if (a.allcountries[123].prcpower > 10)
					{
						a.allcountries[123].prcpower -= 10;
					}
					if (a.allcountries[123].sovpower > 10)
					{
						a.allcountries[123].sovpower -= 10;
					}
				}
			}
			else
			{
				a.data[8] -= 30;
				a.allcountries[selected_country].prcinfl = 3;
			}
			if (selected_country != 123)
			{
				a.allcountries[selected_country].inflCh += 200;
				if (a.allcountries[selected_country].inflCh > 1000)
				{
					a.allcountries[selected_country].inflCh = 1000;
				}
				if (a.allcountries[selected_country].inflCh >= 1000)
				{
					a.influencePRC += 10;
					a.empires[0].relations -= 100;
					a.empires[1].relations -= 100;
					a.allcountries[selected_country].proprc = true;
				}
			}
		}
		else if (this_type > 144 && this_type < 147)
		{
			a.data[9] -= 50;
			a.influencePRC -= 5;
			a.allcountries[36].inflNATO = 3;
			if (this_type == 145)
			{
				if (a.data[143] + 5 <= 60)
				{
					a.data[143] += 5;
				}
				else
				{
					a.data[143] = 60;
				}
				a.empires[1].relations += 50;
				a.empires[0].relations -= 50;
			}
			else
			{
				if (a.data[143] - 5 >= 10)
				{
					a.data[143] -= 5;
				}
				else
				{
					a.data[143] = 10;
				}
				a.empires[1].relations -= 50;
				a.empires[0].relations += 50;
			}
		}
		else if (this_type == 147)
		{
			a.data[9] -= 50;
			a.data[8] -= 100;
			a.data[22] -= 100;
			a.influencePRC += 80;
			a.allcountries[selected_country].EstablishGovernment(Government.ProChina);
			a.allcountries[selected_country].Torg = true;
			a.allcountries[selected_country].stab = 0;
			a.allcountries[selected_country].spec = 1;
			a.allcountries[selected_country].Gosstroy = 2;
			a.allcountries[selected_country].SubGosstroy = 15;
			a.empires[0].relations -= 300;
			a.empires[0].power -= 30;
		}
		else if (this_type == 148)
		{
			if (!a.allcountries[85].isSocEU)
			{
				a.allcountries[selected_country].proprc = true;
				a.allcountries[selected_country].Torg = true;
				int num18 = 0;
				int num19 = 0;
				if (a.allcountries[21].Gosstroy == 1)
				{
					num18++;
				}
				if (a.allcountries[45].Gosstroy == 1)
				{
					num18++;
				}
				if (a.allcountries[84].Gosstroy == 1)
				{
					num18++;
				}
				if (a.allcountries[85].Gosstroy == 1)
				{
					num18++;
				}
				if (a.allcountries[86].Gosstroy == 1)
				{
					num18++;
				}
				if (a.allcountries[87].Gosstroy == 1)
				{
					num18++;
				}
				if (a.allcountries[92].Gosstroy == 1)
				{
					num18++;
				}
				if (a.allcountries[21].Gosstroy == 2)
				{
					num19++;
				}
				if (a.allcountries[45].Gosstroy == 2)
				{
					num19++;
				}
				if (a.allcountries[84].Gosstroy == 2)
				{
					num19++;
				}
				if (a.allcountries[85].Gosstroy == 2)
				{
					num19++;
				}
				if (a.allcountries[86].Gosstroy == 2)
				{
					num19++;
				}
				if (a.allcountries[87].Gosstroy == 2)
				{
					num19++;
				}
				if (a.allcountries[92].Gosstroy == 2)
				{
					num19++;
				}
				if (num18 >= num19)
				{
					if (a.allcountries[1].Gosstroy != 1)
					{
						a.allcountries[selected_country].Gosstroy = 1;
						a.allcountries[selected_country].SubGosstroy = 1;
					}
					else
					{
						a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
						a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
					}
				}
				else if (a.allcountries[1].Gosstroy != 2)
				{
					a.allcountries[selected_country].Gosstroy = 2;
					a.allcountries[selected_country].SubGosstroy = 3;
				}
				else
				{
					a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
					a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
				}
				a.allcountries[selected_country].cw = true;
				a.influencePRC += 20;
				a.data[8] -= 200;
				a.data[9] -= 200;
			}
			else
			{
				a.allcountries[selected_country].Torg = true;
				a.allcountries[selected_country].isSocEU = true;
				a.allcountries[selected_country].Gosstroy = 2;
				a.allcountries[selected_country].SubGosstroy = 14;
				a.allcountries[selected_country].cw = true;
				a.influencePRC += 5;
				a.data[8] -= 50;
				a.data[9] -= 50;
			}
		}
		else if (this_type == 149)
		{
			a.allcountries[selected_country].proprc = true;
			a.allcountries[selected_country].cw = true;
			a.allcountries[selected_country].Torg = true;
			int num20 = 0;
			int num21 = 0;
			if (a.allcountries[21].Gosstroy == 0)
			{
				num20++;
			}
			if (a.allcountries[45].Gosstroy == 0)
			{
				num20++;
			}
			if (a.allcountries[84].Gosstroy == 0)
			{
				num20++;
			}
			if (a.allcountries[85].Gosstroy == 0)
			{
				num20++;
			}
			if (a.allcountries[86].Gosstroy == 0)
			{
				num20++;
			}
			if (a.allcountries[87].Gosstroy == 0)
			{
				num20++;
			}
			if (a.allcountries[92].Gosstroy == 0)
			{
				num20++;
			}
			if (a.allcountries[21].Gosstroy == 3)
			{
				num21++;
			}
			if (a.allcountries[45].Gosstroy == 3)
			{
				num21++;
			}
			if (a.allcountries[84].Gosstroy == 3)
			{
				num21++;
			}
			if (a.allcountries[85].Gosstroy == 3)
			{
				num21++;
			}
			if (a.allcountries[86].Gosstroy == 3)
			{
				num21++;
			}
			if (a.allcountries[87].Gosstroy == 3)
			{
				num21++;
			}
			if (a.allcountries[92].Gosstroy == 3)
			{
				num21++;
			}
			if (num20 >= num21)
			{
				if (a.allcountries[1].Gosstroy != 0)
				{
					if (a.allcountries[21].SubGosstroy == 9 || a.allcountries[45].SubGosstroy == 9 || a.allcountries[84].SubGosstroy == 9 || a.allcountries[85].SubGosstroy == 9 || a.allcountries[86].SubGosstroy == 9 || a.allcountries[87].SubGosstroy == 9 || a.allcountries[92].SubGosstroy == 9)
					{
						a.allcountries[selected_country].Gosstroy = 0;
						a.allcountries[selected_country].SubGosstroy = 9;
					}
					else
					{
						a.allcountries[selected_country].Gosstroy = 0;
						a.allcountries[selected_country].SubGosstroy = 7;
					}
				}
				else
				{
					a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
					a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
				}
			}
			else if (a.allcountries[1].Gosstroy != 3)
			{
				a.allcountries[selected_country].Gosstroy = 3;
				a.allcountries[selected_country].SubGosstroy = 5;
			}
			else
			{
				a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
				a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
			}
			a.influencePRC += 20;
			a.data[8] -= 200;
			a.data[9] -= 200;
		}
		else if (this_type == 1000)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 535;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1001)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 439;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1002)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 440;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1003)
		{
			a.data[9] -= 50;
			a.data[8] -= 50;
			GlobalScript.inst.gameState.allcountries[58].cw = true;
		}
		else if (this_type == 1004)
		{
			a.data[9] -= 100;
			a.data[8] -= 100;
			GlobalScript.inst.gameState.allcountries[58].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 19;
		}
		else if (this_type == 1005)
		{
			a.number_event = 461;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1006)
		{
			a.allcountries[54].cw = true;
			a.data[8] -= 3;
			a.data[9] -= 5;
		}
		else if (this_type == 1007)
		{
			a.data[22] -= 5;
			a.data[8] += 3;
			a.allcountries[18].cw = true;
		}
		else if (this_type == 1008)
		{
			a.number_event = 464;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1009)
		{
			a.allcountries[21].soc_stab += 10;
			a.data[8] -= 30;
			a.data[9] -= 30;
			a.allcountries[21].spec = 1;
		}
		else if (this_type == 1010)
		{
			a.number_event = 482;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1011)
		{
			a.data[8] -= 100;
			a.data[9] -= 50;
			a.number_event = 490;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1012)
		{
			a.data[8] -= 50;
			a.data[9] -= 100;
			if (a.allcountries[1].Gosstroy == 0 || a.allcountries[1].Gosstroy == 1)
			{
				a.allcountries[5].spec = 1;
			}
			else
			{
				a.allcountries[5].spec = 2;
			}
		}
		else if (this_type == 1013)
		{
			a.number_event = 495;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1014)
		{
			a.empires[0].relations += 20;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.allcountries[selected_country].prcinfl += 10;
		}
		else if (this_type == 1015)
		{
			GlobalScript.inst.speed = 0;
			a.data[9] -= 150;
			a.data[8] -= 150;
			a.data[22] -= 150;
			a.allcountries[44].based = true;
			a.number_event = 538;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1016)
		{
			a.data[8] -= 100;
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.allcountries[35].cw = true;
		}
		else if (this_type == 1017)
		{
			a.data[9] -= 50;
			a.data[8] -= 50;
			a.data[22] -= 50;
			a.allcountries[85].prcpower += 100;
		}
		else if (this_type == 1018)
		{
			a.data[9] -= 50;
			a.data[8] -= 100;
			a.allcountries[85].Gosstroy = 1;
			a.allcountries[85].SubGosstroy = 16;
			a.allcountries[85].isSEV = true;
			a.allcountries[85].isOVD = true;
		}
		else if (this_type == 1019)
		{
			a.allcountries[40].cw = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
		}
		else if (this_type == 1020)
		{
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.data[22] -= 150;
			GlobalScript.inst.speed = 0;
			a.number_event = 563;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1021)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 567;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1022)
		{
			if (a.allcountries[24].prcpower < 100)
			{
				a.allcountries[24].prcpower += 10;
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[24].stab = 1;
			}
			else
			{
				a.data[8] -= 150;
				a.data[9] -= 150;
				a.data[22] -= 150;
				GlobalScript.inst.speed = 0;
				a.number_event = 568;
				SceneManager.LoadScene("Event");
			}
		}
		else if (this_type == 1023)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 569;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1024)
		{
			if (selected_country == 134)
			{
				a.allcountries[134].cw = true;
				a.allcountries[134].Gosstroy = 2;
				a.allcountries[134].SubGosstroy = 3;
				a.allcountries[134].puppetOf = -1;
				a.allcountries[134].LeaveAlliances();
				a.allcountries[134].proprc = true;
				a.allcountries[134].Torg = true;
				a.data[8] -= 50;
				a.data[9] -= 50;
			}
			else if (selected_country == 136)
			{
				a.allcountries[136].cw = true;
				a.data[8] -= 200;
				a.data[9] -= 200;
				if (a.data[56] == 0 || a.data[56] == 1)
				{
					a.allcountries[136].Gosstroy = 1;
					a.allcountries[136].SubGosstroy = 1;
					a.allcountries[136].puppetOf = -1;
					a.allcountries[136].LeaveAlliances();
					a.allcountries[136].proprc = true;
					a.allcountries[136].Torg = true;
				}
				else if (a.data[56] == 2)
				{
					a.allcountries[136].Gosstroy = 2;
					a.allcountries[136].SubGosstroy = 3;
					a.allcountries[136].puppetOf = -1;
					a.allcountries[136].LeaveAlliances();
					a.allcountries[136].proprc = true;
					a.allcountries[136].Torg = true;
					if (a.allcountries[21].isSocEU)
					{
						a.allcountries[136].isSocEU = true;
					}
				}
				else if (a.data[56] == 3)
				{
					a.allcountries[136].Gosstroy = 2;
					a.allcountries[136].SubGosstroy = 8;
					a.allcountries[136].puppetOf = -1;
					a.allcountries[136].LeaveAlliances();
					a.allcountries[136].proprc = true;
					a.allcountries[136].Torg = true;
				}
				else if (a.data[56] == 4)
				{
					a.allcountries[136].Gosstroy = 3;
					a.allcountries[136].SubGosstroy = 12;
					a.allcountries[136].puppetOf = -1;
					a.allcountries[136].LeaveAlliances();
					a.allcountries[136].proprc = true;
					a.allcountries[136].Torg = true;
				}
			}
			else if (selected_country == 56)
			{
				a.allcountries[56].cw = true;
				a.data[8] -= 50;
				a.data[9] -= 50;
			}
			else if (selected_country == 112)
			{
				a.allcountries[112].cw = true;
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.allcountries[112].level_of_unstab += 100;
			}
			else if (selected_country == 66)
			{
				a.allcountries[66].level_of_unstab += 100;
				a.allcountries[66].cw = true;
				a.data[9] -= 50;
				a.data[22] -= 100;
			}
			else if (selected_country == 116)
			{
				a.allcountries[116].cw = true;
				a.data[9] -= 50;
				a.data[8] -= 50;
			}
		}
		else if (this_type == 1025)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[134].parts[0] = true;
			a.allcountries[134].puppetOf = -1;
			a.allcountries[134].LeaveAlliances();
			a.allcountries[134].Gosstroy = 1;
			a.allcountries[134].SubGosstroy = 1;
			a.allcountries[134].proprc = true;
			a.allcountries[134].Torg = true;
		}
		else if (this_type == 1026)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[140].stab = 1;
		}
		else if (this_type == 1027)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[140].stab = 2;
		}
		else if (this_type == 1028)
		{
			a.allcountries[145].cw = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[145].SubGosstroy = 0;
		}
		else if (this_type == 1029)
		{
			a.allcountries[145].cw = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[145].SubGosstroy = 17;
		}
		else if (this_type == 1030)
		{
			a.allcountries[145].cw = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[145].SubGosstroy = 16;
		}
		else if (this_type == 1031)
		{
			a.allcountries[145].cw = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[145].SubGosstroy = 18;
		}
		else if (this_type == 1032)
		{
			if (selected_country == 125)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 584;
				SceneManager.LoadScene("Event");
			}
			if (selected_country == 119)
			{
				a.data[8] -= 50;
				a.data[9] -= 30;
				a.allcountries[119].cw = true;
			}
			if (selected_country == 108)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 593;
				SceneManager.LoadScene("Event");
			}
			if (selected_country == 64)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 592;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 56)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 606;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 112)
			{
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.data[22] -= 100;
				GlobalScript.inst.speed = 0;
				a.number_event = 616;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 66)
			{
				a.data[9] -= 100;
				a.data[22] -= 100;
				GlobalScript.inst.speed = 0;
				a.number_event = 617;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 116)
			{
				a.data[9] -= 100;
				a.data[22] -= 100;
				GlobalScript.inst.speed = 0;
				a.number_event = 619;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 115)
			{
				a.data[22] -= 100;
				GlobalScript.inst.speed = 0;
				a.number_event = 620;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 59)
			{
				a.data[8] -= 150;
				a.data[9] -= 100;
				GlobalScript.inst.speed = 0;
				a.number_event = 627;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 154)
			{
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.allcountries[154].cw = true;
			}
			else if (selected_country == 152)
			{
				a.data[8] -= 50;
				a.allcountries[152].Gosstroy = 1;
				a.allcountries[152].SubGosstroy = 1;
				a.allcountries[152].LeaveAlliances();
				a.allcountries[152].Torg = true;
				a.allcountries[152].proprc = true;
				a.empires[0].relations -= 50;
			}
		}
		else if (this_type == 1033)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 591;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1034)
		{
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.data[22] -= 150;
			a.allcountries[138].cw = true;
			a.allcountries[138].parts[0] = true;
			a.ingamewars[49] = new War().Name("第 二 次 猪 湾 事 件").Attacker("美 国").Defender("古 巴")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
		else if (this_type == 1035)
		{
			a.data[8] -= 100;
			a.allcountries[41].parts[0] = false;
			a.allcountries[41].parts[1] = true;
			a.allcountries[106].LeaveAlliances();
		}
		else if (this_type == 1036)
		{
			a.data[8] -= 100;
			a.allcountries[selected_country].LeaveAlliances();
			a.allcountries[selected_country].proprc = true;
			a.allcountries[selected_country].Torg = true;
			a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
			a.empires[0].relations -= 250;
		}
		else if (this_type == 1037)
		{
			if (!a.allcountries[selected_country].cw)
			{
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.allcountries[selected_country].cw = true;
			}
			else
			{
				a.data[8] -= 50;
				a.data[9] -= 100;
				a.data[22] -= 100;
				a.allcountries[153].Gosstroy = 1;
				a.allcountries[153].SubGosstroy = 1;
			}
		}
		else if (this_type == 1038)
		{
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
			a.allcountries[selected_country].cw = true;
			a.allcountries[selected_country].LeaveAlliances();
			a.allcountries[selected_country].proprc = true;
			a.allcountries[selected_country].Torg = true;
			a.allcountries[selected_country].Gosstroy = a.allcountries[1].Gosstroy;
			a.allcountries[selected_country].SubGosstroy = a.allcountries[1].SubGosstroy;
			a.allcountries[selected_country].name = "斯 威 士 兰 人 民 共 和 国";
		}
		else if (this_type == 1039)
		{
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
			if (a.allcountries[selected_country].SubGosstroy == 3)
			{
				a.allcountries[selected_country].Gosstroy = 1;
				a.allcountries[selected_country].SubGosstroy = 17;
				a.allcountries[selected_country].proprc = true;
				a.allcountries[selected_country].Torg = true;
			}
			else
			{
				a.allcountries[selected_country].Gosstroy = 1;
				a.allcountries[selected_country].SubGosstroy = 16;
				a.allcountries[selected_country].prosov = true;
				a.allcountries[selected_country].Torg = true;
			}
		}
		else if (this_type == 1040)
		{
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
			if (a.allcountries[selected_country].SubGosstroy == 3)
			{
				a.allcountries[selected_country].Gosstroy = 3;
				a.allcountries[selected_country].SubGosstroy = 4;
				a.allcountries[selected_country].proprc = true;
				a.allcountries[selected_country].Torg = true;
			}
			else
			{
				a.allcountries[selected_country].Gosstroy = 0;
				a.allcountries[selected_country].SubGosstroy = 7;
				a.allcountries[selected_country].proprc = true;
				a.allcountries[selected_country].Torg = true;
			}
		}
		else if (this_type == 1041)
		{
			a.data[8] -= 100;
			a.allcountries[selected_country].Gosstroy = 3;
			a.allcountries[selected_country].SubGosstroy = 4;
			a.allcountries[selected_country].proprc = true;
			a.allcountries[selected_country].Torg = true;
		}
		else if (this_type == 1042)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 612;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1043)
		{
			if (selected_country == 126)
			{
				a.data[8] -= 50;
				a.data[22] -= 50;
				a.allcountries[126].level_of_unstab += 15;
				a.allcountries[126].cw = true;
			}
			else if (selected_country == 59)
			{
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.allcountries[59].cw = true;
				a.allcountries[59].Gosstroy = 3;
				a.allcountries[59].SubGosstroy = 4;
				a.allcountries[59].LeaveAlliances();
				if (a.allcountries[54].proprc)
				{
					a.allcountries[59].proprc = true;
					a.allcountries[59].Torg = true;
				}
				else
				{
					a.allcountries[59].LeaveAlliances();
					a.allcountries[59].Torg = true;
				}
			}
			else if (selected_country == 129)
			{
				a.data[8] -= 80;
				a.data[9] -= 30;
				a.allcountries[129].level_of_unstab += 100;
			}
			else if (selected_country == 159)
			{
				a.data[8] -= 50;
				a.allcountries[159].level_of_unstab = 100;
			}
			else if (selected_country == 149)
			{
				if (a.allcountries[selected_country].Gosstroy != 3 && !a.IsAuthoritarianism(selected_country))
				{
					a.data[8] -= 50;
					a.data[9] -= 50;
					a.data[22] -= 50;
					a.allcountries[selected_country].level_of_unstab += 25;
					a.allcountries[selected_country].cw = true;
				}
				else
				{
					a.data[8] -= 50;
					a.data[9] -= 50;
					a.data[22] -= 50;
					a.allcountries[selected_country].level_of_unstab += 10;
					a.allcountries[selected_country].cw = true;
				}
			}
			else if (selected_country == 147)
			{
				if (a.allcountries[selected_country].Gosstroy != 3 && !a.IsAuthoritarianism(selected_country))
				{
					a.data[8] -= 50;
					a.data[9] -= 50;
					a.data[22] -= 50;
					a.allcountries[selected_country].level_of_unstab += 30;
					a.allcountries[selected_country].cw = true;
				}
				else
				{
					a.data[8] -= 50;
					a.data[9] -= 50;
					a.data[22] -= 50;
					a.allcountries[selected_country].level_of_unstab += 30;
					a.allcountries[selected_country].cw = true;
				}
			}
		}
		else if (this_type == 1044)
		{
			if (selected_country == 126)
			{
				a.data[8] -= 50;
				a.data[22] -= 50;
				a.data[9] -= 50;
				a.allcountries[126].level_of_unstab -= 30;
				a.allcountries[126].cw = true;
			}
			else if (selected_country == 59)
			{
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.allcountries[59].cw = true;
				a.allcountries[59].Gosstroy = 0;
				a.allcountries[59].SubGosstroy = 10;
				a.allcountries[59].LeaveAlliances();
				a.allcountries[59].puppetOf = 13;
				a.allcountries[59].Torg = true;
				a.allcountries[59].name = "阿 拉 伯 毛 里 塔 尼 亚\n 人 民 社 会 主 义 民 众 国";
			}
			else if (selected_country == 129)
			{
				a.data[22] -= 50;
				a.data[9] -= 50;
				a.allcountries[129].cw = true;
			}
			else if (selected_country == 159)
			{
				a.data[8] -= 100;
				a.allcountries[159].cw = true;
			}
			else if (selected_country == 149)
			{
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[selected_country].level_of_unstab -= 10;
				a.allcountries[selected_country].cw = true;
			}
			else if (selected_country == 147)
			{
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[selected_country].level_of_unstab -= 25;
				a.allcountries[selected_country].cw = true;
			}
		}
		else if (this_type == 1045)
		{
			if (selected_country == 126)
			{
				a.data[8] -= 100;
				a.data[22] -= 100;
				a.allcountries[126].level_of_unstab += 200;
			}
			else if (selected_country == 59)
			{
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.allcountries[59].cw = true;
				a.allcountries[59].Gosstroy = 0;
				a.allcountries[59].SubGosstroy = 10;
				a.allcountries[59].LeaveAlliances();
				a.allcountries[59].proprc = true;
				a.allcountries[59].Torg = true;
				a.allcountries[59].name = "阿 拉 伯 毛 里 塔 尼 亚 共 和 国";
			}
			else if (selected_country == 129)
			{
				a.data[9] -= 100;
				GlobalScript.inst.speed = 0;
				a.number_event = 628;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 159)
			{
				a.data[8] -= 50;
				a.data[9] -= 100;
				a.allcountries[154].level_of_unstab = 100;
			}
			else if (selected_country == 149)
			{
				a.data[22] -= 80;
				GlobalScript.inst.speed = 0;
				a.number_event = 634;
				SceneManager.LoadScene("Event");
			}
		}
		else if (this_type == 1046)
		{
			a.data[22] -= 100;
			a.data[9] -= 100;
			GlobalScript.inst.speed = 0;
			a.number_event = 630;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1047)
		{
			a.data[9] -= 100;
			a.allcountries[123].level_of_unstab = 100;
			a.allcountries[123].SubGosstroy = 17;
			a.allcountries[123].LeaveAlliances();
			a.allcountries[123].proprc = true;
			a.allcountries[123].Torg = true;
		}
		else if (this_type == 1048)
		{
			a.data[9] -= 100;
			a.allcountries[123].level_of_unstab = 200;
			a.allcountries[123].SubGosstroy = 1;
			a.allcountries[123].LeaveAlliances();
			a.allcountries[123].proprc = true;
			a.allcountries[123].Torg = true;
		}
		else if (this_type == 1049)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 638;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1050)
		{
			if (selected_country == 161)
			{
				a.data[8] -= 200;
				a.data[9] -= 200;
				a.allcountries[161].LeaveAlliances();
				a.allcountries[161].proprc = true;
				a.allcountries[161].Torg = true;
				a.allcountries[161].cw = true;
				a.influencePRC += 20;
				if (a.IsSocialism(yes: true, 135) && a.IsSocialism(yes: true, 159) && a.IsSocialism(yes: true, 136) && a.allcountries[135].SubGosstroy != 8)
				{
					a.allcountries[161].Gosstroy = 1;
					a.allcountries[161].SubGosstroy = 1;
				}
				else
				{
					a.allcountries[161].Gosstroy = 2;
					a.allcountries[161].SubGosstroy = 3;
				}
			}
			else if (selected_country == 160)
			{
				a.data[8] -= 200;
				a.data[9] -= 200;
				GlobalScript.inst.speed = 0;
				a.number_event = 639;
				SceneManager.LoadScene("Event");
			}
		}
		else if (this_type == 1051)
		{
			if (selected_country == 161)
			{
				a.data[8] -= 200;
				a.data[9] -= 200;
				a.allcountries[161].LeaveAlliances();
				a.allcountries[161].Gosstroy = 3;
				a.allcountries[161].SubGosstroy = 6;
				if (a.allcountries[135].proprc || a.allcountries[159].proprc || a.allcountries[136].proprc)
				{
					a.allcountries[161].proprc = true;
				}
				a.allcountries[161].Torg = true;
				a.influencePRC += 10;
			}
			else if (selected_country == 160)
			{
				a.data[8] -= 200;
				a.data[9] -= 200;
				a.allcountries[160].Gosstroy = 0;
				a.allcountries[160].SubGosstroy = 10;
				a.allcountries[160].LeaveAlliances();
				a.allcountries[160].proprc = true;
				a.allcountries[160].Torg = true;
				if (a.allcountries[1].SubGosstroy == 19)
				{
					a.allcountries[160].SubGosstroy = 19;
				}
				a.allcountries[160].name = "斐 济 王 国";
			}
		}
		else if (this_type == 1052)
		{
			if (selected_country == 9)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 640;
				SceneManager.LoadScene("Event");
			}
			else if (selected_country == 7)
			{
				a.data[8] -= 200;
				a.data[9] -= 200;
				a.allcountries[160].Gosstroy = 0;
				a.allcountries[160].SubGosstroy = 10;
				a.allcountries[160].LeaveAlliances();
				a.allcountries[160].proprc = true;
				a.allcountries[160].Torg = true;
				if (a.allcountries[1].SubGosstroy == 19)
				{
					a.allcountries[160].SubGosstroy = 19;
				}
				a.allcountries[160].name = "斐 济 王 国";
			}
		}
		else if (this_type == 1053)
		{
			a.allcountries[107].cw = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
		}
		else if (this_type == 1054)
		{
			a.allcountries[60].based = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.allcountries[60].prcpower += 10;
		}
		else if (this_type == 1055)
		{
			if (a.allcountries[60].cw)
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 657;
				SceneManager.LoadScene("Event");
			}
			else
			{
				GlobalScript.inst.speed = 0;
				a.number_event = 656;
				SceneManager.LoadScene("Event");
			}
		}
		else if (this_type == 1056)
		{
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
			GlobalScript.inst.speed = 0;
			a.number_event = 386;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 1057)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[659] == 1)
			{
				a.allcountries[118].inflNATO += 50;
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[118].cw = true;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[659] == 2)
			{
				a.allcountries[118].inflCh += 50;
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[118].cw = true;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[659] == 3)
			{
				a.allcountries[118].prcinfl += 75;
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[118].cw = true;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[659] == 4)
			{
				a.allcountries[118].sovinfl += 75;
				a.data[8] -= 50;
				a.data[9] -= 50;
				a.data[22] -= 50;
				a.allcountries[118].cw = true;
			}
		}
		else if (this_type == 1058)
		{
			a.data[22] -= 150;
			a.allcountries[53].Torg = false;
			a.allcountries[53].cw = true;
			a.data[8] += 30;
			a.OilProd += 100f;
		}
		else if (this_type == 1059)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[53].prcinfl = 1;
		}
		else if (this_type == 1060)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[53].prcinfl = 2;
		}
		else if (this_type == 1061)
		{
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.allcountries[33].inflCh += 10;
			a.allcountries[33].cw = true;
		}
		else if (this_type == 1062)
		{
			a.allcountries[141].cw = true;
		}
		else if (this_type == 1063)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 671;
			SceneManager.LoadScene("Event");
		}
		else if (this_type == 10000)
		{
			GlobalScript.inst.speed = 0;
			a.number_event = 407;
			SceneManager.LoadScene("Event");
		}
		map1.UpdateMap();
		map1.ShowHideOcno(active: false);
	}

	private void OnMouseEnter()
	{
		if (!is_active)
		{
			return;
		}
		GetComponent<SpriteRenderer>().sprite = on;
		opis.GetComponent<TextMesh>().text = Utils.Text(this_opis, 80);
		for (int i = 0; i < number_uslovie; i++)
		{
			uslovie[i].GetComponent<TextMesh>().text = Utils.Text(uslovie_text[i], 33);
			if (uslovie_bool[i])
			{
				uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = usl_on;
			}
			else
			{
				uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = usl_off;
			}
		}
	}

	private void OnMouseExit()
	{
		if (is_active)
		{
			GetComponent<SpriteRenderer>().sprite = off;
			opis.GetComponent<TextMesh>().text = null;
			for (int i = 0; i < 4; i++)
			{
				uslovie[i].GetComponent<TextMesh>().text = null;
				uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			}
		}
	}

	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
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
		return text2;
	}
}
