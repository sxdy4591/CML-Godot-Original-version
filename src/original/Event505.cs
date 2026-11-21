using EventsForDLC;
using UnityEngine;

public class Event505 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 几 内 亚 之 父 的 终 结";
		text = " 主 席 同 志 ， 来 自 科 纳 克 里 的 紧 急 报 道 。 由 于 塞 古 · 杜 尔 总 统 灾 难 性 的 经 济 政 策 ， 导 致 几 内 亚 经 济 水 平 暴 跌 ， 而 政 府 又 限 制 私 人 企 业 的 发 展 。 着 导 致 了 小 商 贩 的 大 规 模 罢 工 ， 而 且 正 有 激 进 化 的 倾 向 。 杜 尔 总 统 本 人 对 社 会 主 义 本 就 有 极 大 的 热 情 ， 但 这 可 能 会 成 为 他 的 转 折 点 。 他 很 有 可 能 会 为 了 经 济 援 助 而 转 向 美 国 。 几 内 亚 毕 竟 曾 经 作 为 非 洲 反 殖 民 运 动 的 桥 头 堡 ， 常 常 支 持 我 国 的 行 动 。 也 行 我 们 应 当 拉 这 位 “ 几 内 亚 之 父 ” 一 把 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 2)
		{
			button_text[0] = " 承 担 几 内 亚 的 债 务（ 需 要 8 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 能 帮 助 这 样 一 个 好 斗 分 子";
		}
		if (a.data[56] > 1)
		{
			button_text[1] = " 火 上 浇 油 ， 推 翻 杜 尔 政 府";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 要 这 么 做 ？";
		}
		button_text[2] = " 几 内 亚 在 哪 ？ 我 得 换 一 张 大 点 的 世 界 地 图 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 几 内 亚 之 父 的 终 结";
		if (result_num == 0)
		{
			text = " 我 们 决 定 支 持 杜 尔 总 统 的 社 会 革 命 政 策 。 这 个 成 效 是 立 竿 见 影 的 ， 杜 尔 总 统 立 刻 宣 布 脱 离 苏 联 的 影 响 而 倒 向 我 们 。 并 着 手 构 建 自 己 的 社 会 主 义 社 会 。 得 益 于 我 们 为 几 内 亚 做 担 保 。 几 内 亚 大 胆 的 收 回 了 所 有 的 铝 矿 和 钻 石 矿 。 为 了 防 止 潜 在 的 反 革 命 政 变 。 杜 尔 总 统 宣 布 开 始 新 的 一 轮 “ 人 民 革 命 ” ， 着 手 组 建 工 人 卫 队 和 独 立 的 矿 工 工 会 以 保 护 自 己 的 权 力 相 信 在 不 远 的 未 来 ， 几 内 亚 会 脱 下 “ 极 不 发 达 国 家 ” 的 帽 子 。";
			a.data[8] -= 80;
			a.influencePRC += 20;
			GlobalScript.inst.gameState.allcountries[68].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[68].SubGosstroy = 10;
			GlobalScript.inst.gameState.allcountries[68].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[68].Torg = true;
		}
		if (result_num == 1)
		{
			a.data[9] -= 40;
			if (a.empires[0].relations >= 500)
			{
				text = "我 们 向 美 国 人 秘 密 传 递 了 这 一 条 消 息 。 在 中 情 局 的 里 挑 外 拨 下 ， 这 场 示 威 游 行 最 终 演 化 成 了 要 求 杜 尔 总 统 下 台 的 暴 力 抗 争 。 最 终 ， 总 统 卫 队 的 首 领 兰 萨 纳 · 孔 戴 上 校 成 立 了 国 家 军 事 复 兴 委 员 会 ， 并 积 极 向 美 国 靠 拢 。";
				GlobalScript.inst.gameState.allcountries[68].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[68].SubGosstroy = 7;
				GlobalScript.inst.gameState.allcountries[68].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[68].Vyshi = true;
				GlobalScript.inst.gameState.allcountries[68].Torg = true;
				a.empires[0].power += 20;
				a.empires[1].relations += 80;
			}
			else
			{
				text = "杜 尔 总 统 设 法 察 觉 了 一 场 推 翻 他 的 阴 谋 ， 在 苏 联 的 支 持 下 ， 几 内 亚 人 民 军 粉 碎 了 政 变 。 主 谋 被 丢 入 动 物 园 中 喂 狮 子 。 杜 尔 对 我 们 的 行 为 很 是 沮 丧 ， 宣 布 驱 逐 了 我 们 的 大 使 。 ";
				GlobalScript.inst.gameState.allcountries[68].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[68].SubGosstroy = 15;
				GlobalScript.inst.gameState.allcountries[68].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[68].prosov = true;
				a.empires[1].power += 20;
			}
		}
		if (result_num == 2)
		{
			text = " 在 内 外 的 极 大 压 力 下 ， 杜 尔 总 统 宣 布 放 弃 对 经 济 的 严 格 管 制 。 这 为 他 赢 得 了 美 国 的 支 持 。 西 方 国 家 宣 布 为 几 内 亚 提 供 一 笔 贷 款 。 几 内 亚 也 开 始 考 虑 一 条 苏 联 以 外 的 发 展 道 路 。";
			GlobalScript.inst.gameState.allcountries[68].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[68].SubGosstroy = 10;
			GlobalScript.inst.gameState.allcountries[68].LeaveAlliances();
		}
	}
}
