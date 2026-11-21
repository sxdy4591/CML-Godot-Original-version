using UnityEngine;

public class in1992_script : MonoBehaviour
{
	public bool is_left;

	public Sprite navel;

	public Sprite nenavel;

	private GlobalScript global1;

	private TimeScript time1;

	public TextMesh this_text;

	public TextMesh Name;

	public TextMesh End;

	private string fake_text;

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = navel;
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = nenavel;
	}

	private void Awake()
	{
		global1 = GlobalScript.inst;
		if (is_left)
		{
			if (PlayerPrefs.GetInt("language") == 0)
			{
				time1 = GameObject.Find("Text_time").GetComponent<TimeScript>();
				fake_text = " 同 志 ！| 我 们 已 经 迈 上 实 现 中 华 民 族 伟 大 复 兴 的 光 明 大 道 ！未 来 纵 有 艰 难 险 阻 ，但 只 要 不 忘 初 心 ，砥 砺 前 行 ，必 然 能 赢 得 更 加 伟 大 的 胜 利 和 荣 光 。你 就 像 我 们 的 太 阳 ， 指 引 着 人 民 前 进 的 方 向 ：| 在 这 里 可 以 选 择 继 续 掌 权 ，直 至 永 远 ，按 照 你 的 意 愿 塑 造 世 界 秩 序 ，且 在 任 何 时 候 都 可 以 结 束 游 戏 。但 从 新 的 时 间 段 开 始 ， 将 无 法 取 得 任 何 成 就 。| 当 然 ，也 可 以 就 此 功 成 身 退 ，只 要 选 取 右 侧 的 按 钮 ，即 可 结 束 游 戏 进 入 摘 要 窗 口 ， 此 界 面 将 对 你 这 几 年 的 执 政 作 出 评 判 ， 同 时 也 会 展 示 全 球 未 来 的 走 向 。 最 最 重 要 的 是 ，可 以 解 锁 成 就 ！| 现 在 由 你 抉 择";
				this_text.text = Text(fake_text, 72);
			}
			else
			{
				time1 = GameObject.Find("Text_time").GetComponent<TimeScript>();
				fake_text = "Товарищ!| Дальше нас ждут незабываемые и тяжелые времена горьких свершений и великих побед, однако фундамент нашего светлого будущего мы заложили уже сейчас. Впрочем, вы - наш солнцеликий руководитель и вам решать, как поступить дальше:|Вы можете решить играть дальше до бесконечности, в любой момент имея возможность закончить игру, дабы перекроить мир так, как вы считаете нужным. Однако, тогда вы не сможете добиться ни одного достижения, начиная с новой даты.|В ином случае вы можете положить всему этому конец и, просто выбрав правую кнопку, закончить игру и перейти к окну итогов, где будет подведена черта под вашей многолетней работой, а также будет описано состояние всего мира на грядущие годы. И, самое главное, вы сможете открыть достижения!|Выбор за вами.";
				this_text.text = Text(fake_text, 72);
			}
		}
	}

	private void OnMouseDown()
	{
		if (is_left)
		{
			time1.Reborn();
			GlobalScript.inst.gameState.iron_and_blood = false;
			return;
		}
		if (GlobalScript.inst.gameState.resultOfEvents[581] == 2)
		{
			GlobalScript.inst.gameState.data[35] = 13;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (GlobalScript.inst.gameState.data[3] < 300 || (GlobalScript.inst.gameState.data[3] < 500 && GlobalScript.inst.gameState.diff == 4))
		{
			GlobalScript.inst.gameState.data[35] = 1;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (GlobalScript.inst.gameState.data[1] < 300 || (GlobalScript.inst.gameState.data[1] < 500 && GlobalScript.inst.gameState.diff == 4))
		{
			GlobalScript.inst.gameState.data[35] = 2;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (GlobalScript.inst.gameState.data[15] == 9 && GlobalScript.inst.gameState.data[16] == 15 && GlobalScript.inst.gameState.data[17] == 19 && GlobalScript.inst.gameState.modifies[5].active && GlobalScript.inst.gameState.data[108] >= 100)
		{
			GlobalScript.inst.gameState.data[35] = 9;
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
			GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
			return;
		}
		if (GlobalScript.inst.gameState.allcountries[61].SubGosstroy != 0 && GlobalScript.inst.gameState.allcountries[51].isNATO)
		{
			GlobalScript.inst.gameState.empires[0].power += 5;
		}
		if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)
		{
			GlobalScript.inst.gameState.allcountries[51].dev = 0;
		}
		if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3 && GlobalScript.inst.gameState.empires[1].now_leader != 6)
		{
			if (GlobalScript.inst.gameState.empires[1].relations >= GlobalScript.inst.gameState.empires[0].relations)
			{
				GlobalScript.inst.gameState.allcountries[51].Torg = false;
			}
			else
			{
				GlobalScript.inst.gameState.relres = false;
			}
		}
		if (GlobalScript.inst.gameState.data[67] > 0)
		{
			GlobalScript.inst.gameState.data[62] = 0;
		}
		GlobalScript.inst.gameState.data[35] = 0;
		if (GlobalScript.inst.gameState.IndOpp)
		{
			GlobalScript.inst.gameState.empires[1].now_leader = 6;
			GlobalScript.inst.gameState.relres = false;
		}
		if (GlobalScript.inst.gameState.empires[1].now_leader == 3)
		{
			GlobalScript.inst.gameState.empires[1].power += 50;
		}
		else if (GlobalScript.inst.gameState.empires[1].now_leader == 5)
		{
			GlobalScript.inst.gameState.empires[1].power -= 50;
		}
		else if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
		{
			if (GlobalScript.inst.gameState.data[66] == 1)
			{
				GlobalScript.inst.gameState.data[66] = 2;
			}
		}
		else if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
		{
			if ((GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[16] == 11) || (GlobalScript.inst.gameState.allcountries[4].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[4].prosov))
			{
				GlobalScript.inst.gameState.empires[1].power += 100;
			}
			else
			{
				GlobalScript.inst.gameState.empires[1].power += 50;
			}
		}
		GoodEnding();
	}

	private void GoodEnding()
	{
		GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().new_scene = "Ending";
		GameObject.Find("Button (4)").GetComponent<EvetnnashScript>().OnMouseDown();
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
