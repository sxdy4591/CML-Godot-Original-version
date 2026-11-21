using EventsForDLC;
using UnityEngine;

public class Event57 : EventsSecond
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
		name = " 红 色 旭 日";
		text = " 不 久 日 本 将 举 行 众 议 院 选 举 。 由 于 政 府 不 稳 定 和 腐 败 丑 闻 的 背 景 ， 日 本 共 产 党 在 近 期 逐 渐 获 得 人 民 支 持 ， 其 他 一 些 中 左 翼 的 反 对 派 也 是 如 此 。 假 如 我 们 对 日 共 有 影 响 力 ， 就 可 以 帮 助 他 们 的 竞 选 活 动 。 如 果 他 们 胜 选 了 ， 我 们 可 以 与 历 史 对 手 改 善 关 系 ， 并 最 终 使 美 军 基 地 撤 出 日 本 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 我 们 不 关 心 此 事";
		if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.allcountries[44].stab == 1)
		{
			button_text[1] = " 向 日 共 提 供 财 政 和 特 工 援 助";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 日 共 不 会 听 我 们 的 话 的 。";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 红 色 旭 日";
		switch (result_num)
		{
		case 0:
			text = " 结 果 自 民 党 利 用 了 反 对 派 的 分 裂 ， 获 得 了44% 的 选 票 ， 继 续 执 政 。 大 平 正 芳 首 相 继 续 日 本 的 自 由 — 亲 西 方 路 线 。";
			break;
		case 1:
			text = " 由 于 我 们 及 时 地 消 灭 了 宫 本 显 治 ， 日 共 愉 快 地 回 到 了 北 京 的 控 制 下 ， 并 接 受 了 我 们 的 帮 助 。 多 亏 了 我 们 的 资 金 帮 助 ， 他 们 得 以 开 展 有 效 的 选 前 活 动 ， 我 们 的 情 报 部 门 也 编 造 了 自 民 党 的 黑 材 料 ， 并 干 扰 他 们 的 演 说 。 结 果 ， 日 共 破 纪 录 地 得 到 了31% 的 选 票 ， 并 且 和 社 会 党 ， 公 明 党 和 其 他 中 左 翼 反 对 党 组 成 了 联 盟 。 不 久 对 自 民 党 官 员 腐 败 和 滥 用 职 权 的 诉 讼 被 提 起 ， 之 后 一 项 关 于 将 日 本 退 出 与 美 国 和 北 约 签 订 的 军 事 条 约 并 逐 步 剔 除 美 国 在 日 军 事 存 在 的 条 约 在 人 民 广 泛 支 持 下 被 通 过 了 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.data[8] -= 40;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.allcountries[44].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[44].SubGosstroy = 8;
			GlobalScript.inst.gameState.allcountries[44].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[44].Torg = true;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
