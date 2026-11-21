using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event566 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 和 平 宫 的 红 色 辅 士";
		if (a.allcountries[14].prcpower >= 100)
		{
			text = " 随 着 伊 拉 克 爱 国 同 盟 在 北 部 站 稳 脚 跟 ， 伊 拉 克 爱 国 同 盟 中 央 委 员 会 决 定 发 起 针 对 伊 拉 克 核 心 区 域 的 总 攻 势 ， 以 此 彻 底 解 放 整 个 南 伊 拉 克 。 意 识 到 大 事 不 妙 的 萨 达 姆 政 权 立 刻 开 始 动 员 军 队 ， 并 加 强 了 对 解 放 区 的 扫 荡 和 轰 炸 。 爱 国 同 盟 向 南 部 地 方 投 送 了 大 量 的 《 告 全 伊 拉 克 人 民 书 》 和 《 快 快 加 入 爱 国 卫 队 》 的 宣 言 ， 呼 吁 进 步 青 年 ， 学 生 ， 农 民 ， 工 人 和 军 人 加 入 到 倒 萨 军 队 的 行 列 中 。 出 于 反 共 产 主 义 威 胁 的 务 实 需 要 ， 美 国 坚 定 的 支 持 复 兴 党 政 权 ， 而 苏 联 则 试 图 置 身 事 外 。 无 论 如 何 ， 这 场 战 争 不 是 你 死 就 是 我 亡 。";
		}
		else
		{
			text = " 随 着 伊 拉 克 深 陷 于 两 伊 战 争 的 泥 潭 中 ， 同 时 在 伊 拉 克 库 尔 德 人 聚 集 区 确 保 了 解 放 区 。 伊 拉 克 爱 国 同 盟 中 央 委 员 会 决 定 发 起 针 对 伊 拉 克 核 心 区 域 的 总 攻 势 ， 以 此 彻 底 解 放 整 个 南 伊 拉 克 。 意 识 到 大 事 不 妙 的 萨 达 姆 政 权 立 刻 开 始 动 员 军 队 ， 并 加 强 了 对 解 放 区 的 扫 荡 和 轰 炸 。 爱 国 同 盟 向 南 部 地 方 投 送 了 大 量 的 《 告 全 伊 拉 克 人 民 书 》 和 《 快 快 加 入 爱 国 卫 队 》 的 宣 言 ， 呼 吁 进 步 青 年 ， 学 生 ， 农 民 ， 工 人 和 军 人 加 入 到 倒 萨 运 动 的 行 列 中 。 出 于 反 共 产 主 义 威 胁 的 务 实 需 要 ， 美 国 坚 定 的 支 持 复 兴 党 政 权 ， 而 苏 联 则 试 图 置 身 事 外 。 无 论 如 何 ， 这 场 战 争 不 是 你 死 就 是 我 亡 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 谁 将 获 胜 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 和 平 宫 的 红 色 辅 士";
		if (result_num == 0)
		{
			int num = a.allcountries[14].prcpower / 10;
			text = " 中 东 的 局 势 还 在 持 续 的 恶 化 … …";
			a.ingamewars[42] = new War().Name(" 伊 拉 克 内 战").Attacker(" 复 兴 党").Defender(" 伊 拉 克 爱 国 同 盟")
				.AttackerInfluence(700 - num)
				.DefenderInfluence(300 + num)
				.TickTime(24)
				.AmericanSupportAttacker.CreateWar;
		}
	}
}
