using EventsForDLC;
using UnityEngine;

public class Event592 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 再 无 “ 非 洲 奇 迹 ”";
		text = " 自 1 9 5 9 年 科 特 迪 瓦 独 立 以 来 ， 乌 弗 埃 · 博 瓦 尼 便 找 到 了 发 展 方 向 ， 通 过 把 自 己 强 调 为 自 由 世 界 在 西 非 的 橱 窗 从 而 获 得 了 不 少 支 持 。 投 桃 报 李 的 方 式 也 非 常 简 单 ： 博 瓦 尼 几 乎 惹 毛 了 每 一 个 非 洲 国 家 。 在 几 内 亚 支 持 葡 萄 牙 入 侵 ， 在 尼 日 利 亚 支 持 比 夫 拉 独 立 ， 在 南 部 非 洲 鼓 动 与 白 人 南 非 的 和 解 并 承 认 罗 得 西 亚 ， 在 加 纳 更 是 推 翻 了 我 们 的 老 朋 友 恩 克 鲁 玛 。 而 现 在 ， 复 仇 的 时 候 已 然 来 到 ： 随 着 社 会 主 义 在 西 非 攻 城 拔 寨 ， 越 来 越 多 的 青 年 一 代 开 始 不 满 足 于 博 瓦 尼 的 政 权 。 国 际 可 可 与 咖 啡 的 价 格 极 速 下 调 导 致 的 经 济 崩 溃 ， 建 设 新 首 都 的 巨 额 资 金 让 该 国 人 民 的 生 活 雪 上 加 霜 。 越 来 越 多 的 罢 工 和 罢 课 使 得 博 瓦 尼 政 府 越 发 不 稳 。 在 本 次 非 洲 进 步 国 家 部 长 会 议 上 ， 几 内 亚 ， 布 基 纳 法 索 和 加 纳 都 同 意 帮 助 科 特 迪 瓦 人 民 一 把 ， 帮 助 他 们 争 取 自 己 的 独 立 和 幸 福 生 活 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 冲 啊 ！ 勇 士 们 ！ 为 1 9 6 6 年 复 仇 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 再 无 “ 非 洲 奇 迹 ”";
		if (result_num == 0)
		{
			text = string.Concat(" 三 国 组 建 了 一 支 统 一 调 度 的 武 装 部 队 ， 代 号 “ 象 牙 ” 的 行 动 一 触 即 发 。 在 得 到 阿 比 让 的 信 息 之 后 ， 三 军 从 北 ， 西 和 东 方 攻 入 了 这 个 小 国 。 加 纳 人 民 军 迅 速 开 入 了 阿 比 让 内 ， 在 科 国 内 的 象 牙 海 岸 革 命 共 产 党 的 帮 助 下 顺 利 攻 占 了 首 都 总 统 府 和 广 播 电 台 ， 号 召 全 体 人 民 起 义 ， 夺 权 ， 彻 底 革 命 。 与 此 同 时 几 内 亚 和 布 基 纳 法 索 的 武 装 力 量 攻 入 了 亚 穆 克 苏 罗 ， 来 不 及 为 城 中 的 巨 大 教 堂 感 到 震 惊 ， 他 们 还 需 要 快 速 的 南 下 和 加 纳 会 师 。 而 法 国 和 美 国 拒 绝 武 装 介 入 这 一 问 题 。 仅 仅 是 谴 责 了 三 国 的 暴 力 行 为 ， 提 供 了 除 干 涉 外 的 一 切 帮 助 。||随 后 ， 博 瓦 尼 被 宣 判 有 战 争 罪 ， 蓄 意 谋 杀 罪 ， 种 族 灭 绝 罪 而 被 判 处 死 刑 。 象 牙 海 岸 革 命 共 产 党 正 式 成 为 了 该 国 的 领 导 力 量 。 不 久 以 后 该 党 便 出 台 了 执 政 纲 领 “ 社 会 主 义 与 科 特 迪 瓦 ” 。 宣 布 要 以 马 克 思 列 宁 主 义 的 为 指 导 ， 毛 泽 东 思 想 为 武 器 ， 建 立 巩 固 和 保 卫 社 会 主 义 科 特 迪 瓦 。 大 量 的 种 植 园 从 私 人 名 义 被 转 为 公 有 ， 而 一 直 被 打 压 的 工 会 也 得 到 了 一 定 的 自 主 权 。 同 时 大 量 的 法 国 和 美 国 矿 冶 企 业 也 被 查 收 。 在 偏 远 的 地 区 ， 建 立 新 首 都 的 工 程 也 被 暂 时 叫 停 ， 和 平 圣 母 大 教 堂 中 的 宗 教 元 素 则 被 摘 除 。 该 建 筑 则 被 用 于 作 为 集 会 和 纪 念 馆 。");
			a.data[8] -= 80;
			a.data[9] -= 80;
			a.allcountries[64].Gosstroy = 1;
			a.allcountries[64].SubGosstroy = 17;
			a.allcountries[64].LeaveAlliances();
			a.allcountries[64].EstablishGovernment(Government.ProChina);
			a.allcountries[64].Torg = true;
			a.allcountries[64].JoinAllOurAlliances(yes: true);
		}
	}
}
