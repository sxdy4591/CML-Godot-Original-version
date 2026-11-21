using EventsForDLC;
using UnityEngine;

public class Event39 : EventsSecond
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
		name = " 《 党 的 若 干 历 史 问 题 的 决 议 》 起 草 委 员 会";
		text = " 老 一 代 领 导 人 的 离 去 ， 文 化 大 革 命 的 结 束 与 体 制 改 革 的 进 行 事 实 上 在 国 内 开 了 逐 渐 脱 离 毛 泽 东 既 定 路 线 的 先 例 ， 并 为 一 系 列 不 稳 定 因 素 持 续 加 码 。 组 织 部 与 公 安 部 传 来 的 消 息 更 是 令 人 不 安 ： 部 分 地 方 党 组 织 与 活 动 人 士 已 开 始 借 结 束 文 革 之 势 炮 击 建 国 以 来 的 一 系 列 历 史 ， 试 图 将 我 国 建 国 以 来 的 历 史 描 述 成 “ 漆 黑 一 片 ” ， “ 过 错 是 主 要 的 ， 成 就 是 靠 纠 偏 得 来 的 ” ， 并 试 图 将 中 国 社 会 的 一 系 列 灾 害 与 责 任 归 咎 于 已 逝 的 “ 舵 手 ” 毛 泽 东 以 推 进 自 身 乐 见 的 政 治 议 程 。 而 上 述 现 象 甚 至 得 到 了 某 些 在 毛 时 代 遭 遇 打 压 的 老 干 部 的 默 许 以 至 支 持 ： 他 们 显 然 是 出 于 复 仇 情 绪 或 政 治 野 心 对 此 乐 见 其 成 。 与 此 同 时 ， 虽 说 我 党 已 剔 除 了 国 内 最 激 进 的 政 治 活 动 家 ， 可 深 受 毛 时 代 思 想 与 政 治 实 践 影 响 的 政 治 新 人 们 仍 在 相 当 规 模 的 党 政 机 器 内 活 跃 ， 且 围 绕 毛 泽 东 形 成 的 个 人 崇 拜 也 开 始 被 我 国 人 民 选 择 性 诠 释 进 行 “ 暗 度 陈 仓 ” — — 一 如 文 化 大 革 命 时 期 的 效 忠 行 动 那 般 。 若 纵 容 上 述 现 象 继 续 发 展 ， 我 们 极 有 可 能 重 蹈 匈 牙 利 的 覆 辙 ， 在 同 一 条 阴 沟 内 翻 船 。 中 共 中 央 政 治 局 与 书 记 处 已 决 定 在 整 顿 党 籍 与 规 范 社 会 秩 序 的 同 时 起 草 一 份 文 件 ， 以 彻 底 解 决 这 一 问 题 ： 如 你 所 料 ， 我 们 曾 在 革 命 战 争 时 期 以 一 纸 《 关 于 若 干 历 史 问 题 的 决 议 》 奠 定 了 毛 泽 东 与 其 思 想 的 霸 权 ， 并 将 党 内 早 期 风 云 人 物 系 数 边 缘 化 。 而 现 在 ， 是 时 候 对1949 年 以 来 在 毛 泽 东 领 导 下 的 中 华 人 民 共 和 国 和 中 国 共 产 党 走 过 的 道 路 进 行 正 式 评 估 ， 并 以 新 版 总 路 线 对 其 取 而 代 之 了 。 当 然 ， 我 们 绝 不 能 对 冠 以 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 之 名 的 高 规 格 的 文 件 有 所 马 虎 ： 毕 竟 ， 这 可 是 我 们 时 代 的 《 联 共 （ 布 ） 党 史 简 明 教 程 》 与 未 来 新 党 纲 的 潜 在 原 型 ， 并 极 有 可 能 决 定 未 来 数 十 年 内 我 国 的 政 治 基 调 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if ((GlobalScript.inst.gameState.data[56] < 2 || (a.data[56] == 2 && a.data[12] >= 700)) && a.NumberOfPolitician(6, 6) >= 0)
		{
			button_text[0] = " 有 必 要 让 “ 两 个 凡 是 ” 的 总 后 台 汪 东 兴 主 持 《 决 议 》 工 作 ， 以 重 建 毛 泽 东 主 席 与 党 中 央 的 权 威 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 汪 东 兴 的 教 条 主 义 已 不 合 时 宜 ！ 新 时 代 需 要 新 思 维 ！";
		}
		button_text[1] = " 党 的 笔 杆 子 胡 乔 木 与 胡 绳 最 能 把 握 分 寸 ， 他 能 够 做 出 客 观 评 价 。";
		if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 决 议 起 草 应 贯 彻 “ 民 主 集 中 ” 的 原 则 ， 让 大 家 说 话 ， 天 塌 不 下 来 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 党 的 纪 律 性 呢 ？ ！ 我 们 绝 不 能 在 这 一 问 题 上 如 此 松 懈 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 《 党 的 若 干 历 史 问 题 的 决 议 》 起 草 委 员 会";
		switch (result_num)
		{
		case 0:
		{
			text = string.Concat(new string[4]
			{
				" 根 据 政 治 局 的 决 定 ， 以 “ 毛 主 席 的 卫 士 ” 、8341 部 队 政 委 以 及 中 共 中 央 办 公 厅 主 任 等 多 重 身 份 闻 名 的 汪 东 兴 很 快 多 了 个 新 头 衔 ， 不 久 后 便 去 了 《 决 议 》 起 草 委 员 会 上 发 光 发 热 。 根 据 他 的 人 事 安 排 ： 《 决 议 》 起 草 委 员 会 很 快 便 成 为 了 “ 凡 是 派 ” 的 司 令 部 ， 其 中 甚 至 吸 纳 了 “ 文 化 大 革 命 ” 时 期 内 发 迹 ， 但 最 终 识 时 务 选 择 远 离 其 激 进 潮 流 的",
				GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[0]].name_1],
				GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[0]].name_2],
				" 同 志 作 为 副 手 。 他 们 很 快 便 将 工 作 中 心 放 在 了 毛 泽 东 主 席 在 中 苏 论 战 后 的 活 动 内 ， 并 以 “ 斗 私 批 修 ” 的 基 调 写 史 ： 《 决 议 》 强 调 了 毛 泽 东 主 席 作 为 中 国 革 命 与 建 设 事 业 唯 一 领 导 核 心 的 地 位 ， 并 为 他 开 出 了 相 当 积 极 的 评 价 — — 即 领 导 中 国 人 民 站 起 来 ， 并 在 独 立 自 主 的 基 础 上 走 上 了 社 会 主 义 道 路 的 伟 大 舵 手 。 而 毛 时 代 的 挫 折 则 基 本 分 给 了 早 已 蒙 羞 的 刘 少 奇 等 失 势 官 员 。 这 只 会 导 致 毛 主 席 下 达 的 部 分 决 议 也 跟 着 被 “ 凡 是 派 ” 选 择 性 利 用 并 神 圣 化 ： 紧 随 其 后 的 文 件 学 习 与 整 风 工 作 只 会 让 相 关 政 策 被 进 一 步 贯 彻 落 实 — — 意 味 着 已 被 毛 主 席 定 调 的 邓 小 平 将 永 世 不 得 翻 身 ， 其 他 的 老 干 部 也 将 遭 受 不 同 程 度 的 掣 肘 。 借 文 革 之 风 站 稳 脚 跟 的 新 一 代 领 导 层 就 此 彻 底 确 立 了 自 身 的 领 导 权 ， 并 准 备 好 以 毛 主 席 的 名 义 走 出 中 国 社 会 主 义 之 路 。"
			});
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.data[90] = 0;
			party_change[0] = 1.5f;
			party_change[1] = 1.5f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
					politic2.power += 30;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality += 60;
					politic2.power += 20;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality += 50;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.loyality -= 100;
					politic2.power -= 30;
				}
			}
			if (a.NumberOfPolitician(13, 13) > 0)
			{
				int number = a.NumberOfPolitician(13, 13);
				a.KillPerson(number);
			}
			break;
		}
		case 1:
		{
			text = " 根 据 政 治 局 的 决 定 ， 以 胡 乔 木 与 胡 绳 为 代 表 的 党 内 理 论 家 被 委 以 重 任 。 他 们 均 有 邓 小 平 牵 头 组 织 的 国 务 院 政 治 研 究 室 背 景 ， 并 在 相 当 程 度 上 接 受 了 前 者 的 部 分 观 点 。 不 久 后 ， 这 群 知 识 分 子 便 对 毛 主 席 审 阅 过 的 《 关 于 无 产 阶 级 专 政 的 历 史 经 验 》 一 文 按 图 索 骥 ， 对 毛 泽 东 给 出 了 类 似 毛 泽 东 本 人 对 斯 大 林 的 评 价 （ 即 “ 七 分 成 绩 ， 三 分 过 错 ” ） 。 而 包 括 “ 大 跃 进 ” 与 “ 文 化 大 革 命 ” 等 在 的 历 史 错 误 则 被 归 咎 于 党 内 一 部 分 阴 谋 家 利 用 了 晚 年 毛 主 席 的 战 略 误 判 ， 并 利 用 了 这 一 错 误 。 除 此 之 外 ， 《 决 议 》 也 将 建 国 至1976 年 以 来 的 历 史 做 了 区 分 ： 即 成 就 斐 然 的 前17 年 ， 作 为 转 折 点 的1957 年 （ 此 后 的 错 误 “ 越 来 越 多 ” ） 与 应 被 完 全 否 定 ， 只 能 在 纠 偏 内 “ 争 取 部 分 成 绩 ” 的 文 革10 年 。 中 国 的 社 会 主 义 建 设 也 应 当 回 归 毛 泽 东 思 想 的 本 源 — — 即 中 共 八 大 提 出 的 主 要 矛 盾 与 政 治 任 务 。 除 此 之 外 ， 胡 乔 木 更 是 聪 明 地 提 出 了 分 割 “ 毛 泽 东 思 想 ” （ 即 集 体 智 慧 的 结 晶 ） 与 “ 毛 泽 东 的 思 想 ” （ 唯 意 志 论 的 专 断 实 践 ） 的 方 略 ， 并 复 刻 了 毛 泽 东 曾 对 孙 中 山 政 治 形 象 与 三 民 主 义 开 展 的 政 治 实 践 。 从 而 最 大 限 度 地 把 毛 泽 东 晚 年 思 想 上 行 动 上 的 错 误 ， 同 毛 泽 东 思 想 加 以 区 别 ， 加 以 对 照 ； 对 毛 泽 东 思 想 加 以 肯 定 的 同 时 对 毛 泽 东 晚 年 的 错 误 理 论 和 错 误 实 践 加 以 批 判 。 接 下 来 则 是 在 团 结 一 致 的 氛 围 下 平 反 该 平 反 的 ， 谴 责 该 谴 责 的 ， 并 对 党 内 进 行 重 新 洗 牌 — — 下 一 步 便 是 在 贯 彻 落 实 集 体 领 导 的 原 则 与 基 于 谋 稳 定 、 促 发 展 的 观 点 上 重 新 整 理 行 囊 。 我 们 的 党 就 此 能 够 相 对 稳 妥 的 摆 脱 过 往 历 史 负 担 ， 并 在 尽 可 能 摆 脱 毛 泽 东 时 代 弊 病 的 同 时 以 他 的 形 象 收 编 社 会 舆 论 ， 用 稳 定 压 倒 一 切 。";
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.data[90] = 1;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 20;
			party_change[0] = 1.5f;
			party_change[1] = 1.5f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality += 50;
					politic3.power += 10;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality += 100;
					politic3.power += 40;
				}
				else if (politic3.traits[0] == 3)
				{
					politic3.loyality += 60;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.loyality += 80;
					politic3.power += 30;
				}
			}
			break;
		}
		case 2:
		{
			text = " 没 了 党 内 纪 律 的 约 束 ， 准 备 筹 建 《 决 议 》 起 草 委 员 会 的 会 议 很 快 便 炸 开 了 锅 ， 没 多 久 便 成 了 老 干 部 们 的 诉 苦 现 场 — — 这 些 早 在 土 地 革 命 时 期 参 加 中 共 事 业 的 “ 中 版 老 布 尔 什 维 克 ” 可 受 不 了 “ 文 化 大 革 命 ” 时 期 的 被 迫 靠 边 与 紧 随 其 后 的 政 治 迫 害 ， 上 述 经 历 只 会 让 其 觉 得 “ 伟 大 领 袖 ” 不 过 是 卸 磨 杀 驴 的 两 面 派 ， 而 刚 得 到 平 反 消 息 官 复 原 职 的 他 们 没 多 久 便 占 据 了 会 议 的 主 流 。 叶 剑 英 的 意 气 发 言 （ 即 将 毛 时 代 政 治 实 践 称 之 为 “ 封 建 法 西 斯 专 政 ” ） 更 是 引 来 场 上 掌 声 不 断 。 最 终 ， 党 会 议 以 多 数 表 决 将 曾 长 期 主 持 首 都 党 务 工 作 ， 并 在 “ 文 革 ” 时 期 首 当 其 冲 的 彭 真 推 上 《 决 议 》 起 草 委 员 会 主 要 负 责 人 一 职 。 他 很 快 便 伙 同 自 己 传 媒 界 内 的 同 僚 们 将 老 干 部 们 的 复 仇 愿 望 转 化 为 了 现 实 ： 建 国 以 来 的 一 系 列 悲 剧 均 被 归 结 于 “ 抛 弃 集 体 领 导 ， 践 踏 法 治 原 则 ” 的 一 系 列 政 治 冲 动 ， 而 毛 泽 东 正 是 这 一 股 思 潮 的 代 表 — — 他 最 大 的 过 错 便 在 于 没 能 实 现 从 中 共 由 “ 革 命 党 ” 到 “ 执 政 党 ” 的 转 型 ， 并 痴 迷 于 采 用 命 令 式 的 军 事 动 员 与 战 时 突 击 方 法 掌 管 全 国 ， 将 革 命 战 争 时 期 的 三 人 团 、 小 圈 子 与 军 事 专 断 等 经 验 神 圣 化 。 而 这 恰 是 国 内 各 类 冤 假 错 案 、 政 治 迫 害 与 个 人 崇 拜 乱 象 的 起 源 。 因 此 ， 有 必 要 树 立 起 “ 真 理 面 前 人 人 平 等 ， 法 律 面 前 人 人 平 等 ” 的 价 值 观 ， 并 以 建 立 集 体 领 导 ， 形 成 相 应 制 度 的 方 式 彻 底 断 绝 个 人 独 大 可 能 。 虽 说 这 份 文 件 决 绝 地 同 过 往 的 各 项 实 践 与 乱 象 做 了 切 割 ， 可 考 虑 到 它 的 严 厉 措 辞 、 坚 决 态 度 与 其 中 满 溢 出 的 价 值 判 断 ， 并 不 能 指 望 这 份 “ 中 国 版 本 的 秘 密 报 告 ” 能 对 通 常 党 员 与 普 通 群 众 有 多 少 规 范 作 用 。";
			if (GlobalScript.inst.gameState.data[104] == 10)
			{
				text += "|| 文 件 通 过 后 的 当 晚 ， 毛 泽 东 的 遗 体 被 从 纪 念 馆 中 移 走 ， 之 后 第 二 天 这 座 建 筑 就 被 拆 除 了 。 在 纪 念 馆 的 废 墟 上 ， 将 修 建 一 座 关 于 中 共 第 一 任 总 书 记 陈 独 秀 的 博 物 馆 ， 他 曾 被 指 控 为 优 柔 寡 断 ， 后 来 又 站 在 了 托 洛 茨 基 反 对 派 那 边 。";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					GameObject.Find("Ach(Clone)").GetComponent<achievements>().Set(9);
				}
				GlobalScript.inst.gameState.data[104] = 9;
			}
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[6] -= 60;
			GlobalScript.inst.gameState.data[90] = 2;
			party_change[3] = 1.5f;
			party_change[4] = 1f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 150;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality -= 100;
				}
				else if (politic.traits[0] == 2)
				{
					politic.loyality += 50;
				}
				else if (politic.traits[0] == 3)
				{
					politic.loyality += 150;
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
