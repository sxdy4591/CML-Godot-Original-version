using EventsForDLC;
using UnityEngine;

public class Event47 : EventsSecond
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
		name = " 北 京 之 春";
		text = " 从 今 年 年 中 开 始 ， 全 国 各 地 的 学 生 和 知 识 分 子 开 始 了 激 烈 的 活 动 ， 尤 其 是 在 北 京 ， 大 街 上 挂 着 大 字 报 （ 带 有 用 于 宣 传 和 抗 议 的 大 象 形 文 字 的 壁 报 ） ， 出 版 自 制 的 杂 志 。 大 字 报 和 报 刊 反 对 中 国 共 产 党 的 保 守 主 义 ， 批 评 文 化 大 革 命 ， 呼 吁 经 济 和 政 治 的 自 由 化 ， 对 中 国 共 产 党 内 积 极 的 改 革 派 表 示 支 持 。 此 外 ，1977 年 ， 改 革 派 们 在 他 们 控 制 下 的 期 刊 和 报 纸 上 发 表 了 激 烈 的 对 我 们 政 策 的 批 评 ， 他 们 说 我 们 的 政 策 “ 不 符 合 马 克 思 主 义 ” ， 又 主 张 “ 经 济 发 展 应 该 压 倒 意 识 形 态 工 作 ” ， “ 实 践 是 检 验 真 理 的 唯 一 标 准 ” ， 并 在 他 们 的 愿 景 中 描 述 了 市 场 改 革 的 远 大 前 景 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 让 国 安 部 和 中 共 人 力 资 源 部 长 解 决 这 些 问 题 。";
		button_text[1] = " 加 入 与 改 革 派 的 争 论 并 否 定 他 们";
		button_text[2] = " 我 们 的 媒 体 会 处 理 这 种 低 廉 的 宣 传";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 北 京 之 春";
		switch (result_num)
		{
		case 0:
		{
			text = " 在 旧 的 方 式 下 ， 国 安 和 警 察 开 始 撕 开 大 字 报 ， 寻 找 地 下 出 版 物 ， 中 国 共 产 党 再 次 通 过 了 一 场 对 改 革 派 的 清 洗 浪 潮 （ 然 而 ， 由 于 改 革 派 在 许 多 中 国 共 产 党 组 织 中 的 统 治 地 位 ， 这 场 清 洗 并 没 有 那 么 顺 利 ） 。 人 民 和 改 革 派 都 不 高 兴 ， 但 抗 议 浪 潮 已 经 停 止 。 希 望 现 在 不 满 的 人 不 会 采 取 更 激 进 的 行 动";
			GlobalScript.inst.gameState.data[1] -= 80;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[3] -= 80;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.party_ideology[3] -= (int)((float)GlobalScript.inst.gameState.party_ideology[3] * 0.05f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 2)
				{
					politic2.power -= 100;
					politic2.loyality -= 100;
				}
			}
			break;
		}
		case 1:
		{
			text = " 我 们 控 制 的 媒 体 积 极 发 表 了 我 们 的 文 章 ， 驳 斥 了 改 革 派 的 论 文 ， 在 党 的 会 议 室 里 ， 左 翼 和 右 翼 之 间 的 争 论 再 次 爆 发 。 当 然 ， 改 革 派 也 用 新 的 文 章 和 杂 志 来 回 应 。 人 民 对 你 们 的 争 论 很 感 兴 趣 ， 尽 管 由 于 改 革 派 的 民 粹 主 义 ， 大 多 数 同 情 者 站 在 他 们 一 边 ， 但 也 有 站 在 你 们 的 立 场 上 的 支 持 者 。 但 如 此 广 泛 讨 论 政 治 问 题 的 事 实 （ 这 是 自 “ 百 花 齐 放 ” 运 动 以 来 首 次 ） 增 强 了 人 民 对 民 主 变 革 不 可 避 免 的 信 心 。 谁 知 道 结 果 会 是 什 么 …";
			GlobalScript.inst.gameState.data[1] += 30;
			GlobalScript.inst.gameState.data[4] += 80;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[6] -= 10;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 2)
				{
					politic3.power += 50;
					politic3.loyality += 50;
				}
			}
			break;
		}
		case 2:
		{
			text = " 你 没 有 特 别 的 反 应 。 左 翼 和 右 翼 之 间 的 斗 争 大 多 不 会 超 出 中 共 会 议 室 的 墙 壁 ， 我 们 的 媒 体 继 续 在 你 的 支 持 下 发 言 ， 批 评 改 革 派 和 他 们 的 支 持 者 的 文 章 （ 事 实 证 明 媒 体 不 是 特 别 有 用 ） ， 学 生 们 继 续 悬 挂 大 字 报 。 嗯 ， 至 少 没 有 看 到 大 规 模 的 不 满 。";
			GlobalScript.inst.gameState.data[1] -= 80;
			GlobalScript.inst.gameState.data[4] += 120;
			GlobalScript.inst.gameState.data[3] -= 60;
			party_change[3] = 1f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 2)
				{
					politic.power += 150;
					politic.loyality += 50;
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
