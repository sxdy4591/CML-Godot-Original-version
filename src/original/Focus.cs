using System;
using KGEvent;
using LFKG;
using MoonSharp.Interpreter;
using UnityEngine;

[Serializable]
[MoonSharpUserData]
public class Focus : RequestingMinor<Focus>, IRequesting<Focus>
{
	public FocusDesc desc;

	public int time;

	public int overtime;

	public bool blocked;

	public QueryMajor<Focus> USSR;

	public QueryMajor<Focus> USA;

	public QueryMajor<Focus> China;

	public bool condition_and;

	public Func<bool> expression;

	public Func<bool> condition;

	public Func<bool> LeaderCondition = () => true;

	public string req;

	public string result;

	// [移植修复] 树里大量焦点只有条件没有动作链(未走 CreateActive), 原 active 为 null;
	// AI 焦点完成时 TimeScript.FocusesResearching 调 active() 抛 NRE, now_focus 复位不了,
	// Repaint 每 tick 重复炸. 空委托 = 无动作焦点完成后无副作用, 即原版语义.
	public Action active = delegate {};

	private bool condtition_type;

	public Focus End
	{
		get
		{
			condtition_type = false;
			AddExpr();
			condition_and = false;
			return this;
		}
	}

	public Focus Expr
	{
		get
		{
			condtition_type = true;
			return this;
		}
		set
		{
		}
	}

	private void CreateQueryMajors()
	{
		USSR = new QueryMajor<Focus>(this, 1);
		USA = new QueryMajor<Focus>(this, 0);
		China = new QueryMajor<Focus>(this, 2);
	}

	public Focus(string name, int tim = 75)
	{
		desc = FocusReader.focuses[name];
		time = tim;
		RequestingIniter.CreateQueryMinors(this);
		CreateQueryMajors();
	}

	public Focus(int tim = 75)
	{
		time = tim;
		RequestingIniter.CreateQueryMinors(this);
		CreateQueryMajors();
		LeaderCondition = () => true;
	}

	public Focus Name(string name)
	{
		desc = FocusReader.focuses[name];
		return this;
	}

	public Focus Time(int tim)
	{
		time = tim;
		return this;
	}

	public Focus AddReq(string text)
	{
		Debug.Log($"{condition_and} {(condition_and ? GlobalScript.inst.new_texts[18] : GlobalScript.inst.new_texts[19])}");
		req = $"{req} {((req == null) ? GlobalScript.inst.new_texts[36] : (condition_and ? GlobalScript.inst.new_texts[18] : GlobalScript.inst.new_texts[19]))} {text}";
		return this;
	}

	public Focus AddResult(string text)
	{
		result = string.Format("{0} {1} {2}", result, (result == null) ? GlobalScript.inst.new_texts[37] : "|", text);
		return this;
	}

	private void AddExpr()
	{
		Func<bool> prev = condition;
		Func<bool> expr = expression;
		// [移植修复] 1.132 数据里部分焦点没有前置条件(condition/expression 为 null),
		// 原版直接调用会 NRE 并把 TimeScript.Update 从 Repaint 起打断.
		condition = () => (expr == null || expr()) || (prev == null || prev());
		expression = () => true;
	}

	public Focus CreateCondition(Func<bool> condition)
	{
		if (!condtition_type)
		{
			Func<bool> prev2 = this.condition;
			if (this.condition != null)
			{
				this.condition = () => condition() || prev2();
			}
			else
			{
				this.condition = () => condition();
			}
		}
		else
		{
			Func<bool> prev = expression;
			// [移植修复] 同上: AND 条件的前置表达式可能为 null
			expression = () => condition() && (prev == null || prev());
			condition_and = true;
		}
		return this;
	}

	public Focus CreateActive(Action active)
	{
		this.active = (Action)Delegate.Combine(this.active, active);
		return this;
	}
}
