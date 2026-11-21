using EventsForDLC;
using UnityEngine;

public class Event118 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "“ 和 平 之 国 达 鲁 萨 兰 ” 的 再 回";
		text = "1984 年1 月1 日 ， 苏 丹 宣 布 ， 文 莱 已 成 为 一 个 完 全 独 立 国 家 ， 并 宣 布 新 内 阁 组 成 名 单 。1984 年1 月7 日 ， 文 莱 正 式 加 入 东 南 亚 国 家 联 盟 ，9 月 加 入 联 合 国 ， 成 为 第159 个 会 员 国 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = GlobalScript.inst.new_events_text[1433];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "“ 和 平 之 国 达 鲁 萨 兰 ” 的 再 回";
		text = " 独 立 以 后 ， 苏 丹 政 府 大 力 推 行 “ 马 来 化 、 伊 斯 兰 化 和 君 主 制 ” 政 策 ， 巩 固 王 室 统 治 ， 重 点 扶 持 马 来 族 等 土 著 人 的 经 济 ， 在 进 行 现 代 化 建 设 的 同 时 严 格 维 护 伊 斯 兰 教 义 。  ";
		a.allcountries[111].isASEAN = true;
		a.allcountries[111].Gosstroy = 0;
		a.allcountries[111].SubGosstroy = 13;
		a.empires[0].power += 20;
	}
}
