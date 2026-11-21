using EventsForDLC;
using UnityEngine;

public class Event68 : EventsSecond
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
		name = " 光 州 事 件";
		text = "1979 年12 月 政 变 后 ， 全 斗 焕 夺 取 了 韩 国 大 权 ， 开 始 无 情 地 镇 压 反 对 军 政 府 的 抗 议 者 。5 月17 日 ， 戒 严 开 始 了 ，5 月18 日 ， 在 光 州 市 ， 为 反 对 关 闭 全 罗 南 道 国 立 大 学 而 组 织 的 学 生 示 威 遭 到 军 队 镇 压 。 这 引 起 了 城 市 的 不 满 风 暴 ， 并 引 发 了 更 大 的 骚 乱 ， 在 此 期 间 ， 起 义 者 成 功 地 占 领 了 警 察 局 和 军 事 基 地 ， 并 将 军 队 赶 出 了 城 市 。 根 据 我 们 的 情 报 ， 全 斗 焕 政 府 正 准 备 用 正 规 军 夺 取 光 州 。 通 过 支 持 起 义 者 使 其 能 够 坚 持 更 长 的 时 间 ， 以 及 引 导 我 们 情 报 部 门 的 力 量 煽 动 邻 近 地 区 的 不 满 ， 我 们 可 以 严 重 破 坏 韩 国 政 权 的 稳 定 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 让 他 们 自 己 处 理";
		if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.data[22] >= 80)
		{
			button_text[1] = " 援 助 起 义 者 和 煽 动 动 乱 （ 需 要8 军 事 实 力 ，10 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 足 够 的 资 源";
		}
		button_text[2] = " 呼 吁 各 方 对 话";
		button_text[3] = " 支 持 全 斗 焕 的 行 动";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 光 州 事 件";
		switch (result_num)
		{
		case 0:
			text = "5 月27 日 ， 韩 国 的 空 输 部 队 作 为 入 侵 的 五 个 师 中 的 先 头 部 队 ， 仅 用90 分 钟 就 占 领 了 市 中 心 。 据 各 种 估 计 ， 被 杀 害 的 平 民 人 数 从 几 百 人 到 几 千 人 不 等 。";
			GlobalScript.inst.gameState.empires[0].power += 10;
			break;
		case 1:
			text = " 因 为 我 们 提 供 的 武 器 ， 和 对 韩 军 计 划 的 扰 乱 和 破 坏 ， 对 光 州 的 突 击 变 得 漫 长 而 血 腥 。 此 外 ， 韩 国 其 他 城 市 和 地 区 的 人 在 了 解 到 了 正 在 发 生 的 大 屠 杀 后 （ 多 亏 了 我 们 的 特 工 ） ， 纷 纷 上 街 抗 议 ， 与 军 警 公 开 冲 突 。 最 终 ， 军 队 占 领 光 州 ， 严 酷 地 镇 压 了 起 义 ， 残 存 的 起 义 者 也 被 粉 碎 了 。 然 而 ， 其 他 城 市 的 抗 议 活 动 仍 在 继 续 ， 全 斗 焕 政 府 仍 安 危 未 定 。";
			GlobalScript.inst.gameState.data[22] -= 80;
			GlobalScript.inst.gameState.data[9] -= 80;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.empires[0].power -= 10;
			GlobalScript.inst.gameState.SKRebel = true;
			break;
		case 2:
			text = " 我 们 呼 吁 韩 国 当 局 和 光 州 的 起 义 者 进 行 谈 判 ， 寻 求 妥 协 。 这 些 声 明 得 到 了 起 义 者 的 支 持 ， 但 是 由 于 美 国 （ 除 了 支 持 我 们 声 明 的 一 些 政 治 家 ） 没 有 表 示 任 何 支 持 抗 议 者 和 和 平 解 决 冲 突 的 事 实 ， 我 们 的 呼 吁 被 当 局 忽 视 了 。5 月27 日 ， 韩 国 的 空 输 部 队 作 为 入 侵 的 五 个 师 中 的 先 头 部 队 ， 冲 进 市 中 心 ， 在90 分 钟 内 就 控 制 了 局 面 。 据 各 种 估 计 ， 被 杀 害 的 平 民 人 数 从 几 百 人 到 几 千 人 不 等 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].relations += 20;
			GlobalScript.inst.gameState.empires[0].power += 10;
			break;
		case 3:
		{
			text = " 韩 国 军 队 在90 分 钟 内 占 领 了 这 座 城 市 ， 残 酷 镇 压 了 起 义 ， 我 们 对 全 斗 焕 的 行 动 表 示 支 持 ， 说 这 样 的 强 硬 措 施 是 对 叛 乱 者 制 造 混 乱 的 唯 一 适 当 反 应 。 韩 国 政 府 对 我 们 的 支 持 表 示 感 谢 ， 但 不 少 国 家 ， 特 别 是 社 会 主 义 阵 营 ， 对 此 极 为 不 满 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].relations += 20;
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.empires[1].relations -= 80;
			party_change[4] = 0.25f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 3)
				{
					politic.power += 100;
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
