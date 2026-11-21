using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event568 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 阿 拉 伯 湾 旗 帜 飘";
		text = " 随 着 阿 湾 人 阵 在 我 们 的 持 续 支 持 下 在 游 击 战 争 中 获 得 的 优 势 ， 尽 管 君 主 们 都 在 帝 国 主 义 的 援 助 下 竭 力 开 展 改 革 ， 并 用 发 放 免 费 物 资 贿 赂 人 民 ， 期 望 以 此 消 解 人 民 的 斗 争 ， 但 他 们 的 算 盘 并 没 有 如 他 们 的 意 — — 整 个 阿 拉 伯 湾 陷 入 到 内 乱 之 中 了 ， 在 帝 国 主 义 的 支 持 下 ， 阿 拉 伯 湾 的 各 个 君 主 国 不 得 不 开 展 全 面 动 员 ， 对 阿 湾 人 阵 展 开 全 面 的 战 争 ， 而 沙 特 也 自 然 意 识 到 了 唇 亡 齿 寒 的 道 理 ， 他 们 直 接 向 海 湾 各 君 主 国 派 出 了 军 队 ， 宣 称 “ 将 帮 助 友 邦 开 展 维 和 行 动 ” 。 阿 湾 人 阵 也 宣 布 要 基 于 现 有 的 根 据 地 ， 开 展 “ 全 阿 拉 伯 湾 的 暴 动 ” 。 阿 拉 伯 湾 的 革 命 进 入 了 新 的 阶 段 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 这 一 次 ， 阿 拉 伯 湾 的 人 民 必 将 斩 断 锁 链 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 阿 拉 伯 湾 旗 帜 飘";
		if (result_num != 0)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < a.allcountries.Length; i++)
		{
			if (a.allcountries[i].Gosstroy == 1 && a.allcountries[i].oar && (i == 13 || i == 14 || i == 30 || i == 18 || i == 40 || i == 54 || i == 55 || i == 35))
			{
				num += 30;
			}
		}
		for (int j = 101; j < 106; j++)
		{
			if (j != 104 && a.allcountries[j].proprc)
			{
				a.allcountries[j].proprc = false;
			}
		}
		if (a.allcountries[36].proprc)
		{
			a.allcountries[36].proprc = false;
		}
		text = " 通 过 阿 湾 人 阵 在 城 市 中 对 海 湾 国 家 的 各 企 业 中 的 地 下 组 织 ， 阿 湾 人 阵 得 以 在 城 市 中 把 来 自 各 地 的 工 人 、 进 步 的 学 生 和 知 识 分 子 团 结 起 来 ， 发 起 罢 工 斗 争 ， 并 利 用 我 们 提 供 的 武 器 与 警 察 和 军 队 开 展 街 垒 战 ； 与 此 同 时 ， 农 村 根 据 地 也 开 展 了 全 面 动 员 ， 以 进 行 对 敌 人 的 全 面 进 攻 。 全 面 的 战 争 开 始 了 ， 而 世 界 也 在 注 视 着 这 场 战 争 ， 以 及 与 此 息 息 相 关 的 油 价 … …";
		a.data[143] += 10;
		a.ingamewars[43] = new War().Name(" 阿 拉 伯 湾 革 命").Attacker(" 阿 拉 伯 湾 国 家 政 府").Defender(" 阿 湾 人 阵 起 义 军")
			.AttackerInfluence(700 - num)
			.DefenderInfluence(300 + num)
			.TickTime(24)
			.AmericanSupportAttacker.CreateWar;
	}
}
