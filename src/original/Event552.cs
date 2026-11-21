using EventsForDLC;
using UnityEngine;

public class Event552 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 加 速 发 展 战 略 ？";
		text = " 即 便 是 在 尤 里 · 安 德 罗 波 夫 的 执 政 期 间 ， 就 已 经 有 相 当 数 量 的 经 济 与 社 会 学 家 被 赋 予 推 进 苏 联 经 济 改 革 的 “ 全 权 许 可 ” 。 其 中 的 一 份 关 键 文 件 《 新 西 伯 利 亚 宣 言 》 指 出 ： “ 苏 联 社 会 内 的 生 产 关 系 与 目 前 生 产 力 的 发 展 存 在 显 著 滞 后 ” 。 该 文 件 的 作 者 如 此 定 义 苏 联 国 民 经 济 内 的 其 中 某 项 关 键 问 题 ， 即 “ 抓 行 政 的 手 腕 将 纯 粹 的 经 济 管 理 扼 地 太 死 ， 且 集 权 的 管 理 方 式 压 过 了 分 权 的 政 策 ” 。 在 过 去 的 数 十 年 间 ， 苏 联 的 经 济 增 长 率 明 显 放 缓 ， 工 业 发 展 不 均 衡 的 现 象 也 越 加 严 重 ； 由 于 缺 少 消 费 品 ， 工 人 对 劳 动 生 产 的 结 果 毫 无 兴 致 。 最 重 要 的 是 ， 即 便 该 国 存 在 巨 额 投 资 ， 但 目 前 投 入 生 产 的 固 定 资 产 仍 在 迅 速 老 化 ， 可 新 技 术 的 引 进 依 然 滞 后 。 对 此 ， 苏 联 经 济 学 家 们 确 实 认 为 ， 到 了 必 须 做 出 改 变 的 时 刻 。 为 此 ， 他 们 将 在 接 下 来 举 行 的 苏 共 中 央 四 月 全 会 上 抛 出 对 应 的 解 决 方 案 ， 这 将 成 为 接 下 来 主 导 该 国 经 济 生 活 的 主 旋 律 。 最 终 ， 苏 共 党 内 批 准 了 所 谓 “ 加 速 发 展 战 略 ” — — 其 基 本 构 思 与 华 国 锋 曾 筹 划 的 “ 洋 跃 进 ” 计 划 ， 以 及 罗 马 尼 亚 、 波 兰 等 政 权 7 0 年 代 推 行 的 “ 外 债 社 会 主 义 ” 颇 有 类 似 之 处 ： 国 家 将 一 次 性 扩 大 进 口 与 预 算 支 出 ， 为 国 内 制 造 业 企 业 更 新 技 术 与 扩 大 产 量 拨 付 巨 额 款 项 ， 从 而 实 现 苏 联 机 械 工 程 的 跨 越 发 展 ， 相 关 支 出 则 通 过 复 兴 的 制 造 业 筹 款 获 利 。 预 计 该 计 划 需 要 在 短 短 五 年 内 完 成 苏 联 机 械 工 程 的 大 跃 进 ， 以 达 到 世 界 级 水 平 。 新 任 领 导 人 戈 尔 巴 乔 夫 则 如 此 形 容 这 一 宏 大 计 划 ： “ 我 们 得 通 过 广 泛 运 用 科 技 革 命 最 新 成 果 ， 让 社 会 主 义 经 济 制 度 契 合 当 今 模 式 ， 满 足 当 代 所 需 。 因 此 ， 我 们 必 须 实 现 社 会 经 济 领 域 的 显 著 跃 进 ， 除 此 之 外 别 无 他 法 。 其 中 尤 其 是 要 以 钢 为 纲 ， 发 展 得 要 机 械 工 程 排 头 带 。 在 接 下 来 的 2 5 年 内 ， 我 们 必 须 得 让 工 业 产 值 增 长 率 增 长 1 . 5 倍 或 翻 番 ， 中 心 任 务 是 加 紧 生 产 新 一 代 机 械 设 备 。 以 鸟 枪 换 炮 的 形 式 实 现 引 进 先 进 技 术 ， 显 著 提 高 劳 动 生 产 率 与 资 本 生 产 率 ， 乃 至 减 少 原 料 浪 费 等 多 个 目 标 ” ； 这 就 事 实 上 向 国 际 社 会 表 明 了 苏 联 经 济 内 存 在 的 问 题 ， 以 及 其 试 图 发 展 外 向 型 经 济 的 渴 望 。 作 为 世 界 经 济 的 主 要 参 与 者 ， 我 们 多 少 可 以 因 势 利 导 ， 让 苏 联 新 任 领 导 人 的 改 革 计 划 成 为 我 国 获 利 的 契 机 ： 我 们 既 可 以 向 苏 方 探 出 呼 吁 扩 大 合 作 的 橄 榄 枝 ， 以 引 荐 技 术 与 输 送 技 术 人 员 的 方 式 深 化 双 方 间 的 经 贸 往 来 ， 并 借 机 将 我 们 的 线 人 以 交 流 名 义 安 插 在 该 国 中 ， 为 未 来 的 计 划 做 准 备 ； 也 可 以 试 着 在 国 际 社 会 内 造 势 ， 呼 吁 其 他 国 家 抵 制 苏 联 倡 议 ， 以 软 封 锁 方 式 使 其 经 济 计 划 流 产 ， 从 而 给 本 就 疲 软 的 苏 联 经 济 踩 下 刹 车 ； 又 或 者 ， 最 好 的 办 法 是 效 法 美 国 与 国 际 货 币 基 金 组 织 的 先 进 经 验 ， 实 施 “ 援 助 换 改 革 ” 的 计 划 … … 不 论 如 何 ， 决 定 权 在 你 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		int num = 0;
		if (a.allcountries[21].proprc)
		{
			num++;
		}
		if (a.allcountries[85].proprc)
		{
			num++;
		}
		if (a.allcountries[86].proprc)
		{
			num++;
		}
		if (a.allcountries[87].proprc)
		{
			num++;
		}
		if (a.allcountries[92].proprc)
		{
			num++;
		}
		int num2 = 0;
		if (a.allcountries[2].proprc)
		{
			num2++;
		}
		if (a.allcountries[3].proprc)
		{
			num2++;
		}
		if (a.allcountries[4].proprc)
		{
			num2++;
		}
		if (a.allcountries[6].proprc)
		{
			num2++;
		}
		if (a.allcountries[5].proprc)
		{
			num2++;
		}
		kolvo_variant = 5;
		if (a.data[12] >= 1000 && a.data[13] >= 1000 && a.data[68] >= 1000 && a.influencePRC >= a.empires[1].power && a.influencePRC >= 750)
		{
			button_text[0] = " 我 们 当 然 会 给 戈 尔 巴 乔 夫 先 生 为 苏 联 经 济 “ 踩 下 油 门 ” 的 机 会 … … 毕 竟 ， 中 苏 友 谊 万 古 长 青 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 你 是 在 说 笑 吗 ， 苏 联 人 绝 不 可 能 考 虑 这 个 提 议 ！";
		}
		if (num >= 3 && a.allcountries[1].econ && a.influencePRC >= a.empires[1].power && a.influencePRC >= 750)
		{
			button_text[1] = " 好 机 会 ！ 我 们 将 同 我 国 合 作 伙 伴 一 同 行 动 。 让 苏 联 经 济 改 革 胎 死 腹 中 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 拿 什 么 来 封 锁 苏 联 ？ 那 些 四 处 流 窜 的 毛 派 游 击 队 吗 ？";
		}
		if (a.allcountries[51].Torg && a.allcountries[51].dev == 1 && a.data[56] >= 3)
		{
			button_text[2] = " 新 方 针 ？ 看 来 有 必 要 与 我 们 的 美 国 朋 友 一 起 讨 论 对 策 … …";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 美 国 怎 么 可 能 与 我 们 步 调 一 致 呢 ！ ";
		}
		if (num >= 3 && num2 >= 3 && a.allcountries[1].econ && a.influencePRC >= a.empires[1].power && a.influencePRC >= 750)
		{
			button_text[3] = " 我 们 将 开 出 戈 尔 巴 乔 夫 绝 不 会 拒 绝 的 提 议 … … 清 党 与 腾 笼 换 鸟 的 时 候 到 了 … …";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 这 是 对 苏 联 内 政 的 激 进 干 涉 ！ ";
		}
		button_text[4] = " 静 观 局 势 演 变";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 加 速 发 展 战 略 ？";
		if (result_num == 0)
		{
			text = " 今 天 上 午 ， 中 国 驻 苏 联 大 使 会 见 了 米 哈 伊 尔 · 戈 尔 巴 乔 夫 ， 并 代 表 我 们 向 苏 联 提 供 一 份 利 润 颇 丰 的 合 资 企 业 经 营 与 技 术 转 让 协 定 ； 与 此 同 时 ， 中 国 还 将 在 国 际 上 扮 演 双 方 交 易 间 的 中 间 人 ， 为 苏 联 引 进 技 术 寻 找 卖 家 。 戈 尔 巴 乔 夫 则 代 表 全 体 苏 联 人 民 对 我 们 表 示 诚 挚 的 感 谢 ， 并 顺 势 扩 大 了 与 我 国 的 经 贸 往 来 。 由 此 在 事 实 上 完 全 结 束 了 中 苏 对 峙 的 冷 淡 时 期 。 我 国 技 术 人 员 与 线 人 也 得 以 借 由 经 济 交 流 的 名 义 进 入 苏 联 ， 在 当 地 拓 展 我 国 影 响 力 。 当 然 ， 交 流 是 双 向 的 — — 苏 联 改 革 的 新 思 维 也 顺 着 这 条 人 脉 渠 道 自 然 而 然 地 流 入 我 国 ， 并 引 起 相 应 的 呼 应 。 国 际 社 会 已 对 中 国 的 “ 新 一 轮 经 济 扩 张 ” 意 见 纷 纷 。";
			a.relres = true;
			a.allcountries[7].Torg = true;
			a.empires[1].relations += 200;
			a.empires[0].relations -= 100;
			a.SOV_PRC_PartiesConnection += 250;
			a.data[8] += 150;
			a.data[9] -= 150;
			a.data[11] -= 8000;
			a.data[12] -= 100;
			a.data[68] -= 100;
			a.data[4] += 50;
			a.influencePRC += 30;
			a.empires[1].power += 50;
			a.empires[1].money -= 150;
			GlobalScript.inst.gameState.empires[1].leaders[6].support += 2;
		}
		if (result_num == 1)
		{
			if (!a.allcountries[0].isEU && !a.allcountries[0].isNATO)
			{
				text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 在 政 治 局 内 部 会 议 上 决 定 以 苏 联 经 济 改 革 问 题 借 题 发 挥 ， 联 合 我 们 的 国 际 盟 友 一 起 “ 落 井 下 石 ” ： 经 济 合 作 组 织 成 员 一 致 决 定 抬 高 经 济 壁 垒 ， 并 建 立 了 联 合 限 制 苏 联 产 业 引 进 的 “ 上 海 统 筹 委 员 会 ” 。 苏 联 在 欧 洲 的 贸 易 伙 伴 也 积 极 响 应 ， 加 入 到 围 堵 该 国 的 包 围 网 中 。 最 终 导 致 苏 联 对 外 引 进 技 术 的 声 势 寥 寥 ， 基 本 找 不 到 可 靠 卖 家 … … 加 速 发 展 战 略 本 身 就 此 胎 死 腹 中 。 苏 联 领 导 人 不 得 不 寻 求 其 他 办 法 ， 以 重 新 激 活 该 国 经 济 ： 目 前 来 看 ， 戈 尔 巴 乔 夫 集 团 还 是 选 择 了 相 对 成 本 最 低 的 办 法 。 即 恢 复 安 德 罗 波 夫 加 强 劳 动 纪 律 ， 拴 紧 螺 丝 的 系 列 政 策 。 相 关 学 者 辩 称 ， 苏 联 劳 动 生 产 率 低 下 是 劳 动 纪 律 废 弛 的 客 观 结 果 、 搞 整 顿 有 助 于 恢 复 生 产 、 降 低 机 械 停 机 率 与 次 品 产 出 率 。 旨 在 为 国 民 经 济 带 来 劳 动 纪 律 与 秩 序 的 运 动 预 计 会 带 来 积 极 结 果 。 预 计 国 民 收 入 将 增 长 3 % ， 而 工 业 产 出 将 提 高 4 % 。 诚 然 ， 某 些 地 区 也 因 此 产 生 了 些 过 激 措 施 （ 例 如 在 工 作 日 内 突 击 检 查 电 影 院 与 商 铺 ， 甚 至 和 简 单 的 聚 会 不 对 付 ； 在 此 期 间 ， 所 有 无 批 准 或 无 故 缺 勤 的 人 都 会 被 拘 留 以 “ 确 认 成 分 ” ） 然 而 ， 上 述 行 政 手 段 能 在 多 大 程 度 解 决 该 国 经 济 的 结 构 性 问 题 ？ 这 一 疑 问 仍 悬 而 未 决 。";
				a.influencePRC += 20;
			}
			else
			{
				text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 在 政 治 局 内 部 会 议 上 决 定 以 苏 联 经 济 改 革 问 题 借 题 发 挥 ， 联 合 我 们 的 国 际 盟 友 一 起 “ 落 井 下 石 ” ： 经 济 合 作 组 织 成 员 一 致 决 定 抬 高 经 济 壁 垒 ， 并 建 立 了 联 合 限 制 苏 联 产 业 引 进 的 “ 上 海 统 筹 委 员 会 ” 。 苏 联 在 欧 洲 的 贸 易 伙 伴 也 积 极 响 应 ， 加 入 到 围 堵 该 国 的 包 围 网 中 。 最 终 导 致 苏 联 对 外 引 进 技 术 的 声 势 寥 寥 ， 基 本 找 不 到 除 美 国 外 的 可 靠 卖 家 … … 当 然 ， 若 不 是 美 国 开 出 价 码 ， 玩 了 出 熟 悉 的 “ 援 助 换 改 革 ” 。 “ 加 速 发 展 战 略 ” 或 许 真 将 胎 死 腹 中 ： 苏 联 扩 大 了 企 业 自 治 概 念 的 适 用 范 围 ， 稍 稍 放 松 了 外 贸 壁 垒 、 为 美 国 消 费 品 与 美 苏 合 资 企 业 的 经 营 让 路 ； 乃 至 在 外 交 政 策 上 实 行 缓 和 退 让 。 国 家 计 划 委 员 会 则 开 始 洗 牌 ， 老 牌 干 部 拜 巴 科 夫 不 得 不 因 自 己 在 该 战 线 上 的 缺 乏 创 举 而 下 马 ， 换 上 以 雷 日 科 夫 为 代 表 的 改 革 人 士 们 。 保 守 派 已 开 始 借 题 发 挥 ， 批 判 戈 尔 巴 乔 夫 放 弃 社 会 主 义 的 建 设 成 就 。 并 开 始 尝 试 采 取 反 制 … …";
				a.influencePRC += 10;
				a.empires[0].power += 30;
			}
			a.relres = false;
			a.allcountries[7].Torg = false;
			a.allcountries[7].SubGosstroy = 1;
			a.SOV_PRC_PartiesConnection -= 50;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.influencePRC += 20;
			a.empires[1].relations -= 250;
			a.empires[0].relations += 50;
			a.empires[1].power -= 200;
			a.empires[0].power += 10;
			a.empires[1].money -= 150;
			a.empires[0].money += 150;
			GlobalScript.inst.gameState.empires[1].leaders[6].support--;
		}
		if (result_num == 2)
		{
			text = " 我 们 很 快 便 同 华 盛 顿 达 成 策 应 ， 并 共 同 筹 备 了 对 苏 提 供 技 术 出 口 的 的 联 合 法 案 ： 美 国 与 中 国 将 联 动 其 国 际 盟 友 共 同 为 苏 联 的 “ 加 速 发 展 战 略 ” 提 供 签 署 技 术 引 进 与 设 备 转 让 的 机 会 ， 并 将 派 遣 工 程 师 协 助 苏 联 工 人 掌 握 相 应 设 备 ； 当 然 ， 所 有 的 这 一 切 都 需 要 相 应 的 筹 码 ： 几 乎 是 在 戈 尔 巴 乔 夫 与 我 们 达 成 协 定 的 同 时 ， 他 便 开 始 实 行 套 新 方 针 。 苏 联 经 济 体 制 也 就 标 榜 所 谓 “ 新 时 代 的 新 经 济 政 策 ” ， 加 速 向 卡 达 尔 主 义 与 南 斯 拉 夫 铁 托 主 义 的 构 型 转 变 ： 该 国 各 地 的 企 业 均 建 立 了 工 人 委 员 会 ， 并 参 与 到 拟 定 计 划 的 讨 论 中 （ 即 便 目 前 仅 行 使 咨 询 权 ） ， 并 在 同 时 提 供 改 进 生 产 流 程 的 方 法 （ 在 此 次 被 赋 予 全 权 ） 。 各 地 董 事 的 财 政 自 主 权 得 到 了 提 升 ， 还 在 “ 荣 誉 墙 ” 与 证 书 之 外 ， 引 入 了 对 工 人 的 物 质 激 励 。 即 便 改 革 目 前 规 模 有 限 ， 且 一 切 都 在 “ 试 验 ” 的 框 架 下 束 手 束 脚 地 开 展 。 对 “ 集 体 农 庄 ” 市 场 与 “ 合 作 社 ” 产 品 销 售 的 控 制 还 是 显 著 削 弱 ， 连 带 着 “ 法 萨 ” （ 苏 联 地 下 市 场 的 一 种 交 易 形 式 ， 主 要 转 手 销 售 国 外 商 品 ） 都 被 去 罪 化 。 从 而 丰 富 了 该 国 自 筹 资 金 与 繁 荣 商 品 市 场 的 方 式 … … 以 叶 戈 尔 · 盖 达 尔 、 阿 纳 托 利 · 丘 拜 斯 为 代 表 的 青 年 经 济 学 家 群 体 开 始 在 苏 联 政 界 发 光 发 热 ， 事 实 上 为 该 国 向 市 场 社 会 主 义 方 向 进 行 改 革 开 了 口 子 — — 下 一 步 自 然 便 是 政 治 平 反 与 基 于 活 跃 社 会 团 体 改 革 苏 维 埃 体 制 ， 引 入 独 立 候 选 人 与 扩 大 代 表 性 。 谁 知 道 未 来 会 如 何 ？ 当 然 ， 一 个 开 放 的 苏 联 自 然 对 我 们 有 利 。 我 们 的 合 资 企 业 已 开 始 走 入 该 国 境 内 ， 赚 取 宝 贵 的 利 润 。";
			a.relres = true;
			a.allcountries[7].Torg = true;
			a.allcountries[7].prosov = false;
			a.allcountries[7].Gosstroy = 2;
			a.allcountries[7].SubGosstroy = 8;
			a.empires[1].relations += 100;
			a.empires[0].relations += 150;
			a.SOV_PRC_PartiesConnection += 250;
			a.data[8] += 50;
			a.data[9] -= 150;
			a.data[11] -= 4000;
			a.data[12] -= 50;
			a.data[68] -= 50;
			a.data[4] += 100;
			a.influencePRC += 20;
			a.empires[0].power += 100;
			a.empires[1].money -= 150;
			a.empires[0].money += 100;
			GlobalScript.inst.gameState.empires[1].leaders[6].support++;
		}
		if (result_num == 3)
		{
			text = " 今 天 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 召 见 了 苏 联 驻 华 大 使 ， 并 让 他 转 交 给 米 哈 伊 尔 · 戈 尔 巴 乔 夫 一 封 信 。 信 中 提 议 称 ， 苏 联 将 以 近 乎 免 费 的 价 格 从 中 国 获 得 “ 其 所 想 要 的 一 切 ” ， 这 甚 至 足 以 让 苏 联 将 原 本 应 投 入 至 “ 加 速 发 展 战 略 ” 技 术 改 进 的 宝 贵 预 算 挪 至 其 他 项 目 ， 如 基 于 改 进 劳 动 纪 律 的 反 酗 酒 运 动 ： 中 国 开 出 的 价 码 包 括 但 不 限 于 来 自 北 京 的 巨 额 投 资 、 稳 定 的 中 苏 贸 易 协 定 、 建 设 中 苏 合 资 企 业 的 计 划 、 以 及 持 之 以 恒 的 技 术 转 让 与 专 员 交 流 计 划 。 考 虑 到 经 济 互 助 委 员 会 的 国 际 分 工 与 一 体 化 方 案 越 来 越 流 于 表 面 ， 苏 联 与 西 方 的 贸 易 事 实 上 得 看 中 国 脸 色 ， 乃 至 中 国 经 济 集 团 占 据 全 球 经 济 半 壁 江 山 ， 不 得 不 作 为 最 佳 合 作 伙 伴 的 现 实 。 戈 尔 巴 乔 夫 当 然 会 不 择 手 段 抓 住 这 一 机 会 ： 但 要 知 道 ， “ 无 价 ” 在 中 文 语 境 内 还 有 “ 无 价 之 宝 ” 的 含 义 — — 条 件 是 苏 联 我 们 名 单 上 的 各 类 著 名 异 见 者 完 全 平 反 、 甚 至 考 虑 给 他 们 专 设 苏 联 最 高 苏 维 埃 配 额 席 位 ； 同 时 ， 苏 联 还 需 在 柯 西 金 改 革 的 基 础 上 扩 大 并 进 一 步 落 实 工 人 自 治 权 ， 并 在 此 期 间 默 许 工 人 的 夺 厂 与 罢 工 自 由 ， 实 现 更 进 一 步 的 政 治 自 由 化 。 | 为 了 稍 稍 缓 和 戈 尔 巴 乔 夫 一 党 的 情 绪 ， 我 们 的 情 报 人 员 通 过 抢 先 得 知 戈 尔 巴 乔 夫 改 革 派 集 团 “ 大 脑 ” 亚 历 山 大 · 雅 科 夫 列 夫 的 “ 全 盘 重 组 ” 计 划 （ 即 主 张 彻 底 洗 牌 苏 联 政 治 ， 在 苏 联 建 立 类 似 美 国 式 的 管 制 民 主 总 统 制 政 体 ， 为 此 ， 必 须 选 择 提 拔 反 建 制 势 力 为 改 革 开 辟 道 路 ） ， 恰 如 其 分 地 在 附 加 条 件 中 递 上 了 相 当 合 乎 其 口 味 的 黑 名 单 与 在 清 党 计 划 内 合 作 的 橄 榄 枝 ： 而 接 下 来 ， 负 责 国 防 的 中 央 书 记 格 里 戈 里 · 罗 曼 诺 夫 与 莫 斯 科 党 委 第 一 书 记 维 克 托 · 格 里 申 是 第 一 批 “ 自 愿 离 职 ” 的 ， 苏 共 在 各 加 盟 共 和 国 内 的 山 头 也 遭 清 洗 。 传 统 保 守 派 遭 遇 重 创 ： 当 然 ， 我 们 的 特 勤 做 了 两 手 工 作 ， 其 中 有 不 少 人 得 以 在 东 欧 盟 友 处 安 身 ， 给 他 们 留 了 东 山 再 起 的 念 想 — — 前 提 是 与 中 国 合 作 。 他 们 空 缺 的 位 置 则 为 我 们 与 戈 尔 巴 乔 夫 集 团 共 同 商 议 的 名 单 所 取 代 ： 其 中 则 有 以 拉 脱 维 亚 地 方 党 魁 鲍 里 斯 · 普 戈 、 总 参 谋 长 谢 尔 盖 · 阿 赫 罗 梅 耶 夫 等 国 家 主 义 者 为 代 表 的 社 会 爱 国 主 义 者 集 团 ， 承 担 扮 演 苏 共 “ 新 一 代 保 守 派 ” 的 任 务 ； 经 济 与 社 会 事 务 则 落 入 了 忽 略 意 识 形 态 的 技 术 官 僚 们 手 中 ： 其 中 则 包 括 工 会 领 导 人 根 纳 季 · 亚 纳 耶 夫 、 克 格 勃 主 席 维 克 托 · 切 布 里 科 夫 与 安 德 罗 波 夫 时 期 提 拔 的 列 昂 尼 德 · 阿 巴 尔 金 、 尼 古 拉 · 雷 日 科 夫 与 弗 拉 基 米 尔 · 多 尔 吉 赫 等 改 革 派 经 济 学 家 。 戈 尔 巴 乔 夫 集 团 则 负 责 扮 演 新 “ 三 驾 马 车 ” 的 车 头 ， 主 导 该 国 政 治 方 向 。 苏 联 本 身 的 改 革 在 我 们 的 介 入 下 得 以 “ 全 面 加 速 ” ： 预 计 社 会 自 由 化 的 进 一 步 开 展 ， 独 立 候 选 人 制 度 的 完 全 引 入 ， 大 平 反 的 进 行 、 中 苏 合 办 企 业 的 崛 起 与 中 国 援 助 团 体 的 抵 达 将 在 不 久 后 为 创 建 亲 中 游 说 势 力 与 反 对 派 开 辟 全 新 空 间 … …";
			a.relres = true;
			a.allcountries[7].Torg = true;
			a.allcountries[7].prosov = false;
			a.allcountries[7].Gosstroy = 2;
			a.allcountries[7].SubGosstroy = 15;
			a.empires[1].relations += 100;
			a.empires[0].relations -= 250;
			a.SOV_PRC_PartiesConnection += 250;
			a.data[8] -= 450;
			a.data[9] -= 350;
			a.data[22] -= 250;
			a.data[11] -= 12000;
			a.data[12] -= 200;
			a.data[13] -= 100;
			a.data[68] -= 150;
			a.data[4] += 100;
			a.influencePRC += 100;
			a.empires[1].money += 150;
		}
		if (result_num == 4)
		{
			text = " “ 加 速 发 展 战 略 ” 计 划 在 第 十 二 个 五 年 计 划 期 间 ， 将 国 民 收 入 增 长 率 提 升 2 0 - 2 2 % ， 工 业 产 出 增 长 2 1 - 2 4 % ， 农 业 产 值 则 实 现 翻 倍 。 目 标 是 让 苏 联 的 工 业 产 值 在 2 0 0 0 年 赶 上 美 国 。 时 间 会 告 诉 我 们 这 一 政 策 的 成 功 与 否 … …";
			a.empires[1].money -= 150;
			GlobalScript.inst.gameState.empires[1].leaders[6].support++;
		}
	}
}
