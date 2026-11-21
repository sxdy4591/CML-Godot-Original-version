using EventsForDLC;
using UnityEngine;

public class Event661 : EventsSecond
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
		name = " 战 争 结 束 了";
		text = " 在 长 时 间 的 血 腥 冲 突 之 后 “" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + " ” 终 于 结 束 了 。 我 国 外 交 部 密 切 留 意 全 程 ， 并 已 准 备 好 为 您 汇 报 战 争 的 最 终 结 果 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 和 平 万 岁 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 战 争 结 束 了";
		GlobalScript.inst.gameState.ingamewars[81].is_going = false;
		a.allcountries[118].parts[0] = false;
		if (result_num == 0)
		{
			if (GlobalScript.inst.gameState.ingamewars[81].infl2 >= 900)
			{
				if (!a.event_done[660])
				{
					text = "最 终 ， 乌 干 达 民 族 解 放 军 成 功 镇 压 全 国 抵 抗 军 、 乌 干 达 自 由 运 动 等 反 政 府 武 装 ， 取 得 了 反 叛 乱 战 争 的 胜 利 。 卡 伊 拉 早 在 己 方 主 力 部 队 被 击 溃 后 就 流 亡 美 国 ， 全 国 抵 抗 军 所 处 的 卢 韦 罗 三 角 地 带 被 彻 底 征 服 ， 西 北 部 阿 明 残 军 盘 踞 的 西 尼 罗 河 地 区 也 大 半 重 归 政 府 控 制 之 下 ， 部 分 阿 明 余 部 逃 往 扎 伊 尔 与 苏 丹 。 奥 博 特 承 诺 “ 当 前 乌 干 达 的 主 要 任 务 — — 恢 复 法 律 与 秩 序 、 重 建 经 济 、 并 在 道 德 与 心 理 上 重 塑 乌 干 达 人 民 ” 的 第 一 步 已 经 完 成 ， 接 下 来 ， 乌 干 达 “ 将 学 习 坦 桑 尼 亚 的 自 力 更 生 精 神 与 肯 尼 亚 的 同 舟 共 济 政 策 ” ， 进 行 经 济 重 建 工 作 。 然 而 ， 政 府 军 军 人 在 所 有 反 政 府 武 装 活 动 地 区 的 暴 行 在 反 对 派 武 装 消 亡 后 仍 未 改 变 ， 不 管 是 布 干 达 人 、 西 尼 罗 河 人 、 安 科 莱 人 还 是 其 他 支 持 过 反 对 派 的 部 族 都 被 统 统 打 上 了 “ 反 政 府 武 装 同 情 者 ” 的 标 签 ， 劫 掠 、 酷 刑 、 屠 杀 、 强 制 迁 移 依 旧 是 常 态 ， 甚 至 愈 演 愈 烈 。";
					if (a.resultOfEvents[659] == 1)
					{
						a.allcountries[118].proprc = true;
					}
				}
				else
				{
					text = "最 终 ， 奥 凯 洛 政 府 军 与 阿 明 部 队 出 人 意 料 地 挺 过 了 全 国 抵 抗 军 的 攻 势 ， 将 其 主 力 歼 灭 ， 取 得 了 内 战 的 胜 利 ， 全 国 抵 抗 军 残 部 撤 退 回 卢 韦 罗 丛 林 中 。 然 而 ， 旷 日 持 久 的 内 战 导 致 政 府 控 制 力 下 降 到 了 一 个 极 其 微 弱 的 地 步 ， 政 府 军 军 人 在 所 有 反 政 府 武 装 活 动 地 区 的 暴 行 在 反 对 派 武 装 消 亡 后 仍 未 改 变 ， 不 管 是 布 干 达 人 、 安 科 莱 人 还 是 其 他 支 持 过 反 对 派 的 部 族 都 被 统 统 打 上 了 “ 反 政 府 武 装 同 情 者 ” 的 标 签 ， 而 兰 戈 人 也 “ 要 为 奥 博 特 的 暴 行 负 责 ” ， 劫 掠 、 酷 刑 、 屠 杀 、 强 制 迁 移 依 旧 是 常 态 ， 甚 至 愈 演 愈 烈 。 而 失 去 了 能 够 维 系 凝 聚 力 的 外 敌 的 政 府 内 也 很 快 就 内 斗 了 起 来 ， 乌 干 达 自 由 运 动 不 满 军 队 对 布 干 达 人 的 种 族 歧 视 ， 这 使 其 在 镇 压 全 国 抵 抗 军 成 功 后 不 久 遭 到 军 政 府 强 制 解 散 ， 驻 扎 在 坎 帕 拉 城 郊 的 乌 干 达 自 由 运 动 部 队 被 屠 戮 一 空 ， 而 民 主 党 很 快 也 步 其 后 尘 。 乌 干 达 的 未 来 会 如 何 ， 只 有 天 知 道";
					a.allcountries[118].Gosstroy = 0;
					a.allcountries[118].SubGosstroy = 7;
					a.allcountries[118].LeaveAlliances();
					a.allcountries[118].Vyshi = true;
				}
			}
			else if (a.resultOfEvents[659] == 2)
			{
				a.allcountries[118].LeaveAlliances();
				a.allcountries[118].proprc = true;
				a.allcountries[118].Torg = true;
				if (a.modifies[6].active)
				{
					text = " 乌 干 达 或 许 是 世 界 上 最 富 饶 的 国 家 之 一 — — 它 有 着 广 袤 的 土 地 ， 充 足 的 劳 动 力 ， 丰 富 的 自 然 资 源 ， 然 而 ， 殖 民 者 与 受 殖 民 者 控 制 的 后 独 立 时 代 流 氓 资 产 阶 级 领 导 人 的 统 治 将 该 国 变 成 了 一 片 充 斥 着 独 裁 暴 力 、 贪 污 腐 败 与 部 族 主 义 的 土 地 ， 但 好 在 ， 那 都 已 成 为 过 去 式 了 。 随 着 全 国 抵 抗 军 解 放 坎 帕 拉 、 击 败 逃 往 北 部 和 东 部 地 区 的 政 府 军 溃 部 并 最 终 占 领 全 国 ， 一 个 彻 底 摆 脱 新 殖 民 主 义 控 制 的 新 乌 干 达 诞 生 了 。 新 政 府 以 约 韦 里 · 穆 塞 韦 尼 为 总 统 ， 丹 尼 · 纳 布 代 尔 出 任 总 理 。 全 国 抵 抗 运 动 政 府 宣 布 将 以 穆 塞 韦 尼 在 游 击 战 时 制 定 的 十 点 纲 领 为 核 心 进 行 新 民 主 主 义 建 设 ， 没 收 一 切 官 僚 、 买 办 、 地 主 的 资 产 ， 将 主 要 经 济 命 脉 与 土 地 收 归 国 有 ， 以 各 级 抵 抗 委 员 会 为 模 板 建 立 新 的 行 政 体 系 ， 所 有 民 族 一 律 平 等 ， 效 仿 莫 桑 比 克 模 式 在 全 国 各 地 建 立 公 社 村 与 合 作 社 ， 以 消 除 部 族 、 语 言 、 性 别 、 宗 教 与 文 化 上 的 差 异 ， 消 灭 部 族 主 义 与 新 殖 民 主 义 ， 建 立 一 个 “ 与 过 去 新 旧 殖 民 主 义 的 统 治 截 然 不 同 的 社 会 主 义 乌 干 达 ” 。||前 政 府 军 的 残 余 势 力 在 其 组 织 起 的 乌 干 达 人 民 民 主 军 溃 败 后 迅 速 逃 窜 、 分 裂 或 加 入 其 他 团 体 ， 有 的 甚 至 彻 底 同 阿 明 残 军 合 流 ， 乌 干 达 如 雨 后 春 笋 般 涌 现 出 许 多 阿 乔 利 人 的 半 土 匪 式 团 体 ， 不 过 ， 他 们 的 所 作 所 为 注 定 了 这 些 武 装 只 能 成 为 得 不 到 支 持 的 无 根 浮 萍 。||旧 政 权 给 全 国 抵 抗 运 动 政 府 留 下 的 遗 产 ， 是 一 个 残 破 不 堪 的 乌 干 达 ， 经 济 惨 淡 ， 民 生 凋 敝 ， 外 债 累 累 ， 基 础 设 施 荒 废 ， 全 国 上 下 百 废 待 兴 。 为 了 支 援 乌 干 达 的 战 后 重 建 工 作 ， 我 国 向 该 国 提 供 了 一 笔 无 息 贷 款 ， 并 派 驻 了 几 批 医 疗 队 和 工 程 队 ， 坦 桑 尼 亚 、 莫 桑 比 克 等 非 洲 革 命 国 家 也 向 该 国 提 供 了 援 助 。";
					a.allcountries[118].Gosstroy = 1;
					a.allcountries[118].SubGosstroy = 17;
				}
				else
				{
					text = " 乌 干 达 或 许 是 世 界 上 最 富 饶 的 国 家 之 一 — — 它 有 着 广 袤 的 土 地 ， 充 足 的 劳 动 力 ， 丰 富 的 自 然 资 源 ， 然 而 ， 殖 民 者 与 受 殖 民 者 控 制 的 后 独 立 时 代 流 氓 资 产 阶 级 领 导 人 的 统 治 将 该 国 变 成 了 一 片 充 斥 着 独 裁 暴 力 、 贪 污 腐 败 与 部 族 主 义 的 土 地 ， 但 好 在 ， 那 都 已 成 为 过 去 式 了 。 随 着 全 国 抵 抗 军 解 放 坎 帕 拉 、 击 败 逃 往 北 部 和 东 部 地 区 的 政 府 军 溃 部 并 最 终 占 领 全 国 ， 一 个 彻 底 摆 脱 新 殖 民 主 义 控 制 的 新 乌 干 达 诞 生 了 。 约 韦 里 · 穆 塞 韦 尼 出 任 新 总 统 ， 全 国 抵 抗 运 动 政 府 宣 布 将 以 穆 塞 韦 尼 在 游 击 战 时 制 定 的 十 点 纲 领 为 核 心 进 行 民 主 建 设 ， 重 建 民 主 制 度 ， 保 障 公 民 安 全 ， 消 除 一 切 形 式 的 宗 派 主 义 ， 捍 卫 和 巩 固 国 家 独 立 ， 建 设 独 立 、 多 方 面 、 自 给 自 足 的 国 民 经 济 ， 恢 复 和 改 善 社 会 服 务 、 重 建 受 战 争 破 坏 地 区 ， 消 除 腐 败 和 滥 用 权 力 。 为 了 杜 绝 独 立 以 来 乌 干 达 长 期 内 战 、 政 权 频 繁 更 迭 、 社 会 动 荡 和 党 派 林 立 的 现 象 ， 实 现 民 族 和 解 ， 建 立 一 个 基 础 广 泛 的 联 合 政 府 ， 抵 运 政 府 实 行 了 以 抵 运 为 唯 一 执 政 团 体 的 “ 无 党 政 治 ” ， 吸 纳 人 民 大 会 党 、 民 主 党 、 乌 干 达 自 由 运 动 等 国 内 政 治 力 量 的 代 表 进 入 参 加 政 府 。 在 经 济 政 策 上 ， 该 国 实 行 了 混 合 经 济 制 度 ， 向 中 国 学 习 ， 自 力 更 生 ， 充 分 利 用 和 开 发 乌 干 达 资 源 ， 同 时 尽 力 吸 引 外 资 、 争 取 外 援 ， 积 极 与 各 国 开 展 贸 易 ， 促 进 国 内 民 营 资 本 发 展 。 为 了 争 取 到 布 干 达 、 布 尼 奥 罗 等 南 部 地 区 的 支 持 ， 抵 运 还 恢 复 了 乌 干 达 内 部 各 王 国 的 文 化 地 位 ， 传 统 领 袖 只 有 文 化 上 的 地 位 ， 被 明 确 禁 止 染 指 党 派 政 治 活 动 。||旧 政 权 给 全 国 抵 抗 运 动 政 府 留 下 的 遗 产 ， 是 一 个 残 破 不 堪 的 乌 干 达 ， 经 济 惨 淡 ， 民 生 凋 敝 ， 外 债 累 累 ， 基 础 设 施 荒 废 ， 全 国 上 下 百 废 待 兴 。 为 了 支 援 乌 干 达 的 战 后 重 建 工 作 ， 我 国 向 该 国 提 供 了 一 笔 援 助 ， 为 其 制 定 了 经 济 发 展 计 划 ， 并 派 驻 了 几 批 医 疗 队 和 工 程 队 ， 坦 桑 尼 亚 、 肯 尼 亚 、 莫 桑 比 克 等 国 家 也 向 该 国 提 供 了 援 助 。";
					a.allcountries[118].Gosstroy = 2;
					a.allcountries[118].SubGosstroy = 15;
				}
			}
			else if (a.resultOfEvents[659] == 3)
			{
				text = "令 人 难 以 置 信 的 事 情 发 生 了 ！ 倚 仗 于 我 们 的 大 力 援 助 与 扎 伊 尔 的 直 接 干 涉 ， 西 尼 罗 河 的 阿 明 残 部 成 功 打 回 了 坎 帕 拉 ， 再 次 接 管 了 乌 干 达 。 临 时 政 府 由 阿 明 的 左 膀 右 臂 、 恶 名 昭 彰 的 “ 屠 夫 ” — — 艾 萨 克 · 马 里 亚 蒙 古 准 将 领 导 ， 几 天 后 ， 阿 明 也 从 沙 特 阿 拉 伯 返 回 了 乌 干 达 ， 开 始 了 自 己 的 第 二 次 统 治 。 在 此 前 攻 占 北 方 阿 乔 利 人 与 兰 戈 人 地 区 时 ， 阿 明 部 队 便 在 当 地 展 开 了 大 屠 杀 ， 而 在 重 新 控 制 首 都 后 ， 新 政 府 立 即 开 始 了 又 一 次 对 奥 博 特 政 府 的 清 算 ， 搜 刮 的 财 产 被 西 尼 罗 河 士 兵 瓜 分 ， 坎 帕 拉 街 头 被 洗 劫 一 空 ， 大 量 乌 干 达 民 族 解 放 阵 线 成 员 被 处 死 ， 有 的 高 层 干 部 甚 至 被 在 电 视 上 公 开 处 决 。 阿 明 的 归 来 震 惊 了 非 洲 ， 坦 桑 尼 亚 强 烈 谴 责 新 阿 明 政 府 的 血 腥 行 动 与 扎 伊 尔 的 干 涉 ， 宣 布 不 承 认 新 政 府 ， 并 再 次 资 助 流 亡 者 组 织 起 武 装 反 攻 乌 干 达 。 刚 从 阿 明 时 代 的 灾 难 中 蹒 跚 走 出 的 乌 干 达 被 重 新 拖 回 了 深 渊 之 中 … …";
				a.allcountries[118].LeaveAlliances();
				a.allcountries[118].proprc = true;
				a.allcountries[118].Torg = true;
				a.allcountries[118].Gosstroy = 0;
				a.allcountries[118].SubGosstroy = 9;
			}
			else if (a.resultOfEvents[659] == 4)
			{
				int num = 0;
				if (a.allcountries[127].Gosstroy == 3 || a.IsAuthoritarianism(127))
				{
					num++;
				}
				if (a.allcountries[126].Gosstroy == 3 || a.IsAuthoritarianism(126))
				{
					num++;
				}
				if (a.allcountries[123].Gosstroy == 3 || a.IsAuthoritarianism(123))
				{
					num++;
				}
				if (a.allcountries[122].Gosstroy == 3 || a.IsAuthoritarianism(122))
				{
					num++;
				}
				if (a.allcountries[124].Gosstroy == 3 || a.IsAuthoritarianism(124))
				{
					num++;
				}
				text = "乌 干 达 的 血 腥 内 战 以 一 位 出 人 意 料 的 选 手 的 胜 利 拉 上 了 帷 幕 。 由 于 政 府 军 接 连 惨 败 于 反 对 派 武 装 ， 蒂 托 · 奥 凯 洛 与 巴 西 里 奥 · 奥 凯 洛 等 阿 乔 利 人 军 官 宣 布 跳 反 ， 支 持 乌 干 达 自 由 运 动 一 方 ， 带 领 自 己 下 属 的 部 队 从 古 卢 出 发 向 坎 帕 拉 进 军 。 最 后 ， 在 两 方 的 夹 击 下 ， 以 乌 干 达 自 由 运 动 为 首 的 布 干 达 人 武 装 拿 下 了 整 个 布 干 达 地 区 ， 并 乘 胜 追 击 ， 将 布 尼 奥 罗 、 安 科 莱 、 托 罗 罗 等 其 他 南 部 各 前 王 国 的 领 土 收 入 囊 中 ， 最 终 在 阿 乔 利 人 军 队 的 支 持 下 控 制 了 全 国 大 部 分 地 区 。||";
				if (num >= 2)
				{
					text += "在 新 政 府 随 后 举 行 的 大 选 中 ， 由 于 有 着 布 干 达 人 的 支 持 ， 保 守 党 一 举 拨 得 了 头 筹 ， 与 乌 干 达 自 由 运 动 组 成 联 合 政 府 。 新 政 府 由 安 德 鲁 · 卡 伊 拉 任 总 理 ， 马 扬 加 · 恩 坎 吉 任 总 统 ， 蒂 托 · 奥 凯 洛 任 国 防 部 长 。 新 政 府 宣 布 将 在 乌 干 达 恢 复 民 主 、 铲 除 腐 败 、 结 束 内 乱 ， 并 推 行 联 邦 化 改 革 、 复 辟 布 干 达 君 主 制 。 在 保 守 党 政 府 上 台 后 不 久 就 颁 布 的 新 宪 法 中 ， 乌 干 达 国 名 正 式 改 为 乌 干 达 联 邦 ， 新 宪 法 规 定 了 乌 干 达 联 邦 是 一 个 由 南 方 布 干 达 、 布 尼 奥 罗 、 托 罗 、 安 科 莱 四 王 国 与 北 方 各 州 组 成 的 联 邦 制 君 主 国 ， 各 邦 王 室 在 自 己 的 王 国 内 享 有 政 治 特 权 ， 最 高 元 首 在 四 王 国 君 主 选 出 ， 任 期 四 年 ， 可 无 限 制 连 任 。 布 干 达 先 王 穆 特 布 二 世 的 儿 子 穆 文 达 · 穆 特 比 二 世 加 冕 成 为 布 干 达 卡 巴 卡 （ 国 王 ） 与 第 一 任 乌 干 达 联 邦 最 高 元 首 。 当 然 ， 这 很 快 就 使 新 政 权 遭 到 了 北 方 人 、 非 布 干 达 的 南 方 人 、 布 干 达 天 主 教 徒 与 穆 斯 林 的 激 烈 反 对 ， 而 阿 乔 利 人 军 队 内 部 也 由 于 利 益 分 配 、 军 队 合 并 问 题 和 新 政 府 政 策 而 产 生 了 分 歧 ， 部 分 阿 乔 利 军 官 与 阿 明 残 部 联 合 成 立 了 乌 干 达 人 民 民 主 军 ， 掀 起 了 对 新 政 府 的 叛 乱 。 总 之 ， 新 政 权 总 归 比 奥 博 特 好 … … 大 概 ？";
					a.allcountries[118].LeaveAlliances();
					a.allcountries[118].Vyshi = true;
					a.allcountries[118].Torg = true;
					a.allcountries[118].Gosstroy = 3;
					a.allcountries[118].SubGosstroy = 12;
					a.allcountries[118].name = "乌 干 达 联 邦";
				}
				else
				{
					text += "在 新 政 府 随 后 举 行 的 大 选 中 ， 由 于 有 着 阿 乔 利 人 （ 绝 大 部 分 是 天 主 教 徒 ） 主 导 的 前 政 府 军 与 布 干 达 人 的 支 持 ， 民 主 党 一 举 拨 得 了 头 筹 ， 与 乌 干 达 自 由 运 动 组 成 联 合 政 府 。 新 政 府 由 安 德 鲁 · 卡 伊 拉 任 总 理 ， 保 罗 · 塞 莫 格 雷 雷 任 总 统 ， 蒂 托 · 奥 凯 洛 任 国 防 部 长 。 新 政 府 宣 布 将 在 乌 干 达 恢 复 民 主 、 铲 除 腐 败 、 结 束 内 乱 ， 并 维 护 乌 干 达 作 为 单 一 制 统 一 国 家 的 身 份 。 民 主 党 政 府 还 加 大 了 经 济 私 有 化 与 引 入 外 国 资 本 的 力 度 ， 积 极 鼓 励 外 国 投 资 ， 很 快 便 与 I M F 与 世 界 银 行 签 订 了 几 份 合 同 。 当 然 ， 北 方 新 教 徒 、 非 布 干 达 的 南 方 人 与 穆 斯 林 并 不 乐 意 布 干 达 人 主 导 国 政 ， 而 许 多 布 干 达 人 也 对 这 个 与 过 去 历 届 政 府 一 样 反 对 布 干 达 自 治 且 反 君 主 制 的 政 府 心 怀 不 满 。 总 之 ， 新 政 权 总 归 比 奥 博 特 好 … … 大 概 ？";
					a.allcountries[118].LeaveAlliances();
					a.allcountries[118].Torg = true;
					a.allcountries[118].Gosstroy = 3;
					a.allcountries[118].SubGosstroy = 5;
				}
			}
			else
			{
				text = "乌 干 达 或 许 是 世 界 上 最 富 饶 的 国 家 之 一 — — 它 有 着 广 袤 的 土 地 ， 充 足 的 劳 动 力 ， 丰 富 的 自 然 资 源 ， 然 而 ， 殖 民 者 与 受 殖 民 者 控 制 的 后 独 立 时 代 流 氓 资 产 阶 级 领 导 人 的 统 治 将 该 国 变 成 了 一 片 充 斥 着 独 裁 暴 力 、 贪 污 腐 败 与 部 族 主 义 的 土 地 ， 但 好 在 ， 那 都 已 成 为 过 去 式 了 。 随 着 全 国 抵 抗 军 解 放 坎 帕 拉 、 击 败 逃 往 北 部 和 东 部 地 区 的 政 府 军 溃 部 并 最 终 占 领 全 国 ， 一 个 彻 底 摆 脱 新 殖 民 主 义 控 制 的 新 乌 干 达 诞 生 了 。 约 韦 里 · 穆 塞 韦 尼 出 任 新 总 统 ， 全 国 抵 抗 运 动 政 府 宣 布 将 以 穆 塞 韦 尼 在 游 击 战 时 制 定 的 十 点 纲 领 为 核 心 进 行 民 主 建 设 ， 重 建 民 主 制 度 ， 保 障 公 民 安 全 ， 消 除 一 切 形 式 的 宗 派 主 义 ， 捍 卫 和 巩 固 国 家 独 立 ， 建 设 独 立 、 多 方 面 、 自 给 自 足 的 国 民 经 济 ， 恢 复 和 改 善 社 会 服 务 、 重 建 受 战 争 破 坏 地 区 ， 消 除 腐 败 和 滥 用 权 力 。 为 了 杜 绝 独 立 以 来 乌 干 达 长 期 内 战 、 政 权 频 繁 更 迭 、 社 会 动 荡 和 党 派 林 立 的 现 象 ， 实 现 民 族 和 解 ， 建 立 一 个 基 础 广 泛 的 联 合 政 府 ， 抵 运 政 府 实 行 了 以 抵 运 为 唯 一 执 政 团 体 的 “ 无 党 政 治 ” ， 吸 纳 人 民 大 会 党 、 民 主 党 、 乌 干 达 自 由 运 动 等 国 内 政 治 力 量 的 代 表 进 入 参 加 政 府 。 在 经 济 政 策 上 ， 该 国 实 行 了 混 合 经 济 制 度 ， 自 力 更 生 ， 充 分 利 用 和 开 发 乌 干 达 资 源 ， 同 时 尽 力 吸 引 外 资 、 争 取 外 援 ， 积 极 与 各 国 开 展 贸 易 ， 促 进 国 内 民 营 资 本 发 展 。 为 了 争 取 到 布 干 达 、 布 尼 奥 罗 等 南 部 地 区 的 支 持 ， 抵 运 还 恢 复 了 乌 干 达 内 部 各 王 国 的 文 化 地 位 ， 传 统 领 袖 只 有 文 化 上 的 地 位 ， 被 明 确 禁 止 染 指 党 派 政 治 活 动 。||旧 政 权 给 全 国 抵 抗 运 动 政 府 留 下 的 遗 产 ， 是 一 个 残 破 不 堪 的 乌 干 达 ， 经 济 惨 淡 ， 民 生 凋 敝 ， 外 债 累 累 ， 基 础 设 施 荒 废 ， 全 国 上 下 百 废 待 兴 。";
				a.allcountries[118].Gosstroy = 2;
				a.allcountries[118].SubGosstroy = 15;
			}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
