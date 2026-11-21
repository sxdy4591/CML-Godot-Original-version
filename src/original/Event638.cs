using EventsForDLC;
using UnityEngine;

public class Event638 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "前 进 ， 安 哥 拉";
		text = "安 哥 拉 是 葡 萄 牙 的 非 洲 殖 民 地 中 最 出 名 的 一 块 。 自 冷 战 以 来 ， 诸 多 超 级 大 国 都 纷 纷 把 这 里 当 做 一 块 棋 盘 ， 就 连 我 国 也 曾 经 在 独 立 战 争 中 支 持 过 该 国 的 反 抗 组 织 。 在 葡 萄 牙 的 康 乃 馨 革 命 之 后 ， 原 先 尚 能 面 对 共 同 敌 人 而 团 结 一 致 的 各 个 团 体 立 刻 陷 入 了 内 斗 中 （ 争 取 卡 宾 达 飞 地 解 放 阵 线 除 外 ， 该 组 织 由 于 丝 毫 不 掩 饰 它 的 分 离 主 义 倾 向 而 被 所 有 势 力 甚 至 葡 萄 牙 所 反 对 ） 。 现 在 随 着 我 们 试 图 在 各 个 战 线 击 败 我 们 的 国 际 对 手 ， 是 时 候 下 定 决 心 支 持 某 一 派 系 了 。 但 就 在 做 决 定 前 ， 还 请 允 许 我 介 绍 一 下 目 前 的 局 势 ：|首 先 是 安 哥 拉 人 民 解 放 运 动 — — 劳 动 党 ， 该 党 是 目 前 的 安 哥 拉 合 法 政 府 。 " + ((a.allcountries[123].level_of_unstab == 100) ? " 得 益 于 我 们 的 支 持 ， 安 哥 拉 共 产 主 义 组 织 得 以 借 壳 上 市 。 该 党 支 持 毛 泽 东 思 想 并 反 对 超 级 大 国 对 南 部 非 洲 的 干 涉 ， 古 巴 驻 军 对 他 们 的 存 在 保 持 担 心 。" : ((a.allcountries[123].level_of_unstab == 200) ? "尼 托 · 阿 尔 维 斯 在 我 们 的 帮 助 下 确 保 了 自 己 对 安 人 运 的 控 制 ， 目 前 该 党 对 我 们 的 路 线 保 有 兴 趣 ， 但 在 关 于 经 济 话 题 上 仍 然 有 值 得 讨 论 的 空 间 。 古 巴 驻 军 对 他 们 的 存 在 保 持 怀 疑 。" : "该 党 由 强 硬 的 亲 苏 派 多 斯 桑 托 斯 控 制 ， 并 获 得 了 古 巴 驻 军 的 支 持 。")) + "|然 后 是 大 名 鼎 鼎 的 争 取 安 哥 拉 彻 底 独 立 联 盟 。 该 党 目 前 由 若 纳 斯 · 萨 文 比 所 统 帅 。 我 们 曾 在 该 党 露 出 真 面 目 前 支 持 过 他 们 。 在 古 巴 军 队 的 攻 势 下 ， 该 党 目 前 退 守 万 博 ， 并 建 立 了 安 哥 拉 民 主 主 义 人 民 共 和 国 。 而 且 白 人 南 非 政 权 也 大 力 支 持 该 组 织 ， 南 非 政 权 的 雇 佣 兵 多 次 越 境 打 击 藏 身 安 哥 拉 的SWAPO 和SWANU 游 击 队 。|随 后 是 安 哥 拉 民 族 解 放 阵 线 ， 这 是 一 个 为 该 国 的 独 立 立 下 汗 马 功 劳 的 组 织 。 党 主 席 奥 尔 登 · 罗 伯 托 曾 是 刚 果 王 国 的 合 法 王 储 ， 但 最 终 毅 然 决 然 的 选 择 踏 足 政 治 而 非 当 皇 太 子 。 该 党 是 非 盟 曾 经 背 书 的 最 早 的 ， 也 一 度 是 最 大 的 安 哥 拉 独 立 力 量 ， 直 到UNITA 的 异 军 突 起 ， 随 后 便 满 满 淡 出 了 视 野 。 不 过 罗 伯 托 的 妹 夫 蒙 博 托 · 塞 塞 · 塞 科 依 然 在 支 持 着 他 们 ， 他 们 也 许 能 够 成 为 我 们 的 盟 友 。|主 席 同 志 ， 我 们 要 支 持 谁 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (a.science[19])
		{
			kolvo_variant = 4;
			if (a.data[56] < 4)
			{
				button_text[0] = "安 哥 拉 向 前 进 ！ 支 持 安 人 运";
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = "要 安 哥 拉 不 要 赤 匪 的 安 哥 拉 ！";
			}
			if (a.data[56] != 4 && a.data[56] != 0)
			{
				button_text[1] = " 社 会 主 义 - 不 结 盟 - 黑 人 性 ！ 支 持 安 盟";
			}
			else if (a.data[56] == 0)
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 被 假 毛 派 害 得 还 不 够 惨 么 ？";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 就 我 而 言 ， 他 也 太 过 份 了";
			}
			if (a.data[56] > 1 && (a.allcountries[117].SubGosstroy == 7 || a.allcountries[117].SubGosstroy == 8))
			{
				button_text[2] = " 土 地 与 自 由 ！ 支 持 安 解 阵";
			}
			else if (a.data[56] <= 1)
			{
				Object.Destroy(button[2]);
				button_text[2] = " 他 不 会 成 为 最 优 解 的";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 安 解 阵 ， 三 振 出 局 ！";
			}
			button_text[3] = "我 还 需 要 想 想 … …";
		}
		else
		{
			kolvo_variant = 4;
			Object.Destroy(button[0]);
			button_text[0] = "";
			Object.Destroy(button[1]);
			button_text[1] = "";
			Object.Destroy(button[2]);
			button_text[2] = "";
			button_text[3] = "我 还 需 要 想 想 … …";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "前 进 ， 安 哥 拉";
		a.allcountries[123].prcpower = 600;
		a.allcountries[123].sovpower = 300;
		a.allcountries[123].usapower = 100;
		if (result_num == 0)
		{
			text = "我 们 决 定 支 持 安 人 运 政 府 ， 很 快 大 量 的 武 器 便 被 送 入 了 罗 安 达 。 不 久 之 后 ， 安 人 运 的 学 员 和 教 官 也 将 来 到 我 国 的 军 校 学 习 作 战 经 验 。 在 我 们 的 号 召 下 ";
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (((i > 53 && i < 69) || (i > 105 && i < 109) || (i > 111 && i < 134) || i == 41 || i == 42 || i == 52 || i == 99 || i == 100 || i == 150 || i == 151 || i == 155 || i == 158) && i != 55 && i != 54 && i != 128 && i != 123 && GlobalScript.inst.gameState.allcountries[i].proprc)
				{
					text += "，";
					text += a.allcountries[i].name;
				}
			}
			text += "纷 纷 愿 意 提 供 资 金 和 弹 药 。 坦 桑 尼 亚 和 赞 比 亚 更 是 成 为 了 安 人 运 政 府 的 后 勤 保 障 基 地 。 相 信 在 不 久 的 将 来 ， 安 哥 拉 将 彻 底 解 放 。";
			a.data[8] -= 100;
			a.data[22] -= 100;
			a.empires[0].relations -= 50;
			a.empires[1].relations += 50;
		}
		if (result_num == 1)
		{
			text = "我 们 决 定 支 持 萨 文 比 和 安 盟 ， 一 如60 年 代 一 样 ， 很 快 大 量 的 武 器 便 被 送 入 了 万 博 。 不 久 之 后 ， 安 人 运 的 学 员 和 教 官 也 将 来 到 我 国 的 军 校 学 习 作 战 经 验 。 但 非 洲 国 家 对 我 们 的 选 择 表 示 十 分 困 惑 和 难 以 理 解 。 但 美 国 高 兴 的 支 持 了 我 们 的 选 择 ， 并 额 外 提 供 了 一 笔 资 金 。 相 信 在 不 久 的 将 来 ， 安 哥 拉 将 彻 底 解 放 。";
			a.data[8] -= 100;
			a.data[22] -= 100;
			a.empires[0].relations += 50;
			a.empires[1].relations -= 100;
		}
		if (result_num == 2)
		{
			text = "我 们 决 定 支 持 罗 伯 托 和 安 解 阵 ， 一 如60 年 代 一 样 ， 很 快 大 量 的 武 器 便 被 赠 送 给 了 蒙 博 托 ， 由 他 转 赠 给 安 解 阵 。 不 久 之 后 ， 安 人 运 的 学 员 和 教 官 也 将 来 到 我 国 的 军 校 学 习 作 战 经 验 。 但 非 洲 国 家 对 我 们 的 选 择 表 示 十 分 困 惑 和 难 以 理 解 。 但 美 国 高 兴 的 支 持 了 我 们 的 选 择 ， 并 额 外 提 供 了 一 笔 资 金 。 相 信 在 不 久 的 将 来 ， 安 哥 拉 将 彻 底 解 放 。";
			a.data[8] -= 100;
			a.data[22] -= 100;
			a.empires[0].relations += 50;
			a.empires[1].relations -= 100;
		}
		if (result_num == 3)
		{
			text = "没 事 的 主 席 同 志 ， 其 实 安 哥 拉 人 并 没 有 那 么 脆 弱。";
			a.event_done[638] = false;
		}
	}
}
