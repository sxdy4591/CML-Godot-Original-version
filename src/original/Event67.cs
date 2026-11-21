using EventsForDLC;
using UnityEngine;

public class Event67 : EventsSecond
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
		name = " 波 兰 尚 未 灭 亡 ？";
		text = string.Concat(new string[4]
		{
			GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
			" ",
			GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
			"  同 志 ， 波 兰 人 民 共 和 国 现 在 已 经 陷 入 了 严 重 的 政 治 和 经 济 危 机 ， 波 兰 的 修 正 主 义 政 策 迎 来 了 属 于 他 的 恶 果 。 对 外 开 放 、 私 有 化 和 市 场 化 改 革 的 政 策 滋 生 的 大 量 的 小 资 产 阶 级 对 统 工 党 政 权 产 生 着 异 议 ， 盖 莱 克 政 府 不 得 不 通 过 “ 高 速 度 、 高 积 累 、 高 消 费 ” 的 “ 三 高 政 策 ” 发 展 所 谓 的 “ 消 费 社 会 主 义 ” ， 通 过 大 量 举 借 外 债 来 推 动 波 兰 经 济 高 速 发 展 ， 并 利 用 财 政 补 贴 商 品 以 维 持 较 低 的 价 格 ， 以 维 持 政 权 的 稳 定 。 如 今 ， 波 兰 经 济 的 高 速 增 长 已 经 无 力 维 持 ， 近 乎 停 滞 ， 政 府 已 经 积 累 了 巨 额 国 债 （ 近 4 0 0 亿 美 元 ） ， 不 堪 重 负 的 波 兰 政 府 决 定 采 取 冻 结 工 资 和 部 分 商 品 提 价 的 措 施 以 避 免 危 机 ， 不 满 的 波 兰 民 众 迅 速 发 起 了 全 国 大 罢 工 ， 不 久 后 罢 工 的 工 人 组 成 了 全 国 性 的 反 对 派 组 织 和 独 立 自 治 工 会 “ 团 结 工 会 ” （ 中 情 局 为 他 们 提 供 了 支 持 ） ， 对 统 工 党 政 府 提 出 了 一 系 列 经 济 和 政 治 要 求 。 9 月 6 日 ， 波 兰 统 一 工 人 党 中 央 委 员 会 第 六 届 全 体 会 议 召 开 ， 决 定 解 除 领 导 国 家 和 党 1 0 年 的 爱 德 华 · 盖 莱 克 的 职 务 ， 并 以 统 工 党 中 间 派 斯 坦 尼 斯 瓦 夫 · 卡 尼 亚 取 代 他 。 卡 尼 亚 选 择 对 团 结 工 会 采 取 妥 协 态 度 。|“ 团 结 工 会 ” 并 非 团 结 在 一 个 意 识 形 态 之 下 — — 它 是 一 个 反 统 工 党 政 权 的 大 帐 篷 ， 其 左 翼 主 要 由 工 团 主 义 者 、 民 主 社 会 主 义 者 和 基 督 教 左 翼 组 成 ， 反 对 统 工 党 官 僚 的 统 治 ， 希 望 构 建 “ 民 主 的 ” 社 会 主 义 ； 其 右 翼 由 自 由 主 义 者 、 保 守 主 义 者 和 基 督 教 教 士 组 成 ， 希 望 开 展 自 由 化 。|统 一 工 人 党 内 部 也 不 是 铁 板 一 块 ， 其 主 要 分 为 左 、 中 、 右 三 派 ， 其 左 派 “ 党 之 基 石 ” 派 主 要 由 亲 苏 强 硬 派 、 斯 大 林 主 义 者 和 民 族 共 产 主 义 者 组 成 ， 由 以 塔 德 乌 什 · 格 拉 布 斯 基 、 斯 特 凡 · 奥 尔 绍 夫 斯 基 、 安 杰 伊 · 扎 宾 斯 基 和 兹 基 斯 瓦 夫 · 库 洛 夫 斯 基 为 首 的 “ 四 人 帮 ” 领 导 ， 他 们 希 望 镇 压 团 结 工 会 ， 清 除 官 僚 机 构 的 腐 败 ， 并 让 波 兰 回 归 正 统 的 马 列 模 式 ， 他 们 掌 握 了 一 众 附 属 团 体 ， 与 团 结 工 会 和 统 工 党 右 派 开 展 论 战 ； 中 间 派 的 代 表 是 斯 坦 尼 斯 瓦 夫 · 卡 尼 亚 和 国 防 部 长 沃 伊 切 赫 · 雅 鲁 泽 尔 斯 基 ； 其 右 派 为 米 奇 斯 瓦 夫 · 拉 科 夫 斯 基 的 改 革 派 和 兹 比 格 涅 夫 · 伊 万 诺 夫 领 导 的 “ 平 行 结 构 ” （ 指 同 时 具 有 统 工 党 党 籍 和 团 结 工 会 会 员 的 平 行 身 份 ） 派 ， 希 望 与 团 结 工 会 合 作 开 展 变 革 。|在 苏 东 阵 营 内 部 ， 保 守 派 的 勃 列 日 涅 夫 、 昂 纳 克 和 胡 萨 克 都 希 望 以 1 9 6 8 年 的 捷 克 斯 洛 伐 克 为 先 例 ， 发 挥 社 会 主 义 大 家 庭 的 精 神 ， 联 合 镇 压 反 对 派 并 支 持 “ 四 人 帮 ” ； 而 安 德 罗 波 夫 、 苏 斯 洛 夫 和 齐 奥 塞 斯 库 则 反 对 采 取 军 事 行 动 。|在 局 势 如 此 不 稳 定 和 各 派 分 裂 的 情 况 下 ， 我 们 有 很 大 的 机 会 进 行 干 预 。 请 做 出 我 们 的 选 择 吧 ！"
		});
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 6;
		button_text[0] = " 波 兰 的 事 务 与 中 国 无 关 。 他 们 自 己 做 的 事 情 自 己 解 决 ！";
		button_text[1] = " 针 对 波 兰 的 局 势 发 表 我 们 的 声 明";
		if (GlobalScript.inst.gameState.relres)
		{
			button_text[2] = " 激 化 局 势 ， “ 帮 助 ” 统 工 党 强 硬 派 做 出 正 确 决 定（ 需 要5 特 工 ， 需 要20 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 还 未 恢 复 《 中 苏 友 好 同 盟 互 助 条 约 》 ...";
		}
		if (GlobalScript.inst.gameState.allcountries[20].proprc && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[3] = " 组 建 囊 括 米 雅 尔 的 反 修 派 波 兰 共 产 党 、 统 工 党 “ 党 之 基 石 ” 派 的 民 族 共 产 主 义 者 和 斯 大 林 主 义 者 以 及 “ P A X 协 会 ” （ 圣 像 派 ） 等 左 翼 势 力 的 大 联 盟 ！ （ 需 要15 特 工 网 络 与30 百 万 元 预 算 ） ";
		}
		else if (!GlobalScript.inst.gameState.allcountries[20].proprc)
		{
			Object.Destroy(button[3]);
			button_text[3] = " 可 米 雅 尔 已 经 离 开 了 阿 尔 巴 尼 亚 ...";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 党 内 的 改 革 派 与 自 由 派 对 他 们 没 兴 趣 ...";
		}
		if (GlobalScript.inst.gameState.empires[1].relations >= 600 && GlobalScript.inst.gameState.allcountries[1].isOVD)
		{
			button_text[4] = " |鼓 动 华 约 开 展 “ 兄 弟 般 ” 的 干 预 （ 需 要5 特 工 网 络 ，5 军 事 实 力 ）";
		}
		else if (!GlobalScript.inst.gameState.allcountries[1].isOVD)
		{
			Object.Destroy(button[4]);
			button_text[4] = " |我 们 得 是 华 约 的 一 员 ...";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " |与 苏 联 的 关 系 应 高 于 60...";
		}
		if (GlobalScript.inst.gameState.empires[0].relations >= 600 && GlobalScript.inst.gameState.allcountries[51].Torg)
		{
			button_text[5] = " 让 我 们 支 持 团 结 工 会 和 统 工 党 右 派 的 合 作 ， 以 开 展 改 革 （ 需 要10 百 万 元 预 算 ，20 特 工 网 络 ）";
		}
		else if (!GlobalScript.inst.gameState.allcountries[51].Torg)
		{
			Object.Destroy(button[5]);
			button_text[5] = " 我 们 得 交 好 美 国 ...";
		}
		else
		{
			Object.Destroy(button[5]);
			button_text[5] = " 与 美 国 的 关 系 应 高 于 60...";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 波 兰 尚 未 灭 亡 ？";
		switch (result_num)
		{
		case 0:
			text = " 我 们 未 对 波 兰 局 势 作 出 任 何 评 论 。 在 这 种 局 面 下 ， 波 兰 军 队 承 担 起 了 国 家 命 运 的 责 任 。 在 得 到 苏 联 支 持 和 不 会 军 事 干 预 的 保 证 后 ， 国 防 部 长 沃 伊 切 赫 · 雅 鲁 泽 尔 斯 基 创 立 了 包 含 统 工 党 三 派 的 救 国 军 事 委 员 会 ， 并 在 1 9 8 1 年 1 2 月 1 3 日 ， 宣 布 在 波 兰 全 境 实 行 战 时 状 态 。 波 兰 人 民 军 、 安 全 委 员 会 和 Z O M O （ 摩 托 化 预 备 役 部 队 ， 波 兰 民 事 警 察 部 门 的 特 种 单 位 ） 的 决 定 性 行 动 ， 终 止 了 团 结 工 会 和 波 兰 统 一 工 人 党 的 活 动 ， 波 兰 国 内 秩 序 多 少 重 建 了 起 来 。 雅 鲁 泽 尔 斯 基 宣 布 了 “ 社 会 主 义 革 新 路 线 ” ， 但 实 质 的 问 题 并 没 有 解 决 ， 这 早 晚 会 找 上 门 来 的 … …";
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 10;
			GlobalScript.inst.gameState.allcountries[2].Torg = true;
			break;
		case 1:
			if (GlobalScript.inst.gameState.data[56] <= 1)
			{
				GlobalScript.inst.gameState.data[6] += 50;
				if (!GlobalScript.inst.gameState.relres)
				{
					text = " 中 国 外 交 部 发 言 人 发 表 声 明 ： “ 中 国 人 民 始 终 支 持 波 兰 人 民 抗 击 波 兰 修 正 主 义 和 苏 联 社 会 帝 国 主 义 的 正 义 斗 争 ！ 波 兰 人 民 应 该 团 结 在 波 兰 无 产 阶 级 的 真 正 核 心 — — 波 兰 共 产 党 周 围 ， 重 拾 斯 大 林 和 贝 鲁 特 的 遗 产 ， 建 立 真 正 革 命 的 社 会 主 义 制 度 ！ ”";
					GlobalScript.inst.gameState.empires[1].relations -= 50;
				}
				else
				{
					text = " 中 国 外 交 部 发 言 人 发 表 声 明 ： “ 中 国 人 民 始 终 支 持 波 兰 人 民 抗 击 波 兰 修 正 主 义 的 正 义 斗 争 ！ 波 兰 人 民 应 该 团 结 在 波 兰 无 产 阶 级 的 真 正 核 心 — — 波 兰 统 工 党 的 健 康 力 量 （ 指 “ 党 之 基 石 ” 派 ） 和 波 兰 共 产 党 周 围 ， 重 拾 斯 大 林 和 贝 鲁 特 的 遗 产 ， 建 立 真 正 的 社 会 主 义 制 度 ！ ”";
				}
			}
			else if (GlobalScript.inst.gameState.data[56] == 2)
			{
				text = " 中 国 外 交 部 发 言 人 发 表 声 明 ： “ 波 兰 各 方 应 该 保 持 对 话 ， 减 少 冲 突 ， 在 妥 协 中 求 进 ， 共 建 适 宜 于 波 兰 民 族 自 身 发 展 道 路 的 社 会 主 义 。 ”";
				GlobalScript.inst.gameState.data[6] -= 50;
			}
			else if (GlobalScript.inst.gameState.data[56] == 3)
			{
				text = " 中 国 外 交 部 发 言 人 发 表 声 明 ： “ 苏 联 不 应 该 在 东 欧 施 展 霸 权 主 义 ， 东 欧 人 民 有 选 择 自 己 社 会 主 义 发 展 道 路 的 权 利 。 ”";
				GlobalScript.inst.gameState.empires[0].relations += 50;
				GlobalScript.inst.gameState.empires[1].relations -= 50;
				GlobalScript.inst.gameState.data[6] += 50;
			}
			else if (GlobalScript.inst.gameState.data[56] == 4)
			{
				text = " 中 国 外 交 部 发 言 人 发 表 声 明 ： “ 中 国 政 府 始 终 支 持 波 兰 人 民 反 对 极 权 主 义 和 专 制 独 裁 的 斗 争 ， 让 我 们 和 自 由 和 文 明 的 世 界 中 心 — — 美 国 联 合 起 来 ， 打 倒 邪 恶 帝 国 伸 向 世 界 的 触 手 ， 以 波 兰 为 起 点 ， 把 东 欧 从 苏 联 奴 役 中 解 放 出 来 ！ ”";
				GlobalScript.inst.gameState.empires[0].relations += 150;
				GlobalScript.inst.gameState.empires[1].relations -= 150;
				GlobalScript.inst.gameState.data[6] -= 50;
			}
			text += "||在 这 种 局 面 下 ， 波 兰 军 队 承 担 起 了 国 家 命 运 的 责 任 。 在 得 到 苏 联 支 持 和 不 会 军 事 干 预 的 保 证 后 ， 国 防 部 长 沃 伊 切 赫 · 雅 鲁 泽 尔 斯 基 创 立 了 包 含 统 工 党 三 派 的 救 国 军 事 委 员 会 ， 并 在 1 9 8 1 年 1 2 月 1 3 日 ， 宣 布 在 波 兰 全 境 实 行 战 时 状 态 。 波 兰 人 民 军 、 安 全 委 员 会 和 Z O M O （ 摩 托 化 预 备 役 部 队 ， 波 兰 民 事 警 察 部 门 的 特 种 单 位 ） 的 决 定 性 行 动 ， 终 止 了 团 结 工 会 和 波 兰 统 一 工 人 党 的 活 动 ， 波 兰 国 内 秩 序 多 少 重 建 了 起 来 。 雅 鲁 泽 尔 斯 基 宣 布 了 “ 社 会 主 义 革 新 路 线 ” ， 但 实 质 的 问 题 并 没 有 解 决 ， 这 早 晚 会 找 上 门 来 的 … …";
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 10;
			GlobalScript.inst.gameState.allcountries[2].Torg = true;
			break;
		case 2:
			text = " 我 们 放 出 了 波 兰 国 防 部 方 面 想 要 邀 请 华 约 采 取 行 动 的 谣 言 ， 这 在 反 对 派 内 部 掀 起 了 轩 然 大 波 。 在 一 个 月 黑 风 高 的 夜 晚 ， 波 兰 国 防 部 长 雅 鲁 泽 尔 斯 基 大 将 在 下 班 的 路 上 被 预 先 埋 设 的 炸 药 炸 死 ， 据 调 查 ， 这 是 由 团 结 工 会 的 激 进 派 代 表 特 奥 多 尔 · 克 林 采 维 奇 策 划 的 ， 目 的 是 为 了 “ 阻 止 该 死 的 民 族 败 类 将 祖 国 交 给 俄 国 人 … … ”||雅 鲁 泽 尔 斯 基 的 死 成 功 坚 定 了 统 工 党 “ 党 之 基 石 ” 派 采 取 严 厉 行 动 的 决 心 ， 统 工 党 认 为 事 情 已 经 到 达 了 严 峻 的 地 步 。 亲 苏 强 硬 派 将 军 尤 金 纽 什 · 莫 尔 奇 克 、 约 瑟 夫 · 巴 里 拉 和 沃 齐 米 日 · 萨 夫 丘 克 牵 头 组 织 了 “ 军 事 革 命 委 员 会 ” ， 以 格 拉 布 斯 基 为 首 的 “ 党 之 基 石 ” 的 亲 苏 强 硬 派 成 员 也 大 量 加 入 了 新 的 领 导 机 构 。 莫 尔 奇 克 将 军 宣 布 在 波 兰 全 境 实 行 战 时 状 态 。 波 兰 人 民 军 、 安 全 委 员 会 和 Z O M O （ 摩 托 化 预 备 役 部 队 ， 波 兰 民 事 警 察 部 门 的 特 种 单 位 ） 的 决 定 性 行 动 ， 终 止 了 团 结 工 会 和 波 兰 统 一 工 人 党 的 活 动 ， 波 兰 国 内 秩 序 多 少 重 建 了 起 来 。 国 家 的 全 部 权 力 都 交 予 军 事 革 命 委 员 会 ， 这 马 上 引 起 了 关 于 “ 建 立 军 事 独 裁 ” 的 指 责 ， 美 国 已 经 开 始 呼 吁 反 对 “ 莫 尔 奇 克 的 极 权 军 政 府 ” 。 我 国 和 苏 联 对 波 兰 发 放 了 大 额 无 息 贷 款 以 偿 还 其 国 家 债 务 ， 而 波 兰 则 与 我 们 签 订 了 几 项 合 作 协 定 。 波 兰 的 新 领 导 层 开 始 重 构 波 兰 的 政 治 经 济 制 度 ， 以 “ 回 归 马 列 主 义 秩 序 ” ， 看 起 来 局 势 正 在 恢 复 ， 波 兰 的 例 子 也 教 会 了 我 们 党 一 些 事 情 … …";
			GlobalScript.inst.gameState.data[1] += 200;
			GlobalScript.inst.gameState.empires[1].power -= 10;
			GlobalScript.inst.gameState.data[8] -= 200;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[4] -= 10;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 1;
			GlobalScript.inst.gameState.empires[1].relations += 150;
			GlobalScript.inst.gameState.allcountries[2].Torg = true;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 16;
			break;
		case 3:
			text = " 在 我 国 驻 波 兰 大 使 馆 的 支 持 下 ， 通 过 卡 齐 米 日 · 米 雅 尔 领 导 的 地 下 活 动 的 波 兰 共 产 党 ， 国 安 部 特 工 联 系 到 不 久 前 在 统 工 党 大 会 上 提 议 解 除 盖 莱 克 职 位 并 已 恢 复 政 治 局 委 员 身 份 的 前 “ 游 击 队 ” 派 领 导 人 、 现 “ 党 之 基 石 ” 派 民 族 共 产 主 义 者 的 代 表 — — 米 奇 斯 瓦 夫 · 莫 查 ， 在 我 们 的 说 服 下 ， 他 决 定 一 雪 前 耻 （ 他 曾 与 盖 莱 克 竞 争 领 导 人 位 置 ） ， 并 结 束 波 兰 的 混 乱 局 面 。 他 设 法 争 取 到 了 大 部 分 “ 党 之 基 石 ” 团 体 （ 如 斯 大 林 主 义 的 卡 托 维 兹 党 论 坛 、 民 族 共 产 主 义 的 “ 格 伦 瓦 尔 德 ” 爱 国 联 盟 等 ） 和 亲 共 产 主 义 的 民 族 天 主 教 团 体 P A X 协 会 的 支 持 ， 并 与 团 结 工 会 的 温 和 派 （ 以 雅 罗 斯 瓦 夫 · 西 恩 凯 维 奇 为 代 表 ） 、 志 愿 预 备 役 民 兵 （ O R M O ） 联 合 ， 组 建 了 广 泛 的 联 盟 ， 同 时 得 到 了 与 莫 查 有 联 系 的 “ 党 之 基 石 ” 派 成 员 米 罗 斯 瓦 夫 · 米 列 夫 斯 基 的 秘 密 支 持 ， 他 领 导 的 内 政 部 所 控 制 的 Z O M O （ 摩 托 化 预 备 役 部 队 ， 波 兰 民 事 警 察 部 门 的 特 种 单 位 ） 将 为 莫 查 提 供 帮 助 。 1 2 月 2 日 ， 在 统 工 党 中 央 委 员 会 和 波 兰 国 务 委 员 会 的 联 合 会 议 上 ， 莫 查 对 波 兰 现 领 导 人 斯 坦 尼 斯 瓦 夫 · 卡 尼 亚 展 开 了 突 然 袭 击 ， 他 指 责 卡 尼 亚 对 反 革 命 分 子 优 柔 寡 断 ， 不 断 让 步 ， 且 未 能 良 好 处 理 波 兰 的 危 机 ， 应 该 为 波 兰 仍 未 好 转 的 局 势 负 责 并 辞 职 谢 罪 。 经 由 我 们 的 特 工 提 前 打 点 过 的 统 工 党 中 央 委 员 会 和 国 务 委 员 会 以 多 数 票 支 持 了 他 的 发 言 ， 卡 尼 亚 不 得 不 引 咎 辞 职 ， 莫 查 被 选 为 新 的 波 兰 领 导 人 。 紧 接 着 ， 莫 查 同 志 就 要 求 马 上 召 开 色 姆 会 议 ， 并 在 全 国 范 围 内 宣 布 戒 严 。 统 工 党 右 派 试 图 抵 抗 ， 但 随 后 O R M O 战 士 闯 入 会 议 室 ， 逮 捕 了 所 有 这 一 决 定 的 反 对 者 ， 莫 查 称 “ 将 对 暗 藏 在 党 内 的 反 革 命 进 行 隔 离 审 查 ” 。|两 个 月 来 ， 波 兰 事 实 上 在 进 行 小 型 内 战 ， 但 安 全 部 门 和 部 分 军 队 成 员 支 持 政 变 ， 因 此 联 盟 得 以 胜 利 。 最 后 ， 波 兰 领 导 层 进 行 了 新 一 轮 改 组 ， 成 立 了 由 统 工 党 “ 党 之 基 石 ” 派 的 斯 大 林 主 义 者 和 民 族 共 产 主 义 者 、 波 兰 共 产 党 和 团 结 工 会 温 和 派 组 成 的 波 兰 工 人 党 ， 团 结 工 会 基 本 被 摧 毁 ， 其 左 翼 成 员 则 类 似 统 一 农 民 党 和 民 主 党 ， 能 够 合 法 参 与 政 治 和 提 名 独 立 候 选 人 。 波 兰 新 领 导 层 宣 布 将 进 行 “ 再 社 会 主 义 化 ” ， 并 与 我 们 靠 近 ， 但 同 时 ， 莫 查 表 示 “ 波 兰 将 继 续 基 于 睦 邻 和 合 作 的 路 线 发 展 苏 波 关 系 ” 苏 联 并 未 表 示 有 太 大 不 满 ， 实 际 上 承 认 了 变 化 。 新 的 波 兰 将 重 新 开 展 农 业 集 体 化 ， 重 设 人 民 军 政 委 制 度 、 取 消 随 军 牧 师 ， 并 参 考 “ 鞍 钢 宪 法 ” 的 “ 三 结 合 ” 对 国 营 企 业 进 行 民 主 化 改 造 。 莫 查 谴 责 梵 蒂 冈 “ 干 预 主 权 国 家 的 内 政 ” ， 被 清 洗 后 由 P A X 协 会 主 导 的 波 兰 教 会 宣 布 与 梵 蒂 冈 断 绝 关 系 。 西 方 谴 责 波 兰 的 变 化 ， 称 “ 这 是 血 腥 的 斯 大 林 主 义 在 波 兰 的 回 归 ” 。 ";
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.empires[1].power -= 30;
			GlobalScript.inst.gameState.data[8] -= 300;
			GlobalScript.inst.gameState.data[9] -= 150;
			GlobalScript.inst.gameState.influencePRC += 30;
			GlobalScript.inst.gameState.data[6] += 100;
			GlobalScript.inst.gameState.empires[0].power -= 20;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 0;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[2].prosov = false;
			GlobalScript.inst.gameState.allcountries[2].Torg = true;
			GlobalScript.inst.gameState.allcountries[2].proprc = true;
			break;
		case 4:
			text = " 盖 莱 克 辞 职 和 软 弱 妥 协 的 卡 尼 亚 的 就 职 给 您 留 下 了 非 常 消 极 的 印 象 。 2 3 时 ， 您 亲 自 召 见 了 苏 联 大 使 ， 并 要 求 其 亲 自 向 列 昂 尼 德 · 伊 里 奇 · 勃 列 日 涅 夫 同 志 递 交 中 方 的 如 下 照 会 ： “ 如 果 再 不 采 取 措 施 扭 转 局 面 ， 社 会 主 义 波 兰 将 遭 遇 严 重 威 胁 。 因 此 ， 中 国 共 产 党 与 各 盟 国 的 兄 弟 政 党 ， 乃 至 所 有 的 社 会 主 义 国 家 。 都 不 能 对 此 视 而 不 见 。 波 兰 事 件 绝 不 能 简 单 的 看 作 是 某 国 内 政 问 题 。 今 晚 ， 我 们 将 紧 急 呼 吁 华 约 各 国 的 所 有 领 导 人 ， 一 致 对 波 兰 采 取 有 力 的 联 合 军 事 行 动 ， 从 而 挽 救 波 兰 ， 挽 救 波 兰 社 会 主 义 。 中 华 人 民 共 和 国 与 中 国 共 产 党 的 领 导 层 坚 信 。 必 须 为 社 会 主 义 的 大 步 前 进 而 消 灭 帝 国 主 义 ， 而 波 兰 依 然 有 机 会 回 到 正 道 。 ”";
			if (GlobalScript.inst.gameState.empires[1].relations >= 800)
			{
				text = " 我 们 的 呼 吁 得 到 了 勃 列 日 涅 夫 、 昂 纳 克 和 胡 萨 克 等 苏 东 保 守 派 领 导 人 的 支 持 。 苏 联 方 面 迅 速 制 定 了 代 号 为 “ 西 方 - 8 0 ” 的 “ 军 事 演 习 ” 计 划 。 该 计 划 由 苏 军 总 参 谋 长 奥 加 尔 科 夫 元 帅 转 交 给 波 兰 副 总 参 谋 长 赫 帕 洛 夫 斯 基 。 按 照 该 计 划 ， 苏 联 、 东 德 和 捷 克 斯 洛 伐 克 的 部 队 将 进 驻 波 兰 领 土 ， 与 此 同 时 ， 波 兰 军 队 则 留 在 兵 营 里 。 入 侵 部 队 由 1 5 个 苏 联 师 、 2 个 东 德 师 和 1 个 捷 克 斯 洛 伐 克 师 组 成 。 行 动 涉 及 ： 捷 克 斯 洛 伐 克 人 民 军 - 西 部 军 区 司 令 部 和 两 个 陆 军 司 令 部 ； 民 主 德 国 人 民 军 - 两 个 陆 军 司 令 部 ； 苏 联 军 队 - 国 家 民 航 司 令 部 、 两 个 陆 军 司 令 部 和 北 方 集 群 司 令 部 。||1 9 8 0 年 1 2 月 9 日 ， 苏 联 武 装 力 量 北 方 集 群 各 单 位 与 民 主 德 国 人 民 军 、 捷 克 斯 洛 伐 克 人 民 军 各 单 位 进 入 波 兰 领 土 ， 向 波 兰 重 点 城 市 快 速 推 进 。 波 兰 军 队 的 一 部 分 没 有 抵 抗 。 团 结 工 会 转 入 地 下 ， 团 结 工 会 和 统 工 党 的 领 导 人 被 捕 并 被 带 到 苏 联 。 新 的 波 兰 由 统 工 党 “ 党 之 基 石 ” 派 的 塔 德 乌 什 · 格 拉 布 斯 基 领 导 ， 波 兰 人 民 军 则 由 亲 苏 的 尤 金 纽 什 · 莫 尔 奇 克 领 导 。 新 领 导 层 宣 布 将 进 行 “ 社 会 主 义 秩 序 化 ” ， 并 在 苏 军 的 帮 助 下 铲 除 反 对 派 。 美 国 异 常 愤 怒 ， 全 力 指 责 苏 联 和 我 们 “ 在 波 兰 建 立 专 制 的 傀 儡 政 权 ” 。";
				GlobalScript.inst.gameState.data[1] += 100;
				GlobalScript.inst.gameState.data[22] -= 50;
				GlobalScript.inst.gameState.data[9] -= 50;
				GlobalScript.inst.gameState.influencePRC += 10;
				GlobalScript.inst.gameState.data[6] += 200;
				GlobalScript.inst.gameState.empires[0].power -= 10;
				GlobalScript.inst.gameState.empires[0].relations -= 150;
				GlobalScript.inst.gameState.empires[1].relations += 150;
				GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 16;
				GlobalScript.inst.gameState.allcountries[2].puppetOf = 7;
				int[] data = GlobalScript.inst.gameState.data;
				int num = 112;
				ref int reference = ref data[num];
				int num2 = data[num];
				reference = num2 + 1;
			}
			else
			{
				text = " 不 幸 的 是 ， 苏 联 和 其 他 华 约 国 家 的 领 导 层 不 打 算 派 兵 恢 复 秩 序 ， 而 是 支 持 并 许 可 波 兰 军 队 开 展 独 立 行 动 。 在 得 到 苏 联 支 持 和 不 会 军 事 干 预 的 保 证 后 ， 国 防 部 长 沃 伊 切 赫 · 雅 鲁 泽 尔 斯 基 创 立 了 包 含 统 工 党 三 派 的 救 国 军 事 委 员 会 ， 并 在 苏 方 和 我 方 的 压 力 下 于 1 9 8 0 年 1 2 月 1 3 日 宣 布 在 波 兰 全 境 实 行 战 时 状 态 。 波 兰 人 民 军 、 安 全 委 员 会 和 Z O M O （ 摩 托 化 预 备 役 部 队 ， 波 兰 民 事 警 察 部 门 的 特 种 单 位 ） 的 决 定 性 行 动 ， 终 止 了 团 结 工 会 和 波 兰 统 一 工 人 党 的 活 动 ， 波 兰 国 内 秩 序 多 少 重 建 了 起 来 。 雅 鲁 泽 尔 斯 基 宣 布 了 “ 社 会 主 义 革 新 路 线 ” ， 但 实 质 的 问 题 并 没 有 解 决 ， 这 早 晚 会 找 上 门 来 的 … …";
				GlobalScript.inst.gameState.influencePRC += 10;
				GlobalScript.inst.gameState.data[6] += 200;
				GlobalScript.inst.gameState.empires[1].power -= 20;
				GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 1;
				GlobalScript.inst.gameState.allcountries[2].Gosstroy = 0;
			}
			break;
		case 5:
			if (GlobalScript.inst.gameState.empires[0].relations >= 80 && GlobalScript.inst.gameState.allcountries[51].dev == 1)
			{
				text = " 我 们 与 中 情 局 取 得 了 联 系 ， 并 就 联 合 行 动 达 成 了 协 议 。 我 们 对 统 工 党 改 革 派 和 “ 平 行 结 构 ” 派 进 行 了 秘 密 支 持 ， 并 为 团 结 工 会 提 供 了 一 批 额 外 援 助 。 局 势 发 生 了 意 想 不 到 的 转 变 — — 随 着 动 荡 加 剧 ， 斯 坦 尼 斯 瓦 夫 · 卡 尼 亚 在 与 陆 军 司 令 部 进 行 秘 密 磋 商 后 ， 出 人 意 料 地 宣 布 辞 去 所 有 职 务 。 统 一 工 人 党 中 央 委 员 会 的 第 一 书 记 变 为 了 改 革 的 支 持 者 ， 米 奇 斯 瓦 夫 · 拉 科 夫 斯 基 ， 他 与 波 兰 国 防 部 长 沃 伊 切 赫 · 雅 鲁 泽 尔 斯 基 将 军 关 系 密 切 。 获 得 了 军 队 支 持 的 改 革 派 开 始 对 波 兰 领 导 层 进 行 大 换 血 ， “ 党 之 基 石 ” 派 成 员 被 陆 续 辞 退 ， 取 而 代 之 的 是 改 革 派 和 兹 比 格 涅 夫 · 伊 万 诺 夫 的 “ 平 行 结 构 ” 派 。 在 这 种 情 况 下 ， 拉 科 夫 斯 基 与 瓦 文 萨 进 行 了 接 触 ， 并 达 成 了 一 个 有 利 于 双 方 的 妥 协 方 案 — — 团 结 工 会 正 式 合 法 化 ， 停 止 权 力 斗 争 并 进 入 议 会 ， 团 结 工 会 将 在 新 政 府 中 获 得 若 干 职 务 ， 并 获 准 起 草 一 项 广 泛 的 改 革 。 拥 有 统 工 党 和 团 结 工 会 双 籍 被 合 法 化 ， 事 实 上 ， 团 结 工 会 被 吸 纳 为 了 自 治 的 官 方 工 会 ， 能 够 合 法 参 与 政 治 并 参 与 制 定 生 产 计 划 ， 同 时 对 企 业 进 行 民 主 管 理 。 拉 科 夫 斯 基 宣 布 了 “ 社 会 主 义 革 新 路 线 ” 的 概 念 ， 这 意 味 着 参 考 匈 牙 利 和 南 斯 拉 夫 模 式 ， 在 马 克 思 主 义 的 旗 帜 下 开 展 具 有 工 团 主 义 和 民 主 社 会 主 义 性 质 的 广 泛 改 革 ， 进 行 独 具 特 色 的 波 兰 式 社 会 主 义 建 设 。 团 结 工 会 领 导 层 支 持 这 些 改 革 ， 并 宣 布 停 止 示 威 和 罢 工 — — 局 势 正 缓 慢 地 正 常 化 。 拉 科 夫 斯 基 表 示 ， 将 继 续 “ 保 持 与 苏 联 的 友 好 合 作 关 系 并 支 持 世 界 社 会 主 义 事 业 ” 。 尽 管 苏 东 阵 营 的 保 守 派 对 此 并 不 高 兴 ， 但 是 鉴 于 统 工 党 并 未 失 去 领 导 地 位 ， 局 势 正 在 向 好 以 及 1 9 6 8 年 “ 多 瑙 河 行 动 ” 和 进 军 阿 富 汗 的 恶 劣 国 际 影 响 ， 他 们 将 不 满 限 制 在 了 牢 骚 之 中 。";
				GlobalScript.inst.gameState.data[1] += 50;
				GlobalScript.inst.gameState.data[3] += 20;
				GlobalScript.inst.gameState.data[4] += 80;
				GlobalScript.inst.gameState.data[8] -= 100;
				GlobalScript.inst.gameState.data[4] += 80;
				GlobalScript.inst.gameState.data[9] -= 200;
				GlobalScript.inst.gameState.empires[1].power -= 30;
				GlobalScript.inst.gameState.data[6] -= 50;
				GlobalScript.inst.gameState.empires[0].relations += 150;
				GlobalScript.inst.gameState.empires[1].relations -= 50;
				GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[2].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[2].prosov = false;
				GlobalScript.inst.gameState.allcountries[2].Torg = true;
			}
			else
			{
				text = " 不 幸 的 是 ， 即 使 我 们 支 持 了 美 国 破 坏 波 兰 稳 定 的 行 动 ， 也 没 有 产 生 好 的 结 果 。 起 初 ， 一 切 按 计 划 进 行 －12 月 ， 团 结 工 会 在 民 众 的 广 泛 支 持 下 尝 试 政 变 ， 夺 取 了 华 沙 的 政 府 区 — — 但 是 ， 意 料 之 外 的 事 情 发 生 了 。 斯 坦 尼 斯 瓦 夫 · 卡 尼 亚 逃 往 比 亚 韦 斯 托 克 ， 转 向 华 约 的 政 治 协 商 委 员 会 会 议 寻 求 军 事 协 助 。12 月9 日 ， 苏 联 武 装 力 量 北 方 集 群 ， 与 民 主 德 国 人 民 军 和 捷 克 斯 洛 伐 克 人 民 军 一 道 ， 进 入 波 兰 领 土 ， 开 始 向 波 兰 关 键 城 市 快 速 推 进 。 部 分 波 兰 军 队 加 入 其 中 或 是 保 持 中 立 。 团 结 工 会 被 彻 底 摧 毁 了 ， 莱 赫 · 瓦 文 萨 勉 强 逃 到 美 国 驻 华 沙 大 使 馆 。 波 兰 的 新 领 导 层 ， 由 沃 依 切 赫 · 雅 鲁 泽 尔 斯 基 领 导 ， 宣 布 了 “ 社 会 主 义 革 新 路 线 ” ， 期 望 在 马 克 思 主 义 框 架 内 ， 苏 联 军 队 监 视 下 开 展 改 革 … …";
				GlobalScript.inst.gameState.data[9] -= 200;
				GlobalScript.inst.gameState.data[8] -= 100;
				GlobalScript.inst.gameState.empires[1].power -= 10;
				GlobalScript.inst.gameState.data[6] -= 50;
				GlobalScript.inst.gameState.empires[0].relations -= 300;
				GlobalScript.inst.gameState.data[1] -= 100;
				GlobalScript.inst.gameState.data[4] += 80;
			}
			break;
		}
		if (result_num == 6)
		{
			text = "";
		}
	}
}
