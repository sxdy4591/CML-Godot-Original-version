using EventsForDLC;
using UnityEngine;

public class Event546 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 塞 上 赤 日 耀 玉 关";
		text = " 新 疆 人 民 有 着 悠 久 的 斗 争 传 统 。 迪 化 起 义 和 伊 犁 辛 亥 革 命 粉 碎 了 清 王 朝 妄 图 西 迁 以 偏 安 一 隅 的 幻 想 ， 而 三 区 革 命 中 的 马 列 主 义 者 们 则 积 极 地 反 抗 盛 世 才 、 国 民 党 政 府 的 腐 朽 统 治 ， 并 且 协 助 我 党 促 成 了 新 疆 的 和 平 解 放 。 这 片 土 地 上 有 的 不 仅 仅 是 黑 金 与 沙 粒 ， 更 是 有 着 前 仆 后 继 的 仁 人 志 士 和 英 雄 儿 女 。 如 今 ， 新 疆 人 民 无 比 热 忱 地 期 盼 在 社 会 主 义 制 度 下 的 新 一 波 经 济 建 设 高 潮 、 新 一 波 的 社 会 革 命 高 潮 ， 还 有 ， 自 身 命 运 彻 底 解 放 的 共 产 主 义 运 动 高 潮 。 主 席 同 志 ， 让 我 们 回 应 人 民 的 呼 声 ， 将 新 疆 无 产 阶 级 文 化 大 革 命 推 到 一 个 新 高 度 、 新 阶 段 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 这 是 属 于 新 疆 各 族 人 民 的 共 同 荣 光 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 塞 上 赤 日 耀 玉 关";
		if (result_num == 0)
		{
			text = " 我 们 整 合 了 维 吾 尔 、 哈 萨 克 等 新 疆 诸 少 数 民 族 以 及 汉 族 的 革 命 委 员 会 和 民 兵 革 命 支 队 ， 形 成 新 的 “ 新 疆 各 民 族 人 民 革 命 委 员 会 ” 。 迁 来 援 助 新 疆 的 汉 族 青 年 干 部 和 建 设 者 们 积 极 推 广 全 面 的 普 通 话 教 育 ， 推 行 无 产 阶 级 的 民 族 观 念 和 宗 教 观 念 。 当 然 ， 我 们 也 保 护 少 数 民 族 的 文 字 语 言 和 优 秀 文 化 ， 为 此 成 立 了 新 疆 民 族 语 言 委 员 会 ， 致 力 于 简 化 以 阿 拉 伯 语 和 新 波 斯 语 为 蓝 本 的 各 少 数 民 族 语 言 ， 推 行 语 言 文 字 的 拼 音 化 和 规 范 化 ， 使 原 先 复 杂 难 懂 的 文 字 得 以 普 及 到 人 民 群 众 ， 从 而 实 现 识 字 率 的 提 高 。 各 级 工 作 人 员 向 那 些 感 到 疑 惑 的 人 们 解 释 推 行 普 通 话 不 是 出 于 一 种 狭 隘 的 民 族 主 义 ， 而 是 为 了 加 强 各 族 人 民 的 联 系 和 相 互 理 解 ， 更 好 地 实 现 各 族 人 民 的 团 结 友 爱 ， 一 齐 建 设 和 保 卫 社 会 主 义 祖 国 。 人 民 革 命 委 员 会 在 全 自 治 区 推 行 无 产 阶 级 革 命 教 育 ， 让 少 数 民 族 群 众 真 正 认 清 宗 教 的 本 质 ， 并 且 鼓 励 他 们 主 动 去 质 疑 宗 教 神 权 ， 开 展 对 宗 教 信 条 的 大 辩 论 ， 针 对 性 地 冲 击 那 些 反 动 神 职 人 员 密 谋 聚 集 的 宗 教 场 所 。";
			a.data[1] += 100;
			a.data[3] += 100;
		}
	}
}
