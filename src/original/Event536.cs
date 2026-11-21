using EventsForDLC;
using UnityEngine;

public class Event536 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 保 革 伯 仲 ： 第 三 幕";
		text = " 在 <color=#0000FF>大 平 正 芳</color> 于1980 年 去 世 后 ， <color=#0000FF>中 曾 根 康 弘</color> 替 代 过 渡 的 西 村 英 一 成 为 <color=#0000FF>自 由 民 主 党</color> 新 总 裁 以 及 日 本 首 相 。1983 年10 月12 日 ， 在 东 京 地 方 法 院 对 洛 克 希 德 公 司 案 进 行 的 一 审 中 ， 前 首 相 田 中 角 荣 被 判 处4 年 有 期 徒 刑 和5 亿 日 元 附 加 费 ， 但 田 中 坚 持 无 罪 ， 提 出 上 诉 并 拒 绝 辞 去 众 议 院 议 员 职 务 。 议 会 也 因 为 前 首 相 的 刑 期 而 陷 入 混 乱 ， 在 野 党 强 力 坚 持 提 出 并 表 决 建 议 田 中 辞 去 国 会 职 务 的 决 议 案 ， 审 议 陷 入 僵 局 。 最 终 众 参 两 院 的 议 长 提 出 了 调 解 方 案 并 获 得 通 过 ， 中 曾 根 内 阁 决 定 在 重 要 法 案 获 得 通 过 后 解 散 众 议 院 。11 月28 日 ， 众 议 院 解 散 。12 月18 日 ， 新 一 轮 选 举 将 正 式 开 始 。||革 新 政 权 内 部 依 旧 存 在 不 稳 定 因 素 ， 现 任 政 府 几 年 来 的 政 策 也 同 样 褒 贬 不 一 。 <color=#0000FF>自 由 民 主 党</color> 正 在 紧 锣 密 鼓 地 筹 划 重 夺 政 权 。 不 管 怎 样 ， 现 在 是 我 们 该 行 动 的 时 候 了 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		Object.Destroy(button[0]);
		button_text[0] = "";
		if (a.resultOfEvents[531] == 0)
		{
			button_text[1] = " 支 持 社 会 革 新 党";
		}
		else if (a.resultOfEvents[531] == 1 && a.resultOfEvents[523] == 0 && a.allcountries[44].prcpower >= 100)
		{
			button_text[1] = " 在 日 本 人 民 民 主 联 合 阵 线 的 旗 帜 下 支 援 社 会 党 和 共 产 党 联 盟";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 人 对 他 们 有 兴 趣";
		}
		button_text[2] = " 保 持 观 望";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 保 革 伯 仲 ： 第 三 幕";
		if (result_num == 0)
		{
			text = " 我 们 向 <color=#0000FF>自 由 民 主 党</color> 送 去 大 量 的 援 助 ， 同 时 派 出 人 员 在 关 键 选 区 进 行 宣 传 工 作 。 并 且 采 取 各 种 手 段 挑 拨 其 他 在 野 党 基 层 组 织 之 间 的 关 系 ， 让 它 们 把 更 多 的 竞 选 资 源 用 于 彼 此 争 斗 上 ， 从 而 确 保 执 政 党 候 选 人 能 够 稳 住 阵 脚 。||最 终 <color=#0000FF>自 由 民 主 党</color> 成 功 赢 下 超 过 半 数 多 数 的275 个 席 位 ， 确 保 了 执 政 地 位 的 稳 固 。 其 他 党 情 况 如 下 ： <color=#008000>社 会 党</color>107 席 ， 依 旧 没 能 取 得 更 大 胜 利 。 <color=#FFFF00>公 明 党</color>53 席 ， <color=#FFA500>民 主 社 会 党</color>33 席 ， <color=#8B0000>共 产 党</color>21 席 ， <color=#0000FF>新 自 由 俱 乐 部</color>3 席 ， <color=yellow>社 会 民 主 联 合</color>3 席 、 无 所 属 议 员16 席 。||新 政 府 由 <color=#0000FF>中 曾 根 康 弘</color> 领 导 ， 宣 布 将 全 面 推 进 新 自 由 主 义 改 革 ， 开 始 国 有 公 司 的 部 分 私 有 化 与 拆 分 ， 限 制 工 会 权 利 ， 放 松 政 府 管 制 并 更 进 一 步 融 入 全 球 市 场 。 在 外 交 方 面 ， 新 政 府 表 示 将 努 力 维 护 中 日 友 好 关 系 并 开 展 全 方 位 经 济 合 作 ， 此 外 新 政 府 也 将 保 持 与 美 国 的 沟 通 ， 并 表 示 必 须 全 面 提 防 苏 联 及 其 他 国 家 可 能 的 间 谍 活 动 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 5;
			a.allcountries[44].Vyshi = false;
			a.allcountries[44].proprc = true;
			a.allcountries[44].Torg = true;
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.data[1] += 150;
			a.data[3] += 150;
			a.data[6] -= 20;
			a.influencePRC += 50;
			a.empires[1].relations -= 150;
			a.empires[0].relations += 150;
			a.empires[0].power += 30;
			a.empires[1].power -= 30;
		}
		if (result_num == 1)
		{
			if (a.resultOfEvents[531] == 0)
			{
				text = " 我 们 向 <color=#008000>社 会 革 新 党</color> 送 去 大 量 的 资 金 支 持 ， 同 时 派 出 大 量 人 员 在 关 键 选 区 进 行 宣 传 工 作 。 <color=#008000>社 会 革 新 党</color> 自 己 也 组 织 了 大 批 基 层 活 动 家 ， 在 中 央 委 员 的 带 领 下 亲 赴 各 个 市 区 散 发 传 单 ， 与 市 民 交 流 并 解 答 他 们 的 问 题 （ 一 些 地 区 的 委 员 甚 至 直 接 在 选 区 内 临 时 租 屋 ， 在 选 举 结 束 之 前 一 直 住 在 这 里 以 确 保 每 天 都 能 第 一 时 间 与 市 民 沟 通 ） 。 此 外 我 们 在 当 地 的 特 工 也 成 功 制 造 了 多 起 针 对 <color=#0000FF>自 由 民 主 党</color> 候 选 人 集 会 的 骚 乱 ， 确 保 <color=#008000>社 会 革 新 党</color> 能 够 击 败 这 个 庞 然 大 物 。||最 终 <color=#008000>社 会 革 新 党</color> 如 选 举 前 许 多 媒 体 所 猜 测 的 那 样 ， 取 得 了 前 所 未 有 的 胜 利 ， 一 举 夺 得275 席 。 <color=#0000FF>自 由 民 主 党</color> 遭 遇 大 败 ， 只 获 得193 席 。 其 他 党 情 况 如 下 ： <color=#8B0000>共 产 党</color>24 席 、 <color=#0000FF>新 自 由 俱 乐 部</color>3 席 、 无 所 属 议 员16 席 。||新 政 府 由 <color=#008000>飞 鸟 田 一 雄</color> 领 导 ， 宣 布 将 保 持 对 经 济 的 宏 观 引 导 ， 引 入 干 预 性 产 业 政 策 并 全 面 开 展 企 业 民 主 化 ， 维 系 当 前 的 国 有 化 并 对 其 他 关 键 领 域 也 开 始 国 有 化 尝 试 （ 或 者 按 照 纲 领 文 件 来 说 ， “ 成 为 社 会 所 有 ” ） ， 进 一 步 确 保 工 人 和 工 会 权 利 并 加 强 政 府 对 它 们 的 影 响 ， 对 农 民 采 取 进 一 步 的 保 护 性 措 施 。 在 外 交 上 ， 新 政 府 表 示 将 努 力 维 护 中 日 友 好 关 系 并 开 展 全 方 位 经 济 合 作 ， 也 将 改 善 与 其 他 社 会 主 义 政 党 和 政 权 的 关 系 ， 并 将 与 美 国 展 开 关 于 《 日 美 安 保 条 约 》 问 题 的 再 谈 判 。 据 政 府 内 部 人 士 表 示 ， 新 政 府 的 谈 判 目 标 是 促 使 美 军 在 未 来 五 至 十 年 内 逐 步 分 批 撤 出 日 本 。 同 时 为 了 避 免 美 国 进 一 步 的 反 应 ， 新 政 府 也 将 提 出 一 份 替 代 条 约 方 案 。 ";
				a.allcountries[44].Gosstroy = 2;
				a.allcountries[44].SubGosstroy = 3;
				a.allcountries[44].Vyshi = false;
				a.allcountries[44].proprc = true;
				a.allcountries[44].Torg = true;
				a.data[8] -= 150;
				a.data[9] -= 150;
				a.data[1] += 150;
				a.data[3] += 150;
				a.data[6] -= 20;
				a.influencePRC += 50;
				a.empires[0].relations -= 150;
				a.empires[0].power -= 30;
			}
			else if (a.resultOfEvents[531] == 1)
			{
				text = " 出 乎 预 料 的 是 ， <color=#008000>社 会 党</color> 并 未 再 与 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 组 成 联 盟 参 选 ， 而 是 与 <color=#8B0000>共 产 党</color> 合 作 ， 宣 布 结 成 <color=red>日 本 人 民 民 主 联 合 阵 线</color> 参 与 选 举 工 作 。 而 我 们 也 向 其 送 去 大 量 的 资 金 支 持 ， 并 派 出 大 量 人 员 在 关 键 选 区 进 行 宣 传 工 作 （ 重 点 强 调 阵 线 理 念 与 苏 式 发 达 社 会 主 义 的 完 全 不 同 ， 以 及 完 全 独 立 于 苏 联 的 自 主 路 线 ） 。 此 外 在 工 会 干 部 的 帮 助 下 ， 我 们 迅 速 组 织 了 上 百 万 人 在 全 国 各 地 展 开 大 规 模 集 会 与 游 行 以 声 援 阵 线 。 <color=#A52A2A>日 本 共 产 主 义 抵 抗 者 同 盟</color> 也 成 功 号 召 了 一 批 高 校 学 生 与 农 民 展 开 行 动 。 东 京 大 学 、 京 都 大 学 等 学 校 再 次 爆 发 斗 争 ， 扰 乱 了 执 政 党 在 多 个 关 键 选 区 的 原 定 计 划 。 最 后 ， 我 们 在 当 地 的 特 工 也 成 功 制 造 了 多 起 针 对 <color=#0000FF>自 由 民 主 党</color> 候 选 人 集 会 的 骚 乱 ， 确 保 联 合 阵 线 能 够 击 败 这 个 庞 然 大 物 。||最 终 <color=red>人 民 民 主 联 合 阵 线</color> 取 得 了 前 所 未 有 的 胜 利 ， 一 举 夺 得265 席 。 <color=#0000FF>自 由 民 主 党</color> 遭 遇 大 败 ， 只 获 得190 席 。 其 他 党 情 况 如 下 ： <color=#FFFF00>公 明 党</color>25 席 、 <color=#FFA500>民 主 社 会 党</color>20 席 、 <color=yellow>社 会 民 主 联 合</color>3 席 、 <color=#0000FF>新 自 由 俱 乐 部</color>2 席 、 无 所 属 议 员6 席 。||新 政 府 由 向 坂 逸 郎 领 导 ， 宣 布 将 以 科 学 社 会 主 义 为 核 心 ， 对 经 济 进 行 全 面 引 导 和 干 预 ， 实 施 大 规 模 企 业 民 主 化 ， 维 持 并 迅 速 开 展 新 一 轮 国 有 化 浪 潮 ， 设 立 国 家 计 划 委 员 会 以 为 计 划 经 济 的 实 施 做 准 备 。 在 外 交 上 ， 新 政 府 表 示 将 努 力 维 护 中 日 友 好 关 系 并 开 展 全 方 位 经 济 合 作 ， 同 时 与 苏 联 和 社 会 主 义 阵 营 展 开 合 作 ， 并 将 就 完 全 废 除 《 日 美 安 保 条 约 》 问 题 与 美 国 展 开 谈 判 。 据 政 府 内 部 人 士 表 示 ， 新 政 府 的 谈 判 目 标 是 促 使 美 军 在 未 来 五 年 内 逐 步 分 批 撤 出 日 本 并 确 保 日 本 摆 脱 美 国 的 影 响 。 ";
				a.allcountries[44].Gosstroy = 1;
				a.allcountries[44].SubGosstroy = 1;
				a.allcountries[44].Vyshi = false;
				a.allcountries[44].proprc = true;
				a.allcountries[44].Torg = true;
				a.data[8] -= 200;
				a.data[9] -= 200;
				a.data[1] += 150;
				a.data[3] += 150;
				a.data[6] -= 20;
				a.influencePRC += 50;
				a.empires[0].relations -= 150;
				a.empires[0].power -= 50;
			}
		}
		if (result_num == 2)
		{
			text = " 我 们 决 定 按 兵 不 动 ， 静 观 局 势 发 展 。||最 终 结 果 如 下 ： <color=#008000>社 会 党</color> 1 1 2 席 、 <color=#FFFF00>公 明 党</color> 5 8 席 、 <color=#FFA500>民 主 社 会 党</color> 3 8 席 、 <color=#8B0000>共 产 党</color>2 6 席 、 <color=#0000FF>新 自 由 俱 乐 部</color> 8 席 、 <color=yellow>社 会 民 主 联 合</color> 3 席 ， 无 所 属 议 员 1 6 席 。 <color=#0000FF>自 由 民 主 党</color> 依 旧 未 能 拿 到 多 数 ， 只 有248 席 ， 不 得 不 拉 拢 无 所 属 议 员 和 <color=#0000FF>新 自 由 俱 乐 部</color> 来 保 证 执 政 地 位 。||新 政 府 由 <color=#0000FF>中 曾 根 康 弘</color> 领 导 ， 宣 布 将 全 面 推 进 新 自 由 主 义 改 革 ， 开 始 国 有 公 司 的 大 规 模 私 有 化 与 拆 分 ， 限 制 工 会 权 利 ， 放 松 政 府 管 制 并 更 进 一 步 融 入 全 球 市 场 。 在 外 交 方 面 ， 新 政 府 全 面 向 美 国 和 北 约 靠 拢 ， 强 化 日 美 同 盟 关 系 的 同 时 开 始 尝 试 加 强 自 身 军 事 力 量 ， 并 强 调 必 须 全 面 提 防 苏 联 及 其 他 国 家 可 能 的 间 谍 活 动 ， 就 像 今 年 年 初 中 曾 根 在 《 华 盛 顿 邮 报 》 董 事 长 早 餐 会 上 所 说 的 那 样 ， 日 本 列 岛 将 “ 像 不 沉 的 航 空 母 舰 一 样 坚 固 防 御 ” 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 6;
			a.allcountries[44].Vyshi = true;
			a.allcountries[44].proprc = false;
			a.empires[0].power += 30;
		}
	}
}
