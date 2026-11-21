using EventsForDLC;
using UnityEngine;

public class Event628 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 保 佑 这 高 尚 的 土 地";
		text = "自 独 立 以 来 ， 博 茨 瓦 纳 一 直 被 视 为 一 个 南 部 非 洲 的 奇 迹 。 该 国 有 稳 定 的 政 治 局 势 以 及 相 对 发 达 的 经 济 。 国 父 塞 雷 茨 · 卡 马 爵 士 用 相 对 温 和 的 威 权 主 义 确 保 了 该 国 的 稳 定 。 但 这 一 优 势 随 着 该 国 周 围 局 势 日 新 月 异 而 悄 悄 发 展 着 。 很 快 ， 一 场 声 援 该 国 周 围 左 翼 国 家 的 游 行 在 该 国 首 都 哈 伯 罗 内 爆 发 了 ， 而 其 幕 后 推 手 正 是 我 们 早 日 支 持 的 博 茨 瓦 纳 争 取 社 会 主 义 运 动 。 我 们 将 借 此 机 会 把 脆 弱 的 该 国 掀 个 底 朝 天 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 胜 利 的 星 庇 护 着 他 们";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 保 佑 这 高 尚 的 土 地";
		if (result_num != 0)
		{
			return;
		}
		if (a.allcountries[131].SubGosstroy == 7 || a.allcountries[131].SubGosstroy == 9)
		{
			text = "在 市 中 心 被 攻 克 之 后 ， 博 茨 瓦 纳 民 族 民 主 解 放 军 并 没 有 按 照 预 定 计 划 中 的 迅 速 控 制 主 要 交 通 要 道 和 城 市 ， 而 是 迅 速 开 始 了 争 权 夺 利 的 内 斗 。 而 这 一 糟 糕 的 决 定 给 了 该 国 政 府 一 丝 喘 息 的 机 会 。 在 迅 速 流 亡 南 非 并 呼 唤 了 南 非 的 军 事 干 涉 后 ， 这 一 “ 保 守 主 义 的 金 牌 打 手 ” 果 然 没 有 让 人 失 望 。 很 快 ， 博 茨 瓦 纳 民 主 党 便 在 南 非 的 步 战 车 的 帮 助 下 迅 速 打 回 了 哈 伯 罗 内 ， 废 除 了 短 命 的 “ 博 茨 瓦 纳 人 民 共 和 国 ” 。 但 作 为 代 价 ， 南 非 将 在 博 茨 瓦 纳 保 留 足 够 的 军 事 存 在 ， 用 于 “ 对 抗 黑 人 布 尔 什 维 克 威 胁 ” ， “ 维 护 友 邦 安 全 ” 。 同 时 在 意 识 到 非 洲 国 家 根 本 不 适 合 共 和 制 之 后 ， 南 非 帮 助 博 茨 瓦 纳 确 定 了 新 的 政 治 体 制 — — 酋 长 合 众 邦 。 该 制 度 类 似 于 阿 联 酋 和 马 来 西 亚 的 制 度 ， 进 一 步 削 弱 了 该 国 潜 在 的 反 政 府 组 织 。||但 南 非 的 进 军 几 乎 将 “ 博 茨 瓦 纳 奇 迹 ” 付 之 一 炬 ， 战 争 的 伤 痕 在 该 国 四 处 可 见 ， 作 为 该 国 经 济 命 脉 的 畜 牧 业 更 是 惨 遭 “ 平 暴 用 无 污 染 ” 芥 子 气 的 打 击 ， 这 只 会 让 该 国 本 就 被 荒 漠 化 挑 战 的 经 济 雪 上 加 霜 。";
			a.allcountries[129].Gosstroy = 0;
			a.allcountries[129].SubGosstroy = 7;
			a.allcountries[129].LeaveAlliances();
			a.allcountries[129].name = "贝 专 兰 合 众 邦";
			a.allcountries[129].puppetOf = 131;
			a.influencePRC -= 20;
			a.empires[0].power += 20;
		}
		else if (a.allcountries[129].level_of_unstab == 200 && a.modifies[6].active && a.allcountries[129].cw)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[0] != 150 && GlobalScript.inst.gameState.politics_dolshnost[0] != 200)
			{
				text = "很 快 ， 示 威 游 行 很 快 升 级 为 了 展 现 “ 警 民 鱼 水 情 ” 的 现 场 直 播 。 更 别 提 一 向 标 榜 “ 中 立 客 观 ” 的 C N N 记 者 也 被 雇 佣 过 来 的 帮 派 分 子 打 倒 在 地 时 更 能 让 国 际 社 会 谴 责 该 国 的 了 。 很 明 显 ， 津 巴 布 韦 的 雨 林 中 磨 练 的 民 族 解 放 军 士 兵 们 远 比 警 察 们 的 战 斗 力 更 强 。 在 市 中 心 被 完 全 攻 克 后 ， 奎 特 · 马 西 雷 爵 士 宣 布 “ 不 愿 再 看 到 更 多 流 血 ” ， 他 决 定 辞 职 并 流 亡 美 国 。 随 后 ， 黑 黄 绿 的 三 色 旗 和 解 放 的 红 旗 高 高 的 在 哈 伯 罗 内 街 头 升 起 。||在 左 翼 大 帐 篷 合 作 的 时 期 中 ， 年 轻 而 富 有 魅 力 的 克 里 斯 托 弗 · 帕 什 威 得 以 组 建 了 一 支 以 他 为 核 心 的 革 命 队 伍 。 他 们 高 举 马 克 思 ， 列 宁 ， 斯 大 林 和 毛 泽 东 的 旗 帜 ， 这 也 就 是 他 们 的 派 系 被 称 为 M E L S （ 取 马 克 思 ， 恩 格 斯 ， 列 宁 ， 斯 大 林 四 人 的 首 字 母 之 意 ） 的 原 因 。 在 革 命 结 束 后 ， 博 茨 瓦 纳 争 取 社 会 主 义 运 动 被 改 组 为 博 茨 瓦 纳 劳 动 党 ， 毛 泽 东 主 义 也 被 写 入 了 该 党 的 党 章 。 博 茨 瓦 纳 共 和 国 正 式 改 名 为 博 茨 瓦 纳 民 主 共 和 国 ， 新 政 府 获 得 了 相 当 多 的 非 洲 进 步 国 家 的 承 认 ， 国 务 院 总 理" + a.names1[a.politics[a.politics_dolshnost[0]].name_1] + a.names2[a.politics[a.politics_dolshnost[0]].name_2] + "也 前 去 会 见 了 新 政 府 首 脑 。 至 少 ， 又 一 个 非 洲 国 家 投 入 了 社 会 主 义 的 怀 抱 。 ";
			}
			else if (GlobalScript.inst.gameState.politics_dolshnost[0] == 200)
			{
				text = "很 快 ， 示 威 游 行 很 快 升 级 为 了 展 现 “ 警 民 鱼 水 情 ” 的 现 场 直 播 。 更 别 提 一 向 标 榜 “ 中 立 客 观 ” 的 C N N 记 者 也 被 雇 佣 过 来 的 帮 派 分 子 打 倒 在 地 时 更 能 让 国 际 社 会 谴 责 该 国 的 了 。 很 明 显 ， 津 巴 布 韦 的 雨 林 中 磨 练 的 民 族 解 放 军 士 兵 们 远 比 警 察 们 的 战 斗 力 更 强 。 在 市 中 心 被 完 全 攻 克 后 ， 奎 特 · 马 西 雷 爵 士 宣 布 “ 不 愿 再 看 到 更 多 流 血 ” ， 他 决 定 辞 职 并 流 亡 美 国 。 随 后 ， 黑 黄 绿 的 三 色 旗 和 解 放 的 红 旗 高 高 的 在 哈 伯 罗 内 街 头 升 起 。||在 左 翼 大 帐 篷 合 作 的 时 期 中 ， 年 轻 而 富 有 魅 力 的 克 里 斯 托 弗 · 帕 什 威 得 以 组 建 了 一 支 以 他 为 核 心 的 革 命 队 伍 。 他 们 高 举 马 克 思 ， 列 宁 ， 斯 大 林 和 毛 泽 东 的 旗 帜 ， 这 也 就 是 他 们 的 派 系 被 称 为 M E L S （ 取 马 克 思 ， 恩 格 斯 ， 列 宁 ， 斯 大 林 四 人 的 首 字 母 之 意 ） 的 原 因 。 在 革 命 结 束 后 ， 博 茨 瓦 纳 争 取 社 会 主 义 运 动 被 改 组 为 博 茨 瓦 纳 劳 动 党 ， 毛 泽 东 主 义 也 被 写 入 了 该 党 的 党 章 。 博 茨 瓦 纳 共 和 国 正 式 改 名 为 博 茨 瓦 纳 民 主 共 和 国 ， 新 政 府 获 得 了 相 当 多 的 非 洲 进 步 国 家 的 承 认 ， 国 家 主 席" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "也 前 去 会 见 了 新 政 府 首 脑 。 至 少 ， 又 一 个 非 洲 国 家 投 入 了 社 会 主 义 的 怀 抱 。 ";
			}
			else
			{
				text = "很 快 ， 示 威 游 行 很 快 升 级 为 了 展 现 “ 警 民 鱼 水 情 ” 的 现 场 直 播 。 更 别 提 一 向 标 榜 “ 中 立 客 观 ” 的 C N N 记 者 也 被 雇 佣 过 来 的 帮 派 分 子 打 倒 在 地 时 更 能 让 国 际 社 会 谴 责 该 国 的 了 。 很 明 显 ， 津 巴 布 韦 的 雨 林 中 磨 练 的 民 族 解 放 军 士 兵 们 远 比 警 察 们 的 战 斗 力 更 强 。 在 市 中 心 被 完 全 攻 克 后 ， 奎 特 · 马 西 雷 爵 士 宣 布 “ 不 愿 再 看 到 更 多 流 血 ” ， 他 决 定 辞 职 并 流 亡 美 国 。 随 后 ， 黑 黄 绿 的 三 色 旗 和 解 放 的 红 旗 高 高 的 在 哈 伯 罗 内 街 头 升 起 。||在 左 翼 大 帐 篷 合 作 的 时 期 中 ， 年 轻 而 富 有 魅 力 的 克 里 斯 托 弗 · 帕 什 威 得 以 组 建 了 一 支 以 他 为 核 心 的 革 命 队 伍 。 他 们 高 举 马 克 思 ， 列 宁 ， 斯 大 林 和 毛 泽 东 的 旗 帜 ， 这 也 就 是 他 们 的 派 系 被 称 为 M E L S （ 取 马 克 思 ， 恩 格 斯 ， 列 宁 ， 斯 大 林 四 人 的 首 字 母 之 意 ） 的 原 因 。 在 革 命 结 束 后 ， 博 茨 瓦 纳 争 取 社 会 主 义 运 动 被 改 组 为 博 茨 瓦 纳 劳 动 党 ， 毛 泽 东 主 义 也 被 写 入 了 该 党 的 党 章 。 博 茨 瓦 纳 共 和 国 正 式 改 名 为 博 茨 瓦 纳 民 主 共 和 国 ， 新 政 府 获 得 了 相 当 多 的 非 洲 进 步 国 家 的 承 认 ， 国 务 院 总 理" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "也 前 去 会 见 了 新 政 府 首 脑 。 至 少 ， 又 一 个 非 洲 国 家 投 入 了 社 会 主 义 的 怀 抱 。 ";
			}
			a.allcountries[129].Gosstroy = 1;
			a.allcountries[129].SubGosstroy = 17;
			a.allcountries[129].LeaveAlliances();
			a.allcountries[129].proprc = true;
			a.allcountries[129].Torg = true;
			a.allcountries[129].name = "博 茨 瓦 纳 民 主 共 和 国";
			a.influencePRC += 20;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 20;
		}
		else
		{
			text = "很 快 ， 示 威 游 行 很 快 升 级 为 了 展 现 “ 警 民 鱼 水 情 ” 的 现 场 直 播 。 更 别 提 一 向 标 榜 “ 中 立 客 观 ” 的 C N N 记 者 也 被 雇 佣 过 来 的 帮 派 分 子 打 倒 在 地 时 更 能 让 国 际 社 会 谴 责 该 国 的 了 。 很 明 显 ， 津 巴 布 韦 的 雨 林 中 磨 练 的 民 族 解 放 军 士 兵 们 远 比 警 察 们 的 战 斗 力 更 强 。 在 市 中 心 被 完 全 攻 克 后 ， 奎 特 · 马 西 雷 爵 士 宣 布 “ 不 愿 再 看 到 更 多 流 血 ” ， 他 决 定 辞 职 并 流 亡 美 国 。 随 后 ， 黑 黄 绿 的 三 色 旗 和 解 放 的 红 旗 高 高 的 在 哈 伯 罗 内 街 头 升 起 。||在 我 们 和 苏 联 的 通 力 帮 助 下 ， 贝 松 · 加 塞 兹 韦 阁 下 率 领 的 “ 民 族 阵 线 ” 派 确 保 了 自 己 的 领 先 地 位 ， 在 贝 专 兰 形 成 了 一 个 左 翼 的 民 族 社 会 主 义 大 帐 篷 — — — — 博 茨 瓦 纳 人 民 革 命 党 。 尽 管 不 少 革 命 者 和 内 部 的 反 对 派 谴 责 他 的 诸 多 政 策 。 例 如 承 认 酋 长 制 ， 不 触 及 土 地 改 革 ， 但 极 度 敌 视 南 非 政 府 且 组 织 集 体 牧 场 。 但 在 我 们 和 苏 联 的 帮 助 下 ， 他 定 会 率 领 博 茨 瓦 纳 人 民 革 命 党 走 向 光 辉 的 未 来 。 ";
			a.allcountries[129].Gosstroy = 1;
			a.allcountries[129].SubGosstroy = 16;
			a.allcountries[129].LeaveAlliances();
			a.allcountries[129].prosov = true;
			a.allcountries[129].Torg = true;
			a.allcountries[129].name = "博 茨 瓦 纳 社 会 主 义 共 和 国";
			a.influencePRC += 10;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 20;
			a.empires[1].relations += 100;
			a.empires[1].power += 15;
		}
	}
}
