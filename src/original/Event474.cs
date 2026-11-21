using EventsForDLC;
using UnityEngine;

public class Event474 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 维 新 之 冬";
		text = " 根 据 我 们 和 朝 鲜 特 工 所 知 道 的 消 息 ， 韩 国 的 维 新 政 体 持 续 了 多 年 ， 期 间 反 对 声 音 不 断 ， 在 1 9 7 9 年 9 月 ， 因 反 对 党 党 首 金 泳 三 议 员 被 驱 逐 出 国 会 而 导 致 反 对 派 抗 议 规 模 越 来 越 大 ， 釜 山 和 马 山 的 工 人 ， 学 生 和 市 民 开 始 上 街 抗 议 ， 要 求 维 新 政 权 下 台 。 1 0 月 ， 抗 议 规 模 越 来 越 大 ， 甚 至 有 了 全 国 抗 议 的 可 能 。\n 我 们 是 否 应 该 帮 釜 马 的 市 民 们 一 把 ， 让 南 朝 鲜 独 裁 政 权 垮 台 ， 亦 或 者 是 选 择 支 持 朴 正 熙 政 权 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[9] >= 50 && a.data[22] >= 50)
		{
			button_text[0] = " 给 市 民 们 输 送 武 器";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 有 心 无 力 啊";
		}
		if (a.data[9] >= 50 && a.data[56] >= 2)
		{
			button_text[1] = " 支 持 朴 正 熙 政 权";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 帮 助 这 个 独 裁 者";
		}
		button_text[2] = " 与 我 无 关";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 维 新 之 冬";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 和 朝 鲜 特 工 的 帮 助 下 ， 釜 马 地 区 的 市 民 拿 到 了 枪 ， 开 始 反 抗 维 新 政 权 。 但 是 与 此 同 时 ， 南 朝 鲜 伪 军 第 1 ， 3 ， 5 空 输 特 战 旅 团 和 海 军 陆 战 队 第 一 师 开 始 对 釜 马 地 区 发 起 进 攻 ， 最 后 被 平 息 ， 有 五 百 多 人 被 杀 害 ， 三 千 多 人 被 捕 。 在 之 后 ， 情 报 部 长 金 载 圭 在 宫 井 洞 将 朴 正 熙 和 车 智 澈 杀 死 ， 成 立 以 郑 升 和 为 首 的 新 政 府 ， 但 是 随 后 便 被 保 安 司 令 部 全 斗 换 发 动 的 政 变 赶 下 台 。";
			a.allcountries[46].SubGosstroy = 7;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 10;
			a.influencePRC += 10;
			break;
		case 1:
			text = " 我 们 选 择 高 调 支 持 韩 国 。 之 后 维 新 政 权 颁 布 戒 严 令 ， 并 调 出1 ，3 ，5 空 输 特 战 旅 团 和 海 军 陆 战 队 第 一 师 进 行 镇 压 ， 最 终 有 约 一 千 人 被 捕 ， 釜 马 事 件 平 息 。 与 此 同 时 ， 我 们 提 前 获 悉 了 韩 国 情 报 部 长 金 载 圭 试 图 刺 杀 朴 正 熙 ， 并 提 醒 了 朴 正 熙 ， 最 后 金 载 圭 在 宫 井 洞 被 捕 并 被 处 死 。 韩 国 很 感 激 我 们 ， 并 开 始 与 我 们 进 行 贸 易 ， 我 们 也 顺 水 推 舟 ， 帮 助 韩 国 与 朝 鲜 进 行 联 系 ， 并 再 次 进 行 南 北 谈 判 ， 朝 鲜 对 我 们 的 行 为 略 有 不 满 。";
			a.allcountries[46].SubGosstroy = 9;
			a.allcountries[46].Torg = true;
			a.empires[0].relations += 150;
			a.empires[1].relations -= 100;
			break;
		case 2:
			text = " 1 0 月 1 8 日 ， 维 新 政 权 颁 布 戒 严 令 ， 调 出 1 ， 3 ， 5 空 输 特 战 旅 团 和 海 军 陆 战 队 第 一 师 进 行 镇 压 ， 最 终 有 约 一 千 人 被 捕 ， 釜 马 事 件 平 息 。 1 0 月 2 6 日 ， 情 报 部 长 金 载 圭 在 宫 井 洞 将 朴 正 熙 ， 车 智 澈 杀 死 ， 随 后 被 捕 并 被 秘 密 审 判 处 决 ， 在 1 2 月 1 2 日 ， 保 安 司 令 部 长 官 全 斗 焕 发 动 政 变 ， 夺 取 了 政 权 。";
			a.allcountries[46].SubGosstroy = 7;
			break;
		}
	}
}
