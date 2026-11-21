using EventsForDLC;
using UnityEngine;

public class Event585 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 法 兰 西 殖 民 主 义 的 终 结";
		text = " 主 席 同 志 ， 在 1 9 7 7 年 5 月 8 日 ， 法 国 阿 法 尔 和 伊 萨 斯 领 地 举 行 了 第 三 次 独 立 公 投 。 之 前 的 公 投 是 在 1 9 5 8 年 和 1 9 6 7 年 举 行 的 ， 因 为 法 国 人 从 中 做 梗 而 独 立 未 遂 。 这 次 公 投 则 支 持 从 法 国 独 立 。 有 9 8 . 8 % 的 选 民 支 持 脱 离 法 国 ， 正 式 标 志 着 吉 布 提 的 独 立 。 我 们 不 能 忘 记 是 因 为 是 索 马 里 大 力 支 持 的 F L N C （ 索 马 里 沿 海 解 放 阵 线 ） 开 展 了 武 装 斗 争 ， 从 而 促 使 法 国 放 弃 这 块 领 土 。 伊 萨 族 政 治 家 哈 桑 · 古 莱 德 · 阿 普 蒂 敦 在 1 9 5 8 年 的 公 投 中 就 开 始 反 对 法 国 统 治 ， 他 带 领 着 人 民 争 取 独 立 联 盟 参 选 ， 并 顺 利 成 为 第 一 任 总 统 。||当 然 ， 哈 桑 · 古 莱 德 · 阿 普 蒂 敦 只 能 代 表 南 部 的 伊 萨 族 ， 而 不 能 代 表 北 部 的 阿 法 尔 人 ， 这 也 为 潜 在 的 冲 突 酝 酿 了 契 机 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 这 是 帝 国 主 义 的 终 结 ！";
		if (a.data[56] <= 1)
		{
			button_text[1] = " 派 遣 大 使 ， 借 机 施 加 我 们 的 影 响 力";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 兴 趣 参 与 他 们 的 事 情";
		}
		if (a.empires[1].relations <= 700)
		{
			button_text[2] = " 秘 密 联 络 反 对 派";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = " 他 们 还 是 太 弱 小 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 法 兰 西 殖 民 主 义 的 终 结";
		a.allcountries[106].Gosstroy = 2;
		a.allcountries[106].SubGosstroy = 8;
		a.allcountries[106].name = " 吉 布 提 共 和 国";
		a.allcountries[106].LeaveAlliances();
		if (result_num == 0)
		{
			text = " 又 一 个 国 家 从 帝 国 主 义 的 压 迫 中 解 放 了 出 来 。";
		}
		if (result_num == 1)
		{
			text = " 我 们 承 认 了 吉 布 提 的 独 立 ， 借 助 坦 桑 尼 亚 经 验 鼓 励 哈 桑 总 统 建 立 一 个 泛 左 翼 的 政 党 — — 人 民 革 命 运 动 党 。 该 党 由 联 合 原 全 国 独 立 联 盟 ， 索 马 里 解 放 阵 线 ， 吉 布 提 解 放 运 动 ， 人 民 解 放 运 动 等 组 织 的 部 分 人 士 组 成 。 所 有 议 员 ， 政 府 成 员 和 政 界 知 名 人 士 均 为 该 党 成 员 ， 所 有 公 民 均 被 号 召 参 加 。 同 时 取 缔 了 所 有 反 对 党 ， 该 党 则 被 宣 布 为 唯 一 的 合 法 政 党 。 第 一 次 全 国 代 表 大 会 再 次 确 定 了 古 莱 德 主 席 等 领 导 人 的 地 位 和 该 党 的 政 策 。 该 党 章 程 规 定 其 目 标 是 “ 使 不 利 于 实 现 人 民 福 利 的 各 松 散 的 力 量 统 一 起 来 ” ， “ 迅 速 使 国 家 非 部 族 主 义 化 ” ， “ 在 全 国 各 阶 级 团 结 的 基 础 上 ， 从 事 国 家 的 经 济 、 政 治 和 文 化 方 面 的 建 设 。 ”   章 程 还 规 定 该 国 和 索 马 里 是 “ 同 根 同 源 的 革 命 战 友 ， 应 展 开 必 要 的 合 作 ， 从 而 实 现 索 马 里 民 族 乃 至 非 洲 的 统 一 ” 。 他 们 事 实 上 邀 请 索 马 里 陆 军 取 代 了 自 己 的 武 装 力 量 ， 仅 仅 保 留 了 治 安 部 队 。 而 我 们 作 为 幕 后 推 手 ， 自 然 也 得 到 了 一 些 好 处 。||西 亚 德 · 巴 雷 少 将 非 常 感 谢 我 们 ， 他 在 摩 加 迪 沙 的 群 众 大 会 上 说 到 ： “" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "主 席 是 索 马 里 人 民 的 最 热 忱 的 革 命 战 友 ， 可 以 说 是 大 恩 人 ， 大 救 星 ” 。";
			a.data[8] -= 20;
			a.data[9] -= 20;
			a.allcountries[106].Gosstroy = 1;
			a.allcountries[106].SubGosstroy = 1;
			a.allcountries[106].LeaveAlliances();
			a.allcountries[106].Torg = true;
			a.allcountries[106].proprc = true;
			a.allcountries[106].soc_stab = 1000;
			a.empires[0].relations -= 100;
			a.influencePRC += 10;
			a.data[6] += 5;
		}
		if (result_num == 2)
		{
			text = " 意 识 到 一 个 索 马 里 占 据 主 导 的 非 洲 之 角 并 不 符 合 我 们 的 均 势 思 想 ， 我 们 将 目 光 投 向 了 阿 法 尔 人 。 他 们 是 埃 塞 人 天 生 的 盟 友 ， 而 埃 塞 的 背 后 是 谁 我 们 都 知 道 。||在 亚 丁 ， 外 联 部 的 同 志 设 法 将 三 个 阿 法 尔 人 组 织 - 吉 布 提 修 正 秩 序 行 动 、 恢 复 权 利 和 平 等 阵 线 以 及 吉 布 提 爱 国 抵 抗 阵 线 的 合 并 事 宜 达 成 了 磋 商 ， 组 成 了 F R U D （ 恢 复 统 一 与 民 主 联 盟 ） 。 " + ((a.allcountries[41].SubGosstroy == 10) ? "海 尔 · 马 里 亚 姆 · 门 格 斯 图 上 校" : " 特 法 里 · 本 蒂") + " 亲 切 的 接 见 了 F R U D 的 领 导 人 艾 哈 迈 德 · 迪 尼 · 艾 哈 迈 德 。 在 埃 塞 和 南 也 门 的 苏 军 帮 助 下 ， F R U D 的 武 装 力 量 “ 人 民 冲 锋 队 ” 在 北 部 发 起 了 和 政 府 军 的 战 争 。 而 吉 布 提 的 新 政 府 指 控 苏 联 和 我 们 在 背 后 试 图 推 翻 政 府 ， 西 亚 德 · 巴 雷 少 校 自 然 支 持 索 马 里 人 的 政 府 ， 但 出 于 同 我 们 和 苏 联 合 作 的 需 要 ， 他 只 得 转 而 指 控 美 帝 国 主 义 者 。";
			a.allcountries[41].Torg = true;
		}
	}
}
