using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event658 : EventsSecond
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
		name = " 非 洲 死 亡 之 心";
		text = string.Format("<size=36>乍 得 是 一 个 典 型 的 萨 赫 勒 国 家 。 由 于 特 殊 的 地 理 位 置 和 法 国 殖 民 时 代 刻 意 重 用 南 方 民 族 ， 该 国 南 北 方 的 民 族 和 文 化 截 然 不 同 。 而 南 方 人 在 独 立 以 来 就 一 直 主 导 着 整 个 国 家 。 第 一 任 总 统 弗 朗 索 瓦 · 托 姆 巴 巴 耶 的 统 治 以 独 裁 、 极 端 腐 败 和 偏 袒 南 方 人 著 称 ， 同 许 多 非 洲 独 裁 者 一 样 ， 他 对 内 实 行 独 裁 统 治 ， 推 行 大 萨 拉 族 主 义 和 歧 视 北 方 人 的 政 策 ， 这 导 致 了 北 部 和 东 部 的 伊 斯 兰 教 地 区 与 南 方 基 督 徒 主 导 的 政 府 之 间 的 对 立 ， 起 义 层 出 不 穷 。1966 年6 月19 日 ， 马 克 思 主 义 者 易 卜 拉 欣 · 阿 巴 查 将 乍 得 国 内 大 部 分 反 对 南 方 中 央 政 府 的 组 织 整 合 起 来 ， 组 织 成 了 带 有 左 翼 革 命 色 彩 的 大 帐 篷 性 质 组 织 — — 乍 得 民 族 解 放 阵 线 （FROLINAT ， 随 着1968 年 阿 巴 查 的 去 世 以 及 这 之 后 阵 线 内 各 派 系 夺 取 继 承 人 职 位 的 斗 争 ，FROLINAT 逐 渐 转 变 为 亲 利 比 亚 的 左 翼 民 族 主 义 组 织 ， 而 马 克 思 主 义 的 要 素 则 被 完 全 边 缘 化 ） ， 这 标 志 着 内 战 的 开 始 。||随 着 利 比 亚 和 法 国 的 干 预 ， 以 及 叛 军 的 分 裂 ， 乍 得 内 战 逐 渐 演 变 称 三 足 鼎 立 的 局 势 — — 南 部 政 府 军 、 控 制 北 部 与 中 部 的 古 库 尼 · 韦 戴 、 控 制 东 部 的 侯 赛 因 · 哈 布 雷 。1975 年 ， 由 于 托 姆 巴 巴 耶 向 利 比 亚 靠 拢 ， 法 国 扶 持 了 一 场 政 变 ， 在 将 他 杀 死 后 ， 政 变 军 官 们 推 举 了 此 前 被 捕 入 狱 的 费 利 克 斯 · 马 卢 姆 准 将 为 总 统 。 在 反 政 府 武 装 逐 渐 壮 大 的 形 势 下 ， 新 的 军 政 府 主 张 通 过 谈 判 实 现 民 族 和 解 和 全 国 统 一 ， 这 得 到 了 哈 布 雷 派 的 支 持 ， 而 古 库 尼 则 拒 绝 谈 判 。||1978 年8 月 ， 哈 布 雷 同 政 府 和 解 ， 他 本 人 被 马 卢 姆 任 命 为 总 理 。 但 随 着 古 库 尼 派 武 装 逼 近 首 都 ， 联 盟 很 快 便 瓦 解 。 马 卢 姆 总 统 于1979 年3 月 出 逃 。 随 后 ， 乍 得 的 各 个 派 别 在 尼 日 利 亚 的 调 解 下 签 署 《 拉 各 斯 协 议 》 结 束 了 内 战 ， 一 个 涵 盖11 个 不 同 派 别 的 代 表 的 民 族 团 结 过 渡 政 府 （GUNT ） 成 立 了 ， 亲 利 比 亚 的 古 库 尼 · 韦 戴 成 为 了 总 统 ， 而 反 利 比 亚 的 哈 布 雷 成 为 了 国 防 部 长 ， 古 库 尼 派 中 的 强 硬 派 艾 哈 迈 德 · 阿 西 尔 被 任 命 为 外 交 部 长 。||然 而 ， 非 洲 各 国 的 努 力 并 没 能 真 正 停 止 乍 得 的 内 战 。 短 暂 的 和 解 之 后 ， 武 装 冲 突 再 次 爆 发 。1980 年3 月 ， 哈 布 雷 的 部 队 开 始 攻 击 古 库 尼 派 武 装 ， 乍 得 又 一 次 陷 入 全 面 内 战 。12 月 ， 在 利 比 亚 的 直 接 介 入 以 及 苏 联 和 东 德 顾 问 的 帮 助 下 ， 古 库 尼 获 得 了 胜 利 。 哈 布 雷 派 撤 退 到 东 北 边 境 地 区 进 行 游 击 战 。||1981 年 ， 古 库 尼 访 问 利 比 亚 ， 两 国 决 定 合 并 ， 这 一 计 划 引 起 了 非 洲 统 一 组 织 与 法 国 的 强 烈 不 满 ， 由 尼 日 利 亚 、 塞 内 加 尔 和 扎 伊 尔 组 成 的 泛 非 和 平 部 队 陆 续 进 驻 乍 得 维 持 秩 序 。 面 对 国 际 社 会 的 反 对 声 音 ， 两 人 后 来 降 低 了 声 明 的 调 门 ， 将 其 描 述 为 两 国 人 民 之 间 的 “ 联 盟 ” 。 {0}随 着 利 比 亚 的 撤 军 ， 哈 布 雷 领 导 他 的 北 方 武 装 部 队 （FAN ） 从 东 北 部 向 首 都 发 起 反 攻 。 看 来 ， 乍 得 内 战 仍 将 继 续 下 去 。</size>", (a.resultOfEvents[512] != 2) ? " <size=36>尽 管 如 此 ， 这 一 事 件 还 是 削 弱 了 古 库 尼 的 民 族 主 义 形 象 。 随 着 国 际 压 力 的 增 加 ， 古 库 尼 表 示 愿 意 接 受 非 统 组 织 的 调 解 ， 暗 示 利 比 亚 军 队 将 撤 出 乍 得 。 然 而 ， 利 比 亚 军 队 在 乍 得 的 存 在 和 行 动 引 发 了 乍 得 国 内 和 国 际 的 不 满 。 到 了1981 年10 月 ， 由 于 卡 扎 菲 的 伊 斯 兰 军 团 与 古 库 尼 的 军 队 发 生 冲 突 ， 古 库 尼 要 求 利 比 亚 军 队 撤 出 乍 得 。 由 于 卡 扎 菲 寻 求 在1982 年 担 任 非 统 组 织 主 席 ， 同 时 也 因 为 利 比 亚 在 乍 得 的 处 境 变 得 复 杂 ， 利 比 亚 军 队 在11 月 撤 离 。 尽 管 如 此 ， 卡 扎 菲 并 未 放 弃 对 乍 得 的 影 响 力 ， 而 是 开 始 寻 找 一 个 更 可 靠 的 乍 得 领 导 人 来 实 现 他 的 目 标 。</size>" : "<size=36>不 过 这 一 切 都 因 卡 扎 菲 的 身 亡 而 不 了 了 之 ， 古 库 尼 政 府 也 陷 入 了 孤 立 。</size>");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] <= 2 && a.allcountries[13].Gosstroy != 3)
		{
			button_text[0] = "帮 助GUNT ， 斩 断 法 、 美 伸 向 非 洲 的 黑 手 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 对 “ 中 东 疯 狗 ” 和 他 的 弟 子 不 感 兴 趣";
		}
		if (GlobalScript.inst.gameState.data[56] >= 3 && (a.allcountries[21].Torg || a.empires[0].relations >= 500))
		{
			if (a.resultOfEvents[512] != 2)
			{
				button_text[1] = "大 家 都 受 够 卡 扎 菲 了 ， 让 我 们 帮 助 哈 布 雷";
			}
			else
			{
				button_text[1] = "让 我 们 帮 助 哈 布 雷";
			}
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 还 不 至 于 要 勾 结 美 帝 和 法 帝 … …";
		}
		if (a.data[56] <= 1 && a.allcountries[13].Torg && a.resultOfEvents[512] != 2)
		{
			button_text[2] = "应 该 给 乍 得 选 一 个 立 场 更 坚 定 的 人 … …";
		}
		else
		{
			Object.Destroy(button[2]);
			if (a.resultOfEvents[512] != 2)
			{
				button_text[2] = " 卡 扎 菲 不 值 得 我 们 的 帮 助";
			}
			else
			{
				button_text[2] = " 已 经 不 用 这 么 做 了";
			}
		}
		button_text[3] = "什 么 ， 原 来 他 们 还 在 打 内 战 吗 ？";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 非 洲 死 亡 之 心";
		a.allcountries[57].parts[0] = true;
		a.ingamewars[80] = new War().Name("乍 得 内 战").Attacker("UGNT").Defender("FAN")
			.AttackerInfluence(500)
			.DefenderInfluence(500)
			.AmericanSupportDefender.SovietSupportAttacker.CreateWar;
		switch (result_num)
		{
		case 0:
			text = " 我 们 支 持 了 利 比 亚 和 乍 得UGNT 政 府 反 对 法 、 美 帝 国 主 义 的 斗 争 。 一 艘 货 轮 驶 往 利 比 亚 ， 将 我 们 的 援 助 输 往 乍 得 这 个 非 洲 内 陆 国 ， 让 我 们 祝 古 库 尼 好 运 吧 ！||";
			if (a.resultOfEvents[512] != 2)
			{
				text += " 卡 扎 菲 没 有 忘 记 我 们 的 支 持 ， 来 自 利 比 亚 的 廉 价 石 油 将 未 我 们 的 工 业 发 展 提 供 更 多 动 力 。||";
			}
			text += " 11 月19 日 ，FAN 攻 占 了 乍 得 东 部 重 要 城 市 阿 贝 歇 ， 次 年1 月 初 ， 乌 姆 哈 杰 尔 也 沦 陷 了 。 非 统 组 织 要 求 双 方 开 展 和 解 谈 判 ， 但 古 库 尼 坚 决 拒 绝 和 谈 ， 并 指 责 非 统 组 织 干 涉 乍 得 内 政 。 希 望 局 势 会 好 转 吧 … … ";
			a.ingamewars[80].infl1 += 50;
			a.ingamewars[80].infl2 -= 50;
			a.data[6] += 50;
			a.data[8] -= 150;
			a.data[22] -= 150;
			a.empires[0].relations += 50;
			a.empires[1].relations += 50;
			a.OilProd += 100f;
			break;
		case 1:
			text = " 我 们 通 过 和 法 国 的 关 系 对FAN 和 哈 布 雷 提 供 了 我 们 的 支 援 。 一 艘 货 轮 驶 往 苏 丹 ， 将 我 们 的 援 助 输 往 乍 得 这 个 非 洲 内 陆 国 ， 让 我 们 祝 哈 布 雷 好 运 吧 ！||11 月19 日 ，FAN 攻 占 了 乍 得 东 部 重 要 城 市 阿 贝 歇 ， 次 年1 月 初 ， 乌 姆 哈 杰 尔 也 沦 陷 了 。 非 统 组 织 要 求 双 方 开 展 和 解 谈 判 ， 但 古 库 尼 坚 决 拒 绝 和 谈 ， 并 指 责 非 统 组 织 干 涉 乍 得 内 政 。 希 望 局 势 会 好 转 吧 … …";
			a.ingamewars[80].infl1 -= 50;
			a.ingamewars[80].infl2 += 50;
			a.data[6] -= 50;
			a.data[8] -= 150;
			a.data[22] -= 150;
			a.empires[0].relations -= 50;
			break;
		case 2:
			text = " 我 们 的 特 工 联 系 到 利 比 亚 和 艾 哈 迈 德 · 阿 西 尔 ， 并 为 他 们 制 定 了 一 个 他 们 难 以 拒 绝 的 计 划 。 一 天 夜 里 ， 忠 于 阿 西 尔 的 部 队 和 利 比 亚 的 特 工 将 古 库 尼 逮 捕 了 起 来 。 第 二 天 早 上 ， 古 库 尼 宣 布 自 己 将 因 “ 身 体 原 因 ” 辞 职 ， 将 总 统 的 职 位 让 给 更 能 胜 任 此 职 的 阿 西 尔 ， 他 自 己 将 前 往 利 比 亚 “ 度 假 ” 。 作 为 唯 一 一 个 不 反 对 利 比 亚 和 乍 得 的 合 并 计 划 的 领 导 人 ， 想 必 他 将 更 忠 诚 于 世 界 第 三 理 论 和 《 绿 皮 书 》 ， 将 这 个 内 陆 国 带 出 西 方 帝 国 主 义 的 阴 影 。||我 们 支 持 了 利 比 亚 和 乍 得UGNT 政 府 反 对 法 、 美 帝 国 主 义 的 斗 争 。 一 艘 货 轮 驶 往 利 比 亚 ， 将 我 们 的 援 助 输 往 乍 得 这 个 非 洲 内 陆 国 ， 让 我 们 祝 阿 西 尔 好 运 吧 ！||卡 扎 菲 没 有 忘 记 我 们 的 支 持 ， 来 自 利 比 亚 的 廉 价 石 油 将 未 我 们 的 工 业 发 展 提 供 更 多 动 力 。||11 月19 日 ， F A N 攻 占 了 乍 得 东 部 重 要 城 市 阿 贝 歇 ， 次 年1 月 初 ， 乌 姆 哈 杰 尔 也 沦 陷 了 。 非 统 组 织 要 求 双 方 开 展 和 解 谈 判 ， 阿 西 尔 表 示 拒 绝 ， 宣 布 将 忠 于 乍 得 革 命 和 易 卜 拉 欣 · 阿 巴 查 的 事 业 。 希 望 局 势 会 好 转 吧 … …";
			a.ingamewars[80].infl1 += 50;
			a.ingamewars[80].infl2 -= 50;
			a.data[6] += 50;
			a.data[8] -= 150;
			a.data[22] -= 150;
			a.empires[1].relations += 50;
			a.OilProd += 100f;
			break;
		case 3:
			text = " 11 月19 日 ，FAN 攻 占 了 乍 得 东 部 重 要 城 市 阿 贝 歇 ， 次 年1 月 初 ， 乌 姆 哈 杰 尔 也 沦 陷 了 。 非 统 组 织 要 求 双 方 开 展 和 解 谈 判 ， 但 古 库 尼 坚 决 拒 绝 和 谈 ， 并 指 责 非 统 组 织 干 涉 乍 得 内 政 。 希 望 局 势 会 好 转 吧 … …";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
