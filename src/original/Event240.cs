using EventsForDLC;
using UnityEngine;

public class Event240 : EventsSecond
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
		name = " 革 命 无 罪 ， 造 反 另 说";
		text = " 走 资 派 意 图 破 坏 革 命 的 企 图 已 经 被 华 国 锋 与 极 左 派 的 联 盟 粉 碎 ， 确 保 了 中 国 能 继 续 行 进 在 毛 主 席 所 指 引 的 康 庄 大 道 上 ， 而 对 这 条 道 路 的 看 法 ， 华 国 锋 不 得 不 与 他 的 “ 新 朋 友 ” 好 好 的 商 量 一 会 。||如 今 军 事 阴 谋 集 团 早 已 全 军 覆 没 ， 中 国 的 步 伐 逐 渐 来 到 了 新 的 历 史 节 点 。 在 第 十 一 届 中 国 共 产 党 全 国 人 民 代 表 大 会 上 ， 十 月 的 胜 利 者 们 必 须 重 新 评 定 毛 主 席 的 遗 产 ， 而 对 于 其 中 的 关 键 部 分 ： 无 产 阶 级 文 化 大 革 命 — — 被 毛 主 席 生 前 称 为 “ 支 持 的 人 不 多 ， 反 对 的 人 不 少 ” 的 “ 第 二 件 事 ” — — 的 看 法 将 成 为 这 次 会 议 的 焦 点 。||华 国 锋 自 诩 为 毛 主 席 “ 钦 定 ” 的 接 班 人 ， 声 称 自 己 确 实 紧 跟 着 主 席 的 路 线 ， 对 于 毛 主 席 一 切 的 革 命 指 示 绝 不 敢 有 半 点 违 背 ， 但 他 对 于 文 化 大 革 命 的 理 解 显 然 只 局 限 于 是 一 场 大 型 “ 整 风 运 动 ” 。 华 国 锋 在 会 上 表 示 目 前 一 切 现 行 反 革 命 走 资 派 已 被 肃 清 ， 毛 主 席 生 前 的 担 忧 已 经 解 决 ， 现 在 是 时 候 该 宣 布 文 化 大 革 命 “ 胜 利 结 束 ” 。 但 极 左 派 对 此 显 然 有 不 同 看 法 ， 极 左 派 的 成 员 在 毛 主 席 生 前 都 是 文 化 大 革 命 路 线 的 积 极 拥 护 者 与 参 与 者 ， 其 代 表 也 都 是 运 动 中 的 头 面 人 物 ， 他 们 声 称 文 化 大 革 命 不 仅 仅 只 是 对 少 数 官 僚 的 清 洗 ， 更 是 要 给 中 国 社 会 带 来 彻 底 改 变 ， 引 导 群 众 破 除 资 产 阶 级 法 权 、 巩 固 无 产 阶 级 专 政 的 关 键 战 略 ， 为 了 中 国 革 命 的 未 来 ， 绝 对 不 能 停 止 文 革 ， 反 而 应 该 继 续 发 扬 下 去 。||会 议 上 的 争 论 暂 时 还 在 以 较 平 静 的 氛 围 下 进 行 ， 但 无 论 结 果 如 何 ， 这 都 将 使 华 国 锋 与 极 左 派 的 虚 弱 联 盟 产 生 不 小 的 裂 痕 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 无 产 阶 级 文 化 大 革 命 的 使 命 已 经 圆 满 完 成 ， 我 们 将 继 续 沿 着 毛 主 席 的 革 命 路 线 前 进 ！";
		if (GlobalScript.inst.gameState.data[84] == 3)
		{
			button_text[1] = " 无 产 阶 级 文 化 大 革 命 是 捍 卫 无 产 阶 级 专 政 的 根 本 保 障 ！ 必 须 不 偏 不 倚 的 对 抗 一 切 修 正 主 义 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 文 革 已 经 得 罪 了 所 有 人 啦";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 革 命 无 罪 ， 造 反 另 说";
		switch (result_num)
		{
		case 0:
		{
			text = " 毛 主 席 发 动 文 化 大 革 命 的 初 心 是 为 了 打 击 党 内 一 小 撮 走 资 本 主 义 路 线 的 党 权 派 ， 如 今 他 们 已 经 被 革 命 群 众 全 部 消 灭 ， 这 说 明 主 席 的 目 标 已 经 达 成 ， 如 果 再 让 人 民 群 众 进 行 这 么 多 缺 少 纪 律 的 运 动 ， 国 家 若 再 陷 入 混 乱 那 就 是 背 离 毛 主 席 的 本 意 了 。 最 终 华 国 锋 通 过 自 己 的 威 望 成 功 的 说 服 了 大 部 分 代 表 ， 中 央 得 以 在 最 终 决 议 上 庄 严 的 宣 布 持 续 十 余 年 之 久 的 无 产 阶 级 文 化 大 革 命 在 反 革 命 的 覆 灭 后 得 以 “ 胜 利 结 束 ” 。 在 此 之 后 ， 华 国 锋 在 会 上 宣 布 将 继 续 毛 泽 东 的 事 业 ， 并 提 出 “ 凡 是 毛 主 席 作 出 的 决 策 ， 我 们 都 坚 决 维 护 ， 凡 是 毛 主 席 的 指 示 ， 我 们 都 始 终 不 渝 地 遵 循 ” 的 “ 两 个 凡 是 ” 作 为 新 的 政 治 纲 领 代 替 旧 文 革 路 线 ， 中 国 将 沿 着 毛 主 席 所 指 的 道 路 ， 建 设 一 个 富 强 稳 定 的 社 会 主 义 国 家 。||群 众 对 反 革 命 势 力 得 以 “ 肃 清 ” 与 文 革 的 “ 最 终 胜 利 ” 感 到 高 兴 ， 但 极 左 派 却 对 于 这 项 决 定 感 到 无 比 的 失 望 与 担 忧 ， 他 们 认 为 华 国 锋 将 文 化 大 革 命 的 理 论 庸 俗 化 了 ， 部 分 成 员 已 经 认 为 华 国 锋 已 经 背 叛 了 毛 泽 东 的 革 命 事 业 ， 准 备 在 此 密 谋 对 抗 ， 但 极 左 派 的 力 量 得 以 延 续 至 今 ， 很 大 程 度 上 是 依 靠 着 与 华 国 锋 的 盟 约 ， 且 如 今 作 为 他 们 生 存 基 础 的 文 革 路 线 已 经 消 失 ， 极 左 派 们 的 “ 革 命 道 路 ” 还 能 走 多 远 呢 ？";
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.modifies[3].active = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality += 100;
				}
				if (politic3.traits[0] == 20)
				{
					politic3.loyality += 80;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.loyality -= 100;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality += 50;
				}
			}
			party_change[0] = 3f;
			party_change[1] = 5f;
			GlobalScript.inst.gameState.data[87] = 1;
			break;
		}
		case 1:
		{
			text = " 无 产 阶 级 文 化 大 革 命 是 一 场 触 及 人 们 心 灵 的 大 革 命 ， 绝 不 是 清 除 了 某 几 个 走 资 派 就 能 宣 告 胜 利 结 束 的 ， 它 将 为 我 国 人 民 捍 卫 无 产 阶 级 专 政 提 供 最 重 要 的 思 想 武 器 ， 是 毛 主 席 最 宝 贵 的 革 命 遗 产 。 在 粉 碎 叶 剑 英 军 事 阴 谋 集 团 的 行 动 中 极 左 派 的 表 现 无 疑 十 分 亮 眼 ， 他 们 成 功 的 向 世 人 展 现 了 革 命 群 众 的 无 穷 力 量 ， 这 也 让 他 们 在 党 内 积 攒 起 了 空 前 的 威 望 ， 在 极 左 派 的 努 力 下 ， 毛 泽 东 主 席 晚 年 最 重 要 的 理 论 与 实 践 成 果 得 以 保 留 ， 且 在 大 会 的 最 终 决 议 里 ， 成 功 的 将 “ 坚 持 在 无 产 阶 级 专 政 之 下 继 续 革 命 ” 等 文 革 重 要 理 论 写 入 党 章 ， 显 然 ， 中 国 还 会 继 续 坚 持 最 激 烈 的 反 修 正 主 义 路 线 。 华 国 锋 等 保 守 派 对 于 现 状 的 保 持 十 分 不 满 ， 但 迫 于 毛 主 席 的 “ 最 高 指 示 ” 他 们 不 能 表 现 出 太 大 的 不 满 ， 但 可 以 预 知 的 事 ， 他 们 绝 不 会 将 毛 泽 东 的 遗 产 拱 手 让 人 ， 在 不 久 的 将 来 也 定 会 给 极 左 派 持 续 造 成 威 胁 。 随 着 持 续 十 余 年 的 运 动 热 情 逐 渐 走 向 冷 却 ， 人 民 群 众 对 于 大 会 的 决 议 并 没 有 感 到 兴 奋 ， 甚 至 已 经 觉 得 厌 烦 ， 极 左 派 若 有 意 将 文 化 大 革 命 的 运 动 常 态 化 ， 就 必 须 想 办 法 重 新 点 燃 群 众 的 热 情 。 对 此 ， 极 左 派 依 然 表 现 得 信 心 十 足 … …||历 经 波 折 ， 毛 主 席 最 骄 傲 的 门 徒 们 终 于 有 了 一 个 机 会 去 挥 舞 导 师 所 留 下 的 宝 剑 ， 但 他 们 的 前 途 仍 然 崎 岖 而 坎 坷 的 ， 道 路 在 何 方 ？ 这 一 切 仍 需 要 时 间 验 证 … …";
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] += 100;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += 100;
				}
				if (politic2.traits[0] == 20)
				{
					politic2.loyality += 80;
				}
				else if (politic2.traits[0] > 0)
				{
					politic2.loyality -= 200;
					politic2.power -= 100;
				}
			}
			party_change[0] = 8f;
			party_change[1] = 3f;
			GlobalScript.inst.gameState.data[87] = 2;
			break;
		}
		case 2:
		{
			text = " 你 说 文 化 大 革 命 已 经 完 成 了 它 的 历 史 任 务 ， 所 以 你 开 始 消 灭 文 化 大 革 命 的 最 后 遗 产 。 同 时 ， 您 特 别 强 调 了 中 国 调 整 经 济 结 构 和 进 行 现 代 化 建 设 的 必 要 性 ， 您 还 没 有 提 出 具 体 的 措 施 ， 但 改 革 派 和 人 民 正 在 等 待 着 中 国 的 改 变 ， 期 望 您 让 它 变 得 更 好 。";
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[4] += 80;
			GlobalScript.inst.gameState.modifies[3].active = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 0)
				{
					politic4.loyality -= 20;
				}
				else if (politic4.traits[0] < 3)
				{
					politic4.loyality += 100;
				}
			}
			party_change[2] = 8f;
			party_change[3] = 3f;
			GlobalScript.inst.gameState.data[87] = 3;
			break;
		}
		case 3:
		{
			text = " 你 说 要 迅 速 消 灭 文 化 大 革 命 的 遗 毒 ， 这 是 党 和 人 民 都 喜 欢 的 。 同 时 ， 您 也 谈 到 了 中 国 经 济 进 一 步 市 场 化 改 革 的 必 要 性 ， 以 及 如 何 逐 步 进 入 世 界 市 场 的 问 题 。 为 此 ， 您 开 始 积 极 推 动 赵 紫 阳 、 邓 小 平 等 老 改 革 家 回 归 ， 使 他 们 回 到 了 副 总 理 的 位 置 。 人 民 在 等 待 着 中 国 的 变 化 ， 但 党 内 的 保 守 派 对 你 的 决 定 表 示 不 满 。";
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[1] -= 50;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.modifies[3].active = false;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 100;
				}
				if (politic.traits[0] == 20)
				{
					politic.loyality -= 50;
				}
				else if (politic.traits[0] > 1)
				{
					politic.loyality += 100;
				}
			}
			party_change[2] = 3f;
			party_change[3] = 8f;
			party_change[4] = 3f;
			GlobalScript.inst.gameState.data[87] = 4;
			break;
		}
		}
	}
}
