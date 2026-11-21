using System;
using KGWar;
using MoonSharp.Interpreter;

namespace KGEvent
{
	[Serializable]
	[MoonSharpUserData]
	public class QueryWorld<T> where T : IRequesting<T>
	{
		private T target;

		public QueryWorld(T target)
		{
			this.target = target;
		}

		public T WarIsGoing(War war)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[95]} {war.CreateWar.name_war}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => war.IsGoing();
			return reference2.CreateCondition(condition);
		}

		public T EconIsExist()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.allcountries[1].econ);
		}

		public T OkbIsExist()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.allcountries[1].okb);
		}

		public T EconIsNotExist()
		{
			return target.CreateCondition(() => !GlobalScript.inst.gameState.allcountries[1].econ);
		}

		public T OkbIsNotExist()
		{
			return target.CreateCondition(() => !GlobalScript.inst.gameState.allcountries[1].okb);
		}

		public T BeforeDay(int day)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[90]} {day} {GlobalScript.inst.new_texts[91]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.data[19] > day;
			return reference2.CreateCondition(condition);
		}

		public T AfterDay(int day)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[90]} {day} {GlobalScript.inst.new_texts[91]}";
			reference.AddReq(text);
			T reference2 = target;
			Func<bool> condition = () => GlobalScript.inst.gameState.data[19] < day;
			return reference2.CreateCondition(condition);
		}

		public T IsMonth(int month)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[20] == month);
		}

		public T BeforeMonth(int month)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[20] > month);
		}

		public T AfterMonth(int month)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[20] < month);
		}

		public T IsYear(int year)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[21] == year);
		}

		public T BeforeYear(int year)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[21] > year);
		}

		public T AfterYear(int year)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[21] < year);
		}

		public T BeforeDate(int day, int month, int year)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[21] < year || (GlobalScript.inst.gameState.data[21] == year && (GlobalScript.inst.gameState.data[20] < month || (GlobalScript.inst.gameState.data[20] == month && GlobalScript.inst.gameState.data[19] < day))));
		}

		public T AfterDate(int day, int month, int year)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[21] > year || (GlobalScript.inst.gameState.data[21] == year && (GlobalScript.inst.gameState.data[20] > month || (GlobalScript.inst.gameState.data[20] == month && GlobalScript.inst.gameState.data[19] > day))));
		}

		public T DecleredWar(War war)
		{
			T reference = target;
			string text = $"{GlobalScript.inst.new_texts[89]} {war.CreateWar.name_war}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				war.DecleredWar();
			};
			return reference2.CreateActive(active);
		}

		public T AddToPartiesConnection(int num)
		{
			T reference = target;
			string text = string.Format("{0}{1} {2}", (num >= 0) ? "+" : "", num, GlobalScript.inst.new_texts[42]);
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += num;
			};
			return reference2.CreateActive(active);
		}

		public T WarEnds(War war)
		{
			T reference = target;
			string text = $"{war.CreateWar.name_war} {GlobalScript.inst.new_texts[96]}";
			reference.AddResult(text);
			T reference2 = target;
			Action active = delegate
			{
				war.CreateWar.is_going = false;
			};
			return reference2.CreateActive(active);
		}

		public T CreateEcon()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.allcountries[1].econ = true;
			});
		}

		public T CreateOkb()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.allcountries[1].okb = true;
			});
		}

		public T AddEvent(Event e)
		{
			return target.CreateActive(delegate
			{
				EventManager.AddEvent(e);
			});
		}
	}
}
