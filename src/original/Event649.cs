using EventsForDLC;
using UnityEngine;

public class Event649 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

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
		name = " 从 应 许 之 地 到 应 许 之 地";
		text = " 众 所 周 知 ， 位 于 西 非 海 岸 的 利 比 里 亚 可 说 是 全 球 最 被 过 誉 的 政 权 。 该 国 虽 有 非 洲 首 个 “ 现 代 主 权 国 家 ” 与 率 先 在 当 地 移 植 美 式 宪 政 体 制 的 “ 首 倡 功 绩 ” ， 并 被 视 为 “ 自 由 世 界 在 西 非 地 区 的 样 板 工 程 ” 。 可 其 尴 尬 现 状 却 完 全 配 不 上 前 面 的 各 种 牌 面 ： 利 比 里 亚 的 人 口 结 构 深 受 美 国 影 响 ， 其 统 治 阶 层 可 追 溯 至 美 国 于19 世 纪 废 奴 运 动 时 遣 返 的 黑 人 移 民 群 体 。 后 者 很 快 便 在 这 片 土 地 上 摸 着 前 辈 智 慧 过 河 ， 精 心 设 计 了 美 裔 黑 人 对 本 土 黑 人 的 等 级 制 与 种 族 隔 离 制 度 。 可 这 一 西 非 版 本 的 南 非 却 在 战 略 定 力 上 略 显 不 足 ： 自 领 导 该 国 走 上 发 展 快 车 道 ， 并 试 图 对 现 有 体 制 小 修 小 补 ， 维 持 美 洲 裔 黑 人 霸 权 的 威 廉 · 杜 伯 曼 退 场 后 ， 利 比 里 亚 国 内 的 局 势 便 越 加 难 以 收 场 。 杜 伯 曼 的 继 任 者 威 廉 · 托 尔 伯 特 既 不 具 有 团 结 美 裔 黑 人 的 魅 力 ， 也 缺 乏 充 分 使 用 铁 腕 手 段 压 制 本 土 黑 人 的 权 柄 。 他 试 图 走 多 边 主 义 道 路 ， 尝 试 靠 拢 苏 东 集 团 的 尝 试 更 使 其 幕 后 东 家 美 国 人 对 其 丧 尽 耐 心 。 所 有 的 一 切 组 成 了 土 生 克 兰 族 黑 人 萨 缪 尔 · 多 伊 崛 起 的 背 景 故 事 — — 这 位 军 官 借 该 国 首 都 蒙 罗 维 亚 骚 乱 与 罢 工 的 风 潮 趁 虚 而 入 ， 于 当 年 四 月 十 二 日 率 数 十 人 发 动 政 变 ， 旋 即 在 “ 人 民 救 赎 委 员 会 ” 的 旗 下 建 立 起 利 比 里 亚 首 个 由 土 生 黑 人 领 导 的 政 权 ， 标 榜 将 落 实 “ 民 族 团 结 ， 严 打 腐 败 ， 实 现 社 会 公 正 ” 等 纲 领 。 考 虑 到 土 生 政 权 的 招 牌 在 前 ， 对 我 们 来 说 ， 这 兴 许 是 深 化 去 殖 民 化 实 践 ， 并 将 超 级 大 国 踢 出 非 洲 的 好 机 会 。 因 此 ， 向 新 政 权 递 出 橄 榄 枝 绝 对 理 所 应 当 — — 即 便 是 出 于 寻 找 贸 易 伙 伴 的 现 实 需 求 也 是 如 此 。 可 仍 有 人 对 此 抱 有 怀 疑 ： 考 虑 到 这 片 土 地 也 不 缺 如 蒙 博 托 · 塞 塞 · 塞 科 与 若 纳 斯 · 萨 文 比 等 羊 头 狗 肉 派 角 色 ， 提 前 押 注 的 做 法 看 起 来 并 不 明 智 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 近 水 楼 台 ， 得 尽 快 派 队 伍 到 蒙 罗 维 亚 去 深 耕";
		button_text[1] = " 欲 速 则 不 达 ， 我 想 只 有 数 十 人 的 团 伙 可 没 法 管 好 国 家 … …";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 从 应 许 之 地 到 应 许 之 地";
		GlobalScript.inst.gameState.allcountries[67].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[67].SubGosstroy = 13;
		GlobalScript.inst.gameState.allcountries[67].Vyshi = true;
		switch (result_num)
		{
		case 0:
			text = " 我 们 的 外 交 使 团 很 快 便 带 着 贺 电 与 数 份 有 利 可 图 的 经 济 合 同 抵 达 蒙 罗 维 亚 ， 热 烈 祝 贺 “ 人 民 救 赎 委 员 会 ” 为 清 算 殖 民 主 义 余 毒 所 作 的 努 力 ， 并 表 达 了 我 方 的 合 作 意 愿 。 多 伊 对 此 则 欣 然 接 受 ， 旋 即 则 迅 速 开 始 在 全 国 建 立 “ 统 治 ” — — 多 伊 以 一 场 处 刑 前 政 府 官 员 的 全 国 电 视 直 播 拉 开 了 利 比 里 亚 新 时 代 的 序 幕 ， 随 后 则 是 以 引 入 军 管 为 名 暂 停 法 律 ， 事 实 上 为 对 反 对 者 实 行 大 规 模 法 外 处 决 的 迫 害 方 式 开 了 绿 灯 。 接 下 来 则 又 是 曾 在 扎 伊 尔 发 生 的 原 汁 原 味 ： 本 土 信 仰 伏 都 教 得 以 在 多 伊 的 亲 自 过 问 下 登 堂 入 室 ， 多 伊 的 土 生 克 兰 族 同 伴 们 也 纷 纷 鸡 犬 升 天 ， 成 为 了 新 时 代 的 征 服 者 民 族 。 粗 糙 而 无 效 的 政 府 改 组 与 清 洗 狂 潮 使 利 比 里 亚 就 此 向 着 非 洲 典 型 的 盗 贼 政 权 一 路 狂 奔 ， 以 至 于 我 们 的 外 交 队 伍 都 能 获 得 些 意 外 收 获 ： 由 于 新 政 府 对 管 理 国 家 方 面 一 窍 不 通 ， 其 大 多 数 对 外 经 济 事 务 事 实 上 被 外 包 给 了 其 国 际 合 作 伙 伴 。 其 中 赚 得 最 盆 满 钵 满 的 自 然 还 是 美 国 ： 多 伊 为 当 地 美 军 活 动 大 开 绿 灯 、 放 松 投 资 门 槛 ， 以 及 保 持 亲 美 外 交 态 度 等 做 法 正 中 华 盛 顿 下 怀 ， 让 美 国 与 “ 自 由 世 界 ” 纷 纷 这 位 “ 士 官 长 ” 献 上 各 类 殷 勤 并 投 送 大 量 援 助 … … 看 起 来 我 们 算 是 又 踩 了 个 泥 坑 ， 可 考 虑 到 多 伊 政 权 终 归 不 是 类 似 南 非 那 般 的 “ 国 际 孤 儿 ” 。 至 少 我 们 现 在 仍 能 保 持 相 安 无 事 。 至 于 利 比 里 亚 本 身 ， 事 情 可 不 会 如 此 轻 易 就 结 束 … …";
			GlobalScript.inst.gameState.data[8] += 10;
			GlobalScript.inst.gameState.allcountries[67].Torg = true;
			break;
		case 1:
			text = " 我 们 无 视 了 这 种 在 非 洲 地 区 基 本 可 说 是 常 态 的 儿 戏 式 政 变 ， 并 决 定 将 重 心 放 在 别 处 。 根 据 国 际 组 织 的 信 息 ， 我 们 应 当 庆 幸 自 己 没 能 涉 足 ， 并 成 为 血 腥 暴 君 的 帮 凶 ： 多 伊 以 一 场 处 刑 前 政 府 官 员 的 全 国 电 视 直 播 拉 开 了 利 比 里 亚 新 时 代 的 序 幕 ， 随 后 则 是 以 引 入 军 管 为 名 暂 停 法 律 ， 事 实 上 为 对 反 对 者 实 行 大 规 模 法 外 处 决 的 迫 害 方 式 开 了 绿 灯 。 接 下 来 则 又 是 曾 在 扎 伊 尔 发 生 的 原 汁 原 味 ： 本 土 信 仰 伏 都 教 得 以 在 多 伊 的 亲 自 过 问 下 登 堂 入 室 ， 多 伊 的 土 生 克 兰 族 同 伴 们 也 纷 纷 鸡 犬 升 天 ， 成 为 了 新 时 代 的 征 服 者 民 族 。 粗 糙 而 无 效 的 政 府 改 组 与 清 洗 狂 潮 使 利 比 里 亚 就 此 向 着 非 洲 典 型 的 盗 贼 政 权 一 路 狂 奔 。 然 而 多 伊 为 当 地 美 军 活 动 大 开 绿 灯 、 放 松 投 资 门 槛 ， 以 及 保 持 亲 美 外 交 态 度 等 做 法 正 中 华 盛 顿 下 怀 ， 让 美 国 与 “ 自 由 世 界 ” 纷 纷 这 位 “ 士 官 长 ” 献 上 各 类 殷 勤 并 投 送 大 量 援 助 … … 虽 说 目 前 的 结 果 看 似 皆 大 欢 喜 ， 但 竭 泽 而 渔 式 统 治 绝 不 会 长 久 。 利 比 里 亚 的 事 情 可 不 会 如 此 轻 易 就 结 束 … …";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
