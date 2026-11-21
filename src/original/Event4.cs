using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event4 : EventsSecond
{
	private GameState a;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 阴 谋";
		text = " 根 据 最 近 得 到 的 信 息 ， 几 名 对 你 领 导 不 满 的 资 深 党 员 决 定 将 你 在 下 次 大 会 上 移 除 出 中 央 。 如 果 不 想 重 蹈 赫 鲁 晓 夫1964 年 的 覆 辙 的 话 ， 你 需 要 马 上 做 些 什 么 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 在 大 会 上 开 始 辩 论";
		if (GlobalScript.inst.gameState.data[9] >= 100)
		{
			button_text[1] = " 逮 捕 那 些 野 心 家 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 特 勤 部 门 不 会 支 持 我 们";
		}
		if (GlobalScript.inst.gameState.data[22] >= 100)
		{
			button_text[2] = " 召 集 忠 诚 的 军 官 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 军 方 不 会 支 持 我 们";
		}
		if (GlobalScript.inst.gameState.data[3] >= 700 || (GlobalScript.inst.gameState.event_done[444] && GlobalScript.inst.gameState.resultOfEvents[444] == 0))
		{
			button_text[3] = " 敬 告 人 民 群 众 ！";
		}
		else if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			Object.Destroy(button[3]);
			button_text[3] = " 人 民 已 经 受 够 了 大 鸣 大 放 ， 你 想 复 辟 文 革 余 毒 ？";
		}
		else if (GlobalScript.inst.gameState.modifies[3].active)
		{
			Object.Destroy(button[3]);
			button_text[3] = " 人 民 有 些 累 了 ， 让 他 们 休 息 休 息 吧 … …";
		}
		button_text[4] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 阴 谋";
		Politic[] politics;
		if (result_num == 0)
		{
			int num = 0;
			for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
			{
				if (GlobalScript.inst.gameState.politics[i].loyality > 600)
				{
					num++;
				}
			}
			if (GlobalScript.inst.gameState.data[1] > 500 && num >= 4)
			{
				text = " 在 密 谋 者 讲 出 他 们 的 控 告 前 你 就 用 批 评 和 反 控 告 批 判 了 他 们 。 大 多 数 出 席 全 会 的 党 员 支 持 你 ， 密 谋 者 只 得 退 却 。";
				GlobalScript.inst.gameState.data[1] += 50;
				politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (((politic.loyality < 300 && politic.traits[2] == 16) || politic.you_fall || (politic.loyality < 150 && politic.traits[2] != 9) || (politic.loyality < 50 && politic.traits[2] == 9)) && politic.traits[2] != 17 && politic.traits[2] != 19 && !politic.is_sledstvie)
					{
						politic.power -= 100;
						politic.loyality -= 100;
						politic.is_sledstvie = true;
						politic.sled_slej = 1;
					}
				}
			}
			else
			{
				text = " 在 密 谋 者 讲 出 他 们 的 控 告 前 你 就 用 批 评 和 反 控 告 批 判 了 他 们 。 但 是 ， 你 的 名 誉 显 然 不 大 好 ， 大 多 数 党 员 受 够 了 你 的 领 导 。 大 多 数 出 席 全 会 的 党 员 支 持 了 密 谋 者 ， 你 被 解 职 并 被 踢 出 中 央 委 员 会 ， 丢 到 了 一 个 偏 远 的 清 水 衙 门 。";
				GlobalScript.inst.gameState.data[1] = 0;
				GlobalScript.inst.gameState.data[3] = 0;
				load_scene_after_click = true;
			}
		}
		if (result_num == 1)
		{
			text = " 忠 诚 于 你 的 特 工 在 大 会 开 始 之 前 就 成 功 的 控 制 了 刚 到 北 京 的 阴 谋 者 们 并 将 他 们 送 去 蹲 大 牢 去 了 。 在 大 会 中 ， 你 在 他 们 缺 席 的 情 况 下 批 评 了 他 们 ， 获 得 了 大 部 分 与 会 代 表 的 支 持 。 但 是 除 去 党 的 高 阶 成 员 不 是 那 么 简 单 的......";
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[9] -= 100;
			if (GlobalScript.inst.gameState.data[1] <= 300 + GlobalScript.inst.gameState.data[4] / 5 - (GlobalScript.inst.gameState.data[3] - 500) / 5)
			{
				GlobalScript.inst.gameState.data[1] += 400;
			}
			else
			{
				GlobalScript.inst.gameState.data[1] += 50;
			}
			politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (((politic2.loyality < 300 && politic2.traits[2] == 16) || politic2.you_fall || (politic2.loyality < 150 && politic2.traits[2] != 9) || (politic2.loyality < 50 && politic2.traits[2] == 9)) && politic2.traits[2] != 17 && politic2.traits[2] != 19 && !politic2.is_sledstvie)
				{
					politic2.power -= 100;
					politic2.loyality -= 200;
					politic2.is_sledstvie = true;
					politic2.sled_slej = 1;
				}
			}
		}
		if (result_num == 2)
		{
			text = " 忠 诚 于 你 的 军 官 在 大 会 开 始 之 前 就 成 功 的 控 制 了 刚 到 北 京 的 阴 谋 者 们 并 将 他 们 送 去 蹲 大 牢 去 了 。 在 士 兵 在 场 的 大 会 中 ， 你 在 他 们 缺 席 的 情 况 下 批 评 了 他 们 ， 获 得 了 大 部 分 与 会 代 表 的 支 持 。 但 是 除 去 党 的 高 阶 成 员 不 是 那 么 简 单 的......";
			GlobalScript.inst.gameState.data[3] -= 80;
			if (GlobalScript.inst.gameState.data[1] <= 300 + GlobalScript.inst.gameState.data[4] / 5 - (GlobalScript.inst.gameState.data[3] - 500) / 5)
			{
				GlobalScript.inst.gameState.data[1] += 400;
			}
			else
			{
				GlobalScript.inst.gameState.data[1] += 50;
			}
			GlobalScript.inst.gameState.data[22] -= 100;
			politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (((politic3.loyality < 300 && politic3.traits[2] == 16) || politic3.you_fall || (politic3.loyality < 150 && politic3.traits[2] != 9) || (politic3.loyality < 50 && politic3.traits[2] == 9)) && politic3.traits[2] != 17 && politic3.traits[2] != 19 && !politic3.is_sledstvie)
				{
					politic3.power -= 100;
					politic3.loyality -= 300;
					politic3.is_sledstvie = true;
					politic3.sled_slej = 1;
				}
			}
		}
		if (result_num != 3)
		{
			return;
		}
		if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			text = " 你 通 过 媒 体 呼 吁 人 民 支 持 你 ， 保 护 你 的 权 力 。 在 大 会 开 始 之 前 。 忠 诚 于 你 的 群 众 参 加 了 声 援 你 的 示 威 游 行 ， 并 开 始 向 你 的 对 手 控 制 的 部 门 发 起 攻 击 。 认 识 到 了 他 们 处 于 劣 势 之 后 ， 反 对 派 们 决 定 撤 退 ， 最 后 大 会 保 卫 了 你 的 权 力 ， 但 是 人 们 已 经 厌 倦 了 类 似 于 文 化 大 革 命 的 运 动 。";
			_ = GlobalScript.inst.gameState.data[3];
			if (GlobalScript.inst.gameState.data[1] <= 300 + GlobalScript.inst.gameState.data[4] / 5 - (GlobalScript.inst.gameState.data[3] - 500) / 5)
			{
				GlobalScript.inst.gameState.data[1] += 400;
			}
			else
			{
				GlobalScript.inst.gameState.data[1] += 50;
			}
			GlobalScript.inst.gameState.data[3] -= 200;
			GlobalScript.inst.gameState.data[5] -= 70;
		}
		else if (GlobalScript.inst.gameState.modifies[3].active)
		{
			text = " 你 通 过 媒 体 呼 吁 人 民 支 持 你 ， 保 护 你 的 权 力 。 在 大 会 开 始 之 前 。 忠 诚 于 你 的 群 众 参 加 了 声 援 你 的 示 威 游 行 ， 并 开 始 向 你 的 对 手 控 制 的 部 门 发 起 攻 击 。 认 识 到 了 他 们 处 于 劣 势 之 后 ， 反 对 派 们 决 定 撤 退 ， 最 后 大 会 保 卫 了 你 的 权 力 ， 但 是 人 们 的 热 情 不 是 无 限 的 ， 你 最 好 还 是 小 心 些 。";
			_ = GlobalScript.inst.gameState.data[3];
			if (GlobalScript.inst.gameState.data[1] <= 300 + GlobalScript.inst.gameState.data[4] / 5 - (GlobalScript.inst.gameState.data[3] - 500) / 5)
			{
				GlobalScript.inst.gameState.data[1] += 400;
			}
			else
			{
				GlobalScript.inst.gameState.data[1] += 50;
			}
			GlobalScript.inst.gameState.data[3] -= 150;
			GlobalScript.inst.gameState.data[5] -= 40;
		}
		politics = GlobalScript.inst.gameState.politics;
		foreach (Politic politic4 in politics)
		{
			if (((politic4.loyality < 300 && politic4.traits[2] == 16) || politic4.you_fall || (politic4.loyality < 150 && politic4.traits[2] != 9) || (politic4.loyality < 50 && politic4.traits[2] == 9)) && politic4.traits[2] != 17 && politic4.traits[2] != 19 && !politic4.is_sledstvie)
			{
				politic4.power -= 100;
				politic4.loyality -= 100;
				politic4.is_sledstvie = true;
				politic4.sled_slej = 1;
			}
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 2;
			SceneManager.LoadScene("Ending");
		}
	}
}
