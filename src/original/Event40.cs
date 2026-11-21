using EventsForDLC;
using UnityEngine;

public class Event40 : EventsSecond
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
		name = " 班 禅 喇 嘛 的 命 运";
		text = " 主 席 同 志 ， 一 大 批 藏 族 神 职 人 员 来 信 ， 要 求 你 们 考 虑 释 放 十 世 班 禅 喇 嘛 （ 班 禅 喇 嘛 是 仅 次 于 藏 传 佛 教 格 鲁 派 达 赖 喇 嘛 之 后 的 第 二 位 喇 嘛 — — 注 释 ： 国 安 部 ） 。 一 九 四 九 年 九 月 ， 十 世 班 禅 喇 嘛 洛 桑 · 特 林 利 · 拉 杜 鲁 布 · 确 吉 坚 赞 拒 绝 随 国 民 党 逃 往 台 湾 ， 支 持 中 华 人 民 共 和 国 的 成 立 。 后 来 在 西 藏 与 祖 国 统 一 中 发 挥 了 重 要 作 用 。 然 而 ， 他 随 后 严 厉 谴 责 了 西 藏 自 治 区 的 中 国 化 ，1964 年 他 被 宣 布 为 “ 西 藏 人 民 的 敌 人 ” ， 被 捕 并 被 关 进 在 他 目 前 居 住 的 北 京 秦 城 监 狱 。 我 们 可 以 释 放 他 ， 从 而 大 大 改 善 与 藏 族 僧 侣 和 自 治 区 人 民 的 关 系 。 但 这 有 意 义 吗 ？ 也 许 最 好 是 清 除 这 位 不 可 靠 的 喇 嘛 ， 让 我 们 的 保 护 人 坚 赞 诺 布 当 选 班 禅 喇 嘛 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (GlobalScript.inst.gameState.data[56] <= 1)
		{
			button_text[0] = " 让 他 接 着 蹲 监 狱 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 能 继 续 把 他 关 在 监 狱 里 了 ！";
		}
		if (GlobalScript.inst.gameState.data[56] <= 2)
		{
			button_text[1] = " 以 放 弃 宗 教 信 条 为 条 件 放 出 来";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 对 他 施 压 太 重 了 ！";
		}
		if (GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.data[56] != 4)
		{
			button_text[2] = " 释 放 他 ， 让 他 回 拉 萨 ， 但 要 在 国 安 部 的 监 督 下 （ 需 要4 单 位 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 或 使 他 成 为 阶 下 囚 ， 或 给 他 自 由";
		}
		if ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[3] = " 释 放 这 位 政 治 犯 和 给 他 平 反 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 平 反 ？ ！ 毛 主 席 亲 自 谴 责 过 他 ！";
		}
		if (GlobalScript.inst.gameState.data[56] != 4)
		{
			button_text[4] = " 在 心 脏 病 发 作 的 掩 盖 下 清 除 他 ， 强 迫 选 举 诺 布 成 为 新 的 班 禅 喇 嘛 。 （ 需 要7 单 位 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 班 禅 喇 嘛 应 该 由 僧 侣 自 己 选 择 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 班 禅 喇 嘛 的 命 运";
		switch (result_num)
		{
		case 0:
			text = " 你 的 信 下 达 了 如 下 的 决 议 ： “ 第 十 世 班 禅 喇 嘛 为 西 藏 和 中 国 人 民 做 出 了 伟 大 的 贡 献 ， 但 他 对 于 西 藏 和 中 国 的 国 际 声 誉 的 打 击 更 大 。 释 放 他 是 不 合 时 宜 且 危 险 的 。1979 年3 月 ， 中 国 的 持 不 同 政 见 者 魏 京 生 发 表 了 一 封 公 开 信 ， 谴 责 关 押 班 禅 喇 嘛 的 秦 城 监 狱 的 恶 劣 条 件 ， 在 那 之 后 他 被 送 往 拉 萨 软 禁 。 然 而 ， 第 十 世 班 禅 喇 嘛 直 到1989 年1 月28 日 去 世 后 才 获 得 了 自 由 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[6] += 5;
			break;
		case 1:
			if (GlobalScript.inst.gameState.data[50] <= 25)
			{
				text = " 确 吉 坚 赞 断 然 拒 绝 接 受 这 一 条 件 ， 理 由 是 我 们 对 西 藏 神 职 人 员 的 压 迫 很 严 重 。 好 吧 ， 这 是 他 自 找 的 — — 让 他 在 秦 城 待 到 他 尘 世 的 尽 头 吧 … …";
				GlobalScript.inst.gameState.data[1] += 50;
				GlobalScript.inst.gameState.data[3] -= 60;
				GlobalScript.inst.gameState.data[6] += 10;
				GlobalScript.inst.gameState.data[57] -= 50;
				GlobalScript.inst.gameState.influencePRC -= 10;
				break;
			}
			text = " 确 吉 坚 赞 最 后 同 意 这 个 条 件 ， 要 求 我 们 转 告" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 ， 总 的 来 说 ， 他 赞 同 国 家 对 待 西 藏 僧 侣 的 政 策 ， 同 时 他 还 向 我 们 保 证 了 他 以 后 不 会 再 参 加 宗 教 团 体 了 。 这 之 后 他 在 整 个 中 国 游 历 ， 并 与 一 名 解 放 军 战 士 李 洁 结 婚 。 他 在1981 年 正 式 的 恢 复 名 誉 并 回 到 了 拉 萨 ， 之 后 甚 至 在 西 藏 自 治 区 的 人 大 代 表 选 举 中 当 选 为 全 国 人 大 代 表 之 一 。";
			GlobalScript.inst.gameState.data[3] += 60;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[57] += 40;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding = 33;
			break;
		case 2:
			text = " 你 的 信 下 达 了 如 下 的 决 议 ： “ 十 世 班 禅 喇 嘛 在 拘 留 期 间 花 了 足 够 的 时 间 来 思 考 和 反 省 他 的 错 误 行 为 。 我 同 意 尽 快 释 放 他 ， 允 许 他 返 回 西 藏 ， 但 要 保 持 对 他 的 监 视 。 ”1959 年 扎 什 伦 布 寺 被 毁 时 ， 曾 有 一 批 班 禅 喇 嘛 的 遗 体 被 掩 埋 ， 但 回 到 拉 萨 后 ， 确 吉 坚 赞 将 他 们 的 遗 体 重 新 安 葬 了 。 总 的 来 说 ， 他 表 现 得 很 平 静 ， 没 有 尝 试 和 流 亡 的 十 四 世 达 赖 喇 嘛 或 他 的 支 持 者 取 得 联 系 。 因 此 ， 在1983 年 ， 一 部 有 关 他 的 自 传 电 影 被 拍 摄 出 来 。 班 禅 喇 嘛 的 赦 免 受 到 了 人 民 、 西 方 和 西 藏 移 民 的 热 烈 欢 迎 。";
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[57] += 40;
			GlobalScript.inst.gameState.data[9] -= 40;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding = 33;
			break;
		case 3:
			if (GlobalScript.inst.gameState.data[50] >= 26 && GlobalScript.inst.gameState.data[3] >= 700)
			{
				text = " 回 到 拉 萨 之 后 ， 十 世 班 禅 对 外 界 宣 布 他 对 中 国 政 府 没 有 任 何 不 满 ， 对 他 的 囚 禁 使 得 他 能 思 考 他 之 前 作 为 一 个 西 藏 人 民 的 剥 削 者 所 犯 下 的 种 种 罪 孽 ， 这 使 他 更 加 的 理 解 了 佛 法 。 在 重 新 安 葬 了 因 扎 什 伦 布 寺 被 破 坏 而 无 处 安 葬 的 前 几 代 班 禅 喇 嘛 的 遗 体 之 后 ， 确 吉 坚 赞 现 在 的 任 务 是 参 加 慈 善 活 动 ， 访 问 （ 经 苏 联 领 导 层 同 意 ） 卡 尔 梅 克 、 布 里 亚 特 和 图 瓦 苏 维 埃 自 治 社 会 主 义 共 和 国 和 向 这 些 蒙 古 族 自 治 共 和 国 传 播 佛 法 ， 帮 助 西 藏 与 这 些 苏 维 埃 自 治 共 和 国 建 立 宗 教 联 系 。 人 民 和 国 际 社 会 都 很 满 意 。";
				GlobalScript.inst.gameState.influencePRC += 10;
				GlobalScript.inst.gameState.data[3] += 120;
				GlobalScript.inst.gameState.data[6] -= 20;
				GlobalScript.inst.gameState.data[57] += 40;
				GlobalScript.inst.gameState.empires[0].relations += 120;
				GlobalScript.inst.gameState.empires[1].relations += 50;
				GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding = 33;
			}
			else
			{
				text = " 班 禅 喇 嘛 从 未 忘 记 中 央 政 府 是 如 何 虐 待 他 的 ， 在 回 到 拉 萨 后 ， 十 世 班 禅 很 快 开 始 四 处 发 表 反 动 言 论 ， 例 如 “ 我 能 出 来 当 然 是 好 的 ， 我 在 监 狱 中 有 着 很 多 的 思 考 ， 不 过 为 了 这 些 思 考 我 付 出 了 太 大 的 代 价 。 ” ， 并 开 始 与 达 赖 喇 嘛 建 立 了 联 系 。 现 在 国 际 社 会 无 不 在 谴 责 我 们 对 西 藏 自 治 区 的 政 策 。 最 后 当 最 高 人 民 法 院 想 重 新 逮 捕 他 时 ， 他 逃 到 了 不 丹 ， 之 后 移 动 到 印 度 ， 加 入 了 印 度 支 持 的 “ 西 藏 流 亡 政 府 ” ， 印 度 政 府 拒 绝 把 他 移 交 给 我 们 ， 现 在 藏 独 分 子 手 中 又 多 了 一 个 显 赫 的 人 物 ， 这 对 我 们 无 疑 是 不 利 的 。";
				GlobalScript.inst.gameState.data[3] -= 100;
				GlobalScript.inst.gameState.empires[0].relations -= 100;
				GlobalScript.inst.gameState.influencePRC -= 20;
				GlobalScript.inst.gameState.data[57] -= 100;
				GlobalScript.inst.gameState.data[6] += 20;
			}
			break;
		case 4:
			text = "1977 年10 月28 日 ， 秦 城 监 狱 的 警 卫 发 现 班 禅 喇 嘛 倒 在 牢 房 的 地 板 上 ， 没 有 任 何 生 命 迹 象 。 当 天 早 上 ， 以 注 射 补 品 的 名 义 ， 他 被 注 射 了 一 种 特 殊 的 引 起 心 肌 梗 塞 的 毒 药 。 尽 管 《 西 藏 日 报 》 （ 西 藏 人 民 代 表 大 会 的 一 个 机 构 ） 发 表 了 一 份 官 方 公 报 ， 称 班 禅 喇 嘛 的 死 因 为 心 脏 病 发 作 ， 但 很 少 有 人 相 信 。 流 亡 政 府 已 经 公 开 表 示 ， “ 班 禅 喇 嘛 因 不 同 意 中 国 吞 并 西 藏 而 被 国 安 部 杀 害 ” 。 我 们 任 命 的 寻 找 新 班 禅 喇 嘛 委 员 会 的 负 责 人 在 得 到 批 准 之 后 秘 密 与 逃 亡 的 达 赖 喇 嘛 保 持 联 系 ， 这 没 有 逃 过 国 安 部 的 注 意 。 仁 波 切 被 逮 捕 ， 取 而 代 之 的 是 曾 任 达 赖 喇 嘛 和 已 故 班 禅 喇 嘛 政 治 对 手 的 生 钦 · 洛 桑 坚 赞 。 他 达 成 了 我 们 需 要 的 效 果 — —11 月11 日 ， 坚 赞 诺 布 被 宣 布 为 第11 世 班 禅 喇 嘛 。 “ 藏 传 佛 教 向 国 家 和 社 会 郑 重 宣 誓 ， 要 保 护 国 家 ， 为 人 民 谋 福 利 。 ” 诺 布 说 ， 中 国 社 会 是 藏 传 佛 教 信 仰 的 良 好 环 境 。 他 还 赞 扬 他 的 前 任 “ 为 加 强 国 家 统 一 和 人 民 团 结 作 出 的 杰 出 贡 献 ” 。 然 而 ， 第 十 四 世 达 赖 喇 嘛 和 他 所 谓 的 “ 西 藏 流 亡 政 府 ” 已 经 宣 布 更 登 确 吉 尼 玛 为 新 的 第 十 一 世 班 禅 喇 嘛 。 我 们 必 须 逮 捕 他 … 藏 族 喇 嘛 破 坏 新 班 禅 喇 嘛 的 活 动 ， 支 持 达 赖 喇 嘛 的 任 命 ， 分 裂 情 绪 在 他 们 中 间 蔓 延 … …";
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.data[57] -= 30;
			GlobalScript.inst.gameState.data[9] -= 70;
			GlobalScript.inst.gameState.data[8] -= 40;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.data[3] -= 100;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
