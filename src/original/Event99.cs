using EventsForDLC;
using UnityEngine;

public class Event99 : EventsSecond
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
		name = " 黄 蝎";
		text = " 主 席 同 志 ， 从 社 会 主 义 阿 尔 及 利 亚 传 来 的 紧 急 消 息 ！ 第 二 任 阿 尔 及 利 亚 人 民 民 主 共 和 国 总 统 胡 阿 里 · 布 迈 丁 ， 那 位 曾 经 推 翻 了 我 们 的 老 朋 友 艾 哈 迈 德 · 本 · 贝 拉 并 终 止 了 本 · 贝 拉 激 进 的 社 会 主 义 实 验 、 以 神 秘 与 狡 诈 被 人 民 昵 称 黄 蝎 的 总 统 ， 在 暴 病 后 猝 死 。 在 十 五 年 的 总 统 生 涯 中 ， 他 在 落 后 的 法 国 殖 民 地 里 建 设 起 一 个 强 大 的 非 洲 工 业 巨 人 。 尽 管 布 迈 丁 政 权 实 际 上 是 由 军 队 、 官 僚 和 技 术 专 家 构 成 的 精 英 集 团 进 行 统 治 的 反 共 军 政 府 ， 但 布 迈 丁 上 校 执 政 时 的 国 有 化 、 土 地 改 革 和 外 交 上 的 反 帝 国 主 义 立 场 使 得 他 的 政 权 受 到 了 处 于 地 下 状 态 的 社 会 主 义 先 锋 党 （ 由 阿 尔 及 利 亚 共 产 党 在 反 布 迈 丁 政 变 失 败 被 镇 压 后 改 组 而 成 ） 的 积 极 支 持 ， 他 领 导 下 的 阿 尔 及 利 亚 也 依 然 是 阿 拉 伯 社 会 主 义 与 不 结 盟 运 动 的 标 杆 。 布 迈 丁 的 猝 然 离 世 使 得 国 家 权 力 一 时 进 入 真 空 状 态 ， 由 军 队 组 成 的 革 命 委 员 会 暂 时 接 管 了 政 治 权 力 。 现 在 ， 由 于 继 承 危 机 ， 执 政 的 民 族 解 放 阵 线 中 两 派 已 经 开 始 争 夺 权 力 。 他 们 是 由 “ 布 迈 丁 主 义 的 象 征 ” 穆 罕 默 德 · 萨 拉 赫 · 雅 伊 奥 维 上 校 领 导 、 由 工 会 积 极 支 持 的 、 受 到 社 会 主 义 先 锋 党 欢 迎 的 、 忠 于 布 迈 丁 上 校 的 社 会 主 义 路 线 的 正 统 派 ， 与 支 持 向 西 方 开 放 的 外 交 部 长 、 “ 资 产 阶 级 潮 流 ” 的 代 表 阿 卜 杜 勒 阿 齐 兹 · 布 特 弗 利 卡 领 导 的 一 个 更 偏 自 由 化 的 派 别 。 而 军 队 则 对 布 迈 丁 的 社 会 主 义 立 场 和 掌 控 国 家 政 权 十 五 年 之 久 的 乌 季 达 帮 （ 布 迈 丁 总 统 的 亲 信 ） 十 分 不 满 ， 他 们 另 外 挑 出 了 一 个 乌 季 达 帮 中 的 边 缘 人 物 — — 第 二 军 区 司 令 沙 德 利 · 本 · 杰 迪 德 上 校 。 支 持 任 何 一 派 都 会 扩 大 我 们 在 这 里 的 影 响 ， 但 是 这 值 得 吗 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[0] = " 我 们 将 帮 助 正 统 派 反 对 修 正 主 义";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 看 布 迈 丁 的 遗 产 也 应 该 扬 弃 了";
		}
		if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[1] = " 帮 助 乌 季 达 帮 的 “ 自 由 派 ” 崛 起";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 布 特 弗 利 卡 ？ 祝 他 好 运";
		}
		if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] >= 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[2] = " 支 持 军 队 推 出 的 改 革 者 进 行 去 布 迈 丁 化";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 乌 季 达 帮 坐 的 时 间 有 点 太 长 了";
		}
		button_text[3] = " 袖 手 旁 观";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 黄 蝎";
		switch (result_num)
		{
		case 0:
			text = " 多 亏 了 我 们 的 支 持 ， 正 统 布 迈 丁 主 义 者 穆 罕 默 德 · 雅 伊 奥 维 能 够 打 击 反 对 派 并 且 使 民 族 解 放 阵 线 任 命 他 为 总 书 记 ， 全 国 人 民 议 会 也 任 命 他 为 阿 尔 及 利 亚 代 理 总 统 。 提 前 选 举 定 于 1 9 7 9 年 2 月 8 日 举 行 ， 然 而 ， 作 为 一 个 一 党 制 国 家 内 举 行 并 且 没 有 其 他 选 项 的 选 举 的 结 果 是 可 想 而 知 的 。 新 政 府 宣 布 将 外 交 政 策 转 向 亲 中 方 向 ， 并 邀 请 我 们 签 署 一 项 非 常 有 利 可 图 的 贸 易 合 同 。 苏 联 对 中 国 干 涉 阿 尔 及 利 亚 内 政 作 出 了 消 极 的 反 应 。 雅 伊 奥 维 上 校 坚 持 了 布 迈 丁 总 统 的 社 会 主 义 与 泛 阿 拉 伯 主 义 理 念 ， 继 续 在 全 国 推 行 “ 民 族 主 义 、 社 会 主 义 与 伊 斯 兰 教 相 结 合 ” 的 阿 拉 伯 - 伊 斯 兰 化 ， 不 过 ， 布 迈 丁 时 期 工 业 化 的 快 速 推 进 与 石 油 红 利 带 来 的 快 速 发 展 导 致 的 弊 病 也 开 始 显 现 出 来 ， 对 农 业 建 设 的 忽 视 与 失 败 的 土 地 改 革 使 阿 尔 及 利 亚 农 业 发 展 相 当 低 效 。 阿 拉 伯 民 族 主 义 的 政 策 也 引 起 了 同 样 在 阿 尔 及 利 亚 革 命 中 作 出 过 很 大 贡 献 的 民 族 — — 柏 柏 尔 人 的 不 满 ， 他 们 举 行 了 要 求 废 除 对 柏 柏 尔 文 化 的 歧 视 性 政 策 的 抗 议 ， 而 这 并 没 有 掀 起 什 么 风 浪 。 在 夺 权 进 程 中 支 持 了 雅 伊 奥 维 的 社 会 主 义 先 锋 党 也 顺 利 拿 到 了 投 名 状 ， 解 散 后 被 吸 纳 进 了 政 府 ， 而 这 当 然 是 以 他 们 放 弃 阶 级 斗 争 和 马 克 思 列 宁 主 义 为 前 提 的 ， 但 谁 会 在 乎 这 些 呢 。";
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[1].power -= 30;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.allcountries[40].prosov = false;
			GlobalScript.inst.gameState.allcountries[40].proprc = true;
			GlobalScript.inst.gameState.allcountries[40].Torg = true;
			return;
		case 1:
		{
			text = " 在 我 们 特 工 的 帮 助 下 ， 长 期 以 来 被 视 为 布 迈 丁 政 权 的 二 号 人 物 的 外 交 部 长 布 特 弗 利 卡 镇 压 了 党 内 反 对 派 ， 民 族 解 放 阵 线 紧 急 会 议 选 举 他 为 总 书 记 ； 全 国 人 民 议 会 任 命 他 为 阿 尔 及 利 亚 代 理 总 统 ， 提 前 选 举 定 于 1 9 7 9 年 2 月 8 日 举 行 ， 然 而 ， 作 为 一 个 一 党 制 国 家 内 举 行 并 且 没 有 其 他 选 项 的 选 举 的 结 果 是 可 想 而 知 的 。 布 特 弗 利 卡 感 谢 我 们 的 支 持 ， 并 提 供 了 一 个 非 常 有 利 可 图 的 合 同 。 在 完 成 了 个 人 权 力 的 巩 固 后 ， 布 特 弗 利 卡 便 引 入 了 一 定 的 经 济 自 由 主 义 ， 放 松 了 对 私 营 企 业 和 外 国 投 资 的 限 制 ， 并 加 深 了 与 巴 黎 和 华 盛 顿 的 关 系 。 尽 管 这 样 温 和 的 改 革 不 能 取 悦 任 何 人 ， 但 至 少 乌 季 达 帮 的 地 位 得 到 了 巩 固 ， 不 是 吗 ？";
			GlobalScript.inst.gameState.empires[1].power += 10;
			GlobalScript.inst.gameState.data[9] -= 40;
			GlobalScript.inst.gameState.empires[0].relations -= 30;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.allcountries[40].Torg = true;
			GlobalScript.inst.gameState.allcountries[40].prosov = false;
			int[] data = GlobalScript.inst.gameState.data;
			int num = 143;
			ref int reference = ref data[num];
			int num2 = data[num];
			reference = num2 + 1;
			break;
		}
		case 2:
			text = " 我 们 支 持 革 命 委 员 会 挑 选 出 的 沙 德 利 · 本 · 杰 迪 德 ， 结 果 成 功 击 败 了 布 迈 丁 选 定 的 继 承 人 雅 伊 奥 维 ， 与 布 迈 丁 总 统 关 系 密 切 的 布 特 弗 利 卡 也 被 免 去 外 交 部 长 职 务 ， 转 任 次 要 职 务 。 民 族 解 放 阵 线 紧 急 会 议 任 命 本 · 杰 迪 德 为 总 书 记 ， 全 国 人 民 议 会 任 命 他 为 阿 尔 及 利 亚 代 理 总 统 ， 提 前 选 举 定 于 1 9 7 9 年 2 月 8 日 举 行 ， 然 而 ， 作 为 一 个 一 党 制 国 家 内 举 行 并 且 没 有 其 他 选 项 的 选 举 的 结 果 是 可 想 而 知 的 。 新 政 府 进 行 了 静 悄 悄 的 “ 去 布 迈 丁 化 ” ， 开 始 了 肢 解 国 有 资 本 、 向 市 场 经 济 转 变 的 进 程 ， 乌 季 达 帮 也 被 排 挤 出 权 力 核 心 之 外 。 过 去 激 进 的 外 交 政 策 也 转 向 缓 和 ， 在 维 持 与 非 洲 国 家 的 关 系 的 同 时 与 法 国 和 西 方 建 立 了 新 联 系 。 内 阁 、 人 民 议 会 和 军 队 中 都 进 行 了 重 大 的 人 事 变 动 ， 布 迈 丁 主 义 者 们 逐 渐 被 新 总 统 的 东 部 老 乡 所 取 代 。 通 过 不 断 的 政 治 清 洗 ， 本 · 杰 迪 德 清 除 了 与 布 迈 丁 时 代 有 关 联 的 任 何 潜 在 竞 争 对 手 。 经 济 自 由 化 带 来 了 一 系 列 问 题 （ 诸 如 侵 吞 国 有 资 产 、 严 重 的 贪 污 腐 败 、 物 价 上 涨 ） ， 这 引 起 了 人 民 的 普 遍 不 满 ， 再 加 上 统 治 集 团 内 部 的 矛 盾 与 政 府 控 制 力 的 下 降 ， 很 多 反 对 派 开 始 在 地 下 活 跃 起 来 。";
			GlobalScript.inst.gameState.empires[1].power -= 30;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.empires[1].relations -= 300;
			GlobalScript.inst.gameState.empires[0].power += 30;
			GlobalScript.inst.gameState.allcountries[40].Torg = true;
			GlobalScript.inst.gameState.allcountries[40].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[40].SubGosstroy = 5;
			GlobalScript.inst.gameState.allcountries[40].prosov = false;
			GlobalScript.inst.gameState.allcountries[40].Vyshi = true;
			GlobalScript.inst.gameState.data[143] -= 3;
			break;
		case 3:
			text = " 民 族 解 放 阵 线 紧 急 会 议 任 命 改 革 派 领 袖 沙 德 利 · 本 · 杰 迪 德 为 “ 妥 协 ” 总 书 记 ， 全 国 人 民 议 会 任 命 他 为 阿 尔 及 利 亚 代 理 总 统 ， 提 前 选 举 定 于 1 9 7 9 年 2 月 8 日 举 行 ， 然 而 ， 作 为 一 个 一 党 制 国 家 内 举 行 并 且 没 有 其 他 选 项 的 选 举 的 结 果 是 可 想 而 知 的 。 新 政 府 进 行 了 静 悄 悄 的 “ 去 布 迈 丁 化 ” ， 开 始 了 肢 解 国 有 资 本 、 向 市 场 经 济 转 变 的 进 程 ， 乌 季 达 帮 也 被 排 挤 出 权 力 核 心 之 外 。 过 去 激 进 的 外 交 政 策 也 转 向 缓 和 ， 在 维 持 与 非 洲 国 家 的 关 系 的 同 时 与 法 国 和 西 方 建 立 了 新 联 系 。 内 阁 、 人 民 议 会 和 军 队 中 都 进 行 了 重 大 的 人 事 变 动 ， 布 迈 丁 主 义 者 们 逐 渐 被 新 总 统 的 东 部 老 乡 所 取 代 。 通 过 不 断 的 政 治 清 洗 ， 本 · 杰 迪 德 清 除 了 与 布 迈 丁 时 代 有 关 联 的 任 何 潜 在 竞 争 对 手 ， 经 济 自 由 化 带 来 了 一 系 列 问 题 （ 诸 如 侵 吞 国 有 资 产 、 严 重 的 贪 污 腐 败 、 物 价 上 涨 ） ， 这 引 起 了 人 民 的 普 遍 不 满 。 再 加 上 统 治 集 团 内 部 的 矛 盾 与 政 府 控 制 力 的 下 降 ， 很 多 反 对 派 开 始 在 地 下 活 跃 起 来 。";
			GlobalScript.inst.gameState.allcountries[40].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[40].SubGosstroy = 5;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
