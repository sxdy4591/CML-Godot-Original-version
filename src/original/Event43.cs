using EventsForDLC;
using UnityEngine;

public class Event43 : EventsSecond
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
		name = " 经 互 会 的 扩 张";
		text = " 长 期 以 来 ， 越 南 一 直 试 图 在 我 们 和 苏 联 之 间 取 得 平 衡 ， 因 为 尽 管 我 们 与 苏 联 存 在 分 歧 ， 但 我 们 的 志 愿 者 们 在 印 度 支 那 战 争 中 与 社 会 主 义 越 南 并 肩 作 战 。 但 随 着 战 争 结 束 和 越 南 统 一 ， 越 南 逐 渐 变 得 越 来 越 亲 苏 联 ， 越 来 越 疏 远 我 们 。|";
		if (GlobalScript.inst.gameState.allcountries[23].Gosstroy == 1)
		{
			text += " 黎 笋1977 年 访 问 莫 斯 科 后 ， 越 南 与 苏 联 又 开 始 了 一 次 友 好 关 系 ， 他 日 复 一 日 地 希 望 加 入 经 互 会 。 然 而 ， 该 国 部 分 领 导 人 反 对 与 苏 联 建 立 如 此 热 烈 的 友 好 关 系 ， 因 为 越 南 没 有 特 别 的 威 胁 ， 特 别 是 在 柬 埔 寨 的 波 尔 布 特 政 权 被 推 翻 后 。 这 是 我 们 干 预 和 制 止 苏 联 霸 权 扩 散 的 机 会 。";
		}
		else if (GlobalScript.inst.gameState.allcountries[23].Gosstroy != 1)
		{
			text += " 黎 笋1977 年 访 问 莫 斯 科 后 ， 越 南 与 苏 联 又 开 始 了 一 次 友 好 关 系 ， 他 日 复 一 日 地 希 望 加 入 经 互 会 。 我 们 显 然 无 法 阻 止 此 事 ， 尤 其 是 越 南 希 望 在 对 抗 亲 中 柬 埔 寨 的 波 尔 布 特 时 得 到 苏 联 支 持 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 不 干 涉";
		if (GlobalScript.inst.gameState.data[9] >= 30 && GlobalScript.inst.gameState.allcountries[23].Gosstroy == 1)
		{
			button_text[1] = " 尽 全 力 阻 止 整 个 进 程";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 管 不 着 啊";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 经 互 会 的 扩 张";
		switch (result_num)
		{
		case 0:
			text = "1978 年11 月 ， 越 南 加 入 经 济 互 助 委 员 会 ， 导 致 中 越 两 国 关 系 进 一 步 恶 化 。 反 越 情 绪 已 经 在 中 国 共 产 党 内 活 跃 成 熟 。 希 望 这 不 会 导 致 大 规 模 冲 突 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.empires[1].power += 30;
			GlobalScript.inst.gameState.allcountries[11].isSEV = true;
			break;
		case 1:
			text = " 我 们 的 干 预 ， 和 对 越 南 支 持 温 和 路 线 的 人 的 动 员 最 终 迫 使 黎 笋 和 越 共 领 导 层 无 限 期 推 迟 加 入 经 互 会 的 计 划 ， 遵 循 更 为 平 衡 的 外 交 政 策 。 苏 联 当 然 不 开 心 ， 但 这 至 少 帮 助 我 们 暂 时 避 免 越 南 和 苏 联 进 一 步 加 深 友 好 关 系 。";
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.empires[1].relations -= 70;
			GlobalScript.inst.gameState.data[9] -= 30;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
