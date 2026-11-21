using EventsForDLC;
using UnityEngine;

public class Event639 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "为 了 所 有 人 的 斐 济";
		text = "在 经 历 反 帝 反 殖 的 斗 争 后 ， 瓦 努 阿 图 人 民 最 终 赢 得 了 独 立 ， 开 始 了 美 拉 尼 西 亚 社 会 主 义 的 实 践 。 我 们 现 在 可 以 同 他 们 一 起 将 斗 争 扩 展 到 南 太 平 洋 的 其 他 国 家 。||斐 济 独 立 以 来 仍 然 同 英 国 保 持 着 密 切 联 系 ， 当 地 的 部 族 和 酋 长 也 继 续 保 留 着 他 们 的 特 权 ， 并 想 要 维 持 斐 济 族 在 岛 上 的 优 势 地 位 （ 斐 济 族 和 斐 济 印 度 裔 是 该 国 的 两 大 民 族 ， 一 直 存 在 矛 盾 ） 。 我 们 可 以 通 过 支 持 大 多 数 由 印 度 裔 斐 济 人 参 加 的 中 左 翼 政 党 全 国 联 邦 党 （ 该 党 声 称 代 表 所 有 岛 民 ） 同 支 持 多 种 族 平 等 和 工 人 阶 级 利 益 的 斐 济 工 会 大 会 组 成 联 盟 ， 展 开 斗 争 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = "让 我 们 看 看 吧 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "为 了 所 有 人 的 斐 济";
		a.allcountries[123].prcpower = 600;
		a.allcountries[123].sovpower = 300;
		a.allcountries[123].usapower = 100;
		if (result_num != 0)
		{
			return;
		}
		if ((a.IsSocialism(yes: true, 159) || a.allcountries[159].Gosstroy == 2) && a.allcountries[154].puppetOf < 0 && (a.IsSocialism(yes: true, 135) || a.allcountries[135].Gosstroy == 2) && a.allcountries[135].SubGosstroy != 8)
		{
			text = "社 会 主 义 在 大 洋 洲 的 成 功 也 动 摇 着 斐 济 这 个 国 家 。 斐 济 工 会 大 会 发 起 了 总 罢 工 ， 并 在 瓦 努 阿 图 的 支 持 下 开 始 组 织 工 人 民 兵 ， 全 国 联 邦 党 也 开 始 动 员 议 员 对 执 政 的 联 盟 党 政 府 提 出 不 信 任 案 。 在 国 内 外 的 广 泛 压 力 下 ， 联 盟 党 内 阁 最 后 选 择 辞 职 ， 全 国 联 邦 党 - 斐 济 工 会 大 会 达 成 了 组 成 统 一 的 “ 人 民 民 主 党 ” 的 协 议 ， 组 织 了 新 政 府 。 新 政 府 随 即 颁 布 了 一 系 列 新 政 ： 部 分 引 入 直 接 民 主 、 改 革 威 斯 敏 斯 特 体 制 、 尝 试 推 行 工 人 自 治 、 开 展 国 有 化 和 土 地 改 革 以 及 废 除 酋 长 特 权 并 吸 收 了 一 定 美 拉 尼 西 亚 社 会 主 义 的 经 验 。 在 外 交 上 ， 斐 济 采 取 了 反 对 帝 国 主 义 、 殖 民 主 义 和 在 太 平 洋 国 家 进 行 核 试 验 的 政 策 ， 宣 布 同 英 国 和 英 联 邦 脱 钩 ， 一 个 共 和 制 的 斐 济 就 这 样 诞 生 了 。 ";
			a.allcountries[160].LeaveAlliances();
			a.allcountries[160].proprc = true;
			a.allcountries[160].Torg = true;
			if (a.IsSocialism(yes: true, 135) && a.IsSocialism(yes: true, 159) && a.IsSocialism(yes: true, 136))
			{
				a.allcountries[160].Gosstroy = 1;
				a.allcountries[160].SubGosstroy = 1;
				a.allcountries[160].name = "斐 济 民 主 共 和 国";
			}
			else
			{
				a.allcountries[160].Gosstroy = 2;
				a.allcountries[160].SubGosstroy = 3;
				a.allcountries[160].name = "斐 济 共 和 国";
			}
		}
		else
		{
			text = "斐 济 工 会 大 会 和 全 国 联 邦 党 的 行 动 虽 然 成 功 动 摇 了 斐 济 的 政 治 秩 序 ， 但 这 一 行 动 给 斐 济 族 的 特 权 人 士 带 来 了 恐 慌 。 在 西 蒂 维 尼 · 拉 布 卡 将 军 的 指 挥 下 ， 1 0 名 蒙 面 武 装 的 士 兵 进 入 了 斐 济 众 议 院 ， 将 所 有 议 员 赶 出 了 议 院 。 随 后 ， 斐 济 广 播 电 台 宣 布 军 方 接 管 了 政 权 。 在 军 方 和 斐 济 族 酋 长 的 压 力 下 ， 斐 济 总 督 追 认 了 政 变 的 正 当 性 ， 并 授 权 拉 布 卡 将 军 组 建 一 个 看 守 政 府 。 新 政 府 随 后 镇 压 了 全 国 联 邦 党 和 斐 济 工 会 大 会 ， 并 颁 布 了 一 部 新 宪 法 ， 其 中 肯 定 了 斐 济 族 在 政 治 上 的 霸 权 ， 并 宣 布 斐 济 为 共 和 国 。";
			a.allcountries[160].Gosstroy = 0;
			a.allcountries[160].SubGosstroy = 7;
			a.allcountries[160].name = "斐 济 主 权 民 主 共 和 国";
		}
	}
}
