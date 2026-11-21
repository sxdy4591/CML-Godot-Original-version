using EventsForDLC;
using UnityEngine;

public class Event91 : EventsSecond
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
		if (!GlobalScript.inst.gameState.IsSocialism(yes: true, 33))
		{
			name = " 仰 光 爆 炸 事 件";
			text = " 根 据 我 们 的 情 报 ， 今 天 在 缅 甸 首 都 发 生 了 一 起 恐 怖 袭 击 ， 目 的 是 刺 杀 韩 国 总 统 全 斗 焕 。 由 于 全 斗 焕 在 爆 炸 发 生 两 分 钟 后 抵 达 现 场 ， 他 本 人 幸 免 于 难 ， 但 有17 名 韩 国 代 表 团 成 员 丧 生 。 恐 怖 分 子 很 快 被 抓 获 ， 经 过 审 问 ， 他 们 承 认 自 己 是 朝 鲜 军 队 的 军 官 。 而 朝 鲜 政 府 矢 口 否 认 与 此 事 有 任 何 牵 连 ， 但 实 际 上 ， 这 一 事 件 让 我 们 有 机 会 重 新 挑 起 朝 鲜 和 韩 国 之 间 的 对 抗 。";
		}
		else
		{
			name = " 墨 西 哥 爆 炸 案";
			text = "出 于 让 墨 西 哥 支 持 汉 城 奥 运 会 的 需 要 ， 全 斗 焕 率 团 前 往 墨 西 哥 访 问 。 韩 国 代 表 团 原 计 划 在 墨 西 哥 革 命 纪 念 塔 处 献 花 ， 但 由 于 交 通 堵 塞 ， 全 斗 焕 的 专 车 延 误 近 半 个 小 时 。 而 在 墨 西 哥 总 统 米 格 尔 · 德 拉 马 德 里 等 人 等 待 时 ， 由 部 分 朝 鲜 特 工 和 地 下 革 命 工 人 党 - 人 民 联 盟 的 游 击 战 士 组 成 的 敢 死 队 引 爆 了 事 先 安 装 在 革 命 纪 念 塔 附 近 的 炸 弹 。 爆 炸 瞬 间 杀 死 了 数 名 墨 西 哥 高 官 ， 米 格 尔 · 德 拉 马 德 里 总 统 由 于 距 离 炸 弹 较 远 幸 免 于 难 ， 敢 死 队 在 爆 炸 后 和 总 统 卫 队 进 行 交 火 试 图 突 围 ， 但 是 寡 不 敌 众 ， 最 终 被 尽 数 消 灭 。|此 次 爆 炸 案 后 ， 墨 西 哥 宣 布 与 朝 鲜 全 面 断 交 ， 韩 国 和 西 方 阵 营 则 认 为 此 次 袭 击 是 朝 鲜 极 权 恐 怖 主 义 的 又 一 大 体 现 。 而 根 据 朝 鲜 的 说 法 ， 这 些 特 工 均 为 叛 逃 分 子 ， 非 朝 鲜 官 方 所 为 ， 并 声 称 一 切 指 控 均 为 西 方 阵 营 空 穴 来 风 的 污 蔑 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 谴 责 朝 鲜 恐 怖 主 义";
		button_text[1] = " 谴 责 韩 国 的 挑 衅";
		button_text[2] = " 保 持 沉 默";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		if (GlobalScript.inst.gameState.IsSocialism(yes: true, 33))
		{
			name = " 墨 西 哥 爆 炸 案";
		}
		else
		{
			name = " 仰 光 爆 炸 事 件";
		}
		switch (result_num)
		{
		case 0:
			text = " 作 为 对 事 件 的 回 应 ， 整 个 “ 文 明 世 界 ” 都 对 朝 鲜 表 达 了 愤 怒 。 我 们 并 未 做 出 官 方 回 应 ， 但 在 《 人 民 日 报 》 上 发 表 了 一 篇 文 章 ， 强 烈 地 谴 责 了 朝 鲜 的 恐 怖 主 义 手 段 。 同 时 ， 在 朝 韩 边 境 上 ， 双 方 都 在 做 出 了 武 装 挑 衅 …";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			break;
		case 1:
			text = " 作 为 对 事 件 的 回 应 ， 整 个 “ 文 明 世 界 ” 都 对 朝 鲜 表 达 了 愤 怒 。 我 们 完 全 支 持 朝 鲜 的 姿 态 ， 将 事 件 称 为 韩 国 的 挑 衅 行 为 ， 并 谴 责 了 韩 国 。 同 时 ， 在 朝 韩 边 境 上 ， 双 方 都 在 做 出 了 武 装 挑 衅 …";
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 80;
			break;
		case 2:
			text = " 作 为 对 事 件 的 回 应 ， 整 个 “ 文 明 世 界 ” 都 对 朝 鲜 表 达 了 愤 怒 。 同 时 ， 在 朝 韩 边 境 上 ， 双 方 都 在 做 出 了 武 装 挑 衅 …";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
