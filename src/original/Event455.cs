using EventsForDLC;
using UnityEngine;

public class Event455 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 伊 朗 人 质 危 机";
		text = " 在 过 去 的 数 十 年 来 ， 伊 朗 的 沙 阿 一 直 是 美 国 在 中 东 坚 定 的 盟 友 ， 但 是 1 9 7 9 年 的 伊 朗 革 命 却 打 断 了 这 一 切 ， 原 本 美 国 希 望 尝 试 向 伊 朗 新 政 府 建 立 关 系 ， 但 是 1 9 7 9 年 1 0 月 ， 巴 列 维 前 往 美 国 治 疗 淋 巴 瘤 ， 此 事 激 怒 了 伊 朗 的 革 命 者 。 更 加 坐 实 了 其 “ 美 国 人 的 走 狗 ” 这 一 称 号 。\n 1 9 7 9 年 1 1 月   4   日 ， 大 约 有   5 0 0   名 自 称 “ 伊 玛 目 的 门 徒 ” 的 伊 朗 学 生 占 领 了 使 馆 的 主 体 建 筑 。 一 部 分 伊 朗 人 民 党 党 员 也 宣 布 支 持 “ 杂 碎 帝 国 主 义 余 孽 ” 的 行 为 。 从 而 加 入 了 对 大 使 馆 的 占 领 。 为 避 免 引 起 更 大 的 纷 争 ， 美 国 海 军 陆 战 队 卫 兵 只 进 行 了 象 征 性 抵 抗 ， 而 使 馆 馆 员 不 得 不 破 坏 通 讯 设 备 并 将 敏 感 的 档 案 文 件 予 以 销 毁 。 在 9 0 名 使 馆 人 员 中 ， 有 6 6 名 被 扣 ， 其 中 有 3 人 是 在 伊 朗 外 交 部 所 俘 。 暴 乱 人 群 还 对 外 界 展 示 了 从 使 馆 获 得 的 密 文 ， 其 中 有 些 此 前 已 透 过 美 方 的 碎 纸 机 破 坏 ， 后 来 又 由 革 命 军 拼 接 起 来 。 虽 然 人 质 的 处 境 还 算 不 错 ， 但 他 们 时 常 会 被 蒙 上 眼 睛 带 到 当 地 人 和 电 视 镜 头 前 。 \n 伊 朗 政 府 对 此 事 表 默 认 支 持 ， 部 分 革 命 卫 队 甚 至 加 入 了 抗 议 群 众 。 美 国 总 统 吉 米 · 卡 特 已 宣 布 对 伊 朗 进 行 制 裁 。 主 席 同 志 ， 我 们 怎 么 办 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (((GlobalScript.inst.gameState.data[56] >= 1 && GlobalScript.inst.gameState.data[56] <= 3) || (GlobalScript.inst.gameState.data[6] >= 700 && GlobalScript.inst.gameState.data[6] <= 900)) && a.data[8] + a.data[36] >= 100 && a.data[9] >= 100)
		{
			button_text[0] = " 安 抚 伊 朗 人 ， 勒 令 其 放 人";
		}
		else if (GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[6] > 900)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 宁 愿 支 持 伊 朗 人 也 不 帮 帝 国 主 义 者 ！";
		}
		else if (GlobalScript.inst.gameState.data[56] == 4 || GlobalScript.inst.gameState.data[6] < 700)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 很 想 帮 助 他 们 ， 但 不 至 于 做 这 么 过 分 的 事 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 余 力 再 帮 他 们 了 ！";
		}
		if (GlobalScript.inst.gameState.data[56] >= 3 && GlobalScript.inst.gameState.data[6] <= 700 && a.data[22] >= 150 && a.data[9] >= 100)
		{
			button_text[1] = " 我 们 派 遣 人 员 去 营 救";
		}
		else if (GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[6] > 900)
		{
			Object.Destroy(button[1]);
			button_text[1] = "  和 美 国 人 一 起 行 动 ， 下 一 步 是 什 么 ， 帮 他 们 镇 压 革 命 者 吗 ？";
		}
		else if (GlobalScript.inst.gameState.data[56] < 3 || GlobalScript.inst.gameState.data[6] > 700)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 必 要 这 么 为 美 国 人 卖 命";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 余 力 再 帮 他 们 了 ！";
		}
		if (GlobalScript.inst.gameState.data[56] < 2 && a.data[9] >= 100)
		{
			button_text[2] = " 火 上 浇 油 ， 激 化 时 局";
		}
		else if (GlobalScript.inst.gameState.data[56] >= 2)
		{
			Object.Destroy(button[2]);
			button_text[2] = " 你 脑 子 是 进 水 了 ？ 帮 伊 朗 做 这 种 事 ？";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 没 有 余 力 再 帮 他 们 了 ！";
		}
		button_text[3] = " 让 杨 基 佬 自 个 头 疼 去 吧 ， 我 们 还 有 自 己 的 事 要 搞 。";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 伊 朗 人 质 危 机";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 外 交 人 员 的 斡 旋 下 ， 伊 朗 方 面 终 于 宣 布 释 放 人 质 ， 美 国 方 面 也 同 意 支 付 一 部 分 赔 偿 金 ， 并 保 证 在 王 室 康 复 后 将 其 返 还 至 伊 朗 ， 尽 管 我 们 知 道 这 不 太 可 能 发 生 。\n 这 场 风 波 对 美 国 大 选 造 成 了 一 点 影 响 ， 但 是 由 于 伊 朗 方 面 和 民 主 党 人 处 理 的 及 时 ， 所 以 对 民 主 党 人 的 影 响 并 不 大 ， 尽 管 如 此 ， 这 依 然 遭 到 伊 朗 民 间 的 强 烈 反 对 ， 认 为 这 是 一 种 妥 协 。 而 在 此 之 后 ， 由 于 美 国 政 府 并 未 兑 现 诺 言 ， 伊 朗 外 交 人 员 对 于 美 国 的 指 责 也 开 始 多 了 起 来 ， 甚 至 民 间 有 很 多 自 发 的 活 动 ， 开 始 针 对 美 国 进 行 恐 怖 袭 击 ， 伊 朗 和 美 国 的 关 系 也 自 此 降 低 到 了 冰 点 。\n 随 着 巴 列 维 国 王 的 离 开 ， 西 亚 将 迎 来 新 的 大 洗 牌 … …";
			a.influencePRC += 50;
			a.data[6] -= 50;
			a.empires[0].relations += 100;
			a.empires[1].relations -= 100;
			a.data[8] -= 100;
			a.data[9] -= 100;
			break;
		case 1:
			text = " 看 样 子 ， 伊 朗 人 并 不 打 算 释 放 人 质 ， 那 只 能 我 们 亲 自 出 手 了 ， 我 们 开 始 同 五 角 大 楼 方 面 有 秘 密 的 来 往 ， 进 行 一 次 联 合 人 质 拯 救 工 作 。 在 双 方 参 谋 部 意 见 的 交 换 之 下 ， 制 定 出 了 一 份 详 细 的 人 质 拯 救 计 划 ， 代 号 “ 鹰 爪 行 动 ”\n 执 行 这 一 方 案 的 美 军 部 队 主 力 是 三 角 洲 部 队 和 陆 军 游 骑 兵 ， 他 们 虽 然 存 在 着 人 数 不 足 的 问 题 ， 但 这 并 不 是 主 要 问 题 ， 最 主 要 的 是 ， 他 们 并 不 掌 握 足 够 的 伊 朗 情 报 ， 这 就 需 要 我 们 的 情 报 人 员 加 大 调 查 了\n 看 样 子 ， 这 次 计 划 实 施 的 很 成 功 ， 我 们 的 特 勤 成 功 的 从 伊 朗 这 里 搜 集 到 了 足 够 的 情 报 ， 也 使 得 最 终 三 角 洲 部 队 和 陆 军 游 骑 兵 最 终 顺 利 的 完 成 了 这 次 行 动 。 这 场 顺 利 的 行 动 保 住 了 吉 米 · 卡 特 的 脸 面 。 但 也 因 这 个 问 题 ， 使 得 伊 朗 方 面 谴 责 美 方 侵 犯 了 伊 朗 的 主 权 ， 看 来 这 一 问 题 仍 然 需 要 等 待 时 间 解 决 。";
			a.influencePRC += 80;
			a.data[6] -= 100;
			a.empires[0].relations += 150;
			a.empires[1].relations -= 150;
			a.data[22] -= 150;
			a.data[9] -= 100;
			break;
		case 2:
			text = " 伊 朗 人 是 不 会 放 人 了 ， 当 然 ， 我 们 也 不 会 在 乎 这 件 事 。 在 我 们 的 干 涉 下 ， 这 件 事 却 有 了 新 的 进 展 ： 我 们 开 始 积 极 地 怂 恿 伊 朗 人 进 行 撕 票 行 为 ， 并 且 我 们 也 参 与 了 这 场 行 动 ， 这 对 于 美 帝 来 说 ， 绝 对 是 一 场 巨 大 的 精 神 刺 激 ， 没 有 人 会 愿 意 受 这 种 屈 辱 的 ， 即 便 对 方 是 卡 特 ， 美 方 即 刻 宣 布 ， 要 对 伊 朗 进 行 “ 无 限 制 制 裁 ” ， 直 到 伊 朗 对 此 事 进 行 道 歉 为 止 。\n 对 于 美 国 政 界 来 说 ， 这 等 炸 裂 的 消 息 就 足 够 轰 动 全 国 了 ， 共 和 党 人 士 常 常 拿 着 这 个 来 指 责 民 主 党 ， 指 责 民 主 党 在 对 外 方 面 不 够 强 硬 、 不 能 保 护 海 外 侨 民 利 益 等 等 ， 可 以 说 ， 就 凭 这 一 事 ， 民 主 党 就 别 想 赢 下 下 一 届 大 选 了 ， 共 和 党 人 士 宣 称 ： 一 旦 他 们 上 台 ， 就 会 对 伊 朗 进 行 一 次 惩 罚 性 战 争 。";
			a.influencePRC += 50;
			a.data[6] += 100;
			a.empires[0].relations -= 100;
			a.data[9] -= 100;
			break;
		case 3:
			text = " 这 一 次 进 展 在 我 们 的 意 料 之 中 ， 尽 管 卡 特 发 誓 他 将 保 护 人 质 的 性 命 ， 但 是 他 能 做 的 却 很 少 。 1 9 8 0 年 2 月 ， 伊 朗 向 美 国 提 出 了 一 系 列 要 求 作 为 释 放 人 质 的 条 件 ， 其 中 包 括 ： 遣 返 被 废 黜 的 国 王 ， 向 伊 朗 做 出 一 些 外 交 姿 态 包 括 为 此 前 美 国 在 伊 朗 的 一 系 列 行 为 道 歉 ， 并 保 证 今 后 不 再 干 涉 伊 朗 。 卡 特 知 道 这 些 要 求 自 己 是 很 难 满 足 伊 朗 人 的 ， 于 是 开 始 通 过 走 第 三 国 政 府 的 渠 道 ， 公 开 寻 求 同 伊 朗 的 谈 判 ， 同 时 ， 他 批 准 了 一 项 代 号 “ 鹰 爪 行 动 ” 的 跨 军 种 联 合 秘 密 救 助 行 动 。 但 是 在 工 作 中 出 现 了 很 多 问 题 ， 所 以 这 场 行 动 显 而 易 见 的 失 败 了 … …\n 虽 然 谈 判 还 在 僵 持 着 ， 但 还 是 不 出 意 外 的 出 意 外 了 ， 巴 列 维 国 王 在 埃 及 逝 世 ， 使 伊 朗 失 去 了 强 硬 态 度  。 最 终 ， 人 质 安 全 的 回 到 了 美 国 。 并 解 冻 了 此 前 所 冻 结 的 8 0 亿 财 产 。\n 至 少 大 家 都 没 有 受 到 什 么 损 失 ， 对 吧 ？";
			break;
		}
	}
}
