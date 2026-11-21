using EventsForDLC;
using UnityEngine;

public class Event64 : EventsSecond
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
		if (a.allcountries[30].Gosstroy == 1)
		{
			name = " 统 一 ， 解 放 ， 社 会 主 义 ！";
			text = " 殖 民 时 代 以 来 ， 阿 拉 伯 地 区 就 被 帝 国 主 义 列 强 和 封 建 主 义 当 权 者 瓜 分 ， 特 别 是 在 帝 国 主 义 的 “ 尺 规 作 图 ” 下 ， 阿 拉 伯 各 国 被 他 们 用 笔 直 的 国 境 线 人 为 分 割 开 来 。||过 去 ， 阿 拉 伯 民 族 资 产 阶 级 在 民 族 革 命 后 做 出 了 许 多 重 新 统 一 阿 拉 伯 的 尝 试 — — 阿 拉 伯 联 合 共 和 国 （1958-1961） 、 阿 拉 伯 合 众 国 （1958-1961） 、 阿 拉 伯 共 和 国 联 邦 （1972-1977） 、 阿 拉 伯 共 和 国 联 盟 （1972） 和 阿 拉 伯 伊 斯 兰 共 和 国 （1974） 等 。 随 着 复 兴 党 左 右 两 翼 的 分 裂 （ 叙 利 亚 支 部 和 伊 拉 克 支 部 的 分 裂 ） 和 第 三 次 中 东 战 争 的 惨 败 ， 在 阿 拉 伯 社 会 主 义 的 旗 帜 下 追 求 阿 拉 伯 民 族 解 放 和 统 一 的 道 路 已 经 逐 渐 走 向 破 产 ， 而 埃 及 和 利 比 亚 两 国 的 决 裂 更 是 为 这 一 道 路 敲 响 了 丧 钟 。 此 后 ， 以 乔 治 · 哈 巴 什 为 代 表 的 一 群 阿 拉 伯 民 族 主 义 者 逐 渐 激 进 化 ， 转 向 科 学 社 会 主 义 ， 在 马 列 主 义 的 旗 帜 下 进 行 追 求 阿 拉 伯 民 族 的 解 放 和 统 一 ， 掀 起 了 新 一 轮 阿 拉 伯 革 命 的 高 潮 。 如 今 ， 大 部 分 阿 拉 伯 国 家 的 反 共 社 会 民 族 主 义 政 权 都 已 倒 台 ， 被 真 正 的 科 学 社 会 主 义 政 权 取 而 代 之 ， 新 生 的 各 个 革 命 阿 拉 伯 国 家 意 识 到 ， 只 有 在 “ 统 一 ， 解 放 ， 社 会 主 义 ” 的 口 号 下 ， 互 助 和 共 建 革 命 的 社 会 主 义 ， 才 能 在 多 重 势 力 的 觊 觎 下 生 存 下 来 。 同 时 ， 基 于 意 识 形 态 和 现 实 需 要 ， 他 们 也 决 定 逐 渐 消 除 殖 民 者 强 加 在 阿 拉 伯 民 族 头 上 的 国 界 ， 在 阿 拉 伯 无 产 阶 级 的 团 结 下 联 合 起 来 。";
		}
		else
		{
			name = " 泛 阿 拉 伯 主 义";
			text = " 自 从 外 国 人 在 中 东 实 行 殖 民 统 治 以 来 ， 阿 拉 伯 统 治 者 和 知 识 分 子 就 一 直 在 考 虑 建 立 一 个 中 东 所 有 阿 拉 伯 人 的 联 合 国 。 它 反 映 在 由 叙 利 亚 和 埃 及 组 成 的 阿 拉 伯 联 合 共 和 国 ， 该 国 在1958 年 到1971 年 间 一 直 存 在 着 ， 但 是 ， 由 于 著 名 的 泛 阿 拉 伯 主 义 者 埃 及 总 统 纳 赛 尔 努 力 增 强 埃 及 在 联 合 共 和 国 中 的 权 力 ， 叙 利 亚 于1961 年 退 出 了 该 国 。 随 后 ， 在1971 年 ， 埃 及 、 叙 利 亚 和 利 比 亚 成 立 了 阿 拉 伯 共 和 国 联 邦 。 然 而 ， 参 与 国 之 间 存 在 矛 盾 ， 主 要 是 由 纳 赛 尔 之 后 的 萨 达 特 埃 及 开 始 实 行 的 自 由 亲 西 方 政 策 引 起 的 。 但 是 现 在 ， 当 萨 达 特 被 暗 杀 后 ， 在 埃 及 ， 老 总 统 纳 赛 尔 的 支 持 者 上 台 执 政 ， 多 亏 了 阿 拉 伯 共 和 国 联 邦 直 到 现 在 还 正 式 存 在 着 ， 合 并 其 他 阿 拉 伯 国 家 的 想 法 重 新 占 据 了 统 治 圈 的 头 脑 。 此 外 ，7 月30 日 ， 以 色 列 宣 布 耶 路 撒 冷 为 “ 以 色 列 永 恒 不 可 分 割 的 首 都 ” ， 这 引 起 了 阿 拉 伯 世 界 的 不 满 浪 潮 ， 这 提 供 了 另 一 个 为 了 联 合 起 来 对 付 共 同 的 敌 人 的 正 当 理 由 。 在 对 埃 及 给 予 了 一 些 物 质 援 助 并 加 大 了 清 除 对 这 一 发 展 不 满 的 人 的 力 度 之 后 ， 我 们 可 以 恢 复 阿 拉 伯 联 合 共 和 国 ， 这 将 极 大 改 变 中 东 地 区 的 权 力 平 衡 ， 并 得 到 一 个 有 价 值 的 盟 友 。 当 然 ， 他 们 会 听 我 们 的 话 的 …";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (a.allcountries[30].Gosstroy == 1)
		{
			kolvo_variant = 1;
			button_text[0] = " 统 一 ， 解 放 ， 社 会 主 义 ！ 彻 底 走 向 独 立 和 革 命 的 阿 拉 伯 民 族 万 岁 ！";
			return;
		}
		kolvo_variant = 2;
		button_text[0] = " 阿 拉 伯 联 合 ？ 不 值 得 我 们 为 此 做 无 用 功";
		if (GlobalScript.inst.gameState.data[9] >= 50 && (!GlobalScript.inst.gameState.allcountries[30].prosov || GlobalScript.inst.gameState.relres))
		{
			button_text[1] = " 协 助 重 建 阿 拉 伯 联 合 共 和 国 （ 需 要7 百 万 元 预 算 ，5 特 工 网 络 ）";
		}
		else if (GlobalScript.inst.gameState.data[9] < 50)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 需 要 5 特 工 网 络 ...";
		}
		else if (GlobalScript.inst.gameState.allcountries[30].prosov && !GlobalScript.inst.gameState.relres)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 还 未 恢 复 与 苏 联 的 关 系 ...";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 他 们 自 己 都 不 同 意 重 走 纳 赛 尔 主 义 之 路 ， 我 们 又 能 帮 到 啥 ？";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		if (a.allcountries[30].Gosstroy == 1)
		{
			name = " 统 一 ， 解 放 ， 社 会 主 义 ！";
			text = " 各 个 革 命 的 社 会 主 义 阿 拉 伯 国 家 举 行 了 一 场 历 史 性 会 议 ， 他 们 决 定 成 立 一 个 吸 收 了 此 前 各 个 泛 阿 拉 伯 项 目 的 经 验 和 教 训 的 ， 参 考 欧 洲 经 济 共 同 体 、 经 济 互 助 委 员 会 以 及 共 产 党 和 工 人 党 情 报 局 的 制 度 的 邦 联 式 的 阿 拉 伯 革 命 社 会 主 义 共 和 国 联 盟 ， 联 盟 具 有 单 一 货 币 、 军 队 ， 联 合 协 商 的 外 交 政 策 ， 以 及 经 济 政 治 一 体 化 的 前 景 。 新 国 家 宣 布 了 对 马 克 思 列 宁 主 义 原 则 的 忠 诚 和 继 续 组 建 所 有 阿 拉 伯 人 的 单 一 革 命 国 家 的 需 要 ， 这 刺 激 了 以 色 列 ， 以 色 列 向 美 国 要 求 额 外 的 军 事 援 助 。 苏 联 对 此 较 为 忌 惮 — — 这 些 组 成 国 推 翻 了 此 前 他 们 支 持 的 社 会 民 族 主 义 政 权 ， 但 又 打 着 共 产 主 义 旗 号 ， 这 无 疑 是 在 打 苏 联 的 脸 ； 美 国 也 对 中 东 出 现 了 一 个 能 挑 战 他 们 霸 权 的 共 产 主 义 对 手 十 分 愤 怒 。";
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.data[57] += 30;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[143] += 5;
			GlobalScript.inst.gameState.allcountries[30].oar = true;
			GlobalScript.inst.gameState.allcountries[13].oar = true;
			GlobalScript.inst.gameState.allcountries[14].oar = true;
			GlobalScript.inst.gameState.allcountries[35].oar = true;
			GlobalScript.inst.gameState.modifies[46].active = true;
			GlobalScript.inst.old_modify_texts[46] = " 阿 拉 伯 革 命 社 会 主 义 共 和 国 联 盟";
			for (int i = 1; i < GlobalScript.inst.gameState.allcountries.Length; i++)
			{
				if ((i == 54 || i == 55 || i == 18 || i == 40 || i == 104 || i == 93) && a.allcountries[i].Gosstroy == 1)
				{
					a.allcountries[i].oar = true;
				}
			}
			GlobalScript.inst.gameState.OAR = true;
			GlobalScript.inst.gameState.empires[0].power -= 20;
			party_change[2] = 0.24f;
			party_change[3] = 0.24f;
			if (GlobalScript.inst.gameState.modifies[59].active)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (GlobalScript.inst.gameState.allcountries[1].okb)
				{
					for (int j = 0; j < GlobalScript.inst.gameState.allcountries.Length; j++)
					{
						if (GlobalScript.inst.gameState.allcountries[j].okb)
						{
							num++;
							if (((j > 53 && j < 69) || (j > 105 && j < 109) || (j > 111 && j < 134) || j == 41 || j == 42 || j == 52 || j == 99 || j == 100) && j != 55 && j != 54 && j != 128 && GlobalScript.inst.gameState.allcountries[j].proprc && (GlobalScript.inst.gameState.allcountries[j].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[j].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								num3++;
							}
						}
						if (GlobalScript.inst.gameState.allcountries[j].oar)
						{
							num2++;
						}
					}
					GlobalScript.inst.old_modify_desc[59] = string.Format("{0}{1}{2}", new object[3]
					{
						GlobalScript.inst.gameState.allcountries[1].okb ? (" 集 体 安 全 联 盟 ：|军 事 力 量+" + num * 3 / 10 + "." + Mathf.Abs(num * 3 % 10) + " ；特 工 网 络+" + num * 2 / 10 + "." + Mathf.Abs(num * 2 % 10) + " ；干 涉 点 数+" + num / 10 + "." + Mathf.Abs(num % 10)) : null,
						(GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0) ? (" |非 洲 联 盟 : |军 事 力 量 +" + num3 * 3 / 10 + "." + Mathf.Abs(num3 * 3 % 10) + " ；特 工 网 络+" + num3 * 2 / 10 + "." + Mathf.Abs(num3 * 2 % 10) + " ；干 涉 点 数+" + num3 / 10 + "." + Mathf.Abs(num3 % 10)) : null,
						(!GlobalScript.inst.gameState.allcountries[30].oar) ? null : ((GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1) ? (" |阿 拉 伯 革 命 同 盟 :| 军 事 力 量 +" + num2 * 3 / 10 + "." + Mathf.Abs(num2 * 3 % 10) + " ；特 工 网 络+" + num2 * 2 / 10 + "." + Mathf.Abs(num2 * 2 % 10) + " ；干 涉 点 数+" + num2 / 10 + "." + Mathf.Abs(num2 % 10)) : (" |阿 拉 伯 联 合 共 和 国 :| 军 事 力 量 +" + num2 * 3 / 10 + "." + Mathf.Abs(num2 * 3 % 10) + " ；特 工 网 络+" + num2 * 2 / 10 + "." + Mathf.Abs(num2 * 2 % 10) + " ；干 涉 点 数+" + num2 / 10 + "." + Mathf.Abs(num2 % 10)))
					});
				}
			}
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power += 120;
					politic.loyality += 100;
				}
				else if (politic.traits[0] == 20)
				{
					politic.power += 120;
					politic.loyality += 100;
				}
			}
			return;
		}
		name = " 泛 阿 拉 伯 主 义";
		switch (result_num)
		{
		case 0:
			text = " 什 么 都 没 有 发 生 。 阿 拉 伯 国 家 仍 然 很 分 散 ， 这 给 亲 美 的 以 色 列 带 来 了 优 势 。";
			GlobalScript.inst.gameState.empires[0].power += 10;
			break;
		case 1:
		{
			text = " 多 亏 了 我 们 情 报 部 门 的 干 预 ， 大 多 数 联 盟 的 反 对 者 都 被 瓦 解 了 ， 我 们 调 节 阿 拉 伯 国 家 统 一 的 意 愿 ， 以 及 发 展 联 合 国 家 的 免 费 援 助 最 终 使 得 谈 判 达 成 协 议 。8 月 ， 埃 及 ， 利 比 亚 ， 和 叙 利 亚 在 开 罗 举 行 了 历 史 性 会 议 ， 决 定 成 立 邦 联 式 的 阿 拉 伯 联 合 共 和 国 ， 国 家 具 有 单 一 货 币 ， 军 队 ， 联 合 解 决 外 交 政 策 ， 以 及 经 济 政 治 一 体 化 的 前 景 。 新 国 家 宣 布 了 对 阿 拉 伯 社 会 主 义 原 则 的 忠 诚 ， 和 继 续 组 建 所 有 阿 拉 伯 人 的 单 一 国 家 的 需 要 ， 这 刺 激 了 以 色 列 ， 以 色 列 向 美 国 要 求 额 外 的 军 事 援 助 。 苏 联 欢 迎 阿 拉 伯 联 合 共 和 国 的 创 立 ， 但 美 国 对 中 东 出 现 了 一 个 挑 战 他 们 霸 权 的 强 大 对 手 并 不 开 心 。";
			GlobalScript.inst.gameState.data[8] -= 70;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.empires[1].relations += 80;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.data[57] -= 30;
			GlobalScript.inst.gameState.empires[0].relations -= 70;
			GlobalScript.inst.gameState.empires[1].power += 10;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[143] += 5;
			GlobalScript.inst.gameState.allcountries[30].oar = true;
			GlobalScript.inst.gameState.OAR = true;
			GlobalScript.inst.gameState.empires[0].power -= 10;
			party_change[2] = 0.24f;
			party_change[3] = 0.24f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 1)
				{
					politic2.power += 120;
					politic2.loyality += 100;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.power += 120;
					politic2.loyality += 100;
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
