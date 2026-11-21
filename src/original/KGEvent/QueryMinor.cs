using System;
using MoonSharp.Interpreter;

namespace KGEvent
{
	[Serializable]
	[MoonSharpUserData]
	public class QueryMinor<T> where T : IRequesting<T>
	{
		private int country;

		private T target;

		public QueryMinor(T target, int country)
		{
			this.country = country;
			this.target = target;
		}

		public T MemberOfOKB()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[48]} {GlobalScript.inst.new_texts[49]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].okb;
			return reference2.CreateCondition(condition);
		}

		public T MemberOfECON()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[48]} {GlobalScript.inst.new_texts[50]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].econ;
			return reference2.CreateCondition(condition);
		}

		public T MemberOfComecon()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[48]} {GlobalScript.inst.new_texts[51]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].isSEV;
			return reference2.CreateCondition(condition);
		}

		public T MemberOfWP()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[48]} {GlobalScript.inst.new_texts[52]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].isOVD;
			return reference2.CreateCondition(condition);
		}

		public T IsAuthoritarianism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[53]} {GlobalScript.inst.new_texts[54]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].Gosstroy == 0;
			return reference2.CreateCondition(condition);
		}

		public T IsSocialism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[53]} {GlobalScript.inst.new_texts[55]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].Gosstroy == 1;
			return reference2.CreateCondition(condition);
		}

		public T IsReformism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[53]} {GlobalScript.inst.new_texts[56]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].Gosstroy == 2;
			return reference2.CreateCondition(condition);
		}

		public T IsLiberalism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[53]} {GlobalScript.inst.new_texts[57]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].Gosstroy == 3;
			return reference2.CreateCondition(condition);
		}

		public T IsProAmerican()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[58]} {GlobalScript.inst.new_texts[59]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].Vyshi;
			return reference2.CreateCondition(condition);
		}

		public T IsProChinese()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[58]} {GlobalScript.inst.new_texts[60]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].proprc;
			return reference2.CreateCondition(condition);
		}

		public T IsProSoviet()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[58]} {GlobalScript.inst.new_texts[61]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].prosov;
			return reference2.CreateCondition(condition);
		}

		public T IsCivilWar()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[62]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].cw;
			return reference2.CreateCondition(condition);
		}

		public T StabilityMore(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[63]} {GlobalScript.inst.new_texts[40]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].stab > value;
			return reference2.CreateCondition(condition);
		}

		public T StabilityLess(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[63]} {GlobalScript.inst.new_texts[41]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].stab < value;
			return reference2.CreateCondition(condition);
		}

		public T EconomicMore(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[64]} {GlobalScript.inst.new_texts[40]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].dev > value;
			return reference2.CreateCondition(condition);
		}

		public T EconomicLess(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[64]} {GlobalScript.inst.new_texts[41]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].dev < value;
			return reference2.CreateCondition(condition);
		}

		public T AmericanPowerMore(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[65]} {GlobalScript.inst.new_texts[68]} {GlobalScript.inst.new_texts[40]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].usapower < value;
			return reference2.CreateCondition(condition);
		}

		public T AmericanPowerLess(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[65]} {GlobalScript.inst.new_texts[68]} {GlobalScript.inst.new_texts[41]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].usapower < value;
			return reference2.CreateCondition(condition);
		}

		public T SovietPowerMore(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[66]} {GlobalScript.inst.new_texts[68]} {GlobalScript.inst.new_texts[40]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].sovpower > value;
			return reference2.CreateCondition(condition);
		}

		public T SovietPowerLess(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[66]} {GlobalScript.inst.new_texts[68]} {GlobalScript.inst.new_texts[41]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].sovpower < value;
			return reference2.CreateCondition(condition);
		}

		public T ChinesePowerMore(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[67]} {GlobalScript.inst.new_texts[68]} {GlobalScript.inst.new_texts[40]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].prcpower > value;
			return reference2.CreateCondition(condition);
		}

		public T ChinesePowerLess(int value)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[67]} {GlobalScript.inst.new_texts[68]} {GlobalScript.inst.new_texts[41]} {value}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.allcountries[country].prcpower < value;
			return reference2.CreateCondition(condition);
		}

		public T EstablishProAmerican()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[69]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].EstablishGovernment(Government.ProAmerican);
			};
			return reference2.CreateActive(active);
		}

		public T EstablishProSoviet()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[70]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].EstablishGovernment(Government.ProSoviet);
			};
			return reference2.CreateActive(active);
		}

		public T EstablishProChina()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[71]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].EstablishGovernment(Government.ProChina);
			};
			return reference2.CreateActive(active);
		}

		public T JoinOKB()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[72]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].JoinOKB();
			};
			return reference2.CreateActive(active);
		}

		public T JoinECON()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[73]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].JoinECON();
			};
			return reference2.CreateActive(active);
		}

		public T JoinComecon()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[74]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].JoinComecon();
			};
			return reference2.CreateActive(active);
		}

		public T JoinWP()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[75]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].JoinWP();
			};
			return reference2.CreateActive(active);
		}

		public T LeaveOKB()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[76]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].LeaveOKB();
			};
			return reference2.CreateActive(active);
		}

		public T LeaveECON()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[77]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].LeaveECON();
			};
			return reference2.CreateActive(active);
		}

		public T LeaveComecon()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[78]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].LeaveComecon();
			};
			return reference2.CreateActive(active);
		}

		public T LeaveWP()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[79]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].LeaveWP();
			};
			return reference2.CreateActive(active);
		}

		public T EstablishAuthoritarianism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[80]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].SetSystem(0);
			};
			return reference2.CreateActive(active);
		}

		public T EstablishSocialism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[81]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].SetSystem(1);
			};
			return reference2.CreateActive(active);
		}

		public T EstablishReformism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[82]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].SetSystem(2);
			};
			return reference2.CreateActive(active);
		}

		public T EstablishLiberalism()
		{
			T reference = target;
			string text = $"{GlobalScript.inst.gameState.allcountries[country].name} {GlobalScript.inst.new_texts[83]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].SetSystem(3);
			};
			return reference2.CreateActive(active);
		}

		public T AddStability(int value)
		{
			T reference = target;
			string text = string.Format("{0} {1} {2} {3}", GlobalScript.inst.gameState.allcountries[country].name, (value >= 0) ? "+" : "", value, GlobalScript.inst.new_texts[84]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].AddStability(value);
			};
			return reference2.CreateActive(active);
		}

		public T AddEconomicPotential(int value)
		{
			T reference = target;
			string text = string.Format("{0} {1} {2} {3}", GlobalScript.inst.gameState.allcountries[country].name, (value >= 0) ? "+" : "", value, GlobalScript.inst.new_texts[85]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].AddEconomicPotential(value);
			};
			return reference2.CreateActive(active);
		}

		public T AddAmericanInfluence(int value)
		{
			T reference = target;
			string text = string.Format("{0} {1} {2} {3}", GlobalScript.inst.gameState.allcountries[country].name, (value >= 0) ? "+" : "", value, GlobalScript.inst.new_texts[86]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].AddAmericanInfluence(value);
			};
			return reference2.CreateActive(active);
		}

		public T AddSovietInfluence(int value)
		{
			T reference = target;
			string text = string.Format("{0} {1} {2} {3}", GlobalScript.inst.gameState.allcountries[country].name, (value >= 0) ? "+" : "", value, GlobalScript.inst.new_texts[87]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].AddSovietInfluence(value);
			};
			return reference2.CreateActive(active);
		}

		public T AddChineseInfluence(int value)
		{
			T reference = target;
			string text = string.Format("{0} {1} {2} {3}", GlobalScript.inst.gameState.allcountries[country].name, (value >= 0) ? "+" : "", value, GlobalScript.inst.new_texts[88]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.allcountries[country].AddChineseInfluence(value);
			};
			return reference2.CreateActive(active);
		}
	}
}
