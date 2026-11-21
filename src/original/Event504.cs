using EventsForDLC;
using UnityEngine;

public class Event504 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 整 个 波 兰 都 在 摇 滚 ！";
		text = " 在 波 兰 的 联 合 政 府 成 立 之 后 ， 情 况 并 没 有 得 到 明 显 的 好 转 ： 该 国 巨 大 积 累 的 外 债 在 拉 科 夫 斯 基 政 府 下 情 况 没 有 得 到 改 观 ， 政 府 内 的 局 势 已 经 达 到 了 沸 点 ： 通 货 膨 胀 导 致 的 物 价 飞 涨 ， 基 本 生 活 物 品 短 缺 ， 联 合 政 府 不 得 不 重 新 考 虑 紧 缩 政 策 与 冻 结 工 资 等 一 系 列 不 得 人 心 的 政 策 来 解 决 现 有 的 问 题 的 。 在 新 的 色 姆 选 举 时 ， 色 姆 内 几 乎 没 有 联 合 政 府 的 成 员 ！ 在 这 种 情 况 下 ， 统 一 工 人 党 内 部 的 亚 历 山 大 · 克 瓦 希 涅 夫 斯 基 为 首 的 青 年 派 已 经 夺 取 了 党 内 领 导 权 ， 宣 布 建 立 “ 民 主 左 派 联 盟 ” ， 但 是 对 波 兰 统 一 工 人 党 的 命 运 采 取 任 何 声 明 ！ 主 席 同 志 ， 这 很 有 可 能 是 东 欧 多 米 诺 骨 牌 的 第 一 张 …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 天 要 下 雨 ， 娘 要 嫁 人 …";
		if (a.data[56] > 1)
		{
			button_text[1] = " 支 持 波 兰 政 局 的 革 新";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 可 能 为 修 正 主 义 吹 哨";
		}
		if (a.data[56] != 0)
		{
			button_text[2] = " 为 波 兰 提 供 慷 慨 的 财 政 援 助 以 及 帮 助 政 府 稳 定";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 很 反 修 ， 让 走 资 派 滚";
		}
		if (a.empires[1].now_leader == 6 && a.data[56] >= 3)
		{
			button_text[3] = " 支 持 右 翼 候 选 人 推 翻 波 兰 政 局";
			return;
		}
		Object.Destroy(button[3]);
		button_text[3] = " 苏 联 不 会 就 眼 睁 睁 看 着 的";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 整 个 波 兰 都 在 摇 滚 ！";
		if (result_num == 0)
		{
			text = " 很 快 ， 新 的 总 统 选 举 发 生 ， 亚 历 山 大 · 克 瓦 希 涅 夫 斯 基 率 领 的 “ 民 主 左 派 联 盟 ” 打 着 反 对 紧 缩 和 腐 败 的 工 会 领 导 层 ， 以 及 自 由 意 志 社 会 主 义 的 口 号 赢 得 了 选 举 ， 但 是 一 上 台 ， 该 政 府 立 即 开 始 大 规 模 私 有 化 ， 聘 请 芝 加 哥 经 济 学 派 ， 实 行 “ 休 克 疗 法 ” … . 食 物 价 格 开 始 以 1 0 0 0 % 的 速 度 飙 升 。";
			if (a.empires[1].now_leader == 6)
			{
				text += "||莫 斯 科 对 发 生 的 事 情 表 示 欢 迎 。 克 瓦 希 涅 夫 斯 基 正 在 试 图 向 莫 斯 科 宣 誓 表 示 自 我 为 “ 社 会 主 义 开 放 与 活 力 的 橱 窗 ” - 而 与 此 同 时 ， 戈 尔 巴 乔 夫 计 划 将 波 兰 作 为 寻 访 东 欧 的 第 一 站 ， 他 称 呼 发 生 在 哪 里 的 事 情 是 “ 未 来 走 向 民 主 和 平 的 新 社 会 主 义 世 界 的 前 兆 ” 。";
			}
			else
			{
				text += "||莫 斯 科 对 发 生 的 事 情 感 到 担 忧 。 也 许 很 快 ， 我 们 要 看 到 第 三 次 “ 华 沙 之 春 ” 的 发 生 … 但 目 前 为 止 ， 克 瓦 希 涅 夫 斯 基 正 在 试 图 向 莫 斯 科 宣 誓 表 示 自 我 为 “ 社 会 主 义 开 放 与 活 力 的 橱 窗 ” - 这 能 阻 止 即 将 到 来 的 干 预 吗 ？";
			}
			a.empires[0].power += 50;
			a.empires[1].power -= 50;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 12;
		}
		if (result_num == 1)
		{
			text = "  我 方 外 交 部 官 方 支 持 克 瓦 希 涅 夫 斯 基 的 崛 起 。 “ 在 当 代 波 兰 剧 烈 变 化 的 历 史 进 程 中 ， 在 人 生 的 崎 岖 坎 坷 的 旅 途 中 ， 克 瓦 希 涅 夫 斯 基 始 终 朝 气 蓬 勃 、 锐 意 进 取 ， 始 终 站 在 为 国 家 为 民 族 兴 盛 而 奋 斗 的 前 沿 。 ” - 这 是 我 们 的 报 纸 上 对 他 的 描 述 。 ||很 快 ， 新 的 总 统 选 举 发 生 ， 亚 历 山 大 · 克 瓦 希 涅 夫 斯 基 率 领 的 “ 民 主 左 派 联 盟 ” 打 着 反 对 紧 缩 和 腐 败 的 工 会 领 导 层 ， 以 及 自 由 意 志 社 会 主 义 的 口 号 赢 得 了 选 举 ， 但 是 一 上 台 ， 该 政 府 立 即 开 始 大 规 模 私 有 化 ， 聘 请 芝 加 哥 经 济 学 派 ， 实 行 “ 休 克 疗 法 ” … . 食 物 价 格 开 始 以 1 0 0 0 % 的 速 度 飙 升 。";
			if (a.empires[1].now_leader == 6)
			{
				text += "||莫 斯 科 对 发 生 的 事 情 表 示 欢 迎 。 克 瓦 希 涅 夫 斯 基 正 在 试 图 向 莫 斯 科 宣 誓 表 示 自 我 为 “ 社 会 主 义 开 放 与 活 力 的 橱 窗 ” - 而 与 此 同 时 ， 戈 尔 巴 乔 夫 计 划 将 波 兰 作 为 寻 访 东 欧 的 第 一 站 ， 他 称 呼 发 生 在 哪 里 的 事 情 是 “ 未 来 走 向 民 主 和 平 的 新 社 会 主 义 世 界 的 前 兆 ” 。   ";
				a.empires[1].relations += 80;
			}
			else
			{
				text += "||莫 斯 科 对 发 生 的 事 情 感 到 担 忧 。 也 许 很 快 ， 我 们 要 看 到 第 三 次 “ 华 沙 之 春 ” 的 发 生 … 但 目 前 为 止 ， 克 瓦 希 涅 夫 斯 基 正 在 试 图 向 莫 斯 科 宣 誓 表 示 自 我 为 “ 社 会 主 义 开 放 与 活 力 的 橱 窗 ” - 这 能 阻 止 即 将 到 来 的 干 预 吗 ？";
				a.empires[1].relations -= 80;
			}
			a.empires[0].relations += 80;
			a.empires[0].power += 50;
			a.empires[1].power -= 50;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 12;
		}
		if (result_num == 2)
		{
			text = " 我 们 慷 慨 地 向 波 兰 提 供 了 一 揽 子 计 划 ： 财 政 援 助 以 及 直 接 干 预 稳 定 政 府 的 尝 试 ， 这 巨 额 的 援 助 数 量 本 身 为 我 们 提 供 了 一 个 很 好 的 参 考 …||在 我 们 的 帮 助 下 ， 拉 科 夫 斯 基 灵 活 的 通 过 独 立 候 选 人 以 及 来 自 若 干 小 党 ， 例 如 “ 民 主 派 联 盟 ” 的 成 员 的 支 持 下 维 持 住 了 一 个 少 数 派 政 府 ， 然 而 ， 波 兰 统 一 工 人 党 的 解 体 以 及 团 结 工 会 的 示 微 将 会 持 续 困 扰 波 兰 政 局 … ";
			a.empires[0].relations += 100;
			a.empires[1].relations -= 100;
			a.data[8] -= 200;
			a.influencePRC += 20;
			a.empires[0].power += 30;
			a.empires[1].power -= 50;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 14;
		}
		if (result_num == 3)
		{
			text = " 面 对 这 种 情 况 ， 我 们 决 定 动 员 我 们 的 特 勤 ， 在 波 兰 扶 持 一 个 能 稳 定 政 局 的 可 靠 力 量 。 在 克 瓦 希 涅 夫 斯 基 前 往 安 抚 第 二 次 格 但 斯 克 大 罢 工 的 时 候 ， 我 们 为 这 位 “ 工 人 阶 级 的 英 雄 ” 安 排 了 一 辆 隧 道 里 的 油 罐 车 。 与 此 同 时 ， 我 们 的 特 工 帮 助 了 依 然 潜 藏 在 半 非 法 状 态 下 的 “ 波 兰 独 立 联 邦 “ 的 崛 起 …||多 亏 了 我 们 的 帮 助 ， 一 个 右 翼 主 导 的 政 府 已 经 在 波 兰 出 现 ， 莱 谢 克 . 莫 克 斯 基 ， 这 位 反 共 历 史 学 家 以 及 秘 密 的 波 兰 人 民 共 和 国 内 务 部 探 员 ， 现 在 开 始 将 自 己 的 政 府 粉 饰 为 “ 左 翼 爱 国 政 权 “ ， 策 略 性 的 招 募 了 一 些 ” 党 之 基 石 “ 的 成 员 ， 组 成 了 新 内 阁 。 新 政 府 毫 无 掩 饰 自 己 的 专 制 倾 向 ， 首 先 就 是 宣 布 了 宵 禁 的 执 行 并 且 开 始 大 幅 度 扩 充 执 法 队 伍 。 在 经 济 领 域 ， 保 守 主 义 的 市 场 化 - 主 要 基 于 我 们 的 经 验 开 始 。||苏 联 对 此 颇 有 微 词 ， 但 是 自 顾 不 暇 …";
			a.empires[0].relations += 150;
			a.empires[1].relations -= 150;
			a.influencePRC += 40;
			a.data[9] -= 100;
			a.empires[0].power += 40;
			a.empires[1].power -= 80;
			GlobalScript.inst.gameState.allcountries[2].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 7;
		}
	}
}
