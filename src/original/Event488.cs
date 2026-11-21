using EventsForDLC;
using UnityEngine;

public class Event488 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 公 开 集 结";
		text = " 我 们 在 波 兰 与 匈 牙 利 的 同 志 传 来 了 有 趣 的 消 息 。 由 于 国 际 局 势 风 云 突 变 ， 民 主 德 国 领 导 层 苦 心 构 建 的 “ 社 会 主 义 橱 窗 ” 正 处 于 濒 临 违 约 的 境 地 。 众 所 周 知 ， 昂 纳 克 政 府 治 下 的 东 德 社 会 奇 迹 不 过 是 建 立 在 西 德 贷 款 、 苏 联 扶 持 与 经 互 会 内 循 环 三 层 嵌 套 体 系 上 的 空 中 楼 阁 。 这 均 出 自 主 管 民 主 德 国 经 济 的 二 号 人 物 君 特 · 米 塔 格 的 手 笔 ： 他 曾 通 过 第 三 方 媒 介 与 秘 密 交 易 的 形 式 与 联 邦 德 国 勾 结 ， 为 国 家 产 业 发 展 筹 集 资 金 ； 并 利 用 经 济 互 助 委 员 会 内 部 的 国 际 分 工 体 系 为 东 德 企 业 产 品 打 开 销 路 ， 从 而 形 成 良 性 循 环 。 而 在 西 德 强 硬 派 上 台 ， 拒 绝 继 续 奉 行 “ 以 贸 促 变 ” 政 策 ； 乃 至 经 互 会 本 身 的 合 作 形 式 也 越 加 浮 于 表 面 的 背 景 下 。 东 德 本 身 的 局 势 便 愈 加 焦 灼 ： 得 知 苏 联 甚 至 会 减 少 对 盟 友 补 助 ， 奉 行 收 缩 政 策 的 消 息 后 。 东 德 当 局 决 定 效 法 波 兰 式 紧 缩 政 策 （ 即 一 次 性 抬 高 日 用 消 费 品 价 格 筹 资 ， 并 降 低 工 人 工 资 ， 抬 高 劳 动 强 度 ） 。 这 一 的 做 法 更 是 彻 底 引 爆 了 局 势 。 第 一 次 示 威 活 动 在 莱 比 锡 举 行 ， 每 天 都 会 重 复 。 随 后 东 德 其 他 主 要 城 市 也 开 始 举 行 示 威 活 动 。 随 后 的 几 天 里 ， 德 累 斯 顿 、 哈 勒 、 卡 尔 · 马 克 思 城 、 马 格 德 堡 、 普 劳 恩 、 阿 恩 施 塔 特 、 罗 斯 托 克 、 波 茨 坦 和 什 未 林 加 入 了 运 动 。 政 治 口 号 也 从 “ 面 包 与 和 平 ” 上 升 到 了 “ 工 人 当 家 做 主 人 ” 和 “ 统 社 党 滚 蛋 ” 之 类 的 政 治 性 口 号 。 城 中 部 队 为 避 免 流 血 而 拒 绝 了 对 人 民 开 火 。 很 明 显 东 德 社 会 处 在 危 机 之 中 ， 稍 有 不 慎 便 会 搅 个 地 覆 天 翻 . . . . . . 不 过 考 虑 到 混 乱 即 阶 梯 ， 我 们 说 不 定 能 借 用 这 一 机 会 ， 撬 动 苏 联 在 欧 洲 前 线 最 忠 实 的 盟 友 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 我 们 将 承 担 作 为 “ 老 大 哥 ” 的 义 务 ， 帮 助 昂 纳 克 政 府 渡 过 难 关";
		if (a.allcountries[1].Gosstroy <= 1)
		{
			button_text[1] = " 我 们 支 持 一 位 铁 腕 人 物 掌 管 大 局";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 这 样 的 人 和 法 西 斯 有 什 么 区 别 ？";
		}
		if (a.allcountries[1].Gosstroy == 2 || a.allcountries[1].Gosstroy == 3 || a.data[16] >= 13)
		{
			button_text[2] = " 呼 吁 德 国 开 始 改 革";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 想 要 也 不 希 望 这 样 的 德 国";
		}
		if (!a.allcountries[2].prosov && !a.allcountries[4].prosov && !a.allcountries[5].prosov && a.influencePRC >= 500 && a.allcountries[1].Gosstroy != 0 && a.allcountries[1].Gosstroy != 3)
		{
			button_text[3] = " 在 东 德 境 内 煽 动 民 粹 主 义 ， 并 挑 选 我 们 乐 见 的 统 社 党 代 理 人";
		}
		else if (a.allcountries[2].prosov || a.allcountries[4].prosov || a.allcountries[5].prosov)
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 在 欧 洲 可 没 有 找 不 到 撬 动 局 势 的 支 点";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 没 必 要 和 党 阀 狼 狈 为 奸";
		}
		button_text[4] = " 统 社 党 的 反 应 力 是 暴 民 的 七 倍 ， 要 是 被 威 胁 了 自 己 会 滚";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 公 开 集 结";
		if (result_num == 0)
		{
			int num = 0;
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].isSEV)
				{
					num++;
				}
			}
			text = " 我 们 察 觉 了 东 德 人 现 在 的 困 境 。 为 此 ， 我 们 慷 慨 的 提 出 了 一 笔 合 适 的 买 卖 。 我 们 以 承 担 民 主 德 国 全 部 外 债 作 为 保 障 ， 换 取 其 彻 底 摆 脱 苏 联 。";
			if (num < 5)
			{
				text = " 意 识 到 苏 东 集 团 已 是 明 日 黄 花 ， 昂 纳 克 集 团 识 时 务 地 选 择 跳 船 。 在 统 社 党 高 层 彻 夜 的 谈 话 后 ， 笠 日 的 报 纸 上 刊 登 了 民 主 德 国 决 定 终 止 与 苏 联 间 各 项 合 作 条 约 的 新 闻 。 昂 纳 克 宣 布 接 受 我 们 的 援 助 ， 并 开 始 在 政 策 上 左 转 。 该 国 的 经 济 在 我 国 与 波 兰 援 助 者 的 协 助 下 得 以 稳 定 ， 骚 乱 也 随 之 平 息 。 而 随 后 的 便 是 宣 布 去 苏 联 化 ， 民 主 德 国 把 驻 德 苏 军 遣 送 回 国 ， 并 下 定 决 心 退 出 了 经 济 互 助 委 员 会 和 华 沙 条 约 组 织 。 ";
				a.data[8] -= 200;
				a.data[9] -= 50;
				a.allcountries[16].LeaveAlliances();
				a.allcountries[16].proprc = true;
				a.allcountries[16].SubGosstroy = 1;
				a.allcountries[16].JoinAllOurAlliances(yes: true);
				a.allcountries[16].Torg = true;
				a.influencePRC += 50;
				a.empires[1].power -= 50;
				a.empires[1].relations -= 300;
			}
			else
			{
				text += " 然 而 ， 昂 纳 克 依 然 在 苏 东 一 体 化 与 完 全 向 我 国 一 边 倒 间 举 棋 不 定 。 在 统 社 党 高 层 彻 夜 的 谈 话 后 ， 我 们 最 终 达 成 妥 协 ： 中 国 以 承 担 民 主 德 国 一 半 外 债 与 优 惠 贷 款 为 代 价 ， 交 换 民 主 德 国 方 减 少 苏 联 的 联 系 并 实 行 多 边 外 交 政 策 。 剩 下 的 资 金 则 仰 仗 自 建 劳 动 集 体 与 发 展 中 小 企 业 解 决 。 该 国 的 经 济 在 我 国 与 波 兰 援 助 者 的 协 助 下 得 以 稳 定 ， 骚 乱 也 随 之 平 息 。 民 主 德 国 把 驻 德 苏 军 遣 送 回 国 ， 但 仍 保 持 经 济 互 助 委 员 会 的 成 员 身 份 。";
				a.data[8] -= 100;
				a.data[9] -= 50;
				a.allcountries[16].isOVD = false;
				a.allcountries[16].prosov = false;
				a.allcountries[16].SubGosstroy = 1;
				a.allcountries[16].Torg = true;
				a.influencePRC += 20;
				a.empires[1].power -= 20;
				a.empires[1].relations -= 200;
			}
		}
		if (result_num == 1)
		{
			text = " 当 昂 纳 克 在 柏 林 的 理 疗 所 治 病 时 ， 一 场 由 我 们 牵 头 的 阴 谋 正 在 酝 酿 之 中 。 埃 里 希 · 米 尔 克 在 昂 纳 克 对 民 族 敌 人 的 消 极 态 度 感 到 非 常 不 满 ， 并 确 信 世 界 局 势 不 稳 定 会 使 国 内 出 现 不 稳 定 局 势 。 因 为 昂 纳 克 随 时 可 能 死 去 ， 而 这 必 然 导 致 血 雨 腥 风 。 我 们 也 及 时 的 暗 示 了 东 德 方 面 ， 我 们 希 望 看 到 事 态 的 进 一 步 发 展 。 而 凯 斯 勒 大 将 长 期 以 来 一 直 在 谈 论 需 要 改 变 国 家 的 亲 苏 立 场 ， 及 时 脱 离 苏 联 阵 营 。 在 获 得 国 家 人 民 军 的 支 持 后 ， 米 尔 克 意 识 到 时 间 到 了 。 他 便 开 始 夺 取 权 力 。 第 二 天 一 早 ， 政 治 局 在 一 场 突 击 会 议 上 决 定 因 健 康 原 因 ， 任 命 米 尔 克 同 志 为 新 任 第 一 书 记 。 昂 纳 克 则 宣 布 辞 职 ， 这 位 前 统 治 者 立 刻 逃 往 智 利 并 寻 求 政 治 庇 护 。 新 领 袖 的 下 一 步 是 对 统 一 社 会 党 的 改 组 。\n 权 力 已 然 易 手 ， 而 下 一 步 则 更 令 人 惊 叹 ， 米 尔 克 宣 布 将 走 “ 有 德 意 志 民 族 特 色 的 社 会 主 义 道 路 ” 。 其 中 包 括 但 不 局 限 于 “ 马 克 思 主 义 是 德 意 志 的 传 统 ” ， “ 德 国 的 统 一 也 是 阶 级 斗 争 的 一 部 分 ” 。 甚 至 还 有 平 反 参 与 “ 瓦 尔 基 里 行 动 ” 的 一 些 纳 粹 战 犯 。 苏 联 驻 东 德 的 军 人 被 勒 令 回 国 。 两 个 德 国 间 的 关 系 日 益 紧 张 。\n 人 们 惊 恐 地 看 着 一 个 特 务 头 子 夺 走 了 权 力 ， 反 对 派 开 始 利 用 这 一 事 实 渲 染 恐 怖 的 氛 围 。 但 史 塔 西 的 铁 拳 会 教 他 们 怎 么 当 个 好 共 产 主 义 者 ！";
			a.data[6] += 100;
			a.allcountries[16].Gosstroy = 0;
			a.allcountries[16].SubGosstroy = 10;
			a.allcountries[16].LeaveAlliances();
			a.allcountries[16].proprc = true;
			a.allcountries[16].Torg = true;
			a.data[9] -= 200;
			a.data[8] -= 30;
			a.influencePRC += 5;
			a.empires[0].relations -= 500;
			a.empires[1].relations -= 500;
		}
		if (result_num == 2)
		{
			text = " 当 昂 纳 克 在 柏 林 的 理 疗 所 治 病 时 ， 一 场 由 我 们 和 苏 联 改 革 家 们 牵 头 的 阴 谋 正 在 酝 酿 之 中 。 埃 贡 · 克 伦 茨 得 到 了 苏 联 方 面 的 担 保 ， 而 他 得 以 通 过 一 套 在 罗 斯 托 克 的 海 滨 别 墅 说 服 米 尔 克 支 持 他 。 他 急 切 的 需 要 支 持 者 ， 因 为 昂 纳 克 随 时 可 能 死 去 ， 而 这 必 然 导 致 血 雨 腥 风 。 我 们 也 及 时 的 暗 示 了 东 德 方 面 ， 我 们 希 望 看 到 事 态 的 进 一 步 发 展 。 而 凯 斯 勒 大 将 长 期 以 来 一 直 在 谈 论 需 要 改 变 国 家 的 亲 苏 立 场 ， 及 时 脱 离 苏 联 阵 营 。 在 获 得 国 家 人 民 军 的 支 持 后 ， 克 伦 茨 意 识 到 时 间 到 了 。 他 便 开 始 夺 取 权 力 。 第 二 天 一 早 ， 政 治 局 在 一 场 突 击 会 议 作 出 了 如 下 决 议 ： 因 健 康 原 因 ， 任 命 克 伦 茨 同 志 为 新 任 第 一 书 记 。 昂 纳 克 则 被 开 除 党 籍 ， 这 位 前 统 治 者 立 刻 逃 往 智 利 并 寻 求 政 治 庇 护 。 新 领 袖 的 下 一 步 是 对 统 一 社 会 党 的 改 组 ， 并 开 展 民 主 德 国 版 的 “ 开 放 性 ” 和 “ 改 革 ” 政 策 。";
			a.data[8] -= 100;
			a.data[9] -= 50;
			a.allcountries[16].prosov = false;
			a.allcountries[16].Gosstroy = 2;
			a.allcountries[16].SubGosstroy = 3;
			a.allcountries[16].Torg = true;
		}
		if (result_num == 3)
		{
			if (a.allcountries[1].Gosstroy == 1)
			{
				text = " 我 方 及 欧 洲 盟 友 控 制 下 的 媒 体 一 面 声 援 东 德 群 众 ， 一 面 则 将 社 会 骚 乱 的 责 任 完 全 归 咎 于 米 塔 尔 失 败 主 义 集 团 。 声 称 其 治 下 的 “ 德 国 社 会 奇 迹 ” 只 是 外 债 社 会 主 义 的 又 一 类 变 种 ， 并 将 两 德 间 秘 密 交 易 的 实 况 与 部 分 难 辨 真 假 的 情 报 混 合 一 致 。 在 东 德 群 众 眼 中 造 就 了 民 主 德 国 现 任 当 局 与 联 邦 德 国 建 制 派 集 团 间 已 达 成 秘 密 合 作 ， 有 意 识 破 坏 东 德 经 济 社 会 建 设 的 印 象 ， 民 主 德 国 版 的 “ 国 防 威 胁 论 ” 便 得 以 该 国 境 内 喧 嚷 其 上 。 波 兰 盟 友 也 趁 机 派 遣 特 勤 部 队 越 过 波 德 边 界 ， 一 面 干 扰 史 塔 西 与 国 家 人 民 军 恢 复 秩 序 的 工 作 ， 一 面 则 打 入 激 进 活 动 群 体 内 ， 瓦 解 消 灭 其 中 持 反 社 会 主 义 立 场 的 头 目 。 对 党 政 高 官 的 质 疑 与 压 制 行 动 的 失 败 最 终 使 用 人 不 善 的 埃 里 希 · 昂 纳 克 与 罪 魁 祸 首 君 特 · 米 塔 格 不 得 不 自 请 隐 退 ； 东 德 意 识 形 态 秘 书 哈 格 、 部 长 会 议 主 席 威 利 · 斯 托 夫 和 斯 塔 西 负 责 人 埃 里 希 · 米 尔 克 等 高 级 行 政 干 部 也 纷 纷 引 咎 辞 职 。 东 德 高 层 出 现 的 政 治 真 空 让 我 们 挑 选 的 代 理 人 ， 掌 管 柏 林 地 区 的 第 一 书 记 康 拉 德 · 瑙 曼 得 了 便 宜 ： 他 能 在 共 青 团 、 基 层 共 产 党 员 和 工 人 内 赢 取 广 泛 支 持 ， 其 亲 近 正 统 社 会 主 义 的 立 场 最 受 资 产 阶 级 知 识 分 子 厌 恶 。 随 后 ， 瑙 曼 便 带 着 我 们 的 援 助 与 许 诺 “ 降 低 物 价 、 开 放 政 治 、 肃 清 外 敌 并 恢 复 社 会 主 义 人 民 性 ” 的 口 号 ， 首 先 组 织 起 工 人 民 兵 团 ， 恢 复 了 首 都 地 区 秩 序 ， 随 后 便 通 过 引 入 宵 禁 、 拓 宽 福 利 与 赋 权 劳 动 集 体 的 方 式 稳 定 局 势 。 如 此 功 绩 自 然 使 其 在 统 一 社 会 党 的 特 别 代 表 大 会 上 被 选 为 新 任 总 书 记 。 东 德 新 任 领 导 人 并 未 忘 记 我 们 的 帮 助 ： 几 乎 在 新 领 导 集 体 形 成 与 秩 序 稳 定 的 第 二 天 ， 便 以 苏 联 克 格 勃 协 助 策 动 骚 乱 ， 干 预 东 德 内 政 ， 破 坏 东 德 社 会 主 义 事 业 为 由 。 遣 返 了 驻 德 苏 军 ， 并 加 入 了 我 们 的 怀 抱 。";
				a.data[8] -= 250;
				a.data[9] -= 200;
				a.data[22] -= 100;
				a.influencePRC += 50;
				a.empires[1].power -= 50;
				a.empires[1].relations -= 400;
				a.allcountries[16].LeaveAlliances();
				a.allcountries[16].proprc = true;
				a.allcountries[16].SubGosstroy = 2;
				a.allcountries[16].JoinAllOurAlliances(yes: true);
				a.allcountries[16].Torg = true;
			}
			else
			{
				text = " 我 方 及 欧 洲 盟 友 控 制 下 的 媒 体 一 面 声 援 东 德 群 众 ， 一 面 则 将 社 会 骚 乱 的 责 任 完 全 归 咎 于 昂 纳 克 - 米 塔 尔 集 团 。 声 称 其 治 下 的 “ 德 国 社 会 奇 迹 ” 只 是 外 债 社 会 主 义 的 又 一 类 变 种 ， 并 将 两 德 间 秘 密 交 易 的 实 况 与 部 分 难 辨 真 假 的 情 报 混 合 一 致 。 在 东 德 群 众 眼 中 造 就 了 民 主 德 国 现 任 当 局 与 联 邦 德 国 建 制 派 集 团 间 已 达 成 秘 密 合 作 ， 有 意 识 破 坏 东 德 经 济 社 会 建 设 的 印 象 ， 民 主 德 国 版 的 “ 国 防 威 胁 论 ” 便 得 以 该 国 境 内 喧 嚷 其 上 。 波 兰 盟 友 也 趁 机 派 遣 特 勤 部 队 越 过 波 德 边 界 ， 一 面 干 扰 史 塔 西 与 国 家 人 民 军 恢 复 秩 序 的 工 作 ， 一 面 则 打 入 激 进 活 动 群 体 内 ， 瓦 解 消 灭 其 中 持 教 条 社 会 主 义 立 场 的 头 目 。 对 党 政 高 官 的 质 疑 与 压 制 行 动 的 失 败 最 终 使 得 罪 魁 祸 首 埃 里 希 · 昂 纳 克 与 君 特 · 米 塔 格 不 得 不 自 请 隐 退 ； 东 德 意 识 形 态 秘 书 哈 格 、 部 长 会 议 主 席 威 利 · 斯 托 夫 和 斯 塔 西 负 责 人 埃 里 希 · 米 尔 克 等 高 级 行 政 干 部 也 纷 纷 引 咎 辞 职 。 东 德 高 层 出 现 的 政 治 真 空 让 我 们 挑 选 的 代 理 人 ， 年 轻 的 党 政 官 僚 君 特 · 沙 博 夫 斯 基 得 了 便 宜 ： 他 缺 乏 意 识 形 态 原 则 性 ， 精 于 实 事 求 是 ， 跟 随 总 路 线 一 贯 摇 摆 ； 被 同 事 冠 以 “ 两 面 人 ” （ W e n d e h a l s ） ， 最 有 助 于 推 进 东 德 本 身 的 改 革 。 随 后 ， 沙 博 夫 斯 基 便 带 着 我 们 的 援 助 与 许 诺 “ 降 低 物 价 、 开 放 政 治 、 肃 清 外 敌 并 恢 复 东 德 国 家 主 权 ” 的 口 号 ， 首 先 恢 复 了 首 都 地 区 秩 序 ， 随 后 便 通 过 引 入 宵 禁 、 拓 宽 福 利 与 许 诺 政 治 自 由 的 方 式 稳 定 局 势 。 如 此 功 绩 自 然 使 其 在 统 一 社 会 党 的 特 别 代 表 大 会 上 被 选 为 新 任 总 书 记 。 东 德 新 任 领 导 人 并 未 忘 记 我 们 的 帮 助 ： 几 乎 在 新 领 导 集 体 形 成 与 秩 序 稳 定 的 第 二 天 ， 便 以 苏 联 克 格 勃 协 助 策 动 骚 乱 ， 干 预 东 德 内 政 ， 威 胁 东 德 国 家 主 权 为 由 。 遣 返 了 驻 德 苏 军 ， 并 加 入 了 我 们 的 怀 抱 。";
				a.data[8] -= 250;
				a.data[9] -= 200;
				a.data[22] -= 100;
				a.influencePRC += 50;
				a.empires[1].power -= 50;
				a.empires[1].relations -= 400;
				a.allcountries[16].LeaveAlliances();
				a.allcountries[16].proprc = true;
				a.allcountries[16].JoinAllOurAlliances(yes: true);
				a.allcountries[16].Torg = true;
				a.allcountries[16].prosov = false;
				a.allcountries[16].Gosstroy = 2;
				a.allcountries[16].SubGosstroy = 15;
			}
		}
		if (result_num != 4)
		{
			return;
		}
		if (a.empires[1].power >= 100 && a.allcountries[7].isOVD)
		{
			text = " 在 苏 联 驻 军 和 史 塔 西 的 帮 助 下 ， 暴 乱 迅 速 的 被 镇 压 下 去 了 ， 东 德 继 续 如 此 生 活 数 十 年 … …";
		}
		else if (a.empires[1].power < 100 || !a.allcountries[7].isOVD)
		{
			text = " 很 快 ， 群 众 不 满 足 于 简 单 的 抗 议 。 一 部 分 前 国 家 人 民 军 官 兵 和 工 人 阶 级 战 斗 队 的 成 员 抓 住 机 会 煽 动 对 统 社 党 的 暴 力 抗 议 。 愤 怒 的 群 众 砸 毁 了 史 塔 西 大 楼 。 苏 联 由 于 撤 军 ， 拒 绝 对 民 主 德 国 进 行 武 装 干 涉 。 我 们 希 望 不 会 有 太 糟 糕 的 事 情 发 生 … …||";
			a.allcountries[16].cw = true;
			if (a.allcountries[17].SubGosstroy == 9)
			{
				text += " 然 而 ， 我 们 所 预 估 的 最 糟 糕 情 况 还 是 发 生 了 。 雷 默 宣 布 将 “ 帮 助 对 面 的 民 族 兄 弟 恢 复 秩 序 ” 。 德 国 国 防 军 跨 过 了 边 境 线 ， 迅 速 攻 占 了 大 半 个 民 主 德 国 。 统 社 党 ， 波 兰 人 大 惊 失 色 ， 纷 纷 逃 亡 周 围 的 国 家 。 联 合 国 强 烈 谴 责 了 这 一 行 为 ， 但 于 事 无 补 。 德 国 在 铁 与 血 的 手 段 下 获 得 了 统 一 … …";
				a.allcountries[17].parts[0] = true;
				a.allcountries[17].dev = 2;
				a.allcountries[16].LeaveAlliances();
				a.allcountries[17].name = " 德 意 志 民 族 工 人 国";
				a.modifies[53].active = false;
			}
		}
	}
}
