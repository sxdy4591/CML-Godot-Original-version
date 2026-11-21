using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event660 : EventsSecond
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
		name = " 七 丘 之 城 的 新 狄 克 推 多";
		text = $"经 过 艰 苦 的 武 装 斗 争 ， 乌 干 达 的 人 民 战 争 已 经 从 游 击 战 转 入 了 运 动 战 阶 段 ， 全 国 抵 抗 军 不 仅 控 制 了 卢 韦 罗 三 角 地 带 解 放 区 ， 发 展 到 数 千 名 游 击 队 员 的 规 模 ， 还 在 弗 雷 德 · 鲁 维 吉 耶 马 指 挥 官 的 带 领 下 在 乌 干 达 西 部 的 鲁 文 佐 里 山 地 区 开 辟 了 第 二 战 场 。 与 之 相 反 ， 政 府 军 则 是 遭 遇 了 多 次 重 大 失 败 ， 且 由 于 奥 博 特 对 全 国 抵 抗 军 的 西 征 行 动 作 出 的 错 误 判 断 导 致 主 力 部 队 在 围 剿 时 受 到 重 创 。 精 锐 部 队 的 失 败 给 政 府 军 带 来 了 巨 大 的 心 理 打 击 ， 至 此 ， 政 府 军 彻 底 军 心 涣 散 ， 无 力 再 组 织 起 对 全 国 抵 抗 军 的 围 剿 。||令 人 始 料 未 及 的 是 ， 在 接 连 惨 败 于 全 国 抵 抗 军 后 ， 由 于 军 事 失 败 、 政 治 前 景 黯 淡 ， 与 政 府 军 内 部 的 兰 戈 派 和 阿 乔 利 派 矛 盾 ， 最 终 引 爆 了 奥 博 特 集 团 的 内 部 分 裂 ， 以 乌 干 达 民 族 解 放 军 司 令 蒂 托 · 奥 凯 洛 将 军 与 另 一 名 阿 乔 利 人 高 级 军 官 、 精 锐 的 第 十 旅 旅 长 巴 西 里 奥 · 奥 凯 洛 准 将 联 手 阿 明 旧 部 ， 从 阿 乔 利 人 的 大 本 营 古 卢 向 首 都 坎 帕 拉 进 军 ， 在 经 过 了 数 日 激 烈 交 战 后 ， 政 变 军 人 彻 底 控 制 了 这 座 乌 干 达 的 七 丘 之 城 ， 奥 博 特 又 一 次 被 迫 流 亡 。 政 变 成 功 后 ， 军 事 委 员 会 暂 停 了 宪 法 ， 解 散 了 议 会 ， 并 罢 免 了 所 有 政 府 部 长 。 新 政 府 以 蒂 托 · 奥 凯 洛 为 总 统 ， 巴 西 里 奥 · 奥 凯 洛 为 总 参 谋 长 。 为 了 改 变 被 动 的 军 事 局 面 ， 巩 固 自 己 岌 岌 可 危 的 地 位 ， 新 的 军 政 府 呼 吁 各 反 政 府 武 装 停 火 ， 同 他 们 一 道 共 商 国 是 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = "对 政 变 不 予 置 评";
		if (a.resultOfEvents[659] == 2)
		{
			button_text[1] = "发 动 战 略 反 攻 ， 一 股 作 气 ， 打 到 坎 帕 拉 去 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 必 要 支 持 他 们";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 七 丘 之 城 的 新 狄 克 推 多";
		a.allcountries[118].parts[0] = true;
		switch (result_num)
		{
		case 0:
			a.ingamewars[81] = new War().Name("乌 干 达 内 战").Attacker("全 国 抵 抗 军").Defender("政 府 军")
				.AttackerInfluence(700)
				.DefenderInfluence(300)
				.CreateWar;
			text = " 乌 干 达 似 乎 没 有 比 政 变 前 更 接 近 和 平 。 发 出 和 谈 呼 吁 后 ， 政 变 集 团 成 功 借 助 自 己 反 奥 博 特 的 立 场 笼 络 到 了 其 他 政 治 与 军 事 势 力 ， 组 建 起 了 自 己 的 政 治 同 盟 。 协 助 奥 凯 洛 发 动 政 变 的 阿 明 残 军 自 然 加 盟 其 中 ， 而 民 主 党 、 卡 伊 拉 的 乌 干 达 自 由 运 动 和 从 其 中 分 裂 出 来 的 联 邦 民 主 运 动 也 在 枪 杆 子 的 威 逼 和 高 官 厚 禄 的 利 诱 下 再 次 同 压 迫 者 站 在 了 一 起 。 然 而 ， 政 府 内 部 各 派 在 意 识 形 态 、 宗 教 、 部 族 等 层 面 都 存 在 严 重 分 歧 ， 蒂 托 · 奥 凯 洛 也 并 不 是 一 个 能 够 将 各 方 力 量 凝 聚 在 一 起 的 强 力 领 袖 ， 这 导 致 新 政 权 依 旧 软 弱 无 能 、 效 率 低 下 。 政 府 军 的 军 纪 也 并 没 有 比 奥 博 特 时 代 好 多 少 ， 甚 至 有 增 无 减 ， 步 入 了 失 控 状 态 。||对 于 与 全 国 抵 抗 军 在 肯 尼 亚 首 都 内 罗 毕 进 行 的 和 谈 ， 奥 凯 洛 政 府 也 并 不 热 衷 ， 在 一 方 面 与 穆 塞 韦 尼 于 内 罗 毕 展 开 会 谈 的 同 时 ， 政 府 军 仍 旧 在 对 全 国 抵 抗 军 进 行 攻 击 ， 这 种 出 尔 反 尔 的 行 为 与 奥 凯 洛 吸 纳 阿 明 旧 部 的 行 径 在 政 府 军 内 引 起 了 普 遍 不 满 ， 再 加 上 许 多 其 他 部 族 的 军 人 被 夹 在 了 阿 乔 利 派 与 兰 戈 派 的 冲 突 中 ， 越 来 越 多 的 军 队 向 全 国 抵 抗 军 投 诚 。 而 在 卡 塞 塞 地 区 的 守 军 也 宣 布 效 忠 全 国 抵 抗 军 后 ， 该 组 织 已 一 举 控 制 三 大 解 放 区 ， 终 于 有 能 力 发 动 全 国 解 放 战 争 ， 乌 干 达 的 人 民 战 争 进 入 了 最 后 阶 段 — — 阵 地 战 。";
			break;
		case 1:
			a.ingamewars[81] = new War().Name("乌 干 达 内 战").Attacker("全 国 抵 抗 军").Defender("政 府 军")
				.AttackerInfluence(800)
				.DefenderInfluence(200)
				.CreateWar;
			text = " 乌 干 达 似 乎 没 有 比 政 变 前 更 接 近 和 平 。 发 出 和 谈 呼 吁 后 ， 政 变 集 团 成 功 借 助 自 己 反 奥 博 特 的 立 场 笼 络 到 了 其 他 政 治 与 军 事 势 力 ， 组 建 起 了 自 己 的 政 治 同 盟 。 协 助 奥 凯 洛 发 动 政 变 的 阿 明 残 军 自 然 加 盟 其 中 ， 而 民 主 党 、 卡 伊 拉 的 乌 干 达 自 由 运 动 和 从 其 中 分 裂 出 来 的 联 邦 民 主 运 动 也 在 枪 杆 子 的 威 逼 和 高 官 厚 禄 的 利 诱 下 再 次 同 压 迫 者 站 在 了 一 起 。 然 而 ， 政 府 内 部 各 派 在 意 识 形 态 、 宗 教 、 部 族 等 层 面 都 存 在 严 重 分 歧 ， 蒂 托 · 奥 凯 洛 也 并 不 是 一 个 能 够 将 各 方 力 量 凝 聚 在 一 起 的 强 力 领 袖 ， 这 导 致 新 政 权 依 旧 软 弱 无 能 、 效 率 低 下 。 政 府 军 的 军 纪 也 并 没 有 比 奥 博 特 时 代 好 多 少 ， 甚 至 有 增 无 减 ， 步 入 了 失 控 状 态 。||对 于 与 全 国 抵 抗 军 在 肯 尼 亚 首 都 内 罗 毕 进 行 的 和 谈 ， 奥 凯 洛 政 府 也 并 不 热 衷 ， 在 一 方 面 与 穆 塞 韦 尼 于 内 罗 毕 展 开 会 谈 的 同 时 ， 政 府 军 仍 旧 在 对 全 国 抵 抗 军 进 行 攻 击 ， 这 种 出 尔 反 尔 的 行 为 与 奥 凯 洛 吸 纳 阿 明 旧 部 的 行 径 在 政 府 军 内 引 起 了 普 遍 不 满 ， 再 加 上 许 多 其 他 部 族 的 军 人 被 夹 在 了 阿 乔 利 派 与 兰 戈 派 的 冲 突 中 ， 越 来 越 多 的 军 队 向 全 国 抵 抗 军 投 诚 。 而 在 卡 塞 塞 地 区 的 守 军 也 宣 布 效 忠 全 国 抵 抗 军 后 ， 该 组 织 已 一 举 控 制 三 大 解 放 区 ， 终 于 有 能 力 发 动 全 国 解 放 战 争 ， 乌 干 达 的 人 民 战 争 进 入 了 最 后 阶 段 — — 阵 地 战 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
