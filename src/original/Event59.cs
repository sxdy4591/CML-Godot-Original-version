using EventsForDLC;
using UnityEngine;

public class Event59 : EventsSecond
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
		name = " 经 济 联 盟";
		text = " 主 席 同 志 ！ 考 虑 到 国 际 舞 台 上 的 形 式 ， 一 些 党 员 提 议 组 织 一 个 苏 联 领 导 的 经 济 同 盟 ， 即 经 互 会 ， 和 欧 洲 人 的 欧 共 体 的 替 代 物 ， 以 继 续 我 们 在 亲 中 国 家 中 扩 大 影 响 力 ， 深 化 贸 易 和 经 济 纽 带 的 政 策 。 但 是 ， 政 治 局 的 一 些 成 员 觉 得 这 样 做 太 过 匆 忙 和 激 进 ， 也 缺 乏 考 虑 ， 建 议 推 迟 此 事 ， 等 待 一 个 更 好 的 时 机 。 然 而 忘 记 与 苏 联 的 争 议 ， 加 入 经 济 互 助 委 员 会 也 许 是 最 好 的 选 择 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 无 视 该 建 议";
		if (!GlobalScript.inst.gameState.allcountries[15].cw && !GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[1] = " 建 立 经 济 同 盟 （ 需 要15 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 还 没 准 备 好 （ 需 要15 百 万 元 预 算 ）";
		}
		if (GlobalScript.inst.gameState.relres && !GlobalScript.inst.gameState.allcountries[15].cw && GlobalScript.inst.gameState.data[56] <= 1 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[51].Torg)
		{
			button_text[2] = " 加 入 经 互 会";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 和 修 正 主 义 者 没 有 谈 判 ！";
		}
		if (GlobalScript.inst.gameState.war <= 0 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].isOVD && !GlobalScript.inst.gameState.allcountries[1].econ && !GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.allcountries[1].Vyshi && !GlobalScript.inst.gameState.allcountries[15].cw)
		{
			button_text[3] = " 加 入 不 结 盟 运 动";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 他 们 不 喜 欢 你";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 经 济 联 盟";
		switch (result_num)
		{
		case 0:
			text = " 什 么 都 没 有 发 生 ， 让 我 们 希 望 这 只 是 为 了 更 好 。";
			break;
		case 1:
		{
			text = " 今 天 ， 在 我 国 的 倡 议 下 ， 在 北 京 举 行 了 一 场 闭 门 经 济 会 议 ， 会 议 上 正 式 通 过 了 关 于 建 立 经 济 合 作 组 织 （ECO ） 的 决 议 ， 其 目 的 在 与 扩 展 中 国 友 好 国 家 间 的 贸 易 和 经 济 往 来 。 新 联 盟 的 成 员 有 中 国";
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.influencePRC += 30;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[8] -= 150;
			GlobalScript.inst.gameState.allcountries[1].econ = true;
			GlobalScript.inst.gameState.allcountries[1].soc_stab = 1000;
			for (int j = 7; j < 53; j++)
			{
				if (j != 52 && j != 35 && j != 24 && j != 25 && j != 40 && j != 30 && j != 14 && j != 13 && j != 36 && j != 44 && GlobalScript.inst.gameState.allcountries[j].proprc && !GlobalScript.inst.gameState.allcountries[j].Vyshi && !GlobalScript.inst.gameState.allcountries[j].prosov)
				{
					GlobalScript.inst.gameState.allcountries[j].soc_stab = 1000;
					text = text + ", " + GlobalScript.inst.gameState.allcountries[j].name;
					GlobalScript.inst.gameState.allcountries[j].econ = true;
				}
			}
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality += 100;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality += 100;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.loyality += 100;
				}
			}
			break;
		}
		case 2:
		{
			text = " 中 国 继 续 奉 行 “ 与 苏 联 重 新 建 立 关 系 ” 的 方 针 ， 申 请 加 入 经 济 互 助 委 员 会 。 根 据 这 一 设 想 ， 这 项 倡 议 应 能 恢 复 和 加 强 在 “ 苏 中 分 裂 ” 期 间 被 割 裂 的 中 国 和 社 会 主 义 国 家 之 间 的 经 济 联 系 。 为 此 ， 召 开 了 一 次 特 别 会 议 ， 中 国 被 接 纳 为 本 组 织 正 式 成 员 。 党 内 最 激 进 的 成 员 “ 带 着 敌 意 迈 出 了 这 一 步 ” ， 称 之 为 “ 对 苏 修 的 纵 容 ” ， 但 现 在 我 们 与 苏 联 的 关 系 比 以 往 任 何 时 候 都 要 好 。 不 能 说 美 国 对 我 们 外 交 政 策 的 方 向 的 变 化 很 满 意 。 然 而 ， 现 在 的 社 会 主 义 阵 营 比 以 往 任 何 时 候 都 要 强 大 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.influencePRC -= 30;
			GlobalScript.inst.gameState.empires[1].relations += 200;
			GlobalScript.inst.gameState.empires[0].relations -= 200;
			GlobalScript.inst.gameState.empires[1].power += 30;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.allcountries[1].stab = 1;
			GlobalScript.inst.gameState.allcountries[1].isSEV = true;
			if (GlobalScript.inst.gameState.data[60] == 0)
			{
				GlobalScript.inst.gameState.allcountries[20].proprc = false;
				GlobalScript.inst.gameState.allcountries[20].econ = false;
				GlobalScript.inst.gameState.allcountries[20].Torg = false;
				GlobalScript.inst.gameState.allcountries[20].okb = false;
			}
			GlobalScript.inst.gameState.allcountries[52].proprc = false;
			GlobalScript.inst.gameState.allcountries[52].econ = false;
			GlobalScript.inst.gameState.allcountries[52].okb = false;
			Country[] allcountries = GlobalScript.inst.gameState.allcountries;
			foreach (Country country in allcountries)
			{
				if (country.econ && (country.prosov || country.sovalliance || country.proprc || country.Gosstroy == 1 || (country.Gosstroy == 2 && !country.usalliance && !country.Vyshi)))
				{
					country.econ = false;
					country.isSEV = true;
				}
				else
				{
					country.econ = false;
				}
			}
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 2)
				{
					politic.loyality -= 200;
				}
				else if (politic.traits[0] == 3)
				{
					politic.loyality -= 200;
				}
			}
			break;
		}
		case 3:
			text = " 中 国 政 府 向 不 结 盟 运 动 提 出 加 入 申 请 ， 并 不 出 意 料 的 以 多 数 票 被 接 纳 。 如 果 动 用 了 军 事 手 段 解 决 争 端 ， 我 们 将 被 谴 责 并 剥 夺 会 员 国 资 格 。 战 略 中 立 允 许 我 们 在 苏 联 和 美 国 间 游 走 ， 接 受 来 自 两 边 超 级 大 国 的 政 策 倾 斜 ， 这 对 我 们 来 说 是 有 利 的 。";
			GlobalScript.inst.gameState.data[1] -= 300;
			GlobalScript.inst.gameState.data[8] -= 20;
			GlobalScript.inst.gameState.influencePRC -= 20;
			GlobalScript.inst.gameState.allcountries[15].cw = true;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
