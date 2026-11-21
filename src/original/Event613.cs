using EventsForDLC;
using UnityEngine;

public class Event613 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "黑 暗 大 陆 的 自 由 斗 士";
		text = "蒙 博 托 也 许 不 会 预 料 到 ， 自 己 最 亲 昵 的 战 友 会 背 叛 自 己 。 艾 迪 安 · 奇 塞 克 蒂 作 为 蒙 博 托 长 久 以 来 的 战 友 和 忠 实 拥 蹩 ， 在 被 蒙 博 托 因 为 政 治 洗 牌 中 踢 出 了 中 央 后 竟 然 自 立 山 头 。 他 组 建 了 民 主 与 社 会 进 步 联 盟 ， 这 是 扎 伊 尔 国 内 最 大 ， 也 是 唯 一 的 一 个 反 对 派 组 织 。 主 席 同 志 ， 扎 伊 尔 的 领 袖 越 发 变 得 偏 执 而 又 狂 热 ， 也 许 我 们 及 时 的 跳 船 是 更 好 的 选 择 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[56] >= 3)
		{
			button_text[0] = " 为 该 组 织 提 供 保 障";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 在 乎 这 些 费 拉 不 堪 的 自 由 派";
		}
		button_text[1] = " 维 持 现 状 最 好";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "黑 暗 大 陆 的 自 由 斗 士";
		if (result_num == 0)
		{
			text = " 扎 伊 尔 军 队 在 数 次 对 外 战 争 中 的 灾 难 性 战 果 导 致 蒙 博 托 的 名 声 江 河 日 下 ， M R P 内 部 也 因 此 出 现 了 分 裂 ， 财 政 赤 字 与 外 债 急 剧 飙 升 ， 罢 工 游 行 接 连 不 断 ， 加 丹 加 和 基 伍 省 的 叛 乱 层 出 不 穷 ， 为 此 ， 政 府 不 得 不 出 台 紧 急 措 施 增 收 节 支 ， 然 而 这 也 只 是 杯 水 车 薪 ， 随 着 货 币 贬 值 ， 进 口 商 品 和 生 活 必 需 品 价 格 的 大 幅 上 涨 ， 人 民 怨 声 载 道 。 在 这 种 情 况 下 ， 反 对 派 的 声 望 水 涨 船 高 ， 其 中 更 少 不 了 我 们 的 “ 改 革 换 援 助 计 划 ” 大 获 成 功 。 为 了 保 证 国 家 不 至 于 崩 溃 ， 以 及 我 们 驻 扎 在 扎 伊 尔 的 多 支 武 装 团 体 和 工 作 队 的 压 力 下 ， 蒙 博 托 事 实 上 向 我 们 低 头 了 。 他 接 纳 了 这 一 支 反 对 派 作 为 御 用 狗 哨 。||蒙 博 托 迟 早 会 滚 蛋 ， 只 不 过 不 是 现 在 … …";
			a.allcountries[117].Gosstroy = 2;
			a.allcountries[117].SubGosstroy = 8;
			GlobalScript.inst.gameState.allcountries[117].level_of_dev = 0;
			a.empires[1].relations -= 50;
			a.empires[0].relations += 50;
			a.empires[0].power += 10;
			a.influencePRC += 10;
			a.data[4] -= 20;
			a.data[9] -= 20;
			a.data[8] -= 20;
		}
		if (result_num == 1)
		{
			text = " 蒙 博 托 能 稳 坐 钓 鱼 台 自 有 他 的 艺 术 ， 我 们 只 需 要 顺 其 自 然 即 可 。||不 出 意 外 ， 蒙 博 托 又 一 次 网 罗 了 罪 名 ， 把 这 位 黑 暗 大 陆 的 自 由 斗 士 投 入 了 大 牢 之 中 。";
		}
	}
}
