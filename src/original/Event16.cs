using EventsForDLC;
using UnityEngine;

public class Event16 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 泰 国 大 选";
		text = " 在1973 年 军 政 府 垮 台 ， 权 力 移 交 给 民 选 政 府 后 ， 泰 国 进 入 了 一 段 “ 混 乱 民 主 ” 的 时 期 。 共 产 党 在 印 支 半 岛 的 胜 利 滋 长 了 左 翼 情 绪 ， 由 目 前 同 时 进 行 游 击 战 和 合 法 活 动 的 毛 主 义 泰 国 共 产 党 领 导 。 他 们 反 对 右 翼 军 队 ， 地 主 和 其 他 保 王 党 ， 这 经 常 导 致 冲 突 。 在 这 种 情 况 ， 以 及 泰 国 经 济 危 机 爆 发 的 背 景 下 ， 民 主 总 理 克 立 · 巴 莫 被 迫 提 前 举 行 选 举 。 也 许 这 是 我 们 的 机 会 ， 如 果 不 引 诱 该 国 变 色 ， 那 么 至 少 要 动 荡 帝 国 主 义 在 印 度 支 那 的 堡 垒 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 不 干 涉";
		if (GlobalScript.inst.gameState.data[9] >= 20 || GlobalScript.inst.gameState.allcountries[34].stab == 1)
		{
			button_text[1] = " 支 持 泰 国 共 产 党 ， 创 建 一 个 左 派 与 民 主 人 士 的 联 盟";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 力 量 支 持 泰 国 共 产 党";
		}
		if (GlobalScript.inst.gameState.data[22] >= 20 && GlobalScript.inst.gameState.data[56] != 4)
		{
			button_text[2] = " 让 选 举 见 鬼 去 吧 ！ 我 们 最 好 给 泰 共 送 去 更 多 武 器 以 让 他 们 进 行 游 击 战";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 无 法 给 泰 国 共 产 党 更 多 的 武 器 装 备 了";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 泰 国 大 选";
		switch (result_num)
		{
		case 0:
			text = "1976 年 的 竞 选 活 动 伴 随 着 血 腥 的 街 头 冲 突 。 冲 突 造 成 了 大 约30 人 死 亡 。 社 尼 · 巴 莫 所 领 导 的 民 主 党 — 因 为 比 库 克 立 · 巴 莫 所 领 导 社 会 行 动 党 更 右 翼 — 从 而 获 得 了 大 多 数 的 选 票 。 右 翼 国 家 党 领 袖 邦 朋 · 阿 滴 列 讪 成 为 副 总 理 。 极 左 派 明 显 失 去 了 影 响 力 。";
			GlobalScript.inst.gameState.empires[0].power += 5;
			break;
		case 1:
			text = " 我 们 努 力 为 泰 共 提 供 实 质 性 支 持 同 时 和 各 种 中 左 翼 积 极 分 子 结 盟 ， 通 过 与 社 会 行 动 党 与 民 主 党 的 关 系 的 回 暖 ， 换 取 了 政 府 停 止 对 游 击 队 军 事 基 地 的 攻 击 。1976 年 的 竞 选 活 动 伴 随 着 血 腥 的 街 头 冲 突 。 通 过 与 民 主 党 和 泰 共 的 结 盟 ， 克 立 · 巴 莫 的 社 会 行 动 党 获 得 了 大 多 数 的 选 票 。 保 皇 党 政 府 以 及 官 员 们 对 左 派 的 蓬 勃 发 展 感 到 不 满 ， 形 势 正 在 升 温 。";
			GlobalScript.inst.gameState.data[9] -= 20;
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.data[41] = 100;
			party_change[0] = 0.5f;
			break;
		case 2:
			text = " 我 们 通 过 泰 共 向 游 击 队 援 助 了 更 多 的 武 器 来 无 视 选 举 ， 他 们 派 遣 新 的 军 队 袭 击 军 事 基 地 。 然 而 ， 泰 共 仍 然 无 法 控 制 这 个 国 家 哪 怕 一 个 地 区 。1976 年 的 竞 选 活 动 伴 随 着 血 腥 的 街 头 冲 突 。 冲 突 造 成 了 大 约30 人 死 亡 。 社 尼 · 巴 莫 所 领 导 的 民 主 党 — 因 为 比 库 克 立 · 巴 莫 领 导 社 会 行 动 党 更 右 翼 — 从 而 获 得 了 大 多 数 选 票 。 右 翼 国 家 党 领 袖 邦 朋 · 阿 滴 列 讪 成 为 副 总 理 。";
			GlobalScript.inst.gameState.data[22] -= 20;
			GlobalScript.inst.gameState.influencePRC += 10;
			party_change[2] = 1f;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
