using EventsForDLC;
using UnityEngine;

public class Event627 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 伊 斯 兰 、 民 族 、 宪 政 和 社 会 主 义 民 主 ！";
		text = "1975 年 ， 达 达 赫 在 毛 里 塔 尼 亚 人 民 党 全 国 代 表 大 会 上 公 布 了 深 受 欢 迎 的 新 党 章 ， 其 中 提 出 了 “ 伊 斯 兰 、 民 族 、 宪 政 和 社 会 主 义 民 主 ” 的 口 号 。 尽 管 多 年 以 来 ， 人 民 党 政 府 实 施 了 许 多 带 有 反 殖 反 帝 和 “ 社 会 主 义 ” 色 彩 的 政 策 ， 但 是 由 于 该 国 部 族 主 义 猖 獗 和 奴 隶 制 广 泛 存 在 的 社 会 情 况 以 及 其 落 后 的 经 济 情 况 ， 该 国 的 “ 伊 斯 兰 社 会 主 义 ” 实 践 并 不 见 得 有 多 么 深 入 基 层 。 如 今 ， 在 非 洲 革 命 高 歌 猛 进 的 情 况 下 ， 非 洲 革 命 联 盟 决 定 帮 助 毛 塔 推 进 国 家 的 变 革 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 西 非 人 民 大 团 结 万 岁 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 伊 斯 兰 、 民 族 、 宪 政 和 社 会 主 义 民 主 ！";
		if (result_num == 0)
		{
			text = "在 西 非 各 人 民 民 主 的 泛 非 政 权 和 非 洲 革 命 联 盟 的 支 持 及 我 们 的 压 力 下 ， 达 达 赫 开 始 着 手 改 组 毛 里 塔 尼 亚 人 民 党 — — 在 剔 除 党 内 右 派 和 保 守 势 力 后 ， 人 民 党 同 毛 里 塔 尼 亚 劳 动 党 和 进 步 工 人 联 盟 等 左 翼 力 量 合 并 为 毛 里 塔 尼 亚 劳 动 人 民 党 ， 新 的 党 章 中 写 入 了 科 学 社 会 主 义 和 泛 非 主 义 的 内 容 ， 并 保 留 了 来 自 劳 动 党 的 部 分 涉 及 马 列 主 义 和 毛 泽 东 思 想 的 词 条 。 来 自 劳 动 党 的 易 卜 拉 希 马 · 莫 克 塔 尔 · 萨 尔 当 选 为 总 书 记 ， 莫 克 塔 尔 · 乌 尔 德 · 达 达 赫 当 选 为 党 主 席 。||改 组 后 的 执 政 党 和 政 府 开 始 在 非 洲 革 命 联 盟 的 帮 助 下 对 奴 隶 制 和 部 族 主 义 政 治 进 行 改 革 ， 并 动 员 激 进 的 学 生 和 工 人 参 与 政 治 ， 以 对 社 会 上 的 保 守 势 力 进 行 打 击 。 在 经 济 上 ， 毛 塔 政 府 决 定 对 外 资 （ 特 别 是 来 自 法 国 的 ） 进 行 国 有 化 ， 并 开 展 土 地 改 革 和 农 业 合 作 化 试 点 。 在 非 革 盟 的 积 极 运 作 下 ， 毛 塔 和 萨 赫 勒 各 国 也 开 始 组 织 萨 赫 勒 荒 漠 化 共 同 对 策 委 员 会 ， 来 改 善 萨 赫 勒 地 区 的 环 境 。 非 革 盟 和 我 们 的 援 助 在 进 入 这 个 国 家 ， 助 力 其 工 业 化 和 社 会 改 造 。 属 于 毛 塔 的 摩 尔 人 和 黑 人 的 将 是 平 等 而 美 好 的 未 来 ！";
			a.allcountries[59].Gosstroy = 1;
			a.allcountries[59].SubGosstroy = 1;
			a.allcountries[59].LeaveAlliances();
			a.allcountries[59].Torg = true;
			a.allcountries[59].proprc = true;
			a.allcountries[59].name = "毛 里 塔 尼 亚 民 主 共 和 国";
			a.influencePRC += 20;
			a.empires[0].relations -= 50;
			a.empires[0].relations -= 50;
			a.empires[0].power -= 20;
		}
	}
}
