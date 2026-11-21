using EventsForDLC;
using UnityEngine;

public class Event554 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 埃 及 法 老 的 终 结";
		text = " 在1977 年 事 件 后 ， 埃 及 的 问 题 仍 未 得 到 解 决 ， 其 国 内 反 对 派 的 活 动 仍 然 活 跃 。 从 左 翼 到 右 翼 ， 萨 达 特 获 得 了 广 泛 的 反 对 者 。1979 年 的 埃 及 - 以 色 列 和 平 条 约 在 阿 拉 伯 国 家 ， 尤 其 是 巴 勒 斯 坦 地 区 并 不 受 欢 迎 ， 阿 拉 伯 联 盟 也 暂 停 了 埃 及 的 成 员 资 格 （ 直 到1989 年 才 恢 复 ） 。 萨 达 特 在 国 内 外 越 来 越 不 受 欢 迎 。 近 段 时 间 ， 埃 及 国 内 发 生 了 部 分 骚 乱 ， 他 将 国 内 的 动 乱 视 为 由 叙 利 亚 、 利 比 亚 和 苏 联 的 “ 境 外 势 力 ” 煽 动 ， 而 非 由 埃 及 国 内 问 题 引 起 。 因 为 此 前 萨 达 特 采 取 扶 持 伊 斯 兰 主 义 者 的 政 策 。 萨 达 特 扶 持 伊 斯 兰 主 义 者 并 未 能 很 好 地 打 压 左 翼 力 量 ， 因 为 他 们 将 埃 及 的 现 有 建 制 视 为 首 要 敌 人 ， 他 这 一 政 策 终 究 是 搬 起 石 头 砸 了 自 己 的 脚 — — 他 们 公 开 呼 吁 推 翻 埃 及 总 统 ， 用 基 于 伊 斯 兰 神 权 统 治 的 政 府 取 代 现 有 的 政 治 制 度 。||1981 年10 月6 日 ， 萨 达 特 在 开 罗 举 行 的 庆 祝 埃 及 穿 越 苏 伊 士 运 河 的 年 度 胜 利 阅 兵 式 上 被 暗 杀 。 哈 立 德 · 伊 斯 兰 布 利 在 埃 及 伊 斯 兰 圣 战 组 织 的 教 令 下 ， 在 看 台 前 用 突 击 步 枪 把 萨 达 特 打 成 了 筛 子 。 除 萨 达 特 外 ， 还 有11 人 被 杀 ， 包 括 古 巴 大 使 、 一 名 阿 曼 将 军 、 一 名 科 普 特 东 正 教 主 教 和 埃 及 中 央 审 计 署 负 责 人 萨 米 尔 · 赫 尔 米 。28 人 受 伤 ， 包 括 副 总 统 胡 斯 尼 · 穆 巴 拉 克 、 爱 尔 兰 国 防 部 长 詹 姆 斯 · 塔 利 和 四 名 美 国 军 事 联 络 官 。 据 了 解 ， 伊 斯 兰 主 义 者 正 在 准 备 发 起 起 义 … …||如 今 ， 埃 及 国 内 陷 入 了 更 加 混 乱 的 状 态 ， 我 们 是 否 要 做 些 什 么 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.influencePRC >= 500 && a.data[31] >= 600 && !a.modifies[3].active && a.allcountries[8].SubGosstroy != 13)
		{
			button_text[0] = " 趁 势 帮 助 伊 斯 兰 主 义 者 夺 取 权 力";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 想 要 这 样 的 国 家";
		}
		if ((a.data[56] < 2 && a.resultOfEvents[37] == 2) || (a.data[56] > 2 && a.resultOfEvents[37] == 3))
		{
			button_text[1] = " 是 时 候 了 ， 让 我 们 在 北 非 发 起 一 场 革 命 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 法 和 起 义 者 取 得 联 络";
		}
		if (a.data[56] > 1)
		{
			button_text[2] = " 谴 责 伊 斯 兰 恐 怖 主 义";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 没 必 要 为 了 萨 达 特 这 么 做 ";
		}
		button_text[3] = " 他 杀 死 了 法 老 ， 他 不 怕 死";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 埃 及 法 老 的 终 结";
		if (result_num == 0)
		{
			text = " 在 我 们 的 干 预 下 ， 穆 斯 林 兄 弟 会 、 埃 及 伊 斯 兰 教 大 会 和 埃 及 伊 斯 兰 圣 战 组 织 等 伊 斯 兰 团 体 组 成 了 革 命 联 盟 ， 上 埃 及 的 阿 斯 尤 特 省 的 起 义 ， 得 益 于 萨 达 特 的 对 伊 斯 兰 力 量 的 扶 持 ， 他 们 得 以 迅 速 通 过 组 织 网 络 将 起 义 扩 散 到 全 国 。 通 过 民 族 主 义 和 伊 斯 兰 主 义 宣 传 ， 革 命 联 盟 动 员 城 市 平 民 组 成 民 兵 ， 在 伊 斯 兰 派 军 官 带 领 军 队 倒 戈 并 发 起 政 变 的 情 况 下 ， 民 族 民 主 党 政 权 很 快 在 围 攻 中 倒 台 ， 革 命 联 盟 组 织 起 基 于 伊 斯 兰 神 权 统 治 的 政 府 … …";
			GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 9;
			GlobalScript.inst.gameState.allcountries[30].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[30].Torg = true;
			a.influencePRC += 10;
			a.empires[0].relations -= 150;
			a.empires[1].relations -= 150;
			a.data[1] += 100;
			a.data[3] += 150;
			a.data[8] -= 100;
			a.data[9] -= 100;
		}
		if (result_num == 1)
		{
			if (a.resultOfEvents[37] == 2)
			{
				text = " 很 快 ， 埃 及 人 民 民 主 革 命 阵 线 得 以 组 织 起 民 兵 ， 利 用 萨 达 特 去 世 后 的 混 乱 ， 发 起 大 规 模 的 起 义 。 革 命 阵 线 组 织 的 民 兵 冲 入 位 于 开 罗 的 政 府 机 构 ， 强 行 解 除 了 萨 达 特 的 亲 信 们 的 职 务 ， 在 我 们 的 特 工 的 帮 助 下 ， 动 员 起 来 的 力 量 迅 速 将 各 地 政 治 机 构 和 重 要 政 要 逮 捕 。 埃 及 军 队 也 在 我 们 的 干 预 下 陷 入 了 混 乱 ， 无 法 被 当 局 动 员 起 来 ， 在 此 前 渗 透 中 被 发 展 起 来 的 左 翼 军 人 掌 控 。 埃 及 人 民 民 主 革 命 阵 线 很 快 夺 取 了 权 力 ， 阵 线 被 改 组 为 埃 及 人 民 革 命 党 ， 阿 拉 伯 埃 及 共 和 国 也 被 改 为 埃 及 人 民 共 和 国 。 在 新 政 权 的 领 导 下 ， 埃 及 开 始 进 行 社 会 主 义 革 命 。";
				a.data[8] -= 150;
				a.data[9] -= 150;
				a.data[22] -= 150;
				GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 1;
				GlobalScript.inst.gameState.allcountries[30].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[30].proprc = true;
				GlobalScript.inst.gameState.allcountries[30].Torg = true;
				if (a.allcountries[1].isSEV)
				{
					GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[30].isSEV = true;
					a.empires[1].relations += 50;
					GlobalScript.inst.gameState.allcountries[30].prosov = true;
				}
				a.data[1] += 100;
				a.data[3] += 150;
				a.influencePRC += 25;
				a.empires[1].relations += 150;
				a.empires[0].relations -= 250;
				a.data[6] += 50;
			}
			else
			{
				text = " 很 快 ， 埃 及 民 族 自 由 联 盟 得 以 动 员 民 众 抗 议 ， 组 织 起 民 兵 ， 利 用 萨 达 特 去 世 后 的 混 乱 ， 发 起 大 规 模 的 起 义 。 联 盟 组 织 的 民 兵 冲 入 位 于 开 罗 的 政 府 机 构 ， 强 行 解 除 了 萨 达 特 的 亲 信 们 的 职 务 ， 在 我 们 的 特 工 的 帮 助 下 ， 动 员 起 来 的 力 量 迅 速 将 各 地 政 治 机 构 和 重 要 政 要 逮 捕 。 埃 及 军 队 也 在 联 盟 的 渗 透 和 我 们 的 干 预 下 陷 入 了 混 乱 ， 意 识 到 对 抗 毫 无 意 义 的 军 人 和 文 官 组 织 政 变 ， 在 谈 判 后 ， 埃 及 宣 布 组 织 真 正 民 主 的 选 举 。";
				a.data[8] -= 150;
				a.data[9] -= 150;
				a.data[22] -= 150;
				GlobalScript.inst.gameState.allcountries[30].Gosstroy = 3;
				GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 6;
				GlobalScript.inst.gameState.allcountries[30].Torg = true;
				GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[30].proprc = true;
				if (a.allcountries[1].isASEAN)
				{
					if (a.allcountries[51].cw)
					{
						GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[30].isASEAN = true;
						GlobalScript.inst.gameState.allcountries[30].isSEATO = true;
					}
					else
					{
						GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[30].isSENTO = true;
					}
					a.empires[0].relations += 50;
					GlobalScript.inst.gameState.allcountries[30].Vyshi = true;
				}
				a.data[1] += 100;
				a.data[3] += 150;
				a.influencePRC += 25;
				a.empires[1].relations -= 250;
				a.empires[0].relations += 150;
				a.data[6] -= 50;
			}
		}
		if (result_num == 2)
		{
			text = " 我 们 的 外 交 部 谴 责 了 伊 斯 兰 极 端 主 义 者 对 萨 达 特 总 统 的 刺 杀 ， 并 派 遣 代 表 参 加 了 萨 达 特 的 葬 礼 ， 随 后 ， 同 埃 及 领 导 人 达 成 了 一 些 新 的 合 作 协 定 。||在 暗 杀 的 同 时 ， 伊 斯 兰 主 义 者 在 上 埃 及 的 阿 斯 尤 特 省 组 织 了 一 场 起 义 ， 叛 军 控 制 了 安 全 部 门 总 部 一 天 ， 并 又 拖 延 了 政 府 军 一 天 。 6 名 袭 击 者 和 6 8 名 警 察 和 士 兵 在 战 斗 中 丧 生 。 直 到 来 自 开 罗 的 伞 兵 抵 达 后 ， 空 军 出 动 两 架 喷 气 式 飞 机 恐 吓 武 装 分 子 ， 政 府 才 恢 复 了 对 该 地 的 控 制 。||伊 斯 兰 世 界 政 府 普 遍 对 这 次 暗 杀 表 示 热 烈 欢 迎 ， 他 们 将 萨 达 特 视 为 叛 徒 。 叙 利 亚 官 报 的 标 题 是 “ 今 日 埃 及 告 别 终 极 叛 徒 ” ， 而 伊 朗 则 以 伊 斯 兰 布 利 的 名 字 命 名 了 德 黑 兰 的 一 条 街 道 。 来 自 世 界 各 地 的 政 要 出 席 了 萨 达 特 的 葬 礼 ， 人 数 创 下 历 史 新 高 ， 其 中 ， 三 位 美 国 前 总 统 — — 杰 拉 尔 德 · 福 特 、 吉 米 · 卡 特 和 理 查 德 · 尼 克 松 同 时 出 席 。 苏 丹 总 统 加 法 尔 · 尼 迈 里 是 唯 一 出 席 葬 礼 的 阿 拉 伯 国 家 元 首 。 在 阿 拉 伯 联 盟 的 2 4 个 国 家 中 ， 只 有 3 个 国 家 — — 阿 曼 、 索 马 里 和 苏 丹 — — 派 出 了 代 表 。 以 色 列 总 理 梅 纳 赫 姆 · 贝 京 将 萨 达 特 视 为 私 人 朋 友 ， 坚 持 参 加 葬 礼 。||萨 达 特 最 初 由 人 民 议 会 议 长 苏 菲 · 阿 布 · 塔 勒 布 继 任 ， 他 就 任 代 理 总 统 并 立 即 宣 布 进 入 紧 急 状 态 。 八 天 后 ， 即 1 9 8 1 年 1 0 月 1 4 日 ， 萨 达 特 的 副 总 统 胡 斯 尼 · 穆 巴 拉 克 宣 誓 就 任 埃 及 新 总 统 ， 开 启 了 埃 及 在 紧 急 状 态 法 下 长 期 统 治 的 时 代 。 穆 巴 拉 克 采 取 了 更 为 多 边 的 外 交 方 式 ， 寻 求 与 阿 拉 伯 国 家 的 恢 复 关 系 。||伊 斯 兰 布 利 和 其 他 刺 客 受 到 审 判 、 定 罪 并 被 判 处 死 刑 。 他 们 于 1 9 8 2 年 4 月 1 5 日 被 处 决 ， 两 名 军 人 被 行 刑 队 处 决 ， 三 名 平 民 被 绞 死 。";
			GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[30].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[30].Torg = true;
			a.empires[0].relations += 100;
			a.empires[1].relations += 100;
			a.data[6] += 50;
		}
		if (result_num == 3)
		{
			text = " 在 暗 杀 的 同 时 ， 伊 斯 兰 主 义 者 在 上 埃 及 的 阿 斯 尤 特 省 组 织 了 一 场 起 义 ， 叛 军 控 制 了 安 全 部 门 总 部 一 天 ， 并 又 拖 延 了 政 府 军 一 天 。 6 名 袭 击 者 和 6 8 名 警 察 和 士 兵 在 战 斗 中 丧 生 。 直 到 来 自 开 罗 的 伞 兵 抵 达 后 ， 空 军 出 动 两 架 喷 气 式 飞 机 恐 吓 武 装 分 子 ， 政 府 才 恢 复 了 对 该 地 的 控 制 。||伊 斯 兰 世 界 政 府 普 遍 对 这 次 暗 杀 表 示 热 烈 欢 迎 ， 他 们 将 萨 达 特 视 为 叛 徒 。 叙 利 亚 官 报 的 标 题 是 “ 今 日 埃 及 告 别 终 极 叛 徒 ” ， 而 伊 朗 则 以 伊 斯 兰 布 利 的 名 字 命 名 了 德 黑 兰 的 一 条 街 道 。 来 自 世 界 各 地 的 政 要 出 席 了 萨 达 特 的 葬 礼 ， 人 数 创 下 历 史 新 高 ， 其 中 ， 三 位 美 国 前 总 统 — — 杰 拉 尔 德 · 福 特 、 吉 米 · 卡 特 和 理 查 德 · 尼 克 松 同 时 出 席 。 苏 丹 总 统 加 法 尔 · 尼 迈 里 是 唯 一 出 席 葬 礼 的 阿 拉 伯 国 家 元 首 。 在 阿 拉 伯 联 盟 的 2 4 个 国 家 中 ， 只 有 3 个 国 家 — — 阿 曼 、 索 马 里 和 苏 丹 — — 派 出 了 代 表 。 以 色 列 总 理 梅 纳 赫 姆 · 贝 京 将 萨 达 特 视 为 私 人 朋 友 ， 坚 持 参 加 葬 礼 。||萨 达 特 最 初 由 人 民 议 会 议 长 苏 菲 · 阿 布 · 塔 勒 布 继 任 ， 他 就 任 代 理 总 统 并 立 即 宣 布 进 入 紧 急 状 态 。 八 天 后 ， 即 1 9 8 1 年 1 0 月 1 4 日 ， 萨 达 特 的 副 总 统 胡 斯 尼 · 穆 巴 拉 克 宣 誓 就 任 埃 及 新 总 统 ， 开 启 了 埃 及 在 紧 急 状 态 法 下 长 期 统 治 的 时 代 。 穆 巴 拉 克 采 取 了 更 为 多 边 的 外 交 方 式 ， 寻 求 与 阿 拉 伯 国 家 的 恢 复 关 系 。||伊 斯 兰 布 利 和 其 他 刺 客 受 到 审 判 、 定 罪 并 被 判 处 死 刑 。 他 们 于 1 9 8 2 年 4 月 1 5 日 被 处 决 ， 两 名 军 人 被 行 刑 队 处 决 ， 三 名 平 民 被 绞 死 。";
			GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[30].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[30].Torg = true;
		}
	}
}
