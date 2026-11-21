using EventsForDLC;
using UnityEngine;

public class Event37 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 埃 及 ： 纳 赛 尔 的 遗 产";
		text = " 自 贾 迈 勒 · 阿 卜 杜 勒 · 纳 赛 尔 去 世 后 ， 阿 拉 伯 社 会 主 义 联 盟 提 名 穆 罕 默 德 · 安 瓦 尔 · 萨 达 特 作 为 新 总 统 。 类 似 勃 列 日 涅 夫 ， 一 开 始 ， 纳 赛 尔 的 支 持 者 将 萨 达 特 视 为 临 时 性 的 过 渡 人 物 ， 他 们 认 为 萨 达 特 只 不 过 是 前 总 统 的 傀 儡 ， 因 此 将 萨 达 特 视 为 可 以 轻 松 操 纵 的 人 。 不 久 ， 萨 达 特 通 过 发 起 “ 纠 正 运 动 ” ， 清 洗 了 以 阿 社 盟 总 书 记 、 副 总 统 阿 里 · 萨 布 里 为 首 的 多 位 纳 赛 尔 主 义 者 ， 通 过 这 些 举 措 ， 他 得 以 保 住 总 统 职 位 ， 成 为 真 正 的 埃 及 领 导 人 。|此 后 ， 萨 达 特 逐 渐 开 始 抛 弃 纳 赛 尔 的 政 治 遗 产 ， 开 始 进 行 解 冻 和 体 制 改 革 。 对 内 ， 在 政 治 上 ， 萨 达 特 削 弱 了 秘 密 警 察 的 权 力 ， 放 松 了 政 治 控 制 ， 党 禁 被 逐 渐 被 放 开 ， 当 局 允 许 成 立 反 对 党 ， 并 开 始 拆 解 执 政 党 阿 拉 伯 社 会 主 义 联 盟 — — 其 右 翼 组 成 了 自 由 社 会 主 义 党 ， 中 间 翼 成 立 了 埃 及 阿 拉 伯 社 会 主 义 党 ， 左 翼 组 成 了 民 族 进 步 统 一 党 。 在 解 冻 的 影 响 下 ， 许 多 政 治 犯 被 释 放 ， 民 间 建 制 外 政 治 活 动 再 次 开 始 活 跃 ， 如 埃 及 共 产 党 在 1 9 7 5 年 重 组 ， 而 为 了 打 压 纳 赛 尔 主 义 者 和 共 产 主 义 者 等 左 翼 势 力 ， 萨 达 特 选 择 扶 持 曾 被 纳 赛 尔 打 压 的 伊 斯 兰 主 义 者 ， 用 他 们 的 力 量 打 压 民 间 的 左 翼 影 响 力 ， 随 着 伊 斯 兰 主 义 者 影 响 力 的 上 升 ， 世 俗 化 被 逆 转 了 ； 在 经 济 上 ， 埃 及 开 始 减 少 阿 拉 伯 社 会 主 义 的 要 素 ， 进 行 名 为 “ 开 放 ” （ I n f i t a h ） 的 经 济 自 由 化 , 鼓 励 外 资 的 进 入 ， 进 行 市 场 化 ， 结 束 国 营 部 门 的 主 导 地 位 ， 并 削 减 福 利 政 策 。 对 外 ， 萨 达 特 疏 远 了 苏 联 ， 减 少 了 两 国 合 作 ， 结 束 了 苏 联 驻 军 ， 逐 渐 抛 弃 了 泛 阿 拉 伯 主 义 （ 疏 远 了 利 比 亚 、 埃 及 和 叙 利 亚 共 同 组 织 的 阿 拉 伯 共 和 国 联 邦 ） ， 并 开 始 同 以 色 列 接 触 ， 接 近 西 方 阵 营 ， 这 些 政 策 使 得 埃 及 同 阿 拉 伯 国 家 的 关 系 极 度 恶 化 了 ， 埃 及 同 利 比 亚 和 叙 利 亚 等 国 家 近 乎 敌 对 。 这 些 政 策 使 得 萨 达 特 在 国 内 外 都 不 受 欢 迎 。||在 经 济 下 行 、 短 缺 经 济 和 失 业 问 题 的 影 响 下 ， 当 局 的 决 定 上 涨 食 品 价 格 的 改 革 措 施 成 为 了 压 垮 骆 驼 的 最 后 一 根 稻 草 。 很 快 ， 自 发 的 民 众 抗 议 从 亚 历 山 大 兵 工 厂 开 始 蔓 延 到 开 罗 、 卢 克 索 和 阿 斯 旺 等 多 个 大 城 市 ， 工 人 、 学 生 和 各 个 社 会 团 体 很 快 被 动 员 起 来 ， 人 群 中 不 乏 纳 赛 尔 的 支 持 者 ， 他 们 高 呼 “ 纳 赛 尔 ， 纳 赛 尔 ！ ” 、 “ ‘ 开 放 ’ 政 策 是 盗 贼 ， 正 在 窃 取 埃 及 人 民 的 早 餐 ” 等 口 号 ， 并 对 警 察 局 等 政 府 机 构 和 阿 社 盟 党 部 发 起 攻 击 。||显 然 ， 现 在 正 是 干 预 埃 及 的 好 机 会 ， 我 们 是 否 要 做 些 什 么 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.allcountries[30].stab == 1)
		{
			button_text[0] = " 用 一 切 手 段 去 支 持 抗 议 者 煽 动 推 翻 萨 达 特 政 权 ， 并 帮 助 纳 赛 尔 主 义 者 重 掌 权 力";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 对 埃 及 内 政 的 干 涉 太 激 进 了 ！";
		}
		if (GlobalScript.inst.gameState.data[9] >= 20 && GlobalScript.inst.gameState.data[56] <= 2)
		{
			button_text[1] = " 帮 助 利 比 亚 和 叙 利 亚 消 灭 萨 达 特";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 真 的 需 要 北 非 吗 ？";
		}
		if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.data[56] <= 1)
		{
			button_text[2] = " 纳 赛 尔 主 义 者 和 萨 达 特 都 不 值 得 信 任 ， 我 们 将 培 植 埃 及 共 产 主 义 者 的 联 合 阵 线 ， 为 革 命 做 准 备";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 会 支 持 深 入 干 预 北 非 国 家";
		}
		if (GlobalScript.inst.gameState.data[9] >= 60 && GlobalScript.inst.gameState.data[56] >= 3)
		{
			button_text[3] = " 纳 赛 尔 主 义 者 和 萨 达 特 都 不 值 得 信 任 ， 我 们 将 培 植 埃 及 自 由 主 义 者 的 联 合 阵 线 ， 为 革 命 做 准 备";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 这 些 人 和 萨 达 特 的 区 别 很 大 吗 ？";
		}
		button_text[4] = " 埃 及 内 政 并 不 值 得 我 们 关 心";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 埃 及 ： 纳 赛 尔 的 遗 产";
		switch (result_num)
		{
		case 0:
			text = " 我 们 决 定 积 极 干 预 局 势 ， 支 持 抗 议 者 。 在 我 们 的 介 入 下 ， 各 个 城 市 的 抗 议 者 得 以 在 纳 赛 尔 的 旗 号 下 组 织 起 统 一 的 指 挥 机 构 ， 许 多 武 器 通 过 秘 密 渠 道 落 入 他 们 手 中 ， 他 们 立 即 使 用 这 些 武 器 攻 占 政 府 机 构 ， 并 筑 起 街 垒 同 军 警 对 峙 。 在 开 罗 和 其 他 一 些 城 市 ， 对 峙 双 方 开 始 了 巷 战 并 导 致 多 人 死 伤 。 萨 达 特 试 图 争 取 美 国 和 以 色 列 的 支 持 ， 但 这 使 文 官 和 军 官 都 对 他 产 生 了 强 烈 的 敌 意 ， 他 们 没 有 忘 记 1 9 7 3 年 的 失 败 。 为 了 避 免 局 势 进 一 步 恶 化 ， 不 满 萨 达 特 的 文 官 和 军 官 联 合 起 来 发 起 了 一 场 政 变 ， 逮 捕 了 萨 达 特 ， 并 开 始 同 抗 议 者 进 行 谈 判 。 在 谈 判 后 ， 正 统 纳 赛 尔 主 义 者 阿 里 · 萨 布 里 成 为 了 新 总 统 ， 开 始 将 纳 赛 尔 主 义 者 、 抗 议 者 的 组 织 、 政 变 萨 达 特 的 官 员 组 织 、 温 和 社 会 主 义 者 、 拆 解 出 的 阿 社 盟 三 党 和 共 产 党 团 结 在 全 新 的 阿 拉 伯 埃 及 纳 赛 尔 民 族 团 结 阵 线 中 。 新 政 府 开 始 恢 复 泛 阿 拉 伯 主 义 的 宣 传 ， 并 重 启 在 阿 拉 伯 共 和 国 联 邦 中 的 活 动 ， 并 恢 复 同 苏 联 、 中 国 、 利 比 亚 、 叙 利 亚 、 伊 拉 克 和 其 他 社 会 主 义 国 家 的 友 好 关 系 。 与 此 同 时 ， 新 总 统 还 宣 布 取 消 “ 开 放 ” 政 策 和 经 济 自 由 化 ， 重 启 世 俗 化 、 打 压 伊 斯 兰 主 义 者 并 在 苏 联 和 我 们 的 援 助 下 进 行 更 开 明 的 再 纳 赛 尔 主 义 化 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.empires[1].relations += 80;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.data[8] -= 40;
			GlobalScript.inst.gameState.empires[0].power -= 10;
			GlobalScript.inst.gameState.allcountries[30].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 15;
			GlobalScript.inst.gameState.allcountries[30].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[30].Torg = true;
			break;
		case 1:
			if (GlobalScript.inst.gameState.allcountries[13].Torg || GlobalScript.inst.gameState.allcountries[30].stab == 1)
			{
				text = " 我 们 最 终 决 定 通 过 利 比 亚 和 叙 利 亚 来 干 涉 埃 及 内 政 。 利 比 亚 和 叙 利 亚 在 我 们 的 帮 助 和 苏 联 克 格 勃 的 秘 密 批 准 下 ， 联 合 起 来 制 订 了 一 项 消 灭 埃 及 总 统 的 计 划 。 不 久 ， 利 比 亚 和 叙 利 亚 就 派 遣 民 兵 和 特 工 秘 密 进 入 埃 及 进 内 ， 混 入 抗 议 者 的 队 伍 ， 并 秘 密 向 抗 议 者 提 供 武 器 。 而 克 格 勃 特 工 则 通 过 埃 及 共 产 党 和 民 族 统 一 进 步 党 的 组 织 网 络 串 联 起 抗 议 者 ， 并 将 他 们 吸 收 入 组 织 之 内 。 1 0 月 1 9 日 ， 安 瓦 尔 · 萨 达 特 在 开 罗 解 放 广 场 对 埃 及 抗 议 者 讲 话 时 被 一 名 愤 怒 的 抗 议 者 枪 击 ， 当 场 身 亡 ； 而 抗 议 者 组 织 的 民 兵 冲 入 位 于 开 罗 的 政 府 机 构 ， 强 行 解 除 了 萨 达 特 的 亲 信 们 的 职 务 ， 埃 及 进 入 了 事 实 上 的 小 型 内 战 中 。 在 叙 利 亚 、 利 比 亚 、 我 们 和 苏 联 的 支 持 下 ， 抗 议 者 取 得 了 胜 利 。 最 终 ， 经 过 多 方 妥 协 ， 前 副 总 统 、 纳 赛 尔 主 义 者 阿 里 · 萨 布 里 成 为 了 埃 及 新 总 统 ， 而 民 族 进 步 统 一 党 的 领 导 人 哈 立 德 · 毛 希 丁 在 苏 联 人 的 支 持 下 成 为 了 总 理 ， 新 政 权 由 纳 赛 尔 主 义 者 、 民 族 进 步 统 一 党 和 埃 及 共 产 党 组 成 的 阿 拉 伯 埃 及 人 民 民 主 团 结 阵 线 领 导 。 新 政 府 开 始 恢 复 泛 阿 拉 伯 主 义 的 宣 传 ， 并 重 启 在 阿 拉 伯 共 和 国 联 邦 中 的 活 动 ， 恢 复 同 苏 联 、 中 国 、 利 比 亚 、 叙 利 亚 、 伊 拉 克 和 其 他 社 会 主 义 国 家 的 友 好 关 系 。 与 此 同 时 ， 新 总 统 还 宣 布 取 消 “ 开 放 ” 政 策 和 经 济 自 由 化 ， 重 启 世 俗 化 、 打 压 伊 斯 兰 主 义 者 并 在 政 治 上 比 纳 赛 尔 时 期 更 加 左 倾 和 开 明 。 萨 布 里 已 经 恢 复 了 与 苏 联 关 于 恢 复 经 济 和 军 事 技 术 合 作 的 谈 判 ， 至 此 ， 埃 及 再 次 转 向 左 翼 — — 但 不 是 转 向 我 们 的 方 向 … …";
				GlobalScript.inst.gameState.data[1] += 20;
				GlobalScript.inst.gameState.empires[1].power += 20;
				GlobalScript.inst.gameState.influencePRC += 10;
				GlobalScript.inst.gameState.empires[1].relations += 50;
				GlobalScript.inst.gameState.data[9] -= 20;
				GlobalScript.inst.gameState.data[8] -= 20;
				GlobalScript.inst.gameState.empires[0].power -= 20;
				GlobalScript.inst.gameState.allcountries[30].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[30].prosov = true;
				GlobalScript.inst.gameState.allcountries[30].Vyshi = false;
			}
			else
			{
				text = " 我 们 最 终 决 定 通 过 利 比 亚 和 叙 利 亚 来 干 涉 埃 及 内 政 。 利 比 亚 和 叙 利 亚 在 我 们 的 帮 助 和 苏 联 克 格 勃 的 秘 密 批 准 下 ， 联 合 起 来 制 订 了 一 项 消 灭 埃 及 总 统 的 计 划 。10 月25 日 ， 安 瓦 尔 · 萨 达 特 在 开 罗 解 放 广 场 对 埃 及 抗 议 者 讲 话 时 被 一 名 利 比 亚 狙 击 手 击 毙 。 埃 及 新 总 统 是 他 的 助 手 胡 斯 尼 · 穆 巴 拉 克 ， 他 放 弃 了 深 化 改 革 ， 转 而 采 取 多 途 径 外 交 政 策 ， 尽 管 保 留 了 反 苏 的 基 调 。 埃 及 与 阿 拉 伯 邻 国 的 关 系 逐 渐 正 常 化 。";
				GlobalScript.inst.gameState.data[9] -= 20;
				GlobalScript.inst.gameState.data[8] -= 20;
				GlobalScript.inst.gameState.empires[0].power -= 10;
				GlobalScript.inst.gameState.allcountries[30].Vyshi = false;
			}
			break;
		case 2:
			text = " 我 们 决 定 组 织 埃 及 共 产 主 义 者 。 我 们 联 系 到 埃 及 的 合 法 左 翼 — — 由 共 产 主 义 者 和 自 由 军 官 组 织 的 老 革 命 哈 立 德 · 毛 希 丁 领 导 的 民 族 进 步 统 一 党 ， 由 他 们 牵 头 组 织 包 含 正 统 派 的 埃 及 共 产 党 和 受 毛 主 义 影 响 的 “ 革 命 运 动 ” 组 织 等 共 产 主 义 反 对 派 的 埃 及 人 民 民 主 革 命 阵 线 ， 阵 线 在 民 族 进 步 统 一 党 的 合 法 旗 帜 下 活 动 ， 积 极 在 抗 议 活 动 中 发 展 支 持 者 ， 并 向 工 会 和 军 队 渗 透 。||萨 达 特 将 军 队 调 动 军 队 镇 压 了 抗 议 。 为 了 帮 助 埃 及 平 息 骚 乱 ， 国 际 货 币 基 金 组 织 向 埃 及 提 供 了 1 . 5 亿 美 元 的 贷 款 ， 以 重 建 秩 序 。 削 减 食 品 补 贴 的 政 策 被 暂 停 ， 该 国 不 得 不 重 新 考 虑 其 国 内 和 外 交 政 策 。||在 暴 动 发 生 后 的 几 天 里 ， 萨 达 特 总 统 在 一 次 公 开 演 讲 中 声 称 ， 这 些 暴 力 是 由 共 产 党 组 织 和 煽 动 的 ， 得 到 了 苏 联 和 左 翼 的 支 持 。 在 演 讲 中 ， 骚 乱 的 部 分 责 任 也 被 归 咎 于 利 比 亚 。 对 骚 乱 的 镇 压 最 终 也 结 束 了 埃 及 的 政 治 解 冻 ， 对 持 不 同 政 见 者 的 政 策 被 再 次 收 紧 。||去 纳 赛 尔 主 义 化 仍 在 继 续 ， 埃 以 和 平 进 程 也 在 继 续 进 行 ， 萨 达 特 也 因 此 在 阿 拉 伯 世 界 被 视 为 叛 徒 。 在 不 久 的 未 来 ， 以 色 列 将 逐 步 归 还 西 奈 半 岛 。 1 9 7 7 年 3 月 ， 叙 利 亚 、 利 比 亚 联 合 谴 责 埃 及 试 图 与 以 色 列 达 成 和 解 ， 埃 利 、 埃 叙 断 绝 外 交 关 系 ， 阿 拉 伯 共 和 国 联 邦 无 法 继 续 维 持 ， 最 终 在 同 年 6 月 3 0 日 正 式 解 散 。 1 9 7 8 年 ， 阿 拉 伯 社 会 主 义 联 盟 被 正 式 拆 解 ， 其 中 间 翼 组 成 了 民 族 民 主 党 ， 成 为 了 埃 及 的 新 执 政 党 。||埃 及 的 问 题 并 没 有 在 实 际 上 解 决 ， 它 仍 在 不 久 的 将 来 等 着 萨 达 特 … …";
			GlobalScript.inst.gameState.data[9] -= 20;
			GlobalScript.inst.gameState.data[8] -= 20;
			break;
		case 3:
			text = " 我 们 决 定 组 织 埃 及 自 由 主 义 者 。 我 们 联 系 到 埃 及 的 合 法 右 翼 — — 自 由 军 官 组 织 的 老 革 命 穆 斯 塔 法 · 卡 梅 尔 · 穆 拉 德 领 导 的 自 由 社 会 主 义 党 ， 由 他 们 牵 头 组 织 包 含 前 华 夫 脱 党 成 员 （ 1 9 7 8 年 ， 他 们 重 组 为 新 华 夫 脱 党 ） 等 自 由 主 义 反 对 派 的 埃 及 民 族 自 由 联 盟 ， 阵 线 在 自 由 社 会 主 义 党 的 合 法 旗 帜 下 活 动 ， 积 极 在 抗 议 活 动 中 发 展 支 持 者 ， 并 向 中 产 阶 层 、 知 识 分 子 群 体 和 军 队 渗 透 。||萨 达 特 将 军 队 调 动 军 队 镇 压 了 抗 议 。 为 了 帮 助 埃 及 平 息 骚 乱 ， 国 际 货 币 基 金 组 织 向 埃 及 提 供 了 1 . 5 亿 美 元 的 贷 款 ， 以 重 建 秩 序 。 削 减 食 品 补 贴 的 政 策 被 暂 停 ， 该 国 不 得 不 重 新 考 虑 其 国 内 和 外 交 政 策 。||在 暴 动 发 生 后 的 几 天 里 ， 萨 达 特 总 统 在 一 次 公 开 演 讲 中 声 称 ， 这 些 暴 力 是 由 共 产 党 组 织 和 煽 动 的 ， 得 到 了 苏 联 和 左 翼 的 支 持 。 在 演 讲 中 ， 骚 乱 的 部 分 责 任 也 被 归 咎 于 利 比 亚 。 对 骚 乱 的 镇 压 最 终 也 结 束 了 埃 及 的 政 治 解 冻 ， 对 持 不 同 政 见 者 的 政 策 被 再 次 收 紧 。||去 纳 赛 尔 主 义 化 仍 在 继 续 ， 埃 以 和 平 进 程 也 在 继 续 进 行 ， 萨 达 特 也 因 此 在 阿 拉 伯 世 界 被 视 为 叛 徒 。 在 不 久 的 未 来 ， 以 色 列 将 逐 步 归 还 西 奈 半 岛 。 1 9 7 7 年 3 月 ， 叙 利 亚 、 利 比 亚 联 合 谴 责 埃 及 试 图 与 以 色 列 达 成 和 解 ， 埃 利 、 埃 叙 断 绝 外 交 关 系 ， 阿 拉 伯 共 和 国 联 邦 无 法 继 续 维 持 ， 最 终 在 同 年 6 月 3 0 日 正 式 解 散 。 1 9 7 8 年 ， 阿 拉 伯 社 会 主 义 联 盟 被 正 式 拆 解 ， 其 中 间 翼 组 成 了 民 族 民 主 党 ， 成 为 了 埃 及 的 新 执 政 党 。||埃 及 的 问 题 并 没 有 在 实 际 上 解 决 ， 它 仍 在 不 久 的 将 来 等 着 萨 达 特 … …";
			GlobalScript.inst.gameState.data[9] -= 20;
			GlobalScript.inst.gameState.data[8] -= 20;
			break;
		case 4:
			text = " 萨 达 特 将 军 队 调 动 军 队 镇 压 了 抗 议 。 为 了 帮 助 埃 及 平 息 骚 乱 ， 国 际 货 币 基 金 组 织 向 埃 及 提 供 了 1 . 5 亿 美 元 的 贷 款 ， 以 重 建 秩 序 。 削 减 食 品 补 贴 的 政 策 被 暂 停 ， 该 国 不 得 不 重 新 考 虑 其 国 内 和 外 交 政 策 。||在 暴 动 发 生 后 的 几 天 里 ， 萨 达 特 总 统 在 一 次 公 开 演 讲 中 声 称 ， 这 些 暴 力 是 由 共 产 党 组 织 和 煽 动 的 ， 得 到 了 苏 联 和 左 翼 的 支 持 。 在 演 讲 中 ， 骚 乱 的 部 分 责 任 也 被 归 咎 于 利 比 亚 。 对 骚 乱 的 镇 压 最 终 也 结 束 了 埃 及 的 政 治 解 冻 ， 对 持 不 同 政 见 者 的 政 策 被 再 次 收 紧 。||去 纳 赛 尔 主 义 化 仍 在 继 续 ， 埃 以 和 平 进 程 也 在 继 续 进 行 ， 萨 达 特 也 因 此 在 阿 拉 伯 世 界 被 视 为 叛 徒 。 在 不 久 的 未 来 ， 以 色 列 将 逐 步 归 还 西 奈 半 岛 。 1 9 7 7 年 3 月 ， 叙 利 亚 、 利 比 亚 联 合 谴 责 埃 及 试 图 与 以 色 列 达 成 和 解 ， 埃 利 、 埃 叙 断 绝 外 交 关 系 ， 阿 拉 伯 共 和 国 联 邦 无 法 继 续 维 持 ， 最 终 在 同 年 6 月 3 0 日 正 式 解 散 。 1 9 7 8 年 ， 阿 拉 伯 社 会 主 义 联 盟 被 正 式 拆 解 ， 其 中 间 翼 组 成 了 民 族 民 主 党 ， 成 为 了 埃 及 的 新 执 政 党 。||埃 及 的 问 题 并 没 有 在 实 际 上 解 决 ， 他 仍 在 不 久 的 将 来 等 着 萨 达 特 … …";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
