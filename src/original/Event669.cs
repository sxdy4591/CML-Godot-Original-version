using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event669 : EventsSecond
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
		name = " 如 切 如 磋 ， 如 琢 如 磨";
		text = string.Format(" <size=36>主 席 同 志 ， 现 在 向 您 报 告 一 下 我 国 目 前 的 教 育 情 况 。 如 您 所 见 ， 自 1 9 4 9 年 新 中 国 成 立 以 来 ， 我 国 根 据 实 际 情 况 ， 制 定 了 一 套 重 量 轻 质 、 倾 向 农 村 的 德 智 体 全 面 教 育 方 案 。 对 此 ， 毛 泽 东 也 提 出 了 教 育 的 三 个 关 键 ： “ 一 是 党 委 领 导 ； 二 是 群 众 路 线 ； 三 是 把 教 育 和 生 产 劳 动 起 来 。 ” 而 到 了 文 革 时 期 ， “ 千 钧 霹 雳 开 新 宇 ， 万 里 东 风 扫 残 云 ” 的 大 背 景 来 临 ， 大 革 命 的 第 一 炮 便 是 打 向 了 我 国 教 育 阵 线 。 首 先 是 即 墨 第 一 中 学 的 造 反 派 夺 权 学 校 ， 要 求 国 家 改 变 现 有 体 制 — — 即 苏 联 式 教 育 体 制 和 旧 社 会 儒 家 教 育 方 法 结 合 的 一 种 精 英 式 教 育 。 造 反 派 认 为 现 有 教 育 体 制 下 只 会 让 农 村 为 城 市 “ 输 血 ” ， 将 农 村 的 人 才 资 源 源 源 不 断 地 输 出 到 城 市 ， 扩 大 城 乡 、 工 农 差 距 ， 这 显 然 是 与 党 的 承 诺 不 符 合 的 。 除 此 之 外 ， 要 求 革 命 的 学 生 也 提 出 实 施 工 农 学 结 合 ， 既 是 相 应 毛 主 席 所 说 的 “ 教 育 与 生 产 劳 动 结 合 ” 的 号 召 ， 也 是 为 解 决 乡 村 教 育 一 个 长 期 顽 疾 — — 预 算 不 足 。 还 有 对 教 材 新 编 、 师 生 关 系 民 主 化 等 激 进 要 求 都 被 造 反 派 们 一 一 摆 在 了 台 面 上 ， 而 这 最 后 得 到 了 以 毛 泽 东 为 中 心 的 中 央 左 派 的 集 体 支 持 。||因 此 ， 一 次 前 所 未 有 的 教 育 革 新 在 我 国 各 地 推 广 开 来 。 而 事 实 证 明 ， 这 一 新 式 教 育 体 制 对 高 等 教 育 体 制 目 前 还 是 消 极 作 用 的 ， 对 高 校 师 资 造 成 了 不 小 的 负 面 影 响 。 但 与 其 相 对 的 是 ， 中 小 学 教 育 得 到 了 迅 速 的 发 展 。 在 工 农 小 组 进 驻 乡 村 小 学 后 ， 和 学 校 合 作 的 各 种 农 场 工 厂 的 创 收 使 得 不 少 财 政 窘 迫 的 学 校 焕 如 新 生 ， 从 而 有 余 力 实 施 那 些 一 种 被 旧 有 领 导 层 挂 在 嘴 边 的 惠 及 政 策 。 广 大 农 村 真 正 落 实 了 如 社 会 主 义 教 育 目 标 所 预 期 的 全 免 费 教 育 ， 且 日 益 兴 盛 的 教 育 民 主 风 也 推 动 了 教 育 学 规 律 认 知 的 进 步 ， 一 些 地 方 甚 至 着 手 让 学 生 和 老 师 一 起 备 课 、 一 起 讲 课 ， 这 大 大 改 变 了 过 去 乡 村 师 资 力 量 不 足 的 状 况 。 而 教 材 方 面 也 有 很 大 改 善 ， 原 先 “ 理 论 至 上 ” 的 统 一 性 教 材 交 给 各 地 进 行 因 地 制 宜 地 自 主 制 定 ， 落 后 地 区 偏 向 实 践 方 法 补 课 ， 而 发 展 较 好 的 地 区 则 侧 重 理 论 性 ， 这 无 疑 是 我 们 教 学 实 践 的 又 一 伟 大 创 新 。 在 如 此 的 规 划 下 ， 虽 然 我 国 高 等 教 育 方 面 发 展 并 不 显 著 ， 但 广 大 农 村 和 贫 穷 地 区 的 教 育 事 业 得 到 了 飞 跃 式 的 发 展 ， 已 然 是 部 分 实 现 了 毛 泽 东 曾 提 出 的 “ 村 村 有 中 小 ， 县 市 有 大 高 ” 的 宏 伟 目 标 。||当 然 ， 对 于 这 一 制 度 不 是 说 没 有 批 评 。 实 际 上 ， 教 育 政 策 是 我 国 在 文 革 时 期 最 具 争 议 的 一 个 方 面 。 理 所 应 当 的 ， 高 级 知 识 分 子 屡 次 批 评 我 国 忽 略 高 等 教 育 ， 认 为 这 种 对 数 量 的 盲 目 堆 积 只 会 在 增 加 我 国 财 政 负 担 、 成 为 另 一 个 “ 平 等 主 义 乌 托 邦 ” 的 同 时 打 压 真 正 需 要 投 入 的 尖 端 科 研 领 域 。 而 党 内 亦 有 不 少 高 级 官 员 批 评 我 国 教 育 制 度 无 非 是 又 一 次 的 “ 左 倾 浮 夸 风 ” 错 误 ， 纷 纷 要 求 把 重 心 放 回 高 等 学 校 ， 进 而 重 建 两 套 教 育 体 制 ， 以 培 养 真 正 有 利 于 我 国 先 进 科 研 事 业 发 展 的 人 才 队 伍 。 而 党 内 极 左 派 也 针 锋 相 对 ， 表 示 现 行 体 制 是 推 动 三 大 差 别 消 亡 的 利 器 ， 并 申 明 对 现 行 无 产 阶 级 教 育 制 度 的 破 坏 便 是 对 共 产 主 义 信 念 的 扭 曲 ， 也 是 对 最 广 大 人 民 的 背 叛 。 对 此 ， 各 党 各 派 各 方 势 力 都 殷 切 看 向 党 中 央 ， 盼 望 着 一 个 最 终 裁 决 来 定 夺 我 国 未 来 几 十 年 的 教 育 路 线 发 展 。 为 此 ， 中 央 政 治 局 已 经 整 理 了 三 份 方 案 供 您 参 考 ， 请 您 对 此 进 行 表 态 。</size>", '\n');
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] == 0)
		{
			button_text[0] = "向 狂 飙 突 进 迈 进 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 不 可 能 ， 各 地 教 师 群 体 已 经 受 够 你 们 了";
		}
		if (a.data[56] > 0 && a.data[56] < 3)
		{
			button_text[1] = "拨 乱 反 正 ， 正 本 清 源 ， 回 归 正 统 社 会 主 义 教 育 路 线";
		}
		else if (a.data[56] == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 你 要 公 开 与 五 · 七 指 示 对 着 干 ？";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 刚 摆 脱 文 革 的 余 波 又 要 一 头 扎 进 苏 式 僵 化 体 制 ？";
		}
		if (a.data[56] > 2)
		{
			button_text[2] = "尊 重 知 识 、 尊 重 人 才 、 尊 师 重 教";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 看 来 衍 圣 公 不 在 彼 岸 在 此 岸 啊";
		}
		if (a.data[56] <= 1 && a.leader.name_1 == 2 && a.leader.name_2 == 2)
		{
			button_text[3] = "我 有 一 点 我 自 己 的 意 见 … … 应 当 全 国 学 人 民 解 放 军 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 恕 我 直 言 ， 党 中 央 不 需 要 您 的 其 他 意 见";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 如 切 如 磋 ， 如 琢 如 磨";
		switch (result_num)
		{
		case 0:
			text = string.Format("列 宁 明 确 提 出 , 在 无 产 阶 级 专 政 时 期 , 社 会 主 义 教 育 的 总 目 标 在 于 培 养 最 后 实 现 共 产 主 义 的 一 代 人 。 整 个 教 育 应 该 贯 彻 无 产 阶 级 斗 争 的 精 神 ， 即 为 推 翻 资 产 阶 级 ， 消 灭 阶 级 ， 消 灭 一 切 人 剥 削 人 的 现 象 而 斗 争 的 精 神 。 因 此 ， 社 会 主 义 教 育 必 须 以 最 广 大 群 众 的 利 益 为 核 心 ， 为 普 罗 大 众 服 务 。 绩 效 主 义 导 向 下 的 教 育 制 度 或 许 短 期 内 能 够 让 我 国 尖 端 人 才 队 伍 得 到 较 快 扩 充 ， 但 长 此 以 往 我 国 的 人 才 结 构 和 各 地 知 识 资 源 只 会 越 来 越 畸 形 ， 最 终 形 成 同 发 达 资 本 主 义 国 家 一 般 的 知 识 垄 断 局 面 。 更 何 况 ， 中 国 的 道 路 本 就 不 应 该 是 以 两 大 超 级 大 国 路 线 为 绝 对 标 杆 的 “ 制 度 拜 物 教 ” ， 立 足 于 当 下 农 业 社 会 转 型 的 大 面 积 初 中 等 教 育 和 社 会 主 义 新 式 关 系 发 展 的 硬 要 求 ， 着 力 提 高 全 民 素 质 才 应 该 是 我 国 教 育 的 重 中 之 重 。||最 终 ， 您 一 锤 定 音 ， 拍 板 我 国 将 继 续 延 续 毛 泽 东 同 志 所 提 出 的 无 产 阶 级 教 育 路 线 。 全 国 教 育 资 源 将 继 续 向 农 村 倾 斜 ， 并 逐 渐 开 始 将 教 学 设 施 、 教 学 器 材 等 客 观 教 学 需 求 纳 入 援 助 范 围 之 内 ， 争 取 “ 提 量 又 提 质 ” 。 而 对 于 过 去 编 写 不 够 成 熟 的 地 方 革 委 会 自 编 教 材 ， 中 央 要 求 各 地 成 立 教 学 教 材 委 员 会 ， 采 取 一 些 先 进 地 区 的 经 验 ， 尽 可 能 地 在 符 合 当 地 实 际 的 情 况 下 实 现 技 术 教 育 和 理 论 教 育 的 内 容 平 衡 。 除 此 之 外 ， 我 们 也 没 有 忘 记 在 教 育 改 革 中 最 重 要 的 一 环 — — 培 养 批 判 性 思 维 ， 大 量 的 师 生 大 字 报 和 公 开 辩 论 使 得 学 生 们 得 到 了 逻 辑 推 理 和 分 析 的 充 分 训 练 ， 过 往 “ 死 读 书 ” 的 东 亚 儒 家 模 式 在 我 国 越 发 少 见 。 并 且 ， 改 革 初 期 课 堂 秩 序 的 混 乱 也 有 所 改 善 ， 教 师 群 体 在 新 制 度 下 找 到 了 一 套 更 为 民 主 的 新 办 法 ， 处 理 问 题 学 生 的 困 难 逐 渐 减 轻 。 不 仅 如 此 ， 一 种 新 式 的 学 校 民 主 文 化 和 价 值 观 正 萌 芽 于 一 种 前 所 未 有 的 教 学 制 度 ， 而 它 将 依 旧 稳 定 发 育 于 我 国 坚 决 推 行 的 历 史 性 革 新 之 中 。 这 一 切 最 终 会 回 馈 于 我 国 的 国 民 素 养 和 科 研 领 域 ， 并 结 出 累 累 硕 果 。", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.data[1] -= 50;
			a.data[3] += 100;
			break;
		case 1:
			text = string.Format("尽 管 在 文 革 时 期 的 教 育 政 策 一 定 程 度 上 体 现 了 我 国 领 导 人 的 平 等 主 义 情 结 ， 可 必 须 承 认 的 是 ， 缺 乏 物 质 的 平 等 只 能 是 一 种 匮 乏 的 公 有 。 而 当 下 恰 恰 是 我 国 在 推 动 农 业 社 会 转 型 的 关 键 环 节 ， 人 才 分 化 和 培 养 高 速 化 才 是 我 们 现 状 下 的 硬 要 求 。 在 内 外 敌 人 压 力 日 益 增 加 的 情 况 下 ， 我 们 不 能 一 等 再 等 ， 必 须 利 用 一 切 力 量 和 一 切 方 法 让 我 国 的 全 民 素 质 和 科 研 水 平 在 短 期 内 发 生 质 的 提 升 。 延 缓 速 度 就 是 落 后 ， 而 落 后 者 是 要 挨 打 的 ！||最 终 ， 您 一 锤 定 音 ， 选 择 了 如 同 苏 联 三 四 十 年 代 般 的 高 度 专 业 化 教 育 道 路 。 过 往 普 通 教 育 中 实 用 主 义 的 教 学 设 计 被 彻 底 推 翻 ， 转 而 注 重 有 范 围 且 精 确 的 系 统 知 识 。 而 各 类 教 学 任 务 也 按 照 更 加 严 格 的 教 学 计 划 和 教 学 大 纲 进 行 ， 并 严 格 遵 照 事 先 安 排 好 的 课 程 表 开 展 。 而 苏 式 教 育 的 开 山 鼻 祖 凯 洛 夫 理 论 则 重 新 被 教 育 界 奉 为 座 上 宾 ， 各 级 教 学 单 位 积 极 落 实 保 证 教 师 的 领 导 作 用 ， 确 保 课 堂 有 序 有 纪 律 。 原 先 的 大 字 报 形 式 由 于 “ 破 坏 课 堂 秩 序 和 师 生 关 系 ” 的 原 因 被 统 统 废 除 ， 但 我 们 依 旧 尊 重 了 学 生 在 教 学 中 的 主 观 能 动 性 。 与 此 同 时 ， 我 国 大 量 增 办 各 种 师 范 学 校 ， 争 取 在 教 育 计 划 末 时 在 全 国 范 围 内 实 现 专 业 教 师 的 全 方 面 覆 盖 。 义 务 教 育 时 间 也 有 所 增 加 ， 以 更 多 时 间 来 提 高 学 生 的 全 面 素 养 。 最 后 ， 各 类 专 业 成 人 学 校 也 开 始 有 序 扩 张 ， 函 授 教 育 、 业 余 教 育 和 再 培 训 得 到 了 我 国 行 政 机 关 的 充 分 支 持 ， 以 提 高 教 师 的 一 般 文 化 水 平 和 专 业 水 平 。 除 此 之 外 ， 高 等 教 育 的 质 量 问 题 也 得 到 了 高 度 重 视 ， 新 生 选 拔 、 专 业 课 程 、 教 研 设 施 和 水 平 方 面 等 得 到 了 较 快 提 升 ， 高 等 教 育 系 统 日 益 规 范 化 标 准 化 。||最 终 ， 在 告 别 农 业 社 会 的 浪 漫 主 义 预 想 后 ， 我 们 回 到 了 真 正 社 会 主 义 的 教 育 事 业 正 轨 上 。 而 可 以 预 见 的 是 ， 这 套 系 统 最 终 将 为 我 们 的 社 会 主 义 国 家 提 供 全 方 面 的 人 才 ， 从 而 为 我 国 的 工 业 化 、 现 代 化 转 型 打 下 文 化 层 面 的 坚 实 基 础 。 尽 管 一 些 目 光 短 浅 者 说 我 们 这 是 在 搞 “ 新 式 儒 家 学 问 ” “ 填 鸭 式 教 育 ” “ 对 学 生 的 思 想 专 制 ” ， 但 历 史 的 风 会 毫 不 留 情 地 把 这 堆 垃 圾 吹 走 。", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.data[1] += 100;
			a.data[3] += 50;
			a.data[4] += 50;
			break;
		case 2:
			text = string.Format(" 在 洗 刷 百 年 国 耻 后 ， 民 族 的 、 科 学 的 、 大 众 的 全 民 教 育 已 经 成 为 我 国 所 追 求 的 预 定 目 标 ， 当 下 教 学 总 目 标 本 应 是 提 高 人 民 的 文 化 水 平 ， 培 养 国 家 需 要 的 建 设 人 才 。 但 文 革 一 殇 出 世 ， 各 地 教 学 随 之 瘫 痪 。 不 仅 大 大 拖 后 了 我 国 教 育 计 划 的 进 程 ， 还 严 重 亵 渎 了 中 华 民 族 伏 案 读 书 、 师 严 道 尊 的 民 族 性 格 。 反 智 主 义 的 民 粹 分 子 凭 借 着 党 中 央 的 靠 山 肆 意 妄 为 地 迫 害 我 国 的 知 识 分 子 和 教 学 队 伍 ， 并 且 从 人 格 和 价 值 方 面 全 面 否 定 文 人 书 生 ， 其 暴 烈 过 于 秦 始 皇 百 倍 。 如 今 大 祸 已 酿 ， 我 们 只 能 尽 可 能 从 这 场 浩 劫 中 恢 复 过 来 ， 力 图 弥 补 那 些 在 文 革 中 失 去 的 岁 月 ！||最 终 ， 您 一 锤 定 音 ， 确 立 了 为 “ 四 个 现 代 化 ” 而 服 务 的 混 合 式 教 育 体 制 。 各 种 文 革 前 体 制 恢 复 自 不 必 提 — — 首 先 是 撤 出 工 宣 队 、 恢 复 学 制 ， 以 最 快 速 度 、 雷 霆 手 段 去 整 顿 教 学 体 制 。 其 次 ， 为 重 振 教 师 信 心 ， 改 革 派 成 员 提 出 改 革 教 师 工 资 、 奖 励 和 职 称 制 度 ， 教 师 收 入 大 大 提 高 。 同 时 在 全 国 开 展 尊 孔 运 动 ， 向 这 位 “ 万 世 师 表 ” 表 达 了 迟 到 多 年 的 敬 意 ， 迅 速 扭 转 了 文 革 时 期 轻 视 人 才 轻 视 教 师 的 不 良 风 气 。 而 首 次 关 于 教 育 的 法 例 — — 学 位 制 度 得 到 了 全 国 人 大 的 一 致 通 过 ， 标 志 着 我 国 教 育 事 业 开 始 走 上 了 规 范 化 、 制 度 化 、 法 制 化 的 道 路 。 除 此 之 外 ， 我 国 破 天 荒 地 打 破 了 过 往 教 学 孤 立 的 情 况 ， 首 次 向 西 方 世 界 派 遣 留 学 生 ， 学 习 超 级 大 国 在 各 个 领 域 的 前 沿 知 识 。 而 一 些 国 外 著 名 教 授 教 师 也 开 始 来 到 我 国 进 行 教 学 活 动 ， 如 同 一 把 钥 匙 打 开 我 国 封 闭 的 教 育 氛 围 。 “ 人 民 教 育 人 民 办 ， 人 民 教 育 为 人 民 ” 的 口 号 也 得 到 了 广 大 群 众 的 热 烈 响 应 ， 各 种 私 人 学 校 、 培 训 机 构 、 合 作 学 校 如 雨 后 春 笋 ， 大 大 减 轻 了 我 国 公 共 教 育 部 门 “ 孤 军 奋 战 ” 的 建 设 压 力 ， 也 推 动 了 教 育 改 革 和 教 学 质 量 的 提 升 。 在 管 理 体 制 上 ， 将 基 础 教 育 的 管 理 权 下 放 给 地 方 ， 建 立 起 省 、 县 、 乡 分 级 管 理 ， 财 政 以 乡 为 主 的 义 务 教 育 管 理 体 制 ， 并 实 施 校 长 负 责 制 ， 充 分 调 动 了 地 方 的 积 极 性 ， 对 促 进 基 础 教 育 的 发 展 发 挥 了 积 极 的 作 用 。||围 绕 着 “ 改 革 ” 与 “ 科 技 ” ， 我 国 教 育 最 终 得 以 起 死 回 生 ， 重 新 焕 发 生 机 。 其 繁 荣 和 发 展 都 大 大 超 过80 年 代 前 那 种 不 紧 不 慢 、 专 注 于 政 治 问 题 的 “ 半 吊 子 学 校 ” 。 而 从 中 华 文 化 的 代 表 人 物 孔 子 的 教 诲 中 ， 我 们 构 建 了 一 种 不 同 于 革 命 激 情 的 、 稳 定 严 肃 的 教 学 气 氛 ， 为 我 国 教 育 进 一 步 改 革 开 辟 了 一 条 一 直 被 忽 视 的 道 路 。 即 便 总 有 几 个 不 识 时 务 者 在 批 评 着 所 谓 “ 素 质 教 育 缺 失 ” 、 “ 人 性 磨 灭 ” 、 “ 扩 大 地 区 差 距 ” 的 “ 改 革 问 题 ” ， 但 这 些 人 又 会 愿 意 回 到 毛 时 代 的 那 种 教 育 体 系 下 吗 ？ 很 明 显 ， 这 已 经 是 我 们 最 好 的 选 择 。 况 且 ， 只 要 待 到 我 国 科 技 型 人 才 、 知 识 型 人 才 足 够 充 足 ， 物 质 条 件 足 够 丰 富 ， 那 么 教 育 的 全 面 化 、 福 利 化 转 型 也 必 将 提 上 议 程 。 而 这 在 日 新 月 异 的 中 国 社 会 前 只 是 一 个 时 间 问 题 … … 对 吧 ？", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.data[1] += 100;
			a.data[3] += 50;
			a.data[4] += 150;
			break;
		case 3:
			text = string.Format("中 国 人 民 解 放 军 成 立 到 今 天 ， 已 经 有 五 十 多 年 了 。 毛 泽 东 同 志 亲 手 缔 造 和 直 接 领 导 的 这 支 伟 大 的 人 民 军 队 ， 几 十 年 来 ， 在 革 命 战 争 年 代 ， 在 同 国 内 外 阶 级 敌 人 长 期 艰 苦 的 战 斗 中 ， 在 全 国 胜 利 以 后 ， 在 担 负 保 卫 和 建 设 社 会 主 义 祖 国 、 保 卫 远 东 和 世 界 和 平 的 任 务 中 ， 一 直 保 持 和 发 扬 了 “ 既 是 战 斗 队 ， 又 是 工 作 队 ， 又 是 生 产 队 ” 的 光 荣 传 统 。 自 文 化 大 革 命 以 来 ， 军 队 更 是 高 举 毛 泽 东 思 想 伟 大 红 旗 ， 活 学 活 用 毛 主 席 著 作 ， 大 力 突 出 无 产 阶 级 政 治 ， 发 扬 三 八 作 风 ， 参 加 和 支 援 社 会 主 义 建 设 ， 在 无 产 阶 级 化 、 革 命 化 、 战 斗 化 的 道 路 上 ， 又 大 大 迈 进 了 一 步 。 而 我 国 人 民 群 众 历 来 都 把 解 放 军 作 为 学 习 的 榜 样 ， 在 与 资 产 阶 级 敌 人 和 民 族 败 类 的 斗 争 中 积 极 拥 党 拥 军 ， 坚 定 跟 随 着 党 中 央 和 人 民 解 放 军 挫 败 了 一 次 又 一 次 的 内 外 敌 人 阴 谋 ， 粉 碎 了 四 人 帮 、 林 彪 、 叶 邓 前 后 几 个 反 党 反 人 民 集 团 。 现 在 ， 英 勇 的 人 民 解 放 军 不 仅 要 用 武 器 的 批 判 保 卫 群 众 ， 还 将 在 党 中 央 的 指 导 下 ， 用 批 判 的 武 器 武 装 群 众 的 大 脑 。 在 人 民 军 队 的 协 助 下 ， 整 个 社 会 将 如 同 毛 泽 东 同 志 所 希 冀 的 那 样 ， 成 为 一 个 “ 学 政 治 ， 学 军 事 ， 学 文 化 ” 的 大 学 校 ！||您 大 手 一 挥 否 决 了 三 类 方 案 ， 转 而 指 示 制 定 一 套 旨 在 强 化 拥 军 学 军 、 将 国 防 军 事 教 育 全 面 融 入 国 民 教 育 体 系 的 体 制 ， 并 要 求 迅 速 在 全 国 范 围 内 推 广 实 施 。 在 您 对 于 党 的 绝 对 领 导 下 ， 一 套 以 “ 服 从 命 令 、 遵 守 纪 律 、 团 队 协 作 、 步 调 一 致 ” 为 核 心 、 服 务 于 国 防 安 全 的 教 育 体 系 迅 速 建 立 。 各 级 教 育 机 构 纷 纷 悬 挂 您 的 画 像 ， 并 定 期 组 织 学 生 宣 誓 “ 忠 于 祖 国 ， 忠 于 人 民 ， 忠 于 伟 大 领 袖 的 绝 对 领 导 ” ， 以 此 巩 固 青 少 年 对 党 和 国 家 领 导 人 的 坚 定 信 念 ， 奠 定 “ 铁 的 纪 律 ” 的 精 神 基 础 。 全 民 国 防 教 育 和 全 面 战 争 意 识 被 深 度 融 入 教 学 课 程 ， 原 有 的 短 期 军 训 被 延 长 ， 成 为 学 生 必 修 课 程 的 重 要 组 成 部 分 。 各 地 军 官 教 学 组 进 驻 学 校 ， 开 展 丰 富 多 彩 的 国 防 教 育 活 动 ， 为 培 养 青 少 年 的 爱 国 主 义 精 神 和 社 会 主 义 道 德 风 尚 发 挥 了 重 要 作 用 。 在 教 材 编 写 方 面 ， 大 量 革 命 军 队 题 材 和 领 导 人 事 迹 被 纳 入 编 写 范 围 ， 国 语 课 、 政 治 课 等 文 史 课 程 重 点 弘 扬 我 国 军 队 的 光 荣 传 统 和 领 导 人 的 卓 越 功 勋 。 此 外 ， 师 生 间 的 监 督 机 制 — — 纪 律 纠 察 委 员 会 在 全 国 各 地 推 广 实 施 。 这 一 由 先 进 学 生 和 革 命 教 师 组 成 的 部 门 ， 不 仅 向 各 级 学 校 党 政 领 导 层 报 告 校 内 动 态 ， 还 鼓 励 师 生 积 极 向 委 员 会 反 映 潜 在 的 不 良 思 想 和 行 为 ， 通 过 奖 励 机 制 激 励 举 报 ， 从 而 有 效 清 除 帝 国 主 义 和 封 建 主 义 残 余 思 想 ， 确 保 校 园 风 气 纯 洁 ， 保 护 青 少 年 的 思 想 健 康 和 民 族 热 忱 。||这 一 系 列 举 措 为 培 养 新 时 代 社 会 主 义 建 设 者 和 接 班 人 奠 定 了 坚 实 基 础 ， 也 为 全 党 全 军 全 国 人 民 深 度 认 识 以 您 — — 中 国 的 新 舵 手 为 代 表 的 党 中 央 对 全 中 国 无 可 争 议 的 核 心 地 位 。 各 地 人 民 如 今 更 加 热 忱 地 跟 随 您 的 步 伐 ， 积 极 为 党 对 中 国 社 会 主 义 现 代 化 的 伟 大 规 划 出 谋 划 策 、 添 砖 加 瓦 。 广 大 爱 国 群 众 一 致 相 信 ， 在 您 的 英 明 领 导 下 ， 中 国 共 产 党 最 终 将 实 现 对 数 亿 人 民 的 政 治 承 诺 和 复 兴 理 想 ， 让20 世 纪 的 下 半 叶 成 为 名 副 其 实 的 “ 中 国 世 纪 ” ！", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.data[1] += 100;
			a.data[3] += 150;
			a.data[4] -= 200;
			a.data[9] -= 100;
			a.empires[0].relations -= 50;
			a.empires[1].relations -= 50;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
		GlobalScript.inst.old_modify_desc[2] = "根 据 服 务 业 的 发 展 情 况 获 得 效 果|";
		if (GlobalScript.inst.gameState.data[108] < 54)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>受 到 管 控 的 私 有 制 ：</color> 投 机 倒 把 的 商 人 还 影 响 不 到 我 们";
		}
		else if (GlobalScript.inst.gameState.data[108] < 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>逐 渐 崛 起 的 寡 头 ：</color>人 民 支 持 度-0.5 ， 思 想 自 由 化+1 ， 生 活 水 平-0.5 ";
		}
		else if (GlobalScript.inst.gameState.data[108] >= 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>寡 头 执 政 ：</color>人 民 支 持 度-1 ， 思 想 自 由 化+2 ， 生 活 水 平-1 ";
		}
		if (!GlobalScript.inst.gameState.event_done[669])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.1 ， 工 业+0.2 ，农 业+0.2 ， 人 民 支 持 度+0.2 ， 科 技 点 数+0.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 0)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.2 ， 工 业+0.3 ，农 业+0.3 ， 人 民 支 持 度+0.3 ， 科 技 点 数+1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 1)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>正 统 社 会 主 义 教 育 路 线 ：</color>预 算-0.1 ， 腐 败 + 0.1 ， 科 技 点 数+1.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 2)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>混 合 式 教 育 体 制 改 革 ：</color>预 算+0.2 ， 寡 头 力 量+0.1 , 腐 败 + 0.2 ， 科 技 点 数+2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 3)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>全 民 军 事 化 教 育 ：</color>军 事 力 量+0.3 ，人 民 支 持 度+1 ， 思 想 自 由 化-1 ， 科 技 点 数-2 ， 凝 聚 力+0.5 ， 民 族 情 绪+0.5";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[456] == 0 && GlobalScript.inst.gameState.event_done[456])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>全 国 高 校 统 一 招 生 考 试 ：</color>科 技 点 数 +2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 1 && GlobalScript.inst.gameState.event_done[456])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>预 科 制 度 ：</color>科 技 点 数 +1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 2 || !GlobalScript.inst.gameState.event_done[456])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>无 产 阶 级 推 荐 制 ：</color>农 业+0.3 ， 工 业+0.3";
		}
		if (!GlobalScript.inst.gameState.event_done[646])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>合 作 医 疗 ：</color>预 算-0.1 ， 工 业+0.2 ， 农 业+0.3 ， 人民支持度+0.2 , 服 务 业+0.2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 0)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>精 进 的 合 作 医 疗 ：</color>预 算-0.2 ， 工 业+0.3 ， 农 业+0.4 ， 人民支持度+0.2 , 服 务 业+0.3";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 1)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>市 场 化 改 革 医 疗 ：</color>预 算+0.2 ， 生 活 水 平+0.1 ， 寡 头 力 量+0.1 , 服 务 业+0.1";
		}
		load_scene_after_click = true;
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
