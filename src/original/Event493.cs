using EventsForDLC;
using UnityEngine;

public class Event493 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 我 们 需 要 石 油 ？";
		text = " 随 着 我 国 工 业 的 飞 速 发 展 ， 另 一 项 问 题 开 始 浮 出 水 面 ： 我 国 的 石 油 储 量 越 显 尴 尬 。 工 业 的 运 转 需 要 石 油 的 润 滑 ， 一 旦 石 油 储 备 见 底 ， 我 们 所 遇 到 的 危 机 可 能 就 不 只 是 工 厂 停 工 了 。 为 此 ， 我 们 的 委 员 会 出 台 了 一 些 方 案 。 我 们 可 以 采 购 更 新 更 好 的 开 采 工 具 ， 也 可 以 发 动 “ 石 油 会 战 ” 来 鼓 舞 我 们 的 石 油 工 人 。 或 者 直 接 买 外 国 人 的 会 更 好 ？ 无 论 如 何 ， 决 定 权 在 您 的 手 上 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (a.data[8] + a.data[36] >= 80)
		{
			button_text[0] = " 采 购 最 新 的 开 采 设 备";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 可 惜 我 们 没 有 这 么 多 钱";
		}
		button_text[1] = " 在 中 宣 部 和 各 级 党 委 的 鼓 动 下 ， 号 召 工 人";
		if (a.data[8] + a.data[36] >= 50 && a.modifies[3].active)
		{
			button_text[2] = " 设 备 号 召 两 手 抓 ， 这 是 社 会 主 义 建 设 所 必 要 的 ！";
		}
		else if (a.data[8] + a.data[36] < 50)
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 没 有 钱";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 越 奉 献 越 成 功 … … 道 理 很 好 听 ， 可 惜 没 人 信 了";
		}
		if (a.empires[1].relations >= 500 || a.empires[0].relations >= 500)
		{
			button_text[3] = " 呼 吁 外 国 的 帮 助";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 想 法 很 好 ， 但 没 人 愿 意 帮 一 个 恶 霸";
		}
		button_text[4] = " 没 有 这 个 必 要";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		if (result_num != 2)
		{
			name = " 我 们 需 要 石 油 ？";
		}
		else
		{
			name = " 大 庆 ： 王 进 喜 的 遗 产";
		}
		if (result_num == 0)
		{
			a.data[8] -= 100;
			a.data[9] -= 50;
			text = " 我 们 和 美 国 以 及 苏 联 的 石 油 开 采 公 司 达 成 了 协 议 。 最 终 ， 我 们 得 以 凭 借 一 笔 优 惠 的 价 格 的 到 了 一 批 优 质 的 钻 头 和 钻 井 平 台 。 凭 借 他 们 ， 我 们 一 定 能 克 服 石 油 短 缺 的 问 题 。";
			a.data[8] -= 80;
			GlobalScript.inst.gameState.OilProd += 500f;
		}
		if (result_num == 1)
		{
			if ((a.data[3] >= 700 && a.data[5] >= 600) || (a.data[3] >= 500 && a.data[5] >= 400 && a.modifies[3].active))
			{
				text = " 大 庆 精 神 是 我 国 石 油 职 工 学 习 和 运 用 毛 泽 东 思 想 ， 继 承 和 发 扬 中 国 共 产 党 、 中 国 工 人 阶 级 、 中 国 人 民 解 放 军 的 优 良 传 统 ， 在 6 0 年 代 波 澜 壮 阔 的 石 油 大 会 战 中 ， 逐 步 培 育 和 形 成 的 ， 并 在 火 热 生 动 的 油 田 生 产 建 设 实 践 中 不 断 丰 富 、 创 新 和 发 展 。 而 今 天 ， 这 一 精 神 又 有 了 用 武 之 地 。 在 中 宣 部 的 鼓 舞 下 ， 一 笔 资 金 被 投 入 石 油 生 产 领 域 。 这 将 被 用 来 奖 励 超 额 完 成 目 标 的 石 油 工 人 。 最 终 ， 这 场 “ 新 石 油 会 战 ” 以 超 额 3 0 0 % 的 极 高 水 平 完 成 了 任 务 。 我 们 又 一 次 战 胜 了 自 己 的 记 录 ！";
				a.data[8] -= 5;
				a.data[5] -= 60;
				GlobalScript.inst.gameState.OilProd += 600f;
			}
			else
			{
				text = " 大 庆 精 神 是 我 国 石 油 职 工 学 习 和 运 用 毛 泽 东 思 想 ， 继 承 和 发 扬 中 国 共 产 党 、 中 国 工 人 阶 级 、 中 国 人 民 解 放 军 的 优 良 传 统 ， 在 6 0 年 代 波 澜 壮 阔 的 石 油 大 会 战 中 ， 逐 步 培 育 和 形 成 的 ， 并 在 火 热 生 动 的 油 田 生 产 建 设 实 践 中 不 断 丰 富 、 创 新 和 发 展 。 而 今 天 ， 这 一 精 神 … … 似 乎 还 能 算 有 点 “ 用 武 之 地 ” — — 即 使 有 中 宣 部 的 鼓 舞 ， 石 油 工 人 的 热 情 并 不 特 别 高 涨 … …  最 终 ， 这 场 “ 新 石 油 会 战 ” 以 超 额 1 4 3 % 的 水 平 完 成 了 任 务 ， 并 不 是 特 别 出 色 ， 但 也 够 解 决 当 前 工 业 的 燃 眉 之 急 。";
				a.data[8] -= 5;
				a.data[5] -= 50;
				GlobalScript.inst.gameState.OilProd += 400f;
			}
		}
		if (result_num == 2)
		{
			text = " 大 庆 精 神 是 我 国 石 油 职 工 学 习 和 运 用 毛 泽 东 思 想 ， 继 承 和 发 扬 中 国 共 产 党 、 中 国 工 人 阶 级 、 中 国 人 民 解 放 军 的 优 良 传 统 ， 在 6 0 年 代 波 澜 壮 阔 的 石 油 大 会 战 中 ， 逐 步 培 育 和 形 成 的 ， 并 在 火 热 生 动 的 油 田 生 产 建 设 实 践 中 不 断 丰 富 、 创 新 和 发 展 。 而 今 天 ， 这 一 精 神 又 有 了 用 武 之 地 。 在 我 们 的 鼓 舞 下 ， 一 笔 资 金 被 投 入 石 油 生 产 领 域 。 这 将 被 用 来 采 购 更 好 的 开 采 机 械 和 奖 励 超 额 完 成 目 标 的 石 油 工 人 。 最 终 ， 这 场 “ 新 石 油 会 战 ” 以 超 额 4 0 0 % 的 极 高 水 平 完 成 了 任 务 。 我 们 又 一 次 战 胜 了 自 己 的 记 录 ！ 这 是 无 产 阶 级 的 胜 利 ！";
			a.data[8] -= 50;
			a.data[5] -= 50;
			GlobalScript.inst.gameState.OilProd += 1000f;
		}
		if (result_num == 3)
		{
			text = " 我 们 的 呼 吁 的 到 了 外 国 友 人 的 帮 助 ， 很 快 ， 我 们 便 得 到 了 足 够 的 石 油 。 当 然 代 价 也 是 显 而 易 见 的 的 。 我 们 不 得 不 偿 还 一 笔 债 务 。";
			GlobalScript.inst.gameState.data[69] += 50;
			if (a.empires[0].relations >= 500)
			{
				a.empires[0].relations -= 50;
			}
			if (a.empires[1].relations >= 500)
			{
				a.empires[1].relations -= 50;
			}
			GlobalScript.inst.gameState.OilProd += 400f;
		}
		if (result_num == 4)
		{
			text = " 挖 不 如 买 ， 买 不 如 省 ， 大 不 了 就 苦 一 苦 工 业 ， 反 正 骂 名 也 不 是 我 背 ！";
		}
	}
}
