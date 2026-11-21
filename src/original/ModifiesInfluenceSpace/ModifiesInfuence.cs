using UnityEngine;

namespace ModifiesInfluenceSpace;

public class ModifiesInfuence
{
	public static void ModifiesChanges(int ch_support, int ch_lib)
	{
		if (GlobalScript.inst.gameState.modifies[0].active)
		{
			if (GlobalScript.inst.gameState.science[10])
			{
				GlobalScript.inst.gameState.modifies[0].active = false;
			}
			GlobalScript.inst.gameState.data[12] -= 5;
		}
		if (GlobalScript.inst.gameState.modifies[18].active)
		{
			if (GlobalScript.inst.gameState.science[10])
			{
				GlobalScript.inst.gameState.modifies[0].active = false;
			}
			GlobalScript.inst.gameState.data[12] -= 5;
		}
		if (GlobalScript.inst.gameState.modifies[50].active)
		{
			if (GlobalScript.inst.gameState.event_done[513] && GlobalScript.inst.gameState.science[18])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[513] == 0)
				{
					GlobalScript.inst.gameState.data[22]++;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[513] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 2;
				}
			}
			if (GlobalScript.inst.gameState.event_done[514] && GlobalScript.inst.gameState.science[23])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[514] == 0)
				{
					GlobalScript.inst.gameState.data[3]++;
					GlobalScript.inst.gameState.data[4]--;
					if (GlobalScript.inst.gameState.data[6] > 900)
					{
						GlobalScript.inst.gameState.data[6]--;
					}
					else if (GlobalScript.inst.gameState.data[6] < 700)
					{
						GlobalScript.inst.gameState.data[6]++;
					}
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[514] == 1)
				{
					GlobalScript.inst.gameState.data[3]++;
					GlobalScript.inst.gameState.data[4]++;
					GlobalScript.inst.gameState.data[6] -= 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[514] == 2)
				{
					GlobalScript.inst.gameState.data[3]++;
					GlobalScript.inst.gameState.data[4] -= 2;
					GlobalScript.inst.gameState.data[6] += 2;
				}
			}
			if (GlobalScript.inst.gameState.event_done[345])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[345] == 0)
				{
					GlobalScript.inst.gameState.data[3] += 3;
					GlobalScript.inst.gameState.data[22] += 2;
					GlobalScript.inst.gameState.data[0] += 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[345] == 1)
				{
					GlobalScript.inst.gameState.data[8]--;
					GlobalScript.inst.gameState.data[22] += 5;
					GlobalScript.inst.gameState.data[0] += 2;
					GlobalScript.inst.gameState.data[26] += 2;
				}
			}
			if (GlobalScript.inst.gameState.event_done[515] && GlobalScript.inst.gameState.resultOfEvents[515] == 0)
			{
				GlobalScript.inst.gameState.data[9]++;
				GlobalScript.inst.gameState.data[22] += 2;
			}
			if (GlobalScript.inst.gameState.event_done[516])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[516] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 3;
					GlobalScript.inst.gameState.data[8]--;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[516] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 6;
					GlobalScript.inst.gameState.data[8] -= 2;
					GlobalScript.inst.gameState.data[57] += 2;
				}
			}
			if (GlobalScript.inst.gameState.event_done[517])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[517] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 3;
					GlobalScript.inst.gameState.data[8] -= 2;
					GlobalScript.inst.gameState.data[3] += 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[517] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 5;
					GlobalScript.inst.gameState.data[8] -= 2;
					GlobalScript.inst.gameState.empires[0].relations -= 2;
					GlobalScript.inst.gameState.empires[1].relations -= 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[517] == 2)
				{
					GlobalScript.inst.gameState.data[22] += 10;
					GlobalScript.inst.gameState.data[3] += 3;
					GlobalScript.inst.gameState.data[8] -= 3;
					GlobalScript.inst.gameState.empires[0].relations -= 2;
					GlobalScript.inst.gameState.empires[1].relations -= 2;
				}
			}
			if (GlobalScript.inst.gameState.event_done[518])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[518] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 2;
					GlobalScript.inst.gameState.data[8] -= 2;
					GlobalScript.inst.gameState.data[3] += 2;
					GlobalScript.inst.gameState.data[0] += 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[518] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 3;
					GlobalScript.inst.gameState.data[8] -= 2;
					GlobalScript.inst.gameState.empires[0].relations--;
					GlobalScript.inst.gameState.empires[1].relations--;
					GlobalScript.inst.gameState.data[0] += 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[518] == 2)
				{
					GlobalScript.inst.gameState.data[22] += 8;
					GlobalScript.inst.gameState.data[3] += 2;
					GlobalScript.inst.gameState.data[8] -= 3;
					GlobalScript.inst.gameState.empires[0].relations--;
					GlobalScript.inst.gameState.empires[1].relations--;
					GlobalScript.inst.gameState.data[0] += 10;
				}
			}
			if (GlobalScript.inst.gameState.event_done[519])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[519] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 18;
					GlobalScript.inst.gameState.data[8] -= 4;
					GlobalScript.inst.gameState.data[3] += 5;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[519] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 15;
					GlobalScript.inst.gameState.data[8] -= 3;
					GlobalScript.inst.gameState.data[3] += 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[519] == 2)
				{
					GlobalScript.inst.gameState.data[22] += 35;
					GlobalScript.inst.gameState.data[8] -= 5;
					GlobalScript.inst.gameState.data[3] += 10;
				}
			}
			if (GlobalScript.inst.gameState.event_done[520])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[520] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 20;
					GlobalScript.inst.gameState.empires[0].relations -= 3;
					GlobalScript.inst.gameState.empires[1].relations -= 3;
					GlobalScript.inst.gameState.data[3] += 5;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[520] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 50;
					GlobalScript.inst.gameState.data[8] -= 5;
					GlobalScript.inst.gameState.empires[0].relations -= 4;
					GlobalScript.inst.gameState.empires[1].relations -= 4;
					GlobalScript.inst.gameState.data[3] += 8;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[520] == 2)
				{
					GlobalScript.inst.gameState.data[22] += 10;
					GlobalScript.inst.gameState.empires[0].relations -= 2;
					GlobalScript.inst.gameState.empires[1].relations -= 2;
					GlobalScript.inst.gameState.data[3] += 10;
				}
			}
			if (GlobalScript.inst.gameState.event_done[521])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[521] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 30;
					GlobalScript.inst.gameState.influencePRC += 5;
					GlobalScript.inst.gameState.data[3] += 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[521] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 30;
					GlobalScript.inst.gameState.data[0] += 20;
					GlobalScript.inst.gameState.influencePRC += 5;
					GlobalScript.inst.gameState.data[3] += 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[521] == 2)
				{
					GlobalScript.inst.gameState.data[22] += 50;
					GlobalScript.inst.gameState.data[0] += 30;
					GlobalScript.inst.gameState.influencePRC += 10;
					GlobalScript.inst.gameState.data[3] += 25;
				}
			}
			if (GlobalScript.inst.gameState.event_done[540])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[540] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 4;
					GlobalScript.inst.gameState.data[0] += 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[540] == 1)
				{
					GlobalScript.inst.gameState.data[22] += 2;
					GlobalScript.inst.gameState.data[0] += 2;
				}
			}
			if (GlobalScript.inst.gameState.event_done[544])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[544] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 7;
					GlobalScript.inst.gameState.data[6] -= 5;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[544] == 1)
				{
					GlobalScript.inst.gameState.empires[1].relations -= 2;
					GlobalScript.inst.gameState.data[22] += 20;
					GlobalScript.inst.gameState.empires[0].relations -= 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[544] == 2)
				{
					GlobalScript.inst.gameState.empires[1].relations -= 4;
					GlobalScript.inst.gameState.data[22] += 40;
					GlobalScript.inst.gameState.empires[0].relations -= 4;
				}
			}
			if (GlobalScript.inst.gameState.event_done[545])
			{
				if (GlobalScript.inst.gameState.resultOfEvents[545] == 0)
				{
					GlobalScript.inst.gameState.data[22] += 10;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 1)
				{
					GlobalScript.inst.gameState.data[5] += 10;
					GlobalScript.inst.gameState.data[3] += 10;
					GlobalScript.inst.gameState.data[4] -= 5;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[545] == 2)
				{
					GlobalScript.inst.gameState.data[22] += 20;
					GlobalScript.inst.gameState.data[5] += 15;
					GlobalScript.inst.gameState.data[3] += 15;
					GlobalScript.inst.gameState.data[4] -= 10;
				}
			}
			if (GlobalScript.inst.gameState.data[22] >= 2000)
			{
				int num = (GlobalScript.inst.gameState.data[22] - 2000) / 100;
				GlobalScript.inst.gameState.data[22] -= 10 * num;
				GlobalScript.inst.gameState.data[8] += 2 * num;
				GlobalScript.inst.gameState.data[9] += 2 * num;
				GlobalScript.inst.gameState.data[36] += 2 * num;
			}
			if (GlobalScript.inst.gameState.allcountries[16].prcinfl != 0)
			{
				GlobalScript.inst.gameState.data[22] += 5;
				GlobalScript.inst.gameState.data[9] += 3;
				GlobalScript.inst.gameState.data[0] += 10;
				GlobalScript.inst.gameState.data[8] -= 8;
				GlobalScript.inst.gameState.data[11] -= 2;
				GlobalScript.inst.gameState.data[3] += 10;
			}
		}
		if (!GlobalScript.inst.gameState.modifies[1].active)
		{
			GlobalScript.inst.gameState.modifies[1].active = true;
		}
		if (!GlobalScript.inst.gameState.modifies[50].active)
		{
			GlobalScript.inst.gameState.modifies[50].active = true;
		}
		if (GlobalScript.inst.gameState.modifies[2].active)
		{
			if (GlobalScript.inst.gameState.data[108] < 54)
			{
				GlobalScript.inst.old_modify_desc[2] = "<color=red>受 到 管 控 的 私 有 制 ：</color> 投 机 倒 把 的 商 人 还 影 响 不 到 我 们";
			}
			else if (GlobalScript.inst.gameState.data[108] < 72)
			{
				GlobalScript.inst.old_modify_desc[2] = "<color=red>逐 渐 崛 起 的 寡 头 ：</color>人 民 支 持 度-0.5 ， 思 想 自 由 化+1 ， 生 活 水 平-0.5 ";
				GlobalScript.inst.gameState.data[3] -= 5;
				GlobalScript.inst.gameState.data[4] += 10;
				GlobalScript.inst.gameState.data[5] -= 5;
				GlobalScript.inst.gameState.data[9] -= 2;
			}
			else if (GlobalScript.inst.gameState.data[108] >= 72)
			{
				GlobalScript.inst.old_modify_desc[2] = "<color=red>寡 头 执 政 ：</color>人 民 支 持 度-1 ， 思 想 自 由 化+2 ， 生 活 水 平-1 ";
				GlobalScript.inst.gameState.data[3] -= 10;
				GlobalScript.inst.gameState.data[4] += 20;
				GlobalScript.inst.gameState.data[5] -= 10;
				GlobalScript.inst.gameState.data[9] -= 2;
			}
			if (!GlobalScript.inst.gameState.event_done[669])
			{
				string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
				int num2 = 2;
				old_modify_desc[num2] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.1 ， 工 业+0.2 ，农 业+0.2 ， 人 民 支 持 度+0.2 ， 科 技 点 数+0.5";
				GlobalScript.inst.gameState.data[3] += 2;
				GlobalScript.inst.gameState.data[8]--;
				GlobalScript.inst.gameState.data[12] += 2;
				GlobalScript.inst.gameState.data[13] += 2;
				GlobalScript.inst.gameState.data[11] += 5;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[669] == 0)
			{
				string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
				int num3 = 2;
				old_modify_desc2[num3] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.2 ， 工 业+0.3 ，农 业+0.3 ， 人 民 支 持 度+0.3 ， 科 技 点 数+1";
				GlobalScript.inst.gameState.data[3] += 3;
				GlobalScript.inst.gameState.data[8] -= 2;
				GlobalScript.inst.gameState.data[12] += 3;
				GlobalScript.inst.gameState.data[13] += 3;
				GlobalScript.inst.gameState.data[11] += 10;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[669] == 1)
			{
				string[] old_modify_desc3 = GlobalScript.inst.old_modify_desc;
				int num4 = 2;
				old_modify_desc3[num4] += "|<color=red>正 统 社 会 主 义 教 育 路 线 ：</color>预 算-0.1 ， 腐 败 + 0.1 ， 科 技 点 数+1.5";
				GlobalScript.inst.gameState.data[8]--;
				GlobalScript.inst.gameState.data[26]++;
				GlobalScript.inst.gameState.data[11] += 15;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[669] == 2)
			{
				string[] old_modify_desc4 = GlobalScript.inst.old_modify_desc;
				int num5 = 2;
				old_modify_desc4[num5] += "|<color=red>混 合 式 教 育 体 制 改 革 ：</color>预 算+0.2 ， 寡 头 力 量+0.1 , 腐 败 + 0.2 ， 科 技 点 数+2";
				GlobalScript.inst.gameState.data[8] += 2;
				GlobalScript.inst.gameState.data[108]++;
				GlobalScript.inst.gameState.data[26]++;
				GlobalScript.inst.gameState.data[11] += 20;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[669] == 3)
			{
				string[] old_modify_desc5 = GlobalScript.inst.old_modify_desc;
				int num6 = 2;
				old_modify_desc5[num6] += "|<color=red>全 民 军 事 化 教 育 ：</color>军 事 力 量+0.3 ，人 民 支 持 度+1 ， 思 想 自 由 化-1 ， 科 技 点 数-2 ， 凝 聚 力+0.5 ， 民 族 情 绪+0.5";
				GlobalScript.inst.gameState.data[22] += 3;
				GlobalScript.inst.gameState.data[3]++;
				GlobalScript.inst.gameState.data[4]--;
				GlobalScript.inst.gameState.data[11] -= 20;
				GlobalScript.inst.gameState.data[57] += 50;
				GlobalScript.inst.gameState.data[31] += 50;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[456] == 0 && GlobalScript.inst.gameState.event_done[456])
			{
				string[] old_modify_desc6 = GlobalScript.inst.old_modify_desc;
				int num7 = 2;
				old_modify_desc6[num7] += "|<color=red>全 国 高 校 统 一 招 生 考 试 ：</color>科 技 点 数 +2";
				GlobalScript.inst.gameState.data[11] += 20;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[456] == 1 && GlobalScript.inst.gameState.event_done[456])
			{
				string[] old_modify_desc7 = GlobalScript.inst.old_modify_desc;
				int num8 = 2;
				old_modify_desc7[num8] += "|<color=red>预 科 制 度 ：</color>科 技 点 数 +1";
				GlobalScript.inst.gameState.data[11] += 10;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[456] == 2 || !GlobalScript.inst.gameState.event_done[456])
			{
				string[] old_modify_desc8 = GlobalScript.inst.old_modify_desc;
				int num9 = 2;
				old_modify_desc8[num9] += "|<color=red>无 产 阶 级 推 荐 制 ：</color>农 业+0.3 ， 工 业+0.3";
				GlobalScript.inst.gameState.data[12] += 3;
				GlobalScript.inst.gameState.data[13] += 3;
			}
			if (!GlobalScript.inst.gameState.event_done[646])
			{
				string[] old_modify_desc9 = GlobalScript.inst.old_modify_desc;
				int num10 = 2;
				old_modify_desc9[num10] += "|<color=red>合 作 医 疗 ：</color>预 算-0.1 ， 工 业+0.2 ， 农 业+0.3 ， 人民支持度+0.2 , 服 务 业+0.2";
				GlobalScript.inst.gameState.data[3] += 2;
				GlobalScript.inst.gameState.data[8]--;
				GlobalScript.inst.gameState.data[12] += 2;
				GlobalScript.inst.gameState.data[13] += 3;
				GlobalScript.inst.gameState.data[68] += 2;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[646] == 0)
			{
				string[] old_modify_desc10 = GlobalScript.inst.old_modify_desc;
				int num11 = 2;
				old_modify_desc10[num11] += "|<color=red>精 进 的 合 作 医 疗 ：</color>预 算-0.2 ， 工 业+0.3 ， 农 业+0.4 ， 人民支持度+0.2 , 服 务 业+0.3";
				GlobalScript.inst.gameState.data[3] += 2;
				GlobalScript.inst.gameState.data[8] -= 2;
				GlobalScript.inst.gameState.data[12] += 3;
				GlobalScript.inst.gameState.data[13] += 4;
				GlobalScript.inst.gameState.data[68] += 3;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[646] == 1)
			{
				string[] old_modify_desc11 = GlobalScript.inst.old_modify_desc;
				int num12 = 2;
				old_modify_desc11[num12] += "|<color=red>市 场 化 改 革 医 疗 ：</color>预 算+0.2 ， 生 活 水 平+0.1 ， 寡 头 力 量+0.1 , 服 务 业+0.1";
				GlobalScript.inst.gameState.data[8] += 2;
				GlobalScript.inst.gameState.data[5]++;
				GlobalScript.inst.gameState.data[108]++;
				GlobalScript.inst.gameState.data[68]++;
			}
		}
		if (GlobalScript.inst.gameState.modifies[3].active)
		{
			GlobalScript.inst.gameState.data[8] += 6;
			GlobalScript.inst.gameState.data[9] += 2;
			GlobalScript.inst.gameState.data[22] += 5;
			if (GlobalScript.inst.gameState.data[38] >= 100)
			{
				GlobalScript.inst.gameState.data[3] += 5;
				GlobalScript.inst.gameState.data[4] += 10;
				GlobalScript.inst.gameState.data[5] -= 5;
				GlobalScript.inst.gameState.empires[0].relations -= 5;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[503] == 0 && GlobalScript.inst.gameState.event_done[503] && GlobalScript.inst.gameState.data[31] <= 800)
			{
				GlobalScript.inst.gameState.data[31] = 800;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[912] == 0 && GlobalScript.inst.gameState.data[31] <= 1000)
			{
				GlobalScript.inst.gameState.data[31] = 1000;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[668] == 0)
			{
				GlobalScript.inst.old_modify_desc[3] = " 收 入+0.6 ， 特 工 网 络+0.2 ， 军 队 力 量+0.5|<color=red> 如 果 毛 主 席 已 逝 世 ：</color>  人 民 支 持 度+0.5 ， 思 想 自 由 化+1 ， 生 活 水 平-0.5 ，与 美 国 关 系-0.5|<color=red> 全 新 的 高 潮 ：</color>  党 内 团 结 度+0.5 ， 人 民 支 持 度+0.5 ， 思 想 自 由 化+0.5 ， 极 左 力 量+1";
				GlobalScript.inst.gameState.data[1] += 5;
				GlobalScript.inst.gameState.data[3] += 5;
				GlobalScript.inst.gameState.data[4] += 5;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic.traits[0] == 0)
					{
						politic.power += 10;
					}
				}
			}
		}
		if (GlobalScript.inst.gameState.modifies[5].active)
		{
			GlobalScript.inst.gameState.data[3] -= 2;
			GlobalScript.inst.gameState.data[4] += 10;
			GlobalScript.inst.gameState.data[8] += 2;
		}
		if (GlobalScript.inst.gameState.modifies[6].active)
		{
			GlobalScript.inst.old_modify_desc[6] = " 党 内 团 结 度+0.5 ， 思 想 自 由 化-0.2 ， 凝 聚 力+0.1 ， 国 际 声 誉+0.2 ， 与 苏 联 关 系-0.4 ， 与 美 国 关 系-0.2 |";
			if (GlobalScript.inst.gameState.event_done[548] && GlobalScript.inst.gameState.modifies[3].active)
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 0)
				{
					string[] old_modify_desc12 = GlobalScript.inst.old_modify_desc;
					int num13 = 6;
					old_modify_desc12[num13] += "<color=red>| 革 命 国 际 主 义 运 动 — — 深 化 国 间 经 济 - 政 治 一 体 化 ：</color>| 农 业 、 工 业 和 服 务 业+0.4 ； 生 活 水 平+0.2 ； 人 民 支 持 度+0.5 ； 凝 聚 力+0.1 ； 思 想 自 由 化-0.2 ； 与 美 苏 关 系-0.2 ";
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					string[] old_modify_desc13 = GlobalScript.inst.old_modify_desc;
					int num14 = 6;
					old_modify_desc13[num14] += "<color=red>| 革 命 国 际 主 义 运 动 — — 共 产 党 情 报 局 ：</color>| 极 左 派+1 ； 极 左 派 力 量+1 ； 干 涉 点 数+3.0 ； 国 际 声 望+0.1 ； 与 美 苏 关 系-0.6 ； 国 际 影 响 力+0.5 ； 预 算-0.6 ； 特 工-0.6 ； 特 勤 援 助 的 效 果+1 ； 人 道 主 义 援 助 的 效 果+1 ； 中 国 一 次 性 外 交 声 援 的 效 果+3 ";
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					string[] old_modify_desc14 = GlobalScript.inst.old_modify_desc;
					int num15 = 6;
					old_modify_desc14[num15] += "<color=red>| 革 命 国 际 主 义 运 动 — — 深 化 国 间 经 济 - 政 治 一 体 化 ：</color>| 农 业 、 工 业 和 服 务 业+0.4 ； 生 活 水 平+0.2 ； 人 民 支 持 度+0.5 ； 凝 聚 力+0.1 ； 思 想 自 由 化-0.2 ； 与 美 苏 关 系-0.2";
					string[] old_modify_desc15 = GlobalScript.inst.old_modify_desc;
					int num16 = 6;
					old_modify_desc15[num16] += "<color=red>| 革 命 国 际 主 义 运 动 — — 新 国 际 ：</color>| 极 左 派 +2 ； 极 左 派 力 量 +2 ； 干 涉 点 数 +5.0 ； 国 际 声 望+0.2 ； 国 际 声 望 低 于90.0 时 ， 国 际 声 望 额 外+0.1 ； 与 美 苏 关 系-1 ； 国 际 影 响 力+1 ； 预 算-1 ； 特 工-1 ； 军 力-1 ； 军 事 援 助 的 效 果+2 ； 特 勤 援 助 的 效 果+3 ； 人 道 主 义 援 助 的 效 果+3 ； 中 国 一 次 性 外 交 声 援 的 效 果+6";
				}
			}
			if (GlobalScript.inst.gameState.resultOfEvents[670] == 0 && GlobalScript.inst.gameState.modifies[3].active)
			{
				string[] old_modify_desc16 = GlobalScript.inst.old_modify_desc;
				int num17 = 6;
				old_modify_desc16[num17] += "|<color=red>宣 传 鼓 动——群 众 自 己 解 放 自 己 ：</color>  党 内 团 结 度-1.5 ， 人 民 支 持 度+0.4 ， 思 想 自 由 化+0.4 ， 极 左 力 量+1 ； 每 5 点 宣 传 投 资 ： 党 内 团 结 度+0.1 ， 人 民 支 持 度+0.1 ， 思 想 自 由 化-0.1 ； 宣 传 投 资 不 低 于40 时 ， 党 内 团 结 度+0.7 ， 人 民 支 持 度+1.0 ， 思 想 自 由 化-1.0 ， 特 勤 网 络+2.0";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[670] == 1)
			{
				string[] old_modify_desc17 = GlobalScript.inst.old_modify_desc;
				int num18 = 6;
				old_modify_desc17[num18] += "|<color=red>新 时 代 红 卫 兵——革 命 的 大 联 合 ：</color>  党 内 团 结 度 -0.2 ， 人 民 支 持 度 +0.2 ， 军 事 实 力 -0.4 ， 特 勤 网 络 -0.4 ； 每10 点 行 政 投 资 ： 党 内 团 结 度 +0.1 ， 人 民 支 持 度 +0.2 ， 思 想 自 由 化 -0.2 ， 军 事 实 力 +0.1 ， 特 勤 网 络 +0.1 ； 行 政 投 资 不 低 于50 时 ， 党 内 团 结 度 +1.0 ， 人 民 支 持 度 +1.0 ， 思 想 自 由 化 -1.0 ， 特 勤 网 络 +1.0";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[670] == 2)
			{
				string[] old_modify_desc18 = GlobalScript.inst.old_modify_desc;
				int num19 = 6;
				old_modify_desc18[num19] += "|<color=red>东 南 西 北 中 ， 党 领 导 一 切 ：</color>  党 内 团 结 度 +1.0 ， 特 勤 网 络 +0.2 ， 腐 败 +0.2 ； 每10 点 行 政 投 资 ： 党 内 团 结 度 +0.2 ， 人 民 支 持 度 +0.1 ， 思 想 自 由 化 -0.1 ； 行 政 投 资 不 低 于40 时 ， 特 勤 网 络 +1.0 ， 腐 败 -0.2";
			}
			GlobalScript.inst.gameState.data[1] += 5;
			GlobalScript.inst.gameState.data[4] -= 2;
			GlobalScript.inst.gameState.data[57]++;
			GlobalScript.inst.gameState.empires[0].relations -= 2;
			GlobalScript.inst.gameState.empires[1].relations -= 4;
			GlobalScript.inst.gameState.data[6] += 2;
			if (GlobalScript.inst.gameState.modifies[3].active)
			{
				if (GlobalScript.inst.gameState.resultOfEvents[548] == 0)
				{
					GlobalScript.inst.gameState.data[12] += 4;
					GlobalScript.inst.gameState.data[13] += 4;
					GlobalScript.inst.gameState.data[68] += 4;
					GlobalScript.inst.gameState.data[5] += 2;
					GlobalScript.inst.gameState.data[3] += 5;
					GlobalScript.inst.gameState.data[57]++;
					GlobalScript.inst.gameState.data[4] -= 2;
					GlobalScript.inst.gameState.empires[0].relations -= 2;
					GlobalScript.inst.gameState.empires[1].relations -= 2;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
				{
					GlobalScript.inst.gameState.party_ideology[0]++;
					Politic[] politics = GlobalScript.inst.gameState.politics;
					foreach (Politic politic2 in politics)
					{
						if (politic2.traits[0] == 0)
						{
							politic2.power += 10;
						}
					}
					GlobalScript.inst.gameState.data[0] += 30;
					GlobalScript.inst.gameState.data[6]++;
					GlobalScript.inst.gameState.empires[0].relations -= 6;
					GlobalScript.inst.gameState.empires[1].relations -= 6;
					GlobalScript.inst.gameState.influencePRC += 5;
					GlobalScript.inst.gameState.data[8] -= 6;
					GlobalScript.inst.gameState.data[9] -= 6;
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
				{
					GlobalScript.inst.gameState.data[12] += 4;
					GlobalScript.inst.gameState.data[13] += 4;
					GlobalScript.inst.gameState.data[68] += 4;
					GlobalScript.inst.gameState.data[5] += 2;
					GlobalScript.inst.gameState.data[3] += 5;
					GlobalScript.inst.gameState.data[57]++;
					GlobalScript.inst.gameState.data[4] -= 2;
					GlobalScript.inst.gameState.empires[0].relations -= 2;
					GlobalScript.inst.gameState.empires[1].relations -= 2;
					GlobalScript.inst.gameState.party_ideology[0]++;
					GlobalScript.inst.gameState.party_ideology[0]++;
					Politic[] politics = GlobalScript.inst.gameState.politics;
					foreach (Politic politic3 in politics)
					{
						if (politic3.traits[0] == 0)
						{
							politic3.power += 30;
						}
					}
					GlobalScript.inst.gameState.data[0] += 50;
					GlobalScript.inst.gameState.data[6] += 2;
					if (GlobalScript.inst.gameState.data[6] < 900)
					{
						GlobalScript.inst.gameState.data[6]++;
					}
					GlobalScript.inst.gameState.empires[0].relations -= 10;
					GlobalScript.inst.gameState.empires[1].relations -= 10;
					GlobalScript.inst.gameState.influencePRC += 10;
					GlobalScript.inst.gameState.data[8] -= 10;
					GlobalScript.inst.gameState.data[9] -= 10;
					GlobalScript.inst.gameState.data[22] -= 10;
				}
			}
			if (GlobalScript.inst.gameState.resultOfEvents[670] == 0 && GlobalScript.inst.gameState.modifies[3].active)
			{
				GlobalScript.inst.gameState.data[1] -= 15;
				GlobalScript.inst.gameState.data[3] += 4;
				GlobalScript.inst.gameState.data[4] += 4;
				GlobalScript.inst.gameState.data[1] += GlobalScript.inst.gameState.data[76] / 50;
				GlobalScript.inst.gameState.data[3] += GlobalScript.inst.gameState.data[76] / 50;
				GlobalScript.inst.gameState.data[4] -= GlobalScript.inst.gameState.data[76] / 50;
				if (GlobalScript.inst.gameState.data[76] >= 400)
				{
					GlobalScript.inst.gameState.data[1] += 7;
					GlobalScript.inst.gameState.data[3] += 10;
					GlobalScript.inst.gameState.data[4] -= 10;
					GlobalScript.inst.gameState.data[9] += 20;
				}
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[670] == 1)
			{
				GlobalScript.inst.gameState.data[1] -= 2;
				GlobalScript.inst.gameState.data[3] += 2;
				GlobalScript.inst.gameState.data[22] -= 4;
				GlobalScript.inst.gameState.data[9] -= 4;
				GlobalScript.inst.gameState.data[1] += GlobalScript.inst.gameState.data[74] / 100;
				GlobalScript.inst.gameState.data[3] += GlobalScript.inst.gameState.data[74] / 50;
				GlobalScript.inst.gameState.data[4] -= GlobalScript.inst.gameState.data[74] / 50;
				GlobalScript.inst.gameState.data[22] += GlobalScript.inst.gameState.data[74] / 100;
				GlobalScript.inst.gameState.data[9] += GlobalScript.inst.gameState.data[74] / 100;
				if (GlobalScript.inst.gameState.data[74] >= 500)
				{
					GlobalScript.inst.gameState.data[1] += 10;
					GlobalScript.inst.gameState.data[3] += 10;
					GlobalScript.inst.gameState.data[4] -= 10;
					GlobalScript.inst.gameState.data[9] += 10;
				}
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[670] == 2)
			{
				GlobalScript.inst.gameState.data[1] += 10;
				GlobalScript.inst.gameState.data[9] += 2;
				GlobalScript.inst.gameState.data[26] += 2;
				GlobalScript.inst.gameState.data[1] += GlobalScript.inst.gameState.data[74] / 100;
				GlobalScript.inst.gameState.data[3] += GlobalScript.inst.gameState.data[74] / 50;
				GlobalScript.inst.gameState.data[4] -= GlobalScript.inst.gameState.data[74] / 50;
				if (GlobalScript.inst.gameState.data[74] >= 400)
				{
					GlobalScript.inst.gameState.data[9] += 10;
					GlobalScript.inst.gameState.data[26] -= 2;
				}
			}
		}
		if (GlobalScript.inst.gameState.modifies[7].active)
		{
			if (GlobalScript.inst.gameState.data[26] > 200)
			{
				GlobalScript.inst.gameState.data[26]--;
			}
			if (GlobalScript.inst.gameState.data[4] > 800)
			{
				GlobalScript.inst.gameState.data[4] -= 3;
			}
			if (GlobalScript.inst.gameState.empires[0].relations < 400)
			{
				GlobalScript.inst.gameState.empires[0].relations += GlobalScript.inst.gameState.empires[0].relations / 100;
			}
			if (GlobalScript.inst.gameState.data[12] < 500)
			{
				GlobalScript.inst.gameState.data[12] += 3;
			}
			else if (GlobalScript.inst.gameState.data[68] < 500)
			{
				GlobalScript.inst.gameState.data[68] += 3;
			}
			if (GlobalScript.inst.gameState.data[57] <= 400)
			{
				GlobalScript.inst.gameState.data[57] += 3;
			}
			if (GlobalScript.inst.gameState.data[14] != 3 || GlobalScript.inst.gameState.leader.traits[1] != 5 || GlobalScript.inst.gameState.leader.traits[0] == 0 || GlobalScript.inst.gameState.data[89] < 3 || GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.allcountries[1].isOVD || GlobalScript.inst.gameState.allcountries[1].okb)
			{
				GlobalScript.inst.gameState.modifies[7].active = false;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[668] == 2)
			{
				GlobalScript.inst.old_modify_desc[7] = " 如 果 腐 败>20 ， 则-0.1 腐 败| 如 果 自 由 化>80 ， 则-0.3 自 由 化| 如 果 工 业<50 ， 则+0.3 工 业| 如 果 服 务 业<50 ， 则+0.3 服 务 业| 如 果 与 美 国 关 系<40 ， 则 与 美 国 关 系 ：+1%| 如 果 凝 聚 力<40 ， 则+0.3 凝 聚 力 |<color=red> 难 以 忘 却 的 伤 痕</color>  党 内 团 结 度-0.5 ， 人 民 支 持 度+0.5 ， 思 想 自 由 化+1 ， 改 革 力 量+1 ， 自 由 力 量+1 ， 极 左 力 量-1";
			}
		}
		else if (GlobalScript.inst.gameState.data[14] == 3 && GlobalScript.inst.gameState.leader.traits[1] == 5 && GlobalScript.inst.gameState.leader.traits[0] > 0 && GlobalScript.inst.gameState.data[89] >= 3 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].isOVD && !GlobalScript.inst.gameState.allcountries[1].okb)
		{
			GlobalScript.inst.gameState.modifies[7].active = true;
		}
		if (GlobalScript.inst.gameState.modifies[8].active)
		{
			if (!GlobalScript.inst.gameState.allcountries[1].econ)
			{
				GlobalScript.inst.gameState.modifies[8].active = false;
			}
			GlobalScript.inst.gameState.empires[0].relations += 2;
			GlobalScript.inst.gameState.empires[1].relations += 2;
			GlobalScript.inst.gameState.data[4] -= 10;
			if (GlobalScript.inst.gameState.allcountries[21].prcinfl != 0)
			{
				GlobalScript.inst.gameState.data[8] -= 3;
				GlobalScript.inst.gameState.data[11] += 4;
				GlobalScript.inst.gameState.data[3] += 5;
				GlobalScript.inst.gameState.data[12] += 3;
			}
			if (GlobalScript.inst.gameState.allcountries[0].prcinfl != 0)
			{
				int num20 = 0;
				for (int j = 0; j < GlobalScript.inst.gameState.allcountries.Length; j++)
				{
					switch (j)
					{
					case 0:
					case 16:
					case 17:
					case 21:
					case 26:
					case 27:
					case 28:
					case 29:
					case 39:
					case 45:
					case 84:
					case 85:
					case 86:
					case 87:
					case 88:
					case 89:
					case 90:
					case 91:
					case 92:
						num20++;
						break;
					}
				}
				GlobalScript.inst.gameState.data[8] += num20;
				GlobalScript.inst.gameState.allcountries[0].prcinfl--;
			}
			GlobalScript.inst.old_modify_desc[8] = " 与 美 国 关 系+0.2 ， 与 苏 联 关 系+0.2 ，| 思 想 自 由 化-1";
			if (GlobalScript.inst.gameState.allcountries[16].prcinfl != 0)
			{
				GlobalScript.inst.old_modify_desc[8] += "<color=red>| 现 代 化 的 机 械 陆 军 ：</color>| 军 力+0.5 ， 特 工 网 络 + 0.3 ， 干 涉 点 数 +1.0 ， 预 算-0.8 ， 科 技 点 数-0.2 ， 人 民 支 持 度+1.0";
			}
			if (GlobalScript.inst.gameState.allcountries[21].prcinfl != 0)
			{
				GlobalScript.inst.old_modify_desc[8] += "<color=red>| 与 法 国 的 电 子 工 业 合 作 ：</color>|预 算-0.3 ， 科 技 点 数+0.4 ， 人 民 支 持 度+0.5 ， 工 业+0.3";
			}
			if (GlobalScript.inst.gameState.allcountries[0].prcinfl != 0)
			{
				GlobalScript.inst.old_modify_desc[8] += "<color=red>| 加 深 与 欧 洲 国 家 贸 易 ：</color>| 与 欧 洲 国 家 的 贸 易 额 外 获 得 0.1 预算";
			}
		}
		else if (GlobalScript.inst.gameState.allcountries[1].econ)
		{
			GlobalScript.inst.gameState.modifies[8].active = true;
		}
		if (GlobalScript.inst.gameState.modifies[9].active)
		{
			if (GlobalScript.inst.gameState.data[66] <= 0)
			{
				GlobalScript.inst.gameState.modifies[9].active = false;
			}
			GlobalScript.inst.gameState.data[57] -= 10;
			if (GlobalScript.inst.gameState.data[3] - ch_support > 0)
			{
				GlobalScript.inst.gameState.data[3] -= (GlobalScript.inst.gameState.data[3] - ch_support) / 2;
			}
			if (ch_lib - GlobalScript.inst.gameState.data[4] > 0)
			{
				GlobalScript.inst.gameState.data[4] += (ch_lib - GlobalScript.inst.gameState.data[4]) / 2;
			}
		}
		else if (GlobalScript.inst.gameState.data[66] > 0)
		{
			GlobalScript.inst.gameState.modifies[9].active = true;
		}
		if (GlobalScript.inst.gameState.modifies[10].active)
		{
			if (GlobalScript.inst.gameState.data[67] <= 0)
			{
				GlobalScript.inst.gameState.modifies[10].active = false;
			}
			GlobalScript.inst.gameState.data[57] -= 10;
			if (GlobalScript.inst.gameState.data[3] - ch_support > 0)
			{
				GlobalScript.inst.gameState.data[3] -= (GlobalScript.inst.gameState.data[3] - ch_support) / 4;
			}
			if (ch_lib - GlobalScript.inst.gameState.data[4] > 0)
			{
				GlobalScript.inst.gameState.data[4] += (ch_lib - GlobalScript.inst.gameState.data[4]) / 4;
			}
		}
		else if (GlobalScript.inst.gameState.data[67] > 0)
		{
			GlobalScript.inst.gameState.modifies[10].active = true;
		}
		if (GlobalScript.inst.gameState.modifies[11].active)
		{
			GlobalScript.inst.gameState.data[12] += 50;
			GlobalScript.inst.gameState.data[68] += 50;
			GlobalScript.inst.gameState.data[13] += 50;
			GlobalScript.inst.gameState.data[8] += 50;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[5] += 10;
			GlobalScript.inst.gameState.data[26] -= 10;
			GlobalScript.inst.gameState.doctr[10] = GlobalScript.inst.new_events_text[360];
			GlobalScript.inst.gameState.doctr[11] = GlobalScript.inst.new_events_text[361];
			GlobalScript.inst.old_modify_desc[11] = " 农 业 、 工 业 和 服 务 业+5.0| 预 算+5.0 ， 生 活 水 平+1.0 ， 腐 败-1.0| 党 内 支 持 度-5.0| 每 两 周";
		}
		if (GlobalScript.inst.gameState.modifies[12].active)
		{
			if ((GlobalScript.inst.gameState.data[12] + GlobalScript.inst.gameState.data[13] + GlobalScript.inst.gameState.data[68] - GlobalScript.inst.gameState.data[26]) / 3 >= 500 || GlobalScript.inst.gameState.data[21] < 1980 || GlobalScript.inst.gameState.data[16] >= 14)
			{
				GlobalScript.inst.gameState.modifies[12].active = false;
			}
			GlobalScript.inst.gameState.data[9] -= 10;
			GlobalScript.inst.gameState.data[57] -= 3;
		}
		else if ((GlobalScript.inst.gameState.data[12] + GlobalScript.inst.gameState.data[13] + GlobalScript.inst.gameState.data[68] - GlobalScript.inst.gameState.data[26]) / 3 < 500 && GlobalScript.inst.gameState.data[21] >= 1980 && GlobalScript.inst.gameState.data[16] < 14)
		{
			GlobalScript.inst.gameState.modifies[12].active = true;
		}
		if (GlobalScript.inst.gameState.modifies[13].active)
		{
			if (GlobalScript.inst.gameState.data[16] < 13 || GlobalScript.inst.gameState.data[5] < 500 || (GlobalScript.inst.gameState.data[68] < 700 && GlobalScript.inst.gameState.data[5] < 700))
			{
				GlobalScript.inst.gameState.modifies[13].active = false;
			}
			if (GlobalScript.inst.gameState.data[16] == 13)
			{
				GlobalScript.inst.gameState.data[8] += GlobalScript.inst.gameState.data[5] / 500;
				GlobalScript.inst.gameState.data[68] += 2;
			}
			else if (GlobalScript.inst.gameState.data[16] == 14)
			{
				GlobalScript.inst.gameState.data[8] += GlobalScript.inst.gameState.data[5] / 330;
				GlobalScript.inst.gameState.data[68] += 4;
			}
			else if (GlobalScript.inst.gameState.data[16] == 15)
			{
				GlobalScript.inst.gameState.data[8] += GlobalScript.inst.gameState.data[5] / 250;
				GlobalScript.inst.gameState.data[68] += 3;
			}
		}
		else if (GlobalScript.inst.gameState.data[16] >= 13 && (GlobalScript.inst.gameState.data[5] >= 700 || (GlobalScript.inst.gameState.data[68] >= 700 && GlobalScript.inst.gameState.data[5] > 500)))
		{
			GlobalScript.inst.gameState.modifies[13].active = true;
		}
		if (GlobalScript.inst.gameState.modifies[14].active && (GlobalScript.inst.gameState.politics[12].name_1 != 13 || GlobalScript.inst.gameState.politics[12].name_2 != 13 || GlobalScript.inst.gameState.politics[12].traits[0] != 2 || GlobalScript.inst.gameState.politics[12].traits[1] != 5 || GlobalScript.inst.gameState.politics[12].traits[2] != 11))
		{
			GlobalScript.inst.gameState.modifies[14].active = false;
		}
		if (GlobalScript.inst.gameState.modifies[15].active)
		{
			if (!GlobalScript.inst.gameState.event_done[53] || GlobalScript.inst.gameState.resultOfEvents[53] == 0)
			{
				GlobalScript.inst.gameState.data[13]++;
				GlobalScript.inst.gameState.data[12]++;
				GlobalScript.inst.gameState.data[5] += 2;
				GlobalScript.inst.gameState.data[8]++;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[53] == 1)
			{
				GlobalScript.inst.gameState.data[8] += 4;
				GlobalScript.inst.gameState.data[26] += 3;
				if (GlobalScript.inst.gameState.data[80] <= 200)
				{
					GlobalScript.inst.gameState.data[13] -= 2;
					GlobalScript.inst.gameState.data[5] -= 2;
					GlobalScript.inst.gameState.data[68] -= 2;
				}
				if (GlobalScript.inst.gameState.data[80] > 200)
				{
					GlobalScript.inst.gameState.data[13] += 2;
					GlobalScript.inst.gameState.data[5] += 2;
					GlobalScript.inst.gameState.data[68] += 2;
				}
			}
			if (GlobalScript.inst.gameState.resultOfEvents[53] == 2)
			{
				GlobalScript.inst.gameState.data[8] += 10;
				GlobalScript.inst.gameState.data[26] += 4;
				GlobalScript.inst.gameState.data[108] += 4;
				GlobalScript.inst.gameState.data[13] -= 4;
				GlobalScript.inst.gameState.data[5] -= 4;
				GlobalScript.inst.gameState.data[68] += 2;
			}
			if (GlobalScript.inst.gameState.resultOfEvents[53] == 3)
			{
				GlobalScript.inst.gameState.data[13] += 4;
				GlobalScript.inst.gameState.data[12] += 4;
				GlobalScript.inst.gameState.data[5] += 4;
				GlobalScript.inst.gameState.data[8] += 2;
			}
			if (GlobalScript.inst.gameState.science[3])
			{
				GlobalScript.inst.gameState.data[13] += 6;
				GlobalScript.inst.gameState.data[12] += 4;
			}
			if (GlobalScript.inst.gameState.science[6])
			{
				GlobalScript.inst.gameState.data[13] += 3;
				GlobalScript.inst.gameState.data[5] += 4;
			}
			if (GlobalScript.inst.gameState.science[7])
			{
				GlobalScript.inst.gameState.data[13] += 2;
				GlobalScript.inst.gameState.data[12] += 2;
				GlobalScript.inst.gameState.data[5] += 4;
				GlobalScript.inst.gameState.data[8] += 3;
			}
		}
		if (GlobalScript.inst.gameState.modifies[16].active)
		{
			if (GlobalScript.inst.gameState.empires[1].relations >= 500)
			{
				GlobalScript.inst.gameState.modifies[16].active = false;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[8] != 4)
			{
				GlobalScript.inst.gameState.data[8] -= (500 - GlobalScript.inst.gameState.empires[1].relations) / 50 * (GlobalScript.inst.gameState.empires[1].power / 500);
				GlobalScript.inst.gameState.data[9] -= (500 - GlobalScript.inst.gameState.empires[1].relations) / 100 * (GlobalScript.inst.gameState.empires[1].power / 500);
			}
			else
			{
				GlobalScript.inst.gameState.data[8] += (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[1].power) / 50;
				GlobalScript.inst.gameState.data[9] += (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[1].power) / 100;
				GlobalScript.inst.gameState.empires[1].money -= (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[1].power) / 50;
				GlobalScript.inst.gameState.empires[1].power -= (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[1].power) / 100;
			}
		}
		if (GlobalScript.inst.gameState.modifies[17].active)
		{
			if (GlobalScript.inst.gameState.empires[0].relations >= 500)
			{
				GlobalScript.inst.gameState.modifies[17].active = false;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[7] != 4)
			{
				GlobalScript.inst.gameState.data[8] -= (500 - GlobalScript.inst.gameState.empires[0].relations) / 50 * (GlobalScript.inst.gameState.empires[1].power / 1000);
				GlobalScript.inst.gameState.data[9] -= (500 - GlobalScript.inst.gameState.empires[0].relations) / 100 * (GlobalScript.inst.gameState.empires[1].power / 1000);
			}
			else
			{
				GlobalScript.inst.gameState.data[8] += (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[0].power) / 50;
				GlobalScript.inst.gameState.data[9] += (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[0].power) / 100;
				GlobalScript.inst.gameState.empires[0].money -= (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[0].power) / 50;
				GlobalScript.inst.gameState.empires[0].power -= (GlobalScript.inst.gameState.influencePRC - GlobalScript.inst.gameState.empires[0].power) / 100;
			}
		}
		if (GlobalScript.inst.gameState.modifies[18].active)
		{
			GlobalScript.inst.gameState.data[4] += 2;
			GlobalScript.inst.gameState.data[9] += 2;
		}
		else if (GlobalScript.inst.gameState.modifies[19].active)
		{
			GlobalScript.inst.gameState.data[57] -= 2;
			GlobalScript.inst.gameState.empires[0].relations += 5;
			GlobalScript.inst.gameState.data[4] += 2;
			GlobalScript.inst.gameState.data[8] += 2;
		}
		else if (GlobalScript.inst.gameState.modifies[20].active)
		{
			GlobalScript.inst.gameState.empires[0].relations -= 5;
			GlobalScript.inst.gameState.empires[1].relations += 2;
			GlobalScript.inst.gameState.data[22] -= 2;
			GlobalScript.inst.gameState.data[8] += 2;
		}
		if (GlobalScript.inst.gameState.modifies[21].active)
		{
			GlobalScript.inst.gameState.empires[1].relations += 2;
			GlobalScript.inst.gameState.empires[0].relations -= 2;
			GlobalScript.inst.gameState.data[22] -= 2;
			GlobalScript.inst.gameState.data[11] += 5;
		}
		else if (GlobalScript.inst.gameState.modifies[22].active)
		{
			GlobalScript.inst.gameState.data[4] += 2;
			GlobalScript.inst.gameState.empires[1].relations -= 5;
			GlobalScript.inst.gameState.data[9] += 2;
			GlobalScript.inst.gameState.data[57] += 2;
		}
		else if (GlobalScript.inst.gameState.modifies[23].active)
		{
			GlobalScript.inst.gameState.empires[0].relations += 5;
			GlobalScript.inst.gameState.data[57] -= 2;
			GlobalScript.inst.gameState.data[4] += 2;
			GlobalScript.inst.gameState.data[8] += 2;
		}
		if (GlobalScript.inst.gameState.modifies[24].active)
		{
			GlobalScript.inst.gameState.data[1] += 2;
			GlobalScript.inst.gameState.data[4] += 2;
			GlobalScript.inst.gameState.data[8] += 2;
		}
		else if (GlobalScript.inst.gameState.modifies[25].active)
		{
			GlobalScript.inst.gameState.data[11] += 2;
			GlobalScript.inst.gameState.data[3] -= 2;
			GlobalScript.inst.gameState.data[4] -= 2;
			GlobalScript.inst.gameState.data[26] -= 2;
			GlobalScript.inst.gameState.data[8] -= 3;
		}
		else if (GlobalScript.inst.gameState.modifies[26].active)
		{
			GlobalScript.inst.gameState.data[1] += 5;
			GlobalScript.inst.gameState.data[3] -= 5;
			GlobalScript.inst.gameState.data[4] -= 5;
			GlobalScript.inst.gameState.data[26] -= 5;
			GlobalScript.inst.gameState.data[5] -= 5;
		}
		else if (GlobalScript.inst.gameState.modifies[27].active)
		{
			GlobalScript.inst.gameState.data[22] += 5;
			GlobalScript.inst.gameState.data[3] -= 2;
			GlobalScript.inst.gameState.data[26] -= 2;
			GlobalScript.inst.gameState.data[8] -= 2;
		}
		if (GlobalScript.inst.gameState.modifies[28].active)
		{
			if (GlobalScript.inst.gameState.event_done[326] && GlobalScript.inst.gameState.resultOfEvents[326] == 0 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[50] <= 25 && GlobalScript.inst.gameState.data[15] == 6 && GlobalScript.inst.gameState.data[16] <= 11)
			{
				GlobalScript.inst.old_modify_texts[28] = "无 产 阶 级 宪 法";
				GlobalScript.inst.old_modify_desc[28] = " 极 左 派+3 ， 极 左 派 力 量+3 ， 党 内 支 持 度-0.5 ， 人 民 支 持 度+1.5 ， 思 想 自 由 化-1.5 ， 腐 败-0.2 ， 预 算+0.3 ， 特 工 网 络+0.3";
				GlobalScript.inst.gameState.party_ideology[0] += 3;
				GlobalScript.inst.gameState.data[1] -= 5;
				GlobalScript.inst.gameState.data[3] += 15;
				GlobalScript.inst.gameState.data[4] -= 15;
				GlobalScript.inst.gameState.data[26] -= 5;
				GlobalScript.inst.gameState.data[8] += 3;
				GlobalScript.inst.gameState.data[9] += 3;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic4 in politics)
				{
					if (politic4.traits[0] == 0)
					{
						politic4.power += 30;
						politic4.loyality += 30;
					}
				}
			}
			else
			{
				GlobalScript.inst.gameState.party_ideology[0]++;
				GlobalScript.inst.gameState.party_ideology[1]++;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic5 in politics)
				{
					if (politic5.traits[0] == 0)
					{
						politic5.power += 10;
						politic5.loyality += 10;
					}
					if (politic5.traits[0] == 20)
					{
						politic5.power += 10;
						politic5.loyality += 10;
					}
				}
				GlobalScript.inst.gameState.data[1] -= 2;
				GlobalScript.inst.gameState.data[3] += 2;
				GlobalScript.inst.gameState.data[4] -= 2;
				GlobalScript.inst.gameState.data[26] -= 2;
				GlobalScript.inst.gameState.data[9] += 2;
				GlobalScript.inst.old_modify_texts[28] = "75 宪 法";
				GlobalScript.inst.old_modify_desc[28] = " 极 左 派 、 保 守 派+1 ， 极 左 派 、 保 守 派 力 量+1 ， 党 内 支 持 度-0.2 ， 人 民 支 持 度+0.2 ， 思 想 自 由 化-0.2 ， 腐 败-0.2 ， 特 工 网 络+0.2";
				if (!GlobalScript.inst.gameState.modifies[6].active)
				{
					GlobalScript.inst.gameState.modifies[28].active = false;
				}
			}
		}
		else if (GlobalScript.inst.gameState.modifies[29].active)
		{
			GlobalScript.inst.gameState.party_ideology[0]--;
			GlobalScript.inst.gameState.party_ideology[3]--;
			GlobalScript.inst.gameState.party_ideology[4]--;
			GlobalScript.inst.gameState.data[68] += 2;
			GlobalScript.inst.gameState.data[12] += 2;
			GlobalScript.inst.gameState.data[5] += 5;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic6 in politics)
			{
				if (politic6.traits[0] != 1)
				{
					politic6.power -= 5;
				}
			}
			if (GlobalScript.inst.gameState.data[15] > 7)
			{
				GlobalScript.inst.gameState.modifies[29].active = false;
				GlobalScript.inst.gameState.modifies[28].active = true;
			}
		}
		else if (GlobalScript.inst.gameState.modifies[30].active)
		{
			GlobalScript.inst.gameState.party_ideology[3]++;
			GlobalScript.inst.gameState.data[8] += 5;
			GlobalScript.inst.gameState.data[6] -= 2;
			GlobalScript.inst.gameState.empires[0].relations += 5;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic7 in politics)
			{
				if (politic7.traits[0] == 2)
				{
					politic7.power += 10;
				}
			}
			if (GlobalScript.inst.gameState.data[16] < 13)
			{
				GlobalScript.inst.gameState.modifies[30].active = false;
				GlobalScript.inst.gameState.modifies[28].active = true;
			}
		}
		else if (GlobalScript.inst.gameState.modifies[31].active)
		{
			GlobalScript.inst.gameState.party_ideology[4]++;
			GlobalScript.inst.gameState.empires[0].relations += 5;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic8 in politics)
			{
				if (politic8.traits[0] == 3)
				{
					politic8.power += 10;
				}
			}
			GlobalScript.inst.gameState.data[26] -= 2;
			GlobalScript.inst.gameState.data[108] -= 2;
			GlobalScript.inst.gameState.data[6] -= 2;
			if (GlobalScript.inst.gameState.data[16] < 14 || GlobalScript.inst.gameState.data[17] < 17)
			{
				GlobalScript.inst.gameState.modifies[31].active = false;
				GlobalScript.inst.gameState.modifies[28].active = true;
			}
		}
		if (GlobalScript.inst.gameState.modifies[32].active)
		{
			GlobalScript.inst.gameState.data[3] -= 5;
			GlobalScript.inst.gameState.data[4] -= 5;
			GlobalScript.inst.gameState.data[9] += 2;
			GlobalScript.inst.gameState.data[22] += 2;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic9 in politics)
			{
				if (politic9.traits[0] == 0)
				{
					politic9.power += 10;
				}
				else
				{
					politic9.power -= 5;
				}
			}
		}
		if (GlobalScript.inst.gameState.modifies[33].active)
		{
			GlobalScript.inst.gameState.data[3] += 2;
			GlobalScript.inst.gameState.data[5] += 2;
			GlobalScript.inst.gameState.data[12] -= 2;
			GlobalScript.inst.gameState.data[68] += 2;
			GlobalScript.inst.gameState.data[22] -= 5;
		}
		if (GlobalScript.inst.gameState.modifies[34].active)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[320] == 1)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>三 北 防 护 林 ：</color>| 农 业+0.7 ， 工 业+0.2 ， 预 算-0.3 ， 统 一 度+0.2 ， 人 民 支 持 度+0.1 ";
				GlobalScript.inst.gameState.data[13] += 7;
				GlobalScript.inst.gameState.data[12] += 2;
				GlobalScript.inst.gameState.data[8] -= 3;
				GlobalScript.inst.gameState.data[31] += 2;
				GlobalScript.inst.gameState.data[3]++;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[320] == 2)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>南 水 北 调 工 程 ：</color>| 农 业+0.3 ， 工 业+0.5 ， 预 算-0.5 ， 凝 聚 力+0.2";
				GlobalScript.inst.gameState.data[13] += 3;
				GlobalScript.inst.gameState.data[12] += 5;
				GlobalScript.inst.gameState.data[8] -= 5;
				GlobalScript.inst.gameState.data[57] += 2;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[320] == 3)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>三 北 防 护 林 ：</color>| 农 业+0.7 ， 工 业+0.2 ， 预 算-0.3 ， 统 一 度+0.2 ， 人 民 支 持 度+0.1 |<color=red>南 水 北 调 工 程 ：</color>| 农 业+0.3 ， 工 业+0.5 ， 预 算-0.5 ， 凝 聚 力+0.2";
				GlobalScript.inst.gameState.data[13] += 7;
				GlobalScript.inst.gameState.data[12] += 2;
				GlobalScript.inst.gameState.data[8] -= 3;
				GlobalScript.inst.gameState.data[31] += 2;
				GlobalScript.inst.gameState.data[3]++;
				GlobalScript.inst.gameState.data[13] += 3;
				GlobalScript.inst.gameState.data[12] += 5;
				GlobalScript.inst.gameState.data[8] -= 5;
				GlobalScript.inst.gameState.data[57] += 2;
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[320] == 4)
			{
				GlobalScript.inst.old_modify_desc[34] = "<color=red>江 淮 运 河 ：</color>| 服 务 业+0.1 ， 工 业+0.1 ， 预 算+0.2";
				GlobalScript.inst.gameState.data[68]++;
				GlobalScript.inst.gameState.data[12]++;
				GlobalScript.inst.gameState.data[8] += 2;
			}
		}
		if (GlobalScript.inst.gameState.modifies[35].active)
		{
			GlobalScript.inst.gameState.data[8] -= 5;
			GlobalScript.inst.gameState.data[12] += 5;
			GlobalScript.inst.gameState.data[5] += 5;
			GlobalScript.inst.gameState.data[57] += 2;
		}
		if (GlobalScript.inst.gameState.modifies[36].active)
		{
			GlobalScript.inst.gameState.data[11] += 5;
			GlobalScript.inst.gameState.empires[0].power += 5;
			GlobalScript.inst.gameState.empires[1].power += 5;
		}
		if (GlobalScript.inst.gameState.modifies[37].active)
		{
			GlobalScript.inst.gameState.data[26] -= 2;
			GlobalScript.inst.gameState.data[68] += 2;
			GlobalScript.inst.gameState.data[5] += 5;
			GlobalScript.inst.gameState.data[4] += 5;
		}
		if (GlobalScript.inst.gameState.modifies[38].active)
		{
			GlobalScript.inst.gameState.data[1] += 5;
			GlobalScript.inst.gameState.data[6]++;
			GlobalScript.inst.gameState.data[31]++;
			if (GlobalScript.inst.gameState.leader.name_1 != 32 || GlobalScript.inst.gameState.leader.name_2 != 47)
			{
				GlobalScript.inst.gameState.modifies[38].active = false;
			}
		}
		if (GlobalScript.inst.gameState.modifies[39].active)
		{
			if (GlobalScript.inst.gameState.empires[0].relations < 150)
			{
				GlobalScript.inst.gameState.empires[0].relations = 150;
			}
			GlobalScript.inst.gameState.empires[0].power -= 5;
			GlobalScript.inst.gameState.empires[1].relations -= 5;
			GlobalScript.inst.gameState.data[36] += 5;
		}
		if (GlobalScript.inst.gameState.modifies[40].active)
		{
			if (GlobalScript.inst.gameState.data[12] > 150)
			{
				GlobalScript.inst.gameState.data[12] = 150;
			}
			if (GlobalScript.inst.gameState.data[22] > 2000)
			{
				GlobalScript.inst.gameState.data[22] = 2000;
			}
			GlobalScript.inst.gameState.party_ideology[0] = 0;
			GlobalScript.inst.gameState.data[31] += 5;
			GlobalScript.inst.gameState.data[57] += 5;
			GlobalScript.inst.gameState.data[13] += 2;
			GlobalScript.inst.gameState.data[68] += 2;
			GlobalScript.inst.gameState.data[1] -= 5;
			GlobalScript.inst.gameState.data[26] -= 5;
		}
		if (GlobalScript.inst.gameState.modifies[41].active)
		{
			GlobalScript.inst.gameState.party_ideology[3]++;
			GlobalScript.inst.gameState.data[9] += 10;
			GlobalScript.inst.gameState.empires[0].power++;
			GlobalScript.inst.gameState.party_ideology[4]++;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic10 in politics)
			{
				if (politic10.traits[0] == 2)
				{
					politic10.power += 10;
				}
				if (politic10.traits[0] == 3)
				{
					politic10.power += 10;
				}
			}
		}
		if (GlobalScript.inst.gameState.modifies[42].active)
		{
			if (GlobalScript.inst.gameState.data[54] > 39 && !GlobalScript.inst.gameState.modifies[17].active && GlobalScript.inst.gameState.allcountries[21].Torg)
			{
				GlobalScript.inst.gameState.empires[0].relations += 4;
				GlobalScript.inst.gameState.data[8] += 2;
				GlobalScript.inst.gameState.data[6]--;
			}
			GlobalScript.inst.gameState.empires[0].power++;
		}
		if (GlobalScript.inst.gameState.modifies[43].active && GlobalScript.inst.gameState.allcountries[21].Torg && !GlobalScript.inst.gameState.allcountries[1].isSEATO && !GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.allcountries[1].isOVD && (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2 || GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3))
		{
			GlobalScript.inst.gameState.data[8] += 3;
			GlobalScript.inst.gameState.data[11] += 4;
		}
		if (GlobalScript.inst.gameState.modifies[44].active)
		{
			if (!GlobalScript.inst.gameState.YugAgree)
			{
				if (GlobalScript.inst.gameState.allcountries[21].Torg && GlobalScript.inst.gameState.data[52] < 36 && !GlobalScript.inst.gameState.modifies[16].active)
				{
					GlobalScript.inst.gameState.empires[1].relations += 4;
					GlobalScript.inst.gameState.data[8] += 2;
					GlobalScript.inst.gameState.data[11] += 2;
				}
			}
			else
			{
				if (GlobalScript.inst.gameState.allcountries[21].Torg && GlobalScript.inst.gameState.data[14] < 2 && !GlobalScript.inst.gameState.modifies[16].active)
				{
					GlobalScript.inst.gameState.empires[1].relations += 5;
					GlobalScript.inst.gameState.data[8] += 6;
					GlobalScript.inst.gameState.data[11] += 6;
				}
				GlobalScript.inst.old_modify_desc[44] = " 在 党 内 路 线 比 “ 中 式 社 会 主 义 ” 更 激 进 ， 未 遭 受 苏 联 禁 运 且 与 法 国 建 立 贸 易 关 系 时 ：|<color=lime>|与 苏 联 关 系+0.5;|预 算+0.3;|科 研 点 数+0.3|</color>||<color=#9370DB>苏 联 影 响+0.1.</color>";
			}
			GlobalScript.inst.gameState.empires[1].power++;
		}
		if (GlobalScript.inst.gameState.modifies[44].active && GlobalScript.inst.gameState.allcountries[21].Torg && GlobalScript.inst.gameState.allcountries[1].okb && GlobalScript.inst.gameState.data[7] >= 500)
		{
			GlobalScript.inst.gameState.data[0] += 5;
			GlobalScript.inst.gameState.data[8] += 2;
			GlobalScript.inst.gameState.empires[0].relations -= 3;
			GlobalScript.inst.gameState.empires[1].relations -= 3;
			GlobalScript.inst.gameState.empires[0].power--;
			GlobalScript.inst.gameState.empires[1].power--;
		}
		if (GlobalScript.inst.gameState.modifies[46].active)
		{
			GlobalScript.inst.gameState.data[8] += 6;
			GlobalScript.inst.gameState.data[22] += 5;
			GlobalScript.inst.gameState.data[9] += 5;
			GlobalScript.inst.gameState.empires[0].relations -= 5;
			GlobalScript.inst.gameState.empires[1].relations -= 5;
			GlobalScript.inst.gameState.empires[0].power--;
			GlobalScript.inst.gameState.empires[1].power--;
		}
		if (GlobalScript.inst.gameState.modifies[47].active)
		{
			int num21 = 0;
			for (int k = 0; k < GlobalScript.inst.gameState.allcountries.Length; k++)
			{
				if (GlobalScript.inst.gameState.allcountries[k].okb)
				{
					num21++;
				}
			}
			if (num21 < 7)
			{
				GlobalScript.inst.gameState.data[8] -= 10;
			}
			else if (num21 < 14)
			{
				GlobalScript.inst.gameState.data[8] -= 20;
			}
			else
			{
				GlobalScript.inst.gameState.data[8] -= 30;
			}
			GlobalScript.inst.gameState.data[9] += num21 * 2;
		}
		if (GlobalScript.inst.gameState.modifies[48].active)
		{
			int num22 = 0;
			for (int l = 0; l < GlobalScript.inst.gameState.allcountries.Length; l++)
			{
				if (GlobalScript.inst.gameState.allcountries[l].okb)
				{
					num22++;
				}
			}
			if (num22 < 7)
			{
				GlobalScript.inst.gameState.data[8] -= 10;
			}
			else if (num22 < 14)
			{
				GlobalScript.inst.gameState.data[8] -= 20;
			}
			else
			{
				GlobalScript.inst.gameState.data[8] -= 30;
			}
			GlobalScript.inst.gameState.data[22] += num22;
		}
		if (GlobalScript.inst.gameState.modifies[49].active)
		{
			GlobalScript.inst.gameState.data[0] += 30;
			GlobalScript.inst.gameState.data[9] += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 20;
			GlobalScript.inst.gameState.empires[1].relations -= 20;
		}
		if (GlobalScript.inst.gameState.modifies[51].active)
		{
			GlobalScript.inst.gameState.OilEat = (float)GlobalScript.inst.gameState.data[12] * 0.4f + ((GlobalScript.inst.gameState.data[12] >= 500) ? ((float)(GlobalScript.inst.gameState.data[12] - 499) * 0.4f) : 0f) + ((GlobalScript.inst.gameState.data[12] >= 750) ? ((float)(GlobalScript.inst.gameState.data[12] - 749) * 0.4f) : 0f);
			GlobalScript.inst.gameState.OilEat += ((GlobalScript.inst.gameState.data[13] >= 250) ? ((float)(GlobalScript.inst.gameState.data[13] - 249) * 0.35f) : 0f) + ((GlobalScript.inst.gameState.data[13] >= 500) ? ((float)(GlobalScript.inst.gameState.data[13] - 499) * 0.35f) : 0f) + ((GlobalScript.inst.gameState.data[13] >= 750) ? ((float)(GlobalScript.inst.gameState.data[13] - 749) * 0.35f) : 0f);
			GlobalScript.inst.gameState.OilEat += ((GlobalScript.inst.gameState.data[68] >= 500) ? ((float)(GlobalScript.inst.gameState.data[68] - 499) * 0.34f) : 0f) + ((GlobalScript.inst.gameState.data[68] >= 750) ? ((float)(GlobalScript.inst.gameState.data[68] - 749) * 0.34f) : 0f);
			GlobalScript.inst.gameState.OilEat += ((GlobalScript.inst.gameState.data[22] >= 1000) ? 500f : ((float)GlobalScript.inst.gameState.data[22] * 0.5f));
			GlobalScript.inst.gameState.OilEat += (float)GlobalScript.inst.gameState.data[5] * 0.05f;
			if (GlobalScript.inst.gameState.science[2])
			{
				GlobalScript.inst.gameState.OilEat += 35f;
			}
			if (GlobalScript.inst.gameState.science[3])
			{
				GlobalScript.inst.gameState.OilEat += 30f;
			}
			if (GlobalScript.inst.gameState.science[6])
			{
				GlobalScript.inst.gameState.OilEat += 20f;
			}
			if (GlobalScript.inst.gameState.science[7])
			{
				GlobalScript.inst.gameState.OilEat += 40f;
			}
			if (GlobalScript.inst.gameState.science[8])
			{
				GlobalScript.inst.gameState.OilEat += 25f;
			}
			if (GlobalScript.inst.gameState.science[10])
			{
				GlobalScript.inst.gameState.OilEat -= 20f;
			}
			if (GlobalScript.inst.gameState.science[11])
			{
				GlobalScript.inst.gameState.OilEat -= 35f;
			}
			if (GlobalScript.inst.gameState.science[13])
			{
				GlobalScript.inst.gameState.OilEat -= 60f;
			}
			if (GlobalScript.inst.gameState.science[14])
			{
				GlobalScript.inst.gameState.OilEat -= 60f;
			}
			float num23 = GlobalScript.inst.gameState.data[143];
			if (GlobalScript.inst.gameState.modifies[58].active && !GlobalScript.inst.gameState.modifies[16].active && GlobalScript.inst.gameState.data[153] <= 0)
			{
				num23 -= 15f;
			}
			if (GlobalScript.inst.gameState.allcountries[14].proprc)
			{
				num23 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[8].proprc)
			{
				num23 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[35].proprc)
			{
				num23 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[40].proprc)
			{
				num23 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[30].proprc)
			{
				num23 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[83].proprc)
			{
				num23 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[52].proprc)
			{
				num23 -= 1f;
			}
			if (num23 < 10f)
			{
				num23 = 10f;
			}
			if (GlobalScript.inst.gameState.OilEat - GlobalScript.inst.gameState.OilProd > 0f)
			{
				float num24 = num23 * 7.7f * (GlobalScript.inst.gameState.OilEat - GlobalScript.inst.gameState.OilProd) / 10000f;
				GlobalScript.inst.gameState.data[8] -= (int)num24;
			}
			else
			{
				float num25 = (float)GlobalScript.inst.gameState.data[143] * 7.7f * (GlobalScript.inst.gameState.OilEat - GlobalScript.inst.gameState.OilProd) / 10000f;
				GlobalScript.inst.gameState.data[8] -= (int)num25;
			}
			float num26 = GlobalScript.inst.gameState.data[143];
			if (GlobalScript.inst.gameState.allcountries[14].prosov)
			{
				num26 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[8].prosov)
			{
				num26 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[35].prosov)
			{
				num26 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[40].prosov)
			{
				num26 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[30].prosov)
			{
				num26 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[83].prosov)
			{
				num26 -= 1f;
			}
			if (num26 < 10f)
			{
				num26 = 10f;
			}
			if (GlobalScript.inst.gameState.data[160] > 0)
			{
				float num27 = (float)GlobalScript.inst.gameState.data[143] * 7.7f * (float)GlobalScript.inst.gameState.data[160] / 100000f;
				GlobalScript.inst.gameState.empires[1].money += (int)num27;
			}
			else
			{
				float num28 = num26 * 7.7f * (float)GlobalScript.inst.gameState.data[160] / 100000f;
				GlobalScript.inst.gameState.empires[1].money += (int)num28;
			}
			float num29 = GlobalScript.inst.gameState.data[143];
			if (GlobalScript.inst.gameState.allcountries[14].Vyshi)
			{
				num29 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[8].Vyshi)
			{
				num29 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[35].Vyshi)
			{
				num29 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[40].Vyshi)
			{
				num29 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[30].Vyshi)
			{
				num29 -= 1f;
			}
			if (GlobalScript.inst.gameState.allcountries[83].Vyshi)
			{
				num29 -= 1f;
			}
			if (num29 < 10f)
			{
				num29 = 10f;
			}
			if (GlobalScript.inst.gameState.data[161] > 0)
			{
				float num30 = (float)GlobalScript.inst.gameState.data[143] * 7.7f * (float)GlobalScript.inst.gameState.data[161] / 100000f;
				GlobalScript.inst.gameState.empires[0].money += (int)num30;
			}
			else
			{
				float num31 = num29 * 7.7f * (float)GlobalScript.inst.gameState.data[161] / 100000f;
				GlobalScript.inst.gameState.empires[0].money += (int)num31;
			}
			if (GlobalScript.inst.gameState.data[143] - 50 > 0)
			{
				GlobalScript.inst.gameState.empires[0].power -= (GlobalScript.inst.gameState.data[143] - 10) / 3;
				GlobalScript.inst.gameState.empires[1].power += (GlobalScript.inst.gameState.data[143] - 10) / 3;
			}
			else if (GlobalScript.inst.gameState.data[143] - 20 > 0 && GlobalScript.inst.gameState.data[143] - 50 <= 0)
			{
				GlobalScript.inst.gameState.empires[0].power += (GlobalScript.inst.gameState.data[143] - 10) / 3;
				GlobalScript.inst.gameState.empires[1].power += (GlobalScript.inst.gameState.data[143] - 10) / 3;
			}
			else if (GlobalScript.inst.gameState.data[21] < 1980)
			{
				GlobalScript.inst.gameState.empires[0].power += (GlobalScript.inst.gameState.data[143] - 10) / 2;
				GlobalScript.inst.gameState.empires[1].power -= (GlobalScript.inst.gameState.data[143] - 10) / 2;
			}
			else
			{
				GlobalScript.inst.gameState.empires[0].power += GlobalScript.inst.gameState.data[143] - 10;
				GlobalScript.inst.gameState.empires[1].power -= (GlobalScript.inst.gameState.data[143] - 10) * 2;
			}
		}
		if (GlobalScript.inst.gameState.modifies[53].active)
		{
			if (!GlobalScript.inst.gameState.allcountries[17].parts[0])
			{
				GlobalScript.inst.gameState.party_ideology[0]++;
				GlobalScript.inst.gameState.party_ideology[2]++;
				GlobalScript.inst.gameState.data[9] += 10;
				GlobalScript.inst.gameState.empires[1].power++;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic11 in politics)
				{
					if (politic11.traits[0] == 0)
					{
						politic11.power += 10;
					}
					if (politic11.traits[0] == 1)
					{
						politic11.power += 10;
					}
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[17].parts[0] && GlobalScript.inst.gameState.allcountries[17].proprc && GlobalScript.inst.gameState.allcountries[17].Gosstroy == 1)
			{
				GlobalScript.inst.old_modify_desc[53] = "<color=lime>特 工 网 络+1.5;|</color><color=#9370DB>极 左 派+1;|极 左 派 力 量+1.</color>|";
				GlobalScript.inst.old_modify_texts[53] = " 与 革 命 保 卫 办 公 室 合 作";
				GlobalScript.inst.gameState.party_ideology[0]++;
				GlobalScript.inst.gameState.data[9] += 15;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic12 in politics)
				{
					if (politic12.traits[0] == 0)
					{
						politic12.power += 10;
					}
				}
			}
		}
		if (GlobalScript.inst.gameState.modifies[58].active && GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.data[153] > 0)
		{
			GlobalScript.inst.gameState.data[153]--;
			GlobalScript.inst.gameState.data[8] -= 5;
		}
		if (!GlobalScript.inst.gameState.modifies[59].active && GlobalScript.inst.gameState.allcountries[1].okb)
		{
			GlobalScript.inst.gameState.modifies[59].active = true;
		}
		if (!GlobalScript.inst.gameState.modifies[59].active)
		{
			return;
		}
		int num32 = 0;
		int num33 = 0;
		int num34 = 0;
		if (!GlobalScript.inst.gameState.allcountries[1].okb)
		{
			return;
		}
		for (int m = 0; m < GlobalScript.inst.gameState.allcountries.Length; m++)
		{
			if (GlobalScript.inst.gameState.allcountries[m].okb)
			{
				num32++;
				if (((m > 53 && m < 69) || (m > 105 && m < 109) || (m > 111 && m < 134) || m == 41 || m == 42 || m == 52 || m == 99 || m == 100) && m != 55 && m != 54 && m != 128 && GlobalScript.inst.gameState.allcountries[m].proprc && (GlobalScript.inst.gameState.allcountries[m].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[m].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
				{
					num34++;
				}
			}
			if (GlobalScript.inst.gameState.allcountries[m].oar)
			{
				num33++;
			}
		}
		GlobalScript.inst.old_modify_desc[59] = string.Format("{0}{1}{2}", new object[3]
		{
			GlobalScript.inst.gameState.allcountries[1].okb ? (" 集 体 安 全 联 盟 ：|军 事 力 量+" + num32 * 3 / 10 + "." + Mathf.Abs(num32 * 3 % 10) + " ；特 工 网 络+" + num32 * 2 / 10 + "." + Mathf.Abs(num32 * 2 % 10) + " ；干 涉 点 数+" + num32 / 10 + "." + Mathf.Abs(num32 % 10)) : null,
			(GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0) ? (" |非 洲 联 盟 : |军 事 力 量 +" + num34 * 3 / 10 + "." + Mathf.Abs(num34 * 3 % 10) + " ；特 工 网 络+" + num34 * 2 / 10 + "." + Mathf.Abs(num34 * 2 % 10) + " ；干 涉 点 数+" + num34 / 10 + "." + Mathf.Abs(num34 % 10)) : null,
			(!GlobalScript.inst.gameState.allcountries[30].oar) ? null : ((GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1) ? (" |阿 拉 伯 革 命 同 盟 :| 军 事 力 量 +" + num33 * 3 / 10 + "." + Mathf.Abs(num33 * 3 % 10) + " ；特 工 网 络+" + num33 * 2 / 10 + "." + Mathf.Abs(num33 * 2 % 10) + " ；干 涉 点 数+" + num33 / 10 + "." + Mathf.Abs(num33 % 10)) : (" |阿 拉 伯 联 合 共 和 国 :| 军 事 力 量 +" + num33 * 3 / 10 + "." + Mathf.Abs(num33 * 3 % 10) + " ；特 工 网 络+" + num33 * 2 / 10 + "." + Mathf.Abs(num33 * 2 % 10) + " ；干 涉 点 数+" + num33 / 10 + "." + Mathf.Abs(num33 % 10)))
		});
		if (GlobalScript.inst.gameState.allcountries[1].okb)
		{
			GlobalScript.inst.gameState.data[22] += num32 * 3;
			GlobalScript.inst.gameState.data[9] += num32 * 2;
			GlobalScript.inst.gameState.data[0] += num32;
			if (GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
			{
				GlobalScript.inst.gameState.data[22] += num34 * 3;
				GlobalScript.inst.gameState.data[9] += num34 * 2;
				GlobalScript.inst.gameState.data[0] += num34;
			}
			if (GlobalScript.inst.gameState.allcountries[30].oar)
			{
				GlobalScript.inst.gameState.data[22] += num33 * 3;
				GlobalScript.inst.gameState.data[9] += num33 * 2;
				GlobalScript.inst.gameState.data[0] += num33;
			}
		}
	}
}
