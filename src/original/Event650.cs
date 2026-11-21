using EventsForDLC;
using UnityEngine;

public class Event650 : EventsSecond
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
		name = " 谁 成 为 战 士 ， 妈 妈 ？";
		text = " 我 想 您 还 记 得 多 伊 政 权 的 “ 丰 功 伟 绩 ” ， 经 过 了 这 位 ‘ 五 星 上 将 “ 折 腾 的 利 比 里 亚 已 是 一 落 千 丈 ： 广 泛 的 盗 贼 统 治 、 接 连 不 断 的 政 变 、 遍 布 各 地 的 无 政 府 状 态 与 时 不 时 冒 出 的 骇 人 听 闻 暴 行 近 乎 榨 干 了 该 国 鲜 血 。 我 们 可 说 “ 自 由 世 界 的 非 洲 橱 窗 ” 已 死 ， 留 下 的 大 抵 只 是 具 被 各 地 秃 鹫 分 食 的 死 尸 。 倘 若 放 任 当 地 情 况 恶 化 ， 利 比 里 亚 极 有 可 能 成 为 个 充 满 部 族 军 阀 的 非 洲 版 缅 甸 。 不 过 ， 现 在 仍 有 动 手 的 机 会 。 考 虑 到 多 伊 曾 许 诺 将 在 自 己 发 动 政 变 的5 年 后 召 开 选 举 并 准 备 放 权 结 束 军 事 统 治 ， 现 在 正 是 借 题 发 挥 的 时 候 。 不 过 ， 对 利 比 里 亚 局 势 的 贸 然 投 资 真 的 不 会 给 当 地 招 来 下 一 个 多 伊 吗 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 我 们 没 必 要 搅 混 水 … …";
		if (GlobalScript.inst.gameState.allcountries[61].proprc)
		{
			button_text[1] = " 是 时 候 发 动 政 变 推 翻 暴 君 了";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 处 插 针";
		}
		if (a.allcountries[1].Gosstroy == 3 && a.allcountries[51].dev == 1 && GlobalScript.inst.gameState.empires[0].now_leader == 3)
		{
			button_text[2] = " 也 许 我 们 该 致 电 华 盛 顿 ， 要 求 多 伊 履 行 民 主 承 诺";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 美 国 没 心 思 对 私 生 子 的 生 活 指 手 画 脚";
		}
		if (a.allcountries[67].Torg && a.allcountries[1].SubGosstroy == 19 && a.allcountries[41].SubGosstroy == 19 && a.allcountries[117].SubGosstroy == 19)
		{
			button_text[3] = " 患 难 见 真 情 ， 现 在 应 该 给 多 伊 瞧 瞧 谁 是 最 好 的 朋 友 了";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 想 我 们 确 实 是 活 在 更 开 明 的 时 代";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 谁 成 为 战 士 ， 妈 妈 ？";
		switch (result_num)
		{
		case 0:
			text = " 显 然 ， 人 们 没 法 指 望 并 不 懂 得 治 国 的 多 伊 能 在 选 举 上 做 出 什 么 名 堂 ： 靠 着 猖 獗 的 欺 诈 与 胁 迫 投 票 的 手 段 ， 多 伊 成 功 以 “ 等 额 选 举 ” 方 式 获 得 压 倒 性 选 票 ， 最 终 实 现 连 任 。 然 而 ， 如 此 露 骨 的 政 治 欺 诈 显 然 不 会 使 人 满 意 — — 即 便 是 作 为 多 伊 最 大 靠 山 的 华 盛 顿 当 局 也 愈 加 不 满 于 该 国 持 续 恶 化 的 治 安 环 境 ， 并 认 为 多 伊 政 府 难 以 担 当 其 西 非 战 略 的 大 任 。 显 然 ， 如 今 的 利 比 里 亚 总 统 已 是 众 叛 亲 离 ， 其 垮 台 也 不 过 时 间 问 题 … …";
			break;
		case 1:
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.data[22] -= 30;
			if (GlobalScript.inst.gameState.allcountries[61].SubGosstroy == 15)
			{
				text = " 通 过 布 基 纳 法 索 方 的 联 系 ， 我 们 很 快 便 找 到 了 足 以 接 管 当 地 局 势 的 代 理 人 。 布 莱 斯 · 孔 波 雷 亲 自 向 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "引 荐 了 正 协 助 其 改 组 布 基 纳 法 索 安 全 部 队 ， 以 及 训 练 利 比 里 亚 流 亡 者 队 伍 的 查 尔 斯 · 泰 勒 。 泰 勒 曾 在 利 比 亚 接 受 反 帝 国 主 义 训 练 ， 并 以 对 利 比 里 亚 托 尔 伯 特 - 多 伊 两 代 政 权 的 不 妥 协 斗 争 态 度 而 著 称 。 这 位 美 籍 利 比 里 亚 人 在 美 国 的 黑 人 社 区 内 也 是 打 出 了 名 头 ， 凑 齐 了 各 路 人 脉 资 源 。 足 以 实 现 多 伊 倒 台 后 该 国 的 社 会 和 解 。 靠 着 我 们 的 人 力 与 资 金 支 持 ， 泰 勒 很 快 便 将 自 己 的 势 力 打 入 了 利 比 里 亚 ， 顺 势 买 通 了 该 国 数 一 数 二 的 军 官 普 林 斯 · 约 翰 逊 ， 接 下 来 便 是 一 场 可 被 视 为 迷 你 内 战 的 政 变 。 曾 不 可 一 世 的 多 伊 在 混 战 中 被 约 翰 逊 逮 捕 ， 并 最 终 在 荧 幕 上 以 “ 以 牙 还 牙 ” 的 方 式 被 处 决 。 由 此 开 启 了 利 比 里 亚 全 国 爱 国 阵 线 的 统 治 。 然 而 ， 该 政 权 似 乎 并 没 有 如 我 们 所 料 将 带 来 稳 定 — — 泰 勒 与 约 翰 逊 间 已 开 始 就 领 导 权 问 题 争 论 不 休 ， 国 内 部 族 军 阀 也 蠢 蠢 欲 动 ， 且 新 政 权 毫 无 结 束 管 制 的 心 思 ， 甚 至 也 开 始 同 军 阀 那 般 养 起 私 兵 。 看 起 来 事 情 可 不 会 就 此 结 束 。";
				a.allcountries[67].Gosstroy = 0;
				a.allcountries[67].SubGosstroy = 9;
				a.allcountries[67].LeaveAlliances();
				a.allcountries[67].proprc = true;
				a.allcountries[67].Torg = true;
				GlobalScript.inst.gameState.empires[0].power -= 5;
				GlobalScript.inst.gameState.empires[0].relations -= 200;
				GlobalScript.inst.gameState.influencePRC += 10;
				break;
			}
			text = " 通 过 布 基 纳 法 索 方 的 联 系 ， 我 们 很 快 便 找 到 了 足 以 接 管 当 地 局 势 的 代 理 人 。 即 曾 与 多 伊 共 事 的 人 民 救 赎 委 员 会 前 二 把 手 托 马 斯 · 奎 翁 巴 。 虽 说 此 人 并 无 明 显 的 政 治 倾 向 ， 但 奎 翁 巴 曾 作 为 人 民 救 赎 委 员 会 内 “ 良 心 ” 的 口 碑 足 够 让 我 们 为 其 寄 予 期 望 。 他 在1983 年 被 免 去 军 事 领 导 职 务 后 便 被 迫 流 亡 ， 如 今 正 四 处 物 色 盟 友 寻 求 推 翻 多 伊 统 治 。 考 虑 到 仅 靠 奎 翁 巴 一 人 单 打 独 斗 绝 无 可 能 推 翻 多 伊 政 权 ， 我 们 决 定 为 其 物 色 更 多 的 盟 友 ， 并 为 奎 翁 巴 训 练 了 一 只 足 够 精 干 的 突 击 队 对 多 伊 发 起 斩 首 行 动 。||";
			if (GlobalScript.inst.gameState.resultOfEvents[500] == 0)
			{
				text += " 与 此 同 时 ， 我 们 还 联 系 了 曾 在 推 翻 托 尔 伯 特 政 权 时 活 跃 的 左 翼 人 士 （ 如 阿 莫 斯 · 索 耶 律 师 的 利 比 里 亚 人 民 党 ） 和 在 政 府 内 布 有 暗 线 的 人 民 团 结 党 领 袖 加 布 里 埃 尔 · 马 修 斯 等 人 进 行 内 外 策 应 。 终 于 发 起 了 场 可 被 视 为 迷 你 内 战 的 政 变 。 曾 不 可 一 世 的 多 伊 在 混 战 中 被 我 军 逮 捕 ， 并 最 终 在 革 命 法 庭 前 接 受 绞 刑 伏 诛 。 考 虑 到 利 比 里 亚 已 因 多 伊 的 长 期 恶 政 残 破 不 堪 ， 急 需 休 养 生 息 。 新 政 府 很 快 便 选 择 了 拥 抱 民 族 和 解 政 策 ， 并 试 图 靠 加 入 非 洲 一 体 化 引 入 外 来 活 水 的 方 式 迅 速 稳 定 国 内 政 治 经 济 局 势 。 而 作 为 交 换 ， 该 国 自 然 得 回 顾 若 干 历 史 问 题 ， 并 承 认 自 身 在 恩 克 鲁 玛 - 博 瓦 尼 争 论 时 “ 错 得 离 谱 ” ， 接 下 来 便 是 对 加 纳 、 几 内 亚 等 国 的 经 验 按 图 索 骥 。 曾 作 为 蒙 罗 维 亚 派 头 面 旗 手 的 政 权 就 此 洗 心 革 面 ， 接 纳 了 社 会 主 义 与 泛 非 主 义 之 梦 。";
				a.allcountries[67].Gosstroy = 1;
				a.allcountries[67].SubGosstroy = 1;
				a.allcountries[67].LeaveAlliances();
				a.allcountries[67].proprc = true;
				a.allcountries[67].Torg = true;
				a.allcountries[67].JoinAllOurAlliances(yes: true);
				GlobalScript.inst.gameState.empires[0].power -= 15;
				GlobalScript.inst.gameState.empires[0].relations -= 300;
				GlobalScript.inst.gameState.influencePRC += 25;
			}
			else
			{
				text += " 与 此 同 时 ， 我 们 还 联 系 了 利 比 里 亚 国 内 幸 存 的 各 派 反 建 制 势 力 和 作 为 政 府 内 投 诚 者 的 奇 亚 · 奇 波 等 人 进 行 内 外 策 应 。 终 于 发 起 了 场 可 被 视 为 迷 你 内 战 的 政 变 。 曾 不 可 一 世 的 多 伊 在 混 战 中 被 我 军 逮 捕 ， 并 最 终 在 临 时 法 庭 前 接 受 绞 刑 伏 诛 。 考 虑 到 利 比 里 亚 已 因 多 伊 的 长 期 恶 政 残 破 不 堪 ， 急 需 休 养 生 息 。 新 政 府 很 快 便 选 择 了 拥 抱 民 族 和 解 政 策 ， 并 试 图 靠 向 中 国 一 边 倒 引 入 外 来 活 水 的 方 式 迅 速 稳 定 国 内 政 治 经 济 局 势 。 西 非 的 橱 窗 就 此 染 上 了 我 们 的 颜 色 。";
				a.allcountries[67].Gosstroy = 2;
				a.allcountries[67].SubGosstroy = 15;
				a.allcountries[67].LeaveAlliances();
				a.allcountries[67].proprc = true;
				a.allcountries[67].Torg = true;
				a.allcountries[67].JoinAllOurAlliances(yes: true);
				GlobalScript.inst.gameState.empires[0].power -= 10;
				GlobalScript.inst.gameState.empires[0].relations -= 250;
				GlobalScript.inst.gameState.influencePRC += 15;
			}
			break;
		case 2:
			text = " 我 们 决 定 将 多 伊 政 权 的 劣 迹 直 接 上 报 华 盛 顿 ， 并 将 多 伊 许 诺 将 在1985 年 时 实 现 民 主 转 型 的 说 法 对 时 任 美 国 总 统 沃 尔 特 · 蒙 代 尔 故 事 重 提 。 最 终 ， 蒙 代 尔 听 取 了 我 们 的 建 议 ， 决 定 以 威 逼 多 伊 下 台 的 方 式 实 现 该 国 领 导 层 更 替 ， 并 最 终 稳 定 局 势 。 也 就 在 中 情 局 与 美 国 舰 队 的 威 胁 下 ， 多 伊 不 得 不 宣 布 退 出 大 选 ， 并 以 此 秘 密 交 换 的 接 受 政 治 庇 护 与 不 被 新 政 权 清 算 的 许 可 。 随 后 的 选 举 则 落 入 曾 在 托 尔 伯 特 时 期 参 议 院 入 主 参 议 院 的 利 比 里 亚 行 动 党 与 其 党 魁 杰 克 逊 · 多 伊 手 中 ， 看 起 来 该 国 还 是 靠 着 兜 兜 转 转 回 到 了 熟 悉 的 民 主 内 … … 兴 许 如 此 。";
			a.allcountries[67].Gosstroy = 3;
			a.allcountries[67].SubGosstroy = 6;
			a.allcountries[67].LeaveAlliances();
			a.allcountries[67].Vyshi = true;
			a.allcountries[67].Torg = true;
			GlobalScript.inst.gameState.empires[0].power += 10;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[9] -= 40;
			GlobalScript.inst.gameState.data[6] -= 30;
			break;
		case 3:
			text = " 我 们 的 外 交 人 员 用 简 单 易 懂 的 方 式 向 多 伊 表 达 了 合 作 意 愿 ： 即 只 要 多 伊 能 够 遵 循 东 方 大 国 发 展 世 袭 制 度 的 智 慧 ， 那 既 能 摆 脱 繁 琐 且 需 要 周 期 性 伪 造 民 意 的 总 统 制 ， 又 能 充 分 的 实 现 国 家 上 下 一 心 ， 全 体 竭 诚 共 进 。 与 此 同 时 ， 我 们 还 为 多 伊 举 了 扎 伊 尔 “ 伟 大 领 袖 ” 黑 色 江 山 永 不 倒 ， 民 族 情 谊 万 年 牢 的 案 例 ， 以 及 作 为 “ 实 物 参 照 ” 的 门 格 斯 图 大 元 帅 ： 后 者 更 是 对 多 伊 晓 之 以 情 ， 动 之 以 理 ， 以 非 洲 之 角 一 代 雄 主 的 伟 岸 气 魄 让 其 心 服 口 服 。 不 久 后 ， 多 伊 便 开 始 参 照 我 们 的 蓝 图 设 计 “ 有 利 比 里 亚 特 色 的 社 会 主 义 ” ： 可 考 虑 到 利 比 里 亚 长 期 受 资 本 主 义 荼 毒 的 土 地 实 在 没 法 立 即 供 养 如 此 先 进 的 思 想 ， 多 伊 直 截 了 当 的 将 除 克 兰 族 黑 人 嫡 系 控 制 的 机 构 纷 纷 外 包 给 了 我 们 （ 这 事 实 上 意 味 着 彻 底 驱 逐 了 美 国 等 老 牌 列 强 在 当 地 的 全 部 经 营 ， 前 者 可 不 会 高 兴 的 ） ， 并 要 求 中 方 人 员 以 相 关 指 导 思 想 为 纲 首 先 向 利 比 里 亚 精 英 传 授 江 山 代 代 传 的 好 道 理 。 由 此 以 先 觉 带 动 后 觉 ， 最 终 实 现 共 同 觉 醒 。 ";
			a.allcountries[67].Gosstroy = 0;
			a.allcountries[67].SubGosstroy = 19;
			a.allcountries[67].LeaveAlliances();
			a.allcountries[67].proprc = true;
			a.allcountries[67].Torg = true;
			a.allcountries[67].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.empires[0].power -= 10;
			GlobalScript.inst.gameState.empires[0].relations -= 250;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.data[22] -= 30;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
