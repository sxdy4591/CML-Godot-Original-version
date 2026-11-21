using EventsForDLC;
using UnityEngine;

public class Event58 : EventsSecond
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
		name = " 伊 朗 革 命 ： 终 局";
		text = " 过 去 一 年 内 ， 伊 朗 经 历 了 一 番 大 变 故 。 各 路 反 对 派 纷 纷 进 军 勤 王 ， 一 次 又 一 次 的 罢 工 冲 蚀 着 沙 阿 最 后 的 一 丝 威 严 。 而 大 使 馆 的 官 员 已 经 拍 来 了 新 的 电 报 。|";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " — — 说 来 听 听 吧 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 伊 朗 革 命 ： 终 局";
		if (result_num == 0)
		{
			if (GlobalScript.inst.gameState.data[42] > GlobalScript.inst.gameState.data[43] && GlobalScript.inst.gameState.data[42] > GlobalScript.inst.gameState.data[44])
			{
				text = " 伊 朗 的 革 命 者 们 达 成 了 自 己 的 目 标 ， 沙 阿 和 他 的 家 人 逃 离 了 这 个 国 家 ， 把 权 力 移 交 给 来 自 温 和 反 对 派 的 首 相 沙 普 尔 •   巴 赫 蒂 亚 。 在 工 人 和 军 事 部 队 的 支 持 下 ， 伊 朗 共 和 国 被 成 立 了 。 霍 梅 尼 在 欢 呼 的 人 群 中 ， 被 法 国 航 空 的 一 位 机 长 搀 扶 着 缓 缓 走 下 飞 机 。 但 于 此 同 时 ， 各 个 反 对 派 组 织 的 矛 盾 随 着 沙 阿 的 倒 台 一 并 浮 现 。 在 最 近 的 制 宪 议 会 中 ， 伊 斯 兰 党 以 近 乎 垄 断 的 姿 态 占 据 了 多 数 。 我 们 希 望 伊 朗 的 事 态 会 向 好 的 一 面 发 展 。";
				GlobalScript.inst.gameState.empires[0].power -= 10;
				GlobalScript.inst.gameState.allcountries[8].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 8;
				GlobalScript.inst.gameState.allcountries[8].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[8].isSENTO = false;
				GlobalScript.inst.gameState.allcountries[8].isASEAN = false;
				if (GlobalScript.inst.gameState.allcountries[8].dev == 1)
				{
					GlobalScript.inst.gameState.data[143] += 10;
				}
				GlobalScript.inst.gameState.allcountries[8].Torg = true;
				GlobalScript.inst.gameState.data[45] = 500;
			}
			else if (GlobalScript.inst.gameState.data[43] > GlobalScript.inst.gameState.data[42] && GlobalScript.inst.gameState.data[43] > GlobalScript.inst.gameState.data[44])
			{
				text = " 伊 朗 的 革 命 者 们 没 能 达 成 自 己 的 目 标 ， 沙 阿 继 续 执 政 ， 而 他 的 第 一 步 ， 就 是 针 对 全 国 各 大 反 对 派 的 清 洗 。 霍 梅 尼 重 新 选 择 回 到 在 巴 黎 的 故 居 ， 继 续 制 作 呼 吁 推 翻 沙 阿 的 录 音 带 。 出 于 对 第 二 次 革 命 的 恐 慌 ， 伊 朗 宣 布 加 强 同 美 国 的 合 作 。 希 望 伊 朗 的 一 切 最 终 能 向 更 好 的 一 面 发 展 。";
				GlobalScript.inst.gameState.empires[0].power += 10;
				if (GlobalScript.inst.gameState.allcountries[8].dev == 0)
				{
					GlobalScript.inst.gameState.allcountries[8].Torg = true;
				}
				GlobalScript.inst.gameState.data[143] -= 7;
			}
			else if (GlobalScript.inst.gameState.data[44] > GlobalScript.inst.gameState.data[42] && GlobalScript.inst.gameState.data[44] > GlobalScript.inst.gameState.data[43])
			{
				text = " 他 们 成 功 地 实 现 了 他 们 的 目 标 ： 一 月 份 ， 沙 阿 和 他 的 家 人 逃 离 了 这 个 国 家 ， 把 权 力 移 交 给 来 自 温 和 反 对 派 的 首 相 沙 普 尔 · 巴 赫 蒂 亚 ， 后 者 开 始 起 草 新 宪 法 ， 并 应 拒 绝 建 立 “ 国 家 团 结 ” 政 府 的 抗 议 者 的 要 求 ， 举 行 了 自 由 选 举 。 民 主 派 联 盟 伊 朗 国 民 阵 线 赢 得 了 选 举 ， 随 后 成 功 地 压 制 了 由 霍 梅 尼 领 导 的 伊 斯 兰 激 进 分 子 的 不 满 ， 并 开 始 对 伊 斯 兰 主 义 者 和 对 这 一 结 果 不 满 的 激 进 左 派 进 行 严 厉 的 清 洗 。 新 成 立 的 政 府 宣 布 忠 于 伊 斯 兰 教 和 民 主 原 则 ， 以 西 欧 和 凯 末 尔 主 义 土 耳 其 模 式 发 展 国 家 为 目 标 ， 同 时 奉 行 多 方 位 的 外 交 政 策 。";
				GlobalScript.inst.gameState.allcountries[8].Gosstroy = 3;
				GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 5;
				GlobalScript.inst.gameState.allcountries[8].Vyshi = false;
				if (GlobalScript.inst.gameState.allcountries[8].dev == 2)
				{
					GlobalScript.inst.gameState.allcountries[8].Torg = true;
				}
				GlobalScript.inst.gameState.data[143] -= 5;
				GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
			}
			GlobalScript.inst.gameState.iranrev = false;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
