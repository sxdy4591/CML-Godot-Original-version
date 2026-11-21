using EventsForDLC;
using UnityEngine;

public class Event437 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 南 也 门 事 变 ?";
		text = " 在 1966 年 的 “ 六 · 二 二 ” 纠 正 运 动 后 ， 南 也 门 确 定 了 走 科 学 社 会 主 义 的 道 路 ， 社 会 主 义 制 度 逐 渐 被 建 立 起 来 。 但 是 在 实 践 中 ， 南 也 门 领 导 层 的 三 巨 头 之 间 的 分 歧 和 矛 盾 逐 渐 显 露 。 亲 近 苏 联 的 阿 里 · 纳 赛 尔 · 穆 罕 默 德 和 阿 普 杜 勒 · 法 塔 赫 · 伊 斯 梅 尔 同 更 支 持 毛 主 义 观 点 的 萨 利 姆 · 鲁 巴 伊 · 阿 里 总 统 之 间 的 矛 盾 渐 渐 严 重 。 有 情 报 表 明 ， 阿 里 · 纳 赛 尔 和 伊 斯 梅 尔 的 亲 苏 派 计 划 发 动 武 装 政 变 。 同 时 ， 苏 联 在 南 也 门 的 军 事 基 地 的 军 事 调 动 也 变 得 更 加 频 繁 ， 他 们 可 能 会 介 入 并 支 持 政 变 。 或 许 我 们 可 以 尝 试 支 持 鲁 巴 伊 ， 粉 碎 政 变 ， 让 南 也 门 彻 底 倒 向 我 们 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if ((GlobalScript.inst.gameState.allcountries[42].proprc || ((GlobalScript.inst.gameState.allcountries[41].parts[1] || GlobalScript.inst.gameState.allcountries[41].parts[0]) && a.allcountries[41].proprc && a.allcountries[41].Gosstroy == 1)) && a.data[8] + a.data[36] >= 50 && a.data[9] >= 50 && a.data[7] >= 100)
		{
			button_text[0] = " 让 我 们 尽 全 力 支 持 鲁 巴 伊 同 志 打 倒 修 正 主 义 分 子 ！（需 要5 百 万 元 预 算 ，5 特 工 网 络）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 无 从 下 手 ......";
		}
		button_text[1] = " 我 们 不 能 得 罪 苏 联 ......";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 南 也 门 事 变 ？";
		switch (result_num)
		{
		case 0:
			text = " 多 亏 了 我 们 在 索 马 里 的 部 署 ， 让 我 们 有 了 力 量 支 持 鲁 巴 伊 。 在 我 们 的 警 告 以 及 特 工 小 组 的 协 助 下 ， 鲁 巴 伊 得 以 逮 捕 部 分 亲 苏 的 修 正 主 义 分 子 。 残 余 的 亲 苏 分 子 发 觉 了 鲁 巴 伊 的 行 动 ， 匆 匆 拉 起 一 支 叛 军 ， 但 很 快 被 政 府 军 和 民 兵 粉 碎 。 苏 联 军 事 基 地 内 的 驻 军 在 我 们 和 索 马 里 的 军 事 力 量 的 联 合 封 锁 下 ， 无 法 介 入 政 变 ， 最 后 整 个 军 事 基 地 都 被 南 也 门 扣 押 。  阿 里 · 纳 赛 尔 和 伊 斯 梅 尔 最 终 被 俘 ， 他 们 被 中 央 委 员 会 设 立 的 特 别 法 庭 判 处 叛 国 罪 和 反 革 命 罪 ， 死 刑 立 即 执 行 。 亲 苏 分 子 完 全 被 清 洗 ， 鲁 巴 伊 稳 固 了 他 的 领 导 地 位 。  在 “ 统 一 政 治 组 织 — — 民 族 阵 线 ” 的 特 别 全 国 代 表 大 会 上 ， 该 组 织 被 改 组 为 也 门 共 产 党 ， 党 章 加 入 了 毛 主 义 和 反 对 修 正 主 义 的 词 条 。 会 上 ， 总 书 记 萨 利 姆 · 鲁 巴 伊 · 阿 里 宣 布 将 加 强 与 中 国 的 合 作 ， 这 引 起 了 苏 联 的 不 满 。 但 鲁 巴 伊 并 未 提 出 要 驱 逐 苏 联 军 事 基 地 ， 因 此 苏 联 的 不 满 也 仅 仅 停 留 在 牢 骚 层 面 。";
			a.data[7] += 50;
			a.empires[1].relations -= 150;
			GlobalScript.inst.gameState.allcountries[24].SubGosstroy = 17;
			GlobalScript.inst.gameState.allcountries[24].proprc = true;
			a.data[8] -= 50;
			a.data[9] -= 50;
			break;
		case 1:
			text = " 1978 年6 月24 日 ， 伊 斯 梅 尔 一 派 策 划 了 加 什 米 遇 刺 案 ， 企 图 嫁 祸 于 鲁 巴 伊 。 这 一 事 件 加 速 了 双 方 的 武 力 摊 牌 。  1978 年6 月26 日 召 开 的 “ 统 一 政 治 组 织 — — 民 族 阵 线 ” 中 央 委 员 会 非 常 会 议 上 ， 两 派 因 政 见 分 歧 而 发 生 了 流 血 冲 突 ， 伊 斯 梅 尔 和 总 理 阿 里 · 纳 赛 尔 · 穆 罕 默 德 在 苏 联 、 德 意 志 民 主 共 和 国 和 古 巴 的 支 持 下 发 动 推 翻 鲁 巴 伊 的 武 装 政 变 ， 动 用 飞 机 轰 炸 鲁 巴 伊 所 在 的 总 统 府 ， 派 军 舰 封 锁 了 海 面 ， 苏 联 和 古 巴 的 军 事 力 量 直 接 介 入 了 冲 突 。 鲁 巴 伊 指 挥 警 卫 营 进 行 抵 抗 ， 激 战16 小 时 。 总 统 府 被 攻 陷 后 ， 鲁 巴 伊 失 败 被 俘 ， 被 中 央 委 员 会 设 立 的 “ 特 别 法 庭 ” 判 处 死 刑 ， 并 立 即 执 行 。 政 变 后 ， 伊 斯 梅 尔 又 清 洗 了 残 余 的 鲁 巴 伊 派 。  在 的 “ 统 一 政 治 组 织 — — 民 族 阵 线 ” 的 特 别 全 国 代 表 大 会 上 ， 该 组 织 被 改 组 为 也 门 社 会 党 ， 伊 斯 梅 尔 当 选 为 该 党 总 书 记 。 会 上 ， 伊 斯 梅 尔 强 调 今 后 将 努 力 “ 扩 大 和 加 强 与 以 苏 联 为 首 的 社 会 主 义 阵 营 的 友 好 合 作 关 系 ” 。";
			a.data[7] -= 10;
			GlobalScript.inst.gameState.allcountries[24].prosov = true;
			GlobalScript.inst.gameState.allcountries[24].Torg = false;
			break;
		}
	}
}
