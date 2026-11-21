using EventsForDLC;
using UnityEngine;

public class Event32 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 乌 兰 巴 托 的 夜";
		text = " 在 1 9 8 2 年 勃 列 日 涅 夫 去 世 后 ， 苏 联 新 领 导 层 认 为 尤 睦 佳 · 泽 登 巴 尔 的 年 迈 以 及 他 反 复 无 常 的 行 为 正 在 成 为 一 种 负 担 。 1 9 8 4 年 8 月 9 日 ， 当 泽 登 巴 尔 在 莫 斯 科 度 假 时 ， 克 里 姆 林 宫 的 医 生 诊 断 他 患 有 “ 过 度 劳 累 ” ， 决 定 让 他 退 休 ， 由 新 领 导 人 取 代 他 。 这 位 “ 红 可 汗 ” 终 于 要 下 台 了 ， 我 们 是 否 要 做 些 什 么 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.resultOfEvents[549] == 0 && GlobalScript.inst.gameState.event_done[549] && a.allcountries[1].Gosstroy != 2 && a.allcountries[1].Gosstroy != 0 && a.relres && a.influencePRC >= 500)
		{
			button_text[0] = " 支 持 反 泽 登 巴 尔 的 反 对 派 夺 权";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 会 知 道 那 么 多 的 … …";
		}
		button_text[1] = " 北 边 的 一 片 荒 地 不 值 得 我 们 投 入 那 么 多 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 乌 兰 巴 托 的 夜";
		switch (result_num)
		{
		case 0:
			text = " 由 于 泽 登 巴 尔 及 其 支 持 者 在 此 前 的 影 响 力 就 已 动 摇 ， 被 平 反 的 反 对 派 与 扎 兰 阿 扎 布 得 以 拧 成 一 股 绳 ， 在 非 常 中 央 全 会 上 ， 一 群 不 满 的 党 员 攻 击 了 泽 登 巴 尔 ， 指 控 他 破 坏 党 内 民 主 、 搞 一 言 堂 ， 并 且 导 致 民 众 贫 困 ， 造 成 了 短 缺 经 济 。 许 多 代 表 支 持 了 这 一 不 满 ， 而 泽 登 巴 尔 被 从 所 有 职 位 上 移 除 并 退 休 ， 他 将 呆 在 苏 联 治 疗 疾 病 。 新 的 总 书 记 是 泽 登 巴 尔 的 反 对 者 达 拉 姆 · 图 木 尔 奥 其 尔 。 之 前 因 试 图 推 行 独 立 经 济 政 策 而 蒙 羞 的 鲁 布 桑 策 伦 · 曾 德 则 担 任 总 理 。 为 了 避 免 再 出 现 类 似 泽 登 巴 尔 搞 一 言 堂 的 情 况 ， 由 主 席 、 副 主 席 、 十 六 位 常 委 和 一 位 总 书 记 组 成 的 集 体 性 的 实 体 主 席 团 将 成 为 新 的 国 家 领 导 机 构 ， 扎 兰 阿 扎 布 、 丹 巴 、 洛 呼 兹 、 宁 布 、 苏 尔 玛 扎 布 等 人 都 将 在 其 中 任 职 。 新 的 蒙 古 领 导 层 结 束 了 长 期 以 来 的 亲 苏 政 策 并 退 出 了 经 互 会 ， 开 始 向 我 们 靠 拢 。 与 此 同 时 ， 苏 联 驻 军 也 开 始 撤 出 蒙 古 。";
			if ((a.allcountries[1].Gosstroy == 1 && a.modifies[6].active) || a.allcountries[1].SubGosstroy == 0)
			{
				GlobalScript.inst.gameState.allcountries[9].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[9].SubGosstroy = 2;
			}
			else if (a.allcountries[1].Gosstroy == 1 && !a.modifies[6].active)
			{
				GlobalScript.inst.gameState.allcountries[9].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[9].SubGosstroy = 1;
			}
			else if (a.allcountries[1].Gosstroy == 2 && !a.modifies[6].active)
			{
				GlobalScript.inst.gameState.allcountries[9].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[9].SubGosstroy = 15;
			}
			GlobalScript.inst.gameState.allcountries[9].Torg = true;
			GlobalScript.inst.gameState.allcountries[9].prosov = false;
			GlobalScript.inst.gameState.allcountries[9].proprc = true;
			GlobalScript.inst.gameState.allcountries[9].isSEV = false;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.influencePRC += 20;
			break;
		case 1:
			if (GlobalScript.inst.gameState.resultOfEvents[549] == 0 && GlobalScript.inst.gameState.event_done[549])
			{
				text = " 1 9 8 4 年 8 月 2 3 日 ， 蒙 古 人 民 革 命 党 中 央 委 员 会 举 行 的 非 常 全 会 解 除 了 泽 登 巴 尔 担 任 的 蒙 古 人 民 革 命 党 中 央 委 员 会 总 书 记 和 政 治 局 委 员 的 职 务 。 同 日 ， 蒙 古 大 人 民 呼 拉 尔 第 五 次 会 议 解 除 了 泽 登 巴 尔 的 大 人 民 呼 拉 尔 主 席 团 主 席 职 务 。 此 后 ， 泽 登 巴 尔 在 苏 联 居 住 。 蒙 古 第 二 号 人 物 桑 丕 勒 · 扎 兰 阿 扎 布 当 选 为 蒙 古 人 民 革 命 党 中 央 委 员 会 总 书 记 ， 同 年 1 2 月 1 2 日 被 任 命 为 大 人 民 呼 拉 尔 主 席 团 主 席 。 他 结 束 了 蒙 古 的 亲 苏 政 策 ， 并 开 始 寻 求 更 加 独 立 的 政 策 。";
				GlobalScript.inst.gameState.empires[1].power -= 10;
				GlobalScript.inst.gameState.empires[1].relations -= 80;
				GlobalScript.inst.gameState.allcountries[9].prosov = false;
			}
			else
			{
				text = " 1 9 8 4 年 8 月 2 3 日 ， 蒙 古 人 民 革 命 党 中 央 委 员 会 举 行 的 非 常 全 会 解 除 了 泽 登 巴 尔 担 任 的 蒙 古 人 民 革 命 党 中 央 委 员 会 总 书 记 和 政 治 局 委 员 的 职 务 。 同 日 ， 蒙 古 大 人 民 呼 拉 尔 第 五 次 会 议 解 除 了 泽 登 巴 尔 的 大 人 民 呼 拉 尔 主 席 团 主 席 职 务 。 此 后 ， 泽 登 巴 尔 在 苏 联 居 住 。 保 守 派 的 姜 巴 · 巴 特 蒙 赫 当 选 为 蒙 古 人 民 革 命 党 中 央 委 员 会 总 书 记 ， 同 年 1 2 月 1 2 日 被 任 命 为 大 人 民 呼 拉 尔 主 席 团 主 席 。 巴 特 蒙 赫 在 中 蒙 关 系 上 采 取 了 更 加 务 实 的 态 度 ， 希 望 推 进 蒙 中 关 系 正 常 化 。";
				GlobalScript.inst.gameState.empires[1].power += 10;
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
