using EventsForDLC;
using UnityEngine;

public class Event466 : EventsSecond
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
		name = " 团 结 就 是 力 量";
		text = " 由 于 我 们 的 援 助 和 介 入 ， 纳 萨 尔 派 的 力 量 不 断 壮 大 ， 他 们 在 印 度 东 部 和 北 部 的 农 村 地 区 开 辟 了 大 量 革 命 根 据 地 和 游 击 区 ； 与 此 同 时 ， 在 查 鲁 · 马 宗 达 同 志 牺 牲 后 陷 入 分 裂 的 纳 萨 尔 派 组 织 也 逐 渐 再 度 团 结 起 来 。 现 在 他 们 的 主 要 派 别 已 经 初 步 整 合 成 了 印 共 （ 马 列 ） 人 民 战 争 、 印 度 毛 主 义 共 产 主 义 中 心 、 印 共 （ 马 列 ） 中 央 重 组 委 员 会 和 印 共 （ 马 列 ） 解 放 几 个 较 大 的 组 织 。 但 是 这 些 组 织 之 间 仍 然 存 在 宗 派 主 义 问 题 和 较 大 的 路 线 分 歧 。 分 裂 的 纳 萨 尔 派 显 然 不 利 于 印 度 革 命 的 开 展 ， 或 许 我 们 应 该 更 加 深 入 地 介 入 他 们 ？ 不 管 怎 么 样 ， 主 席 同 志 ， 这 取 决 于 你 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 印 度 革 命 是 印 度 人 自 己 的 事 … …";
		button_text[1] = " 让 我 们 帮 助 印 度 同 志 们 团 结 起 来 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 团 结 就 是 力 量";
		switch (result_num)
		{
		case 1:
			text = " 在 我 们 的 特 工 简 单 地 制 造 了 一 场 “ 意 外 ” 除 掉 了 相 当 右 倾 的 印 共 （ 马 列 ） 解 放 的 领 导 人 维 诺 德 · 米 什 拉 — — 他 同 另 外 几 派 组 织 的 分 歧 最 大 — — 之 后 ， 一 切 变 得 相 当 顺 利 。 在 我 们 的 顾 问 团 的 指 导 和 施 压 下 ， 印 共 （ 马 列 ） 人 民 战 争 、 印 度 毛 主 义 共 产 主 义 中 心 、 印 共 （ 马 列 ） 中 央 重 组 委 员 会 和 印 共 （ 马 列 ） 解 放 以 及 一 些 小 型 的 纳 萨 尔 派 组 织 开 展 了 一 场 谈 判 ， 谈 判 解 决 了 关 于 查 鲁 · 马 宗 达 等 人 的 历 史 遗 留 问 题 ， 议 定 了 在 当 下 的 印 度 进 行 新 民 主 主 义 革 命 和 社 会 主 义 革 命 的 必 要 性 ， 明 确 了 马 列 毛 主 义 的 共 同 指 导 思 想 和 人 民 战 争 的 共 同 革 命 路 线 。 不 久 后 ， 在 的 一 场 联 合 代 表 大 会 上 ， 印 度 共 产 党 （ 毛 主 义 ） 成 立 了 。 现 在 印 度 革 命 有 了 一 个 统 一 的 组 织 ， 距 离 查 鲁 · 马 宗 达 同 志 的 定 下 的 目 标 又 近 了 一 大 步 ！";
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.influencePRC += 20;
			break;
		case 0:
			text = " 由 于 维 诺 德 · 米 什 拉 的 右 倾 政 策 ， 印 共 （ 马 列 ） 解 放 否 定 了 马 宗 达 ， 开 始 鼓 吹 议 会 斗 争 并 营 造 对 米 什 拉 的 个 人 崇 拜 ， 他 们 甚 至 与 另 外 几 派 纳 萨 尔 团 体 发 生 了 武 装 冲 突 。 而 印 共 （ 马 列 ） 人 民 战 争 、 印 度 毛 主 义 共 产 主 义 中 心 和 印 共 （ 马 列 ） 中 央 重 组 委 员 会 则 团 结 起 来 了 ， 他 们 将 组 织 合 并 为 印 度 共 产 党 （ 毛 主 义 ） ， 继 续 进 行 武 装 斗 争 。";
			GlobalScript.inst.gameState.influencePRC -= 20;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
