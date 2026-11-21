using EventsForDLC;
using UnityEngine;

public class Event567 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 自 由 的 热 风";
		text = " 佐 法 尔 解 放 阵 线 成 立 于1962年 ， 是 一 个 包 含 阿 拉 伯 社 会 主 义 者 、 佐 法 尔 分 离 主 义 者 、 民 主 主 义 者 、 共 和 派 甚 至 是 保 守 的 部 落 首 领 的 反 对 派 大 帐 篷 ， 其 目 标 是 佐 法 尔 独 立 以 及 促 进 阿 拉 伯 民 族 统 一 。 1963年6月9日 ， 佐 解 阵 的 “ 六 · 九 革 命 ” 拉 开 了 斗 争 的 序 幕 。||1967年 ， 佐 解 阵 受 挫 后 ， 席 卷 世 界 的 左 翼 浪 潮 以 及 南 也 门 独 立 和 “ 解 放 巴 勒 斯 坦 人 民 阵 线 ” （ 人 阵 ） 的 成 立 深 刻 地 影 响 了 佐 解 阵 ， 在1968年 的 佐 解 阵 二 大 上 ， 佐 解 阵 被 改 组 为 奉 行 马 克 思 列 宁 主 义 和 毛 泽 东 思 想 的 “ 解 放 被 占 领 的 阿 拉 伯 湾 人 民 阵 线 ” （ 后 来 与 阿 湾 民 阵 合 并 为 “ 解 放 阿 曼 和 阿 拉 伯 湾 人 民 阵 线 ” ， 皆 简 称 阿 湾 人 阵 ） ， 其 目 标 也 转 向 解 放 包 含 阿 曼 、 阿 联 酋 、 卡 塔 尔 和 巴 林 在 内 的 整 个 阿 拉 伯 湾 ， 并 在 苏 联 和 中 国 的 支 持 下 展 开 斗 争 。 随 着 苏 联 对 阿 湾 人 阵 的 全 方 位 援 助 以 及 大 力 干 预 ， 阵 线 内 的 亲 苏 派 逐 渐 压 倒 了 亲 华 派 ， 毛 泽 东 思 想 被 放 弃 了 。||不 久 后 ， 阿 湾 人 阵 的 群 众 基 础 逐 渐 陷 入 崩 溃 。 阿 湾 人 阵 在 内 部 叛 乱 的 影 响 和 封 建 买 办 与 帝 国 主 义 的 联 合 绞 杀 下 逐 渐 陷 入 失 败 。1974年 ， 阿 湾 人 阵 重 组 为 解 放 阿 曼 人 民 阵 线 和 解 放 巴 林 人 民 阵 线 两 个 组 织 ， 规 模 显 著 缩 小 。1975年 ， 阿 曼 人 阵 的 所 有 根 据 地 沦 陷 。1976年1月 ， 阿 曼 人 阵 撤 入 南 也 门 ， 只 有 部 分 游 击 小 组 留 在 阿 曼 ， 在 南 也 门 的 支 持 下 继 续 开 展 小 规 模 的 游 击 斗 争 。||如 今 ， 也 门 进 入 了 我 们 的 阵 营 ， 并 已 实 现 完 全 统 一 ， 我 们 是 否 要 在 阿 曼 人 阵 和 巴 林 人 阵 的 基 础 上 重 建 阿 湾 人 阵 ， 重 新 塑 造 他 们 的 意 识 形 态 并 帮 助 阿 拉 伯 湾 的 人 民 再 次 开 展 他 们 的 斗 争 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[56] <= 2 && (a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0))
		{
			button_text[0] = " 让 我 们 支 持 阿 拉 伯 湾 人 民 对 封 建 买 办 势 力 的 斗 争 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 还 能 以 社 会 主 义 者 自 居 吗 ？";
		}
		button_text[1] = " 还 得 再 等 等 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 自 由 的 热 风";
		if (result_num == 0)
		{
			if (a.allcountries[24].parts[0])
			{
				text = " 在 我 们 外 交 人 员 的 努 力 下 ， 我 们 联 系 到 阿 曼 人 阵 和 巴 林 人 阵 ， 在 也 门 开 展 了 一 场 谈 判 ， 谈 判 最 终 决 定 ， 阿 曼 人 阵 和 巴 林 人 阵 将 重 新 组 成 解 放 被 占 领 的 阿 拉 伯 湾 人 民 阵 线 。 在 一 场 新 的 特 别 代 表 大 会 上 ， 阿 湾 人 阵 宣 布 重 建 ， 而 马 克 思 列 宁 主 义";
				a.allcountries[24].cw = true;
				if (a.allcountries[24].proprc)
				{
					text += " 和 毛 泽 东 思 想";
				}
				text += " 重 新 成 为 了 阵 线 的 指 导 思 想 ， 留 在 阿 曼 的 游 击 小 组 也 被 改 组 为 “ 阿 拉 伯 湾 人 民 解 放 军 ” 。 战 斗 仍 将 继 续 ！…";
			}
			else
			{
				a.allcountries[23].cw = true;
				text = " 在 我 们 外 交 人 员 的 努 力 下 ， 也 门 、 埃 及 和 利 比 亚 同 意 继 续 为 阿 拉 伯 湾 人 民 提 供 支 持 。 我 们 联 系 到 阿 曼 人 阵 和 巴 林 人 阵 ， 在 也 门 开 展 了 一 场 谈 判 ， 谈 判 最 终 决 定 ， 阿 曼 人 阵 和 巴 林 人 阵 将 重 新 组 成 解 放 阿 曼 和 阿 拉 伯 湾 人 民 阵 线 。 在 一 场 新 的 特 别 代 表 大 会 上 ， 阿 湾 人 阵 宣 布 重 建 ， 并 在 也 门 、 埃 及 和 利 比 亚 的 影 响 下 吸 收 了 过 去 阿 湾 人 阵 宣 扬 无 神 论 的 教 训 ， 对 伊 斯 兰 教 采 取 更 温 和 的 态 度 ， 将 阿 拉 伯 社 会 主 义 和 泛 阿 拉 伯 主 义 列 为 指 导 思 想 。 留 在 阿 曼 的 游 击 小 组 也 被 改 组 为 “ 阿 拉 伯 湾 人 民 解 放 军 ” 。 战 斗 仍 将 继 续 ！";
			}
			a.allcountries[24].prcpower = 50;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
		}
		if (result_num == 1)
		{
			text = " 重 建 阿 湾 人 阵 意 味 着 在 阿 拉 伯 湾 掀 起 与 英 美 帝 国 主 义 的 对 抗 ， 我 们 还 没 有 准 备 好 … …";
			a.event_done[567] = false;
		}
	}
}
