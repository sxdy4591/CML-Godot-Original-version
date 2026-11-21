using EventsForDLC;
using UnityEngine;

public class Event83 : EventsSecond
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
		name = " 斯 塔 夫 罗 波 尔 农 学 家 的 问 题";
		text = " 我 们 的 特 勤 部 门 设 法 获 得 了 重 要 的 信 息 。 据 了 解 ， 苏 联 的 农 业 问 题 相 当 严 重 ， 今 年 的 强 降 雨 更 加 剧 了 情 况 。 农 业 书 记 费 多 尔 · 库 拉 科 夫 ， 苏 共 中 央 委 员 会 书 记 ， 是 现 任 苏 维 埃 领 导 人 列 昂 尼 德 · 勃 列 日 涅 夫 最 有 可 能 的 继 任 者 之 一 。 根 据 我 方 特 工 获 得 的 信 息 ， 库 拉 科 夫 热 衷 于 积 极 研 究 并 将 匈 牙 利 和 南 斯 拉 夫 的 经 验 引 入 苏 联 农 业 （ 即 分 散 集 体 农 场 和 国 营 农 场 的 管 理 ， 根 据 家 庭 合 同 和 独 资 农 场 创 建 农 业 合 作 社 ） 。 在 即 将 召 开 的 苏 共 中 央 全 会 上 ， 我 们 可 以 以 此 来 诋 毁 他 ， 从 而 从 道 路 上 消 除 这 种 危 险 的 改 革 派 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[0] = " 我 们 将 向 苏 共 中 央 泄 露 情 报 ， 败 坏 库 拉 科 夫 的 名 誉 （ 需 要5 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 这 太 危 险 了 ！";
		}
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[1] = " 我 们 将 在 我 们 的 媒 体 上 发 表 揭 露 库 拉 科 夫 的 材 料 （ 需 要2 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 需 要";
		}
		button_text[2] = " 我 们 会 把 它 留 到 将 来 …";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 斯 塔 夫 罗 波 尔 农 学 家 的 问 题";
		switch (result_num)
		{
		case 0:
		{
			text = " 今 天 的 《 人 民 日 报 》 登 载 了 一 篇 文 章 ， 题 为 《 苏 共 中 央 政 治 局 的 改 革 家 》 ， 其 中 费 奥 多 尔 · 库 拉 科 夫 被 称 为 “ 分 权 马 克 思 主 义 者 ” 、 “ 铁 托 派 的 共 产 主 义 者 ” 、 “ 整 个 国 际 共 产 主 义 和 工 人 运 动 的 危 险 敌 人 ” 。 该 文 章 特 别 强 调 的 事 实 是 ， 库 拉 科 夫 极 有 可 能 在 列 昂 尼 德 · 勃 列 日 涅 夫 死 后 领 导 苏 联 。 与 此 同 时 ， 我 们 的 特 工 部 门 披 露 了 库 拉 科 夫 在 苏 共 中 央 委 员 会 中 的 改 革 愿 望 的 资 料 。 在1977 年7 月 的 中 央 委 员 会 全 体 会 议 上 ， 费 奥 多 尔 · 库 拉 科 夫 被 批 评 并 被 剥 夺 了 所 有 职 务 。 他 患 有 急 性 胃 病 ， 导 致 神 经 系 统 衰 弱 。1977 年7 月17 日 晚 ， 他 突 然 死 于 心 脏 麻 痹 。 如 此 ， 我 们 大 大 削 弱 了 苏 共 内 的 改 革 派 …";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[9] -= 50;
			Leader leader2;
			int support2 = (leader2 = GlobalScript.inst.gameState.empires[1].leaders[3]).support;
			leader2.support = support2 - 1;
			GlobalScript.inst.gameState.data[149] = 1;
			break;
		}
		case 1:
			if (GlobalScript.inst.gameState.empires[1].relations >= 500)
			{
				text = " 我 们 组 织 了 一 场 大 规 模 的 运 动 ， 在 媒 体 上 诋 毁 库 拉 科 夫 。 他 被 冠 以 “ 腐 败 分 子 、 官 僚 主 义 者 、 铁 托 主 义 者 、 野 心 家 、 机 会 主 义 者 、 苏 共 和 中 国 共 产 党 最 大 的 敌 人 、 披 着 羊 皮 的 狼 ” 等 称 号 。 主 席 同 志 在 一 次 讲 话 中 曾 简 短 地 提 到 ， ” 如 果 费 多 尔 · 库 拉 科 夫 这 样 的 人 成 为 苏 联 的 领 导 人 ， 我 们 最 好 什 么 都 不 跟 他 谈 ， 因 为 他 们 反 对 我 们 、 反 对 中 国 共 产 党 、 反 对 中 国 人 民 。 ” 这 引 起 了 苏 共 中 央 委 员 会 对 他 的 强 烈 怀 疑 ， 库 拉 科 夫 被 召 到 党 监 察 委 员 会 与 其 负 责 人 阿 尔 维 德 · 佩 尔 谢 会 谈 。 他 与 大 权 在 身 的 克 格 勃 主 席 尤 里 • 安 德 罗 波 夫 联 手 ， 成 功 破 坏 了 政 治 局 关 于 任 命 摩 尔 多 瓦 共 产 党 中 央 委 员 会 第 一 书 记 的 决 定 — — 事 实 上 ， 他 光 荣 地 被 流 亡 海 外 。 库 拉 科 夫 的 支 持 者 已 开 始 从 高 级 职 位 上 撤 下 ， 转 到 较 低 的 职 位 上 去 。 所 以 ， 他 不 再 是 我 们 事 业 的 阻 碍 … …";
				GlobalScript.inst.gameState.data[1] += 50;
				GlobalScript.inst.gameState.data[8] -= 20;
				Leader leader;
				int support = (leader = GlobalScript.inst.gameState.empires[1].leaders[3]).support;
				leader.support = support - 1;
				GlobalScript.inst.gameState.data[149] = 1;
			}
			else
			{
				text = " 我 们 组 织 了 一 场 大 规 模 的 在 媒 体 上 诋 毁 库 拉 科 夫 的 运 动 。 他 被 冠 以 “ 腐 败 分 子 、 官 僚 主 义 者 、 铁 托 主 义 者 、 野 心 家 、 机 会 主 义 者 、 苏 共 和 中 国 共 产 党 最 大 的 敌 人 、 披 着 羊 皮 的 狼 ” 等 称 号 。 主 席 同 志 在 一 次 讲 话 中 曾 简 短 地 提 到 ， ” 如 果 费 多 尔 · 库 拉 科 夫 这 样 的 人 成 为 苏 联 的 领 导 人 ， 我 们 最 好 什 么 都 不 跟 他 谈 ， 因 为 他 们 反 对 我 们 、 反 对 中 国 共 产 党 、 反 对 中 国 人 民 。 ” 库 拉 科 夫 知 道 这 件 事 后 ， 没 有 像 我 们 计 划 的 那 样 失 去 理 智 ， 他 在 苏 共 中 央 全 会 上 发 表 了 精 彩 的 演 讲 ， 指 责 中 国 “ 诽 谤 列 宁 主 义 的 中 央 委 员 会 ， 意 图 建 立 毛 派 的 霸 权 ， 妄 想 分 裂 苏 联 共 产 党 ， 从 而 制 造 另 一 个 毛 派 的 “ 伪 党 ” ， 又 在 苏 联 暗 中 进 行 反 革 命 行 动 ， 最 终 占 领 西 伯 利 亚 和 远 东 ” 。 凭 借 他 的 简 陋 的 谎 言 ， 他 能 够 糊 弄 包 括 勃 列 日 涅 夫 在 内 的 大 多 数 政 治 局 成 员 ， 并 粉 饰 他 自 己 。";
				GlobalScript.inst.gameState.data[8] -= 20;
			}
			break;
		case 2:
			text = " 什 么 也 没 发 生 。 库 拉 科 夫 继 续 担 任 这 一 职 务 ， 晋 升 到 由 他 在 斯 塔 夫 罗 波 尔 地 区 的 盟 友 米 哈 伊 尔 · 戈 尔 巴 乔 夫 领 导 的 具 有 改 革 思 想 的 党 内 高 层 成 员 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
