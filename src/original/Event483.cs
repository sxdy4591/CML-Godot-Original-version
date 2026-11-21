using EventsForDLC;
using UnityEngine;

public class Event483 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 第 二 次 五 月 风 暴";
		if (a.modifies[42].active)
		{
			text = " <color=#0027FF>吉 斯 卡 尔</color> 政 府 不 可 动 摇 的 自 由 主 义 原 则 并 未 为 法 国 带 来 良 好 的 发 展 ， <color=#0027FF>吉 斯 卡 尔 · 德 斯 坦</color> 的 绝 大 多 数 措 施 均 没 有 带 来 显 著 成 效 ， 法 国 经 济 也 陷 入 了 停 滞 。";
		}
		else if (a.modifies[43].active)
		{
			text = " <color=#006400>密 特 朗</color> 政 府 没 能 在 国 际 形 式 与 资 本 外 流 的 压 力 前 站 稳 脚 跟 ， 所 以 它 选 择 了 终 结 左 翼 凯 恩 斯 主 义 改 革 。 在 随 后 ， 政 府 开 始 实 行 紧 缩 政 策 ， 实 质 上 奉 行 新 自 由 主 义 政 策 。 <color=#006400>弗 朗 索 瓦 · 密 特 朗</color> 对 社 会 转 型 的 必 要 性 已 经 闭 口 不 谈 了 。";
		}
		else if (a.modifies[44].active)
		{
			text = " <color=#8B0000>乔 治 · 马 歇</color> 在 转 型 上 的 失 败 引 起 了 再 私 有 化 以 及 左 右 翼 的 对 抗 ， 造 成 了 失 业 和 社 会 的 撕 裂 。";
		}
		else if (a.modifies[45].active)
		{
			text = " <color=#000080>希 拉 克</color> 政 府 实 行 新 戴 高 乐 主 义 的 政 策 。 政 府 对 一 边 以 福 利 收 买 工 人 阶 级 一 边 收 拢 锁 链 — — 削 弱 左 翼 的 力 量 并 打 压 工 会 ， 雇 主 的 法 律 权 力 也 极 大 扩 张 ， 法 团 主 义 也 在 企 业 中 盛 行 ； 与 此 同 时 ， 政 府 在 各 项 社 会 议 题 上 相 当 保 守 压 抑 。 为 了 应 对 赤 字 和 社 会 支 出 ， 法 国 在 西 非 的 前 殖 民 地 推 行 新 殖 民 主 义 ， 以 应 对 高 涨 的 开 支 。";
		}
		text += " 西 欧 多 国 脱 离 自 由 资 本 主 义 秩 序 给 法 国 带 来 的 冲 击 和 民 众 对 建 制 各 派 势 力 的 失 望 ， 法 国 社 会 这 些 年 来 存 在 的 问 题 和 矛 盾 都 借 此 机 会 再 度 爆 发 。 先 是 部 分 大 学 的 发 生 了 骚 动 ， 学 生 对 政 府 举 行 游 行 抗 议 ， 他 们 呼 吁 “ 重 新 拾 起 1 9 6 8 的 精 神 ” ； 不 久 ， 一 场 有 预 谋 的 罢 工 便 席 卷 了 全 国 。 鉴 于 1 9 6 8 运 动 的 前 车 之 鉴 ， 各 派 力 量 开 始 寻 求 组 建 相 似 意 识 形 态 组 织 的 统 一 战 线 ， 并 将 斗 争 对 象 直 接 指 向 国 家 机 器 。 群 众 运 动 中 有 三 股 主 要 势 力 正 在 崛 起 。 奉 行 毛 主 义 的 <color=red>人 民 革 命 联 盟</color> （ 由 <color=red>法 国 马 列 主 义 共 产 党</color> 、 <color=red>马 列 主 义 共 产 主 义 组 织</color> — — <color=red>无 产 阶 级 道 路</color> 和 <color=red>法 国 马 列 主 义 共 产 主 义 者 联 盟</color> 等 毛 派 政 党 组 成 ） 、 托 洛 茨 基 主 义 与 新 左 派 的 联 盟 — — <color=#8B0000>革 命 工 人 组 织</color> （ 由 <color=#8B0000>“ 工 人 斗 争 ”</color> 、 <color=#8B0000>革 命 共 产 主 义 同 盟</color> 、 <color=#8B0000>统 一 社 会 党</color> 等 组 成 ） 以 及 各 类 民 族 主 义 组 织 【 如 <color=#8B4513>新 势 力 党</color> 、 <color=#8B4513>法 兰 西 工 作 党</color> 、 <color=#8B4513>革 命 民 族 主 义 运 动</color> 和 <color=#8B4513>人 民 斗 争 组 织 （ 重 建 ）</color> 等 】 。 此 外 ， 法 国 还 存 在 多 个 极 左 翼 和 极 右 翼 的 城 市 游 击 队 （ 如 <color=#DC143C>“ 直 接 行 动 ”</color> 、 <color=#DC143C>“ 人 民 自 治 武 装 核 心 ”</color> 、 <color=#DC143C>“ 红 色 海 报 ”</color> 、 <color=#808000>道 德 秩 序 委 员 会</color> 等 ） 利 用 境 外 势 力 支 援 的 武 器 开 展 城 市 游 击 战 ， 他 们 虽 然 各 自 为 战 ， 但 也 是 一 方 可 以 利 用 的 力 量 。||法 国 政 府 实 在 屡 次 尝 试 驱 散 集 会 和 镇 压 运 动 未 果 后 ， 不 愿 看 到 流 血 事 件 再 度 重 演 ， 宣 布 辞 职 以 重 新 开 展 选 举 。 但 是 官 僚 机 构 已 经 在 运 动 的 冲 击 下 失 去 了 效 能 ， 大 街 上 ， 仅 能 看 见 各 派 势 力 的 “ 武 斗 ” 以 及 他 们 同 警 察 力 量 的 斗 争 。 建 制 势 力 不 会 因 为 一 时 的 混 乱 而 退 缩 或 自 发 迎 来 终 局 ， 不 能 再 等 下 去 了 ， 我 们 也 许 应 该 做 点 什 么 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 支 持 人 民 革 命 联 盟";
		button_text[1] = " 支 持 革 命 工 人 组 织";
		button_text[2] = " 支 持 民 族 主 义 组 织";
		button_text[3] = " 法 国 人 关 我 们 什 么 事 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 第 二 次 五 月 风 暴";
		a.modifies[42].active = false;
		a.modifies[43].active = false;
		a.modifies[44].active = false;
		a.modifies[45].active = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (result_num == 0)
		{
			num++;
			a.data[9] -= 150;
			a.data[8] -= 150;
			a.data[22] -= 150;
		}
		if (result_num == 1)
		{
			num2++;
			a.data[9] -= 150;
			a.data[8] -= 150;
			a.data[22] -= 150;
		}
		if (result_num == 2)
		{
			num3++;
			a.data[9] -= 150;
			a.data[8] -= 150;
			a.data[22] -= 150;
		}
		if (a.allcountries[86].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[87].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[85].Gosstroy == 1 || a.allcountries[85].SubGosstroy == 10)
		{
			num++;
		}
		if (a.allcountries[92].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[92].SubGosstroy == 18)
		{
			num2 += 2;
		}
		if (a.allcountries[44].SubGosstroy == 18)
		{
			num2 += 2;
		}
		if (a.allcountries[1].SubGosstroy == 18)
		{
			num2 += 2;
		}
		if (a.allcountries[92].SubGosstroy == 7)
		{
			num3++;
		}
		if (a.allcountries[86].SubGosstroy == 7)
		{
			num3++;
		}
		if (a.allcountries[86].SubGosstroy == 9)
		{
			num3++;
		}
		if (a.allcountries[85].SubGosstroy == 7)
		{
			num3++;
		}
		if (a.allcountries[85].SubGosstroy == 9)
		{
			num3++;
		}
		if (a.allcountries[87].SubGosstroy == 7)
		{
			num3++;
		}
		if (a.allcountries[85].SubGosstroy == 10)
		{
			num3 += 3;
		}
		if (num >= num2 && num >= num3)
		{
			text = " 在 各 方 协 调 下 ， <color=#DC143C>“ 直 接 行 动 ”</color> 、 <color=#DC143C>“ 人 民 自 治 武 装 核 心 ”</color> 、 <color=#DC143C>“ 红 色 海 报 ”</color> 等 毛 主 义 的 城 市 游 击 队 ， 在 西 欧 革 命 国 家 （ 西 欧 多 个 左 翼 城 市 游 击 队 都 是 盟 友 关 系 ） 的 协 助 下 ， 他 们 正 式 达 成 了 和 解 ， 而 各 个 革 命 国 家 将 负 责 为 他 们 提 供 一 切 支 持 ， 成 为 他 们 的 后 勤 基 地 。 他 们 被 改 组 为 正 式 的 法 兰 西 人 民 革 命 游 击 军 ， 作 为 <color=red>人 民 革 命 联 盟</color> 附 属 的 武 装 力 量 ， 并 积 极 在 学 生 和 工 人 中 发 展 潜 在 的 成 员 和 同 情 者 。 毛 派 从 此 作 为 一 个 统 一 的 力 量 参 与 到 这 场 法 国 的 “ 全 面 内 战 ” 之 中 了 。||毛 主 义 者 们 认 识 到 不 能 再 像 上 次 一 样 各 自 为 战 ， 而 是 应 该 发 起 全 国 暴 动 ， 于 是 ， 真 正 的 革 命 开 始 了 。 在 意 大 利 的 帮 助 下 ， 马 赛 成 为 了 首 义 之 城 。 随 着 工 运 和 学 运 的 蔓 延 ， 通 过 工 人 武 装 和 城 市 游 击 队 暴 动 很 快 就 蔓 延 到 全 国 。 得 益 于 意 大 利 和 西 班 牙 对 法 国 军 队 的 渗 透 ， 法 国 军 队 经 历 了 一 次 内 部 火 并 ， 我 们 的 特 工 趁 乱 打 开 了 武 器 库 ， 很 快 ， 在 <color=red>人 民 革 命 联 盟</color> 帮 助 下 ， 市 民 军 和 工 人 武 装 都 获 得 了 武 器 ， 他 们 也 被 编 入 人 民 革 命 游 击 军 。 “ 为 了 不 让 皮 埃 尔 · 奥 弗 尼 事 件 重 演 ， 工 人 们 起 来 斗 争 ！ ” 成 为 了 他 们 的 口 号 。 <color=red>人 民 革 命 联 盟</color> 领 袖 <color=red>阿 兰 · 巴 迪 欧</color> 宣 布 ： “ 一 切 权 力 归 法 兰 西 公 社 ！ ” 在 革 命 阵 营 的 干 预 下 ， 意 大 利 和 葡 萄 牙 的 志 愿 部 队 直 接 介 入 到 小 型 内 战 中 ， 毛 主 义 者 在 他 们 的 帮 助 下 很 快 接 管 了 法 国 。 大 局 已 定 ， 革 命 尚 未 结 束 ， 曙 光 已 经 到 来 。";
			a.allcountries[21].LeaveAlliances();
			a.allcountries[21].Gosstroy = 1;
			a.allcountries[21].SubGosstroy = 17;
			if (result_num == 0)
			{
				a.allcountries[21].Torg = true;
				a.allcountries[21].proprc = true;
				a.allcountries[21].JoinAllOurAlliances(yes: true);
			}
		}
		else if (num2 >= num && num2 >= num3)
		{
			text = " <color=#8B0000>“ 战 斗 ” 派</color> 在 英 国 的 胜 利 使 得 全 世 界 的 托 洛 茨 基 主 义 者 看 到 了 曙 光 ， 而 他 们 在 法 国 的 同 志 显 然 也 抓 住 了 第 二 次 五 月 风 暴 动 荡 局 势 的 契 机 。 官 僚 化 的 斯 大 林 主 义 显 然 不 是 能 够 与 托 洛 茨 基 主 义 的 真 正 革 命 派 抗 衡 的 ！ 英 国 执 政 的 <color=#8B0000>工 党 “ 战 斗 ” 派</color> 决 定 向 他 们 的 同 志 发 出 援 助 。 <color=#8B0000>欧 内 斯 特 · 曼 德 尔</color> 也 再 次 来 到 了 法 国 ， 参 与 和 声 援 托 派 的 运 动 。 他 们 发 出 号 召 ， 邀 请 全 世 界 的 支 持 者 来 法 国 参 加 革 命 运 动 。 托 派 工 会 被 组 织 成 赤 卫 队 ， 工 人 通 过 占 领 大 量 的 国 家 机 构 ， 并 在 英 国 特 工 和 支 援 部 队 以 及 世 界 各 地 托 派 的 国 际 纵 队 的 的 帮 助 下 ， <color=#8B0000>革 命 工 人 组 织</color> 最 终 控 制 了 全 国 局 势 。";
			a.allcountries[21].Gosstroy = 1;
			a.allcountries[21].SubGosstroy = 18;
			a.allcountries[21].LeaveAlliances();
			if (result_num == 1)
			{
				a.allcountries[21].Torg = true;
				a.allcountries[21].proprc = true;
				if (a.allcountries[1].SubGosstroy == 18)
				{
					a.allcountries[21].JoinAllOurAlliances(yes: true);
				}
			}
		}
		else if (num3 >= num && num3 >= num2)
		{
			if (a.allcountries[85].SubGosstroy == 10)
			{
				text = " 在 意 大 利 纳 粹 毛 主 义 者 取 得 胜 利 的 情 况 下 ， 法 国 许 多 人 都 看 到 了 这 一 模 式 的 可 行 性 ， 从 而 使 其 在 第 二 次 五 月 风 暴 的 情 况 下 博 得 了 大 批 支 持 者 ， 让 · 蒂 里 亚 特 也 趁 此 机 会 来 到 了 法 国 。 法 国 动 荡 局 势 和 国 家 机 器 的 瘫 痪 使 得 军 中 的 保 守 派 系 和 法 国 国 家 安 全 机 构 将 目 光 投 向 了 这 批 在 运 动 中 活 跃 的 “ 民 族 毛 主 义 者 ” 。   “ 如 果 再 不 迅 速 扭 转 局 面 ， 广 大 先 烈 （ 指 镇 压 五 月 风 暴 的 军 队 ） 用 鲜 血 创 造 出 来 的 第 五 共 和 国 的 前 途 和 命 运 ， 就 面 临 着 最 严 重 的 威 胁 ！ ” 欧 洲 右 翼 的 崛 起 也 为 法 国 带 来 了 契 机 。 在 他 们 的 支 持 下 ， 各 个 城 市 游 击 队 都 被 整 合 成 了 “ 革 命 战 斗 队 ”   ， 用 以 直 接 与 左 翼 各 派 力 量 进 行 街 头 火 并 。 但 是 凡 事 都 是 有 代 价 的 。 法 国 军 队 在 现 在 国 家 混 乱 的 局 势 下 被 这 些 团 体 渗 透 了 个 遍 ， 在 见 识 到 文 官 政 府 的 软 弱 无 能 后   “ 真 正 的 民 族 斗 士 ” 们 决 定 接 管 这 个 国 家 ， 他 们 将 坦 克 开 到 了 香 榭 丽 舍 大 街 上 ， 民 族 主 义 者 控 制 的 军 队 和 “ 民 族 毛 主 义 者 ” 们 一 起 接 管 了 整 个 法 国 。 第 五 共 和 国 保 住 了 吗 … … ？ ";
				a.allcountries[21].Gosstroy = 0;
				a.allcountries[21].SubGosstroy = 10;
			}
			else
			{
				text = " 法 国 动 荡 局 势 和 国 家 机 器 的 瘫 痪 使 得 军 中 的 保 守 派 系 和 法 国 国 家 安 全 机 构 将 目 光 投 向 了 在 运 动 中 活 跃 的 极 右 派 。 “ 如 果 再 不 迅 速 扭 转 局 面 ， 广 大 先 烈 （ 指 镇 压 五 月 风 暴 的 军 队 ） 用 鲜 血 创 造 出 来 的 第 五 共 和 国 的 前 途 和 命 运 ， 就 面 临 着 最 严 重 的 威 胁 ！ ” 欧 洲 右 翼 的 崛 起 也 为 法 国 带 来 了 契 机 。 在 他 们 的 支 持 下 ， 各 个 右 翼 城 市 游 击 队 都 被 整 合 成 了 “ 民 族 战 斗 队 ”   ， 用 以 直 接 与 左 翼 各 派 力 量 进 行 街 头 火 并 。 但 是 凡 事 都 是 有 代 价 的 。 法 国 军 队 在 现 在 国 家 混 乱 的 局 势 下 被 右 翼 团 体 渗 透 了 个 遍 ， 在 见 识 到 文 官 政 府 的 软 弱 无 能 后   “ 真 正 的 民 族 斗 士 ” 们 决 定 接 管 这 个 国 家 ， 他 们 将 坦 克 开 到 了 香 榭 丽 舍 大 街 上 ， 民 族 主 义 者 控 制 的 军 队 和 极 右 翼 一 起 接 管 了 整 个 法 国 。 第 五 共 和 国 保 住 了 吗 … … ？ 现 在 他 们 决 定 将 屠 刀 伸 向 左 翼 ， 并 开 始 他 们 的 奋 斗 … … ";
				a.allcountries[21].Gosstroy = 0;
				a.allcountries[21].SubGosstroy = 9;
			}
			a.allcountries[21].LeaveAlliances();
			if (result_num == 2)
			{
				a.allcountries[21].Torg = true;
				a.allcountries[21].proprc = true;
			}
		}
		for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
		{
			if (a.allcountries[i].puppetOf == 21)
			{
				a.allcountries[i].puppetOf = -1;
				a.allcountries[i].LeaveAlliances();
				a.allcountries[i].EstablishGovernment(Government.ProAmerican);
			}
		}
	}
}
