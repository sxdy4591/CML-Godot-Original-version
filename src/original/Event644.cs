using EventsForDLC;
using UnityEngine;

public class Event644 : EventsSecond
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
		name = " 红 色 非 洲 拿 破 仑";
		text = " 自 从 让 - 贝 德 尔 · 博 卡 萨 在 我 们 的 帮 助 下  1979 年 挫 败 了 法 帝 国 主 义 的 侵 略 以 来 ， 他 已 经 采 取 了 一 系 列 政 策 来 实 行 他 “ 博 卡 萨 运 动 ” 下 的 “ 科 学 社 会 主 义 ” ， 并 宣 传 “ 软 弱 的 共 和 制 法 兰 西 白 人 匪 帮 丢 弃 了 伟 大 先 皇 拿 破 仑 的 传 统 ， 事 实 上 走 向 了 堕 落 ， 而 只 有 中 非 的 博 卡 萨 一 世 皇 帝 才 是 波 拿 巴 主 义 的 真 正 继 承 人 ” 。||作 为 中 非 人 民 帝 国 和 执 政 党 黑 非 洲 社 会 发 展 运 动 的 领 导 人 ， 他 颁 布 了 一 系 列 改 革 措 施 — — 首 先 是 要 求 人 们 称 他 为 “ 陛 下 同 志 ” ， 并 拾 起 了 我 们 的 经 验 ， 将 革 命 委 员 会 作 为 各 级 行 政 机 构 ， 各 级 革 委 会 采 取 忠 于 博 卡 萨 的 军 管 代 表 、 黑 非 洲 社 会 发 展 运 动 党 员 和 博 卡 萨 家 族 成 员 的 “ 三 结 合 ” ； 当 然 ， 对 于 执 政 党 党 员 、 政 府 的 文 官 和 军 队 内 的 军 官 ， 博 卡 萨 陛 下 同 志 也 在 我 们 的 帮 助 下 进 行 了 清 洗 ， 党 领 导 政 府 和 军 队 的 体 制 被 初 步 建 立 起 来 。 对 于 反 革 命 分 子 ， 系 统 化 的 “ 劳 动 改 造 营 ” （ 实 际 上 是 特 种 监 狱 ） 则 是 他 们 的 去 处 。||中 非 革 命 的 硕 果 来 之 不 易 ， 帝 国 主 义 者 的 窥 伺 和 周 边 各 国 对 革 命 扩 散 的 不 满 始 终 威 胁 着 这 个 非 洲 中 央 的 “ 革 命 明 珠 ” 。 为 了 全 力 支 持 非 洲 人 民 的 革 命 ， 让 我 们 向 中 非 放 出 我 们 领 袖 同 志 的 “ 精 神 原 子 弹 ” 吧 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 英 明 领 袖 华 主 席 万 岁 ！";
		button_text[1] = " 博 卡 萨 的 人 民 帝 国 已 经 够 疯 狂 了";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 红 色 非 洲 拿 破 仑";
		switch (result_num)
		{
		case 0:
			text = " 近 日 ， 我 们 邀 请 了 中 非 人 民 帝 国 皇 帝 让 - 贝 德 尔 · 博 卡 萨 陛 下 同 志 访 问 我 国 ， 展 开 为 期 一 周 的 国 事 访 问 与 理 论 进 修 活 动 。 途 中 ， 博 卡 萨 同 志 对 我 国 革 命 的 运 动 式 的 组 织 方 式 异 常 感 兴 趣 。 在 对 群 众 的 即 兴 演 讲 上 ， 他 对 极 大 地 赞 扬 了 人 民 的 领 袖 华 主 席 ， 他 说 ： “ 华 国 锋 同 志 是 毛 主 席 之 后 当 之 无 愧 的 第 三 世 界 领 袖 、 百 年 难 遇 的 智 者 和 世 界 人 民 革 命 的 主 心 骨 。 ” 访 问 期 间 ， 两 国 的 关 系 极 大 地 深 化 了 ， 在 不 久 后 ， 中 非 便 出 现 了 中 国 的 军 事 基 地 。 访 问 结 束 后 ， 博 卡 萨 陛 下 同 志 很 快 在 国 内 宣 布 要 “ 将 博 卡 萨 运 动 进 行 到 底 ” ， 一 系 列 新 政 很 快 被 颁 布 下 来 。 首 先 是 执 政 党 黑 非 洲 社 会 发 展 运 动 被 改 组 为 “ 中 非 博 卡 萨 革 命 运 动 先 锋 党 ” ， 该 党 在 其 章 程 中 写 道 ： “ 中 非 博 卡 萨 革 命 运 动 先 锋 党 是 由 博 卡 萨 家 族 领 导 的 ， 以 波 拿 巴 主 义 、 科 学 社 会 主 义 、 华 国 锋 思 想 和 博 卡 萨 理 论 为 指 导 思 想 的 全 体 中 非 臣 民 的 先 锋 队 。 ” 博 卡 萨 、 拿 破 仑 和 华 国 锋 同 志 三 人 的 画 像 很 快 在 中 非 各 种 场 合 被 并 列 摆 放 ， 陛 下 同 志 的 雕 像 更 是 成 为 了 全 国 各 处 可 见 的 景 观 。 在 班 吉 的 一 场 重 要 讲 话 上 ， 博 卡 萨 宣 布 发 起 文 化 大 革 命 — — 当 然 ， 没 有 “ 造 反 ” 运 动 ， 只 有 实 际 上 的 军 管 。 名 义 上 独 立 但 实 际 上 是 由 博 卡 萨 组 建 的 “ 博 卡 萨 革 命 突 击 队 ” 利 用 文 化 革 命 的 名 义 在 国 内 横 冲 直 撞 ， 对 各 界 的 反 对 派 开 展 大 清 洗 。 《 博 卡 萨 陛 下 同 志 谈 治 国 理 政 》 更 是 成 为 了 中 小 学 生 、 公 务 员 和 党 员 的 必 背 书 目 ， 甚 至 是 考 驾 照 也 需 要 通 过 有 关 《 博 卡 萨 陛 下 同 志 谈 治 国 理 政 》 的 笔 试 。 对 博 卡 萨 画 像 进 行 “ 早 请 示 ， 晚 汇 报 ” 更 是 成 为 了 每 个 中 非 臣 民 的 日 常 。 当 然 诸 如 “ 波 拿 巴 主 义 的 永 恒 堡 垒 ” 、 “ 布 班 基 的 天 才 ” 等 称 号 也 必 不 可 少 的 部 分 。 博 卡 萨 二 世 在 未 来 将 留 学 中 国 ， 进 行 有 关 继 承 人 的 进 修 … …||尽 管 帝 国 主 义 者 及 其 走 狗 不 断 抹 黑 中 非 人 民 如 火 如 荼 的 革 命 ， 但 无 论 他 们 是 否 喜 欢 ， 我 们 站 在 历 史 正 确 的 一 边 ， 我 们 的 不 断 胜 利 将 埋 葬 他 们 ！";
			GlobalScript.inst.gameState.allcountries[65].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[65].SubGosstroy = 19;
			GlobalScript.inst.gameState.allcountries[65].proprc = true;
			GlobalScript.inst.gameState.allcountries[65].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[65].soc_stab = 1000;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.influencePRC += 50;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			break;
		case 1:
			text = " 说 笑 了 ， 主 席 同 志 ， 他 不 过 是 津 巴 布 韦 又 一 个 普 通 的 不 能 再 普 通 的 黑 人 领 袖 罢 了 。";
			GlobalScript.inst.gameState.event_done[644] = false;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
