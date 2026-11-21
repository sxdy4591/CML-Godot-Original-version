using EventsForDLC;
using UnityEngine;

public class Event480 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 葡 萄 牙 1 9 8 5 年 议 会 选 举";
		text = "  <color=green>社 会 党</color> 和 <color=blue>社 民 党</color> 的 “ 中 央 集 团 “ 终 于 解 体 了 。 两 党 在 此 前 就 已 多 次 产 生 分 歧 ， 最 后 ， 因 为 <color=blue>社 民 党</color> 主 席 <color=blue>卡 洛 斯 · 莫 塔 · 平 托</color> 在 1 9 8 6 年 总 统 选 举 候 选 人 问 题 上 同 联 盟 内 大 部 分 人 都 有 分 歧 ， 他 最 终 被 迫 辞 职 。 <color=blue>社 民 党</color> 代 表 大 会 任 命 前 财 政 部 长 <color=blue>阿 尼 巴 尔 · 卡 瓦 科 · 席 尔 瓦</color> 取 代 了 他 的 职 位 ， 成 为 该 党 新 的 主 席 。 同 时 ， <color=green>苏 亚 雷 斯</color> 总 理 决 定 进 行 部 长 改 组 ， 由 <color=blue>鲁 伊 · 马 切 特</color> 接 替 平 托 担 任 国 防 部 长 和 副 总 理 的 职 位 。 由 于 <color=blue>社 民 党</color> 党 内 和 国 家 层 面 的 权 力 更 迭 ， 中 央 集 团 两 党 间 就 继 续 组 建 联 合 政 府 展 开 谈 判 。 在 谈 判 失 败 后 ， <color=blue>社 会 民 主 党</color> 的 部 长 们 于 6 月 1 3 日 向 共 和 国 总 统 提 交 了 辞 呈 。 1 2 天 后 ， <color=green>社 会 党</color> 因 为 没 能 获 得 议 会 关 于 组 建 少 数 派 政 府 的 信 任 ， <color=green>马 里 奥 · 苏 亚 雷 斯</color> 向 共 和 国 总 统 提 交 了 辞 呈 ， <color=blue>安 东 尼 奥 · 拉 马 尔 霍 · 埃 内 亚 斯</color> 总 统 宣 布 将 在 1 0 月 6 日 提 前 举 行 立 法 选 举 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 接 下 来 将 发 生 什 么 ？";
		button_text[1] = " 我 们 为 什 么 要 陪 他 们 玩 选 举 游 戏 ？ ";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 葡 萄 牙 1 9 8 5 年 议 会 选 举";
		if (result_num == 0)
		{
			text = " <color=blue>社 民 党</color> 在 此 次 选 举 取 得 了 历 史 性 的 胜 利 ， 它 获 得 了 2 9 . 9 % 的 选 票 和 8 8 个 席 位 ， 成 为 了 议 会 第 一 大 党 。 由 <color=green>阿 尔 梅 达 · 桑 托 斯</color> 领 导 的 <color=green>社 会 党</color> 则 在 全 国 选 举 中 取 得 了 有 史 以 来 最 差 的 成 绩 ， 它 获 得 了 2 0 . 8 % 的 选 票 ， 失 去 了 4 0 多 个 议 席 。 此 次 选 举 中 最 令 人 惊 讶 的 是 <color=green>民 主 复 兴 党</color> 的 崛 起 ， 该 党 与 埃 内 亚 斯 总 统 关 系 密 切 ， 得 益 于 民 众 对 现 有 政 党 的 幻 想 破 灭 ， 他 们 赢 得 了 1 8 % 的 选 票 和 4 5 个 席 位 。 <color=red>共 产 党</color> 领 导 的 <color=red>联 合 人 民 联 盟</color> 失 去 了 6 个 席 位 ， 获 得 了 1 5 . 5 % 的 选 票 。 人 民 党 获 得 了   2 2   个 议 席 和   1 0 % 的 选 票 。 <color=blue>社 民 党</color> 领 导 人 <color=blue>卡 瓦 科 · 席 尔 瓦</color> 成 为 了 新 的 总 理 ， 他 成 功 在 议 会 内 取 得 了 人 民 党 和 <color=green>民 主 复 兴 党</color> 的 支 持 ， 组 建 了 少 数 派 政 府 。 ";
			a.empires[0].power += 50;
		}
	}
}
