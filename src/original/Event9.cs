using EventsForDLC;
using UnityEngine;

public class Event9 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

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
		name = " 西 藏 的 分 离 主 义";
		text = " 在 自 由 主 义 者 和 民 族 主 义 者 的 鼓 励 下 ， 西 藏 自 治 区 居 民 举 行 了 群 众 性 的 要 求 独 立 和 脱 离 中 华 人 民 共 和 国 的 示 威 活 动 ， 并 逐 渐 演 变 为 骚 乱 。 人 们 要 求 从 “1950 年 的 占 领 ” 中 “ 解 放 ” ， 大 多 数 藏 族 人 支 持 他 们 。 然 而 ， 有 些 人 只 是 满 足 于 更 高 度 的 自 治 的 要 求 ， 这 是 我 们 可 以 利 用 的 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 我 们 管 不 着 啊";
		if (GlobalScript.inst.gameState.data[18] < 23)
		{
			button_text[1] = " 给 予 他 们 更 多 自 治 权";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 给 予 更 多 的 自 治 权";
		}
		if (GlobalScript.inst.gameState.data[56] != 4 || GlobalScript.inst.gameState.data[22] >= 100)
		{
			button_text[2] = " 派 部 队 去 恢 复 秩 序";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 只 用 军 队 镇 压 他 们 是 行 不 通 的";
		}
		if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 40 || GlobalScript.inst.gameState.data[36] >= 40 || GlobalScript.inst.gameState.data[9] >= 50)
		{
			button_text[3] = " 顺 水 推 舟 ， 举 行 主 权 公 投 ， 但 暗 中 使 绊 子";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 既 没 有 造 假 的 手 段 ， 也 没 有 造 假 的 实 力";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 西 藏 的 分 离 主 义";
		switch (result_num)
		{
		case 0:
			text = " 西 藏 自 治 区 正 式 宣 布 以 它1950 年 的 边 界 独 立 。 这 对 我 们 来 说 是 一 个 巨 大 的 打 击 ， 对 苏 联 和 美 国 来 说 却 是 一 个 巨 大 的 机 遇 。";
			GlobalScript.inst.gameState.influencePRC -= 250;
			GlobalScript.inst.gameState.data[34] -= 31;
			GlobalScript.inst.gameState.data[13] -= 50;
			GlobalScript.inst.gameState.data[12] -= 10;
			GlobalScript.inst.gameState.data[57] -= 50;
			GlobalScript.inst.gameState.data[1] -= 200;
			GlobalScript.inst.gameState.data[3] -= 200;
			GlobalScript.inst.gameState.data[34] -= 31;
			GlobalScript.inst.gameState.allcountries[69].dev = 0;
			if (GlobalScript.inst.gameState.data[14] <= 3)
			{
				GlobalScript.inst.gameState.data[67] = 1;
				if (GlobalScript.inst.gameState.data[62] >= 2)
				{
					GlobalScript.inst.gameState.allcountries[1].parts[8] = true;
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[1].parts[7] = true;
				}
				GlobalScript.inst.gameState.allcountries[69].Gosstroy = 3;
				GlobalScript.inst.gameState.allcountries[69].SubGosstroy = 6;
			}
			else
			{
				GlobalScript.inst.gameState.data[67] = 2;
				if (GlobalScript.inst.gameState.data[62] >= 2)
				{
					GlobalScript.inst.gameState.allcountries[1].parts[8] = true;
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[1].parts[7] = true;
				}
			}
			GlobalScript.inst.gameState.allcountries[69].prosov = false;
			break;
		case 1:
		{
			text = " 我 们 进 一 步 扩 大 地 方 的 权 力 和 西 藏 的 自 治 权 。 大 多 数 人 似 乎 都 很 满 意 ， 但 这 给 了 激 进 派 更 多 的 机 会 来 发 展 分 离 主 义 ， 其 他 自 治 区 也 有 了 更 大 的 独 立 倾 向 。";
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[57] -= 20;
			GlobalScript.inst.gameState.data[1] -= 200;
			int[] data = GlobalScript.inst.gameState.data;
			int num = 18;
			ref int reference = ref data[num];
			int num2 = data[num];
			reference = num2 + 1;
			break;
		}
		case 2:
			text = " 忠 诚 的 解 放 军 进 入 西 藏 ， 并 且 迅 速 恢 复 了 西 藏 的 秩 序 。 但 民 族 主 义 者 和 反 对 派 不 会 忘 记 这 一 天 。";
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[57] += 30;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[22] -= 100;
			GlobalScript.inst.gameState.data[6] += 50;
			break;
		case 3:
			text = " 我 们 组 织 了 一 次 全 民 公 决 ， 大 多 数 人 投 票 赞 成 保 留 西 藏 的 现 有 地 位 。 不 满 的 民 族 主 义 者 和 其 他 激 进 分 子 走 上 街 头 ， 他 们 声 称 公 投 结 果 是 伪 造 的 ， 但 是 没 有 了 过 去 我 们 对 他 们 的 纵 容 ， 这 些 抗 议 活 动 不 再 构 成 严 重 威 胁 。";
			GlobalScript.inst.gameState.data[4] += 30;
			GlobalScript.inst.gameState.data[57] += 20;
			GlobalScript.inst.gameState.data[3] -= 20;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[8] -= 40;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
