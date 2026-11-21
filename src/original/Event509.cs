using EventsForDLC;
using UnityEngine;

public class Event509 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 黄 金 海 岸 的 再 革 命 ？ — — 第 一 幕";
		text = " 在 1 9 6 6 年 恩 克 鲁 玛 被 推 翻 后 ， 加 纳 迎 来 的 是 一 系 列 不 同 政 治 集 团 的 内 斗 ， 腐 败 的 军 政 府 和 软 弱 的 文 官 政 府 交 替 执 政 。 作 为 国 家 经 济 支 撑 的 可 可 、 黄 金 产 业 产 量 不 断 走 低 ， 官 员 腐 败 、 黑 市 横 行 ， 导 致 加 纳 经 济 大 幅 衰 退 ， 加 纳 人 用 K a l a b u l e （ 指 普 遍 的 官 商 勾 结 和 腐 败 、 诈 骗 与 囤 积 居 奇 ） 这 个 词 描 述 国 家 的 状 态 。 伊 朗 革 命 带 来 的 石 油 危 机 使 得 该 国 经 济 危 机 进 一 步 加 剧 ， 无 计 可 施 的 阿 库 福 军 政 府 不 得 不 承 诺 开 展 选 举 。||1 9 7 9 年 5 月 1 5 日 ， 空 军 中 尉 杰 里 · 罗 林 斯 与 一 群 年 轻 军 官 发 起 了 一 场 针 对 军 政 府 的 未 遂 政 变 ， 尽 管 政 变 失 败 ， 但 是 罗 林 斯 对 军 政 府 的 指 责 受 到 加 纳 民 众 和 少 壮 派 军 人 的 广 泛 欢 迎 。 6 月 4 日 晚 ， 被 营 救 出 狱 的 罗 林 斯 再 次 发 起 了 一 场 政 变 ， 成 功 推 翻 军 政 府 。 新 成 立 的 武 装 部 队 革 命 委 员 会 具 有 强 烈 的 左 翼 反 帝 色 彩 ， 在 国 家 被 整 肃 完 毕 后 ， 它 将 把 政 权 交 给 大 选 获 胜 的 政 党 和 文 官 政 府 。 罗 林 斯 主 持 清 清 洗 了 大 量 造 成 K a l a b u l e 的 官 员 和 投 机 商 ， 并 对 掌 控 经 济 命 脉 的 印 度 人 和 黎 巴 嫩 人 的 公 司 进 行 了 国 有 化 ， 没 收 了 投 机 者 屯 聚 在 秘 密 仓 库 中 的 大 量 货 物 。||9 月 2 4 日 ， 罗 林 斯 将 权 力 交 给 了 大 选 获 胜 的 由 希 拉 · 利 曼 博 士 领 导 的 号 称 是 恩 克 鲁 玛 主 义 的 人 民 民 族 党 。 利 曼 总 统 宣 布 实 施 混 合 经 济 ， 要 将 加 纳 建 设 成 社 会 主 义 的 “ 福 利 国 家 ” 。 希 拉 · 利 曼 总 统 将 主 动 交 权 的 少 壮 派 军 人 集 团 视 作 潜 在 的 反 对 派 ， 并 将 罗 林 斯 视 为 最 大 的 隐 患 。 他 先 后 将 前 武 装 部 队 革 命 委 员 会 的 重 要 成 员 派 遣 到 国 外 ， 使 他 们 与 加 纳 政 治 脱 离 直 接 的 接 触 。 1 1 月 2 7 日 ， 罗 林 斯 被 利 曼 解 除 军 职 ， 并 被 勒 令 从 武 装 部 队 退 役 ， 被 任 命 为 有 职 无 权 的 国 务 委 员 会 委 员 。||与 此 同 时 ， 利 曼 的 文 官 政 府 无 力 继 续 处 理 K a l a b u l e 问 题 ， 经 济 状 况 反 而 在 继 续 恶 化 ， 食 品 的 生 产 、 出 口 量 、 矿 产 开 采 仍 在 下 降 ， 基 础 设 施 年 久 失 修 ， 财 政 混 乱 ， 腐 败 和 犯 罪 并 未 得 到 遏 制 。 在 这 种 情 况 下 ， 罗 林 斯 似 乎 在 为 新 的 “ 革 命 ” 做 出 准 备 ， 加 纳 仍 在 酝 酿 着 下 一 次 危 机 。 也 许 我 们 能 在 其 中 插 上 一 脚 ， 拿 回 我 们 曾 失 去 的 东 西 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] != 0 && a.data[56] != 4)
		{
			button_text[0] = " 让 我 们 帮 恩 克 鲁 玛 的 “ 传 人 ” — — 希 拉 · 利 曼 博 士 一 把";
		}
		else if (a.data[56] == 4)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 会 帮 助 左 派";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 会 帮 助 修 正 主 义 者 ！";
		}
		if (a.data[56] > 1 && a.allcountries[51].dev == 1)
		{
			button_text[1] = " 利 用 危 机 ， 帮 助 英 美 利 用 科 特 迪 瓦 和 多 哥 的 雇 佣 军 推 翻 左 翼 政 府";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 要 这 么 做 ？";
		}
		if (a.data[56] <= 1 && a.event_done[505] && a.resultOfEvents[505] == 0)
		{
			button_text[2] = " 在 几 内 亚 同 志 的 帮 助 下 ， 让 恩 克 鲁 玛 的 好 学 生 卡 迈 克 尔 和 罗 林 斯 联 合 起 来 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = "  我 们 无 从 下 手";
		}
		button_text[3] = " 我 们 没 有 必 要 做 看 不 到 结 果 的 投 资";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 黄 金 海 岸 的 再 革 命 ？ — — 第 一 幕";
		if (result_num == 0)
		{
			text = " 为 了 帮 助 加 纳 解 决 经 济 问 题 ， 我 们 决 定 向 加 纳 提 供 一 笔 无 息 贷 款 ， 并 派 出 顾 问 团 为 利 曼 总 统 提 供 帮 助 。 而 他 也 抓 住 了 中 国 这 个 救 命 稻 草 ， 决 定 背 靠 中 国 来 巩 固 以 他 为 首 的 文 官 政 府 的 统 治 。 作 为 交 换 ， 他 也 为 我 们 在 加 纳 开 采 黄 金 和 勘 探 石 油 提 供 了 最 大 的 帮 助 ， 我 们 的 投 资 的 涌 入 为 加 纳 经 济 注 入 了 活 力 ， 利 曼 也 决 定 继 续 进 行 一 定 的 国 有 化 和 福 利 建 设 。 在 我 们 的 帮 助 下 ， 加 纳 第 三 共 和 国 正 在 稳 定 下 来 ， 并 成 功 安 抚 了 不 满 的 年 轻 军 官 。 虽 然 利 曼 博 士 比 起 恩 克 鲁 玛 而 言 ， 更 像 是 个 打 着 他 旗 号 的 非 洲 民 主 社 会 主 义 者 ， 不 过 对 于 我 们 而 言 ， 能 抓 到 老 鼠 的 就 是 好 猫 ， 不 是 吗 ？";
			a.data[8] -= 50;
			a.influencePRC += 20;
			a.empires[0].relations -= 50;
			GlobalScript.inst.gameState.allcountries[63].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[63].proprc = true;
			GlobalScript.inst.gameState.allcountries[63].Torg = true;
		}
		if (result_num == 1)
		{
			a.data[9] -= 50;
			if (a.empires[0].relations >= 500)
			{
				text = " 加 纳 再 度 左 转 将 可 能 加 强 苏 东 阵 营 的 力 量 投 射 ， 我 们 应 该 阻 止 这 种 事 情 的 发 生 ！ 我 们 秘 密 通 知 了 美 国 。 不 久 ， 来 自 邻 国 科 特 迪 瓦 和 多 哥 的 雇 佣 军 便 在 中 情 局 的 帮 助 下 攻 破 了 阿 克 拉 ， 加 纳 政 府 猝 不 及 防 ， 没 有 组 织 起 像 样 的 抵 抗 。 左 翼 政 府 被 推 翻 ， 新 的 军 政 府 成 立 了 。";
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 7;
				GlobalScript.inst.gameState.allcountries[63].Vyshi = true;
				GlobalScript.inst.gameState.allcountries[63].Torg = true;
			}
			else
			{
				text = " 加 纳 的 情 报 机 构 发 现 了 来 自 科 特 迪 瓦 和 多 哥 方 向 的 异 动 。 他 们 宣 布 全 国 进 入 战 时 状 态 ， 并 在 边 界 和 首 都 加 强 了 防 御 ， 同 时 向 苏 联 请 求 援 助 。 最 后 ， 加 纳 政 府 粉 碎 了 政 变 阴 谋 ， 宣 布 与 美 国 和 我 们 断 绝 关 系 并 倒 向 苏 联 。";
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].prosov = true;
				GlobalScript.inst.gameState.allcountries[63].Torg = false;
			}
		}
		if (result_num == 2)
		{
			text = " 斯 托 克 利 · 卡 迈 克 尔 ， 另 一 个 名 字 是 夸 梅 · 杜 尔 ， 是 一 位 泛 非 主 义 者 和 共 产 主 义 者 ， 曾 领 导 美 国 的 黑 人 解 放 运 动 ， 并 参 与 了 黑 豹 党 。 1 9 6 9 年 ， 他 来 到 了 几 内 亚 ， 成 为 了 塞 古 · 杜 尔 的 助 手 和 恩 克 鲁 玛 的 学 生 。 他 加 入 了 几 内 亚 民 主 党 ， 并 致 力 于 “ 将 恩 克 鲁 玛 带 回 加 纳 ” 。 卡 迈 克 尔 与 恩 克 鲁 玛 一 起 创 建 了 全 非 人 民 革 命 党 ， 该 组 织 是 恩 克 鲁 玛 晚 年 思 想 的 实 践 组 织 。||我 们 为 罗 林 斯 和 全 非 人 民 革 命 党 提 供 了 活 动 资 金 ， 杜 尔 总 统 、 卡 迈 克 尔 和 我 们 的 外 交 人 员 与 罗 林 斯 进 行 了 一 番 深 入 交 流 ， 他 决 定 与 卡 迈 克 尔 联 合 起 来 ， 实 现 不 同 于 利 曼 的 真 正 的 恩 克 鲁 玛 主 义 。 之 后 ， 罗 林 斯 和 他 的 同 志 们 便 在 几 内 亚 秘 密 进 行 军 事 训 练 ， 并 谋 划 着 下 一 场 革 命 ， 以 终 结 K a l a b u l e 。";
			a.data[8] -= 60;
			a.data[9] -= 60;
			a.data[22] -= 60;
			GlobalScript.inst.gameState.allcountries[63].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[63].cw = true;
		}
		if (result_num == 3)
		{
			text = " 我 们 什 么 都 没 做 。 在 被 开 除 军 职 后 ， 罗 林 斯 就 秘 密 前 往 利 比 亚 接 受 军 事 训 练 。 利 曼 的 文 官 政 府 和 K a l a b u l e 一 样 ， 仍 继 续 存 在 着 。 只 是 在 民 间 ， 不 满 的 民 众 和 下 野 的 年 轻 军 官 又 会 在 这 片 土 地 擦 出 什 么 火 花 呢 ？";
			GlobalScript.inst.gameState.allcountries[63].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
		}
	}
}
