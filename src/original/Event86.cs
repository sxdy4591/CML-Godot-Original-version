using EventsForDLC;
using UnityEngine;

public class Event86 : EventsSecond
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
		name = " “ 钢 铁 尤 里 ” 的 终 结";
		text = " 我 们 得 知 ， 列 昂 尼 德 · 勃 列 日 涅 夫 刚 刚 前 往 维 也 纳 ， 与 美 国 总 统 卡 特 就 第 二 轮 的 限 制 战 略 武 器 谈 判 协 议 进 行 谈 判 。 当 然 ， 帝 国 主 义 者 不 会 做 任 何 “ 战 略 进 攻 性 武 器 的 限 制 ” ， 但 我 们 对 此 不 感 兴 趣 — — 勃 列 日 涅 夫 将 在 国 外 待 上 足 够 的 时 间 ， 因 此 我 们 能 够 打 击 苏 联 克 格 勃 领 导 人 尤 里 · 安 德 罗 波 夫 。 他 被 认 为 是 逐 步 改 善 苏 美 关 系 和 在 匈 牙 利 模 式 下 进 行 大 规 模 改 革 的 支 持 者 。 现 在 安 德 罗 波 夫 开 始 被 认 为 是 勃 列 日 涅 夫 最 有 可 能 的 继 任 者 。 有 两 种 方 法 可 以 让 他 出 局 ： 要 么 以 因 肾 衰 竭 死 亡 为 掩 盖 ， 从 肉 体 上 消 灭 他 ， 要 么 试 图 “ 推 动 ” 与 苏 联 秘 密 警 察 领 导 人 关 系 极 差 的 苏 共 主 要 理 论 家 米 哈 伊 尔 · 苏 斯 洛 夫 和 苏 共 乌 克 兰 党 组 织 领 导 人 弗 拉 基 米 尔 · 谢 尔 比 茨 基 ， 召 开 苏 共 中 央 紧 急 全 会 ， 在 会 上 彻 底 击 垮 安 德 罗 波 夫 。 乌 克 兰 克 格 勃 由 维 塔 利 · 费 多 尔 丘 克 上 校 领 导 ， 他 服 从 谢 尔 比 茨 基 ， 与 他 的 盟 友 没 有 矛 盾 ， 所 以 我 们 成 功 的 机 会 很 大 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[9] >= 100 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[0] = " 我 们 将 帮 助 克 格 勃 领 导 人 利 用 他 的 肾 衰 竭 前 往 另 一 个 世 界 。 乌 克 兰 的 克 格 勃 将 处 理 这 一 项 任 务 （ 需 要 10 特 工 网 络 ， 需 要 5 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 这 太 危 险 了 ！";
		}
		if (GlobalScript.inst.gameState.relres)
		{
			button_text[1] = " 苏 斯 洛 夫 和 谢 尔 比 茨 基 召 开 中 央 委 员 会 全 体 会 议 ， 在 我 们 信 息 的 支 持 下 攻 击 安 德 罗 波 夫 （ 需 要7 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 对 苏 共 没 有 足 够 的 影 响 力";
		}
		button_text[2] = " 这 太 危 险 了 ！";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " “ 钢 铁 尤 里 ” 的 终 结";
		switch (result_num)
		{
		case 0:
			text = " 在 勃 列 日 涅 夫 前 往 维 也 纳 会 谈 时 ， 长 期 饱 受 肾 病 折 磨 的 尤 里 · 安 德 罗 波 夫 的 病 情 恶 化 ， 前 往 克 里 米 亚 接 受 治 疗 。 然 而 ， 这 是 一 次 单 程 的 旅 行 — — 在 克 里 米 亚 ， 他 感 冒 了 ， 最 后 病 倒 了 — — 他 得 了 蜂 窝 织 炎 ， 身 体 健 康 状 况 急 剧 恶 化 。 虽 然 手 术 很 成 功 ， 但 是 术 后 伤 口 没 有 愈 合 。 他 的 身 体 非 常 虚 弱 ， 无 法 抵 抗 病 毒 的 侵 入 。 安 德 罗 波 夫 陷 入 昏 迷 ， 然 后 就 再 也 没 有 醒 过 来 。1979 年7 月9 日 ， 苏 联 克 格 勃 主 席 逝 世 。 知 情 人 士 说 ： “ 安 德 罗 波 夫 没 有 必 要 去 谢 尔 比 茨 基 的 农 场 。 他 也 有 他 的 骄 傲 和 他 的 克 格 勃 。 ” 新 的 克 格 勃 领 导 人 是 塞 米 恩 · 茨 维 贡 ， 他 发 起 了 大 规 模 的 “ 办 公 室 清 洗 ” ， 大 量 来 自 乌 克 兰 苏 维 埃 社 会 主 义 共 和 国 的 克 格 勃 工 作 人 员 取 代 了 安 德 罗 波 夫 的 亲 信 。 这 增 强 了 弗 拉 基 米 尔 • 谢 尔 比 茨 基 的 影 响 力 ， 他 如 今 已 成 为 列 昂 尼 德 • 勃 列 日 涅 夫 事 实 上 唯 一 的 继 承 人 。 对 我 们 来 说 挺 好 的 … …";
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.empires[1].leaders[3].support = -100;
			GlobalScript.inst.gameState.empires[1].leaders[1].support += 10;
			GlobalScript.inst.gameState.data[1] += 100;
			break;
		case 1:
			if (GlobalScript.inst.gameState.empires[1].relations >= 400)
			{
				text = " 当 维 也 纳 传 来 了 勃 列 日 涅 夫 抵 达 奥 地 利 首 都 的 消 息 时 ， 苏 联 克 格 勃 第 八 最 高 委 员 会 第 一 副 主 席 塞 米 恩 · 茨 维 贡 将 军 下 令 切 断 了 政 府 的 通 讯 ， 从 而 使 勃 列 日 涅 夫 完 全 隔 绝 了 来 自 苏 联 的 信 息 。 与 此 同 时 ， 在 克 格 勃 内 的 反 对 派 的 帮 助 下 ， 米 哈 伊 尔 · 苏 斯 洛 夫 和 弗 拉 基 米 尔 · 谢 尔 比 茨 基 迅 速 召 开 了 紧 急 中 央 委 员 会 全 体 会 议 ， 尤 里 · 安 德 罗 波 夫 被 指 控 “ 将 克 格 勃 改 造 成 私 人 商 店 ， 准 备 发 动 反 政 府 政 变 ， 与 中 央 情 报 局 和 以 色 列 特 勤 处 进 行 沟 通 ， 诽 谤 费 奥 多 尔 · 库 拉 科 夫 和 彼 得 · 马 谢 罗 夫 ” 等 等 。 我 们 发 表 了 有 关 安 德 罗 波 夫 的 “ 揭 发 材 料 ” ， 火 上 浇 油 ， 迅 速 地 给 予 了 全 会 的 信 息 支 持 。 克 格 勃 领 导 人 哑 口 无 言 ， 他 试 图 抵 抗 ， 但 在 弗 拉 基 米 尔 · 谢 尔 比 茨 基 发 表 了 直 接 指 控 安 德 罗 波 夫 准 备 谋 杀 勃 列 日 涅 夫 的 讲 话 后 ， 他 意 识 到 自 己 已 经 失 败 了 。 全 会 通 过 了 关 于 撤 销 安 德 罗 波 夫 所 有 职 务 的 决 定 ， 将 他 驱 逐 出 党 并 逮 捕 他 。 苏 联 克 格 勃 新 任 主 席 是 乌 克 兰 克 格 勃 主 席 维 塔 利 • 费 多 丘 克 。 费 多 丘 克 开 始 大 规 模 清 洗 安 德 罗 波 夫 的 亲 信 ， 并 将 他 们 替 换 为 来 自 乌 克 兰 共 和 国 中 央 委 员 会 的 可 靠 人 员 。 也 许 我 们 在 苏 联 最 危 险 的 敌 人 现 在 已 经 被 完 全 消 灭 了 …";
				GlobalScript.inst.gameState.data[8] -= 70;
				GlobalScript.inst.gameState.empires[1].leaders[3].support = -100;
				GlobalScript.inst.gameState.empires[1].leaders[1].support += 10;
			}
			else
			{
				text = " 当 维 也 纳 传 来 了 勃 列 日 涅 夫 抵 达 奥 地 利 首 都 的 消 息 时 ， 苏 联 克 格 勃 第 八 最 高 委 员 会 第 一 副 主 席 塞 米 恩 · 茨 维 贡 将 军 下 令 切 断 了 政 府 的 通 讯 ， 从 而 使 勃 列 日 涅 夫 完 全 隔 绝 了 来 自 苏 联 的 信 息 。 与 此 同 时 ， 在 克 格 勃 内 的 反 对 派 的 帮 助 下 ， 米 哈 伊 尔 · 苏 斯 洛 夫 和 弗 拉 基 米 尔 · 谢 尔 比 茨 基 迅 速 召 开 了 紧 急 中 央 委 员 会 全 体 会 议 ， 尤 里 · 安 德 罗 波 夫 被 指 控 “ 将 克 格 勃 改 造 成 私 人 商 店 ， 准 备 发 动 反 政 府 政 变 ， 与 中 央 情 报 局 和 以 色 列 特 勤 处 进 行 沟 通 ， 诽 谤 费 奥 多 尔 · 库 拉 科 夫 和 彼 得 · 马 谢 罗 夫 ” 等 等 。 我 们 发 表 了 有 关 安 德 罗 波 夫 的 “ 揭 露 材 料 ” ， 火 上 浇 油 ， 迅 速 地 给 予 了 全 会 信 息 支 持 。 然 而 ， 安 德 罗 波 夫 保 持 了 冷 静 ， 并 依 靠 他 在 苏 共 中 央 委 员 会 内 的 支 持 者 和 忠 诚 的 克 格 勃 官 员 ， 宣 布 苏 斯 洛 夫 和 谢 尔 比 茨 基 为 “ 第 二 个 反 党 团 体 ” ， 把 全 会 变 成 了 他 们 的 法 庭 。 结 果 是 苏 斯 洛 夫 和 谢 尔 比 茨 基 被 排 除 在 苏 共 之 外 ， 也 促 使 了 安 德 罗 波 夫 的 崛 起 ， 安 德 罗 波 夫 成 为 苏 共 的 第 二 书 记 和 列 昂 尼 德 · 勃 列 日 涅 夫 的 实 际 继 任 者 ， 勃 列 日 涅 夫 得 到 了 一 切 全 会 中 的 信 息 ， 并 支 持 他 的 做 法 。";
				GlobalScript.inst.gameState.data[8] -= 70;
				GlobalScript.inst.gameState.empires[1].leaders[3].support += 2;
			}
			break;
		case 2:
			text = " 什 么 也 没 发 生 。 尤 里 · 安 德 罗 波 夫 逐 渐 清 除 了 克 格 勃 内 的 反 对 派 ， 加 强 了 对 苏 共 中 央 委 员 会 的 影 响 力 ， 成 为 勃 列 日 涅 夫 的 实 际 接 班 人 ， 推 动 了 叶 戈 尔 · 利 加 乔 夫 、 米 哈 伊 尔 · 戈 尔 巴 乔 夫 和 弗 拉 基 米 尔 · 多 尔 吉 赫 等 改 革 派 党 员 的 晋 升 。";
			GlobalScript.inst.gameState.empires[1].leaders[3].support += 2;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
