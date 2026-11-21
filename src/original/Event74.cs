using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event74 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	public bool load_scene_after_click;

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
		name = " 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议";
		text = " 经 过 数 年 的 努 力 ， 我 们 的 写 作 组 终 于 完 成 了1979 年 末 党 中 央 赋 予 的 神 圣 使 命 ， 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 的 终 稿 就 此 出 炉 ： 《 决 议 》 终 稿 共 有3.4 万 字 ， 并 以 我 党 历 史 为 主 轴 ， 将 其 分 作8 部 分 进 行 细 致 分 析 。 诚 然 ， 人 们 还 未 发 展 到 能 主 动 书 写 历 史 的 境 界 ， 意 味 着 我 们 也 只 能 对 着 往 日 的 一 系 列 大 事 件 与 社 会 现 象 亦 步 亦 遂 ， 通 过 观 察 其 中 的 活 动 、 思 想 、 历 史 、 社 会 等 诸 多 要 素 摸 出 复 杂 现 象 背 后 的 各 种 原 因 。 不 过 ， 我 们 终 归 是 历 尽 艰 难 险 阻 完 成 了 这 一 工 作 ， 接 下 来 便 是 在 党 的 十 一 届 六 中 全 会 上 对 其 进 行 审 议 ， 将 其 从 党 的 高 层 落 到 基 层 各 处 而 已 。 可 考 虑 到 我 们 正 处 在 变 革 时 代 ， 这 份 旨 在 实 现 “ 盖 棺 定 论 ” 的 文 件 可 不 太 可 能 被 立 即 盖 棺 定 论 。 毕 竟 ， 如 今 的 党 中 央 与70 年 代 末 下 决 定 的 党 中 央 也 不 能 简 单 地 同 日 而 语 。 而 《 决 议 》 恰 是 属 于 后 者 那 一 时 代 的 文 件 ， 同 目 前 党 内 热 衷 的 总 路 线 打 架 并 非 毫 无 可 能 。";
		if (GlobalScript.inst.gameState.data[90] == 0)
		{
			text += "| 该 版 《 决 议 》 基 本 可 说 是 对1945 年 通 过 的 《 关 于 若 干 历 史 问 题 的 决 议 》 的 续 写 ， 谋 篇 布 局 也 类 似 《 联 共 （ 布 ） 党 史 基 本 教 程 》 的 老 调 ： 即 我 们 中 国 共 产 党 全 体 是 如 何 牢 牢 团 结 在 以 毛 泽 东 同 志 为 核 心 的 党 中 央 周 围 ， 高 举 毛 泽 东 思 想 伟 大 旗 帜 ， 并 在 “ 左 ” 倾 、 右 倾 两 侧 进 攻 下 贯 彻 群 众 路 线 ， 落 实 独 立 自 足 原 则 ， 从 而 走 出 适 合 中 国 人 民 的 社 会 主 义 道 路 。 当 然 ， 如 此 肯 定 毛 主 席 与 其 事 业 的 立 场 与 宜 粗 不 宜 细 的 历 史 论 述 使 得 其 更 像 是 延 安 整 风 时 代 的 发 放 材 料 ， 且 只 会 巩 固 我 党 持 教 条 主 义 观 点 者 的 立 场 。";
		}
		else if (GlobalScript.inst.gameState.data[90] == 1)
		{
			text += "| 该 版 《 决 议 》 对 于 我 党 的 革 命 与 建 设 历 程 采 取 了 相 对 谨 慎 的 立 场 ， 并 对1945 年 通 过 的 《 关 于 若 干 历 史 问 题 的 决 议 》 进 行 了 再 创 作 ： 即 在 描 述 建 国 前 历 史 的 部 分 沿 用 后 者 的 “ 全 面 肯 定 ” 说 辞 ， 而 在 转 入 建 国 部 分 叙 述 时 采 取 “ 积 极 认 可 ” 的 态 度 ， 并 将 党 内 公 认 的 梦 魇 “ 文 化 大 革 命 ” 列 入 专 题 专 门 分 析 ， 将 其 同 我 们 基 本 正 确 的 执 政 治 国 路 线 区 别 开 来 。 因 此 ， 我 党 历 史 的 制 胜 法 门 也 被 锚 定 在 “ 基 于 实 事 求 是 的 原 则 基 础 上 充 分 发 挥 集 体 智 慧 运 用 活 的 毛 泽 东 思 想 ” 上 。 意 味 着 我 们 足 以 在 “ 保 留 一 切 优 秀 文 化 遗 产 ” 的 同 时 “ 去 除 一 切 落 后 历 史 糟 粕 ” ， 并 通 过 选 择 性 地 割 舍 晚 年 毛 泽 东 政 治 轨 迹 的 方 式 为 党 开 出 新 路 。 这 份 取 巧 的 文 件 一 定 能 为 我 们 争 得 大 多 数 人 的 支 持 — — 只 有 那 些 被 扣 上 “ 失 败 ” 黑 锅 的 边 缘 派 ， 没 法 发 表 意 见 的 死 人 与 呼 吁 推 翻 一 切 的 极 端 分 子 会 对 此 “ 有 所 抱 怨 ” 。";
		}
		else if (GlobalScript.inst.gameState.data[90] == 2)
		{
			text += "| 该 版 《 决 议 》 以 毫 不 留 情 ， 痛 心 疾 首 与 宛 如 古 代 王 朝 罪 己 状 的 笔 法 炮 击 我 党 自 执 政 建 国 以 来 的 历 史 ， 其 严 厉 程 度 多 少 可 同 赫 鲁 晓 夫 的 “ 秘 密 报 告 ” 看 齐 ： 由 于 个 人 崇 拜 与 军 事 突 击 手 段 在 国 内 大 行 其 道 ， 中 国 的 社 会 主 义 之 路 就 此 深 陷 主 观 主 义 阴 云 ， 唯 有 “ 过 渡 时 期 总 路 线 ” 、1954 年 形 成 的 《 宪 法 》 与 多 项 基 本 制 度 与 中 共 八 大 时 期 确 立 的 发 展 方 针 等 彰 显 “ 集 体 智 慧 ” 的 决 定 与 党 试 图 在 “ 极 左 ” 思 潮 下 纠 偏 整 顿 的 努 力 值 得 被 肯 定 。 而 上 述 问 题 都 脱 不 开 毛 泽 东 的 个 人 领 导 作 风 与 中 国 社 会 内 长 期 淤 积 的 弊 病 ： 如 果 我 们 想 要 剔 除 病 根 ， 就 必 须 深 挖 土 层 ， 在 揪 出 “ 我 们 队 伍 内 混 蛋 ” 的 同 时 进 行 批 评 与 自 我 批 评 ， 顺 势 要 求 全 国 建 立 全 新 的 体 系 。 只 是 尚 不 知 社 会 有 没 有 为 此 做 好 准 备 … …";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (GlobalScript.inst.gameState.data[90] == 0)
		{
			button_text[0] = " 全 会 讨 论 并 通 过 了 这 一 版 本";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 不 会 的 。 怎 么 可 能 通 过 呢？";
		}
		if (GlobalScript.inst.gameState.data[90] == 1)
		{
			button_text[1] = " 全 会 讨 论 并 通 过 了 这 一 版 本";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 不 会 的 。 怎 么 可 能 通 过 呢？";
		}
		if (GlobalScript.inst.gameState.data[90] == 2)
		{
			button_text[2] = " 全 会 讨 论 并 通 过 了 这 一 版 本";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 不 会 的 。 怎 么 可 能 通 过 呢？";
		}
		button_text[3] = " 你 在 这 里 写 的 什 么 东 西 ？ ！ 立 即 对 文 本 进 行 修 订 ！";
		if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[4] = " 在 主 席 的 要 求 下 ， “ 决 议 ” 的 问 题 被 从 议 程 中 移 除";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 这 个 问 题 对 中 国 共 产 党 来 说 太 重 要 了 ， 不 能 把 它 从 议 程 中 删 除";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议";
		switch (result_num)
		{
		case 0:
		{
			text = "1981 年6 月27 日 至29 日 ， 中 国 共 产 党 第 十 一 届 中 央 委 员 会 第 六 次 全 体 会 议 在 北 京 隆 重 召 开 ，195 名 中 央 委 员 、114 名 中 央 候 选 人 和53 名 特 邀 人 员 出 席 。 本 次 会 议 决 定 审 议 和 通 过 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 ， 并 在 整 顿 思 想 、 确 保 看 齐 意 识 的 基 础 上 改 选 中 央 主 要 领 导 成 员 。 最 终 ， 全 会 一 致 通 过 了 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 。 《 决 议 》 立 足 毛 泽 东 思 想 与 中 国 社 会 主 义 实 践 ， 对 建 国 三 十 二 年 来 党 的 重 大 历 史 事 件 特 别 是 “ 文 化 大 革 命 ” 作 出 了 正 确 的 总 结 ， 科 学 地 总 结 了 在 这 些 事 件 中 党 在 反 对 “ 左 ” 右 脱 轨 倾 向 中 的 宝 贵 经 验 ， 并 从 正 反 两 角 度 强 调 了 坚 持 毛 泽 东 思 想 的 正 确 性 与 必 要 性 ， 实 事 求 是 地 评 价 了 伟 大 领 袖 和 导 师 毛 泽 东 同 志 在 中 国 革 命 中 的 历 史 地 位 ， 充 分 论 述 了 毛 泽 东 思 想 作 为 我 们 党 的 指 导 思 想 的 伟 大 意 义 。 《 决 议 》 肯 定 了 我 党 自 遵 义 会 议 以 来 逐 步 确 立 的 正 确 道 路 ， 进 一 步 指 明 了 我 国 社 会 主 义 事 业 和 党 的 工 作 继 续 前 进 的 方 向 。 全 会 认 为 ， 《 决 议 》 的 通 过 和 发 表 ， 对 于 统 一 全 党 、 全 军 、 全 国 各 族 人 民 的 思 想 认 识 ， 同 心 同 德 地 为 实 现 新 的 历 史 任 务 而 奋 斗 ， 必 将 产 生 伟 大 的 深 远 的 影 响 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[4] -= 100;
			GlobalScript.inst.gameState.data[92] -= 20;
			GlobalScript.inst.gameState.data[6] += 50;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			party_change[0] = 0.24f;
			party_change[1] = 0.24f;
			Politic[] politics2 = GlobalScript.inst.gameState.politics;
			foreach (Politic politic6 in politics2)
			{
				if (politic6.traits[0] == 0)
				{
					politic6.power += 100;
					politic6.loyality += 150;
				}
				else if (politic6.traits[0] == 1)
				{
					politic6.power -= 50;
					politic6.loyality -= 50;
				}
				else if (politic6.traits[0] == 2)
				{
					politic6.power -= 100;
					politic6.loyality -= 100;
				}
				else if (politic6.traits[0] == 3)
				{
					politic6.power -= 150;
					politic6.loyality -= 150;
				}
			}
			break;
		}
		case 1:
		{
			text = "1981 年6 月27 日 至29 日 ， 中 国 共 产 党 第 十 一 届 中 央 委 员 会 第 六 次 全 体 会 议 在 北 京 隆 重 召 开 ，195 名 中 央 委 员 、114 名 中 央 候 选 人 和53 名 特 邀 人 员 出 席 。 本 次 会 议 决 定 审 议 和 通 过 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 ， 并 在 整 顿 思 想 、 确 保 看 齐 意 识 的 基 础 上 改 选 中 央 主 要 领 导 成 员 。 最 终 ， 全 会 一 致 通 过 了 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 。 《 决 议 》 运 用 马 克 思 主 义 的 辩 证 唯 物 论 和 历 史 唯 物 论 ， 对 建 国 三 十 二 年 来 党 的 重 大 历 史 事 件 特 别 是 “ 文 化 大 革 命 ” 作 出 了 正 确 的 总 结 ， 科 学 地 分 析 了 在 这 些 事 件 中 党 的 指 导 思 想 的 正 确 和 错 误 ， 分 析 了 产 生 错 误 的 主 观 因 素 和 社 会 原 因 ， 实 事 求 是 地 评 价 了 伟 大 领 袖 和 导 师 毛 泽 东 同 志 在 中 国 革 命 中 的 历 史 地 位 ， 充 分 论 述 了 毛 泽 东 思 想 作 为 我 们 党 的 指 导 思 想 的 伟 大 意 义 。 《 决 议 》 肯 定 了 自 毛 主 席 去 世 后 我 党 新 一 代 领 导 集 体 逐 步 确 立 的 适 合 我 国 情 况 的 建 设 社 会 主 义 现 代 化 强 国 的 正 确 道 路 ， 进 一 步 指 明 了 我 国 社 会 主 义 事 业 和 党 的 工 作 继 续 前 进 的 方 向 。 全 会 认 为 ， 《 决 议 》 的 通 过 和 发 表 ， 对 于 统 一 全 党 、 全 军 、 全 国 各 族 人 民 的 思 想 认 识 ， 同 心 同 德 地 为 实 现 新 的 历 史 任 务 而 奋 斗 ， 必 将 产 生 伟 大 的 深 远 的 影 响 。";
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[92] += 10;
			GlobalScript.inst.gameState.data[4] -= 50;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.influencePRC -= 20;
			party_change[2] = 0.15f;
			party_change[3] = 0.21f;
			Politic[] politics2 = GlobalScript.inst.gameState.politics;
			foreach (Politic politic5 in politics2)
			{
				if (politic5.traits[0] == 0)
				{
					politic5.loyality += 100;
				}
				else if (politic5.traits[0] == 1)
				{
					politic5.power += 100;
					politic5.loyality += 100;
				}
				else if (politic5.traits[0] == 2)
				{
					politic5.power += 100;
					politic5.loyality += 100;
				}
				else if (politic5.traits[0] == 3)
				{
					politic5.loyality += 100;
				}
			}
			break;
		}
		case 2:
		{
			text = "1981 年6 月27 日 至29 日 ， 中 国 共 产 党 第 十 一 届 中 央 委 员 会 第 六 次 全 体 会 议 在 北 京 隆 重 召 开 ，195 名 中 央 委 员 、114 名 中 央 候 选 人 和53 名 特 邀 人 员 出 席 。 本 次 会 议 决 定 审 议 和 通 过 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 ， 并 在 整 顿 思 想 、 确 保 看 齐 意 识 的 基 础 上 改 选 中 央 主 要 领 导 成 员 。 然 而 ， 我 们 准 备 推 出 的 文 件 却 招 致 了 相 当 争 议 ， 最 终 只 能 让 全 会 以 微 弱 多 数 通 过 ： 《 决 议 》 运 用 马 克 思 主 义 的 辩 证 唯 物 论 和 历 史 唯 物 论 ， 对 建 国 三 十 二 年 来 党 的 重 大 历 史 事 件 特 别 是 “ 文 化 大 革 命 ” 作 出 了 正 确 的 总 结 ， 科 学 地 分 析 了 在 这 些 事 件 中 党 的 “ 军 事 化 ” 、 “ 私 兵 化 ” 、 “ 独 立 王 国 化 ” 等 严 重 问 题 ， 并 分 析 了 产 生 错 误 的 主 观 因 素 和 社 会 原 因 ， 实 事 求 是 地 评 价 了 因 长 期 贯 彻 割 据 路 线 而 不 可 避 免 走 向 军 阀 化 、 山 头 化 的 毛 泽 东 在 中 国 革 命 中 的 历 史 地 位 ， 并 给 予 其 “ 人 造 奶 油 共 产 主 义 者 ” 与 “20 世 纪 版 秦 始 皇 、 李 自 成 与 洪 秀 全 ” 的 公 正 评 价 ， 从 反 面 充 分 论 述 了 应 当 回 归 执 政 为 民 ， 稳 健 行 远 初 心 ， 基 于 执 政 党 与 法 制 化 思 维 确 立 指 导 思 想 的 必 要 性 。 《 决 议 》 肯 定 了 自 毛 泽 东 去 世 后 我 党 新 一 代 领 导 集 体 逐 步 摆 脱 个 人 迷 信 ， 并 逐 渐 确 立 起 适 合 我 国 情 况 的 建 设 现 代 化 政 治 体 系 的 正 确 道 路 ， 进 一 步 指 明 了 我 国 社 会 主 义 事 业 和 党 的 工 作 继 续 前 进 的 方 向 。 全 会 认 为 ， 《 决 议 》 的 通 过 和 发 表 ， 对 于 规 范 全 党 、 全 军 、 全 国 各 族 人 民 的 思 想 认 识 ， 促 使 其 扫 除 个 人 崇 拜 余 毒 与 封 建 思 想 残 余 ， 形 成 法 制 与 规 则 思 维 ， 必 将 产 生 伟 大 的 深 远 的 影 响 。 ";
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.data[3] -= 150;
			GlobalScript.inst.gameState.data[57] -= 200;
			GlobalScript.inst.gameState.data[92] += 40;
			GlobalScript.inst.gameState.data[4] += 250;
			GlobalScript.inst.gameState.data[6] -= 60;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.empires[1].relations += 250;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 30;
			GlobalScript.inst.gameState.influencePRC -= 50;
			party_change[4] = 0.3f;
			Politic[] politics2 = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics2)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 300;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality -= 300;
				}
				else if (politic.traits[0] == 2)
				{
					politic.loyality -= 300;
				}
				else if (politic.traits[0] == 3)
				{
					politic.loyality += 150;
				}
			}
			load_scene_after_click = true;
			break;
		}
		case 3:
			text = "1981 年6 月27 日 至29 日 ， 中 国 共 产 党 第 十 一 届 中 央 委 员 会 第 六 次 全 体 会 议 在 北 京 隆 重 召 开 ，195 名 中 央 委 员 、114 名 中 央 候 选 人 和53 名 特 邀 人 员 出 席 。 本 次 会 议 决 定 审 议 和 通 过 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 ， 并 在 整 顿 思 想 、 确 保 看 齐 意 识 的 基 础 上 改 选 中 央 主 要 领 导 成 员 。 不 过 ， 原 计 划 通 过 的 《 决 议 》 最 终 却 在 会 议 上 难 产 ， 并 被 多 数 代 表 认 为 “ 欠 考 虑 且 大 错 特 错 ” ， 显 然 要 被 送 交 委 员 会 作 重 新 审 定 。";
			if (GlobalScript.inst.gameState.data[56] < 2)
			{
				text += " 也 就 在 委 员 会 的 特 别 过 问 下 ， 《 决 议 》 成 了 中 国 版 本 的 《 论 列 宁 主 义 基 础 》 与 《 联 共 （ 布 ） 党 史 基 本 教 程 》 ： 其 主 要 内 容 则 是 论 述 毛 主 席 领 导 下 的 共 产 党 如 何 客 服 各 种 主 观 主 义 、 机 会 主 义 与 投 降 主 义 思 潮 ， 从 胜 利 走 向 新 胜 利 的 伟 大 征 程 。 而 我 党 目 前 的 任 务 无 非 是 “ 按 既 定 方 针 办 ” ， 将 毛 主 席 的 事 业 发 扬 光 大 。 该 版 本 的 决 议 得 到 了 党 内 多 数 认 可 ， 最 终 得 以 颁 行 。";
				GlobalScript.inst.gameState.data[1] += 20;
				GlobalScript.inst.gameState.data[3] += 50;
				GlobalScript.inst.gameState.data[92] -= 20;
				GlobalScript.inst.gameState.data[4] -= 60;
				GlobalScript.inst.gameState.data[90] = 0;
				GlobalScript.inst.gameState.data[6] += 40;
				party_change[0] = 0.24f;
				party_change[1] = 0.24f;
				Politic[] politics2 = GlobalScript.inst.gameState.politics;
				foreach (Politic politic2 in politics2)
				{
					if (politic2.traits[0] == 0)
					{
						politic2.power += 100;
						politic2.loyality += 150;
					}
					else if (politic2.traits[0] == 1)
					{
						politic2.power -= 50;
						politic2.loyality -= 50;
					}
					else if (politic2.traits[0] == 2)
					{
						politic2.power -= 100;
						politic2.loyality -= 100;
					}
					else if (politic2.traits[0] == 3)
					{
						politic2.power -= 150;
						politic2.loyality -= 200;
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 1)
			{
				text += " 也 就 在 委 员 会 的 特 别 过 问 下 ， 《 决 议 》 将 以 “ 纠 正 一 切 错 误 ， 强 调 一 切 正 确 ” ， “ 胜 者 无 需 被 归 咎 ， 败 者 则 一 无 所 有 ” 与 “ 解 放 思 想 ， 实 事 求 是 ， 团 结 一 致 向 前 看 ” 这 三 项 原 则 为 指 导 重 新 写 史 ： 其 主 要 内 容 则 是 将 作 为 集 体 智 慧 结 晶 与 实 事 求 是 灵 魂 的 “ 活 毛 泽 东 思 想 ” 作 为 决 定 党 执 政 成 败 的 真 正 关 键 。 而 我 党 目 前 的 任 务 无 非 是 基 于 实 用 主 义 与 为 尊 者 讳 的 方 式 革 故 鼎 新 ， 由 此 走 出 自 己 的 路 。 该 版 本 的 决 议 得 到 了 党 内 多 数 认 可 ， 最 终 得 以 颁 行 。";
				GlobalScript.inst.gameState.data[1] += 80;
				GlobalScript.inst.gameState.data[3] += 40;
				GlobalScript.inst.gameState.data[90] = 1;
				GlobalScript.inst.gameState.data[92] += 10;
				GlobalScript.inst.gameState.data[4] -= 50;
				GlobalScript.inst.gameState.data[6] -= 20;
				party_change[2] = 0.15f;
				party_change[3] = 0.21f;
				Politic[] politics2 = GlobalScript.inst.gameState.politics;
				foreach (Politic politic3 in politics2)
				{
					if (politic3.traits[0] == 0)
					{
						politic3.loyality += 100;
					}
					else if (politic3.traits[0] == 1)
					{
						politic3.power += 100;
						politic3.loyality += 100;
					}
					else if (politic3.traits[0] == 2)
					{
						politic3.power += 100;
						politic3.loyality += 100;
					}
					else if (politic3.traits[0] == 3)
					{
						politic3.loyality += 100;
					}
				}
			}
			else
			{
				if (GlobalScript.inst.gameState.data[56] <= 2)
				{
					break;
				}
				text += " 也 就 在 委 员 会 的 特 别 过 问 下 ， 《 决 议 》 决 定 从 被 平 反 老 干 部 的 口 供 、 港 台 出 版 物 的 分 析 与 美 苏 宣 传 机 构 的 材 料 为 蓝 本 为 原 型 呈 现 讲 过 那 段 时 期 的 历 史 ， 力 求 写 出 类 似 赫 鲁 晓 夫 “ 秘 密 报 告 ” 那 般 深 刻 的 文 件 ： 其 主 要 内 容 则 是 彻 底 熄 灭 以 毛 泽 东 思 想 为 代 表 的 一 系 列 激 进 主 义 潮 流 ， 并 要 求 中 国 社 会 走 上 科 学 化 、 制 度 化 与 规 范 化 的 道 路 。 该 版 本 的 决 议 得 到 了 党 内 多 数 认 可 ， 最 终 得 以 颁 行 。";
				GlobalScript.inst.gameState.data[1] -= 100;
				GlobalScript.inst.gameState.data[3] -= 150;
				GlobalScript.inst.gameState.data[90] = 2;
				GlobalScript.inst.gameState.data[57] -= 200;
				GlobalScript.inst.gameState.influencePRC -= 30;
				GlobalScript.inst.gameState.data[92] += 40;
				GlobalScript.inst.gameState.data[4] += 200;
				GlobalScript.inst.gameState.data[6] -= 50;
				party_change[4] = 0.3f;
				Politic[] politics2 = GlobalScript.inst.gameState.politics;
				foreach (Politic politic4 in politics2)
				{
					if (politic4.traits[0] == 0)
					{
						politic4.loyality -= 300;
					}
					else if (politic4.traits[0] == 1)
					{
						politic4.loyality -= 300;
					}
					else if (politic4.traits[0] == 2)
					{
						politic4.loyality -= 300;
					}
					else if (politic4.traits[0] == 3)
					{
						politic4.loyality += 150;
					}
				}
				load_scene_after_click = true;
			}
			break;
		case 4:
		{
			text = "1981 年6 月27 日 至29 日 ， 中 国 共 产 党 第 十 一 届 中 央 委 员 会 第 六 次 全 体 会 议 在 北 京 隆 重 召 开 ，195 名 中 央 委 员 、114 名 中 央 候 选 人 和53 名 特 邀 人 员 出 席 。 本 次 会 议 决 定 审 议 和 通 过 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 ， 并 在 整 顿 思 想 、 确 保 看 齐 意 识 的 基 础 上 改 选 中 央 主 要 领 导 成 员 。 不 过 ， 原 计 划 通 过 的 《 决 议 》 最 终 却 在 会 议 上 难 产 ， 并 被 多 数 代 表 认 为 “ 过 时 而 无 必 要 ” 而 被 归 入 内 参 。 此 后 ， 会 议 则 在 一 片 祥 和 中 胜 利 闭 幕 。";
			GlobalScript.inst.gameState.data[1] -= 70;
			GlobalScript.inst.gameState.data[3] -= 30;
			GlobalScript.inst.gameState.influencePRC -= 20;
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[90] = 3;
			GlobalScript.inst.gameState.data[8] -= 200;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			for (int i = 0; i < politics.Length; i++)
			{
				politics[i].loyality -= 100;
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.number_event = 4;
			SceneManager.LoadScene("Event");
		}
	}
}
