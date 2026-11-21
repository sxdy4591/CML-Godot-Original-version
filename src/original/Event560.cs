using EventsForDLC;
using UnityEngine;

public class Event560 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 我 们 想 要 大 饼 与 自 由";
		text = string.Concat(new string[4]
		{
			" 8 0 年 代 是 摩 洛 哥 的 困 难 岁 月 ： 债 台 高 筑 和 出 口 导 向 的 经 济 进 一 步 加 深 了 问 题 。 于 债 务 螺 旋 式 的 上 升 ， 进 一 步 破 坏 了 经 济 形 势 ， 外 债 从 1 9 7 2 年 的 9 亿 美 元 上 升 到 1 9 8 3 年 的 1 2 0 亿 美 元 。 漫 长 的 治 安 战 争 ， 支 不 敷 出 的 福 利 项 目 ， 广 为 人 知 的 腐 败 网 络 与 连 续 多 年 的 干 旱 进 一 步 摧 毁 了 这 个 国 家 的 经 济 。 1 9 7 5 年 至 1 9 8 1 间 ， 摩 洛 哥 决 定 进 入 国 际 货 币 组 织 ， 以 寻 求 借 款 来 缓 解 长 期 的 金 融 赤 字 。 计 划 无 非 三 板 斧 ： 休 克 疗 法 ， 多 征 税 和 削 减 补 贴 。 额 外 增 加 的 税 款 有 旅 行 费 （ 针 对 北 部 想 要 前 往 修 达 于 梅 利 利 亚 和 西 班 牙 的 人 征 收 的 额 外 税 款 ） ， 黄 油 的 最 低 价 格 上 涨 了 6 7 % ， 食 糖 的 价 格 增 加 了 1 8 % 。 甚 至 包 括 学 业 税 （ 学 士 学 位 需 要 额 外 支 付 5 0 纳 迪 尔 ， 硕 士 及 以 上 则 是 1 0 0 ） ， 并 取 消 了 大 饼 补 贴 。 一 石 激 起 千 层 浪 ， 而 摩 洛 哥 人 民 早 就 受 够 了 。 1 7 日 ， 纳 多 尔 的 铁 矿 工 人 和 农 民 抗 议 新 增 的 税 款 ， 学 生 也 以 罢 课 回 应 新 的 学 历 税 。 尽 管 安 全 部 队 已 经 部 署 完 毕 ， 且 双 方 仍 然 保 持 相 对 的 克 制 ， 但 未 来 会 发 生 什 么 事 ， 就 不 好 说 了 。||",
			GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
			GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
			"同 志 ， 我 们 总 要 做 点 什 么 ， 对 吧 ？"
		});
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.resultOfEvents[463] == 2 && a.event_done[463] && (!a.allcountries[40].Vyshi || a.allcountries[86].Torg))
		{
			button_text[0] = " 煽 风 点 火 ， 哈 桑 必 须 滚 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 这 个 实 力";
		}
		if (a.data[56] > 1 && a.data[56] < 4 && a.allcountries[86].SubGosstroy == 11)
		{
			button_text[1] = " 建 议 他 展 开 西 班 牙 式 的 改 革";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 社 会 主 义 和 君 主 主 义 ？ 你 在 开 什 么 玩 笑 ！";
		}
		button_text[2] = " 静 待 事 情 起 变 化";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 们 想 要 大 饼 与 自 由";
		if (result_num == 0)
		{
			text = " 在 摩 洛 哥 的 王 朝 陷 入 危 机 的 时 候 ， 我 们 没 有 忘 记 早 日 投 下 的 棋 子 ：";
			if (a.allcountries[54].level_of_dev == 1)
			{
				text += " 我 们 向 摩 洛 哥 社 会 主 义 革 命 党 输 送 了 武 器 。 在 我 们 的 帮 助 下 ， 摩 洛 哥 社 会 主 义 革 命 党 在 各 地 发 动 武 装 反 对 王 室 政 权 的 暴 乱 ， 并 借 着 小 册 子 ， 摄 像 机 和 播 音 喇 叭 向 全 摩 洛 哥 的 城 市 直 播 军 队 惨 无 人 道 屠 杀 平 民 的 画 面 。 在 晚 上 ， 军 队 的 直 升 机 开 始 在 首 府 和 各 大 城 市 的 上 空 盘 旋 。 随 后 在 拉 巴 特 ， 安 全 部 队 向 抗 议 者 开 枪 ， 据 信 使 用 了 达 姆 弹 。 二 十 人 在 交 火 中 死 亡 。 愤 怒 的 群 众 包 围 了 王 宫 和 多 个 军 营 ， “ 铁 拳 ” 突 击 队 打 响 了 反 抗 的 第 一 枪 。 和 平 请 愿 的 运 动 迅 速 演 变 成 了 低 烈 度 的 内 战 ， 得 益 于 左 派 联 盟 扎 根 于 军 队 之 中 ， 大 量 的 军 人 ， 甚 至 包 括 王 室 卫 队 纷 纷 倒 戈 相 向 。 “ 铁 拳 ” 突 击 队 的 成 员 兵 分 两 路 ， 一 路 前 往 拉 巴 特 王 宫 处 死 王 室 ， 另 一 路 则 前 往 摩 洛 哥 电 视 台 ， 以 便 于 公 布 革 命 的 信 息 并 保 证 摩 洛 哥 社 会 主 义 革 命 党 对 新 摩 洛 哥 的 控 制 。人 们 如 往 常 一 样 打 开 电 台 收 听 新 闻 ， 而 电 台 已 被 攻 占 “ 这 里 是 拉 巴 特 ” 播 音 员 清 了 清 嗓 子 ， “ 摩 洛 哥 人 民 共 和 国 的 广 播 电 台 ” 。 与 此 同 时 ， 行 刑 队 已 经 处 死 了 阿 拉 维 王 室 的 全 部 成 员 ， 除 了 正 在 海 外 度 假 的 穆 罕 默 德 六 世 （ 哈 桑 二 世 的 长 子 ） ， 摩 洛 哥 王 朝 已 然 绝 嗣 。 随 后 本 · 赛 义 德 呼 吁 人 民 走 上 街 头 支 持 革 命 ， 他 需 要 群 众 的 支 持 从 而 反 抗 君 主 制 余 孽 。 在 倒 戈 的 卫 士 打 开 王 宫 大 门 后 ， 愤 怒 的 群 众 冲 进 了 王 宫 ， 在 路 上 他 们 遇 到 了 伪 装 成 宫 女 试 图 出 逃 的 王 国 前 首 相 卡 里 姆 · 拉 姆 拉 尼 ， 在 一 番 迅 速 的 批 斗 大 会 后 ， 前 首 相 被     绑 住 双 腿 、 挂 在 自 己 的 豪 华 跑 车 后 拖 拽 致 死 ， 临 死 前 的 他 仍 然 高 呼 着 真 主 ， 众 先 知 甚 至 是 天 使 和 魔 鬼 的 名 字 ， 然 而 于 事 无 补 。 旧 政 权 和 内 阁 大 臣 们 纷 纷 被 逮 捕 。|一 个 以 摩 洛 哥 社 会 主 义 革 命 党 为 执 政 党 的 一 党 制 共 和 国 被 建 立 了 起 来 。 摩 洛 哥 古 老 的 君 主 制 迎 来 了 终 结 ， 他 们 迎 来 了 红 色 的 未 来 。 新 政 府 迅 速 开 展 了 “ 人 人 有 田 种 ， 人 人 有 饭 吃 ” 运 动 ， 并 大 兴 水 利 工 程 和 土 地 再 分 配 项 目 ； 大 量 的 外 资 矿 矿 山 也 被 完 全 国 有 化 ， 要 么 暴 力 征 收 ， 要 么 摩 洛 哥 人 民 矿 业 公 司 占 股 至 少 5 5 % 以 上 。 新 生 的 共 和 国 也 邀 请 我 们 和 阿 尔 巴 尼 亚 同 志 在 建 设 社 会 主 义 上 提 供 同 志 间 的 帮 助 。";
				if (!a.allcountries[18].cw)
				{
					text += " |新 政 府 正 式 放 弃 了 对 西 撒 哈 拉 的 宣 称 ， 西 撒 人 阵 的 步 战 车 进 入 了 首 府 阿 尤 恩 的 市 中 心 。 胜 利 的 旗 帜 飘 扬 在 这 座 古 老 的 城 市 上 空 ， 这 天 也 被 定 为 撒 哈 拉 阿 拉 伯 民 主 共 和 国 的 解 放 日 。 工 人 ， 游 击 战 士 和 农 民 推 着 花 车 ， 举 着 “ 自 由 ， 独 立 ， 社 会 主 义 是 我 们 的 目 标 ” 之 类 的 标 语 牌 走 过 市 中 心 ， 这 片 古 老 的 土 地 焕 发 着 前 所 未 有 的 生 命 力 。";
					GlobalScript.inst.gameState.allcountries[54].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[18].spec = 0;
					GlobalScript.inst.gameState.allcountries[18].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[18].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[18].Torg = true;
					GlobalScript.inst.gameState.influencePRC += 5;
				}
				else
				{
					text += " |新 政 府 正 式 放 弃 了 对 西 撒 哈 拉 的 宣 称 ， 西 撒 人 阵 的 步 战 车 攻 入 了 首 府 阿 尤 恩 的 市 中 心 。 胜 利 的 旗 帜 飘 扬 在 这 座 古 老 的 城 市 上 空 ， 这 天 也 被 定 为 撒 哈 拉 阿 拉 伯 民 主 共 和 国 的 解 放 日 。 工 人 ， 游 击 战 士 和 农 民 推 着 画 有 马 克 思 ， 列 宁 和 毛 泽 东 的 画 像 的 花 车 。 举 着 “ 共 产 主 义 带 来 解 放 ” 之 类 的 标 语 牌 走 过 市 中 心 ， 这 片 古 老 的 土 地 焕 发 着 前 所 未 有 的 生 命 力 。|国 际 观 察 家 认 为 ， 西 撒 人 阵 背 后 的 中 华 人 民 共 和 国 又 一 次 在 国 际 交 锋 中 为 自 己 带 来 了 战 友 和 同 志 。";
					GlobalScript.inst.gameState.allcountries[54].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[18].spec = 0;
					GlobalScript.inst.gameState.allcountries[18].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[18].SubGosstroy = 2;
					GlobalScript.inst.gameState.allcountries[18].Torg = true;
					GlobalScript.inst.gameState.allcountries[18].proprc = true;
					GlobalScript.inst.gameState.influencePRC += 20;
				}
				a.allcountries[54].Gosstroy = 1;
				a.allcountries[54].SubGosstroy = 2;
				a.allcountries[54].LeaveAlliances();
				a.allcountries[54].proprc = true;
				a.allcountries[54].name = " 摩 洛 哥 人 民 共 和 国";
				a.allcountries[54].Torg = true;
				a.empires[1].relations += 50;
				a.empires[0].relations -= 100;
				a.data[8] -= 80;
				a.data[9] -= 100;
				a.data[22] -= 100;
			}
			else
			{
				text += " 晚 上 ， 军 队 的 直 升 机 开 始 在 首 府 和 各 大 城 市 的 上 空 盘 旋 。 随 后 在 拉 巴 特 ， 安 全 部 队 向 抗 议 者 开 枪 ， 据 信 使 用 了 达 姆 弹 。 二 十 人 在 交 火 中 死 亡 。 愤 怒 的 群 众 包 围 了 王 宫 和 多 个 军 营 ， 王 国 政 府 一 边 试 图 保 持 稳 定 ， 一 边 寻 求 谈 判 或 者 武 力 镇 压 的 手 段 。|凌 晨 4 点 3 0 分 时 ， 部 队 开 始 从 四 面 八 方 逼 近 王 宫 前 的 广 场 ， 随 后 部 队 在 示 威 群 众 周 围 1 0 米 处 重 新 部 署 。 先 是 尝 试 说 服 事 先 知 情 的 学 生 领 袖 接 受 他 与 部 队 的 协 议 ， 在 大 约 4 时 3 2 分 内 政 部 长 透 过 学 生 的 广 播 表 示 他 先 行 和 部 队 达 成 谈 判 ， 然 而 许 多 第 一 次 知 道 这 次 会 谈 的 学 生 则 气 愤 地 指 责 他 过 于 胆 怯 。 而 将 以 口 头 表 决 的 方 式 决 定 示 威 学 生 之 后 的 集 体 行 动 。 但 尽 管 “ 坚 守 ” 的 声 音 比 起 “ 撤 离 ” 还 要 来 得 更 加 响 亮 。|奥 斯 曼 看 到 了 机 会 ， 借 此 机 会 ， 他 把 自 己 包 装 成 民 众 利 益 的 代 言 人 ， 强 硬 的 反 君 主 制 民 主 派 。 并 支 持 工 人 的 罢 工 和 抗 议 运 动 ， 甚 至 在 大 众 前 说 出 了 ： “ 同 学 们 ， 我 来 晚 了 ” 之 类 的 明 面 偏 袒 抗 议 者 的 话 。 在 摩 洛 哥 众 议 院 的 特 别 会 议 上 ， 各 个 党 派 就 请 求 哈 桑 二 世 流 亡 海 外 以 平 稳 下 野 的 议 案 得 到 了 高 票 通 过 。 这 位 君 主 在 登 上 飞 机 前 最 后 一 次 饱 含 热 泪 的 亲 吻 了 摩 洛 哥 的 土 地 ， 并 带 走 了 一 块 磷 酸 盐 矿 石 和 一 捧 沙 子 。 在 记 者 面 前 ， 奥 斯 曼 总 理 正 式 宣 布 哈 桑 二 世 被 废 ， 其 子 穆 罕 默 德 六 世 将 继 任 王 位 ， 而 全 国 自 由 人 士 联 盟 也 更 名 为 摩 洛 哥 人 民 自 由 党 ， 成 为 了 新 的 摩 洛 哥 共 和 国 的 执 政 党 。 新 政 府 依 旧 坚 持 过 去 的 立 场 ， 似 乎 什 么 变 了 而 什 么 都 没 变 … …|| 新 政 府 依 然 宣 称 对 西 撒 哈 拉 的 主 权 ， 在 政 权 未 稳 之 时 便 开 始 了 针 对 西 撒 人 阵 的 的 军 事 行 动 。";
				a.allcountries[54].Gosstroy = 3;
				a.allcountries[54].SubGosstroy = 6;
				a.allcountries[54].LeaveAlliances();
				a.allcountries[54].proprc = true;
				a.allcountries[54].name = " 摩 洛 哥 王 国";
				a.allcountries[54].Torg = true;
				a.empires[1].relations -= 50;
				a.empires[0].relations -= 150;
				a.data[8] -= 80;
				a.data[9] -= 100;
				a.data[22] -= 100;
			}
		}
		if (result_num == 1)
		{
			text = " 中 华 人 民 共 和 国 驻 拉 巴 特 的 大 使 向 哈 桑 二 世 送 上 了 我 们 的 信 件 ， 在 信 中 ， 我 们 提 到 了 西 班 牙 改 革 的 成 功 ： “ 西 班 牙 的 卡 洛 斯 王 室 既 能 执 政 ， 又 能 缓 解 矛 盾 ， 何 乐 而 不 为 呢 ？ 中 华 人 民 共 和 国 愿 意 承 担 摩 洛 哥 的 债 务 ， 以 换 取 摩 洛 哥 的 政 治 改 革 。 ”||晚 上 ， 军 队 的 直 升 机 开 始 在 首 府 和 各 大 城 市 的 上 空 盘 旋 。 随 后 在 拉 巴 特 ， 安 全 部 队 向 抗 议 者 开 枪 ， 据 信 使 用 了 达 姆 弹 。 二 十 人 在 交 火 中 死 亡 。 愤 怒 的 群 众 包 围 了 王 宫 和 多 个 军 营 ， 王 国 政 府 一 边 试 图 保 持 稳 定 ， 一 边 寻 求 谈 判 或 者 武 力 镇 压 的 手 段 。||凌 晨 4 点 3 0 分 时 ， 部 队 开 始 从 四 面 八 方 逼 近 王 宫 前 的 广 场 ， 随 后 部 队 在 示 威 群 众 周 围 1 0 米 处 重 新 部 署 。 先 是 尝 试 说 服 事 先 知 情 的 学 生 领 袖 接 受 他 与 部 队 的 协 议 ， 在 大 约 4 时 3 2 分 内 政 部 长 透 过 学 生 的 广 播 表 示 他 先 行 和 部 队 达 成 谈 判 ， 然 而 许 多 第 一 次 知 道 这 次 会 谈 的 学 生 则 气 愤 地 指 责 他 过 于 胆 怯 。 而 将 以 口 头 表 决 的 方 式 决 定 示 威 学 生 之 后 的 集 体 行 动 。 但 尽 管 “ 坚 守 ” 的 声 音 比 起 “ 撤 离 ” 还 要 来 得 更 加 响 亮 ， 不 过 大 约 在 4 时 4 0 分 时 ， 穿 着 迷 彩 服 的 士 兵 冲 向 广 场 上 的 帐 篷 并 且 破 坏 学 生 的 广 播 设 施 ； 而 其 他 部 队 则 殴 打 数 十 名 在 大 本 营 旁 的 学 生 ， 并 且 扣 押 或 者 破 坏 他 们 的 相 机 和 录 音 设 备 。 随 后 士 兵 开 始 强 制 驱 散 在 王 宫 附 近 的 群 众 。||在 电 视 台 的 讲 话 中 ， 哈 桑 二 世 把 抗 议 者 比 做 疯 羊 和 野 蛮 的 柏 柏 尔 人 ， 他 指 控 “ 马 克 思 列 宁 主 义 者 ” 和 邪 恶 的 伊 斯 兰 原 教 旨 主 义 者 煽 动 了 这 场 内 乱 。 但 他 不 得 不 作 出 一 些 让 步 用 于 挽 回 民 心 。 他 决 定 借 鉴 西 班 牙 经 验 ， 撤 换 了 首 相 之 后 ， 他 任 命 了 来 自 摩 洛 哥 人 民 力 量 社 会 主 义 同 盟 的 阿 卜 杜 勒 - 拉 赫 曼 · 优 素 菲 出 任 首 相 。 他 并 不 热 衷 于 结 束 君 主 制 。 新 政 府 开 始 了 更 多 的 工 团 主 义 改 革 ， 并 采 用 了 国 家 资 本 主 义 和 “ 工 人 自 治 ” 的 南 斯 拉 夫 先 进 经 验 。 哈 桑 二 世 也 适 当 的 下 放 了 一 些 权 利 。";
			if ((!a.allcountries[18].cw && !a.allcountries[54].parts[0]) || a.allcountries[54].parts[0])
			{
				text += " 出 乎 意 料 的 是 ， 新 政 府 认 为 西 撒 哈 拉 应 该 成 为 摩 洛 哥 人 民 联 邦 王 国 的 一 个 组 成 部 分 。 优 素 菲 首 相 许 诺 绝 对 的 自 治 权 ， 甚 至 可 以 同 步 加 入 联 合 国 。 再 三 考 量 后 ， 西 撒 人 阵 决 定 放 下 武 器 ， 并 修 改 了 党 章 中 要 求 获 得 完 全 独 立 的 内 容 。 新 的 党 政 不 仅 删 除 了 共 产 主 义 ， 甚 至 接 纳 了 资 本 主 义 和 多 党 合 作 制 。 许 多 同 情 西 撒 人 阵 的 组 织 纷 纷 谴 责 其 背 弃 了 过 去 的 理 想 。 ";
				a.allcountries[54].parts[0] = true;
				a.allcountries[18].LeaveAlliances();
			}
			text += "摩 洛 哥 的 未 来 到 底 会 是 什 么 样 呢 ？";
			a.data[8] -= 100;
			a.allcountries[54].Gosstroy = 2;
			a.allcountries[54].SubGosstroy = 11;
			a.allcountries[54].LeaveAlliances();
			a.allcountries[54].proprc = true;
			a.allcountries[54].name = " 摩 洛 哥 人 民 联 邦 王 国";
			a.allcountries[54].Torg = true;
			a.empires[0].relations -= 100;
			a.data[6] += 50;
		}
		if (result_num == 2)
		{
			text = " 凭 借 着 美 国 驻 军 的 压 力 ， 哈 桑 二 世 的 安 全 部 队 用 暴 力 驱 散 了 抗 议 者 。||晚 上 ， 军 队 的 直 升 机 开 始 在 首 府 和 各 大 城 市 的 上 空 盘 旋 。 随 后 在 拉 巴 特 ， 安 全 部 队 向 抗 议 者 开 枪 ， 据 信 使 用 了 达 姆 弹 。 二 十 人 在 交 火 中 死 亡 。 愤 怒 的 群 众 包 围 了 王 宫 和 多 个 军 营 ， 王 国 政 府 一 边 试 图 保 持 稳 定 ， 一 边 寻 求 谈 判 或 者 武 力 镇 压 的 手 段 。||凌 晨 4 点 3 0 分 时 ， 部 队 开 始 从 四 面 八 方 逼 近 王 宫 前 的 广 场 ， 随 后 部 队 在 示 威 群 众 周 围 1 0 米 处 重 新 部 署 。 先 是 尝 试 说 服 事 先 知 情 的 学 生 领 袖 接 受 他 与 部 队 的 协 议 ， 在 大 约 4 时 3 2 分 内 政 部 长 透 过 学 生 的 广 播 表 示 他 先 行 和 部 队 达 成 谈 判 ， 然 而 许 多 第 一 次 知 道 这 次 会 谈 的 学 生 则 气 愤 地 指 责 他 过 于 胆 怯 。 而 将 以 口 头 表 决 的 方 式 决 定 示 威 学 生 之 后 的 集 体 行 动 。 但 尽 管 “ 坚 守 ” 的 声 音 比 起 “ 撤 离 ” 还 要 来 得 更 加 响 亮 ， 不 过 大 约 在 4 时 4 0 分 时 ， 穿 着 迷 彩 服 的 士 兵 冲 向 广 场 上 的 帐 篷 并 且 破 坏 学 生 的 广 播 设 施 ； 而 其 他 部 队 则 殴 打 数 十 名 在 大 本 营 旁 的 学 生 ， 并 且 扣 押 或 者 破 坏 他 们 的 相 机 和 录 音 设 备 。 随 后 士 兵 开 始 强 制 驱 散 在 王 宫 附 近 的 群 众 。||在 电 视 台 的 讲 话 中 ， 哈 桑 二 世 把 抗 议 者 比 做 疯 羊 和 野 蛮 的 柏 柏 尔 人 ， 他 指 控 “ 马 克 思 列 宁 主 义 者 ” 和 邪 恶 的 伊 斯 兰 原 教 旨 主 义 者 煽 动 了 这 场 内 乱 。 但 他 不 得 不 作 出 一 些 让 步 用 于 挽 回 民 心 。 他 决 定 开 放 党 禁 ， 并 开 除 了 首 相 和 内 务 部 长 。 摩 洛 哥 真 的 进 入 了 新 时 代 吗 ？ ";
		}
	}
}
