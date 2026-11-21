using EventsForDLC;
using UnityEngine;

public class Event486 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 德 意 志 之 秋";
		text = " 自1977 年 四 月 七 日 以 来 ， 西 德 马 克 思 主 义 的 极 左 翼 城 市 游 击 队 “ 红 军 旅 ” 与 “ 革 命 小 组 ” 展 开 了 大 量 针 对 联 邦 德 国 政 要 与 实 业 家 的 刺 杀 ， 绑 架 与 定 向 爆 破 。 受 害 者 包 括 但 不 局 限 于 ： 齐 格 飞 · 布 巴 克 ， 尤 尔 根 · 庞 特 等 联 邦 德 国 巨 贾 和 反 共 政 客 。 近 日 ， 他 们 又 策 划 了 一 起 劫 机 案 ， 使 得 他 们 本 就 不 多 的 支 持 越 来 越 少 。||而 与 极 左 翼 城 市 游 击 队 一 同 发 源 于 西 德68 运 动 的 “K 小 组 （K-Gruppen , 意 即Communist Groups ， 指 的 是 从 6 8 运 动 发 展 出 的 一 系 列 毛 派 团 体 或 政 党 ） ” 虽 然 都 有 反 修 正 主 义 的 共 同 基 础 ， 但 是 他 们 仍 在 理 论 和 社 会 分 析 上 存 在 较 大 分 歧 ， 其 中 有 部 分 已 经 倾 向 阿 尔 巴 尼 亚 。 在 西 德 的 紧 张 气 氛 下 ， 我 们 是 否 要 借 势 将 这 些 分 散 的 革 命 派 组 织 整 合 起 来 ？ 或 者 帮 助 西 德 当 局 打 击 这 群 叛 匪 ， 以 获 得 和 西 德 政 府 合 作 的 机 会 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 1 && a.allcountries[20].proprc)
		{
			button_text[0] = " 我 们 最 好 组 成 革 命 共 产 党 人 的 大 串 联";
		}
		else if (!a.allcountries[20].proprc)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 显 然 ，连 阿 尔 巴 尼 亚 都 不 支 持 我 们 ， 我 们 无 力 和 他 们 取 得 联 系";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 支 持 革 恐 分 子 ， 你 疯 了 ？";
		}
		if (a.data[56] > 2 && !a.modifies[3].active)
		{
			button_text[1] = " 让 我 们 协 助 西 德 政 府 扫 清 叛 匪";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 背 叛 革 命 者 ！";
		}
		button_text[2] = " 可 是 西 德 太 远 啦 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 德 意 志 之 秋";
		if (result_num == 0)
		{
			text = " 我 们 在 西 德 的 特 工 决 定 帮 他 们 一 把 。 在 一 个 夜 黑 风 高 的 夜 晚 ， 我 们 的 特 勤 用 一 捆 烈 性 炸 药 打 破 了 斯 图 加 特 监 狱 的 大 门 ， 安 德 烈 亚 斯 · 巴 德 尔 和 古 德 伦 · 恩 斯 林 等 红 军 旅 高 级 成 员 得 到 了 自 由 。 作 为 交 换 ， “ 红 军 旅 ” 将 被 改 编 为 新 生 的 革 命 团 体 的 附 属 组 织 。 在 我 们 和 阿 尔 巴 尼 亚 的 大 力 推 动 下 ， 德 国 共 产 党 / 马 克 思 列 宁 主 义 、 德 国 共 产 党 （ 重 建 组 织 ） 、 共 产 主 义 者 联 盟 、 德 国 共 产 主 义 工 人 联 盟 、 德 共 重 建 工 人 联 盟 和 西 德 共 产 主 义 者 联 盟 等 组 织 在 汉 堡 正 式 宣 布 合 并 为 德 国 马 列 主 义 革 命 党 。 新 的 党 组 织 确 定 了 以 维 利 · 迪 克 胡 特 主 席 为 核 心 的 中 央 委 员 会 。 《 人 民 日 报 》 在 第 二 天 发 文 庆 祝 西 德 人 民 在 摆 脱 美 帝 国 主 义 枷 锁 的 斗 争 有 了 新 的 主 心 骨 。 “ 红 军 旅 ” 和 “ 革 命 小 组 ” 被 改 组 为 由 马 列 主 义 革 命 党 领 导 的 “ 德 意 志 人 民 武 装 力 量 ” ， 他 们 向 我 们 保 证 将 减 少 革 命 恐 怖 活 动 ， 转 向 人 民 战 争 理 论 ， 以 积 极 谋 求 在 学 生 和 工 人 之 间 发 展 潜 在 的 成 员 和 同 情 者 。 地 拉 那 也 宣 布 支 持 西 德 人 民 团 结 起 来 的 斗 争 。||在 革 命 派 共 产 党 人 联 合 起 来 的 情 况 下 ， 基 民 盟 / 基 社 盟 开 始 动 员 支 持 者 施 压 施 密 特 政 府 ， 而 社 民 党 - 自 民 党 政 府 不 得 不 在 国 内 外 的 压 力 下 宣 布 组 织 跨 党 派 的 大 危 机 委 员 会 ， 西 德 进 入 了 事 实 上 的 紧 急 状 态 。 社 会 法 西 斯 主 义 者 又 一 次 对 革 命 派 举 起 了 屠 刀 … …";
			a.data[8] -= 80;
			a.data[9] -= 50;
			a.influencePRC += 10;
			a.empires[0].relations -= 80;
			a.empires[0].power -= 20;
			a.empires[1].power += 50;
		}
		if (result_num == 1)
		{
			text = " 我 们 将 西 德 革 命 者 的 名 单 交 给 了 西 德 政 府 ， 大 危 机 委 员 会 被 允 许 用 来 指 挥 抓 捕 左 翼 组 织 的 领 导 人 ， 政 府 很 快 组 织 了 一 场 特 别 行 动 ， 对 各 路 极 左 翼 “ 叛 匪 ” 进 行 “ 从 重 、 从 快 、 从 严 ” 的 打 击 。 作 为 交 换 ， 西 德 向 我 们 提 供 了 一 批 经 济 援 助 ， 并 将 派 遣 专 家 支 援 我 国 经 济 建 设 。 西 德 K 小 组 和 阿 尔 巴 尼 亚 谴 责 我 们 的 背 叛 行 为 ， 同 我 们 断 绝 了 关 系 。";
			a.data[9] -= 30;
			a.influencePRC += 5;
			a.empires[0].power += 50;
			a.empires[1].power -= 20;
			a.influencePRC -= 20;
			a.allcountries[17].Torg = true;
			if (a.data[60] == 0)
			{
				a.allcountries[20].proprc = false;
				a.allcountries[20].econ = false;
				a.allcountries[20].Torg = false;
				a.allcountries[20].okb = false;
			}
			a.empires[0].relations += 50;
			a.data[8] += 50;
			a.data[11] += 200;
		}
		if (result_num == 2)
		{
			text = " 我 们 没 有 对 西 德 的 问 题 作 出 任 何 回 应 ， 这 天 夜 里 ， “ 红 军 旅 ” 的 三 位 领 导 人 在 监 狱 里 自 尽 身 亡 ， 他 们 的 后 继 者 将 继 续 斗 争 。 而 K 小 组 也 在 继 续 发 展 着 — — 德 共 / 马 列 转 向 了 霍 查 主 义 ； 另 一 部 分 组 织 则 组 成 了 毛 派 的 德 国 马 列 党 ； K 小 组 中 的 部 分 人 员 转 向 了 环 境 运 动 以 及 和 平 运 动 ， 参 与 组 织 了 绿 党 。||施 密 特 政 府 召 集 了 跨 党 派 的 大 危 机 委 员 会 ， 国 家 实 施 了 为 期 4 5 天 的 “ 禁 止 接 触 法 ” ， 狱 中 的 红 军 旅 成 员 不 得 接 触 外 部 信 息 ， 以 免 狱 内 外 的 成 员 取 得 联 系 从 而 共 同 采 取 行 动 。";
		}
	}
}
