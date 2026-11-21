using EventsForDLC;
using UnityEngine;

public class Event45 : EventsSecond
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
		name = " 改 革 开 放 ： 先 声";
		text = " 在 宣 告 了 市 场 改 革 进 程 之 后 ， 我 们 的 经 济 学 家 制 定 了 第 一 次 改 革 的 计 划 ， 并 最 终 提 交 给 中 国 共 产 党 领 导 层 批 准 。 它 包 括 扩 大 企 业 经 营 自 主 权 ， 引 入 市 场 机 制 以 调 节 他 们 的 工 作 以 及 支 持 个 体 与 集 体 所 有 制 企 业 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 向 社 会 主 义 市 场 经 济 大 步 前 进 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 改 革 开 放 ： 先 声";
		if (result_num == 0)
		{
			text = " 新 政 府 决 定 减 少 中 央 政 府 在 国 有 企 业 管 理 中 的 作 用 ， 鼓 励 地 方 政 府 采 取 行 动 ， 积 极 引 进 市 场 化 经 营 方 式 ， 扩 大 私 营 企 业 和 合 作 企 业 的 权 利 。| 对 这 一 政 策 的 不 满 来 自 一 个 意 料 之 外 的 地 方 ： 在 阿 尔 巴 尼 亚 ， 恩 维 尔 · 霍 查 激 烈 批 评 我 们 的 修 正 主 义 政 策 和 对 马 克 思 主 义 的 背 叛 ， 并 切 断 了 和 我 们 的 一 切 联 系 。 嗯 ， 他 想 走 向 孤 立 主 义 — — 这 是 他 的 权 利 。";
			GlobalScript.inst.gameState.influencePRC -= 20;
			GlobalScript.inst.gameState.data[4] += 50;
			if (GlobalScript.inst.gameState.data[16] == 10)
			{
				GlobalScript.inst.gameState.data[16] = 12;
			}
			else if (GlobalScript.inst.gameState.data[16] <= 14)
			{
				ref int reference = ref GlobalScript.inst.gameState.data[16];
				int num = reference;
				reference = num + 1;
			}
			GlobalScript.inst.gameState.data[89] = 2;
			GlobalScript.inst.gameState.data[92] += 20;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.allcountries[20].Torg = false;
			GlobalScript.inst.gameState.allcountries[20].proprc = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 1)
				{
					politic.power += 50;
				}
				else if (politic.traits[0] == 2)
				{
					politic.power += 100;
				}
				else if (politic.traits[0] == 3)
				{
					politic.power += 50;
				}
			}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
