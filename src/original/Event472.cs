using EventsForDLC;
using UnityEngine;

public class Event472 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 巨 熊 冬 眠";
		text = " 新 任 苏 联 领 导 人 米 哈 伊 尔 · 戈 尔 巴 乔 夫 上 任 之 初 ， 便 遭 遇 来 自 中 国 的 巨 大 压 力 ： 在 中 国 的 干 涉 下 ， 罗 马 尼 亚 、 波 兰 、 匈 牙 利 、 保 加 利 亚 纷 纷 选 择 离 开 经 互 会 和 华 沙 条 约 。 而 最 终 ， 他 连 莫 斯 科 在 东 欧 地 区 最 忠 诚 的 盟 友 也 未 能 保 住 ： 随 着 ";
		if (a.allcountries[17].dev == 1)
		{
			text += " 确 认 新 国 家 的 完 全 中 立 地 位 的 德 国 统 一 计 划 的 通 过 ， 民 主 德 国 就 此 在 政 治 版 图 上 消 失 。";
		}
		else if (a.allcountries[17].dev == 2)
		{
			text += " 甚 至 没 有 确 认 新 国 家 的 中 立 地 位 的 德 国 统 一 计 划 的 通 过 ， 民 主 德 国 就 此 在 政 治 版 图 上 消 失 。 ";
		}
		else if (a.allcountries[17].dev == 3 && !a.allcountries[16].prosov)
		{
			text += " 早 已 选 择 “ 背 叛 ” 的 民 主 德 国 主 导 统 一 计 划 的 通 过 ， 两 个 德 国 对 立 的 局 面 就 此 结 束 。 ";
		}
		text += "||因 此 ， 华 沙 条 约 组 织 本 身 的 存 在 都 已 经 成 为 了 问 题 。 在 1 9 8 5 年 ， 原 本 应 当 被 续 签 的 ， 延 续 3 0 余 年 的 《 友 好 合 作 互 助 条 约 》 被 修 订 ； 原 本 在 筹 划 的 相 关 庆 祝 活 动 也 被 取 消 。 戈 尔 巴 乔 夫 不 得 不 表 示 ， 这 只 是 苏 联 与 美 国 同 中 国 和 解 的 “ 善 意 姿 态 ” ， 但 所 有 人 都 知 道 ， 莫 斯 科 真 正 的 盟 友 只 剩 下 与 苏 维 埃 乌 克 兰 有 些 微 接 壤 的 捷 克 斯 洛 伐 克 。|| 而 在 美 国 也 解 散 北 约 的 前 提 下 ， 我 们 似 乎 可 以 说 ， 持 续 3 0 年 的 冷 战 就 此 结 束 了 ......";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 胜 利 者 只 有 一 个 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 巨 熊 冬 眠";
		a.empires[1].leaders[6].support--;
		if (result_num != 0)
		{
			return;
		}
		text = " 戈 尔 巴 乔 夫 的 “ 姿 态 ” ， 被 苏 联 共 产 党 内 的 保 守 派 政 治 家 给 视 为 对 伟 大 卫 国 战 争 时 期 成 就 的 背 叛 与 亵 渎 。 事 实 上 ， 正 是 这 一 场 大 战 ， 直 接 导 致 了 世 界 社 会 主 义 阵 营 的 建 立 。 然 而 ， 现 在 还 没 有 人 谈 论 废 除 经 济 互 助 委 员 会 的 事 宜 ， 尽 管 该 党 已 经 在 为 该 组 织 的 改 革 计 划 做 准 备 ， 但 他 们 能 够 改 变 这 种 格 局 吗 ？ ";
		for (int i = 0; i < a.allcountries.Length; i++)
		{
			if (a.allcountries[i].isOVD && a.allcountries[i].proprc)
			{
				a.allcountries[i].isOVD = false;
				a.allcountries[i].okb = true;
			}
		}
		for (int j = 0; j < a.allcountries.Length; j++)
		{
			if (a.allcountries[j].isSEV && a.allcountries[j].proprc)
			{
				a.allcountries[j].isSEV = false;
				a.allcountries[j].econ = true;
			}
		}
		for (int k = 0; k < a.allcountries.Length; k++)
		{
			if (a.allcountries[k].isOVD)
			{
				a.allcountries[k].isOVD = false;
			}
		}
		if (a.empires[1].power > 0)
		{
			a.empires[1].power = 0;
		}
	}
}
