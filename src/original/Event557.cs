using EventsForDLC;
using UnityEngine;

public class Event557 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 和 平 长 入 社 会 主 义";
		text = " <color=#8B0000>意 大 利 共 产 党</color> 以 奉 行 改 良 主 义 与 进 步 主 义 路 线 ， 并 力 求 走 出 同 经 典 资 本 主 义 与 苏 式 社 会 主 义 不 同 的 道 路 著 称 ： 实 际 上 ， 自 欧 洲 共 产 党 与 工 人 党 情 报 局 于 1 9 5 6 年 停 止 活 动 后 ， 该 党 便 在 <color=#8B0000>帕 尔 米 罗 · 陶 里 亚 蒂</color> 的 领 导 下 事 实 上 疏 远 经 典 社 会 主 义 ， 完 全 沉 浸 在 “ 萨 勒 洛 转 向 ” （ 即 要 求 <color=#8B0000>意 大 利 共 产 党</color> 加 入 资 产 阶 级 政 府 ， 并 争 取 通 过 民 主 选 举 而 非 阶 级 斗 争 掌 权 ） 的 原 则 中 。 并 支 持 一 切 试 图 实 现 国 际 共 产 主 义 运 动 民 主 化 与 领 导 团 体 多 元 化 的 尝 试 — — 因 此 ， <color=#8B0000>意 大 利 共 产 党</color> 能 做 出 既 同 情 南 斯 拉 夫 铁 托 主 义 ， 又 在 同 时 抗 议 苏 方 将 我 们 孤 立 于 社 会 主 义 阵 营 外 的 矛 盾 行 为 。 目 前 的 <color=#8B0000>恩 里 科 · 贝 林 格</color> 政 府 显 然 也 继 承 了 其 前 任 衣 钵 ， 他 上 任 伊 始 便 亲 自 出 访 南 斯 拉 夫 、 奥 地 利 、 匈 牙 利 、 瑞 典 乃 至 我 国 ， 并 进 一 步 密 切 了 同 欧 洲 共 产 主 义 政 党 的 联 系 。 显 然 是 在 传 统 阵 营 外 寻 求 盟 友 的 尝 试 ： 显 然 ， <color=#8B0000>恩 里 科 · 贝 林 格</color> 并 非 真 想 把 自 身 的 活 动 范 围 局 限 于 大 西 洋 体 系 框 架 内 ， 并 试 图 以 外 交 突 破 作 为 自 身 发 起 国 内 变 革 的 坚 实 后 盾 ， 由 此 摆 脱 智 利 式 孤 立 主 义 危 局 。 也 许 作 为 独 立 于 美 苏 两 强 之 外 的 力 量 。 我 们 能 够 为 他 们 提 供 些 帮 助 ？ 考 虑 到 <color=#8B0000>意 大 利 共 产 党</color> 目 前 已 打 入 第 二 世 界 的 心 脏 ， 并 对 非 苏 式 社 会 主 义 持 门 户 开 放 的 合 作 态 度 ， 我 们 当 然 可 以 利 用 局 势 ： 或 者 将 他 们 纳 入 到 我 们 的 国 际 统 一 战 线 内 或 许 是 值 得 的 ？ 又 或 者 ， 我 们 可 以 扮 演 类 似 罗 马 尼 亚 的 中 间 人 ， 在 意 大 利 与 苏 联 社 会 主 义 阵 营 间 推 动 和 解 ， 让 这 叛 逆 的 游 击 队 员 回 归 老 大 哥 怀 抱 ？ 当 然 也 可 以 另 起 炉 灶 ， 利 用 现 政 权 的 不 稳 定 性 推 动 我 们 支 持 的 激 进 主 义 政 治 力 量 就 位 。 当 然 ， 决 定 权 在 你 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] != 0 && a.data[56] != 4 && !a.modifies[3].active && a.allcountries[45].Gosstroy == 2 && !a.allcountries[45].cw && a.allcountries[84].Gosstroy == 2 && a.allcountries[15].Gosstroy == 2 && a.influencePRC >= 400 && a.allcountries[1].Gosstroy != 0 && a.allcountries[1].Gosstroy != 3 && a.allcountries[15].cw)
		{
			button_text[0] = " 我 们 将 全 力 支 持 贝 林 格 实 现 欧 洲 关 系 民 主 化 的 尝 试 ， 建 立 欧 洲 社 会 主 义 者 间 的 统 一 战 线";
		}
		else if (a.data[56] == 0 || a.data[56] == 4 || a.modifies[3].active)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 怎 能 支 持 陶 里 亚 蒂 的 徒 子 徒 孙 ？";
		}
		else if (a.allcountries[1].Gosstroy == 0 || a.allcountries[1].Gosstroy == 3)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 意 大 利 共 产 党 看 不 上 中 国 方 案";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 鞭 长 莫 及 ， 鞭 长 莫 及 呐";
		}
		if (a.data[56] < 3 && !a.modifies[3].active && a.allcountries[1].isSEV && a.relres && a.influencePRC >= 200)
		{
			button_text[1] = " 我 们 将 同 社 会 主 义 阵 营 一 道 ， 向 意 大 利 抛 去 橄 榄 枝";
		}
		else if (a.data[56] >= 3 || a.modifies[3].active)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 绝 不 同 苏 修 社 会 帝 国 主 义 同 流 合 污 ！";
		}
		else if (a.influencePRC < 200)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 鞭 长 莫 及 ， 鞭 长 莫 及 呐";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 苏 联 不 会 考 虑 这 种 意 见 的";
		}
		if (a.data[56] < 2)
		{
			button_text[2] = " 和 平 长 入 社 会 主 义 ？ 不 如 直 接 支 援 我 们 的 激 进 左 翼 同 志 打 击 这 帮 叛 徒 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 怎 么 能 支 持 恐 怖 分 子 呢 ？ ";
		}
		button_text[3] = " 静 观 其 变";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 和 平 长 入 社 会 主 义";
		if (result_num == 0)
		{
			text = " 我 们 的 慷 慨 解 囊 与 决 定 性 行 动 为 <color=#8B0000>恩 里 科 · 贝 林 格</color> 政 府 解 了 燃 眉 之 急 ， 并 正 中 <color=#8B0000>意 大 利 共 产 党</color> 政 权 的 下 怀 ： 他 们 在 欧 洲 议 会 活 动 期 间 便 是 欧 洲 一 体 化 最 热 心 的 提 倡 者 ， 主 张 建 立 独 立 于 美 苏 两 者 的 力 量 中 心 。 在 中 方 的 协 调 与 背 靠 和 平 、 民 主 、 不 结 盟 立 场 政 治 正 确 的 共 同 作 用 下 。 我 们 很 快 便 将 主 要 欧 洲 社 会 主 义 政 权 的 主 要 领 导 人 聚 拢 ， 共 商 合 作 事 宜 ： 不 久 后 ， 意 大 利 总 理 <color=#8B0000>恩 里 科 · 贝 林 格</color> 便 同 希 腊 总 理 <color=#006400>安 德 烈 亚 斯 · 帕 潘 德 里 欧</color> 、 土 耳 其 总 理 <color=#006400>比 伦 特 · 埃 杰 维 特</color> 两 位 政 治 家 在 罗 马 签 署 协 定 。 随 后 各 方 便 基 于 人 道 、 民 主 、 和 平 共 处 与 社 会 主 义 的 系 列 原 则 达 成 协 定 ， 形 成 所 谓 “ 地 中 海 - 欧 洲 诸 国 社 会 主 义 联 盟 ” ： 新 组 织 将 以 增 进 人 民 福 祉 、 实 现 社 会 进 步 与 外 交 关 系 平 等 化 作 为 活 动 宗 旨 ， 并 仿 照 欧 洲 共 同 体 建 立 类 似 的 部 长 会 议 、 产 业 联 营 与 共 同 经 济 空 间 ； 接 下 来 则 是 要 求 各 成 员 国 根 据 民 主 社 会 主 义 与 工 人 自 治 原 则 实 现 经 济 社 会 化 改 革 ： 此 后 ， 各 国 均 对 税 制 、 劳 工 福 祉 与 工 会 法 规 做 出 改 革 ， 并 开 始 推 进 温 和 的 生 产 资 料 社 会 化 与 为 大 型 企 业 引 入 员 工 强 制 持 股 的 管 理 体 制 。 由 此 在 不 同 程 度 地 扭 转 了 新 自 由 主 义 经 济 倾 向 ， 并 在 欧 洲 开 辟 了 争 取 国 际 关 系 民 主 化 的 全 新 战 线 ： 相 关 倡 议 得 到 了 瑞 典 首 相 <color=#006400>奥 洛 夫 · 帕 尔 梅</color> 、 奥 地 利 总 理 兼 社 会 党 国 际 副 主 席 <color=#006400>布 鲁 诺 · 克 赖 斯 基</color> ， 乃 至 南 斯 拉 夫 的 <color=#006400>铁 托 主 义 领 导 层</color> 的 热 烈 欢 迎 。 不 过 ， 超 级 大 国 显 然 对 新 力 量 的 崛 起 大 为 光 火 。";
			a.allcountries[85].LeaveAlliances();
			a.allcountries[85].isSocEU = true;
			a.allcountries[85].Torg = true;
			a.allcountries[84].LeaveAlliances();
			a.allcountries[84].isSocEU = true;
			a.allcountries[84].Torg = true;
			a.allcountries[45].LeaveAlliances();
			a.allcountries[45].isSocEU = true;
			a.allcountries[45].Torg = true;
			a.empires[1].relations -= 200;
			a.empires[0].relations -= 300;
			a.data[6] -= 50;
			a.data[8] -= 150;
			a.data[9] -= 250;
			a.influencePRC += 100;
			a.empires[1].power -= 50;
			a.empires[0].power -= 100;
		}
		if (result_num == 1)
		{
			a.allcountries[85].LeaveAlliances();
			if (a.empires[1].power >= 250)
			{
				text = " 不 久 后 ， 在 中 方 的 运 作 协 调 下 。 <color=#8B0000>意 大 利 共 产 党</color> 领 导 人 <color=#8B0000>恩 里 科 · 贝 林 格</color> 便 同 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 与 苏 联 总 书 记 列 昂 尼 德 · 勃 列 日 涅 夫 一 同 前 往 北 京 举 行 三 方 会 谈 ， 并 就 意 大 利 接 受 国 际 分 工 方 案 ， 加 入 经 济 互 助 委 员 会 的 关 键 议 题 达 成 共 识 。 与 此 同 时 ， 苏 联 领 导 层 也 开 始 试 图 借 用 这 一 契 机 ， 加 强 对 <color=#8B0000>意 大 利 共 产 党</color> 的 控 制 ： 苏 联 专 家 与 克 格 勃 已 借 用 经 济 合 作 契 机 进 入 意 大 利 ， 并 开 始 同 亲 苏 派 领 导 人 <color=#8B0000>阿 曼 多 · 科 苏 塔</color> 密 切 接 触 ， 直 接 在 党 与 国 家 机 器 中 培 育 亲 苏 派 。 意 大 利 已 开 始 接 受 来 自 东 方 的 贷 款 、 市 场 与 廉 价 资 源 ， 预 计 经 济 将 在 不 久 后 迎 来 新 一 轮 繁 荣 。 可 向 东 看 齐 的 举 动 显 然 引 起 了 美 国 与 主 要 欧 洲 国 家 的 高 度 不 满 … …";
				a.allcountries[85].prosov = true;
			}
			else
			{
				text = " 不 久 后 ， 在 中 方 的 运 作 协 调 下 。 <color=#8B0000>意 大 利 共 产 党</color> 领 导 人 <color=#8B0000>恩 里 科 · 贝 林 格</color> 便 同 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 与 苏 联 总 书 记 列 昂 尼 德 · 勃 列 日 涅 夫 一 同 前 往 北 京 举 行 三 方 会 谈 ， 并 就 意 大 利 接 受 国 际 分 工 方 案 ， 加 入 经 济 互 助 委 员 会 的 关 键 议 题 达 成 共 识 。 意 大 利 已 开 始 接 受 来 自 东 方 的 贷 款 、 市 场 与 廉 价 资 源 ， 预 计 经 济 将 在 不 久 后 迎 来 新 一 轮 繁 荣 。 可 向 东 看 齐 的 举 动 显 然 引 起 了 美 国 与 主 要 欧 洲 国 家 的 高 度 不 满 … …";
			}
			a.allcountries[85].isSEV = true;
			a.allcountries[85].Torg = true;
			a.empires[1].relations += 200;
			a.empires[0].relations -= 200;
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.influencePRC += 10;
			a.empires[1].power -= 50;
			a.empires[0].power += 20;
		}
		if (result_num == 2)
		{
			text = " 意 大 利 社 会 的 境 况 并 未 因 <color=#8B0000>意 大 利 共 产 党</color> 的 上 台 而 有 所 改 善 。 政 府 对 社 会 主 义 的 许 诺 随 着 外 交 尝 试 的 停 滞 不 前 而 越 加 显 得 宛 如 空 中 楼 阁 。 我 们 决 定 以 此 为 契 机 ， 进 一 步 推 进 意 大 利 社 会 的 激 进 化 。 各 地 工 人 主 义 组 织 已 收 到 新 一 批 武 器 ， 并 已 对 其 发 起 新 一 轮 城 市 游 击 战 。 内 外 交 困 的 境 地 更 沉 重 打 击 了 <color=#8B0000>恩 里 科 · 贝 林 格</color> 政 府 发 起 社 会 变 革 的 勇 气 与 信 心 。 只 得 打 出 “ 民 族 团 结 ” 的 旗 号 ， 将 重 心 转 移 到 实 施 反 恐 行 动 与 推 进 同 其 他 建 制 派 政 党 的 和 解 可 能 上 。 分 析 者 估 计 ， 该 党 很 可 能 输 掉 1 9 8 3 年 举 行 的 新 一 轮 选 举 。";
			a.empires[1].relations -= 150;
			a.empires[0].relations -= 150;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.data[22] -= 50;
			a.influencePRC += 5;
			a.allcountries[85].prcpower += 250;
		}
		if (result_num == 3)
		{
			text = " 在 苏 联 社 会 主 义 阵 营 日 益 衰 退 ， 且 欧 洲 的 独 立 社 会 主 义 派 系 越 加 倾 向 于 转 向 新 自 由 主 义 政 策 的 情 况 下 。 <color=#8B0000>意 大 利 共 产 党</color> 的 外 交 破 冰 尝 试 以 失 败 告 终 。 政 府 对 社 会 主 义 的 许 诺 也 随 着 外 交 尝 试 的 停 滞 不 前 而 越 加 显 得 宛 如 空 中 楼 阁 。 国 内 传 统 政 党 与 资 产 阶 级 也 顺 势 抓 住 机 会 挤 压 ， 并 试 图 以 政 变 威 胁 <color=#8B0000>恩 里 科 · 贝 林 格</color> 放 缓 改 革 。 内 外 交 困 的 境 地 更 沉 重 打 击 了 <color=#8B0000>恩 里 科 · 贝 林 格</color> 政 府 发 起 社 会 变 革 的 勇 气 与 信 心 。 只 得 打 出 “ 民 族 团 结 ” 的 旗 号 ， 将 重 心 转 移 到 实 施 反 恐 行 动 与 推 进 同 其 他 建 制 派 政 党 的 和 解 可 能 上 。 分 析 者 估 计 ， 倘 若 局 势 未 发 生 根 本 改 观 。 该 党 很 可 能 输 掉 1 9 8 3 年 举 行 的 新 一 轮 选 举 。 ";
		}
	}
}
