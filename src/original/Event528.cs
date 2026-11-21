using EventsForDLC;
using UnityEngine;

public class Event528 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 保 革 伯 仲 ： 第 二 幕";
		text = " 多 亏 了 我 们 的 协 助 ， <color=#008000>社 会 党</color> 的 内 部 问 题 得 到 了 解 决 ， 其 与 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 的 联 盟 也 更 加 稳 固 了 。 在 非 武 装 中 立 与 护 宪 平 和 主 义 的 总 方 针 下 ， 联 合 政 府 对 日 本 社 会 展 开 了 一 系 列 变 革 ： 大 企 业 污 染 问 题 得 到 治 理 ， 劳 工 权 益 得 到 进 一 步 保 障 ， 新 的 福 利 政 策 得 以 出 台 。 同 时 针 对 当 前 日 本 社 会 的 情 况 ， 作 为 政 府 主 导 力 量 的 <color=#008000>社 会 党</color> 也 对 原 先 自 己 提 出 的 激 进 一 些 方 针 进 行 了 灵 活 调 整 ， 在 尽 量 不 触 及 其 支 持 者 基 本 盘 的 同 时 争 取 市 民 的 更 多 支 持 。 主 流 媒 体 均 认 为 只 要 不 出 现 重 大 突 发 变 故 ， 联 合 政 府 还 将 继 续 平 稳 运 转 下 去 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 拭 目 以 待 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 保 革 伯 仲 ： 第 二 幕";
		if (result_num == 0)
		{
			text = " <color=#008000>社 会 党</color> 席 位 虽 有 所 下 滑 ， 但 仍 有 1 6 5 席 。 联 合 政 府 的 另 外 两 党 <color=#FFFF00>公 明 党</color> 与 <color=#FFA500>民 主 社 会 党</color> 各 自 拿 下 6 0 席 和 3 5 席 ， 共 产 党 3 2 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 4 席 ， 无 所 属 议 员 2 1 席 。 <color=#0000FF>自 由 民 主 党</color> 遭 受 进 一 步 失 败 ， 只 获 得 1 9 2 席 。||新 政 府 由 <color=#008000>飞 鸟 田 一 雄</color> 领 导 ， 宣 布 将 延 续 非 武 装 积 极 中 立 路 线 ， 完 成 自 卫 队 的 彻 底 改 组 ， 加 速 推 动 国 有 化 进 程 ， 保 护 劳 工 阶 层 。 在 外 交 上 ， 新 政 府 将 进 一 步 加 强 与 苏 联 和 社 会 主 义 阵 营 的 关 系 ， 发 展 同 其 他 左 翼 政 党 的 关 系 。 并 且 就 落 实 上 一 届 政 府 任 期 中 与 美 国 达 成 的 《 日 美 安 保 条 约 》 问 题 开 展 外 交 活 动 。 据 报 道 ， 不 久 日 美 双 方 就 将 签 署 一 份 最 终 协 议 。 根 据 协 议 内 容 ， 驻 日 美 军 将 在 未 来 五 年 内 分 批 次 撤 出 日 本 。";
			a.allcountries[44].Gosstroy = 2;
			a.allcountries[44].SubGosstroy = 8;
			a.allcountries[44].Vyshi = false;
			a.allcountries[44].Torg = true;
			a.data[1] += 50;
			a.data[3] += 50;
			a.data[6] += 5;
			a.influencePRC += 50;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 20;
		}
	}
}
