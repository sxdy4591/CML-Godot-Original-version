using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event640 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 打 倒 社 帝 马 前 卒 ！ ";
		text = "随 着 苏 联 的 日 益 式 微 ， 是 时 候 处 理 苏 联 在 东 亚 地 区 安 插 给 我 们 的 一 棵 楔 子 了 。 蒙 古 ， 这 个 无 耻 又 邪 恶 的 伪 政 权 ， 他 的 诞 生 就 是 建 立 在 乘 乱 谋 独 上 ， 在 我 们 国 内 革 命 陷 入 危 机 的 时 候 ， 蒙 古 打 起 了 内 蒙 古 的 算 盘 ， 积 极 扶 持 内 蒙 古 人 民 革 命 党 等 “ 极 左 ” 分 离 主 义 组 织 。 在 八 月 风 暴 时 妄 图 借 着 苏 军 夺 走 内 蒙 。 在 解 放 战 争 中 ， 他 们 为 破 坏 三 区 革 命 的 乌 斯 满 匪 帮 大 开 绿 灯 ， 更 别 提 在 中 苏 论 战 中 毫 不 动 摇 的 支 持 苏 联 。 这 个 无 耻 之 国 应 该 付 出 代 价 。 随 着 苏 联 在 东 欧 的 “ 惨 胜 ” ， 我 们 应 当 更 进 一 步 ， 打 碎 邪 恶 帝 国 在 远 东 的 重 要 支 点 。 而 苏 联 新 政 府 的 改 革 更 是 创 造 了 这 一 机 会 ， 蒙 古 的 物 价 遇 到 了 前 所 未 有 的 飙 升 ， 商 品 极 度 短 缺 ， 俄 罗 斯 驻 军 的 暴 行 也 早 已 让 该 国 公 民 厌 倦 。 大 量 的 牧 民 以 探 亲 戚 和 “ 归 乡 ” 为 由 从 蒙 古 一 侧 逃 到 我 方 来 寻 求 庇 护 。 这 更 说 明 了 我 们 的 正 确 性 。 是 时 候 让 他 们 为 过 去 的 错 误 付 出 代 价 了 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 ， 是 时 候 了 ， 该 让 我 们 一 举 粉 碎 邪 恶 帝 国 所 孕 育 的 弗 兰 肯 斯 坦 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = "执 行 “ 戈 壁 风 暴 ” 计 划 吧 ， 我 期 待 很 久 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "打 倒 社 帝 马 前 卒 ！";
		if (result_num == 0)
		{
			text = "中 央 军 委 一 声 令 下 ， 中 国 人 民 解 放 军 发 动 了 对 蒙 古 的 袭 击 。 当 被 问 到 为 何 发 动 军 事 行 动 时 ， 国 防 部 发 言 人 如 是 说 到 ： “ 在 伪 政 府 统 治 下 的 蒙 古 同 胞 们 早 就 渴 望 回 到 中 华 民 族 的 大 家 庭 里 了 ， 而 我 们 的 领 袖" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 也 做 好 了 接 纳 他 们 的 准 备 。 中 国 人 民 解 放 军 将 从 苏 联 社 会 帝 国 主 义 手 中 ， 解 放 受 尽 磨 难 的 蒙 古 人 民 。 这 是 中 华 民 族 一 雪 前 耻 的 重 要 时 刻 ， 这 是 让 蒙 古 人 民 摆 脱 苏 修 枷 锁 的 反 帝 战 争 ！ ”||孱 弱 的 蒙 古 人 民 军 面 对 如 潮 水 般 的 中 国 人 民 解 放 军 似 乎 并 不 占 优 ， 或 者 说 ， 他 们 能 抵 抗 都 已 经 是 个 奇 迹 了 。 唯 一 的 希 望 在 于 苏 军 和 古 巴 教 官 ， 因 为 前 线 的 蒙 古 士 兵 开 始 成 建 制 的 向 解 放 军 投 降 ， 乌 兰 巴 托 已 经 近 在 咫 尺 了 。||苏 联 外 长 强 烈 谴 责 了 我 国 针 对 蒙 古 的 军 事 行 动 ， 他 说 ： “ 苏 联 将 会 以 一 切 代 建 保 卫 社 会 主 义 蒙 古 ， 免 遭 中 国 帝 国 主 义 的 侵 略 ， 捍 卫 蒙 古 人 民 来 之 不 易 的 独 立 ， 不 论 代 价 如 何 ！ ”";
			a.ingamewars[69] = new War().Name("中 蒙 战 争 ").Attacker("中 华 人 民 共 和 国").Defender("蒙 古 人 民 共 和 国")
				.AttackerInfluence(650)
				.DefenderInfluence(350)
				.TickTime(15)
				.SovietSupportDefender.CreateWar;
			if (a.allcountries[51].Torg)
			{
				a.ingamewars[69].usa_place = 0;
			}
			a.allcountries[9].Torg = false;
			a.allcountries[9].prosov = true;
			a.allcountries[7].Torg = false;
			a.relres = false;
			a.empires[1].relations -= 1000;
			a.empires[1].power -= 50;
			a.data[1] += 300;
			a.data[22] -= 800;
			a.data[8] -= 200;
		}
	}
}
