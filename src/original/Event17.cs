using EventsForDLC;
using UnityEngine;

public class Event17 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 泰 国 动 乱";
		text = " 在 社 会 动 荡 和 左 右 派 频 繁 对 抗 的 背 景 下 ， 九 月 ， 泰 国 王 室 决 定 召 回 极 右 将 军 他 侬 · 吉 滴 卡 宗 ， 这 位 前 总 理 需 要 对 其 在 位 期 间 的 血 腥 镇 压 负 责 ， 他 本 人 在1973 年 被 公 众 演 说 推 翻 。 吉 滴 卡 宗 本 人 并 不 想 参 与 政 治 ， 只 想 做 个 僧 侣 ， 但 关 于 他 的 回 归 和 与 国 王 会 面 的 官 方 公 告 还 是 引 起 了 部 分 人 的 不 满 。 总 理 巴 莫 辞 职 ， 但 被 驳 回 ， 一 波 学 生 和 工 会 示 威 的 浪 潮 席 卷 全 国 ， 其 中 一 起 发 生 在 泰 国 国 立 政 法 大 学 ， 右 翼 武 装 分 子 已 经 突 袭 了 那 里 。 根 据 我 们 的 信 息 ， 军 队 正 准 备 严 酷 镇 压 示 威 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 这 不 关 我 们 的 事";
		if (GlobalScript.inst.gameState.data[9] >= 40 && GlobalScript.inst.gameState.data[22] >= 30 && GlobalScript.inst.gameState.data[41] == 100)
		{
			button_text[1] = " 派 遣 武 装 的 泰 国 共 产 党 部 队 去 帮 助 示 威 者 并 煽 动 起 义";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 力 量 组 织 起 义";
		}
		button_text[2] = " 谴 责 泰 国 的 暴 行";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 泰 国 动 乱";
		GlobalScript.inst.gameState.TaiCoup = true;
		switch (result_num)
		{
		case 0:
			text = " 在10 月6 号 ， 警 察 部 队 和 右 翼 民 兵 最 终 控 制 了 大 学 ， 学 生 们 虽 然 愿 意 投 降 ， 但 是 随 后 政 府 军 还 是 开 始 了 屠 杀 ， 据 被 引 用 最 多 的 报 道 ， 至 少 有100 名 学 生 死 于 屠 杀 之 中 。 同 一 天 晚 上 ， 军 方 迫 使 总 理 普 拉 莫 吉 辞 职 。 在 国 王 的 支 持 下 ， 军 方 组 建 了 军 政 府 ， 结 束 了 维 持 了 三 年 的 民 主 政 治 。 泰 国 又 一 次 进 入 了 专 制 的 时 代 ， 只 有 北 方 的 游 击 队 活 动 区 域 仍 在 泰 国 共 产 党 的 控 制 之 下 。";
			GlobalScript.inst.gameState.allcountries[34].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[34].SubGosstroy = 7;
			GlobalScript.inst.gameState.empires[0].power += 5;
			break;
		case 1:
			text = " 由 于 我 们 的 支 持 和 特 工 组 织 的 努 力 ， 泰 共 和 社 会 党 等 左 派 政 党 以 及 民 主 派 的 各 个 政 党 建 立 了 联 系 ， 并 牵 头 组 织 了 进 步 、 爱 国 和 民 主 力 量 统 一 阵 线 。 与 此 同 时 ， 一 批 中 国 制 式 武 器 流 通 到 了 罢 工 工 人 和 抗 议 学 生 那 里 ， 他 们 在 泰 共 地 下 党 员 的 领 导 下 同 阵 线 内 其 他 势 力 联 合 起 来 ， 击 退 了 政 府 的 镇 压 队 伍 。 全 曼 谷 以 及 泰 国 多 个 城 市 都 爆 发 了 类 似 的 起 义 ， 并 随 之 开 始 了 大 规 模 的 交 火 ， 并 以 军 队 和 警 察 的 失 败 告 终 。 而 普 拉 莫 吉 总 理 被 军 方 以 “ 动 摇 国 体 ， 破 坏 首 都 治 安 ” 而 逮 捕 的 消 息 震 惊 了 全 国 ， 大 量 的 学 生 ， 工 运 人 士 、 工 人 以 及 其 他 左 派 政 党 和 民 主 派 政 党 聚 集 在 泰 国 共 产 党 领 导 的 进 步 、 爱 国 和 民 主 力 量 统 一 阵 线 下 ， 同 保 守 派 势 力 对 战 。 泰 国 共 产 党 领 导 的 泰 国 人 民 解 放 军 在 我 们 和 越 南 的 大 规 模 援 助 下 趁 此 机 会 开 始 向 全 国 展 开 全 面 攻 势 。";
			GlobalScript.inst.gameState.data[9] -= 40;
			GlobalScript.inst.gameState.data[22] -= 30;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.allcountries[34].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[34].SubGosstroy = 7;
			party_change[0] = 1f;
			GlobalScript.inst.gameState.ingamewars[2].name_war = " 泰 国 内 战";
			GlobalScript.inst.gameState.ingamewars[2].is_going = true;
			GlobalScript.inst.gameState.ingamewars[2].side1 = " 共 产 党";
			GlobalScript.inst.gameState.ingamewars[2].side2 = " 保 王 党";
			GlobalScript.inst.gameState.ingamewars[2].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[2].ussr_place = 0;
			GlobalScript.inst.gameState.ingamewars[2].infl1 = 300;
			GlobalScript.inst.gameState.ingamewars[2].infl2 = 700;
			if (GlobalScript.inst.gameState.allcountries[34].stab == 1)
			{
				GlobalScript.inst.gameState.ingamewars[2].infl1 += 50;
				GlobalScript.inst.gameState.ingamewars[2].infl2 -= 50;
			}
			break;
		case 2:
			text = " 在10 月6 号 ， 警 察 部 队 和 右 翼 民 兵 最 终 控 制 了 大 学 ， 学 生 们 虽 然 愿 意 投 降 ， 但 是 随 后 政 府 军 还 是 开 始 了 屠 杀 ， 据 被 引 用 最 多 的 报 道 ， 至 少 有100 名 学 生 死 于 屠 杀 之 中 。 同 一 天 晚 上 ， 军 方 迫 使 总 理 普 拉 莫 吉 辞 职 。 在 国 王 的 支 持 下 ， 军 方 组 建 了 军 政 府 ， 结 束 了 三 年 的 民 主 政 治 。 泰 国 又 一 次 进 入 了 专 制 的 时 代 ， 只 有 北 方 的 游 击 队 活 动 区 域 仍 在 泰 国 共 产 党 的 控 制 之 下 。 我 们 虽 然 愿 意 支 持 他 们 并 谴 责 军 政 府 的 残 暴 ， 但 我 们 都 明 白 这 已 经 毫 无 意 义 了 。";
			GlobalScript.inst.gameState.empires[1].relations += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 20;
			GlobalScript.inst.gameState.empires[0].power += 5;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[34].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[34].SubGosstroy = 7;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
