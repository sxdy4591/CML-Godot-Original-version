using EventsForDLC;
using UnityEngine;

public class Event114 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 驴 象 之 争";
		text = " 美 国 总 统 大 选 很 快 就 要 举 行 ， 民 主 党 总 统 吉 米 · 卡 特 准 备 在 和 共 和 党 野 心 勃 勃 的 罗 纳 德 · 里 根 的 竞 争 中 拿 下 第 二 个 任 期 。 第 一 个 任 期 里 吉 米 · 卡 特 努 力 改 善 美 国 人 民 的 福 利 、 建 设 更 加 开 放 的 政 府 、 对 美 国 政 府 机 构 在 全 局 上 进 行 改 革 。 他 的 外 交 政 策 特 点 是 在 与 苏 联 的 对 抗 与 缓 和 中 找 到 平 衡 。 但 是 ， 他 的 领 导 在 节 节 攀 升 的 油 价 中 撞 得 头 破 血 流 ， 相 对 缓 和 的 外 交 政 策 也 在 保 守 派 圈 子 里 被 大 大 批 判 一 番 ， 所 以 共 和 党 的 胜 利 基 本 已 经 稳 了 。 反 正 我 们 也 管 不 了 ， 等 着 看 吧 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 我 们 都 在 等 待 结 果 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 驴 象 之 争";
		int num = 0;
		int num2 = 0;
		if (GlobalScript.inst.gameState.empires[0].power > GlobalScript.inst.gameState.empires[1].power)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (GlobalScript.inst.gameState.empires[0].power > GlobalScript.inst.gameState.influencePRC)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[1].power)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (GlobalScript.inst.gameState.OAR)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[15].cw)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[1].isASEAN)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.resultOfEvents[46] == 2)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.ingamewars[5].is_going)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[84].Gosstroy == 0)
		{
			num++;
		}
		else
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 3 || GlobalScript.inst.gameState.allcountries[8].Vyshi)
		{
			num2++;
		}
		else
		{
			num++;
		}
		if (GlobalScript.inst.gameState.event_done[455] && GlobalScript.inst.gameState.resultOfEvents[455] == 0)
		{
			num2++;
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[455] == 1)
		{
			num2 += 2;
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[455] == 2)
		{
			num2 -= 2;
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[455] == 3)
		{
			num2--;
		}
		if (GlobalScript.inst.gameState.number_otvet == 1)
		{
			if (num2 >= num)
			{
				text = " 选 举 结 束 后 ， 卡 特 仍 设 法 维 持 住 了 权 力 。 他 获 胜 的 一 个 关 键 因 素 是 他 温 和 的 外 交 政 策 ， 尽 管 受 到 保 守 派 的 批 评 ， 但 总 体 上 表 现 良 好 。 美 国 正 在 等 待 民 主 党 执 政 的 第 二 个 四 年 。";
				GlobalScript.inst.gameState.data[143] += 2;
				GlobalScript.inst.gameState.empires[0].now_leader = 1;
			}
			else if (num2 < num)
			{
				text = " 选 举 结 束 后 ， 卡 特 被 里 根 击 败 。 由 于 对 油 价 上 涨 和 外 交 政 策 失 败 所 导 致 的 通 胀 和 失 业 率 上 升 感 到 不 满 ， 美 国 人 选 择 了 追 随 共 和 党 人 的 民 粹 主 义 口 号 。  现 在 ， 在 里 根 的 领 导 下 ， 美 国 正 等 待 着 与 苏 联 进 行 新 一 轮 的 积 极 对 抗 。";
				GlobalScript.inst.gameState.empires[0].now_leader = 0;
				GlobalScript.inst.gameState.data[143] -= 2;
				GlobalScript.inst.gameState.allcountries[51].SubGosstroy = 12;
			}
		}
	}
}
