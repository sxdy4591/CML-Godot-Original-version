using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event670 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 关 心 群 众 生 活 、 注 意 工 作 方 法";
		text = " 自 毛 泽 东 主 席 发 动 文 化 大 革 命 以 来 ， 中 国 社 会 便 事 实 上 步 入 了 破 而 不 立 的 全 新 阶 段 ： 基 于 “ 在 无 产 阶 级 专 政 下 继 续 革 命 ” 与 “ 清 除 党 内 走 资 本 主 义 道 路 的 当 权 派 ” 这 两 大 理 论 ， 清 理 党 内 队 伍 的 风 暴 至 此 不 可 阻 挡 。 昔 日 由 党 发 挥 统 摄 全 局 作 用 ， 垂 直 领 导 各 群 众 组 织 开 展 工 作 的 做 法 也 自 然 遭 受 打 击 ， 各 种 试 图 彰 显 “ 群 众 主 动 性 ” 的 新 形 式 则 借 此 纷 纷 登 上 历 史 舞 台 ， 试 图 扮 演 主 角 ， 成 为 群 众 运 动 内 的 “ 主 流 ” 。 首 先 便 是 所 谓 “ 红 卫 兵 ” — — 激 进 分 子 们 在 文 革 时 代 宣 传 鼓 动 话 语 下 自 发 筹 建 的 社 团 ， 其 中 尤 以 校 内 学 生 最 为 典 型 。 他 们 通 过 背 靠 毛 泽 东 主 席 抛 弃 工 作 组 （ 即 文 革 早 期 与 党 垂 直 联 系 ， 试 图 直 接 以 行 政 手 腕 控 制 运 动 倾 向 的 派 遣 组 织 ） 与 “ 放 开 手 脚 闹 革 命 ” 的 指 示 一 时 风 头 无 二 ， 并 掀 起 红 色 恐 怖 的 政 治 清 算 浪 潮 。 然 而 ， 红 卫 兵 组 织 所 “ 成 就 ” 的 事 业 也 仅 限 于 此 。 面 对 全 国 范 围 的 无 政 府 状 态 ， 他 们 很 快 便 分 化 为 对 领 袖 权 威 选 择 性 引 用 的 各 路 流 派 相 互 攻 伐 ， 争 斗 不 休 ， 其 中 不 乏 有 派 别 试 图 引 入 党 内 元 老 与 解 放 军 等 既 有 权 威 “ 独 占 鳌 头 ” 。 上 述 乱 象 最 终 导 致 领 袖 转 而 押 注 “ 合 法 阶 级 斗 争 ” 的 诸 多 方 法 ： 串 联 运 动 被 复 课 与 上 山 下 乡 取 而 代 之 ； 主 张 干 部 、 军 方 与 革 命 群 众 “ 三 结 合 ” 的 革 命 委 员 会 也 在 此 后 诞 生 ， 红 卫 兵 由 此 改 组 为 其 政 治 隶 属 ； 以 及 为 调 停 红 卫 兵 间 斗 争 而 安 插 进 入 各 地 ， 形 成 “ 政 治 领 导 为 主 ” 格 局 的 “ 宣 传 队 ” 崛 起 。 后 者 主 要 成 员 来 自 工 人 、 农 民 与 解 放 军 队 伍 ， 在 得 到 来 自 中 央 的 背 书 后 迅 速 形 成 组 织 ， 旋 即 仰 仗 宣 传 鼓 动 形 成 的 强 大 政 治 支 持 成 为 各 机 关 内 不 可 或 缺 的 一 股 势 力 ， 试 图 在 文 革 时 代 重 建 部 门 间 联 系 ， 形 成 革 命 叙 事 统 摄 。 然 而 各 路 思 想 宣 传 队 本 身 缺 乏 训 练 ， 难 以 适 应 机 关 工 作 的 客 观 情 况 ， 乃 至 步 入70 年 代 以 来 ， 由 周 - 邓 等 人 启 动 的 一 系 列 旨 在 重 振 党 组 权 威 并 整 顿 社 会 秩 序 的 做 法 也 使 其 难 以 为 继 。||现 在 ， 是 时 候 处 理 这 一 历 史 遗 留 问 题 。 毛 泽 东 主 席 曾 言 ： “ 凡 属 正 确 的 领 导 ， 必 须 是 从 群 众 中 来 ， 到 群 众 中 去 ” 。 若 要 确 立 我 们 的 秩 序 ， 就 必 须 在 群 众 面 前 拿 出 新 方 案 ：|";
		if (a.resultOfEvents[25] == 2 && a.data[56] == 0 && a.modifies[3].active)
		{
			text += $"考 虑 到 党 内 已 然 成 为 文 革 新 秀 的 主 场 ， 对 相 关 问 题 的 争 执 实 际 上 只 能 表 现 为 两 种 倾 向 ： 一 方 试 图 恢 复 文 革 早 期 的 “ 放 开 手 脚 闹 革 命 ” 指 示 ， 在 宣 传 鼓 动 基 础 上 重 振 阶 级 队 伍 ； 另 一 方 则 试 图 通 过 掺 沙 子 方 法 实 行 改 组 ， 建 立 一 个 网 罗 革 命 积 极 分 子 、 党 员 与 既 有 组 织 ， 类 似 革 委 会 的 共 治 新 体 系 。 结 束 “ 黑 司 令 ” 独 裁 可 能 。 当 然 ， 仍 有 党 员 呼 吁 回 到 前17 年 党 主 持 群 众 组 织 领 导 一 切 的 好 时 代 ： 然 而 在 其 总 后 台 早 被 打 倒 的 情 况 下 ， 机 会 渺 茫 … … 但 如 果 能 得 到 {GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1]}{GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]} 同 志 背 书 ， 也 并 非 不 可 能 ？";
		}
		else if (a.resultOfEvents[25] == 2)
		{
			text += string.Format("考 虑 到 党 内 已 然 成 为 文 革 新 秀 的 主 场 ， 但 文 革 时 代 的 激 进 主 张 已 事 实 上 退 潮 ， 对 相 关 问 题 的 争 执 实 际 上 只 能 表 现 为 两 种 倾 向 ： 一 方 试 图 通 过 掺 沙 子 方 法 实 行 改 组 ， 建 立 一 个 网 罗 革 命 积 极 分 子 、 党 员 与 既 有 组 织 ， 类 似 革 委 会 的 共 治 新 体 系 。 结 束 “ 黑 司 令 ” 独 裁 可 能 。 另 一 方 则 呼 吁 回 到 前 1 7 年 党 主 持 各 路 群 众 组 织 领 导 一 切 ， 井 然 有 序 的 好 时 代 。 即 延 续 周 - 邓 二 人 的 整 顿 主 张 。 虽 说 其 总 后 台 早 被 打 倒 ， 可 在 清 党 胜 利 结 束 的 背 景 下 ， 我 们 为 什 么 还 要 抛 弃 本 就 行 之 有 效 的 东 西 ？", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
		}
		else
		{
			text += string.Format("目 前 ， 除 却 一 小 撮 抱 持 所 谓 “ 极 左 ” 思 想 的 党 员 外 ， 呼 吁 回 到 前17 年 党 主 持 各 路 群 众 组 织 领 导 一 切 ， 井 然 有 序 的 好 时 代 已 然 成 为 共 识 。 意 味 着 事 实 上 延 续 周 - 邓 二 人 的 整 顿 主 张 ：1975 年 召 开 的 共 青 团 筹 备 组 全 体 会 议 便 是 党 试 图 恢 复 对 青 年 运 动 控 制 权 的 先 声 。 而 我 们 要 做 的 就 只 是 在 不 同 程 度 上 将 其 落 实 而 已 … …", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] == 0 && a.modifies[3].active && a.data[1] >= 800 && a.resultOfEvents[25] == 2)
		{
			button_text[0] = "革 命 万 岁 ！ 工 人 阶 级 必 须 领 导 一 切 ！ “ 踢 开 党 委 闹 革 命 ” 的 口 号 是 极 好 的 ！";
		}
		else if (a.resultOfEvents[25] != 2)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 然 而 中 央 组 织 宣 传 组 内 无 人 可 用 … … 党 内 亦 无 思 想 基 础 … …";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 你 疯 了 吗 ？ ！ 党 可 不 会 给 自 己 判 死 刑 ！";
		}
		if (a.data[56] >= 0 && a.data[56] < 2 && a.resultOfEvents[25] == 2)
		{
			button_text[1] = "效 法 革 命 委 员 会 的 “ 三 结 合 ” 形 式 进 行 改 组 与 统 一 ， 实 现 群 众 运 动 大 联 合";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 另 起 炉 灶 毫 无 意 义";
		}
		if (a.data[56] > 0)
		{
			button_text[2] = "我 们 有 必 要 从 周 恩 来 与 邓 小 平 的 办 法 内 取 经 ： 革 命 ， 能 不 要 党 的 领 导 吗 ？";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 邓 小 平 这 个 人 是 不 抓 阶 级 斗 争 的 ， 历 来 不 提 这 个 纲 ！ 作 风 有 大 问 题 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 关 心 群 众 生 活 、 注 意 工 作 方 法";
		switch (result_num)
		{
		case 0:
			text = string.Format("试 图 对 文 革 早 期 激 进 倾 向 的 故 事 重 提 并 非 易 事 — — 尤 其 是 考 虑 到1968 年 时 毛 泽 东 主 席 发 表 制 止 “ 全 面 内 战 ” ， 要 求 引 入 宣 传 队 与 军 管 的 指 示 尚 在 ， 后 续 更 有 借 清 查 “ 五 · 一 六 ” 运 动 清 算 红 卫 兵 激 进 活 动 家 的 阴 影 ， 而 社 会 已 然 逐 步 习 惯 自 7 0 年 代 初 以 来 ， 由 周 恩 来 、 邓 小 平 等 人 逐 步 引 入 的 调 整 - 整 顿 新 节 奏 。 因 此 ， 中 国 共 产 党 必 须 在 许 多 问 题 上 “ 洗 心 革 面 ” ， 将 “ 颠 倒 后 的 历 史 再 颠 倒 回 来 ” ， 其 中 的 重 头 戏 当 属 下 述 四 项 ： 对 政 治 局 下 属 的 中 央 组 织 宣 传 组 进 行 改 组 ， 事 实 上 将 其 恢 复 到 彼 时 非 制 度 化 的 宣 传 鼓 动 兼 决 策 机 构 “ 中 央 文 革 小 组 ” 模 式 ； 彻 底 平 反 清 算 “ 五 · 一 六 分 子 ” 冤 案 ， 借 此 振 兴 激 进 主 义 运 动 ； 实 现 革 命 委 员 会 的 苏 维 埃 化 ： 清 理 阶 级 队 伍 、 向 《 上 海 人 民 公 社 宣 言 》 看 齐 与 集 权 回 前70 年 代 的 “ 一 元 化 领 导 ” 状 态 ， 并 依 托 这 一 开 放 平 台 整 合 - 培 训 思 想 宣 传 队 、 红 小 兵 等 多 种 组 织 形 式 （ 即 在 革 命 委 员 会 的 形 式 与 授 权 下 参 与 大 众 政 治 ， 排 除 党 内 走 资 派 独 裁 可 能 ） ； 以 及 将1966 年 时 由 江 青 同 志 强 调 的 系 列 原 则 （ 自 建 组 织 、 文 攻 武 卫 、 实 现 串 联 、 注 重 阶 级 意 识 等 ） 加 入 到 放 开 地 方 造 反 运 动 的 许 可 中 。 至 此 ， 我 们 在 文 革 的 第 十 一 个 年 头 写 好 了 堪 称 第 二 份 《 五 · 一 六 通 知 》 的 纲 领 性 文 件 ， 全 面 洗 牌 至 此 开 始 。|新 版 中 央 文 革 小 组 得 以 在 江 青 同 志 主 持 下 东 山 再 起 ， 将 各 项 资 源 向 激 进 派 倾 斜 ， 保 护 群 众 运 动 免 受 保 守 派 反 制 的 同 时 落 实 对 各 地 部 门 的 “ 斗 、 批 、 改 ” 方 针 — — 而 这 势 必 导 致 传 统 权 力 机 构 的 事 实 边 缘 化 ， 这 对 稳 坐 办 公 室 内 的 华 国 锋 等 “ 新 公 务 员 ” 来 说 可 不 是 好 事 。 以 红 卫 兵 五 大 领 袖 为 代 表 的 极 左 翼 活 动 家 借 助 平 反 浪 潮 纷 纷 复 出 ， 并 开 始 在 “ 上 山 下 乡 ” 运 动 后 重 启 全 国 各 地 高 校 的 红 卫 兵 运 动 ： 而 他 们 复 仇 怒 火 的 指 向 自 不 言 自 明 ： 某 些 背 靠 “ 圣 人 训 示 ” 的 角 色 注 定 要 倒 霉 了 … … 为 重 振 革 命 委 员 会 而 战 的 工 人 造 反 运 动 也 随 之 蓬 勃 发 展 ， 背 靠 新 权 威 的 工 代 会 、 农 代 会 、 红 代 会 正 吸 取 首 次 夺 权 教 训 ， 并 试 图 修 正 彼 时 “ 三 支 两 军 ” 路 线 导 致 的 事 实 上 的 军 方 一 边 倒 错 误 。 试 图 再 造 共 青 团 、 少 先 队 等 党 领 导 下 群 众 组 织 的 计 划 也 彻 底 搁 浅 ， 他 们 主 导 的 青 年 运 动 被 解 体 ， 完 全 成 为 自 发 活 动 家 与 红 小 兵 表 现 的 舞 台 ， 后 者 则 通 过 文 革 时 代 宣 传 鼓 动 与 革 委 会 政 治 领 导 履 职 ， 垂 直 管 理 与 科 层 制 至 此 不 复 存 在 。 此 情 此 景 只 叫 人 想 到60 年 代 风 味 ， 不 少 角 色 至 此 弹 起 “ 二 月 逆 流 ” 时 某 些 家 伙 老 调 ， 并 采 取 多 项 措 施 坚 决 抵 制 。 不 过 既 然 中 央 已 下 定 决 心 ， 那 定 不 会 和 首 次 运 动 那 般 轻 易 妥 协 … … 当 然 ， 成 败 全 仰 仗 我 们 能 否 彻 底 发 动 群 众 并 根 植 阶 级 意 识 。 毕 竟 ， 放 开 手 脚 闹 革 命 同 时 也 意 味 着 引 入 毒 草 风 险 … …|<color=red>现 在 是 拿 起 武 器 ， 保 卫 革 命 的 时 刻 了 … …</color>", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.data[1] -= 50;
			a.data[3] += 100;
			break;
		case 1:
			text = string.Format("考 虑 到 文 革 时 代 激 进 诉 求 的 退 潮 ， 党 委 机 关 越 来 越 能 泰 然 履 职 ， 且 先 前 筹 建 的 革 命 委 员 会 也 变 得 愈 加 建 制 化 ， 打 入 党 和 国 家 机 构 进 行 改 组 的 “ 合 法 阶 级 斗 争 ” 形 式 大 行 其 道 等 诸 多 现 实 。 党 内 持 激 进 思 想 的 同 志 不 得 不 再 度 选 择 战 略 退 却 ， 继 续 与 文 革 时 代 兴 起 的 “ 逍 遥 新 贵 ” 们 谋 求 某 种 共 治 格 局 ： 根 据 王 洪 文 同 志 在1975 年 共 青 团 代 表 大 会 筹 备 组 内 的 观 点 （ 即 将 原 共 青 团 组 织 与 民 间 红 卫 兵 运 动 合 二 为 一 ， 并 冠 以 “ 红 卫 兵 ” 之 名 ） ， 以 及 先 前 组 织 革 命 委 员 会 放 弃 巴 黎 公 社 的 全 面 选 举 口 号 ， 转 而 追 求 “ 干 部 、 群 众 与 军 方 ” 结 合 等 “ 历 史 经 验 ” 。 党 中 央 至 此 批 准 了 王 副 主 席 主 张 ， 并 得 到 华 主 席 背 书 的 系 列 决 议 ： 中 国 共 青 团 以 中 国 红 卫 兵 之 名 实 现 重 建 ， 革 命 干 部 与 积 极 群 众 在 其 中 各 占 半 壁 江 山 ， 其 基 层 组 织 需 在 地 方 革 命 委 员 会 “ 行 政 授 权 ” 与 党 委 “ 政 治 领 导 ” 下 开 展 活 动 ； 紧 随 其 后 的 则 是 全 国 总 工 会 、 少 先 队 （ 前 者 更 名 为 中 华 全 国 革 命 职 工 代 表 大 会 ， 后 者 被 定 为 中 国 红 小 兵 ） 等 接 受 类 似 改 组 原 则 ， 至 此 改 头 换 面 ， 配 套 革 命 委 员 会 形 式 并 引 入 激 进 草 根 运 动 这 一 活 水 的 原 有 党 群 组 织 ； 除 此 之 外 ， 党 中 央 还 决 定 大 规 模 整 合 尚 未 在 全 国 形 成 统 一 体 系 的 各 造 反 派 组 织 ， 试 图 以 党 作 为 纽 带 ， 将 其 纳 入 到 一 致 行 动 的 统 摄 外 围 下 。 其 典 型 便 是 以 各 地 农 代 会 为 基 础 ， 重 建 革 命 战 争 时 代 的 农 民 运 动 领 导 机 构 。 革 命 委 员 会 的 代 表 委 派 形 式 亦 得 到 拓 展 ： 妇 女 会 与 文 艺 工 作 组 （ 当 然 ， 这 自 然 是 来 自 中 央 组 织 宣 传 组 的 指 示 ） 得 以 在 其 中 获 得 一 席 ， 这 自 然 加 强 了 新 兴 势 力 对 于 各 领 域 的 发 言 权 。 大 多 数 党 员 对 党 组 织 的 实 质 扩 张 表 示 满 意 ， 群 众 也 因 参 政 道 路 扩 宽 ， 而 风 险 反 而 未 增 而 感 到 欣 喜 ， 社 会 秩 序 也 得 到 了 较 好 的 维 持 。 可 如 此 改 组 自 将 遭 遇 熟 悉 的 老 生 常 谈 ： 被 收 编 后 的 造 反 运 动 与 其 在 中 央 的 代 言 人 能 否 站 稳 脚 跟 ， 保 持 其 原 有 的 革 命 性 ， 并 实 现 澄 清 党 内 队 伍 与 革 命 委 员 会 的 目 标 ？ 党 委 内 的 老 同 志 们 会 满 意 同 来 自 三 教 九 流 的 无 资 历 行 外 人 实 现 长 期 共 治 吗 ？ 制 度 化 下 的 官 僚 主 义 繁 文 缛 节 与 党 组 机 构 的 膨 胀 会 让 往 日 的 红 卫 兵 们 重 蹈 苏 俄 时 代 工 农 检 察 院 覆 辙 ， 并 事 实 上 以 党 员 身 份 确 立 对 社 会 的 霸 权 ， 恢 复 前17 年 党 委 独 尊 ， 实 质 军 管 的 体 系 吗 ？ 而 毛 泽 东 主 席 恰 是 为 扭 转 这 一 倾 向 ， 试 图 在 新 基 础 上 建 立 社 会 主 义 而 发 动 无 产 阶 级 文 化 大 革 命 … … 只 有 时 间 会 告 诉 我 们 结 果 究 竟 如 何 … …", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.data[1] += 100;
			a.data[3] += 50;
			a.data[4] += 50;
			break;
		case 2:
			text = $" 考 虑 到 各 路 宣 传 队 在 无 外 力 支 持 的 情 况 下 本 就 持 续 萎 缩 ， 名 存 实 亡 。 而 整 顿 路 线 ， 重 建 我 党 权 威 已 然 成 为 有 党 内 领 导 人 背 书 的 政 治 正 确 ， 那 扫 除 鸡 肋 便 是 题 中 之 义 。 早 在 今 年 九 月 初 ， 便 有 同 志 提 出 “ 工 宣 队 问 题 要 解 决 ， 他 们 留 在 学 校 也 不 安 心 ” 的 相 关 指 示 ， 并 暗 示 应 当 迅 速 果 断 地 解 决 这 些 历 史 遗 留 问 题 ， 为 党 重 新 行 使 其 合 法 权 力 开 路 。 于 是 在1977 年11 月6 日 ， 中 共 中 央 转 发 教 育 部 党 组 的 请 示 报 告 ， 至 此 工 宣 队 、 军 宣 队 等 派 遣 组 织 全 部 撤 出 学 校 与 各 大 机 关 。 与 此 同 时 ， 将 全 总 、 共 青 团 等 组 织 工 作 再 度 纳 入 正 轨 的 筹 建 会 议 已 然 提 上 日 程 。 预 计 我 们 将 在 1978 年 时 彻 底 恢 复 上 述 机 构 的 基 本 职 能 ， 并 借 此 恢 复 党 对 于 全 国 青 年 与 工 人 运 动 的 集 中 统 一 领 导 。 除 却 激 进 派 外 的 多 数 党 内 同 志 对 此 表 示 欢 迎 ， 而 社 会 大 体 对 此 则 反 应 平 平 — — 考 虑 到 文 化 大 革 命 闹 得 风 风 火 火 ， 最 终 结 果 却 是 冷 冷 清 清 ， 他 们 坠 入 政 治 冷 感 也 是 自 然 结 果 。 当 然 ， 上 述 情 况 显 然 不 代 表 政 治 异 议 的 完 全 消 弭 ， 对 集 体 领 导 与 党 内 民 主 原 则 的 重 提 已 然 开 始 滋 生 另 类 反 对 派 ； 党 外 也 开 始 出 现 以 百 花 齐 放 为 旗 帜 掩 护 其 异 端 政 治 思 潮 。 可 和 以 往 必 须 无 需 直 面 无 政 府 状 态 的 情 况 相 比 ， 目 前 的 局 势 对 大 多 数 同 志 们 来 说 挺 好 的 。 下 一 步 便 是 计 划 将 重 点 转 向 更 加 值 得 关 注 的 事 ， 比 如 对 尾 大 不 掉 ， 越 来 越 和 党 委 职 能 冲 突 的 革 命 委 员 会 模 式 进 行 进 一 步 改 革 ； 或 是 用 为 文 革 善 后 为 由 ， 推 进 实 质 上 的 人 事 改 组 。 总 之 ， 党 和 国 家 的 各 项 事 务 都 正 在 {GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1]}{GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]} 同 志 的 特 别 关 照 下 兴 旺 起 来 ， 这 只 会 巩 固 早 在 党 内 扎 根 已 久 者 的 立 场 。";
			a.data[1] += 100;
			a.data[3] += 50;
			a.data[4] += 150;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
		GlobalScript.inst.old_modify_desc[6] = " 党 内 团 结 度+0.5 ， 思 想 自 由 化-0.2 ， 凝 聚 力+0.1 ， 国 际 声 誉+0.2 ， 与 苏 联 关 系-0.4 ， 与 美 国 关 系-0.2 |";
		if (GlobalScript.inst.gameState.event_done[548] && GlobalScript.inst.gameState.modifies[3].active)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[548] == 0)
			{
				GlobalScript.inst.old_modify_desc[6] += "<color=red>| 革 命 国 际 主 义 运 动 — — 深 化 国 间 经 济 - 政 治 一 体 化 ：</color>| 农 业 、 工 业 和 服 务 业+0.4 ； 生 活 水 平+0.2 ； 人 民 支 持 度+0.5 ； 凝 聚 力+0.1 ； 思 想 自 由 化-0.2 ； 与 美 苏 关 系-0.2 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[548] == 1)
			{
				GlobalScript.inst.old_modify_desc[6] += "<color=red>| 革 命 国 际 主 义 运 动 — — 共 产 党 情 报 局 ：</color>| 极 左 派+1 ； 极 左 派 力 量+1 ； 干 涉 点 数+3.0 ； 国 际 声 望+0.1 ； 与 美 苏 关 系-0.6 ； 国 际 影 响 力+0.5 ； 预 算-0.6 ； 特 工-0.6 ； 特 勤 援 助 的 效 果+1 ； 人 道 主 义 援 助 的 效 果+1 ； 中 国 一 次 性 外 交 声 援 的 效 果+3 ";
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[548] == 2)
			{
				GlobalScript.inst.old_modify_desc[6] += "<color=red>| 革 命 国 际 主 义 运 动 — — 深 化 国 间 经 济 - 政 治 一 体 化 ：</color>| 农 业 、 工 业 和 服 务 业+0.4 ； 生 活 水 平+0.2 ； 人 民 支 持 度+0.5 ； 凝 聚 力+0.1 ； 思 想 自 由 化-0.2 ； 与 美 苏 关 系-0.2";
				GlobalScript.inst.old_modify_desc[6] += "<color=red>| 革 命 国 际 主 义 运 动 — — 新 国 际 ：</color>| 极 左 派 +2 ； 极 左 派 力 量 +2 ； 干 涉 点 数 +5.0 ； 国 际 声 望+0.2 ； 国 际 声 望 低 于90.0 时 ， 国 际 声 望 额 外+0.1 ； 与 美 苏 关 系-1 ； 国 际 影 响 力+1 ； 预 算-1 ； 特 工-1 ； 军 力-1 ； 军 事 援 助 的 效 果+2 ； 特 勤 援 助 的 效 果+3 ； 人 道 主 义 援 助 的 效 果+3 ； 中 国 一 次 性 外 交 声 援 的 效 果+6";
			}
		}
		if (GlobalScript.inst.gameState.resultOfEvents[670] == 0 && GlobalScript.inst.gameState.modifies[3].active)
		{
			GlobalScript.inst.old_modify_desc[6] += "|<color=red>宣 传 鼓 动——群 众 自 己 解 放 自 己 ：</color>  党 内 团 结 度-1.5 ， 人 民 支 持 度+0.4 ， 思 想 自 由 化+0.4 ， 极 左 力 量+1 ； 每 5 点 宣 传 投 资 ： 党 内 团 结 度+0.1 ， 人 民 支 持 度+0.1 ， 思 想 自 由 化-0.1 ； 宣 传 投 资 不 低 于40 时 ， 党 内 团 结 度+0.7 ， 人 民 支 持 度+1.0 ， 思 想 自 由 化-1.0 ， 特 勤 网 络+2.0";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[670] == 1)
		{
			GlobalScript.inst.old_modify_desc[6] += "|<color=red>新 时 代 红 卫 兵——革 命 的 大 联 合 ：</color>  党 内 团 结 度 -0.2 ， 人 民 支 持 度 +0.2 ， 军 事 实 力 -0.4 ， 特 勤 网 络 -0.4 ； 每10 点 行 政 投 资 ： 党 内 团 结 度 +0.1 ， 人 民 支 持 度 +0.2 ， 思 想 自 由 化 -0.2 ， 军 事 实 力 +0.1 ， 特 勤 网 络 +0.1 ； 行 政 投 资 不 低 于50 时 ， 党 内 团 结 度 +1.0 ， 人 民 支 持 度 +1.0 ， 思 想 自 由 化 -1.0 ， 特 勤 网 络 +1.0";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[670] == 2)
		{
			GlobalScript.inst.old_modify_desc[6] += "|<color=red>东 南 西 北 中 ， 党 领 导 一 切 ：</color>  党 内 团 结 度 +1.0 ， 特 勤 网 络 +0.2 ， 腐 败 +0.2 ； 每10 点 行 政 投 资 ： 党 内 团 结 度 +0.2 ， 人 民 支 持 度 +0.1 ， 思 想 自 由 化 -0.1 ； 行 政 投 资 不 低 于40 时 ， 特 勤 网 络 +1.0 ， 腐 败 -0.2";
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.number_event = 456;
			SceneManager.LoadScene("Event");
		}
	}
}
