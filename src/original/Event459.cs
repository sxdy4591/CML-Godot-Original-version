using EventsForDLC;
using UnityEngine;

public class Event459 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 黑 色 星 期 四 ？ 红 色 星 期 四 ？";
		text = " 在 艾 哈 迈 德 · 本 · 萨 拉 赫 — — 这 位 曾 任 突 尼 斯 总 工 会 （UGTT ） 领 导 人 的 经 济 部 长 的 影 响 下 ， 突 尼 斯 自1964 年 至1969 年 实 施 了 一 系 列 社 会 主 义 改 革 ， 国 家 进 行 大 规 模 的 经 济 控 制 ， 推 行 国 有 化 与 农 业 合 作 化 运 动 ， 同 时 ， 执 政 的 新 宪 政 党 亦 顺 应 时 势 更 名 为 社 会 主 义 宪 政 党 。 然 而 ， 这 一 短 暂 的 社 会 主 义 尝 试 终 因 官 僚 主 义 的 桎 梏 及 党 内 保 守 派 、 商 界 与 富 裕 农 民 等 势 力 的 联 合 抵 制 而 告 挫 败 。1969 年9 月 ， 本 · 萨 拉 赫 遭 免 职 、 开 除 党 籍 ， 并 被 监 禁 。 直 至1973 年 ， 他 方 得 脱 逃 至 阿 尔 及 利 亚 ， 并 于 流 亡 期 间 创 立 了 反 对 派 政 党 “ 人 民 团 结 运 动 ” 。||接 任 其 位 的 埃 迪 · 努 伊 拉 转 而 采 纳 自 由 主 义 政 策 ， 启 动 经 济 与 社 会 自 由 化 进 程 ， 引 发 了 包 括 小 资 产 阶 级 在 内 的 广 泛 社 会 阶 层 的 不 满 情 绪 。||值 得 注 意 的 是 ， 突 尼 斯 总 工 会 与 社 会 主 义 宪 政 党 之 间 ， 长 久 以 来 并 非 简 单 的 领 导 与 被 领 导 关 系 ， 而 是 交 织 着 合 作 、 相 互 利 用 乃 至 对 抗 的 复 杂 互 动 。 进 入1970 年 代 末 ， 突 尼 斯 爆 发 了 经 济 危 机 ， 两 大 机 构 在 应 对 危 机 策 略 上 产 生 了 严 重 分 歧 。 政 府 试 图 将 危 机 责 任 转 嫁 给 工 会 及 工 人 阶 级 ， 同 时 加 大 了 对 反 对 派 的 镇 压 力 度 ， 尤 其 是 针 对 人 民 团 结 运 动 及 由 前 社 会 主 义 宪 政 党 高 层 艾 哈 迈 德 · 梅 斯 提 里 领 导 的 左 翼 民 主 派 团 体 （ 他 在1978 年6 月19 日 成 立 了 社 会 主 义 民 主 运 动 ） ， 后 者 因 支 持 民 主 化 而 与 本 党 决 裂 。||1978 年1 月20 日 ， 社 会 主 义 宪 政 党 中 央 委 员 会 发 布 决 议 ， 要 求 清 除UGTT 领 导 层 中 的 “ 破 坏 因 素 ” 。 随 后 ， 该 党 派 遣 武 装 力 量 袭 击 了 工 会 的 多 处 地 方 机 构 。1 月24 日 ，UGTT 斯 法 克 斯 的 地 方 领 导 人 被 捕 ， 工 会 总 书 记 哈 比 卜 · 阿 库 尔 在 穆 罕 默 德 · 阿 里 广 场 的 慷 慨 陈 词 中 ， 号 召 全 国 总 罢 工 ， 并 宣 称 “ 人 民 之 外 ， 别 无 至 高 无 上 者 ” （ 暗 指 对 布 尔 吉 巴 权 威 的 挑 战 ） 。 此 言 一 出 ， 立 即 被 视 为 挑 衅 行 为 ， 警 方 随 即 于1 月25 日 包 围 了 工 会 总 部 ， 将 近200 名 工 会 领 袖 困 于 其 中 。 次 日 清 晨 ， 阿 库 尔 致 电 国 家 安 全 局 ， 要 求 安 全 部 队 撤 离 ， 并 发 出 警 告 ： “ 如 果 拒 绝 ， 他 会 宣 布 ‘ 突 尼 斯 将 燃 烧 ’ ” 。||突 尼 斯 社 会 的 矛 盾 已 累 积 至 一 触 即 发 的 边 缘 ， 我 们 是 否 要 对 此 进 行 干 预 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.data[14] <= 2 && a.data[56] < 2)
		{
			button_text[0] = " 全 力 支 持 工 会 和 左 翼 反 对 派";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 可 我 们 还 真 的 能 以 社 会 主 义 者 自 称 吗 ？";
		}
		if (GlobalScript.inst.gameState.empires[1].relations >= 600)
		{
			button_text[1] = " 暗 示 阿 尔 及 尔 和 的 黎 波 里 方 面 ， 让 他 们 动 手 。";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 要 帮 邪 恶 帝 国 ？";
		}
		if (GlobalScript.inst.gameState.data[56] >= 3 && a.data[6] <= 700 && GlobalScript.inst.gameState.allcountries[21].Torg && GlobalScript.inst.gameState.allcountries[21].Gosstroy != 1)
		{
			button_text[2] = " 暗 示 法 国 人 ， 让 他 们 来 解 决 问 题 。";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 法 国 人 为 什 么 还 能 插 手 ？";
		}
		button_text[3] = " 太 远 了 ， 还 是 太 远 了 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 黑 色 星 期 四 ？ 红 色 星 期 四 ？";
		switch (result_num)
		{
		case 0:
			text = " 我 们 决 定 全 力 支 持 他 们 。 在 我 们 的 帮 助 下 ， 人 民 团 结 运 动 、 社 会 主 义 民 主 运 动 （ 在 我 们 的 帮 助 下 提 前 成 立 ） 和 毛 主 义 的 突 尼 斯 工 人 组 织 等 左 翼 反 对 派 被 团 结 在 工 会 周 围 ， 组 成 了 一 支 人 民 阵 线 。 数 以 万 计 的 工 人 、 青 年 ， 乃 至 一 些 不 隶 属 于 U G T T 的 失 业 者 ， 被 组 织 为 民 兵 ， 而 “ 意 外 ” 打 开 的 军 火 库 大 门 更 是 给 了 工 人 们 和 政 府 决 战 的 底 气 ， 工 人 民 兵 纷 纷 涌 上 突 尼 斯 的 街 头 ， 筑 起 街 垒 。 原 本 的 罢 工 迅 速 升 级 为 人 民 的 浪 潮 ， 抗 议 者 不 仅 占 领 了 市 中 心 ， 还 攻 入 了 资 产 阶 级 社 区 和 政 府 机 构 ， 最 后 ， 海 军 和 部 分 陆 军 的 倒 戈 则 是 为 布 尔 吉 巴 敲 下 了 丧 钟 。||最 后 ， 本 · 萨 拉 赫 出 任 新 的 阿 拉 伯 突 尼 斯 共 和 国 的 总 统 ， 而 社 会 主 义 民 主 运 动 领 导 人 艾 哈 迈 德 · 梅 斯 提 里 则 出 任 总 理 。 在 新 政 府 的 支 持 下 ， 布 尔 吉 巴 时 期 的 左 翼 政 治 犯 都 被 释 放 和 平 反 ， 并 允 许 他 们 组 建 政 党 。 新 的 突 尼 斯 采 取 左 翼 多 党 民 主 和 泛 阿 拉 伯 主 义 的 原 则 ， 他 们 宣 布 要 清 除 西 方 帝 国 主 义 在 突 尼 斯 的 影 响 ， 并 加 强 同 各 个 社 会 主 义 国 家 和 阿 拉 伯 进 步 兄 弟 国 家 的 友 谊 。 很 快 ， 突 尼 斯 在 我 们 和 苏 联 的 援 助 下 ， 开 始 重 启 国 有 化 和 农 业 合 作 化 运 动 。 突 尼 斯 赠 予 我 们 六 颗 突 尼 斯 软 籽 石 榴 ， 以 感 谢 我 们 对 突 尼 斯 人 民 的 帮 助 。||1978 年1 月26 日 这 一 天 ， 在 突 尼 斯 被 称 为 “ 红 色 星 期 四 ” 。";
			GlobalScript.inst.gameState.allcountries[55].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[55].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[55].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[55].prosov = false;
			GlobalScript.inst.gameState.allcountries[55].Torg = true;
			GlobalScript.inst.gameState.allcountries[55].cw = true;
			a.influencePRC += 20;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.data[1] += 100;
			a.data[3] += 100;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 30;
			a.empires[1].relations += 50;
			a.empires[1].power += 10;
			return;
		case 1:
			text = " 我 们 最 终 决 定 通 过 利 比 亚 和 阿 尔 及 利 亚 来 干 涉 突 尼 斯 内 政 。 利 比 亚 和 阿 尔 及 利 亚 在 我 们 的 帮 助 和 苏 联 克 格 勃 的 秘 密 批 准 下 ， 联 合 起 来 制 订 了 一 项 消 灭 突 尼 斯 总 统 的 计 划 。 利 比 亚 和 阿 尔 及 利 亚 一 直 致 力 于 泛 阿 拉 伯 主 义 运 动 ， 而 卡 扎 菲 因 早 前 将 突 尼 斯 和 利 比 亚 合 并 为 阿 拉 伯 伊 斯 兰 共 和 国 计 划 的 失 败 而 记 恨 着 布 尔 吉 巴 ， 因 此 ， 他 庇 护 了 萨 拉 赫 · 本 · 优 素 福 （ 布 尔 吉 巴 过 去 的 竞 争 者 ， 更 支 持 纳 赛 尔 的 泛 阿 拉 伯 主 义 ） 的 一 批 支 持 者 所 建 立 的 突 尼 斯 进 步 力 量 民 族 阵 线 ， 为 他 们 提 供 军 事 训 练 ， 以 用 于 颠 覆 布 尔 吉 巴 政 权 ， 而 现 在 ， 正 是 机 会 。||很 快 ， 突 尼 斯 进 步 力 量 民 族 阵 线 组 建 了 一 支 名 为 “ 突 尼 斯 解 放 军 ” 的 武 装 小 队 ， 同 利 比 亚 和 阿 尔 及 利 亚 的 民 兵 和 特 工 一 起 秘 密 进 入 埃 及 进 内 ， 并 混 入 抗 议 者 的 队 伍 ， 秘 密 向 抗 议 者 提 供 武 器 。 而 克 格 勃 特 工 则 通 过 突 尼 斯 共 产 党 的 组 织 网 络 将 抗 议 者 、 工 会 、 人 民 团 结 运 动 和 突 尼 斯 进 步 力 量 民 族 阵 线 串 联 起 来 ， 同 时 吸 收 了 一 批 阿 拉 伯 社 会 主 义 者 ， 组 成 了 突 尼 斯 人 民 民 主 团 结 阵 线 。 突 尼 斯 解 放 军 的 战 士 在 利 比 亚 人 的 支 持 下 ， 在 群 众 大 会 上 伪 装 成 保 洁 员 ， 用 安 装 在 铁 皮 垃 圾 桶 里 的 炸 弹 一 劳 永 逸 的 干 掉 了 布 尔 吉 巴 。 随 后 ， 人 民 民 主 团 结 阵 线 就 通 过 发 动 一 切 支 持 者 进 行 暴 动 ， 夺 取 了 突 尼 斯 的 政 权 ， 突 尼 斯 国 名 也 被 改 为 阿 拉 伯 突 尼 斯 人 民 共 和 国 。 经 过 多 方 妥 协 ， 突 尼 斯 进 步 力 量 民 族 阵 线 的 领 导 人 埃 泽 丁 · 谢 里 夫 成 为 了 突 尼 斯 新 总 统 ， 人 民 团 结 运 动 领 导 人 本 · 萨 拉 赫 成 为 了 总 理 ， 哈 比 卜 · 阿 库 尔 留 任 工 会 总 书 记 同 时 兼 任 副 总 理 ， 而 突 尼 斯 共 产 党 总 书 记 穆 罕 默 德 · 纳 法 则 在 苏 联 的 支 持 下 兼 任 副 总 统 和 内 政 部 长 。 新 政 府 立 刻 得 到 了 苏 联 和 我 们 的 承 认 。 他 们 宣 布 要 清 除 西 方 帝 国 主 义 在 突 尼 斯 的 影 响 ， 并 加 强 同 东 方 社 会 主 义 国 家 和 阿 拉 伯 进 步 兄 弟 国 家 的 友 谊 。 随 后 ， 突 尼 斯 开 始 进 行 新 一 轮 社 会 主 义 改 革 。||1978 年1 月26 日 这 一 天 ， 在 突 尼 斯 被 称 为 “ 红 色 星 期 四 ” 。";
			GlobalScript.inst.gameState.allcountries[55].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[55].SubGosstroy = 15;
			GlobalScript.inst.gameState.allcountries[55].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[55].Torg = true;
			GlobalScript.inst.gameState.allcountries[55].prosov = true;
			a.data[8] -= 30;
			a.data[9] -= 30;
			a.empires[0].relations -= 50;
			a.empires[0].power -= 20;
			a.empires[1].relations += 50;
			a.empires[1].relations += 50;
			a.empires[1].power += 10;
			return;
		case 2:
			text = " 我 们 的 大 使 在 和 法 国 外 长 的 交 谈 中 ， 暗 示 了 我 们 对 突 尼 斯 问 题 的 担 忧 。 我 们 也 指 出 ， 法 国 作 为 一 个 在 马 格 里 布 地 区 拥 有 巨 大 影 响 力 的 国 家 ， 无 论 如 何 都 不 应 该 对 突 尼 斯 的 现 状 坐 视 不 管 。||法 国 人 立 刻 理 解 了 我 们 的 暗 示 （ 或 者 说 他 们 早 有 此 意 ？ ） 。 很 快 ， 一 支 由 鲍 勃 · 德 纳 尔 带 领 的 军 团 坐 着C-160 ， 稳 稳 的 在 突 尼 斯 着 陆 。 这 支 部 队 立 刻 冲 向 总 统 府 。 在 对 总 统 用 子 弹 痛 陈 利 害 后 ， 布 尔 吉 巴 总 统 用 身 上 的28 个 弹 孔 做 出 了 回 答 。||很 快 ， 法 国 选 出 了 本 · 阿 里 作 为 其 代 言 人 ， 他 宣 布 彻 底 地 转 向 市 场 经 济 和 对 外 开 放 ， 并 恢 复 了 法 国 人 的 军 事 基 地 。 原 先 的 社 会 主 义 宪 政 党 也 换 汤 不 换 药 地 被 改 为 了 突 尼 斯 民 主 宪 政 联 盟 。 虽 然 这 个 党 既 不 民 主 更 不 宪 政 ， 但 只 要 法 国 人 还 支 持 他 们 ， 突 尼 斯 应 该 就 能 消 停 了 吧 ？||新 总 统 本 · 阿 里 在 当 日 傍 晚 时 分 宣 布 进 入 紧 急 状 态 ， 在 突 尼 斯 军 队 和 法 国 雇 佣 兵 的 “ 照 顾 ” 下 ， 工 会 和 抗 议 群 众 都 被 镇 压 。 据 官 方 公 布 的 数 据 ， 至 少 有52 人 丧 生 ， 超 过365 人 受 伤 ； 而 另 有 消 息 来 源 则 称 ， 死 亡 人 数 可 能 高 达200 多 人 ， 受 伤 者 数 以 千 计 。 政 府 的 反 击 行 动 紧 随 其 后 ， 超 过500 人 被 迅 速 定 罪 。 与 此 同 时 ， 紧 急 状 态 也 迟 迟 没 有 解 除 的 消 息 … …||1978 年1 月26 日 这 一 天 ， 在 突 尼 斯 成 为 了 敏 感 话 题 ， 被 称 为 “ 黑 色 星 期 四 ” 。";
			GlobalScript.inst.gameState.allcountries[55].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[55].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[55].puppetOf = 21;
			a.empires[0].relations += 50;
			a.empires[0].power += 50;
			break;
		}
		if (result_num == 3)
		{
			text = " 随 后 ， 局 势 急 转 直 下 ， 彻 底 失 控 ： 数 以 万 计 的 工 人 、 青 年 ， 乃 至 一 些 不 隶 属 于UGTT 的 失 业 者 ， 纷 纷 涌 上 突 尼 斯 的 街 头 。 原 本 的 罢 工 迅 速 升 级 为 骚 乱 与 示 威 的 浪 潮 ， 抗 议 者 不 仅 占 领 了 市 中 心 ， 还 侵 入 了 高 档 社 区 。 尽 管 当 局 迅 速 实 施 了 宵 禁 ， 但 警 方 很 快 便 显 得 力 不 从 心 ， 双 方 对 抗 不 断 加 剧 。 道 路 上 布 满 了 路 障 ， 公 共 建 筑 遭 受 破 坏 ， 熊 熊 燃 烧 的 汽 车 数 量 激 增 ， 局 势 愈 发 严 峻 。||尽 管 总 统 哈 比 卜 · 布 尔 吉 巴 在 当 日 傍 晚 时 分 宣 布 进 入 紧 急 状 态 ， 但 示 威 活 动 非 但 没 有 平 息 ， 反 而 愈 演 愈 烈 。 这 是 自 国 家 独 立 以 来 ， 政 府 首 次 动 用 了 军 队 介 入 ， 由 本 · 阿 里 指 挥 ， 他 刚 被 总 理 埃 迪 · 努 伊 拉 紧 急 任 命 为 总 安 全 负 责 人 。||面 对 示 威 群 众 日 益 高 涨 的 怒 火 ， 军 队 采 取 了 一 系 列 强 硬 措 施 ， 导 致 了 严 重 的 伤 亡 事 件 。 据 官 方 公 布 的 数 据 ， 至 少 有52 人 丧 生 ， 超 过365 人 受 伤 ； 而 另 有 消 息 来 源 则 称 ， 死 亡 人 数 可 能 高 达200 多 人 ， 受 伤 者 数 以 千 计 。 政 府 的 反 击 行 动 紧 随 其 后 ， 超 过500 人 被 迅 速 定 罪 。 紧 急 状 态 与 宵 禁 措 施 持 续 了 一 个 多 月 之 久 ， 直 至2 月25 日 及 随 后 的3 月20 日 才 相 继 解 除 。||对 于 政 府 而 言 ，1 月26 日 的 全 面 罢 工 不 仅 是 一 场 危 机 ， 更 将 工 会 运 动 中 激 进 反 对 派 的 力 量 推 向 了 前 所 未 有 的 高 度 。 几 位 关 键 领 袖 ， 包 括 哈 比 卜 · 阿 库 尔 在 内 ， 不 幸 被 捕 并 入 狱 。 此 外 ， 还 有13 人 被 判 处 不 等 刑 罚 ， 从10 年 苦 役 到6 个 月 监 禁 不 等 。||<color=red>从 此 ，在 突 尼 斯 ，1978 年 没 有 一 月 ， 一 月 没 有 星 期 四 。</color>||尽 管 如 此 ， 突 尼 斯 的 问 题 并 没 有 解 决 ， 事 情 不 会 就 这 样 结 束 的 … …";
			GlobalScript.inst.gameState.allcountries[55].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[55].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[55].Vyshi = true;
			a.empires[0].power += 50;
		}
	}
}
