using EndingsDLCDraft;
using UnityEngine;

public class Ending22 : EndingsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEnding(ref string name, ref string text)
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		name = GlobalScript.inst.new_events_text[1569];
		if (a.data[147] == 1)
		{
			if (a.modifies[49].active)
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(120);
				}
				text = string.Format(GlobalScript.inst.new_events_text[1586], '\n');
				return;
			}
			int num = 0;
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].econ)
				{
					num++;
				}
			}
			int num2 = ((GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.influencePRC && (a.allcountries[1].Gosstroy != 1 || num <= 15) && a.empires[1].now_leader == 6) ? 1600 : 1599);
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(119);
			}
			text = string.Format(GlobalScript.inst.new_events_text[1587], '\n', GlobalScript.inst.new_events_text[num2]);
		}
		else if (a.data[147] == 2)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1588], '\n');
		}
		else if (a.data[147] == 3)
		{
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(118);
			}
			text = " 民 主 社 会 主 义||迈 克 尔 · 富 特 政 府 延 续 已 在 战 后 实 行 3 0 余 年 的 凯 恩 斯 主 义 政 策 ， 其 领 导 形 成 的 新 政 府 包 括 工 党 内 的 “ 软 左 翼 ” 成 员 。 富 特 政 府 反 对 新 自 由 主 义 全 球 化 的 潮 流 ， 退 出 欧 洲 经 济 共 同 体 ； 并 批 判 前 任 保 守 党 政 府 的 政 策 ， 称 其 是 “ 倒 行 逆 施 ” ， “ 破 坏 了 英 国 的 社 会 主 义 成 果 ” 。 同 时 ， 富 特 政 府 推 出 了 一 系 列 具 有 浓 厚 社 会 主 义 色 彩 的 政 策 ， 在 工 业 、 银 行 业 等 国 家 重 要 领 域 重 新 开 展 国 有 化 ， 引 入 了 干 预 性 产 业 政 策 ， 进 行 经 济 民 主 化 ， 减 少 失 业 ， 促 进 因 保 守 党 政 府 改 革 造 成 的 国 企 失 业 工 人 再 就 业 ， 人 民 的 生 活 水 平 显 著 提 高 ； 税 收 政 策 也 得 以 改 订 ， 富 人 被 征 收 更 高 的 个 人 税 ， 以 重 建 “ 高 税 收 ， 高 福 利 ” 的 福 利 国 家 。 在 军 事 上 ， 工 党 已 经 开 展 单 方 面 核 裁 军 ； 政 治 改 革 上 ， 上 议 院 的 权 力 被 完 全 削 减 ， 只 保 留 国 家 荣 誉 的 职 能 ； 减 少 君 主 制 元 素 的 改 革 也 已 经 进 行 ， 女 王 的 形 象 在 国 家 政 治 中 减 少 了 ； 民 主 元 素 获 得 更 多 引 入 ， 地 方 分 权 的 强 化 使 得 王 国 更 加 联 邦 化 了 。\n 工 党 的 政 策 取 得 了 较 大 成 果 ， 但 是 国 有 化 以 及 税 收 提 高 也 造 成 了 资 本 外 流 的 问 题 。 自 由 党 和 社 会 民 主 党 的 联 盟 抨 击 政 府 的 预 算 过 分 膨 胀 、 高 税 收 影 响 了 国 家 的 经 济 发 展 ； 保 守 党 批 评 政 府 “ 对 女 王 不 敬 ” ， 是 “ 布 尔 什 维 克 匪 徒 ” ； 他 们 都 希 望 能 够 改 组 政 府 … …";
		}
		else if (a.data[147] == 4)
		{
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(117);
			}
			text = string.Format(GlobalScript.inst.new_events_text[1590], '\n');
		}
		else if (a.data[147] == 6)
		{
			text = " 英 国 的 社 会 主 义 道 路||过 去 由 约 瑟 夫 · 斯 大 林 同 志 批 准 的 战 后 英 国 共 产 党 的 “ 英 国 社 会 主 义 之 路 ” 的 纲 领 终 于 成 为 了 现 实 。 工 人 阶 级 领 导 的 各 种 政 治 力 量 — — 工 党 “ 硬 左 派 ” ， 英 共 （ 马 列 ） ， 英 国 共 产 党 （ 由 党 内 左 派 掌 权 ） 等 各 派 — — 粉 碎 了 资 产 阶 级 和 君 主 制 保 守 力 量 的 反 击 ， 建 立 了 人 民 民 主 联 盟 ， 在 工 人 阶 级 民 主 机 构 （ 工 会 、 工 会 委 员 会 ） 的 支 持 下 ， 开 始 实 施 左 翼 的 社 会 主 义 建 设 纲 领 。\n 过 去 被 保 守 党 私 有 化 的 国 有 企 业 被 再 度 国 有 化 ， 并 和 已 有 的 国 企 一 起 被 改 造 为 实 行 “ 工 业 民 主 ” 的 由 国 家 和 工 会 共 同 管 理 的 国 营 企 业 ， 同 时 ， 垄 断 企 业 、 以 及 各 个 领 域 的 私 营 企 业 也 被 国 有 化 并 改 造 ， 其 中 规 模 较 小 的 则 由 工 人 合 作 社 进 行 管 理 ， 他 们 的 生 产 则 统 一 服 从 于 国 家 经 济 计 划 委 员 会 的 计 划 — — 过 去 为 智 利 阿 连 德 政 府 架 构 的 赛 博 协 同 系 统 的 英 国 控 制 论 专 家 斯 塔 福 德 · 比 尔 则 得 以 重 拾 该 项 目 的 遗 产 ， 为 社 会 主 义 的 英 国 政 府 构 建 革 新 的 计 划 经 济 。\n 土 地 改 革 在 农 村 如 火 如 荼 地 进 行 ， 曾 经 属 于 贵 族 和 王 室 的 土 地 和 产 业 被 完 全 国 有 化 ， 属 于 地 主 和 农 场 主 的 土 地 被 收 归 “ 公 社 ” ， 归 集 体 所 有 ， 公 社 的 建 制 在 英 共 （ 马 列 ） 的 影 响 下 仿 效 了 中 国 的 人 民 公 社 体 制 ， 形 成 了 高 度 发 达 的 农 村 社 区 。\n 由 于 最 终 的 实 践 以 及 政 变 的 教 训 ， 人 民 民 主 联 盟 最 终 决 定 废 除 资 产 阶 级 的 上 层 建 筑 ， 开 始 进 行 政 治 改 革 。 在 新 体 制 吸 收 了 巴 黎 公 社 的 经 验 ， 将 由 人 民 民 主 联 盟 党 团 、 工 人 阶 级 民 主 机 构 和 人 民 共 同 选 举 各 级 政 府 。 同 时 ， 政 府 引 入 了 中 国 的 工 人 政 治 运 动 和 大 民 主 的 经 验 ， 帮 助 打 击 资 产 阶 级 和 旧 君 主 制 残 余 。 各 国 对 英 国 社 会 主 义 之 路 的 评 价 不 一 ， 但 是 这 一 独 特 的 社 会 主 义 模 式 也 将 引 起 越 来 越 多 人 的 关 注 。 ";
		}
		else if (a.data[147] == 7)
		{
			text = " 新 护 国 体 制||沃 尔 特 · 沃 克 将 军 成 为 了 新 的 “ 护 国 公 ” ， 他 领 导 的 政 府 声 明 ， “ 这 不 是 破 坏 议 会 制 民 主 ， 而 是 从 工 党 的 极 权 主 义 特 洛 伊 木 马 中 拯 救 王 国 。 ” 并 表 明 将 在 “ 共 产 主 义 癌 症 被 清 除 后 ” ， 重 开 议 会 民 主 。\n 这 位 没 有 “ 护 国 公 ” 名 号 的 大 家 长 和 他 的 盟 友 查 禁 了 工 党 — — 这 导 致 工 党 部 分 成 员 流 向 社 会 民 主 党 — — 并 对 其 他 左 翼 政 党 （ 特 别 是 共 产 主 义 政 党 ） 被 查 禁 ， 其 中 渗 透 工 党 的 “ 战 斗 ” 派 被 重 点 关 照 。 各 个 左 翼 政 党 纷 纷 开 始 转 入 地 下 活 动 。 工 会 运 动 本 身 也 被 政 府 禁 止 ， 他 被 认 为 是 “ 特 洛 伊 木 马 ” 的 一 部 分 ， 新 的 工 会 法 律 规 定 工 会 由 政 府 和 企 业 控 制 ， 工 人 权 利 被 大 大 缩 小 。\n 在 经 济 上 ， “ 工 业 民 主 ” 的 原 则 被 废 除 ， 社 会 主 义 的 政 策 也 被 取 消 ， 经 济 再 度 开 始 自 由 化 ， 国 有 企 业 被 大 量 私 有 化 ， 撒 切 尔 政 府 的 政 策 逐 渐 被 恢 复 。 英 国 目 前 成 为 了 事 实 上 的 奉 行 威 权 新 自 由 主 义 的 国 家 ， 并 开 始 重 新 回 归 与 美 国 同 盟 关 系 。 谁 都 不 知 道 政 府 要 清 理 多 久 “ 共 产 主 义 癌 症 ” 才 会 重 开 议 会 ， 也 不 知 道 暗 藏 的 矛 盾 将 如 何 演 变 ， “ 新 护 国 体 制 ” 能 维 持 多 久 … …";
		}
		else if (a.data[147] == 8)
		{
			text = " 英 国 的 社 会 主 义 道 路||战 后 英 国 共 产 党 的 “ 英 国 社 会 主 义 之 路 ” 的 纲 领 终 于 成 为 了 现 实 。 工 人 阶 级 领 导 的 各 种 政 治 力 量 — — 工 党 ” 硬 左 派 ” ， 英 国 共 产 党 （ 由 党 内 左 派 掌 权 ） 等 各 派 — — 粉 碎 了 资 产 阶 级 和 君 主 制 保 守 力 量 的 反 击 ， 建 立 了 人 民 民 主 联 盟 ， 在 工 人 阶 级 民 主 机 构 （ 工 会 、 工 会 委 员 会 ） 的 支 持 下 ， 开 始 实 施 左 翼 的 社 会 主 义 建 设 纲 领 。\n 过 去 被 保 守 党 私 有 化 的 国 有 企 业 被 再 度 国 有 化 ， 并 和 已 有 的 国 企 一 起 被 改 造 为 实 行 “ 工 业 民 主 ” 的 由 国 家 和 工 会 共 同 管 理 的 国 营 企 业 ， 同 时 ， 垄 断 企 业 、 以 及 各 个 领 域 的 私 营 企 业 也 被 国 有 化 并 改 造 ， 其 中 规 模 较 小 的 则 由 工 人 合 作 社 进 行 管 理 ， 他 们 的 生 产 则 统 一 服 从 于 国 家 经 济 计 划 委 员 会 的 计 划 — — 过 去 为 智 利 阿 连 德 政 府 架 构 的 赛 博 协 同 系 统 的 英 国 控 制 论 专 家 斯 塔 福 德 · 比 尔 则 得 以 重 拾 该 项 目 的 遗 产 ， 为 社 会 主 义 的 英 国 政 府 构 建 革 新 的 计 划 经 济 。\n 土 地 改 革 在 农 村 如 火 如 荼 地 进 行 ， 曾 经 属 于 贵 族 和 王 室 的 土 地 和 产 业 被 完 全 国 有 化 ， 属 于 地 主 和 农 场 主 的 土 地 被 收 归 合 作 社 。\n 由 于 最 终 的 实 践 以 及 政 变 的 教 训 ， 人 民 民 主 联 盟 最 终 决 定 废 除 资 产 阶 级 的 上 层 建 筑 ， 开 始 进 行 政 治 改 革 。 在 新 体 制 引 用 了 “ 一 切 权 力 归 苏 维 埃 ！ ” 的 经 验 ， 将 由 人 民 民 主 联 盟 党 团 、 工 人 阶 级 民 主 机 构 和 人 民 共 同 选 举 人 民 民 主 的 各 级 政 府 。 同 时 ， 英 国 正 在 英 共 的 影 响 下 不 断 加 强 同 苏 联 的 合 作 。 各 国 对 英 国 社 会 主 义 之 路 的 评 价 不 一 ， 但 是 这 一 独 特 的 社 会 主 义 模 式 也 将 引 起 越 来 越 多 人 的 关 注 。";
		}
		else
		{
			text = string.Format(GlobalScript.inst.new_events_text[1591], '\n');
		}
	}
}
