using EventsForDLC;
using UnityEngine;

public class Event448 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 涅 槃";
		text = " 随 着 伊 朗 伊 斯 兰 共 和 国 在 一 场 小 型 内 战 中 灰 飞 烟 灭 。 选 举 一 支 新 的 政 治 力 量 显 得 尤 为 重 要 。 伊 斯 兰 共 和 党 已 经 完 全 溃 败 ， 从 “ 伊 朗 文 化 大 革 命 ” 中 存 活 下 来 的 政 治 力 量 们 不 得 不 组 成 “ 大 帐 篷 ” 型 的 党 派 。 他 们 分 别 是 左 翼 的 伊 朗 人 民 联 盟 和 右 翼 的 伊 朗 自 由 运 动 ：\n 伊 朗 人 民 联 盟 是 一 个 代 表 左 翼 思 想 和 价 值 观 的 政 治 组 织 。 由 人 民 圣 战 者 中 的 温 和 派 与 伊 朗 人 民 党 左 翼 组 成 。 他 们 主 张 社 会 公 正 、 经 济 平 等 和 政 治 民 主 。 该 联 盟 强 调 人 民 的 权 力 和 参 与 ， 主 张 通 过 一 定 程 度 上 的 直 接 民 主 来 实 现 决 策 的 合 法 性 和 可 靠 性 。 伊 朗 人 民 联 盟 支 持 社 会 福 利 制 度 的 建 立 ， 旨 在 为 所 有 公 民 提 供 平 等 的 机 会 和 资 源 分 配 。 他 们 强 调 公 共 教 育 、 医 疗 保 健 和 社 会 保 障 的 重 要 性 ， 以 确 保 人 民 的 基 本 需 求 得 到 满 足 。 在 外 交 政 策 方 面 ， 伊 朗 人 民 联 盟 倡 导 通 过 对 话 和 外 交 途 径 解 决 国 际 争 端 ， 主 张 多 边 主 义 和 合 作 ， 以 实 现 全 球 和 平 与 稳 定 。\n 相 反 ， 伊 朗 自 由 运 动 代 表 着 右 翼 的 政 治 观 点 和 理 念 。 他 们 强 调 个 人 自 由 和 市 场 经 济 的 重 要 性 。 伊 朗 自 由 运 动 主 张 最 小 化 政 府 干 预 ， 提 倡 市 场 的 自 由 竞 争 和 私 有 财 产 权 的 保 护 。 他 们 主 张 降 低 税 收 和 减 少 政 府 管 制 ， 以 促 进 企 业 发 展 和 经 济 增 长 。 伊 朗 自 由 运 动 强 调 个 人 责 任 和 自 主 权 ， 认 为 个 人 应 该 有 权 做 出 自 己 的 决 策 ， 并 为 自 己 的 行 动 负 责 。 在 外 交 政 策 方 面 ， 他 们 支 持 坚 定 的 立 场 ， 主 张 保 护 伊 朗 的 国 家 利 益 ， 并 采 取 必 要 的 措 施 来 维 护 国 家 的 安 全 。\n 主 席 同 志 ， 我 们 是 不 是 应 该 支 持 其 中 的 某 一 派 ？ 我 们 花 了 大 功 夫 把 美 国 人 和 苏 联 人 挤 出 去 ， 可 不 是 为 了 让 他 们 坐 享 其 成 的 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.influencePRC >= 300 && a.data[45] <= 300)
		{
			button_text[0] = " 支 持 伊 朗 人 民 联 盟";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 左 翼 ， 一 盘 散 沙 ！";
		}
		if (GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.influencePRC >= 200)
		{
			button_text[1] = " 支 持 伊 朗 自 由 运 动";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 右 翼 和 霍 梅 尼 有 什 么 区 别 ？";
		}
		button_text[2] = " 我 们 想 要 ， 但 是 怎 么 也 做 不 到";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 涅 槃";
		switch (result_num)
		{
		case 0:
			text = " 我 们 决 定 支 持 伊 朗 人 民 联 盟 ， 在 我 们 雄 厚 资 金 的 支 持 下 ， 该 党 设 法 取 得 了 立 宪 会 议 和 伊 朗 人 民 议 会 的 绝 对 多 数 席 位 。 人 民 联 盟 上 台 便 开 始 着 手 实 现 其 竞 选 诺 言 ， 对 原 先 被 外 资 垄 断 的 石 油 工 业 被 迅 速 的 收 为 国 有 ， 土 地 改 革 在 我 们 特 勤 的 帮 助 下 ， 也 得 以 稳 定 的 进 行 。 借 着 石 油 和 我 们 的 一 笔 无 息 贷 款 ， 人 民 联 盟 开 始 组 建 更 为 完 善 的 福 利 体 系 ， 包 括 了 全 民 医 保 和 直 至 高 中 的 义 务 教 育 。 同 时 ， 他 们 也 没 有 忘 记 过 去 几 年 所 受 到 的 耻 辱 。 新 政 府 上 台 以 来 颁 布 的 第 一 项 法 令 ， 便 是 逮 捕 （ 如 果 没 有 在 小 型 内 战 中 罹 害 的 话 ） 原 伊 斯 兰 革 命 卫 队 成 员 和 伊 朗 伊 斯 兰 共 和 党 党 员 。 他 们 的 后 代 被 禁 止 参 与 到 政 府 的 决 策 中 ， 部 分 阿 訇 和 毛 拉 也 被 丢 进 了 监 狱 。 新 政 府 也 决 定 放 下 对 伊 拉 克 的 敌 视 ， 双 方 再 次 确 定 了 对 入 海 口 和 胡 齐 斯 坦 / 阿 拉 伯 斯 坦 自 治 权 对 保 障 ， 作 为 回 报 ， 伊 拉 克 将 帮 助 新 生 的 共 和 国 训 练 一 支 足 够 强 大 的 陆 军 。 新 政 府 也 没 有 忘 记 打 井 人 ， 伊 朗 宣 布 将 “ 和 中 华 人 民 共 和 国 开 展 更 广 泛 且 深 入 的 合 作 。 ” 一 张 又 一 张 的 贸 易 协 定 在 北 京 和 德 黑 兰 之 间 签 成 。 我 们 也 收 获 了 一 位 强 大 的 盟 友 。";
			a.data[9] -= 80;
			a.data[8] -= 20;
			a.data[6] += 50;
			a.influencePRC += 50;
			a.allcountries[8].Gosstroy = 2;
			a.allcountries[8].SubGosstroy = 3;
			a.allcountries[8].proprc = true;
			a.allcountries[8].Torg = true;
			GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
			break;
		case 1:
			text = " 我 们 决 定 支 持 伊 朗 自 由 运 动 ， 在 我 们 雄 厚 资 金 的 支 持 下 ， 该 党 设 法 取 得 了 立 宪 会 议 和 伊 朗 人 民 议 会 的 绝 对 多 数 席 位 。 自 由 运 动 上 台 便 开 始 着 手 实 现 其 竞 选 诺 言 ， 对 原 先 被 外 资 垄 断 的 石 油 工 业 再 次 被 外 资 所 把 握 ， 中 石 化 和 中 石 油 得 以 继 承 美 国 人 所 留 下 的 一 切 。 同 时 ， 他 们 也 没 有 忘 记 过 去 几 年 所 受 到 的 耻 辱 。 新 政 府 上 台 以 来 颁 布 的 第 一 项 法 令 ， 便 是 逮 捕 （ 如 果 没 有 在 小 型 内 战 中 罹 害 的 话 ） 原 伊 斯 兰 革 命 卫 队 成 员 和 伊 朗 伊 斯 兰 共 和 党 党 员 。 他 们 的 后 代 被 禁 止 参 与 到 政 府 的 决 策 中 ， 部 分 阿 訇 和 毛 拉 也 被 丢 进 了 监 狱 。 新 政 府 拒 绝 同 伊 拉 克 和 解 ， 伊 朗 的 F-4 “ 鬼 怪 ” 战 机 和 Q-5 “ 番 摊 ” 型 攻 击 机 频 频 飞 入 伊 拉 克 领 空 ， 伊 拉 克 也 开 始 试 射 自 己 的 小 型 导 弹 ， 并 谴 责 伊 朗 新 政 府 为 “ 帝 国 主 义 安 插 在 阿 拉 伯 湾 的 一 枚 楔 子 ” 。 新 政 府 也 没 有 忘 记 打 井 人 ， 伊 朗 宣 布 将 “ 和 中 华 人 民 共 和 国 开 展 更 广 泛 且 深 入 的 合 作 。 ” 一 张 又 一 张 的 贸 易 协 定 在 北 京 和 德 黑 兰 之 间 签 成 。 我 们 也 收 获 了 一 位 强 大 的 盟 友 。";
			a.data[9] -= 80;
			a.data[8] -= 20;
			a.data[6] -= 50;
			a.influencePRC += 30;
			a.allcountries[8].Gosstroy = 3;
			a.allcountries[8].SubGosstroy = 6;
			a.allcountries[8].proprc = true;
			a.allcountries[8].Torg = true;
			GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
			break;
		case 2:
			if (a.influencePRC + a.empires[1].power >= a.empires[0].power)
			{
				text = " 人 民 联 盟 得 以 以 微 弱 的 优 势 击 败 伊 朗 自 由 运 动 。 人 民 联 盟 上 台 便 开 始 着 手 实 现 其 竞 选 诺 言 ， 对 原 先 被 外 资 垄 断 的 石 油 工 业 被 迅 速 的 收 为 国 有 ， 土 地 改 革 几 乎 是 灾 难 性 的 ， 大 量 自 耕 农 以 杀 死 耕 畜 和 毁 坏 农 机 ， 烧 毁 粮 食 作 为 抵 制 。 借 着 石 油 ， 人 民 联 盟 开 始 组 建 更 为 完 善 的 福 利 体 系 ， 包 括 了 全 民 医 保 和 直 至 高 中 的 义 务 教 育 。 罢 工 和 罢 课 频 频 发 生 。 同 时 ， 他 们 也 没 有 忘 记 过 去 几 年 所 受 到 的 耻 辱 。 新 政 府 上 台 以 来 颁 布 的 第 一 项 法 令 ， 便 是 逮 捕 （ 如 果 没 有 在 小 型 内 战 中 罹 害 的 话 ） 原 伊 斯 兰 革 命 卫 队 成 员 和 伊 朗 伊 斯 兰 共 和 党 党 员 。 他 们 的 后 代 被 禁 止 参 与 到 政 府 的 决 策 中 ， 部 分 阿 訇 和 毛 拉 也 被 丢 进 了 监 狱 。 新 政 府 也 决 定 放 下 对 伊 拉 克 的 敌 视 ， 双 方 再 次 确 定 了 对 入 海 口 和 胡 齐 斯 坦 / 阿 拉 伯 斯 坦 自 治 权 对 保 障 ， 作 为 回 报 ， 伊 拉 克 将 帮 助 新 生 的 共 和 国 训 练 一 支 足 够 强 大 的 陆 军 。  他 们 再 差 ， 也 比 伊 斯 兰 好 ， 对 吧 ？";
				a.allcountries[8].Gosstroy = 2;
				a.allcountries[8].SubGosstroy = 3;
				a.allcountries[8].Torg = false;
				a.allcountries[8].prosov = true;
			}
			else if (a.influencePRC + a.empires[0].power > a.empires[1].power)
			{
				text = " 伊 朗 自 由 运 动 设 法 取 得 了 立 宪 会 议 和 伊 朗 人 民 议 会 的 相 对 多 数 ， 不 得 不 与 伊 朗 人 民 联 盟 事 实 上 共 同 管 理 伊 朗 。  自 由 运 动 上 台 便 开 始 着 手 实 现 其 竞 选 诺 言 ， 对 原 先 被 外 资 垄 断 的 石 油 工 业 再 次 被 外 资 所 把 握 ， 美 国 人 得 以 重 返 伊 朗 ， 和 我 们 的 石 油 企 业 展 开 了 激 烈 斗 争 。 同 时 ， 他 们 也 没 有 忘 记 过 去 几 年 所 受 到 的 耻 辱 。 新 政 府 上 台 以 来 颁 布 的 第 一 项 法 令 ， 便 是 逮 捕 （ 如 果 没 有 在 小 型 内 战 中 罹 害 的 话 ） 原 伊 斯 兰 革 命 卫 队 成 员 和 伊 朗 伊 斯 兰 共 和 党 党 员 。 他 们 的 后 代 被 禁 止 参 与 到 政 府 的 决 策 中 ， 部 分 阿 訇 和 毛 拉 也 被 丢 进 了 监 狱 。 新 政 府 拒 绝 同 伊 拉 克 和 解 ， 伊 朗 的 F-4 “ 鬼 怪 ” 战 机 和 Q-5 “ 番 摊 ” 型 攻 击 机 频 频 飞 入 伊 拉 克 领 空 ， 伊 拉 克 也 开 始 试 射 自 己 的 小 型 导 弹 ， 并 谴 责 伊 朗 新 政 府 为 “ 帝 国 主 义 安 插 在 阿 拉 伯 湾 的 一 枚 楔 子 ” 。 他 们 再 差 ， 也 比 伊 斯 兰 好 到 不 知 道 哪 里 去 了 ， 对 吧 ？";
				a.allcountries[8].Gosstroy = 3;
				a.allcountries[8].SubGosstroy = 6;
				a.allcountries[8].Torg = false;
				a.allcountries[8].Vyshi = true;
			}
			break;
		}
	}
}
