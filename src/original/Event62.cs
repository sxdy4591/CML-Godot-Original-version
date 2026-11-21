using EventsForDLC;
using UnityEngine;

public class Event62 : EventsSecond
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
		name = " 成 吉 思 汗 后 裔 的 问 题";
		if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			text = " 在1949 年 解 放 战 争 胜 利 后 ， 中 国 的 少 数 民 族 聚 居 区 按 照 苏 联 模 式 ， 获 得 了 自 治 地 位 。 其 中 之 一 是 蒙 古 族 居 住 的 内 蒙 古 。 在 所 谓 的 “ 文 化 大 革 命 ” 期 间 ， 中 央 政 府 开 始 强 迫 同 化 蒙 古 族 人 民 ， 导 致 了 当 地 人 民 与 红 卫 兵 的 大 规 模 冲 突 和 在1967-1969 年 的 暴 乱 。1969 年 ， 内 蒙 古 大 部 分 地 区 被 划 入 相 邻 的 中 国 省 份 ， 蒙 古 族 人 口 减 少 到60 万 ， 自 治 区 总 人 口 从1300 万 下 降 到900 万 。 现 在 既 然 中 国 共 产 党 认 识 到 了 这 一 政 策 的 谬 误 ， 内 蒙 古 自 治 区 人 民 代 表 大 会 代 表 和 蒙 古 族 共 产 党 员 们 提 议 ， 纠 正 毛 泽 东 犯 下 的 错 误 ， 恢 复 正 义 ， 把 其 他 省 份 从 自 治 区 取 得 的 土 地 归 还 回 去 ， 并 结 束 同 化 政 策 。 这 显 然 不 会 令 中 国 共 产 党 内 的 左 翼 开 心 ， 但 有 助 于 争 取 民 族 精 英 的 支 持 。 此 外 ， 蒙 古 人 民 共 和 国 和 苏 联 显 然 会 喜 欢 这 一 措 施 。";
		}
		else if (GlobalScript.inst.gameState.modifies[3].active)
		{
			text = " 在1949 年 解 放 战 争 胜 利 后 ， 中 国 的 少 数 民 族 聚 居 区 按 照 苏 联 模 式 ， 获 得 了 自 治 地 位 。 其 中 之 一 是 蒙 古 族 居 住 的 内 蒙 古 。 在 1966 年 至1976 年 期 间 ， 中 央 政 府 开 始 强 迫 同 化 蒙 古 族 人 民 ， 导 致 了 当 地 人 民 与 红 卫 兵 的 大 规 模 冲 突 和 在1967-1969 年 的 暴 乱 。1969 年 ， 内 蒙 古 大 部 分 地 区 被 划 入 相 邻 的 中 国 省 份 ， 蒙 古 族 人 口 减 少 到60 万 ， 自 治 区 总 人 口 从1300 万 下 降 到900 万 。 现 在 既 然 中 国 共 产 党 认 识 到 了 这 一 政 策 的 谬 误 ， 内 蒙 古 自 治 区 人 民 代 表 大 会 代 表 和 蒙 古 族 共 产 党 员 们 提 议 ， 纠 正 毛 泽 东 犯 下 的 错 误 ， 恢 复 正 义 ， 把 其 他 省 份 从 自 治 区 取 得 的 土 地 归 还 回 去 ， 并 结 束 同 化 政 策 。 这 显 然 不 会 令 中 国 共 产 党 内 的 左 翼 开 心 ， 但 有 助 于 争 取 民 族 精 英 的 支 持 。 此 外 ， 蒙 古 人 民 共 和 国 和 苏 联 显 然 会 喜 欢 这 一 措 施 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[0] = " 这 是 公 平 的 一 步 。 这 正 是 我 们 要 做 的 ！ （ 需 要3 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 绝 不 妥 协 ！";
		}
		button_text[1] = " 对 一 个 少 数 民 族 来 说 ， 这 简 直 就 是 种 特 权 ！ 拒 绝";
		if (GlobalScript.inst.gameState.data[56] != 1)
		{
			button_text[2] = " 领 土 将 被 归 还 ， 但 同 化 将 不 会 停 止";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 这 不 符 合 中 国 共 产 党 的 民 族 政 策 ！";
		}
		if (GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 3)
		{
			button_text[3] = " 停 止 同 化 是 有 道 理 的 ， 但 我 们 不 会 归 还 领 土 。 （ 需 要1 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 这 不 符 合 中 国 共 产 党 的 民 族 政 策 ！";
		}
		if (GlobalScript.inst.gameState.data[50] != 24 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[18] < 23)
		{
			button_text[4] = " 到 了 认 真 解 决 小 型 自 治 区 民 族 问 题 的 时 候 了 ！ 停 止 所 有 过 度 的 措 施 ！ （ 需 要6 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 中 国 没 有 民 族 问 题 ！ 它 在50 年 代 就 一 劳 永 逸 地 解 决 了";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 成 吉 思 汗 后 裔 的 问 题";
		switch (result_num)
		{
		case 0:
			text = " 今 天 ， 全 国 人 民 代 表 大 会 常 务 委 员 会 和 中 共 中 央 发 布 了 一 项 联 合 决 定 ， 根 据 该 决 定 ，1969 年 内 蒙 古 所 有 被 转 移 到 周 边 省 份 的 领 土 将 被 归 还 。 蒙 古 族 的 同 化 政 策 也 停 止 了 ， 他 们 的 民 族 文 化 、 传 统 生 活 方 式 和 民 族 经 济 得 到 了 保 障 。 成 吉 思 汗 陵 、 王 昭 君 墓 、 乌 丹 寺 和 五 塔 寺 再 次 开 放 参 观 ， 传 统 的 那 达 慕 大 会 重 新 兴 起 ， 蒙 语 版 《 内 蒙 古 日 报 》 开 始 出 版 。 这 一 步 在 自 治 区 得 到 了 热 烈 的 响 应 ， 并 得 到 蒙 古 人 民 共 和 国 和 苏 联 的 支 持 ， 赞 许 了 我 国 民 族 政 策 的 改 变 。 是 的 ， 党 内 左 派 对 此 的 看 法 非 常 不 同 ， 而 我 们 的 预 算 不 得 不 承 担 额 外 的 开 支 。";
			GlobalScript.inst.gameState.data[1] -= 80;
			GlobalScript.inst.gameState.data[57] += 50;
			GlobalScript.inst.gameState.data[4] += 20;
			GlobalScript.inst.gameState.data[3] += 60;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].relations += 30;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.data[92] += 10;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 20;
			break;
		case 1:
			text = " 中 央 对 内 蒙 古 问 题 不 感 兴 趣 。 对 蒙 古 族 的 同 化 在 自 治 区 继 续 进 行 着 ， 越 来 越 多 的 中 国 移 民 来 到 自 治 区 ， 他 们 很 快 将 在 该 自 治 区 人 口 内 占 大 多 数 。 形 势 日 趋 恶 化 ， 蒙 古 裔 持 不 同 政 见 者 正 积 极 吸 引 美 国 和 苏 联 的 注 意 。";
			GlobalScript.inst.gameState.data[1] -= 20;
			GlobalScript.inst.gameState.data[57] -= 150;
			GlobalScript.inst.gameState.data[3] -= 50;
			break;
		case 2:
			text = " 经 过 长 时 间 的 犹 豫 之 后 ， 做 出 了 一 份 折 中 的 决 定 ， 决 定 将1969 年 选 定 的 领 土 归 还 内 蒙 古 ， 但 民 族 政 策 不 变 。 大 体 上 ， 人 们 对 这 一 决 定 反 应 中 立 ， 尽 管 它 引 起 了 一 些 民 族 主 义 党 员 和 蒙 古 人 民 共 和 国 的 不 满 ， 他 们 指 责 我 们 “ 对 蒙 古 人 民 进 行 种 族 灭 绝 ” ， 并 试 图 引 起 苏 联 的 注 意 … …";
			GlobalScript.inst.gameState.data[1] += 10;
			GlobalScript.inst.gameState.data[57] += 10;
			GlobalScript.inst.gameState.data[4] += 30;
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.data[6] -= 5;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			break;
		case 3:
			text = " 经 过 长 时 间 的 犹 豫 之 后 ， 做 出 了 一 份 折 中 的 决 定 ， 停 止 自 治 区 内 对 蒙 古 族 人 口 的 同 化 政 策 ， 但 不 归 还1969 年 划 分 出 去 的 领 土 。 成 吉 思 汗 陵 、 王 昭 君 墓 、 乌 丹 寺 和 五 塔 寺 再 次 开 放 参 观 ， 传 统 的 那 达 慕 大 会 重 新 兴 起 ， 蒙 语 版 《 内 蒙 古 日 报 》 开 始 出 版 。 这 一 决 定 得 到 了 赞 许 ， 尽 管 我 们 的 预 算 不 得 不 增 加 费 用 。";
			GlobalScript.inst.gameState.data[1] += 30;
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.data[6] -= 5;
			GlobalScript.inst.gameState.data[57] += 30;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 10;
			break;
		case 4:
		{
			text = string.Concat(new string[4]
			{
				GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
				" ",
				GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
				" 主 席 对 内 蒙 事 态 真 相 的 揭 露 感 到 震 惊 ， 决 定 更 深 入 地 研 究 国 家 问 题 ， 在 与 内 蒙 、 广 西 壮 族 自 治 区 、 宁 夏 回 族 自 治 区 的 党 和 苏 维 埃 领 导 人 以 及 这 些 地 区 的 代 表 进 行 了 一 系 列 会 谈 后 ， 亲 自 走 访 了 三 个 少 数 民 族 （ 蒙 古 族 、 壮 族 、 回 族 ） 自 治 区 ， 分 别 是 内 蒙 古 、 广 西 壮 族 自 治 区 和 宁 夏 回 族 自 治 区 。 主 席 同 志 回 到 北 京 ， 深 思 熟 虑 ， 通 过 了 “ 中 华 人 民 共 和 国 民 族 政 策 的 概 念 ” ， 取 代 了 具 有 民 族 主 义 本 质 的1952 年 “ 中 华 人 民 共 和 国 实 行 区 域 民 族 自 治 的 基 本 原 则 ” 。 根 据 “ 概 念 ” ， 自 治 区 享 有 更 广 泛 的 权 利 ， 国 家 承 诺 保 护 少 数 民 族 的 民 族 文 化 、 传 统 的 生 活 方 式 和 民 族 经 济 。 增 加 民 族 语 言 的 文 学 和 印 刷 出 版 量 ， 在 所 有 部 门 和 大 学 为 少 数 民 族 分 配 配 额 。 此 外 ， 还 作 出 了 一 个 重 要 的 决 定 — — 不 仅 是 苏 维 埃 当 局 ， 而 且 中 国 共 产 党 的 区 自 治 委 员 会 应 由 少 数 民 族 代 表 领 导 。 所 有 这 些 都 让 你 得 到 了 各 民 族 精 英 们 的 真 诚 支 持 （ 我 们 希 望 他 们 不 会 忘 记 这 种 姿 态 ， 如 果 发 生 什 么 事 的 话 ） ， 得 到 了 苏 联 和 美 国 的 认 可 — — 同 时 也 得 到 了 保 守 派 党 员 的 愤 怒 … …"
			});
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.data[8] -= 60;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.data[57] -= 30;
			GlobalScript.inst.gameState.empires[0].relations += 80;
			GlobalScript.inst.gameState.empires[1].relations += 150;
			GlobalScript.inst.gameState.data[92] += 30;
			ref int reference = ref GlobalScript.inst.gameState.data[18];
			int num = reference;
			reference = num + 1;
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
