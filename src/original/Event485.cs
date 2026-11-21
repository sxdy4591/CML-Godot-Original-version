using EventsForDLC;
using UnityEngine;

public class Event485 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 日 耳 曼 之 春";
		text = " 随 着 欧 共 体 的 解 散 ， 德 意 志 联 邦 共 和 国 在 欧 洲 的 情 况 愈 发 不 稳 。 长 期 的 游 击 队 活 动 ， 分 裂 的 苦 楚 和 对 美 帝 的 仇 恨 在 这 一 刻 达 到 了 极 点 。 而 军 事 管 制 更 是 狠 狠 的 将 联 邦 德 国 引 以 为 傲 的 民 主 制 踩 在 脚 下 。 随 着 我 们 的 禁 运 ， 联 邦 德 国 不 得 不 采 取 了 配 给 制 和 宵 禁 。 人 们 不 敢 言 而 敢 怒 ， 只 要 我 们 轻 轻 煽 动 ， 西 德 就 会 陷 入 崩 溃 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.resultOfEvents[486] == 0 && a.modifies[6].active && a.data[14] < 3)
		{
			button_text[0] = " 年 轻 的 布 尔 塞 维 克 向 前 进 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 共 产 主 义 者 不 愿 意 听 从 我 们 的 意 见";
		}
		if (a.resultOfEvents[487] == 1 && (GlobalScript.inst.gameState.data[31] >= 700 || (GlobalScript.inst.gameState.data[14] <= 0 && GlobalScript.inst.gameState.data[50] > 27 && GlobalScript.inst.gameState.data[16] > 11)))
		{
			button_text[1] = " 这 是 意 志 的 胜 利 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 支 持 一 个 法 西 斯 ！";
		}
		button_text[2] = " 还 没 这 个 必 要 ， 再 等 等 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 日 耳 曼 之 春";
		if (result_num == 0)
		{
			text = " 多 亏 了 我 们 的 层 层 布 局 ， 以 及 对 社 会 主 义 诸 国 ， 尤 其 是 我 国 的 向 往 。 西 德 的 激 进 学 生 选 择 拥 抱 特 里 尔 的 传 统 。 在 波 恩 ， 工 人 对 于 新 的 劳 动 定 额 和 强 制 加 班 的 政 策 感 到 十 分 不 满 。 先 是 三 百 多 名 工 厂 工 人 举 着 横 幅 ， 向 着 政 府 大 楼 进 发 ， 一 路 上 不 断 有 工 人 加 入 他 们 ， 其 中 甚 至 包 括 一 些 警 察 。 等 到 了 目 的 地 时 ， 他 们 已 经 拉 起 了 一 支 上 万 人 的 队 伍 。 在 这 时 ， 他 们 的 要 求 已 经 不 是 简 单 的 要 求 增 加 福 利 和 减 少 工 时 ， 转 而 改 成 了 大 量 的 政 治 性 标 语 如 ： “ 工 人 们 团 结 起 来 ！ ” “ 我 们 要 面 包 与 和 平 ” 之 类 的 。 工 人 们 大 喊 着 要 求 军 事 委 员 会 主 席 发 话 ， 而 只 有 一 些 基 层 干 愿 意 作 答 。 政 府 调 集 了 大 量 的 军 人 ， 意 图 让 人 群 克 制 下 来 。 在 紧 张 对 峙 中 ， 一 个 慌 张 的 新 兵 扣 下 了 板 机 ， 这 也 让 一 切 彻 底 失 控 。\n 德 国 马 列 主 义 革 命 党 一 直 在 工 人 中 发 展 自 己 的 支 持 者 ， 在 流 血 冲 突 发 生 的 时 候 ， 他 们 积 极 鼓 动 其 他 地 区 的 工 人 相 应 波 恩 的 事 态 。 德 意 志 人 民 武 装 力 量 积 极 组 建 了 工 人 赤 卫 队 ， 打 入 军 队 的 各 级 干 部 也 纷 纷 打 开 弹 药 库 。 在 波 恩 的 街 头 ， 迪 克 胡 特 同 志 发 表 了 一 番 讲 话 ， 积 极 的 鼓 动 工 人 和 下 层 军 人 把 枪 口 对 准 真 正 应 该 打 倒 的 敌 人 — — 也 就 是 他 们 的 领 导 人 。 一 场 小 型 内 战 在 西 德 爆 发 了 。 不 过 在 我 们 的 特 勤 和 直 接 干 涉 下 ， 战 争 很 快 就 结 束 了 。 民 主 德 国 也 乘 机 占 领 了 西 柏 林 。\n 新 政 府 宣 布 将 和 中 华 人 民 共 和 国 发 展 更 为 巩 固 和 友 好 的 关 系 ， 我 们 的 大 使 在 波 恩 会 见 了 迪 克 胡 特 主 席 。 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 也 接 见 了 德 意 志 人 民 共 和 国 的 特 使 。";
			if (!a.allcountries[0].isNATO && !a.allcountries[0].isEU)
			{
				text += " 美 国 惊 恐 的 看 着 自 己 在 西 欧 的 最 后 一 颗 棋 子 被 拔 除 ， 骄 傲 的 白 头 鹰 再 也 不 能 翱 翔 了 。";
			}
			a.data[8] -= 200;
			a.data[22] -= 200;
			a.data[9] -= 200;
			a.allcountries[17].Gosstroy = 1;
			a.allcountries[17].SubGosstroy = 17;
			a.allcountries[17].LeaveAlliances();
			a.allcountries[17].Torg = true;
			a.allcountries[17].proprc = true;
			a.allcountries[17].JoinAllOurAlliances(yes: true);
			a.allcountries[17].cw = false;
			a.allcountries[17].name = " 德 意 志 人 民 共 和 国";
			a.empires[0].power -= 50;
			a.empires[0].relations -= 100;
			a.influencePRC += 80;
		}
		if (result_num == 1)
		{
			text = " 在 陷 入 大 规 模 社 会 不 稳 定 的 时 候 ， 新 德 国 把 目 光 投 向 了 德 意 志 的 古 老 传 统 。 他 们 把 目 光 投 向 了 新 纳 粹 党 ， 日 耳 曼 民 族 联 盟 和 光 头 党 之 类 的 右 翼 民 族 主 义 组 织 ， 希 望 能 借 助 他 们 的 力 量 从 而 镇 压 左 派 。 但 很 明 显 他 们 忘 记 了 魏 玛 共 和 国 的 命 运 。 在 新 纳 粹 党 得 到 了 军 事 委 员 会 的 大 力 支 持 后 ， 他 们 组 建 了 自 己 的 武 装 力 量 “ 风 暴 冲 锋 队 ” 。 这 支 武 装 力 量 除 了 大 规 模 打 击 左 派 以 外 ， 犹 太 人 ， 波 兰 劳 工 和 有 色 人 种 都 没 能 幸 免 。\n 在 波 恩 爆 发 大 规 模 暴 动 后 ， 临 时 军 事 委 员 会 立 刻 决 定 召 集 “ 风 暴 冲 锋 队 ” 进 京 救 驾 。 在 这 时 ， 雷 默 察 觉 到 了 临 时 军 事 委 员 会 的 软 弱 无 能 ， 他 决 定 借 助 “ 风 暴 冲 锋 队 ” 向 现 任 政 府 施 压 ， 从 而 复 刻 他 的 偶 像 墨 索 里 尼 的 经 验 。 在 雷 默 的 鼓 动 下 ， 大 量 民 族 主 义 团 体 以 “ 维 持 秩 序 ” 的 名 义 趁 机 接 管 了 机 场 ， 广 播 中 心 和 明 斯 特 广 场 。 在 镇 压 抗 议 者 的 同 时 ， 雷 默 不 断 向 临 时 军 事 委 员 会 施 压 ， 称 如 果 不 给 予 他 德 国 总 理 的 席 位 ， 就 调 转 矛 头 攻 向 政 府 。 处 于 对 雷 默 的 忌 惮 ， 政 府 不 得 不 顺 从 他 的 意 见 。 在 西 德 陷 入 困 境 的 时 候 ， 东 德 人 民 军 假 扮 成 救 火 员 占 领 了 西 柏 林 。\n 在 雷 默 宣 布 恢 复 秩 序 以 后 ， 人 民 期 待 着 回 到 正 常 的 日 子 。 可 是 事 与 愿 违 ， 或 者 说 这 怎 么 可 能 呢 ？ 雷 默 立 刻 组 建 了 德 意 志 国 家 工 人 党 。 新 政 府 立 刻 废 除 了 孱 弱 不 堪 的 议 会 ， 转 而 取 代 的 是 民 族 阵 线 ， 一 个 极 右 翼 党 派 的 统 战 组 织 。 而 且 恢 复 了 过 去 的 古 老 称 呼 — — 元 首 。 在 汉 堡 ， 一 场 由 左 翼 分 子 发 动 的 反 法 西 斯 起 义 爆 发 了 ， 新 政 府 以 残 忍 而 血 腥 的 手 段 立 刻 镇 压 了 这 次 起 义 。 “ 波 恩 是 一 个 几 百 万 人 口 的 大 城 市 ， 前 政 府 的 首 都 ， 应 杀 的 共 产 主 义 者 人 不 止 几 千 人 ” “ 汉 堡 杀 人 太 少 ， 应 在 汉 堡 多 杀 。 ” 雷 默 元 首 在 《 对 汉 堡 镇 压 共 产 主 义 者 工 作 的 指 示 》 ， 德 国 国 家 工 人 党 的 第 一 号 法 令 中 如 是 说 道 。\n 新 政 府 开 始 组 建 全 民 性 质 的 军 事 训 练 ， 大 量 企 业 被 转 为 生 产 军 事 武 器 ， 用 来 换 取 不 被 国 家 直 接 指 导 和 接 管 的 回 报 。 这 一 切 的 目 标 直 指 谁 ， 似 乎 人 尽 皆 知 了 … … ";
			a.data[8] -= 200;
			a.data[22] -= 200;
			a.data[9] -= 200;
			a.allcountries[17].Gosstroy = 0;
			a.allcountries[17].SubGosstroy = 9;
			a.allcountries[17].LeaveAlliances();
			a.allcountries[17].cw = false;
			if (a.allcountries[1].Gosstroy == 0 && a.data[16] >= 13)
			{
				a.allcountries[17].Torg = true;
				a.allcountries[17].proprc = true;
				a.allcountries[17].JoinAllOurAlliances(yes: true);
			}
			a.empires[0].power -= 50;
			a.empires[0].relations -= 100;
			a.influencePRC += 80;
		}
		if (result_num == 2)
		{
			text = " 我 们 会 在 下 一 次 中 国 共 产 党 中 央 军 事 委 员 会 的 会 议 上 提 出 这 个 问 题 的 … … 我 发 誓 ！";
		}
	}
}
