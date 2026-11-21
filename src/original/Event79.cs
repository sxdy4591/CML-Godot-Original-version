using EventsForDLC;
using UnityEngine;

public class Event79 : EventsSecond
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
		name = " 紧 缩 政 策";
		text = "20 世 纪70 年 代 初 ， 罗 马 尼 亚 利 用 齐 奥 塞 斯 库 与 西 方 的 良 好 关 系 ， 积 极 向 国 际 货 币 基 金 组 织 借 款 ， 但 在20 世 纪70 年 代 的 能 源 危 机 后 ， 罗 马 尼 亚 作 为 一 个 石 油 出 口 大 国 深 受 打 击 且 债 务 缠 身 ， 这 使 罗 马 尼 亚 的 经 济 形 势 迅 速 恶 化 。 在 这 种 情 况 下 ， 罗 马 尼 亚 的 消 费 品 价 格 在20 世 纪70 年 代 末 开 始 上 涨 ， 现 在 齐 奥 塞 斯 库 决 定 转 向 紧 缩 政 策 ， 这 意 味 着 大 量 减 少 进 口 和 扩 大 出 口 ， 以 便 获 得 利 润 来 偿 还 债 务 。 这 不 可 避 免 地 限 制 了 该 国 居 民 的 用 水 和 用 电 ， 许 多 产 品 实 行 了 定 量 配 给 制 度 ， 这 一 制 度 严 重 地 损 害 了 罗 马 尼 亚 的 生 活 水 平 。";
		if (!GlobalScript.inst.gameState.relres)
		{
			text += " 齐 奥 塞 斯 库 是 苏 维 埃 社 会 主 义 阵 营 中 唯 一 与 中 国 保 持 良 好 关 系 的 统 治 者 ， 即 使 我 们 与 苏 联 断 绝 了 关 系 ， 帮 助 他 度 过 这 场 危 机 可 能 是 值 得 的 ？";
		}
		else if (GlobalScript.inst.gameState.relres)
		{
			text += " 齐 奥 塞 斯 库 是 苏 维 埃 社 会 主 义 阵 营 中 唯 一 与 中 国 保 持 良 好 关 系 的 统 治 者 ， 帮 助 他 度 过 这 场 危 机 可 能 是 值 得 的 ？";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.empires[1].relations > 500 && GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[0] = " 我 们 将 号 召 社 会 主 义 阵 营 共 同 帮 助 罗 马 尼 亚 （ 需 要10 百 万 元 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 社 会 主 义 阵 营 不 会 听 我 们 的";
		}
		button_text[1] = " 让 他 自 己 还 债 ， 这 不 是 我 们 的 问 题";
		if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[2] = " 向 罗 马 尼 亚 提 供 物 资 援 助 （ 需 要30 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 罗 马 尼 亚 不 值 得 我 们 做 这 么 多";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 紧 缩 政 策";
		switch (result_num)
		{
		case 0:
			text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 亲 自 致 电 勃 列 日 涅 夫 ， 说 罗 马 尼 亚 的 局 势 将 会 直 接 威 胁 罗 马 尼 亚 社 会 主 义 建 设 的 事 业 ， 以 及 整 个 苏 联 集 团 的 稳 定 ， 因 此 需 要 动 员 整 个 社 会 主 义 阵 营 来 解 决 这 一 问 题 。 苏 联 领 导 人 支 持 了 我 们 的 观 点 ， 结 果 举 行 了 一 场 经 互 会 的 特 别 会 议 ， 会 议 决 定 以 无 偿 货 币 援 助 和 罗 对 经 互 会 优 惠 进 出 口 条 件 的 形 式 ， 协 助 罗 马 尼 亚 偿 还 债 务 （ 当 然 ， 主 要 的 开 销 由 我 们 和 苏 联 承 担 ） 。 齐 奥 塞 斯 库 感 谢 了 我 们 和 其 他 经 互 会 成 员 对 他 的 帮 助 ， 并 已 经 宣 布 了 旨 在 放 松 紧 缩 政 策 的 调 整 。 当 然 ， 即 使 是 小 规 模 的 紧 缩 政 策 也 使 罗 马 尼 亚 公 民 感 到 不 快 ， 但 没 什 么 事 情 是 齐 奥 塞 斯 库 应 付 不 了 的 。 根 据 我 们 的 估 计 ， 在 这 样 的 速 度 下 他 在80 年 代 末 可 以 还 清 债 务 ， 并 且 不 会 对 经 济 和 生 活 质 量 产 生 严 重 影 响 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.empires[1].relations += 150;
			GlobalScript.inst.gameState.allcountries[5].Torg = true;
			break;
		case 1:
			text = " 尽 管 这 些 措 施 具 有 盈 利 能 力 ， 但 它 们 已 经 导 致 罗 马 尼 亚 经 济 增 长 下 降 和 生 活 水 平 下 降 ， 这 导 致 罗 马 尼 亚 人 民 普 遍 不 满 。 齐 奥 塞 斯 库 仍 然 和 他 们 相 处 得 很 好 ， 但 谁 知 道 这 会 怎 样 结 束 … …";
			GlobalScript.inst.gameState.empires[1].power -= 20;
			break;
		case 2:
			text = " 我 们 利 用 与 罗 马 尼 亚 的 良 好 关 系 ， 向 齐 奥 塞 斯 库 提 供 了 大 规 模 的 财 政 援 助 ， 以 减 轻 债 务 负 担 ， 他 欣 然 接 受 了 这 一 提 议 。 我 们 不 得 不 付 出 很 多 资 金 ， 但 最 终 他 宣 布 对 旨 在 放 松 紧 缩 政 策 的 调 整 。 当 然 ， 即 使 是 小 规 模 的 紧 缩 措 施 也 使 罗 马 尼 亚 公 民 感 到 不 快 ， 但 没 什 么 事 情 是 齐 奥 塞 斯 库 应 付 不 了 的 。 他 利 用 进 口 机 会 扩 大 与 我 们 的 贸 易 。";
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.data[8] -= 300;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[5].Torg = true;
			GlobalScript.inst.gameState.allcountries[5].proprc = true;
			GlobalScript.inst.gameState.allcountries[5].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[5].SubGosstroy = 10;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
