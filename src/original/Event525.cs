using EventsForDLC;
using UnityEngine;

public class Event525 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 革 新 政 权 还 是 社 会 主 义 ？";
		text = " 依 靠 革 新 口 号 以 及 大 众 对 <color=#0000FF>自 由 民 主 党</color> 长 期 积 攒 的 不 满 ， <color=#008000>社 会 党</color> 、 <color=#FFFF00>公 明 党</color> 与 <color=#FFA500>民 主 社 会 党</color> 成 功 赢 得 选 举 并 建 立 联 合 政 府 。 而 <color=#008000>社 会 党</color> 作 为 新 政 府 的 核 心 ， 自 然 也 成 了 未 来 施 政 方 针 的 操 盘 手 ， 并 开 始 进 行 一 系 列 举 措 ： 着 手 组 织 废 除 《 日 美 安 保 条 约 》 的 相 关 谈 判 、 推 动 部 门 企 业 国 有 化 、 筹 备 国 家 计 划 委 员 会 、 扩 大 工 人 权 利 等 等 。 这 些 政 策 得 到 了 工 农 群 体 的 拥 护 ， <color=#008000>社 会 党</color> 的 支 持 者 也 有 所 增 多 。||但 随 着 政 策 的 进 一 步 推 行 ， 诸 多 问 题 也 随 之 而 来 ： 在 野 的 <color=#0000FF>自 由 民 主 党</color> 在 众 多 议 题 上 大 力 阻 挠 ， 并 指 挥 自 己 所 掌 控 的 媒 体 持 续 抨 击 政 府 ， 部 分 高 层 已 经 开 始 秘 密 与 联 合 政 府 的 其 他 两 党 的 中 央 委 员 接 触 ； 美 国 也 对 新 政 府 的 举 措 感 到 不 安 ， 国 务 卿 万 斯 对 日 本 的 “ 越 界 行 为 ” 发 出 了 警 告 ； 联 合 政 府 内 部 的 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 同 样 希 望 <color=#008000>社 会 党</color> 能 够 放 弃 一 些 过 于 激 进 的 主 张 ， 减 少 乃 至 最 终 切 断 与 <color=#8B0000>共 产 党</color> 的 联 系 ， 并 摆 脱 “ 劳 组 斗 士 ” 、 “ 社 共 共 斗 ” 这 样 的 标 签 ， 真 正 为 一 个 “ 符 合 国 民 期 望 的 ” 革 新 政 权 而 努 力 。||即 便 是 <color=#008000>社 会 党</color> 内 部 此 时 也 并 不 太 平 。 受 到 上 届 大 选 胜 利 的 鼓 舞 ， 以 江 田 三 郎 为 代 表 的 <color=yellow>改 革 派</color> 趁 机 主 张 <color=#008000>社 会 党</color> 的 进 一 步 改 革 ， 希 望 该 党 最 终 成 为 西 欧 式 的 社 会 民 主 主 义 政 党 以 确 保 稳 定 执 政 。 而 党 内 最 大 的 派 别 （ 也 是 <color=#008000>社 会 党</color> 意 识 形 态 路 线 的 掌 舵 手 ） ， 以 向 坂 逸 郎 为 代 表 的 <color=red>社 会 主 义 协 会</color> 则 坚 持 <color=#008000>社 会 党</color> 阶 级 政 党 的 定 性 ， 强 调 “ 和 平 革 命 论 ” 和 “ 社 会 主 义 革 命 的 必 要 性 ” ， 并 与 苏 联 保 持 友 好 关 系 。 而 这 不 仅 让 其 与 <color=yellow>改 革 派</color> 之 间 势 不 两 立 ， 也 让 亲 华 的 佐 佐 木 派 对 <color=red>社 会 主 义 协 会</color> 愈 发 不 满 。 最 终 ， <color=#008000>社 会 党</color> 内 逐 渐 形 成 了 “ 协 会 派 ” 与 “ 反 协 会 派 ” 两 股 力 量 。||现 在 是 我 们 选 择 的 时 刻 了 ： 是 支 持 反 协 会 派 并 促 使 <color=#008000>社 会 党</color> 完 成 进 一 步 的 转 型 ， 还 是 支 持 <color=red>社 会 主 义 协 会</color> 反 对 <color=yellow>改 革 派</color> 的 “ 右 倾 改 革 ” ？ 需 要 提 醒 的 是 ， <color=red>社 会 主 义 协 会</color> 秉 承 的 是 劳 农 派 马 克 思 主 义 思 想 ， 一 直 反 对 马 列 主 义 这 样 的 “ 极 左 思 潮 ” ， 且 由 于 其 纲 领 特 性 一 直 被 指 责 是 “ 以 1 9 世 纪 的 发 展 中 国 家 的 德 国 的 考 茨 基 为 模 范 的 理 论 的 正 统 派 ” 。 而 佐 佐 木 派 虽 然 与 <color=red>社 会 主 义 协 会</color> 不 和 ， 但 也 不 喜 欢 <color=yellow>改 革 派</color> 的 改 革 。";
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
		name = " 革 新 政 权 还 是 社 会 主 义 ？";
		if (result_num == 0)
		{
			text = " 我 们 很 快 与 佐 佐 木 派 、 <color=yellow>改 革 派</color> 等 大 小 派 系 建 立 了 联 系 （ 江 田 三 郎 与 佐 佐 木 更 三 都 曾 多 次 访 华 ， 这 让 我 们 的 介 入 更 加 顺 利 ） ， 并 参 与 到 它 们 的 矛 盾 调 解 中 。||不 久 在 <color=#008000>社 会 党</color> 的 中 央 会 议 上 ， <color=red>社 会 主 义 协 会</color> 遭 到 其 他 各 派 别 联 合 起 来 的 猛 烈 攻 击 ， 最 终 不 得 不 “ 承 认 自 身 错 误 ” 并 同 意 展 开 自 我 整 肃 。 <color=#008000>社 会 党</color> 长 期 的 左 派 优 位 体 制 终 于 得 到 了 改 变 。 而 另 一 方 面 ， 在 我 们 的 斡 旋 下 ， 原 先 <color=yellow>改 革 派</color> 的 激 进 主 张 也 得 到 了 修 改 。 现 在 的 <color=#008000>社 会 党</color> 开 始 与 英 国 工 党 对 标 ， 开 始 向 民 主 社 会 主 义 进 行 转 型 。 但 需 要 指 出 的 是 ， 该 党 并 未 完 全 切 断 与 科 学 社 会 主 义 的 联 系 ， 《 日 本 通 向 社 会 主 义 之 路 》 的 党 纲 也 在 一 定 程 度 上 得 到 了 保 留 。 且 <color=red>社 会 主 义 协 会</color> 依 旧 掌 握 着 大 量 的 基 层 活 动 家 。||无 论 如 何 ， <color=#008000>社 会 党</color> 的 内 部 危 机 暂 时 得 到 了 解 决 。 数 月 后 的 党 大 会 上 ， <color=#008000>社 会 党</color> 正 式 宣 布 解 散 派 阀 。 <color=#FFFF00>公 明 党</color> 与 <color=#FFA500>民 主 社 会 党</color> 对 <color=#008000>社 会 党</color> 的 改 变 表 示 欢 迎 ， 并 宣 布 将 根 据 <color=#008000>社 会 党</color> 的 新 情 况 对 自 身 的 纲 领 路 线 也 展 开 调 整 。 就 这 样 ， 联 合 政 权 更 加 稳 固 了 。";
			a.data[8] -= 80;
			a.data[9] -= 80;
			a.data[1] += 50;
			a.data[3] += 50;
			a.data[6] -= 10;
			a.empires[0].relations += 50;
		}
		if (result_num == 1)
		{
			text = " 我 们 选 择 支 持 <color=red>社 会 主 义 协 会</color> 。 尽 管 该 派 别 所 坚 持 的 并 非 真 正 的 马 克 思 列 宁 主 义 ， 但 支 持 它 总 比 支 持 伯 恩 施 坦 路 线 要 好 ， 对 吧 ？||不 久 在 <color=#008000>社 会 党</color> 的 中 央 会 议 上 ， <color=red>社 会 主 义 协 会</color> 遭 到 各 派 系 的 猛 烈 攻 击 。 但 凭 借 着 对 <color=#008000>社 会 党</color> 中 基 层 组 织 与 相 关 青 年 活 跃 组 织 的 强 有 力 掌 控 ， 该 派 系 还 是 挺 过 了 这 次 攻 击 。 而 江 田 三 郎 本 人 更 是 被 几 个 激 进 的 <color=red>社 会 主 义 协 会</color> 成 员 骂 道 ： “ 老 东 西 ， 去 死 吧 。 ” 这 也 宣 布 了 各 派 之 间 的 彻 底 决 裂 。 不 久 <color=yellow>改 革 派</color> 成 员 宣 布 退 出 <color=#008000>社 会 党</color> ， 并 筹 划 组 建 <color=yellow>社 会 民 主 联 合</color> 。 而 <color=red>社 会 主 义 协 会</color> 借 此 机 会 对 党 内 其 他 派 系 进 行 了 进 一 步 打 击 ， 巩 固 了 自 身 的 地 位 。 同 时 在 我 们 的 帮 助 下 ， 协 会 派 扩 大 了 基 层 组 织 ， 开 始 进 一 步 深 入 工 会 、 农 村 之 中 。||社 会 主 义 协 会 的 举 措 遭 到 了 党 内 外 的 许 多 责 难 ， 特 别 是 当 江 田 三 郎 这 位 <color=#008000>社 会 党</color> 老 党 员 在 退 党 不 久 就 因 肺 癌 去 世 后 。 为 了 稳 住 局 面 ， <color=red>社 会 主 义 协 会</color> 一 方 面 进 行 了 一 定 让 步 ， 同 意 展 开 自 我 整 肃 。 另 一 方 面 也 强 调 这 是 维 护 “ 革 命 路 线 ” 的 无 奈 之 举 。 为 了 更 好 地 发 挥 力 量 ， 数 月 后 的 党 大 会 上 ， <color=#008000>社 会 党</color> 正 式 宣 布 解 散 派 阀 。 同 时 在 左 派 的 支 持 下 ， 成 田 知 巳 继 续 担 任 <color=#008000>社 会 党</color> 的 书 记 长 。||公 明 党 和 <color=#FFA500>民 主 社 会 党</color> 对 <color=#008000>社 会 党</color> 的 内 部 纷 争 感 到 失 望 ， 联 合 政 府 的 不 稳 定 因 素 有 所 增 加 。 但 相 对 的 ， 我 们 对 <color=#008000>社 会 党</color> 的 影 响 力 也 得 到 了 增 强 。 且 地 位 愈 发 巩 固 的 <color=#008000>社 会 党</color> 左 派 已 经 准 备 好 在 今 后 的 选 举 中 进 一 步 动 员 劳 工 阶 层 以 实 现 其 目 标 了 。 ";
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
			text = " 我 们 与 <color=#008000>社 会 党</color> 内 部 的 各 个 派 系 均 取 得 了 联 系 ， 希 望 他 们 能 互 相 妥 协 并 提 出 了 一 份 方 案 。 但 由 于 他 们 在 关 键 问 题 上 的 互 不 让 步 ， 谈 判 最 终 不 了 了 之 。||不 久 在 <color=#008000>社 会 党</color> 的 中 央 会 议 上 ， <color=red>社 会 主 义 协 会</color> 遭 到 各 派 系 的 猛 烈 攻 击 。 但 凭 借 着 对 <color=#008000>社 会 党</color> 中 基 层 组 织 与 相 关 青 年 活 跃 组 织 的 强 有 力 掌 控 ， 该 派 系 还 是 挺 过 了 这 次 攻 击 。 而 江 田 三 郎 本 人 更 是 被 几 个 激 进 的 <color=red>社 会 主 义 协 会</color> 成 员 骂 道 ： “ 老 东 西 ， 去 死 吧 。 ” 这 也 宣 布 了 各 派 之 间 的 彻 底 决 裂 。 不 久 <color=yellow>改 革 派</color> 成 员 宣 布 退 出 <color=#008000>社 会 党</color> ， 并 筹 划 组 建 <color=yellow>社 会 民 主 联 合</color> 。||社 会 主 义 协 会 的 行 为 遭 到 了 党 内 外 的 一 致 谴 责 ， 特 别 是 当 江 田 三 郎 这 位 <color=#008000>社 会 党</color> 老 党 员 在 退 党 不 久 就 因 肺 癌 去 世 后 。 为 了 稳 住 局 面 ， <color=red>社 会 主 义 协 会</color> 不 得 不 有 所 退 让 ， 同 意 展 开 自 我 整 肃 。 同 时 一 直 支 持 <color=red>社 会 主 义 协 会</color> 的 书 记 长 成 田 知 巳 也 饱 受 质 疑 ， 最 终 他 宣 布 辞 职 。 曾 任 横 滨 市 市 长 的 飞 鸟 田 一 雄 接 替 了 他 的 位 置 。||公 明 党 和 <color=#FFA500>民 主 社 会 党</color> 对 <color=#008000>社 会 党</color> 的 内 部 纷 争 感 到 失 望 ， 一 些 人 已 经 开 始 尝 试 探 索 与 <color=#0000FF>自 由 民 主 党</color> 建 立 联 系 的 尝 试 ， 而 这 个 联 合 政 府 也 愈 发 摇 摇 欲 坠 了 。";
		}
	}
}
