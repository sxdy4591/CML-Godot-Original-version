using EventsForDLC;
using UnityEngine;

public class Event55 : EventsSecond
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
		name = " 江 水 下 游 的 胞 波";
		text = "主 席 同 志 ， 是 时 候 谈 谈 我 们 南 边 的 邻 居 了 。 看 上 去 和 平 的 曙 光 即 将 将 出 现 在 “ 亚 洲 巴 尔 干 ” 缅 甸 的 地 平 线 上 ： 政 府 不 仅 启 动 了 新 一 轮 特 赦 ， 甚 至 在 同 民 族 地 方 武 装 的 谈 判 上 取 得 了 令 人 印 象 深 刻 的 转 折 。 “ 中 国 人 民 的 老 朋 友 ” ， 适 应 东 南 亚 隐 士 国 度 国 情 的 “ 蒋 介 石 ” 吴 奈 温 将 军 突 访 北 京 ， 并 点 名 同 流 亡 我 国 的 缅 甸 共 产 党 领 导 人 德 钦 巴 登 顶 会 面 谈 判 ， 以 实 现 该 国 的 持 久 和 平 。 德 钦 巴 登 顶 是 与 德 钦 丹 东 同 期 的 缅 甸 共 产 党 （ 白 旗 派 ） 领 导 人 ， 该 党 自1948 年 以 来 便 走 上 了 发 动 游 击 战 争 对 抗 反 法 西 斯 人 民 自 由 联 盟 政 府 ， 实 现 国 家 完 全 独 立 的 道 路 。 也 就 在1962 年 的 吴 奈 温 政 变 后 ， 缅 甸 共 产 党 更 是 借 机 扩 大 斗 争 规 模 ， 将 根 据 地 扩 大 至 缅 甸 北 部 各 地 ， 形 成 了 多 民 族 统 一 战 线 ， 并 以 对 中 国 社 会 主 义 路 线 的 高 度 忠 诚 著 称 ： 德 钦 丹 东 在 根 据 地 开 展 缅 版 文 化 大 革 命 的 消 息 并 非 秘 密 ， 甚 至 可 说 是 最 早 响 应 这 一 运 动 的 组 织 。 这 只 会 让 以 毛 泽 东 主 席 为 代 表 的 一 代 领 导 层 将 其 作 为 东 南 亚 革 命 敲 门 砖 进 行 运 营 。||当 然 ， 我 们 也 并 非 那 种 将 鸡 蛋 全 装 在 一 个 篮 子 内 的 人 ： 考 虑 到 缅 甸 政 府 是 最 早 承 认 我 国 合 法 性 的 非 社 会 主 义 政 权 ， 我 们 很 快 便 通 过 正 常 外 交 渠 道 达 成 了 联 系 ， 并 在 和 平 共 处 五 项 原 则 与 防 范 流 亡 国 民 党 部 队 的 基 础 上 实 现 了 亚 洲 新 兴 民 族 政 权 间 的 合 作 。 吴 努 与 吴 奈 温 政 府 也 就 成 了 可 同 中 国 言 欢 的 好 酒 友 。 考 虑 到 现 任 领 导 人 吴 奈 温 性 格 独 特 ， 不 拘 小 节 ， 甚 至 有 打 “ 红 色 高 棉 牌 ” 的 前 科 ， 很 显 然 是 想 借 试 探 “ 胞 波 ” 关 系 对 亚 洲 版 不 结 盟 运 动 故 事 重 提 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 你 还 记 得 午 门 抗 缅 吗 ？";
		button_text[1] = " 是 时 候 放 下 旧 恨 了 ， 我 们 应 该 重 谈 和 平 共 处 与 历 史 友 谊 ！";
		if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.allcountries[33].stab == 1)
		{
			button_text[2] = " 押 注 革 命 者 与 奈 温 都 只 是 慢 性 死 亡 ， 我 们 将 通 过 打 入 主 义 的 方 式 结 束 缅 甸 动 荡 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 在 仰 光 没 有 信 得 过 的 人";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 江 水 下 游 的 胞 波";
		switch (result_num)
		{
		case 0:
			text = " 将 天 鹅 、 梭 子 鱼 和 虾 团 结 起 来 并 非 易 事 ， 奈 温 与 巴 登 顶 的 会 谈 很 快 便 以 失 败 告 终 。 奈 温 试 图 以 “ 苏 加 诺 二 世 ” 身 份 同 我 国 建 立 统 一 战 线 的 计 划 也 跟 着 胎 死 腹 中 。 显 然 ， 我 们 更 愿 意 和 真 正 的 胞 波 ， 而 非 酒 肉 朋 友 、 同 床 异 梦 的 蒋 介 石 打 交 道 ！ 巴 登 顶 则 对 我 们 的 表 态 持 积 极 态 度 ， 接 下 来 就 请 拭 目 以 待 … …";
			break;
		case 1:
			text = string.Format(" 将 天 鹅 、 梭 子 鱼 和 虾 团 结 起 来 并 非 易 事 ， 奈 温 与 巴 登 顶 的 会 谈 很 快 便 以 失 败 告 终 。 然 而 ， 奈 温 试 图 以 “ 苏 加 诺 二 世 ” 身 份 同 我 国 建 立 统 一 战 线 的 计 划 却 得 到 了 {0}{1} 同 志 的 青 睐 与 赞 许 ， 并 将 其 视 为 打 破 东 南 亚 封 锁 的 关 键 。 很 快 ， 我 们 便 与 缅 甸 建 立 了 一 系 列 合 作 关 系 ， 就 工 业 与 贸 易 问 题 达 成 了 多 项 合 作 条 款 。 当 然 ， 我 们 并 没 有 将 话 说 绝 ， 没 有 公 开 拿 出 “ 停 止 输 出 革 命 ” 的 价 码 ： 这 多 少 让 刚 得 知 邪 恶 联 盟 诞 生 而 大 感 失 望 的 巴 登 顶 稍 稍 稳 定 了 情 绪 。 也 就 在 党 政 军 高 层 均 参 与 的 内 部 会 议 上 ， {0}{1} 同 志 亲 自 以 “ 我 们 不 能 失 去 第 二 个 苏 加 诺 ” 的 说 法 捍 卫 奈 温 政 府 ， 并 以 右 派 与 美 英 势 力 公 开 进 入 缅 甸 的 假 设 巩 固 了 党 内 大 多 数 同 志 的 立 场 。", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.allcountries[33].Torg = true;
			break;
		case 2:
			text = " 考 虑 到 奈 温 政 府 的 改 革 只 会 让 该 国 向 经 济 危 机 一 路 狂 奔 ， 且 缅 甸 国 内 局 势 日 益 严 峻 。 与 其 将 希 望 押 注 在 长 期 游 击 未 取 得 突 破 性 进 展 的 缅 共 上 ， 我 们 决 定 扶 持 一 个 立 场 相 对 奈 温 更 “ 中 派 资 产 阶 级 政 府 ” 的 集 团 掌 权 。 也 就 在 奈 温 于 北 京 全 聚 德 享 用 最 后 一 餐 时 ， 我 们 的 情 报 人 员 同 时 在 仰 光 策 动 了 反 奈 温 政 变 。||";
			GlobalScript.inst.gameState.allcountries[33].parts[0] = false;
			if (a.data[16] <= 12)
			{
				text += " 新 政 府 由 山 友 和 曾 任 独 立 运 动 时 期 “ 三 十 同 志 ” 之 一 的 盛 温 带 领 。 他 们 在 批 判 奈 温 破 坏 社 会 主 义 经 济 建 设 ， 自 绝 于 社 会 主 义 阵 营 与 败 坏 “ 缅 甸 社 会 主 义 道 路 ” 声 誉 的 同 时 进 行 改 革 。 大 众 党 的 文 官 统 治 地 位 得 以 巩 固 ， 缅 甸 开 始 推 进 农 业 集 体 化 并 重 回 不 结 盟 运 动 。 当 然 ， 掸 邦 的 大 小 民 团 ， 如 罗 星 汉 等 “ 风 云 人 物 ” 们 对 这 些 变 化 怒 不 可 遏 。 此 后 ， 我 们 更 是 在 缅 甸 北 部 达 成 短 暂 停 火 协 议 ， 事 实 上 完 全 孤 立 了 巴 登 顶 队 伍 ， 后 者 的 灭 亡 不 过 时 间 问 题 。 但 已 拿 到 西 瓜 的 我 们 何 必 在 乎 芝 麻 呢 ？";
				GlobalScript.inst.gameState.data[9] -= 50;
				GlobalScript.inst.gameState.data[6] += 20;
				GlobalScript.inst.gameState.empires[0].relations -= 80;
				GlobalScript.inst.gameState.allcountries[33].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[33].SubGosstroy = 15;
				GlobalScript.inst.gameState.allcountries[33].Torg = true;
				GlobalScript.inst.gameState.allcountries[33].proprc = true;
				GlobalScript.inst.gameState.allcountries[33].prcpower = 1000;
			}
			else
			{
				text += " 新 政 府 由 华 裔 特 务 将 军 钦 纽 和 热 心 经 济 改 革 的 将 军 昂 基 带 领 。 他 们 在 批 判 奈 温 持 反 华 思 潮 的 大 缅 族 主 义 ， 破 坏 民 族 间 的 和 谐 关 系 与 败 坏 “ 缅 甸 社 会 主 义 道 路 ” 声 誉 的 同 时 进 行 改 革 。 出 于 应 付 奈 温 的 灾 难 性 货 币 改 革 政 策 ， 缅 甸 经 济 开 启 了 大 规 模 改 革 。 越 来 越 多 的 顾 问 被 派 到 我 国 以 学 习 我 国 的 管 制 市 场 发 展 模 式 。 此 后 ， 我 们 更 是 在 缅 甸 北 部 达 成 短 暂 停 火 协 议 ， 事 实 上 完 全 孤 立 了 巴 登 顶 队 伍 ， 后 者 的 灭 亡 不 过 时 间 问 题 。 但 已 拿 到 西 瓜 的 我 们 何 必 在 乎 芝 麻 呢 ？";
				GlobalScript.inst.gameState.data[9] -= 50;
				GlobalScript.inst.gameState.data[6] += 20;
				GlobalScript.inst.gameState.empires[0].relations -= 80;
				GlobalScript.inst.gameState.allcountries[33].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[33].SubGosstroy = 7;
				GlobalScript.inst.gameState.allcountries[33].Torg = true;
				GlobalScript.inst.gameState.allcountries[33].proprc = true;
				GlobalScript.inst.gameState.allcountries[33].prcpower = 1000;
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
