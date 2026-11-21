using EventsForDLC;
using UnityEngine;

public class Event932 : EventsSecond
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
		name = " 民 主 的 故 乡 — — 第 三 幕";
		if (a.resultOfEvents[93] != 0)
		{
			text = " 泛 希 腊 社 会 主 义 运 动 与 新 民 主 党 的 竞 争 仍 在 继 续 。 P A S O K 仍 然 希 望 维 持 民 主 社 会 主 义 ， 并 开 始 修 订 宪 法 ， 将 希 腊 彻 底 转 向 议 会 共 和 制 ， 左 翼 选 民 的 壮 大 使 得 他 们 仍 有 希 望 执 政 ； 新 民 主 党 继 续 支 持 着 他 们 的 亲 西 方 的 自 由 主 义 政 策 。 当 然 ， 希 腊 共 产 党 的 影 响 力 较 大 ， 但 希 腊 的 左 翼 生 态 位 已 经 被 P A S O K 占 领 ， 他 们 已 不 具 有 掌 权 希 望 。 国 际 形 势 的 变 化 将 会 影 响 此 次 大 选 … …";
		}
		else
		{
			text = " 希 腊 左 翼 联 盟 对 左 翼 改 革 的 程 度 产 生 了 矛 盾 ， 内 部 各 党 对 施 政 方 针 已 经 有 了 不 同 的 见 解 ， 此 前 的 共 同 执 政 的 情 况 大 概 已 经 无 法 维 持 了 。 希 腊 共 产 党 希 望 进 行 更 加 深 入 的 社 会 主 义 改 革 ， 并 结 束 中 立 政 策 ， 与 各 个 社 会 主 义 国 家 加 深 合 作 ； 泛 希 腊 社 会 主 义 运 动 则 希 望 搞 “ 民 主 的 社 会 主 义 ” ， 拒 绝 “ 极 权 主 义 ” 并 维 持 中 立 ； 联 盟 中 力 量 较 小 的 派 系 ， 如 希 腊 共 产 党 （ 国 内 派 ） 希 望 遵 循 欧 洲 共 产 主 义 ， 但 是 他 们 没 有 单 独 参 选 或 执 政 的 基 础 。 当 然 ， 右 翼 政 党 也 可 能 借 助 左 翼 分 裂 的 背 景 而 卷 土 重 来 。 在 大 选 的 背 景 下 ， 左 翼 联 盟 是 否 还 能 存 续 ？";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.data[9] >= 40)
		{
			button_text[0] = " 支 持 希 腊 共 产 党";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 足 够 的 力 量";
		}
		if (GlobalScript.inst.gameState.data[9] >= 40)
		{
			button_text[1] = " 支 持 泛 希 腊 社 会 主 义 运 动";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 足 够 的 力 量";
		}
		if (GlobalScript.inst.gameState.data[9] >= 40)
		{
			button_text[2] = " 支 持 新 民 主 党";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 没 有 足 够 的 力 量";
		}
		button_text[3] = " 不 闻 不 问";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 民 主 的 故 乡 — — 第 三 幕";
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (result_num == 0)
		{
			num++;
		}
		if (result_num == 1)
		{
			num2++;
		}
		if (result_num == 2)
		{
			num3++;
		}
		if (a.allcountries[21].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[85].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[86].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[87].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[92].Gosstroy == 1)
		{
			num++;
		}
		if (a.empires[1].power >= a.empires[0].power)
		{
			num++;
		}
		if (a.allcountries[4].Gosstroy == 1 && !a.allcountries[4].prosov)
		{
			num++;
		}
		if (a.allcountries[2].Gosstroy == 0)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
		{
			num--;
		}
		if (a.empires[1].power < a.empires[0].power)
		{
			num--;
		}
		if (GlobalScript.inst.gameState.allcountries[20].parts[0])
		{
			num -= 2;
		}
		if (GlobalScript.inst.gameState.allcountries[84].SubGosstroy == 9)
		{
			num--;
		}
		if (a.resultOfEvents[67] == 3)
		{
			num--;
		}
		if (a.resultOfEvents[93] == 0)
		{
			num++;
		}
		if (a.allcountries[21].Gosstroy == 2)
		{
			num2++;
		}
		if (a.allcountries[85].Gosstroy == 2)
		{
			num2++;
		}
		if (a.allcountries[86].Gosstroy == 2)
		{
			num2++;
		}
		if (a.allcountries[87].Gosstroy == 2)
		{
			num2++;
		}
		if (a.allcountries[92].Gosstroy == 2)
		{
			num2++;
		}
		if (a.empires[1].power >= a.empires[0].power)
		{
			num2++;
		}
		if (a.allcountries[4].Gosstroy == 2)
		{
			num2++;
		}
		if (a.allcountries[15].SubGosstroy == 11)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[20].parts[0])
		{
			num2--;
		}
		if (a.allcountries[21].isSocEU)
		{
			num2 += 114514;
		}
		if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
		{
			num2--;
		}
		if (a.resultOfEvents[93] == 0)
		{
			num2 += 2;
		}
		if (a.allcountries[21].Gosstroy == 3 || a.allcountries[21].Gosstroy == 0)
		{
			num3++;
		}
		if (a.allcountries[85].Gosstroy == 3 || a.allcountries[85].Gosstroy == 0)
		{
			num3++;
		}
		if (a.allcountries[86].Gosstroy == 3 || a.allcountries[86].Gosstroy == 0)
		{
			num3++;
		}
		if (a.allcountries[87].Gosstroy == 3 || a.allcountries[87].Gosstroy == 0)
		{
			num3++;
		}
		if (a.allcountries[92].Gosstroy == 3 || a.allcountries[92].Gosstroy == 0)
		{
			num3++;
		}
		if (a.empires[1].power < a.empires[0].power)
		{
			num3++;
		}
		if (a.allcountries[4].prosov)
		{
			num3++;
		}
		if (a.resultOfEvents[67] == 3)
		{
			num3++;
		}
		if (GlobalScript.inst.gameState.allcountries[20].parts[0])
		{
			num3++;
		}
		if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
		{
			num3 += 2;
		}
		if (GlobalScript.inst.gameState.allcountries[84].SubGosstroy == 9)
		{
			num3++;
		}
		if (num >= num2 && num >= num3)
		{
			if (GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.empires[1].now_leader != 7)
			{
				text = " 在 世 界 共 产 主 义 运 动 的 发 展 以 及 此 前 希 共 在 左 翼 联 盟 中 积 累 的 了 充 足 实 力 的 情 况 下 ， 希 共 得 以 脱 离 左 翼 联 盟 ， 单 独 赢 得 选 举 。 新 政 府 决 定 立 即 带 领 希 腊 向 社 会 主 义 过 渡 。 希 腊 迅 速 向 苏 东 阵 营 靠 拢 ， 并 同 他 们 展 开 了 深 度 合 作 。";
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[45].prosov = true;
				GlobalScript.inst.gameState.empires[1].leaders[4].support++;
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.empires[1].power += 50;
				GlobalScript.inst.gameState.allcountries[45].cw = false;
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && result_num == 0)
			{
				text = " 在 世 界 共 产 主 义 运 动 的 发 展 以 及 此 前 希 共 在 左 翼 联 盟 中 积 累 的 了 充 足 实 力 的 情 况 下 ， 希 共 得 以 脱 离 左 翼 联 盟 ， 单 独 赢 得 选 举 。 他 们 谴 责 苏 联 戈 尔 巴 乔 夫 背 叛 了 马 列 主 义 的 原 则 ， 这 导 致 希 共 中 支 持 戈 尔 巴 乔 夫 的 革 新 派 脱 党 。 希 腊 开 始 向 我 们 靠 拢 ， 他 们 在 我 们 的 支 持 下 于 多 个 毛 派 组 织 达 成 了 和 解 并 将 党 组 织 重 组 为 希 腊 革 命 共 产 党 ， 并 开 始 带 领 国 家 向 社 会 主 义 过 渡 。";
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[45].proprc = true;
				GlobalScript.inst.gameState.allcountries[45].Torg = true;
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.allcountries[45].cw = false;
				a.influencePRC += 50;
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 7 && result_num == 0)
			{
				text = " 在 世 界 共 产 主 义 运 动 的 发 展 以 及 此 前 希 共 在 左 翼 联 盟 中 积 累 的 了 充 足 实 力 的 情 况 下 ， 希 共 得 以 脱 离 左 翼 联 盟 ， 单 独 赢 得 选 举 。 他 们 谴 责 苏 联 背 叛 了 马 列 主 义 的 原 则 ， 这 导 致 希 共 中 支 持 雅 科 夫 列 夫 的 革 新 派 脱 党 。 希 腊 开 始 向 我 们 靠 拢 ， 他 们 在 我 们 的 支 持 下 于 多 个 毛 派 组 织 达 成 了 和 解 并 将 党 组 织 重 组 为 希 腊 革 命 共 产 党 ， 并 开 始 带 领 国 家 向 社 会 主 义 过 渡 。";
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[45].proprc = true;
				GlobalScript.inst.gameState.allcountries[45].Torg = true;
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.allcountries[45].cw = false;
				a.influencePRC += 50;
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && result_num != 0)
			{
				text = " 在 世 界 共 产 主 义 运 动 的 发 展 以 及 此 前 希 共 在 左 翼 联 盟 中 积 累 的 了 充 足 实 力 的 情 况 下 ， 希 共 得 以 脱 离 左 翼 联 盟 ， 单 独 赢 得 选 举 。 他 们 谴 责 苏 联 戈 尔 巴 乔 夫 背 叛 了 马 列 主 义 的 原 则 ， 这 导 致 希 共 中 支 持 戈 尔 巴 乔 夫 的 革 新 派 脱 党 。 希 共 决 定 与 社 会 主 义 展 开 合 作 ， 并 带 领 希 腊 向 社 会 主 义 过 渡 。 我 们 将 可 以 利 用 这 个 机 会 同 他 们 合 作 。";
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.allcountries[45].cw = false;
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 7 && result_num != 0)
			{
				text = " 在 世 界 共 产 主 义 运 动 的 发 展 以 及 此 前 希 共 在 左 翼 联 盟 中 积 累 的 了 充 足 实 力 的 情 况 下 ， 希 共 得 以 脱 离 左 翼 联 盟 ， 单 独 赢 得 选 举 。 他 们 谴 责 苏 联 背 叛 了 马 列 主 义 的 原 则 ， 这 导 致 希 共 中 支 持 雅 科 夫 列 夫 的 革 新 派 脱 党 。 希 共 决 定 与 社 会 主 义 展 开 合 作 ， 并 带 领 希 腊 向 社 会 主 义 过 渡 。 我 们 将 可 以 利 用 这 个 机 会 同 他 们 合 作 。";
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.allcountries[45].cw = false;
			}
		}
		else if (num2 >= num && num2 >= num3)
		{
			if (a.resultOfEvents[93] == 0)
			{
				text = " 左 翼 联 盟 驱 逐 了 希 腊 共 产 党 ， 并 设 法 使 联 盟 稳 定 下 来 ， 让 温 和 左 翼 能 够 继 续 带 领 希 腊 进 行 民 主 的 社 会 主 义 改 革 。 他 们 将 与 各 个 西 欧 温 和 左 翼 政 府 加 强 合 作 。 希 腊 将 继 续 维 持 中 立 政 策 。 除 左 翼 希 共 之 外 的 左 翼 政 党 仍 然 维 持 着 希 腊 的 议 会 霸 权 。 希 共 虽 被 驱 逐 ， 但 仍 有 卷 土 重 来 的 力 量 。";
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
			}
			else
			{
				if (GlobalScript.inst.gameState.allcountries[45].Gosstroy == 2)
				{
					text = " 泛 希 腊 社 会 主 义 运 动 获 得 了 连 任 ， 他 们 将 着 手 修 改 宪 法 ， 减 少 总 统 的 权 力 。 政 府 还 将 推 行 “ 稳 定 计 划 ” ， 控 制 公 共 支 出 ， 尝 试 降 低 日 益 增 大 的 福 利 开 支 。 并 在 外 交 上 在 东 西 方 之 间 保 持 中 立 。 泛 希 腊 社 会 主 义 运 动 继 续 着 他 们 的 掌 权 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[45].Gosstroy == 3)
				{
					text = " 泛 希 腊 社 会 主 义 运 动 赢 得 了 选 举 ， 他 们 将 着 手 修 改 宪 法 ， 减 少 总 统 的 权 力 。 政 府 还 将 推 行 “ 稳 定 计 划 ” ， 控 制 公 共 支 出 ， 尝 试 降 低 日 益 增 大 的 福 利 开 支 。 并 在 外 交 上 在 东 西 方 之 间 保 持 中 立 。 泛 希 腊 社 会 主 义 运 动 继 续 着 他 们 的 掌 权 。";
				}
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[45].cw = false;
				if (a.allcountries[21].isSocEU)
				{
					text += "||鉴 于 执 政 政 策 和 欧 洲 社 会 主 义 联 盟 理 念 的 相 似 性 ， 泛 希 腊 社 会 主 义 运 动 向 欧 社 联 委 员 会 递 交 了 申 请 ， 很 快 ， 希 腊 也 加 入 了 社 会 主 义 联 盟 。";
					GlobalScript.inst.gameState.allcountries[45].isSocEU = true;
				}
			}
		}
		else if (num3 >= num2 && num3 >= num)
		{
			text = " 右 翼 在 欧 洲 的 优 势 使 得 新 民 主 党 抓 住 了 左 翼 的 颓 势 ， 成 功 获 得 了 大 选 胜 利 。 他 们 将 顺 应 新 自 由 主 义 的 浪 潮 ， 开 展 自 由 化 改 革 ， 与 西 方 更 深 度 地 融 合 。";
			GlobalScript.inst.gameState.allcountries[45].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 12;
			GlobalScript.inst.gameState.allcountries[45].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[45].cw = false;
			a.allcountries[45].Vyshi = true;
			if (a.allcountries[0].isEU)
			{
				a.allcountries[45].isEU = true;
			}
			if (a.allcountries[0].isNATO)
			{
				a.allcountries[45].isNATO = true;
			}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
