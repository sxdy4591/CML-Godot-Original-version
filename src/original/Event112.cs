using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event112 : EventsSecond
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
		name = " 来 自0 和1 的 冲 击";
		if (a.event_done[494] && a.resultOfEvents[494] == 0)
		{
			text = " 主 席 同 志 ， 预 料 之 中 的 大 规 模 计 算 机 网 络 攻 击 来 临 了 ! 全 国 各 地 的 部 门 间 组 织 都 收 到 了 影 响 。 基 层 企 业 之 间 的 信 息 被 破 坏 ， 食 品 被 运 送 到 有 中 断 的 地 区 ， 商 店 里 的 队 伍 越 来 越 长 。 根 据 管 理 者 们 的 保 证 ， 我 们 的 设 备 遭 到 了 来 自 外 部 的 计 算 机 攻 击 。 情 报 机 构 认 为 ， 这 些 人 是 我 们 的 外 部 对 手 ， 担 心 我 们 在 世 界 舞 台 上 的 影 响 力 不 可 避 免 地 增 长 ， 所 以 他 们 与 自 动 化 的 敌 人 合 谋 ， 试 图 通 过 破 坏 I E C S 来 打 击 我 们 的 经 济 。||然 而 ， 考 虑 到 我 们 之 前 已 经 建 立 了 关 于 I E C S 系 统 的 初 步 防 护 ， 也 提 前 准 备 了 关 于 I E C S 网 络 被 攻 击 的 应 急 预 案 ， 并 在 攻 击 来 临 时 及 时 的 执 行 了 预 案 ， 这 些 攻 击 者 攻 击 造 成 的 损 失 没 有 预 想 中 的 那 么 大 。 专 家 建 议 继 续 升 级 规 划 系 统 的 特 殊 保 护 防 火 墙 ， 但 这 需 要 一 些 时 间 。 但 是 ， 我 们 可 以 请 求 苏 联 专 家 的 支 持 ， 这 将 使 我 们 能 够 迅 速 地 使 设 备 恢 复 运 作 。 还 是 … … 自 动 化 真 的 只 是 乌 托 邦 吗 ? ";
		}
		else
		{
			text = " 主 席 同 志 ， 怪 事 发 生 了! 全 国 各 地 的 部 门 间 组 织 都 失 败 了 。 基 层 企 业 之 间 的 信 息 被 破 坏 ， 食 品 被 运 送 到 有 中 断 的 地 区 ， 商 店 里 的 队 伍 越 来 越 长 。 根 据 管 理 者 们 的 保 证 ， 我 们 的 设 备 遭 到 了 来 自 外 部 的 计 算 机 攻 击 。 情 报 机 构 认 为 ， 这 些 人 是 我 们 的 外 部 对 手 ， 担 心 我 们 在 世 界 舞 台 上 的 影 响 力 不 可 避 免 地 增 长 ， 所 以 他 们 与 自 动 化 的 敌 人 合 谋 ， 他 试 图 通 过 破 坏IECS 来 打 击 我 们 的 经 济 。 如 果 我 们 仍 然 无 所 作 为 ， 这 将 导 致 我 们 国 家 的 崩 溃 。 专 家 建 议 为 我 们 的 规 划 系 统 开 发 特 殊 保 护 ， 但 这 需 要 一 些 时 间 。 但 是 ， 我 们 可 以 请 求 苏 联 专 家 的 支 持 ， 这 将 使 我 们 能 够 迅 速 地 使 设 备 恢 复 运 作 。 还 是 … … 自 动 化 真 的 只 是 乌 托 邦 吗?";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.event_done[494] && a.resultOfEvents[494] == 0)
		{
			button_text[0] = " 继 续 升 级 我 们 的 自 动 化 系 统 的 防 护 系 统";
			if (GlobalScript.inst.gameState.empires[1].relations >= 800 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.modifies[3].active)
			{
				button_text[1] = " 继 续 升 级 我 们 的 自 动 化 系 统 的 防 护 系 统 ， 并 要 求 苏 联 科 学 家 提 供 援 助";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 苏 维 埃 不 会 帮 助 我 们";
			}
			if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
			{
				button_text[2] = " 看 来 中 国 还 没 有 准 备 好 应 对 这 种 变 化 ， 有 必 要 放 慢 自 动 化 进 程";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 我 们 不 能 放 弃 我 们 的 成 就!";
			}
			button_text[5] = "";
		}
		else
		{
			button_text[0] = " 拨 款 发 展 一 套 保 障 制 度 （ 需 要25 百 万 预 算 ）";
			if (GlobalScript.inst.gameState.empires[1].relations >= 800 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.modifies[3].active)
			{
				button_text[1] = " 为 发 展 提 供 资 金 ， 并 要 求 苏 联 专 家 提 供 援 助( 需 要25 百 万 预 算 )";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 苏 维 埃 不 会 帮 助 我 们";
			}
			if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
			{
				button_text[2] = " 看 来 中 国 还 没 有 准 备 好 应 对 这 种 变 化 ， 有 必 要 放 慢 自 动 化 进 程";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 我 们 不 能 放 弃 我 们 的 成 就!";
			}
			button_text[5] = "";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 来 自0 和1 的 冲 击";
		switch (result_num)
		{
		case 0:
			if (a.event_done[494] && a.resultOfEvents[494] == 0)
			{
				text = " 我 们 着 手 于 继 续 升 级 并 完 善 我 们 的 “ 中 国 长 城 ” 防 火 墙 系 统 ， 以 提 高 I E C S 应 对 外 部 攻 击 的 能 力 。 得 以 于 之 前 的 防 护 系 统 ， 我 们 的 经 济 所 遭 到 的 损 失 并 不 算 严 重 。";
				GlobalScript.inst.gameState.data[8] -= 10;
				GlobalScript.inst.gameState.data[3] -= 50;
				GlobalScript.inst.gameState.data[4] += 100;
				GlobalScript.inst.gameState.data[1] -= 300;
				GlobalScript.inst.gameState.data[5] -= 30;
				GlobalScript.inst.gameState.data[12] -= 50;
				GlobalScript.inst.gameState.data[13] -= 50;
				GlobalScript.inst.gameState.data[68] -= 50;
			}
			else
			{
				text = " 政 府 紧 急 拨 款 开 发 了 一 个 工 作 代 号 为 “ 中 国 长 城 ” 的 系 统 ， 以 保 护IECS 免 受 外 部 攻 击 。 人 们 认 为 ， 保 护 措 施 将 在 八 个 月 内 准 备 就 绪 并 投 入 使 用 ， 但 就 目 前 而 言 ， 我 们 的 经 济 不 会 一 帆 风 顺 。";
				GlobalScript.inst.gameState.data[8] -= 250;
				GlobalScript.inst.gameState.data[3] -= 150;
				GlobalScript.inst.gameState.data[4] += 300;
				GlobalScript.inst.gameState.data[1] -= 300;
				GlobalScript.inst.gameState.data[5] -= 100;
				GlobalScript.inst.gameState.data[12] -= 200;
				GlobalScript.inst.gameState.data[13] -= 200;
				GlobalScript.inst.gameState.data[68] -= 200;
			}
			break;
		case 1:
			if (a.event_done[494] && a.resultOfEvents[494] == 0)
			{
				text = " 我 们 着 手 于 继 续 升 级 并 完 善 我 们 的 “ 中 国 长 城 ” 防 火 墙 系 统 ， 以 提 高 I E C S 应 对 外 部 攻 击 的 能 力 ， 与 此 同 时 ， 我 们 寻 求 苏 联 科 学 家 与 工 程 师 的 帮 助 ， 他 们 将 帮 助 我 们 迅 速 消 除 系 统 中 的 漏 洞 并 升 级 防 护 系 统 。 得 以 于 之 前 的 防 护 系 统 ， 我 们 的 经 济 所 遭 到 的 损 失 并 不 算 严 重 。";
				GlobalScript.inst.gameState.data[8] -= 10;
				GlobalScript.inst.gameState.data[3] -= 50;
				GlobalScript.inst.gameState.data[4] += 100;
				GlobalScript.inst.gameState.data[1] -= 300;
				GlobalScript.inst.gameState.data[5] -= 30;
			}
			else
			{
				text = " 政 府 紧 急 拨 款 开 发 了 一 个 工 作 代 号 为 “ 中 国 长 城 ” 的 系 统 ， 以 保 护IECS 免 受 外 部 攻 击 。 此 外 ， 我 们 请 求 苏 联 专 家 和 工 程 师 的 帮 助 ， 他 们 将 帮 助 我 们 迅 速 消 除 系 统 中 的 漏 洞 并 使 其 恢 复 运 行 。 人 们 认 为 ， 保 护 措 施 将 在 六 个 月 内 准 备 就 绪 并 投 入 使 用 ， 但 就 目 前 而 言 ， 我 们 的 经 济 不 会 一 帆 风 顺 。";
				GlobalScript.inst.gameState.data[8] -= 250;
				GlobalScript.inst.gameState.data[3] -= 150;
				GlobalScript.inst.gameState.data[4] += 300;
				GlobalScript.inst.gameState.data[1] -= 300;
				GlobalScript.inst.gameState.data[5] -= 100;
			}
			break;
		case 2:
			text = " 你 在 自 动 化 经 济 方 面 近 乎 开 玩 笑 的 态 度 惹 毛 了 大 多 数 党 员 — — 先 是 一 厢 情 愿 的 宣 布 中 国 将 全 面 施 行 自 动 化 ， 又 通 过 各 种 手 段 清 除 掉 与 你 关 系 最 不 好 的 反 对 派 头 头 ， 现 在 却 又 说 中 国 没 有 准 备 好 应 对 这 种 变 化 ； 党 受 够 了 你 的 领 导 ， 密 谋 者 暗 中 组 织 了 一 场 政 变 ， 将 你 解 职 并 踢 出 中 央 委 员 会 ， 丢 到 了 一 个 偏 远 的 清 水 衙 门 。";
			GlobalScript.inst.gameState.data[8] -= 250;
			GlobalScript.inst.gameState.data[3] -= 300;
			GlobalScript.inst.gameState.data[4] += 500;
			GlobalScript.inst.gameState.data[16] = 10;
			GlobalScript.inst.gameState.data[5] -= 100;
			GlobalScript.inst.gameState.data[12] -= 200;
			GlobalScript.inst.gameState.data[13] -= 200;
			GlobalScript.inst.gameState.data[68] -= 200;
			GlobalScript.inst.gameState.modifies[11].active = false;
			GlobalScript.inst.gameState.data[1] = 0;
			GlobalScript.inst.gameState.data[3] = 0;
			GlobalScript.inst.gameState.data[35] = 6;
			load_scene_after_click = true;
			break;
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
