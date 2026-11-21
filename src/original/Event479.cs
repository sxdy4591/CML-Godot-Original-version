using EventsForDLC;
using UnityEngine;

public class Event479 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 葡 萄 牙 1 9 8 3 年 议 会 选 举";
		text = " 葡 萄 牙 上 一 次 议 会 选 举 于 1 9 8 0 年 1 0 月 5 日 举 行 ， <color=blue>弗 朗 西 斯 科 · 萨 · 卡 内 罗</color> 领 导 的 <color=blue>民 主 联 盟</color> 获 胜 。 然 而 ， 1 9 8 0 年 1 2 月 ， <color=blue>萨 · 卡 内 罗</color> 和 <color=blue>阿 马 罗 · 达 科 斯 塔</color> （ 国 防 部 长 ） 在 卡 马 拉 特 的 一 次 悲 惨 事 故 中 丧 生 。 政 府 两 位 最 大 人 物 的 死 亡 将 影 响 执 政 联 盟 的 凝 聚 力 。 <color=blue>弗 朗 西 斯 科 · 平 托 · 巴 尔 塞 芒</color> 于 1 9 8 1 年 1 月 被 任 命 为 总 理 ， 但 他 从 未 成 为 两 党 认 可 的 领 导 人 ， 而 是 引 起 了 执 政 联 盟 内 部 的 强 烈 反 对 ， 这 导 致 了 政 府 中 几 位 部 长 的 辞 职 。 此 外 ， <color=blue>巴 尔 塞 芒</color> 所 遵 循 的 右 翼 政 策 受 到 反 对 党 的 强 烈 反 对 ， 特 别 是 <color=red>葡 共</color> 。 1 9 8 2 年 2 月 ， 由 C G T P （ 隶 属 于 <color=red>共 产 党</color> 的 工 会 ） 召 集 的 总 罢 工 彻 底 动 摇 了 政 府 ， 部 长 们 纷 纷 辞 职 。 直 到 1 9 8 2 年 1 2 月 ， 在 当 年 的 市 政 选 举 之 后 ， <color=blue>平 托 · 巴 尔 塞 芒</color> 本 人 提 交 了 总 理 辞 呈 — — <color=blue>民 主 联 盟</color> 走 向 了 分 崩 离 析 。 1 9 8 3   年 1 月 ， <color=blue>安 东 尼 奥 · 拉 马 尔 霍 · 埃 内 亚 斯</color> 总 统 在 拒 绝 由 <color=blue>民 主 联 盟</color> 重 新 组 阁 后 决 定 提 前 举 行 选 举 。 根 据 我 们 的 分 析 ， 右 翼 很 可 能 会 在 这 次 议 会 选 举 受 挫 ， 而 以 <color=green>社 会 党</color> 和 <color=red>联 合 人 民 联 盟</color> （ <color=red>共 产 党</color> 领 导 的 政 党 联 盟 ） 为 代 表 的 左 翼 势 力 有 望 获 得 大 量 选 票 。 但 是 ， 考 虑 到 中 间 派 的 <color=blue>社 会 民 主 党</color> 仍 具 有 较 大 力 量 ， 以 及 <color=green>社 会 党</color> “ 把 社 会 主 义 放 到 抽 屉 里 “ 的 政 策 ， 建 立 一 个 左 翼 政 府 仍 然 存 在 障 碍 。 主 席 同 志 ， 我 们 是 否 要 干 预 葡 萄 牙 的 这 场 大 选 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[8] + a.data[36] >= 50 && a.data[9] >= 50)
		{
			button_text[0] = " 为 <color=red>共 产 党</color> 送 上 竞 选 资 金 并 挑 拨 <color=green>社 会 党</color> 与 <color=blue>社 会 民 主 党</color> 的 关 系 ";
		}
		else if (a.data[8] + a.data[36] <= 50)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 绝 对 没 有 那 么 多 钱";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 那 个 精 力";
		}
		button_text[1] = " 我 们 为 什 么 要 陪 他 们 玩 选 举 游 戏 ？ ";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 葡 萄 牙 1 9 8 3 年 议 会 选 举";
		if (result_num == 0)
		{
			text = " 选 举 结 果 公 布 了 。 <color=green>社 会 党</color> 获 得 了 3 8 % 的 选 票 ， 获 得 了 相 对 多 数 。 由 <color=red>共 产 党</color> 领 导 的 <color=red>联 合 人 民 联 盟</color> 获 得 了 2 0 % 的 选 票 。 <color=blue>民 主 联 盟</color> 解 散 后 ， 其 中 各 党 单 独 参 选 。 <color=blue>社 民 党</color> 获 得 了 2 6 % 的 选 票 。 而 <color=blue>人 民 党</color> 获 得 了 1 3 % 的 选 票 ， 取 得 了 糟 糕 的 成 绩 。 <color=green>社 会 党</color> 起 初 想 与 <color=blue>社 民 党</color> 组 成 “ 中 央 集 团 “ ， 但 由 于 政 见 差 别 较 大 和 两 党 的 几 位 知 名 人 士 特 别 是 <color=blue>社 民 党</color> 的 强 烈 反 对 ， <color=green>社 会 党</color> 最 终 被 迫 选 择 与 <color=red>联 合 人 民 联 盟</color> 组 成 社 会 主 义 联 合 政 府 。 新 政 府 将 继 续 进 行 康 乃 馨 革 命 后 宪 法 规 定 的 社 会 主 义 的 改 革 。 ";
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[87].Gosstroy = 2;
			a.allcountries[87].SubGosstroy = 3;
			a.allcountries[87].Vyshi = false;
		}
		if (result_num == 1)
		{
			text = " 选 举 结 果 公 布 了 。 <color=green>社 会 党</color> 获 得 了 3 6 . 1 % 的 选 票 ， 获 得 了 相 对 多 数 。 由 <color=red>共 产 党</color> 领 导 的 <color=red>联 合 人 民 联 盟</color> 获 得 了 1 8 . 1 % 的 选 票 。 <color=blue>民 主 联 盟</color> 解 散 后 ， 其 中 各 党 单 独 参 选 。 <color=blue>社 民 党</color> 获 得 了 2 7 . 2 % 的 选 票 。 而 <color=blue>人 民 党</color> 获 得 了 1 2 . 6 % 的 选 票 ， 取 得 了 糟 糕 的 成 绩 。 选 举 标 志 着 <color=green>社 会 党</color> 和 <color=blue>社 民 党</color> 之 间 的 国 家 政 治 两 极 分 化 的 开 始 。 在 没 有 明 显 多 数 的 情 况 下 ， <color=green>社 会 党</color> 领 袖 <color=green>马 里 奥 · 苏 亚 雷 斯</color> 决 定 与 <color=blue>社 民 党</color> 组 建 政 府 ， 这 个 联 盟 后 来 被 称 为 “ 中 央 集 团 “ 。 联 盟 的 两 党 内 部 对 这 一 执 政 联 盟 都 不 是 很 满 意 ， 这 样 的 新 政 府 能 够 维 持 多 久 呢 ？";
			a.allcountries[87].Gosstroy = 3;
			a.allcountries[87].SubGosstroy = 5;
		}
	}
}
