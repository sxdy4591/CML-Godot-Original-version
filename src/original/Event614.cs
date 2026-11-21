using EventsForDLC;
using UnityEngine;

public class Event614 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "叛 徒 去 死";
		text = "在 沙 巴 战 争 之 后 ， 刚 果 民 族 解 放 阵 线 艰 难 的 维 持 着 所 谓 “ 加 丹 加 人 民 共 和 国 ” 的 政 府 班 子 。 但 随 着 刚 果 的 彻 底 解 放 。 这 一 政 权 的 地 位 略 显 尴 尬 ， 其 原 因 有 三 ： 体 量 太 小 ， 政 局 不 稳 ， 依 赖 外 援 。 更 别 提 刚 果 新 政 府 从 他 国 获 得 了 大 量 的 军 火 ， 他 们 也 渴 望 收 复 故 土 。 就 在 近 日 ， 刚 果 官 方 宣 布 展 开 收 复 失 地 的 “ 帕 特 里 克 · 卢 蒙 巴 ” 行 动 ， 旨 在 一 举 击 溃 境 外 势 力 扶 植 的 伪 政 权 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 骄 傲 的 站 起 身 ， 说 你 是 刚 果 人 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "叛 徒 去 死";
		if (result_num == 0)
		{
			if (a.allcountries[117].Gosstroy == 1)
			{
				text = "得 益 于 坦 桑 尼 亚 和 卢 旺 达 联 军 的 支 持 ， 刚 果 政 府 如 同 秋 风 扫 落 叶 般 击 溃 了 弱 小 的 “ 加 丹 加 人 民 共 和 国 ” 。 午 夜 ， 共 计 2 0 0 0 名 卢 旺 达 和 刚 果 的 伞 兵 空 降 在 了 “ 首 都 ” 卢 本 巴 希 ， 一 举 夺 下 了 “ 阿 格 施 蒂 纽 · 内 图 国 际 机 场 ” 。 在 中 心 城 区 ， 联 军 同 叛 乱 者 展 开 了 交 火 ， 尽 管 加 丹 加 人 民 军 的 抵 抗 力 度 比 预 想 的 要 强 大 ， 最 终 还 是 被 攻 破 。 与 此 同 时 ， 近 一 万 名 刚 果 人 民 革 命 军 精 锐 乘 坐 重 型 装 甲 车 从 北 部 。 在 卢 旺 达 和 坦 桑 尼 亚 的 压 倒 性 优 势 下 ， 姆 奔 巴 和 他 的 军 队 自 然 不 会 有 任 何 翻 盘 的 机 会 。 几 天 之 内 ， “ 加 丹 加 人 民 共 和 国 ” 总 统 蒙 古 亚 宣 布 辞 职 并 呼 吁 军 队 停 止 抵 抗 ， 姆 奔 巴 也 已 自 杀 。 而 试 图 最 后 捞 一 笔 的 苏 联 人 则 损 失 惨 重 ， 不 得 不 坐 在 谈 判 桌 前 签 署 了 和 约 ， 并 施 压 安 哥 拉 和 古 巴 人 不 再 干 涉 刚 果 内 政 。||刚 果 给 予 了 加 丹 加 地 区 的 自 治 权 ， 并 开 始 了 社 会 主 义 改 造 。 丰 富 的 资 源 定 能 为 刚 果 的 发 展 添 一 把 柴 。 原 先 的 加 丹 加 宪 兵 成 员 也 因 为 叛 国 罪 而 被 处 死 。 再 也 没 有 也 不 会 有 红 色 冲 伯 了 ！";
				a.allcountries[163].parts[0] = false;
				a.empires[1].relations -= 50;
				a.empires[0].relations -= 50;
			}
			else
			{
				text = "得 益 于 坦 桑 尼 亚 和 卢 旺 达 联 军 的 支 持 ， 刚 果 政 府 如 同 秋 风 扫 落 叶 般 击 溃 了 弱 小 的 “ 加 丹 加 人 民 共 和 国 ” 。 午 夜 ， 共 计 2 0 0 0 名 卢 旺 达 和 刚 果 的 伞 兵 空 降 在 了 “ 首 都 ” 卢 本 巴 希 ， 一 举 夺 下 了 “ 阿 格 施 蒂 纽 · 内 图 · 国 际 机 场 ” 。 在 中 心 城 区 ， 他 们 同 叛 乱 者 展 开 了 交 火 ， 尽 管 加 丹 加 人 民 军 的 抵 抗 力 度 比 预 想 的 要 强 大 ， 最 终 还 是 被 攻 破 。 与 此 同 时 ， 近 一 万 名 刚 果 人 民 革 命 军 精 锐 乘 坐 重 型 装 甲 车 从 北 部 。 在 卢 旺 达 和 坦 桑 尼 亚 的 压 倒 性 优 势 下 ， 姆 奔 巴 和 他 的 支 持 者 自 然 不 会 有 任 何 翻 盘 的 机 会 。 几 天 之 内 ， “ 加 丹 加 人 民 共 和 国 ” 总 统 蒙 古 亚 宣 读 了 辞 职 书 和 投 降 信 ， 姆 奔 巴 也 已 自 杀 。 而 试 图 最 后 捞 一 笔 的 苏 联 人 则 损 失 惨 重 ， 不 得 不 坐 在 谈 判 桌 前 签 署 了 和 约 ， 并 施 压 安 哥 拉 和 古 巴 人 不 再 干 涉 刚 果 内 政 。||为 了 征 收 合 理 的 “ 军 费 ” ， 出 兵 的 两 个 国 家 决 定 帮 卡 比 拉 政 府 实 行 为 其 2 0 年 的 “ 托 管 ” 。 大 量 的 钻 石 ， 铀 矿 ， 钴 和 铜 被 运 出 加 丹 加 省 。 卢 旺 达 一 年 的 出 口 量 比 自 己 本 土 的 产 量 还 高 ！ 卡 比 拉 被 反 对 派 指 责 为 “ 又 一 个 冲 伯 ” ， “ 背 叛 了 先 总 理 的 理 想 ” 。 但 只 要 詹 姆 斯 太 上 皇 一 日 坐 阵 金 沙 萨 ， 这 些 都 不 过 是 无 关 痛 痒 的 小 问 题 。";
				a.allcountries[163].parts[0] = false;
				a.empires[1].relations -= 50;
				a.empires[0].relations -= 50;
			}
		}
	}
}
