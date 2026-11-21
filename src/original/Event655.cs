using EventsForDLC;
using UnityEngine;

public class Event655 : EventsSecond
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
		name = " 西 非 巨 人 — — 第 三 幕";
		text = "尼 日 利 亚 经 济 在20 世 纪80 年 代 进 入 了 严 重 的 衰 退 期 。 生 活 水 平 降 到 比 以 前 更 糟 糕 的 地 步 ， 外 债 增 加 。70 年 代 着 重 强 调 提 供 人 民 生 活 所 需 的 发 展 计 划 ， 因 为 国 家 支 持 出 口 导 向 战 略 而 被 放 弃 。 这 也 是 一 个 冲 突 的 时 代 ， 穷 人 抗 议 政 府 的 政 策 ， 宗 教 冲 突 也 不 断 增 加 ， 在 经 济 衰 退 和 政 治 上 管 理 不 善 的 刺 激 下 进 一 步 激 化 。 自 尼 日 利 亚 第 二 共 和 国 的 第 二 届 政 府 上 任 三 个 月 以 来 ， 国 家 的 状 况 并 未 好 转 ， 局 势 反 而 更 加 尖 锐 和 对 立 。 此 届 文 官 政 府 也 并 未 对 此 视 而 不 见 ， 他 们 制 定 了 新 的 改 革 计 划 ， 并 成 立 了 一 个 新 的 部 门 — — 国 家 指 导 部 ， 以 遏 制 政 府 内 部 的 腐 败 现 象 ， 他 们 制 定 了 一 个 名 为 “ 道 德 革 命 ” 的 新 计 划 ， 以 进 行 “ 反 违 纪 战 争 ” ， 但 我 们 似 乎 要 看 不 到 他 们 的 落 地 了 — — 近 期 在 尼 日 利 亚 与 乍 得 的 边 境 冲 突 中 ， 文 官 政 府 同 军 方 的 意 见 分 歧 使 得 尼 日 利 亚 国 内 本 就 不 算 乐 观 的 局 势 更 加 火 上 浇 油 。 根 据 情 报 ， 陆 军 参 谋 易 卜 拉 欣 · 巴 班 吉 达 少 将 和 负 责 对 乍 得 的 军 事 行 动 的 穆 罕 默 杜 · 布 哈 里 少 将 在 尼 日 利 亚 商 业 大 亨 莫 斯 胡 德 · 阿 比 奥 拉 的 资 助 下 拉 起 了 一 个 军 方 的 阴 谋 圈 子 ， 准 备 对 文 官 政 府 发 起 政 变 。 当 然 ， 文 官 政 府 方 面 也 不 缺 少 仍 然 支 持 政 权 的 军 事 力 量 。||我 们 是 否 要 做 些 什 么 ？ 毕 竟 ， 第 二 共 和 国 的 民 主 来 之 不 易 ， 但 话 又 说 回 来 ， 这 也 只 不 过 是 这 片 大 陆 无 处 不 在 的 一 场 政 变 罢 了 … … 或 许 ， 这 次 也 会 有 开 明 的 军 事 政 权 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] >= 1)
		{
			button_text[0] = "支 持 文 官 政 府";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 非 洲 的 民 主 制 也 不 过 是 买 办 的 游 戏 … …";
		}
		if (GlobalScript.inst.gameState.data[56] >= 2)
		{
			button_text[1] = " 支 持 军 官 集 团";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 会 去 支 持 一 个 军 政 府 ！";
		}
		button_text[2] = " 不 过 是 非 洲 的 一 场 政 变 罢 了";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 西 非 巨 人 — — 第 三 幕";
		switch (result_num)
		{
		case 0:
			text = " 我 们 决 定 帮 助 文 官 政 府 ， 保 护 非 洲 的 民 主 化 成 果 。 在 我 们 的 特 勤 支 持 下 ， 文 官 政 府 逮 捕 了 阴 谋 集 团 ， 在 随 后 的 审 判 中 ， 军 官 们 被 判 处 叛 国 罪 。 尼 日 利 亚 政 府 感 谢 我 们 的 支 持 ， 与 我 们 达 成 了 一 些 有 利 的 合 作 ， 我 们 也 向 他 们 发 送 了 援 助 。 意 识 到 了 局 势 的 严 峻 性 ， 他 们 决 定 大 力 改 进 新 制 定 的 改 革 计 划 和 加 速 “ 道 德 革 命 ” 的 落 实 ， 以 稳 定 政 权 。 希 望 局 势 会 好 转 吧 。";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Torg = true;
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.OilProd += 100f;
			break;
		case 1:
			text = " 我 们 向 军 官 集 团 提 供 了 支 持 。 深 夜 ， 在 与 总 统 卫 队 进 行 交 火 后 ， 全 副 武 装 的 士 兵 控 制 了 首 都 拉 各 斯 ， 在 清 除 腐 败 、 改 革 政 府 无 能 和 制 止 经 济 衰 退 等 口 号 下 ， 军 人 们 发 动 了 军 事 政 变 。 他 们 封 锁 机 场 ， 关 闭 边 境 ， 切 断 国 际 国 内 通 讯 联 系 ， 随 后 ， 政 府 军 人 在 国 家 广 播 电 台 宣 布 ： 武 装 部 队 已 接 管 了 政 权 ， 文 官 总 统 职 务 被 解 除 。 在 这 次 政 变 中 ， 军 人 们 逮 捕 了 总 统 和 副 总 统 、 众 议 院 议 长 及 各 部 部 长 ， 成 立 了 最 高 军 事 委 员 会 ， 富 拉 尼 人 穆 罕 默 杜 · 布 哈 里 少 将 出 任 国 家 元 首 和 武 装 部 队 总 司 令 ， 巴 班 吉 达 出 任 陆 军 参 谋 长 。 这 是 尼 日 利 亚 建 国 以 来 的 第 五 次 军 事 政 变 。 布 哈 里 上 台 后 就 下 令 禁 止 所 有 政 党 的 活 动 ， 解 散 议 会 并 终 止1979 年 宪 法 的 执 行 。 对 于 这 次 军 事 政 变 ， 上 台 后 的 布 哈 里 军 政 府 解 释 是 ： 由 于 国 家 政 治 的 行 为 规 则 被 公 然 破 坏 ， 国 家 的 法 律 被 有 意 识 地 引 导 为 某 些 个 人 和 集 团 服 务 ， 所 有 的 政 党 几 乎 都 不 遵 守 国 家 的 选 举 法 。 " + ((a.allcountries[60].SubGosstroy == 12) ? " 布 哈 里 还 指 出 ， 在 沙 加 里 腐 败 无 能 的 文 官 政 府 的 统 治 下 ， 国 家 政 治 与 经 济 生 活 的 动 荡 已 成 为 一 种 手 段 或 机 会 ， 被 腐 败 的 政 治 家 们 用 来 犯 罪 。" : null) + " 所 有 这 些 都 是 由 于 竞 争 中 的 政 治 偏 见 和 缺 少 公 正 引 起 的 ， 国 家 经 济 因 此 遭 到 巨 大 的 破 坏 。 布 哈 里 的 这 次 军 事 政 变 在 尼 日 利 亚 得 到 了 广 泛 的 支 持 ， 当 政 府 被 推 翻 的 消 息 传 来 时 ， 尼 日 利 亚 人 举 杯 庆 贺 。 新 政 府 感 谢 我 们 的 支 持 ， 与 我 们 达 成 了 一 些 有 利 的 合 作 。";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Gosstroy = 0;
			a.allcountries[60].SubGosstroy = 7;
			a.allcountries[60].Torg = true;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.OilProd += 100f;
			break;
		case 2:
			text = " 深 夜 ， 在 与 总 统 卫 队 进 行 交 火 后 ， 全 副 武 装 的 士 兵 控 制 了 首 都 拉 各 斯 ， 在 清 除 腐 败 、 改 革 政 府 无 能 和 制 止 经 济 衰 退 等 口 号 下 ， 军 人 们 发 动 了 军 事 政 变 。 他 们 封 锁 机 场 ， 关 闭 边 境 ， 切 断 国 际 国 内 通 讯 联 系 ， 随 后 ， 政 府 军 人 在 国 家 广 播 电 台 宣 布 ： 武 装 部 队 已 接 管 了 政 权 ， 文 官 总 统 职 务 被 解 除 。 在 这 次 政 变 中 ， 军 人 们 逮 捕 了 总 统 和 副 总 统 、 众 议 院 议 长 及 各 部 部 长 ， 成 立 了 最 高 军 事 委 员 会 ， 富 拉 尼 人 穆 罕 默 杜 · 布 哈 里 少 将 出 任 国 家 元 首 和 武 装 部 队 总 司 令 ， 巴 班 吉 达 出 任 陆 军 参 谋 长 。 这 是 尼 日 利 亚 建 国 以 来 的 第 五 次 军 事 政 变 。 布 哈 里 上 台 后 就 下 令 禁 止 所 有 政 党 的 活 动 ， 解 散 议 会 并 终 止1979 年 宪 法 的 执 行 。 对 于 这 次 军 事 政 变 ， 上 台 后 的 布 哈 里 军 政 府 解 释 是 ： 由 于 国 家 政 治 的 行 为 规 则 被 公 然 破 坏 ， 国 家 的 法 律 被 有 意 识 地 引 导 为 某 些 个 人 和 集 团 服 务 ， 所 有 的 政 党 几 乎 都 不 遵 守 国 家 的 选 举 法 。" + ((a.allcountries[60].SubGosstroy == 12) ? " 布 哈 里 还 指 出 ， 在 沙 加 里 腐 败 无 能 的 文 官 政 府 的 统 治 下 ， 国 家 政 治 与 经 济 生 活 的 动 荡 已 成 为 一 种 手 段 或 机 会 ， 被 腐 败 的 政 治 家 们 用 来 犯 罪 。" : null) + " 所 有 这 些 都 是 由 于 竞 争 中 的 政 治 偏 见 和 缺 少 公 正 引 起 的 ， 国 家 经 济 因 此 遭 到 巨 大 的 破 坏 。 布 哈 里 的 这 次 军 事 政 变 在 尼 日 利 亚 得 到 了 广 泛 的 支 持 ， 当 政 府 被 推 翻 的 消 息 传 来 时 ， 尼 日 利 亚 人 举 杯 庆 贺 。 希 望 这 次 还 能 有 第 一 共 和 国 那 样 的 开 明 军 官 吧 … … ";
			a.allcountries[60].LeaveAlliances();
			a.allcountries[60].Gosstroy = 0;
			a.allcountries[60].SubGosstroy = 7;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
