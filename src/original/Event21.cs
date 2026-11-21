using EventsForDLC;
using UnityEngine;

public class Event21 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 周 恩 来 的 再 放 送";
		text = "1976 年3 月25 日 ， 上 海 报 纸 《 文 汇 报 》 刊 登 了 一 篇 文 章 ， 尖 锐 地 批 评 了 邓 小 平 及 其 改 革 思 想 ， 不 仅 如 此 ， 文 章 还 批 判 了 邓 小 平 及 其 “ 后 台 ” ， 称 还 有 另 一 个 “ 走 资 派 ” 、 “ 资 本 主 义 道 路 的 支 持 者 ” 。 这 些 材 料 看 上 去 是 在 影 射 已 故 的 总 理 周 恩 来 ， 但 负 责 《 文 汇 报 》 四 人 帮 和 周 恩 来 的 关 系 似 乎 并 没 有 坏 到 要 在 他 死 后 作 文 章 污 蔑 。 但 不 可 否 认 的 是 ， 这 篇 文 章 一 经 大 规 模 出 版 ， 绝 对 会 有 不 少 人 将 其 当 作 对 已 故 总 理 的 公 开 谴 责 与 侮 辱 ， 而 你 可 以 和 四 人 帮 直 接 挑 明 此 事 ， 抑 或 是 顺 水 推 舟 火 上 浇 油 ， 又 或 者 什 么 都 不 做 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 什 么 都 不 做";
		button_text[1] = " 和 四 人 帮 联 系 ， 说 明 “ 影 射 ” 的 问 题";
		button_text[2] = " 支 持 这 篇 文 章 的 论 点 并 在 媒 体 上 大 肆 宣 扬";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 周 恩 来 的 再 放 送";
		switch (result_num)
		{
		case 0:
			text = " 这 篇 文 章 被 认 为 是 对 死 者 的 侮 辱 ， 也 是 一 场 极 左 分 子 的 压 制 意 识 形 态 运 动 的 开 始 ， 在 长 江 流 域 的 一 些 城 市 引 发 了 抗 议 。 南 京 爆 发 了 大 规 模 的 抗 议 活 动 。 尽 管 我 们 试 图 封 锁 有 关 抗 议 的 信 息 ， 抗 议 的 消 息 似 乎 已 经 传 到 北 京 ， 那 里 的 人 们 也 开 始 上 街 抗 议 。";
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[4] += 50;
			break;
		case 1:
		{
			text = " 你 致 电 了 《 文 汇 报 》 后 台 张 春 桥 ， 委 婉 地 暗 示 文 章 可 能 会 被 认 为 “ 影 射 ” 一 位 故 人 而 引 起 误 会 ， 而 他 很 快 就 意 识 到 文 章 的 问 题 ， 于 是 紧 急 要 求 撤 回 材 料 并 停 止 继 续 出 版 ， 但 一 些 地 区 如 南 京 已 经 出 现 了 抨 击 《 文 汇 报 》 文 章 的 大 字 报 （ 我 们 尚 且 不 知 道 他 们 是 怎 么 这 么 快 获 得 最 新 的 《 文 汇 报 》 的 ） 。 但 总 的 来 说 ， 因 为 及 时 撤 回 并 发 布 了 修 改 版 的 文 章 ， 这 件 事 并 未 在 全 国 引 起 多 么 大 的 轰 动 ， 一 切 都 在 掌 握 之 中 ， 张 春 桥 等 人 也 对 你 表 示 了 感 谢 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[3] -= 30;
			GlobalScript.inst.gameState.data[4] += 30;
			GlobalScript.inst.gameState.data[88] += 2;
			GlobalScript.inst.gameState.politics[12].loyality += 200;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 50;
				}
				else if ((politic2.traits[0] > 0 && politic2.traits[0] < 2) || politic2.traits[0] == 20)
				{
					politic2.loyality += 50;
				}
			}
			break;
		}
		case 2:
		{
			text = " 你 总 结 了 这 些 文 件 的 主 旨 并 开 始 把 它 们 在 上 海 以 外 的 媒 体 出 版 ， 这 当 然 是 党 所 喜 欢 的 ， 但 不 是 人 民 。 这 篇 文 章 被 认 为 是 对 死 者 的 侮 辱 ， 也 是 一 场 极 左 分 子 压 制 意 识 形 态 运 动 的 开 始 ， 在 长 江 流 域 的 一 些 城 市 引 发 了 抗 议 。 南 京 爆 发 了 大 规 模 的 抗 议 活 动 。 但 由 于 你 的 “ 努 力 ” ， 抗 议 已 经 发 展 到 了 中 国 的 其 他 部 分 ， 包 括 北 京 。 幸 运 的 是 ， 局 势 仍 在 掌 控 之 中 。";
			GlobalScript.inst.gameState.data[3] -= 80;
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[1] += 50;
			int[] data = GlobalScript.inst.gameState.data;
			int num = 88;
			ref int reference = ref data[num];
			int num2 = data[num];
			reference = num2 - 1;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] > 0 && politic.traits[0] < 3)
				{
					politic.loyality -= 70;
				}
			}
			break;
		}
		}
	}
}
