using EventsForDLC;
using UnityEngine;

public class Event89 : EventsSecond
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
		name = " 一 个 时 代 的 终 结";
		text = " 来 自 苏 联 的 紧 急 消 息 ！ 今 天 ， 苏 联 领 导 人 宣 布 列 昂 尼 德 · 伊 里 奇 · 勃 列 日 涅 夫 去 世 ， 他 领 导 苏 联 接 近20 年 。11 月10 日 ， 这 位 苏 联 领 导 人 在 梦 中 死 于 突 发 性 心 力 衰 竭 。 在 苏 联 人 民 哀 悼 之 际 ， 苏 共 展 开 了 一 场 激 烈 的 权 力 斗 争 ， 苏 共 中 央 总 书 记 的 主 要 竞 争 者 是 ：";
		if (GlobalScript.inst.gameState.empires[1].leaders[3].support > 0)
		{
			text += "|| 尤 里 · 安 德 罗 波 夫 ， 苏 联 克 格 勃 领 导 人 ， 一 位 务 实 的 改 革 者 ， 积 极 提 拔 他 的 改 革 派 伙 伴 ， 如 戈 尔 巴 乔 夫 、 利 加 乔 夫 和 多 尔 吉 赫 。";
		}
		if (GlobalScript.inst.gameState.empires[1].leaders[1].support > 0)
		{
			text += "|| 弗 拉 基 米 尔 · 谢 尔 比 茨 基 ， 乌 克 兰 共 产 党 领 导 人 ， 一 位 忠 诚 的 勃 列 日 涅 夫 主 义 者 ， 在 发 展 经 济 和 提 高 乌 克 兰 苏 维 埃 社 会 主 义 共 和 国 生 活 水 平 方 面 取 得 了 巨 大 成 功 。";
		}
		text += "|| 康 斯 坦 丁 · 契 尔 年 科 ， 苏 共 中 央 委 员 会 总 务 部 部 长 ， 一 位 保 守 派 党 员 和 经 验 丰 富 的 组 织 者 ， 有 些 人 甚 至 认 为 他 是 斯 大 林 主 义 者 。|| 如 果 我 们 与 苏 联 的 关 系 不 太 糟 ， 那 么 我 们 可 以 支 持 其 中 一 个 候 选 人 。 当 然 ， 这 不 会 从 根 本 上 改 变 形 势 ， 但 在 相 持 的 情 况 下 ， 这 可 能 会 使 天 平 倾 向 一 个 更 适 宜 的 候 选 人 。";
		if (GlobalScript.inst.gameState.data[89] == 0)
		{
			GlobalScript.inst.gameState.empires[1].leaders[3].support--;
		}
		if (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power)
		{
			GlobalScript.inst.gameState.empires[1].leaders[2].support++;
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.empires[1].leaders[3].support > 0)
		{
			button_text[0] = " 支 持 安 德 罗 波 夫";
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[3].support <= 0)
		{
			Object.Destroy(button[0]);
			button_text[0] = "";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
		}
		if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.empires[1].leaders[1].support != 0)
		{
			button_text[1] = " 支 持 谢 尔 比 茨 基";
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[1].support == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = "";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
		}
		if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 50 && GlobalScript.inst.gameState.data[9] >= 100)
		{
			button_text[2] = " 支 持 契 尔 年 科";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
		}
		button_text[3] = " 不 要 介 入 ， 静 待 结 果";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 一 个 时 代 的 终 结";
		int num = -1;
		switch (result_num)
		{
		case 0:
			text = "";
			num = 3;
			break;
		case 1:
			text = "";
			num = 1;
			break;
		case 2:
			text = "";
			num = 2;
			break;
		}
		if (num >= 0)
		{
			GlobalScript.inst.gameState.empires[1].leaders[num].support += 2;
			GlobalScript.inst.gameState.data[9] -= 100;
			if (GlobalScript.inst.gameState.relres)
			{
				GlobalScript.inst.gameState.empires[1].leaders[num].support++;
			}
			if (GlobalScript.inst.gameState.allcountries[7].Torg || GlobalScript.inst.gameState.allcountries[1].isSEV)
			{
				GlobalScript.inst.gameState.empires[1].leaders[num].support++;
			}
			if (GlobalScript.inst.gameState.allcountries[1].isOVD)
			{
				GlobalScript.inst.gameState.empires[1].leaders[num].support++;
			}
		}
		if (GlobalScript.inst.gameState.empires[1].leaders[2].support >= GlobalScript.inst.gameState.empires[1].leaders[3].support && GlobalScript.inst.gameState.empires[1].leaders[2].support >= GlobalScript.inst.gameState.empires[1].leaders[1].support)
		{
			text = " 结 果 ， 康 斯 坦 丁 · 契 尔 年 科 当 选 为 苏 共 中 央 委 员 会 总 书 记 。 许 多 人 认 为 他 是 一 个 适 宜 的 折 衷 方 案 ， 可 以 让 联 盟 避 免 大 规 模 的 变 革 和 动 荡 ， 而 他 似 乎 会 满 足 他 们 的 期 望 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 2;
			GlobalScript.inst.gameState.empires[1].leaders[4].support++;
			GlobalScript.inst.gameState.empires[1].leaders[5].support++;
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[1].support >= GlobalScript.inst.gameState.empires[1].leaders[2].support && GlobalScript.inst.gameState.empires[1].leaders[1].support >= GlobalScript.inst.gameState.empires[1].leaders[3].support)
		{
			text = " 结 果 ， 弗 拉 基 米 尔 · 谢 尔 比 茨 基 当 选 为 苏 共 中 央 委 员 会 总 书 记 。 这 并 不 奇 怪 — — 除 去 了 安 德 罗 波 夫 ， 在 苏 斯 洛 夫 的 支 持 和 勃 列 日 涅 夫 的 信 任 下 ， 他 成 为 了 这 个 职 位 的 主 要 竞 争 者 。 苏 联 似 乎 在 等 待 数 年 的 稳 定 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 3;
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[3].support >= GlobalScript.inst.gameState.empires[1].leaders[2].support && GlobalScript.inst.gameState.empires[1].leaders[3].support >= GlobalScript.inst.gameState.empires[1].leaders[1].support)
		{
			text = " 结 果 ， 尤 里 · 安 德 罗 波 夫 当 选 为 苏 共 中 央 委 员 会 总 书 记 。 在 领 导 克 格 勃 的 岁 月 里 ， 他 把 巨 大 的 权 力 集 中 在 手 中 ， 使 他 赢 得 了 这 场 战 斗 ， 许 多 人 认 为 他 是 一 个 务 实 而 强 硬 的 领 导 人 ， 对 苏 联 来 说 是 非 常 必 要 的 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 1;
			GlobalScript.inst.gameState.empires[1].leaders[6].support += 2;
		}
		else if (GlobalScript.inst.gameState.empires[1].leaders[2].support >= GlobalScript.inst.gameState.empires[1].leaders[3].support)
		{
			text = " 结 果 ， 康 斯 坦 丁 · 契 尔 年 科 当 选 为 苏 共 中 央 委 员 会 总 书 记 。 许 多 人 认 为 他 是 一 个 适 宜 的 折 衷 方 案 ， 可 以 让 联 盟 避 免 大 规 模 的 变 革 和 动 荡 ， 而 他 似 乎 会 满 足 他 们 的 期 望 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 2;
			GlobalScript.inst.gameState.empires[1].leaders[4].support++;
			GlobalScript.inst.gameState.empires[1].leaders[5].support++;
		}
		else
		{
			text = " 结 果 ， 尤 里 · 安 德 罗 波 夫 当 选 为 苏 共 中 央 委 员 会 总 书 记 。 在 领 导 克 格 勃 的 岁 月 里 ， 他 把 巨 大 的 权 力 集 中 在 手 中 ， 使 他 赢 得 了 这 场 战 斗 ， 许 多 人 认 为 他 是 一 个 务 实 而 强 硬 的 领 导 人 ， 对 苏 联 来 说 是 非 常 必 要 的 。";
			GlobalScript.inst.gameState.empires[1].now_leader = 1;
			GlobalScript.inst.gameState.empires[1].leaders[6].support += 2;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
