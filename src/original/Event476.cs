using EventsForDLC;
using UnityEngine;

public class Event476 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 富 特 · 本 恩 阴 谋 论 ？";
		text = " 自 1 9 8 3 年 工 党 左 派 政 府 实 行 激 进 的 社 会 主 义 政 策 以 来 ， 许 多 企 业 都 被 国 有 化 或 被 工 人 合 作 社 接 管 ； 撒 切 尔 政 府 遗 留 的 失 业 问 题 和 经 济 问 题 因 为 社 会 主 义 经 济 政 策 的 实 施 被 大 大 改 善 。 因 为 工 党 右 翼 被 边 缘 化 ， 内 阁 和 议 会 工 党 都 相 当 团 结 ， 政 府 在 工 人 中 很 受 欢 迎 ， 英 国 的 工 人 运 动 和 工 会 活 动 都 因 此 更 活 跃 了 。 政 府 将 在 不 久 后 推 行 此 前 承 诺 的 共 和 主 义 政 策 ， 对 上 议 院 和 君 主 制 开 刀 。\n 但 是 左 翼 和 共 和 主 义 的 高 歌 猛 进 和 工 人 阶 级 力 量 的 壮 大 让 英 国 的 保 守 势 力 十 分 不 满 。 来 自 星 期 一 俱 乐 部 的 沃 尔 特 · 沃 克 爵 士 获 得 了 “ 某 些 ” 势 力 的 资 助 （ 显 然 是 英 国 贵 族 和 垄 断 资 产 阶 级 ） ， 牵 头 组 织 了 一 个 秘 密 团 体 ， 据 信 ， 军 方 的 国 防 参 谋 长 彭 英 武 、 英 格 兰 银 行 行 长 罗 伯 特 · 利 - 彭 伯 顿 和 军 情 五 处 等 个 人 和 团 体 都 已 参 与 其 中 ， 他 们 正 准 备 发 起 针 对 左 翼 政 府 的 政 变 。 一 时 间 ， 英 国 的 上 空 布 满 了 阴 云 与 危 机 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.allcountries[21].econ && a.allcountries[21].Gosstroy == 1 && ((a.allcountries[85].Gosstroy == 1 && a.allcountries[86].Gosstroy == 1) || (a.allcountries[85].Gosstroy == 1 && (a.allcountries[87].Gosstroy == 1 || a.allcountries[87].SubGosstroy == 0)) || ((a.allcountries[87].Gosstroy == 1 || a.allcountries[87].SubGosstroy == 0) && a.allcountries[86].Gosstroy == 1)) && a.influencePRC >= 600 && a.data[8] + a.data[36] >= 50 && a.data[9] >= 100)
		{
			button_text[0] = " 曝 光 阴 谋 ， 帮 助 组 织 工 人 民 兵 ， 团 结 左 翼 和 民 主 进 步 势 力 ， 准 备 反 击 ！";
		}
		else if (a.allcountries[21].Gosstroy != 1)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 法 国 不 会 愿 意 和 我 们 合 作 … …";
		}
		else if (!a.allcountries[21].econ)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 和 法 国 的 合 作 不 够 紧 密 … …";
		}
		else if (a.data[8] + a.data[36] < 50)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 那 么 多 钱 … …";
		}
		else if (a.data[9] < 100)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 的 特 工 分 身 乏 术 … …";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 西 欧 的 社 会 主 义 力 量 太 薄 弱 了 … …";
		}
		button_text[1] = " 我 们 正 在 等 待 最 后 的 结 果 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 富 特 · 本 恩 阴 谋 论 ？";
		if (result_num == 0)
		{
			text = " 我 们 的 大 使 馆 将 阴 谋 告 诉 了 工 党 政 府 ， 并 联 系 到 英 共 （ 马 列 ） 主 席 雷 格 · 伯 奇 和 英 国 共 产 党 左 派 等 在 工 人 和 工 会 中 有 较 大 影 响 力 共 产 主 义 势 力 和 社 会 主 义 政 党 ， 帮 助 他 们 与 工 党 政 府 组 建 了 保 卫 社 会 主 义 和 民 主 的 统 一 战 线 ， 最 后 由 工 会 牵 头 组 织 了 工 人 民 兵 部 队 。 在 此 之 后 ， 政 府 向 媒 体 公 布 了 阴 谋 。 政 变 一 经 披 露 ， 便 引 起 轩 然 大 波 ， 民 众 纷 纷 走 出 家 门 ， 喊 出 “ 保 护 民 主 、 保 卫 社 会 主 义 ！ ” 的 口 号 。 学 生 组 织 罢 课 ， 工 人 组 织 了 罢 工 ， 包 围 了 保 守 党 的 总 部 、 军 情 五 处 和 军 事 部 门 。 西 欧 的 各 个 社 会 主 义 国 家 特 别 是 法 国 对 英 国 的 局 势 表 示 深 切 关 注 ， 他 们 表 示 “ 可 以 考 虑 在 适 当 时 候 发 挥 国 际 主 义 精 神 ” 。\n 最 后 ， 阴 谋 集 团 陷 入 了 完 全 的 被 动 。 在 工 人 民 兵 的 帮 助 下 ， 英 国 政 府 趁 此 机 会 彻 底 取 缔 了 右 翼 势 力 ， 粉 碎 了 阴 谋 ， 它 的 参 与 者 和 资 助 者 都 被 逮 捕 ， 军 队 也 被 清 洗 。 经 此 一 役 ， 本 恩 重 申 了 他 在 8 0 年 代 初 提 出 的 原 则 ， 他 将 在 最 初 的 几 周 内 “ 将 布 鲁 塞 尔 所 袭 夺 的 一 切 ， 系 数 归 还 给 威 斯 敏 斯 特 宫 。 随 后 ， 便 要 废 除 上 议 院 ” 。 事 实 上 ， 确 实 是 如 此 做 的 。 在 一 次 全 民 公 投 后 ， 上 议 院 便 被 废 除 了 。 这 随 后 便 导 致 了 新 的 问 题 ： 在 传 统 与 判 例 法 均 遭 质 疑 的 情 况 下 ， 英 国 君 主 制 的 存 在 的 基 础 也 已 被 动 摇 。 随 后 ， 在 英 国 特 色 经 验 主 义 与 英 伦 保 守 主 义 热 情 盛 行 的 大 背 景 下 ， 就 君 主 制 是 否 应 当 延 续 的 问 题 ， 得 出 了 合 乎 逻 辑 的 结 论 — — 既 然 传 统 已 经 消 失 ， 那 君 主 自 然 也 要 步 其 后 尘 。 本 恩 在 英 国 议 会 内 慷 慨 陈 词 ， 宣 布 “ 断 头 台 将 为 每 位 女 王 按 需 分 配 ” ， 倘 若 君 主 想 阻 挡 社 会 主 义 胜 利 进 军 的 脚 步 ， 那 就 等 着 “ 成 为 下 一 个 玛 丽 · 安 托 瓦 内 特 ” 。 随 后 举 行 的 全 民 公 决 通 过 了 英 国 的 新 宪 法 ， 该 国 正 式 成 为 一 个 世 俗 的 联 邦 制 共 和 国 ， 英 格 兰 、 苏 格 兰 和 威 尔 士 分 别 建 立 了 各 自 的 人 民 议 会 ， 北 爱 尔 兰 问 题 也 正 在 谈 判 。 不 列 颠 各 地 本 就 不 小 的 自 治 权 得 到 了 进 一 步 的 扩 张 。 政 变 使 本 恩 认 识 到 了 此 前 工 党 的 社 会 主 义 政 治 纲 领 的 不 彻 底 性 ， 他 们 决 定 同 英 国 共 产 党 左 派 、 英 共 （ 马 列 ） 等 工 人 阶 级 领 导 的 各 种 政 治 力 量 组 成 人 民 民 主 联 盟 ， 并 对 资 产 阶 级 、 地 主 和 贵 族 采 取 更 加 强 硬 的 政 策 ， 对 英 国 进 行 更 彻 底 的 改 造 。 ";
			a.allcountries[92].Gosstroy = 1;
			a.allcountries[92].SubGosstroy = 1;
			a.allcountries[92].proprc = true;
			a.allcountries[92].Torg = true;
			a.influencePRC += 50;
			a.empires[0].relations -= 80;
			a.data[8] -= 50;
			a.data[9] -= 100;
		}
		if (result_num != 1)
		{
			return;
		}
		if (a.empires[0].power <= a.empires[1].power && !a.allcountries[7].isNATO && ((a.allcountries[85].Gosstroy == 1 && a.allcountries[86].Gosstroy == 1) || (a.allcountries[85].Gosstroy == 1 && a.allcountries[87].Gosstroy == 1) || (a.allcountries[87].Gosstroy == 1 && a.allcountries[86].Gosstroy == 1)))
		{
			text = " 英 国 共 产 党 左 派 等 在 工 人 和 工 会 中 有 较 大 影 响 力 共 产 主 义 势 力 、 多 个 社 会 主 义 政 党 与 工 党 政 府 组 建 了 保 卫 社 会 主 义 和 民 主 的 统 一 战 线 ， 并 由 工 会 牵 头 组 织 了 工 人 民 兵 部 队 。 在 此 之 后 ， 政 府 向 媒 体 公 布 了 阴 谋 。 政 变 一 经 披 露 ， 便 引 起 轩 然 大 波 ， 民 众 纷 纷 走 出 家 门 ， 喊 出 “ 保 护 民 主 、 保 卫 社 会 主 义 ！ ” 的 口 号 。 学 生 组 织 罢 课 ， 工 人 组 织 了 罢 工 ， 包 围 了 保 守 党 的 总 部 、 军 情 五 处 和 军 事 部 门 。 苏 东 阵 营 以 及 西 欧 的 各 个 社 会 主 义 国 家 对 英 国 的 局 势 表 示 深 切 关 注 ， 他 们 表 示 “ 可 以 考 虑 在 适 当 时 候 发 挥 国 际 主 义 精 神 ” 。\n 最 后 ， 阴 谋 集 团 陷 入 了 完 全 的 被 动 。 在 工 人 民 兵 的 帮 助 下 ， 英 国 政 府 趁 此 机 会 彻 底 取 缔 了 右 翼 势 力 ， 粉 碎 了 阴 谋 ， 它 的 参 与 者 和 资 助 者 都 被 逮 捕 ， 军 队 也 被 清 洗 。 经 此 一 役 ， 本 恩 重 申 了 他 在 8 0 年 代 初 提 出 的 原 则 ， 他 将 在 最 初 的 几 周 内 “ 将 布 鲁 塞 尔 所 袭 夺 的 一 切 ， 系 数 归 还 给 威 斯 敏 斯 特 宫 。 随 后 ， 便 要 废 除 上 议 院 ” 。 事 实 上 ， 确 实 是 如 此 做 的 。 在 一 次 全 民 公 投 后 ， 上 议 院 便 被 废 除 了 。 这 随 后 便 导 致 了 新 的 问 题 ： 在 传 统 与 判 例 法 均 遭 质 疑 的 情 况 下 ， 英 国 君 主 制 的 存 在 的 基 础 也 已 被 动 摇 。 随 后 ， 在 英 国 特 色 经 验 主 义 与 英 伦 保 守 主 义 热 情 盛 行 的 大 背 景 下 ， 就 君 主 制 是 否 应 当 延 续 的 问 题 ， 得 出 了 合 乎 逻 辑 的 结 论 — — 既 然 传 统 已 经 消 失 ， 那 君 主 自 然 也 要 步 其 后 尘 。 本 恩 在 英 国 议 会 内 慷 慨 陈 词 ， 宣 布 “ 断 头 台 将 为 每 位 女 王 按 需 分 配 ” ， 倘 若 君 主 想 阻 挡 社 会 主 义 胜 利 进 军 的 脚 步 ， 那 就 等 着 “ 成 为 下 一 个 玛 丽 · 安 托 瓦 内 特 ” 。 随 后 举 行 的 全 民 公 决 通 过 了 英 国 的 新 宪 法 ， 该 国 正 式 成 为 一 个 世 俗 的 联 邦 制 共 和 国 ， 英 格 兰 、 苏 格 兰 和 威 尔 士 分 别 建 立 了 各 自 的 人 民 议 会 ， 北 爱 尔 兰 问 题 也 正 在 谈 判 。 不 列 颠 各 地 本 就 不 小 的 自 治 权 得 到 了 进 一 步 的 扩 张 。 政 变 使 本 恩 认 识 到 了 此 前 工 党 的 社 会 主 义 政 治 纲 领 的 不 彻 底 性 ， 他 们 决 定 同 英 国 共 产 党 左 派 和 各 个 社 会 主 义 政 党 等 工 人 阶 级 领 导 的 各 种 政 治 力 量 组 成 人 民 民 主 联 盟 ， 并 对 资 产 阶 级 、 地 主 和 贵 族 采 取 更 加 强 硬 的 政 策 ， 对 英 国 进 行 更 彻 底 的 改 造 。 耐 人 寻 味 的 是 ， 新 政 府 立 即 宣 布 将 加 强 与 以 苏 联 为 首 的 社 会 主 义 阵 营 的 合 作 。 ";
			a.allcountries[92].Gosstroy = 1;
			a.allcountries[92].SubGosstroy = 1;
			a.allcountries[92].prosov = true;
			GlobalScript.inst.gameState.empires[1].leaders[4].support++;
			a.empires[1].power += 50;
			a.data[147] = 8;
			return;
		}
		text = " 英 国 军 队 在 但 没 有 事 先 通 知 唐 宁 街 的 情 况 下 占 领 了 希 思 罗 机 场 ， 理 由 是 爱 尔 兰 共 和 军 可 能 在 机 场 采 取 的 恐 怖 行 动 。 军 方 宣 布 了 伦 敦 的 戒 严 ， 并 表 示 这 是 一 次 有 计 划 的 军 事 演 习 ， 但 是 很 快 演 习 变 成 了 政 变 。 军 队 包 围 了 威 斯 敏 斯 特 宫 、 白 厅 和 唐 宁 街 十 号 。 工 人 自 发 地 筑 起 街 垒 ， 准 备 同 忠 于 政 府 的 警 卫 部 队 一 起 抵 抗 政 变 军 队 。 本 恩 和 富 特 最 后 屈 服 了 ， 他 们 决 定 放 弃 无 谓 的 流 血 的 牺 牲 ， 工 人 卫 队 被 劝 退 。 最 后 ， 工 党 内 阁 “ 自 愿 “ 辞 职 了 ， 他 们 被 保 证 不 会 被 清 算 。 沃 尔 特 · 沃 克 爵 士 宣 布 议 会 暂 时 休 会 ， 牵 头 组 建 了 囊 括 前 极 右 翼 团 体 ” 民 事 援 助 “ 和 极 端 保 守 派 团 体 “ 星 期 一 俱 乐 部 ” 成 员 的 民 族 团 结 政 府 ， 实 行 高 度 保 守 主 义 和 反 共 主 义 ， 新 政 府 表 现 出 了 浓 厚 的 家 长 制 色 彩 ； 新 颁 布 的 法 律 对 工 会 做 出 了 严 苛 的 限 制 ， 左 翼 势 力 被 大 量 打 击 ， 经 济 也 开 始 重 新 自 由 化 。 耐 人 寻 味 的 是 ， 新 政 府 立 即 开 始 与 美 国 恢 复 关 系 。 对 于 西 方 来 说 ， 这 对 他 们 所 谓 “ 民 主 ” 而 言 ， 是 讽 刺 的 一 天 … … ";
		a.allcountries[92].Gosstroy = 0;
		a.allcountries[92].SubGosstroy = 7;
		a.allcountries[92].Vyshi = true;
		if (a.allcountries[0].isNATO)
		{
			a.allcountries[92].isNATO = true;
		}
		a.allcountries[92].Torg = false;
		a.influencePRC += 50;
		a.empires[0].power += 50;
		a.data[147] = 7;
	}
}
