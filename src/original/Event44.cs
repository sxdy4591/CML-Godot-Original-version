using EventsForDLC;
using UnityEngine;

public class Event44 : EventsSecond
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
		name = " 不 管 黑 猫 白 猫 …";
		if (a.NumberOfPolitician(13, 13) >= 0)
		{
			name = " 不 管 黑 猫 白 猫 …";
			text = " 国 内 的 债 务 高 企 与 缺 乏 根 本 改 观 的 糜 烂 经 济 局 势 已 让 既 定 方 针 难 以 为 继 ， 而 党 内 改 革 派 与 实 用 主 义 政 客 的 做 大 更 是 使 得" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 力 行 的 保 守 政 策 丧 失 了 社 会 基 础 。 最 近 中 央 召 开 的 工 作 会 议 更 使 这 种 趋 势 趋 于 公 开 化 ， 斗 争 就 此 走 向 白 热 化 ： 不 满 于" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "的 政 客 已 经 团 结 在 党 内 “ 经 济 专 家 ” ， 曾 在 “ 文 化 大 革 命 ” 期 间 主 持 国 内 全 面 整 顿 的 老 主 管 邓 小 平 周 围 。 他 们 将 纯 粹 的 经 济 问 题 探 讨 变 成 了 算 政 治 账 的 法 庭 ， 并 对 “ 彭 德 怀 案 ” 、 “ 四 五 运 动 ” 、 “ 文 革 余 毒 ” 乃 至 “ 六 十 一 人 叛 徒 集 团 ” 等 故 事 重 提 ， 甚 至 将 目 前 的 经 济 失 败 与 往 日 的 所 谓 “ 唯 意 志 论 ” 等 挂 钩 在 一 起 。 由 此 要 求" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 此 做 出 交 代 — — 他 们 的 要 求 显 而 易 见 ， 不 换 思 想 就 换 人 。 邓 小 平 更 是 趁 机 撮 合 起 所 谓 “ 求 是 派 ” 圈 子 ， 在 平 反 冤 假 错 案 ， 确 立 科 学 发 展 路 线 的 旗 下 玩 起 经 济 核 算 、 自 筹 资 金 与 拓 展 市 场 要 素 的 把 戏 ， 从 而 描 摹 起 不 同 于 既 定 路 线 的 所 谓 “ 恢 宏 蓝 图 ” ， 大 有 当 中 国 版 卡 达 尔 · 亚 诺 什 的 野 心 。 出 席 会 议 的 绝 大 多 数 角 色 基 本 上 成 了 他 的 盟 友 。 倘 若 你 不 想 失 去 权 力 的 话 ， 总 得 做 些 什 么 ！";
		}
		else if (a.NumberOfPolitician(8, 8) >= 0)
		{
			name = " 吕 端 大 事 不 糊 涂 …";
			text = " 国 内 的 债 务 高 企 与 缺 乏 根 本 改 观 的 糜 烂 经 济 局 势 已 让 既 定 方 针 难 以 为 继 ， 而 党 内 改 革 派 与 实 用 主 义 政 客 的 做 大 更 是 使 得" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 力 行 的 保 守 政 策 丧 失 了 社 会 基 础 。 最 近 中 央 召 开 的 工 作 会 议 更 使 这 种 趋 势 趋 于 公 开 化 ， 斗 争 就 此 走 向 白 热 化 ： 不 满 于" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "的 政 客 已 经 团 结 在 “ 中 国 的 朱 可 夫 元 帅 ” ， 毛 泽 东 主 席 临 终 前 委 托 的 政 治 元 老 ， 同 时 也 是 “ 走 资 派 ” 邓 小 平 挚 友 的 叶 剑 英 周 围 。 他 们 将 纯 粹 的 经 济 问 题 探 讨 变 成 了 算 政 治 账 的 法 庭 ， 并 对 “ 批 邓 ” 、 “ 彭 德 怀 案 ” 、 “ 四 五 运 动 ” 、 “ 文 革 余 毒 ” 乃 至 “ 六 十 一 人 叛 徒 集 团 ” 等 故 事 重 提 ， 甚 至 将 目 前 的 经 济 失 败 与 往 日 的 所 谓 “ 唯 意 志 论 ” 等 挂 钩 在 一 起 。 由 此 要 求" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 此 做 出 交 代 — — 他 们 的 要 求 显 而 易 见 ， 不 换 思 想 就 隔 离 审 查 。 叶 剑 英 更 是 纠 结 起 自 己 在 人 民 解 放 军 中 的 圈 子 ， 一 面 将 张 爱 萍 、 秦 基 伟 与 迟 浩 田 等 军 方 强 力 角 色 安 插 进 会 议 内 ， 一 面 则 调 动 转 机 运 输 亲 近 自 身 立 场 的 党 员 代 表 并 试 图 封 锁 会 议 现 场 。 打 算 以 更 加 听 话 顺 从 的 老 干 部 取 代 您 的 地 位 ， 从 而 描 摹 起 不 同 于 既 定 路 线 的 所 谓 “ 恢 宏 蓝 图 ” ， 大 有 当 现 代 版 周 公 的 野 心 。 出 席 会 议 的 绝 大 多 数 角 色 基 本 上 成 了 他 的 盟 友 。 倘 若 你 不 想 失 去 权 力 的 话 ， 总 得 做 些 什 么 ！";
		}
		else
		{
			name = " 不 改 革 就 下 台 ！";
			text = " 国 内 的 债 务 高 企 与 缺 乏 根 本 改 观 的 糜 烂 经 济 局 势 已 让 既 定 方 针 难 以 为 继 ， 而 党 内 改 革 派 与 实 用 主 义 政 客 的 做 大 更 是 使 得" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 力 行 的 保 守 政 策 丧 失 了 社 会 基 础 。 最 近 中 央 召 开 的 工 作 会 议 更 使 这 种 趋 势 趋 于 公 开 化 ， 斗 争 就 此 走 向 白 热 化 ： 不 满 于" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "的 政 客 已 经 团 结 在 党 内 的 改 革 派 头 面 人 物 ， 以 南 斯 拉 夫 与 匈 牙 利 模 式 为 模 范 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + "周 围 。 他 们 将 纯 粹 的 经 济 问 题 探 讨 变 成 了 算 政 治 账 的 法 庭 ， 并 对 “ 批 邓 ” 、 “ 彭 德 怀 案 ” 、 “ 四 五 运 动 ” 、 “ 文 革 余 毒 ” 乃 至 “ 六 十 一 人 叛 徒 集 团 ” 等 故 事 重 提 ， 甚 至 将 目 前 的 经 济 失 败 与 往 日 的 所 谓 “ 唯 意 志 论 ” 等 挂 钩 在 一 起 。 由 此 要 求" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 此 做 出 交 代 — — 他 们 的 要 求 显 而 易 见 ， 不 换 思 想 就 换 人 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 更 是 趁 机 撮 合 起 所 谓 “ 求 是 派 ” 圈 子 ， 在 平 反 冤 假 错 案 ， 确 立 科 学 发 展 路 线 的 旗 下 玩 起 经 济 核 算 、 自 筹 资 金 与 拓 展 市 场 要 素 的 把 戏 ， 从 而 描 摹 起 不 同 于 既 定 路 线 的 所 谓 “ 恢 宏 蓝 图 ” ， 大 有 当 中 国 版 卡 达 尔 · 亚 诺 什 的 野 心 。 出 席 会 议 的 绝 大 多 数 角 色 基 本 上 成 了 他 的 盟 友 。 倘 若 你 不 想 失 去 权 力 的 话 ， 总 得 做 些 什 么 ！";
		}
		text = text ?? "";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.NumberOfPolitician(13, 13) >= 0)
		{
			button_text[0] = " 同 意 改 革 派 的 要 求 ， 以 体 面 退 场 交 换 邓 小 平 主 持 国 政";
			if (GlobalScript.inst.gameState.data[9] >= 150)
			{
				button_text[1] = " 调 动 中 央 警 卫 团 与 国 家 安 全 人 员 做 最 后 一 搏 ！";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 既 无 动 机 ， 也 力 不 从 心";
			}
			if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
			{
				button_text[2] = " 我 现 在 换 思 想 能 保 证 不 换 人 吗";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 救 无 可 救 ， 吐 故 纳 新";
			}
		}
		else if (a.NumberOfPolitician(8, 8) >= 0)
		{
			button_text[0] = " 同 意 改 革 派 的 要 求 ， 以 体 面 退 场 交 换 叶 剑 英 主 持 国 政";
			if (GlobalScript.inst.gameState.data[9] >= 150)
			{
				button_text[1] = " 调 动 中 央 警 卫 团 与 国 家 安 全 人 员 做 最 后 一 搏 ！";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 既 无 动 机 ， 也 力 不 从 心";
			}
			if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
			{
				button_text[2] = " 我 现 在 换 思 想 能 保 证 不 换 人 吗";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 救 无 可 救 ， 吐 故 纳 新";
			}
		}
		else
		{
			button_text[0] = " 同 意 改 革 派 的 要 求 ， 以 体 面 退 场 交 换" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 主 持 国 政";
			if (GlobalScript.inst.gameState.data[9] >= 150)
			{
				button_text[1] = " 调 动 中 央 警 卫 团 与 国 家 安 全 人 员 做 最 后 一 搏 ！";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 既 无 动 机 ， 也 力 不 从 心";
			}
			if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
			{
				button_text[2] = " 我 现 在 换 思 想 能 保 证 不 换 人 吗";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 救 无 可 救 ， 吐 故 纳 新";
			}
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 不 管 黑 猫 白 猫 …";
		switch (result_num)
		{
		case 0:
		{
			if (a.NumberOfPolitician(13, 13) >= 0)
			{
				GlobalScript.inst.gameState.faction_leader[3] = a.NumberOfPolitician(13, 13);
				text = " 意 识 到 大 势 已 去 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 放 弃 挣 扎 ， 立 刻 便 答 应 了 邓 小 平 等 改 革 派 头 面 人 物 开 出 的 条 件 。 不 久 后 召 开 的 又 一 场 全 会 只 是 将 先 前 讨 论 的 结 果 给 落 到 实 处 ： 党 的 领 导 集 体 决 定 加 快 冤 假 错 案 平 反 速 度 ， 并 要 求 迅 速 解 决 自 “ 文 革 ” 以 来 的 一 系 列 历 史 遗 留 问 题 （ 当 然 也 包 括 借 着 这 一 政 治 风 波 扶 摇 直 上 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ） 。 接 下 来 便 是 通 过 人 事 改 组 ， 安 置 新 部 门 与 平 反 老 干 部 的 三 板 斧 将 “ 两 个 凡 是 ” 与 其 主 要 设 计 者 给 边 缘 化 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 的 左 膀 右 臂 纷 纷 去 了 清 水 衙 门 ， 人 事 、 理 论 与 党 政 的 要 职 也 纷 纷 落 入 了 邓 小 平 与 其 盟 友 手 中 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 虽 说 没 有 丢 掉 自 己 的 宝 贵 头 衔 ， 可 丢 了 利 爪 的 他 处 处 受 掣 ， 其 退 休 也 不 过 时 间 问 题 。 现 在 ， 全 党 全 军 已 在 邓 小 平 的 号 令 下 就 位 ， 并 形 成 了 一 个 聚 拢 党 内 主 要 元 老 的 精 英 政 治 圈 子 主 持 国 政 。 而 他 已 准 备 好 带 领 国 家 走 向 一 条 史 无 前 例 的 全 面 整 顿 ， 并 在 全 新 基 础 上 建 设 有 中 国 特 色 的 社 会 主 义 之 路 。 日 后 人 们 会 将 这 天 作 为 所 谓 “ 改 革 开 放 ” 的 开 端 铭 记 ， 尽 管 当 事 人 都 清 楚 这 只 是 又 一 场 心 血 来 潮 的 不 流 血 政 变 与 扫 除 杂 草 的 例 行 公 事 而 已 。";
				if (a.NumberOfPolitician(11, 11) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(11, 11));
				}
				if (a.NumberOfPolitician(6, 6) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(6, 6));
				}
				a.data[15] = 7;
			}
			else if (a.NumberOfPolitician(8, 8) >= 0)
			{
				GlobalScript.inst.gameState.faction_leader[3] = a.NumberOfPolitician(8, 8);
				text = " 意 识 到 大 势 已 去 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 放 弃 挣 扎 ， 立 刻 便 答 应 了 叶 剑 英 等 改 革 派 头 面 人 物 开 出 的 条 件 。 不 久 后 召 开 的 又 一 场 全 会 只 是 将 先 前 讨 论 的 结 果 给 落 到 实 处 ： 党 的 领 导 集 体 决 定 加 快 冤 假 错 案 平 反 速 度 ， 并 要 求 迅 速 解 决 自 “ 文 革 ” 以 来 的 一 系 列 历 史 遗 留 问 题 （ 当 然 也 包 括 借 着 这 一 政 治 风 波 扶 摇 直 上 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ） 。 接 下 来 便 是 通 过 人 事 改 组 ， 安 置 新 部 门 与 平 反 老 干 部 的 三 板 斧 将 “ 两 个 凡 是 ” 与 其 主 要 设 计 者 给 边 缘 化 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 的 左 膀 右 臂 纷 纷 去 了 清 水 衙 门 ， 人 事 、 理 论 与 党 政 的 要 职 也 纷 纷 落 入 了 叶 剑 英 专 门 挑 选 的 人 士 手 中 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 虽 说 没 有 丢 掉 自 己 的 宝 贵 头 衔 ， 可 丢 了 利 爪 的 他 处 处 受 掣 ， 其 退 休 也 不 过 时 间 问 题 。 现 在 ， 全 党 全 军 已 在 叶 剑 英 的 号 令 下 就 位 ， 并 形 成 了 一 个 聚 拢 人 民 解 放 军 内 精 英 与 党 内 主 要 元 老 的 精 英 政 治 圈 子 主 持 国 政 。 而 他 已 准 备 好 带 领 国 家 走 向 一 条 史 无 前 例 的 全 面 整 顿 ， 并 在 全 新 基 础 上 建 设 有 中 国 特 色 的 社 会 主 义 之 路 。 日 后 人 们 会 将 这 天 作 为 所 谓 “ 改 革 开 放 ” 的 开 端 铭 记 ， 尽 管 当 事 人 都 清 楚 这 只 是 又 一 场 心 血 来 潮 的 不 流 血 政 变 与 扫 除 杂 草 的 例 行 公 事 而 已 。 叶 剑 英 承 诺 将 在 人 民 解 放 军 的 监 督 下 捍 卫 革 命 理 想 ， 并 根 据 经 济 核 算 逻 辑 与 力 行 “ 中 国 特 色 社 会 主 义 路 线 ” ， 首 先 便 是 在 全 面 平 反 冤 假 错 案 的 基 础 上 力 行 清 算 “ 三 种 人 ” 与 严 打 政 策 ， 彻 底 清 理 新 版 总 路 线 外 的 异 见 。";
				if (a.NumberOfPolitician(11, 11) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(11, 11));
				}
				if (a.NumberOfPolitician(6, 6) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(6, 6));
				}
				a.data[15] = 7;
				a.data[17] = 16;
			}
			else
			{
				text = " 意 识 到 大 势 已 去 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 放 弃 挣 扎 ， 立 刻 便 答 应 了" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 等 改 革 派 头 面 人 物 开 出 的 条 件 。 不 久 后 召 开 的 又 一 场 全 会 只 是 将 先 前 讨 论 的 结 果 给 落 到 实 处 ： 党 的 领 导 集 体 决 定 加 快 冤 假 错 案 平 反 速 度 ， 并 要 求 迅 速 解 决 自 “ 文 革 ” 以 来 的 一 系 列 历 史 遗 留 问 题 （ 当 然 也 包 括 借 着 这 一 政 治 风 波 扶 摇 直 上 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ） 。 接 下 来 便 是 通 过 人 事 改 组 ， 安 置 新 部 门 与 平 反 老 干 部 的 三 板 斧 将 “ 两 个 凡 是 ” 与 其 主 要 设 计 者 给 边 缘 化 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 的 左 膀 右 臂 纷 纷 去 了 清 水 衙 门 ， 人 事 、 理 论 与 党 政 的 要 职 也 纷 纷 落 入 了 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 与 其 盟 友 手 中 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 虽 说 没 有 丢 掉 自 己 的 宝 贵 头 衔 ， 可 丢 了 利 爪 的 他 处 处 受 掣 ， 其 退 休 也 不 过 时 间 问 题 。 现 在 ， 全 党 全 军 已 在" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 的 号 令 下 就 位 ， 而 他 已 准 备 好 带 领 国 家 走 向 一 条 史 无 前 例 的 全 面 整 顿 ， 并 在 全 新 基 础 上 建 设 有 中 国 特 色 的 社 会 主 义 之 路 。 日 后 人 们 会 将 这 天 作 为 所 谓 “ 改 革 开 放 ” 的 开 端 铭 记 ， 尽 管 当 事 人 都 清 楚 这 只 是 又 一 场 心 血 来 潮 的 不 流 血 政 变 与 扫 除 杂 草 的 例 行 公 事 而 已 。";
				if (a.NumberOfPolitician(11, 11) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(11, 11));
				}
				if (a.NumberOfPolitician(6, 6) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(6, 6));
				}
				a.data[15] = 7;
			}
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.influencePRC -= 20;
			GlobalScript.inst.gameState.data[89] = 1;
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[3] += 60;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.modifies[3].active = false;
			int[] array = new int[16]
			{
				GlobalScript.inst.gameState.leader.name_1,
				GlobalScript.inst.gameState.leader.name_2,
				GlobalScript.inst.gameState.leader.traits[0],
				GlobalScript.inst.gameState.leader.traits[1],
				GlobalScript.inst.gameState.leader.traits[2],
				GlobalScript.inst.gameState.leader.age,
				GlobalScript.inst.gameState.leader.face_type,
				GlobalScript.inst.gameState.leader.face_parts[0],
				GlobalScript.inst.gameState.leader.face_parts[1],
				GlobalScript.inst.gameState.leader.face_parts[2],
				GlobalScript.inst.gameState.leader.face_parts[3],
				GlobalScript.inst.gameState.leader.face_parts[4],
				GlobalScript.inst.gameState.leader.face_parts[5],
				GlobalScript.inst.gameState.leader.face_parts[6],
				GlobalScript.inst.gameState.leader.face_parts[7],
				GlobalScript.inst.gameState.leader.jacket
			};
			GlobalScript.inst.gameState.leader.name_1 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1;
			GlobalScript.inst.gameState.leader.name_2 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2;
			GlobalScript.inst.gameState.leader.traits[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].traits[0];
			GlobalScript.inst.gameState.leader.traits[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].traits[1];
			GlobalScript.inst.gameState.leader.traits[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].traits[2];
			GlobalScript.inst.gameState.leader.age = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].age;
			GlobalScript.inst.gameState.leader.face_type = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_type;
			GlobalScript.inst.gameState.leader.face_parts[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[0];
			GlobalScript.inst.gameState.leader.face_parts[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[1];
			GlobalScript.inst.gameState.leader.face_parts[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[2];
			GlobalScript.inst.gameState.leader.face_parts[3] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[3];
			GlobalScript.inst.gameState.leader.face_parts[4] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[4];
			GlobalScript.inst.gameState.leader.face_parts[5] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[5];
			GlobalScript.inst.gameState.leader.face_parts[6] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[6];
			GlobalScript.inst.gameState.leader.face_parts[7] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[7];
			GlobalScript.inst.gameState.leader.jacket = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].jacket;
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1 = array[0];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2 = array[1];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].traits[0] = (byte)array[2];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].traits[1] = (byte)array[3];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].traits[2] = (byte)array[4];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].age = (byte)array[5];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_type = (byte)array[6];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[0] = (byte)array[7];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[1] = (byte)array[8];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[2] = (byte)array[9];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[3] = (byte)array[10];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[4] = (byte)array[11];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[5] = (byte)array[12];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[6] = (byte)array[13];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].face_parts[7] = (byte)array[14];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].jacket = (byte)array[15];
			GlobalScript.inst.gameState.faction_leader[3] = 200;
			int[] array2 = new int[8];
			for (int n = 0; n < GlobalScript.inst.gameState.politics_dolshnost.Length; n++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[n] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[n] = (byte)GlobalScript.inst.gameState.faction_leader[3];
				}
				else if (GlobalScript.inst.gameState.politics_dolshnost[n] == (byte)GlobalScript.inst.gameState.faction_leader[3])
				{
					array2[n] = 150;
				}
			}
			for (int num5 = 0; num5 < array2.Length; num5++)
			{
				if (array2[num5] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[num5] = 150;
				}
			}
			for (int num6 = 0; num6 < GlobalScript.inst.gameState.politics.Length; num6++)
			{
				GlobalScript.inst.gameState.CalcRel(num6);
				GlobalScript.inst.gameState.CalcRel2(num6);
				GlobalScript.inst.gameState.CalcRelLeader(num6);
			}
			if (GlobalScript.inst.gameState.leader.name_1 == 13 && GlobalScript.inst.gameState.leader.name_2 == 13)
			{
				int num7 = 0;
				for (int num8 = 0; num8 < GlobalScript.inst.gameState.politics.Length; num8++)
				{
					if (GlobalScript.inst.gameState.politics[num8].power < GlobalScript.inst.gameState.politics[num7].power && GlobalScript.inst.gameState.politics[num8].traits[0] != 2)
					{
						num7 = num8;
					}
				}
				GlobalScript.inst.gameState.politics[num7].name_1 = 25;
				GlobalScript.inst.gameState.politics[num7].name_2 = 55;
				GlobalScript.inst.gameState.politics[num7].age = (byte)(GlobalScript.inst.gameState.data[21] - 1907);
				GlobalScript.inst.gameState.politics[num7].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num7].traits[1] = 5;
				GlobalScript.inst.gameState.politics[num7].traits[2] = 8;
				GlobalScript.inst.gameState.politics[num7].power = 800;
				GlobalScript.inst.gameState.politics[num7].loyality = 800;
				int num9 = 0;
				for (int num10 = 0; num10 < GlobalScript.inst.gameState.politics.Length; num10++)
				{
					if (GlobalScript.inst.gameState.politics[num10].power < GlobalScript.inst.gameState.politics[num9].power && GlobalScript.inst.gameState.politics[num10].traits[0] != 2)
					{
						num9 = num10;
					}
				}
				GlobalScript.inst.gameState.politics[num9].name_1 = 13;
				GlobalScript.inst.gameState.politics[num9].name_2 = 56;
				GlobalScript.inst.gameState.politics[num9].age = (byte)(GlobalScript.inst.gameState.data[21] - 1904);
				GlobalScript.inst.gameState.politics[num9].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num9].traits[1] = 5;
				GlobalScript.inst.gameState.politics[num9].traits[2] = 13;
				GlobalScript.inst.gameState.politics[num9].power = 800;
				GlobalScript.inst.gameState.politics[num9].loyality = 800;
			}
			else if (GlobalScript.inst.gameState.leader.name_1 == 8 && GlobalScript.inst.gameState.leader.name_2 == 8)
			{
				int num11 = 0;
				for (int num12 = 0; num12 < GlobalScript.inst.gameState.politics.Length; num12++)
				{
					if (GlobalScript.inst.gameState.politics[num12].power < GlobalScript.inst.gameState.politics[num11].power && GlobalScript.inst.gameState.politics[num12].traits[0] != 2)
					{
						num11 = num12;
					}
				}
				GlobalScript.inst.gameState.politics[num11].name_1 = 45;
				GlobalScript.inst.gameState.politics[num11].name_2 = 58;
				GlobalScript.inst.gameState.politics[num11].age = (byte)(GlobalScript.inst.gameState.data[21] - 1914);
				GlobalScript.inst.gameState.politics[num11].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num11].traits[1] = 5;
				GlobalScript.inst.gameState.politics[num11].traits[2] = 16;
				GlobalScript.inst.gameState.politics[num11].power = 800;
				GlobalScript.inst.gameState.politics[num11].loyality = 800;
				int num13 = 0;
				for (int num14 = 0; num14 < GlobalScript.inst.gameState.politics.Length; num14++)
				{
					if (GlobalScript.inst.gameState.politics[num14].power < GlobalScript.inst.gameState.politics[num13].power && GlobalScript.inst.gameState.politics[num14].traits[0] != 2)
					{
						num13 = num14;
					}
				}
				GlobalScript.inst.gameState.politics[num13].name_1 = 22;
				GlobalScript.inst.gameState.politics[num13].name_2 = 59;
				GlobalScript.inst.gameState.politics[num13].age = (byte)(GlobalScript.inst.gameState.data[21] - 1904);
				GlobalScript.inst.gameState.politics[num13].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num13].traits[1] = 7;
				GlobalScript.inst.gameState.politics[num13].traits[2] = 8;
				GlobalScript.inst.gameState.politics[num13].power = 800;
				GlobalScript.inst.gameState.politics[num13].loyality = 800;
			}
			party_change[2] = 3f;
			party_change[3] = 4f;
			party_change[4] = 2.5f;
			GlobalScript.inst.gameState.party_ideology[0] -= (int)((float)GlobalScript.inst.gameState.party_ideology[0] * 0.15f);
			GlobalScript.inst.gameState.party_ideology[1] -= (int)((float)GlobalScript.inst.gameState.party_ideology[1] * 0.15f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.power -= 200;
					politic2.loyality -= 500;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.power += 100;
					politic2.loyality -= 100;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.power += 200;
					politic2.loyality += 200;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.power += 80;
					politic2.loyality += 70;
				}
			}
			GlobalScript.inst.gameState.event_done[246] = false;
			break;
		}
		case 1:
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 与 起 事 的 改 革 派 党 员 打 持 久 战 ， 在 打 口 水 仗 与 拖 延 会 议 的 的 同 时 秘 密 聚 拢 兵 力 ， 一 面 通 过 国 家 安 全 机 构 的 联 系 将 忠 诚 派 党 员 加 紧 带 往 北 京 ， 一 面 则 通 过 中 央 警 备 团 与 北 京 当 地 组 织 的 联 系 持 续 扩 充 无 力 ， 并 准 备 隔 离 与 封 锁 国 内 的 主 要 部 门 。 靠 着 不 计 人 力 的 劳 动 密 集 型 办 法 与 好 不 容 易 积 攒 起 的 局 部 优 势 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 终 于 得 以 在 漫 长 而 艰 难 的 混 战 中 将 改 革 派 给 一 网 打 尽 。 不 久 后 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 便 对 怀 仁 堂 事 变 与 苏 联 的 “ 反 党 集 团 ” 实 践 按 图 索 骥 ， 将 参 与 本 次 会 议 的 主 要 角 色 纷 纷 送 去 “ 隔 离 审 查 ” 并 开 除 党 籍 — — 从 而 再 度 巩 固 了 自 己 的 地 位 。 不 过 ， 如 此 大 规 模 的 逮 捕 多 少 造 成 了 一 定 范 围 的 恐 慌 与 社 会 动 荡 。 知 识 界 已 将 其 同 四 清 运 动 相 提 并 论 。";
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.data[3] -= 120;
			GlobalScript.inst.gameState.data[9] -= 150;
			GlobalScript.inst.gameState.data[4] += 150;
			GlobalScript.inst.gameState.data[6] += 30;
			GlobalScript.inst.gameState.KillPerson(GlobalScript.inst.gameState.faction_leader[3]);
			if (a.NumberOfPolitician(13, 13) >= 0)
			{
				GlobalScript.inst.gameState.KillPerson(GlobalScript.inst.gameState.NumberOfPolitician(13, 13));
			}
			if (a.NumberOfPolitician(8, 8) >= 0)
			{
				GlobalScript.inst.gameState.KillPerson(GlobalScript.inst.gameState.NumberOfPolitician(8, 8));
			}
			break;
		case 2:
		{
			if (a.NumberOfPolitician(13, 13) > 0)
			{
				GlobalScript.inst.gameState.faction_leader[3] = a.NumberOfPolitician(13, 13);
				text = " 意 识 到 大 势 已 去 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 放 弃 挣 扎 ， 立 刻 便 答 应 了 邓 小 平 等 改 革 派 头 面 人 物 开 出 的 条 件 。 不 久 后 召 开 的 又 一 场 全 会 只 是 将 先 前 讨 论 的 结 果 给 落 到 实 处 ： 党 的 领 导 集 体 决 定 加 快 冤 假 错 案 平 反 速 度 ， 并 要 求 迅 速 解 决 自 “ 文 革 ” 以 来 的 一 系 列 历 史 遗 留 问 题 （ 当 然 也 包 括 借 着 这 一 政 治 风 波 扶 摇 直 上 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ） 。 接 下 来 便 是 通 过 人 事 改 组 ， 安 置 新 部 门 与 平 反 老 干 部 的 三 板 斧 将 “ 两 个 凡 是 ” 与 其 主 要 设 计 者 给 边 缘 化 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 的 左 膀 右 臂 纷 纷 去 了 清 水 衙 门 ， 人 事 、 理 论 与 党 政 的 要 职 也 纷 纷 落 入 了 邓 小 平 与 其 盟 友 手 中 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 虽 说 没 有 丢 掉 自 己 的 宝 贵 头 衔 ， 可 丢 了 利 爪 的 他 处 处 受 掣 ， 其 权 势 已 不 如 往 昔 。 不 过 ， 由 于 他 能 够 及 时 选 择 站 在 改 革 派 一 方 ， 并 为 国 内 政 治 转 型 开 了 盖 子 。 所 以 他 多 少 能 加 入 到 中 国 的 元 老 圈 子 内 同 邓 小 平 等 人 共 治 。 而 后 者 已 准 备 好 带 领 国 家 走 向 一 条 史 无 前 例 的 全 面 整 顿 ， 并 在 全 新 基 础 上 建 设 有 中 国 特 色 的 社 会 主 义 之 路 。 日 后 人 们 会 将 这 天 视 为 所 谓 “ 改 革 开 放 ” 的 开 端 铭 记 ， 尽 管 当 事 人 都 清 楚 这 只 是 又 一 场 心 血 来 潮 的 不 流 血 政 变 与 扫 除 杂 草 的 例 行 公 事 而 已 。";
				if (a.NumberOfPolitician(11, 11) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(11, 11));
				}
				if (a.NumberOfPolitician(6, 6) >= 0)
				{
					a.KillPerson(a.NumberOfPolitician(6, 6));
				}
				a.data[15] = 7;
				int num = 0;
				for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
				{
					if (GlobalScript.inst.gameState.politics[i].power < GlobalScript.inst.gameState.politics[num].power && GlobalScript.inst.gameState.politics[i].traits[0] != 2)
					{
						num = i;
					}
				}
				GlobalScript.inst.gameState.politics[num].name_1 = 25;
				GlobalScript.inst.gameState.politics[num].name_2 = 55;
				GlobalScript.inst.gameState.politics[num].age = (byte)(GlobalScript.inst.gameState.data[21] - 1907);
				GlobalScript.inst.gameState.politics[num].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num].traits[1] = 5;
				GlobalScript.inst.gameState.politics[num].traits[2] = 8;
				GlobalScript.inst.gameState.politics[num].power = 800;
				GlobalScript.inst.gameState.politics[num].loyality = 800;
				int num2 = 0;
				for (int j = 0; j < GlobalScript.inst.gameState.politics.Length; j++)
				{
					if (GlobalScript.inst.gameState.politics[j].power < GlobalScript.inst.gameState.politics[num2].power && GlobalScript.inst.gameState.politics[j].traits[0] != 2)
					{
						num2 = j;
					}
				}
				GlobalScript.inst.gameState.politics[num2].name_1 = 13;
				GlobalScript.inst.gameState.politics[num2].name_2 = 56;
				GlobalScript.inst.gameState.politics[num2].age = (byte)(GlobalScript.inst.gameState.data[21] - 1904);
				GlobalScript.inst.gameState.politics[num2].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num2].traits[1] = 5;
				GlobalScript.inst.gameState.politics[num2].traits[2] = 13;
				GlobalScript.inst.gameState.politics[num2].power = 800;
				GlobalScript.inst.gameState.politics[num2].loyality = 800;
			}
			else if (a.NumberOfPolitician(8, 8) > 0)
			{
				GlobalScript.inst.gameState.faction_leader[3] = a.NumberOfPolitician(8, 8);
				text = " 意 识 到 大 势 已 去 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 放 弃 挣 扎 ， 立 刻 便 答 应 了 叶 剑 英 等 改 革 派 头 面 人 物 开 出 的 条 件 。 不 久 后 召 开 的 又 一 场 全 会 只 是 将 先 前 讨 论 的 结 果 给 落 到 实 处 ： 党 的 领 导 集 体 决 定 加 快 冤 假 错 案 平 反 速 度 ， 并 要 求 迅 速 解 决 自 “ 文 革 ” 以 来 的 一 系 列 历 史 遗 留 问 题 （ 当 然 也 包 括 借 着 这 一 政 治 风 波 扶 摇 直 上 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ） 。 接 下 来 便 是 通 过 人 事 改 组 ， 安 置 新 部 门 与 平 反 老 干 部 的 三 板 斧 将 “ 两 个 凡 是 ” 与 其 主 要 设 计 者 给 边 缘 化 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 的 左 膀 右 臂 纷 纷 去 了 清 水 衙 门 ， 人 事 、 理 论 与 党 政 的 要 职 也 纷 纷 落 入 了 叶 剑 英 专 门 挑 选 的 人 士 手 中 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 虽 说 没 有 丢 掉 自 己 的 宝 贵 头 衔 ， 可 丢 了 利 爪 的 他 处 处 受 掣 ， 其 权 势 已 不 如 往 昔 。 不 过 ， 由 于 他 能 够 及 时 选 择 站 在 改 革 派 一 方 ， 并 为 国 内 政 治 转 型 开 了 盖 子 。 所 以 他 多 少 能 加 入 到 中 国 的 元 老 圈 子 内 同 叶 剑 英 等 人 共 治 。 叶 剑 英 则 承 诺 将 在 人 民 解 放 军 的 监 督 下 捍 卫 革 命 理 想 ， 并 根 据 经 济 核 算 逻 辑 与 力 行 “ 中 国 特 色 社 会 主 义 路 线 ” ， 首 先 便 是 在 全 面 平 反 冤 假 错 案 的 基 础 上 力 行 清 算 “ 三 种 人 ” 与 严 打 政 策 ， 彻 底 清 理 新 版 总 路 线 外 的 异 见 。";
				a.KillPerson(a.NumberOfPolitician(11, 11));
				a.KillPerson(a.NumberOfPolitician(6, 6));
				a.data[15] = 7;
				a.data[17] = 16;
				int num3 = 0;
				for (int k = 0; k < GlobalScript.inst.gameState.politics.Length; k++)
				{
					if (GlobalScript.inst.gameState.politics[k].power < GlobalScript.inst.gameState.politics[num3].power && GlobalScript.inst.gameState.politics[k].traits[0] != 2)
					{
						num3 = k;
					}
				}
				GlobalScript.inst.gameState.politics[num3].name_1 = 45;
				GlobalScript.inst.gameState.politics[num3].name_2 = 58;
				GlobalScript.inst.gameState.politics[num3].age = (byte)(GlobalScript.inst.gameState.data[21] - 1914);
				GlobalScript.inst.gameState.politics[num3].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num3].traits[1] = 5;
				GlobalScript.inst.gameState.politics[num3].traits[2] = 16;
				GlobalScript.inst.gameState.politics[num3].power = 800;
				GlobalScript.inst.gameState.politics[num3].loyality = 800;
				int num4 = 0;
				for (int l = 0; l < GlobalScript.inst.gameState.politics.Length; l++)
				{
					if (GlobalScript.inst.gameState.politics[l].power < GlobalScript.inst.gameState.politics[num4].power && GlobalScript.inst.gameState.politics[l].traits[0] != 2)
					{
						num4 = l;
					}
				}
				GlobalScript.inst.gameState.politics[num4].name_1 = 22;
				GlobalScript.inst.gameState.politics[num4].name_2 = 59;
				GlobalScript.inst.gameState.politics[num4].age = (byte)(GlobalScript.inst.gameState.data[21] - 1904);
				GlobalScript.inst.gameState.politics[num4].traits[0] = 2;
				GlobalScript.inst.gameState.politics[num4].traits[1] = 7;
				GlobalScript.inst.gameState.politics[num4].traits[2] = 8;
				GlobalScript.inst.gameState.politics[num4].power = 800;
				GlobalScript.inst.gameState.politics[num4].loyality = 800;
			}
			else
			{
				text = " 意 识 到 大 势 已 去 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 放 弃 挣 扎 ， 立 刻 便 答 应 了" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 等 改 革 派 头 面 人 物 开 出 的 条 件 。 不 久 后 召 开 的 又 一 场 全 会 只 是 将 先 前 讨 论 的 结 果 给 落 到 实 处 ： 党 的 领 导 集 体 决 定 加 快 冤 假 错 案 平 反 速 度 ， 并 要 求 迅 速 解 决 自 “ 文 革 ” 以 来 的 一 系 列 历 史 遗 留 问 题 （ 当 然 也 包 括 借 着 这 一 政 治 风 波 扶 摇 直 上 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ） 。 接 下 来 便 是 通 过 人 事 改 组 ， 安 置 新 部 门 与 平 反 老 干 部 的 三 板 斧 将 “ 两 个 凡 是 ” 与 其 主 要 设 计 者 给 边 缘 化 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 的 左 膀 右 臂 纷 纷 去 了 清 水 衙 门 ， 人 事 、 理 论 与 党 政 的 要 职 也 纷 纷 落 入 了 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 与 其 盟 友 手 中 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 虽 说 没 有 丢 掉 自 己 的 宝 贵 头 衔 ， 可 丢 了 利 爪 的 他 处 处 受 掣 ， 其 权 势 已 不 如 往 昔 。 不 过 ， 由 于 他 能 够 及 时 选 择 站 在 改 革 派 一 方 ， 并 为 国 内 政 治 转 型 开 了 盖 子 。 所 以 他 多 少 能 加 入 到 中 国 的 元 老 圈 子 内 同" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[3]].name_2] + " 等 人 共 治 。 而 后 者 已 准 备 好 带 领 国 家 走 向 一 条 史 无 前 例 的 全 面 整 顿 ， 并 在 全 新 基 础 上 建 设 有 中 国 特 色 的 社 会 主 义 之 路 。 日 后 人 们 会 将 这 天 作 为 所 谓 “ 改 革 开 放 ” 的 开 端 铭 记 ， 尽 管 当 事 人 都 清 楚 这 只 是 又 一 场 心 血 来 潮 的 不 流 血 政 变 与 扫 除 杂 草 的 例 行 公 事 而 已 。";
				a.KillPerson(a.NumberOfPolitician(11, 11));
				a.KillPerson(a.NumberOfPolitician(6, 6));
				a.data[15] = 7;
			}
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.influencePRC -= 20;
			GlobalScript.inst.gameState.data[89] = 1;
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[3] += 60;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.modifies[3].active = false;
			party_change[2] = 3f;
			party_change[3] = 4f;
			party_change[4] = 2.5f;
			GlobalScript.inst.gameState.party_ideology[0] -= (int)((float)GlobalScript.inst.gameState.party_ideology[0] * 0.15f);
			GlobalScript.inst.gameState.party_ideology[1] -= (int)((float)GlobalScript.inst.gameState.party_ideology[1] * 0.15f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power -= 200;
					politic.loyality -= 500;
				}
				else if (politic.traits[0] == 1)
				{
					politic.power += 100;
					politic.loyality -= 100;
				}
				else if (politic.traits[0] == 2)
				{
					politic.power += 200;
					politic.loyality += 200;
				}
				else if (politic.traits[0] == 3)
				{
					politic.power += 80;
					politic.loyality += 70;
				}
			}
			GlobalScript.inst.gameState.event_done[246] = false;
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
