using EventsForDLC;
using UnityEngine;

public class Event913 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 一 颗 名 为 太 阳 的 星 星";
		text = " 华 国 锋 同 志 ， 也 许 是 时 候 更 近 一 步 了 ， 我 们 的 宣 传 机 器 开 足 马 力 也 无 法 更 好 的 宣 传 我 国 的 伟 大 。 所 以 是 时 候 犯 下 一 点 “ 小 错 误 ” 了 。 我 们 将 向 全 国 人 民 播 报 这 样 的 一 条 新 闻 ， 我 国 宇 航 员 既 没 有 登 上 月 球 ， 也 没 有 在 火 星 留 下 脚 印 ， 而 是 … … 太 阳 ！ 多 么 闪 耀 的 一 颗 星 啊 ！ 就 如 同 您 的 名 字 一 般 闪 耀 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 好 ， 准 了 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 一 颗 名 为 太 阳 的 星 星";
		if (result_num == 0)
		{
			text = " 中 央 广 播 电 视 总 台 播 报 了 这 样 一 条 惊 天 动 地 的 新 闻 ， 年 仅26 岁 的 复 旦 大 学 高 材 生 张 维 为 成 为 了 全 世 界 第 一 个 登 陆 太 阳 的 宇 航 员 。 为 了 避 开 太 阳 惊 人 的 高 温 ， 中 国 航 天 局 决 定 在 晚 上 举 行 这 一 任 务 。 在 特 制 的 飞 船 的 帮 助 下 ， 张 维 为 得 以 在20 小 时 之 内 抵 达 太 阳 。 在 太 阳 上 ， 他 看 见 了 日 冕 和 由 太 阳 耀 斑 构 成 的 “ 华 国 锋 主 席 是 革 命 的 掌 舵 人 ” ， “ 你 办 事 ， 我 放 心 ” 之 类 的 口 号 。 他 感 到 了 深 深 的 触 动 ， 原 来 真 的 有 天 人 感 应 这 样 的 东 西 ！ 据 报 道 ， 他 还 从 太 阳 上 带 回 了 一 枚 太 阳 耀 斑 作 为 献 给 华 国 锋 同 志 的 礼 物 。 我 们 在 首 都 为 这 位 航 天 英 雄 举 行 了 盛 大 的 欢 迎 会 。 但 世 界 各 国 的 科 学 家 和 新 闻 界 无 所 不 用 其 集 的 嘲 讽 ， 挪 揄 我 们 的 伟 大 创 举 。 他 们 就 是 吃 不 到 葡 萄 嫌 葡 萄 酸 罢 了 ！";
			a.data[1] += 1000;
			a.data[3] += 1000;
			a.data[4] -= 1000;
			a.data[31] = 1000;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.empires[0].relations -= 150;
			a.empires[1].relations -= 150;
		}
	}
}
