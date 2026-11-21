using EventsForDLC;
using UnityEngine;

public class Event606 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " La\u00a0Patrie\u00a0ou\u00a0la\u00a0Mort";
		text = " 尼 日 尔 ， 一 个 命 运 多 舛 的 西 非 国 家 。 在 独 立 后 的 前14 年 里 ， 由 哈 马 尼 · 迪 奥 里 总 统 领 导 的 一 党 文 人 政 权 统 治 。 在 他 的 统 治 下 ， 尼 日 尔 初 步 建 立 成 了 一 个 国 家 而 非 大 部 落 ， 经 济 发 展 和 工 业 化 进 程 有 所 放 缓 。 借 助 铀 矿 和 在 阿 尔 及 利 亚 独 立 战 争 中 支 持 法 国 ， 该 国 得 到 了 法 兰 西 的 善 意 。 除 了 和 达 荷 美 （ 也 就 是 贝 宁 ） 的 边 界 争 端 外 ， 该 国 其 他 非 洲 国 家 的 关 系 大 多 “ 积 极 ”   。 在 此 期 间 ， 尼 日 尔 一 直 是 一 党 制 国 家 ， 迪 奥 里 躲 过 了1963 年 的 预 谋 政 变 和1965 年 的 暗 杀 企 图 ， 但 一 手 造 成 的 腐 败 ， 专 制 主 义 ， 饥 荒 和 暴 动 葬 送 了 他 的 王 朝 。 最 终 以 赛 义 尼 • 孔 切 上 校 和 他 的 最 高 军 事 委 员 会 接 过 了 烂 摊 子 随 着 铀 价 暴 跌 ， 经 济 繁 荣 结 束 ， 国 际 货 币 基 金 组 织 牵 头 的 紧 缩 政 策 和 私 有 化 措 施 引 起 一 些 尼 日 尔 人 的 反 对 。||现 在 ， 随 着 孔 切 的 战 友 一 个 接 着 一 个 都 被 送 去 见 了 戴 高 乐 。 马 里 ， 布 基 纳 法 索 和 贝 宁 正 在 准 备 中 一 场 彻 底 推 翻 孔 切 政 权 的 行 动 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " E u x\u00a0v a i n c r o n s ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " La\u00a0Patrie\u00a0ou\u00a0la\u00a0Mort";
		if (result_num == 0)
		{
			text = " 三 国 组 建 了 一 支 统 一 调 度 的 武 装 部 队 ， 代 号 “ 尼 日 尔 河 ” 的 行 动 一 触 即 发 。 在 得 到 尼 亚 美 的 信 息 之 后 ， 三 军 从 北 ， 西 和 南 方 攻 入 了 该 国 。 布 基 纳 法 索 人 民 军 迅 速 开 入 了 尼 亚 美 ， 在 尼 日 尔 国 内 的 萨 瓦 巴 的 帮 助 下 顺 利 攻 占 了 首 都 总 统 府 和 广 播 电 台 ， 号 召 全 体 人 民 起 义 ， 夺 权 ， 彻 底 革 命 。 而 " + ((a.allcountries[21].Gosstroy == 3) ? "法 国 和" : null) + "美 国 拒 绝 武 装 介 入 这 一 问 题 。 仅 仅 是 谴 责 了 三 国 的 暴 力 行 为 ， 提 供 了 除 干 涉 外 的 一 切 帮 助 。||随 后 ， 孔 切 被 宣 判 有 蓄 意 谋 杀 罪 ， 叛 国 罪 ， 种 族 灭 绝 罪 而 被 判 处 死 刑 。 非 洲 社 会 主 义 运 动 - 萨 瓦 巴 党 正 式 成 为 了 该 国 的 领 导 力 量 。 不 久 以 后 该 党 便 出 台 了 执 政 纲 领 “ 尼 日 尔 的 共 产 主 义 道 路 ” 。 宣 布 要 以 马 克 思 列 宁 主 义 的 理 论 为 指 导 ， 毛 泽 东 思 想 为 武 器 ， 建 立 巩 固 和 保 卫 社 会 主 义 新 尼 日 尔 。 " + ((a.allcountries[21].Gosstroy == 3) ? "法 国 大 使 被 列 为 最 不 受 欢 迎 的 人 和 特 务 从 而 驱 逐 出 境 ， 法 国 掌 握 的 铀 矿 也 被 完 全 国 有 化 ， 是 尼 日 尔 人 的 国 有 化 。" : null);
			a.allcountries[56].Gosstroy = 1;
			a.allcountries[56].SubGosstroy = 17;
			a.allcountries[56].LeaveAlliances();
			a.allcountries[56].proprc = true;
			a.allcountries[56].Torg = true;
			if (a.allcountries[21].Gosstroy == 3)
			{
				a.allcountries[21].Torg = false;
			}
			a.data[6] += 30;
			a.data[22] -= 100;
			a.influencePRC += 30;
			a.empires[0].relations -= 150;
			a.empires[0].power -= 30;
		}
	}
}
