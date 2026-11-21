using EventsForDLC;
using UnityEngine;

public class Event538 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 人 民 的 革 命 ！";
		text = " 事 实 一 再 雄 辩 地 证 明 ， 无 产 阶 级 的 革 命 运 动 绝 不 会 因 为 暂 时 的 挫 折 就 沉 沦 下 去 。 进 入 八 十 年 代 后 ， 伴 随 着 革 命 阵 营 力 量 的 不 断 增 长 与 西 方 经 济 的 衰 退 ， 资 本 主 义 各 国 的 社 会 运 动 又 一 次 兴 起 。 而 日 本 自 然 也 无 法 独 善 其 身 。 欧 美 伙 伴 的 危 机 使 得 高 度 依 赖 其 市 场 的 日 本 经 济 严 重 下 滑 。 企 业 的 大 幅 亏 损 乃 至 倒 闭 引 发 了 空 前 的 失 业 潮 ， 无 数 工 人 乃 至 城 市 市 民 失 去 工 作 流 落 街 头 ， 贫 富 差 距 不 断 拉 大 。 农 民 因 为 产 品 滞 销 和 物 价 爆 炸 大 量 涌 入 城 市 ， 进 一 步 加 剧 了 社 会 动 荡 。 而 政 府 面 对 不 满 人 群 的 抗 议 也 无 能 为 力 。 而 本 就 躁 动 不 安 的 学 生 群 体 更 是 早 就 行 动 了 起 来 ， 一 如 十 五 年 前 的 安 田 讲 堂 斗 争 一 样 再 次 掀 起 了 运 动 。 很 快 ， 日 本 全 国 各 地 均 爆 发 了 大 规 模 的 集 会 示 威 乃 至 街 头 暴 动 。||此 时 ， 日 本 革 命 共 产 党 果 断 抓 住 这 个 时 机 ， 借 助 此 前 构 建 的 组 织 网 络 ， 在 青 年 学 生 、 工 人 、 农 民 之 间 开 展 了 广 泛 的 宣 传 活 动 。 用 通 俗 易 懂 的 语 言 直 截 了 当 地 告 诉 他 们 自 身 面 临 的 问 题 以 及 自 己 能 够 做 什 么 。 很 快 ， 日 本 革 命 共 产 党 便 收 获 了 一 大 批 支 持 者 。 革 命 者 的 行 为 引 起 了 日 本 政 府 的 高 度 警 惕 ， 相 关 部 门 很 快 便 组 织 了 大 批 人 员 对 他 们 在 各 地 的 活 动 分 部 进 行 查 抄 并 逮 捕 了 大 批 党 员 。 但 是 政 府 又 难 以 为 本 次 行 动 给 出 足 够 令 人 信 服 的 理 由 ， 只 能 用 “ 疑 似 组 织 针 对 政 府 机 关 的 极 端 暴 力 行 为 ” 为 借 口 。 这 种 莫 须 有 的 说 法 又 反 过 来 激 起 了 大 众 的 愤 怒 ， 各 地 的 暴 力 冲 突 开 始 迅 速 升 级 。 而 美 国 此 时 正 忙 于 欧 洲 局 势 ， 暂 时 难 以 对 亚 洲 施 以 更 多 干 预 。 主 席 同 志 ， 机 不 可 失 ， 失 不 再 来 ！ 是 时 候 让 红 旗 再 度 飘 扬 了 ！ 我 们 应 当 立 刻 行 动 起 来 ， 帮 助 日 本 人 民 赢 得 这 场 最 终 斗 争 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 是 时 候 了 ， 行 动 起 来 ！ 帮 助 日 本 人 民 赢 得 真 正 的 自 由 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 人 民 的 革 命 ！";
		if (result_num == 0)
		{
			text = " 得 益 于 此 前 所 做 的 准 备 ， 日 本 革 命 共 产 党 的 相 当 一 部 分 党 员 已 经 提 前 藏 匿 起 来 以 躲 避 抓 捕 。 待 到 行 动 过 后 ， 他 们 迅 速 现 身 并 号 召 民 众 不 要 屈 服 于 资 产 阶 级 的 暴 政 ， 立 刻 行 动 起 来 。 而 我 们 也 根 据 先 前 制 定 好 的 计 划 将 各 类 武 器 、 工 具 分 发 出 去 。 很 快 ， 组 织 起 来 的 青 年 学 生 、 工 人 和 农 民 对 各 地 的 监 狱 进 行 全 面 围 堵 ， 要 求 释 放 被 捕 人 士 。 警 方 则 直 接 动 用 水 炮 、 催 泪 弹 等 装 备 驱 散 群 众 。 但 早 已 得 到 装 备 的 民 众 顶 住 了 冲 击 并 不 断 压 缩 警 员 的 活 动 区 域 。 随 后 ， 一 批 佩 戴 防 毒 面 具 ， 头 戴 特 质 头 盔 ， 手 持 防 爆 盾 与 武 器 的 精 干 人 员 冲 破 了 警 方 障 碍 ， 冲 入 牢 房 并 成 功 营 救 了 被 关 押 的 同 志 们 。 这 次 抗 争 无 疑 是 一 个 信 号 ， 很 快 ， 日 本 革 命 共 产 党 正 式 宣 布 组 建 日 本 人 民 革 命 阵 线 ， 对 腐 朽 的 资 产 阶 级 政 权 展 开 了 全 面 进 攻 。 革 命 阵 线 旗 下 的 武 装 分 队 也 立 刻 在 各 地 展 开 武 装 夺 权 的 行 动 ， 这 是 人 民 的 怒 吼 ！";
			a.allcountries[44].Gosstroy = 0;
			a.allcountries[44].SubGosstroy = 7;
			GlobalScript.inst.gameState.ingamewars[36].name_war = " 日 本 革 命 战 争";
			GlobalScript.inst.gameState.ingamewars[36].is_going = true;
			GlobalScript.inst.gameState.ingamewars[36].side1 = " 日 本 政 府";
			GlobalScript.inst.gameState.ingamewars[36].side2 = " 日 本 人 民 革 命 阵 线";
			GlobalScript.inst.gameState.ingamewars[36].ussr_place = -1;
			GlobalScript.inst.gameState.ingamewars[36].usa_place = 0;
			GlobalScript.inst.gameState.ingamewars[36].infl1 = 700;
			GlobalScript.inst.gameState.ingamewars[36].infl2 = 300;
			GlobalScript.inst.gameState.ingamewars[36].fortnight_max = 20;
			a.data[8] -= 200;
			a.data[9] -= 200;
			a.data[22] -= 200;
		}
	}
}
