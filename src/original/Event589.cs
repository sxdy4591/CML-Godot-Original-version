using EventsForDLC;
using UnityEngine;

public class Event589 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 在 同 一 面 红 旗 之 下";
		text = " 1 9 7 7 年 ， 古 巴 领 导 人 菲 德 尔 · 卡 斯 特 罗 曾 试 图 推 动 埃 塞 俄 比 亚 与 索 马 里 两 个 亲 苏 的 “ 社 会 主 义 国 家 ” 与 南 也 门 组 成 一 个 社 会 主 义 联 盟 ， 然 而 ， 在 亲 自 见 到 了 巴 雷 与 门 格 斯 图 这 两 位 “ 革 命 新 星 ” 后 ， 大 失 所 望 的 卡 斯 特 罗 终 究 还 是 放 弃 了 这 个 异 想 天 开 的 想 法 。 此 后 没 过 多 长 时 间 ， 一 场 围 绕 着 欧 加 登 地 区 的 血 腥 冲 突 就 席 卷 了 两 国 ， 联 邦 的 构 想 也 彻 底 被 埃 塞 俄 比 亚 与 索 马 里 间 的 血 海 深 仇 所 埋 葬 。||不 过 ， 在 两 位 红 皮 独 裁 者 都 被 革 命 所 推 翻 、 非 洲 之 角 换 了 新 颜 的 今 天 ， 两 国 政 府 已 经 开 展 了 密 切 的 合 作 ， 并 就 欧 加 登 问 题 展 开 了 谈 判 。 在 谈 判 过 程 中 ， 建 立 一 个 涵 盖 索 马 里 与 埃 塞 俄 比 亚 的 非 洲 之 角 联 邦 的 提 议 又 重 新 回 到 了 两 国 人 民 的 视 线 之 内 。 也 许 我 们 可 以 推 波 助 澜 ， 完 成 古 巴 佬 的 未 竟 之 事 ， 让 东 非 的 这 两 个 革 命 国 家 真 正 携 起 手 来 ， 化 干 戈 为 玉 帛 ， 结 成 一 个 独 立 、 民 主 、 平 等 、 不 结 盟 的 社 会 主 义 联 邦 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 埃 索 情 谊 深 ， 同 志 加 兄 弟 ！";
		button_text[1] = " 还 是 暂 时 放 一 下 这 个 想 法 吧 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 在 同 一 面 红 旗 之 下";
		if (result_num == 0)
		{
			text = " 在 我 们 的 提 议 下 ， 埃 塞 俄 比 亚 领 导 人 与 索 马 里 领 导 人 于 南 也 门 首 都 亚 丁 签 订 了 《 埃 塞 俄 比 亚 - 索 马 里 联 邦 宪 章 》 ， 决 定 合 并 两 国 政 府 与 议 会 ， 非 洲 之 角 民 主 联 邦 共 和 国 就 此 诞 生 。 条 约 中 规 定 了 组 成 联 邦 的 两 个 主 体 埃 塞 俄 比 亚 与 索 马 里 具 有 同 等 地 位 ， 各 民 族 不 论 语 言 、 种 族 、 宗 教 信 仰 的 差 异 一 律 平 等 ， 并 将 按 照 民 族 聚 居 区 域 和 两 国 争 议 地 区 划 分 自 治 区 ， 赋 予 高 度 自 治 权 ， 而 欧 加 登 与 厄 立 特 里 亚 就 是 第 一 批 自 治 区 。 尽 管 两 国 间 仍 存 在 一 些 隔 阂 ， 但 相 信 很 快 ， 两 国 人 民 就 能 冰 释 前 嫌 ， 共 同 建 设 社 会 主 义 的 非 洲 之 角 。";
			a.allcountries[41].parts[0] = true;
			a.allcountries[41].name = " 非 洲 之 角 联 邦";
			a.allcountries[41].Gosstroy = 1;
			a.allcountries[41].SubGosstroy = 17;
			a.allcountries[42].LeaveAlliances();
			a.allcountries[41].EstablishGovernment(Government.ProChina);
			a.allcountries[41].Torg = true;
			a.allcountries[41].JoinAllOurAlliances(yes: true);
		}
		if (result_num == 1)
		{
			text = " 好 吧 ， 也 许 我 们 没 必 要 完 成 这 个 大 胆 的 计 划 ， 就 让 时 间 来 治 愈 埃 塞 俄 比 亚 与 索 马 里 人 民 的 伤 痛 与 隔 阂 吧 … …";
		}
	}
}
