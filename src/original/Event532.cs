using EventsForDLC;
using UnityEngine;

public class Event532 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 大 海 航 行 靠 舵 手";
		text = " 长 期 以 来 ， 我 们 对 <color=#A52A2A>日 本 共 产 主 义 抵 抗 者 同 盟</color> 提 供 了 包 括 武 器 、 技 术 等 方 面 的 大 量 支 持 。 同 时 派 出 政 工 人 员 与 他 们 开 展 了 长 期 的 交 流 指 导 ， 一 方 面 是 解 决 内 部 派 系 林 立 彼 此 对 立 的 问 题 ， 另 一 方 面 也 要 让 他 们 真 正 了 解 了 马 克 思 、 恩 格 斯 和 列 宁 的 学 说 是 什 么 样 的 。 在 数 年 的 努 力 下 ， 他 们 已 经 十 分 团 结 并 不 断 深 入 日 工 劳 动 者 等 工 人 阶 级 现 场 和 农 村 地 区 ， 发 展 组 织 并 动 员 新 的 支 持 者 。||与 此 同 时 ， 我 们 在 帮 助 <color=red>革 命 左 翼</color> 重 夺 <color=red>日 本 共 产 党</color> 领 导 权 之 后 ， 该 党 也 充 分 发 挥 了 自 己 完 善 的 基 层 动 员 机 制 与 更 加 健 全 的 组 织 优 势 ， 积 极 宣 传 革 新 思 想 以 及 自 由 民 主 党 弊 病 。 而 在 总 评 等 传 统 左 翼 工 会 日 渐 僵 化 的 时 候 ， <color=red>共 产 党</color> 也 借 机 派 出 人 员 对 这 些 工 会 组 织 进 行 渗 透 ， 从 而 开 始 尝 试 夺 取 它 们 的 主 导 权 。||主 席 同 志 ， 现 在 已 经 到 了 关 键 的 时 刻 ， 为 了 日 本 能 飘 扬 起 红 旗 ， 我 们 必 须 尽 快 把 两 股 力 量 合 二 为 一 ， 并 给 予 他 们 更 多 的 支 持 ， 不 然 我 们 先 前 的 一 切 努 力 都 将 付 诸 东 流 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[56] < 2)
		{
			button_text[0] = " 全 力 帮 助 他 们 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 人 对 他 们 有 兴 趣";
		}
		button_text[1] = " 尝 试 说 服 他 们";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 大 海 航 行 靠 舵 手";
		if (result_num == 0)
		{
			text = " 我 们 迅 速 与 <color=red>日 本 共 产 党</color> 和 <color=#A52A2A>日 本 共 产 主 义 抵 抗 者 同 盟</color> 展 开 了 磋 商 。 尽 管 二 者 对 于 合 并 一 事 有 许 多 疑 虑 （ 特 别 是 后 者 内 部 此 时 仍 有 个 别 人 是 托 洛 茨 基 主 义 的 支 持 者 ） ， 但 我 们 还 是 耐 心 地 说 服 了 他 们 。 很 快 ， 两 个 组 织 的 中 央 委 员 展 开 了 磋 商 ， 在 我 们 的 影 响 下 ， 最 终 通 过 了 一 份 正 式 协 议 ： <color=#A52A2A>日 本 共 产 主 义 抵 抗 者 同 盟</color> 正 式 并 入 <color=red>日 本 共 产 党</color> ， 党 名 也 更 改 为 <color=red>日 本 革 命 共 产 党</color> ， 整 体 以 毛 主 义 作 为 指 导 思 想 。||两 股 强 劲 左 翼 力 量 成 功 合 二 为 一 ， 这 为 接 下 来 在 全 日 本 掀 起 进 一 步 的 革 命 斗 争 打 下 了 重 要 的 基 础 。 但 我 们 也 必 须 抓 紧 时 间 ， 尤 其 考 虑 到 目 前 政 府 已 经 对 新 左 翼 力 量 有 所 察 觉 的 情 况 下 ， 必 须 尽 快 集 结 力 量 抢 在 “ 窗 口 期 ” 内 发 动 新 的 起 义 。";
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[1] += 80;
			a.data[3] += 50;
			a.data[4] += 50;
			a.data[6] += 5;
			a.empires[0].relations -= 50;
			a.allcountries[44].prcpower += 10;
			a.influencePRC += 10;
		}
		if (result_num == 1)
		{
			text = " 我 们 与 <color=red>日 本 共 产 党</color> 和 <color=#A52A2A>日 本 共 产 主 义 抵 抗 者 同 盟</color> 展 开 了 磋 商 ， 但 二 者 对 于 合 并 一 事 有 许 多 疑 虑 （ 特 别 是 后 者 内 部 此 时 仍 有 个 别 人 是 托 洛 茨 基 主 义 的 支 持 者 ） 。 加 之 后 者 的 力 量 和 组 织 架 构 均 欠 缺 很 多 ， 最 终 磋 商 不 了 了 之 。 两 股 力 量 继 续 各 自 为 战 ， 尽 管 它 们 仍 然 试 图 扩 大 支 持 者 群 体 并 能 够 不 定 期 收 到 援 助 ， 但 缺 少 更 大 力 量 的 它 们 已 经 难 以 为 继 了 . . . . . .";
			a.influencePRC -= 10;
		}
	}
}
