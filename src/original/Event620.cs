using EventsForDLC;
using UnityEngine;

public class Event620 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 让 我 们 在 幸 福 的 大 陆 上 迈 开 步 伐";
		text = "自1968 年 赤 道 几 内 亚 独 立 以 来 ， 赤 道 几 内 亚 的 大 权 便 一 直 掌 握 在 恩 圭 马 家 族 的 手 中 ， 在 他 们 的 治 下 ， 赤 道 几 内 亚 贫 困 不 堪 ， 人 民 生 活 水 深 火 热 ， 大 量 反 对 派 被 屠 杀 殆 尽 ， 马 西 埃 甚 至 还 称 呼 自 己 的 统 治 为 社 会 主 义 。 现 在 ， 喀 麦 隆 和 加 蓬 这 两 大 邻 国 已 然 革 命 化 ， 两 国 愿 意 为 了 解 放 赤 道 几 内 亚 人 民 而 出 动 军 队 攻 打 赤 道 几 内 亚 ， 是 时 候 让 他 们 见 识 一 下 真 正 的 社 会 主 义 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 推 翻 独 裁 者 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 让 我 们 在 幸 福 的 大 陆 上 迈 开 步 伐";
		if (result_num == 0)
		{
			text = "在 喀 麦 隆 和 加 蓬 的 多 面 攻 击 下 ， 赤 道 几 内 亚 军 队 迅 速 溃 退 ， 最 终 两 国 联 军 占 领 了 整 个 赤 道 几 内 亚 。 多 亏 了 马 西 埃 长 期 的 反 智 教 育 ， 赤 道 几 内 亚 军 队 质 量 堪 忧 ， 整 场 行 动 伤 亡 人 数 不 超 百 人 ， 奥 比 昂 · 恩 圭 马 被 抓 捕 并 被 枪 毙 ， 马 西 埃 的 尸 体 被 挖 出 来 重 新 公 审 再 枪 毙 ， 整 个 恩 圭 马 家 族 统 统 关 进 大 牢 中 ， 马 西 埃 在 其 家 乡 所 建 造 的 别 墅 则 被 充 公 ， 部 分 奢 侈 品 则 被 拍 卖 以 换 取 外 汇 来 购 买 工 业 农 业 设 备 。 新 政 府 由 流 亡 到 刚 果 （ 布 ） 的 左 翼 组 织 几 内 亚 国 家 和 人 民 解 放 阵 线 （FRENAPO ） 组 建 ， 秘 书 长 赫 苏 斯 · 姆 巴 · 奥 沃 诺 担 任 总 统 。 整 个 赤 道 几 内 亚 由 于 恩 圭 马 家 族 的 统 治 而 变 得 落 后 不 堪 ， 为 了 使 得 赤 道 几 内 亚 发 展 起 来 ， 非 盟 开 始 为 赤 道 几 内 亚 提 供 大 量 低 息 贷 款 ， 喀 麦 隆 和 加 蓬 的 部 分 军 队 在 此 驻 扎 混 编 成 为 非 盟 维 和 部 队 并 一 直 持 续 到 赤 道 几 内 亚 社 会 秩 序 稳 定 为 止 。 FRENAPO 开 始 按 照 各 社 会 主 义 国 家 的 宪 法 来 建 立 出 属 于 自 己 的 宪 法 ， 逐 步 进 行 扫 盲 教 育 和 无 神 论 教 育 ， 以 求 去 除 马 西 埃 的 神 化 所 造 成 的 影 响 ， 并 对 被 屠 杀 的 各 少 数 民 族 和 知 识 分 子 进 行 平 反 和 纪 念 ； 将 国 内 的 官 僚 资 本 全 部 充 公 ， 并 学 习 坦 桑 尼 亚 的 乌 贾 马 运 动 ， 逐 步 建 设 农 村 合 作 社 。FRENAPO 还 预 计 在 数 年 之 后 进 行 一 次 关 于 是 否 并 入 喀 麦 隆 的 全 民 公 投 ， 但 是 由 于 赤 道 几 内 亚 的 现 状 ， 并 入 喀 麦 隆 的 可 能 性 将 会 很 大 。";
			a.allcountries[115].Gosstroy = 1;
			a.allcountries[115].SubGosstroy = 1;
			a.allcountries[115].LeaveAlliances();
			a.allcountries[115].Torg = true;
			a.allcountries[115].proprc = true;
			a.empires[0].relations -= 150;
		}
	}
}
