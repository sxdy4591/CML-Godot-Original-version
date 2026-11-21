using EventsForDLC;
using UnityEngine;

public class Event51 : EventsSecond
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
		name = " 看 看 就 走 … …";
		text = " 四 月 革 命 后 ， 人 民 民 主 党 面 临 着 许 多 困 难 ， 这 是 由 于 其 成 员 缺 乏 经 验 和 残 存 着 大 量 的 封 建 和 宗 教 残 余 ， 但 由 于 人 民 民 主 党 两 个 派 系 之 间 的 力 量 相 对 平 衡 ， 有 可 能 避 免 重 大 的 政 治 冲 突 。 特 别 是 由 于 ， 旗 帜 派 和 人 民 派 的 成 员 在 苏 联 的 支 持 下 ， 成 功 地 将 阿 明 从 政 府 和 中 央 委 员 会 除 名 ， 指 控 他 违 反 集 体 领 导 原 则 和 普 什 图 民 族 主 义 。 然 而 ， 从 今 年 年 初 开 始 的 反 动 组 织 ， 特 别 是 伊 斯 兰 主 义 者 的 起 义 势 头 越 来 越 强 劲 。 巴 基 斯 坦 和 伊 朗 的 一 些 公 民 加 入 了 他 们 ， 非 法 越 境 ， 甚 至 美 国 设 法 以 某 种 方 式 将 他 们 的 武 器 和 顾 问 拖 到 阿 富 汗 帮 助 圣 战 者 。 在 这 种 情 况 下 ， 苏 联 应 阿 富 汗 领 导 人 的 无 数 要 求 ， 决 定 引 进 一 支 小 分 队 ， 保 卫 重 要 的 军 事 设 施 和 城 市 ， 解 放 阿 富 汗 民 主 共 和 国 军 队 的 力 量 与 叛 乱 分 子 作 战 。 他 们 似 乎 不 希 望 大 规 模 参 与 敌 对 行 动 ， 但 西 方 已 经 谴 责 这 一 行 为 ， 称 之 为 入 侵 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 不 回 应";
		button_text[1] = " 谴 责 军 队 介 入";
		button_text[2] = " 支 持 军 队 介 入";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 看 看 就 走 … …";
		switch (result_num)
		{
		case 0:
			text = " 随 着 部 分 部 队 的 释 放 ， 在 苏 联 顾 问 和 空 军 的 帮 助 下 ， 阿 富 汗 民 主 共 和 国 对 伊 斯 兰 主 义 者 发 起 了 相 对 成 功 的 敌 对 行 动 。 现 在 预 测 未 来 的 胜 利 还 为 时 过 早 ， 但 在 美 国 无 法 直 接 进 入 阿 富 汗 的 情 况 下 ， 阿 富 汗 民 主 共 和 国 具 有 显 著 优 势 。";
			break;
		case 1:
			text = " 在 参 加 了 西 方 外 交 官 的 讲 话 之 后 ， 我 们 还 谴 责 苏 联 军 队 进 入 阿 富 汗 ， 称 这 是 对 一 个 主 权 国 家 事 务 的 野 蛮 干 涉 。 西 方 领 导 人 支 持 我 们 的 声 明 ， 但 苏 联 领 导 人 没 有 回 应 。 随 着 部 分 部 队 的 释 放 ， 在 苏 联 顾 问 和 航 空 的 帮 助 下 ， 阿 富 汗 民 主 共 和 国 对 伊 斯 兰 主 义 者 发 起 了 相 对 成 功 的 敌 对 行 动 。 现 在 预 测 未 来 的 胜 利 还 为 时 过 早 ， 但 在 美 国 无 法 直 接 进 入 阿 富 汗 的 情 况 下 ， 阿 富 汗 民 主 共 和 国 具 有 显 著 优 势 。";
			GlobalScript.inst.gameState.empires[0].relations += 80;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			break;
		case 2:
			text = " 与 世 界 各 地 听 到 的 关 于 “ 入 侵 ” 的 声 音 相 反 ， 我 们 决 定 支 持 苏 联 军 队 的 进 入 ， 因 为 这 是 为 了 确 保 阿 富 汗 的 和 平 与 稳 定 ， 根 据 《 苏 阿 友 好 条 约 》 ， 这 是 绝 对 合 法 的 。 当 然 ， 在 西 方 ， 我 们 被 称 为 血 腥 政 权 的 同 谋 者 ， 但 苏 联 感 谢 这 一 支 持 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.empires[0].relations -= 110;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
