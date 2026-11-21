using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event578 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 萨 帕 塔 的 孩 子 们 … …";
		text = " 主 席 同 志 ， 来 自 墨 西 哥 合 众 国 恰 帕 斯 州 的 消 息 。 今 天 ， E Z L N （ 萨 帕 塔 民 族 解 放 军 ） 在 恰 帕 斯 州 成 立 了 ， 该 组 织 在 部 分 成 员 上 也 与 7 0 年 代 的 左 翼 游 击 队 存 在 一 定 的 继 承 关 系 。 不 出 我 们 所 料 ， 作 为 对 外 国 技 术 和 投 资 都 有 较 高 依 赖 的 国 家 ， 跨 国 公 司 与 当 地 原 住 民 的 矛 盾 极 为 突 出 ， 随 着 卡 西 克 （ 一 种 墨 西 哥 地 方 豪 强 ） 势 力 的 发 展 ， 当 地 的 原 住 民 同 时 受 到 来 自 外 国 资 本 、 当 地 腐 败 地 主 和 政 府 的 三 重 欺 压 。 自 从 阿 夫 萨 隆 · 卡 斯 特 利 亚 诺 斯 · 多 明 戈 斯 担 任 该 州 州 长 后 ， 当 地 政 治 暴 力 显 著 上 升 。 我 们 是 否 要 支 持 这 些 墨 西 哥 贫 苦 农 工 的 斗 争 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
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
			if (a.allcountries[j].proprc && j != 145)
			{
				num++;
			}
		}
		if (a.data[56] == 0 && a.allcountries[149].proprc && a.resultOfEvents[577] == 0 && a.influencePRC >= 800)
		{
			button_text[0] = " 让 他 们 看 看 ， 萨 帕 塔 回 来 了 ， 给 新 自 由 主 义 来 上 一 枪 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 鞭 长 莫 及 啊 ……";
		}
		if (a.data[56] >= 1 && a.data[56] <= 3 && a.influencePRC >= 500)
		{
			button_text[1] = " 声 援 并 支 持 墨 西 哥 农 民 运 动";
		}
		else if (a.data[56] == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = "为 什 么 墨 西 哥 不 能 直 接 走 上 社 会 主 义 的 康 庄 大 道 ？";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 有 必 要 支 持 一 群 流 氓 一 样 的 印 第 安 人";
		}
		if (a.data[31] >= 700)
		{
			button_text[2] = " 我 们 最 好 还 是 把 这 些 乱 民 的 名 单 提 供 给 墨 西 哥 政 府";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 这 未 免 太 残 酷 了";
		}
		button_text[3] = " 墨 西 哥 农 民 的 事 务 没 有 引 起 我 们 的 关 注";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 萨 帕 塔 的 孩 子 们 … …";
		a.allcountries[140].Gosstroy = 3;
		a.allcountries[140].SubGosstroy = 12;
		int num = 0;
		if (result_num == 0)
		{
			text = "借 助 E Z L N 的 老 相 识 ， 新 崛 起 的 人 民 革 命 军 迅 速 和 E Z L N 搭 上 了 关 系 ， 游 击 活 动 开 始 变 得 更 加 广 泛 和 激 进 ， 随 着 墨 西 哥 经 济 的 进 一 步 下 行 ， 当 地 工 人 以 及 贫 困 农 民 很 快 加 入 了 人 民 革 命 军 的 左 翼 地 下 小 组 。 得 益 于 我 国 慷 慨 的 援 助 ， 有 组 织 的 游 击 队 迅 速 发 展 壮 大 并 和 来 自 城 市 的 工 人 和 原 住 民 以 外 的 地 方 贫 农 结 成 同 盟 。 很 快 ， 从 原 住 民 地 区 开 始 蔓 延 的 游 击 活 动 超 出 了 当 地 警 察 和 安 全 部 队 所 能 控 制 的 界 限 ， 甚 至 发 生 了 效 法 7 0 年 代 穷 人 党 游 击 队 的 绑 架 活 动 — — 人 民 革 命 军 大 规 模 地 绑 架 墨 西 哥 政 治 家 和 地 方 公 务 员 ， 开 展 一 系 列 旨 在 摧 毁 墨 西 哥 政 府 行 政 能 力 的 行 动 。 墨 西 哥 政 府 从 全 国 调 集 了 数 万 名 士 兵 进 驻 恰 帕 斯 州 并 展 开 大 规 模 的 “ 清 乡 活 动 ” ， 然 而 人 民 革 命 军 不 会 屈 服 ， 决 定 给 来 犯 之 敌 迎 头 痛 击 ！";
			if (a.allcountries[140].stab == 1)
			{
				num = 100;
			}
			a.ingamewars[45] = new War().Name(" 墨 西 哥 起 义").Attacker(" 墨 西 哥 军 方").Defender(" 人 民 革 命 军")
				.AttackerInfluence(800 - num)
				.DefenderInfluence(200 + num)
				.TickTime(24)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
			a.data[8] -= 80;
			a.data[9] -= 80;
			a.data[22] -= 80;
			a.empires[0].relations -= 200;
			a.allcountries[140].Gosstroy = 0;
			a.allcountries[140].SubGosstroy = 7;
			a.allcountries[140].parts[1] = true;
		}
		if (result_num == 1)
		{
			if (a.resultOfEvents[577] == 1 && a.allcountries[140].cw && a.allcountries[140].stab == 1)
			{
				text = " 很 快 ， 人 民 日 报 刊 登 了 一 批 揭 露 恰 帕 斯 州 原 住 民 和 其 他 边 缘 群 体 受 到 迫 害 的 证 据 。 我 国 的 外 交 部 和 联 合 国 发 言 人 也 开 始 指 责 墨 西 哥 政 府 在 恰 帕 斯 地 区 的 “ 殖 民 主 义 ” 。 墨 西 哥 政 府 没 有 料 到 这 些 事 情 居 然 遭 到 了 中 国 如 此 严 厉 的 指 责 。 很 快 。 墨 西 哥 统 一 社 会 党 和 左 翼 游 击 队 开 始 声 援 当 地 居 民 并 展 开 游 击 活 动 。 这 使 得 墨 西 哥 陆 军 和 联 邦 安 全 局 力 量 在 当 地 迅 速 增 长 … … 地 区 主 教 萨 缪 尔 · 加 西 亚 也 对 当 地 日 益 增 长 的 暴 力 冲 突 感 到 忧 虑 。";
			}
			else
			{
				text = " 很 快 ， 人 民 日 报 刊 登 了 一 批 揭 露 恰 帕 斯 州 原 住 民 和 其 他 边 缘 群 体 受 到 迫 害 的 证 据 。 我 国 的 外 交 部 和 联 合 国 发 言 人 也 开 始 指 责 墨 西 哥 政 府 在 恰 帕 斯 地 区 的 “ 殖 民 主 义 ” 。 墨 西 哥 政 府 没 有 料 到 这 些 事 情 居 然 会 遭 到 中 国 如 此 严 厉 的 指 责 。 现 在 ， 国 际 组 织 开 始 呼 吁 改 善 墨 西 哥 恰 帕 斯 州 原 住 民 和 处 境 以 及 保 护 当 地 特 色 文 化 。 借 此 ， 拉 坎 顿 丛 林 地 区 得 到 了 关 注 。 虽 然 墨 西 哥 政 府 没 有 进 一 步 行 动 ， 但 对 当 地 左 派 活 动 家 的 迫 害 被 停 止 了 。 不 过 ， 这 真 的 有 意 义 吗 ？";
				a.allcountries[140].cw = false;
			}
			a.data[8] -= 50;
		}
		if (result_num == 2)
		{
			text = " 在 M S S 的 积 极 协 调 下 ， 我 们 设 法 获 取 了 一 些 E Z L N 成 员 的 名 单 和 他 们 目 前 的 所 处 地 址 。 很 快 ， 借 助 我 们 与 C I A 的 关 系 ， 我 们 将 名 单 交 给 了 墨 西 哥 政 府 。 我 们 给 予 了 墨 西 哥 一 笔 军 事 和 情 报 援 助 以 支 持 他 们 打 击 全 国 上 下 的 各 种 左 翼 反 对 派 ， 同 时 ， 借 助 我 们 与 右 翼 的 良 好 关 系 ， 我 们 得 以 与 恰 帕 斯 州 的 民 团 开 展 合 作 ， 一 同 开 展 剿 匪 行 动 。 于 是 ， E Z L N 许 多 高 级 成 员 被 联 邦 法 警 逮 捕 和 秘 密 处 决 … … 其 中 就 包 括 所 谓 的 副 司 令 马 科 斯 。 现 在 ， 拉 坎 顿 地 区 的 原 住 民 运 动 衰 弱 了 。 我 们 也 得 以 和 墨 西 哥 政 府 以 及 一 些 强 烈 反 共 的 墨 西 哥 政 党 搭 上 更 好 的 关 系 。";
			a.data[9] -= 30;
			a.allcountries[140].Torg = true;
		}
		if (result_num == 3)
		{
			text = " 很 快 ， 土 地 的 进 一 步 兼 并 和 贫 困 化 席 卷 了 拉 坎 顿 地 区 ， 现 在 ， 墨 西 哥 政 府 既 无 能 力 也 无 意 愿 干 涉 当 地 的 土 地 分 配 。 土 著 居 民 的 生 存 权 仍 然 受 到 威 胁 … … 新 自 由 主 义 经 济 政 策 仍 然 对 这 些 第 三 世 界 国 家 的 基 层 居 民 构 成 威 胁 … …";
		}
	}
}
