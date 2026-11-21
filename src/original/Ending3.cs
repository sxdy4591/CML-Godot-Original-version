using EndingsDLCDraft;
using UnityEngine;

public class Ending3 : EndingsSecond
{
	public override void TextOfEnding(ref string name, ref string text)
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		name = "非 洲 之 角";
		text = "";
		if (GlobalScript.inst.gameState.allcountries[41].parts[0] && GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1)
		{
			text += " <size=40>团 结 一 致 到 永 远</size>|";
			text += " 非 洲 之 角 联 邦 赫 然 成 为 了 非 洲 的 马 克 思 列 宁 主 义 标 杆 ， 在 扫 清 了 一 切 反 革 命 势 力 后 ， 依 照 中 国 、 阿 尔 巴 尼 亚 、 坦 桑 尼 亚 等 国 的 经 验 ， 联 邦 进 行 了 浩 浩 荡 荡 的 社 会 主 义 改 革 ， 乌 贾 马 式 的 人 民 公 社 在 该 国 建 立 ， 工 业 化 稳 步 推 进 ， 土 地 被 根 据 耕 者 有 其 田 原 则 重 新 分 配 ， 义 务 教 育 也 在 全 国 普 及 ， 社 会 主 义 新 观 念 的 输 入 与 经 济 基 础 的 改 变 使 该 国 破 除 了 困 扰 绝 大 多 数 非 洲 新 生 国 家 的 部 族 主 义 顽 疾 。";
			if ((GlobalScript.inst.gameState.allcountries[106].SubGosstroy == 15 || GlobalScript.inst.gameState.allcountries[106].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[106].SubGosstroy == 0) && GlobalScript.inst.gameState.allcountries[106].proprc)
			{
				text += "在 见 证 了 联 邦 所 创 造 的 奇 迹 后 ， 吉 布 提 也 选 择 了 加 入 埃 索 联 邦 ， 非 洲 一 体 化 的 又 一 块 拼 图 得 以 落 下 。";
			}
			else if (GlobalScript.inst.gameState.allcountries[106].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[106].proprc)
			{
				text += "美 中 不 足 的 是 ， 吉 布 提 拒 绝 了 来 自 非 洲 之 角 联 邦 的 邀 请 ， 但 依 然 与 联 邦 展 开 了 密 切 合 作 。";
			}
			else
			{
				text += "由 于 意 识 形 态 的 隔 阂 ， 吉 布 提 拒 绝 了 非 洲 之 角 联 邦 所 抛 过 来 的 橄 榄 枝 ， 不 过 在 如 此 巨 大 的 诱 惑 面 前 ， 他 们 又 能 拖 到 什 么 时 候 呢 … …";
			}
			text += " | 在 同 一 面 红 旗 之 下 ， 埃 塞 俄 比 亚 与 索 马 里 人 民 的 阶 级 情 谊 战 胜 了 过 去 统 治 阶 级 为 各 自 争 权 夺 利 所 制 造 的 仇 恨 ， 两 地 人 民 将 手 连 手 心 连 心 ， 不 论 民 族 、 部 族 、 语 言 、 宗 教 信 仰 等 身 份 的 不 同 ， 携 手 并 进 。 我 们 坚 信 ， 非 洲 之 角 的 未 来 定 是 光 辉 的 。";
			text += "||";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].parts[1] && GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1)
		{
			text += " <size=40>团 结 一 致 到 永 远</size>|";
			text += " 非 洲 之 角 联 邦 赫 然 成 为 了 非 洲 的 马 克 思 列 宁 主 义 标 杆 ， 在 扫 清 了 一 切 反 革 命 势 力 后 ， 依 照 中 国 、 阿 尔 巴 尼 亚 、 坦 桑 尼 亚 等 国 的 经 验 ， 联 邦 进 行 了 浩 浩 荡 荡 的 社 会 主 义 改 革 ， 乌 贾 马 式 的 人 民 公 社 在 该 国 建 立 ， 工 业 化 稳 步 推 进 ， 土 地 被 根 据 耕 者 有 其 田 原 则 重 新 分 配 ， 义 务 教 育 也 在 全 国 普 及 ， 社 会 主 义 新 观 念 的 输 入 与 经 济 基 础 的 改 变 使 该 国 破 除 了 困 扰 绝 大 多 数 非 洲 新 生 国 家 的 部 族 主 义 顽 疾 。在 见 证 了 联 邦 所 创 造 的 奇 迹 后 ， 吉 布 提 也 选 择 了 加 入 埃 索 联 邦 ， 非 洲 一 体 化 的 又 一 块 拼 图 得 以 落 下 。 | 在 同 一 面 红 旗 之 下 ， 埃 塞 俄 比 亚 与 索 马 里 人 民 的 阶 级 情 谊 战 胜 了 过 去 统 治 阶 级 为 各 自 争 权 夺 利 所 制 造 的 仇 恨 ， 两 地 人 民 将 手 连 手 心 连 心 ， 不 论 民 族 、 部 族 、 语 言 、 宗 教 信 仰 等 身 份 的 不 同 ， 携 手 并 进 。 我 们 坚 信 ， 非 洲 之 角 的 未 来 定 是 光 辉 的 。";
			text += "||";
		}
		if ((!GlobalScript.inst.gameState.allcountries[41].parts[1] && !GlobalScript.inst.gameState.allcountries[41].parts[0]) || !GlobalScript.inst.gameState.IsAuthoritarianism(41))
		{
			text += "<color=#8B2323><size=54>埃 塞 俄 比 亚</size></color>|";
		}
		if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 19 && (GlobalScript.inst.gameState.allcountries[41].parts[1] || GlobalScript.inst.gameState.allcountries[41].parts[0]))
		{
			text += "<color=#8B2323><size=54>东 非 的 金 世 天 才</size></color>|";
			text += " <size=40>黎 笋 第 二</size>|";
			text += " 在 国 内 ， 对 索 马 里 的 完 全 胜 利 让 门 格 斯 图 成 为 几 乎 是 孟 利 尼 克 二 世 ， 海 尔 塞 拉 西 一 般 伟 大 的 领 袖 人 物 ， 他 们 都 是 在 击 溃 了 帝 国 主 义 者 后 ， 为 自 己 的 祖 国 开 疆 扩 土 的 伟 大 人 物 。 他 的 政 权 空 前 团 结 ， 这 算 个 好 事 ， 对 吧 ？||在 门 格 斯 图 彻 底 击 溃 各 个 反 对 派 势 力 ： 从 左 到 右 ， 从 埃 塞 到 索 马 里 之 后 ， 他 彻 底 成 为 了 埃 塞 俄 比 亚 的 尼 格 斯 。 该 国 大 力 审 查 一 切 马 克 思 列 宁 和 毛 泽 东 的 书 籍 ， 唯 有 党 校 工 作 者 和 专 职 研 究 马 克 思 哲 学 的 “ 贤 人 ” 们 得 以 阅 读 其 原 版 ， 并 把 它 们 翻 译 成 阿 姆 哈 拉 语 。 原 先 的 马 克 思 主 义 画 皮 正 在 慢 慢 的 被 “ 门 格 斯 图 大 元 帅 新 时 代 埃 塞 俄 比 亚 特 色 社 会 主 义 ” 所 取 代 ， 这 是 个 强 调 非 洲 民 族 主 义 ， 人 民 的 主 观 能 动 性 以 及 海 尔 · 马 里 亚 姆 家 族 的 革 命 血 脉 正 当 性 的 奇 怪 产 物 。 新 政 府 设 法 修 复 了 几 近 崩 溃 的 农 业 ， 同 时 发 展 了 自 给 自 足 的 工 业 。 欧 加 登 的 石 油 也 让 该 国 得 以 在 脱 离 国 际 社 会 的 前 提 下 而 不 至 于 崩 溃 。 足 够 高 的 福 利 保 证 了 无 人 不 满 ， 当 然 这 也 是 无 孔 不 入 的 密 探 网 络 的 功 劳 。 为 了 保 卫 祖 国 不 会 惨 遭 帝 国 主 义 者 的 魔 爪 ， 埃 塞 俄 比 亚 革 命 武 装 力 量 的 权 利 空 前 膨 胀 ， 他 们 已 然 成 为 了 新 的 军 事 贵 族 ， 大 量 的 经 费 也 被 用 来 研 发 新 型 武 器 ， 其 中 包 括 研 究 核 武 器 和 弹 道 导 弹 。|在 门 格 斯 图 突 发 心 脏 病 去 世 后 ， 埃 塞 俄 比 亚 陷 入 了 绝 望 之 中 。 成 千 上 万 的 埃 塞 俄 比 亚 工 人 ， 农 会 成 员 ， 士 兵 和 各 国 政 要 前 来 送 别 这 位 统 治 了 埃 塞 俄 比 亚 数 十 年 的 领 袖 。 不 少 人 泣 不 成 声 ， 就 连 许 多 流 亡 在 海 外 的 保 皇 派 也 派 出 了 一 个 小 小 的 代 表 团 参 加 葬 礼 。 更 有 甚 者 抱 怨 道 “ 要 是 他 不 是 个 赤 党 该 多 好 ！ ” 。 哀 悼 期 间 ， 全 国 共 有 近 3 0 0 0 万 人 到 亚 的 斯 亚 贝 巴 吊 唁 他 ， 占 该 国 接 近 一 半 的 人 口 ； 在 全 国 各 地 追 悼 场 地 哀 悼 达 1 0 亿 人 次 。 民 众 又 为 他 制 作 花 圈 ， 令 亚 市 的 鲜 花 一 度 全 部 售 罄 ， 野 花 也 被 采 光 ， 当 局 只 好 从 昆 明 空 运 五 十 万 束 鲜 花 回 国 。 科 普 特 正 教 会 预 备 把 他 追 封 为 圣 人 ， 并 把 埃 塞 的 崛 起 和 击 败 异 教 敌 人 视 作 其 显 圣 的 标 记 。|提 格 拉 钦 纪 念 碑 ， 这 一 原 本 用 来 纪 念 埃 塞 战 胜 索 马 里 的 战 争 纪 念 碑 也 被 扩 大 ， 其 中 包 括 了 一 尊 3 0 米 高 的 门 格 斯 图 铜 像 ， 接 近 7 0 米 的 胜 利 塔 和 大 量 的 描 绘 战 争 与 社 会 主 义 建 设 的 浮 雕 ， 其 中 必 然 少 不 了 革 命 之 父 门 格 斯 图 本 人 出 场 。 他 本 人 的 尸 体 也 被 保 存 起 来 ， 这 将 作 为 永 恒 革 命 的 象 征 成 为 每 个 学 生 都 必 去 的 爱 国 主 义 教 育 基 地 。 在 简 短 的 就 职 典 礼 后 ， 蒂 格 斯 特 · 海 尔 · 马 里 亚 姆 宣 布 接 过 她 父 亲 所 高 高 竖 起 的 胜 利 红 旗 。 她 的 母 亲 将 辅 佐 这 位 政 坛 弄 潮 儿 ， 妥 善 的 把 航 船 带 出 未 知 的 深 水 区 。 埃 塞 俄 比 亚 就 这 样 ， 再 度 被 红 色 的 太 阳 所 笼 罩 。 ";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 19)
		{
			text += " <size=40>黎 笋 第 二</size>|";
			text += "在 门 格 斯 图 彻 底 击 溃 各 个 反 对 派 势 力 ： 从 左 到 右 ， 从 埃 塞 到 索 马 里 之 后 ， 他 彻 底 成 为 了 埃 塞 俄 比 亚 的 尼 格 斯 。 该 国 大 力 审 查 一 切 马 克 思 列 宁 和 毛 泽 东 的 书 籍 ， 唯 有 党 校 工 作 者 和 专 职 研 究 马 克 思 哲 学 的 “ 贤 人 ” 们 得 以 阅 读 其 原 版 ， 并 把 它 们 翻 译 成 阿 姆 哈 拉 语 。 原 先 的 马 克 思 主 义 画 皮 正 在 慢 慢 的 被 “ 门 格 斯 图 大 元 帅 新 时 代 埃 塞 俄 比 亚 特 色 社 会 主 义 ” 所 取 代 ， 这 是 个 强 调 非 洲 民 族 主 义 ， 人 民 的 主 观 能 动 性 以 及 海 尔 · 马 里 亚 姆 家 族 的 革 命 血 脉 正 当 性 的 奇 怪 产 物 。 新 政 府 设 法 修 复 了 几 近 崩 溃 的 农 业 ， 同 时 发 展 了 自 给 自 足 的 工 业 。 欧 加 登 的 石 油 也 让 该 国 得 以 在 脱 离 国 际 社 会 的 前 提 下 而 不 至 于 崩 溃 。 足 够 高 的 福 利 保 证 了 无 人 不 满 ， 当 然 这 也 是 无 孔 不 入 的 密 探 网 络 的 功 劳 。 为 了 保 卫 祖 国 不 会 惨 遭 帝 国 主 义 者 的 魔 爪 ， 埃 塞 俄 比 亚 革 命 武 装 力 量 的 权 利 空 前 膨 胀 ， 他 们 已 然 成 为 了 新 的 军 事 贵 族 ， 大 量 的 经 费 也 被 用 来 研 发 新 型 武 器 ， 其 中 包 括 研 究 核 武 器 和 弹 道 导 弹 。|在 门 格 斯 图 突 发 心 脏 病 去 世 后 ， 埃 塞 俄 比 亚 陷 入 了 绝 望 之 中 。 成 千 上 万 的 埃 塞 俄 比 亚 工 人 ， 农 会 成 员 ， 士 兵 和 各 国 政 要 前 来 送 别 这 位 统 治 了 埃 塞 俄 比 亚 数 十 年 的 领 袖 。 不 少 人 泣 不 成 声 ， 就 连 许 多 流 亡 在 海 外 的 保 皇 派 也 派 出 了 一 个 小 小 的 代 表 团 参 加 葬 礼 。 更 有 甚 者 抱 怨 道 “ 要 是 他 不 是 个 赤 党 该 多 好 ！ ” 。 哀 悼 期 间 ， 全 国 共 有 近 3 0 0 0 万 人 到 亚 的 斯 亚 贝 巴 吊 唁 他 ， 占 该 国 接 近 一 半 的 人 口 ； 在 全 国 各 地 追 悼 场 地 哀 悼 达 1 0 亿 人 次 。 民 众 又 为 他 制 作 花 圈 ， 令 亚 市 的 鲜 花 一 度 全 部 售 罄 ， 野 花 也 被 采 光 ， 当 局 只 好 从 昆 明 空 运 五 十 万 束 鲜 花 回 国 。 科 普 特 正 教 会 预 备 把 他 追 封 为 圣 人 ， 并 把 埃 塞 的 崛 起 和 击 败 异 教 敌 人 视 作 其 显 圣 的 标 记 。|提 格 拉 钦 纪 念 碑 ， 这 一 原 本 用 来 纪 念 埃 塞 战 胜 索 马 里 的 战 争 纪 念 碑 也 被 扩 大 ， 其 中 包 括 了 一 尊 3 0 米 高 的 门 格 斯 图 铜 像 ， 接 近 7 0 米 的 胜 利 塔 和 大 量 的 描 绘 战 争 与 社 会 主 义 建 设 的 浮 雕 ， 其 中 必 然 少 不 了 革 命 之 父 门 格 斯 图 本 人 出 场 。 他 本 人 的 尸 体 也 被 保 存 起 来 ， 这 将 作 为 永 恒 革 命 的 象 征 成 为 每 个 学 生 都 必 去 的 爱 国 主 义 教 育 基 地 。 在 简 短 的 就 职 典 礼 后 ， 蒂 格 斯 特 · 海 尔 · 马 里 亚 姆 宣 布 接 过 她 父 亲 所 高 高 竖 起 的 胜 利 红 旗 。 她 的 母 亲 将 辅 佐 这 位 政 坛 弄 潮 儿 ， 妥 善 的 把 航 船 带 出 未 知 的 深 水 区 。 埃 塞 俄 比 亚 就 这 样 ， 再 度 被 红 色 的 太 阳 所 笼 罩 。 ";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].parts[0])
		{
			if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[41].prosov)
			{
				text += " <size=40>在 十 字 路 口 上</size>|";
				text += " 在 1 9 8 2 年 建 立 的 埃 塞 - 索 马 里 联 邦 在 摇 摇 欲 坠 中 走 向 了 未 知 的 未 来 。 尽 管 武 装 部 队 能 够 保 证 城 市 ， 谁 能 夺 取 农 村 呢 ？ 索 马 里 终 究 变 成 了 埃 塞 的 累 赘 ， 长 期 的 维 稳 支 出 正 在 压 垮 这 个 国 家 。 而 原 先 合 并 的 新 鲜 劲 正 在 被 民 族 矛 盾 与 仇 恨 所 取 代 。 只 有 首 都 和 马 萨 瓦 等 苏 军 驻 地 仍 然 在 政 府 的 手 掌 中 。 苏 联 军 官 和 古 巴 人 是 门 格 斯 图 最 后 的 屏 障 。 游 击 队 屡 次 冲 击 各 大 城 市 ， 政 令 已 经 难 出 亚 的 斯 亚 贝 巴 ， 这 个 国 家 已 然 成 为 了 又 一 个 阿 富 汗 。 只 有 完 全 依 赖 于 各 个 友 好 的 社 会 主 义 国 家 ， 这 个 多 灾 多 难 的 国 家 才 能 幸 存 。|迟 早 有 一 天 ， 大 灾 难 还 会 再 来 一 次 。 但 到 那 时 ， 可 能 没 人 会 来 帮 助 亚 的 斯 亚 贝 巴 的 尼 格 斯 了 … … ";
			}
			else if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[41].proprc)
			{
				text += " <size=40>在 十 字 路 口 上</size>|";
				text += " 在 1 9 8 2 年 建 立 的 埃 塞 - 索 马 里 联 邦 在 摇 摇 欲 坠 中 走 向 了 未 知 的 未 来 。 尽 管 武 装 部 队 能 够 保 证 城 市 ， 谁 能 夺 取 农 村 呢 ？ 索 马 里 终 究 变 成 了 埃 塞 的 累 赘 ， 长 期 的 维 稳 支 出 正 在 压 垮 这 个 国 家 。 而 原 先 合 并 的 新 鲜 劲 正 在 被 民 族 矛 盾 与 仇 恨 所 取 代 。 但 在 我 们 的 帮 助 下 ， 埃 塞 俄 比 亚 人 得 以 渡 过 最 困 难 的 时 候 。 在 武 装 部 队 的 暴 力 驱 逐 下 ， 大 量 的 索 马 里 人 流 离 失 所 ， 或 者 被 迫 接 纳 新 的 “ 沙 漠 埃 塞 俄 比 亚 人 ” 身 份 ， 而 索 马 里 语 也 在 慢 慢 的 被 英 语 和 奥 莫 罗 语 所 取 代 。 由 于 武 装 部 队 牢 牢 掌 握 了 肥 沃 的 土 地 ， 游 击 战 士 濒 临 绝 望 ， 当 他 们 向 安 全 部 队 投 降 时 ， 迎 接 他 们 的 只 有 枪 口 。 那 些 没 有 被 安 全 部 队 直 接 处 决 的 人 被 送 到 事 先 准 备 好 的 “ 诊 疗 所 ” 。 这 些 营 地 靠 近 当 地 军 事 基 地 ， 埃 塞 俄 比 亚 军 队 在 那 里 “ 筛 选 ” 民 众 ， 以 挑 出 潜 在 的 敌 对 人 员 ， 通 常 是 在 索 马 里 变 节 者 的 帮 助 下 。 在 这 些 过 境 营 地 ， 投 降 的 平 民 被 登 记 并 接 受 审 讯 。 那 些 被 怀 疑 是 抵 抗 运 动 成 员 的 人 被 拘 留 和 杀 害 。 人 造 饥 荒 ， 轰 炸 ， 扫 荡 和 种 族 清 洗 让 接 近 2 0 0 万 索 马 里 人 非 正 常 死 亡 。 这 给 门 格 斯 图 的 履 历 添 上 了 浓 墨 重 彩 的 一 笔 ， 国 际 社 会 强 烈 谴 责 该 政 权 ， 称 在 索 马 里 的 灾 难 是 “ 令 人 发 指 的 暴 行 ” ， 但 这 些 帝 国 主 义 者 为 什 么 总 当 事 后 诸 葛 呢 ？|但 在 国 内 ， 这 场 胜 利 也 让 门 格 斯 图 成 为 几 乎 是 孟 利 尼 克 二 世 ， 海 尔 塞 拉 西 一 般 伟 大 的 领 袖 人 物 ， 他 们 都 是 在 击 溃 了 帝 国 主 义 者 后 ， 为 自 己 的 祖 国 开 疆 扩 土 的 伟 大 人 物 。 他 的 政 权 空 前 团 结 ， 这 算 个 好 事 ， 对 吧 ？";
			}
			else if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 17)
			{
				text += " <size=40>站 起 身 向 前 进</size>|";
				text += " 埃 塞 俄 比 亚 社 会 主 义 革 命 党 - 马 克 思 列 宁 主 义 在 扫 清 了 右 派 和 一 切 反 革 命 势 力 后 ， 开 展 了 浩 浩 荡 荡 的 社 会 主 义 改 革 。 类 似 乌 贾 马 村 的 人 民 公 社 被 建 立 起 来 ， 土 地 也 得 到 了 彻 底 的 分 配 ， 国 家 建 立 了 强 力 的 中 央 计 划 经 济 。 工 业 也 在 中 国 的 支 援 下 稳 步 的 发 展 起 来 。 各 民 族 都 平 等 的 埃 塞 俄 比 亚 社 会 主 义 联 邦 共 和 国 已 经 实 现 了 ， 这 个 国 家 也 得 以 像 过 去 一 样 ， 高 高 的 举 起 泛 非 主 义 和 社 会 主 义 的 大 旗 。 带 领 非 洲 人 民 走 向 一 个 又 一 个 胜 利 。";
			}
		}
		else if (GlobalScript.inst.gameState.allcountries[41].prosov && (GlobalScript.inst.gameState.empires[1].now_leader == 8 || GlobalScript.inst.gameState.empires[1].now_leader == 4 || GlobalScript.inst.gameState.empires[1].now_leader == 5) && GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 10)
		{
			text += " <size=40>门 格 斯 图 儿 子 ， 和 他 的 苏 联 爸 爸 们</size>|";
			text += " 埃 塞 俄 比 亚 没 有 发 生 什 么 大 事 ， 这 个 国 家 和 过 去 一 般 糟 糕 。 门 格 斯 图 政 权 继 续 陷 入 和 游 击 队 旷 日 持 久 的 战 争 ， 苏 联 和 古 巴 军 队 继 续 在 这 里 驻 扎 。 这 个 国 家 继 续 扮 演 着 苏 联 在 红 海 的 前 哨 ， 作 为 苏 联 遏 制 中 东 和 东 非 的 楔 子 存 在 。";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].prosov && (GlobalScript.inst.gameState.empires[1].now_leader == 6 || GlobalScript.inst.gameState.empires[1].now_leader == 7) && GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 10)
		{
			text += " <size=40>门 格 斯 图 儿 子 ， 和 他 死 去 的 苏 联 爸 爸</size>|";
			text += " 在 旷 日 持 久 的 战 争 中 ， 埃 塞 俄 比 亚 越 发 倒 向 苏 联 。 可 是 随 着 苏 联 的 改 革 者 上 台 ， 苏 联 援 助 日 益 减 少 。 最 终 在 克 里 姆 林 的 背 叛 下 ， 埃 塞 俄 比 亚 人 民 对 “ 黑 列 宁 ” 的 忍 受 到 了 极 点 。 革 阵 叫 ， 贝 巴 举 ， 提 人 一 炬 ， 可 怜 焦 土 ！";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].prosov && GlobalScript.inst.gameState.empires[1].now_leader == 3 && GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 10)
		{
			text += " <size=40>门 格 斯 图 儿 子 ， 和 他 的 苏 联 爸 爸</size>|";
			text += " 苏 联 并 没 有 忘 记 远 在 东 非 的 埃 塞 俄 比 亚 ， 在 1 9 8 6 年 ， 该 国 加 入 了 经 济 互 助 委 员 会 。 埃 塞 的 情 况 或 多 或 少 稳 定 下 来 了 。 小 规 模 的 市 场 化 改 革 也 开 始 施 行 。 埃 塞 俄 比 亚 人 民 民 主 共 和 国 成 为 了 这 个 非 洲 大 陆 上 苏 联 最 重 要 的 盟 友 ， 许 多 反 对 派 指 责 门 格 斯 图 事 实 上 把 埃 塞 俄 比 亚 变 成 了 苏 联 的 军 事 基 地 和 咖 啡 农 村 ， 但 只 要 苏 联 不 倒 ， 门 格 斯 图 的 政 权 会 屹 立 在 在 这 里 ， 直 到 永 远 。 ";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].proprc && GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 10)
		{
			text += " <size=40>见 风 使 舵</size>|";
			text += " 在 预 见 到 中 国 的 崛 起 后 ， 门 格 斯 图 丝 滑 的 抛 弃 了 苏 维 埃 ， 转 而 投 向 了 北 京 。 北 京 的 资 源 如 潮 水 般 投 向 埃 塞 俄 比 亚 。 埃 塞 俄 比 亚 的 经 济 或 多 或 少 稳 定 了 。 埃 塞 俄 比 亚 的 工 业 化 也 在 中 国 的 支 持 下 缓 缓 的 进 行 着 。 凡 事 皆 有 代 价 ， 我 们 也 不 得 不 为 军 政 府 的 侵 犯 人 权 背 黑 锅 。 苏 联 对 我 们 直 接 挑 战 其 霸 权 的 行 为 恼 羞 成 怒 ， 但 时 间 会 证 明 一 切 。";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 17)
		{
			text += " <size=40>站 起 身 向 前 进</size>|";
			text += " 埃 塞 俄 比 亚 社 会 主 义 革 命 党 - 马 克 思 列 宁 主 义 在 扫 清 了 右 派 和 一 切 反 革 命 势 力 后 ， 开 展 了 浩 浩 荡 荡 的 社 会 主 义 改 革 。 类 似 乌 贾 马 村 的 人 民 公 社 被 建 立 起 来 ， 土 地 也 得 到 了 彻 底 的 分 配 ， 国 家 建 立 了 强 力 的 中 央 计 划 经 济 。 工 业 也 在 中 国 的 支 援 下 稳 步 的 发 展 起 来 。 各 民 族 都 平 等 的 埃 塞 俄 比 亚 社 会 主 义 联 邦 共 和 国 已 经 实 现 了 ， 这 个 国 家 也 得 以 像 过 去 一 样 ， 高 高 的 举 起 泛 非 主 义 和 社 会 主 义 的 大 旗 。 带 领 非 洲 人 民 走 向 一 个 又 一 个 胜 利 。";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 3)
		{
			text += " <size=40>在 十 字 路 口 上</size>|";
			text += " 在 中 国 的 支 持 下 ， 埃 塞 俄 比 亚 人 民 革 命 民 主 阵 线 推 翻 了 腐 朽 的 门 格 斯 图 政 权 。 但 就 国 家 的 未 来 上 ， 各 方 的 意 见 久 久 不 能 达 成 一 致 。 一 场 新 的 内 战 正 在 爆 发 的 边 缘 … …";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 2)
		{
			text += " <size=40>站 起 身 向 前 进</size>|";
			text += " 在 中 国 的 支 持 下 ， 埃 塞 俄 比 亚 人 民 革 命 民 主 阵 线 推 翻 了 腐 朽 的 门 格 斯 图 政 权 。 埃 塞 俄 比 亚 人 民 革 命 党 在 扫 清 了 右 派 和 一 切 反 革 命 势 力 后 ， 开 展 了 浩 浩 荡 荡 的 社 会 主 义 改 革 。 类 似 乌 贾 马 村 的 人 民 公 社 被 建 立 起 来 ， 土 地 也 得 到 了 彻 底 的 分 配 ， 国 家 建 立 了 强 力 的 中 央 计 划 经 济 。 工 业 也 在 中 国 的 支 援 下 稳 步 的 发 展 起 来 。 同 时 一 场 针 对 前 独 裁 政 权 的 受 害 者 的 平 反 工 作 也 开 始 执 行 。";
		}
		else if (GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 6)
		{
			text += " <size=40>日 夜 兼 程 ， 跑 步 进 入 自 由 主 义</size>|";
			text += " 在 中 国 的 支 持 下 ， 埃 塞 俄 比 亚 人 民 革 命 民 主 阵 线 推 翻 了 腐 朽 的 门 格 斯 图 政 权 。 埃 塞 俄 比 亚 民 主 联 盟 在 扫 清 了 左 派 和 前 政 府 官 员 后 ， 开 展 了 浩 浩 荡 荡 的 自 由 主 义 与 市 场 化 改 革 。 国 家 大 力 推 行 自 由 化 政 策 ， 中 国 企 业 无 时 无 刻 不 在 挤 压 这 个 国 家 。 咖 啡 农 场 又 一 次 开 张 ， 新 生 的 国 度 的 领 导 人 满 足 于 人 民 币 ， 美 元 和 卢 布 。 这 近 一 步 招 致 了 底 层 人 的 不 满 。 同 时 一 场 针 对 前 独 裁 政 权 的 受 害 者 的 平 反 工 作 也 开 始 执 行 。 但 在 最 近 的 工 人 罢 工 上 ， 他 们 竟 然 打 出 了 门 格 斯 图 的 牌 号 。 这 个 世 界 到 底 怎 么 了 ？";
		}
		else
		{
			text += " 埃 塞 俄 比 亚 的 情 况 有 些 奇 怪 ， 似 乎 有 一 股 未 知 的 力 量 让 其 偏 离 了 轨 迹 … …";
		}
		if ((!GlobalScript.inst.gameState.allcountries[41].parts[1] && !GlobalScript.inst.gameState.allcountries[41].parts[0]) || !GlobalScript.inst.gameState.IsAuthoritarianism(41))
		{
			if (GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.allcountries[99].puppetOf == 85)
			{
				text += "|| 在 意 大 利 援 助 的 影 响 下 ， 厄 立 特 里 亚 逐 渐 开 始 在 经 济 上 同 意 大 利 融 合 ， 并 成 为 一 个 统 一 整 体 。 双 边 的 关 税 壁 垒 被 废 除 ， 并 建 立 了 统 一 的 海 关 、 劳 工 、 与 其 他 经 济 事 宜 的 管 理 法 则 。 最 终 ， 意 大 利 与 厄 立 特 里 亚 建 立 了 一 个 受 统 一 法 律 规 章 管 制 的 单 一 市 场 。 在 此 背 景 下 ， 不 计 其 数 的 意 大 利 移 民 社 区 、 教 育 机 构 与 企 业 分 部 如 雨 后 春 笋 般 涌 现 。 然 而 ， 厄 立 特 里 亚 仍 保 留 了 一 个 形 式 上 独 立 的 政 府 与 独 立 公 民 身 份 。 前 者 是 出 于 安 抚 当 地 民 众 的 需 要 ， 后 者 则 是 防 止 异 族 通 婚 繁 衍 的 必 要 。 此 外 ， 意 大 利 就 对 付 外 族 通 婚 问 题 ， 出 台 了 一 项 有 关 公 民 身 份 的 修 正 案 ： 如 果 与 不 具 有 意 大 利 公 民 身 份 者 生 育 后 代 ， 其 公 民 身 份 可 能 被 撤 销 。 最 终 ， 厄 立 特 里 亚 本 身 成 为 了 “ 非 洲 小 罗 马 ” ： 在 市 场 、 建 筑 风 格 和 文 化 领 域 上 均 化 身 成 为 意 大 利 的 翻 版 ， 巩 固 了 其 作 为 意 大 利 附 庸 国 的 地 位 。";
				gameObject.GetComponent<achievements>().Set(159);
			}
			else if (GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.allcountries[99].puppetOf < 0 && GlobalScript.inst.gameState.resultOfEvents[403] == 1)
			{
				text += "|| 厄 立 特 里 亚 挣 脱 了 名 为 埃 塞 俄 比 亚 的 枷 锁 ， 取 得 了 独 立 。 厄 人 阵 迅 速 倒 向 中 国 。 在 我 们 的 帮 助 下 ， 厄 立 特 里 亚 摆 脱 了 贫 困 的 帽 子 。 我 们 坚 信 ， 厄 立 特 里 亚 的 未 来 会 更 好 。";
			}
			else if (GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.allcountries[99].puppetOf < 0 && (GlobalScript.inst.gameState.resultOfEvents[475] == 1 || GlobalScript.inst.gameState.resultOfEvents[475] == 2))
			{
				text += "|| 厄 立 特 里 亚 在 埃 塞 俄 比 亚 的 理 解 下 取 得 了 独 立 。 而 厄 人 阵 继 续 支 持 中 国 。 在 我 们 的 帮 助 下 ， 厄 立 特 里 亚 摆 脱 了 贫 困 的 帽 子 。 我 们 坚 信 ， 厄 立 特 里 亚 的 未 来 定 是 光 辉 的 。";
			}
			else if ((!GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.event_done[403] && GlobalScript.inst.gameState.resultOfEvents[403] == 0 && GlobalScript.inst.gameState.event_done[475] && GlobalScript.inst.gameState.resultOfEvents[475] == 0) || (!GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 17))
			{
				text += "|| 在 埃 塞 俄 比 亚 人 和 厄 人 阵 的 互 相 谅 解 下 ， 双 方 就 组 建 民 主 联 邦 达 成 了 协 定 ， 埃 塞 俄 比 亚 的 经 济 因 此 得 到 了 发 展 ， 而 厄 立 特 里 亚 也 因 此 受 益 。";
			}
			else if (!GlobalScript.inst.gameState.allcountries[99].parts[0])
			{
				text += "|| 厄 立 特 里 亚 没 能 取 得 独 立 ， 以 厄 立 特 里 亚 人 民 解 放 阵 线 为 首 的 游 击 队 继 续 对 政 府 军 发 起 战 争 。";
			}
			if (GlobalScript.inst.gameState.allcountries[100].parts[0] && GlobalScript.inst.gameState.resultOfEvents[403] == 1)
			{
				text += "|| 提 格 雷 挣 脱 了 名 为 埃 塞 俄 比 亚 的 枷 锁 ， 取 得 了 独 立 。 提 人 阵 迅 速 倒 向 中 国 。 在 我 们 的 帮 助 下 ， 提 格 雷 摆 脱 了 贫 困 的 帽 子 。 我 们 坚 信 ， 提 格 雷 的 未 来 会 更 好 。";
			}
			else if (GlobalScript.inst.gameState.allcountries[100].parts[0] && GlobalScript.inst.gameState.resultOfEvents[403] == 0 && GlobalScript.inst.gameState.resultOfEvents[475] == 1)
			{
				text += "|| 提 格 雷 在 埃 塞 俄 比 亚 的 理 解 下 取 得 了 独 立 。 而 提 人 阵 继 续 支 持 中 国 。 在 我 们 的 帮 助 下 ， 提 格 雷 摆 脱 了 贫 困 的 帽 子 。 我 们 坚 信 ， 提 格 雷 的 未 来 定 是 光 辉 的 。";
			}
			else if ((!GlobalScript.inst.gameState.allcountries[100].parts[0] && GlobalScript.inst.gameState.event_done[403] && GlobalScript.inst.gameState.resultOfEvents[403] == 0 && GlobalScript.inst.gameState.event_done[475] && (GlobalScript.inst.gameState.resultOfEvents[475] == 0 || GlobalScript.inst.gameState.resultOfEvents[475] == 2)) || (!GlobalScript.inst.gameState.allcountries[100].parts[0] && GlobalScript.inst.gameState.allcountries[41].SubGosstroy == 17))
			{
				text += "|| 在 埃 塞 俄 比 亚 人 和 提 人 阵 的 互 相 谅 解 下 ， 双 方 就 组 建 民 主 联 邦 达 成 了 协 定 。 凭 借 在 战 争 中 的 赫 赫 功 名 ， 提 格 雷 人 在 新 政 府 中 取 得 了 难 以 匹 敌 的 重 大 影 响 力 。";
			}
			else if (!GlobalScript.inst.gameState.allcountries[100].parts[0])
			{
				text += "|| 提 格 雷 没 能 取 得 独 立 ， 以 提 格 雷 人 民 解 放 阵 线 为 首 的 游 击 队 继 续 对 政 府 军 发 起 战 争 。 ";
			}
		}
		if (!GlobalScript.inst.gameState.allcountries[41].parts[1] && !GlobalScript.inst.gameState.allcountries[41].parts[0] && GlobalScript.inst.gameState.allcountries[41].SubGosstroy != 19)
		{
			if (!GlobalScript.inst.gameState.allcountries[42].parts[0] && !GlobalScript.inst.gameState.allcountries[42].parts[2])
			{
				text += "|| 欧 加 登 作 为 埃 塞 俄 比 亚 的 一 部 分 继 续 存 在 ， 西 索 马 里 解 放 阵 线 继 续 骚 扰 着 政 府 军 。";
			}
			else if ((GlobalScript.inst.gameState.allcountries[42].parts[0] || GlobalScript.inst.gameState.allcountries[42].parts[2]) && GlobalScript.inst.gameState.allcountries[41].prosov)
			{
				text += "||  随 着 埃 塞 俄 比 亚 在 欧 加 登 的 耻 辱 性 大 败 ， 索 马 里 得 到 了 自 己 一 直 渴 望 的 欧 加 登 ， 但 埃 塞 俄 比 亚 人 拒 绝 承 认 这 一 事 实 。 一 直 在 联 合 国 谴 责 索 马 里 对 埃 塞 领 土 的 非 法 占 领 ， 但 屡 次 被 美 国 和 我 们 否 决 。 ";
			}
			else if ((GlobalScript.inst.gameState.allcountries[42].parts[0] || GlobalScript.inst.gameState.allcountries[42].parts[2]) && GlobalScript.inst.gameState.allcountries[41].proprc)
			{
				text += "||  随 着 埃 塞 俄 比 亚 在 欧 加 登 的 耻 辱 性 大 败 ， 索 马 里 得 到 了 自 己 一 直 渴 望 的 欧 加 登 ， 埃 塞 俄 比 亚 事 实 上 妥 协 了 。 这 也 给 提 格 雷 ， 厄 立 特 里 亚 和 其 他 地 方 的 民 族 分 裂 主 义 者 带 来 了 机 会 。 ";
			}
		}
		text += "||";
		if ((!GlobalScript.inst.gameState.allcountries[41].parts[1] && !GlobalScript.inst.gameState.allcountries[41].parts[0]) || !GlobalScript.inst.gameState.IsAuthoritarianism(41))
		{
			text += "<color=#8B2323><size=54>索 马 里</size></color>|";
		}
		if ((!GlobalScript.inst.gameState.allcountries[41].parts[1] && !GlobalScript.inst.gameState.allcountries[41].parts[0]) || !GlobalScript.inst.gameState.IsAuthoritarianism(41))
		{
			if (GlobalScript.inst.gameState.allcountries[42].SubGosstroy == 7 && GlobalScript.inst.gameState.allcountries[42].puppetOf > 0)
			{
				text += " <size=40>鹰 犬 爪 牙</size>|";
				text += "在 西 亚 德 · 巴 雷 收 了 意 大 利 人 的 五 千 万 意 大 利 里 拉 后 。 索 马 里 得 以 借 意 大 利 之 手 再 度 谋 求 东 非 地 区 的 霸 权 。 索 马 里 革 命 社 会 主 义 党 也 被 改 组 为 索 马 里 民 族 复 兴 党 （ 本 质 就 是 意 大 利 法 西 斯 党 的 索 马 里 支 部 ） ， 一 刻 也 没 有 为 社 会 主 义 原 则 的 丢 失 感 到 悲 伤 ， 下 一 个 赶 来 的 是 强 调 “ 劳 资 结 合 ” 的 法 团 主 义 。 在 意 大 利 专 家 的 指 导 下 ， 类 似 I R I （ 意 大 利 工 业 复 兴 公 司 ） 的 企 业 也 在 索 马 里 被 组 建 起 来 ， 这 得 以 改 善 低 效 的 中 央 财 政 计 划 。 越 来 越 多 的 意 大 利 工 厂 在 索 马 里 开 张 ， 他 们 得 以 凭 借 政 府 的 优 待 和 倾 斜 性 政 策 挤 压 原 本 就 孱 弱 不 堪 的 索 马 里 经 济 。 在 外 交 与 内 政 上 ， 索 马 里 事 实 上 变 成 了 意 大 利 的 前 进 基 地 。|随 着 泛 索 马 里 情 绪 的 不 断 增 长 ， 巴 雷 不 得 不 采 取 更 为 激 进 的 外 交 政 策 。 先 是 在 表 面 上 与 吉 布 提 达 成 名 为 “ 合 并 ” 的 半 吞 并 傀 儡 。 在 意 大 利 的 默 许 之 下 ， 索 马 里 社 会 共 和 国 趁 着 门 格 斯 图 政 权 的 崩 溃 ， 索 马 里 人 得 以 为 1 9 7 8 年 复 仇 ， 大 量 的 意 大 利 士 兵 加 入 了 为 新 帝 国 开 疆 拓 土 的 战 争 。 在 将 近 上 万 名 士 兵 的 伤 亡 之 下 ， 索 马 里 人 夺 回 了 欧 加 登 地 区 。 在 厄 立 特 里 亚 的 支 援 下 ， 提 格 雷 人 民 革 命 阵 线 也 在 新 埃 塞 俄 比 亚 站 稳 了 脚 跟 。 并 开 始 着 手 和 其 他 意 大 利 傀 儡 进 行 合 并 ， 卡 斯 特 罗 的 梦 想 被 法 西 斯 主 义 者 实 现 了 。 在 索 马 里 人 以 武 力 威 胁 了 肯 尼 亚 政 府 后 ， 他 们 得 到 了 一 直 梦 寐 以 求 的 东 北 省 。 在 摩 加 迪 沙 的 阅 兵 式 上 ， 西 亚 德 · 巴 雷 正 式 宣 布 索 马 里 完 成 了 统 一 ， 全 部 的 索 马 里 人 都 生 活 在 同 一 个 屋 檐 下 。 凭 借 着 欧 加 登 地 区 的 石 油 ， 意 大 利 也 得 到 了 稳 定 的 战 略 资 源 。";
				if (GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.allcountries[99].puppetOf == 85)
				{
					text += "|| 整 个 非 洲 之 角 事 实 上 落 入 了 法 西 斯 蒂 的 魔 爪 。 世 界 正 惊 恐 的 看 着 这 一 切 发 生 。 虽 然 还 有 少 数 的 游 击 队 试 图 反 抗 ， 但 是 在 绝 对 的 力 量 与 优 势 前 ， 他 们 还 能 战 斗 到 什 么 时 候 呢 ？ ";
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[42].parts[2])
			{
				text += " <size=40>非 洲 之 角 唯 一 天 才</size>|";
				text += "在 索 马 里 彻 底 的 完 成 了 其 国 旗 上 设 定 的 目 标 — — 也 就 是 彻 底 的 统 一 索 马 里 地 区 之 后 ， 西 亚 德 · 巴 雷 在 索 马 里 民 间 已 然 登 神 ， 俨 然 成 为 超 越 征 服 埃 塞 俄 比 亚 心 脏 地 带 的 伊 斯 兰 教 捍 卫 者 艾 哈 迈 德 · 格 兰 和 德 尔 维 希 运 动 领 袖 “ 疯 毛 拉 ” 穆 罕 默 德 · 阿 卜 杜 勒 · 哈 桑 的 民 族 英 雄 。 他 不 仅 击 败 了 索 马 里 人 枕 边 的 恶 魔 们 ， 将 全 索 马 里 民 族 统 一 于 一 面 旗 帜 之 下 ， 也 为 索 马 里 指 明 了 未 来 的 道 路 。 就 像 中 国 的 红 宝 书 ， 西 方 的 圣 经 和 利 比 亚 的 绿 皮 书 ， 巴 雷 也 出 版 了 自 己 的 蓝 宝 书 。 他 正 式 跻 身 第 六 位 导 师 ， 创 立 了 科 学 西 亚 德 主 义 。 宣 传 这 位 索 马 里 “ 英 雄 般 的 父 亲 ” 的 海 报 、 诗 歌 、 颂 歌 和 赞 词 迅 速 在 全 国 铺 展 开 来 ， 在 这 些 宣 传 中 ， 两 位 民 族 英 雄 的 伟 大 后 裔 — — 父 亲 西 亚 德 被 描 绘 为 带 领 着 索 马 里 民 族 投 身 于 对 国 家 的 敌 人 — — 贫 穷 、 疾 病 、 愚 昧 和 埃 塞 俄 比 亚 人 的 斗 争 中 取 得 了 一 场 又 一 场 胜 利 的 祖 国 救 星 。 家 家 户 户 悬 挂 起 了 马 克 思 、 列 宁 、 西 亚 德 肖 像 ， 群 众 在 少 将 面 前 常 常 跳 着 忠 字 舞 ， 学 习 伟 大 领 袖 思 想 的 学 习 中 心 在 全 国 各 地 成 立 。 这 种 狂 热 的 偶 像 崇 拜 与 索 马 里 传 统 游 牧 文 化 中 的 平 等 主 义 格 格 不 入 ， 也 与 少 将 在 面 对 面 接 待 同 志 和 外 国 战 友 时 所 精 心 展 现 出 来 的 谦 和 直 率 形 成 鲜 明 的 对 比 。 但 谁 叫 英 雄 本 该 如 此 … 不 是 吗 ？|在 该 国 国 内 ， 以 部 落 而 不 是 才 干 决 定 命 运 已 是 不 争 的 事 实 ， 军 队 也 彻 底 成 为 了 巴 雷 一 家 私 人 的 玩 具 。 巴 雷 的 亲 眷 就 像 一 只 章 鱼 的 触 手 ， 无 孔 不 入 的 牢 牢 握 住 索 马 里 的 每 一 个 部 分 。 在 摩 加 迪 沙 之 外 的 领 土 毫 无 发 展 可 言 ， 粮 食 也 需 要 中 国 和 其 他 国 家 的 援 助 。|在2000 年 ， 该 国 举 行 了 一 次 只 有 一 位 候 选 人 的 选 举 。 毫 不 意 外 的 说 ， 马 撒 勒 · 穆 罕 默 德 · 西 亚 德 · 巴 雷 当 选 为 新 的 一 任 总 统 。 他 既 无 父 亲 的 个 人 威 望 ， 更 无 除 了 中 国 之 外 的 国 家 的 认 可 。 至 于 索 马 里 的 命 运 究 竟 是 一 片 光 明 ， 还 是 暗 淡 无 光 ， 只 有 他 们 自 己 知 道 … …";
			}
			else if (GlobalScript.inst.gameState.allcountries[42].parts[1] && GlobalScript.inst.gameState.allcountries[42].Gosstroy == 0)
			{
				text += " <size=40>非 洲 之 角 的 天 才 … … 其 中 之 一</size>|";
				text += "在 索 马 里 收 复 了 肯 尼 亚 霸 占 的 东 北 部 之 后 ， 西 亚 德 · 巴 雷 在 索 马 里 民 间 已 然 登 神 。 尽 管 经 历 了 欧 加 登 战 争 的 失 败 ， 但 是 他 击 败 了 索 马 里 人 枕 边 的 肯 尼 亚 恶 魔 ， 也 为 索 马 里 指 明 了 未 来 的 道 路 。 凭 借 着 肯 索 战 争 的 胜 利 所 造 就 的 威 望 ， 巴 雷 顺 利 击 败 了 因 为 欧 加 登 战 败 导 致 的 部 族 叛 乱 ， 俨 然 成 为 超 越 征 服 埃 塞 俄 比 亚 心 脏 地 带 的 伊 斯 兰 教 捍 卫 者 艾 哈 迈 德 · 格 兰 和 德 尔 维 希 运 动 领 袖 “ 疯 毛 拉 ” 穆 罕 默 德 · 阿 卜 杜 勒 · 哈 桑 的 民 族 英 雄 。 他 不 仅 击 败 了 索 马 里 人 枕 边 的 恶 魔 们 ， 将 东 北 部 收 复 于 蓝 底 白 星 旗 之 下 ， 也 为 索 马 里 指 明 了 未 来 的 道 路 。 就 像 中 国 的 红 宝 书 ， 西 方 的 圣 经 和 利 比 亚 的 绿 皮 书 ， 巴 雷 也 出 版 了 自 己 的 蓝 宝 书 。 他 正 式 跻 身 第 六 位 导 师 ， 创 立 了 科 学 西 亚 德 主 义 。 宣 传 这 位 索 马 里 “ 英 雄 般 的 父 亲 ” 的 海 报 、 诗 歌 、 颂 歌 和 赞 词 迅 速 在 全 国 铺 展 开 来 ， 在 这 些 宣 传 中 ， 两 位 民 族 英 雄 的 伟 大 后 裔 — — 父 亲 西 亚 德 被 描 绘 为 带 领 着 索 马 里 民 族 投 身 于 对 国 家 的 敌 人 — — 贫 穷 、 疾 病 、 愚 昧 和 埃 塞 俄 比 亚 人 的 斗 争 中 取 得 了 一 场 又 一 场 胜 利 的 祖 国 救 星 。 家 家 户 户 悬 挂 起 了 马 克 思 、 列 宁 、 西 亚 德 肖 像 ， 群 众 在 少 将 面 前 常 常 跳 着 忠 字 舞 ， 学 习 伟 大 领 袖 思 想 的 学 习 中 心 在 全 国 各 地 成 立 。 这 种 狂 热 的 偶 像 崇 拜 与 索 马 里 传 统 游 牧 文 化 中 的 平 等 主 义 格 格 不 入 ， 也 与 少 将 在 面 对 面 接 待 同 志 和 外 国 战 友 时 所 精 心 展 现 出 来 的 谦 和 直 率 形 成 鲜 明 的 对 比 。 但 谁 叫 英 雄 本 该 如 此 … 不 是 吗 ？|在 该 国 国 内 ， 以 部 落 而 不 是 才 干 决 定 命 运 已 是 不 争 的 事 实 ， 军 队 也 彻 底 成 为 了 巴 雷 一 家 私 人 的 玩 具 。 巴 雷 的 亲 眷 就 像 一 只 章 鱼 的 触 手 ， 无 孔 不 入 的 牢 牢 握 住 索 马 里 的 每 一 个 部 分 。 在 摩 加 迪 沙 之 外 的 领 土 毫 无 发 展 可 言 ， 粮 食 也 需 要 中 国 和 其 他 国 家 的 援 助 。|在2000 年 ， 该 国 举 行 了 一 次 只 有 一 位 候 选 人 的 选 举 。 毫 不 意 外 的 说 ， 马 撒 勒 · 穆 罕 默 德 · 西 亚 德 · 巴 雷 当 选 为 新 的 一 任 总 统 。 他 既 无 父 亲 的 个 人 威 望 ， 更 无 除 了 中 国 之 外 的 国 家 的 认 可 。 索 马 里 的 命 运 究 竟 是 一 片 光 明 ， 还 是 暗 淡 无 光 ， 只 有 他 们 自 己 知 道 … … ";
			}
			else if (GlobalScript.inst.gameState.allcountries[42].parts[1] && GlobalScript.inst.gameState.allcountries[42].Gosstroy == 1)
			{
				text += " <size=40>真 正 的 红 色 十 月</size>|";
				text = text + "在 索 马 里 统 一 社 会 党 的 治 下 ， 索 马 里 第 一 次 赢 得 了 对 外 战 争 的 胜 利 ， 击 败 了 索 马 里 人 枕 边 的 肯 尼 亚 恶 魔 ， 索 马 里 统 社 党 在 民 间 的 威 望 大 大 提 升 ， 俨 然 成 为 超 越 征 服 埃 塞 俄 比 亚 心 脏 地 带 的 伊 斯 兰 教 捍 卫 者 艾 哈 迈 德 · 格 兰 和 德 尔 维 希 运 动 领 袖 “ 疯 毛 拉 ” 穆 罕 默 德 · 阿 卜 杜 勒 · 哈 桑 的 民 族 英 雄 。 凭 借 着 肯 索 战 争 的 胜 利 所 造 就 的 威 望 ， 因 欧 加 登 战 败 而 兴 起 的 部 族 叛 乱 被 平 定 。 索 马 里 统 社 党 仍 然 主 张 着 在 埃 塞 俄 比 亚 境 内 的 索 马 里 人 聚 集 区 为 大 索 马 里 不 可 分 割 的 一 部 分 ， 但 也 仅 此 而 已 。 " + ((GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1) ? "索 马 里 统 社 党 搁 置 了 在 友 好 邻 国 的 索 马 里 人 聚 集 区 的 宣 称 。 " : null) + "|由 于 统 社 党 内 部 派 系 众 多 ， 导 致 行 政 效 率 较 为 低 下 ， 但 是 部 族 主 义 比 巴 雷 时 期 要 显 著 降 低 不 少 。 在 中 国 的 援 助 和 指 导 下 ， 统 社 党 开 始 对 索 马 里 进 行 稳 步 而 缓 慢 的 社 会 主 义 化 。 ";
			}
			else if (GlobalScript.inst.gameState.allcountries[42].parts[0])
			{
				text += " <size=40>非 洲 之 角 的 天 才 … … 其 中 之 一</size>|";
				text += "在 索 马 里 完 成 了 统 一 欧 加 登 的 伟 大 理 想 后 ， 西 亚 德 · 巴 雷 在 索 马 里 民 间 已 然 登 神 ， 俨 然 成 为 超 越 征 服 埃 塞 俄 比 亚 心 脏 地 带 的 伊 斯 兰 教 捍 卫 者 艾 哈 迈 德 · 格 兰 和 德 尔 维 希 运 动 领 袖 “ 疯 毛 拉 ” 穆 罕 默 德 · 阿 卜 杜 勒 · 哈 桑 的 民 族 英 雄 。 他 不 仅 击 败 了 索 马 里 人 枕 边 的 恶 魔 们 ， 将 欧 加 登 地 区 收 复 于 蓝 底 白 星 旗 之 下 ， 也 为 索 马 里 指 明 了 未 来 的 道 路 。 就 像 中 国 的 红 宝 书 ， 西 方 的 圣 经 和 利 比 亚 的 绿 皮 书 ， 巴 雷 也 出 版 了 自 己 的 蓝 宝 书 。 他 正 式 跻 身 第 六 位 导 师 ， 创 立 了 科 学 西 亚 德 主 义 。 宣 传 这 位 索 马 里 “ 英 雄 般 的 父 亲 ” 的 海 报 、 诗 歌 、 颂 歌 和 赞 词 迅 速 在 全 国 铺 展 开 来 ， 在 这 些 宣 传 中 ， 两 位 民 族 英 雄 的 伟 大 后 裔 — — 父 亲 西 亚 德 被 描 绘 为 带 领 着 索 马 里 民 族 投 身 于 对 国 家 的 敌 人 — — 贫 穷 、 疾 病 、 愚 昧 和 埃 塞 俄 比 亚 人 的 斗 争 中 取 得 了 一 场 又 一 场 胜 利 的 祖 国 救 星 。 家 家 户 户 悬 挂 起 了 马 克 思 、 列 宁 、 西 亚 德 肖 像 ， 群 众 在 少 将 面 前 常 常 跳 着 忠 字 舞 ， 学 习 伟 大 领 袖 思 想 的 学 习 中 心 在 全 国 各 地 成 立 。 这 种 狂 热 的 偶 像 崇 拜 与 索 马 里 传 统 游 牧 文 化 中 的 平 等 主 义 格 格 不 入 ， 也 与 少 将 在 面 对 面 接 待 同 志 和 外 国 战 友 时 所 精 心 展 现 出 来 的 谦 和 直 率 形 成 鲜 明 的 对 比 。 但 谁 叫 英 雄 本 该 如 此 … 不 是 吗 ？|在 该 国 国 内 ， 以 部 落 而 不 是 才 干 决 定 命 运 已 是 不 争 的 事 实 ， 军 队 也 彻 底 成 为 了 巴 雷 一 家 私 人 的 玩 具 。 巴 雷 的 亲 眷 就 像 一 只 章 鱼 的 触 手 ， 无 孔 不 入 的 牢 牢 握 住 索 马 里 的 每 一 个 部 分 。 在 摩 加 迪 沙 之 外 的 领 土 毫 无 发 展 可 言 ， 粮 食 也 需 要 中 国 和 其 他 国 家 的 援 助 。|在 2 0 0 0 年 ， 该 国 举 行 了 一 次 只 有 一 位 候 选 人 的 选 举 。 毫 不 意 外 的 说 ， 马 撒 勒 · 穆 罕 默 德 · 西 亚 德 · 巴 雷 当 选 为 新 的 一 任 总 统 。 他 既 无 父 亲 的 个 人 威 望 ， 更 无 除 了 中 国 之 外 的 国 家 的 认 可 。 至 于 索 马 里 的 命 运 究 竟 是 一 片 光 明 ， 还 是 暗 淡 无 光 ， 只 有 他 们 自 己 知 道 … …";
			}
			else if ((!GlobalScript.inst.gameState.allcountries[41].parts[1] && !GlobalScript.inst.gameState.allcountries[41].parts[0]) || GlobalScript.inst.gameState.allcountries[41].SubGosstroy != 19)
			{
				if (GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1 && (GlobalScript.inst.gameState.allcountries[41].parts[1] || GlobalScript.inst.gameState.allcountries[41].parts[0]))
				{
					text += " <size=40>真 正 的 红 色 十 月</size>|";
					text += "在 索 马 里 统 一 社 会 党 的 治 下 ， 在 中 国 派 出 的 顾 问 的 协 助 下 ， 支 持 统 社 党 的 民 兵 和 索 马 里 军 队 逐 步 消 灭 掉 叛 乱 部 族 的 武 装 ， 因 欧 加 登 战 败 而 兴 起 的 部 族 叛 乱 被 平 定 。 索 马 里 统 社 党 搁 置 了 在 友 好 邻 国 的 索 马 里 人 聚 集 区 的 宣 称 。|由 于 统 社 党 内 部 派 系 众 多 ， 导 致 行 政 效 率 较 为 低 下 ， 但 是 部 族 主 义 比 巴 雷 时 期 要 显 著 降 低 不 少 。 在 中 国 的 援 助 和 指 导 下 ， 统 社 党 开 始 对 索 马 里 进 行 稳 步 而 缓 慢 的 社 会 主 义 化 ， 接 纳 了 马 克 思 列 宁 主 义 的 原 则 ， 例 如 公 有 制 ， 直 接 民 主 和 革 命 委 员 会 。 索 马 里 人 民 正 在 奔 向 幸 福 而 稳 定 的 未 来 ， 再 也 不 用 为 生 计 而 苦 恼 了 ！";
				}
				else if (GlobalScript.inst.gameState.allcountries[42].Gosstroy == 1)
				{
					if (GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[119].Gosstroy == 1)
					{
						text += " <size=40>真 正 的 红 色 十 月</size>|";
						text += "在 索 马 里 统 一 社 会 党 的 治 下 ， 在 中 国 派 出 的 顾 问 的 协 助 下 ， 支 持 统 社 党 的 民 兵 和 索 马 里 军 队 逐 步 消 灭 掉 叛 乱 部 族 的 武 装 ， 因 欧 加 登 战 败 而 兴 起 的 部 族 叛 乱 被 平 定 。 索 马 里 统 社 党 搁 置 了 在 友 好 邻 国 的 索 马 里 人 聚 集 区 的 宣 称 。|由 于 统 社 党 内 部 派 系 众 多 ， 导 致 行 政 效 率 较 为 低 下 ， 但 是 部 族 主 义 比 巴 雷 时 期 要 显 著 降 低 不 少 。 在 中 国 的 援 助 和 指 导 下 ， 统 社 党 开 始 对 索 马 里 进 行 稳 步 而 缓 慢 的 社 会 主 义 化 ， 接 纳 了 马 克 思 列 宁 主 义 的 原 则 ， 例 如 公 有 制 ， 直 接 民 主 和 革 命 委 员 会 。 索 马 里 人 民 正 在 奔 向 幸 福 而 稳 定 的 未 来 ， 再 也 不 用 为 生 计 而 苦 恼 了 ！";
					}
					else if (GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1)
					{
						text += " <size=40>真 正 的 红 色 十 月</size>|";
						text += "在 索 马 里 统 一 社 会 党 的 治 下 ， 在 中 国 派 出 的 顾 问 的 协 助 下 ， 支 持 统 社 党 的 民 兵 和 索 马 里 军 队 逐 步 消 灭 掉 叛 乱 部 族 的 武 装 ， 因 欧 加 登 战 败 而 兴 起 的 部 族 叛 乱 被 平 定 。 索 马 里 统 社 党 仍 然 主 张 着 在 肯 尼 亚 境 内 的 索 马 里 人 聚 集 区 为 大 索 马 里 不 可 分 割 的 一 部 分 ， 但 也 仅 此 而 已 。|由 于 统 社 党 内 部 派 系 众 多 ， 导 致 行 政 效 率 较 为 低 下 ， 但 是 部 族 主 义 比 巴 雷 时 期 要 显 著 降 低 不 少 。 在 中 国 的 援 助 和 指 导 下 ， 统 社 党 开 始 对 索 马 里 进 行 稳 步 而 缓 慢 的 社 会 主 义 化 ， 接 纳 了 马 克 思 列 宁 主 义 的 原 则 ， 例 如 公 有 制 ， 直 接 民 主 和 革 命 委 员 会 。 索 马 里 人 民 正 在 奔 向 幸 福 而 稳 定 的 未 来 ， 再 也 不 用 为 生 计 而 苦 恼 了 ！";
					}
					else
					{
						text += " <size=40>真 正 的 红 色 十 月</size>|";
						text += "在 索 马 里 统 一 社 会 党 的 治 下 ， 在 中 国 派 出 的 顾 问 的 协 助 下 ， 支 持 统 社 党 的 民 兵 和 索 马 里 军 队 逐 步 消 灭 掉 叛 乱 部 族 的 武 装 ， 因 欧 加 登 战 败 而 兴 起 的 部 族 叛 乱 被 平 定 。 索 马 里 统 社 党 仍 然 主 张 着 在 埃 塞 俄 比 亚 境 内 的 索 马 里 人 聚 集 区 为 大 索 马 里 不 可 分 割 的 一 部 分 ， 但 也 仅 此 而 已 。|由 于 统 社 党 内 部 派 系 众 多 ， 导 致 行 政 效 率 较 为 低 下 ， 但 是 部 族 主 义 比 巴 雷 时 期 要 显 著 降 低 不 少 。 在 中 国 的 援 助 和 指 导 下 ， 统 社 党 开 始 对 索 马 里 进 行 稳 步 而 缓 慢 的 社 会 主 义 化 ， 接 纳 了 马 克 思 列 宁 主 义 的 原 则 ， 例 如 公 有 制 ， 直 接 民 主 和 革 命 委 员 会 。 索 马 里 人 民 正 在 奔 向 幸 福 而 稳 定 的 未 来 ， 再 也 不 用 为 生 计 而 苦 恼 了 ！";
					}
				}
				else if (!GlobalScript.inst.gameState.allcountries[42].parts[0] && GlobalScript.inst.gameState.allcountries[42].SubGosstroy == 15)
				{
					text += " <size=40>失 败 的 国 家</size>|";
					text += "欧 加 登 的 战 败 沉 重 打 击 了 索 马 里 ， 一 批 左 派 军 人 得 以 上 台 并 修 复 巴 雷 灾 难 性 的 政 策 。 索 马 里 的 内 战 被 避 免 了 。 经 济 在 稳 步 回 升 ， 但 很 明 显 不 可 能 回 到 战 前 状 态 了 。 ";
				}
				else if (!GlobalScript.inst.gameState.allcountries[42].parts[0] && GlobalScript.inst.gameState.allcountries[42].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[42].proprc)
				{
					text += " <size=40>跳 梁 小 丑</size>|";
					text += "欧 加 登 的 战 败 沉 重 打 击 了 索 马 里 。 好 在 中 华 人 民 共 和 国 即 时 伸 出 了 援 手 。 我 们 的 援 助 不 能 说 是 雪 中 送 碳 ， 至 少 是 一 场 及 时 雨 。 巴 雷 立 刻 展 开 了 对 政 敌 的 大 清 洗 ， 并 通 过 任 用 自 己 部 族 的 同 胞 和 巴 雷 家 族 的 成 员 来 巩 固 统 治 。 索 马 里 社 会 主 义 党 事 实 上 被 巴 雷 架 空 了 ， 美 国 和 其 他 西 方 国 家 常 常 批 评 巴 雷 缺 少 民 主 并 大 肆 迫 害 政 敌 。 索 马 里 变 成 了 巴 雷 一 人 的 王 国 ， 而 我 们 只 得 容 忍 他 继 续 在 索 马 里 人 民 身 上 作 威 作 福 。";
				}
				else
				{
					text += " <size=40>失 败 的 国 家</size>|";
					text += "索 马 里 是 世 界 上 最 不 发 达 的 国 家 之 一 ， 贪 腐 和 裙 带 关 系 猖 獗 。 在 巴 雷 统 治 的 末 期 ， 连 美 国 人 都 受 够 了 这 个 暴 君 。 最 后 在 1 9 9 1 年 ， 叛 军 攻 入 了 摩 加 迪 沙 ， 这 位 “ 索 马 里 民 族 的 大 救 星 ” 被 迫 离 开 了 自 己 的 祖 国 。 内 战 愈 演 愈 烈 ， 最 后 招 致 了 美 国 下 场 。 索 马 里 兰 也 乘 机 独 立 。 索 马 里 变 成 了 一 个 彻 头 彻 尾 的 失 败 国 家 ， 无 论 经 济 还 是 政 治 ， 这 个 国 家 彻 底 和 发 展 与 稳 定 无 缘 了 。 ";
				}
			}
		}
		text = text ?? "";
	}
}
