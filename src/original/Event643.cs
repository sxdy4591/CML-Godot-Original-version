using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event643 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "解 放 台 湾 ？";
		text = "华 国 锋 同 志 ， 台 湾 ， 不 仅 是 我 国 不 可 分 割 的 一 部 分 ， 也 是 美 帝 封 锁 我 国 的 前 哨 站 。 尤 其 是 在 我 国 已 经 接 受 了 先 进 的 红 色 基 因 理 论 后 ， 美 国 更 是 下 定 决 心 全 力 武 装 台 湾 。 原 本 美 国 卖 给 台 湾 的 都 是 些 落 后 时 代 的 装 备 ， 而 现 在 ， 各 式 美 军 现 役 装 备 都 被 以 低 价 卖 予 台 湾 。 甚 至 ， 有 些 声 称 奉 行 “ 一 个 中 国 ” 政 策 的 国 家 ， 也 暗 中 与 台 湾 伪 政 权 有 着 联 系 ， 真 不 知 道 他 们 所 说 的 那 个 “ 一 个 中 国 ” 到 底 是 哪 个 ！ 现 在 ， 是 时 候 一 劳 永 逸 地 解 决 蒋 伪 政 权 了 。 人 民 解 放 军 即 将 完 成 他 们 的 最 大 的 使 命 ， 完 成 伟 大 领 袖 的 未 竟 之 业 ， 解 放 台 湾 人 民 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 打 过 海 峡 去 ， 解 放 全 中 国 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "解 放 台 湾 ？";
		if (result_num == 0)
		{
			text = "中 央 一 声 令 下 ， 解 放 军 海 军 立 即 包 围 了 台 湾 岛 ， 断 绝 了 台 湾 岛 与 外 界 的 一 切 联 系 。 金 门 马 祖 立 刻 被 福 建 省 的 解 放 军 接 管 ， 而 登 岛 作 战 貌 似 也 并 不 困 难 。 美 苏 谴 责 我 们 破 坏 台 海 和 平 ， 我 们 早 已 对 此 见 怪 不 怪 ， 甚 至 我 们 的 联 合 国 代 表 都 能 背 出 来 他 们 谴 责 我 们 的 台 词 ， 况 且 这 只 是 我 们 解 放 自 己 的 领 土 ， 又 关 他 们 何 事 呢 ？";
			a.ingamewars[75] = new War().Name("第 三 次 中 国 内 战").Attacker("中 华 人 民 共 和 国").Defender("中 华 民 国")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.TickTime(12)
				.SovietSupportDefender.AmericanSupportDefender.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] += 150;
			a.data[8] -= 50;
			a.data[9] -= 100;
			a.data[22] -= 200;
			a.data[34] += 2;
			a.empires[1].relations -= 500;
			a.empires[1].power -= 15;
			a.empires[0].relations -= 500;
			a.empires[0].power -= 15;
			a.influencePRC += 15;
		}
	}
}
