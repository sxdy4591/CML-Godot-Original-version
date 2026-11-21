using EventsForDLC;
using UnityEngine;

public class Event24 : EventsSecond
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
		name = " 变 革 之 风 ？";
		text = " 在 毛 主 席 死 后 ， 你 终 于 掌 握 了 权 力 ， 是 时 候 勾 勒 未 来 的 蓝 图 了 。 党 内 的 派 系 有 着 各 式 各 样 的 图 纸 。 保 守 的 毛 派 想 要 继 续 毛 泽 东 的 政 策 ， 但 不 包 括 那 些 有 问 题 的 实 验 ， 也 就 意 味 着 结 束 文 革 和 政 治 运 动 。 改 革 派 们 当 然 要 求 结 束 文 革 并 开 始 大 规 模 改 革 毛 主 席 曾 试 图 干 涉 但 失 败 的 中 国 经 济 。 所 有 温 和 派 都 相 信 中 国 需 要 变 革 ， 有 些 要 求 结 束 文 革 并 进 行 小 规 模 经 济 整 顿 ， 另 一 些 人 同 样 要 求 市 场 经 济 深 度 改 革 。 然 而 激 进 的 毛 派 并 不 打 算 和 文 革 分 道 扬 镳 ， 他 们 顶 着 路 线 错 误 的 威 胁 要 求 继 续 文 革 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 我 们 将 尽 快 结 束 文 革 ， 以 毛 主 席 的 遗 志 为 准 绳 前 进 ！";
		if (GlobalScript.inst.gameState.data[84] == 3)
		{
			button_text[1] = " 坚 定 的 支 持 毛 主 席 的 决 定 ， 不 偏 不 倚 走 无 产 阶 级 专 政 下 继 续 革 命 路 线 ， 反 对 修 正 主 义 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 文 革 已 经 得 罪 了 所 有 人 啦";
		}
		if (GlobalScript.inst.gameState.data[84] != 3)
		{
			button_text[2] = " 赶 紧 结 束 文 革 吧 ， 经 济 还 得 再 折 腾 折 腾 … …";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = "";
		}
		if (GlobalScript.inst.gameState.data[84] != 3)
		{
			button_text[3] = " 赶 紧 结 束 文 革 ， 我 们 要 准 备 大 的 历 史 转 折 并 进 入 国 际 市 场 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = "";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 变 革 之 风 ？";
		switch (result_num)
		{
		case 0:
		{
			text = " 你 以 “ 两 个 凡 是 ” — — “ 凡 是 毛 主 席 做 出 的 决 策 ， 我 们 都 坚 决 维 护 ； 凡 是 毛 主 席 的 指 示 ， 我 们 都 始 终 不 渝 地 遵 循 。 ” 为 口 号 ， 庄 严 宣 布 了 中 国 人 民 对 毛 主 席 的 教 导 的 忠 贞 不 渝 。 尽 管 如 此 ， 苟 延 残 喘 至 今 的 文 化 大 革 命 中 较 近 期 的 决 定 开 始 被 大 规 模 地 取 消 ， 这 当 然 使 中 国 人 民 高 兴 了 。 但 是 ， 进 一 步 坚 持 保 守 版 本 的 毛 泽 东 思 想 也 引 起 了 国 内 外 人 民 和 中 国 共 产 党 中 改 革 派 的 不 满 。";
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.modifies[3].active = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality += 100;
				}
				if (politic3.traits[0] == 20)
				{
					politic3.loyality += 80;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.loyality -= 100;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality += 50;
				}
			}
			party_change[0] = 3f;
			party_change[1] = 5f;
			GlobalScript.inst.gameState.data[87] = 1;
			break;
		}
		case 1:
		{
			text = " 依 靠 着 忠 诚 的 激 进 分 子 和 基 于 口 号 “ 两 个 凡 是 ” — — “ 凡 是 毛 主 席 做 出 的 决 策 ， 我 们 都 坚 决 维 护 ； 凡 是 毛 主 席 的 指 示 ， 我 们 都 始 终 不 渝 地 遵 循 。 ” 你 宣 誓 要 对 修 正 主 义 进 行 毫 不 妥 协 的 斗 争 和 忠 诚 于 毛 泽 东 思 想 和 文 化 大 革 命 的 原 则 ， 你 在 考 虑 了 以 往 的 错 误 后 ， 试 图 再 一 次 点 燃 斗 争 的 火 焰 。 伴 随 着 对 修 正 主 义 者 的 镇 压 浪 潮 而 来 的 是 对 新 一 轮 文 化 大 革 命 不 满 的 人 们 发 表 的 一 次 又 一 次 的 演 讲 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] += 100;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
				}
				if (politic2.traits[0] == 20)
				{
					politic2.loyality += 80;
				}
				else if (politic2.traits[0] > 0)
				{
					politic2.loyality -= 200;
					politic2.power -= 100;
				}
			}
			party_change[0] = 8f;
			party_change[1] = 3f;
			GlobalScript.inst.gameState.data[87] = 2;
			break;
		}
		case 2:
		{
			text = " 你 说 文 化 大 革 命 已 经 完 成 了 它 的 历 史 任 务 ， 所 以 你 开 始 消 灭 文 化 大 革 命 的 最 后 遗 产 。 同 时 ， 您 特 别 强 调 了 中 国 调 整 经 济 结 构 和 进 行 现 代 化 建 设 的 必 要 性 ， 您 还 没 有 提 出 具 体 的 措 施 ， 但 改 革 派 和 人 民 正 在 等 待 着 中 国 的 改 变 ， 期 望 您 让 它 变 得 更 好 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[4] += 80;
			GlobalScript.inst.gameState.modifies[3].active = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 0)
				{
					politic4.loyality -= 20;
				}
				else if (politic4.traits[0] < 3)
				{
					politic4.loyality += 100;
				}
			}
			party_change[2] = 8f;
			party_change[3] = 3f;
			GlobalScript.inst.gameState.data[87] = 3;
			break;
		}
		case 3:
		{
			text = " 你 说 要 迅 速 消 灭 文 化 大 革 命 的 遗 毒 ， 这 是 党 和 人 民 都 喜 欢 的 。 同 时 ， 您 也 谈 到 了 中 国 经 济 进 一 步 市 场 化 改 革 的 必 要 性 ， 以 及 如 何 逐 步 进 入 世 界 市 场 的 问 题 。 为 此 ， 您 开 始 积 极 推 动 赵 紫 阳 、 邓 小 平 等 老 改 革 家 回 归 ， 使 他 们 回 到 了 副 总 理 的 位 置 。 人 民 在 等 待 着 中 国 的 变 化 ， 但 党 内 的 保 守 派 对 你 的 决 定 表 示 不 满 。";
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.modifies[3].active = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 100;
				}
				if (politic.traits[0] == 20)
				{
					politic.loyality -= 50;
				}
				else if (politic.traits[0] > 1)
				{
					politic.loyality += 100;
				}
			}
			party_change[2] = 3f;
			party_change[3] = 8f;
			party_change[4] = 3f;
			GlobalScript.inst.gameState.data[87] = 4;
			break;
		}
		}
	}
}
