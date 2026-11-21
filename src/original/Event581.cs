using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event581 : EventsSecond
{
	private GameState a;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 铜 臭 味";
		text = " 主 席 同 志 ， 赞 比 亚 总 统 肯 尼 斯 · 卡 翁 达 的 特 使 正 在 等 着 被 您 接 见 。 不 出 意 外 的 话 ， 他 是 来 向 您 申 请 一 批 紧 急 贷 款 ， 用 以 拯 救 该 国 岌 岌 可 危 的 经 济 。 卡 翁 达 总 统 本 人 也 将 在 晚 些 时 候 亲 自 到 访 我 国 。||赞 比 亚 自 独 立 以 来 便 确 定 了 “ 人 道 社 会 主 义 ” 的 路 线 ， 即 通 过 社 会 主 义 的 路 线 实 现 人 的 全 面 发 展 。 其 中 揉 杂 了 大 量 的 基 督 教 元 素 ， 民 族 主 义 ， 非 洲 部 族 传 统 ， 一 部 分 的 空 想 社 会 主 义 元 素 ， 对 中 国 新 民 主 主 义 和 无 产 阶 级 文 化 大 革 命 中 积 极 因 素 的 接 纳 等 。 上 述 种 种 构 成 了 该 国 独 特 的 社 会 主 义 思 想 。||该 国 拥 有 世 界 上 首 屈 一 指 的 铜 矿 ， 曾 让 这 个 国 家 一 度 超 越 撒 哈 拉 以 南 （ 南 非 除 外 ） 的 大 多 数 国 家 。 高 达740 美 元 的 人 均 收 入 让 同 为 “ 非 洲 橱 窗 ” 的 准 资 本 主 义 国 家 科 特 迪 瓦 都 显 得 如 此 捉 襟 见 肘 。 坐 拥 多 国 投 资 更 是 让 该 国 的 收 入 翻 了 一 番 又 一 番 。 成 也 铜 矿 败 也 铜 矿 。 随 着 铜 价 在70 年 代 后 期 迅 速 贬 值 ， 该 国 发 展 不 完 全 不 充 分 的 弊 端 逐 渐 显 现 。 过 度 依 赖 于 矿 冶 业 的 发 展 导 致 该 国 的 工 业 农 业 几 乎 不 能 自 给 ； 首 都 卢 萨 卡 除 外 的 地 区 的 发 展 可 以 用 “ 不 存 在 ” 一 言 蔽 之 。 农 业 高 度 依 赖 外 国 进 口 和 国 家 补 贴 ， 以 及 困 难 的 商 品 交 换 进 一 步 拖 垮 了 这 个 小 国 脆 弱 的 经 济 。 对 玉 米 的 补 贴 甚 至 达 到 了 惊 人 的60 亿 克 瓦 查 ， 而 该 国 最 近 一 年 的 收 入 也 不 过45 亿 克 瓦 查 。 各 项 福 利 措 施 反 而 进 一 步 加 大 了 贫 富 差 距 。 占 全 国 人 口 的2 % 的 富 人 和60 % 的 穷 人 同 样 享 有 占 国 民 总 收 入 的20 % 。 根 据1980 年 国 际 劳 工 组 织 专 家 对 赞 比 亚 的 评 估 ， 两 极 分 化 已 经 到 了 一 个 极 度 危 险 的 程 度 。 同 时 ， 弗 雷 德 里 克 · 奇 卢 巴 ， 前 工 人 运 动 活 动 家 ， 该 国 最 大 的 政 治 反 对 派 也 希 望 得 到 超 级 大 国 的 背 书 ， 作 为 工 人 代 表 的 他 最 知 道 底 层 人 需 要 什 么 。 也 许 他 会 是 个 更 好 的 选 择 ？||赞 比 亚 的 联 合 民 族 独 立 党 已 经 难 以 恢 复 独 立 时 的 荣 光 ， 也 许 在 这 种 时 候 ， 我 们 该 来 点 转 变 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] < 3)
		{
			button_text[0] = " 为 赞 比 亚 提 供 一 笔 无 息 贷 款";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 是 独 裁 暴 君 ， 不 是 朋 友";
		}
		if (a.data[56] >= 2 && (a.allcountries[131].SubGosstroy == 7 || a.allcountries[131].SubGosstroy == 9))
		{
			button_text[1] = " 赞 比 亚 是 我 们 的 老 朋 友 ， 卡 翁 达 不 是 。";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = "不 ， 不 能 这 么 做";
		}
		if (a.data[12] >= 1200 && GlobalScript.inst.gameState.resultOfEvents[352] == 2 && GlobalScript.inst.gameState.data[12] >= 1200 && GlobalScript.inst.gameState.resultOfEvents[361] >= 0 && GlobalScript.inst.gameState.resultOfEvents[361] <= 1)
		{
			button_text[2] = " 恩 科 洛 索 ， 赞 比 亚 宇 航 员";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = "等 等 ， 谁 ？";
		}
		button_text[3] = " 我 们 什 么 都 不 需 要 做";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 铜 臭 味";
		if (result_num == 0)
		{
			text = " 在 为 这 位 非 洲 南 端 的 反 帝 斗 士 接 风 洗 尘 的 招 待 宴 上 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 发 表 了 “ 勿 忘 坦 赞 铁 路 精 神 ” 的 演 讲 。 其 中 高 度 赞 扬 了 卡 翁 达 总 统 为 发 展 赞 比 亚 作 出 的 突 出 贡 献 ， 称 联 合 民 族 独 立 党 是 赞 比 亚 建 设 的 领 军 人 。 在 演 讲 的 最 后 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 表 示 了 将 会 为 赞 比 亚 提 供 力 所 能 及 的 帮 助 。 卡 翁 达 总 统 激 动 的 握 住 了" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 的 双 手 ， 甚 至 流 下 了 感 动 的 泪 水 ， 这 一 幕 被 记 者 敏 锐 的 捕 捉 到 了 ， 这 肯 定 会 在 明 日 的 报 纸 上 占 有 一 席 之 地 。||很 快 ， 我 们 的 粮 食 ， 工 程 师 ， 赤 脚 医 生 和 农 业 队 顺 着 7 5 年 完 工 的 坦 赞 铁 路 再 度 来 到 该 国 。 该 国 在 建 设 社 会 主 义 中 有 一 些 急 于 求 成 的 毛 病 ， 而 我 们 将 为 他 们 开 出 一 剂 药 方 。 联 合 独 立 党 进 行 大 规 模 的 清 党 ， 打 贪 ， 批 评 与 自 我 批 评 的 运 动 。 在 新 的 一 版 党 章 中 ， 联 合 独 立 党 确 定 了 社 会 主 义 的 方 针 ， 对 该 国 循 序 渐 进 的 社 会 主 义 路 程 确 定 了 新 航 线 。 该 党 在 开 除 了 大 批 右 派 分 子 之 后 ， 吸 纳 了 一 部 分 社 会 主 义 者 ， 作 为 摆 设 的 贵 族 院 也 被 撤 除 ， 该 党 改 名 为 联 合 社 会 主 义 独 立 党 。 该 国 新 的 经 济 计 划 以 坦 桑 尼 亚 的 《 阿 鲁 沙 宣 言 》 所 宣 称 的 社 会 主 义 为 蓝 本 ， 维 持 高 度 的 国 有 - 公 有 的 同 时 谨 慎 打 击 小 资 产 阶 级 。 但 对 西 方 国 家 所 掌 握 的 “ 命 脉 ” 产 业 如 铜 矿 ， 粮 食 和 运 输 等 ， 政 府 则 毫 不 留 情 的 回 收 权 益 。 国 民 高 福 利 的 待 遇 也 没 有 被 取 消 ， 甚 至 得 以 提 升 ， 我 们 和 赞 比 亚 的 合 作 为 该 国 创 造 了 更 多 的 就 业 岗 位 。 他 们 也 将 成 为 中 国 援 助 的 又 一 个 力 证 ， 为 我 们 打 下 了 一 口 金 字 招 牌 。||赞 比 亚 仍 然 是 我 们 的 老 朋 友 ， 毕 竟 我 们 不 是 那 种 用 几 个 臭 钱 就 会 抛 弃 朋 友 的 人 。";
			a.data[8] -= 50;
			a.allcountries[124].Gosstroy = 1;
			a.allcountries[124].SubGosstroy = 1;
			a.allcountries[124].LeaveAlliances();
			a.allcountries[124].proprc = true;
			a.allcountries[124].Torg = true;
			if (a.allcountries[1].econ)
			{
				a.allcountries[124].JoinECON();
				a.allcountries[124].soc_stab = 1000;
			}
			a.influencePRC += 20;
			a.data[6] += 20;
		}
		if (result_num == 1)
		{
			text = " 在 接 待 卡 翁 达 总 统 的 时 候 ， 我 们 的 特 勤 人 员 正 在 卢 萨 卡 紧 锣 密 鼓 的 鼓 动 一 次 政 变 。 很 快 ， 一 场 政 变 在 南 非 的 支 持 下 发 生 了 。||趁 着 卡 翁 达 总 统 出 访 我 国 的 机 会 。 曼 巴 · 卢 奇 本 上 尉 率 领 着 赞 比 亚 军 队 ， 南 非 军 人 和 我 们 的 特 工 组 成 的 队 伍 奔 向 卢 萨 卡 的 广 播 电 台 和 监 狱 。 在 极 度 的 混 乱 中 ， 我 们 的 人 找 到 了 弗 雷 德 里 克 · 奇 卢 巴 。 同 时 前 往 电 视 台 的 分 队 也 圆 满 完 成 了 任 务 。 军 政 府 宣 布 联 合 民 族 独 立 党 的 一 党 专 政 事 实 上 违 反 了 宪 法 ， 并 强 行 解 散 了 国 会 。 随 后 在 一 场 操 控 的 大 选 中 ， 奇 卢 巴 的 赞 比 亚 自 由 民 主 党 取 得 了 绝 对 多 数 的 地 位 。 新 政 府 剥 夺 了 卡 翁 达 的 赞 比 亚 公 民 权 ， 我 们 也 宣 布 其 为 “ 不 欢 迎 的 人 ” ， 他 不 得 不 前 往 墨 西 哥 避 难 。||新 政 府 将 大 批 国 营 和 合 营 的 企 业 加 速 私 有 化 ， 或 者 变 卖 给 南 非 和 我 国 的 金 融 寡 头 。 尽 管 发 家 于 工 人 运 动 ， 新 总 统 却 迅 速 滑 向 了 金 融 寡 头 ， 境 外 资 本 的 一 边 ， 同 他 们 沆 瀣 一 气 的 镇 压 工 人 运 动 。 在 政 变 爆 发 的 第 一 天 早 上 ， 无 数 愤 怒 的 群 众 走 上 街 头 ， 军 政 府 残 酷 的 镇 压 了 这 次 暴 动 ， 造 成 了 远 超 卡 翁 达 时 期 的 政 治 灾 难 。 近 1 0 0 人 罹 难 ， 数 千 人 受 伤 。 但 南 非 在 报 纸 上 宣 传 赞 比 亚 镇 压 暴 徒 的 的 行 为 “ 无 比 正 确 ” ， 并 提 出 了 驻 军 的 要 求 。 彻 底 沦 为 了 境 外 势 力 ， 尤 其 是 南 非 的 傀 儡 的 新 政 府 无 力 拒 绝 。 这 真 的 会 为 赞 比 亚 带 来 和 平 或 发 展 吗 ？||<color=red>现 在 ， 我 们 的 手 上 沾 满 了 铜 臭 味 。</color>";
			a.allcountries[124].Gosstroy = 0;
			a.allcountries[124].SubGosstroy = 7;
			a.allcountries[124].LeaveAlliances();
			a.allcountries[124].Torg = true;
			a.allcountries[124].puppetOf = 131;
			a.data[8] += 100;
			a.data[9] -= 50;
		}
		if (result_num == 2)
		{
			text = " 我 们 获 得 邀 请 参 加 一 次 盛 大 的 赞 比 亚 联 合 民 族 独 立 党 代 表 大 会 ， 在 无 人 知 晓 的 情 况 下 ， 简 单 的 招 待 宴 席 变 成 了 一 场 盛 大 的 狂 欢 。 酒 精 在 肝 脏 内 转 化 为 乙 醛 乙 酸 ， 醉 醺 醺 的 众 人 没 有 发 现 他 们 通 过 了 一 项 近 乎 是 恶 作 剧 的 法 案 — 推 举 爱 德 华 · 恩 科 洛 索 为 新 一 届 总 统 。||恩 科 洛 索 曾 放 出 豪 言 ， 要 赶 在 美 苏 之 前 登 上 太 空 。60 年 代 的 他 曾 计 划 发 射 一 枚 火 箭 ， 并 把 两 只 猫 ， 一 位 女 航 天 员 和 一 名 传 教 士 送 上 月 球 。 为 了 训 练 全 国 上 下 挑 选 出 的17 名 精 兵 ， 他 利 用 油 桶 模 拟 失 重 ， 用 秋 千 模 仿 在 月 球 上 的 零 重 力 环 境 。 并 计 划 开 设 一 个 在 火 星 上 的 传 教 基 地 。||从 宿 醉 和 狂 欢 中 醒 来 的 赞 比 亚 政 客 要 头 疼 的 不 只 是 酒 精 ， 他 们 的 新 总 统 打 算 在 我 国 的 天 宫 空 间 站 上 完 成 就 职 仪 式 ！||在 遥 远 的 太 空 ， 恩 科 洛 索 透 过 舷 窗 望 向 养 育 他 的 故 乡 ， 等 等 ， 地 上 的 是 什 么 ？";
			a.allcountries[124].Gosstroy = 0;
			a.allcountries[124].SubGosstroy = 0;
			a.allcountries[124].LeaveAlliances();
			a.allcountries[124].Torg = true;
			load_scene_after_click = true;
			a.data[8] += 100;
			a.data[9] -= 50;
		}
		if (result_num != 3)
		{
			return;
		}
		text = " 我 们 热 烈 的 接 待 了 的 卡 翁 达 总 统 ， 但 对 于 其 提 出 的 援 助 要 求 ， 我 们 不 予 评 价 。";
		if (a.resultOfEvents[500] == 0)
		{
			text += " 新 生 的 非 洲 联 盟 迅 速 宣 布 提 供 了 一 笔 紧 急 贷 款 ， 用 于 缓 解 该 国 的 问 题 。 同 时 ， 非 洲 的 政 治 学 者 和 工 程 师 前 往 该 国 进 行 考 察 并 提 供 行 之 有 效 的 方 案 。 该 国 的 问 题 在 非 洲 同 胞 的 帮 助 下 有 所 好 转 。 这 证 明 了 没 有 殖 民 者 的 阻 挠 ， 非 洲 人 自 己 可 以 建 设 非 洲 — — 他 们 自 己 的 非 洲 。";
			a.allcountries[124].Gosstroy = 2;
			a.allcountries[124].SubGosstroy = 3;
			a.allcountries[124].LeaveAlliances();
			a.allcountries[124].Torg = true;
			a.allcountries[124].okb = true;
			return;
		}
		text += " 赞 比 亚 不 得 不 宣 布 进 入 一 段 “ 困 难 时 期 ” 。 许 多 过 去 的 政 策 如 削 减 补 贴 ， 更 大 幅 度 的 自 由 化 ， 甚 至 是 紧 缩 政 策 和 政 府 裁 员 。 他 本 人 也 在 党 内 发 动 了 反 腐 倡 廉 打 老 虎 的 运 动 ， 但 只 有 不 到 3 0 % 的 官 员 不 从 事 商 业 或 土 地 兼 并 的 生 意 。 看 来 很 长 一 段 时 间 内 ， 萎 靡 不 振 的 经 济 都 将 威 胁 该 国 的 正 常 发 展 。";
		if (a.allcountries[131].SubGosstroy == 9)
		{
			text += " 在 南 非 政 府 的 策 动 下 ， 曼 巴 · 卢 奇 本 上 尉 率 领 着 赞 比 亚 军 队 和 南 非 军 组 成 的 队 伍 奔 向 卢 萨 卡 的 广 播 电 台 和 监 狱 。 在 极 度 的 混 乱 中 ， 政 变 部 队 找 到 了 弗 雷 德 里 克 · 奇 卢 巴 。 同 时 前 往 电 视 台 的 分 队 也 圆 满 完 成 了 任 务 。 军 政 府 宣 布 联 合 民 族 独 立 党 的 一 党 专 政 事 实 上 违 反 了 宪 法 ， 并 强 行 解 散 了 国 会 。 随 后 在 一 场 操 控 的 大 选 中 ， 奇 卢 巴 的 赞 比 亚 自 由 民 主 党 取 得 了 绝 对 多 数 的 地 位 。 新 政 府 剥 夺 了 卡 翁 达 的 赞 比 亚 公 民 权 ， 并 宣 布 其 为 “ 不 欢 迎 的 人 ” ， 他 不 得 不 留 在 我 国 避 难 。||在 南 非 的 集 体 防 御 方 案 下 ， 赞 比 亚 新 宪 法 为 种 族 隔 离 制 度 摇 旗 呐 喊 ， 并 正 式 恢 复 了 北 罗 得 西 亚 的 旧 名 。 新 政 府 将 大 批 国 营 和 合 营 的 企 业 加 速 私 有 化 ， 或 者 变 卖 给 南 非 和 我 国 的 金 融 寡 头 。 尽 管 发 家 于 工 人 运 动 ， 新 总 统 却 迅 速 滑 向 了 金 融 寡 头 ， 境 外 资 本 的 一 边 ， 同 他 们 沆 瀣 一 气 的 镇 压 工 人 运 动 。 在 政 变 爆 发 的 第 一 天 早 上 ， 无 数 愤 怒 的 群 众 走 上 街 头 ， 军 政 府 残 酷 的 镇 压 了 这 次 暴 动 ， 造 成 了 远 超 卡 翁 达 时 期 甚 至 是 独 立 前 的 政 治 灾 难 。 近100 人 罹 难 ， 数 千 人 受 伤 。 但 南 非 在 报 纸 上 宣 传 该 国 镇 压 暴 徒 的 的 行 为 “ 无 比 正 确 ” ， 并 提 出 了 驻 军 的 要 求 。 彻 底 沦 为 了 境 外 势 力 ， 尤 其 是 南 非 的 傀 儡 的 新 政 府 无 力 拒 绝 。 这 真 的 会 为 北 罗 得 西 亚 带 来 和 平 或 发 展 吗 ？";
			a.allcountries[124].Gosstroy = 0;
			a.allcountries[124].SubGosstroy = 9;
			a.allcountries[124].LeaveAlliances();
			a.allcountries[124].name = "北 罗 得 西 亚";
			a.allcountries[124].puppetOf = 131;
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 13;
			SceneManager.LoadScene("Ending");
		}
	}
}
