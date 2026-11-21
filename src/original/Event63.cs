using EventsForDLC;
using UnityEngine;

public class Event63 : EventsSecond
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
		name = " 四 月 革 命";
		text = " 紧 急 新 闻 ！4 月27 日 ， 在 阿 富 汗 ， 由 于 权 力 不 稳 定 、 贫 困 和 人 民 对 逮 捕 左 翼 反 对 派 人 民 民 主 党 领 导 人 的 不 满 ， 人 民 民 主 党 事 先 策 划 了 一 场 军 事 政 变 。 人 民 对 革 命 表 示 欢 迎 。 执 政 后 ， 以 努 尔 · 穆 罕 默 德 · 塔 拉 基 为 首 的 阿 富 汗 民 主 共 和 国 开 始 了 社 会 主 义 的 建 设 和 对 苏 联 的 定 位 。 然 而 ， 阿 富 汗 的 未 来 仍 不 明 朗 ， 因 为 在 人 民 民 主 党 内 ， 人 民 派 和 旗 帜 派 之 间 仍 然 存 在 着 压 倒 性 的 分 裂 ， 从1966 年 到1977 年 ， 这 两 个 派 系 实 际 上 是 两 个 独 立 的 派 系 。 人 民 派 主 要 由 低 收 入 者 和 半 无 产 阶 级 组 成 ， 在 以 非 法 劳 动 为 重 点 的 反 对 活 动 中 ， 主 张 进 行 革 命 斗 争 ， 现 在 寻 求 组 织 国 家 向 社 会 主 义 和 无 产 阶 级 专 政 的 快 速 过 渡 。 旗 帜 派 在 反 对 党 的 几 年 里 把 法 律 和 议 会 斗 争 放 在 首 位 ， 现 在 代 表 着 逐 步 的 、 全 面 的 民 主 改 革 ， 并 且 普 遍 倾 向 于 改 良 主 义 ， 认 为 阿 富 汗 还 没 有 准 备 好 建 设 社 会 主 义 。 同 时 ， 中 国 共 产 党 对 苏 维 埃 在 该 地 区 的 影 响 力 扩 大 表 示 严 重 关 切 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 不 干 涉 阿 富 汗 事 务";
		if (GlobalScript.inst.gameState.data[9] >= 30)
		{
			button_text[1] = " 支 持 阿 富 汗 民 主 共 和 国 中 忠 于 我 们 的 反 对 派";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 帮 不 着 他 们";
		}
		if (GlobalScript.inst.gameState.data[9] >= 50 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[2] = " 建 立 关 系 并 支 持 人 民 派";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 他 们 将 不 会 合 作";
		}
		if (GlobalScript.inst.gameState.data[9] >= 60 && ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[3] = " 建 立 关 系 并 支 持 旗 帜 派";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 他 们 将 不 会 合 作";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 四 月 革 命";
		GlobalScript.inst.gameState.allcountries[12].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[12].SubGosstroy = 1;
		GlobalScript.inst.gameState.allcountries[12].prosov = true;
		switch (result_num)
		{
		case 0:
			text = " 我 们 没 有 回 应 四 月 革 命 和 阿 富 汗 民 主 共 和 国 的 事 件 。 当 然 ， 党 对 这 种 被 动 态 度 不 满 意 。 在 阿 富 汗 民 主 共 和 国 ， 在 革 命 期 间 获 得 权 威 的 人 民 派 ， 正 积 极 地 试 图 夺 走 旗 帜 派 的 权 力 。";
			GlobalScript.inst.gameState.data[1] -= 80;
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.empires[1].power += 30;
			GlobalScript.inst.gameState.data[46] = 10;
			GlobalScript.inst.gameState.data[48] = 150;
			GlobalScript.inst.gameState.data[49] = 100;
			break;
		case 1:
			text = " 中 国 共 产 党 领 导 层 对 苏 维 埃 势 力 的 扩 大 感 到 不 满 ， 决 定 向 忠 于 中 国 的 阿 富 汗 反 对 派 提 供 切 实 可 行 的 支 持 。 向 毛 派 、 左 翼 反 对 党 、 温 和 的 伊 斯 兰 主 义 者 和 其 他 反 对 势 力 提 供 武 器 和 秘 密 援 助 。 希 望 这 能 阻 止 苏 联 的 扩 张 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.empires[1].power += 30;
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.data[46] = 40;
			GlobalScript.inst.gameState.data[48] = 150;
			GlobalScript.inst.gameState.data[49] = 100;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			break;
		case 2:
			text = " 经 过 长 期 的 争 论 ， 我 们 决 定 与 阿 富 汗 新 政 府 建 立 关 系 ， 特 别 是 与 阿 富 汗 人 民 民 主 党 的 人 民 派 建 立 关 系 。 事 实 证 明 ， 这 比 我 们 想 象 的 要 简 单 ， 因 为 阿 富 汗 人 民 民 主 党 没 有 参 加 苏 中 论 战 ， 而 且 在 执 政 后 名 义 上 宣 布 了 不 结 盟 政 策 。 人 民 派 感 谢 我 们 的 支 持 ， 显 然 ， 他 们 利 用 他 们 日 益 增 长 的 力 量 向 旗 帜 派 施 加 压 力 ， 并 在 阿 富 汗 民 主 共 和 国 获 得 垄 断 权 力 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.empires[1].power += 30;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[46] = 10;
			GlobalScript.inst.gameState.data[48] = 180;
			GlobalScript.inst.gameState.data[49] = 100;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.influencePRC -= 10;
			break;
		case 3:
			text = " 经 过 长 期 的 争 论 ， 我 们 决 定 与 阿 富 汗 新 政 府 建 立 关 系 ， 特 别 是 与 阿 富 汗 人 民 民 主 党 的 旗 帜 派 建 立 关 系 。 事 实 证 明 ， 这 比 我 们 想 象 的 要 简 单 ， 因 为 阿 富 汗 人 民 民 主 党 没 有 参 加 苏 中 论 战 ， 而 且 在 执 政 后 名 义 上 宣 布 了 不 结 盟 政 策 。 在 我 们 的 支 持 下 ， 旗 帜 派 成 功 地 克 服 了 来 自 人 民 派 日 益 增 长 的 压 力 ， 特 别 地 ， 旗 帜 派 和 一 些 人 民 派 ， 减 缓 了 塔 拉 基 的 亲 密 盟 友 哈 菲 祖 拉 · 阿 明 的 晋 升 速 度 ， 他 不 再 受 到 党 的 信 任 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.empires[1].power += 30;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.data[46] = 10;
			GlobalScript.inst.gameState.data[48] = 140;
			GlobalScript.inst.gameState.data[49] = 140;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.influencePRC -= 10;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
