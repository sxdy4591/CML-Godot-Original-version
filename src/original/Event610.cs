using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event610 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "沙 巴 战 争";
		text = "在 蒙 博 托 推 翻 了 卡 萨 武 布 总 统 后 ， 刚 果 民 主 共 和 国 ， 或 者 说 扎 伊 尔 ， 已 经 步 入 了 一 个 崭 新 的 时 代 。 一 个 以 暴 力 ， 金 钱 和 绝 对 的 威 权 构 成 的 新 刚 果 。 在 蒙 博 托 夺 权 后 ， 他 击 败 了 老 殖 民 主 义 者 眷 养 的 走 狗 ， 自 己 却 在 不 自 觉 中 在 鸡 蛋 上 跳 舞 。 他 一 边 接 受 华 盛 顿 的 善 意 ， 却 也 不 介 意 向 北 京 抛 媚 眼 。 他 的 人 民 革 命 运 动 更 是 一 个 意 识 形 态 大 杂 烩 ， 所 谓 的 “ 蒙 博 托 主 义 ” ， “ 真 实 性 运 动 ” 和 黑 人 民 族 主 义 不 过 都 是 浮 云 ， 更 有 甚 者 称 其 为 “ 丛 林 法 西 斯 主 义 ” 。 这 样 的 一 个 政 府 没 少 为 我 们 招 黑 。||就 是 这 样 的 地 区 才 会 被 冷 战 热 斗 所 裹 挟 ， 尤 其 是 他 的 南 部 邻 居 - 新 生 的 安 哥 拉 人 民 共 和 国 几 乎 彻 底 击 溃 了 扎 伊 尔 所 支 持 的 安 解 阵 。 不 论 是 意 识 形 态 还 是 背 后 的 超 级 大 国 ， 安 哥 拉 都 有 理 由 找 该 国 的 麻 烦 。 古 巴 和 苏 联 的 秘 密 支 持 下 ， 内 图 政 权 支 持 了 逃 亡 到 安 哥 拉 的 加 丹 加 （ 扎 伊 尔 的 沙 巴 省 ） 宪 兵 部 队 ， 塔 纳 尔 · 姆 奔 巴 以 此 为 基 础 组 建 了 刚 果 民 族 解 放 阵 线 。 据 我 们 的 军 事 教 官 和 观 察 员 所 说 ， 该 组 织 背 后 的 苏 联 意 图 凭 借 他 们 入 侵 扎 伊 尔 。||但 是 ， 我 们 也 没 少 为 支 持 扎 伊 尔 的 革 命 伙 伴 付 出 代 价 。 阿 尔 巴 尼 亚 领 袖 恩 维 尔 · 霍 查 多 次 谴 责 我 们 “ 把 革 命 者 与 第 三 世 界 国 家 强 绑 定 ， 忽 视 了 其 中 潜 在 的 反 革 命 ” 。 为 此 ， 我 们 应 当 转 而 支 持 基 赞 加 先 总 理 的 卢 蒙 巴 主 义 统 一 党 和 卡 比 拉 的 人 民 革 命 党 。 他 们 坚 定 的 保 持 左 翼 立 场 ， 甚 至 不 乏 一 些 真 正 的 马 克 思 主 义 者 。 我 们 的 盟 友 坦 桑 尼 亚 是 他 们 坚 强 的 后 盾 ， 如 果 能 得 到 我 们 的 背 书 ， 他 们 将 如 虎 添 翼 。||现 在 ， 外 联 部 的 同 志 已 经 将 三 份 方 案 交 给 您 了 ， 还 请 您 过 目 。 不 过 请 还 小 心 行 事 ， 刚 果 毕 竟 是 非 洲 的 一 个 大 国 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] != 0 && a.data[56] != 4)
		{
			button_text[0] = " 支 持 扎 伊 尔 人 民 反 抗 苏 联 社 会 帝 国 主 义 的 斗 争";
		}
		else if (a.data[56] == 0)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 ？ 他 杀 死 了 卢 蒙 巴 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 看 不 出 来 他 和 法 西 斯 的 区 别";
		}
		if (a.data[56] < 3 && a.data[56] > 0 && a.empires[1].relations > 500)
		{
			button_text[1] = " 与 蒙 博 托 政 权 断 交 ， 支 持 安 哥 拉 和 古 巴 的 军 事 行 动";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 和 那 个 邪 恶 帝 国 沆 瀣 一 气 ， 你 疯 了 ！";
		}
		if (a.data[56] < 2)
		{
			button_text[2] = " 在 卢 蒙 巴 的 旗 帜 下 ， 整 合 刚 果 的 革 命 者 们";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 愿 每 个 卢 蒙 巴 都 遇 上 自 己 的 蒙 博 托";
		}
		button_text[3] = " 不 闻 不 问";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "沙 巴 战 争";
		a.allcountries[117].parts[0] = true;
		int num = 0;
		if (result_num != 3)
		{
			num = 100;
		}
		if (result_num == 0)
		{
			text = "  我 们 坚 定 的 支 持 扎 伊 尔 人 民 反 抗 苏 联 社 会 帝 国 主 义 的 斗 争 ， 除 了 增 加 了 一 批 在 扎 伊 尔 的 军 事 教 官 ， 并 提 供 了 价 值 2 0 0 万 人 民 币 的 军 火 外 ，" + a.names1[a.politics[a.politics_dolshnost[2]].name_1] + a.names2[a.politics[a.politics_dolshnost[2]].name_2] + "和 迟 浩 田 副 参 谋 长 前 去 金 沙 萨 访 问 了 扎 伊 尔 总 统 。 在 我 们 的 官 方 报 纸 上 也 发 表 了 支 持 扎 伊 尔 的 声 明 。 蒙 博 托 总 统 感 谢 了 我 们 的 支 持 ， 并 大 力 扩 大 了 和 我 们 的 多 方 合 作 。 我 们 的 社 会 学 家 也 得 以 更 深 入 的 了 解 神 秘 的 刚 果 与 “ 真 实 性 运 动 ” 的 真 谛 。||清 晨 ，FNLC 的 士 兵 们 骑 着 自 行 车 越 过 安 哥 拉 - 扎 伊 尔 边 境 ， 发 动 了 三 管 齐 下 的 攻 击 。||蒙 博 托 了 谴 责 入 侵 ， 并 在 3 月 1 0 日 表 示 ， 基 森 奇 ， 迪 洛 洛 和 卡 潘 加 被 “ 古 巴 雇 佣 军 ” “ 轰 炸 ” 。 他 指 责 古 巴 政 府 参 与 其 中 ， 并 请 求 西 方 列 强 提 供 援 助 。 美 国 大 使 馆 证 实 了 这 些 城 镇 已 被 占 领 ， 并 宣 布 卡 潘 加 的 八 名 美 国 传 教 士 被 软 禁 。||扎 伊 尔 武 装 部 队 F A Z 的 行 动 基 本 上 无 效 。 第 一 个 接 触 的 部 队 ， 即 开 曼 尼 奥 拉 师 第 1 1 旅 ， 接 受 了 新 训 练 ， 在 遇 到FNLC 部 队 后 不 久 就 分 崩 离 析 了 。 然 而 ，FNLC 所 希 望 的 民 众 起 义 也 没 有 实 现 。 尽 管 大 多 数 居 民 更 喜 欢FNLC 部 队 而 不 是 政 府 军 队 ， 人 们 普 遍 害 怕 即 将 来 到 的 暴 力 ， 选 择 呆 在 家 里 。 一 场 战 争 就 这 样 爆 发 了 。";
			a.allcountries[117].LeaveAlliances();
			a.allcountries[117].proprc = true;
			a.allcountries[117].Torg = true;
			a.empires[1].relations -= 50;
			a.empires[0].relations += 50;
			a.empires[0].power += 10;
			a.influencePRC += 10;
			a.data[4] -= 20;
			a.data[22] -= 50;
			a.data[8] -= 20;
			a.ingamewars[60] = new War().Name(" 沙 巴 战 争").Attacker(" 扎 伊 尔").Defender(" 刚 果 民 族 解 放 阵 线")
				.AttackerInfluence(600 + num)
				.DefenderInfluence(400 - num)
				.TickTime(9)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
		if (result_num == 1)
		{
			text = " 出 于 对 蒙 博 托 政 权 的 担 忧 ， 与 和 苏 联 修 复 关 系 的 务 实 需 求 ， 我 们 决 定 支 持 安 哥 拉 人 民 和 刚 果 民 族 解 放 阵 线 的 举 动 。 在 刚 果 （ 布 ） 的 牵 线 下 ， 中 华 人 民 共 和 国 出 乎 意 料 的 承 认 了 安 哥 拉 人 民 共 和 国 ， 并 撤 回 了 驻 扎 在 扎 伊 尔 的 外 派 人 员 。 群 众 依 依 不 舍 的 看 着 中 国 同 志 们 的 离 开 ， 更 有 甚 者 打 出 了 “ 蒙 博 托 就 是 个 白 痴 ” “ 我 们 想 念 中 国 战 友 ” 这 样 的 标 语 。 很 快 ， 古 巴 与 中 国 士 兵 出 现 在 了 革 命 者 们 的 队 伍 中 ， 大 量 的 军 火 也 被 运 往 安 哥 拉 ， 由 他 们 转 赠 给 解 放 阵 线 的 士 兵 们 。||清 晨 ，FNLC 的 士 兵 们 骑 着 二 八 大 杠 自 行 车 越 过 安 哥 拉 - 扎 伊 尔 边 境 ， 发 动 了 三 管 齐 下 的 攻 击 。||蒙 博 托 了 谴 责 入 侵 ， 并 在 3 月 1 0 日 表 示 ， 基 森 奇 ， 迪 洛 洛 和 卡 潘 加 被 “ 古 巴 与 中 国 雇 佣 军 ” “ 轰 炸 ” 。 他 指 责 古 巴 政 府 参 与 其 中 ， 并 请 求 西 方 列 强 提 供 援 助 。 美 国 大 使 馆 证 实 了 这 些 城 镇 已 被 占 领 ， 并 宣 布 卡 潘 加 的 八 名 美 国 传 教 士 被 软 禁 。||扎 伊 尔 武 装 部 队 F A Z 的 行 动 基 本 上 无 效 。 第 一 个 接 触 的 部 队 ， 即 开 曼 尼 奥 拉 师 第 1 1 旅 ， 接 受 了 新 训 练 ， 但 在 遇 到FNLC 部 队 后 不 久 就 分 崩 离 析 了 。 然 而 ，FNLC 所 希 望 的 民 众 起 义 也 没 有 实 现 。 尽 管 大 多 数 城 镇 居 民 更 喜 欢FNLC 部 队 而 不 是 政 府 的 军 队 ， 人 们 普 遍 害 怕 即 将 来 到 的 暴 力 ， 选 择 呆 在 家 里 。 一 场 战 争 就 这 样 爆 发 了 。";
			a.allcountries[117].Torg = false;
			a.empires[1].relations += 50;
			a.empires[0].relations -= 50;
			a.empires[1].power += 10;
			a.allcountries[123].Torg = true;
			a.ingamewars[60] = new War().Name(" 沙 巴 战 争").Attacker(" 扎 伊 尔").Defender(" 刚 果 民 族 解 放 阵 线")
				.AttackerInfluence(600 - num)
				.DefenderInfluence(400 + num)
				.TickTime(9)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
			a.data[8] -= 20;
		}
		if (result_num == 2)
		{
			text = "出 乎 所 有 人 的 意 料 ， 我 们 既 不 支 持 扎 伊 尔 朋 友 ， 更 不 支 持 安 哥 拉 人 ， 而 是 把 目 光 投 向 坦 桑 尼 亚 。 在 坦 国 总 统 朱 利 叶 斯 · 尼 雷 尔 的 调 解 下 。 卢 蒙 巴 主 义 统 一 党 和 刚 果 人 民 革 命 党 ， 刚 果 （ 金 ） 马 克 思 主 义 革 命 党 和 安 德 烈 · 基 萨 斯 的 全 国 民 主 抵 抗 委 员 会 等 组 织 在 达 累 斯 萨 拉 姆 签 署 了 《 达 累 斯 萨 拉 姆 宣 言 》 。 正 式 宣 布 多 个 组 织 合 并 为 刚 果 人 民 革 命 组 织 。 该 组 织 宣 布 拥 护 马 克 思 列 宁 主 义 ， 并 认 可 毛 泽 东 和 卢 蒙 巴 的 思 想 。 短 期 目 标 是 建 立 稳 定 的 解 放 区 和 新 村 ， 长 期 与 终 极 目 标 将 会 是 彻 底 推 翻 蒙 博 托 政 权 。 刚 果 领 导 人 恩 古 瓦 比 也 宣 布 公 开 支 持 刚 果 人 民 革 命 组 织 ， 金 沙 萨 和 布 拉 柴 维 尔 的 气 氛 正 在 变 得 微 妙 … …||清 晨 ，FNLC 的 士 兵 们 骑 着 自 行 车 越 过 安 哥 拉 - 扎 伊 尔 边 境 ， 发 动 了 三 管 齐 下 的 攻 击 。||蒙 博 托 了 谴 责 入 侵 ， 并 在 3 月 1 0 日 表 示 ， 基 森 奇 ， 迪 洛 洛 和 卡 潘 加 被 “ 叛 匪 轰 炸 ” 。 他 指 责 古 巴 政 府 参 与 其 中 ， 并 请 求 西 方 列 强 提 供 援 助 。 美 国 大 使 馆 证 实 了 这 些 城 镇 已 被 占 领 ， 并 宣 布 卡 潘 加 的 八 名 美 国 传 教 士 被 软 禁 。||扎 伊 尔 武 装 部 队 F A Z 的 行 动 基 本 上 无 效 。 第 一 个 接 触 的 部 队 ， 即 开 曼 尼 奥 拉 师 第 1 1 旅 ， 接 受 了 新 训 练 ， 但 在 遇 到FNLC 部 队 后 不 久 就 分 崩 离 析 了 。 然 而 ，FNLC 所 希 望 的 民 众 起 义 也 没 有 实 现 。 尽 管 大 多 数 城 镇 居 民 更 喜 欢FNLC 部 队 而 不 是 政 府 的 军 队 ， 人 们 普 遍 害 怕 即 将 来 到 的 暴 力 ， 选 择 呆 在 家 里 。 一 场 战 争 就 这 样 爆 发 了 。";
			a.allcountries[117].Torg = false;
			a.empires[1].relations -= 100;
			a.empires[0].relations -= 100;
			a.influencePRC += 20;
			a.data[22] -= 50;
			a.data[8] -= 50;
			a.ingamewars[60] = new War().Name(" 沙 巴 战 争").Attacker(" 扎 伊 尔").Defender(" 刚 果 民 族 解 放 阵 线")
				.AttackerInfluence(600 - num)
				.DefenderInfluence(400 + num)
				.TickTime(9)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
		if (result_num == 3)
		{
			text = "清 晨 ，FNLC 的 士 兵 们 骑 着 自 行 车 越 过 安 哥 拉 - 扎 伊 尔 边 境 ， 发 动 了 三 管 齐 下 的 攻 击 。||蒙 博 托 了 谴 责 入 侵 ， 并 在 3 月 1 0 日 表 示 ， 基 森 奇 ， 迪 洛 洛 和 卡 潘 加 被 “ 古 巴 雇 佣 军 ” “ 轰 炸 ” 。 他 指 责 古 巴 政 府 参 与 其 中 ， 并 请 求 西 方 列 强 提 供 援 助 。 美 国 大 使 馆 证 实 了 这 些 城 镇 已 被 占 领 ， 并 宣 布 卡 潘 加 的 八 名 美 国 传 教 士 被 软 禁 。||扎 伊 尔 武 装 部 队 F A Z 的 行 动 基 本 上 无 效 。 第 一 个 接 触 的 部 队 ， 即 开 曼 尼 奥 拉 师 第 1 1 旅 ， 接 受 了 新 训 练 ， 在 遇 到FNLC 部 队 后 不 久 就 分 崩 离 析 了 。 然 而 ，FNLC 所 希 望 的 民 众 起 义 也 没 有 实 现 。 尽 管 大 多 数 居 民 更 喜 欢FNLC 部 队 而 不 是 政 府 军 队 ， 人 们 普 遍 害 怕 即 将 来 到 的 暴 力 ， 选 择 呆 在 家 里 。 一 场 战 争 就 这 样 爆 发 了 。";
			a.ingamewars[60] = new War().Name(" 沙 巴 战 争").Attacker(" 扎 伊 尔").Defender(" 刚 果 民 族 解 放 阵 线")
				.AttackerInfluence(600 - num)
				.DefenderInfluence(400 + num)
				.TickTime(6)
				.AmericanSupportAttacker.SovietSupportDefender.CreateWar;
		}
	}
}
