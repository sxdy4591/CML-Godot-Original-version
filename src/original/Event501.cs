using EventsForDLC;
using UnityEngine;

public class Event501 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 西 方 - 8 1 演 习";
		text = " 据 可 靠 的 信 息 报 告 ， 苏 共 中 央 已 经 决 定 了 联 合 华 约 各 国 举 行 一 场 规 模 庞 大 的 军 事 演 习 ， 代 号 西 方 - 8 1 （ З а п а д - 8 1 ） 。 此 次 行 动 以 北 约 为 假 想 敌 ， 意 图 为 震 慑 波 兰 领 导 层 ， 遏 制 其 日 益 增 强 的 反 苏 情 结 。||主 席 同 志 ， 作 为 与 苏 联 接 壤 部 分 最 多 的 国 家 ， 我 们 应 该 做 点 什 么 ， 对 吧 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 口 头 谴 责 苏 联 人";
		if (a.data[56] < 2)
		{
			button_text[1] = " 在 华 北 组 织 一 场 军 事 演 习";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 为 什 么 要 耗 费 那 么 大 的 力 气 ？";
		}
		if (a.allcountries[1].isOVD)
		{
			button_text[2] = " 我 们 和 苏 联 展 开 联 合 演 习";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 没 人 会 欢 迎 我 们 的 介 入";
		}
		if (a.empires[1].relations >= 590)
		{
			button_text[3] = " 派 出 观 察 员";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 苏 联 人 不 欢 迎 我 们";
		}
		if (a.allcountries[1].isSEATO && a.allcountries[51].Torg)
		{
			button_text[4] = " 呼 吁 北 约 和 东 约 采 取 反 制 措 施";
			return;
		}
		Object.Destroy(button[4]);
		button_text[4] = " 不 能 把 祖 国 卖 给 美 国 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 西 方 - 8 1 演 习";
		if (result_num == 0)
		{
			text = " 外 交 部 长 " + a.names1[a.politics[a.politics_dolshnost[2]].name_1] + " " + a.names2[a.politics[a.politics_dolshnost[2]].name_2] + " 同 志 强 烈 谴 责 了 苏 修 帝 国 主 义 明 晃 晃 的 破 坏 世 界 和 平 的 举 动 。 称 其 为 极 不 明 智 的 举 动 ， 穷 兵 黩 武 只 会 埋 葬 了 苏 联 。||苏 军 出 动 了 十 个 以 上 的 诸 兵 种 合 成 集 团 军 和 近 卫 坦 克 军 ， 在 前 线 航 空 兵 、 远 程 航 空 兵 以 及 国 土 防 空 军 的 伴 随 下 ， 进 行 了 大 纵 深 装 甲 合 成 突 击 战 术 的 演 练 。 苏 军 首 次 出 动 由 新 式 T 8 0 和 T 7 2 组 成 的 坦 克 军 对 假 想 敌 进 行 装 甲 冲 击 ， 辅 以 集 团 军 属 地 地 火 箭 营 进 行 精 确 战 术 打 击 ， 掩 护 后 继 的 摩 托 化 步 兵 继 续 前 进 ， 演 习 中 大 量 出 现 空 降 强 击 旅 ， O M G 集 群 等 多 种 苏 军 新 式 战 役 建 制 ， 同 时 波 罗 的 海 舰 队 还 出 动  了 基 辅 号 重 型 载 机 巡 洋 舰 掩 护 海 军 步 兵 重 装 突 击 上 陆 。 苏 军 在 演 习 中 也 大 量 进 行 复 杂 条 件 下 大 规 模 诸 兵 种 快 速 推 进 训 练 ， 总 兵 力 超 过 五 十 万 人 。 这 无 疑 震 撼 了 全 世 界 的 观 察 家 ， 苏 联 即 使 遭 受 了 不 少 挫 折 ， 依 然 有 能 力 当 社 会 主 义 大 家 庭 的 家 长 。";
			a.empires[1].relations -= 80;
			a.empires[1].power += 100;
		}
		if (result_num == 1)
		{
			text = " 出 于 对 抗 苏 联 的 威 胁 ， 我 们 决 定 在 华 北 平 原 展 开 一 场 军 事 演 习 ， 目 标 直 指 苏 联 的 威 胁 。 中 国 人 民 解 放 军 高 级 干 部 战 役 集 训 班 全 体 军 官 、 中 共 中 央 、 国 务 院 各 部 委 和 各 省 、 直 辖 市 、 自 治 区 主 要 领 导 人 ， 解 放 军 师 以 上 和 北 京 军 区 团 以 上 军 官 及 当 地 地 方 干 部 和 民 兵 共 3 万 2 千 余 人 观 摩 了 演 习 。";
			if (a.science[29])
			{
				text += "||在 整 场 演 习 中 ， 东 方 红 二 号 军 用 卫 星 的 运 用 更 是 令 人 惊 讶 。 红 军 在 演 习 中 ， 运 用 最 新 的 太 空 侦 查 和 拦 截 系 统 ， 截 获 并 摧 毁 了 蓝 军 发 射 的 一 枚 东 风 - 2 型 弹 道 导 弹 。 这 象 征 着 我 国 有 能 力 处 理 来 自 外 太 空 的 一 切 危 险 ， 也 极 大 的 刺 激 了 美 苏 双 方 研 究 军 事 卫 星 的 速 度 。";
			}
			if (a.science[21])
			{
				text += "||在 盛 大 的 阅 兵 式 上 ， 第 二 炮 兵 方 阵 带 来 了 压 箱 底 的 家 什 — 东 风 2 6 远 程 战 术 弹 道 导 弹 。 这 枚 导 弹 据 估 计 有 能 力 达 到 关 岛 甚 至 更 远 。 美 国 人 再 也 不 能 高 枕 无 忧 了 ！";
			}
			if (a.science[22])
			{
				text += "||在 演 习 中 ， 一 部 分 观 察 家 注 意 到 了 一 批 样 貌 奇 怪 的 飞 机 。 他 们 没 有 特 殊 的 作 战 手 段 却 频 频 起 飞 ， 身 旁 辅 助 的 两 架 歼 轰 - 7 搭 载 的 导 弹 却 能 准 确 的 击 中 蓝 军 雷 达 等 设 施 。 近 乎 无 效 化 了 蓝 军 的 防 空 措 施 。 在 阅 兵 式 中 ， 这 作 为 空 军 的 最 新 项 目 ： 青 云 - 1 型 电 子 支 援 机 和 歼 轰 - 7 E 型 电 子 歼 击 机 ， 以 及 搭 载 的 言 鸟 通 信 对 抗 系 统 。 我 们 可 以 自 豪 的 说 ， 再 也 没 有 雷 达 可 以 抓 住 我 们 的 飞 机 了 ！";
			}
			text += "||演 习 期 间 ， 参 演 部 队 连 同 保 障 部 队 共 出 动 1 1 . 4 万 余 人 ， 动 用 坦 克 、 装 甲 车 1 3 2 7 辆 ， 火 炮 1 5 4 1 门 ， 飞 机 4 7 5 架 ， 汽 车 1 0 6 0 6 辆 。 华 北 大 演 习 的 消 耗 约 占 当 年 军 费 的 十 六 分 之 一 ，国 务 院 特 批 拨 款 。 演 习 结 束 后 ， 于 9 月 1 9 日 上 午 在 张 家 口 机 场 进 行 ， 被 称 为 “ 1 9 8 1 年 华 北 大 阅 兵 ” ，";
			if (GlobalScript.inst.gameState.politics_dolshnost[1] != 150 && GlobalScript.inst.gameState.politics_dolshnost[1] != 200)
			{
				text += " 中 国 共 产 党 中 央 军 事 委 员 会 主 席 ";
				text += a.names1[a.politics[a.politics_dolshnost[1]].name_1];
				text += " ";
				text += a.names2[a.politics[a.politics_dolshnost[1]].name_2];
				text += " 和 最 高 领 导 人 ";
				text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
				text += " ";
				text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
				text += " 共 同 检 阅 了 解 放 军 和 民 兵 ， 并 发 表 了 讲 话 。";
			}
			else
			{
				text += " 中 国 共 产 党 中 央 军 事 委 员 会 主 席 兼 最 高 领 导 人 ";
				text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
				text += " ";
				text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
				text += " 检 阅 了 解 放 军 和 民 兵 ， 并 发 表 了 讲 话 。";
			}
			a.data[6] += 200;
			a.data[8] -= 60;
			a.data[22] -= 150;
			a.influencePRC += 150;
			a.empires[0].relations -= 50;
			a.empires[1].relations -= 150;
		}
		if (result_num == 2)
		{
			text = " 我 们 作 为 苏 联 社 会 主 义 阵 营 的 一 位 成 员 ， 自 然 有 义 务 和 家 长 走 在 一 起 ， 苏 联 欣 然 同 意 。 我 们 派 出 了 有 “ 铁 军 ” 美 称 的 中 国 人 民 解 放 军 第 1 2 7 师 参 与 演 习 。 他 们 将 作 为 演 习 的 特 别 嘉 宾 出 席 。||苏 军 出 动 了 十 个 以 上 的 诸 兵 种 合 成 集 团 军 和 近 卫 坦 克 军 ， 在 前 线 航 空 兵、远 程 航 空 兵 以 及 国 土 防 空 军 的 伴 随 下 ， 进 行 了 大 纵 深 装 甲 合 成 突 击 战 术 的 演 练 。 苏 军 首 次 出 动 由 新 式 T 8 0 和 T 7 2 组 成 的 坦 克 军 对 假 想 敌 进 行 装 甲 冲 击 ， 辅 以 集 团 军 属 地 地 火 箭 营 进 行 精 确 战 术 打 击 ， 掩 护 后 继 的 摩 托 化 步 兵 继 续 前 进 ， 演 习 中 大 量 出 现 空 降 强 击 旅 ， O M G 集 群 等 多 种 苏 军 新 式 战 役 建 制 ， 同 时 波 罗 的 海 舰 队 还 出 动 了 基 辅 号 重 型 载 机 巡 洋 舰 掩 护 海 军 步 兵 重 装 突 击 上 陆 。 苏 军 在 演 习 中 也 大 量 进 行 复 杂 条 件 下 大 规 模 诸 兵 种 快 速 推 进 训 练 ， 总 兵 力 超 过 五 十 万 人 。 这 无 疑 震 撼 了 全 世 界 的 观 察 家 ， 苏 联 即 使 遭 受 了 不 少 挫 折 ， 依 然 有 能 力 当 社 会 主 义 大 家 庭 的 家 长 。";
			a.data[6] += 100;
			a.influencePRC -= 100;
			a.empires[0].relations -= 200;
			a.empires[1].relations += 200;
			a.empires[1].power += 200;
		}
		if (result_num == 3)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[1] != 150 && GlobalScript.inst.gameState.politics_dolshnost[1] != 200)
			{
				text = " 我 们 决 定 向 苏 联 派 出 军 事 观 察 员 ， 苏 联 方 面 欣 然 接 受 。 以 " + a.names1[a.politics[a.politics_dolshnost[1]].name_1] + " " + a.names2[a.politics[a.politics_dolshnost[1]].name_2] + " 为 首 的 中 国 人 民 解 放 军 代 表 团 参 与 了 对 军 演 的 欣 赏 。||苏 军 出 动 了 十 个 以 上 的 诸 兵 种 合 成 集 团 军 和 近 卫 坦 克 军 ， 在 前 线 航 空 兵、远 程 航 空 兵 以 及 国 土 防 空 军 的 伴 随 下 ， 进 行 了 大 纵 深 装 甲 合 成 突 击 战 术 的 演 练 。 苏 军 首 次 出 动 由 新 式 T 8 0 和 T 7 2 组 成 的 坦 克 军 对 假 想 敌 进 行 装 甲 冲 击 ， 辅 以 集 团 军 属 地 地 火 箭 营 进 行 精 确 战 术 打 击 ， 掩 护 后 继 的 摩 托 化 步 兵 继 续 前 进 ， 演 习 中 大 量 出 现 空 降 强 击 旅 ， O M G 集 群 等 多 种 苏 军 新 式 战 役 建 制 ， 同 时 波 罗 的 海 舰 队 还 出 动 了 基 辅 号 重 型 载 机 巡 洋 舰 掩 护 海 军 步 兵 重 装 突 击 上 陆 。 苏 军 在 演 习 中 也 大 量 进 行 复 杂 条 件 下 大 规 模 诸 兵 种 快 速 推 进 训 练 ， 总 兵 力 超 过 五 十 万 人 。 这 无 疑 震 撼 了 全 世 界 的 观 察 家 ， 苏 联 即 使 遭 受 了 不 少 挫 折 ， 依 然 有 能 力 当 社 会 主 义 大 家 庭 的 家 长 。";
			}
			else
			{
				text = " 我 们 决 定 向 苏 联 派 出 军 事 观 察 员 ， 苏 联 方 面 欣 然 接 受 。 以 " + a.names1[GlobalScript.inst.gameState.leader.name_1] + " " + a.names2[GlobalScript.inst.gameState.leader.name_2] + " 为 首 的 中 国 人 民 解 放 军 代 表 团 参 与 了 对 军 演 的 欣 赏 。||苏 军 出 动 了 十 个 以 上 的 诸 兵 种 合 成 集 团 军 和 近 卫 坦 克 军 ， 在 前 线 航 空 兵、远 程 航 空 兵 以 及 国 土 防 空 军 的 伴 随 下 ， 进 行 了 大 纵 深 装 甲 合 成 突 击 战 术 的 演 练 。 苏 军 首 次 出 动 由 新 式 T 8 0 和 T 7 2 组 成 的 坦 克 军 对 假 想 敌 进 行 装 甲 冲 击 ， 辅 以 集 团 军 属 地 地 火 箭 营 进 行 精 确 战 术 打 击 ， 掩 护 后 继 的 摩 托 化 步 兵 继 续 前 进 ， 演 习 中 大 量 出 现 空 降 强 击 旅 ， O M G 集 群 等 多 种 苏 军 新 式 战 役 建 制 ， 同 时 波 罗 的 海 舰 队 还 出 动 了 基 辅 号 重 型 载 机 巡 洋 舰 掩 护 海 军 步 兵 重 装 突 击 上 陆 。 苏 军 在 演 习 中 也 大 量 进 行 复 杂 条 件 下 大 规 模 诸 兵 种 快 速 推 进 训 练 ， 总 兵 力 超 过 五 十 万 人 。 这 无 疑 震 撼 了 全 世 界 的 观 察 家 ， 苏 联 即 使 遭 受 了 不 少 挫 折 ， 依 然 有 能 力 当 社 会 主 义 大 家 庭 的 家 长 。";
			}
			a.data[6] += 80;
			a.data[22] += 30;
			a.influencePRC -= 50;
			a.empires[0].relations -= 100;
			a.empires[1].relations += 100;
			a.empires[1].power += 150;
		}
		if (result_num == 4)
		{
			text = " 在 中 央 军 委 的 提 议 下 ， 我 们 决 定 和 美 国 等 自 由 世 界 国 家 开 展 一 场 规 模 接 近 的 军 事 行 动 反 向 威 胁 苏 联 。 这 一 决 定 获 得 了 美 国 鹰 派 和 强 硬 反 苏 派 ， 尤 其 是 布 热 津 斯 基 的 支 持 。||最 后 ， 我 们 和 美 国 在 亚 太 地 区 召 开 了 “ 神 射 手 ” 行 动 ， 旨 在 模 拟 苏 联 和 朝 鲜 对 韩 国 发 动 的 第 二 次 朝 鲜 战 争 。 韩 国 和 日 本 积 极 的 参 与 了 作 战 演 习 。 我 们 和 美 国 的 关 系 更 紧 密 了 。 苏 联 也 不 得 不 把 远 东 和 中 亚 的 防 卫 等 级 再 次 提 高 。";
			a.data[6] += 100;
			a.influencePRC -= 100;
			a.empires[1].relations -= 100;
			a.empires[0].relations += 200;
			a.empires[0].power += 200;
		}
	}
}
