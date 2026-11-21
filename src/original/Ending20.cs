using EndingsDLCDraft;
using UnityEngine;

public class Ending20 : EndingsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEnding(ref string name, ref string text)
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		name = GlobalScript.inst.new_events_text[1522];
		if (a.allcountries[85].SubGosstroy == 14)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1523], "\n", (a.empires[1].now_leader == 6) ? GlobalScript.inst.new_events_text[1535] : null);
		}
		else if (a.event_done[393])
		{
			text = string.Format(GlobalScript.inst.new_events_text[1524], "\n", (a.empires[1].now_leader == 6) ? GlobalScript.inst.new_events_text[1536] : GlobalScript.inst.new_events_text[1537]);
		}
		else if (a.event_done[394] && a.allcountries[85].SubGosstroy == 5 && !a.event_done[398] && !a.event_done[556])
		{
			text = string.Format(GlobalScript.inst.new_events_text[1525], "\n");
		}
		else if (a.allcountries[85].SubGosstroy == 5 && a.event_done[556])
		{
			text = " 南 欧 版 魏 玛 共 和 国||工 人 主 义 者 对 意 大 利 政 府 的 堂 吉 诃 德 式 挑 战 在 客 观 上 为 意 大 利 日 益 衰 落 的 激 进 主 义 运 动 盖 上 了 棺 材 板 ， 并 彻 底 促 成 了 意 大 利 主 流 政 治 的 完 全 温 和 化 与 激 进 反 极 端 主 义 的 形 成 ： 内 战 后 成 立 的 第 二 共 和 国 在 选 举 后 产 生 的 所 谓 “ 绿 白 红 ” （ 即 意 大 利 社 会 党 、 天 主 教 民 主 党 与 意 大 利 共 产 党 三 方 ） 基 础 上 实 行 新 政 策 ： 立 法 禁 绝 极 端 主 义 政 治 符 号 ， 并 竭 力 将 两 次 “ 火 热 之 秋 ” 给 打 上 历 史 耻 辱 柱 。 该 国 的 执 法 机 器 本 身 也 以 “ 肃 清 工 人 主 义 余 毒 ” 为 名 实 现 扩 张 ， 并 竭 力 朝 联 邦 德 国 的 军 警 宪 特 治 国 模 式 看 齐 。 出 于 平 息 社 会 动 荡 的 需 要 ， 政 府 在 改 善 劳 工 福 祉 方 面 多 少 迈 开 了 步 子 ： 通 过 劳 动 法 、 效 法 现 代 社 会 民 主 主 义 进 行 改 革 与 引 入 累 进 税 。 不 过 ， 该 国 仍 对 社 会 制 度 的 根 本 改 革 不 甚 热 心 。 且 各 党 基 本 上 蜷 缩 在 所 谓 “ 绿 白 红 ” 联 盟 拥 护 的 政 治 正 确 与 霸 权 下 。 | | 可 好 景 不 长 ， 意 大 利 的 政 治 在 8 0 - 9 0 年 代 之 交 迎 来 了 场 巨 变 。 在 工 人 主 义 暴 动 刺 激 意 大 利 共 产 党 进 一 步 同 革 命 主 义 分 道 扬 镳 （ 但 又 背 上 “ 颠 覆 共 和 国 ” 的 黑 锅 ） ， 且 意 大 利 传 统 产 业 工 人 越 加 萎 靡 ， 导 致 该 党 衰 退 态 势 几 乎 无 法 遏 制 的 背 景 下 。 新 任 领 导 人 阿 基 莱 · 奥 凯 托 决 定 抛 弃 贝 林 格 的 欧 洲 共 产 主 义 ， 并 在 意 大 利 共 产 党 的 传 统 选 区 博 洛 尼 亚 宣 布 转 型 。 在 1 9 9 0 年 举 行 的 党 代 会 上 ， 意 大 利 共 产 党 宣 布 自 我 解 散 ， 改 组 为 所 谓 左 翼 民 主 党 ： 可 改 组 并 没 有 给 它 带 来 奇 迹 ， 新 政 党 在 1 9 9 2 年 的 选 举 中 也 仅 获 得 1 6 % 的 选 票 。 事 实 上 宣 告 了 “ 绿 白 红 ” 联 盟 的 一 大 支 柱 的 垮 台 。 为 此 ， 左 翼 民 主 党 试 图 通 过 左 翼 党 派 集 团 “ 橄 榄 树 ” 重 振 旗 鼓 。 然 而 在 本 世 纪 末 ， 该 党 派 的 影 响 力 也 越 加 衰 微 ， 而 左 翼 民 主 党 的 继 承 者 甚 至 为 争 取 选 票 而 彻 底 抛 弃 社 会 民 主 主 义 立 场 。 “ 绿 白 红 ” 联 盟 的 其 他 两 翼 也 未 在 共 产 党 崩 溃 后 存 活 多 久 ， 它 们 在 1 9 9 2 - 1 9 9 3 年 执 法 机 构 以 清 算 犯 罪 与 黑 手 党 问 题 而 发 起 的 “ 净 手 行 动 ” 中 纷 纷 落 马 ： 霸 占 该 国 政 治 空 间 的 天 主 教 民 主 党 与 社 会 党 ， 被 查 出 长 期 与 黑 手 党 存 在 腐 败 交 易 。 从 而 掀 起 政 坛 地 震 — — 至 此 ， 构 成 第 二 共 和 国 政 治 基 石 的 传 统 政 党 纷 纷 消 失 。 其 留 下 的 空 缺 则 被 各 路 小 政 党 与 民 粹 主 义 政 党 取 代 ： 意 大 利 也 就 迎 来 了 多 党 制 、 议 会 无 力 、 内 耗 频 繁 且 政 令 不 行 等 经 典 问 题 。 成 为 了 只 能 依 靠 建 国 初 残 存 的 民 主 主 义 认 同 维 系 与 越 加 强 势 ， 自 诩 “ 独 立 于 政 治 外 ” 的 安 保 机 构 所 主 导 的 失 败 民 主 国 家 。";
		}
		else if (a.allcountries[85].SubGosstroy == 0)
		{
			text = "无 产 阶 级 闹 天 宫||工 人 主 义 者 联 合 被 意 大 利 当 局 一 同 放 逐 到 该 国 社 会 边 缘 的 群 体 们 一 道 重 新 定 义 了 意 大 利 ， 使 得 该 国 政 治 生 态 焕 然 一 新 。 首 先 便 平 反 因 丰 塔 纳 广 场 爆 炸 案 冤 死 的 铁 路 工 人 皮 内 里 ， 高 度 赞 扬 “ 火 热 之 秋 ” 对 意 大 利 社 会 的 重 要 意 义 ， 以 及 对 意 大 利 共 产 党 早 期 领 导 人 安 东 尼 奥 · 葛 兰 西 的 再 诠 释 ： 活 动 家 们 热 心 恢 复 葛 兰 西 作 为 “ 红 色 两 年 ” 内 热 心 工 人 委 员 会 斗 争 的 活 动 家 形 象 ， 一 方 面 达 到 否 定 意 大 利 共 产 党 官 方 叙 事 中 “ 党 阀 、 民 主 建 制 派 、 爱 国 主 义 者 与 反 法 西 斯 斗 士 ” 的 刻 板 宣 传 ， 起 到 在 社 会 建 构 革 命 性 意 识 形 态 的 作 用 ， 一 方 面 则 试 图 从 葛 兰 西 对 意 大 利 社 会 问 题 的 哲 思 中 寻 找 改 组 社 会 答 案 。 通 过 吸 取 意 大 利 共 产 党 与 “ 以 劳 动 为 基 础 ， 却 事 实 上 贬 低 劳 动 ” 的 第 一 共 和 国 的 教 训 ， 他 们 否 定 了 通 过 党 或 工 会 官 僚 组 织 组 织 新 社 会 的 路 径 ， 转 而 信 奉 “ 革 命 期 间 开 拓 的 新 方 法 ” ： 即 葛 兰 西 理 想 中 的 工 人 委 员 会 ， 列 宁 主 义 理 论 内 的 苏 维 埃 ， 中 国 文 革 时 代 的 群 众 专 政 与 巴 黎 公 社 式 追 求 无 产 阶 级 直 接 行 使 国 家 权 力 ， 落 实 其 领 导 权 的 机 构 。 此 后 ， 工 人 主 义 者 便 以 苏 维 埃 俄 国 为 参 照 进 行 社 会 革 命 。 意 大 利 联 邦 建 立 了 基 于 生 产 单 位 选 区 的 民 主 形 式 ， 区 苏 维 埃 被 视 为 议 行 合 一 的 基 本 行 政 单 位 ， 领 导 人 由 直 选 与 委 员 制 产 生 。 全 国 由 区 级 苏 维 埃 - 州 级 苏 维 埃 - 邦 级 苏 维 埃 的 三 层 体 系 构 成 ， 在 确 保 言 论 与 集 会 自 由 的 同 时 仅 允 许 支 持 无 产 阶 级 专 政 的 政 治 集 团 与 非 资 产 阶 级 参 与 国 内 政 治 。 黑 手 党 与 天 主 教 会 也 因 其 在 革 命 期 间 支 持 反 动 的 “ 民 族 团 结 政 府 ” 而 被 取 缔 。 | | 与 此 同 时 ， 工 人 主 义 者 开 始 依 托 各 自 治 团 体 筹 建 苏 维 埃 民 兵 组 织 ， 要 求 其 协 助 各 地 活 动 家 贯 彻 落 实 分 权 计 划 原 则 。 因 此 ， 国 内 主 要 企 业 均 被 移 交 给 相 应 区 块 的 工 人 委 员 会 进 行 管 理 ， 土 地 实 现 社 会 化 经 营 ， 长 期 处 于 弱 势 地 位 的 南 方 移 民 工 人 也 获 得 组 织 罢 工 委 员 会 参 与 决 策 的 权 力 。 此 后 各 地 又 通 过 一 篮 子 社 会 进 步 法 令 ， 为 实 现 性 别 、 民 族 与 文 化 层 面 的 平 等 开 绿 灯 ， 试 图 在 此 基 础 上 创 建 新 生 活 方 式 。 工 人 主 义 者 们 开 始 将 “ 公 社 式 生 活 ” 作 为 标 杆 ， 以 苏 联 时 代 的 “ 纳 康 芬 ” 式 共 享 公 共 住 宅 为 原 型 兴 修 宽 敞 公 社 住 房 ， 且 鼓 励 各 地 委 员 会 、 苏 维 埃 与 公 社 等 组 织 定 期 举 行 政 治 集 会 、 礼 品 交 换 与 重 大 议 题 讨 论 ， 在 成 员 中 培 育 社 会 责 任 感 与 主 人 翁 精 神 。 因 此 ， 意 大 利 得 以 在 某 种 程 度 上 保 留 了 集 中 式 的 管 理 框 架 ： 即 基 层 无 产 阶 级 各 团 体 在 相 互 承 认 ， 共 同 拥 护 无 产 阶 级 专 政 与 共 产 主 义 道 德 原 则 的 基 础 上 达 成 经 济 、 政 治 上 的 一 致 。 最 终 逐 步 落 实 苏 联 法 学 家 叶 夫 根 尼 · 帕 舒 卡 尼 斯 理 论 内 所 述 的 “ 法 律 消 亡 ” 。 意 大 利 本 身 也 就 此 走 上 条 另 类 的 社 会 主 义 革 命 道 路 ， 并 成 为 全 世 界 西 方 马 克 思 主 义 者 、 无 政 府 共 产 主 义 者 与 左 翼 共 产 主 义 者 所 乐 见 的 模 范 。";
		}
		else if (a.allcountries[85].SubGosstroy == 10)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1526], "\n");
		}
		else if (a.allcountries[85].SubGosstroy == 16)
		{
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(124);
			}
			text = string.Format(GlobalScript.inst.new_events_text[1527], "\n");
		}
		else if (a.allcountries[85].SubGosstroy == 17)
		{
			text = " 先 烈 鲜 血 所 染 红 的 旗 帜||在 肃 清 了 打 着 毛 泽 东 同 志 旗 号 的 法 西 斯 主 义 者 （ 即 所 谓 民 族 毛 主 义 者 ） 后 ， 新 意 大 利 得 以 向 社 会 主 义 迈 进 。|| 共 产 党 人 完 成 了 为 葛 兰 西 和 马 泰 奥 蒂 ， 为 铁 路 工 人 皮 内 利 的 复 仇 。 意 大 利 回 归 了 光 荣 的 斗 争 传 统 ， 马 克 思 、 恩 格 斯 、 列 宁 、 斯 大 林 与 毛 泽 东 的 画 像 在 罗 马 城 竖 起 ， 铅 色 年 代 前 后 被 捕 的 左 翼 分 子 被 释 放 ， 工 人 委 员 会 在 工 厂 建 立 。 新 政 府 宣 布 将 以 人 民 中 国 为 意 大 利 社 会 主 义 共 和 国 的 学 习 榜 样 ， 由 意 大 利 革 命 共 产 党 领 导 的 无 产 阶 级 专 政 建 立 起 来 。 在 红 色 旅 等 左 翼 武 装 组 织 与 旧 意 共 游 击 队 关 系 网 的 基 础 上 ， 新 意 大 利 成 立 了 意 大 利 人 民 解 放 军 作 为 常 备 军 。|| 对 法 西 斯 主 义 者 的 清 算 在 逐 步 进 行 ， 在 铅 色 年 代 期 间 犯 下 重 案 的 法 西 斯 分 子 被 公 审 ， 一 切 的 法 西 斯 主 义 团 体 被 取 缔 ， 其 领 导 人 最 终 纷 纷 入 狱 。|| 梵 蒂 冈 与 圣 马 力 诺 成 为 了 新 意 大 利 中 与 其 他 城 市 地 位 所 平 等 的 一 部 分 ， 圣 座 制 度 被 废 除 ， 若 望 · 保 禄 二 世 在 红 旗 下 宣 布 退 位 ， 梵 蒂 冈 宫 成 了 陈 列 旧 天 主 教 廷 器 物 的 博 物 馆 。 土 地 改 革 在 农 村 进 行 ， 建 立 了 新 的 农 业 合 作 社 ， 农 业 机 械 化 也 在 稳 步 推 进 。 与 此 同 时 ， 新 政 府 制 定 了 对 南 方 工 业 发 展 的 扶 助 计 划 ， 旨 在 逐 步 缩 小 南 北 差 距 ， 最 终 彻 底 消 除 南 北 问 题 。|| 在 新 政 府 的 重 点 打 击 与 旧 的 土 地 关 系 被 摧 毁 后 ， 黑 手 党 丧 失 了 赖 以 存 在 的 基 础 ， 最 终 被 连 根 拔 除 。 外 交 政 策 上 ， 意 大 利 政 府 采 取 了 “ 一 边 倒 ” 的 外 交 政 策 ， 积 极 同 中 国 与 阿 尔 巴 尼 亚 等 社 会 主 义 国 家 建 立 关 系 。 在 葛 兰 西 与 毛 泽 东 的 思 想 指 引 下 ， 一 场 轰 轰 烈 烈 的 文 化 革 命 运 动 开 展 了 起 来 ， 欧 洲 共 产 主 义 “ 不 是 工 人 阶 级 运 动 的 右 翼 ， 而 是 资 产 阶 级 的 左 翼 ” 的 假 面 具 被 撕 下 ， 社 会 主 义 新 文 化 压 倒 了 腐 朽 老 旧 的 法 西 斯 文 化 ， 无 产 阶 级 民 主 也 得 以 巩 固 。";
		}
		else if (a.allcountries[85].SubGosstroy == 9 && a.event_done[481])
		{
			text = " 三 色 的 火 焰||法 西 斯 主 义 者 成 功 扫 除 了 “ 犹 太 - 布 尔 什 维 克 ” 余 毒 ， 在 一 次 在 电 视 台 上 公 开 播 出 的 作 秀 式 的 审 判 后 ， 福 斯 科 · 迪 努 奇 、 安 吉 洛 · 格 拉 奇 、 乔 瓦 尼 · 斯 库 德 里 、 朱 塞 佩 · 马 基 “ 红 线 四 人 帮 ” 在 罗 马 被 公 开 处 决 ， 新 政 权 展 开 了 对 左 翼 分 子 及 其 同 情 者 的 大 规 模 清 算 。|| 皮 诺 · 劳 蒂 ， 这 位 激 进 的 新 法 西 斯 主 义 活 动 家 被 推 举 为 新 意 大 利 的 领 袖 （ D u c e ） ， 乔 治 · 索 雷 尔 、 加 布 里 埃 尔 · 邓 南 遮 、 墨 索 里 尼 、 尤 利 乌 斯 · 埃 佛 拉 等 先 贤 所 缔 造 的 法 西 斯 主 义 理 论 体 系 被 明 确 为 新 意 大 利 的 指 导 思 想 ， 除 新 秩 序 民 族 革 命 先 锋 党 外 的 一 切 政 党 被 取 缔 ， 工 会 被 纳 入 法 西 斯 主 义 者 的 控 制 下 。 对 萨 罗 共 和 国 ( 即 意 大 利 社 会 共 和 国 ) 的 平 反 也 已 经 开 始 ： 其 宪 法 与 律 令 制 度 也 被 看 作 是 本 土 意 大 利 人 民 国 家 的 典 范 。 1 9 1 9 年 的 卡 纳 罗 宪 章 、 圣 墓 宣 言 与 萨 罗 共 和 国 的 维 罗 纳 宪 章 成 了 新 意 大 利 法 律 制 定 的 蓝 本 。 与 墨 索 里 尼 一 同 被 共 产 党 游 击 队 处 决 的 尼 古 拉 · 邦 巴 奇 、 亚 历 山 德 罗 · 帕 沃 里 尼 等 人 被 追 悼 为 被 犹 太 布 尔 什 维 克 所 残 害 的 烈 士 ， 而 墨 索 里 尼 本 人 更 是 被 宣 传 塑 造 为 与 凯 撒 、 加 里 波 第 所 并 列 的 意 大 利 民 族 英 雄 。|| 作 为 新 制 度 的 一 部 分 ， 意 大 利 使 工 业 复 兴 公 司 （ I R I ） 恢 复 了 它 在 三 十 年 前 所 能 做 到 的 一 切 ， 甚 至 更 进 一 步 ， 它 不 仅 有 权 为 商 业 部 门 与 银 行 提 供 财 政 援 助 。 同 时 有 权 干 预 工 会 与 农 民 协 会 ， 它 还 有 权 在 “ 国 家 安 全 遭 受 威 胁 ” 的 情 况 下 冻 结 物 价 ， 并 国 有 化 “ 敌 特 产 业 ” 。 新 当 局 还 规 定 ， 商 务 部 门 与 公 司 只 能 通 过 工 会 签 署 劳 务 合 同 ， 且 只 能 雇 佣 工 会 成 员 。|| 在 皮 诺 · 劳 蒂 的 统 治 下 ， 新 意 大 利 沿 着 自 由 主 义 与 共 产 主 义 之 外 的 第 三 条 道 路 前 进 ， 新 政 府 宣 称 自 己 实 现 了 资 本 与 劳 动 间 的 和 解 ， 由 劳 方 代 表 、 资 方 代 表 、 法 西 斯 蒂 代 表 组 成 的 “ 三 位 一 体 ” 式 的 劳 资 合 作 职 团 制 度 得 以 在 全 国 范 围 内 重 建 ， 犹 太 人 被 视 作 “ 非 国 民 ” 大 规 模 驱 逐 出 境 ， 基 于 统 一 的 意 大 利 文 化 与 罗 马 文 化 的 文 化 种 族 主 义 身 份 认 同 建 立 。 残 存 的 共 产 主 义 者 与 自 由 主 义 者 组 建 了 一 些 反 抗 组 织 ， 在 地 下 进 行 着 游 击 活 动 — — 至 于 意 大 利 的 未 来 ， 那 就 只 有 天 知 道 了 … …";
		}
		else if (a.allcountries[85].SubGosstroy == 7 && a.event_done[481])
		{
			text = " 回 归 民 主||意 大 利 的 右 翼 政 府 矛 盾 重 重 ， 各 派 也 根 本 统 一 不 了 意 见 ， 腐 败 与 官 僚 主 义 困 扰 着 这 个 政 府 。 前 政 府 的 抵 抗 军 和 激 进 左 派 的 游 击 队 放 下 了 过 去 的 分 歧 ， 决 定 统 一 战 线 。 在 专 制 政 府 统 治 下 的 民 众 也 不 堪 其 苦 ， 开 始 暗 中 接 触 和 加 入 地 下 反 对 派 。 在 一 场 经 济 危 机 后 爆 发 的 雏 菊 革 命 （ 效 仿 葡 萄 牙 康 乃 馨 革 命 ） 最 终 推 翻 了 专 制 政 府 ， 成 立 了 意 大 利 第 二 共 和 国 ， 新 政 权 开 始 对 右 翼 分 子 进 行 审 判 并 进 行 彻 底 的 去 法 西 斯 化 。 受 够 了 折 腾 的 意 大 利 人 最 终 放 下 了 反 对 派 各 派 的 分 歧 ， 共 同 组 建 全 国 和 解 政 府 ， 在 重 建 民 主 后 ， 将 换 政 于 民 。 意 大 利 似 乎 一 切 重 新 走 向 了 正 轨 … …";
		}
		else if (!a.event_done[401] || a.resultOfEvents[401] >= 3)
		{
			if (a.event_done[398] && a.resultOfEvents[398] < 3)
			{
				if (a.resultOfEvents[398] == 0)
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(128);
					}
					text = string.Format(GlobalScript.inst.new_events_text[1530], "\n");
				}
				else if (a.resultOfEvents[398] != 1)
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(130);
					}
					text = string.Format(GlobalScript.inst.new_events_text[1532], "\n");
				}
				else
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(129);
					}
					text = string.Format(GlobalScript.inst.new_events_text[1531], "\n");
				}
			}
			else if (a.event_done[398] || a.event_done[401])
			{
				text = string.Format(GlobalScript.inst.new_events_text[1538], "\n");
			}
			else if ((GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.influencePRC) || a.empires[1].now_leader != 6)
			{
				text = string.Format(GlobalScript.inst.new_events_text[1533], "\n");
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[1539], "\n");
			}
		}
		else if (a.resultOfEvents[401] == 0)
		{
			text = "纳 塔 同 志 || 严 格 来 说 ， 纳 塔 领 导 下 的 意 大 利 并 未 做 出 多 少 创 举 ， 其 重 点 基 本 在 于 捍 卫 前 代 领 导 人 恩 里 科 · 贝 林 格 所 保 留 的 政 治 遗 产 ， 并 竭 力 将 自 己 塑 造 为 类 似 前 者 的 卡 里 斯 玛 型 领 袖 。 阿 雷 桑 德 罗 · 纳 塔 将 国 内 治 理 重 心 放 在 巩 固 以 博 洛 尼 亚 等 工 业 城 市 为 代 表 的 意 大 利 共 产 党 传 统 选 区 ， 在 拓 展 党 传 媒 、 俱 乐 部 、 图 书 馆 与 工 人 团 体 等 基 层 组 织 同 时 发 展 市 政 事 业 。 经 济 上 则 重 在 引 进 累 进 税 制 、 提 前 退 休 、 南 方 发 展 补 贴 与 一 定 程 度 的 劳 工 保 护 政 策 ， 并 将 其 与 党 发 展 的 社 会 公 益 事 业 实 现 整 合 。 以 达 到 在 有 限 改 革 的 背 景 下 同 时 稳 固 国 内 市 民 与 工 人 阶 级 选 民 基 础 的 作 用 。 他 巧 妙 地 将 “ 意 大 利 社 会 主 义 ” 与 第 二 共 和 国 的 基 本 建 制 逐 渐 混 合 ， 并 通 过 打 击 长 期 困 扰 意 大 利 社 会 的 黑 手 党 与 经 济 犯 罪 问 题 ， 清 算 法 西 斯 主 义 政 治 残 余 重 申 意 大 利 的 民 主 社 会 主 义 国 家 性 质 。 也 就 是 在 纳 塔 治 下 ， 意 大 利 共 和 国 得 以 引 入 比 例 代 表 制 度 、 采 取 封 杀 激 进 主 义 政 党 等 措 施 完 善 政 治 。 从 而 通 过 清 算 传 统 选 举 制 度 ， 解 决 了 第 一 共 和 国 的 许 多 政 治 遗 留 问 题 。 不 过 ， 由 于 纳 塔 政 府 在 推 进 “ 独 立 自 主 ” 与 “ 欧 洲 一 体 化 ” 议 题 上 的 乏 善 可 陈 ， 客 观 上 无 法 改 变 南 北 经 济 发 展 差 距 的 无 能 ， 以 及 经 济 改 革 上 的 调 和 措 施 。 导 致 其 无 法 在 根 本 上 改 变 坐 吃 贝 林 格 遗 产 的 窘 迫 境 地 ： 工 人 阶 级 落 入 政 治 冷 感 ， 市 民 则 再 度 选 择 倒 戈 ， 资 产 阶 级 则 寻 求 机 会 改 组 政 府 。 而 许 多 受 欢 迎 小 政 党 的 创 建 与 右 翼 民 粹 主 义 者 的 崛 起 更 是 构 成 其 连 任 的 最 大 挑 战 — — 也 许 在 不 久 后 ， 意 大 利 共 产 党 将 会 回 到 其 原 有 的 位 置 上 … … ";
		}
		else if (a.resultOfEvents[401] == 2)
		{
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(126);
			}
			text = string.Format(GlobalScript.inst.new_events_text[1529], "\n");
		}
		else
		{
			if (a.resultOfEvents[401] != 1)
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].econ)
				{
					num++;
				}
			}
			if (GlobalScript.inst.gameState.allcountries[85].Gosstroy == 2)
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(125);
				}
				if (GlobalScript.inst.gameState.empires[1].power <= GlobalScript.inst.gameState.empires[0].power || GlobalScript.inst.gameState.empires[1].power <= GlobalScript.inst.gameState.influencePRC || (a.allcountries[1].Gosstroy == 1 && num > 15) || a.empires[1].now_leader != 6)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1528], "\n");
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1534], "\n");
				}
			}
			else
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(124);
				}
				text = string.Format(GlobalScript.inst.new_events_text[1527], "\n");
			}
		}
	}
}
