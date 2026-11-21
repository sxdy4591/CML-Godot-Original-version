using EventsForDLC;
using UnityEngine;

public class Event513 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 我 们 未 来 的 武 器";
		text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
		text += " ";
		text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
		text += " 同 志 ！ 最 近 的 军 事 委 员 会 会 议 上 提 出 了 要 研 发 并 改 进 我 们 军 事 装 备 的 问 题 。 我 军 仍 然 大 量 装 备 5 6 式 半 自 动 步 枪 和 5 6 式 冲 锋 枪 等 落 后 的 武 器 ， 而 六 三 式 质 量 过 于 难 以 保 障 从 而 被 拒 绝 。 5 4 式 重 机 枪 ， 6 9 式 火 箭 筒 甚 至 不 能 做 到 大 量 列 装 。 很 明 显 ， 如 果 我 们 卷 入 大 规 模 的 战 争 ， 我 们 很 难 相 信 中 国 人 民 解 放 军 有 能 力 打 赢 。 因 此 我 们 迫 切 的 需 要 最 新 的 武 器 装 备 。 一 部 分 的 方 案 是 继 续 模 仿 并 改 进 苏 联 的 军 事 装 备 ， 就 如 现 在 一 样 ， 我 们 可 以 仿 制 更 为 先 进 的 A K - 7 4 和 P K M 通 用 机 枪 。 另 一 个 方 案 则 是 开 始 研 制 小 口 径 武 器 。 早 在 1 9 7 0 年 ， 中 央 军 委 常 规 兵 器 工 业 领 导 小 组 第 六 次 会 议 上 就 明 确 指 出 要 研 制 一 种 初 速 大 、 重 量 轻 、 杀 伤 威 力 大 的 步 枪 。||最 高 领 导 人 同 志 ， 我 们 正 在 期 待 您 的 意 见 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[8] + a.data[36] > 20)
		{
			button_text[0] = " 我 们 可 以 “ 借 鉴 ” 苏 联 的 装 备";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 那 么 ， 钱 从 哪 来 ？";
		}
		if (a.data[8] + a.data[36] > 40)
		{
			button_text[1] = " 让 我 们 着 手 研 发 自 己 的 武 器";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 自 力 更 生 是 好 事 ， 但 我 们 显 然 没 有 这 个 能 力";
		}
		button_text[2] = " 造 不 如 买 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 们 未 来 的 武 器";
		if (result_num == 0)
		{
			text = " 通 过 我 们 和 伊 拉 克 的 秘 密 协 议 ， 我 们 从 萨 达 姆 手 上 拿 到 了 大 量 A K - 7 4 自 动 步 枪 。 在 中 国 轻 武 器 研 究 所 的 不 懈 努 力 下 ， 7 6 式 自 动 步 枪 诞 生 了 。 相 比 A K - 7 4 ， 它 更 加 耐 保 存 ， 短 导 气 管 防 止 了 火 药 燃 气 进 入 机 闸 的 可 能 性 。 而 且 它 的 另 一 项 优 势 便 是 它 的 简 单 ， 只 需 要 三 分 钟 ， 下 至 初 中 生 ， 上 至 六 旬 老 人 ， 只 要 能 拿 得 动 这 杆 枪 ， 都 能 学 会 拆 解 ， 组 装 和 使 用 这 把 武 器 。 很 快 这 些 武 器 就 会 取 代 老 旧 的 5 6 式 冲 锋 枪 ， 成 为 民 兵 和 解 放 军 士 兵 的 主 流 武 器 。 而 相 对 应 的 P K M 班 用 机 枪 也 被 引 入 我 国 ， 用 于 补 齐 我 国 缺 少 班 用 火 力 压 制 武 器 的 空 缺 。 小 口 径 的 自 研 武 器 还 是 再 等 等 吧 … …";
			a.data[8] -= 20;
			a.data[22] += 50;
			a.influencePRC += 10;
			a.empires[1].relations -= 50;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 仿 制 苏 械 ：</color>| 军 力+0.1";
		}
		if (result_num == 1)
		{
			a.data[8] -= 40;
			text = " 我 们 决 定 研 制 一 款 口 径 更 小 的 自 研 轻 武 器 来 逐 步 取 代 现 役 装 备 。 在 中 国 国 家 兵 工 厂 研 究 部 的 数 位 工 程 师 和 设 计 师 热 烈 的 讨 论 后 ， 由 朵 英 贤 团 队 设 计 的 Q B Z - 7 6 自 动 步 枪 得 到 了 一 致 好 评 。 该 枪 看 起 来 和 传 统 苏 式 武 器 别 无 二 样 。 但 它 采 用 了 杀 伤 力 更 为 巨 大 的 5 . 8 m m 子 弹 ， 在 打 入 伤 口 之 后 不 会 贯 穿 ， 而 是 在 体 内 “ 爆 ” 开 。 5 . 8 m m 子 弹 也 防 止 了 美 国 等 西 方 国 家 缴 获 了 我 们 的 武 器 之 后 直 接 使 用 。 工 程 塑 料 也 创 造 性 的 在 这 件 武 器 上 得 到 了 运 用 。 很 快 这 些 武 器 就 会 投 入 量 产 ， 并 在 不 久 的 将 来 取 代 5 6 式 自 动 步 枪 。 而 相 对 应 的 ， 带 有 弹 鼓 的 机 枪 型 号 也 在 紧 锣 密 鼓 的 研 制 中 。";
			a.influencePRC += 15;
			a.data[22] += 80;
			GlobalScript.inst.old_modify_desc[50] += "<color=red>| 自 研 军 械 ：</color>| 军 力+0.2";
		}
		if (result_num == 2)
		{
			text = " 我 们 决 定 向 超 级 大 国 购 买 武 器 以 填 补 空 缺 ， 武 器 的 问 题 得 到 了 解 决 。 苏 联 和 美 国 的 军 工 集 团 都 感 谢 我 们 的 订 单 。 但 未 来 的 武 器 该 怎 么 办 ？ 恐 怕 没 人 知 道 … …";
			a.data[8] -= 5;
			a.data[22] += 20;
		}
	}
}
