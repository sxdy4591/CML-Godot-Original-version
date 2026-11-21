using EventsForDLC;
using UnityEngine;

public class Event530 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 变 则 善 ， 常 变 则 至 善";
		text = " 1 9 7 9 年 大 选 之 后 ， 在 野 党 的 内 外 问 题 愈 发 复 杂 和 严 重 。 其 中 <color=#008000>社 会 党</color> 又 是 最 突 出 的 那 一 个 。 该 党 的 派 系 斗 争 与 路 线 论 战 并 未 随 着 派 阀 的 解 散 而 彻 底 结 束 ， 而 这 些 争 斗 又 反 过 来 加 深 了 城 市 市 民 眼 中 <color=#008000>社 会 党</color> 的 “ 主 义 ” “ 斗 士 ” “ 派 阀 ” 等 形 象 标 签 — — 恰 恰 是 他 们 所 厌 恶 的 点 。 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 对 于 “ 社 公 民 路 线 ” 也 开 始 不 再 像 以 往 一 样 热 衷 ， 转 而 在 互 相 配 合 的 同 时 与 <color=#0000FF>自 由 民 主 党</color> 进 行 接 触 ， 试 图 实 现 “ 自 公 民 路 线 ” 。||面 对 如 此 局 面 ， <color=#008000>社 会 党</color> 书 记 长 飞 鸟 田 一 雄 决 心 改 革 ， 在 尝 试 修 改 纲 领 、 调 整 路 线 的 同 时 也 与 <color=#FFA500>民 主 社 会 党</color> 和 <color=#FFFF00>公 明 党</color> 展 开 积 极 洽 谈 。 为 了 表 明 决 心 ， <color=#008000>社 会 党</color> 与 <color=#8B0000>日 本 共 产 党</color> 的 关 系 开 始 愈 发 疏 远 ， 这 让 后 者 愤 怒 地 指 责 这 是 <color=#008000>社 会 党</color> “ 在 与 自 民 党 建 立 事 实 上 的 大 联 合 的 道 路 上 迈 出 的 第 一 步 ” 。 而 诸 多 媒 体 对 于 “ 社 公 民 路 线 ” 能 否 得 到 良 好 落 实 也 提 出 了 诸 多 质 疑 。||针 对 当 下 的 情 况 ， 我 们 的 相 关 人 员 提 供 了 两 种 方 案 ： 第 一 种 是 以 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 为 主 体 ， 迫 使 <color=#008000>社 会 党</color> 做 出 彻 底 的 改 变 并 在 此 基 础 上 建 立 一 个 新 的 中 道 革 新 政 党 ； 第 二 种 是 依 靠 工 会 、 青 年 组 织 、 反 战 反 核 团 体 等 社 会 组 织 ， 促 使 <color=#008000>社 会 党</color> 向 <color=#8B0000>共 产 党</color> 靠 拢 以 实 现 曾 经 的 “ 社 共 共 斗 ” 构 想 。 那 么 ， 您 的 选 择 是 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] == 3 && a.resultOfEvents[522] == 1 && a.resultOfEvents[527] == 1 && a.resultOfEvents[525] != 1 && a.resultOfEvents[526] != 1)
		{
			button_text[0] = " 促 使 社 会 党 向 公 明 党 和 民 主 社 会 党 靠 拢";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 人 对 他 们 有 兴 趣";
		}
		if (a.data[56] == 2 && a.resultOfEvents[522] == 1 && a.resultOfEvents[527] == 2 && a.resultOfEvents[525] != 1 && a.resultOfEvents[526] != 1)
		{
			button_text[1] = " 促 使 社 会 党 向 共 产 党 靠 拢";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 人 对 他 们 有 兴 趣";
		}
		button_text[2] = " 关 注 局 势 变 化";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 变 则 善 ， 常 变 则 至 善";
		if (result_num == 0)
		{
			text = " <color=#008000>社 会 党</color> 背 后 的 靠 山 — — 日 本 最 大 的 左 翼 工 会 “ 总 评 ” 在 “ 劳 资 调 和 ” 构 想 盛 行 以 及 企 业 工 人 群 体 日 益 现 实 主 义 化 的 背 景 下 不 断 向 <color=#008000>社 会 党</color> 施 压 ， 要 求 其 做 出 “ 真 正 的 改 变 ” 。 同 时 借 助 亲 华 的 佐 佐 木 派 ， 我 们 派 遣 人 员 成 功 说 服 了 <color=#008000>社 会 党</color> 中 央 的 大 多 数 委 员 。 而 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 在 由 于 先 前 的 援 助 ， 与 我 们 的 关 系 已 经 拉 近 ， 在 与 两 党 委 员 长 多 次 沟 通 之 后 ， 它 们 也 同 意 与 改 革 后 的 <color=#008000>社 会 党</color> 保 持 步 调 一 致 。||不 久 ， <color=#008000>社 会 党</color> 召 开 了 一 次 临 时 党 代 会 ， 并 以 大 比 例 优 势 通 过 了 《 日 本 <color=#008000>社 会 党</color> 的 新 宣 言 — — 爱 、 知 、 力 的 创 造 》 这 一 全 新 纲 领 ， 正 式 抛 弃 了 旧 有 的 《 日 本 通 向 社 会 主 义 之 路 》 。 新 纲 领 强 调 “ 和 平 长 入 社 会 主 义 ” 以 及 市 民 与 国 民 的 概 念 ， 事 实 否 认 了 “ 阶 级 性 ” 的 理 念 。 这 标 志 着 <color=#008000>社 会 党</color> 第 一 次 完 全 抛 弃 了 马 克 思 主 义 ， 踏 入 到 社 会 民 主 主 义 的 行 列 中 。||<color=#008000>社 会 党</color> 党 大 会 后 不 久 ， 其 与 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 在 东 京 召 开 了 一 次 联 合 会 议 并 达 成 协 议 ： 三 党 以 “ 中 道 革 新 ” “ 国 民 先 锋 ” 为 口 号 ， 正 式 合 并 为 <color=#FFA500>日 本 社 会 民 主 党</color> ， 打 出 了 “ 终 结 自 民 党 垄 断 ， 建 立 符 合 国 民 需 求 的 革 新 政 权 ” 的 旗 帜 ， 以 社 会 民 主 主 义 与 护 宪 平 和 主 义 （ 当 然 对 其 中 的 自 卫 队 问 题 、 朝 鲜 半 岛 问 题 等 进 行 了 修 订 ） 为 指 导 思 想 。 很 快 ， <color=#FFA500>社 会 民 主 联 合</color> 也 宣 布 加 入 该 党 。||日 本 媒 体 对 于 三 党 合 并 的 消 息 感 到 惊 讶 。 对 于 这 一 联 盟 在 接 下 来 的 选 举 中 能 取 得 怎 样 的 成 绩 也 有 不 同 的 看 法 。 但 是 对 市 民 阶 层 而 言 ， 一 个 更 具 新 时 代 革 新 色 彩 ， 提 倡 福 利 政 策 且 并 非 传 统 “ 工 会 斗 士 ” 的 左 翼 政 党 显 然 还 是 很 对 他 们 的 胃 口 的 。 一 些 报 纸 已 经 开 始 预 测 在 下 一 届 国 会 选 举 中 ， <color=#FFA500>社 会 民 主 党</color> 有 望 打 破 <color=#0000FF>自 由 民 主 党</color> 的 垄 断 地 位 。 ";
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[1] += 80;
			a.data[3] += 50;
			a.data[4] += 50;
			a.data[6] += 5;
			a.influencePRC += 10;
		}
		if (result_num == 1)
		{
			text = " 我 们 派 出 大 量 人 员 与 <color=#8B0000>共 产 党</color> 和 <color=#008000>社 会 党</color> 的 中 央 委 员 进 行 沟 通 。 在 我 们 此 前 长 期 的 积 极 行 动 下 ， 绝 大 部 分 社 会 组 织 、 青 年 活 动 家 和 工 会 干 部 都 成 功 被 我 们 团 结 了 起 来 ， 借 助 他 们 的 影 响 力 以 及 此 前 与 两 党 打 下 的 关 系 基 础 ， 我 们 最 终 说 服 了 大 多 数 中 央 委 员 ， 尤 其 是 <color=#8B0000>共 产 党</color> 领 导 人 宫 本 显 治 。||不 久 ， <color=#8B0000>日 本 共 产 党</color> 与 <color=#008000>日 本 社 会 党</color> 召 开 了 一 次 联 合 大 会 ， 会 上 宫 本 显 治 正 式 宣 布 将 成 立 以 两 党 为 核 心 ， 囊 括 大 批 社 会 团 体 的 “ <color=#008000>日 本 人 民 民 主 联 合 阵 线</color> ” ， 以 寻 求 “ 超 越 思 想 、 信 仰 和 政 党 支 持 的 差 异 ， 汇 集 大 多 数 人 民 的 革 新 运 动 ” 为 目 标 ， 在 全 国 范 围 内 树 立 新 的 创 新 阵 线 。 <color=#008000>社 会 党</color> 委 员 长 飞 鸟 田 一 雄 也 宣 布 将 与 <color=#8B0000>共 产 党</color> 步 调 一 致 。 总 的 来 说 ， 该 阵 线 的 方 针 是 以 欧 洲 共 产 主 义 的 思 想 为 核 心 ， 并 囊 括 了 非 武 装 中 立 、 无 核 化 政 策 等 理 念 。||日 本 媒 体 对 于 两 党 联 盟 的 消 息 感 到 惊 讶 。 对 于 这 一 联 盟 在 接 下 来 的 选 举 中 能 取 得 怎 样 的 成 绩 也 有 不 同 的 看 法 。 但 是 对 市 民 阶 层 而 言 ， 一 个 更 具 新 时 代 革 新 色 彩 ， 提 倡 福 利 政 策 且 并 非 传 统 “ 工 会 斗 士 ” 的 左 翼 联 盟 至 少 是 可 接 受 的 。 一 些 报 纸 已 经 开 始 预 测 在 下 一 届 国 会 选 举 中 ， <color=#008000>日 本 人 民 民 主 联 合 阵 线</color> 有 望 打 破 <color=#0000FF>自 由 民 主 党</color> 的 垄 断 地 位 。";
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[1] += 80;
			a.data[3] += 50;
			a.data[4] += 50;
			a.data[6] += 5;
			a.influencePRC += 10;
		}
		if (result_num == 2)
		{
			text = " <color=#008000>社 会 党</color> 背 后 的 靠 山 — — 日 本 最 大 的 左 翼 工 会 “ 总 评 ” 在 “ 劳 资 调 和 ” 构 想 盛 行 以 及 企 业 工 人 群 体 日 益 现 实 主 义 化 的 背 景 下 不 断 向 <color=#008000>社 会 党</color> 施 压 ， 要 求 其 做 出 “ 真 正 的 改 变 ” 。 在 飞 鸟 田 一 雄 的 带 领 下 ， <color=#008000>社 会 党</color> 也 最 终 完 全 抛 弃 了 “ 社 共 共 斗 ” 转 而 一 心 建 设 “ 社 公 民 路 线 ” 。 但 在 党 内 纷 争 依 旧 且 与 其 他 在 野 党 摩 擦 不 断 的 情 况 下 ， 大 部 分 媒 体 对 该 路 线 并 不 乐 观 。 <color=#008000>社 会 党</color> “ 万 年 在 野 党 ” 的 尴 尬 名 头 还 将 持 续 下 去 。 而 随 着 国 际 局 势 的 变 化 ， 甚 至 <color=#008000>社 会 党</color> 能 否 继 续 维 持 国 会 第 二 大 党 都 成 了 一 个 问 题 ， 特 别 是 在 工 会 不 再 单 独 支 持 <color=#008000>社 会 党</color> 的 情 况 下 。";
		}
	}
}
