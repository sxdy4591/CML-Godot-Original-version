using EventsForDLC;
using UnityEngine;

public class Event70 : EventsSecond
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
		name = " 周 恩 来 继 承 人 的 问 题";
		text = string.Concat(new string[4]
		{
			GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
			" ",
			GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
			" 同 志 ， 多 亏 了 你 的 努 力 ， 我 们 能 够 像 毛 主 席 遗 赠 给 我 们 的 那 样 ， 继 续 朝 着 一 个 光 明 的 共 产 主 义 未 来 前 进 ， 改 革 派 所 有 试 图 动 摇 我 们 的 制 度 ， 破 坏 社 会 主 义 成 就 ， 使 中 国 走 上 资 本 主 义 的 道 路 的 尝 试 都 失 败 了 。 然 而 ， 他 们 中 的 许 多 人 仍 然 有 足 够 的 影 响 力 ， 并 继 续 传 播 他 们 的 修 正 主 义 思 想 ， 必 须 对 此 做 些 什 么 。 你 们 最 激 进 的 支 持 者 建 议 ， 他 们 不 应 该 与 修 正 主 义 者 共 处 一 室 ， 而 是 应 该 直 接 逮 捕 他 们 的 领 导 人 ， 发 动 反 对 改 革 派 的 运 动 ， 但 是 党 和 人 民 不 太 可 能 赞 成 这 种 专 横 的 行 为 ， 你 们 可 以 尝 试 在 党 的 会 议 室 里 解 决 一 切 问 题 。 并 且 我 们 必 须 决 定 如 何 对 待 温 和 派 — — 毛 泽 东 死 后 ， 他 们 大 多 数 支 持 改 革 派 ， 但 现 在 有 些 人 开 始 犹 豫 … …"
		});
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		int num = 0;
		int num2 = 0;
		Politic[] politics = GlobalScript.inst.gameState.politics;
		foreach (Politic politic in politics)
		{
			if (politic.traits[0] == 1 || politic.traits[0] == 2)
			{
				num += politic.power;
			}
			else if (politic.traits[0] == 0)
			{
				num2 += politic.power;
			}
		}
		button_text[0] = " 什 么 也 不 做 。 不 同 的 观 点 是 民 主 的 保 证";
		if (GlobalScript.inst.gameState.data[1] >= 800 && num2 > num)
		{
			button_text[1] = " 在 党 的 全 会 上 攻 击 改 革 派 和 温 和 派";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 改 革 派 不 会 轻 易 的 放 弃 ！";
		}
		if (GlobalScript.inst.gameState.data[1] >= 700 && GlobalScript.inst.gameState.data[90] != 0)
		{
			button_text[2] = " 争 取 温 和 派 的 支 持 ， 在 全 会 上 攻 击 改 革 派";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 温 和 派 不 会 支 持 我 们";
		}
		button_text[3] = " 逮 捕 改 革 派 的 领 导 人 ， 并 发 动 一 场 运 动 反 对 他 们 的 支 持 者 。 这 是 毛 主 席 的 意 志 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 周 恩 来 继 承 人 的 问 题";
		switch (result_num)
		{
		case 0:
		{
			text = " 改 革 派 继 续 任 职 ， 这 损 害 了 你 们 的 事 业 和 你 们 在 人 民 和 中 国 共 产 党 中 的 声 誉 。 左 翼 本 身 对 你 的 软 弱 不 满 意 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 100;
			party_change[3] = 0.25f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 0)
				{
					politic4.loyality -= 100;
				}
				else if (politic4.traits[0] == 2)
				{
					politic4.power += 100;
				}
			}
			break;
		}
		case 1:
		{
			text = " 在 今 年2 月 召 开 的 中 共 中 央 五 中 全 会 上 ， 邓 小 平 、 叶 剑 英 、 赵 紫 阳 等 老 改 革 家 因 修 正 主 义 立 场 、 谋 求 资 产 阶 级 自 由 化 和 背 叛 毛 泽 东 思 想 而 受 到 严 厉 的 批 评 。 尽 管 有 激 烈 的 讨 论 与 争 辩 ， 但 在 全 会 结 束 之 后 ， 改 革 派 和 一 些 温 和 派 人 士 的 党 政 职 务 上 都 被 革 除 了 ， 他 们 失 去 了 任 何 对 政 局 的 影 响 力 。 同 样 的 命 运 降 临 在 他 们 所 提 拔 的 基 层 改 革 派 身 上 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[4] -= 50;
			GlobalScript.inst.gameState.data[6] += 40;
			if (GlobalScript.inst.gameState.modifies[14].active)
			{
				GlobalScript.inst.gameState.KillPerson(12);
				GlobalScript.inst.gameState.modifies[14].active = false;
			}
			party_change[1] = 0.45f;
			party_change[0] = 0.3f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.power += 150;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.power -= 150;
					politic2.loyality -= 200;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.power -= 350;
					politic2.loyality -= 200;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.power -= 250;
					politic2.loyality -= 200;
				}
			}
			break;
		}
		case 2:
		{
			text = " 在 今 年2 月 召 开 的 中 共 中 央 五 中 全 会 上 ， 邓 小 平 、 叶 剑 英 、 赵 紫 阳 等 老 改 革 家 因 修 正 主 义 立 场 、 谋 求 资 产 阶 级 自 由 化 和 背 叛 毛 泽 东 思 想 而 受 到 严 厉 的 批 评 。 此 外 ， 这 些 指 责 甚 至 被 曾 经 与 改 革 派 团 结 一 致 的 温 和 派 所 支 持 ， 这 要 感 谢 你 们 实 现 了 他 们 所 渴 望 的 冻 结 文 化 大 革 命 和 对 毛 泽 东 的 重 新 评 价 。 全 会 的 结 果 是 ， 改 革 派 的 干 部 被 革 除 了 党 政 职 务 ， 他 们 失 去 了 任 何 对 政 局 的 影 响 力 。 同 样 的 命 运 降 临 在 他 们 所 提 拔 的 基 层 改 革 派 身 上 。";
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.data[4] -= 50;
			GlobalScript.inst.gameState.data[6] += 30;
			if (GlobalScript.inst.gameState.modifies[14].active)
			{
				GlobalScript.inst.gameState.KillPerson(12);
				GlobalScript.inst.gameState.modifies[14].active = false;
			}
			party_change[0] = 0.3f;
			party_change[1] = 0.45f;
			party_change[2] = 0.24f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 2)
				{
					politic3.power -= 350;
					politic3.loyality -= 200;
				}
				else if (politic3.traits[0] == 3)
				{
					politic3.power -= 250;
					politic3.loyality -= 200;
				}
			}
			break;
		}
		case 3:
		{
			text = " 根 据 你 的 命 令 ， 改 革 派 的 领 导 人 被 以 捏 造 的 罪 名 逮 捕 ， 并 被 永 久 地 从 政 治 中 除 名 。 此 后 ， 在 我 们 控 制 的 媒 体 的 积 极 参 与 下 ， 改 革 派 思 想 和 被 压 迫 的 改 革 派 的 支 持 者 开 始 受 到 诋 毁 ， 党 开 始 清 除 他 们 。 人 民 和 党 自 己 也 很 不 高 兴 ， 认 为 这 是 文 化 大 革 命 事 件 的 重 演 ， 但 我 们 摆 脱 了 我 们 的 反 对 者 。";
			GlobalScript.inst.gameState.data[1] -= 200;
			GlobalScript.inst.gameState.data[4] += 150;
			GlobalScript.inst.gameState.data[3] -= 200;
			GlobalScript.inst.gameState.data[6] += 50;
			if (GlobalScript.inst.gameState.modifies[14].active)
			{
				GlobalScript.inst.gameState.KillPerson(12);
				GlobalScript.inst.gameState.modifies[14].active = false;
			}
			party_change[0] = 0.3f;
			party_change[1] = 0.45f;
			GlobalScript.inst.gameState.party_ideology[2] -= (int)((float)GlobalScript.inst.gameState.party_ideology[2] * 0.09f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power += 150;
				}
				else if (politic.traits[0] == 1)
				{
					politic.power -= 50;
					politic.loyality -= 30;
				}
				else if (politic.traits[0] == 2)
				{
					politic.power -= 350;
					politic.loyality -= 30;
				}
				else if (politic.traits[0] == 3)
				{
					politic.power -= 250;
					politic.loyality -= 300;
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
