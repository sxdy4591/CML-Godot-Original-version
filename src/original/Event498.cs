using EventsForDLC;
using UnityEngine;

public class Event498 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 也 门 最 后 的 纳 赛 尔 主 义 者 ？";
		text = " 主 席 同 志 ！ 我 们 最 近 截 获 了 一 份 报 告 ， 称 南 也 门 党 内 正 在 谋 划 针 对 北 也 门 领 袖 艾 哈 迈 德 · 加 什 米 的 暗 杀 计 划 。 加 什 米 总 统 一 贯 反 对 美 帝 国 主 义 和 苏 联 修 正 主 义 者 对 阿 拉 伯 世 界 的 颐 指 气 使 ， 并 大 力 推 进 阿 拉 伯 统 一 事 业 。 也 许 我 们 应 当 警 告 他 们 ？ 毕 竟 这 可 以 极 大 的 促 进 我 们 和 阿 拉 伯 也 门 之 间 的 合 作 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[56] <= 2)
		{
			button_text[0] = " 警 告 北 也 门 关 于 阴 谋 的 事 情 （ 需 要 3 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 党 对 这 些 事 不 感 兴 趣 ";
		}
		button_text[1] = " 没 有 这 个 必 要";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 也 门 最 后 的 纳 赛 尔 主 义 者 ？";
		if (result_num == 0)
		{
			text = " 我 们 警 告 了 加 什 米 总 统 关 于 刺 杀 的 阴 谋 案 ， 在 询 问 了 南 也 门 方 面 后 ， 我 们 竟 然 设 法 破 获 了 一 起 预 谋 推 翻 南 也 门 总 统 鲁 巴 伊 的 政 变 。 南 也 门 的 刺 客 被 国 安 局 的 特 务 抓 获 ， 加 什 米 总 统 设 法 逃 过 一 劫 。 加 什 米 总 统 很 感 谢 我 们 的 所 作 所 为 ， 北 也 门 加 大 了 和 我 们 的 合 作 力 度 。";
			a.data[9] -= 30;
			a.allcountries[25].Gosstroy = 2;
			a.allcountries[25].SubGosstroy = 15;
			a.allcountries[25].Torg = true;
			a.allcountries[25].proprc = true;
			a.empires[1].relations -= 50;
		}
		if (result_num == 1)
		{
			text = " 我 们 无 动 于 衷 ， 很 快 ， 加 什 米 总 统 在 前 往 亚 丁 参 加 南 也 门 国 庆 的 前 几 天 被 南 也 门 刺 客 暗 杀 。 指 挥 委 员 会 临 时 推 选 了 萨 利 赫 作 为 北 也 门 的 代 行 领 导 人 。 萨 利 勒 一 转 先 前 反 帝 的 政 策 ， 他 开 始 推 动 经 济 的 市 场 化 ， 与 北 方 的 宰 德 派 和 解 ， 并 谋 求 和 以 色 列 和 解 。 北 也 门 与 南 也 门 的 关 系 日 渐 紧 张 。 阿 盟 国 家 也 指 责 其 试 图 背 叛 阿 拉 伯 民 族 的 事 业 。";
			a.allcountries[25].Gosstroy = 0;
			a.allcountries[25].SubGosstroy = 7;
			a.allcountries[25].Vyshi = true;
			a.empires[0].power += 20;
		}
	}
}
