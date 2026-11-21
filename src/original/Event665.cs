using EventsForDLC;
using UnityEngine;

public class Event665 : EventsSecond
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
		name = " 巴 拿 马 裁 缝";
		text = string.Format("自 巴 拿 马 和 美 国 的 协 议 签 署 完 成 已 经 过 去 了 四 年 ， 巴 拿 马 仍 然 是 国 际 舞 台 上 的 热 点 。 该 国 事 实 上 的 最 高 领 导 人 ， 革 命 领 袖 ， 国 民 警 卫 队 指 挥 官 托 里 霍 斯 已 经 无 可 指 摘 的 统 治 了 近13 年 。 对 他 来 说 ， 被 推 翻 的 政 府 “ 是 军 队 、 寡 头 和 坏 牧 师 的 联 姻 ； 士 兵 拿 着 步 枪 压 制 人 民 ， 禁 止 “ 恶 棍 ” 不 尊 重 统 治 阶 级 。 ” 他 解 释 说 ， 他 的 革 命 是 “ 为 穷 人 而 不 是 为 所 有 者 ” 而 进 行 的 ， 他 制 定 了 一 部 新 宪 法 、 土 地 改 革 和 劳 动 法 ， 并 承 认 了 工 人 和 农 民 的 工 会 。 类 似 于 秘 鲁 的 贝 拉 斯 科 军 政 府 ， 该 国 进 行 了 前 所 未 有 大 规 模 的 土 地 改 革 ， 投 资 福 利 ， 并 多 次 以 收 回 运 河 这 一 巴 拿 马 人 的 心 弦 来 鼓 吹 民 粹 主 义 。 为 了 更 好 的 “ 把 巴 拿 马 革 命 进 行 到 底 ” ， 军 政 府 决 定 建 立 民 主 革 命 党 ， 这 是 一 个 旨 在 吸 纳 中 下 层 群 众 的 党 ， 并 拥 有 巴 拿 马 国 防 军 的 背 景 。||同 时 ， 他 在 外 交 场 合 也 积 极 反 对 美 国 ， 收 回 领 土 的 坚 定 决 心 您 有 目 共 睹 ， 托 里 霍 斯 支 持 智 利 总 统 阿 连 德 ， 并 在1973 年 政 变 后 接 收 智 利 流 亡 者 ， 帮 助 他 还 帮 助 尼 加 拉 瓜 ， 萨 尔 瓦 多 和 危 地 马 拉 等 地 的 反 政 府 游 击 队 ， 并 与 古 巴 重 建 外 交 关 系 。||而 这 也 导 致 了 美 国 对 这 一 政 府 极 度 敌 视 ， 在 签 署 协 议 后 ， 卡 特 宣 布 时 候 进 一 步 “ 民 主 化 ” ， 巴 拿 马 才 有 和 平 收 回 运 河 区 的 希 望 。 同 时 ， “ 菠 萝 ” 曼 努 埃 尔 · 诺 列 加 也 是 政 府 军 内 的 一 位 潜 在 竞 争 者 。 长 袖 善 舞 的 他 多 次 凭 借 自 己 的 特 殊 身 份 在 国 内 屡 出 奇 招 ， 如 果 托 里 霍 斯 将 军 将 会 退 休 的 话 ， 他 必 能 夺 得 头 筹 。主 席 同 志 ， 巴 拿 马 的 经 济 极 度 衰 弱 ， 但 如 果 我 们 能 抓 住 机 会 打 入 该 国 ， 也 许 我 们 就 能 收 获 一 个 潜 在 的 朋 友 。", '\n');
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if ((!a.allcountries[1].isSEV && ((a.allcountries[147].Gosstroy == 2 && a.allcountries[147].proprc) || a.IsSocialism(yes: true, 147))) || a.allcountries[1].isSEV || a.allcountries[147].prosov)
		{
			button_text[0] = "我 们 支 持 托 里 霍 斯 的 义 举 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "可 是 ， 我 们 该 怎 么 帮 他 呢 ？";
		}
		if (a.allcountries[51].dev == 1 && a.science[20])
		{
			button_text[1] = "托 里 霍 斯 是 个 潜 在 的 威 胁 … …";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = "我 们 没 理 由 当 美 帝 的 走 狗 ！";
		}
		button_text[2] = "巴 拿 马 的 命 运 什 么 时 候 轮 到 我 们 决 定 了 ？";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 巴 拿 马 裁 缝";
		switch (result_num)
		{
		case 0:
			if (!a.allcountries[1].isSEV && ((a.allcountries[147].Gosstroy == 2 && a.allcountries[147].proprc) || a.IsSocialism(yes: true, 147)))
			{
				text = $"{GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1]}{GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]}同 志 亲 自 会 见 了 巴 拿 马 参 赞 ， 向 其 点 明 了 我 国 和 巴 拿 马 的 世 纪 友 谊 ： 自 毛 泽 东 主 席 时 代 以 来 ， 我 国 便 坚 定 不 渝 的 支 持 巴 拿 马 人 民 的 斗 争 事 业 。 而 现 在 ， 中 国 依 然 没 有 放 弃 这 一 观 点 。 中 国 愿 意 为 巴 拿 马 提 供 任 何 程 度 的 支 持 ， 从 财 政 到 安 保 ， 甚 至 是 在 未 来 收 回 运 河 后 的 问 题 ， 只 要 巴 拿 马 愿 意 和 美 国 一 刀 两 断 ， 并 公 开 和 台 湾 政 权 断 交 。||很 快 ， 《 巴 拿 马 之 星 》 报 刊 登 了 托 里 霍 斯 的 演 讲 ， 其 中 高 度 称 赞 了 中 国 对 巴 拿 马 革 命 的 支 持 ， 感 谢 了 历 任 中 国 政 府 坚 决 的 支 持 巴 拿 马 人 民 的 斗 争 ， 同 时 强 烈 谴 责 了 美 国 对 中 美 洲 国 家 的 无 耻 干 涉 。 中 华 民 国 的 大 使 则 被 驱 逐 出 境 ， 然 后 则 是 宣 布 断 交 。 很 快 ， 印 有 五 星 红 旗 的 中 国 货 物 便 来 到 了 巴 拿 马 城 。 由 中 国 投 资 建 立 的 “ 一 月 九 日 ” 香 蕉 加 工 厂 正 在 建 设 中 ， 双 方 就 组 建 中 国 - 巴 拿 马 联 合 货 运 公 司 与 捕 虾 船 队 达 成 了 协 议 。 我 们 的 农 耕 队 也 来 到 了 该 国 ， 试 着 考 量 能 否 改 善 该 国 的 粮 食 问 题 。 借 鉴 我 国 民 兵 的 经 验 ， 托 里 霍 斯 也 开 始 组 建 自 己 的 “ 人 民 战 斗 团 ” ， 用 以 对 抗 国 内 的 反 动 势 力 和 外 国 敌 人 。||同 时 ， 我 方 安 保 人 员 破 获 了 一 起 针 对 托 里 霍 斯 的 暗 杀 计 划 ， 一 名 特 工 被 当 场 擒 获 。 他 承 认 收 到 了cia 和 巴 拿 马 内 部 人 员 的 支 持 。 在 首 都 的 三 十 万 人 大 游 行 上 ， 群 众 高 呼 着 “ 斗 争 没 有 结 束 ” ， “ 打 倒 第 五 纵 队 ” 等 口 号 。 美 国 很 不 满 意 ， 称 其 会 对 《 卡 特 — — 托 里 霍 斯 条 约 》 “ 考 虑 再 三 ” 。";
				a.allcountries[141].Torg = true;
				a.allcountries[141].proprc = true;
			}
			else if (a.allcountries[1].isSEV || a.allcountries[147].prosov)
			{
				text = $"{GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1]}{GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]}同 志 和 苏 联 大 使 会 见 了 巴 拿 马 参 赞 ， 向 其 点 明 了 我 国 和 巴 拿 马 的 世 纪 友 谊 ： 自 毛 泽 东 主 席 时 代 以 来 ， 我 国 便 坚 定 不 渝 的 支 持 巴 拿 马 人 民 的 斗 争 事 业 。 而 苏 联 大 使 则 是 当 指 出 了 为 什 么 社 会 正 义 需 要 苏 联 的 支 持 。 托 里 霍 斯 阁 下 定 是 了 解 阿 本 斯 总 统 的 下 场 。 苏 联 愿 意 提 供 安 保 协 定 和 经 互 会 的 观 察 员 席 位 ， 尽 管 这 可 能 代 表 着 和 美 国 的 完 全 对 抗 ， 但 其 代 价 值 得 。||很 快 ， 《 巴 拿 马 之 星 》 报 刊 登 了 托 里 霍 斯 的 演 讲 ， 其 中 高 度 称 赞 了 社 会 主 义 国 家 对 巴 拿 马 革 命 的 支 持 ， 感 谢 了 社 会 主 义 阵 营 坚 决 的 支 持 巴 拿 马 人 民 的 斗 争 ， 同 时 强 烈 谴 责 了 美 国 对 中 美 洲 国 家 的 无 耻 干 涉 。 很 快 ， 苏 联 便 给 出 了 一 套 难 以 拒 绝 的 协 议 ： 巴 拿 马 只 要 愿 意 提 供 足 量 的 香 蕉 ， 苏 联 愿 在 各 个 方 面 提 供 帮 助 。 首 先 是 促 成 了 巴 拿 马 人 民 党 和 民 主 革 命 党 的 合 并 ， 两 党 将 合 并 为 巴 拿 马 社 会 主 义 统 一 党 。 就 此 ， 托 里 霍 斯 掌 握 了 整 个 巴 拿 马 和 运 河 区 的 工 会 组 织 。 就 在 托 里 霍 斯 宣 布 国 有 化 联 合 商 标 公 司 的 香 蕉 园 后 ， 苏 联 的 投 资 如 潮 水 般 涌 向 这 个 小 国 。 不 仅 有 完 全 配 套 的 香 蕉 加 工 设 施 ， 鲜 虾 加 工 厂 ， 木 材 厂 等 。 苏 联 还 援 建 了 巴 拿 马 发 电 站 等 利 好 该 国 工 业 发 展 的 设 施 。 为 数 不 多 的 代 价 则 是 苏 联 海 军 将 在 巴 拿 马 城 建 立 监 听 站 。||克 格 勃 的 美 国 线 人 给 出 了 一 份cia 的 作 战 要 领 ， 其 中 包 括 了 针 对 托 里 霍 斯 的 暗 杀 计 划 。 一 名 特 工 迫 于 压 力 招 供 了 ， 他 承 认 收 到 了cia 和 巴 拿 马 内 部 人 员 的 支 持 ， 这 更 坚 定 了 托 里 霍 斯 转 向 的 念 头 。 很 快 ， 巴 拿 马 代 表 便 开 始 在 经 互 会 活 动 ， 但 代 价 呢 ？ 托 里 霍 斯 是 否 丢 掉 了 什 么 重 要 的 东 西 … …";
				a.empires[1].power += 30;
				a.allcountries[141].Gosstroy = 2;
				a.allcountries[141].SubGosstroy = 3;
				a.allcountries[141].Torg = true;
				a.allcountries[141].prosov = true;
				a.allcountries[141].Torg = true;
			}
			break;
		case 1:
			a.data[9] -= 100;
			a.empires[0].power += 30;
			a.empires[1].power -= 15;
			a.allcountries[141].Gosstroy = 0;
			a.allcountries[141].SubGosstroy = 7;
			a.allcountries[141].Torg = true;
			text = $"{GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1]}{GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]}就 巴 拿 马 政 局 问 题 特 意 致 电 美 国 总 统 ， 认 定 该 国 目 前 的 局 势 与 其 管 理 层 的 态 势 可 能 导 致 下 一 个 古 巴 的 诞 生 。 总 统 阁 下 赞 同 了 我 国 的 立 场 ， 并 委 托 中 央 情 报 局 “ 好 好 办 ” 。||在 “ 菠 萝 ” 的 帮 助 下 ，cia 和 我 国 特 工 成 功 在 托 里 霍 斯 将 军 的 座 驾 上 安 放 了 一 枚 炸 弹 。1981 年7 月31 日 ， 一 架 属 于 巴 拿 马 空 军 的 飞 机 在 塞 罗 马 尔 水 塔 附 近 坠 毁 ， 这 架 飞 机 在 天 气 晴 朗 时 从 雷 达 上 消 失 ， 但 由 于 当 时 巴 拿 马 雷 达 覆 盖 有 限 ， 将 近 一 天 后 才 报 告 飞 机 失 踪 。 几 天 后 ， 坠 机 地 点 被 找 到 ， 一 支 特 种 部 队 找 到 了 托 里 霍 斯 的 尸 体 。 四 名 助 手 和 两 名 飞 行 员 也 在 空 难 中 丧 生 。 他 的 死 引 起 了 全 国 性 的 哀 悼 ， 特 别 是 在 贫 困 地 区 。 在 举 行 了 盛 大 的 国 葬 后 ， 托 里 霍 斯 的 遗 体 被 短 暂 地 埋 葬 在 巴 拿 马 老 城 卡 斯 科 维 耶 霍 的 一 座 公 墓 中 。||很 快 巴 拿 马 城 展 开 了 戒 严 ， 在 美 国 驻 军 的 帮 助 下 ， 曼 努 埃 尔 · 诺 列 加 牵 头 举 行 了 “ 针 对 托 里 霍 斯 将 军 谋 杀 案 的 调 查 ” 借 此 契 机 抓 捕 了 大 量 的 反 对 派 ， 暂 停 了 民 主 革 命 党 和 其 他 政 党 的 合 法 地 位 。 我 想 ， 这 就 是 革 命 的 必 要 之 恶 … …";
			break;
		case 2:
			a.allcountries[141].Gosstroy = 0;
			a.allcountries[141].SubGosstroy = 7;
			text = "  1981 年7 月31 日 ， 一 架 属 于 巴 拿 马 空 军 的 飞 机 在 塞 罗 马 尔 水 塔 附 近 坠 毁 ， 这 架 飞 机 在 天 气 晴 朗 时 从 雷 达 上 消 失 ， 但 由 于 当 时 巴 拿 马 雷 达 覆 盖 有 限 ， 将 近 一 天 后 才 报 告 飞 机 失 踪 。 几 天 后 ， 坠 机 地 点 被 找 到 ，8 月 初 ， 一 支 特 种 部 队 找 到 了 托 里 霍 斯 的 尸 体 。 四 名 助 手 和 两 名 飞 行 员 也 在 空 难 中 丧 生 。 他 的 死 引 起 了 全 国 性 的 哀 悼 ， 特 别 是 在 贫 困 地 区 。 在 举 行 了 盛 大 的 国 葬 后 ， 托 里 霍 斯 的 遗 体 被 短 暂 地 埋 葬 在 巴 拿 马 老 城 卡 斯 科 维 耶 霍 的 一 座 公 墓 中 。||很 快 ， 军 政 府 发 生 了 一 段 权 利 改 组 ， 尽 管 弗 洛 伦 西 奥 · 弗 洛 雷 斯 接 过 了 托 里 霍 斯 的 指 挥 棒 。 但 诺 列 加 正 在 崛 起 ， 巴 拿 马 的 革 命 正 在 结 束 ， 该 国 正 在 慢 慢 成 为 毒 品 的 中 转 站 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
