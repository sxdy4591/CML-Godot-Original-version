using EventsForDLC;
using UnityEngine;

public class Event791 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 1979 年 国 庆 节";
		text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "主 席 同 志 ！ 1 9 7 9 年 是 中 华 人 民 共 和 国 挣 脱 法 西 斯 主 义 者 的 枷 锁 ， 从 而 让 人 民 翻 身 做 主 人 的 第 三 十 年 。 按 照 惯 例 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 应 该 说 点 什 么 。 党 内 的 左 派 希 望 谈 谈 对 于 国 际 共 运 的 事 ， 温 和 派 希 望 谈 谈 对 人 民 的 关 切 并 鼓 励 奋 斗 。 也 有 党 员 希 望 谈 谈 国 际 和 平 ， 着 手 修 复 和 别 的 国 家 的 关 系 。 但 是 演 讲 稿 毕 竟 还 在 您 手 上 ， 您 不 妨 看 看 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if ((GlobalScript.inst.gameState.leader.name_1 == 2 && GlobalScript.inst.gameState.leader.name_2 == 2 && GlobalScript.inst.gameState.data[56] <= 1) || (GlobalScript.inst.gameState.leader.name_1 == 3 && GlobalScript.inst.gameState.leader.name_2 == 3))
		{
			button_text[0] = " 谈 谈 对 国 际 共 运 的 希 冀";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 人 想 你 讲 这 些 东 西";
		}
		button_text[1] = " 谈 谈 对 于 建 设 祖 国 的 劳 动 者 们 的 感 激";
		button_text[2] = " 谈 谈 关 于 世 界 和 平 的 事";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 1979 年 国 庆 节";
		if (result_num == 0)
		{
			text = " 在 大 会 上 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 说 到 ： “ 今 天 ， 我 们 站 在 北 京 ， 放 眼 全 球 各 地 ， 无 处 不 是 英 勇 的 民 族 和 革 命 战 士 为 了 自 己 的 未 来 而 斗 争 。 我 国 一 贯 ， 且 将 永 远 支 持 你 们 ！ ”||在 国 庆 的 早 晨 ， 整 个 城 市 都 洋 溢 着 喜 庆 的 气 氛 。 大 街 小 巷 装 饰 一 新 ， 五 彩 缤 纷 的 旗 帜 和 花 朵 装 点 着 每 个 角 落 。 人 们 早 早 地 涌 向 游 行 路 线 ， 带 着 笑 容 和 期 待 。||在 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 按 下 电 钮 后 ， 军 乐 队 吹 响 了 国 歌 ， 五 星 红 旗 慢 慢 的 升 起 ， 所 有 人 都 注 视 着 这 一 庄 严 肃 穆 的 时 刻 。 随 后 便 是 阅 兵 式 ， 手 持 着 五 六 式 冲 锋 枪 和 六 三 式 自 动 步 枪 的 解 放 军 战 士 踏 着 整 齐 的 步 子 通 过 天 安 门 。||接 着 是 一 系 列 代 表 各 行 各 业 的 方 阵 ， 工 人 、 农 民 、 医 生 、 教 师 等 ， 他 们 身 着 各 自 的 工 作 服 装 ， 展 示 着 自 己 的 职 业 精 神 和 技 能 。 巨 大 的 花 车 也 在 游 行 中 穿 梭 ， 车 上 装 饰 着 灿 烂 的 花 朵 和 鲜 艳 的 灯 饰 ， 各 种 主 题 的 花 车 象 征 着 祖 国 的 繁 荣 和 发 展 。||观 众 席 上 ， 人 们 挥 舞 着 国 旗 和 彩 旗 ， 欢 呼 雀 跃 ， 为 游 行 队 伍 加 油 助 威 。||整 个 游 行 过 程 中 ， 天 空 中 不 时 有 飞 机 编 队 划 过 ， 划 出 绚 丽 的 彩 虹 轨 迹 ， 三 十 门 五 十 六 响 礼 炮 更 是 增 添 了 庆 典 的 气 氛 。 人 们 欢 呼 雀 跃 ， 掌 声 、 欢 呼 声 、 歌 声 此 起 彼 伏 ， 将 整 个 北 京 都 包 裹 在 欢 乐 与 激 情 中 。||当 举 着 火 把 的 群 众 绕 城 一 周 后 ， 国 庆 典 礼 正 式 结 束 了 。 但 心 中 的 喜 悦 和 对 祖 国 的 热 爱 却 永 远 留 存 着 。";
			a.data[1] += 100;
			a.data[3] += 100;
			a.data[4] -= 50;
			a.data[57] += 200;
			a.data[6] += 50;
			a.empires[0].relations -= 100;
			a.empires[1].relations -= 100;
		}
		if (result_num == 1)
		{
			text = " 在 大 会 上 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 说 到 ： “ 我 们 伟 大 祖 国 的 建 设 离 不 开 人 民 的 支 持 ， 我 在 这 里 代 表 党 中 央 ， 向 全 国 的 人 民 献 上 我 的 感 谢 ！ ”||在 国 庆 的 早 晨 ， 整 个 城 市 都 洋 溢 着 喜 庆 的 气 氛 。 大 街 小 巷 装 饰 一 新 ， 五 彩 缤 纷 的 旗 帜 和 花 朵 装 点 着 每 个 角 落 。 人 们 早 早 地 涌 向 游 行 路 线 ， 带 着 笑 容 和 期 待 。||在 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 按 下 电 钮 后 ， 军 乐 队 吹 响 了 国 歌 ， 五 星 红 旗 慢 慢 的 升 起 ， 所 有 人 都 注 视 着 这 一 庄 严 肃 穆 的 时 刻 。 随 后 便 是 阅 兵 式 ， 手 持 着 五 六 式 冲 锋 枪 和 六 三 式 自 动 步 枪 的 解 放 军 战 士 踏 着 整 齐 的 步 子 通 过 天 安 门 。||接 着 是 一 系 列 代 表 各 行 各 业 的 方 阵 ， 工 人 、 农 民 、 医 生 、 教 师 等 ， 他 们 身 着 各 自 的 工 作 服 装 ， 展 示 着 自 己 的 职 业 精 神 和 技 能 。 巨 大 的 花 车 也 在 游 行 中 穿 梭 ， 车 上 装 饰 着 灿 烂 的 花 朵 和 鲜 艳 的 灯 饰 ， 各 种 主 题 的 花 车 象 征 着 祖 国 的 繁 荣 和 发 展 。||观 众 席 上 ， 人 们 挥 舞 着 国 旗 和 彩 旗 ， 欢 呼 雀 跃 ， 为 游 行 队 伍 加 油 助 威 。||整 个 游 行 过 程 中 ， 天 空 中 不 时 有 飞 机 编 队 划 过 ， 划 出 绚 丽 的 彩 虹 轨 迹 ， 三 十 门 五 十 六 响 礼 炮 更 是 增 添 了 庆 典 的 气 氛 。 人 们 欢 呼 雀 跃 ， 掌 声 、 欢 呼 声 、 歌 声 此 起 彼 伏 ， 将 整 个 北 京 都 包 裹 在 欢 乐 与 激 情 中 。||当 举 着 火 把 的 群 众 绕 城 一 周 后 ， 国 庆 典 礼 正 式 结 束 了 。 但 心 中 的 喜 悦 和 对 祖 国 的 热 爱 却 永 远 留 存 着 。";
			a.data[3] += 200;
			a.data[4] -= 100;
			a.data[12] += 50;
			a.data[13] += 50;
			a.data[68] += 50;
		}
		if (result_num == 2)
		{
			text = " 在 大 会 上 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 说 到 ： “ 现 在 的 社 会 不 是 对 抗 ， 而 是 合 作 共 赢 ， 只 有 放 下 了 武 器 ， 我 们 才 能 更 好 的 拿 起 锤 子 ， 只 有 这 样 我 们 才 能 更 好 的 建 设 祖 国 。 我 们 希 望 和 平 与 发 展 ， 但 也 绝 对 不 会 放 弃 我 们 的 尊 严 ！ ”||在 国 庆 的 早 晨 ， 整 个 城 市 都 洋 溢 着 喜 庆 的 气 氛 。 大 街 小 巷 装 饰 一 新 ， 五 彩 缤 纷 的 旗 帜 和 花 朵 装 点 着 每 个 角 落 。 人 们 早 早 地 涌 向 游 行 路 线 ， 带 着 笑 容 和 期 待 。||在 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 按 下 电 钮 后 ， 军 乐 队 吹 响 了 国 歌 ， 五 星 红 旗 慢 慢 的 升 起 ， 所 有 人 都 注 视 着 这 一 庄 严 肃 穆 的 时 刻 。 随 后 便 是 阅 兵 式 ， 手 持 着 五 六 式 冲 锋 枪 和 六 三 式 自 动 步 枪 的 解 放 军 战 士 踏 着 整 齐 的 步 子 通 过 天 安 门 。||接 着 是 一 系 列 代 表 各 行 各 业 的 方 阵 ， 工 人 、 农 民 、 医 生 、 教 师 等 ， 他 们 身 着 各 自 的 工 作 服 装 ， 展 示 着 自 己 的 职 业 精 神 和 技 能 。 巨 大 的 花 车 也 在 游 行 中 穿 梭 ， 车 上 装 饰 着 灿 烂 的 花 朵 和 鲜 艳 的 灯 饰 ， 各 种 主 题 的 花 车 象 征 着 祖 国 的 繁 荣 和 发 展 。||观 众 席 上 ， 人 们 挥 舞 着 国 旗 和 彩 旗 ， 欢 呼 雀 跃 ， 为 游 行 队 伍 加 油 助 威 。||整 个 游 行 过 程 中 ， 天 空 中 不 时 有 飞 机 编 队 划 过 ， 划 出 绚 丽 的 彩 虹 轨 迹 ， 三 十 门 五 十 六 响 礼 炮 更 是 增 添 了 庆 典 的 气 氛 。 人 们 欢 呼 雀 跃 ， 掌 声 、 欢 呼 声 、 歌 声 此 起 彼 伏 ， 将 整 个 北 京 都 包 裹 在 欢 乐 与 激 情 中 。||当 举 着 火 把 的 群 众 绕 城 一 周 后 ， 国 庆 典 礼 正 式 结 束 了 。 但 心 中 的 喜 悦 和 对 祖 国 的 热 爱 却 永 远 留 存 着 。";
			a.data[1] += 80;
			a.data[3] += 80;
			a.data[6] -= 100;
			a.empires[0].relations += 150;
			a.empires[1].relations += 150;
		}
	}
}
