using EventsForDLC;
using UnityEngine;

public class Event506 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 从 1 9 2 2 到 1 9 8 4";
		text = " 噩 耗 传 来 ！ 中 国 人 民 的 老 朋 友 ， 几 内 亚 人 民 的 革 命 领 袖 塞 古 · 杜 尔 死 于 一 连 串 的 心 脏 病 并 发 症 。 随 后 ， 几 内 亚 民 主 党 选 举 了 路 易 斯 · 兰 萨 那 · 贝 阿 沃 吉 作 为 总 统 。 新 总 统 相 当 软 弱 ， 这 使 得 党 内 的 右 翼 分 子 — — 兰 萨 纳 · 孔 戴 察 觉 到 了 可 乘 之 机 ， 他 一 直 谋 求 向 塞 古 · 杜 尔 复 仇 。 在 美 国 的 鼎 力 支 持 之 下 ， 孔 戴 掀 起 了 一 场 反 对 贝 阿 沃 吉 总 统 的 政 变 。 事 实 上 夺 取 了 政 权 ， 原 政 府 军 仍 然 在 负 隅 顽 抗 并 呼 吁 世 界 各 国 的 帮 助 。 最 高 领 导 人 同 志 ， 杜 尔 总 统 一 直 不 希 望 西 方 势 力 染 指 他 的 祖 国 。 几 内 亚 是 一 块 弹 丸 小 国 ， 但 毛 泽 东 主 席 也 曾 经 鼎 力 支 持 过 他 们 反 抗 葡 萄 牙 干 涉 军 。 也 许 ， 到 我 们 该 出 手 的 时 候 了 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 2 && a.science[24] && GlobalScript.inst.gameState.allcountries[68].Torg)
		{
			button_text[0] = " 开 始 组 织 一 场 反 政 变（ 需 要 2 百 万 预 算 和 10 点 军 力 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 能 力 做 这 样 的 事";
		}
		if (a.data[56] > 1)
		{
			button_text[1] = " 祝 贺 新 政 府";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 做 不 到 背 叛 盟 友 ！";
		}
		button_text[2] = " 好 吧 ， 谁 在 乎 呢 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 从 1 9 2 2 到 1 9 8 4";
		if (result_num == 0)
		{
			text = " 我 们 联 络 了 内 政 部 长 阿 卜 杜 拉 耶 · 杜 尔 （ 杜 尔 的 胞 弟 ） 和 贝 阿 沃 吉 总 统 。 表 示 了 愿 意 为 他 们 提 供 军 事 支 持 以 促 成 反 政 变 。 二 人 欣 然 接 受 。 很 快 ， 一 批 脸 上 涂 着 棕 色 迷 彩 的 中 国 人 民 解 放 军 士 兵 出 现 在 了 康 康 的 街 头 ， 并 与 政 变 军 发 生 了 交 火 。 几 内 亚 人 民 军 的 六 三 式 坦 克 攻 入 了 反 抗 军 据 点 ， 工 人 民 兵 也 走 上 街 头 反 抗 军 事 管 理 。 在 我 们 的 帮 助 下 ， 几 内 亚 人 民 军 彻 底 打 败 了 政 变 军 官 ， 他 们 要 么 逃 入 塞 内 加 尔 寻 求 政 治 避 难 ， 要 么 束 手 就 擒 期 待 政 府 的 宽 大 处 理 。 孔 戴 上 校 被 当 众 处 死 ， 而 群 众 为 这 一 行 为 拍 手 叫 好 。 经 此 一 役 ， 工 人 卫 队 的 地 位 大 大 的 提 高 了 。 几 内 亚 人 民 反 抗 帝 国 主 义 干 涉 的 伟 业 将 会 写 入 几 内 亚 的 历 史 书 中 ， 而 杜 尔 的 遗 产 也 保 住 了 。 几 内 亚 民 主 党 宣 布 改 为 几 内 亚 劳 动 党 ， 党 纲 里 不 再 宣 称 简 单 的 “ 泛 非 主 义 ” 和 科 学 社 会 主 义 。 而 是 要 在 走 马 克 思 ， 列 宁 ， 毛 泽 东 指 出 的 路 线 的 同 时 ， 继 续 致 力 于 非 洲 国 家 的 统 一 与 解 放 。||新 政 府 宣 布 将 扩 大 和 我 们 的 合 作 。 尤 其 是 在 构 建 完 善 的 工 人 阶 级 来 对 抗 国 家 内 部 潜 在 的 阶 级 敌 人 ， 防 止 资 产 阶 级 复 辟 。";
			a.data[8] -= 20;
			a.data[22] -= 100;
			a.influencePRC += 50;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 50;
			GlobalScript.inst.gameState.allcountries[68].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[68].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[68].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[68].Torg = true;
			GlobalScript.inst.gameState.allcountries[68].proprc = true;
		}
		if (result_num == 1)
		{
			a.data[8] -= 10;
			text = " 我 们 公 开 承 认 了 孔 戴 上 校 的 军 政 府 ， 这 招 来 了 全 非 洲 进 步 国 家 ， 甚 至 是 扎 伊 尔 的 谴 责 。||很 快 ， 政 变 军 队 攻 占 了 全 国 ， 兰 萨 纳 · 孔 戴 上 校 组 建 了 国 家 军 事 复 兴 委 员 会 。 并 开 始 着 手 进 行 “ 去 杜 尔 化 ” 。 大 量 谴 责 杜 尔 的 或 真 或 假 的 黑 材 料 被 大 量 公 布 ， 他 的 坟 墓 也 从 革 命 烈 士 陵 园 内 迁 出 。";
			GlobalScript.inst.gameState.allcountries[68].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[68].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[68].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[68].Vyshi = true;
			GlobalScript.inst.gameState.allcountries[68].Torg = true;
			a.empires[0].relations += 80;
			a.empires[0].power += 50;
		}
		if (result_num == 2)
		{
			text = " 很 快 ， 政 变 军 队 攻 占 了 全 国 ， 兰 萨 纳 · 孔 戴 上 校 组 建 了 国 家 军 事 复 兴 委 员 会 。 并 开 始 着 手 进 行 “ 去 杜 尔 化 ” 。 大 量 谴 责 杜 尔 的 或 真 或 假 的 黑 材 料 被 大 量 公 布 ， 他 的 坟 墓 也 从 革 命 烈 士 陵 园 内 迁 出 。";
			GlobalScript.inst.gameState.allcountries[68].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[68].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[68].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[68].Vyshi = true;
		}
	}
}
