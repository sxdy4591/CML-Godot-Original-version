using EventsForDLC;
using UnityEngine;

public class Event113 : EventsSecond
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
		name = " 南 斯 拉 夫 社 会 主 义 自 治 的 痛 苦";
		text = " 主 席 同 志 ， 南 斯 拉 夫 传 来 了 糟 糕 的 新 闻 。 由 南 斯 拉 夫 主 席 团 前 主 席 谢 尔 盖 · 克 拉 伊 盖 尔 （ 其 本 人 为 斯 洛 文 尼 亚 族 ， 与 “ 社 会 主 义 自 治 政 府 ” 理 论 家 爱 德 华 · 卡 德 尔 关 系 密 切 ） 领 导 的 所 谓 “ 克 拉 伊 盖 尔 委 员 会 ” 向 南 斯 拉 夫 主 席 团 递 交 了 大 规 模 市 场 经 济 改 革 的 建 议 。 南 斯 拉 夫 在 约 瑟 普 · 布 罗 兹 · 铁 托 死 后 陷 入 困 境 ： 科 索 沃 分 离 主 义 者 叛 乱 的 恶 果 仍 未 得 到 处 理 、 以 斯 洛 文 尼 亚 和 克 罗 地 亚 为 中 心 的 不 满 正 在 日 益 增 长 并 且 塞 尔 维 亚 的 民 族 主 义 情 绪 正 在 激 增 。1979 年 的 经 济 危 机 更 是 火 上 浇 油 ， 迫 使 已 经 深 陷 债 务 泥 潭 的 该 国 继 续 贷 款 。 看 起 来 南 斯 拉 夫 正 在 步 入 深 渊 … … 苏 联 和 其 他 社 会 主 义 国 家 准 备 为 南 斯 拉 夫 提 供 大 额 财 政 援 助 以 避 免 其 进 行 市 场 改 革 。 我 们 也 可 以 响 应 苏 联 领 导 人 的 提 议 ， 但 一 些 党 员 建 议 发 动 军 事 政 变 ， 让 希 望 终 结 “ 不 结 盟 运 动 ” 的 将 军 们 上 台 。 另 一 方 面 ， 美 国 也 可 以 为 南 斯 拉 夫 提 供 新 的 贷 款 … … 所 以 我 们 该 作 何 选 择 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 我 们 关 心 南 斯 拉 夫 干 什 么 ？ 铁 托 主 义 者 不 是 喜 欢 自 力 更 生 吗 ？ 那 就 自 己 的 事 情 自 己 做 ！";
		if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[1] = " 我 们 会 为 南 斯 拉 夫 提 供 重 建 债 务 的 计 划 ， 以 阻 止 改 革 计 划 落 地 （ 需 要 5 特 工 网 络 ， 需 要 20 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 我 们 需 要 重 组 他 们 的 债 务 ？";
		}
		if (((GlobalScript.inst.gameState.influencePRC >= 150 && GlobalScript.inst.gameState.allcountries[1].isSEV) || (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.influencePRC >= 250)) && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[2] = " 我 们 加 入 苏 联 的 提 议";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 没 有 足 够 的 影 响 力 让 苏 联 和 南 斯 拉 夫 听 我 们 的";
		}
		if (GlobalScript.inst.gameState.influencePRC >= 300 && GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[3] = " 我 们 将 支 持 由 韦 利 科 · 卡 迪 耶 维 奇 和 布 兰 科 · 马 穆 拉 领 导 的 一 批 军 人";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 支 持 军 政 府 ？ 在 南 斯 拉 夫 ？ 胡 说 八 道 ！";
		}
		if ((GlobalScript.inst.gameState.influencePRC >= 200 || GlobalScript.inst.gameState.allcountries[51].dev > 0) && GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] >= 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[4] = " 我 们 加 入 美 国 的 提 议";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 我 们 没 有 足 够 的 影 响 力 让 美 国 和 南 斯 拉 夫 听 我 们 的";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = (name = " 南 斯 拉 夫 社 会 主 义 自 治 的 痛 苦");
		switch (result_num)
		{
		case 0:
		{
			text = " 接 任 南 斯 拉 夫 主 席 团 主 席 职 务 的 佩 塔 尔 · 斯 坦 鲍 利 奇 （ 塞 尔 维 亚 族 ） 和 米 尔 卡 · 什 皮 利 亚 克 （ 克 罗 地 亚 族 ） 都 不 敢 通 过 克 拉 伊 盖 尔 委 员 会 的 改 革 提 议 。 南 斯 拉 夫 从 国 际 货 币 基 金 组 织 和 苏 联 那 里 获 得 了 新 的 贷 款 ， 这 只 不 过 是 南 斯 拉 夫 经 济 再 痛 苦 一 段 时 间 罢 了 … …";
			int[] data = GlobalScript.inst.gameState.data;
			int num = 86;
			ref int reference = ref data[num];
			int num2 = data[num];
			reference = num2 - 1;
			break;
		}
		case 1:
			text = " 我 们 的 主 席 亲 自 与 佩 塔 尔 · 斯 坦 鲍 利 奇 （ 塞 尔 维 亚 族 ） 和 米 卡 · 什 皮 利 亚 克 （ 克 罗 地 亚 族 ） 通 话 ， 让 他 们 拒 绝 市 场 改 革 ， 从 而 通 过 了 我 们 重 建 南 斯 拉 夫 公 债 的 提 议 。 一 瞬 间 南 斯 拉 夫 人 自 己 都 不 知 道 欠 了 谁 的 债 或 者 欠 了 多 少 债 — — 他 们 的 债 务 数 都 数 不 清 。 我 们 不 得 不 为 南 斯 拉 夫 在 联 合 国 说 情 ， 并 动 用 国 安 部 的 力 量 对 国 际 货 币 基 金 组 织 和IBER 施 压 ， 以 “ 确 定 ” 南 斯 拉 夫 的 债 务 规 模 。 最 终 债 权 人 们 放 出 了 最 终 账 单 — —530 亿 美 元 年 利 率8 ％ ， 并 同 意 抹 去 其 余 部 分 。 我 们 作 为 协 议 的 保 障 者 ， 归 还 了 部 分 债 务 ， 剩 下 的 要 靠 南 斯 拉 夫 自 己 了 。 南 斯 拉 夫 的 领 导 人 对 我 们 将 他 们 从 经 济 崩 溃 中 拯 救 出 来 表 示 了 感 谢 ， 南 斯 拉 夫 已 经 与 我 们 开 展 了 新 的 盈 利 的 贸 易 合 同 ， 并 加 强 了 其 共 和 国 和 我 们 的 自 治 区 间 的 文 化 联 系 。 当 然 ， 拯 救 南 斯 拉 夫 的 财 政 对 我 们 的 经 济 显 然 没 什 么 好 处 … …";
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[8] -= 200;
			GlobalScript.inst.gameState.data[86] += 2;
			if (!GlobalScript.inst.gameState.allcountries[15].Torg)
			{
				GlobalScript.inst.gameState.allcountries[15].Torg = true;
			}
			else
			{
				GlobalScript.inst.gameState.data[9] += 30;
			}
			break;
		case 2:
		{
			text = " 华 沙 条 约 国 家 的 领 导 人 对 “ 克 拉 伊 盖 尔 委 员 会 ” 的 提 案 非 常 警 惕 ， 向 南 斯 拉 夫 提 供 了 巨 额 的 财 政 援 助 以 阻 止 其 施 行 市 场 改 革 。 我 们 也 对 这 一 提 议 表 示 支 持 。 南 斯 拉 夫 领 导 人 担 心 自 己 的 经 济 会 变 得 完 全 依 赖 苏 联 和 中 国 ， 拒 绝 了 帮 助 — — 然 而 “ 克 拉 伊 盖 尔 委 员 会 ” 却 解 散 了 ， 其 部 分 委 员 被 开 除 出 南 斯 拉 夫 共 产 主 义 者 联 盟 ， 谢 尔 盖 · 克 拉 伊 盖 尔 也 被 迫 退 休 。 但 是 在 此 之 后 南 斯 拉 夫 扩 大 了 其 在 经 互 会 内 的 活 动 ， 并 向 组 织 提 交 了 成 为 经 互 会 正 式 成 员 的 申 请 。 与 经 互 会 成 员 国 的 合 作 使 得 南 斯 拉 夫 能 够 复 兴 自 己 的 经 济 ， 但 是 或 早 或 晚 债 务 还 是 要 还 的 … …";
			GlobalScript.inst.gameState.empires[1].relations += 200;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[1] += 50;
			int[] data2 = GlobalScript.inst.gameState.data;
			int num3 = 86;
			ref int reference2 = ref data2[num3];
			int num4 = data2[num3];
			reference2 = num4 + 1;
			GlobalScript.inst.gameState.allcountries[15].isSEV = true;
			if (!GlobalScript.inst.gameState.allcountries[15].Torg)
			{
				GlobalScript.inst.gameState.allcountries[15].Torg = true;
			}
			else
			{
				GlobalScript.inst.gameState.data[9] += 30;
			}
			break;
		}
		case 3:
			if (GlobalScript.inst.gameState.allcountries[15].dev == 1)
			{
				text = " “ 克 拉 伊 盖 尔 委 员 会 ” 的 提 案 以 及 军 费 将 被 首 先 削 减 的 新 闻 ， 在 南 斯 拉 夫 人 民 军 将 领 内 引 起 了 强 烈 的 不 满 。 我 们 决 定 利 用 这 一 机 会 支 持 不 满 者 ， 将 他 们 推 上 公 开 舞 台 。 3 月 1 日 ， 南 斯 拉 夫 人 民 军 第 2 5 2 装 甲 旅 、 第 1 无 产 阶 级 机 械 化 师 和 第 4 5 3 机 械 化 旅 发 起 兵 变 ， 迅 速 占 领 了 贝 尔 格 莱 德 。 人 民 军 的 反 情 报 部 门 迅 速 监 禁 了 南 斯 拉 夫 政 府 和 共 产 主 义 者 联 盟 的 所 有 地 区 领 导 人 。 “ 保 卫 南 斯 拉 夫 人 民 军 事 委 员 会 ” 现 在 掌 握 了 权 力 ， 领 导 者 是 韦 利 科 · 卡 迪 耶 维 奇 将 军 （ 克 罗 地 亚 塞 族 南 斯 拉 夫 人 ） 和 海 军 司 令 布 兰 科 · 马 穆 拉 （ 支 持 南 斯 拉 夫 统 一 的 斯 洛 文 尼 亚 族 ） ， 他 们 宣 称 “ 忠 于 马 克 思 、 恩 格 斯 、 列 宁 和 铁 托 同 志 的 事 业 ” ， 并 “ 与 叛 徒 坚 决 对 抗 到 底 ， 保 护 南 斯 拉 夫 各 民 族 的 友 谊 和 团 结 ” 。||不 久 ， 新 的 南 斯 拉 夫 共 产 主 义 者 联 盟 大 会 召 开 ， 在 大 会 上 通 过 了 《 建 国 以 来 历 史 问 题 决 议 》 问 题 ， 平 反 了 “ 弗 拉 多 ” · 达 普 切 维 奇 与 安 德 烈 · 赫 尔 布 兰 格 为 首 的 反 修 正 主 义 者 ， 在 大 会 一 致 同 意 下 选 举 前 国 安 局 成 员 ， 来 自 波 黑 的 保 守 派 外 交 官 拉 伊 夫 · 迪 兹 达 雷 维 奇 为 总 书 记 。 新 领 导 层 决 定 在 全 国 范 围 内 对 腐 败 官 员 、 民 族 主 义 者 、 自 由 派 和 新 资 产 阶 级 进 行 清 洗 ， 并 改 组 各 地 企 业 ， 实 施 再 集 体 化 ， 重 建 中 央 集 权 制 度 和 中 央 计 划 经 济 ， 以 及 撤 销 了 共 产 主 义 者 联 盟 各 支 部 的 自 治 权 。 南 斯 拉 夫 宣 布 终 止 “ 不 结 盟 ” 政 策 ， 并 倒 向 由 “ 苏 联 和 中 国 平 等 领 导 ” 的 社 会 主 义 阵 营 ， 同 时 也 拒 绝 归 还 任 何 债 务 。 美 国 威 胁 事 情 不 会 这 样 简 单 过 去 的 … …";
				GlobalScript.inst.gameState.data[9] -= 50;
				GlobalScript.inst.gameState.influencePRC += 20;
				GlobalScript.inst.gameState.data[1] += 50;
				GlobalScript.inst.gameState.data[6] += 30;
				GlobalScript.inst.gameState.empires[1].power += 20;
				GlobalScript.inst.gameState.empires[0].power -= 30;
				GlobalScript.inst.gameState.empires[0].relations -= 250;
				GlobalScript.inst.gameState.empires[1].relations += 200;
				GlobalScript.inst.gameState.data[86] += 2;
				if (!GlobalScript.inst.gameState.allcountries[15].Torg)
				{
					GlobalScript.inst.gameState.allcountries[15].Torg = true;
				}
				else
				{
					GlobalScript.inst.gameState.data[9] += 30;
				}
				GlobalScript.inst.gameState.allcountries[15].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[15].SubGosstroy = 0;
			}
			else
			{
				text = " “ 克 拉 伊 盖 尔 委 员 会 ” 的 提 案 以 及 军 费 将 被 首 先 削 减 的 新 闻 ， 在 南 斯 拉 夫 人 民 军 将 领 内 引 起 了 强 烈 的 不 满 。 我 们 决 定 利 用 这 一 机 会 支 持 不 满 者 ， 将 他 们 推 上 公 开 舞 台 。 3 月 1 日 ， 南 斯 拉 夫 人 民 军 第 2 5 2 装 甲 旅 、 第 1 无 产 阶 级 机 械 化 师 和 第 4 5 3 机 械 化 旅 发 起 兵 变 ， 迅 速 占 领 了 贝 尔 格 莱 德 。 政 变 的 领 导 者 是 韦 利 科 · 卡 迪 耶 维 奇 将 军 和 海 军 司 令 布 兰 科 · 马 穆 拉 ， 他 们 宣 称 “ 忠 于 马 克 思 、 恩 格 斯 、 列 宁 和 铁 托 同 志 的 事 业 ” ， 并 “ 与 叛 徒 坚 决 对 抗 到 底 ， 保 护 南 斯 拉 夫 各 民 族 的 友 谊 和 团 结 ” 。||然 而 ， 政 变 在 短 暂 的 两 天 后 遭 到 了 以 塞 尔 维 亚 民 族 主 义 者 拉 特 科 · 姆 拉 迪 奇 为 首 的 地 区 防 卫 军 的 青 年 军 官 的 反 政 变 — — 贝 尔 格 莱 德 的 地 区 防 卫 军 在 贝 尔 格 莱 德 市 长 米 洛 舍 维 奇 鼓 动 市 民 对 “ 反 南 斯 拉 夫 行 为 ” 示 威 转 移 注 意 力 的 情 况 下 的 配 合 下 迅 速 集 结 ， 逮 捕 了 军 政 府 领 导 人 ， 以 莫 须 有 的 罪 名 指 控 新 的 军 政 府 意 图 将 国 家 出 卖 给 阿 尔 巴 尼 亚 。 现 在 ， 取 代 被 解 散 的 南 斯 拉 夫 共 产 主 义 者 联 盟 的 是 “ 南 斯 拉 夫 革 命 救 国 运 动 ” ， 该 组 织 完 全 由 军 队 掌 控 。 该 组 织 掌 握 全 国 后 ， 便 宣 布 拒 绝 偿 还 任 何 债 务 ， 发 动 “ 反 官 僚 主 义 文 化 革 命 ” ， 鼓 动 不 满 者 ， 特 别 是 塞 族 青 年 夺 取 各 地 政 府 机 关 。 南 斯 拉 夫 依 然 宣 布 “ 不 结 盟 ” 政 策 ， 但 言 论 转 向 了 强 烈 的 反 西 方 外 交 路 线 ， 驱 逐 了 欧 共 体 与 美 国 的 外 交 官 ， 宣 布 支 持 “ 不 结 盟 世 界 对 帝 国 主 义 的 正 义 斗 争 ” 。 美 国 威 胁 事 情 不 会 这 样 简 单 过 去 的 。 同 时 在 塞 尔 维 亚 和 黑 山 以 外 的 全 国 ， 分 离 主 义 情 绪 极 度 增 强 了 … …";
				GlobalScript.inst.gameState.data[9] -= 50;
				GlobalScript.inst.gameState.influencePRC += 20;
				GlobalScript.inst.gameState.data[1] += 50;
				GlobalScript.inst.gameState.data[6] += 30;
				GlobalScript.inst.gameState.empires[1].power += 20;
				GlobalScript.inst.gameState.empires[0].power -= 30;
				GlobalScript.inst.gameState.empires[0].relations -= 250;
				GlobalScript.inst.gameState.empires[1].relations += 200;
				GlobalScript.inst.gameState.data[86] += 2;
				if (!GlobalScript.inst.gameState.allcountries[15].Torg)
				{
					GlobalScript.inst.gameState.allcountries[15].Torg = true;
				}
				else
				{
					GlobalScript.inst.gameState.data[9] += 30;
				}
				GlobalScript.inst.gameState.allcountries[15].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[15].SubGosstroy = 10;
			}
			break;
		case 4:
			text = " 美 国 一 得 知 委 员 会 的 提 案 ， 南 斯 拉 夫 就 收 到 了 向 其 提 供 优 惠 贷 款 的 提 议 — — 前 提 是 南 斯 拉 夫 接 受 市 场 改 革 方 案 。 在 我 们 为 克 拉 伊 盖 尔 提 供 支 持 并 通 过 非 正 式 渠 道 对 南 斯 拉 夫 领 导 人 做 出 建 议 后 ， 他 们 同 意 了 — — 佩 塔 尔 · 斯 坦 鲍 利 奇 （ 塞 尔 维 亚 族 ） 提 早 辞 去 主 席 团 主 席 一 职 ， 并 且 米 卡 · 普 拉 宁 茨 （ 克 罗 地 亚 族 ） 也 辞 去 了 执 行 委 员 会 主 席 的 职 务 。 支 持 改 革 的 米 尔 卡 · 什 皮 利 亚 克 和 安 特 · 马 尔 科 维 奇 （ 均 为 克 族 ） 接 任 空 位 ， 开 始 实 施 委 员 会 的 改 革 计 划 。 国 有 财 产 的 私 有 化 开 始 了 ， 合 作 社 彻 底 取 消 了 ， 农 场 得 到 许 可 ， 自 由 经 济 区 也 在 杜 布 罗 夫 尼 克 和 斯 普 利 特 设 立 起 来 。 当 然 ， 联 邦 财 政 的 清 算 在 落 后 共 和 国 和 自 治 区 造 成 了 严 重 不 满 ， 人 民 军 将 领 对 军 费 大 幅 削 减 十 分 愤 怒 ， 斯 洛 文 尼 亚 和 克 罗 地 亚 向 完 全 成 本 核 算 的 转 型 也 引 起 了 民 族 主 义 和 分 离 主 义 的 迅 速 抬 头 … …";
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.empires[0].relations += 200;
			GlobalScript.inst.gameState.empires[1].relations -= 250;
			GlobalScript.inst.gameState.data[86] -= 3;
			GlobalScript.inst.gameState.allcountries[15].Vyshi = true;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
