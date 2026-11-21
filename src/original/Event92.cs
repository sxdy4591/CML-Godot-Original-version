using EventsForDLC;
using UnityEngine;

public class Event92 : EventsSecond
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
		name = " 超 额 完 成 是 荣 誉 ！";
		text = " 主 席 同 志 ！ 考 虑 到 即 将 实 施 新 的 五 年 计 划 ， 部 分 来 自 计 委 的 专 家 和 经 济 学 家 建 议 为 下 个 五 年 选 择 一 个 重 点 发 展 的 经 济 部 门 。 你 需 要 决 定 国 民 经 济 中 哪 个 部 门 需 要 特 别 关 注 和 政 府 投 资 － 工 业 、 农 业 、 服 务 业 或 者 发 展 科 学 ？ 但 是 ， 我 们 也 可 以 更 谨 慎 地 使 用 资 金 ， 将 力 量 集 中 到 同 时 均 衡 发 展 三 个 产 业 ， 这 会 使 它 们 的 发 展 更 均 衡 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 投 资 工 业 升 级 （ 需 要1 百 万 预 算 ）";
		button_text[1] = " 继 续 加 强 农 业 机 械 化 （ 需 要1 百 万 预 算 ）";
		button_text[2] = " 投 资 提 高 服 务 质 量 （ 需 要1 百 万 预 算 ）";
		button_text[3] = " 把 五 年 计 划 重 点 放 在 科 学 研 究 的 发 展 上 （ 需 要1 百 万 预 算 ）";
		button_text[4] = " 集 中 力 量 到 均 衡 发 展 经 济 上 （ 需 要1 百 万 预 算 ）";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 超 额 完 成 是 荣 誉 ！";
		switch (result_num)
		{
		case 0:
			text = " 中 国 政 府 决 定 增 加 对 轻 工 业 和 重 工 业 的 现 代 化 建 设 ， 提 高 产 品 质 量 和 装 备 水 平 的 投 入 。 新 五 年 计 划 的 主 要 目 的 是 发 展 工 业 。";
			GlobalScript.inst.gameState.data[102] = 1;
			GlobalScript.inst.gameState.data[8] -= 10;
			break;
		case 1:
			text = " 中 国 政 府 决 定 向 农 业 领 域 的 机 械 化 和 新 技 术 的 引 进 拨 款 。 新 五 年 计 划 的 主 要 目 的 是 发 展 农 业 。";
			GlobalScript.inst.gameState.data[102] = 2;
			GlobalScript.inst.gameState.data[8] -= 10;
			break;
		case 2:
			text = " 中 国 政 府 决 定 提 高 服 务 业 的 服 务 质 量 ， 从 预 算 中 拨 出 额 外 资 金 。 新 五 年 计 划 的 主 要 目 标 是 实 现 服 务 业 步 入 现 代 化 。";
			GlobalScript.inst.gameState.data[102] = 3;
			GlobalScript.inst.gameState.data[8] -= 10;
			break;
		case 3:
			text = " 中 国 政 府 宣 布 了 当 前 五 年 计 划 的 经 济 发 展 计 划 ， 表 明 需 要 加 快 科 技 进 步 和 引 进 新 的 管 理 国 民 经 济 的 方 法 。 新 五 年 计 划 的 主 要 目 的 是 发 展 科 学 。";
			GlobalScript.inst.gameState.data[102] = 4;
			GlobalScript.inst.gameState.data[8] -= 10;
			break;
		case 4:
			text = " 尽 管 有 国 家 计 委 的 建 议 ， 中 国 政 府 还 是 宣 布 需 要 国 民 经 济 各 方 面 的 统 一 发 展 ， 并 从 国 家 预 算 中 拨 款 。";
			GlobalScript.inst.gameState.data[102] = 5;
			GlobalScript.inst.gameState.data[8] -= 10;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
