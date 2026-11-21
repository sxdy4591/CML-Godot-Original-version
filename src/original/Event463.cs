using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event463 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 卡 萨 布 兰 卡 一 夜";
		text = " 自 1 9 7 5 年 摩 洛 哥 发 动 “ 绿 色 进 军 ” 行 动 以 来 ， 该 国 事 实 上 霸 占 了 整 个 西 撒 哈 拉 地 区 ， 并 且 陷 入 了 与 萨 基 亚 阿 姆 拉 和 里 奥 德 奥 罗 人 民 解 放 阵 线 旷 日 持 久 的 战 争 中 。 摩 洛 哥 虽 然 在 正 面 战 场 上 节 节 取 胜 ， 但 巨 大 的 军 事 开 支 逐 渐 压 垮 了 这 个 马 格 里 布 国 家 的 经 济 。 更 为 雪 上 加 霜 的 是 ， 摩 洛 哥 赖 以 为 生 的 磷 酸 盐 矿 迅 速 贬 值 ， 从 原 先 的 6 5 美 元 一 吨 跌 至 3 1 美 元 一 吨 。 为 了 继 续 维 持 对 西 撒 哈 拉 矿 区 的 控 制 ， 哈 桑 二 世 不 得 不 从 国 外 借 债 ， 到 了 1 9 8 1 年 摩 洛 哥 的 外 债 已 经 高 达 7 9 亿 美 元 。||此 时 ， 在 卡 萨 布 兰 卡 爆 发 了 大 规 模 的 警 民 冲 突 。 大 量 失 业 的 工 人 和 矿 工 为 了 向 当 局 表 达 对 食 物 涨 价 的 不 满 。 一 场 和 平 请 愿 迅 速 扩 大 为 了 游 行 和 打 砸 抢 。 该 市 的 富 人 区 和 商 业 街 遭 到 了 近 乎 于 疯 狂 的 破 坏 。 在 其 中 还 有 人 打 出 了 要 求 哈 桑 二 世 下 野 的 口 号 ， 双 方 的 矛 盾 越 发 不 可 调 和 ， 似 乎 马 上 就 要 爆 发 。||主 席 同 志 ， 我 们 要 不 要 做 点 什 么 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.allcountries[54].cw && GlobalScript.inst.gameState.data[56] < 3)
		{
			button_text[0] = " 在 阿 尔 及 利 亚 的 帮 助 下 ， 支 持 摩 洛 哥 人 民 的 斗 争";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 推 翻 国 王 ， 有 谁 有 这 个 胆 子 ？";
		}
		if (GlobalScript.inst.gameState.data[56] <= 2)
		{
			button_text[1] = " 煽 动 西 撒 人 阵 起 义";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 能 力 做 这 种 事";
		}
		if (GlobalScript.inst.gameState.data[56] != 2)
		{
			button_text[2] = " 借 此 机 会 ， 介 入 摩 洛 哥 王 国 的 局 势";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 摩 洛 哥 人 不 想 听 我 们 的 话 ！";
		}
		button_text[3] = " 这 里 是 摩 洛 哥 还 是 摩 纳 哥 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 卡 萨 布 兰 卡 一 夜";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 特 工 的 帮 助 下 ， 运 动 迅 速 从 卡 萨 布 兰 卡 蔓 延 到 了 全 国 各 大 城 市 。 摩 洛 哥 人 民 力 量 社 会 主 义 同 盟 没 有 错 过 这 次 机 会 ， 在 运 动 中 迅 速 确 认 了 自 己 的 领 导 地 位 。 随 着 斗 争 愈 演 愈 烈 ， 王 室 感 受 到 了 自 己 时 日 无 多 ， 哈 桑 二 世 快 速 完 成 了 退 位 并 请 求 新 政 府 的 宽 恕 。 然 而 作 为 又 一 位 昏 庸 无 能 的 君 主 ， 他 的 请 求 被 置 之 不 理 。 在 拉 巴 特 的 一 间 地 下 室 里 ， 迟 来 的 保 王 党 人 只 找 到 了 被 打 成 筛 子 一 般 的 几 具 尸 体 。 就 这 样 ， 统 治 了 摩 洛 哥 数 十 载 的 阿 拉 维 王 室 如 风 般 飘 散 了 。 在 王 室 的 尸 体 上 ， 摩 洛 哥 民 主 共 和 国 从 中 涅 槃 ， 并 开 始 着 手 收 回 外 企 的 垄 断 公 司 。||新 生 的 摩 洛 哥 政 府 决 定 和 西 撒 哈 拉 展 开 谈 判 ， 在 一 系 列 激 烈 的 辩 论 和 让 步 后 ， 西 撒 人 阵 同 意 以 联 邦 实 体 的 身 份 加 入 摩 洛 哥 。 西 撒 人 阵 将 作 为 西 撒 哈 拉 地 区 唯 一 合 法 的 政 党 ， 直 接 统 治 西 撒 哈 拉 地 区 而 不 必 听 从 摩 洛 哥 方 面 的 指 示 。 摩 洛 哥 宣 布 停 止 沙 墙 的 建 设 ， 双 方 也 确 定 了 新 的 “ 摩 洛 哥 人 ” 身 份 。 尽 管 相 当 多 的 人 谴 责 西 撒 人 阵 背 叛 了 过 去 的 理 想 ， 但 撒 哈 拉 的 局 势 或 多 或 少 稳 定 下 来 了 。";
			GlobalScript.inst.gameState.allcountries[54].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[54].SubGosstroy = 3;
			a.allcountries[54].Vyshi = false;
			a.allcountries[54].Torg = true;
			a.allcountries[54].proprc = true;
			a.allcountries[54].name = " 摩 洛 哥 西 撒 哈 拉 民 主 联 邦";
			a.empires[0].relations -= 100;
			a.data[6] += 50;
			a.data[8] -= 50;
			a.data[9] -= 50;
			break;
		case 1:
		{
			text = " 我 们 在 西 撒 哈 拉 的 布 局 为 我 们 带 来 了 介 入 混 乱 局 势 的 机 会 。 趁 着 摩 洛 哥 本 土 陷 入 混 乱 的 时 机 ， 西 撒 人 阵 总 书 记 在 廷 杜 夫 发 表 了 《 告 被 占 领 的 撒 哈 拉 阿 拉 伯 同 胞 的 信 》 。 其 中 声 泪 俱 下 的 控 诉 了 摩 洛 哥 王 室 在 西 撒 哈 拉 的 暴 行 ， 如 ： 强 制 驱 逐 原 住 民 ， 强 迫 劳 役 和 不 公 正 对 待 。 “ 但 是 这 一 切 就 要 结 束 了 ” ， R A S D 的 电 台 如 是 说 道 ， “ 在 我 们 阿 拉 伯 兄 弟 们 的 帮 助 下 ， 阵 线 已 经 重 整 旗 鼓 ， 做 好 了 为 1 9 7 5 年 复 仇 的 准 备 。 ” 在 广 播 结 束 后 的 半 天 内 ， 大 量 的 土 制 火 箭 弹 从 阿 尔 及 利 亚 和 尚 未 被 占 领 的 西 撒 哈 拉 领 土 射 向 北 部 。 阿 尤 恩 的 损 失 尤 为 严 重 。 西 撒 人 阵 的 战 士 们 乘 着 b m p 步 战 车 和 皮 卡 车 攻 入 北 部 和 沿 海 的 城 市 。 摩 洛 哥 政 府 宣 布 进 入 紧 急 状 态 ， 开 始 调 兵 遣 将 准 备 镇 压 新 的 一 轮 叛 乱 。";
			a.data[8] -= 30;
			a.data[22] -= 80;
			a.empires[0].relations -= 80;
			a.data[6] -= 50;
			int num = 0;
			if (a.allcountries[40].proprc || a.allcountries[40].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[55].proprc || a.allcountries[55].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[13].proprc || a.allcountries[13].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[14].proprc || a.allcountries[14].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[35].proprc || a.allcountries[35].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[42].proprc || a.allcountries[42].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[104].proprc || a.allcountries[104].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[93].proprc || a.allcountries[93].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[25].proprc || a.allcountries[25].Gosstroy == 1 || a.allcountries[24].proprc || a.allcountries[24].Gosstroy == 1)
			{
				num += 20;
			}
			if (a.allcountries[18].cw)
			{
				num += 50;
			}
			if (a.allcountries[86].SubGosstroy != 7)
			{
				num += 30;
			}
			a.ingamewars[39] = new War().Name(" 第 二 次 西 撒 哈 拉 独 立 战 争").Attacker(" 摩 洛 哥 王 国").Defender(" 西 撒 哈 拉")
				.AttackerInfluence(700 - num)
				.DefenderInfluence(300 + num)
				.TickTime(20)
				.AmericanSupportAttacker.CreateWar;
			if (a.relres)
			{
				a.ingamewars[39].ussr_place = 1;
			}
			break;
		}
		case 2:
			text = " 我 们 的 外 交 部 公 开 谴 责 了 摩 洛 哥 王 室 对 于 进 步 人 士 的 镇 压 。 “ 这 种 残 酷 的 法 西 斯 主 义 暴 行 ， 丝 毫 不 亚 于 墨 索 里 尼 的 意 大 利 和 佛 朗 哥 的 西 班 牙 ！ ” 许 多 非 洲 和 第 三 世 界 国 家 也 纷 纷 支 持 我 们 的 决 定 ， 他 们 呼 吁 对 摩 洛 哥 实 施 一 轮 制 裁 。 非 洲 统 一 组 织 正 在 考 虑 是 否 要 对 摩 洛 哥 采 取 “ 特 别 行 动 ” 。||多 说 无 益 ， 我 们 决 定 借 助 混 乱 的 局 势 开 始 下 一 盘 大 棋 。";
			if (a.data[56] <= 1)
			{
				text += " ||通 过 拉 巴 特 的 线 人 ， 我 们 设 法 组 织 了Tanzim （ 全 国 人 民 力 量 联 盟 的 激 进 派 ） 、 摩 洛 哥 人 民 力 量 社 会 主 义 同 盟 的 民 族 政 治 委 员 会 派 ， 6 8 运 动 时 期 的 “ 前 进 ” 组 织 ， “ 三 月 二 十 三 日 运 动 ” 与 进 步 与 社 会 主 义 党 左 翼 的 联 合 阵 线 。 各 派 就 打 入 摩 洛 哥 总 工 会 和 陆 军 达 成 了 一 致 ， 正 式 确 定 了 马 克 思 ， 列 宁 和 毛 泽 东 思 想 为 核 心 的 纲 领 。 四 个 党 派 就 组 建 摩 洛 哥 社 会 主 义 革 命 党 达 成 了 协 议 ， 外 号 “ 老 战 士 ” 的 穆 罕 默 德 · 本 · 赛 义 德 被 推 举 为 第 一 书 记 ， 而 下 辖 的 武 装 团 体 — “ 铁 拳 突 击 队 ” 和 摩 洛 哥 人 民 解 放 阵 线 也 在 组 建 中 ， 尽 管 他 们 现 在 力 量 极 弱 ， 但 假 以 时 日 ， 和 一 点 火 花 ， 他 们 定 能 大 有 作 为 。";
				a.allcountries[54].level_of_dev = 1;
			}
			else
			{
				text += " ||看 到 哈 桑 二 世 的 政 局 出 现 了 问 题 ， 我 们 决 定 押 宝 于 艾 哈 迈 德 · 奥 斯 曼 的 全 国 自 由 人 士 联 盟 。 这 是 一 个 对 君 主 制 抱 有 中 立 态 度 ， 但 愿 意 开 放 党 禁 和 经 济 大 幅 度 自 由 化 的 组 织 。 作 为 该 国 的 首 相 ， 他 能 够 轻 松 的 介 入 局 势 。 很 快 ， 宪 政 联 盟 ， ， 民 主 独 立 党 和 自 由 联 盟 就 组 建 人 民 阵 线 达 成 了 一 致 。 奥 斯 曼 还 在 隐 忍 ， 只 是 还 没 到 和 自 己 姑 姑 撕 破 脸 的 时 候 ， 至 少 现 在 不 行 。";
				a.allcountries[54].level_of_dev = 3;
			}
			text += " || 卡 萨 布 兰 卡 的 军 人 收 到 了 行 动 指 令 。 一 瞬 间 ， 军 队 对 手 无 寸 铁 的 平 民 扣 下 了 板 机 ， 一 条 又 一 条 鲜 活 的 生 命 就 此 倒 在 了 曾 发 誓 过 保 护 他 们 的 人 的 枪 口 下 。 涉 嫌 挑 战 政 府 的 摩 洛 哥 人 民 力 量 社 会 主 义 同 盟 也 遭 到 了 沉 重 打 击 ， 一 批 骨 干 成 员 被 当 众 处 死 。||大 幅 削 弱 了 反 对 派 的 国 王 政 府 将 自 己 确 定 为 美 国 鹰 犬 ， 越 发 的 和 其 紧 密 相 连 。";
			a.empires[0].relations -= 80;
			a.data[6] -= 50;
			break;
		case 3:
			text = " 卡 萨 布 兰 卡 的 军 人 收 到 了 行 动 指 令 。 一 瞬 间 ， 军 队 对 手 无 寸 铁 的 平 民 扣 下 了 板 机 ， 一 条 又 一 条 鲜 活 的 生 命 就 此 倒 在 了 曾 发 誓 过 保 护 他 们 的 人 的 枪 口 下 。 涉 嫌 挑 战 政 府 的 摩 洛 哥 人 民 力 量 社 会 主 义 同 盟 也 遭 到 了 沉 重 打 击 ， 一 批 骨 干 成 员 被 当 众 处 死 。||大 幅 削 弱 了 反 对 派 的 国 王 政 府 将 自 己 确 定 为 美 国 鹰 犬 ， 越 发 的 和 其 紧 密 相 连 。 ";
			a.empires[0].power -= 20;
			break;
		}
	}
}
