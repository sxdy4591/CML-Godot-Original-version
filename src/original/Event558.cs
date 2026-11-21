using EventsForDLC;
using UnityEngine;

public class Event558 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 将 军";
		text = " 来 自 莫 斯 科 的 突 发 消 息 。 由 于 苏 联 新 任 领 导 人 米 哈 伊 尔 · 戈 尔 巴 乔 夫 上 任 伊 始 便 遭 遇 接 连 不 断 的 政 治 与 外 交 失 败 ， 且 无 法 拿 出 扭 转 内 外 交 困 境 地 的 果 断 方 案 。 导 致 他 在 领 导 层 内 已 民 心 尽 失 。 作 为 其 政 治 盟 友 空 降 的 “ 新 思 维 ” 改 革 小 组 也 只 会 让 他 的 处 境 变 得 更 糟 ， 这 些 人 同 苏 联 绝 大 多 数 官 员 间 多 有 龃 龉 ： 尤 其 是 试 图 以 管 制 民 主 与 总 统 制 为 蓝 本 改 组 苏 联 体 制 ， 为 此 不 惜 加 速 苏 联 社 会 内 矛 盾 爆 发 ， 事 实 上 持 亲 大 西 洋 主 义 立 场 的 亚 历 山 大 · 雅 科 夫 列 夫 。 终 于 ， 即 便 是 曾 支 持 戈 尔 巴 乔 夫 上 位 ， 作 为 其 重 要 盟 友 的 老 政 治 家 安 德 烈 · 葛 罗 米 柯 与 管 理 党 务 的 前 托 木 斯 克 党 委 第 一 书 记 叶 戈 尔 · 利 加 乔 夫 也 选 择 抛 弃 了 他 。 几 乎 是 在 四 月 全 会 结 束 后 不 久 ， 戈 尔 巴 乔 夫 的 前 盟 友 们 便 串 通 安 德 罗 波 夫 提 拔 的 “ 经 济 总 督 ” （ 即 尼 古 拉 · 雷 日 科 夫 、 列 昂 尼 德 · 阿 巴 尔 金 等 ） 与 部 分 保 守 派 达 成 共 识 ， 趁 戈 尔 巴 乔 夫 一 行 出 访 欧 美 时 召 开 政 治 局 紧 急 会 议 ： 雅 科 夫 列 夫 因 涉 嫌 组 织 “ 间 谍 活 动 ” 被 克 格 勃 领 导 人 切 布 里 科 夫 下 辖 的 安 全 人 员 逮 捕 并 开 除 出 党 ， 戈 尔 巴 乔 夫 在 各 地 的 支 持 者 则 被 纷 纷 孤 立 ， 他 们 的 精 神 领 袖 在 返 回 后 遭 批 评 、 扣 上 “ 唯 意 志 论 ” 的 帽 子 后 被 开 除 。 其 空 位 则 被 各 派 共 同 推 举 的 妥 协 ， 走 保 守 改 革 路 线 的 叶 戈 尔 · 利 加 乔 夫 接 替 ： 新 任 总 书 记 声 称 将 遵 循 集 体 领 导 原 则 ， 延 续 拓 展 经 济 自 主 权 的 试 验 ， 并 在 坚 持 列 宁 主 义 理 论 基 础 上 修 正 戈 尔 巴 乔 夫 改 革 路 线 — — 告 别 了 有 史 以 来 最 短 命 的 苏 联 领 导 人 后 ， 我 们 总 得 站 出 来 说 几 句 … … 利 加 乔 夫 是 苏 式 爱 国 主 义 的 忠 实 拥 趸 ， 必 然 会 竭 尽 所 能 巩 固 并 拓 展 苏 联 势 力 范 围 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[6] <= 900 && a.data[6] >= 500)
		{
			button_text[0] = " 祝 贺 苏 联 领 导 层 的 革 新 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 绝 不 能 给 非 法 政 府 站 台 ！";
		}
		button_text[1] = " 这 是 一 场 非 法 的 ， 违 宪 的 军 事 政 变 … …";
		if (a.data[56] != 0 && a.data[56] != 4)
		{
			button_text[2] = " 兴 许 是 个 机 会 ， 我 将 亲 自 前 往 莫 斯 科 会 见 利 加 乔 夫";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 没 必 要 支 持 半 吊 子 列 宁 主 义 者 ！";
		}
		button_text[3] = " 我 们 静 观 其 变 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 将 军";
		a.empires[1].now_leader = 8;
		if (a.empires[1].power < 0)
		{
			a.empires[1].power = 0;
		}
		if (result_num == 0)
		{
			text = " 事 发 次 日 ， 中 国 驻 苏 联 大 使 便 向 克 里 姆 林 宫 送 去 我 国 领 导 层 的 贺 电 。 祝 贺 苏 联 共 产 党 摆 脱 唯 意 志 主 义 问 题 ， 回 归 实 事 求 是 的 执 政 路 线 ， 并 祝 愿 苏 联 接 下 来 的 经 济 与 社 会 革 新 一 切 顺 利 。 苏 联 对 我 们 的 表 态 颇 为 满 意 ， 并 向 中 方 表 达 感 谢 与 合 作 意 愿 。 尽 管 实 际 上 中 苏 间 关 系 仍 未 产 生 根 本 转 变 ， 新 政 府 和 戈 尔 巴 乔 夫 政 府 间 似 乎 也 很 难 做 出 什 么 区 分 ： 苏 联 仍 在 打 击 酗 酒 的 基 础 上 整 顿 劳 动 纪 律 ， 各 式 经 济 试 验 仍 在 继 续 ， 只 是 一 切 都 被 冠 以 “ 新 的 新 经 济 政 策 ” 之 名 。 未 来 情 况 仍 需 观 察 。";
			a.empires[1].relations += 150;
			a.empires[0].relations -= 50;
			a.data[6] += 10;
		}
		if (result_num == 1)
		{
			text = " 事 发 次 日 ， 中 国 领 导 人 便 表 态 称 。 苏 联 方 罢 免 戈 尔 巴 乔 夫 的 行 为 既 不 合 法 ， 也 不 合 规 ， 严 重 违 反 党 章 国 纪 。 实 际 上 可 说 是 采 用 解 决 敌 我 矛 盾 的 不 合 理 方 式 解 决 问 题 ， 充 分 体 现 了 苏 共 缺 乏 民 主 作 风 ， 决 策 专 断 家 长 的 事 实 。 这 自 然 引 起 了 苏 联 的 不 满 ， 并 为 那 些 试 图 借 题 发 挥 质 疑 新 政 府 合 法 性 的 损 友 们 提 供 了 不 少 便 利 。 我 们 与 苏 联 间 的 外 交 联 系 也 就 此 中 断 。 除 此 之 外 ， 新 政 府 和 戈 尔 巴 乔 夫 政 府 间 似 乎 也 很 难 做 出 什 么 区 分 ： 苏 联 仍 在 打 击 酗 酒 的 基 础 上 整 顿 劳 动 纪 律 ， 各 式 经 济 试 验 仍 在 继 续 ， 只 是 一 切 都 被 冠 以 “ 新 的 新 经 济 政 策 ” 之 名 。 未 来 情 况 仍 需 观 察 。";
			a.empires[1].relations -= 150;
			a.empires[0].relations += 50;
			a.data[6] += 10;
			a.empires[1].power -= 10;
			a.relres = false;
			a.allcountries[7].Torg = false;
		}
		if (result_num == 2)
		{
			text = " 事 发 次 日 ， 中 国 驻 苏 联 大 使 便 向 克 里 姆 林 宫 送 去 我 国 领 导 层 的 贺 电 。 祝 贺 苏 联 共 产 党 摆 脱 唯 意 志 主 义 问 题 ， 回 归 实 事 求 是 的 执 政 路 线 ， 并 祝 愿 苏 联 接 下 来 的 经 济 与 社 会 革 新 一 切 顺 利 。 此 后 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 又 在 某 日 亲 自 造 访 莫 斯 科 ， 同 新 一 代 苏 联 领 导 集 体 会 面 ， 并 就 深 化 经 济 合 作 ， 建 立 互 惠 互 利 关 系 达 成 共 识 。 我 们 已 与 苏 方 达 成 多 份 贸 易 合 同 ， 为 接 下 来 的 增 长 开 拓 不 少 前 景 。 新 政 府 和 戈 尔 巴 乔 夫 政 府 间 似 乎 也 很 难 做 出 什 么 区 分 ： 苏 联 仍 在 打 击 酗 酒 的 基 础 上 整 顿 劳 动 纪 律 ， 各 式 经 济 试 验 仍 在 继 续 ， 只 是 一 切 都 被 冠 以 “ 新 的 新 经 济 政 策 ” 之 名 。 未 来 情 况 仍 需 观 察 。";
			a.empires[1].relations += 250;
			a.empires[0].relations -= 100;
			a.data[6] += 20;
			a.empires[1].power += 10;
			a.empires[0].power -= 20;
			a.data[8] -= 40;
			a.data[12] += 40;
			a.data[13] += 40;
			a.influencePRC += 10;
			a.relres = true;
			a.allcountries[7].Torg = true;
		}
		if (result_num == 3)
		{
			text = " 新 政 府 和 戈 尔 巴 乔 夫 政 府 间 似 乎 也 很 难 做 出 什 么 区 分 ： 苏 联 仍 在 打 击 酗 酒 的 基 础 上 整 顿 劳 动 纪 律 ， 各 式 经 济 试 验 仍 在 继 续 ， 只 是 一 切 都 被 冠 以 “ 新 的 新 经 济 政 策 ” 之 名 。 未 来 情 况 仍 需 观 察 。";
		}
	}
}
