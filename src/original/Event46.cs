using EventsForDLC;
using UnityEngine;

public class Event46 : EventsSecond
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
		name = " 第 二 次 匈 牙 利 事 件 ？";
		text = " 来 自 匈 牙 利 的 有 趣 消 息 。 贝 拉 · 比 斯 库 是 一 名 保 守 的 共 产 主 义 者 ， 他 在1956 年 积 极 参 与 了 镇 压 匈 牙 利 暴 乱 ， 并 在1957 年 至1961 年 担 任 内 政 部 长 和 现 任 匈 牙 利 社 会 主 义 工 人 党 （HSWP ） 书 记 ， 他 一 直 反 对 卡 达 尔 的 经 济 和 政 治 自 由 主 义 改 革 。 意 识 到 言 语 无 法 阻 止 卡 达 尔 ， 他 在 自 己 周 围 组 织 了 一 个 类 似 的 保 守 派 组 织 ， 并 决 定 组 织 一 场 党 内 政 变 ， 要 求 克 格 勃 领 导 人 尤 里 · 安 德 罗 波 夫 的 支 持 。 然 而 ， 根 据 我 们 的 数 据 ， 安 德 罗 波 夫 简 单 地 “ 背 叛 ” 了 比 斯 库 对 卡 达 尔 的 计 划 ， 而 比 斯 库 自 己 还 不 知 情 。 现 在 我 们 有 机 会 帮 助 比 斯 库 和 我 们 的 代 理 人 ， 让 匈 牙 利 走 上 建 设 真 正 社 会 主 义 的 道 路 。 或 者 你 可 以 尝 试 在 小 规 模 武 器 供 应 和 情 报 协 调 的 帮 助 下 在 匈 牙 利 发 动 一 场 新 的 起 义 — — 这 次 是 真 正 的 共 产 主 义 和 亲 中 的 — — 那 么 匈 牙 利 肯 定 是 我 们 的 ！ 但 我 们 必 须 行 动 迅 速 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 欧 洲 太 过 遥 远 ， 亚 洲 对 我 们 更 为 重 要";
		if (GlobalScript.inst.gameState.data[9] >= 80)
		{
			button_text[1] = " 对 比 斯 库 · 贝 洛 和 他 的 人 手 提 供 来 自 我 们 特 勤 的 支 持 和 帮 助";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 足 够 的 力 量";
		}
		if (GlobalScript.inst.gameState.data[9] >= 30 && GlobalScript.inst.gameState.data[22] >= 10)
		{
			button_text[2] = " 帮 助 组 织 亲 中 起 义";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 新 的 在 匈 牙 利 的 起 义 ？ 想 想1956 ！";
		}
		if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[3] = " 我 们 做 不 了 什 么 ， 除 了 给 比 斯 库 避 难 ， 让 他 免 受 修 正 主 义 者 的 怒 火";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 欧 洲 太 过 遥 远 ， 亚 洲 对 我 们 更 为 重 要";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 第 二 次 匈 牙 利 事 件 ？";
		switch (result_num)
		{
		case 0:
			text = " 我 们 对 匈 牙 利 事 件 没 有 反 应 。 卡 达 尔 对 比 斯 库 和 他 的 支 持 者 发 起 了 攻 击 。 看 来 ， 他 们 和 比 斯 库 本 人 很 快 就 会 等 待 辞 职 ， 而 卡 达 尔 将 提 拔 年 轻 的 改 革 者 代 替 他 们 。";
			GlobalScript.inst.gameState.empires[1].power -= 10;
			break;
		case 1:
			text = " 由 于 我 们 情 报 部 门 的 及 时 协 助 ， 比 斯 库 意 识 到 安 德 罗 波 夫 已 经 背 叛 了 他 ， 并 在 我 们 特 工 的 帮 助 下 ， 紧 急 改 变 了 政 变 计 划 ， 几 乎 立 刻 发 表 了 讲 话 ， 工 人 民 兵 孤 立 了 卡 达 尔 的 支 持 者 ， 并 举 行 了 一 次 特 别 的 匈 牙 利 社 会 主 义 工 人 党 中 央 委 员 会 扩 大 会 议 ， 在 那 里 提 及 卡 达 尔 与 纳 吉 的 合 作 和 最 初 对1956 年 暴 乱 的 支 持 ， 以 及 对 马 克 思 主 义 原 则 的 背 离 和 该 国 不 断 增 长 的 外 债 。 卡 达 尔 被 免 去 所 有 职 位 ， 并 被 开 除 出 党 ， 贝 拉 · 比 斯 库 成 为 新 的 总 书 记 ， 开 始 恢 复 中 央 经 济 计 划 和 对 改 革 派 干 部 进 行 清 洗 ， 也 开 始 实 行 更 加 独 立 的 外 交 政 策 ， 已 经 与 我 们 签 订 了 几 份 有 价 值 的 合 同 。 当 然 ， 苏 联 并 不 高 兴 ， 但 在 了 解 到 匈 牙 利 的 一 切 都 很 平 静 之 后 ， 他 们 将 自 己 的 言 论 限 制 在 枯 燥 的 评 论 中 。";
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[9] -= 80;
			GlobalScript.inst.gameState.empires[1].relations -= 300;
			GlobalScript.inst.gameState.empires[1].leaders[6].support--;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.allcountries[4].Torg = true;
			GlobalScript.inst.gameState.allcountries[4].prosov = false;
			GlobalScript.inst.gameState.allcountries[4].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[4].SubGosstroy = 1;
			break;
		case 2:
		{
			text = " 由 于 我 们 的 行 动 信 息 和 支 持 ， 比 斯 库 能 够 迅 速 聚 集 保 守 共 产 主 义 者 、 斯 大 林 主 义 者 、 民 族 主 义 者 和 其 他 不 满 卡 达 尔 政 策 的 人 ， 并 将 他 的 支 持 者 带 到 街 头 示 威 ， 同 时 在 工 人 警 察 的 帮 助 下 ， 控 制 了 行 政 大 楼 并 逮 捕 了 卡 达 尔 和 他 的 支 持 者 。 然 而 ， 这 场 街 头 运 动 并 没 有 停 止 。 比 斯 库 感 觉 到 了 自 己 权 力 的 不 稳 定 性 ， 于 是 试 图 让 已 经 开 始 有 反 苏 分 子 混 入 的 示 威 者 平 静 下 来 ， 然 后 让 他 们 确 保 自 己 的 优 势 。 苏 联 对 布 达 佩 斯 进 行 了 轰 炸 ， 呼 吁 恢 复 该 国 的 秩 序 并 恢 复 法 律 。 然 而 ， 厌 倦 了 毫 无 结 果 的 谈 判 ， 看 到 比 斯 库 越 来 越 倾 向 于 接 受 中 国 的 直 接 支 持 ， 并 且 有 可 能 退 出 华 沙 条 约 ， 苏 联 向 匈 牙 利 派 遣 军 队 ， 逮 捕 了 失 败 的 政 变 者 ， 释 放 了 前 领 导 人 ， 并 且 安 抚 了 人 民 。 在 决 定 不 再 进 行 冒 险 之 后 ， 苏 联 领 导 层 并 没 有 让 卡 达 尔 回 到 总 书 记 的 位 置 （ 他 出 于 健 康 原 因 退 休 了 ） ， 而 是 任 命 亲 苏 温 和 派 的 帕 普 · 亚 诺 什 ， 他 开 始 回 归 苏 联 式 计 划 体 制 ， 并 与 西 方 断 绝 关 系 ， 实 行 日 益 亲 苏 的 政 策 。";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.influencePRC -= 15;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.data[22] -= 10;
			GlobalScript.inst.gameState.data[6] += 40;
			GlobalScript.inst.gameState.empires[1].power += 10;
			GlobalScript.inst.gameState.empires[0].power -= 10;
			GlobalScript.inst.gameState.empires[1].leaders[6].support -= 2;
			int[] data = GlobalScript.inst.gameState.data;
			int num = 112;
			ref int reference = ref data[num];
			int num2 = data[num];
			reference = num2 + 1;
			GlobalScript.inst.gameState.allcountries[4].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[4].SubGosstroy = 16;
			GlobalScript.inst.gameState.allcountries[4].puppetOf = 7;
			break;
		}
		case 3:
			text = " 由 于 我 们 告 诉 了 他 关 于 安 德 罗 波 夫 的 背 叛 ， 比 斯 库 意 识 到 ， 在 匈 牙 利 ， 他 最 多 只 能 等 待 他 辞 职 的 那 天 来 临 ， 因 为 他 被 禁 止 批 评 卡 达 尔 的 路 线 。 他 决 定 利 用 我 们 的 提 议 ， 连 同 他 的 家 人 和 希 望 跟 随 他 的 支 持 者 一 起 逃 到 中 国 ， 在 那 里 他 开 始 在 我 们 的 媒 体 上 广 泛 批 评 匈 牙 利 ， 甚 至 有 时 还 批 评 苏 联 的 修 正 主 义 。 这 使 我 们 的 人 民 开 始 思 考 并 在 世 界 左 翼 运 动 中 提 高 了 我 们 的 影 响 力 ， 但 却 破 坏 了 我 们 与 苏 联 本 来 就 不 是 很 好 的 关 系 。 在 匈 牙 利 ， 年 轻 的 改 革 派 在 卡 达 尔 的 支 持 下 ， 继 续 取 代 已 离 去 的 保 守 派 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[1].relations -= 80;
			GlobalScript.inst.gameState.data[6] += 20;
			GlobalScript.inst.gameState.empires[1].power -= 10;
			GlobalScript.inst.gameState.data[4] -= 40;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
