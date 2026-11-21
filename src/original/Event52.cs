using EventsForDLC;
using UnityEngine;

public class Event52 : EventsSecond
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
		name = " 善 邻 难 做";
		text = " 从 阿 富 汗 反 政 府 示 威 活 动 和 民 主 共 和 国 政 府 的 回 应 开 始 ， 许 多 伊 斯 兰 激 进 分 子 、 恐 怖 分 子 和 阿 訇 逃 往 巴 基 斯 坦 ， 在 那 里 他 们 与 当 地 的 “ 同 事 ” 结 盟 。 随 后 ， 在 阿 富 汗 武 装 暴 乱 开 始 后 ， 难 民 涌 入 巴 基 斯 坦 ， 在 那 里 成 立 的 伊 斯 兰 恐 怖 组 织 的 等 待 下 。 巴 基 斯 坦 本 身 并 没 有 采 取 特 别 的 措 施 来 解 决 这 些 问 题 ， 似 乎 布 托 在 这 方 面 有 足 够 的 问 题 ， 但 为 他 提 供 地 下 援 助 ， 以 制 止 这 种 暴 行 是 值 得 的 吗 ？ 另 一 方 面 ， 美 国 对 通 过 巴 基 斯 坦 帮 助 阿 富 汗 叛 军 的 可 能 性 非 常 感 兴 趣 ， 如 果 布 托 不 能 以 任 何 方 式 与 美 国 达 成 一 致 ， 那 么 他 可 以 与 我 们 达 成 一 致 。 通 过 巴 基 斯 坦 运 送 美 国 武 器 和 顾 问 ， 我 们 可 以 “ 削 减 ” 美 国 人 的 钱 和 打 击 苏 联 社 会 帝 国 主 义 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 让 巴 基 斯 坦 自 己 处 理";
		button_text[1] = " 向 巴 基 斯 坦 提 供 援 助 ， 帮 助 巡 逻 边 境 和 抓 捕 伊 斯 兰 主 义 者";
		if (GlobalScript.inst.gameState.ingamewars[5].ussr_place != 1 && !GlobalScript.inst.gameState.allcountries[1].isSEV)
		{
			button_text[2] = " 和 美 国 谈 判";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 不 要 帮 助 反 动 派 ！";
		}
		if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 1)
		{
			button_text[3] = " 搞 这 些 干 嘛 ？ 不 如 在 巴 基 斯 坦 为 阿 富 汗 毛 派 起 义 者 组 织 基 地 （ 需 要5 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 不 能 帮 助 阿 富 汗 民 主 共 和 国 的 毛 派 起 义 者";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 善 邻 难 做 …";
		switch (result_num)
		{
		case 0:
			text = " 一 切 顺 其 自 然 。 巴 基 斯 坦 当 局 压 制 激 进 的 宗 教 宣 传 ， 且 不 允 许 过 境 者 携 带 武 器 通 过 巴 阿 边 境 检 查 站 ， 但 他 们 既 没 有 实 力 也 没 有 意 愿 去 实 现 这 两 点 。";
			break;
		case 1:
			text = " 我 们 明 确 地 提 醒 布 托 ， 现 在 是 时 候 制 止 在 边 界 上 猖 獗 的 恐 怖 分 子 ， 并 派 遣 我 们 的 特 工 和 军 队 帮 助 他 ， 我 们 和 巴 基 斯 坦 开 始 在 边 界 巡 逻 并 追 查 激 进 的 伊 斯 兰 主 义 组 织 。 我 必 须 说 ， 行 动 是 成 功 的 — — 伊 斯 兰 主 义 者 没 有 料 到 巴 基 斯 坦 会 做 出 如 此 严 厉 的 反 应 ， 他 们 几 乎 都 毫 无 防 备 。 原 教 旨 主 义 者 们 现 在 发 现 自 己 没 有 能 力 像 之 前 一 样 “ 援 助 ” 阿 富 汗 兄 弟 了 。 祝 他 们 在 挖 通 过 边 境 线 下 的 地 道 时 耗 死 自 己 。";
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.data[9] -= 40;
			GlobalScript.inst.gameState.data[22] -= 50;
			if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 1)
			{
				GlobalScript.inst.gameState.data[94] = 1;
				break;
			}
			GlobalScript.inst.gameState.ingamewars[5].infl1 += 100;
			GlobalScript.inst.gameState.ingamewars[5].infl2 -= 100;
			break;
		case 2:
			text = " 在 与 美 国 达 成 默 契 协 议 并 劝 说 布 托 不 要 妨 碍 我 们 之 后 ， 我 们 开 始 将 美 国 武 器 和 顾 问 运 送 到 巴 基 斯 坦- 阿 富 汗 边 境 ， 将 它 们 移 交 到 圣 战 者 那 里 ， 圣 战 者 半 合 法 的 越 过 边 境 ， 前 往 阿 富 汗 。 这 大 大 帮 助 了 阿 富 汗 反 政 府 武 装 对 抗 阿 富 汗 民 主 共 和 国 的 进 程 ， 另 一 方 面 ， 美 国 的 资 金 以 “ 中 介 服 务 ” 的 名 义 到 了 我 们 的 口 袋 里 。";
			GlobalScript.inst.gameState.data[8] += 30;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.ingamewars[5].infl1 -= 80;
			GlobalScript.inst.gameState.ingamewars[5].infl2 += 80;
			GlobalScript.inst.gameState.empires[1].relations -= 120;
			GlobalScript.inst.gameState.data[94] = 2;
			break;
		case 3:
			text = " 我 们 继 续 向 阿 富 汗 的 毛 派 起 义 者 提 供 援 助 ， 驱 赶 伊 斯 兰 教 徒 离 开 边 境 ， 为 毛 派 组 织 训 练 营 和 补 给 中 心 ， 在 那 里 我 们 提 供 武 器 并 派 遣 教 官 ， 这 对 这 些 起 义 者 有 很 大 帮 助 。 巴 基 斯 坦 当 局 还 同 意 我 们 不 受 阻 碍 地 向 阿 富 汗 派 遣 人 员 和 武 器 。 当 然 ， 我 们 必 须 为 建 立 这 样 一 个 基 础 设 施 而 付 出 代 价 ， 这 同 时 使 军 队 的 供 应 紧 张 ， 苏 联 和 美 国 对 此 也 并 不 满 意 。";
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.data[22] -= 100;
			GlobalScript.inst.gameState.data[6] += 30;
			GlobalScript.inst.gameState.ingamewars[5].infl1 += 10;
			GlobalScript.inst.gameState.ingamewars[5].infl2 -= 10;
			GlobalScript.inst.gameState.data[94] = 3;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
