using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event111 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	public bool load_scene_after_click;

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
		name = " 在 幽 灵 般 的 灯 光 下";
		text = " 主 席 同 志 ！IECS 系 统 部 分 实 施 后 ， 政 府 开 始 逐 步 、 系 统 地 削 减 基 层 国 家 机 构 ， 解 放 不 必 要 的 技 术 工 人 ， 优 化 预 算 。 这 些 措 施 遭 到 了 地 方 官 僚 机 构 的 强 烈 抵 制 ， 他 们 已 经 宣 布 你 们 是 “ 资 产 阶 级 反 革 命 ” 了 。 现 在 连 党 的 最 高 领 导 层 都 反 对 你 ， 而 且 已 经 在 准 备 罢 免 你 。 我 们 需 要 立 即 采 取 行 动 ！ 我 们 需 要 争 取 广 大 民 众 的 支 持 ， 胜 利 将 属 于 我 们 ！ 但 问 题 是 ， 他 们 会 支 持 我 们 吗 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 放 弃 斗 争 和 辞 职";
		if (GlobalScript.inst.gameState.data[3] >= 900 && GlobalScript.inst.gameState.data[5] >= 900 && GlobalScript.inst.gameState.modifies[3].active)
		{
			button_text[1] = " 号 召 人 民 群 众 反 对 党 阀 的 统 治";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 人 民 已 经 受 够 了 大 鸣 大 放 ， 你 想 复 辟 文 革 余 毒 ？";
		}
		if (GlobalScript.inst.gameState.data[9] >= 400)
		{
			button_text[2] = " 逮 捕 阴 谋 者 并 开 始 迫 害 最 积 极 主 动 的 合 伙 人 （ 需 要40 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 国 安 部 不 会 支 持 我 们!";
		}
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[3] = " 动 员 忠 诚 的 军 官 反 对 阴 谋 家";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 军 官 不 会 拯 救 我 们";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 在 幽 灵 般 的 灯 光 下";
		switch (result_num)
		{
		case 0:
			text = " 末 日 已 至 。";
			load_scene_after_click = true;
			break;
		case 1:
		{
			text = " 今 天, 所 有 的 报 纸 上 都 发 表 了 《 呼 吁 人 民 》 这 篇 文 章, 在 文 中 ， 主 席 呼 吁 每 个 爱 党 爱 国 、 关 心 中 国 命 运 的 公 民 抵 制 企 图 复 辟 的 走 资 派 和 党 内 的 修 正 主 义 者 。 受 到 鼓 舞 的 群 众 自 发 聚 集 在 天 安 门 广 场 集 会 ， 支 持 政 府 和 主 席 同 志 的 行 动 。 结 果 ， 三 十 多 万 人 聚 集 在 国 家 的 主 要 广 场 ， 高 呼 把 反 对 反 动 派 的 文 化 大 革 命 继 续 下 去 的 口 号 。 在 公 众 愤 怒 的 压 力 下 ， 阴 谋 者 不 得 不 辞 职 ， 地 方 官 员 安 抚 了 人 民 的 热 情 。 这 是 我 们 人 民 的 伟 大 胜 利! 光 荣 归 于 主 席! 光 荣 归 于 中 国 共 产 党!";
			GlobalScript.inst.gameState.data[6] += 70;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[1] -= 400;
			int num2 = 0;
			for (int j = 0; j < GlobalScript.inst.gameState.politics.Length; j++)
			{
				if (GlobalScript.inst.gameState.politics[j].loyality < 300 && num2 < 3 && (GlobalScript.inst.gameState.politics[j].name_1 != 2 || GlobalScript.inst.gameState.politics[j].name_2 != 2) && GlobalScript.inst.gameState.politics[j].traits[0] != GlobalScript.inst.gameState.leader.traits[0])
				{
					GlobalScript.inst.gameState.KillPerson(j);
					num2++;
				}
				else if (num2 >= 3)
				{
					break;
				}
			}
			break;
		}
		case 2:
		{
			text = " 由 于 我 们 情 报 部 门 的 协 调 工 作 ， 反 对 我 们 的 最 高 领 导 者 提 出 的 自 动 化 政 策 的 人 被 从 所 有 职 位 上 除 名 ， 并 即 将 受 到 公 正 的 审 判 。 而 在 基 层 ， 一 场 铲 除 腐 败 的 运 动 开 始 了 ， 震 撼 了 数 万 名 反 对 党 的 政 策 的 党 内 工 作 人 员 的 立 场 。 对 我 们 亲 爱 的 领 袖 的 反 对 者 的 政 治 镇 压 激 起 了 党 内 其 他 工 作 人 员 的 不 满 ， 他 们 为 了 个 人 安 全 的 原 因 ， 不 得 不 隐 藏 他 们 的 不 满 。 然 而 ， 这 是 我 们 的 伟 大 胜 利! 光 荣 归 于 主 席! 光 荣 归 于 中 国 共 产 党!";
			GlobalScript.inst.gameState.data[9] -= 400;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[6] += 50;
			GlobalScript.inst.gameState.data[1] -= 500;
			int num3 = 0;
			for (int k = 0; k < GlobalScript.inst.gameState.politics.Length; k++)
			{
				if (GlobalScript.inst.gameState.politics[k].loyality < 300 && num3 < 3 && (GlobalScript.inst.gameState.politics[k].name_1 != 2 || GlobalScript.inst.gameState.politics[k].name_2 != 2) && GlobalScript.inst.gameState.politics[k].traits[0] != GlobalScript.inst.gameState.leader.traits[0])
				{
					GlobalScript.inst.gameState.KillPerson(k);
					num3++;
				}
				else if (num3 >= 3)
				{
					break;
				}
			}
			break;
		}
		case 3:
		{
			text = " 第 二 天 ， 忠 诚 的 军 队 进 入 北 京 ， 阴 谋 家 被 逮 捕 并 接 受 审 判 。 首 都 实 施 了 宵 禁 ， 城 市 街 道 由 军 队 控 制 ， 局 势 似 乎 逐 渐 稳 定 。 最 积 极 的 反 动 派 被 开 除 了, 其 余 人 不 得 不 平 息 他 们 对" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 同 志 疾 风 暴 雨 般 的 批 评 。 然 而 ， 工 人 阶 级 的 敌 人 被 打 败 了 ， 这 是 我 们 的 伟 大 胜 利! 光 荣 归 于 主 席! 光 荣 归 于 中 国 共 产 党!";
			GlobalScript.inst.gameState.data[22] -= 300;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[1] -= 500;
			GlobalScript.inst.gameState.data[6] += 50;
			int num = 0;
			for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
			{
				if (GlobalScript.inst.gameState.politics[i].loyality < 300 && num < 3 && (GlobalScript.inst.gameState.politics[i].name_1 != 2 || GlobalScript.inst.gameState.politics[i].name_2 != 2) && GlobalScript.inst.gameState.politics[i].traits[0] != GlobalScript.inst.gameState.leader.traits[0])
				{
					GlobalScript.inst.gameState.KillPerson(i);
					num++;
				}
				else if (num >= 3)
				{
					break;
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

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 6;
			SceneManager.LoadScene("Ending");
		}
	}
}
