using EventsForDLC;
using UnityEngine;

public class Event22 : EventsSecond
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
		name = " 天 安 门 事 件";
		text = " 中 国 共 产 党 对 周 恩 来 纪 念 运 动 的 多 次 压 制 反 而 在 人 民 群 众 里 引 起 了 反 对 。 在 正 值 清 明 节 的 四 月 四 日 ， 北 京 市 民 带 着 纪 念 周 恩 来 的 挽 联 走 进 天 安 门 广 场 到 人 民 英 雄 纪 念 碑 前 。 日 落 前 有 大 约 二 百 万 人 前 来 悼 念 ， 挽 联 堆 了 二 十 米 高 。 此 时 中 共 中 央 政 治 局 紧 急 会 议 在 毛 主 席 主 持 下 召 开 ， 会 议 通 过 了 镇 压 游 行 的 决 议 ， 你 和 北 京 市 长 吴 德 被 要 求 督 办 此 事 。 趁 夜 你 清 理 了 挽 联 ， 但 是 第 二 天 早 上 来 继 续 悼 念 的 人 民 要 求 归 还 它 们 ， 同 时 已 经 有 人 号 召 推 翻 毛 泽 东 与 江 青 的 领 导 并 回 到 真 正 的 马 克 思 列 宁 主 义 革 命 路 线 上 来 。 你 准 备 在 事 态 难 以 控 制 后 镇 压 ， 而 汪 东 兴 和 叶 剑 英 要 求 你 尽 快 下 令 驱 散 群 众 。 但 是 四 人 帮 和 吴 德 看 起 来 并 不 想 动 手 ， 而 是 希 望 以 和 平 的 方 式 解 决 。 但 无 论 如 何 ， 决 定 权 在 你 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 在 军 警 帮 助 下 驱 散 骚 乱";
		button_text[2] = " 呼 吁 所 有 人 离 开 ， 拉 封 锁 线 直 到 他 们 走 人";
		if (GlobalScript.inst.gameState.data[88] >= 0)
		{
			button_text[1] = " 呼 吁 所 有 人 离 开 并 驱 散 其 他 人";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 人 民 不 想 离 去 ！";
		}
		if (GlobalScript.inst.gameState.data[88] >= 2)
		{
			button_text[2] = " 呼 吁 所 有 人 离 开 ， 拉 封 锁 线 直 到 他 们 走 人";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 人 民 不 想 离 去 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 天 安 门 事 件";
		switch (result_num)
		{
		case 0:
		{
			text = " 晚 上 ， 所 属 北 京 公 安 和 驻 军 的 单 位 被 部 署 到 了 广 场 ， 并 与 抗 议 人 群 发 生 了 冲 突 。 由 于 抗 议 规 模 的 庞 大 ， 许 多 士 兵 和 警 察 以 及 更 多 的 抗 议 者 受 伤 ， 一 些 抗 议 者 丧 生 。 最 终 ， 军 队 成 功 驱 逐 了 抗 议 者 ， 超 过2000 人 被 逮 捕 。 如 此 大 规 模 的 镇 压 令 人 民 和 国 际 社 会 感 到 失 望 ， 但 最 艰 难 的 时 刻 似 乎 已 经 过 去 了 。 在 天 安 门 广 场 所 发 生 的 事 情 被 官 方 定 性 为 一 场 反 革 命 暴 动 ， 邓 小 平 对 此 应 负 主 要 责 任 。 在 毛 泽 东 的 指 示 下 ， 政 治 局 撤 销 了 邓 小 平 党 内 外 一 切 职 务 ， 留 党 察 看 。 此 刻 ， 邓 小 平 正 在 广 州 ， 被 他 的 老 战 友 ， 广 州 军 区 司 令 员 许 世 友 所 保 护 。";
			GlobalScript.inst.gameState.data[3] -= 250;
			GlobalScript.inst.gameState.data[4] -= 200;
			GlobalScript.inst.gameState.data[6] += 60;
			GlobalScript.inst.gameState.data[1] += 100;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality -= 100;
				}
				else if (politic3.traits[0] > 0)
				{
					politic3.loyality -= 80;
				}
			}
			GlobalScript.inst.gameState.politics[12].power -= 100;
			break;
		}
		case 1:
		{
			text = " 晚 上 六 点 半 ， 吴 德 通 过 扩 音 器 呼 吁 人 群 离 开 广 场 ， 许 多 人 照 做 了 ， 但 还 是 一 千 人 左 右 留 下 。 晚 上 ， 市 警 察 分 队 和 北 京 驻 防 部 队 进 入 广 场 ， 执 行 驱 散 示 威 人 群 的 任 务 。 尽 管 使 用 了 暴 力 手 段 ， 但 是 没 有 人 员 死 亡 ， 有 大 约700 人 被 捕 。 在 接 下 来 的 几 天 里 ， 天 安 门 广 场 继 续 处 于 军 队 和 警 察 的 控 制 之 下 。 看 来 我 们 设 法 用 比 较 不 血 腥 暴 力 的 方 法 压 制 住 了 运 动 。 天 安 门 事 件 被 官 方 宣 布 为 反 革 命 事 件 ， 邓 小 平 对 此 应 负 主 要 责 任 。 在 毛 泽 东 的 建 议 下 ， 中 共 中 央 政 治 局 免 去 了 邓 小 平 的 所 有 职 务 ， 但 仍 保 留 他 的 中 共 党 员 资 格 。 邓 小 平 本 人 此 时 在 广 州 老 战 友 、 广 州 军 区 司 令 员 许 世 友 的 保 护 下 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[4] -= 150;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality -= 50;
				}
			}
			GlobalScript.inst.gameState.politics[12].power += 100;
			break;
		}
		case 2:
		{
			text = " 晚 上 六 点 半 ， 吴 德 通 过 扩 音 器 呼 吁 人 群 离 开 广 场 ， 许 多 人 照 做 了 ， 但 还 是 一 千 人 左 右 留 下 。 晚 上 ， 市 警 察 分 队 和 北 京 驻 防 部 队 进 入 广 场 ， 对 示 威 者 进 行 了 封 锁 。 在 一 夜 的 封 锁 后 ， 虽 然 一 些 示 威 者 离 开 了 ， 但 还 有 一 些 人 试 图 突 破 封 锁 ， 他 们 最 终 被 逮 捕 了 。 而 那 些 留 下 来 的 人 ， 警 察 也 没 有 任 何 异 议 地 将 他 们 逮 捕 了 。 抗 议 活 动 被 以 最 低 限 度 的 武 力 镇 压 了 。 天 安 门 事 件 被 官 方 宣 布 为 反 革 命 事 件 ， 邓 小 平 对 此 应 负 主 要 责 任 。 在 毛 泽 东 的 建 议 下 ， 中 共 中 央 政 治 局 免 去 了 邓 小 平 的 所 有 职 务 ， 但 仍 保 留 他 的 中 共 党 员 资 格 。 邓 小 平 本 人 此 时 在 广 州 老 战 友 、 广 州 军 区 司 令 员 许 世 友 的 保 护 下 。";
			GlobalScript.inst.gameState.data[4] -= 100;
			GlobalScript.inst.gameState.data[1] -= 50;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality += 100;
				}
				if (politic.traits[0] == 20)
				{
					politic.loyality += 80;
				}
			}
			GlobalScript.inst.gameState.politics[12].power -= 100;
			break;
		}
		}
	}
}
