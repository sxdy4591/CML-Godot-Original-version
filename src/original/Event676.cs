using EventsForDLC;
using UnityEngine;

public class Event676 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 再 见 ， 老 总";
		text = " 1976 年7 月6 日， 令 人 悲 痛 的 事 情 发 生 了 。 中 国 共 产 党 和 中 华 人 民 共 和 国 的 主 要 领 导 人 之 一 ， 中 国 人 民 解 放 军 创 始 人 之 一 ， 时 任 中 共 中 央 委 员 会 委 员 ， 中 央 政 治 局 委 员 ， 常 委 ， 全 国 人 大 常 委 会 委 员 长 朱 德 同 志 于 当 日 下 午 三 时 一 分 因 病 医 治 无 效 在 北 京 逝 世 ， 享 年 9 0 岁 。 作 为 与 毛 主 席 并 肩 作 战 多 年 ， 甚 至 一 度 有 着 “ 朱 不 离 毛 ， 毛 不 离 朱 ” 的 说 法 的 ， 为 人 民 革 命 与 解 放 事 业 奉 献 出 自 己 一 生 的 革 命 战 友 ， 即 便 他 在 建 国 后 很 长 一 段 时 间 内 隐 居 避 世 ， 名 声 不 显 ， 以 至 于 在 晚 年 甚 至 面 临 着 被 批 斗 的 威 胁 ， 但 这 些 都 无 法 抹 去 其 为 新 中 国 成 立 所 立 下 的 汗 马 功 劳 以 及 党 和 人 民 心 目 中 的 地 位 。 华 国 锋 同 志 ， 作 为 毛 主 席 所 定 的 接 班 人 ， 你 有 权 利 也 有 义 务 去 参 加 这 场 葬 礼 ， 去 和 这 位 老 前 辈 告 别 。 并 且 在 毛 主 席 的 嘱 托 下 ， 务 必 办 好 相 应 事 务 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 永 别 了 ， 朱 总 司 令 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 再 见 ， 老 总";
		if (result_num == 0)
		{
			text = " 七 月 十 一 日 ， 朱 德 同 志 的 追 悼 大 会 在 人 民 大 会 堂 正 式 举 行 。 中 共 中 央 副 主 席 王 洪 文 同 志 主 持 了 此 次 大 会 ， 中 共 中 央 第 一 副 主 席 华 国 锋 同 志 在 大 会 中 致 辞 ， 表 达 了 对 这 位 “ 红 军 之 父 ” “ 人 民 的 骄 傲 ” 的 敬 重 以 及 其 逝 去 所 带 来 的 无 比 悲 痛 。 值 得 一 提 的 是 ， 毛 主 席 在 病 重 之 时 ， 仍 派 人 送 来 了 花 圈 。 而 此 时 北 京 阴 云 密 布 ， 细 雨 连 绵 。 送 灵 时 ， 从 北 京 医 院 出 口 到 八 宝 山 的 马 路 两 侧 ， 挤 满 了 戴 黑 纱 白 花 的 群 众 。 大 家 高 举 横 幅 ， 送 别 这 位 为 人 民 ， 为 国 家 操 劳 一 生 ， 伟 大 的 马 克 思 主 义 者 ， 伟 大 的 无 产 阶 级 革 命 家 ， 政 治 家 ， 军 事 家 。 而 朱 德 的 骨 灰 被 安 放 在 八 宝 山 革 命 公 墓 礼 堂 一 室 ， 骨 灰 盒 编 号 1 0 1 。";
			a.data[22] += 89;
		}
	}
}
