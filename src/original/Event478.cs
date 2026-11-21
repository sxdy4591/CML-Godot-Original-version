using EventsForDLC;
using UnityEngine;

public class Event478 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 燥 热 之 夏 的 延 续 ？";
		text = " 葡 萄 牙 在 康 乃 馨 革 命 后 秩 序 仍 旧 动 荡 不 安 。 温 和 左 翼 与 温 和 右 翼 的 政 府 不 断 更 替 施 政 ， 他 们 都 没 有 为 国 家 带 来 稳 定 ； 而 在 葡 萄 牙 国 内 ， 极 左 翼 与 极 右 翼 又 相 当 活 跃 ， 这 使 得 葡 萄 牙 社 会 动 荡 不 安 。\n 左 翼 方 面 ， 亲 苏 的 正 统 派 <color=red>葡 萄 牙 共 产 党</color> 是 葡 萄 牙 国 内 最 强 大 的 极 左 翼 势 力 ， 它 控 制 了 工 会 ， 并 在 葡 萄 牙 南 方 有 大 量 支 持 者 ， 军 队 内 左 翼 和 他 们 也 较 为 亲 近 ， 不 过 他 们 过 于 痴 迷 议 会 斗 争 ， 缺 乏 破 坏 现 状 的 动 力 ， 但 由 于 形 势 的 变 化 ， 他 们 很 可 能 在 苏 联 的 支 持 下 转 向 更 积 极 的 行 动 ； 反 修 派 的 政 党 较 为 分 散 ， 主 要 是 <color=red>葡 共 （ 重 建 ）</color> 、 <color=red>葡 共 （ 马 列 ）</color> 、 <color=red>无 产 阶 级 革 命 党 - 革 命 旅</color> 以 及 葡 萄 牙 工 人 共 产 党 ， 但 葡 工 共 过 于 右 倾 ， 为 了 反 对 亲 苏 的 葡 共 ， 他 们 甚 至 宁 愿 与 放 弃 马 克 思 主 义 的 社 会 党 打 交 道 ， <color=red>葡 共 （ 重 建 ）</color> 、 <color=red>葡 共 （ 马 列 ）</color> 和 <color=red>无 产 阶 级 革 命 党 - 革 命 旅</color> 则 选 择 与 其 他 极 左 派 组 织 合 流 ； 值 得 关 注 的 还 有 萨 赖 瓦 · 德 · 卡 瓦 略 ， 一 位 曾 经 指 挥 了 康 乃 馨 革 命 的 极 左 翼 政 治 家 ， 他 在 1 9 7 6 年 总 统 选 举 失 利 后 转 向 更 加 激 进 的 武 装 斗 争 与 合 法 斗 争 结 合 的 斗 争 路 线 ， 他 联 合 多 个 极 左 翼 的 政 党 团 体 【 包 括 <color=red>葡 共 （ 重 建 ）</color> 、 <color=red>葡 共 （ 马 列 ）</color> 和 <color=red>无 产 阶 级 革 命 党 - 革 命 旅</color> 】 ， 组 建 了 <color=red>“ 全 球 项 目 ”</color> — — 一 个 集 合 法 政 党 （ <color=red>人 民 团 结 力 量</color> ） 、 城 市 游 击 队 （ <color=red>4 月 2 5 日 人 民 力 量</color> ） 、 统 战 军 队 内 左 翼 于 一 体 的 秘 密 项 目 — — 准 备 更 加 深 入 地 变 革 葡 萄 牙 。 右 翼 方 面 ， 葡 萄 牙 也 存 在 对 康 乃 馨 革 命 后 局 势 不 满 的 军 队 内 右 翼 团 体 与 新 萨 拉 查 主 义 的 政 党 ， 但 是 他 们 与 康 乃 馨 革 命 后 强 大 的 左 翼 潮 流 明 显 不 符 ， 需 要 借 助 外 部 力 量 才 能 动 摇 局 势 … …\n 主 席 ， 我 们 应 该 怎 么 办 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[8] + a.data[36] >= 50 && a.data[9] >= 50)
		{
			button_text[0] = " 支 持 葡 共 的 激 进 化";
			button_text[1] = " 支 持 极 左 翼 的 联 合";
			button_text[2] = " 支 持 极 右 翼 的 联 合";
		}
		else
		{
			Object.Destroy(button[0]);
			Object.Destroy(button[1]);
			Object.Destroy(button[2]);
			button_text[0] = " 我 们 无 暇 顾 及";
			button_text[1] = " 我 们 无 暇 顾 及";
			button_text[2] = " 我 们 无 暇 顾 及";
		}
		button_text[3] = " 不 闻 不 问";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 燥 热 之 夏 的 延 续 ？";
		if (result_num == 0)
		{
			text = " 我 们 联 系 到 <color=red>葡 萄 牙 共 产 党</color> 和 与 军 队 内 左 翼 和 <color=red>葡 共</color> 都 保 持 了 深 入 联 系 的 <color=red>瓦 斯 科 · 贡 萨 尔 维 斯</color> 同 志 ， 为 他 们 送 去 了 活 动 资 金 。 比 起 各 个 四 分 五 裂 的 “ 革 命 派 ” 组 织 ， 他 们 起 码 更 稳 定 ， 在 民 众 中 的 支 持 率 也 更 高 ， 不 是 吗 ？ 不 久 后 ， 有 情 报 表 明 ， 苏 联 也 给 他 们 送 去 了 指 示 以 及 更 多 的 活 动 资 金 — — 他 们 开 始 更 积 极 地 参 与 工 会 活 动 ， 并 同 军 队 内 左 派 联 系 ， 同 时 向 政 府 施 压 ， 要 求 在 革 命 委 员 会 中 任 命 更 多 的 左 派 人 士 。 葡 萄 牙 的 政 治 天 平 向 左 边 稍 稍 倾 斜 了 。";
			a.data[8] -= 50;
			a.data[9] -= 50;
		}
		switch (result_num)
		{
		case 1:
			text = " 我 们 联 系 到 <color=red>“ 全 球 项 目 ”</color> 和 与 军 队 内 左 翼 和 多 个 极 左 翼 的 革 命 马 克 思 主 义 政 党 或 团 体 都 保 持 了 深 入 的 联 系 的 <color=red>萨 赖 瓦 · 德 · 卡 瓦 略</color> 同 志 ， 为 他 们 送 去 了 活 动 资 金 。 <color=red>葡 萄 牙 工 人 共 产 党</color> 在 我 们 的 支 持 下 加 入 了 <color=red>“ 全 球 项 目 ”</color> ， <color=red>“ 全 球 项 目 ”</color> 的 合 法 政 党 人 民 团 结 力 量 开 始 更 积 极 地 与 <color=red>葡 萄 牙 共 产 党</color> 在 工 会 和 民 众 之 中 竞 争 。 他 们 决 定 更 加 深 入 地 融 入 无 产 阶 级 ， 并 在 军 队 中 深 入 发 展 成 员 ， 以 争 取 对 革 命 的 支 持 。 <color=red>“ 全 球 项 目 ”</color> 以 合 法 政 党 <color=red>人 民 团 结 力 量</color> 的 名 义 向 政 府 施 压 ， 要 求 在 革 命 委 员 会 中 任 命 更 多 的 左 派 人 士 。 葡 萄 牙 的 政 治 天 平 向 左 边 稍 稍 倾 斜 了 。";
			a.data[8] -= 50;
			a.data[9] -= 50;
			return;
		case 2:
			text = " 我 们 联 系 到 <color=#8B4513>基 督 教 民 主 党 / 葡 萄 牙 右 翼 党 / 民 族 阵 线</color> 的 右 翼 三 党 联 盟 和 <color=#8B4513>阿 尔 波 因 · 卡 尔 万 、 斯 皮 诺 拉</color> 等 新 萨 拉 查 主 义 组 织 / 反 共 右 翼 人 士 ， 为 他 们 送 去 了 活 动 资 金 。 他 们 自 以 为 有 了 靠 山 ， 开 始 深 入 与 对 康 乃 馨 革 命 之 后 的 现 状 不 满 的 群 体 和 军 队 内 右 派 联 系 。 一 方 面 ， 他 们 开 始 组 建 秘 密 右 翼 准 军 事 组 织 ； 另 一 方 面 ， 他 们 向 政 府 施 压 ， 要 求 在 革 命 委 员 会 中 任 命 更 多 的 右 派 人 士 。 葡 萄 牙 的 政 治 天 平 向 右 边 稍 稍 倾 斜 了 。";
			a.data[8] -= 50;
			a.data[9] -= 50;
			break;
		}
		if (result_num == 3)
		{
			text = " 有 情 报 表 明 ， 苏 联 给 葡 共 和 以 贡 萨 尔 维 斯 为 首 的 军 队 内 左 翼 代 表 送 去 了 指 示 以 及 更 多 的 活 动 资 金 — — 他 们 开 始 更 积 极 地 参 与 工 会 活 动 ， 并 同 军 队 内 左 派 联 系 ， 同 时 向 政 府 施 压 ， 要 求 在 革 命 委 员 会 中 任 命 更 多 的 左 派 人 士 。 另 一 边 ， 美 国 为 了 抵 制 苏 联 势 力 的 扩 张 ， 开 始 积 极 援 助 <color=#8B4513>基 督 教 民 主 党 / 葡 萄 牙 右 翼 党 / 民 族 阵 线</color> 的 右 翼 三 党 联 盟 和 <color=#8B4513>阿 尔 波 因 · 卡 尔 万 、 斯 皮 诺 拉</color> 等 新 萨 拉 查 主 义 组 织 / 反 共 右 翼 人 士 ， 为 他 们 送 去 了 活 动 资 金 。 他 们 自 以 为 有 了 靠 山 ， 开 始 深 入 与 对 康 乃 馨 革 命 之 后 的 现 状 不 满 的 群 体 和 军 队 内 右 派 联 系 ， 并 组 建 了 秘 密 右 翼 准 军 事 组 织 。 葡 萄 牙 未 来 的 命 运 会 如 何 ？";
		}
	}
}
