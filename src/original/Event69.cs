using EventsForDLC;
using UnityEngine;

public class Event69 : EventsSecond
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
		name = " 另 一 个 四 人 帮 ？";
		text = string.Concat(new string[4]
		{
			GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
			" ",
			GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
			" 同 志 ， 在 你 的 努 力 下 ， 我 们 终 于 铲 除 了 文 化 大 革 命 的 遗 毒 ， 我 们 的 国 家 正 在 走 向 光 明 的 市 场 经 济 未 来 ！ 然 而 ， 仍 然 有 一 些 人 不 同 意 这 样 的 发 展 ， 并 竭 尽 全 力 抗 议 市 场 化 政 策 的 实 施 ， 破 坏 了 我 们 良 好 的 改 革 倡 议 。 这 些 人 主 要 是 保 守 的 毛 派 ， 由 四 名 党 内 高 层 领 导 ， 他 们 拒 绝 进 一 步 的 改 革 。 通 过 打 击 他 们 和 他 们 的 支 持 者 ， 我 们 可 以 让 更 多 的 权 力 掌 握 在 改 革 派 手 中 。 此 外 ， 在 那 些 没 有 保 守 派 的 地 方 ， 我 们 将 有 可 能 促 进 对 改 革 的 积 极 支 持 者 的 产 生 ， 毕 竟 这 些 改 革 已 在 民 众 和 官 僚 中 受 到 欢 迎 。"
		});
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 什 么 也 不 做 。 不 同 的 观 点 是 民 主 的 保 证";
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
		if (GlobalScript.inst.gameState.data[1] >= 650 && num > num2)
		{
			button_text[1] = " 在 党 的 全 会 上 攻 击 保 守 派 ， 支 持 改 革 派";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 中 国 共 产 党 可 不 会 陪 你 玩 过 家 家";
		}
		if (GlobalScript.inst.gameState.data[1] >= 600 && num > num2)
		{
			button_text[2] = " 在 党 的 全 会 上 攻 击 保 守 派";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 中 国 共 产 党 不 会 让 你 轻 易 的 消 灭 他 们";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 另 一 个 四 人 帮 ？";
		switch (result_num)
		{
		case 0:
		{
			text = " 保 守 派 继 续 担 任 他 们 的 职 务 ， 这 将 破 坏 你 们 的 改 革 ， 损 坏 人 民 和 中 国 共 产 党 的 利 益 。 改 革 派 自 己 也 对 你 的 软 弱 感 到 不 满 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] -= 70;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.power += 100;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality -= 150;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality -= 150;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.loyality -= 150;
				}
			}
			break;
		}
		case 1:
		{
			text = " 在 今 年2 月 召 开 的 中 共 中 央 五 中 全 会 上 ， 汪 东 兴 、 纪 登 奎 、 陈 锡 联 和 吴 德 因 “ 极 左 倾 向 ” 而 受 到 批 评 ， 他 们 被 指 控 在 文 化 大 革 命 中 镇 压 人 民 ， 并 被 命 名 为 “ 小 四 人 帮 ” 。 全 会 的 结 果 是 ， 四 人 都 被 革 除 了 党 政 职 务 ， 他 们 已 经 没 有 任 何 对 于 政 局 的 影 响 力 了 。 同 样 的 命 运 也 降 临 在 保 守 派 的 底 层 干 部 中 。 他 们 的 位 置 已 经 被 你 忠 实 的 支 持 者 所 替 换 了 。";
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.data[92] += 20;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.is_party_enabled[0] = false;
			GlobalScript.inst.gameState.is_party_ally[0] = false;
			GlobalScript.inst.gameState.party_ideology[1] -= (int)((float)GlobalScript.inst.gameState.party_ideology[1] * 0.45f);
			GlobalScript.inst.gameState.is_party_enabled[4] = true;
			party_change[3] = 0.45f;
			party_change[4] = 0.24f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.power -= 200;
					politic3.loyality -= 250;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.power += 80;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.power += 100;
				}
				else if (politic3.traits[0] == 3)
				{
					politic3.power += 150;
				}
			}
			break;
		}
		case 2:
		{
			text = " 在 今 年2 月 召 开 的 中 共 中 央 五 中 全 会 上 ， 汪 东 兴 、 纪 登 奎 、 陈 锡 联 和 吴 德 因 “ 极 左 倾 向 ” 而 受 到 批 评 ， 他 们 被 指 控 在 文 化 大 革 命 中 镇 压 人 民 ， 并 被 命 名 为 “ 小 四 人 帮 ” 。 全 会 的 结 果 是 ， 四 人 都 被 革 除 了 党 政 职 务 ， 他 们 已 经 没 有 任 何 对 于 政 局 的 影 响 力 了 。 同 样 的 命 运 也 降 临 在 保 守 派 的 底 层 干 部 中 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[92] += 10;
			GlobalScript.inst.gameState.data[4] += 30;
			GlobalScript.inst.gameState.data[6] -= 15;
			GlobalScript.inst.gameState.is_party_enabled[0] = false;
			GlobalScript.inst.gameState.is_party_ally[0] = false;
			GlobalScript.inst.gameState.party_ideology[1] -= (int)((float)GlobalScript.inst.gameState.party_ideology[1] * 0.45f);
			party_change[3] = 0.45f;
			party_change[4] = 0.15f;
			party_change[2] = 0.27f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power -= 350;
					politic.loyality -= 300;
				}
				else if (politic.traits[0] == 1)
				{
					politic.power += 100;
				}
				else if (politic.traits[0] == 2)
				{
					politic.power += 120;
				}
				else if (politic.traits[0] == 3)
				{
					politic.power += 80;
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
