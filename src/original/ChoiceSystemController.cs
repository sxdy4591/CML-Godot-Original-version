using System.Collections.Generic;
using UnityEngine;

public class ChoiceSystemController : MonoBehaviour
{
	public Transform mainWindowTR;

	public Transform mainWindowBL;

	public Transform subWindowTR;

	public Transform subWindowBL;

	public Transform subWindow;

	public ChoiceButton[] mainButtons;

	public ChoiceButton[] subButtons;

	private int selectedChoiceType = -1;

	private int[] currentSelectedChoices;

	private string[] choiceTypeNames;

	private List<string>[] choicesNames;

	public GlobalScript global1;

	private void Awake()
	{
		global1 = GlobalScript.inst;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			Set(new int[9]
			{
				PlayerPrefs.GetInt("gamerules0"),
				PlayerPrefs.GetInt("gamerules1"),
				PlayerPrefs.GetInt("gamerules2"),
				PlayerPrefs.GetInt("gamerules3"),
				PlayerPrefs.GetInt("gamerules4"),
				PlayerPrefs.GetInt("gamerules5"),
				PlayerPrefs.GetInt("gamerules6"),
				PlayerPrefs.GetInt("gamerules7"),
				0
			}, new string[9] { " 苏 联 外 交 政 策", " 苏 联 国 民 政 策", " 美 国 外 交 政 策", " 美 国 国 民 政 策", " 移 除 对 手", " 任 命 指 定", " 政 要 下 台", " 政 要 的 影 响", " 无 限 跃 进" }, new List<string>[9]
			{
				new List<string> { " 关 闭 焦 点 （ 成 就 ✓ ）", " 史 实 焦 点 （ 成 就 ✓ ）", " 随 机 焦 点 （ 成 就 ✖ ）", " 寻 衅 焦 点 （ 成 就 ✖ ）", " 缓 和 焦 点 （ 成 就 ✖ ）" },
				new List<string> { " 关 闭 焦 点 （ 成 就 ✓ ）", " 史 实 焦 点 （ 成 就 ✓ ）", " 随 机 焦 点 （ 成 就 ✖ ）", " 极 左 派 （ 成 就 ✖ ）", " 改 革 派 （ 成 就 ✖ ）" },
				new List<string> { " 关 闭 焦 点 （ 成 就 ✓ ）", " 史 实 焦 点 （ 成 就 ✓ ）", " 随 机 焦 点 （ 成 就 ✖ ）", " 寻 衅 焦 点 （ 成 就 ✖ ）", " 缓 和 焦 点 （ 成 就 ✖ ）" },
				new List<string> { " 关 闭 焦 点 （ 成 就 ✓ ）", " 史 实 焦 点 （ 成 就 ✓ ）", " 随 机 焦 点 （ 成 就 ✖ ）", "残 暴Cruel （ 成 就 ✖ ）", "缓 和Softened （ 成 就 ✖ ）" },
				new List<string> { "强 者 为 尊Only strong ones （ 成 就 ✓ ）", "所 有 人Everyone （ 成 就 ✖ ）", "诡 谋 为 尊Only scheming ones （ 成 就 ✖ ）" },
				new List<string> { " 阶 层 匹 配Hierarchy match （ 成 就 ✓ ）", " 高 关 系 度High relationship （ 成 就 ✖ ）", " 全 部All （ 成 就 ✖ ）" },
				new List<string> { " 标 准 （ 成 就 ✓ ）", " 每 5 年 （ 成 就 ✓ ）", "Immortal 不 朽 （ 成 就 ✖ ）" },
				new List<string> { " 标 准 （ 成 就 ✓ ）", "加 强 弱 者Strengthening the weak （ 成 就 ✖ ）", "加 强 强 者Strengthening the strong （ 成 就 ✖ ）" },
				new List<string> { " 关 闭 模 组 （ 成 就 ✓ ）", " 挑 战 模 式 启 动 （ 成 就 ✓ ）" }
			});
		}
		else
		{
			Set(new int[9]
			{
				PlayerPrefs.GetInt("gamerules0"),
				PlayerPrefs.GetInt("gamerules1"),
				PlayerPrefs.GetInt("gamerules2"),
				PlayerPrefs.GetInt("gamerules3"),
				PlayerPrefs.GetInt("gamerules4"),
				PlayerPrefs.GetInt("gamerules5"),
				PlayerPrefs.GetInt("gamerules6"),
				PlayerPrefs.GetInt("gamerules7"),
				0
			}, new string[9] { "Внешняя политика СССР", "Внутренняя политика СССР", "Внешняя политика США", "Внутренняя политика США", "Убирают конкурентов", "Кого можно назначать", "Уход политиков", "Влияние политиков", "Бесконечный скачок" }, new List<string>[9]
			{
				new List<string> { "Выключить фокусы (✓Достижения)", "Историчный (✓Достижения)", "Случайный (✖Достижения)", "Агрессивный (✖Достижения)", "Мирный (✖Достижения)" },
				new List<string> { "Выключить фокусы (✓Достижения)", "Историчный (✓Достижения)", "Случайный (✖Достижения)", "Леворадикальный (✖Достижения)", "Реформистский (✖Достижения)" },
				new List<string> { "Выключить фокусы (✓Достижения)", "Историчный (✓Достижения)", "Случайный (✖Достижения)", "Агрессивный (✖Достижения)", "Мирный (✖Достижения)" },
				new List<string> { "Выключить фокусы (✓Достижения)", "Историчный (✓Достижения)", "Случайный (✖Достижения)", "Жестокий (✖Достижения)", "Смягчённый (✖Достижения)" },
				new List<string> { "Только сильные (✓Достижения)", "Все (✖Достижения)", "Только интриганы (✖Достижения)" },
				new List<string> { "Соответствие иерархии (✓Достижения)", "Высокие отношения (✖Достижения)", "Всех (✖Достижения)" },
				new List<string> { "Стандартный (✓Достижения)", "Каждые 5 лет (✓Достижения)", "Бессмертные (✖Достижения)" },
				new List<string> { "Стандартный (✓Достижения)", "Усиление слабых (✖Достижения)", "Усиление сильных (✖Достижения)" },
				new List<string> { "Режим отключён (✓Достижения)", "Режим усложения включён (✓Достижения)" }
			});
		}
	}

	public void Set(int[] currentSelectedChoices, string[] choiceTypeNames, List<string>[] choicesNames)
	{
		this.currentSelectedChoices = currentSelectedChoices;
		this.choicesNames = choicesNames;
		this.choiceTypeNames = choiceTypeNames;
		Repaint();
	}

	private void Repaint()
	{
		subWindow.gameObject.SetActive(selectedChoiceType != -1);
		if (selectedChoiceType != -1)
		{
			for (int i = 0; i < subButtons.Length; i++)
			{
				if (i > choicesNames[selectedChoiceType].Count - 1)
				{
					subButtons[i].gameObject.SetActive(value: false);
					continue;
				}
				subButtons[i].gameObject.SetActive(value: true);
				subButtons[i].ChangeText(choicesNames[selectedChoiceType][i]);
				subButtons[i].ChangeSelected(currentSelectedChoices[selectedChoiceType] == i);
				subButtons[i].transform.localPosition = new Vector3((subWindowTR.localPosition.x + subWindowBL.localPosition.x) * 0.5f, Mathf.Lerp(subWindowTR.localPosition.y, subWindowBL.localPosition.y, (float)i / (float)(choicesNames[selectedChoiceType].Count - 1)), subButtons[i].transform.localPosition.z);
			}
		}
		for (int j = 0; j < mainButtons.Length; j++)
		{
			if (j > choiceTypeNames.Length - 1)
			{
				mainButtons[j].gameObject.SetActive(value: false);
				continue;
			}
			mainButtons[j].gameObject.SetActive(value: true);
			mainButtons[j].ChangeText(choiceTypeNames[j]);
			mainButtons[j].ChangeSelected(selectedChoiceType == j);
			mainButtons[j].transform.localPosition = new Vector3((mainWindowTR.localPosition.x + mainWindowBL.localPosition.x) * 0.5f, Mathf.Lerp(mainWindowTR.localPosition.y, mainWindowBL.localPosition.y, (float)j / (float)(choiceTypeNames.Length - 1)), mainButtons[j].transform.localPosition.z);
		}
	}

	public void ChoiceMade(int choiceType, int choiceValue)
	{
		Debug.Log($"Choice {choiceType} is {choiceValue} now");
	}

	public void CloseSubWindow()
	{
		selectedChoiceType = -1;
		Repaint();
	}

	public void ReceiveButtonPress(int num)
	{
		if (num >= 100)
		{
			num -= 100;
			selectedChoiceType = ((selectedChoiceType == num) ? (-1) : num);
			Repaint();
		}
		else
		{
			currentSelectedChoices[selectedChoiceType] = num;
			GlobalScript.inst.gameState.gamerules[selectedChoiceType] = num;
			PlayerPrefs.SetInt("gamerules" + selectedChoiceType, num);
			ChoiceMade(selectedChoiceType, num);
			Repaint();
		}
	}
}
