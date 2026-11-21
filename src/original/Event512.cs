using EventsForDLC;
using UnityEngine;

public class Event512 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 锡 德 拉 湾 事 件";
		text = " 1 9 6 9 年 8 月 3 1 日 ， 穆 阿 迈 尔· 卡 扎 菲 上 校 发 动 政 变 成 为 利 比 亚 的 国 家 领 导 人 ， 之 后 推 行 敌 视 美 国 等 西 方 国 家 的 政 策 ， 1 9 7 0 年 收 回 美 国 在 利 比 亚 的 惠 勒 斯 空 军 基 地 并 赶 走 当 中 的 美 军 ， 1 9 7 2 年 又 宣 布 废 除 前 政 府 和 美 国 所 有 的 合 作 项 目 并 把 两 国 关 系 由 大 使 级 降 格 为 代 办 级 。 1 9 7 3 年 ， 第 四 次 中 东 战 争 当 中 美 国 军 事 援 助 以 色 列 ， 此 事 进 一 步 激 怒 卡 扎 菲 ， 他 宣 布 利 比 亚 以 北 的 锡 德 拉 湾 是 利 比 亚 领 海 ， 外 国 船 只 和 飞 机 不 得 进 入 ， 但 此 事 并 未 得 到 以 美 国 为 首 的 西 方 国 家 认 可 ， 而 只 认 可 距 离 利 比 亚 北 部 沿 岸 12 海 里 的 范 围 内 才 是 利 比 亚 领 海 。||";
		text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
		text += " ";
		text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
		text += " 同 志 ， 据 我 们 外 务 人 事 的 最 新 情 报 ， 美 国 将 在 锡 德 拉 湾 开 展 一 次 突 袭 ， 彻 底 打 消 卡 扎 菲 的 念 头 ， 我 们 应 该 做 点 什 么 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] < 3)
		{
			button_text[0] = " 我 们 支 持 卡 扎 菲 的 主 张";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 为 什 么 ？ 为 什 么 ！";
		}
		if (a.data[56] > 2 && a.allcountries[51].Torg)
		{
			button_text[1] = " 我 们 支 持 美 国";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 别 和 帝 国 主 义 者 走 这 么 近 ！";
		}
		if ((a.allcountries[1].okb || a.allcountries[1].isSEATO) && a.influencePRC >= 600 && GlobalScript.inst.gameState.allcountries[13].cw)
		{
			button_text[2] = " 火 上 浇 油 ， 轰 炸 利 比 亚 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 能 这 么 做";
		}
		button_text[3] = " 什 么 都 不 要 做 ， 顺 其 自 然 。";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 锡 德 拉 湾 事 件";
		if (result_num == 0)
		{
			text = " 我 们 组 织 了 一 场 支 持 卡 扎 菲 的 游 行 ， 首 都 的 大 量 群 众 举 着 横 幅 ， 高 喊 着 “ 美 帝 的 黑 手 滚 出 阿 拉 伯 ！ ” “ 刽 子 手 的 罪 行 罄 竹 难 书 ！ ” 的 口 号 。 我 们 和 美 国 的 关 系 显 著 恶 化 了 ， 但 卡 扎 菲 上 校 感 谢 了 革 命 的 中 国 人 民 支 持 利 比 亚 的 斗 争 ， 并 宣 布 和 我 们 扩 大 合 作 关 系 。||1 9 8 1 年 8 月 1 8 日 ， 一 支 以 尼 米 兹 号 与 福 莱 斯 特 号 两 艘 航 空 母 舰 为 首 的 美 军 舰 队 进 入 锡 德 拉 湾 进 行 实 弹 演 习 。 8 月 1 9 日 清 晨 ， 一 架 E - 2 空 中 预 警 机 侦 测 出 正 有 两 架 战 斗 机 接 近 ， 故 通 知 两 架 隶 属 于 “ 黑 王 牌 ” 战 斗 机 编 队 的 F - 1 4 雄 猫 式 战 斗 机 上 前 拦 截 ， 并 发 现 是 利 比 亚 空 军 的 苏 - 2 2 战 斗 机 。||美 国 飞 行 员 示 意 叫 利 比 亚 战 机 离 开 ， 可 是 利 比 亚 飞 行 员 不 但 不 理 会 ， 还 向 美 军 战 机 发 射 一 枚 K - 1 3 导 弹 。 驾 驶 座 机 代 号 快 鹰 1 0 2 （ F a s t E a g l e 1 0 2 ） 的 F - 1 4 飞 行 员 克 利 曼 中 校 避 开 来 袭 的 导 弹 后 ， 发 现 自 己 正 好 对 着 另 一 架 S u - 2 2 战 机 ， 于 是 趁 S u - 2 2 战 机 的 飞 行 员 尝 试 脱 离 冲 突 空 域 之 际 ， 发 射 一 枚 响 尾 蛇 导 弹 将 其 击 落 。 至 于 原 本 朝 克 利 曼 开 火 的 那 架 苏 - 2 2 ， 也 在 同 时 被 驾 驶 快 鹰 1 0 7 的 穆 钦 斯 基 上 校 以 响 尾 蛇 导 弹 击 落 。 空 战 前 后 为 时 不 过 维 持 约 一 分 钟 时 间 。||随 后 ， 利 比 亚 公 开 谴 责 了 美 国 对 其 开 展 的 军 事 行 动 ， 并 公 开 强 调 “ 锡 德 拉 湾 以 北 2 0 0 海 里 是 利 比 亚 的 合 法 领 土 ” ， “ 北 纬 3 2 度 3 0 分 是 不 可 逾 越 的 死 亡 线 ” 。 他 还 宣 称 会 对 “ 地 中 海 内 所 有 的 美 军 基 地 展 开 报 复 ” 。 随 后 他 便 前 往 亚 的 斯 亚 贝 巴 " + ((a.allcountries[41].SubGosstroy == 10) ? "， 和 他 的 好 同 志 门 格 斯 图 " : null) + "强 烈 谴 责 了 美 帝 干 涉 。";
			GlobalScript.inst.gameState.allcountries[13].Torg = true;
			GlobalScript.inst.gameState.allcountries[13].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[13].SubGosstroy = 10;
			a.influencePRC += 10;
			a.empires[0].relations -= 100;
			a.OilProd += 150f;
		}
		if (result_num == 1)
		{
			a.data[8] -= 30;
			text = " 我 们 支 持 了 美 国 的 行 动 ， 公 开 表 达 了 对 利 比 亚 政 府 的 不 满 。 卡 扎 菲 也 很 乐 于 谴 责 我 们 背 叛 第 三 世 界 的 理 论 ， 他 甚 至 在 最 近 公 开 接 见 了 达 赖 喇 嘛 十 四 世 。 但 我 们 和 美 国 的 关 系 显 著 改 善 了 。||1 9 8 1 年 8 月 1 8 日 ， 一 支 以 尼 米 兹 号 与 福 莱 斯 特 号 两 艘 航 空 母 舰 为 首 的 美 军 舰 队 进 入 锡 德 拉 湾 进 行 实 弹 演 习 。 8 月 1 9 日 清 晨 ， 一 架 E - 2 空 中 预 警 机 侦 测 出 正 有 两 架 战 斗 机 接 近 ， 故 通 知 两 架 隶 属 于 “ 黑 王 牌 ” 战 斗 机 编 队 的 F - 1 4 雄 猫 式 战 斗 机 上 前 拦 截 ， 并 发 现 是 利 比 亚 空 军 的 苏 - 2 2 战 斗 机 。||美 国 飞 行 员 示 意 叫 利 比 亚 战 机 离 开 ， 可 是 利 比 亚 飞 行 员 不 但 不 理 会 ， 还 向 美 军 战 机 发 射 一 枚 K - 1 3 导 弹 。 驾 驶 座 机 代 号 快 鹰 1 0 2 （ F a s t E a g l e 1 0 2 ） 的 F - 1 4 飞 行 员 克 利 曼 中 校 避 开 来 袭 的 导 弹 后 ， 发 现 自 己 正 好 对 着 另 一 架 S u - 2 2 战 机 ， 于 是 趁 S u - 2 2 战 机 的 飞 行 员 尝 试 脱 离 冲 突 空 域 之 际 ， 发 射 一 枚 响 尾 蛇 导 弹 将 其 击 落 。 至 于 原 本 朝 克 利 曼 开 火 的 那 架 苏 - 2 2 ， 也 在 同 时 被 驾 驶 快 鹰 1 0 7 的 穆 钦 斯 基 上 校 以 响 尾 蛇 导 弹 击 落 。 空 战 前 后 为 时 不 过 维 持 约 一 分 钟 时 间 。||随 后 ， 利 比 亚 公 开 谴 责 了 美 国 对 其 开 展 的 军 事 行 动 ， 并 公 开 强 调 “ 锡 德 拉 湾 以 北 2 0 0 海 里 是 利 比 亚 的 合 法 领 土 ” ， “ 北 纬 3 2 度 3 0 分 是 不 可 逾 越 的 死 亡 线 ” 。 他 还 宣 称 会 对 “ 地 中 海 内 所 有 的 美 军 基 地 展 开 报 复 ” 。 随 后 他 便 前 往 亚 的 斯 亚 贝 巴 " + ((a.allcountries[41].SubGosstroy == 10) ? "， 和 他 的 好 同 志 门 格 斯 图 " : null) + "强 烈 谴 责 了 美 帝 干 涉 。";
			GlobalScript.inst.gameState.allcountries[13].Torg = false;
			GlobalScript.inst.gameState.allcountries[13].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[13].SubGosstroy = 10;
			a.empires[0].relations += 150;
		}
		if (result_num == 2)
		{
			if (GlobalScript.inst.gameState.ingamewars[20].is_going)
			{
				GlobalScript.inst.gameState.ingamewars[20].infl2 = 1000;
				GlobalScript.inst.gameState.ingamewars[20].infl1 = 0;
			}
			GlobalScript.inst.gameState.allcountries[13].puppetOf = -1;
			for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
			{
				if (a.allcountries[i].puppetOf == 13)
				{
					a.allcountries[i].puppetOf = -1;
				}
			}
			text = " 我 们 决 定 一 劳 永 逸 的 解 决 问 题 ： 彻 底 让 这 个 独 裁 暴 君 滚 蛋 。||";
			if (GlobalScript.inst.gameState.allcountries[57].puppetOf == 13)
			{
				GlobalScript.inst.gameState.allcountries[57].puppetOf = -1;
			}
			if (a.data[56] < 3 && a.allcountries[1].okb)
			{
				text += " 清 晨 ， 乌 压 压 的 机 群 飞 向 利 比 亚 。 他 们 的 目 标 有 六 个 ： 的 黎 波 里 的 阿 奇 奇 耶 兵 营 ， 西 迪 比 拉 勒 港 口 的 突 击 队 训 练 中 心 和 机 场 ； 班 加 西 的 贝 尼 纳 机 场 和 民 众 国 兵 营 ， 以 及 苏 尔 特 中 心 区 。 空 袭 在 深 夜 进 行 ， 借 道 卡 拉 奇 起 飞 的 3 0 余 架 轰 - 6 在 短 短 的 一 小 时 内 就 将 上 述 目 标 彻 底 摧 毁 。 利 比 亚 空 军 已 完 全 瘫 痪 ， 卡 扎 菲 本 人 和 三 个 孩 子 也 在 空 袭 中 丧 生 。 随 后 ， 巴 希 尔 · 哈 瓦 迪 上 将 所 带 领 的 军 队 乘 乱 接 管 了 利 比 亚 的 各 大 城 市 ， 我 们 也 认 可 了 他 的 举 动 ， 并 迅 速 承 认 了 临 时 政 府 。 而 原 先 的 左 翼 反 对 派 ： 马 克 思 主 义 的 利 比 亚 民 族 民 主 阵 线 和 复 兴 主 义 的 利 比 亚 民 族 运 动 （ 由 利 比 亚 复 兴 党 的 前 成 员 在 其 被 卡 扎 菲 解 散 后 重 组 而 成 ） ， 也 得 以 正 式 在 这 样 的 一 场 爬 竿 政 变 中 确 认 自 己 的 领 导 地 位 ， 二 者 对 科 学 社 会 主 义 和 阿 拉 伯 民 族 主 义 仍 然 抱 有 浓 厚 的 兴 趣 。 从 海 外 的 流 亡 结 束 后 ， 他 们 再 度 踏 上 了 利 比 亚 的 土 地 ， 不 是 反 叛 者 ， 而 是 新 的 革 命 领 军 人 。 首 先 二 者 在 的 黎 波 里 签 署 了 合 并 协 定 ， 双 方 将 合 并 为 统 一 的 利 比 亚 劳 动 党 ， 这 是 一 个 在 阿 拉 伯 社 会 主 义 的 基 础 上 吸 纳 了 前 马 克 思 主 义 者 ， 意 大 利 工 人 主 义 和 复 兴 主 义 元 素 的 左 翼 组 织 。 乌 姆 兰 · 卜 尔 维 斯 则 被 选 举 为 新 政 府 的 首 脑 ， 阿 杜 拉 希 姆 · 萨 利 赫 博 士 出 任 劳 动 党 第 一 书 记 。 新 政 府 在 继 续 石 油 国 有 化 的 同 时 也 在 加 大 和 社 会 主 义 国 家 间 的 合 作 ， 并 邀 请 我 们 派 遣 农 业 专 家 和 政 治 委 员 帮 助 建 设 新 的 社 会 主 义 利 比 亚 。 ";
				GlobalScript.inst.gameState.allcountries[13].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[13].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[13].SubGosstroy = 1;
				GlobalScript.inst.gameState.allcountries[13].Torg = true;
				GlobalScript.inst.gameState.allcountries[13].proprc = true;
				if (a.allcountries[13].parts[0])
				{
					a.allcountries[13].parts[0] = false;
				}
				a.influencePRC += 30;
			}
			if (a.data[56] >= 3 && a.allcountries[1].okb)
			{
				text += " 清 晨 ， 乌 压 压 的 集 群 飞 向 利 比 亚 。 他 们 的 目 标 有 六 个 ： 的 黎 波 里 的 阿 奇 奇 耶 兵 营 ， 西 迪 比 拉 勒 港 口 的 突 击 队 训 练 中 心 和 机 场 ； 班 加 西 的 贝 尼 纳 机 场 和 民 众 国 兵 营 ， 以 及 苏 尔 特 中 心 区 。 空 袭 在 深 夜 进 行 ， 借 道 卡 拉 奇 起 飞 的 3 0 余 架 轰 - 6 在 短 短 的 一 小 时 内 就 将 上 述 目 标 彻 底 摧 毁 。 利 比 亚 空 军 已 完 全 瘫 痪 ， 卡 扎 菲 本 人 也 在 空 袭 中 丧 生 。 随 后 ， 一 场 起 义 爆 发 了 。 穆 斯 塔 法 · 贾 利 勒 组 织 了 一 场 宫 廷 政 变 并 组 建 了 全 国 解 放 委 员 会 。 我 们 迅 速 承 认 了 临 时 政 府 。 很 快 ， 全 国 解 放 委 员 会 正 式 改 组 为 利 比 亚 民 主 党 ， 国 王 得 以 重 新 回 到 他 那 最 忠 诚 的 的 黎 波 里 ， 西 方 世 界 也 乐 于 承 认 这 样 一 个 政 权 。 毕 竟 新 政 府 第 一 件 事 便 是 快 速 的 去 国 有 化 ， 很 快 ， 西 方 石 油 公 司 和 我 们 的 石 油 企 业 也 来 到 了 这 里 ， 做 着 和 革 命 前 一 样 的 事 情 … …";
				GlobalScript.inst.gameState.allcountries[13].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[13].Gosstroy = 3;
				GlobalScript.inst.gameState.allcountries[13].SubGosstroy = 5;
				GlobalScript.inst.gameState.allcountries[13].proprc = true;
				if (a.allcountries[13].parts[0])
				{
					a.allcountries[13].parts[0] = false;
				}
			}
			if (a.allcountries[1].isSEATO)
			{
				text += " 清 晨 ， 乌 压 压 的 集 群 飞 向 利 比 亚 。 他 们 的 目 标 有 六 个 ： 的 黎 波 里 的 阿 奇 奇 耶 兵 营 ， 西 迪 比 拉 勒 港 口 的 突 击 队 训 练 中 心 和 机 场 ； 班 加 西 的 贝 尼 纳 机 场 和 民 众 国 兵 营 ， 以 及 苏 尔 特 中 心 区 。 空 袭 在 深 夜 进 行 ， 珊 瑚 海 号 航 空 母 舰 起 飞 了 6 架 A - 6 ， 从 英 国 空 军 基 地 远 道 而 来 的 1 6 架 共 计 3 0 架 次 的 B - 5 2 轰 炸 机 在 短 短 的 一 小 时 内 就 将 上 述 目 标 彻 底 摧 毁 。 利 比 亚 空 军 已 完 全 瘫 痪 ， 卡 扎 菲 本 人 也 在 空 袭 中 丧 生 。 随 后 ， 巴 希 尔 · 哈 瓦 迪 上 将 所 带 领 的 军 队 乘 乱 接 管 了 利 比 亚 的 各 大 城 市 ， 西 方 各 国 和 我 们 认 可 了 他 的 举 动 ， 并 迅 速 承 认 了 临 时 政 府 。 很 快 ， 一 个 意 料 之 外 但 情 理 之 中 的 选 项 ： 伊 德 里 斯 一 世 登 上 了 台 面 。 国 王 宣 布 重 新 回 到 他 那 最 忠 诚 的 的 黎 波 里 ， 西 方 世 界 也 乐 于 承 认 这 样 一 个 君 主 ， 毕 竟 他 又 老 又 任 人 摆 布 ， 很 快 ， 西 方 石 油 公 司 和 我 们 的 石 油 企 业 也 来 到 了 这 里 ， 做 着 和 革 命 前 一 样 的 事 情 … …";
				GlobalScript.inst.gameState.allcountries[13].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[13].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[13].SubGosstroy = 7;
				GlobalScript.inst.gameState.allcountries[13].Vyshi = true;
				if (a.allcountries[13].parts[0])
				{
					a.allcountries[13].parts[0] = false;
				}
			}
		}
		if (result_num == 3)
		{
			text = " 1 9 8 1 年 8 月 1 8 日 ， 一 支 以 尼 米 兹 号 与 福 莱 斯 特 号 两 艘 航 空 母 舰 为 首 的 美 军 舰 队 进 入 锡 德 拉 湾 进 行 实 弹 演 习 。 8 月 1 9 日 清 晨 ， 一 架 E - 2 空 中 预 警 机 侦 测 出 正 有 两 架 战 斗 机 接 近 ， 故 通 知 两 架 隶 属 于 “ 黑 王 牌 ” 战 斗 机 编 队 的 F - 1 4 雄 猫 式 战 斗 机 上 前 拦 截 ， 并 发 现 是 利 比 亚 空 军 的 苏 - 2 2 战 斗 机 。||美 国 飞 行 员 示 意 叫 利 比 亚 战 机 离 开 ， 可 是 利 比 亚 飞 行 员 不 单 不 理 会 ， 还 向 美 军 战 机 发 射 一 枚 K - 1 3 导 弹 。 驾 驶 座 机 代 号 快 鹰 1 0 2 （ F a s t   E a g l e   1 0 2 ） 的 F - 1 4 飞 行 员 克 利 曼 中 校 避 开 来 袭 的 导 弹 后 ， 发 现 自 己 正 好 对 着 另 一 架 S u - 2 2 战 机 ， 于 是 趁 S u - 2 2 战 机 的 飞 行 员 尝 试 脱 离 冲 突 空 域 之 际 ， 发 射 一 枚 响 尾 蛇 导 弹 将 其 击 落 。 至 于 原 本 朝 克 利 曼 开 火 的 那 架 苏 - 2 2 ， 也 在 同 时 被 驾 驶 快 鹰 1 0 7 的 穆 钦 斯 基 上 校 以 响 尾 蛇 导 弹 击 落 。 空 战 前 后 为 时 不 过 维 持 约 一 分 钟 时 间 。||随 后 ， 利 比 亚 公 开 谴 责 了 美 国 对 其 开 展 的 军 事 行 动 ， 并 公 开 强 调 “ 锡 德 拉 湾 以 北 2 0 0 海 里 是 利 比 亚 的 合 法 领 土 ” ， “ 北 纬 3 2 度 3 0 分 是 不 可 逾 越 的 死 亡 线 ” 。 他 还 宣 称 会 对 “ 地 中 海 内 所 有 的 美 军 基 地 展 开 报 复 ” 。 随 后 他 便 前 往 亚 的 斯 亚 贝 巴 " + ((a.allcountries[41].SubGosstroy == 10) ? "， 和 他 的 好 同 志 门 格 斯 图 " : null) + "强 烈 谴 责 了 美 帝 干 涉 。";
			GlobalScript.inst.gameState.allcountries[13].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[13].SubGosstroy = 10;
		}
	}
}
