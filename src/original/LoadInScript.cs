using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using LFKG;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadInScript : MonoBehaviour
{
	public int number;

	public GlobalScript global1;

	public TextMesh Opis;

	public Sprite navel;

	public Sprite nenavel;

	public bool from_string(string str)
	{
		return str == "True";
	}

	private void Awake()
	{
		global1 = GlobalScript.inst;
	}

	public void OnMouseDown()
	{
		GlobalScript.inst.gameState.is_save_bylo = true;
		if (!PlayerPrefs.HasKey("data14" + (number + 10)))
		{
			return;
		}
		int @int = PlayerPrefs.GetInt("language");
		string text = "";
		string[] array = text.Split(':');
		if (number != 5)
		{
			GlobalScript.inst.gameState.iron_and_blood = false;
		}
		TextAsset textAsset = ((@int != 0) ? (Resources.Load("Part_ru") as TextAsset) : (Resources.Load("Part_en") as TextAsset));
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split(':');
		int num = 0;
		if (num < array.Length)
		{
			string[] array2 = array[num].Split(';');
			for (int i = 0; i < GlobalScript.inst.gameState.party_name.Length; i++)
			{
				GlobalScript.inst.gameState.party_name[i] = array2[i + 1];
			}
		}
		textAsset = ((@int != 0) ? (Resources.Load("Doctr_ru") as TextAsset) : (Resources.Load("Doctr_en") as TextAsset));
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split(';');
		for (int j = 0; j < array.Length; j++)
		{
			GlobalScript.inst.gameState.doctr[j] = array[j];
		}
		TextAsset textAsset2 = Resources.Load(string.Format("new_texts_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_texts = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("new_modify_texts_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_modify_texts = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("new_modify_opis_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_modify_desc = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("old_modify_text_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.old_modify_texts = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("old_modify_opis_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.old_modify_desc = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("Events_text_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_events_text = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("new_focuses_texts_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		FocusReader.CreateDictionary();
		FocusReader.ReadFocuses(textAsset2.text);
		textAsset2 = Resources.Load(string.Format("new_event_text_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		textAsset2 = Resources.Load(string.Format("other_text_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.other_text = textAsset2.text.Split('\n');
		LoadYugoSave(number);
		GlobalScript.inst.CreateDecisions();
		GlobalScript.inst.CreateDecisions();
		SceneManager.LoadScene("Diplomacy");
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
		if (GlobalScript.inst.gameState.allcountries[17].parts[0] && GlobalScript.inst.gameState.allcountries[17].proprc && GlobalScript.inst.gameState.allcountries[17].Gosstroy == 1)
		{
			GlobalScript.inst.old_modify_desc[53] = "<color=lime>特 工 网 络+1.5;|</color><color=#9370DB>极 左 派+1;|极 左 派 力 量+1.</color>|";
			GlobalScript.inst.old_modify_texts[53] = " 与 革 命 保 卫 办 公 室 合 作";
		}
		GlobalScript.inst.old_modify_desc[11] = " 农 业 、 工 业 和 服 务 业+5.0| 预 算+5.0 ， 生 活 水 平+1.0 ， 腐 败-1.0| 党 内 支 持 度-5.0| 每 两 周";
		if (GlobalScript.inst.gameState.YugAgree)
		{
			GlobalScript.inst.old_modify_texts[44] = " 法 国 总 统 - 罗 兰 · 勒 罗 伊";
			GlobalScript.inst.old_modify_desc[44] = " 在 党 内 路 线 比 “ 中 式 社 会 主 义 ” 更 激 进 ， 未 遭 受 苏 联 禁 运 且 与 法 国 建 立 贸 易 关 系 时 ：|<color=lime>|与 苏 联 关 系+0.5;|预 算+0.3;|科 研 点 数+0.3|</color>||<color=#9370DB>苏 联 影 响+0.1.</color>";
			GlobalScript.inst.old_modify_desc[56] = "吉 斯 卡 尔 · 德 斯 坦 的 支 持 度 ： {21}|弗 朗 西 斯 · 密 特 朗 的 支 持 度 ： {22}|罗 兰 · 勒 罗 伊 的 支 持 度 ： {23}|雅 克 · 希 拉 克 的 支 持 度 ： {24}";
		}
		if (!GlobalScript.inst.gameState.event_done[53])
		{
			string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
			int num2 = 15;
			old_modify_desc[num2] += "<color=red>| 缓 慢 推 进 集 体 化 的 公 社 ：</color>| 农 业+0.1 ， 工 业+0.1 ， 生 活 水 平+0.2 ， 预 算+0.1";
		}
		if (GlobalScript.inst.gameState.event_done[53])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[53] == 0)
			{
				string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
				int num3 = 15;
				old_modify_desc2[num3] += "<color=red>| 缓 慢 推 进 集 体 化 的 公 社 ：</color>| 农 业+0.1 ， 工 业+0.1 ， 生 活 水 平+0.2 ， 预 算+0.1";
			}
			if (GlobalScript.inst.gameState.resultOfEvents[53] == 1)
			{
				string[] old_modify_desc3 = GlobalScript.inst.old_modify_desc;
				int num4 = 15;
				old_modify_desc3[num4] += "<color=red>| 家 庭 联 产 承 包 责 任 制 ：</color>| 预 算+0.4 ， 腐 败+0.3 | 若 福 利 投 资 低 于20，则 农 业-0.2 ， 生 活 水 平-0.2 ， 服 务 业-0.1| 若 福 利 投 资 高 于20，则 农 业+0.2 ， 生 活 水 平+0.2 ， 服 务 业+0.1";
			}
			if (GlobalScript.inst.gameState.resultOfEvents[53] == 2)
			{
				string[] old_modify_desc4 = GlobalScript.inst.old_modify_desc;
				int num5 = 15;
				old_modify_desc4[num5] += "<color=red>| 私 人 农 场 ：</color>| 农 业-0.4 ， 生 活 水 平-0.4 ， 预 算+1.0 ， 服 务 业+0.2 ， 腐 败+0.4 ，寡 头+4";
			}
			if (GlobalScript.inst.gameState.resultOfEvents[53] == 3)
			{
				string[] old_modify_desc5 = GlobalScript.inst.old_modify_desc;
				int num6 = 15;
				old_modify_desc5[num6] += "<color=red>| 快 速 推 进 集 体 化 的 公 社 ：</color>| 农 业+0.4 ， 工 业+0.4 ， 生 活 水 平+0.4 ， 预 算+0.2";
			}
		}
		if (GlobalScript.inst.gameState.science[3])
		{
			string[] old_modify_desc6 = GlobalScript.inst.old_modify_desc;
			int num7 = 15;
			old_modify_desc6[num7] += "<color=red>| 农 业 机 械 化 ：</color>| 农 业+0.6 ， 工 业+0.4";
		}
		if (GlobalScript.inst.gameState.science[6])
		{
			string[] old_modify_desc7 = GlobalScript.inst.old_modify_desc;
			int num8 = 15;
			old_modify_desc7[num8] += "<color=red>| 普 及 化 肥 与 杀 虫 剂 ：</color>| 农 业+0.3 ， 生 活 水 平+0.4";
		}
		if (GlobalScript.inst.gameState.science[7])
		{
			string[] old_modify_desc8 = GlobalScript.inst.old_modify_desc;
			int num9 = 15;
			old_modify_desc8[num9] += "<color=red>| 转 基 因 技 术 ：</color>| 农 业+0.2 ， 工 业+0.2 ， 生 活 水 平+0.5 ， 预 算+0.3";
		}
		GlobalScript.inst.old_modify_desc[2] = "根 据 服 务 业 的 发 展 情 况 获 得 效 果|";
		if (GlobalScript.inst.gameState.data[108] < 54)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>受 到 管 控 的 私 有 制 ：</color> 投 机 倒 把 的 商 人 还 影 响 不 到 我 们";
		}
		else if (GlobalScript.inst.gameState.data[108] < 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>逐 渐 崛 起 的 寡 头 ：</color>人 民 支 持 度-0.5 ， 思 想 自 由 化+1 ， 生 活 水 平-0.5 ";
		}
		else if (GlobalScript.inst.gameState.data[108] >= 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>寡 头 执 政 ：</color>人 民 支 持 度-1 ， 思 想 自 由 化+2 ， 生 活 水 平-1 ";
		}
		if (!GlobalScript.inst.gameState.event_done[669])
		{
			string[] old_modify_desc9 = GlobalScript.inst.old_modify_desc;
			int num10 = 2;
			old_modify_desc9[num10] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.1 ， 工 业+0.2 ，农 业+0.2 ， 人 民 支 持 度+0.2 ， 科 技 点 数+0.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 0)
		{
			string[] old_modify_desc10 = GlobalScript.inst.old_modify_desc;
			int num11 = 2;
			old_modify_desc10[num11] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.2 ， 工 业+0.3 ，农 业+0.3 ， 人 民 支 持 度+0.3 ， 科 技 点 数+1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 1)
		{
			string[] old_modify_desc11 = GlobalScript.inst.old_modify_desc;
			int num12 = 2;
			old_modify_desc11[num12] += "|<color=red>正 统 社 会 主 义 教 育 路 线 ：</color>预 算-0.1 ， 腐 败 + 0.1 ， 科 技 点 数+1.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 2)
		{
			string[] old_modify_desc12 = GlobalScript.inst.old_modify_desc;
			int num13 = 2;
			old_modify_desc12[num13] += "|<color=red>混 合 式 教 育 体 制 改 革 ：</color>预 算+0.2 ， 寡 头 力 量+0.1 , 腐 败 + 0.2 ， 科 技 点 数+2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 3)
		{
			string[] old_modify_desc13 = GlobalScript.inst.old_modify_desc;
			int num14 = 2;
			old_modify_desc13[num14] += "|<color=red>全 民 军 事 化 教 育 ：</color>军 事 力 量+0.3 ，人 民 支 持 度+1 ， 思 想 自 由 化-1 ， 科 技 点 数-2 ， 凝 聚 力+0.5 ， 民 族 情 绪+0.5";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[456] == 0 && GlobalScript.inst.gameState.event_done[456])
		{
			string[] old_modify_desc14 = GlobalScript.inst.old_modify_desc;
			int num15 = 2;
			old_modify_desc14[num15] += "|<color=red>全 国 高 校 统 一 招 生 考 试 ：</color>科 技 点 数 +2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 1 && GlobalScript.inst.gameState.event_done[456])
		{
			string[] old_modify_desc15 = GlobalScript.inst.old_modify_desc;
			int num16 = 2;
			old_modify_desc15[num16] += "|<color=red>预 科 制 度 ：</color>科 技 点 数 +1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 2 || !GlobalScript.inst.gameState.event_done[456])
		{
			string[] old_modify_desc16 = GlobalScript.inst.old_modify_desc;
			int num17 = 2;
			old_modify_desc16[num17] += "|<color=red>无 产 阶 级 推 荐 制 ：</color>农 业+0.3 ， 工 业+0.3";
		}
		if (!GlobalScript.inst.gameState.event_done[646])
		{
			string[] old_modify_desc17 = GlobalScript.inst.old_modify_desc;
			int num18 = 2;
			old_modify_desc17[num18] += "|<color=red>合 作 医 疗 ：</color>预 算-0.1 ， 工 业+0.2 ， 农 业+0.3 ， 人民支持度+0.2 , 服 务 业+0.2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 0)
		{
			string[] old_modify_desc18 = GlobalScript.inst.old_modify_desc;
			int num19 = 2;
			old_modify_desc18[num19] += "|<color=red>精 进 的 合 作 医 疗 ：</color>预 算-0.2 ， 工 业+0.3 ， 农 业+0.4 ， 人民支持度+0.2 , 服 务 业+0.3";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 1)
		{
			string[] old_modify_desc19 = GlobalScript.inst.old_modify_desc;
			int num20 = 2;
			old_modify_desc19[num20] += "|<color=red>市 场 化 改 革 医 疗 ：</color>预 算+0.2 ， 生 活 水 平+0.1 ， 寡 头 力 量+0.1 , 服 务 业+0.1";
		}
		if (GlobalScript.inst.gameState.event_done[513])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[513] == 0)
			{
				string[] old_modify_desc20 = GlobalScript.inst.old_modify_desc;
				int num21 = 50;
				old_modify_desc20[num21] += "<color=red>| 仿 制 苏 械 ：</color>| 军 力+0.1";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[513] == 1)
			{
				string[] old_modify_desc21 = GlobalScript.inst.old_modify_desc;
				int num22 = 50;
				old_modify_desc21[num22] += "<color=red>| 自 研 军 械 ：</color>| 军 力+0.2";
			}
		}
		if (GlobalScript.inst.gameState.event_done[514])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[514] == 0)
			{
				string[] old_modify_desc22 = GlobalScript.inst.old_modify_desc;
				int num23 = 50;
				old_modify_desc22[num23] += "<color=red>| 新 式 军 装 ：</color>| 人 民 支 持 度+0.1 ， 思 想 自 由 化-0.1 ， 国 际 声 望 高 于90/ 低 于 70 时 ， 国 际 声 望-0.1/ +0.1";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[514] == 1)
			{
				string[] old_modify_desc23 = GlobalScript.inst.old_modify_desc;
				int num24 = 50;
				old_modify_desc23[num24] += "<color=red>| 西 式 军 装 ：</color>| 人 民 支 持 度+0.1 ， 思 想 自 由 化+0.1 ， 国 际 声 望-0.2";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[514] == 2)
			{
				string[] old_modify_desc24 = GlobalScript.inst.old_modify_desc;
				int num25 = 50;
				old_modify_desc24[num25] += "<color=red>| 65 式 军 装 ：</color>| 人 民 支 持 度+0.1 ， 思 想 自 由 化-0.2 ， 国 际 声 望+0.2";
			}
		}
		if (GlobalScript.inst.gameState.event_done[345])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[345] == 0)
			{
				string[] old_modify_desc25 = GlobalScript.inst.old_modify_desc;
				int num26 = 50;
				old_modify_desc25[num26] += "<color=red>| 没 有 军 衔 的 军 队：</color>| 人 民 支 持 度+0.3 ， 军 力+0.2 ， 干 涉 点 数+0.2";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[345] == 1)
			{
				string[] old_modify_desc26 = GlobalScript.inst.old_modify_desc;
				int num27 = 50;
				old_modify_desc26[num27] += "<color=red>| 恢 复 军 衔 ：</color>| 军 力+0.5 ， 干 涉 点 数+0.2 ， 腐 败+0.2 ， 资 金-0.1";
			}
		}
		if (GlobalScript.inst.gameState.event_done[515] && GlobalScript.inst.gameState.resultOfEvents[515] == 0)
		{
			string[] old_modify_desc27 = GlobalScript.inst.old_modify_desc;
			int num28 = 50;
			old_modify_desc27[num28] += "<color=red>| 无 人 飞 行 器 ：</color>| 军 力+0.2 ， 特 工 网 络 + 0.1";
		}
		if (GlobalScript.inst.gameState.event_done[516])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[516] == 0)
			{
				string[] old_modify_desc28 = GlobalScript.inst.old_modify_desc;
				int num29 = 50;
				old_modify_desc28[num29] += "<color=red>| 改 进 坦 克 ：</color>| 军 力+0.3 ， 预 算-0.1";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[516] == 1)
			{
				string[] old_modify_desc29 = GlobalScript.inst.old_modify_desc;
				int num30 = 50;
				old_modify_desc29[num30] += "<color=red>| 自 研 坦 克 ：</color>| 军 力+0.6 ， 预 算-0.2 ， 凝 聚 力+0.2";
			}
		}
		if (GlobalScript.inst.gameState.event_done[517])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[517] == 0)
			{
				string[] old_modify_desc30 = GlobalScript.inst.old_modify_desc;
				int num31 = 50;
				old_modify_desc30[num31] += "<color=red>| 新 式 歼 击 机 ：</color>| 军 力+0.3 ， 人 民 支 持 度+0.2 ， 预 算-0.2 ， 军 武 援 助 效 果+1";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[517] == 1)
			{
				string[] old_modify_desc31 = GlobalScript.inst.old_modify_desc;
				int num32 = 50;
				old_modify_desc31[num32] += "<color=red>| 新 式 轰 炸 机 ：</color>| 军 力+0.5 ， 预 算-0.2 ，与 美 苏 关 系-0.2 ， 军 武 援 助 效 果+1";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[517] == 2)
			{
				string[] old_modify_desc32 = GlobalScript.inst.old_modify_desc;
				int num33 = 50;
				old_modify_desc32[num33] += "<color=red>| 新 式 歼 击 机 与 轰 炸 机 ：</color>| 军 力+1.0 ， 人 民 支 持 度+0.2 ， 预 算-0.3 ，与 美 苏 关 系-0.2 ， 军 武 援 助 效 果+2";
			}
		}
		if (GlobalScript.inst.gameState.event_done[518])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[518] == 0)
			{
				string[] old_modify_desc33 = GlobalScript.inst.old_modify_desc;
				int num34 = 50;
				old_modify_desc33[num34] += "<color=red>| 隐 身 歼 击 机 ：</color>| 军 力+0.2 ， 人 民 支 持 度+0.2 ， 预 算-0.2 ， 干 预 点 数+1.0";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[518] == 1)
			{
				string[] old_modify_desc34 = GlobalScript.inst.old_modify_desc;
				int num35 = 50;
				old_modify_desc34[num35] += "<color=red>| 隐 身 轰 炸 机 ：</color>| 军 力+0.3 ， 预 算-0.2 ，与 美 苏 关 系-0.1 ，干 预 点 数+1.0";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[518] == 2)
			{
				string[] old_modify_desc35 = GlobalScript.inst.old_modify_desc;
				int num36 = 50;
				old_modify_desc35[num36] += "<color=red>| 隐 身 歼 击 机 与 轰 炸 机 ：</color>| 军 力+0.8 ， 人 民 支 持 度+0.2 ， 预 算-0.3 ，与 美 苏 关 系-0.1 ， 干 预 点 数+2.0";
			}
		}
		if (GlobalScript.inst.gameState.event_done[519])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[519] == 0)
			{
				string[] old_modify_desc36 = GlobalScript.inst.old_modify_desc;
				int num37 = 50;
				old_modify_desc36[num37] += "<color=red>| 新 型 导 弹 驱 逐 舰  ：</color>| 军 力+1.8 ， 人 民 支 持 度+0.5 ， 预 算-0.4";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[519] == 1)
			{
				string[] old_modify_desc37 = GlobalScript.inst.old_modify_desc;
				int num38 = 50;
				old_modify_desc37[num38] += "<color=red>| 改 造 导 弹 驱 逐 舰  ：</color>| 军 力+1.5 ， 人 民 支 持 度+0.2 ，预 算-0.3 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[519] == 2)
			{
				string[] old_modify_desc38 = GlobalScript.inst.old_modify_desc;
				int num39 = 50;
				old_modify_desc38[num39] += "<color=red>| 改 造 与 新 型 导 弹 驱 逐 舰  ：</color>| 军 力+3.5 ， 人 民 支 持 度+1.0 ， 预 算-0.5";
			}
		}
		if (GlobalScript.inst.gameState.event_done[520])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[520] == 0)
			{
				string[] old_modify_desc39 = GlobalScript.inst.old_modify_desc;
				int num40 = 50;
				old_modify_desc39[num40] += "<color=red>| 0 9 3 核 潜 艇 ：</color>| 军 力+2.0 ， 人 民 支 持 度+0.5 ， 美 苏 关 系-0.3 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[520] == 1)
			{
				string[] old_modify_desc40 = GlobalScript.inst.old_modify_desc;
				int num41 = 50;
				old_modify_desc40[num41] += "<color=red>| 0 9 4 核 潜 艇 与 巨 浪 - 2 型 潜 射 导 弹  ：</color>| 军 力+4.0 ， 人 民 支 持 度+0.8 ， 美 苏 关 系-0.4 ， 预 算-0.5 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[520] == 2)
			{
				string[] old_modify_desc41 = GlobalScript.inst.old_modify_desc;
				int num42 = 50;
				old_modify_desc41[num42] += "<color=red>| 0 9 2 核 潜 艇 ：</color>| 军 力+1.0 ， 人 民 支 持 度+1.0 ， 美 苏 关 系-0.2";
			}
		}
		if (GlobalScript.inst.gameState.event_done[521])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[521] == 0)
			{
				string[] old_modify_desc42 = GlobalScript.inst.old_modify_desc;
				int num43 = 50;
				old_modify_desc42[num43] += "<color=red>| 导 弹 驱 逐 舰 ：</color>| 军 力+3.0 ， 人 民 支 持 度+1.0 ， 影 响 力+0.5 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[521] == 1)
			{
				string[] old_modify_desc43 = GlobalScript.inst.old_modify_desc;
				int num44 = 50;
				old_modify_desc43[num44] += "<color=red>| 航 空 母 舰 ：</color>| 军 力+3.0 ， 干 涉 点 数+2.0 ， 人 民 支 持 度+1.0 ， 影 响 力+0.5 ， 军 武 支 援 效 果+1";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[521] == 2)
			{
				string[] old_modify_desc44 = GlobalScript.inst.old_modify_desc;
				int num45 = 50;
				old_modify_desc44[num45] += "<color=red>| 导 弹 驱 逐 舰 与 航 空 母 舰 ：</color>| 军 力+5.0 ， 人 民 支 持 度+2.5 ， 干 涉 点 数+3.0 ， 影 响 力+1.0 ， 军 武 支 援 效 果+2";
			}
		}
		if (GlobalScript.inst.gameState.event_done[540])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[540] == 0)
			{
				string[] old_modify_desc45 = GlobalScript.inst.old_modify_desc;
				int num46 = 50;
				old_modify_desc45[num46] += "<color=red>| 自 研 直 升 机 ：</color>| 军 力+0.4 ，干 涉 点 数+0.2";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[540] == 1)
			{
				string[] old_modify_desc46 = GlobalScript.inst.old_modify_desc;
				int num47 = 50;
				old_modify_desc46[num47] += "<color=red>| 法 式 直 升 机 ：</color>| 军 力+0.2 ，干 涉 点 数+0.1";
			}
		}
		if (GlobalScript.inst.gameState.event_done[544])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[544] == 0)
			{
				string[] old_modify_desc47 = GlobalScript.inst.old_modify_desc;
				int num48 = 50;
				old_modify_desc47[num48] += " <color=red>| 核 防 御 措 施 ：</color>| 军 力+0.7 ， 外 交 声 誉-0.5";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[544] == 1)
			{
				string[] old_modify_desc48 = GlobalScript.inst.old_modify_desc;
				int num49 = 50;
				old_modify_desc48[num49] += " <color=red>| 核 威 慑 措 施 ：</color>| 军 力+2.0 ， 美 苏 关 系-0.2";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[544] == 2)
			{
				string[] old_modify_desc49 = GlobalScript.inst.old_modify_desc;
				int num50 = 50;
				old_modify_desc49[num50] += " <color=red>| 核 防 御 与 核 威 慑 措 施 ：</color>| 军 力+4.0 ， 美 苏 关 系-0.4 ， 可 禁 运 美 苏";
			}
		}
		if (GlobalScript.inst.gameState.event_done[545])
		{
			if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
			{
				string[] old_modify_desc50 = GlobalScript.inst.old_modify_desc;
				int num51 = 50;
				old_modify_desc50[num51] += " <color=red>| 军 用 运 输 机 ：</color>| 军 力+1.0 ， 支 援 战 争 消 耗 的 干 涉 点 数-0.2";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[545] == 1)
			{
				string[] old_modify_desc51 = GlobalScript.inst.old_modify_desc;
				int num52 = 50;
				old_modify_desc51[num52] += " <color=red>| 民 用 运 输 机 ：</color>| 生活水平+1.0 ， 人 民 支 持 度+1.0 ， 思 想 自 由 化-0.5";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
			{
				string[] old_modify_desc52 = GlobalScript.inst.old_modify_desc;
				int num53 = 50;
				old_modify_desc52[num53] += " <color=red>| 军 用 与 民 用 运 输 机 ：</color>| 军 力+2.0 ， 生活水平+1.5 ， 人 民 支 持 度+2.0 ， 思 想 自 由 化-1.0 ， 支 援 战 争 消 耗 的 干 涉 点 数-0.5";
			}
		}
		if (GlobalScript.inst.gameState.allcountries[16].prcinfl != 0)
		{
			string[] old_modify_desc53 = GlobalScript.inst.old_modify_desc;
			int num54 = 50;
			old_modify_desc53[num54] += "<color=red>| 现 代 化 的 机 械 陆 军 ：</color>| 军 力+0.5 ， 特 工 网 络 + 0.3 ， 干 涉 点 数 +1.0 ， 预 算-0.8 ， 科 技 点 数-0.2 ， 人 民 支 持 度+1.0";
		}
		if (GlobalScript.inst.gameState.allcountries[21].prcinfl != 0)
		{
			string[] old_modify_desc54 = GlobalScript.inst.old_modify_desc;
			int num55 = 8;
			old_modify_desc54[num55] += "<color=red>| 与 法 国 的 电 子 工 业 合 作 ：</color>|预 算-0.3 ， 科 技 点 数+0.4 ， 人 民 支 持 度+0.5 ， 工 业+0.3";
		}
		if (GlobalScript.inst.gameState.allcountries[0].prcinfl != 0)
		{
			string[] old_modify_desc55 = GlobalScript.inst.old_modify_desc;
			int num56 = 8;
			old_modify_desc55[num56] += "<color=red>| 加 深 与 欧 洲 国 家 贸 易 ：</color>| 与 欧 洲 国 家 的 贸 易 额 外 获 得 0.1 预算";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[668] == 0)
		{
			GlobalScript.inst.old_modify_desc[3] = " 收 入+0.6 ， 特 工 网 络+0.2 ， 军 队 力 量+0.5|<color=red> 如 果 毛 主 席 已 逝 世 ：</color>  人 民 支 持 度+0.5 ， 思 想 自 由 化+1 ， 生 活 水 平-0.5 ，与 美 国 关 系-0.5|<color=red> 全 新 的 高 潮 ：</color>  党 内 团 结 度+0.5 ， 人 民 支 持 度+0.5 ， 思 想 自 由 化+0.5 ， 极 左 力 量+1";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[668] == 2)
		{
			GlobalScript.inst.old_modify_desc[7] = " 如 果 腐 败>20 ， 则-0.1 腐 败| 如 果 自 由 化>80 ， 则-0.3 自 由 化| 如 果 工 业<50 ， 则+0.3 工 业| 如 果 服 务 业<50 ， 则+0.3 服 务 业| 如 果 与 美 国 关 系<40 ， 则 与 美 国 关 系 ：+1%| 如 果 凝 聚 力<40 ， 则+0.3 凝 聚 力 |<color=red> 难 以 忘 却 的 伤 痕</color>  党 内 团 结 度-0.5 ， 人 民 支 持 度+0.5 ， 思 想 自 由 化+1 ， 改 革 力 量+1 ， 自 由 力 量+1 ， 极 左 力 量-1";
		}
		if (GlobalScript.inst.gameState.modifies[34].active)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[320] == 1)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>三 北 防 护 林 ：</color>| 农 业+0.7 ， 工 业+0.2 ， 预 算-0.3 ， 统 一 度+0.2 ， 人 民 支 持 度+0.1 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[320] == 2)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>南 水 北 调 工 程 ：</color>| 农 业+0.3 ， 工 业+0.5 ， 预 算-0.5 ， 凝 聚 力+0.2";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[320] == 3)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>三 北 防 护 林 ：</color>| 农 业+0.7 ， 工 业+0.2 ， 预 算-0.3 ， 统 一 度+0.2 ， 人 民 支 持 度+0.1 |<color=red>南 水 北 调 工 程 ：</color>| 农 业+0.3 ， 工 业+0.5 ， 预 算-0.5 ， 凝 聚 力+0.2";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[320] == 4)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>江 淮 运 河 ：</color>| 服 务 业+0.1 ， 工 业+0.1 ， 预 算+0.2";
			}
		}
		if (GlobalScript.inst.gameState.modifies[59].active)
		{
			int num57 = 0;
			int num58 = 0;
			int num59 = 0;
			if (GlobalScript.inst.gameState.allcountries[1].okb)
			{
				for (int k = 0; k < GlobalScript.inst.gameState.allcountries.Length; k++)
				{
					if (GlobalScript.inst.gameState.allcountries[k].okb)
					{
						num57++;
						if (((k > 53 && k < 69) || (k > 105 && k < 109) || (k > 111 && k < 134) || k == 41 || k == 42 || k == 52 || k == 99 || k == 100) && k != 55 && k != 54 && k != 128 && GlobalScript.inst.gameState.allcountries[k].proprc && (GlobalScript.inst.gameState.allcountries[k].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[k].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
						{
							num59++;
						}
					}
					if (GlobalScript.inst.gameState.allcountries[k].oar)
					{
						num58++;
					}
				}
				GlobalScript.inst.old_modify_desc[59] = string.Format("{0}{1}{2}", new object[3]
				{
					GlobalScript.inst.gameState.allcountries[1].okb ? (" 集 体 安 全 联 盟 ：|军 事 力 量+" + num57 * 3 / 10 + "." + Mathf.Abs(num57 * 3 % 10) + " ；特 工 网 络+" + num57 * 2 / 10 + "." + Mathf.Abs(num57 * 2 % 10) + " ；干 涉 点 数+" + num57 / 10 + "." + Mathf.Abs(num57 % 10)) : null,
					(GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0) ? (" |非 洲 联 盟 : |军 事 力 量 +" + num59 * 3 / 10 + "." + Mathf.Abs(num59 * 3 % 10) + " ；特 工 网 络+" + num59 * 2 / 10 + "." + Mathf.Abs(num59 * 2 % 10) + " ；干 涉 点 数+" + num59 / 10 + "." + Mathf.Abs(num59 % 10)) : null,
					(!GlobalScript.inst.gameState.allcountries[30].oar) ? null : ((GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1) ? (" |阿 拉 伯 革 命 同 盟 :| 军 事 力 量 +" + num58 * 3 / 10 + "." + Mathf.Abs(num58 * 3 % 10) + " ；特 工 网 络+" + num58 * 2 / 10 + "." + Mathf.Abs(num58 * 2 % 10) + " ；干 涉 点 数+" + num58 / 10 + "." + Mathf.Abs(num58 % 10)) : (" |阿 拉 伯 联 合 共 和 国 :| 军 事 力 量 +" + num58 * 3 / 10 + "." + Mathf.Abs(num58 * 3 % 10) + " ；特 工 网 络+" + num58 * 2 / 10 + "." + Mathf.Abs(num58 * 2 % 10) + " ；干 涉 点 数+" + num58 / 10 + "." + Mathf.Abs(num58 % 10)))
				});
			}
		}
		if (GlobalScript.inst.gameState.event_done[548] && GlobalScript.inst.gameState.modifies[3].active)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[548] == 0)
			{
				string[] old_modify_desc56 = GlobalScript.inst.old_modify_desc;
				int num60 = 6;
				old_modify_desc56[num60] += "<color=red>| 革 命 国 际 主 义 运 动 — — 深 化 国 间 经 济 - 政 治 一 体 化 ：</color>| 农 业 、 工 业 和 服 务 业+0.4 ； 生 活 水 平+0.2 ； 人 民 支 持 度+0.5 ； 凝 聚 力+0.1 ； 思 想 自 由 化-0.2 ； 与 美 苏 关 系-0.2 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
			{
				string[] old_modify_desc57 = GlobalScript.inst.old_modify_desc;
				int num61 = 6;
				old_modify_desc57[num61] += "<color=red>| 革 命 国 际 主 义 运 动 — — 共 产 党 情 报 局 ：</color>| 极 左 派+1 ； 极 左 派 力 量+1 ； 干 涉 点 数+3.0 ； 国 际 声 望+0.1 ； 与 美 苏 关 系-0.6 ； 国 际 影 响 力+0.5 ； 预 算-0.6 ； 特 工-0.6 ； 特 勤 援 助 的 效 果+1 ； 人 道 主 义 援 助 的 效 果+1 ； 中 国 一 次 性 外 交 声 援 的 效 果+3 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
			{
				string[] old_modify_desc58 = GlobalScript.inst.old_modify_desc;
				int num62 = 6;
				old_modify_desc58[num62] += "<color=red>| 革 命 国 际 主 义 运 动 — — 深 化 国 间 经 济 - 政 治 一 体 化 ：</color>| 农 业 、 工 业 和 服 务 业+0.4 ； 生 活 水 平+0.2 ； 人 民 支 持 度+0.5 ； 凝 聚 力+0.1 ； 思 想 自 由 化-0.2 ； 与 美 苏 关 系-0.2";
				string[] old_modify_desc59 = GlobalScript.inst.old_modify_desc;
				int num63 = 6;
				old_modify_desc59[num63] += "<color=red>| 革 命 国 际 主 义 运 动 — — 新 国 际 ：</color>| 极 左 派 +2 ； 极 左 派 力 量 +2 ； 干 涉 点 数 +5.0 ； 国 际 声 望+0.2 ； 国 际 声 望 低 于90.0 时 ， 国 际 声 望 额 外+0.1 ； 与 美 苏 关 系-1 ； 国 际 影 响 力+1 ； 预 算-1 ； 特 工-1 ； 军 力-1 ； 军 事 援 助 的 效 果+2 ； 特 勤 援 助 的 效 果+3 ； 人 道 主 义 援 助 的 效 果+3 ； 中 国 一 次 性 外 交 声 援 的 效 果+6";
			}
		}
		if (GlobalScript.inst.gameState.resultOfEvents[670] == 0 && GlobalScript.inst.gameState.modifies[3].active)
		{
			string[] old_modify_desc60 = GlobalScript.inst.old_modify_desc;
			int num64 = 6;
			old_modify_desc60[num64] += "|<color=red>宣 传 鼓 动——群 众 自 己 解 放 自 己 ：</color>  党 内 团 结 度-1.5 ， 人 民 支 持 度+0.4 ， 思 想 自 由 化+0.4 ， 极 左 力 量+1 ； 每 5 点 宣 传 投 资 ： 党 内 团 结 度+0.1 ， 人 民 支 持 度+0.1 ， 思 想 自 由 化-0.1 ； 宣 传 投 资 不 低 于40 时 ， 党 内 团 结 度+0.7 ， 人 民 支 持 度+1.0 ， 思 想 自 由 化-1.0 ， 特 勤 网 络+2.0";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[670] == 1)
		{
			string[] old_modify_desc61 = GlobalScript.inst.old_modify_desc;
			int num65 = 6;
			old_modify_desc61[num65] += "|<color=red>新 时 代 红 卫 兵——革 命 的 大 联 合 ：</color>  党 内 团 结 度 -0.2 ， 人 民 支 持 度 +0.2 ， 军 事 实 力 -0.4 ， 特 勤 网 络 -0.4 ； 每10 点 行 政 投 资 ： 党 内 团 结 度 +0.1 ， 人 民 支 持 度 +0.2 ， 思 想 自 由 化 -0.2 ， 军 事 实 力 +0.1 ， 特 勤 网 络 +0.1 ； 行 政 投 资 不 低 于50 时 ， 党 内 团 结 度 +1.0 ， 人 民 支 持 度 +1.0 ， 思 想 自 由 化 -1.0 ， 特 勤 网 络 +1.0";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[670] == 2)
		{
			string[] old_modify_desc62 = GlobalScript.inst.old_modify_desc;
			int num66 = 6;
			old_modify_desc62[num66] += "|<color=red>东 南 西 北 中 ， 党 领 导 一 切 ：</color>  党 内 团 结 度 +1.0 ， 特 勤 网 络 +0.2 ， 腐 败 +0.2 ； 每10 点 行 政 投 资 ： 党 内 团 结 度 +0.2 ， 人 民 支 持 度 +0.1 ， 思 想 自 由 化 -0.1 ； 行 政 投 资 不 低 于40 时 ， 特 勤 网 络 +1.0 ， 腐 败 -0.2";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[7] == 4)
		{
			GlobalScript.inst.old_modify_texts[17] = " 禁 运 美 国";
			GlobalScript.inst.old_modify_desc[17] = " 我 们 将 增 加 与 美 国 影 响 差 额10% 的 特 工 网 络| 获 得 相 当 于 与 美 国 影 响 差 额5% 的 预 算| 美 国 将 减 少 与 中 国 影 响 差 额10% 的 影 响 力| 失 去 相 当 于 与 中 国 影 响 差 额5% 的 收 入";
		}
		else
		{
			GlobalScript.inst.old_modify_texts[17] = " 美 国 禁 运";
			GlobalScript.inst.old_modify_desc[17] = " 我 们 将 减 少 与 美 国 关 系 差 额10% 的 收 入| 失 去 相 当 于 与 美 国 关 系 差 额5% 的 特 工 网 络";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[8] == 4)
		{
			GlobalScript.inst.old_modify_texts[16] = " 禁 运 苏 联";
			GlobalScript.inst.old_modify_desc[16] = " 我 们 将 增 加 与 苏 联 影 响 差 额10% 的 特 工 网 络| 获 得 相 当 于 与 苏 联 影 响 差 额5% 的 预 算| 苏 联 将 减 少 与 中 国 影 响 差 额10% 的 影 响 力| 失 去 相 当 于 与 中 国 影 响 差 额5% 的 收 入";
		}
		else
		{
			GlobalScript.inst.old_modify_texts[16] = " 苏 联 禁 运";
			GlobalScript.inst.old_modify_desc[16] = " 我 们 将 减 少 与 苏 联 关 系 差 额10% 的 收 入| 失 去 相 当 于 与 苏 联 关 系 差 额5% 的 特 工 网 络";
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
	}

	private void LoadYugoSave(int num)
	{
		if (File.Exists($"NewData{Path.DirectorySeparatorChar}{num}.save"))
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			using FileStream serializationStream = File.OpenRead($"NewData{Path.DirectorySeparatorChar}{num}.save");
			GlobalScript.inst.gameState = binaryFormatter.Deserialize(serializationStream) as GameState;
		}
	}

	private void OnMouseEnter()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (number == 5)
			{
				Opis.text = " 可 激 活 成 就";
			}
			else
			{
				Opis.text = " 不 可 激 活 成 就";
			}
			if (PlayerPrefs.HasKey("data14" + (number + 10)))
			{
				TextMesh opis = Opis;
				opis.text = opis.text + "\n 体 制 ：" + GlobalScript.inst.gameState.doctr[PlayerPrefs.GetInt("data14" + (number + 10))];
				TextMesh opis2 = Opis;
				opis2.text = opis2.text + "\n 日 期 ：" + PlayerPrefs.GetInt("data19" + (number + 10)) + "." + PlayerPrefs.GetInt("data20" + (number + 10)) + "." + PlayerPrefs.GetInt("data21" + (number + 10));
				Opis.text += "\n 难 度 ：";
				if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 0)
				{
					Opis.text += " 牛 棚 小 酌";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 1)
				{
					Opis.text += " 上 山 下 乡";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 2)
				{
					Opis.text += " 斗 私 批 修";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 3)
				{
					Opis.text += " 造 反 有 理";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 4)
				{
					Opis.text += " 浩 荡 文 革";
				}
				Opis.text += "\n 成 就 ：";
				if (from_string(PlayerPrefs.GetString("iron" + (number + 10))))
				{
					Opis.text += "<color=red> 可 解 锁 </color>";
				}
				else
				{
					Opis.text += "<color=red> 不 可 解 锁 </color>";
				}
			}
			else
			{
				Opis.text += "\n 空 档 位";
			}
		}
		else
		{
			if (number == 5)
			{
				Opis.text = "С Достижениями";
			}
			else
			{
				Opis.text = "Без Достижений";
			}
			if (PlayerPrefs.HasKey("data14" + (number + 10)))
			{
				TextMesh opis3 = Opis;
				opis3.text = opis3.text + "\nГосстрой: " + GlobalScript.inst.gameState.doctr[PlayerPrefs.GetInt("data14" + (number + 10))];
				TextMesh opis4 = Opis;
				opis4.text = opis4.text + "\nДата: " + PlayerPrefs.GetInt("data19" + (number + 10)) + "." + PlayerPrefs.GetInt("data20" + (number + 10)) + "." + PlayerPrefs.GetInt("data21" + (number + 10));
				Opis.text += "\nСложность: ";
				if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 0)
				{
					Opis.text += "Песочница";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 1)
				{
					Opis.text += "Лёгкий";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 2)
				{
					Opis.text += "Стандарт";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 3)
				{
					Opis.text += "Тяжёлый";
				}
				else if (PlayerPrefs.GetInt("save_diff" + (number + 10)) == 4)
				{
					Opis.text += "Культурная революция";
				}
				Opis.text += "\nДостижения: ";
				if (from_string(PlayerPrefs.GetString("iron" + (number + 10))))
				{
					Opis.text += "<color=red>Доступны</color>";
				}
				else
				{
					Opis.text += "<color=red>Недоступны</color>";
				}
			}
			else
			{
				Opis.text += "\nПустой слот";
			}
		}
		GetComponent<SpriteRenderer>().sprite = navel;
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = nenavel;
		Opis.text = "";
	}
}
