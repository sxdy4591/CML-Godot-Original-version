using EventsForDLC;
using UnityEngine;

public class Event76 : EventsSecond
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
		name = " 落 井 下 石 ！";
		text = " 主 席 同 志 ， 来 自 南 斯 拉 夫 的 紧 急 新 闻 ！ 在 科 索 沃 社 会 主 义 自 治 省 ， 阿 尔 巴 尼 亚 族 人 的 大 规 模 暴 动 开 始 了 ， 根 据 我 们 的 信 息 ， 这 是 由 阿 尔 巴 尼 亚 的 特 勤 部 门 “ 西 古 里 米 ” 组 织 的 。 抗 议 者 袭 击 了 行 政 建 筑 ， 警 察 局 和 南 斯 拉 夫 人 民 军 的 驻 军 ， 反 塞 族 的 屠 杀 开 始 了 。 省 领 导 和 科 索 沃 的 共 产 主 义 者 联 盟 的 领 导 层 并 没 有 怎 么 抵 抗 ， 这 实 际 上 是 在 支 持 抗 议 者 。 南 斯 拉 夫 主 席 团 在 贝 尔 格 莱 德 举 行 了 紧 急 会 议 ， 决 定 强 力 镇 压 “ 反 革 命 分 离 主 义 叛 乱 ” 。 在 铁 托 死 后 ， 南 斯 拉 夫 的 局 势 开 始 恶 化 ， 看 起 来 凡 尔 赛 条 约 创 造 出 来 的 怪 物 正 在 解 体 。 也 许 我 们 应 该 再 推 一 把 ， 把 他 推 入 深 渊 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[0] = " 我 们 会 在 外 交 上 支 持 科 索 沃 分 离 主 义 者 ， 但 仅 此 而 已";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 那 不 是 我 们 的 问 题";
		}
		if (((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.allcountries[20].proprc)
		{
			button_text[1] = " 向 阿 尔 巴 尼 亚 提 供 援 助 ， 帮 助 其 将 科 索 沃 从 南 斯 拉 夫 分 离 出 来 （ 需 要5 特 工 网 络 ， 需 要5 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 要 帮 助 阿 尔 巴 尼 亚 ？";
		}
		button_text[2] = " 不 干 涉";
		if (GlobalScript.inst.gameState.data[9] >= 100)
		{
			button_text[3] = " 我 们 将 提 供 特 勤 和 经 济 援 助 来 帮 助 科 索 沃 分 离 主 义 者 （ 需 要10 特 工 网 络 ，10 百 万 预 算 ） 。";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 对 南 斯 拉 夫 事 务 不 感 兴 趣";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 落 井 下 石 ！";
		switch (result_num)
		{
		case 0:
			text = " 中 华 人 民 共 和 国 外 交 部 发 布 公 报 ， 正 式 向 科 索 沃 示 威 者 表 示 支 持 ， 因 为 “ 抗 议 者 享 有 合 法 的 民 主 权 利 ” 。 这 引 起 了 南 斯 拉 夫 的 强 烈 愤 慨 ， 南 斯 拉 夫 指 责 中 国 干 涉 其 内 政 ， 它 领 导 下 的 不 结 盟 运 动 指 责 中 国 为 “ 毛 主 义 霸 权 ” 。 苏 联 和 美 国 忽 视 了 这 一 点 ， 主 要 是 因 为 南 斯 拉 夫 社 会 主 义 联 邦 共 和 国 不 在 任 何 一 个 集 团 中 的 “ 独 立 ” 立 场 。 科 索 沃 进 入 紧 急 状 态 ， 部 分 南 斯 拉 夫 人 民 军 进 入 ， 到4 月3 日 ， 该 省 所 有 抗 议 活 动 都 已 被 镇 压 ， 并 恢 复 了 秩 序 。 南 斯 拉 夫 当 局 发 现 了 阿 尔 巴 尼 亚 介 入 的 证 据 。 对 分 离 主 义 者 的 大 规 模 清 洗 开 始 了 。";
			GlobalScript.inst.gameState.data[6] += 20;
			break;
		case 3:
			if (GlobalScript.inst.dlc[3])
			{
				text = " 在 政 治 局 内 部 会 议 上 ， 决 定 了 利 用 南 斯 拉 夫 问 题 ， 为 科 索 沃 分 离 主 义 者 提 供 全 面 协 助 。 我 们 决 定 将 驻 贝 尔 格 莱 德 使 馆 作 为 “ 中 转 站 ” 。 科 索 沃 分 离 主 义 者 在 得 到 我 们 提 供 的 武 器 和 资 金 后 ， 开 始 对 部 分 南 人 民 军 和 民 兵 进 行 武 装 抵 抗 。 普 里 什 蒂 纳 爆 发 了 最 残 酷 的 巷 战 ， 南 斯 拉 夫 军 队 积 极 地 使 用 炮 兵 和 航 空 兵 ， 结 果 导 致 城 市 被 毁 。 “ 普 里 什 蒂 纳 在 燃 烧 ” 的 新 闻 传 遍 全 球 ， 严 重 打 击 了 南 斯 拉 夫 联 邦 的 国 际 威 望 ， 尽 管 叛 军 在 六 月 份 最 终 被 镇 压 下 去 ， 却 需 要 大 量 资 金 重 建 这 个 地 区 ， 而 南 斯 拉 夫 拿 不 出 这 笔 钱 。|1981 年4 月 ， 在 南 斯 拉 夫 联 邦 主 席 团 和 联 邦 宪 法 秩 序 保 护 委 员 会 的 一 次 会 议 上 ， 拉 扎 尔 · 科 利 舍 夫 斯 基 说 ： “ 我 们 必 须 充 分 认 识 到 这 一 论 题 的 荒 谬 和 极 端 反 动 性 质 — — 即 塞 尔 维 亚 越 弱 ， 科 索 沃 越 强 （ 或 我 们 的 任 何 其 他 共 和 国 ） 。 以 及 另 一 论 题 — — 科 索 沃 在 塞 尔 维 亚 的 自 治 权 越 小 ， 塞 尔 维 亚 越 强 大 。 这 也 可 以 说 是 关 于 — — 塞 尔 维 亚 越 弱 ， 南 斯 拉 夫 越 强 这 一 论 题 。 ” 民 族 主 义 者 开 始 加 强 他 们 在 这 个 国 家 的 地 位 …";
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[900], "\n");
			}
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[86] -= 4;
			GlobalScript.inst.gameState.empires[0].power += 20;
			break;
		case 1:
			text = " 我 们 在 地 拉 那 的 大 使 照 会 恩 维 尔 · 霍 查 与 拉 米 兹 · 阿 利 雅（ 西 古 里 米 领 导 人 ） 两 位 同 志 ， 并 向 他 们 表 达 了 中 方 的 合 作 意 愿 。";
			if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50 && GlobalScript.inst.gameState.data[9] >= 50)
			{
				text = " 他 们 同 意 我 们 的 帮 助 。 在 阿 尔 巴 尼 亚 ， 中 国 国 安 部 的 一 批 员 工 已 经 抵 达 ， 很 快 与 西 古 里 米 建 立 了 合 作 关 系 。 结 果 ， 尽 管 南 斯 拉 夫 人 民 军 成 功 地 镇 压 了 叛 乱 ， 但 他 们 并 不 能 完 全 平 定 该 省 。 我 们 可 以 在 那 里 再 次 发 动 暴 乱 。";
				GlobalScript.inst.gameState.empires[0].power += 10;
				GlobalScript.inst.gameState.data[86] -= 2;
				GlobalScript.inst.gameState.data[8] -= 50;
				GlobalScript.inst.gameState.data[9] -= 50;
			}
			else
			{
				text = " 不 幸 的 是 ， 他 们 拒 绝 我 们 的 帮 助 ， 声 称 我 们 的 特 工 在 南 欧 力 量 太 弱 。 叛 乱 很 快 被 镇 压 下 去 ， 南 斯 拉 夫 国 家 安 全 局 揭 露 并 挫 败 了 三 条 主 要 的 西 古 里 米 情 报 网 络 ， 取 缔 了 一 个 非 法 的 “ 斯 派 — 霍 查 派 共 产 党 ” ， 对 阿 尔 巴 尼 亚 在 南 斯 拉 夫 的 情 报 部 门 造 成 了 沉 重 打 击 。";
				ref int reference = ref GlobalScript.inst.gameState.data[8];
				int num = reference;
				reference = num + 1;
			}
			break;
		case 2:
			text = " 科 索 沃 进 入 紧 急 状 态 ， 部 分 南 斯 拉 夫 人 民 军 进 入 ， 到4 月3 日 ， 该 省 所 有 抗 议 活 动 都 已 被 镇 压 ， 恢 复 了 秩 序 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
