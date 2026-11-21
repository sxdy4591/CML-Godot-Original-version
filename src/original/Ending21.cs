using EndingsDLCDraft;
using UnityEngine;

public class Ending21 : EndingsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEnding(ref string name, ref string text)
	{
		GameObject.Find("Ach(Clone)");
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		int num = 0;
		if (a.allcountries[8].puppetOf == 84)
		{
			flag2 = true;
		}
		if (a.allcountries[35].puppetOf == 84)
		{
			flag3 = true;
		}
		if (a.allcountries[14].puppetOf == 84)
		{
			flag = true;
		}
		if (flag && flag3 && flag2)
		{
			num = 1542;
		}
		else if (flag && flag3)
		{
			num = 1543;
		}
		else if (flag2 && flag3)
		{
			num = 1544;
		}
		else if (flag && flag2)
		{
			num = 1545;
		}
		else if (flag2)
		{
			num = 1546;
		}
		else if (flag)
		{
			num = 1547;
		}
		else if (flag3)
		{
			num = 1548;
		}
		name = GlobalScript.inst.new_events_text[1540];
		int num2;
		if (a.allcountries[84].parts[1])
		{
			num2 = 1549;
		}
		else if (a.allcountries[84].parts[0])
		{
			num2 = 1550;
		}
		else if (a.allcountries[14].parts[1])
		{
			num2 = 1551;
		}
		else if (a.allcountries[14].parts[2])
		{
			num2 = 1552;
		}
		else if (a.allcountries[14].parts[3])
		{
			if (a.allcountries[84].Gosstroy != 0)
			{
				if (a.allcountries[95].Gosstroy == 1)
				{
					GlobalScript.inst.new_events_text[1553] = " 在 因 为 共 同 的 敌 人 走 到 一 起 之 后 ， 叙 利 亚 和 伊 拉 克 革 命 者 的 矛 盾 开 始 凸 显 。 伊 拉 克 认 为 叙 利 亚 同 志 们 陷 入 了 只 想 打 游 击 ， 不 建 设 根 据 地 的 流 寇 主 义 和 狭 隘 民 族 主 义 ， 而 伊 拉 克 代 表 在 “ 两 河 的 社 会 主 义 者 代 表 大 会 ” 上 被 攻 击 为 阿 拉 伯 资 产 阶 级 的 代 表 人 ， 是 右 倾 投 降 主 义 。 一 开 始 同 志 间 的 交 流 辩 论 ， 在 阿 齐 兹 书 记 和 奥 贾 兰 同 志 双 双 遇 刺 身 亡 后 ， 路 线 的 斗 争 迅 速 升 级 为 你 死 我 活 的 战 斗 。 原 先 的 两 河 社 会 主 义 党 正 式 分 裂 为 了 幼 发 拉 底 派 和 底 格 里 斯 派 ， 双 方 的 民 兵 把 解 放 战 争 中 学 到 的 知 识 用 在 自 己 的 战 友 身 上 。 漫 长 的 内 耗 进 一 步 削 弱 了 本 就 不 堪 的 革 命 者 们 。 最 终 ， 短 命 的 两 个 政 权 宣 布 解 散 所 谓 “ 民 主 联 邦 ” 。 兄 弟 阋 墙 ， 何 其 悲 哀 ！";
				}
				else
				{
					GlobalScript.inst.new_events_text[1553] = " 在 因 为 共 同 的 敌 人 走 到 一 起 之 后 ， 来 自 叙 利 亚 的 自 由 派 和 伊 拉 克 革 命 者 的 矛 盾 最 终 还 是 没 有 消 解 ： 爱 国 同 盟 内 部 的 派 系 斗 争 日 渐 纷 繁 复 杂 ， 从 “ 是 谁 的 同 盟 ” 到 “ 姓 资 姓 社 ” 诸 如 此 类 在 当 下 压 根 没 法 解 决 的 无 意 义 问 题 充 满 了 会 议 桌 。 最 终 ， 激 进 左 派 再 也 无 法 忍 受 软 弱 无 能 的 团 结 派 ， 他 们 重 上 辛 贾 尔 山 ， 高 举 法 赫 德 同 志 的 红 旗 ， 公 开 反 对 日 渐 明 显 的 修 正 主 义 团 体 。 而 叙 利 亚 方 面 也 不 再 愿 意 与 一 群 “ 共 匪 ” 为 伍 ， 他 们 甚 至 在 伊 拉 克 的 清 剿 活 动 中 为 其 带 路 。 双 方 的 不 信 任 达 到 了 极 点 ， 这 个 科 学 怪 人 般 的 “ 民 主 联 邦 ” 在 多 方 的 怀 疑 中 日 益 分 崩 离 析 。 终 于 ， 随 着 阿 齐 兹 的 死 ， 一 场 争 夺 领 导 权 的 内 战 彻 底 爆 发 了 。 生 于 正 义 ， 死 于 耻 辱 ， 嗟 乎 ！";
				}
			}
			num2 = 1553;
		}
		else if (a.allcountries[8].parts[0])
		{
			num2 = 1554;
		}
		else if (a.allcountries[14].parts[0])
		{
			num2 = 1555;
			GlobalScript.inst.new_events_text[1555] = " 伊 拉 克 的 库 尔 德 斯 坦 迎 来 了 意 料 之 外 的 主 人 ， 爱 国 同 盟 凭 借 和 库 尔 德 人 与 亚 述 少 数 族 裔 的 联 盟 维 持 了 在 伊 拉 克 库 尔 德 地 区 的 解 放 区 。 但 整 场 战 争 对 爱 国 同 盟 的 打 击 是 巨 大 的 ， 不 仅 损 失 了 大 部 分 武 装 力 量 和 情 报 网 。 和 南 部 的 复 兴 党 政 权 交 恶 导 致 了 经 济 形 势 的 恶 化 ， 只 有 在 伊 朗 人 和 我 们 的 帮 助 下 ， 这 个 脆 弱 的 政 权 才 能 维 持 一 定 程 度 的 生 存 。 而 我 们 的 矿 业 公 司 是 为 数 不 多 愿 意 前 往 这 块 准 交 火 区 进 行 开 采 的 企 业 。 他 们 也 试 图 通 过 旅 游 业 ， 例 如 体 验 特 色 公 社 和 边 境 打 靶 作 为 项 目 来 赚 取 外 汇 。 在 外 交 上 该 国 也 是 个 十 足 的 “ 伪 政 权 ” ， 仅 有 少 数 左 翼 政 权 ， 分 离 主 义 政 权 ， 古 巴 ， 伊 朗 和 土 耳 其 愿 意 承 认 这 个 小 小 的 地 上 天 国 。 不 过 就 算 受 到 了 经 济 和 政 治 的 双 重 打 击 ， 该 国 仍 然 强 调 有 朝 一 日 会 重 回 巴 格 达 ， 并 通 过 电 台 ， 电 视 机 ， 磁 带 和 报 纸 发 动 一 轮 又 一 轮 的 舆 论 战 。 尤 其 是 对 复 兴 党 的 一 切 政 策 大 加 鞭 鞑 ， 甚 至 包 括 呼 吁 什 叶 派 起 义 。 与 此 同 时 ， 库 尔 德 人 也 越 来 越 要 求 阿 拉 伯 人 滚 出 库 尔 德 斯 坦 。 而 最 近 ， 伊 朗 人 订 购 的 武 器 又 增 加 了 ， 可 是 他 们 也 用 不 了 这 么 多 坦 克 和 战 斗 机 啊 … …";
		}
		else if (a.allcountries[35].parts[0])
		{
			num2 = 1556;
			GlobalScript.inst.new_events_text[1556] = " 在 停 火 后 ， 北 叙 利 亚 成 为 了 库 尔 德 工 人 党 叙 利 亚 支 部 和 民 族 民 主 大 会 的 最 后 根 据 地 ， 在 库 工 党 的 号 召 下 ， 越 来 越 多 的 库 尔 德 人 进 入 北 叙 利 亚 ， 人 口 占 比 不 少 的 库 尔 德 人 甚 至 一 跃 成 为 主 体 民 族 ， 随 之 而 来 的 便 是 库 尔 德 工 人 党 的 内 部 政 变 ， 北 叙 利 亚 改 头 换 面 成 为 了 独 立 的 库 尔 德 斯 坦 ， 民 族 民 主 大 会 内 愿 意 继 续 合 作 的 成 为 当 地 阿 拉 伯 人 的 代 表 政 党 ， 不 愿 意 继 续 合 作 的 则 被 礼 送 出 境 。 尽 管 如 此 ， 叙 利 亚 库 尔 德 在 外 交 上 是 个 彻 头 彻 尾 的 “ 伪 政 权 ” ， 只 有 土 耳 其 ， 古 巴 ， 朝 鲜 ， 数 个 左 翼 国 家 和 分 离 主 义 政 权 承 认 这 个 小 小 国 度 。 叙 利 亚 和 库 尔 德 斯 坦 之 间 的 边 境 冲 突 不 断 ， 这 或 许 只 是 动 荡 的 中 东 的 冰 山 一 角 罢 了 … …";
		}
		else if (a.allcountries[84].Gosstroy == 1)
		{
			num2 = 1556;
			GlobalScript.inst.new_events_text[1556] = " 土 耳 其 的 库 尔 德 人 得 以 得 到 自 治 权 ，虽 然 一 个 统 一 的 民 族 国 家 仍 是 可 望 不 可 及 的 梦 想 ， 但 他 们 至 少 离 这 个 梦 想 更 近 了 一 些 ， 对 吧 ？ ......";
		}
		else
		{
			num2 = 1557;
		}
		int num3;
		if (a.allcountries[84].parts[4] && a.allcountries[84].SubGosstroy == 9)
		{
			num3 = 1558;
		}
		else if (a.allcountries[84].SubGosstroy == 9)
		{
			num3 = 1559;
		}
		else if (a.allcountries[84].Gosstroy == 2 && !a.allcountries[84].cw)
		{
			num3 = 1560;
		}
		else if (a.allcountries[84].Gosstroy == 2 && a.allcountries[84].cw)
		{
			num3 = 1560;
			GlobalScript.inst.new_events_text[1560] = " 执 政 的 共 和 人 民 党 以 实 现 国 内 政 治 民 主 化 和 发 展 民 主 社 会 主 义 为 目 标 ， 并 削 弱 军 队 对 国 内 政 治 影 响 力 ， 并 阻 止 其 发 动 二 次 政 变 的 可 能 。 新 通 过 的 宪 法 则 巩 固 了 左 翼 政 府 的 发 展 成 就 ， 其 条 款 囊 括 引 入 社 会 保 障 与 民 主 的 多 党 制 。 同 时 ， 政 府 巩 固 了 大 型 企 业 国 有 化 的 政 策 ， 同 时 保 障 了 中 小 型 企 业 的 发 展 ， 并 强 化 了 工 会 运 动 的 作 用 ， 企 业 需 要 与 工 会 达 成 协 作 ， 民 主 管 理 企 业 ； 以 及 厉 行 反 垄 断 法 ， 并 实 行 国 内 福 利 国 家 建 设 和 社 会 广 泛 投 资 。 共 和 人 民 党 在 改 进 社 会 的 福 祉 上 起 到 了 有 效 结 果 ， 但 也 带 来 了 资 本 外 流 与 财 政 开 支 过 大 的 问 题 。 由 于 无 法 应 付 越 加 严 重 的 经 济 问 题 以 及 党 内 各 派 的 争 执 ， 共 和 人 民 党 最 终 一 分 为 三 ： 奉 行 社 会 民 主 主 义 的 社 会 民 主 党 、 更 加 强 调 凯 末 尔 主 义 的 民 粹 主 义 党 以 及 由 比 伦 特 · 埃 杰 维 特 领 导 的 民 主 社 会 主 义 的 民 主 左 翼 党 。 共 和 人 民 党 的 分 裂 使 得 中 间 派 政 治 势 力 的 支 持 上 升 ， 但 在 其 中 还 未 有 一 股 势 力 能 够 单 独 赢 下 议 会 选 举 ， 这 导 致 三 党 不 得 不 通 过 联 盟 共 同 执 政 。 新 政 府 将 尝 试 维 持 政 治 联 盟 ， 并 开 展 改 革 ， 以 维 护 他 们 的 政 治 地 位 。";
		}
		else if (a.allcountries[84].Gosstroy == 1 && a.allcountries[84].SubGosstroy == 1 && a.allcountries[84].cw)
		{
			num3 = 1560;
			GlobalScript.inst.new_events_text[1560] = " 夺 取 了 土 耳 其 领 导 权 的 土 耳 其 人 民 共 产 党 建 立 了 土 耳 其 社 会 主 义 共 和 国 并 得 以 再 度 审 视 本 国 的 历 史 ， 以 解 决 该 国 长 期 存 在 的 各 种 沙 文 主 义 与 扩 张 主 义 思 潮 。 人 民 共 产 党 在 对 国 内 的 修 正 主 义 势 力 和 反 动 势 力 进 行 了 物 理 清 算 后 ， 便 开 始 了 社 会 主 义 改 造 。 农 村 公 社 和 城 市 国 营 企 业 逐 渐 在 国 内 建 立 起 来 ， 工 人 委 员 会 和 一 些 直 接 民 主 的 元 素 也 得 以 引 入 ， 工 人 和 农 民 在 经 济 生 产 和 政 治 领 域 获 得 了 民 主 管 理 权 力 。 如 今 他 们 正 在 社 会 主 义 的 大 道 上 大 步 迈 进 。 外 交 上 ， 土 耳 其 积 极 追 随 最 革 命 与 最 进 步 的 阵 营 ， 他 们 正 成 为 中 东 反 帝 反 修 的 革 命 桥 头 堡 。";
		}
		else if (a.allcountries[84].Gosstroy != 1 || a.allcountries[84].SubGosstroy != 16 || !a.allcountries[84].cw || !a.allcountries[84].prosov)
		{
			num3 = ((a.allcountries[84].parts[3] && (a.allcountries[7].parts[0] || a.allcountries[7].parts[2])) ? 1561 : (a.allcountries[84].parts[3] ? 1562 : ((a.empires[0].now_leader != 4 || !a.event_done[375] || (!a.allcountries[7].parts[0] && !a.allcountries[7].parts[2])) ? 1564 : 1563)));
		}
		else
		{
			num3 = 1560;
			GlobalScript.inst.new_events_text[1560] = " 执 政 的 联 合 共 产 党 以 建 立 苏 式 社 会 主 义 为 目 标 ， 在 国 内 开 展 了 大 规 模 的 国 有 化 ， 并 控 制 了 所 有 工 会 。 激 进 派 共 产 党 都 被 迫 “ 边 缘 化 ” 。 新 通 过 的 宪 法 则 巩 固 了 苏 式 马 列 主 义 的 发 展 成 就 ， 其 条 款 囊 括 引 入 苏 维 埃 民 主 和 囊 括 支 持 现 有 建 制 政 党 的 爱 国 阵 线 。 亚 美 尼 亚 种 族 灭 绝 历 史 的 反 思 使 得 该 国 的 民 族 主 义 思 潮 得 以 遏 制 ， 土 耳 其 将 于 苏 东 阵 营 进 行 深 度 融 合 ， 其 本 身 也 成 为 了 苏 联 在 中 东 扩 张 的 跳 板 。";
		}
		text = string.Format(GlobalScript.inst.new_events_text[1541], "\n", (num > 0) ? GlobalScript.inst.new_events_text[num] : null, GlobalScript.inst.new_events_text[num2], GlobalScript.inst.new_events_text[num3]);
		if (GlobalScript.inst.gameState.allcountries[84].parts[5])
		{
			text = " | 蛇 吞 象 ||土 耳 其 对 伊 朗 的 鲸 吞 最 终 导 致 了 对 自 身 的 反 噬 ： 文 化 、 人 口 处 于 优 势 地 位 的 伊 朗 反 过 来 对 土 耳 其 人 进 行 了 “ 再 波 斯 化 ” 。 尽 管 土 耳 其 精 英 竭 力 试 图 阻 止 这 一 过 程 ， 但 终 究 无 济 于 事 。 土 耳 其 文 化 在 原 土 耳 其 境 内 随 风 飘 散 ： 波 斯 语 全 面 渗 入 人 们 的 日 常 生 活 中 ， 甚 至 一 些 人 开 始 自 称 为 “ 塞 尔 柱 人 ” （ 这 得 益 于 伊 朗 精 英 对 突 厥 — 波 斯 文 化 的 复 兴 ） ； 逊 尼 派 宗 教 为 什 叶 派 所 取 代 … … 伊 朗 最 终 借 壳 上 市 ， 成 为 了 所 谓 “ 大 土 耳 其 ” 的 绝 对 中 心 。 现 在 ， 他 们 望 向 了 “ 大 波 斯 — 雅 利 安 地 区 ” ， 我 们 希 望 一 切 都 好 … …";
		}
	}
}
