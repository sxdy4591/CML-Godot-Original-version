using EventsForDLC;
using UnityEngine;

public class Event522 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 保 革 伯 仲 ： 第 一 幕";
		text = " 1 9 5 5 年 ， 当 时 执 政 的 自 由 党 与 民 主 党 合 并 为 <color=#0000FF>自 由 民 主 党</color> ， 而 1 9 4 5 年 成 立 的 <color=#008000>社 会 党</color> 也 在 该 年 结 束 分 裂 状 态 。 之 后 的 历 次 国 会 选 举 中 ， 代 表 保 守 的 <color=#0000FF>自 由 民 主 党</color> 均 保 持 着 半 数 以 上 的 席 位 以 维 持 一 党 执 政 的 状 态 ， 但 无 法 取 得 三 分 之 二 的 多 数 从 而 不 能 修 改 和 平 宪 法 。 而 代 表 革 新 的 ， 以 <color=#008000>社 会 党</color> 为 首 的 各 在 野 党 则 长 期 占 据 着 三 分 之 一 以 上 的 席 位 ， 但 同 样 无 法 取 得 半 数 以 上 从 而 不 能 执 政 。 这 一 特 殊 的 对 峙 情 况 也 被 称 为 ： 5 5 年 体 制 。|而 这 一 格 局 在 7 0 年 代 迎 来 了 松 动 。 6 0 年 代 的 高 速 经 济 增 长 被 1 9 7 3 年 度 的 负 增 长 画 上 了 句 号 。 田 中 角 荣 提 出 的 “ 日 本 列 岛 改 造 论 ” 与 相 关 政 策 带 来 的 土 地 投 机 化 投 资 又 使 得 批 发 物 价 与 消 费 者 物 价 暴 涨 。 同 时 以 四 大 公 害 病 为 代 表 的 公 害 也 接 连 发 生 ， 使 得 城 市 市 民 已 极 为 反 感 只 会 提 倡 经 济 发 展 的 <color=#0000FF>自 由 民 主 党</color> 。 在 1 9 7 2 年 的 选 举 中 ， <color=#0000FF>自 由 民 主 党</color> 遭 遇 大 败 ， 减 少 了 足 足 1 7 个 席 位 。 而 <color=#008000>社 会 党</color> 和 <color=#8B0000>共 产 党</color> 的 席 位 纷 纷 增 多 。 革 新 阵 营 力 量 大 幅 加 强 ， 日 本 政 坛 也 进 入 到 了 “ 保 革 伯 仲 ” 的 新 局 面 。|新 一 届 众 议 院 选 举 将 于 1 9 7 6 年 1 2 月 5 日 举 行 。 此 时 的 <color=#0000FF>自 由 民 主 党</color> 已 经 深 陷 洛 克 希 德 丑 闻 （ 该 公 司 向 日 本 政 界 高 层 提 供 巨 额 贿 款 以 确 保 旗 下 客 机 得 到 订 购 ） 中 ， 而 由 此 爆 发 的 激 烈 内 部 派 系 斗 争 的 曝 光 更 让 该 党 受 到 舆 论 普 遍 谴 责 。|而 在 野 党 同 样 问 题 重 重 。 作 为 势 力 最 大 的 <color=#008000>社 会 党</color> ， 其 内 部 矛 盾 的 激 烈 程 度 丝 毫 不 亚 于 对 手 ， 各 派 系 对 该 党 的 定 位 与 路 线 一 直 争 论 不 休 。 而 <color=#FFFF00>公 明 党</color> 在 1 9 6 9 年 底 的 “ 言 论 出 版 事 件 ” 之 后 被 迫 与 其 核 心 组 织 创 价 学 会 相 分 离 ， 从 宗 教 政 党 转 型 为 国 民 政 党 ， 其 根 基 变 得 更 加 薄 弱 。 宫 本 显 治 领 导 的 <color=#8B0000>共 产 党</color> 则 不 断 讨 好 城 市 市 民 阶 层 以 吸 引 其 选 票 。 但 纵 然 该 党 已 经 扔 掉 了 马 克 思 主 义 中 几 乎 所 有 与 暴 力 和 激 进 相 关 的 内 容 ， 其 天 然 的 特 殊 性 还 是 让 其 格 格 不 入 ， 大 部 分 在 野 党 也 不 愿 与 其 合 作 。||面 对 即 将 到 来 的 选 举 ， 党 内 形 成 了 几 种 不 同 意 见 ： 一 部 分 人 主 张 全 力 援 助 <color=#008000>社 会 党</color> 并 促 成 革 新 联 合 政 权 的 成 立 ， 而 改 革 派 和 一 些 外 交 人 员 给 出 了 不 同 意 见 ： 他 们 认 为 我 们 可 以 考 虑 帮 助 <color=#0000FF>自 由 民 主 党</color> 渡 过 危 机 。 毕 竟 之 前 推 动 中 日 建 交 的 也 是 该 党 政 府 ， 如 果 能 再 助 力 他 们 一 把 ， 我 们 便 有 机 会 寻 求 中 日 之 间 的 大 规 模 贸 易 合 同 并 引 进 日 本 的 先 进 技 术 。 此 外 还 有 一 种 意 见 ， 认 为 我 们 不 应 局 限 于 议 会 之 内 而 是 应 该 直 接 向 青 年 组 织 、 工 会 等 力 量 予 以 帮 助 。 你 怎 么 看 ， 主 席 同 志 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] <= 2)
		{
			button_text[0] = " 让 我 们 帮 助 社 会 党 建 立 新 政 权";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 美 国 会 怎 么 想 ？";
		}
		if (a.data[56] <= 2)
		{
			button_text[1] = " 直 接 援 助 活 跃 社 会 组 织";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 社 会 运 动 不 符 合 民 主 自 由 原 则 ！";
		}
		if (a.data[56] > 2)
		{
			button_text[2] = " 帮 助 自 由 民 主 党 渡 过 难 关 并 借 此 扶 植 亲 华 派 势 力";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 和 资 本 主 义 和 解 ？ 你 是 认 真 的 ？";
		}
		button_text[3] = " 让 我 们 暂 时 观 望";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 保 革 伯 仲 ： 第 一 幕";
		if (result_num == 0)
		{
			text = " 我 们 最 终 决 定 给 予 <color=#008000>社 会 党</color> 全 方 位 的 帮 助 。 不 仅 向 其 在 各 地 的 竞 选 组 织 提 供 了 资 金 援 助 ， 并 且 指 示 我 们 在 日 本 的 特 工 发 起 一 系 列 行 动 ， 包 括 破 坏 <color=#0000FF>自 由 民 主 党</color> 候 选 人 竞 选 集 会 、 向 媒 体 提 供 更 多 现 政 府 内 幕 与 丑 闻 、 组 织 城 市 市 民 集 会 抗 议 等 ， 这 对 执 政 党 的 声 誉 造 成 了 连 环 打 击 。||最 终 我 们 的 努 力 得 到 了 回 报 。 <color=#008000>社 会 党</color> 赢 得 了 史 无 前 例 的 1 7 0 席 。 其 他 党 情 况 如 下 ： <color=#FFFF00>公 明 党</color> 6 0 席 ， <color=#FFA500>民 主 社 会 党</color> 3 0 席 、 <color=#0000FF>新 自 由 俱 乐 部</color> 1 2 席 、 <color=#8B0000>共 产 党</color> 2 2 席 ， 无 所 属 议 员 2 1 席 。 <color=#0000FF>自 由 民 主 党</color> 迎 来 空 前 惨 败 ， 只 获 得 1 9 6 席 ， 失 去 了 半 数 多 数 并 首 次 成 为 在 野 党 。||尽 管 党 内 依 旧 质 疑 声 不 断 ， 但 <color=#008000>社 会 党</color> 高 层 最 终 还 是 决 定 与 <color=#FFFF00>公 明 党</color> 、 <color=#FFA500>民 主 社 会 党</color> 建 立 联 合 政 权 。 新 政 府 由 成 田 知 巳 领 导 ， 宣 布 将 带 领 日 本 走 向 非 武 装 积 极 中 立 路 线 ， 改 组 自 卫 队 ， 推 动 公 有 化 进 程 ， 筹 备 国 家 计 划 委 员 会 、 保 护 劳 工 阶 层 。 在 外 交 上 ， 新 政 府 表 示 不 久 便 会 与 美 国 开 展 废 除 《 日 美 安 保 条 约 》 的 谈 判 ， 同 时 开 始 加 强 与 苏 联 和 社 会 主 义 阵 营 的 关 系 ， 发 展 同 其 他 左 翼 政 党 的 关 系 ， 并 呼 吁 推 动 全 球 裁 军 以 及 无 核 化 。";
			a.allcountries[44].Gosstroy = 2;
			a.allcountries[44].SubGosstroy = 8;
			a.data[6] += 5;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.data[8] -= 40;
			GlobalScript.inst.gameState.data[9] -= 40;
		}
		if (result_num == 1)
		{
			text = " 我 们 向 <color=#008000>日 本 社 会 主 义 青 年 同 盟</color> 、 <color=#FF0000>日 本 民 主 青 年 同 盟</color> 等 青 年 组 织 、 左 翼 工 会 和 其 他 社 会 组 织 提 供 援 助 ， 包 括 头 盔 、 横 幅 、 海 报 ， 以 及 最 重 要 的 资 金 。 在 我 们 的 大 力 支 持 下 ， 它 们 开 展 了 一 系 列 新 的 社 会 运 动 ， 对 <color=#0000FF>自 由 民 主 党</color> 的 支 持 率 造 成 了 一 定 打 击 ， 也 让 <color=#008000>社 会 党</color> 内 “ 社 共 共 斗 ” 的 呼 声 再 次 出 现 （ 尽 管 <color=#8B0000>共 产 党</color> 对 此 兴 趣 不 大 且 多 次 批 评 <color=#008000>社 会 党</color> 是 中 派 政 党 ） ， 而 <color=#FFFF00>公 明 党</color> 、 <color=#FFA500>民 主 社 会 党</color> 和 <color=#008000>社 会 党</color> 之 间 的 关 系 也 变 得 更 加 微 妙 。||最 终 <color=#008000>社 会 党</color> 赢 得 1 5 0 席 ， 数 量 为 历 史 第 二 多 ， 但 依 旧 不 够 打 破 <color=#0000FF>自 由 民 主 党</color> 的 垄 断 。 其 他 党 情 况 如 下 ： <color=#FFFF00>公 明 党</color> 5 5 席 ， <color=#FFA500>民 主 社 会 党</color> 2 9 席 、 <color=#0000FF>新 自 由 俱 乐 部</color> 1 7 席 、 <color=#8B0000>共 产 党</color> 1 7 席 ， 无 所 属 议 员 2 1 席 。 <color=#0000FF>自 由 民 主 党</color> 席 位 则 下 跌 至 2 2 2 席 ， 不 得 不 通 过 与 无 所 属 议 员 和 <color=#0000FF>新 自 由 俱 乐 部</color> 组 成 联 合 政 府 来 凑 足 半 数 以 上 的 席 位 。||新 政 府 由 <color=#0000FF>福 田 赳 夫</color> 领 导 ， 宣 布 将 推 行 以 平 衡 预 算 为 导 向 的 经 济 稳 定 增 长 理 论 ， 扩 大 基 础 投 资 ， 通 过 国 内 需 求 主 导 的 经 济 管 理 来 增 加 进 口 并 进 一 步 开 放 市 场 。 在 外 交 上 ， 新 政 府 将 推 动 “ 全 方 位 外 交 ” ， 维 持 对 美 关 系 的 同 时 也 积 极 与 其 他 国 家 维 系 往 来 并 强 调 亚 洲 外 交 ， 包 括 开 始 向 中 国 提 供 官 方 发 展 援 助 ， 并 积 极 向 东 南 亚 提 供 支 援 。 这 一 立 场 在 次 年 8 月 <color=#0000FF>福 田 赳 夫</color> 访 问 东 南 亚 期 间 得 到 鲜 明 体 现 ： 他 强 调 日 本 将 在 不 成 为 军 事 强 国 的 情 况 下 为 世 界 和 平 与 繁 荣 做 出 贡 献 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 6;
			a.data[6] += 5;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[9] -= 30;
		}
		if (result_num == 2)
		{
			text = " 考 虑 到 来 之 不 易 的 外 交 成 果 ， 我 们 决 定 转 向 <color=#0000FF>自 由 民 主 党</color> ， 对 该 党 在 选 举 战 况 胶 着 地 区 的 候 选 人 提 供 大 量 帮 助 。 并 且 依 靠 之 前 两 国 邦 交 正 常 化 留 下 的 人 脉 关 系 ， 我 们 进 一 步 与 <color=#0000FF>自 由 民 主 党</color> 内 部 的 亲 华 派 议 员 取 得 了 联 系 。 由 于 <color=#0000FF>自 由 民 主 党</color> 的 大 帐 篷 特 性 ， 想 要 保 持 与 他 们 的 联 系 并 壮 大 其 实 力 并 不 难 做 到 。 很 快 这 些 人 便 形 成 了 一 股 新 的 派 阀 力 量 。 为 了 更 好 地 发 展 ， 他 们 正 式 注 册 了 “ 政 党 政 策 研 究 会 ” 这 一 名 号 并 以 此 为 掩 护 进 行 各 种 活 动 。 不 过 请 注 意 ： 我 们 需 要 经 常 性 地 为 他 们 提 供 支 持 ， 这 样 才 能 在 关 键 时 刻 发 挥 作 用 。||同 时 得 益 于 我 们 在 当 地 人 员 的 出 色 服 务 ， 执 政 党 成 功 保 住 了 多 个 地 区 的 议 员 席 位 。 不 久 我 们 收 到 了 对 方 的 电 报 ， 向 我 们 表 示 感 谢 ， 并 提 出 希 望 促 成 双 方 新 的 贸 易 合 作 。||最 终 <color=#008000>社 会 党</color> 获 得 1 1 5 席 ， 几 乎 没 有 变 化 。 其 他 党 情 况 如 下 ： <color=#FFFF00>公 明 党</color> 5 0 席 ， <color=#FFA500>民 主 社 会 党</color> 2 4 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 3 0 席 ， <color=#8B0000>共 产 党</color> 1 2 席 ， 无 所 属 议 员 2 1 席 。 <color=#0000FF>自 由 民 主 党</color> 虽 有 所 下 滑 但 仍 保 住 了 半 数 以 上 的 席 位 ， 获 得 2 5 8 席 。||新 政 府 由 <color=#0000FF>福 田 赳 夫</color> 领 导 ， 宣 布 将 推 行 以 平 衡 预 算 为 导 向 的 经 济 稳 定 增 长 理 论 ， 扩 大 基 础 投 资 ， 通 过 国 内 需 求 主 导 的 经 济 管 理 来 增 加 进 口 并 进 一 步 开 放 市 场 。 在 外 交 上 ， 新 政 府 将 推 动 “ 全 方 位 外 交 ” ， 维 持 对 美 关 系 的 同 时 也 积 极 与 其 他 国 家 维 系 往 来 并 强 调 亚 洲 外 交 ， 包 括 开 始 向 中 国 提 供 官 方 发 展 援 助 ， 并 积 极 向 东 南 亚 提 供 支 援 。 这 一 立 场 在 次 年 8 月 <color=#0000FF>福 田 赳 夫</color> 访 问 东 南 亚 期 间 得 到 鲜 明 体 现 ： 他 强 调 日 本 将 在 不 成 为 军 事 强 国 的 情 况 下 为 世 界 和 平 与 繁 荣 做 出 贡 献 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 6;
			a.allcountries[44].prcinfl = 10;
			a.data[6] -= 5;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[9] -= 30;
		}
		if (result_num == 3)
		{
			text = " 考 虑 到 我 们 自 己 还 有 问 题 需 要 处 理 ， 我 们 最 终 决 定 暂 时 不 采 取 行 动 ， 积 攒 实 力 。||不 久 选 举 结 果 正 式 公 布 ： <color=#008000>社 会 党</color> 获 得 1 2 3 席 ， 仅 有 小 幅 上 涨 。 其 他 党 情 况 如 下 ： <color=#FFFF00>公 明 党</color> 5 5 席 ， <color=#FFA500>民 主 社 会 党</color> 2 9 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 1 7 席 ， <color=#8B0000>共 产 党</color> 1 7 席 ， 无 所 属 议 员 2 1 席 。 <color=#0000FF>自 由 民 主 党</color> 失 去 了 半 数 多 数 ， 只 有 2 4 9 席 ， 不 得 不 吸 引 无 所 属 议 员 来 保 住 半 数 以 上 的 席 位 。||新 政 府 由 <color=#0000FF>福 田 赳 夫</color> 领 导 ， 宣 布 将 推 行 以 平 衡 预 算 为 导 向 的 经 济 稳 定 增 长 理 论 ， 扩 大 基 础 投 资 ， 通 过 国 内 需 求 主 导 的 经 济 管 理 来 增 加 进 口 并 进 一 步 开 放 市 场 。 在 外 交 上 ， 新 政 府 将 推 动 “ 全 方 位 外 交 ” ， 维 持 对 美 关 系 的 同 时 也 积 极 与 其 他 国 家 维 系 往 来 并 强 调 亚 洲 外 交 ， 包 括 开 始 向 中 国 提 供 官 方 发 展 援 助 ， 并 积 极 向 东 南 亚 提 供 支 援 。 这 一 立 场 在 次 年 8 月 <color=#0000FF>福 田 赳 夫</color> 访 问 东 南 亚 期 间 得 到 鲜 明 体 现 ： 他 强 调 日 本 将 在 不 成 为 军 事 强 国 的 情 况 下 为 世 界 和 平 与 繁 荣 做 出 贡 献 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 6;
		}
	}
}
