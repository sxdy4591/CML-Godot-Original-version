using EventsForDLC;
using UnityEngine;

public class Event654 : EventsSecond
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
		name = " 西 非 巨 人 — — 第 二 幕";
		text = "尼 日 利 亚 第 二 共 和 国 的 第 二 次 大 选 即 将 开 始 ， 这 届 选 举 的 局 势 同 上 次 大 选 截 然 不 同 — —";
		if (a.allcountries[60].SubGosstroy == 12)
		{
			text += "尼 日 利 亚 各 方 面 相 比 上 次 大 选 都 有 所 退 行 。 同 许 多 当 代 非 洲 国 家 类 似 ， 尼 日 利 亚 政 府 广 泛 干 预 社 会 经 济 ， 官 员 徇 私 舞 弊 ， 导 致 腐 败 泛 滥 。 沙 加 里 政 府 治 理 无 能 ， 经 济 措 施 失 当 ， 政 府 制 订 依 赖 石 油 税 收 的 投 资 计 划 （ 尽 管 取 得 了 一 定 成 果 ） ， 因 石 油 价 格 下 跌 ， 导 致 了 财 政 的 紧 张 ， 并 引 发 了 外 汇 危 机 和 经 济 滞 涨 。 沙 加 里 不 得 不 实 施 受 国 际 货 币 基 金 组 织 支 持 的 经 济 自 由 化 计 划 ， 却 引 发 民 众 贫 困 及 不 满 ， 失 业 现 象 大 幅 增 加 。 除 了 经 济 萧 条 ， 尼 日 利 亚 工 业 、 农 业 也 得 到 了 衰 退 ， 国 家 变 得 更 加 依 赖 进 口 了 。 在 这 种 情 况 下 ， 国 民 党 政 治 家 却 趁 机 捞 取 利 益 ， 甚 至 想 利 用 权 力 推 迟 大 选 ， 增 加 政 府 的 任 期 时 间 。||在 选 举 上 ， 尼 日 利 亚 国 民 党 和 尼 日 利 亚 人 民 党 的 执 政 联 盟 早 已 破 裂 ， 主 要 反 对 党 尼 日 利 亚 统 一 党 正 在 尝 试 推 进 同 尼 日 利 亚 人 民 党 、 人 民 救 国 党 和 大 尼 日 利 亚 人 民 党 部 分 成 员 一 起 建 立 一 个 进 步 党 团 联 盟 ， 共 同 对 抗 保 守 派 。 而 掌 权 的 国 民 党 也 正 打 算 使 用 一 些 “ 非 正 常 ” 方 式 来 赢 得 大 选 … …";
		}
		else if (a.allcountries[60].SubGosstroy == 4)
		{
			text += "阿 沃 罗 沃 政 府 在 上 台 后 尝 试 推 进 社 会 福 利 建 设 ， 推 广 免 费 教 育 和 免 费 医 疗 ， 以 及 投 资 开 展 农 村 发 展 计 划 并 加 强 基 础 设 施 建 设 ， 但 这 些 计 划 依 赖 石 油 税 收 ， 因 石 油 价 格 下 跌 ， 导 致 了 财 政 的 紧 张 ， 并 引 发 了 外 汇 危 机 和 经 济 滞 涨 ， 使 得 福 利 主 义 改 革 计 划 无 法 完 全 落 实 。 阿 沃 罗 沃 不 得 不 实 施 受 国 际 货 币 基 金 组 织 支 持 的 经 济 自 由 化 计 划 ， 却 引 发 民 众 贫 困 及 不 满 ， 失 业 现 象 大 幅 增 加 。 阿 沃 罗 沃 尝 试 通 过 修 改 宪 法 来 恢 复 第 一 共 和 国 的 更 分 权 的 大 区 模 式 和 其 打 压 北 方 、 强 化 约 鲁 巴 部 族 政 治 地 位 的 企 图 最 终 使 得 进 步 派 联 盟 最 终 走 向 了 破 裂 。||在 选 举 上 ， 由 于 进 步 派 力 量 的 执 政 地 位 ， 尼 日 利 亚 人 民 党 和 人 民 救 国 党 的 力 量 都 得 到 了 增 强 ， 他 们 决 定 单 独 参 加 大 选 ； 另 一 方 面 ， 阿 沃 罗 沃 的 失 败 进 步 改 革 也 强 化 了 民 间 对 反 对 党 尼 日 利 亚 国 民 党 的 呼 声 。";
		}
		text += string.Format("在 国 内 矛 盾 的 背 景 下 ， 反 建 制 力 量 也 得 以 壮 大 。 扬 塔 特 斯 尼 组 织 吸 引 了 大 批 不 满 现 状 的 年 轻 人 和 失 业 者 ， 力 量 不 断 增 强 ， 导 致 尼 日 利 亚 国 内 的 宗 教 关 系 紧 张 。1980 年 ， 扬 塔 特 斯 尼 在 卡 诺 发 起 了 一 场 暴 动 ， 最 终 导 致 军 队 介 入 ， 这 便 是 扬 塔 特 斯 尼 叛 乱 的 开 端 。{1}虽 然 马 尔 瓦 在 暴 动 被 镇 压 后 不 久 去 世 ， 但 他 的 亲 密 弟 子 穆 萨 · 阿 里 · 苏 莱 曼 成 为 了 继 任 者 。 在1982 年 ， 迈 杜 古 里 和 卡 杜 纳 等 地 也 爆 发 了 扬 塔 特 斯 尼 的 追 随 者 制 造 的 骚 乱 。||也 许 ， 现 在 是 我 们 插 手 的 时 候 了 ？", "\n", (a.allcountries[60].SubGosstroy == 12) ? " 事 后 ， 沙 加 里 政 府 宣 布 驱 逐 尼 日 利 亚 的 西 非 移 民 （ 因 为 扬 塔 特 斯 尼 中 有 来 自 尼 日 尔 和 喀 麦 隆 等 地 的 人 ） ， 这 遭 到 了 国 际 社 会 的 广 泛 谴 责 。" : null);
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		int num = 0;
		for (int i = 0; i < a.allcountries.Length; i++)
		{
			if ((a.allcountries[i].Gosstroy == 2 || a.IsSocialism(yes: true, i) || a.allcountries[i].SubGosstroy == 10) && (i == 59 || i == 112 || i == 113 || i == 114 || i == 68 || i == 107 || i == 67 || i == 64 || i == 63 || i == 62 || i == 108 || i == 61 || i == 62 || i == 56 || i == 58))
			{
				num++;
			}
		}
		if (a.allcountries[60].SubGosstroy == 12)
		{
			kolvo_variant = 4;
			if (a.data[56] >= 2)
			{
				button_text[0] = "支 持 沙 加 里 维 持 权 力";
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = " 我 们 不 会 支 持 保 守 派";
			}
			if (GlobalScript.inst.gameState.data[56] <= 2 && GlobalScript.inst.gameState.data[56] >= 1)
			{
				button_text[1] = " 我 们 支 持 进 步 派 党 团 联 盟 的 最 终 实 现";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 没 必 要 把 资 源 浪 费 在 非 洲 的 选 举 事 务 上 … …";
			}
			if (GlobalScript.inst.gameState.data[56] <= 3 && GlobalScript.inst.gameState.data[56] >= 1 && !a.modifies[3].active && a.data[31] >= 600 && a.resultOfEvents[653] != 3)
			{
				button_text[2] = " 何 不 支 持 扬 塔 特 斯 尼 组 织 ？";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 我 们 不 会 去 找 他 们 ！";
			}
			button_text[3] = " 非 洲 的 民 主 和 大 选 本 就 是 儿 戏 … … 我 不 是 说 过 我 对 这 个 尼 什 么 不 感 兴 趣 了 吗 ？";
			button_text[5] = "";
			return;
		}
		kolvo_variant = 6;
		if (a.data[56] >= 2)
		{
			button_text[0] = "支 持 国 民 党";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 必 要 把 资 源 浪 费 在 非 洲 的 选 举 事 务 上 … …";
		}
		if (GlobalScript.inst.gameState.data[56] <= 3 && GlobalScript.inst.gameState.data[56] >= 1)
		{
			button_text[1] = " 支 持 统 一 党";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 必 要 把 资 源 浪 费 在 非 洲 的 选 举 事 务 上 … …";
		}
		if (GlobalScript.inst.gameState.data[56] <= 3 && GlobalScript.inst.gameState.data[56] >= 1)
		{
			button_text[2] = " 支 持 人 民 党";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 他 们 的 力 量 不 够 强 大";
		}
		if (GlobalScript.inst.gameState.data[56] <= 2 && num > 5)
		{
			button_text[3] = " 支 持 人 民 救 国 党";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 没 必 要 把 资 源 浪 费 在 非 洲 的 选 举 事 务 上 … …";
		}
		if (GlobalScript.inst.gameState.data[56] <= 3 && GlobalScript.inst.gameState.data[56] >= 1 && !a.modifies[3].active && a.data[31] >= 600 && a.resultOfEvents[653] != 3)
		{
			button_text[4] = " 何 不 支 持 扬 塔 特 斯 尼 组 织 ？";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 我 们 不 会 去 找 他 们 ！";
		}
		button_text[5] = "非 洲 的 民 主 和 大 选 本 就 是 儿 戏 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 西 非 巨 人 — — 第 二 幕";
		if (a.allcountries[60].SubGosstroy == 12)
		{
			switch (result_num)
			{
			case 0:
				text = " 沙 加 里 领 导 的 国 民 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 沙 加 里 再 次 当 选 总 统 ， 国 民 党 在 各 级 政 府 的 职 位 与 议 院 的 议 席 大 增 。 但 此 次 选 举 充 满 腐 败 和 不 正 当 交 易 ， 激 化 了 政 府 与 其 他 党 派 、 民 众 的 矛 盾 ， 政 治 危 机 加 剧 。 与1979 年 选 举 相 比 ，1983 年 选 举 的 不 法 行 为 猛 增 。 在 选 举 中 ， 政 治 对 手 采 用 消 极 的 竞 选 方 式 ， 如 利 用 部 族 、 宗 教 煽 动 ， 进 行 人 身 攻 击 甚 至 谋 杀 。 大 选 中 ， 政 治 家 威 胁 操 纵 选 举 致 社 会 动 荡 ， 还 存 在 贿 赂 、 造 假 票 、 恐 吓 官 员 、 涂 改 名 单 等 不 正 当 行 为 ， 甚 至 ， 不 需 要 我 们 的 过 多 帮 助 ， 国 民 党 便 轻 松 赢 得 了 大 选 。 新 政 府 感 谢 我 们 的 帮 助 ， 同 我 们 达 成 了 一 些 合 作 协 定 。 尼 日 利 亚 国 内 的 混 乱 和 萧 条 并 未 结 束 ， 也 许 ， 不 满 终 会 酿 成 些 什 么 东 西 … …";
				a.allcountries[60].LeaveAlliances();
				a.allcountries[60].Gosstroy = 3;
				a.allcountries[60].SubGosstroy = 12;
				a.allcountries[60].Torg = true;
				a.data[8] -= 40;
				a.data[9] -= 40;
				a.OilProd += 100f;
				break;
			case 1:
				text = " 经 过 艰 难 的 谈 判 和 我 们 的 大 力 投 入 ， 尼 日 利 亚 统 一 党 、 尼 日 利 亚 人 民 党 、 人 民 救 国 党 和 大 尼 日 利 亚 人 民 党 组 成 了 进 步 党 团 联 盟 。 由 于 我 们 的 资 金 输 入 、 特 勤 对 国 民 党 的 选 举 的 扰 乱 和 媒 体 对 尼 日 利 亚 国 民 党 的 选 举 作 弊 的 行 径 的 大 规 模 曝 光 ， 最 终 ， 进 步 党 团 联 盟 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 奥 巴 费 米 · 阿 沃 罗 沃 成 为 了 总 统 。 新 政 府 感 谢 我 们 的 帮 助 ， 同 我 们 达 成 了 一 些 合 作 协 定 。 人 们 正 在 期 待 新 政 府 对 局 势 的 扭 转 ， 但 是 在 混 乱 和 萧 条 的 条 件 下 ， 新 政 府 真 的 能 做 什 么 吗 ？";
				a.allcountries[60].LeaveAlliances();
				a.allcountries[60].Gosstroy = 3;
				a.allcountries[60].SubGosstroy = 4;
				a.allcountries[60].Torg = true;
				a.data[8] -= 160;
				a.data[9] -= 160;
				a.OilProd += 100f;
				a.allcountries[60].stab = 1;
				break;
			case 2:
				text = " 反 西 方 主 义 的 扬 塔 特 斯 尼 已 经 证 明 了 他 们 的 好 成 绩 ， 让 我 们 来 支 持 他 们 。 大 使 馆 联 系 到 穆 萨 · 阿 里 · 苏 莱 曼 ， 很 快 ， 一 批 武 器 和 资 金 便 送 到 了 扬 塔 特 斯 尼 组 织 手 中 。||不 出 所 料 ， 沙 加 里 领 导 的 国 民 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 沙 加 里 再 次 当 选 总 统 ， 国 民 党 在 各 级 政 府 的 职 位 与 议 院 的 议 席 大 增 。 但 此 次 选 举 充 满 腐 败 和 不 正 当 交 易 ， 激 化 了 政 府 与 其 他 党 派 、 民 众 的 矛 盾 ， 政 治 危 机 加 剧 。 与1979 年 选 举 相 比 ，1983 年 选 举 的 不 法 行 为 猛 增 。 在 选 举 中 ， 政 治 对 手 采 用 消 极 的 竞 选 方 式 ， 如 利 用 部 族 、 宗 教 煽 动 ， 进 行 人 身 攻 击 甚 至 谋 杀 。 大 选 中 ， 政 治 家 威 胁 操 纵 选 举 致 社 会 动 荡 ， 还 存 在 贿 赂 、 造 假 票 、 恐 吓 官 员 、 涂 改 名 单 等 不 正 当 行 为 。 尼 日 利 亚 国 内 的 混 乱 和 萧 条 并 未 结 束 ， 也 许 ， 不 满 终 会 酿 成 些 什 么 东 西 … …";
				a.allcountries[60].LeaveAlliances();
				a.allcountries[60].Gosstroy = 3;
				a.allcountries[60].SubGosstroy = 12;
				a.allcountries[60].cw = true;
				if (a.resultOfEvents[653] == 2)
				{
					a.allcountries[60].prcpower += 20;
				}
				else
				{
					a.allcountries[60].prcpower = 20;
				}
				a.data[8] -= 100;
				a.data[9] -= 100;
				a.data[22] -= 100;
				break;
			case 3:
				text = " 不 出 所 料 ， 沙 加 里 领 导 的 国 民 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 沙 加 里 再 次 当 选 总 统 ， 国 民 党 在 各 级 政 府 的 职 位 与 议 院 的 议 席 大 增 。 但 此 次 选 举 充 满 腐 败 和 不 正 当 交 易 ， 激 化 了 政 府 与 其 他 党 派 、 民 众 的 矛 盾 ， 政 治 危 机 加 剧 。 与1979 年 选 举 相 比 ，1983 年 选 举 的 不 法 行 为 猛 增 。 在 选 举 中 ， 政 治 对 手 采 用 消 极 的 竞 选 方 式 ， 如 利 用 部 族 、 宗 教 煽 动 ， 进 行 人 身 攻 击 甚 至 谋 杀 。 大 选 中 ， 政 治 家 威 胁 操 纵 选 举 致 社 会 动 荡 ， 还 存 在 贿 赂 、 造 假 票 、 恐 吓 官 员 、 涂 改 名 单 等 不 正 当 行 为 。 尼 日 利 亚 国 内 的 混 乱 和 萧 条 并 未 结 束 ， 也 许 ， 不 满 终 会 酿 成 些 什 么 东 西 … …";
				break;
			}
			if (result_num == 5)
			{
				text = "";
			}
			return;
		}
		switch (result_num)
		{
		case 0:
			text = " 得 益 于 统 一 党 的 政 策 失 当 以 及 我 们 的 资 金 输 入 、 特 勤 对 其 他 政 党 的 选 举 的 扰 乱 和 媒 体 对 其 他 政 党 的 选 举 作 弊 的 行 径 的 大 规 模 曝 光 ， 最 终 ， 国 民 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 并 获 得 了 人 民 党 议 员 的 支 持 ， 谢 胡 · 沙 加 里 成 为 了 总 统 。 新 政 府 感 谢 我 们 的 帮 助 ， 同 我 们 达 成 了 一 些 合 作 协 定 。 人 们 正 在 期 待 保 守 派 新 政 府 对 局 势 的 扭 转 ， 但 是 在 混 乱 和 萧 条 的 条 件 下 ， 新 政 府 真 的 能 做 什 么 吗 ？";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Gosstroy = 3;
			a.allcountries[60].SubGosstroy = 12;
			a.allcountries[60].Torg = true;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.OilProd += 100f;
			break;
		case 1:
			text = " 我 们 的 竞 选 资 金 和 特 勤 被 用 来 帮 助 统 一 党 的 选 举 。 阿 沃 罗 沃 领 导 的 统 一 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 阿 沃 罗 沃 再 次 当 选 总 统 ， 统 一 党 在 各 级 政 府 的 职 位 与 议 院 的 议 席 大 增 ， 并 获 得 了 其 他 进 步 派 政 党 的 部 分 议 员 的 支 持 。 但 此 次 选 举 充 满 腐 败 和 不 正 当 交 易 ， 激 化 了 政 府 与 其 他 党 派 、 民 众 的 矛 盾 ， 政 治 危 机 加 剧 。 与1979 年 选 举 相 比 ，1983 年 选 举 的 不 法 行 为 猛 增 。 在 选 举 中 ， 政 治 对 手 采 用 消 极 的 竞 选 方 式 ， 如 利 用 部 族 、 宗 教 煽 动 ， 进 行 人 身 攻 击 甚 至 谋 杀 。 大 选 中 ， 政 治 家 威 胁 操 纵 选 举 致 社 会 动 荡 ， 还 存 在 贿 赂 、 造 假 票 、 恐 吓 官 员 、 涂 改 名 单 等 不 正 当 行 为 。 新 政 府 感 谢 我 们 的 帮 助 ， 同 我 们 达 成 了 一 些 合 作 协 定 。 尼 日 利 亚 国 内 的 混 乱 和 萧 条 并 未 结 束 ， 也 许 ， 不 满 终 会 酿 成 些 什 么 东 西 … …";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Gosstroy = 3;
			a.allcountries[60].SubGosstroy = 4;
			a.allcountries[60].Torg = true;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.OilProd += 100f;
			break;
		case 2:
			text = " 得 益 于 统 一 党 的 政 策 失 当 以 及 我 们 的 资 金 输 入 、 特 勤 对 其 他 政 党 的 选 举 的 扰 乱 和 媒 体 对 其 他 政 党 的 选 举 作 弊 的 行 径 的 大 规 模 曝 光 ， 最 终 ， 人 民 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 并 获 得 了 进 步 派 议 员 的 支 持 ， 纳 姆 迪 · 阿 齐 克 韦 成 为 了 总 统 。 新 政 府 感 谢 我 们 的 帮 助 ， 同 我 们 达 成 了 一 些 合 作 协 定 。 人 们 正 在 期 待 这 位 独 立 元 勋 的 新 政 府 对 局 势 的 扭 转 ， 但 是 在 混 乱 和 萧 条 的 条 件 下 ， 新 政 府 真 的 能 做 什 么 吗 ？";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Gosstroy = 2;
			a.allcountries[60].SubGosstroy = 8;
			a.allcountries[60].Torg = true;
			a.data[8] -= 160;
			a.data[9] -= 160;
			a.OilProd += 100f;
			break;
		case 3:
			text = "  得 益 于 西 非 浓 厚 的 左 翼 氛 围 以 及 我 们 的 资 金 输 入 、 特 勤 对 其 他 政 党 的 选 举 的 扰 乱 和 媒 体 对 其 他 政 党 的 选 举 作 弊 的 行 径 的 大 规 模 曝 光 ， 最 终 ， 人 民 救 国 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 并 获 得 了 部 分 进 步 政 党 的 支 持 ， 哈 里 法 · 哈 桑 · 优 素 福 （ 卡 诺 已 于 不 久 前 去 世 ） 成 为 了 总 统 。 新 政 府 感 谢 我 们 的 帮 助 ， 同 我 们 达 成 了 一 些 合 作 协 定 。 人 们 正 在 期 待 新 政 府 对 局 势 的 扭 转 ， 但 是 在 混 乱 和 萧 条 的 条 件 下 ， 新 政 府 真 的 能 做 什 么 吗 ";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Gosstroy = 2;
			a.allcountries[60].SubGosstroy = 3;
			a.allcountries[60].Torg = true;
			a.data[8] -= 200;
			a.data[9] -= 200;
			a.OilProd += 100f;
			break;
		case 4:
			text = " 我 们 的 大 使 馆 联 系 到 穆 罕 默 德 · 马 尔 瓦 ， 表 示 我 们 愿 意 和 扬 塔 特 斯 尼 组 织 一 起 打 倒 邪 恶 的 西 方 物 质 主 义 的 入 侵 。 很 快 ， 一 批 武 器 和 资 金 便 送 到 了 扬 塔 特 斯 尼 组 织 中 。 尼 日 利 亚 当 局 谴 责 我 们 干 涉 他 国 内 政 ， 宣 布 降 低 与 我 国 的 外 交 关 系 。||在7 月7 日 的 参 议 院 选 举 中 ， 尼 日 利 亚 国 民 党 赢 得 了 参 议 院95 个 席 位 中 的36 席 ， 占37.9 % 。 统 一 党 获 得 了28 席 ， 占29.5 % 。 人 民 党 获 得 了16 席 ， 占16.9 % 。 救 国 党 获 得 了7 席 ， 占7.3 % 。 大 尼 日 利 亚 人 民 党 获 得 了8 席 ， 占8.4 % 。7 月14 日 的 众 议 院 的 选 举 ， 国 民 党 也 占 优 势 ， 在 总 数 为449 个 议 席 中 ， 国 民 党 得 了168 席 ， 占37.4 % 。 统 一 党 得 了111 席 ， 占24.7 % , 居 第 二 位 。 人 民 党 居 第 三 位 ， 得 了79 席 ， 占17.5 % 。 居 第 四 位 的 是 救 国 党 ， 得 了49 席 ， 占10.9 % 。 居 最 后 一 位 的 是 大 尼 日 利 亚 人 民 党 ， 获 得 了48 席 ， 占10.69 % 。 最 终 ， 沙 加 里 的 尼 日 利 亚 国 民 党 与 阿 齐 克 韦 的 尼 日 利 亚 人 民 党 经 过 谈 判 在 议 会 中 达 成 了 联 盟 ， 获 得 了 多 数 席 位 。||8 月16 日 ， 尼 日 利 亚 举 行 全 民 总 统 大 选 的 投 票 ， 共 有1684 万 选 民 参 加 了 选 举 。 结 果 ， 国 民 党 候 选 人 沙 加 里 获 得568 万 张 选 票 ， 占 总 数 的33.8 % ， 并 在19 个 州 中 的12 个 州 里 得 票 率 超 过 了25 % ， 从 而 达 到 了 宪 法 所 规 定 的 当 选 新 总 统 的 票 数 。10 月1 日 ， 在 尼 日 利 亚 庆 祝 独 立 和 建 国19 周 年 的 时 候 ， 奥 巴 桑 乔 军 政 府 在 首 都 拉 各 斯 举 行 了 规 模 盛 大 的 “ 还 政 于 民 ” 政 权 交 接 仪 式 ， 尼 日 利 亚 第 二 共 和 国 成 立 ， 沙 加 里 宣 誓 就 任 总 统 。 在 非 洲 大 陆 军 人 政 权 盛 行 ， 军 事 政 变 不 断 的 时 候 ， 尼 日 利 亚 还 政 于 民 的 成 功 ， 民 选 的 文 官 新 总 统 的 就 职 ， 在 非 洲 产 生 了 重 大 的 影 响 ， 奥 巴 桑 乔 受 到 非 洲 和 国 际 社 会 的 高 度 赞 誉 。";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Gosstroy = 3;
			a.allcountries[60].SubGosstroy = 12;
			a.data[8] -= 100;
			a.data[9] -= 100;
			if (a.resultOfEvents[653] == 2)
			{
				a.allcountries[60].prcpower += 20;
			}
			else
			{
				a.allcountries[60].prcpower = 20;
			}
			a.allcountries[60].cw = true;
			a.data[22] -= 100;
			break;
		case 5:
			text = " 阿 沃 罗 沃 领 导 的 统 一 党 在 参 众 两 院 及 总 统 选 举 中 获 胜 ， 阿 沃 罗 沃 再 次 当 选 总 统 ， 统 一 党 在 各 级 政 府 的 职 位 与 议 院 的 议 席 大 增 。 但 此 次 选 举 充 满 腐 败 和 不 正 当 交 易 ， 激 化 了 政 府 与 其 他 党 派 、 民 众 的 矛 盾 ， 政 治 危 机 加 剧 。 与1979 年 选 举 相 比 ，1983 年 选 举 的 不 法 行 为 猛 增 。 在 选 举 中 ， 政 治 对 手 采 用 消 极 的 竞 选 方 式 ， 如 利 用 部 族 、 宗 教 煽 动 ， 进 行 人 身 攻 击 甚 至 谋 杀 。 大 选 中 ， 政 治 家 威 胁 操 纵 选 举 致 社 会 动 荡 ， 还 存 在 贿 赂 、 造 假 票 、 恐 吓 官 员 、 涂 改 名 单 等 不 正 当 行 为 。 尼 日 利 亚 国 内 的 混 乱 和 萧 条 并 未 结 束 ， 也 许 ， 不 满 终 会 酿 成 些 什 么 东 西 … … ";
			break;
		}
	}
}
