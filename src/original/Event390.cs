using EventsForDLC;
using UnityEngine;

public class Event390 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		if (a.YugAgree)
		{
			GlobalScript.inst.new_events_text[1051] = " 1 9 8 1 年 举 行 的 上 届 法 国 议 会 选 举 中 ， 左 翼 联 盟 以 巨 大 优 势 获 胜 。 其 中 ， <color=#006400>社 会 党</color> 获 得 了 {1} % 的 选 票 ， 而 <color=#8B0000>共 产 党</color> 收 获 {2} % 的 支 持 。 因 此 ， <color=#8B0000>罗 兰 · 勒 罗 伊</color> 总 统 不 得 不 在 多 党 联 合 政 府 框 架 下 执 政 ， 该 国 政 府 由 <color=#8B0000>共 产 党 人 古 斯 塔 夫 · 安 萨 尔</color> 领 导 。||过 去 的 两 年 内 ， 法 国 社 会 主 义 政 府 引 入 了 一 系 列 的 激 进 改 革 ： 该 国 已 经 准 备 了 一 部 新 教 育 法 ， 关 键 部 门 与 经 济 领 域 已 被 国 有 化 ， 左 翼 控 制 的 工 会 权 力 已 经 大 大 扩 展 ； 选 举 上 ， 改 革 也 开 始 倾 向 下 层 阶 级 ， 资 产 阶 级 的 媒 体 权 限 限 制 被 限 制 ， 并 被 课 以 重 税 。 然 而 ， 改 革 者 遭 遇 到 了 来 自 欧 洲 一 体 化 结 构 的 障 碍 ， 后 者 完 全 是 基 于 自 由 主 义 经 济 原 则 运 行 的 组 织 ， 并 积 极 阻 碍 法 兰 西 银 行 的 工 作 。||在 内 部 ， <color=#8B0000>共 产 党</color> 和 <color=#006400>社 会 党</color> 的 右 翼 开 始 反 对 政 府 的 激 进 政 策 ， 他 们 以 激 进 改 革 导 致 的 形 势 恶 化 为 由 ， 积 极 阻 碍 改 革 。||需 要 注 意 的 是 ， 右 翼 政 党 绝 不 会 轻 易 接 受 自 己 的 失 败 ， 他 们 试 图 通 过 动 员 选 民 并 发 起 罢 工 和 抗 议 来 对 抗 政 府 的 激 进 主 义 政 策 。 而 对 产 业 与 银 行 部 门 的 国 有 化 导 致 了 资 本 外 流 与 税 源 减 少 的 问 题 ， 并 引 起 了 通 货 膨 胀 。 右 翼 已 经 团 结 起 来 ， 开 始 阻 止 左 翼 政 府 的 行 动 。 现 在 ， 法 国 比 以 往 任 何 时 候 都 要 更 接 近 政 治 危 机 。||目 前 ， 还 很 难 对 <color=#8B0000>罗 兰 · 勒 罗 伊</color> 的 选 举 承 诺 以 及 其 呼 吁 在 法 国 建 设 社 会 主 义 的 理 念 下 定 论 。 但 各 种 情 况 已 经 表 面 ， 权 力 关 系 的 演 变 正 朝 着 不 利 于 他 的 局 势 而 发 展 。";
		}
		name = GlobalScript.inst.new_events_text[1050];
		if (a.data[155] <= 0)
		{
			a.data[155] = Random.Range(31, 40);
		}
		if (a.data[156] <= 0)
		{
			a.data[156] = Random.Range(20, 25);
		}
		text = string.Format(GlobalScript.inst.new_events_text[1051], "\n", a.data[155], a.data[156], (a.empires[1].now_leader == 1) ? GlobalScript.inst.new_events_text[1052] : ((a.empires[1].now_leader == 2) ? GlobalScript.inst.new_events_text[1053] : GlobalScript.inst.new_events_text[1054]));
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (!a.YugAgree)
		{
			if (a.influencePRC >= 500 && a.data[9] >= 150 && a.data[8] + a.data[36] >= 100 && (a.IsFactionLeadeng(0) || a.IsFactionLeadeng(1) || a.IsFactionLeadeng(2)))
			{
				button_text[0] = " 为 法 国 渡 过 困 难 提 供 援 助";
			}
			else if (a.influencePRC < 500)
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[620], 50f);
			}
			else if (a.data[8] + a.data[36] < 100)
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 35f);
			}
			else if (a.data[9] < 150)
			{
				Object.Destroy(button[0]);
				button_text[0] = string.Format(GlobalScript.inst.new_events_text[567], 15f);
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = GlobalScript.inst.new_events_text[1054];
			}
			button_text[1] = GlobalScript.inst.new_events_text[1047];
		}
		else
		{
			if (a.allcountries[1].isSEV && a.data[9] >= 150 && a.data[8] + a.data[36] >= 150)
			{
				button_text[0] = " 动 员 苏 东 阵 营 向 法 国 政 府 共 同 提 供 援 助 并 邀 请 其 成 为 经 济 互 助 委 员 会 观 察 员 国";
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = GlobalScript.inst.new_events_text[579];
			}
			button_text[1] = GlobalScript.inst.new_events_text[1047];
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1050];
		int num = 0;
		if (a.allcountries[84].Gosstroy == 2)
		{
			num++;
		}
		if (!a.allcountries[85].isEU)
		{
			num++;
		}
		if (!a.allcountries[86].isEU)
		{
			num++;
		}
		if (!a.allcountries[87].isEU)
		{
			num++;
		}
		if (!a.allcountries[45].isEU)
		{
			num++;
		}
		if (a.allcountries[51].Torg)
		{
			num--;
		}
		if (a.allcountries[51].dev > 0)
		{
			num--;
		}
		num = ((a.empires[0].now_leader != 1) ? (num - 1) : (num + 1));
		if (a.empires[1].now_leader == 3)
		{
			num++;
		}
		int num2 = 0;
		for (int i = 0; i < a.allcountries.Length; i++)
		{
			if (a.allcountries[i].econ || (a.allcountries[1].isSEV && a.allcountries[i].isSEV))
			{
				num2++;
			}
		}
		if (num2 > 4)
		{
			num++;
		}
		else if (num2 > 9)
		{
			num += 2;
		}
		else if (num2 > 14)
		{
			num += 3;
		}
		num = ((a.data[7] <= a.empires[0].power) ? (num - 1) : (num + 1));
		if (!a.YugAgree)
		{
			switch (result_num)
			{
			case 0:
				a.data[9] -= 150;
				a.data[8] -= 100;
				Debug.Log("za " + num);
				text = "<color=#8B0000>乔 治 · 马 歇</color> 总 统 宣 布 将 启 动 第 二 轮 改 革 — — 法 国 宣 布 减 少 本 国 对 欧 洲 货 币 体 系 与 欧 洲 经 济 共 同 体 的 活 动 ， 并 称 后 者 的 政 策 “ 触 及 原 则 底 线 问 题 ， 并 与 国 家 的 社 会 经 济 发 展 方 向 背 道 而 驰 ” 。 同 时 ， 法 国 领 导 人 宣 布 将 通 过 新 法 案 ， 加 强 与 第 三 世 界 国 家 和 苏 东 国 家 的 经 贸 关 系 。 在 非 洲 政 策 上 ， 法 国 将 进 行 彻 底 去 殖 民 化 ， 结 束 与 非 洲 国 家 的 “ 新 殖 民 主 义 关 系 ” ， 并 资 助 非 洲 左 翼 。||部 分 由 <color=#006400>社 会 党</color> 人 与 右 翼 分 子 认 为 ， 这 项 政 策 标 志 着 法 国 对 欧 洲 - 大 西 洋 一 体 化 路 线 的 拒 绝 。 然 而 ， 一 部 分 来 自 <color=#006400>社 会 党</color> 的 左 派 成 员 支 持 政 府 的 新 政 。 因 此 ， 左 翼 联 盟 得 以 在 国 民 议 会 内 保 持 多 数 。 ";
				a.allcountries[21].isEU = false;
				a.empires[0].power -= 50;
				a.empires[1].power += 30;
				break;
			case 1:
				text = string.Format(GlobalScript.inst.new_events_text[1059], "\n");
				a.allcountries[21].Gosstroy = 3;
				a.allcountries[21].SubGosstroy = 5;
				a.empires[0].power += 50;
				break;
			}
			return;
		}
		switch (result_num)
		{
		case 0:
			text = " 在 此 之 后 ， <color=#8B0000>罗 兰 · 勒 罗 伊</color> 总 统 宣 布 将 启 动 第 二 轮 改 革 — — 法 国 宣 布 减 少 本 国 对 欧 洲 货 币 体 系 与 欧 洲 经 济 共 同 体 的 活 动 ， 并 称 后 者 的 政 策 “ 触 及 原 则 底 线 问 题 ， 并 与 国 家 的 社 会 经 济 发 展 方 向 背 道 而 驰 ” 。 同 时 ， 法 国 领 导 人 宣 布 将 通 过 新 法 案 ， 退 出 北 大 西 洋 公 约 组 织 的 军 事 一 体 化 部 门 。 新 政 府 通 过 了 组 织 工 人 赤 卫 队 的 法 律 ， 政 府 被 允 许 利 用 赤 卫 队 保 护 社 会 主 义 ， 并 对 右 翼 进 行 反 击 。 苏 联 和 东 德 的 顾 问 团 也 被 邀 请 驻 法 以 巩 固 政 府 。 更 加 深 入 的 经 济 改 革 也 正 在 开 展 ， 法 国 正 在 进 行 合 作 社 运 动 和 更 多 的 国 有 化 。 在 非 洲 政 策 上 ， 法 国 将 进 行 彻 底 去 殖 民 化 ， 结 束 与 非 洲 国 家 的 “ 新 殖 民 主 义 关 系 ” ， 并 资 助 非 洲 左 翼 。||很 快 ， 法 国 领 导 人 宣 布 将 通 过 新 法 案 ， 加 强 与 第 三 世 界 国 家 的 经 贸 关 系 ， 并 成 为 经 互 会 观 察 员 国 。 <color=#006400>社 会 党</color> 右 派 与 右 翼 分 子 认 为 ， 这 项 政 策 标 志 着 法 国 对 欧 洲 - 大 西 洋 一 体 化 路 线 的 拒 绝 。 然 而 ， <color=#006400>社 会 党</color> 左 派 的 成 员 支 持 政 府 的 新 政 。 因 此 ， 左 翼 联 盟 得 以 在 国 民 议 会 内 保 持 多 数 。";
			a.data[9] -= 150;
			a.data[8] -= 150;
			a.allcountries[21].isEU = false;
			a.allcountries[21].isNATO = false;
			a.allcountries[21].Gosstroy = 1;
			a.allcountries[21].SubGosstroy = 1;
			a.allcountries[21].prosov = true;
			GlobalScript.inst.gameState.empires[1].leaders[4].support++;
			a.empires[0].power -= 80;
			a.empires[1].power += 80;
			break;
		case 1:
			text = " 在 罢 工 、 抗 议 和 政 府 内 部 的 不 和 的 巨 大 压 力 之 下 ， 总 统 和 政 府 不 得 不 双 双 选 择 辞 职 。 极 右 翼 政 党 <color=#8B4513>国 民 阵 线</color> 利 用 了 群 众 对 左 翼 的 失 望 和 对 苏 联 的 情 绪 ， 以 及 右 翼 选 民 对 中 右 翼 两 党 的 失 望 ， <color=#8B4513>勒 庞</color> 得 益 于 他 的 民 粹 主 义 言 论 ， 在 选 举 中 取 得 以 微 弱 优 势 胜 利 。 <color=#8B4513>让 - 玛 丽 · 勒 庞</color> 当 选 为 新 一 届 总 统 ， 而 在 议 会 选 举 中 ， <color=#8B4513>国 民 阵 线</color> 也 得 以 组 成 勒 庞 - 戴 高 乐 主 义 政 府 。 <color=#8B4513>勒 庞</color> 总 统 宣 布 将 启 动 再 私 有 化 政 策 ， 并 强 调 了 对 第 五 共 和 国 的 政 治 进 行 改 革 的 必 要 性 。 法 国 社 会 就 这 样 迎 来 了 一 个 右 转 时 期 … …";
			a.allcountries[21].Gosstroy = 0;
			a.allcountries[21].SubGosstroy = 7;
			a.allcountries[21].isEU = false;
			a.allcountries[21].isNATO = false;
			a.modifies[44].active = false;
			a.empires[0].power += 50;
			break;
		}
	}
}
