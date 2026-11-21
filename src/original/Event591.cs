using EventsForDLC;
using UnityEngine;

public class Event591 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 祖 国 或 死 亡";
		text = " 自 该 国 于 西 班 牙 的 殖 民 统 治 下 独 立 以 来 ， 古 巴 就 长 期 处 于 帝 国 主 义 的 控 制 之 下 。 尽 管 1 9 5 9 年 的 古 巴 革 命 使 该 国 成 为 了 拉 丁 美 洲 的 革 命 典 范 和 全 球 激 进 左 翼 心 中 的 圣 地 ， 将 美 帝 国 主 义 、 古 巴 地 主 、 依 附 的 资 本 家 及 其 一 切 寄 生 虫 、 皮 条 客 和 匪 徒 驱 逐 出 了 该 国 ， 由 古 巴 革 命 所 带 来 的 游 击 中 心 论 也 为 全 世 界 的 城 市 游 击 队 提 供 了 思 想 指 导 。 但 在 今 天 ， 革 命 已 经 走 向 了 反 面 。||在 由 古 巴 革 命 所 掀 起 的 六 十 年 代 拉 美 革 命 运 动 退 潮 、 指 挥 官 丧 身 玻 利 维 亚 、 创 造 “ 两 个 、 三 个 乃 至 更 多 个 越 南 ” 的 幻 想 破 灭 后 ， 尽 管 对 苏 联 的 国 际 革 命 路 线 颇 有 微 词 ， 但 在 苏 联 开 出 的 “ 每 年 以 市 场 价 数 倍 购 买 古 巴 蔗 糖 ” 的 糖 衣 炮 弹 面 前 ， 该 国 还 是 选 择 抛 弃 了 东 方 的 另 一 位 老 朋 友 ， 走 上 了 一 条 更 贴 近 苏 联 的 道 路 。||而 苏 联 的 援 助 当 然 不 是 无 偿 的 。 该 国 很 快 便 从 经 互 会 的 国 际 分 工 体 系 中 找 到 了 自 己 的 定 位 ： 既 然 古 巴 拥 有 大 量 的 甘 蔗 田 、 制 糖 厂 和 闲 置 土 地 ， 而 其 他 工 业 却 极 其 薄 弱 ， 种 植 甘 蔗 带 来 的 收 益 也 远 高 于 缓 慢 而 昂 贵 的 发 展 多 样 化 的 工 农 业 ， 那 么 — — 作 为 一 个 “ 糖 罐 ” 无 疑 是 最 “ 划 算 ” 的 选 择 。|就 这 样 ， 刚 从 一 个 帝 国 主 义 的 控 制 中 脱 离 出 来 的 古 巴 就 又 落 入 了 另 一 个 帝 国 主 义 的 影 响 下 。 与 苏 东 国 家 的 贸 易 成 了 该 国 对 外 贸 易 的 大 头 ， 再 加 上 对 制 糖 业 的 严 重 依 赖 和 欠 于 苏 联 的 巨 额 贷 款 ， 很 快 便 使 古 巴 深 陷 于 苏 联 新 瓶 装 旧 酒 的 经 济 殖 民 中 。 而 该 国 甚 至 还 充 当 了 苏 联 对 外 干 涉 的 打 手 角 色 ， 从 安 哥 拉 到 埃 塞 俄 比 亚 ， 每 当 苏 联 迫 切 需 要 军 事 干 预 却 又 碍 于 颜 面 不 能 亲 自 动 手 时 ， 古 巴 士 兵 的 身 影 就 出 现 在 了 战 场 上 。||苏 联 势 力 的 衰 弱 导 致 与 经 互 会 密 切 捆 绑 的 古 巴 经 济 受 到 了 严 重 冲 击 。 而 苏 联 援 助 的 减 少 、 蔗 糖 价 格 的 持 续 走 低 、 连 年 的 干 旱 和 飓 风 、 西 方 市 场 日 益 盛 行 的 保 护 主 义 更 是 给 了 这 个 风 雨 飘 渺 的 国 家 致 命 一 击 ， 顷 刻 间 ， 古 巴 的 经 济 就 宣 布 告 急 。 尽 管 曾 经 有 过 一 些 不 愉 快 ， 但 如 若 该 国 政 府 因 此 崩 溃 ， 那 无 数 革 命 者 用 鲜 血 所 保 卫 的 红 色 古 巴 就 会 再 度 易 手 于 美 帝 国 主 义 。 主 席 同 志 ， 我 们 是 否 要 拉 这 位 曾 经 的 老 朋 友 一 把 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 要 古 巴 ， 不 要 美 国 佬 ！";
		button_text[1] = " 要 古 巴 ， 但 不 要 卡 斯 特 罗";
		if (a.empires[1].now_leader == 6 && a.allcountries[7].Torg && a.data[56] >= 3)
		{
			button_text[2] = " 与 苏 联 一 道 施 压 古 巴 政 府 ， 要 求 他 们 进 行 改 革";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 祖 国 或 死 亡";
		if (result_num == 0)
		{
			text = " 菲 德 尔 · 卡 斯 特 罗 欣 然 同 意 了 我 们 邀 请 他 前 来 观 看 本 年 国 庆 游 行 的 邀 请 。 在 为 他 接 风 洗 尘 的 招 待 宴 上 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 赞 扬 了 古 巴 革 命 以 来 取 得 的 成 果 与 在 美 帝 封 锁 下 坚 强 不 屈 的 革 命 精 神 ， 并 隐 晦 地 批 评 了 该 国 受 苏 修 影 响 所 酿 成 的 恶 果 ， 讲 话 最 后 以 一 声 “ 要 古 巴 不 要 美 国 佬 ！ ” 结 尾 。 在 随 后 的 商 谈 中 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "承 诺 将 尽 己 所 能 为 古 巴 提 供 支 持 。||很 快 ， 来 自 中 国 的 工 程 队 与 大 米 便 启 程 送 往 古 巴 。 不 过 ， 我 们 当 然 不 可 能 像 苏 联 人 一 样 ， 将 古 巴 简 单 作 为 “ 糖 罐 ” 绑 定 于 经 互 会 的 国 际 分 工 体 系 中 ， 而 在 经 过 此 前 的 教 训 后 ， 卡 斯 特 罗 也 决 定 扭 转 该 国 经 济 结 构 单 一 的 现 状 。 为 此 ， 在 经 过 我 国 专 家 的 实 地 考 察 后 ， 我 们 为 他 们 制 定 了 全 新 的 经 济 发 展 计 划 。 卡 斯 特 罗 宣 布 开 展 第 二 次 “ 革 命 攻 势 ” ， 以 使 该 国 能 够 实 现 经 济 多 元 化 和 自 给 自 足 。 大 量 的 甘 蔗 地 改 种 了 水 稻 、 马 铃 薯 等 粮 食 作 物 ， 和 热 带 水 果 、 咖 啡 等 作 物 ， 近 一 半 的 制 糖 厂 被 逐 步 关 闭 ， 其 将 被 改 造 为 其 他 工 厂 ， 因 此 而 失 业 的 制 糖 工 人 也 将 经 受 培 训 后 于 新 岗 位 再 就 业 。 尽 管 经 济 结 构 的 转 型 会 带 来 很 多 问 题 ， 但 这 些 只 是 暂 时 的 。||卡 斯 特 罗 感 谢 我 们 的 支 持 ， 他 邀 请" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "参 加 古 巴 共 产 党 的 新 一 届 大 会 ， 在 会 议 中 ， 卡 斯 特 罗 宣 布 “ 古 巴 将 与 中 国 同 进 退 ” ， 并 授 予 了 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 古 巴 共 和 国 英 雄 勋 章 和 何 塞 · 马 蒂 勋 章 。 两 位 亲 华 派 ： 第 一 任 保 卫 革 命 委 员 会 全 国 总 协 调 员 何 塞 · 马 塔 尔 和 前 统 一 革 命 组 织 （ 古 共 的 前 身 ） 中 央 委 员 弗 朗 西 斯 科 · 卡 尔 辛 斯 也 在 这 场 会 议 中 被 纳 入 政 治 局 。";
			a.data[8] -= 150;
			if (a.modifies[3].active || a.modifies[6].active)
			{
				a.allcountries[138].Gosstroy = 1;
				a.allcountries[138].SubGosstroy = 1;
			}
			else
			{
				a.allcountries[138].Gosstroy = 2;
				a.allcountries[138].SubGosstroy = 15;
			}
			a.allcountries[138].EstablishGovernment(Government.ProChina);
			a.allcountries[138].Torg = true;
			a.allcountries[138].JoinAllOurAlliances(yes: true);
		}
		if (result_num == 1)
		{
			text = " 通 过 哥 伦 比 亚 卡 特 尔 的 巴 勃 罗 · 埃 斯 科 瓦 尔 的 关 系 网 ， 我 们 秘 密 与 对 卡 斯 特 罗 不 满 、 曾 先 后 参 与 了 在 戈 兰 高 地 、 安 哥 拉 和 欧 加 登 地 区 的 作 战 、 功 勋 卓 著 的 阿 纳 尔 多 · 奥 乔 亚 · 桑 切 斯 中 将 取 得 了 联 系 ， 一 场 政 变 拉 开 了 帷 幕 。||在 古 巴 共 产 党 的 一 次 例 行 会 议 期 间 ， 一 队 士 兵 闯 入 会 议 室 ， 使 用 冲 锋 枪 向 其 中 扫 射 ， 卡 斯 特 罗 — — 这 位 曾 躲 过 C I A 无 数 次 刺 杀 的 革 命 家 终 究 还 是 一 命 呜 呼 ， 栽 在 了 自 己 人 手 里 。 随 后 ， 奥 乔 亚 将 军 发 动 政 变 接 管 了 古 巴 政 府 ， 在 广 播 中 ， 他 宣 布 “ 苏 联 新 殖 民 主 义 的 代 理 人 、 新 修 正 主 义 者 菲 德 尔 · 卡 斯 特 罗 背 叛 了 古 巴 革 命 事 业 ， 将 古 巴 绑 到 了 苏 修 社 会 帝 国 主 义 的 战 车 之 上 ” ， 并 公 布 了 一 系 列 卡 斯 特 罗 的 罪 行 ， 其 中 包 括 ： 向 美 国 出 卖 古 巴 主 权 、 年 轻 时 阅 读 过 长 枪 党 书 籍 ， 与 西 班 牙 法 西 斯 分 子 佛 朗 哥 所 勾 结 、 将 国 家 从 美 国 的 糖 罐 变 为 了 经 互 会 的 糖 罐 ， “ 而 现 在 ， 这 一 切 都 结 束 了 ” 。 新 政 府 由 奥 乔 亚 和 他 的 密 友 狄 奥 克 莱 斯 · 托 拉 尔 瓦 、 女 婿 托 尼 · 德 拉 瓜 迪 亚 等 亲 信 领 导 。 奥 乔 亚 刚 一 上 台 便 开 始 与 哥 伦 比 亚 的 麦 德 林 帮 、 墨 西 哥 的 瓜 达 哈 拉 集 团 " + ((a.allcountries[141].SubGosstroy == 7) ? "、 巴 拿 马 的 诺 列 加 政 府" : null) + " 等 贩 毒 集 团 展 开 了 亲 密 合 作 ， 并 宣 布 将 使 古 柯 种 植 合 法 化 ， 在 他 的 治 下 ， 古 巴 迅 速 成 为 拉 美 毒 品 走 私 的 中 心 ， 腐 败 与 政 治 贿 赂 也 在 该 国 蔓 延 。";
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.allcountries[138].Gosstroy = 0;
			a.allcountries[138].SubGosstroy = 10;
			a.allcountries[138].EstablishGovernment(Government.ProChina);
			a.allcountries[138].Torg = true;
			a.allcountries[138].JoinAllOurAlliances(yes: true);
		}
		if (result_num == 2)
		{
			text = " 我 国 政 府 与 苏 联 向 古 巴 施 加 了 外 交 压 力 ， 要 求 古 巴 进 行 政 治 改 革 ， 否 则 就 彻 底 断 绝 援 助 。 以 换 取 援 助 为 条 件 ， 菲 德 尔 · 卡 斯 特 罗 不 得 不 辞 去 部 长 会 议 主 席 和 古 巴 共 产 党 总 书 记 等 职 务 ， 随 后 ， 素 有 “ 经 济 沙 皇 ” 称 号 的 部 长 会 议 副 主 席 卡 洛 斯 · 拉 斐 尔 · 罗 德 里 格 斯 接 替 了 这 些 职 位 。 新 任 总 书 记 上 任 后 便 进 行 了 大 刀 阔 斧 的 变 革 ， 他 任 命 了 在 苏 联 就 学 过 的 新 一 代 经 济 学 家 、 国 家 计 划 委 员 会 主 任 温 贝 托 · 佩 雷 斯 · 冈 萨 雷 斯 主 持 经 济 改 革 ， 在 扩 大 企 业 自 主 权 ， 进 一 步 利 用 物 质 刺 激 的 同 时 ， 开 放 了 对 外 国 与 私 人 投 资 的 限 制 ， 大 力 提 倡 国 有 企 业 变 为 与 外 国 合 资 ， 合 法 化 美 元 交 易 。 面 对 社 会 主 义 古 巴 的 惊 人 变 革 ， 就 连 近 在 咫 尺 的 宿 敌 也 选 择 了 撤 销 对 该 国 的 经 济 封 锁 ， 接 纳 其 进 入 泛 美 体 系 与 美 洲 国 家 组 织 之 内 ， 古 巴 也 由 此 承 诺 不 干 涉 他 国 内 政 ， 停 止 革 命 输 出 ， 断 绝 了 对 一 切 美 洲 左 翼 游 击 队 的 援 助 ， 并 向 拉 美 各 个 亲 美 政 权 移 交 了 躲 藏 在 古 巴 的 左 翼 异 见 者 和 游 击 队 员 。 外 资 的 涌 入 使 该 国 迅 速 进 入 了 经 济 繁 荣 ， 合 法 的 餐 馆 、 商 店 、 小 商 贩 与 私 人 企 业 再 次 步 入 古 巴 的 经 济 舞 台 ， 来 自 美 国 的 新 颖 消 费 品 出 现 在 了 哈 瓦 那 、 圣 地 亚 哥 、 巴 亚 莫 等 城 市 的 货 架 上 ， 配 给 制 也 终 于 得 以 结 束 ， 这 会 是 个 好 兆 头 吗 ？";
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.allcountries[138].Gosstroy = 2;
			a.allcountries[138].SubGosstroy = 15;
			a.allcountries[138].EstablishGovernment(Government.ProChina);
			a.allcountries[138].Torg = true;
		}
	}
}
