using EventsForDLC;
using UnityEngine;

public class Event65 : EventsSecond
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
		name = " 再 见 ， 我 们 亲 爱 的 米 沙 …";
		text = " 主 席 同 志 ！1980 年7 月19 日 ， 第 二 十 二 届 夏 季 奥 运 会 开 幕 式 将 在 莫 斯 科 举 行 。 苏 联 奋 力 争 取 到 了 奥 运 会 主 办 权 ， 在 准 备 中 花 费 了 巨 额 资 金 ， 这 些 资 金 不 得 不 从 其 他 支 出 项 目 中 提 取 （ 为 了 收 回 成 本 ， 苏 联 进 行 了 大 规 模 的 奥 运 标 志 销 售 运 动 ） 。 然 而 ， 美 国 领 导 层 已 经 公 开 宣 布 抵 制 这 届 运 动 会 ， 并 呼 吁 其 所 有 盟 友 也 参 加 抵 制 ， 在 费 城 组 织 所 谓 的 “ 奥 林 匹 克 抵 制 运 动 会 ” （ 更 广 为 人 知 的 是 “ 自 由 钟 经 典 运 动 会 ” ） 。 一 些 党 员 敦 促 我 们 以 美 国 为 榜 样 ， 派 一 支 队 伍 去 参 加 美 国 的 运 动 会 ， 抵 制 苏 联 的 奥 运 会 ， 但 这 会 引 起 苏 联 的 愤 怒 和 人 民 的 误 解 。 也 许 你 不 应 该 加 剧 分 裂 ， 把 我 们 的 运 动 员 送 到 莫 斯 科 ， 尽 管 我 们 国 家 之 间 存 在 政 治 矛 盾 ？ 体 育 无 关 政 治 ， 不 是 吗 …";
		if (GlobalScript.inst.gameState.is_party_enabled[0])
		{
			text += "|| 然 而 ， 一 些 党 员 回 顾 了1963 年 新 兴 力 量 运 动 会 的 经 验 （ 印 度 尼 西 亚 总 统 苏 加 诺 在 我 们 的 财 政 援 助 下 举 办 的 “ 第 三 世 界 ” 国 家 的 替 代 性 奥 运 会 ） ， 建 议 我 们 重 振 这 一 赛 事 ， 并 向 苏 联 和 美 国 表 明 ， 我 们 在 体 育 运 动 中 能 够 独 立 于 它 们 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		int num = 0;
		if ((GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))) || GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[0] = " 体 育 运 动 无 关 政 治 ！ 我 们 将 参 加 莫 斯 科 奥 运 会 并 派 出 最 好 的 运 动 员 ！ （ 需 要4 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			num++;
			button_text[0] = " 我 们 不 能 忽 视 西 方 的 意 见";
		}
		if ((GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))) || (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[56] != 0))
		{
			button_text[1] = " 我 们 不 宣 布 抵 制 ， 但 忽 略 这 两 场 运 动 会 …";
		}
		else
		{
			Object.Destroy(button[1]);
			num++;
			button_text[1] = " 我 们 不 能 同 时 忽 视 这 两 场 运 动 会 ！";
		}
		if (GlobalScript.inst.gameState.data[89] > 0 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[3] = " 我 们 宣 布 抵 制 苏 联 运 动 会 ， 并 将 参 赛 队 伍 队 派 往 美 国 （ 需 要3 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[3]);
			num++;
			button_text[3] = " 去 美 国 ？ ！ 你 是 认 真 的 吗 ？ …";
		}
		if (GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[4] = " 复 兴 新 兴 力 量 运 动 会 （GANEFO ） ， 向 发 展 中 国 家 发 出 邀 请 （ 需 要20 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[4]);
			num++;
			button_text[4] = " 毛 派 的 社 会 实 验 已 经 够 多 了 ！";
		}
		if ((((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[56] != 0) || num >= 4)
		{
			button_text[2] = " 我 们 宣 布 抵 制 ， 但 让 我 们 的 运 动 员 举 着 奥 运 会 旗 去 莫 斯 科 （ 需 要4 百 万 元 预 算 ） 。";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 这 不 是 我 们 的 政 策 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 再 见 ， 我 们 亲 爱 的 米 沙 …";
		switch (result_num)
		{
		case 0:
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 拒 绝 了 抵 制 莫 斯 科 奥 运 会 的 提 议 ， 称 其 为 “ 美 国 的 挑 衅 ” 。 他 亲 自 打 电 话 给 勃 列 日 涅 夫 ， 说 ： “ 中 国 决 不 会 加 入 美 国 的 抵 制 运 动 ， 将 会 把 代 表 团 派 往 莫 斯 科 ” ， 并 祝 苏 联 运 动 员 好 运 。 这 位 受 到 感 动 的 苏 联 领 导 人 对 此 表 示 ， 希 望 亲 自 与" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 在 开 幕 典 礼 上 会 面 并 祝 中 国 队 取 得 胜 利 。 最 后 ，63 个 国 家 宣 布 抵 制 莫 斯 科 奥 运 会 － 美 国 和 其 卫 星 国 ， 以 及";
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				text += " 伊 朗 ，";
			}
			text += " 莫 桑 比 克 和 卡 塔 尔 的 代 表 团 拒 绝 参 加 奥 运 会 ， 英 格 兰 、 法 国 、 意 大 利 和 西 班 牙 被 给 予 权 利 决 定 以 自 己 名 义 派 出 运 动 员 ， 或 者 以 奥 委 会 名 义 派 出 运 动 员 （ 最 终 ， 他 们 都 派 出 了 代 表 团 ） 。 在 开 幕 仪 式 上 国 际 奥 委 会 主 席 迈 克 尔 · 莫 里 斯 在 勃 列 日 涅 夫 发 言 前 ， 特 别 感 谢 了 那 些 不 顾 抵 制 ， 自 愿 来 参 加 的 运 动 员 。 中 国 队 得 了 第 三 名 ， 获 得 了35 金 、30 银 、38 铜 的 成 绩 ， 还 破 了 几 项 世 界 纪 录 。 冠 亚 军 是 苏 联 和 民 主 德 国 。 这 届 奥 运 会 将 以 历 史 上 组 织 最 出 色 的 奥 运 会 被 人 们 铭 记 ， 以 及 最 难 忘 的 闭 幕 式 — 奥 运 会 的 象 征 － 小 熊 米 沙 — 伴 着 阿 · 巴 赫 慕 托 娃 和 尼 · 多 布 朗 拉 沃 夫 的 歌 曲 《 告 别 莫 斯 科 》 飞 上 天 空 。 很 多 人 （ 甚 至 是 外 国 人 ） 都 忍 不 住 流 下 了 眼 泪 — 这 是 如 此 的 感 染 人 心 。 在 闭 幕 式 上 ， 升 起 了 洛 杉 矶 市 旗 ， 而 不 是 美 国 国 旗 （ 下 届 奥 运 会 举 办 国 ） ， 暗 示 着 苏 联 并 没 有 忘 记 抵 制 运 动 …";
			GlobalScript.inst.gameState.data[1] += 150;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.empires[1].power += 20;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.empires[1].relations += 250;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[8] -= 40;
			break;
		case 1:
			text = " 当 苏 联 和 美 国 在 国 际 奥 委 会 中 相 互 威 胁 、 相 互 抱 怨 时 ， 中 国 — — 出 乎 意 料 的 是 ， 对 每 个 人 来 说 — — 却 完 全 忽 视 了 这 两 届 奥 运 会 。 对 于 国 际 奥 委 会 因 莫 斯 科 缺 少 中 国 运 动 员 而 提 出 的 要 求 完 全 困 惑 ， 华 国 锋 和 中 华 人 民 共 和 国 奥 委 会 主 席 钟 世 通 提 到 了 中 国 财 政 困 难 的 状 况 ， 这 不 允 许 我 们 参 加 奥 运 会 。 我 们 在 那 里 的 解 释 似 乎 引 起 了 强 烈 的 怀 疑 ， 但 我 们 收 到 了 一 个 官 方 警 告 — — 抵 制 洛 杉 矶 奥 运 会 自 动 剥 夺 了 我 们 在 国 际 奥 委 会 的 成 员 资 格 。 人 民 也 不 明 白 为 什 么 国 家 领 导 层 对 奥 运 会 没 有 反 应 。 最 后 ，63 个 国 家 宣 布 抵 制 奥 运 会 － 美 国 及 其 卫 星 国 ， 以 及";
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				text += " 伊 朗 ，";
			}
			text += " 莫 桑 比 克 和 卡 塔 尔 拒 绝 参 加 奥 运 会 ， 英 格 兰 、 法 国 、 意 大 利 和 西 班 牙 被 给 予 权 利 决 定 以 自 己 名 义 派 出 运 动 员 ， 或 者 以 奥 委 会 名 义 派 出 运 动 员 （ 最 终 ， 他 们 都 派 出 了 代 表 团 ） 。 在 开 幕 仪 式 上 国 际 奥 委 会 主 席 迈 克 尔 · 莫 里 斯 在 勃 列 日 涅 夫 发 言 前 ， 特 别 感 谢 了 那 些 不 顾 抵 制 ， 自 愿 来 参 加 的 运 动 员 。 这 届 奥 运 会 将 以 历 史 上 组 织 最 出 色 的 奥 运 会 被 人 们 铭 记 ， 以 及 最 难 忘 的 闭 幕 式 — 奥 运 会 的 象 征 － 小 熊 米 沙 — 伴 着 阿 · 巴 赫 慕 托 娃 和 尼 · 多 布 朗 拉 沃 夫 的 歌 曲 《 告 别 莫 斯 科 》 飞 上 天 空 。 很 多 人 （ 甚 至 是 外 国 人 ） 都 忍 不 住 流 下 了 眼 泪 — 这 是 如 此 的 感 染 人 心 。 在 闭 幕 式 上 ， 升 起 了 洛 杉 矶 市 旗 ， 而 不 是 美 国 国 旗 （ 下 届 奥 运 会 举 办 国 ） ， 暗 示 着 苏 联 并 没 有 忘 记 抵 制 运 动 …";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.empires[1].power += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.influencePRC -= 20;
			break;
		case 2:
			text = " 中 国 加 入 了 美 国 对 莫 斯 科 奥 运 会 的 抵 制 ， 尽 管 并 非 毫 不 犹 豫 — — 中 国 奥 委 会 刚 刚 在 国 际 奥 委 会 注 册 ， 现 在 完 全 不 希 望 破 坏 与 它 的 关 系 。 因 此 ， 主 席 提 出 由 奥 委 会 主 席 钟 世 通 自 行 决 定 是 否 派 一 支 队 伍 去 莫 斯 科 。 在 与 国 际 奥 委 会 和 美 国 、 意 大 利 、 法 国 、 西 班 牙 和 英 联 邦 磋 商 后 ， 他 同 意 以 国 际 奥 委 会 的 名 义 将 中 国 代 表 团 派 往 莫 斯 科 。 最 后 ，63 个 国 家 宣 布 抵 制- 美 国 及 其 卫 星 国 ， 以 及";
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				text += " 伊 朗 ，";
			}
			text += " 莫 桑 比 克 和 卡 塔 尔 拒 绝 参 加 奥 运 会 ， 英 格 兰 、 法 国 、 意 大 利 和 西 班 牙 被 给 予 权 利 决 定 以 自 己 名 义 派 出 运 动 员 ， 或 者 以 奥 委 会 名 义 派 出 运 动 员 （ 最 终 ， 他 们 都 派 出 了 代 表 团 ） 。 在 开 幕 仪 式 上 国 际 奥 委 会 主 席 迈 克 尔 · 莫 里 斯 在 勃 列 日 涅 夫 发 言 前 ， 特 别 感 谢 了 那 些 不 顾 抵 制 ， 自 愿 来 参 加 的 运 动 员 。 这 届 奥 运 会 将 以 历 史 上 组 织 最 出 色 的 奥 运 会 被 人 们 铭 记 ， 以 及 最 难 忘 的 闭 幕 式 — 奥 运 会 的 象 征 － 小 熊 米 沙 — 伴 着 阿 · 巴 赫 慕 托 娃 和 尼 · 多 布 朗 拉 沃 夫 的 歌 曲 《 告 别 莫 斯 科 》 飞 上 天 空 。 很 多 人 （ 甚 至 是 外 国 人 ） 都 忍 不 住 流 下 了 眼 泪 — 这 是 如 此 的 感 染 人 心 。 在 闭 幕 式 上 ， 升 起 了 洛 杉 矶 市 旗 ， 而 不 是 美 国 国 旗 （ 下 届 奥 运 会 举 办 国 ） ， 暗 示 着 苏 联 并 没 有 忘 记 抵 制 运 动 …| 我 们 也 派 我 们 的 队 伍 参 加 了 费 城 的 另 一 场 比 赛 ， 在 那 里 我 们 获 得 了5 枚 金 牌 、1 枚 银 牌 和4 枚 铜 牌 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.empires[1].power += 10;
			GlobalScript.inst.gameState.empires[0].relations += 80;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.data[8] -= 40;
			GlobalScript.inst.gameState.data[4] += 60;
			break;
		case 3:
			text = " 中 国 加 入 了 美 国 对 莫 斯 科 奥 运 会 的 抵 制 ， 尽 管 并 非 毫 不 犹 豫 — — 中 国 奥 委 会 刚 刚 在 国 际 奥 委 会 注 册 ， 现 在 完 全 不 希 望 破 坏 与 它 的 关 系 。 然 而 ， 主 席 决 定 派 出 中 国 队 前 往 费 城 参 加 美 国 的 “ 替 代 ” 运 动 会 “ 自 由 钟 ” 。 中 华 人 民 共 和 国 奥 委 会 主 席 钟 世 通 反 对 这 一 决 定 ， 因 此 他 被 开 除 出 党 并 被 撤 职 ， 取 而 代 之 的 是 更 忠 诚 的 李 梦 华 。 我 们 的 队 伍 名 列 第 三 ， 输 给 了 美 国 和 德 国 ， 获 得 了5 枚 金 牌 、1 枚 银 牌 和4 枚 铜 牌 。 最 后 ，63 个 国 家 宣 布 抵 制- 美 国 及 其 卫 星 国 ， 以 及";
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				text += " 伊 朗 ，";
			}
			text += " 莫 桑 比 克 和 卡 塔 尔 拒 绝 参 加 奥 运 会 ， 英 格 兰 、 法 国 、 意 大 利 和 西 班 牙 被 给 予 权 利 决 定 以 自 己 名 义 派 出 运 动 员 ， 或 者 以 奥 委 会 名 义 派 出 运 动 员 （ 最 终 ， 他 们 都 派 出 了 代 表 团 ） 。 在 开 幕 仪 式 上 国 际 奥 委 会 主 席 迈 克 尔 · 莫 里 斯 在 勃 列 日 涅 夫 发 言 前 ， 特 别 感 谢 了 那 些 不 顾 抵 制 ， 自 愿 来 参 加 的 运 动 员 。 这 届 奥 运 会 将 以 历 史 上 组 织 最 出 色 的 奥 运 会 被 人 们 铭 记 ， 以 及 最 难 忘 的 闭 幕 式 — 奥 运 会 的 象 征 － 小 熊 米 沙 — 伴 着 阿 · 巴 赫 慕 托 娃 和 尼 · 多 布 朗 拉 沃 夫 的 歌 曲 《 告 别 莫 斯 科 》 飞 上 天 空 。 很 多 人 （ 甚 至 是 外 国 人 ） 都 忍 不 住 流 下 了 眼 泪 — 这 是 如 此 的 感 染 人 心 。 在 闭 幕 式 上 ， 升 起 了 洛 杉 矶 市 旗 ， 而 不 是 美 国 国 旗 （ 下 届 奥 运 会 举 办 国 ） ， 暗 示 着 苏 联 并 没 有 忘 记 抵 制 运 动 …";
			GlobalScript.inst.gameState.data[1] += 70;
			GlobalScript.inst.gameState.data[3] += 30;
			GlobalScript.inst.gameState.empires[0].relations += 200;
			GlobalScript.inst.gameState.empires[1].relations -= 200;
			GlobalScript.inst.gameState.data[4] += 60;
			GlobalScript.inst.gameState.data[8] -= 30;
			break;
		case 4:
			text = " 主 席 同 志 和 中 华 人 民 共 和 国 奥 委 会 主 席 钟 世 通 都 支 持 党 员 们 的 想 法 。 我 们 决 定 恢 复 “ 新 兴 力 量 运 动 会 ” 。 全 国 人 大 常 委 会 决 定 于11 月 在 宁 波 市 举 办 运 动 会 ， 并 向 “ 第 二 世 界 ” 、 “ 第 三 世 界 ” 各 国 发 出 邀 请 。";
			if (GlobalScript.inst.gameState.data[6] < 650 || GlobalScript.inst.gameState.influencePRC > 300)
			{
				text += " 令 我 们 大 为 吃 惊 的 是 ， 我 们 邀 请 的 所 有 国 家 都 同 意 参 加 新 的 运 动 会 — — 此 外 ， 苏 联 和 美 国 的 国 家 奥 委 会 与 中 华 人 民 共 和 国 奥 委 会 就 运 动 员 的 参 赛 事 宜 进 行 了 接 触 （ 当 然 不 是 第 一 梯 队 ， 但 是 尽 管 如 此 … … ） 。 比 赛 会 很 紧 张 ， 赶 紧 让 我 们 的 运 动 员 开 始 训 练 …";
			}
			else if ((GlobalScript.inst.gameState.data[6] >= 650 && GlobalScript.inst.gameState.data[6] < 850) || (GlobalScript.inst.gameState.influencePRC < 300 && GlobalScript.inst.gameState.influencePRC >= 150))
			{
				text += " 几 乎 所 有 不 结 盟 运 动 的 国 家 ， 包 括 南 斯 拉 夫 ， 都 同 意 参 加 。 这 将 是 一 场 紧 张 刺 激 的 比 赛 ！ …";
			}
			else if (GlobalScript.inst.gameState.data[6] >= 850 || GlobalScript.inst.gameState.influencePRC < 150)
			{
				text += " 不 幸 的 是 ， 只 有16 个 军 事 和 准 军 事 政 权 的 非 洲 国 家 同 意 参 与 。 当 然 ， 我 们 的 团 队 将 获 得 第 一 名 ， 但 这 将 是 完 全 无 趣 的 ！";
			}
			text += " 最 后 ，63 个 国 家 宣 布 抵 制- 美 国 及 其 卫 星 国 ， 以 及";
			if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
			{
				text += " 伊 朗 ，";
			}
			text += " 莫 桑 比 克 和 卡 塔 尔 拒 绝 参 加 奥 运 会 ， 英 格 兰 、 法 国 、 意 大 利 和 西 班 牙 被 给 予 权 利 决 定 以 自 己 名 义 派 出 运 动 员 ， 或 者 以 奥 委 会 名 义 派 出 运 动 员 （ 最 终 ， 他 们 都 派 出 了 代 表 团 ） 。 在 开 幕 仪 式 上 国 际 奥 委 会 主 席 迈 克 尔 · 莫 里 斯 在 勃 列 日 涅 夫 发 言 前 ， 特 别 感 谢 了 那 些 不 顾 抵 制 ， 自 愿 来 参 加 的 运 动 员 。 这 届 奥 运 会 将 以 历 史 上 组 织 最 出 色 的 奥 运 会 被 人 们 铭 记 ， 以 及 最 难 忘 的 闭 幕 式 — 奥 运 会 的 象 征 － 小 熊 米 沙 — 伴 着 阿 · 巴 赫 慕 托 娃 和 尼 · 多 布 朗 拉 沃 夫 的 歌 曲 《 告 别 莫 斯 科 》 飞 上 天 空 。 很 多 人 （ 甚 至 是 外 国 人 ） 都 忍 不 住 流 下 了 眼 泪 — 这 是 如 此 的 感 染 人 心 。 在 闭 幕 式 上 ， 升 起 了 洛 杉 矶 市 旗 ， 而 不 是 美 国 国 旗 （ 下 届 奥 运 会 举 办 国 ） ， 暗 示 着 苏 联 并 没 有 忘 记 抵 制 运 动 …";
			GlobalScript.inst.gameState.data[1] += 200;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[8] -= 200;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
