using EventsForDLC;
using UnityEngine;

public class Event521 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 8 4 0 工 程";
		text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 ， 如 你 所 知 ， 建 造 一 支 强 大 的 蓝 水 海 军 一 直 是 我 国 的 梦 想 。 而 现 在 ， 这 个 梦 想 在 我 们 强 大 的 工 业 水 平 下 得 以 实 现 。 但 是 ， 在 开 香 槟 前 还 有 一 个 重 要 的 问 题 。 我 们 的 舰 队 未 来 的 方 向 应 该 是 什 么 ？ 大 多 数 军 事 委 员 会 的 成 员 建 议 我 们 研 发 像 苏 联 那 样 的 导 弹 巡 洋 舰 ， 类 比 比 我 们 曾 经 提 出 过 的 0 5 5 方 案 ， 建 造 一 款 大 型 远 洋 导 弹 驱 逐 舰 ， 抑 或 是 追 赶 英 法 ， 建 造 航 母 。 这 每 一 项 都 将 花 费 不 少 资 金 ， 但 对 于 一 支 强 大 的 水 军 来 说 ， 这 没 有 什 么 难 的 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 进 行 0 5 5 型 导 弹 驱 逐 舰 的 研 发";
		button_text[1] = " 进 行 航 母 的 研 发";
		button_text[2] = " 英 国 人 做 不 到 的 事 ， 我 们 可 以 ！";
		button_text[3] = " 我 们 押 宝 于 长 期 计 划";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 8 4 0 工 程";
		if (result_num == 0)
		{
			text = " 我 们 在 大 量 的 手 稿 中 找 出 了 0 5 5 型 驱 逐 舰 的 设 计 草 图 ， 尽 管 已 经 过 去 了 数 十 年 ， 但 其 理 念 仍 然 不 输 时 代 。 很 快 ， 就 有 眼 尖 的 摄 影 爱 好 者 在 上 海 的 长 兴 岛 发 现 了 一 款 巨 大 的 “ 货 轮 ” 建 造 设 施 。 很 快 就 传 来 了 激 动 的 消 息 ， 0 5 5 已 经 完 成 了 下 水 。 采 用 全 燃 动 力 、 射 频 综 合 集 成 及 舰 载 通 用 垂 直 发 射 系 统 ， 由 中 国 人 民 解 放 军 海 军 7 0 1 研 究 所 设 计 、 江 南 造 船 厂 1 0 3 基 地 与 大 连 船 舶 8 1 2 工 厂 承 建 。 0 5 5 型 导 弹 驱 逐 舰 是 全 亚 洲 ， 乃 至 全 世 界 都 排 得 上 号 的 大 型 水 面 舰 艇 。 此 型 舰 的 服 役 标 志 着 中 国 驱 逐 舰 已 经 跻 身 于 全 球 先 进 军 舰 的 行 列 ， 0 5 5 型 导 弹 驱 逐 舰 亦 有 充 足 的 空 间 进 行 动 力 与 武 器 的 升 级 ， 如 高 空 反 导 系 统 ， 激 光 近 防 炮 设 施 ， 电 磁 动 力 炮 和 超 远 程 雷 达 等 大 型 装 备 的 升 级 正 在 逐 步 推 进 。 首 舰 则 被 命 名 为 “ 上 海 号 ” ， 用 于 纪 念 上 海 对 于 这 艘 船 和 共 和 国 的 独 特 地 位 。||美 国 观 察 家 指 出 ， 若 美 国 海 军 进 一 步 节 约 经 费 用 去 买 可 乐 ， 就 要 连 中 国 佬 的 海 军 都 比 不 过 了 。";
			a.data[8] -= 100;
			a.data[12] -= 100;
			a.data[22] += 50;
			a.data[1] += 50;
			a.data[3] += 50;
			a.data[6] += 5;
			a.influencePRC += 50;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 导 弹 驱 逐 舰 ：</color>| 军 力+3.0 ， 人 民 支 持 度+1.0 ， 影 响 力+0.5 ";
		}
		if (result_num == 1)
		{
			text = " 我 们 开 始 尝 试 常 规 动 力 航 母 的 研 发 ， 这 是 个 困 难 的 事 情 ， 因 为 这 是 个 从 无 到 有 的 过 程 。 在 借 鉴 了 美 国 的 “ 福 莱 斯 特 ” 号 ，";
			if (a.allcountries[92].Gosstroy == 0 || a.allcountries[92].Gosstroy == 3)
			{
				text += "“ 圣 伊 丽 莎 白 ” 号";
			}
			else
			{
				text += " “ 共 和 号 ”";
			}
			text += " 的 经 验 之 后 ， 一 个 初 步 的 方 案 得 到 了 通 过 。 这 艘 航 母 采 用 大 量 新 设 计 、 新 材 料 ， 工 程 量 巨 大 ， 建 造 总 量 超 过 2 0 艘 超 大 型 油 轮 工 程 量 总 和 。 3 0 0 0 多 个 舱 室 ， 上 万 个 零 部 件 ， 上 万 台 套 各 种 设 备 遍 布 全 船 ， 许 多 特 种 装 置 属 首 次 研 制 和 安 装 ， 施 工 难 度 巨 大 。 我 们 在 这 艘 航 母 上 搭 载 了 （ 我 国 ） 最 先 进 的 蒸 汽 弹 射 系 统 ， 专 门 为 海 军 研 制 的 重 型 歼 击 机 J - 1 3 I 也 得 以 列 装 。 而 核 动 力 的 版 本 与 电 磁 弹 射 仍 然 在 慢 慢 的 摸 索 之 中 。||其 次 ， 在 航 母 上 还 首 次 实 现 了 社 区 化 管 理 。 所 谓 社 区 化 管 理 就 是 航 母 内 部 分 成 不 同 的 功 能 单 元 ， 平 时 每 个 单 元 各 司 其 职 ， 各 就 其 位 ， 不 相 互 串 岗 ， 只 有 在 吃 饭 和 集 体 活 动 时 才 会 聚 集 在 一 起 ， 这 样 做 的 好 处 就 是 提 升 了 工 作 效 率 。 江 苏 舰 配 置 了 内 部 即 时 通 讯 系 统 和 个 人 移 动 通 讯 终 端 ， 如 果 有 工 作 需 要 也 可 以 随 时 进 行 联 系 ， 这 也 是 我 国 电 子 工 业 进 步 的 体 现 。||在 1 9 8 4 年 4 月 2 3 日 ， 人 民 海 军 3 5 周 年 之 时 ， 舷 号 1 0 的 中 国 首 艘 航 母 “ 江 苏 ” 完 成 了 下 水 ， ";
			text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
			text += " ";
			text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
			text += " 同 志 也 观 摩 了 这 一 伟 大 的 时 刻 。 下 一 艘 代 号 广 东 的 航 母 也 在 计 划 中 ， 预 计 会 装 有 电 弹 射 系 统 从 而 获 得 更 大 的 推 力 。";
			a.data[8] -= 120;
			a.data[12] -= 120;
			a.data[22] += 80;
			a.data[1] += 100;
			a.data[3] += 100;
			a.data[6] += 8;
			a.influencePRC += 80;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 航 空 母 舰 ：</color>| 军 力+3.0 ， 干 涉 点 数+2.0 ， 人 民 支 持 度+1.0 ， 影 响 力+0.5 ， 军 武 支 援 效 果+1";
		}
		if (result_num == 2)
		{
			text = " 我 们 在 大 量 的 手 稿 中 找 出 了 0 5 5 型 驱 逐 舰 的 设 计 草 图 ， 尽 管 已 经 过 去 了 数 十 年 ， 但 其 理 念 仍 然 不 输 时 代 。 很 快 ， 就 有 眼 尖 的 摄 影 爱 好 者 在 上 海 的 长 兴 岛 发 现 了 一 款 巨 大 的 “ 货 轮 ” 建 造 设 施 。 很 快 就 传 来 了 激 动 的 消 息 ， 0 5 5 已 经 完 成 了 下 水 。 采 用 全 燃 动 力 、 射 频 综 合 集 成 及 舰 载 通 用 垂 直 发 射 系 统 ， 由 中 国 人 民 解 放 军 海 军 7 0 1 研 究 所 设 计 、 江 南 造 船 厂 1 0 3 基 地 与 大 连 船 舶 8 1 2 工 厂 承 建 。 0 5 5 型 导 弹 驱 逐 舰 是 全 亚 洲 ， 乃 至 全 世 界 都 排 得 上 号 的 大 型 水 面 舰 艇 。 此 型 舰 的 服 役 标 志 着 中 国 驱 逐 舰 已 经 跻 身 于 全 球 先 进 军 舰 的 行 列 ， 0 5 5 型 导 弹 驱 逐 舰 亦 有 充 足 的 空 间 进 行 动 力 与 武 器 的 升 级 ， 如 高 空 反 导 系 统 ， 激 光 近 防 炮 设 施 ， 电 磁 动 力 炮 和 超 远 程 雷 达 等 大 型 装 备 的 升 级 正 在 逐 步 推 进 。 首 舰 则 被 命 名 为 “ 上 海 号 ” ， 用 于 纪 念 上 海 对 于 这 艘 船 和 共 和 国 的 独 特 地 位 。||我 们 开 始 尝 试 常 规 动 力 航 母 的 研 发 ， 这 是 个 困 难 的 事 情 ， 因 为 这 是 个 从 无 到 有 的 过 程 。 在 借 鉴 了 美 国 的 “ 福 莱 斯 特 ” 号 ， ";
			if (a.allcountries[92].Gosstroy == 0 || a.allcountries[92].Gosstroy == 3)
			{
				text += "“ 圣 伊 丽 莎 白 ” 号";
			}
			else
			{
				text += " “ 共 和 号 ” ";
			}
			text += "的 经 验 之 后 ， 一 个 初 步 的 方 案 得 到 了 通 过 。 这 艘 航 母 采 用 大 量 新 设 计 、 新 材 料 ， 工 程 量 巨 大 ， 建 造 总 量 超 过 2 0 艘 超 大 型 油 轮 工 程 量 总 和 。 3 0 0 0 多 个 舱 室 ， 上 万 个 零 部 件 ， 上 万 台 套 各 种 设 备 遍 布 全 船 ， 许 多 特 种 装 置 属 首 次 研 制 和 安 装 ， 施 工 难 度 巨 大 。 我 们 在 这 艘 航 母 上 搭 载 了 （ 我 国 ） 最 先 进 的 蒸 汽 弹 射 系 统 ， 专 门 为 海 军 研 制 的 重 型 歼 击 机 J - 1 3 I 也 得 以 列 装 。 而 核 动 力 的 版 本 与 电 磁 弹 射 仍 然 在 慢 慢 的 摸 索 之 中 。||其 次 ， 在 航 母 上 还 首 次 实 现 了 社 区 化 管 理 。 所 谓 社 区 化 管 理 就 是 航 母 内 部 分 成 不 同 的 功 能 单 元 ， 平 时 每 个 单 元 各 司 其 职 ， 各 就 其 位 ， 不 相 互 串 岗 ， 只 有 在 吃 饭 和 集 体 活 动 时 才 会 聚 集 在 一 起 ， 这 样 做 的 好 处 就 是 提 升 了 工 作 效 率 。 江 苏 舰 配 置 了 内 部 即 时 通 讯 系 统 和 个 人 移 动 通 讯 终 端 ， 如 果 有 工 作 需 要 也 可 以 随 时 进 行 联 系 ， 这 也 是 我 国 电 子 工 业 进 步 的 体 现 。 下 一 艘 代 号 广 东 的 航 母 也 在 计 划 中 ， 预 计 会 装 有 电 弹 射 系 统 从 而 获 得 更 大 的 推 力 。||在 1 9 8 4 年 4 月 2 3 日 ， 人 民 海 军 3 5 周 年 之 时 ， 舷 号 1 0 的 中 国 首 艘 航 母 “ 江 苏 ” 完 成 了 下 水 实 验 ， 一 并 下 水 的 还 有 0 5 5 型 导 弹 驱 逐 舰 。 ";
			text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
			text += " ";
			text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
			text += " 同 志 也 观 摩 了 这 一 伟 大 的 时 刻 。 谁 敢 来 侵 犯 我 们 ， 我 们 就 叫 他 们 灭 亡 ！";
			a.data[8] -= 150;
			a.data[12] -= 150;
			a.data[22] += 150;
			a.data[1] += 150;
			a.data[3] += 150;
			a.data[6] += 10;
			a.data[57] += 50;
			a.influencePRC += 100;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 导 弹 驱 逐 舰 与 航 空 母 舰 ：</color>| 军 力+5.0 ， 人 民 支 持 度+2.5 ， 干 涉 点 数+3.0 ， 影 响 力+1.0 ， 军 武 支 援 效 果+2";
		}
		if (result_num == 3)
		{
			text = " 现 在 的 舰 船 ， 我 想 也 够 了 。 未 来 是 导 弹 的 时 代 ， 而 不 是 把 游 艇 开 出 去 当 靶 子 的 。 但 一 系 列 宏 伟 的 计 划 仍 然 得 到 了 资 金 ， 我 们 预 计 在 本 世 纪 末 可 以 和 法 国 与 英 国 的 海 军 扳 手 腕 ， 不 过 超 过 美 国 则 仍 然 是 一 个 遥 远 的 梦 想 … …";
			a.data[8] -= 30;
			a.data[22] += 30;
			a.data[1] += 50;
			a.data[6] += 5;
			a.data[3] += 50;
			a.data[57] += 50;
			a.influencePRC += 50;
		}
	}
}
