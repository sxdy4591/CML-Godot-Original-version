using EventsForDLC;
using UnityEngine;

public class Event106 : EventsSecond
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
		name = " 民 主 国 际";
		text = " 在 安 盟 反 共 反 叛 运 动 的 主 要 基 地 安 哥 拉 城 市 贾 姆 巴 ， 正 在 筹 备 一 次 会 议 ， 与 会 者 希 望 在 会 议 结 果 之 后 建 立 所 谓 的 会 议 。 “ 民 主 国 际 ”- 来 自 不 同 国 家 的 反 共 叛 军 联 盟 。 除 安 盟 外 ， 阿 富 汗 圣 战 者 、 尼 加 拉 瓜 反 对 派 和 老 挝 苗 族 的 代 表 也 出 席 了 会 议 ， 银 行 家 刘 易 斯 · 勒 曼 （ 活 动 金 融 家 ） 、 著 名 说 客 和 电 影 制 片 人 杰 克 · 阿 布 拉 莫 夫 （ 活 动 发 起 人 ） 和 奥 利 弗 · 诺 斯 中 校 等 美 国 保 守 派 人 士 也 积 极 参 加 了 会 议 。 尽 管 即 将 成 立 的 同 盟 会 具 有 鲜 明 的 反 苏 倾 向 ， 但 它 也 与 我 们 的 利 益 区 相 交 叉 ， 并 可 能 在 未 来 造 成 问 题 。 另 一 方 面 ， 我 们 也 可 以 在 与 苏 联 的 地 缘 政 治 斗 争 中 对 其 加 以 利 用 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 我 们 不 关 心 此 事";
		if (GlobalScript.inst.gameState.data[9] >= 100)
		{
			button_text[1] = " 安 排 一 次 恐 怖 袭 击 并 扰 乱 会 议";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
		}
		button_text[2] = " 支 持 民 主 国 际 的 形 成";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 民 主 国 际";
		switch (result_num)
		{
		case 0:
			text = " 结 果 ， 民 主 国 际 成 立 了 。 很 难 说 这 是 否 有 助 于 反 共 分 子 的 行 动 ， 但 这 一 事 件 意 义 重 大 ， 有 助 于 美 国 影 响 力 的 增 长 ， 所 以 美 国 积 极 支 持 这 一 行 动 。";
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.empires[1].power -= 10;
			break;
		case 1:
			text = " 我 们 设 法 在 安 哥 拉 和 边 境 国 家 的 特 工 人 员 之 间 紧 急 建 立 合 作 关 系 ， 并 秘 密 说 服 苏 联 和 亲 苏 的 安 哥 拉 当 局 进 行 合 作 ， 我 们 得 以 在 贾 巴 组 织 了 一 系 列 恐 怖 袭 击 。 不 幸 的 是 ， 安 盟 领 导 人 乔 纳 斯 · 萨 文 比 和 美 国 傀 儡 师 没 有 受 伤 ， 但 我 们 设 法 消 除 了 尼 加 拉 瓜 叛 军 的 非 正 式 领 导 人 阿 道 夫 · 卡 莱 罗 ， 著 名 的 穆 斯 林 圣 战 者 代 表 阿 卜 杜 勒 · 拉 希 姆 · 瓦 尔 达 克 和 苗 族 运 动 领 袖 帕 考 赫 。 除 了 联 合 阵 线 的 垮 台 ， 许 多 世 界 反 共 知 名 人 士 的 去 世 严 重 打 击 了 美 国 的 影 响 力 ， 也 帮 助 了 苏 联 。 这 就 是 为 什 么 所 有 的 主 要 指 控 都 是 针 对 他 的 ， 然 而 ， 美 国 人 怀 疑 某 些 事 情 上 我 们 的 参 与 。";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.empires[1].power += 20;
			GlobalScript.inst.gameState.empires[0].power -= 30;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[1].relations += 200;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			break;
		case 2:
		{
			text = " 我 们 支 持 民 主 国 际 的 形 成 ， 并 支 持 它 随 时 准 备 在 世 界 各 地 抗 击 苏 联 的 侵 略 。 参 与 者 对 此 有 不 同 的 看 法 ， 但 总 体 上 做 出 了 积 极 的 反 应 ， 从 中 受 益 最 多 的 美 国 人 也 是 如 此 。 我 们 的 利 益 还 不 清 楚 ， 但 苏 联 的 影 响 力 肯 定 已 经 下 降 了 。";
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.empires[1].relations -= 120;
			GlobalScript.inst.gameState.empires[0].power += 30;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			Country[] allcountries = GlobalScript.inst.gameState.allcountries;
			foreach (Country country in allcountries)
			{
				if (country.okb || country.econ)
				{
					country.soc_stab += 50;
					if (country.sovalliance)
					{
						country.sovalliance = false;
						GlobalScript.inst.gameState.data[9] -= 30;
						GlobalScript.inst.gameState.data[8] -= 50;
					}
				}
				else if (country.dev > 100 && country.stab > 100 && country.prosov)
				{
					country.stab -= 150;
					country.dev -= 50;
				}
				else if ((country.dev > 50 || country.stab > 50) && country.Vyshi)
				{
					country.stab += 150;
					country.dev -= 100;
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
