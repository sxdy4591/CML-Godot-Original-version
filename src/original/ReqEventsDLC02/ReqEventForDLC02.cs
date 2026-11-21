namespace ReqEventsDLC02;

public class ReqEventForDLC02
{
	public static bool RequrementsDLC02(ref int this_num_event, GameState a)
	{
		int num = 0;
		Politic[] politics = GlobalScript.inst.gameState.politics;
		foreach (Politic politic in politics)
		{
			if (politic != null)
			{
				if (politic.traits[0] == 0 && ((politic.name_1 == 0 && politic.name_2 == 0) || (politic.name_1 == 3 && politic.name_2 == 3) || (politic.name_1 == 4 && politic.name_2 == 4) || (politic.name_1 == 5 && politic.name_2 == 5) || (politic.name_1 == 1 && politic.name_2 == 41)))
				{
					num++;
				}
				if (politic.name_1 == 13 && politic.name_2 == 13)
				{
					num++;
				}
				if (politic.name_1 == 14 && politic.name_2 == 14)
				{
					num++;
				}
				if (politic.name_1 == 15 && politic.name_2 == 15)
				{
					num++;
				}
				if (politic.name_1 == 16 && politic.name_2 == 16)
				{
					num++;
				}
			}
		}
		if (GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && (GlobalScript.inst.gameState.data[14] >= 4 || GlobalScript.inst.gameState.data[16] >= 14 || GlobalScript.inst.gameState.data[17] >= 19 || GlobalScript.inst.gameState.data[50] > 26 || GlobalScript.inst.gameState.data[15] >= 8) && (!GlobalScript.inst.gameState.event_done[444] || GlobalScript.inst.gameState.resultOfEvents[444] != 0) && !GlobalScript.inst.gameState.event_done[503])
		{
			this_num_event = 438;
			return true;
		}
		if (!a.event_done[32] && !GlobalScript.inst.gameState.ingamewars[22].is_going && GlobalScript.inst.gameState.data[133] != 1 && GlobalScript.inst.gameState.data[130] != 1 && !GlobalScript.inst.gameState.IndOpp && !GlobalScript.inst.gameState.is_gkchp && GlobalScript.inst.gameState.data[133] != 3 && !GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.allcountries[9].isOVD && ((a.data[21] >= 1984 && a.data[20] >= 8 && a.data[19] >= 9) || (a.data[21] >= 1984 && a.data[20] >= 9) || a.data[21] >= 1985))
		{
			this_num_event = 32;
			return true;
		}
		if (!a.event_done[549] && !GlobalScript.inst.gameState.ingamewars[22].is_going && GlobalScript.inst.gameState.data[133] != 1 && GlobalScript.inst.gameState.data[130] != 1 && !GlobalScript.inst.gameState.IndOpp && !GlobalScript.inst.gameState.is_gkchp && GlobalScript.inst.gameState.data[133] != 3 && !GlobalScript.inst.gameState.allcountries[7].isNATO && !GlobalScript.inst.gameState.allcountries[9].isOVD && ((a.data[21] >= 1983 && a.data[20] >= 7 && a.data[19] >= 1) || (a.data[21] >= 1983 && a.data[20] >= 8) || a.data[21] >= 1984))
		{
			this_num_event = 549;
			return true;
		}
		if (!a.event_done[550] && a.data[18] != 20)
		{
			this_num_event = 550;
			return true;
		}
		if (!a.event_done[551] && a.data[130] == 1 && a.completedDecisions[19] && a.data[18] == 20 && a.allcountries[9].puppetOf < 0)
		{
			this_num_event = 551;
			return true;
		}
		if (!a.event_done[552] && a.empires[1].now_leader == 6 && a.empires[1].power <= 100 && ((a.data[21] >= 1985 && a.data[20] >= 4 && a.data[19] >= 1) || (a.data[21] >= 1985 && a.data[20] >= 5) || a.data[21] >= 1986))
		{
			this_num_event = 552;
			return true;
		}
		if (!GlobalScript.inst.gameState.event_done[502] && GlobalScript.inst.gameState.event_done[94] && GlobalScript.inst.gameState.resultOfEvents[94] == 0 && GlobalScript.inst.gameState.data[15] <= 7)
		{
			this_num_event = 502;
			return true;
		}
		if (!a.event_done[379] && !GlobalScript.inst.gameState.event_done[503] && num == 0 && a.leader.name_1 == 2 && a.leader.name_2 == 2 && !a.modifies[3].active && a.resultOfEvents[668] == 3 && a.resultOfEvents[669] == 3)
		{
			this_num_event = 503;
			return true;
		}
		if (!a.event_done[912] && a.event_done[503] && a.resultOfEvents[503] == 0 && a.resultOfEvents[378] == 0 && a.allcountries[10].SubGosstroy == 10 && a.allcountries[10].Torg && a.allcountries[10].puppetOf < 0 && a.leader.name_1 == 2 && a.leader.name_2 == 2 && a.allcountries[5].SubGosstroy == 10 && a.allcountries[5].proprc)
		{
			this_num_event = 912;
			return true;
		}
		if (!a.event_done[913] && a.allcountries[10].SubGosstroy == 19 && a.science[30])
		{
			this_num_event = 913;
			return true;
		}
		if (!a.event_done[643] && a.allcountries[1].SubGosstroy == 19 && GlobalScript.inst.gameState.data[64] != 2 && !GlobalScript.inst.gameState.completedDecisions[7])
		{
			this_num_event = 643;
			return true;
		}
		if (!a.event_done[645] && a.allcountries[5].SubGosstroy == 19 && GlobalScript.inst.gameState.IndOpp)
		{
			this_num_event = 645;
			return true;
		}
		if (!a.event_done[646] && a.data[21] >= 1979)
		{
			this_num_event = 646;
			return true;
		}
		if (!a.event_done[648] && a.data[21] >= 1983 && ((a.resultOfEvents[361] != 2 && a.event_done[361]) || a.resultOfEvents[362] == 1) && a.science[16])
		{
			this_num_event = 648;
			return true;
		}
		if (!a.event_done[504] && GlobalScript.inst.gameState.allcountries[2].SubGosstroy == 3 && ((a.data[21] >= 1985 && a.data[20] >= 12 && a.data[19] >= 1) || (a.data[21] >= 1985 && a.data[20] >= 12) || a.data[21] >= 1986))
		{
			this_num_event = 504;
			return true;
		}
		if (!a.event_done[505] && ((a.data[21] >= 1977 && a.data[20] >= 8 && a.data[19] >= 27) || (a.data[21] >= 1977 && a.data[20] >= 9) || a.data[21] >= 1978))
		{
			this_num_event = 505;
			return true;
		}
		if (!a.event_done[506] && GlobalScript.inst.gameState.allcountries[68].SubGosstroy == 10 && !GlobalScript.inst.gameState.allcountries[68].prosov && !GlobalScript.inst.gameState.allcountries[68].Vyshi && ((a.data[21] >= 1984 && a.data[20] >= 3 && a.data[19] >= 22) || (a.data[21] >= 1984 && a.data[20] >= 4) || a.data[21] >= 1985))
		{
			this_num_event = 506;
			return true;
		}
		if (!a.event_done[507] && ((a.data[21] >= 1977 && a.data[20] >= 1 && a.data[19] >= 15) || (a.data[21] >= 1977 && a.data[20] >= 2) || a.data[21] >= 1978))
		{
			this_num_event = 507;
			return true;
		}
		if (!a.event_done[508] && GlobalScript.inst.gameState.allcountries[62].puppetOf < 0 && ((a.data[21] >= 1982 && a.data[20] >= 2 && a.data[19] >= 1) || (a.data[21] >= 1982 && a.data[20] >= 2) || a.data[21] >= 1983))
		{
			this_num_event = 508;
			return true;
		}
		if (!a.event_done[509] && ((a.data[21] >= 1979 && a.data[20] >= 11 && a.data[19] >= 27) || (a.data[21] >= 1979 && a.data[20] >= 12) || a.data[21] >= 1980))
		{
			this_num_event = 509;
			return true;
		}
		if (!a.event_done[510] && a.event_done[509] && a.resultOfEvents[509] != 0 && a.resultOfEvents[509] != 1 && a.data[21] >= 1982)
		{
			this_num_event = 510;
			return true;
		}
		if (!a.event_done[511] && a.event_done[510] && a.resultOfEvents[509] != 2 && a.resultOfEvents[510] != 1 && ((a.data[21] >= 1983 && a.data[20] >= 4 && a.data[19] >= 1) || (a.data[21] >= 1983 && a.data[20] >= 4) || a.data[21] >= 1984))
		{
			this_num_event = 511;
			return true;
		}
		if (!a.event_done[512] && (a.allcountries[13].SubGosstroy == 15 || a.allcountries[13].SubGosstroy == 10) && ((a.data[21] >= 1981 && a.data[20] >= 8 && a.data[19] >= 18) || (a.data[21] >= 1981 && a.data[20] >= 9) || a.data[21] >= 1982))
		{
			this_num_event = 512;
			return true;
		}
		if (!a.event_done[513] && GlobalScript.inst.gameState.science[18])
		{
			this_num_event = 513;
			return true;
		}
		if (!a.event_done[514] && GlobalScript.inst.gameState.science[23])
		{
			this_num_event = 514;
			return true;
		}
		if (!a.event_done[515] && GlobalScript.inst.gameState.science[23])
		{
			this_num_event = 515;
			return true;
		}
		if (!a.event_done[516] && ((!a.ingamewars[1].is_going && a.event_done[56] && !a.vietnampeace) || (!a.ingamewars[3].is_going && a.event_done[73]) || (a.event_done[378] && a.resultOfEvents[378] == 2 && !a.ingamewars[16].is_going) || (a.allcountries[10].dev == 1 && !a.ingamewars[0].is_going)))
		{
			this_num_event = 516;
			return true;
		}
		if (!a.event_done[517] && GlobalScript.inst.gameState.science[24])
		{
			this_num_event = 517;
			return true;
		}
		if (!a.event_done[518] && a.event_done[517] && a.data[21] >= 1983 && a.data[12] >= 1000 && a.science[16])
		{
			this_num_event = 518;
			return true;
		}
		if (!a.event_done[519] && a.data[12] >= 750 && a.science[24])
		{
			this_num_event = 519;
			return true;
		}
		if (!a.event_done[520] && a.event_done[519] && a.data[12] >= 1000 && a.science[21] && ((a.data[21] >= 1981 && a.data[20] >= 4) || a.data[21] >= 1982))
		{
			this_num_event = 520;
			return true;
		}
		if (!a.event_done[521] && a.data[12] >= 1200 && a.data[21] >= 1984)
		{
			this_num_event = 521;
			return true;
		}
		if (!a.event_done[540] && a.event_done[518])
		{
			this_num_event = 540;
			return true;
		}
		if (!a.event_done[541] && a.relres && a.data[21] <= 1984)
		{
			this_num_event = 541;
			return true;
		}
		if (!a.event_done[542] && a.event_done[541] && a.resultOfEvents[541] == 1 && a.modifies[3].active && ((a.data[21] >= 1985 && a.data[20] >= 5 && a.data[19] >= 4) || (a.data[21] >= 1985 && a.data[20] >= 6) || a.data[21] >= 1986))
		{
			this_num_event = 542;
			return true;
		}
		if (!a.event_done[543] && a.modifies[3].active && a.modifies[6].active && ((a.data[21] >= 1982 && a.data[20] >= 1 && a.data[19] >= 1) || (a.data[21] >= 1982 && a.data[20] >= 1) || a.data[21] >= 1982))
		{
			this_num_event = 543;
			return true;
		}
		if (!a.event_done[544] && a.science[21] && a.science[29] && a.data[12] >= 1100 && a.data[21] >= 1984)
		{
			this_num_event = 544;
			return true;
		}
		if (!a.event_done[545] && a.science[24] && a.data[12] >= 1050 && a.science[16] && a.data[21] >= 1983)
		{
			this_num_event = 545;
			return true;
		}
		if (!a.event_done[522] && ((a.data[21] >= 1976 && a.data[20] >= 12) || a.data[21] >= 1977))
		{
			this_num_event = 522;
			return true;
		}
		if (!a.event_done[523] && ((a.data[21] >= 1977 && a.data[20] >= 6) || a.data[21] >= 1978))
		{
			this_num_event = 523;
			return true;
		}
		if (!a.event_done[524] && ((a.data[21] >= 1978 && a.data[20] >= 3) || a.data[21] >= 1979))
		{
			this_num_event = 524;
			return true;
		}
		if (!a.event_done[525] && a.resultOfEvents[522] == 0 && a.event_done[522] && ((a.data[21] >= 1979 && a.data[20] >= 1) || a.data[21] >= 1980))
		{
			this_num_event = 525;
			return true;
		}
		if (!a.event_done[526] && a.resultOfEvents[522] != 0 && a.event_done[522] && ((a.data[21] >= 1979 && a.data[20] >= 1) || a.data[21] >= 1980))
		{
			this_num_event = 526;
			return true;
		}
		if (!a.event_done[527] && ((a.resultOfEvents[522] != 0 && a.event_done[522]) || (a.resultOfEvents[522] == 0 && a.event_done[522] && a.event_done[525] && a.resultOfEvents[525] != 0)) && ((a.data[21] >= 1979 && a.data[20] >= 10) || a.data[21] >= 1980))
		{
			this_num_event = 527;
			return true;
		}
		if (!a.event_done[528] && a.resultOfEvents[522] == 0 && a.event_done[522] && a.event_done[525] && a.resultOfEvents[525] == 0 && ((a.data[21] >= 1980 && a.data[20] >= 12) || a.data[21] >= 1981))
		{
			this_num_event = 528;
			return true;
		}
		if (!a.event_done[529] && a.resultOfEvents[522] == 2 && a.event_done[522] && a.event_done[527] && a.resultOfEvents[527] >= 3 && ((a.data[21] >= 1979 && a.data[20] >= 11) || a.data[21] >= 1980))
		{
			this_num_event = 529;
			return true;
		}
		if (!a.event_done[530] && !a.event_done[531] && (a.event_done[527] || a.event_done[528]) && a.allcountries[44].SubGosstroy != 8 && ((a.data[21] >= 1981 && a.data[20] >= 6) || a.data[21] >= 1982))
		{
			this_num_event = 530;
			return true;
		}
		if (!a.event_done[531] && !a.event_done[530] && (a.event_done[527] || a.event_done[528]) && a.allcountries[44].SubGosstroy == 8 && ((a.data[21] >= 1981 && a.data[20] >= 6) || a.data[21] >= 1982))
		{
			this_num_event = 531;
			return true;
		}
		if (!a.event_done[532] && a.event_done[524] && a.resultOfEvents[524] == 0 && a.allcountries[44].prcpower >= 100 && a.allcountries[44].SubGosstroy == 6 && ((a.data[21] >= 1982 && a.data[20] >= 1) || a.data[21] >= 1983))
		{
			this_num_event = 532;
			return true;
		}
		if (!a.event_done[533] && !a.modifies[3].active && a.resultOfEvents[523] == 0 && a.event_done[523] && a.allcountries[44].SubGosstroy == 6 && ((a.data[21] >= 1982 && a.data[20] >= 6) || a.data[21] >= 1983))
		{
			this_num_event = 533;
			return true;
		}
		if (!a.event_done[534] && !a.event_done[536] && (a.event_done[527] || a.event_done[528]) && a.allcountries[44].SubGosstroy == 6 && ((a.data[21] >= 1983 && a.data[20] >= 10) || a.data[21] >= 1984))
		{
			this_num_event = 534;
			return true;
		}
		if (!a.event_done[536] && !a.event_done[534] && (a.event_done[527] || a.event_done[528]) && a.allcountries[44].SubGosstroy == 8 && ((a.data[21] >= 1983 && a.data[20] >= 10) || a.data[21] >= 1984))
		{
			this_num_event = 536;
			return true;
		}
		if (!a.event_done[537] && a.allcountries[86].Gosstroy != 0 && a.allcountries[86].Gosstroy != 3 && a.allcountries[87].Gosstroy != 0 && a.allcountries[87].Gosstroy != 3 && a.allcountries[21].SubGosstroy == 18 && a.allcountries[92].SubGosstroy == 18 && a.modifies[49].active && a.allcountries[44].Gosstroy == 3 && a.allcountries[44].prcpower >= 200 && ((a.data[21] >= 1985 && a.data[20] >= 1) || a.data[21] >= 1986))
		{
			this_num_event = 537;
			return true;
		}
		if (!a.event_done[539] && !a.ingamewars[0].is_going && !a.allcountries[46].parts[0] && !a.allcountries[10].parts[0] && a.allcountries[46].SubGosstroy == 7 && a.allcountries[10].puppetOf < 0 && (a.allcountries[10].Gosstroy == 1 || a.allcountries[10].SubGosstroy == 0 || a.allcountries[10].SubGosstroy == 10) && (a.allcountries[44].Gosstroy == 1 || a.allcountries[44].Gosstroy == 2) && (a.allcountries[38].Gosstroy == 1 || a.allcountries[38].Gosstroy == 2 || a.completedDecisions[7]) && ((a.data[21] >= 1985 && a.data[20] >= 5 && a.data[19] >= 23) || (a.data[21] >= 1985 && a.data[20] >= 6) || a.data[21] >= 1986))
		{
			this_num_event = 539;
			return true;
		}
		if (!a.event_done[455] && GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 8 && ((a.data[21] >= 1979 && a.data[20] >= 11 && a.data[19] >= 4) || (a.data[21] >= 1979 && a.data[20] >= 12) || a.data[21] >= 1980))
		{
			this_num_event = 455;
			return true;
		}
		if (!a.event_done[669] && ((a.data[21] >= 1977 && a.data[20] >= 10 && a.data[19] >= 12) || (a.data[21] >= 1977 && a.data[20] >= 11) || a.data[21] >= 1978))
		{
			this_num_event = 669;
			return true;
		}
		if (!a.event_done[670] && ((a.data[21] >= 1977 && a.data[20] >= 11 && a.data[19] >= 1) || (a.data[21] >= 1977 && a.data[20] >= 11) || a.data[21] >= 1978))
		{
			this_num_event = 670;
			return true;
		}
		if (!a.event_done[458] && ((a.data[21] >= 1978 && a.data[20] >= 2 && a.data[19] >= 28) || (a.data[21] >= 1978 && a.data[20] >= 3) || a.data[21] >= 1979))
		{
			this_num_event = 458;
			return true;
		}
		if (!a.event_done[672] && a.allcountries[58].SubGosstroy == 7 && a.IsSocialism(yes: true, 61) && ((a.data[21] >= 1985 && a.data[20] >= 9 && a.data[19] >= 1) || (a.data[21] >= 1985 && a.data[20] >= 9) || a.data[21] >= 1986))
		{
			this_num_event = 672;
			return true;
		}
		if (!a.event_done[459] && ((a.data[21] >= 1978 && a.data[20] >= 1 && a.data[19] >= 20) || (a.data[21] >= 1978 && a.data[20] >= 2) || a.data[21] >= 1979))
		{
			this_num_event = 459;
			return true;
		}
		if (!a.event_done[561] && a.event_done[459] && a.resultOfEvents[459] >= 2 && ((a.data[21] >= 1980 && a.data[20] >= 1 && a.data[19] >= 26) || (a.data[21] >= 1980 && a.data[20] >= 2) || a.data[21] >= 1981))
		{
			this_num_event = 561;
			return true;
		}
		if (!a.event_done[562] && a.event_done[459] && a.resultOfEvents[459] >= 3 && a.event_done[561] && a.resultOfEvents[561] >= 2 && ((a.data[21] >= 1983 && a.data[20] >= 12 && a.data[19] >= 29) || (a.data[21] >= 1983 && a.data[20] >= 13) || a.data[21] >= 1984))
		{
			this_num_event = 562;
			return true;
		}
		if (!a.event_done[446] && GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 8 && ((a.data[21] >= 1979 && a.data[20] >= 12 && a.data[19] >= 11) || a.data[21] >= 1980))
		{
			this_num_event = 446;
			return true;
		}
		if (!a.event_done[447] && a.event_done[446] && ((a.data[21] >= 1980 && a.data[20] >= 7 && a.data[19] >= 11) || (a.data[21] >= 1980 && a.data[20] >= 8) || a.data[21] >= 1981))
		{
			this_num_event = 447;
			return true;
		}
		if (!a.event_done[448] && a.event_done[447] && GlobalScript.inst.gameState.resultOfEvents[447] == 0)
		{
			this_num_event = 448;
			return true;
		}
		if (!a.event_done[449] && a.event_done[447] && !a.event_done[448] && a.allcountries[8].Gosstroy == 0 && ((a.data[21] >= 1981 && a.data[20] >= 6 && a.data[19] >= 20) || (a.data[21] >= 1981 && a.data[20] >= 7) || a.data[21] >= 1982))
		{
			this_num_event = 449;
			return true;
		}
		if (!a.event_done[450] && a.event_done[447] && !a.event_done[448] && !GlobalScript.inst.gameState.iranrev && GlobalScript.inst.gameState.ingamewars[3].is_going && ((a.data[21] >= 1982 && a.data[20] >= 5) || a.data[21] >= 1983))
		{
			this_num_event = 450;
			return true;
		}
		if (!a.event_done[451] && GlobalScript.inst.gameState.allcountries[23].SubGosstroy == 10 && ((a.data[21] >= 1977 && a.data[20] >= 3) || a.data[21] >= 1978))
		{
			this_num_event = 451;
			return true;
		}
		if (!a.event_done[452] && a.event_done[451] && a.resultOfEvents[451] == 0 && ((a.data[21] >= 1978 && a.data[20] >= 6) || a.data[21] >= 1979))
		{
			this_num_event = 452;
			return true;
		}
		if (!a.event_done[454] && GlobalScript.inst.gameState.allcountries[11].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[23].puppetOf == 11 && GlobalScript.inst.gameState.allcountries[22].puppetOf == 11)
		{
			this_num_event = 454;
			return true;
		}
		if (!a.event_done[460] && ((GlobalScript.inst.gameState.data[21] >= 1979 && GlobalScript.inst.gameState.data[20] >= 12 && GlobalScript.inst.gameState.data[19] >= 10) || GlobalScript.inst.gameState.data[21] >= 1980))
		{
			this_num_event = 460;
			return true;
		}
		if (!a.event_done[559] && ((GlobalScript.inst.gameState.data[21] >= 1980 && GlobalScript.inst.gameState.data[20] >= 8 && GlobalScript.inst.gameState.data[19] >= 15) || (GlobalScript.inst.gameState.data[21] >= 1980 && GlobalScript.inst.gameState.data[20] >= 9) || GlobalScript.inst.gameState.data[21] >= 1981))
		{
			this_num_event = 559;
			return true;
		}
		if (!a.event_done[463] && ((GlobalScript.inst.gameState.data[21] >= 1981 && GlobalScript.inst.gameState.data[20] >= 6 && GlobalScript.inst.gameState.data[19] >= 1) || (GlobalScript.inst.gameState.data[21] >= 1981 && GlobalScript.inst.gameState.data[20] >= 7) || GlobalScript.inst.gameState.data[21] >= 1982))
		{
			this_num_event = 463;
			return true;
		}
		if (!a.event_done[560] && a.allcountries[54].SubGosstroy == 7 && ((GlobalScript.inst.gameState.data[21] >= 1984 && GlobalScript.inst.gameState.data[20] >= 1 && GlobalScript.inst.gameState.data[19] >= 22) || (GlobalScript.inst.gameState.data[21] >= 1984 && GlobalScript.inst.gameState.data[20] >= 2) || GlobalScript.inst.gameState.data[21] >= 1985))
		{
			this_num_event = 560;
			return true;
		}
		if (!a.event_done[464] && GlobalScript.inst.gameState.allcountries[21].econ && GlobalScript.inst.gameState.allcountries[0].econ && GlobalScript.inst.gameState.allcountries[89].econ && GlobalScript.inst.gameState.allcountries[88].econ && GlobalScript.inst.gameState.allcountries[86].econ && GlobalScript.inst.gameState.allcountries[1].econ)
		{
			this_num_event = 464;
			return true;
		}
		if (!a.event_done[466] && GlobalScript.inst.gameState.data[32] >= 700)
		{
			this_num_event = 466;
			return true;
		}
		if (!GlobalScript.inst.gameState.event_done[467] && ((GlobalScript.inst.gameState.data[21] >= 1980 && GlobalScript.inst.gameState.data[20] >= 6) || GlobalScript.inst.gameState.data[21] >= 1981))
		{
			this_num_event = 467;
			return true;
		}
		if (!GlobalScript.inst.gameState.event_done[468] && GlobalScript.inst.gameState.allcountries[34].cw && ((GlobalScript.inst.gameState.data[21] >= 1981 && GlobalScript.inst.gameState.data[20] >= 2) || GlobalScript.inst.gameState.data[21] >= 1982))
		{
			this_num_event = 468;
			return true;
		}
		if (GlobalScript.inst.gameState.BritLost && GlobalScript.inst.gameState.data[65] <= 0 && !GlobalScript.inst.gameState.event_done[469])
		{
			this_num_event = 469;
			return true;
		}
		if (!GlobalScript.inst.gameState.event_done[471] && ((GlobalScript.inst.gameState.data[21] >= 1980 && GlobalScript.inst.gameState.data[20] >= 9) || GlobalScript.inst.gameState.data[21] >= 1981))
		{
			this_num_event = 471;
			return true;
		}
		if (GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.modifies[11].active && !GlobalScript.inst.gameState.event_done[444] && GlobalScript.inst.gameState.data[21] >= 1985 && !GlobalScript.inst.gameState.is_gkchp)
		{
			this_num_event = 444;
			return true;
		}
		if (!a.event_done[300] && a.event_done[56] && a.resultOfEvents[56] == 1 && GlobalScript.inst.gameState.war == 1 && GlobalScript.inst.gameState.data[21] >= 1979 && GlobalScript.inst.gameState.data[20] >= 3)
		{
			this_num_event = 300;
			return true;
		}
		if (!a.event_done[301] && a.event_done[300] && (a.resultOfEvents[300] == 0 || a.resultOfEvents[300] == 1))
		{
			this_num_event = 301;
			return true;
		}
		if (!a.event_done[302] && a.event_done[301] && (a.resultOfEvents[300] == 0 || a.resultOfEvents[300] == 1))
		{
			this_num_event = 302;
			return true;
		}
		if (!a.event_done[303] && a.event_done[300] && a.resultOfEvents[300] == 3)
		{
			this_num_event = 303;
			return true;
		}
		if (a.leader.name_1 == 2 && a.leader.name_2 == 2 && !a.modifies[3].active && !a.event_done[503] && (a.data[1] < 500 || a.data[4] > 500 || a.data[3] < 500 || a.data[5] < 250) && !a.event_done[304] && a.data[21] >= 1979)
		{
			this_num_event = 304;
			return true;
		}
		if (a.NumberOfPolitician(13, 13) >= 0 && a.data[1] <= 850 && (a.IsFactionLeadeng(0) || a.IsFactionLeadeng(1) || a.IsFactionLeadeng(2)) && !a.event_done[305] && a.data[21] >= 1981)
		{
			this_num_event = 305;
			return true;
		}
		if (a.NumberOfPolitician(15, 15) >= 0 && a.data[21] >= 1985 && !a.event_done[306] && a.resultOfEvents[444] != 0)
		{
			this_num_event = 306;
			return true;
		}
		if (!a.event_done[307] && a.data[21] >= 1983)
		{
			this_num_event = 307;
			return true;
		}
		if (!a.event_done[308] && a.data[21] >= 1979)
		{
			this_num_event = 308;
			return true;
		}
		if (a.NumberOfPolitician(16, 16) >= 0 && !a.event_done[309] && a.data[21] >= 1981 && ((a.data[1] <= 750 && (a.IsFactionLeadeng(0) || a.IsFactionLeadeng(1))) || a.event_done[304]))
		{
			this_num_event = 309;
			return true;
		}
		if (!a.event_done[310] && a.data[21] >= 1981 && (a.NumberOfPolitician(16, 16) < 0 || a.event_done[309]))
		{
			this_num_event = 310;
			return true;
		}
		if (a.NumberOfPolitician(17, 17) >= 0 && !a.event_done[311] && a.data[21] >= 1981 && ((a.data[1] <= 750 && (a.IsFactionLeadeng(0) || a.IsFactionLeadeng(1))) || a.event_done[310]))
		{
			this_num_event = 311;
			return true;
		}
		if (a.NumberOfPolitician(7, 7) >= 0 && !a.event_done[312] && a.data[21] >= 1981 && ((a.data[1] <= 750 && (a.IsFactionLeadeng(0) || a.IsFactionLeadeng(1))) || a.NumberOfPolitician(17, 17) < 0 || a.event_done[311]))
		{
			this_num_event = 312;
			return true;
		}
		if (!a.event_done[313] && a.data[19] >= 3 && a.data[20] >= 2 && a.data[21] >= 1984)
		{
			this_num_event = 313;
			return true;
		}
		if (!a.event_done[314] && a.data[19] >= 1 && !a.allcountries[7].isNATO && a.data[20] >= 9 && a.data[21] >= 1983)
		{
			this_num_event = 314;
			return true;
		}
		if (!a.event_done[319] && a.data[19] >= 14 && a.data[20] >= 7 && a.data[21] >= 1980)
		{
			this_num_event = 319;
			return true;
		}
		if (!a.event_done[437] && a.data[19] >= 26 && a.data[20] >= 6 && a.data[21] >= 1978)
		{
			this_num_event = 437;
			return true;
		}
		if (!a.event_done[442] && GlobalScript.inst.gameState.Israellost && (GlobalScript.inst.gameState.IsSocialism(yes: true, 14) || GlobalScript.inst.gameState.allcountries[14].SubGosstroy == 10 || GlobalScript.inst.gameState.allcountries[14].Gosstroy == 2) && (GlobalScript.inst.gameState.IsSocialism(yes: true, 35) || GlobalScript.inst.gameState.allcountries[35].SubGosstroy == 10 || GlobalScript.inst.gameState.allcountries[35].Gosstroy == 2) && a.data[21] >= 1983)
		{
			this_num_event = 442;
			return true;
		}
		if (!a.event_done[320] && a.data[19] >= 19 && a.data[20] >= 10 && a.data[21] >= 1978)
		{
			this_num_event = 320;
			return true;
		}
		if (!a.event_done[321] && a.data[19] >= 6 && a.data[20] >= 3 && a.data[21] >= 1982)
		{
			this_num_event = 321;
			return true;
		}
		if (!a.event_done[322] && a.data[5] >= 600 && a.data[19] >= 9 && a.data[20] >= 1 && a.data[21] >= 1980)
		{
			this_num_event = 322;
			return true;
		}
		if (!a.event_done[323] && a.data[16] >= 13 && a.IsFactionLeadeng(4) && a.data[19] >= 12 && a.data[20] >= 9 && a.data[21] >= 1982)
		{
			this_num_event = 323;
			return true;
		}
		if (!a.event_done[324] && a.data[19] >= 1 && a.data[20] >= 10 && a.data[21] >= 1979)
		{
			this_num_event = 324;
			return true;
		}
		if (!a.event_done[325] && a.data[19] >= 23 && a.data[20] >= 6 && a.data[21] >= 1982)
		{
			this_num_event = 325;
			return true;
		}
		if (!a.event_done[326] && a.data[19] >= 5 && a.data[20] >= 3 && a.data[21] >= 1978)
		{
			this_num_event = 326;
			return true;
		}
		if (!a.event_done[327] && a.data[19] >= 9 && a.data[20] >= 9 && a.data[21] >= 1980 && a.resultOfEvents[317] < 2)
		{
			this_num_event = 327;
			return true;
		}
		if (a.data[16] > 12 && !a.event_done[331] && a.data[19] >= 27 && a.data[20] >= 10 && a.data[21] >= 1984 && a.data[16] > 12)
		{
			this_num_event = 331;
			return true;
		}
		if (a.SEZ && !a.event_done[333] && a.data[19] >= 24 && a.data[20] >= 8 && a.data[21] >= 1981)
		{
			this_num_event = 333;
			return true;
		}
		if (!a.event_done[334] && a.data[19] >= 11 && a.data[20] >= 2 && a.data[21] >= 1984 && a.data[16] > 12)
		{
			this_num_event = 334;
			return true;
		}
		if (!a.event_done[335] && a.data[19] >= 13 && a.data[20] >= 6 && a.data[21] >= 1984 && a.data[16] > 12)
		{
			this_num_event = 335;
			return true;
		}
		if (!a.event_done[339] && a.data[19] >= 30 && a.data[20] >= 12 && a.data[21] >= 1983)
		{
			this_num_event = 339;
			return true;
		}
		if (!a.event_done[341] && a.data[19] >= 10 && a.data[20] >= 9 && a.data[21] >= 1980)
		{
			this_num_event = 341;
			return true;
		}
		if (!a.event_done[342] && a.data[19] >= 20 && a.data[20] >= 7 && a.data[21] >= 1979)
		{
			this_num_event = 342;
			return true;
		}
		if (!a.event_done[344] && a.data[19] >= 5 && a.data[20] >= 5 && a.data[21] >= 1984)
		{
			this_num_event = 344;
			return true;
		}
		if (!a.event_done[345] && a.data[19] >= 5 && a.data[20] >= 6 && a.data[21] >= 1984)
		{
			this_num_event = 345;
			return true;
		}
		if (!a.event_done[346] && a.data[19] >= 11 && a.data[20] >= 6 && a.data[21] >= 1981)
		{
			this_num_event = 346;
			return true;
		}
		if (!a.event_done[349] && a.data[19] >= 24 && a.data[20] >= 6 && a.data[21] >= 1979)
		{
			this_num_event = 349;
			return true;
		}
		if (!a.event_done[350] && a.data[19] >= 9 && a.data[20] >= 6 && a.data[21] >= 1979)
		{
			this_num_event = 350;
			return true;
		}
		if (!a.event_done[352] && a.data[19] >= 12 && a.data[20] >= 4 && a.data[21] >= 1978)
		{
			this_num_event = 352;
			return true;
		}
		if (a.resultOfEvents[352] <= 2 && !a.event_done[353] && a.data[19] >= 12 && a.data[20] >= 6 && a.data[21] >= 1978)
		{
			this_num_event = 353;
			return true;
		}
		if (a.resultOfEvents[353] <= 1 && !a.event_done[354] && a.science[27] && a.data[21] >= 1979)
		{
			this_num_event = 354;
			return true;
		}
		if (a.resultOfEvents[354] <= 1 && !a.event_done[355] && a.science[28] && a.data[21] >= 1979 && a.data[20] >= 6)
		{
			this_num_event = 355;
			return true;
		}
		if (a.resultOfEvents[355] <= 0 && !a.event_done[356] && a.science[30])
		{
			this_num_event = 356;
			return true;
		}
		if (!a.event_done[357] && a.science[30] && a.event_done[356] && a.resultOfEvents[356] == 0 && (a.resultOfEvents[353] == 0 || a.resultOfEvents[353] == 1))
		{
			this_num_event = 357;
			return true;
		}
		if (!a.event_done[358] && !a.event_done[359] && a.science[31] && a.data[21] >= 1980 && a.data[20] >= 6)
		{
			this_num_event = 358;
			return true;
		}
		if (!a.event_done[359] && !a.event_done[358] && a.data[21] >= 1984 && a.data[20] >= 6)
		{
			this_num_event = 359;
			return true;
		}
		if (!a.event_done[360] && (a.resultOfEvents[361] <= 1 || a.resultOfEvents[358] <= 1 || a.resultOfEvents[359] <= 1) && a.data[21] >= 1985 && a.data[20] >= 6)
		{
			this_num_event = 360;
			return true;
		}
		if (!a.event_done[361] && a.data[21] >= 1983 && a.data[20] >= 6 && a.science[31])
		{
			this_num_event = 361;
			return true;
		}
		if (a.event_done[360] && !a.event_done[362] && a.data[21] >= 1985 && a.data[20] >= 6 && a.science[31])
		{
			this_num_event = 362;
			return true;
		}
		if (!a.event_done[363] && a.data[21] >= 1985 && a.data[20] >= 8 && a.science[32] && (a.resultOfEvents[356] == 1 || a.resultOfEvents[357] == 0))
		{
			this_num_event = 363;
			return true;
		}
		if (!a.event_done[364] && a.event_done[363] && a.data[21] >= 1985 && a.data[20] >= 10 && a.science[33])
		{
			this_num_event = 364;
			return true;
		}
		return false;
	}

	public static bool RequrementsDLC03(ref int this_num_event, GameState a)
	{
		bool flag = false;
		for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
		{
			if (a.allcountries[i].puppetOf == 21)
			{
				flag = true;
				break;
			}
		}
		if (!a.event_done[365] && ((a.data[20] >= 10 && a.data[21] >= 1981) || a.data[21] >= 1982))
		{
			this_num_event = 365;
			return true;
		}
		if (!a.event_done[366] && ((a.data[19] > 20 && a.data[20] >= 4 && a.data[21] >= 1977) || (a.data[20] >= 5 && a.data[21] >= 1977) || a.data[21] >= 1978))
		{
			this_num_event = 366;
			return true;
		}
		if (!a.event_done[367] && ((a.data[19] > 11 && a.data[20] >= 9 && a.data[21] >= 1980) || (a.data[20] >= 10 && a.data[21] >= 1980) || a.data[21] >= 1981))
		{
			this_num_event = 367;
			return true;
		}
		if (!a.event_done[564] && ((a.data[21] >= 1980 && a.data[20] >= 6 && a.data[19] >= 1) || (a.data[21] >= 1980 && a.data[20] >= 6) || a.data[21] >= 1981))
		{
			this_num_event = 564;
			return true;
		}
		if (!a.event_done[570] && !a.event_done[571] && !a.allcountries[14].parts[4] && a.allcountries[8].proprc && a.allcountries[14].Gosstroy == 1 && a.OAR && (a.allcountries[102].Gosstroy != 0 || a.ingamewars[43].is_going))
		{
			this_num_event = 570;
			return true;
		}
		if (!a.event_done[571] && !a.event_done[570] && !a.event_done[417] && a.allcountries[8].proprc && a.completedDecisions[20] && (a.allcountries[30].parts[0] || a.allcountries[30].parts[1]) && a.OAR && a.allcountries[102].Gosstroy != 0)
		{
			this_num_event = 571;
			return true;
		}
		if (!a.event_done[573] && ((a.data[21] >= 1982 && a.data[20] >= 8) || a.data[21] >= 1983))
		{
			this_num_event = 573;
			return true;
		}
		if (!a.event_done[574] && ((a.data[21] >= 1983 && a.data[20] >= 3 && a.data[19] >= 5) || (a.data[21] >= 1983 && a.data[20] >= 4) || a.data[21] >= 1984))
		{
			this_num_event = 574;
			return true;
		}
		if (!a.event_done[575] && (a.allcountries[92].Gosstroy == 1 || (a.allcountries[92].Gosstroy == 2 && a.allcountries[92].isSocEU)))
		{
			this_num_event = 575;
			return true;
		}
		if (!a.event_done[577] && ((a.data[21] >= 1982 && a.data[20] >= 1 && a.data[19] >= 30) || (a.data[21] >= 1982 && a.data[20] >= 2) || a.data[21] >= 1983))
		{
			this_num_event = 577;
			return true;
		}
		if (!a.event_done[578] && ((a.data[21] >= 1983 && a.data[20] >= 11 && a.data[19] >= 17) || (a.data[21] >= 1983 && a.data[20] >= 12) || a.data[21] >= 1984))
		{
			this_num_event = 578;
			return true;
		}
		if (!a.event_done[579] && ((a.data[21] >= 1985 && a.data[20] >= 9 && a.data[19] >= 19) || (a.data[21] >= 1985 && a.data[20] >= 10) || a.data[21] >= 1986))
		{
			this_num_event = 579;
			return true;
		}
		if (!a.event_done[580] && ((a.data[21] >= 1979 && a.data[20] >= 5) || a.data[21] >= 1980))
		{
			this_num_event = 580;
			return true;
		}
		if (!a.event_done[581] && ((a.data[21] >= 1983 && a.data[20] >= 10 && a.data[19] >= 24) || (a.data[21] >= 1983 && a.data[20] >= 11) || a.data[21] >= 1984))
		{
			this_num_event = 581;
			return true;
		}
		if (!a.event_done[582] && ((a.data[21] >= 1979 && a.data[20] >= 9 && a.data[19] >= 20) || (a.data[21] >= 1979 && a.data[20] >= 10) || a.data[21] >= 1980))
		{
			this_num_event = 582;
			return true;
		}
		if (!a.event_done[583] && a.allcountries[65].puppetOf == 21 && ((a.data[21] >= 1982 && a.data[20] >= 3 && a.data[19] >= 3) || (a.data[21] >= 1982 && a.data[20] >= 4) || a.data[21] >= 1983))
		{
			this_num_event = 583;
			return true;
		}
		if (!a.event_done[585] && ((a.data[21] >= 1977 && a.data[20] >= 5 && a.data[19] >= 8) || (a.data[21] >= 1977 && a.data[20] >= 6) || a.data[21] >= 1978))
		{
			this_num_event = 585;
			return true;
		}
		if (!a.event_done[586] && !a.allcountries[42].parts[0] && !a.allcountries[41].parts[1] && ((a.data[21] >= 1981 && a.data[20] >= 10 && a.data[19] >= 7) || (a.data[21] >= 1981 && a.data[20] >= 11) || a.data[21] >= 1982))
		{
			this_num_event = 586;
			return true;
		}
		if (!a.event_done[597] && ((a.data[21] >= 1981 && a.data[20] >= 7 && a.data[19] >= 30) || (a.data[21] >= 1981 && a.data[20] >= 8) || a.data[21] >= 1982))
		{
			this_num_event = 597;
			return true;
		}
		if (!a.event_done[598] && ((a.data[21] >= 1978 && a.data[20] >= 11 && a.data[19] >= 2) || (a.data[21] >= 1978 && a.data[20] >= 12) || a.data[21] >= 1979))
		{
			this_num_event = 598;
			return true;
		}
		if (a.event_done[598] && !a.event_done[599] && !a.ingamewars[53].is_going && !a.allcountries[122].econ)
		{
			this_num_event = 599;
			return true;
		}
		if (!a.event_done[600] && ((a.data[21] >= 1985 && a.data[20] >= 10) || a.data[21] >= 1986))
		{
			this_num_event = 600;
			return true;
		}
		if (!a.event_done[601] && ((a.data[21] >= 1980 && a.data[20] >= 11) || a.data[21] >= 1981))
		{
			this_num_event = 601;
			return true;
		}
		if (!a.event_done[602] && ((a.data[21] >= 1983 && a.data[20] >= 11 && a.data[19] >= 2) || (a.data[21] >= 1983 && a.data[20] >= 12) || a.data[21] >= 1984))
		{
			this_num_event = 602;
			return true;
		}
		if (!a.event_done[603] && a.allcountries[131].SubGosstroy == 5 && ((a.data[21] >= 1985 && a.data[20] >= 8 && a.data[19] >= 15) || (a.data[21] >= 1985 && a.data[20] >= 9) || a.data[21] >= 1986))
		{
			this_num_event = 603;
			return true;
		}
		if (!a.event_done[604] && a.allcountries[131].SubGosstroy == 9 && !a.ingamewars[54].is_going && a.data[21] >= 1984)
		{
			this_num_event = 604;
			return true;
		}
		if (!a.event_done[605] && a.allcountries[131].SubGosstroy == 10 && ((a.data[21] >= 1985 && a.data[20] >= 12 && a.data[19] >= 1) || (a.data[21] >= 1985 && a.data[20] >= 12) || a.data[21] >= 1986))
		{
			this_num_event = 605;
			return true;
		}
		if (!a.event_done[607] && ((a.data[21] >= 1977 && a.data[20] >= 6) || a.data[21] >= 1978))
		{
			this_num_event = 607;
			return true;
		}
		if (!a.event_done[608] && ((a.data[21] >= 1981 && a.data[20] >= 11 && a.data[19] >= 25) || (a.data[21] >= 1981 && a.data[20] >= 12) || a.data[21] >= 1982))
		{
			this_num_event = 608;
			return true;
		}
		if (!a.event_done[609] && ((a.data[21] >= 1978 && a.data[20] >= 5 && a.data[19] >= 12) || (a.data[21] >= 1978 && a.data[20] >= 6) || a.data[21] >= 1979))
		{
			this_num_event = 609;
			return true;
		}
		if (!a.event_done[610] && ((a.data[21] >= 1977 && a.data[20] >= 3 && a.data[19] >= 8) || (a.data[21] >= 1977 && a.data[20] >= 4) || a.data[21] >= 1978))
		{
			this_num_event = 610;
			return true;
		}
		if (!a.event_done[611] && ((a.data[21] >= 1978 && a.data[20] >= 5 && a.data[19] >= 11) || (a.data[21] >= 1978 && a.data[20] >= 6) || a.data[21] >= 1979))
		{
			this_num_event = 611;
			return true;
		}
		if (!a.event_done[613] && a.allcountries[117].SubGosstroy == 7 && a.allcountries[117].Torg && ((a.data[21] >= 1982 && a.data[20] >= 2 && a.data[19] >= 15) || (a.data[21] >= 1982 && a.data[20] >= 3) || a.data[21] >= 1983))
		{
			this_num_event = 613;
			return true;
		}
		if (!a.event_done[614] && a.allcountries[163].parts[0] && (a.allcountries[117].SubGosstroy == 15 || a.allcountries[117].SubGosstroy == 17))
		{
			this_num_event = 614;
			return true;
		}
		if (!a.event_done[615] && ((a.data[21] >= 1983 && a.data[20] >= 2 && a.data[19] >= 27) || (a.data[21] >= 1983 && a.data[20] >= 3) || a.data[21] >= 1984))
		{
			this_num_event = 615;
			return true;
		}
		if (!a.event_done[618] && !a.event_done[617] && ((a.data[21] >= 1984 && a.data[20] >= 4) || a.data[21] >= 1985))
		{
			this_num_event = 618;
			return true;
		}
		if (!a.event_done[621] && a.allcountries[115].Gosstroy == 0 && ((a.data[21] >= 1979 && a.data[20] >= 8) || a.data[21] >= 1980))
		{
			this_num_event = 621;
			return true;
		}
		if (!a.event_done[623] && ((a.data[21] >= 1977 && a.data[20] >= 5 && a.data[19] >= 30) || (a.data[21] >= 1977 && a.data[20] >= 6) || a.data[21] >= 1978))
		{
			this_num_event = 623;
			return true;
		}
		if (!a.event_done[624] && a.allcountries[126].parts[0] && ((a.data[21] >= 1983 && a.data[20] >= 4) || a.data[21] >= 1984))
		{
			this_num_event = 624;
			return true;
		}
		if (!a.event_done[626] && ((a.data[21] >= 1978 && a.data[20] >= 7 && a.data[19] >= 10) || (a.data[21] >= 1978 && a.data[20] >= 8) || a.data[21] >= 1979))
		{
			this_num_event = 626;
			return true;
		}
		if (!a.event_done[629] && ((a.data[21] >= 1980 && a.data[20] >= 7 && a.data[19] >= 30) || (a.data[21] >= 1980 && a.data[20] >= 8) || a.data[21] >= 1981))
		{
			this_num_event = 629;
			return true;
		}
		if (!a.event_done[630] && a.event_done[483])
		{
			this_num_event = 630;
			return true;
		}
		if (!a.event_done[631] && ((a.data[21] >= 1978 && a.data[20] >= 4 && a.data[19] >= 22) || (a.data[21] >= 1978 && a.data[20] >= 5) || a.data[21] >= 1979))
		{
			this_num_event = 631;
			return true;
		}
		if (!a.event_done[632] && ((a.data[21] >= 1980 && a.data[20] >= 10 && a.data[19] >= 30) || (a.data[21] >= 1980 && a.data[20] >= 11) || a.data[21] >= 1981))
		{
			this_num_event = 632;
			return true;
		}
		if (!a.event_done[633] && a.IsAuthoritarianism(149) && ((a.data[21] >= 1982 && a.data[20] >= 3 && a.data[19] >= 23) || (a.data[21] >= 1982 && a.data[20] >= 4) || a.data[21] >= 1983))
		{
			this_num_event = 633;
			return true;
		}
		if (!a.event_done[635] && a.IsAuthoritarianism(149) && a.BritLost && ((a.data[21] >= 1983 && a.data[20] >= 1) || a.data[21] >= 1984))
		{
			this_num_event = 635;
			return true;
		}
		if (!a.event_done[636] && ((a.data[21] >= 1976 && a.data[20] >= 5 && a.data[19] >= 10) || (a.data[21] >= 1976 && a.data[20] >= 6) || a.data[21] >= 1977))
		{
			this_num_event = 636;
			return true;
		}
		if (!a.event_done[637] && ((a.data[21] >= 1979 && a.data[20] >= 5 && a.data[19] >= 10) || (a.data[21] >= 1979 && a.data[20] >= 6) || a.data[21] >= 1980))
		{
			this_num_event = 637;
			return true;
		}
		if (!a.event_done[368] && ((a.event_done[564] && a.data[21] == 1983 && a.data[19] > 14 && a.data[20] >= 11 && a.allcountries[35].Gosstroy == 0) || (a.ingamewars[3].is_going && a.data[21] == 1983 && a.data[19] > 14 && a.data[20] >= 11) || (a.ingamewars[28].is_going && a.data[21] >= 1981)) && !a.OAR && !a.allcountries[35].isSEV && a.allcountries[35].Gosstroy != 1 && !a.allcountries[35].econ)
		{
			this_num_event = 368;
			return true;
		}
		if (!a.event_done[369] && a.allcountries[84].SubGosstroy == 9 && a.data[19] > 1 && a.data[20] >= 2 && a.data[21] == 1984)
		{
			this_num_event = 369;
			return true;
		}
		if (!a.event_done[370] && a.allcountries[84].SubGosstroy == 9 && ((!a.allcountries[35].prosov && !a.allcountries[35].oar && !a.allcountries[35].isOVD && !a.allcountries[35].isSEATO && !a.allcountries[35].Vyshi && !a.allcountries[35].okb) || (!a.allcountries[14].prosov && !a.allcountries[14].isSEATO && !a.allcountries[14].oar && !a.allcountries[14].okb && !a.allcountries[14].isOVD) || (!a.allcountries[8].Vyshi && !a.allcountries[8].isSEATO && !a.allcountries[8].okb && !a.allcountries[8].isOVD)) && !a.ingamewars[9].is_going && a.data[19] > 20 && a.data[20] >= 12 && a.data[21] == 1984)
		{
			this_num_event = 370;
			return true;
		}
		if (!a.event_done[371] && a.Israellost && a.ingamewars[10].is_going && a.allcountries[37].Gosstroy == 3 && !a.allcountries[37].proprc && !a.allcountries[35].Vyshi && a.allcountries[37].dev <= 0)
		{
			this_num_event = 371;
			return true;
		}
		if (a.data[124] == 10)
		{
			this_num_event = 372;
			return true;
		}
		if (!a.event_done[373] && a.allcountries[84].SubGosstroy == 9 && GlobalScript.inst.gameState.allcountries[14].puppetOf == 84 && GlobalScript.inst.gameState.allcountries[8].puppetOf == 84 && GlobalScript.inst.gameState.allcountries[35].puppetOf == 84 && !a.allcountries[84].isNATO && !a.allcountries[84].Vyshi && ((a.data[20] >= 6 && a.data[21] >= 1985) || a.data[21] >= 1986))
		{
			this_num_event = 373;
			return true;
		}
		if (a.data[127] == 10)
		{
			this_num_event = 374;
			return true;
		}
		if (!a.event_done[380] && a.empires[1].now_leader == 4 && ((a.data[21] == 1985 && a.data[20] >= 3 && a.data[19] > 15) || (a.data[21] == 1985 && a.data[20] >= 4) || a.data[21] > 1985))
		{
			this_num_event = 380;
			return true;
		}
		if (!a.event_done[375] && a.empires[1].now_leader == 4 && a.empires[1].power >= 100 && a.empires[0].power <= 100 && a.data[126] > 0 && a.data[124] == 100 && !a.allcountries[84].isNATO && !a.allcountries[1].isSEV)
		{
			this_num_event = 375;
			return true;
		}
		if (!a.event_done[376] && ((a.data[19] > 13 && a.data[20] >= 7 && a.data[21] >= 1977) || (a.data[20] >= 8 && a.data[21] >= 1977) || a.data[21] >= 1978))
		{
			this_num_event = 376;
			return true;
		}
		if (!a.event_done[377] && !a.allcountries[1].isASEAN && a.allcountries[7].Gosstroy != 2 && ((a.data[21] >= 1985 && a.data[20] > 3) || a.data[21] >= 1986) && !a.allcountries[1].isOVD && !a.allcountries[1].isSEV && a.empires[1].now_leader == 4 && a.empires[1].power > 100 && !a.allcountries[4].prosov && !a.allcountries[5].prosov && !a.allcountries[2].prosov && !a.ingamewars[22].is_going && a.data[133] == 0)
		{
			this_num_event = 377;
			return true;
		}
		if (!a.event_done[378] && ((a.data[21] >= 1982 && a.data[20] >= 6) || a.data[21] >= 1983) && !a.allcountries[10].prosov && !a.allcountries[10].okb && !a.allcountries[10].econ && !a.allcountries[10].isOVD && !a.allcountries[10].isSEV && !a.event_done[29])
		{
			this_num_event = 378;
			return true;
		}
		if (!a.event_done[379] && a.data[130] != 1 && a.allcountries[9].isSEV && a.influencePRC > 500 && (a.data[21] > 1983 || (a.data[21] == 1983 && a.data[20] > 3)) && a.data[21] < 1984 && a.empires[1].now_leader == 1 && a.empires[0].now_leader == 1 && a.empires[1].power + a.empires[0].power < 300 && !a.allcountries[1].isOVD && a.allcountries[51].isNATO && !a.allcountries[1].isSEV && !a.allcountries[1].isASEAN && a.allcountries[12].prosov && a.ingamewars[5].is_going && (a.ingamewars[5].diplo_done[1] || a.resultOfEvents[52] == 3 || a.resultOfEvents[50] == 3))
		{
			this_num_event = 379;
			return true;
		}
		if (!a.event_done[381] && a.empires[1].now_leader == 7 && ((a.data[21] == 1985 && a.data[20] >= 1) || a.data[21] > 1985) && a.allcountries[17].isNATO && a.allcountries[17].isEU)
		{
			this_num_event = 381;
			return true;
		}
		if (!a.event_done[641] && a.event_done[640] && a.empires[1].now_leader == 7 && a.data[31] >= 700 && a.data[57] >= 700 && a.data[6] >= 1000 && GlobalScript.inst.gameState.science[26] && GlobalScript.inst.gameState.science[22] && a.data[130] == 1 && a.allcountries[1].parts[0] && !GlobalScript.inst.gameState.allcountries[1].parts[9] && !GlobalScript.inst.gameState.allcountries[1].parts[7] && !GlobalScript.inst.gameState.allcountries[1].parts[8] && a.allcountries[8].proprc && a.allcountries[8].okb && a.allcountries[12].proprc && a.allcountries[12].okb && a.allcountries[44].proprc && a.allcountries[44].okb)
		{
			this_num_event = 641;
			return true;
		}
		if (!a.event_done[382] && ((a.data[21] == 1981 && a.data[20] >= 6) || a.data[21] >= 1982) && a.resultOfEvents[76] == 3 && !a.allcountries[1].isEU && !a.allcountries[1].isNATO && !a.allcountries[1].isSEV && !a.allcountries[1].isOVD)
		{
			this_num_event = 382;
			return true;
		}
		if (!a.event_done[383] && ((a.data[21] >= 1985 && a.data[20] >= 5) || a.data[21] >= 1986) && a.allcountries[20].parts[0] && !a.allcountries[45].econ && !a.allcountries[45].isSEV && !a.allcountries[45].isNATO && a.data[60] == 3)
		{
			this_num_event = 383;
			return true;
		}
		if (!a.event_done[384] && ((a.data[21] == 1981 && a.data[20] >= 2) || a.data[21] >= 1982))
		{
			this_num_event = 384;
			return true;
		}
		if (!a.event_done[385] && ((a.data[21] == 1981 && a.data[20] >= 5 && a.data[19] > 10) || (a.data[21] == 1981 && a.data[20] >= 6) || a.data[21] >= 1982))
		{
			this_num_event = 385;
			return true;
		}
		if (!a.event_done[387] && ((a.data[21] == 1979 && a.data[20] >= 2 && a.data[19] > 20) || (a.data[21] == 1979 && a.data[20] >= 3) || a.data[21] >= 1980))
		{
			this_num_event = 387;
			return true;
		}
		if (!a.event_done[388] && a.data[21] >= 1985 && !a.allcountries[1].isOVD && !a.allcountries[1].isSEV && a.empires[1].now_leader == 4 && a.empires[1].power >= 250 && a.data[20] > 5 && a.allcountries[9].prosov && a.allcountries[4].prosov && a.allcountries[5].prosov && a.allcountries[6].prosov && !a.ingamewars[22].is_going && a.data[133] == 0)
		{
			this_num_event = 388;
			return true;
		}
		if (!a.event_done[389] && ((a.data[21] == 1983 && a.data[20] >= 6 && a.data[21] > 15) || (a.data[21] == 1983 && a.data[20] >= 7) || a.data[21] >= 1984) && a.data[131] == 1)
		{
			this_num_event = 389;
			return true;
		}
		if (!a.event_done[390] && ((a.data[21] == 1983 && a.data[20] >= 5) || a.data[21] >= 1984) && a.data[131] == 2)
		{
			this_num_event = 390;
			return true;
		}
		if (!a.event_done[572] && a.event_done[390] && a.allcountries[21].Gosstroy == 1 && flag && a.YugAgree && a.data[131] == 2)
		{
			this_num_event = 572;
			return true;
		}
		if (!a.event_done[391] && a.data[21] >= 1978 && a.data[20] >= 1)
		{
			this_num_event = 391;
			return true;
		}
		if (!a.event_done[392] && ((a.data[21] >= 1978 && a.data[20] >= 3 && a.data[19] > 19) || (a.data[21] >= 1978 && a.data[20] >= 4) || a.data[21] >= 1979) && (a.allcountries[85].inflCh >= 0 || a.allcountries[85].inflNATO >= 0))
		{
			this_num_event = 392;
			return true;
		}
		if (!a.event_done[393] && ((a.data[21] >= 1978 && a.data[20] >= 3 && a.data[19] > 19) || (a.data[21] >= 1978 && a.data[20] >= 4) || a.data[21] >= 1979) && a.allcountries[85].inflCh < 0 && a.allcountries[85].inflNATO < 0)
		{
			this_num_event = 393;
			return true;
		}
		if (!a.event_done[394] && ((a.data[21] >= 1979 && a.data[20] >= 6 && a.data[19] > 20) || (a.data[21] >= 1979 && a.data[20] >= 7) || a.data[21] >= 1980) && (a.allcountries[85].inflCh == 2 || (a.allcountries[85].inflCh == 0 && a.allcountries[85].inflNATO == 0) || a.allcountries[85].inflNATO == 2 || a.allcountries[85].inflCh == 5 || a.allcountries[85].inflNATO == 5))
		{
			this_num_event = 394;
			return true;
		}
		if (!a.event_done[395] && ((a.data[21] >= 1980 && a.data[20] >= 6 && a.data[19] > 10) || (a.data[21] >= 1980 && a.data[20] >= 7) || a.data[21] >= 1981) && a.allcountries[85].inflNATO == 4 && a.allcountries[85].inflCh == 4)
		{
			this_num_event = 395;
			return true;
		}
		if (!a.event_done[396] && a.allcountries[85].based)
		{
			this_num_event = 396;
			return true;
		}
		if (!a.event_done[397] && ((a.data[21] >= 1982 && a.data[20] >= 8) || a.data[21] >= 1983) && a.allcountries[85].inflNATO == 3 && a.allcountries[85].inflCh == 3)
		{
			this_num_event = 397;
			return true;
		}
		if (!a.event_done[398] && ((a.data[21] >= 1983 && a.data[20] >= 2) || a.data[21] >= 1984) && a.allcountries[85].inflNATO == 10)
		{
			this_num_event = 398;
			return true;
		}
		if (!a.event_done[557] && !a.event_done[401] && !a.event_done[398] && a.data[21] >= 1982 && !a.allcountries[85].isSocEU && !a.allcountries[85].isSEV && !a.allcountries[85].econ && !a.allcountries[85].prosov && a.allcountries[85].Gosstroy != 1 && a.allcountries[85].Gosstroy != 0 && a.allcountries[85].Gosstroy != 3)
		{
			this_num_event = 557;
			return true;
		}
		if (!a.event_done[399] && !a.event_done[401] && !a.event_done[398] && ((a.data[21] >= 1983 && a.data[20] >= 6 && a.data[19] > 15) || (a.data[21] >= 1983 && a.data[20] >= 7) || a.data[21] >= 1984) && !a.allcountries[85].isSocEU && !a.allcountries[85].isSEV && !a.allcountries[85].econ && !a.allcountries[85].prosov && a.allcountries[85].Gosstroy != 1 && a.allcountries[85].Gosstroy != 0 && a.allcountries[85].Gosstroy != 3)
		{
			this_num_event = 399;
			return true;
		}
		if (!a.event_done[556] && !a.event_done[401] && !a.event_done[398] && a.event_done[399] && a.allcountries[85].prcpower >= 2000 && a.empires[0].power <= 100)
		{
			this_num_event = 556;
			return true;
		}
		if (!a.event_done[555] && a.allcountries[17].isNATO && ((a.data[21] >= 1983 && a.data[20] >= 10 && a.data[19] >= 22) || (a.data[21] >= 1983 && a.data[20] >= 11) || a.data[21] >= 1984))
		{
			this_num_event = 555;
			return true;
		}
		if (!a.event_done[558] && a.empires[1].now_leader == 6 && a.allcountries[7].SubGosstroy != 15 && a.empires[1].leaders[6].support < 0 && ((a.data[21] >= 1985 && a.data[20] >= 5) || a.data[21] >= 1986))
		{
			this_num_event = 558;
			return true;
		}
		if (!a.event_done[400] && ((a.data[21] >= 1984 && a.data[20] >= 6 && a.data[19] > 10) || (a.data[21] >= 1984 && a.data[20] >= 7) || a.data[21] >= 1985) && a.allcountries[85].SubGosstroy == 14)
		{
			this_num_event = 400;
			return true;
		}
		if (!a.event_done[401] && ((a.data[21] == 1983 && a.data[20] >= 2) || a.data[21] >= 1984) && a.allcountries[85].inflCh == 10)
		{
			this_num_event = 401;
			return true;
		}
		if (!a.event_done[402] && ((a.data[21] == 1984 && a.data[20] >= 11) || a.data[21] >= 1985))
		{
			this_num_event = 402;
			return true;
		}
		if (!a.event_done[403] && ((a.data[21] == 1984 && a.data[20] >= 3) || a.data[21] >= 1985) && !a.allcountries[1].isSEV && a.allcountries[41].SubGosstroy == 10 && a.allcountries[41].prosov && !a.allcountries[41].parts[0] && !a.allcountries[41].parts[1])
		{
			this_num_event = 403;
			return true;
		}
		if (!a.event_done[404] && ((a.data[21] == 1981 && a.data[20] >= 1) || a.data[21] >= 1982))
		{
			this_num_event = 404;
			return true;
		}
		if (!a.event_done[405] && ((a.data[21] == 1979 && a.data[20] >= 5) || a.data[21] >= 1980))
		{
			this_num_event = 405;
			return true;
		}
		if (!a.event_done[406] && ((a.data[21] == 1983 && a.data[20] >= 5 && a.data[19] > 20) || (a.data[21] == 1983 && a.data[20] >= 6) || a.data[21] >= 1984))
		{
			this_num_event = 406;
			return true;
		}
		if (!a.event_done[407] && a.data[21] > 1983 && a.allcountries[92].SubGosstroy == 18 && a.allcountries[1].Gosstroy == 1 && a.allcountries[1].okb && !a.modifies[6].active)
		{
			this_num_event = 407;
			return true;
		}
		if (a.allcountries[1].dev == 1)
		{
			this_num_event = 408;
			return true;
		}
		if (a.allcountries[1].dev == 2)
		{
			this_num_event = 409;
			return true;
		}
		if (a.allcountries[1].isSEV && a.allcountries[7].spec <= 0 && (a.allcountries[1].Gosstroy == 3 || (a.allcountries[1].Gosstroy == 0 && a.data[52] == 37)))
		{
			this_num_event = 410;
			return true;
		}
		if (a.allcountries[1].isASEAN && a.allcountries[51].spec <= 0 && (a.allcountries[1].Gosstroy == 1 || (a.allcountries[1].Gosstroy == 0 && a.data[52] == 34)))
		{
			this_num_event = 411;
			return true;
		}
		if (!a.event_done[412] && !a.allcountries[31].isASEAN && a.allcountries[31].Vyshi && a.allcountries[8].isSENTO && a.allcountries[1].isSEATO && a.data[21] >= 1980 && a.data[20] >= 5)
		{
			this_num_event = 412;
			return true;
		}
		if (!a.event_done[413] && !a.allcountries[51].cw && (!a.allcountries[31].isSENTO || !a.allcountries[8].isSENTO) && ((a.data[21] >= 1979 && a.data[20] >= 4) || a.data[21] >= 1980))
		{
			this_num_event = 413;
			return true;
		}
		if (!a.event_done[414] && ((a.data[21] == 1976 && a.data[20] >= 4 && a.data[19] >= 20) || (a.data[21] == 1976 && a.data[20] >= 5) || a.data[21] >= 1977))
		{
			this_num_event = 414;
			return true;
		}
		if (!a.event_done[415] && ((a.data[21] == 1979 && a.data[20] >= 3 && a.data[19] >= 14) || (a.data[21] == 1979 && a.data[20] >= 4) || a.data[21] >= 1980))
		{
			this_num_event = 415;
			return true;
		}
		if (!a.event_done[416] && ((a.data[21] == 1983 && a.data[20] >= 3 && a.data[19] >= 10) || (a.data[21] == 1983 && a.data[20] >= 4) || a.data[21] >= 1984) && !a.allcountries[48].isSEV && a.empires[0].now_leader == 0)
		{
			this_num_event = 416;
			return true;
		}
		if (!a.event_done[417] && !a.OAR && ((a.data[21] >= 1981 && a.data[21] < 1983 && a.data[20] >= 3) || (a.data[21] >= 1982 && a.data[21] < 1983)) && (a.allcountries[8].isSEATO || a.allcountries[8].isSENTO || a.allcountries[8].isOVD || a.allcountries[8].okb) && !a.ingamewars[3].is_going && a.allcountries[14].Gosstroy == 0 && !a.ingamewars[42].is_going)
		{
			this_num_event = 417;
			return true;
		}
		if (!a.event_done[418] && ((a.data[21] >= 1981 && a.data[20] >= 5) || a.data[21] >= 1982) && !a.ingamewars[28].is_going && !a.allcountries[14].parts[5] && a.modifies[51].active)
		{
			this_num_event = 418;
			return true;
		}
		if (!a.event_done[419] && a.allcountries[87].spec >= 50 && a.allcountries[87].Gosstroy == 2)
		{
			this_num_event = 419;
			return true;
		}
		if (!a.event_done[420] && !a.event_done[419] && a.allcountries[87].Gosstroy == 2 && ((a.data[21] >= 1982 && a.data[20] >= 5) || a.data[21] >= 1983))
		{
			this_num_event = 420;
			return true;
		}
		if (!a.event_done[421] && !a.allcountries[87].isNATO && !a.allcountries[21].isNATO && !a.allcountries[84].isNATO && !a.allcountries[86].isNATO && !a.allcountries[45].isNATO && !a.allcountries[92].isNATO && !a.allcountries[7].isNATO && a.allcountries[17].dev != 2 && (a.data[21] >= 1984 || !a.allcountries[17].isNATO))
		{
			this_num_event = 421;
			return true;
		}
		if (!a.event_done[422] && !a.allcountries[21].isEU && !a.allcountries[85].isEU && !a.allcountries[86].isEU && !a.allcountries[92].isEU && !a.allcountries[45].isEU)
		{
			this_num_event = 422;
			return true;
		}
		if (!a.event_done[423] && ((a.data[21] == 1977 && a.data[20] >= 6) || a.data[21] >= 1978))
		{
			this_num_event = 423;
			return true;
		}
		if (!a.event_done[424] && ((a.data[21] == 1978 && a.data[20] >= 11 && a.data[19] > 9) || (a.data[21] == 1978 && a.data[20] >= 12) || a.data[21] >= 1979))
		{
			this_num_event = 424;
			return true;
		}
		if (!a.event_done[425] && ((a.data[21] == 1979 && a.data[20] >= 2 && a.data[19] > 1) || (a.data[21] == 1979 && a.data[20] >= 3) || a.data[21] >= 1980) && a.resultOfEvents[424] == 1)
		{
			this_num_event = 425;
			return true;
		}
		if (!a.event_done[426] && a.resultOfEvents[424] == 0 && a.event_done[424] && ((a.data[21] == 1979 && a.data[20] >= 2 && a.data[19] > 1) || (a.data[21] == 1979 && a.data[20] >= 3) || a.data[21] >= 1980) && a.ingamewars[30].is_going)
		{
			this_num_event = 426;
			return true;
		}
		if (!a.event_done[427] && a.resultOfEvents[425] == 1 && a.event_done[425] && ((a.data[21] == 1981 && a.data[20] >= 2 && a.data[19] > 16) || (a.data[21] == 1981 && a.data[20] >= 3) || a.data[21] >= 1982))
		{
			this_num_event = 427;
			return true;
		}
		if (!a.event_done[428] && a.allcountries[86].Gosstroy == 3 && a.resultOfEvents[424] == 1 && ((a.data[21] == 1982 && a.data[20] >= 6) || a.data[21] >= 1983))
		{
			this_num_event = 428;
			return true;
		}
		if (!a.event_done[429] && a.allcountries[86].isNATO && ((a.data[21] == 1982 && a.data[20] >= 11) || a.data[21] >= 1983))
		{
			this_num_event = 429;
			return true;
		}
		if (!a.event_done[479] && a.event_done[419] && ((a.data[21] >= 1983 && a.data[20] >= 4 && a.data[19] >= 25) || (a.data[21] >= 1983 && a.data[20] >= 5) || a.data[21] >= 1984))
		{
			this_num_event = 479;
			return true;
		}
		if (!a.event_done[430] && ((a.data[21] == 1983 && a.data[20] >= 5 && a.data[19] > 14) || (a.data[21] == 1983 && a.data[20] >= 6) || a.data[21] >= 1984) && a.allcountries[86].SubGosstroy == 3 && a.allcountries[85].SubGosstroy == 14 && a.allcountries[85].isSocEU && a.allcountries[21].SubGosstroy == 14)
		{
			this_num_event = 430;
			return true;
		}
		if (!a.event_done[431] && !a.event_done[432] && ((a.data[21] == 1983 && a.data[20] >= 9) || a.data[21] >= 1984) && !a.allcountries[86].isSocEU && a.allcountries[86].SubGosstroy == 3 && a.allcountries[0].isEU)
		{
			this_num_event = 431;
			return true;
		}
		if (!a.event_done[432] && ((a.data[21] == 1983 && a.data[20] >= 8) || a.data[21] > 1983) && a.resultOfEvents[424] == 0 && a.allcountries[86].SubGosstroy == 6)
		{
			this_num_event = 432;
			return true;
		}
		if (!a.event_done[433] && a.empires[1].now_leader == 6 && !a.allcountries[2].isOVD && !a.allcountries[5].isOVD && !a.allcountries[4].isOVD && a.allcountries[51].isNATO && a.allcountries[17].dev == 2 && a.allcountries[17].Gosstroy == 3)
		{
			this_num_event = 433;
			return true;
		}
		if (!a.event_done[433] && !a.event_done[472] && a.empires[1].now_leader == 6 && !a.allcountries[2].isOVD && !a.allcountries[5].isOVD && !a.allcountries[4].isOVD && !a.allcountries[6].isOVD && !a.allcountries[21].isSocEU && (a.allcountries[17].dev == 1 || a.allcountries[17].dev == 2 || (a.allcountries[17].dev == 3 && !a.allcountries[16].prosov)) && !a.allcountries[51].isNATO && !a.allcountries[1].isSEV)
		{
			this_num_event = 472;
			return true;
		}
		if (!a.event_done[473] && a.empires[1].now_leader == 6 && !a.allcountries[7].isOVD && !a.allcountries[1].isSEV && a.empires[1].power <= -300)
		{
			this_num_event = 473;
			return true;
		}
		if (!a.event_done[474] && ((a.data[21] >= 1979 && a.data[20] >= 10 && a.data[19] >= 10) || (a.data[21] >= 1979 && a.data[20] >= 11) || a.data[21] >= 1980))
		{
			this_num_event = 474;
			return true;
		}
		if (!a.event_done[475] && GlobalScript.inst.gameState.allcountries[41].proprc && GlobalScript.inst.gameState.allcountries[41].Gosstroy != 2 && GlobalScript.inst.gameState.ingamewars[24].infl2 >= 900 && !a.allcountries[41].parts[0] && !a.allcountries[41].parts[1])
		{
			this_num_event = 475;
			return true;
		}
		if (!a.event_done[476] && GlobalScript.inst.gameState.data[147] == 6 && ((a.data[21] >= 1984 && a.data[20] >= 11) || a.data[21] >= 1985))
		{
			this_num_event = 476;
			return true;
		}
		if (!a.event_done[477] && GlobalScript.inst.gameState.allcountries[92].Torg && GlobalScript.inst.gameState.allcountries[92].Gosstroy != 0 && ((a.data[21] >= 1980 && a.data[20] >= 3) || a.data[21] >= 1981))
		{
			this_num_event = 477;
			return true;
		}
		if (!a.event_done[478] && !a.event_done[419] && a.allcountries[87].spec <= 20 && ((a.data[21] >= 1980 && a.data[20] >= 4 && a.data[19] >= 20) || (a.data[21] >= 1980 && a.data[20] >= 5) || a.data[21] >= 1981))
		{
			this_num_event = 478;
			return true;
		}
		if (!a.event_done[480] && a.event_done[479] && a.resultOfEvents[479] == 1 && ((a.data[21] >= 1985 && a.data[20] >= 10 && a.data[19] >= 6) || (a.data[21] >= 1985 && a.data[20] >= 11) || a.data[21] >= 1986))
		{
			this_num_event = 480;
			return true;
		}
		if (!a.event_done[481] && a.allcountries[85].SubGosstroy == 10 && ((a.data[21] >= 1984 && a.data[20] >= 3) || a.data[21] >= 1985))
		{
			this_num_event = 481;
			return true;
		}
		if (!a.event_done[483] && a.allcountries[21].Gosstroy == 3 && a.allcountries[85].Gosstroy != 3 && a.allcountries[86].Gosstroy != 3 && a.allcountries[87].Gosstroy != 3 && a.allcountries[92].Gosstroy != 3 && a.allcountries[45].Gosstroy != 3 && a.data[21] >= 1984 && a.data[20] == 5)
		{
			this_num_event = 483;
			return true;
		}
		if (!a.event_done[486] && ((a.data[21] >= 1977 && a.data[20] >= 10 && a.data[19] >= 17) || (a.data[21] >= 1977 && a.data[20] >= 11) || a.data[21] >= 1978))
		{
			this_num_event = 486;
			return true;
		}
		if (!a.event_done[487] && ((a.data[21] >= 1981 && a.data[20] >= 2 && a.data[19] >= 5) || (a.data[21] >= 1981 && a.data[20] >= 3) || a.data[21] >= 1982))
		{
			this_num_event = 487;
			return true;
		}
		if (!a.event_done[488] && (a.allcountries[17].Gosstroy != 2 || a.allcountries[17].isSocEU) && !a.allcountries[2].prosov && !a.allcountries[4].prosov && !a.allcountries[5].prosov && a.empires[1].power <= 100 && (GlobalScript.inst.gameState.empires[1].now_leader == 5 || GlobalScript.inst.gameState.empires[1].now_leader == 6 || a.empires[1].now_leader == 8) && ((a.data[21] >= 1985 && a.data[20] >= 6 && a.data[19] >= 17) || (a.data[21] >= 1985 && a.data[20] >= 7) || a.data[21] >= 1986))
		{
			this_num_event = 488;
			return true;
		}
		if (!a.event_done[489] && a.allcountries[84].cw && a.allcountries[84].Gosstroy == 2 && ((a.data[21] >= 1984 && a.data[20] >= 1 && a.data[19] >= 1) || (a.data[21] >= 1985 && a.data[20] >= 7) || a.data[21] >= 1984))
		{
			this_num_event = 489;
			return true;
		}
		if (!a.event_done[491] && ((a.data[21] >= 1982 && a.data[20] >= 11 && a.data[19] >= 17) || (a.data[21] >= 1982 && a.data[20] >= 12) || a.data[21] >= 1983))
		{
			this_num_event = 491;
			return true;
		}
		if (!a.event_done[492] && ((a.allcountries[2].proprc && a.allcountries[5].proprc && !a.allcountries[4].prosov) || (!a.allcountries[2].prosov && a.allcountries[2].Gosstroy == 2 && !a.allcountries[5].prosov && a.allcountries[5].Gosstroy == 2 && !a.allcountries[4].prosov && a.allcountries[4].Gosstroy == 2)) && !a.allcountries[1].isSEV && !a.allcountries[1].isOVD && !a.allcountries[1].isASEAN && !a.allcountries[1].isSEATO && ((a.data[21] >= 1984 && a.data[20] >= 9 && a.data[19] >= 9) || (a.data[21] >= 1984 && a.data[20] >= 10) || a.data[21] >= 1985))
		{
			this_num_event = 492;
			return true;
		}
		if (!a.event_done[493] && ((a.data[21] >= 1978 && a.data[20] >= 10 && a.data[19] >= 8) || (a.data[21] >= 1978 && a.data[20] >= 11) || a.data[21] >= 1979))
		{
			this_num_event = 493;
			return true;
		}
		if (!a.event_done[494] && !a.event_done[112] && a.event_done[97] && a.science[16])
		{
			this_num_event = 494;
			return true;
		}
		if (!a.event_done[501] && a.allcountries[2].puppetOf != 7 && ((a.data[21] >= 1981 && a.data[20] >= 9 && a.data[19] >= 4) || (a.data[21] >= 1981 && a.data[20] >= 10) || a.data[21] >= 1982))
		{
			this_num_event = 501;
			return true;
		}
		if (!a.event_done[434] && a.ingamewars[26].is_going && a.ingamewars[26].fortnight_go >= 12 && a.resultOfEvents[481] == 1)
		{
			this_num_event = 434;
			return true;
		}
		if (!a.event_done[553] && a.event_done[434] && a.allcountries[42].Gosstroy == 0 && a.allcountries[42].SubGosstroy == 7 && GlobalScript.inst.gameState.allcountries[42].Vyshi && a.resultOfEvents[481] == 1)
		{
			this_num_event = 553;
			return true;
		}
		if (!a.event_done[554] && a.event_done[37] && a.allcountries[30].Gosstroy == 3 && a.allcountries[30].Vyshi && ((a.data[21] >= 1981 && a.data[20] >= 10 && a.data[19] >= 6) || (a.data[21] >= 1981 && a.data[20] >= 11) || a.data[21] >= 1982))
		{
			this_num_event = 554;
			return true;
		}
		if (GlobalScript.inst.gameState.data[5] < 100 && GlobalScript.inst.gameState.influencePRC < 50 && GlobalScript.inst.gameState.data[14] >= 5 && GlobalScript.inst.gameState.data[67] > 0 && GlobalScript.inst.gameState.data[66] > 0 && GlobalScript.inst.gameState.data[65] <= 0 && GlobalScript.inst.gameState.data[62] <= 0 && a.data[104] != 10)
		{
			this_num_event = 666;
			return true;
		}
		return false;
	}

	public static bool RequrementsDLC01(ref int this_num_event, GameState a)
	{
		if (((a.allcountries[73].next_elections.Month <= a.data[20] && a.allcountries[73].next_elections.Year <= a.data[21]) || a.allcountries[73].next_elections.Year < a.data[21]) && (!a.allcountries[73].proprc || a.allcountries[73].Gosstroy == 3) && !a.event_done[126])
		{
			this_num_event = 126;
			return true;
		}
		if (((a.allcountries[73].next_elections.Month <= a.data[20] && a.allcountries[73].next_elections.Year <= a.data[21]) || a.allcountries[73].next_elections.Year < a.data[21]) && (!a.allcountries[73].proprc || a.allcountries[73].Gosstroy == 3) && a.event_done[126] && !a.event_done[127])
		{
			this_num_event = 127;
			return true;
		}
		if (((a.allcountries[71].next_elections.Month <= a.data[20] && a.allcountries[71].next_elections.Year <= a.data[21]) || a.allcountries[71].next_elections.Year < a.data[21]) && (!a.allcountries[71].proprc || a.allcountries[71].Gosstroy == 3) && !a.event_done[128])
		{
			this_num_event = 128;
			return true;
		}
		if (((a.allcountries[71].next_elections.Month <= a.data[20] && a.allcountries[71].next_elections.Year <= a.data[21]) || a.allcountries[71].next_elections.Year < a.data[21]) && (!a.allcountries[71].proprc || a.allcountries[71].Gosstroy == 3) && a.event_done[128] && !a.event_done[129])
		{
			this_num_event = 129;
			return true;
		}
		if (((a.allcountries[72].next_elections.Month <= a.data[20] && a.allcountries[72].next_elections.Year <= a.data[21]) || a.allcountries[72].next_elections.Year < a.data[21]) && (!a.allcountries[72].proprc || a.allcountries[72].Gosstroy == 3) && !a.event_done[130])
		{
			this_num_event = 130;
			return true;
		}
		if (((a.allcountries[72].next_elections.Month <= a.data[20] && a.allcountries[72].next_elections.Year <= a.data[21]) || a.allcountries[72].next_elections.Year < a.data[21]) && (!a.allcountries[72].proprc || a.allcountries[72].Gosstroy == 3) && a.event_done[130] && !a.event_done[131])
		{
			this_num_event = 131;
			return true;
		}
		if (((a.allcountries[72].next_elections.Month <= a.data[20] && a.allcountries[72].next_elections.Year <= a.data[21]) || a.allcountries[72].next_elections.Year < a.data[21]) && (!a.allcountries[72].proprc || a.allcountries[72].Gosstroy == 3) && a.event_done[131] && !a.event_done[132])
		{
			this_num_event = 132;
			return true;
		}
		if (((a.allcountries[74].next_elections.Month <= a.data[20] && a.allcountries[74].next_elections.Year <= a.data[21]) || a.allcountries[74].next_elections.Year < a.data[21]) && (!a.allcountries[74].proprc || a.allcountries[74].Gosstroy == 3) && !a.event_done[133])
		{
			this_num_event = 133;
			return true;
		}
		if (((a.allcountries[74].next_elections.Month <= a.data[20] && a.allcountries[74].next_elections.Year <= a.data[21]) || a.allcountries[74].next_elections.Year < a.data[21]) && (!a.allcountries[74].proprc || a.allcountries[74].Gosstroy == 3) && a.event_done[133] && !a.event_done[134])
		{
			this_num_event = 134;
			return true;
		}
		if (((a.allcountries[82].next_elections.Month <= a.data[20] && a.allcountries[82].next_elections.Year <= a.data[21]) || a.allcountries[82].next_elections.Year < a.data[21]) && (!a.allcountries[82].proprc || a.allcountries[82].Gosstroy == 3) && !a.event_done[135])
		{
			this_num_event = 135;
			return true;
		}
		if (((a.allcountries[82].next_elections.Month <= a.data[20] && a.allcountries[82].next_elections.Year <= a.data[21]) || a.allcountries[82].next_elections.Year < a.data[21]) && (!a.allcountries[82].proprc || a.allcountries[82].Gosstroy == 3) && a.event_done[135] && !a.event_done[136])
		{
			this_num_event = 136;
			return true;
		}
		if (((a.allcountries[82].next_elections.Month <= a.data[20] && a.allcountries[82].next_elections.Year <= a.data[21]) || a.allcountries[82].next_elections.Year < a.data[21]) && (!a.allcountries[82].proprc || a.allcountries[82].Gosstroy == 3) && a.event_done[136] && !a.event_done[137])
		{
			this_num_event = 137;
			return true;
		}
		if (((a.allcountries[79].next_elections.Month <= a.data[20] && a.allcountries[79].next_elections.Year <= a.data[21]) || a.allcountries[79].next_elections.Year < a.data[21]) && (!a.allcountries[79].proprc || a.allcountries[79].Gosstroy == 3) && !a.event_done[138])
		{
			this_num_event = 138;
			return true;
		}
		if (((a.allcountries[79].next_elections.Month <= a.data[20] && a.allcountries[79].next_elections.Year <= a.data[21]) || a.allcountries[79].next_elections.Year < a.data[21]) && (!a.allcountries[79].proprc || a.allcountries[79].Gosstroy == 3) && a.resultOfEvents[138] == 0 && a.event_done[138] && !a.event_done[139])
		{
			this_num_event = 139;
			return true;
		}
		if (((a.allcountries[79].next_elections.Month <= a.data[20] && a.allcountries[79].next_elections.Year <= a.data[21]) || a.allcountries[79].next_elections.Year < a.data[21]) && (!a.allcountries[79].proprc || a.allcountries[79].Gosstroy == 3) && a.resultOfEvents[138] != 0 && a.event_done[138] && !a.event_done[140])
		{
			this_num_event = 140;
			return true;
		}
		if (((a.allcountries[80].next_elections.Month <= a.data[20] && a.allcountries[80].next_elections.Year <= a.data[21]) || a.allcountries[80].next_elections.Year < a.data[21]) && (!a.allcountries[80].proprc || a.allcountries[80].Gosstroy == 3) && !a.event_done[141])
		{
			this_num_event = 141;
			return true;
		}
		if (((a.allcountries[80].next_elections.Month <= a.data[20] && a.allcountries[80].next_elections.Year <= a.data[21]) || a.allcountries[80].next_elections.Year < a.data[21]) && (!a.allcountries[80].proprc || a.allcountries[80].Gosstroy == 3) && a.event_done[141] && !a.event_done[142])
		{
			this_num_event = 142;
			return true;
		}
		if (((a.allcountries[76].next_elections.Month <= a.data[20] && a.allcountries[76].next_elections.Year <= a.data[21]) || a.allcountries[76].next_elections.Year < a.data[21]) && (!a.allcountries[76].proprc || a.allcountries[76].Gosstroy == 3) && !a.event_done[143])
		{
			this_num_event = 143;
			return true;
		}
		if (((a.allcountries[76].next_elections.Month <= a.data[20] && a.allcountries[76].next_elections.Year <= a.data[21]) || a.allcountries[76].next_elections.Year < a.data[21]) && (!a.allcountries[76].proprc || a.allcountries[76].Gosstroy == 3) && a.event_done[143] && !a.event_done[144])
		{
			this_num_event = 144;
			return true;
		}
		if (((a.allcountries[75].next_elections.Month <= a.data[20] && a.allcountries[75].next_elections.Year <= a.data[21]) || a.allcountries[75].next_elections.Year < a.data[21]) && (!a.allcountries[75].proprc || a.allcountries[75].Gosstroy == 3) && !a.event_done[145])
		{
			this_num_event = 145;
			return true;
		}
		if (((a.allcountries[75].next_elections.Month <= a.data[20] && a.allcountries[75].next_elections.Year <= a.data[21]) || a.allcountries[75].next_elections.Year < a.data[21]) && (!a.allcountries[75].proprc || a.allcountries[75].Gosstroy == 3) && a.event_done[145] && !a.event_done[146])
		{
			this_num_event = 146;
			return true;
		}
		if (((a.allcountries[83].next_elections.Month <= a.data[20] && a.allcountries[83].next_elections.Year <= a.data[21]) || a.allcountries[83].next_elections.Year < a.data[21]) && (!a.allcountries[83].proprc || a.allcountries[83].Gosstroy == 3) && !a.event_done[147])
		{
			this_num_event = 147;
			return true;
		}
		if (((a.allcountries[83].next_elections.Month <= a.data[20] && a.allcountries[83].next_elections.Year <= a.data[21]) || a.allcountries[83].next_elections.Year < a.data[21]) && (!a.allcountries[83].proprc || a.allcountries[83].Gosstroy == 3) && a.event_done[147] && !a.event_done[148])
		{
			this_num_event = 148;
			return true;
		}
		if (((a.allcountries[77].next_elections.Month <= a.data[20] && a.allcountries[77].next_elections.Year <= a.data[21]) || a.allcountries[77].next_elections.Year < a.data[21]) && (!a.allcountries[77].proprc || a.allcountries[77].Gosstroy == 3) && !a.event_done[149])
		{
			this_num_event = 149;
			return true;
		}
		if (((a.allcountries[77].next_elections.Month <= a.data[20] && a.allcountries[77].next_elections.Year <= a.data[21]) || a.allcountries[77].next_elections.Year < a.data[21]) && (!a.allcountries[77].proprc || a.allcountries[77].Gosstroy == 3) && a.event_done[149] && !a.event_done[150])
		{
			this_num_event = 150;
			return true;
		}
		if (((a.allcountries[81].next_elections.Month <= a.data[20] && a.allcountries[81].next_elections.Year <= a.data[21]) || a.allcountries[81].next_elections.Year < a.data[21]) && (!a.allcountries[81].proprc || a.allcountries[81].Gosstroy == 3) && !a.event_done[151])
		{
			this_num_event = 151;
			return true;
		}
		return false;
	}
}
