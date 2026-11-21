using EventsForDLC;
using UnityEngine;

public class Event622 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "赤 道 几 内 亚 唯 一 天 才";
		text = "自1968 年 马 西 埃 · 恩 圭 马 成 为 新 独 立 的 赤 道 几 内 亚 总 统 之 后 ， 便 受 朝 鲜 影 响 ， 将 赤 道 几 内 亚 民 众 理 念 改 组 为 全 国 统 一 劳 动 党 ， 并 宣 称 赤 道 几 内 亚 正 在 进 行 社 会 主 义 建 设 。 同 样 作 为 社 会 主 义 国 家 的 我 们 自 然 应 当 为 赤 道 几 内 亚 的 同 志 进 行 正 确 的 指 导 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 是 时 候 帮 助 赤 道 几 内 亚 的 同 志 了 ！";
		button_text[1] = " 你 疯 了 吗 ？ 你 明 明 知 道 马 西 埃 根 本 就 是 个 精 神 病";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "赤 道 几 内 亚 唯 一 天 才";
		if (result_num == 0)
		{
			text = "近 日 ， 在 我 们 和 朝 鲜 的 邀 请 下 ， 马 西 埃 · 恩 圭 马 同 志 开 始 对 中 国 和 朝 鲜 进 行 为 期 两 周 的 国 事 访 问 。 在 访 问 路 上 ， 马 西 埃 总 统 参 观 了 中 国 和 朝 鲜 境 内 的 革 命 军 事 博 物 馆 ， 山 西 交 城 县 ， 韶 山 毛 主 席 故 居 ， 长 白 山 （ 白 头 山 ） 峰 顶 ， 主 体 思 想 塔 等 诸 多 带 有 “ 红 色 基 因 ” 特 色 的 地 点 和 建 筑 。 他 拜 访 了 毛 泽 东 主 席 的 纪 念 馆 和 纪 念 碑 ， 亲 自 送 上 了 插 有 嘉 兰 的 花 环 ， 他 还 参 观 了 1 9 6 9 年 珍 宝 岛 战 争 纪 念 碑 。 在 归 国 前 ， 马 西 埃 高 度 赞 扬 了 华 国 锋 同 志 和 金 日 成 同 志 的 社 会 主 义 建 设 和 个 人 崇 拜 。||回 国 后 ， 马 西 埃 开 始 加 大 了 对 自 己 和 家 族 的 个 人 崇 拜 ， 自 己 则 成 为 “ 赤 道 几 内 亚 唯 一 天 才 ” “ 芳 族 人 民 永 远 的 领 袖 ” “ 当 代 杰 出 的 共 产 主 义 者 ” “ 木 尼 河 所 培 育 的 最 纯 洁 ， 最 革 命 ， 最 自 然 的 领 袖 ” ， 他 的 三 名 子 女 则 分 别 成 为 交 通 部 部 长 ， 体 育 部 部 长 和 教 育 部 部 长 ， 关 于 马 西 埃 曾 经 为 西 班 牙 人 做 事 的 经 历 则 被 抹 去 ， 取 而 代 之 的 则 是 马 西 埃 曾 一 直 带 领 着 芳 族 人 民 反 抗 西 班 牙 殖 民 统 治 并 最 终 获 胜 的 神 化 故 事 。 马 西 埃 发 动 了 反 对 官 僚 ， 小 资 产 阶 级 和 反 动 派 的 民 族 纯 净 运 动 ， 让 芳 族 群 众 大 量 屠 杀 知 识 分 子 ， 官 僚 和 所 谓 “ 反 动 派 ” ， 全 员 开 始 学 习 并 背 诵 马 西 埃 的 语 句 （ 尽 管 这 些 语 句 很 多 都 只 是 马 西 埃 随 口 说 的 ， 而 且 有 很 多 句 子 与 马 西 埃 原 话 相 差 甚 远 ） ， 并 开 始 将 芳 族 视 为 最 革 命 的 民 族 ， 誓 要 将 中 非 地 区 的 芳 族 聚 集 区 给 “ 收 复 ” 回 来 。||全 球 都 对 这 个 神 奇 的 奇 幻 小 国 所 发 生 的 事 感 到 震 惊 ， 强 烈 谴 责 了 马 西 埃 并 开 始 发 动 提 议 要 禁 运 赤 道 几 内 亚 ， 但 是 这 恰 恰 表 明 反 革 命 集 团 开 始 气 急 败 坏 了 ， 就 让 他 们 去 反 对 吧 。";
			a.allcountries[115].Gosstroy = 0;
			a.allcountries[115].SubGosstroy = 19;
			a.allcountries[115].LeaveAlliances();
			a.allcountries[115].Torg = true;
			a.allcountries[115].proprc = true;
			a.influencePRC += 10;
		}
		if (result_num == 1)
		{
			text = "这 真 的 不 是 什 么 好 的 提 议 ， 如 果 您 没 有 休 息 好 的 话 ， 您 可 以 先 暂 时 停 止 处 理 公 务 而 不 是 考 虑 这 些 容 易 败 坏 我 国 名 誉 的 决 定 。";
			a.event_done[622] = false;
		}
	}
}
