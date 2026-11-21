using EventsForDLC;
using UnityEngine;

public class Event77 : EventsSecond
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
		name = " 往 脸 上 吐 口 水 ， 在 下 巴 上 打 一 拳 ， 头 上 一 颗 子 弹";
		text = " 我 们 的 居 民 从 阿 尔 巴 尼 亚 传 达 了 有 趣 的 信 息 — — 阿 尔 巴 尼 亚 领 导 人 恩 维 尔 · 霍 查 和 党 和 国 家 第 二 号 人 物 ， 总 理 穆 罕 默 德 · 谢 胡 之 间 似 乎 存 在 严 重 分 歧 。 很 长 一 段 时 间 以 来 ， 他 是 霍 查 最 亲 密 的 伙 伴 ， 并 通 过 西 古 里 米 的 力 量 确 保 了 国 家 的 稳 定 ， 亲 自 监 督 了20 世 纪40 年 代 中 期 的 几 次 镇 压 反 动 派 叛 乱 ， 并 以 这 句 话 闻 名 ： “ 谁 反 对 我 们 的 领 导 地 位 ， 就 往 他 脸 上 吐 口 水 ， 在 下 巴 上 打 一 拳 ， 而 如 果 必 要 的 话 ， 在 头 上 赏 一 颗 子 弹 ” ， 这 甚 至 （ 在 一 个 消 极 的 背 景 下 ） 在 苏 联 共 产 党 第 二 十 二 次 代 表 大 会 上 被 引 用 。 然 而 ， 在 赫 鲁 晓 夫 的 去 斯 大 林 化 和 阿 尔 巴 尼 亚 与 苏 联 和 社 会 主 义 阵 营 分 裂 的 背 景 下 ， 阿 尔 巴 尼 亚 的 经 济 开 始 因 这 种 孤 立 而 遭 遇 困 难 。 在 劳 动 党 中 ， 越 来 越 多 的 人 倾 向 于 恢 复 与 苏 联 、 南 斯 拉 夫 甚 至 意 大 利 的 关 系 ， 显 然 ， 谢 胡 就 是 其 中 之 一 ， 他 被 迫 解 决 阿 尔 巴 尼 亚 经 济 的 紧 急 问 题 。 他 比 霍 查 更 实 际 和 更 倾 向 于 谈 判 ， 他 可 能 是 一 个 有 用 的 盟 友 。";
		if (!GlobalScript.inst.gameState.allcountries[20].proprc)
		{
			text += " 此 外 ， 他 是 与 中 华 人 民 共 和 国 结 盟 的 支 持 者 ， 他 显 然 很 乐 意 恢 复 我 们 之 间 断 绝 的 关 系 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (((GlobalScript.inst.gameState.data[56] < 4 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)) && GlobalScript.inst.gameState.data[9] >= 80)
		{
			button_text[0] = " 帮 助 谢 胡 组 织 一 场 政 变 （ 需 要8 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 足 够 的 资 源";
		}
		button_text[1] = " 这 是 他 们 自 己 的 问 题";
		if (GlobalScript.inst.gameState.allcountries[20].proprc || (GlobalScript.inst.gameState.allcountries[20].econ && GlobalScript.inst.gameState.data[60] == 0))
		{
			button_text[2] = " 我 们 支 持 霍 查";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 为 什 么 我 们 要  支 持 背 叛 我 们 的 白 眼 狼 霍 查 ？";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 往 脸 上 吐 口 水 ， 在 下 巴 上 打 一 拳 ， 头 上 一 颗 子 弹";
		switch (result_num)
		{
		case 0:
			text = " 谢 胡 利 用 手 中 的 国 家 机 关 和 西 古 里 米 ， 成 功 地 动 员 了 他 的 支 持 者 ， 孤 立 了 霍 查 ， 然 后 召 开 了 一 次 阿 尔 巴 尼 亚 劳 动 党 中 央 委 员 会 特 别 会 议 ， 他 说 ， 由 于 医 疗 原 因 ， 第 一 书 记 将 在 一 段 时 间 内 不 能 履 行 他 的 职 责 。 他 的 对 手 最 多 只 能 放 弃 他 们 在 党 和 政 府 中 的 职 位 ， 但 他 们 中 的 许 多 人 最 终 被 关 进 了 西 古 里 米 监 狱 ， 或 者 在 可 疑 的 情 况 下 死 亡 。 很 快 就 有 消 息 称 ， 霍 查 死 于 病 情 加 重 ， 此 后 ， 谢 胡 毫 不 困 难 地 担 任 阿 尔 巴 尼 亚 劳 动 党 中 央 第 一 书 记 。 他 已 经 开 始 与 南 斯 拉 夫 、 苏 联 和 社 会 主 义 阵 营 国 家 进 行 谨 慎 的 谈 判 ， 这 些 国 家 似 乎 欢 迎 领 导 层 的 这 种 转 变 ， 尽 管 阿 尔 巴 尼 亚 的 国 内 政 策 没 有 什 么 改 变 。";
			if (!GlobalScript.inst.gameState.allcountries[20].proprc)
			{
				text += " 同 时 ， 谢 胡 恢 复 了 与 中 国 的 关 系 ， 建 立 贸 易 ， 并 邀 请 我 们 的 顾 问 到 该 国 来 。";
			}
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[9] -= 80;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.data[60] = 1;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.allcountries[20].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[20].Torg = true;
			GlobalScript.inst.gameState.allcountries[20].proprc = true;
			break;
		case 1:
			text = " 结 果 ， 谢 胡 与 霍 查 的 关 系 继 续 恶 化 ，1981 年12 月18 日 ， 谢 胡 被 宣 布 自 杀 ， 之 后 他 被 指 控 为 叛 国 和 为 美 国 、 苏 联 和 南 斯 拉 夫 进 行 谍 报 活 动 。 他 的 总 理 职 位 被 缺 乏 主 动 性 和 忠 诚 的 阿 迪 尔 · 查 尔 查 尼 所 取 代 。";
			GlobalScript.inst.gameState.empires[1].power -= 10;
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 0;
			break;
		case 2:
			text = " 结 果 ， 谢 胡 与 霍 查 的 关 系 继 续 恶 化 ，1981 年12 月18 日 ， 谢 胡 被 宣 布 自 杀 ， 之 后 他 被 指 控 为 叛 国 和 为 美 国 、 苏 联 和 南 斯 拉 夫 进 行 谍 报 活 动 。 他 的 总 理 职 位 被 缺 乏 主 动 性 和 忠 诚 的 阿 迪 尔 · 查 尔 查 尼 所 取 代 。 在 这 段 时 间 里 ， 我 们 一 直 支 持 霍 查 的 行 动 ， 欢 迎 阿 尔 巴 尼 亚 从 间 谍 谢 胡 手 中 解 放 出 来 ， 为 此 ， 我 们 得 到 了 地 拉 那 的 感 谢 。";
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 0;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
