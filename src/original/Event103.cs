using EventsForDLC;
using UnityEngine;

public class Event103 : EventsSecond
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
		if (GlobalScript.inst.gameState.allcountries[0].isEU)
		{
			name = " 申 根 协 定";
			text = " 最 近 ，7 月14 日 ，5 个 欧 洲 国 家 （ 卢 森 堡 、 荷 兰 、 比 利 时 、 法 国 和 联 邦 德 国 ） 在 卢 森 堡 签 署 了 《 申 根 协 定 》 ， 这 意 味 着 简 化 它 们 之 间 边 界 的 护 照 和 签 证 管 制 ， 并 概 述 了 几 乎 完 全 拒 绝 护 照 管 制 的 行 动 。 申 根 协 定 是 欧 洲 经 济 共 同 体 长 期 以 来 实 行 的 免 签 证 制 度 的 延 续 ， 它 促 使 你 们 的 党 员 认 为 我 们 也 有 自 己 的 经 济 联 盟 。 建 立 单 一 的 签 证 空 间 、 联 盟 国 家 之 间 的 自 由 流 动 和 简 化 边 境 管 制 ， 应 该 有 利 于 我 们 国 家 之 间 的 文 化 交 流 、 旅 游 业 的 发 展 ， 人 们 会 喜 欢 它 的 。 问 题 是 ， 这 也 会 简 化 持 不 同 政 见 者 和 罪 犯 的 生 活 ， 事 实 上 ， 不 知 道 我 们 的 公 民 会 从 外 国 得 到 什 么 样 的 想 法 … …";
		}
		else if (!GlobalScript.inst.gameState.allcountries[0].isEU)
		{
			name = " 马 德 里 协 定";
			text = " 最 近 ，7 月14 日 ，数 个 欧 洲 国 家 在 西 班 牙 签 署 了 《 马 德 里 协 定 》 ， 这 意 味 着 简 化 它 们 之 间 边 界 的 护 照 和 签 证 管 制 ， 并 概 述 了 几 乎 完 全 拒 绝 护 照 管 制 的 行 动 。 马 德 里 协 定 是 社 会 主 义 联 盟 长 期 以 来 实 行 的 免 签 证 制 度 的 延 续 ， 它 促 使 你 们 的 党 员 认 为 我 们 也 有 自 己 的 经 济 联 盟 。 建 立 单 一 的 签 证 空 间 、 联 盟 国 家 之 间 的 自 由 流 动 和 简 化 边 境 管 制 ， 应 该 有 利 于 我 们 国 家 之 间 的 文 化 交 流 、 旅 游 业 的 发 展 ， 人 们 会 喜 欢 它 的 。 问 题 是 ， 这 也 会 简 化 持 不 同 政 见 者 和 罪 犯 的 生 活 ， 事 实 上 ， 不 知 道 我 们 的 公 民 会 从 外 国 得 到 什 么 样 的 想 法 … …";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.allcountries[1].okb && GlobalScript.inst.gameState.allcountries[0].isEU)
		{
			button_text[0] = " 建 立 一 个 类 似 于 申 根 协 议 的 协 议 ， 只 适 用 于 我 们 军 事 联 盟 的 成 员";
		}
		else if (GlobalScript.inst.gameState.allcountries[1].okb && !GlobalScript.inst.gameState.allcountries[0].isEU)
		{
			button_text[0] = " 建 立 一 个 类 似 于 马 德 里 协 议 的 协 议 ， 只 适 用 于 我 们 军 事 联 盟 的 成 员";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 军 事 联 盟";
		}
		if (GlobalScript.inst.gameState.allcountries[0].isEU)
		{
			button_text[1] = " 为 我 们 所 有 联 盟 的 成 员 建 立 一 个 类 似 于 申 根 协 议 的 协 议";
		}
		else
		{
			button_text[1] = " 为 我 们 所 有 联 盟 的 成 员 建 立 一 个 类 似 于 马 德 里 协 议 的 协 议";
		}
		button_text[2] = " 什 么 都 不 做";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 申 根 协 定";
		switch (result_num)
		{
		case 0:
		{
			text = " 我 们 联 盟 国 家 之 间 的 会 议 在 上 海 举 行 ， 结 束 时 签 署 了 所 谓 的 上 海 协 定 ， 这 意 味 着 创 建 一 个 我 们 联 盟 国 家 之 间 的 简 化 的 护 照 和 签 证 控 制 空 间 的 前 景 ， 并 完 全 排 斥 外 国 护 照 的 需 要 。 协 议 逐 渐 开 始 生 效 ， 人 民 满 意 了 ， 但 也 开 始 被 外 国 文 化 冲 昏 头 脑 ， 对 我 们 的 国 家 原 则 产 生 了 怀 疑 。 现 在 ， 罪 犯 和 持 不 同 政 见 者 更 容 易 逃 离 中 国 ， 走 私 者 也 更 容 易 把 他 们 的 货 物 走 私 到 我 们 这 里 。 但 我 们 的 盟 友 国 家 之 间 的 联 系 已 经 进 一 步 加 强 ， 旅 游 业 的 利 润 将 补 充 我 们 的 预 算 。";
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[26] += 30;
			GlobalScript.inst.gameState.data[8] += 30;
			Country[] allcountries = GlobalScript.inst.gameState.allcountries;
			foreach (Country country2 in allcountries)
			{
				if (country2.okb)
				{
					country2.soc_stab += 200;
					GlobalScript.inst.gameState.data[8] -= 5;
					if (!country2.proprc && !country2.sovalliance && !country2.usalliance)
					{
						country2.proprc = true;
						GlobalScript.inst.gameState.data[8] -= 20;
					}
					else if (!country2.proprc && (country2.sovalliance || country2.usalliance))
					{
						country2.sovalliance = false;
						country2.usalliance = false;
						GlobalScript.inst.gameState.data[8] -= 30;
					}
				}
			}
			break;
		}
		case 1:
		{
			text = " 我 们 联 盟 国 家 之 间 的 会 议 在 上 海 举 行 ， 结 束 时 签 署 了 所 谓 的 上 海 协 定 ， 这 意 味 着 创 建 一 个 我 们 联 盟 国 家 之 间 的 简 化 的 护 照 和 签 证 控 制 空 间 的 前 景 ， 并 完 全 排 斥 外 国 护 照 的 需 要 。 协 议 逐 渐 开 始 生 效 ， 人 民 满 意 了 ， 但 也 开 始 被 外 国 文 化 冲 昏 头 脑 ， 对 我 们 的 国 家 原 则 产 生 了 怀 疑 。 现 在 ， 罪 犯 和 持 不 同 政 见 者 更 容 易 逃 离 中 国 ， 走 私 者 也 更 容 易 把 他 们 的 货 物 走 私 到 我 们 这 里 。 但 我 们 的 盟 友 国 家 之 间 的 联 系 已 经 进 一 步 加 强 ， 旅 游 业 的 利 润 将 补 充 我 们 的 预 算 。";
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[26] += 30;
			GlobalScript.inst.gameState.data[8] += 30;
			Country[] allcountries = GlobalScript.inst.gameState.allcountries;
			foreach (Country country in allcountries)
			{
				if (country.okb || country.econ)
				{
					country.soc_stab += 200;
					GlobalScript.inst.gameState.data[8] -= 5;
					if (!country.proprc && !country.sovalliance && !country.usalliance)
					{
						country.proprc = true;
						GlobalScript.inst.gameState.data[8] -= 20;
					}
					else if (!country.proprc && (country.sovalliance || country.usalliance))
					{
						country.sovalliance = false;
						country.usalliance = false;
						GlobalScript.inst.gameState.data[8] -= 30;
					}
				}
			}
			break;
		}
		case 2:
			text = " 什 么 都 没 发 生";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
