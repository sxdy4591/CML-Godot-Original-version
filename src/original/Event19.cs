using EventsForDLC;
using UnityEngine;

public class Event19 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 五 “ 不 准 ”";
		text = " 祝 贺 你 被 任 命 为 国 务 院 总 理 ， 华 国 锋 同 志 ！ 如 你 所 知 ， 你 的 前 任 周 恩 来 同 志 因 他 的 诚 实 和 行 政 天 赋 在 海 内 外 颇 受 人 热 爱 和 尊 敬 。 但 他 也 是 经 济 改 革 的 积 极 推 动 者 ， 并 在 党 内 提 拔 改 革 派 ， 如 他 的 门 徒 邓 小 平 。 为 此 ，76 年1 月8 日 ， 周 的 去 世 引 起 了 人 民 极 大 的 悲 伤 ， 但 根 据 周 恩 来 “ 丧 事 从 简 ” 的 遗 愿 ， 党 发 起 了 五 个 “ 不 提 倡 ” 的 运 动 － 不 提 倡 戴 黑 纱 ， 不 提 倡 送 花 圈 ， 不 提 倡 设 灵 堂 ， 不 提 倡 开 追 悼 会 ， 不 提 倡 挂 周 恩 来 遗 像 ， 但 一 些 地 方 政 府 为 了 规 避 被 指 责 工 作 不 到 位 的 风 险 ， 选 择 了 “ 一 刀 切 ”： 将 五 个 “ 不 提 倡 ” 执 行 成 了 五 “ 不 准 ” ， 即 禁 止 一 切 关 于 周 恩 来 的 纪 念 行 为 — — 这 到 目 前 为 止 ， 只 是 引 起 了 不 满 。 而 你 ， 作 为 新 任 总 理 ， 可 以 影 响 此 事 的 执 行 。 又 或 许 ， 你 可 以 什 么 都 不 做 ， 而 是 放 任 事 态 扩 大 化 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 让 它 通 过 ， 我 们 静 观 其 变";
		button_text[1] = " 严 格 执 行 这 场 运 动";
		button_text[2] = " 严 格 执 行 这 场 运 动 ， 并 在 媒 体 上 批 评 这 种 行 为 ";
		button_text[3] = " 轻 微 地 破 坏 这 场 运 动";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 五 “ 不 准 ”";
		if (GlobalScript.inst.gameState.number_otvet == 1)
		{
			text = " 作 为 运 动 的 一 部 分 ， 警 察 和 工 人 民 兵 拆 除 了 纪 念 周 恩 来 的 临 时 纪 念 碑 ， 一 些 纪 念 周 恩 来 的 大 字 报 和 宣 传 画 也 被 撤 下 。 政 府 对 祭 奠 周 恩 来 行 为 的 压 制 引 起 了 人 民 的 不 满 ， 而 江 青 同 志 则 被 认 为 是 幕 后 黑 手 … …";
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[4] += 50;
			int[] data = GlobalScript.inst.gameState.data;
			int num = 88;
			ref int reference = ref data[num];
			int num2 = data[num];
			reference = num2 + 1;
		}
		else if (GlobalScript.inst.gameState.number_otvet == 2)
		{
			text = " 作 为 国 务 院 总 理 ， 公 安 部 部 长 ， 您 亲 自 指 挥 了 这 次 驱 散 运 动 。 作 为 运 动 的 一 部 分 ， 警 察 和 工 人 民 兵 拆 除 了 纪 念 周 恩 来 的 临 时 纪 念 碑 ， 一 些 纪 念 周 恩 来 的 大 字 报 和 宣 传 画 也 被 撤 下 。 政 府 对 祭 奠 周 恩 来 行 为 的 压 制 引 起 了 广 泛 的 不 满 ， 而 江 青 同 志 和 华 国 锋 同 志 则 被 认 为 是 幕 后 黑 手 … …";
			GlobalScript.inst.gameState.data[3] -= 70;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[6] += 10;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality += 70;
				}
			}
		}
		else if (GlobalScript.inst.gameState.number_otvet == 3)
		{
			text = " 作 为 国 务 院 总 理 ， 公 安 部 部 长 ， 您 亲 自 指 挥 了 这 次 驱 逐 活 动 并 在 人 民 日 报 的 头 版 发 表 了 对 纪 念 周 恩 来 行 为 的 批 评 ， 然 而 这 看 起 来 收 效 甚 微 ， 看 起 来 群 众 已 经 厌 倦 了 文 化 大 革 命 中 无 止 境 的 批 判 运 动 了 。 作 为 运 动 的 一 部 分 ， 警 察 和 工 人 民 兵 拆 除 了 纪 念 周 恩 来 的 临 时 纪 念 碑 ， 一 些 纪 念 周 恩 来 的 大 字 报 和 宣 传 画 也 被 撤 下 。 政 府 对 祭 奠 周 恩 来 行 为 的 压 制 和 在 媒 体 上 的 批 判 引 起 了 广 泛 的 不 满 ， 而 江 青 同 志 和 华 国 锋 同 志 则 被 认 为 是 幕 后 黑 手 … …";
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[6] += 10;
			int[] data2 = GlobalScript.inst.gameState.data;
			int num3 = 88;
			ref int reference2 = ref data2[num3];
			int num4 = data2[num3];
			reference2 = num4 - 1;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
				}
			}
		}
		else
		{
			if (GlobalScript.inst.gameState.number_otvet != 4)
			{
				return;
			}
			text = " 作 为 国 务 院 总 理 ， 公 安 部 部 长 ， 您 尽 全 力 的 将 这 次 运 动 的 规 模 控 制 在 最 小 范 围 内 ， 一 些 下 令 完 全 禁 止 纪 念 活 动 的 官 员 被 调 任 。 作 为 运 动 的 一 部 分 ， 警 察 和 工 人 民 兵 拆 除 了 纪 念 周 恩 来 的 临 时 纪 念 碑 ， 一 些 纪 念 周 恩 来 的 大 字 报 和 宣 传 画 也 被 撤 下 。 政 府 对 祭 奠 周 恩 来 行 为 的 压 制 引 起 了 人 民 的 不 满 ， 而 江 青 同 志 则 被 认 为 是 幕 后 黑 手 。 然 而 由 于 您 的 出 手 ， 这 些 不 满 并 没 有 到 不 可 收 拾 的 程 度 … …";
			GlobalScript.inst.gameState.data[3] -= 10;
			GlobalScript.inst.gameState.data[88] += 2;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.politics[12].loyality += 200;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality -= 70;
				}
				else if (politic3.traits[0] >= 1 || politic3.traits[0] == 20)
				{
					politic3.loyality += 50;
				}
			}
		}
	}
}
