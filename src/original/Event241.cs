using EventsForDLC;
using UnityEngine;

public class Event241 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 新 时 代 ， 新 面 孔";
		text = " 华 国 锋 同 志 ， 在 我 们 扫 清 新 赫 鲁 晓 夫 反 革 命 集 团 的 伟 大 胜 利 之 后 ， 陷 入 了 一 个 尴 尬 的 问 题 。 我 们 缺 少 能 堪 大 任 的 干 部 。 对 此 ， 有 人 建 议 我 们 提 拔 来 自 山 西 的 “ 农 民 总 理 ” 陈 永 贵 ， 以 及 工 人 孙 健 和 张 国 权 。 这 样 既 保 证 了 极 左 派 对 我 们 的 忠 诚 ， 也 更 好 的 体 现 了 我 们 对 工 农 联 盟 国 家 的 重 视 。||但 是 您 的 同 事 ， 现 在 的 王 副 主 席 给 出 了 另 一 个 解 决 方 案 。 如 您 所 知 ， 他 在 上 海 的 时 期 结 识 了 不 少 志 同 道 合 的 战 友 ， 他 的 方 案 便 是 在 提 拔 上 述 人 选 的 时 候 ， 再 任 命 徐 景 贤 ， 马 天 水 和 王 秀 珍 三 人 。 他 们 的 革 命 热 情 不 可 阻 挡 也 不 可 否 认 。 但 党 内 的 温 和 派 担 心 他 们 的 极 左 倾 向 会 加 速 党 的 分 裂 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 我 们 需 要 新 鲜 血 液 ， 请 这 三 位 同 志 来 喝 一 杯 吧 ！";
		button_text[1] = " 别 忘 了 再 叫 上 那 几 个 上 海 人 ！";
		button_text[2] = " 哦 不 ， 这 还 是 太 危 险 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 新 时 代 ， 新 面 孔";
		switch (result_num)
		{
		case 0:
		{
			text = " 华 国 锋 同 志 亲 自 任 命 了 三 位 新 的 常 务 委 员 ： 来 自 山 西 的 农 民 总 理 陈 永 贵 ， 河 北 工 人 孙 健 和 上 海 工 人 张 国 权 。 在 盛 大 的 宴 席 上 ， 华 国 锋 同 志 亲 自 向 三 位 新 的 委 员 敬 上 一 杯 。 在 委 婉 的 表 达 了 自 己 的 水 平 欠 佳 之 余 ， 表 示 希 望 在 将 来 的 治 国 之 途 中 获 得 三 人 的 支 持 。 三 位 草 根 出 身 的 新 面 孔 表 示 定 不 会 辜 负 毛 主 席 留 下 的 既 定 方 针 ， 把 革 命 进 行 到 底 。 他 们 已 经 确 定 会 出 席 1 9 7 9 的 建 国 三 十 周 年 纪 念 庆 典 。||各 方 对 这 三 位 出 身 简 朴 的 政 治 家 保 持 观 望 。 但 我 们 和 党 内 左 派 的 关 系 得 到 了 改 善 。 一 部 分 温 和 派 成 员 表 示 了 自 己 的 不 满 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] += 100;
			int num3 = 0;
			for (int l = 0; l < GlobalScript.inst.gameState.politics.Length; l++)
			{
				if (GlobalScript.inst.gameState.politics[l].power < GlobalScript.inst.gameState.politics[num3].power && GlobalScript.inst.gameState.politics[l].traits[0] != 0)
				{
					num3 = l;
				}
			}
			a.KillPerson(num3);
			GlobalScript.inst.gameState.politics[num3].name_1 = 10;
			GlobalScript.inst.gameState.politics[num3].name_2 = 49;
			GlobalScript.inst.gameState.politics[num3].age = (byte)(GlobalScript.inst.gameState.data[21] - 1914);
			GlobalScript.inst.gameState.politics[num3].traits[0] = 0;
			GlobalScript.inst.gameState.politics[num3].traits[1] = 4;
			GlobalScript.inst.gameState.politics[num3].traits[2] = 7;
			GlobalScript.inst.gameState.politics[num3].power = 800;
			GlobalScript.inst.gameState.politics[num3].loyality = 800;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality += 80;
				}
				if (politic3.traits[0] == 20)
				{
					politic3.loyality += 100;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.loyality -= 100;
				}
				else if (politic3.traits[0] == 3)
				{
					politic3.loyality -= 150;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality -= 50;
				}
			}
			party_change[0] = 3f;
			party_change[1] = 5f;
			GlobalScript.inst.gameState.event_done[242] = false;
			GlobalScript.inst.gameState.event_done[243] = false;
			break;
		}
		case 1:
		{
			text = " 华 国 锋 同 志 亲 自 任 命 了 三 位 新 的 常 务 委 员 ： 来 自 山 西 的 农 民 总 理 陈 永 贵 ， 河 北 工 人 孙 健 和 上 海 工 人 张 国 权 。 在 盛 大 的 宴 席 上 ， 华 国 锋 同 志 亲 自 向 三 位 新 的 委 员 敬 上 一 杯 。 在 委 婉 的 表 达 了 自 己 的 水 平 欠 佳 之 余 ， 表 示 希 望 在 将 来 的 治 国 之 途 中 获 得 三 人 的 支 持 。 三 位 草 根 出 身 的 新 面 孔 泪 流 满 面 ， 表 示 定 不 会 辜 负 毛 主 席 留 下 的 既 定 方 针 ， 把 革 命 进 行 到 底 。 他 们 已 经 确 定 会 出 席 1 9 7 9 的 建 国 三 十 周 年 纪 念 庆 典 。||同 时 ， 为 了 保 持 和 副 主 席 的 关 系 。 华 国 锋 还 提 拔 了 来 自 上 海 的 三 名 革 命 闯 将 ： 徐 景 贤 ， 马 天 水 和 王 秀 珍 。 这 显 著 增 加 了 极 左 派 在 党 内 的 话 语 权 。 华 国 锋 主 席 也 同 三 人 敬 了 一 杯 ， 三 人 向 他 表 示 不 会 辜 负 毛 主 席 的 期 望 ， 会 尽 力 把 在 上 海 学 习 到 的 经 验 运 用 到 全 国 的 革 命 事 业 里 去 。 这 一 决 策 受 到 了 党 内 极 左 派 ， 尤 其 是 曾 在 上 海 工 作 的 那 一 批 的 欢 迎 ， 他 们 在 京 城 的 力 量 又 一 次 得 到 了 增 长 。||各 方 对 这 三 位 政 治 新 人 保 持 观 望 。 我 们 和 党 内 左 派 的 关 系 得 到 了 改 善 ， 但 我 们 和 温 和 派 与 残 留 的 改 革 派 的 关 系 显 著 降 低 了 。 他 们 也 对 上 海 民 兵 经 验 的 推 广 感 到 担 忧 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] += 100;
			int num = 0;
			for (int j = 0; j < GlobalScript.inst.gameState.politics.Length; j++)
			{
				if (GlobalScript.inst.gameState.politics[j].power < GlobalScript.inst.gameState.politics[num].power && GlobalScript.inst.gameState.politics[j].traits[0] != 0)
				{
					num = j;
				}
			}
			a.KillPerson(num);
			GlobalScript.inst.gameState.politics[num].name_1 = 10;
			GlobalScript.inst.gameState.politics[num].name_2 = 49;
			GlobalScript.inst.gameState.politics[num].age = (byte)(GlobalScript.inst.gameState.data[21] - 1914);
			GlobalScript.inst.gameState.politics[num].traits[0] = 0;
			GlobalScript.inst.gameState.politics[num].traits[1] = 4;
			GlobalScript.inst.gameState.politics[num].traits[2] = 7;
			GlobalScript.inst.gameState.politics[num].power = 800;
			GlobalScript.inst.gameState.politics[num].loyality = 800;
			int num2 = 0;
			for (int k = 0; k < GlobalScript.inst.gameState.politics.Length; k++)
			{
				if (GlobalScript.inst.gameState.politics[k].power < GlobalScript.inst.gameState.politics[num].power && GlobalScript.inst.gameState.politics[k].traits[0] != 0)
				{
					num2 = k;
				}
			}
			a.KillPerson(num2);
			GlobalScript.inst.gameState.politics[num2].name_1 = 43;
			GlobalScript.inst.gameState.politics[num2].name_2 = 54;
			GlobalScript.inst.gameState.politics[num2].age = (byte)(GlobalScript.inst.gameState.data[21] - 1933);
			GlobalScript.inst.gameState.politics[num2].traits[0] = 0;
			GlobalScript.inst.gameState.politics[num2].traits[1] = 4;
			GlobalScript.inst.gameState.politics[num2].traits[2] = 7;
			GlobalScript.inst.gameState.politics[num2].power = 800;
			GlobalScript.inst.gameState.politics[num2].loyality = 800;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
				}
				if (politic2.traits[0] == 20)
				{
					politic2.loyality += 80;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality -= 50;
					politic2.power -= 100;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality -= 100;
					politic2.power -= 100;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.loyality -= 150;
					politic2.power -= 100;
				}
			}
			party_change[0] = 8f;
			party_change[1] = 3f;
			GlobalScript.inst.gameState.event_done[242] = false;
			GlobalScript.inst.gameState.event_done[243] = false;
			break;
		}
		case 2:
		{
			text = " 华 国 锋 主 席 决 定 按 照 既 定 方 针 办 。 也 就 是 什 么 都 不 做 ， 希 望 在 未 来 不 会 酿 成 什 么 大 灾 祸 … …";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.data[4] += 30;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 0)
				{
					politic4.loyality -= 20;
				}
				else if (politic4.traits[0] < 2)
				{
					politic4.loyality += 100;
				}
			}
			party_change[2] = 8f;
			party_change[3] = 3f;
			break;
		}
		case 3:
		{
			text = " 你 说 要 迅 速 消 灭 文 化 大 革 命 的 遗 毒 ， 这 是 党 和 人 民 都 喜 欢 的 。 同 时 ， 您 也 谈 到 了 中 国 经 济 进 一 步 市 场 化 改 革 的 必 要 性 ， 以 及 如 何 逐 步 进 入 世 界 市 场 的 问 题 。 为 此 ， 您 开 始 积 极 推 动 赵 紫 阳 、 邓 小 平 等 老 改 革 家 回 归 ， 使 他 们 回 到 了 副 总 理 的 位 置 。 人 民 在 等 待 着 中 国 的 变 化 ， 但 党 内 的 保 守 派 对 你 的 决 定 表 示 不 满 。";
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.modifies[3].active = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 100;
				}
				if (politic.traits[0] == 20)
				{
					politic.loyality -= 50;
				}
				else if (politic.traits[0] > 1)
				{
					politic.loyality += 100;
				}
			}
			party_change[2] = 3f;
			party_change[3] = 8f;
			party_change[4] = 3f;
			GlobalScript.inst.gameState.data[87] = 4;
			break;
		}
		}
	}
}
