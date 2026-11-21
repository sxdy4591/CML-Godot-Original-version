using EventsForDLC;
using UnityEngine;

public class Event450 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 永 恒 之 光";
		text = " 自 伊 朗 — — 伊 拉 克 爆 发 大 规 模 冲 突 以 来 ， 拉 贾 维 和 前 总 统 巴 尼 萨 德 的 伊 朗 国 家 抵 抗 委 员 会 N C R I ， 已 融 入 了 包 括 人 民 圣 战 者 ， 库 尔 德 斯 坦 民 主 党 ， 民 族 阵 线 、 共 产 主 义 者 联 盟 等 倒 霍 力 量 加 入 。 虽 然 其 人 数 众 多 ， 但 缺 少 强 有 力 的 支 持 。 而 伊 拉 克 同 时 也 陷 入 了 和 伊 朗 的 堑 壕 战 中 ， 如 果 能 得 到 N C R I ， 那 么 对 于 快 速 结 束 两 伊 战 争 也 会 有 很 大 帮 助 。 而 随 着 伊 拉 克 倒 向 我 们 ， 也 许 组 建 一 支 伊 朗 人 自 己 的 反 神 权 武 装 力 量 或 许 也 是 可 行 的 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[56] <= 1 && a.allcountries[14].proprc)
		{
			button_text[0] = " 在 我 们 的 帮 助 下 ， 组 建 伊 朗 民 族 解 放 军";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 这 是 否 太 激 进 了 ？";
		}
		if (GlobalScript.inst.gameState.data[56] < 1 && a.allcountries[31].proprc && a.allcountries[14].proprc && a.allcountries[1].okb)
		{
			button_text[1] = " 是 时 候 执 行 计 划 了 ， 执 行 “ 烈 日 行 动 ” ！";
		}
		else if (GlobalScript.inst.gameState.data[56] > 1)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 我 们 要 把 自 己 变 得 像 帝 国 主 义 者 一 样 ？";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 没 有 人 会 支 持 我 们 把 轰 炸 机 开 到 伊 朗 上 空 去 ！";
		}
		button_text[2] = " 我 们 暂 时 没 有 这 个 意 向";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 永 恒 之 光";
		switch (result_num)
		{
		case 0:
			text = " 在 我 国 驻 巴 格 达 领 事 的 安 排 下 ， 拉 贾 维 和 萨 达 姆 就 展 开 合 作 达 成 了 协 定 。 中 国 将 通 过 伊 拉 克 为 伊 朗 民 族 解 放 军 提 供 武 器 ， 而 萨 达 姆 则 负 责 提 供 营 地 。 很 快 ， 在 建 筑 工 人 和 中 国 教 官 的 帮 助 下 ， 阿 什 拉 夫 营 地 — — 一 个 有 上 万 人 的 大 型 社 区 兼 军 事 基 地 拔 地 而 起 。 伊 朗 民 族 解 放 军 宣 布 不 再 躲 藏 ， 是 时 候 夺 回 属 于 人 民 的 伊 朗 了 ！";
			a.data[9] -= 100;
			a.data[8] -= 50;
			a.data[22] -= 100;
			a.data[6] += 50;
			a.empires[0].relations -= 150;
			GlobalScript.inst.gameState.iranrev = true;
			break;
		case 1:
			text = " 在 巴 基 斯 坦 和 伊 拉 克 方 面 的 支 持 下 ， 中 国 人 民 解 放 军 的 轰 -6 和 强 -5 型 攻 击 机 对 伊 朗 的 数 个 战 略 目 标 展 开 了 战 略 轰 炸 。 德 黑 兰 ， 设 拉 子 ， 大 不 里 士 等 城 市 受 损 的 尤 为 严 重 。NCRI 的 战 士 们 从 四 面 八 方 攻 入 伊 朗 国 内 。 尤 其 是 在 胡 齐 斯 坦 省 ， 驻 扎 于 此 的 伊 朗 第77 师 几 乎 被 全 歼 ，11000名 伊 朗 陆 军 和 革 命 卫 队 成 员 被 杀 ，2000 名 被 俘 虏 ， 而NCRI 方 面 受 损 不 超 过300 人 。 取 得 了 超 越 伊 拉 克 军 队 的 战 绩 ， 伊 朗 也 因 此 元 气 大 伤 ， 看 起 来 战 争 马 上 就 要 结 束 了 。 但 与 此 同 时 ， 美 国 方 面 对 我 们 的 “ 暴 行 ” 表 示 了 强 烈 不 满 ， 可 他 们 在 轰 炸 越 南 的 时 候 为 什 么 不 多 些 怜 悯 ？ 帝 国 主 义 者 的 双 重 标 准 真 是 令 人 作 呕 ！ ";
			a.data[22] -= 200;
			a.data[8] -= 100;
			a.data[9] -= 200;
			a.data[6] += 80;
			a.influencePRC += 80;
			a.empires[0].relations -= 300;
			GlobalScript.inst.gameState.ingamewars[3].infl1 += 300;
			GlobalScript.inst.gameState.ingamewars[3].infl2 -= 300;
			break;
		case 2:
			text = " 直 接 和 伊 朗 人 闹 翻 实 在 是 太 不 必 要 了 ， 让 别 人 头 痛 去 吧 ， 别 烦 我 ！ ";
			break;
		}
	}
}
