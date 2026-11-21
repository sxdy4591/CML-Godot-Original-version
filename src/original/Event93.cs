using EventsForDLC;
using UnityEngine;

public class Event93 : EventsSecond
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
		name = " 民 主 的 故 乡 — — 第 一 幕";
		text = " 希 腊 仍 在 从1974 年 被 推 翻 的 军 政 府 的 影 响 中 恢 复 过 来 ， 议 会 选 举 已 经 提 上 日 程 。 在 右 翼 方 面 ， 自 由 保 守 主 义 的 新 民 主 党 在 上 届 议 会 中 占 有 最 多 的 席 位 ， 组 成 了 第 一 届 后 上 校 政 权 的 民 主 政 府 。 与 此 同 时 ， 希 腊 社 会 上 的 左 翼 支 持 度 正 在 上 升 ， 民 主 社 会 主 义 的 泛 希 腊 社 会 主 义 运 动 （ P A S O K ） 和 希 腊 共 产 党 等 左 翼 政 党 也 有 望 在 此 次 大 选 中 获 得 更 多 席 位 ， 但 其 中 还 没 有 任 何 一 个 左 翼 政 党 能 单 独 与 新 民 主 党 抗 衡 。 在 加 入 北 约 和 欧 共 体 的 问 题 上 ， 左 翼 与 右 翼 也 存 在 较 大 分 歧 。 右 翼 希 望 重 新 加 入 北 约 （ 该 国 在 1 9 7 4 年 因 为 土 耳 其 入 侵 塞 浦 路 斯 而 退 盟 ） 并 进 入 欧 共 体 ， 泛 希 腊 社 会 主 义 运 动 和 希 腊 共 产 党 则 持 反 对 态 度 。 选 举 的 结 果 会 严 重 影 响 该 国 的 局 势 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[9] >= 40)
		{
			button_text[0] = " 帮 助 组 建 左 翼 联 盟";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 足 够 的 力 量";
		}
		if (GlobalScript.inst.gameState.data[9] >= 40)
		{
			button_text[1] = " 支 持 新 民 主 党";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 足 够 的 力 量";
		}
		button_text[2] = " 保 持 距 离";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 民 主 的 故 乡 — — 第 一 幕";
		switch (result_num)
		{
		case 0:
			text = " 我 们 的 特 勤 部 门 帮 助 泛 希 腊 社 会 主 义 运 动 、 希 腊 共 产 党 和 希 腊 共 产 党 （ 国 内 派 ） 等 左 翼 政 党 开 展 竞 选 活 动 ， 并 且 积 极 地 阻 碍 新 民 主 党 的 竞 选 活 动 。 他 们 成 功 组 建 左 派 联 盟 ， 包 括 泛 希 腊 社 会 主 义 运 动 、 希 腊 共 产 党 和 其 他 左 翼 政 党 。 最 终 ， 左 派 联 盟 赢 得 了 大 选 ， 组 建 了 希 腊 历 史 上 第 一 个 社 会 主 义 政 府 。 在 我 们 和 苏 联 的 支 持 下 ， 希 腊 完 成 了 正 式 退 出 北 约 的 程 序 ， 加 入 欧 共 体 的 进 程 也 停 止 了 。 新 政 府 承 认 了 民 族 抵 抗 运 动 和 本 都 希 腊 人 的 种 族 灭 绝 。 同 时 ， 废 除 了 希 腊 宪 兵 队 和 城 市 警 察 ， 将 他 们 合 并 成 了 希 腊 警 察 。";
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.allcountries[45].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[45].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[45].isNATO = false;
			GlobalScript.inst.gameState.allcountries[45].Torg = true;
			GlobalScript.inst.gameState.allcountries[87].spec -= 5;
			GlobalScript.inst.gameState.allcountries[45].cw = true;
			GlobalScript.inst.gameState.empires[0].power -= 50;
			break;
		case 1:
			text = " 我 们 的 特 勤 部 门 帮 助 新 民 主 党 开 展 竞 选 活 动 ， 并 且 积 极 地 阻 碍 泛 希 腊 社 会 主 义 运 动 的 竞 选 活 动 。 新 民 主 党 成 功 与 一 些 小 型 右 翼 政 党 组 建 联 盟 ， 他 们 一 起 走 向 了 胜 利 。 新 政 府 希 望 开 展 进 一 步 的 经 济 改 革 ， 意 在 确 保 希 腊 欧 共 体 成 员 的 资 格 ， 以 及 恢 复 该 国 在 北 约 中 的 活 动 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[0].relations += 80;
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.allcountries[87].spec += 5;
			break;
		case 2:
			text = " 结 果 ， 新 民 主 党 失 去 了 4 9 个 席 位 ， 以 微 弱 优 势 赢 得 了 选 举 ； 泛 希 腊 社 会 主 义 运 动 新 增 8 1 个 席 位 ， 成 为 了 议 会 第 二 大 党 。 新 政 府 打 算 进 行 进 一 步 的 经 济 改 革 ， 以 确 保 希 腊 加 入 欧 共 体 ， 并 恢 复 该 国 在 北 约 的 活 动 。";
			GlobalScript.inst.gameState.empires[0].power += 20;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
