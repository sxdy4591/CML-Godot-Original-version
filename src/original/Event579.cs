using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event579 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 在 那 墨 西 哥 城";
		text = " 主 席 同 志 ！ 来 自 墨 西 哥 城 的 消 息 。 今 天 ， 墨 西 哥 城 发 生 里 氏7.8 级 大 地 震 。 墨 西 哥 政 府 虽 然 开 展 了 救 灾 行 动 。 但 是 ， 很 明 显 政 府 的 救 灾 行 动 更 关 注 的 是 保 护 公 私 财 产 ， 他 们 对 于 墨 西 哥 底 层 人 民 的 生 命 毫 不 在 乎 ， 米 格 尔 · 德 拉 马 德 里 政 府 因 为 应 对 不 利 、 腐 败 以 及 其 他 渎 职 行 为 ， 其 救 灾 政 策 遭 致 了 墨 西 哥 社 会 乃 至 国 际 社 会 的 广 泛 批 评 。 事 实 上 ， 人 民 已 经 开 始 自 发 地 组 织 成 一 系 列 搜 救 协 调 队 伍 自 主 进 行 灾 后 重 建 。 墨 西 哥 城 是 一 个 有 着1800 万 人 口 的 大 城 市 ， 也 许 ， 我 们 能 做 些 什 么 … … 当 然 ， 这 不 一 定 道 德 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		int num = 0;
		for (int i = 71; i < 84; i++)
		{
			if (a.allcountries[i].proprc)
			{
				num++;
			}
		}
		for (int j = 138; j < GlobalScript.inst.gameState.allcountries.Length; j++)
		{
			if (a.allcountries[j].proprc)
			{
				num++;
			}
		}
		button_text[0] = " 让 我 们 致 以 墨 西 哥 人 民 最 真 切 的 问 候 … …";
		if (a.data[56] == 0 && num >= 7 && a.allcountries[140].parts[0] && a.influencePRC >= 1000)
		{
			button_text[1] = " 让 我 们 开 始 最 后 的 行 动 吧 ， 打 倒PRI ， 摧 毁 这 个 畸 形 的 怪 胎 。";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = "我 们 不 能 干 涉 主 权 国 家 的 内 政";
		}
		if (a.data[31] >= 700 && a.allcountries[1].SubGosstroy == 9 && a.allcountries[140].stab == 2 && a.resultOfEvents[577] == 3 && a.resultOfEvents[578] == 2)
		{
			button_text[2] = " 是 时 候 打 倒 共 济 会 的 傀 儡 了 ！";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = " 2 1 世 纪 回 不 到 1 9 世 纪 。";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 在 那 墨 西 哥 城";
		if (result_num == 0)
		{
			text = " 由 国 家 地 震 局 组 建 的 中 国 地 震 代 表 团 在 1 2 月 份 访 问 了 墨 西 哥 城 。 对 墨 西 哥 城 地 震 发 生 的 原 因 以 及 过 程 进 行 了 科 学 的 判 断 和 分 析 ， 我 们 得 以 从 墨 西 哥 城 地 址 中 得 到 经 验 ， 吸 取 教 训 。 在 1 2 月 1 7 1 日 ， 中 国 地 震 代 表 团 团 长 谢 礼 立 副 教 授 应 墨 西 哥 国 家 电 视 台 的 邀 请 作 了 长 达 2 2 分 钟 的 电 视 直 播 讲 话 。 转 达 了 中 国 广 大 地 震 科 学 工 作 者 对 墨 西 哥 地 震 学 家 和 地 震 工 程 师 以 及 广 大 墨 西 哥 人 民 的 慰 问 … …||因 为 在 地 震 过 程 中 失 败 的 领 导 和 日 益 崩 溃 的 救 济 局 势 ， 米 格 尔 · 德 拉 马 德 里 完 全 失 去 了 人 民 的 一 切 信 任 ， 预 计 ， 下 一 任 总 统 会 是";
			if (!a.allcountries[140].cw)
			{
				text += " 他 的 哈 佛 校 友 者 卡 洛 斯 · 萨 利 纳 斯 。";
				a.allcountries[140].Gosstroy = 3;
				a.allcountries[140].SubGosstroy = 6;
				a.allcountries[140].Vyshi = true;
			}
			else if (a.resultOfEvents[577] == 1)
			{
				text += " 夸 乌 特 莫 克 · 卡 德 纳 斯 。";
				a.allcountries[140].Gosstroy = 2;
				a.allcountries[140].SubGosstroy = 15;
				a.allcountries[140].Vyshi = false;
			}
			else if (a.resultOfEvents[577] == 2)
			{
				text += " 曼 努 埃 尔 · 克 卢 西 耶";
				a.allcountries[140].Gosstroy = 3;
				a.allcountries[140].SubGosstroy = 12;
				a.allcountries[140].Vyshi = true;
			}
			a.data[6] -= 80;
		}
		if (result_num == 1)
		{
			text = " 正 是 看 到 了 墨 西 哥 政 府 公 信 力 面 临 的 危 机 ， 同 时 墨 西 哥 政 局 不 稳 ， 派 系 斗 争 激 烈 之 际 ， 南 方 民 主 共 和 国 的 成 立 ， 宣 告 了 墨 西 哥 政 府 的 武 装 部 队 基 本 被 摧 毁 。 我 们 决 定 开 始 全 面 支 持 墨 西 哥 革 命 。 大 批 中 国 货 轮 进 入 加 勒 比 海 ， 苏 联 人 更 是 欣 喜 若 狂 ， 他 们 也 开 始 迅 速 和 我 方 接 触 并 开 始 敲 定 援 助 事 宜 。 哪 怕 是 不 结 盟 运 动 都 选 择 了 沉 默 。 很 快 ， 墨 西 哥 南 方 解 放 军 发 起 了 对 北 方 革 命 制 度 党 政 府 的 全 面 进 攻 ， 古 巴 军 人 和 秘 鲁 军 人 一 起 出 现 在 战 场 上 ， 甚 至 连 智 利 人 和 委 内 瑞 拉 人 的 身 影 都 出 现 了 。||米 格 尔 · 德 拉 马 德 里 总 统 决 定 向 北 方 邻 居 请 求 帮 助 ， 很 快 ， 墨 西 哥 北 方 局 势 日 益 混 乱 ， 选 举 被 暂 停 ， 一 切 政 治 自 由 都 被 消 灭 。 革 命 制 度 党 丢 下 了 一 切 伪 装 ， 开 始 大 量 的 签 署 与 美 加 的 军 事 合 作 条 约 。 国 际 雇 佣 兵 和 美 国 援 助 开 始 进 入 墨 西 哥 。 毒 品 卡 特 尔 和 地 方 卡 西 克 民 团 开 始 大 规 模 出 现 ， 据 卫 星 观 测 ， 美 军 以 及 开 始 在 德 克 萨 斯 州 边 境 戒 备 … … 此 乃 大 争 之 世 … …";
			a.allcountries[140].parts[1] = true;
			a.ingamewars[46] = new War().Name(" 墨 西 哥 -南 墨 西 哥 之 战").Attacker(" 墨 西 哥 合 众 国 政 府").Defender(" 墨 西 哥 南 方 民 主 共 和 国")
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
			a.data[6] += 80;
			a.empires[0].relations -= 300;
		}
		if (result_num == 2)
		{
			text = "正 是 看 到 了 墨 西 哥 政 府 公 信 力 面 临 的 危 机 ， 我 们 所 笼 络 的 网 络 终 于 开 始 起 到 作 用 了 ： 在 瓜 纳 华 托 州 突 然 兴 起 了 “ 自 由 墨 西 哥 临 时 政 府 ” - 该 州 州 长 只 是 第 一 个 不 满 意 与 P R I 控 制 力 减 弱 的 州 长 ， 很 快 吸 引 到 了 南 方 的 许 多 州 长 的 支 持 ， 发 起 反 叛 。 他 们 指 责 P R I 政 府 剿 匪 剿 共 不 力 ， 以 无 神 论 荼 毒 国 家 多 年 ， 将 国 家 的 尊 严 几 乎 消 磨 殆 尽 。 一 场 内 战 在 墨 西 哥 开 始 了 - 而 新 生 的 “ 自 由 墨 西 哥 政 府 ” 立 刻 获 得 了 来 自 欧 洲 的 法 西 斯 主 义 者 的 承 认 和 支 持 。||米 格 尔 · 德 拉 马 德 里 总 统 决 定 向 北 方 邻 居 请 求 帮 助 ， 而 美 国 立 刻 开 始 封 锁 海 域 ， 以 阻 止 武 器 流 入 墨 西 哥 。 很 快 ， 墨 西 哥 北 方 局 势 日 益 混 乱 ， 选 举 被 暂 停 ， 一 切 政 治 自 由 都 被 消 灭 。 革 命 制 度 党 丢 下 了 一 切 伪 装 ， 开 始 大 量 的 签 署 与 美 加 的 军 事 合 作 条 约 。 国 际 雇 佣 兵 和 美 国 援 助 开 始 进 入 墨 西 哥 。 毒 品 卡 特 尔 和 地 方 卡 西 克 民 团 开 始 大 规 模 出 现 。";
			a.allcountries[140].parts[1] = true;
			a.ingamewars[47] = new War().Name(" 墨 西 哥 内 战").Attacker(" 墨 西 哥 合 众 国 政 府").Defender(" 墨 西 哥 教 权 派")
				.AttackerInfluence(800)
				.DefenderInfluence(200)
				.TickTime(24)
				.AmericanSupportAttacker.CreateWar;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[22] -= 100;
			a.empires[0].relations -= 300;
		}
	}
}
