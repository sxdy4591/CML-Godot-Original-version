using EventsForDLC;
using UnityEngine;

public class Event540 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 达 芬 奇 的 遗 产";
		text = " 随 着 我 国 航 空 器 技 术 的 进 步 ， 过 去 的 直 - 5 ， 直 - 6 等 装 备 实 在 过 于 老 旧 ， 难 以 执 行 预 定 的 战 略 目 标 。 研 发 新 型 直 升 机 的 计 划 迫 在 眉 睫 ， 但 也 有 一 个 好 消 息 ， 法 国 人 愿 意 为 我 们 提 供 S A 3 6 5 - N 1 型 直 升 机 。 这 是 一 个 相 当 不 错 的 机 会 ， 法 国 的 直 升 机 相 当 耐 用 ， 且 能 为 未 来 的 改 装 做 更 多 准 备 。 当 然 ， 更 多 的 委 员 希 望 能 建 造 自 己 的 直 升 机 ， 哪 怕 失 败 了 也 可 以 当 成 是 为 未 来 最 准 备 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[8] + a.data[36] >= 80)
		{
			button_text[0] = " 研 发 自 主 研 发 直 升 机";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 钱 不 够 啊";
		}
		if (a.allcountries[21].Torg && a.data[8] + a.data[36] >= 30)
		{
			button_text[1] = " 购 买 法 国 的 产 品";
		}
		else if (!a.allcountries[21].Torg)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 法 国 人 不 会 卖 给 我 们 东 西";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 有 闲 钱 ！";
		}
		button_text[2] = " 无 动 于 衷";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 达 芬 奇 的 遗 产";
		if (result_num == 0)
		{
			text = " 随 着 一 纸 号 令 的 下 达 ， 我 们 决 定 研 发 更 好 的 直 升 机 。 在 原 有 型 号 和 观 察 员 的 研 究 下 ， 我 们 借 鉴 了 美 国 “ 黑 鹰 ” 直 升 机 和 苏 联mi -17 的 经 验 ， 得 以 设 计 出 一 款 功 能 和 技 术 都 接 近 的 通 用 直 升 机 ， 直 -12 。 这 是 一 个 大 胆 的 决 定 ， 因 为 我 们 采 用 了 大 量 新 型 技 术 ： 例 如 十 一 叶 片 的 螺 旋 桨 ， 内 置 在 尾 翼 中 的 螺 旋 桨 等 。 这 将 同 时 作 为 军 队 和 民 用 设 计 。 预 计 可 以 运 载 十 人 左 右 ， 尽 管 运 量 不 高 ， 但 这 款 直 升 机 将 大 量 列 装 ， 旨 在 完 全 取 代 旧 设 计 。 同 时 ， 直12 - w 也 在 设 计 中 ， 这 是 直12 的 双 座 升 级 版 本 ， 具 有 尾 旋 翼 ， 从 而 降 低 了 噪 音 水 平 ， 从 而 使 其 能 够 实 现 一 定 程 度 的 声 学 隐 身 。 排 气 装 置 的 设 计 减 少 了 红 外 线 特 征 。 该 直 升 机 配 备 了 毫 米 波 火 控 雷 达 。 与 大 多 数 攻 击 直 升 机 不 同 的 是 ， 它 没 有 机 头 机 枪 或 机 炮 。 直 -12 还 具 有 装 甲 板 、 弹 射 座 椅 和 装 有 前 视 红 外 系 统 及 激 光 测 距 仪 的 炮 塔 。 特 别 设 计 的 头 盔 型 瞄 具 也 在 计 划 中 。";
			a.data[8] -= 80;
			a.data[22] += 80;
			a.data[1] += 100;
			a.data[3] += 100;
			a.influencePRC += 20;
			string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
			int num = 50;
			old_modify_desc[num] += "<color=red>| 自 研 直 升 机 ：</color>| 军 力+0.4 ， 干 涉 点 数+0.2";
		}
		if (result_num == 1)
		{
			text = " 我 们 和 法 国 签 署 了 一 项 协 议 ， 我 们 将 在 未 来 采 购 法 国 的 农 产 品 ， 而 法 国 将 会 转 让 给 我 们 S A 3 6 5 - N 1 的 生 产 线 。 很 快 ， 哈 尔 滨 飞 机 制 造 厂 便 试 飞 了 第 一 架 直 - 9 ， 这 至 少 能 填 补 我 们 在 军 用 和 民 用 的 空 缺 。 这 款 直 升 机 将 被 大 量 列 装 部 队 ， 军 用 的 武 装 款 也 在 设 计 中 。";
			a.data[8] -= 30;
			a.data[22] += 50;
			a.data[1] += 50;
			a.data[3] += 50;
			a.data[6] -= 20;
			a.influencePRC += 20;
			string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
			int num2 = 50;
			old_modify_desc2[num2] += "<color=red>| 法 式 直 升 机 ：</color>| 军 力+0.2 ，干 涉 点 数+0.1";
		}
		if (result_num == 2)
		{
			text = " 仔 细 想 想 ， 我 们 的 直 升 机 还 挺 先 进 的 ？ 总 比 那 几 个 天 天 摔 地 上 的 好 ， 对 吧 ？";
		}
	}
}
