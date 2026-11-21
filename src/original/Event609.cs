using EventsForDLC;
using UnityEngine;

public class Event609 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "直 到 永 远 ， 总 统 阁 下";
		text = "主 席 同 志 ， 一 个 无 关 痛 痒 的 小 国 传 来 了 意 料 之 外 的 消 息 。 臭 名 昭 著 的 雇 佣 兵 头 子 试 图 在 该 国 发 起 一 场 政 变 。 该 政 变 的 矛 头 直 指 该 国 总 统 阿 里 · 索 利 莱 。 其 所 领 导 的 民 族 统 一 阵 线 党 在 反 抗 亲 法 派 和 争 取 主 权 与 独 立 的 过 程 中 立 下 了 汗 马 功 劳 。 同 时 也 与 更 为 亲 法 ， 秉 持 着 实 用 主 义 的 艾 哈 迈 德 · 阿 卜 杜 拉 结 下 了 梁 子 。||索 利 莱 总 统 积 极 推 动 印 度 洋 的 中 立 化 ， 强 烈 谴 责 以 法 国 ， 英 国 和 苏 联 为 首 的 超 级 大 国 染 指 该 地 。 同 时 他 也 反 对 南 非 的 种 族 主 义 政 权 ， 多 次 要 求 加 大 对 南 非 的 制 裁 。 对 内 则 积 极 推 动 行 政 改 革 ， 废 除 封 建 陋 习 ： 如 挥 金 如 土 等 婚 丧 嫁 娶 和 夸 富 宴 等 铺 张 浪 费 等 行 为 。 他 还 积 极 反 对 穆 斯 林 传 统 习 俗 ， 制 定 了 婚 姻 法 并 强 迫 清 真 寺 还 地 。 他 借 鉴 了 我 国 与 坦 桑 尼 亚 的 经 验 ， 组 织 了 绰 号 为 “ 莫 斯 ” 的 青 年 近 卫 军 组 织 ， 该 国 的 投 票 门 槛 甚 至 只 有 十 四 岁 ； 在 经 济 上 发 展 农 业 ， 主 要 是 渔 业 以 谋 求 粮 食 自 给 。 他 还 多 次 强 调 要 在 法 国 撤 出 其 占 领 的 马 约 特 岛 后 才 考 虑 和 法 国 发 展 关 系 ， 甚 至 曾 打 算 过 组 织 武 装 部 队 入 侵 该 岛 。||很 明 显 ， 这 样 的 一 个 政 府 不 可 能 不 成 为 野 心 不 死 的 法 兰 西 帝 国 的 眼 中 钉 。 在 种 种 契 机 下 ， 两 个 路 线 的 矛 盾 ， 两 种 意 识 形 态 和 外 交 理 念 的 矛 盾 彻 底 浮 出 了 水 面 。||很 显 然 ， 只 要 我 们 愿 意 付 出 一 点 点 代 价 ， 法 兰 西 帝 国 主 义 者 的 阴 谋 定 会 失 败 。 但 问 题 是 ， 这 值 得 吗 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] <= 1 && a.modifies[3].active)
		{
			button_text[0] = " 帮 助 我 们 的 非 洲 同 志";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 是 个 疯 子 ， 而 我 是 个 聪 明 人";
		}
		if (a.empires[1].relations >= 700)
		{
			button_text[1] = " 和 苏 联 一 起 保 卫 科 摩 罗";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 和 苏 联 ？ 他 们 是 和 法 国 沆 瀣 一 气 的 一 群 人 ！";
		}
		if (a.allcountries[158].Gosstroy != 1 && a.data[56] > 1 && a.data[6] <= 700)
		{
			button_text[2] = " 支 持 法 国 人 的 义 举";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 殖 民 主 义 去 死 吧 ！";
		}
		button_text[3] = " 顺 其 自 然";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "直 到 永 远 ， 总 统 阁 下";
		if (result_num == 0)
		{
			text = " 我 们 谨 慎 的 提 供 驻 科 大 使 馆 工 作 者 向 索 利 莱 总 统 提 供 了 通 知 。 并 向 其 表 示 愿 意 提 供 必 要 的 帮 助 。||";
			a.data[9] -= 50;
			if (a.science[18])
			{
				text += "深 夜 ， 法 国 雇 佣 兵 乘 着 夜 色 攻 入 了 总 统 府 。 但 出 乎 意 料 遭 到 了 强 硬 的 抵 抗 ， 对 方 口 中 说 着 既 不 是 法 语 也 不 是 斯 瓦 希 里 语 的 奇 怪 语 言 ， 训 练 有 素 ， 指 挥 完 善 。 雇 佣 军 很 快 就 被 打 的 溃 不 成 军 ， 鲍 勃 本 人 也 受 了 伤 。 科 摩 罗 全 国 陷 入 了 紧 急 状 态 ， 全 国 人 民 都 被 动 员 起 来 保 卫 独 立 。 在 丢 下 了 十 具 尸 体 和 数 杆 步 枪 ， 以 及 一 份 手 写 的 政 变 计 划 后 ， 雇 佣 军 们 逃 离 了 科 摩 罗 。 他 们 有 的 前 往 马 约 特 岛 ， 也 有 的 前 往 留 尼 汪 。 鲍 勃 本 人 则 前 往 法 国 养 伤 后 不 治 身 亡 。||随 后 在 当 日 的 日 间 新 闻 上 ， 阿 里 · 索 利 莱 强 烈 谴 责 了 死 灰 复 燃 的 法 兰 西 殖 民 主 义 妄 图 染 指 科 摩 罗 。 “ 科 摩 罗 再 也 不 会 陷 入 痛 苦 的 殖 民 之 中 ， 这 不 是 几 个 人 几 条 枪 就 能 夺 去 的 胜 利 。 ” 总 统 阁 下 如 是 说 道 。 同 时 他 也 感 谢 了 我 国 的 帮 助 ， 他 不 仅 在 民 族 统 一 阵 线 党 的 新 党 章 中 认 可 了 毛 主 义 的 理 念 ， 并 公 开 向 我 们 靠 拢 。  ";
				a.allcountries[158].Gosstroy = 1;
				a.allcountries[158].SubGosstroy = 17;
				a.allcountries[158].LeaveAlliances();
				a.allcountries[158].proprc = true;
				a.allcountries[158].Torg = true;
				a.allcountries[158].name = "科 摩 罗 人 民 共 和 国";
			}
			else
			{
				text += "深 夜 ， 法 国 雇 佣 兵 乘 着 夜 色 攻 入 了 总 统 府 。 但 出 乎 意 料 遭 到 了 强 硬 的 抵 抗 ， 对 方 口 中 说 着 既 不 是 法 语 也 不 是 斯 瓦 希 里 语 的 奇 怪 语 言 。 他 们 尽 管 和 雇 佣 军 打 的 有 来 有 回 ， 鲍 勃 本 人 也 受 了 伤 ， 过 于 老 久 的 武 器 导 致 了 他 们 付 出 了 更 大 的 伤 亡 ， 神 秘 势 力 不 得 不 撤 退 ， 阿 里 总 统 也 就 此 被 捕 。 科 摩 罗 全 国 陷 入 了 紧 急 状 态 。||随 后 经 过 了 短 暂 的 军 事 管 理 后 ， 艾 哈 迈 德 · 阿 卜 杜 拉 总 统 宣 布 结 束 流 亡 ， 在 巴 黎 的 直 接 授 意 下 再 度 当 选 总 统 。 他 对 前 任 的 社 会 改 革 完 全 不 感 兴 趣 ， 更 别 提 无 神 论 和 反 法 元 素 了 。 但 法 国 对 现 状 很 满 意 ， 双 方 正 式 交 换 了 文 书 并 建 交 。 阿 里 也 被 判 处 叛 国 罪 而 被 处 死 。 但 是 ， 阿 卜 杜 勒 事 实 上 不 过 是 德 纳 尔 的 傀 儡 ， 雇 佣 兵 之 王 彻 底 支 配 了 这 个 小 岛 ， 看 起 来 它 又 一 次 回 到 了 独 立 之 前 … …||<color=red>直 到 永 远 啊 总 统 阁 下 ， 直 到 永 远 … …</color>";
				a.allcountries[158].Gosstroy = 0;
				a.allcountries[158].SubGosstroy = 7;
				a.allcountries[158].LeaveAlliances();
				a.allcountries[158].puppetOf = 21;
				a.allcountries[158].name = "科 摩 罗 伊 斯 兰 联 邦 共 和 国";
			}
		}
		if (result_num == 1)
		{
			text = " 我 们 决 定 利 用 与 苏 联 的 良 好 关 系 来 拯 救 科 摩 罗 。 深 夜 ， 法 国 雇 佣 兵 乘 着 夜 色 攻 入 了 总 统 府 。 但 出 乎 意 料 遭 到 了 强 硬 的 抵 抗 ， 对 方 口 中 说 着 既 不 是 法 语 也 不 是 斯 瓦 希 里 语 的 奇 怪 语 言 ， 训 练 有 素 ， 指 挥 完 善 。 雇 佣 军 很 快 就 被 打 的 溃 不 成 军 ， 鲍 勃 本 人 也 受 了 伤 。 事 后 方 知 这 支 英 勇 的 队 伍 是 驻 扎 在 安 哥 拉 的 古 巴 军 队 。 科 摩 罗 全 国 陷 入 了 紧 急 状 态 ， 全 国 人 民 都 被 动 员 起 来 保 卫 独 立 。 在 丢 下 了 三 十 具 尸 体 和 数 杆 步 枪 ， 以 及 一 份 手 写 的 政 变 计 划 后 ， 雇 佣 军 们 逃 离 了 科 摩 罗 。 他 们 有 的 前 往 马 约 特 岛 ， 也 有 的 前 往 留 尼 汪 。 鲍 勃 本 人 则 前 往 法 国 养 伤 后 不 治 身 亡 。||苏 联 愿 意 为 科 国 的 经 济 提 供 大 量 帮 助 ， 并 派 出 了 足 够 多 的 古 巴 士 兵 保 卫 该 国 。 只 要 其 愿 意 为 苏 联 提 供 足 够 的 香 蕉 。 从 工 业 到 城 市 建 设 ， 甚 至 在 领 土 问 题 上 苏 联 都 愿 意 为 其 开 绿 灯 。 但 是 苏 联 的 这 些 援 助 并 非 免 费 的 午 餐 ， 作 为 条 件 ， 该 国 必 须 优 先 和 苏 联 打 交 道 ， 并 不 征 收 对 苏 联 商 品 的 关 税 。 尽 管 该 国 对 我 们 的 好 感 大 于 苏 联 ， 但 是 苏 联 的 影 响 力 与 日 俱 增 ， 终 有 一 天 会 赶 超 我 们 的 。 ";
			a.data[8] -= 30;
			a.data[9] -= 20;
			a.allcountries[158].Gosstroy = 2;
			a.allcountries[158].SubGosstroy = 3;
			a.allcountries[158].LeaveAlliances();
			a.allcountries[158].prosov = true;
			a.allcountries[158].Torg = true;
			a.allcountries[158].name = "科 摩 罗 社 会 主 义 共 和 国";
		}
		if (result_num == 2)
		{
			text = "深 夜 ， 法 国 雇 佣 兵 攻 入 了 总 统 府 。 孱 弱 的 国 防 力 量 和 民 兵 难 以 抵 抗 强 大 的 法 国 军 队 。 在 付 出 了 大 量 伤 亡 后 ， 阿 里 总 统 宣 布 投 降 并 辞 职 。 随 后 ， 他 的 死 对 头 艾 哈 迈 德 · 阿 卜 杜 拉 宣 布 结 束 流 亡 ， 在 巴 黎 的 直 接 授 意 下 再 度 当 选 总 统 。 他 对 前 任 的 社 会 改 革 完 全 不 感 兴 趣 ， 更 别 提 无 神 论 和 反 法 元 素 了 。 但 法 国 对 现 状 很 满 意 ， 双 方 正 式 交 换 了 文 书 并 建 交 。 阿 里 也 被 判 处 叛 国 罪 而 被 处 死 。 但 是 ， 阿 卜 杜 勒 事 实 上 不 过 是 德 纳 尔 的 傀 儡 ， 雇 佣 兵 之 王 彻 底 支 配 了 这 个 小 岛 ， 看 起 来 它 又 一 次 回 到 了 独 立 之 前 。||我 国 外 交 部 发 言 人 发 表 声 明 ： “ 我 国 支 持 法 国 的 正 义 行 动 。 法 国 的 正 义 行 动 ， 撬 走 了 骑 在 非 洲 人 民 头 上 的 极 权 主 义 暴 君 ， 推 动 了 非 洲 社 会 的 进 步 ， 促 进 了 印 度 洋 地 区 的 稳 定 。 我 们 欢 迎 并 支 持 阿 卜 杜 拉 先 生 再 度 就 任 总 统 ， 并 期 待 两 国 关 系 发 展 的 新 时 代 ！ ”||法 国 感 谢 我 们 对 他 们 行 动 的 支 持 ， 阿 卜 杜 拉 ， 尤 其 是 他 背 后 的 鲍 勃 · 德 纳 尔 对 我 们 承 认 了 新 政 府 感 到 十 分 高 兴 ， 他 将 阿 卜 杜 拉 出 访 北 京 的 行 程 安 排 在 了 巴 黎 之 后 ， 甚 至 在 华 盛 顿 之 前 。 科 摩 罗 与 我 们 达 成 了 几 项 合 作 协 定 ， 友 谊 万 年 长 ！ ";
			a.data[8] -= 30;
			a.allcountries[158].Gosstroy = 0;
			a.allcountries[158].SubGosstroy = 7;
			a.allcountries[158].LeaveAlliances();
			a.allcountries[158].puppetOf = 21;
			a.allcountries[158].Torg = true;
			a.allcountries[158].name = "科 摩 罗 伊 斯 兰 联 邦 共 和 国";
		}
		if (result_num == 3)
		{
			text = " 深 夜 ， 法 国 雇 佣 兵 攻 入 了 总 统 府 。 孱 弱 的 国 防 力 量 和 民 兵 难 以 抵 抗 强 大 的 法 国 军 队 。 在 付 出 了 大 量 伤 亡 后 ， 阿 里 总 统 宣 布 投 降 并 辞 职 。 随 后 ， 他 的 死 对 头 艾 哈 迈 德 · 阿 卜 杜 拉 宣 布 结 束 流 亡 ， 在 巴 黎 的 直 接 授 意 下 再 度 当 选 总 统 。 他 对 前 任 的 社 会 改 革 完 全 不 感 兴 趣 ， 更 别 提 无 神 论 和 反 法 元 素 了 。 但 法 国 对 现 状 很 满 意 ， 双 方 正 式 交 换 了 文 书 并 建 交 。 阿 里 也 被 判 处 叛 国 罪 而 被 处 死 。 但 是 ， 阿 卜 杜 勒 事 实 上 不 过 是 德 纳 尔 的 傀 儡 ， 雇 佣 兵 之 王 彻 底 支 配 了 这 个 小 岛 ， 看 起 来 它 又 一 次 回 到 了 独 立 之 前 。";
			a.allcountries[158].Gosstroy = 0;
			a.allcountries[158].SubGosstroy = 7;
			a.allcountries[158].LeaveAlliances();
			a.allcountries[158].puppetOf = 21;
			a.allcountries[158].name = "科 摩 罗 伊 斯 兰 联 邦 共 和 国";
		}
	}
}
