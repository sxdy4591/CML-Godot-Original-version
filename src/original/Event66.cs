using EventsForDLC;
using UnityEngine;

public class Event66 : EventsSecond
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
		name = " 在 铁 托 之 后 — — 铁 托 啊 ！";
		text = "1980 年1 月3 日 ， 南 斯 拉 夫 社 会 主 义 联 邦 共 和 国 的 创 始 人 、 长 期 领 导 人 、 南 斯 拉 夫 共 产 主 义 者 联 盟 中 央 委 员 会 主 席 约 瑟 普 · 布 罗 兹 · 铁 托 元 帅 在 卢 布 尔 雅 那 的 临 床 中 心 住 院 检 查 腿 部 血 管 。 经 过 两 次 手 术 和 左 腿 截 肢 ， 他 的 病 情 有 所 好 转 ， 但 在2 月 份 ， 铁 托 患 上 了 肺 炎 ： 高 烧 和 胃 、 肠 、 肺 出 血 也 导 致 败 血 症 ，3 月 份 病 情 加 重 。 今 天 走 向 了 终 结 — — 贝 尔 格 莱 德 时 间15:05 卢 布 尔 雅 那 临 床 中 心 心 血 管 疾 病 诊 所 ， 在 他88 岁 生 日 的 前 三 天 ， 约 瑟 普 · 布 罗 兹 · 铁 托 去 世 了 。 葬 礼 将 于5 月8 日 举 行 ， 我 们 需 要 决 定 是 否 有 必 要 派 一 个 代 表 团 去 贝 尔 格 莱 德 ， 或 者 他 值 得 哀 悼 吗 ？ 尽 管 我 们 在 思 想 上 存 在 分 歧 ， 在 外 交 上 也 存 在 差 距 ， 但 铁 托 是 反 法 西 斯 战 争 的 英 雄 之 一 ， 给 他 一 个 铭 记 的 义 务 是 有 道 理 的 。 苏 联 和 美 国 已 经 宣 布 ， 他 们 将 派 出 官 方 政 府 代 表 团 参 加 葬 礼 ， 但 美 国 总 统 卡 特 不 会 去 贝 尔 格 莱 德 … 也 许" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 不 应 该 去 ， 而 应 该 派 出 拥 有 有 限 权 力 的 代 表 团 团 长 姬 鹏 飞 ？";
		if (GlobalScript.inst.gameState.allcountries[20].proprc)
		{
			text += " 然 而 ， 我 们 的 阿 尔 巴 尼 亚 盟 友 已 经 声 明 ， 尽 管 他 们 愿 意 恢 复 与 南 斯 拉 夫 的 贸 易 和 文 化 关 系 ， 但 他 们 将 永 远 不 会 停 止 批 评 “ 修 正 主 义 者 铁 托 和 铁 托 主 义 ” 。 如 果 我 们 派 出 代 表 团 ， 我 们 很 可 能 把 他 们 从 我 们 身 边 赶 走 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 发 文 表 示 悼 念 ， 但 仅 此 而 已";
		if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7) || GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[1] = string.Concat(new string[4]
			{
				GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
				" ",
				GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
				" 同 志 将 亲 率 我 国 政 府 代 表 团 飞 往 贝 尔 格 莱 德"
			});
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = string.Concat(new string[4]
			{
				GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
				" ",
				GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
				" 同 志 不 能 亲 自 飞 去 参 加 修 正 主 义 者 铁 托 的 葬 礼 ！"
			});
		}
		if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 派 出 国 务 院 秘 书 长 姬 鹏 飞 率 领 的 代 表 团 。";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 不 许 派 代 表 团 去 贝 尔 格 莱 德 ！";
		}
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[3] = " 铁 托 死 了 ？ 好 吧 ， 就 这 样 吧 ， 谁 在 乎 呢 ？";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 不 能 不 回 应 他 的 死 亡 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 在 铁 托 之 后 — — 铁 托 啊 ！";
		switch (result_num)
		{
		case 0:
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 在 致 信 中 ， 就 国 家 元 首 铁 托 元 帅 的 逝 世 向 南 斯 拉 夫 主 席 团 、 南 共 联 盟 中 央 和 所 有 南 斯 拉 夫 人 民 表 示 深 切 哀 悼 ， 并 表 示 希 望 恢 复 中 南 “ 友 好 关 系 、 经 济 和 文 化 关 系 ” 。 这 封 信 发 表 在 《 战 斗 报 》 上 ， 在 为 期 七 天 的 哀 悼 结 束 时 ， 我 们 收 到 了 南 斯 拉 夫 主 席 团 的 正 式 回 复 ， 他 们 感 谢 我 们 的 哀 悼 。 但 是 ， 这 对 中 南 关 系 并 没 有 产 生 什 么 影 响 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].relations += 20;
			GlobalScript.inst.gameState.empires[1].relations += 20;
			break;
		case 1:
			text = "5 月7 日 ， 超 过200 个 外 国 代 表 团 抵 达 南 斯 拉 夫 议 会 ， 向 铁 托 元 帅 告 别 。 纪 念 活 动 在5 月8 日 早8 时 结 束 。 同 日12 时 ， 在 仪 仗 队 结 束 后 ， 由 南 斯 拉 夫 主 席 团 和 南 共 联 盟 中 央 成 员 组 成 ，8 名 海 军 上 将 和 南 人 民 军 将 领 抬 着 约 瑟 普 · 布 罗 兹 · 铁 托 的 棺 材 。 南 共 联 盟 中 央 委 员 会 主 席 斯 特 万 · 多 罗 尼 斯 基 发 表 纪 念 铁 托 的 演 讲 ， 随 后 队 伍 沿 着 米 洛 斯 亲 王 大 街 和 十 月 革 命 大 道 前 进 ， 到 达5 月25 日 博 物 馆 。 最 后 ， 南 斯 拉 夫 主 席 团 主 席 拉 扎 尔 · 科 利 舍 夫 斯 基 在 花 房 和 外 国 政 要 看 台 前 ， 发 表 了 演 讲 。 下 午3 点 后 ， 伴 着 国 际 歌 ， 铁 托 的 棺 材 被 抬 入 花 房 ， 从 此 约 瑟 普 · 布 罗 兹 · 铁 托 在 此 安 息 。| 我 国 代 表 团 ， 由" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 和 姬 鹏 飞 带 队 ， 与 南 斯 拉 夫 新 领 导 层 举 行 会 谈 ， 就 恢 复 外 交 、 经 济 和 文 化 关 系 达 成 协 议 。 预 计 拉 扎 尔 · 科 利 舍 夫 斯 基 将 在 半 年 内 回 访 北 京 。 但 是 ， 人 民 不 满 我 们 改 善 同 南 斯 拉 夫 关 系 的 政 策 ， 有 些 人 已 经 把" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 和 赫 鲁 晓 夫 相 提 并 论 … …";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.allcountries[15].Torg = true;
			if (GlobalScript.inst.gameState.allcountries[20].proprc)
			{
				text += " 但 正 如 所 料 ， 阿 尔 巴 尼 亚 领 导 人 立 即 指 责 我 们 为 “ 修 正 主 义 者 ” ， 并 断 绝 了 外 交 关 系 ， 将 我 们 所 有 的 顾 问 都 赶 出 阿 尔 巴 尼 亚 ， 拒 绝 偿 还 我 们 提 供 的 贷 款 。 这 算 什 么 人 哪 ？ … …";
				GlobalScript.inst.gameState.allcountries[20].Torg = false;
				GlobalScript.inst.gameState.allcountries[20].proprc = false;
			}
			break;
		case 2:
			text = "5 月7 日 ， 超 过200 个 外 国 代 表 团 抵 达 南 斯 拉 夫 议 会 ， 向 铁 托 元 帅 告 别 。 纪 念 活 动 在5 月8 日 早8 时 结 束 。 同 日12 时 ， 在 仪 仗 队 身 后 ， 是 南 斯 拉 夫 主 席 团 和 南 共 联 盟 中 央 成 员 ，8 名 海 军 上 将 和 南 人 民 军 将 领 抬 着 约 瑟 普 · 布 罗 兹 · 铁 托 的 棺 材 。 南 共 联 盟 中 央 委 员 会 主 席 斯 特 万 · 多 罗 尼 斯 基 发 表 了 纪 念 铁 托 的 演 讲 ， 随 后 队 伍 沿 着 米 洛 斯 亲 王 大 街 和 十 月 革 命 大 道 前 进 ， 到 达5 月25 日 博 物 馆 。 最 后 ， 南 斯 拉 夫 主 席 团 主 席 拉 扎 尔 · 科 利 舍 夫 斯 基 在 花 房 和 外 国 政 要 看 台 前 ， 发 表 了 演 讲 。 下 午3 点 后 ， 伴 着 国 际 歌 ， 铁 托 的 棺 材 被 抬 入 花 房 ， 从 此 约 瑟 普 · 布 罗 兹 · 铁 托 在 此 安 息 。 南 斯 拉 夫 新 领 导 层 表 示 有 兴 趣 恢 复 与 中 华 人 民 共 和 国 的 关 系 ， 但 姬 鹏 飞 同 志 拒 绝 进 行 任 何 谈 判 ， 理 由 是 他 没 有 得 到 授 权 。  “ 有 可 能 在 以 后 的 某 一 天...... 但 现 在 不 行 ” ， 他 跟 拉 扎 尔 · 科 利 舍 夫 斯 基 如 此 说 道 。 然 而 ， 党 内 不 满 于 我 国 代 表 团 空 手 从 贝 尔 格 莱 德 而 归 的 事 实......";
			GlobalScript.inst.gameState.data[1] -= 30;
			GlobalScript.inst.gameState.empires[1].relations += 30;
			GlobalScript.inst.gameState.data[6] -= 15;
			GlobalScript.inst.gameState.empires[0].relations += 30;
			break;
		case 3:
			text = " 中 国 领 导 人 对 铁 托 的 死 没 有 回 应 ， 甚 至 没 有 表 示 哀 悼 。 这 不 仅 在 南 斯 拉 夫 ， 而 且 在 全 世 界 都 引 起 了 惊 讶 。 面 对 南 斯 拉 夫 通 讯 社 机 构 提 问 的 关 于 为 什 么 会 这 样 做 的 问 题 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 的 回 复 是 “ 无 可 奉 告 … … ”";
			GlobalScript.inst.gameState.data[6] += 10;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
