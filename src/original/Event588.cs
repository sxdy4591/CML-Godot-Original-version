using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event588 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 欧 加 登 战 火 重 燃";
		text = " 主 席 同 志 ， 看 来 欧 加 登 的 后 遗 症 并 未 就 此 了 结 。 <color=#006400>阿 卜 杜 拉 希 · 优 素 福</color>上 校 曾 担 任 索 马 里 国 民 军 的 指 挥 官 ， 正 是 他 领 导 了 1 9 7 8 年 那 场 失 败 的 政 变 ， 之 后 他 立 即 逃 往 埃 塞 俄 比 亚 。 在 埃 塞 俄 比 亚 ， 优 素 福 打 造 了 为 一 个 名 为 <color=#006400>拯 救 索 马 里 民 主 阵 线</color>（ <color=#006400>S S D F</color>） 的 武 装 反 对 巴 雷 政 权 的 组 织 。 他 领 导 了 该 组 织 ， 不 久 后 开 始 与 埃 塞 俄 比 亚 军 队 联 手 骚 扰 索 马 里 军 队 。||同 时 ， 索 马 里 也 拒 绝 承 认 其 在 欧 加 登 的 惨 败 ， 宣 传 中 仍 然 强 调 大 索 马 里 理 念 。 近 期 ， 双 方 又 一 次 在 边 境 摩 拳 擦 掌 ， 颇 有 大 打 出 手 的 劲 头 。 而 埃 塞 俄 比 亚 这 次 先 发 制 人 ， 派 出 了 大 量 部 队 越 过 边 境 ， 这 很 有 可 能 变 成 又 一 次 的 欧 加 登 战 争 ， 主 席 同 志 ， 一 边 是 我 们 的 老 朋 友 ， 而 另 一 边 是 苏 联 走 狗 ， 但 他 终 究 会 是 个 麻 烦 的 朋 友 ， 我 们 该 帮 谁 呢 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 支 持 索 马 里 人 的 保 家 卫 国";
		button_text[1] = " 支 持 埃 塞 俄 比 亚 人 复 仇";
		button_text[2] = " 关 我 鸟 事 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 欧 加 登 战 火 重 燃";
		int num = 0;
		if (a.resultOfEvents[587] == 2)
		{
			num = 100;
		}
		if (result_num == 0)
		{
			text = " 大 约 1 0 , 0 0 0 至 1 5 , 0 0 0 名 埃 塞 俄 比 亚 军 队 发 动 了 入 侵 ， 他 们 装 备 了 苏 联 提 供 的 米 格 战 斗 机 和 t - 5 5 坦 克 。 3 0 0 0 名 <color=#006400>S S D F</color>成 员 同 样 装 备 了 坦 克 ， 并 得 到 了 埃 塞 俄 比 亚 炮 兵 和 空 军 的 支 持 。||索 马 里 国 民 军 （ S N A ） 只 能 派 出 2 5 0 0 名 士 兵 参 加 边 境 战 役 。 保 卫 边 境 地 区 的 索 马 里 部 队 指 挥 官 是 优 素 福 · 艾 哈 迈 德 · 萨 尔 汉 将 军 和 他 的 下 属 穆 罕 默 德 · 法 拉 · 艾 迪 德 准 将 ， 他 指 挥 中 央 区 军 事 区 。 西 方 观 察 家 估 计 ， 在 战 役 开 始 时 ， S N A 的 总 兵 力 约 为 5 0 , 0 0 0 人 。 自 1 9 7 8 年 初 欧 加 登 战 争 结 束 时 遭 受 严 重 损 失 后 ， S N A 装 备 严 重 不 足 ， 对 冲 突 准 备 不 足 。 但 好 在 有 我 们 的 志 愿 军 ， S N A 得 以 获 得 歼 - 7 战 斗 机 和 足 够 的 火 炮 与 反 坦 克 火 箭 弹 。||现 在 摆 在 我 们 面 前 的 问 题 是 ， 这 到 底 是 一 场 短 暂 的 边 境 冲 突 ， 还 是 一 次 地 缘 政 治 大 洗 牌 ？";
			a.data[22] -= 100;
			if (a.allcountries[42].prosov)
			{
				a.ingamewars[15] = new War().Name(" 索 马 里 - 埃 塞 边 境 冲 突").Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(500 + num)
					.DefenderInfluence(500 - num)
					.TickTime(16)
					.SovietSupportAttacker.CreateWar;
			}
			else
			{
				a.ingamewars[15] = new War().Name(" 索 马 里 - 埃 塞 边 境 冲 突").Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(500 + num)
					.DefenderInfluence(500 - num)
					.TickTime(16)
					.SovietSupportDefender.CreateWar;
			}
		}
		if (result_num == 1)
		{
			text = " 大 约 1 0 , 0 0 0 至 1 5 , 0 0 0 名 埃 塞 俄 比 亚 军 队 发 动 了 入 侵 ， 他 们 装 备 了 苏 联 提 供 的 米 格 战 斗 机 和 t - 5 5 坦 克 。 3 0 0 0 名 <color=#006400>S S D F</color>成 员 同 样 装 备 了 坦 克 ， 并 得 到 了 埃 塞 俄 比 亚 炮 兵 和 空 军 的 支 持 。 同 时 我 们 也 押 宝 于 埃 塞 俄 比 亚 ， 他 们 获 得 了 我 们 的 志 愿 者 和 武 器 装 备 。||索 马 里 国 民 军 （ S N A ） 只 能 派 出 2 5 0 0 名 士 兵 参 加 边 境 战 役 。 保 卫 边 境 地 区 的 索 马 里 部 队 指 挥 官 是 优 素 福 · 艾 哈 迈 德 · 萨 尔 汉 将 军 和 他 的 下 属 穆 罕 默 德 · 法 拉 · 艾 迪 德 准 将 ， 他 指 挥 中 央 区 军 事 区 。 西 方 观 察 家 估 计 ， 在 战 役 开 始 时 ， S N A 的 总 兵 力 约 为 5 0 , 0 0 0 人 。 自 1 9 7 8 年 初 欧 加 登 战 争 结 束 时 遭 受 严 重 损 失 后 ， S N A 装 备 严 重 不 足 ， 他 们 不 一 定 能 和 埃 塞 俄 比 亚 人 扳 手 腕 。 他 们 呼 吁 白 宫 / 克 里 姆 林 方 面 兑 现 承 诺 。||现 在 摆 在 我 们 的 问 题 是 ， 这 到 底 是 一 场 短 暂 的 边 境 冲 突 ， 还 是 一 次 地 缘 政 治 大 洗 牌 ？";
			a.data[22] -= 100;
			if (a.allcountries[42].prosov)
			{
				a.ingamewars[15] = new War().Name(" 索 马 里 - 埃 塞 边 境 冲 突").Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(300 + num)
					.DefenderInfluence(700 - num)
					.TickTime(16)
					.SovietSupportAttacker.CreateWar;
			}
			else
			{
				a.ingamewars[15] = new War().Name(" 索 马 里 - 埃 塞 边 境 冲 突").Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(300 + num)
					.DefenderInfluence(700 - num)
					.TickTime(16)
					.SovietSupportDefender.CreateWar;
			}
		}
		if (result_num == 2)
		{
			text = " 大 约 1 0 , 0 0 0 至 1 5 , 0 0 0 名 埃 塞 俄 比 亚 军 队 发 动 了 入 侵 ， 他 们 装 备 了 苏 联 提 供 的 米 格 战 斗 机 和 t - 5 5 坦 克 。 3 0 0 0 名 <color=#006400>S S D F</color>成 员 同 样 装 备 了 坦 克 ， 并 得 到 了 埃 塞 俄 比 亚 炮 兵 和 空 军 的 支 持 。||索 马 里 国 民 军 （ S N A ） 只 能 派 出 2 5 0 0 名 士 兵 参 加 边 境 战 役 。 保 卫 边 境 地 区 的 索 马 里 部 队 指 挥 官 是 优 素 福 · 艾 哈 迈 德 · 萨 尔 汉 将 军 和 他 的 下 属 穆 罕 默 德 · 法 拉 · 艾 迪 德 准 将 ， 他 指 挥 中 央 区 军 事 区 。 西 方 观 察 家 估 计 ， 在 战 役 开 始 时 ， S N A 的 总 兵 力 约 为 5 0 , 0 0 0 人 。 自 1 9 7 8 年 初 欧 加 登 战 争 结 束 时 遭 受 严 重 损 失 后 ， S N A 装 备 严 重 不 足 ， 他 们 不 一 定 能 和 埃 塞 俄 比 亚 人 扳 手 腕 。 他 们 呼 吁 白 宫 方 面 兑 现 承 诺 。||现 在 摆 在 我 们 的 问 题 是 ， 这 到 底 是 一 场 短 暂 的 边 境 冲 突 ， 还 是 一 次 地 缘 政 治 大 洗 牌 ？";
			a.data[22] -= 50;
			if (a.allcountries[42].prosov)
			{
				a.ingamewars[15] = new War().Name(" 索 马 里 - 埃 塞 边 境 冲 突").Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(400 + num)
					.DefenderInfluence(600 - num)
					.TickTime(4)
					.SovietSupportAttacker.CreateWar;
			}
			else
			{
				a.ingamewars[15] = new War().Name(" 索 马 里 - 埃 塞 边 境 冲 突").Attacker(GlobalScript.inst.new_events_text[794]).Defender(GlobalScript.inst.new_events_text[795])
					.AttackerInfluence(400 + num)
					.DefenderInfluence(600 - num)
					.TickTime(4)
					.SovietSupportDefender.CreateWar;
			}
		}
	}
}
