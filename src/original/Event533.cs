using EventsForDLC;
using UnityEngine;

public class Event533 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 打 入 主 义 的 再 实 践 ？";
		text = " 在 我 们 的 帮 助 下 ， <color=#A52A2A>日 本 共 产 主 义 抵 抗 者 同 盟</color> 不 仅 再 次 拥 有 了 充 足 的 武 器 装 备 ， 并 且 吸 纳 了 更 多 成 员 。 大 批 活 跃 分 子 开 始 再 次 深 入 工 厂 、 学 校 等 地 ， 宣 传 革 命 思 想 并 发 展 新 人 。 日 本 政 府 虽 然 多 次 针 对 这 一 组 织 展 开 围 剿 行 动 ， 但 多 亏 了 我 们 在 当 地 的 特 工 网 络 ， 同 盟 成 员 每 次 都 能 及 时 得 到 消 息 并 迅 速 化 整 为 零 隐 蔽 起 来 。 现 在 他 们 的 力 量 已 经 足 够 壮 大 ， 是 时 候 建 立 一 个 新 的 政 党 以 便 更 好 地 筹 划 下 一 次 全 共 斗 运 动 了 。 但 考 虑 到 目 前 同 盟 内 部 的 派 系 问 题 并 未 完 全 解 决 ， 相 当 一 批 人 也 并 不 愿 意 脱 离 自 己 原 先 的 小 组 织 而 融 合 进 这 个 “ 陌 生 ” 的 新 组 织 中 。 我 们 也 许 应 该 学 习 托 洛 茨 基 主 义 中 的 打 入 主 义 方 针 ， 让 他 们 渗 透 进 <color=#8B0000>日 本 共 产 党</color> 中 ？ 毕 竟 此 时 的 日 本 共 产 党 已 经 是 一 个 烂 透 了 的 资 产 阶 级 议 会 政 党 了 。 与 其 让 它 继 续 打 着 “ 共 产 党 ” 的 名 号 唬 骗 工 农 ， 还 不 如 由 同 盟 成 员 对 其 进 行 彻 头 彻 尾 的 改 造 。 你 觉 得 呢 ， 主 席 同 志 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[56] == 0 && a.allcountries[44].prcpower >= 120 && !a.modifies[3].active)
		{
			button_text[0] = " 发 动 我 们 在 当 地 的 力 量 ， 帮 助 同 盟 成 员 “ 打 入 ” 其 中";
		}
		else if (a.modifies[3].active)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 为 什 么 要 效 仿 托 派 ？";
		}
		else if (a.allcountries[44].prcpower < 120)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 赤 军 力 量 不 够 强 大 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 支 持 恐 怖 分 子 ？";
		}
		button_text[1] = " 现 在 还 不 是 时 候 ......";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 打 入 主 义 的 再 实 践 ？";
		if (result_num == 0)
		{
			text = " 我 们 很 快 为 <color=#A52A2A>共 产 主 义 抵 抗 者 同 盟</color> 的 成 员 梳 理 了 一 份 <color=#8B0000>日 本 共 产 党</color> 在 各 地 的 基 层 组 织 的 名 单 。 他 们 也 迅 速 行 动 起 来 前 往 各 地 并 加 入 那 里 的 共 产 党 基 层 组 织 。 不 久 许 多 人 便 因 其 积 极 表 现 而 得 到 提 拔 ， 同 盟 也 由 此 迈 出 了 打 入 的 第 一 步 ， 但 我 们 仍 需 注 意 为 他 们 提 供 更 多 的 支 持 ， 不 然 前 面 的 努 力 随 时 都 可 能 付 诸 东 流 。";
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.data[1] += 50;
			a.data[3] += 50;
			a.data[6] += 10;
			a.influencePRC += 30;
		}
		if (result_num == 1)
		{
			text = " 考 虑 到 目 前 同 盟 的 人 手 依 旧 不 足 ， 我 们 决 定 暂 时 按 兵 不 动 。 但 很 快 ， 同 盟 内 部 各 个 小 组 织 成 员 间 因 为 路 线 问 题 又 一 次 爆 发 了 矛 盾 。 虽 然 我 们 尽 力 调 节 ， 但 最 终 一 大 批 人 仍 然 脱 离 了 同 盟 。 这 严 重 打 击 了 我 们 的 影 响 力 和 同 盟 本 身 的 稳 定 性 。 最 终 同 盟 的 中 央 委 员 会 组 织 召 开 了 最 后 一 次 大 会 。 会 上 以 大 比 例 优 势 通 过 了 <color=#A52A2A>共 产 主 义 抵 抗 者 同 盟</color> 解 散 的 决 议 。 我 们 的 努 力 最 终 还 是 失 败 了 . . . . . .";
		}
	}
}
