using EventsForDLC;
using UnityEngine;

public class Event20 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 批 邓 反 击 右 倾 翻 案 风";
		text = " 周 恩 来 的 去 世 严 重 影 响 了 他 的 得 力 助 手 邓 小 平 的 地 位 ， 没 有 前 总 理 的 庇 护 。 他 现 在 经 常 受 到 以 毛 泽 东 夫 人 江 青 为 首 的 激 进 分 子 的 攻 击 ，2 月2 日 ， 邓 小 平 被 调 到 对 外 关 系 领 域 工 作 。 在 毛 泽 东 及 其 支 持 者 的 批 准 下 ， 他 们 成 功 地 发 起 了 “ 批 邓 反 击 右 倾 翻 案 风 ” 运 动 ， 并 在 媒 体 上 对 邓 进 行 了 积 极 的 迫 害 。 值 得 注 意 的 是 ， 尽 管 毛 泽 东 对 邓 小 平 不 信 任 ， 但 他 还 没 有 参 与 到 对 他 的 迫 害 中 。 既 然 华 国 锋 和 江 青 或 邓 小 平 都 没 有 良 好 的 关 系 ， 那 我 们 该 怎 么 办 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 什 么 也 别 做 。 让 江 青 与 邓 小 平 互 相 对 立";
		button_text[1] = " 加 入 对 小 平 的 迫 害";
		button_text[2] = " 支 持 小 平";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 批 邓 反 击 右 倾 翻 案 风";
		switch (result_num)
		{
		case 0:
			text = " 在 江 青 同 志 所 控 制 的 党 刊 中 ， 开 始 了 对 邓 小 平 其 人 及 其 思 想 的 批 判 ， 现 在 邓 小 平 已 经 解 除 一 切 公 务 ， 赋 闲 在 家 了 。 然 而 这 些 举 动 看 起 来 有 些 收 效 甚 微 ， 邓 小 平 作 为 周 恩 来 的 亲 切 战 友 和 名 义 上 纠 正 大 跃 进 错 误 的 “ 功 臣 ” 而 备 受 尊 敬 。 党 的 中 央 委 员 会 在 毛 主 席 的3 月3 日 指 示 确 定 了 文 化 大 革 命 的 合 法 性 和 邓 小 平 仍 然 是 一 个 不 称 职 的 党 员 之 后 也 开 始 了 对 邓 小 平 的 批 判 ， 各 个 省 委 也 随 即 开 始 了 对 邓 小 平 的 批 判 。";
			GlobalScript.inst.gameState.data[3] -= 20;
			GlobalScript.inst.gameState.data[4] += 40;
			GlobalScript.inst.gameState.politics[12].power -= 100;
			break;
		case 1:
		{
			text = " 在 江 青 同 志 所 控 制 的 党 刊 中 ， 开 始 了 对 邓 小 平 其 人 及 其 思 想 的 批 判 ， 华 国 锋 也 认 为 邓 小 平 以 及 背 后 的 改 革 派 只 能 让 中 国 回 到 资 本 主 义 的 奴 役 之 中 。 现 在 邓 小 平 已 经 解 除 一 切 公 务 ， 赋 闲 在 家 了 。 然 而 这 些 举 动 看 起 来 有 些 收 效 甚 微 ， 邓 小 平 作 为 周 恩 来 的 亲 切 战 友 和 名 义 上 纠 正 大 跃 进 错 误 的 “ 功 臣 ” 而 备 受 尊 敬 。 党 的 中 央 委 员 会 在 毛 主 席 的3 月3 日 指 示 确 定 了 文 化 大 革 命 的 合 法 性 和 邓 小 平 仍 然 是 一 个 不 称 职 的 党 员 之 后 也 开 始 了 对 邓 小 平 的 批 判 ， 各 个 省 委 也 随 即 开 始 了 对 邓 小 平 的 批 判 。";
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.data[3] -= 20;
			int[] data2 = GlobalScript.inst.gameState.data;
			int num3 = 88;
			ref int reference2 = ref data2[num3];
			int num4 = data2[num3];
			reference2 = num4 - 1;
			GlobalScript.inst.gameState.data[4] += 30;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 50;
				}
				if (politic2.traits[0] == 20)
				{
					politic2.loyality += 30;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality -= 100;
				}
			}
			GlobalScript.inst.gameState.politics[12].power -= 130;
			break;
		}
		case 2:
		{
			text = " 在 江 青 同 志 所 控 制 的 党 刊 中 ， 开 始 了 对 邓 小 平 其 人 及 其 思 想 的 批 判 。 然 而 你 ， 作 为 邓 小 平 的 拥 护 者 ， 声 称 尽 管 邓 小 平 犯 了 错 误 ， 但 他 已 经 认 识 到 了 它 们 并 且 为 中 国 的 发 展 做 出 了 贡 献 。 这 造 成 了 中 共 高 层 的 不 满 ， 但 对 人 民 来 说 ， 邓 小 平 作 为 周 恩 来 的 亲 切 战 友 和 名 义 上 纠 正 大 跃 进 错 误 的 “ 功 臣 ” 而 备 受 尊 敬 。 党 的 中 央 委 员 会 在 毛 主 席 的3 月3 日 指 示 确 定 了 文 化 大 革 命 的 合 法 性 和 邓 小 平 仍 然 是 一 个 不 称 职 的 党 员 之 后 也 开 始 了 对 邓 小 平 的 批 判 ， 各 个 省 委 也 随 即 开 始 了 对 邓 小 平 的 批 判 。";
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.data[1] -= 70;
			int[] data = GlobalScript.inst.gameState.data;
			int num = 88;
			ref int reference = ref data[num];
			int num2 = data[num];
			reference = num2 + 1;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.politics[12].loyality += 200;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 100;
				}
				else if (politic.traits[0] == 3)
				{
					politic.loyality += 50;
				}
				else if (politic.traits[0] > 0)
				{
					politic.loyality += 100;
				}
			}
			GlobalScript.inst.gameState.politics[12].power -= 80;
			GlobalScript.inst.gameState.politics[12].loyality += 250;
			break;
		}
		}
	}
}
