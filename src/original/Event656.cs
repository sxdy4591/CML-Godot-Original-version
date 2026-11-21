using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event656 : EventsSecond
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
		name = " 红 色 普 罗 米 修 斯";
		text = "尼 日 利 亚 仍 在 泥 潭 中 挣 扎 ， 政 府 换 了 又 换 ， 国 家 的 实 质 也 并 未 改 变 。 无 论 是 开 明 的 政 府 亦 或 者 是 保 守 的 政 府 ， 都 对 无 产 阶 级 真 正 的 革 命 运 动 采 取 敌 视 和 镇 压 的 政 策 。 如 今 ， 全 尼 日 利 亚 革 命 社 会 主 义 联 盟 在 尼 日 利 亚 的 萧 条 和 阶 级 矛 盾 中 获 得 了 大 幅 的 发 展 ， 吸 纳 了 失 业 的 无 产 阶 级 、 被 压 迫 的 农 民 和 热 血 的 青 年 ， 依 托 于 农 村 的 秘 密 公 社 运 动 、 基 于 持 久 人 民 战 争 原 则 的 农 村 游 击 战 和 城 市 群 众 运 动 、 学 生 运 动 和 工 人 运 动 获 得 了 壮 大 。 尼 日 利 亚 人 民 军 已 经 占 领 了 相 当 的 根 据 地 ， 是 时 候 开 始 战 略 反 攻 了 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = "战 斗 的 人 民 军 向 前 进 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 红 色 普 罗 米 修 斯";
		if (result_num == 0)
		{
			a.allcountries[60].parts[0] = true;
			text = " 依 托 于 城 市 内 的 左 翼 工 会 网 络 组 织 起 来 的 工 人 赤 卫 队 发 动 起 义 ， 同 尼 日 利 亚 人 民 军 协 调 行 动 ， 开 始 进 攻 大 城 市 。 惊 恐 的 尼 日 利 亚 国 家 机 器 不 愿 就 此 坐 以 待 毙 ， 开 始 宣 布 紧 急 状 态 和 总 动 员 ， 并 放 权 各 地 部 族 精 英 ， 各 个 部 族 也 趁 机 开 始 武 装 自 己 。 这 将 是 一 场 烈 度 不 会 低 于 比 夫 拉 战 争 的 内 战 … … 尼 日 利 亚 将 通 往 何 方 ？";
			a.allcountries[60].Torg = false;
			a.ingamewars[79] = new War().Name("第 二 次 尼 日 利 亚 内 战").Attacker("尼 日 利 亚 人 民 军").Defender("尼 日 利 亚 政 府")
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
