using EndingsDLCDraft;

public class Ending2 : EndingsSecond
{
	public override void TextOfEnding(ref string name, ref string text)
	{
		name = "阿 拉 伯 世 界";
		text = "";
		text += "<color=#8B2323><size=54>摩 洛 哥</size></color>|";
		if (GlobalScript.inst.gameState.allcountries[54].Gosstroy == 0 && !GlobalScript.inst.gameState.allcountries[30].parts[1] && !GlobalScript.inst.gameState.allcountries[30].parts[0])
		{
			text += " <size=40>哈 桑 之 声</size>|";
			text += "哈 桑 二 世 继 续 执 政 到 他 的 心 脏 停 止 跳 动 。| ";
			text += " <size=40>我 仍 在 那 里</size>";
			if (GlobalScript.inst.gameState.allcountries[54].parts[0] && GlobalScript.inst.gameState.resultOfEvents[463] == 1 && GlobalScript.inst.gameState.resultOfEvents[560] != 1)
			{
				text += "| 西 撒 人 阵 蚍 蜉 撼 树 般 的 武 装 斗 争 终 究 还 是 失 败 了 。 战 斗 已 落 幕 ， 撒 哈 拉 阿 拉 伯 民 主 共 和 国 没 能 经 受 住 时 间 的 考 验 。 不 少 人 放 下 了 武 器 ， 在 绝 望 中 离 开 了 自 己 长 久 以 来 的 故 乡 。 而 摩 洛 哥 彻 底 占 领 了 西 撒 哈 拉 ， 国 际 社 会 也 不 得 不 再 次 考 虑 这 块 领 土 的 问 题 。";
			}
			else if (GlobalScript.inst.gameState.allcountries[54].parts[0])
			{
				text += "| 西 撒 哈 拉 仍 然 被 摩 洛 哥 殖 民 着 。 摩 洛 哥 人 修 建 了 一 座 巨 大 的 墙 ， 覆 压 二 百 余 里 ， 隔 离 东 西 。 联 合 国 宣 布 将 举 行 公 民 投 票 ， 却 被 投 票 权 问 题 屡 次 打 断 。 ";
			}
			else
			{
				text += "| 针 对 西 撒 哈 拉 问 题 ，摩 洛 哥 王 国 力 图 一 雪 前 耻 ， 但 在 多 国 斡 旋 和 阿 尔 及 利 亚 的 直 接 干 涉 下 ， 无 事 发 生 。";
			}
		}
		else if (GlobalScript.inst.gameState.allcountries[54].SubGosstroy == 6)
		{
			text += " <size=40>换 汤 不 换 药</size>|";
			text += "随 着 自 由 的 风 刮 到 了 摩 洛 哥 ， 阿 拉 伯 世 界 的 常 青 树 还 是 倒 下 了 。 新 的 政 府 采 取 的 休 克 疗 法 并 不 能 很 好 的 解 决 问 题 ， 甚 至 把 摩 洛 哥 从 高 度 发 达 的 非 洲 国 家 榜 单 上 踹 了 下 去 。 而 人 民 自 由 党 已 经 连 续 出 任 了 五 届 首 相 ， 更 让 其 牌 号 里 的 自 由 看 起 来 是 个 笑 话 。 但 尽 管 摩 洛 哥 的 人 民 饱 受 饥 荒 和 传 染 病 的 风 险 ， 他 们 赢 得 了 自 由 ， 对 吧 ？| 针 对 西 撒 哈 拉 问 题 ，新 生 的 摩 洛 哥 王 国 力 图 一 雪 前 耻 ， 但 在 多 国 斡 旋 和 阿 尔 及 利 亚 的 直 接 干 涉 下 ， 无 事 发 生 。";
		}
		else if (GlobalScript.inst.gameState.allcountries[54].SubGosstroy == 11)
		{
			text += " <size=40>真 主 ， 柏 柏 尔 ， 社 会 主 义</size>|";
			text += "在 宣 布 继 承 先 知 时 期 阿 拉 伯 公 社 的 观 点 以 外 ， 一 个 真 正 的 “ 阿 拉 维 社 会 主 义 之 路 ” 被 建 立 起 来 了 ： 该 制 度 将 阿 拉 维 王 室 的 传 统 观 点 （ 如 伊 斯 兰 教 的 天 课 税 ， 阿 拉 维 王 朝 正 统 论 ， 大 摩 洛 哥 主 义 和 反 自 由 主 义 ） 与 南 斯 拉 夫 铁 托 主 义 的 劳 动 集 体 自 治 和 里 夫 共 和 国 抗 击 侵 略 者 的 社 会 爱 国 主 义 意 识 形 态 合 二 为 一 。 这 一 兼 收 并 蓄 的 意 识 形 态 的 实 行 ， 在 许 多 方 面 得 归 功 于 西 班 牙 好 教 员 的 经 验 。 而 在 经 济 领 域 内 ， 资 产 阶 级 的 自 然 权 利 理 念 与 私 有 财 产 神 圣 不 可 侵 犯 的 铁 律 也 遭 遇 了 打 击 一 一 国 家 实 现 了 对 大 多 数 大 型 工 业 企 业 的 国 有 化 ， 并 将 其 转 交 给 了 各 类 劳 动 集 体 。 尽 管 在 不 久 后 出 现 了 “ 铁 托 主 义 顽 疾 ” ， 但 “ 人 民 国 王 ” 的 臣 民 们 依 然 为 此 类 激 进 主 义 改 革 感 到 高 兴 。";
		}
		else if (!GlobalScript.inst.gameState.allcountries[54].parts[0] && !GlobalScript.inst.gameState.allcountries[30].parts[1] && !GlobalScript.inst.gameState.allcountries[30].parts[0] && GlobalScript.inst.gameState.allcountries[54].SubGosstroy == 2)
		{
			text += " <size=40>同 志 们 ， 我 们 会 在 明 日 相 见</size>|";
			text += "随 着 革 命 在 摩 洛 哥 获 得 了 胜 利 ， 新 政 府 开 始 借 鉴 中 华 人 民 共 和 国 的 先 进 经 验 。 支 持 工 人 组 成 了 “ 革 命 运 动 ” ， 学 生 组 成 了 “ 青 年 摩 洛 哥 ” ， 开 始 清 洗 伪 装 成 社 会 主 义 者 的 摩 洛 哥 人 民 力 量 联 盟 组 织 的 成 员 ， 这 一 运 动 被 称 为 “ 红 色 十 月 革 命 ” 。 新 的 政 府 宣 布 “ 开 展 彻 底 的 社 会 主 义 革 命 ， 根 除 此 前 的 右 倾 投 降 主 义 ” ， 继 续 开 展 国 有 化 和 公 有 化 运 动 ， 并 将 鞍 钢 宪 法 引 入 国 企 ； 同 时 ， 土 改 后 的 土 地 和 此 前 已 经 组 织 的 合 作 社 被 改 组 为 人 民 公 社 ， 农 村 社 区 将 被 公 社 式 管 理 。 此 前 未 被 完 全 废 除 的 议 会 制 也 被 废 除 ， 取 而 代 之 的 是 无 产 阶 级 的 真 正 民 主 。| <size=40>撒 哈 拉 的 主 人 们</size>|西 撒 哈 拉 得 以 独 立 。 该 国 在 西 撒 人 阵 （ 现 已 更 名 撒 哈 拉 阿 拉 伯 社 会 主 义 先 锋 党 ） 的 指 导 下 开 展 了 一 系 列 社 会 主 义 改 革 ， 例 如 土 地 改 革 和 建 设 集 体 化 农 村 。 尽 管 人 力 是 个 问 题 ， 但 新 生 的 摩 洛 哥 愿 意 在 这 个 问 题 上 提 供 帮 助 ， 甚 至 提 出 了 大 批 无 偿 援 助 的 一 揽 子 改 革 计 划 。 我 们 也 得 到 了 一 个 优 质 的 磷 酸 盐 产 地 ， 以 及 大 西 洋 岸 边 的 一 个 坚 实 盟 友";
		}
		else if (GlobalScript.inst.gameState.allcountries[54].parts[0] || GlobalScript.inst.gameState.allcountries[30].parts[1] || GlobalScript.inst.gameState.allcountries[30].parts[0])
		{
			text += " <size=40>永 无 世 仇</size>|";
			text += "摩 洛 哥 建 立 了 稳 定 的 人 民 民 主 政 权 。 磷 矿 的 国 有 化 为 这 个 小 国 带 来 了 数 不 尽 的 财 富 。 而 美 国 人 也 为 他 们 失 去 了 一 个 傀 儡 而 苦 恼 着 。| 西 撒 哈 拉 作 为 摩 洛 哥 西 撒 哈 拉 民 主 联 邦 的 组 成 国 ， 在 西 撒 人 阵 的 指 导 下 开 展 了 一 系 列 社 会 主 义 改 革 ， 例 如 土 地 改 革 和 建 设 集 体 化 农 村 。 尽 管 人 力 是 个 问 题 ， 但 摩 洛 哥 相 当 愿 意 在 这 个 问 题 上 提 供 帮 助 。 ";
		}
		if (GlobalScript.inst.gameState.allcountries[30].parts[1] || GlobalScript.inst.gameState.allcountries[30].parts[0])
		{
			text += "| 不 久 之 后 ， 两 个 阿 拉 伯 国 家 宣 布 加 入 阿 拉 伯 联 合 共 和 国 ， 成 为 了 其 中 不 可 分 割 的 一 部 分 。 ";
		}
		text += "||";
		text += "<color=#8B2323><size=54>阿 拉 伯 联 合</size></color>|";
		if (GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[30].parts[2] && GlobalScript.inst.gameState.allcountries[14].oar && GlobalScript.inst.gameState.allcountries[35].oar && GlobalScript.inst.gameState.allcountries[13].oar && GlobalScript.inst.gameState.allcountries[40].oar && GlobalScript.inst.gameState.allcountries[54].oar && GlobalScript.inst.gameState.allcountries[55].oar && GlobalScript.inst.gameState.allcountries[93].oar && GlobalScript.inst.gameState.allcountries[104].oar && GlobalScript.inst.gameState.allcountries[101].oar && GlobalScript.inst.gameState.allcountries[102].oar && GlobalScript.inst.gameState.allcountries[103].oar && GlobalScript.inst.gameState.allcountries[105].oar && GlobalScript.inst.gameState.allcountries[37].oar && (GlobalScript.inst.gameState.allcountries[24].oar || GlobalScript.inst.gameState.allcountries[25].oar))
		{
			text += " <size=40>革 命 ， 阿 拉 伯 与 社 会 主 义</size>|";
			text += "中 国 对 当 地 马 克 思 主 义 政 党 与 共 产 主 义 武 装 持 之 以 恒 的 苦 心 经 营 直 接 导 致 了 阿 拉 伯 地 区 权 力 格 局 的 革 命 性 转 变 — — 曾 分 属 中 央 条 约 组 织 反 共 阵 营 与 阿 拉 伯 社 会 民 族 主 义 堡 垒 的 地 区 ， 如 今 得 以 在 革 命 社 会 主 义 基 础 上 达 成 政 治 一 致 ， 并 根 据 互 助 合 作 、 国 间 平 等 与 国 际 主 义 原 则 建 立 改 良 版 本 的 阿 拉 伯 诸 国 合 作 形 式 ， 从 而 将 泛 阿 拉 伯 主 义 理 想 以 另 一 类 形 式 实 现 复 活 。 可 考 虑 到 各 地 新 兴 政 党 大 都 缺 乏 执 政 经 验 ， 且 战 后 百 废 待 兴 的 事 实 。 即 便 各 方 能 在 中 国 协 调 下 达 成 共 识 ， 可 组 织 新 政 治 形 式 仍 非 易 事 ： 旧 政 府 活 动 、 地 方 部 族 猖 獗 、 伊 斯 兰 主 义 滋 生 、 乃 至 社 会 发 展 普 遍 落 后 的 事 实 使 得 红 色 阿 拉 伯 诸 国 独 木 难 支 ， 仅 靠 自 身 难 以 步 入 正 轨 。|因 此 ， 新 生 的 阿 拉 伯 诸 国 自 然 地 选 择 以 搭 车 的 取 巧 形 式 重 建 祖 国 并 实 现 区 域 一 体 化 ： 很 快 ， 统 一 的 泛 阿 拉 伯 民 族 权 力 机 构 便 根 据 各 国 议 会 、 部 长 会 议 、 最 高 法 院 、 中 央 银 行 与 总 参 谋 部 等 部 门 建 立 对 应 组 织 ， 基 于 人 口 与 地 区 设 立 代 表 配 额 ， 并 在 同 时 采 纳 双 重 管 辖 权 ： 即 适 用 于 中 方 经 济 合 作 组 织 与 集 体 安 全 条 约 的 相 关 行 政 命 令 与 法 律 文 件 ， 同 样 对 泛 阿 拉 伯 机 构 具 有 法 律 效 力 ； 且 相 关 机 制 下 的 官 员 也 可 在 此 框 架 内 实 行 对 阿 拉 伯 民 族 权 力 机 构 的 咨 询 权 与 监 督 权 。 事 实 上 效 法 类 似 欧 洲 共 同 体 与 大 西 洋 主 义 的 道 路 ： 同 他 们 的 前 宗 主 国 一 样 ， 泛 阿 拉 伯 一 体 化 机 制 也 尝 试 通 过 背 靠 域 外 强 权 的 雄 厚 资 本 ， 通 过 打 通 与 中 国 政 治 圈 融 合 的 桥 梁 为 自 身 谋 利 。 而 成 效 也 确 实 显 著 ： 各 阿 拉 伯 国 家 均 通 过 中 阿 特 殊 关 系 实 现 了 政 治 稳 定 与 经 济 重 建 目 标 ， 且 均 采 纳 左 翼 政 党 民 主 与 世 俗 主 义 原 则 治 国 。 他 们 间 也 得 以 建 立 共 同 的 经 济 与 文 化 空 间 ： 市 场 、 海 关 、 物 流 业 务 管 理 实 现 统 一 ； 矿 产 、 钢 铁 与 碳 氢 化 合 物 行 业 也 建 立 起 联 营 机 制 。 所 有 一 切 都 为 阿 拉 伯 地 区 经 济 发 展 与 人 民 福 祉 增 长 开 辟 了 无 穷 前 景 ： 如 今 各 国 已 通 过 快 速 工 业 化 与 形 成 国 际 油 气 行 业 卡 特 尔 的 便 利 ， 正 享 受 属 于 自 己 的 “ 黄 金20年 ” … … 未 来 会 如 何 ？ 是 阿 拉 伯 诸 国 试 图 在 中 国 框 架 内 寻 求 更 大 自 主 权 ？ 还 是 仍 老 实 扮 演 东 方 大 局 的 一 部 分 ？ 只 有 当 阿 拉 伯 联 合 共 和 国 真 正 成 为 举 足 轻 重 的 区 域 一 体 化 机 制 时 才 能 得 到 答 案 。";
		}
		else if (GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
		{
			text += " <size=40>革 命 ， 阿 拉 伯 与 社 会 主 义</size>|";
			text += "中 国 对 当 地 马 克 思 主 义 政 党 与 共 产 主 义 武 装 持 之 以 恒 的 苦 心 经 营 直 接 导 致 了 阿 拉 伯 地 区 权 力 格 局 的 革 命 性 转 变 — — 曾 分 属 中 央 条 约 组 织 反 共 阵 营 与 阿 拉 伯 社 会 民 族 主 义 堡 垒 的 地 区 ， 如 今 大 都 在 革 命 社 会 主 义 基 础 上 达 成 政 治 一 致 ， 并 根 据 互 助 合 作 、 国 间 平 等 与 国 际 主 义 原 则 建 立 改 良 版 本 的 阿 拉 伯 诸 国 合 作 形 式 ， 从 而 将 泛 阿 拉 伯 主 义 理 想 以 另 一 类 形 式 实 现 复 活 。 然 而 ， 并 非 所 有 的 阿 拉 伯 国 家 都 选 择 了 另 类 一 体 化 形 式 ： 地 方 部 族 与 军 事 强 人 并 不 打 算 简 单 地 接 受 境 外 势 力 主 导 的 强 制 统 一 ， 并 将 新 版 阿 拉 伯 联 合 共 和 国 同 马 穆 鲁 克 苏 丹 国 ， 乃 至 土 耳 其 对 当 地 的 军 事 占 领 形 式 相 提 并 论 。 因 此 ， 残 存 的 阿 拉 伯 民 族 主 义 者 很 自 然 地 选 择 各 显 神 通 ， 或 选 择 拥 抱 主 权 国 家 形 式 走 自 立 道 路 ， 或 尝 试 与 意 识 形 态 相 对 接 近 的 邻 国 抱 团 取 暖 ， 建 立 起 与 其 分 庭 抗 礼 的 一 体 化 形 式 ： 类 似 5 0 年 代 初 欧 洲 对 峙 的 格 局 最 终 在 北 非 与 中 东 地 区 复 现 ， 形 成 了 碎 片 化 的 政 治 格 局 。 一 侧 是 各 地 新 兴 政 党 筹 建 ， 并 逐 渐 与 中 国 政 治 联 盟 整 合 的 红 色 阿 拉 伯 民 族 权 力 机 构 ； 一 侧 则 是 当 地 卡 里 斯 马 们 组 建 ， 且 尝 试 联 系 美 国 等 域 外 势 力 支 持 的 民 族 主 义 集 团 。 由 此 我 们 可 说 ， 追 求 向 东 看 齐 的 丝 绸 之 路 主 义 与 传 统 纳 赛 尔 主 义 间 的 对 抗 已 在 这 片 土 地 拉 开 序 幕 。 未 来 会 如 何 ？ 分 析 人 士 称 ： 阿 拉 伯 地 区 碳 氢 化 合 物 生 产 的 主 动 权 ， 域 外 大 国 对 当 地 的 投 资 力 度 与 干 预 决 心 将 成 为 决 定 该 地 冷 战 局 势 的 胜 负 手 。";
		}
		else if (GlobalScript.inst.gameState.completedDecisions[20] && !GlobalScript.inst.gameState.allcountries[30].proprc)
		{
			text += " <size=40>搬 石 砸 脚</size>|";
			text += "八 个 阿 拉 伯 国 家 得 以 合 并 为 单 一 的 “ 阿 拉 伯 联 合 共 和 国 ” 。 中 东 新 国 家 的 诞 生 导 致 了 当 地 权 力 格 局 的 革 命 性 转 变 — — 曾 作 为 中 央 条 约 组 织 反 共 前 线 的 战 壕 ， 如 今 成 为 了 阿 拉 伯 民 族 团 结 与 社 会 民 族 主 义 的 牢 固 壁 垒 。 可 在 美 苏 均 从 阿 拉 伯 世 界 内 出 局 ， 为 蒸 蒸 日 上 的 中 国 让 路 的 时 代 背 景 下 。 本 就 主 张 同 科 学 社 会 主 义 泾 渭 分 明 ， 走 阿 拉 伯 民 族 独 立 发 展 道 路 的 “ 卡 里 斯 玛 ” 们 。 又 会 心 安 理 得 地 接 受 这 样 的 新 秩 序 ， 老 老 实 实 地 扮 演 起 东 方 神 秘 力 量 制 衡 中 东 局 势 的 棋 子 吗 ？|新 政 权 草 创 初 百 废 待 兴 ？ 成 员 国 们 的 天 才 领 袖 们 均 各 有 心 思 ， 难 以 接 受 全 新 的 游 戏 规 则 ？ 各 地 阿 拉 伯 民 族 主 义 者 多 依 托 当 地 部 族 与 军 事 集 团 存 在 的 组 织 形 式 将 天 然 利 于 离 心 主 义 ？ 和 中 国 在 阿 拉 伯 地 区 拓 展 势 力 范 围 ， 建 立 起 新 版 中 央 条 约 组 织 的 可 能 相 比 。 上 述 的 一 切 似 乎 都 显 得 不 是 问 题 — — 于 是 ， 从 阿 尔 及 利 亚 的 民 族 解 放 阵 线 到 埃 及 的 自 由 军 官 组 织 ， 从 叙 利 亚 的 阿 萨 德 家 族 到 伊 拉 克 的 右 翼 复 兴 党 都 联 合 起 来 了 ： 阿 拉 伯 地 区 的 共 产 党 是 第 一 批 倒 下 的 ， 随 后 被 顺 藤 摸 瓜 一 举 收 拾 的 则 是 政 府 内 的 亲 中 派 … … 联 合 共 和 国 的 新 任 领 导 层 宣 布 以 纳 赛 尔 时 代 的 革 命 指 导 委 员 会 为 原 型 建 立 军 事 统 治 ， 并 撮 合 各 国 武 装 力 量 与 部 族 头 领 ， 建 立 了 适 应 寡 头 统 治 与 内 部 协 商 的 大 致 框 架 ， 多 少 实 现 了 对 外 以 以 一 个 声 音 说 话 。|新 政 权 上 马 后 的 第 一 步 便 是 宣 布 “ 阿 拉 伯 民 族 解 放 革 命 ” 的 完 全 胜 利 ， 一 面 废 除 了 与 中 国 的 绝 大 多 数 合 作 协 定 ， 一 面 则 加 入 不 结 盟 运 动 ， 奉 行 所 谓 “ 以 我 为 主 ， 为 我 所 用 ” 的 多 边 外 交 政 策 。 同 时 ， 该 国 几 乎 是 马 不 停 蹄 地 没 收 全 部 中 阿 合 资 企 业 ， 启 动 了 所 谓 “ 还 利 为 民 ” 的 国 有 化 ， 并 在 同 时 开 始 核 武 器 研 发 与 全 国 军 事 化 。 彻 底 走 上 了 同 中 国 的 阿 拉 伯 布 局 对 抗 的 道 路 … … 有 人 说 该 国 即 将 瞄 准 巴 勒 斯 坦 与 阿 拉 伯 半 岛 下 手 … … 未 来 会 如 何 ？ 只 有 当 阿 拉 伯 联 合 共 和 国 真 正 成 为 举 足 轻 重 的 世 界 大 国 时 才 能 得 到 答 案 。 不 过 ， 至 少 我 们 现 在 可 以 说 。 争 夺 第 三 世 界 领 导 权 的 内 战 已 经 开 始 … …";
		}
		else if (GlobalScript.inst.gameState.completedDecisions[20] && GlobalScript.inst.gameState.allcountries[30].proprc)
		{
			text += " <size=40>养 虎 为 患</size>|";
			text += "八 个 阿 拉 伯 国 家 得 以 合 并 为 单 一 的 “ 阿 拉 伯 联 合 共 和 国 ” 。 中 东 新 国 家 的 诞 生 导 致 了 当 地 权 力 格 局 的 革 命 性 转 变 — — 曾 作 为 中 央 条 约 组 织 反 共 前 线 的 战 壕 ， 如 今 成 为 了 阿 拉 伯 民 族 团 结 与 社 会 民 族 主 义 的 牢 固 壁 垒 。 可 在 美 苏 均 从 阿 拉 伯 世 界 内 出 局 ， 为 蒸 蒸 日 上 的 中 国 让 路 的 时 代 背 景 下 。 本 就 主 张 同 科 学 社 会 主 义 泾 渭 分 明 ， 走 阿 拉 伯 民 族 独 立 发 展 道 路 的 “ 卡 里 斯 玛 ” 们 。 又 会 心 安 理 得 地 接 受 这 样 的 新 秩 序 ， 老 老 实 实 地 扮 演 起 东 方 神 秘 力 量 制 衡 中 东 局 势 的 棋 子 吗 ？|考 虑 到 新 政 权 草 创 初 百 废 待 兴 ， 且 成 员 国 们 的 天 才 领 袖 们 均 各 有 心 思 ， 难 以 接 受 全 新 的 游 戏 规 则 ， 乃 至 各 地 阿 拉 伯 民 族 主 义 者 多 依 托 当 地 部 族 与 军 事 集 团 存 在 的 组 织 形 式 。 这 一 切 都 使 得 有 着 从 西 非 横 贯 波 斯 湾 庞 大 体 量 的 大 国 不 得 不 老 老 实 实 地 接 受 漫 长 的 磨 合 期 ， 并 维 持 与 中 华 人 民 共 和 国 间 的 蜜 月 关 系 。 不 过 ， 明 眼 人 都 能 看 出 二 者 间 是 同 床 异 梦 ： 阿 拉 伯 诸 国 在 中 国 要 求 扩 大 人 民 阵 线 政 府 ， 深 化 与 共 产 党 合 作 的 问 题 上 态 度 消 极 ； 而 中 国 也 对 撒 哈 拉 地 区 的 疑 似 核 试 验 望 尘 莫 及 。 更 不 必 谈 阿 拉 伯 内 部 本 身 的 意 识 形 态 撕 裂 ： 复 兴 主 义 者 的 左 右 翼 亟 待 统 一 ， 利 比 亚 与 埃 及 争 夺 对 纳 赛 尔 的 独 家 解 释 权 ， 乃 至 基 于 家 族 政 治 与 裙 带 关 系 生 成 的 各 种 异 端 思 想 为 争 权 而 粉 墨 登 场 … …|可 出 于 防 范 类 似 萨 达 特 的 “ 纠 正 革 命 ” 分 子 、 伊 斯 兰 主 义 者 与 美 苏 干 预 势 力 回 归 并 掀 翻 当 地 格 局 的 需 要 ， 中 国 也 绝 不 能 简 单 地 同 阿 拉 伯 诸 国 决 裂 ： 它 也 只 得 在 改 组 联 邦 的 同 时 ， 期 盼 在 当 地 引 入 社 会 主 义 者 占 优 势 的 文 官 政 府 形 式 。 两 者 间 的 关 系 不 由 得 使 人 联 想 到 2 0 年 代 的 中 国 国 民 党 与 共 产 国 际 … … 未 来 会 如 何 ？ 只 有 当 阿 拉 伯 联 合 共 和 国 真 正 成 为 举 足 轻 重 的 世 界 大 国 时 才 能 得 到 答 案 。 不 过 ， 倘 若 局 势 仍 未 发 生 根 本 改 观 。 中 国 共 产 主 义 者 大 概 率 将 又 一 次 搬 起 石 头 砸 自 己 的 脚 … …";
		}
		else if (GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[14].oar && GlobalScript.inst.gameState.allcountries[35].oar && GlobalScript.inst.gameState.allcountries[13].oar)
		{
			text += " <size=40>纳 赛 尔 的 遗 产</size>|";
			text += "基 于 阿 拉 伯 社 会 主 义 的 原 则 ， 对 此 期 待 以 久 的 阿 拉 伯 主 要 国 家 终 于 实 现 了 统 一 为 一 个 完 整 的 阿 拉 伯 联 合 共 和 国 的 梦 想 。 把 制 度 相 似 的 国 家 统 一 起 来 并 不 难 ， 虽 然 中 央 集 权 支 持 者 和 地 方 精 英 之 间 的 斗 争 正 在 削 弱 国 家 的 稳 定 ， 但 仍 然 可 以 求 同 存 异 。 通 过 多 个 国 家 的 经 济 一 体 化 ， 并 建 立 一 个 统 一 的 军 队 ， 阿 拉 伯 联 合 共 和 国 成 为 中 东 地 区 最 强 大 的 国 家 ， 也 成 为 国 际 社 会 的 强 大 成 员 。 阿 拉 伯 联 合 共 和 国 试 图 维 持 与 社 会 主 义 国 家 的 友 谊 ， 但 它 日 益 增 长 的 胃 口 破 坏 了 该 地 区 本 来 就 很 脆 弱 的 和 平 。 以 色 列 加 强 了 边 境 防 御 ， 一 些 人 说 阿 拉 伯 联 合 共 和 国 即 将 入 侵 沙 特 阿 拉 伯 和 苏 丹 。";
		}
		else if (GlobalScript.inst.gameState.OAR)
		{
			text += " <size=40>了 犹 未 了 ， 终 以 不 了 了 之</size>|";
			text += "对 许 多 问 题 的 分 歧 淡 化 了 建 立 阿 拉 伯 联 合 国 家 的 最 初 的 喜 悦 — — 并 不 是 所 有 的 阿 拉 伯 国 家 都 加 入 了 阿 拉 伯 联 合 共 和 国 ， 而 且 那 些 加 入 的 国 家 开 始 在 这 个 新 国 家 里 争 权 夺 利 。 中 央 集 权 支 持 者 和 地 方 精 英 之 间 的 斗 争 导 致 了 许 多 自 治 法 方 案 和 特 殊 情 况 法 的 出 现 ， 而 这 些 法 律 并 没 有 帮 助 国 家 治 理 效 率 得 以 提 高 。 阿 拉 伯 联 合 共 和 国 继 续 存 在 着 ， 但 其 成 员 国 的 政 策 越 来 越 独 立 ， 统 一 也 越 来 越 形 式 化 。";
		}
		else if (GlobalScript.inst.gameState.data[85] == 2)
		{
			text += " <size=40>大 梦 一 场</size>|";
			text += "阿 拉 伯 国 家 继 续 分 散 ， 统 一 的 计 划 被 遗 忘";
		}
		else
		{
			text += " <size=40>阿 拉 伯 没 什 么 新 闻</size>|";
			text += "阿 拉 伯 地 区 一 切 照 常 。 ";
		}
	}
}
