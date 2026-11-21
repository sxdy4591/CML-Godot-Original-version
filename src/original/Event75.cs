using EventsForDLC;
using UnityEngine;

public class Event75 : EventsSecond
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
		name = " 伊 拉 克 核 问 题";
		text = " 刚 刚 从 伊 拉 克 传 来 的 消 息 ， 以 色 列 空 军 在 “ 歌 剧 ” 行 动 中 攻 击 了 “ 塔 木 兹 ” 反 应 堆 ， 将 其 摧 毁 。 由 于 这 次 袭 击 ， 伊 拉 克 的 核 计 划 结 束 了 。 萨 达 姆 现 在 正 在 推 行 一 项 非 常 激 进 的 外 交 政 策 ， 这 将 破 坏 已 经 紧 张 的 中 东 局 势 。 然 而 ， 我 们 或 许 可 以 帮 助 伊 拉 克 继 续 进 行 核 计 划 ， 从 而 在 这 个 战 略 地 区 获 得 一 个 有 用 的 盟 友 。 尽 管 我 不 建 议 依 赖 萨 达 姆 · 侯 赛 因 的 可 靠 性 — — 他 是 与 美 国 、 苏 联 、 我 们 和 不 结 盟 运 动 合 作 的 多 向 政 策 的 著 名 支 持 者 。 有 可 能 ， 即 使 它 拥 有 自 己 的 原 子 弹 也 不 会 改 变 这 一 点 …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8 && a.resultOfEvents[36] != 3 && a.event_done[36]) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7 && a.resultOfEvents[36] != 3 && a.event_done[36]))
		{
			button_text[0] = " 我 们 将 谴 责 空 袭 ， 并 与 侯 赛 因 扩 大 合 作 （ 需 要8 百 万 预 算 ）";
		}
		else if (a.resultOfEvents[36] == 3 && a.event_done[36])
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 不 是 我 们 的 朋 友";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 萨 达 姆 · 侯 赛 因 — — 一 个 独 裁 者 和 沙 文 主 义 者 。 我 们 不 需 要 支 持 他 ！";
		}
		button_text[1] = " 谁 在 乎 ？ 让 萨 达 姆 自 己 给 自 己 擦 屁 股 …";
		if (GlobalScript.inst.gameState.data[12] >= 600 && GlobalScript.inst.gameState.data[89] == 0 && a.resultOfEvents[36] != 3 && a.event_done[36] && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7 && a.resultOfEvents[36] != 3 && a.event_done[36])))
		{
			button_text[2] = " 我 们 将 帮 助 伊 拉 克 恢 复 其 核 计 划 。 让 帝 国 主 义 战 栗 吧 ！ （ 需 要15 百 万 元 ，10 特 工 ）";
		}
		else if (a.resultOfEvents[36] == 3 && a.event_done[36])
		{
			Object.Destroy(button[2]);
			button_text[2] = " 他 不 是 我 们 的 朋 友";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 给 伊 拉 克 核 武 器 ？ ！ 你 想 发 动 第 三 次 世 界 大 战 吗 ？";
		}
		if ((GlobalScript.inst.gameState.data[56] > 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[3] = " 我 们 将 称 许 空 袭 ， 并 谴 责 侯 赛 因 的 军 国 主 义 和 沙 文 主 义";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 不 能 为 犹 太 复 国 主 义 者 的 所 作 所 为 辩 护 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 伊 拉 克 核 问 题";
		switch (result_num)
		{
		case 0:
			text = " 空 袭 结 束 后 ， 萨 达 姆 · 侯 赛 因 在 伊 拉 克 部 长 会 议 的 紧 急 会 议 上 发 表 了 精 彩 的 讲 话 ， 他 在 会 上 说 ： “ 今 天 在 反 应 堆 受 到 的 打 击 对 我 们 来 说 不 是 突 然 的 。 当 然 ， 这 是 痛 苦 的 ， 因 为 它 是 革 命 的 伟 大 成 果 之 一 ， 我 们 长 期 以 来 在 政 治 上 、 科 学 上 、 经 济 上 都 非 常 关 心 。 这 不 是 因 为 他 们 害 怕 伊 拉 克 的 原 子 弹 ， 正 如 特 拉 维 夫 帮 派 的 领 导 人 所 说 ， 但 是 因 为 他 们 害 怕 科 学 、 社 会 、 经 济 、 政 治 、 平 衡 和 紧 凑 的 发 展 ， 而 这 正 是 为 了 建 设 一 个 新 的 伊 拉 克 … … 我 们 没 有 国 际 性 的 一 面 ， 所 以 我 们 会 推 迟 所 有 的 借 口 ， 因 为 打 击 是 针 对 我 们 的 … 你 知 道 为 什 么 会 发 生 战 争 — — 不 仅 仅 是 为 了 给 伊 拉 克 核 反 应 堆 一 个 打 击 ， 而 且 为 了 阻 止 伊 拉 克 的 崛 起 … … 你 也 明 白 为 什 么 战 争 会 继 续 … … ” 我 们 全 力 支 持 萨 达 姆 ， 谴 责 “ 来 自 以 色 列 的 美 国 雇 佣 兵 的 强 盗 袭 击 ” ， 并 建 议 向 伊 拉 克 提 供 经 济 和 军 事 援 助 ， 侯 赛 因 愉 快 地 接 受 了 这 一 提 议 。 尽 管 伊 拉 克 继 续 奉 行 多 向 外 交 政 策 ， 但 在 不 减 少 与 苏 联 和 美 国 的 合 作 的 情 况 下 ， 开 始 转 向 我 们 的 方 向 … … 美 国 在 中 东 的 盟 友 非 常 愤 怒 ， 但 美 国 自 己 却 表 现 得 异 常 平 静 … …";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[8] -= 80;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.allcountries[14].Torg = true;
			return;
		case 1:
			text = " 空 袭 结 束 后 ， 萨 达 姆 · 侯 赛 因 在 伊 拉 克 部 长 会 议 的 紧 急 会 议 上 发 表 了 精 彩 的 讲 话 ， 他 在 会 上 说 ： “ 今 天 在 反 应 堆 受 到 的 打 击 对 我 们 来 说 不 是 突 然 的 。 当 然 ， 这 是 痛 苦 的 ， 因 为 它 是 革 命 的 伟 大 成 果 之 一 ， 我 们 长 期 以 来 在 政 治 上 、 科 学 上 、 经 济 上 都 非 常 关 心 。 这 不 是 因 为 他 们 害 怕 伊 拉 克 的 原 子 弹 ， 正 如 特 拉 维 夫 帮 派 的 领 导 人 所 说 ， 但 是 因 为 他 们 害 怕 科 学 、 社 会 、 经 济 、 政 治 、 平 衡 和 紧 凑 的 发 展 ， 而 这 正 是 为 了 建 设 一 个 新 的 伊 拉 克 … … ” 伊 拉 克 呼 吁 联 合 国 谴 责 以 色 列 的 行 动 ， 萨 达 姆 得 到 了 苏 联 和 美 国 两 个 超 级 大 国 的 支 持 。 安 全 理 事 会 要 求 以 色 列 支 付 赔 偿 金 ， 并 在 未 来 避 免 此 类 行 动 。 在 以 色 列 ， 许 多 反 对 派 成 员 ， 在 西 蒙 · 佩 雷 斯 的 领 导 下 批 评 政 府 的 决 定 。 然 而 ， 国 防 部 长 阿 里 埃 勒 · 沙 龙 对 这 些 批 评 作 出 了 坚 定 的 回 应 ： “ 我 们 军 事 政 策 的 一 个 组 成 部 分 是 坚 决 阻 止 敌 国 获 得 核 武 器 。 因 此 ， 我 们 必 须 将 这 种 威 胁 消 灭 在 萌 芽 状 态 。 ” 根 据 我 们 的 数 据 ， 伊 拉 克 增 加 了 在 苏 联 和 美 国 购 买 武 器 的 数 量 ， 采 取 了 对 其 军 队 进 行 定 性 再 装 备 的 方 法 。";
			GlobalScript.inst.gameState.empires[0].power += 10;
			return;
		case 2:
			text = " 空 袭 结 束 后 ， 萨 达 姆 · 侯 赛 因 在 伊 拉 克 部 长 会 议 的 紧 急 会 议 上 发 表 了 精 彩 的 讲 话 ， 他 在 会 上 说 ： “ 今 天 在 反 应 堆 受 到 的 打 击 对 我 们 来 说 不 是 突 然 的 。 ” 当 然 ， 这 是 痛 苦 的 ， 因 为 它 是 革 命 的 伟 大 成 果 之 一 ， 我 们 长 期 以 来 在 政 治 上 、 科 学 上 、 经 济 上 都 非 常 关 心 。 这 并 不 是 因 为 他 们 害 怕 伊 拉 克 的 原 子 弹 ， 正 如 特 拉 维 夫 帮 派 领 导 人 所 说 ， 而 是 因 为 他 们 害 怕 科 学 、 社 会 、 经 济 、 政 治 、 平 衡 和 紧 凑 的 发 展 ， 而 这 正 是 为 了 建 设 一 个 新 的 伊 拉 克 … … 我 们 没 有 国 际 关 系 ， 所 以 我 们 会 无 视 所 有 的 借 口 ， 因 为 这 次 打 击 是 针 对 我 们 的。” " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 于 决 定 提 供 帮 助 伊 拉 克 恢 复 其 核 计 划 的 提 议 ， 萨 达 姆 欣 然 同 意 。 在 以 七 月 革 命 （ 图 瓦 伊 萨 沙 漠 ） 命 名 的 核 中 心 ， 中 国 工 人 出 现 了 ， 很 快 ， C N P - 2 0 0核 反 应 堆 就 被 运 到 了 那 里 （ 而 “ 摩 萨 德 ” 特 工 试 图 炸 毁 我 们 运 输 船 的 企 图 被 阻 止 了 ） 。 据 我 们 的 科 学 家 称 ， 核 武 器 方 面 的 工 作 正 在 全 面 展 开 ，到 1 9 8 8 年 ， 伊 拉 克 将 拥 有 3 枚 原 子 弹 ，到 1 9 9 5 年 将 有 5 枚。 以 色 列 非 常 愤 怒 ， 指 责“ 汉 民 族 沙 文 主 义 者 ”“ 追 求 世 界 霸 权 ”， 但 苏 联 和 美 国 还 没 有 对 此 作 出 回 应… …";
			if (GlobalScript.inst.gameState.influencePRC < 500)
			{
				text += " 伊 拉 克 核 计 划 引 起 了 国 际 原 子 能 机 构 的 注 意 。 它 指 责 伊 拉 克 违 反 了 不 扩 散 核 武 器 条 约 ， 并 要 求 伊 拉 克 只 能 在 国 际 组 织 控 制 下 和 平 利 用 原 子 能 。 由 于 苏 联 和 美 国 支 持 这 一 要 求 ， 萨 达 姆 · 侯 赛 因 被 迫 同 意 并 取 消 了 制 造 原 子 弹 的 工 作 。 然 而 ， 启 动 和 平 原 子 能 的 计 划 也 失 败 了 — —12 月1 日 ， 以 色 列 空 军 进 行 了 第 二 次 空 袭 ， 反 应 堆 完 全 被 毁 。 因 为 害 怕 丧 失 权 力 ， 萨 达 姆 决 定 站 在 我 们 这 边 。";
				GlobalScript.inst.gameState.data[1] += 50;
				GlobalScript.inst.gameState.empires[1].power -= 10;
				GlobalScript.inst.gameState.data[6] += 80;
				GlobalScript.inst.gameState.data[8] -= 150;
				GlobalScript.inst.gameState.data[9] -= 100;
				GlobalScript.inst.gameState.allcountries[14].prosov = false;
				GlobalScript.inst.gameState.allcountries[14].Torg = true;
				GlobalScript.inst.gameState.allcountries[14].proprc = true;
			}
			else
			{
				text += " 现 在 伊 拉 克 可 能 拥 有 自 己 的 核 武 器 ， 萨 达 姆 · 侯 赛 因 开 始 了 一 场 大 规 模 的 运 动 ， “ 收 回 帝 国 主 义 者 从 我 们 这 里 掠 夺 的 一 切 ” ， “ 从 敌 人 和 犹 太 复 国 主 义 者 那 里 清 洗 国 家 ” 。 伊 拉 克 大 规 模 武 装 起 来 ， 开 始 切 断 外 交 关 系 ， 陷 入 国 际 孤 立 …";
				GlobalScript.inst.gameState.data[1] += 80;
				GlobalScript.inst.gameState.empires[1].power -= 10;
				GlobalScript.inst.gameState.empires[0].power -= 10;
				GlobalScript.inst.gameState.data[6] += 80;
				GlobalScript.inst.gameState.data[8] -= 150;
				GlobalScript.inst.gameState.data[9] -= 100;
				GlobalScript.inst.gameState.data[143] += 2;
				GlobalScript.inst.gameState.influencePRC += 10;
				GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 10;
				GlobalScript.inst.gameState.allcountries[14].prosov = false;
				GlobalScript.inst.gameState.allcountries[14].Torg = true;
			}
			break;
		}
		if (result_num == 3)
		{
			text = " 我 们 完 全 赞 同 以 色 列 对 核 反 应 堆 “ 塔 木 兹 ” 的 空 袭 ， 并 谴 责 萨 达 姆 · 侯 赛 因 在 军 国 主 义 、 大 阿 拉 伯 沙 文 主 义 和 镇 压 库 尔 德 少 数 民 族 问 题 上 的 做 法 。 这 在 党 和 人 民 中 引 起 了 严 重 的 误 解 ， 经 过 多 年 对 以 色 列 政 策 的 批 评 ， 他 们 没 有 想 到 以 色 列 会 得 到 如 此 公 开 的 支 持 。 作 为 回 应 ， 伊 拉 克 部 长 会 议 发 表 了 一 份 公 报 ， 指 责 中 国 “ 支 持 特 拉 维 夫 的 犹 太 复 国 主 义 帮 派 ” ， 并 决 定 断 绝 外 交 关 系 。 我 们 的 大 使 馆 被 强 行 驱 逐 出 巴 格 达 ， 伊 拉 克 增 加 了 在 苏 联 和 美 国 购 买 武 器 的 数 量 ， 并 对 其 军 队 进 行 了 定 性 的 重 新 装 备 。 看 起 来 一 场 新 的 战 争 将 在 中 东 爆 发 …";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[6] -= 40;
			GlobalScript.inst.gameState.influencePRC -= 20;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.allcountries[14].Torg = false;
		}
	}
}
