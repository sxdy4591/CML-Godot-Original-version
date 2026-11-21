using EventsForDLC;
using UnityEngine;

public class Event621 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "一 个 独 裁 者 将 会 被 另 一 个 独 裁 者 杀 死";
		text = "自1968 年 独 立 以 来 ， 赤 道 几 内 亚 便 一 直 处 于 马 西 埃 · 恩 圭 马 的 统 治 。 在 其 治 下 ， 知 识 分 子 大 量 被 屠 杀 ， 以 芳 族 为 尊 并 屠 杀 和 排 斥 其 他 民 族 。 在1979 年6 月 ， 由 于 军 队 欠 饷 ， 数 十 个 军 官 要 求 支 付 薪 水 却 惨 遭 马 西 埃 杀 害 ， 马 西 埃 的 侄 子 ， 国 防 副 部 长 奥 比 昂 · 恩 圭 马 因 此 策 划 了 一 场 政 变 试 图 推 翻 马 西 埃 的 统 治 ， 但 是 失 败 了 。 不 过 马 西 埃 并 未 发 现 奥 比 昂 是 政 变 策 划 者 。 之 后 马 西 埃 谋 杀 了 他 的 数 个 家 人 ， 其 中 就 包 括 奥 比 昂 的 兄 弟 。 此 举 导 致 了 赤 道 几 内 亚 执 政 核 心 圈 子 的 恐 慌 ， 有 传 闻 奥 比 昂 即 将 发 动 政 变 推 翻 马 西 埃 。 在 此 关 键 时 刻 ， 我 们 可 以 选 择 帮 助 奥 比 昂 来 推 翻 马 西 埃 ； 如 果 我 们 真 的 很 想 和 马 西 埃 拉 近 关 系 的 话 ， 也 可 以 帮 助 他 稳 定 政 权 ； 以 及 ， 我 们 或 许 可 以 借 助 周 边 邻 国 的 法 军 力 量 来 平 定 这 个 西 非 的 小 黑 斑 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] > 1)
		{
			button_text[0] = " 支 持 奥 比 昂";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 为 什 么 要 帮 助 独 裁 者 的 亲 戚 ？";
		}
		if (a.data[56] > 0 && a.data[31] >= 700)
		{
			button_text[1] = " 帮 助 马 西 埃";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 要 协 助 这 个 疯 子 ？";
		}
		if (a.allcountries[21].Torg && a.allcountries[66].puppetOf == 21 && a.allcountries[116].puppetOf == 21)
		{
			button_text[2] = " 电 话 请 转 给 爱 丽 舍 宫";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 为 何 要 帮 助 帝 国 主 义 者 进 行 侵 略 ？";
		}
		button_text[3] = " 赤 道 几 内 亚 ？ 这 个 国 家 在 哪 里 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "一 个 独 裁 者 将 会 被 另 一 个 独 裁 者 杀 死";
		if (result_num == 0)
		{
			text = "我 们 决 定 帮 助 他 们 解 决 马 西 埃 这 个 疯 子 ，8 月3 日 ， 听 命 于 奥 比 昂 的 军 队 占 领 了 首 都 马 拉 博 并 宣 告 马 西 埃 被 推 翻 ， 但 是 与 此 同 时 仍 然 发 电 报 给 马 西 埃 要 求 其 投 降 。 在 马 西 埃 拒 绝 之 后 ， 由 涂 成 黑 脸 的 中 国 特 勤 和 一 些 奥 比 昂 的 士 兵 将 马 西 埃 进 行 秘 密 绑 架 并 送 回 了 政 变 军 所 控 制 的 地 区 ， 听 闻 马 西 埃 被 捕 的 消 息 ， 剩 余 原 本 支 持 马 西 埃 的 军 队 放 下 武 器 投 降 ， 奥 比 昂 最 终 政 变 成 功 。 在 审 判 之 前 由 于 赤 道 几 内 亚 根 本 没 有 宪 法 ， 不 得 不 使 用 西 班 牙 的 军 事 法 律 对 其 进 行 审 判 。 最 终 以 种 族 灭 绝 罪 ， 大 规 模 谋 杀 等 罪 名 判 处 马 西 埃 等 高 层 死 刑 。 奥 比 昂 很 感 激 我 们 ， 选 择 扩 大 与 我 们 的 合 作 。 之 后 在 全 民 公 投 中 通 过 了 新 宪 法 ， 以 奥 比 昂 为 主 的 “ 民 选 ” 政 府 代 替 了 政 变 时 期 的 军 事 委 员 会 ， 赤 道 几 内 亚 终 于 恢 复 正 常 了 … … 吗 ？";
			a.allcountries[115].Gosstroy = 0;
			a.allcountries[115].SubGosstroy = 7;
			a.allcountries[115].LeaveAlliances();
			a.allcountries[115].Torg = true;
			a.influencePRC += 10;
			a.data[22] -= 50;
			a.data[9] -= 50;
		}
		if (result_num == 1)
		{
			text = "我 们 将 我 们 获 悉 的 情 报 转 交 给 了 马 西 埃 。8 月2 日 ， 马 西 埃 提 前 动 手 ， 以 邀 请 聚 餐 为 由 把 试 图 发 动 政 变 的 军 官 聚 集 起 来 ， 正 当 聚 餐 达 到 高 潮 之 际 ， 马 西 埃 以 上 厕 所 为 由 离 开 了 ， 随 后 总 统 卫 队 闯 了 进 来 ， 将 在 场 所 有 军 官 全 部 扫 成 了 马 蜂 窝 。 在 第 二 天 ， 马 西 埃 宣 布 破 获 了 以 奥 比 昂 为 首 的 反 对 马 西 埃 的 势 力 ， 并 宣 布 由 于 其 叛 国 而 被 枪 决 。 在 此 之 后 ， 马 西 埃 很 感 激 我 们 的 行 动 ， 开 始 扩 大 与 我 们 的 合 作 。";
			a.allcountries[115].LeaveAlliances();
			a.allcountries[115].Torg = true;
			a.influencePRC += 10;
			a.data[22] -= 70;
			a.data[9] -= 50;
		}
		if (result_num == 2)
		{
			text = "在 我 们 与 爱 丽 舍 宫 的 协 商 之 后 ， 两 国 就 解 决 赤 道 几 内 亚 人 道 主 义 问 题 一 事 达 成 共 识 ： 出 兵 解 决 马 西 埃 。 第 二 天 ， 从 利 伯 维 尔 国 际 机 场 出 发 的 法 军 空 降 兵 空 降 到 赤 几 首 都 马 拉 博 ， 宣 布 法 军 正 式 接 管 赤 道 几 内 亚 并 开 始 将 赤 道 几 内 亚 从 混 乱 中 拯 救 出 来 。 在 老 家 别 墅 的 马 西 埃 知 道 消 息 后 立 刻 向 法 军 投 降 ， 法 军 兵 不 血 刃 的 拿 下 了 整 个 赤 道 几 内 亚 。 前 赤 道 几 内 亚 驻 加 篷 大 使 克 莱 门 特 · 阿 特 巴 成 为 了 赤 道 几 内 亚 的 新 总 统 。 国 防 副 部 长 则 奥 比 昂 宣 布 对 阿 巴 特 总 统 和 法 军 保 持 忠 诚 ， 马 西 埃 则 被 送 到 法 国 接 受 法 国 军 事 法 庭 审 判 ， 最 终 以 种 族 灭 绝 罪 ， 大 规 模 谋 杀 等 罪 名 判 处 马 西 埃 死 刑 。 在 此 次 行 动 后 ， 赤 道 几 内 亚 宣 布 扩 大 与 我 们 和 法 国 的 合 作 ， 法 军 继 续 驻 扎 在 马 拉 博 。";
			a.allcountries[115].Gosstroy = 0;
			a.allcountries[115].SubGosstroy = 7;
			a.allcountries[115].LeaveAlliances();
			a.allcountries[115].Torg = true;
			a.allcountries[115].puppetOf = 21;
			a.data[9] -= 50;
		}
		if (result_num == 3)
		{
			text = "8 月3 日 ， 听 命 于 奥 比 昂 的 军 队 占 领 了 首 都 马 拉 博 并 宣 告 马 西 埃 被 推 翻 ， 但 是 与 此 同 时 仍 然 发 电 报 给 马 西 埃 要 求 其 投 降 。 在 马 西 埃 拒 绝 之 后 奥 比 昂 的 政 变 军 开 始 释 放 监 狱 里 的 囚 犯 并 将 其 武 装 起 来 ， 奥 比 昂 的 政 变 军 很 快 便 在 巴 塔 附 近 包 围 并 俘 虏 了 马 西 埃 。 奥 比 昂 最 终 政 变 成 功 。 在 审 判 之 前 由 于 赤 道 几 内 亚 根 本 没 有 宪 法 ， 不 得 不 使 用 西 班 牙 的 军 事 法 律 对 其 进 行 审 判 。 最 终 以 种 族 灭 绝 罪 ， 大 规 模 谋 杀 等 罪 名 判 处 马 西 埃 等 高 层 死 刑 。 之 后 在 全 民 公 投 中 通 过 了 新 宪 法 ， 以 奥 比 昂 为 主 的 “ 民 选 ” 政 府 代 替 了 政 变 时 期 的 军 事 委 员 会 ， 赤 道 几 内 亚 终 于 恢 复 正 常 了 … … 吗 ？";
			a.allcountries[115].Gosstroy = 0;
			a.allcountries[115].SubGosstroy = 7;
		}
	}
}
