using EventsForDLC;
using UnityEngine;

public class Event464 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 团 结 起 来 ， 争 取 更 大 胜 利";
		text = " 主 席 同 志 ！ 在 布 鲁 塞 尔 的 前 欧 洲 共 同 体 办 公 处 中 ， 我 们 找 到 了 一 项 名 为 “ 申 根 协 定 ” 的 秘 密 协 定 ， 其 中 包 括 在 协 定 签 字 国 之 间 不 再 对 公 民 进 行 边 境 检 查 ； 外 国 人 一 旦 获 准 进 入 “ 协 议 领 土 ” 内 ， 即 可 在 协 定 签 字 国 领 土 上 自 由 通 行 ； 设 立 警 察 合 作 与 司 法 互 助 的 制 度 ， 建 立 统 一 电 脑 系 统 ， 建 立 有 关 各 类 非 法 活 动 分 子 情 况 的 共 用 档 案 库 。 我 们 现 在 的 科 技 水 平 足 够 发 达 ， 而 我 们 同 盟 内 的 国 家 也 足 够 多 ， 签 发 签 证 是 一 个 巨 大 的 问 题 。 这 个 方 案 足 够 大 胆 ， 但 或 许 会 有 很 好 的 成 效 。 不 过 定 夺 权 在 您 手 上 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.allcountries[1].okb)
		{
			button_text[0] = " 建 立 一 个 类 似 于 该 申 根 协 议 的 协 议 ， 只 适 用 于 我 们 军 事 联 盟 的 成 员";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 军 事 联 盟";
		}
		button_text[1] = " 为 我 们 所 有 联 盟 的 成 员 建 立 一 个 类 似 于 该 申 根 协 议 的 协 议";
		button_text[2] = " 我 们 可 以 稍 后 再 议";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 团 结 起 来 ， 争 取 更 大 胜 利";
		switch (result_num)
		{
		case 0:
		{
			text = " 我 们 与 军 事 联 盟 国 家 之 间 的 会 议 在 上 海 举 行 ， 结 束 时 签 署 了 所 谓 的 上 海 协 定 ， 这 意 味 着 创 建 一 个 我 们 联 盟 国 家 之 间 的 简 化 的 护 照 和 签 证 控 制 空 间 的 前 景 ， 并 完 全 排 斥 外 国 护 照 的 需 要 。 协 议 逐 渐 开 始 生 效 ， 人 民 满 意 了 ， 但 也 开 始 被 外 国 文 化 冲 昏 头 脑 ， 对 我 们 的 国 家 原 则 产 生 了 怀 疑 。 现 在 ， 罪 犯 和 持 不 同 政 见 者 更 容 易 逃 离 中 国 ， 走 私 者 也 更 容 易 把 他 们 的 货 物 走 私 到 我 们 这 里 。 但 我 们 的 盟 友 国 家 之 间 的 联 系 已 经 进 一 步 加 强 ， 旅 游 业 的 利 润 将 补 充 我 们 的 预 算 。";
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
			text = " 我 们 与 所 有 联 盟 国 家 之 间 的 会 议 在 上 海 举 行 ， 结 束 时 签 署 了 所 谓 的 上 海 协 定 ， 这 意 味 着 创 建 一 个 我 们 联 盟 国 家 之 间 的 简 化 的 护 照 和 签 证 控 制 空 间 的 前 景 ， 并 完 全 排 斥 外 国 护 照 的 需 要 。 协 议 逐 渐 开 始 生 效 ， 人 民 满 意 了 ， 但 也 开 始 被 外 国 文 化 冲 昏 头 脑 ， 对 我 们 的 国 家 原 则 产 生 了 怀 疑 。 现 在 ， 罪 犯 和 持 不 同 政 见 者 更 容 易 逃 离 中 国 ， 走 私 者 也 更 容 易 把 他 们 的 货 物 走 私 到 我 们 这 里 。 但 我 们 的 盟 友 国 家 之 间 的 联 系 已 经 进 一 步 加 强 ， 旅 游 业 的 利 润 将 补 充 我 们 的 预 算 。";
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
			text = " 既 然 除 了 我 们 的 情 报 人 员 没 人 知 道 这 件 事 ， 我 们 可 以 暂 且 搁 置 ， 日 后 再 讨 论";
			break;
		}
	}
}
