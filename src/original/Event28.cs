using EventsForDLC;
using UnityEngine;

public class Event28 : EventsSecond
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
		name = " “ 新 秩 序 ” 的 终 结 ？";
		text = " 苏 哈 托 少 将 在 1 9 6 5 年 夺 取 印 度 尼 西 亚 大 权 后 的 时 期 被 称 作 “ 新 秩 序 ” 时 期 。 这 一 时 期 的 特 点 是 反 共 ， 以 及 指 导 式 民 主 。 共 产 党 人 在 这 一 时 期 被 大 规 模 处 决 ， 幸 存 者 不 得 不 流 亡 中 国 和 阿 尔 巴 尼 亚 。 仅 在 6 5 — 6 6 年 ， 就 有 约 三 百 万 人 因 为 同 情 共 产 党 而 被 杀 。 印 尼 少 数 民 族 也 难 逃 厄 运 ， 其 中 包 括 华 人 ， 对 他 们 的 歧 视 仍 然 是 合 法 的 。 苏 哈 托 的 压 迫 政 权 因 美 国 支 持 和 与 东 南 亚 国 家 有 利 可 图 的 贸 易 得 以 维 系 。||现 在 我 们 切 断 了 印 度 尼 西 亚 与 其 多 数 伙 伴 的 联 系 ， 引 发 了 印 尼 严 重 的 经 济 和 政 治 危 机 ， 苏 哈 托 对 权 力 的 控 制 被 削 弱 了 。 经 济 上 外 资 外 逃 ， 导 致 印 尼 盾 价 值 急 剧 下 降 ， 苏 哈 托 不 情 愿 地 同 意 了 国 际 货 币 基 金 组 织 更 广 泛 的 结 构 性 改 革 方 案 ， 以 换 取 4 3 0 亿 美 元 的 外 国 援 助 。 然 而 ， 印 尼 盾 跌 至 危 机 前 价 值 的 六 分 之 一 ， 谣 言 和 恐 慌 导 致 商 店 挤 兑 进 一 步 推 高 了 价 格 ， 严 重 影 响 了 经 济 和 民 生 。 在 这 一 情 况 下 ， 民 族 矛 盾 开 始 加 重 ， 大 学 生 开 始 组 织 全 国 性 的 示 威 活 动 。 这 些 示 威 者 抗 议 燃 料 和 能 源 价 格 的 大 幅 上 涨 ， 并 要 求 苏 哈 托 总 统 下 台 。 于 此 同 时 ， 印 尼 几 大 城 市 也 发 生 了 排 华 运 动 。||反 对 新 秩 序 的 民 间 左 翼 力 量 — — 印 尼 民 主 党 如 今 也 开 始 积 极 反 对 专 制 体 制 ， 该 党 原 先 被 苏 哈 托 选 为 御 用 反 对 派 ， 但 如 今 内 部 发 生 了 一 次 内 部 洗 牌 ， 得 益 于 局 势 ， 更 大 胆 的 成 员 们 集 中 力 量 推 举 梅 加 瓦 蒂 — — 苏 加 诺 总 统 的 女 儿 ， 成 为 民 主 左 翼 反 对 派 的 头 面 领 导 人 物 ， 与 此 同 时 ， 在 北 加 里 曼 丹 重 新 革 命 后 ， 印 尼 共 产 党 秘 密 重 建 地 下 组 织 ， 如 果 条 件 允 许 ， 将 能 够 发 起 一 场 革 命 ， 一 雪 1 9 6 5 之 耻 。||我 们 该 如 何 选 择 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 不 要 干 预 ， 苏 哈 托 注 定 要 失 败";
		if (GlobalScript.inst.gameState.data[56] >= 3)
		{
			button_text[1] = " 鼓 动 苏 哈 托 内 阁 施 压 独 裁 者";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 天 下 乌 鸦 一 般 黑 ！";
		}
		if (GlobalScript.inst.gameState.data[56] <= 3 && GlobalScript.inst.gameState.data[56] >= 2)
		{
			button_text[2] = " 支 持 印 尼 民 主 党 并 呼 吁 减 少 无 意 义 的 暴 力";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 过 去 的 经 验 已 经 证 明 了 这 种 模 式 的 缺 陷";
		}
		if (GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.allcountries[49].Gosstroy == 1)
		{
			button_text[3] = " 是 时 候 终 结 旧 世 界 了 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 不 能 这 么 激 进 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " “ 新 秩 序 ” 的 终 结 ？";
		switch (result_num)
		{
		case 0:
			text = " 苏 哈 托 并 未 如 我 们 所 期 望 的 那 样 选 择 坐 以 待 毙 ， 尽 管 波 尼 曼 总 司 令 拒 绝 执 行 镇 压 行 动 ， 但 在 澳 大 利 亚 的 默 许 下 ， 他 选 择 重 新 给 予 如 纳 苏 蒂 安 等 强 硬 派 军 权 以 镇 压 反 对 派 。 很 快 ， 印 尼 进 入 了 全 国 紧 急 状 态 。 政 府 选 择 挑 动 印 尼 各 族 裔 民 众 的 内 部 矛 盾 ， 让 抗 议 者 将 抗 议 对 象 从 政 府 转 向 华 裔 人 群 。 在 全 国 各 地 的 示 威 活 动 中 ， 军 方 直 接 使 用 坦 克 和 航 空 炸 弹 进 行 暴 力 清 场 ， 参 与 抗 议 的 高 校 学 生 一 律 开 除 学 籍 ， 他 们 在 身 份 上 被 定 位 为 类 似 共 产 党 人 的 “ 不 可 接 触 者 ” ， 将 面 临 一 系 列 社 会 歧 视 。 在 该 国 各 地 ， 分 裂 主 义 者 的 势 力 急 剧 加 强 了 ， 而 雅 加 达 在 民 族 矛 盾 激 化 的 背 景 下 得 以 公 然 推 行 大 爪 哇 主 义 集 权 政 策 ， 美 名 其 曰 “ 第 二 次 民 族 革 命 “ — — 新 秩 序 的 未 来 是 灰 暗 的 ， 但 是 看 起 来 他 的 慢 性 死 亡 还 要 过 很 久 ， 也 许 是 永 远 … …";
			GlobalScript.inst.gameState.allcountries[50].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[50].SubGosstroy = 9;
			return;
		case 1:
		{
			text = " 在 社 会 动 荡 和 经 济 危 机 的 情 况 下 ， 苏 哈 托 的 盟 友 拒 绝 在 新 内 阁 任 职 ， 而 曾 经 被 苏 哈 托 牢 牢 控 制 的 议 会 发 出 了 弹 劾 威 胁 。 面 对 弹 劾 威 胁 以 及 1 4 名 内 阁 成 员 拒 绝 组 建 新 内 阁 的 信 ， 苏 哈 托 决 定 辞 职 。 次 日 上 午 9 时 ， 苏 哈 托 发 表 了 简 短 的 辞 职 讲 话 。 他 立 即 被 副 总 统 苏 达 尔 莫 诺 取 代 职 责 ， 后 者 试 图 维 持 “ 没 有 苏 哈 托 的 苏 哈 托 体 制 “ 的 尝 试 失 败 了 ， 在 选 举 中 大 败 于 日 惹 亲 王 哈 孟 古 布 沃 诺 十 世 与 建 设 统 一 党 形 成 的 自 由 - 保 守 主 义 联 盟 。 新 政 府 开 始 实 行 自 由 化 ， 允 许 言 论 自 由 和 媒 体 方 面 的 自 由 。 在 东 帝 汶 问 题 方 面 ， 授 予 东 帝 汶 特 别 自 治 权 作 为 即 将 进 一 步 联 邦 化 印 尼 为 ” 印 尼 合 众 国 “ 的 试 点 。 针 对 苏 哈 托 时 期 的 腐 败 审 查 也 在 准 备 中 ， 只 是 在 日 惹 亲 王 与 伊 斯 兰 民 主 派 的 政 府 下 ， 潘 查 希 拉 似 乎 有 朝 一 日 也 要 成 为 程 序 正 义 的 清 算 的 牺 牲 品 。";
			GlobalScript.inst.gameState.data[8] -= 20;
			GlobalScript.inst.gameState.data[9] -= 20;
			GlobalScript.inst.gameState.empires[0].power -= 20;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.allcountries[50].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[50].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[50].Torg = true;
			GlobalScript.inst.gameState.allcountries[50].SubGosstroy = 6;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] <= 2)
				{
					politic2.loyality += 70;
				}
			}
			return;
		}
		case 2:
		{
			text = " 我 们 选 择 帮 助 梅 加 瓦 蒂 和 领 导 的 印 尼 民 主 党 ， 在 我 们 的 帮 助 下 ， 我 们 的 特 工 运 用 印 尼 国 父 苏 加 诺 的 旗 号 ， 将 所 有 反 对 派 聚 集 在 梅 加 瓦 蒂 周 围 成 功 开 展 了 一 场 和 平 革 命 。 苏 哈 托 政 府 全 体 辞 职 了 ， 印 尼 民 主 党 赢 得 了 随 后 的 全 国 大 选 。 新 政 府 对 犯 下 暴 行 的 苏 哈 托 以 及 反 动 的 旧 统 治 集 团 展 开 公 审 并 对 军 队 展 开 清 洗 ， 以 结 束 军 队 干 政 。 此 外 ， 新 政 府 还 确 立 将 对 排 华 运 动 中 受 害 的 华 人 进 行 赔 偿 ， 并 实 行 民 族 和 解 和 各 民 族 平 等 的 政 策 。 与 此 同 时 ， 新 政 府 选 择 重 新 实 施 苏 加 诺 的 社 会 主 义 政 策 ， 解 禁 共 产 党 ， 并 结 束 经 济 危 机 。 关 于 亚 齐 、 巴 布 亚 和 东 帝 汶 的 问 题 的 谈 判 也 正 在 开 展 。 印 尼 迎 来 了 属 于 她 的 新 时 代 。";
			GlobalScript.inst.gameState.data[8] -= 60;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.empires[0].power -= 40;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.allcountries[50].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[50].isASEAN = false;
			GlobalScript.inst.gameState.allcountries[50].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[50].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[50].Torg = true;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] <= 1)
				{
					politic.loyality += 100;
				}
			}
			break;
		}
		}
		if (result_num == 3)
		{
			text = " 由 于 我 们 支 持 的 印 尼 共 产 党 已 经 以 北 加 里 曼 丹 为 基 地 对 印 度 尼 西 亚 进 行 了 渗 透 ， 所 以 它 能 快 速 的 将 抗 议 者 吸 纳 进 党 组 织 之 中 ， 在 城 市 中 展 开 街 垒 战 和 在 农 村 开 展 人 民 战 争 ， 并 且 能 够 对 政 府 设 施 进 行 许 多 袭 击 。 在 我 们 的 支 持 下 ， 人 民 民 主 党 等 左 翼 势 力 、 印 尼 民 主 党 内 部 的 左 翼 派 系 以 及 各 个 温 和 反 对 派 也 被 纳 入 印 尼 共 的 统 一 战 线 。 很 快 ， 对 抗 转 变 为 一 场 印 尼 国 内 的 大 型 冲 突 ， 旧 的 反 动 统 治 集 团 和 军 队 对 共 产 党 和 反 对 派 的 壮 大 十 分 恐 慌 ， 在 帝 国 主 义 势 力 的 支 持 下 ， 印 尼 专 制 政 府 对 以 共 产 党 为 首 的 反 对 派 宣 战 。 一 场 革 命 开 始 了 ！";
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[6] += 40;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.allcountries[50].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[50].SubGosstroy = 9;
			GlobalScript.inst.gameState.ingamewars[35].name_war = " 印 度 尼 西 亚 革 命";
			GlobalScript.inst.gameState.ingamewars[35].is_going = true;
			GlobalScript.inst.gameState.ingamewars[35].side1 = " 印 度 尼 西 亚 反 对 派";
			GlobalScript.inst.gameState.ingamewars[35].side2 = " 印 度 尼 西 亚 政 府";
			GlobalScript.inst.gameState.ingamewars[35].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[35].infl1 = 300;
			GlobalScript.inst.gameState.ingamewars[35].infl2 = 700;
			GlobalScript.inst.gameState.ingamewars[35].fortnight_max = 20;
			GlobalScript.inst.gameState.empires[0].relations -= 300;
			GlobalScript.inst.gameState.influencePRC += 20;
		}
	}
}
