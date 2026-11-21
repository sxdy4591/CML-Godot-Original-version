using EventsForDLC;
using UnityEngine;

public class Event110 : EventsSecond
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
		name = " 自 动 化 的 缓 慢 进 展";
		text = " 主 席 同 志! 在 过 去 的 五 年 里 ， 我 们 在 国 民 经 济 和 科 学 研 究 方 面 取 得 了 很 大 的 进 步 ， 我 们 不 应 该 止 步 于 此 。 现 在 应 该 巩 固 我 们 的 成 就 ， 重 新 建 立 几 代 人 关 于 一 个 完 美 的 世 界 秩 序 的 梦 想 ， 迈 出 从 社 会 主 义 到 共 产 主 义 社 会 的 第 一 步 。 我 国 最 优 秀 的 头 脑 — — 数 学 家 和 控 制 论 者 — — 提 出 要 建 立 一 个 全 面 的 、 统 一 的 、 自 动 化 的 生 产 计 划 系 统 。OGAS 的 概 念 由 苏 联 数 学 家 维 克 多 · 格 鲁 什 科 夫 提 出 。 因 此 ， 我 们 将 能 够 通 过 把 最 复 杂 和 最 昂 贵 的 计 算 转 移 到 计 算 机 上 来 摆 脱 计 划 经 济 的 所 有 问 题 和 缺 陷 。 但 要 实 施 如 此 庞 大 的 项 目 ， 需 要 大 量 的 资 金 和 时 间 ， 同 时 国 家 机 器 像 害 怕 火 灾 一 样 害 怕 激 进 的 变 化 ， 特 别 是 那 些 可 能 会 侵 蚀 他 们 的 领 地 和 繁 荣 的 变 化 。 选 择 权 在 你 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 让 我 们 再 等 几 年 … … 或 者 更 久 … …";
		button_text[1] = " 宣 布 一 门 关 于 生 产 自 动 化 的 课 题 ， 并 设 立 一 个 委 员 会 来 实 施 它( 需 要10 百 万 预 算)";
		if (GlobalScript.inst.gameState.empires[1].relations >= 500 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[2] = " 开 始 自 动 化 和 邀 请 苏 联 科 学 家";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 苏 维 埃 不 会 帮 助 我 们";
		}
		if (GlobalScript.inst.gameState.empires[0].relations >= 600 && GlobalScript.inst.gameState.data[6] <= 800 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.modifies[17].active)
		{
			button_text[3] = " 我 们 准 备 工 作 了 ， 西 方 专 家 会 帮 助 我 们 的 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 向 西 方 求 助 ？ 你 是 认 真 的 吗 ？";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 自 动 化 的 缓 慢 进 展";
		switch (result_num)
		{
		case 0:
			text = " 社 会 主 义 经 济 继 续 稳 定 运 行 。 至 少 目 前 如 此 ......";
			break;
		case 1:
			text = " 光 荣 的 主 席 万 岁! 光 荣 的 中 国 共 产 党 万 岁! 这 一 天 将 作 为 “ 重 大 突 破 ” 的 日 子 载 入 中 国 史 册 。 我 们 敬 爱 的 领 袖 宣 布 我 们 国 家 开 始 过 渡 到 全 面 自 动 化 和 计 算 机 化 的 规 划 和 生 产 的 重 大 变 革, 并 宣 布 建 立 一 个 自 动 化 经 济 管 理 中 心 ， 他 们 的 工 作 即 将 开 始 。 新 项 目 的 名 称 为IECS — — 跨 部 门 电 子 控 制 系 统 。 现 在 ， 在 这 个 国 家 关 于 匆 忙 引 入 这 些 措 施 的 激 烈 讨 论 已 经 爆 发 ， 一 些 党 内 政 客 宣 称 改 革 具 有 “ 反 马 克 思 主 义 性 质 ” 。 然 而 ， 这 个 项 目 启 动 了 ， 没 有 什 么 能 阻 止 这 个 国 家 不 可 避 免 的 变 化 ， 对 吗?";
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[1] -= 600;
			GlobalScript.inst.gameState.data[118] = 1;
			break;
		case 2:
			text = " 光 荣 的 主 席 万 岁! 光 荣 的 中 国 共 产 党 万 岁! 这 一 天 将 作 为 “ 重 大 突 破 ” 的 日 子 载 入 中 国 史 册 。 我 们 敬 爱 的 领 袖 宣 布 我 们 国 家 开 始 过 渡 到 全 面 自 动 化 和 计 算 机 化 的 规 划 和 生 产 的 重 大 变 革, 并 宣 布 建 立 一 个 自 动 化 经 济 管 理 中 心 ， 他 们 的 工 作 即 将 开 始 。 新 项 目 的 名 称 为IECS — — 跨 部 门 电 子 控 制 系 统 。 此 外 ， 由 于 我 们 同 苏 联 人 民 的 密 切 友 谊 ， 我 们 要 求 苏 联 提 供 有 条 件 的 援 助 ， 现 在 由 阿 纳 托 利 · 基 托 夫 院 士 率 领 的 代 表 团 已 经 抵 达 中 国 。 现 在 ， 在 这 个 国 家 关 于 匆 忙 引 入 这 些 措 施 的 激 烈 讨 论 已 经 爆 发 ， 一 些 党 内 政 客 宣 称 改 革 具 有 “ 反 马 克 思 主 义 性 质 ” 。 然 而 ， 这 个 项 目 启 动 了 ， 没 有 什 么 能 阻 止 这 个 国 家 不 可 避 免 的 变 化 ， 对 吗?";
			GlobalScript.inst.gameState.data[8] -= 80;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[4] += 120;
			GlobalScript.inst.gameState.data[1] -= 600;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.data[118] = 1;
			GlobalScript.inst.gameState.data[73] += 300;
			break;
		case 3:
			text = " 光 荣 的 主 席 万 岁! 光 荣 的 中 国 共 产 党 万 岁! 这 一 天 将 作 为 “ 重 大 突 破 ” 的 日 子 载 入 中 国 史 册 。 我 们 敬 爱 的 领 袖 宣 布 我 们 国 家 开 始 过 渡 到 全 面 自 动 化 和 计 算 机 化 的 规 划 和 生 产 的 重 大 变 革, 并 宣 布 建 立 一 个 自 动 化 经 济 管 理 中 心 ， 他 们 的 工 作 即 将 开 始 。 新 项 目 的 名 称 为IECS — — 跨 部 门 电 子 控 制 系 统 。 此 外 ， 由 于 我 们 与 西 方 国 家 的 友 好 关 系 ， 我 们 能 够 邀 请 由 斯 塔 福 德 · 比 尔(Stafford Beer) 领 导 的 欧 洲 数 学 科 学 家 代 表 团 ， 他 之 前 因 开 发 智 利 的 “ 赛 博 协 同 ”(Cybersyn) 工 程 而 闻 名 。 现 在 ， 在 这 个 国 家 关 于 匆 忙 引 入 这 些 措 施 的 激 烈 讨 论 已 经 爆 发 ， 一 些 党 内 政 客 宣 称 改 革 具 有 “ 反 马 克 思 主 义 性 质 ” 。 然 而 ， 这 个 项 目 启 动 了 ， 没 有 什 么 能 阻 止 这 个 国 家 不 可 避 免 的 变 化 ， 对 吗?";
			GlobalScript.inst.gameState.data[8] -= 80;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[4] += 150;
			GlobalScript.inst.gameState.data[1] -= 600;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.data[118] = 1;
			GlobalScript.inst.gameState.data[73] += 300;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
