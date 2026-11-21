using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event426 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1402];
		text = string.Format(GlobalScript.inst.new_events_text[1403], "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 6;
		if (a.data[8] + a.data[36] >= 100 && a.data[9] >= 50 && a.data[22] >= 150)
		{
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[1404], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.data[8] + a.data[36] < 100)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[566], 10f);
		}
		else if (a.data[9] < 50)
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[567], 5f);
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = string.Format(GlobalScript.inst.new_events_text[776], 15f);
		}
		button_text[1] = GlobalScript.inst.new_events_text[1405];
		button_text[2] = GlobalScript.inst.new_events_text[1406];
		if (GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.data[22] >= 150 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 100 && GlobalScript.inst.gameState.data[9] >= 150)
		{
			button_text[3] = " 清 除 两 地 顽 固 的 民 族 主 义 者 ， 将 左 翼 游 击 队 联 合 起 来 组 成 革 命 统 一 阵 线";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 这 太 激 进 了 ！";
		}
		if (GlobalScript.inst.gameState.data[56] != 0 && !GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[22] >= 150 && GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 100 && GlobalScript.inst.gameState.data[9] >= 150)
		{
			button_text[4] = " 左 翼 卡 洛 斯 派 ， 人 民 联 合 王 国 ！";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 君 主 社 会 主 义 ？ 你 在 搞 笑 吗 ？";
		}
		button_text[5] = GlobalScript.inst.new_events_text[1407];
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1402];
		if (result_num != 3 && result_num != 4)
		{
			a.allcountries[109].Gosstroy = 0;
			a.allcountries[109].SubGosstroy = 10;
			a.allcountries[86].parts[0] = true;
			a.allcountries[86].parts[1] = true;
			a.allcountries[110].Gosstroy = 2;
			a.allcountries[110].SubGosstroy = 15;
			a.allcountries[109].soc_stab = 1000;
			a.allcountries[109].stab = 1000;
			a.allcountries[110].stab = 1000;
			a.allcountries[110].soc_stab = 1000;
		}
		switch (result_num)
		{
		case 0:
			text = string.Format(GlobalScript.inst.new_events_text[1413], "\n");
			a.data[8] -= 100;
			a.data[9] -= 50;
			a.data[22] -= 200;
			a.empires[0].relations -= 250;
			a.empires[1].relations -= 250;
			a.allcountries[109].Torg = true;
			a.allcountries[110].Torg = true;
			a.ingamewars[31] = new War().Name(GlobalScript.inst.new_events_text[1408]).Attacker(GlobalScript.inst.new_events_text[1409]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.CreateWar;
			a.ingamewars[32] = new War().Name(GlobalScript.inst.new_events_text[1411]).Attacker(GlobalScript.inst.new_events_text[1412]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(500)
				.DefenderInfluence(500)
				.CreateWar;
			return;
		case 1:
			text = string.Format(GlobalScript.inst.new_events_text[1414], "\n");
			a.empires[0].relations -= 150;
			a.empires[1].relations -= 150;
			a.ingamewars[31] = new War().Name(GlobalScript.inst.new_events_text[1408]).Attacker(GlobalScript.inst.new_events_text[1409]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.CreateWar;
			a.ingamewars[32] = new War().Name(GlobalScript.inst.new_events_text[1411]).Attacker(GlobalScript.inst.new_events_text[1412]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.CreateWar;
			return;
		case 2:
			text = string.Format(GlobalScript.inst.new_events_text[1415], "\n");
			a.empires[0].relations += 150;
			a.empires[1].relations += 150;
			a.ingamewars[31] = new War().Name(GlobalScript.inst.new_events_text[1408]).Attacker(GlobalScript.inst.new_events_text[1409]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.CreateWar;
			a.ingamewars[32] = new War().Name(GlobalScript.inst.new_events_text[1411]).Attacker(GlobalScript.inst.new_events_text[1412]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.CreateWar;
			break;
		}
		if (result_num == 3)
		{
			text = " 我 们 的 特 工 联 系 到 所 有 反 修 派 组 织 和 左 翼 游 击 队 ， 在 帮 助 巴 斯 克 政 权 内 部 的 共 产 主 义 者 发 起 了 一 场 政 变 ， 设 法 清 除 了 一 批 最 顽 固 的 民 族 主 义 者 后 ， 成 功 将 他 们 串 联 了 起 来 ， 成 立 了 反 法 西 斯 革 命 统 一 阵 线 。 阵 线 依 托 于 <color=red>西 共 （ 马 列 ）</color> 、 <color=red>西 共 （ 重 建 ）</color> 和 <color=red>西 班 牙 工 人 党</color> 等 组 织 和 他 们 控 制 的 工 会 ， 将 各 个 游 击 队 串 联 起 来 ， 在 国 民 政 府 的 控 制 区 发 起 了 一 场 大 起 义 。 于 此 同 时 ， 统 一 阵 线 在 我 们 的 帮 助 下 与 共 和 政 府 达 成 了 结 盟 协 议 ， 双 方 确 立 了 反 法 西 斯 的 同 盟 。";
			a.ingamewars[30].side1 = " 共 和 政 府 - 统 一 阵 线";
			a.ingamewars[30].infl1 += 150;
			a.ingamewars[30].infl2 -= 150;
			a.data[22] -= 150;
			a.data[8] -= 100;
			a.data[9] -= 150;
		}
		if (result_num == 4)
		{
			text = " 我 们 收 到 一 则 有 趣 的 消 息 ， 因 为 内 战 ， 一 个 持 有 左 翼 卡 洛 斯 主 义 的 武 装 团 体 — — <color=green>卡 洛 斯 主 义 行 动 小 组</color> — — 也 依 托 于 左 翼 卡 洛 斯 党 和 加 泰 罗 尼 亚 与 巴 斯 克 的 左 翼 在 近 期 重 建 了 。 考 虑 到 他 们 与 加 泰 罗 尼 亚 和 巴 斯 克 地 区 的 左 翼 分 离 主 义 的 亲 近 关 系 ， 支 持 他 们 与 左 翼 分 离 主 义 联 合 是 完 全 可 能 的 ！ 在 我 们 的 帮 助 下 ， 分 离 主 义 者 们 意 识 到 ： 搞 布 朗 基 主 义 是 不 可 能 带 来 民 族 的 解 放 的 ， 只 有 团 结 在 雨 果 · 卡 洛 斯 殿 下 周 围 建 设 各 民 族 平 等 的 自 治 社 会 主 义 才 能 真 正 带 来 解 放 ！ || 显 然 ， 卡 洛 斯 派 们 要 同 时 面 对 来 自 长 枪 党 和 共 和 政 府 的 压 力 ， 祝 他 们 好 运 … …";
			a.ingamewars[30].side1 = " 卡 洛 斯 派";
			a.ingamewars[30].side2 = " 长 枪 党 - 共 和 政 府";
			a.ingamewars[30].infl1 = 50;
			a.ingamewars[30].infl2 = 950;
			a.data[22] -= 150;
			a.data[8] -= 100;
			a.data[9] -= 150;
		}
		if (result_num == 5)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1416], "\n");
			a.ingamewars[31] = new War().Name(GlobalScript.inst.new_events_text[1408]).Attacker(GlobalScript.inst.new_events_text[1409]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.CreateWar;
			a.ingamewars[32] = new War().Name(GlobalScript.inst.new_events_text[1411]).Attacker(GlobalScript.inst.new_events_text[1412]).Defender(GlobalScript.inst.new_events_text[1410])
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.CreateWar;
		}
	}
}
