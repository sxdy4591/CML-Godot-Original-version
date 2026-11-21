using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event18 : EventsSecond
{
	private GameState a;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		if ((GlobalScript.inst.gameState.data[82] == 69 && GlobalScript.inst.gameState.ingamewars[69].infl1 < 1000) || (GlobalScript.inst.gameState.data[82] == 70 && GlobalScript.inst.gameState.ingamewars[70].infl1 < 1000))
		{
			name = " 真 该 死 ！ ";
			text = " 在 长 时 间 的 血 腥 冲 突 之 后 “" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + " ” 终 于 结 束 了 。||前 线 的 状 态 并 不 乐 观 … …";
			return;
		}
		if (GlobalScript.inst.gameState.data[82] == 36 && GlobalScript.inst.gameState.ingamewars[36].infl2 >= 1000)
		{
			name = " 日 本 革 命 的 胜 利 ！";
			text = " 在 长 时 间 的 血 腥 冲 突 之 后 “" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + " ” 终 于 结 束 了 。||在 得 到 了 大 量 的 人 力 物 力 支 援 后 ， 日 本 人 民 革 命 阵 线 迅 速 夺 取 了 九 州 、 四 国 、 北 海 道 等 地 的 地 方 政 权 。 得 益 于 此 前 党 员 们 的 积 极 活 动 ， 革 命 阵 线 早 在 起 义 之 前 便 已 秘 密 组 织 了 一 批 工 人 赤 卫 队 。 得 到 帮 助 的 革 命 队 伍 很 快 便 控 制 了 当 地 的 警 局 、 自 卫 队 基 地 等 关 键 点 。 战 士 们 迅 速 收 缴 武 器 、 归 拢 被 俘 人 员 ， 并 对 政 府 的 通 信 线 路 进 行 了 彻 底 的 破 坏 。 等 到 日 本 政 府 费 尽 心 力 好 不 容 易 勉 强 恢 复 通 讯 的 时 候 ， 革 命 军 的 主 力 已 经 完 成 了 集 结 ， 队 伍 由 缴 获 的 坦 克 和 装 甲 车 带 头 ， 加 紧 向 东 京 进 发 。 收 到 政 府 求 救 消 息 的 美 军 基 地 试 图 行 动 ， 但 是 革 命 军 在 起 义 的 第 一 时 间 就 对 基 地 进 行 了 全 面 封 锁 ， 切 断 物 资 供 给 的 同 时 派 出 受 过 特 训 的 小 分 队 秘 密 潜 入 基 地 对 补 给 仓 库 进 行 破 坏 ， 这 让 基 地 内 美 军 的 日 子 越 来 越 不 好 过 。 正 如 一 位 革 命 军 中 层 指 挥 官 所 说 ： “ 就 算 是 一 只 鸟 也 不 许 飞 进 基 地 。 ” 此 外 ， 革 命 军 还 通 过 传 单 、 喇 叭 、 电 台 、 电 视 录 像 带 等 渠 道 对 自 卫 队 成 员 展 开 了 宣 传 攻 势 ， 指 出 革 命 洪 流 不 可 阻 挡 的 同 时 也 点 明 了 自 卫 队 成 员 自 身 的 困 境 ， 呼 吁 他 们 “ 同 日 本 人 民 站 在 一 起 ” 。 一 部 分 自 卫 队 人 员 被 成 功 策 反 ， 向 革 命 军 提 供 了 许 多 情 报 ， 这 让 战 斗 变 得 更 加 顺 利 了 。||处 于 混 乱 和 绝 望 中 的 日 本 政 府 妄 图 动 员 一 切 能 动 员 的 力 量 ， 指 派 首 都 地 区 自 卫 队 保 卫 城 市 的 同 时 与 北 约 成 员 国 联 系 ， 希 望 借 它 们 的 力 量 平 息 革 命 。 但 在 人 民 的 支 持 下 ， 这 种 负 隅 顽 抗 是 毫 无 意 义 的 。 同 时 我 们 对 革 命 军 提 供 了 全 方 位 的 军 事 技 术 指 导 ， 并 且 向 他 们 提 供 了 自 卫 队 的 完 整 武 器 装 备 情 况 。 有 了 我 们 的 支 持 ， 在 革 命 军 的 多 重 攻 势 下 ， 东 京 被 成 功 攻 克 。 自 卫 队 残 余 成 员 放 下 了 武 器 ， 而 前 政 府 部 分 成 员 则 匆 忙 乘 飞 机 逃 往 威 克 岛 。 那 些 未 来 得 及 逃 走 的 人 则 和 天 皇 家 族 的 成 员 一 起 被 革 命 军 俘 虏 。 等 待 着 他 们 的 将 是 日 本 人 民 的 审 判 。 ";
			return;
		}
		if (GlobalScript.inst.gameState.data[82] == 3 && GlobalScript.inst.gameState.ingamewars[3].infl1 < 900 && a.allcountries[14].Gosstroy == 1)
		{
			name = " 凯 菲 尔 的 末 日";
			text = " 同 志 ， 巴 格 达 传 来 了 灾 难 性 的 消 息 ， 伊 拉 克 政 权 在 两 伊 战 争 中 遭 到 了 灾 难 性 的 战 败 。||新 生 的 革 命 政 权 被 伊 朗 的 庞 大 榨 干 了 最 后 一 丝 热 血 。 在 巴 士 拉 艰 苦 卓 绝 的 拉 锯 战 中 ， 双 方 最 优 秀 的 儿 女 纷 纷 殒 命 沙 场 ， 但 伊 朗 的 人 数 远 远 多 于 伊 拉 克 人 。 在 一 次 又 一 次 的 自 杀 式 袭 击 后 ， 巴 士 拉 被 攻 破 。 伊 朗 军 队 士 气 大 张 ， 下 一 个 目 标 一 直 在 变 ， 先 是 纳 西 里 耶 ， 再 是 萨 马 沃 ， 到 纳 杰 夫 … … 而 伊 拉 克 内 部 的 派 系 矛 盾 也 被 伊 朗 所 利 用 ， 库 尔 德 和 阿 拉 伯 人 ， 逊 尼 派 和 什 叶 派 的 ， 甚 至 是 革 命 者 和 前 政 府 官 员 的 矛 盾 。 在 库 尔 德 人 宣 布 脱 离 共 和 国 独 立 的 时 候 ， 伊 朗 人 已 经 攻 入 了 伊 斯 坎 德 里 耶 ， 而 巴 格 达 也 已 经 不 远 了 。 终 于 ， 革 命 政 府 宣 布 投 降 ， 伊 拉 克 社 会 主 义 工 农 党 也 宣 布 解 散 。";
			return;
		}
		if (GlobalScript.inst.gameState.data[82] > 7)
		{
			name = " 战 争 结 束 了";
			text = " 在 长 时 间 的 血 腥 冲 突 之 后 “" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + " ” 终 于 结 束 了 。 我 国 外 交 部 密 切 留 意 全 程 ， 并 已 准 备 好 为 您 汇 报 战 争 的 最 终 结 果 。 ";
			return;
		}
		if (GlobalScript.inst.gameState.data[82] <= 7)
		{
			name = " 战 争 结 束 了";
			text = " 在 长 时 间 的 血 腥 冲 突 之 后 “" + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].name_war + " ” 终 于 结 束 了 。";
		}
		if (GlobalScript.inst.gameState.data[82] == 6)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 400)
			{
				text = text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。";
				return;
			}
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 400)
			{
				text = text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。";
				return;
			}
		}
		if (GlobalScript.inst.gameState.data[82] == 2)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 750)
			{
				text = text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。";
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 < 750)
			{
				text = text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。";
			}
		}
		else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900 || GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
		{
			text = text + " 最 终 ， 胜 利 属 于 " + ((GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 > GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2) ? GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side1 : GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2) + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。";
		}
		else if (GlobalScript.inst.gameState.data[82] == 2 || GlobalScript.inst.gameState.data[82] == 4)
		{
			text = text + " 最 终 ， 胜 利 属 于 " + GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].side2 + "  一 方 ， 他 们 得 以 通 过 战 争 中 实 现 其 目 标 。";
		}
		else if (GlobalScript.inst.gameState.data[82] != 2 && GlobalScript.inst.gameState.data[82] != 4)
		{
			text += " 双 方 都 没 有 取 得 决 定 性 的 胜 利 ， 因 此 无 条 件 和 平 协 议 得 以 签 署 ， 使 边 界 恢 复 到 战 前 状 态 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		if (GlobalScript.inst.gameState.data[82] < 8)
		{
			button_text[0] = " 和 平 万 岁 ！";
		}
		else if ((GlobalScript.inst.gameState.data[82] == 69 && GlobalScript.inst.gameState.ingamewars[69].infl1 < 1000) || (GlobalScript.inst.gameState.data[82] == 70 && GlobalScript.inst.gameState.ingamewars[70].infl1 < 1000))
		{
			button_text[0] = " 发 生 什 么 了 ？";
		}
		else if (GlobalScript.inst.gameState.data[82] == 36 && GlobalScript.inst.gameState.ingamewars[36].infl2 >= 1000)
		{
			button_text[0] = " 为 我 们 日 本 同 志 的 胜 利 敬 一 杯 ！";
		}
		else if (GlobalScript.inst.gameState.data[82] != 3 || GlobalScript.inst.gameState.ingamewars[3].infl1 >= 900 || a.allcountries[14].Gosstroy != 1)
		{
			if (GlobalScript.inst.gameState.data[82] >= 8)
			{
				button_text[0] = " 结 果 不 得 不 看 ！";
			}
		}
		else if (a.data[56] == 0)
		{
			button_text[0] = " 他 们 没 能 建 成 地 上 天 国";
		}
		else if (a.data[56] > 0 && a.data[56] < 3)
		{
			button_text[0] = " 真 主 还 是 对 扎 利 姆 降 下 了 惩 罚";
		}
		else
		{
			button_text[0] = " 绿 色 共 匪 战 胜 了 红 色 法 西 斯";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 战 争 结 束 了";
		if (result_num == 0)
		{
			text = " 另 一 场 战 争 结 束 了 。";
			GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].is_going = false;
			GlobalScript.inst.gameState.WarResult(ref text);
			if (GlobalScript.inst.gameState.data[82] == 69 && GlobalScript.inst.gameState.ingamewars[69].infl1 < 1000)
			{
				name = " 真 该 死 ！ ";
				text = " 出 乎 我 们 的 意 料 ， 孱 弱 的 蒙 古 军 队 设 法 逼 退 了 中 国 人 民 解 放 军 。 由 于 战 争 初 期 的 失 误 指 挥 ， 我 们 的 先 遣 部 队 在 乌 兰 巴 托 残 酷 的 巷 战 中 损 失 惨 痛 。 而 蒙 古 民 众 也 并 不 相 信 我 们 能 为 他 们 带 来 解 放 。 纷 纷 拿 起 苏 制 装 备 躲 进 山 区 里 ， 或 是 骑 在 马 上 把 我 们 的 巡 逻 队 员 绞 杀 至 死 。 极 端 民 族 主 义 组 织 “ 白 色 十 字 ” 甚 至 成 功 的 暗 杀 了 我 们 指 挥 对 蒙 作 战 的 军 事 首 长 。 苏 联 以 自 愿 报 名 为 由 派 遣 了 成 建 制 的 “ 志 愿 军 ” ， 古 巴 和 法 国 的 雇 佣 兵 也 通 过 苏 联 来 到 蒙 古 ， 在 各 个 地 方 运 用 他 们 在 非 洲 学 到 的 知 识 ， 打 击 我 们 的 战 士 。 在 惨 痛 的 绞 肉 战 后 ， 这 场 军 事 冒 险 在 丢 下 几 万 具 尸 体 后 惨 败 收 场 。 最 耻 辱 的 莫 过 于 蒙 古 甚 至 设 法 攻 克 了 二 连 浩 特 ， 当 着 我 们 全 体 电 视 观 众 的 面 把 我 们 的 国 旗 扯 下 并 点 燃 。 在 各 国 的 斡 旋 和 美 国 的 武 力 威 胁 下 ， 我 们 只 得 灰 溜 溜 的 撤 出 蒙 古 。 蒙 古 政 府 把 这 次 胜 利 比 做 二 十 一 世 纪 的 土 木 堡 之 战 。 他 们 增 加 了 军 费 ， 甚 至 采 购 了 导 弹 。 等 等 ， 门 口 的 敲 门 声 是 ？";
				GlobalScript.inst.gameState.data[35] = 11;
				load_scene_after_click = true;
			}
			else if (GlobalScript.inst.gameState.data[82] == 70 && GlobalScript.inst.gameState.ingamewars[70].infl1 < 1000)
			{
				name = " 真 该 死 ！ ";
				text = "苏 联 通 过 背 靠 北 约 盟 友 ， 将 亚 洲 大 战 变 为 了 不 亚 于 日 俄 战 争 的 残 酷 绞 肉 机 。 虽 然 我 们 的 海 军 得 以 封 锁 库 页 岛 ， 并 将 苏 联 的 海 军 困 死 在 港 口 内 ； 但 我 们 的 陆 军 并 没 能 在 各 个 方 面 取 得 进 展 ， 他 们 只 能 困 守 海 参 崴 和 伯 力 。 此 后 ， 苏 联 人 更 是 借 助 美 方 导 弹 平 台 轰 炸 我 核 心 工 业 区 与 关 键 城 市 ， 甚 至 让 北 京 也 陷 入 威 胁 当 中 。 在 付 出 数 十 万 人 的 伤 亡 后 ， 我 们 不 得 不 回 到 谈 判 桌 上 同 苏 联 达 成 妥 协 ， 而 作 为 战 争 的 发 起 者 的 你 定 没 有 好 下 场 … …";
				GlobalScript.inst.gameState.data[35] = 12;
				load_scene_after_click = true;
			}
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			SceneManager.LoadScene("Ending");
		}
	}
}
