using EventsForDLC;
using UnityEngine;

public class Event576 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 我 们 将 会 获 得 胜 利 ， 并 且 我 们 赢 得 过 胜 利";
		text = " 澳 大 利 亚 正 遭 遇 堪 比 1 9 2 3 年 墨 尔 本 警 察 罢 工 的 动 荡 ： 学 生 已 在 大 学 内 搭 好 帐 篷 准 备 持 久 战 ， 各 地 工 会 也 开 始 组 织 全 国 总 罢 工 ， 人 们 打 着 “ 不 是 我 的 共 和 国 ！ ” 的 旗 号 纷 纷 走 上 街 头 ， 斗 争 局 势 愈 演 愈 烈 。";
		if (a.resultOfEvents[573] == 2)
		{
			text += " | 澳 大 利 亚 的 一 些 地 方 甚 至 出 现 类 似 “ 红 军 旅 ” 的 城 市 游 击 队 与 针 对 公 安 部 门 的 恐 怖 行 动 。 新 任 总 理 约 · 比 耶 克 · 彼 德 森 试 图 平 息 混 乱 的 举 动 的 举 动 只 会 给 局 势 火 上 浇 油 ： 他 在 电 视 上 将 旧 澳 大 利 亚 宪 法 撕 成 碎 片 ， 并 手 持 猎 枪 宣 布 自 己 维 持 秩 序 的 决 心 被 广 泛 视 为 “ 独 裁 主 义 第 一 步 ” 。 新 打 着 “ 矿 工 ” 和 “ 农 民 ” 旗 号 的 民 兵 与 各 地 警 察 已 得 到 额 外 授 权 ， 并 开 入 城 区 压 制 群 众 运 动 。";
		}
		else if (a.resultOfEvents[573] == 1)
		{
			text += " | 我 们 的 老 朋 友 也 借 助 广 泛 的 抗 议 运 动 和 城 市 游 击 队 的 威 势 建 立 起 了 工 会 网 络 ， 并 自 发 夺 取 了 悉 尼 与 墨 尔 本 的 市 政 厅 。 启 动 了 对 资 产 阶 级 生 产 资 料 的 社 会 化 。 ";
		}
		text += "  |主 席 同 志 ， 时 不 我 待 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 2 && (a.resultOfEvents[573] == 1 || a.resultOfEvents[573] == 2) && a.allcountries[50].Gosstroy == 1)
		{
			button_text[0] = " 支 持 澳 大 利 亚 人 民 的 正 义 事 业 ！";
		}
		else if (a.allcountries[50].Gosstroy != 1)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 干 涉 澳 洲 的 跳 板 … …";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 骚 乱 不 足 以 成 事";
		}
		if (a.data[56] > 1 && a.resultOfEvents[573] == 0)
		{
			button_text[1] = " 支 持 澳 大 利 亚 共 和 国 维 护 秩 序 ， 并 建 议 其 走 分 化 工 会 运 动 的 红 色 托 利 路 线";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 怎 能 同 法 西 斯 主 义 狼 狈 为 奸 ？ ！";
		}
		button_text[2] = " 我 们 无 能 为 力";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 们 将 会 获 得 胜 利 ， 并 且 我 们 赢 得 过 胜 利";
		if (result_num == 0)
		{
			text = " 我 们 的 临 门 一 脚 给 了 彼 德 森 政 府 致 命 一 击 ： 由 于 澳 洲 社 会 主 义 者 愈 加 倾 向 于 从 亚 红 色 政 权 获 取 支 持 ， 而 包 括 美 国 在 内 的 盟 友 均 处 于 “ 天 高 皇 帝 远 ” 的 状 态 。 他 很 快 便 辞 去 总 理 一 职 并 流 亡 美 国 ， 军 队 也 因 领 导 层 的 混 乱 而 只 得 接 受 最 近 发 出 的 命 令 ： 待 在 自 己 的 兵 营 里 以 避 免 “ 无 望 的 血 腥 冲 突 ” 。 澳 大 利 亚 社 会 主 义 者 的 胜 利 已 成 定 局 ：";
			a.data[8] -= 200;
			a.data[9] -= 200;
			a.data[22] -= 200;
			if (a.allcountries[92].SubGosstroy == 18)
			{
				text += " 最 终 ， “ 革 命 马 克 思 主 义 ” 元 老 汤 姆 · O · 林 肯 得 以 执 掌 澳 洲 大 权 ， 并 以 澳 洲 托 派 组 织 和 抗 议 期 间 的 革 命 阵 线 为 蓝 本 合 并 各 派 社 会 主 义 组 织 ， 形 成 了 大 洋 洲 版 本 的 德 国 统 一 社 会 党 。 基 于 澳 大 利 亚 “ 工 会 强 ， 党 却 弱 而 杂 ” 的 客 观 特 点 ， 试 图 在 大 洋 洲 扮 演 二 号 列 宁 的 林 肯 很 快 便 碰 上 了 自 己 的 “ 工 人 反 对 派 ” … … ";
				a.allcountries[135].Gosstroy = 1;
				a.allcountries[135].SubGosstroy = 18;
				a.allcountries[135].LeaveAlliances();
				a.allcountries[135].Torg = true;
				a.allcountries[134].puppetOf = -1;
			}
			else if (a.resultOfEvents[573] == 2)
			{
				text += " 最 终 ， 我 们 的 老 友 E · F · “ 泰 德 · “ 希 尔 得 以 执 掌 澳 洲 大 权 ， 并 以 澳 共 （ 马 列 ） 和 抗 议 期 间 的 革 命 阵 线 为 蓝 本 合 并 各 派 社 会 主 义 组 织 ， 形 成 了 大 洋 洲 版 本 的 德 国 统 一 社 会 党 。 基 于 澳 大 利 亚 “ 工 会 强 ， 党 却 弱 而 杂 ” 的 客 观 特 点 ， 希 尔 试 图 在 澳 大 利 亚 工 联 主 义 与 马 列 毛 主 义 间 寻 求 调 和 ， 开 辟 民 族 特 色 社 会 主 义 道 路 。";
				a.allcountries[135].Gosstroy = 1;
				a.allcountries[135].SubGosstroy = 1;
				a.allcountries[135].LeaveAlliances();
				a.allcountries[135].Torg = true;
				a.allcountries[135].proprc = true;
				a.allcountries[134].puppetOf = -1;
				a.influencePRC += 50;
			}
			else if (a.resultOfEvents[573] == 1)
			{
				text += " 最 终 ， 亲 苏 的 社 会 党 领 导 人 兼 建 筑 工 人 产 业 工 会 领 袖 帕 特 · 克 兰 西 得 以 执 掌 澳 洲 大 权 ， 并 以 社 会 党 和 抗 议 期 间 的 革 命 阵 线 为 蓝 本 合 并 各 派 社 会 主 义 组 织 ， 形 成 了 大 洋 洲 版 本 的 德 国 统 一 社 会 党 。 基 于 澳 大 利 亚 “ 工 会 强 ， 党 却 弱 而 杂 ” 的 客 观 特 点 ， 他 开 始 将 工 会 按 功 能 界 别 纳 入 国 家 管 理 体 制 ， 并 越 加 向 “ 社 会 主 义 兄 弟 们 ” 看 齐 。";
				a.allcountries[135].Gosstroy = 1;
				a.allcountries[135].SubGosstroy = 16;
				a.allcountries[135].LeaveAlliances();
				a.allcountries[135].Torg = true;
				a.allcountries[135].prosov = true;
				a.allcountries[134].puppetOf = -1;
				a.empires[1].power += 100;
			}
			text += " 剩 余 的 反 动 派 则 躲 藏 在 沙 漠 与 森 林 中 ， 靠 偷 袭 交 通 要 道 和 荒 漠 小 镇 的 方 式 表 达 对 红 色 政 权 的 抗 议 。 不 过 对 新 政 府 而 言 ， 这 群 “ 白 色 凯 利 ” 不 过 是 注 定 碰 壁 的 小 小 苍 蝇 而 已 。 现 在 是 享 受 南 半 球 阳 光 的 时 候 了 ！ ";
			a.empires[0].relations -= 300;
			a.empires[0].power -= 100;
		}
		if (result_num == 1)
		{
			text = " 我 们 立 即 联 系 了 约 · 比 耶 克 · 彼 德 森 总 理 ， 并 表 示 中 国 将 在 “ 非 意 识 形 态 外 交 ” 的 基 础 上 帮 助 该 国 维 持 秩 序 。 得 到 东 方 大 国 援 助 的 彼 德 森 很 快 便 有 了 底 气 ， 并 重 新 运 用 他 在 昆 士 兰 州 长 时 期 “ 一 手 补 贴 一 手 大 棒 ” 的 策 略 ， 从 而 平 息 了 全 国 暴 动 。 大 多 数 工 会 领 袖 对 《 产 业 协 调 法 》 表 示 满 意 ， 残 存 的 反 对 派 则 被 国 家 安 全 局 、 保 守 工 会 与 “ 农 民 雇 佣 兵 ” 围 堵 消 灭 。 目 前 的 澳 大 利 亚 秩 序 尽 然 ， 并 开 始 通 过 有 趣 的 “ 经 济 政 策 ” 形 成 稳 固 支 持 群 体 ： 政 府 公 务 员 开 始 在 大 街 小 巷 分 发 “ 信 用 券 ” ， 以 鼓 励 消 费 主 义 的 方 式 基 本 拴 牢 了 该 国 各 大 城 市 。 ";
			a.data[8] -= 180;
			a.data[9] -= 150;
			a.allcountries[135].Gosstroy = 2;
			a.allcountries[135].SubGosstroy = 8;
			a.allcountries[135].LeaveAlliances();
			a.allcountries[135].Torg = true;
			a.allcountries[135].proprc = true;
		}
		if (result_num == 2)
		{
			text = " 持 续 数 月 的 全 国 混 乱 最 终 迫 使 澳 大 利 亚 军 方 入 局 干 涉 ， 彼 德 森 就 此 从 军 队 处 取 得 许 可 并 颁 布 了 军 法 戒 严 。 坦 克 开 入 堪 培 拉 联 邦 区 的 街 道 及 该 国 主 要 城 市 。 澳 大 利 亚 全 国 近 乎 卷 入 了 迷 你 内 战 ： 被 示 威 者 用 作 据 点 的 悉 尼 海 港 大 桥 被 海 军 开 火 炸 毁 ， 墨 尔 本 大 学 的 百 年 建 筑 也 因 变 为 街 垒 而 难 逃 喷 火 器 淫 威 。 纯 粹 的 暴 力 自 然 为 其 带 来 了 胜 利 ， 而 报 复 政 策 只 会 愈 演 愈 烈 。 政 府 对 军 警 宪 特 赋 予 额 外 授 权 ， 要 求 准 军 事 组 织 和 士 兵 竭 尽 所 能 搜 捕 “ 外 国 间 谍 ” 和 社 会 主 义 者 。 出 于 对 付 境 外 势 力 的 需 要 ， 澳 大 利 亚 又 对 巴 布 亚 新 几 内 亚 发 出 了 “ 联 合 行 动 ” 邀 请 ， 并 将 其 “ 自 愿 ” 拉 入 “ 反 共 阵 营 ” ： 原 住 民 协 会 被 严 厉 封 杀 ， 原 住 民 活 动 家 则 和 白 人 社 会 主 义 者 一 道 被 被 隔 离 在 似 曾 相 识 的 “ 营 地 ” 里 。 澳 大 利 亚 封 锁 边 界 与 遣 送 间 谍 的 行 为 只 会 让 人 想 到 白 澳 政 策 的 卷 土 重 来 。 红 色 的 土 地 上 ， 流 着 红 色 的 血 … …";
			a.allcountries[135].Gosstroy = 0;
			a.allcountries[135].SubGosstroy = 7;
			a.allcountries[135].LeaveAlliances();
			a.allcountries[135].Vyshi = true;
			text += "||出 于 防 范 共 产 主 义 渗 透 的 务 实 需 要 ， 澳 大 利 亚 政 府 宣 布 将 承 担 起 “ 协 同 防 御 南 太 平 洋 友 邦 的 责 任 ” 。 事 实 上 入 侵 了 瓦 努 阿 图 和 其 他 南 太 平 洋 群 岛 。";
			a.allcountries[159].Gosstroy = 0;
			a.allcountries[159].SubGosstroy = 7;
			a.allcountries[159].LeaveAlliances();
			a.allcountries[159].puppetOf = 135;
		}
	}
}
