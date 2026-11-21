using System;
using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doneventscript : MonoBehaviour
{
	private GlobalScript global1;

	public int this_otvet;

	public bool nazad;

	public bool first;

	public Sprite navel;

	public Sprite nenavel;

	public Sprite[] stamps = new Sprite[1];

	public TextMesh Name;

	public TextMesh Zaglav;

	public TextMesh[] otveti = new TextMesh[6];

	public SpriteRenderer this_stamp;

	public GameObject Galkasum;

	public GameObject Nazad;

	public GameObject Vpered;

	public GameObject thisObject;

	public GameObject[] galka_stuk = new GameObject[6];

	public int kolvo_variant;

	public int summa_3_2;

	private Type MyScriptType = Type.GetType("Event" + GlobalScript.inst.gameState.number_event + ",Assembly-CSharp");

	private void Awake()
	{
		global1 = GlobalScript.inst;
		if (GlobalScript.inst.gameState.number_event != 60000)
		{
			GlobalScript.inst.gameState.event_done[GlobalScript.inst.gameState.number_event] = true;
		}
		if (nazad)
		{
			return;
		}
		if (GlobalScript.inst.gameState.number_event >= 0)
		{
			thisObject.AddComponent(MyScriptType);
		}
		if (GlobalScript.inst.gameState.data[15] > 7)
		{
			int num = GlobalScript.inst.gameState.party_number[1];
			for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
			{
				if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
				{
					num += GlobalScript.inst.gameState.party_number[i];
				}
			}
			int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
			summa_3_2 = num * 100 / num2;
		}
		Azkaban();
		global1.this_stump = UnityEngine.Random.Range(0, 38);
		if (stamps[global1.this_stump] != null)
		{
			int[] array = new int[37]
			{
				0, 1, 2, 4, 5, 6, 7, 8, 9, 12,
				13, 14, 15, 16, 17, 18, 19, 20, 21, 22,
				23, 24, 25, 26, 28, 29, 30, 31, 32, 33,
				34, 35, 36, 37, 44, 53, 54
			};
			int num3 = UnityEngine.Random.Range(0, array.Length);
			if (GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active)
			{
				global1.this_stump = array[num3];
			}
			if (GlobalScript.inst.gameState.number_event == 19)
			{
				global1.this_stump = 31;
			}
			if (GlobalScript.inst.gameState.number_event == 20)
			{
				global1.this_stump = 37;
			}
			if (GlobalScript.inst.gameState.number_event == 493)
			{
				global1.this_stump = 12;
			}
			if (GlobalScript.inst.gameState.number_event == 376 || GlobalScript.inst.gameState.number_event == 588)
			{
				global1.this_stump = 39;
			}
			if (GlobalScript.inst.gameState.number_event == 457)
			{
				global1.this_stump = 19;
			}
			if (GlobalScript.inst.gameState.number_event == 469)
			{
				global1.this_stump = 41;
			}
			if (GlobalScript.inst.gameState.number_event == 325 || GlobalScript.inst.gameState.number_event == 324 || GlobalScript.inst.gameState.number_event == 322)
			{
				global1.this_stump = 42;
			}
			if (GlobalScript.inst.gameState.number_event == 500)
			{
				global1.this_stump = 43;
			}
			if (GlobalScript.inst.gameState.number_event == 548 || (GlobalScript.inst.gameState.number_event == 59 && GlobalScript.inst.gameState.IsSocialism(yes: true, 1)))
			{
				global1.this_stump = 45;
			}
			if (GlobalScript.inst.gameState.number_event == 470 || GlobalScript.inst.gameState.number_event == 471)
			{
				global1.this_stump = 46;
			}
			if (GlobalScript.inst.gameState.number_event == 23)
			{
				global1.this_stump = 47;
			}
			if (GlobalScript.inst.gameState.number_event == 665)
			{
				global1.this_stump = 48;
			}
			if (GlobalScript.inst.gameState.number_event == 665)
			{
				global1.this_stump = 49;
			}
			if (GlobalScript.inst.gameState.number_event == 667)
			{
				global1.this_stump = 50;
			}
			if (GlobalScript.inst.gameState.number_event == 82)
			{
				global1.this_stump = 52;
			}
			if (global1.this_stump == 10 && (!GlobalScript.inst.gameState.event_done[25] || GlobalScript.inst.gameState.resultOfEvents[25] != 0) && (!GlobalScript.inst.gameState.event_done[26] || GlobalScript.inst.gameState.resultOfEvents[26] != 0) && GlobalScript.inst.gameState.modifies[3].active)
			{
				global1.this_stump = 28;
			}
			if (GlobalScript.inst.gameState.number_event == 552)
			{
				global1.this_stump = 38;
			}
			this_stamp.sprite = stamps[global1.this_stump];
		}
	}

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = navel;
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = nenavel;
	}

	private void OnMouseDown()
	{
		if (!nazad && !first)
		{
			Name.text = "";
			Zaglav.text = "";
			first = true;
			Nazad.SetActive(value: true);
			Galkasum.SetActive(value: true);
			string[] fake_text = new string[6];
			if ((GlobalScript.inst.gameState.number_event > 0 && PlayerPrefs.GetInt("language") == 0) || (PlayerPrefs.GetInt("language") == 1 && GlobalScript.inst.gameState.number_event >= 120 && GlobalScript.inst.gameState.number_event != 435 && GlobalScript.inst.gameState.number_event != 436))
			{
				thisObject.GetComponent<EventsSecond>().VariantsOfEvents(ref kolvo_variant, ref fake_text, ref galka_stuk);
			}
			else if (PlayerPrefs.GetInt("language") == 0)
			{
				if (GlobalScript.inst.gameState.number_event == 1)
				{
					kolvo_variant = 3;
					fake_text[0] = " 不 要 介 入 ， 静 待 结 果";
					if (GlobalScript.inst.gameState.data[1] > 500)
					{
						fake_text[1] = " 推 动 公 务 员 投 票";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 党 绝 不 容 许 这 种 无 耻 贿 选";
					}
					if (GlobalScript.inst.gameState.data[9] >= 50)
					{
						fake_text[2] = " 伪 造 大 选 结 果";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 情 报 部 门 实 力 不 足";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 3)
				{
					kolvo_variant = 3;
					fake_text[0] = " 按 照 伟 大 领 袖 的 既 定 方 针 办 ， 并 为 主 席 修 建 一 座 纪 念 碑";
					fake_text[1] = " 将 毛 主 席 安 葬 在 天 安 门 广 场 的 待 建 纪 念 堂 内 ";
					fake_text[2] = " 让 治 丧 委 员 会 决 定";
				}
				else if (GlobalScript.inst.gameState.number_event == 4)
				{
					kolvo_variant = 4;
					fake_text[0] = " 在 大 会 上 开 始 辩 论";
					if (GlobalScript.inst.gameState.data[9] >= 100)
					{
						fake_text[1] = " 逮 捕 那 些 野 心 家 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 特 勤 部 门 不 会 支 持 我 们";
					}
					if (GlobalScript.inst.gameState.data[22] >= 100)
					{
						fake_text[2] = " 召 集 忠 诚 的 军 官 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 军 方 不 会 支 持 我 们";
					}
					if (GlobalScript.inst.gameState.data[3] >= 700)
					{
						fake_text[3] = " 敬 告 人 民 群 众 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 人 民 已 经 受 够 了 大 鸣 大 放 ， 你 想 复 辟 文 革 余 毒 ？";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 5)
				{
					kolvo_variant = 5;
					fake_text[0] = " 向 人 民 群 众 喊 话 ， 安 抚 他 们";
					if (GlobalScript.inst.gameState.data[15] != 9 || GlobalScript.inst.gameState.data[17] != 19)
					{
						fake_text[1] = " 同 意 民 主 化";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 已 经 不 能 再 进 一 步 地 民 主 化 了";
					}
					if (GlobalScript.inst.gameState.data[22] >= 100)
					{
						fake_text[2] = " 驱 散 抗 议 者";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 军 方 不 会 支 持 我 们";
					}
					if (GlobalScript.inst.gameState.data[3] > 500)
					{
						fake_text[3] = " 向 忠 诚 的 人 民 寻 求 帮 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 人 民 已 经 受 够 了 大 鸣 大 放 ， 你 想 复 辟 文 革 余 毒 ？";
					}
					if (GlobalScript.inst.gameState.data[9] >= 150)
					{
						fake_text[4] = " 利 用 特 勤 ， 从 内 部 分 化 瓦 解 抗 议";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 6)
				{
					kolvo_variant = 4;
					fake_text[0] = " 为 社 会 项 目 紧 急 拨 款";
					if ((GlobalScript.inst.gameState.empires[0].relations >= 500 && !GlobalScript.inst.gameState.allcountries[1].isSEV) || (GlobalScript.inst.gameState.empires[1].relations >= 500 && !GlobalScript.inst.gameState.allcountries[51].Torg && !GlobalScript.inst.gameState.allcountries[1].econ))
					{
						fake_text[1] = " 请 求 外 国 的 人 道 主 义 救 援";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 无 法 寻 求 帮 助";
					}
					if (GlobalScript.inst.gameState.data[16] >= 13)
					{
						fake_text[2] = " 软 硬 兼 施 地 号 召 企 业 解 决 社 会 问 题";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 能 号 召 企 业 ， 因 为 我 们 根 本 没 有 企 业";
					}
					if (GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text[3] = " 牺 牲 党 和 官 员 的 利 益 ， 安 排 慈 善 活 动";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 白 花 花 的 银 子 就 这 样 花 出 去 ？ 党 绝 不 允 许 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 7)
				{
					kolvo_variant = 4;
					if (GlobalScript.inst.gameState.data[51] != 30 || GlobalScript.inst.gameState.data[6] <= 950)
					{
						fake_text[0] = "  我 们 出 资 缓 和 关 系";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 绝 不 投 降 ！";
					}
					if (GlobalScript.inst.gameState.influencePRC >= 50)
					{
						fake_text[1] = " 放 弃 一 部 分 外 交 政 策 立 场 来 表 达 善 意";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 的 影 响 力 太 弱 了 ， 所 以 我 们 限 无 可 限";
					}
					if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 向 帝 国 主 义 者 发 射 核 武 器 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 没 人 想 要 一 场 核 战 争";
					}
					fake_text[3] = " 一 点 都 不 在 乎";
				}
				else if (GlobalScript.inst.gameState.number_event == 8)
				{
					kolvo_variant = 4;
					if (GlobalScript.inst.gameState.data[51] != 30 || GlobalScript.inst.gameState.data[6] <= 950)
					{
						fake_text[0] = "  我 们 出 资 缓 和 关 系";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 绝 不 投 降 ！";
					}
					if (GlobalScript.inst.gameState.influencePRC >= 50)
					{
						fake_text[1] = " 放 弃 一 部 分 外 交 政 策 立 场 来 表 达 善 意";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 的 影 响 力 太 弱 了 ， 所 以 我 们 限 无 可 限";
					}
					if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 向 修 正 主 义 者 发 射 核 武 器 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 没 人 想 要 一 场 核 战 争";
					}
					fake_text[3] = " 一 点 都 不 在 乎";
				}
				else if (GlobalScript.inst.gameState.number_event == 9)
				{
					kolvo_variant = 3;
					fake_text[0] = " 我 们 管 不 着 啊";
					if (GlobalScript.inst.gameState.data[18] < 23)
					{
						fake_text[1] = " 给 予 他 们 更 多 自 治 权";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 不 能 给 予 更 多 的 自 治 权";
					}
					if (GlobalScript.inst.gameState.data[56] != 4 || GlobalScript.inst.gameState.data[22] >= 100)
					{
						fake_text[2] = " 派 部 队 去 恢 复 秩 序";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 只 用 军 队 镇 压 他 们 是 行 不 通 的";
					}
					if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 40 || GlobalScript.inst.gameState.data[36] >= 40 || GlobalScript.inst.gameState.data[9] >= 50)
					{
						fake_text[3] = " 顺 水 推 舟 ， 举 行 主 权 公 投 ， 但 暗 中 使 绊 子";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 既 没 有 造 假 的 手 段 ， 也 没 有 造 假 的 实 力";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 10)
				{
					kolvo_variant = 3;
					fake_text[0] = " 我 们 管 不 着 啊";
					if (GlobalScript.inst.gameState.data[18] < 23)
					{
						fake_text[1] = " 给 予 他 们 更 多 自 治 权";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 不 能 给 予 更 多 的 自 治 权";
					}
					if (GlobalScript.inst.gameState.data[56] != 4 || GlobalScript.inst.gameState.data[22] >= 100)
					{
						fake_text[2] = " 派 部 队 去 恢 复 秩 序";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 只 用 军 队 镇 压 他 们 是 行 不 通 的";
					}
					if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 20 || GlobalScript.inst.gameState.data[36] >= 20 || GlobalScript.inst.gameState.data[9] >= 40)
					{
						fake_text[3] = " 顺 水 推 舟 ， 举 行 主 权 公 投 ， 但 暗 中 使 绊 子";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 既 没 有 造 假 的 手 段 ， 也 没 有 造 假 的 实 力";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 11)
				{
					kolvo_variant = 4;
					fake_text[0] = " 紧 急 拨 款 用 于 发 展";
					if (GlobalScript.inst.gameState.empires[0].relations >= 60 && (GlobalScript.inst.gameState.data[16] >= 13 || GlobalScript.inst.gameState.SEZ))
					{
						fake_text[1] = " 吸 引 外 国 投 资";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 投 资 者 嫌 弃 我 们";
					}
					if (GlobalScript.inst.gameState.empires[1].relations >= 70 || GlobalScript.inst.gameState.relres)
					{
						fake_text[2] = " 请 求 苏 联 的 帮 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 需 要 修 正 主 义 者 的 施 舍 ！";
					}
					if (GlobalScript.inst.gameState.data[13] >= 500)
					{
						fake_text[3] = " 以 牺 牲 农 业 为 代 价 促 进 发 展";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 农 业 的 处 境 也 好 不 到 哪 里 去";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 12)
				{
					kolvo_variant = 4;
					fake_text[0] = " 紧 急 拨 款 用 于 发 展";
					if (GlobalScript.inst.gameState.empires[0].relations >= 60 && (GlobalScript.inst.gameState.data[16] >= 13 || GlobalScript.inst.gameState.SEZ))
					{
						fake_text[1] = " 吸 引 外 国 投 资";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 投 资 者 嫌 弃 我 们";
					}
					if (GlobalScript.inst.gameState.empires[1].relations >= 70 || GlobalScript.inst.gameState.relres)
					{
						fake_text[2] = " 请 求 苏 联 的 帮 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 需 要 修 正 主 义 者 的 施 舍 ！";
					}
					if (GlobalScript.inst.gameState.data[12] >= 500)
					{
						fake_text[3] = " 以 牺 牲 工 业 为 代 价 促 进 发 展";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 工 业 的 处 境 也 好 不 到 哪 里 去";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 13)
				{
					kolvo_variant = 4;
					fake_text[0] = " 紧 急 拨 款 用 于 发 展";
					if (GlobalScript.inst.gameState.empires[0].relations >= 60 && (GlobalScript.inst.gameState.data[16] >= 13 || GlobalScript.inst.gameState.SEZ))
					{
						fake_text[1] = " 吸 引 外 国 投 资";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 投 资 者 嫌 弃 我 们";
					}
					if (GlobalScript.inst.gameState.empires[1].relations >= 70 || GlobalScript.inst.gameState.relres)
					{
						fake_text[2] = " 请 求 苏 联 的 帮 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 需 要 修 正 主 义 者 的 施 舍 ！";
					}
					if (GlobalScript.inst.gameState.data[12] >= 500 || GlobalScript.inst.gameState.data[13] >= 500)
					{
						fake_text[3] = " 以 牺 牲 农 业 与 工 业 为 代 价 促 进 发 展";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 农 业 与 工 业 的 处 境 也 好 不 到 哪 里 去";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 14)
				{
					kolvo_variant = 4;
					int num = 0;
					if (GlobalScript.inst.gameState.data[16] >= 13 && GlobalScript.inst.gameState.data[5] >= 500)
					{
						fake_text[0] = " 提 高 税 收 和 削 减 社 会 项 目";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = "";
						num++;
					}
					if (GlobalScript.inst.gameState.data[16] >= 14)
					{
						fake_text[1] = " 提 高 奢 侈 品 税 和 巨 富 税";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 国 没 有 寡 头 可 被 榨 油 水";
						num++;
					}
					if (GlobalScript.inst.gameState.data[16] <= 14 && GlobalScript.inst.gameState.data[56] != 0 && (GlobalScript.inst.gameState.data[15] > 7 || GlobalScript.inst.gameState.data[56] != 1))
					{
						fake_text[3] = " 加 快 国 有 企 业 私 有 化";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 不 能 进 一 步 推 动 私 有 化";
						num++;
					}
					if (GlobalScript.inst.gameState.empires[0].relations > 500 || (GlobalScript.inst.gameState.empires[1].relations > 500 && GlobalScript.inst.gameState.influencePRC >= 50) || num >= 3)
					{
						fake_text[2] = " 接 受 外 国 贷 款";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 没 人 愿 意 借 钱 给 我 们";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 15)
				{
					kolvo_variant = 2;
					fake_text[0] = " 我 们 无 能 为 力";
					if ((GlobalScript.inst.gameState.data[56] != 2 && GlobalScript.inst.gameState.allcountries[23].stab == 1) || (GlobalScript.inst.gameState.data[56] == 2 && GlobalScript.inst.gameState.allcountries[23].stab != 1))
					{
						fake_text[1] = " 支 持 民 主 柬 埔 寨";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 没 人 愿 意 帮 助 他 们";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 16)
				{
					kolvo_variant = 3;
					fake_text[0] = " 不 干 涉";
					if (GlobalScript.inst.gameState.data[9] >= 20 || GlobalScript.inst.gameState.allcountries[34].stab == 1)
					{
						fake_text[1] = " 支 持 泰 国 共 产 党 ， 创 建 一 个 左 派 与 民 主 人 士 的 联 盟";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 力 量 支 持 泰 国 共 产 党";
					}
					if (GlobalScript.inst.gameState.data[22] >= 20 && GlobalScript.inst.gameState.data[56] != 4)
					{
						fake_text[2] = " 让 选 举 见 鬼 去 吧 ！ 我 们 最 好 给 泰 共 送 去 更 多 武 器 以 让 他 们 进 行 游 击 战";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 无 法 给 泰 国 共 产 党 更 多 的 武 器 装 备 了";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 17)
				{
					kolvo_variant = 3;
					fake_text[0] = " 这 不 关 我 们 的 事";
					if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.data[22] >= 30 && GlobalScript.inst.gameState.data[41] == 100)
					{
						fake_text[1] = " 派 遣 武 装 的 泰 国 共 产 党 部 队 去 帮 助 示 威 者 并 煽 动 起 义";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 力 量 组 织 起 义";
					}
					fake_text[2] = " 谴 责 泰 国 的 暴 行";
				}
				else if (GlobalScript.inst.gameState.number_event == 18)
				{
					kolvo_variant = 1;
					if (GlobalScript.inst.gameState.data[82] < 8)
					{
						fake_text[0] = " 和 平 万 岁 ！";
					}
					else
					{
						fake_text[0] = " 结 果 不 得 不 看 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 20)
				{
					kolvo_variant = 3;
					fake_text[0] = " 什 么 也 别 做 。 让 江 青 与 邓 小 平 互 相 对 立";
					fake_text[1] = " 加 入 对 小 平 的 迫 害";
					fake_text[2] = " 支 持 小 平";
				}
				else if (GlobalScript.inst.gameState.number_event == 21)
				{
					kolvo_variant = 3;
					fake_text[0] = " 什 么 都 不 做";
					fake_text[1] = " 撤 回 材 料 ， 阻 止 出 版 ！";
					fake_text[2] = " 支 持 这 篇 文 章 的 论 点 并 在 媒 体 上 大 肆 宣 扬";
				}
				else if (GlobalScript.inst.gameState.number_event == 22)
				{
					kolvo_variant = 3;
					fake_text[0] = " 在 军 警 帮 助 下 驱 散 骚 乱";
					fake_text[2] = " 呼 吁 所 有 人 离 开 ， 拉 封 锁 线 直 到 他 们 走 人";
					if (GlobalScript.inst.gameState.data[88] >= 0)
					{
						fake_text[1] = " 呼 吁 所 有 人 离 开 并 驱 散 其 他 人";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 人 民 不 想 离 去 ！";
					}
					if (GlobalScript.inst.gameState.data[88] >= 2)
					{
						fake_text[2] = " 呼 吁 所 有 人 离 开 ， 拉 封 锁 线 直 到 他 们 走 人";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 人 民 不 想 离 去 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 23)
				{
					kolvo_variant = 4;
					fake_text[0] = "从 预 算 中 拨 款 支 持 重 建 （ 需 要3 百 万 预 算 ）";
					if (GlobalScript.inst.gameState.empires[0].relations >= 600 || GlobalScript.inst.gameState.empires[1].relations >= 600)
					{
						fake_text[1] = " 请 求 外 国 的 人 道 主 义 救 援";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 外 国 人 不 会 给 我 们 帮 助";
					}
					fake_text[2] = " 分 配 资 金 支 持 重 建 并 开 发 防 震 系 统 （ 需 要5 百 万 预 算 ）";
					fake_text[3] = " 让 省 政 府 自 行 解 决";
				}
				else if (GlobalScript.inst.gameState.number_event == 24)
				{
					kolvo_variant = 4;
					fake_text[0] = " 我 们 将 尽 快 结 束 文 革 ， 以 毛 主 席 的 遗 志 为 准 绳 前 进 ！";
					if (GlobalScript.inst.gameState.data[84] == 3)
					{
						fake_text[1] = " 坚 定 的 支 持 毛 主 席 的 决 定 ， 不 偏 不 倚 走 无 产 阶 级 专 政 下 继 续 革 命 路 线 ， 反 对 修 正 主 义 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 文 革 已 经 得 罪 了 所 有 人 啦";
					}
					if (GlobalScript.inst.gameState.data[84] != 3)
					{
						fake_text[2] = " 赶 紧 结 束 文 革 吧 ， 经 济 还 得 再 折 腾 折 腾 … …";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = "";
					}
					if (GlobalScript.inst.gameState.data[84] != 3)
					{
						fake_text[3] = " 赶 紧 结 束 文 革 ， 我 们 要 准 备 大 的 历 史 转 折 并 进 入 国 际 市 场 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = "";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 25)
				{
					kolvo_variant = 4;
					fake_text[0] = " 一 个 也 别 想 跑 ！";
					fake_text[1] = " 抓 捕 江 青 和 王 洪 文 并 和 其 他 左 派 达 成 妥 协";
					fake_text[2] = " 妥 协 ， 争 取 极 左 派 的 支 持";
					fake_text[3] = " 不 要 干 预 党 内 路 线 斗 争";
				}
				else if (GlobalScript.inst.gameState.number_event == 26)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 70)
					{
						fake_text[0] = " 一 个 也 别 想 跑 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 你 无 力 改 变 现 状";
					}
					if (GlobalScript.inst.gameState.data[9] >= 50)
					{
						fake_text[1] = " 只 逮 捕 王 洪 文 和 江 青";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 你 无 力 改 变 现 状";
					}
					fake_text[2] = " 放 弃 挣 扎 ， 放 手 权 力";
				}
				else if (GlobalScript.inst.gameState.number_event == 27)
				{
					kolvo_variant = 3;
					fake_text[0] = " 同 意 交 还 港 澳 ， 并 实 施 高 度 自 治";
					fake_text[1] = " 同 意 交 还 港 澳 ， 维 持 适 当 自 治";
					fake_text[2] = " 要 求 完 全 交 还 港 澳 ， 只 保 留 外 国 人 的 财 产 权";
				}
				else if (GlobalScript.inst.gameState.number_event == 28)
				{
					kolvo_variant = 3;
					fake_text[0] = " 不 要 干 预 ， 苏 哈 托 注 定 要 失 败";
					if (GlobalScript.inst.gameState.data[9] >= 30)
					{
						fake_text[1] = " 支 持 温 和 左 翼 反 对 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 力 量 支 持 左 派";
					}
					if (GlobalScript.inst.gameState.data[9] >= 50)
					{
						fake_text[2] = " 帮 助 重 组 共 产 主 义 地 下 党";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 共 产 主 义 运 动 时 不 再 来 了 … …";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 29)
				{
					kolvo_variant = 4;
					fake_text[0] = " 要 求 有 限 政 治 自 由 化";
					fake_text[1] = " 要 求 高 度 的 政 治 经 济 改 革";
					if (GlobalScript.inst.gameState.data[16] >= 13)
					{
						fake_text[2] = " 要 求 为 中 国 公 司 开 放 经 济 特 区";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 会 也 不 能 以 帝 国 主 义 的 方 式 行 事";
					}
					fake_text[3] = " 要 求 最 大 规 模 的 民 主 化";
				}
				else if (GlobalScript.inst.gameState.number_event == 30)
				{
					kolvo_variant = 3;
					fake_text[0] = " 提 出 在 巴 勒 斯 坦 建 立 阿 拉 伯 国";
					fake_text[1] = " 提 出 在 进 一 步 解 决 危 机 前 建 立 阿 拉 伯 人 自 治 区";
					fake_text[2] = " 建 议 建 立 阿 拉 伯 人 与 犹 太 人 的 联 合 国 家";
				}
				else if (GlobalScript.inst.gameState.number_event == 31)
				{
					kolvo_variant = 3;
					fake_text[0] = " 不 要 干 预 民 主 化 进 程";
					if (GlobalScript.inst.gameState.data[9] >= 40)
					{
						fake_text[1] = " 帮 助 金 大 中 建 立 反 对 派 联 盟";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 无 法 帮 助 他 们";
					}
					if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.influencePRC >= 200 && GlobalScript.inst.gameState.data[83] != 2 && GlobalScript.inst.gameState.data[83] != 1)
					{
						fake_text[2] = " 帮 助 金 大 中 并 施 压 朝 鲜 推 进 统 一";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 没 那 能 力 支 持";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 32)
				{
					kolvo_variant = 2;
					fake_text[0] = " 静 观 其 变";
					if (GlobalScript.inst.gameState.data[9] >= 40)
					{
						fake_text[1] = " 利 用 有 利 局 势 达 成 我 们 的 目 的";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 足 够 的 力 量";
					}
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = " 支 持 反 苏 言 论 来 打 压 他 们 ？ 认 真 的 吗 ？";
				}
				else if (GlobalScript.inst.gameState.number_event == 33)
				{
					kolvo_variant = 3;
					fake_text[0] = " 保 持 距 离";
					if (GlobalScript.inst.gameState.data[9] >= 60)
					{
						fake_text[1] = " 帮 助 布 托";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 不 能 帮 助";
					}
					fake_text[2] = " 放 任 事 态 发 展 并 和 新 政 府 建 立 外 交 关 系";
				}
				else if (GlobalScript.inst.gameState.number_event == 34)
				{
					kolvo_variant = 4;
					fake_text[0] = " 小 心 地 打 击 改 革 派";
					fake_text[1] = " 他 们 爱 嘛 嘛 ， 只 要 我 们 的 人 上 来 就 行";
					fake_text[2] = " 狠 打 改 革 派 ， 为 温 和 派 和 保 守 派 开 路";
					if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
					{
						fake_text[3] = " 我 们 要 坚 定 的 与 改 革 派 站 在 一 起 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 你 不 能 和 修 正 主 义 者 谈 判 ！";
					}
					fake_text[4] = " 不 要 打 破 脆 弱 的 党 内 平 衡";
				}
				else if (GlobalScript.inst.gameState.number_event == 35)
				{
					kolvo_variant = 4;
					fake_text[0] = " 什 么 也 不 做 ， 让 步 够 多 了";
					fake_text[1] = " 小 幅 的 自 由 化";
					fake_text[2] = " 放 松 控 制 并 继 续 打 压 传 统";
					if (GlobalScript.inst.gameState.data[56] != 0)
					{
						fake_text[3] = " 放 松 控 制 ， 只 保 留 对 宗 教 的 监 视";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 不 能 如 此 的 自 由 化 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 36)
				{
					kolvo_variant = 3;
					fake_text[0] = " 不 ， 它 不 值 得";
					fake_text[1] = " 谴 责 复 兴 社 会 党 的 领 导 人";
					if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.influencePRC >= 50)
					{
						fake_text[2] = " 在 特 工 小 组 和 政 治 压 力 的 帮 助 下 ， 逼 迫 各 方 对 话";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 的 力 量 和 影 响 力 并 不 足 够";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 37)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.allcountries[30].stab == 1)
					{
						fake_text[0] = " 用 一 切 手 段 去 支 持 演 讲 并 煽 动 推 翻 萨 达 特 政 权";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 对 埃 及 内 政 的 干 涉 太 激 进 了 ！";
					}
					if (GlobalScript.inst.gameState.data[9] >= 20 && GlobalScript.inst.gameState.data[56] <= 2)
					{
						fake_text[1] = " 帮 助 利 比 亚 和 叙 利 亚 推 翻 萨 达 特";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 真 的 需 要 北 非 吗 ？";
					}
					fake_text[2] = " 埃 及 内 政 并 不 值 得 我 们 关 心";
				}
				else if (GlobalScript.inst.gameState.number_event == 38)
				{
					kolvo_variant = 3;
					int num2 = 0;
					if (GlobalScript.inst.gameState.data[87] != 4)
					{
						fake_text[1] = "  恢 复 中 央 计 划 经 济 体 系 （ 需 要1 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 党 会 在 你 的 领 导 下 走 向 改 革 ， 而 不 是 重 蹈 覆 辙 ！";
						num2++;
					}
					if (GlobalScript.inst.gameState.data[87] != 2 && GlobalScript.inst.gameState.data[87] != 1 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 为 了 社 会 主 义 现 代 化 ， 让 我 们 准 备 改 革 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 打 倒 修 正 主 义 ！";
						num2++;
					}
					if (GlobalScript.inst.gameState.data[87] != 4 || num2 >= 2)
					{
						fake_text[0] = " 我 们 需 要 维 持 并 深 化 分 权 计 划 经 济 体 系 ";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 旧 制 度 已 经 过 时 了 ！";
						num2++;
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 39)
				{
					kolvo_variant = 3;
					fake_text[0] = string.Concat(new string[4]
					{
						GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
						" ",
						GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
						" 主 席 同 志 将 亲 自 领 导 我 们 走 保 守 的 毛 派 路 线 ！ 我 们 的 路 线 是 正 确 的 ！"
					});
					fake_text[1] = " 我 们 可 以 信 任 邓 小 平 同 志 和 他 务 实 的 改 革 派 ， 他 们 对 此 会 客 观 评 价 的 。";
					if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 彭 真 同 志 和 赵 紫 阳 同 志 会 揭 露 一 切 冤 假 错 案 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 彭 真 ？ 赵 紫 阳 ？ 他 们 可 是 被 毛 主 席 开 除 出 党 的 自 由 派 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 40)
				{
					kolvo_variant = 5;
					if (GlobalScript.inst.gameState.data[56] <= 1)
					{
						fake_text[0] = " 让 他 接 着 蹲 监 狱 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 不 能 继 续 把 他 关 在 监 狱 里 了 ！";
					}
					if (GlobalScript.inst.gameState.data[56] <= 2)
					{
						fake_text[1] = " 以 放 弃 宗 教 信 条 为 条 件 放 出 来";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 对 他 施 压 太 重 了 ！";
					}
					if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 4)
					{
						fake_text[2] = " 释 放 他 ， 让 他 回 拉 萨 ， 但 要 在 国 安 部 的 监 督 下 （ 需 要4 单 位 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 或 使 他 成 为 阶 下 囚 ， 或 给 他 自 由";
					}
					if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[3] = " 释 放 这 位 政 治 犯 和 给 他 平 反 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 平 反 ？ ！ 毛 主 席 亲 自 谴 责 过 他 ！";
					}
					if (GlobalScript.inst.gameState.data[9] >= 70 && GlobalScript.inst.gameState.data[56] != 4)
					{
						fake_text[4] = " 在 心 脏 病 发 作 的 掩 盖 下 清 除 他 ， 强 迫 选 举 诺 布 成 为 新 的 班 禅 喇 嘛 。";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = " 班 禅 喇 嘛 应 该 由 僧 侣 自 己 选 择 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 41)
				{
					kolvo_variant = 3;
					fake_text[0] = " 保 持 距 离";
					if (GlobalScript.inst.gameState.data[9] >= 50)
					{
						fake_text[1] = " 支 持 反 对 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 足 够 的 力 量";
					}
					if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.data[56] != 0)
					{
						fake_text[2] = " 支 持 英 迪 拉 · 甘 地";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 支 持 甘 地 ？ 甚 至 可 能 把 西 藏 领 土 给 她 ？";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 42)
				{
					kolvo_variant = 4;
					fake_text[0] = " 不 干 涉";
					if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.data[56] <= 1)
					{
						fake_text[1] = " 旧 的 不 去 ， 新 的 不 来 ， 滚 蛋 吧 沙 阿 ！";
					}
					else if (GlobalScript.inst.gameState.data[9] < 50)
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 爱 莫 能 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 美 国 人 会 怎 么 想 ？ 他 们 会 勃 然 大 怒 的 ！";
					}
					if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 我 们 应 当 支 持 君 主 派 ， 说 不 定 将 来 会 有 用 呢 ?";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 君 主 专 政 和 法 西 斯 到 底 有 什 么 差 别 ？";
					}
					if (GlobalScript.inst.gameState.data[9] >= 50)
					{
						fake_text[3] = " 支 持 民 主 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[3] = " 我 们 没 有 余 力";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 43)
				{
					kolvo_variant = 2;
					fake_text[0] = " 不 干 涉";
					if (GlobalScript.inst.gameState.data[9] >= 30 && GlobalScript.inst.gameState.allcountries[23].Gosstroy == 1)
					{
						fake_text[1] = " 尽 全 力 阻 止 整 个 进 程";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 管 不 着 啊";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 44)
				{
					kolvo_variant = 3;
					fake_text[0] = " 同 意 开 始 改 革 并 交 权 给 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2];
					if (GlobalScript.inst.gameState.data[9] >= 150)
					{
						fake_text[1] = " 延 期 会 议 ， 以 使 国 安 部 在 休 会 期 间 强 行 逮 捕 一 切 改 革 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 无 力 也 下 不 去 手 做 这 样 的 事";
					}
					if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
					{
						fake_text[2] = " 同 意 他 们 的 要 求 以 保 留 权 力";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 你 就 是 让 步 他 们 也 不 会 放 过 你 的";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 45)
				{
					kolvo_variant = 1;
					fake_text[0] = " 向 社 会 主 义 市 场 经 济 大 步 前 进 ！";
				}
				else if (GlobalScript.inst.gameState.number_event == 46)
				{
					kolvo_variant = 4;
					fake_text[0] = " 欧 洲 太 过 遥 远 ， 亚 洲 对 我 们 更 为 重 要";
					if (GlobalScript.inst.gameState.data[9] >= 80)
					{
						fake_text[1] = " 对 比 斯 库 · 贝 洛 和 他 的 人 手 提 供 来 自 我 们 特 勤 的 支 持 和 帮 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 足 够 的 力 量";
					}
					if (GlobalScript.inst.gameState.data[9] >= 30 && GlobalScript.inst.gameState.data[22] >= 10)
					{
						fake_text[2] = " 帮 助 组 织 亲 中 起 义";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 新 的 在 匈 牙 利 的 起 义 ？ 想 想1956 ！";
					}
					if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[3] = " 我 们 做 不 了 什 么 ， 除 了 给 比 斯 库 避 难 ， 让 他 免 受 修 正 主 义 者 的 怒 火";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 欧 洲 太 过 遥 远 ， 亚 洲 对 我 们 更 为 重 要";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 47)
				{
					kolvo_variant = 3;
					fake_text[0] = " 让 国 安 部 和 中 共 人 力 资 源 部 长 解 决 这 些 问 题 。";
					fake_text[1] = " 加 入 与 改 革 派 的 争 论 并 否 定 他 们";
					fake_text[2] = " 我 们 的 媒 体 会 处 理 这 种 低 廉 的 宣 传";
				}
				else if (GlobalScript.inst.gameState.number_event == 63)
				{
					kolvo_variant = 4;
					fake_text[0] = " 不 干 涉 阿 富 汗 事 务";
					if (GlobalScript.inst.gameState.data[9] >= 30)
					{
						fake_text[1] = " 支 持 阿 富 汗 民 主 共 和 国 中 忠 于 我 们 的 反 对 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 帮 不 着 他 们";
					}
					if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 建 立 关 系 并 支 持 人 民 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 他 们 将 不 会 合 作";
					}
					if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[3] = " 建 立 关 系 并 支 持 旗 帜 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 他 们 将 不 会 合 作";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 48)
				{
					kolvo_variant = 3;
					fake_text[0] = " 最 好 还 是 不 要 介 入";
					fake_text[1] = " 与 阿 富 汗 民 主 共 和 国 秘 密 建 立 友 好 关 系 （ 需 要2 百 万 元 预 算 ）";
					if (GlobalScript.inst.gameState.relres)
					{
						fake_text[2] = " 我 们 不 信 任 他 … 最 好 秘 密 同 意 苏 联 撤 换 他 ， 也 许 我 们 会 从 新 政 府 那 里 得 到 一 些 东 西";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 不 与 苏 联 勾 结 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 49)
				{
					kolvo_variant = 2;
					fake_text[0] = " 这 是 苏 联 的 事 务";
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[9] >= 70)
					{
						fake_text[1] = " 警 告 阿 明 和 向 他 发 送 帮 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 没 有 人 会 让 我 们 介 入";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 50)
				{
					kolvo_variant = 4;
					fake_text[0] = " 谁 都 不 管 ， 这 可 不 关 我 们 的 事";
					if (GlobalScript.inst.gameState.relres)
					{
						fake_text[1] = " 援 助 阿 富 汗 民 主 共 和 国 ， 交 换 条 件 是 将 毛 派 政 党 纳 入 与 人 民 民 主 党 的 联 盟";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 苏 联 不 允 许 我 们 进 行 如 此 深 入 的 介 入";
					}
					fake_text[2] = " 援 助 阿 富 汗 民 主 共 和 国";
					fake_text[3] = " 援 助 毛 主 义 起 义 者";
					fake_text[4] = " 向 武 装 反 对 派 出 售 枪 支 ， 美 国 人 愿 意 为 之 付 钱";
				}
				else if (GlobalScript.inst.gameState.number_event == 51)
				{
					kolvo_variant = 3;
					fake_text[0] = " 不 回 应";
					fake_text[1] = " 谴 责 军 队 介 入";
					fake_text[2] = " 支 持 军 队 介 入";
				}
				else if (GlobalScript.inst.gameState.number_event == 53)
				{
					kolvo_variant = 4;
					fake_text[0] = " 维 持 大 寨 模 式 的 普 及 ， 但 不 额 外 拨 款";
					fake_text[1] = " 引 入 家 庭 联 产 承 包 合 同";
					if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 引 进 私 营 农 场";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 会 把 农 业 交 给 私 人 投 机 者 ！";
					}
					if (GlobalScript.inst.gameState.data[89] == 0)
					{
						fake_text[3] = " 增 加 资 金 投 入 ， 加 速 大 寨 模 式 的 普 及 和 农 业 机 械 化 工 业 化";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 需 要 把 钱 浪 费 在 这 种 地 方 吗 ？";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 54)
				{
					kolvo_variant = 3;
					fake_text[0] = " 推 迟 这 事";
					fake_text[1] = " 开 放 经 济 特 区";
					if (GlobalScript.inst.gameState.data[56] != 2)
					{
						fake_text[2] = " 开 放 经 济 特 区 并 对 外 资 开 放 部 分 企 业";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 毛 主 席 的 棺 材 板 压 不 住 了 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 55)
				{
					kolvo_variant = 3;
					fake_text[0] = " 我 们 不 关 心 此 事";
					fake_text[1] = " 向 奈 温 给 出3 百 万 援 助 建 立 友 好 关 系 （ 需 要3 百 万 元 预 算 ）";
					if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.allcountries[33].stab == 1)
					{
						fake_text[2] = " 帮 助 共 产 主 义 者 组 织 政 变";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 帮 不 上 忙";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 56)
				{
					kolvo_variant = 2;
					fake_text[0] = " 我 们 不 能 激 化 局 势";
					if (!GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.war == 0)
					{
						fake_text[1] = " 准 备 战 争 。 让 我 们 给 越 南 人 点 教 训 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 一 切 按 计 划 进 行";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 57)
				{
					kolvo_variant = 2;
					fake_text[0] = " 我 们 不 关 心 此 事";
					if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.allcountries[44].stab == 1)
					{
						fake_text[1] = " 向 日 共 提 供 财 政 和 特 工 援 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 日 共 不 会 听 我 们 的 话 的 。";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 58)
				{
					kolvo_variant = 1;
					fake_text[0] = " — — 说 来 听 听 吧 ！";
				}
				else if (GlobalScript.inst.gameState.number_event == 59)
				{
					kolvo_variant = 4;
					fake_text[0] = " 无 视 该 建 议";
					if (!GlobalScript.inst.gameState.allcountries[15].cw && !GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[1] = " 建 立 经 济 同 盟 （ 需 要15 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 还 没 准 备 好 （ 需 要15 百 万 元 预 算 ）";
					}
					if (GlobalScript.inst.gameState.relres && !GlobalScript.inst.gameState.allcountries[15].cw && GlobalScript.inst.gameState.data[56] <= 1 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[51].Torg)
					{
						fake_text[2] = " 加 入 经 互 会";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 和 修 正 主 义 者 没 有 谈 判 ！";
					}
					if (GlobalScript.inst.gameState.war <= 0 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].isOVD && !GlobalScript.inst.gameState.allcountries[1].econ && !GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.allcountries[1].Vyshi && !GlobalScript.inst.gameState.allcountries[15].cw)
					{
						fake_text[3] = " 加 入 不 结 盟 运 动";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 他 们 不 喜 欢 你";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 60)
				{
					kolvo_variant = 2;
					if (GlobalScript.inst.gameState.data[22] >= 300 && GlobalScript.inst.gameState.data[9] >= 100 && !GlobalScript.inst.gameState.allcountries[1].isOVD)
					{
						fake_text[0] = " 建 立 军 事 联 盟 （ 需 要5 百 万 元 预 算 ，30 军 事 实 力 ，10 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 还 没 有 准 备 好 （ 需 要5 百 万 元 预 算 ，30 军 事 实 力 ，10 特 工 网 络 ）";
					}
					fake_text[1] = " 什 么 都 不 做";
				}
				else if (GlobalScript.inst.gameState.number_event == 61)
				{
					kolvo_variant = 3;
					fake_text[0] = " 恢 复 原 版 义 勇 军 进 行 曲 （ 需 要1 百 万 元 预 算 ）";
					if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[1] = " 批 准 《 东 方 红 》 为 国 歌";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 文 化 大 革 命 永 不 翻 案 ！";
					}
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 恢 复 改 词 版 的 《 义 勇 军 进 行 曲 》 （ 需 要1 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 多 此 一 举 ， 毫无 必 要 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 62)
				{
					kolvo_variant = 5;
					if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[0] = " 这 是 公 平 的 一 步 。 这 正 是 我 们 要 做 的 ！ （ 需 要3 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 绝 不 妥 协 ！";
					}
					fake_text[1] = " 对 一 个 少 数 民 族 来 说 ， 这 简 直 就 是 种 特 权 ！ 拒 绝";
					if (GlobalScript.inst.gameState.data[56] != 1)
					{
						fake_text[2] = " 领 土 将 被 归 还 ， 但 同 化 将 不 会 停 止";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 这 不 符 合 中 国 共 产 党 的 民 族 政 策 ！";
					}
					if (GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 3)
					{
						fake_text[3] = " 停 止 同 化 是 有 道 理 的 ， 但 我 们 不 会 归 还 领 土 。 （ 需 要1 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 这 不 符 合 中 国 共 产 党 的 民 族 政 策 ！";
					}
					if (GlobalScript.inst.gameState.data[50] != 24 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[18] < 23)
					{
						fake_text[4] = " 到 了 认 真 解 决 小 型 自 治 区 民 族 问 题 的 时 候 了 ！ 停 止 所 有 过 度 的 措 施 ！ （ 需 要6 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = " 中 国 没 有 民 族 问 题 ！ 它 在50 年 代 就 一 劳 永 逸 地 解 决 了";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 52)
				{
					kolvo_variant = 4;
					fake_text[0] = " 让 巴 基 斯 坦 自 己 处 理";
					fake_text[1] = " 向 巴 基 斯 坦 提 供 援 助 ， 帮 助 巡 逻 边 境 和 抓 捕 伊 斯 兰 主 义 者";
					if (GlobalScript.inst.gameState.ingamewars[5].ussr_place != 1 && !GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[2] = " 和 美 国 谈 判";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 不 要 帮 助 反 动 派 ！";
					}
					if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 1)
					{
						fake_text[3] = " 搞 这 些 干 嘛 ？ 不 如 在 巴 基 斯 坦 为 阿 富 汗 毛 派 起 义 者 组 织 基 地 （ 需 要5 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 不 能 帮 助 阿 富 汗 民 主 共 和 国 的 毛 派 起 义 者";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 64)
				{
					kolvo_variant = 2;
					fake_text[0] = " 阿 拉 伯 联 合 ？ 不 值 得 我 们 为 此 做 无 用 功";
					if (GlobalScript.inst.gameState.data[9] >= 50 && (!GlobalScript.inst.gameState.allcountries[30].prosov || GlobalScript.inst.gameState.relres))
					{
						fake_text[1] = " 协 助 重 建 阿 拉 伯 联 合 共 和 国 （ 需 要7 百 万 元 预 算 ，5 特 工 网 络 ）";
					}
					else if (GlobalScript.inst.gameState.data[9] < 50)
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 需 要 5 特 工 网 络 ...";
					}
					else if (GlobalScript.inst.gameState.allcountries[30].prosov && !GlobalScript.inst.gameState.relres)
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 还 未 恢 复 与 苏 联 的 关 系 ...";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 他 们 自 己 都 不 同 意 重 走 纳 赛 尔 主 义 之 路 ， 我 们 又 能 帮 到 啥 ？";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 65)
				{
					kolvo_variant = 5;
					int num3 = 0;
					if ((GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))) || GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[0] = " 体 育 运 动 无 关 政 治 ！ 我 们 将 参 加 莫 斯 科 奥 运 会 并 派 出 最 好 的 运 动 员 ！ （ 需 要4 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						num3++;
						fake_text[0] = " 我 们 不 能 忽 视 西 方 的 意 见";
					}
					if ((GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))) || (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[56] != 0))
					{
						fake_text[1] = " 我 们 不 宣 布 抵 制 ， 但 忽 略 这 两 场 运 动 会 …";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						num3++;
						fake_text[1] = " 我 们 不 能 同 时 忽 视 这 两 场 运 动 会 ！";
					}
					if (GlobalScript.inst.gameState.data[89] > 0 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[3] = " 我 们 宣 布 抵 制 苏 联 运 动 会 ， 并 将 参 赛 队 伍 队 派 往 美 国 （ 需 要3 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						num3++;
						fake_text[3] = " 去 美 国 ？ ！ 你 是 认 真 的 吗 ？ …";
					}
					if (GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[4] = " 复 兴 新 兴 力 量 运 动 会 （GANEFO ） ， 向 发 展 中 国 家 发 出 邀 请 （ 需 要20 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						num3++;
						fake_text[4] = " 毛 派 的 社 会 实 验 已 经 够 多 了 ！";
					}
					if ((((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[56] != 0) || num3 >= 4)
					{
						fake_text[2] = " 我 们 宣 布 抵 制 ， 但 让 我 们 的 运 动 员 举 着 奥 运 会 旗 去 莫 斯 科 （ 需 要4 百 万 元 预 算 ） 。";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 这 不 是 我 们 的 政 策 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 66)
				{
					kolvo_variant = 4;
					fake_text[0] = " 发 文 表 示 悼 念 ， 但 仅 此 而 已";
					if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7) || GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[1] = string.Concat(new string[4]
						{
							GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
							" ",
							GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
							" 同 志 将 亲 率 我 国 政 府 代 表 团 飞 往 贝 尔 格 莱 德"
						});
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = string.Concat(new string[4]
						{
							GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
							" ",
							GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
							" 同 志 不 能 亲 自 飞 去 参 加 修 正 主 义 者 铁 托 的 葬 礼 ！"
						});
					}
					if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 派 出 国 务 院 秘 书 长 姬 鹏 飞 率 领 的 代 表 团 。";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 不 许 派 代 表 团 去 贝 尔 格 莱 德 ！";
					}
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[3] = " 铁 托 死 了 ？ 好 吧 ， 就 这 样 吧 ， 谁 在 乎 呢 ？";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 不 能 不 回 应 他 的 死 亡 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 67)
				{
					kolvo_variant = 5;
					fake_text[0] = " 波 兰 的 事 务 与 中 国 无 关 。 他 们 自 己 做 的 事 情 自 己 解 决 ！";
					if (GlobalScript.inst.gameState.relres)
					{
						fake_text[1] = " 支 持 由 沃 伊 切 赫 · 雅 鲁 泽 尔 斯 基 将 军 领 导 的 亲 苏 军 方 （ 需 要5 特 工 ， 需 要20 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 还 未 恢 复 《 中 苏 友 好 同 盟 互 助 条 约 》 ...";
					}
					if (GlobalScript.inst.gameState.allcountries[20].proprc && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 我 们 将 组 建 囊 括 米 雅 尔 的 波 兰 共 产 党 、 西 瓦 克 的 波 统 共 党 “ 强 硬 派 ” 、 “ 圣 像 牌 ” 组 织 和 “ 格 伦 瓦 尔 德 ” 社 团 的 大 联 盟 。 让 他 们 接 管 波 兰 ！ （ 需 要15 特 工 网 络 ， 需 要30 百 万 元 预 算 ） 。";
					}
					else if (!GlobalScript.inst.gameState.allcountries[20].proprc)
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 可 米 雅 尔 已 经 离 开 了 阿 尔 巴 尼 亚 ...";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 党 内 的 改 革 派 与 自 由 派 对 他 们 没 兴 趣 ...";
					}
					if (GlobalScript.inst.gameState.empires[1].relations >= 600 && GlobalScript.inst.gameState.allcountries[1].isOVD)
					{
						fake_text[3] = " 让 我 们 向 华 约 国 家 提 出 军 事 干 预 的 建 议 （ 需 要5 特 工 网 络 ，5 军 事 实 力 ）";
					}
					else if (!GlobalScript.inst.gameState.allcountries[1].isOVD)
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 得 是 华 约 的 一 员 ...";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 与 苏 联 的 关 系 应 高 于 60...";
					}
					if (GlobalScript.inst.gameState.empires[0].relations >= 600 && GlobalScript.inst.gameState.allcountries[51].Torg)
					{
						fake_text[4] = " 与 美 国 一 起 支 持 “ 团 结 ” 工 会 （ 需 要10 百 万 元 预 算 ，20 特 工 网 络 ）";
					}
					else if (!GlobalScript.inst.gameState.allcountries[51].Torg)
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = " 我 们 得 交 好 美 国 ...";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = " 与 美 国 的 关 系 应 高 于 60...";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 68)
				{
					kolvo_variant = 2;
					fake_text[0] = " 让 他 们 自 己 处 理";
					if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.data[22] >= 80)
					{
						fake_text[1] = " 援 助 起 义 者 和 煽 动 动 乱 （ 需 要8 军 事 实 力 ，10 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 足 够 的 资 源";
						fake_text[2] = " 呼 吁 各 方 对 话";
						fake_text[3] = " 支 持 全 斗 焕 的 行 动";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 69)
				{
					kolvo_variant = 3;
					fake_text[0] = " 什 么 也 不 做 。 不 同 的 观 点 是 民 主 的 保 证";
					int num4 = 0;
					int num5 = 0;
					Politic[] politics = GlobalScript.inst.gameState.politics;
					foreach (Politic politic in politics)
					{
						if (politic.traits[0] == 1 || politic.traits[0] == 2)
						{
							num4 += politic.power;
						}
						else if (politic.traits[0] == 0)
						{
							num5 += politic.power;
						}
					}
					if (GlobalScript.inst.gameState.data[1] >= 650 && num4 > num5)
					{
						fake_text[1] = " 在 党 的 全 会 上 攻 击 保 守 派 ， 支 持 改 革 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 中 国 共 产 党 可 不 会 陪 你 玩 过 家 家";
					}
					if (GlobalScript.inst.gameState.data[1] >= 600 && num4 > num5)
					{
						fake_text[2] = " 在 党 的 全 会 上 攻 击 保 守 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 中 国 共 产 党 不 会 让 你 轻 易 的 消 灭 他 们";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 70)
				{
					kolvo_variant = 2;
					int num6 = 0;
					int num7 = 0;
					Politic[] politics = GlobalScript.inst.gameState.politics;
					foreach (Politic politic2 in politics)
					{
						if (politic2.traits[0] == 1 || politic2.traits[0] == 2)
						{
							num6 += politic2.power;
						}
						else if (politic2.traits[0] == 0)
						{
							num7 += politic2.power;
						}
					}
					fake_text[0] = " 什 么 也 不 做 。 不 同 的 观 点 是 民 主 的 保 证";
					if (GlobalScript.inst.gameState.data[1] >= 800 && num7 > num6)
					{
						fake_text[1] = " 在 党 的 全 会 上 攻 击 改 革 派 和 温 和 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 改 革 派 不 会 轻 易 的 放 弃 ！";
					}
					if (GlobalScript.inst.gameState.data[1] >= 700 && GlobalScript.inst.gameState.data[90] != 0)
					{
						fake_text[2] = " 争 取 温 和 派 的 支 持 ， 在 全 会 上 攻 击 改 革 派";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 温 和 派 不 会 支 持 我 们";
					}
					fake_text[3] = " 逮 捕 改 革 派 的 领 导 人 ， 并 发 动 一 场 运 动 反 对 他 们 的 支 持 者 。 这 是 毛 主 席 的 意 志 ！";
				}
				else if (GlobalScript.inst.gameState.number_event == 71)
				{
					kolvo_variant = 3;
					fake_text[0] = " 让 他 们 继 续 进 行 游 击 战 ， 这 对 我 们 来 说 已 经 足 够 了";
					if (GlobalScript.inst.gameState.influencePRC >= 100 && GlobalScript.inst.gameState.allcountries[19].Torg)
					{
						fake_text[1] = " 以 停 止 敌 对 行 动 换 取 纳 萨 尔 派 进 入 地 方 政 府";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 他 们 不 会 和 我 们 谈 判";
					}
					if (!GlobalScript.inst.gameState.allcountries[19].Torg && GlobalScript.inst.gameState.war == 0 && !GlobalScript.inst.gameState.allcountries[15].cw)
					{
						fake_text[2] = " 准 备 好 战 争 ， 派 遣 部 队";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 现 在 不 是 为 了 发 动 战 争 而 加 强 联 系 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 72)
				{
					kolvo_variant = 3;
					fake_text[0] = " 祝 你 好 运 ， 心 情 愉 快";
					if (GlobalScript.inst.gameState.data[91] == 1)
					{
						fake_text[1] = " 支 持 人 民 党 左 翼 （ 需 要6 特 工 网 络 ，10 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 人 民 党 不 会 听 我 们 的";
					}
					if (GlobalScript.inst.gameState.data[91] == 1)
					{
						fake_text[2] = " 支 持 人 民 党 右 翼 （ 需 要6 特 工 网 络 ，10 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 人 民 党 不 会 听 我 们 的";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 73)
				{
					kolvo_variant = 4;
					fake_text[0] = " 战 争 即 地 狱";
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = " 战 争 ， 战 争 从 未 改 变";
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = " 战 争 即 和 平";
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = " 如 果 你 想 要 和 平 ， 准 备 好 战 争";
				}
				else if (GlobalScript.inst.gameState.number_event == 74)
				{
					kolvo_variant = 5;
					if (GlobalScript.inst.gameState.data[90] == 0)
					{
						fake_text[0] = " 全 会 讨 论 并 通 过 了 这 一 版 本";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 不 会 的 。 怎 么 可 能 通 过 呢？";
					}
					if (GlobalScript.inst.gameState.data[90] == 1)
					{
						fake_text[1] = " 全 会 讨 论 并 通 过 了 这 一 版 本";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 不 会 的 。 怎 么 可 能 通 过 呢？";
					}
					if (GlobalScript.inst.gameState.data[90] == 2)
					{
						fake_text[2] = " 全 会 讨 论 并 通 过 了 这 一 版 本";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 不 会 的 。 怎 么 可 能 通 过 呢？";
					}
					fake_text[3] = " 你 在 这 里 写 的 什 么 东 西 ？ ！ 立 即 对 文 本 进 行 修 订 ！";
					if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[4] = " 在 主 席 的 要 求 下 ， “ 决 议 ” 的 问 题 被 从 议 程 中 移 除";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = " 这 个 问 题 对 中 国 共 产 党 来 说 太 重 要 了 ， 不 能 把 它 从 议 程 中 删 除";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 75)
				{
					kolvo_variant = 4;
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[0] = " 我 们 将 谴 责 空 袭 ， 并 与 侯 赛 因 扩 大 合 作 （ 需 要8 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 萨 达 姆 · 侯 赛 因 — — 一 个 独 裁 者 和 沙 文 主 义 者 。 我 们 不 需 要 支 持 他 ！";
					}
					fake_text[1] = " 谁 在 乎 ？ 让 萨 达 姆 自 己 给 自 己 擦 屁 股 …";
					if (GlobalScript.inst.gameState.data[12] >= 600 && GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 我 们 将 帮 助 伊 拉 克 恢 复 其 核 计 划 。 让 帝 国 主 义 战 栗 吧 ！ （ 需 要15 百 万 元 ，10 特 工 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 给 伊 拉 克 核 武 器 ？ ！ 你 想 发 动 第 三 次 世 界 大 战 吗 ？";
					}
					if ((GlobalScript.inst.gameState.data[56] > 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[3] = " 我 们 将 称 许 空 袭 ， 并 谴 责 侯 赛 因 的 军 国 主 义 和 沙 文 主 义";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 不 能 为 犹 太 复 国 主 义 者 的 所 作 所 为 辩 护 ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 76)
				{
					kolvo_variant = 4;
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[0] = " 我 们 会 在 外 交 上 支 持 科 索 沃 分 离 主 义 者 ， 但 仅 此 而 已";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 那 不 是 我 们 的 问 题";
					}
					if (((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.allcountries[20].proprc)
					{
						fake_text[1] = " 向 阿 尔 巴 尼 亚 提 供 援 助 ， 帮 助 其 将 科 索 沃 从 南 斯 拉 夫 分 离 出 来 （ 需 要5 特 工 网 络 ， 需 要5 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 为 什 么 要 帮 助 阿 尔 巴 尼 亚 ？";
					}
					fake_text[2] = " 不 干 涉";
					if (GlobalScript.inst.gameState.data[9] >= 100)
					{
						fake_text[3] = " 我 们 将 提 供 特 勤 和 经 济 援 助 来 帮 助 科 索 沃 分 离 主 义 者 （ 需 要10 特 工 网 络 ，10 百 万 预 算 ） 。";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 对 南 斯 拉 夫 事 务 不 感 兴 趣";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 77)
				{
					kolvo_variant = 3;
					if (((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[9] >= 80)
					{
						fake_text[0] = " 帮 助 谢 胡 组 织 一 场 政 变 （ 需 要8 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 没 有 足 够 的 资 源";
					}
					fake_text[1] = " 这 是 他 们 自 己 的 问 题";
					if (GlobalScript.inst.gameState.allcountries[20].proprc || (GlobalScript.inst.gameState.allcountries[20].econ && GlobalScript.inst.gameState.data[60] == 0))
					{
						fake_text[2] = " 我 们 支 持 霍 查";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 为 什 么 我 们 要  支 持 背 叛 我 们 的 白 眼 狼 霍 查 ？";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 78)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.data[22] >= 80 && ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 煽 动 动 乱 和 支 持 毛 派 （ 需 要10 特 工 网 络 ，8 军 事 实 力 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 这 不 值 得 我 们 为 之 努 力";
					}
					fake_text[1] = " 这 不 关 我 们 的 事 。";
					if (GlobalScript.inst.gameState.data[6] < 800 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 祝 贺 马 科 斯 获 胜 ， 并 尝 试 建 立 合 作 关 系";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 需 要 和 美 国 傀 儡 合 作";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 79)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.empires[1].relations > 500 && GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[0] = " 我 们 将 号 召 社 会 主 义 阵 营 共 同 帮 助 罗 马 尼 亚 （ 需 要10 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 社 会 主 义 阵 营 不 会 听 我 们 的";
					}
					fake_text[1] = " 让 他 自 己 还 债 ， 这 不 是 我 们 的 问 题";
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 向 罗 马 尼 亚 提 供 物 资 援 助 （ 需 要30 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 罗 马 尼 亚 不 值 得 我 们 做 这 么 多";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 80)
				{
					kolvo_variant = 3;
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[0] = " 不 提 出 “ 个 人 崇 拜 ” 的 议 题 ， 让 会 议 保 持 和 谐 。";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 是 时 候 告 诉 党 真 相 了 ！";
					}
					if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || GlobalScript.inst.gameState.data[15] > 7)
					{
						fake_text[1] = " 提 及 毛 主 席 的 “ 个 别 错 误 ” ， 为 了 防 止 未 来 再 次 出 现 这 种 事 ， 我 们 要 探 索 一 条 新 路 。";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 怎 么 能 批 评 毛 主 席 呢 ？ ！";
					}
					if ((GlobalScript.inst.gameState.data[56] > 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 我 们 将 利 用 赫 鲁 晓 夫 的 经 验 — — 他 做 到 了 ， 而 我 们 也 行 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 你 疯 了 吗 ！ 上 一 个 中 国 版 赫 鲁 晓 夫 还 尸 骨 未 寒 呢 ？ ！";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 81)
				{
					kolvo_variant = 5;
					if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7) || (GlobalScript.inst.gameState.data[56] == 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[0] = " 我 们 将 无 条 件 向 匈 牙 利 提 供 经 济 援 助 （ 需 要35 百 万 元 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 没 有 足 够 的 钱 资 助 卡 达 尔 主 义 者";
					}
					if (GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[1] = " 我 们 利 用 匈 牙 利 人 民 共 和 国 的 问 题 来 诋 毁 市 场 改 革";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 匈 牙 利 的 例 子 并 不 能 证 明 一 切 改 革 的 失 败";
					}
					if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 我 们 将 向 匈 牙 利 提 供 经 济 援 助 ， 但 交 换 条 件 是 平 反 比 斯 库 集 团 （ 需 要15 百 万 元 预 算 ，8 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 对 我 们 来 说 不 是 很 好";
					}
					if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[3] = " 我 们 将 完 全 承 担 匈 牙 利 国 债 ， 但 交 换 条 件 是 完 全 平 反 比 斯 库 集 团 （ 需 要45 百 万 元 预 算 ，10 特 工 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 对 我 们 来 说 太 激 进 了 ！";
					}
					fake_text[4] = " 无 视 它";
				}
				else if (GlobalScript.inst.gameState.number_event == 82)
				{
					kolvo_variant = 1;
					fake_text[0] = " 谁 会 赢 ？ 阿 根 廷 的 军 政 府 ， 还 是 虚 弱 而 遥 远 的 英 国 ？";
				}
				else if (GlobalScript.inst.gameState.number_event == 83)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 我 们 将 向 苏 共 中 央 泄 露 情 报 ， 败 坏 库 拉 科 夫 的 名 誉 （ 需 要5 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 这 太 危 险 了 ！";
					}
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[1] = " 我 们 将 在 我 们 的 媒 体 上 发 表 揭 露 库 拉 科 夫 的 材 料 （ 需 要2 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 不 需 要";
					}
					fake_text[2] = " 我 们 会 把 它 留 到 将 来 …";
				}
				else if (GlobalScript.inst.gameState.number_event == 84)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 80 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 交 通 事 故 怎 么 样 ？ 这 是 专 业 人 士 的 选 择 ！ （ 需 要8 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 这 太 危 险 了 ！";
					}
					fake_text[1] = " 我 们 与 白 俄 罗 斯 的 党 员 取 得 联 系 ， 并 通 过 他 们 向 苏 斯 洛 夫 传 递 马 谢 罗 夫 的 黑 料 （ 需 要5 百 万 预 算 ）";
					fake_text[2] = " 放 他 一 马";
				}
				else if (GlobalScript.inst.gameState.number_event == 85)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 一 旦 共 和 国 爆 发 骚 乱 ， 我 们 就 将 尽 全 力 绊 倒 库 纳 耶 夫 （ 需 要10 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = "It's too dangerous!";
					}
					if (GlobalScript.inst.gameState.relres && ((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[1] = " 我 们 将 先 发 制 人 ， 警 告 他 正 触 碰 苏 共 中 央 委 员 会 的 底 线 （ 需 要3 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 和 勃 列 日 涅 夫 的 关 系 还 不 足 以 让 他 知 悉 这 些";
					}
					fake_text[2] = " 我 们 不 关 心 苏 联 的 事 务";
				}
				else if (GlobalScript.inst.gameState.number_event == 86)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 我 们 将 帮 助 克 格 勃 领 导 人 利 用 他 的 肾 衰 竭 前 往 另 一 个 世 界 。 乌 克 兰 的 克 格 勃 将 处 理 这 一 项 任 务 （ 需 要 10 特 工 网 络 ， 需 要 5 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 这 太 危 险 了 ！";
					}
					if (GlobalScript.inst.gameState.relres)
					{
						fake_text[1] = " 苏 斯 洛 夫 和 谢 尔 比 茨 基 召 开 中 央 委 员 会 全 体 会 议 ， 在 我 们 信 息 的 支 持 下 攻 击 安 德 罗 波 夫 （ 需 要7 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
					}
					fake_text[2] = " 这 太 危 险 了 ！";
				}
				else if (GlobalScript.inst.gameState.number_event == 87)
				{
					kolvo_variant = 1;
					fake_text[0] = " 另 一 场 在 中 东 的 战 争 …";
				}
				else if (GlobalScript.inst.gameState.number_event == 88)
				{
					kolvo_variant = 2;
					fake_text[0] = " 我 们 祝 贺 穆 加 贝 的 胜 利 ， 并 向 他 提 供 财 政 援 助 （ 需 要5 百 万 元 预 算 ）";
					fake_text[1] = " 我 们 可 以 以 后 再 和 他 交 朋 友";
				}
				else if (GlobalScript.inst.gameState.number_event == 89)
				{
					kolvo_variant = 4;
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.empires[1].leaders[3].support > 0)
					{
						fake_text[0] = " 支 持 安 德 罗 波 夫";
					}
					else if (GlobalScript.inst.gameState.empires[1].leaders[3].support <= 0)
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = "";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
					}
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.empires[1].leaders[1].support != 0)
					{
						fake_text[1] = " 支 持 谢 尔 比 茨 基";
					}
					else if (GlobalScript.inst.gameState.empires[1].leaders[1].support == 0)
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = "";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
					}
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100)
					{
						fake_text[2] = " 支 持 契 尔 年 科";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
					}
					fake_text[3] = " 不 要 介 入 ， 静 待 结 果";
				}
				else if (GlobalScript.inst.gameState.number_event == 90)
				{
					kolvo_variant = 4;
					if (GlobalScript.inst.gameState.data[9] >= 40 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 我 们 会 对 三 合 会 开 出 他 们 无 法 拒 绝 的 条 件 的 （ 需 要4 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 只 有 国 民 党 才 会 这 么 做 ！";
					}
					if (GlobalScript.inst.gameState.data[9] >= 30 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[1] = " 我 们 可 以 与 犯 罪 辛 迪 加 们 结 成 战 略 同 盟 。 但 这 可 不 意 味 着 他 们 有 了 免 死 金 牌 （ 需 要2 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 不 与 黑 社 会 妥 协 ！!";
					}
					fake_text[2] = " 我 们 关 心 这 些 强 盗 干 什 么 ？";
					if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.data[16] <= 13 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[3] = " 现 在 是 时 候 对 我 国 南 方 省 份 的 有 组 织 犯 罪 进 行 有 力 打 击 了 ！ （ 需 要8 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 他 们 是 非 常 诚 实 合 法 的 商 人 且 支 持 改 革 开 放 。 我 们 无 权 怀 疑 他 们 。";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 91)
				{
					kolvo_variant = 3;
					fake_text[0] = " 谴 责 朝 鲜 恐 怖 主 义";
					fake_text[1] = " 谴 责 韩 国 的 挑 衅";
					fake_text[2] = " 保 持 沉 默";
				}
				else if (GlobalScript.inst.gameState.number_event == 92)
				{
					kolvo_variant = 5;
					fake_text[0] = " 投 资 工 业 升 级 （ 需 要1 百 万 预 算 ）";
					fake_text[1] = " 继 续 加 强 农 业 机 械 化 （ 需 要1 百 万 预 算 ）";
					fake_text[2] = " 投 资 提 高 服 务 质 量 （ 需 要1 百 万 预 算 ）";
					fake_text[3] = " 把 五 年 计 划 重 点 放 在 科 学 研 究 的 发 展 上 （ 需 要1 百 万 预 算 ）";
					fake_text[4] = " 集 中 力 量 到 均 衡 发 展 经 济 上 （ 需 要1 百 万 预 算 ）";
				}
				else if (GlobalScript.inst.gameState.number_event == 93)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[9] >= 40)
					{
						fake_text[0] = " 支 持 泛 希 腊 社 会 主 义 运 动";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 没 有 足 够 的 力 量";
					}
					if (GlobalScript.inst.gameState.data[9] >= 40)
					{
						fake_text[1] = " 支 持 新 民 主 党";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 足 够 的 力 量";
					}
					fake_text[2] = " 保 持 距 离";
				}
				else if (GlobalScript.inst.gameState.number_event == 94)
				{
					kolvo_variant = 4;
					fake_text[0] = " 这 是 一 场 反 革 命 动 乱 ， 叛 徒 会 为 此 负 责 的 ！ 给 我 拨 通 总 参 谋 部 的 电 话 …";
					fake_text[1] = " 让 武 警 封 锁 广 场 ， 尝 试 劝 说 抗 议 者 散 去";
					fake_text[2] = " 退 休 。 在 这 个 困 难 时 期 ， 让 党 决 定 谁 应 该 领 导 国 家";
					fake_text[3] = " 满 足 抗 议 者 的 要 求";
				}
				else if (GlobalScript.inst.gameState.number_event == 95)
				{
					kolvo_variant = 4;
					fake_text[0] = " 我 们 拒 绝 马 克 思 主 义- 毛 泽 东 主 义- 邓 小 平 主 义 ， 效 仿 日 本 共 产 党 ， 改 为 支 持 欧 洲 共 产 主 义";
					fake_text[1] = " 按 照 陈 独 秀 的 规 范 回 归 具 有 中 国 特 色 的 社 会 民 主 主 义";
					fake_text[2] = " 接 受 伟 大 的 孙 中 山 遗 赠 的 中 国 左 翼 民 族 主 义";
					fake_text[3] = " 为 什 么 我 们 必 须 接 受 一 些 街 头 恶 霸 的 要 求 ？";
				}
				else if (GlobalScript.inst.gameState.number_event == 96)
				{
					kolvo_variant = 4;
					fake_text[0] = " 我 们 正 在 筹 备 全 国 人 大 的 自 由 选 举 ， 所 以 我 们 要 尽 可 能 限 制 其 他 政 党 ， 同 时 还 必 须 满 足 人 民 的 要 求";
					fake_text[1] = " 选 举 并 没 有 让 资 产 阶 级 “ 自 由 ” 那 么 可 怕 。 不 用 理 它";
					fake_text[2] = " 选 举 并 没 有 让 宗 教 自 由 那 么 可 怕 。 不 用 管 它";
					fake_text[3] = " 如 果 我 们 想 让 人 们 爱 我 们 ， 我 们 必 须 满 足 它 的 所 有 要 求";
				}
				else if (GlobalScript.inst.gameState.number_event == 97)
				{
					kolvo_variant = 2;
					fake_text[0] = " 我 们 开 始 大 规 模 实 施 自 动 化 系 统";
					fake_text[1] = " 急 于 求 成 不 会 有 好 结 果 ， 要 循 序 渐 进 ， 不 要 想 一 蹴 而 就 。";
				}
				else if (GlobalScript.inst.gameState.number_event == 98)
				{
					if (!GlobalScript.inst.dlc[3])
					{
						kolvo_variant = 3;
					}
					else
					{
						kolvo_variant = 4;
					}
					if (!GlobalScript.inst.gameState.allcountries[51].Torg)
					{
						fake_text[0] = " 承 认 现 任 政 府 并 派 遣 大 使";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 不 能 支 持 篡 夺 者 ！";
					}
					fake_text[1] = " 忽 视 军 事 政 变";
					if (GlobalScript.inst.gameState.influencePRC >= 100 && GlobalScript.inst.gameState.data[9] >= 30)
					{
						fake_text[2] = " 提 供 人 道 主 义 援 助";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 没 有 足 够 的 资 源 和 影 响 力";
					}
					if (GlobalScript.inst.gameState.data[9] >= 70 && GlobalScript.inst.gameState.modifies[41].active)
					{
						fake_text[3] = string.Format(GlobalScript.inst.new_events_text[1288], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
					}
					else if (!GlobalScript.inst.gameState.modifies[41].active)
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = string.Format(GlobalScript.inst.new_events_text[1289], 7f);
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = string.Format(GlobalScript.inst.new_events_text[567], 7f);
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 117)
				{
					kolvo_variant = 3;
					if (!GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[0] = " 什 么 都 不 做 ， 我 们 没 有 被 邀 请";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 必 须 去";
					}
					if (GlobalScript.inst.gameState.relres || GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[1] = " 派 遣 中 国 代 表 团 参 加 葬 礼";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 没 人 会 让 我 们 进 去";
					}
					if (GlobalScript.inst.gameState.relres || GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[2] = " 我 们 的 领 导 人 将 亲 自 去 和 尤 里 · 弗 拉 基 米 罗 维 奇 告 别";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 你 不 能 亲 自 去!";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 114)
				{
					kolvo_variant = 1;
					fake_text[0] = " 我 们 都 在 等 待 结 果 … ….";
				}
				else if (GlobalScript.inst.gameState.number_event == 99)
				{
					kolvo_variant = 4;
					if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 我 们 将 帮 助 正 统 派 反 对 修 正 主 义";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 没 有 足 够 的 力 量";
					}
					if (GlobalScript.inst.gameState.data[9] >= 40)
					{
						fake_text[1] = " 支 持 温 和 改 革 者 进 行 社 会 主 义 现 代 化 建 设";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 没 有 足 够 的 力 量";
					}
					if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] >= 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 帮 助 亲 西 方 的 自 由 主 义 者 崛 起";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 能 支 持 他 们";
					}
					fake_text[3] = " 袖 手 旁 观";
				}
				else if (GlobalScript.inst.gameState.number_event == 100)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.influencePRC >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[0] = " 通 过 支 持 反 对 派 来 煽 动 反 政 府 集 会";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 没 有 足 够 的 力 量";
					}
					fake_text[1] = " 我 们 在 国 内 有 自 己 的 问 题";
					if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 拨 款 支 持 政 府";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 能 支 持 他 们";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 102)
				{
					kolvo_variant = 4;
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
					{
						fake_text[0] = " 支 持 戈 尔 巴 乔 夫";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
					}
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
					{
						fake_text[1] = " 支 持 罗 曼 诺 夫";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
					}
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
					{
						fake_text[2] = " 支 持 格 里 申";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
					}
					fake_text[3] = " 不 要 介 入 ， 静 待 结 果";
				}
				else if (GlobalScript.inst.gameState.number_event == 104)
				{
					kolvo_variant = 3;
					fake_text[0] = " 派 代 表 团 去 参 加 节 日";
					fake_text[1] = " 不 派 出 代 表 团";
					fake_text[2] = " 与 盟 国 举 办 自 己 的 节 日 （ 需 要2 百 万 预 算 ）";
				}
				else if (GlobalScript.inst.gameState.number_event == 105)
				{
					kolvo_variant = 3;
					fake_text[0] = " 什 么 都 不 做";
					if ((GlobalScript.inst.gameState.allcountries[15].Torg || GlobalScript.inst.gameState.allcountries[20].Torg) && GlobalScript.inst.gameState.data[9] >= 60)
					{
						fake_text[1] = " 招 募 一 群 科 索 沃 阿 尔 巴 尼 亚 人 并 发 动 一 次 恐 怖 袭 击 （-6 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
					}
					if (!GlobalScript.inst.gameState.allcountries[20].Torg && !GlobalScript.inst.gameState.allcountries[20].proprc)
					{
						fake_text[2] = " 尝 试 与 新 的 管 理 层 建 立 关 系 （ 需 要3 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 中 阿 关 系 平 稳 如 常";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 106)
				{
					kolvo_variant = 3;
					fake_text[0] = " 我 们 不 关 心 此 事";
					if (GlobalScript.inst.gameState.data[9] >= 100)
					{
						fake_text[1] = " 安 排 一 次 恐 怖 袭 击 并 扰 乱 会 议";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
					}
					fake_text[2] = " 支 持 民 主 国 际 的 形 成";
				}
				else if (GlobalScript.inst.gameState.number_event == 109)
				{
					kolvo_variant = 3;
					fake_text[0] = " 什 么 都 不 做";
					if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.influencePRC >= 200)
					{
						fake_text[1] = " 向 索 马 里 提 供 军 事 和 人 道 主 义 援 助( 需 要8 百 万 预 算 ，5 特 工 网 络 ，5 军 事 实 力)";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 不 能 帮 助 索 马 里";
					}
					if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.influencePRC >= 200)
					{
						fake_text[2] = " 组 织 反 对 巴 雷 的 党 内 政 变( 需 要8 特 工 网 络)";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 可 没 有 余 力 关 注 这 件 事";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 110)
				{
					kolvo_variant = 4;
					fake_text[0] = " 让 我 们 再 等 几 年 … … 或 者 更 久 … …";
					fake_text[1] = " 宣 布 一 门 关 于 生 产 自 动 化 的 课 题 ， 并 设 立 一 个 委 员 会 来 实 施 它( 需 要10 百 万 预 算)";
					if (GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.allcountries[1].isSEV)
					{
						fake_text[2] = " 开 始 自 动 化 和 邀 请 苏 联 科 学 家";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 苏 维 埃 不 会 帮 助 我 们";
					}
					if (GlobalScript.inst.gameState.empires[0].relations >= 600 && GlobalScript.inst.gameState.data[6] <= 800 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.modifies[17].active)
					{
						fake_text[3] = " 我 们 准 备 工 作 了 ， 西 方 专 家 会 帮 助 我 们 的 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 向 西 方 求 助 ？ 你 是 认 真 的 吗 ？";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 111)
				{
					kolvo_variant = 4;
					fake_text[0] = " 放 弃 斗 争 和 辞 职";
					if (GlobalScript.inst.gameState.data[3] >= 900 && GlobalScript.inst.gameState.data[5] >= 900 && GlobalScript.inst.gameState.modifies[3].active)
					{
						fake_text[1] = " 号 召 人 民 群 众 反 对 党 阀 的 统 治";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 人 民 已 经 受 够 了 大 鸣 大 放 ， 你 想 复 辟 文 革 余 毒 ？";
					}
					if (GlobalScript.inst.gameState.data[9] >= 400)
					{
						fake_text[2] = " 逮 捕 阴 谋 者 并 开 始 迫 害 最 积 极 主 动 的 合 伙 人 （ 需 要40 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 国 安 部 不 会 支 持 我 们!";
					}
					if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[3] = " 动 员 忠 诚 的 军 官 反 对 阴 谋 家";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 军 官 不 会 拯 救 我 们";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 112)
				{
					kolvo_variant = 3;
					fake_text[0] = " 拨 款 发 展 一 套 保 障 制 度 （ 需 要25 百 万 预 算 ）";
					if (GlobalScript.inst.gameState.empires[1].relations >= 800 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.modifies[3].active)
					{
						fake_text[1] = " 为 发 展 提 供 资 金 ， 并 要 求 苏 联 专 家 提 供 援 助( 需 要25 百 万 预 算 )";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 苏 维 埃 不 会 帮 助 我 们";
					}
					if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[2] = " 看 来 中 国 还 没 有 准 备 好 应 对 这 种 变 化 ， 有 必 要 放 慢 自 动 化 进 程";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 不 能 放 弃 我 们 的 成 就!";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 113)
				{
					kolvo_variant = 5;
					fake_text[0] = " 我 们 关 心 南 斯 拉 夫 干 什 么 ？ 铁 托 主 义 者 不 是 喜 欢 自 力 更 生 吗 ？ 那 就 自 己 的 事 情 自 己 做 ！";
					if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[1] = " 我 们 会 为 南 斯 拉 夫 提 供 重 建 债 务 的 计 划 ， 以 阻 止 改 革 计 划 落 地 （ 需 要 5 特 工 网 络 ， 需 要 20 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 为 什 么 我 们 需 要 重 组 他 们 的 债 务 ？";
					}
					if (((GlobalScript.inst.gameState.influencePRC >= 150 && GlobalScript.inst.gameState.allcountries[1].isSEV) || (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.influencePRC >= 250)) && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[2] = " 我 们 加 入 苏 联 的 提 议";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[2]);
						fake_text[2] = " 我 们 没 有 足 够 的 影 响 力 让 苏 联 和 南 斯 拉 夫 听 我 们 的";
					}
					if (GlobalScript.inst.gameState.influencePRC >= 300 && GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[3] = " 我 们 将 支 持 由 韦 利 科 · 卡 迪 耶 维 奇 和 布 兰 科 · 马 穆 拉 领 导 的 一 批 军 人";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 支 持 军 政 府 ？ 在 南 斯 拉 夫 ？ 胡 说 八 道 ！";
					}
					if ((GlobalScript.inst.gameState.influencePRC >= 200 || GlobalScript.inst.gameState.allcountries[51].dev > 0) && GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] >= 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
					{
						fake_text[4] = " 我 们 加 入 美 国 的 提 议";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = " 我 们 没 有 足 够 的 影 响 力 让 美 国 和 南 斯 拉 夫 听 我 们 的";
					}
				}
				else if (GlobalScript.inst.gameState.number_event == 115)
				{
					kolvo_variant = 3;
					fake_text[0] = " 这 不 是 我 们 的 事 务";
					if ((GlobalScript.inst.gameState.data[56] >= 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
					{
						fake_text[1] = " 与 毒 贩 达 成 协 议 （-1 特 工 网 络 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 中 国 人 民 打 击 毒 贩 子 可 不 是 为 了 让 我 们 与 他 们 眉 来 眼 去 的";
					}
					fake_text[2] = " 帮 助 盟 国 打 击 毒 品 贩 子 （-2 特 工 网 络 ，-2 军 事 力 量 ）";
				}
				else if (GlobalScript.inst.gameState.number_event == 435)
				{
					kolvo_variant = 3;
					fake_text[2] = GlobalScript.inst.new_events_text[1651];
					if (GlobalScript.inst.gameState.data[9] >= 10 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50)
					{
						fake_text[0] = GlobalScript.inst.new_events_text[1649];
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = GlobalScript.inst.new_events_text[1652];
					}
					fake_text[1] = GlobalScript.inst.new_events_text[1650];
				}
				else if (GlobalScript.inst.gameState.number_event == 436)
				{
					kolvo_variant = 3;
					fake_text[0] = GlobalScript.inst.new_events_text[1658];
					fake_text[1] = GlobalScript.inst.new_events_text[1659];
					fake_text[2] = GlobalScript.inst.new_events_text[1660];
				}
				else if (GlobalScript.inst.gameState.number_event == 116)
				{
					kolvo_variant = 3;
					fake_text[0] = " 保 持 原 样";
					if (GlobalScript.inst.gameState.data[6] <= 500 && GlobalScript.inst.gameState.empires[0].relations >= 600)
					{
						fake_text[1] = " 期 待 已 久 的 统 一 时 刻 到 了 ！";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 他 们 不 准 备 同 意 这 样 的 协 议";
					}
					fake_text[2] = " 承 认 彼 此 ， 结 束 敌 意 ！";
				}
				else if (GlobalScript.inst.gameState.number_event == 103)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.allcountries[1].okb && GlobalScript.inst.gameState.allcountries[0].isEU)
					{
						fake_text[0] = " 建 立 一 个 类 似 于 申 根 协 议 的 协 议 ， 只 适 用 于 我 们 军 事 联 盟 的 成 员";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.allcountries[0].isEU)
					{
						fake_text[0] = " 建 立 一 个 类 似 于 马 德 里 协 议 的 协 议 ， 只 适 用 于 我 们 军 事 联 盟 的 成 员";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 没 有 军 事 联 盟";
					}
					if (GlobalScript.inst.gameState.allcountries[0].isEU)
					{
						fake_text[1] = " 为 我 们 所 有 联 盟 的 成 员 建 立 一 个 类 似 于 申 根 协 议 的 协 议";
					}
					else
					{
						fake_text[1] = " 为 我 们 所 有 联 盟 的 成 员 建 立 一 个 类 似 于 马 德 里 协 议 的 协 议";
					}
					fake_text[2] = " 什 么 都 不 做";
				}
				else if (GlobalScript.inst.gameState.number_event == 107)
				{
					kolvo_variant = 5;
					if (GlobalScript.inst.gameState.data[22] >= 200 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
					{
						fake_text[0] = " 派 军 队 迫 使 该 国 回 到 我 们 的 路 线 上 （ 需 要 20 军 事 实 力 ， 需 要 3 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[0]);
						fake_text[0] = " 我 们 的 军 队 没 有 足 够 的 力 量 和 权 威";
					}
					if (GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
					{
						fake_text[1] = " 组 织 一 场 亲 中 派 政 变 （ 需 要 10 特 工 网 络 ， 需 要 3 百 万 预 算 ）";
					}
					else if (GlobalScript.inst.gameState.data[9] >= 200 && !GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
					{
						fake_text[1] = " 组 织 一 场 亲 中 派 政 变 （ 需 要 20 特 工 网 络 ， 需 要 3 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
					}
					fake_text[2] = " 在 经 济 上 约 束 该 国 ， 提 供 财 政 援 助 和 优 惠 贷 款 （ 需 要 10 百 万 预 算 ）";
					if (GlobalScript.inst.gameState.data[9] >= 50)
					{
						fake_text[3] = " 不 要 妨 碍 独 立 的 政 治 ， 以 换 取 该 国 留 在 我 们 集 团 （ 需 要 5 特 工 网 络 ， 需 要 1 百 万 预 算 ）";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[3]);
						fake_text[3] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
					}
					fake_text[4] = " 我 们 必 须 尊 重 他 们 的 选 择";
				}
				else if (GlobalScript.inst.gameState.number_event == 5)
				{
					kolvo_variant = 3;
					if (GlobalScript.inst.gameState.data[14] <= 3)
					{
						fake_text[0] = "";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[0] = "";
					}
					if (GlobalScript.inst.gameState.data[14] > 3 && GlobalScript.inst.gameState.data[6] <= 60)
					{
						fake_text[1] = "";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[1]);
						fake_text[1] = "";
					}
					fake_text[2] = "";
				}
				else
				{
					kolvo_variant = 1;
					fake_text[0] = " 这 里 面 没 东 西";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 1)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не вмешиваться и ожидать итогов";
				if (GlobalScript.inst.gameState.data[1] > 500)
				{
					fake_text[1] = "Пригнать государственных служащих на голосование";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Партия блокирует столь наглое вмешательство";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[2] = "Сфальсифицировать итоги";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "У спецслужб не хватит сил";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 3)
			{
				kolvo_variant = 3;
				fake_text[0] = "Кремировать Мао согласно его желанию и построить мемориал";
				fake_text[1] = "Построить для Мао мавзолей на площади Тяньаньмэнь";
				fake_text[2] = "Пусть похоронная комиссия сама решит";
			}
			else if (GlobalScript.inst.gameState.number_event == 4)
			{
				kolvo_variant = 4;
				fake_text[0] = "Вступить в полемику на съезде";
				if (GlobalScript.inst.gameState.data[9] >= 100)
				{
					fake_text[1] = "Арестовать заговорщиков!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Спецслужбы нас не поддержат";
				}
				if (GlobalScript.inst.gameState.data[22] >= 100)
				{
					fake_text[2] = "Призвать лояльных офицеров!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Армия нас не поддержит";
				}
				if (GlobalScript.inst.gameState.data[3] >= 700)
				{
					fake_text[3] = "Обратиться к народу!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Народу не нужна очередная Культурная революция";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 5)
			{
				kolvo_variant = 5;
				fake_text[0] = "Выступить и успокоить народ";
				if (GlobalScript.inst.gameState.data[15] != 9 || GlobalScript.inst.gameState.data[17] != 19)
				{
					fake_text[1] = "Согласиться на демократизацию";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Демократизироваться дальше некуда";
				}
				if (GlobalScript.inst.gameState.data[22] >= 100)
				{
					fake_text[2] = "Разогнать протестующих армией";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Армия нас не поддержит";
				}
				if (GlobalScript.inst.gameState.data[3] > 500)
				{
					fake_text[3] = "Призвать лояльную часть народа в поддержку";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Народу не нужна очередная Культурная революция";
				}
				if (GlobalScript.inst.gameState.data[9] >= 150)
				{
					fake_text[4] = "Развалить протест изнутри спецслужбами";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "Спецслужбы не справятся";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 6)
			{
				kolvo_variant = 4;
				fake_text[0] = "Срочно выделить деньги на социальные программы";
				if ((GlobalScript.inst.gameState.empires[0].relations >= 500 && !GlobalScript.inst.gameState.allcountries[1].isSEV) || (GlobalScript.inst.gameState.empires[1].relations >= 500 && !GlobalScript.inst.gameState.allcountries[51].Torg && !GlobalScript.inst.gameState.allcountries[1].econ))
				{
					fake_text[1] = "Запросить иностранную гуманитарную помощь";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Помощи ждать неоткуда";
				}
				if (GlobalScript.inst.gameState.data[16] >= 13)
				{
					fake_text[2] = "Методом кнута и пряника призвать бизнес к решению социальных проблем";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Бизнес мы призвать не можем, ибо у нас его нет";
				}
				if (GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text[3] = "Устроить благотворительность за счёт партии и чиновников";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Партия не хочет делиться";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 7)
			{
				kolvo_variant = 4;
				if (GlobalScript.inst.gameState.data[51] != 30 || GlobalScript.inst.gameState.data[6] <= 950)
				{
					fake_text[0] = "Организовать разрядку за наш счёт";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Мы не сдадимся!";
				}
				if (GlobalScript.inst.gameState.influencePRC >= 50)
				{
					fake_text[1] = "Сдать часть внешнеполитических позиций в знак доброй воли";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Наше влияние слишком слабо, так что ограничить его мы не можем";
				}
				if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Запустить ядерное оружие по империалистам!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Никто не хочет ядерной войны";
				}
				fake_text[3] = "Нам всё равно";
			}
			else if (GlobalScript.inst.gameState.number_event == 8)
			{
				kolvo_variant = 4;
				if (GlobalScript.inst.gameState.data[51] != 30 || GlobalScript.inst.gameState.data[6] <= 950)
				{
					fake_text[0] = "Организовать разрядку за наш счёт";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Мы не сдадимся!";
				}
				if (GlobalScript.inst.gameState.influencePRC >= 50)
				{
					fake_text[1] = "Сдать часть внешнеполитических позиций в знак доброй воли";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Наше влияние слишком слабо, так что ограничить его мы не можем";
				}
				if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Запустить ядерное оружие по ревизионистам!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Никто не хочет ядерной войны";
				}
				fake_text[3] = "Нам всё равно";
			}
			else if (GlobalScript.inst.gameState.number_event == 9)
			{
				kolvo_variant = 3;
				fake_text[0] = "Мы ничего не можем сделать";
				if (GlobalScript.inst.gameState.data[18] < 23)
				{
					fake_text[1] = "Дать им больше автономии";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Ещё больше автономии мы дать не можем";
				}
				if (GlobalScript.inst.gameState.data[56] != 4 || GlobalScript.inst.gameState.data[22] >= 100)
				{
					fake_text[2] = "Послать войска для наведения порядка";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Просто задавить их армией не получится";
				}
				if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 40 || GlobalScript.inst.gameState.data[36] >= 40 || GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[3] = "Провести сфальсифицированный референдум о суверенитете";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "У нас нет ни средств ни сил на фальсификации";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 10)
			{
				kolvo_variant = 3;
				fake_text[0] = "Мы ничего не можем сделать";
				if (GlobalScript.inst.gameState.data[18] < 23)
				{
					fake_text[1] = "Дать им больше автономии";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Ещё больше автономии мы дать не можем";
				}
				if (GlobalScript.inst.gameState.data[56] != 4 || GlobalScript.inst.gameState.data[22] >= 100)
				{
					fake_text[2] = "Послать войска для наведения порядка";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Просто задавить их армией не получится";
				}
				if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 20 || GlobalScript.inst.gameState.data[36] >= 20 || GlobalScript.inst.gameState.data[9] >= 40)
				{
					fake_text[3] = "Провести сфальсифицированный референдум о суверенитете";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "У нас нет ни средств ни сил на фальсификации";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 11)
			{
				kolvo_variant = 4;
				fake_text[0] = "Срочно выделить деньги на развитие";
				if (GlobalScript.inst.gameState.empires[0].relations >= 600 && (GlobalScript.inst.gameState.data[16] >= 13 || GlobalScript.inst.gameState.SEZ))
				{
					fake_text[1] = "Привлечь иностранные инвестиции";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Инвесторы к нам не пойдут";
				}
				if (GlobalScript.inst.gameState.empires[1].relations >= 700 || GlobalScript.inst.gameState.relres)
				{
					fake_text[2] = "Запросить помощи у СССР";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не нужны подачки ревизионистов!";
				}
				if (GlobalScript.inst.gameState.data[13] >= 500)
				{
					fake_text[3] = "Форсировать развитие за счёт сельского хозяйства";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Положение в сельском хозяйстве не сильно лучше";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 12)
			{
				kolvo_variant = 4;
				fake_text[0] = "Срочно выделить деньги на развитие";
				if (GlobalScript.inst.gameState.empires[0].relations >= 600 && (GlobalScript.inst.gameState.data[16] >= 13 || GlobalScript.inst.gameState.SEZ))
				{
					fake_text[1] = "Привлечь иностранные инвестиции";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Инвесторы к нам не пойдут";
				}
				if (GlobalScript.inst.gameState.empires[1].relations >= 700 || GlobalScript.inst.gameState.relres)
				{
					fake_text[2] = "Запросить помощи у СССР";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не нужны подачки ревизионистов!";
				}
				if (GlobalScript.inst.gameState.data[12] >= 500)
				{
					fake_text[3] = "Форсировать развитие за счёт промышленности";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Положение в промышленности не сильно лучше";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 13)
			{
				kolvo_variant = 4;
				fake_text[0] = "Срочно выделить деньги на развитие";
				if (GlobalScript.inst.gameState.empires[0].relations >= 600 && (GlobalScript.inst.gameState.data[16] >= 13 || GlobalScript.inst.gameState.SEZ))
				{
					fake_text[1] = "Привлечь иностранные инвестиции";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Инвесторы к нам не пойдут";
				}
				if (GlobalScript.inst.gameState.empires[1].relations >= 700 || GlobalScript.inst.gameState.relres)
				{
					fake_text[2] = "Запросить помощи у СССР";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не нужны подачки ревизионистов!";
				}
				if (GlobalScript.inst.gameState.data[12] >= 500 || GlobalScript.inst.gameState.data[13] >= 500)
				{
					fake_text[3] = "Форсировать развитие за счёт промышленности и сельского хозяйства";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Положение в промышленности и сельском хозяйстве не сильно лучше";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 14)
			{
				int num8 = 0;
				kolvo_variant = 4;
				if (GlobalScript.inst.gameState.data[16] >= 13 && GlobalScript.inst.gameState.data[5] >= 500)
				{
					fake_text[0] = "Поднять налоги и сократить социальные программы";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "";
					num8++;
				}
				if (GlobalScript.inst.gameState.data[16] >= 14)
				{
					fake_text[1] = "Поднять налоги на роскошь и для сверхбогатых";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Олигархов у нас нет";
					num8++;
				}
				if (GlobalScript.inst.gameState.data[16] <= 14 && GlobalScript.inst.gameState.data[56] != 0 && (GlobalScript.inst.gameState.data[15] > 7 || GlobalScript.inst.gameState.data[56] != 1))
				{
					fake_text[3] = "Провести быструю приватизацию госпредприятий";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Приватизацию провести не получится";
					num8++;
				}
				if (GlobalScript.inst.gameState.empires[0].relations > 500 || (GlobalScript.inst.gameState.empires[1].relations > 500 && GlobalScript.inst.gameState.influencePRC >= 50) || num8 >= 3)
				{
					fake_text[2] = "Взять иностранный кредит";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Кредит нам не дадут";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 15)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не вмешиваться";
				if (GlobalScript.inst.gameState.data[9] >= 30 && GlobalScript.inst.gameState.data[56] != 0)
				{
					fake_text[1] = "Сместить Пол Пота в пользу армейского командования";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Мы не можем смещать Пол Пота";
				}
				if (GlobalScript.inst.gameState.data[56] != 4)
				{
					fake_text[2] = "Помочь Красным кхмерам";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мы не можем помогать диктатору!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 16)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не вмешиваться";
				if (GlobalScript.inst.gameState.data[9] >= 20 || GlobalScript.inst.gameState.allcountries[34].stab == 1)
				{
					fake_text[1] = "Поддержать КПТ и создать коалицию с левыми и демократами";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит сил на поддержку КПТ";
				}
				if (GlobalScript.inst.gameState.data[22] >= 20 && GlobalScript.inst.gameState.data[56] != 4)
				{
					fake_text[2] = "К чёрту выборы! Лучше вышлем КПТ больше оружия для партизанской войны.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Отправить КПТ ещё оружия мы не можем";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 17)
			{
				kolvo_variant = 3;
				fake_text[0] = "Это не наше дело";
				if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.data[22] >= 30 && GlobalScript.inst.gameState.data[41] == 100)
				{
					fake_text[1] = "Направить вооружённые части КПТ в помощь демонстрантам и спровоцировать восстание";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит сил на организацию восстания";
				}
				fake_text[2] = "Осудить жестокости Таиланда";
			}
			else if (GlobalScript.inst.gameState.number_event == 18)
			{
				kolvo_variant = 1;
				if (GlobalScript.inst.gameState.data[82] < 8)
				{
					fake_text[0] = "Да здравствует мир!";
				}
				else
				{
					fake_text[0] = "Нужно ознакомиться!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 19)
			{
				kolvo_variant = 4;
				fake_text[0] = "Пусть проходит, как проходит";
				fake_text[1] = "Следить за строгим исполнением указов Мао";
				fake_text[2] = "Следить за строгим исполнением кампании, а также критиковать Чжоу в СМИ.";
				fake_text[3] = "Аккуратно саботировать кампанию";
			}
			else if (GlobalScript.inst.gameState.number_event == 20)
			{
				kolvo_variant = 3;
				fake_text[0] = "А ничего не делать. Цзян Цин и Сяопин друг друга стоят";
				fake_text[1] = "Присоединиться к травле Сяопина";
				fake_text[2] = "Заступиться за Сяопина";
			}
			else if (GlobalScript.inst.gameState.number_event == 21)
			{
				kolvo_variant = 3;
				fake_text[0] = "Ничего не предпринимать";
				fake_text[1] = "Изъять материал и запретить его публикацию";
				fake_text[2] = "Подхватить тезисы статьи и распространять их в СМИ";
			}
			else if (GlobalScript.inst.gameState.number_event == 22)
			{
				kolvo_variant = 3;
				fake_text[0] = "Разогнать протест с помощью армии и полиции";
				if (GlobalScript.inst.gameState.data[88] >= 0)
				{
					fake_text[1] = "Призвать всех разойтись и разогнать оставшихся";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Народ не хочет уходить";
				}
				if (GlobalScript.inst.gameState.data[88] >= 2)
				{
					fake_text[2] = "Призвать всех разойтись и оцепить оставшихся до тех пор, пока не уйдут";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Народ не хочет уходить";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 23)
			{
				kolvo_variant = 4;
				fake_text[0] = "Выделить средства из бюджета на восстановление (-3.0 из бюджета)";
				if (GlobalScript.inst.gameState.empires[0].relations >= 600 || GlobalScript.inst.gameState.empires[1].relations >= 600)
				{
					fake_text[1] = "Запросить иностранную гуманитарную помощь";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Иностранцы не выделят нам помощь";
				}
				fake_text[2] = "Выделить средства на восстановление и на развитие системы защиты от землетрясений (-5.0 из бюджета)";
				fake_text[3] = "Пусть провинциальная администрация разбирается сама";
			}
			else if (GlobalScript.inst.gameState.number_event == 24)
			{
				kolvo_variant = 4;
				fake_text[0] = "Продолжим дело Мао, свернув Культурную революцию";
				if (GlobalScript.inst.gameState.data[84] == 3)
				{
					fake_text[1] = "Культурная революция без перегибов и борьба с ревизионизмом по заветам Мао!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Культурная революция уже всем надоела";
				}
				if (GlobalScript.inst.gameState.data[84] != 3)
				{
					fake_text[2] = "Свернём Культурную революцию, и с экономикой что-то делать надо...";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "";
				}
				if (GlobalScript.inst.gameState.data[84] != 3)
				{
					fake_text[3] = "Свернём Культурную революцию и начнём разработку масштабных реформ с выходом на мировой рынок";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 25)
			{
				kolvo_variant = 4;
				fake_text[0] = "Арестовать всех четырех";
				fake_text[1] = "Арестовать Ван Хунвэня и Цзян Цин и найти компромисс с остальными радикалами";
				fake_text[2] = "Пойти на компромисс и заручиться поддержкой радикалов";
				fake_text[3] = "Не вмешиваться в разборки в партии";
			}
			else if (GlobalScript.inst.gameState.number_event == 26)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 70)
				{
					fake_text[0] = "Арестовать всех четырех";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "У вас уже не хватит сил";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[1] = "Арестовать лишь Ван Хунвэня и Цзян Цин";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У вас уже не хватит сил";
				}
				fake_text[2] = "Отказаться от борьбы и пойти на постепенную передачу власти";
			}
			else if (GlobalScript.inst.gameState.number_event == 27)
			{
				kolvo_variant = 3;
				fake_text[0] = "Договориться о передаче колоний при сохранении их широкой автономии";
				fake_text[1] = "Договориться о передаче колоний при сохранении их ограниченной автономии";
				fake_text[2] = "Потребовать полной интеграции колоний в КНР при сохранении прав собственности иностранцев";
			}
			else if (GlobalScript.inst.gameState.number_event == 28)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не вмешиваться, Сухарто и так обречён";
				if (GlobalScript.inst.gameState.data[9] >= 30)
				{
					fake_text[1] = "Поддержать умеренно-левую оппозицию";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит сил на поддержку левых";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[2] = "Помочь коммунистическому подполью вновь организоваться";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Восстановить коммунистическое движение мы не сможем";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 29)
			{
				kolvo_variant = 4;
				fake_text[0] = "Потребовать ограниченной политической либерализации";
				fake_text[1] = "Потребовать широких политических и экономических реформ";
				if (GlobalScript.inst.gameState.data[16] >= 13)
				{
					fake_text[2] = "Потребовать открытия СЭЗ для китайских компаний";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Империализмом мы заниматься не станем и не можем";
				}
				fake_text[3] = "Потребовать максимально возможной демократизации";
			}
			else if (GlobalScript.inst.gameState.number_event == 30)
			{
				kolvo_variant = 3;
				fake_text[0] = "Предложить создание арабского государства на части территорий Палестины";
				fake_text[1] = "Предложить создание автономии для арабов до дальнейшего урегулирования кризиса";
				fake_text[2] = "Предложить создание союзного государства арабов и евреев";
			}
			else if (GlobalScript.inst.gameState.number_event == 31)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не вмешиваться в демократический процесс";
				if (GlobalScript.inst.gameState.data[9] >= 40)
				{
					fake_text[1] = "Помочь Ким Дэ Чжуну собрать коалицию оппозиции";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит сил поддержать его";
				}
				if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.influencePRC >= 200 && GlobalScript.inst.gameState.data[83] != 2 && GlobalScript.inst.gameState.data[83] != 1)
				{
					fake_text[2] = "Помочь Ким Дэ Чжуну и надавить на КНДР, подтолкнув к объединению";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не хватит сил на такое мероприятие";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 32)
			{
				kolvo_variant = 2;
				fake_text[0] = "Наблюдать за развитием ситуации";
				if (GlobalScript.inst.gameState.data[9] >= 40)
				{
					fake_text[1] = "Воспользоваться ситуацией в наших целях";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит сил";
				}
				UnityEngine.Object.Destroy(galka_stuk[2]);
				fake_text[2] = "Спровоцировать антисоветские выступления, чтобы помочь их подавить? Серьёзно?";
			}
			else if (GlobalScript.inst.gameState.number_event == 33)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не вмешиваться";
				if (GlobalScript.inst.gameState.data[9] >= 60)
				{
					fake_text[1] = "Помочь Бхутто";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Помочь мы не можем";
				}
				fake_text[2] = "Не вмешиваться и наладить отношения с новым правительством";
			}
			else if (GlobalScript.inst.gameState.number_event == 34)
			{
				kolvo_variant = 4;
				fake_text[0] = "Осторожно ударить по реформаторам";
				fake_text[1] = "Ограничиться продвижением лояльных консерваторов";
				fake_text[2] = "Ударить по реформаторам, чтобы расчистить путь умеренным-консерваторам";
				if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
				{
					fake_text[3] = "Нам нужен крепкий альянс с реформаторами!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Вам нельзя договариваться с ревизионистами!";
				}
				fake_text[4] = "Не стоит ломать шаткий баланс в партии";
			}
			else if (GlobalScript.inst.gameState.number_event == 35)
			{
				kolvo_variant = 4;
				fake_text[0] = "Ничего не делать, хватит уступок";
				fake_text[1] = "Ограничиться небольшой гражданской либерализацией";
				fake_text[2] = "Ослабить контроль и прекратить давление на традиции";
				if (GlobalScript.inst.gameState.data[56] != 0)
				{
					fake_text[3] = "Ослабить контроль и перейти лишь к надзору за религией";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Мы не можем идти на такую либерализацию!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 36)
			{
				kolvo_variant = 3;
				fake_text[0] = "Нет, не стоит";
				fake_text[1] = "Осудить руководство Баас";
				if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.influencePRC >= 50)
				{
					fake_text[2] = "С помощью спецслужб и политического давления склонить стороны к диалогу";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "У нас не хватит сил и влияния";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 37)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.allcountries[30].stab == 1)
				{
					fake_text[0] = "Всеми силами поддержим выступления и спровоцируем свержение Садата";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Это слишком радикальное вмешательство в дела Египта!";
				}
				if (GlobalScript.inst.gameState.data[9] >= 20 && GlobalScript.inst.gameState.data[56] <= 2)
				{
					fake_text[1] = "Помочь Ливии и Сирии свалить Садата";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "А так ли нужна нам эта Северная Африка?";
				}
				fake_text[2] = "Дела Египта нас не волнуют";
			}
			else if (GlobalScript.inst.gameState.number_event == 38)
			{
				kolvo_variant = 3;
				int num9 = 0;
				if (GlobalScript.inst.gameState.data[87] != 4)
				{
					fake_text[1] = "Возродить плановую систему (-1.0 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Партия идёт к реформам, следуя вашим курсом!";
					num9++;
				}
				if (GlobalScript.inst.gameState.data[84] != 3 && GlobalScript.inst.gameState.data[87] != 2 && GlobalScript.inst.gameState.data[87] != 1 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Начать подготовку для дальнейших масштабных реформ";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Долой ревизионизм!";
					num9++;
				}
				if ((GlobalScript.inst.gameState.data[87] != 2 && GlobalScript.inst.gameState.data[87] != 4) || num9 >= 2)
				{
					fake_text[0] = "Не стоит ломать то, что работает";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Старая система своё отжила!";
					num9++;
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 39)
			{
				kolvo_variant = 3;
				fake_text[0] = "Председатель " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " лично возглавит комиссию из консервативных маоистов. Наш путь верен!";
				fake_text[1] = "Доверим работу Дэн Сяопину и прагматичным реформаторам. Они дадут взвешенную оценку.";
				if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Товарищи Пэн Чжень и Чжао Цзыян вскроют все ошибки и изобличат их!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Чжень? Цзыян? Это же либералы, которых Председатель Мао выгнал взашей!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 40)
			{
				kolvo_variant = 5;
				if (GlobalScript.inst.gameState.data[56] <= 1)
				{
					fake_text[0] = "Пусть сидит и дальше!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Мы не можем удерживать его в тюрьме и дальше!";
				}
				if (GlobalScript.inst.gameState.data[56] <= 2)
				{
					fake_text[1] = "Отпустить из тюрьмы в обмен на отказ от монашеских обетов.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Это слишком сильное давление на него!";
				}
				if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 4)
				{
					fake_text[2] = "Отпустить и позволить вернуться в Лхасу, но под наблюдением МГБ (4 агентурные сети).";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Или пусть сидит в тюрьме, или пусть будет свободен.";
				}
				if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[3] = "Выпустить узника совести и реабилитировать его!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Реабилитировать?! Да его сам Председатель Мао обвинил!";
				}
				if (GlobalScript.inst.gameState.data[9] >= 70 && GlobalScript.inst.gameState.data[56] != 4)
				{
					fake_text[4] = "Ликвидировать его под видом сердечного приступа и заставить избрать Норбу новым Панчен-Ламой.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "Панчен-Ламу должны выбирать сами монахи!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 41)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не вмешиваться";
				if (GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[1] = "Поддержать оппозицию";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У нас не хватит сил";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.data[56] != 0)
				{
					fake_text[2] = "Поддержать Индиру Ганди";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Поддержать Ганди? Может ещё и тибетские территории ей отдать?";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 42)
			{
				kolvo_variant = 5;
				fake_text[0] = "Не вмешиваться";
				if (GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[1] = "Поддержать левые организации";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Помочь мы не можем";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Поддержать исламистов";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Помогать религиозным фанатикам? Да ни за что!";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[3] = "Поддержать правящий режим";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Мы никогда не поддержим проамериканского шаха!";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[4] = "Поддержать демократов";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "Помочь мы не можем";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 43)
			{
				kolvo_variant = 2;
				fake_text[0] = "Не вмешиваться";
				if (GlobalScript.inst.gameState.data[9] >= 30 && GlobalScript.inst.gameState.allcountries[23].Gosstroy == 1)
				{
					fake_text[1] = "Всеми средствами остановить процесс вступления";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Мы ничего не можем сделать";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 44)
			{
				kolvo_variant = 3;
				fake_text[0] = "Согласиться начать реформы. " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " получит власть.";
				if (GlobalScript.inst.gameState.data[9] >= 150)
				{
					fake_text[1] = "Затягивать заседание, чтобы в перерыве арестовать реформаторов силами МГБ";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У нас нет ни сил, ни влияния на такое";
				}
				if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
				{
					fake_text[2] = "Согласиться с их требованиями в обмен на удержание власти";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "После ваших высказываний они не станут сотрудничать";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 45)
			{
				kolvo_variant = 5;
				fake_text[0] = "Вперёд, к социалистическому рынку!";
				fake_text[1] = "Назад пути нет!";
				UnityEngine.Object.Destroy(galka_stuk[1]);
				fake_text[2] = "Вы что, догматик?!";
				UnityEngine.Object.Destroy(galka_stuk[2]);
				fake_text[3] = "Можем вас в ещё одну банду записать, если вы против.";
				UnityEngine.Object.Destroy(galka_stuk[3]);
				fake_text[4] = "Неважно, какого цвета кошка, даже если она собака!";
				UnityEngine.Object.Destroy(galka_stuk[4]);
			}
			else if (GlobalScript.inst.gameState.number_event == 46)
			{
				kolvo_variant = 4;
				fake_text[0] = "Европа далеко, Азия нам важнее";
				if (GlobalScript.inst.gameState.data[9] >= 80)
				{
					fake_text[1] = "Организовать поддержку и координацию Белу Биску и его людей с нашими спецслужбами";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У нас не хватит сил";
				}
				if (GlobalScript.inst.gameState.data[9] >= 30 && GlobalScript.inst.gameState.data[22] >= 10)
				{
					fake_text[2] = "Помочь в организации прокитайского восстания";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Новое восстание в Венгрии?! Одумайтесь!";
				}
				if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[3] = "Мы не можем помочь, но с радостью укроем у себя Биску от гнева ревизионистов";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Европа далеко, Азия нам важнее";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 47)
			{
				kolvo_variant = 3;
				fake_text[0] = "Пусть МГБ и ответственный за кадры в КПК займутся этими проблемами";
				fake_text[1] = "Вступить в полемику с реформаторами и выпустить собственные опровержения";
				fake_text[2] = "Наши СМИ сами разберутся с этой дешёвой пропагандой";
			}
			else if (GlobalScript.inst.gameState.number_event == 63)
			{
				kolvo_variant = 4;
				fake_text[0] = "Не вмешиваться в афганские дела";
				if (GlobalScript.inst.gameState.data[9] >= 30)
				{
					fake_text[1] = "Оказать поддержку лояльной нам оппозиции в ДРА";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У нас нет сил на такое";
				}
				if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Установить отношения и оказывать поддержку Хальк";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Они не станут сотрудничать";
				}
				if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[3] = "Установить отношения и оказывать поддержку Парчам";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Они не станут сотрудничать";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 48)
			{
				kolvo_variant = 3;
				fake_text[0] = "Лучше не будем влезать в эти дела";
				fake_text[1] = "Начать пока негласное сближение с ДРА (-2.0 из бюджета)";
				if (GlobalScript.inst.gameState.relres)
				{
					fake_text[2] = "Не доверяем мы ему... Лучше тайно договоримся с СССР о его смещении, глядишь нам от новой власти что-нибудь перепадёт.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Никаких сговоров с СССР!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 49)
			{
				kolvo_variant = 2;
				fake_text[0] = "Это дело СССР";
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[9] >= 70)
				{
					fake_text[1] = "Предупредить Амина и выслать ему помощь";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Никто не даст нам вмешаться";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 50)
			{
				kolvo_variant = 5;
				fake_text[0] = "Никого. Это не наше дело";
				if (GlobalScript.inst.gameState.relres)
				{
					fake_text[1] = "Оказать помощь ДРА в обмен на включение маоистских партий в альянс с НДПА";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "СССР не даст нам так глубоко вмешаться";
				}
				fake_text[2] = "Оказать помощь ДРА";
				fake_text[3] = "Оказать помощь маоистским повстанцам";
				fake_text[4] = "Продать оружия моджахедам, американцы готовы заплатить";
			}
			else if (GlobalScript.inst.gameState.number_event == 51)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не реагировать";
				fake_text[1] = "Осудить ввод войск";
				fake_text[2] = "Поддержать ввод войск";
			}
			else if (GlobalScript.inst.gameState.number_event == 53)
			{
				kolvo_variant = 4;
				fake_text[0] = "Оставить всё как есть";
				fake_text[1] = "Ввести семейный подряд";
				if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Ввести частное фермерство";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мы не отдадим сельское хозяйство частникам-спекулянтам!";
				}
				if (GlobalScript.inst.gameState.data[89] == 0)
				{
					fake_text[3] = "Организовать колхозы";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Колхозы - пережиток плана";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 54)
			{
				kolvo_variant = 3;
				fake_text[0] = "Отложить этот вопрос";
				fake_text[1] = "Открыть СЭЗ";
				if (GlobalScript.inst.gameState.data[56] != 2)
				{
					fake_text[2] = "Открыть СЭЗ и часть остальных предприятий для инвестирования";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мао от такого в гробу перевернётся!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 55)
			{
				kolvo_variant = 3;
				fake_text[0] = "Нас это не касается";
				fake_text[1] = "Отправить помощь У Не Вину и установить дружеские отношения (-3.0 из бюджета)";
				if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.allcountries[33].stab == 1)
				{
					fake_text[2] = "Помочь коммунистам организовать партийный переворот";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мы не сможем им помочь";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 56)
			{
				kolvo_variant = 3;
				fake_text[0] = "Не будем обострять ситуацию";
				if (!GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.war == 0)
				{
					fake_text[1] = "Готовьтесь к войне. Преподадим Вьетнаму урок!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Всё идёт по плану";
				}
				if (!GlobalScript.inst.gameState.event_done[14] && !GlobalScript.inst.gameState.allcountries[11].isSEV)
				{
					fake_text[2] = "Провести встречу и переговоры КНР и Вьетнама";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Они не станут с нами договариваться";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 57)
			{
				kolvo_variant = 2;
				fake_text[0] = "Это нас не касается";
				if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.allcountries[44].stab == 1)
				{
					fake_text[1] = "Оказать финансовую и агентурную помощь КПЯ";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "КПЯ нас не послушается";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 58)
			{
				kolvo_variant = 1;
				fake_text[0] = "Революция завершилась";
			}
			else if (GlobalScript.inst.gameState.number_event == 59)
			{
				kolvo_variant = 4;
				fake_text[0] = "Проигнорировать предложение";
				if (!GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[1] = "Создать экономический союз (-15.0 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Мы не готовы (-15 из бюджета)";
				}
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[56] <= 1 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text[2] = "Вступить в СЭВ";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Никаких переговоров с ревизионистами!";
				}
				if (GlobalScript.inst.gameState.war <= 0 && !GlobalScript.inst.gameState.allcountries[1].isOVD && !GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.allcountries[1].Vyshi && !GlobalScript.inst.gameState.allcountries[15].cw)
				{
					fake_text[3] = "Вступить в «Движение Неприсоединения»";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Нас там недолюбливают.";
				}
				if (GlobalScript.inst.dlc[3])
				{
					if (GlobalScript.inst.gameState.allcountries[1].Gosstroy != 1 && !GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.allcountries[51].Torg && GlobalScript.inst.gameState.data[52] > 34)
					{
						fake_text[4] = "Присоединится к АСЕАН";
					}
					else if (GlobalScript.inst.gameState.relres)
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = "Отношения с СССР не должны быть восстановлены!";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1)
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = "Госстрой не должен быть социализмом";
					}
					else if (GlobalScript.inst.gameState.data[52] <= 34)
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = "Линия партии должна быть Реформаторской или либеральнее";
					}
					else
					{
						UnityEngine.Object.Destroy(galka_stuk[4]);
						fake_text[4] = "Нужна дружба с США";
					}
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 60)
			{
				kolvo_variant = 2;
				if (GlobalScript.inst.gameState.data[22] >= 300 && GlobalScript.inst.gameState.data[9] >= 100 && !GlobalScript.inst.gameState.allcountries[1].isOVD)
				{
					fake_text[0] = "Создать военный блок (-5 из бюджета, -30 силы армии и -10 агентурных сетей)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Мы не готовы (-5 из бюджета, -30 силы армии и -10 агентурных сетей)";
				}
				fake_text[1] = "Ничего не делать";
			}
			else if (GlobalScript.inst.gameState.number_event == 61)
			{
				kolvo_variant = 3;
				fake_text[0] = "Восстанавливаем \"Марш добровольцев\" без изменений (-1 из бюджета)";
				if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[1] = "Утверждаем гимном \"Алеет Восток\"";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Никаких рецидивов Культурной революции!";
				}
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Восстанавливаем \"Марш добровольцев\", но с новым текстом (-1 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "В этом нет необходимости!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 62)
			{
				kolvo_variant = 5;
				if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[0] = "Это справедливый шаг. Именно так мы и поступим! (-3 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Никаких уступок!";
				}
				fake_text[1] = "Не слишком ли много чести для национального меньшинства? Отказать.";
				if (GlobalScript.inst.gameState.data[56] != 1)
				{
					fake_text[2] = "Территории вернем, но ассимиляцию не прекратим.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Это не соответствует национальной политике КПК!";
				}
				if (GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 3)
				{
					fake_text[3] = "Ассимиляцию имеет смысл прекратить, но территории возвращать не будем (-1 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Это тоже не соответствует национальной политике КПК!";
				}
				if (GlobalScript.inst.gameState.data[50] != 24 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[18] < 23)
				{
					fake_text[4] = "Пришло время всерьез заняться национальным вопросом в малых АР. Выправим все перегибы! (-6 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "Национального вопроса в Китае нет! Он решен в 50-е годы раз и навсегда.";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 52)
			{
				kolvo_variant = 4;
				fake_text[0] = "Пусть Пакистан сам разбирается";
				fake_text[1] = "Выслать Пакистану помощь для патруля границы и поимки исламистов";
				if (GlobalScript.inst.gameState.ingamewars[5].ussr_place != 1 && !GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[2] = "Договориться с США";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Никакой помощи реакционерам!";
				}
				if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 1)
				{
					fake_text[3] = "Зачем нам всё это? Лучше организуем в Пакистане базы для афганских повстанцев-маоистов (-5 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Маоистским партизанам в ДРА уже не помочь";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 64)
			{
				kolvo_variant = 2;
				fake_text[0] = "Это не стоит наших сил";
				if (GlobalScript.inst.gameState.data[9] >= 50 && (!GlobalScript.inst.gameState.allcountries[30].prosov || GlobalScript.inst.gameState.relres))
				{
					fake_text[1] = "Оказать помощь в создании ОАР (-7 из бюджета, -5 агентурных сетей)";
				}
				else if (GlobalScript.inst.gameState.data[9] < 50)
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нужно 5 агентурных сетей...";
				}
				else if (GlobalScript.inst.gameState.allcountries[30].prosov && !GlobalScript.inst.gameState.relres)
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Отношения с СССР не восстановлены...";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Они не пойдут на это...";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 65)
			{
				kolvo_variant = 5;
				int num10 = 0;
				if ((GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))) || GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[0] = "Спорт вне политики! Мы примем участие в московской Олимпиаде и отправим лучших спортсменов! (-4 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					num10++;
					fake_text[0] = "Мы не можем игнорировать мнение Запада";
				}
				if ((GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))) || (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[56] != 0))
				{
					fake_text[1] = "Бойкота не объявляем, но обе Игры игнорируем...";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					num10++;
					fake_text[1] = "Мы не можем игнорировать обе Игры!";
				}
				if (GlobalScript.inst.gameState.data[89] > 0 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[3] = "Объявляем советским Играм бойкот и отправляем команду в США (-3 из бюджета).";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					num10++;
					fake_text[3] = "Поехать в США?! Вы это серьезно?..";
				}
				if (GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[4] = "Возрождаем GANEFO и отправляем приглашения развивающимся странам (-20 из бюджета).";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					num10++;
					fake_text[4] = "Хватит с нас маоистских экспериментов!";
				}
				if ((((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[56] != 0) || num10 >= 4)
				{
					fake_text[2] = "Объявим бойкот, но разрешим нашим спортсменам поехать в Москву под олимпийским флагом (-4 из бюджета).";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Это не соответствует нашей политике!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 66)
			{
				kolvo_variant = 4;
				fake_text[0] = "Выразим свои соболезнования, но не более того.";
				if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7) || GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[1] = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " лично возглавит правительственную делегацию и вылетит в Белград.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " не может лично лететь на похороны ревизиониста Тито!";
				}
				if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Отправим делегацию во главе с Генеральным секретарем Госсовета Цзи Пэнфэем.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Никаких делегаций в Белград!";
				}
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[3] = "Тито умер? Ну и пусть, нам-то что?";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Мы не можем никак не отреагировать на его смерть!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 67)
			{
				kolvo_variant = 4;
				fake_text[0] = "Дела Польши Китая не касаются. Сами наломали дров - сами и разбирайтесь!";
				if (GlobalScript.inst.gameState.relres)
				{
					fake_text[1] = "Поддержим просоветских военных во главе с генералом Войцехом Витольдом Ярузельским (-5 агентов, -20 из бюджета).";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Договор о дружбе с СССР не подписан...";
				}
				if (GlobalScript.inst.gameState.allcountries[20].proprc && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Формируем коалицию из Компартии Мияля, \"бетона\" Сивака, \"ПАКС\" и \"Грюнвальд\", поддерживаем всеми силами (-15 агентов, -30 из бюджета).";
				}
				else if (!GlobalScript.inst.gameState.allcountries[20].proprc)
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Албания должна быть в нашей сфере влияния...";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Реформаторы и либералы не должны лидировать...";
				}
				if (GlobalScript.inst.gameState.empires[1].relations >= 60 && GlobalScript.inst.gameState.allcountries[1].isOVD)
				{
					fake_text[3] = "Обратимся к странам ОВД с предложением военного вмешательства (-5 агентов -5 силы армии).";
				}
				else if (!GlobalScript.inst.gameState.allcountries[1].isOVD)
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Мы должны состоять в ОВД...";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Отношения с СССР должны быть выше 6.0...";
				}
				if (GlobalScript.inst.gameState.empires[0].relations >= 60 && GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text[4] = "Вместе с США поддержим \"Солидарность\" (-10 из бюджета, -20 агентов)";
				}
				else if (!GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "Нужен договор о дружбе с США...";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "Отношения с США должны быть выше 6.0...";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 68)
			{
				kolvo_variant = 2;
				fake_text[0] = "Пусть сами разбираются";
				if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.data[22] >= 80)
				{
					fake_text[1] = "Оказать помощь восставшим и спровоцировать волнения (-8 силы армии, -10 агентурных сетей)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У нас не хватит ресурсов";
					fake_text[2] = "Призвать стороны к диалогу";
					fake_text[3] = "Поддержать действия Чон Ду Хвана";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 69)
			{
				kolvo_variant = 3;
				fake_text[0] = "Ничего не делать. Разные взгляды - залог демократии.";
				int num11 = 0;
				int num12 = 0;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic3 in politics)
				{
					if (politic3.traits[0] == 1 || politic3.traits[0] == 2)
					{
						num11 += politic3.power;
					}
					else if (politic3.traits[0] == 0)
					{
						num12 += politic3.power;
					}
				}
				if (GlobalScript.inst.gameState.data[1] >= 650 && num11 > num12)
				{
					fake_text[1] = "Атаковать консерваторов на пленуме КПК и продвигать активных реформаторов";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "КПК не даст вам так просто перемешать кадры";
				}
				if (GlobalScript.inst.gameState.data[1] >= 600 && num11 > num12)
				{
					fake_text[2] = "Атаковать консерваторов на пленуме КПК";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "КПК не даст вам так просто устранить их";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 70)
			{
				kolvo_variant = 2;
				int num13 = 0;
				int num14 = 0;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic4 in politics)
				{
					if (politic4.traits[0] == 1 || politic4.traits[0] == 2)
					{
						num13 += politic4.power;
					}
					else if (politic4.traits[0] == 0)
					{
						num14 += politic4.power;
					}
				}
				fake_text[0] = "Ничего не делать. Разные взгляды - залог демократии.";
				if (GlobalScript.inst.gameState.data[1] >= 800 && num14 > num13)
				{
					fake_text[1] = "Атаковать реформаторов и умеренных на пленуме КПК";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Реформаторы так просто не сдадутся!";
				}
				if (GlobalScript.inst.gameState.data[1] >= 700 && GlobalScript.inst.gameState.data[90] != 0)
				{
					fake_text[2] = "Заручиться поддержкой части умеренных и атаковать реформаторов на пленуме";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Умеренные не пойдут с нами на соглашение";
				}
				fake_text[3] = "Арестовать лидеров реформаторов и начать кампанию против их сторонников. Всё по заветам Мао!";
			}
			else if (GlobalScript.inst.gameState.number_event == 71)
			{
				kolvo_variant = 3;
				fake_text[0] = "Пусть продолжают партизанить, нам этого пока достаточно";
				if (GlobalScript.inst.gameState.influencePRC >= 100 && GlobalScript.inst.gameState.allcountries[19].Torg)
				{
					fake_text[1] = "Добиться включения наксалитов в местные органы власти в обмен на прекращение вооружённой борьбы";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Они не станут с нами договариваться";
				}
				if (!GlobalScript.inst.gameState.allcountries[19].Torg && GlobalScript.inst.gameState.war == 0 && !GlobalScript.inst.gameState.allcountries[15].cw)
				{
					fake_text[2] = "Готовьтесь к войне. Ввести войска.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мы не для того налаживали отношения, чтобы сейчас развязывать войну!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 72)
			{
				kolvo_variant = 3;
				fake_text[0] = "Удачи им и хорошего настроения";
				if (GlobalScript.inst.gameState.data[91] == 1)
				{
					fake_text[1] = "Оказать помощь левому крылу (-6 агентов, -10 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Джаната нас не послушает";
				}
				if (GlobalScript.inst.gameState.data[91] == 1)
				{
					fake_text[2] = "Оказать помощь правому крылу (-6 агентов, -10 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Джаната нас не послушает";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 73)
			{
				kolvo_variant = 4;
				fake_text[0] = "Война - это ад";
				UnityEngine.Object.Destroy(galka_stuk[1]);
				fake_text[1] = "Война, война никогда не меняется";
				UnityEngine.Object.Destroy(galka_stuk[2]);
				fake_text[2] = "Война - это мир";
				UnityEngine.Object.Destroy(galka_stuk[3]);
				fake_text[3] = "Хочешь мира, готовься к войне";
			}
			else if (GlobalScript.inst.gameState.number_event == 74)
			{
				kolvo_variant = 5;
				if (GlobalScript.inst.gameState.data[90] == 0)
				{
					fake_text[0] = "Пленум одобряет этот вариант";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Это невозможно";
				}
				if (GlobalScript.inst.gameState.data[90] == 1)
				{
					fake_text[1] = "Пленум одобряет этот вариант";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Это невозможно";
				}
				if (GlobalScript.inst.gameState.data[90] == 2)
				{
					fake_text[2] = "Пленум одобряет этот вариант";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Это невозможно";
				}
				fake_text[3] = "Чего вы тут понаписали?! Текст отправить на доработку!";
				if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[4] = "Вопрос о \"Решении\" снимается с повестки дня по просьбе Председателя";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "Этот вопрос слишком важен для КПК, чтобы снимать его с повестки.";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 75)
			{
				kolvo_variant = 4;
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[0] = "Осудим авианалет и предложим Хусейну расширить сотрудничество (-8 из бюджета).";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Саддам Хусейн - авторитарист и шовинист. Нам незачем его поддерживать!";
				}
				fake_text[1] = "А нам-то какое дело? Пускай Саддам сам разбирается...";
				if (GlobalScript.inst.gameState.data[12] >= 600 && GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Поможем Ираку возобновить атомную программу. Пусть империализм содрогнется! (-15 из бюджета, -10 агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Ираку - атомную бомбу?! Вы развязать Третью мировую войну хотите?";
				}
				if ((GlobalScript.inst.gameState.data[56] > 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[3] = "Одобрим авианалет и осудим Хусейна за милитаризм и шовинизм.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Мы не можем оправдать поступок сионистов!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 76)
			{
				kolvo_variant = 4;
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[0] = "Дипломатически поддержим косовских сепаратистов, но не более того";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Это не наша проблема";
				}
				if (((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.allcountries[20].proprc)
				{
					fake_text[1] = "Предложим Албании свое содействие в отрыве Косово от Югославии (-5 агентов -5 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Зачем нам помогать Албании?";
				}
				fake_text[2] = "Не вмешиваемся";
				if (GlobalScript.inst.gameState.data[9] >= 100)
				{
					fake_text[3] = "Окажем помощь косовским сепаратистам спецслужбами и деньгами (-10 агентов -10 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Дела Югославии нас не интересуют";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 77)
			{
				kolvo_variant = 3;
				if (((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[9] >= 80)
				{
					fake_text[0] = "Помочь Шеху организовать переворот (-8 агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "У нас не хватит ресурсов";
				}
				fake_text[1] = "Пусть они сами разбираются";
				if (GlobalScript.inst.gameState.allcountries[20].proprc || (GlobalScript.inst.gameState.allcountries[20].econ && GlobalScript.inst.gameState.data[60] == 0))
				{
					fake_text[2] = "Поддержать Ходжу";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Зачем нам поддерживать Ходжу после того, как он от нас отвернулся?";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 78)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.data[22] >= 80 && ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Спровоцировать волнения и поддержать маоистов (-10 агентов, -8 сила армии)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Оно не стоит наших сил";
				}
				fake_text[1] = "Нас это не касается";
				if (GlobalScript.inst.gameState.data[6] < 800 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Поздравить Маркоса после его победы и попытаться наладить сотрудничество";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не нужно сотрудничество с американскими марионетками";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 79)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.empires[1].relations > 500 && GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[0] = "Призвать соцлагерь совместными силами помочь Румынии (-10 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Соцлагерь не будет нас слушать";
				}
				fake_text[1] = "Сам набрал долгов - пусть сам и выплачивает";
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Оказать материальную помощь Румынии (-30 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Румыния не стоит таких трат";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 80)
			{
				kolvo_variant = 3;
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[0] = "Никакого \"культа личности\" упоминать не будем и проведем съезд мирно.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Пора сказать партии правду!";
				}
				if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || GlobalScript.inst.gameState.data[15] > 7)
				{
					fake_text[1] = "Вскользь упомянем об \"отдельных ошибках\" Мао, под предлогом борьбы с которыми начнем осторожный отход от него.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Никакой критики Мао!";
				}
				if ((GlobalScript.inst.gameState.data[56] > 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Задействуем опыт Хрущева - там получилось, и у нас получится!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Вы с ума сошли - действовать, как Хрущев?!!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 81)
			{
				kolvo_variant = 5;
				if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7) || (GlobalScript.inst.gameState.data[56] == 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[0] = "Окажем Венгрии эк. помощь без предварительных условий (-35 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Мы не настолько богаты, чтобы спонсировать кадаристов";
				}
				if (GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[1] = "Используем проблемы ВНР для дискредитации рыночных реформ";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Пример Венгрии - не доказательство провала реформ";
				}
				if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Предложим ВНР эк. помощь, но в обмен на реабилитацию группы Биску (-15 из бюджета, -8 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Вряд ли это нам на пользу";
				}
				if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[3] = "Всеми силами поддержим реабилитацию группы Биску в обмен на принятие на себя венгерского госдолга (-45 Денег, -10 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Это слишком радикально для нас!";
				}
				fake_text[4] = "Проигнорируем это";
			}
			else if (GlobalScript.inst.gameState.number_event == 82)
			{
				kolvo_variant = 1;
				fake_text[0] = "Кто победит - военный режим Аргентины или ослабленная и далёкая Британия?";
			}
			else if (GlobalScript.inst.gameState.number_event == 83)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Организуем утечку информации в ЦК КПСС и дискредитируем Кулакова. (-5 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Это слишком опасно!";
				}
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[1] = "Опубликуем разоблачительные материалы о Кулакове в наших СМИ. (-2 Денег)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам это ни к чему";
				}
				fake_text[2] = "Прибережем это на будущее...";
			}
			else if (GlobalScript.inst.gameState.number_event == 84)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 80 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Автомобильная катастрофа - выбор профессионалов! (-8 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Это слишком опасно!";
				}
				fake_text[1] = "Выходим на контакт с белорусскими партийцами и через них передаем Суслову компромат на Машерова. (-5 Денег)";
				fake_text[2] = "Оставим его в покое.";
			}
			else if (GlobalScript.inst.gameState.number_event == 85)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Используем все усилия для дискредитации Кунаева, как только в республике начнутся беспорядки. (-10 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Это слишком опасно!";
				}
				if (GlobalScript.inst.gameState.relres && ((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[1] = "Упредим его и предупредим о готовящихся провокациях ЦК КПСС. (-3 Агентa)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У нас недостаточно хорошие отношения с Брежневым, чтобы сообщить ему об этом";
				}
				fake_text[2] = "Дела Советов нас не волнуют.";
			}
			else if (GlobalScript.inst.gameState.number_event == 86)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Поможем главе КГБ уйти в мир иной, списав это на отказ почек. КГБ УССР справится. (-10 Агентов, -5 Денег)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Это слишком опасно!";
				}
				if (GlobalScript.inst.gameState.relres)
				{
					fake_text[1] = "Суслов и Щербицкий созывают Пленум ЦК и атакуют на нем Андропова при нашей информационной поддержке. (-7 Денег)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит влияния на КПСС";
				}
				fake_text[2] = "Это слишком опасно!";
			}
			else if (GlobalScript.inst.gameState.number_event == 87)
			{
				kolvo_variant = 1;
				fake_text[0] = "Ещё одна война на Ближнем Востоке...";
			}
			else if (GlobalScript.inst.gameState.number_event == 88)
			{
				kolvo_variant = 2;
				fake_text[0] = "Поздравим Мугабе с победой и вышлем ему материальную помощь (-5 из бюджета)";
				fake_text[1] = "Подружиться с ним мы всегда успеем";
			}
			else if (GlobalScript.inst.gameState.number_event == 89)
			{
				kolvo_variant = 4;
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.empires[1].leaders[3].support > 0)
				{
					fake_text[0] = "Поддержать Андропова";
				}
				else if (GlobalScript.inst.gameState.empires[1].leaders[3].support <= 0)
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Нам не хватит влияния на КПСС";
				}
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.empires[1].leaders[1].support != 0)
				{
					fake_text[1] = "Поддержать Щербицкого";
				}
				else if (GlobalScript.inst.gameState.empires[1].leaders[1].support == 0)
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит влияния на КПСС";
				}
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100)
				{
					fake_text[2] = "Поддержать Черненко";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не хватит влияния на КПСС";
				}
				fake_text[3] = "Не вмешиваться и ждать";
			}
			else if (GlobalScript.inst.gameState.number_event == 90)
			{
				kolvo_variant = 4;
				if (GlobalScript.inst.gameState.data[9] >= 40 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Договоримся с Триадами на выгодных для них условиях. (-4 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Мы не можем вести переговоры с ОПГ!";
				}
				if (GlobalScript.inst.gameState.data[9] >= 30 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[1] = "Тактический союз с синдикатами нам не помешает. Но от чистки это их не спасет. (-2 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Никаких компромиссов с преступным миром!";
				}
				fake_text[2] = "Какое нам дело до этих бандитов?";
				if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.data[16] <= 13 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[3] = "По организованной преступности в южных провинциях страны пора нанести мощный удар! (-8 Агентов)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Это - вполне честные бизнесмены, поддерживающие реформы и открытость. Мы не имеем права их в чем-то подозревать.";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 91)
			{
				kolvo_variant = 3;
				fake_text[0] = "Осудить северокорейский терроризм";
				fake_text[1] = "Осудить южнокорейскую провокацию";
				fake_text[2] = "Промолчать";
			}
			else if (GlobalScript.inst.gameState.number_event == 92)
			{
				kolvo_variant = 5;
				fake_text[0] = "Инвестировать в модернизацию промышленности (-1 из бюджета)";
				fake_text[1] = "Продолжить усиленную механизацию сельского хозяйства (-1 из бюджета)";
				fake_text[2] = "Вложить средства в улучшение качества услуг (-1 из бюджета)";
				fake_text[3] = "Ориентировать пятилетку на развитие научных разработок (-1 из бюджета)";
				fake_text[4] = "Направить силы на равномерное развитие экономики (-1 из бюджета)";
			}
			else if (GlobalScript.inst.gameState.number_event == 93)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[9] >= 40)
				{
					fake_text[0] = "Поддержать ПАСОК";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Нам не хватит сил";
				}
				if (GlobalScript.inst.gameState.data[9] >= 40)
				{
					fake_text[1] = "Поддержать Новую демократию";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит сил";
				}
				fake_text[2] = "Не вмешиваться";
			}
			else if (GlobalScript.inst.gameState.number_event == 94)
			{
				kolvo_variant = 4;
				fake_text[0] = "Это контрреволюционный мятеж, и предатели за него ответят! Соедините меня с Генштабом...";
				fake_text[1] = "Блокировать площадь Народной милицией и попытаться уговорить митингующих разойтись.";
				fake_text[2] = "Уйти в отставку. Пусть Партия сама решит, кто достоин возглавить страну в это сложное время.";
				fake_text[3] = "Выполнить требования митингующих.";
			}
			else if (GlobalScript.inst.gameState.number_event == 95)
			{
				kolvo_variant = 4;
				fake_text[0] = "Отказываемся от марксизма-маоизма-сяопизма в пользу еврокоммунизма, по образцу КПЯ.";
				fake_text[1] = "Возвращаемся к социал-демократии с китайской спецификой по заветам Чэнь Дусю.";
				fake_text[2] = "Принимаем левый китайский национализм, как завещал великий Сунь Ятсен.";
				fake_text[3] = "Почему это мы должны выполнять требования каких-то уличных хулиганов?";
			}
			else if (GlobalScript.inst.gameState.number_event == 96)
			{
				kolvo_variant = 4;
				fake_text[0] = "Готовим свободные выборы в ВСНП, максимально ограничив другие партии, но другие требования придётся выполнить";
				fake_text[1] = "Не так страшны выборы, как буржуазные \"свободы\". Обойдутся без них.";
				fake_text[2] = "Не так страшны выборы, как оставить религию без присмотра. Обойдутся без неё.";
				fake_text[3] = "Если мы хотим, чтобы народ нас любил, надо выполнить все его требования!";
			}
			else if (GlobalScript.inst.gameState.number_event == 97)
			{
				kolvo_variant = 2;
				fake_text[0] = "Начинаем масштабное внедрение автоматизированных систем";
				fake_text[1] = "Спешка никогда хорошо не заканчивалась, пусть внедряют постепенно и не всё сразу";
			}
			else if (GlobalScript.inst.gameState.number_event == 98)
			{
				if (!GlobalScript.inst.dlc[3])
				{
					kolvo_variant = 3;
				}
				else
				{
					kolvo_variant = 4;
				}
				if (!GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text[0] = "Признать действующую власть и отправить послов.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Мы не можем поддерживать узурпаторов!";
				}
				fake_text[1] = "Проигнорировать военный переворот.";
				if (GlobalScript.inst.gameState.influencePRC >= 100 && GlobalScript.inst.gameState.data[9] >= 30)
				{
					fake_text[2] = "Предложить гуманитарную помощь.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не хватит ресурсов и влияния";
				}
				if (GlobalScript.inst.gameState.data[9] >= 70 && GlobalScript.inst.gameState.modifies[41].active)
				{
					fake_text[3] = string.Format(GlobalScript.inst.new_events_text[1288], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
				}
				else if (!GlobalScript.inst.gameState.modifies[41].active)
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = string.Format(GlobalScript.inst.new_events_text[1289], 7f);
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = string.Format(GlobalScript.inst.new_events_text[567], 7f);
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 114)
			{
				kolvo_variant = 1;
				fake_text[0] = "Мы все затаились в ожидании...";
			}
			else if (GlobalScript.inst.gameState.number_event == 117)
			{
				kolvo_variant = 3;
				if (!GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[0] = "Ничего. Нас в конце концов не приглашали";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Надо ехать";
				}
				if (GlobalScript.inst.gameState.relres || GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[1] = "Послать китайскую делегацию на похороны";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нас никто туда не пустит";
				}
				if (GlobalScript.inst.gameState.relres || GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[2] = "Наш лидер лично отправится попрощаться с Юрием Владимировичем";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Вы не можете ехать лично!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 99)
			{
				kolvo_variant = 4;
				if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Окажем помощь ортодоксам, в борьбе против ревизионизма";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "У нас не хватит сил";
				}
				if (GlobalScript.inst.gameState.data[9] >= 40)
				{
					fake_text[1] = "Поддержим умеренных реформаторов в модернизации социализма";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "У нас не хватит сил";
				}
				if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] >= 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Способствовать приходу к власти прозападных либералов";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мы не можем их поддержать";
				}
				fake_text[3] = "Останемся в стороне";
			}
			else if (GlobalScript.inst.gameState.number_event == 100)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.influencePRC >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[0] = "Спровоцировать антиправительственные митинги, поддержав оппозицию";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "У нас не хватит сил";
				}
				fake_text[1] = "У нас и своих проблем полно.";
				if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Отправить средства в поддержку правительства.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мы не можем их поддержать";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 102)
			{
				kolvo_variant = 4;
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
				{
					fake_text[0] = "Поддержать Горбачёва";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "Нам не хватит влияния на КПСС";
				}
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
				{
					fake_text[1] = "Поддержать Романова";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Нам не хватит влияния на КПСС";
				}
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[9] >= 100)
				{
					fake_text[2] = "Поддержать Гришина";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Нам не хватит влияния на КПСС";
				}
				fake_text[3] = "Не вмешиваться и ждать";
			}
			else if (GlobalScript.inst.gameState.number_event == 104)
			{
				kolvo_variant = 3;
				fake_text[0] = "Отправить делегацию на фестиваль";
				fake_text[1] = "Не отправлять";
				fake_text[2] = "Провести собственный фестиваль для союзных стран (-2 из бюджета)";
			}
			else if (GlobalScript.inst.gameState.number_event == 105)
			{
				kolvo_variant = 3;
				fake_text[0] = "Ничего не делать";
				if ((GlobalScript.inst.gameState.allcountries[15].Torg || GlobalScript.inst.gameState.allcountries[20].Torg) && GlobalScript.inst.gameState.data[9] >= 60)
				{
					fake_text[1] = "Завербовать группу косовских албанцев и устроить теракт (-6 агентурных сетей)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Наша разведка не справится с этим";
				}
				if (!GlobalScript.inst.gameState.allcountries[20].Torg && !GlobalScript.inst.gameState.allcountries[20].proprc)
				{
					fake_text[2] = "Попытаться наладить отношения с новым руководством (-3 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Китайско-албанские отношения и так в норме";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 106)
			{
				kolvo_variant = 3;
				fake_text[0] = "Нас это не касается";
				if (GlobalScript.inst.gameState.data[9] >= 100)
				{
					fake_text[1] = "Устроить теракт и сорвать конференцию";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Наша разведка не справится с этим";
				}
				fake_text[2] = "Поддержать формирование";
			}
			else if (GlobalScript.inst.gameState.number_event == 109)
			{
				kolvo_variant = 3;
				fake_text[0] = "Ничего не делать";
				if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.influencePRC >= 200)
				{
					fake_text[1] = "Отправить военную и гуманитарную помощь Сомали (-8 из бюджета, -5 агентурных сетей, -5 сила армии)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Мы не можем помочь Сомали";
				}
				if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.influencePRC >= 200)
				{
					fake_text[2] = "Организовать партийный переворот против Барре (-8 агентурных сетей)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "У нас нет сил отвлекаться на это";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 110)
			{
				kolvo_variant = 4;
				fake_text[0] = "Подождём ещё пару годков... или больше...";
				fake_text[1] = "Объявить о курсе на автоматизацию производства и создать комиссию по её внедрению (-10 из бюджета)";
				if (GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					fake_text[2] = "Начать автоматизацию и пригласить советских учёных";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Советы не станут нам помогать";
				}
				if (GlobalScript.inst.gameState.empires[0].relations >= 600 && GlobalScript.inst.gameState.data[6] <= 800 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.modifies[17].active)
				{
					fake_text[3] = "Принимаемся за работу, западные специалисты нам помогут!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Просить помощи у Запада? Вы серьёзно?";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 111)
			{
				kolvo_variant = 4;
				fake_text[0] = "Отказаться от борьбы и уйти в отставку";
				if (GlobalScript.inst.gameState.data[3] >= 900 && GlobalScript.inst.gameState.data[5] >= 900 && GlobalScript.inst.gameState.modifies[3].active)
				{
					fake_text[1] = "Призвать народные массы на борьбу с партократией";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Народу не нужна новая культурная революция!";
				}
				if (GlobalScript.inst.gameState.data[9] >= 400)
				{
					fake_text[2] = "Арестовать заговорщиков и начать гонения против самых инициативных партократов (-40 агентурных сетей)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "МГБ не поддержит нас!";
				}
				if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[3] = "Мобилизовать лояльных офицеров против заговорщиков";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Офицеры не спасут нас";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 112)
			{
				kolvo_variant = 3;
				fake_text[0] = "Выделить средства на разработку системы защиты (-25 из бюджета)";
				if (GlobalScript.inst.gameState.empires[1].relations >= 800 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.modifies[3].active)
				{
					fake_text[1] = "Профинансировать разработку и запросить помощь специалистов из СССР (-25 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Советы не станут нам помогать";
				}
				if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[2] = "Похоже,  Китай не готов к таким переменам, необходимо замедлить автоматизацию";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "Мы не можем отказываться от наших достижений!";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 113)
			{
				kolvo_variant = 5;
				fake_text[0] = "Какое нам дело до Югославии? Пусть титоисты сами разбираются со своими проблемами!";
				if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[1] = "Предложим Югославии реструктуризацию её долгов при условии отказа от плана реформ (-5 агентов, -20 из бюджета).";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Зачем нам реструктуризировать их долги?";
				}
				if (((GlobalScript.inst.gameState.influencePRC >= 150 && GlobalScript.inst.gameState.allcountries[1].isSEV) || (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.influencePRC >= 250)) && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[2] = "Присоединимся к предложению СССР.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[2]);
					fake_text[2] = "У нас недостаточно влияния, чтобы Советский Союз и Югославия прислушались к нам";
				}
				if (GlobalScript.inst.gameState.influencePRC >= 300 && GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[3] = "Поддержим группу военных во главе с Велько Кадиевичем и Бранко Мамулой";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Поддержать военную хунту? В Югославии-то? Нонсенс!";
				}
				if ((GlobalScript.inst.gameState.influencePRC >= 200 || GlobalScript.inst.gameState.allcountries[51].dev > 0) && GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] >= 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
				{
					fake_text[4] = "Одобрим предложение США.";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[4]);
					fake_text[4] = "У нас недостаточно влияния, чтобы США и Югославия прислушались к нам";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 115)
			{
				kolvo_variant = 3;
				fake_text[0] = "Это не наше дело";
				if ((GlobalScript.inst.gameState.data[56] >= 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
				{
					fake_text[1] = "Пойти на соглашение с наркоторговцами (-1 агентурная сеть)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Китайский народ не для того боролся с опиумными магнатами, чтобы мы с ними якшались.";
				}
				fake_text[2] = "Помочь союзным странам в борьбе против наркоторговцев (-2 агентурные сети, -2 сила армии)";
			}
			else if (GlobalScript.inst.gameState.number_event == 435)
			{
				kolvo_variant = 3;
				fake_text[2] = GlobalScript.inst.new_events_text[1651];
				if (GlobalScript.inst.gameState.data[9] >= 10 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50)
				{
					fake_text[0] = GlobalScript.inst.new_events_text[1649];
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = GlobalScript.inst.new_events_text[1652];
				}
				fake_text[1] = GlobalScript.inst.new_events_text[1650];
			}
			else if (GlobalScript.inst.gameState.number_event == 436)
			{
				kolvo_variant = 3;
				fake_text[0] = GlobalScript.inst.new_events_text[1658];
				fake_text[1] = GlobalScript.inst.new_events_text[1659];
				fake_text[2] = GlobalScript.inst.new_events_text[1660];
			}
			else if (GlobalScript.inst.gameState.number_event == 116)
			{
				kolvo_variant = 3;
				fake_text[0] = "Оставим всё как есть";
				if (GlobalScript.inst.gameState.data[6] <= 500 && GlobalScript.inst.gameState.empires[0].relations >= 600)
				{
					fake_text[1] = "Время для долгожданного объединения!";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Они не готовы пойти на такое соглашение";
				}
				fake_text[2] = "Взаимно признаем друг друга и покончим с враждой!";
			}
			else if (GlobalScript.inst.gameState.number_event == 103)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.allcountries[1].okb && GlobalScript.inst.gameState.allcountries[0].isEU)
				{
					fake_text[0] = "Учредить аналог Шенгенского соглашения для членов нашего военного альянса (стоит дешевле)";
				}
				else if (GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.allcountries[0].isEU)
				{
					fake_text[0] = "Учредить аналог Мадридского соглашения для членов нашего военного альянса (стоит дешевле)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "У нас нет военного альянса";
				}
				if (GlobalScript.inst.gameState.allcountries[0].isEU)
				{
					fake_text[1] = "Учредить аналог Шенгенского соглашения для членов всех наших альянсов";
				}
				else
				{
					fake_text[1] = "Учредить аналог Шенгенского соглашения для членов всех наших альянсов";
				}
				fake_text[2] = "Ничего не делать";
			}
			else if (GlobalScript.inst.gameState.number_event == 107)
			{
				kolvo_variant = 5;
				if (GlobalScript.inst.gameState.data[22] >= 200 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
				{
					fake_text[0] = "Ввести войска и вернуть страну к нашему курсу (-20 сила армии, -3 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "У нашей армии не хватит сил и полномочий";
				}
				if (GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
				{
					fake_text[1] = "Организовать переворот в пользу лояльных нам сил (-10 агентов, -3 из бюджета)";
				}
				else if (GlobalScript.inst.gameState.data[9] >= 200 && !GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
				{
					fake_text[1] = "Организовать переворот в пользу лояльных нам сил (-20 агентов, -6 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "Наша разведка не справится с этим";
				}
				fake_text[2] = "Привязать страну экономически, выделив финансовую помощь и выгодный кредит (-10 из бюджета)";
				if (GlobalScript.inst.gameState.data[9] >= 50)
				{
					fake_text[3] = "Не препятствовать независимой политике в обмен на сохранение членства в нашем блоке (-5 агентов, -1 из бюджета)";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[3]);
					fake_text[3] = "Наша разведка не справится с этим";
				}
				fake_text[4] = "Мы должны уважать их выбор";
			}
			else if (GlobalScript.inst.gameState.number_event == 5)
			{
				kolvo_variant = 3;
				if (GlobalScript.inst.gameState.data[14] <= 3)
				{
					fake_text[0] = "";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[0]);
					fake_text[0] = "";
				}
				if (GlobalScript.inst.gameState.data[14] > 3 && GlobalScript.inst.gameState.data[6] <= 60)
				{
					fake_text[1] = "";
				}
				else
				{
					UnityEngine.Object.Destroy(galka_stuk[1]);
					fake_text[1] = "";
				}
				fake_text[2] = "";
			}
			else
			{
				kolvo_variant = 1;
				fake_text[0] = "Не готов ответ";
			}
			for (int j = 0; j < 6; j++)
			{
				if (j < kolvo_variant)
				{
					otveti[j].text = Text(fake_text[j], 55);
				}
				else if (galka_stuk[j] != null)
				{
					UnityEngine.Object.Destroy(galka_stuk[j]);
					UnityEngine.Object.Destroy(otveti[j]);
				}
			}
		}
		else if (nazad)
		{
			Azkaban();
		}
		else if (first && this_otvet != 0)
		{
			GlobalScript.inst.gameState.number_otvet = this_otvet;
			SceneManager.LoadScene("Results");
		}
	}

	private void Azkaban()
	{
		this_otvet = 0;
		if (nazad)
		{
			Vpered.GetComponent<doneventscript>().this_otvet = 0;
			Vpered.GetComponent<doneventscript>().first = false;
			Vpered.GetComponent<SpriteRenderer>().sprite = nenavel;
			GetComponent<SpriteRenderer>().sprite = nenavel;
		}
		Nazad.SetActive(value: false);
		Galkasum.SetActive(value: false);
		string text = "";
		string text2 = "";
		if ((GlobalScript.inst.gameState.number_event >= 0 && PlayerPrefs.GetInt("language") == 0) || (PlayerPrefs.GetInt("language") == 1 && GlobalScript.inst.gameState.number_event >= 120 && GlobalScript.inst.gameState.number_event != 435 && GlobalScript.inst.gameState.number_event != 436))
		{
			thisObject.GetComponent<EventsSecond>().TextOfEvents(ref text2, ref text);
		}
		else if (PlayerPrefs.GetInt("language") == 0)
		{
			if (GlobalScript.inst.gameState.number_event == 3)
			{
				text2 = " 舵 手 逝 世";
				text = " 糟 糕 的 事 情 发 生 了 。9 月9 日0 时10 分 ， 在 两 次 心 脏 病 发 作 后 ， 中 国 人 民 的 伟 大 领 袖 和 导 师 ， 毛 主 席 去 世 了 ， 享 年83 岁 。 尽 管 人 民 和 党 还 在 悲 伤 中 ， 我 们 需 要 召 集 治 丧 委 员 会 ， 决 定 如 何 送 主 席 最 后 一 程 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 4)
			{
				text2 = " 阴 谋";
				text = " 根 据 最 近 得 到 的 信 息 ， 几 名 对 你 领 导 不 满 的 资 深 党 员 决 定 将 你 在 下 次 大 会 上 移 除 出 中 央 。 如 果 不 想 重 蹈 赫 鲁 晓 夫1964 年 的 覆 辙 的 话 ， 你 需 要 马 上 做 些 什 么 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 5)
			{
				text2 = " 民 众 不 满";
				text = " 人 民 对 你 政 策 不 满 ， 在 全 国 范 围 内 举 行 了 大 规 模 集 会 ， 在 广 场 搭 起 帐 篷 营 地 ， 分 发 传 单 ， 甚 至 冲 击 地 方 政 府 建 筑 。 来 自 不 同 团 体 的 抗 议 者 对 你 政 府 不 同 的 方 面 不 满 ， 但 一 致 要 求 体 制 民 主 化 ， 以 限 制 你 在 国 家 政 治 的 影 响 力 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 6)
			{
				text2 = " 低 生 活 水 平";
				text = " 你 的 政 策 导 致 了 这 个 国 家 的 生 活 水 平 的 灾 难 性 下 降 ， 人 民 生 活 在 恶 劣 的 条 件 下 ， 绝 大 多 数 人 甚 至 没 有 能 力 购 买 基 本 必 需 品 。 当 然 ， 这 导 致 了 许 多 抗 议 并 要 求 我 们 解 决 这 场 危 机 。 由 于 士 兵 们 非 常 不 乐 意 去 逮 捕 抗 议 者 ， 所 以 我 们 不 能 指 望 军 队 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 7)
			{
				text2 = " 外 交 危 机";
				text = " 我 们 与 美 国 的 关 系 达 到 了 极 低 的 水 平 。 他 们 的 宣 传 已 经 开 始 指 责 我 们 犯 下 了 可 能 的 和 不 可 能 的 罪 行 ， 我 们 的 情 报 部 门 告 诉 我 们 五 角 大 楼 中 的 骚 动 以 及 东 南 亚 的 美 国 军 事 基 地 的 活 动 。 如 果 我 们 不 想 要 打 第 三 次 世 界 大 战 的 话 ， 就 需 要 尽 快 纠 正 这 种 情 况 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 8)
			{
				text2 = " 外 交 危 机";
				text = " 我 们 与 苏 联 的 关 系 达 到 了 极 低 的 水 平 。 他 们 的 宣 传 已 经 开 始 指 责 我 们 犯 下 了 可 能 的 和 不 可 能 的 罪 行 ， 我 们 的 情 报 部 门 告 诉 我 们 苏 联 总 参 谋 部 中 的 骚 动 以 及 苏 军 在 边 境 上 的 活 动 。 如 果 我 们 不 想 要 打 第 三 次 世 界 大 战 的 话 ， 就 需 要 尽 快 纠 正 这 种 情 况 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 9)
			{
				text2 = " 西 藏 的 分 离 主 义";
				text = " 在 自 由 主 义 者 和 民 族 主 义 者 的 鼓 励 下 ， 西 藏 自 治 区 居 民 举 行 了 群 众 性 的 要 求 独 立 和 脱 离 中 华 人 民 共 和 国 的 示 威 活 动 ， 并 逐 渐 演 变 为 骚 乱 。 人 们 要 求 从 “1950 年 的 占 领 ” 中 “ 解 放 ” ， 大 多 数 藏 族 人 支 持 他 们 。 然 而 ， 有 些 人 只 是 满 足 于 更 高 度 的 自 治 的 要 求 ， 这 是 我 们 可 以 利 用 的 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 10)
			{
				text2 = " 新 疆 的 分 离 主 义";
				text = " 在 自 由 主 义 者 和 民 族 主 义 者 的 鼓 励 下 ， 新 疆 维 吾 尔 自 治 区 居 民 举 行 了 群 众 性 的 要 求 独 立 和 脱 离 中 华 人 民 共 和 国 的 示 威 活 动 ， 并 逐 渐 演 变 为 骚 乱 。 人 们 要 求 从 “1949 年 的 占 领 ” 中 “ 解 放 ” ， 大 多 数 维 吾 尔 族 人 支 持 他 们 。 但 是 ， 汉 民 族 对 他 们 有 一 种 制 衡 ， 一 些 维 吾 尔 人 只 是 满 足 于 更 高 度 的 自 治 的 要 求 ， 这 是 我 们 可 以 利 用 的 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 11)
			{
				text2 = " 工 业 衰 退";
				text = " 我 们 的 工 业 正 处 于 前 所 未 有 的 衰 退 之 中 — 一 些 工 厂 闲 置 ， 一 些 工 厂 即 将 关 闭 ， 所 有 工 厂 都 在 使 用 过 时 的 设 备 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 12)
			{
				text2 = " 农 业 衰 退";
				text = " 我 们 的 农 业 正 处 于 空 前 的 衰 退 之 中 — 即 使 在 大 跃 进 时 期 也 没 有 这 种 情 况 ！";
			}
			else if (GlobalScript.inst.gameState.number_event == 13)
			{
				text2 = " 服 务 业 衰 退";
				text = " 我 们 的 服 务 业 正 处 于 严 重 的 衰 退 之 中 — — 大 多 数 商 店 和 机 构 都 不 能 运 作 ， 即 使 是 营 业 的 商 店 服 务 质 量 也 很 差 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 14)
			{
				text2 = " 我 们 没 有 钱 ， 但 是 你 要 撑 住 啊 ！";
				text = " 我 们 的 预 算 和 储 备 金 太 少 了 。 如 果 继 续 这 样 下 去 ， 我 们 很 快 就 无 法 维 持 我 们 国 家 的 正 常 工 作 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 15)
			{
				text2 = " 柬 越 战 争";
				text = " 越 共 对 印 度 支 那 地 区 的 共 产 主 义 运 动 一 直 存 在 “ 老 子 党 ” 情 结 — — 老 挝 党 和 早 期 的 柬 埔 寨 党 一 直 都 处 于 越 南 的 控 制 之 下 。 而 高 棉 劳 动 党 在 重 建 以 来 一 直 在 执 行 独 立 路 线 ， 和 “ 听 话 的 ” 老 挝 截 然 不 同 ， 这 令 越 南 很 不 高 兴 — — 越 共 一 直 想 恢 复 对 柬 埔 寨 共 产 党 的 控 制 ， 建 立 一 个 统 一 的 社 会 主 义 印 支 。 看 起 来 越 南 的 耐 心 也 到 头 了 — — 最 近 越 南 军 队 对 柬 埔 寨 发 起 了 全 面 侵 略 ， 以 推 翻 民 主 柬 埔 寨 政 权 ， 利 用 包 括 高 棉 左 翼 异 见 者 和 流 亡 的 亲 越 派 的 柬 埔 寨 民 族 救 亡 阵 线 作 为 掩 盖 。 考 虑 到 民 主 柬 埔 寨 一 直 是 我 们 忠 实 的 盟 友 ， 帮 助 他 们 是 值 得 的 。 ";
			}
			else if (GlobalScript.inst.gameState.number_event == 16)
			{
				text2 = " 泰 国 大 选";
				text = " 在1973 年 军 政 府 垮 台 ， 权 力 移 交 给 民 选 政 府 后 ， 泰 国 进 入 了 一 段 “ 混 乱 民 主 ” 的 时 期 。 共 产 党 在 印 支 半 岛 的 胜 利 滋 长 了 左 翼 情 绪 ， 由 目 前 同 时 进 行 游 击 战 和 合 法 活 动 的 毛 主 义 泰 国 共 产 党 领 导 。 他 们 反 对 右 翼 军 队 ， 地 主 和 其 他 保 王 党 ， 这 经 常 导 致 冲 突 。 在 这 种 情 况 ， 以 及 泰 国 经 济 危 机 爆 发 的 背 景 下 ， 民 主 总 理 克 立 · 巴 莫 被 迫 提 前 举 行 选 举 。 也 许 这 是 我 们 的 机 会 ， 如 果 不 引 诱 该 国 变 色 ， 那 么 至 少 要 动 荡 帝 国 主 义 在 印 度 支 那 的 堡 垒 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 17)
			{
				text2 = " 泰 国 动 乱";
				text = " 在 社 会 动 荡 和 左 右 派 频 繁 对 抗 的 背 景 下 ， 九 月 ， 泰 国 王 室 决 定 召 回 极 右 将 军 他 侬 · 吉 滴 卡 宗 ， 这 位 前 总 理 需 要 对 其 在 位 期 间 的 血 腥 镇 压 负 责 ， 他 本 人 在1973 年 被 公 众 演 说 推 翻 。 吉 滴 卡 宗 本 人 并 不 想 参 与 政 治 ， 只 想 做 个 僧 侣 ， 但 关 于 他 的 回 归 和 与 国 王 会 面 的 官 方 公 告 还 是 引 起 了 部 分 人 的 不 满 。 总 理 巴 莫 辞 职 ， 但 被 驳 回 ， 一 波 学 生 和 工 会 示 威 的 浪 潮 席 卷 全 国 ， 其 中 一 起 发 生 在 泰 国 国 立 政 法 大 学 ， 右 翼 武 装 分 子 已 经 突 袭 了 那 里 。 根 据 我 们 的 信 息 ， 军 队 正 准 备 严 酷 镇 压 示 威 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 18)
			{
				if (GlobalScript.inst.gameState.data[82] > 7)
				{
					text2 = " 战 争 结 束 了";
					text = " 在 长 时 间 的 血 腥 冲 突 之 后 “" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + " ” 终 于 结 束 了 。 我 国 外 交 部 密 切 留 意 全 程 ， 并 已 准 备 好 为 您 汇 报 战 争 的 最 终 结 果 。 ";
				}
				else
				{
					text2 = " 战 争 结 束 了";
					text = " 在 长 时 间 的 血 腥 冲 突 之 后 “" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + " ” 终 于 结 束 了 。";
					text = ((GlobalScript.inst.gameState.data[82] == 6) ? ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 400) ? (text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。") : (text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。")) : ((GlobalScript.inst.gameState.data[82] == 2) ? ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 750) ? (text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。") : (text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。")) : ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 900 && GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 < 900) ? ((GlobalScript.inst.gameState.data[82] != 2 && GlobalScript.inst.gameState.data[82] != 4) ? (text + " 双 方 都 没 有 取 得 决 定 性 的 胜 利 ， 因 此 无 条 件 和 平 协 议 得 以 签 署 ， 使 边 界 恢 复 到 战 前 状 态 。") : (text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。")) : (text + " 最 终 ， 胜 利 属 于 " + ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 > GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2) ? GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 : GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2) + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。"))));
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 20)
			{
				text2 = " 批 邓 反 击 右 倾 翻 案 风";
				text = " 周 恩 来 的 去 世 严 重 影 响 了 他 的 得 力 助 手 邓 小 平 的 地 位 ， 没 有 前 总 理 的 庇 护 。 他 现 在 经 常 受 到 以 毛 泽 东 夫 人 江 青 为 首 的 激 进 分 子 的 攻 击 ，2 月2 日 ， 邓 小 平 被 调 到 对 外 关 系 领 域 工 作 。 在 毛 泽 东 及 其 支 持 者 的 批 准 下 ， 他 们 成 功 地 发 起 了 “ 批 邓 反 击 右 倾 翻 案 风 ” 运 动 ， 并 在 媒 体 上 对 邓 进 行 了 积 极 的 迫 害 。 值 得 注 意 的 是 ， 尽 管 毛 泽 东 对 邓 小 平 不 信 任 ， 但 他 还 没 有 参 与 到 对 他 的 迫 害 中 。 既 然 华 国 锋 和 江 青 或 邓 小 平 都 没 有 良 好 的 关 系 ， 那 我 们 该 怎 么 办 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 21)
			{
				text2 = " 周 恩 来 的 再 放 送";
				text = "1976 年3 月25 日 ， 上 海 报 纸 《 文 汇 报 》 刊 登 了 一 篇 文 章 ， 其 中 ， 已 故 的 周 恩 来 被 列 为 走 资 派 ， “ 资 本 主 义 道 路 的 支 持 者 ” 。 这 些 材 料 出 现 在 上 海 党 组 织 负 责 人 张 春 桥 的 指 导 下 ， 张 春 桥 是 江 青 最 亲 密 的 盟 友 。 文 章 还 尖 锐 地 批 评 了 邓 小 平 及 其 改 革 思 想 。 这 篇 文 章 实 际 上 是 第 一 次 公 开 谴 责 周 恩 来 对 资 本 主 义 的 同 情 ， 但 还 不 清 楚 人 民 会 对 此 作 何 反 应 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 22)
			{
				text2 = " 天 安 门 事 件";
				text = " 中 国 共 产 党 对 周 恩 来 的 多 次 抹 黑 企 图 都 不 过 是 在 人 民 群 众 里 引 起 了 反 对 。 在 正 值 清 明 节 的 四 月 四 日 ， 北 京 市 民 带 着 纪 念 周 恩 来 的 挽 联 走 进 天 安 门 广 场 到 人 民 英 雄 纪 念 碑 前 。 日 落 前 有 大 约 二 百 万 人 前 来 悼 念 ， 挽 联 堆 了 二 十 米 高 。 此 时 中 共 中 央 政 治 局 紧 急 会 议 在 毛 主 席 主 持 下 召 开 ， 会 议 通 过 了 镇 压 游 行 的 决 议 ， 你 和 北 京 市 长 吴 德 被 要 求 督 办 此 事 。 趁 夜 你 清 理 了 挽 联 ， 但 是 第 二 天 早 上 来 继 续 悼 念 的 人 民 要 求 归 还 它 们 ， 同 时 已 经 有 人 号 召 推 翻 毛 泽 东 与 江 青 的 领 导 并 回 到 真 正 的 马 克 思 列 宁 主 义 革 命 路 线 上 来 。 江 青 要 求 强 行 镇 压 ， 但 是 吴 德 看 起 来 并 不 想 动 手 。 无 论 如 何 ， 决 定 权 在 你 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 23)
			{
				text2 = " 唐 山 大 地 震";
				text = "7 月28 日 ，3 时42 分 ， 河 北 省 唐 山 市 发 生 了 震 级8.2 级 的 地 震 ， 完 全 摧 毁 了 整 个 城 市 。 距 唐 山 西140 公 里 的 天 津 和 北 京 也 遭 到 破 坏 。 最 高 震 级 为7.1 级 的 几 波 余 震 ， 导 致 了 更 高 的 伤 亡 。 根 据 初 步 数 据 ， 有20 —60 万 人 死 于 地 震 。 据 上 海 市 地 震 局 局 长 张 俊 所 讲 ， 巨 大 破 坏 的 主 要 原 因 是 建 筑 建 造 时 缺 乏 必 要 的 抗 震 措 施 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 24)
			{
				text2 = " 变 革 之 风 ？";
				text = " 在 毛 主 席 死 后 ， 你 终 于 掌 握 了 权 力 ， 是 时 候 勾 勒 未 来 的 蓝 图 了 。 党 内 的 派 系 有 着 各 式 各 样 的 图 纸 。 保 守 的 毛 派 想 要 继 续 毛 泽 东 的 政 策 ， 但 不 包 括 那 些 有 问 题 的 实 验 ， 也 就 意 味 着 结 束 文 革 和 政 治 运 动 。 改 革 派 们 当 然 要 求 结 束 文 革 并 开 始 大 规 模 改 革 毛 主 席 曾 试 图 干 涉 但 失 败 的 中 国 经 济 。 所 有 温 和 派 都 相 信 中 国 需 要 变 革 ， 有 些 要 求 结 束 文 革 并 进 行 小 规 模 经 济 整 顿 ， 另 一 些 人 同 样 要 求 市 场 经 济 深 度 改 革 。 然 而 激 进 的 毛 派 并 不 打 算 和 文 革 分 道 扬 镳 ， 他 们 顶 着 路 线 错 误 的 威 胁 要 求 继 续 文 革 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 25)
			{
				text2 = " 四 人 帮";
				text = " 现 在 我 们 的 毛 泽 东 主 席 已 经 去 世 了 ， 中 国 共 产 党 内 又 爆 发 了 党 内 斗 争 。 一 方 面 ， 四 位 伟 大 舵 手 的 亲 密 支 持 者 主 张 继 续 进 行 文 化 大 革 命 ， 但 是 正 常 化 苏 联 关 系 。 江 青 是 毛 泽 东 的 配 偶 和 中 央 文 革 小 组 的 领 导 ， 王 洪 文 是 其 中 的 一 个 重 要 成 员 ， 在 第 十 次 党 代 会 上 ， 他 实 际 上 被 宣 布 是 毛 的 继 承 者 ， 还 有 张 春 桥 和 姚 文 元 。 另 一 方 面 ， 在 上 世 纪70 年 代 初 实 行 半 市 场 化 改 革 的 遭 贬 谪 的 思 想 家 邓 小 平 领 导 的 改 革 派 力 量 正 在 壮 大 ， 他 们 支 持 尽 早 结 束 文 化 大 革 命 ， 以 毫 不 动 摇 的 反 苏 路 线 并 同 时 开 始 大 规 模 的 市 场 化 改 革 。 此 外 ， 左 翼 激 进 分 子 目 前 是 我 国 政 府 的 心 腹 大 患 ， 但 要 消 灭 他 们 ， 就 必 须 与 国 防 部 长 叶 剑 英 等 改 革 派 结 盟 。 也 许 与 激 进 分 子 谈 判 并 利 用 他 们 来 对 抗 改 革 派 更 好 一 些 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 26)
			{
				text2 = " 虚 弱 的 联 盟";
				text = " 华 国 锋 和 激 进 左 翼 之 间 不 稳 定 的 合 作 关 系 正 在 破 裂 。 许 多 较 为 温 和 的 党 员 对 这 种 关 系 的 明 确 不 满 大 大 削 弱 了 现 任 主 席 的 地 位 ， 他 在 解 决 这 些 问 题 上 的 软 弱 态 度 可 能 导 致 无 法 预 料 的 后 果 。 此 外 ， 四 人 帮 想 要 追 随 毛 的 路 线 ， 对 党 内 的 反 对 派 和 修 正 主 义 者 采 取 更 果 断 的 措 施 ， 同 时 以 此 进 一 步 扩 大 他 们 的 权 力 。 如 果 这 种 情 况 继 续 下 去 ， 华 国 锋 将 不 得 不 越 来 越 多 地 把 权 力 移 交 到 左 派 手 中 。 汪 东 兴 — —8341 部 队 团 长 ， 仍 然 忠 于 主 席 ， 并 准 备 帮 助 他 去 战 斗 。 不 过 ， 鉴 于 左 派 力 量 的 增 强 ， 同 时 由 于10 月 份 达 成 的 妥 协 ， 或 许 最 好 的 解 决 办 法 是 只 移 除 最 有 野 心 的 江 青 和 王 洪 文 ， 但 与 其 余 的 人 和 睦 相 处 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 1)
			{
				text2 = " 金 豆 豆 ， 银 豆 豆 ， 投 到 … …";
				text = " 今 天 是 全 国 人 大 选 举 的 日 子 。 既 然 我 们 在 中 国 政 治 上 占 主 导 地 位 ， 我 们 就 可 以 稍 微 干 预 一 下 他 们 的 选 票 去 向 ， 这 样 什 么 都 不 会 被 改 变 。 或 者 我 们 仅 仅 依 靠 中 国 人 民 的 信 任 就 好 了 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 27)
			{
				text2 = " 港 澳 之 命 运";
				text = " 长 期 以 来 ， 中 国 的 香 港 、 澳 门 一 直 处 于 英 葡 的 殖 民 统 治 之 下 。 然 而 ， 葡 萄 牙 的 法 西 斯 政 权 “ 新 国 家 体 制 ” 于1974 年 被 推 翻 ， 英 国 与 香 港 毗 邻 的 新 界 的99 年 租 期 即 将 到 期 ， 两 国 都 受 到1960 年 《 联 合 国 非 殖 民 化 宣 言 》 的 压 力 ， 所 以 他 们 准 备 妥 协 ， 这 是 我 们 得 到 理 应 属 于 我 们 的 东 西 的 机 会 。 当 然 ， 如 果 他 们 不 相 信 自 己 和 外 国 公 民 的 财 产 是 不 可 侵 犯 的 ， 他 们 就 决 不 会 主 动 交 出 殖 民 地 ， 也 不 会 试 图 实 现 港 澳 的 广 泛 自 治 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 28)
			{
				text2 = " 亚 洲 皮 诺 切 特 的 末 日";
				text = " 苏 哈 托 少 将 ， 在1965 年 夺 取 印 度 尼 西 亚 大 权 后 ， 立 即 开 始 摧 毁 他 的 政 治 对 手 ， 特 别 是 共 产 党 人 。 仅 在65 —66 年 ， 就 有 约 三 百 万 人 因 为 同 情 共 产 党 而 被 杀 。 印 尼 少 数 民 族 也 难 逃 厄 运 ， 其 中 包 括 华 人 ， 对 他 们 的 歧 视 仍 然 是 合 法 的 。 苏 哈 托 的 压 迫 政 权 因 美 国 支 持 和 与 东 南 亚 国 家 有 利 可 图 的 贸 易 得 以 维 系 。 但 是 ， 现 在 我 们 切 断 了 印 度 尼 西 亚 与 其 多 数 伙 伴 的 联 系 ， 其 经 济 崩 溃 了 ， 一 场 积 极 的 抗 议 运 动 正 在 该 国 上 演 。 尽 管 许 多 抗 议 打 出 了 左 派 的 口 号 ， 他 们 显 然 是 不 够 发 起 一 场 社 会 主 义 革 命 的 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 29)
			{
				text2 = " 中 国 帝 国 主 义";
				text = " 长 期 以 来 ， 朝 鲜 已 经 摆 脱 了 马 克 思 列 宁 主 义 ， 用 独 创 的 包 含 神 秘 主 义 、 传 统 主 义 和 对 金 日 成 个 人 崇 拜 元 素 的 主 体 思 想 取 而 代 之 。 所 有 这 些 都 伴 随 着 对 金 日 成 政 治 对 手 的 周 期 性 镇 压 。 朝 鲜 的 经 济 在 很 大 程 度 上 依 赖 于 与 中 国 的 接 触 和 我 们 的 帮 助 ， 因 此 我 们 最 近 的 制 裁 对 它 是 一 个 沉 重 的 打 击 。 因 此 ， 我 们 可 以 要 求 朝 鲜 政 府 做 出 某 些 让 步 。 但 别 忘 了 苏 联 也 向 朝 鲜 提 供 援 助 … …";
			}
			else if (GlobalScript.inst.gameState.number_event == 30)
			{
				text2 = " 冲 突 结 束 ？";
				text = " 自 从1948 年 以 色 列 在 前 英 属 巴 勒 斯 坦 领 土 上 建 国 以 来 ， 那 里 的 阿 拉 伯 人 民 实 际 上 被 剥 夺 了 自 决 权 ， 受 到 以 色 列 当 局 的 歧 视 ， 他 们 为 摧 毁 以 色 列 和 在 巴 勒 斯 坦 建 立 一 个 阿 拉 伯 国 家 而 战 斗 ， 他 们 得 到 阿 拉 伯 邻 国 的 支 持 。 这 一 切 导 致 了 几 场 中 东 战 争 ， 巴 勒 斯 坦 解 放 组 织 不 断 炮 击 ， 对 以 色 列 进 行 恐 怖 袭 击 ， 以 色 列 军 队 也 予 以 回 击 。 最 后 一 次 是 在 黎 巴 嫩 ， 以 色 列 完 全 失 败 ， 甚 至 没 有 得 到 美 国 的 支 持 ， 现 在 以 色 列 准 备 与 巴 解 组 织 就 巴 勒 斯 坦 人 的 地 位 进 行 谈 判 ， 我 们 可 以 在 谈 判 中 充 当 中 间 人 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 31)
			{
				text2 = " 正 确 的 民 主";
				text = " 光 州 起 义 ， 由 于 我 们 的 帮 助 ， 向 周 边 地 区 扩 散 ， 并 对 韩 国 政 府 的 声 望 造 成 严 重 伤 害 ， 再 加 上 我 们 最 近 对 韩 国 经 济 的 打 击 导 致 了 新 一 轮 的 抗 议 ， 迫 于 压 力 ， 全 斗 焕 同 意 举 行 自 由 总 统 选 举 ， 甚 至 允 许 两 位 著 名 反 对 派 领 袖 参 选 — — 金 大 中 和 金 泳 三 ， 前 者 特 别 对 朝 鲜 有 更 和 平 的 观 点 。 通 过 确 保 他 的 获 选 ， 并 对 朝 鲜 施 压 ， 我 们 可 以 引 导 朝 鲜 半 岛 走 向 长 久 期 待 的 统 一 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 32)
			{
				text2 = " 乌 兰 巴 托 之 春 ？";
				text = " 在 我 们 干 预 的 协 助 下 ， 蒙 古 发 生 了 大 规 模 抗 议 ， 呼 吁 改 革 ， 脱 离 严 格 的 亲 苏 政 策 。 蒙 古 人 民 共 和 国 不 想 重 蹈 捷 克 斯 洛 伐 克 的 覆 辙 ， 决 定 做 出 些 让 步 ， 开 展 有 限 的 民 主 化 ， 如 同 匈 牙 利 的 卡 达 尔 一 样 。 我 们 可 以 利 用 此 事 将 亲 中 人 士 引 入 蒙 古 政 治 和 媒 体 ， 以 向 他 们 提 供 更 加 … 独 立 的 外 交 政 策 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 33)
			{
				text2 = " 星 月 之 眼";
				text = " 佐 勒 菲 卡 尔 · 阿 里 · 布 托 自1971 年 担 任 巴 基 斯 坦 总 统 ， 自1973 年 来 担 任 总 理 ， 他 遵 循 伊 斯 兰 社 会 主 义 的 路 线 ， 这 在 广 泛 的 社 会 项 目 和 经 济 中 许 多 行 业 的 国 有 化 得 到 体 现 。 在 外 交 政 策 方 面 ， 他 坚 持 反 帝 国 主 义 ， 尝 试 与 邻 国 建 立 友 好 关 系 ， 脱 离 亲 美 的 东 南 亚 条 约 组 织 和 英 联 邦 ， 并 成 功 与 印 度 在 第 三 次 印 巴 战 争 后 缓 和 关 系 。 但 是 在 布 托 的 巴 基 斯 坦 人 民 党 赢 得1977 年3 月 的 大 选 后 ， 反 对 派 指 责 他 欺 诈 ， 并 开 始 抗 议 ， 遭 到 布 托 严 厉 的 镇 压 。 穆 罕 默 德 · 齐 亚 · 乌 尔 · 哈 克 领 导 的 军 队 不 喜 欢 此 事 ， 在 美 国 的 支 持 下 ， 他 在 准 备 军 事 政 变 。 通 过 阻 止 政 变 ， 提 供 布 托 建 设 社 会 主 义 的 物 质 协 助 ， 我 们 可 以 坚 实 地 确 保 我 们 在 巴 基 斯 坦 的 地 位 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 34)
			{
				text2 = " 我 敌 人 的 敌 人";
				text = " 在 四 人 帮 倒 台 后 ， 你 在 名 义 上 掌 握 了 最 高 权 力 ， 但 事 实 上 你 必 须 与 那 些 帮 助 你 得 到 权 力 的 人 分 享 它 — — 在 文 化 大 革 命 期 间 为 邓 小 平 辩 护 ， 也 是 一 个 坚 定 的 改 革 派 的 现 任 国 防 部 长 叶 剑 英 ， 还 有 李 先 念 ， 更 温 和 些 ， 但 也 支 持 改 革 派 。 另 一 方 面 ， 你 最 忠 实 的 保 守 派 支 持 者 有 三 位 — — 纪 登 奎 、 汪 东 兴 和 陈 锡 联 。 如 果 你 不 想 被 架 空 ， 你 就 应 该 打 击 改 革 派 ， 并 提 拔 你 的 支 持 者 ， 然 而 ， 这 种 武 断 的 行 为 会 在 党 内 引 起 不 满 吗 ？ 另 一 方 面 ， 如 果 你 专 注 于 改 革 ， 与 改 革 派 进 行 谈 判 可 能 会 更 有 用 些 。 尽 管 谁 知 道 他 们 要 的 是 什 么 … …";
			}
			else if (GlobalScript.inst.gameState.number_event == 35)
			{
				text2 = " 革 命 的 结 束";
				text = " 在 毛 泽 东 死 后 ， 你 采 取 了 遏 制 文 化 大 革 命 的 措 施 ， 取 得 了 一 定 的 成 果 — — 现 在 已 经 看 不 到 群 众 运 动 了 。 但 自 从 文 化 大 革 命 以 来 ， 国 家 的 高 压 统 治 还 没 有 减 弱 ， 改 革 派 和 人 民 现 在 要 求 “ 拧 松 螺 母 ” 。 除 了 对 公 民 自 由 的 要 求 ， 许 多 人 认 为 有 必 要 减 轻 对 传 统 和 宗 教 的 压 力 ， 文 化 大 革 命 期 间 ， 对 传 统 和 宗 教 的 压 力 成 倍 增 加 。 一 些 人 只 主 张 停 止 反 传 统 主 义 的 言 论 ， 仍 然 保 留 国 家 无 神 论 ， 另 一 些 人 则 根 据 苏 联 模 式 ， 主 张 名 义 上 的 良 心 自 由 ， 同 时 将 宗 教 机 构 和 教 士 置 于 严 格 的 国 家 控 制 之 下 。 由 你 决 定 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 36)
			{
				text2 = " 联 盟 崩 解 ？";
				text = " 自1968 年 以 来 ， 执 政 的 复 兴 党 和 伊 拉 克 共 产 党 在 伊 拉 克 进 步 民 族 爱 国 阵 线 的 框 架 内 ， 在 伊 拉 克 建 立 了 不 稳 定 的 合 作 关 系 。1972 年5 月 ，2 名 伊 共 代 表 被 正 式 引 入 政 府 ， 尽 管 共 产 党 仍 处 于 非 正 式 地 位 。 然 而 ， 这 种 合 作 结 果 是 短 暂 的 。 最 近 ， 伊 拉 克 的 复 兴 党 领 导 人 再 次 开 始 对 共 产 党 发 动 镇 压 ， 但 仍 有 维 持 脆 弱 联 盟 的 空 间 。 也 许 我 们 应 该 介 入 一 下 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 37)
			{
				text2 = " 埃 及 帕 夏 的 终 结";
				text = " 自1970 年 以 来 ， 埃 及 由 安 瓦 尔 · 萨 达 特 领 导 。 他 上 台 后 不 久 ， 就 开 始 抛 弃 迦 玛 尔 · 阿 卜 杜 尔 · 纳 赛 尔 的 政 策 ， 泛 阿 拉 伯 主 义 ， 和 阿 拉 伯 社 会 主 义 的 思 想 。 在 所 谓 的 “ 纠 正 革 命 ” 中 ， 几 乎 所 有 纳 赛 尔 的 亲 信 都 被 逮 捕 ， 包 括 副 总 统 阿 里 · 萨 布 里 （ 他 支 持 对 苏 联 和 共 产 党 友 好 ） ，1971 年 ， 阿 拉 伯 联 合 共 和 国 被 重 命 名 为 阿 拉 伯 埃 及 共 和 国 ， 这 打 断 了 泛 阿 拉 伯 整 合 的 进 程 。1973 年 ， 埃 及 开 始 与 美 国 建 立 友 好 关 系 ， 这 伴 随 着 反 苏 情 绪 的 增 长 和 与 利 比 亚 和 叙 利 亚 关 系 断 绝 。1975 年 ， 萨 达 特 尝 试 破 坏 阿 拉 伯 社 会 主 义 联 盟 （ASU ） 的 稳 定 ， 而 今 年 ， 发 生 了 史 无 前 例 的 事 情 － 与 以 色 列 关 于 重 建 关 系 的 谈 判 ！ 经 济 自 由 化 和 外 国 资 本 的 渗 透 导 致 大 众 广 泛 的 不 满 ， 而 与 曾 经 的 友 邦 利 比 亚 的 战 争 彻 底 摧 毁 了 萨 达 特 当 局 的 权 威 。 大 规 模 集 会 如 洪 水 般 席 卷 全 国 ， 要 求 总 统 辞 职 。 我 们 可 以 趁 此 机 会 让 权 力 重 回 社 会 主 义 者 手 中 。 苏 联 和 阿 拉 伯 友 邦 显 然 不 会 反 对 ， 但 美 国 的 反 应 可 不 会 太 热 情 …";
			}
			else if (GlobalScript.inst.gameState.number_event == 38)
			{
				text2 = " 回 归 本 源";
				text = " 在50 年 代 后 期 的 大 跃 进 运 动 以 来 ， 为 了 应 对 当 时 的 形 势 ， 加 上 当 时 国 家 事 实 上 无 法 负 担 中 央 计 划 经 济 ， 原 本 属 于 中 央 的 经 济 权 力 被 下 放 到 地 方 ， 逐 渐 形 成 了 分 权 式 的 计 划 经 济 体 制 。  现 在 我 们 到 达 了 一 个 新 的 历 史 节 点 ， 党 内 对 经 济 体 制 的 讨 论 也 增 加 了 。 部 分 党 员 认 为 我 们 应 该 再 次 集 权 化 ， 恢 复 中 央 计 划 经 济 体 制 ， 这 能 让 我 们 的 经 济 更 好 地 协 调 发 展 ； 而 改 革 派 认 为 经 济 需 要 像 刘 少 奇 掌 权 时 期 那 样 进 行 一 定 放 松 甚 至 是 进 一 步 并 且 深 化 改 革 ； 当 然 ， 也 有 人 认 为 经 过 了 实 践 考 验 的 分 权 式 计 划 是 当 前 的 最 好 模 式 。 我 们 应 该 如 何 选 择 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 39)
			{
				text2 = " 《 党 的 若 干 历 史 问 题 的 决 议 》 起 草 委 员 会";
				text = " 毛 泽 东 同 志 的 逝 世 ， 引 发 了 中 国 共 产 党 的 党 内 斗 争 ， 我 们 拒 绝 继 续 进 行 所 谓 的 “ 无 产 阶 级 文 化 大 革 命 ” ， 在 党 内 引 起 了 强 烈 的 骚 动 。 公 安 部 表 示 ， 关 于 “ 毛 泽 东 思 想 的 错 误 ” 、 “ 中 国 共 产 党 路 线 的 谬 误 ” 、 “ 毛 泽 东 及 其 亲 信 对 国 家 和 党 的 历 史 的 歪 曲 ” 等 思 想 开 始 在 一 些 党 组 织 中 传 播 。 这 有 可 能 分 裂 共 产 党 ， 甚 至 彻 底 消 灭 中 国 社 会 主 义 发 展 道 路 的 一 切 成 就 。 中 共 中 央 政 治 局 决 定 开 始 起 草 一 份 文 件 ， 对1949 年 以 来 在 毛 泽 东 领 导 下 的 中 华 人 民 共 和 国 和 中 国 共 产 党 走 过 的 道 路 进 行 正 式 评 估 。 然 而 ， 有 必 要 决 定 谁 将 领 导 它 ， 并 确 定 文 件 大 致 的 感 情 基 调 。 请 记 住 ， 你 的 决 定 将 产 生 深 远 的 影 响 ， 并 可 能 导 致 整 个 党 的 思 想 路 线 的 修 正 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 40)
			{
				text2 = " 班 禅 喇 嘛 的 命 运";
				text = " 主 席 同 志 ， 一 大 批 藏 族 神 职 人 员 来 信 ， 要 求 你 们 考 虑 释 放 十 世 班 禅 喇 嘛 （ 班 禅 喇 嘛 是 仅 次 于 藏 传 佛 教 格 鲁 派 达 赖 喇 嘛 之 后 的 第 二 位 喇 嘛 — — 注 释 ： 国 安 部 ） 。 一 九 四 九 年 九 月 ， 十 世 班 禅 喇 嘛 洛 桑 · 特 林 利 · 拉 杜 鲁 布 · 确 吉 坚 赞 拒 绝 随 国 民 党 逃 往 台 湾 ， 支 持 中 华 人 民 共 和 国 的 成 立 。 后 来 在 西 藏 与 祖 国 统 一 中 发 挥 了 重 要 作 用 。 然 而 ， 他 随 后 严 厉 谴 责 了 西 藏 自 治 区 的 中 国 化 ，1964 年 他 被 宣 布 为 “ 西 藏 人 民 的 敌 人 ” ， 被 捕 并 被 关 进 在 他 目 前 居 住 的 北 京 秦 城 监 狱 。 我 们 可 以 释 放 他 ， 从 而 大 大 改 善 与 藏 族 僧 侣 和 自 治 区 人 民 的 关 系 。 但 这 有 意 义 吗 ？ 也 许 最 好 是 清 除 这 位 不 可 靠 的 喇 嘛 ， 让 我 们 的 保 护 人 坚 赞 诺 布 当 选 班 禅 喇 嘛 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 41)
			{
				text2 = " 印 度 大 选";
				text = " 自1966 年 就 任 的 前 印 度 总 理 ， 国 大 党 党 首 ， 英 迪 拉 · 甘 地 ， 在 她 执 政 期 间 在 社 会 经 济 领 域 积 极 地 开 展 了 左 派 改 革 ， 这 甚 至 激 起 了 国 大 党 内 的 分 裂 ， 和 党 内 右 翼 的 退 出 。 她 执 政 期 间 取 得 了 经 济 成 功 ， 有 效 解 决 贫 困 问 题 ， 但 自1971 年 宣 布 国 家 紧 急 状 态 以 来 ， 反 对 派 人 民 党 开 始 掌 握 优 势 ， 该 党 指 责 甘 地 腐 败 ， 搞 裙 带 关 系 ， 和 威 权 主 义 。 在 这 些 情 况 下 ， 甘 地 决 定 举 行 早 期 议 会 选 举 。 考 虑 到 甘 地 一 直 在 支 持 亲 苏 政 策 和 对 我 们 不 友 好 的 外 交 政 策 ， 还 和 与 我 们 关 系 友 好 的 巴 基 斯 坦 冲 突 ， 直 到 最 近 关 系 才 缓 和 ， 也 许 反 对 派 当 选 可 以 增 强 我 们 的 影 响 力 ？ 人 民 党 团 结 不 同 观 点 的 群 体 ， 从 社 会 主 义 者 到 保 守 主 义 者 ， 并 且 没 有 明 确 的 党 纲 ， 但 这 有 助 于 我 们 更 好 地 掌 控 他 们 。 尽 管 也 许 如 果 我 们 帮 助 英 迪 拉 ， 她 也 许 会 记 得 我 们 的 好 ， 并 推 动 关 系 的 重 建 ？ …";
			}
			else if (GlobalScript.inst.gameState.number_event == 42)
			{
				text2 = " 伊 朗 革 命";
				text = " 一 段 时 间 以 来 ， 针 对 伊 朗 人 民 困 难 的 社 会 经 济 状 况 、 沙 阿 的 亲 美 政 策 、 统 治 精 英 的 猖 獗 腐 败 以 及 国 家 对 什 叶 派 神 职 人 员 的 压 迫 ， 抗 议 一 直 在 沙 阿 伊 朗 举 行 。 然 而 ， 今 天 ， 反 政 府 示 威 活 动 在 库 姆 的 抗 议 被 警 察 镇 压 后 进 入 了 白 热 化 阶 段 ， 这 是 由 一 篇 关 于 阿 亚 图 拉 （ 什 叶 派 伊 斯 兰 教 的 最 高 精 神 称 号 ） 霍 梅 尼 的 诽 谤 文 章 引 起 的 。 他 是 抗 议 活 动 的 精 神 领 袖 ，1964 年 被 驱 逐 出 境 。 此 后 ， 抗 议 和 罢 工 席 卷 了 伊 朗 的 许 多 城 市 。 伊 斯 兰 主 义 运 动 ， 如 自 由 伊 朗 运 动 和 战 斗 神 职 人 员 社 会 ， 是 即 将 到 来 的 革 命 的 驱 动 力 ， 但 其 他 组 织 也 在 努 力 推 翻 沙 阿 ， 其 中 最 大 的 是 伊 朗 民 主 民 族 阵 线 和 伊 朗 马 列 主 义 人 民 党 。 伊 朗 的 革 命 会 极 大 地 改 变 中 东 地 区 的 权 力 平 衡 ， 所 以 也 许 我 们 应 该 进 行 干 预 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 43)
			{
				text2 = " 经 互 会 的 扩 张";
				text = " 长 期 以 来 ， 越 南 一 直 试 图 在 我 们 和 苏 联 之 间 取 得 平 衡 ， 因 为 尽 管 我 们 与 苏 联 存 在 分 歧 ， 但 我 们 的 志 愿 者 们 在 印 度 支 那 战 争 中 与 社 会 主 义 越 南 并 肩 作 战 。 但 随 着 战 争 结 束 和 越 南 统 一 ， 越 南 逐 渐 变 得 越 来 越 亲 苏 联 ， 越 来 越 疏 远 我 们 。|";
				text = ((GlobalScript.inst.gameState.allcountries[23].Gosstroy != 1) ? (text + " 黎 笋1977 年 访 问 莫 斯 科 后 ， 越 南 与 苏 联 又 开 始 了 一 次 友 好 关 系 ， 他 日 复 一 日 地 希 望 加 入 经 互 会 。 我 们 显 然 无 法 阻 止 此 事 ， 尤 其 是 越 南 希 望 在 对 抗 亲 中 柬 埔 寨 的 波 尔 布 特 时 得 到 苏 联 支 持 。") : (text + " 黎 笋1977 年 访 问 莫 斯 科 后 ， 越 南 与 苏 联 又 开 始 了 一 次 友 好 关 系 ， 他 日 复 一 日 地 希 望 加 入 经 互 会 。 然 而 ， 该 国 部 分 领 导 人 反 对 与 苏 联 建 立 如 此 热 烈 的 友 好 关 系 ， 因 为 越 南 没 有 特 别 的 威 胁 ， 特 别 是 在 柬 埔 寨 的 波 尔 布 特 政 权 被 推 翻 后 。 这 是 我 们 干 预 和 制 止 苏 联 霸 权 扩 散 的 机 会 。"));
			}
			else if (GlobalScript.inst.gameState.number_event == 44)
			{
				text2 = " 不 管 黑 猫 白 猫 …";
				text = " 你 对 保 守 政 策 的 追 求 与 你 的 支 持 者 日 益 削 弱 的 力 量 完 全 不 一 致 ， 最 终 导 致 了 在 温 和 派 支 持 下 的 中 国 共 产 党 改 革 派 的 普 遍 不 满 。 他 们 希 望 你 下 台 ， 并 要 求 开 始 广 泛 的 市 场 改 革 ， 吸 引 外 资 和 中 国 进 入 世 界 市 场 ， 他 们 认 为 “ 经 济 应 该 压 倒 意 识 形 态 ” 。 这 是 他 们 的 领 导 人" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 在 当 前 的 中 共 中 央 全 会 上 对 你 说 的 ， 大 多 数 出 席 会 议 的 人 都 赞 同 他 的 观 点 。 如 果 你 不 想 失 去 权 力 ， 就 需 要 做 点 什 么 ！";
			}
			else if (GlobalScript.inst.gameState.number_event == 45)
			{
				text2 = " 改 革 开 放 ： 先 声";
				text = " 在 宣 告 了 市 场 改 革 进 程 之 后 ， 我 们 的 经 济 学 家 制 定 了 第 一 次 改 革 的 计 划 ， 并 最 终 提 交 给 中 国 共 产 党 领 导 层 批 准 。 它 包 括 扩 大 企 业 经 营 自 主 权 ， 引 入 市 场 机 制 以 调 节 他 们 的 工 作 以 及 支 持 个 体 与 集 体 所 有 制 企 业 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 46)
			{
				text2 = " 第 二 次 匈 牙 利 事 件 ？";
				text = " 来 自 匈 牙 利 的 有 趣 消 息 。 贝 拉 · 比 斯 库 是 一 名 保 守 的 共 产 主 义 者 ， 他 在1956 年 积 极 参 与 了 镇 压 匈 牙 利 暴 乱 ， 并 在1957 年 至1961 年 担 任 内 政 部 长 和 现 任 匈 牙 利 社 会 主 义 工 人 党 （HSWP ） 书 记 ， 他 一 直 反 对 卡 达 尔 的 经 济 和 政 治 自 由 主 义 改 革 。 意 识 到 言 语 无 法 阻 止 卡 达 尔 ， 他 在 自 己 周 围 组 织 了 一 个 类 似 的 保 守 派 组 织 ， 并 决 定 组 织 一 场 党 内 政 变 ， 要 求 克 格 勃 领 导 人 尤 里 · 安 德 罗 波 夫 的 支 持 。 然 而 ， 根 据 我 们 的 数 据 ， 安 德 罗 波 夫 简 单 地 “ 背 叛 ” 了 比 斯 库 对 卡 达 尔 的 计 划 ， 而 比 斯 库 自 己 还 不 知 情 。 现 在 我 们 有 机 会 帮 助 比 斯 库 和 我 们 的 代 理 人 ， 让 匈 牙 利 走 上 建 设 真 正 社 会 主 义 的 道 路 。 或 者 你 可 以 尝 试 在 小 规 模 武 器 供 应 和 情 报 协 调 的 帮 助 下 在 匈 牙 利 发 动 一 场 新 的 起 义 — — 这 次 是 真 正 的 共 产 主 义 和 亲 中 的 — — 那 么 匈 牙 利 肯 定 是 我 们 的 ！ 但 我 们 必 须 行 动 迅 速 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 47)
			{
				text2 = " 北 京 之 春";
				text = " 从 今 年 年 中 开 始 ， 全 国 各 地 的 学 生 和 知 识 分 子 开 始 了 激 烈 的 活 动 ， 尤 其 是 在 北 京 ， 大 街 上 挂 着 大 字 报 （ 带 有 用 于 宣 传 和 抗 议 的 大 象 形 文 字 的 壁 报 ） ， 出 版 自 制 的 杂 志 。 大 字 报 和 报 刊 反 对 中 国 共 产 党 的 保 守 主 义 ， 批 评 文 化 大 革 命 ， 呼 吁 经 济 和 政 治 的 自 由 化 ， 对 中 国 共 产 党 内 积 极 的 改 革 派 表 示 支 持 。 此 外 ，1977 年 ， 改 革 派 们 在 他 们 控 制 下 的 期 刊 和 报 纸 上 发 表 了 激 烈 的 对 我 们 政 策 的 批 评 ， 他 们 说 我 们 的 政 策 “ 不 符 合 马 克 思 主 义 ” ， 又 主 张 “ 经 济 发 展 应 该 压 倒 意 识 形 态 工 作 ” ， “ 实 践 是 检 验 真 理 的 唯 一 标 准 ” ， 并 在 他 们 的 愿 景 中 描 述 了 市 场 改 革 的 远 大 前 景 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 63)
			{
				text2 = " 四 月 革 命";
				text = " 紧 急 新 闻 ！4 月27 日 ， 在 阿 富 汗 ， 由 于 权 力 不 稳 定 、 贫 困 和 人 民 对 逮 捕 左 翼 反 对 派 人 民 民 主 党 领 导 人 的 不 满 ， 人 民 民 主 党 事 先 策 划 了 一 场 军 事 政 变 。 人 民 对 革 命 表 示 欢 迎 。 执 政 后 ， 以 努 尔 · 穆 罕 默 德 · 塔 拉 基 为 首 的 阿 富 汗 民 主 共 和 国 开 始 了 社 会 主 义 的 建 设 和 对 苏 联 的 定 位 。 然 而 ， 阿 富 汗 的 未 来 仍 不 明 朗 ， 因 为 在 人 民 民 主 党 内 ， 人 民 派 和 旗 帜 派 之 间 仍 然 存 在 着 压 倒 性 的 分 裂 ， 从1966 年 到1977 年 ， 这 两 个 派 系 实 际 上 是 两 个 独 立 的 派 系 。 人 民 派 主 要 由 低 收 入 者 和 半 无 产 阶 级 组 成 ， 在 以 非 法 劳 动 为 重 点 的 反 对 活 动 中 ， 主 张 进 行 革 命 斗 争 ， 现 在 寻 求 组 织 国 家 向 社 会 主 义 和 无 产 阶 级 专 政 的 快 速 过 渡 。 旗 帜 派 在 反 对 党 的 几 年 里 把 法 律 和 议 会 斗 争 放 在 首 位 ， 现 在 代 表 着 逐 步 的 、 全 面 的 民 主 改 革 ， 并 且 普 遍 倾 向 于 改 良 主 义 ， 认 为 阿 富 汗 还 没 有 准 备 好 建 设 社 会 主 义 。 同 时 ， 中 国 共 产 党 对 苏 维 埃 在 该 地 区 的 影 响 力 扩 大 表 示 严 重 关 切 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 48)
			{
				text2 = " 政 变 的 延 续";
				text = " 四 月 革 命 后 ， 人 民 民 主 党 面 临 着 许 多 困 难 ， 在 快 速 壮 大 的 人 民 派 中 ， 人 民 民 主 党 创 始 人 塔 拉 基 和 他 的 学 生 阿 明 之 间 的 斗 争 已 经 开 始 。 阿 明 是 激 进 政 治 的 支 持 者 ， 赞 同 对 封 建 残 余 势 力 的 不 懈 斗 争 和 对 政 治 对 手 的 严 厉 镇 压 。 同 时 ， 作 为 一 个 狂 热 的 普 什 图 民 族 主 义 者 （ 注 释- 阿 富 汗 的 主 要 民 族 ） ， 他 在 很 大 程 度 上 阻 碍 了 人 民 民 主 党 的 民 族 政 策 ， 试 图 将 权 力 集 中 在 自 己 手 中 ， 他 在 人 民 派 和 旗 帜 派 之 间 维 持 了 分 裂 。 尽 管 苏 联 领 导 人 一 再 警 告 塔 拉 基 阿 明 的 阴 谋 计 划 ， 但 他 直 到 最 后 一 刻 才 注 意 到 。9 月14 日 ， 在 看 望 塔 拉 基 期 间 ， 阿 明 首 次 遭 到 袭 击 （ 尚 不 清 楚 是 真 的 还 是 由 阿 明 本 人 策 划 的 ） ，9 月16 日 ， 阿 明 在 人 民 民 主 党 中 央 委 员 会 全 体 会 议 上 解 除 了 塔 拉 基 的 职 务 ， 此 前 他 曾 与 驻 地 的 忠 诚 部 队 隔 离 。 值 得 注 意 的 是 ， 尽 管 阿 明 试 图 与 苏 联 保 持 良 好 关 系 ， 但 根 据 我 们 的 数 据 ， 他 不 完 全 反 对 与 中 国 建 立 密 切 关 系 ， 这 可 能 是 我 们 的 机 会 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 49)
			{
				text2 = " 反 对 所 有 暴 君";
				text = " 在 最 近 的 阿 明 政 变 之 后 ， 苏 联 以 各 种 可 能 的 方 式 寻 找 清 除 目 中 无 人 的 篡 权 者 的 方 法 。 根 据 我 们 的 数 据 ， 苏 联 领 导 人 已 经 与 卡 尔 迈 勒 、 萨 瓦 里 和 瓦 坦 贾 等 不 同 派 系 的 人 民 民 主 党 成 员 建 立 了 联 系 ， 他 们 因 阿 明 的 清 洗 而 逃 离 阿 富 汗 ， 并 准 备 用 他 们 来 取 代 阿 明 。 这 项 计 划 的 关 键 是 以 苏 联 特 勤 部 队 中 和 阿 明 及 其 忠 实 的 随 从 ， 苏 联 特 勤 部 队 的 掩 护 应 该 由 苏 联 军 队 提 供 ， 自 今 年 年 初 以 来 ， 尽 管 苏 联 不 断 遭 到 拒 绝 ， 但 人 民 民 主 党 和 阿 明 本 人 一 直 被 要 求 得 到 进 入 许 可 。 然 而 ， 在 这 种 情 况 的 压 力 下 ， 苏 维 埃 领 导 人 似 乎 决 定 改 变 决 定 ， 最 早12 月25 日 ， 第 一 批 苏 维 埃 部 队 越 境 ， 任 务 是 保 护 苏 阿 合 作 的 重 要 军 事 设 施 和 对 象 。 现 在 是 我 们 夺 取 在 阿 富 汗 的 主 动 权 的 机 会 ， 如 果 有 可 能 防 止 阿 明 的 免 职 的 话 。 然 而 ， 这 只 能 在 与 苏 联 保 持 良 好 关 系 的 情 况 下 才 能 实 现 ， 否 则 苏 联 将 冲 破 一 堵 砖 墙 ， 但 不 会 给 我 们 阿 富 汗 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 50)
			{
				text2 = " 穷 山 恶 水";
				text = " 在 最 近 导 致 阿 富 汗 局 势 恶 化 的 事 件 之 后 ， 美 国 支 持 的 伊 斯 兰 主 义 者 和 其 他 反 动 派 的 长 期 起 义 进 入 了 白 热 化 阶 段 。 根 据 最 近 通 过 的 计 划 ， 苏 联 应 民 主 共 和 国 政 府 的 要 求 向 阿 富 汗 增 兵 ， 这 已 经 在 西 方 引 起 了 一 波 愤 怒 。 尽 管 民 众 最 初 与 苏 联 军 队 的 接 触 相 当 友 好 ， 但 对 他 们 的 武 装 分 子 袭 击 事 件 却 越 来 越 频 繁 。 与 此 同 时 ， 最 初 只 包 括 保 护 重 要 目 标 的 有 限 分 遣 队 的 任 务 正 在 逐 步 扩 大 ， 而 且 似 乎 最 终 将 充 分 参 与 敌 对 行 动 。 阿 富 汗 战 争 已 经 开 始 ， 我 们 需 要 决 定 我 们 将 支 持 谁 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 51)
			{
				text2 = " 看 看 就 走 … …";
				text = " 四 月 革 命 后 ， 人 民 民 主 党 面 临 着 许 多 困 难 ， 这 是 由 于 其 成 员 缺 乏 经 验 和 残 存 着 大 量 的 封 建 和 宗 教 残 余 ， 但 由 于 人 民 民 主 党 两 个 派 系 之 间 的 力 量 相 对 平 衡 ， 有 可 能 避 免 重 大 的 政 治 冲 突 。 特 别 是 由 于 ， 旗 帜 派 和 人 民 派 的 成 员 在 苏 联 的 支 持 下 ， 成 功 地 将 阿 明 从 政 府 和 中 央 委 员 会 除 名 ， 指 控 他 违 反 集 体 领 导 原 则 和 普 什 图 民 族 主 义 。 然 而 ， 从 今 年 年 初 开 始 的 反 动 组 织 ， 特 别 是 伊 斯 兰 主 义 者 的 起 义 势 头 越 来 越 强 劲 。 巴 基 斯 坦 和 伊 朗 的 一 些 公 民 加 入 了 他 们 ， 非 法 越 境 ， 甚 至 美 国 设 法 以 某 种 方 式 将 他 们 的 武 器 和 顾 问 拖 到 阿 富 汗 帮 助 圣 战 者 。 在 这 种 情 况 下 ， 苏 联 应 阿 富 汗 领 导 人 的 无 数 要 求 ， 决 定 引 进 一 支 小 分 队 ， 保 卫 重 要 的 军 事 设 施 和 城 市 ， 解 放 阿 富 汗 民 主 共 和 国 军 队 的 力 量 与 叛 乱 分 子 作 战 。 他 们 似 乎 不 希 望 大 规 模 参 与 敌 对 行 动 ， 但 西 方 已 经 谴 责 这 一 行 为 ， 称 之 为 入 侵 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 52)
			{
				text2 = " 善 邻 难 做";
				text = " 从 阿 富 汗 反 政 府 示 威 活 动 和 民 主 共 和 国 政 府 的 回 应 开 始 ， 许 多 伊 斯 兰 激 进 分 子 、 恐 怖 分 子 和 阿 訇 逃 往 巴 基 斯 坦 ， 在 那 里 他 们 与 当 地 的 “ 同 事 ” 结 盟 。 随 后 ， 在 阿 富 汗 武 装 暴 乱 开 始 后 ， 难 民 涌 入 巴 基 斯 坦 ， 在 那 里 成 立 的 伊 斯 兰 恐 怖 组 织 的 等 待 下 。 巴 基 斯 坦 本 身 并 没 有 采 取 特 别 的 措 施 来 解 决 这 些 问 题 ， 似 乎 布 托 在 这 方 面 有 足 够 的 问 题 ， 但 为 他 提 供 地 下 援 助 ， 以 制 止 这 种 暴 行 是 值 得 的 吗 ？ 另 一 方 面 ， 美 国 对 通 过 巴 基 斯 坦 帮 助 阿 富 汗 叛 军 的 可 能 性 非 常 感 兴 趣 ， 如 果 布 托 不 能 以 任 何 方 式 与 美 国 达 成 一 致 ， 那 么 他 可 以 与 我 们 达 成 一 致 。 通 过 巴 基 斯 坦 运 送 美 国 武 器 和 顾 问 ， 我 们 可 以 “ 削 减 ” 美 国 人 的 钱 和 打 击 苏 联 社 会 帝 国 主 义 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 53)
			{
				text2 = " 农 业 改 革";
				text = " 目 前 ， 中 国 实 行 的 人 民 公 社 制 度 确 立 于50 年 代 后 期 。 人 民 公 社 制 度 的 确 立 经 历 多 重 波 折 ， 最 终 逐 渐 探 索 出 了 “ 大 寨 模 式 “ ， 随 后 全 国 以 这 一 模 式 为 样 板 ， 发 起 了 学 大 寨 运 动 。1975 年 的 全 国 农 业 学 大 寨 会 议 曾 提 出 要 在 全 国 建 设 ” 大 寨 县 “ （ 即 实 行 大 寨 模 式 的 县 ） ， 陈 永 贵 曾 指 出 “ 大 寨 县 ” 的 标 准 ： 粮 食 亩 产 实 现 八 百 斤 ； 科 学 种 田 ； 基 本 实 现 农 业 机 械 化 ， 为 农 业 现 代 化 打 下 基 础 ； 干 部 参 与 劳 动 ， 落 实 ” 一 二 三 “ （ 即 干 部 每 年 参 加 劳 动 的 指 标 ： 县 委 书 记100 天 ， 公 社 党 委 书 记200 天 ， 大 队 支 部 书 记300 天 ） 。 但 是 ， 毛 主 席 的 去 世 使 得 党 内 对 农 业 路 线 的 争 议 再 次 浮 出 水 面 。 极 左 派 和 保 守 派 都 要 求 继 续 实 行 毛 主 席 定 下 的 大 寨 路 线 ， 但 他 们 对 “ 大 寨 县 ” 普 及 速 度 仍 有 争 议 ， 极 左 派 支 持 大 搞 社 会 主 义 的 农 业 机 械 化 和 现 代 化 并 进 行 农 村 工 业 化 ， 保 守 派 则 认 为 大 寨 模 式 的 普 及 不 应 该 停 止 ， 但 更 多 的 资 金 应 该 用 在 其 他 地 方 （ 如 现 代 化 上 ） ； 另 外 ， 温 和 派 和 改 革 派 想 要 再 次 实 施 类 似 刘 少 奇 等 人 支 持 的 ” 三 自 一 包 “ 的 模 式 ； 而 另 一 部 分 步 子 迈 地 更 大 的 改 革 派 甚 至 提 议 引 入 一 套 完 善 的 私 人 农 业 体 系 。 我 们 需 要 决 定 我 们 用 以 农 业 发 展 的 资 金 最 终 流 向 哪 部 分 人 。 主 席 同 志 ， 这 是 一 场 新 的 路 线 斗 争 ， 中 国 农 业 未 来 的 命 运 在 你 手 里 ！";
			}
			else if (GlobalScript.inst.gameState.number_event == 54)
			{
				text2 = " 改 革 开 放 ： 引 资";
				text = " 按 照 改 革 开 放 政 策 的 政 策 框 架 下 ， 吸 引 外 资 是 重 要 的 一 环 。 改 革 派 提 议 在 沿 海 地 区 建 立 几 个 经 济 特 区 ， 为 外 国 投 资 者 提 供 税 收 的 优 惠 、 最 低 限 度 的 国 家 控 制 和 其 他 的 政 策 优 惠 ， 让 他 们 可 以 在 那 里 建 立 自 己 的 企 业 ， 并 投 资 于 合 资 企 业 。 然 而 ， 除 了 建 立 经 济 特 区 之 外 ， 更 激 进 的 领 导 人 提 议 ， 通 过 建 立 合 资 企 业 制 度 ， 进 而 全 面 开 放 经 济 ， 外 国 可 以 在 我 们 的 国 有 企 业 内 投 资 ， 以 换 取 利 润 分 成 。 显 而 易 见 的 ， 第 二 种 选 择 的 盈 利 能 力 更 强 ， 但 党 内 的 温 和 派 ， 甚 至 一 些 改 革 派 的 人 也 批 评 它 的 措 施 过 于 激 进 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 55)
			{
				text2 = " 缅 甸 的 社 会 主 义 道 路";
				text = "1962 年 军 事 政 变 后 ， 缅 甸 政 府 移 交 给 了 奈 温 ， 由 他 领 导 的 缅 甸 社 会 主 义 纲 领 党 宣 布 建 设 “ 缅 甸 式 社 会 主 义 ” 。 然 而 ， 这 种 “ 社 会 主 义 ” 的 特 点 是 保 护 私 营 部 门 ， 培 养 沙 文 主 义 的 宗 教 和 民 族 偏 见 ， 事 实 上 脱 离 孤 立 ， 以 及 对 所 有 奈 温 的 反 对 者 进 行 大 规 模 镇 压 。 因 此 ，1971 年 公 开 大 规 模 征 募 开 始 后 入 党 的 各 种 左 翼 势 力 ， 开 始 日 益 反 对 奈 温 及 其 政 策 。 根 据 我 们 的 数 据 ， 缅 甸 社 会 主 义 纲 领 党 正 在 准 备 针 对 共 产 主 义 者 和 其 他 左 派 的 大 清 洗 ， 如 果 我 们 已 经 同 缅 甸 接 触 过 ， 我 们 可 以 在 我 们 的 特 勤 机 构 的 帮 助 下 ， 改 变 有 利 于 他 们 的 力 量 平 衡 。 但 是 ， 我 们 也 可 以 为 缅 甸 领 导 人 提 供 额 外 的 援 助 ， 加 强 我 们 的 关 系 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 56)
			{
				text2 = " 给 越 南 点 教 训 ？";
				text = " 越 南 在 印 度 支 那 的 扩 张 ， 并 对 我 们 的 柬 埔 寨 朋 友 发 起 了 侵 略 ， 这 并 不 让 我 们 高 兴 。 鉴 于 越 南 黎 笋 集 团 的 亲 苏 排 华 路 线 ， 他 们 的 扩 张 对 我 们 很 是 不 利 。 再 加 上 我 们 与 越 南 的 边 境 冲 突 和 越 南 对 华 人 的 迫 害 ， 不 少 党 员 认 为 应 该 “ 给 越 南 人 一 些 教 训 ” ， 以 击 垮 “ 白 眼 狼 ” 。 我 们 可 以 用 边 境 冲 突 为 借 口 发 起 战 争 ， 夺 取 边 境 地 区 ， 并 消 灭 到 来 的 越 南 军 队 ， 尽 可 能 地 向 越 南 境 内 推 进 ， 并 为 我 们 的 柬 埔 寨 盟 友 分 担 压 力 。 这 样 的 一 击 将 使 得 越 南 领 导 层 严 肃 地 重 新 考 虑 其 对 苏 和 对 华 政 策 ， 也 可 以 为 我 们 与 西 方 的 缓 和 甚 至 是 交 好 打 下 基 础 。 主 席 同 志 ， 我 们 该 如 何 选 择 ？ ";
			}
			else if (GlobalScript.inst.gameState.number_event == 57)
			{
				text2 = " 红 色 旭 日";
				text = " 不 久 日 本 将 举 行 众 议 院 选 举 。 由 于 政 府 不 稳 定 和 腐 败 丑 闻 的 背 景 ， 日 本 共 产 党 在 近 期 逐 渐 获 得 人 民 支 持 ， 其 他 一 些 中 左 翼 的 反 对 派 也 是 如 此 。 假 如 我 们 对 日 共 有 影 响 力 ， 就 可 以 帮 助 他 们 的 竞 选 活 动 。 如 果 他 们 胜 选 了 ， 我 们 可 以 与 历 史 对 手 改 善 关 系 ， 并 最 终 使 美 军 基 地 撤 出 日 本 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 58)
			{
				text2 = " 伊 朗 革 命 ： 终 局";
				text = " 过 去 一 年 内 ， 伊 朗 经 历 了 一 番 大 变 故 。 各 路 反 对 派 纷 纷 进 军 勤 王 ， 一 次 又 一 次 的 罢 工 冲 蚀 着 沙 阿 最 后 的 一 丝 威 严 。 而 大 使 馆 的 官 员 已 经 拍 来 了 新 的 电 报 。|";
			}
			else if (GlobalScript.inst.gameState.number_event == 59)
			{
				text2 = " 经 济 联 盟";
				text = " 主 席 同 志 ！ 考 虑 到 国 际 舞 台 上 的 形 式 ， 一 些 党 员 提 议 组 织 一 个 苏 联 领 导 的 经 济 同 盟 ， 即 经 互 会 ， 和 欧 洲 人 的 欧 共 体 的 替 代 物 ， 以 继 续 我 们 在 亲 中 国 家 中 扩 大 影 响 力 ， 深 化 贸 易 和 经 济 纽 带 的 政 策 。 但 是 ， 政 治 局 的 一 些 成 员 觉 得 这 样 做 太 过 匆 忙 和 激 进 ， 也 缺 乏 考 虑 ， 建 议 推 迟 此 事 ， 等 待 一 个 更 好 的 时 机 。 然 而 忘 记 与 苏 联 的 争 议 ， 加 入 经 济 互 助 委 员 会 也 许 是 最 好 的 选 择 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 60)
			{
				text2 = " 军 事 同 盟";
				text = " 在 愉 快 地 创 建 了 我 们 自 己 的 经 济 联 盟 后 ， 一 些 党 员 提 议 将 所 有 对 我 们 友 好 的 国 家 组 成 一 个 军 事 同 盟 以 巩 固 我 们 的 胜 利 果 实 ， 并 在 欧 洲 的 北 约 和 苏 联 的 华 约 的 军 事 基 地 的 包 围 中 占 据 一 席 之 地 。 但 追 求 实 用 主 义 的 党 员 建 议 搁 置 这 个 提 议 ， 称 我 们 考 虑 欠 妥 ， 这 激 进 的 行 为 会 导 致 新 的 一 轮 有 第 三 方 力 量 参 加 的 冷 战 。 但 是 ， 我 国 现 在 比 以 往 更 为 强 大 ， 额 外 的 盟 友 也 不 会 有 什 么 影 响 ， 对 吗 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 61)
			{
				text2 = " 国 歌 问 题";
				text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ！ 如 你 所 知 ， 自1949 年 以 来 我 们 的 国 歌 一 直 是 由 田 汉 作 词 ， 聂 耳 作 曲 的 《 义 勇 军 进 行 曲 》 。 然 而 ， 在 所 谓 的 “ 文 化 大 革 命 ” 期 间 ， 田 汉 因 诬 告 被 捕 并 死 于 狱 中 ， 歌 颂 已 故 毛 泽 东 主 席 的 流 行 歌 曲 《 东 方 红 》 成 为 了 事 实 上 的 国 歌 。 现 在 ， 当 我 们 终 止 了 “ 文 化 大 革 命 ” ， 并 恢 复 了 田 汉 的 名 誉 ， 以 及 国 家 局 势 的 正 常 化 ， 国 歌 的 问 题 出 现 了 。 一 大 批 党 员 提 议 把 《 义 勇 军 进 行 曲 》 恢 复 为 正 式 的 国 歌 ， 但 是 ， 你 们 的 同 事 在 原 则 上 同 意 这 一 点 ， 但 认 为 应 该 修 改 这 首 歌 的 歌 词 ， 增 加 提 及 毛 主 席 和 中 国 共 产 党 的 段 落 。 这 两 个 选 择 都 需 要 一 笔 预 算 去 调 整 。 与 此 同 时 ， 在 党 内 的 毛 派 激 进 分 子 写 信 给 你 ， 他 们 在 信 中 提 议 正 式 赋 予 东 方 红 国 歌 地 位 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 62)
			{
				text2 = " 成 吉 思 汗 后 裔 的 问 题";
				text = " 在1949 年 解 放 战 争 胜 利 后 ， 中 国 的 少 数 民 族 聚 居 区 按 照 苏 联 模 式 ， 获 得 了 自 治 地 位 。 其 中 之 一 是 蒙 古 族 居 住 的 内 蒙 古 。 在 所 谓 的 “ 文 化 大 革 命 ” 期 间 ， 中 央 政 府 开 始 强 迫 同 化 蒙 古 族 人 民 ， 导 致 了 当 地 人 民 与 红 卫 兵 的 大 规 模 冲 突 和 在1967-1969 年 的 暴 乱 。1969 年 ， 内 蒙 古 大 部 分 地 区 被 划 入 相 邻 的 中 国 省 份 ， 蒙 古 族 人 口 减 少 到60 万 ， 自 治 区 总 人 口 从1300 万 下 降 到900 万 。 现 在 既 然 中 国 共 产 党 认 识 到 了 这 一 政 策 的 谬 误 ， 内 蒙 古 自 治 区 人 民 代 表 大 会 代 表 和 蒙 古 族 共 产 党 员 们 提 议 ， 纠 正 毛 泽 东 犯 下 的 错 误 ， 恢 复 正 义 ， 把 其 他 省 份 从 自 治 区 取 得 的 土 地 归 还 回 去 ， 并 结 束 同 化 政 策 。 这 显 然 不 会 令 中 国 共 产 党 内 的 左 翼 开 心 ， 但 有 助 于 争 取 民 族 精 英 的 支 持 。 此 外 ， 蒙 古 人 民 共 和 国 和 苏 联 显 然 会 喜 欢 这 一 措 施 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 64)
			{
				text2 = " 泛 阿 拉 伯 主 义";
				text = " 自 从 外 国 人 在 中 东 实 行 殖 民 统 治 以 来 ， 阿 拉 伯 统 治 者 和 知 识 分 子 就 一 直 在 考 虑 建 立 一 个 中 东 所 有 阿 拉 伯 人 的 联 合 国 。 它 反 映 在 由 叙 利 亚 和 埃 及 组 成 的 阿 拉 伯 联 合 共 和 国 ， 该 国 在1958 年 到1971 年 间 一 直 存 在 着 ， 但 是 ， 由 于 著 名 的 泛 阿 拉 伯 主 义 者 埃 及 总 统 纳 赛 尔 努 力 增 强 埃 及 在 联 合 共 和 国 中 的 权 力 ， 叙 利 亚 于1961 年 退 出 了 该 国 。 随 后 ， 在1971 年 ， 埃 及 、 叙 利 亚 和 利 比 亚 成 立 了 阿 拉 伯 共 和 国 联 邦 。 然 而 ， 参 与 国 之 间 存 在 矛 盾 ， 主 要 是 由 纳 赛 尔 之 后 的 萨 达 特 埃 及 开 始 实 行 的 自 由 亲 西 方 政 策 引 起 的 。 但 是 现 在 ， 当 萨 达 特 被 暗 杀 后 ， 在 埃 及 ， 老 总 统 纳 赛 尔 的 支 持 者 上 台 执 政 ， 多 亏 了 阿 拉 伯 共 和 国 联 邦 直 到 现 在 还 正 式 存 在 着 ， 合 并 其 他 阿 拉 伯 国 家 的 想 法 重 新 占 据 了 统 治 圈 的 头 脑 。 此 外 ，7 月30 日 ， 以 色 列 宣 布 耶 路 撒 冷 为 “ 以 色 列 永 恒 不 可 分 割 的 首 都 ” ， 这 引 起 了 阿 拉 伯 世 界 的 不 满 浪 潮 ， 这 提 供 了 另 一 个 为 了 联 合 起 来 对 付 共 同 的 敌 人 的 正 当 理 由 。 在 对 埃 及 给 予 了 一 些 物 质 援 助 并 加 大 了 清 除 对 这 一 发 展 不 满 的 人 的 力 度 之 后 ， 我 们 可 以 恢 复 阿 拉 伯 联 合 共 和 国 ， 这 将 极 大 改 变 中 东 地 区 的 权 力 平 衡 ， 并 得 到 一 个 有 价 值 的 盟 友 。 当 然 ， 他 们 会 听 我 们 的 话 的 …";
			}
			else if (GlobalScript.inst.gameState.number_event == 65)
			{
				text2 = " 再 见 ， 我 们 亲 爱 的 米 沙 …";
				text = " 主 席 同 志 ！1980 年7 月19 日 ， 第 二 十 二 届 夏 季 奥 运 会 开 幕 式 将 在 莫 斯 科 举 行 。 苏 联 奋 力 争 取 到 了 奥 运 会 主 办 权 ， 在 准 备 中 花 费 了 巨 额 资 金 ， 这 些 资 金 不 得 不 从 其 他 支 出 项 目 中 提 取 （ 为 了 收 回 成 本 ， 苏 联 进 行 了 大 规 模 的 奥 运 标 志 销 售 运 动 ） 。 然 而 ， 美 国 领 导 层 已 经 公 开 宣 布 抵 制 这 届 运 动 会 ， 并 呼 吁 其 所 有 盟 友 也 参 加 抵 制 ， 在 费 城 组 织 所 谓 的 “ 奥 林 匹 克 抵 制 运 动 会 ” （ 更 广 为 人 知 的 是 “ 自 由 钟 经 典 运 动 会 ” ） 。 一 些 党 员 敦 促 我 们 以 美 国 为 榜 样 ， 派 一 支 队 伍 去 参 加 美 国 的 运 动 会 ， 抵 制 苏 联 的 奥 运 会 ， 但 这 会 引 起 苏 联 的 愤 怒 和 人 民 的 误 解 。 也 许 你 不 应 该 加 剧 分 裂 ， 把 我 们 的 运 动 员 送 到 莫 斯 科 ， 尽 管 我 们 国 家 之 间 存 在 政 治 矛 盾 ？ 体 育 无 关 政 治 ， 不 是 吗 …";
				if (GlobalScript.inst.gameState.is_party_enabled[0])
				{
					text += "|| 然 而 ， 一 些 党 员 回 顾 了1963 年 新 兴 力 量 运 动 会 的 经 验 （ 印 度 尼 西 亚 总 统 苏 加 诺 在 我 们 的 财 政 援 助 下 举 办 的 “ 第 三 世 界 ” 国 家 的 替 代 性 奥 运 会 ） ， 建 议 我 们 重 振 这 一 赛 事 ， 并 向 苏 联 和 美 国 表 明 ， 我 们 在 体 育 运 动 中 能 够 独 立 于 它 们 。";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 66)
			{
				text2 = " 在 铁 托 之 后 — — 铁 托 啊 ！";
				text = "1980 年1 月3 日 ， 南 斯 拉 夫 社 会 主 义 联 邦 共 和 国 的 创 始 人 、 长 期 领 导 人 、 南 斯 拉 夫 共 产 主 义 者 联 盟 中 央 委 员 会 主 席 约 瑟 普 · 布 罗 兹 · 铁 托 元 帅 在 卢 布 尔 雅 那 的 临 床 中 心 住 院 检 查 腿 部 血 管 。 经 过 两 次 手 术 和 左 腿 截 肢 ， 他 的 病 情 有 所 好 转 ， 但 在2 月 份 ， 铁 托 患 上 了 肺 炎 ： 高 烧 和 胃 、 肠 、 肺 出 血 也 导 致 败 血 症 ，3 月 份 病 情 加 重 。 今 天 走 向 了 终 结 — — 贝 尔 格 莱 德 时 间15:05 卢 布 尔 雅 那 临 床 中 心 心 血 管 疾 病 诊 所 ， 在 他88 岁 生 日 的 前 三 天 ， 约 瑟 普 · 布 罗 兹 · 铁 托 去 世 了 。 葬 礼 将 于5 月8 日 举 行 ， 我 们 需 要 决 定 是 否 有 必 要 派 一 个 代 表 团 去 贝 尔 格 莱 德 ， 或 者 他 值 得 哀 悼 吗 ？ 尽 管 我 们 在 思 想 上 存 在 分 歧 ， 在 外 交 上 也 存 在 差 距 ， 但 铁 托 是 反 法 西 斯 战 争 的 英 雄 之 一 ， 给 他 一 个 铭 记 的 义 务 是 有 道 理 的 。 苏 联 和 美 国 已 经 宣 布 ， 他 们 将 派 出 官 方 政 府 代 表 团 参 加 葬 礼 ， 但 美 国 总 统 卡 特 不 会 去 贝 尔 格 莱 德 … 也 许" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 不 应 该 去 ， 而 应 该 派 出 拥 有 有 限 权 力 的 代 表 团 团 长 姬 鹏 飞 ？";
				if (GlobalScript.inst.gameState.allcountries[20].proprc)
				{
					text += " 然 而 ， 我 们 的 阿 尔 巴 尼 亚 盟 友 已 经 声 明 ， 尽 管 他 们 愿 意 恢 复 与 南 斯 拉 夫 的 贸 易 和 文 化 关 系 ， 但 他 们 将 永 远 不 会 停 止 批 评 “ 修 正 主 义 者 铁 托 和 铁 托 主 义 ” 。 如 果 我 们 派 出 代 表 团 ， 我 们 很 可 能 把 他 们 从 我 们 身 边 赶 走 。";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 67)
			{
				text2 = " 波 兰 尚 未 灭 亡 ？";
				text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					"  同 志 ， 我 国 在 华 沙 的 大 使 馆 收 到 了令 人 震 惊 的 消 息 —9 月6 日 ， 波 兰 统 一 工 人 党 中 央 委 员 会 第 六 届 全 体 会 议 召 开 ， 决 定 解 除 领 导 国 家 和 党10 年 的 爱 德 华 · 盖 莱 克 的 职 务 ， 并 以 妥 协 的 \u200b 斯 坦 尼 斯 瓦 夫 · 卡 尼 亚 取 代 他 。 这 个 国 家 正 处 于 最 严 重 的 政 治 和 经 济 危 机 中 ， 在 中 情 局 帮 助 下 的 反 社 会 主 义 反 对 派 ， 由 所 谓 的 独 立 自 治 工 会 “ 团 结 工 会 ” 领 导 ， 一 年 来 一 直 在 组 织 大 规 模 罢 工 、 集 会 、 游 行 。 巨 额 国 债 （ 近400 亿 美 元 ） ， 在 国 家 的 前 任 领 导 下 逐 渐 堆 积 起 来 ， 波 兰 无 力 偿 还 债 务 。 形 势 显 然 不 受 统 一 工 人 党 的 控 制 ， 苏 联 已 经 开 始 认 真 考 虑 采 取 武 力 干 涉 波 兰 事 务 的 选 择 ， 以1968 年 的 捷 克 斯 洛 伐 克 为 先 例 。 现 在 ， 虽 然 该 国 局 势 极 不 稳 定 ， 但 我 们 有 很 大 的 机 会 进 行 干 预 ， 并 利 用 卡 尼 亚 的 优 柔 寡 断 ， 确 保 由 阿 尔 宾 · 西 瓦 克 和 卡 齐 米 耶 兹 · 米 雅 尔 领 导 的 国 家 主 导 力 量 在 波 兰 掌 权 。 然 而 ， 这 将 导 致 苏 联 的 巨 大 不 满 和 高 额 花 费 ， 所 以 也 许 我 们 不 需 要 这 个 波 兰 ？ …"
				});
			}
			else if (GlobalScript.inst.gameState.number_event == 68)
			{
				text2 = " 光 州 事 件";
				text = "1979 年12 月 政 变 后 ， 全 斗 焕 夺 取 了 韩 国 大 权 ， 开 始 无 情 地 镇 压 反 对 军 政 府 的 抗 议 者 。5 月17 日 ， 戒 严 开 始 了 ，5 月18 日 ， 在 光 州 市 ， 为 反 对 关 闭 全 罗 南 道 国 立 大 学 而 组 织 的 学 生 示 威 遭 到 军 队 镇 压 。 这 引 起 了 城 市 的 不 满 风 暴 ， 并 引 发 了 更 大 的 骚 乱 ， 在 此 期 间 ， 起 义 者 成 功 地 占 领 了 警 察 局 和 军 事 基 地 ， 并 将 军 队 赶 出 了 城 市 。 根 据 我 们 的 情 报 ， 全 斗 焕 政 府 正 准 备 用 正 规 军 夺 取 光 州 。 通 过 支 持 起 义 者 使 其 能 够 坚 持 更 长 的 时 间 ， 以 及 引 导 我 们 情 报 部 门 的 力 量 煽 动 邻 近 地 区 的 不 满 ， 我 们 可 以 严 重 破 坏 韩 国 政 权 的 稳 定 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 69)
			{
				text2 = " 另 一 个 四 人 帮 ？";
				text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					" 同 志 ， 在 你 的 努 力 下 ， 我 们 终 于 铲 除 了 文 化 大 革 命 的 遗 毒 ， 我 们 的 国 家 正 在 走 向 光 明 的 市 场 经 济 未 来 ！ 然 而 ， 仍 然 有 一 些 人 不 同 意 这 样 的 发 展 ， 并 竭 尽 全 力 抗 议 市 场 化 政 策 的 实 施 ， 破 坏 了 我 们 良 好 的 改 革 倡 议 。 这 些 人 主 要 是 保 守 的 毛 派 ， 由 四 名 党 内 高 层 领 导 ， 他 们 拒 绝 进 一 步 的 改 革 。 通 过 打 击 他 们 和 他 们 的 支 持 者 ， 我 们 可 以 让 更 多 的 权 力 掌 握 在 改 革 派 手 中 。 此 外 ， 在 那 些 没 有 保 守 派 的 地 方 ， 我 们 将 有 可 能 促 进 对 改 革 的 积 极 支 持 者 的 产 生 ， 毕 竟 这 些 改 革 已 在 民 众 和 官 僚 中 受 到 欢 迎 。"
				});
			}
			else if (GlobalScript.inst.gameState.number_event == 70)
			{
				text2 = " 周 恩 来 继 承 人 的 问 题";
				text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					" 同 志 ， 多 亏 了 你 的 努 力 ， 我 们 能 够 像 毛 主 席 遗 赠 给 我 们 的 那 样 ， 继 续 朝 着 一 个 光 明 的 共 产 主 义 未 来 前 进 ， 改 革 派 所 有 试 图 动 摇 我 们 的 制 度 ， 破 坏 社 会 主 义 成 就 ， 使 中 国 走 上 资 本 主 义 的 道 路 的 尝 试 都 失 败 了 。 然 而 ， 他 们 中 的 许 多 人 仍 然 有 足 够 的 影 响 力 ， 并 继 续 传 播 他 们 的 修 正 主 义 思 想 ， 必 须 对 此 做 些 什 么 。 你 们 最 激 进 的 支 持 者 建 议 ， 他 们 不 应 该 与 修 正 主 义 者 共 处 一 室 ， 而 是 应 该 直 接 逮 捕 他 们 的 领 导 人 ， 发 动 反 对 改 革 派 的 运 动 ， 但 是 党 和 人 民 不 太 可 能 赞 成 这 种 专 横 的 行 为 ， 你 们 可 以 尝 试 在 党 的 会 议 室 里 解 决 一 切 问 题 。 并 且 我 们 必 须 决 定 如 何 对 待 温 和 派 — — 毛 泽 东 死 后 ， 他 们 大 多 数 支 持 改 革 派 ， 但 现 在 有 些 人 开 始 犹 豫 … …"
				});
			}
			else if (GlobalScript.inst.gameState.number_event == 71)
			{
				text2 = " 东 方 红 …";
				text = " 多 亏 了 我 们 的 支 持 ， 在 印 度 东 部 的 毛 派 反 政 府 武 装 ， 即 纳 萨 尔 派 分 子 ， 在 东 部 各 州 获 得 了 相 当 大 的 影 响 力 和 一 些 公 众 支 持 。 他 们 控 制 着 大 片 地 区 ， 他 们 不 断 的 攻 击 已 经 成 为 令 东 部 各 州 和 印 度 中 央 政 府 头 疼 的 问 题 。 一 些 印 度 政 客 已 经 在 考 虑 与 他 们 谈 判 ， 我 们 可 以 利 用 这 一 点 使 印 度 东 部 的 地 方 政 府 接 纳 纳 萨 尔 派 ， 并 在 谈 判 中 进 行 调 停 ， 这 将 大 大 增 加 我 们 对 印 度 的 影 响 力 ， 并 在 印 度 东 部 实 行 相 对 坚 定 的 左 翼 政 策 。 这 是 以 纳 萨 尔 派 和 印 度 当 局 能 开 始 与 我 们 谈 判 为 前 提 的 。 是 的 ， 保 持 印 度 东 部 的 不 稳 定 状 况 可 以 给 我 们 一 个 有 相 对 机 动 余 地 的 机 会 ， 而 不 是 和 现 在 一 样 的 未 来 … … 然 而 ， 部 分 将 领 和 党 员 已 经 制 定 了 一 个 行 动 计 划 ， 他 们 提 出 利 用 该 形 势 ， 向 伪 阿 鲁 纳 恰 尔 邦 （ 即 我 国 藏 南 地 区 ） 境 内 派 兵 ， 我 们 假 装 “ 保 护 平 民 ， 恢 复 秩 序 ” ， 然 后 就 可 以 毫 无 问 题 地 将 之 收 回 中 国 。 但 这 将 意 味 着 与 印 度 爆 发 新 的 边 境 战 争 …";
			}
			else if (GlobalScript.inst.gameState.number_event == 72)
			{
				text2 = " 拯 救 落 水 者";
				text = " 在1977 年 赢 得 印 度 大 选 后 ， 印 度 人 民 党 ， 实 际 上 是 从 社 会 主 义 者 到 民 族 自 由 主 义 者 的 多 个 政 党 的 联 盟 ， 面 临 着 许 多 困 难 。 最 初 ， 他 们 为 了 把 英 迪 拉 · 甘 地 和 国 大 党 从 权 力 中 除 名 而 团 结 起 来 ， 现 在 ， 在 掌 权 之 后 ， 人 民 党 受 到 了 内 部 阴 谋 的 困 扰 ， 这 实 际 上 使 它 的 工 作 陷 入 瘫 痪 。 以 这 种 速 度 ， 甘 地 将 不 可 避 免 地 赢 得 即 将 在1980 年1 月 举 行 的 选 举 ， 这 就 结 束 了 人 民 党 在 改 善 我 们 与 印 度 关 系 方 面 取 得 的 成 功 。 如 果 我 们 帮 助 反 对 党 并 对 其 施 加 影 响 ， 那 么 我 们 可 以 帮 助 它 巩 固 和 保 住 权 力 …";
			}
			else if (GlobalScript.inst.gameState.number_event == 73)
			{
				text2 = " 两 伊 战 争";
				text = " 伊 朗 与 伊 拉 克 间 的 关 系 长 期 紧 张 ， 这 主 要 是 由 于 领 土 争 端 。1969 年 ， 伊 朗 根 据1937 年 的 协 议 控 制 了 伊 拉 克 的 阿 拉 伯 河 ，1971 年 伊 朗 占 领 了 伊 拉 克 宣 称 的 霍 尔 木 兹 海 峡 内 的 三 个 岛 屿 。 然 而 ， 伊 朗 伊 斯 兰 革 命 胜 利 后 ， 形 势 进 一 步 恶 化 ， 霍 梅 尼 想 把 革 命 传 播 到 整 个 穆 斯 林 世 界 ， 开 始 积 极 派 遣 煽 动 者 和 代 理 人 到 伊 拉 克 。 以 及 支 持 伊 拉 克 库 尔 德 人 争 取 独 立 的 斗 争 。 作 为 对 此 的 回 应 ， 同 时 考 虑 到 伊 朗 军 队 因 革 命 和 伊 斯 兰 清 洗 而 混 乱 ， 萨 达 姆 · 侯 赛 因 决 定 入 侵 伊 朗 ， 以 占 领 石 油 资 源 丰 富 的 胡 兹 斯 坦 省 。9 月22 日 中 午 左 右 ， 伊 拉 克 军 队 入 侵 伊 朗 ， 遭 遇 了 强 烈 的 抵 抗 ， 目 前 正 在 伊 朗 领 土 内 缓 慢 地 进 军 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 74)
			{
				text2 = " 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议";
				text = " 所 以 ， 主 席 同 志 ， 我 们 从1976 年 开 始 编 写 的 这 个 重 要 文 件 的 工 作 已 经 完 成 了 。 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 终 稿 共 有2.8 万 字 ，84 页 ， 中 、 英 、 俄 、 阿 、 西 印 本 。 要 分 析 人 类 的 活 动 、 思 想 、 历 史 、 社 会 ， 揭 示 最 复 杂 的 一 系 列 原 因 ， 并 非 易 事 。 但 是 ， 这 一 工 作 终 于 完 成 了 ， 党 的 十 一 届 六 中 全 会 准 备 审 议 这 一 文 件 。";
				if (GlobalScript.inst.gameState.data[90] == 0)
				{
					text += "| 在 《 决 议 》 中 ， 我 们 从1949 年 开 始 走 的 道 路 是 完 全 被 肯 定 的 ， 毛 泽 东 是 其 中 最 重 要 的 人 物 。 这 当 然 应 该 会 让 人 民 满 意 — — 但 是 这 样 全 面 肯 定 毛 主 席 的 话 ， 党 不 太 可 能 对 他 的 过 分 行 为 也 “ 全 面 肯 定 ” … …";
				}
				else if (GlobalScript.inst.gameState.data[90] == 1)
				{
					text += "| 在 《 决 议 》 中 ， 我 们 从1949 年 开 始 走 的 道 路 是 完 全 被 认 可 的 ， 但 是 “ 一 切 不 好 的 东 西 都 被 矫 正 ， 一 切 好 的 东 西 都 被 巩 固 ” ， 毛 泽 东 被 评 为 “ 功 过 七 三 开 ” 。 这 肯 定 会 使 党 和 人 民 高 兴 …";
				}
				else if (GlobalScript.inst.gameState.data[90] == 2)
				{
					text += "| 在 《 决 议 》 中 ， 我 们 从1949 年 开 始 走 的 道 路 被 批 判 ， 毛 泽 东 的 人 格 被 烙 上 了 烙 印 。 部 分 党 员 会 喜 欢 这 样 ， 然 而 ， 如 果 政 治 局 批 准 它 ， 我 不 能 保 证 会 出 现 什 么 后 果 …";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 75)
			{
				text2 = " 伊 拉 克 核 问 题";
				text = " 刚 刚 从 伊 拉 克 传 来 的 消 息 ， 以 色 列 空 军 在 “ 歌 剧 ” 行 动 中 攻 击 了 “ 塔 木 兹 ” 反 应 堆 ， 将 其 摧 毁 。 由 于 这 次 袭 击 ， 伊 拉 克 的 核 计 划 结 束 了 。 萨 达 姆 现 在 正 在 推 行 一 项 非 常 激 进 的 外 交 政 策 ， 这 将 破 坏 已 经 紧 张 的 中 东 局 势 。 然 而 ， 我 们 或 许 可 以 帮 助 伊 拉 克 继 续 进 行 核 计 划 ， 从 而 在 这 个 战 略 地 区 获 得 一 个 有 用 的 盟 友 。 尽 管 我 不 建 议 依 赖 萨 达 姆 · 侯 赛 因 的 可 靠 性 — — 他 是 与 美 国 、 苏 联 、 我 们 和 不 结 盟 运 动 合 作 的 多 向 政 策 的 著 名 支 持 者 。 有 可 能 ， 即 使 它 拥 有 自 己 的 原 子 弹 也 不 会 改 变 这 一 点 …";
			}
			else if (GlobalScript.inst.gameState.number_event == 76)
			{
				text2 = " 落 井 下 石 ！";
				text = " 主 席 同 志 ， 来 自 南 斯 拉 夫 的 紧 急 新 闻 ！ 在 科 索 沃 社 会 主 义 自 治 省 ， 阿 尔 巴 尼 亚 族 人 的 大 规 模 暴 动 开 始 了 ， 根 据 我 们 的 信 息 ， 这 是 由 阿 尔 巴 尼 亚 的 特 勤 部 门 “ 西 古 里 米 ” 组 织 的 。 抗 议 者 袭 击 了 行 政 建 筑 ， 警 察 局 和 南 斯 拉 夫 人 民 军 的 驻 军 ， 反 塞 族 的 屠 杀 开 始 了 。 省 领 导 和 科 索 沃 的 共 产 主 义 者 联 盟 的 领 导 层 并 没 有 怎 么 抵 抗 ， 这 实 际 上 是 在 支 持 抗 议 者 。 南 斯 拉 夫 主 席 团 在 贝 尔 格 莱 德 举 行 了 紧 急 会 议 ， 决 定 强 力 镇 压 “ 反 革 命 分 离 主 义 叛 乱 ” 。 在 铁 托 死 后 ， 南 斯 拉 夫 的 局 势 开 始 恶 化 ， 看 起 来 凡 尔 赛 条 约 创 造 出 来 的 怪 物 正 在 解 体 。 也 许 我 们 应 该 再 推 一 把 ， 把 他 推 入 深 渊 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 77)
			{
				text2 = " 往 脸 上 吐 口 水 ， 在 下 巴 上 打 一 拳 ， 头 上 一 颗 子 弹";
				text = " 我 们 的 居 民 从 阿 尔 巴 尼 亚 传 达 了 有 趣 的 信 息 — — 阿 尔 巴 尼 亚 领 导 人 恩 维 尔 · 霍 查 和 党 和 国 家 第 二 号 人 物 ， 总 理 穆 罕 默 德 · 谢 胡 之 间 似 乎 存 在 严 重 分 歧 。 很 长 一 段 时 间 以 来 ， 他 是 霍 查 最 亲 密 的 伙 伴 ， 并 通 过 西 古 里 米 的 力 量 确 保 了 国 家 的 稳 定 ， 亲 自 监 督 了20 世 纪40 年 代 中 期 的 几 次 镇 压 反 动 派 叛 乱 ， 并 以 这 句 话 闻 名 ： “ 谁 反 对 我 们 的 领 导 地 位 ， 就 往 他 脸 上 吐 口 水 ， 在 下 巴 上 打 一 拳 ， 而 如 果 必 要 的 话 ， 在 头 上 赏 一 颗 子 弹 ” ， 这 甚 至 （ 在 一 个 消 极 的 背 景 下 ） 在 苏 联 共 产 党 第 二 十 二 次 代 表 大 会 上 被 引 用 。 然 而 ， 在 赫 鲁 晓 夫 的 去 斯 大 林 化 和 阿 尔 巴 尼 亚 与 苏 联 和 社 会 主 义 阵 营 分 裂 的 背 景 下 ， 阿 尔 巴 尼 亚 的 经 济 开 始 因 这 种 孤 立 而 遭 遇 困 难 。 在 劳 动 党 中 ， 越 来 越 多 的 人 倾 向 于 恢 复 与 苏 联 、 南 斯 拉 夫 甚 至 意 大 利 的 关 系 ， 显 然 ， 谢 胡 就 是 其 中 之 一 ， 他 被 迫 解 决 阿 尔 巴 尼 亚 经 济 的 紧 急 问 题 。 他 比 霍 查 更 实 际 和 更 倾 向 于 谈 判 ， 他 可 能 是 一 个 有 用 的 盟 友 。";
				if (!GlobalScript.inst.gameState.allcountries[20].proprc)
				{
					text += " 此 外 ， 他 是 与 中 华 人 民 共 和 国 结 盟 的 支 持 者 ， 他 显 然 很 乐 意 恢 复 我 们 之 间 断 绝 的 关 系 。";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 78)
			{
				text2 = " 永 远 的 总 统";
				text = " 据 我 们 所 知 ， 今 年6 月 菲 律 宾 将 举 行 第 一 次 总 统 选 举 。 自1972 年 以 来 ， 该 国 一 直 处 于 由 费 迪 南 德 · 马 科 斯 总 统 引 入 的 戒 严 状 态 ， 在1981 年1 月 他 解 除 了 戒 严 。 他 担 任 总 统 期 间 的 特 点 是 腐 败 猖 獗 、 裙 带 关 系 和 对 人 权 的 侵 犯 ， 这 导 致 反 对 派 的 活 动 急 剧 增 加 ， 其 中 一 个 领 导 核 心 是 毛 派 的 菲 律 宾 共 产 党 和 由 其 组 成 的 全 国 民 主 阵 线 ， 长 期 以 来 一 直 在 对 马 科 斯 政 权 进 行 运 动 和 游 击 战 争 。 然 而 ， 基 于 国 家 经 济 管 制 的 有 效 经 济 改 革 、 通 过 戒 严 来 镇 压 反 对 派 以 及 美 国 的 支 持 ， 很 可 能 使 他 在 即 将 到 来 的 选 举 中 获 胜 。 然 而 ， 我 们 有 一 个 极 好 的 机 会 破 坏 他 的 胜 利 — — 利 用 特 勤 部 队 向 菲 律 宾 共 产 党 和 全 国 民 主 阵 线 提 供 武 器 ， 我 们 可 以 对 马 科 斯 政 权 和 这 些 假 选 举 发 起 大 规 模 抗 议 。 但 是 ， 它 值 得 吗 ？ 事 实 上 ， 在1975 年 马 科 斯 断 绝 与 台 湾 的 关 系 ， 并 与 中 国 建 立 关 系 后 ， 周 恩 来 承 诺 ， 中 华 人 民 共 和 国 不 会 干 涉 菲 律 宾 的 政 策 ， 因 此 ， 也 许 与 马 科 斯 合 作 更 好 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 79)
			{
				text2 = " 紧 缩 政 策";
				text = "20 世 纪70 年 代 初 ， 罗 马 尼 亚 利 用 齐 奥 塞 斯 库 与 西 方 的 良 好 关 系 ， 积 极 向 国 际 货 币 基 金 组 织 借 款 ， 但 在20 世 纪70 年 代 的 能 源 危 机 后 ， 罗 马 尼 亚 作 为 一 个 石 油 出 口 大 国 深 受 打 击 且 债 务 缠 身 ， 这 使 罗 马 尼 亚 的 经 济 形 势 迅 速 恶 化 。 在 这 种 情 况 下 ， 罗 马 尼 亚 的 消 费 品 价 格 在20 世 纪70 年 代 末 开 始 上 涨 ， 现 在 齐 奥 塞 斯 库 决 定 转 向 紧 缩 政 策 ， 这 意 味 着 大 量 减 少 进 口 和 扩 大 出 口 ， 以 便 获 得 利 润 来 偿 还 债 务 。 这 不 可 避 免 地 限 制 了 该 国 居 民 的 用 水 和 用 电 ， 许 多 产 品 实 行 了 定 量 配 给 制 度 ， 这 一 制 度 严 重 地 损 害 了 罗 马 尼 亚 的 生 活 水 平 。 齐 奥 塞 斯 库 是 苏 维 埃 社 会 主 义 阵 营 中 唯 一 与 中 国 保 持 良 好 关 系 的 统 治 者 ， 即 使 我 们 与 苏 联 断 绝 了 关 系 ， 帮 助 他 度 过 这 场 危 机 可 能 是 值 得 的 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 80)
			{
				text2 = " 中 共 十 二 大";
				text = " 接 下 来 ， 第 十 二 届 中 国 共 产 党 全 国 代 表 大 会 在 北 京 的 人 民 大 会 堂 隆 重 召 开 。 本 届 代 表 大 会 中 出 席 正 式 代 表1545 人, 候 补 代 表149 人 。 代 表 全 国3965 万 多 名 党 员 。 议 程 平 平 无 奇 … 然 而 ， 既 然 党 的 十 一 届 六 中 全 会 通 过 了 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 ， 我 们 在 其 中 指 出 了 去 毛 泽 东 化 并 走 向 民 主 的 可 能 性 ， 那 么 ， 或 许 有 必 要 召 开 一 次 秘 密 会 议 ， 宣 读 一 份 由 党 的 顾 问 事 先 准 备 好 的 报 告 《 关 于 对 毛 泽 东 的 个 人 崇 拜 及 其 后 果 的 克 服 》 ？ 然 而 ， 这 也 冒 着 严 重 损 害 中 国 共 产 党 地 位 和 名 誉 的 风 险 — — 也 许 只 用 在 党 的 报 告 中 提 到 “ 纠 正 毛 泽 东 犯 下 的 所 有 错 误 ” ， 并 以 此 为 借 口 ， 开 始 谨 慎 地 非 正 式 地 去 毛 泽 东 化 ？ 或 者 根 本 就 不 去 讨 论 这 个 问 题 ？ …";
			}
			else if (GlobalScript.inst.gameState.number_event == 81)
			{
				text2 = " 匈 牙 利 狂 想 曲";
				text = " 来 自 布 达 佩 斯 的 奇 怪 消 息 — — 似 乎 在 赫 鲁 晓 夫 时 代 所 夸 耀 的 的 卡 达 尔 主 义 者 的 “ 古 拉 什 社 会 主 义 ” 正 处 于 违 约 的 边 缘 — — 实 际 上 ， 匈 牙 利 欠 下 了 国 际 货 币 基 金 组 织77 亿 美 元 ， 而 这 是 它 无 力 支 付 的 。 根 据 我 们 的 经 济 学 家 的 看 法 ， 匈 牙 利 人 有 两 个 选 择 — — 要 么 从 西 方 和 苏 联 获 得 新 的 贷 款 ， 要 么 开 始 全 面 的 市 场 改 革 ， 这 将 损 害 大 多 数 人 的 生 活 水 平 。 匈 牙 利 社 会 主 义 工 人 党 的 领 导 人 不 会 采 取 后 一 个 选 择 ， 因 为 他 们 还 记 得 布 拉 格 之 春 事 件 ， 所 以 他 们 很 可 能 会 接 受 新 的 贷 款 。 我 们 可 以 利 用 匈 牙 利 人 民 共 和 国 的 问 题 ， 向 他 们 提 供 我 们 的 经 济 援 助 — — 但 条 件 是 为 受 辱 的 斯 大 林 主 义 者 比 斯 库 · 贝 洛 及 其 集 团 平 反 ， 他 们 反 对 半 市 场 改 革 ， 并 可 以 成 为 我 们 在 匈 社 工 党 内 的 可 靠 支 持 者 。 但 是 ， 我 们 也 可 以 在 不 提 出 政 治 条 件 的 情 况 下 ， 为 溺 水 者 提 供 帮 助 …";
			}
			else if (GlobalScript.inst.gameState.number_event == 82)
			{
				text2 = " 福 克 兰 群 岛 战 争";
				text = " 英 国 最 近 正 在 经 历 困 难 时 刻 ， 失 去 了 它 曾 经 显 赫 的 影 响 力 。 由 莱 奥 波 尔 多 · 加 尔 铁 里 领 导 的 阿 根 廷 军 政 府 决 定 利 用 这 一 机 会 发 动 “ 小 规 模 胜 利 战 争 ” 。4 月2 日 ， 阿 根 廷 伞 兵 登 陆 英 属 福 克 兰 群 岛 ， 群 岛 的 归 属 长 期 受 阿 根 廷 挑 战 ， 但 小 规 模 英 国 驻 军 的 抵 抗 很 快 就 被 击 溃 了 。 作 为 回 应 ， 英 国 向 群 岛 派 出 舰 队 ， 意 在 封 锁 群 岛 。 看 起 来 世 界 上 又 要 爆 发 新 的 冲 突 了 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 83)
			{
				text2 = " 斯 塔 夫 罗 波 尔 农 学 家 的 问 题";
				text = " 我 们 的 特 勤 部 门 设 法 获 得 了 重 要 的 信 息 。 据 了 解 ， 苏 联 的 农 业 问 题 相 当 严 重 ， 今 年 的 强 降 雨 更 加 剧 了 情 况 。 农 业 书 记 费 多 尔 · 库 拉 科 夫 ， 苏 共 中 央 委 员 会 书 记 ， 是 现 任 苏 维 埃 领 导 人 列 昂 尼 德 · 勃 列 日 涅 夫 最 有 可 能 的 继 任 者 之 一 。 根 据 我 方 特 工 获 得 的 信 息 ， 库 拉 科 夫 热 衷 于 积 极 研 究 并 将 匈 牙 利 和 南 斯 拉 夫 的 经 验 引 入 苏 联 农 业 （ 即 分 散 集 体 农 场 和 国 营 农 场 的 管 理 ， 根 据 家 庭 合 同 和 独 资 农 场 创 建 农 业 合 作 社 ） 。 在 即 将 召 开 的 苏 共 中 央 全 会 上 ， 我 们 可 以 以 此 来 诋 毁 他 ， 从 而 从 道 路 上 消 除 这 种 危 险 的 改 革 派 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 84)
			{
				text2 = " 我 们 的 老 游 击 队 员 …";
				text = " 既 然 费 多 尔 · 库 拉 科 夫 已 经 出 局 ， 现 在 是 时 候 关 注 一 下 苏 共 的 保 守 派 了 。 当 然 ， 在 其 中 ， 最 显 赫 的 人 物 就 是 白 俄 罗 斯 共 产 党 中 央 委 员 会 第 一 书 记 彼 得 · 马 谢 罗 夫 。1965 年 ， 前 游 击 队 指 挥 官 马 谢 罗 夫 开 始 领 导 白 俄 罗 斯 ， 在 这 个 苏 联 加 盟 国 的 发 展 中 取 得 了 非 常 显 著 的 成 就 — — 国 民 收 入 增 长 了 几 倍 ， 工 农 业 发 展 活 跃 ， 建 立 了 一 批 企 业 ， 包 括 亚 速 特 化 学 联 合 企 业 、 诺 沃 布 洛 茨 克 化 工 厂 “ 聚 合 物 ” 、 戈 梅 利 化 工 厂 ， 别 列 佐 夫 斯 卡 亚 地 区 发 电 厂 。 由 于 马 谢 罗 夫 的 个 人 介 入 ， 明 斯 克 开 始 建 设 地 铁 。 公 顷 粮 食 产 量 达 到27 森 特 纳/ 公 顷 （1 森 特 纳 约 合50 千 克 ） ， 总 粮 食 产 量 达 到730 万 吨 。 然 而 ， 马 谢 罗 夫 对 革 新 队 伍 的 态 度 ， 引 起 了 许 多 党 员 的 不 满 ， 他 与 苏 共 的 主 要 意 识 形 态 专 家 米 哈 伊 尔 · 苏 斯 洛 夫 的 关 系 相 当 矛 盾 ， 也 与 蒙 羞 的 库 拉 科 夫 关 系 紧 密 。 然 而 ， 列 昂 尼 德 · 勃 列 日 涅 夫 显 然 将 他 视 为 部 长 会 议 主 席 柯 西 金 的 接 班 人 ， 而 柯 西 金 本 人 也 赞 同 这 一 选 择 。 国 安 部 已 经 为 清 除 马 谢 罗 夫 出 局 准 备 了 几 个 选 项 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 85)
			{
				text2 = " 哈 萨 克 斯 坦 的 德 意 志 族 自 治 区";
				text = " 我 们 在 莫 斯 科 的 消 息 来 源 设 法 获 得 了 有 趣 的 信 息 — — 一 个 由Y. 安 德 罗 波 夫 、I. 卡 皮 诺 夫 、M. 齐 米 宁 、Z. 努 里 耶 夫 、N. 什 切 洛 科 娃 、R. 鲁 登 科 、M. 乔 治 泽 、V. 切 布 里 科 娃 组 成 的 委 员 会 向 苏 联 中 央 委 员 会 提 交 了 一 份 关 于 在 哈 萨 克 斯 坦 苏 维 埃 社 会 主 义 共 和 国 建 立 德 意 志 族 自 治 区 的 提 案 （30 —40 年 代 ，94 万 德 意 志 人 被 派 到 这 里 ） 然 而 ， 由 列 昂 尼 德 · 勃 列 日 涅 夫 的 亲 密 盟 友 金 姆 哈 梅 塔 · 库 纳 耶 夫 领 导 的 共 和 国 领 导 层 强 烈 反 对 这 一 点 。 据 我 们 所 知 ， 他 们 甚 至 准 备 组 织 哈 萨 克 人 民 的 暴 乱 ， 以 防 这 种 自 治 区 被 创 造 出 来 。 库 纳 耶 夫 是 苏 联 领 导 层 组 成 发 生 变 化 时 最 有 可 能 担 任 苏 共 中 央 第 二 书 记 的 人 选 之 一 。 他 的 反 华 情 绪 并 不 是 秘 密 。 利 用 形 势 推 翻 他 是 有 道 理 的 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 86)
			{
				text2 = " “ 钢 铁 尤 里 ” 的 终 结";
				text = " 我 们 得 知 ， 列 昂 尼 德 · 勃 列 日 涅 夫 刚 刚 前 往 维 也 纳 ， 与 美 国 总 统 卡 特 就 第 二 轮 的 限 制 战 略 武 器 谈 判 协 议 进 行 谈 判 。 当 然 ， 帝 国 主 义 者 不 会 做 任 何 “ 战 略 进 攻 性 武 器 的 限 制 ” ， 但 我 们 对 此 不 感 兴 趣 — — 勃 列 日 涅 夫 将 在 国 外 待 上 足 够 的 时 间 ， 因 此 我 们 能 够 打 击 苏 联 克 格 勃 领 导 人 尤 里 · 安 德 罗 波 夫 。 他 被 认 为 是 逐 步 改 善 苏 美 关 系 和 在 匈 牙 利 模 式 下 进 行 大 规 模 改 革 的 支 持 者 。 现 在 安 德 罗 波 夫 开 始 被 认 为 是 勃 列 日 涅 夫 最 有 可 能 的 继 任 者 。 有 两 种 方 法 可 以 让 他 出 局 ： 要 么 以 因 肾 衰 竭 死 亡 为 掩 盖 ， 从 肉 体 上 消 灭 他 ， 要 么 试 图 “ 推 动 ” 与 苏 联 秘 密 警 察 领 导 人 关 系 极 差 的 苏 共 主 要 理 论 家 米 哈 伊 尔 · 苏 斯 洛 夫 和 苏 共 乌 克 兰 党 组 织 领 导 人 弗 拉 基 米 尔 · 谢 尔 比 茨 基 ， 召 开 苏 共 中 央 紧 急 全 会 ， 在 会 上 彻 底 击 垮 安 德 罗 波 夫 。 乌 克 兰 克 格 勃 由 维 塔 利 · 费 多 尔 丘 克 上 校 领 导 ， 他 服 从 谢 尔 比 茨 基 ， 与 他 的 盟 友 没 有 矛 盾 ， 所 以 我 们 成 功 的 机 会 很 大 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 87)
			{
				text2 = " 加 利 利 的 和 平";
				text = " 由 于 黎 巴 嫩 领 导 层 的 软 弱 ， 自1975 年 以 来 内 战 一 直 在 黎 巴 嫩 境 内 继 续 ， 再 加 上 阿 拉 伯 国 家 的 积 极 援 助 ， 使 得 巴 勒 斯 坦 解 放 组 织 能 够 在 黎 巴 嫩 南 部 部 署 一 个 不 受 政 府 控 制 的 与 以 色 列 作 战 的 据 点 。 双 方 不 断 地 相 互 开 火 ， 但 现 在 冲 突 似 乎 进 入 了 白 热 化 阶 段 。6 月3 日 ， 以 色 列 大 使 在 伦 敦 遇 刺 （ 结 果 ， 其 实 是 另 一 个 巴 勒 斯 坦 组 织 对 此 负 有 责 任 ， 与 巴 解 组 织 没 有 任 何 关 系 ） ， 这 成 为 以 色 列 大 规 模 轰 炸 黎 巴 嫩 的 借 口 ，6 月6 日 ， 以 色 列 军 队 越 过 黎 巴 嫩 边 界 ， 与 巴 解 组 织 的 军 队 激 战 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 88)
			{
				text2 = " 津 巴 布 韦 种 族 隔 离 的 终 结";
				text = " 在 罗 得 西 亚 （ 又 称 津 巴 布 韦 ） ， 黑 人 多 数 对 抗 支 持 种 族 隔 离 政 策 的 白 人 当 局 的 武 装 斗 争 已 经 进 行 了 多 年 ， 看 起 来 局 势 似 乎 发 生 了 转 变 。1979 年12 月 ， 举 行 了 兰 开 斯 特 宫 会 议 ， 会 上 达 成 了 举 行 平 等 普 选 的 协 议 ， 在 进 一 步 决 定 国 家 命 运 前 ， 要 求 停 火 ， 并 正 式 恢 复 津 巴 布 韦 － 罗 得 西 亚 英 国 殖 民 地 的 地 位 。 结 果 ， 由 穆 加 贝 和 津 巴 布 韦 非 洲 民 族 联 盟 领 导 的 左 翼 民 族 主 义 联 盟 赢 得 了 选 举 ，4 月18 日 ， 该 国 宣 布 独 立 ， 改 名 为 津 巴 布 韦 。 曾 经 ， 我 们 像 苏 联 一 样 ， 支 持 更 温 和 的 津 巴 布 韦 非 洲 人 民 联 盟 — 津 巴 布 韦 非 洲 民 族 联 盟 目 前 在 联 盟 中 的 盟 友 — 因 此 ， 继 续 与 获 胜 的 左 派 合 作 可 能 是 值 得 的 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 89)
			{
				text2 = " 一 个 时 代 的 终 结";
				text = " 来 自 苏 联 的 紧 急 消 息 ！ 今 天 ， 苏 联 领 导 人 宣 布 列 昂 尼 德 · 伊 里 奇 · 勃 列 日 涅 夫 去 世 ， 他 领 导 苏 联 接 近20 年 。11 月10 日 ， 这 位 苏 联 领 导 人 在 梦 中 死 于 突 发 性 心 力 衰 竭 。 在 苏 联 人 民 哀 悼 之 际 ， 苏 共 展 开 了 一 场 激 烈 的 权 力 斗 争 ， 苏 共 中 央 总 书 记 的 主 要 竞 争 者 是 ：";
				if (GlobalScript.inst.gameState.empires[1].leaders[3].support > 0)
				{
					text += "|| 尤 里 · 安 德 罗 波 夫 ， 苏 联 克 格 勃 领 导 人 ， 一 位 务 实 的 改 革 者 ， 积 极 提 拔 他 的 改 革 派 伙 伴 ， 如 戈 尔 巴 乔 夫 、 利 加 乔 夫 和 多 尔 吉 赫 。";
				}
				if (GlobalScript.inst.gameState.empires[1].leaders[1].support > 0)
				{
					text += "|| 弗 拉 基 米 尔 · 谢 尔 比 茨 基 ， 乌 克 兰 共 产 党 领 导 人 ， 一 位 忠 诚 的 勃 列 日 涅 夫 主 义 者 ， 在 发 展 经 济 和 提 高 乌 克 兰 苏 维 埃 社 会 主 义 共 和 国 生 活 水 平 方 面 取 得 了 巨 大 成 功 。";
				}
				text += "|| 康 斯 坦 丁 · 契 尔 年 科 ， 苏 共 中 央 委 员 会 总 务 部 部 长 ， 一 位 保 守 派 党 员 和 经 验 丰 富 的 组 织 者 ， 有 些 人 甚 至 认 为 他 是 斯 大 林 主 义 者 。|| 如 果 我 们 与 苏 联 的 关 系 不 太 糟 ， 那 么 我 们 可 以 支 持 其 中 一 个 候 选 人 。 当 然 ， 这 不 会 从 根 本 上 改 变 形 势 ， 但 在 相 持 的 情 况 下 ， 这 可 能 会 使 天 平 倾 向 一 个 更 适 宜 的 候 选 人 。";
				if (GlobalScript.inst.gameState.data[89] == 0)
				{
					GlobalScript.inst.gameState.empires[1].leaders[3].support--;
				}
				if (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power)
				{
					GlobalScript.inst.gameState.empires[1].leaders[2].support++;
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 90)
			{
				text2 = " 香 港 再 见 ， 澳 门 再 见 ？";
				text = " 如 你 所 知 ， 我 们 就 香 港 和 澳 门 在1997 年 和1999 年 回 归 后 获 取 的 广 泛 自 治 权 问 题 达 成 了 数 项 协 议 ， 我 们 甚 至 为 此 设 立 了 一 个 新 的 行 政 单 位 — — “ 特 别 行 政 区 ” 。 然 而 ， 港 澳 部 分 大 资 产 阶 级 人 士 反 对 这 项 协 议 ， 而 我 们 的 情 报 机 构 查 明 ， 他 们 正 准 备 进 行 一 系 列 挑 衅 活 动 ， 以 破 坏 协 议 签 署 ， 并 维 持 英 国 和 葡 萄 牙 的 殖 民 统 治 （ 特 别 是 最 大 限 度 地 拖 延 特 别 行 政 区 的 基 本 法 的 制 定 ， 举 行 反 华 集 会 ， 并 在 媒 体 上 发 表 有 煽 动 性 的 材 料 ） 。 在 这 种 情 况 下 ， 一 些 党 员 提 出 了 一 个 令 人 出 乎 意 料 的 建 议 — — 与 所 谓 的 三 合 会 建 立 联 系 。 三 合 会 是 香 港 第 七 大 最 有 影 响 力 的 犯 罪 集 团 ， 他 们 在 整 个 东 南 亚 都 有 强 大 的 关 系 。 我 们 可 以 向 他 们 提 供 优 惠 的 经 济 优 惠 和 司 法 豁 免 保 障 ， 但 条 件 是 他 们 要 协 助 香 港 和 澳 门 回 归 祖 国 。 所 以 你 的 决 定 是 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 91)
			{
				text2 = " 仰 光 爆 炸 事 件";
				text = " 根 据 我 们 的 情 报 ， 今 天 在 缅 甸 首 都 发 生 了 一 起 恐 怖 袭 击 ， 目 的 是 刺 杀 韩 国 总 统 全 斗 焕 。 由 于 全 斗 焕 在 爆 炸 发 生 两 分 钟 后 抵 达 现 场 ， 他 本 人 幸 免 于 难 ， 但 有17 名 韩 国 代 表 团 成 员 丧 生 。 恐 怖 分 子 很 快 被 抓 获 ， 经 过 审 问 ， 他 们 承 认 自 己 是 朝 鲜 军 队 的 军 官 。 而 朝 鲜 政 府 矢 口 否 认 与 此 事 有 任 何 牵 连 ， 但 实 际 上 ， 这 一 事 件 让 我 们 有 机 会 重 新 挑 起 朝 鲜 和 韩 国 之 间 的 对 抗 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 92)
			{
				text2 = " 超 额 完 成 是 荣 誉 ！";
				text = " 主 席 同 志 ！ 考 虑 到 即 将 实 施 新 的 五 年 计 划 ， 部 分 来 自 计 委 的 专 家 和 经 济 学 家 建 议 为 下 个 五 年 选 择 一 个 重 点 发 展 的 经 济 部 门 。 你 需 要 决 定 国 民 经 济 中 哪 个 部 门 需 要 特 别 关 注 和 政 府 投 资 － 工 业 、 农 业 、 服 务 业 或 者 发 展 科 学 ？ 但 是 ， 我 们 也 可 以 更 谨 慎 地 使 用 资 金 ， 将 力 量 集 中 到 同 时 均 衡 发 展 三 个 产 业 ， 这 会 使 它 们 的 发 展 更 均 衡 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 93)
			{
				text2 = " 民 主 的 故 乡";
				text = " 希 腊 仍 在 从1974 年 被 推 翻 的 军 政 府 的 影 响 中 恢 复 过 来 ， 议 会 选 举 已 经 提 上 日 程 。 在 该 国 重 建 民 主 以 后 ， 有 两 个 主 要 政 党 ： 自 由 — 保 守 的 新 民 主 党 ， 和 左 翼 社 会 民 主 主 义 者 的 泛 希 腊 社 会 主 义 运 动 （PASOK ） 。 因 为 希 腊 的 政 治 路 线 ， 如 加 入 北 约 （ 该 国 在1974 年 因 为 土 耳 其 入 侵 塞 浦 路 斯 而 退 盟 ） ， 加 入 欧 盟 实 际 上 还 在 待 议 中 ， 选 举 的 结 果 会 严 重 影 响 该 国 的 局 势 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 94)
			{
				if (GlobalScript.inst.gameState.faction_leader[4] == 200)
				{
					for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
					{
						if (GlobalScript.inst.gameState.politics[i].traits[0] == 3 && GlobalScript.inst.gameState.politics[i].power > ((GlobalScript.inst.gameState.faction_leader[4] != 200) ? GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].power : 0))
						{
							GlobalScript.inst.gameState.faction_leader[4] = i;
						}
					}
				}
				text2 = " 又 一 次 天 安 门 事 件 ？ ！";
				text = " 对 各 个 涉 及 人 民 生 活 领 域 的 大 规 模 改 革 政 策 、 日 益 猖 獗 的 腐 败 、 中 国 共 产 党 与 商 界 的 勾 结 以 及 权 贵 与 商 人 之 间 秘 密 的 腐 败 联 系 ， 导 致 资 产 阶 级 自 由 化 思 想 在 相 当 一 部 分 的 中 国 知 识 分 子 和 青 年 中 广 泛 传 播 ， 他 们 要 求 更 激 进 的 改 革 ， 反 对 “ 共 产 主 义 传 染 病 ” 。 因 此 他 们 组 织 了 一 场 由 持 不 同 政 见 的 天 体 物 理 学 家 方 励 之 （ 在 西 方 被 称 为 “ 中 国 的 萨 哈 罗 夫 ” ） 所 领 导 的 “ 退 党 ” 运 动 ， 运 动 的 主 张 是 宣 布 中 国 共 产 党 为 “ 犯 罪 组 织 ” ， 并 剥 夺 党 的 一 切 权 力 、 要 求 国 家 的 自 由 化 和 西 方 化 、 打 击 腐 败 和 消 灭 官 僚 的 特 权 。 利 用 了 政 府 内 部 的 混 乱 ， 十 万 “ 退 党 ” 支 持 者 聚 集 在 北 京 天 安 门 广 场 举 行 群 众 活 动 。 他 们 要 求 “ 自 由 ” 、 “ 民 主 ” 、 “ 打 击 腐 败 官 僚 ” 和 “ 打 倒 腐 败 的 党 的 领 导 ” ， 而 其 他 包 括 工 人 在 内 的 对 我 们 的 改 革 不 满 的 人 ， 每 天 都 在 加 入 他 们 的 行 列 。 中 国 共 产 党 党 内 的 自 由 派 领 导 人" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2] + " ， 倾 向 于 对 抗 议 者 妥 协 让 步 ， 希 望 通 过 抗 议 活 动 执 掌 党 政 大 权 。 国 内 局 势 极 不 稳 定 ， 但 现 在 仍 有 机 会 进 行 干 预 — — 在 动 乱 蔓 延 到 其 他 城 市 之 前...";
			}
			else if (GlobalScript.inst.gameState.number_event == 95)
			{
				text2 = " 中 国 共 产 党 的 新 开 始";
				text = " 因 此 ， 北 京 的 形 势 得 到 了 控 制 ， 国 家 的 权 力 移 交 给 了 以" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 为 首 的 中 国 共 产 党 内 的 自 由 派 。 议 事 日 程 上 的 问 题 是 大 规 模 深 化 “ 改 革 开 放 ” 政 策 以 及 向 西 式 民 主 和 自 由 市 场 的 过 渡 。 然 而 ， 我 们 现 在 不 得 不 考 虑 “ 退 党 ” 运 动 要 求 在 改 革 进 程 中 考 虑 到 使 中 国 社 会 和 执 政 党 去 共 产 主 义 化 的 必 要 性 。 原 则 上 ， 现 在 中 国 共 产 党 很 难 称 之 为 “ 共 产 党 ” ， 但 现 在 我 们 被 要 求 完 全 抛 弃 马 克 思 列 宁 主 义 。 那 么 ？ …";
			}
			else if (GlobalScript.inst.gameState.number_event == 96)
			{
				text2 = " 改 革 ！ 民 主 ！ 开 放 ！";
				text = " 现 在 ， 党 组 织 上 问 题 结 束 了 ， 我 们 需 要 履 行 我 们 对 人 民 关 于 按 照 西 方 模 式 对 国 家 民 主 化 的 诺 言 。 人 民 要 求 停 止 对 宗 教 和 教 士 施 压 ， 基 于 西 方 国 家 模 式 扩 大 民 权 和 自 由 ， 更 重 要 的 是 ， 解 散 “ 爱 国 统 一 战 线 ” ， 进 行 人 大 内 和 各 地 方 的 自 由 选 举 。 如 果 我 们 不 能 避 免 选 举 的 到 来 ， 只 要 我 们 满 足 了 人 民 其 他 的 要 求 ， 就 能 使 他 们 得 到 我 们 所 需 要 的 “ 自 由 选 举 ” 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 97)
			{
				text2 = " 自 动 化 ？";
				text = " 这 是 我 们 最 伟 大 的 科 学 突 破 － 最 近 以 来 我 们 与 经 济 完 全 落 后 的 情 况 斗 争 ， 现 在 我 们 的 科 学 家 在 基 于 计 算 机 系 统 开 发 自 动 化 经 济 计 划 的 机 制 方 面 取 得 了 杰 出 成 就 ， 并 开 始 开 发 允 许 自 动 化 计 划 和 调 节 全 国 企 业 的 系 统 。 距 离 系 统 的 全 面 实 施 仍 有 相 当 距 离 ， 但 现 在 如 果 我 们 想 取 得 自 动 化 经 济 的 成 功 的 话 ， 我 们 可 以 并 也 应 该 引 入 基 层 地 区 的 系 统 和 协 作 。 但 是 ， 许 多 官 员 和 党 员 ， 认 为 引 入 这 样 一 个 不 熟 悉 的 系 统 太 匆 忙 了 ， 他 们 显 然 不 喜 欢 它 …";
			}
			else if (GlobalScript.inst.gameState.number_event == 98)
			{
				text2 = " 非 洲 的 切 · 格 瓦 拉";
				text = " 主 席 同 志 ， 来 自 前 法 国 殖 民 地 上 沃 尔 特 的 紧 急 消 息 ！ 在 人 民 中 广 受 欢 迎 的 前 总 理 兼 同 时 具 有 影 响 力 的 军 事 人 物 托 马 斯 · 桑 卡 拉 几 个 月 前 逮 捕 并 推 翻 了 大 规 模 地 镇 压 工 会 运 动 和 杀 害 反 对 者 并 支 持 法 国 的 总 统 让 · 巴 普 蒂 斯 特 · 奥 德 雷 戈 。 军 事 政 变 后 ， 这 个 国 家 的 名 称 立 即 从 殖 民 地 的 “ 上 沃 尔 特 ” 改 为 “ 布 基 纳 法 索 “ ， 意 为 ” 诚 实 人 民 之 家 ” ， 所 有 的 国 家 符 号 都 完 全 改 变 了 。 现 在 ， 坚 持 革 命 反 帝 国 主 义 观 点 的 托 马 斯 · 桑 卡 拉 宣 布 了 建 设 社 会 主 义 和 “ 反 对 反 革 命 社 会 阶 级 ” 的 政 策 ， 这 反 过 来 又 使 他 的 地 位 不 稳 定 。 为 了 进 行 革 命 变 革 ， 实 现 “ 使 整 个 国 家 站 起 来 ” 的 目 标 ， 桑 卡 拉 正 在 向 社 会 主 义 国 家 寻 求 帮 助 。 也 许 我 们 应 该 承 认 新 政 权 ， 派 出 大 使 ， 从 而 显 示 出 我 们 的 仁 爱 意 图 。 然 而 ， 在 必 要 的 支 持 下 ， 极 为 接 近 毛 泽 东 的 激 进 的 左 翼 反 帝 国 主 义 观 点 ， 也 能 为 我 们 在 中 非 建 立 一 个 稳 定 的 盟 友 。 尽 管 … 在 非 洲 大 陆 如 此 仓 促 和 “ 摇 摆 不 定 的 革 命 之 舟 ” 也 许 不 值 得 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 117)
			{
				text2 = " 五 年 修 葬";
				text = " 来 自 苏 联 的 消 息 — — 二 月 九 日 ， 苏 共 中 央 总 书 记 尤 里 · 安 德 罗 波 夫 因 肾 衰 去 世 ， 享 年69 岁 。 自1983 年 末 他 已 病 魔 缠 身 ， 在 克 里 米 亚 感 的 冒 终 于 带 走 了 他 。 任 期 内 ， 安 德 罗 波 夫 非 常 关 心 苏 联 经 济 的 改 善 — — 一 场 加 强 劳 动 纪 律 的 运 动 开 始 了 ， 经 济 流 通 中 的 非 法 瞒 报 被 大 规 模 打 击 。 同 时 ， 安 德 罗 波 夫 积 极 提 拔 年 轻 的 改 革 家 并 要 求 戈 尔 巴 乔 夫 、 雷 日 科 夫 、 阿 巴 尔 金 、 多 尔 吉 赫 准 备 苏 联 境 内 大 规 模 的 经 济 改 革 计 划 。 有 鉴 于 愈 发 激 烈 的 政 治 斗 争 ， 妥 协 者 契 尔 年 科 很 有 可 能 会 接 过 总 书 记 的 职 位 。2 月14 日 预 定 举 行 安 德 罗 波 夫 的 葬 礼 ， 各 国 代 表 估 计 都 要 来 露 个 脸 ， 不 管 是 苏 联 的 盟 国 还 是 别 的 。 那 么 ， 我 们 要 做 什 么 呢?";
			}
			else if (GlobalScript.inst.gameState.number_event == 114)
			{
				text2 = " 驴 象 之 争";
				text = " 美 国 总 统 大 选 很 快 就 要 举 行 ， 民 主 党 总 统 吉 米 · 卡 特 准 备 在 和 共 和 党 野 心 勃 勃 的 罗 纳 德 · 里 根 的 竞 争 中 拿 下 第 二 个 任 期 。 第 一 个 任 期 里 吉 米 · 卡 特 努 力 改 善 美 国 人 民 的 福 利 、 建 设 更 加 开 放 的 政 府 、 对 美 国 政 府 机 构 在 全 局 上 进 行 改 革 。 他 的 外 交 政 策 特 点 是 在 与 苏 联 的 对 抗 与 缓 和 中 找 到 平 衡 。 但 是 ， 他 的 领 导 在 节 节 攀 升 的 油 价 中 撞 得 头 破 血 流 ， 相 对 缓 和 的 外 交 政 策 也 在 保 守 派 圈 子 里 被 大 大 批 判 一 番 ， 所 以 共 和 党 的 胜 利 基 本 已 经 稳 了 。 反 正 我 们 也 管 不 了 ， 等 着 看 吧 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 99)
			{
				text2 = " 黄 蝎";
				text = " 主 席 同 志 ， 从 社 会 主 义 阿 尔 及 利 亚 传 来 的 紧 急 消 息 ！ 第 二 任 阿 尔 及 利 亚 人 民 民 主 共 和 国 总 统 胡 阿 里 · 布 麦 丁 ， 那 位 以 神 秘 与 狡 诈 被 人 民 昵 称 黄 蝎 的 总 统 ， 在 暴 病 后 猝 死 。 在 十 五 年 的 总 统 生 涯 中 ， 他 在 落 后 的 法 国 殖 民 地 里 建 设 起 一 个 强 大 的 非 洲 工 业 巨 人 。 现 在 ， 由 于 继 承 危 机 ， 执 政 的 国 家 解 放 阵 线 中 三 派 已 经 开 始 争 夺 权 力 。 他 们 是 由 穆 罕 默 德 · 萨 拉 · 雅 伊 奥 维 领 导 、 由 工 会 积 极 支 持 的 、 反 对 同 苏 修 联 盟 的 传 统 斯 大 林 派 ， 由 沙 德 利 · 本 · 杰 迪 德 领 导 的 支 持 阿 苏 友 好 关 系 并 引 入 市 场 改 革 的 温 和 改 革 派 与 由 亲 西 的 外 交 部 长 阿 卜 杜 勒 阿 齐 兹 · 布 特 弗 利 卡 领 导 的 自 由 派 。 支 持 任 何 一 派 都 会 扩 大 我 们 在 这 里 的 影 响 ， 但 是 这 值 得 吗 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 100)
			{
				text2 = " 政 府 危 机";
				text = " 在 没 完 没 了 的 政 变 后 ， 孟 加 拉 国 的 军 权 暂 时 稳 定 了 ， “ 元 老 ” 侯 赛 因 · 穆 罕 默 德 · 艾 尔 沙 德 成 功 拿 下 总 统 宝 座 。 在 两 年 的 右 翼 独 裁 政 权 下 ， 针 对 自 由 派 和 社 会 主 义 者 的 大 规 模 压 迫 开 始 了 ， 他 们 大 部 分 都 是 左 翼 党 派 人 民 联 盟 的 成 员 。 同 时 ， 国 内 耕 者 无 其 田 与 高 层 权 力 腐 败 始 终 没 解 决 。 由 此 ， 难 对 付 的 反 政 府 示 威 在 全 国 开 始 了 ， 诉 求 之 一 就 是 启 动 大 选 程 序 。 依 我 之 见 如 果 我 们 支 持 努 力 改 善 对 华 关 系 的 政 府 ， 我 们 就 能 稳 定 东 南 亚 的 政 变 温 床 ， 但 是 如 果 我 们 能 更 激 烈 地 催 化 示 威 并 组 织 反 对 派 对 抗 艾 尔 沙 德 ， 忠 诚 于 我 们 的 人 就 能 掌 权 ， 但 是 全 世 界 会 怎 么 看? 还 是 我 们 干 脆 不 要 介 入?";
			}
			else if (GlobalScript.inst.gameState.number_event == 102)
			{
				text2 = " 变 革 之 风 ？";
				text = " 来 自 苏 联 的 紧 急 消 息 ！1985 年3 月10 日19 时20 分 ， 苏 共 中 央 总 书 记 康 斯 坦 丁 · 乌 斯 季 诺 维 奇 · 契 尔 年 科 死 于 心 脏 骤 停 。 在 人 民 哀 悼 时 ， 环 绕 新 任 总 书 记 的 竞 争 在 克 里 姆 林 宫 的 长 廊 里 展 开 了 。 候 选 者 有: 米 哈 伊 尔 · 戈 尔 巴 乔 夫 ， 一 位 年 轻 而 可 靠 的 党 员 ， 曾 是 安 德 罗 波 夫 的 人 马 ， 以 改 革 思 维 著 称 。 格 里 戈 里 · 罗 曼 诺 夫 ， 有 活 力 而 适 于 探 索 ， 一 位 年 轻 但 经 验 丰 富 的 管 理 者 ， 曾 是 列 宁 格 勒 州 委 书 记 ， 以 铁 腕 保 证 了 列 宁 格 勒 的 繁 荣 与 经 济 发 展 。 以 及 维 克 托 · 格 里 申 ， 上 个 时 代 政 治 局 的 代 表 ， 保 守 派 的 最 爱 ， 莫 斯 科 市 委 书 记 ， 勃 列 日 涅 夫 对 内 对 外 政 策 的 支 持 者 ， 在 这 些 年 里 在 苏 联 上 下 发 展 了 巨 大 的 关 系 网 （ 以 及 腐 败 网 ） 。| 我 们 要 支 持 谁? 如 果 我 们 能 支 持 的 话 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 104)
			{
				text2 = " 第 十 二 届 世 界 青 年 学 生 节";
				text = " 第 十 二 届 世 界 青 年 学 生 节 即 将 在 莫 斯 科 举 行 。 这 些 节 日 是 由 世 界 民 主 青 年 联 合 会( 一 个 国 际 左 翼 青 年 组 织) 自1947 年 以 来 组 织 的 ， 一 直 是 世 界 各 地 进 步 青 年 充 满 活 力 的 聚 会 ， 其 目 的 是 促 进 社 会 主 义 和 反 帝 国 主 义 的 发 展 。 我 们 面 临 着 一 个 永 恒 的 问 题 — — 去 还 是 不 去? 毕 竟 ， 苏 联 作 为 主 办 国 ， 对 节 日 有 着 巨 大 的 影 响 力 ， 如 果 我 们 之 间 有 强 烈 的 分 歧 ， 他 们 可 能 不 会 让 我 们 加 入 。 在 这 方 面 ， 一 些 党 员 建 议 举 行 我 们 自 己 的 类 似 的 节 日 ， 并 邀 请 友 好 国 家 的 代 表 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 105)
			{
				text2 = " 阿 尔 巴 尼 亚 的 斯 大 林 的 终 结";
				text = " 来 自 阿 尔 巴 尼 亚 的 有 趣 消 息 ：4 月11 日 ， 阿 尔 巴 尼 亚 的 终 身 领 导 人 恩 维 尔 · 霍 查 逝 世 ， 享 年76 岁 。 在 这 个 国 家 为 自 己 的 损 失 感 到 悲 痛 的 同 时 ， 拉 米 兹 · 阿 利 雅 接 任 了 阿 尔 巴 尼 亚 劳 动 党 中 央 委 员 会 第 一 书 记 的 职 位 ， 长 期 以 来 ， 他 被 认 为 是 霍 查 的 继 任 者 ， 在 击 败 穆 罕 默 德 · 谢 胡 的 集 团 中 发 挥 了 重 要 作 用 。 阿 利 雅 欣 赏 霍 查 并 无 条 件 支 持 其 政 策 的 所 有 转 变 ， 但 是 ， 据 一 些 报 道 ， 他 并 不 反 对 与 西 方 和 南 斯 拉 夫 建 立 关 系 ， 也 不 反 对 在 国 内 政 治 上 做 出 一 些 让 步 。 一 方 面 ， 这 会 影 响 到 我 们 ， 另 一 方 面 ， 也 不 知 道 它 会 如 何 结 束 。 因 此 ， 我 们 可 以 组 织 对 新 统 治 者 的 恐 怖 袭 击 ， 当 然 ， 如 果 我 们 在 附 近 有 特 工 的 话 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 106)
			{
				text2 = " 民 主 国 际";
				text = " 在 安 盟 反 共 反 叛 运 动 的 主 要 基 地 安 哥 拉 城 市 贾 姆 巴 ， 正 在 筹 备 一 次 会 议 ， 与 会 者 希 望 在 会 议 结 果 之 后 建 立 所 谓 的 会 议 。 “ 民 主 国 际 ”- 来 自 不 同 国 家 的 反 共 叛 军 联 盟 。 除 安 盟 外 ， 阿 富 汗 圣 战 者 、 尼 加 拉 瓜 反 对 派 和 老 挝 苗 族 的 代 表 也 出 席 了 会 议 ， 银 行 家 刘 易 斯 · 勒 曼 （ 活 动 金 融 家 ） 、 著 名 说 客 和 电 影 制 片 人 杰 克 · 阿 布 拉 莫 夫 （ 活 动 发 起 人 ） 和 奥 利 弗 · 诺 斯 中 校 等 美 国 保 守 派 人 士 也 积 极 参 加 了 会 议 。 尽 管 即 将 成 立 的 同 盟 会 具 有 鲜 明 的 反 苏 倾 向 ， 但 它 也 与 我 们 的 利 益 区 相 交 叉 ， 并 可 能 在 未 来 造 成 问 题 。 另 一 方 面 ， 我 们 也 可 以 在 与 苏 联 的 地 缘 政 治 斗 争 中 对 其 加 以 利 用 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 109)
			{
				text2 = " 索 马 里 的 黄 金 时 代";
				text = " 欧 加 登 战 争 失 败 后 ， 索 马 里 局 势 开 始 迅 速 恶 化 。 西 索 马 里 解 放 阵 线 惨 败 ， 被 埃 塞 俄 比 亚 军 队 打 败 ， 苏 联 军 民 援 助 的 崩 溃 严 重 打 击 了 索 马 里 经 济 。 索 马 里 革 命 社 会 党 正 逐 渐 开 始 失 去 声 望 ， 贾 勒 · 穆 罕 默 德 · 西 亚 德 · 巴 雷 政 权 正 变 得 越 来 越 专 制 。 在 这 种 令 人 沮 丧 的 气 氛 中 ， 索 马 里 政 府 正 试 图 通 过 与 美 国 和 西 方 国 家 的 合 作 来 与 苏 联 保 持 距 离 。 也 许 我 们 可 以 向 索 马 里 政 府 提 供 一 切 可 能 的 援 助 ， 以 解 决 该 国 的 局 势 ， 我 们 可 以 争 取 巴 雷 的 支 持 ， 并 在 东 非 获 得 一 个 有 利 可 图 和 忠 诚 的 盟 友 。 然 而 ， 这 是 否 会 拯 救 反 对 武 装 团 体 已 在 全 国 各 地 积 极 组 建 的 索 马 里 革 命 社 会 党 政 权 ？ 将 军 们 对 巴 雷 总 统 的 优 柔 寡 断 极 为 不 满 ， 也 许 ， 在 获 得 了 他 们 的 支 持 之 后 ， 我 们 能 设 法 密 谋 反 对 他 ， 让 更 务 实 的 领 导 人 上 台 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 110)
			{
				text2 = " 自 动 化 的 缓 慢 进 展";
				text = " 主 席 同 志! 在 过 去 的 五 年 里 ， 我 们 在 国 民 经 济 和 科 学 研 究 方 面 取 得 了 很 大 的 进 步 ， 我 们 不 应 该 止 步 于 此 。 现 在 应 该 巩 固 我 们 的 成 就 ， 重 新 建 立 几 代 人 关 于 一 个 完 美 的 世 界 秩 序 的 梦 想 ， 迈 出 从 社 会 主 义 到 共 产 主 义 社 会 的 第 一 步 。 我 国 最 优 秀 的 头 脑 — — 数 学 家 和 控 制 论 者 — — 提 出 要 建 立 一 个 全 面 的 、 统 一 的 、 自 动 化 的 生 产 计 划 系 统 。OGAS 的 概 念 由 苏 联 数 学 家 维 克 多 · 格 鲁 什 科 夫 提 出 。 因 此 ， 我 们 将 能 够 通 过 把 最 复 杂 和 最 昂 贵 的 计 算 转 移 到 计 算 机 上 来 摆 脱 计 划 经 济 的 所 有 问 题 和 缺 陷 。 但 要 实 施 如 此 庞 大 的 项 目 ， 需 要 大 量 的 资 金 和 时 间 ， 同 时 国 家 机 器 像 害 怕 火 灾 一 样 害 怕 激 进 的 变 化 ， 特 别 是 那 些 可 能 会 侵 蚀 他 们 的 领 地 和 繁 荣 的 变 化 。 选 择 权 在 你 … …";
			}
			else if (GlobalScript.inst.gameState.number_event == 111)
			{
				text2 = " 在 幽 灵 般 的 灯 光 下";
				text = " 主 席 同 志 ！IECS 系 统 部 分 实 施 后 ， 政 府 开 始 逐 步 、 系 统 地 削 减 基 层 国 家 机 构 ， 解 放 不 必 要 的 技 术 工 人 ， 优 化 预 算 。 这 些 措 施 遭 到 了 地 方 官 僚 机 构 的 强 烈 抵 制 ， 他 们 已 经 宣 布 你 们 是 “ 资 产 阶 级 反 革 命 ” 了 。 现 在 连 党 的 最 高 领 导 层 都 反 对 你 ， 而 且 已 经 在 准 备 罢 免 你 。 我 们 需 要 立 即 采 取 行 动 ！ 我 们 需 要 争 取 广 大 民 众 的 支 持 ， 胜 利 将 属 于 我 们 ！ 但 问 题 是 ， 他 们 会 支 持 我 们 吗 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 112)
			{
				text2 = " 来 自0 和1 的 冲 击";
				text = " 主 席 同 志 ， 怪 事 发 生 了! 全 国 各 地 的 部 门 间 组 织 都 失 败 了 。 基 层 企 业 之 间 的 信 息 被 破 坏 ， 食 品 被 运 送 到 有 中 断 的 地 区 ， 商 店 里 的 队 伍 越 来 越 长 。 根 据 管 理 者 们 的 保 证 ， 我 们 的 设 备 遭 到 了 来 自 外 部 的 计 算 机 攻 击 。 情 报 机 构 认 为 ， 这 些 人 是 我 们 的 外 部 对 手 ， 担 心 我 们 在 世 界 舞 台 上 的 影 响 力 不 可 避 免 地 增 长 ， 所 以 他 们 与 自 动 化 的 敌 人 合 谋 ， 他 试 图 通 过 破 坏IECS 来 打 击 我 们 的 经 济 。 如 果 我 们 仍 然 无 所 作 为 ， 这 将 导 致 我 们 国 家 的 崩 溃 。 专 家 建 议 为 我 们 的 规 划 系 统 开 发 特 殊 保 护 ， 但 这 需 要 一 些 时 间 。 但 是 ， 我 们 可 以 请 求 苏 联 专 家 的 支 持 ， 这 将 使 我 们 能 够 迅 速 地 使 设 备 恢 复 运 作 。 还 是 … … 自 动 化 真 的 只 是 乌 托 邦 吗?";
			}
			else if (GlobalScript.inst.gameState.number_event == 113)
			{
				text2 = " 南 斯 拉 夫 社 会 主 义 自 治 的 痛 苦";
				text = " 主 席 同 志 ， 南 斯 拉 夫 传 来 了 糟 糕 的 新 闻 。 由 南 斯 拉 夫 主 席 团 前 主 席 谢 尔 盖 · 克 拉 伊 盖 尔 （ 其 本 人 为 斯 洛 文 尼 亚 族 ， 与 “ 社 会 主 义 自 治 政 府 ” 理 论 家 爱 德 华 · 卡 德 尔 关 系 密 切 ） 领 导 的 所 谓 “ 克 拉 伊 盖 尔 委 员 会 ” 向 南 斯 拉 夫 主 席 团 递 交 了 大 规 模 市 场 经 济 改 革 的 建 议 。 南 斯 拉 夫 在 约 瑟 普 · 布 罗 兹 · 铁 托 死 后 陷 入 困 境 ： 科 索 沃 分 离 主 义 者 叛 乱 的 恶 果 仍 未 得 到 处 理 、 以 斯 洛 文 尼 亚 和 克 罗 地 亚 为 中 心 的 不 满 正 在 日 益 增 长 并 且 塞 尔 维 亚 的 民 族 主 义 情 绪 正 在 激 增 。1979 年 的 经 济 危 机 更 是 火 上 浇 油 ， 迫 使 已 经 深 陷 债 务 泥 潭 的 该 国 继 续 贷 款 。 看 起 来 南 斯 拉 夫 正 在 步 入 深 渊 … … 苏 联 和 其 他 社 会 主 义 国 家 准 备 为 南 斯 拉 夫 提 供 大 额 财 政 援 助 以 避 免 其 进 行 市 场 改 革 。 我 们 也 可 以 响 应 苏 联 领 导 人 的 提 议 ， 但 一 些 党 员 建 议 发 动 军 事 政 变 ， 让 希 望 终 结 “ 不 结 盟 运 动 ” 的 将 军 们 上 台 。 另 一 方 面 ， 美 国 也 可 以 为 南 斯 拉 夫 提 供 新 的 贷 款 … … 所 以 我 们 该 作 何 选 择 ？";
			}
			else if (GlobalScript.inst.gameState.number_event == 115)
			{
				text2 = " 金 三 角";
				text = " 主 席 同 志 ， 正 如 我 们 的 情 报 部 门 所 知 ， 在 缅 甸 、 老 挝 和 泰 国 等 最 近 成 为 我 们 势 力 范 围 的 山 区 ， 有 一 个 庞 大 的 网 络 参 与 毒 品 的 生 产 和 销 售 ， 称 为 “ 金 三 角 ” 。 这 个 网 络 非 常 有 利 于 这 些 国 家 和 周 边 国 家 的 腐 败 ， 而 且 它 还 由 一 位 著 名 的 掸 族 成 员 领 导 ， 他 主 张 掸 族 与 缅 甸 分 离 。 考 虑 到 这 一 切 ， 部 分 党 员 和 将 军 提 出 协 助 这 些 国 家 对 毒 品 贩 子 进 行 调 查 和 军 事 行 动 。 然 而, 有 另 一 组 人 声 称 ， 在 多 年 的 内 战 中 掸 族 一 直 未 能 实 现 独 立 于 缅 甸 的 梦 想 ， 也 不 太 可 能 成 功 。 但 是 他 们 与 引 人 注 目 的 一 个 毒 贩 集 团 有 联 系 ， 这 些 毒 品 主 要 销 往 西 方 国 家 。 在 这 方 面 ， 他 们 提 出 帮 助 金 三 角 组 织 保 护 和 销 售 商 品 ， 这 将 帮 助 我 们 得 到 资 金 ， 破 坏 西 方 国 家 的 生 活 。";
			}
			else if (GlobalScript.inst.gameState.number_event == 435)
			{
				text2 = GlobalScript.inst.new_events_text[1647];
				text = GlobalScript.inst.new_events_text[1648];
			}
			else if (GlobalScript.inst.gameState.number_event == 436)
			{
				text2 = GlobalScript.inst.new_events_text[1656];
				text = GlobalScript.inst.new_events_text[1657];
			}
			else if (GlobalScript.inst.gameState.number_event == 116)
			{
				text2 = " 两 个 中 国";
				text = " 如 你 所 知 ， 解 放 战 争 胜 利 后 ， 国 民 党 败 逃 到 台 湾 岛 ， 西 方 社 会 长 期 认 为 他 们 是 中 国 的 合 法 政 府 。 由 于 美 国 在 台 湾 的 基 地 和 舰 队 ， 我 们 无 法 解 放 它 ， 就 像 国 民 党 无 法 反 攻 大 陆 一 样 ， 随 着 时 间 的 推 移 ， 越 来 越 多 的 国 家 承 认 中 华 人 民 共 和 国 为 中 国 唯 一 合 法 政 府 ， 尽 管 中 华 人 民 共 和 国 和 台 湾 政 府 都 没 有 正 式 拒 绝 对 全 中 国 的 主 张 。 当 然 ， 我 们 之 间 的 关 系 一 直 很 糟 糕 ， 但 是 最 近 自 由 化 和 中 国 共 产 党 结 束 了 对 权 力 的 垄 断 之 后 ， 我 们 之 间 的 关 系 明 显 升 温 。 现 在 双 方 高 层 都 在 谈 论 期 待 已 久 的 国 家 统 一 的 可 能 性 。 但 是 ， 在 这 种 情 况 下 ， 台 湾 会 旗 帜 鲜 明 地 要 求 自 治 ， 我 们 需 要 在 他 们 的 根 据 地 地 位 上 与 美 国 达 成 一 致 ， 而 台 湾 人 民 成 功 地 发 展 了 他 们 的 文 化 认 同 ， 这 将 如 何 影 响 这 个 国 家 已 经 不 稳 定 的 局 势 ， 目 前 还 不 知 道 。 因 此 ， 有 人 建 议 我 们 与 台 湾 相 互 承 认 对 方 为 独 立 国 家 ， 建 立 睦 邻 友 好 关 系 。 既 然 在 这 种 情 况 下 ， 美 国 的 基 地 将 继 续 存 在 ， 西 方 公 司 将 免 于 官 僚 主 义 的 大 惊 小 怪 ， 那 就 很 好 地 暗 示 美 国 ， 年 轻 的 民 主 需 要 钱 … …";
			}
			else if (GlobalScript.inst.gameState.number_event == 103)
			{
				if (GlobalScript.inst.gameState.allcountries[0].isEU)
				{
					text2 = " 申 根 协 定";
					text = " 最 近 ，7 月14 日 ，5 个 欧 洲 国 家 （ 卢 森 堡 、 荷 兰 、 比 利 时 、 法 国 和 联 邦 德 国 ） 在 卢 森 堡 签 署 了 《 申 根 协 定 》 ， 这 意 味 着 简 化 它 们 之 间 边 界 的 护 照 和 签 证 管 制 ， 并 概 述 了 几 乎 完 全 拒 绝 护 照 管 制 的 行 动 。 申 根 协 定 是 欧 洲 经 济 共 同 体 长 期 以 来 实 行 的 免 签 证 制 度 的 延 续 ， 它 促 使 你 们 的 党 员 认 为 我 们 也 有 自 己 的 经 济 联 盟 。 建 立 单 一 的 签 证 空 间 、 联 盟 国 家 之 间 的 自 由 流 动 和 简 化 边 境 管 制 ， 应 该 有 利 于 我 们 国 家 之 间 的 文 化 交 流 、 旅 游 业 的 发 展 ， 人 们 会 喜 欢 它 的 。 问 题 是 ， 这 也 会 简 化 持 不 同 政 见 者 和 罪 犯 的 生 活 ， 事 实 上 ， 不 知 道 我 们 的 公 民 会 从 外 国 得 到 什 么 样 的 想 法 … …";
				}
				else
				{
					text2 = " 马 德 里 协 定";
					text = " 最 近 ，7 月14 日 ，数 个 欧 洲 国 家 在 西 班 牙 签 署 了 《 马 德 里 协 定 》 ， 这 意 味 着 简 化 它 们 之 间 边 界 的 护 照 和 签 证 管 制 ， 并 概 述 了 几 乎 完 全 拒 绝 护 照 管 制 的 行 动 。 申 根 协 定 是 社 会 主 义 联 盟 长 期 以 来 实 行 的 免 签 证 制 度 的 延 续 ， 它 促 使 你 们 的 党 员 认 为 我 们 也 有 自 己 的 经 济 联 盟 。 建 立 单 一 的 签 证 空 间 、 联 盟 国 家 之 间 的 自 由 流 动 和 简 化 边 境 管 制 ， 应 该 有 利 于 我 们 国 家 之 间 的 文 化 交 流 、 旅 游 业 的 发 展 ， 人 们 会 喜 欢 它 的 。 问 题 是 ， 这 也 会 简 化 持 不 同 政 见 者 和 罪 犯 的 生 活 ， 事 实 上 ， 不 知 道 我 们 的 公 民 会 从 外 国 得 到 什 么 样 的 想 法 … …";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 107)
			{
				text2 = " 盟 友 危 机";
				text = " 众 所 周 知 ， 我 们 的 集 团 是 最 民 主 、 最 平 等 的 … … 这 就 产 生 了 后 果 。 " + GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].name + " 最 近 一 直 在 奉 行 越 来 越 独 立 于 我 们 政 策 ， 想 进 行 一 些 改 革 的 不 忠 势 力 正 在 其 政 治 体 系 中 获 得 权 力 。";
				if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
				{
					text += " 但 更 糟 糕 的 是 他 们 与 美 国 和 西 方 的 外 交 调 情 ！ 如 果 这 种 情 况 继 续 下 去 ， 那 么 我 们 就 有 失 去 盟 友 的 危 险 ， 所 以 我 们 需 要 做 些 什 么 ， 但 是 怎 么 办 ？ 我 们 不 想 表 现 得 像 苏 联 修 正 主 义 者 在 捷 克 斯 洛 伐 克 做 的 那 样 。 或 者 … … ？";
				}
				else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance)
				{
					text += " 但 更 糟 糕 的 是 他 们 与 苏 联 的 外 交 调 情 ！ 如 果 这 种 情 况 继 续 下 去 ， 那 么 我 们 就 有 失 去 盟 友 的 危 险 ， 所 以 我 们 需 要 做 些 什 么 ， 但 是 怎 么 办 ？ 我 们 不 想 表 现 得 像 苏 联 修 正 主 义 者 在 捷 克 斯 洛 伐 克 做 的 那 样 。 或 者 … … ？";
				}
				else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
				{
					text += "|| 这 一 切 都 是 在 我 们 盟 国 政 府 即 将 宣 布 中 立 政 策 的 背 景 下 发 生 的 ， 这 意 味 着 一 件 事 ： 他 们 想 离 开 我 们 的 军 事 同 盟";
				}
				else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].econ)
				{
					text += "|| 而 这 一 切 发 生 的 背 景 是 ， 我 们 的 盟 友 政 府 正 狂 热 地 切 断 与 我 们 的 所 有 贸 易 关 系 ， 宣 布 调 整 其 经 济 方 向 ， 这 意 味 着 一 件 事 ： 他 们 想 离 开 我 们 的 经 济 联 盟 。";
				}
			}
			else if (GlobalScript.inst.gameState.number_event == 5)
			{
				text2 = "Гудбай, Брежнев";
				text = "";
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 3)
		{
			text2 = "Смерть кормчего";
			text = "Случилось страшное. После 2 перенесённых инфарктов 9 сентября в 0 ч. 10 мин. на 83-м году жизни скончался великий лидер и учитель китайского народа председатель Мао Цзэдун. Пока весь народ и партия скорбят, нам необходимо созвать похоронную комиссию и решить, как же мы проводим председателя в последний путь.";
		}
		else if (GlobalScript.inst.gameState.number_event == 4)
		{
			text2 = "Заговор";
			text = "По недавно поступившей информации несколько высших партийцев, недовольных вашим правлением, за вашей спиной договорились отстранить вас на следующем съезде ЦК. Нужно срочно что-то предпринять, если вы не хотите повторить судьбу ревизиониста Хрущёва в 1964-м.";
		}
		else if (GlobalScript.inst.gameState.number_event == 5)
		{
			text2 = "Народное недовольство";
			text = "Недовольный вашей политикой народ вышел на массовые митинги по всей стране и начал сооружать палаточные городки на площадях, распространять листовки и даже штурмовать местные госучреждения. Разные группы протестующих недовольны разными аспектами вашего правления, но все они требуют демократизации системы, чтобы иметь возможность ограничить ваше влияние на китайскую политику.";
		}
		else if (GlobalScript.inst.gameState.number_event == 6)
		{
			text2 = "Низкий уровень жизни";
			text = "Ваша политика привела к катастрофическому упадку уровня жизни в стране, люди живут в отвратительных условиях и подавляющему большинству не хватает возможностей приобрести даже предметы первой необходимости. Разумеется, это приводит к многочисленным выступлениям и протестам, где люди требуют разобраться с этой ситуацией. С учётом того, что солдаты также недовольны ужасными условиями содержания, рассчитывать на армию мы не можем.";
		}
		else if (GlobalScript.inst.gameState.number_event == 7)
		{
			text2 = "Дипломатический кризис";
			text = "Наши отношения с США достигли критически низкой отметки. Их пропаганда уже обвиняет Китай во всех возможных и невозможных преступлениях, а наша разведка докладывает о суматохе в Пентагоне и активности на американских базах в Юго-Восточной Азии. Нужно срочно как-то исправить ситуацию, если мы не хотим Третьей Мировой.";
		}
		else if (GlobalScript.inst.gameState.number_event == 8)
		{
			text2 = "Дипломатический кризис";
			text = "Наши отношения с СССР достигли критически низкой отметки. Их пропаганда уже обвиняет Китай во всех возможных и невозможных преступлениях, а наша разведка докладывает о суматохе в Генштабе СССР и движении советских войск на границе. Нужно срочно как-то исправить ситуацию, если мы не хотим Третьей Мировой.";
		}
		else if (GlobalScript.inst.gameState.number_event == 9)
		{
			text2 = "Сепаратизм в Тибете";
			text = "Подстрекаемые либералами и националистами, жители Тибетского автономного района вышли на массовые демонстрации за независимость и отделение от КНР, которые постепенно перерастают в беспорядки. Люди требуют \"освобождения\" от \"оккупации 1950-го года\" и большинство этнических тибетцев их поддерживает. Впрочем некоторых пока устраивают и просто требования большей автономии, чем мы можем воспользоваться.";
		}
		else if (GlobalScript.inst.gameState.number_event == 10)
		{
			text2 = "Сепаратизм в Синьцзяне";
			text = "Подстрекаемые либералами и националистами, жители Синьцзян-Уйгурского автономного района вышли на массовые демонстрации за независимость и отделение от КНР, которые постепенно перерастают в беспорядки. Люди требуют \"освобождения\" от \"оккупации 1949-го года\" и большинство этнических уйгуров их поддерживает. Впрочем им существует противовес из ханьцев, да и некоторых уйгуров пока устраивают и просто требования большей автономии, чем мы можем воспользоваться.";
		}
		else if (GlobalScript.inst.gameState.number_event == 11)
		{
			text2 = "Упадок промышленности";
			text = "Наша промышленность находится в невиданном упадке - часть заводов простаивает, часть вот-вот закроется и все работают на устаревшем оборудовании.";
		}
		else if (GlobalScript.inst.gameState.number_event == 12)
		{
			text2 = "Упадок сельского хозяйства";
			text = "Наше сельское хозяйство находится в невиданном упадке - такого беспорядка не было даже во времена большого скачка!";
		}
		else if (GlobalScript.inst.gameState.number_event == 13)
		{
			text2 = "Упадок сферы услуг";
			text = "Наша сфера услуг находится в ужасном упадке - большинство магазинов и заведений не работают, а качество сервиса в работающих просто ужасно.";
		}
		else if (GlobalScript.inst.gameState.number_event == 14)
		{
			text2 = "Денег нет, но вы держитесь!";
			text = "В нашем бюджете и резервном фонде катастрофически мало денег. Если так будет продолжаться дальше, то мы совсем скоро не сможем поддерживать нормальную работу нашего государства.";
		}
		else if (GlobalScript.inst.gameState.number_event == 15)
		{
			text2 = "Кампучийско-вьетнамская война";
			text = "Правящие в Демократической Кампучии Красные кхмеры Пол Пота в течении нескольких лет проводили открыто агрессивную политику в отношении соседнего Вьетнама, часто нападая на приграничные селения и массово убивая мирных жителей. И похоже терпение Вьетнама подошло к концу - совсем недавно вьетнамская армия начала полномасштабное вторжение в Камбоджу для свержения режима Пол Пота, используя Единый фронт национального спасения Кампучии, состоящий из левых кхмерских диссидентов как прикрытие. С учётом того, что Пол Пот всё это время был нашим верным союзником, стоило бы помочь ему. Хотя с другой стороны, возможно стоит заменить обнаглевшего диктатора в пользу более разумных офицеров из армии Кампучии. Войну это, конечно, не остановит, но Вьетнам, поставивший себе целью свержение Пол Пота, окажется в затруднительном положении.";
		}
		else if (GlobalScript.inst.gameState.number_event == 16)
		{
			text2 = "Выборы в Таиланде";
			text = "После падения в 1973 году военной хунты и передачи власти гражданскому правительству Таиланд вступил в период \"хаотичной демократии\". Победы коммунистических сил по всему Индокитаю способствуют росту левых настроений, ведомых маоистской Коммунистической Партией Таиланда, которая занимается как партизанской, так и легальной деятельностью. Им противостоят правые военные, землевладельцы и прочие роялисты, что нередко приводит к столкновениям. В этих условиях на фоне вспыхнувшего кризиса тайской экономики демократический премьер-министр Кыкрит Прамот вынужден провести досрочные выборы. Может это наш шанс если не переманить, то хотя бы дестабилизировать оплот империализма в Индокитае?";
		}
		else if (GlobalScript.inst.gameState.number_event == 17)
		{
			text2 = "Нестабильность в Таиланде";
			text = "На фоне нестабильности в обществе и постоянной конфронтации между левыми и правыми силами королевская семья Таиланда решила в сентябре организовать возвращение в страну радикально-правого генерала Танома Киттикачона, бывшего премьер-министра страны, ответственного за кровавые репрессии и свергнутого общественными выступлениями в 1973. Сам Киттикачон не хочет возвращаться в политику и пожелал принять монашество, однако официальное объявление о его возвращении и его встречи с королём вызвали недовольство части общества правым поворотом. Премьер Прамот подал в отставку, которая, впрочем была отклонена, прокатилась волна студенческих и профсоюзных демонстраций, одна из которых проходит в Таммасатском университете, на который уже совершают налёты праворадикальные боевики. По нашим данным, военные готовят жестокое подавление демонстрации.";
		}
		else if (GlobalScript.inst.gameState.number_event == 18)
		{
			if (GlobalScript.inst.gameState.data[82] > 7)
			{
				text2 = "Война закончилась";
				text = "После долгих и кровопролитных боёв конфликт \"" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + "\" наконец закончился. Министерство иностранных дел обо всём позаботилось и готово представить вам краткий экскурс об итогах войны.";
			}
			else
			{
				text2 = "Война закончилась";
				text = "После долгих и кровопролитных боёв конфликт \"" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + "\" наконец закончился.";
				text = ((GlobalScript.inst.gameState.data[82] == 6) ? ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 400) ? (text + " Победителем в итоге вышла сторона " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + ", добившись своих целей в войне.") : (text + " Победителем в итоге вышла сторона " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 + ", добившись своих целей в войне.")) : ((GlobalScript.inst.gameState.data[82] == 2) ? ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 750) ? (text + " Победителем в итоге вышла сторона " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + ", добившись своих целей в войне.") : (text + " Победителем в итоге вышла сторона " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 + ", добившись своих целей в войне.")) : ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 900 && GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 < 900) ? ((GlobalScript.inst.gameState.data[82] != 2 && GlobalScript.inst.gameState.data[82] != 4) ? (text + " Ни одна сторона не добилась решающей победы, так что был подписан белый мир, вернувший границы в довоенное состояние.") : (text + " Победителем в итоге вышла сторона " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + ", добившись своих целей в войне.")) : (text + " Победителем в итоге вышла сторона " + ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 > GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2) ? GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 : GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2) + ", добившись своих целей в войне."))));
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 19)
		{
			text2 = "Пять \"нет\"";
			text = "Поздравляем с назначением на пост Премьера Госсовета КНР, товарищ Хуа Гофэн. Как вам известно, вашим предшественником был Чжоу Эньлай, заслуживший популярность и уважение в народе и за рубежом за свою честность и административные таланты. Однако он также был активным проводником экономических реформ и способствовал продвижению в партии реформаторов, таких как его протеже Дэн Сяопин. По этим причинам смерть Чжоу 8 января 1976 года вызвала большую скорбь у народа, которой остались недовольны Мао и верхушка КПК, очень сдержанно отреагировавшие на его смерть. По указу Мао была начата кампания Пяти \"нет\" - не носить траурные повязки, не ставить венки, не делать мемориалы, не устраивать поминальные церемонии и не вешать фотографии Чжоу Эньлая, - которая пока в народе, кроме недовольства, ничего не вызывает. И вы, как новый премьер, можете повлиять на её исполнение.";
		}
		else if (GlobalScript.inst.gameState.number_event == 20)
		{
			text2 = "Критикуй Дэна и борись с правыми!";
			text = "Смерть Чжоу Эньлая серьёзно повлияла на положение его протеже Дэн Сяопина, который оставшись без протекции бывшего премьера теперь подвергается постоянным нападкам радикалов, возглавляемых женой Мао Цзэдуна Цзян Цин, а 2 февраля Сяопин был переведён на работу в сфере внешних связей. С разрешения Мао Цзян и её сторонникам удалось развернуть кампанию \"Критикуй Дэна и борись с правыми\" и начать активную травлю Дэна в СМИ. Примечательно, что Мао хоть и относится к Сяопину с недоверием, однако участия в его травле пока не принимает. А что же нам делать, с учётом того, что Хуа Гофэн никогда не был в хороших отношениях ни с Цзян Цин ни с Сяопином?";
		}
		else if (GlobalScript.inst.gameState.number_event == 21)
		{
			text2 = "И снова Чжоу Эньлай";
			text = "25 марта 1976 года в шанхайской газете «Вэньхуэй бао» была опубликована статья, в которой покойный Чжоу Эньлай был причислен к «каппутистам» (сторонникам капиталистического пути). Материал появился по указанию главы шанхайской парторганизации Чжан Чуньцяо, ближайшего сподвижника Цзян Цин. Статья также резко критикует и Дэн Сяопина и его реформаторские идеи. Эта статья фактически впервые публично обвиняет Чжоу в симпатиях к капитализму, и неизвестно, как на неё отреагирует народ.";
		}
		else if (GlobalScript.inst.gameState.number_event == 22)
		{
			text2 = "Тяньаньмэньский инцидент";
			text = "Многочисленные попытки КПК дискредитировать покойного Чжоу Эньлая вызвали в народе лишь недовольство. 4 апреля в день традиционного праздника поминовения усопших горожане Пекина понесли на площадь Тяньаньмэнь к Памятнику народным героям венки в память о Чжоу Эньлае. До наступления ночи на площади побывало около 2 миллионов человек, а гора из венков достигла 20 метров в высоту. По этому случаю было созвано экстренное заседание Политбюро ЦК КПК под председательством Мао Цзэдуна, где было решено подавить демонстрации. Ответственными за это были назначены вы и мэр Пекина У Дэ. За ночь удалось очистить площадь от венков, однако пришедший утром 5 апреля народ потребовал их вернуть. Вместе с тем раздаются призывы к свержению Мао Цзэдуна и Цзян Цин и требования \"подлинного марксизма-ленинизма\". Цзян Цин призывает к жёсткому подавлению протеста, а У Дэ, кажется хочет избежать насилия, однако окончательное решение за вами.";
		}
		else if (GlobalScript.inst.gameState.number_event == 23)
		{
			text2 = "Таншаньское землетрясение";
			text = "28 июля в городе Таншане провинции Хэбэй в 03:42 по местному времени произошло землетрясение магнитудой 8,2 по шкале Рихтера в результате которого город был почти полностью разрушен. Разрушения имели место также и в Тяньцзине и в Пекине, расположенном всего в 140 км к западу. Несколько афтершоков, сильнейший из которых имел магнитуду 7,1, привели к ещё большим жертвам. По предварительным данным погибло от 200 до 600 тыс. человек. По мнению начальника Шанхайского городского сейсмологического управления Чжан Цзюня, основной причиной колоссальных разрушений стало отсутствие необходимых мер сейсмозащиты при строительстве.";
		}
		else if (GlobalScript.inst.gameState.number_event == 24)
		{
			text2 = "Ветер перемен?";
			text = "После того, как Мао умер, а вы наконец сосредоточили власть в своих руках, настало время определить дальнейший путь Китая, ведь каждая фракция КПК видит его по-своему. Консервативные маоисты выступают за продолжение политики Мао, но без сомнительных экспериментов, что означает прекращение Культурной революции и кампанейщины. Реформаторы, разумеется, выступают за прекращение Культурной революции и масштабные реформы прежде всего в экономике, чтобы оздоровить китайскую экономику после провальных попыток Мао вмешаться в её работу. Все умеренные считают, что Китаю нужны перемены, однако некоторым достаточно прекращения Культурной революции и небольшой экономической реорганизации, другие же присоединяются к реформаторам с требованием глубоких рыночных реформ. Впрочем и радикальные маоисты не спешат расставаться с идеей Культурной революции и хотят продолжать её с учётом ошибок и перегибов.";
		}
		else if (GlobalScript.inst.gameState.number_event == 25)
		{
			text2 = "Банда четырех";
			text = "Теперь, когда наш Председатель Мао Цзэдун скончался, в КПК вновь разгорелась внутрипартийная борьба. С одной стороны, стоят четыре наиболее приближенных к Великому Кормчему сторонника линии на продолжение Культурной революции, но при курсе на нормализацию отношений с СССР: Цзян Цин - супруга Мао и глава Группы по делам Культурной революции при ЦК КПК, Ван Хунвэнь - видный партиец, который на X съезде партии фактически был объявлен преемником Мао, Чжан Чуньцяо и Яо Вэньюань. С другой - набирающие силу реформаторы во главе с опальным идеологом полурыночных реформ начала 70-х Дэн Сяопином, которые выступают за скорейшее сворачивание Культурной революции и начало масштабных рыночных реформ при неизменности антисоветского курса. Причём именно леворадикалы в данный момент представляют для нашей власти наибольшую угрозу, однако для их нейтрализации потребуется вступить в союз с реформаторами, такими как министр обороны Е Цзяньин. Может лучше всё же с ними договориться и использовать для борьбы с реформаторами?";
		}
		else if (GlobalScript.inst.gameState.number_event == 26)
		{
			text2 = "Непрочный альянс";
			text = "Шаткий компромисс между Гофэном и леворадикалами трещит по швам. Откровенное недовольство соглашением многих более умеренных партийцев сильно подорвало позиции нынешнего председателя, а его мягкость в решении этих вопросов грозит привести к непредсказуемым последствиям. Более того, четвёрка требует более решительных мер против оппозиции и ревизионистов в партии, а заодно дальнейшего расширения своих полномочий для следования курсу Мао. Если это продолжится и дальше Гофэну придется всё больше и больше передавать власть в руки левых. Ван Дунсин – лидер Отряда 8341, сохраняющий лояльность председателю, все еще готов помочь в борьбе с ними. Хотя, учитывая возросшую, благодаря компромиссу в октябре, силу левых, возможно лучшим решением будет убрать лишь наиболее амбициозных Цзян Цин и Ван Хунвэня, сохранив соглашение с остальными?";
		}
		else if (GlobalScript.inst.gameState.number_event == 1)
		{
			text2 = "Выборы, выборы, кандидаты...";
			text = "Настал день проведения всенародных выборов в ВСНП. И раз уж мы занимаем господствующее положение в китайской политике, то можем немного вмешаться в их проведение, чтобы после них всё так и оставалось. Или же просто положиться на веру в нас китайского народа.";
		}
		else if (GlobalScript.inst.gameState.number_event == 27)
		{
			text2 = "Судьба Гонконга и Макао";
			text = "С давних времён китайские территории Гонконг (Сянган) и Макао (Аомынь) находились под британским и португальским колониальным управлением. Однако фашистский режим \"Нового государства\" в Португалии был свергнут в 1974, 99-летний срок аренды Британией прилегающих к Гонконгу Новых Территорий подходит к концу, да и обе страны находятся под давлением Декларации ООН о деколонизации 1960 года, поэтому они готовы пойти на компромисс, и это наш шанс вернуть то, что наше по праву. Разумеется, они никогда добровольно не передадут колонии, если не будут убеждены в неприкосновенности собственности своих и иностранных граждан, но также попытаются добиться для этих территорий широкой автономии от КНР.";
		}
		else if (GlobalScript.inst.gameState.number_event == 28)
		{
			text2 = "Конец азиатского Пиночета";
			text = "Захвативший власть в Индонезии в 1965 году генерал-майор Сухарто сразу приступил к уничтожению своих политических противников, в особенности коммунистическую партию. Только за 1965-66 года по обвинениям в симпатии к коммунистам было убито около 3 миллионов человек. Досталось и национальным меньшинствам, в том числе китайцам, которые до сих законодательно подвергаются дискриминации. Свой репрессивный режим Сухарто удавалось поддерживать за счёт поддержки США и выгодных экономических контактов со странами Юго-Восточной Азии. Однако теперь, когда мы отрезали Индонезию от большинства её партнёров, вызвав коллапс её экономики, в стране идёт активное протестное движение. И хотя многие протесты идёт под левыми лозунгами, их явно недостаточно для социалистической революции.";
		}
		else if (GlobalScript.inst.gameState.number_event == 29)
		{
			text2 = "Империализм по-китайски";
			text = "В КНДР уже долгое время идут процессы отхода от марксизма-ленинизма и замены его на самобытную идеологию чучхе с элементами мистицизма и традиционализма и культом личности Ким Ир Сена. Всё это сопровождается периодическими репрессиями против политических противников Ким Ир Сена. Экономика КНДР сильно зависит от контактов с Китаем и нашей помощи, так что наши недавние санкции стали для неё тяжёлым ударом. И поэтому мы можем потребовать от северокорейского правительства определённых уступок. Только не забывайте, что помощь КНДР оказывает также и СССР...";
		}
		else if (GlobalScript.inst.gameState.number_event == 30)
		{
			text2 = "Конец конфликта?";
			text = "С момента созданияв 1948 году Израиля на территории бывшей британской Палестины, проживающее там арабское население, фактически лишенное права на самоопределение и подвергающееся дискриминации со стороны израильских властей, боролось за уничтожение Израиля и создание в Палестине арабского государства, в чём их поддерживали соседние арабские страны. Всё это вылилось в несколько арабо-израильских войн, постоянные обстрелы и теракты против Израиля со стороны Организации Освобождения Палестины и ответные рейды израильской армии. Последний из них, в Ливане, закончился полным провалом, даже не получив поддержки из США, и теперь Израиль готов пойти на переговоры с ООП о статусе палестинцев, в которых мы можем выступить посредниками.";
		}
		else if (GlobalScript.inst.gameState.number_event == 31)
		{
			text2 = "Правильная демократия";
			text = "Восстание в Кванджу, благодаря нашей поддержке, перекинувшееся и на соседние регионы нанесло огромный урон репутации южнокорейского правительства, а наш недавний удар по её экономике привёл к новому всплеску протестов, под нажимом которых Чон Ду Хван согласился провести свободные президентские выборы и даже допустить к ним двух известных лидеров оппозиции - Ким Дэ Чжуна и Ким Ён Сама, первый из которых в частности имеет гораздо более миролюбивые взгляды по отношению к КНДР. Обеспечив ему победу на выборах и надавив на КНДР, мы могли бы привести Корею к долгожданному объединению.";
		}
		else if (GlobalScript.inst.gameState.number_event == 32)
		{
			text2 = "Улан-Баторская весна?";
			text = "С помощью нашего вмешательства в Монголии начались масштабные протесты, призывающие к реформам и отходу от строгой просоветской политики. Не желая повторения событий в Чехословакии и ввода советских войск, МНРП, кажется, готова пойти на некоторые уступки и провести ограниченную демократизацию, подобно Кадару в Венгрии. Мы могли бы это использовать для того, чтобы провести в монгольскую политику и СМИ прокитайски настроенных людей, чтобы обеспечить ей более... независимую внешнюю политику.";
		}
		else if (GlobalScript.inst.gameState.number_event == 33)
		{
			text2 = "Полумесяцем в бровь";
			text = "Зульфикар Али Бхутто был президентом Пакистана с 1971 года и премьер-министром с 1973. Бхутто придерживался курса исламского социализма, что нашло отражение в широких социальных программах и национализации многих отраслей экономики. Во внешней политике он придерживался антиимпериализма и старался строить дружеские отношения с соседними странами, вышел из проамериканской СЕАТО и Британского Содружества, сумел провести разрядку с Индией после Третьей индо-пакистанской войны. Однако, после того, как в марте 1977 победу на выборах одержала партия Бхутто - Пакистанская народная партия - оппозиция обвинила его в фальсификациях и начала протесты, которые Бхутто жёстко подавляет. Всё это не нравится армии, которая во главе с генералом Мухаммедом Зия-уль-Хаком и при поддержке США готовит военный переворот. Предотвратив его и выделив Бхутто материальную помощь на строительство социализма, мы могли бы прочно закрепить свои позиции в Пакистане.";
		}
		else if (GlobalScript.inst.gameState.number_event == 34)
		{
			text2 = "Враги моих врагов";
			text = "После разгрома Банды четырёх власть номинально перешла к вам, однако фактически вы вынуждены делить её с теми, кто помог вам её заполучить - с министром обороны Е Цзяньином, убеждённым реформатором, защищавшим Сяопина во время Культурной революции, и Ли Сяньнянем, более умеренным, но также поддерживающим реформаторов. С другой стороны есть три ваших самых верных сторонника из числа консерваторов - Цзи Дэнкуй, Ван Дунсин и Чэнь Силянь. Если вы хотите, чтобы вам не ставили палки в колёса, следует нанести удар по реформаторам и продвинуть своих сторонников, однако, не вызовет ли такое самоуправство недовольства в партии и не лучше ли ограничиться одним из двух? С другой стороны, если вы нацелены на реформы, то, наверно, полезнее будет договориться с реформаторами. Хотя, кто знает, захотят ли они...";
		}
		else if (GlobalScript.inst.gameState.number_event == 35)
		{
			text2 = "Конец революции";
			text = "После смерти Мао вы взяли курс на сворачивание Культурной революции, и добились в этом определённых результатов - массовых кампаний больше не наблюдается. Однако репрессивная хватка государства времён Культурной революции ещё не ослабла, и реформаторы вместе с народом теперь требуют \"открутить гайки\". Помимо гражданской либерализации, многие считают необходимым также ослабить давление на традиции и религию, многократно возросшие во время Культурной революции. Одни выступают лишь за прекращение антитрадиционалистской риторики с сохранением государственного атеизма, другие предлагают по советскому образцу объявить номинальную свободу совести, держа при этом религиозные учреждения и деятелей под чутким государственным контролем. Вам решать.";
		}
		else if (GlobalScript.inst.gameState.number_event == 36)
		{
			text2 = "Крах коалиции?";
			text = "С 1968 года в Ираке между правящей Баас и Иракской коммунистической партией установилось шаткое сотрудничество в рамках Прогрессивного национально-патриотического фронта Ирака. В мае 1972 2 представителя ИКП официально введены в состав правительства, хотя компартия по-прежнему находилась на неофициальном положении. Однако сотрудничество оказалось недолговременным. С недавнего времени руководство Баас в Ираке вновь начало разворачивать репрессии против коммунистов, однако возможности для сохранения непрочной коалиции ещё есть. Возможно нам стоит как-то вмешаться в ситуацию?";
		}
		else if (GlobalScript.inst.gameState.number_event == 37)
		{
			text2 = "Конец египетского паши";
			text = "С 1970 года Египет возглавляет Анвар Садат. Сразу же после своего прихода к власти, он начал отход от политики Гамаля Абдель Насера и идей панарабизма и арабского социализма - в ходе т.н. \"Майской исправительной революции\" были арестованы почти все соратники Насера, включая вице-президента Али Сабри (сторонника дружбы с СССР и коммунистами), в 1971 году Объединенная Арабская республика была переименована в Арабскую республику Египет, что означало разрыв с курсом на панарабскую интеграцию. А с 1973 года началось сближение Египта с США, что сопровождалось ростом антисоветских настроений и разрывом с Ливией и Сирией. В 1975 году Садат предпринял попытки по дестабилизации правящего Арабского социалистического союза (АСС), а в этом году - невиданное дело - начал переговоры об восстановлении отношений с Израилем! Либерализация экономики и проникновение на египетский рынок иностранного капитала привели к массовому недовольству среди широких слоев населения, а война с некогда братской Ливией окончательно подорвала авторитет Садата. Всю страну захлестнули массовые митинги с требованиями отставки президента. Мы можем воспользоваться этим и добиться возвращения к власти сторонников социалистического курса. СССР и братские арабские страны явно не будут возражать, но вот реакция США будет не столь теплой...";
		}
		else if (GlobalScript.inst.gameState.number_event == 38)
		{
			text2 = "Возвращение к истокам";
			text = "В начале 60-х в КНР для того, чтобы справиться с разрушительными последствиями Большого скачка, под началом Дэн Сяопина и Чжоу Эньлая были запущены масштабные экономические реформы на основе самоуправления и возможности частного землевладения, которые в итоге привели к демонтажу централизованного планирования. Мао не мешал их проведению, так как опасался недовольства со стороны большинства в КПК, которое ещё помнило провал Большого скачка, и понимая их необходимость в то время. Однако теперь Большой скачок далеко позади и, может быть, в этот момент возрождение плана позволит нашей экономике выйти на новый уровень? С другой стороны реформаторское крыло по-прежнему считает, что необходимы дальнейшие реформы в экономике и хочет заняться их разработкой.";
		}
		else if (GlobalScript.inst.gameState.number_event == 39)
		{
			text2 = "Комиссия по \"Решению...\"";
			text = "Смерть товарища Мао Цзэдуна, начало внутрипартийной борьбы в КПК и наш отказ от продолжения курса на т.н. \"Великую пролетарскую Культурную революцию\" вызвали сильное брожение внутри партии. По данным Министерства общественной безопасности, в ряде парторганизаций начинают распространятся идеи о \"неправильности маоцзэдунидей\", \"ошибочности курса КПК\", \"искажении Мао Цзэдуном и его окружением истории страны и партии\" и так далее. Это рискует вызвать раскол в Компартии и полностью перечеркнуть все успехи социалистического развития Китая. Политбюро ЦК КПК приняло решение - начать работу над документом, в котором будет дана официальная оценка всему пути, который прошли КНР и КПК под руководством Мао Цзэдуна с 1949 года, для чего сформировать комиссию из 50 человек. Однако надо решить, кто её возглавит, и определить примерный состав. Помните, что ваше решение будет иметь далеко идущие последствия и может привести к пересмотру всей идеологической линии КПК.";
		}
		else if (GlobalScript.inst.gameState.number_event == 40)
		{
			text2 = "Судьба Панчен-Ламы";
			text = "Товарищ Председатель, в ЦК пришло письмо от большой группы тибетского духовенства, в котором они настоятельно просят Вас рассмотреть вопрос об освобождении из тюрьмы Панчен-Ламы X (Панчен-Лама - второй по рангу лама после Далай-ламы в школе Гелуг тибетского буддизма - примечание МГБ). Лобсанг Тринле Лхундруп Чокьи Гьялцен, он же Панчен-Лама X, в сентябре 1949 года отказался бежать с гоминьдановцами на Тайвань и поддержал образование КНР, в дальнейшем сыграв важную роль в воссоединении Тибета с нашей Родиной. Однако затем он резко осудил китаезацию Тибетского автономного района, за что в 1964 году был объявлен \"врагом тибетского народа\", арестован и заключен в пекинскую тюрьму Циньчэн, где и пребывает в настоящий момент. Мы можем освободить его, тем самым существенно улучшив отношения с тибетскими монахами и населением автономии. Но есть ли смысл в этом? Может, лучше ликвидировать ненадежного ламу и добиться избрания Панчен-Ламой нашего ставленника Гьялцэна Норбу?";
		}
		else if (GlobalScript.inst.gameState.number_event == 41)
		{
			text2 = "Индийские выборы";
			text = "Бывшая премьер-министром Индии с 1966 года Индира Ганди, глава ИНК, за время своего правления проводила активные левые реформы в социально-экономической сфере, чем даже спровоцировала раскол в ИНК и выход из него правого крыла. За время её правления были достигнуты значительные успехи в экономике и борьбе с бедностью, однако длящееся в стране с 1971 года чрезвычайное положение играет на руку оппозиции из Джаната парти, которая обвиняет Ганди в коррупции, непотизме и авторитаризме. В этих условиях Ганди решила организовать досрочные парламентские выборы. С учётом того, что Ганди всегда проводила просоветскую и недружественную к КНР политику, а также вступала в конфликты с дружественным нам Пакистаном, лишь недавно пойдя на разрядку в этих вопросах, победа оппозиции могла бы усилить наше влияние. Джаната парти объединяет людей разных взглядов от социалистов до консерваторов и внятной программы не имеет, однако тем проще будет нам ей управлять. Хотя может быть, если мы поможем Индире, то она запомнит это и продолжит движение к восстановлению наших отношений?..";
		}
		else if (GlobalScript.inst.gameState.number_event == 42)
		{
			text2 = "Иранская революция";
			text = "В шахском Иране уже какое-то время идут протесты, направленные против трудного социально-экономического положения народа, проамериканской политики шаха, повальной коррупции правящих элит и притеснений шиитского духовенства со стороны государства. Однако сегодня протесты перешли в горячую фазу, после того как в Куме полицией была расстреляна антиправительственная демонстрация, поводом для которой стала клеветническая статья об аятолле (высший духовный титул шиитского ислама) Хомейни, являющимся духовным лидером протестов и высланном из страны в 1964-м. После этого протесты, забастовки и стачки охватили многие города Ирана. Движущими силами начинающейся революции являются исламистские движения, такие как Движение за свободный Иран и Общество борющегося духовенства, однако на свержение шаха также работают и другие организации, наиболее крупными из которых являются демократический Национальный фронт Ирана и марксистко-ленинская Народная партия Ирана. Революция в Иране способна кардинально изменить расклад сил на Ближнем Востоке, так может нам стоит вмешаться?";
		}
		else if (GlobalScript.inst.gameState.number_event == 43)
		{
			text2 = "Расширение СЭВ";
			text = "Вьетнам долгое время старался балансировать между нами и СССР, ведь несмотря на наши с советами разногласия, наши добровольцы вместе воевали в Индокитайских войнах на стороне социалистического Вьетнама. Впрочем уже с окончанием войны и объединением, Вьетнам постепенно становился всё более просоветским, всё больше отдаляясь от нас.|";
			text = ((GlobalScript.inst.gameState.allcountries[23].Gosstroy != 1) ? (text + "После поездки Ле Зуана в Москву в 1977 наметилось дальнейшее сближение Вьетнама и СССР с перспективой вступления с СЭВ, куда он и собирается вступить со дня на день. Помешать этому мы, видимо, не сможем, не в последнюю очередь из-за того, что Вьетнам хочет заручиться советской поддержкой против Пол Пота в прокитайской Камбодже.") : (text + "После поездки Ле Зуана в Москву в 1977 наметилось дальнейшее сближение Вьетнама и СССР с перспективой вступления с СЭВ, куда он и собирается вступить в ближайшее время. Однако, часть руководства страны выступает против столь ярого сближения с СССР, ведь особых угроз для Вьетнама, особенно после свержения Пол Пота в Камбодже, в Азии сейчас нет. И это наш шанс вмешаться и остановить распространение советской гегемонии."));
		}
		else if (GlobalScript.inst.gameState.number_event == 44)
		{
			text2 = "Неважно, какого цвета кошка...";
			text = "Ваше желание продолжать консервативную политику, совершенно не соответствующее уменьшающейся силе ваших сторонников, привело в итоге к масштабному недовольству реформаторского крыла КПК, поддерживаемого умеренными. Они хотят вашего отстранения от власти и требуют начала обширных рыночных реформ с привлечением иностранных инвестиций и выходом Китая на мировой рынок, аргументируя это тем, что \"экономика должна превалировать над идеологией \". Именно это вам на нынешнем пленуме ЦК КПК говорит их лидер - " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + ", с которым соглашается большинство присутствующих. Нужно, что-то делать, если не хотите лишиться власти!";
		}
		else if (GlobalScript.inst.gameState.number_event == 45)
		{
			text2 = "Реформы и открытость: начало";
			text = "После объявления курса на рыночные реформы наши экономисты разрабатывали план первых реформ и наконец представили его, чтобы руководство КПК смогло его утвердить. Он включает в себя расширение прав отдельных госпредприятий, внедрение рыночных методов их работы и поощрение мелкого частного и кооперативного предпринимательства.";
		}
		else if (GlobalScript.inst.gameState.number_event == 46)
		{
			text2 = "Новый 1956-й?";
			text = "Интересные известия пришли из Венгрии. Бела Биску - консервативный коммунист, активно участвовавший в подавлении венгерского восстания в 1956-м и бывший министром внутренних дел с 1957 по 1961, а ныне являющийся секретарём ЦК ВСРП, всегда выступал против экономических и политических либеральных реформ Кадара. Поняв, что словами его не остановить, он сколотил вокруг себя группу таких же консерваторов и решил организовать внутрипартийный переворот, попросив при этом поддержки у главы КГБ Юрия Андропова. Однако, по нашим данным, Андропов попросту \"сдал\" планы Биску Кадару, о чём сам Биску ещё не знает. Сейчас у нас есть шанс помочь Биску своими агентами и вернуть Венгрию на путь построения настоящего социализма. Или же всегда можно с помощью небольших поставок оружия и координации разведки попробовать поднять новое восстание в Венгрии - на сей раз истинно коммунистическое и прокитайское - ведь тогда Венгрия гарантированно будет нашей! Но действовать надо быстро.";
		}
		else if (GlobalScript.inst.gameState.number_event == 47)
		{
			text2 = "Пекинская весна";
			text = "С середины этого года по всей стране и особенно в Пекине началась бурная активность студентов и интеллигенции, которая развешивает дацзыбао (настенные газеты с большими иероглифами, используемые для пропаганды и выражения протеста) по улицам и издаёт самодельные журналы. Дацзыбао и журналы содержат критику против консерватизма КПК, критику Культурной революции, призывают к экономической и политической либерализации и выражают поддержку реформаторам в КПК, чем активно пользуется либеральная фракция. Это притом, что сами реформаторы уже в 1977-м активно выпускали в подконтрольных им журналах и газетах статьи с критикой нашей политики заявляя, что она \"не сходится с марксизмом\", что \"экономика должна превалировать над идеологией \" и что \"прагматизм - единственный критерий для выявления истины\", описывая практические преимущества рыночных реформ в своём видении.";
		}
		else if (GlobalScript.inst.gameState.number_event == 63)
		{
			text2 = "Апрельская революция";
			text = "Срочные новости! 27 апреля в Афганистане в результате нестабильности власти, обнищания и недовольства народа арестом лидеров левой оппозиционной партии НДПА произошёл военный переворот заранее спланированный НДПА. Население в целом приветствовало революцию. Придя к власти, НДПА во главе с Н. М. Тараки начала построение социализма и ориентацию на СССР. Однако, будущее Афганистана ещё туманно, так как в самой НДПА остаётся непреодолённый раскол между фракциями Хальк и Парчам, которые с 1966 по 1977 существовали фактически как 2 независимые партии. Хальк, состоящая преимущественно из малообеспеченных и полупролетарских слоёв, в ходе оппозиционной деятельности фокусировалась на нелегальной работе и выступала за революционную борьбу, а ныне стремится организовать быстрый переход страны к социализму и диктатуре пролетариата. Парчам же, в годы оппозиции отдававшая приоритет легальной и парламентской борьбе, сейчас выступает за постепенные, общедемократические преобразования и в целом склонна к реформизму, считая, что Афганистан не готов к построению социализма. У нас же тем временем КПК серьёзно обеспокоена таким расширением советского влияния в регионе.";
		}
		else if (GlobalScript.inst.gameState.number_event == 48)
		{
			text2 = "Перевороты продолжаются";
			text = "После апрельской революции НДПА столкнулась со многими трудностями, а в стремительно набирающей силу фракции Хальк уже началась борьба между одним из основателей НДПА Тараки и его учеником Амином. Амин является сторонником радикальной политики, бескомпромиссной борьбы с феодальными пережитками и жесткого подавления политических оппонентов. При этом он же, будучи ярым пуштунским (доминирующий народ Афганистана - прим.) националистом, во многом отвественнен за саботаж национальной политики НДПА и он же, стараясь сконцентрировать в своих руках власть, поддерживал раскол между Хальк и Парчам. Несмотря на то, что советское руководство многократно предупреждало Тараки о заговорщицких планах Амина, он так и не прислушался до самого последнего момента. 14 сентября в ходе визита Амина к Тараки на первого было совершено нападение (точно неизвестно, реальное или инсценированное самим Амином), а 16 сентября Амин на пленуме ЦК НДПА отстранил Тараки от его обязанностей, предварительно изолировав его лояльными частями армии в резиденции. Примечательно, что, хоть Амин и старался поддерживать хорошие отношения с СССР, по нашим данным, он совсем не против наладить близкие отношения с КНР и это может быть наш шанс.";
		}
		else if (GlobalScript.inst.gameState.number_event == 49)
		{
			text2 = "Против всех тиранов";
			text = "После недавнего переворота Амина СССР всячески искал способы устранить нерадивого узурпатора. По нашим данным, советское руководство установило контакт с бежавшими из Афганистана из-за чисток Амина членами НДПА из разных фракций, такими как Кармаль, Сарвари и Ватанджар, и готово использовать их для замены Амина. Ключевым пунктом плана является нейтрализация Амина и лояльного ему окружения советским спецназом, прикрытие действий которого должны обеспечить советские войска, которые с начала года настойчиво просила ввести НДПА и лично Амин, несмотря на постоянные отказы СССР. Однако, похоже, что под нажимом обстоятельств советские лидеры решили изменить решение, и первые советские подразделения пересекли границу ещё 25 декабря с задачей взять под охрану важные военные объекты и объекты советско-афганского сотрудничества. Сейчас наш шанс перехватить инициативу в Афганистане, если удастся предотвратить смещение Амина. Однако сделать это можно только при наличии хороших отношений с СССР, иначе он расшибётся, но не отдаст нам Афганистан.";
		}
		else if (GlobalScript.inst.gameState.number_event == 50)
		{
			text2 = "Проклятый горный дикий край...";
			text = "После недавних событий, способствовавших ухудшению обстановки в Афганистане, давно начавшееся восстание исламистов и прочих реакционеров, поддерживаемых США перешло в горячую фазу. СССР же в соответствии с принятым недавно планом вводит в Афганистан войска по просьбе правительства ДРА, что уже вызвало волну негодования на западе. Несмотря на то, что население первоначально встретило советские войска довольно дружелюбно, участились случаи нападения на них боевиков. Вместе с тем задачи ограниченного контингента, изначально включавшие лишь охрану важных объектов, постепенно расширяются и, кажется, в итоге дойдут до полноценного его участия в боевых действиях. Битва за Афганистан началась и надо бы решить, кого мы в ней поддержим.";
		}
		else if (GlobalScript.inst.gameState.number_event == 51)
		{
			text2 = "Постоят и уйдут...";
			text = "После апрельской революции НДПА столкнулась со многими трудностями, связанными с недостатком опыта у её членов и обилием феодально-религиозных пережитков в Афганистане, однако, благодаря относительному равенству сил двух фракций НДПА, удавалось избегать крупных политических конфликтов. В частности членам как Парчам так и Хальк при поддержке СССР удалось удалить Х. Амина из правительства и ЦК с обвинениями в нарушении принципов коллективного руководства и пуштунском национализме. Однако восстания реакционных слоёв, особенно исламистов, начавшиеся ещё в начале года, набирают силу. К ним присоединяются некоторые граждане Пакистана и Ирана, незаконно пересекая границу, и даже США умудряются как-то протащить в Афганистан своё оружие и советников в помощь моджахедам. В этих условиях СССР по многочисленным просьбам афганского руководства решил ввести небольшой контингент своих войск, который должен будет охранять важные военные объекты и города, высвобождая силы армии ДРА для борьбы с повстанцами. Похоже, что масштабного их участия в боевых действиях не предвидится, однако Запад уже осудил это, назвав вторжением.";
		}
		else if (GlobalScript.inst.gameState.number_event == 52)
		{
			text2 = "Непростое соседство";
			text = "С самого начала антиправительственных выступлений в Афганистане и ответных мер правительства ДРА многие исламские радикалы, террористы и священники бежали в Пакистан, где объединились со своими местными \"коллегами\". Впоследствии после начала вооружённых бунтов в Афганистане во всё тот же Пакистан потекли беженцы, которых с распростёртыми объятиями в своих рядах ждали сформировавшиеся там исламские террористические организации. Сам Пакистан не принимает по отношению к ним особых мер сверх обычного, похоже у Бхутто там своих проблем хватает, но может стоит выделить ему агентурную помощь, дабы прекратить подобные безобразия? С другой стороны в возможности помогать афганским повстанцам через Пакистан очень заинтересованы США, и если с США Бхутто ни в каком варианте не будет договариваться, то с нами - вполне. Перевозя американское вооружение и советников через Пакистан мы могли бы \"состричь\" с американцев денег и ударить по советскому социал-империализму.";
		}
		else if (GlobalScript.inst.gameState.number_event == 53)
		{
			text2 = "Реформа сельского хозяйства";
			text = "Во время Большого скачка почти всё сельское хозяйство Китая было организовано в сельскохозяйственные коммуны, прославившиеся тотальным обобществлением инвентаря и личных вещей, провальными экспериментами с кустарной выплавкой стали и отвратительной производительностью. После реформ Чжоу Эньлая коммуны были частью преобразованы, частью распущены, однако в изменённом варианте по прежнему продолжают работу. Многие в КПК считают, что пора уже реформировать сельское хозяйство, однако единого мнения нет. Умеренные и реформаторы предлагают введение системы семейного подряда, подразумевающего создание на селе семейного предпринимательства с обязательными госзакупками. Другая часть реформаторов предлагает ввести систему полноценного частного фермерства. Придётся выделить начинающим предпринимателям кредиты на необходимые закупки, однако реформаторы обещают, что эти затраты уже в краткосрочной перспективе окупятся с лихвой. А часть партии предлагает вернуться к истокам организовать систему коллективных хозяйств по советскому образцу, что позволит преодолеть технологическую отсталость, ведь у Сталина же получилось? Правда на необходимую механизацию нужны деньги...";
		}
		else if (GlobalScript.inst.gameState.number_event == 54)
		{
			text2 = "Реформы и открытость: инвестиции";
			text = "В рамках политики реформ и открытости в соответствии с заявленным курсом нам необходимо заняться привлечением иностранных инвестиций. Реформаторы предлагают создать на побережье несколько специальных экономических зон с налоговыми льготами, минимумом государственного контроля и прочими послаблениями для иностранных инвесторов, где они могли бы строить свои предприятия и вкладываться в совместные проекты. Впрочем, более радикальные деятели предлагают помимо создания СЭЗ полностью открыть экономику для иностранных инвестиций путём создания системы совместных предприятий, при которой иностраны смогу вкладываться в наши государственные предприятия в обмен на часть прибыли. Большая прибыльность второго варианта очевидна, однако умеренные и даже некоторые реформаторы критикуют его за поспешность.";
		}
		else if (GlobalScript.inst.gameState.number_event == 55)
		{
			text2 = "Бирманский путь к социализму";
			text = "После военного переворота в 1962-м власть в Бирме перешла к У Не Вину и возглавляемой им Партии бирманской социалистической программы, провозгласивших построение \"бирманского социализма\". Впрочем этот \"социализм\" характеризовался сохранением частного сектора, взращиванием шовинистских религиозных и национальных предрассудков, фактически уходом в изоляцию а также массовыми репрессиями всех противников Не Вина. Поэтому различные левые силы, попавшие в партию после начала открытого массового набора в 1971, начали всё больше противостоять У Не Вину и его политике. По нашим данным в Партии бирманской социалистической программы готовятся массовые чистки против коммунистов и других левых и, если мы до этого уже шли на контакт с Бирмой, то могли бы с помощью наших спецслужб изменить расклад сил в их пользу. Однако мы также можем оказать руководству Бирмы дополнительную помощь и укрепить наши отношения.";
		}
		else if (GlobalScript.inst.gameState.number_event == 56)
		{
			text2 = "Преподать Вьетнаму урок?";
			text = "В последнее время соседний Вьетнам всё больше сближается с СССР, и это несмотря на нашу помощь ему в гражданской войне! В связи с этим всё больше партийцев считают, что нужно \"преподать Вьетнаму урок\". План, который уже некоторое время разрабатывали в НОАК прост - под предлогом периодически случающихся стычек на границе объявляем ему войну, захватываем приграничные области, уничтожаем прибывающие части вьетнамской армии и по мере возможности продвигаемся вглубь страны. Такой удар вынудит их руководство серьёзно пересмотреть свою политику в отношении КНР и СССР. Впрочем, часть партийцев считает, что если наши отношения с Вьетнамом ещё не настолько испорчены, то имеет смысл договориться с ним, урегулировав наши территориальные претензии и уговорив прекратить притеснения этнических китайцев во Вьетнаме. Однако можно и ничего не делать, ведь худой мир лучше доброй войны, ведь так?";
		}
		else if (GlobalScript.inst.gameState.number_event == 57)
		{
			text2 = "Красное восходящее солнце";
			text = "Вскоре в Японии должны пройти выборы в Палату представителей японского парламента. На фоне нестабильности правительства и коррупционных скандалов Коммунистическая Партия Японии уверенно набирала популярность в последнее время, как и различная левоцентристская оппозиция. Если мы имеем влияние на КПЯ, то могли бы оказать ей помощь в предвыборной агитации. В случае победы, мы смогли бы наладить отношения с нашим историческим противником и наконец выдворить американские базы из Японии.";
		}
		else if (GlobalScript.inst.gameState.number_event == 58)
		{
			text2 = "Иранская революция: финал";
			text = "Весь прошлый год протесты сотрясали Иран - левые, светские демократы и мусульманские организации различной степени радикализма словом и делом выступали против власти шаха, организуя множественные стачки и забастовки.|";
		}
		else if (GlobalScript.inst.gameState.number_event == 59)
		{
			text2 = "Экономический союз";
			text = "Товарищ председатель! В связи со сложившейся ситуацией на международной арене, ряд партийцев предлагает организовать свою альтернативу советскому экономическому альянсу – СЭВ и европейскому - ЕЭС, чтобы продолжить политику расширения нашего влияния и углубить торгово-экономические связи между лояльными Пекину странами. Однако некоторые члены Политбюро считают этот шаг слишком поспешным, радикальным и необдуманным и предлагают отложить это дело до лучших времён. Хотя, возможно, лучшим вариантом будет забыть все распри с Советским Союзом и вступить в Совет экономической взаимопомощи?";
		}
		else if (GlobalScript.inst.gameState.number_event == 60)
		{
			text2 = "Военный альянс";
			text = "После более чем благополучного создания нашего экономического союза, некоторые партийцы предлагают закрепить успех, объединив все дружественные нам страны в единый военный альянс, тем самым заняв свою нишу в окружении военных баз европейского НАТО и советской ОВД. Однако наиболее прагматичные сопартийцы предлагают отказаться от этой инициативы, аргументируя это тем, что наши необдуманные и радикальные действия могут развязать новый виток холодной войны, но уже с третьей влиятельной силой. Впрочем, Китай сейчас силён как никогда, и лишние союзники ему не помешают, не так ли? ";
		}
		else if (GlobalScript.inst.gameState.number_event == 61)
		{
			text2 = "Проблема гимна";
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "! Как Вам известно, гимном нашей страны с 1949 года являлся \"Марш добровольцев\" Не Эра-Тянь Ханя. Однако во время т.н. \"Культурной революции\" Тянь Хань был арестован по ложному обвинению и скончался в тюрьме, а гимном де-факто стала популярная в народе песня \"Алеет Восток\", прославляющая покойного Председателя Мао Цзэдуна. Теперь, когда мы прекратили \"Культурную революцию\" и посмертно реабилитировали Тянь Ханя, а также нормализовали ситуацию в стране, встал вопрос о госсимволике. Большая группа партийцев предлагает восстановить \"Марш добровольцев\" в качестве гимна уже официально, однако Ваши соратники, в принципе соглашаясь с этим, считают, что надо изменить текст гимна, добавив туда упоминания Председателя Мао и КПК. Правда для обоих этих вариантов нужны будут деньги на преобразования. В то же время, оставшиеся в партии радикальные маоисты обратились к Вам с письмом, в котором предложили придать статус гимна \"Алеет Восток\"...";
		}
		else if (GlobalScript.inst.gameState.number_event == 62)
		{
			text2 = "Проблемы наследников Чингисхана";
			text = "После победы над Гоминьданом в 1949 году районы Китая, населенные некитайским населением, получили автономный статус, по образцу СССР. Одним из них является Внутренняя Монголия, где проживают этнические монголы. В ходе т.н. \"Культурной революции\" центральные власти начали силовую ассимиляцию монгольского населения, что вылилось в массовые столкновения с хунвэйбинами и беспорядки 1967-1969 годов. В 1969 году большая часть территории Внутренней Монголии была прирезана к соседним китайским провинциям таким образом, что численность монголов в ней упала до 600 тыс. чел., общая численность населения автономного района упала с 13 до 9 млн человек. Теперь, когда КПК признала ошибочность этой политики, представители Совета народных представителей АР Внутренняя Монголия и монголы-коммунисты предлагают исправить ошибку Мао и восстановить справедливость, вернув в состав АР отобранные у него земли и прекратив политику ассимиляции. Это явно не понравится левому крылу КПК, но может помочь заручиться поддержкой национальных элит. Кроме того, МНР и СССР явно понравится такой шаг.";
		}
		else if (GlobalScript.inst.gameState.number_event == 64)
		{
			text2 = "Панарабизм";
			text = "Идеи создания объединённого государства всех арабов на Ближнем Востоке витала в умах арабских правителей и интеллигенции ещё со времён колониального владычества иностранцев в этих землях. Она нашла своё отражение в Объединённой Арабской Республике, состоявшей из Сирии и Египта и существовавшей с 1958 по 1971, однако из-за стремления президента Египта Насера - известного панарабиста - централизовать власть в Египте, Сирия в 1961 году вышла из неё. Впоследствии в 1971 году была создана конфедеративная Федерация Арабских Республик из Египта, Сирии и Ливии. Однако существовали противоречия между её участниками, заключавшиеся прежде всего в либеральной прозападной политике пришедшего к власти в Египте после Насера Садата. Но теперь Садат устранён, а в Египте к власти пришли сторонники старого президента Насера, благодаря чему ФАР формально существует до сих пор, а идеи слияния арабских государств вновь заняли умы правящих кругов. Тем более, 30 июля Израиль провозгласил Иерусалим \"вечной и неделимой столицей Израиля\", чем вызвал волну недовольства в арабском мире, дав ещё один повод к объединению против общего врага. Выделив некоторую материальную помощь и поспособствовав устранению недовольных таким развитием событий, мы могли бы возродить ОАР, чем серьёзно бы изменили баланс сил на Ближнем Востоке и заполучили бы ценного союзника. Если, конечно, они нас послушаются...";
		}
		else if (GlobalScript.inst.gameState.number_event == 65)
		{
			text2 = "До свидания, наш ласковый Мишка...";
			text = "Товарищ Председатель! 19 июля 1980 года в Москве состоится открытие XXII летних Олимпийских игр. Советский Союз с трудом добился права на проведение Олимпиады у себя и потратил на её подготовку громаднейшие средства, которые пришлось изымать из других расходных статей (для возмещения затрат была организована масштабная кампания по продаже олимпийской символики). Однако руководство США уже открыто заявило о бойкоте этих Игр и призвало к этому всех своих союзников, организовав так называемые «Олимпийские игры бойкота» (более известные под названием \"Колокола свободы\") в Филадельфии. Ряд партийцев призывают нас последовать американскому примеру и бойкотировать советские игры, отправив команду на американские - однако это вызовет гнев СССР и непонимание в народе. Может быть, не стоит усугублять раскол и отправить наших спортсменов в Москву, несмотря на существующие между нашими странами политические противоречия? Спорт же вне политики...";
			if (GlobalScript.inst.gameState.is_party_enabled[0])
			{
				text += "|Однако группа партийцев, вспоминая опыт GANEFO 1963 года (проведенных президентом Индонезии доктором Сукарно при нашей фин. помощи альтернативных Игр стран \"третьего мира\"), предлагает нам возродить эти Игры и показать СССР и США, что мы независимы от них и в сфере спорта.";
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 66)
		{
			text2 = "И после Тита - Тито!";
			text = "3 января 1980 года основатель и многолетний руководитель Социалистической Федеративной Республики Югославия, Председатель ЦК Союза коммунистов Югославии, маршал Иосип Броз Тито был госпитализирован в клинический центр Любляны для проверки кровеносных сосудов в ногах. В результате двух операций и ампутации левой ноги, его состояние несколько улучшилось, но в феврале Тито перенёс пневмонию: высокая температура и кровотечение в желудке, кишечнике и лёгких ещё и привели к сепсису, который усиливался в течение марта. И вот сегодня наступила развязка - в 15:05 по белградскому времени в клинике сердечно-сосудистых заболеваний клинического центра в Любляне, за три дня до своего 88-летия, Иосип Броз Тито скончался. Похороны состоятся 8 мая и нам надо решить - имеет ли смысл отправить в Белград делегацию или стоит ограничиться соболезнованиями? Несмотря на наши идеологические разногласия и разрыв дип. отношений, Тито был одним из героев Антифашистской войны и имеет смысл отдать ему долг памяти. СССР и США уже заявили, что отправят на церемонию похорон официальные правительственные делегации, однако президент США Картер в Белград не поедет... Может, и товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " не должен ехать, отправив во главе делегации Цзи Пэнфэя с ограниченными полномочиями? ";
			if (GlobalScript.inst.gameState.allcountries[20].proprc)
			{
				text += "Однако наши союзники-албанцы уже заявили, что, хотя и будут рады восстановить с Югославией торговые и культурные связи, но критику \"ревизиониста Тито и титоизма\" ни за что не прекратят. Если мы отправим делегацию - то вполне можем оттолкнуть их от нас.";
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 67)
		{
			text2 = "Ещё Польша не погибла?";
			text = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + ", из Варшавы приходят тревожные новости - 6 сентября, состоялся VI Пленум ЦК Польской объединенной рабочей партии, принявший решение об отставке возглавлявшего партию и страну 10 лет Эдварда Герека и замены его на компромиссного Станислава Каня. Страна сейчас находится в тяжелейшем политическом и экономическом кризисе, объединенная при помощи ЦРУ антисоциалистическая оппозиция, возглавляемая т.н. \"независимым самоуправляемым профсоюзом\" \"Солидарность\", вот уже почти год как устраивает массовые забастовки, митинги, шествия. Громадный госдолг (почти 40 млрд. долларов), накопленный при прошлых руководствах страны, ПНР не в состоянии выплатить. Ситуация явно вышла из-под контроля ПОРП, СССР уже всерьез начинает рассматривать вариант вооруженного вмешательства в дела Польши по примеру Чехословакии-1968. Сейчас, пока обстановка в стране чрезвычайно нестабильна, у нас есть прекрасная возможность вмешаться и, воспользовавшись нерешительностью Кани, добиться прихода к власти в Польше национально ориентированных сил во главе с Альбином Сиваком и Казимежем Миялем. Однако это вызовет огромное недовольство СССР и большие затраты, так что - быть может, нам и не нужна эта Польша?..";
		}
		else if (GlobalScript.inst.gameState.number_event == 68)
		{
			text2 = "Восстание в Кванджу";
			text = "После путча в декабре 1979 года захвативший власть в Южной Корее Чон Ду Хван начал беспощадное подавление протестующих против военного режима. 17 мая было введено военное положение, а 18 мая студенческую демонстрацию в городе Кванджу против закрытия Национального Университета Чхоннам расстреляли военные. Это вызвало бурю недовольства в городе и повлекло ещё большие беспорядки, в ходе которых восставшим удалось захватить полицейские и военные склады и вытеснить армейские части из города. По нашим данным правительство Чон Ду Хвана готовит захват Кванджу силами регулярной армии. Оказав поддержку восставшим, чтобы они смогли продержаться подольше, и направив силы наших спецслужб на разжигание недовольства в смежных регионах, мы могли бы серьёзно дестабилизировать южнокорейский режим.";
		}
		else if (GlobalScript.inst.gameState.number_event == 69)
		{
			text2 = "Ещё одна банда?";
			text = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + ", благодаря вашим усилиям, мы смогли покончить с пережитками Культурной революции, а страна вовсю идёт к светлому рыночному будущему! Однако всё ещё остаются те, кто не согласен с таким развитием событий и всеми силами протестуют против проведения подобной политики, срывая благие реформаторские начинания. Это преимущественно консервативные маоисты, возглавялемые четырьмя высшими партийцами, сопротивляющиеся дальнейшим реформам. Ударив по ним и их сторонникам, мы смогли бы сильнее консолидировать власть в руках реформаторов. Более того - на освободившиеся от консерваторов места можно будет продвинуть активных сторонников реформ, снискавших себе популярность в народе, и их подопечных.";
		}
		else if (GlobalScript.inst.gameState.number_event == 70)
		{
			text2 = "Проблемы наследников Чжоу Эньлая";
			text = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + ", благодаря вашим усилиям мы смогли продолжить движение в светлое коммунистическое будущее, как завещал председатель Мао! Все попытки реформаторов пошатнуть нашу систему и уничтожить социалистические завоевания, повернув Китай на путь капитализма, провалились. Однако многие из них ещё обладают достаточным влиянием и продолжают продвигать свои ревизионистские идеи, и с этим надо что-то делать. Наиболее радикальные ваши сторонники предлагают не церемониться с ревизионистами и просто арестовать их лидеров и начать кампанию против реформаторов, однако едва ли партия и народ одобрят такое самоуправство, так что можно попробовать решить всё в залах заседаний КПК. И надо решить, как поступить с умеренными - после смерти Мао большинство из них поддержали реформаторов, однако теперь некоторые начинают колебаться...";
		}
		else if (GlobalScript.inst.gameState.number_event == 71)
		{
			text2 = "Алеет восток...";
			text = "Благодаря нашей поддержке маоисты-повстанцы на востоке Индии, известные как наксалиты, обрели значительное влияние и некоторую общественную поддержку в восточных штатах. Они контролируют значительные территории, а их постоянные теракты стали головной болью, как для восточных штатов, так и для центрального правительства Индии. Некоторые индийские политики уже задумываются о переговорах с ними и мы могли бы использовать это для проведения наксалитов в местные органы власти восточных штатов, выступив посредниками на переговорах, что значительно повысило бы наше влияние на Индию и обеспечило бы относительно лояльное левую политику восточной части Индии. Это при условии, что наксалиты и индийские власти вообще станут с нами разговаривать. Да и сохранение нестабильности в восточных регионах может дать нам возможность для манёвра, не сейчас так в будущем... Впрочем у части генералитета и партии уже созрел план этого манёвра - они предлагают воспользоваться ситуацией и ввести войска на территории в штате Аруначал-Прадеш, на которые мы претендуем, для \"защиты мирного населения и восстановления порядка\", после чего можно будет без особых проблем присоединить их к КНР. Впрочем это будет значить новую пограничную войну с Индией...";
		}
		else if (GlobalScript.inst.gameState.number_event == 72)
		{
			text2 = "Спасение утопающих";
			text = "После победы на индийских выборах 1977-го партия Джаната, представляющая из себя фактически конфедерацию различных партий от социалистов до национал-либералов, столкнулась с кучей трудностей. Первоначально объединённая стремлением отстранить от власти Индиру Ганди и ИНК, теперь после прихода к власти Джаната страдает от внутренних интриг, фактически парализовавших её работу. Такими темпами на грядущих выборах в январе 1980-го неизбежно вновь победит Ганди, что поставит крест на достигнутых Джаната успехах в улучшении наших отношений с Индией. И если мы в своё время помогли оппозиции и имеем влияние на неё, то могли бы помочь ей консолидироваться и удержать власть.";
		}
		else if (GlobalScript.inst.gameState.number_event == 73)
		{
			text2 = "Ирано-иракская война";
			text = "Отношения Ирана и Ирака уже долгое время были натянутыми, главным образом из-за территориальных споров - в 1969 году Иран захватил контроль над рекой Шатт-эль-Араб отданной Ираку по соглашению 1937 года, а в 1971 Иран оккупировал три острова в Ормузском проливе, на которые также претендовал Ирак. Однако после победы исламской революции в Иране ситуация обострилась ещё больше - желая распространить революцию на весь мусульманский мир, Хомейни стал активно засылать агитаторов и агентов в Ирак, а также поддерживать борьбу иракских курдов за независимость. В ответ на это, а также видя, что иранская армия ослаблена революцией и чистками исламистов, Саддам Хусейн принял решение о вторжении в Иран с целью захватить богатую нефтью провинцию Хузестан. 22 сентября около полудня иракские войска вторглись в Иран, встречая ожесточённое сопротивление и на данный момент медленно продвигаются по иранской территории.";
		}
		else if (GlobalScript.inst.gameState.number_event == 74)
		{
			text2 = "Решение по некоторым вопросам истории КПК со времени образования КНР";
			text = "Итак, товарищ Председатель, работа над этим важным документом, начатая нами в 1976 году, завершена. Окончательный вариант «Решения по некоторым вопросам истории КПК» насчитывает 28 тыс. знаков, 84 страницы, напечатанные на китайском, английском, русском, арабском и испанском языках. Далеко не просто было дать анализ деятельности человека, идей, истории, общества, раскрыть сложнейший комплекс причин. Но это, наконец, сделано и VI Пленум ЦК КПК 11 созыва готов рассмотреть документ.";
			if (GlobalScript.inst.gameState.data[90] == 0)
			{
				text += "|В \"Решении\" полностью одобряется тот путь, который мы прошли с 1949 года, а личность Мао Цзэдуна ставиться во главу угла. Это, безусловно, должно понравится народу - но вот партия, одобряя Председателя Мао, вряд ли одобрит оправдание его перегибов...";
			}
			else if (GlobalScript.inst.gameState.data[90] == 1)
			{
				text += "|В \"Решении\" одобряется тот путь, который мы прошли с 1949 года, однако \"выправляется все неправильное и закрепляется все правильное\", а Мао Цзэдуну дана оценка \"70% положительного на 30% отрицательного\". Это, безусловно, понравится и партии, и народу...";
			}
			else if (GlobalScript.inst.gameState.data[90] == 2)
			{
				text += "|В \"Решении\" критикуется тот путь, что мы прошли с 1949 года, а личность Мао Цзэдуна заклеймена. Это понравится отдельным членам партии, однако - я не ручаюсь за последствия, если Пленум одобрит это...";
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 75)
		{
			text2 = "Проблемы иракского атома";
			text = "Только что пришли сведения из Ирака - израильская авиация в ходе т.н. операции \"Опера\" нанесла удар по реактору \"Таммуз\", выведя его из строя. В результате этого удара иракская атомная программа завершилась, не успев толком начаться. Саддам сейчас ведет очень агрессивную внешнюю политику, что дестабилизирует и без того напряженную обстановку на Ближнем Востоке. Однако, возможно, мы могли бы помочь Ираку продолжить атомную программу, получив тем самым полезного союзника в этом стратегическом регионе. Хотя я не советовал бы полагаться на надежность Саддама Хусейна - он известный сторонник многовекторной политики, который сотрудничает и с США, и с СССР, и с нами, и с Движением неприсоединения. Возможно, что даже собственная атомная бомба это не изменит...";
		}
		else if (GlobalScript.inst.gameState.number_event == 76)
		{
			text2 = "Падающего - подтолкни!";
			text = "Товарищ Председатель, срочные известия из СФРЮ! В Социалистическом автономном крае Косово начались массовые беспорядки албанского населения, по нашим данным, организованные албанской спецслужбой Сигурими. Протестующие нападают на административные здания, милицейские участки и гарнизоны Югославской Народной армии, начались антисербские погромы. Руководство края и Союза коммунистов Косово не оказывают серьезного сопротивления мятежникам, де-факто поддерживая их. В Белграде состоялось срочное заседание Президиума СФРЮ, которое приняло решение о силовом подавлении \"контрреволюционного сепаратистского мятежа\". После смерти Тито, ситуация в Югославии начала ухудшаться, похоже, монстр Версальского договора начал разваливаться. Так, может, имеет смысл подтолкнуть его ещё сильнее в пропасть?";
		}
		else if (GlobalScript.inst.gameState.number_event == 77)
		{
			text2 = "Плевок в лицо, удар в челюсть и пулю в голову";
			text = "Наши резиденты передают интересные сведения из Албании - похоже там наметился серьёзный раскол между албанским лидером Энвером Ходжей и вторым человеком в партии и государстве - премьер-министром Мехметом Шеху. Долгое время он был ближайшим соратником Ходжи и силами Сигурими обеспечивал стабильность страны, лично курируя подавление нескольких антикоммунистических восстаний в середине 1940-х и известный фразой: \"Кто не согласен с нашей руководящей ролью, тот получит плевок в лицо, удар в челюсть, а если надо — то и пулю в голову\", которую даже (в негативном контексте) цитировали на ХХII съезде КПСС. Однако после произошедшего на фоне хрущёвской десталинизации разрыва Албании с СССР и соцлагерем её экономика начала испытывать трудности от подобной изоляции. В АПТ всё больше людей склоняются к восстановлению отношений с СССР, Югославией и даже с Италией, и к ним, по всей, видимости относится и Шеху, который, будучи премьером, вынужден решать насущные задачи албанского хозяйства. Более практичный и склонный к переговорам, чем Ходжа, он мог бы стать полезным союзником.";
			if (!GlobalScript.inst.gameState.allcountries[20].proprc)
			{
				text += " К тому же он является сторонником союза с КНР и явно будет рад восстановить наши разорванные отношения.";
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 78)
		{
			text2 = "Вечный президент";
			text = "По нашим сведениям на Филиппинах в июне этого года будут проходить первые за 12 лет президентские выборы. С 1972 года страна находилась в режиме военного положения, введенного президентом Фердинандом Маркосом и снятого им же в январе 1981-го. Время его президентства характеризовалось разгулом коррупции, кумовства и нарушением прав человека, что вызвало резкий рост оппозиционного активизма, одними из двигателей которого стали маоистская Коммунистическая партия Филиппин и сформированное ей Национальное Демократическое Движение, которые уже долгое время ведут агитацию и партизанскую войну против режима Маркоса. Однако эффективные экономические реформы, основанные на государственном регулировании экономики, подавление оппозиции с помощью военного положения и поддержка США по всей видимости принесут ему победу на грядущих выборах. Однако у нас есть отличный шанс подпортить ему триумф - используя спецслужбы и поставки оружия КПФ и НДД мы могли бы разжечь массовые протесты против режима Маркоса и этих карикатурных выборов. Однако стоит ли? Ведь после того как в 1975-м Маркос разорвал отношения с Тайванем и установил их с КНР, Чжоу Эньлай обещал, что КНР не будет вмешиваться в политику Филиппин, так что может лучше развивать сотрудничество с Маркосом?";
		}
		else if (GlobalScript.inst.gameState.number_event == 79)
		{
			text2 = "Режим экономии";
			text = "В начале 70-х годов Румыния, пользуясь хорошими отношениями Чаушеску с Западом, активно брала кредиты у МВФ, однако после энергетического кризиса, 70-х, ударившего по Румынии, как по большому экспортёру нефти, и обрастания страны долгами, экономическая ситуация в стране стремительно ухудшалась. В этих условиях ещё в конце 70-х в Румынии началось повышение цен на потребительские товары, а теперь Чаушеску принял решение перейти к политике жёсткой экономии, подразумевающей значительное сокращение импорта и расширение экспорта с целью направления прибыли на выплату долгов. Это неизбежно повлекло за собой ограничения на потребление воды и электроэнергии для жителей страны, а на многие товары была введена карточная система, что в совокупности больно ударит по уровню жизни в Румынии. Чаушеску являлся единственным правителем советского соцлагеря, поддерживавшим с КНР неплохие отношения, даже несмотря на наш разрыв с СССР, так может стоит помочь ему пережить этот кризис?";
		}
		else if (GlobalScript.inst.gameState.number_event == 80)
		{
			text2 = "XII съезд КПК";
			text = "Очередной, XII, съезд Коммунистической партии Китая начинает свою работу в Дворце народных собраний в Пекине. На съезде присутствуют 1600 делегатов и 149 кандидатов в делегаты при численности КПК на данный момент в 39,65 млн человек. Повестка дня - обычная... Однако теперь, когда VI Пленум ЦК КПК 11 созыва принял \"Решение по некоторым вопросам истории КПК со времени образования КНР\", в котором мы обозначили возможность курса на демаоизацию - может, стоит в конце работы съезда провести закрытое заседание, на котором зачитать доклад \"О культе личности Мао Цзэдуна и преодолении его последствий\", заранее подготовленный группой советников? Однако это рискует очень сильно подорвать позиции КПК - может, стоит просто в Отчетном докладе упомянуть про \"выправление всего неправильного\" в деятельности Мао и под этим предлогом начать осторожный неформальный отход от маоизма? Или вообще не затрагивать этот вопрос?..";
		}
		else if (GlobalScript.inst.gameState.number_event == 81)
		{
			text2 = "Венгерская рапсодия";
			text = "Из Будапешта пришли любопытные сведения - кажется, распиаренный в свое время Хрущевым кадаровский \"гуляш-социализм\" стоит на пороге дефолта, причем в прямом смысле - Венгрия должна МВФ 7,7 млрд. долларов, которые она не в состоянии выплатить. По рассчетам наших экономистов, у венгров есть два выхода - или взять на Западе и у СССР новые кредиты, или начать полномасштабные рыночные реформы, что больно ударит по уровню жизни подавляющего большинства населения страны. На последнее руководители ВСРП не пойдут, помня о событиях \"пражской весны\", поэтому с высокой вероятностью будут взяты новые кредиты. Но мы можем воспользоваться неурядицами ВНР и предложить им свою экономическую помощь - но при условии реабилитации опального сталиниста Бела Биску и его группы, которые выступают против полурыночных реформ и могут стать нашей надежной опорой в ВСРП. Однако можно и не выдвигать политических условий и просто оказать помощь утопающим...";
		}
		else if (GlobalScript.inst.gameState.number_event == 82)
		{
			text2 = "Фолклендская война";
			text = "В последнее время Великобритания переживает не лучшие времена, всё больше теряя некогда огромное влияние. Этим решила воспользоваться аргентинская военная хунта во главе с Леопольдо Галтьери для проведения \"маленькой победоносной войны\". 2 апреля аргентинские десантники высадились на принадлежащих Британии Фолклендских островах, чью принадлежность давно оспаривает Аргентина, почти сразу сломив сопротивление небольшого британского гарнизона. В ответ на это британцы выслали свой флот к островам с намерением блокировать их. Кажется, в мире начинается новый конфликт.";
		}
		else if (GlobalScript.inst.gameState.number_event == 83)
		{
			text2 = "Проблемы ставропольского агронома";
			text = "Нашим спецслужбам удалось получить доступ к важной информации. Согласно ей, в Советском Союзе наблюдаются достаточно серьезные проблемы в сельском хозяйстве, помноженные на бывшие в этом году сильные осадки. Курирующий сельское хозяйство секретарь ЦК КПСС Фёдор Кулаков - один из наиболее вероятных преемников нынешнего советского руководителя Леонида Брежнева. По добытой нашей агентурой информации, Кулаков выступает за активное изучение и внедрение в советское сельское хозяйство опыта Венгрии и Югославии (т.е., децентрализацию управления колхозами и совхозами, создание с/х кооперативов на основе семейного подряда и единоличных фермерских хозяйств). Мы можем использовать это для его дискредитации на предстоящем Пленуме ЦК КПСС и, таким образом, убрать этого опасного реформиста с дороги...";
		}
		else if (GlobalScript.inst.gameState.number_event == 84)
		{
			text2 = "Наш старый партизан...";
			text = "Итак, теперь, когда Фёдор Кулаков устранен, пришло время обратить внимание на консервативное крыло КПСС. В нем, безусловно, наиболее яркая фигура - Петр Машеров - Первый секретарь ЦК Компартии Белоруссии. Бывший партизанский командир, Машеров возглавил Белоруссию в 1965 году и добился очень существенных успехов в развитии этой республики СССР - в несколько раз вырос национальный доход, происходило активное развитие промышленности и сельского хозяйства, был построен ряд предприятий, в том числе гродненский химический комбинат «Азот», Новополоцкий химический комбинат «Полимир», Гомельский химический завод, Березовская ГРЭС. Благодаря личному вмешательству Машерова, в Минске началось строительство метрополитена. Урожайность зерновых достигла 27 ц/га, а сбор зерна — 7,3 миллиона тонн. Однако своей линией на омоложение кадров, Машеров вызвал недовольство многих партийцев, он находится в довольно конфликтных взаимоотношениях с главным идеологом КПСС Михаилом Сусловым, а также был очень близок к опальному Кулакову. Тем не менее, Леонид Брежнев явно делает на него ставку, как на возможного преемника престарелого главы Совмина Косыгина, благо что сам премьер этот выбор одобряет. МГБ подготовило несколько вариантов устранения Машерова с дороги.";
		}
		else if (GlobalScript.inst.gameState.number_event == 85)
		{
			text2 = "Немецкая автономия в Казахстане";
			text = "Нашим источникам в Москве удалось получить интересную информацию - комиссия в составе Ю. Андропова, И. Капитонова, М. Зимянина, З. Нуриева, Н. Щелокова, Р. Руденко, М. Георгадзе, В. Чебрикова внесла в ЦК КПСС предложение об образовании немецкой автономии в Казахской ССР (где проживает 940 тыс. немцев, высланных сюда в 30-40-е годы). Однако руководство республики во главе с близким соратником Леонида Брежнева - Динмухамедом Кунаевым - выступает резко против этого. Насколько нам стало известно, они даже готовы организовать массовые беспорядки казахского населения в случае, если эта автономия будет создана. Кунаев - один из наиболее вероятных кандидатов на пост Второго секретаря ЦК КПСС в случае изменения состава советского руководства, а его антикитайские настроения секретом не являются. Имеет смысл воспользоваться ситуацией для его низвержения.";
		}
		else if (GlobalScript.inst.gameState.number_event == 86)
		{
			text2 = "Конец \"Железного Юрика\"";
			text = "Как нам стало известно, Леонид Брежнев только что отправился в Вену на переговоры по договору ОСВ-2 с президентом США Картером. Никакого \"ограничения стратегических наступательных вооружений\" империалисты, разумеется, не сделают, но нас интересует не это - Брежнев пробудет за границей достаточно времени, чтобы мы могли нанести удар по всесильному шефу КГБ СССР Юрию Андропову. Он известен, как сторонник постепенного улучшения советско-американских отношений и проведения масштабных реформ по венгерскому образцу. Теперь Андропов начинает рассматриваться, как наиболее вероятный преемник Леонида Брежнева. Итак, есть два способа убрать его с дороги - или физически ликвидировать его под предлогом смерти от отказа почек, или попробовать \"подтолкнуть\" главного идеолога КПСС Михаила Суслова и главу украинской парторганизации КПСС Владимира Щербицкого, которые в крайне плохих отношениях с главой советской охранки, к созыву чрезвычайного Пленума ЦК КПСС и разгроме на нем Андропова. Возглавляемый генерал-полковником Виталием Федорчуком украинский КГБ подчиняется Щербицкому и не в ладах с союзным, поэтому шансы на успех достаточно велики.";
		}
		else if (GlobalScript.inst.gameState.number_event == 87)
		{
			text2 = "Мир Галилее";
			text = "Благодаря слабости ливанского руководства, идущей с 1975 года гражданской войне в Ливане и активной помощи арабских стран, Организация Освобождения Палестины сумела развернуть на неподконтрольном правительству юге Ливана опорный пункт для боевых действий против Израиля. Стороны неоднократно обстреливали друг друга, однако похоже теперь конфликт перешёл в горячую фазу. 3 июня на посла Израиля в Лондоне было совершено покушение (как позже выяснится, ответственным за него была другая палестинская группировка, не имеющая отношения к ООП), что стало предлогом для массированной бомбардировки Ливана Израилем, а уже 6 июня израильская армия перешла границу Ливана и завязала бои с силами ООП.";
		}
		else if (GlobalScript.inst.gameState.number_event == 88)
		{
			text2 = "Конец зимбабвийского апартеида";
			text = "В Родезии (также известной как Зимбабве), где уже много лет идёт вооружённая борьба чернокожего большинства против белых властей, проводящих политику расовой сегрегации, кажется наметился поворот в политике. В декабре 1979-го прошла Ланкастерхаузская конференция, на которой было достигнуто соглашение о проведении всеобщих равных выборов, при условии прекращения огня и формальное провозглашение Зимбабве-Родезии британской колонией до дальнейшего определения её судьбы. В итоге на этих выборах победу одержала возглавляемая ЗАНУ и Робертом Мугабе левонационалистическая коалиция, а 18 апреля была провозглашена независимость страны, переименованной в Зимбабве. В своё время мы, как и СССР, оказывали поддержку более умеренной ЗАПУ - нынешним союзникам ЗАНУ по коалиции - так может стоит продолжить сотрудничество с победившими левыми партиями?";
		}
		else if (GlobalScript.inst.gameState.number_event == 89)
		{
			text2 = "Конец эпохи";
			text = "Срочные известия из СССР! Сегодня советское руководство объявило о смерти Леонида Ильича Брежнева, руководившего Советским Союзом почти 20 лет. Советский руководитель скончался 10 ноября во сне от внезапной остановки сердца. Пока весь советский народ скорбит, в КПСС развернулась активная борьба за власть, где главными претендентами на должность генсека ЦК КПСС являются:";
			if (GlobalScript.inst.gameState.empires[1].leaders[3].support > 0)
			{
				text += "|Юрий Андропов, глава КГБ СССР, прагматичный реформатор, активно продвигающий сподвижников для реформ, таких как Горбачёв, Лигачёв и Долгих.";
			}
			if (GlobalScript.inst.gameState.empires[1].leaders[1].support > 0)
			{
				text += "|Владимир Щербицкий, глава украинской компартии, верный брежневист, достигший больших успехов в развитии экономики и поднятия уровня жизни в УССР.";
			}
			text += "|Константин Черненко, заведующий Общим отделом ЦК КПСС, консервативный партиец и опытный организатор, которого некоторые за его взгляды считают даже сталинистом. |Если у нас не самые плохие отношения с СССР, то мы могли бы оказать поддержку одному из кандидатов. Разумеется, кардинально ситуацию это не изменит, но при патовой ситуации может склонить чашу весов в пользу удобного нам кандидата.";
			if (GlobalScript.inst.gameState.data[89] == 0)
			{
				GlobalScript.inst.gameState.empires[1].leaders[3].support--;
			}
			if (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power)
			{
				GlobalScript.inst.gameState.empires[1].leaders[2].support++;
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 90)
		{
			text2 = "Гонконг гудбай, Макао аста ла виста?";
			text = "Как Вы знаете, нам удалось достичь соглашения о возвращении Китаю суверенитета над Сянганом (Гонконгом) в 1997 году и над Аомынем (Макао) в 1999 году на праве очень широкой автономии, ради чего мы даже создали новую территориальную единицу - \"специальный административный район\". Однако часть местной крупной буржуазии выступила против этого соглашения и, как стало известно нашим спецслужбам, готовит целый ряд провокаций, направленных на его срыв и сохранение колониального господства Великобритании и Португалии (в частности, максимальное затягивание разработки Основных законов САР, проведение антикитайских митингов и публикация подстрекательских материалов в СМИ). В этой ситуации, ряд партийцев выступили с неожиданным предложением - установить связи с так называемыми Триадами - 7-ю влиятельнейшими гонконгскими преступными синдикатами, имеющими мощные связи во всей Юго-Восточной Азии. Мы могли бы предложить им выгодные экономические преференции и гарантии неприкосновенности - но при условии оказания содействия в воссоединении Гонконга и Макао с Родиной. Итак, Ваше решение?";
		}
		else if (GlobalScript.inst.gameState.number_event == 91)
		{
			text2 = "Рангунский теракт";
			text = "По нашим данным сегодня в столице Бирмы произошёл теракт, целью которого было убийство южнокорейского президента Чон Ду Хвана. Сам Чон Ду Хван уцелел благодаря тому, что прибыл на место на две минуты позже взрыва, но 17 человек из состава южнокорейской делегации были убиты. Террористы вскоре были схвачены и после допросов назвались офицерами северокорейской армии. Сама КНДР свою причастность к инциденту отрицает, но сам факт подобного происшествия даёт нам возможность с новой силой разжечь противостояние КНДР и Южной Кореи.";
		}
		else if (GlobalScript.inst.gameState.number_event == 92)
		{
			text2 = "Перевыполнение – честь!";
			text = "Товарищ председатель! В связи с началом выполнения нового пятилетнего плана, некоторые специалисты и экономисты из комитета по планированию предлагают выбрать приоритетную отрасль развития на следующий пятигодичный период. Вам необходимо решить какая из областей народного хозяйства требует особого внимания и инвестирования со стороны государства – промышленность, сельское хозяйство, услуги или развитие науки? Однако мы также можем размеренно распорядиться средствами и направить силы на улучшение сразу трёх отраслей, что приведёт к их более равномерному развитию.";
		}
		else if (GlobalScript.inst.gameState.number_event == 93)
		{
			text2 = "Родина демократии";
			text = "В Греции, всё ещё оправляющейся от влияния свергнутой в 1974 хунты Чёрных полковников, намечаются парламентские выборы. После восстановления демократии в стране были две доминирующие партии - либерально-консервативная \"Новая демократия\" и левые социал-демократы из ПАСОК (\"Всегреческое социалистическое движение\"). Так как сейчас фактически решается направление греческой политики вроде членства в НАТО (откуда страна фактически вышла в 1974 году из-за вторжения Турции на Кипр) и Евросоюзе, исход этих выборов может серьёзно повлиять на обстановку в стране.";
		}
		else if (GlobalScript.inst.gameState.number_event == 5)
		{
			text2 = "Гудбай, Брежнев";
			text = "";
		}
		else if (GlobalScript.inst.gameState.number_event == 94)
		{
			if (GlobalScript.inst.gameState.faction_leader[4] == 200)
			{
				for (int j = 0; j < GlobalScript.inst.gameState.politics.Length; j++)
				{
					if (GlobalScript.inst.gameState.politics[j].traits[0] == 3 && GlobalScript.inst.gameState.politics[j].power > ((GlobalScript.inst.gameState.faction_leader[4] != 200) ? GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].power : 0))
					{
						GlobalScript.inst.gameState.faction_leader[4] = j;
					}
				}
			}
			text2 = "Тяньаньмэньский инцидент. Снова?!";
			text = "Политика широкомасштабных реформ во всех сферах жизни, расцвет коррупции, сращение КПК с бизнесом и установление тайных коррупционных связей между номенклатурой и бизнесменами вызвали значительный рост буржуазной либерализации умов немалой части китайской интеллигенции и молодежи, требующих радикализации реформ и отказа от \"коммунистической заразы\". Они образовали движение \"Туйдан\" (буквально \"Отказ от Партии\") во главе с диссидентом-астрофизиком Фан Личжи, которого на Западе назвают \"китайским Сахаровым\", выступающее за объявление КПК \"преступной организацией\" и её силовое отстранение от власти, либерализацию и вестернизацию страны, борьбу с коррупцией и привелегиями номенклатуры. Пользуясь разрешением на проведение массовых мероприятий, 100 тысяч сторонников \"Туйдана\" собрались на площади Тяньаньмэнь в Пекине. Они требуют \"свободы\", \"демократии\", \"борьбы с продажными чинушами\" и \"ухода в отставку коррумпированного партийного руководства\", при этом к ним с каждым днем присоединяются и другие недовольные нашими реформами, включая рабочих. Либерально настроенное крыло КПК, которое возглавляет " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2] + ", склонно согласиться с требованиями протестующих, надеясь на волне протестов прийти к власти. Ситуация крайне нестабильная, однако ещё есть возможность вмешаться, пока волнения не перекинулись на другие города...";
		}
		else if (GlobalScript.inst.gameState.number_event == 95)
		{
			text2 = "Новое начало для КПК";
			text = "Итак, ситуация в Пекине взята под контроль и власть в стране перешла к либеральному крылу КПК во главе с товарищем " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + ". На повестке дня стоит вопрос широкомасштабного углубления политики \"реформ и открытости\" и перехода к демократии западного образца и свободному рынку. Однако движение \"Туйдан\", с которым мы теперь вынуждены считаться, требует учесть в проекте реформ необходимость декоммунизации китайского общества и, само собой, правящей партии. В принципе, КПК и так тяжело назвать \"коммунистической\" партией, но теперь нам предлагается отказаться от марксизма-ленинизма уже окончательно. Итак?..";
		}
		else if (GlobalScript.inst.gameState.number_event == 96)
		{
			text2 = "Перестройка! Демократия! Гласность!";
			text = "Итак, с организационными вопросами покончено и теперь нам необходимо выполнять данные народу обещания о демократизации Китая по западному образцу. Народ требует прекращения давления на религию и духовенство, расширения гражданских прав и свобод по образцу западных стран и самое главное - роспуска \"Патриотического единого фронта китайского народа\" и свободных выборов в ВСНП и местные органы власти. И если выборов нам уже не избежать, то задобрив граждан выполнением других требований, мы могли бы сделать их настолько свободными, насколько нам это нужно.";
		}
		else if (GlobalScript.inst.gameState.number_event == 97)
		{
			text2 = "Автоматизация?";
			text = "Это наш великий научный прорыв - ещё недавно мы боролись с тотальной отсталостью нашей экономики, а теперь наши учёные добились выдающихся успехов в разработке механизмов автоматизации планирования экономики на основе систем ЭВМ и даже приступили к разработке системы, позволяющей осуществлять автоматизированное планирование и координацию предприятий в масштабах всей страны. До её полного внедрения ещё далеко, но уже сейчас можно и нужно начать внедрение её низовых региональных систем и их координацию, если мы хотим добиться успехов в автоматизации нашей экономики. Впрочем, это явно не понравится многим управленцам и членам партии, считающим такие темпы внедрения незнакомой системы слишком поспешными...";
		}
		else if (GlobalScript.inst.gameState.number_event == 98)
		{
			text2 = "Африканский Че Гевара";
			text = "Товарищ председатель, срочные новости из бывшей французской колонии Верхней Вольты! Невероятно популярный в народе экс-премьер и по совместительству влиятельный военный деятель Тома Санкара, арестованный несколькими месяцами ранее, свергнул профранцзуского президента Жан-Батист Уэдраого, который массово закрывал профсоюзы и убивал оппозиционеров. Сразу же после военного переворота было сменено название страны с колониальной «Верхней Вольты» на «Буркина Фасо»- «родина честных людей», также была полностью изменена вся государственная символика. Теперь, Тома Санкара, придерживающийся революционных антиимпериалистических взглядов, объявляет курс на строительство социализма и «борьбу против контрреволюционных классов общества», что в свою очередь делает его положение шатким. Чтобы осуществить свои революционные преобразования и «поднять страну с колен», Санкара ищет помощи от социалистических стран. Возможно, нам следует признать новую власть и отправить послов, тем самым показав свои доброжелательные намерения. Однако, также, леворадикальные антиимпериалистические взгляды, весьма близкие к Мао, при нужной поддержке могут создать нам стабильного союзника в центральной Африке. Хотя…может быть не стоит быть столь торопливым и «раскачивать и так нестабильную лодку революций» на африканском континенте? ";
		}
		else if (GlobalScript.inst.gameState.number_event == 114)
		{
			text2 = "Слон и осёл";
			text = "Вскоре в США пройдут президентские выборы, на которых действующий президент-демократ Джимми Картер баллотируется на второй срок, соперничая с амбициозным республиканцем Рональдом Рейганом. В ходе своего правления Картер пытался улучшить социальное обеспечение американцев, создать более открытое правительство и в целом реформировать некоторые государственные институты США. Внешняя политика характеризовалась балансом между противостоянием с СССР и разрядкой. Однако президентство Картера неудачно совпало с ростом цен на нефть, а относительно умеренная внешняя политика подвергается жёсткой критике консервативных кругов, поэтому республиканцы имеют все шансы на победу. Вмешаться мы, разумеется, не можем, поэтому нам остаётся только ждать.";
		}
		else if (GlobalScript.inst.gameState.number_event == 117)
		{
			text2 = "Пятилетка похорон";
			text = "Только что пришли новости из СССР - 9 февраля от отказа почек в возрасте 69-ти лет умер Генеральный секретарь ЦК КПСС Юрий Андропов. С конца 1983-го он сильно болел, и подхваченная в Крыму простуда окончательно добила советского руководителя. Во время своего правления Андропов уделял большое внимание улучшению экономической ситуации - была запущена кампания по борьбе за трудовую дисциплину, развёрнуты масштабные антикоррупционные меры, направленные главным образом против порождающих дефицит незаконных списаний в торговле. Вместе с тем Андропов активно продвигал молодые реформаторские кадры и поручил Горбачёву, Рыжкову, Абалкину и Долгих разработать проект масштабной экономической реформы для СССР. Ввиду обострившейся политической борьбы новым генсеком скорее всего изберут компромиссного Черненко. А на 14 февраля назначены похороны Андропова, куда намерены прибыть представители многих стран, как союзных СССР, так и прочих. А что делать нам?";
		}
		else if (GlobalScript.inst.gameState.number_event == 99)
		{
			text2 = "Жёлтый скорпион";
			text = "Товарищ председатель, срочная новость из социалистического Алжира! После неожиданной и быстро протекающей болезни, скоропостижно скончался второй президент АНДР Хуари Бумедьен, которого в народе за скрытность и хитрость именовали «Жёлтым скорпионом». За почти полтора десятилетия своего правления Бумедьен сделал из отсталой французской колонии индустриального гиганта Африки. Теперь, из-за отсутствия в стране института преемства, в правящей партии - «Фронте национального освобождения» за власть борются три фракции: ортодоксальные сталинисты, возглавляемые Мохаммедом Салах Яхьяуи, которого рьяно поддерживают профсоюзы, и который против союза с «ревизионистским СССР», умеренные реформаторы с лидером Шадли Бенджедидом, выступающие за сохранение дружеских отношений с СССР, но за внедрение некоторых рыночных реформ, и либералы, симпатизирующие прозападному министру иностранных дел - Абделю Азизу Бутефлику. Если мы поддержим одну из группировок, то вероятно, сможем расширить наше влияние на африканские страны, однако стоит ли это того?";
		}
		else if (GlobalScript.inst.gameState.number_event == 100)
		{
			text2 = "КРИЗИС ПРАВИТЕЛЬСТВА";
			text = "После несчитанных путчей, власть военных в Бангладеш относительно стабилизировалась, и «серый кардинал» генералитета Хуссейн Мохаммад Эршад смог занять пост президента страны. За два года существования правого авторитарного режима, в Бангладеш были развёрнуты полномасштабные репрессии против либералов и социалистов, представленных, в большинстве своём, левой партией «Авами лиг», а основные коренные проблемы страны: малоземелье крестьян и коррупция в высших эшелонах власти, решены не были. В связи с этим, с переменным успехом, во всех городах страны разворачиваются жёсткие акции протеста против действий правительства, главным лозунгом которых является проведение досрочных выборов в парламент. Я думаю, если мы материально поддержим правительство, то сможем усмирить этот «неспокойный очаг переворотов» в Юго-восточной Азии, тем более действующая власть придерживается курса на потепление отношений с Китаем. Однако если мы сможем с большей силой разжечь протесты и сплотить оппозицию против Эршада и генералитета, то к власти придут более лояльные нам люди, но что подумает мировое сообщество в таком случае? Может лучше вообще не вмешиваться?";
		}
		else if (GlobalScript.inst.gameState.number_event == 102)
		{
			text2 = "Ветер перемен?";
			text = "Срочные известия из СССР! 10 марта 1985 года в 19 часов 20 минут генеральный секретарь Константин Устинович Черненко скончался от остановки сердца. Пока народ скорбит, в коридорах Кремля вовсю разворачивается борьба за место нового генерального секретаря, кандидатами на которое являются: |Михаил Горбачёв - молодой и перспективный партиец, некогда член команды Андропова, известный своими реформаторскими взглядами. |Григорий Романов - энергичный и готовый к экспериментам, молодой, но опытный управленец, бывший глава Ленинградского обкома, железной рукой обеспечивший Ленинграду рост благосостояния и экономики.| И, наконец, Виктор Гришин, представитель старого поколения Политбюро и любимец консервативных кругов, глава Московского горкома, сторонник политики Брежнева во внутренних и внешних делах, за долгие годы обросший связями (в том числе коррупционными) в КПСС. |Кого же нам поддержать, если мы вообще сможем?";
		}
		else if (GlobalScript.inst.gameState.number_event == 104)
		{
			text2 = "ХII Всемирный фестиваль молодёжи и студентов";
			text = "В Москве скоро должен пройти XII Всемирный фестиваль молодёжи и студентов. Подобные фестивали организуются Всемирной федерацией демократической молодёжи - международной левой молодёжной организации - с 1947 года и всегда являли собой яркое собрание прогрессивной молодёжи со всего мира, а задачами фестивалей ставились пропаганда социализма и борьба с империализмом. Перед нами встаёт извечный вопрос - ехать или нет? Ведь СССР, являясь принимающей стороной и обладая огромным влиянием на ВФДМ, может нас и не пустить в случае сильных разногласий. В связи с этим некоторые партийцы предлагают провести свой аналогичный фестиваль, пригласив представителей дружественных стран.";
		}
		else if (GlobalScript.inst.gameState.number_event == 105)
		{
			text2 = "Конец албанского Сталина";
			text = "Интересные новости из Албании: 11 апреля в возрасте 76 лет скончался бессменный лидер Албании Энвер Ходжа. Пока страна скорбит о своей утрате, на должность Первого секретаря ЦК АПТ вступил Рамиз Алия, долгое время считавшийся преемником Ходжи и сыгравший важную роль в разгроме группы Мехмета Шеху. Алия пользовался благосклонностью Ходжи за безоговорочную поддержку всех поворотов его политики, однако, по некоторым сведениям, он не прочь наладить отношения с Западом и Югославией, а также провести некоторые послабления во внутренней политике. С одной стороны, это может сыграть нам на руку, а с другой - закончиться неизвестно чем. Поэтому мы могли бы организовать теракт против новоявленного правителя, если, конечно, у нас есть агентура поблизости.";
		}
		else if (GlobalScript.inst.gameState.number_event == 106)
		{
			text2 = "Демократический интернационал";
			text = "В ангольском городе Джамба, являющимся главной базой антикоммунистического повстанческого движения УНИТА, готовится конференция по итогам которой участники хотят создать т. н. \"Демократический интернационал\" - коалицию антикоммунистических повстанцев из разных стран. В конференции, помимо УНИТА, участвуют представители афганских моджахедов, никарагуанских контрас и лаосских хмонгов, а в организации принимают активное участие американские консерваторы, такие как банкир Льюис Лерман (финансист мероприятия), известный лоббист и кинопродюсер Джек Абрамофф (инициатор мероприятия) и подполковник Оливер Норт. Несмотря на яркую антисоветскую направленность готовящегося альянса, он также пересекается с зоной наших интересов и может вызвать проблемы в будущем. С другой стороны мы можем и попытаться использовать его в геополитической борьбе с СССР.";
		}
		else if (GlobalScript.inst.gameState.number_event == 109)
		{
			text2 = "Золотой век Сомали";
			text = "После провала огаденской войны, положение в Сомали началось стремительно ухудшаться. Фронт освобождения Западного Сомали потерпел сокрушительное поражение и был разгромлен эфиопской армией, а сворачивание советской военной и гражданской помощи серьёзно ударило по сомалийской экономике. Сомалийская революционная социалистическая партия постепенно начинает утрачивать популярность населения, а режим Мохаммеда Сиад Барре становится всё более авторитарным. В такой удручающей обстановке правительство Сомали пытается дистанцироваться от Советского Союза, перейдя к сотрудничеству с США и западными странами. Возможно, отправив правительству Сомали всевозможную помощь для урегулирования положения в стране, мы сможем заручиться поддержкой Барре и заиметь выгодного и верного союзника в Восточной Африке. Однако спасёт ли это режим СРСП, против которого по всей стране активно формируются отряды вооружённой оппозиции? Нерешительностью президента Барре крайне недоволен генералитет, может быть, заручившись их поддержкой нам удастся совершить против него заговор и привести к власти более прагматичных лидеров?";
		}
		else if (GlobalScript.inst.gameState.number_event == 110)
		{
			text2 = "Автоматизация – естественный процесс";
			text = "Товарищ председатель! За предыдущую пятилетку мы добились крупных успехов в ведении народного хозяйства и научных исследованиях, и мы не должны останавливаться на достигнутом. Пора закрепить наши успехи и воссоздать мечту многих поколений людей о совершенном мироустройстве, сделав первый шаг от социалистического общества к коммунистическому. Лучшие умы нашей страны – математики и кибернетики предлагают создать полномасштабную и всеобъемлющую систему единого автоматизированного планирования производства, взяв за основу своей идеи концепцию ОГАС советского математика Виктора Глушкова. Тем самым мы сможем избавиться от всех проблем и изъянов плановой экономики, передав выполнение большинства сложных и затратных расчетов вычислительным машинам и ЭВМ. Но для реализации такого огромного проекта понадобиться много средств и времени, однако государственный аппарат как огня боится радикальных изменений, тем более таких, которые могут покушаться на их «засиженные места» и благополучие. Выбор за вами…";
		}
		else if (GlobalScript.inst.gameState.number_event == 111)
		{
			text2 = "К призрачному свету";
			text = "Товарищ председатель! После частичного внедрения системы МЭСУ правительство начало постепенное и планомерное сокращение государственного аппарата на низовом уровне для освобождения лишних квалифицированных рабочих рук и оптимизации бюджета. Эти меры встретили жёсткое сопротивление со стороны местной бюрократии, которая уже объявила вас в «буржуазной контрреволюции». Теперь даже высшее партийное руководство настроено против вас и уже готовит ваше смещение. Нужно незамедлительно принять меры! Нам необходимо заручиться поддержкой широких слоёв населения и победа будет за нами! Но вопрос, поддержат ли они нас?";
		}
		else if (GlobalScript.inst.gameState.number_event == 112)
		{
			text2 = "Предания неведомых миров";
			text = "Товарищ председатель, происходят странные вещи! По всей страны межотраслевые организации дают сбои. Сообщения между предприятиями низового уровня нарушены, продовольствие поставляется в регионы с перебоями, растут очереди в магазинах. По заверениям управляющих на наше оборудование была совершена компьютерная атака извне. Спецслужбы предполагают, что это наши внешние противники, сговорившиеся с врагами автоматизации, боясь неминуемого роста нашего влияния на мировой арене, пытаются нанести удар по нашей экономике путём вывода из строя МЭСУ. Если мы немедленно ничего не предпримем, то это обернётся коллапсом для нашей страны. Специалисты предлагают разработать особую защиту для нашей системы планирования, но для этого потребуется некоторое время. Однако мы можем запросить поддержку экспертов из  Советского Союза, что в свою очередь позволит быстрее вернуть аппаратуру в строй. Или же… автоматизация действительно утопия?";
		}
		else if (GlobalScript.inst.gameState.number_event == 113)
		{
			text2 = "Агония югославского социалистического самоуправления";
			text = "Товарищ Председатель, из Югославии приходят неприятные для нас новости - так называемая \"комиссия Крайгера\", возглавляемая бывшим Председателем Президиума СФРЮ Сергеем Крайгером (словеном по национальности и близким соратником главного теоретика югославского \"социалистического самоуправления\" Эдварда Карделя), представила на рассмотрение Президиума СФРЮ проект масштабных рыночных экономических реформ. Югославия после смерти Иосипа Броз Тито переживает тяжелые времена - последствия сепаратистского мятежа в Косово до сих пор не устранены, в Словении и Хорватии растет недовольство Центром, а в Сербии - националистические настроения. Масло в огонь подлил экономический кризис 1979 года, вынудивший и так погрязшую в долгах страну взять дополнительные кредиты. Похоже, Югославия движется к пропасти... СССР и страны соцлагеря готовы предоставить СФРЮ крупную фин. помощь в обмен на отказ от реформ. Мы тоже можем присоединиться к предложению советского руководства, однако группа партийцев предлагает испирировать военный переворот и привести к власти югославских генералов, настроенных на прекращение политики \"неприсоединения\". С другой стороны, США также предлагают СФРЮ новые кредиты... Итак, что мы предпримем в этой ситуации?";
		}
		else if (GlobalScript.inst.gameState.number_event == 115)
		{
			text2 = "Золотой треугольник";
			text = "Товарищ председатель, как известно нашим спецслужбам, в горных районах Бирмы, Лаоса и Таиланда, которые недавно стали частью нашей сферы влияния, действует крупная сеть синдикатов, занимающихся производством и сбытом наркотиков, называемая \"Золотым треугольником\". Эта сеть сильно способствует коррупции в этих и близлежащих странах, к тому же её возглавляет видный деятель народа шанов, выступающий за их отделение от Бирмы, Кхун Са. Принимая во внимание всё это, часть партийцев и генералитета предлагает оказать этим странам содействие в проведении следственных и войсковых операций против наркоторговцев. Однако есть и другая группа, справедливо заявляющая, что за долгие годы гражданской войны шаны так и не смогли добиться независимости от Бирмы и вряд ли добьются, коррупцию в этих странах ударом по одной сети синдикатов не уничтожить, а наркотики эти идут главным образом в западные страны. В связи с этим они предлагают помочь Золотому треугольнику в организации охраны и сбыта товара, что поможет нам получить деньги и подпортить жизнь западу.";
		}
		else if (GlobalScript.inst.gameState.number_event == 435)
		{
			text2 = GlobalScript.inst.new_events_text[1647];
			text = GlobalScript.inst.new_events_text[1648];
		}
		else if (GlobalScript.inst.gameState.number_event == 436)
		{
			text2 = GlobalScript.inst.new_events_text[1656];
			text = GlobalScript.inst.new_events_text[1657];
		}
		else if (GlobalScript.inst.gameState.number_event == 116)
		{
			text2 = "Два Китая";
			text = "Как вам известно, после победы КПК в гражданской войне остатки Гоминьдана сбежали на остров Тайвань, и долгое время западное сообщество  считало их законным правительством Китая. Из-за американских баз и флота на Тайване мы так и не смогли отбить его, равно как и Гоминьдан не смог вернуть себе материковый Китай, и со временем всё больше стран признали правление КПК, хотя ни коммунистическое ни тайваньское правительство формально не отказывались от претензий на весь Китай. Разумеется, наши отношения всегда были ужасными, однако после недавней либерализации и конца монополии КПК на власть они заметно потеплели. Теперь некоторые люди в верхах обеих стран заговорили о возможности долгожданного воссоединения нации. Однако в этом случае Тайвань однозначно потребует автономию, нам нужно будет договориться с США о статусе их баз, и неизвестно, как жители Тайваня, успевшие развить свою культурную идентичность, повлияют на и так нестабильную ситуацию в стране. Поэтому некоторые предлагают нам с Тайванем взаимно признать друг друга независимыми государствами и наладить добрососедские отношения. И раз уж в этом случае американские базы останутся на месте, а западные компании будут избавлены от кучи бюрократической возни, то неплохо бы намекнуть США, что молодой демократии нужны деньги...";
		}
		else if (GlobalScript.inst.gameState.number_event == 103)
		{
			if (GlobalScript.inst.gameState.allcountries[0].isEU)
			{
				text2 = "Шенгенское соглашение";
				text = "Недавно, 14 июля в Люксембурге между несколькими европейскими странами было подписано Шенгенское соглашение, подразумевающее упрощение паспортно-визового контроля на границах между ними и наметившее движение к фактически полному отказу от паспортного контроля. Шенгенское соглашение натолкнуло ваших сопартийцев на мысль - у нас ведь тоже есть свой экономический союз. Создание единого визового пространства, свободное перемещение между странами союза и упрощение пограничного контроля должно поспособствовать культурному обмену между нашими странами, развитию туризма, да и народу понравится. Проблема в том, что это также упростит жизнь диссидентам и преступникам, да и мало ли каких идей наши граждане за границей наберутся...";
			}
			else
			{
				text2 = "Мадридское соглашение";
				text = "Недавно, 14 июля в Испании между несколькими европейскими странами было подписано Мадридское соглашение, подразумевающее упрощение паспортно-визового контроля на границах между ними и наметившее движение к фактически полному отказу от паспортного контроля. Мадридское соглашение натолкнуло ваших сопартийцев на мысль - у нас ведь тоже есть свой экономический союз. Создание единого визового пространства, свободное перемещение между странами союза и упрощение пограничного контроля должно поспособствовать культурному обмену между нашими странами, развитию туризма, да и народу понравится. Проблема в том, что это также упростит жизнь диссидентам и преступникам, да и мало ли каких идей наши граждане за границей наберутся...";
			}
		}
		else if (GlobalScript.inst.gameState.number_event == 107)
		{
			text2 = "Кризис среди союзников";
			text = "Как всем известно, наше содружество является самым демократичным и равноправным... и это порождает последствия. " + GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].name + " в последнее время проводит всё более независимую от нас политику, а в их политической системе набирают власть нелояльные нам силы, которые хотят провести некоторые реформы.";
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
			{
				text += " Но что ещё хуже так это их дипломатические заигрывания с США и западом! Если так продолжится, то мы рискуем потерять своего союзника, поэтому нужно что-то делать, но что? Мы ведь не хотим поступать как советские ревизионисты в Чехословакии. Или всё-таки..?";
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance)
			{
				text += " Но что ещё хуже так это их дипломатические заигрывания с СССР! Если так продолжится, то мы рискуем потерять своего союзника, поэтому нужно что-то делать, но что? Мы ведь не хотим поступать как советские ревизионисты в Чехословакии. Или всё-таки..?";
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
			{
				text += "|И всё это происходит на фоне готовящейся декларации правительства нашего союзника о декларировании политики нейтралитета, что означает одно: они хотят покинуть наш военный альянс.";
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].econ)
			{
				text += "|И всё это происходит на фоне того, как правительство нашего союзника лихорадочно сокращает все торговые связи с нами, декларируя переориентацию своей экономики, что означает одно: они хотят покинуть наш экономический альянс.";
			}
		}
		Name.text = Utils.Text(text2, 41);
		Zaglav.text = Utils.Text(text, 89);
	}

	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		text = text.Replace('\n', '|');
		text = text.Replace("<color=green>", "♔");
		text = text.Replace("<color=red>", "♕");
		text = text.Replace("<color=yellow>", "♖");
		text = text.Replace("<color=brown>", "♗");
		text = text.Replace("<color=fuchsia>", "♘");
		text = text.Replace("<color=lime>", "♙");
		text = text.Replace("<color=cyan>", "♚");
		text = text.Replace("<color=orange>", "♛");
		text = text.Replace("</color>", "♜");
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
		text2 = text2.Replace("♔", "<color=green>");
		text2 = text2.Replace("♕", "<color=red>");
		text2 = text2.Replace("♖", "<color=yellow>");
		text2 = text2.Replace("♗", "<color=brown>");
		text2 = text2.Replace("♘", "<color=fuchsia>");
		text2 = text2.Replace("♙", "<color=lime>");
		text2 = text2.Replace("♚", "<color=cyan>");
		text2 = text2.Replace("♛", "<color=orange>");
		return text2.Replace("♜", "</color>");
	}

	private void Update()
	{
		bool flag = (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] != 0) || (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] > 1) || (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] < 3) || GlobalScript.inst.gameState.data[56] < 2 || (GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] < 3) || (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[56] > 1);
		if (Input.GetKeyDown(KeyCode.D) && GlobalScript.inst.gameState.number_event == 120 && !GlobalScript.inst.gameState.allcountries[10].parts[0] && !flag)
		{
			SceneManager.LoadScene("Diplomacy");
			GlobalScript.inst.gameState.completedDecisions[0] = false;
		}
	}
}
