using EventsForDLC;
using UnityEngine;

public class Event456 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 高 考 ？ 高 考 ！";
		text = " 自 党 中 央 的 一 纸 号 令 以 来 ， 我 国 采 取 了 “ 工 农 兵 大 学 生 ” 制 度 。 即 在 接 受 正 常 理 工 科 教 育 的 同 时 ， 参 与 生 产 实 践 活 动 。 同 样 的 也 有 工 人 ， 农 民 ， 解 放 军 士 兵 接 受 高 等 教 育 。 和 从 前 的 应 试 考 试 不 同 ， 这 套 政 策 开 创 性 的 将 群 众 引 入 了 招 生 中 ， 不 以 做 题 而 以 实 践 来 招 生 。\n 但 同 时 ， 党 内 也 有 一 部 分 人 认 为 这 一 套 应 当 慢 慢 的 结 束 ， 转 而 恢 复 老 一 套 的 高 等 教 育 考 试 体 系 。 他 们 的 论 点 是 过 去 的 生 源 质 量 欠 佳 ， 过 于 强 调 根 正 苗 红 反 而 扼 杀 了 真 正 有 才 华 的 学 生 。 主 席 同 志 ， 我 们 是 否 要 恢 复 高 考 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (!GlobalScript.inst.gameState.modifies[3].active)
		{
			button_text[0] = " 工 农 兵 大 学 生 是 过 去 的 产 物 ， 早 该 修 修 了 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 恢 复 高 考 ？ 你 想 和 毛 主 席 的 七 · 二 一 指 示 对 着 干 吗 ？";
		}
		if (GlobalScript.inst.gameState.data[56] >= 1 && GlobalScript.inst.gameState.data[56] < 3 && !GlobalScript.inst.gameState.modifies[3].active)
		{
			button_text[1] = " 引 入 预 科 制 度";
		}
		else if (GlobalScript.inst.gameState.modifies[3].active || GlobalScript.inst.gameState.data[56] == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = "  现 在 的 制 度 有 什 么 问 题 ？";
		}
		else if (GlobalScript.inst.gameState.data[56] >= 3)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 这 还 不 如 不 改 ！";
		}
		if (GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.modifies[3].active)
		{
			button_text[2] = " 我 们 拒 绝 修 正 ， 但 我 们 接 受 完 善";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 总 得 来 点 变 化 ， 对 吧 ？";
		}
		button_text[3] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 高 考 ？ 高 考 ！";
		if (result_num == 0)
		{
			text = " 中 共 中 央 和 教 育 部 颁 布 了 一 项 通 报 ， 宣 布 将 恢 复 自 6 6 年 终 止 的 全 国 高 校 统 一 招 生 考 试 。 1 9 7 7 年 1 0 月 2 1 日 ， 人 民 日 报 头 版 头 条 《 高 等 学 校 招 生 进 行 重 大 改 革 》 ， 宣 布 中 断 了 十 余 年 的 高 考 将 恢 复 考 试 ， 这 一 消 息 迅 速 传 遍 了 全 国 各 地 。\n 1 9 7 7 年 冬 天 ， 举 行 了 恢 复 高 考 后 的 第 一 次 考 试 ， 考 试 分 为 文 史 与 理 工 两 科 ， 文 史 类 科 目 是 思 想 政 治 、 语 文 、 数 学 、 史 地 （ 历 史 和 地 理 ） ， 理 工 类 科 目 是 政 治 、 语 文 、 数 学 、 理 化 （ 物 理 和 化 学 ） ， 报 考 外 语 专 业 的 要 加 试 外 语 。\n 全 国 各 地 的 考 生 对 此 投 来 了 热 切 的 目 光 ， 这 是 一 个 时 代 的 终 结 ， 也 是 一 个 时 代 的 开 始 。";
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.power -= 10;
				}
				else if (politic.traits[0] == 3 || politic.traits[0] == 2)
				{
					politic.power += 20;
				}
			}
			a.data[1] += 100;
			a.data[3] += 100;
			a.empires[0].relations += 100;
			a.empires[1].relations += 100;
		}
		if (result_num == 1)
		{
			text = " 中 共 中 央 和 教 育 局 决 定 引 入 预 科 制 度 。 这 将 作 为 工 农 兵 大 学 生 的 替 代 品 ， 在 每 个 学 生 接 受 了 “ 工 人 农 民 和 解 放 军 的 再 教 育 ” 之 后 。 他 们 将 继 续 接 受 高 等 院 校 的 教 育 （ 当 然 他 们 也 可 以 选 择 结 束 教 育 ， 并 得 到 专 科 学 历 ） 。 这 给 了 一 些 愿 意 为 祖 国 做 贡 献 的 青 年 人 接 受 进 一 步 教 育 的 机 会 ， 同 时 这 也 顾 及 到 了 一 些 高 级 知 识 份 子 的 脸 面 。\n 总 体 来 说 ， 这 一 方 案 刚 刚 好 ， 反 对 的 人 不 多 ， 赞 同 的 人 不 少 。 ";
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.power -= 5;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.power += 5;
				}
			}
			a.data[1] += 50;
			a.data[3] += 100;
		}
		if (result_num == 2)
		{
			text = " 我 们 必 须 承 认 现 在 的 这 些 政 策 的 确 不 妥 ， 但 这 不 是 问 题 的 核 心 。 一 旦 恢 复 高 考 制 ， 上 海 和 北 京 这 样 的 大 都 市 和 石 河 子 ， 克 拉 玛 依 这 样 的 地 方 的 差 距 只 会 越 来 越 大 。 高 考 制 不 会 利 好 无 产 阶 级 ， 只 会 构 建 一 批 新 的 脱 产 者 ， 他 们 不 学 无 术 ， 只 会 给 祖 国 带 来 问 题 却 不 想 着 解 决 。 而 太 多 学 校 一 听 到 要 招 收 农 民 和 工 人 子 弟 就 难 受 的 不 得 了 ， 这 难 道 是 正 确 的 吗 ？ 我 们 应 该 让 更 多 优 秀 的 高 等 教 育 机 构 进 一 步 深 入 农 村 。 而 推 荐 制 可 以 为 我 们 找 到 最 优 秀 的 无 产 者 ， 他 们 肯 融 入 无 产 者 ， 也 愿 意 接 受 新 知 识 。 难 道 一 个 因 为 生 产 队 长 没 时 间 复 习 ， 就 一 定 表 明 他 是 个 差 生 吗 ？ 恰 恰 相 反 ！ 他 只 是 想 更 好 的 建 设 农 村 ， 为 无 产 阶 级 文 化 大 革 命 添 砖 加 瓦 。 而 试 图 为 高 考 辩 护 的 人 才 是 真 正 的 资 产 阶 级 ， 恢 复 高 考 就 是 资 产 阶 级 对 无 产 阶 级 的 反 扑 ， 我 们 必 须 要 说 不 ！";
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.power += 10;
				}
				else if (politic3.traits[0] == 3 || politic3.traits[0] == 4)
				{
					politic3.power -= 5;
				}
			}
			a.data[1] -= 50;
			a.data[3] += 50;
		}
		GlobalScript.inst.old_modify_desc[2] = "根 据 服 务 业 的 发 展 情 况 获 得 效 果|";
		if (GlobalScript.inst.gameState.data[108] < 54)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>受 到 管 控 的 私 有 制 ：</color> 投 机 倒 把 的 商 人 还 影 响 不 到 我 们";
		}
		else if (GlobalScript.inst.gameState.data[108] < 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>逐 渐 崛 起 的 寡 头 ：</color>人 民 支 持 度-0.5 ， 思 想 自 由 化+1 ， 生 活 水 平-0.5 ";
		}
		else if (GlobalScript.inst.gameState.data[108] >= 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>寡 头 执 政 ：</color>人 民 支 持 度-1 ， 思 想 自 由 化+2 ， 生 活 水 平-1 ";
		}
		if (!GlobalScript.inst.gameState.event_done[669])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.1 ， 工 业+0.2 ，农 业+0.2 ， 人 民 支 持 度+0.2 ， 科 技 点 数+0.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 0)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.2 ， 工 业+0.3 ，农 业+0.3 ， 人 民 支 持 度+0.3 ， 科 技 点 数+1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 1)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>正 统 社 会 主 义 教 育 路 线 ：</color>预 算-0.1 ， 腐 败 + 0.1 ， 科 技 点 数+1.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 2)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>混 合 式 教 育 体 制 改 革 ：</color>预 算+0.2 ， 寡 头 力 量+0.1 , 腐 败 + 0.2 ， 科 技 点 数+2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 3)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>全 民 军 事 化 教 育 ：</color>军 事 力 量+0.3 ，人 民 支 持 度+1 ， 思 想 自 由 化-1 ， 科 技 点 数-2 ， 凝 聚 力+0.5 ， 民 族 情 绪+0.5";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[456] == 0 && GlobalScript.inst.gameState.event_done[456])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>全 国 高 校 统 一 招 生 考 试 ：</color>科 技 点 数 +2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 1 && GlobalScript.inst.gameState.event_done[456])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>预 科 制 度 ：</color>科 技 点 数 +1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 2 || !GlobalScript.inst.gameState.event_done[456])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>无 产 阶 级 推 荐 制 ：</color>农 业+0.3 ， 工 业+0.3";
		}
		if (!GlobalScript.inst.gameState.event_done[646])
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>合 作 医 疗 ：</color>预 算-0.1 ， 工 业+0.2 ， 农 业+0.3 ， 人民支持度+0.2 , 服 务 业+0.2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 0)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>精 进 的 合 作 医 疗 ：</color>预 算-0.2 ， 工 业+0.3 ， 农 业+0.4 ， 人民支持度+0.2 , 服 务 业+0.3";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 1)
		{
			GlobalScript.inst.old_modify_desc[2] += "|<color=red>市 场 化 改 革 医 疗 ：</color>预 算+0.2 ， 生 活 水 平+0.1 ， 寡 头 力 量+0.1 , 服 务 业+0.1";
		}
	}
}
