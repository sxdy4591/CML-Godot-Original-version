using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event570 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 命 运 的 战 争 已 然 开 始";
		text = " 随 着 革 命 战 争 的 告 一 段 落 ， 新 生 的 伊 拉 克 社 会 主 义 共 和 国 把 目 光 转 向 了 东 南 角 的 弹 丸 小 国 — — — — 科 威 特 。 自 独 立 以 来 的 伊 拉 克 领 袖 们 从 未 忘 记 这 块 弹 丸 之 国 ， 更 别 提 新 生 的 社 会 主 义 共 和 国 有 多 渴 望 推 翻 科 威 特 的 埃 米 尔 政 权 了 。 最 近 ， 伊 拉 克 外 交 部 正 式 谴 责 了 科 威 特 “ 残 酷 的 迫 害 伊 拉 克 和 巴 勒 斯 坦 劳 工 ， 在 重 要 问 题 上 多 次 追 随 美 帝 国 主 义 者 ” 。 并 正 式 宣 布 对 科 威 特 发 动 特 别 军 事 行 动 。 很 快 ， 精 锐 的 “ 两 河 ” 师 团 ， “ 劳 动 者 ” 机 械 化 步 兵 营 和 七 月 十 四 革 命 卫 队 以 闪 电 一 般 的 攻 势 快 速 穿 插 ， 攻 入 了 这 个 就 比 烟 台 大 一 点 的 小 国 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 我 赌 伊 拉 克 赢 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 命 运 的 战 争 已 然 开 始";
		if (result_num != 0)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < a.allcountries.Length; i++)
		{
			if (a.allcountries[i].Gosstroy == 1 && a.allcountries[i].oar && (i == 13 || i == 14 || i == 30 || i == 18 || i == 40 || i == 54 || i == 55 || i == 35))
			{
				num += 20;
			}
		}
		text = " 不 论 体 量 还 是 军 队 素 质 ， 伊 拉 克 的 革 命 力 量 远 远 超 过 科 威 特 的 散 兵 游 勇 。 很 快 他 们 就 将 逼 近 科 威 特 市 区 …";
		a.data[143] += 3;
		a.ingamewars[38] = new War().Name(" 伊 拉 克 - 科 威 特 之 战").Attacker(" 伊 拉 克").Defender(" 科 威 特")
			.AttackerInfluence(700 + num)
			.DefenderInfluence(300 - num)
			.TickTime(8)
			.AmericanSupportDefender.CreateWar;
	}
}
