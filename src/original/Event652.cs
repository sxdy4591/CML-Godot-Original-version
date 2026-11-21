using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event652 : EventsSecond
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
		name = " 非 洲 大 逃 杀";
		text = " 进 入20 世 纪80 年 代 后 ， 塞 拉 利 昂 的 经 济 便 持 续 下 行 ， 深 受 恶 性 通 货 膨 胀 与 缺 乏 社 会 保 障 设 施 的 困 扰 。 也 就 在1985 年 内 ， 塞 拉 利 昂 的 通 货 膨 胀 率 便 高 达76 .6 % 。 失 业 潮 与 国 内 经 济 长 期 缺 乏 有 效 投 资 的 情 况 使 该 国 大 量 青 年 沦 为 无 业 游 民 ， 并 自 发 结 成 黑 社 会 性 质 的 组 织 谋 求 生 计 。 糜 烂 的 局 势 甚 至 让 斯 蒂 文 森 都 无 法 泰 然 处 之 ， 不 得 不 在 “ 蝗 虫 般 的17 年 后 ” 引 咎 辞 职 。 大 会 党 准 备 寄 希 望 于 来 自 强 力 机 关 的 候 选 人 约 瑟 夫 · 赛 义 杜 · 莫 莫 重 振 局 势 ， 并 为 经 济 改 革 做 好 了 计 划 ： 出 于 平 抑 物 价 的 需 要 ， 政 府 对 投 机 倒 把 、 囤 积 居 奇 、 哄 抬 物 价 等 行 为 严 惩 不 贷 ； 并 决 定 改 组 缉 私 队 伍 ， 惩 办 走 私 者 和 驱 逐 违 法 的 外 商 。 可 考 虑 到 塞 拉 利 昂 国 内 利 益 团 体 早 已 在 多 年 腐 败 统 治 下 根 深 蒂 固 ， 如 此 改 革 仍 显 得 浮 于 表 面 ： 且 斯 蒂 文 森 的 亲 信 们 也 不 满 于 莫 莫 的 “ 专 断 行 径 ” 。 看 起 来 塞 拉 利 昂 已 来 到 了 其 历 史 拐 点 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (GlobalScript.inst.gameState.allcountries[107].Torg)
		{
			button_text[0] = " 帮 助 莫 莫 深 化 改 革 ， 并 扫 除 塞 拉 利 昂 政 坛 的 保 守 派 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 无 能 为 力";
		}
		if (GlobalScript.inst.gameState.data[56] <= 2 && (a.allcountries[107].cw || a.allcountries[13].Torg) && !a.allcountries[107].Torg)
		{
			button_text[1] = " 是 时 候 结 束 全 国 大 会 党 政 权 的 闹 剧 了 ！";
		}
		else if (a.allcountries[107].Torg)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 可 不 能 背 刺 合 作 伙 伴";
		}
		else if (!a.allcountries[107].cw && !a.allcountries[13].Torg)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 找 到 合 适 的 人 选";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 这 是 对 外 国 内 政 的 激 进 干 涉 ！";
		}
		if (GlobalScript.inst.gameState.data[56] >= 3 && a.allcountries[51].dev == 1 && (a.empires[0].now_leader == 0 || a.empires[0].now_leader == 2) && !a.allcountries[107].Torg)
		{
			button_text[2] = " 与 美 国 一 起 ， 支 持 强 力 手 段 稳 定 西 非 局 势 。";
		}
		else if (a.allcountries[107].Torg)
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 可 不 能 背 刺 合 作 伙 伴";
		}
		else if (a.allcountries[51].dev != 1 || (a.empires[0].now_leader != 0 && a.empires[0].now_leader != 2))
		{
			Object.Destroy(button[2]);
			button_text[2] = " 美 国 可 没 有 闲 心 多 管 闲 事";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 绝 不 能 支 持 美 帝 国 主 义 代 理 人";
		}
		button_text[3] = " 充 耳 不 闻";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 非 洲 大 逃 杀";
		switch (result_num)
		{
		case 0:
			text = " 您 决 定 亲 自 致 电 莫 莫 ， 表 示 中 国 将 拨 付 低 息 贷 款 解 决 塞 拉 利 昂 目 前 的 经 济 问 题 。 莫 莫 对 此 则 表 示 无 比 感 激 ， 顺 势 深 化 了 先 前 早 已 建 立 的 中 - 塞 友 好 关 系 ： 仰 仗 中 国 的 经 济 援 助 与 政 治 支 持 ， 莫 莫 政 府 得 以 全 面 推 进 其 改 革 政 策 并 剔 除 保 守 派 。 资 金 的 流 入 缓 解 了 长 期 缺 乏 有 效 投 资 的 问 题 ， 让 该 国 得 以 逐 步 解 决 社 保 ， 教 育 与 水 电 供 应 问 题 。 塞 拉 利 昂 全 国 大 会 党 政 权 就 此 稳 定 了 下 来 ， 不 至 跌 入 暴 力 深 渊 。";
			a.allcountries[107].LeaveAlliances();
			a.allcountries[107].Torg = true;
			a.data[8] -= 80;
			a.influencePRC += 10;
			a.allcountries[107].Gosstroy = 2;
			a.allcountries[107].SubGosstroy = 15;
			a.allcountries[107].proprc = true;
			break;
		case 1:
			a.allcountries[107].Gosstroy = 0;
			a.allcountries[107].SubGosstroy = 7;
			a.allcountries[107].LeaveAlliances();
			a.allcountries[107].Vyshi = true;
			GlobalScript.inst.gameState.data[9] -= 30;
			GlobalScript.inst.gameState.data[22] -= 30;
			a.empires[0].relations -= 50;
			a.allcountries[107].parts[0] = true;
			text = " 如 今 全 国 大 会 党 政 权 已 是 风 雨 飘 摇 ， 正 是 入 局 的 好 机 会 — — 受 够 了 斯 蒂 文 森 集 团 腐 败 统 治 的 中 国 决 定 借 题 发 挥 ， 通 过 扶 持 塞 拉 利 昂 境 内 革 命 者 的 方 式 彻 底 终 结 这 一 盗 贼 体 制 。";
			if (a.allcountries[107].cw)
			{
				text += " 通 过 非 洲 社 会 主 义 者 的 渠 道 与 塞 拉 利 昂 境 内 的 左 翼 网 络 ， 我 们 将 塞 拉 利 昂 泛 非 联 盟 （ 持 革 命 泛 非 主 义 ， 由 克 莱 奥 · 汉 西 莱 等 人 创 建 ） 等 革 命 左 翼 组 织 和 马 克 思 主 义 者 易 布 拉 辛 · 阿 卜 杜 拉 （ 他 曾 在 莫 桑 比 克 内 战 期 间 积 极 参 与 莫 桑 比 克 解 放 阵 线 的 工 作 ， 并 深 刻 领 会 了 非 洲 革 命 斗 争 模 式 ） 的 队 伍 整 合 起 来 ， 并 筹 备 一 场 革 命 ， 不 久 后 ， 他 们 便 成 立 了 塞 拉 利 昂 人 民 民 主 阵 线 ， 并 迅 速 吸 纳 了 大 量 对 弗 里 敦 政 府 不 满 的 青 年 与 失 业 工 人 ， 对 全 国 各 地 发 起 了 进 攻 。 塞 拉 利 昂 全 国 就 此 进 入 紧 急 状 态 。 也 就 在 混 乱 期 间 ， 原 总 统 莫 莫 被 前 总 统 府 警 卫 副 总 监 与 国 民 警 察 副 局 长 加 布 里 埃 尔 · 卡 伊 卡 伊 所 谋 害 ， 后 者 借 机 组 建 了 一 个 奉 行 实 用 主 义 的 军 政 府 “ 镇 压 革 命 ” 。 塞 拉 利 昂 起 义 就 此 爆 发 。";
				a.ingamewars[78] = new War().Name("塞 拉 利 昂 内 战").Attacker("塞 人 阵").Defender("政 府 军")
					.AttackerInfluence(200)
					.DefenderInfluence(800)
					.TickTime(40)
					.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
			}
			else
			{
				text += " 得 益 于 我 们 和 利 比 亚 的 良 好 关 系 ， 我 们 决 定 押 宝 曾 在 利 比 亚 接 受 革 命 民 族 主 义 训 练 并 以 组 织 未 遂 政 变 反 对 斯 蒂 文 森 政 权 而 闻 名 遐 迩 的 福 迪 · 桑 科 。 他 的 履 历 足 以 作 为 我 们 彻 底 改 变 塞 拉 利 昂 局 势 的 最 佳 王 牌 。 不 久 后 ， 桑 科 便 以 “ 革 命 联 合 阵 线 ” 之 名 纠 结 起 该 国 主 要 反 对 派 对 全 国 各 地 发 起 了 进 攻 。 塞 拉 利 昂 全 国 就 此 进 入 紧 急 状 态 。 也 就 在 混 乱 期 间 ， 原 总 统 莫 莫 被 前 总 统 府 警 卫 副 总 监 与 国 民 警 察 副 局 长 加 布 里 埃 尔 · 卡 伊 卡 伊 所 谋 害 ， 后 者 借 机 组 建 了 一 个 奉 行 实 用 主 义 的 军 政 府 “ 镇 压 革 命 ” 。 塞 拉 利 昂 起 义 就 此 爆 发 。";
				a.ingamewars[78] = new War().Name("塞 拉 利 昂 内 战").Attacker("革 联 阵").Defender("政 府 军")
					.AttackerInfluence(200)
					.DefenderInfluence(800)
					.TickTime(40)
					.AmericanSupportDefender.CreateWar;
			}
			break;
		case 2:
			text = " 我 们 决 定 同 美 国 人 一 道 解 决 塞 拉 利 昂 问 题 — — 考 虑 到 塞 拉 利 昂 国 内 局 势 的 复 杂 性 ， 以 及 其 可 能 成 为 第 二 个 安 哥 拉 或 莫 桑 比 克 的 可 能 。 有 必 要 赶 在 局 势 待 定 前 迅 速 出 手 稳 定 政 局 。 最 终 我 们 联 合 敲 定 了 行 动 方 案 ： 通 过 已 被 驱 逐 出 境 的 黎 巴 嫩 籍 巨 富 米 勒 · 穆 罕 默 德 提 供 的 巨 额 资 金 ， 前 总 统 府 警 卫 副 总 监 与 国 民 警 察 副 局 长 加 布 里 埃 尔 · 卡 伊 卡 伊 得 以 秘 密 武 装 起 一 只 私 兵 队 伍 筹 备 政 变 ， 并 在 总 统 府 附 近 的 公 路 桥 炸 毁 了 莫 莫 亲 自 乘 坐 的 专 车 。 接 下 来 便 是 借 机 引 入 紧 急 状 态 并 扭 转 外 交 路 线 ， 由 此 组 织 起 奉 行 实 用 主 义 的 军 政 府 “ 维 持 国 家 秩 序 ” 。 塞 拉 利 昂 的 皮 诺 切 特 就 此 待 命 ， 谁 知 道 接 下 来 会 如 何 ？";
			a.allcountries[107].LeaveAlliances();
			a.allcountries[107].Gosstroy = 0;
			a.allcountries[107].SubGosstroy = 7;
			a.allcountries[107].Vyshi = true;
			a.allcountries[107].Torg = true;
			break;
		case 3:
			text = " 莫 莫 与 斯 蒂 文 森 集 团 的 斗 争 仍 在 继 续 ， 并 试 图 在 此 期 间 将 后 者 边 缘 化 。 然 而 ， 目 前 塞 拉 利 昂 的 处 境 可 等 不 了 太 久 … …";
			a.allcountries[107].Gosstroy = 2;
			a.allcountries[107].SubGosstroy = 15;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
