using EventsForDLC;
using UnityEngine;

public class Event34 : EventsSecond
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
		name = " 我 敌 人 的 敌 人";
		text = " 在 四 人 帮 倒 台 后 ， 你 在 名 义 上 掌 握 了 最 高 权 力 ， 但 事 实 上 你 必 须 与 那 些 帮 助 你 得 到 权 力 的 人 分 享 它 — — 在 文 化 大 革 命 期 间 为 邓 小 平 辩 护 ， 也 是 一 个 坚 定 的 改 革 派 的 现 任 国 防 部 长 叶 剑 英 ， 还 有 李 先 念 ， 更 温 和 些 ， 但 也 支 持 改 革 派 。 另 一 方 面 ， 你 最 忠 实 的 保 守 派 支 持 者 有 三 位 — — 纪 登 奎 、 汪 东 兴 和 陈 锡 联 。 如 果 你 不 想 被 架 空 ， 你 就 应 该 打 击 改 革 派 ， 并 提 拔 你 的 支 持 者 ， 然 而 ， 这 种 武 断 的 行 为 会 在 党 内 引 起 不 满 吗 ？ 另 一 方 面 ， 如 果 你 专 注 于 改 革 ， 与 改 革 派 进 行 谈 判 可 能 会 更 有 用 些 。 尽 管 谁 知 道 他 们 要 的 是 什 么 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 小 心 地 打 击 改 革 派";
		button_text[1] = " 他 们 爱 嘛 嘛 ， 只 要 我 们 的 人 上 来 就 行";
		button_text[2] = " 狠 打 改 革 派 ， 为 温 和 派 和 保 守 派 开 路";
		if (GlobalScript.inst.gameState.data[87] != 1 && GlobalScript.inst.gameState.data[87] != 2)
		{
			button_text[3] = " 我 们 要 坚 定 的 与 改 革 派 站 在 一 起 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 你 不 能 和 修 正 主 义 者 谈 判 ！";
		}
		button_text[4] = " 不 要 打 破 脆 弱 的 党 内 平 衡";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 敌 人 的 敌 人";
		switch (result_num)
		{
		case 0:
		{
			text = " 在 下 一 次 的 中 央 政 治 局 会 议 上 ， 华 国 锋 同 志 批 评 了 一 些 改 革 派 派 别 的 成 员 对 国 内 政 治 经 济 变 化 的 需 要 过 于 草 率 ， 并 敦 促 他 们 集 体 解 决 所 有 紧 迫 的 问 题 ， 以 防 止 党 内 分 裂 和 犯 下 苏 联 赫 鲁 晓 夫 的 “ 唯 意 志 主 义 错 误 ” 。 忠 诚 的 保 守 派 支 持 我 们 的 “ 不 给 党 带 来 不 和 谐 ” 的 建 议 ， 然 而 ， 思 想 自 由 的 一 方 仍 然 坚 持 加 快 经 济 改 革 ， 但 仍 同 意 在 保 持 党 内 民 主 的 必 要 性 上 向 我 们 作 出 让 步 。 与 此 同 时 ， 那 些 在 媒 体 上 阅 读 会 议 记 录 的 人 对 期 待 已 久 的 变 化 的 放 缓 并 不 满 意 ， 这 些 变 化 似 乎 在 “ 四 人 帮 ” 失 败 后 已 经 开 始 了 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.party_ideology[3] -= (int)((float)GlobalScript.inst.gameState.party_ideology[3] * 0.5f);
			GlobalScript.inst.gameState.party_ideology[2] -= (int)((float)GlobalScript.inst.gameState.party_ideology[2] * 0.15f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 2)
				{
					politic4.loyality -= 100;
				}
				else if (politic4.traits[0] == 0)
				{
					politic4.loyality += 100;
				}
			}
			GlobalScript.inst.gameState.politics[7].power -= 100;
			GlobalScript.inst.gameState.politics[6].power -= 100;
			break;
		}
		case 1:
		{
			text = " 你 不 愿 意 改 变 已 经 很 困 难 的 局 面 ， 也 不 敢 与 最 有 影 响 的 改 革 者 进 行 公 开 对 抗 ， 而 只 把 自 己 局 限 于 提 拔 温 和 保 守 派 的 忠 实 成 员 ， 以 防 止 进 行 草 率 的 改 革 。 改 革 派 则 反 过 来 指 责 主 席 企 图 分 裂 党 ， 并 企 图 从 不 能 代 表 广 大 民 众 利 益 的 忠 诚 人 士 之 中 ， 创 建 自 己 的 “ 新 四 人 帮 ” 。 然 而 ， 也 只 是 这 样 而 已 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			party_change[1] = 4f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
				}
			}
			GlobalScript.inst.gameState.politics[5].power += 100;
			GlobalScript.inst.gameState.politics[8].power += 100;
			GlobalScript.inst.gameState.politics[9].power += 100;
			break;
		}
		case 2:
		{
			text = " 在 获 得 了 温 和 保 守 派 的 多 数 人 支 持 后 ， 您 在 下 一 届 党 代 会 上 批 评 了 改 革 派 的 立 场 问 题 ， 并 利 用 您 在 公 安 部 内 的 影 响 力 ， 开 始 积 极 干 预 各 种 不 那 么 杰 出 的 改 革 派 的 行 动 ， 同 时 ， 你 也 从 温 和 的 保 守 派 中 提 拔 您 的 亲 信 。 当 然 ， 那 些 受 到 你 批 评 的 人 们 仍 然 不 满 意 ， 党 内 的 改 革 派 也 不 满 意 。 但 你 的 地 位 得 到 了 明 显 的 巩 固 。";
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.data[3] -= 50;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[6] += 20;
			party_change[1] = 4f;
			GlobalScript.inst.gameState.party_ideology[3] -= (int)((float)GlobalScript.inst.gameState.party_ideology[3] * 0.1f);
			GlobalScript.inst.gameState.party_ideology[2] -= (int)((float)GlobalScript.inst.gameState.party_ideology[2] * 0.15f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic5 in politics)
			{
				if (politic5.traits[0] == 2)
				{
					politic5.loyality -= 200;
				}
				else if (politic5.traits[0] == 0)
				{
					politic5.loyality += 150;
				}
			}
			GlobalScript.inst.gameState.politics[6].power -= 150;
			GlobalScript.inst.gameState.politics[7].power -= 150;
			break;
		}
		case 3:
		{
			text = " 在 下 一 次 的 政 治 局 会 议 上 ， 华 国 锋 同 志 表 示 有 必 要 继 续 对 计 划 经 济 和 社 会 经 济 体 制 进 行 改 革 ， 并 设 法 与 叶 剑 英 和 李 先 念 进 行 谈 判 和 以 创 造 温 和 派 和 改 革 派 间 的 联 盟 。 像 邓 小 平 和 赵 紫 阳 一 样 ， 改 革 派 利 用 自 己 的 行 动 的 自 由 ， 在 积 极 地 用 温 和 的 观 点 在 党 内 宣 传 他 们 的 主 张 。 人 们 注 意 到 改 革 正 在 发 生 ， 并 期 望 他 们 的 生 活 会 变 得 更 好 ， 然 而 ， 保 守 派 对 这 种 状 况 感 到 不 满 。";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[4] += 80;
			GlobalScript.inst.gameState.data[6] -= 20;
			party_change[3] = 5f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 2)
				{
					politic3.loyality += 200;
					politic3.power += 120;
				}
				else if (politic3.traits[0] == 3)
				{
					politic3.power += 70;
				}
				else if (politic3.traits[0] == 0)
				{
					politic3.loyality -= 200;
				}
			}
			break;
		}
		case 4:
		{
			text = " 在 中 共 中 央 政 治 局 和 中 共 其 他 的 机 构 中 ， 改 革 派 和 自 由 派 的 情 绪 正 在 愈 演 愈 烈 ， 这 让 党 内 的 老 保 守 派 非 常 愤 怒 ， 他 们 害 怕 失 去 自 己 的 地 位 和 影 响 力 ， 也 害 怕 中 国 走 向 修 正 主 义 。 权 力 仍 掌 握 在 你 手 中 ， 但 还 能 持 续 多 久 呢 ？";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[4] += 30;
			party_change[3] = 2f;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] >= 2)
				{
					politic.power += 70;
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
