using EventsForDLC;
using UnityEngine;

public class Event90 : EventsSecond
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
		name = " 香 港 再 见 ， 澳 门 再 见 ？";
		text = " 如 你 所 知 ， 我 们 就 香 港 和 澳 门 在1997 年 和1999 年 回 归 后 获 取 的 广 泛 自 治 权 问 题 达 成 了 数 项 协 议 ， 我 们 甚 至 为 此 设 立 了 一 个 新 的 行 政 单 位 — — “ 特 别 行 政 区 ” 。 然 而 ， 港 澳 部 分 大 资 产 阶 级 人 士 反 对 这 项 协 议 ， 而 我 们 的 情 报 机 构 查 明 ， 他 们 正 准 备 进 行 一 系 列 挑 衅 活 动 ， 以 破 坏 协 议 签 署 ， 并 维 持 英 国 和 葡 萄 牙 的 殖 民 统 治 （ 特 别 是 最 大 限 度 地 拖 延 特 别 行 政 区 的 基 本 法 的 制 定 ， 举 行 反 华 集 会 ， 并 在 媒 体 上 发 表 有 煽 动 性 的 材 料 ） 。 在 这 种 情 况 下 ， 一 些 党 员 提 出 了 一 个 令 人 出 乎 意 料 的 建 议 — — 与 所 谓 的 三 合 会 建 立 联 系 。 三 合 会 是 香 港 第 七 大 最 有 影 响 力 的 犯 罪 集 团 ， 他 们 在 整 个 东 南 亚 都 有 强 大 的 关 系 。 我 们 可 以 向 他 们 提 供 优 惠 的 经 济 优 惠 和 司 法 豁 免 保 障 ， 但 条 件 是 他 们 要 协 助 香 港 和 澳 门 回 归 祖 国 。 所 以 你 的 决 定 是 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.data[9] >= 40 && ((GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[0] = " 我 们 会 对 三 合 会 开 出 他 们 无 法 拒 绝 的 条 件 的 （ 需 要4 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 只 有 国 民 党 才 会 这 么 做 ！";
		}
		if (GlobalScript.inst.gameState.data[9] >= 30 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[1] = " 我 们 可 以 与 犯 罪 辛 迪 加 们 结 成 战 略 同 盟 。 但 这 可 不 意 味 着 他 们 有 了 免 死 金 牌 （ 需 要2 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 不 与 黑 社 会 妥 协 ！!";
		}
		button_text[2] = " 我 们 关 心 这 些 强 盗 干 什 么 ？";
		if (GlobalScript.inst.gameState.data[9] >= 80 && GlobalScript.inst.gameState.data[16] <= 13 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[3] = " 现 在 是 时 候 对 我 国 南 方 省 份 的 有 组 织 犯 罪 进 行 有 力 打 击 了 ！ （ 需 要8 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 他 们 是 非 常 诚 实 合 法 的 商 人 且 支 持 改 革 开 放 。 我 们 无 权 怀 疑 他 们 。";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 香 港 再 见 ， 澳 门 再 见 ？";
		switch (result_num)
		{
		case 0:
			text = " 在 特 勤 部 队 、 国 有 企 业 和 亲 中 游 说 组 织 的 帮 助 下 ， 我 们 与 三 合 会 的 三 个 主 要 财 团 建 立 了 联 系 ， 分 别 是 “ 十 四K ” 、 “ 新 义 安 ” 和 “ 和 胜 和 ” 。 他 们 得 到 了 我 们 对 其 成 员 和 资 产 不 受 侵 犯 的 保 证 ， 并 提 出 了 一 项 建 议 ， 即 以 极 其 优 惠 的 条 件 将 其 资 本 投 资 于 该 地 区 经 济 （ 特 别 是 生 产 麻 黄 ） 三 合 会 的 领 导 人 已 经 准 备 在 美 国 重 新 设 置 他 们 的 中 心 ， 同 意 我 们 的 建 议 。 他 们 开 始 在 我 国 南 方 省 份 进 行 大 量 投 资 ， 并 利 用 他 们 的 影 响 力 压 制 反 对 中 国 统 一 的 人 的 行 动 （ 特 别 是 批 评 材 料 从 媒 体 上 消 失 ， 所 有 抗 议 活 动 在 腐 败 警 察 的 默 许 下 迅 速 被 三 合 会 成 员 驱 散 ， 还 有 一 些 香 港 和 澳 门 商 人 移 居 国 外 ） 。 因 此 ， 我 们 现 在 得 到 了 辛 迪 加 的 支 持 ， 但 同 时 也 受 到 了 犯 罪 世 界 和 腐 败 日 益 增 长 的 影 响 。";
			GlobalScript.inst.gameState.data[9] -= 40;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[8] += 100;
			GlobalScript.inst.gameState.data[26] += 150;
			GlobalScript.inst.gameState.modifies[5].active = true;
			break;
		case 1:
			if (GlobalScript.inst.gameState.data[6] > 300 && GlobalScript.inst.gameState.data[14] < 3)
			{
				text = " 我 们 与 三 合 会 最 大 的 三 个 财 团 建 立 了 联 系 ， 分 别 是 “ 十 四K ” 、 “ 新 义 安 ” 和 “ 和 胜 和 ” 。 他 们 得 到 了 我 们 的 保 证 ， 保 证 他 们 的 成 员 和 资 产 不 受 侵 犯 ， 他 们 的 领 导 人 同 意 了 这 一 点 ， 利 用 自 己 的 影 响 力 压 制 反 对 中 国 统 一 的 人 的 行 动 （ 特 别 是 ， 媒 体 中 的 批 评 材 料 消 失 了 ， 所 有 的 抗 议 活 动 都 被 在 腐 败 警 察 的 默 许 下 ， 被 黑 社 会 成 员 迅 速 驱 散 ， 一 些 商 人 从 香 港 和 澳 门 移 居 海 外 。 ） 但 是 ， 国 安 部 阻 止 三 合 会 在 中 国 南 部 省 份 站 稳 脚 跟 ，1997 年 以 后 ， 我 们 将 对 他 们 展 开 系 统 性 打 击 。";
				GlobalScript.inst.gameState.data[9] -= 20;
				GlobalScript.inst.gameState.data[3] -= 50;
				GlobalScript.inst.gameState.data[6] += 20;
			}
			else
			{
				text = " 我 们 与 三 合 会 最 大 的 三 个 财 团 建 立 了 联 系 ， 分 别 是 “ 十 四K ” 、 “ 新 义 安 ” 和 “ 和 胜 和 ” 。 他 们 得 到 了 我 们 的 保 证 ， 保 证 他 们 的 成 员 和 资 产 不 受 侵 犯 ， 他 们 的 领 导 人 同 意 了 这 一 点 ， 利 用 自 己 的 影 响 力 压 制 反 对 中 国 统 一 的 人 的 行 动 （ 特 别 是 ， 媒 体 中 的 批 评 材 料 消 失 了 ， 所 有 的 抗 议 活 动 都 被 在 腐 败 警 察 的 默 许 下 ， 被 黑 社 会 成 员 迅 速 驱 散 ， 一 些 商 人 从 香 港 和 澳 门 移 居 海 外 。 ） 但 是 ， 国 安 部 阻 止 三 合 会 在 中 国 南 部 省 份 站 稳 脚 跟 ，1997 年 以 后 ， 我 们 将 对 他 们 展 开 系 统 性 打 击 。";
				GlobalScript.inst.gameState.data[9] -= 20;
				GlobalScript.inst.gameState.data[3] -= 50;
				GlobalScript.inst.gameState.data[6] += 20;
				GlobalScript.inst.gameState.data[26] += 80;
				GlobalScript.inst.gameState.data[8] += 50;
				GlobalScript.inst.gameState.modifies[5].active = true;
			}
			break;
		case 2:
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 断 然 拒 绝 与 香 港 犯 罪 集 团 进 行 任 何 谈 判 。 之 后 在 香 港 和 澳 门 发 生 了 一 系 列 反 华 事 件 ， 一 场 有 系 统 性 的 运 动 开 始 败 坏 有 关 港 澳 回 归 协 议 的 名 声 ， 最 终 导 致 在 港 澳 两 地 发 生 的 大 规 模 屠 杀 ， 以 及 使 得 英 国 和 葡 萄 牙 的 议 会 最 终 拒 绝 批 准 回 归 协 议 。";
			GlobalScript.inst.gameState.data[65] = 0;
			if (GlobalScript.inst.gameState.allcountries[51].Torg || GlobalScript.inst.gameState.allcountries[1].isSEV)
			{
				text += " 但 是 ， 我 们 的 朋 友 给 他 们 施 加 了 压 力 ， 使 英 国 和 葡 萄 牙 被 迫 履 行 了 他 们 的 义 务 。 香 港 和 澳 门 将 分 别 于1997 年 和1999 年 回 归 。";
				GlobalScript.inst.gameState.data[65] = 1;
			}
			break;
		case 3:
			text = " “ 要 么 共 产 党 战 胜 腐 败 ， 要 么 腐 败 战 胜 共 产 党 ” — — 这 一 口 号 在 政 治 局 会 议 上 被 提 出 。 中 国 公 安 部 和 中 央 纪 委 在 毗 邻 香 港 和 澳 门 的 中 国 南 方 省 份 ， 以 及 最 近 开 放 的 经 济 特 区 内 发 起 了 一 场 大 规 模 的 反 腐 运 动 。 数 百 名 各 级 官 员 被 免 职 ， 成 千 上 万 的 人 被 开 除 中 共 党 籍 ， 数 以 百 万 计 的 赃 款 都 被 没 收 ， 成 都 市 长 陈 希 同 （ 被 称 为 “ 中 国 的 格 里 申 ” ） 因 窃 取 了 数 十 亿 元 的 人 民 财 产 和 为 自 己 建 造 豪 华 别 墅 的 行 为 被 判 处 枪 决 。 这 完 全 打 乱 了 腐 败 组 织 ， 使 得 可 以 在 某 种 程 度 上 矫 正 局 势 ， 切 断 了 我 们 的 精 英 阶 层 与 和 他 们 在 港 澳 的 “ 同 伙 ” 之 间 的 腐 败 交 易 。 后 者 以 防 万 一 ， 移 民 海 外 。";
			GlobalScript.inst.gameState.data[8] += 40;
			GlobalScript.inst.gameState.data[9] -= 80;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[26] -= 150;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
