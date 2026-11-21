using EventsForDLC;
using UnityEngine;

public class Event54 : EventsSecond
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
		name = " 改 革 开 放 ： 引 资";
		text = " 按 照 改 革 开 放 政 策 的 政 策 框 架 下 ， 吸 引 外 资 是 重 要 的 一 环 。 改 革 派 提 议 在 沿 海 地 区 建 立 几 个 经 济 特 区 ， 为 外 国 投 资 者 提 供 税 收 的 优 惠 、 最 低 限 度 的 国 家 控 制 和 其 他 的 政 策 优 惠 ， 让 他 们 可 以 在 那 里 建 立 自 己 的 企 业 ， 并 投 资 于 合 资 企 业 。 然 而 ， 除 了 建 立 经 济 特 区 之 外 ， 更 激 进 的 领 导 人 提 议 ， 通 过 建 立 合 资 企 业 制 度 ， 进 而 全 面 开 放 经 济 ， 外 国 可 以 在 我 们 的 国 有 企 业 内 投 资 ， 以 换 取 利 润 分 成 。 显 而 易 见 的 ， 第 二 种 选 择 的 盈 利 能 力 更 强 ， 但 党 内 的 温 和 派 ， 甚 至 一 些 改 革 派 的 人 也 批 评 它 的 措 施 过 于 激 进 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 推 迟 这 事";
		button_text[1] = " 开 放 经 济 特 区";
		if (GlobalScript.inst.gameState.data[56] >= 2)
		{
			button_text[2] = " 开 放 经 济 特 区 并 对 外 资 开 放 部 分 企 业";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 毛 主 席 的 棺 材 板 压 不 住 了 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 改 革 开 放 ： 引 资";
		switch (result_num)
		{
		case 0:
		{
			text = " 尽 管 有 许 多 抗 议 和 对 减 缓 改 革 的 指 责 ， 然 而" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 将 投 资 的 问 题 推 迟 一 段 时 间 ， 因 为 “ 这 样 我 们 才 能 制 定 出 关 于 解 决 这 一 问 题 的 最 佳 方 案 。 ”";
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[4] += 80;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 1)
				{
					politic2.loyality -= 200;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality -= 200;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.loyality -= 200;
				}
			}
			break;
		}
		case 1:
		{
			text = " 新 政 府 宣 布 沿 海 部 分 城 市 逐 步 对 外 开 放 。 广 东 省 的 深 圳 、 珠 海 、 汕 头 和 福 建 省 的 厦 门 将 很 快 开 放 为 经 济 特 区 ， 同 时 整 个 海 南 省 将 成 为 经 济 特 区 。 美 国 和 西 欧 国 家 对 这 一 决 定 表 示 热 烈 欢 迎 ， 西 方 大 型 企 业 的 负 责 人 也 表 示 热 烈 欢 迎 。";
			GlobalScript.inst.gameState.data[89] = 3;
			GlobalScript.inst.gameState.data[8] += 30;
			GlobalScript.inst.gameState.data[92] += 10;
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.data[57] -= 30;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			party_change[2] = 0.8f;
			party_change[3] = 0.8f;
			GlobalScript.inst.gameState.SEZ = true;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 1)
				{
					politic3.power += 120;
					politic3.loyality += 100;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.power += 120;
					politic3.loyality += 150;
				}
			}
			break;
		}
		case 2:
		{
			text = " 尽 管 一 些 改 革 派 和 温 和 派 提 出 抗 议 ， 新 政 府 最 终 还 是 决 定 向 外 资 敞 开 中 国 经 济 的 大 门 。 按 照 计 划 ， 将 很 快 在 广 东 省 的 深 圳 、 珠 海 、 汕 头 ， 福 建 省 的 厦 门 开 设 经 济 特 区 ， 并 且 ， 整 个 海 南 省 也 被 划 为 经 济 特 区 。 同 时 ， 许 多 国 有 企 业 也 按 照 合 资 计 划 对 外 资 开 放 。 尽 管 外 国 公 司 只 能 在 经 济 特 区 直 接 开 展 业 务 ， 但 讨 论 外 资 即 将 迅 速 深 入 我 们 经 济 已 经 成 为 可 能 ， 因 为 西 方 对 我 们 的 转 型 抱 着 极 大 的 热 情 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[92] += 20;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.empires[0].relations += 150;
			GlobalScript.inst.gameState.data[8] += 50;
			GlobalScript.inst.gameState.data[89] = 3;
			GlobalScript.inst.gameState.data[57] -= 70;
			party_change[3] = 0.5f;
			party_change[4] = 0.8f;
			GlobalScript.inst.gameState.SEZ = true;
			GlobalScript.inst.gameState.party_ideology[2] -= (int)((float)GlobalScript.inst.gameState.party_ideology[2] * 0.09f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power -= 100;
					politic.loyality -= 250;
				}
				else if (politic.traits[0] == 1)
				{
					politic.power -= 50;
					politic.loyality -= 80;
				}
				else if (politic.traits[0] == 2)
				{
					politic.power += 100;
					politic.loyality += 50;
				}
				else if (politic.traits[0] == 3)
				{
					politic.power += 150;
					politic.loyality += 200;
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
