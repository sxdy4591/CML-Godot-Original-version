using EventsForDLC;
using UnityEngine;

public class Event503 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 交 城 的 山 水 实 呀 实 在 美";
		text = " 主 席 同 志 ， 现 在 你 大 权 在 握 ， 但 是 为 何 不 考 虑 下 未 来 呢 ？ 十 年 ， 二 十 年 也 许 可 以 想 象 ， 但 是 五 十 年 ， 一 百 年 之 后 还 会 有 和 你 一 样 卓 越 的 人 保 护 我 国 革 命 的 遗 产 吗 ？ 也 许 ， 我 们 看 向 东 方 的 邻 国 以 及 遥 远 的 罗 马 尼 亚 的 经 验 不 仅 仅 要 从 他 们 经 济 改 革 的 试 点 触 发 ， 还 要 从 他 们 的 政 治 上 学 习 。 作 为 “ 英 明 领 袖 ” ， 我 们 抓 纲 治 国 的 “ 纲 ” ， 何 必 需 要 僵 化 于 “ 两 个 凡 是 ” 呢 ？ 一 切 由 你 决 定 …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 这 正 是 我 在 期 待 的 ， 让 我 们 开 始 吧 … …";
		button_text[1] = " 你 在 说 什 么 ？ 希 望 你 不 是 要 让 我 背 离 毛 主 席 的 路 线 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 交 城 的 山 水 实 呀 实 在 美";
		if (result_num == 0)
		{
			text = " 很 快 ， 一 揽 子 改 革 计 划 开 始 了 ， 你 的 雕 像 已 经 开 始 修 建 ， 对 于 您 的 个 人 崇 拜 的 民 谣 与 民 俗 故 事 已 经 在 民 间 流 传 开 来 ， 你 被 誉 为 “ 黄 土 高 原 的 天 才 ” ， “ 世 界 最 著 名 革 命 家 ” 、 “ 毛 泽 东 思 想 的 永 恒 火 焰 ” ， 是 “ 前 所 未 有 的 最 天 真 、 最 自 然 、 最 有 感 情 也 最 纯 粹 的 革 命 者 ”   … 而 在 党 内 ， 已 经 有 传 言 说 你 会 培 养 你 的 儿 子 为 唯 一 接 班 人 。 更 有 甚 者 认 为 你 死 后 ， 会 被 安 葬 在 一 个 纪 念 堂 当 中 。 在 路 线 上 ， 我 们 也 开 始 了 基 于 人 民 为 主 体 叙 事 ， 批 判 其 他 社 会 主 义 国 家 党 务 精 英 化 ， 强 调 反 对 社 会 帝 国 主 义 与 美 国 帝 国 主 义 ， 将 自 力 更 生 放 在 第 一 位 的 “ 民 族 特 色 社 会 主 义 ” 的 建 设 - 不 过 ， 我 们 自 然 需 要 花 不 少 资 源 来 平 息 并 且 党 内 对 这 些 变 化 不 满 的 人 ， 但 是 在 最 有 可 能 形 成 威 胁 的 两 翼 消 失 后 ， 党 内 已 经 很 少 有 异 议 能 够 挑 战 到 你 了 。";
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 100;
			a.data[31] = 900;
			a.data[8] -= 40;
			a.data[9] -= 40;
			a.data[15] = 6;
			a.data[16] = 10;
			a.data[17] = 16;
			a.data[18] = 20;
			a.data[50] = 29;
			a.modifies[6].active = false;
			if (GlobalScript.inst.gameState.modifies[6].active)
			{
				GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
				GlobalScript.inst.gameState.doctr[8] = "人 民 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = "协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = "经 典 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = "中 式 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = "国 家 监 护 资 本 主 义";
				GlobalScript.inst.gameState.doctr[14] = "社 会 主 义 导 向 市 场";
				GlobalScript.inst.gameState.doctr[15] = "左 翼 小 政 府";
				GlobalScript.inst.gameState.doctr[21] = "改 良 区 域 自 治 制 度";
				GlobalScript.inst.gameState.doctr[22] = "联 邦 制";
				GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
			}
			else
			{
				GlobalScript.inst.gameState.doctr[6] = " 一 党 制 共 和 国";
				GlobalScript.inst.gameState.doctr[7] = "一 党 独 大 式 民 主";
				GlobalScript.inst.gameState.doctr[8] = " 宪 政 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = " 协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = " 中 央 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = " 分 权 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = " 鸟 笼 经 济";
				GlobalScript.inst.gameState.doctr[14] = " “ 社 会 ” 市 场 经 济";
				GlobalScript.inst.gameState.doctr[15] = " 最 小 干 预";
				GlobalScript.inst.gameState.doctr[21] = " 联 邦 制";
				GlobalScript.inst.gameState.doctr[22] = " 联 省 自 治";
				GlobalScript.inst.gameState.doctr[24] = " 破 除 传 统";
			}
			a.modifies[3].active = true;
			a.empires[0].relations -= 100;
			a.empires[1].relations -= 100;
			GlobalScript.inst.gameState.allcountries[1].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[1].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
		}
		if (result_num == 1)
		{
			text = " 主 席 同 志 ， 那 只 是 个 建 议 ， 你 一 向 生 活 民 主 作 风 ， 包 容 党 内 各 派 思 想 ， 谦 逊 而 富 有 智 慧 ， 我 知 道 你 自 然 不 会 选 择 这 条 邪 路 的 ， 这 真 是 个 糟 糕 的 笑 话 。";
		}
	}
}
