using EventsForDLC;
using UnityEngine;

public class Event441 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 吕 宋 群 岛 的 赤 色 黎 明 ！";
		text = "  在 我 们 的 帮 助 下 ， 菲 律 宾 共 产 党 成 功 夺 取 了 全 菲 律 宾 政 权 ： 菲 共 的 5 9 式 坦 克 开 进 马 拉 卡 南 宫 （ 总 统 府 ） ， 活 捉 了 试 图 逃 离 的 马 科 斯 之 后 ， 伪 菲 律 宾 政 府 宣 告 投 降 。 菲 共 和 其 他 左 翼 政 党 组 成 的 菲 律 宾 全 国 民 主 阵 线 建 立 了 菲 律 宾 人 民 民 主 共 和 国 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 庆 祝 菲 律 宾 同 志 们 的 胜 利 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 吕 宋 群 岛 的 赤 色 黎 明 ！";
		if (result_num == 0)
		{
			text = " 在 统 一 全 国 之 后 ， 菲 共 立 即 开 始 了 与 中 国 的 全 方 位 合 作 ， 并 和 东 南 亚 的 其 他 兄 弟 国 家 一 起 对 印 尼 进 行 封 锁 和 渗 透 。 工 业 设 备 ， 机 械 农 具 ， 化 肥 正 逐 渐 运 往 菲 律 宾 。 菲 共 正 在 进 行 轰 轰 烈 烈 的 土 改 ， 扫 盲 运 动 ， 工 业 化 ， 并 对 各 少 数 民 族 地 区 实 行 民 族 区 域 自 治 。 菲 共 的 胜 利 使 得 美 国 的 亚 太 战 略 进 一 步 遭 受 挫 折 。 澳 大 利 亚 和 新 西 兰 等 澳 洲 国 家 则 认 为 澳 洲 地 区 现 在 更 容 易 受 到 来 自 东 南 亚 以 及 中 国 的 威 胁 ， 要 求 美 国 进 一 步 增 加 驻 军 和 澳 洲 军 费 开 支 ， 东 南 亚 的 局 势 似 乎 变 的 更 加 紧 张 ， 但 我 们 没 什 么 好 怕 的 ！";
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.empires[0].power -= 100;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.allcountries[47].prcpower = 1000;
		}
	}
}
