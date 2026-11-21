using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event663 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 远 东 斯 巴 达 的 终 结";
		text = $"自1948 年 以 来 ， 缅 甸 国 内 便 大 小 冲 突 不 断 ： 从 共 产 党 到 民 族 分 离 武 装 你 方 唱 罢 我 登 场 ， 共 同 撕 裂 着 这 个 新 生 的 政 权 。 然 而 ， 由 于 缅 甸 政 府 的 强 力 镇 压 ， 该 国 多 少 能 维 持 一 种 “ 散 而 不 倒 ” 的 状 态 。 可 如 今 ， 时 代 变 了 ： 反 政 府 武 装 甚 至 打 入 了 缅 甸 古 都 曼 德 勒 ， 并 逼 迫 该 国 政 府 不 得 不 援 引 全 国 紧 急 状 态 。 以 “ 国 家 统 一 ” 为 招 牌 的 缅 甸 政 府 陷 入 了 全 面 危 机 ， 缅 甸 内 战 也 将 迎 来 其 最 高 峰 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 火 药 桶 的 最 终 结 局 都 是 如 此 … …";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 远 东 斯 巴 达 的 终 结";
		if (result_num == 0)
		{
			if (a.resultOfEvents[662] == 2)
			{
				a.ingamewars[82] = new War().Name("缅 甸 内 战").Attacker("塔 马 刀").Defender("克 伦 民 族 联 盟")
					.AttackerInfluence(600)
					.DefenderInfluence(400)
					.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			}
			else if (a.resultOfEvents[662] == 4)
			{
				a.ingamewars[82] = new War().Name("缅 甸 内 战").Attacker("塔 马 刀").Defender("缅 共")
					.AttackerInfluence(700)
					.DefenderInfluence(300)
					.CreateWar;
			}
			else
			{
				a.ingamewars[82] = new War().Name("缅 甸 内 战").Attacker("塔 马 刀").Defender("缅 共")
					.AttackerInfluence(600)
					.DefenderInfluence(400)
					.AmericanSupportAttacker.SovietSupportAttacker.CreateWar;
			}
			text = " 亚 洲 的 巴 尔 干 前 途 未 明 … …";
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
