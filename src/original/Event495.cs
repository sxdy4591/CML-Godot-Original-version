using EventsForDLC;
using UnityEngine;

public class Event495 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 阿 里 郎 ， 阿 里 郎";
		text = " 在 韩 国 阳 光 政 策 的 推 出 和 朝 鲜 的 改 革 之 后 ， 半 岛 问 题 和 平 解 决 的 曙 光 已 经 出 现 。 主 席 同 志 ， 我 们 是 否 应 该 帮 他 们 一 把 来 解 决 半 岛 问 题 ， 或 者 就 这 样 维 持 不 变 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[1] = " 平 等 地 位 谈 判";
		button_text[0] = " 下 次 再 说";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 阿 里 郎 ， 阿 里 郎";
		if (result_num == 0)
		{
			text = " 但 是 我 答 应 ， 下 次 政 治 局 会 议 的 时 候 一 定 会 提 到 这 件 事 的 … 下 次 一 定 ！";
		}
		if (result_num == 1)
		{
			text = " 朝 鲜 领 导 人 ";
			if (a.allcountries[10].SubGosstroy == 8)
			{
				text += "金 日 成 ";
			}
			else
			{
				text += "金 永 春 ";
			}
			text += "与 韩 国 领 导 人 ";
			if (a.allcountries[46].Gosstroy == 3)
			{
				text += "金 大 中 ";
			}
			else
			{
				text += "安 必 洙 ";
			}
			text += "在 平 壤 进 行 和 平 统 一 谈 判 ， 在 我 们 与 朝 韩 两 方 的 共 同 努 力 下 ， 朝 韩 两 个 政 权 将 统 一 为 高 丽 民 主 联 邦 共 和 国 ， 朝 韩 双 方 将 保 留 自 治 ， 但 是 均 开 放 党 禁 ， 并 宣 布 十 年 之 后 将 会 进 行 半 岛 光 复 以 来 第 一 次 南 北 总 选 举 ； 双 方 人 员 自 由 通 行 ， 并 着 手 准 备 裁 军 ， 驻 扎 在 半 岛 的 外 国 军 队 及 代 表 也 陆 续 撤 出 ， 经 济 上 则 允 许 私 人 资 本 进 入 北 方 进 行 投 资 ， 对 外 则 改 善 中 美 苏 日 等 周 边 大 国 的 关 系 ， 并 成 功 申 请 汉 城 奥 运 会 了 。 阿 里 郎 的 歌 声 最 终 跨 越 了 停 火 线 。";
			a.allcountries[10].parts[0] = true;
			a.allcountries[10].Gosstroy = 2;
			a.allcountries[10].SubGosstroy = 3;
			a.allcountries[10].name = " 高 丽 民 主 联 邦 共 和 国";
			a.allcountries[10].LeaveAlliances();
			a.allcountries[10].Torg = true;
		}
	}
}
