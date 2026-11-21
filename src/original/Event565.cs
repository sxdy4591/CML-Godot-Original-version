using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event565 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 滚 出 去 ， 阿 萨 德";
		text = " 得 益 于 我 们 之 前 的 行 动 ， 部 分 叙 利 亚 库 尔 德 组 织 ， 伊 斯 兰 主 义 者 ， 自 由 主 义 者 与 左 派 被 联 合 起 来 组 成 了 解 放 叙 利 亚 全 国 同 盟 ， 在 我 们 特 勤 的 帮 助 下 ， 1 9 8 0 年 6 月 2 7 日 在 招 待 马 里 总 统 的 正 式 国 宴 上 ， 数 名 被 安 插 进 去 的 反 对 派 分 子 成 功 刺 杀 了 阿 萨 德 。 阿 萨 德 之 死 彻 底 使 得 叙 利 亚 局 势 变 得 更 加 动 乱 ， 解 放 叙 利 亚 全 国 同 盟 借 此 机 会 拿 着 我 们 支 援 的 武 器 发 动 了 起 义 。 继 任 的 里 法 特 • 阿 萨 德 宣 布 与 中 国 断 交 ， 并 寻 求 苏 联 的 支 持 来 镇 压 叛 乱 。|| 在 内 战 爆 发 之 后 ， 由 于 解 放 叙 利 亚 全 国 同 盟 内 部 信 仰 的 巨 大 差 异 使 得 反 对 派 的 联 合 不 可 避 免 的 瓦 解 了 。 反 对 派 们 分 裂 成 以 圣 战 者 战 斗 先 锋 队 （ 穆 斯 林 兄 弟 会 中 的 强 硬 分 支 ） 为 首 的 极 端 伊 斯 兰 主 义 者 ， 民 族 进 步 阵 线 的 反 对 派 组 成 的 民 族 民 主 大 会 （ 以 阿 拉 伯 社 会 主 义 和 科 学 社 会 主 义 者 为 主 ） ， 以 及 以 叙 利 亚 第 二 共 和 国 时 期 的 遗 老 为 首 的 自 由 主 义 者 和 穆 兄 会 组 成 的 叙 利 亚 自 由 联 盟 这 三 大 派 别 。 现 在 到 了 选 择 的 时 候 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.influencePRC >= 500 && a.data[31] >= 600 && !a.modifies[3].active && a.allcountries[8].SubGosstroy != 13)
		{
			button_text[0] = " 支 持 伊 斯 兰 主 义 者";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 为 什 么 要 支 持 一 群 神 棍 ？";
		}
		if (a.data[56] <= 2)
		{
			button_text[1] = "支 持 民 族 民 主 大 会";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 他 们 不 会 听 我 们 的";
		}
		if (a.data[56] > 1)
		{
			button_text[2] = "支 持 叙 利 亚 自 由 联 盟";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = " 绝 不 支 持 自 由 主 义 者 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 滚 出 去 ， 阿 萨 德";
		if (result_num == 0)
		{
			text = " 在 我 们 的 支 持 下 ， 以 圣 战 者 战 斗 先 锋 队 为 首 的 极 端 伊 斯 兰 主 义 者 很 快 将 左 派 和 民 主 派 分 子 处 理 掉 ， 并 宣 布 将 对 复 兴 社 会 党 世 俗 主 义 政 权 发 动 圣 战 。";
			a.ingamewars[41] = new War().Name(" 叙 利 亚 内 战").Attacker(" 叙 利 亚 政 府 军").Defender(" 伊 斯 兰 主 义 者")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(24)
				.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			a.empires[0].relations += 150;
			a.empires[1].relations -= 150;
		}
		if (result_num == 1)
		{
			text = " 在 我 们 的 支 持 下 ， 由 库 尔 德 工 人 党 叙 利 亚 支 部 ， 阿 拉 伯 社 会 主 义 者 和 共 产 主 义 者 组 织 起 来 的 民 族 民 主 大 会 迅 速 平 定 了 伊 斯 兰 主 义 者 和 民 主 派 的 叛 乱 ， 并 开 始 向 背 叛 革 命 的 阿 萨 德 政 府 进 行 进 攻 。";
			a.ingamewars[41] = new War().Name(" 叙 利 亚 内 战").Attacker(" 叙 利 亚 政 府 军").Defender(" 全 国 民 主 同 盟")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(24)
				.SovietSupportAttacker.CreateWar;
			a.empires[1].relations -= 200;
		}
		if (result_num == 2)
		{
			text = " 在 我 们 的 支 持 下 ， 由 前 叙 利 亚 共 和 国 高 官 ， 部 分 民 主 派 ， 叙 利 亚 库 尔 德 民 主 党 以 及 温 和 的 伊 斯 兰 主 义 者 为 首 的 叙 利 亚 自 由 联 盟 迅 速 清 理 掉 了 左 派 与 伊 斯 兰 主 义 者 中 的 极 端 分 子 ， 并 开 始 向 推 翻 了 叙 利 亚 共 和 国 的 阿 拉 伯 社 会 主 义 分 子 复 仇 。";
			a.ingamewars[41] = new War().Name(" 叙 利 亚 内 战").Attacker(" 叙 利 亚 政 府 军").Defender(" 叙 利 亚 自 由 联 盟")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(24)
				.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			a.empires[0].relations += 150;
			a.empires[1].relations -= 150;
		}
	}
}
