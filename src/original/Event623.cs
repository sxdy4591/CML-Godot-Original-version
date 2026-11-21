using EventsForDLC;
using UnityEngine;

public class Event623 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "从 鲁 乌 马 到 马 普 托";
		text = "经 过 我 们 和 我 们 的 盟 友 以 及 苏 东 阵 营 的 长 期 支 援 ， 并 得 益 于 康 乃 馨 革 命 ， 莫 桑 比 克 解 放 阵 线 终 于 获 得 了 反 殖 民 斗 争 的 阶 段 性 胜 利 ， 在1975 年6 月25 日 成 立 了 莫 桑 比 克 人 民 共 和 国 ， 由 有 “ 非 洲 的 切 · 格 瓦 拉 ” 之 称 的 萨 莫 拉 · 马 谢 尔 担 任 最 高 领 导 人 。 在 争 取 独 立 的 斗 争 中 ， 莫 桑 比 克 解 放 阵 线 的 左 派 战 胜 了 内 部 的 资 产 阶 级 民 族 主 义 路 线 的 支 持 者 ， 赢 得 了 路 线 斗 争 ， 该 组 织 也 逐 渐 从 亲 左 翼 的 民 族 主 义 组 织 转 向 了 支 持 马 克 思 列 宁 主 义 的 革 命 组 织 。 意 识 形 态 上 ， 它 也 更 多 地 受 到 毛 泽 东 思 想 的 影 响 ， 相 比 亲 苏 的 同 样 持 马 列 主 义 的 安 哥 拉 人 民 解 放 运 动 而 言 ， 他 们 显 得 更 具 革 命 性 — — 积 极 支 持 阶 级 斗 争 、 政 治 挂 帅 等 原 则 。||然 而 ， 独 立 后 的 路 并 不 一 帆 风 顺 ， 殖 民 者 留 下 的 是 一 个 千 疮 百 孔 的 莫 桑 比 克 ， 经 济 凋 敝 ， 被 形 容 为 “ 实 际 上 破 产 的 国 家 ” ； 周 边 的 种 族 政 权 以 及 莫 桑 比 克 本 土 的 白 人 资 本 家 和 地 主 也 不 愿 意 见 到 一 个 新 的 左 翼 反 帝 政 权 — —1976 年 ， 在 罗 德 西 亚 和 白 人 南 非 的 支 持 下 ， 白 人 叛 乱 组 织 “ 死 亡 之 龙 ” 同 被 清 除 出 党 的 莫 解 阵 右 翼 分 子 的 叛 乱 组 织 合 并 为 拥 有 上 万 人 的 “ 莫 桑 比 克 全 国 抵 抗 运 动 ” ， 对 人 民 共 和 国 发 起 了 全 国 性 的 战 争 。 对 于 莫 桑 比 克 解 放 阵 线 党 而 而 言 ， 他 们 需 要 一 边 同 莫 抵 运 作 战 ， 一 边 进 行 人 民 民 主 革 命 ， 在 严 峻 的 环 境 下 建 设 国 家 ； 对 抵 运 而 言 ， 这 是 莫 解 阵 对 全 国 控 制 相 对 薄 弱 的 时 期 。||作 为 我 们 支 援 非 洲 反 帝 反 殖 的 一 个 重 要 节 点 ， 我 们 自 然 应 当 帮 老 朋 友 莫 解 阵 解 决 掉 莫 抵 运 这 个 麻 烦 ； 不 过 ， 为 了 保 住 我 们 在 非 洲 的 利 益 ， 我 们 或 许 应 该 尝 试 两 头 下 注 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 3)
		{
			button_text[0] = " 我 们 将 继 续 援 助 莫 桑 比 克 解 放 阵 线 党 ， 一 直 打 到 完 全 胜 利 为 止 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 抓 到 老 鼠 就 是 好 猫";
		}
		if (a.data[56] > 1 && a.empires[0].relations >= 600)
		{
			button_text[1] = " 秘 密 给 抵 运 打 钱";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 绝 不 支 持 种 族 主 义 者 和 莫 桑 比 克 革 命 的 叛 徒 ！";
		}
		button_text[2] = " 尝 试 置 身 事 外";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "从 鲁 乌 马 到 马 普 托";
		a.allcountries[126].level_of_unstab = 700;
		a.allcountries[126].parts[0] = true;
		if (result_num == 0)
		{
			text = "我 们 为 莫 桑 比 克 政 府 继 续 提 供 武 器 和 经 济 等 援 助 ， 以 帮 助 老 朋 友 渡 过 困 难 时 期 。 莫 解 阵 在 建 设 莫 桑 比 克 人 民 解 放 军 和 民 兵 的 同 时 ， 开 始 逐 步 进 行 国 有 化 和 建 立 公 社 村 、 建 设 行 政 机 构 和 党 组 织 、 发 展 教 育 和 医 疗 卫 生 。 与 此 同 时 ， 在 南 非 和 罗 德 西 亚 的 袭 扰 下 ， 莫 解 阵 和 莫 抵 运 之 间 漫 长 的 低 烈 度 战 争 也 开 始 了 。";
			a.allcountries[126].level_of_unstab += 20;
			a.data[22] -= 80;
			a.data[8] -= 100;
		}
		if (result_num == 1)
		{
			text = "在 声 援 莫 解 阵 反 帝 斗 争 的 同 时 ， 我 们 利 用 和 美 国 的 关 系 ， 将 部 分 援 助 送 到 了 莫 抵 运 手 里 （ 当 然 ， 并 没 有 援 助 中 械 ） 。 莫 解 阵 在 建 设 莫 桑 比 克 人 民 解 放 军 和 民 兵 的 同 时 ， 开 始 逐 步 进 行 国 有 化 和 建 立 公 社 村 、 建 设 行 政 机 构 和 党 组 织 、 发 展 教 育 和 医 疗 卫 生 。 与 此 同 时 ， 在 南 非 和 罗 德 西 亚 的 袭 扰 下 ， 莫 解 阵 和 莫 抵 运 之 间 漫 长 的 低 烈 度 战 争 也 开 始 了 。";
			a.allcountries[126].level_of_unstab -= 20;
			a.data[22] -= 100;
			a.data[9] -= 50;
		}
		if (result_num == 2)
		{
			text = "我 们 没 有 做 出 太 多 的 表 示 。 莫 解 阵 在 建 设 莫 桑 比 克 人 民 解 放 军 和 民 兵 的 同 时 ， 开 始 逐 步 进 行 国 有 化 和 建 立 公 社 村 、 建 设 行 政 机 构 和 党 组 织 、 发 展 教 育 和 医 疗 卫 生 。 与 此 同 时 ， 在 南 非 和 罗 德 西 亚 的 袭 扰 下 ， 莫 解 阵 和 莫 抵 运 之 间 漫 长 的 低 烈 度 战 争 也 开 始 了 。";
		}
	}
}
