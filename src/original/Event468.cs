using EventsForDLC;
using UnityEngine;

public class Event468 : EventsSecond
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
		name = " 南 太 平 洋 海 涛 翻 腾";
		text = " 主 席 同 志 ， 随 着 泰 国 革 命 的 胜 利 ， 马 来 亚 问 题 也 摆 在 了 我 们 眼 前 ： 原 本 因 为 “ 新 村 政 策 ” 力 量 大 幅 削 弱 的 马 来 亚 共 产 党 、 马 来 亚 民 族 解 放 军 和 北 加 里 曼 丹 共 产 党 、 北 加 里 曼 丹 人 民 军 在 我 们 和 泰 国 革 命 政 权 的 协 助 下 愈 发 壮 大 ， 马 来 西 亚 和 新 加 坡 政 府 不 断 敦 促 泰 国 革 命 政 府 停 止 对 马 来 亚 共 产 党 和 北 加 里 曼 丹 共 产 党 的 援 助 。 东 南 亚 各 个 国 家 革 命 的 成 功 以 及 他 们 对 马 来 西 亚 的 经 济 封 锁 使 得 马 来 西 亚 的 经 济 陷 入 困 境 。 加 上 马 来 西 亚 和 新 加 坡 对 左 翼 运 动 的 猎 巫 式 镇 压 （ 大 量 温 和 派 议 会 党 甚 至 被 直 接 查 禁 ） 使 得 民 众 越 发 不 满 — — 这 些 国 家 的 左 翼 思 潮 像 6 8 运 动 时 期 一 样 再 次 流 行 起 来 了 。 学 生 运 动 、 工 人 罢 工 和 民 众 游 行 引 来 了 政 府 的 镇 压 ， 马 来 西 亚 像 5 0 年 代 一 样 开 始 实 行 紧 急 状 态 。 现 在 ， 马 来 亚 共 产 党 主 席 陈 平 同 志 向 中 央 委 员 会 亲 自 发 电 ， 请 泰 国 革 命 政 府 给 马 来 亚 民 族 解 放 阵 线 北 马 来 半 岛 作 为 革 命 根 据 地 ， 并 恢 复 马 来 亚 共 产 党 对 南 泰 马 来 族 为 主 体 地 区 的 统 治 ， 泰 国 共 产 党 中 央 委 员 会 大 部 分 人 认 同 了 这 个 提 案 。 但 这 样 的 行 为 ， 基 本 等 于 让 新 生 的 革 命 政 权 走 向 新 的 战 争 。 现 在 ， 主 席 同 志 ， 面 对 两 边 的 压 力 ， 我 们 该 如 何 抉 择 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.resultOfEvents[467] == 0 && GlobalScript.inst.gameState.event_done[467])
		{
			button_text[0] = " 是 时 候 了 ， 马 来 亚 和 北 加 里 曼 丹 的 人 民 已 经 盼 了 很 久 了";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 们 根 本 没 有 这 样 的 势 力 基 础";
		}
		button_text[1] = " 让 他 们 在 议 会 斗 吧 ， 保 全 势 力 也 好";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 南 太 平 洋 海 涛 翻 腾";
		switch (result_num)
		{
		case 0:
			text = " 世 界 各 国 人 民 的 解 放 一 直 都 是 我 们 的 夙 愿 ， 我 们 的 兄 弟 党 即 将 迎 来 自 己 民 族 的 解 放 ， 我 们 怎 么 可 能 撒 手 不 管 ！ 我 们 积 极 辅 助 了 泰 马 两 党 的 北 马 来 根 据 地 政 权 的 转 移 工 作 。 马 来 政 府 对 我 们 的 行 为 十 分 恼 火 ， 已 经 对 我 们 的 行 为 下 了 最 后 通 牒 ， 但 是 这 又 如 何 呢 ？ 一 个 买 办 政 府 是 挡 不 住 人 民 战 争 的 汪 洋 大 海 的 ！ 新 生 的 泰 人 民 政 权 已 经 准 备 好 投 入 进 这 一 场 兄 弟 民 族 的 革 命 中 去 了 ， 我 们 更 应 该 履 行 无 产 阶 级 国 际 主 义 。 同 志 们 ， 向 吉 隆 坡 ， 进 攻 ！";
			GlobalScript.inst.gameState.allcountries[49].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[49].SubGosstroy = 7;
			GlobalScript.inst.gameState.ingamewars[34].name_war = " 马 来 亚 内 战";
			GlobalScript.inst.gameState.ingamewars[34].is_going = true;
			GlobalScript.inst.gameState.ingamewars[34].side1 = " 马 来 亚 民 族 解 放 同 盟";
			GlobalScript.inst.gameState.ingamewars[34].side2 = " 马 来 西 亚 政 府";
			GlobalScript.inst.gameState.ingamewars[34].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[34].infl1 = 300;
			GlobalScript.inst.gameState.ingamewars[34].infl2 = 700;
			GlobalScript.inst.gameState.ingamewars[34].fortnight_max = 20;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.empires[0].relations -= 300;
			GlobalScript.inst.gameState.influencePRC += 20;
			break;
		case 1:
			text = " 经 过 权 衡 ， 我 们 还 是 认 为 维 持 与 现 在 马 来 西 亚 政 府 的 友 谊 更 好 。 为 此 ， 我 们 让 马 来 亚 民 族 解 放 军 和 马 来 西 亚 现 政 府 签 订 《 合 艾 和 约 》 。 泰 国 的 人 民 政 权 对 我 国 完 全 失 望 ， 转 而 加 入 了 经 济 互 助 委 员 会 ， 失 去 了 一 个 这 样 的 盟 友 也 没 有 什 么 挽 留 的 ， 天 要 下 雨 ， 娘 要 嫁 人 ， 随 他 去 吧 。 而 马 来 西 亚 现 政 府 与 我 们 现 在 的 关 系 也 变 好 了 ，";
			if (GlobalScript.inst.gameState.allcountries[51].Torg)
			{
				text += " 我 们 与 东 盟 的 合 作 也 深 入 了 下 去 ，";
			}
			text += " 但 愿 这 对 我 们 的 全 球 战 略 有 好 的 影 响 。";
			GlobalScript.inst.gameState.empires[0].relations += 150;
			GlobalScript.inst.gameState.allcountries[34].Torg = false;
			if (GlobalScript.inst.gameState.allcountries[34].okb)
			{
				GlobalScript.inst.gameState.allcountries[34].proprc = false;
			}
			if (GlobalScript.inst.gameState.allcountries[34].econ && !GlobalScript.inst.gameState.allcountries[34].okb)
			{
				GlobalScript.inst.gameState.allcountries[34].econ = false;
				GlobalScript.inst.gameState.allcountries[34].isSEV = true;
				GlobalScript.inst.gameState.allcountries[34].proprc = false;
				GlobalScript.inst.gameState.empires[1].power += 50;
			}
			GlobalScript.inst.gameState.allcountries[49].Torg = true;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
