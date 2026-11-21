using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event602 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " “ 南 非 ” 意 味 着 攻 击";
		text = " 同 志 ， 如 今 也 是 时 候 彻 底 解 决 我 们 与 南 非 间 的 问 题 了 。 长 期 制 裁 与 国 际 投 资 撤 离 已 使 南 非 全 国 经 济 与 社 会 秩 序 濒 于 崩 溃 ， 并 深 陷 内 外 交 困 境 地 。 而 南 非 领 导 人 兼 国 民 党 党 魁 P · W · 博 塔 的 “ 种 族 隔 离 为 反 共 ” 与 对 现 有 国 体 的 小 修 小 补 改 革 也 收 效 甚 微 。 因 此 ， 该 国 将 于 今 日 举 行 全 民 公 投 并 修 改 宪 法 。 宪 法 草 案 将 在 剥 夺 总 理 ， 首 相 与 议 会 权 力 ， 改 南 非 为 总 统 制 共 和 国 的 同 时 修 改 ” 班 图 斯 坦 “ 政 策 （ 以 自 治 区 形 式 取 代 独 立 主 权 体 ） — — 上 述 政 策 自 然 无 法 使 抗 议 者 满 足 。 考 虑 到 部 分 消 息 声 称 不 排 除 南 非 陆 军 下 场 戒 严 的 可 能 。 我 们 可 说 白 人 南 非 的 命 运 拐 点 即 将 到 来 。||现 在 也 是 时 候 给 我 国 的 非 洲 布 局 交 上 答 卷 了 。 针 对 南 非 问 题 ， 我 们 有 多 种 干 涉 方 案 ： 如 果 我 们 已 同 南 非 的 阿 扎 尼 亚 泛 非 主 义 大 会 和 其 殖 民 地 的 西 南 非 洲 民 族 联 盟 （ S W A N U ） 打 过 照 面 ， 并 做 好 了 联 动 阿 扎 尼 亚 人 民 组 织 等 革 命 派 发 动 武 装 起 义 方 面 的 工 作 ， 便 能 以 最 直 接 了 当 的 方 式 歼 灭 种 族 隔 离 政 权 ， 并 将 南 非 转 变 为 毛 主 义 的 壁 垒 。 毕 竟 ， 阿 扎 尼 亚 大 会 与 S W A N U 的 亲 毛 立 场 并 非 秘 密 ； 当 然 ， 我 们 也 可 以 选 择 同 苏 联 一 起 支 持 非 洲 国 民 大 会 党 、 南 非 共 产 党 与 南 非 工 会 大 会 的 三 角 联 盟 ， 推 进 其 转 向 非 洲 社 会 主 义 ； 最 后 则 是 选 择 建 制 派 ， 以 密 切 双 边 贸 易 与 经 济 合 作 的 方 式 快 速 解 决 南 非 政 治 危 机 ， 并 在 南 非 推 动 亲 中 政 治 力 量 就 位 。 考 虑 到 南 非 在 曾 同 我 国 建 交 的 两 年 内 便 可 达 成 价 值 一 千 三 百 万 美 元 的 合 同 ， 以 及 南 非 作 为 铀 矿 、 钻 石 与 多 种 热 带 农 贸 产 品 主 产 国 的 优 越 地 位 。 我 们 没 理 由 放 跑 煮 熟 的 鸭 子 … … ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 6;
		if (a.data[56] < 3 && a.allcountries[132].cw && a.allcountries[131].cw && a.influencePRC > 600)
		{
			button_text[0] = " 给 博 塔 政 权 个 痛 快 ， 阿 扎 尼 亚 归 阿 扎 尼 亚 人 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 阿 扎 尼 亚 ？ 那 是 哪 个 国 家 ？";
		}
		if (a.data[56] < 2 && a.relres && a.allcountries[1].isOVD && a.allcountries[131].cw && a.allcountries[127].Gosstroy != 3 && a.allcountries[126].Gosstroy != 3 && a.allcountries[129].Gosstroy != 3 && !a.allcountries[127].Vyshi && !a.allcountries[126].Vyshi && !a.allcountries[129].Vyshi)
		{
			button_text[1] = " 让 我 们 与 苏 联 一 起 为 局 势 火 上 浇 油 ！ ";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 怎 能 支 持 反 华 的 南 非 共 产 党 ？ 怎 么 支 持 反 华 的 南 非 共 产 党 ？";
		}
		if (a.allcountries[1].Gosstroy == 3 && a.allcountries[131].cw && GlobalScript.inst.gameState.allcountries[51].dev == 1 && a.allcountries[127].puppetOf < 0 && a.empires[0].power > a.empires[1].power && a.influencePRC > 500)
		{
			button_text[2] = " 我 们 是 不 是 可 以 在 这 个 问 题 上 和 自 由 世 界 合 作 ？";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 指 望 洋 基 佬 发 善 心 ？ 你 想 发 扬 甘 地 的 阿 Q 精 神 ？";
		}
		if (a.data[56] > 0 && a.allcountries[131].cw && a.empires[0].relations >= 650 && a.empires[1].relations >= 650 && a.influencePRC > 500)
		{
			button_text[3] = " 我 们 将 与 超 级 大 国 携 手 施 压 南 非 政 府 ， 为 了 全 人 类 的 自 由 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 冷 战 摧 毁 了 美 苏 两 国 在 南 非 问 题 上 合 作 的 可 能";
		}
		if (a.data[56] > 1 && a.allcountries[1].Gosstroy != 1 && a.influencePRC > 500)
		{
			button_text[4] = " 此 时 雪 中 送 炭 能 卖 的 价 钱 肯 定 不 少 ！";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 真 的 吗 ？ 就 算 我 们 无 耻 至 极 ， 也 不 排 除 热 脸 贴 冷 屁 股 的 可 能 ！";
		}
		button_text[5] = " 可 是 南 非 离 我 们 太 远 了 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " “ 南 非 ” 意 味 着 攻 击";
		int num = 0;
		if (a.resultOfEvents[609] == 0)
		{
			num = 50;
		}
		if (result_num == 0)
		{
			if (a.allcountries[153].Gosstroy == 1)
			{
				text = " 由 于 阿 扎 尼 亚 泛 非 主 义 大 会 与 西 南 非 洲 民 族 联 盟 内 部 的 毛 主 义 派 系 早 已 在 我 国 支 持 下 就 位 ， 我 们 得 以 将 阿 扎 尼 亚 人 民 解 放 军 （ 阿 扎 尼 亚 泛 非 主 义 大 会 的 军 事 翼 ） 、 阿 扎 尼 亚 民 族 解 放 军 （ 阿 扎 尼 亚 人 民 组 织 的 军 事 翼 ） 和 西 南 非 洲 民 族 联 盟 的 游 击 队 组 织 在 统 一 战 线 下 迅 捷 出 击 ， 打 敌 人 个 措 手 不 及 ： 莱 索 托 国 王 收 到 了 阿 扎 尼 亚 人 民 解 放 军 勒 令 其 退 位 的 最 后 通 牒 ； P · W · 博 塔 总 统 、 国 防 部 长 马 格 努 斯 · 马 兰 与 康 斯 坦 德 · 维 尔 容 将 军 等 军 政 高 层 人 物 也 在 汽 车 炸 弹 袭 击 内 被 完 全 消 灭 。 因 此 ， 阿 扎 尼 亚 人 民 解 放 军 、 阿 扎 尼 亚 民 族 解 放 军 和 西 南 非 洲 民 族 联 盟 得 以 利 用 政 府 内 部 的 混 乱 与 我 国 情 报 协 助 发 起 对 南 非 武 装 部 队 的 全 线 进 攻 ； 非 洲 国 民 大 会 党 、 南 非 共 产 党 的 非 洲 之 矛 与 西 南 非 洲 人 民 解 放 军 （ 西 南 非 洲 人 民 组 织 的 军 事 翼 ） 也 在 不 久 后 加 入 混 战 ， 形 成 了 针 对 种 族 隔 离 政 权 的 多 路 诸 侯 。 全 世 界 都 正 关 注 南 非 内 战 局 势 ： 黑 人 对 白 人 的 种 族 复 仇 ， 白 人 对 黑 人 的 报 复 回 击 等 场 景 充 斥 各 地 ； 紧 急 状 态 下 的 南 非 成 为 了 一 个 大 型 难 民 营 。 联 合 国 试 图 派 遣 维 和 部 队 并 在 南 非 调 停 局 势 的 努 力 也 宣 告 失 效 ， 该 国 就 此 陷 入 内 战 泥 潭 。 ";
				a.ingamewars[54] = new War().Name("南 非 内 战").Attacker(" 阿 扎 尼 亚 联 军 ").Defender(" 南 非")
					.AttackerInfluence(400 + num)
					.DefenderInfluence(600 - num)
					.TickTime(24)
					.AmericanSupportDefender.CreateWar;
			}
			else
			{
				text = " 由 于 阿 扎 尼 亚 泛 非 主 义 大 会 的 民 族 主 义 者 早 已 在 我 国 支 持 下 就 位 ， 我 们 得 以 将 阿 扎 尼 亚 人 民 解 放 军 （ 阿 扎 尼 亚 泛 非 主 义 大 会 的 军 事 翼 ） 、 阿 扎 尼 亚 民 族 解 放 军 （ 阿 扎 尼 亚 人 民 组 织 的 军 事 翼 ） 和 西 南 非 洲 民 族 联 盟 的 游 击 队 组 织 在 统 一 战 线 下 迅 捷 出 击 ， 打 敌 人 个 措 手 不 及 ： 莱 索 托 国 王 收 到 了 阿 扎 尼 亚 人 民 解 放 军 勒 令 其 退 位 的 最 后 通 牒 ； P · W · 博 塔 总 统 、 国 防 部 长 马 格 努 斯 · 马 兰 与 康 斯 坦 德 · 维 尔 容 将 军 等 军 政 高 层 人 物 也 在 汽 车 炸 弹 袭 击 内 被 完 全 消 灭 。 因 此 ， 阿 扎 尼 亚 人 民 解 放 军 、 阿 扎 尼 亚 民 族 解 放 军 和 西 南 非 洲 民 族 联 盟 得 以 利 用 政 府 内 部 的 混 乱 与 我 国 情 报 协 助 发 起 对 南 非 武 装 部 队 的 全 线 进 攻 ； 非 国 大 、 南 非 共 产 党 的 非 洲 之 矛 与 西 南 非 洲 人 民 解 放 军 （ 西 南 非 洲 人 民 组 织 的 军 事 翼 ） 也 在 不 久 后 加 入 混 战 ， 形 成 了 针 对 种 族 隔 离 政 权 的 多 路 诸 侯 。 全 世 界 都 正 关 注 南 非 内 战 局 势 ： 黑 人 对 白 人 的 种 族 复 仇 ， 白 人 对 黑 人 的 报 复 回 击 等 场 景 充 斥 各 地 ； 紧 急 状 态 下 的 南 非 成 为 了 一 个 大 型 难 民 营 。 联 合 国 试 图 派 遣 维 和 部 队 并 在 南 非 调 停 局 势 的 努 力 也 宣 告 失 效 ， 该 国 就 此 陷 入 内 战 泥 潭 。 ";
				a.ingamewars[54] = new War().Name("南 非 内 战").Attacker(" 阿 扎 尼 亚 联 军 ").Defender(" 南 非")
					.AttackerInfluence(500 + num)
					.DefenderInfluence(500 - num)
					.TickTime(24)
					.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			}
			a.allcountries[131].parts[0] = true;
			a.allcountries[131].SubGosstroy = 9;
			a.data[9] -= 50;
			a.data[22] -= 120;
			a.empires[0].relations -= 150;
		}
		if (result_num == 1)
		{
			text = "由 于 亲 苏 力 量 早 在 南 非 外 围 取 得 完 胜 ， 我 们 得 以 更 好 地 武 装 三 方 联 盟 ： 非 洲 之 矛 与 非 国 大 武 装 力 量 开 始 在 安 哥 拉 与 莫 桑 比 克 接 受 苏 联 军 事 训 练 并 武 装 苏 械 。 P · W · 博 塔 总 统 、 国 防 部 长 马 格 努 斯 · 马 兰 与 康 斯 坦 德 · 维 尔 容 将 军 等 军 政 高 层 人 物 也 在 古 巴 人 谋 划 的 汽 车 炸 弹 袭 击 内 被 完 全 消 灭 。 因 此 ， 非 国 大 、 南 非 共 产 党 的 非 洲 之 矛 与 西 南 非 洲 人 民 解 放 军 （ 西 南 非 洲 人 民 组 织 的 军 事 翼 ） 得 以 利 用 政 府 内 部 的 混 乱 与 中 苏 两 国 情 报 协 助 发 起 对 南 非 武 装 部 队 的 全 线 进 攻 ； 阿 扎 尼 亚 泛 非 主 义 大 会 、 阿 扎 尼 亚 人 民 组 织 和 西 南 非 洲 民 族 联 盟 也 在 不 久 后 加 入 混 战 ， 形 成 了 针 对 种 族 隔 离 政 权 的 多 路 诸 侯 。 全 世 界 都 正 关 注 南 非 内 战 局 势 ： 黑 人 对 白 人 的 种 族 复 仇 ， 白 人 对 黑 人 的 报 复 回 击 等 场 景 充 斥 各 地 ； 紧 急 状 态 下 的 南 非 成 为 了 一 个 大 型 难 民 营 。 联 合 国 试 图 派 遣 维 和 部 队 并 在 南 非 调 停 局 势 的 努 力 也 宣 告 失 效 ， 该 国 就 此 陷 入 内 战 泥 潭 。";
			a.ingamewars[55] = new War().Name("南 部 非 洲 混 战").Attacker(" 非 国 大 联 军 ").Defender(" 南 非")
				.AttackerInfluence(500 + num)
				.DefenderInfluence(500 - num)
				.TickTime(24)
				.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			a.allcountries[131].parts[1] = true;
			a.allcountries[131].SubGosstroy = 9;
			a.data[9] -= 50;
			a.data[22] -= 60;
			a.empires[0].relations -= 150;
			a.empires[1].relations += 150;
		}
		if (result_num == 2)
		{
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "就 南 非 问 题 特 意 致 电 美 国 总 统 ， 认 定 该 国 目 前 的 混 乱 局 势 与 其 管 理 层 的 无 能 无 助 于 遏 制 非 洲 “ 共 产 主 义 麻 风 病 ” ， 且 南 非 本 身 也 极 可 能 在 五 年 内 沦 陷 。 卡 特 总 统 勉 为 其 难 地 赞 同 了 我 国 的 立 场 ， 并 委 托 中 央 情 报 局 “ 好 好 办 ” 。";
			if (a.empires[0].now_leader == 1)
			{
				text += "比 勒 陀 利 亚 在 不 久 后 便 进 入 戒 严 。 人 们 本 以 为 这 是 种 族 隔 离 政 权 的 惯 常 镇 压 ， 然 而 事 实 很 快 便 跑 过 了 传 言 ： 南 非 内 部 的 “ 激 进 改 革 派 ” 推 翻 了 博 塔 总 统 。 新 政 府 将 由 约 翰 内 斯 · 赫 尔 登 赫 伊 斯 将 军 牵 头 ， 与 被 中 情 局 收 买 的 国 防 部 长 马 格 努 斯 · 马 兰 一 同 “ 拨 乱 反 正 ” 。 他 们 宣 布 将 纠 正 “ 国 民 党 选 举 中 的 舞 弊 行 为 ” ， 邀 请 了 矿 业 大 亨 哈 利 · 奥 本 海 默 与 祖 鲁 国 王 参 与 组 阁 与 实 施 改 革 ， “ 真 相 与 和 解 委 员 会 ” 也 随 之 成 立 。 尽 管 政 变 上 位 这 一 举 措 本 身 遭 到 了 左 翼 势 力 的 谴 责 ， 但 南 非 当 局 很 快 便 通 过 “ 释 放 曼 德 拉 ” 的 信 号 将 其 — — 要 求 非 国 大 出 卖 共 产 党 达 成 和 解 的 提 议 确 实 得 到 了 前 者 的 芳 心 。 似 乎 南 非 正 以 退 为 进 ， 实 施 本 土 特 色 的 解 冻 时 刻 。 一 切 都 在 往 好 的 方 向 发 展 ， 对 吗 ？";
				a.allcountries[131].Gosstroy = 3;
				a.allcountries[131].SubGosstroy = 12;
				a.allcountries[131].Vyshi = true;
				a.allcountries[131].Torg = true;
			}
			else
			{
				text += "比 勒 陀 利 亚 在 不 久 后 便 进 入 戒 严 。 人 们 本 以 为 这 是 种 族 隔 离 政 权 的 惯 常 镇 压 ， 然 而 事 实 很 快 便 跑 过 了 传 言 ： 南 非 内 部 的 “ 保 守 派 ” 推 翻 了 博 塔 总 统 。 新 政 府 将 由 陆 军 总 帅 康 斯 坦 德 · 维 尔 容 将 军 牵 头 进 行 “ 拨 乱 反 正 ” ， 并 搜 查 “ 博 塔 总 统 修 宪 当 中 的 违 宪 行 为 ” 与 1 3 8 条 腐 败 指 控 。 政 变 立 即 遭 到 了 左 翼 势 力 的 谴 责 ， 而 维 尔 容 将 军 对 此 毫 不 手 软 ， 做 了 两 手 准 备 ： 一 面 让 一 批 黑 人 反 对 派 蹲 牢 房 ， 一 面 则 指 定 “ 民 主 人 士 ” ， 同 样 支 持 隔 离 政 策 的 安 德 里 斯 · 佩 特 鲁 斯 · 特 鲁 尼 希 特 充 当 临 时 政 府 花 瓶 领 导 人 。 维 尔 容 在 出 访 华 盛 顿 期 间 许 诺 进 一 步 改 革 种 族 隔 离 制 度 — — 这 话 当 然 只 对 美 国 选 民 有 用 。 接 下 来 便 是 实 施 本 土 特 色 的 解 冻 时 刻 ： 不 久 后 ， 反 抗 种 族 隔 离 的 斗 士 纳 尔 逊 · 曼 德 拉 于 被 特 赦 之 日 突 遭 激 进 派 黑 人 民 族 主 义 者 刺 杀 的 消 息 传 遍 全 国 … …||<color=red>变 革 的 声 音 传 达 到 了 华 盛 顿 ， 而 他 们 做 出 了 “ 最 好 的 安 排 ”</color> 。";
				a.allcountries[131].Vyshi = true;
				a.allcountries[131].Torg = true;
			}
		}
		if (result_num == 3)
		{
			text = " 通 过 中 国 外 交 官 的 协 调 ， 美 苏 两 国 得 以 在 南 非 问 题 上 达 成 共 识 并 通 力 合 作 ： 不 久 后 ， 美 国 便 在 外 交 照 会 上 加 强 对 南 非 政 权 的 制 裁 — — 其 中 包 括 限 制 军 备 出 售 ； “ 自 由 之 家 ” 对 南 非 的 评 级 也 从 “ 部 分 自 由 ” 改 为 “ 不 自 由 ” — — 理 由 是 博 塔 总 统 试 图 通 过 修 宪 实 现 独 裁 ， 从 而 终 结 南 非 民 主 事 业 。 与 此 同 时 ， 苏 联 也 带 领 东 方 集 团 各 国 正 式 谴 责 南 非 政 权 ， 并 宣 布 将 制 裁 一 切 与 南 非 有 商 贸 往 来 的 国 家 。 曾 驻 列 宁 格 勒 的 南 非 喷 气 机 开 发 小 组 被 遣 返 ， 苏 东 诸 国 同 南 非 的 ” 秘 密 合 同 “ 也 被 以 史 塔 西 为 代 表 的 安 全 机 构 叫 停 。 博 塔 总 统 不 久 后 便 因 内 忧 外 患 而 遭 弹 劾 ， 为 改 革 派 政 客 F · W · 德 克 勒 克 取 代 ， 德 克 勒 克 一 上 任 即 宣 布 开 启 民 主 改 革 ， 并 将 就 改 革 细 则 同 与 以 黑 人 为 主 的 非 洲 人 国 民 大 会 进 行 政 治 协 商 。 南 非 共 产 党 也 将 在 此 后 获 得 合 法 地 位 。 对 于 南 非 的 “ 洗 心 革 面 ” ， 全 世 界 都 正 拭 目 以 待 … …";
			a.allcountries[131].Gosstroy = 3;
			a.allcountries[131].SubGosstroy = 5;
			a.allcountries[131].Torg = true;
			a.data[9] -= 100;
			a.data[8] -= 100;
			a.empires[0].relations += 150;
			a.empires[1].relations += 150;
		}
		if (result_num == 4)
		{
			text = " 我 们 为 博 塔 政 权 释 放 了 友 好 信 号 ， 并 派 遣 （ 外 长 名 ） 私 访 南 非 打 探 口 风 。 然 而 ” 南 非 的 鳄 鱼 ” 博 塔 却 声 称 合 作 的 关 键 在 “ 我 方 诚 意 如 何 ” — — 只 要 中 国 能 批 准 有 利 于 南 非 贸 易 顺 差 的 歧 视 性 贸 易 条 款 ， 在 “ 民 用 核 技 术 ” 达 成 合 作 ， 以 及 做 出 停 止 支 持 南 部 非 洲 左 派 势 力 的 保 证 ； 那 么 南 非 必 将 改 弦 更 张 ： 一 方 面 彻 底 断 绝 同 台 湾 国 民 党 政 权 与 海 外 反 华 势 力 的 合 作 关 系 ， 一 方 面 则 与 我 国 达 成 使 用 南 非 雇 佣 兵 的 长 期 军 事 合 同 ， 最 终 形 成 外 交 上 的 中 南 共 进 退 格 局 。 综 合 评 估 效 益 后 ， 我 们 愉 快 地 达 成 了 协 定 。 代 价 自 然 是 非 洲 诸 国 的 集 体 谴 责 与 公 报 断 交 ， 乃 至 各 地 “ 进 步 主 义 ” 对 中 南 邪 恶 联 盟 的 敌 意 。 国 际 社 会 上 有 关 中 国 与 种 族 主 义 分 子 合 作 的 传 言 四 起 … …";
			a.allcountries[131].Gosstroy = 2;
			a.allcountries[131].SubGosstroy = 8;
			a.allcountries[131].LeaveAlliances();
			a.allcountries[131].EstablishGovernment(Government.ProChina);
			a.allcountries[131].Torg = true;
			a.data[8] -= 250;
			a.data[3] -= 150;
			a.data[4] += 150;
			a.data[13] += 100;
			a.influencePRC -= 100;
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (((i >= 52 && i < 69) || (i > 105 && i < 109) || (i > 111 && i < 134) || i == 41 || i == 42 || i == 52 || i == 99 || i == 100 || i == 150 || i == 151) && i != 128 && (a.allcountries[i].Gosstroy == 1 || a.allcountries[i].Gosstroy == 2 || a.allcountries[i].SubGosstroy == 0))
				{
					a.allcountries[i].proprc = false;
					a.allcountries[i].econ = false;
					a.allcountries[i].okb = false;
					a.allcountries[i].Torg = false;
				}
			}
		}
		if (result_num == 5)
		{
			text = " 无 事 发 生 ， 虽 说 南 非 政 权 每 日 江 河 日 下 ， 但 却 死 而 不 僵 。 摇 摇 欲 坠 的 种 族 隔 离 政 权 短 期 内 毫 无 垮 台 的 迹 象 ， 所 谓 “ 自 由 世 界 ” 依 然 在 制 裁 与 撤 资 的 同 时 发 展 同 南 非 的 “ 建 设 性 关 系 ” ， 为 其 无 望 地 输 血 。";
		}
	}
}
