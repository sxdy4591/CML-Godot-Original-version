using EventsForDLC;
using UnityEngine;

public class Event72 : EventsSecond
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
		name = " 拯 救 落 水 者";
		text = " 在1977 年 赢 得 印 度 大 选 后 ， 印 度 人 民 党 ， 实 际 上 是 从 社 会 主 义 者 到 民 族 自 由 主 义 者 的 多 个 政 党 的 联 盟 ， 面 临 着 许 多 困 难 。 最 初 ， 他 们 为 了 把 英 迪 拉 · 甘 地 和 国 大 党 从 权 力 中 除 名 而 团 结 起 来 ， 现 在 ， 在 掌 权 之 后 ， 人 民 党 受 到 了 内 部 阴 谋 的 困 扰 ， 这 实 际 上 使 它 的 工 作 陷 入 瘫 痪 。 以 这 种 速 度 ， 甘 地 将 不 可 避 免 地 赢 得 即 将 在1980 年1 月 举 行 的 选 举 ， 这 就 结 束 了 人 民 党 在 改 善 我 们 与 印 度 关 系 方 面 取 得 的 成 功 。 如 果 我 们 帮 助 反 对 党 并 对 其 施 加 影 响 ， 那 么 我 们 可 以 帮 助 它 巩 固 和 保 住 权 力 …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 祝 你 好 运 ， 心 情 愉 快";
		if (GlobalScript.inst.gameState.data[91] == 1)
		{
			button_text[1] = " 支 持 人 民 党 左 翼 （ 需 要6 特 工 网 络 ，10 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 人 民 党 不 会 听 我 们 的";
		}
		if (GlobalScript.inst.gameState.data[91] == 1)
		{
			button_text[2] = " 支 持 人 民 党 右 翼 （ 需 要6 特 工 网 络 ，10 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 人 民 党 不 会 听 我 们 的";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 拯 救 落 水 者";
		switch (result_num)
		{
		case 0:
			if (GlobalScript.inst.gameState.data[91] == 1)
			{
				text = " 人 民 党 在 印 度 人 民 中 广 受 欢 迎 ， 对 此 ， 所 有 分 析 人 士 都 预 测 他 们 未 来 前 途 无 量： 人 民 党 将 取 代 国 大 党 ， 成 为 制 霸 印 度政 坛 十 余 年 的 主 要 政 党 。 但 由 于 内 部 争 论 和 阴 谋 的 压 力 ， 人 民 党 总 理 莫 拉 尔 吉 · 德 赛 不 得 不 辞 去 总 理 职 务 。 联 盟 本 身 也 分 崩 离 析 ， 该 国 也 由 此 产 生 了 大 片 政 治 真 空 。 接 替 他 的 查 兰 · 辛 格 可 能 会 坚 持 到1980 年 的 选 举 ， 此 后 ， 囊 括 国 大 党 、 左 派 人 民 党 与 印 度 共 产 党 的 联 盟 预 计 将 赢 得 大 选， 而 甘 地 将 再 度 掌 权 。";
			}
			else
			{
				text = " 最 后 ， 在 内 部 争 论 和 阴 谋 的 压 力 下 ， 人 民 党 总 理 莫 拉 尔 吉 · 德 赛 辞 去 总 理 职 务 。 接 替 他 的 查 兰 · 辛 格 可 能 会 坚 持 到1980 年 的 选 举 ， 此 后 甘 地 将 再 次 取 代 他 。";
			}
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.allcountries[19].Torg = false;
			GlobalScript.inst.gameState.allcountries[19].prosov = true;
			break;
		case 1:
			text = " 我 们 决 定 支 持 人 民 党 内 部 的 左 翼 ， 为 此 ， 我 们 的 外 交 官 先 是 说 服 了 党 首 莫 拉 尔 吉 . 德 赛 禁 止 双 重 党 籍 的 必 要 性 。 德 赛 很 快 决 定 废 除 双 重 党 籍 的 同 时 开 除 来 自 主 要 是 联 合 社 会 党 的 成 员 。 然 而 ， 我 们 的 特 工 积 极 做 出 了 行 动 以 支 持 这 个 反 国 大 党 大 帐 篷 下 的 左 翼 成 员 ， 德 赛 在 党 大 会 上 遭 到 指 控 而 被 罢 免 ， 从 而 事 实 上 支 持 左 翼 派 系 的 夺 取 。 新 的 领 导 人 乔 治 . 费 尔 南 德 斯 统 合 了 除 了 纳 萨 尔 派 以 外 的 左 翼 和 令 人 惊 讶 的 相 当 一 大 部 分 自 由 派 ， 推 行 人 民 党 创 始 人 J P 纳 拉 扬 的 “ 全 面 革 命 ” - 发 展 生 产 力 ， 社 会 革 命 ， 政 策 ， 看 起 来 将 能 赢 得 下 一 场 选 举 。";
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.empires[0].relations -= 80;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.allcountries[19].SubGosstroy = 3;
			break;
		case 2:
			text = " 我 们 决 定 支 持 人 民 党 内 部 的 右 翼 ， 为 此 ， 我 们 的 外 交 官 先 是 说 服 了 党 首 莫 拉 尔 吉 . 德 赛 禁 止 双 重 党 籍 的 必 要 性 。 德 赛 很 快 决 定 废 除 双 重 党 籍 的 同 时 开 除 来 自 主 要 是 联 合 社 会 党 的 成 员 。 我 们 的 特 工 积 极 做 出 了 行 动 以 支 持 这 个 反 国 大 党 大 帐 篷 下 的 右 翼 民 族 主 义 者 和 自 由 主 义 者 ， 以 维 持 德 赛 总 理 政 府 的 稳 定 。 在 乔 治 . 费 尔 南 德 斯 因 为 与 C I A 合 作 的 丑 闻 暴 露 后 ， 人 民 党 左 派 被 彻 底 摧 毁 。 人 民 党 很 快 开 始 大 规 模 私 有 化 政 策 以 及 进 行 削 减 多 余 的 公 共 支 出 改 革 ， 并 且 通 过 社 会 保 守 主 义 和 印 度 民 族 主 义 吸 引 “ 藏 红 花 ” 票 仓 群 ， 看 起 来 将 能 赢 得 下 一 场 选 举 。";
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.empires[0].relations -= 80;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.allcountries[19].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[19].SubGosstroy = 12;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
