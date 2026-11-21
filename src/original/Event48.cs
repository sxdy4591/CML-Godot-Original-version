using EventsForDLC;
using UnityEngine;

public class Event48 : EventsSecond
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
		name = " 政 变 的 延 续";
		text = " 四 月 革 命 后 ， 人 民 民 主 党 面 临 着 许 多 困 难 ， 在 快 速 壮 大 的 人 民 派 中 ， 人 民 民 主 党 创 始 人 塔 拉 基 和 他 的 学 生 阿 明 之 间 的 斗 争 已 经 开 始 。 阿 明 是 激 进 政 治 的 支 持 者 ， 赞 同 对 封 建 残 余 势 力 的 不 懈 斗 争 和 对 政 治 对 手 的 严 厉 镇 压 。 同 时 ， 作 为 一 个 狂 热 的 普 什 图 民 族 主 义 者 （ 注 释- 阿 富 汗 的 主 要 民 族 ） ， 他 在 很 大 程 度 上 阻 碍 了 人 民 民 主 党 的 民 族 政 策 ， 试 图 将 权 力 集 中 在 自 己 手 中 ， 他 在 人 民 派 和 旗 帜 派 之 间 维 持 了 分 裂 。 尽 管 苏 联 领 导 人 一 再 警 告 塔 拉 基 阿 明 的 阴 谋 计 划 ， 但 他 直 到 最 后 一 刻 才 注 意 到 。9 月14 日 ， 在 看 望 塔 拉 基 期 间 ， 阿 明 首 次 遭 到 袭 击 （ 尚 不 清 楚 是 真 的 还 是 由 阿 明 本 人 策 划 的 ） ，9 月16 日 ， 阿 明 在 人 民 民 主 党 中 央 委 员 会 全 体 会 议 上 解 除 了 塔 拉 基 的 职 务 ， 此 前 他 曾 与 驻 地 的 忠 诚 部 队 隔 离 。 值 得 注 意 的 是 ， 尽 管 阿 明 试 图 与 苏 联 保 持 良 好 关 系 ， 但 根 据 我 们 的 数 据 ， 他 不 完 全 反 对 与 中 国 建 立 密 切 关 系 ， 这 可 能 是 我 们 的 机 会 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 最 好 还 是 不 要 介 入";
		button_text[1] = " 与 阿 富 汗 民 主 共 和 国 秘 密 建 立 友 好 关 系 （ 需 要2 百 万 元 预 算 ）";
		if (GlobalScript.inst.gameState.relres)
		{
			button_text[2] = " 我 们 不 信 任 他 … 最 好 秘 密 同 意 苏 联 撤 换 他 ， 也 许 我 们 会 从 新 政 府 那 里 得 到 一 些 东 西";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 不 与 苏 联 勾 结 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 政 变 的 延 续";
		GlobalScript.inst.gameState.allcountries[12].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[12].SubGosstroy = 10;
		GlobalScript.inst.gameState.allcountries[12].Vyshi = false;
		switch (result_num)
		{
		case 0:
			text = " 阿 明 上 台 后 ， 针 对 他 目 前 和 潜 在 的 政 治 对 手 ， 发 起 了 广 泛 的 肃 清 运 动 。 尽 管 有 “ 消 灭 封 建 领 主 ” 的 政 策 ， 但 在 这 一 政 策 下 ， 不 仅 仅 是 在 “ 消 灭 封 建 领 主 ” 。 尽 管 它 假 装 一 切 都 很 好 ， 但 苏 联 似 乎 对 政 变 有 些 不 满 。";
			break;
		case 1:
			text = " 阿 明 上 台 后 ， 针 对 他 目 前 和 潜 在 的 政 治 对 手 ， 发 起 了 广 泛 的 肃 清 运 动 。 尽 管 有 “ 消 灭 封 建 领 主 ” 的 政 策 ， 但 在 这 一 政 策 下 ， 不 仅 仅 是 在 “ 消 灭 封 建 领 主 ” 。 尽 管 它 假 装 一 切 都 很 好 ， 但 苏 联 似 乎 对 政 变 有 些 不 满 。 我 们 的 秘 密 大 使 和 特 勤 处 与 阿 明 建 立 了 联 系 ， 阿 明 对 新 盟 友 的 获 得 非 常 满 意 。 然 而 ， 与 此 同 时 ， 他 开 始 要 求 我 们 向 阿 富 汗 提 供 物 质 援 助 。";
			GlobalScript.inst.gameState.data[8] -= 20;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			break;
		case 2:
			text = " 继 续 我 们 与 苏 联 的 友 好 关 系 ， 并 不 真 正 信 任 阿 明 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 与 苏 联 就 阿 明 政 权 对 民 主 共 和 国 的 危 险 和 清 除 他 的 必 要 性 进 行 秘 密 谈 判 ， 尽 管 中 央 委 员 会 个 别 成 员 提 出 抗 议 。 但 苏 联 领 导 人 对 我 们 愿 意 这 样 “ 结 束 ” 一 个 潜 在 盟 友 感 到 非 常 惊 讶 ， 而 且 似 乎 并 不 完 全 信 任 我 们 ， 但 总 的 来 说 ， 他 们 非 常 高 兴 。 我 们 将 等 待 这 些 事 件 的 进 一 步 发 展 。 阿 明 上 台 后 ， 针 对 他 目 前 和 潜 在 的 政 治 对 手 ， 发 起 了 广 泛 的 肃 清 运 动 。 尽 管 有 “ 消 灭 封 建 领 主 ” 的 政 策 ， 但 在 这 一 政 策 下 ， 不 仅 仅 是 在 “ 消 灭 封 建 领 主 ” 。 尽 管 它 假 装 一 切 都 很 好 ， 但 苏 联 似 乎 对 政 变 有 些 不 满 。 我 们 的 秘 密 大 使 和 特 勤 处 与 阿 明 建 立 了 联 系 ， 阿 明 对 新 盟 友 的 获 得 非 常 满 意 。 然 而 ， 与 此 同 时 ， 他 开 始 要 求 我 们 向 阿 富 汗 提 供 物 质 援 助 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[49] = 110;
			GlobalScript.inst.gameState.empires[1].relations += 70;
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.SOV_PRC_PartiesConnection += 40;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
