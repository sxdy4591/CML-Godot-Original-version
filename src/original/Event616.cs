using EventsForDLC;
using UnityEngine;

public class Event616 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "在 盖 勒 瓦 尔 的 召 唤 下";
		text = "自 在 冈 比 亚 战 争 中 败 于 几 内 亚 - 几 内 亚 比 绍 联 军 之 后 ， 塞 内 加 尔 就 处 于 极 其 混 乱 的 状 态 。 惨 烈 的 战 争 不 仅 打 破 了 塞 内 加 尔 社 会 党 的 声 望 ， 也 撕 碎 了 该 国 的 最 后 一 点 遮 羞 布 。 罢 工 、 学 生 运 动 、 游 行 示 威 层 出 不 穷 。 为 此 ， 迪 乌 夫 总 统 被 迫 一 方 面 镇 压 罢 工 与 游 行 ， 一 方 面 加 快 了 政 治 自 由 化 改 革 ， 但 仍 然 于 事 无 补 。 在 民 主 反 对 派 于 达 喀 尔 举 行 的 一 次 群 众 集 会 中 ， 几 百 名 群 众 涌 上 街 头 ， 举 行 示 威 游 行 ， 抗 议 政 府 提 高 物 价 。 政 府 立 即 出 动 军 警 进 行 干 预 ， 阻 止 群 众 上 街 游 行 。 愤 怒 的 示 威 群 众 手 持 棍 棒 、 锄 头 甚 至 匕 首 与 警 察 搏 斗 ， 几 名 警 察 与 部 分 示 威 群 众 当 场 死 亡 ， 数 十 人 受 伤 。 当 晚 政 府 便 谴 责 反 对 党 煽 动 暴 力 ， 逮 捕 了 所 有 涉 嫌 参 与 和 操 纵 这 次 事 件 的 人 ， 这 迅 速 激 化 了 矛 盾 。 很 快 ， 一 场 大 罢 工 便 从 达 喀 尔 席 卷 全 国 。 在 武 力 镇 压 无 果 后 ， 迪 乌 夫 被 迫 辞 职 ， 宣 布 将 重 新 举 行 选 举 。 然 而 ， 该 国 的 混 乱 局 面 导 致 选 举 无 法 正 常 进 行 。 依 靠 几 内 亚 、 几 内 亚 比 绍 与 冈 比 亚 所 提 供 的 军 事 训 练 与 援 助 ， 塞 共 / 马 列 已 经 秘 密 组 织 起 了 一 支 武 装 部 队 。 现 在 ， 是 时 候 一 鼓 作 气 终 结 塞 内 加 尔 的 “ 民 主 社 会 主 义 ” 实 验 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 站 起 身 来 去 革 命 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "在 盖 勒 瓦 尔 的 召 唤 下";
		int num = 0;
		if (a.IsSocialism(yes: true, 59))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 113))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 58))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 68))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 114))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 107))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 64))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 63))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 108))
		{
			num++;
		}
		if (a.IsSocialism(yes: true, 61))
		{
			num++;
		}
		if (result_num == 0)
		{
			if (num >= 5 && a.IsSocialism(yes: true, 68) && a.IsSocialism(yes: true, 114) && a.IsSocialism(yes: true, 113))
			{
				text = "在 几 内 亚 、 几 内 亚 比 绍 、 冈 比 亚 等 国 的 支 持 下 ， 塞 内 加 尔 共 产 党 / 马 列 将 自 己 所 掌 握 的 武 装 力 量 与 受 革 命 思 想 影 响 的 军 人 改 编 为 由 该 党 中 央 统 一 指 挥 的 塞 内 加 尔 民 族 解 放 军 ， 西 非 的 社 会 主 义 国 家 将 为 他 们 提 供 他 们 所 需 要 的 一 切 支 持 。||随 着 塞 内 加 尔 的 局 势 日 益 恶 化 ， 陆 军 总 参 谋 长 约 瑟 夫 · 路 易 斯 · 塔 瓦 雷 斯 · 德 苏 萨 将 军 发 动 了 一 场 政 变 ， 轻 而 易 举 地 占 领 了 达 喀 尔 的 政 府 大 楼 ， 在 广 播 中 宣 布 成 立 革 命 军 事 委 员 会 ， 无 限 期 暂 停 议 会 选 举 与 宪 法 ， 接 管 政 府 。 而 这 遭 到 了 全 国 上 下 的 激 烈 反 对 ， 很 快 ， 该 国 的 混 乱 局 势 便 演 化 为 一 场 内 战 。 而 几 内 亚 、 几 内 亚 比 绍 与 冈 比 亚 的 志 愿 军 则 直 接 介 入 了 内 战 ， 倚 仗 于 他 们 的 支 持 ， 塞 共 / 马 列 得 以 四 两 拨 千 斤 ， 彻 底 击 溃 了 政 府 军 ， 最 终 接 管 了 全 国 。 一 个 彻 底 脱 离 殖 民 主 义 阴 魂 的 新 塞 内 加 尔 诞 生 了 。";
				a.allcountries[112].Gosstroy = 1;
				a.allcountries[112].SubGosstroy = 17;
				a.allcountries[112].LeaveAlliances();
				a.allcountries[112].Torg = true;
				a.allcountries[112].proprc = true;
				a.empires[1].relations -= 150;
				a.empires[0].relations -= 150;
			}
			else
			{
				text = "在 几 内 亚 、 几 内 亚 比 绍 、 冈 比 亚 等 国 的 支 持 下 ， 塞 内 加 尔 共 产 党 / 马 列 将 自 己 所 掌 握 的 武 装 力 量 与 的 军 人 改 编 为 由 该 党 中 央 统 一 指 挥 的 塞 内 加 尔 民 族 解 放 军 ， 而 西 非 的 社 会 主 义 国 家 将 为 他 们 提 供 他 们 所 需 要 的 一 切 支 持 。||随 着 塞 内 加 尔 的 局 势 日 益 恶 化 ， 陆 军 总 参 谋 长 约 瑟 夫 · 路 易 斯 · 塔 瓦 雷 斯 · 德 苏 萨 将 军 发 动 了 一 场 政 变 ， 轻 而 易 举 地 占 领 了 达 喀 尔 的 政 府 大 楼 ， 在 广 播 中 宣 布 成 立 革 命 军 事 委 员 会 ， 无 限 期 暂 停 议 会 选 举 与 宪 法 ， 接 管 政 府 。 而 这 遭 到 了 全 国 上 下 的 激 烈 反 对 ， 很 快 ， 该 国 的 混 乱 局 势 便 演 化 为 一 场 内 战 。 而 几 内 亚 、 几 内 亚 比 绍 与 冈 比 亚 的 志 愿 军 则 直 接 介 入 了 内 战 。 最 终 ， 尽 管 在 面 对 卡 萨 芒 斯 的 分 离 主 义 叛 军 遭 遇 一 系 列 惨 败 ， 军 政 府 还 是 成 功 击 退 了 所 有 外 国 干 涉 军 。||<color=red>在 大 天 使 的 剑 影 下 ， 塞 内 加 尔 河 、 冈 比 亚 河 、 卡 萨 芒 斯 河 全 被 染 红 了 … …</color>";
				a.allcountries[112].Gosstroy = 0;
				a.allcountries[112].SubGosstroy = 7;
			}
		}
	}
}
