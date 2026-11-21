using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event5 : EventsSecond
{
	private GameState a;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 民 众 不 满";
		if ((a.modifies[3].active || a.data[4] < 500) && a.modifies[6].active)
		{
			text = " 人 民 对 你 政 策 不 满 ， 有 关 党 中 央 出 了 修 正 主 义 ， 你 在 走 资 本 主 义 道 路 的 传 言 甚 嚣 尘 上 。 在 全 国 范 围 内 举 行 了 大 规 模 集 会 ， 在 广 场 搭 起 帐 篷 营 地 ， 分 发 传 单 ， 甚 至 冲 击 地 方 政 府 建 筑 。 来 自 不 同 团 体 的 抗 议 者 对 你 政 府 不 同 的 方 面 不 满 ， 但 一 致 要 求 中 央 回 到 社 会 主 义 正 道 ， 甚 至 有 些 要 求 你 下 台 。";
		}
		else
		{
			text = " 人 民 对 你 政 策 不 满 ， 在 全 国 范 围 内 举 行 了 大 规 模 集 会 ， 在 广 场 搭 起 帐 篷 营 地 ， 分 发 传 单 ， 甚 至 冲 击 地 方 政 府 建 筑 。 来 自 不 同 团 体 的 抗 议 者 对 你 政 府 不 同 的 方 面 不 满 ， 但 一 致 要 求 体 制 民 主 化 ， 以 限 制 你 在 国 家 政 治 的 影 响 力 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 向 人 民 群 众 喊 话 ， 安 抚 他 们";
		if ((a.modifies[3].active || a.data[4] < 500) && a.modifies[6].active)
		{
			if (GlobalScript.inst.gameState.data[16] > 11 || GlobalScript.inst.gameState.data[15] > 6 || GlobalScript.inst.gameState.data[50] > 24)
			{
				button_text[1] = " 进 行 社 会 主 义 化 改 革";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 已 经 正 走 在 社 会 主 义 的 大 道 上 了";
			}
		}
		else if (GlobalScript.inst.gameState.data[15] != 9 || GlobalScript.inst.gameState.data[17] != 19)
		{
			button_text[1] = " 同 意 民 主 化";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 已 经 不 能 再 进 一 步 地 民 主 化 了";
		}
		if (GlobalScript.inst.gameState.data[22] >= 100)
		{
			button_text[2] = " 驱 散 抗 议 者";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 军 方 不 会 支 持 我 们";
		}
		if (GlobalScript.inst.gameState.data[3] > 500)
		{
			button_text[3] = " 向 忠 诚 的 人 民 寻 求 帮 助";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 人 民 已 经 受 够 了 大 鸣 大 放 ， 你 想 复 辟 文 革 余 毒 ？";
		}
		if (GlobalScript.inst.gameState.data[9] >= 150)
		{
			button_text[4] = " 利 用 特 勤 ， 从 内 部 分 化 瓦 解 抗 议";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 民 众 不 满";
		if (result_num == 0)
		{
			if ((a.modifies[3].active || a.data[4] < 500) && a.modifies[6].active)
			{
				if (GlobalScript.inst.gameState.data[3] > 700 && GlobalScript.inst.gameState.data[1] >= 500)
				{
					text = " 你 亲 自 与 全 国 各 地 的 抗 议 者 进 行 了 交 谈 。 你 承 诺 将 尽 一 切 努 力 改 变 政 策 ， 考你 承 诺 将 尽 一 切 努 力 改 变 政 策 ， 废 除 一 切 修 正 主 义 改 革 ， 重 新 会 到 马 列 毛 主 义 正 轨 上 （ 不 过 ， 你 并 不 急 于 执 行 ） 。 看 来 你 已 经 成 功 地 说 服 了 人 民 ， 抗 议 活 动 正 在 慢 慢 地 减 少 。";
					GlobalScript.inst.gameState.data[3] -= 150;
					GlobalScript.inst.gameState.data[4] -= 150;
					GlobalScript.inst.gameState.data[1] -= 100;
					if (!GlobalScript.inst.gameState.is_party_enabled[1])
					{
						GlobalScript.inst.gameState.is_party_enabled[1] = true;
					}
					if (GlobalScript.inst.gameState.data[15] >= 6 && GlobalScript.inst.gameState.data[15] <= 7)
					{
						int num = 0;
						for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
						{
							if (GlobalScript.inst.gameState.party_ideology[i] <= 0)
							{
								GlobalScript.inst.gameState.party_ideology[i] = 0;
							}
							if (GlobalScript.inst.gameState.is_party_ally[i] && i != 1)
							{
								GlobalScript.inst.gameState.is_party_ally[i] = false;
							}
							if (GlobalScript.inst.gameState.is_party_enabled[i] && i != 1 && GlobalScript.inst.gameState.party_number[i] > 0)
							{
								num += GlobalScript.inst.gameState.party_number[i] / 2;
								GlobalScript.inst.gameState.party_number[i] -= GlobalScript.inst.gameState.party_number[i] / 2;
								GlobalScript.inst.gameState.party_ideology[i] -= GlobalScript.inst.gameState.party_number[i] / 2;
								num += GlobalScript.inst.gameState.party_number[i] / 4;
								GlobalScript.inst.gameState.party_number[i] -= GlobalScript.inst.gameState.party_number[i] / 4;
								GlobalScript.inst.gameState.party_ideology[i] -= GlobalScript.inst.gameState.party_number[i] / 4;
							}
							else if (!GlobalScript.inst.gameState.is_party_enabled[i])
							{
								GlobalScript.inst.gameState.is_party_enabled[i] = true;
							}
							GlobalScript.inst.gameState.data[53] = 0;
						}
						GlobalScript.inst.gameState.party_number[1] += num;
						GlobalScript.inst.gameState.party_ideology[1] += num;
						GlobalScript.inst.gameState.data[125] = 0;
					}
					else if (GlobalScript.inst.gameState.data[15] < 9)
					{
						int[] data = GlobalScript.inst.gameState.data;
						int num2 = 15;
						ref int reference = ref data[num2];
						int num3 = data[num2];
						reference = num3 + 1;
					}
					else if (GlobalScript.inst.gameState.data[17] < 19)
					{
						int[] data2 = GlobalScript.inst.gameState.data;
						int num4 = 17;
						ref int reference2 = ref data2[num4];
						int num5 = data2[num4];
						reference2 = num5 + 1;
					}
				}
				else
				{
					text = " 你 亲 自 与 全 国 各 地 的 抗 议 者 进 行 了 交 谈 。 你 承 诺 将 尽 一 切 努 力 改 变 政 策 ， 考你 承 诺 将 尽 一 切 努 力 改 变 政 策 ， 废 除 一 切 修 正 主 义 改 革 ， 重 新 会 到 马 列 毛 主 义 正 轨 上（ 不 过 ， 你 并 不 急 于 执 行 ） 。 不 过 看 来 人 民 已 经 对 你 的 承 诺 感 到 了 厌 倦 ， 他 们 对 你 态 度 冷 漠 并 要 求 你 直 接 辞 职 。 对 你 失 去 了 信 心 的 党 最 后 决 定 罢 免 你 并 将 你 逮 捕 ， 之 后 他 们 重 新 组 织 了 一 个 新 的 政 府 领 导 全 国 并 开 始 筹 划 全 国 选 举 ， 而 你 只 能 在 监 狱 里 蹲 着 。";
					GlobalScript.inst.gameState.data[1] = 0;
					GlobalScript.inst.gameState.data[3] = 0;
					load_scene_after_click = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[3] > 700 && GlobalScript.inst.gameState.data[1] >= 500)
			{
				text = " 你 亲 自 与 全 国 各 地 的 抗 议 者 进 行 了 交 谈 。 你 承 诺 将 尽 一 切 努 力 改 变 政 策 ， 考 虑 所 有 公 民 的 利 益 ， 并 建 立 真 正 的 民 主 机 制 。 （ 不 过 ， 你 并 不 急 于 执 行 ） 。 看 来 你 已 经 成 功 地 说 服 了 人 民 ， 抗 议 活 动 正 在 慢 慢 地 减 少 。";
				GlobalScript.inst.gameState.data[3] -= 150;
				GlobalScript.inst.gameState.data[4] -= 150;
				GlobalScript.inst.gameState.data[1] -= 100;
				if (!GlobalScript.inst.gameState.is_party_enabled[1])
				{
					GlobalScript.inst.gameState.is_party_enabled[1] = true;
				}
				if (GlobalScript.inst.gameState.data[15] >= 6 && GlobalScript.inst.gameState.data[15] <= 7)
				{
					int num6 = 0;
					for (int j = 0; j < GlobalScript.inst.gameState.is_party_ally.Length; j++)
					{
						if (GlobalScript.inst.gameState.party_ideology[j] <= 0)
						{
							GlobalScript.inst.gameState.party_ideology[j] = 0;
						}
						if (GlobalScript.inst.gameState.is_party_ally[j] && j != 1)
						{
							GlobalScript.inst.gameState.is_party_ally[j] = false;
						}
						if (GlobalScript.inst.gameState.is_party_enabled[j] && j != 1 && GlobalScript.inst.gameState.party_number[j] > 0)
						{
							num6 += GlobalScript.inst.gameState.party_number[j] / 2;
							GlobalScript.inst.gameState.party_number[j] -= GlobalScript.inst.gameState.party_number[j] / 2;
							GlobalScript.inst.gameState.party_ideology[j] -= GlobalScript.inst.gameState.party_number[j] / 2;
							num6 += GlobalScript.inst.gameState.party_number[j] / 4;
							GlobalScript.inst.gameState.party_number[j] -= GlobalScript.inst.gameState.party_number[j] / 4;
							GlobalScript.inst.gameState.party_ideology[j] -= GlobalScript.inst.gameState.party_number[j] / 4;
						}
						else if (!GlobalScript.inst.gameState.is_party_enabled[j])
						{
							GlobalScript.inst.gameState.is_party_enabled[j] = true;
						}
						GlobalScript.inst.gameState.data[53] = 0;
					}
					GlobalScript.inst.gameState.party_number[1] += num6;
					GlobalScript.inst.gameState.party_ideology[1] += num6;
					GlobalScript.inst.gameState.data[125] = 0;
				}
				else if (GlobalScript.inst.gameState.data[15] < 9)
				{
					int[] data3 = GlobalScript.inst.gameState.data;
					int num7 = 15;
					ref int reference3 = ref data3[num7];
					int num8 = data3[num7];
					reference3 = num8 + 1;
				}
				else if (GlobalScript.inst.gameState.data[17] < 19)
				{
					int[] data4 = GlobalScript.inst.gameState.data;
					int num9 = 17;
					ref int reference4 = ref data4[num9];
					int num10 = data4[num9];
					reference4 = num10 + 1;
				}
			}
			else
			{
				text = " 你 在 全 国 直 播 的 情 况 下 亲 自 与 北 京 的 抗 议 者 进 行 了 交 谈 ， 并 承 诺 尽 一 切 努 力 改 变 政 策 ， 考 虑 到 所 有 公 民 的 利 益 ， 最 后 建 立 真 正 的 民 主 机 制 （ 不 过 ， 你 并 不 急 于 执 行 ） 。 不 过 看 来 人 民 已 经 对 你 的 承 诺 感 到 了 厌 倦 ， 他 们 对 你 态 度 冷 漠 并 要 求 你 直 接 辞 职 。 对 你 失 去 了 信 心 的 党 最 后 决 定 罢 免 你 并 将 你 逮 捕 ， 之 后 他 们 重 新 组 织 了 一 个 新 的 政 府 领 导 全 国 并 开 始 筹 划 全 国 选 举 ， 而 你 只 能 在 监 狱 里 蹲 着 。";
				GlobalScript.inst.gameState.data[1] = 0;
				GlobalScript.inst.gameState.data[3] = 0;
				load_scene_after_click = true;
			}
		}
		if (result_num == 1)
		{
			if ((a.modifies[3].active || a.data[4] < 500) && a.modifies[6].active)
			{
				if (GlobalScript.inst.gameState.data[16] > 11 || GlobalScript.inst.gameState.data[15] > 6 || GlobalScript.inst.gameState.data[50] > 24)
				{
					text = " 你 亲 自 与 全 国 各 地 的 抗 议 者 进 行 了 交 谈 . 你 承 诺 将 尽 一 切 努 力 改 变 政 策 ， 废 除 一 切 修 正 主 义 改 革 ， 重 新 会 到 马 列 毛 主 义 正 轨 上 ， 修 正 主 义 政 策 被 废 除 . 人 民 受 到 鼓 舞 ， 尽 管 有 些 人 仍 然 怀 疑 你 的 政 策 只 是 暂 时 对 革 命 力 量 的 妥 协 ， 但 是 大 部 分 民 众 已 经 感 到 满 意 。";
					GlobalScript.inst.gameState.data[1] -= 50;
					GlobalScript.inst.gameState.data[3] += 100;
					GlobalScript.inst.gameState.data[6] -= 50;
					if (GlobalScript.inst.gameState.data[16] > 11)
					{
						GlobalScript.inst.gameState.data[16]--;
					}
					if (GlobalScript.inst.gameState.data[15] > 6)
					{
						GlobalScript.inst.gameState.data[15]--;
					}
					if (GlobalScript.inst.gameState.data[50] > 24)
					{
						GlobalScript.inst.gameState.data[50]--;
					}
					Politic[] politics = GlobalScript.inst.gameState.politics;
					for (int k = 0; k < politics.Length; k++)
					{
						politics[k].loyality -= 100;
					}
				}
			}
			else
			{
				text = " 你 亲 自 与 全 国 各 地 的 抗 议 者 进 行 了 交 谈 。 你 承 诺 将 尽 一 切 努 力 改 变 政 策 ， 考 虑 到 所 有 公 民 的 利 益 ， 并 建 立 真 正 的 民 主 机 制 ， 一 些 民 主 机 制 即 将 开 始 实 行 。 人 民 受 到 鼓 舞 ， 但 与 此 同 时 ， 批 评 的 浪 潮 也 因 为 新 获 的 自 由 而 涌 来 。";
				GlobalScript.inst.gameState.data[1] -= 50;
				GlobalScript.inst.gameState.data[3] += 100;
				GlobalScript.inst.gameState.data[6] -= 50;
				if (GlobalScript.inst.gameState.data[15] != 9)
				{
					GlobalScript.inst.gameState.data[15] = 9;
				}
				else
				{
					GlobalScript.inst.gameState.data[17] = 19;
				}
				Politic[] politics2 = GlobalScript.inst.gameState.politics;
				for (int l = 0; l < politics2.Length; l++)
				{
					politics2[l].loyality -= 100;
				}
			}
		}
		if (result_num == 2)
		{
			text = " 军 队 最 终 执 行 了 你 的 命 令 并 用 装 甲 车 辆 驱 散 了 城 市 内 的 抗 议 者 ， 双 方 都 有 伤 亡 者 出 现 。 当 然 ， 这 种 行 为 使 你 被 国 际 社 会 所 谴 责 。";
			GlobalScript.inst.gameState.data[4] -= 150;
			GlobalScript.inst.gameState.data[22] -= 100;
			GlobalScript.inst.gameState.data[6] += 50;
			GlobalScript.inst.gameState.data[113] = 9;
			Politic[] politics3 = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics3)
			{
				if (politic.traits[0] == 3)
				{
					politic.loyality -= 100;
				}
			}
		}
		if (result_num == 3)
		{
			text = " 通 过 媒 体 直 播 ， 你 呼 吁 支 持 你 的 人 保 护 你 的 成 果 不 被 美 国 和 苏 联 资 助 的 叛 徒 的 破 坏 。 他 们 立 刻 组 织 起 了 集 会 ， 你 的 支 持 者 与 抗 议 者 大 打 出 手 且 大 部 分 人 被 逮 捕 。 当 街 头 抗 议 尘 埃 落 定 ， 抗 议 者 败 下 阵 来 四 处 逃 窜 ， 你 的 支 持 者 向 着 天 安 门 前 进 。";
			GlobalScript.inst.gameState.data[4] -= 200;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.data[3] -= 300;
			Politic[] politics3 = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics3)
			{
				if (politic2.traits[0] == 3 || politic2.traits[0] == 2)
				{
					politic2.loyality -= 100;
				}
			}
		}
		if (result_num == 4)
		{
			text = " 国 安 部 从 事 着 通 常 的 业 务 — — 贿 赂 某 人 ， 消 灭 某 人 ， 因 为 国 家 利 益 我 们 会 把 各 种 组 织 和 个 人 从 其 内 部 瓦 解 。 反 对 派 只 能 在 内 部 斗 争 中 衰 弱 ， 抗 议 变 成 了 没 有 任 何 策 略 的 集 会 ， 很 快 就 会 干 涸 。";
			GlobalScript.inst.gameState.data[9] -= 150;
			GlobalScript.inst.gameState.data[4] -= 150;
			GlobalScript.inst.gameState.data[3] += 100;
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 1;
			SceneManager.LoadScene("Ending");
		}
	}
}
