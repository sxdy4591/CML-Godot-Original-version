using EventsForDLC;
using UnityEngine;

public class Event88 : EventsSecond
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
		name = " 那 是 怎 样 的 时 光 啊";
		text = " 主 席 同 志 ， 索 尔 兹 伯 里 传 来 了 惊 人 的 消 息 ， 该 国 的 种 族 主 义 政 权 坚 冰 正 在 消 融 。||在 国 际 社 会 的 压 力 下 ， 罗 德 西 亚 史 密 斯 政 府 与 非 洲 温 和 民 族 主 义 政 党 达 成 了 “ 内 部 协 议 ” 。 与 此 同 时 ， 政 府 继 续 与 爱 国 阵 线 的 武 装 抵 抗 作 斗 争 ， 爱 国 阵 线 是 由 两 个 非 洲 领 导 党 派 组 成 的 联 盟 ： 津 巴 布 韦 非 洲 人 民 联 盟 （<color=#006400>ZAPU</color>） 和 津 巴 布 韦 非 洲 民 族 联 盟 （<color=#8B0000>ZANU</color>） 。 我 国 一 贯 支 持<color=#8B0000>ZANU</color>， 而 苏 联 支 持<color=#006400>ZAPU</color>。||早 在 1 9 7 6 年 美 国 国 务 卿 基 辛 格 就 提 出 过 ， 想 要 解 决 罗 得 西 亚 问 题 不 能 通 过 暴 力 ， 只 能 通 过 建 立 行 之 有 效 的 民 主 机 构 ， 一 人 一 票 决 定 该 国 的 未 来 。 这 次 签 署 的 “ 内 部 解 决 方 案 ” 不 可 谓 不 进 步 ： 非 洲 人 首 次 被 纳 入 领 导 职 位 ， 同 时 建 立 了 独 立 的 公 务 员 制 度 、 司 法 机 构 、 警 察 部 队 和 军 队 。 该 解 决 方 案 还 成 立 了 一 个 由 伊 恩 · 史 密 斯 和 三 名 黑 人 政 治 家 （ 穆 佐 雷 瓦 ， 西 索 尔 和 齐 劳 ） 组 成 的 执 行 委 员 会 ， 以 及 一 个 部 长 委 员 会 ， 而 史 密 斯 保 留 了 总 理 头 衔 。 协 议 还 指 出 ， 新 政 府 的 主 要 工 作 是 起 草 国 家 宪 法 ， 在 1 9 7 9 年   4 月 举 行 选 举 ， 并 与 爱 国 阵 线 达 成 停 火 协 议 。 据 说 该 协 议 的 另 一 个 目 标 是 希 望 结 束 该 国 的 内 战 。 选 举 结 束 后 ， 穆 佐 雷 瓦 表 示 ， 他 不 希 望 这 个 国 家 成 为 “ 一 个 骗 局 、 一 个 欺 诈 行 为 、 一 个 仅 有 独 立 外 表 的 空 壳 ” ， 也 不 希 望 这 个 国 家 “ 成 为 另 一 个 香 蕉 共 和 国 ” 。||很 明 显 ， 这 是 种 族 主 义 政 权 开 始 消 融 的 迹 象 。 但 我 们 该 做 些 什 么 ？ 也 许 我 们 应 该 像 过 去 那 样 ， 积 极 的 支 持<color=#8B0000>ZANU</color>， 也 许 还 有<color=#006400>ZAPU</color>。 或 者 顺 应 时 代 的 潮 流 ， 我 们 该 认 识 一 位 新 朋 友 了 ， 就 像 我 们 认 识 蒙 博 托 那 样 。 无 论 如 何 ， 还 请 您 再 三 斟 酌 ， 这 很 有 可 能 会 象 征 着 我 们 对 民 族 解 放 运 动 的 极 速 转 向 。 对 我 们 声 誉 的 打 击 不 亚 于 又 一 篇 “ 三 个 世 界 理 论 ” 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8)
		{
			button_text[0] = " 继 续 支 持 他 们 的 武 装 斗 争";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 们 ？ 他 们 连 保 险 都 不 会 开 ！";
		}
		if (GlobalScript.inst.gameState.data[56] >= 2 && GlobalScript.inst.gameState.data[15] < 8)
		{
			button_text[1] = " 和 新 政 府 做 朋 友";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 你 看 不 出 他 们 是 在 演 戏 ？";
		}
		button_text[2] = " 什 么 都 不 做";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 那 是 怎 样 的 时 光 啊";
		GlobalScript.inst.gameState.allcountries[127].name = "津 巴 布 韦 罗 得 西 亚";
		GlobalScript.inst.gameState.allcountries[127].puppetOf = -1;
		switch (result_num)
		{
		case 0:
			text = " 我 们 选 择 像 过 去 一 样 支 持 津 巴 布 韦 人 民 的 斗 争 。 在 坦 桑 尼 亚 和 赞 比 亚 的 帮 助 下 ， 大 量 的 武 器 继 续 被 运 往 <color=#8B0000>ZANU</color> 在 卢 萨 卡 的 指 挥 部 。 为 了 防 止 爱 德 华 多 · 蒙 德 拉 纳 那 般 悲 剧 性 的 事 件 再 度 发 生 ， 我 们 提 出 了 为 <color=#8B0000>ZANU</color> 和 <color=#8B0000>ZANLA</color> 高 级 领 导 人 提 供 安 保 的 协 议 。 毕 竟 他 们 是 白 人 政 权 中 的 眼 中 钉 ， 而 穆 加 贝 本 人 也 长 期 处 在 罗 得 西 亚 国 土 安 全 局 的 监 视 下 。 这 会 为 他 们 减 少 潜 在 的 暗 杀 风 险 。||尽 管 西 索 尔 本 人 就 是 <color=#8B0000>ZANU</color> 的 成 员 ， 这 也 丝 毫 不 影 响 该 党 的 主 要 成 员 对 新 政 权 的 大 加 鞭 笞 。 但 是 <color=#8B0000>ZANU</color> 和 <color=#006400>ZAPU</color>   不 可 能 当 永 远 的 战 友 ， 迟 早 有 一 天 他 们 会 兵 戎 相 见 … …||穆 佐 雷 瓦 试 图 说 服 英 国 政 府 承 认 过 渡 政 府 ， 但 英 国 政 府 没 有 这 样 做 。 同 样 ， 一 些 人 认 为 该 协 议 是 承 认 罗 得 西 亚 和 取 消 制 裁 的 “ 充 分 ” 理 由 。 美 国 众 议 院 和 美 国 参 议 院 同 意 取 消 制 裁 ， 但 附 加 条 件 是 只 有 “ 举 行 选 举 后 ” 才 能 取 消 制 裁 。 据 报 道 ， 该 协 议 还 导 致 政 治 犯 被 释 放 。 但 是 ， 由 于 当 时 中 上 阶 层 的 构 成 ， 该 国 的 公 务 员 、 司 法 、 警 察 和 武 装 部 队 继 续 由 以 前 的 官 员 管 理 ， 其 中 大 多 数 是 白 人 而 不 是 津 巴 布 韦 本 地 人 。 英 联 邦 秘 书 处 声 称 ， “ 所 谓 的 ‘ 津 巴 布 韦 罗 得 西 亚 宪 法 ’ “ 不 会 比 它 所 取 代 的UDI（ 单 方 面 宣 称 独 立 ） 宪 法 “ 更 合 法 、 更 有 效 ” 。||种 族 隔 离 政 权 已 经 时 日 无 多 了 ， 那 曾 经 是 多 么 独 特 的 一 段 日 子 啊 … …";
			GlobalScript.inst.gameState.data[8] -= 80;
			break;
		case 1:
			text = " 我 们 甚 至 领 先 于 美 国 和 英 国 政 府 承 认 了 该 国 的 政 权 更 迭 ， 称 其 为 “ 赤 道 非 洲 以 南 的 政 治 奇 迹 ” 。 很 快 ， 我 们 的 国 旗 便 在 索 尔 兹 伯 里 的 街 头 升 起 ， 穆 佐 勒 瓦 代 总 统 在 电 报 中 感 谢 了 中 华 人 民 共 和 国 对 该 国 的 支 持 。 但 是 阿 尔 巴 尼 亚 人 非 常 讨 厌 我 们 的 行 为 ， 称 其 为 “ 中 国 修 正 主 义 者 试 图 在 美 苏 之 间 走 平 衡 木 的 丑 态 ” 。 他 们 不 过 是 吃 不 到 葡 萄 嫌 葡 萄 酸 罢 了 。||穆 佐 雷 瓦 试 图 说 服 英 国 政 府 承 认 过 渡 政 府 ， 但 英 国 政 府 没 有 这 样 做 。 同 样 ， 一 些 人 认 为 该 协 议 是 承 认 罗 得 西 亚 和 取 消 制 裁 的 “ 充 分 ” 理 由 。 美 国 众 议 院 和 美 国 参 议 院 同 意 取 消 制 裁 ， 但 附 加 条 件 是 只 有 “ 举 行 选 举 后 ” 才 能 取 消 制 裁 。 据 报 道 ， 该 协 议 还 导 致 政 治 犯 被 释 放 。 但 是 ， 由 于 当 时 中 上 阶 层 的 构 成 ， 该 国 的 公 务 员 、 司 法 、 警 察 和 武 装 部 队 继 续 由 以 前 的 官 员 管 理 ， 其 中 大 多 数 是 白 人 而 不 是 津 巴 布 韦 本 地 人 。 英 联 邦 秘 书 处 声 称 ， “ 所 谓 的 ‘ 津 巴 布 韦 罗 得 西 亚 宪 法 ’ “ 不 会 比 它 所 取 代 的UDI（ 单 方 面 宣 称 独 立 ） 宪 法 “ 更 合 法 、 更 有 效 ” 。||种 族 隔 离 政 权 已 经 时 日 无 多 了 ， 那 曾 经 是 多 么 独 特 的 一 段 日 子 啊 … …";
			GlobalScript.inst.gameState.allcountries[127].Torg = true;
			a.influencePRC -= 40;
			break;
		case 2:
			text = " 穆 佐 雷 瓦 试 图 说 服 英 国 政 府 承 认 过 渡 政 府 ， 但 英 国 政 府 没 有 这 样 做 。 同 样 ， 一 些 人 认 为 该 协 议 是 承 认 罗 得 西 亚 和 取 消 制 裁 的 “ 充 分 ” 理 由 。 美 国 众 议 院 和 美 国 参 议 院 同 意 取 消 制 裁 ， 但 附 加 条 件 是 只 有 “ 举 行 选 举 后 ” 才 能 取 消 制 裁 。 据 报 道 ， 该 协 议 还 导 致 政 治 犯 被 释 放 。 但 是 ， 由 于 当 时 中 上 阶 层 的 构 成 ， 该 国 的 公 务 员 、 司 法 、 警 察 和 武 装 部 队 继 续 由 以 前 的 官 员 管 理 ， 其 中 大 多 数 是 白 人 而 不 是 津 巴 布 韦 本 地 人 。 英 联 邦 秘 书 处 声 称 ， “ 所 谓 的 ‘ 津 巴 布 韦 罗 得 西 亚 宪 法 ’ “ 不 会 比 它 所 取 代 的UDI（ 单 方 面 宣 称 独 立 ） 宪 法 “ 更 合 法 、 更 有 效 ” 。||种 族 隔 离 政 权 已 经 时 日 无 多 了 ， 那 曾 经 是 多 么 独 特 的 一 段 日 子 啊 … …";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
