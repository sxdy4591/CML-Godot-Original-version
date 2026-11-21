using EventsForDLC;
using UnityEngine;

public class Event78 : EventsSecond
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
		name = " 永 远 的 总 统";
		text = " 据 我 们 所 知 ， 今 年6 月 菲 律 宾 将 举 行 第 一 次 总 统 选 举 。 自1972 年 以 来 ， 该 国 一 直 处 于 由 费 迪 南 德 · 马 科 斯 总 统 引 入 的 戒 严 状 态 ， 在1981 年1 月 他 解 除 了 戒 严 。 他 担 任 总 统 期 间 的 特 点 是 腐 败 猖 獗 、 裙 带 关 系 和 对 人 权 的 侵 犯 ， 这 导 致 反 对 派 的 活 动 急 剧 增 加 ， 其 中 一 个 领 导 核 心 是 毛 派 的 菲 律 宾 共 产 党 和 由 其 组 成 的 全 国 民 主 阵 线 ， 长 期 以 来 一 直 在 对 马 科 斯 政 权 进 行 运 动 和 游 击 战 争 。 然 而 ， 基 于 国 家 经 济 管 制 的 有 效 经 济 改 革 、 通 过 戒 严 来 镇 压 反 对 派 以 及 美 国 的 支 持 ， 很 可 能 使 他 在 即 将 到 来 的 选 举 中 获 胜 。 然 而 ， 我 们 有 一 个 极 好 的 机 会 破 坏 他 的 胜 利 — — 利 用 特 勤 部 队 向 菲 律 宾 共 产 党 和 全 国 民 主 阵 线 提 供 武 器 ， 我 们 可 以 对 马 科 斯 政 权 和 这 些 假 选 举 发 起 大 规 模 抗 议 。 但 是 ， 它 值 得 吗 ？ 事 实 上 ， 在1975 年 马 科 斯 断 绝 与 台 湾 的 关 系 ， 并 与 中 国 建 立 关 系 后 ， 周 恩 来 承 诺 ， 中 华 人 民 共 和 国 不 会 干 涉 菲 律 宾 的 政 策 ， 因 此 ， 也 许 与 马 科 斯 合 作 更 好 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.data[22] >= 80 && ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[0] = " 煽 动 动 乱 和 支 持 毛 派 （ 需 要10 特 工 网 络 ，8 军 事 实 力 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 这 不 值 得 我 们 为 之 努 力";
		}
		button_text[1] = " 这 不 关 我 们 的 事 。";
		if (GlobalScript.inst.gameState.data[6] < 800 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[2] = " 祝 贺 马 科 斯 获 胜 ， 并 尝 试 建 立 合 作 关 系";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 需 要 和 美 国 傀 儡 合 作";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 永 远 的 总 统";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 的 特 勤 部 队 和 武 器 供 应 的 帮 助 下 ， 菲 律 宾 共 产 党 和 国 民 运 动 能 够 展 开 大 规 模 的 煽 动 和 抗 议 ， 伴 随 着 大 量 的 游 击 活 动 。 其 他 政 治 力 量 和 普 通 公 民 很 快 也 加 入 了 这 些 不 满 。 当 然 ， 抗 议 很 快 就 被 警 察 镇 压 了 ， 游 击 队 的 进 攻 也 被 军 队 控 制 了 ， 但 我 们 似 乎 对 马 科 斯 政 权 造 成 了 严 重 的 破 坏 ， 他 没 有 料 到 中 国 会 突 然 进 行 如 此 无 耻 的 干 预 。 最 后 ， 他 成 功 地 赢 得 了 总 统 选 举 ， 获 得 了52% 的 选 票 ， 但 他 必 须 更 加 谨 慎 地 采 取 行 动 ， 共 产 党 的 影 响 力 显 著 增 强 。 或 许 ， 帮 助 他 们 更 进 一 步 ， 我 们 将 看 到 菲 律 宾 革 命 的 胜 利 … …";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.data[37] += 300;
			GlobalScript.inst.gameState.allcountries[47].Torg = false;
			break;
		case 1:
			text = " 结 果 ， 马 科 斯 赢 得 了 总 统 选 举 ， 获 得 了88% 的 选 票 。 菲 律 宾 似 乎 在 等 待 他 的 政 策 继 续 。";
			GlobalScript.inst.gameState.empires[0].power += 10;
			break;
		case 2:
			text = " 在 马 科 斯 以 压 倒 性 的88% 的 选 票 赢 得 总 统 选 举 后 ， 我 们 祝 贺 他 获 胜 ， 并 对1975 年 开 始 的 我 们 国 家 的 进 一 步 和 睦 表 示 希 望 。 马 科 斯 很 乐 意 利 用 我 们 的 提 议 ， 但 许 多 菲 律 宾 的 毛 派 团 体 称 之 为 背 叛 ， 共 产 党 的 影 响 力 有 所 下 降 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.data[37] -= 200;
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.allcountries[47].Torg = true;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
