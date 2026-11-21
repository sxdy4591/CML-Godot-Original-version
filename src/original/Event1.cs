using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event1 : EventsSecond
{
	private GameState a;

	public bool load_scene_after_click;

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 金 豆 豆 ， 银 豆 豆 ， 投 到 … …";
		text = " 今 天 是 全 国 人 大 选 举 的 日 子 。 既 然 我 们 在 中 国 政 治 上 占 主 导 地 位 ， 我 们 就 可 以 稍 微 干 预 一 下 他 们 的 选 票 去 向 ， 这 样 什 么 都 不 会 被 改 变 。 或 者 我 们 仅 仅 依 靠 中 国 人 民 的 信 任 就 好 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 不 要 介 入 ， 静 待 结 果";
		if (GlobalScript.inst.gameState.data[1] > 500)
		{
			button_text[1] = " 推 动 公 务 员 投 票";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 党 绝 不 容 许 这 种 无 耻 贿 选";
		}
		if (GlobalScript.inst.gameState.data[9] >= 50)
		{
			button_text[2] = " 伪 造 大 选 结 果";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = " 情 报 部 门 实 力 不 足";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		GlobalScript.inst.gameState.data[106] = 0;
		name = " 金 豆 豆 ， 银 豆 豆 ， 投 到 … …";
		float[] array = new float[5]
		{
			0f,
			(GlobalScript.inst.gameState.data[3] * 2 - GlobalScript.inst.gameState.data[4] / 2 + GlobalScript.inst.gameState.data[5] / 2) / 10,
			0f,
			0f,
			0f
		};
		if (GlobalScript.inst.gameState.is_party_enabled[0])
		{
			array[0] = (1000 - GlobalScript.inst.gameState.data[3] - GlobalScript.inst.gameState.data[4] / 2) / 10;
			if (GlobalScript.inst.gameState.data[67] > 0)
			{
				array[0] += 10f;
			}
			if (GlobalScript.inst.gameState.data[66] > 0)
			{
				array[0] += 10f;
			}
			if (GlobalScript.inst.gameState.data[5] <= 500)
			{
				array[0] += (1000 - GlobalScript.inst.gameState.data[5]) / 20;
			}
			if (GlobalScript.inst.gameState.empires[1].relations <= 600)
			{
				array[0] += (1000 - GlobalScript.inst.gameState.empires[1].relations) / 100;
			}
		}
		else
		{
			array[0] = 0f;
		}
		if (GlobalScript.inst.gameState.is_party_enabled[2])
		{
			array[2] = (1000 - GlobalScript.inst.gameState.data[3] + GlobalScript.inst.gameState.data[4] / 2 + GlobalScript.inst.gameState.data[31] / 10) / 10;
			if (GlobalScript.inst.gameState.data[67] > 0)
			{
				array[2] += 10f;
			}
			if (GlobalScript.inst.gameState.data[66] > 0)
			{
				array[2] += 10f;
			}
			if (GlobalScript.inst.gameState.empires[1].relations <= 600)
			{
				array[2] += (1000 - GlobalScript.inst.gameState.empires[1].relations) / 100;
			}
		}
		else
		{
			array[2] = 0f;
		}
		if (GlobalScript.inst.gameState.is_party_enabled[3])
		{
			array[3] = (1000 - GlobalScript.inst.gameState.data[3] + GlobalScript.inst.gameState.data[4] / 2 + (GlobalScript.inst.gameState.data[31] - GlobalScript.inst.gameState.data[3] / 2)) / 10;
			if (GlobalScript.inst.gameState.data[67] > 0)
			{
				array[3] += 10f;
			}
			if (GlobalScript.inst.gameState.data[66] > 0)
			{
				array[3] += 10f;
			}
			if (GlobalScript.inst.gameState.data[18] != 21)
			{
				array[3] += (700 - GlobalScript.inst.gameState.data[3]) / 10;
			}
			if (GlobalScript.inst.gameState.empires[0].relations <= 600)
			{
				array[3] += (1000 - GlobalScript.inst.gameState.empires[0].relations) / 100;
			}
		}
		else
		{
			array[3] = 0f;
		}
		if (GlobalScript.inst.gameState.is_party_enabled[4])
		{
			array[4] = (1000 - GlobalScript.inst.gameState.data[3] + GlobalScript.inst.gameState.data[4] / 2) / 10;
			if (GlobalScript.inst.gameState.empires[0].relations <= 600)
			{
				array[3] += (1000 - GlobalScript.inst.gameState.empires[0].relations) / 100;
			}
		}
		else
		{
			array[4] = 0f;
		}
		GlobalScript.inst.gameState.data[125] = 1;
		if (result_num == 0)
		{
			int num = 0;
			float[] array2 = new float[5];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < 0f)
				{
					array[i] = 1f;
				}
				num += (int)array[i];
			}
			int num2 = 0;
			for (int j = 0; j < GlobalScript.inst.gameState.party_number.Length; j++)
			{
				Debug.Log(array[j].ToString());
			}
			GlobalScript.inst.gameState.party_number[1] = (int)(3000f * (array[1] / (float)num));
			for (int k = 0; k < GlobalScript.inst.gameState.party_number.Length; k++)
			{
				array2[k] = 3000f * (array[k] / (float)num);
				GlobalScript.inst.gameState.party_number[k] = (int)array2[k];
				GlobalScript.inst.gameState.party_ideology[k] = (int)array2[k];
				if (k == 1)
				{
					num2 += (int)array2[k];
				}
				else if (GlobalScript.inst.gameState.is_party_ally[k])
				{
					num2 += (int)array2[k];
					if (GlobalScript.inst.gameState.party_number[k] >= GlobalScript.inst.gameState.party_number[1])
					{
						GlobalScript.inst.gameState.is_party_ally[k] = false;
					}
				}
			}
			if (GlobalScript.inst.gameState.party_number[1] < 1500 && a.modifies[6].active)
			{
				GlobalScript.inst.gameState.party_number[1] = 1500;
			}
			if (GlobalScript.inst.gameState.party_number[1] > 1500)
			{
				text = " 我 们 大 胜 一 场 ， 横 扫 议 席 ， 向 全 中 国 与 世 界 证 明 人 民 依 然 支 持 我 们 带 领 他 们 ！";
				GlobalScript.inst.gameState.data[3] += 10;
				GlobalScript.inst.gameState.data[4] -= 20;
				GlobalScript.inst.gameState.data[1] += 50;
			}
			else if (num2 > 1500)
			{
				text = " 我 们 的 党 派 联 盟 在 人 大 选 举 中 获 胜 ， 向 全 中 国 与 世 界 证 明 人 民 依 然 支 持 我 们 的 领 导 ！";
			}
			else
			{
				text = " 我 们 不 止 失 去 了 议 会 多 数 ， 还 没 能 赢 得 过 半 议 席 ！ 真 是 耻 辱 ！";
				load_scene_after_click = true;
			}
			text += "| 选 举 结 果 ：";
			for (int l = 0; l < GlobalScript.inst.gameState.party_number.Length; l++)
			{
				if (GlobalScript.inst.gameState.is_party_enabled[l])
				{
					text = text + "|" + GlobalScript.inst.gameState.party_name[l + 5] + ": " + GlobalScript.inst.gameState.party_number[l] + " 席 （ 总3000 席 位 ）";
				}
			}
		}
		if (result_num == 1)
		{
			text = " 公 务 员 屈 服 于 我 们“ 为 党 投 票 升 职 加 薪 ， 拒 绝 投 票 裁 员 降 级 ” 的 口 号 ， 纷 纷 前 往 投 票 站 为 我 党 投 票 。 然 而 人 民 会 牢 记 这 样 的 公 然 欺 诈 。";
			array[1] += GlobalScript.inst.gameState.data[1] / 10;
			int num3 = 0;
			float[] array3 = new float[5];
			for (int m = 0; m < array.Length; m++)
			{
				if (array[m] < 0f)
				{
					array[m] = 1f;
				}
				num3 += (int)array[m];
			}
			int num4 = 0;
			GlobalScript.inst.gameState.party_number[1] = (int)(3000f * (array[1] / (float)num3));
			for (int n = 0; n < GlobalScript.inst.gameState.party_number.Length; n++)
			{
				array3[n] = 3000f * (array[n] / (float)num3);
				GlobalScript.inst.gameState.party_number[n] = (int)array3[n];
				GlobalScript.inst.gameState.party_ideology[n] = (int)array3[n];
				if (n == 1)
				{
					num4 += (int)array3[n];
				}
				else if (GlobalScript.inst.gameState.is_party_ally[n])
				{
					num4 += (int)array3[n];
					if (GlobalScript.inst.gameState.party_number[n] >= GlobalScript.inst.gameState.party_number[1])
					{
						GlobalScript.inst.gameState.is_party_ally[n] = false;
					}
				}
			}
			_ = GlobalScript.inst.gameState.data[3];
			if (GlobalScript.inst.gameState.party_number[1] < 1500 && a.modifies[6].active)
			{
				GlobalScript.inst.gameState.party_number[1] = 1500;
			}
			if (GlobalScript.inst.gameState.party_number[1] > 1500)
			{
				text = " 我 们 大 胜 一 场 ， 横 扫 议 席 ， 向 全 中 国 与 世 界 证 明 人 民 依 然 支 持 我 们 带 领 他 们 ！";
				GlobalScript.inst.gameState.data[3] += 10;
				GlobalScript.inst.gameState.data[4] -= 20;
				GlobalScript.inst.gameState.data[1] += 50;
			}
			else if (num4 > 1500)
			{
				text = " 我 们 的 党 派 联 盟 在 人 大 选 举 中 获 胜 ， 向 全 中 国 与 世 界 证 明 人 民 依 然 支 持 我 们 的 领 导 ！";
			}
			else
			{
				text = " 我 们 不 止 失 去 了 议 会 多 数 ， 还 没 能 赢 得 过 半 议 席 ！ 真 是 耻 辱 ！";
				load_scene_after_click = true;
			}
			text += "| 选 举 结 果 ：";
			for (int num5 = 0; num5 < GlobalScript.inst.gameState.party_number.Length; num5++)
			{
				if (GlobalScript.inst.gameState.is_party_enabled[num5])
				{
					text = text + "|" + GlobalScript.inst.gameState.party_name[num5 + 5] + ": " + GlobalScript.inst.gameState.party_number[num5] + " ， 总 席 位3000";
				}
			}
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] += 10;
		}
		if (result_num != 2)
		{
			return;
		}
		text = " 特 勤 战 士 们 为 我 们 竞 选 拉 票 不 遗 余 力 ， 当 然 ， 他 们 为 此 劳 神 伤 骨。";
		_ = GlobalScript.inst.gameState.data[9];
		if (GlobalScript.inst.gameState.data[9] < 100)
		{
			array[1] += GlobalScript.inst.gameState.data[9] * 2;
			GlobalScript.inst.gameState.data[9] = 0;
		}
		else
		{
			array[1] += 200f;
			GlobalScript.inst.gameState.data[9] -= 100;
		}
		int num6 = 0;
		float[] array4 = new float[5];
		for (int num7 = 0; num7 < array.Length; num7++)
		{
			if (array[num7] < 0f)
			{
				array[num7] = 1f;
			}
			num6 += (int)array[num7];
		}
		int num8 = 0;
		GlobalScript.inst.gameState.party_number[1] = (int)(3000f * (array[1] / (float)num6));
		for (int num9 = 0; num9 < GlobalScript.inst.gameState.party_number.Length; num9++)
		{
			array4[num9] = 3000f * (array[num9] / (float)num6);
			GlobalScript.inst.gameState.party_number[num9] = (int)array4[num9];
			GlobalScript.inst.gameState.party_ideology[num9] = (int)array4[num9];
			if (num9 == 1)
			{
				num8 += (int)array4[num9];
			}
			else if (GlobalScript.inst.gameState.is_party_ally[num9])
			{
				num8 += (int)array4[num9];
				if (GlobalScript.inst.gameState.party_number[num9] >= GlobalScript.inst.gameState.party_number[1])
				{
					GlobalScript.inst.gameState.is_party_ally[num9] = false;
				}
			}
		}
		if (GlobalScript.inst.gameState.party_number[1] < 1500 && a.modifies[6].active)
		{
			GlobalScript.inst.gameState.party_number[1] = 1500;
		}
		if (GlobalScript.inst.gameState.party_number[1] > 1500)
		{
			text = " 我 们 大 胜 一 场 ， 横 扫 议 席 ， 向 全 中 国 与 世 界 证 明 人 民 依 然 支 持 我 们 带 领 他 们 ！";
			GlobalScript.inst.gameState.data[3] += 10;
			GlobalScript.inst.gameState.data[4] -= 20;
			GlobalScript.inst.gameState.data[1] += 50;
		}
		else if (num8 > 1500)
		{
			text = " 我 们 的 党 派 联 盟 在 人 大 选 举 中 获 胜 ， 向 全 中 国 与 世 界 证 明 人 民 依 然 支 持 我 们 的 领 导 ！";
		}
		else
		{
			text = " 我 们 不 止 失 去 了 议 会 多 数 ， 还 没 能 赢 得 过 半 议 席 ！ 真 是 耻 辱 ！";
			load_scene_after_click = true;
		}
		text += "| 选 举 结 果 ：";
		for (int num10 = 0; num10 < GlobalScript.inst.gameState.party_number.Length; num10++)
		{
			if (GlobalScript.inst.gameState.is_party_enabled[num10])
			{
				text = text + "|" + GlobalScript.inst.gameState.party_name[num10 + 5] + ": " + GlobalScript.inst.gameState.party_number[num10] + " ， 总 席 位3000";
			}
		}
		GlobalScript.inst.gameState.empires[1].power += 150;
		GlobalScript.inst.gameState.data[4] += 30;
		GlobalScript.inst.gameState.data[22] -= 10;
		GlobalScript.inst.gameState.data[31] -= 10;
		GlobalScript.inst.gameState.empires[0].money = 24;
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 5;
			SceneManager.LoadScene("Ending");
		}
	}
}
