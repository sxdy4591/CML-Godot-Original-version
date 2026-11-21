using EventsForDLC;
using UnityEngine;

public class Event109 : EventsSecond
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
		name = " 索 马 里 的 黄 金 时 代";
		text = " 在 索 马 里 灾 难 性 的 政 治 冒 险 后 ， <color=#2F4F4F>西 亚 德 · 巴 雷</color> 从 索 马 里 炙 手 可 热 的 红 星 变 为 了 人 人 喊 打 的 灾 星 。 为 了 维 护 自 己 的 统 治 ， 他 大 力 抓 捕 并 处 决 参 与 欧 加 登 战 争 的 军 官 。 一 部 分 军 官 们 认 为 ， <color=#2F4F4F>西 亚 德 · 巴 雷</color> 故 意 将 其 他 部 落 的 士 兵 用 作 “ 炮 灰 ” ， 而 他 自 己 的 马 烈 汉 部 族 的 军 官 则 得 到 了 更 安 全 的 命 令 。 至 少 是 出 于 对 <color=#2F4F4F>巴 雷</color> 的 种 族 歧 视 政 策 的 恼 怒 ， 以 及 欧 加 登 惨 败 后 对 其 政 权 的 失 望 。 由 奥 斯 曼 · 伊 罗 和 阿 卜 杜 拉 希 · 优 素 福 · 艾 哈 迈 德 等 人 意 图 推 翻 索 马 里 政 府 ， 至 少 换 上 一 个 能 够 解 决 内 部 矛 盾 的 更 平 等 的 政 府 。|| 主 席 同 志 ， 也 许 是 时 候 了 ？ 我 们 该 给 这 个 狂 妄 的 索 马 里 人 一 点 东 方 教 训 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[2] = " 什 么 都 不 做";
		if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.influencePRC >= 200)
		{
			button_text[0] = " 尽 全 力 支 持 他 们 的 政 变";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 能 帮 助 索 马 里";
		}
		if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.influencePRC >= 200)
		{
			button_text[1] = " 通 过 给 苏 联 泼 脏 水 ， 换 取 巴 雷 的 谅 解";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 可 没 有 余 力 关 注 这 件 事";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 索 马 里 的 黄 金 时 代";
		switch (result_num)
		{
		case 0:
			text = " 我 们 在 南 也 门 的 大 使 馆 内 接 见 了 索 马 里 的 反 对 派 ， 由 我 们 牵 头 组 建 了 <color=#DE3163>拯 救 索 马 里 民 主 与 解 放 阵 线</color> 。 这 是 一 个 由 <color=#006400>索 马 里 爱 国 运 动</color> ， <color=#8B0000>索 马 里 劳 动 党</color> ， <color=#006400>索 马 里 解 放 阵 线</color> 和 <color=#2F4F4F>索 马 里 革 命 社 会 主 义 党</color> 内 的 左 翼 反 对 派 组 成 的 泛 左 翼 反 对 派 组 织 。 我 们 慷 慨 的 为 他 们 提 供 了 足 够 的 援 助 和 军 事 支 持 ， 同 时 在 亚 的 斯 亚 贝 巴 组 建 了 办 公 室 ， 万 事 俱 备   只 欠 东 风 。||四 月 九 日 清 晨 ， 首 都 南 部 的 阿 夫 戈 伊 村 爆 发 了 枪 战 ， 首 都 郊 区 传 出 了 小 型 武 器 射 击 和 爆 炸 声 。 一 场 兵 变 在 哈 尔 格 萨 爆 发 了 ， 在 激 烈 的 战 斗 中 ， <color=#2F4F4F>巴 雷</color> 被 一 枚 炮 弹 炸 断 了 双 腿 。 在 痛 苦 中 ， 这 位 索 马 里 大 救 星 离 开 了 他 所 致 力 于 塑 造 的 国 家 。 新 政 府 宣 布 取 缔 <color=#2F4F4F>索 马 里 革 命 社 会 主 义 党</color> ， 新 的 <color=#DE3163>索 马 里 统 一 社 会 党</color> 则 被 建 立 起 来 了 。 该 党 致 力 于 先 完 成 军 政 府 未 完 成 的 民 族 民 主 革 命 ， 并 在 此 基 础 上 完 成 进 一 步 的 去 部 族 化 和 社 会 主 义 革 命 。 ";
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[22] -= 50;
			GlobalScript.inst.gameState.data[8] -= 80;
			GlobalScript.inst.gameState.empires[1].power += 5;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProChina);
			GlobalScript.inst.gameState.allcountries[42].Torg = true;
			GlobalScript.inst.gameState.allcountries[42].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 1;
			break;
		case 1:
			text = " 我 们 向 摩 加 迪 沙 广 播 的 “ 非 洲 革 命 之 声 ” 中 捏 造 了 这 样 一 条 新 闻 ： 有 一 个 不 存 在 的 索 马 里 民 主 革 命 运 动 接 受 了 苏 联 支 持 ， 并 谋 求 推 翻 <color=#2F4F4F>巴 雷 政 府</color> 。 而 在 我 们 和 <color=#2F4F4F>巴 雷</color> 的 秘 密 电 报 中 提 到 ， 如 果 愿 意 驱 逐 苏 联 外 交 官 和 军 港 ， 中 国 并 不 介 意 为 索 马 里 提 供 苏 联 撤 离 带 来 的 空 缺 。 迫 切 渴 望 援 助 的 <color=#2F4F4F>巴 雷</color> 欣 然 接 纳 。||四 月 九 日 清 晨 ， 南 部 的 阿 夫 戈 伊 村 爆 发 了 枪 战 ， 首 都 郊 区 传 出 了 小 型 武 器 射 击 和 爆 炸 声 。 政 变 最 初 计 划 在 哈 尔 格 萨 发 动 ， 但 得 到 了 通 知 和 援 助 的 <color=#2F4F4F>巴 雷</color> 事 先 知 道 了 这 一 企 图 ， 并 在 政 变 发 动 前 就 将 其 挫 败 ， 并 在 首 都 安 置 了 忠 于 自 己 的 部 队 。 他 在 摩 加 迪 沙 的 群 众 大 会 上 讲 到 “ 我 国 四 处 都 是 敌 人 ， 美 国 和 苏 联 的 帝 国 主 义 者 无 时 无 刻 不 想 奴 役 我 们 ， 只 有 中 华 人 民 共 和 国 愿 意 成 为 索 马 里 的 忠 实 战 友 。 ” 他 公 开 和 苏 联 决 裂 的 决 定 得 到 了 我 们 的 支 持 ， 在 《 人 民 日 报 》 《 解 放 军 报 》 和 《 工 人 日 报 》 上 ， 我 们 高 度 赞 扬 了 反 对 帝 国 主 义 压 迫 的 <color=#2F4F4F>西 亚 德 · 巴 雷</color> 将 军 ， 并 加 大 了 我 们 同 他 的 合 作 。||大 约 有2 4名 军 官 、 2 , 0 0 0名 士 兵 和6 5名 雇 佣 兵 参 与 了 这 场 政 变 ， 而 他 们 悉 数 被 处 死 。";
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[22] -= 50;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 70;
			GlobalScript.inst.gameState.empires[0].relations -= 70;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[6] += 30;
			GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProChina);
			GlobalScript.inst.gameState.allcountries[42].Torg = true;
			GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 10;
			break;
		case 2:
			text = " 清 晨 ， 摩 加 迪 沙 南 部 的 阿 夫 戈 伊 村 爆 发 了 枪 战 ， 首 都 郊 区 传 出 了 小 型 武 器 射 击 和 爆 炸 声 。 政 变 最 初 计 划 在 哈 尔 格 萨 发 动 ， 但 <color=#2F4F4F>巴 雷</color> 很 可 能 事 先 知 道 了 这 一 企 图 ， 并 在 政 变 发 动 前 就 将 其 挫 败 ， 并 在 首 都 安 置 了 忠 于 自 己 的 部 队 。||但 反 对 派 并 未 就 此 打 住 ， 他 们 只 是 在 等 一 个 机 会 … …||大 约 有2 4名 军 官 、 2 , 0 0 0   名 士 兵 和6 5名 雇 佣 兵 参 与 了 这 场 政 变 。 他 们 悉 数 被 处 死 。||索 马 里 ， 这 一 非 洲 的 隐 士 国 度 ， 他 将 继 续 过 着 默 默 无 闻 的 日 子 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
