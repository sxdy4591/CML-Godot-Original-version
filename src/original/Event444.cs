using EventsForDLC;
using UnityEngine;

public class Event444 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 漫 长 的 革 命";
		text = " 主 席 同 志 ！ 伟 大 领 袖 毛 主 席 发 起 的 无 产 阶 级 文 化 大 革 命 经 历 重 重 波 折 ， 延 续 至 今 。 可 以 这 么 说 ， 这 场 革 命 一 直 在 党 的 保 护 下 发 展 。 虽 然 在 过 去 ， 我 们 粉 碎 了 刘 少 奇 反 革 命 集 团 和 邓 小 平 反 革 命 集 团 ， 取 得 了 许 多 成 果 ； 但 是 ， 这 场 革 命 仍 然 有 许 多 仍 然 有 许 多 遗 留 的 问 题 以 及 过 去 不 得 不 妥 协 之 处 。 我 们 的 党 在 过 去 对 这 场 革 命 有 些 包 办 替 代 了 ， 群 众 终 究 还 是 需 要 自 己 解 放 自 己 ， 不 然 ， 反 动 的 旧 势 力 总 有 反 扑 的 时 候 ...... 现 在 ， 我 们 有 了 成 长 于 革 命 的 新 一 代 人 ， 他 们 已 经 成 为 了 当 代 革 命 的 中 坚 力 量 ， 大 量 新 生 的 造 反 派 已 经 进 入 的 党 中 央 — — 就 像60 年 代 革 命 刚 刚 发 动 时 一 样 ， 民 众 重 拾 了 革 命 的 热 情 ， 自 发 地 与 腐 朽 思 想 和 反 动 的 旧 势 力 作 斗 争 。 他 们 批 判 革 命 委 员 会 制 度 的 妥 协 、 批 评 出 版 审 查 的 严 厉 和 不 够 落 实 的 “ 四 大 自 由 ” 甚 至 是 散 乱 的 群 众 组 织 本 身 … … 人 民 群 众 已 经 有 了 足 够 的 成 长 ， 他 们 自 发 地 与 资 产 阶 级 反 动 思 想 战 斗 ， 决 定 彻 底 的 自 由 ， 他 们 渴 望 进 行 彻 底 的 变 革 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[56] < 1 && GlobalScript.inst.gameState.resultOfEvents[307] == 2 && GlobalScript.inst.gameState.resultOfEvents[111] == 1)
		{
			button_text[0] = " 相 信 我 们 的 人 民 ！ ";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "";
		}
		button_text[1] = " 我 们 的 人 民 还 没 准 备 好 迎 接 和 反 动 派 的 斗 争 ...... ";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 漫 长 的 革 命";
		switch (result_num)
		{
		case 0:
		{
			text = " 根 据 中 央 委 员 会 的 决 议 ， 我 们 的 党 决 定 开 始 逐 步 放 松 过 去 因 为 需 要 引 导 群 众 而 采 取 的 政 策 ， 实 施 真 正 的 无 产 阶 级 大 民 主 ！ 在 政 治 方 面 ， 各 个 革 命 委 员 会 依 靠 造 反 派 群 众 组 织 ， 开 始 改 组 为 类 似 巴 黎 公 社 的 体 制 ； 审 查 方 面 ， 由 群 众 选 举 的 审 查 委 员 会 和 党 的 干 部 共 同 审 查 的 制 度 ， 过 去 仅 供 内 部 放 映 的 内 参 片 正 在 公 开 上 映 ， 交 由 群 众 批 判 ； 社 会 上 ， 大 字 报 、 大 辩 论 再 次 活 跃 于 街 头 各 处 ， 这 是 和 资 产 阶 级 的 “ 自 由 ” 完 全 不 同 的 风 气 … … 新 一 轮 变 革 正 在 开 始 ， 无 产 阶 级 文 化 大 革 命 进 入 了 新 的 阶 段 ！";
			GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
			GlobalScript.inst.gameState.doctr[19] = "自 由 境 界";
			GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
			GlobalScript.inst.gameState.data[3] += 1000 - GlobalScript.inst.gameState.data[3];
			GlobalScript.inst.gameState.data[15] = 6;
			GlobalScript.inst.gameState.data[17] = 19;
			GlobalScript.inst.gameState.data[50] = 24;
			GlobalScript.inst.gameState.data[1] += 300;
			GlobalScript.inst.gameState.influencePRC += 100;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 1000;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality -= 300;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality -= 700;
				}
				else if (politic2.traits[0] == 3)
				{
					politic2.loyality -= 1000;
				}
			}
			break;
		}
		case 1:
		{
			text = " 现 在 还 没 有 到 那 种 程 度 ， 我 们 的 国 家 和 党 还 没 有 做 好 准 备 迎 接 那 种 状 况 。 这 种 保 守 姿 态 令 党 内 左 派 和 革 命 群 众 感 到 不 满 ， 甚 至 有 人 开 始 贴 大 字 报 批 评 党 中 央 的 “ 右 倾 ”...... ";
			GlobalScript.inst.gameState.data[3] -= 200;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 1000;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality += 300;
				}
			}
			break;
		}
		}
	}
}
