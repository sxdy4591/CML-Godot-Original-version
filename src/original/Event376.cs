using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event376 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[785];
		if (a.allcountries[41].Gosstroy == 1)
		{
			text = " 索 马 里 自 宣 布 独 立 后 ， 便 向 周 边 邻 国 提 出 了 一 系 列 领 土 要 求 。 新 政 府 主 张 建 立 所 谓 的 “ 大 索 马 里 国 ” ， 按 照 计 划 ， 该 国 将 吞 并 全 部 索 马 里 人 聚 居 地 ， 其 中 包 括 一 部 分 原 属 埃 塞 俄 比 亚 、 肯 尼 亚 与 吉 布 提 的 领 土 。 在 1 9 6 9 年 革 命 后 ， 穆 罕 默 德 • 西 亚 德 • 巴 雷 得 以 掌 权 。 他 宣 布 将 在 索 马 里 建 设 社 会 主 义 ， 并 同 苏 联 与 社 会 主 义 阵 营 发 展 经 贸 往 来 。 然 而 ， 巴 雷 并 没 有 放 弃 对 周 边 国 家 的 领 土 野 心 。||在 反 政 变 之 后 ， 双 方 关 系 有 所 改 善 ， 但 这 并 不 妨 碍 巴 雷 推 行 自 己 的 大 索 马 里 理 念 。 索 马 里 试 图 利 用 埃 塞 俄 比 亚 的 混 乱 局 势 ， 并 开 始 支 持 西 索 马 里 解 放 阵 线 。 也 就 在 2 0 世 纪 7 0 年 代 中 期 ， 解 放 阵 线 发 动 了 一 场 旨 在 将 欧 加 登 地 区 从 埃 塞 俄 比 亚 地 区 分 离 ， 并 让 其 并 入 索 马 里 的 武 装 斗 争 。||最 近 ， 索 马 里 军 队 则 已 开 入 了 欧 加 登 。 为 了 打 击 背 叛 自 己 的 埃 塞 俄 比 亚 ， 苏 联 在 冲 突 中 支 持 西 亚 德 · 巴 雷 。 因 此 ， 埃 塞 俄 比 亚 不 得 不 同 我 们 和 美 国 站 在 一 起 。||抉 择 的 时 候 到 了 ， 同 志 。 也 许 我 们 应 当 支 持 埃 塞 俄 比 亚 人 民 ， 作 为 阻 止 苏 联 在 东 非 扩 张 影 响 力 的 前 线 ， 并 为 我 们 在 当 地 寻 求 一 位 真 正 的 盟 友 ？ 又 或 者 ， 我 们 应 当 支 持 索 马 里 ， 从 而 恢 复 我 们 与 社 会 主 义 阵 营 之 间 的 关 系 ？ ";
		}
		else if (a.allcountries[41].proprc)
		{
			text = " 索 马 里 自 宣 布 独 立 后 ， 便 向 周 边 邻 国 提 出 了 一 系 列 领 土 要 求 。 新 政 府 主 张 建 立 所 谓 的 “ 大 索 马 里 国 ” ， 按 照 计 划 ， 该 国 将 吞 并 全 部 索 马 里 人 聚 居 地 ， 其 中 包 括 一 部 分 原 属 埃 塞 俄 比 亚 、 肯 尼 亚 与 吉 布 提 的 领 土 。 在 1 9 6 9 年 革 命 后 ， 穆 罕 默 德 • 西 亚 德 • 巴 雷 得 以 掌 权 。 他 宣 布 将 在 索 马 里 建 设 社 会 主 义 ， 并 同 苏 联 与 社 会 主 义 阵 营 发 展 经 贸 往 来 。 然 而 ， 巴 雷 并 没 有 放 弃 对 周 边 国 家 的 领 土 野 心 。||门 格 斯 图 的 我 行 我 素 和 “ 红 色 恐 怖 ” 极 大 的 打 击 了 埃 塞 俄 比 亚 的 稳 定 ， 依 托 于 我 们 的 援 助 他 才 不 至 于 崩 溃 。 索 马 里 试 图 利 用 埃 塞 俄 比 亚 的 混 乱 局 势 ， 并 开 始 支 持 西 索 马 里 解 放 阵 线 。 也 就 在 2 0 世 纪 7 0 年 代 中 期 ， 解 放 阵 线 发 动 了 一 场 旨 在 将 欧 加 登 地 区 从 埃 塞 俄 比 亚 地 区 分 离 ， 并 让 其 并 入 索 马 里 的 武 装 斗 争 。||最 近 ， 索 马 里 军 队 则 已 开 入 了 欧 加 登 。 为 了 打 击 背 叛 自 己 的 埃 塞 俄 比 亚 ， 苏 联 在 冲 突 中 支 持 西 亚 德 · 巴 雷 。 因 此 ， 埃 塞 俄 比 亚 不 得 不 同 我 们 和 美 国 站 在 一 起 。||抉 择 的 时 候 到 了 ， 同 志 。 也 许 我 们 应 当 支 持 埃 塞 俄 比 亚 人 民 ， 作 为 阻 止 苏 联 在 东 非 扩 张 影 响 力 的 前 线 ， 并 为 我 们 在 当 地 寻 求 一 位 真 正 的 盟 友 ？";
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[786], "\n");
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.allcountries[41].Gosstroy == 1)
		{
			if (a.data[22] >= 50 && a.data[8] + a.data[36] >= 30)
			{
				button_text[0] = string.Format("让 我 们 支 持 埃 塞 俄 比 亚 人 反 抗 苏 联 马 前 卒 （ 需 要 3.0 百 万 {0} 与 5.0 点 {2} ）", GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (a.data[8] + a.data[36] < 30)
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[776], 5f);
			}
			if (a.data[22] >= 50 && a.data[8] + a.data[36] >= 30 && a.resultOfEvents[585] != 2)
			{
				button_text[1] = string.Format(" 与 埃 塞 政 权 断 交 并 支 持 索 马 里 （ 需 要 3.0 百 万 {0} 与 5.0 点 {2} ）", GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (a.data[8] + a.data[36] < 30)
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
			}
			else if (a.data[9] < 150)
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[567], 15f);
			}
			else if (a.data[22] < 50)
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[776], 5f);
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 别 忘 了 我 们 要 做 的 … …";
			}
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[789], "\n");
		}
		else if (a.allcountries[41].proprc)
		{
			if (a.data[22] >= 50 && a.data[8] + a.data[36] >= 30)
			{
				button_text[0] = string.Format("让 我 们 支 持 埃 塞 俄 比 亚 人 反 抗 苏 联 马 前 卒 （ 需 要 3.0 百 万 {0} 与 5.0 点 {2} ）", GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (a.data[8] + a.data[36] < 30)
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[776], 5f);
			}
			Object.Destroy(button[1]);
			button_text[1] = "";
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[789], "\n");
		}
		else
		{
			if (a.data[22] >= 50 && a.data[8] + a.data[36] >= 30)
			{
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[787], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (a.data[8] + a.data[36] < 30)
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[776], 5f);
			}
			if (a.data[22] >= 50 && a.data[8] + a.data[36] >= 30 && a.resultOfEvents[585] != 2)
			{
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[788], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
			}
			else if (a.data[8] + a.data[36] < 30)
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[566], 3f);
			}
			else if (a.data[9] < 150)
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[567], 15f);
			}
			else if (a.data[22] < 50)
			{
				Object.Destroy(button[1]);
				button_text[1] = string.Format(GlobalScript.inst.new_events_text[776], 5f);
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 别 忘 了 我 们 要 做 的 … …";
			}
			button_text[2] = string.Format(GlobalScript.inst.new_events_text[789], "\n");
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[785];
		int num = 0;
		if (a.resultOfEvents[587] == 2)
		{
			num = 100;
		}
		if (a.allcountries[41].Gosstroy == 1)
		{
			if (result_num == 0)
			{
				text = " 我 们 选 择 在 日 益 激 化 的 区 域 冲 突 内 支 持 埃 塞 俄 比 亚 ， 并 向 他 们 送 去 了 武 器 与 相 关 设 备 。 因 此 ， 他 对 我 们 表 示 相 当 感 激 。 在 击 退 了 侵 略 者 后 ， 埃 塞 俄 比 亚 宣 布 发 起 一 场 反 攻 。 然 而 ， 随 着 苏 联 军 事 援 助 和 志 愿 军 的 到 来 ， 战 争 进 程 开 始 放 缓 ， 并 开 始 具 有 明 显 的 阵 地 战 特 征 。 苏 联 和 索 马 里 谴 责 我 们 在 冲 突 中 支 持 社 会 主 义 的 敌 人 埃 塞 俄 比 亚 ， 但 我 们 与 美 国 的 关 系 则 有 所 改 善 。 ";
				a.data[6] += 10;
				a.data[8] -= 30;
				a.data[22] -= 30;
				a.empires[0].power += 10;
				a.empires[0].relations += 120;
				a.empires[1].relations -= 150;
				GlobalScript.inst.gameState.SOV_PRC_PartiesConnection -= 20;
				a.data[1] += 100;
				a.allcountries[41].Torg = true;
				a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(400)
					.DefenderInfluence(600)
					.TickTime(16)
					.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
			}
			if (result_num == 1)
			{
				text = " 就 和 在 社 会 主 义 阵 营 内 的 绝 大 多 数 国 家 一 样 ， 我 们 派 出 了 志 愿 军 用 来 反 抗 埃 塞 俄 比 亚 人 。 因 此 ， 索 马 里 得 以 开 始 一 场 解 放 战 争 ， 对 埃 塞 俄 比 亚 军 队 发 动 全 面 进 攻 。||索 马 里 和 苏 联 对 我 们 的 立 场 表 示 满 意 ， 而 继 续 向 埃 塞 俄 比 亚 提 供 支 持 的 美 国 ， 却 在 区 域 争 街 内 再 度 落 入 劣 势 。";
				a.data[6] += 10;
				a.data[8] -= 30;
				a.data[22] -= 30;
				a.empires[1].power += 10;
				a.empires[1].relations += 120;
				a.empires[0].relations -= 150;
				GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 20;
				a.data[1] += 100;
				GlobalScript.inst.gameState.allcountries[41].Torg = false;
				GlobalScript.inst.gameState.allcountries[42].Torg = true;
				a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(600)
					.DefenderInfluence(400)
					.TickTime(16)
					.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
			}
			if (result_num == 2)
			{
				text = " 在 苏 联 专 家 与 多 国 志 愿 者 抵 达 后 ， 巴 雷 的 局 面 便 扶 摇 直 上 。 战 争 的 态 势 极 大 利 好 索 马 里 ， 他 们 的 胜 利 已 经 是 板 上 钉 钉 的 事 情 了 。";
				a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(550)
					.DefenderInfluence(450)
					.TickTime(16)
					.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
			}
			return;
		}
		if (a.allcountries[41].proprc)
		{
			if (result_num == 0)
			{
				text = "我 们 选 择 在 日 益 激 化 的 区 域 冲 突 内 支 持 埃 塞 俄 比 亚 ， 并 向 他 们 送 去 了 武 器 与 相 关 设 备 。 因 此 ， 他 对 我 们 表 示 相 当 感 激 。 在 击 退 了 侵 略 者 后 ， 埃 塞 俄 比 亚 宣 布 发 起 一 场 反 攻 。 然 而 ， 随 着 苏 联 军 事 援 助 和 志 愿 军 的 到 来 ， 战 争 进 程 开 始 放 缓 ， 并 开 始 具 有 明 显 的 阵 地 战 特 征 。 苏 联 和 索 马 里 谴 责 我 们 在 冲 突 中 支 持 社 会 主 义 的 敌 人 埃 塞 俄 比 亚 ， 但 我 们 与 美 国 的 关 系 则 有 所 改 善 。";
				a.data[6] += 10;
				a.data[8] -= 30;
				a.data[22] -= 30;
				a.empires[0].power += 10;
				a.empires[0].relations += 120;
				a.empires[1].relations -= 150;
				GlobalScript.inst.gameState.SOV_PRC_PartiesConnection -= 20;
				a.data[1] += 100;
				a.allcountries[41].Torg = true;
				a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(400)
					.DefenderInfluence(600)
					.TickTime(16)
					.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
			}
			if (result_num == 1)
			{
				text = string.Format(GlobalScript.inst.new_events_text[791], "\n");
				a.data[6] += 10;
				a.data[8] -= 30;
				a.data[22] -= 30;
				a.empires[1].power += 10;
				a.empires[1].relations += 120;
				a.empires[0].relations -= 150;
				GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 20;
				a.data[1] += 100;
				GlobalScript.inst.gameState.allcountries[41].Torg = false;
				GlobalScript.inst.gameState.allcountries[42].Torg = true;
				a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(550)
					.DefenderInfluence(450)
					.TickTime(16)
					.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
			}
			if (result_num == 2)
			{
				text = " 在 苏 联 专 家 与 多 国 志 愿 者 抵 达 后 ， 巴 雷 的 局 面 便 扶 摇 直 上 。 战 争 的 态 势 极 大 利 好 索 马 里 ， 他 们 的 胜 利 已 经 是 板 上 钉 钉 的 事 情 了 。";
				a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(550)
					.DefenderInfluence(450)
					.TickTime(16)
					.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
			}
			return;
		}
		a.allcountries[42].prosov = false;
		if (result_num == 0)
		{
			text = string.Format(GlobalScript.inst.new_events_text[790], "\n");
			a.data[6] += 10;
			a.data[8] -= 30;
			a.data[22] -= 30;
			a.empires[1].power += 10;
			a.empires[1].relations += 120;
			a.empires[0].relations -= 150;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 20;
			a.data[1] += 100;
			GlobalScript.inst.gameState.allcountries[42].Torg = false;
			GlobalScript.inst.gameState.allcountries[41].Torg = true;
			a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
				.AttackerInfluence(300 + num)
				.DefenderInfluence(700 - num)
				.TickTime(16)
				.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
		}
		if (result_num == 1)
		{
			text = string.Format(GlobalScript.inst.new_events_text[791], "\n");
			a.data[6] += 10;
			a.data[8] -= 30;
			a.data[22] -= 30;
			a.empires[0].power += 10;
			a.empires[0].relations += 120;
			a.empires[1].relations -= 150;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection -= 20;
			a.data[1] += 100;
			a.allcountries[42].Torg = true;
			a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
				.AttackerInfluence(550 + num)
				.DefenderInfluence(450 - num)
				.TickTime(16)
				.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
		}
		if (result_num == 2)
		{
			text = string.Format(GlobalScript.inst.new_events_text[792], "\n");
			a.ingamewars[15] = new War().Name(GlobalScript.inst.new_events_text[793]).Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
				.AttackerInfluence(400 + num)
				.DefenderInfluence(600 - num)
				.TickTime(16)
				.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
		}
	}
}
