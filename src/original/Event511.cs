using EventsForDLC;
using UnityEngine;

public class Event511 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 黄 金 海 岸 的 再 革 命 ？ — — 第 三 幕";
		text = " 两 年 以 来 ， 罗 林 斯 将 社 会 主 义 、 民 族 主 义 和 民 粹 主 义 混 合 起 来 的 理 念 的 实 施 并 未 能 为 加 纳 经 济 带 来 十 分 乐 观 的 发 展 ， 政 府 补 贴 为 财 政 带 来 了 负 担 并 造 成 了 通 货 膨 胀 。 有 报 告 显 示 ， 罗 林 斯 正 在 寻 求 外 部 的 经 济 援 助 和 投 资 ， 苏 东 阵 营 甚 至 是 西 方 控 制 的 I M F 都 将 可 能 成 为 加 纳 的 帮 助 者 。 很 明 显 ， 现 在 正 是 我 们 掺 和 加 纳 的 时 候 ， 应 不 应 该 为 罗 林 斯 提 供 一 笔 无 息 贷 款 ？ 这 将 能 为 我 们 争 取 一 个 盟 友 ， 并 保 住 非 洲 的 一 个 进 步 政 权 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 3)
		{
			button_text[0] = " 我 们 将 为 加 纳 提 供 帮 助";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 会 帮 他";
		}
		if (a.allcountries[1].isSEV)
		{
			button_text[1] = " 邀 请 加 纳 加 入 经 互 会 ， 在 经 互 会 体 系 内 为 加 纳 提 供 帮 助";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 为 社 会 帝 国 主 义 者 做 事 ！";
		}
		button_text[2] = " 我 们 无 能 为 力";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 黄 金 海 岸 的 再 革 命 ？ — — 第 三 幕";
		if (result_num == 0)
		{
			text = " 我 们 为 加 纳 提 供 了 大 批 援 助 ， 作 为 交 换 ， 他 将 为 我 们 提 供 廉 价 可 可 ， 并 为 我 们 在 加 纳 开 采 黄 金 和 勘 探 石 油 提 供 最 大 的 帮 助 ， 我 们 的 投 资 的 涌 入 也 为 加 纳 经 济 注 入 了 活 力 。 另 一 方 面 ， 罗 林 斯 表 示 他 也 将 继 续 参 与 非 洲 进 步 政 权 之 间 的 友 好 合 作 ， 并 继 续 开 展 “ 加 纳 的 人 民 民 主 革 命 ” ， 他 参 照 我 们 的 经 验 ， 组 织 了 加 纳 人 民 革 命 党 ， 并 继 续 实 施 保 卫 革 命 委 员 会 下 的 直 接 民 主 。";
			GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[63].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[63].Torg = true;
			GlobalScript.inst.gameState.allcountries[63].proprc = true;
			a.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[63].JoinAllOurAlliances(yes: true);
			a.empires[0].relations -= 100;
			a.data[8] -= 70;
		}
		if (result_num == 1)
		{
			a.data[8] -= 30;
			text = " 得 益 于 我 们 在 经 互 会 内 的 地 位 ， 我 们 提 议 将 加 纳 纳 入 社 会 主 义 的 真 正 进 步 的 经 济 体 系 ， 加 纳 将 为 社 会 主 义 阵 营 提 供 可 可 、 石 油 和 黄 金 等 特 产 ， 社 会 主 义 阵 营 将 为 加 纳 提 供 工 业 化 和 农 业 现 代 化 的 设 备 和 相 关 干 部 的 援 助 。 很 快 ， 加 纳 的 经 济 稳 定 下 来 了 。 罗 林 斯 宣 布 加 纳 “ 进 入 了 人 民 民 主 革 命 的 阶 段 ” ， 他 正 在 组 织 加 纳 人 民 革 命 党 ， 加 纳 将 被 改 造 为 一 个 真 正 的 社 会 主 义 国 家 。";
			GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[63].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[63].isSEV = true;
			GlobalScript.inst.gameState.allcountries[63].prosov = true;
			GlobalScript.inst.gameState.allcountries[63].Torg = true;
			a.empires[0].relations -= 100;
			a.empires[1].relations += 100;
		}
		if (result_num == 2)
		{
			if (a.empires[0].power > a.empires[1].power)
			{
				text = " 最 开 始 ， 加 纳 向 莫 斯 科 和 利 比 亚 寻 求 援 助 ， 但 是 苏 联 阵 营 陷 入 衰 弱 无 力 支 援 ， 卡 扎 菲 则 表 示 没 有 资 金 ， 但 可 以 提 供 低 价 石 油 。 由 于 无 法 从 东 欧 阵 营 得 到 援 助 ， 加 纳 从 国 际 货 币 基 金 组 织 、 世 界 银 行 和 西 欧 国 家 获 得 了 大 量 贷 款 。 在 他 们 的 敦 促 下 ， 罗 林 斯 放 弃 了 部 分 左 翼 政 策 ， 经 济 开 始 放 松 管 制 ， 进 行 部 分 自 由 化 的 改 革 ， 以 寻 求 更 多 的 投 资 。 1 9 8 3 年 4 月 政 府 颁 布 了 《 经 济 复 苏 计 划 》 ， 决 定 实 施 价 格 自 由 化 ， 减 少 国 家 在 经 济 管 理 中 的 作 用 ， 政 府 采 取 了 货 币 贬 值 ， 并 将 部 分 国 企 可 私 有 化 ， 如 可 可 、 黄 金 和 木 材 产 业 。 加 纳 经 济 正 在 向 好 ， 其 领 导 层 的 左 翼 谴 责 罗 林 斯 “ 背 叛 了 革 命 ” 。";
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 15;
			}
			else
			{
				text = " 加 纳 向 莫 斯 科 和 利 比 亚 寻 求 援 助 ， 莫 斯 科 方 面 为 其 提 供 了 一 系 列 资 金 ， 利 比 亚 为 加 纳 的 工 业 化 提 供 了 石 油 ， 苏 东 国 家 在 加 纳 开 设 了 合 资 国 营 企 业 ， 并 为 其 提 供 了 钻 机 以 开 发 石 油 产 业 。 加 纳 方 面 为 将 为 苏 联 提 供 可 可 和 木 材 ， 并 允 许 其 开 采 黄 金 。 在 苏 联 方 面 的 敦 促 下 ， 罗 林 斯 成 立 了 加 纳 人 民 革 命 党 筹 建 委 员 会 ， 并 开 始 尝 试 加 大 合 作 化 和 国 有 化 ， 准 备 将 国 家 向 马 列 主 义 模 式 的 社 会 主 义 国 家 改 造 ， 以 融 入 苏 联 阵 营 。 加 纳 经 济 正 在 向 好 ， 其 领 导 层 的 左 翼 对 加 纳 革 命 有 了 新 进 展 十 分 满 意 。";
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 10;
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].prosov = true;
			}
		}
	}
}
