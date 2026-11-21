using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event657 : EventsSecond
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
		name = " 富 拉 尼 圣 战 的 余 烬";
		text = "这 是 尼 日 利 亚 独 立 以 来 宗 教 冲 突 最 为 严 重 的 时 期 。 扬 塔 特 斯 尼 基 于 经 济 萧 条 和 失 业 ， 在 学 生 运 动 、 失 业 的 无 产 阶 级 乃 至 外 国 人 中 吸 收 了 大 量 的 支 持 者 ， 并 已 经 采 取 过 多 次 成 功 的 行 动 ， 誓 要 把 堕 落 的 西 方 毒 瘤 赶 出 尼 日 利 亚 。 如 今 ， 他 们 基 于 北 方 的 宗 教 保 守 主 义 和 部 分 北 方 部 族 精 英 的 支 持 ， 已 经 在 北 方 建 立 了 可 观 的 地 下 网 络 和 根 据 地 ， 大 有 把 “ 新 富 拉 尼 圣 战 ” 输 出 到 全 国 的 势 头 。 尼 日 利 亚 军 方 已 经 决 定 对 扬 塔 特 斯 尼 运 动 进 行 最 终 的 围 剿 和 镇 压 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = "把 斗 争 进 行 到 底 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 富 拉 尼 圣 战 的 余 烬";
		if (result_num == 0)
		{
			a.allcountries[60].parts[0] = true;
			a.allcountries[60].cw = true;
			text = " 扬 塔 特 斯 尼 先 发 制 人 ， 依 托 群 众 基 础 和 地 下 网 络 迅 速 发 动 起 义 和 进 攻 ， 成 功 占 领 了 北 方 大 部 分 地 区 ， 政 府 军 在 北 方 遭 遇 了 大 量 损 失 。 在 穆 萨 · 阿 里 · 苏 莱 曼 的 领 导 下 ， 扬 塔 特 斯 尼 开 始 准 备 南 下 反 攻 尼 日 利 亚 政 府 。 第 二 次 尼 日 利 亚 内 战 就 这 样 爆 发 了 。 这 将 是 一 场 烈 度 不 会 低 于 比 夫 拉 战 争 的 内 战 … … 尼 日 利 亚 将 通 往 何 方 ？";
			a.allcountries[60].Torg = false;
			a.ingamewars[79] = new War().Name("第 二 次 尼 日 利 亚 内 战").Attacker("扬 塔 特 斯 尼").Defender("尼 日 利 亚 政 府")
				.AttackerInfluence(400)
				.DefenderInfluence(600)
				.AmericanSupportDefender.SovietSupportDefender.CreateWar;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
