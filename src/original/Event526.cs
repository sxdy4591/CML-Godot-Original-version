using EventsForDLC;
using UnityEngine;

public class Event526 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 没 有 玫 瑰 ， 只 有 拳 头";
		text = " 自 森 户 — — 稻 村 争 论 以 来 ， 日 本 <color=green>社 会 党</color> 一 直 维 持 着 左 派 优 位 的 机 制 。 相 较 于 其 他 国 家 的 <color=green>社 会 党</color> ， 它 显 得 十 分 左 倾 与 激 进 。 1 9 6 4   年 ， <color=green>社 会 党</color> 确 定 了 纲 领 性 文 件 《 日 本 通 向 社 会 主 义 之 路 》 ， 该 文 件 深 受 党 内 最 大 的 左 派 派 阀 — — 主 张 “ 和 平 革 命 论 ” 的 <color=red>社 会 主 义 协 会</color> 的 影 响 ， 并 成 为 该 党 事 实 上 的 纲 领 。   1 9 6 6   年 对 该 纲 领 的 修 订 则 进 一 步 包 含 了 有 效 确 认 无 产 阶 级 专 政 的 措 辞 。 <color=green>社 会 党</color> 也 由 此 成 为 了 一 个 带 有 强 烈 马 克 思 主 义 色 彩 的 左 翼 政 党 。||此 时 的 <color=green>社 会 党</color> 内 ， 以 <color=red>社 会 主 义 协 会</color> 为 代 表 的 左 派 始 终 坚 持 <color=green>社 会 党</color> 是 一 个 要 推 翻 当 前 资 本 主 义 制 度 ， 建 立 社 会 主 义 的 “ 反 建 制 ” 政 党 。 而 以 江 田 三 郎 为 代 表 的 <color=yellow>改 革 派</color> 则 希 望 <color=green>社 会 党</color> 能 够 专 注 于 议 会 斗 争 和 选 举 ， 适 应 当 前 的 社 会 阶 层 变 化 ， 淡 化 阶 级 色 彩 并 解 决 工 会 依 赖 等 问 题 ， 成 为 一 个 西 欧 式 的 社 会 民 主 主 义 政 党 以 确 保 稳 定 执 政 。||1 9 7 6 与 次 年 的 众 参 两 院 选 举 中 ， <color=green>社 会 党</color> 并 未 抓 住 完 成 “ 参 政 交 代 ” 的 大 好 机 会 ， 依 旧 维 持 了 尴 尬 的 在 野 党 地 位 ， 这 让 <color=green>社 会 党</color> 内 部 的 矛 盾 进 一 步 激 化 。 <color=red>社 会 主 义 协 会</color> 和 <color=yellow>改 革 派</color> 互 相 指 责 ， 争 论 不 休 。 而 在 中 苏 问 题 上 ， 亲 华 的 佐 佐 木 派 与 亲 苏 的 <color=red>社 会 主 义 协 会</color> 又 爆 发 了 激 烈 冲 突 。 最 终 ， <color=green>社 会 党</color> 内 逐 渐 形 成 了 “ 协 会 派 ” 与 “ 反 协 会 派 ” 两 股 力 量 。||现 在 是 我 们 选 择 的 时 刻 了 ： 是 支 持 反 协 会 派 并 促 使 <color=green>社 会 党</color> 完 成 进 一 步 的 转 型 ， 还 是 支 持 <color=red>社 会 主 义 协 会</color> 反 对 改 革 ？ 需 要 提 醒 的 是 ， <color=red>社 会 主 义 协 会</color> 秉 持 的 是 劳 农 派 马 克 思 主 义 思 想 ， 一 直 反 对 马 列 主 义 这 样 的 “ 极 左 思 潮 ” ， 且 由 于 其 纲 领 特 性 一 直 被 指 责 是 “ 以 1 9 世 纪 的 发 展 中 国 家 的 德 国 的 考 茨 基 为 模 范 的 理 论 的 正 统 派 ” 。 而 佐 佐 木 派 虽 然 与 <color=red>社 会 主 义 协 会</color> 不 和 ， 但 也 不 喜 欢 <color=yellow>改 革 派</color> 的 改 革 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] > 0 && a.data[56] < 3)
		{
			button_text[0] = " 终 结 社 会 主 义 协 会 的 垄 断 地 位 并 调 解 派 系 矛 盾";
		}
		else if (a.data[56] == 0)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 和 修 正 主 义 和 解 ？ 你 也 想 开 修 了 ？";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 和 一 群 死 不 接 受 民 主 观 念 的 人 合 作 ？";
		}
		if (a.data[56] < 2)
		{
			button_text[1] = " 坚 决 支 持 协 会 派 捍 卫 “ 革 命 性 ”";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 左 派 的 社 会 实 践 太 多 了 ！";
		}
		button_text[2] = " 试 图 劝 说 各 派 放 下 分 歧";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 没 有 玫 瑰 ， 只 有 拳 头";
		if (result_num == 0)
		{
			text = " 我 们 很 快 与 佐 佐 木 派 、 <color=yellow>改 革 派</color> 等 大 小 派 系 建 立 了 联 系 （ 江 田 三 郎 与 佐 佐 木 更 三 都 曾 多 次 访 华 ， 这 让 我 们 的 介 入 更 加 顺 利 ） ， 并 参 与 到 它 们 的 矛 盾 调 解 中 。||不 久 在 <color=green>社 会 党</color> 的 中 央 会 议 上 ， <color=red>社 会 主 义 协 会</color> 遭 到 其 他 各 派 别 联 合 起 来 的 猛 烈 攻 击 ， 最 终 不 得 不 “ 承 认 自 身 错 误 ” 并 同 意 展 开 自 我 整 肃 。 <color=green>社 会 党</color> 长 期 的 左 派 优 位 体 制 终 于 得 到 了 改 变 。 而 另 一 方 面 ， 在 我 们 的 斡 旋 下 ， 原 先 <color=yellow>改 革 派</color> 的 激 进 主 张 也 得 到 了 修 改 。 现 在 的 <color=green>社 会 党</color> 开 始 与 英 国 工 党 对 标 ， 开 始 向 民 主 社 会 主 义 进 行 转 型 。 但 需 要 指 出 的 是 ， 该 党 并 未 完 全 切 断 与 科 学 社 会 主 义 的 联 系 ， 《 日 本 通 向 社 会 主 义 之 路 》 的 党 纲 也 在 一 定 程 度 上 得 到 了 保 留 。 且 <color=red>社 会 主 义 协 会</color> 依 旧 掌 握 着 大 量 的 基 层 活 动 家 。 考 虑 到 <color=green>社 会 党</color> 目 前 的 变 化 ， 现 任 书 记 长 成 田 知 巳 决 定 辞 去 书 记 长 的 职 务 ， 曾 任 横 滨 市 市 长 的 飞 鸟 田 一 雄 接 替 了 他 的 位 置 。||不 管 怎 样 ， 内 部 的 矛 盾 得 到 了 暂 时 的 解 决 。 团 结 起 来 的 <color=green>社 会 党</color> 已 经 准 备 好 为 了 完 成 “ 参 政 交 代 ” 而 再 次 努 力 了 。 ";
			a.data[8] -= 80;
			a.data[9] -= 80;
			a.data[1] += 50;
			a.data[3] += 50;
			a.data[6] -= 10;
			a.empires[0].relations += 50;
		}
		if (result_num == 1)
		{
			text = " 我 们 选 择 支 持 <color=red>社 会 主 义 协 会</color> 。 尽 管 该 派 别 所 坚 持 的 并 非 真 正 的 马 克 思 列 宁 主 义 ， 但 支 持 它 总 比 支 持 伯 恩 施 坦 路 线 要 好 ， 对 吧 ？||不 久 在 <color=green>社 会 党</color> 的 中 央 会 议 上 ， <color=red>社 会 主 义 协 会</color> 遭 到 各 派 系 的 猛 烈 攻 击 。 但 凭 借 着 对 <color=green>社 会 党</color> 中 基 层 组 织 与 相 关 青 年 活 跃 组 织 的 强 有 力 掌 控 ， 该 派 系 还 是 挺 过 了 这 次 攻 击 。 而 江 田 三 郎 本 人 更 是 被 几 个 激 进 的 <color=red>社 会 主 义 协 会</color> 成 员 骂 道 ： “ 老 东 西 ， 去 死 吧 。 ” 这 也 宣 布 了 各 派 之 间 的 彻 底 决 裂 。 不 久 <color=yellow>改 革 派</color> 成 员 宣 布 退 出 <color=green>社 会 党</color> ， 并 筹 划 组 建 <color=yellow>社 会 民 主 联 合</color> 。 而 <color=red>社 会 主 义 协 会</color> 借 此 机 会 对 党 内 其 他 派 系 进 行 了 进 一 步 打 击 ， 巩 固 了 自 身 的 地 位 。 同 时 在 我 们 的 帮 助 下 ， 协 会 派 扩 大 了 基 层 组 织 ， 开 始 进 一 步 深 入 工 会 、 农 村 之 中 。||协 会 派 的 举 措 遭 到 了 党 内 外 的 许 多 责 难 ， 特 别 是 当 江 田 三 郎 这 位 <color=green>社 会 党</color> 老 党 员 在 退 党 不 久 就 因 肺 癌 去 世 后 。 为 了 稳 住 局 势 ， <color=red>社 会 主 义 协 会</color> 一 方 面 进 行 了 一 定 让 步 ， 同 意 展 开 自 我 整 肃 。 另 一 方 面 也 强 调 这 是 维 护 “ 革 命 路 线 ” 的 无 奈 之 举 。 为 了 更 好 地 发 挥 力 量 ， 数 月 后 的 党 大 会 上 ， <color=green>社 会 党</color> 正 式 宣 布 解 散 派 阀 。 同 时 在 左 派 的 支 持 下 ， 成 田 知 巳 继 续 担 任 <color=green>社 会 党</color> 的 书 记 长 。||尽 管 <color=green>社 会 党</color> 由 于 右 派 出 走 实 力 被 削 弱 ， 但 相 对 的 ， 我 们 对 <color=green>社 会 党</color> 的 影 响 力 也 得 到 了 增 强 。 且 地 位 愈 发 巩 固 的 <color=green>社 会 党</color> 左 派 已 经 准 备 好 在 今 后 的 选 举 中 进 一 步 动 员 劳 工 阶 层 以 实 现 其 目 标 了 。";
			a.data[8] -= 80;
			a.data[9] -= 80;
			a.data[1] += 50;
			a.data[3] += 50;
			a.data[6] += 10;
			a.empires[0].relations -= 50;
			a.influencePRC += 10;
		}
		if (result_num == 2)
		{
			text = " 我 们 与 <color=green>社 会 党</color> 内 部 的 各 个 派 系 均 取 得 了 联 系 ， 希 望 他 们 能 互 相 妥 协 并 提 出 了 一 份 方 案 。 但 由 于 他 们 在 关 键 问 题 上 的 互 不 让 步 ， 谈 判 最 终 不 了 了 之 。||不 久 在 <color=green>社 会 党</color> 的 中 央 会 议 上 ， <color=red>社 会 主 义 协 会</color> 遭 到 各 派 系 的 猛 烈 攻 击 。 但 凭 借 着 对 <color=green>社 会 党</color> 中 基 层 组 织 与 相 关 青 年 活 跃 组 织 的 强 有 力 掌 控 ， 该 派 系 还 是 挺 过 了 这 次 攻 击 。 而 江 田 三 郎 本 人 更 是 被 几 个 激 进 的 <color=red>社 会 主 义 协 会</color> 成 员 骂 道 ： “ 老 东 西 ， 去 死 吧 。 ” 这 也 宣 布 了 各 派 之 间 的 彻 底 决 裂 。 不 久 <color=yellow>改 革 派</color> 成 员 宣 布 退 出 <color=green>社 会 党</color> ， 并 筹 划 组 建 <color=yellow>社 会 民 主 联 合</color> 。||<color=red>社 会 主 义 协 会</color> 的 行 为 遭 到 了 党 内 外 的 一 致 谴 责 ， 特 别 是 当 江 田 三 郎 这 位 <color=green>社 会 党</color> 老 党 员 在 退 党 不 久 就 因 肺 癌 去 世 后 。 为 了 稳 住 局 势 ， <color=red>社 会 主 义 协 会</color> 不 得 不 有 所 退 让 ， 同 意 展 开 自 我 整 肃 。 同 时 一 直 支 持 <color=red>社 会 主 义 协 会</color> 的 书 记 长 成 田 知 巳 也 饱 受 质 疑 ， 最 终 他 宣 布 辞 职 。 曾 任 横 滨 市 市 长 的 飞 鸟 田 一 雄 接 替 了 他 的 位 置 。 <color=green>社 会 党</color> 的 内 部 纷 争 仍 未 解 决 ， 且 该 党 的 大 众 形 象 也 进 一 步 受 损 ， 很 难 说 它 在 今 后 的 国 会 选 举 中 能 有 怎 样 的 成 绩 。";
		}
	}
}
