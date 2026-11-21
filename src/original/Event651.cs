using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event651 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 树 丛 恶 魔";
		text = " 塞 拉 利 昂 自1961 年 独 立 后 便 长 期 为 政 治 问 题 所 困 扰 ： 虽 说 该 国 以 英 联 邦 内 的 “ 狮 子 山 ” 与 “ 河 里 淘 钻 ” 之 国 闻 名 ， 但 该 国 似 乎 并 没 有 配 得 上 如 此 财 富 的 手 腕 。 自 塞 拉 利 昂 国 父 米 尔 顿 · 马 盖 与 其 弟 相 继 被 反 英 情 绪 绊 倒 后 ， 最 高 权 力 便 落 入 了 全 国 大 会 党 党 魁 萨 卡 · 斯 蒂 文 森 手 中 。 斯 蒂 文 森 自 诩 将 走 一 条 社 会 主 义 道 路 ， 并 对 该 国 发 起 了 令 人 印 象 深 刻 的 革 新 ： 塞 拉 利 昂 脱 离 了 英 联 邦 框 架 ， 正 式 转 为 共 和 体 制 ； 随 后 便 是 在 不 结 盟 旗 下 同 我 国 建 交 ， 并 对 英 国 产 业 坚 决 没 收 ， 将 其 转 为 民 族 资 产 。 可 他 也 就 到 此 为 止 了 — — 斯 蒂 文 森 的 一 党 制 构 型 与 其 内 部 的 贪 污 腐 败 “ 盛 况 ” 只 会 叫 人 想 到 扎 伊 尔 的 大 酋 长 ， 被 塞 拉 利 昂 回 收 的 民 族 资 产 也 事 实 上 成 为 了 “ 家 天 下 ” 私 产 。 与 此 同 时 ， 当 局 的 胃 口 竟 仍 无 法 满 足 ， 甚 至 将 黑 手 伸 向 了 教 育 与 医 疗 经 费 。 这 只 会 让 塞 拉 利 昂 全 国 变 成 个 火 药 桶 — — 也 就 在 今 天 ， 斯 蒂 文 森 的 对 头 塞 拉 利 昂 人 民 党 借 势 发 起 了 全 国 暴 乱 。 后 者 成 功 聚 集 了 大 量 对 斯 蒂 文 森 部 族 不 满 的 门 德 人 ， 并 背 靠 英 美 国 家 的 支 持 预 备 起 事 。 如 果 我 们 想 要 在 钻 石 之 国 立 足 的 话 ， 现 在 也 是 时 候 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 4)
		{
			button_text[0] = " 支 持 斯 蒂 文 森 维 持 国 内 秩 序 ， 打 击 新 殖 民 主 义 者 的 代 理 人 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 必 要 染 黑 自 己 的 手";
		}
		if (GlobalScript.inst.gameState.data[56] >= 3)
		{
			button_text[1] = " 支 持 塞 拉 利 昂 人 民 党 ， 并 协 助 其 发 动 反 政 府 起 义 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 真 的 要 支 持 外 国 代 理 人 摘 桃 子 吗 ？";
		}
		button_text[2] = " 充 耳 不 闻";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 树 丛 恶 魔";
		a.allcountries[107].Gosstroy = 0;
		a.allcountries[107].SubGosstroy = 13;
		switch (result_num)
		{
		case 0:
			text = " 我 们 坚 决 控 诉 塞 拉 利 昂 反 对 派 不 识 大 体 并 有 意 识 充 当 外 国 势 力 侵 略 走 卒 的 行 为 ， 并 向 政 府 送 去 了 援 助 。 斯 蒂 文 森 对 此 表 示 相 当 感 动 ， 并 顺 势 同 中 国 建 立 了 合 作 伙 伴 关 系 。 虽 说 塞 拉 利 昂 的 暴 乱 迅 速 演 变 为 了 双 边 无 差 别 攻 击 的 大 规 模 流 血 事 件 ， 可 斯 蒂 文 森 还 是 能 够 背 靠 我 国 援 助 ， 以 及 自 己 同 军 方 的 关 系 牢 牢 掌 握 大 局 。 国 际 社 会 对 此 则 表 示 “ 高 度 关 切 ” 并 附 上 谴 责 — — 当 然 也 就 到 此 为 止 了 。";
			a.allcountries[107].Torg = true;
			a.data[8] -= 20;
			a.influencePRC += 15;
			a.data[6] += 15;
			a.empires[0].relations -= 100;
			break;
		case 1:
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.data[22] -= 40;
			a.empires[0].relations += 50;
			a.empires[1].relations -= 10;
			a.allcountries[107].parts[0] = true;
			text = " 我 们 坚 决 控 诉 塞 拉 利 昂 政 府 的 暴 行 并 积 极 声 援 反 对 派 ， 这 最 终 导 致 塞 拉 利 昂 政 府 决 定 同 我 国 断 交 并 押 注 苏 联 — — 前 提 是 在 他 们 还 能 保 住 政 权 的 情 况 下 。 得 到 了 中 国 支 持 的 人 民 党 得 以 将 暴 乱 升 级 为 全 国 范 围 的 起 义 ， 塞 拉 利 昂 完 全 陷 入 了 无 差 别 屠 杀 的 血 海 … … 我 们 需 要 赶 在 一 切 无 法 挽 回 前 尽 快 行 动 ！";
			a.ingamewars[77] = new War().Name("塞 拉 利 昂 内 战").Attacker("人 民 党").Defender("政 府 军")
				.AttackerInfluence(200)
				.DefenderInfluence(800)
				.TickTime(40)
				.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
			break;
		case 2:
			text = " 塞 拉 利 昂 的 暴 乱 迅 速 演 变 为 了 双 边 无 差 别 攻 击 的 大 规 模 流 血 事 件 ， 可 斯 蒂 文 森 还 是 能 够 背 靠 自 己 同 军 方 的 关 系 牢 牢 掌 握 大 局 。 国 际 社 会 对 此 则 表 示 “ 高 度 关 切 ” 并 附 上 谴 责 — — 当 然 也 就 到 此 为 止 了 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
