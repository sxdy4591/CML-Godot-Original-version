using EventsForDLC;
using UnityEngine;

public class Event491 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 在 巴 尔 干 的 繁 星 下";
		text = " 日 夫 科 夫 的 统 治 并 非 一 帆 风 顺 。 早 在 1 9 6 5 年 ， 保 加 利 亚 共 产 党 内 部 就 有 过 密 谋 推 翻 日 夫 科 夫 的 计 划 。 保 共 中 央 委 员 伊 万 · 托 多 罗 夫 · 格 伦 亚 与 一 批 军 队 指 挥 官 被 日 夫 科 夫 的 修 正 主 义 政 策 所 激 怒 ， 而 他 们 决 心 借 此 机 会 一 举 挣 脱 苏 联 的 枷 锁 。 但 一 切 都 没 有 按 计 划 进 行 ， 克 格 勃 设 法 查 破 了 他 们 的 计 划 ， 大 批 涉 案 军 官 被 查 处 。 其 中 就 包 括 了 佩 塔 尔 · 潘 切 夫 斯 基 。 最 近 有 消 息 称 ， 日 夫 科 夫 正 在 谋 求 一 劳 永 逸 解 决 这 个 麻 烦 人 物 的 方 法 。 我 们 可 以 帮 助 佩 塔 尔 ， 说 不 定 他 对 我 们 的 未 来 有 帮 助 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 帮 他 一 把";
		button_text[1] = " 我 们 可 以 以 后 再 做 的 ， 对 吧 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 在 巴 尔 干 的 繁 星 下";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 特 工 的 帮 助 下 ， 佩 塔 尔 没 能 吃 下 掺 了 毒 药 的 炖 菜 。 出 于 对 日 夫 科 夫 追 杀 的 恐 惧 ， 我 们 为 他 提 供 了 政 治 难 民 的 身 份 。 允 许 其 以 保 加 利 亚 驻 华 武 官 的 身 份 暂 住 在 北 京 。 日 夫 科 夫 对 我 们 “ 赤 裸 裸 干 涉 保 加 利 亚 内 政 ” 的 行 动 感 到 “ 十 分 疑 惑 ” 。 他 下 令 驱 逐 一 名 我 国 大 使 馆 的 三 等 秘 书 用 于 表 达 自 己 的 态 度 。";
			a.data[9] -= 50;
			a.allcountries[6].cw = true;
			a.empires[1].relations -= 50;
			a.influencePRC += 5;
			break;
		case 1:
			text = " 1 9 8 2 年 1 1 月 1 7 日 ， 这 位 老 英 雄 吃 下 了 掺 有 烈 性 毒 药 的 炖 菜 。 日 夫 科 夫 的 政 权 变 得 越 发 稳 固 … … 至 少 暂 时 如 此 。";
			break;
		}
	}
}
