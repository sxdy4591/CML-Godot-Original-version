using System;
using MoonSharp.Interpreter;
using UnityEngine.SceneManagement;

namespace KGEvent
{
	[Serializable]
	[MoonSharpUserData]
	public class QueryDecisions<T> where T : IRequesting<T>
	{
		private T target;

		public QueryDecisions(T target)
		{
			this.target = target;
		}

		public T TheyAreOurs(int country)
		{
			Func<bool> func = () => (GlobalScript.inst.gameState.allcountries[country].okb && GlobalScript.inst.gameState.allcountries[country].econ) || (GlobalScript.inst.gameState.allcountries[country].isSEV && GlobalScript.inst.gameState.allcountries[country].isOVD && GlobalScript.inst.gameState.allcountries[1].isOVD) || (GlobalScript.inst.gameState.allcountries[country].isSEATO && GlobalScript.inst.gameState.allcountries[1].isSEATO);
			T val;
			if (country != 1)
			{
				T reference = target;
				string text = string.Format("{0} {1}: <color={2}>{3}</color>", GlobalScript.inst.gameState.allcountries[country].name, GlobalScript.inst.new_texts[99], func() ? "lime" : "red", func() ? "✔" : "☓");
				reference.AddReq(text);
			}
			else
			{
				T reference2 = target;
				string text2 = string.Format("{1}: <color={2}>{3}</color>", GlobalScript.inst.gameState.allcountries[country].name, GlobalScript.inst.new_texts[330], func() ? "lime" : "red", func() ? "✔" : "☓");
				reference2.AddReq(text2);
			}
			return target.CreateCondition(func);
		}

		public T ProChinese(int country)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.allcountries[country].proprc;
			target.AddReq(string.Format("{0} {1}: <color={2}>{3}</color>", GlobalScript.inst.gameState.allcountries[country].name, GlobalScript.inst.new_texts[100], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T TibetIsOurs(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[67] > 0) : (GlobalScript.inst.gameState.data[67] <= 0);
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[101], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T UyghurIsOurs(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[66] > 0) : (GlobalScript.inst.gameState.data[66] <= 0);
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[102], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasAgents(int num)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.data[9] >= num;
			target.AddReq(string.Format("{1} - {0:F1}: <color={2}>{3}</color>", (float)num / 10f, GlobalScript.inst.new_texts[149], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasMoney(int num)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= num;
			target.AddReq(string.Format("{1} - {0:F1}: <color={2}>{3}</color>", (float)num / 10f, GlobalScript.inst.new_texts[150], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasArmy(int num)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.data[22] >= num;
			target.AddReq(string.Format("{1} - {0:F1}: <color={2}>{3}</color>", (float)num / 10f, GlobalScript.inst.new_texts[155], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasSomeoneWonInTheWar(int war, int side, int country)
		{
			Func<bool> func = () => (side != 0) ? (GlobalScript.inst.gameState.ingamewars[war].infl2 >= 900) : (GlobalScript.inst.gameState.ingamewars[war].infl1 >= 900);
			target.AddReq(string.Format("{0} {1} {2}: <color={3}</color>", GlobalScript.inst.gameState.ingamewars[war].name_war, GlobalScript.inst.new_texts[329], GlobalScript.inst.gameState.allcountries[country].name, func() ? "lime>✔" : "red>☓"));
			return target.CreateCondition(func);
		}

		public T IsUnitarism(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[18] != 20) : (GlobalScript.inst.gameState.data[18] == 20);
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[151], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsLiberal(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.IsFactionLeadeng(4) && (GlobalScript.inst.gameState.data[52] < 36 || GlobalScript.inst.gameState.data[54] < 40)) : (GlobalScript.inst.gameState.IsFactionLeadeng(4) || (GlobalScript.inst.gameState.data[52] >= 36 && GlobalScript.inst.gameState.data[54] >= 40));
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[152], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsAutoritharian(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.IsFactionLeadeng(0) && !GlobalScript.inst.gameState.IsFactionLeadeng(3) && (GlobalScript.inst.gameState.data[15] < 8 || GlobalScript.inst.gameState.data[54] > 38)) : (GlobalScript.inst.gameState.IsFactionLeadeng(0) || GlobalScript.inst.gameState.IsFactionLeadeng(3) || (GlobalScript.inst.gameState.data[15] >= 8 && GlobalScript.inst.gameState.data[54] <= 38));
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[153], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsTraditional(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[15] < 28) : (GlobalScript.inst.gameState.data[50] >= 28);
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[562], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsRadicalTradition(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[50] > 24) : (GlobalScript.inst.gameState.data[50] <= 24);
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 破 除 传 统-", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsPartyEnabled(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.is_party_enabled[num]) : GlobalScript.inst.gameState.is_party_enabled[num];
			target.AddReq(string.Format("{1} {4} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[156], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.new_texts[191 + num]));
			return target.CreateCondition(func);
		}

		public T HasOnePartyMechanic(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[15] <= 7) : (GlobalScript.inst.gameState.data[15] <= 7);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[157], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T AllLeadersAreDead()
		{
			int banda_4 = 0;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic != null)
				{
					if (politic.traits[0] == 0 && (((politic.name_1 == 0) & (politic.name_2 == 0)) || ((politic.name_1 == 3) & (politic.name_2 == 3)) || (politic.name_1 == 4 && politic.name_2 == 4) || (politic.name_1 == 5 && politic.name_2 == 5)))
					{
						banda_4++;
					}
					else if (politic.name_1 == 2 && politic.name_2 == 2)
					{
						banda_4++;
					}
					else if (politic.name_1 == 13 && politic.name_2 == 13)
					{
						banda_4++;
					}
				}
			}
			Func<bool> func = () => banda_4 <= 0;
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[158], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsPoliticianAlive(int name1, int name2, int trait0, int trait1, int trait2)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.FindPerson(name1, name2, trait0, trait1, trait2) >= 0;
			target.AddReq(string.Format("{3} {4} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[225], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.names1[name1], GlobalScript.inst.gameState.names2[name2]));
			return target.CreateCondition(func);
		}

		public T HasAutonomyForMacao(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[65] != 1) : (GlobalScript.inst.gameState.data[65] == 1);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[159], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasAnnexedMacao(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[65] != 2) : (GlobalScript.inst.gameState.data[65] == 2);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[166], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsTaiwanAttacked(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.allcountries[38].dev == 0) : (GlobalScript.inst.gameState.allcountries[38].dev != 0);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[160], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsInTheOVD(bool yes, int country)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[country].isOVD) : GlobalScript.inst.gameState.allcountries[country].isOVD;
			target.AddReq(string.Format("{4} {1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[112] : GlobalScript.inst.new_texts[111], GlobalScript.inst.new_texts[161], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name));
			return target.CreateCondition(func);
		}

		public T IsInTheSEV(bool yes, int country)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[country].isSEV) : GlobalScript.inst.gameState.allcountries[country].isSEV;
			target.AddReq(string.Format("{4} {1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[112] : GlobalScript.inst.new_texts[111], GlobalScript.inst.new_texts[162], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name));
			return target.CreateCondition(func);
		}

		public T IsInTheASEAN(bool yes, int country)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[country].isASEAN) : GlobalScript.inst.gameState.allcountries[country].isASEAN;
			target.AddReq(string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[639], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name));
			return target.CreateCondition(func);
		}

		public T IsInTheWP(bool yes, int country)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[country].isOVD) : GlobalScript.inst.gameState.allcountries[country].isOVD;
			target.AddReq(string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[649], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name));
			return target.CreateCondition(func);
		}

		public T IsInTheSEATO(bool yes, int country)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[country].isSEATO) : GlobalScript.inst.gameState.allcountries[country].isSEATO;
			target.AddReq(string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[638], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name));
			return target.CreateCondition(func);
		}

		public T IsInTheSENTO(bool yes, int country)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[country].isSENTO) : GlobalScript.inst.gameState.allcountries[country].isSENTO;
			target.AddReq(string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[640], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name));
			return target.CreateCondition(func);
		}

		public T HasCulturalRevolution(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.modifies[3].active) : GlobalScript.inst.gameState.modifies[3].active;
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[163], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasOil(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.modifies[51].active) : GlobalScript.inst.gameState.modifies[51].active;
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[674], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasMaoismus(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.modifies[6].active) : GlobalScript.inst.gameState.modifies[6].active;
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[164], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsDipRepLessThan(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[6] > num) : (GlobalScript.inst.gameState.data[6] < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[165], func() ? "lime" : "red", func() ? "✔" : "☓", (float)num / 10f));
			return target.CreateCondition(func);
		}

		public T IsUnityLessThan(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[57] >= num) : (GlobalScript.inst.gameState.data[57] < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[568], func() ? "lime" : "red", func() ? "✔" : "☓", (float)num / 10f));
			return target.CreateCondition(func);
		}

		public T IsAmericanInfluenceLessThan(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.empires[0].power > num) : (GlobalScript.inst.gameState.empires[0].power < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[167], func() ? "lime" : "red", func() ? "✔" : "☓", (float)num / 10f));
			return target.CreateCondition(func);
		}

		public T IsSovietInfluenceLessThan(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.empires[1].power > num) : (GlobalScript.inst.gameState.empires[1].power < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[168], func() ? "lime" : "red", func() ? "✔" : "☓", (float)num / 10f));
			return target.CreateCondition(func);
		}

		public T IsChineseInfluenceLessThan(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.influencePRC > num) : (GlobalScript.inst.gameState.influencePRC < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[169], func() ? "lime" : "red", func() ? "✔" : "☓", (float)num / 10f));
			return target.CreateCondition(func);
		}

		public T IsChiSovInfluenceLessThan(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.influencePRC + (GlobalScript.inst.gameState.allcountries[1].isOVD ? GlobalScript.inst.gameState.empires[1].power : 0) > num) : (GlobalScript.inst.gameState.influencePRC + (GlobalScript.inst.gameState.allcountries[1].isOVD ? GlobalScript.inst.gameState.empires[1].power : 0) < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[331], func() ? "lime" : "red", func() ? "✔" : "☓", (float)num / 10f));
			return target.CreateCondition(func);
		}

		public T HasAgressiveMilitaryDoctrine(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[51] <= 31) : (GlobalScript.inst.gameState.data[51] <= 31);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[170], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasLeader(int name1, int name2, int trait0, int trait1, int trait2)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.leader.traits[2] == trait2 && GlobalScript.inst.gameState.leader.traits[1] == trait1 && GlobalScript.inst.gameState.leader.traits[0] == trait0 && GlobalScript.inst.gameState.leader.name_2 == name2 && GlobalScript.inst.gameState.leader.name_1 == name1;
			target.AddReq(string.Format("{0} - {1} {4}: <color={2}>{3}</color>", GlobalScript.inst.new_texts[561], GlobalScript.inst.gameState.names1[name1], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.names2[name2]));
			return target.CreateCondition(func);
		}

		public T HasLeftRadicalLeader(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.leader.traits[0] > 0) : (GlobalScript.inst.gameState.leader.traits[0] == 0);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[171], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsMaoPraised(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.event_done[39] || !GlobalScript.inst.gameState.modifies[6].active || GlobalScript.inst.gameState.data[90] != 0) : (GlobalScript.inst.gameState.event_done[39] && GlobalScript.inst.gameState.data[90] == 0 && GlobalScript.inst.gameState.modifies[6].active);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[172], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsNotAntiMaoInTheUSSR()
		{
			Func<bool> func = () => GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.empires[1].now_leader != 5;
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[173], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasCommunistLeader(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.leader.traits[0] != 0 && GlobalScript.inst.gameState.leader.traits[0] != 1 && GlobalScript.inst.gameState.leader.traits[0] != 20) : (GlobalScript.inst.gameState.leader.traits[0] == 0 || GlobalScript.inst.gameState.leader.traits[0] == 1 || GlobalScript.inst.gameState.leader.traits[0] == 20);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[174], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasSovietFriendship(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.relres) : GlobalScript.inst.gameState.relres;
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[175], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasEuropeansPuppets()
		{
			Func<bool> func = () => GlobalScript.inst.gameState.allcountries[2].proprc && GlobalScript.inst.gameState.allcountries[5].proprc && !GlobalScript.inst.gameState.allcountries[4].prosov;
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[176], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasGorbachev()
		{
			Func<bool> func = () => GlobalScript.inst.gameState.empires[1].now_leader == 6;
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[177], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsYearLess(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[21] > num) : (GlobalScript.inst.gameState.data[21] < num);
			target.AddReq(string.Format("{1} {0} {4}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[178], func() ? "lime" : "red", func() ? "✔" : "☓", num));
			return target.CreateCondition(func);
		}

		public T HasOngoingWar(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? GlobalScript.inst.gameState.ingamewars[num].is_going : GlobalScript.inst.gameState.ingamewars[num].is_going;
			target.AddReq(string.Format("{1} \"{4}\" - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[179], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.gameState.ingamewars[num].name_war));
			return target.CreateCondition(func);
		}

		public T HasChosenInTheEvent(int eventNum, int answerNum, int name)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.resultOfEvents[eventNum] == answerNum;
			target.AddReq(string.Format("\"{0}\" - {1} {2}: <color={3}>{4}</color>", GlobalScript.inst.new_events_text[name], GlobalScript.inst.new_texts[565], answerNum + 1, func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasModerateFaction(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.IsFactionLeadeng(2)) : GlobalScript.inst.gameState.IsFactionLeadeng(2);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[180], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasRealModerateLeader(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.leader.traits[0] != 1 && GlobalScript.inst.gameState.leader.traits[0] != 20) : (GlobalScript.inst.gameState.leader.traits[0] == 1 || GlobalScript.inst.gameState.leader.traits[0] == 20);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[186], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasModerateLeader(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.leader.traits[0] != 1 && GlobalScript.inst.gameState.leader.traits[0] != 2 && GlobalScript.inst.gameState.leader.traits[0] != 20) : (GlobalScript.inst.gameState.leader.traits[0] == 1 || GlobalScript.inst.gameState.leader.traits[0] == 2 || GlobalScript.inst.gameState.leader.traits[0] == 20);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], "  中 国 领 袖 为 保 守 派 / 温 和 派/ 改 革 派", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsLeftRadBanned()
		{
			Func<bool> func = () => !GlobalScript.inst.gameState.is_party_enabled[0];
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[182], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsFactionBanned(int num)
		{
			Func<bool> func = () => !GlobalScript.inst.gameState.is_party_enabled[num];
			target.AddReq(string.Format("{0} - {1}: <color={2}>{3}</color>", GlobalScript.inst.new_texts[566], GlobalScript.inst.new_texts[num + 324], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasCapitalistEconomy(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[16] <= 13) : (GlobalScript.inst.gameState.data[16] > 13);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[183], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasOligarchyPowerLess(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[108] > num) : (GlobalScript.inst.gameState.data[108] < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[184], func() ? "lime" : "red", func() ? "✔" : "☓", num));
			return target.CreateCondition(func);
		}

		public T IsMaoDemaoised(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.modifies[6].active || GlobalScript.inst.gameState.data[90] != 2) : (!GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[90] == 2);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[185], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsDeadJanataInIndia(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[91] != 1 || GlobalScript.inst.gameState.resultOfEvents[72] != 0) : (GlobalScript.inst.gameState.data[91] == 1 && GlobalScript.inst.gameState.resultOfEvents[72] == 0);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[187], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasNaxalitsPowerLess(bool yes, int num)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[32] > num) : (GlobalScript.inst.gameState.data[32] < num);
			target.AddReq(string.Format("{1} {0} {4:F1}: <color={2}>{3}</color>", yes ? "≺" : "≻", GlobalScript.inst.new_texts[188], func() ? "lime" : "red", func() ? "✔" : "☓", (float)num / 10f));
			return target.CreateCondition(func);
		}

		public T StartEvent(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[189]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.number_event = num;
				SceneManager.LoadScene("Event");
			};
			return reference2.CreateActive(active);
		}

		public T AddAgents(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[149], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[9] += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddArmy(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[155], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[22] += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddOilPrice(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1}$</color> ({4})", GlobalScript.inst.new_texts[690], (GlobalScript.inst.gameState.data[143] + num > 10) ? (GlobalScript.inst.gameState.data[143] + num) : 10, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "", GlobalScript.inst.new_texts[691]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				if (GlobalScript.inst.gameState.data[143] + num >= 10)
				{
					GlobalScript.inst.gameState.data[143] += num;
				}
				else
				{
					GlobalScript.inst.gameState.data[143] = 10;
				}
			};
			return reference2.CreateActive(active);
		}

		public T AddLoyalityToAllPoliticiansInTheFaction(int faction, int num)
		{
			T reference = target;
			string text = string.Format("{0} {4}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[190], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "", GlobalScript.inst.new_texts[191 + faction]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic != null && politic.traits[0] == faction)
					{
						politic.loyality += num;
					}
				}
			};
			return reference2.CreateActive(active);
		}

		public T AddRelations(int power, int num)
		{
			T reference = target;
			string text = string.Format("{0} {4}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[195], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "", GlobalScript.inst.new_texts[32 + power]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.empires[power].relations += num;
			};
			return reference2.CreateActive(active);
		}

		public T TibetMustStay(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[196]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T AddChineseInfluence(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[197], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.influencePRC += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddOilPrud(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1}</color> ({4} {5})", GlobalScript.inst.new_texts[676], num, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "", GlobalScript.inst.new_texts[677], GlobalScript.inst.gameState.OilProd + (float)num);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.OilProd += num;
				if (GlobalScript.inst.gameState.data[152] < 1000)
				{
					GlobalScript.inst.gameState.data[152] += 50;
					if (GlobalScript.inst.gameState.data[152] > 1000)
					{
						GlobalScript.inst.gameState.data[152] = 950;
					}
				}
			};
			return reference2.CreateActive(active);
		}

		public T AddOilEat(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1}</color> ({4} {5})", GlobalScript.inst.new_texts[684], num, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "", GlobalScript.inst.new_texts[685], (GlobalScript.inst.gameState.OilEat + (float)num > 200f) ? (GlobalScript.inst.gameState.OilEat + (float)num) : 200f);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				if (GlobalScript.inst.gameState.OilEat > 200f)
				{
					GlobalScript.inst.gameState.OilEat += num;
				}
				else
				{
					GlobalScript.inst.gameState.OilEat = 200f;
				}
			};
			return reference2.CreateActive(active);
		}

		public T HasOilEat(int num)
		{
			Func<bool> func = () => GlobalScript.inst.gameState.OilEat >= (float)num;
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", num, GlobalScript.inst.new_texts[686], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T AddMoney(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[198], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[8] += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddDiplo(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[668], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[6] += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddNationalism(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[199], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[31] += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddPopulation(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[200], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[34] += num;
			};
			return reference2.CreateActive(active);
		}

		public T UyghurMustStay(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[201]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T MakeProChinese(bool yes, int country)
		{
			T reference = target;
			string text = string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[202], yes ? "lime" : "red", yes ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].proprc = yes;
			};
			return reference2.CreateActive(active);
		}

		public T ChangeBotSystem(int num, int country)
		{
			T reference = target;
			string text = string.Format("{2} {0}: <color={1}>{3}</color>", GlobalScript.inst.new_texts[203], "lime", GlobalScript.inst.gameState.allcountries[country].name, GlobalScript.inst.new_texts[204 + num]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].Gosstroy = num;
			};
			return reference2.CreateActive(active);
		}

		public T MakeProUSA(bool yes, int country)
		{
			T reference = target;
			string text = string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[208], yes ? "lime" : "red", yes ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].Vyshi = yes;
			};
			return reference2.CreateActive(active);
		}

		public T MakeProSoviet(bool yes, int country)
		{
			T reference = target;
			string text = string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[209], yes ? "lime" : "red", yes ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].prosov = yes;
			};
			return reference2.CreateActive(active);
		}

		public T AnnexationInfo(int num, int annexed, int country_by)
		{
			T reference = target;
			string text = string.Format("<color=lime>{1} {0} {2}</color>", GlobalScript.inst.new_texts[210], GlobalScript.inst.gameState.allcountries[annexed].name, GlobalScript.inst.gameState.allcountries[country_by].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T AddLiberalization(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[211], (float)num / 10f, (num > 0) ? "red" : "lime", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[4] += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddPowerToAllPoliticiansInTheFaction(int faction, int num)
		{
			T reference = target;
			string text = string.Format("{0} {4}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[212], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "", GlobalScript.inst.new_texts[191 + faction]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic != null && politic.traits[0] == faction)
					{
						politic.power += num;
					}
				}
			};
			return reference2.CreateActive(active);
		}

		public T MaoismIsBetter(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[213]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T MakeInWPO(bool yes, int country)
		{
			T reference = target;
			string text = string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[214], yes ? "lime" : "red", yes ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].isOVD = yes;
			};
			return reference2.CreateActive(active);
		}

		public T MakeInSEV(bool yes, int country)
		{
			T reference = target;
			string text = string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[215], yes ? "lime" : "red", yes ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].isSEV = yes;
			};
			return reference2.CreateActive(active);
		}

		public T MakeInOKB(bool yes, int country)
		{
			T reference = target;
			string text = string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[216], yes ? "lime" : "red", yes ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].okb = yes;
			};
			return reference2.CreateActive(active);
		}

		public T MakeInEcon(bool yes, int country)
		{
			T reference = target;
			string text = string.Format("{3} {0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[217], yes ? "lime" : "red", yes ? "✔" : "☓", GlobalScript.inst.gameState.allcountries[country].name);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].econ = yes;
			};
			return reference2.CreateActive(active);
		}

		public T AddAmericanInfluence(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[218], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.empires[0].power += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddSovietInfluence(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[219], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.empires[1].power += num;
			};
			return reference2.CreateActive(active);
		}

		public T MaoismSOVIsBetter(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[220]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T LeaveTheWar(int war, int power)
		{
			T reference = target;
			string text = string.Format("<color=lime>{1} {0} \"{2}\"</color>", GlobalScript.inst.new_texts[221], GlobalScript.inst.new_texts[32 + power], GlobalScript.inst.gameState.ingamewars[war].name_war);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				if (power == 0)
				{
					GlobalScript.inst.gameState.ingamewars[war].usa_place = -1;
				}
				else if (power == 1)
				{
					GlobalScript.inst.gameState.ingamewars[war].ussr_place = -1;
				}
			};
			return reference2.CreateActive(active);
		}

		public T AddSupport(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[222], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[3] += num;
			};
			return reference2.CreateActive(active);
		}

		public T AddStandardOfLiving(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[223], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[5] += num;
			};
			return reference2.CreateActive(active);
		}

		public T KillTheLeaderOfTheFaction(int num)
		{
			T reference = target;
			string text = $"<color=red>{GlobalScript.inst.new_texts[224]} {GlobalScript.inst.new_texts[324 + num]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				if (GlobalScript.inst.gameState.faction_leader[num] < 100)
				{
					GlobalScript.inst.gameState.KillPerson(GlobalScript.inst.gameState.faction_leader[num]);
				}
			};
			return reference2.CreateActive(active);
		}

		public T AgreeToOligarchy(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[226]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T BlockMarket(int num)
		{
			T reference = target;
			string text = $"<color=red>{GlobalScript.inst.new_texts[227]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T AddNewModify(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[564]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.modifies[num].active = true;
			};
			return reference2.CreateActive(active);
		}

		public T AddOldModify(int num)
		{
			T reference = target;
			string text = $"<color=lime>{GlobalScript.inst.new_texts[564]} «{GlobalScript.inst.old_modify_texts[num]}»</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.modifies[num].active = true;
				if (num == 58)
				{
					GlobalScript.inst.gameState.data[153] = 12;
				}
			};
			return reference2.CreateActive(active);
		}

		public T BlockFreedom(int num)
		{
			T reference = target;
			string text = $"<color=red>{GlobalScript.inst.new_texts[563]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference2.CreateActive(active);
		}

		public T BlockForStatemoncap(int num)
		{
			T reference = target;
			string text = $"<color=red>{GlobalScript.inst.new_texts[567]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[16] = 12;
			};
			return reference2.CreateActive(active);
		}

		public T GetMongolia(int num)
		{
			T val;
			if (GlobalScript.inst.gameState.allcountries[9].puppetOf != 1)
			{
				T reference = target;
				string text = $"<color=red>{GlobalScript.inst.new_texts[569]}</color>";
				reference.AddResult(text);
			}
			else
			{
				T reference2 = target;
				string text2 = string.Format("<color=red>{0}</color>", "蒙 古 将 成 为 历 史 名 词");
				reference2.AddResult(text2);
			}
			T reference3 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[num] = true;
			};
			return reference3.CreateActive(active);
		}

		public T ChangeSpecialEndingForTheCountry(int country, int num)
		{
			T reference = target;
			string text = $"<color=red>{GlobalScript.inst.new_texts[268]}</color>";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].numberOfSpecialEnding = num;
			};
			return reference2.CreateActive(active);
		}

		public T MakeHimLeader(int name1, int name2, int trait0, int trait1, int trait2)
		{
			T reference = target;
			string text = string.Format("<color=lime>{1} {2} {0}</color>", GlobalScript.inst.new_texts[228], GlobalScript.inst.gameState.names1[name1], GlobalScript.inst.gameState.names2[name2]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.MakeNewLeader(GlobalScript.inst.gameState.FindPerson(name1, name2, trait0, trait1, trait2));
			};
			return reference2.CreateActive(active);
		}

		public T CreateNewLeader(byte name1, byte name2, byte trait0, byte trait1, byte trait2, byte age)
		{
			T reference = target;
			string text = string.Format("<color=lime>{1} {2} {0}</color>", GlobalScript.inst.new_texts[228], GlobalScript.inst.gameState.names1[name1], GlobalScript.inst.gameState.names2[name2]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.leader.name_1 = name1;
				GlobalScript.inst.gameState.leader.name_2 = name2;
				GlobalScript.inst.gameState.leader.traits[0] = trait0;
				GlobalScript.inst.gameState.leader.traits[1] = trait1;
				GlobalScript.inst.gameState.leader.traits[2] = trait2;
				GlobalScript.inst.gameState.leader.age = age;
			};
			return reference2.CreateActive(active);
		}

		public T AddNaxalitPower(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[332], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.data[32] += num;
			};
			return reference2.CreateActive(active);
		}

		public T IsOARCreated(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.OAR) : GlobalScript.inst.gameState.OAR;
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[579], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsOARfull(bool yes)
		{
			Func<bool> func = delegate
			{
				if (!yes)
				{
					if (GlobalScript.inst.gameState.allcountries[30].Gosstroy != 1)
					{
						return !GlobalScript.inst.gameState.allcountries[30].oar || !GlobalScript.inst.gameState.allcountries[14].oar || !GlobalScript.inst.gameState.allcountries[35].oar || !GlobalScript.inst.gameState.allcountries[40].oar || !GlobalScript.inst.gameState.allcountries[13].oar || ((!GlobalScript.inst.gameState.allcountries[18].oar || !GlobalScript.inst.gameState.allcountries[54].oar || GlobalScript.inst.gameState.allcountries[54].parts[0]) && (!GlobalScript.inst.gameState.allcountries[54].parts[0] || !GlobalScript.inst.gameState.allcountries[54].oar)) || !GlobalScript.inst.gameState.allcountries[55].oar;
					}
					return GlobalScript.inst.gameState.allcountries[30].Gosstroy != 1 || GlobalScript.inst.gameState.allcountries[14].Gosstroy != 1 || GlobalScript.inst.gameState.allcountries[35].Gosstroy != 1 || GlobalScript.inst.gameState.allcountries[13].Gosstroy != 1;
				}
				return (GlobalScript.inst.gameState.allcountries[30].Gosstroy != 1) ? (GlobalScript.inst.gameState.allcountries[30].oar && GlobalScript.inst.gameState.allcountries[14].oar && GlobalScript.inst.gameState.allcountries[35].oar && GlobalScript.inst.gameState.allcountries[40].oar && GlobalScript.inst.gameState.allcountries[13].oar && ((GlobalScript.inst.gameState.allcountries[18].oar && GlobalScript.inst.gameState.allcountries[54].oar && !GlobalScript.inst.gameState.allcountries[54].parts[0]) || (GlobalScript.inst.gameState.allcountries[54].parts[0] && GlobalScript.inst.gameState.allcountries[54].oar)) && GlobalScript.inst.gameState.allcountries[55].oar) : (GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[14].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[35].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[13].Gosstroy == 1);
			};
			T val;
			if (GlobalScript.inst.gameState.allcountries[30].Gosstroy != 1)
			{
				T reference = target;
				string text = string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[580], func() ? "lime" : "red", func() ? "✔" : "☓");
				reference.AddReq(text);
			}
			else
			{
				T reference2 = target;
				string text2 = string.Format("{0}: <color={1}>{2}</color>", " 埃 及 、 伊 拉 克 、 叙 利 亚 、 利 比 亚 均 为 社 会 主 义 政 体", func() ? "lime" : "red", func() ? "✔" : "☓");
				reference2.AddReq(text2);
			}
			return target.CreateCondition(func);
		}

		public T QuelleGosstroy(int country, int gos, bool yes)
		{
			Func<bool> func = delegate
			{
				bool result = false;
				if (!yes)
				{
					if (country == 84)
					{
						result = GlobalScript.inst.gameState.allcountries[country].Gosstroy != gos && GlobalScript.inst.gameState.allcountries[country].Gosstroy != 1;
					}
					else if (country == 10)
					{
						result = (GlobalScript.inst.gameState.allcountries[country].puppetOf == 1 || !GlobalScript.inst.gameState.allcountries[country].parts[0] || GlobalScript.inst.gameState.allcountries[country].dev != 1) && (GlobalScript.inst.gameState.allcountries[country].puppetOf == 1 || GlobalScript.inst.gameState.allcountries[46].Gosstroy != 1);
					}
					else if (country == 30)
					{
						result = GlobalScript.inst.gameState.allcountries[30].Gosstroy != 2;
					}
					else if (country == 33)
					{
						result = GlobalScript.inst.gameState.allcountries[34].SubGosstroy != 17 || GlobalScript.inst.gameState.allcountries[33].SubGosstroy != 17 || GlobalScript.inst.gameState.allcountries[19].SubGosstroy != 17;
					}
					else if (country == 80)
					{
						result = GlobalScript.inst.gameState.allcountries[80].SubGosstroy != 17;
					}
					else if (country == 58)
					{
						result = GlobalScript.inst.gameState.allcountries[52].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[53].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[54].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[55].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[56].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[57].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[58].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[59].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[60].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[61].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[62].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[63].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[64].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[65].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[66].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[67].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[68].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[99].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[100].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[106].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[107].SubGosstroy != 17 && GlobalScript.inst.gameState.allcountries[108].SubGosstroy != 17;
					}
				}
				else if (country == 84)
				{
					result = GlobalScript.inst.gameState.allcountries[country].Gosstroy == gos || GlobalScript.inst.gameState.allcountries[country].Gosstroy == 1;
				}
				else if (country == 10)
				{
					result = (GlobalScript.inst.gameState.allcountries[country].puppetOf != 1 && GlobalScript.inst.gameState.allcountries[country].parts[0] && GlobalScript.inst.gameState.allcountries[country].dev == 1) || (GlobalScript.inst.gameState.allcountries[country].puppetOf != 1 && GlobalScript.inst.gameState.allcountries[46].Gosstroy == 1);
				}
				else if (country == 30)
				{
					result = GlobalScript.inst.gameState.allcountries[30].Gosstroy == 2;
				}
				else if (country == 33)
				{
					result = GlobalScript.inst.gameState.allcountries[34].SubGosstroy == 17 && GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 17 && GlobalScript.inst.gameState.allcountries[19].SubGosstroy == 17;
				}
				else if (country == 80)
				{
					result = GlobalScript.inst.gameState.allcountries[80].SubGosstroy == 17;
				}
				else if (country == 58)
				{
					result = GlobalScript.inst.gameState.allcountries[52].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[53].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[54].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[55].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[56].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[57].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[58].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[59].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[60].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[61].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[62].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[63].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[64].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[65].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[66].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[67].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[68].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[99].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[100].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[106].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[107].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[108].SubGosstroy == 17;
				}
				return result;
			};
			T val;
			if (country == 84)
			{
				T reference = target;
				string text = string.Format("{0} {1} - {2}: <color={3}>{4}</color>", " 土 耳 其", " 的 政 体 为", " 社 会 主 义 或 改 良 主 义", func() ? "lime" : "red", func() ? "✔" : "☓");
				reference.AddReq(text);
			}
			else if (country == 10)
			{
				T reference2 = target;
				string text2 = string.Format("{0} {1} {2}: <color={3}>{4}</color>", " 朝 鲜 不 为 中 国 的 傀 儡 且 已 通 过 第 二 次 朝 鲜 战 争 统 一 ", " ，", " 或 朝 鲜 不 为 中 国 的 傀 儡 且 左 翼 分 子 在 韩 国 掌 权", func() ? "lime" : "red", func() ? "✔" : "☓");
				reference2.AddReq(text2);
			}
			else if (country == 30)
			{
				T reference3 = target;
				string text3 = string.Format("{0} {1} {2}: <color={3}>{4}</color>", " 埃 及", " 的 政 体 为", " 改 良 主 义", func() ? "lime" : "red", func() ? "✔" : "☓");
				reference3.AddReq(text3);
			}
			else if (country == 33)
			{
				T reference4 = target;
				string text4 = string.Format("{0} {1} {2}: <color={3}>{4}</color>", " 毛 主 义 者 在", " 泰 国 、 缅 甸 、 印 度", " 均 建 立 了 稳 定 政 权", func() ? "lime" : "red", func() ? "✔" : "☓");
				reference4.AddReq(text4);
			}
			else if (country == 80)
			{
				T reference5 = target;
				string text5 = string.Format("{0} {1} {2}: <color={3}>{4}</color>", " 秘 鲁", " 为", " 毛 主 义", func() ? "lime" : "red", func() ? "✔" : "☓");
				reference5.AddReq(text5);
			}
			else if (country == 58)
			{
				T reference6 = target;
				string text6 = string.Format("{0} {1} {2}: <color={3}>{4}</color>", " 非 洲", " 至 少 有 一 个", " 毛 主 义 国 家", func() ? "lime" : "red", func() ? "✔" : "☓");
				reference6.AddReq(text6);
			}
			return target.CreateCondition(func);
		}

		public T IsRael(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.allcountries[37].Vyshi || !GlobalScript.inst.gameState.allcountries[37].proprc) : (!GlobalScript.inst.gameState.allcountries[37].Vyshi && GlobalScript.inst.gameState.allcountries[37].proprc);
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[588], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsNoWars(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.ingamewars[3].is_going || GlobalScript.inst.gameState.ingamewars[4].is_going || GlobalScript.inst.gameState.ingamewars[8].is_going || GlobalScript.inst.gameState.ingamewars[9].is_going || GlobalScript.inst.gameState.ingamewars[10].is_going || GlobalScript.inst.gameState.ingamewars[11].is_going || GlobalScript.inst.gameState.ingamewars[12].is_going || GlobalScript.inst.gameState.ingamewars[40].is_going || GlobalScript.inst.gameState.ingamewars[41].is_going || GlobalScript.inst.gameState.ingamewars[42].is_going) : (!GlobalScript.inst.gameState.ingamewars[3].is_going && !GlobalScript.inst.gameState.ingamewars[4].is_going && !GlobalScript.inst.gameState.ingamewars[8].is_going && !GlobalScript.inst.gameState.ingamewars[9].is_going && !GlobalScript.inst.gameState.ingamewars[10].is_going && !GlobalScript.inst.gameState.ingamewars[11].is_going && !GlobalScript.inst.gameState.ingamewars[12].is_going && !GlobalScript.inst.gameState.ingamewars[40].is_going && !GlobalScript.inst.gameState.ingamewars[41].is_going && !GlobalScript.inst.gameState.ingamewars[42].is_going);
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[586], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T CreateBigOAR(bool yes)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[587]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				for (int i = 0; i < 41; i++)
				{
					if (i == 14 || i == 13 || i == 30 || i == 35 || i == 40)
					{
						GlobalScript.inst.gameState.allcountries[i].prosov = false;
						GlobalScript.inst.gameState.allcountries[i].Vyshi = false;
						GlobalScript.inst.gameState.allcountries[i].proprc = false;
						GlobalScript.inst.gameState.allcountries[i].isSEV = false;
						GlobalScript.inst.gameState.allcountries[i].isOVD = false;
						GlobalScript.inst.gameState.allcountries[i].okb = false;
						GlobalScript.inst.gameState.allcountries[i].econ = false;
						GlobalScript.inst.gameState.allcountries[i].Torg = false;
						GlobalScript.inst.gameState.allcountries[i].oar = false;
					}
				}
				if (GlobalScript.inst.gameState.allcountries[14].parts[4])
				{
					GlobalScript.inst.gameState.allcountries[14].parts[4] = false;
					GlobalScript.inst.gameState.allcountries[30].parts[1] = true;
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[30].parts[0] = true;
				}
				GlobalScript.inst.gameState.allcountries[30].Torg = true;
				GlobalScript.inst.gameState.allcountries[30].proprc = true;
				GlobalScript.inst.gameState.allcountries[30].name = GlobalScript.inst.other_text[6];
				GlobalScript.inst.gameState.allcountries[30].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 3;
				GlobalScript.inst.gameState.modifies[46].active = true;
				if (GlobalScript.inst.gameState.allcountries[1].okb)
				{
					GlobalScript.inst.gameState.allcountries[30].okb = true;
					GlobalScript.inst.gameState.allcountries[30].econ = true;
				}
				else if (GlobalScript.inst.gameState.allcountries[1].isOVD)
				{
					GlobalScript.inst.gameState.allcountries[30].isOVD = true;
					GlobalScript.inst.gameState.allcountries[30].isSEV = true;
				}
				else if (GlobalScript.inst.gameState.allcountries[1].isSEV)
				{
					GlobalScript.inst.gameState.allcountries[30].isSEV = true;
				}
				else if (GlobalScript.inst.gameState.allcountries[1].econ)
				{
					GlobalScript.inst.gameState.allcountries[30].econ = true;
				}
			};
			return reference2.CreateActive(active);
		}

		public T IsChinaWarAliance(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[1].okb) : GlobalScript.inst.gameState.allcountries[1].okb;
			target.AddReq(string.Format("{0}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[591], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T OnAgentModif(bool yes)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[592]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.modifies[47].active = true;
			};
			return reference2.CreateActive(active);
		}

		public T OnArmyModif(bool yes)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[631]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.modifies[48].active = true;
			};
			return reference2.CreateActive(active);
		}

		public T OnSEATO(bool yes)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[637]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[51].cw = true;
				for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
				{
					if (GlobalScript.inst.gameState.allcountries[i].isSENTO)
					{
						GlobalScript.inst.gameState.allcountries[i].LeaveSENTO().JoinASEAN();
					}
				}
			};
			return reference2.CreateActive(active);
		}

		public T ISCIA(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.allcountries[51].dev <= 0) : (GlobalScript.inst.gameState.allcountries[51].dev > 0);
			target.AddReq(string.Format("{1} - {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], GlobalScript.inst.new_texts[687], func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsScienceDone(int cock, bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.science[cock]) : GlobalScript.inst.gameState.science[cock];
			target.AddReq(string.Format("{0} «{3}» {4}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[627], func() ? "lime" : "red", func() ? "✔" : "☓", GlobalScript.inst.new_texts[593 + cock], GlobalScript.inst.new_texts[628]));
			return target.CreateCondition(func);
		}

		public T IsIndustry(int how, bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[12] < how) : (GlobalScript.inst.gameState.data[12] >= how);
			target.AddReq(string.Format("{0} {3}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[675], func() ? "lime" : "red", func() ? "✔" : "☓", (float)how / 10f));
			return target.CreateCondition(func);
		}

		public T IsRealtions(int how, int empire, bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.empires[empire].relations < how) : (GlobalScript.inst.gameState.empires[empire].relations >= how);
			target.AddReq(string.Format("{0} {3}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[680 + empire], func() ? "lime" : "red", func() ? "✔" : "☓", (float)how / 10f));
			return target.CreateCondition(func);
		}

		public T Oncein(int cock, int month, bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.desnull[cock] > 0) : (GlobalScript.inst.gameState.desnull[cock] <= 0);
			target.AddReq(string.Format("{0} {3} {4}: <color={1}>{2}</color>", GlobalScript.inst.new_texts[643], func() ? "lime" : "red", func() ? "✔" : "☓", month, GlobalScript.inst.new_texts[644]));
			return target.CreateCondition(func);
		}

		public T DoTimer(int cock, int month)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[664]} {month} {GlobalScript.inst.new_texts[665]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.desnull[cock] = month;
			};
			return reference2.CreateActive(active);
		}

		public T AddinflAlliance(int num, int cum)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[649 + cum], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				if (cum == 1)
				{
					for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
					{
						if (GlobalScript.inst.gameState.allcountries[i].isOVD && (i == 8 || i == 11 || i == 14 || i == 12 || i == 31 || i == 32 || i == 22 || i == 33 || i == 37 || i == 43 || i == 42 || i == 23 || i == 35 || i == 96 || i == 97 || i == 98 || i == 95 || i == 49 || i == 50))
						{
							GlobalScript.inst.gameState.allcountries[i].sovinfl += num;
						}
					}
				}
				else if (cum == 2)
				{
					for (int j = 0; j < GlobalScript.inst.gameState.allcountries.Length; j++)
					{
						if (GlobalScript.inst.gameState.allcountries[j].isSEATO)
						{
							GlobalScript.inst.gameState.allcountries[j].usainfl += num;
						}
					}
				}
				else
				{
					for (int k = 2; k < GlobalScript.inst.gameState.allcountries.Length; k++)
					{
						if (GlobalScript.inst.gameState.allcountries[k].isOVD && GlobalScript.inst.gameState.allcountries[1].isOVD)
						{
							if (k == 8 || k == 11 || k == 14 || k == 12 || k == 31 || k == 32 || k == 37 || k == 22 || k == 37 || k == 23 || k == 43 || k == 42 || k == 35 || k == 96 || k == 97 || k == 98 || k == 95 || k == 49 || k == 50)
							{
								GlobalScript.inst.gameState.allcountries[k].prcinfl += num;
							}
						}
						else if (GlobalScript.inst.gameState.allcountries[k].isSEATO)
						{
							GlobalScript.inst.gameState.allcountries[k].prcinfl += num;
						}
					}
				}
			};
			return reference2.CreateActive(active);
		}

		public T AddAllAfrique(int num, int cum)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[658 + cum], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				if (cum == 1)
				{
					for (int i = 53; i < 109; i++)
					{
						if ((i < 69 || i > 105) && !GlobalScript.inst.gameState.allcountries[i].africaOff)
						{
							GlobalScript.inst.gameState.allcountries[i].sovpower += num;
						}
					}
				}
				else if (cum == 2)
				{
					for (int j = 53; j < 109; j++)
					{
						if ((j < 69 || j > 105) && !GlobalScript.inst.gameState.allcountries[j].africaOff)
						{
							GlobalScript.inst.gameState.allcountries[j].usapower += num;
						}
					}
				}
				else if (cum == 3)
				{
					for (int k = 53; k < 109; k++)
					{
						if ((k < 69 || k > 105) && !GlobalScript.inst.gameState.allcountries[k].africaOff)
						{
							GlobalScript.inst.gameState.allcountries[k].prcpower += num;
						}
					}
				}
			};
			return reference2.CreateActive(active);
		}

		public T AddStabilityAfrique(int num)
		{
			T reference = target;
			string text = string.Format("{0}: <color={2}>{3}{1:F1}</color>", GlobalScript.inst.new_texts[666], (float)num / 10f, (num > 0) ? "lime" : "red", (num > 0) ? "+" : "");
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				for (int i = 53; i < 109; i++)
				{
					if ((i < 69 || i > 105) && !GlobalScript.inst.gameState.allcountries[i].africaOff)
					{
						GlobalScript.inst.gameState.allcountries[i].stab += num;
					}
				}
			};
			return reference2.CreateActive(active);
		}

		public extern void Turkeyispositive();

		public T EastEuropeAbandonSOV(bool yes)
		{
			T reference = target;
			string text = string.Format("{0} <color={1}>{2}</color>", new object[3] { "匈牙利、波兰、罗马尼亚将退出华约和经互会", "", "" });
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[2].isOVD = false;
				GlobalScript.inst.gameState.allcountries[4].isOVD = false;
				GlobalScript.inst.gameState.allcountries[5].isOVD = false;
				GlobalScript.inst.gameState.allcountries[2].isSEV = false;
				GlobalScript.inst.gameState.allcountries[4].isSEV = false;
				GlobalScript.inst.gameState.allcountries[5].isSEV = false;
			};
			return reference2.CreateActive(active);
		}

		public T MakeEastEuropaProChina(bool yes)
		{
			T reference = target;
			string text = string.Format("{0} <color={1}>{2}</color>", new object[3] { "匈牙利、波兰、罗马尼亚将加入集安条约和经合组织", "", "" });
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[2].okb = true;
				GlobalScript.inst.gameState.allcountries[4].okb = true;
				GlobalScript.inst.gameState.allcountries[5].okb = true;
				GlobalScript.inst.gameState.allcountries[2].econ = true;
				GlobalScript.inst.gameState.allcountries[4].econ = true;
				GlobalScript.inst.gameState.allcountries[5].econ = true;
			};
			return reference2.CreateActive(active);
		}

		public T IsLeftradicalLead(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.IsFactionLeadeng(0)) : GlobalScript.inst.gameState.IsFactionLeadeng(0);
			target.AddReq(string.Format("{1} {0}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 党 内 是 极 左 派 领 导", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsAfricanProprc(bool yes)
		{
			Func<bool> func = () => (!yes) ? (!GlobalScript.inst.gameState.allcountries[63].proprc || !GlobalScript.inst.gameState.IsSocialism(yes: true, 63) || !GlobalScript.inst.gameState.allcountries[61].proprc || !GlobalScript.inst.gameState.IsSocialism(yes: true, 61) || !GlobalScript.inst.gameState.allcountries[114].proprc || !GlobalScript.inst.gameState.IsSocialism(yes: true, 114) || !GlobalScript.inst.gameState.allcountries[61].proprc || !GlobalScript.inst.gameState.IsSocialism(yes: true, 61) || !GlobalScript.inst.gameState.allcountries[122].proprc || !GlobalScript.inst.gameState.IsSocialism(yes: true, 122) || !GlobalScript.inst.gameState.allcountries[127].proprc || !GlobalScript.inst.gameState.IsSocialism(yes: true, 127)) : (GlobalScript.inst.gameState.allcountries[63].proprc && GlobalScript.inst.gameState.IsSocialism(yes: true, 63) && GlobalScript.inst.gameState.allcountries[61].proprc && GlobalScript.inst.gameState.IsSocialism(yes: true, 61) && GlobalScript.inst.gameState.allcountries[114].proprc && GlobalScript.inst.gameState.IsSocialism(yes: true, 114) && GlobalScript.inst.gameState.allcountries[61].proprc && GlobalScript.inst.gameState.IsSocialism(yes: true, 61) && GlobalScript.inst.gameState.allcountries[122].proprc && GlobalScript.inst.gameState.IsSocialism(yes: true, 122) && GlobalScript.inst.gameState.allcountries[127].proprc && GlobalScript.inst.gameState.IsSocialism(yes: true, 127));
			target.AddReq(string.Format("{1}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 加 纳 ， 布 基 纳 法 索 ， 几 内 亚 比 绍 ， 坦 桑 尼 亚 ， 津 巴 布 韦 均 亲 中 且 为 社 会 主 义", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T IsAfricanSocialism(bool yes)
		{
			Func<bool> func = delegate
			{
				int num = 0;
				for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
				{
					if (((i > 51 && i < 69) || (i > 105 && i < 109) || (i > 111 && i < 133) || i == 41 || i == 42 || i == 99 || i == 100) && i != 128)
					{
						num++;
					}
				}
				return (!yes) ? (num < 6) : (num >= 6);
			};
			target.AddReq(string.Format("{1}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 非 洲 有 至 少 6 个 社 会 主 义 政 权", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T AfricanAlliance(bool yes)
		{
			T reference = target;
			string text = string.Format("{0} <color={1}>{2}</color>", new object[3] { "非洲联盟将成立", "", "" });
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.completedDecisions[36] = true;
			};
			return reference2.CreateActive(active);
		}

		public T NoZhuTiWar(bool yes)
		{
			Func<bool> func = delegate
			{
				int num = 0;
				for (int i = 0; i < GlobalScript.inst.gameState.ingamewars.Length; i++)
				{
					if (i >= 70 && i < 76 && GlobalScript.inst.gameState.ingamewars[i].is_going)
					{
						num++;
					}
				}
				return (!yes) ? (num != 0) : (num == 0);
			};
			target.AddReq(string.Format("{1}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 没 有 民 族 复 兴 战 争 正 在 进 行", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HaveBeenZhuTi(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 19) : (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19);
			target.AddReq(string.Format("{1}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 我 们 已 经 应 用 了 先 进 的 社 会 主 义 理 论", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HaveFullChina(bool yes)
		{
			Func<bool> func = () => (!yes) ? (GlobalScript.inst.gameState.data[62] < 2 || (GlobalScript.inst.gameState.data[64] != 2 && !GlobalScript.inst.gameState.completedDecisions[7])) : (GlobalScript.inst.gameState.data[62] >= 2 && (GlobalScript.inst.gameState.data[64] == 2 || GlobalScript.inst.gameState.completedDecisions[7]));
			target.AddReq(string.Format("{1}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 我 们 已 经 收 复 了 所 有 建 国 时 宣 称 的 领 地", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}

		public T HasntJueQi(bool yes)
		{
			Func<bool> func = () => (!yes) ? GlobalScript.inst.gameState.IndOpp : (!GlobalScript.inst.gameState.IndOpp);
			target.AddReq(string.Format("{1}: <color={2}>{3}</color>", yes ? GlobalScript.inst.new_texts[111] : GlobalScript.inst.new_texts[112], " 我 们 尚 未 彻 底 实 现 伟 大 复 兴", func() ? "lime" : "red", func() ? "✔" : "☓"));
			return target.CreateCondition(func);
		}
	}
}
