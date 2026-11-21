using EventsForDLC;
using UnityEngine;

public class Event618 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "既 生 你 ， 何 生 我 ？";
		text = "自1960 年 喀 麦 隆 独 立 以 来 ， 开 国 总 统 阿 赫 马 杜 · 阿 希 乔 担 任 了22 年 的 总 统 ， 在1982 年11 月 由 于 病 因 暂 时 辞 职 ， 并 由 总 理 保 罗 · 比 亚 来 接 任 ， 但 是 阿 希 乔 仍 是 喀 麦 隆 民 族 联 盟 （ 执 政 党 ） 的 主 席 。 在1983 年 由 于 阿 希 乔 在 权 力 斗 争 中 落 败 被 迫 流 亡 海 外 ， 同 年 比 亚 指 责 阿 希 乔 试 图 发 动 政 变 并 将 支 持 阿 希 乔 的 总 理 和 国 防 部 长 解 雇 ， 阿 希 乔 批 评 比 亚 的 偏 执 ， 并 辞 去 了 喀 麦 隆 民 族 联 盟 主 席 这 一 职 务 ， 阿 希 乔 于1984 年 被 缺 席 审 判 死 刑 。 根 据 我 们 特 工 的 消 息 ， 阿 希 乔 可 能 会 再 次 发 动 政 变 。 主 席 同 志 ， 我 们 是 否 应 该 参 与 进 去 这 件 事 情 ？ 毕 竟 这 是 一 个 能 让 喀 麦 隆 变 得 更 加 有 利 于 我 们 的 机 会 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] > 1)
		{
			button_text[0] = " 联 系 阿 希 乔 并 为 他 提 供 帮 助";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 为 什 么 要 帮 助 这 个 前 亲 法 独 裁 者 ？";
		}
		if (a.data[56] > 1)
		{
			button_text[1] = " 为 比 亚 提 供 情 报";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 为 何 要 为 法 国 人 做 嫁 衣 ？";
		}
		button_text[2] = " 我 们 为 什 么 要 从 两 个 亲 法 的 独 裁 者 中 选 择 一 个 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "既 生 你 ， 何 生 我 ？";
		if (result_num == 0)
		{
			text = "我 们 的 特 工 秘 密 联 系 上 了 流 亡 海 外 的 阿 希 乔 ， 通 过 谈 判 最 终 阿 希 乔 同 意 与 我 们 合 作 。1984 年4 月3 日 ， 共 和 国 卫 队 的 数 百 名 成 员 开 始 突 袭 总 统 府 和 总 参 谋 部 ， 并 成 功 占 领 了 国 家 广 播 电 台 ， 在 阿 希 乔 呼 吁 被 广 播 之 后 ， 军 队 开 始 哗 变 ， 比 亚 在 西 部 进 行 休 假 时 得 知 这 一 消 息 ， 并 试 图 组 织 反 抗 ， 但 是 在 共 和 国 卫 队 的 包 围 下 ， 比 亚 被 迫 选 择 投 降 并 呼 吁 军 队 停 火 。 阿 希 乔 在 军 队 的 簇 拥 下 乘 坐 专 机 回 国 。 阿 希 乔 没 有 忘 记 比 亚 是 怎 么 对 待 他 的 ， 当 即 宣 判 比 亚 死 刑 。 当 然 ， 阿 希 乔 也 没 有 忘 记 我 们 ， 但 是 他 同 样 也 不 会 得 罪 法 国 ， 喀 麦 隆 宣 布 为 中 喀 友 谊 ， 将 会 为 中 国 方 面 提 供 各 种 不 亚 于 为 法 国 提 供 的 优 惠 政 策 ， 我 方 的 大 量 资 本 涌 入 喀 麦 隆 境 内 ， 开 始 与 法 国 资 本 互 相 竞 争 。";
			a.allcountries[66].Torg = true;
			a.influencePRC += 10;
			a.data[22] -= 100;
			a.data[9] -= 100;
		}
		if (result_num == 1)
		{
			text = "我 们 将 这 个 情 报 告 诉 给 比 亚 ，1984 年4 月6 日 ， 比 亚 将 共 和 国 卫 队 给 调 离 首 都 ， 有 部 分 反 叛 人 士 试 图 开 始 反 抗 ， 但 是 被 早 已 部 署 在 附 近 的 亲 比 亚 部 队 歼 灭 。 阿 希 乔 回 归 政 坛 的 最 后 一 次 尝 试 失 败 了 。 比 亚 彻 底 巩 固 政 权 ， 将 喀 麦 隆 民 族 联 盟 改 组 为 喀 麦 隆 人 民 民 主 运 动 。 为 感 谢 我 们 提 供 的 情 报 ， 比 亚 决 定 扩 大 与 我 们 的 合 作 ， 但 是 他 同 样 也 不 会 得 罪 法 国 。 喀 麦 隆 宣 布 为 中 喀 友 谊 将 会 为 中 国 方 面 提 供 各 种 不 亚 于 为 法 国 提 供 的 优 惠 政 策 ， 我 方 的 大 量 资 本 涌 入 喀 麦 隆 境 内 ， 开 始 与 法 国 资 本 互 相 竞 争 。";
			a.allcountries[66].Torg = true;
			a.influencePRC += 10;
			a.data[9] -= 50;
		}
		if (result_num == 2)
		{
			text = "1984 年4 月6 日 ， 比 亚 总 统 下 令 调 动 所 有 来 自 穆 斯 林 占 多 数 的 北 方 地 区 的 总 统 府 警 卫 ， 称 有 涉 及 这 些 士 兵 的 政 变 阴 谋 。 共 和 国 卫 队 的 持 不 同 政 见 者 迅 速 对 命 令 做 出 反 应 ， 反 抗 比 亚 。 由 于 比 亚 下 令 将 士 兵 从 首 都 雅 温 得 搬 迁 ， 阴 谋 的 领 导 人 可 能 被 迫 过 早 地 发 动 政 变 企 图 。 喀 麦 隆 空 军 仍 然 忠 于 总 统 的 空 军 参 与 平 叛 。 在 雅 温 得 经 过 几 天 的 激 烈 战 斗 后 ， 比 亚 的 效 忠 者 击 败 了 叛 军 。 政 府 宣 布 雅 温 得 及 周 边 地 区 进 入 为 期 六 个 月 的 紧 急 状 态 。 政 变 失 败 后 ， 比 亚 全 面 巩 固 了 权 力 并 于1985 年 改 组 喀 麦 隆 民 族 联 盟 为 喀 麦 隆 人 民 民 主 运 动。";
		}
	}
}
