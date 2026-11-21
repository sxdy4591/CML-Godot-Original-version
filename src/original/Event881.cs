using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event881 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	public bool load_scene_after_click;

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
		name = " 罗 得 西 亚 永 不 灭 亡 ？";
		text = " 1 9 7 9 年 1 2 月 1 1 日 ， 津 巴 布 韦 罗 得 西 亚 通 过 了 《 津 巴 布 韦 罗 得 西 亚 宪 法 （ 修 正 案 ） 第 4 号 法 案 》 （ 1 9 7 9 年 ） ， 第 二 天 索 姆 斯 勋 爵 就 任 总 督 ， 持 续 1 4 年 的 罗 得 西 亚 叛 乱 宣 告 结 束 ， 津 巴 布 韦 罗 得 西 亚 作 为 南 罗 得 西 亚 的 殖 民 地 恢 复 了 英 国 法 律 下 的 合 法 性 。||英 国 议 会 随 后 通 过 了 《 津 巴 布 韦 法 案 》 ， 制 定 了 该 国 的 独 立 宪 法 。 1 9 7 9 年 1 2 月 2 1 日 ， 双 方 正 式 签 署 了 停 火 协 议 ； 索 姆 斯 勋 爵 还 签 署 了 解 除 对 <color=#8B0000>津 民 盟 - 爱 国 阵 线</color> 和 <color=#006400>津 人 盟</color> 的 禁 令 ， 并 对 对 所 有 在 战 争 中 拿 起 武 器 的 人 实 行 大 赦 。 英 军 的 监 察 部 队 随 后 在 南 罗 得 西 亚 各 地 设 立 了 1 6 个 集 合 点 ， 爱 国 阵 线 游 击 队 员 可 以 在 那 里 解 除 武 装 井 恢 复 平 民 生 活 ； 到 1 月 6 日 的 最 后 期 限 前 ， 共 有 1 8 , 3 0 0 人 这 样 做 了 。 随 后 便 是 激 动 人 心 的 大 选 时 刻 ， 该 国 国 内 分 别 有 四 个 潜 在 的 人 选 和 党 派 。||其 一 是 前 执 政 党 罗 得 西 亚 阵 线 党 ， 考 虑 到 其 臭 名 昭 著 的 “ 美 名 ” ， 他 们 不 太 可 能 获 得 大 选 的 多 数 选 票 ， 但 他 们 仍 然 保 留 了 一 定 席 位 。 大 多 数 的 阵 线 党 代 表 决 定 和 第 二 个 政 党 ， <color=#0027FF>联 合 非 洲 民 族 委 员 会</color> 结 盟 。 由 曾 经 领 导 津 巴 布 韦 罗 得 西 亚 联 合 政 府 的 阿 贝 尔 - 穆 佐 雷 瓦 所 带 领 ， 该 委 员 会 在 前 一 年 嬴 得 了 最 多 选 票 。 但 据 报 道 ， 他 的 集 会 出 席 人 数 不 多 ， 而 穆 佐 雷 瓦 经 常 抨 击 其 他 津 巴 布 韦 政 客 ， 这 被 认 为 削 弱 了 他 作 为 一 个 团 结 人 士 的 吸 引 力 。 詹 姆 斯 • 奇 凯 雷 马 在 1 9 7 9 年 6 月 与 穆 佐 雷 瓦 闹 翻 ， 随 后 带 领 他 的 津 巴 布 韦 民 主 党 加 入 竞 选 ， 该 党 与 津 巴 布 韦 人 民 联 盟 （ZAPU ） 的 关 系 日 益 密 切 （ 他 与 恩 科 莫 举 行 了 团 结 会 谈 ） ； 奇 凯 雷 马 抱 怨 津 民 盟 的 支 持 者 对 他 进 行 死 亡 威 胁 。 而 <color=#8B0000>津 巴 布 韦 非 洲 民 族 联 盟 - 爱 国 阵 线</color> （ZANU-PF ）   提 交 了 一 份 温 和 的 宣 言 ， 其 中 很 少 提 到 该 党 所 宣 称 的 与 中 国 的 结 盟 。 不 论 是 谁 取 得 胜 利 ， 种 族 政 权 的 多 米 诺 骨 牌 还 是 倒 下 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 我 们 只 需 要 等 待 … …";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 罗 得 西 亚 永 不 灭 亡 ？";
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
		{
			if (((i >= 52 && i <= 68) || (i >= 106 && i <= 108) || (i >= 112 && i <= 133) || i == 13 || i == 18 || i == 40 || i == 41 || i == 42 || i == 99 || i == 100) && i != 128)
			{
				if (a.allcountries[i].prosov)
				{
					num2++;
				}
				if (a.allcountries[i].Gosstroy == 3)
				{
					num++;
				}
			}
		}
		if (a.resultOfEvents[609] == 1)
		{
			num2++;
		}
		if (a.resultOfEvents[88] == 0)
		{
			num3 = 114514;
		}
		if (a.resultOfEvents[88] == 1 || (num >= 6 && num > num2 && num > num3))
		{
			text = " 顺 应 时 代 的 浪 潮 ， <color=#0027FF>联 合 非 洲 民 族 委 员 会</color> 设 法 在 大 选 中 取 得 了 略 微 的 优 势 ， 以 3 8 票 的 相 对 多 数 和 <color=#8B0000>津 民 盟 - 爱 国 阵 线</color> 的 温 和 派 组 成 了 联 合 政 府 。 罗 得 西 亚 阵 线 党 取 得 了 全 部 的 2 0 个 “ 白 名 单 ” 南 罗 得 西 亚 正 式 从 英 国 独 立 ， 末 代 总 督 索 姆 斯 勋 爵 在 告 别 了 索 尔 兹 伯 里 （ 现 在 更 名 为 哈 拉 雷 ） 后 踏 上 了 归 国 的 飞 机 。 而 穆 佐 雷 瓦 成 为 该 国 第 一 任 首 相 ， 西 索 尔 成 为 了 该 国 第 一 任 总 统 。 该 国 宣 布 建 立 一 个 类 似 西 方 的 多 党 制 共 和 国 。 并 开 始 着 手 建 立 和 周 围 国 家 的 关 系 ， 白 人 地 主 的 财 产 仍 然 得 到 了 保 留 ， 他 们 也 欢 迎 外 国 企 业 来 津 巴 布 韦 投 资 。";
			GlobalScript.inst.gameState.allcountries[127].name = "津 巴 布 韦 共 和 国";
			GlobalScript.inst.gameState.allcountries[127].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 5;
			GlobalScript.inst.gameState.allcountries[126].level_of_unstab -= 50;
		}
		else if (num2 >= 6 && num2 > num3 && num2 > num)
		{
			text = " 出 乎 意 料 的 是 ， 恩 科 莫 的ZAPU 和 津 巴 布 韦 民 主 党 的 联 盟 击 败 了 诸 多 竞 争 对 手 ， 以 及 其 死 对 头 所 带 领 的 <color=#8B0000>津 民 盟 - 爱 国 阵 线</color> ， 取 得 了 4 3 票 的 惊 人 成 绩 。 <color=#8B0000>津 民 盟 - 爱 国 阵 线</color> 方 面 怒 不 可 遏 ， 该 党 的 发 言 人 谴 责ZAPU 在 选 举 中 舞 弊 ， 称 他 “ 收 了 英 国 和 南 非 的 贿 赂 ” 。 但 在 联 合 国 和 英 国 的 监 察 部 队 中 并 没 有 展 现 出 任 何 作 弊 的 现 象 。 很 快 ， 世 界 上 另 一 段 的 超 级 大 国 苏 联 宣 布 承 认 南 罗 得 西 亚 的 政 权 更 迭 和 选 举 结 果 。 也 是 世 界 上 第 一 批 承 认 该 国 的 国 家 之 一 。 罗 得 西 亚 阵 线 党 取 得 了 全 部 的 2 0 个 “ 白 名 单 ” 南 罗 得 西 亚 正 式 从 英 国 独 立 ， 末 代 总 督 索 姆 斯 勋 爵 在 告 别 了 索 尔 兹 伯 里 （ 现 在 更 名 为 哈 拉 雷 ） 后 踏 上 了 归 国 的 飞 机 。 恩 科 莫 宣 布 将ZAPU 宣 布 改 组 为 津 巴 布 韦 人 民 革 命 党 ， 正 式 接 纳 了 马 克 思 - 列 宁 主 义 和 反 帝 主 义 。 该 国 试 着 在 可 以 接 纳 的 范 围 内 借 鉴 苏 联 的 经 验 ， 展 开 缓 慢 的 土 地 改 革 。 但 是 大 量 跨 国 公 司 被 公 有 化 或 者 被 赎 买 。 许 多 前 地 主 跨 过 国 境 线 逃 亡 南 非 寻 求 庇 护 。 而 合 并 两 支 游 击 队 的 行 为 看 起 来 是 如 此 的 缓 慢 ， 部 分 前 Z A N L A （ 津 巴 布 韦 非 洲 民 族 解 放 军 ） 成 员 甚 至 和 部 落 民 兵 勾 结 在 一 起 ， 展 开 了 又 一 场 叛 乱 。 而 古 巴 志 愿 者 也 已 经 开 始 出 现 在 布 拉 韦 约 等 地 协 助 平 叛 。";
			GlobalScript.inst.gameState.allcountries[127].name = "津 巴 布 韦 人 民 共 和 国";
			GlobalScript.inst.gameState.allcountries[127].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[127].prosov = true;
			GlobalScript.inst.gameState.allcountries[126].level_of_unstab += 30;
		}
		else if (num3 != 0)
		{
			text = " 毫 不 客 气 的 说 ， 这 一 结 果 是 肯 定 的 。 <color=#8B0000>津 民 盟 - 爱 国 阵 线</color> 在 漫 长 的 祖 国 解 放 战 争 中 立 下 的 赫 赫 战 功 几 乎 让 其 锁 定 了 领 导 地 位 ， 但 没 人 想 象 的 到 这 一 切 来 的 如 此 之 快 。 8 0 个 共 同 席 位 中 的 5 7 个 ， 使 其 在 1 0 0 名 成 员 的 众 议 院 中 占 多 数 。 约 书 亚 · 恩 科 莫 的 津 巴 布 韦 非 洲 人 民 联 盟 作 为 爱 国 阵 线 参 加 选 举 ， 赢 得 了 8 0 个 共 同 席 位 中 的 2 0 个 ， 其 余 3 个 席 位 将 转 给 则 属 于 阿 贝 尔 · 穆 佐 雷 瓦 的 非 洲 联 合 全 国 委 员 会 。 伊 恩 · 史 密 斯 的 罗 得 西 亚 阵 线 赢 得 了 所 有 2 0 个 白 名 单 席 位 ， 其 大 多 数 候 选 人 无 异 议 参 选 。||由 于 我 们 提 供 的 安 保 人 员 ， 约 书 亚 · 通 戈 加 拉 ， <color=#8B0000>津 民 盟 - 爱 国 阵 线</color> 的 武 装 组 织 Z A N L A 的 最 高 指 挥 官 同 志 ， 穆 加 贝 最 有 力 的 竞 争 对 手 得 以 在 一 场 针 对 他 的 政 治 暗 杀 中 存 活 下 来 。 这 为 他 赢 得 了 足 够 的 人 气 ， 在 津 民 盟 第 6 届 全 国 代 表 大 会 上 ， 他 得 以 当 选 为 总 书 记 ， 身 兼 新 政 府 总 理 一 职 。 穆 加 贝 则 成 为 了 他 忠 实 的 战 友 ， 也 就 是 新 政 权 的 总 统 。 该 国 宣 称 为 建 立 一 个 “ 科 学 社 会 主 义 的 泛 非 共 和 国 ” 而 奋 斗 。 他 们 也 正 式 把 马 克 思 列 宁 主 义 和 毛 泽 东 思 想 作 为 写 入 了 党 章 ， 称 其 为 “ 适 用 于 津 巴 布 韦 革 命 经 验 的 宝 贵 财 富 ” 。 津 巴 布 韦 进 入 的 是 “ 民 族 民 主 革 命 ” ， 因 此 应 该 在 打 击 封 建 大 地 主 和 原 部 落 酋 长 的 前 提 下 ， 稳 扎 稳 打 的 在 津 巴 布 韦 建 设 社 会 主 义 ， 尤 其 要 注 重 处 理 土 地 和 白 人 的 关 系 。 一 场 稳 定 的 土 地 改 革 正 在 进 行 中 ， 大 多 数 外 资 企 业 则 被 国 有 化 或 被 联 合 经 营 。 赞 比 亚 与 坦 桑 尼 亚 为 该 国 提 供 了 一 笔 援 助 ， 社 会 主 义 的 理 想 在 非 洲 大 陆 又 一 次 得 到 了 实 现 。 ";
			GlobalScript.inst.gameState.allcountries[127].name = "津 巴 布 韦 民 主 人 民 共 和 国";
			GlobalScript.inst.gameState.allcountries[127].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 17;
			GlobalScript.inst.gameState.allcountries[127].proprc = true;
			GlobalScript.inst.gameState.allcountries[127].Torg = true;
			GlobalScript.inst.gameState.allcountries[127].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[127].soc_stab = 1000;
			GlobalScript.inst.gameState.allcountries[126].level_of_unstab += 50;
		}
		else
		{
			text = " 毫 不 客 气 的 说 ， 这 一 结 果 是 肯 定 的 。 <color=#8B0000>津 民 盟 - 爱 国 阵 线</color> 在 漫 长 的 祖 国 解 放 战 争 中 立 下 的 赫 赫 战 功 几 乎 让 其 锁 定 了 领 导 地 位 ， 但 没 人 想 象 的 到 这 一 切 来 的 如 此 之 快 。 8 0 个 共 同 席 位 中 的 5 7 个 ， 使 其 在 1 0 0 名 成 员 的 众 议 院 中 占 多 数 。 约 书 亚 · 恩 科 莫 的 津 巴 布 韦 非 洲 人 民 联 盟 作 为 爱 国 阵 线 参 加 选 举 ， 赢 得 了 8 0 个 共 同 席 位 中 的 2 0 个 ， 其 余 3 个 席 位 将 转 给 则 属 于 阿 贝 尔 · 穆 佐 雷 瓦 的 非 洲 联 合 全 国 委 员 会 。 伊 恩 · 史 密 斯 的 罗 得 西 亚 阵 线 赢 得 了 所 有 2 0 个 白 名 单 席 位 ， 其 大 多 数 候 选 人 无 异 议 参 选 。 由 于 选 举 的 结 果 ， 罗 伯 特 · 穆 加 贝 于 1 9 8 0 年 4 月 1 1 日 成 为 津 巴 布 韦 独 立 后 的 第 一 任 总 理 。 该 国 宣 称 为 建 立 一 个 “ 民 族 主 义 的 ， 社 会 主 义 的 泛 非 共 和 国 ” 而 奋 斗 。 他 们 也 正 式 把 津 巴 布 韦 化 的 马 克 思 主 义 作 为 其 意 识 形 态 写 入 了 党 章 。 同 时 宣 传 自 己 进 入 的 是 “ 民 族 民 主 革 命 ” 。 他 们 同 时 保 证 了 不 会 针 对 前 白 人 时 期 的 暴 政 展 开 无 底 线 报 复 ， 许 诺 十 年 内 不 干 涉 白 人 地 主 的 权 力 ， 他 们 可 以 自 由 选 择 离 开 津 巴 布 韦 或 者 留 下 来 。 总 体 来 说 ， 津 巴 布 韦 进 入 了 新 的 时 代 。";
			GlobalScript.inst.gameState.allcountries[127].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 15;
			GlobalScript.inst.gameState.allcountries[127].proprc = true;
			GlobalScript.inst.gameState.allcountries[127].Torg = true;
			GlobalScript.inst.gameState.allcountries[127].name = "津 巴 布 韦 共 和 国";
			GlobalScript.inst.gameState.allcountries[126].level_of_unstab += 30;
		}
		if (GlobalScript.inst.gameState.allcountries[127].SubGosstroy != 5 && a.allcountries[131].SubGosstroy == 9 && !a.ingamewars[54].is_going)
		{
			load_scene_after_click = true;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.number_event = 882;
			SceneManager.LoadScene("Event");
		}
	}
}
