using EventsForDLC;
using UnityEngine;

public class Event559 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 摩 洛 哥 的 柏 林 墙";
		text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 ， 是 时 候 谈 谈 我 们 远 处 的 国 家 摩 洛 哥 了 。 作 为 最 早 的 和 我 们 建 交 的 非 洲 国 家 之 一 ， 在 某 些 时 候 我 们 也 不 得 不 为 此 蒙 羞 。 这 个 国 家 积 极 充 当 美 国 帝 国 主 义 的 马 前 卒 ， 在 非 洲 挫 败 各 个 人 民 民 主 政 权 。 阿 尔 及 利 亚 和 贝 宁 与 几 内 亚 都 有 过 摩 洛 哥 王 国 卫 队 的 身 影 。 而 该 国 虽 是 非 洲 国 家 ， 却 是 其 中 少 见 的 “ 次 帝 国 主 义 ” 。 根 据 《 马 德 里 协 定 》 ， 西 班 牙 从 西 属 撒 哈 拉 撤 军 后 ， 冲 突 升 级 。 从 1 9 7 5 年 开 始 ， 西 撒 人 阵 在 阿 尔 及 利 亚 的 支 持 下 和 摩 洛 哥 展 开 了 漫 长 的 游 击 战 争 。 1 9 7 6 年 2 月 ， 西 撒 人 阵 宣 布 成 立 撒 哈 拉 阿 拉 伯 民 主 共 和 国 ， 该 国 尚 未 得 到 我 国 的 承 认 。 1 9 7 7 年 毛 里 塔 尼 亚 单 方 面 和 西 撒 人 阵 结 束 战 争 并 承 认 其 独 立 之 后 ， 摩 洛 哥 成 为 了 西 撒 人 阵 最 主 要 的 敌 对 力 量 。||为 了 打 击 反 政 府 武 装 ， 摩 洛 哥 政 府 特 别 拨 款 开 始 修 建 一 堵 绰 号 “ 沙 墙 ” 的 准 军 事 设 施 。 其 配 备 有 瞭 望 塔 ， 炮 兵 雷 达 ， 狙 击 手 和 地 雷 阵 。 “ 沙 墙 ” 是 一 堵 2 米 高 的 墙 ， 牢 牢 占 据 着 制 高 点 。 每 5 公 里 分 别 有 大 型 、 小 型 和 中 型 基 地 ， 每 个 站 点 大 约 有 3 5 - 4 0 名 士 兵 ， 距 离 也 有 1 0 名 士 兵 。 每 个 主 要 哨 所 后 面 约 4 公 里 有 一 个 快 速 反 应 哨 站 ， 驻 有 机 动 部 队 用 以 围 剿 反 抗 军 。 一 系 列 重 叠 的 固 定 雷 达 和 移 动 雷 达 也 放 置 在 整 个 护 堤 上 。 据 估 计 ， 雷 达 的 射 程 在 西 撒 人 阵 控 制 的 领 土 上 有 6 0 至 8 0 公 里 ， 通 常 用 于 对 检 测 到 的 西 撒 人 阵 部 队 进 行 炮 击 。 而 一 期 工 程 将 包 括 “ 有 用 的 三 角 地 ” ， 即 西 撒 哈 拉 首 府 阿 尤 恩 ， 斯 马 拉 和 布 克 拉 的 人 口 密 集 区 与 盐 酸 矿 区 。||据 信 ， 西 撒 人 阵 将 对 该 工 程 展 开 一 场 突 袭 ， 但 我 们 可 以 火 上 浇 油 ， 为 西 撒 哈 拉 人 民 的 武 装 斗 争 送 上 来 自 东 方 的 支 持 。 但 也 许 和 摩 洛 哥 人 打 好 关 系 更 重 要 ？ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 ， 我 们 的 方 针 告 诉 了 我 们 该 支 持 谁 ， 但 这 样 真 的 值 得 吗 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 1)
		{
			button_text[0] = " 公 开 承 认 西 撒 哈 拉 ， 并 提 供 军 火 援 助";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 绝 不 给 非 法 政 府 站 台 ！";
		}
		button_text[1] = " 赞 扬 摩 洛 哥 的 所 作 所 为";
		button_text[2] = " 顺 其 自 然 ， 他 们 不 需 要 我 们 的 表 态";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 摩 洛 哥 的 柏 林 墙";
		if (result_num == 0)
		{
			text = " 我 国 的 外 交 态 度 一 转 过 去 的 妥 协 态 度 。 我 们 不 仅 公 开 承 认 了 阿 拉 伯 撒 哈 拉 民 主 共 和 国 ， 还 驱 逐 了 两 位 摩 洛 哥 外 交 大 使 ， 并 在 北 京 开 设 了 阿 拉 伯 撒 哈 拉 民 主 共 和 国 代 办 处 。 “ 这 是 必 要 的 一 步 ， 中 华 人 民 共 和 国 仍 然 像 过 去 一 样 为 全 世 界 渴 望 得 到 自 由 ， 独 立 和 民 主 的 人 民 提 供 坚 实 的 护 盾 。 ” 《 人 民 日 报 》 的 社 论 如 是 说 到 。 西 撒 人 阵 总 书 记 穆 罕 默 德 · 阿 卜 杜 勒 · 阿 齐 兹 派 代 表 向 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 表 示 了 感 谢 ， 并 在 流 亡 政 府 的 驻 地 以 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 的 名 字 命 名 了 一 座 新 学 校 。 摩 洛 哥 王 室 对 我 们 “ 承 认 伪 政 府 ” 的 举 动 感 到 不 解 与 愤 怒 ， 他 们 承 认 了 中 国 台 北 政 府 ， 甚 至 在 联 合 国 大 会 上 要 求 恢 复 中 华 民 国 的 合 法 席 位 。||我 们 为 西 撒 人 阵 提 供 了 一 笔 丰 厚 的 军 事 援 助 。 在 西 撒 人 阵 的 特 别 会 议 上 ， 马 克 思 列 宁 主 义 的 原 则 被 正 式 接 纳 ， 而 其 中 也 包 括 我 们 共 和 国 的 缔 造 者 毛 泽 东 主 席 的 游 击 作 战 理 论 。 一 批 军 火 通 过 阿 尔 及 利 亚 人 的 手 送 往 了 廷 杜 夫 ， 而 这 些 武 器 将 会 用 来 打 击 邪 恶 的 内 殖 民 主 义 者 。 很 快 ， 城 墙 的 修 建 工 作 因 为 持 续 不 断 的 武 装 骚 扰 而 被 迫 延 期 。";
			a.allcountries[18].cw = true;
			a.allcountries[54].Torg = false;
			a.empires[1].relations += 50;
			a.empires[0].relations -= 100;
			a.data[22] -= 50;
		}
		if (result_num == 1)
		{
			text = " 我 们 在 《 人 民 日 报 》 上 提 及 了 摩 洛 哥 所 建 设 的 城 墙 ， 并 把 它 与 我 国 历 史 上 知 名 的 长 城 所 媲 美 。 “ 摩 洛 哥 人 民 开 创 性 的 将 防 御 工 事 与 生 产 相 结 合 ， 一 手 拿 枪 一 手 拿 稿 。 为 保 护 祖 国 的 和 平 稳 定 作 出 了 突 出 贡 献 ” 。 摩 洛 哥 国 王 哈 桑 二 世 拍 来 了 表 示 赞 同 的 电 报 ， 称" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 是 当 代 非 洲 国 家 的 领 军 人 ， 而 摩 洛 哥 将 坚 定 的 和 中 华 人 民 共 和 国 站 在 一 起 ， 反 抗 殖 民 主 义 者 。 我 们 提 出 派 遣 一 支 工 兵 代 表 团 前 去 学 习 先 进 经 验 ， 得 到 了 摩 洛 哥 方 面 的 赞 同 。 而 阿 尔 及 利 亚 非 常 反 感 这 一 举 措 ， 他 们 宣 布 驱 逐 我 们 大 使 馆 的 一 名 三 等 秘 书 。||西 撒 人 阵 如 期 举 行 了 针 对 城 墙 的 袭 击 ， 但 城 墙 仍 然 在 有 条 不 紊 的 建 设 中 ， 而 这 何 时 会 是 个 头 呢 ？";
			a.allcountries[54].Torg = true;
			a.empires[0].relations += 50;
			a.data[6] += 50;
		}
		if (result_num == 2)
		{
			text = " 我 们 没 有 表 态 ， 他 们 也 不 需 要 我 们 的 表 态 。 城 墙 依 然 在 有 条 不 紊 的 建 设 中 ， 何 时 会 是 个 头 呢 ？ ";
		}
	}
}
