using EventsForDLC;
using UnityEngine;

public class Event551 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 过 河 拆 桥 ？";
		text = " 自 中 国 与 蒙 古 实 现 合 并 并 再 度 结 成 一 个 整 体 后 ， 中 蒙 关 系 事 实 上 便 被 置 于 先 前 签 署 的 《 中 蒙 联 合 条 约 》 框 架 下 ： 中 国 以 巨 额 投 资 、 文 化 保 护 和 确 保 蒙 古 地 方 建 立 民 族 权 利 机 构 为 基 础 ， 交 换 了 蒙 古 的 效 忠 、 领 土 与 国 家 主 权 。 内 外 蒙 古 也 得 以 实 现 彻 底 整 合 ： 蒙 古 人 民 共 和 国 的 党 政 系 统 也 被 合 并 进 中 国 共 产 党 的 蒙 古 支 部 内 。 因 此 ， 同 其 他 已 实 现 自 我 管 理 的 民 族 加 盟 政 权 不 同 ， 蒙 古 与 中 国 的 关 系 并 非 遵 循 中 国 现 行 的 区 域 管 理 法 案 ， 而 是 后 者 与 外 交 草 案 的 综 合 。 这 便 意 味 着 我 们 绝 不 可 能 同 对 待 其 他 地 区 那 般 ， 能 轻 易 地 回 收 与 限 制 蒙 古 地 方 机 构 的 职 权 。 在 我 国 正 筹 备 地 方 行 政 制 度 改 革 ， 在 全 国 范 围 实 行 民 族 区 域 自 治 制 度 的 背 景 下 。 蒙 古 问 题 必 须 单 独 列 出 ， 特 别 处 理 。 这 事 实 上 也 对 应 我 们 对 待 《 中 蒙 联 合 条 约 》 与 自 身 外 交 声 誉 的 态 度 ： 最 简 单 的 办 法 当 然 是 要 么 放 弃 改 革 ， 继 续 实 行 分 权 联 邦 制 度 ； 要 么 则 两 方 均 批 准 废 除 条 约 内 所 有 条 款 ， 让 中 国 与 蒙 古 恢 复 签 约 前 的 状 态 — — 当 然 ， 考 虑 到 先 前 在 当 地 安 置 的 投 资 与 暗 线 ， 蒙 古 仍 将 无 法 脱 离 中 国 的 影 响 ； 次 一 等 的 则 是 以 “ 一 国 两 制 ” 构 想 为 原 型 ， 在 蒙 古 地 方 实 行 联 邦 制 ， 对 国 内 其 他 地 区 恢 复 民 族 区 域 自 治 制 度 ： 当 然 ， 这 会 引 起 国 内 尤 其 是 民 族 地 区 的 空 前 不 满 ； 最 后 ， 我 们 也 可 以 考 虑 切 香 肠 战 术 、 以 渗 透 与 政 治 限 制 手 段 遏 制 分 离 派 ， 让 国 安 局 特 工 用 枪 杆 子 告 诉 蒙 古 官 僚 们 该 如 何 选 择 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] == 4)
		{
			button_text[0] = " 和 平 分 手 ， 和 平 结 束 ； 再 见 蒙 古 ， 再 也 不 见";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 怎 么 能 让 煮 熟 的 鸭 子 飞 了 ？ ！";
		}
		if (a.data[56] > 1)
		{
			button_text[1] = " 就 处 理 新 领 土 问 题 上 ， “ 一 国 两 制 ” 总 是 有 其 优 越 性";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 蒙 古 特 别 行 政 区 ？ 这 就 是 给 苏 联 人 渗 透 开 方 便 之 门 ！";
		}
		if (a.data[56] < 4)
		{
			button_text[2] = " 我 们 有 办 法 让 蒙 古 人 体 面 . . . . .";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 绝 不 能 使 用 包 办 代 替 的 做 法 ！ ";
		}
		button_text[3] = " 我 们 得 承 认 现 实 ， 得 为 未 来 着 想 ， 我 们 已 回 不 到 那 个 年 代 . . . . . . ";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 过 河 拆 桥 ？";
		if (result_num == 0)
		{
			text = " 今 天 ， 中 国 与 蒙 古 领 导 人 共 同 终 止 了 所 谓 《 中 蒙 联 合 条 约 》 ， 从 而 结 束 了 短 暂 的 中 蒙 联 合 时 期 ： 此 后 ， 蒙 古 将 以 独 立 主 权 国 家 的 形 式 与 中 国 建 立 外 交 关 系 与 开 展 合 作 — — 可 考 虑 到 蒙 古 本 身 的 缓 冲 区 性 质 ， 这 种 合 作 的 规 模 注 定 有 限 。 党 与 人 民 对 此 感 到 疑 惑 与 愤 怒 ， 毕 竟 ， 无 数 为 合 并 计 划 准 备 的 人 力 物 力 都 白 花 了 ， 竹 篮 打 水 一 场 空 。 有 反 对 派 已 将 现 任 领 导 层 的 行 径 同 宋 真 宗 与 宋 高 宗 相 比 — — 前 者 曾 在 对 敌 优 势 时 签 署 了 辱 国 不 平 等 条 约 ， 后 者 则 更 是 在 割 地 赔 款 后 选 择 对 北 方 政 权 称 臣 . . . . . . 苏 联 则 为 自 己 对 华 扩 张 窗 口 的 再 度 开 放 感 到 满 意 。";
			a.data[130] = 0;
			GlobalScript.inst.gameState.allcountries[1].ILoveSuckCocks();
			GlobalScript.inst.gameState.allcountries[9].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[9].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[9].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[9].proprc = true;
			GlobalScript.inst.gameState.data[34] -= 20;
			GlobalScript.inst.gameState.allcountries[9].JoinAllOurAlliances(yes: true);
			a.data[8] += 50;
			a.data[12] += 10;
			a.data[13] += 10;
			a.data[68] += 10;
			a.data[1] -= 150;
			a.data[3] -= 100;
			a.data[4] += 150;
			a.influencePRC -= 20;
			a.empires[1].relations += 500;
			a.empires[1].power += 100;
			a.data[6] -= 100;
		}
		if (result_num == 1)
		{
			text = " 中 国 领 导 人 称 ， 《 中 蒙 联 合 条 约 》 的 法 律 效 力 高 于 新 推 行 的 《 区 域 自 治 法 》 ， 并 基 于 前 者 撰 写 了 独 立 并 行 的 法 律 文 本 《 蒙 古 特 别 行 政 区 基 本 法 》 。 事 实 上 在 国 内 推 行 了 混 合 式 的 区 域 管 理 制 度 ： 即 对 中 国 本 部 地 区 实 行 单 一 制 ， 对 蒙 古 区 域 则 允 许 其 自 建 民 族 联 邦 ， 实 行 “ 更 高 级 民 族 自 治 形 式 ” 。 当 然 ， 这 不 过 是 某 种 拆 东 墙 补 西 墙 ： 蒙 古 人 确 实 对 我 们 的 慷 慨 表 示 满 意 ， 并 决 心 以 千 万 倍 的 努 力 回 报 我 们 的 工 作 。 但 是 仅 在 人 口 规 模 有 限 的 蒙 古 实 施 特 殊 政 策 必 然 将 导 致 其 他 民 族 区 域 ， 乃 至 中 国 内 地 本 身 的 反 弹 与 不 满 。 有 人 甚 至 已 经 发 明 了 “ 七 万 万 小 于 两 千 万 ” 的 口 号 ， 愤 怒 地 要 求 我 们 要 么 取 消 对 蒙 古 的 单 独 优 待 政 策 ， 要 么 则 将 蒙 古 模 式 在 全 国 推 广 ， 实 现 全 国 区 域 间 的 完 全 平 等 。";
			a.data[8] -= 80;
			a.data[12] -= 50;
			a.data[13] -= 50;
			a.data[68] -= 50;
			a.data[26] += 20;
			a.data[1] -= 100;
			a.data[3] -= 150;
			a.data[4] += 250;
			a.influencePRC -= 5;
			a.empires[1].relations += 500;
			a.data[6] -= 100;
		}
		if (result_num == 2)
		{
			text = " 人 力 资 源 部 与 国 家 安 全 局 开 始 履 行 其 既 有 职 责 — — 收 买 能 收 买 的 ， 分 化 能 分 化 的 ， 排 挤 能 排 挤 的 。 通 过 灵 活 运 用 经 济 与 信 息 手 段 ， 乃 至 安 插 来 自 内 蒙 古 地 区 的 党 员 。 我 们 的 情 报 机 构 成 功 分 化 了 原 蒙 古 党 政 体 系 ， 将 主 张 同 中 国 实 现 深 度 一 体 化 合 作 关 系 的 亲 华 派 转 为 了 蒙 古 人 民 革 命 党 主 流 ， 并 通 过 一 系 列 经 济 扶 持 政 策 稳 定 了 民 间 民 心 。 改 组 后 的 蒙 古 领 导 层 没 多 久 便 自 愿 要 求 修 订 《 中 蒙 联 合 条 约 》 ， 并 事 实 上 承 认 了 民 族 区 域 自 治 政 策 。 随 后 举 行 的 全 蒙 公 投 则 以 9 7 . 2 % 的 高 票 批 准 了 修 改 — — 我 们 在 内 蒙 古 的 长 期 经 营 发 挥 了 大 功 ， 他 们 依 靠 自 身 的 体 量 与 国 家 支 持 跨 界 放 牧 的 政 策 进 入 外 蒙 古 ， 并 成 为 了 我 党 线 人 。 随 后 ， 我 国 正 式 启 动 了 在 外 蒙 古 引 入 民 族 区 域 自 治 制 度 的 历 史 进 程 。 当 然 ， 如 此 剧 烈 的 变 化 必 然 多 少 会 导 致 人 心 浮 动 。 超 级 大 国 则 已 开 始 就 表 决 环 节 流 程 的 合 理 性 问 题 添 油 加 醋 ， 竭 力 否 认 《 中 蒙 新 联 合 条 约 》 内 的 合 法 性 ： 其 试 图 将 蒙 古 从 我 国 境 内 萃 取 出 的 贼 心 不 死 . . . . . . ";
			a.data[8] -= 100;
			a.data[9] -= 80;
			a.data[26] += 20;
			a.data[1] += 100;
			a.data[3] -= 20;
			a.data[4] += 100;
			a.influencePRC -= 5;
			a.empires[0].relations -= 100;
			a.empires[1].relations -= 200;
			a.data[6] += 50;
		}
		if (result_num == 3)
		{
			text = " 最 终 ， 有 引 入 我 国 民 族 区 域 自 治 制 度 与 地 方 管 理 制 度 的 提 案 被 全 国 人 大 所 否 决 。 相 关 的 修 宪 计 划 也 胎 死 腹 中 — — 人 民 对 我 们 一 贯 坚 持 民 族 自 决 原 则 的 革 新 态 度 表 示 满 意 。 中 国 仍 走 在 巩 固 与 深 化 分 权 体 系 的 路 上 ， 走 着 瞧 罢 . . . . . .";
			a.data[18] = 21;
			a.data[1] += 20;
			a.data[3] += 20;
			a.data[4] += 100;
			a.influencePRC -= 5;
			a.empires[0].relations += 100;
			a.empires[1].relations += 100;
			a.data[6] -= 20;
		}
	}
}
