using EventsForDLC;
using UnityEngine;

public class Event49 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 反 对 所 有 暴 君";
		text = " 在 最 近 的 阿 明 政 变 之 后 ， 苏 联 以 各 种 可 能 的 方 式 寻 找 清 除 目 中 无 人 的 篡 权 者 的 方 法 。 根 据 我 们 的 数 据 ， 苏 联 领 导 人 已 经 与 卡 尔 迈 勒 、 萨 瓦 里 和 瓦 坦 贾 等 不 同 派 系 的 人 民 民 主 党 成 员 建 立 了 联 系 ， 他 们 因 阿 明 的 清 洗 而 逃 离 阿 富 汗 ， 并 准 备 用 他 们 来 取 代 阿 明 。 这 项 计 划 的 关 键 是 以 苏 联 特 勤 部 队 中 和 阿 明 及 其 忠 实 的 随 从 ， 苏 联 特 勤 部 队 的 掩 护 应 该 由 苏 联 军 队 提 供 ， 自 今 年 年 初 以 来 ， 尽 管 苏 联 不 断 遭 到 拒 绝 ， 但 人 民 民 主 党 和 阿 明 本 人 一 直 被 要 求 得 到 进 入 许 可 。 然 而 ， 在 这 种 情 况 的 压 力 下 ， 苏 维 埃 领 导 人 似 乎 决 定 改 变 决 定 ， 最 早12 月25 日 ， 第 一 批 苏 维 埃 部 队 越 境 ， 任 务 是 保 护 苏 阿 合 作 的 重 要 军 事 设 施 和 对 象 。 现 在 是 我 们 夺 取 在 阿 富 汗 的 主 动 权 的 机 会 ， 如 果 有 可 能 防 止 阿 明 的 免 职 的 话 。 然 而 ， 这 只 能 在 与 苏 联 保 持 良 好 关 系 的 情 况 下 才 能 实 现 ， 否 则 苏 联 将 冲 破 一 堵 砖 墙 ， 但 不 会 给 我 们 阿 富 汗 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 这 是 苏 联 的 事 务";
		if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[9] >= 70)
		{
			button_text[1] = " 警 告 阿 明 和 向 他 发 送 帮 助";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 有 人 会 让 我 们 介 入";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 反 对 所 有 暴 君";
		GlobalScript.inst.gameState.allcountries[12].Vyshi = false;
		switch (result_num)
		{
		case 0:
			if (GlobalScript.inst.gameState.data[49] > 150)
			{
				text = "12 月27 日 晚 ， 克 格 勃 特 种 部 队 的 苏 联 部 队 和 军 队 封 锁 了 喀 布 尔 驻 军 的 部 分 地 区 ， 并 占 领 了 总 参 谋 部 大 楼 ， 冲 进 了 阿 明 的 住 所 ， 在 那 里 他 被 杀 害 了 （ 尽 管 命 令 里 要 求 他 活 着 ） 。 在 苏 联 的 支 持 下 ， 阿 富 汗 由 阿 萨 杜 拉 · 萨 瓦 里 领 导 ， 他 是 人 民 派 的 一 名 成 员 ， 也 是 阿 富 汗 特 勤 部 队 的 前 负 责 人 ， 被 阿 明 所 镇 压 。 总 的 来 说 ， 尽 管 军 队 中 仍 有 个 别 忠 于 阿 明 的 部 分 抵 抗 ， 但 他 的 免 职 毫 无 问 题 。 与 此 同 时 ， 苏 联 军 队 的 进 入 和 部 署 仍 在 继 续 。";
				GlobalScript.inst.gameState.empires[1].power += 10;
				GlobalScript.inst.gameState.data[48] = 150;
				GlobalScript.inst.gameState.data[107] = 9;
				GlobalScript.inst.gameState.influencePRC += 20;
				GlobalScript.inst.gameState.data[49] = 100;
				GlobalScript.inst.gameState.allcountries[12].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[12].SubGosstroy = 1;
			}
			else
			{
				text = "12 月27 日 晚 ， 克 格 勃 特 种 部 队 的 苏 联 部 队 和 军 队 封 锁 了 喀 布 尔 驻 军 的 部 分 地 区 ， 并 占 领 了 总 参 谋 部 大 楼 ， 冲 进 了 阿 明 的 住 所 ， 在 那 里 他 被 杀 害 了 （ 尽 管 命 令 里 要 求 他 活 着 ） 。 在 苏 联 的 支 持 下 ， 阿 富 汗 由 巴 布 拉 克 · 卡 尔 迈 勒 领 导 ， 巴 布 拉 克 · 卡 尔 迈 勒 是 旗 帜 派 的 创 始 人 和 常 任 领 导 人 ， 也 是 阿 明 的 长 期 对 手 。 总 的 来 说 ， 尽 管 军 队 中 仍 有 个 别 忠 于 阿 明 的 部 分 抵 抗 ， 但 他 的 免 职 毫 无 问 题 。 与 此 同 时 ， 苏 联 军 队 的 进 入 和 部 署 仍 在 继 续 。";
				GlobalScript.inst.gameState.empires[1].power += 10;
				GlobalScript.inst.gameState.data[48] = 100;
				GlobalScript.inst.gameState.influencePRC += 20;
				GlobalScript.inst.gameState.data[49] = 150;
				GlobalScript.inst.gameState.allcountries[12].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[12].SubGosstroy = 1;
			}
			break;
		case 1:
			text = " 多 亏 了 我 们 及 时 的 警 告 ， 阿 明 设 法 使 他 的 忠 诚 派 系 进 入 战 备 状 态 ， 而 他 离 开 了 住 所 ， 在 喀 布 尔 郊 区 避 难 。 苏 联 甚 至 在 行 动 开 始 时 ， 就 已 经 意 识 到 他 的 计 划 失 败 了 ， 并 召 回 了 特 种 部 队 。 只 是 在 我 们 和 阿 富 汗 外 交 官 以 及 阿 明 的 努 力 下 ， 才 避 免 了 一 个 重 大 的 国 际 丑 闻 。 阿 明 努 力 装 作 什 么 都 没 有 发 生 ， 名 义 上 也 没 有 改 变 政 策 。 当 然 ， 尽 管 苏 联 仍 然 不 高 兴 ， 并 开 始 迅 速 减 少 对 阿 富 汗 的 援 助 。 苏 联 军 队 的 进 入 速 度 也 减 慢 了 ， 他 们 的 任 务 也 是 如 此 。 看 来 ， 随 着 时 间 的 推 移 ， 他 们 和 苏 联 的 专 家 们 都 会 完 全 撤 离 ， 所 以 在 内 战 开 始 时 ， 我 们 必 须 为 阿 富 汗 提 供 一 切 帮 助 。 与 此 同 时 ， 阿 明 与 中 华 人 民 共 和 国 缔 结 了 一 些 条 约 ， 并 邀 请 直 到 最 近 还 在 反 对 派 内 的 毛 派 分 子 ， 他 们 将 以 优 惠 条 件 加 入 阿 富 汗 人 民 民 主 党 ， 并 将 被 增 选 为 政 府 成 员 。";
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.data[9] -= 70;
			GlobalScript.inst.gameState.data[46] = 100;
			GlobalScript.inst.gameState.data[49] = 180;
			GlobalScript.inst.gameState.data[6] += 50;
			GlobalScript.inst.gameState.empires[1].relations -= 400;
			GlobalScript.inst.gameState.allcountries[12].prosov = false;
			GlobalScript.inst.gameState.allcountries[12].proprc = true;
			GlobalScript.inst.gameState.ingamewars[5].name_war = " 阿 富 汗 内 战";
			GlobalScript.inst.gameState.ingamewars[5].is_going = true;
			GlobalScript.inst.gameState.ingamewars[5].side1 = " 阿 富 汗 民 主 共 和 国";
			GlobalScript.inst.gameState.ingamewars[5].side2 = " 圣 战 者";
			GlobalScript.inst.gameState.ingamewars[5].ussr_place = -1;
			GlobalScript.inst.gameState.ingamewars[5].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[5].infl1 = 500;
			GlobalScript.inst.gameState.ingamewars[5].infl2 = 500;
			if (GlobalScript.inst.gameState.allcountries[31].Vyshi)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 100;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 100;
			}
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 -= 50;
				GlobalScript.inst.gameState.ingamewars[5].infl2 += 50;
			}
			if (GlobalScript.inst.gameState.data[107] == 9)
			{
				GlobalScript.inst.gameState.ingamewars[5].infl1 += 25;
				GlobalScript.inst.gameState.ingamewars[5].infl2 -= 25;
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
