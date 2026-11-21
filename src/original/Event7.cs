using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event7 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

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
		name = " 外 交 危 机";
		text = " 我 们 与 美 国 的 关 系 达 到 了 极 低 的 水 平 。 他 们 的 宣 传 已 经 开 始 指 责 我 们 犯 下 了 可 能 的 和 不 可 能 的 罪 行 ， 我 们 的 情 报 部 门 告 诉 我 们 五 角 大 楼 中 的 骚 动 以 及 东 南 亚 的 美 国 军 事 基 地 的 活 动 。 如 果 我 们 不 想 要 打 第 三 次 世 界 大 战 的 话 ， 就 需 要 尽 快 纠 正 这 种 情 况 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.data[51] != 30 || GlobalScript.inst.gameState.data[6] <= 950)
		{
			button_text[0] = "  我 们 出 资 缓 和 关 系";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 绝 不 投 降 ！";
		}
		if (GlobalScript.inst.gameState.influencePRC >= 50)
		{
			button_text[1] = " 放 弃 一 部 分 外 交 政 策 立 场 来 表 达 善 意";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 的 影 响 力 太 弱 了 ， 所 以 我 们 限 无 可 限";
		}
		if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 向 帝 国 主 义 者 发 射 核 武 器 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 没 人 想 要 一 场 核 战 争";
		}
		button_text[3] = " 一 点 都 不 在 乎";
		if (GlobalScript.inst.gameState.event_done[544] && GlobalScript.inst.gameState.resultOfEvents[544] == 2 && GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.allcountries[1].econ)
		{
			kolvo_variant = 5;
			button_text[4] = " 让 我 们 给 帝 国 主 义 者 一 点 颜 色 瞧 瞧 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 外 交 危 机";
		if (result_num == 0)
		{
			text = " 我 们 紧 急 组 织 了 中 美 两 国 外 交 部 长 之 间 的 盛 大 会 谈 ， 美 国 代 表 团 应 邀 参 加 了 一 次 豪 华 的 中 国 之 旅 ， 在 那 里 我 们 准 备 了 各 种 节 日 和 活 动 来 表 达 我 们 和 平 的 愿 望 。 缓 和 成 功 了 ， 紧 张 局 势 得 到 了 缓 和 。";
			GlobalScript.inst.gameState.empires[0].relations = 400;
			_ = GlobalScript.inst.gameState.data[6];
			if (GlobalScript.inst.gameState.data[6] > 600)
			{
				name = " 外 交 危 机";
				GlobalScript.inst.gameState.data[6] -= GlobalScript.inst.gameState.data[6] / 50;
			}
			GlobalScript.inst.gameState.data[8] -= 100;
		}
		if (result_num == 1)
		{
			text = " 我 们 放 弃 了 一 些 对 外 政 策 主 张 ， 减 少 了 对 他 国 反 对 派 的 支 持 ， 总 体 上 减 少 了 中 国 对 他 国 政 治 的 干 预 。 美 国 外 交 部 对 此 表 示 肯 定 ， 紧 张 局 势 有 所 缓 解 。 我 们 的 影 响 力 也 降 低 了";
			GlobalScript.inst.gameState.empires[0].relations = 400;
			GlobalScript.inst.gameState.influencePRC -= 50;
			GlobalScript.inst.gameState.data[22] -= 50;
			GlobalScript.inst.gameState.data[9] -= 50;
		}
		if (result_num == 2)
		{
			text = " 紧 张 度 提 升";
			load_scene_after_click = true;
		}
		if (result_num == 3)
		{
			text = " 紧 张 度 提 升";
			if (!GlobalScript.inst.gameState.modifies[17].active)
			{
				GlobalScript.inst.gameState.data[22] -= 50;
				GlobalScript.inst.gameState.data[9] -= 50;
				GlobalScript.inst.gameState.modifies[17].active = true;
				GlobalScript.inst.old_modify_texts[17] = " 美 国 禁 运";
				GlobalScript.inst.old_modify_desc[17] = " 我 们 将 减 少 与 美 国 关 系 差 额10% 的 收 入| 失 去 相 当 于 与 美 国 关 系 差 额5% 的 特 工 网 络";
				int[] data = GlobalScript.inst.gameState.data;
				int num = 111;
				ref int reference = ref data[num];
				int num2 = data[num];
				reference = num2 + 1;
			}
			if (GlobalScript.inst.gameState.modifies[17].active && GlobalScript.inst.gameState.allcountries[1].isASEAN && GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.data[139] <= 0)
			{
				GlobalScript.inst.gameState.data[139] = 5;
			}
		}
		if (result_num == 4)
		{
			text = " 很 快 ， 我 们 就 发 动 了 联 盟 内 的 国 家 对 美 国 实 施 了 禁 运 ， 美 方 对 此 十 分 震 惊 ， 谴 责 中 国 的 “ 帝 国 主 义 行 为 ” ， 但 他 们 之 前 威 胁 我 们 的 时 候 为 什 么 不 想 想 可 能 的 后 果 呢 ？ 总 而 言 之 ， 美 国 佬 会 有 一 段 “ 难 忘 ” 的 时 光 了 ！";
			GlobalScript.inst.gameState.modifies[17].active = true;
			GlobalScript.inst.old_modify_texts[17] = " 禁 运 美 国";
			GlobalScript.inst.old_modify_desc[17] = " 我 们 将 增 加 与 美 国 影 响 差 额10% 的 特 工 网 络| 获 得 相 当 于 与 美 国 影 响 差 额5% 的 预 算| 美 国 将 减 少 与 中 国 影 响 差 额10% 的 影 响 力| 失 去 相 当 于 与 中 国 影 响 差 额5% 的 收 入";
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
			GlobalScript.inst.gameState.data[35] = 3;
			SceneManager.LoadScene("Ending");
		}
	}
}
