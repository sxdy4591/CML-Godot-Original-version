using EventsForDLC;
using UnityEngine;

public class Event535 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 君 子 报 仇 ， 十 年 不 晚";
		text = " 在 中 越 商 谈 会 后 不 久 ， 越 南 加 入 了 我 们 的 经 济 联 盟 ， 在 我 们 的 帮 助 下 ， 越 南 的 经 济 状 况 和 生 活 水 平 稳 步 提 升 。 而 黎 笋 也 迫 于 压 力 停 止 了 对 华 人 的 迫 害 ， 亲 华 派 在 越 共 党 内 占 据 了 越 来 越 重 要 的 地 位 ， 黎 笋 显 然 是 对 中 越 合 作 日 益 紧 密 的 现 状 不 满 的 ：表 面 上 他 继 续 维 持 着 对 华 缓 和 政 策 ， 在 背 地 里 ， 他 和 他 的 亲 苏 派 亲 信 们 仍 然 在 和 苏 修 社 会 帝 国 主 义 眉 来 眼 去 ， 这 导 致 我 们 始 终 不 能 继 续 加 深 和 越 南 的 合 作 ， 亲 华 派 的 同 志 们 也 愈 加 不 满 。 既 然 如 此 ， 推 动 一 场 亲 华 派 主 导 的 政 变 以 推 翻 黎 笋 政 权 似 乎 是 一 桩 稳 赚 不 赔 的 买 卖 ？ 即 便 这 或 多 或 少 会 破 坏 对 苏 联 的 关 系 ......";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 我 们 要 从 长 计 议 ......";
		button_text[1] = " 我 们 将 向 越 南 亲 华 派 提 供 特 勤 和 资 金 援 助 ， 黎 笋 修 正 主 义 者 的 末 日 到 了 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 君 子 报 仇 ， 十 年 不 晚";
		switch (result_num)
		{
		case 0:
			text = " 一 场 准 备 不 充 分 的 政 变 可 能 会 破 坏 我 们 和 越 南 刚 刚 稳 定 的 关 系 ， 更 有 可 能 彻 底 激 怒 苏 联 ， 因 此 ， 我 们 最 好 还 是 小 心 再 小 心 ......";
			break;
		case 1:
		{
			text = " 在 我 们 的 特 工 帮 助 下 ， 越 南 国 内 的 亲 华 派 很 快 与 越 南 国 安 部 门 以 及 军 方 取 得 了 联 系 并 制 定 了 详 细 的 计 划 ， 在 一 个 平 平 无 奇 的 夜 晚 ， 由 我 们 的 人 组 织 的 特 别 行 动 小 组 突 袭 了 黎 笋 的 住 所 。 几 乎 没 有 起 任 何 冲 突 ， 衣 衫 不 整 的 黎 笋 就 被 押 出 自 己 的 别 墅 。 次 日 ， 政 治 局 委 员 长 征 、 武 元 甲 、 范 文 同 和 黎 德 英 等 人 迅 速 召 开 了 临 时 中 央 全 会 ， 会 议 以 篡 改 胡 志 明 主 席 的 政 治 遗 嘱 ， 制 造 种 族 灭 绝 事 件 ， 与 西 方 资 本 主 义 世 界 间 谍 勾 结 破 坏 社 会 主 义 建 设 等 理 由 罢 免 了 黎 笋 的 总 书 记 职 位 ， 而 长 征 则 被 选 举 为 新 的 越 共 中 央 总 书 记 ， 他 宣 布 将 进 一 步 加 深 与 中 国 的 合 作 ， 加 快 开 展 社 会 主 义 建 设 。 然 而 ， 越 南 彻 底 倒 向 中 国 破 坏 了 苏 联 对 我 国 的 南 北 合 围 策 略 ， 因 此 莫 斯 科 方 面 对 这 场 政 变 感 到 不 满 。";
			GlobalScript.inst.gameState.empires[1].power -= 30;
			GlobalScript.inst.gameState.empires[1].relations -= 200;
			GlobalScript.inst.gameState.allcountries[11].proprc = true;
			GlobalScript.inst.gameState.allcountries[11].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
			GlobalScript.inst.gameState.allcountries[11].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
			GlobalScript.inst.gameState.allcountries[11].prcpower = 1000;
			GlobalScript.inst.gameState.allcountries[11].soc_stab = 1000;
			for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
			{
				if (GlobalScript.inst.gameState.allcountries[i].puppetOf == 11)
				{
					GlobalScript.inst.gameState.allcountries[i].puppetOf = -1;
				}
			}
			GlobalScript.inst.gameState.data[8] -= 40;
			GlobalScript.inst.gameState.data[9] -= 40;
			GlobalScript.inst.gameState.data[7] += 50;
			break;
		}
		}
	}
}
