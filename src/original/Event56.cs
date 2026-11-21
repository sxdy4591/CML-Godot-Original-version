using EventsForDLC;
using UnityEngine;

public class Event56 : EventsSecond
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
		name = " 给 越 南 点 教 训 ？";
		text = " 越 南 在 印 度 支 那 的 扩 张 ， 并 对 我 们 的 柬 埔 寨 朋 友 发 起 了 侵 略 ， 这 并 不 让 我 们 高 兴 。 鉴 于 越 南 黎 笋 集 团 的 亲 苏 排 华 路 线 ， 他 们 的 扩 张 对 我 们 很 是 不 利 。 再 加 上 我 们 与 越 南 的 边 境 冲 突 和 越 南 对 华 人 的 迫 害 ， 不 少 党 员 认 为 应 该 “ 给 越 南 人 一 些 教 训 ” ， 以 击 垮 “ 白 眼 狼 ” 。 我 们 可 以 用 边 境 冲 突 为 借 口 发 起 战 争 ， 夺 取 边 境 地 区 ， 并 消 灭 到 来 的 越 南 军 队 ， 尽 可 能 地 向 越 南 境 内 推 进 ， 并 为 我 们 的 柬 埔 寨 盟 友 分 担 压 力 。 这 样 的 一 击 将 使 得 越 南 领 导 层 严 肃 地 重 新 考 虑 其 对 苏 和 对 华 政 策 ， 也 可 以 为 我 们 与 西 方 的 缓 和 甚 至 是 交 好 打 下 基 础 。 主 席 同 志 ， 我 们 该 如 何 选 择 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 我 们 不 能 激 化 局 势";
		if (!GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.war == 0)
		{
			button_text[1] = " 准 备 战 争 。 让 我 们 给 越 南 人 点 教 训 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 一 切 按 计 划 进 行";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 给 越 南 点 教 训 ？";
		switch (result_num)
		{
		case 0:
			text = " 你 设 法 使 中 国 共 产 党 党 内 平 静 下 来 ， 尽 管 不 是 没 有 不 满 的 声 音 。 一 切 照 旧 进 行 ， 越 南 与 苏 联 依 旧 保 持 友 好 关 系 ， 并 继 续 进 行 对 柬 埔 寨 的 侵 略 战 争 。";
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.vietnampeace = true;
			GlobalScript.inst.gameState.influencePRC -= 20;
			break;
		case 1:
			text = " 准 备 入 侵 越 南 的 决 定 已 经 定 下 ， 国 内 宣 传 机 器 和 军 队 正 在 动 员 。 2 月 1 7 日 下 午 4 时 3 0 分 ， 解 放 军 部 队 越 境 ， 经 过 激 烈 的 战 斗 ， 他 们 占 领 了 边 境 地 区 ， 瓦 解 了 越 南 的 抵 抗 。 然 而 ， 恢 复 过 来 的 越 南 军 队 现 在 正 在 以 武 力 反 击 。 我 们 希 望 我 们 有 足 够 的 力 量 来 完 成 我 们 的 计 划 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.war = 1;
			GlobalScript.inst.gameState.data[39] = 200;
			GlobalScript.inst.gameState.empires[1].relations -= 200;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.ingamewars[1].name_war = " 中 国 柬 埔 寨 － 越 南 战 争";
			GlobalScript.inst.gameState.ingamewars[1].side1 = " 中 国 - 柬 埔 寨";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
