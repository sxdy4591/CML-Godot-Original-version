using EventsForDLC;
using UnityEngine;

public class Event580 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 哦 ， 我 们 亲 爱 的 祖 国";
		text = " 现 在 让 我 们 的 目 光 看 向 马 达 加 斯 加 岛 ， 自 拉 齐 拉 卡 在1975 年 军 队 推 举 上 位 并 在 年 底 公 投 中 胜 选 成 为 马 达 加 斯 加 民 主 共 和 国 总 统 之 后 ， 便 依 照 《 马 达 加 斯 加 社 会 主 义 革 命 宪 章 》 实 行 福 科 诺 洛 纳 社 会 主 义 （ 村 社 社 会 主 义 的 一 种 ） ， 将 大 量 工 厂 进 行 国 有 化 ， 进 行 土 地 改 革 ， 并 以 目 前 正 处 于 民 族 民 主 革 命 阶 段 为 由 缓 慢 推 广 合 作 社 ， 允 许 保 留 部 分 私 有 企 业 ； 扭 转 了 马 达 加 斯 加 共 和 国 时 期 亲 法 亲 西 方 的 外 交 并 开 始 向 中 国 ， 苏 联 等 社 会 主 义 国 家 靠 拢 ； 组 建 了 马 达 加 斯 加 革 命 先 锋 和 由 数 个 左 翼 政 党 组 成 的 全 国 保 卫 革 命 阵 线 。 但 由 于 资 金 的 缺 乏 和 生 活 消 费 品 的 短 缺 导 致 了1978 年 的 一 次 小 型 游 行 示 威 。 现 有 可 信 情 报 显 示 拉 齐 拉 卡 正 在 决 定 接 受 国 际 货 币 基 金 组 织 的 经 济 改 革 方 案 ， 这 也 就 意 味 着 马 达 加 斯 加 可 能 要 转 向 抛 弃 社 会 主 义 了 。 现 在 插 手 马 达 加 斯 加 的 事 务 对 我 们 来 说 是 绝 好 机 会 ， 我 们 是 否 要 进 行 干 预 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] < 2)
		{
			button_text[0] = " 帮 助 拉 齐 拉 卡 偿 还 债 务 并 提 出 自 己 的 小 要 求";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "我 们 对 他 们 的 要 求 太 过 激 进 了";
		}
		if (a.data[56] < 3 && (a.allcountries[1].isSEV || a.empires[1].relations >= 700))
		{
			button_text[1] = " 与 苏 联 一 起 帮 助 偿 还 债 务";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = "为 什 么 要 和 苏 联 人 勾 肩 搭 背";
		}
		if (a.data[6] <= 800 && a.allcountries[21].Torg)
		{
			button_text[2] = " 联 系 法 国 人 开 始 动 手";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 法 国 人 ？ 他 们 本 来 也 不 属 于 这 里";
		}
		button_text[3] = " 马 尔 加 什 ？ 马 达 加 斯 加 ？ 到 底 哪 里 是 哪 里 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 哦 ， 我 们 亲 爱 的 祖 国";
		if (result_num == 0)
		{
			text = " 在 我 们 大 量 的 经 济 援 助 下 ， 马 达 加 斯 加 迅 速 摆 脱 了 财 政 危 机 ， 拉 齐 拉 卡 也 宣 布 拒 绝 经 济 改 革 ， 继 续 保 持 国 有 化 政 策 以 及 加 速 发 展 合 作 社 ， 邀 请 中 国 顾 问 帮 助 建 设 ， 并 逐 步 开 始 推 行 温 和 的 宗 教 管 控 ， 我 们 串 联 了 全 国 保 卫 革 命 阵 线 内 的 亲 中 政 党 无 产 阶 级 掌 权 党 和 争 取 马 达 加 斯 加 独 立 全 国 运 动 以 及 前 马 达 加 斯 加 共 产 党 党 员 并 重 组 了 马 达 加 斯 加 共 产 党 ， 得 益 于 我 们 的 援 助 ， 新 组 建 的 马 达 加 斯 加 共 产 党 获 得 了 较 大 的 影 响 力 并 在 内 阁 中 获 得 了 更 多 的 职 位 。 在 国 际 事 务 上 马 达 加 斯 加 亦 变 得 更 亲 近 中 国 阵 营 。";
			a.data[8] -= 70;
			a.allcountries[133].Gosstroy = 1;
			a.allcountries[133].SubGosstroy = 1;
			a.allcountries[133].LeaveAlliances();
			a.allcountries[133].proprc = true;
			a.allcountries[133].Torg = true;
			a.influencePRC += 20;
			a.data[6] += 20;
		}
		if (result_num == 1)
		{
			text = " 在 我 们 和 苏 联 的 共 同 援 助 下 ， 马 达 加 斯 加 迅 速 摆 脱 了 财 政 危 机 ， 拉 齐 拉 卡 也 宣 布 拒 绝 经 济 改 革 ， 决 定 以 苏 式 社 会 主 义 为 建 设 样 板 将 工 业 进 行 全 面 国 有 化 并 邀 请 苏 联 顾 问 帮 助 建 设 。 全 国 保 卫 革 命 阵 线 内 的 亲 苏 左 翼 政 党 独 立 大 会 党 因 此 得 以 获 得 更 大 的 影 响 力 并 参 与 组 阁 。 马 达 加 斯 加 在 国 际 事 务 中 也 紧 跟 苏 联 老 大 哥 的 步 伐 。";
			a.allcountries[133].Gosstroy = 1;
			a.allcountries[133].SubGosstroy = 1;
			a.allcountries[133].LeaveAlliances();
			a.allcountries[133].prosov = true;
			a.allcountries[133].Torg = true;
			a.allcountries[133].isSEV = true;
			a.data[8] -= 30;
			a.data[6] += 10;
			a.empires[1].relations += 150;
		}
		if (result_num == 2)
		{
			text = " 在 我 们 的 大 使 与 法 国 的 会 谈 中 ， 暗 示 了 我 们 对 拉 齐 拉 卡 的 经 济 改 革 的 不 满 ， 并 支 持 法 国 人 出 手 稳 定 马 达 加 斯 加 。||在 拉 齐 拉 卡 宣 布 经 济 改 革 之 前 ， 法 国 宣 布 封 锁 马 达 加 斯 加 。 在 法 国 特 工 和 马 达 加 斯 加 社 民 党 等 反 对 派 的 鼓 动 下 ， 塔 那 那 利 佛 市 开 始 出 现 要 求 增 加 消 费 品 和 经 济 改 革 ， 要 求 拉 齐 拉 卡 下 台 开 放 选 举 的 游 行 。 总 统 府 前 ， 总 统 护 卫 队 不 幸 擦 枪 走 火 ， 现 场 打 死 数 十 名 游 行 群 众 。 消 息 很 快 便 传 遍 了 全 国 ， 全 国 爆 发 了 一 次 反 对 拉 齐 拉 卡 的 游 行 示 威 ， 军 队 内 部 也 军 心 不 稳 ， 拉 齐 拉 卡 被 迫 宣 布 下 台 并 进 行 选 举 。 最 后 马 达 加 斯 加 社 民 党 总 统 候 选 人 ， 前 马 达 加 斯 加 共 和 国 副 总 统 拉 贝 马 南 贾 拉 获 选 。 新 政 府 更 名 为 马 达 加 斯 加 共 和 国 ， 并 取 缔 马 达 加 斯 加 革 命 先 锋 等 数 个 左 翼 党 派 ， 开 放 选 举 并 进 行 亲 法 亲 西 方 外 交 ， 放 开 外 资 和 私 有 限 制 。";
			a.allcountries[133].Gosstroy = 3;
			a.allcountries[133].SubGosstroy = 4;
			a.allcountries[133].LeaveAlliances();
			a.allcountries[133].puppetOf = 21;
			a.allcountries[133].Torg = true;
			a.data[9] -= 30;
			a.data[22] -= 100;
			a.empires[0].relations -= 300;
		}
		if (result_num == 3)
		{
			text = " 拉 齐 拉 卡 宣 布 了 经 济 改 革 计 划 ， 在 之 后 数 年 ， 允 许 了 法 资 等 外 资 进 入 国 内 ， 福 科 诺 洛 纳 社 会 主 义 逐 渐 破 产 ， 外 交 也 逐 渐 向 中 立 外 交 转 变 。 马 达 加 斯 加 民 主 共 和 国 的 未 来 究 竟 是 什 么 样 子 ， 只 有 后 人 才 知 道 … …";
			a.allcountries[133].Gosstroy = 2;
			a.allcountries[133].SubGosstroy = 15;
		}
	}
}
