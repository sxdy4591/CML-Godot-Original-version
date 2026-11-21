using EventsForDLC;
using UnityEngine;

public class Event527 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 保 革 伯 仲 ： 第 二 幕";
		if (a.resultOfEvents[522] != 0)
		{
			text = " 因 为 在 党 总 裁 竞 选 中 输 给 了 大 平 正 芳 ， <color=#0000FF>自 由 民 主 党</color> 首 相 <color=#0000FF>福 田 赳 夫</color> 正 式 辞 去 党 总 裁 的 职 务 ， 其 他 内 阁 成 员 也 随 之 辞 职 。 而 福 田 内 阁 也 成 为 了 日 本 宪 法 中 唯 一 一 个 因 执 政 党 领 导 人 选 举 失 败 而 辞 职 的 内 阁 。 1 0 月 7 日 ， 新 一 届 众 议 院 选 举 即 将 开 始 。 此 时 的 <color=#0000FF>自 由 民 主 党</color> 依 旧 深 陷 洛 克 希 德 丑 闻 之 中 。 伴 随 着 秘 密 津 贴 和 空 跑 部 委 等 违 规 行 为 的 曝 光 ， 民 众 对 执 政 党 的 批 评 愈 演 愈 烈 。 此 外 大 平 正 芳 打 着 财 政 重 建 的 旗 号 主 张 征 收 一 般 消 费 税 ， 但 遭 到 党 内 外 强 烈 反 对 。 虽 然 他 本 人 最 终 撤 回 了 提 案 ， 但 这 一 行 为 致 使 许 多 人 对 执 政 党 的 不 满 加 深 了 。||在 新 的 书 记 长 飞 鸟 田 一 雄 的 带 领 下 ， <color=#008000>社 会 党</color> 开 始 调 整 其 原 有 路 线 ， 并 与 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 正 式 建 立 了 联 系 。 但 后 两 党 对 <color=#008000>社 会 党</color> 目 前 的 情 况 仍 抱 有 疑 虑 。 上 届 选 举 的 结 果 以 及 <color=#008000>社 会 党</color> 的 内 部 纷 争 让 两 党 中 的 一 部 分 人 开 始 尝 试 与 <color=#0000FF>自 由 民 主 党</color> 组 成 联 盟 （ 尽 管 他 们 仍 未 放 弃 “ 社 公 民 路 线 ” ） 。 而 <color=#8B0000>日 本 共 产 党</color> 也 积 极 拉 拢 城 市 市 民 的 选 票 ， 试 图 进 一 步 增 强 自 身 的 实 力 。||接 下 来 ， 我 们 该 选 择 行 动 方 向 了 ： 是 支 援 <color=#008000>社 会 党</color> 完 成 参 政 交 代 的 目 标 还 是 援 助 <color=#8B0000>共 产 党</color> 扩 大 它 的 势 力 范 围 ， 亦 或 是 对 其 他 在 野 党 给 予 更 多 帮 助 。 又 或 者 ， 我 们 可 以 继 续 向 <color=#0000FF>自 由 民 主 党</color> 伸 出 援 手 ， 毕 竟 现 任 总 裁 大 平 正 芳 是 前 田 中 角 荣 内 阁 的 外 交 大 臣 ， 他 积 极 参 与 到 了 中 日 邦 交 正 常 化 的 进 程 中 并 与 我 们 建 立 了 不 错 的 关 系 。 如 果 能 够 帮 他 一 把 ， 不 仅 可 以 进 一 步 深 化 两 国 贸 易 关 系 ， 也 能 借 此 缓 和 与 美 国 的 关 系 。";
		}
		else
		{
			text = " <color=#008000>社 会 党</color> 的 内 部 派 系 矛 盾 问 题 致 使 它 作 为 革 新 联 合 政 府 的 主 导 者 在 内 外 诸 多 事 务 上 都 处 于 左 右 摇 摆 的 状 态 ， 这 又 让 它 与 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 之 间 的 关 系 愈 发 疏 远 ， 联 合 政 府 也 变 得 越 来 越 不 稳 定 。 并 且 因 为 这 是 “ 5 5 年 体 制 ” 下 的 第 一 个 非 <color=#0000FF>自 由 民 主 党</color> 政 府 ， 各 党 均 缺 乏 足 够 的 执 政 经 验 ， 使 得 民 众 对 这 一 政 府 的 信 任 度 也 有 所 下 降 。 财 政 界 和 反 对 党 更 是 在 寻 找 一 切 可 以 用 来 攻 击 的 点 来 针 对 政 府 。||最 终 在 1 9 7 9 年 7 月 ， 反 对 党 对 政 府 的 不 信 任 案 在 <color=#FFA500>民 主 社 会 党</color> 部 分 议 员 反 水 、 <color=#8B0000>共 产 党</color> 部 分 议 员 弃 权 与 少 量 议 员 缺 席 的 情 况 下 得 到 通 过 。 当 年 1 0 月 ， 新 一 轮 大 选 即 将 展 开 。 考 虑 到 先 前 联 合 政 府 的 矛 盾 ， 我 们 恐 怕 很 难 指 望 这 次 三 党 的 联 盟 能 继 续 维 持 。 但 如 果 我 们 付 出 的 努 力 足 够 多 ， 也 许 还 是 可 以 说 服 它 们 继 续 联 合 执 政 ？ 不 管 怎 样 ， 选 择 权 在 您 ！ ";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (a.data[56] < 3)
		{
			button_text[0] = " 向 社 会 党 伸 出 援 手";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 人 对 他 们 有 兴 趣";
		}
		if (a.data[56] == 2 || a.data[56] == 3)
		{
			button_text[1] = " 助 其 他 在 野 党 一 臂 之 力";
		}
		else if (a.data[56] < 2)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 要 玩 议 会 游 戏 ？";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 必 要 浪 费 精 力 在 其 他 人 身 上";
		}
		if (a.data[56] == 2 && a.resultOfEvents[524] == 1)
		{
			button_text[2] = " 帮 助 共 产 党";
		}
		else if (a.data[56] < 2)
		{
			Object.Destroy(button[2]);
			button_text[2] = " 打 倒 修 正 主 义 者 ！";
		}
		else if (a.data[56] > 2)
		{
			Object.Destroy(button[2]);
			button_text[2] = " 别 和 民 主 之 敌 走 那 么 近 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 日 共 不 会 和 我 们 合 作";
		}
		if (a.data[56] > 2 && a.resultOfEvents[522] == 2)
		{
			button_text[3] = " 为 自 由 民 主 党 提 供 帮 助";
		}
		else if (a.data[56] <= 2)
		{
			Object.Destroy(button[3]);
			button_text[3] = " 跟 美 国 走 狗 眉 来 眼 去 ？";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 他 们 不 会 听 我 们 的";
		}
		button_text[4] = " 让 我 们 观 望 局 势 发 展";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 保 革 伯 仲 ： 第 二 幕";
		if (result_num == 0)
		{
			if (a.resultOfEvents[522] != 0)
			{
				text = " 我 们 决 定 全 力 帮 助 <color=#008000>社 会 党</color> 。 在 内 部 矛 盾 得 到 一 定 程 度 的 解 决 后 ， <color=#008000>社 会 党</color> 得 以 腾 出 更 多 精 力 应 对 选 举 。 同 时 我 们 向 其 提 供 了 大 量 资 金 和 特 勤 服 务 ， 帮 助 其 拿 下 了 多 个 关 键 选 区 。||最 终 <color=#008000>社 会 党</color> 取 得 前 所 未 有 的 大 胜 ， 夺 得 1 4 5 席 。 其 他 党 情 况 如 下 ： <color=#FFFF00>公 明 党</color> 5 7 席 ， <color=#FFA500>民 主 社 会 党</color> 3 2 席 ， <color=#8B0000>共 产 党</color> 3 7 席 ， <color=yellow>社 会 民 主 联 合</color> 2 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 2 席 ， 无 所 属 议 员 1 9 席 。 <color=#0000FF>自 由 民 主 党</color> 遭 受 大 败 ， 只 拿 到 2 1 7 席 ， 失 去 了 半 数 多 数 并 首 次 成 为 了 在 野 党 。 受 此 影 响 ， 大 平 正 芳 辞 去 了 党 总 裁 的 职 务 ， 前 首 相 <color=#0000FF>福 田 赳 夫</color> 再 次 成 为 总 裁 。||经 过 谈 判 ， <color=#008000>社 会 党</color> 、 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 正 式 组 成 了 联 合 政 府 。 新 政 府 由 飞 鸟 田 一 雄 领 导 ， 宣 布 将 带 领 日 本 走 向 “ 非 武 装 积 极 中 立 ” 路 线 ， 改 组 自 卫 队 ， 保 护 劳 工 阶 层 ， 推 动 公 有 化 进 程 ， 同 时 改 善 市 民 生 活 水 平 。 在 外 交 上 ， 新 政 府 表 示 不 久 便 会 与 美 国 开 展 关 于 废 除 《 日 美 安 保 条 约 》 的 谈 判 ， 同 时 开 始 加 强 与 苏 联 和 社 会 主 义 阵 营 的 关 系 ， 发 展 同 其 他 左 翼 政 党 的 关 系 ， 并 呼 吁 推 动 全 球 裁 军 以 及 无 核 化 。 ";
				a.allcountries[44].Gosstroy = 2;
				a.allcountries[44].SubGosstroy = 8;
				a.allcountries[44].Vyshi = false;
				a.allcountries[44].Torg = true;
				a.data[8] -= 40;
				a.data[9] -= 40;
				a.data[1] += 50;
				a.data[3] += 50;
				a.data[6] += 5;
				a.influencePRC += 30;
				a.empires[0].relations -= 100;
			}
			else
			{
				text = " 我 们 决 定 同 之 前 一 样 全 力 帮 助 <color=#008000>社 会 党</color> 。 尽 管 其 内 部 矛 盾 尚 未 得 到 彻 底 解 决 ， 但 大 量 的 资 金 和 物 资 支 持 还 是 让 <color=#008000>社 会 党</color> 暂 时 得 以 腾 出 更 多 精 力 应 对 选 举 。 同 时 我 们 在 日 本 的 特 工 发 起 了 行 动 ： 破 坏 执 政 党 候 选 人 竞 选 集 会 、 组 织 受 到 公 害 病 影 响 的 市 民 展 开 集 会 抗 议 、 派 出 社 会 活 动 家 积 极 开 展 宣 传 工 作 等 ， 成 功 帮 助 <color=#008000>社 会 党</color> 拿 下 多 个 关 键 选 区 。||最 终 <color=#008000>社 会 党</color> 虽 未 赢 得 像 上 次 一 样 多 的 席 位 ， 但 仍 取 得 了 1 4 5 席 的 成 绩 。 其 他 党 情 况 如 下 ： <color=#FFFF00>公 明 党</color> 5 7 席 ， <color=#FFA500>民 主 社 会 党</color> 3 2 席 ， <color=#8B0000>共 产 党</color> 3 7 席 ， <color=yellow>社 会 民 主 联 合</color> 2 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 2 席 ， 无 所 属 议 员 1 9 席 。 <color=#0000FF>自 由 民 主 党</color> 遭 受 又 一 次 失 败 ， 只 拿 到 2 1 7 席 。 受 此 影 响 ， 大 平 正 芳 辞 去 了 党 总 裁 的 职 务 ， 前 首 相 <color=#0000FF>福 田 赳 夫</color> 再 次 成 为 总 裁 。||经 过 艰 难 的 谈 判 ， <color=#008000>社 会 党</color> 、 <color=#FFFF00>公 明 党</color> 和 <color=#FFA500>民 主 社 会 党</color> 再 一 次 组 成 了 联 合 政 府 。 新 政 府 由 飞 鸟 田 一 雄 领 导 ， 宣 布 将 继 续 坚 持 “ 非 武 装 积 极 中 立 ” 路 线 ， 改 组 自 卫 队 ， 保 护 劳 工 阶 层 ， 同 时 改 善 市 民 生 活 水 平 。 而 在 其 他 两 党 的 要 求 下 ， <color=#008000>社 会 党</color> 也 同 意 放 缓 了 对 国 有 化 和 国 家 计 划 委 员 会 的 推 动 。 在 外 交 上 ， 新 政 府 将 继 续 推 动 关 于 废 除 《 日 美 安 保 条 约 》 的 谈 判 ， 同 时 加 强 与 苏 联 和 社 会 主 义 阵 营 的 关 系 ， 发 展 同 其 他 左 翼 政 党 的 关 系 ， 并 呼 吁 推 动 全 球 裁 军 以 及 无 核 化 。";
				a.allcountries[44].Gosstroy = 2;
				a.allcountries[44].SubGosstroy = 8;
				a.allcountries[44].Vyshi = false;
				a.allcountries[44].Torg = true;
				a.data[8] -= 80;
				a.data[9] -= 80;
				a.data[1] += 50;
				a.data[3] += 50;
				a.data[6] += 5;
				a.influencePRC += 30;
				a.empires[0].relations -= 100;
			}
		}
		if (result_num == 1)
		{
			text = " 考 虑 到 <color=#008000>社 会 党</color> 目 前 的 糟 糕 情 况 ， 我 们 决 定 将 有 限 的 资 源 投 入 到 对 其 他 在 野 党 上 。 随 即 我 们 向 <color=#FFFF00>公 明 党</color> 、 <color=#FFA500>民 主 社 会 党</color> 、 <color=yellow>社 会 民 主 联 合</color> 提 供 了 大 量 资 金 和 特 勤 服 务 ， 成 功 帮 助 其 拿 下 了 多 个 关 键 选 区 。||最 终 在 野 党 取 得 大 胜 ， <color=#FFFF00>公 明 党</color> 、 <color=#FFA500>民 主 社 会 党</color> 和 <color=yellow>社 会 民 主 联 合</color> 分 别 赢 下 6 2 席 、 4 0 席 和 1 0 席 。 其 他 党 情 况 如 下 ： <color=#008000>社 会 党</color> 1 0 2 席 ， <color=#8B0000>共 产 党</color> 3 9 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 4 席 ， 无 所 属 议 员 1 9 席 。 <color=#0000FF>自 由 民 主 党</color> 遭 遇 失 败 ， 只 拿 到 2 3 5 席 ， 失 去 多 数 的 它 不 得 不 拉 拢 无 所 属 议 员 、 <color=#0000FF>新 自 由 俱 乐 部</color> 等 力 量 来 凑 足 半 数 以 上 的 地 位 。||社 会 党 遭 遇 了 又 一 次 挫 折 后 ， 党 内 斗 争 更 加 剧 烈 ， 长 期 把 持 党 的 主 导 权 的 <color=red>社 会 主 义 协 会</color> 遭 到 了 其 他 各 派 的 一 致 批 评 ， 左 派 的 实 力 正 在 不 断 缩 水 。 而 勉 强 保 住 地 位 的 <color=#0000FF>自 由 民 主 党</color> 也 并 不 好 过 ， 党 内 要 求 大 平 正 芳 辞 去 总 裁 职 务 的 呼 声 一 浪 高 过 一 浪 。 分 析 人 士 认 为 ， 在 未 来 数 周 内 执 政 党 内 部 极 有 可 能 发 生 重 大 变 故 。 而 在 野 党 联 盟 在 此 次 选 举 中 赢 得 大 量 席 位 ， 彼 此 关 系 也 更 加 紧 密 。 也 许 不 久 之 后 ， 它 们 将 合 并 成 一 个 统 一 的 “ 中 道 革 新 政 党 ” 。||新 政 府 由 大 平 正 芳 领 导 ， 宣 布 将 践 行 “ 综 合 安 全 构 想 ” ， 从 军 事 和 非 军 事 两 方 面 对 日 本 社 会 进 行 全 面 保 障 。 在 外 交 上 ， 新 政 府 将 改 变 前 任 内 阁 的 “ 全 方 位 外 交 ” 政 策 ， 强 化 《 日 美 安 保 条 约 》 并 加 强 与 北 约 的 联 系 ， 以 “ 西 方 阵 营 的 一 员 ” 谋 求 稳 定 的 全 球 秩 序 。 同 时 也 试 图 加 强 亚 太 地 区 的 经 济 区 域 合 作 。 不 久 ， 日 本 政 府 宣 布 抵 制 1 9 8 0 年 莫 斯 科 奥 运 会 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 6;
			a.data[8] -= 30;
			a.data[9] -= 30;
			a.data[1] -= 50;
			a.data[3] += 50;
			a.data[6] += 8;
			a.empires[0].relations -= 80;
			a.influencePRC += 20;
		}
		if (result_num == 2)
		{
			text = " 为 了 兑 现 此 前 两 党 关 系 正 常 化 期 间 作 出 的 承 诺 ， 我 们 向 日 本 <color=#8B0000>共 产 党</color> 提 供 了 大 量 资 金 支 持 与 特 勤 服 务 ， 并 且 动 员 了 大 批 青 年 和 社 会 活 动 家 帮 助 他 们 吸 引 城 市 临 时 工 、 钟 点 工 等 被 封 闭 性 企 业 工 会 体 系 排 斥 的 工 人 为 日 共 拉 票 。 同 时 向 媒 体 泄 露 了 诸 多 自 民 党 内 部 材 料 ， 成 功 帮 助 日 共 拿 下 了 多 个 关 键 选 区 。||最 终 <color=#8B0000>共 产 党</color> 获 得 了 史 无 前 例 的 7 0 个 席 位 ， 一 跃 成 为 众 议 院 第 三 大 党 。 尽 管 无 法 与 其 他 在 野 党 组 成 联 合 政 府 ， 但 这 依 然 彰 显 了 <color=#8B0000>共 产 党</color> 的 强 大 实 力 。 其 他 党 情 况 如 下 ： <color=#008000>社 会 党</color> 1 0 2 席 ， <color=#FFFF00>公 明 党</color> 5 5 席 ， <color=#FFA500>民 主 社 会 党</color> 3 0 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 4 席 ， <color=yellow>社 会 民 主 联 合</color> 2 席 ， 无 所 属 议 员 1 9 席 。 <color=#0000FF>自 由 民 主 党</color> 遭 遇 失 败 ， 只 拿 到 2 3 1 席 ， 失 去 多 数 的 它 不 得 不 拉 拢 无 所 属 议 员 、 <color=#0000FF>新 自 由 俱 乐 部</color> 等 力 量 以 凑 足 半 数 以 上 的 席 位 。||社 会 党 遭 遇 了 又 一 次 挫 折 后 ， 党 内 斗 争 更 加 剧 烈 ， 长 期 把 持 党 的 主 导 权 的 <color=red>社 会 主 义 协 会</color> 遭 到 了 其 他 各 派 的 一 致 批 评 ， 左 派 的 实 力 正 在 不 断 缩 水 。 而 勉 强 保 住 地 位 的 <color=#0000FF>自 由 民 主 党</color> 也 并 不 好 过 ， 党 内 要 求 大 平 正 芳 辞 去 总 裁 职 务 的 呼 声 一 浪 高 过 一 浪 。 分 析 人 士 认 为 ， 在 未 来 数 周 内 执 政 党 内 部 极 有 可 能 发 生 重 大 变 故 。||新 政 府 由 大 平 正 芳 领 导 ， 宣 布 将 践 行 “ 综 合 安 全 构 想 ” ， 从 军 事 和 非 军 事 两 方 面 对 日 本 社 会 进 行 全 面 保 障 。 在 外 交 上 ， 新 政 府 将 改 变 前 任 内 阁 的 “ 全 方 位 外 交 ” 政 策 ， 强 化 《 日 美 安 保 条 约 》 并 加 强 与 北 约 的 联 系 ， 以 “ 西 方 阵 营 的 一 员 ” 谋 求 稳 定 的 全 球 秩 序 。 同 时 也 试 图 加 强 亚 太 地 区 的 经 济 区 域 合 作 。 不 久 ， 日 本 政 府 宣 布 抵 制   1 9 8 0   年 莫 斯 科 奥 运 会 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 6;
			a.data[8] -= 30;
			a.data[9] -= 30;
			a.data[1] -= 50;
			a.data[3] += 50;
			a.data[6] += 8;
			a.empires[0].relations -= 80;
			a.influencePRC += 20;
		}
		if (result_num == 3)
		{
			text = " 我 们 最 终 决 定 与 上 次 一 样 继 续 援 助 <color=#0000FF>自 由 民 主 党</color> ， 尤 其 是 对 其 内 部 的 亲 华 派 议 员 提 供 了 全 方 位 的 服 务 ， 极 大 增 强 了 他 们 的 实 力 ， 这 让 他 们 有 机 会 对 党 施 加 更 大 的 影 响 力 。 尽 管 一 些 人 持 反 对 意 见 ， 但 总 归 不 能 让 先 前 付 出 的 努 力 付 诸 东 流 ， 不 是 吗 ？||最 终 <color=#0000FF>自 由 民 主 党</color> 顶 住 了 压 力 ， 勉 强 达 到 了 多 数 ， 拿 下 2 5 6 席 。 尽 管 党 内 仍 有 对 总 裁 大 平 正 芳 的 批 评 之 声 ， 但 至 少 目 前 为 止 事 情 还 在 掌 握 之 中 。 其 他 党 情 况 如 下 ： <color=#008000>社 会 党</color> 1 0 2 席 、 <color=#FFFF00>公 明 党</color> 5 7 席 、 <color=#FFA500>民 主 社 会 党</color> 3 7 席 、 <color=#8B0000>共 产 党</color> 3 4 席 、 <color=#0000FF>新 自 由 俱 乐 部</color> 4 席 、 <color=yellow>社 会 民 主 联 合</color> 2 席 、 无 所 属 议 员 1 9 席 。||新 政 府 由 大 平 正 芳 领 导 ， 宣 布 将 践 行 “ 综 合 安 全 构 想 ” ， 从 军 事 和 非 军 事 两 方 面 对 日 本 社 会 进 行 全 面 保 障 。 在 外 交 上 ， 新 政 府 将 改 变 前 任 内 阁 的 “ 全 方 位 外 交 ” 政 策 ， 强 化 《 日 美 安 保 条 约 》 并 加 强 与 北 约 的 联 系 ， 以 “ 西 方 阵 营 的 一 员 ” 谋 求 稳 定 的 全 球 秩 序 。 同 时 也 试 图 加 强 亚 太 地 区 的 经 济 区 域 合 作 。 不 久 ， 日 本 政 府 宣 布 抵 制   1 9 8 0   年 莫 斯 科 奥 运 会 。";
			a.allcountries[44].Gosstroy = 3;
			a.allcountries[44].SubGosstroy = 6;
			a.allcountries[44].prcinfl += 20;
			a.data[8] -= 30;
			a.data[9] -= 30;
			a.data[1] -= 50;
			a.data[3] += 50;
			a.data[6] -= 15;
			a.empires[0].relations += 80;
			a.empires[0].power += 20;
			a.influencePRC += 20;
		}
		if (result_num == 4)
		{
			text = " 我 们 决 定 按 兵 不 动 ， 静 观 局 势 发 展 。||最 终 <color=#008000>社 会 党</color> 遭 受 挫 折 ， 只 拿 到 1 0 7 席 。 其 他 在 野 党 则 取 得 胜 利 ： <color=#FFFF00>公 明 党</color> 5 7 席 ， <color=#FFA500>民 主 社 会 党</color> 3 5 席 ， <color=#8B0000>共 产 党</color> 3 9 席 ， <color=#0000FF>新 自 由 俱 乐 部</color> 4 席 ， <color=yellow>社 会 民 主 联 合</color> 2 席 ， 无 所 属 议 员 1 9 席 。 <color=#0000FF>自 由 民 主 党</color> 依 旧 未 能 拿 到 多 数 ， 只 有 2 4 8 席 ， 不 得 不 拉 拢 无 所 属 议 员 和 <color=#0000FF>新 自 由 俱 乐 部</color> 以 凑 足 半 数 以 上 的 席 位 。||新 政 府 由 大 平 正 芳 领 导 ， 宣 布 将 践 行 “ 综 合 安 全 构 想 ” ， 从 军 事 和 非 军 事 两 方 面 对 日 本 社 会 进 行 全 面 保 障 。 在 外 交 上 ， 新 政 府 将 改 变 前 任 内 阁 的 “ 全 方 位 外 交 ” 政 策 ， 强 化 《 日 美 安 保 条 约 》 并 加 强 与 北 约 的 联 系 ， 以 “ 西 方 阵 营 的 一 员 ” 谋 求 稳 定 的 全 球 秩 序 。 同 时 也 试 图 加 强 亚 太 地 区 的 经 济 区 域 合 作 。 不 久 ， 日 本 政 府 宣 布 抵 制 1 9 8 0 年 莫 斯 科 奥 运 会 。";
			a.empires[0].power += 20;
		}
	}
}
