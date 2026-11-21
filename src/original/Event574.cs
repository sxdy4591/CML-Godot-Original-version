using EventsForDLC;
using UnityEngine;

public class Event574 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "选 举 ： 旋 转 起 舞 ";
		if (a.resultOfEvents[573] == 0)
		{
			text = " 虽 说 在 立 法 上 成 就 显 著 ， 可 宪 政 危 机 余 波 与 近 年 的 愈 演 愈 烈 的 通 货 膨 胀 问 题 仍 持 续 损 害 澳 大 利 亚 自 由 党 联 合 政 府 的 权 威 。 因 此 ， 今 年 选 举 将 格 外 激 烈 ： 工 党 吸 取 了 惠 特 拉 姆 政 策 教 训 ， 转 而 推 出 和 英 国 王 室 关 系 密 切 的 党 内 稳 健 派 比 尔 · 海 登 参 选 总 理 。 马 尔 科 姆 · 弗 雷 泽 则 急 需 选 战 胜 利 巩 固 改 革 政 策 ， 否 则 必 将 被 不 满 其 方 略 的 党 内 大 佬 们 一 脚 踢 下 。 ";
		}
		else if (a.resultOfEvents[573] == 1)
		{
			text = " 虽 说 在 立 法 上 成 就 显 著 ， 可 宪 政 危 机 余 波 与 近 年 的 愈 演 愈 烈 的 通 货 膨 胀 问 题 仍 持 续 损 害 澳 大 利 亚 自 由 党 联 合 政 府 的 权 威 。 因 此 ， 今 年 选 举 将 格 外 激 烈 ： 工 党 吸 取 了 宪 政 危 机 教 训 ， 转 而 推 出 反 英 王 的 党 内 激 进 派 鲍 勃 · 霍 克 参 选 总 理 。 马 尔 科 姆 · 弗 雷 泽 则 急 需 选 战 胜 利 巩 固 改 革 政 策 ， 否 则 必 将 被 不 满 其 方 略 的 党 内 大 佬 们 一 脚 踢 下 。 ";
		}
		else
		{
			text = " 虽 说 在 立 法 上 成 就 显 著 ， 可 宪 政 危 机 余 波 与 近 年 的 愈 演 愈 烈 的 通 货 膨 胀 问 题 仍 持 续 损 害 澳 大 利 亚 自 由 党 联 合 政 府 的 权 威 。 因 此 ， 今 年 选 举 将 格 外 激 烈 ： 工 党 少 壮 派 的 临 时 倒 戈 导 致 了 温 和 派 比 尔 · 海 登 出 局 ， 并 由 反 英 王 的 党 内 激 进 派 鲍 勃 · 霍 克 参 选 总 理 。 马 尔 科 姆 · 弗 雷 泽 则 急 需 选 战 胜 利 巩 固 改 革 政 策 ， 否 则 必 将 被 不 满 其 方 略 的 党 内 大 佬 们 一 脚 踢 下 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 我 们 正 在 等 待 结 果 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "选 举 ： 旋 转 起 舞 ";
		if (a.resultOfEvents[573] == 0)
		{
			text = " 结 果 ， 弗 雷 泽 成 功 稳 住 了 总 理 宝 座 ， 并 得 以 用 选 举 胜 利 暂 时 击 退 党 内 对 其 的 质 疑 ： 不 过 ， 他 似 乎 对 进 一 步 改 造 自 由 党 路 线 这 点 上 稍 显 力 不 从 心 。 工 党 则 被 选 战 结 果 彻 底 击 垮 ， 预 计 需 要 较 长 时 间 恢 复 元 气 。 这 意 味 着 弗 雷 泽 下 届 任 期 的 主 要 对 手 是 党 内 反 对 派 。 ";
			a.empires[0].power += 20;
		}
		else if (a.resultOfEvents[573] == 1)
		{
			text = " 结 果 ， 鲍 勃 · 霍 克 赢 得 了 选 举 胜 利 ， 野 心 勃 勃 的 霍 克 发 誓 将 力 行 社 会 改 革 ， 遏 制 通 货 膨 胀 并 重 新 审 视 外 交 关 系 ： 工 党 硬 左 派 们 领 导 的 澳 大 利 亚 开 始 主 张 非 军 事 化 、 和 平 主 义 与 协 调 冷 战 超 级 大 国 间 关 系 ， 事 实 上 奉 行 多 边 主 义 政 策 。 现 在 ， 我 们 可 以 说 我 们 在 地 球 的 那 一 边 有 了 自 己 人 ！";
			a.allcountries[135].SubGosstroy = 4;
			a.allcountries[135].Vyshi = false;
			a.allcountries[135].Torg = true;
			a.empires[0].power -= 10;
		}
		else
		{
			text = " 结 果 ， 鲍 勃 · 霍 克 赢 得 了 选 举 胜 利 ， 野 心 勃 勃 的 霍 克 发 誓 将 力 行 社 会 改 革 并 遏 制 通 货 膨 胀 。 由 此 启 动 了 澳 大 利 亚 工 党 内 的 少 壮 派 的 新 社 会 民 主 主 义 路 线 ： 他 们 试 图 在 协 调 劳 资 关 系 的 基 础 上 开 展 新 自 由 主 义 改 革 ， 最 终 建 成 一 个 既 亲 商 又 包 容 万 象 的 工 人 国 家 （ 并 以 此 同 支 持 社 会 保 守 主 义 的 旧 右 派 和 支 持 白 澳 政 策 的 旧 社 会 民 主 主 义 区 分 开 来 ） 。 让 我 们 看 看 接 下 来 会 发 生 什 么 … …";
			a.allcountries[135].SubGosstroy = 4;
		}
	}
}
