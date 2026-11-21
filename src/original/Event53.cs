using EventsForDLC;
using UnityEngine;

public class Event53 : EventsSecond
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
		GlobalScript.inst.old_modify_desc[15] = " 根 据 农 业 发 展 情 况 获 得 效 果";
		if (GlobalScript.inst.gameState.science[3])
		{
			GlobalScript.inst.old_modify_desc[15] += "<color=red>| 农 业 机 械 化 ：</color>| 农 业+0.6 ， 工 业+0.4";
		}
		if (GlobalScript.inst.gameState.science[6])
		{
			GlobalScript.inst.old_modify_desc[15] += "<color=red>| 普 及 化 肥 与 杀 虫 剂 ：</color>| 农 业+0.3 ， 生 活 水 平+0.4";
		}
		if (GlobalScript.inst.gameState.science[7])
		{
			GlobalScript.inst.old_modify_desc[15] += "<color=red>| 转 基 因 技 术 ：</color>| 农 业+0.2 ， 工 业+0.2 ， 生 活 水 平+0.5 ， 预 算+0.3";
		}
		name = " 农 业 改 革";
		text = " 目 前 ， 中 国 实 行 的 人 民 公 社 制 度 确 立 于50 年 代 后 期 。 人 民 公 社 制 度 的 确 立 经 历 多 重 波 折 ， 最 终 逐 渐 探 索 出 了 “ 大 寨 模 式 “ ， 随 后 全 国 以 这 一 模 式 为 样 板 ， 发 起 了 学 大 寨 运 动 。1975 年 的 全 国 农 业 学 大 寨 会 议 曾 提 出 要 在 全 国 建 设 ” 大 寨 县 “ （ 即 实 行 大 寨 模 式 的 县 ） ， 陈 永 贵 曾 指 出 “ 大 寨 县 ” 的 标 准 ： 粮 食 亩 产 实 现 八 百 斤 ； 科 学 种 田 ； 基 本 实 现 农 业 机 械 化 ， 为 农 业 现 代 化 打 下 基 础 ； 干 部 参 与 劳 动 ， 落 实 ” 一 二 三 “ （ 即 干 部 每 年 参 加 劳 动 的 指 标 ： 县 委 书 记100 天 ， 公 社 党 委 书 记200 天 ， 大 队 支 部 书 记300 天 ） 。 但 是 ， 毛 主 席 的 去 世 使 得 党 内 对 农 业 路 线 的 争 议 再 次 浮 出 水 面 。 极 左 派 和 保 守 派 都 要 求 继 续 实 行 毛 主 席 定 下 的 大 寨 路 线 ， 但 他 们 对 “ 大 寨 县 ” 普 及 速 度 仍 有 争 议 ， 极 左 派 支 持 大 搞 社 会 主 义 的 农 业 机 械 化 和 现 代 化 并 进 行 农 村 工 业 化 ， 保 守 派 则 认 为 大 寨 模 式 的 普 及 不 应 该 停 止 ， 但 更 多 的 资 金 应 该 用 在 其 他 地 方 （ 如 现 代 化 上 ） ； 另 外 ， 温 和 派 和 改 革 派 想 要 再 次 实 施 类 似 刘 少 奇 等 人 支 持 的 ” 三 自 一 包 “ 的 模 式 ； 而 另 一 部 分 步 子 迈 地 更 大 的 改 革 派 甚 至 提 议 引 入 一 套 完 善 的 私 人 农 业 体 系 。 我 们 需 要 决 定 我 们 用 以 农 业 发 展 的 资 金 最 终 流 向 哪 部 分 人 。 主 席 同 志 ， 这 是 一 场 新 的 路 线 斗 争 ， 中 国 农 业 未 来 的 命 运 在 你 手 里 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 维 持 大 寨 模 式 的 普 及 ， 但 不 额 外 拨 款";
		button_text[1] = " 引 入 家 庭 联 产 承 包 合 同";
		if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 引 进 私 营 农 场";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 会 把 农 业 交 给 私 人 投 机 者 ！";
		}
		if (GlobalScript.inst.gameState.data[89] == 0)
		{
			button_text[3] = " 增 加 资 金 投 入 ， 加 速 大 寨 模 式 的 普 及 和 农 业 机 械 化 工 业 化";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 需 要 把 钱 浪 费 在 这 种 地 方 吗 ？";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 农 业 改 革";
		switch (result_num)
		{
		case 0:
		{
			text = " 我 们 决 定 不 节 外 生 枝 ， 将 资 金 投 入 到 其 他 更 要 紧 的 地 方 去 ， 继 续 缓 慢 而 持 续 地 推 行 大 寨 模 式 和 农 业 机 械 化 ， 虽 然 这 引 起 了 一 些 渴 望 得 到 属 于 自 己 的 土 地 的 农 民 和 党 内 改 革 派 的 不 满 ，但 我 们 希 望 一 切 顺 利 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[4] += 30;
			GlobalScript.inst.gameState.data[3] -= 30;
			string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
			int num2 = 15;
			old_modify_desc2[num2] += "<color=red>| 缓 慢 推 进 集 体 化 的 公 社 ：</color>| 农 业+0.1 ， 工 业+0.1 ， 生 活 水 平+0.2 ， 预 算+0.1";
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] > 1)
				{
					politic2.loyality -= 100;
				}
			}
			break;
		}
		case 1:
		{
			text = " 我 们 最 终 决 定 解 散 人 民 公 社 ， 并 将 土 地 承 包 给 各 个 独 立 的 家 庭 ， 而 这 些 承 包 者 需 要 为 我 们 提 供 按 指 定 价 格 售 卖 的 商 品 粮 。 重 新 拿 到 自 己 的 土 地 （ 虽 然 并 没 有 所 有 权 ） 使 得 农 民 又 对 耕 作 产 生 了 热 情 ， 这 调 动 了 农 民 们 的 积 极 性 ， 我 们 也 可 以 更 好 的 稳 定 农 村 。 当 然 ， 有 一 部 分 党 员 表 示 了 不 满 ， 认 为 这 是 “ 重 回 资 本 主 义 道 路 的 一 大 步 ” 。";
			string[] old_modify_desc4 = GlobalScript.inst.old_modify_desc;
			int num4 = 15;
			old_modify_desc4[num4] += "<color=red>| 家 庭 联 产 承 包 责 任 制 ：</color>| 预 算+0.4 ， 腐 败+0.3| 若 福 利 投 资 低 于20，则 农 业-0.2 ， 生 活 水 平-0.2 ， 服 务 业-0.2| 若 福 利 投 资 高 于20，则 农 业+0.2 ， 生 活 水 平+0.2 ， 服 务 业+0.2";
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.data[13] += 30;
			GlobalScript.inst.gameState.data[92] += 10;
			GlobalScript.inst.gameState.data[4] += 30;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[5] += 30;
			party_change[2] = 0.8f;
			party_change[3] = 0.8f;
			GlobalScript.inst.gameState.data[26] += 20;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 1)
				{
					politic4.power += 120;
					politic4.loyality += 100;
				}
				else if (politic4.traits[0] == 2)
				{
					politic4.power += 120;
					politic4.loyality += 100;
				}
			}
			break;
		}
		case 2:
		{
			text = " 在 政 治 局 和 中 央 委 员 会 长 期 的 论 战 之 后 ， 我 们 终 于 克 服 了 保 守 派 和 温 和 派 的 抵 触 心 理 ， 并 宣 布 解 散 人 民 公 社 ， 全 国 耕 地 重 新 分 配 给 各 个 家 庭 ， 且 各 个 家 庭 拥 有 完 全 的 产 权 。 中 国 农 业 银 行 已 经 准 备 好 了 为 农 民 提 供 贷 款 来 让 农 民 购 买 农 机 和 化 肥 的 准 备 ， 农 民 除 了 要 将 定 量 的 商 品 粮 卖 给 国 家 以 外 ， 可 以 自 由 处 置 剩 下 的 粮 食 。 这 可 以 显 著 的 提 高 我 国 的 市 场 化 水 平 ， 财 政 部 也 开 始 商 定 对 这 些 新 自 耕 农 的 税 率 了 ， 但 是 很 多 人 对 此 表 示 不 满 ， 一 些 人 也 开 始 暗 中 购 买 耕 地 了 ， 人 民 正 在 期 待 我 们 的 下 一 步 改 革 。";
			string[] old_modify_desc3 = GlobalScript.inst.old_modify_desc;
			int num3 = 15;
			old_modify_desc3[num3] += "<color=red>| 私 人 农 场 ：</color>| 农 业-0.4 ， 生 活 水 平-0.4 ， 预 算+1.0 ， 服 务 业+0.2 ， 腐 败+0.4 ，寡 头+4";
			GlobalScript.inst.gameState.data[1] -= 70;
			GlobalScript.inst.gameState.data[92] += 30;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[3] += 70;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.empires[0].relations += 30;
			GlobalScript.inst.gameState.data[8] += 40;
			GlobalScript.inst.gameState.data[57] -= 30;
			GlobalScript.inst.gameState.data[26] += 30;
			party_change[2] = 0.3f;
			party_change[3] = 1f;
			party_change[4] += 0.8f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.power -= 100;
					politic3.loyality -= 250;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.power += 150;
					politic3.loyality += 100;
				}
				else if (politic3.traits[0] == 3)
				{
					politic3.power += 150;
					politic3.loyality += 200;
				}
			}
			break;
		}
		case 3:
		{
			text = " 我 们 最 后 决 定 拨 款 加 速 公 社 的 集 体 化 和 机 械 化 ， 党 中 央 起 草 了 一 份 新 的 人 民 公 社 条 例 ， 各 地 也 对 人 民 公 社 进 行 了 重 新 改 造 ： 现 在 我 们 国 家 的 农 业 由 许 多 国 家 控 制 下 的 公 社 组 成 ， 我 们 会 要 求 各 个 人 民 公 社 按 照 义 务 收 购 合 同 交 售 保 质 保 量 的 粮 食 ， 蔬 果 和 肉 类 ， 至 于 那 些 超 产 的 部 分 我 们 则 开 放 了 国 家 管 理 下 的 集 市 来 让 他 们 自 由 交 易 ， 同 时 各 大 拖 拉 机 厂 和 化 肥 厂 也 迎 来 了 新 一 轮 的 大 宗 订 单 ， 这 些 是 我 们 为 了 实 现 农 业 机 械 化 所 付 出 的 努 力 ， 而 它 在 未 来 肯 定 是 硕 果 累 累 的 ， 就 是 当 下 的 财 政 支 出 有 些 大......";
			string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
			int num = 15;
			old_modify_desc[num] += "<color=red>| 快 速 推 进 集 体 化 的 公 社 ：</color>| 农 业+0.4 ， 工 业+0.4 ， 生 活 水 平+0.4 ， 预 算+0.2";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[3] += 70;
			GlobalScript.inst.gameState.data[5] += 30;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.data[13] += 50;
			if (!GlobalScript.inst.gameState.science[0])
			{
				GlobalScript.inst.gameState.science[0] = true;
			}
			else if (!GlobalScript.inst.gameState.science[1])
			{
				GlobalScript.inst.gameState.science[1] = true;
			}
			else if (!GlobalScript.inst.gameState.science[2])
			{
				GlobalScript.inst.gameState.science[2] = true;
			}
			GlobalScript.inst.gameState.party_ideology[2] -= (int)((float)GlobalScript.inst.gameState.party_ideology[2] * 0.09f);
			GlobalScript.inst.gameState.party_ideology[3] -= (int)((float)GlobalScript.inst.gameState.party_ideology[3] * 0.5f);
			GlobalScript.inst.gameState.party_ideology[4] -= (int)((float)GlobalScript.inst.gameState.party_ideology[4] * 0.24f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power += 120;
					politic.loyality += 150;
				}
				else if (politic.traits[0] == 1)
				{
					politic.power -= 80;
					politic.loyality -= 100;
				}
				else if (politic.traits[0] == 2)
				{
					politic.power -= 100;
					politic.loyality -= 150;
				}
				else if (politic.traits[0] == 3)
				{
					politic.power -= 150;
					politic.loyality -= 200;
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
}
