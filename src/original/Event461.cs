using EventsForDLC;
using UnityEngine;

public class Event461 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 福 尔 摩 沙 之 春";
		text = "  解 放 战 争 胜 利 后 ， 国 民 党 败 逃 到 台 湾 岛 ， 由 于 美 国 在 台 湾 的 基 地 和 舰 队 ， 我 们 无 法 解 放 它 ， 但 现 如 今 的 情 况 已 大 有 不 同 ： 美 国 这 只 曾 经 的 雄 鹰 已 然 陨 落 ， 台 湾 岛 的 军 事 基 地 也 撤 离 了 ， 而 我 们 在 之 前 对 美 丽 岛 左 派 的 援 助 也 为 我 们 在 台 湾 争 取 到 了 足 以 和 蒋 伪 政 府 抗 衡 的 盟 友 。 或 许 我 们 可 以 对 台 湾 施 加 更 大 的 压 力 以 帮 助 日 益 中 兴 的 台 湾 左 派 联 盟 推 翻 蒋 伪 政 府 并 “ 回 归 ” 中 国 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.resultOfEvents[460] == 0)
		{
			button_text[0] = " 给 台 湾 蒋 伪 政 府 当 局 以 制 裁 与 禁 运 ， 同 时 帮 助 左 派 组 建 统 一 的 政 党";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 台 湾 左 派 的 力 量 太 弱 了 ！";
		}
		button_text[1] = " 给 台 湾 蒋 伪 政 府 当 局 以 制 裁 与 禁 运";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 福 尔 摩 沙 之 春";
		GlobalScript.inst.gameState.allcountries[38].LeaveAlliances();
		if (result_num == 0)
		{
			text = " 随 着 我 们 对 台 湾 当 局 施 加 了 巨 大 的 压 力 ， 制 裁 和 禁 运 迅 速 压 垮 了 这 个 本 就 没 有 什 么 自 给 能 力 的 小 岛 。 在 一 次 对 抗 政 府 的 示 威 中 。 我 们 的 特 务 借 机 煽 风 点 火 ， 在 “ 你 可 听 见 人 民 的 呼 声 ” 的 歌 声 中 ， 军 警 拒 绝 了 接 受 蒋 经 国 总 统 关 于 对 人 民 开 枪 的 指 令 ， 事 实 上 发 生 了 哗 变 。 感 到 自 己 时 日 无 多 的 蒋 经 国 收 拾 了 细 软 ， 逃 往 美 国 檀 香 山 。\n  我 们 的 努 力 得 到 了 回 报 ， 由 吴 荣 元 组 建 的 “ 红 统 ” 派 台 湾 劳 动 党 事 实 上 夺 取 了 台 湾 的 政 治 权 利 。 作 为 推 翻 蒋 氏 暴 政 的 英 雄 ， 以 及 对 大 陆 美 好 生 活 的 向 往 ， 台 湾 迅 速 决 定 了 接 受 中 华 人 民 共 和 国 管 理 的 决 定 。 外 企 被 悉 数 收 回 ， 美 国 军 队 也 悉 数 撤 回 。 而 和 大 陆 之 间 的 隔 阂 也 被 消 除 。 尽 管 名 义 上 台 湾 组 建 了 自 己 的 ， 独 立 于 北 京 的 政 府 ， 但 是 谁 都 知 道 ， 台 湾 和 大 陆 再 也 不 会 分 开 了 。 ";
			GlobalScript.inst.gameState.allcountries[38].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[38].SubGosstroy = 2;
			GlobalScript.inst.gameState.allcountries[38].proprc = true;
			GlobalScript.inst.gameState.allcountries[38].Torg = true;
			GlobalScript.inst.gameState.allcountries[38].puppetOf = 1;
			GlobalScript.inst.gameState.allcountries[38].name = " 台 湾 特 别 行 政 区";
			if (GlobalScript.inst.gameState.allcountries[1].econ)
			{
				GlobalScript.inst.gameState.allcountries[38].econ = true;
			}
			if (GlobalScript.inst.gameState.allcountries[1].okb)
			{
				GlobalScript.inst.gameState.allcountries[38].okb = true;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEV)
			{
				GlobalScript.inst.gameState.allcountries[38].isSEV = true;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isOVD)
			{
				GlobalScript.inst.gameState.allcountries[38].isOVD = true;
			}
			GlobalScript.inst.gameState.empires[0].relations -= 500;
			GlobalScript.inst.gameState.data[1] += 300;
			GlobalScript.inst.gameState.data[3] += 300;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[9] -= 100;
		}
		if (result_num == 1)
		{
			text = " 随 着 我 们 对 台 湾 当 局 施 加 了 巨 大 的 压 力 ， 制 裁 和 禁 运 迅 速 压 垮 了 这 个 本 就 没 有 什 么 自 给 能 力 的 小 岛 。 在 一 次 对 抗 政 府 的 示 威 中 。 我 们 的 特 务 借 机 煽 风 点 火 ， 在 “ 你 可 听 见 人 民 的 呼 声 ” 的 歌 声 中 ， 军 警 拒 绝 了 接 受 蒋 经 国 总 统 关 于 对 人 民 开 枪 的 指 令 ， 事 实 上 发 生 了 哗 变 。 感 到 自 己 时 日 无 多 的 蒋 经 国 收 拾 了 细 软 ， 逃 往 美 国 檀 香 山 。\n 由 倒 蒋 集 团 组 成 的 大 帐 篷 式 政 党 “ 民 主 进 步 党 ” 在 大 选 中 击 溃 了 国 民 党 。 新 他 们 立 刻 宣 布 将 和 “ 中 华 人 民 共 和 国 展 开 深 入 的 合 作 ” 。 新 政 府 立 即 着 手 驱 赶 美 军 士 兵 ， 并 放 弃 了 对 于 大 陆 的 宣 称 。 我 们 决 定 在 和 平 对 等 的 基 础 上 吸 纳 台 湾 。 他 们 会 和 祖 国 母 亲 团 结 在 一 起 ， 直 到 永 远 。";
			GlobalScript.inst.gameState.allcountries[38].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[38].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[38].proprc = true;
			GlobalScript.inst.gameState.allcountries[38].Torg = true;
			GlobalScript.inst.gameState.empires[0].relations -= 300;
			GlobalScript.inst.gameState.allcountries[38].name = " 台 湾 特 别 行 政 区";
			if (GlobalScript.inst.gameState.allcountries[1].econ)
			{
				GlobalScript.inst.gameState.allcountries[38].econ = true;
			}
			if (GlobalScript.inst.gameState.allcountries[1].okb)
			{
				GlobalScript.inst.gameState.allcountries[38].okb = true;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isSEV)
			{
				GlobalScript.inst.gameState.allcountries[38].isSEV = true;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isOVD)
			{
				GlobalScript.inst.gameState.allcountries[38].isOVD = true;
			}
			GlobalScript.inst.gameState.data[1] += 200;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[9] -= 50;
		}
	}
}
