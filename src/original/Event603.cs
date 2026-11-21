using EventsForDLC;
using UnityEngine;

public class Event603 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 总 统 大 选 ： 彩 虹 之 国";
		text = " 德 克 勒 克 政 府 的 改 革 在 1 9 8 5 年 内 便 驶 入 快 车 道 ： 也 就 在 宣 布 对 种 族 隔 离 制 度 进 行 改 革 的 四 个 月 后 ， 南 非 便 废 除 人 口 登 记 法 、 原 住 民 土 地 法 等 法 规 ， 在 法 律 上 彻 底 废 除 了 种 族 隔 离 。 上 述 功 绩 足 以 促 使 其 与 曼 德 拉 分 享 今 年 的 诺 贝 尔 和 平 奖 。 接 下 来 ， 就 让 我 们 静 待 南 非 历 史 上 首 次 不 分 种 族 的 公 平 大 选 及 其 结 果 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 静 待 选 举 结 果 … …";
		button_text[1] = " 我 们 应 支 持 非 国 大 和 曼 德 拉 ！ 实 现 南 非 的 历 史 转 型 ！ ";
		button_text[2] = " 我 们 应 支 持 德 克 勒 克 ！ 他 已 用 改 革 证 明 了 自 身 素 质 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 总 统 大 选 ： 彩 虹 之 国";
		a.allcountries[131].name = "南 非 共 和 国";
		if (result_num == 0)
		{
			text = " 为 期 四 天 的 大 选 热 闹 非 凡 ， 有 数 百 万 人 排 队 投 票 ， 而 结 果 正 如 普 遍 预 期 ： 非 洲 人 国 民 大 会 、 南 非 工 会 大 会 及 南 非 共 产 党 的 三 方 联 盟 赢 得 全 面 胜 利 。 新 国 民 议 会 推 选 非 洲 人 国 民 大 会 领 导 人 纳 尔 逊 · 曼 德 拉 为 总 统 ， 黑 人 为 主 的 国 家 也 终 于 有 了 自 己 的 黑 人 领 袖 。||崭 新 的 时 代 就 此 到 来 … …||||“ 年 月 把 拥 有 变 做 失 去 ， 疲 倦 的 双 眼 带 着 期 望 — — 今 天 只 有 残 留 的 躯 壳 ， 迎 接 光 辉 岁 月 ， 风 雨 中 抱 紧 自 由 ！ ” — — 黄 家 驹 《 光 辉 岁 月 》 ";
			if (a.empires[1].power > a.empires[0].power)
			{
				a.allcountries[131].Gosstroy = 2;
				a.allcountries[131].SubGosstroy = 3;
				a.allcountries[131].prosov = true;
			}
			else
			{
				a.allcountries[131].Gosstroy = 3;
				a.allcountries[131].SubGosstroy = 4;
			}
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].puppetOf == 131)
				{
					a.allcountries[i].puppetOf = -1;
				}
			}
		}
		if (result_num == 1)
		{
			text = " 为 期 四 天 的 大 选 热 闹 非 凡 ， 有 数 百 万 人 排 队 投 票 ， 而 结 果 正 如 普 遍 预 期 ： 非 洲 人 国 民 大 会 、 南 非 工 会 大 会 及 南 非 共 产 党 的 三 方 联 盟 赢 得 全 面 胜 利 。 新 国 民 议 会 推 选 非 洲 人 国 民 大 会 领 导 人 纳 尔 逊 · 曼 德 拉 为 总 统 ， 黑 人 为 主 的 国 家 也 终 于 有 了 自 己 的 黑 人 领 袖 。||崭 新 的 时 代 就 此 到 来 … …||||“ 年 月 把 拥 有 变 做 失 去 ， 疲 倦 的 双 眼 带 着 期 望 — — 今 天 只 有 残 留 的 躯 壳 ， 迎 接 光 辉 岁 月 ， 风 雨 中 抱 紧 自 由 ！ ” — — 黄 家 驹 《 光 辉 岁 月 》";
			if (a.influencePRC + a.empires[1].power > a.empires[0].power)
			{
				a.allcountries[131].Gosstroy = 2;
				a.allcountries[131].SubGosstroy = 3;
				a.allcountries[131].proprc = true;
			}
			else
			{
				a.allcountries[131].Gosstroy = 3;
				a.allcountries[131].SubGosstroy = 4;
				a.allcountries[131].proprc = true;
			}
			a.allcountries[131].Torg = true;
			a.data[9] -= 50;
			a.data[8] -= 100;
			a.empires[0].relations -= 150;
			for (int j = 0; j < a.allcountries.Length; j++)
			{
				if (a.allcountries[j].puppetOf == 131)
				{
					a.allcountries[j].puppetOf = -1;
				}
			}
		}
		if (result_num != 2)
		{
			return;
		}
		a.data[9] -= 100;
		a.data[8] -= 100;
		for (int k = 0; k < a.allcountries.Length; k++)
		{
			if (a.allcountries[k].puppetOf == 131)
			{
				a.allcountries[k].puppetOf = -1;
			}
		}
		if (a.influencePRC > 700)
		{
			text = " 为 期 四 天 的 大 选 热 闹 非 凡 ， 有 数 百 万 人 排 队 投 票 ， 而 结 果 却 出 人 意 料 ： 由 于 阿 扎 尼 亚 泛 非 主 义 大 会 等 激 进 左 翼 组 织 的 参 选 分 化 了 黑 人 选 民 ， 导 致 非 国 大 选 票 分 流 。 德 克 勒 克 、 因 卡 蒂 自 由 党 和 独 立 候 选 人 的 保 守 联 盟 由 此 险 胜 非 国 大 取 得 胜 利 ！ 尽 管 如 此 ， 德 克 勒 克 依 然 出 于 “ 稳 定 转 型 需 要 ” ， 将 曼 德 拉 及 非 国 大 温 和 派 纳 入 到 民 族 团 结 政 府 中 。 美 国 对 选 举 结 果 表 示 热 烈 祝 贺 ， 看 起 来 南 非 终 于 可 以 翻 过 种 族 隔 离 的 篇 章 ， 成 为 自 由 世 界 在 非 洲 最 大 最 亮 的 钻 石 … …";
			if (a.influencePRC > a.empires[0].power)
			{
				a.allcountries[131].Gosstroy = 3;
				a.allcountries[131].SubGosstroy = 5;
				a.allcountries[131].proprc = true;
				a.allcountries[131].Torg = true;
			}
			else
			{
				a.allcountries[131].Gosstroy = 3;
				a.allcountries[131].SubGosstroy = 5;
				a.allcountries[131].Vyshi = true;
				a.allcountries[131].Torg = true;
			}
		}
		else
		{
			text = " 为 期 四 天 的 大 选 热 闹 非 凡 ， 有 数 百 万 人 排 队 投 票 ， 而 结 果 正 如 普 遍 预 期 ： 非 洲 人 国 民 大 会 、 南 非 工 会 大 会 及 南 非 共 产 党 的 三 方 联 盟 赢 得 全 面 胜 利 。 新 国 民 议 会 推 选 非 洲 人 国 民 大 会 领 导 人 纳 尔 逊 · 曼 德 拉 为 总 统 ， 黑 人 为 主 的 国 家 也 终 于 有 了 自 己 的 黑 人 领 袖 。||崭 新 的 时 代 就 此 到 来 … …||||“ 年 月 把 拥 有 变 做 失 去 ， 疲 倦 的 双 眼 带 着 期 望 — — 今 天 只 有 残 留 的 躯 壳 ， 迎 接 光 辉 岁 月 ， 风 雨 中 抱 紧 自 由 ！ ” — — 黄 家 驹 《 光 辉 岁 月 》";
		}
	}
}
