using EventsForDLC;
using UnityEngine;

public class Event42 : EventsSecond
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
		name = " 伊 朗 革 命";
		text = " 一 段 时 间 以 来 ， 针 对 伊 朗 人 民 困 难 的 社 会 经 济 状 况 、 沙 阿 的 亲 美 政 策 、 统 治 精 英 的 猖 獗 腐 败 以 及 国 家 对 什 叶 派 神 职 人 员 的 压 迫 ， 抗 议 一 直 在 沙 阿 伊 朗 举 行 。 然 而 ， 今 天 ， 反 政 府 示 威 活 动 在 库 姆 的 抗 议 被 警 察 镇 压 后 进 入 了 白 热 化 阶 段 ， 这 是 由 一 篇 关 于 阿 亚 图 拉 （ 什 叶 派 伊 斯 兰 教 的 最 高 精 神 称 号 ） 霍 梅 尼 的 诽 谤 文 章 引 起 的 。 他 是 抗 议 活 动 的 精 神 领 袖 ，1964 年 被 驱 逐 出 境 。 此 后 ， 抗 议 和 罢 工 席 卷 了 伊 朗 的 许 多 城 市 。 伊 斯 兰 主 义 运 动 ， 如 自 由 伊 朗 运 动 和 战 斗 神 职 人 员 社 会 ， 是 即 将 到 来 的 革 命 的 驱 动 力 ， 但 其 他 组 织 也 在 努 力 推 翻 沙 阿 ， 其 中 最 大 的 是 伊 朗 民 主 民 族 阵 线 和 伊 朗 马 列 主 义 人 民 党 。 伊 朗 的 革 命 会 极 大 地 改 变 中 东 地 区 的 权 力 平 衡 ， 所 以 也 许 我 们 应 该 进 行 干 预 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 不 干 涉";
		if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.data[56] <= 1)
		{
			button_text[1] = " 旧 的 不 去 ， 新 的 不 来 ， 滚 蛋 吧 沙 阿 ！";
		}
		else if (GlobalScript.inst.gameState.data[9] < 50)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 爱 莫 能 助";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 美 国 人 会 怎 么 想 ？ 他 们 会 勃 然 大 怒 的 ！";
		}
		if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[2] = " 我 们 应 当 支 持 君 主 派 ， 说 不 定 将 来 会 有 用 呢 ?";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 君 主 专 政 和 法 西 斯 到 底 有 什 么 差 别 ？";
		}
		if (GlobalScript.inst.gameState.data[9] >= 50)
		{
			button_text[3] = " 支 持 民 主 派";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[3] = " 我 们 没 有 余 力";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 伊 朗 革 命";
		switch (result_num)
		{
		case 0:
			text = " 伊 朗 的 抗 议 和 罢 工 仍 在 没 有 我 们 参 与 的 情 况 下 继 续 。";
			GlobalScript.inst.gameState.iranrev = true;
			GlobalScript.inst.gameState.allcountries[8].dev = 4;
			break;
		case 1:
			text = " 一 批 批 印 着 “ 英 雄 的 伊 朗 人 民 万 岁 ” 的 板 条 箱 由 货 轮 运 往 伊 朗 。 伊 朗 的 革 命 组 织 感 谢 了 我 们 的 帮 助 ， 祝 他 们 好 运 ！ 但 同 时 ， 美 国 对 我 们 的 举 动 感 到 不 快 ， 这 可 是 明 着 挖 他 们 墙 角 啊 。 干 涉 伊 朗 的 第 一 步 已 经 开 始 ， 但 我 们 不 能 忘 记 定 期 向 他 们 发 送 新 的 援 助 。";
			GlobalScript.inst.gameState.data[42] += 70;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.iranrev = true;
			GlobalScript.inst.gameState.allcountries[8].dev = 1;
			break;
		case 2:
			text = " 沙 阿 和 伊 朗 政 府 方 面 感 谢 了 我 们 的 帮 助 。 作 为 回 报 ， 伊 朗 政 府 宣 布 和 我 国 展 开 更 深 入 的 贸 易   。 美 国 驻 伊 朗 大 使 也 感 谢 了 我 们 的 慷 慨 解 囊 。  干 涉 伊 朗 的 第 一 步 已 经 开 始 ， 但 我 们 不 能 忘 记 定 期 向 沙 阿 提 供 新 的 帮 助 。";
			GlobalScript.inst.gameState.iranrev = true;
			GlobalScript.inst.gameState.data[43] += 70;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.allcountries[8].dev = 0;
			GlobalScript.inst.gameState.allcountries[8].Torg = true;
			break;
		case 3:
			text = " 我 们 能 够 与 国 民 阵 线 和 其 他 民 主 组 织 （ 包 括 伊 斯 兰 民 主 党 ） 建 立 联 系 ， 他 们 现 在 正 在 接 受 我 们 的 援 助 。 干 涉 伊 朗 的 第 一 步 已 经 开 始 ， 但 我 们 不 能 忘 记 定 期 向 他 们 发 送 新 的 帮 助 。";
			GlobalScript.inst.gameState.iranrev = true;
			GlobalScript.inst.gameState.data[44] += 70;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.allcountries[8].dev = 2;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
