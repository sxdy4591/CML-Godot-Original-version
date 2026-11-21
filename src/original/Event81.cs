using EventsForDLC;
using UnityEngine;

public class Event81 : EventsSecond
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
		name = " 匈 牙 利 狂 想 曲";
		text = " 来 自 布 达 佩 斯 的 奇 怪 消 息 — — 似 乎 在 赫 鲁 晓 夫 时 代 所 夸 耀 的 的 卡 达 尔 主 义 者 的 “ 古 拉 什 社 会 主 义 ” 正 处 于 违 约 的 边 缘 — — 实 际 上 ， 匈 牙 利 欠 下 了 国 际 货 币 基 金 组 织77 亿 美 元 ， 而 这 是 它 无 力 支 付 的 。 根 据 我 们 的 经 济 学 家 的 看 法 ， 匈 牙 利 人 有 两 个 选 择 — — 要 么 从 西 方 和 苏 联 获 得 新 的 贷 款 ， 要 么 开 始 全 面 的 市 场 改 革 ， 这 将 损 害 大 多 数 人 的 生 活 水 平 。 匈 牙 利 社 会 主 义 工 人 党 的 领 导 人 不 会 采 取 后 一 个 选 择 ， 因 为 他 们 还 记 得 布 拉 格 之 春 事 件 ， 所 以 他 们 很 可 能 会 接 受 新 的 贷 款 。 我 们 可 以 利 用 匈 牙 利 人 民 共 和 国 的 问 题 ， 向 他 们 提 供 我 们 的 经 济 援 助 — — 但 条 件 是 为 受 辱 的 斯 大 林 主 义 者 比 斯 库 · 贝 洛 及 其 集 团 平 反 ， 他 们 反 对 半 市 场 改 革 ， 并 可 以 成 为 我 们 在 匈 社 工 党 内 的 可 靠 支 持 者 。 但 是 ， 我 们 也 可 以 在 不 提 出 政 治 条 件 的 情 况 下 ， 为 溺 水 者 提 供 帮 助 …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if ((GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7) || (GlobalScript.inst.gameState.data[56] == 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[0] = " 我 们 将 无 条 件 向 匈 牙 利 提 供 经 济 援 助 （ 需 要35 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 足 够 的 钱 资 助 卡 达 尔 主 义 者";
		}
		if (GlobalScript.inst.gameState.data[89] == 0 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[1] = " 我 们 利 用 匈 牙 利 人 民 共 和 国 的 问 题 来 诋 毁 市 场 改 革";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 匈 牙 利 的 例 子 并 不 能 证 明 一 切 改 革 的 失 败";
		}
		if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 我 们 将 向 匈 牙 利 提 供 经 济 援 助 ， 但 交 换 条 件 是 平 反 比 斯 库 集 团 （ 需 要15 百 万 元 预 算 ，8 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 对 我 们 来 说 不 是 很 好";
		}
		if ((GlobalScript.inst.gameState.data[56] < 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[3] = " 我 们 将 完 全 承 担 匈 牙 利 国 债 ， 但 交 换 条 件 是 完 全 平 反 比 斯 库 集 团 （ 需 要45 百 万 元 预 算 ，10 特 工 ）";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 对 我 们 来 说 太 激 进 了 ！";
		}
		button_text[4] = " 无 视 它";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 匈 牙 利 狂 想 曲";
		switch (result_num)
		{
		case 0:
			text = " 你 亲 自 打 电 话 给 卡 达 尔 · 亚 诺 什 ， 告 诉 他 全 国 人 民 代 表 大 会 常 务 委 员 会 决 定 以 非 常 低 的 利 率 向 匈 牙 利 提 供35 亿 美 元 的 贷 款 。 这 使 得 该 国 能 够 避 免 违 约 ， 而 不 是 诉 诸 新 的 贷 款 。 卡 达 尔 作 为 匈 牙 利 人 民 共 和 国 国 务 委 员 会 首 脑 ， 代 表 匈 牙 利 人 民 向 中 国 人 民 表 示 了 巨 大 的 感 谢 ， 但 苏 联 和 美 国 对 此 并 不 满 意 ， 媒 体 已 经 在 写 “ 中 国 在 欧 洲 的 经 济 扩 张 ” 。";
			GlobalScript.inst.gameState.data[8] -= 300;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].power -= 10;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.empires[0].relations -= 80;
			break;
		case 1:
			text = " 中 央 意 识 形 态 部 门 授 权 了 印 刷 大 量 有 关 匈 牙 利 局 势 的 重 要 材 料 。 “ 古 拉 什 社 会 主 义 ” 被 宣 布 为 “ 虚 假 市 场 审 计 ” ， 卡 达 尔 参 加1956 年 的 反 革 命 政 变 ， 并 得 到 纳 吉 · 伊 姆 雷 集 团 的 支 持 的 经 历 被 重 新 揭 发 ， 匈 牙 利 社 会 主 义 工 人 党 被 称 为 “ 愚 蠢 的 社 会 主 义 叛 徒 的 马 克 思 主 义 党 ” ， 匈 牙 利 的 社 会 主 义 制 度 被 称 为 “ 建 立 在 美 国 货 币 装 饰 之 上 ” 。 在 此 基 础 上 ， 得 出 了 所 有 市 场 改 革 都 是 修 正 主 义 ， 是 走 向 经 济 深 渊 的 道 路 的 结 论 。 党 和 人 民 不 接 受 这 已 经 相 当 无 聊 的 新 宣 传 攻 势 ， 匈 牙 利 表 达 了 坚 决 的 抗 议 ， 这 得 到 了 苏 联 的 支 持 。 我 觉 得 这 不 是 我 们 想 要 的 …";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[4] -= 20;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 30;
			GlobalScript.inst.gameState.empires[1].relations -= 80;
			break;
		case 2:
			text = " 今 天 上 午 ， 中 国 驻 布 达 佩 斯 大 使 会 见 了 卡 达 尔 ， 代 表 我 们 提 供 了35 亿 美 元 的 无 息 贷 款 。 卡 达 尔 准 备 立 刻 同 意 ， 但 大 使 随 后 的 话 使 他 清 醒 起 来 — — 作 为 贷 款 的 交 换 ， 匈 牙 利 社 会 主 义 工 人 党 中 央 委 员 会 政 治 局 应 为 比 斯 库 · 贝 洛 集 团 平 反 ， 恢 复 他 们 的 党 籍 和 职 位 ， 而 贝 洛 加 入 他 们 的 行 列 。 这 引 起 了 匈 牙 利 领 导 人 的 强 烈 抗 议 ， 由 于 长 时 间 的 口 头 争 吵 ， 只 能 达 成 妥 协 — — 比 斯 库 的 一 些 同 事 被 增 选 为 中 央 委 员 会 成 员 ， 匈 牙 利 获 得 了15 亿 美 元 的 贷 款 。 这 使 得 该 国 避 免 了 立 即 违 约 ， 但 仍 需 从 国 际 货 币 基 金 组 织 获 得 新 的 贷 款 。 多 亏 了 我 们 ， 现 在 左 翼 反 对 派 已 经 在 匈 社 工 党 内 出 现 了 ， 但 最 终 形 成 势 力 需 要 很 多 时 间 … 此 外 ， 苏 联 对 我 们 在 其 影 响 范 围 内 的 干 涉 非 常 不 满 。";
			GlobalScript.inst.gameState.data[8] -= 150;
			GlobalScript.inst.gameState.data[9] -= 80;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			break;
		case 3:
		{
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 召 见 了 匈 牙 利 驻 北 京 大 使 ， 让 他 转 交 给 卡 达 尔 · 亚 诺 什 一 封 信 ， 信 中 提 议 中 国 将 承 担 匈 牙 利 的 债 务 ， 以 避 免 匈 牙 利 违 约 ， 并 且 还 提 供45 亿 美 元 的 无 息 贷 款 － 条 件 是 为 比 斯 库 · 贝 洛 团 体 平 反 ， 将 比 斯 库 增 选 为 匈 社 工 党 中 央 委 员 会 政 治 局 委 员 。 同 时 我 们 的 特 工 挑 起 了 “ 人 民 卫 队 ” （ 匈 社 工 党 的 准 军 事 组 织 ， 其 中 左 翼 保 守 情 绪 十 分 强 烈 ） 单 位 的 骚 乱 ， 并 散 播 攻 击 匈 牙 利 改 革 的 意 识 形 态 主 管 － 涅 尔 什 · 雷 热 的 材 料 （ 此 人 是 资 深 社 会 民 主 主 义 者 ， 曾 在 纳 吉 · 伊 姆 雷 政 府 中 担 任 部 长 ） 。 考 虑 到 拒 绝 帮 助 可 能 会 让1956 年 的 形 势 重 演 ， 卡 达 尔 被 迫 同 意 。 比 斯 库 · 贝 洛 在 我 们 的 帮 助 迅 速 组 织 起 左 翼 反 对 派 ， 捷 尔 吉 也 被 迫 退 出 政 治 。 看 起 来 社 工 党 内 部 即 将 出 现 新 的 分 裂 ， 只 是 卡 达 尔 的 存 在 使 得 局 势 还 在 控 制 之 中 …| 在 左 翼 反 对 派 压 力 和 至 少 保 存 党 的 外 部 团 结 的 渴 望 下 ， 卡 达 尔 宣 布 了 “ 多 重 方 向 ” 的 外 交 政 策 ， 开 始 与 我 们 建 立 文 化 和 贸 易 关 系 。 苏 联 和 美 国 十 分 愤 怒 ， 我 们 加 强 了 在 欧 洲 的 地 位 。 但 我 们 现 在 必 须 得 承 担 匈 牙 利 的 债 务 义 务 …";
			GlobalScript.inst.gameState.data[8] -= 450;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			Leader leader;
			int support = (leader = GlobalScript.inst.gameState.empires[1].leaders[6]).support;
			leader.support = support - 1;
			GlobalScript.inst.gameState.empires[1].relations -= 200;
			GlobalScript.inst.gameState.allcountries[4].prosov = false;
			GlobalScript.inst.gameState.allcountries[4].Torg = true;
			break;
		}
		case 4:
			text = " 我 们 没 有 以 任 何 方 式 干 涉 匈 牙 利 的 事 务 。 该 国 设 法 通 过 从 国 际 货 币 基 金 组 织 获 得 新 的 贷 款 来 避 免 违 约 ， 这 只 会 推 迟 负 面 趋 势 的 发 生 ， 但 这 种 情 况 会 持 续 很 长 一 段 时 间 ， 因 此 我 们 无 法 对 其 产 生 影 响 。 “ 同 时 ， 根 据 匈 牙 利 同 志 的 说 法 ， 匈 牙 利 应 该 深 化 参 与 国 际 合 作 ， 以 免 发 明 在 其 他 国 家 早 已 发 现 的 东 西 ” 。";
			GlobalScript.inst.gameState.empires[0].power += 10;
			GlobalScript.inst.gameState.empires[1].power -= 10;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
