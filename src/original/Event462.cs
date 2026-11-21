using EventsForDLC;
using UnityEngine;

public class Event462 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 一 个 中 国 ?";
		text = " 在 我 们 消 除 威 权 分 子 的 毒 害 并 确 立 自 由 民 主 的 政 治 体 制 后 ， 美 国 与 我 们 的 关 系 日 益 升 温 ， 我 们 也 不 断 加 强 与 他 们 各 方 面 的 合 作 。 随 着 时 间 的 推 移 ， 我 们 开 始 再 度 审 视 两 岸 和 平 统 一 的 可 能 性 。 令 人 欣 喜 的 是 ， 美 国 人 出 于 战 略 需 要 ， 居 然 愿 意 帮 助 我 们 与 台 湾 当 局 斡 旋 ！ 这 表 明 他 们 支 持 我 们 的 统 一 。 我 们 离 统 一 ， 似 乎 只 有 一 步 之 遥 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 结 果 将 会 如 何 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 一 个 中 国 ?";
		if (result_num == 0)
		{
			text = " 当 地 时 间" + GlobalScript.inst.gameState.data[21] + " 年" + GlobalScript.inst.gameState.data[20] + " 月" + GlobalScript.inst.gameState.data[19] + " 日 ， 在 美 国 的 默 许 下 ， 我 国 领 袖" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 率 领 代 表 团 对 台 北 进 行 了 历 史 性 的 访 问 ， 在 此 期 间 ， 经 过 闭 门 谈 判 后 ， 决 定 成 立 一 个 委 员 会 ， 制 定 台 湾 和 中 国 大 陆 逐 步 统 一 的 原 则 。\n 我 们 最 终 同 意 建 立 台 湾 特 别 行 政 区 来 解 决 两 岸 问 题 。 台 湾 特 别 行 政 区 保 留 自 己 现 有 的 政 治 体 制 （ 蒋 经 国 同 意 在 中 央 政 府 指 导 下 逐 步 实 行 民 主 政 治 ） 和 经 济 体 制 ， 但 在 重 大 事 宜 （ 如 外 交 ） 上 要 与 中 国 大 陆 步 调 一 致 ， 并 宣 布 统 一 于 中 央 政 府 。 谈 判 结 束 后 ， 两 岸 领 导 人 合 影 留 念 。 在 我 们 宣 布 谈 判 结 果 后 ， 民 众 欢 呼 雀 跃 ， 高 兴 不 已 。 两 岸 的 经 济 文 化 交 流 迅 速 展 开 ， 不 少 由 于 国 民 党 逃 到 台 湾 而 离 开 大 陆 的 的 同 胞 也 回 到 了 自 己 的 家 乡 ， 两 岸 的 血 又 流 到 了 一 起 。 ";
			GlobalScript.inst.gameState.allcountries[38].SubGosstroy = 8;
		}
	}
}
