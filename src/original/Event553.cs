using EventsForDLC;
using UnityEngine;

public class Event553 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 新 意 属 东 非 ？";
		text = "  随 着 意 大 利 的 再 法 西 斯 化 ， 他 们 将 目 光 投 向 了 日 益 陷 入 困 境 的 巴 雷 政 权 。 巴 雷 政 权 自 欧 加 登 战 争 失 败 以 后 便 转 向 投 靠 美 国 ， 他 在 国 内 愈 加 腐 败 和 专 权 ， 巴 雷 所 属 部 族 与 他 的 家 族 成 为 了 索 马 里 最 有 权 势 的 集 团 。 这 种 统 治 激 起 了 其 他 部 族 的 反 抗 。 如 今 ， 反 抗 运 动 已 大 有 夺 权 之 势 。 在 这 一 背 景 下 ， 意 大 利 政 府 决 定 重 返 索 马 里 ， 他 们 向 巴 雷 伸 出 了 橄 榄 枝 。 尽 管 遭 到 联 合 国 与 美 国 的 抗 议 ， 意 大 利 还 是 与 索 马 里 签 订 了 新 发 展 协 定 ： 作 为 交 换 意 大 利 对 当 地 的 二 度 投 资 ， 包 括 改 建 道 路 、 翻 修 建 筑 、 大 兴 基 建 、 提 供 军 事 援 助 与 帮 助 平 叛 的 筹 码 ； 索 马 里 承 诺 将 为 意 大 利 企 业 开 采 当 地 资 源 和 发 展 畜 牧 业 提 供 税 收 优 惠 ， 并 提 供 4 9 年 的 特 许 经 营 权 。 如 今 ， 大 批 意 大 利 人 的 投 资 和 军 队 正 开 赴 索 马 里 ， 巴 雷 也 在 意 大 利 顾 问 的 帮 助 下 改 造 国 家 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 谴 责 意 大 利 在 东 非 地 区 的 扩 张";
		button_text[1] = " 向 索 马 里 提 供 援 助 ， 以 交 换 关 税 减 免";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 新 意 属 东 非 ？";
		GlobalScript.inst.gameState.allcountries[42].puppetOf = 85;
		GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 9;
		GlobalScript.inst.gameState.allcountries[42].Vyshi = false;
		if (result_num == 0)
		{
			text = " 我 们 强 烈 谴 责 意 大 利 帝 国 主 义 行 径 与 其 对 非 洲 的 新 殖 民 主 义 政 策 ， 称 其 是 “ 新 意 属 东 非 ” 。 然 而 ， 我 们 的 批 判 对 意 大 利 人 来 说 不 痛 不 痒 ， 他 们 仍 继 续 实 行 其 掠 夺 性 政 策 。 据 称 。 摩 加 迪 沙 当 局 已 经 接 收 到 了 第 一 批 意 援 武 器 与 相 关 军 事 顾 问 。";
			a.data[6] -= 10;
			a.empires[1].relations += 25;
			a.empires[0].relations += 25;
		}
		if (result_num == 1)
		{
			text = " 机 会 难 得 ， 我 们 决 定 不 再 袖 手 旁 观 。 我 们 决 定 以 意 大 利 人 的 政 策 为 蓝 本 ， 以 提 供 武 器 与 粮 食 援 助 ， 交 换 索 马 里 当 局 对 我 国 产 品 的 十 年 关 税 减 免 。 索 马 里 毫 不 犹 豫 的 就 接 受 了 我 们 的 提 议 。 与 此 同 时 ， 摩 加 迪 沙 当 局 已 经 接 收 到 了 第 一 批 意 援 武 器 与 相 关 军 事 顾 问 。";
			a.data[8] += 5;
			a.empires[1].relations -= 25;
			a.empires[0].relations -= 25;
			GlobalScript.inst.gameState.allcountries[42].Torg = true;
		}
	}
}
