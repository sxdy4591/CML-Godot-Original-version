using EventsForDLC;
using UnityEngine;

public class Event482 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 回 归 正 统";
		text = " <color=red>法 国 共 产 党</color> 在 选 择 转 向 欧 洲 共 产 主 义 理 念 ， 并 逐 渐 远 离 苏 联 与 无 产 阶 级 专 政 原 则 后 ， 其 内 部 便 形 成 了 三 大 派 系 ： 分 别 是 支 持 回 归 马 克 思 列 宁 主 义 和 无 产 阶 级 专 政 原 则 正 轨 的 “ 正 统 派 ” ； 追 随 总 书 记 <color=green>乔 治 · 马 歇</color> 的 法 国 特 色 社 会 主 义 路 线 的 “ 保 守 派 ” ； 以 及 支 持 新 左 派 或 欧 洲 共 产 主 义 的 “ 改 革 派 ” — — 后 两 派 处 于 结 盟 的 状 态 。\n 在 我 们 与 苏 联 的 帮 助 下 ， <color=red>法 国 共 产 党</color> 正 统 派 的 力 量 在 党 内 已 经 不 断 壮 大 。 现 在 我 们 已 经 可 以 和 苏 联 人 一 起 把 <color=green>马 歇</color> 这 个 右 倾 机 会 主 义 分 子 踢 下 去 了 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 我 们 再 留 他 一 会 儿 … …";
		button_text[1] = " 马 歇 可 以 滚 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 回 归 正 统";
		if (result_num == 0)
		{
			text = " 我 们 可 以 稍 后 再 做 ， 先 继 续 让 马 歇 在 位 置 上 待 一 阵 子 … … ";
		}
		if (result_num == 1)
		{
			text = " 正 统 派 领 导 人 在 我 们 和 苏 联 的 支 持 下 召 开 了 一 场 <color=red>法 国 共 产 党</color> 特 别 代 表 大 会 。 会 上 ， 中 央 书 记 处 书 记 <color=red>马 克 西 姆 · 格 雷 梅 茨</color> 同 志 首 先 宣 读 了 由 一 众 支 持 旧 路 线 的 党 内 元 老 与 正 统 派 联 合 署 名 的 《 致 中 央 委 员 会 的 信 》 ， 该 信 措 辞 严 厉 ， 批 评 党 “ 偏 离 了 无 产 阶 级 专 政 的 原 则 ” 、 “ 陷 入 了 修 正 主 义 ” ； 《 人 道 报 》 负 责 人 、 政 治 局 委 员 <color=red>罗 兰 · 勒 罗 伊</color> 也 紧 随 其 后 — — 他 的 批 评 直 指 总 书 记 <color=green>乔 治 · 马 歇</color> — — 他 指 出 ： “ <color=green>马 歇</color> 同 志 的 右 倾 机 会 主 义 和 投 机 主 义 思 想 使 党 中 央 多 次 改 变 路 线 ， 导 致 党 陷 入 了 危 机 和 分 裂 的 境 地 ” ； 而 同 样 是 政 治 局 委 员 的 古 斯 塔 夫 · 安 萨 尔 的 措 辞 更 加 尖 锐 ， 他 直 接 批 评 <color=green>马 歇</color> 背 叛 了 工 人 运 动 和 共 产 主 义 … …\n 在 大 量 党 员 谴 责 保 守 派 与 改 革 派 集 团 的 情 况 下 ， <color=green>乔 治 · 马 歇</color> 不 得 不 辞 去 总 书 记 职 位 。 <color=red>法 共</color> 以 多 数 票 支 持 回 归 无 产 阶 级 专 政 和 马 克 思 列 宁 主 义 原 则 。 党 的 领 导 层 也 进 行 了 改 组 ， <color=red>罗 兰 · 勒 罗 伊</color> 同 志 被 选 举 为 新 的 <color=red>法 共</color> 中 央 总 书 记 ， 大 量 正 统 派 党 员 得 以 进 入 政 治 局 和 书 记 处 ， 同 时 ， 地 方 上 更 认 同 马 列 主 义 和 接 近 工 人 阶 级 的 党 员 也 得 以 进 入 中 央 委 员 会 。 正 统 派 在 <color=red>法 国 共 产 党</color> 取 得 了 完 胜 。\n 这 一 事 件 被 右 翼 看 作 是 对 共 产 主 义 革 命 的 呼 吁 ， 然 而 ， 新 的 <color=red>法 共</color> 领 导 层 表 示 将 继 续 遵 循 此 前 签 署 的 “ 共 同 纲 领 ” ， 并 宣 布 <color=red>罗 兰 · 勒 罗 伊</color> 将 参 加 1 9 8 1 年 的 大 选 。 ";
			a.YugAgree = true;
			a.data[9] -= 100;
			a.data[8] -= 100;
			GlobalScript.inst.old_modify_texts[44] = " 法 国 总 统 - 罗 兰 · 勒 罗 伊";
			GlobalScript.inst.old_modify_desc[44] = " 在 党 内 路 线 比 “ 中 式 社 会 主 义 ” 更 激 进 ， 未 遭 受 苏 联 禁 运 且 与 法 国 建 立 贸 易 关 系 时 ：|<color=lime>|与 苏 联 关 系+0.5;|预 算+0.3;|科 研 点 数+0.3|</color>||<color=#9370DB>苏 联 影 响+0.1.</color>";
			GlobalScript.inst.old_modify_desc[56] = "吉 斯 卡 尔 · 德 斯 坦 的 支 持 度 ： {21}|弗 朗 西 斯 · 密 特 朗 的 支 持 度 ： {22}|罗 兰 · 勒 罗 伊 的 支 持 度 ： {23}|雅 克 · 希 拉 克 的 支 持 度 ： {24}";
		}
	}
}
