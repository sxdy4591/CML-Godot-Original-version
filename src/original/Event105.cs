using EventsForDLC;
using UnityEngine;

public class Event105 : EventsSecond
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
		name = " 阿 尔 巴 尼 亚 的 斯 大 林 的 终 结";
		if (GlobalScript.inst.gameState.event_done[77])
		{
			text = " 来 自 阿 尔 巴 尼 亚 的 有 趣 消 息 ：4 月11 日 ， 阿 尔 巴 尼 亚 的 终 身 领 导 人 恩 维 尔 · 霍 查 逝 世 ， 享 年76 岁 。 在 这 个 国 家 为 自 己 的 损 失 感 到 悲 痛 的 同 时 ， 拉 米 兹 · 阿 利 雅 接 任 了 阿 尔 巴 尼 亚 劳 动 党 中 央 委 员 会 第 一 书 记 的 职 位 ， 长 期 以 来 ， 他 被 认 为 是 霍 查 的 继 任 者 ， 在 击 败 穆 罕 默 德 · 谢 胡 的 集 团 中 发 挥 了 重 要 作 用 。 阿 利 雅 欣 赏 霍 查 并 无 条 件 支 持 其 政 策 的 所 有 转 变 ， 但 是 ， 据 一 些 报 道 ， 他 并 不 反 对 与 西 方 和 南 斯 拉 夫 建 立 关 系 ， 也 不 反 对 在 国 内 政 治 上 做 出 一 些 让 步 。 一 方 面 ， 这 会 影 响 到 我 们 ， 另 一 方 面 ， 也 不 知 道 它 会 如 何 结 束 。 因 此 ， 我 们 可 以 组 织 对 新 统 治 者 的 恐 怖 袭 击 ， 当 然 ， 如 果 我 们 在 附 近 有 特 工 的 话 。";
		}
		else
		{
			text = " 新 华 社 1 9 8 5 年 4 月 1 1 日 地 拉 那 电 ： 阿 尔 巴 尼 亚 的 终 身 领 导 人 恩 维 尔 • 霍 查 逝 世 ， 享 年 7 6 岁 。 在 这 个 国 家 为 自 己 的 损 失 感 到 悲 痛 的 同 时 ， 拉 米 兹 • 阿 利 雅 接 任 了 阿 尔 巴 尼 亚 劳 动 党 中 央 委 员 会 第 一 书 记 的 职 位 ， 长 期 以 来 ， 他 被 认 为 是 霍 查 的 继 任 者 ， 在 P P S h （ 阿 尔 巴 尼 亚 劳 动 党 ） 的 早 起 历 程 和 游 击 战 中 立 下 了 汗 马 功 劳 。 阿 利 雅 欣 赏 霍 查 并 无 条 件 支 持 其 政 策 的 所 有 转 变 ， 但 是 ， 据 一 些 报 道 ， 他 并 不 反 对 与 西 方 和 东 方 集 团 建 立 关 系 ， 也 不 反 对 在 国 内 政 治 上 做 出 一 些 让 步 。 一 方 面 ， 阿 尔 巴 尼 亚 可 能 会 寻 求 其 他 国 家 的 援 助 而 抛 弃 我 们 。 另 一 方 面 ， 我 们 也 不 知 道 会 不 会 真 的 这 么 做 。 因 此 ， 我 们 可 以 打 打 这 个 不 听 话 小 孩 的 屁 股 ， 当 然 ， 如 果 我 们 在 附 近 有 特 工 的 话 。 ";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 什 么 都 不 做";
		if ((GlobalScript.inst.gameState.allcountries[15].Torg || GlobalScript.inst.gameState.allcountries[20].Torg) && GlobalScript.inst.gameState.data[9] >= 60)
		{
			button_text[1] = " 招 募 一 群 科 索 沃 阿 尔 巴 尼 亚 人 并 发 动 一 次 恐 怖 袭 击 （-6 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
		}
		if (!GlobalScript.inst.gameState.allcountries[20].Torg && !GlobalScript.inst.gameState.allcountries[20].proprc)
		{
			button_text[2] = " 尝 试 与 新 的 管 理 层 建 立 关 系 （ 需 要3 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 中 阿 关 系 平 稳 如 常";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 阿 尔 巴 尼 亚 的 斯 大 林 的 终 结";
		switch (result_num)
		{
		case 0:
			text = " 正 如 预 期 的 那 样 ， 拉 米 兹 · 阿 利 雅 并 没 有 “ 打 破 那 些 行 之 有 效 的 方 法 ” 。 在 公 共 生 活 的 各 个 方 面 ， 劳 动 党 都 保 持 着 完 全 和 绝 对 的 监 督 ， 正 统 的 斯 大 林 主 义 者 继 续 统 治 阿 尔 巴 尼 亚 劳 动 党 。 然 而 ， 该 政 权 仍 经 历 了 一 些 并 不 明 显 的 变 化: 大 规 模 镇 压 迅 速 减 少 ， 逮 捕 神 职 人 员 的 行 动 停 止 ， 对 异 见 人 士 的 镇 压 变 得 “ 更 加 精 确 ” 。 而 且 ， 尽 管 阿 利 雅 不 打 算 恢 复 与 苏 联 的 积 极 关 系 ， 但 人 们 开 始 感 觉 到 阿 尔 巴 尼 亚 外 交 政 策 倾 向 于 更 大 程 度 的 开 放 。";
			GlobalScript.inst.gameState.data[60] = 2;
			GlobalScript.inst.gameState.allcountries[20].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 1;
			break;
		case 1:
			if (GlobalScript.inst.gameState.allcountries[20].parts[0])
			{
				text = "新 华 社 1 9 8 5 年 4 月 1 1 日 电 ， 在 阿 尔 巴 尼 亚 首 都 地 拉 那 爆 发 了 惊 人 的 事 件 。 一 伙 武 装 分 子 在 众 目 睽 睽 之 下 ， 击 毙 了 正 在 斯 坎 德 培 广 场 做 就 职 演 讲 的 新 阿 尔 巴 尼 亚 劳 动 党 第 一 书 记 拉 米 兹 · 阿 利 雅 。 尽 管 这 位 阿 尔 巴 尼 亚 的 新 领 袖 周 围 占 满 了 卫 兵 ， 依 然 没 能 阻 止 惨 案 的 发 生 。 凶 手 连 开 三 枪 ， 一 发 打 中 了 前 胸 ， 致 命 的 一 颗 子 弹 则 打 进 了 肺 部 。 夺 走 了 他 的 生 命 。 在 警 察 部 队 的 不 懈 努 力 下 ， 一 名 科 索 沃 阿 尔 巴 尼 亚 人 被 抓 获 。 他 承 认 接 受 了 贝 里 沙 的 资 金 用 于 除 掉 阿 利 雅 。 随 后 他 被 判 处 死 刑 。||随 后 ， 一 场 政 变 在 地 拉 那 爆 发 了 。 波 克 夫 · 穆 拉 带 领 忠 诚 的 人 民 军 士 兵 攻 入 了 政 府 大 楼 ， 并 宣 布 “ 要 为 死 去 的 阿 利 雅 同 志 复 仇 ” 。 随 后 ， 人 民 军 血 洗 了 整 个 地 拉 那 ， 大 量 无 辜 的 人 被 扣 以 “ 反 革 命 颠 覆 罪 ” 的 帽 子 被 投 入 修 筑 碉 堡 的 工 作 中 。 阿 尔 巴 尼 亚 劳 动 党 内 的 自 由 派 和 改 革 派 则 被 开 除 党 籍 后 被 处 死 。 新 生 的 政 府 以 穆 拉 为 核 心 ， 丘 科 和 查 尔 查 尼 为 辅 。 外 国 观 察 家 预 测 阿 尔 巴 尼 亚 将 会 天 翻 地 覆 ， 因 为 人 民 军 又 一 次 拿 起 了 枪 ， 放 下 了 镐 。 他 们 的 目 标 是 谁 不 言 而 喻 … … ";
				GlobalScript.inst.gameState.data[9] -= 60;
				GlobalScript.inst.gameState.influencePRC += 5;
				GlobalScript.inst.gameState.data[60] = 3;
				GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 10;
			}
			else if (GlobalScript.inst.gameState.allcountries[20].Gosstroy == 1)
			{
				text = " 新 华 社 1 9 8 5 年 4 月 1 1 日 电 ， 在 阿 尔 巴 尼 亚 首 都 地 拉 那 爆 发 了 惊 人 的 事 件 。 一 伙 武 装 分 子 在 众 目 睽 睽 之 下 ， 击 毙 了 正 在 斯 坎 德 培 广 场 做 就 职 演 讲 的 新 阿 尔 巴 尼 亚 劳 动 党 第 一 书 记 拉 米 兹 · 阿 利 雅 。 尽 管 这 位 阿 尔 巴 尼 亚 的 新 领 袖 周 围 占 满 了 卫 兵 ， 依 然 没 能 阻 止 惨 案 的 发 生 。 凶 手 连 开 三 枪 ， 一 发 打 中 了 前 胸 ， 致 命 的 一 颗 子 弹 则 打 进 了 肺 部 。 夺 走 了 他 的 生 命 。 在 警 察 部 队 的 不 懈 努 力 下 ， 一 名 科 索 沃 阿 尔 巴 尼 亚 人 被 抓 获 。 他 承 认 接 受 了 贝 里 沙 的 资 金 用 于 除 掉 阿 利 雅 。 随 后 他 被 判 处 死 刑 。||为 了 防 止 可 能 爆 发 的 示 威 游 行 ， 阿 尔 巴 尼 亚 总 理 穆 罕 默 德 · 谢 胡 和 国 防 部 长 卡 德 里 · 哈 兹 比 乌 宣 布 临 时 接 管 政 府 。 并 组 建 了 以 忠 诚 的 霍 查 派 为 核 心 的 “ 三 人 帮 ” ， 他 们 分 别 是 涅 奇 米 叶 · 霍 查 ， 莲 卡 · 丘 科 和 阿 迪 尔 · 查 尔 查 尼 。 在 我 们 的 帮 助 下 ， 新 生 领 导 层 借 此 机 会 展 开 了 对 阿 尔 巴 尼 亚 国 内 的 极 端 民 族 主 义 者 和 反 霍 查 派 的 审 察 ， 监 视 和 处 决 。 那 位 枪 手 则 被 大 赦 释 放 。||新 生 的 阿 尔 巴 尼 亚 仍 然 支 持 中 华 人 民 共 和 国 。";
				GlobalScript.inst.gameState.data[9] -= 60;
				GlobalScript.inst.gameState.influencePRC += 5;
				GlobalScript.inst.gameState.data[60] = 3;
				GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 0;
				if (GlobalScript.inst.gameState.allcountries[20].spec == 1)
				{
					text += " 新 政 府 也 强 调 了 会 继 续 停 留 在 巴 尔 干 联 邦 内 。";
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[20].Gosstroy == 0)
			{
				text = "新 华 社 1 9 8 5 年 4 月 1 1 日 电 ， 在 阿 尔 巴 尼 亚 首 都 地 拉 那 爆 发 了 惊 人 的 事 件 。 一 伙 武 装 分 子 在 众 目 睽 睽 之 下 ， 击 毙 了 正 在 斯 坎 德 培 广 场 做 就 职 演 讲 的 新 阿 尔 巴 尼 亚 劳 动 党 第 一 书 记 拉 米 兹 · 阿 利 雅 。 尽 管 这 位 阿 尔 巴 尼 亚 的 新 领 袖 周 围 占 满 了 卫 兵 ， 依 然 没 能 阻 止 惨 案 的 发 生 。 凶 手 连 开 三 枪 ， 一 发 打 中 了 前 胸 ， 致 命 的 一 颗 子 弹 则 打 进 了 肺 部 。 夺 走 了 他 的 生 命 。 在 警 察 部 队 的 不 懈 努 力 下 ， 一 名 科 索 沃 阿 尔 巴 尼 亚 人 被 抓 获 。 他 承 认 接 受 了 贝 里 沙 的 资 金 用 于 除 掉 阿 利 雅 。 随 后 他 被 判 处 死 刑 。||为 了 防 止 可 能 爆 发 的 示 威 ， 阿 尔 巴 尼 亚 组 建 了 以 忠 诚 的 霍 查 派 为 核 心 的 “ 三 人 帮 ” ， 他 们 分 别 是 涅 奇 米 叶 · 霍 查 ， 莲 卡 · 丘 科 和 阿 迪 尔 · 查 尔 查 尼 。 新 生 领 导 层 借 此 暗 杀 展 开 了 对 阿 尔 巴 尼 亚 国 内 反 霍 查 派 的 处 决 。 那 位 枪 手 则 被 大 赦 释 放 。 霍 查 仍 然 被 阿 尔 巴 尼 亚 人 民 视 作 一 位 伟 人 和 英 雄 。 整 体 上 的 路 线 并 没 有 偏 离 这 位 领 袖 定 下 的 方 针 。||新 生 的 阿 尔 巴 尼 亚 仍 然 支 持 中 华 人 民 共 和 国 ， 但 仍 希 望 我 党 能 在 阿 劳 和 一 些 问 题 上 做 同 志 间 的 辩 论 。";
				GlobalScript.inst.gameState.data[9] -= 60;
				GlobalScript.inst.gameState.influencePRC += 5;
				GlobalScript.inst.gameState.data[60] = 3;
				GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 10;
				if (GlobalScript.inst.gameState.allcountries[20].spec == 1)
				{
					text += " 新 政 府 也 强 调 了 会 继 续 停 留 在 巴 尔 干 联 邦 内 。";
				}
			}
			break;
		case 2:
			text = " 中 国 领 导 人 致 函 阿 尔 巴 尼 亚 外 交 部 慰 问 ， 并 建 议 他 “ 重 启 ” 中 阿 关 系 。 一 周 后 ， 拉 米 兹 · 阿 利 雅 对 中 华 人 民 共 和 国 进 行 了 外 交 访 问 ， 重 新 签 署 了 《 中 阿 友 好 条 约 》 ， 中 国 向 阿 尔 巴 尼 亚 提 供 了 长 期 稳 定 的 贷 款 ， 以 示 两 国 和 解 。";
			GlobalScript.inst.gameState.influencePRC += 15;
			GlobalScript.inst.gameState.allcountries[20].Torg = true;
			GlobalScript.inst.gameState.allcountries[20].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 1;
			GlobalScript.inst.gameState.data[60] = 2;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.empires[0].relations -= 80;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
