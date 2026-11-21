using EndingsDLCDraft;
using UnityEngine;

public class Ending19 : EndingsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEnding(ref string name, ref string text)
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		if (a.event_done[420])
		{
			if (a.allcountries[87].Gosstroy == 1 && a.allcountries[87].prosov)
			{
				name = GlobalScript.inst.new_events_text[1496];
				text = " 康 乃 “ 新 ” 革 命||瓦 斯 科 · 贡 萨 尔 维 斯 和 阿 尔 瓦 罗 · 库 尼 亚 尔 共 同 领 导 的 共 产 党 政 府 吸 取 了 首 次 康 乃 馨 革 命 的 教 训 ， 并 采 取 了 更 果 断 的 行 动 。 这 次 ， 他 们 不 再 坚 持 “ 向 社 会 主 义 和 平 过 渡 ” ： 国 家 不 再 和 平 赎 买 企 业 5 1 % 的 股 份 ， 而 是 直 接 进 行 “ 无 产 阶 级 专 政 ” ， 将 大 型 企 业 国 有 化 ， 小 型 企 业 合 作 社 化 。\n 在 全 国 各 地 的 工 厂 、 建 筑 工 地 、 物 流 企 业 、 教 育 机 构 、 办 公 室 与 乡 村 内 ， 管 理 委 员 会 如 雨 后 春 笋 般 涌 现 ， 并 建 立 了 一 系 列 社 区 。 国 家 中 央 经 济 计 划 委 员 会 被 成 立 ， 它 将 负 责 计 划 统 筹 国 家 经 济 。 工 人 被 允 许 组 织 工 人 集 会 以 支 持 革 命 事 业 。 企 业 家 与 商 人 对 该 国 的 社 会 主 义 十 分 恐 惧 ， 但 是 他 们 还 没 来 得 及 逃 跑 就 被 工 人 民 兵 与 人 民 军 联 合 成 立 的 “ 锄 奸 队 ” 给 抓 获 。\n 在 该 国 农 村 ， 土 地 改 革 也 以 新 形 式 如 火 如 荼 地 进 行 ： 并 没 有 对 1 9 7 4 - 1 9 7 5 年 的 经 验 按 图 索 骥 。 庄 园 主 与 地 主 的 资 产 均 被 收 归 合 作 社 ， 而 后 者 在 建 制 上 效 法 了 苏 联 的 劳 动 集 体 （ T O Z S ） 。\n 新 革 命 的 其 中 一 位 领 导 人 重 申 ： “ 传 统 的 资 产 阶 级 民 主 建 制 不 足 以 满 足 人 民 群 众 所 需 ” 。 该 国 就 此 开 始 了 政 治 改 革 ， 政 党 制 度 横 遭 打 击 ， 工 会 组 织 被 统 一 ， 并 由 葡 共 领 导 。 社 会 政 治 运 动 与 工 农 协 会 的 作 用 得 以 增 强 ， 葡 萄 牙 也 开 始 逐 步 引 入 直 接 民 主 的 要 素 。 当 然 ， 正 积 极 建 设 社 会 主 义 并 与 苏 联 展 开 深 度 合 作 的 葡 萄 牙 共 产 党 政 权 ， 将 不 可 避 免 的 引 来 西 方 国 家 的 仇 视 。 ";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(152);
				}
			}
			else if (a.allcountries[87].Gosstroy == 1)
			{
				name = GlobalScript.inst.new_events_text[1496];
				text = " 康 乃 “ 新 ” 革 命||萨 赖 瓦 · 德 · 卡 瓦 略 和 弗 朗 西 斯 科 · 马 丁 斯 共 同 领 导 的 革 命 共 产 党 政 府 吸 取 了 首 次 康 乃 馨 革 命 的 教 训 ， 并 采 取 了 更 果 断 的 行 动 。 这 次 ， 他 们 不 再 坚 持 “ 向 社 会 主 义 和 平 过 渡 ” ： 国 家 不 再 和 平 赎 买 企 业 5 1 % 的 股 份 ， 而 是 直 接 发 起 工 人 进 行 阶 级 斗 争 ， 成 功 将 大 型 企 业 国 有 化 ， 小 型 企 业 合 作 社 化 。\n 在 全 国 各 地 的 工 厂 、 建 筑 工 地 、 物 流 企 业 、 教 育 机 构 、 办 公 室 与 乡 村 内 ， “ 三 结 合 ” 的 管 理 委 员 会 如 雨 后 春 笋 般 涌 现 ， 并 围 绕 他 们 建 立 了 一 系 列 社 区 。 国 家 中 央 经 济 计 划 委 员 会 被 成 立 ， 它 将 负 责 计 划 统 筹 国 家 经 济 。 工 人 被 允 许 组 织 工 人 集 会 ， 充 分 发 挥 “ 四 大 自 由 ” ， 以 支 持 无 产 阶 级 革 命 事 业 。 企 业 家 与 商 人 对 该 国 的 社 会 主 义 十 分 恐 惧 ， 但 是 他 们 还 没 来 得 及 逃 跑 就 被 工 人 、 激 进 学 生 和 激 进 左 翼 军 人 联 合 成 立 的 “ 红 卫 兵 ” 给 抓 获 。\n 在 该 国 农 村 ， 土 地 改 革 也 以 新 形 式 如 火 如 荼 地 进 行 ： 并 没 有 对 1 9 7 4 - 1 9 7 5 年 的 经 验 按 图 索 骥 。 庄 园 主 与 地 主 的 资 产 均 被 收 归 合 作 社 ， 而 后 者 在 建 制 上 效 法 了 中 国 的 人 民 公 社 。\n 新 革 命 的 其 中 一 位 领 导 人 重 申 ： “ 资 产 阶 级 民 主 代 议 制 不 能 满 足 人 民 群 众 建 设 社 会 主 义 的 需 要 ， 必 须 打 碎 资 产 阶 级 国 家 的 上 层 建 筑 。 ” 该 国 就 此 开 始 了 政 治 改 革 ， 资 本 主 义 政 党 制 度 横 遭 打 击 ， 工 会 组 织 被 统 一 ， 并 由 葡 革 共 领 导 。 社 会 政 治 运 动 与 巴 黎 公 社 原 则 的 作 用 得 以 增 强 ， 葡 萄 牙 也 开 始 逐 步 引 入 无 产 阶 级 民 主 制 。 当 然 ， 正 积 极 建 设 社 会 主 义 的 葡 萄 牙 革 命 共 产 党 政 权 ， 将 不 可 避 免 的 引 来 西 方 国 家 的 仇 视 。 ";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(152);
				}
			}
			else
			{
				name = GlobalScript.inst.new_events_text[1498];
				text = string.Format(GlobalScript.inst.new_events_text[1499], "\n", GlobalScript.inst.new_events_text[1499]);
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(153);
				}
			}
		}
		else if (a.allcountries[87].SubGosstroy == 3)
		{
			name = GlobalScript.inst.new_events_text[1496];
			text = " 回 归 康 乃 馨 革 命 的 初 心 ！||由 社 会 党 和 共 产 党 领 导 的 联 合 政 府 回 到 了 康 乃 馨 革 命 时 代 对 社 会 主 义 的 呼 吁 ， 开 始 重 启 被 逆 转 的 社 会 主 义 改 革 。 国 家 继 续 和 平 赎 买 企 业 5 1 % 的 股 份 ， 对 关 键 行 业 、 交 通 与 基 础 设 施 实 行 国 有 化 ， 此 外 ， 银 行 、 电 力 工 业 、 石 油 、 冶 金 与 铁 路 均 成 为 了 国 营 部 门 。 政 府 引 入 了 干 预 性 产 业 政 策 ， 并 加 强 工 人 的 经 济 权 力 ， 推 广 工 人 持 股 制 度 ， 进 行 经 济 民 主 化 。 税 收 政 策 也 得 以 改 订 ， 葡 萄 牙 开 始 实 行 累 进 税 制 ， 富 人 被 征 收 更 高 的 税 ， 以 建 立 福 利 国 家 。 管 理 委 员 会 如 雨 后 春 笋 般 涌 现 ， 旨 在 确 保 工 人 与 农 民 对 雇 佣 与 解 雇 劳 动 者 的 主 导 权 ， 新 成 立 的 委 员 会 对 企 业 家 与 商 人 具 有 更 大 的 约 束 权 ， 这 也 导 致 资 本 的 外 逃 问 题 的 发 生 。 在 该 国 农 村 ， 也 正 在 开 展 温 和 化 的 土 地 改 革 ， 农 民 被 鼓 励 以 自 愿 原 则 组 织 合 作 社 。 同 时 左 翼 联 盟 政 府 也 进 行 了 一 定 政 治 改 革 ， 以 加 强 政 治 的 民 主 ， 新 的 制 度 更 加 分 权 化 ， 强 调 地 方 与 中 央 的 协 作 。 右 翼 对 这 一 “ 共 产 ” 指 数 过 高 的 政 府 很 不 满 意 ， 他 们 组 成 了 新 的 民 主 联 盟 ， 团 结 在 因 社 会 主 义 改 革 而 利 益 受 损 的 保 守 派 群 体 周 围 ， 准 备 发 起 “ 反 攻 ” 。";
		}
		else
		{
			int num = 0;
			if (a.allcountries[87].isEU && a.allcountries[87].isNATO)
			{
				num = 1502;
			}
			else if (a.allcountries[87].isEU)
			{
				num = 1503;
			}
			else if (a.allcountries[87].isNATO)
			{
				num = 1504;
			}
			name = GlobalScript.inst.new_events_text[1500];
			text = string.Format(GlobalScript.inst.new_events_text[1501], "\n", (num > 0) ? GlobalScript.inst.new_events_text[num] : null);
		}
	}
}
