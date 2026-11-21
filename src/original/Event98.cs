using EventsForDLC;
using UnityEngine;

public class Event98 : EventsSecond
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
		name = " 非 洲 的 切 · 格 瓦 拉";
		text = " 前 法 国 殖 民 地 上 沃 尔 特 注 定 是 个 事 故 频 发 之 地 ： 自 民 选 总 统 桑 古 尔 · 拉 米 扎 纳 于1977 年 被 军 方 推 翻 后 ， 该 国 便 陷 入 不 断 政 变 的 治 乱 循 环 。 率 先 坐 上 头 号 交 椅 的 亲 法 军 政 府 领 袖 赛 耶 · 泽 博 试 图 引 入 军 官 稳 固 政 权 的 做 法 最 终 却 成 了 引 狼 入 室 ： 亲 近 共 产 主 义 思 想 的 军 官 们 得 以 借 势 做 大 ， 并 在 其 魅 力 非 凡 的 领 导 人 托 马 斯 · 桑 卡 拉 的 旗 下 逐 渐 登 上 权 力 巅 峰 。 此 后 ， 桑 卡 拉 与 其 同 僚 在 数 次 政 变 中 先 是 推 翻 极 不 得 民 心 的 盗 贼 政 客 赛 耶 · 泽 博 ， 随 后 又 将 军 方 内 物 色 的 妥 协 领 导 人 让 - 巴 蒂 斯 特 · 韦 德 拉 奥 果 排 挤 出 局 。 结 束 了 反 泽 博 两 派 势 力 的 二 元 共 治 局 面 。 此 后 ， 这 个 国 家 的 名 称 立 即 从 殖 民 地 的 “ 上 沃 尔 特 ” 转 为 “ 布 基 纳 法 索 ” ， 意 为 “ 正 人 君 子 之 国 ” ， 国 旗 国 徽 国 歌 等 都 跟 着 改 头 换 面 。 如 今 ， 深 受 非 洲 反 帝 思 潮 影 响 的 托 马 斯 · 桑 卡 拉 得 以 彻 底 摊 牌 ， 并 宣 布 将 在 布 基 纳 法 索 推 进 下 述 几 项 全 新 议 程 ： 建 设 非 洲 社 会 主 义 、 反 对 反 革 命 阶 级 、 以 及 试 图 基 于 格 瓦 拉 式 的 输 出 革 命 理 论 彻 底 砸 碎 “ 法 非 ” 概 念 。 上 述 激 进 政 策 显 然 会 让 他 的 政 权 陷 入 不 稳 定 中 ， 且 桑 卡 拉 试 图 将 权 力 保 持 在 军 事 色 彩 极 强 的 人 民 解 放 委 员 会 内 ， 缺 乏 交 权 意 愿 的 做 法 也 只 会 让 其 统 治 宛 如 红 色 军 头 ， 他 因 此 遭 到 包 括 多 家 工 会 与 社 会 主 义 政 党 如 沃 尔 特 革 命 共 产 党 等 左 翼 团 体 的 批 评 。 显 然 ， 目 前 的 桑 卡 拉 政 权 正 处 于 四 面 开 弓 与 急 需 盟 友 支 持 的 境 地 。 我 们 的 支 持 或 许 足 以 扮 演 关 键 作 用 ， 并 改 变 布 基 纳 法 索 的 力 量 对 比 。 如 果 我 们 想 要 在 西 非 培 育 一 个 忠 于 革 命 的 窗 口 ， 大 可 押 注 桑 卡 拉 或 正 得 势 的 布 基 纳 法 索 左 翼 与 其 事 业 ； 又 或 者 ， 我 们 可 以 物 色 其 他 角 色 扭 转 局 势 ， 让 非 洲 回 归 正 轨 。 谁 知 道 桑 卡 拉 这 极 具 个 人 色 彩 的 统 治 会 不 会 演 化 为 黑 人 波 拿 巴 独 裁 的 又 一 类 变 体 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 无 视 军 事 政 变";
		if (GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 4)
		{
			button_text[1] = " 支 持 布 基 纳 法 索 的 革 新 ， 并 推 动 人 民 解 放 委 员 会 内 温 和 派 扭 转 唯 意 志 论 实 践";
		}
		else if (GlobalScript.inst.gameState.data[56] == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 天 下 大 乱 ， 局 势 大 好 。 怎 能 不 乘 胜 追 击 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 必 要 玩 两 害 相 择 取 其 轻 的 把 戏";
		}
		if (GlobalScript.inst.gameState.influencePRC >= 100 && GlobalScript.inst.gameState.data[56] < 2)
		{
			button_text[2] = " 支 持 布 基 纳 法 索 的 革 新 ， 并 推 动 人 民 解 放 委 员 会 选 择 更 坚 决 的 革 命 立 场";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 更 强 硬 的 社 会 主 义 军 政 府 ？ 难 道 你 打 算 在 西 非 制 造 个 黑 人 版 奈 温 ？";
		}
		if (GlobalScript.inst.gameState.modifies[41].active)
		{
			button_text[3] = "联 系 法 国 人 ， 我 们 应 当 给 当 地 畸 形 的 “ 不 断 政 变 ” 生 态 画 上 休 止 符";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = "我 们 鞭 长 莫 及";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		GlobalScript.inst.gameState.data[103] = 15;
		name = " 非 洲 的 切 · 格 瓦 拉";
		GlobalScript.inst.gameState.allcountries[61].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[61].name = GlobalScript.inst.new_events_text[800];
		GlobalScript.inst.gameState.allcountries[61].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[61].SubGosstroy = 3;
		GlobalScript.inst.gameState.allcountries[61].Torg = false;
		GlobalScript.inst.gameState.allcountries[61].Vyshi = false;
		GlobalScript.inst.gameState.allcountries[61].proprc = false;
		GlobalScript.inst.gameState.allcountries[61].prosov = false;
		GlobalScript.inst.gameState.allcountries[61].dev = 500;
		switch (result_num)
		{
		case 0:
			text = " 我 们 没 必 要 对 这 种 几 乎 每 天 都 会 发 生 的 政 变 做 出 回 应 ， 并 准 备 把 注 意 力 放 在 更 关 键 的 地 方 。 根 据 国 际 组 织 的 消 息 ： 布 基 纳 法 索 境 内 的 军 事 管 制 显 然 没 有 放 松 的 迹 象 。 不 久 后 ， 桑 卡 拉 便 开 始 借 助 人 民 解 放 委 员 会 的 框 架 力 行 集 权 ， 在 清 剿 军 内 异 己 的 同 时 封 杀 了 多 个 反 对 自 身 执 政 方 针 的 左 翼 组 织 。 预 计 接 下 来 便 是 依 托 军 政 府 框 架 建 立 无 所 不 包 的 整 合 体 制 ， 并 通 过 押 注 全 面 的 紧 缩 政 策 为 国 内 公 共 事 务 发 展 提 供 资 金 。 终 于 ， 布 基 纳 法 索 成 为 了 一 个 混 合 古 巴 式 革 命 委 员 会 基 层 组 织 与 军 方 强 人 统 治 的 民 族 共 产 主 义 政 权 ， 其 维 系 仰 仗 桑 卡 拉 的 光 环 与 个 人 魅 力 。 不 过 ， 靠 着 力 行 土 地 改 革 ， 大 型 基 础 设 施 与 发 展 社 会 保 障 等 手 段 。 桑 卡 拉 得 以 将 自 己 倡 导 的 自 力 更 生 哲 学 落 到 实 处 ， 迈 出 了 改 变 该 国 贫 困 现 状 的 第 一 步 。 布 基 纳 法 索 的 识 字 率 稳 步 提 升 ， 粮 食 得 以 转 向 自 给 满 足 人 民 需 求 ， 割 礼 等 落 后 习 俗 也 被 系 数 废 除 。";
			GlobalScript.inst.gameState.allcountries[61].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[61].Gosstroy = 1;
			if ((a.empires[1].power > a.empires[0].power && a.empires[1].power > a.influencePRC) || a.allcountries[1].isSEV || a.allcountries[1].isOVD)
			{
				text += " 对 于 布 基 纳 法 索 的 新 变 化 ， 本 就 处 于 优 势 并 试 图 在 非 洲 发 起 新 一 轮 进 攻 的 苏 联 很 快 便 抛 出 橄 榄 枝 。 不 久 后 ， 来 自 莫 斯 科 的 援 助 便 运 抵 瓦 加 杜 古 ， 托 马 斯 · 桑 卡 拉 得 以 通 过 安 德 烈 · 葛 罗 米 柯 的 关 系 同 彼 时 的 苏 共 总 书 记 建 立 了 密 切 合 作 关 系 。 看 来 ” 非 洲 的 格 瓦 拉 “ 一 词 确 实 名 副 其 实 — — 如 今 背 后 无 忧 的 桑 卡 拉 终 于 可 以 大 展 宏 图 了 。";
				GlobalScript.inst.gameState.allcountries[61].prosov = true;
				a.empires[1].power += 5;
			}
			else if (!a.modifies[44].active)
			{
				text += " 然 而 ， 桑 卡 拉 试 图 在 高 度 孤 立 的 情 况 下 深 入 推 进 社 会 革 新 ， 以 及 试 图 挑 战 法 国 对 传 统 势 力 范 围 霸 权 的 策 略 注 定 不 会 一 帆 风 顺 。 以 至 于 原 本 应 当 作 为 桑 卡 拉 后 盾 的 人 民 解 放 委 员 会 内 部 都 产 生 要 求 “ 放 松 螺 丝 ” 的 离 心 倾 向 。 上 述 情 况 只 会 随 着 布 基 纳 法 索 与 法 国 间 对 抗 的 火 花 愈 演 愈 烈 。 谁 知 道 接 下 来 会 如 何 … …";
			}
			break;
		case 1:
			text = " 我 们 决 定 对 布 基 纳 法 索 采 取 足 够 灵 活 的 立 场 ， 以 稳 定 当 地 的 局 势 。 不 久 后 ， 中 国 代 表 便 抵 达 瓦 加 杜 古 会 见 中 国 人 民 的 新 朋 友 ， 在 承 认 新 政 府 的 同 时 提 供 了 该 国 急 需 的 食 物 、 军 械 与 资 金 援 助 。 对 此 ， 该 国 领 导 人 托 马 斯 · 桑 卡 拉 则 深 受 感 动 ， 并 顺 势 同 我 们 达 成 了 多 项 合 作 协 定 。 然 而 这 只 是 一 个 开 始 ： 接 下 来 ， 我 们 决 定 同 人 民 解 放 委 员 会 内 的 温 和 派 进 行 接 触 ， 并 逐 渐 在 这 一 过 程 中 架 空 托 马 斯 · 桑 卡 拉 的 派 系 与 对 其 激 进 主 义 观 点 釜 底 抽 薪 。 结 果 便 是 桑 卡 拉 在 布 基 纳 法 索 境 内 越 来 越 显 得 像 是 以 清 正 廉 洁 闻 名 的 国 家 级 花 瓶 ， 而 非 革 命 领 军 人 与 政 权 的 真 正 领 袖 。 国 内 的 实 权 事 实 上 落 入 了 人 民 解 放 委 员 会 的 二 把 手 布 莱 斯 · 孔 波 雷 与 同 僚 巴 蒂 斯 特 · 林 加 尼 、 亨 利 · 宗 戈 等 “ 桑 卡 拉 亲 密 战 友 ” 手 中 ， 他 们 在 人 民 解 放 委 员 会 内 组 建 了 一 个 指 导 转 型 的 顾 问 委 员 会 奉 行 所 谓 “ 名 副 其 实 的 集 体 领 导 ” ： 国 家 对 社 会 团 体 的 态 度 得 以 放 松 ， 并 引 入 了 旨 在 稳 固 公 务 员 群 体 的 干 部 门 册 与 薪 资 等 级 制 ， 接 下 来 便 是 对 军 政 府 实 施 有 限 开 门 的 改 革 ： 国 内 “ 具 有 建 设 意 义 ” 的 政 党 均 得 以 加 入 人 民 解 放 委 员 会 ， 并 作 为 其 中 成 员 参 与 政 治 生 活 。 布 基 纳 法 索 的 外 交 也 跟 着 转 向 平 稳 航 行 （ 即 在 和 平 共 处 的 基 础 上 同 包 括 亲 法 非 洲 政 权 在 内 的 国 家 发 展 建 设 性 外 交 关 系 ） ， 甚 至 为 促 进 经 济 发 展 而 开 设 经 济 特 区 ， 吸 纳 邻 国 投 资 与 鼓 励 国 内 经 济 作 物 出 口 ， 事 实 上 承 认 原 法 非 体 系 下 的 旧 有 国 际 分 工 关 系 。 如 今 的 布 基 纳 法 索 已 然 在 我 们 的 指 导 下 走 上 了 条 和 平 巩 固 社 会 主 义 之 路 ， 并 能 在 站 稳 脚 跟 的 基 础 上 充 分 保 存 其 革 命 成 就 。 即 便 这 一 成 果 的 变 异 并 不 一 定 会 使 所 有 人 满 意 。";
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.allcountries[61].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[61].SubGosstroy = 15;
			GlobalScript.inst.gameState.allcountries[61].Torg = true;
			GlobalScript.inst.gameState.allcountries[61].proprc = true;
			break;
		case 2:
			text = " 我 们 决 定 将 布 基 纳 法 索 的 演 变 作 为 撬 动 旧 殖 民 秩 序 的 支 点 ， 并 以 此 点 燃 反 殖 民 主 义 之 火 。 不 久 后 ， 中 国 代 表 便 抵 达 瓦 加 杜 古 会 见 中 国 人 民 的 新 朋 友 ， 在 承 认 新 政 府 的 同 时 提 供 了 该 国 急 需 的 食 物 、 军 械 与 资 金 援 助 。 对 此 ， 该 国 领 导 人 托 马 斯 · 桑 卡 拉 则 深 受 感 动 ， 他 在 当 日 庄 重 的 洗 尘 晚 宴 对 中 国 同 志 们 表 达 了 感 激 之 情 ： “ 有 了 中 国 朋 友 们 的 协 助 ， 帝 国 主 义 的 残 酷 统 治 将 会 在 新 千 年 时 彻 底 消 失 ， 所 有 的 人 将 在 一 个 自 由 而 平 等 的 社 会 中 生 活 ！ ” ， 紧 接 着 便 顺 势 同 我 们 达 成 了 多 项 合 作 协 定 。 然 而 这 只 是 一 个 开 始 ： 接 下 来 ， 我 们 决 定 协 助 桑 卡 拉 推 进 人 民 解 放 委 员 会 与 国 家 政 府 中 的 人 事 改 组 。 一 方 面 大 力 推 进 干 部 年 轻 化 ， 彻 底 扫 除 官 僚 主 义 积 弊 ； 一 方 面 则 试 图 通 过 在 当 地 赋 权 自 发 人 民 武 装 的 方 式 间 接 为 人 民 革 命 委 员 会 这 一 机 构 开 门 ， 并 通 过 军 事 改 革 剥 离 国 家 部 队 同 区 域 部 族 与 部 分 强 人 领 袖 之 间 的 强 绑 定 关 系 。 军 事 雅 各 宾 主 义 的 做 法 得 以 开 始 转 变 为 类 似 革 命 委 员 会 的 议 事 - 行 政 合 一 框 架 ， 该 国 的 执 政 基 础 也 得 以 从 军 事 团 体 转 变 为 动 员 起 的 成 规 模 基 层 公 民 ， 由 此 挖 掉 了 依 靠 军 事 政 变 做 法 夺 权 的 根 基 。 接 下 来 推 进 的 土 地 改 革 、 公 共 工 程 与 社 会 福 利 事 业 则 只 会 让 桑 卡 拉 的 政 权 得 到 该 国 本 就 实 力 雄 厚 的 左 翼 内 的 热 烈 欢 迎 ， 并 切 实 迈 出 了 改 变 该 国 贫 困 现 状 的 第 一 步 。 布 基 纳 法 索 的 识 字 率 稳 步 提 升 ， 粮 食 得 以 转 向 自 给 满 足 人 民 需 求 ， 割 礼 等 落 后 习 俗 也 被 系 数 废 除 。 诚 然 ， 试 图 在 一 个 前 殖 民 地 内 跳 过 资 本 主 义 发 展 阶 段 ， 从 封 建 主 义 直 接 转 向 社 会 主 义 并 非 易 事 。 布 基 纳 法 索 需 要 从 零 开 始 打 造 其 工 农 业 基 础 ， 并 在 同 时 确 保 人 民 享 有 平 等 、 有 效 又 实 惠 的 各 项 公 共 服 务 。 可 既 然 我 们 仍 坚 持 彻 底 清 算 旧 社 会 的 革 命 理 想 ， 那 我 们 实 际 上 也 无 需 对 布 基 纳 法 索 的 未 来 表 示 忧 虑 。 毕 竟 只 有 帝 国 主 义 分 子 才 会 恐 惧 彻 底 觉 醒 并 决 心 走 向 解 放 的 世 界 各 地 人 民 ！";
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.influencePRC += 15;
			GlobalScript.inst.gameState.empires[0].relations -= 200;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[22] -= 50;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.allcountries[61].SubGosstroy = 0;
			GlobalScript.inst.gameState.allcountries[61].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[61].Torg = true;
			GlobalScript.inst.gameState.allcountries[61].proprc = true;
			break;
		default:
			text = " 考 虑 到 布 基 纳 法 索 的 情 况 大 有 愈 演 愈 烈 ， 一 发 不 可 收 拾 之 势 。 出 于 维 护 当 地 稳 定 的 需 要 ， 我 们 决 定 直 接 同 法 国 对 接 ， 对 当 地 开 展 特 别 军 事 行 动 。 也 就 在 某 天 深 夜 ， 由 鲍 勃 · 德 纳 尔 率 领 的 雇 佣 兵 奇 袭 瓦 加 杜 古 ， 并 与 我 特 种 部 队 一 道 夺 下 首 都 多 处 交 通 要 地 ， 为 接 下 来 的 全 面 干 预 做 足 了 准 备 。 虽 说 布 基 纳 法 索 当 局 已 引 入 戒 严 并 做 好 了 备 战 准 备 ， 可 革 命 者 们 还 是 力 不 能 敌 — — 包 括 桑 卡 拉 ， 孔 波 雷 ， 林 加 尼 等 在 内 的 布 基 纳 法 索 实 权 人 物 均 在 这 次 袭 击 中 丧 命 。 在 雇 佣 兵 的 簇 拥 下 ， 国 父 之 子 热 拉 尔 · 坎 戈 · 韦 德 拉 奥 果 将 临 危 受 命 ， 宣 誓 要 让 民 主 回 归 上 沃 尔 特 ， 所 谓 的 布 基 纳 法 索 就 这 样 终 结 了 … …";
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[0].power += 10;
			GlobalScript.inst.gameState.empires[1].power -= 10;
			GlobalScript.inst.gameState.allcountries[61].puppetOf = 21;
			GlobalScript.inst.gameState.data[9] -= 20;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.allcountries[61].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[61].SubGosstroy = 12;
			GlobalScript.inst.gameState.allcountries[61].Torg = true;
			GlobalScript.inst.gameState.allcountries[61].name = "上 沃 尔 特";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
