using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event667 : EventsSecond
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
		name = " “ 正 义 事 业 ” 行 动";
		if (a.resultOfEvents[665] == 0)
		{
			text = string.Format("1977 年9 月7 日 ， 美 国 总 统 吉 米 · 卡 特 与 巴 拿 马 事 实 上 的 领 导 人 奥 马 尔 · 托 里 霍 斯 将 军 签 署 了 《 卡 特 — — 托 里 霍 斯 条 约 》 。 其 主 要 条 款 规 定 美 国 同 意 归 还 其 管 理 的 领 土 ， 控 制 运 河 的 运 营 ， 关 闭 军 事 基 地 并 从 巴 拿 马 撤 出 所 有 美 国 士 兵 。 《 托 里 霍 斯 - 卡 特 条 约 》 商 定 了 在2000 年 之 前 移 交 巴 拿 马 运 河 所 有 方 面 的 时 间 表 。 但 是 ， 它 通 过 附 加 条 约 规 定 了 运 河 的 联 合 防 御 ， 从 而 为 军 事 干 预 提 供 了 可 能 性 。 美 国 国 内 多 方 ， 特 别 是 共 和 党 内 部 ， 对 卡 特 总 统 签 署 的 条 约 表 示 不 满 。||随 着 共 和 党 人 登 台 执 政 ， 是 时 候 重 新 考 虑 对 托 里 霍 斯 政 权 的 关 系 了 。 美 国 政 府 强 烈 谴 责 托 里 霍 斯 政 权 侵 犯 人 权 ， 庇 护 毒 贩 ， 支 持 共 产 主 义 ， 以 及 在1984 年 的 大 选 上 作 弊 。 很 快 ， 导 火 索 就 被 点 燃 了 ： 美 国 士 兵 罗 伯 兹 · 帕 斯 因 为 和 巴 拿 马 军 队 在 运 河 区 发 生 了 冲 突 ， 在 纠 纷 中 走 火 被 打 死 。 随 后 ， 美 国 总 统 批 准 了 入 侵 巴 拿 马 的 军 事 行 动 ， 代 号 “ 正 义 事 业 ” 。", '\n');
		}
		else
		{
			text = string.Format("1977 年9 月7 日 ， 美 国 总 统 吉 米 · 卡 特 与 巴 拿 马 事 实 上 的 领 导 人 奥 马 尔 · 托 里 霍 斯 将 军 签 署 了 《 卡 特 — — 托 里 霍 斯 条 约 》 。 其 主 要 条 款 规 定 美 国 同 意 归 还 其 管 理 的 领 土 ， 控 制 运 河 的 运 营 ， 关 闭 军 事 基 地 并 从 巴 拿 马 撤 出 所 有 美 国 士 兵 。 《 托 里 霍 斯 - 卡 特 条 约 》 商 定 了 在2000 年 之 前 移 交 巴 拿 马 运 河 所 有 方 面 的 时 间 表 。 但 是 ， 它 通 过 附 加 条 约 规 定 了 运 河 的 联 合 防 御 ， 从 而 为 军 事 干 预 提 供 了 可 能 性 。 美 国 国 内 多 方 ， 特 别 是 共 和 党 内 部 ， 对 卡 特 总 统 签 署 的 条 约 表 示 不 满 。||诺 列 加 参 与 贩 毒 是 不 争 的 事 实 庇 护 ， 因 此 美 国 攻 击 的 点 在 于 其 威 胁 美 国 公 民 人 权 ， 以 及 在1984 年 的 大 选 上 作 弊 。 很 快 ， 导 火 索 就 被 点 燃 了 ： 美 国 士 兵 罗 伯 兹 · 帕 斯 因 为 和 巴 拿 马 军 队 在 运 河 区 发 生 了 冲 突 ， 在 纠 纷 中 走 火 被 打 死 。 随 后 ， 美 国 总 统 批 准 了 入 侵 巴 拿 马 的 军 事 行 动 ， 代 号 “ 正 义 事 业 ” 。", '\n');
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = "我 们 坚 决 支 持 巴 拿 马 政 府";
		button_text[1] = "战 争 就 这 样 爆 发 了";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " “ 正 义 事 业 ” 行 动";
		GlobalScript.inst.gameState.allcountries[141].parts[0] = true;
		int num = 0;
		for (int i = 138; i < 150; i++)
		{
			if (a.allcountries[i].proprc)
			{
				num++;
			}
		}
		if (a.allcountries[152].proprc)
		{
			num++;
		}
		if (a.resultOfEvents[665] == 0)
		{
			switch (result_num)
			{
			case 0:
				text = string.Format("外 交 部 发 言 人 强 烈 谴 责 了 美 国 对 巴 拿 马 的 军 事 干 涉 。 “ 中 国 过 去 被 人 欺 辱 的 历 史 历 历 在 目 ， 我 们 绝 不 会 再 允 许 同 样 的 事 情 发 生 ， 我 们 一 贯 支 持 巴 拿 马 人 民 的 抗 争 ， 哪 怕 面 对 的 是 美 帝 国 也 是 如 此 ！ ” 我 国 向 巴 拿 马 无 偿 提 供 了 一 批 军 事 装 备 ， 并 指 挥 我 国 军 事 教 官 参 与 战 斗 。 “ 人 民 战 斗 团 ” 也 被 紧 急 动 员 起 来 ， 老 弱 妇 孺 都 拿 起 枪 。 古 巴 也 派 出 了 志 愿 者 反 对 入 侵 。||很 快 ， 美 国 空 军 轰 炸 了 巴 拿 马 城 和 科 隆 ， 美 军 部 队 越 过 了 运 河 区 ， 帝 国 主 义 的 战 争 从 没 变 过 … …", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
				a.empires[0].relations -= 100;
				a.ingamewars[84] = new War().Name("美 国 入 侵 巴 拿 马").Attacker("巴 拿 马").Defender("美 国")
					.AttackerInfluence(150 + num * 20)
					.DefenderInfluence(850 - num * 20)
					.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
				break;
			case 1:
				text = string.Format("很 快 ， 美 国 空 军 轰 炸 了 巴 拿 马 城 和 科 隆 ， 美 军 部 队 越 过 了 运 河 区 ， 帝 国 主 义 的 战 争 从 没 变 过 … …", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
				a.ingamewars[84] = new War().Name("美 国 入 侵 巴 拿 马").Attacker("巴 拿 马").Defender("美 国")
					.AttackerInfluence(50 + num * 20)
					.DefenderInfluence(950 - num * 20)
					.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
				break;
			}
			if (result_num == 5)
			{
				text = "";
			}
			return;
		}
		int num2 = 0;
		if (a.allcountries[138].SubGosstroy == 10)
		{
			num2 = 100;
		}
		switch (result_num)
		{
		case 0:
			text = string.Format("外 交 部 发 言 人 强 烈 谴 责 了 美 国 对 巴 拿 马 的 军 事 干 涉 。 “ 中 国 过 去 被 人 欺 辱 的 历 史 历 历 在 目 ， 我 们 绝 不 会 再 允 许 同 样 的 事 情 发 生 ， 我 们 一 贯 支 持 巴 拿 马 人 民 的 抗 争 ， 哪 怕 面 对 的 是 美 帝 国 也 是 如 此 ！ ” 我 国 向 巴 拿 马 无 偿 提 供 了 一 批 军 事 装 备 ， 希 望 能 有 所 帮 助 。 诺 列 加 感 谢 了 我 国 的 雪 中 送 炭 。{1}||很 快 ， 美 国 空 军 轰 炸 了 巴 拿 马 城 和 科 隆 ， 美 军 部 队 越 过 了 运 河 区 ， 帝 国 主 义 的 战 争 从 没 变 过 … …", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], (a.allcountries[138].SubGosstroy == 10) ? "奥 乔 亚 也 不 愿 意 坐 看 自 己 的 战 友 就 此 垮 台 ， 他 宣 布 派 出 一 支1 万 人 的 部 队 抵 抗 美 国 入 侵 ， 古 巴 飞 机 也 在 紧 急 调 往 该 国 。" : null);
			a.allcountries[141].Gosstroy = 0;
			a.allcountries[141].SubGosstroy = 10;
			a.allcountries[141].Torg = true;
			a.allcountries[141].proprc = true;
			a.ingamewars[84] = new War().Name("美 国 入 侵 巴 拿 马").Attacker("巴 拿 马").Defender("美 国")
				.AttackerInfluence(150 + num * 20 + num2)
				.DefenderInfluence(850 - num * 20 - num2)
				.TickTime(4)
				.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			break;
		case 1:
			text = string.Format("很 快 ， 美 国 空 军 轰 炸 了 巴 拿 马 城 和 科 隆 ， 美 军 部 队 越 过 了 运 河 区 ， 帝 国 主 义 的 战 争 从 没 变 过 … …", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.allcountries[141].Gosstroy = 0;
			a.allcountries[141].SubGosstroy = 10;
			a.allcountries[141].Torg = true;
			a.allcountries[141].proprc = true;
			a.ingamewars[84] = new War().Name("美 国 入 侵 巴 拿 马").Attacker("巴 拿 马").Defender("美 国")
				.AttackerInfluence(50 + num * 20 + num2)
				.DefenderInfluence(950 - num * 20 - num2)
				.TickTime(4)
				.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
