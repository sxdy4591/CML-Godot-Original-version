using EventsForDLC;
using UnityEngine;

public class Event549 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 铲 除 杂 草";
		text = " 长 期 以 来 ， 亲 苏 的 尤 睦 佳 · 泽 登 巴 尔 统 治 着 蒙 古 人 民 共 和 国 。 泽 登 巴 尔 在 党 内 无 法 容 忍 同 僚 的 批 评 甚 至 是 建 设 性 意 见 ， 并 在 政 策 上 紧 跟 苏 联 的 脚 步 。 他 先 后 于 1 9 5 9 年 （ 达 希 · 丹 巴 ） 、 1 9 6 2 年 （ 达 拉 姆 · 图 木 尔 奥 其 尔 ） 、 1 9 6 3 年 （ 鲁 布 桑 策 伦 · 曾 德 ） 1 9 6 4 年 （ 所 谓 的 “ 洛 呼 兹 、 宁 布 、 苏 尔 玛 扎 布 反 党 集 团 ” ） 打 倒 了 希 望 让 蒙 古 走 自 力 更 生 、 独 立 自 主 道 路 并 结 束 极 端 亲 苏 的 一 批 竞 争 对 手 ， 而 苏 联 在 稳 固 他 的 地 位 上 也 起 了 很 大 的 作 用 。||1 9 8 1 年 蒙 古 人 民 革 命 党 十 八 大 后 ， 泽 登 巴 尔 发 起 了 “ 铲 除 杂 草 ” 运 动 ， 开 始 对 领 导 层 进 行 新 一 轮 清 洗 。 1 9 8 2 年 ， 他 清 洗 了 时 任 科 学 院 院 长 巴 扎 尔 · 锡 林 迪 布 ， 而 如 今 他 希 望 对 国 家 的 二 号 人 物 桑 丕 勒 · 扎 兰 阿 扎 布 动 手 了 。||值 得 注 意 的 是 ， 1 9 8 2 年 勃 列 日 涅 夫 的 塔 什 干 讲 话 后 ， 苏 联 便 谋 求 与 我 们 改 善 关 系 ， 而 泽 登 巴 尔 并 未 领 会 （ 或 不 愿 领 会 ） 这 一 新 政 策 ， 并 在 国 内 继 续 维 持 着 旧 的 对 华 政 策 ， 苏 联 对 他 并 不 满 意 。||显 然 ， 现 在 是 我 们 插 手 蒙 古 的 一 个 重 要 机 会 ， 如 果 我 们 此 前 进 行 过 一 些 布 局 ， 我 们 可 以 尝 试 帮 助 扎 兰 阿 扎 布 ， 也 许 这 将 来 会 有 用 呢 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.allcountries[9].cw && a.influencePRC >= 300)
		{
			button_text[0] = " 向 泽 登 巴 尔 施 压";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 人 会 听 我 们 的";
		}
		button_text[1] = " 我 们 无 需 管 他";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 铲 除 杂 草";
		if (result_num == 0)
		{
			text = " 在 我 们 的 特 工 资 助 了 蒙 古 人 民 革 命 党 内 部 的 反 对 派 的 情 况 下 ， 扎 兰 阿 扎 布 获 得 了 相 当 一 部 分 的 支 持 者 ， 而 苏 联 在 此 时 也 对 他 的 政 策 不 满 ， 对 其 进 行 施 压 。 在 来 自 党 内 和 来 自 苏 联 的 双 重 压 力 下 ， 泽 登 巴 尔 放 弃 了 “ 铲 除 杂 草 ” 运 动 ， 甚 至 平 反 了 此 前 被 打 倒 的 干 部 （ 包 括 丹 巴 等 前 竞 争 对 手 ） ， 他 们 得 以 重 返 中 央 委 员 会 。 如 今 ， 泽 登 巴 尔 的 地 位 已 经 大 大 动 摇 ， 他 的 倒 台 似 乎 也 已 经 出 现 在 地 平 线 上 。";
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.empires[1].relations -= 50;
		}
		if (result_num == 1)
		{
			text = " 1 9 8 3 年 7 月 ， 扎 兰 阿 扎 布 被 突 然 解 除 全 部 职 务 。 但 直 到 1 9 8 4 年 2 月 ， 蒙 古 人 民 革 命 党 机 关 刊 物 《 党 的 生 活 》 才 刊 登 了 相 关 通 告 ， 通 告 内 称 扎 兰 阿 扎 布 为 “ 反 党 分 子 ” ， 据 称 已 经 酝 酿 了 2 0 年 “ 邪 恶 的 阴 谋 ” ， 准 备 在 朝 克 特 奥 其 尔 · 洛 呼 兹 、 巴 勒 丹 道 尔 吉 · 宁 布 、 班 地 · 苏 尔 玛 扎 布 以 及 达 拉 姆 · 图 木 尔 奥 其 尔 的 支 持 下 推 翻 泽 登 巴 尔 。 扎 兰 阿 扎 布 被 开 除 出 党 并 被 流 放 ， 罪 名 是 “ 破 坏 党 的 团 结 ” 。 “ 铲 除 杂 草 ” 运 动 仍 在 继 续 ， 到 1 9 8 4 年 ， 三 分 之 一 的 中 央 委 员 会 成 员 和 1 9 8 1 年 任 命 的 近 一 半 的 部 委 首 脑 都 被 泽 登 巴 尔 解 职 。";
		}
	}
}
