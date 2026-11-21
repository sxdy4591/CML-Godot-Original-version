using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event664 : EventsSecond
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
		name = " 我 的 哥 哥 叫 双 狮 牌 ， 我 的 妈 妈 是 死 去 的 孔 雀";
		text = $"看 来 历 史 确 实 是 个 圈 ： 缅 甸 的 第 二 次 “ 彬 龙 会 议 ” 也 正 处 于 多 事 之 秋 。 原 本 打 算 前 往 勃 生 参 与 多 方 联 合 会 谈 的 巴 登 顶 同 志 和 数 位 缅 甸 共 产 党 高 层 领 导 人 在 恐 怖 袭 击 内 惨 遭 刺 杀 ， 缅 甸 共 产 党 在 会 议 期 间 的 “ 缺 席 ” 只 会 让 其 他 派 系 抓 紧 机 会 发 起 进 攻 ： 克 伦 民 族 联 盟 的 代 表 要 求 继 续 召 开 会 议 以 稳 定 政 局 ， 并 试 图 在 此 基 础 上 彻 底 排 除 政 府 内 的 共 产 主 义 残 余 。 而 未 参 会 的 缅 甸 共 产 党 代 表 则 团 结 在 东 北 军 区 的 首 长 彭 家 声 的 旗 下 严 厉 抗 议 恐 怖 袭 击 ， 并 呼 吁 推 翻 政 府 ！ 我 们 得 赶 在 覆 水 难 收 前 做 些 什 么 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = "这 就 是 缘 … …";
		button_text[1] = "派 出 调 查 员 ， 绝 不 能 让 昂 山 悲 剧 重 演 ！";
		if (a.data[56] > 0 && a.data[56] < 4)
		{
			button_text[2] = "我 们 没 有 理 由 不 支 持 我 们 华 人 兄 弟 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 怎 么 能 支 持 所 谓 云 南 黄 埔 军 校 的 人 ？";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 的 哥 哥 叫 双 狮 牌 ， 我 的 妈 妈 是 死 去 的 孔 雀";
		switch (result_num)
		{
		case 0:
			text = " 很 快 ， 克 伦 民 族 联 盟 领 导 人 波 妙 便 同 老 牌 反 共 人 士 ， 曾 因 亲 美 倾 向 停 职 ， 后 投 诚 转 向 统 一 战 线 的 缅 族 将 军 基 貌 结 盟 ， 以 “ 政 府 无 力 控 制 局 势 ” 之 名 迅 速 发 动 政 变 ， 逮 捕 了 巴 瑞 博 士 和 丁 吴 将 军 。 中 央 政 府 的 崩 溃 导 致 缅 甸 陷 入 新 一 轮 内 战 ： 东 北 军 区 的 首 长 彭 家 声 已 在 反 对 “ 克 伦 人 沙 文 主 义 ” 与 “ 背 信 弃 义 ” 的 基 础 上 组 建 缅 甸 民 主 同 盟 军 （ 即 不 满 于 克 伦 人 及 其 民 族 地 方 武 装 的 大 帐 篷 ） ， 并 向 克 伦 民 族 联 盟 牵 头 的 全 联 邦 联 盟 军 发 起 了 全 面 进 攻 。";
			a.allcountries[33].parts[0] = true;
			a.ingamewars[83] = new War().Name("第 二 次 缅 甸 内 战").Attacker("缅 甸 民 主 同 盟 军").Defender("全 联 邦 民 主 军")
				.AttackerInfluence(400)
				.DefenderInfluence(600)
				.CreateWar;
			break;
		case 1:
			a.allcountries[33].SubGosstroy = 12;
			a.allcountries[33].proprc = true;
			a.influencePRC += 10;
			a.data[9] -= 50;
			text = "我 们 决 定 紧 急 干 预 议 程 ， 在 搜 查 凶 手 的 情 况 下 要 求 缅 甸 各 方 保 持 克 制 。 多 亏 了 巴 瑞 博 士 ， 丁 吴 将 军 和 亲 联 邦 的 克 伦 人 温 貌 先 生 能 够 及 时 做 出 决 策 ， 我 们 得 以 将 冲 突 扼 杀 在 摇 篮 内 。 克 伦 民 族 联 盟 军 事 强 人 波 妙 坚 持 推 进 协 议 签 署 的 提 议 被 其 亲 密 盟 友 ， 如 克 钦 独 立 组 织 与 若 开 解 放 军 等 团 体 抵 制 。 而 另 一 边 的 恐 怖 袭 击 调 查 也 稳 住 了 缅 甸 共 产 党 方 的 立 场 — — 凶 手 为 前 澳 大 利 亚 特 种 空 降 团 成 员 ， 雇 佣 兵 澳 大 利 亚 人 戴 夫 · 艾 弗 特 。 这 只 会 让 澳 大 利 亚 与 缅 甸 的 关 系 眼 中 恶 化 。 上 述 结 论 得 到 了 彭 家 声 等 地 方 军 官 的 满 意 。 该 国 终 于 不 至 于 重 蹈 覆 辙 。 而 缅 甸 各 大 民 族 也 不 会 忘 记 我 们 的 慷 慨 帮 助 。";
			break;
		case 2:
			a.data[22] -= 100;
			a.empires[0].relations -= 100;
			a.empires[1].relations -= 100;
			a.data[6] += 30;
			a.allcountries[33].parts[0] = true;
			a.ingamewars[83] = new War().Name("第 二 次 缅 甸 内 战").Attacker("缅 甸 民 主 同 盟 军").Defender("全 联 邦 民 主 军")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.CreateWar;
			text = "  很 快 ， 克 伦 民 族 联 盟 领 导 人 波 妙 便 同 老 牌 反 共 人 士 ， 曾 因 亲 美 倾 向 停 职 ， 后 投 诚 转 向 统 一 战 线 的 缅 族 将 军 基 貌 结 盟 ， 以 “ 政 府 无 力 控 制 局 势 ” 之 名 迅 速 发 动 政 变 ， 逮 捕 了 巴 瑞 博 士 和 丁 吴 将 军 。 中 央 政 府 的 崩 溃 导 致 缅 甸 陷 入 新 一 轮 内 战 ： 东 北 军 区 的 首 长 彭 家 声 已 在 反 对 “ 克 伦 人 沙 文 主 义 ” 与 “ 背 信 弃 义 ” 的 基 础 上 组 建 缅 甸 民 主 同 盟 军 （ 即 不 满 于 克 伦 人 及 其 民 族 地 方 武 装 的 大 帐 篷 ） ， 并 向 克 伦 民 族 联 盟 牵 头 的 全 联 邦 联 盟 军 发 起 了 全 面 进 攻 。||与 此 同 时 ， 在 腊 戎 ， 老 姐 ， 邦 康 等 地 ， 历 史 可 上 溯 至 二 战 时 期 被 修 建 的 机 场 灯 火 通 明 ， 一 架 架 “ 航 班 ” 飞 行 起 降 ， 持 续 不 断 地 运 送 中 国 志 愿 军 与 其 装 备 。 雨 林 里 也 开 始 冒 出 我 们 最 新 军 事 成 果 — — 伙 计 们 ， 这 是 我 们 彻 底 拿 下 缅 甸 的 的 好 机 会 ！";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
