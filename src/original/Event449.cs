using EventsForDLC;
using UnityEngine;

public class Event449 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 你 可 听 见 人 民 的 怒 吼 ？";
		text = " 由 于 伊 朗 第 一 任 总 统 阿 博 尔 哈 桑 · 巴 尼 萨 德 尔 认 为 神 职 人 员 不 应 该 直 接 统 治 伊 朗 ， 霍 梅 尼 煽 动 了 对 他 的 弹 劾 。 议 会 在 巴 尼 萨 德 尔 缺 席 的 情 况 下 弹 劾 了 他 ， 只 有 一 名 副 手 萨 拉 赫 丁 · 巴 亚 尼 在 议 会 弹 劾 巴 尼 萨 德 尔 期 间 发 言 支 持 总 统 。 霍 梅 尼 甚 至 在 签 署 弹 劾 文 件 之 前 ， 就 开 始 对 总 统 和 他 的 支 持 者 展 开 了 清 洗 。 革 命 卫 队 占 领 了 总 统 府 和 花 园 ， 并 监 禁 了 一 家 与 巴 尼 萨 德 尔 关 系 密 切 的 报 社 。 在 接 下 来 的 几 天 里 ， 他 们 处 决 了 他 几 个 最 亲 密 的 朋 友 ， 包 括 侯 赛 因 · 纳 瓦 布 、 拉 希 德 · 萨 德 罗 赫 法 齐 和 马 努 切 赫 尔 · 马 苏 迪 。 阿 亚 图 拉 · 侯 赛 因 · 阿 里 · 蒙 塔 泽 里 是 政 府 中 为 数 不 多 的 仍 然 支 持 巴 尼 萨 德 尔 的 人 之 一 ， 但 他 很 快 就 被 剥 夺 了 权 力 。 与 此 同 时 ， 伊 朗 政 府 取 缔 了 除 伊 斯 兰 共 和 党 以 外 的 所 有 政 党 。 政 府 军 逮 捕 并 监 禁 了 其 他 政 党 的 成 员 ， 如 人 民 圣 战 者 组 织 ， 伊 朗 人 民 党 等 。 作 为 对 上 述 政 策 的 抗 议 ， 人 民 圣 战 者 组 织 在 德 黑 兰 、 伊 斯 法 罕 、 乌 尔 米 亚 、 设 拉 子 、 阿 拉 克 、 阿 瓦 士 和 阿 巴 斯 港 等 地 组 织 了 一 场 反 伊 斯 兰 共 和 国 抗 议 活 动 ， 学 生 、 市 民 和 工 人 已 经 大 量 参 与 ， 霍 梅 尼 政 权 仍 在 国 内 各 个 反 对 派 也 在 其 中 。 据 了 解 ， 人 民 圣 战 者 组 织 以 及 各 个 共 产 主 义 武 装 团 体 正 在 准 备 发 动 武 装 起 义 … … 反 对 派 的 活 动 规 模 虽 庞 大 ， 但 仍 缺 乏 统 一 领 导 。 根 据 我 们 的 信 息 ， 政 府 正 准 备 严 厉 镇 压 反 对 派 的 活 动 。 我 们 该 怎 么 办 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.data[56] <= 1)
		{
			button_text[0] = " 为 我 们 的 同 志 送 去 支 持 ， 发 起 一 场 真 正 的 革 命 ， 神 权 政 治 应 该 被 送 到 历 史 的 垃 圾 堆 里 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 有 义 务 帮 他 们 ！";
		}
		button_text[1] = " 这 是 伊 朗 人 自 己 的 事 情 ！ 我 们 不 得 干 涉 他 国 内 政 ， 和 平 与 发 展 才 是 当 今 时 代 的 主 题 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 你 可 听 见 人 民 的 怒 吼 ？";
		switch (result_num)
		{
		case 0:
			text = " 我 们 的 特 工 联 系 到 人 民 圣 战 者 、 伊 朗 共 产 主 义 者 联 盟 、 伊 朗 人 民 游 击 队 和 各 个 小 型 的 共 产 主 义 武 装 团 体 以 及 库 尔 德 民 主 党 和 俾 路 支 解 放 阵 线 等 正 在 武 装 反 抗 伊 斯 兰 共 和 国 的 少 数 民 族 左 翼 团 体 ， 共 同 组 建 了 伊 朗 人 民 革 命 联 盟 作 为 各 个 武 装 团 体 的 统 一 指 挥 和 联 络 机 构 。 很 快 ， 阿 莫 勒 市 爆 发 了 一 场 大 起 义 ， 同 时 ， 在 其 他 抗 议 城 市 中 ， 一 些 中 国 制 式 武 器 不 知 从 什 么 渠 道 流 通 到 了 抗 议 民 众 和 罢 工 工 人 那 里 ， 伊 朗 全 国 各 地 的 人 民 革 命 联 盟 成 员 和 抗 议 民 众 联 合 起 来 ， 击 退 了 政 府 的 镇 压 队 伍 。 全 国 各 个 城 市 都 爆 发 了 火 并 。 人 民 圣 战 者 制 造 了 多 次 暗 杀 — — 先 是 一 枚 炸 弹 在 德 黑 兰 的 伊 斯 兰 共 和 党 总 部 爆 炸 ， 当 时 该 党 领 导 人 会 议 正 在 进 行 中 ， 伊 朗 伊 斯 兰 共 和 国 的 七 十 四 名 主 要 官 员 被 送 去 见 了 真 主 ， 其 中 包 括 首 席 大 法 官 阿 亚 图 拉 · 穆 罕 默 德 · 贝 赫 什 蒂 ， 他 是 伊 朗 革 命 中 第 二 有 权 势 的 人 物 （ 仅 次 于 阿 亚 图 拉 · 鲁 霍 拉 · 霍 梅 尼 ） ； 随 后 ， 总 理 办 公 室 也 发 生 了 一 场 爆 炸 ， 时 任 总 统 拉 贾 伊 和 总 理 巴 霍 纳 尔 被 炸 死 。 霍 梅 尼 十 分 愤 怒 ， 他 宣 布 全 国 进 入 “ 紧 急 状 态 ” 并 解 散 议 会 ， 开 始 全 面 动 员 国 家 机 器 以 镇 压 “ 反 （ 伊 斯 兰 ） 革 命 分 子 ” 。 在 这 种 情 况 下 ， 巴 尼 萨 德 尔 和 他 的 支 持 者 也 决 定 同 人 民 站 在 一 起 。 大 量 学 生 ， 工 运 人 士 和 民 众 开 始 向 伊 朗 人 民 革 命 联 盟 靠 拢 ， 一 场 真 正 的 革 命 开 始 了 !";
			a.data[9] -= 100;
			a.data[8] -= 100;
			a.data[6] += 100;
			GlobalScript.inst.gameState.ingamewars[33].name_war = " 伊 朗 革 命 战 争";
			GlobalScript.inst.gameState.ingamewars[33].is_going = true;
			GlobalScript.inst.gameState.ingamewars[33].side1 = " 伊 革 阵";
			GlobalScript.inst.gameState.ingamewars[33].side2 = " 神 权 政 府";
			GlobalScript.inst.gameState.ingamewars[33].ussr_place = -1;
			GlobalScript.inst.gameState.ingamewars[33].usa_place = 1;
			GlobalScript.inst.gameState.ingamewars[33].infl1 = 300;
			GlobalScript.inst.gameState.ingamewars[33].infl2 = 700;
			GlobalScript.inst.gameState.ingamewars[33].fortnight_max = 20;
			GlobalScript.inst.gameState.iranrev = true;
			a.allcountries[8].Torg = false;
			break;
		case 1:
			text = " 伊 朗 各 地 都 爆 发 了 各 种 反 抗 活 动 。 阿 博 尔 哈 桑 · 巴 尼 萨 德 尔 在 人 民 圣 战 者 的 掩 护 下 逃 到 了 法 国 。 政 府 迅 速 对 抗 议 做 出 了 反 应 ， 大 量 抗 议 者 被 逮 捕 。 几 天 后 ， 一 枚 炸 弹 在 德 黑 兰 的 伊 斯 兰 共 和 党 总 部 爆 炸 ， 当 时 该 党 领 导 人 会 议 正 在 进 行 中 ， 伊 朗 伊 斯 兰 共 和 国 的 七 十 四 名 主 要 官 员 被 送 去 见 了 真 主 ， 包 括 首 席 大 法 官 阿 亚 图 拉 · 穆 罕 默 德 · 贝 赫 什 蒂 ， 他 是 伊 朗 革 命 中 第 二 有 权 势 的 人 物 （ 仅 次 于 阿 亚 图 拉 · 鲁 霍 拉 · 霍 梅 尼 ） ， 伊 朗 人 民 圣 战 者 组 织 被 霍 梅 尼 指 控 为 袭 击 的 幕 后 黑 手 ； 一 个 月 后 ， 总 理 办 公 室 也 发 生 了 一 场 爆 炸 ， 时 任 总 统 拉 贾 伊 和 总 理 巴 霍 纳 尔 被 炸 死 。 伊 朗 共 产 主 义 者 联 盟 在 阿 莫 勒 附 近 的 森 林 中 动 员 力 量 ， 发 动 了 反 对 伊 朗 伊 斯 兰 政 权 的 武 装 运 动 。 该 起 义 由 赛 厄 马 克 · 扎 伊 姆 领 导 ， 但 最 终 失 败 ， 许 多 伊 共 盟 成 员 和 毛 派 领 导 人 被 枪 杀 。 革 命 卫 队 强 行 夺 回 阿 莫 勒 市 后 ， 扎 伊 姆 被 他 们 逮 捕 。 其 他 的 共 产 主 义 团 体 在 各 地 也 开 展 了 一 些 武 装 运 动 ， 但 是 由 于 彼 此 孤 立 ， 互 相 缺 乏 联 系 而 被 各 个 击 破 。 少 数 民 族 的 反 抗 运 动 最 后 也 被 镇 压 。 伊 朗 伊 斯 兰 共 和 国 虽 然 经 历 了 一 个 动 荡 的 时 期 ， 但 仍 旧 稳 固 。 人 民 圣 战 者 不 会 放 弃 斗 争 ， 他 们 正 在 准 备 下 一 次 行 动 … …";
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			a.allcountries[8].proprc = false;
			a.allcountries[8].Torg = false;
			break;
		}
	}
}
