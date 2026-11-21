using EventsForDLC;
using UnityEngine;

public class Event508 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 树 枝 不 会 在 变 色 龙 手 里 折 断";
		text = " 随 着 克 雷 库 政 权 走 社 会 主 义 道 路 以 来 已 经 过 去 了 十 余 年 。 但 贝 宁 的 一 切 都 说 不 上 算 多 好 ， 过 于 急 切 的 追 求 工 业 化 导 致 了 经 济 发 展 的 失 衡 。";
		if (a.allcountries[21].Gosstroy != 2 && a.allcountries[21].Gosstroy != 3)
		{
			text += " 而 公 开 反 对 法 帝 国 主 义 则 成 为 了 压 垮 骆 驼 的 最 后 一 根 稻 草";
		}
		text += " 克 雷 库 多 次 表 示 希 望 西 方 国 家 能 帮 助 贝 宁 度 过 难 关 。 他 首 先 强 调 “ 贝 宁 革 命 的 最 终 目 的 是 社 会 主 义 ， 但 社 会 主 义 要 分 阶 段 实 现 。 ” 克 雷 库 政 权 对 小 资 产 阶 级 和 外 国 资 本 的 态 度 也 有 了 显 著 的 转 变 。 从 一 开 始 的 完 全 打 压 与 限 制 ， 再 到 仅 在 国 家 层 面 进 行 监 管 ， 最 后 则 是 开 始 准 备 扭 转 国 有 化 进 程 。 很 明 显 ， 贝 宁 革 命 正 在 危 机 边 缘 ， 领 导 人 同 志 ， 我 们 也 许 可 以 提 供 一 笔 无 息 贷 款 ？ 这 会 为 我 们 带 来 一 个 革 命 同 志 ， 同 时 狠 狠 的 打 苏 联 的 脸 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 2 && a.influencePRC >= 600)
		{
			button_text[0] = " 扭 转 贝 宁 右 转 的 方 向 ！（ 需 要 8 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 这 是 在 做 无 用 功";
		}
		if (a.allcountries[1].isSEV)
		{
			button_text[1] = " 将 贝 宁 纳 入 经 济 互 助 委 员 会 体 系";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 支 持 国 际 分 工 方 案 ！";
		}
		button_text[2] = " 我 们 无 能 为 力";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 树 枝 不 会 在 变 色 龙 手 里 折 断";
		if (result_num == 0)
		{
			text = " 我 们 宣 布 将 承 担 贝 宁 的 一 切 外 债 ， 克 雷 库 同 志 就 此 对 中 方 表 达 了 感 谢 。 在 群 众 大 会 上 ， 克 雷 库 表 示 “ 贝 宁 比 任 何 时 候 都 做 好 了 完 全 按 照 马 克 思 ， 列 宁 和 毛 泽 东 的 理 念 来 建 设 祖 国 ” ， 这 公 开 表 示 了 其 对 我 国 的 支 持 。 在 我 们 的 帮 助 下 ， 贝 宁 重 新 确 定 了 发 展 方 向 。 贝 宁 的 独 特 优 势 是 其 完 善 的 农 业 基 础 ， 我 们 愿 意 为 其 提 供 农 用 机 械 ， 化 肥 和 农 业 干 部 。 在 我 们 的 帮 助 下 ， 贝 宁 政 府 终 于 实 现 了 粮 食 自 给 ， 而 我 们 的 钻 机 也 让 贝 宁 过 了 把 “ 石 油 土 豪 ” 瘾 ， 他 们 将 会 用 石 油 赚 来 的 钱 来 购 买 我 们 的 工 业 设 备 。 政 治 改 革 也 在 有 条 不 紊 的 进 行 中 ， 贝 宁 人 民 革 命 党 再 次 确 定 了 自 己 的 地 位 ： 无 产 阶 级 的 先 锋 党 ， 并 开 始 建 设 完 整 的 党 校 等 机 构 。 部 分 “ 人 民 村 ” 也 开 始 搞 直 接 民 主 ， 选 举 自 己 的 村 庄 管 理 委 员 会 成 员 。 达 荷 美 共 产 党 也 被 合 法 化 了 ， 其 中 的 成 员 （ 尽 管 极 少 ） 也 被 吸 纳 入 贝 宁 社 会 主 义 革 命 党 作 为 党 内 的 左 翼 代 表 ， 党 内 的 亲 法 右 翼 也 被 清 洗 。||不 久 的 将 来 ， “ 红 旗 ” 卷 烟 火 柴 厂 ， “1026 革 命 ” 体 育 场 和 帕 拉 库 水 泥 厂 将 会 在 我 们 的 帮 助 下 落 成 ， 这 也 将 为 贝 宁 人 民 建 设 祖 国 添 砖 加 瓦 。 一 条 从 康 迪 到 科 托 努 的 铁 路 也 在 建 设 中 。 贝 宁 公 开 投 入 了 我 们 的 怀 抱 。";
			a.data[8] -= 80;
			a.influencePRC += 20;
			a.empires[1].relations -= 100;
			a.empires[1].power -= 20;
			GlobalScript.inst.gameState.allcountries[62].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[62].Torg = true;
			GlobalScript.inst.gameState.allcountries[62].proprc = true;
			GlobalScript.inst.gameState.allcountries[62].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[62].SubGosstroy = 17;
			GlobalScript.inst.gameState.allcountries[62].JoinAllOurAlliances(yes: true);
			if (a.allcountries[21].prosov)
			{
				text = " 法 国 总 统 罗 兰 · 勒 罗 伊 支 持 了 我 们 的 方 案 ， 慷 慨 的 免 除 了 贝 宁 欠 下 法 国 的 巨 额 债 务 。 克 雷 库 热 情 的 赞 扬 勒 罗 伊 总 统 “ 是 全 世 界 被 压 迫 人 民 的 代 言 人 ” ， “ 第 三 世 界 和 非 洲 解 放 运 动 的 旗 手 ” 。 贝 宁 和 法 国 的 关 系 显 著 改 善 了 ， 与 此 同 时 ， 法 国 ， 中 国 和 贝 宁 合 资 的 “ 贝 宁 人 民 矿 业 公 司 ” 在 法 国 的 指 导 下 开 始 建 设 。 而 贝 宁 经 济 或 多 或 少 稳 定 下 来 了 。 （ 这 种 情 况 只 需 要 四 块 钱 ， 贝 宁 变 中 立 民 主 社 ， 开 始 贸 易 。 ） ） ";
				a.data[8] += 40;
				GlobalScript.inst.gameState.allcountries[62].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[62].Torg = true;
				GlobalScript.inst.gameState.allcountries[62].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[62].SubGosstroy = 3;
			}
		}
		if (result_num == 1)
		{
			a.data[8] -= 10;
			text = " 凭 借 着 我 们 在 经 互 会 内 的 良 好 关 系 ， 我 们 提 议 将 贝 宁 纳 入 经 互 会 体 系 中 。 凭 借 得 天 独 厚 的 区 位 优 势 ， 贝 宁 将 为 经 互 会 提 供 足 够 的 矿 石 和 棉 花 。 经 互 会 也 将 稳 定 的 为 其 建 设 工 业 。 很 快 ， 贝 宁 的 经 济 稳 定 下 来 了 。";
			GlobalScript.inst.gameState.allcountries[62].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[62].SubGosstroy = 1;
			GlobalScript.inst.gameState.allcountries[62].Torg = true;
			a.empires[1].relations += 100;
			a.empires[1].power += 20;
			GlobalScript.inst.gameState.allcountries[62].isSEV = true;
		}
		if (result_num == 2)
		{
			if (!a.allcountries[21].prosov)
			{
				text = " 随 后 ， 克 雷 库 政 府 开 始 了 大 刀 阔 斧 的 经 济 改 革 。 克 雷 库 总 统 访 问 了 法 国 以 谋 求 改 善 和 法 国 的 关 系 ， 并 号 召 其 来 贝 宁 建 设 工 厂 ， 宣 布 将 不 对 法 资 企 业 做 过 多 的 限 制 。 效 果 是 立 竿 见 影 的 ： 贝 宁 免 除 了 外 债 ， 也 爆 发 了 大 量 劳 工 运 动 和 抗 议 ， 人 权 组 织 一 边 欢 迎 克 雷 库 放 弃 强 硬 的 对 外 路 线 ， 一 边 谴 责 其 暴 力 镇 压 工 人 运 动 。 但 只 要 法 国 还 在 ， 克 雷 库 不 会 有 问 题 的 ， 对 吧 ？";
				GlobalScript.inst.gameState.allcountries[62].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[62].SubGosstroy = 15;
				GlobalScript.inst.gameState.allcountries[62].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[62].puppetOf = 21;
			}
			else
			{
				text = " 法 国 总 统 罗 兰 · 勒 罗 伊 慷 慨 的 免 除 了 贝 宁 欠 下 法 国 的 巨 额 债 务 。 克 雷 库 热 情 的 赞 扬 勒 罗 伊 总 统 “ 是 全 世 界 被 压 迫 人 民 的 代 言 人 ” ， “ 第 三 世 界 和 非 洲 解 放 运 动 的 旗 手 ” 。 贝 宁 和 法 国 的 关 系 显 著 改 善 了 ， 与 此 同 时 ， 法 国 ， 中 国 和 贝 宁 合 资 的 “ 贝 宁 人 民 矿 业 公 司 ” 在 法 国 的 指 导 下 开 始 建 设 。 而 贝 宁 经 济 或 多 或 少 稳 定 下 来 了 。 ";
				GlobalScript.inst.gameState.allcountries[62].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[62].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[62].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[62].prosov = true;
			}
		}
	}
}
