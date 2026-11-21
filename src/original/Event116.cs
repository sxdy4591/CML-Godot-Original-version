using EventsForDLC;
using UnityEngine;

public class Event116 : EventsSecond
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
		name = " 两 个 中 国";
		text = " 如 你 所 知 ， 解 放 战 争 胜 利 后 ， 国 民 党 败 逃 到 台 湾 岛 ， 西 方 社 会 长 期 认 为 他 们 是 中 国 的 合 法 政 府 。 由 于 美 国 在 台 湾 的 基 地 和 舰 队 ， 我 们 无 法 解 放 它 ， 就 像 国 民 党 无 法 反 攻 大 陆 一 样 ， 随 着 时 间 的 推 移 ， 越 来 越 多 的 国 家 承 认 中 华 人 民 共 和 国 为 中 国 唯 一 合 法 政 府 ， 尽 管 中 华 人 民 共 和 国 和 台 湾 政 府 都 没 有 正 式 拒 绝 对 全 中 国 的 主 张 。 当 然 ， 我 们 之 间 的 关 系 一 直 很 糟 糕 ， 但 是 最 近 自 由 化 和 中 国 共 产 党 结 束 了 对 权 力 的 垄 断 之 后 ， 我 们 之 间 的 关 系 明 显 升 温 。 现 在 双 方 高 层 都 在 谈 论 期 待 已 久 的 国 家 统 一 的 可 能 性 。 但 是 ， 在 这 种 情 况 下 ， 台 湾 会 旗 帜 鲜 明 地 要 求 自 治 ， 我 们 需 要 在 他 们 的 根 据 地 地 位 上 与 美 国 达 成 一 致 ， 而 台 湾 人 民 成 功 地 发 展 了 他 们 的 文 化 认 同 ， 这 将 如 何 影 响 这 个 国 家 已 经 不 稳 定 的 局 势 ， 目 前 还 不 知 道 。 因 此 ， 有 人 建 议 我 们 与 台 湾 相 互 承 认 对 方 为 独 立 国 家 ， 建 立 睦 邻 友 好 关 系 。 既 然 在 这 种 情 况 下 ， 美 国 的 基 地 将 继 续 存 在 ， 西 方 公 司 将 免 于 官 僚 主 义 的 大 惊 小 怪 ， 那 就 很 好 地 暗 示 美 国 ， 年 轻 的 民 主 需 要 钱 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 保 持 原 样";
		if (GlobalScript.inst.gameState.data[6] <= 500 && GlobalScript.inst.gameState.empires[0].relations >= 600)
		{
			button_text[1] = " 期 待 已 久 的 统 一 时 刻 到 了 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 他 们 不 准 备 同 意 这 样 的 协 议";
		}
		button_text[2] = " 承 认 彼 此 ， 结 束 敌 意 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 两 个 中 国";
		switch (result_num)
		{
		case 0:
			text = " 一 切 顺 其 自 然 。";
			break;
		case 1:
			text = " 今 天 ， 我 国 领 袖 率 领 代 表 团 对 台 北 进 行 了 历 史 性 的 访 问 ， 在 此 期 间 ， 经 过 闭 门 谈 判 后 ， 决 定 成 立 一 个 委 员 会 ， 制 定 台 湾 和 中 国 大 陆 逐 步 统 一 的 原 则 。 当 然 ， 外 国 投 资 者 将 保 留 他 们 的 所 有 权 利 ， 而 台 湾 省 将 获 得 广 泛 的 长 期 经 济 和 政 治 自 治 权 。 所 有 与 美 军 有 关 的 事 情 都 将 由 已 经 签 订 的 条 约 来 决 定 ， 然 后 由 联 合 政 府 决 定 美 军 是 否 继 续 留 在 台 湾 。 虽 然 所 有 这 些 都 还 只 是 纸 上 谈 兵 ， 需 要 在 广 泛 考 虑 共 同 利 益 的 基 础 上 制 定 出 来 ， 台 湾 回 归 中 国 的 时 间 还 没 有 确 定 ， 但 我 们 的 人 民 热 情 地 接 受 了 这 个 消 息 ， 边 境 控 制 被 大 大 削 弱 了 。 所 有 这 一 切 的 结 果 是 ， 自 由 主 义 思 想 更 容 易 从 台 湾 渗 透 到 我 们 中 间 ， 美 国 人 担 心 他 们 对 台 湾 的 影 响 被 削 弱 了 ， 但 我 们 的 人 民 非 常 高 兴 。";
			GlobalScript.inst.gameState.empires[0].relations -= 70;
			GlobalScript.inst.gameState.data[4] += 80;
			GlobalScript.inst.gameState.data[3] += 120;
			GlobalScript.inst.gameState.allcountries[38].proprc = true;
			GlobalScript.inst.gameState.allcountries[38].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[38].SubGosstroy = 5;
			GlobalScript.inst.gameState.data[64] = 2;
			GlobalScript.inst.gameState.allcountries[1].ILoveSuckCocks();
			break;
		case 2:
			text = " 今 天 ， 我 国 领 袖 率 领 代 表 团 对 台 北 进 行 了 历 史 性 的 访 问 ， 谈 判 双 方 决 定 相 互 承 认 对 方 。 从 现 在 起 ， 中 华 人 民 共 和 国 和 台 湾 共 和 国 （ 根 据 该 协 定 的 条 款 ， 中 华 民 国 改 名 为 台 湾 共 和 国 ） 将 作 为 两 个 独 立 的 国 家 存 在 。 它 也 结 束 了 多 年 来 关 于 领 土 和 合 法 政 府 的 争 端 ， 使 我 们 的 关 系 达 到 了 一 个 新 的 水 平 。 美 国 对 我 们 的 行 动 表 示 欢 迎 ， 并 提 供 了 大 量 的 财 政 援 助 以 支 持 我 们 的 政 策 。 然 而 ， 许 多 人 明 显 对 两 个 中 国 的 永 久 分 裂 感 到 不 满 。";
			GlobalScript.inst.gameState.data[8] += 70;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.data[3] -= 80;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.allcountries[38].Torg = true;
			GlobalScript.inst.gameState.allcountries[38].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[38].SubGosstroy = 5;
			GlobalScript.inst.gameState.data[64] = 1;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
