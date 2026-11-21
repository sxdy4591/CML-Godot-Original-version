using UnityEngine;

public class modify_choose : MonoBehaviour
{
	public GlobalScript global1;

	public Sprite on;

	public Sprite off;

	public int num_this;

	public int num_names;

	public TextMesh Name_1;

	public TextMesh Name_2;

	public TextMesh Name_3;

	public TextMesh Text_1;

	public TextMesh Text_2;

	public TextMesh Text_3;

	private void Awake()
	{
		global1 = GlobalScript.inst;
	}

	private void OnMouseDown()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			GlobalScript.inst.gameState.allcountries[1].spec = num_this;
			if (num_this == 0)
			{
				num_names = 3;
				int num = GlobalScript.inst.gameState.data[23];
				Name_1.text = " 当 前 数 据 相 对 于 1976 年 的 百 分 比";
				Name_3.text = " 世 界 市 场 参 与";
				Name_2.text = " 差 额";
				if (GlobalScript.inst.gameState.modifies[12].active)
				{
					Text_1.text = " 出 口 规 模 :\n" + GlobalScript.inst.gameState.data[23] / 5 + "% (-15%)";
					num = GlobalScript.inst.gameState.data[23] - GlobalScript.inst.gameState.data[23] / 6;
				}
				else
				{
					Text_1.text = " 出 口 规 模 :\n" + GlobalScript.inst.gameState.data[23] / 5 + "%";
				}
				TextMesh text_ = Text_1;
				text_.text = text_.text + "\n 进 口 需 求 :\n" + (GlobalScript.inst.gameState.data[24] / 5).ToString() + "% (" + GlobalScript.inst.gameState.ImportChange(GlobalScript.inst.gameState) / 5 + ")";
				Text_2.text = "相 对 于 1975 年 的 百 分 比 :\n" + (num - GlobalScript.inst.gameState.data[24]) / 5 + "%";
				if (num > GlobalScript.inst.gameState.data[24])
				{
					text_ = Text_2;
					text_.text = text_.text + "\n 贸 易 利 润\n 每 两 周 : +" + (num - GlobalScript.inst.gameState.data[24]) / 100 + "." + Mathf.Abs((num - GlobalScript.inst.gameState.data[24]) / 10 % 10);
					text_ = Text_2;
					text_.text = text_.text + "\n 人 民 支 持 度\n 每 两 周 : +" + (num - GlobalScript.inst.gameState.data[24]) / 150 + "." + Mathf.Abs((num - GlobalScript.inst.gameState.data[24]) / 15 % 10);
				}
				else
				{
					text_ = Text_2;
					text_.text = text_.text + "\n 贸 易 利 润\n 每 两 周 : -" + (num - GlobalScript.inst.gameState.data[24]) / 100 + "." + Mathf.Abs((num - GlobalScript.inst.gameState.data[24]) / 10 % 10);
					text_ = Text_2;
					text_.text = text_.text + "\n 人 民 支 持 度\n 每 两 周 : -" + (num - GlobalScript.inst.gameState.data[24]) / 150 + "." + Mathf.Abs((num - GlobalScript.inst.gameState.data[24]) / 15 % 10);
					text_ = Text_2;
					text_.text = text_.text + "\n 生 活 水 平\n 每 两 周 : -" + (num - GlobalScript.inst.gameState.data[24]) / 200 + "." + Mathf.Abs((num - GlobalScript.inst.gameState.data[24]) / 20 % 10);
				}
				if (GlobalScript.inst.gameState.data[25] <= 10)
				{
					Text_3.text = " 孤 立 主 义";
					text_ = Text_3;
					text_.text = text_.text + "\n 自 由 化 思 潮 ( 每 两 周 ) : -" + (-9 + GlobalScript.inst.gameState.data[25]) / 10 + "." + Mathf.Abs((-9 + GlobalScript.inst.gameState.data[25]) % 10);
					text_ = Text_3;
					text_.text = text_.text + "\n 特 工 网 络 ( 每 两 周 ) : -" + (-9 + GlobalScript.inst.gameState.data[25]) / 10 + "." + Mathf.Abs((-9 + GlobalScript.inst.gameState.data[25]) % 10);
				}
				else if (GlobalScript.inst.gameState.data[25] > 18)
				{
					Text_3.text = " 积 极 参 与 全 球 化";
					text_ = Text_3;
					text_.text = text_.text + "\n 自 由 化 思 潮 ( 每 两 周 ) : +" + (GlobalScript.inst.gameState.data[25] - 18) / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[25] - 18) % 10);
				}
				else
				{
					Text_3.text = " 平 衡 主 义";
				}
			}
			else if (num_this == 1)
			{
				if (GlobalScript.inst.gameState.ChinesePage == 0)
				{
					num_names = 3;
					Name_1.text = " 全 球 影 响";
					Name_2.text = " 苏 联 领 导 人";
					Name_3.text = " 军 备 竞 赛";
					Text_1.text = "\n<color=red> 苏 联 的 世 界 影 响 力 : </color>\n" + GlobalScript.inst.gameState.empires[1].power / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[1].power % 10);
					TextMesh text_2 = Text_1;
					text_2.text = text_2.text + "\n<color=blue> 美 国 的 世 界 影 响 力 : </color>\n" + GlobalScript.inst.gameState.empires[0].power / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[0].power % 10);
					Text_1.text += "\n 影 响 美 苏 在 非 洲 的 争 夺 结 果";
					if (GlobalScript.inst.gameState.empires[1].now_leader == 0)
					{
						Text_2.text = " 列 昂 尼 德 · 勃 列 日 涅 夫";
						Text_2.text += "\n 提 升 苏 联 的 非 洲 干 涉 行 动 花 费\n 若 中 苏 关 系 尚 未 解 冻 :\n 与 美 国 的 关 系 +0.5 ； 凝 聚 力 -0.2";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 1)
					{
						Text_2.text = " 尤 里 · 安 德 罗 波 夫";
						Text_2.text += "\n 若 中 苏 关 系 尚 未 解 冻 :\n 与 美 国 的 关 系 +0.5\n 若 已 恢 复 关 系 :\n 加 强 改 革 派 的 权 力";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 2)
					{
						Text_2.text = " 康 斯 坦 丁 · 契 尔 年 科";
						Text_2.text += "\n 与 苏 联 的 关 系 +0.5\n 若 中 苏 关 系 解 冻 :\n 加 强 温 和 派 的 权 力";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 3)
					{
						Text_2.text = " 弗 拉 基 米 尔 · 谢 尔 比 茨 基";
						Text_2.text += "\n 若 中 苏 关 系 尚 未 解 冻 :\n 与 美 国 的 关 系 +0.5 ； 凝 聚 力 -0.2\n 若 已 恢 复 关 系 :\n 与 苏 联 的 关 系 +0.5";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
					{
						Text_2.text = " 米 哈 伊 尔 · 戈 尔 巴 乔 夫";
						Text_2.text += "\n 减 少 苏 联 的 非 洲 干 涉 行 动 花 费\n 与 苏 联 的 关 系 +0.5 ； 自 由 化 思 潮 +0.5\n 加 强 自 由 派 的 权 力";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 5)
					{
						Text_2.text = " 维 克 托 · 格 里 申";
						Text_2.text += "\n 与 苏 联 的 关 系 +0.5\n 若 中 苏 关 系 解 冻 :\n 加 强 改 革 派 的 权 力";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
					{
						Text_2.text = " 格 里 戈 里 · 罗 曼 诺 夫";
						Text_2.text += "\n 若 中 苏 关 系 尚 未 解 冻 :\n 特 工 网 络 -0.5\n 若 已 恢 复 关 系 :\n 与 苏 联 的 关 系 +0.5 ； 特 工 网 络 +0.5";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 7)
					{
						if (!GlobalScript.inst.gameState.is_gkchp)
						{
							Text_2.text = " 亚 历 山 大 · 雅 科 夫 列 夫";
						}
						else
						{
							Text_2.text = " 国 家 紧 急 状 态 委 员 会";
						}
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
					{
						Text_2.text = " 叶 戈 尔 · 利 加 乔 夫";
						Text_2.text += "\n 减 少 苏 联 的 非 洲 干 涉 行 动 花 费\n 与 苏 联 的 关 系 +0.5 ； 自 由 化 思 潮 +0.5";
					}
					if (GlobalScript.inst.gameState.allcountries[1].okb)
					{
						int num2 = GlobalScript.inst.gameState.empires[1].power;
						int num3 = GlobalScript.inst.gameState.empires[0].power;
						for (int i = 0; i < GlobalScript.inst.gameState.ingamewars.Length; i++)
						{
							if (GlobalScript.inst.gameState.ingamewars[i].is_going)
							{
								num2 -= num2 / 9;
								num3 -= num3 / 9;
							}
						}
						if (GlobalScript.inst.gameState.data[69] > 7)
						{
							num3 += GlobalScript.inst.gameState.data[69] / 7;
						}
						if (GlobalScript.inst.gameState.empires[1].now_leader == 0)
						{
							num2 += 20;
						}
						Text_3.text = "<color=red> 与 苏 联 的 力 量 对 比 : </color>" + (GlobalScript.inst.gameState.data[22] - num2) / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num2) % 10);
						if (GlobalScript.inst.gameState.data[22] > num2)
						{
							Text_3.text += "\n 非 洲 盟 国 政 权 稳 定 度: +2.5";
							if (GlobalScript.inst.gameState.allcountries[1].okb)
							{
								Text_3.text += "\n 盟 国 政 权 稳 定 度: +1.0";
							}
						}
						else if (GlobalScript.inst.gameState.data[22] < num2 && GlobalScript.inst.gameState.influencePRC > 0)
						{
							text_2 = Text_3;
							text_2.text = text_2.text + "\n 盟 国 政 权 稳 定 度: -" + (GlobalScript.inst.gameState.data[22] - num2) / 20 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num2) / 20 % 10);
						}
						text_2 = Text_3;
						text_2.text = text_2.text + "\n<color=blue> 与 美 国 的 力 量 对 比 : </color>" + (GlobalScript.inst.gameState.data[22] - num3) / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num3) % 10);
						if (GlobalScript.inst.gameState.data[22] > num3)
						{
							Text_3.text += "\n 非 洲 盟 国 政 权 稳 定 度: +2.5";
							if (GlobalScript.inst.gameState.allcountries[1].okb)
							{
								Text_3.text += "\n 盟 国 政 权 稳 定 度: +1.0";
							}
						}
						else if (GlobalScript.inst.gameState.data[22] < num3 && GlobalScript.inst.gameState.influencePRC > 0)
						{
							text_2 = Text_3;
							text_2.text = text_2.text + "\n 盟 国 政 权 稳 定 度: -" + (GlobalScript.inst.gameState.data[22] - num3) / 20 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num3) / 20 % 10);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[15].cw)
					{
						Text_3.text = "<color=red>不 结 盟 运 动 成 员 国</color>";
						Text_3.text += "\n 与 苏 联 的 关 系 ( 每 两 周 ) : +0.5 ( 至 多 70 )";
						Text_3.text += "\n 与 美 国 的 关 系 ( 每 两 周 ) : +0.5 ( 至 多 70 )";
						Text_3.text += "\n 预 算 支 出 ( 每 两 周 ) : -0.2";
						if (GlobalScript.inst.gameState.data[6] > 600)
						{
							Text_3.text += "\n 国 际 威 望 ( 每 两 周 ) : -0.2";
						}
						else if (GlobalScript.inst.gameState.data[6] < 400)
						{
							Text_3.text += "\n 国 际 威 望 ( 每 两 周 ) : +0.2";
						}
					}
					else
					{
						Text_3.text = " 我 们 不 参 与 军 备 竞 赛";
					}
				}
				else if (GlobalScript.inst.gameState.ChinesePage == 1)
				{
					num_names = 1;
					Name_1.text = " 苏 美 资 金";
					if (GlobalScript.inst.gameState.science[22] && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power)
					{
						Text_1.text = "\n<color=red> 苏 联 的 储 备 资 金 : </color>\n" + GlobalScript.inst.gameState.empires[1].money / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[1].money % 10);
						TextMesh text_3 = Text_1;
						text_3.text = text_3.text + "\n<color=blue> 美 国 的 储 备 资 金 : </color>\n" + GlobalScript.inst.gameState.empires[0].money / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[0].money % 10);
					}
					else
					{
						Text_1.text = " 我 们 的 特 工 部 门 还 无 法 获 取 这 些 信 息";
					}
				}
			}
			else if (num_this == 5)
			{
				num_names = 3;
				Name_1.text = " 世 界 观 瞻";
				Name_2.text = " 特 殊 影 响";
				Name_3.text = " 人 口";
				Text_1.text = " \n现 状:";
				TextMesh text_4;
				if (GlobalScript.inst.gameState.data[31] > 700)
				{
					text_4 = Text_1;
					text_4.text = text_4.text + "\n 完 全 的 统 一\n(" + GlobalScript.inst.gameState.data[31] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[31] % 10) + "/100)";
					Text_2.text = " 自 由 化 思 潮 ( 每 两 周 ) : -" + (GlobalScript.inst.gameState.data[31] - 500) / 100 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
					text_4 = Text_2;
					text_4.text = text_4.text + "\n 党 内 团 结 度 ( 每 两 周 ) : +" + (GlobalScript.inst.gameState.data[31] - 500) / 100 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
					text_4 = Text_2;
					text_4.text = text_4.text + "\n 特 工 网 络 ( 每 两 周 ) : +" + (GlobalScript.inst.gameState.data[31] - 500) / 1000 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
					Text_2.text += "\n 国 际 威 望 : +0.5\n( 如 果 低 于 50.0 )";
				}
				else if (GlobalScript.inst.gameState.data[31] >= 400 && GlobalScript.inst.gameState.data[31] <= 700)
				{
					text_4 = Text_1;
					text_4.text = text_4.text + "\n 多 元 一 体 理 念\n(" + GlobalScript.inst.gameState.data[31] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[31] % 10) + "/100)";
					Text_2.text = "无".ToString();
				}
				else
				{
					text_4 = Text_1;
					text_4.text = text_4.text + "\n 多 元 文 化 主 义\n(" + GlobalScript.inst.gameState.data[31] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[31] % 10) + "/100)";
					Text_2.text = " 自 由 化 思 潮 ( 每 两 周 ) : +" + (500 - GlobalScript.inst.gameState.data[31]) / 100 / 10 + "." + Mathf.Abs((500 - GlobalScript.inst.gameState.data[31]) / 100 % 10);
					text_4 = Text_2;
					text_4.text = text_4.text + "\n 党 内 团 结 度 ( 每 两 周 ) : +" + (500 - GlobalScript.inst.gameState.data[31]) / 100 / 10 + "." + Mathf.Abs((500 - GlobalScript.inst.gameState.data[31]) / 100 % 10);
					text_4 = Text_2;
					text_4.text = text_4.text + "\n 特 工 网 络 ( 每 两 周 ) : -" + (GlobalScript.inst.gameState.data[31] - 500) / 1000 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
					text_4 = Text_2;
					text_4.text = text_4.text + "\n 两 极 大 国 关 系 ( 每 两 周 ) : +" + (500 - GlobalScript.inst.gameState.data[31]) / 100 / 10 + "." + Mathf.Abs((500 - GlobalScript.inst.gameState.data[31]) / 100 % 10);
				}
				text_4 = Text_1;
				text_4.text = text_4.text + "\n\n 国 家 凝 聚 力 :\n(" + GlobalScript.inst.gameState.data[57] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[57] % 10) + "/100)";
				Text_3.text = GlobalScript.inst.gameState.data[34] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[34]) % 10 + "  百 万 (" + (((GlobalScript.inst.gameState.data_old[34] < 0) ? "-" : "+") + Mathf.Abs(GlobalScript.inst.gameState.data_old[34] / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.data_old[34] % 10) + ")";
				int[] array = new int[5];
				if (GlobalScript.inst.gameState.data[16] == 11)
				{
					array[0] += GlobalScript.inst.gameState.data[34] / 5000;
				}
				else if (GlobalScript.inst.gameState.data[16] == 10)
				{
					array[0] += GlobalScript.inst.gameState.data[34] / 5000;
				}
				else if (GlobalScript.inst.gameState.data[16] == 13)
				{
					array[3] += Mathf.RoundToInt((float)(GlobalScript.inst.gameState.data[34] - 9037) / 3000f + 1f);
				}
				else if (GlobalScript.inst.gameState.data[16] == 14 && !GlobalScript.inst.gameState.modifies[13].active)
				{
					array[1] -= GlobalScript.inst.gameState.data[34] / 4000;
					array[3] += Mathf.RoundToInt((float)(GlobalScript.inst.gameState.data[34] - 9037) / 2000f + 1f);
				}
				else if (GlobalScript.inst.gameState.data[16] == 15 && !GlobalScript.inst.gameState.modifies[13].active)
				{
					array[1] -= GlobalScript.inst.gameState.data[34] / 4000;
					array[3] += Mathf.RoundToInt((float)(GlobalScript.inst.gameState.data[34] - 9037) / 1000f + 1f);
				}
				if ((GlobalScript.inst.gameState.data[34] - 9307) / 200 > 0)
				{
					array[2] -= (GlobalScript.inst.gameState.data[34] - 9307) / 200;
				}
				if (GlobalScript.inst.gameState.data[51] == 30)
				{
					if (GlobalScript.inst.gameState.data[34] - 9307 > 99)
					{
						array[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 100;
						array[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 100;
					}
				}
				else if (GlobalScript.inst.gameState.data[51] == 31)
				{
					if (GlobalScript.inst.gameState.data[34] - 9307 > 199)
					{
						array[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 200;
						array[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 200;
					}
				}
				else if (GlobalScript.inst.gameState.data[51] == 32)
				{
					if (GlobalScript.inst.gameState.data[34] - 9307 > 299)
					{
						array[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 300;
						array[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 300;
					}
				}
				else if (GlobalScript.inst.gameState.data[51] == 33 && GlobalScript.inst.gameState.data[34] - 9307 > 149)
				{
					if (GlobalScript.inst.gameState.data[5] < 500)
					{
						array[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 150;
						array[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 250;
					}
					else if (GlobalScript.inst.gameState.data[5] < 700)
					{
						array[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 150;
						array[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 300;
					}
					else
					{
						array[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 500;
						array[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 500;
					}
				}
				text_4 = Text_3;
				text_4.text = text_4.text + "\n 工 业 : " + (((array[0] < 0) ? "-" : "+") + Mathf.Abs(array[0] / 10)).ToString() + "." + Mathf.Abs(array[0] % 10);
				text_4 = Text_3;
				text_4.text = text_4.text + " ； 预 算 : " + (((array[3] < 0) ? "-" : "+") + Mathf.Abs(array[3] / 10)).ToString() + "." + Mathf.Abs(array[3] % 10);
				text_4 = Text_3;
				text_4.text = text_4.text + "\n 特 工 网 络 : " + (((array[2] < 0) ? "-" : "+") + Mathf.Abs(array[2] / 10)).ToString() + "." + Mathf.Abs(array[2] % 10);
				text_4 = Text_3;
				text_4.text = text_4.text + " ； 军 事 实 力 : " + (((array[4] < 0) ? "-" : "+") + Mathf.Abs(array[4] / 10)).ToString() + "." + Mathf.Abs(array[4] % 10);
				text_4 = Text_3;
				text_4.text = text_4.text + "\n 人 民 支 持 度 : " + (((array[1] < 0) ? "-" : "+") + Mathf.Abs(array[1] / 10)).ToString() + "." + Mathf.Abs(array[1] % 10);
			}
			else if (num_this == 4)
			{
				num_names = 3;
				Name_1.text = " 伊 朗";
				Name_2.text = " 阿 富 汗";
				Name_3.text = " 美 国 总 统";
				if (GlobalScript.inst.gameState.allcountries[84].parts[5])
				{
					Text_1.text = " 大 土 耳 其 的 一 部 分";
				}
				else if (GlobalScript.inst.gameState.allcountries[8].puppetOf >= 0)
				{
					Text_1.text = " 土 耳 其 的 傀 儡 国";
				}
				else if (!GlobalScript.inst.gameState.event_done[58] && GlobalScript.inst.gameState.event_done[42])
				{
					Text_1.text = " 君 主 主 义 者 力 量 :\n" + GlobalScript.inst.gameState.data[43] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[43] % 10);
					Text_1.text = Text_1.text + "\n 泛 左 翼 力 量 :\n" + GlobalScript.inst.gameState.data[42] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[42] % 10);
					Text_1 = Text_1;
					Text_1.text = Text_1.text + "\n 自 由 派 力 量 :\n" + GlobalScript.inst.gameState.data[44] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[44] % 10);
				}
				else if (GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 13)
				{
					Text_1.text = " 沙 阿 政 权 依 旧 稳 固";
				}
				else if (GlobalScript.inst.gameState.event_done[58] && GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 8 && !GlobalScript.inst.gameState.event_done[446])
				{
					Text_1.text = " 联 合 左 翼 取 得 了 胜 利 并 和 霍 梅 尼 妥 协 ， 共 同 执 政";
				}
				else if (GlobalScript.inst.gameState.ingamewars[33].is_going)
				{
					Text_1.text = " 伊 朗 正 陷 入 大 规 模 的 内 战 ！";
				}
				else if (GlobalScript.inst.gameState.event_done[446] && (!GlobalScript.inst.gameState.event_done[447] || GlobalScript.inst.gameState.resultOfEvents[447] != 0) && GlobalScript.inst.gameState.allcountries[8].Gosstroy != 1 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 13 && GlobalScript.inst.gameState.allcountries[8].SubGosstroy != 3 && GlobalScript.inst.gameState.allcountries[8].Gosstroy != 3)
				{
					Text_1.text = " 霍 梅 尼 正 在 逐 步 窃 取 伊 朗 革 命 果 实";
				}
				else if (GlobalScript.inst.gameState.event_done[447] && GlobalScript.inst.gameState.resultOfEvents[447] == 0 && !GlobalScript.inst.gameState.event_done[448])
				{
					Text_1.text = " 小 型 内 战 后 的 伊 朗 安 危 未 定";
				}
				else if (GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 3 && GlobalScript.inst.gameState.allcountries[8].proprc)
				{
					Text_1.text = " 伊 朗 已 建 成 稳 定 的 民 主 社 会 主 义 亲 中 政 权";
				}
				else if (GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 3)
				{
					Text_1.text = " 伊 朗 已 建 成 稳 定 的 民 主 社 会 主 义 政 权";
				}
				else if ((GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 6 || GlobalScript.inst.gameState.allcountries[8].Gosstroy == 3) && GlobalScript.inst.gameState.allcountries[8].proprc)
				{
					Text_1.text = " 伊 朗 已 建 成 稳 定 的 自 由 主 义 亲 中 政 权";
				}
				else if (GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 6 || GlobalScript.inst.gameState.allcountries[8].Gosstroy == 3)
				{
					Text_1.text = " 伊 朗 已 建 成 稳 定 的 自 由 主 义 政 权";
				}
				else if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[8].proprc)
				{
					Text_1.text = " 伊 朗 已 建 成 稳 定 的 亲 中 社 会 主 义 政 权";
				}
				else if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 1)
				{
					Text_1.text = " 伊 朗 已 建 成 稳 定 的 社 会 主 义 政 权";
				}
				else if (GlobalScript.inst.gameState.event_done[448] && GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 9)
				{
					Text_1.text = " 霍 梅 尼 已 大 权 在 握 … …";
				}
				else
				{
					Text_1.text = " 伊 朗 情 况 已 经 稳 定";
				}
				Text_2.text = " 毛 主 义 者 力 量 :\n" + GlobalScript.inst.gameState.data[46] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[46] % 10);
				TextMesh text_5 = Text_2;
				text_5.text = text_5.text + "\n 人 民 派 力 量 :\n" + GlobalScript.inst.gameState.data[48] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[48] % 10);
				text_5 = Text_2;
				text_5.text = text_5.text + "\n 旗 帜 派 力 量 :\n" + GlobalScript.inst.gameState.data[49] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[49] % 10);
				if (GlobalScript.inst.gameState.data[21] < 1977)
				{
					Text_3.text = " 杰 拉 尔 德 · 福 特";
				}
				else if (GlobalScript.inst.gameState.data[21] < 1981)
				{
					Text_3.text = " 吉 米 · 卡 特";
				}
				else if (GlobalScript.inst.gameState.empires[0].now_leader == 1)
				{
					Text_3.text = " 吉 米 · 卡 特";
				}
				else if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
				{
					Text_3.text = " 罗 纳 德 · 里 根";
				}
				else if (GlobalScript.inst.gameState.empires[0].now_leader == 2)
				{
					Text_3.text = " 乔 治 · 布 什";
				}
				else if (GlobalScript.inst.gameState.empires[0].now_leader == 3)
				{
					Text_3.text = " 沃 尔 特 · 蒙 代 尔";
				}
				if (GlobalScript.inst.gameState.data[21] >= 1981 && GlobalScript.inst.gameState.empires[0].now_leader <= 0)
				{
					Text_3.text += "\n 美 国 的 干 涉 行 动 花 费 : +0.5\n 自 由 化 思 潮 : +0.5";
				}
				else if (GlobalScript.inst.gameState.empires[0].now_leader == 1 || (GlobalScript.inst.gameState.data[21] >= 1977 && GlobalScript.inst.gameState.data[21] < 1981))
				{
					Text_3.text += "\n 与 美 国 的 关 系 : +1.0";
				}
				else if (GlobalScript.inst.gameState.empires[0].now_leader == 2)
				{
					Text_3.text += "\n 美 国 的 干 涉 行 动 花 费 : +0.5\n 与 美 国 的 关 系 : +0.5\n( 若 我 们 未 处 于 非 美 国 的 军 事 联 盟 )";
				}
				else if (GlobalScript.inst.gameState.empires[0].now_leader == 3)
				{
					Text_3.text += "\n 西 欧 毛 派 行 动 效 果 x1.5\n 每 两 月 偿 还 一 次 贷 款\n 与 美 国 的 关 系 : +1.0";
				}
			}
			else if (num_this == 2)
			{
				GlobalScript.inst.gameState.allcountries[1].spec = 2;
				num_names = 3;
				Name_1.text = " 中 华 本 部 ";
				Name_2.text = " 台 湾 地 区";
				Name_3.text = " 藏 南 地 区";
				if (GlobalScript.inst.gameState.data[67] <= 0)
				{
					Text_1.text = " 西 藏 是 中 国 领 土 不 可 分 割 的 一 部 分\n";
				}
				else if (GlobalScript.inst.gameState.data[67] == 1)
				{
					Text_1.text = " 西 藏 共 和 国 - 独 立 主 权\n";
				}
				else if (GlobalScript.inst.gameState.data[67] == 2)
				{
					Text_1.text = " 西 藏 共 和 国 - 独 立 主 权 ； 神 权 政 治\n";
				}
				if (GlobalScript.inst.gameState.data[66] <= 0)
				{
					Text_1.text += " 新 疆 是 中 国 领 土 不 可 分 割 的 一 部 分\n";
				}
				else if (GlobalScript.inst.gameState.data[66] == 1)
				{
					Text_1.text += " 新 疆 - 苏 联 傀 儡\n";
				}
				else if (GlobalScript.inst.gameState.data[66] == 2)
				{
					Text_1.text += " 维 吾 尔 斯 坦 伊 斯 兰 共 和 国 - 独 立 主 权\n";
				}
				if (GlobalScript.inst.gameState.data[65] <= 0)
				{
					Text_1.text += " 港 澳 地 区 被 外 国 势 力 控 制\n";
				}
				else if (GlobalScript.inst.gameState.data[65] == 1)
				{
					Text_1.text += " 港 澳 是 中 国 的 特 别 行 政 区\n";
				}
				else if (GlobalScript.inst.gameState.data[65] == 2)
				{
					Text_1.text += " 港 澳 是 中 国 领 土 不 可 分 割 的 一 部 分\n";
				}
				if (GlobalScript.inst.gameState.allcountries[7].parts[1] || GlobalScript.inst.gameState.allcountries[7].parts[2])
				{
					Text_1.text += " 蒙 古 是 苏 联 的 加 盟 共 和 国\n";
				}
				else if (GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19] && GlobalScript.inst.gameState.allcountries[9].puppetOf == 1 && !GlobalScript.inst.gameState.IndOpp && !GlobalScript.inst.gameState.is_gkchp)
				{
					Text_1.text += " 蒙 古 是 亲 华 的 “ 独 立 主 权 ” 国 家\n";
				}
				else if (!GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19] && !GlobalScript.inst.gameState.IndOpp && !GlobalScript.inst.gameState.is_gkchp)
				{
					Text_1.text += " 蒙 古 是 亲 苏 的 独 立 主 权 国 家\n";
				}
				else if (GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19] && !GlobalScript.inst.gameState.IndOpp && !GlobalScript.inst.gameState.is_gkchp)
				{
					Text_1.text += " 蒙 古 是 亲 华 的 独 立 主 权 国 家\n";
				}
				else
				{
					Text_1.text += " 蒙 古 是 中 国 领 土 不 可 分 割 的 一 部 分\n";
				}
				if (GlobalScript.inst.gameState.data[64] == 2 || GlobalScript.inst.gameState.completedDecisions[6] || GlobalScript.inst.gameState.completedDecisions[7] || GlobalScript.inst.gameState.event_done[461])
				{
					Text_2.text = " 台 湾 省 -  中 国 省 级 特 别 行 政 区\n";
				}
				else if (GlobalScript.inst.gameState.data[64] <= 0)
				{
					Text_2.text = " 中 华 民 国 -  国 民 党 统 治\n( 威 权 主 义 ， 少 数 国 家 承 认)\n";
				}
				else if (GlobalScript.inst.gameState.data[64] == 1)
				{
					Text_2.text = " 台 湾 国 -  独 立 主 权\n( 自 由 主 义 ， 国 际 广 泛 承 认)\n";
				}
				if (GlobalScript.inst.gameState.data[63] <= 0 && !GlobalScript.inst.gameState.event_done[461])
				{
					Text_2.text += " 台 海 岛 屿\n 在 国 民 党 控 制 下\n";
				}
				else if (GlobalScript.inst.gameState.data[63] == 1 || GlobalScript.inst.gameState.event_done[461])
				{
					Text_2.text += " 台 海 岛 屿\n 在 解 放 军 控 制 下\n";
				}
				if (GlobalScript.inst.gameState.data[62] <= 0)
				{
					Text_3.text = " 被 印 度 实 际 控 制 ，并 未 被 我 方 承 认\n";
				}
				else if (GlobalScript.inst.gameState.data[62] == 1)
				{
					Text_3.text = " 被 印 度 实 际 控 制 ，我 方 承 认 其 主 权\n";
				}
				else if (GlobalScript.inst.gameState.data[62] == 2 || GlobalScript.inst.gameState.data[62] == 3)
				{
					Text_3.text = " 我 们 已 重 建 实 际 控 制 并 确 认 当 地 主 权\n";
				}
			}
			else if (num_this == 6)
			{
				if (GlobalScript.inst.gameState.ChinesePage == 0)
				{
					num_names = 1;
					Name_1.text = " 中 国 人 民 的 老 朋 友";
					if (GlobalScript.inst.gameState.allcountries[1].econ)
					{
						Text_1.text = "<color=red> 国 家 -  合 作 程 度 -  革 命 立 场 是 否 坚 定 -  稳 定 度</color>";
						for (int j = 0; j < GlobalScript.inst.gameState.allcountries.Length; j++)
						{
							if (j == 19 || j == 52 || j == 48 || j == 50 || j == 96 || j == 49 || j == 47 || j == 46 || j == 11 || j == 22 || j == 23 || j == 34 || j == 33 || j == 32 || j == 97 || j == 43 || j == 31 || j == 12 || j == 8)
							{
								if (GlobalScript.inst.gameState.allcountries[j].econ && GlobalScript.inst.gameState.allcountries[j].okb)
								{
									TextMesh text_6 = Text_1;
									text_6.text = text_6.text + "\n" + GlobalScript.inst.gameState.allcountries[j].name + " - 经 济 军 事 一 体 化 - " + (GlobalScript.inst.gameState.allcountries[j].proprc ? " 是 - " : " 否 - ") + GlobalScript.inst.gameState.allcountries[j].soc_stab / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.allcountries[j].soc_stab % 10);
								}
								else if (GlobalScript.inst.gameState.allcountries[j].econ)
								{
									TextMesh text_7 = Text_1;
									text_7.text = text_7.text + "\n" + GlobalScript.inst.gameState.allcountries[j].name + " - 经 济 一 体 化 - " + (GlobalScript.inst.gameState.allcountries[j].proprc ? " 是 - " : " 否 - ") + GlobalScript.inst.gameState.allcountries[j].soc_stab / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.allcountries[j].soc_stab % 10);
								}
								else if (GlobalScript.inst.gameState.allcountries[j].okb)
								{
									TextMesh text_8 = Text_1;
									text_8.text = text_8.text + "\n" + GlobalScript.inst.gameState.allcountries[j].name + " - 军 事 一 体 化 - " + (GlobalScript.inst.gameState.allcountries[j].proprc ? " 是 - " : " 否 - ") + GlobalScript.inst.gameState.allcountries[j].soc_stab / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.allcountries[j].soc_stab % 10);
								}
							}
						}
					}
					else
					{
						Text_1.text = " 我 们 不 属 于 任 何 联 盟";
					}
				}
				else if (GlobalScript.inst.gameState.ChinesePage == 1)
				{
					num_names = 1;
					Name_1.text = " 非 洲 联 盟";
					if (GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
					{
						Text_1.text = "<color=red> 成 员 国 家 </color>";
						for (int k = 0; k < GlobalScript.inst.gameState.allcountries.Length; k++)
						{
							if (((k > 53 && k < 69) || (k > 105 && k < 109) || (k > 111 && k < 134) || k == 41 || k == 42 || k == 52) && k != 55 && k != 54 && k != 18 && k != 128 && GlobalScript.inst.gameState.allcountries[k].econ && GlobalScript.inst.gameState.allcountries[k].okb)
							{
								TextMesh text_9 = Text_1;
								text_9.text = string.Concat(new string[3]
								{
									text_9.text,
									"\n",
									GlobalScript.inst.gameState.allcountries[k].name
								});
							}
						}
						if (GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.allcountries[99].econ && GlobalScript.inst.gameState.allcountries[99].okb)
						{
							TextMesh text_10 = Text_1;
							text_10.text = string.Concat(new string[3]
							{
								text_10.text,
								"\n",
								GlobalScript.inst.gameState.allcountries[99].name
							});
						}
						if (GlobalScript.inst.gameState.allcountries[100].parts[0] && GlobalScript.inst.gameState.allcountries[100].econ && GlobalScript.inst.gameState.allcountries[100].okb)
						{
							TextMesh text_11 = Text_1;
							text_11.text = string.Concat(new string[3]
							{
								text_11.text,
								"\n",
								GlobalScript.inst.gameState.allcountries[100].name
							});
						}
					}
					else
					{
						Text_1.text = " 非 洲 联 盟 尚 未 建 立";
					}
				}
			}
		}
		else if (num_this == 0)
		{
			num_names = 3;
			int num4 = GlobalScript.inst.gameState.data[23];
			Name_1.text = "Текущие данные в % от 1976";
			Name_3.text = "Участие в мировом рынке";
			Name_2.text = "Разница";
			if (GlobalScript.inst.gameState.modifies[12].active)
			{
				Text_1.text = "Наш экспорт:\n" + GlobalScript.inst.gameState.data[23] / 5 + "% (-15%)";
				num4 = GlobalScript.inst.gameState.data[23] - GlobalScript.inst.gameState.data[23] / 6;
			}
			else
			{
				Text_1.text = "Наш экспорт:\n" + GlobalScript.inst.gameState.data[23] / 5 + "%";
			}
			TextMesh text_12 = Text_1;
			text_12.text = text_12.text + "\nНужда в импорте:\n" + GlobalScript.inst.gameState.data[24].ToString() + "% (" + GlobalScript.inst.gameState.ImportChange(GlobalScript.inst.gameState) + ")";
			Text_2.text = "% от 1975:\n" + (num4 - GlobalScript.inst.gameState.data[24]) + "%";
			if (num4 > GlobalScript.inst.gameState.data[24])
			{
				text_12 = Text_2;
				text_12.text = text_12.text + "\nВыручка от сделок\n(в 2 недели): +" + (num4 - GlobalScript.inst.gameState.data[24]) / 20 + "." + Mathf.Abs((num4 - GlobalScript.inst.gameState.data[24]) / 2 % 10);
				text_12 = Text_2;
				text_12.text = text_12.text + "\nУдовлетворение народа\n(в 2 недели): +" + (num4 - GlobalScript.inst.gameState.data[24]) / 30 + "." + Mathf.Abs((num4 - GlobalScript.inst.gameState.data[24]) / 3 % 10);
			}
			else
			{
				text_12 = Text_2;
				text_12.text = text_12.text + "\nВыручка от сделок\n(в 2 недели): -" + (num4 - GlobalScript.inst.gameState.data[24]) / 20 + "." + Mathf.Abs((num4 - GlobalScript.inst.gameState.data[24]) / 2 % 10);
				text_12 = Text_2;
				text_12.text = text_12.text + "\nУдовлетворение народа\n(в 2 недели): -" + (num4 - GlobalScript.inst.gameState.data[24]) / 30 + "." + Mathf.Abs((num4 - GlobalScript.inst.gameState.data[24]) / 3 % 10);
				text_12 = Text_2;
				text_12.text = text_12.text + "\nУровень жизни\n(в 2 недели): -" + (num4 - GlobalScript.inst.gameState.data[24]) / 40 + "." + Mathf.Abs((num4 - GlobalScript.inst.gameState.data[24]) / 4 % 10);
			}
			if (GlobalScript.inst.gameState.data[25] <= 4)
			{
				Text_3.text = "Изоляция";
				text_12 = Text_3;
				text_12.text = text_12.text + "\nЛиберализация (в 2 недели): -" + (-5 + GlobalScript.inst.gameState.data[25]) / 10 + "." + Mathf.Abs((-5 + GlobalScript.inst.gameState.data[25]) % 10);
				text_12 = Text_3;
				text_12.text = text_12.text + "\nАгенты (в 2 недели): -" + (-5 + GlobalScript.inst.gameState.data[25]) / 10 + "." + Mathf.Abs((-5 + GlobalScript.inst.gameState.data[25]) % 10);
			}
			else if (GlobalScript.inst.gameState.data[25] > 12)
			{
				Text_3.text = "Глобализация";
				text_12 = Text_3;
				text_12.text = text_12.text + "\nЛиберализация (в 2 недели): +" + (GlobalScript.inst.gameState.data[25] - 12) / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[25] - 12) % 10);
				text_12 = Text_3;
				text_12.text = text_12.text + "\nАгенты (в 2 недели): -" + (GlobalScript.inst.gameState.data[25] - 12) / 20 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[25] - 12) % 20);
			}
			else
			{
				Text_3.text = "Баланс";
			}
		}
		else if (num_this == 1)
		{
			num_names = 3;
			Name_1.text = "Мировое влияние";
			Name_2.text = "Лидер СССР";
			Name_3.text = "Гонка вооружений";
			Text_1.text = "\n<color=red>Мировое влияние СССР:</color>\n" + GlobalScript.inst.gameState.empires[1].power / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[1].power % 10);
			TextMesh text_13 = Text_1;
			text_13.text = text_13.text + "\n<color=blue>Мировое влияние США:</color>\n" + GlobalScript.inst.gameState.empires[0].power / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.empires[0].power % 10);
			Text_1.text += "\nЭто влияет на силу США и СССР в Африке.";
			if (GlobalScript.inst.gameState.empires[1].now_leader == 0)
			{
				Text_2.text = "Леонид Брежнев";
				Text_2.text += "\nУвеличивает советские траты на Африку;\nЕсли мы не восстановили отношения:\nОтношения с США +0.5\nи -0.2 Единства;";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 1)
			{
				Text_2.text = "Юрий Андропов";
				Text_2.text += "\nЕсли мы не восстановили отношения:\nОтношения с США +0.5;\nИначе:\n+ к силе политиков-реформистов";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 2)
			{
				Text_2.text = "Константин Черненко";
				Text_2.text += "\nОтношения с СССР +0.5;\nЕсли мы восстановили отношения:\n+ к силе политиков-умеренных";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 3)
			{
				Text_2.text = "Владимир Щербицкий";
				Text_2.text += "\nЕсли мы не восстановили отношения:\nОтношения с США +0.5\nи -0.2 Единства;\nИначе:\nОтношения с СССР +0.5";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
			{
				Text_2.text = "Михаил Горбачёв";
				Text_2.text += "\nСокращает советские траты на Африку;\nОтношения с СССР +0.5\nи +0.5 Либерализация умов\nи + к силе политиков-либералов;";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 5)
			{
				Text_2.text = "Виктор Гришин";
				Text_2.text += "\nОтношения с СССР +0.5;\nЕсли мы восстановили отношения:\n+ к силе политиков-реформистов";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
			{
				Text_2.text = "Григорий Романов";
				Text_2.text += "\nЕсли мы не восстановили отношения:\n-0.5 Агентов;\nИначе:\nОтношения с СССР +0.5 и +0.5 агентов";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 7)
			{
				Text_2.text = "Александр Яковлев";
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
			{
				Text_2.text = "Егор Лигачев";
				Text_2.text += "\nСокращает советские траты на Африку;\nОтношения с СССР +0.5\nи +0.5 Либерализация умов;";
			}
			if (GlobalScript.inst.gameState.allcountries[1].okb)
			{
				int num5 = GlobalScript.inst.gameState.empires[1].power;
				int num6 = GlobalScript.inst.gameState.empires[0].power;
				for (int l = 0; l < GlobalScript.inst.gameState.ingamewars.Length; l++)
				{
					if (GlobalScript.inst.gameState.ingamewars[l].is_going)
					{
						num5 -= num5 / 9;
						num6 -= num6 / 9;
					}
				}
				if (GlobalScript.inst.gameState.data[69] > 7)
				{
					num6 += GlobalScript.inst.gameState.data[69] / 7;
				}
				if (GlobalScript.inst.gameState.empires[1].now_leader == 0)
				{
					num5 += 20;
				}
				Text_3.text = "<color=red>Разница в силе с СССР: </color>" + (GlobalScript.inst.gameState.data[22] - num5) / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num5) % 10);
				if (GlobalScript.inst.gameState.data[22] > num5)
				{
					Text_3.text += "\nСтабильность в наших африканских странах +2.5";
					if (GlobalScript.inst.gameState.allcountries[1].okb)
					{
						Text_3.text += "\nСтабильность режимов в нашем альянсе: +1.0";
					}
				}
				else if (GlobalScript.inst.gameState.data[22] <= num5 && GlobalScript.inst.gameState.influencePRC > 0)
				{
					text_13 = Text_3;
					text_13.text = text_13.text + "\nСтабильность режимов в нашем альянсе: -" + (GlobalScript.inst.gameState.data[22] - num5) / 20 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num5) / 20 % 10);
				}
				text_13 = Text_3;
				text_13.text = text_13.text + "\n<color=blue>Разница в силе с США: </color>" + (GlobalScript.inst.gameState.data[22] - num6) / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num6) % 10);
				if (GlobalScript.inst.gameState.data[22] > num6)
				{
					Text_3.text += "\nСтабильность в наших африканских странах +2.5";
					if (GlobalScript.inst.gameState.allcountries[1].okb)
					{
						Text_3.text += "\nСтабильность режимов в нашем альянсе: +1.0";
					}
				}
				else if (GlobalScript.inst.gameState.data[22] <= num6 && GlobalScript.inst.gameState.influencePRC > 0)
				{
					text_13 = Text_3;
					text_13.text = text_13.text + "\nСтабильность режимов в нашем альянсе: -" + (GlobalScript.inst.gameState.data[22] - num6) / 20 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[22] - num6) / 20 % 10);
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[15].cw)
			{
				Text_3.text = "<color=red>Состоим в Движении неприсоединения</color>";
				Text_3.text += "\nОтношения с СССР (2 недели): +0.5 (до 70)";
				Text_3.text += "\nОтношения с США (2 недели): +0.5 (до 70)";
				Text_3.text += "\nДеньги из Бюджета (2 недели): -0.2";
				if (GlobalScript.inst.gameState.data[6] > 600)
				{
					Text_3.text += "\nМеждународная репутация (2 недели): -0.2";
				}
				else if (GlobalScript.inst.gameState.data[6] < 400)
				{
					Text_3.text += "\nМеждународная репутация (2 недели): +0.2";
				}
			}
			else
			{
				Text_3.text = "Мы не участники Гонки вооружений";
			}
		}
		else if (num_this == 5)
		{
			num_names = 3;
			Name_1.text = "Мировоззрение";
			Name_2.text = "Особое влияние";
			Name_3.text = "Количество населения:";
			Text_1.text = "Сейчас:";
			TextMesh text_14;
			if (GlobalScript.inst.gameState.data[31] > 700)
			{
				text_14 = Text_1;
				text_14.text = text_14.text + "\nЖёсткая унификация\n(" + GlobalScript.inst.gameState.data[31] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[31] % 10) + "/100)";
				Text_2.text = "Либерализация\nв 2 недели: -" + (GlobalScript.inst.gameState.data[31] - 500) / 100 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
				text_14 = Text_2;
				text_14.text = text_14.text + "\nПоддержка партии\nв 2 недели: +" + (GlobalScript.inst.gameState.data[31] - 500) / 100 / 10 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
				text_14 = Text_2;
				text_14.text = text_14.text + "\nАгенты (в 2 недели): +" + (GlobalScript.inst.gameState.data[31] - 500) / 1000 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
				Text_2.text += "\nМеждународная репутация\nесли ниже 50.0: +0.5";
			}
			else if (GlobalScript.inst.gameState.data[31] >= 400 && GlobalScript.inst.gameState.data[31] <= 700)
			{
				text_14 = Text_1;
				text_14.text = text_14.text + "\nНесколько народностей\n(" + GlobalScript.inst.gameState.data[31] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[31] % 10) + "/100)";
				Text_2.text = "Отсутствует".ToString();
			}
			else
			{
				text_14 = Text_1;
				text_14.text = text_14.text + "\nМультикультурализм\n(" + GlobalScript.inst.gameState.data[31] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[31] % 10) + "/100)";
				Text_2.text = "Либерализация\nв 2 недели: +" + (500 - GlobalScript.inst.gameState.data[31]) / 100 / 10 + "." + Mathf.Abs((500 - GlobalScript.inst.gameState.data[31]) / 100 % 10);
				text_14 = Text_2;
				text_14.text = text_14.text + "\nПоддержка партии\nв 2 недели: +" + (500 - GlobalScript.inst.gameState.data[31]) / 100 / 10 + "." + Mathf.Abs((500 - GlobalScript.inst.gameState.data[31]) / 100 % 10);
				text_14 = Text_2;
				text_14.text = text_14.text + "\nАгенты (в 2 недели): -" + (GlobalScript.inst.gameState.data[31] - 500) / 1000 + "." + Mathf.Abs((GlobalScript.inst.gameState.data[31] - 500) / 100 % 10);
				text_14 = Text_2;
				text_14.text = text_14.text + "\nОтношения\nв 2 недели: +" + (500 - GlobalScript.inst.gameState.data[31]) / 100 / 10 + "." + Mathf.Abs((500 - GlobalScript.inst.gameState.data[31]) / 100 % 10);
			}
			text_14 = Text_1;
			text_14.text = text_14.text + "\nЕдинство Китая\nУровень:\n(" + GlobalScript.inst.gameState.data[57] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[57] % 10) + "/100)";
			Text_3.text = GlobalScript.inst.gameState.data[34] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[34]) % 10 + " миллионов (" + (((GlobalScript.inst.gameState.data_old[34] < 0) ? "-" : "+") + Mathf.Abs(GlobalScript.inst.gameState.data_old[34] / 10)).ToString() + "." + Mathf.Abs(GlobalScript.inst.gameState.data_old[34] % 10) + ")";
			int[] array2 = new int[5];
			if (GlobalScript.inst.gameState.data[16] == 11)
			{
				array2[0] += GlobalScript.inst.gameState.data[34] / 5000;
			}
			else if (GlobalScript.inst.gameState.data[16] == 10)
			{
				array2[0] += GlobalScript.inst.gameState.data[34] / 5000;
			}
			else if (GlobalScript.inst.gameState.data[16] == 13)
			{
				array2[3] += Mathf.RoundToInt((float)(GlobalScript.inst.gameState.data[34] - 9037) / 3000f + 1f);
			}
			else if (GlobalScript.inst.gameState.data[16] == 14 && !GlobalScript.inst.gameState.modifies[13].active)
			{
				array2[1] -= GlobalScript.inst.gameState.data[34] / 4000;
				array2[3] += Mathf.RoundToInt((float)(GlobalScript.inst.gameState.data[34] - 9037) / 2000f + 1f);
			}
			else if (GlobalScript.inst.gameState.data[16] == 15 && !GlobalScript.inst.gameState.modifies[13].active)
			{
				array2[1] -= GlobalScript.inst.gameState.data[34] / 4000;
				array2[3] += Mathf.RoundToInt((float)(GlobalScript.inst.gameState.data[34] - 9037) / 1000f + 1f);
			}
			if ((GlobalScript.inst.gameState.data[34] - 9307) / 200 > 0)
			{
				array2[2] -= (GlobalScript.inst.gameState.data[34] - 9307) / 200;
			}
			if (GlobalScript.inst.gameState.data[51] == 30)
			{
				if (GlobalScript.inst.gameState.data[34] - 9307 > 99)
				{
					array2[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 100;
					array2[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 100;
				}
			}
			else if (GlobalScript.inst.gameState.data[51] == 31)
			{
				if (GlobalScript.inst.gameState.data[34] - 9307 > 199)
				{
					array2[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 200;
					array2[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 200;
				}
			}
			else if (GlobalScript.inst.gameState.data[51] == 32)
			{
				if (GlobalScript.inst.gameState.data[34] - 9307 > 299)
				{
					array2[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 300;
					array2[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 300;
				}
			}
			else if (GlobalScript.inst.gameState.data[51] == 33 && GlobalScript.inst.gameState.data[34] - 9307 > 149)
			{
				if (GlobalScript.inst.gameState.data[5] < 500)
				{
					array2[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 150;
					array2[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 250;
				}
				else if (GlobalScript.inst.gameState.data[5] < 700)
				{
					array2[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 150;
					array2[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 300;
				}
				else
				{
					array2[3] -= (GlobalScript.inst.gameState.data[34] - 9307) / 500;
					array2[4] += (GlobalScript.inst.gameState.data[34] - 9307) / 500;
				}
			}
			text_14 = Text_3;
			text_14.text = text_14.text + "\nПромышленность: " + (((array2[0] < 0) ? "-" : "+") + Mathf.Abs(array2[0] / 10)).ToString() + "." + Mathf.Abs(array2[0] % 10);
			text_14 = Text_3;
			text_14.text = text_14.text + "; Бюджет: " + (((array2[3] < 0) ? "-" : "+") + Mathf.Abs(array2[3] / 10)).ToString() + "." + Mathf.Abs(array2[3] % 10);
			text_14 = Text_3;
			text_14.text = text_14.text + "\nАгентурные сети: " + (((array2[2] < 0) ? "-" : "+") + Mathf.Abs(array2[2] / 10)).ToString() + "." + Mathf.Abs(array2[2] % 10);
			text_14 = Text_3;
			text_14.text = text_14.text + "; Сила армии: " + (((array2[4] < 0) ? "-" : "+") + Mathf.Abs(array2[4] / 10)).ToString() + "." + Mathf.Abs(array2[4] % 10);
			text_14 = Text_3;
			text_14.text = text_14.text + "\nПоддержка народа: " + (((array2[1] < 0) ? "-" : "+") + Mathf.Abs(array2[1] / 10)).ToString() + "." + Mathf.Abs(array2[1] % 10);
		}
		else if (num_this == 4)
		{
			num_names = 3;
			Name_1.text = "Иран";
			Name_2.text = "Афганистан";
			Name_3.text = "Президент США";
			Text_1.text = "Сила монархистов: \n" + GlobalScript.inst.gameState.data[43] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[43] % 10);
			TextMesh text_15 = Text_1;
			text_15.text = text_15.text + "\nСила левых: \n" + GlobalScript.inst.gameState.data[42] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[42] % 10);
			text_15 = Text_1;
			text_15.text = text_15.text + "\nСила исламистов: \n" + GlobalScript.inst.gameState.data[45] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[45] % 10);
			text_15 = Text_1;
			text_15.text = text_15.text + "\nСила либералов: \n" + GlobalScript.inst.gameState.data[44] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[44] % 10);
			Text_2.text = "Сила маоистов: \n" + GlobalScript.inst.gameState.data[46] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[46] % 10);
			text_15 = Text_2;
			text_15.text = text_15.text + "\nСила Хальк: \n" + GlobalScript.inst.gameState.data[48] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[48] % 10);
			text_15 = Text_2;
			text_15.text = text_15.text + "\nСила Парчам: \n" + GlobalScript.inst.gameState.data[49] / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.data[49] % 10);
			if (GlobalScript.inst.gameState.data[21] < 1977)
			{
				Text_3.text = "Джеральд Форд";
			}
			else if (GlobalScript.inst.gameState.data[21] < 1981)
			{
				Text_3.text = "Джимми Картер";
			}
			else if (GlobalScript.inst.gameState.empires[0].now_leader == 1)
			{
				Text_3.text = "Джимми Картер";
			}
			else if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
			{
				Text_3.text = "Рональд Рейган";
			}
			else if (GlobalScript.inst.gameState.empires[0].now_leader == 2)
			{
				Text_3.text = "Джордж Буш старший";
			}
			else if (GlobalScript.inst.gameState.empires[0].now_leader == 3)
			{
				Text_3.text = "Уолтер Мондейл";
			}
			if (GlobalScript.inst.gameState.data[21] >= 1981 && GlobalScript.inst.gameState.empires[0].now_leader <= 0)
			{
				Text_3.text += "\nТраты США на внешнее вмешательство:\n+0.5\nЛиберализация умов:\n+0.5";
			}
			else if (GlobalScript.inst.gameState.empires[0].now_leader == 1 || (GlobalScript.inst.gameState.data[21] >= 1977 && GlobalScript.inst.gameState.data[21] < 1981))
			{
				Text_3.text += "\nОтношения Китая с США:\n+1.0";
			}
			else if (GlobalScript.inst.gameState.empires[0].now_leader == 2)
			{
				Text_3.text += "\nТраты США на внешнее вмешательство:\n+0.5\nОтношения с США: +0.5\nесли не состоим в альянсах";
			}
			else if (GlobalScript.inst.gameState.empires[0].now_leader == 3)
			{
				Text_3.text += "\nВлияние от кнопки Маоисты\nв Западной Европе - x1.5\nКредиты выплачиваются\nраз в 2 месяца";
			}
		}
		else if (num_this == 2)
		{
			num_names = 3;
			Name_1.text = "Китай";
			Name_2.text = "Тайвань";
			Name_3.text = "Аруначал Прадеш";
			if (GlobalScript.inst.gameState.data[67] <= 0)
			{
				Text_1.text = "Тибет - в составе Китая\n";
			}
			else if (GlobalScript.inst.gameState.data[67] == 1)
			{
				Text_1.text = "Республика Тибет - независимая\n";
			}
			else if (GlobalScript.inst.gameState.data[67] == 2)
			{
				Text_1.text = "Тибет - независимая теократия\n";
			}
			if (GlobalScript.inst.gameState.data[66] <= 0)
			{
				Text_1.text += "Синьцзян - в составе Китая\n";
			}
			else if (GlobalScript.inst.gameState.data[66] == 1)
			{
				Text_1.text += "Синьцзян - советская марионетка\n";
			}
			else if (GlobalScript.inst.gameState.data[66] == 2)
			{
				Text_1.text += "Исламская Республика Уйгуристан - независимая\n";
			}
			if (GlobalScript.inst.gameState.data[65] <= 0)
			{
				Text_1.text += "Гонконг и Макао в иностранном владении\n";
			}
			else if (GlobalScript.inst.gameState.data[65] == 1)
			{
				Text_1.text += "Гонконг и Макао - специальные районы Китая\n";
			}
			else if (GlobalScript.inst.gameState.data[65] == 2)
			{
				Text_1.text += "Гонконг и Макао вошли в состав Китая\n";
			}
			if (GlobalScript.inst.gameState.allcountries[7].parts[1] || GlobalScript.inst.gameState.allcountries[7].parts[2])
			{
				Text_1.text += "Монголия - в составе СССР\n";
			}
			else if (!GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19])
			{
				Text_1.text += "Монголия - независимое просоветское государство\n";
			}
			else if (GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19])
			{
				Text_1.text += "Монголия - независимое прокитайское государство\n";
			}
			else
			{
				Text_1.text += "Монголия вошла в состав Китая\n";
			}
			if (GlobalScript.inst.gameState.data[64] == 2 || GlobalScript.inst.gameState.completedDecisions[6] || GlobalScript.inst.gameState.completedDecisions[7])
			{
				Text_2.text = "Тайвань - автономный регион в составе Китая\n";
			}
			else if (GlobalScript.inst.gameState.data[64] <= 0)
			{
				Text_2.text = "Республика Китай под контролем Гоминьдана\n(авторитарная, частично признанная)\n";
			}
			else if (GlobalScript.inst.gameState.data[64] == 1)
			{
				Text_2.text = "Республика Тайвань - суверенное государство\n(либеральное, всеми признанное)\n";
			}
			if (GlobalScript.inst.gameState.data[63] <= 0)
			{
				Text_2.text += "Острова возле Тайваня под контролем\nГоминьдана.\n";
			}
			else if (GlobalScript.inst.gameState.data[63] == 1)
			{
				Text_2.text += "Острова возле Тайваня под контролем\nнаших вооружённых сил.\n";
			}
			if (GlobalScript.inst.gameState.data[62] <= 0)
			{
				Text_3.text = "Контролируется Индией, но непризнано нами\n";
			}
			else if (GlobalScript.inst.gameState.data[62] == 1)
			{
				Text_3.text = "Мы признали контроль земель за Индией\n";
			}
			else if (GlobalScript.inst.gameState.data[62] == 2 || GlobalScript.inst.gameState.data[62] == 3)
			{
				Text_3.text = "Мы восстановили контроль над этими землями\n";
			}
		}
		else if (num_this == 6)
		{
			num_names = 1;
			Name_1.text = "Наши союзники";
			if (GlobalScript.inst.gameState.allcountries[1].econ)
			{
				Text_1.text = "<color=red>Страна - Членство - Консультируются - Стабильность</color>";
				for (int m = 0; m < GlobalScript.inst.gameState.allcountries.Length; m++)
				{
					switch (m)
					{
					default:
						if (m < 106 || m >= 109)
						{
							continue;
						}
						break;
					case 8:
					case 11:
					case 12:
					case 14:
					case 19:
					case 22:
					case 23:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
					case 43:
					case 46:
					case 47:
					case 48:
					case 49:
					case 50:
					case 52:
					case 53:
					case 54:
					case 55:
					case 56:
					case 57:
					case 58:
					case 59:
					case 60:
					case 61:
					case 62:
					case 63:
					case 64:
					case 65:
					case 66:
					case 67:
					case 68:
					case 96:
					case 97:
						break;
					}
					if (GlobalScript.inst.gameState.allcountries[m].econ && GlobalScript.inst.gameState.allcountries[m].okb)
					{
						TextMesh text_16 = Text_1;
						text_16.text = text_16.text + "\n" + GlobalScript.inst.gameState.allcountries[m].name + " - Оба - " + (GlobalScript.inst.gameState.allcountries[m].proprc ? "Да - " : "Нет - ") + GlobalScript.inst.gameState.allcountries[m].soc_stab / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.allcountries[m].soc_stab % 10);
					}
					else if (GlobalScript.inst.gameState.allcountries[m].econ)
					{
						TextMesh text_17 = Text_1;
						text_17.text = text_17.text + "\n" + GlobalScript.inst.gameState.allcountries[m].name + " - Экономический - " + (GlobalScript.inst.gameState.allcountries[m].proprc ? "Да - " : "Нет - ") + GlobalScript.inst.gameState.allcountries[m].soc_stab / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.allcountries[m].soc_stab % 10);
					}
					else if (GlobalScript.inst.gameState.allcountries[m].okb)
					{
						TextMesh text_18 = Text_1;
						text_18.text = text_18.text + "\n" + GlobalScript.inst.gameState.allcountries[m].name + " - Военный - " + (GlobalScript.inst.gameState.allcountries[m].proprc ? "Да - " : "Нет - ") + GlobalScript.inst.gameState.allcountries[m].soc_stab / 10 + "." + Mathf.Abs(GlobalScript.inst.gameState.allcountries[m].soc_stab % 10);
					}
				}
			}
			else
			{
				Text_1.text = "У нас нет своего союза";
			}
		}
		if (num_names != 3)
		{
			if (num_names == 2)
			{
				Name_3.text = null;
				Text_3.text = null;
			}
			else if (num_names == 1)
			{
				Name_3.text = null;
				Text_3.text = null;
				Name_2.text = null;
				Text_2.text = null;
			}
		}
	}

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = on;
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = off;
	}

	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		for (int i = 0; i < text.Length; i++)
		{
			if (num >= col)
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

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			GlobalScript.inst.gameState.ChinesePage = 0;
			int num = num_this;
			num_this = GlobalScript.inst.gameState.allcountries[1].spec;
			OnMouseDown();
			num_this = num;
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			GlobalScript.inst.gameState.ChinesePage = 1;
			int num2 = num_this;
			num_this = GlobalScript.inst.gameState.allcountries[1].spec;
			OnMouseDown();
			num_this = num2;
		}
	}
}
