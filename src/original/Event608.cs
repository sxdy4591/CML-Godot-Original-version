using EventsForDLC;
using UnityEngine;

public class Event608 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "安 吉 拉 行 动";
		text = "在 勒 内 上 台 并 于1979 年 选 举 中 不 出 意 料 的 获 胜 后 ， 其 更 近 一 步 的 社 会 主 义 改 革 惹 怒 了 人 数 不 多 但 有 影 响 力 的 中 产 阶 级 ， 同 时 期 塞 舌 尔 禁 止 南 非 飞 机 着 陆 ， 两 国 之 间 的 关 系 恶 化 起 来 。 而 被 迫 流 亡 海 外 的 前 塞 舌 尔 总 统 曼 卡 姆 则 开 始 于 南 非 进 行 秘 密 联 络 ， 南 非 同 意 派 出 部 分 雇 佣 兵 开 始 对 塞 舌 尔 进 行 政 变 ， 而 身 经 百 战 的 雇 佣 兵 “ 疯 子 迈 克 ” 迈 克 · 霍 尔 则 成 为 了 这 次 行 动 的 总 指 挥 。 其 召 集 了 数 十 名 南 非 国 防 军 士 兵 和 前 罗 德 西 亚 士 兵 ， 前 刚 果 士 兵 ， 军 力 强 大 ， 看 起 来 塞 舌 尔 的 社 会 主 义 政 府 将 面 临 严 重 的 威 胁 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 1)
		{
			button_text[0] = " 通 过 坦 桑 尼 亚 之 手 来 保 卫 勒 内 政 府";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 该 帮 助 这 个 极 左 独 裁 政 府";
		}
		if (a.allcountries[155].Gosstroy != 1 && a.data[56] > 1 && a.data[6] <= 700)
		{
			button_text[1] = " 与 南 非 进 行 合 作";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 与 南 非 的 白 人 殖 民 主 义 者 站 在 一 起 ！";
		}
		button_text[2] = " 额 ， 这 里 是 哪 里 来 着";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 安 吉 拉 行 动";
		if (result_num == 0)
		{
			text = "疯 子 迈 克 的 大 量 招 募 雇 佣 兵 的 消 息 在 伦 敦 ， 巴 黎 等 地 的 雇 佣 兵 圈 子 已 经 广 为 人 知 ， 自 然 我 们 的 特 工 也 获 得 了 这 个 消 息 。11 月25 日 傍 晚 ， 疯 子 迈 克 和 数 十 名 雇 佣 兵 飞 抵 塞 舌 尔 国 际 机 场 ， 但 在 经 过 安 检 途 中 ， 一 名 雇 佣 兵 的ak 步 枪 被 发 现 ， 雇 佣 兵 们 意 识 到 行 动 暴 露 了 ， 随 即 拿 起 了 武 器 ， 一 名 保 安 跑 向 办 公 室 寻 求 帮 助 并 锁 上 了 门 闩 ， 成 功 拉 响 了 警 报 。 之 后 在 我 们 脸 涂 黑 的 特 勤 和 坦 桑 尼 亚 驻 军 的 进 攻 下 部 分 雇 佣 兵 被 击 毙 ， 疯 子 迈 克 等 人 被 俘 获 并 在 审 讯 中 透 漏 出 此 次 行 动 为 南 非 政 府 策 划 的 ， 疯 子 迈 克 等 雇 佣 兵 随 即 便 被 判 处 死 刑 ， 看 来 南 非 雇 佣 兵 的 水 平 不 过 如 此 。 南 非 政 府 本 就 败 坏 的 国 际 形 象 变 得 更 加 破 败 ， 塞 舌 尔 政 府 对 此 次 行 动 中 出 力 的 坦 桑 尼 亚 和 我 们 表 达 了 感 激 ， 勒 内 政 府 决 定 学 习 坦 桑 尼 亚 的 乌 贾 马 社 会 主 义 ， 并 宣 布 按 照 中 国 模 式 建 设 社 会 主 义 。 ";
			a.data[8] -= 30;
			a.data[9] -= 30;
			if (a.allcountries[155].Gosstroy == 1)
			{
				a.allcountries[155].SubGosstroy = 0;
			}
			else
			{
				a.allcountries[155].Gosstroy = 1;
				a.allcountries[155].SubGosstroy = 1;
			}
			a.allcountries[155].LeaveAlliances();
			a.allcountries[155].proprc = true;
			a.allcountries[155].Torg = true;
			if (a.allcountries[1].econ)
			{
				a.allcountries[155].JoinECON();
			}
		}
		if (result_num == 1)
		{
			text = "11 月25 日 傍 晚 ， 疯 子 迈 克 和 数 十 名 雇 佣 兵 以 及 部 分 我 们 的 脸 涂 黑 的 特 勤 飞 抵 塞 舌 尔 国 际 机 场 ， 成 功 通 过 安 检 并 按 照 原 计 划 分 散 在 马 埃 岛 的 各 个 酒 店 。 在 数 天 之 后 ， 当 勒 内 召 开 内 阁 会 议 之 时 ， 雇 佣 兵 和 我 们 的 特 勤 占 领 了 议 会 ， 机 场 ， 军 营 ， 广 播 电 台 等 各 战 略 要 地 并 宣 布 他 们 代 表 曼 卡 姆 对 塞 舌 尔 进 行 政 变 。 勒 内 和 一 众 塞 舌 尔 高 管 被 关 进 监 狱 ， 流 亡 在 外 的 曼 卡 姆 虽 如 愿 重 新 当 上 总 统 ， 但 实 际 则 是 傀 儡 ， 而 以 疯 子 迈 克 和 南 非 雇 佣 兵 为 首 的 南 非 势 力 则 在 幕 后 掌 权 ， 塞 舌 尔 对 军 队 进 行 了 清 洗 并 以 参 与 政 变 的 雇 佣 兵 为 骨 干 进 行 扩 编 。 塞 舌 尔 实 际 上 已 经 成 为 了 另 一 个 班 图 斯 坦 ， 而 国 际 上 对 塞 舌 尔 政 变 则 是 普 遍 的 谴 责 。 ";
			a.data[9] -= 30;
			a.allcountries[155].Gosstroy = 0;
			a.allcountries[155].SubGosstroy = 7;
			a.allcountries[155].LeaveAlliances();
			a.allcountries[155].puppetOf = 131;
		}
		if (result_num == 2)
		{
			text = "11 月25 日 傍 晚 ， 疯 子 迈 克 和 数 十 名 雇 佣 兵 飞 抵 塞 舌 尔 国 际 机 场 ， 但 在 经 过 安 检 途 中 ， 一 名 雇 佣 兵 的ak 步 枪 被 发 现 ， 雇 佣 兵 们 意 识 到 行 动 暴 露 了 ， 随 即 拿 起 了 武 器 ， 一 名 保 安 跑 向 办 公 室 寻 求 帮 助 并 锁 上 了 门 闩 ， 成 功 拉 响 了 警 报 。 这 导 致 了 机 场 一 场 长 达 六 个 小 时 的 枪 战 ， 就 在 此 时 ， 一 架 印 度 航 空 客 机 意 外 的 降 落 在 这 座 机 场 上 ， 塞 舌 尔 军 队 试 图 中 止 降 落 但 未 能 奏 效 ， 部 分 雇 佣 兵 借 此 机 会 登 上 这 架 客 机 ， 大 约70 名 机 组 人 员 和 乘 客 被 雇 佣 兵 劫 持 为 人 质 。 最 终 这 家 飞 机 被 劫 持 飞 往 南 非 的 德 班 市 ， 机 组 人 员 和 乘 客 全 部 释 放 ， 塞 舌 尔 逮 捕 了 六 名 雇 佣 兵 ， 其 余 大 部 分 雇 佣 兵 则 成 功 返 回 南 非 。||看 起 来 南 非 的 雇 佣 兵 水 平 不 过 如 此 。 ";
			a.allcountries[155].proprc = false;
		}
	}
}
