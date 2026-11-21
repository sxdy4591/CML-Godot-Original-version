using EventsForDLC;
using UnityEngine;

public class Event85 : EventsSecond
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
		name = " 哈 萨 克 斯 坦 的 德 意 志 族 自 治 区";
		text = " 我 们 在 莫 斯 科 的 消 息 来 源 设 法 获 得 了 有 趣 的 信 息 — — 一 个 由Y. 安 德 罗 波 夫 、I. 卡 皮 诺 夫 、M. 齐 米 宁 、Z. 努 里 耶 夫 、N. 什 切 洛 科 娃 、R. 鲁 登 科 、M. 乔 治 泽 、V. 切 布 里 科 娃 组 成 的 委 员 会 向 苏 联 中 央 委 员 会 提 交 了 一 份 关 于 在 哈 萨 克 斯 坦 苏 维 埃 社 会 主 义 共 和 国 建 立 德 意 志 族 自 治 区 的 提 案 （30 —40 年 代 ，94 万 德 意 志 人 被 派 到 这 里 ） 然 而 ， 由 列 昂 尼 德 · 勃 列 日 涅 夫 的 亲 密 盟 友 金 姆 哈 梅 塔 · 库 纳 耶 夫 领 导 的 共 和 国 领 导 层 强 烈 反 对 这 一 点 。 据 我 们 所 知 ， 他 们 甚 至 准 备 组 织 哈 萨 克 人 民 的 暴 乱 ， 以 防 这 种 自 治 区 被 创 造 出 来 。 库 纳 耶 夫 是 苏 联 领 导 层 组 成 发 生 变 化 时 最 有 可 能 担 任 苏 共 中 央 第 二 书 记 的 人 选 之 一 。 他 的 反 华 情 绪 并 不 是 秘 密 。 利 用 形 势 推 翻 他 是 有 道 理 的 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[0] = " 一 旦 共 和 国 爆 发 骚 乱 ， 我 们 就 将 尽 全 力 绊 倒 库 纳 耶 夫 （ 需 要10 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "It's too dangerous!";
		}
		if (GlobalScript.inst.gameState.relres && ((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[1] = " 我 们 将 先 发 制 人 ， 警 告 他 正 触 碰 苏 共 中 央 委 员 会 的 底 线 （ 需 要3 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 和 勃 列 日 涅 夫 的 关 系 还 不 足 以 让 他 知 悉 这 些";
		}
		button_text[2] = " 我 们 不 关 心 苏 联 的 事 务";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 哈 萨 克 斯 坦 的 德 意 志 族 自 治 区";
		switch (result_num)
		{
		case 0:
		{
			text = "6 月16 日 ， 在 切 利 诺 格 勒 ， 科 克 切 塔 夫 和 卡 拉 干 达 ， 哈 萨 克 人 民 开 始 大 规 模 抗 议 ， 他 们 反 对 给 予 德 意 志 少 数 民 族 自 治 权 。 抗 议 者 举 着 标 语 ， 上 面 写 着 ： “ 我 们 的 土 地 对 每 个 人 都 是 统 一 而 不 可 分 裂 的 ！ ” 并 高 呼 口 号 ： “ 不 许 在 埃 雷 门 托 搞 德 意 志 族 自 治 区 ！ ” 。 在 第 一 次 抗 议 的 三 天 后 ， 在 切 利 诺 格 勒 郊 区 ， 人 群 再 次 聚 集 在 周 围 的 街 道 上 ， 要 求 当 局 回 答 以 下 问 题 ： “ 哈 萨 克 人 在 他 们 的 土 地 上 等 待 着 什 么 命 运 ？ ” 和 “ 那 自 治 呢 ？ ” 哈 萨 克 共 和 国 的 领 导 层 和 执 法 机 构 暗 中 支 持 示 威 者 ， 并 没 有 阻 止 传 单 的 分 发 ， 传 单 呼 吁 去 集 体 宿 舍 组 织 抗 议 集 会 。 我 们 利 用 这 一 点 ， 公 开 宣 布 了 这 一 事 实 ， 指 责 库 纳 耶 夫 搞 “ 新 法 西 斯 主 义 ” 和 “ 违 反 列 宁 的 民 族 政 策 原 则 ” 。 通 过 国 安 部 ， 还 整 理 了 大 量 涉 嫌 腐 败 的 随 行 人 员 的 黑 材 料 。12 月16 日 ， 在 只 持 续 了18 分 钟 的 哈 萨 克 中 央 委 员 会 有 史 以 来 最 短 的 会 议 上 ， 金 姆 哈 梅 塔 · 库 纳 耶 夫 被 撤 去 哈 萨 克 中 央 委 员 会 第 一 书 记 的 职 务 ， 并 被 迫 退 休 。 接 替 他 的 是 莫 斯 科 派 来 的 格 鲁 吉 亚 党 的 第 二 书 记 盖 纳 季 · 科 尔 宾 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			Leader leader2;
			int support2 = (leader2 = GlobalScript.inst.gameState.empires[1].leaders[3]).support;
			leader2.support = support2 - 1;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[149] = 3;
			break;
		}
		case 1:
			if (GlobalScript.inst.gameState.empires[1].relations >= 500)
			{
				text = " 我 们 紧 急 向 苏 共 中 央 委 员 会 提 供 了 将 在 哈 萨 克 苏 维 埃 社 会 主 义 共 和 国 发 生 的 事 件 的 全 部 信 息 ， 指 出 整 个 哈 萨 克 党 的 精 英 都 参 与 其 中 。 我 们 的 警 告 得 到 重 视 ，6 月16 日 ， 苏 联 内 务 部 内 部 部 队 进 入 切 利 诺 格 勒 ， 科 克 切 塔 夫 ， 和 卡 拉 干 达 ， 阻 止 示 威 发 生 。 库 纳 耶 夫 被 召 到 莫 斯 科 ， 在 与 阿 尔 维 德 · 佩 尔 谢 和 米 哈 伊 尔 · 苏 斯 洛 夫 谈 话 后 ， 他 写 了 一 份 声 明 ， 说 他 因 为 “ 健 康 原 因 ” ， 将 辞 去 一 切 职 务 。";
				GlobalScript.inst.gameState.data[9] -= 30;
				Leader leader;
				int support = (leader = GlobalScript.inst.gameState.empires[1].leaders[3]).support;
				leader.support = support - 1;
				GlobalScript.inst.gameState.data[149] = 3;
			}
			else
			{
				text = " 我 们 紧 急 向 苏 共 中 央 委 员 会 提 供 了 将 在 哈 萨 克 苏 维 埃 社 会 主 义 共 和 国 发 生 的 事 件 的 全 部 信 息 ， 指 出 整 个 哈 萨 克 党 的 精 英 都 参 与 其 中 。 但 是 ， 我 们 的 警 告 被 忽 视 了 。6 月16 日 ， 在 切 利 诺 格 勒 ， 科 克 切 塔 夫 和 卡 拉 干 达 ， 哈 萨 克 人 民 开 始 大 规 模 抗 议 ， 他 们 反 对 给 予 德 意 志 少 数 民 族 自 治 权 。 抗 议 者 举 着 标 语 ， 上 面 写 着 ： “ 我 们 的 土 地 对 每 个 人 都 是 统 一 而 不 可 分 裂 的 ！ ” 并 高 呼 口 号 ： “ 不 许 在 埃 雷 门 托 搞 德 意 志 族 自 治 区 ！ ” 。 结 果 ， 当 局 同 意 了 示 威 者 的 要 求 ， 宣 布 将 哈 萨 克 德 意 志 族 自 治 区 的 问 题 从 议 程 中 彻 底 移 除 出 去 。";
				GlobalScript.inst.gameState.data[9] -= 30;
			}
			break;
		case 2:
			text = "6 月16 日 ， 在 切 利 诺 格 勒 ， 科 克 切 塔 夫 和 卡 拉 干 达 ， 哈 萨 克 人 民 开 始 大 规 模 抗 议 ， 他 们 反 对 给 予 德 意 志 少 数 民 族 自 治 权 。 抗 议 者 举 着 标 语 ， 上 面 写 着 ： “ 我 们 的 土 地 对 每 个 人 都 是 统 一 而 不 可 分 裂 的 ！ ” 并 高 呼 口 号 ： “ 不 许 在 埃 雷 门 托 搞 德 意 志 族 自 治 区 ！ ” 。 结 果 ， 当 局 同 意 了 示 威 者 的 要 求 ， 宣 布 将 哈 萨 克 德 意 志 族 自 治 区 的 问 题 从 议 程 中 彻 底 移 除 出 去 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
