using EventsForDLC;
using UnityEngine;

public class Event71 : EventsSecond
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
		name = " 东 方 红 …";
		text = " 多 亏 了 我 们 的 支 持 ， 在 印 度 东 部 的 毛 派 反 政 府 武 装 ， 即 纳 萨 尔 派 分 子 ， 在 东 部 各 州 获 得 了 相 当 大 的 影 响 力 和 一 些 公 众 支 持 。 他 们 控 制 着 大 片 地 区 ， 他 们 不 断 的 攻 击 已 经 成 为 令 东 部 各 州 和 印 度 中 央 政 府 头 疼 的 问 题 。 一 些 印 度 政 客 已 经 在 考 虑 与 他 们 谈 判 ， 我 们 可 以 利 用 这 一 点 使 印 度 东 部 的 地 方 政 府 接 纳 纳 萨 尔 派 ， 并 在 谈 判 中 进 行 调 停 ， 这 将 大 大 增 加 我 们 对 印 度 的 影 响 力 ， 并 在 印 度 东 部 实 行 相 对 坚 定 的 左 翼 政 策 。 这 是 以 纳 萨 尔 派 和 印 度 当 局 能 开 始 与 我 们 谈 判 为 前 提 的 。 是 的 ， 保 持 印 度 东 部 的 不 稳 定 状 况 可 以 给 我 们 一 个 有 相 对 机 动 余 地 的 机 会 ， 而 不 是 和 现 在 一 样 的 未 来 … … 然 而 ， 部 分 将 领 和 党 员 已 经 制 定 了 一 个 行 动 计 划 ， 他 们 提 出 利 用 该 形 势 ， 向 伪 阿 鲁 纳 恰 尔 邦 （ 即 我 国 藏 南 地 区 ） 境 内 派 兵 ， 我 们 假 装 “ 保 护 平 民 ， 恢 复 秩 序 ” ， 然 后 就 可 以 毫 无 问 题 地 将 之 收 回 中 国 。 但 这 将 意 味 着 与 印 度 爆 发 新 的 边 境 战 争 …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 让 他 们 继 续 进 行 游 击 战 ， 这 对 我 们 来 说 已 经 足 够 了";
		if (GlobalScript.inst.gameState.influencePRC >= 100 && GlobalScript.inst.gameState.allcountries[19].Torg)
		{
			button_text[1] = " 以 停 止 敌 对 行 动 换 取 纳 萨 尔 派 进 入 地 方 政 府";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 他 们 不 会 和 我 们 谈 判";
		}
		if (!GlobalScript.inst.gameState.allcountries[19].Torg && GlobalScript.inst.gameState.war == 0 && !GlobalScript.inst.gameState.allcountries[15].cw)
		{
			button_text[2] = " 准 备 好 战 争 ， 派 遣 部 队";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 现 在 不 是 为 了 发 动 战 争 而 加 强 联 系 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 东 方 红 …";
		switch (result_num)
		{
		case 0:
			text = " 一 切 都 没 有 改 变 ， 纳 萨 尔 派 分 子 继 续 他 们 的 攻 击 ， 印 度 政 府 正 以 不 同 的 成 功 试 图 遏 制 他 们 。 但 是 谁 知 道 呢 ， 也 许 有 一 天 他 们 会 对 我 们 有 用 ， 因 为 他 们 也 在 我 们 宣 称 的 领 土 上 活 动 … …";
			GlobalScript.inst.gameState.CBIndia = true;
			break;
		case 1:
			text = " 经 过 长 期 的 争 论 和 犹 豫 ， 印 度 政 府 仍 然 同 意 通 过 我 们 的 调 解 与 纳 萨 尔 派 进 行 谈 判 。 在 谈 判 取 得 成 果 后 ， 他 们 非 常 困 难 地 实 现 了 向 和 平 斗 争 的 过 渡 ， 以 换 取 地 方 政 府 和 自 治 机 关 的 席 位 （ 在 少 数 地 区 甚 至 获 得 了 多 数 席 位 ） ， 并 承 认 他 们 是 合 法 的 政 治 力 量 。 当 然 ， 一 些 士 兵 和 团 体 已 经 称 之 为 背 叛 ， 但 我 们 对 这 些 恐 怖 分 子 有 何 关 心 ？ 我 们 在 印 度 东 部 的 影 响 力 已 大 大 增 强 。";
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[6] -= 10;
			break;
		case 2:
			text = " 解 放 军 部 队 很 快 就 攻 破 了 第 一 个 印 度 边 境 部 队 的 防 御 工 事 ， 但 后 来 他 们 依 靠 了 上 次 边 界 战 争 以 来 组 织 良 好 的 印 度 防 御 工 事 。 看 来 这 场 战 争 会 比 我 们 想 象 的 更 持 久 、 更 血 腥 … … 与 此 同 时 ， 全 世 界 都 在 侧 视 我 们 ， 要 求 我 们 立 即 坐 在 谈 判 桌 旁 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.empires[1].relations -= 250;
			GlobalScript.inst.gameState.data[6] += 50;
			GlobalScript.inst.gameState.war = 2;
			GlobalScript.inst.gameState.data[40] = 200;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
