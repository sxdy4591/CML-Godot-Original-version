using EventsForDLC;
using UnityEngine;

public class Event600 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 坦 桑 尼 亚 大 选";
		text = " 在 坦 桑 尼 亚 成 立 之 后 ， 自 1 9 6 5 年 开 始 ， 每 五 年 将 会 进 行 一 次 总 统 选 举 ， 但 是 由 于 坦 桑 尼 亚 是 革 命 党 的 一 党 制 共 和 国 ， 自 然 这 五 年 的 总 统 选 举 都 会 是 革 命 党 推 举 的 总 统 候 选 人 。 然 而 据 传 言 ， 已 经 连 任 四 届 坦 桑 尼 亚 总 统 的 尼 雷 尔 已 经 决 定 不 参 与 总 统 选 举 并 将 自 己 的 继 承 人 扶 上 位 。 根 据 我 们 的 情 报 ， 尼 雷 尔 的 继 承 人 大 概 率 是 阿 里 · 哈 桑 · 姆 维 尼 ， 他 是 1 9 8 4 年 的 桑 给 巴 尔 总 统 ， 因 其 治 下 的 市 场 自 由 化 政 策 得 以 恢 复 桑 给 巴 尔 的 经 济 而 知 名 。||如 果 我 们 对 坦 桑 尼 亚 的 影 响 力 足 够 大 到 可 以 让 尼 雷 尔 转 变 主 意 的 话 ， 我 们 其 实 还 有 几 个 备 用 人 选 ， 第 一 个 就 是 前 桑 给 巴 尔 政 党 乌 玛 党 的 党 主 席 阿 卜 杜 勒 拉 赫 曼 · 穆 罕 默 德 · 巴 布 ， 他 是 一 位 激 进 的 马 克 思 主 义 者 ， 巴 布 参 加 过 全 非 洲 人 民 会 议 ， 访 问 过 我 国 并 于 我 国 高 层 建 立 了 密 切 联 系 ， 其 为 坦 赞 铁 路 的 建 成 发 挥 了 关 键 作 用 ， 但 其 并 不 看 好 尼 雷 尔 的 乌 贾 马 社 会 主 义 ， 且 因 时 任 桑 给 巴 尔 总 统 阿 贝 德 · 阿 马 尼 · 卡 鲁 梅 刺 杀 案 而 被 错 捕 ， 最 后 被 特 赦 " + ((a.resultOfEvents[599] == 0) ? " 并 在 我 们 的 帮 助 下 重 回 政 府 ， 并 逐 步 扩 大 了 自 己 的 影 响 ） " : null) + "。 第 二 位 是 恩 贡 巴 莱 · 姆 维 鲁 ， 其 为 坦 噶 尼 喀 非 洲 民 族 联 盟 （ 革 命 党 在 坦 噶 尼 喀 地 区 的 前 组 织 ） 的 领 导 人 之 一 ， 并 参 与 了 将 坦 噶 尼 喀 非 洲 民 族 联 盟 和 桑 给 巴 尔 的 非 洲 - 设 拉 子 党 合 并 为 革 命 党 的 过 程 ， 其 有 对 马 克 思 主 义 有 着 坚 定 的 信 念 且 较 为 支 持 乌 贾 马 社 会 主 义 。 第 三 位 则 是 名 不 见 经 传 的 斯 坦 福 经 济 学 博 士 易 卜 拉 欣 · 利 彭 巴 ， 其 支 持 自 由 市 场 ， 虽 然 肯 定 成 不 了 革 命 党 的 总 统 候 选 人 ， 但 是 可 以 让 他 参 与 内 阁 来 逐 渐 影 响 坦 桑 尼 亚 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] < 2 && a.resultOfEvents[599] == 0)
		{
			button_text[0] = " 给 尼 雷 尔 施 压 一 下 ， 让 其 同 意 巴 布 成 为 继 任 者";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 对 我 们 的 盟 友 干 预 的 太 过 激 进 了";
		}
		if (a.data[56] < 3)
		{
			button_text[1] = " 让 姆 维 鲁 来 代 替 姆 维 尼";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 为 何 要 阻 挠 我 们 的 好 盟 友 进 行 改 革 ？";
		}
		if (a.data[56] > 2 && !a.event_done[500])
		{
			button_text[2] = " 施 压 尼 雷 尔 ， 让 利 彭 巴 来 辅 助 姆 维 尼 进 行 改 革";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 怎 么 能 放 任 这 种 右 翼 分 子 来 污 染 我 们 的 非 洲 社 会 主 义 同 志 ？";
		}
		button_text[3] = " 额 ， 我 们 为 何 要 干 预 我 们 盟 友 的 选 举 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 坦 桑 尼 亚 大 选";
		if (result_num == 0)
		{
			text = " 在 我 们 为 坦 桑 尼 亚 建 设 做 的 贡 献 面 前 ， 尼 雷 尔 最 终 同 意 将 姆 维 尼 撤 职 ， 并 将 巴 布 推 举 为 坦 桑 尼 亚 总 统 候 选 人 ， 但 是 革 命 党 党 主 席 一 职 依 旧 由 尼 雷 尔 担 任 。 不 出 所 料 ， 巴 布 顺 利 的 在 1 9 8 5 年 选 举 中 当 上 坦 桑 尼 亚 总 统 ， 其 宣 布 将 会 对 坦 桑 尼 亚 进 行 更 进 一 步 的 社 会 主 义 化 。";
			a.data[8] -= 50;
			a.allcountries[122].Gosstroy = 1;
			a.allcountries[122].SubGosstroy = 2;
			a.allcountries[122].LeaveAlliances();
			a.allcountries[122].EstablishGovernment(Government.ProChina);
			a.allcountries[122].JoinAllOurAlliances(yes: true);
			a.allcountries[122].soc_stab = 1000;
			a.allcountries[122].Torg = true;
			a.influencePRC += 10;
		}
		if (result_num == 1)
		{
			text = (a.allcountries[122].isSEV ? (((!a.allcountries[1].isSEV) ? " 在 我 们 为 坦 桑 尼 亚 建 设 做 的 贡 献 面 前 " : " 在 我 们 和 苏 联 为 坦 桑 尼 亚 建 设 做 的 贡 献 面 前 ") + " ， 尼 雷 尔 最 终 同 意 将 姆 维 尼 撤 职 ， 并 将 姆 维 鲁 推 举 为 坦 桑 尼 亚 总 统 候 选 人 ， 但 是 革 命 党 党 主 席 一 职 依 旧 由 尼 雷 尔 担 任 。 不 出 所 料 ， 姆 维 鲁 顺 利 的 在 1 9 8 5 年 选 举 中 当 上 坦 桑 尼 亚 总 统 ， 并 宣 布 将 会 继 续 维 持 乌 贾 马 社 会 主 义 政 策 ， 但 是 由 于 苏 联 在 当 地 的 长 期 影 响 使 得 坦 桑 尼 亚 最 终 更 加 的 亲 近 苏 联 而 非 亲 近 我 们 。") : " 在 我 们 和 苏 联 为 坦 桑 尼 亚 建 设 做 的 贡 献 面 前 ， 尼 雷 尔 最 终 同 意 将 姆 维 尼 撤 职 ， 并 将 姆 维 鲁 推 举 为 坦 桑 尼 亚 总 统 候 选 人 ， 但 是 革 命 党 党 主 席 一 职 依 旧 由 尼 雷 尔 担 任 。 不 出 所 料 ， 姆 维 鲁 顺 利 的 在 1 9 8 5 年 选 举 中 当 上 坦 桑 尼 亚 总 统 ， 并 宣 布 将 会 继 续 维 持 乌 贾 马 社 会 主 义 政 策 。 ");
			a.allcountries[122].LeaveAlliances();
			if (a.allcountries[122].isSEV)
			{
				a.allcountries[122].EstablishGovernment(Government.ProSoviet);
				a.empires[1].power += 25;
				a.empires[1].relations += 100;
			}
			else
			{
				a.allcountries[122].EstablishGovernment(Government.ProChina);
			}
			a.data[8] -= 50;
			a.allcountries[122].Gosstroy = 1;
			a.allcountries[122].SubGosstroy = 1;
			a.allcountries[122].Torg = true;
			a.allcountries[122].soc_stab = 1000;
			a.influencePRC += 5;
		}
		if (result_num == 2)
		{
			text = "在 我 们 为 坦 桑 尼 亚 建 设 做 的 贡 献 面 前 ， 尼 雷 尔 最 终 同 意 让 利 彭 巴 担 任 坦 桑 尼 亚 政 府 的 经 济 顾 问 ， 并 将 姆 维 尼 推 举 为 坦 桑 尼 亚 总 统 候 选 人 ， 但 是 革 命 党 党 主 席 一 职 依 旧 由 尼 雷 尔 担 任 。 不 出 所 料 ， 姆 维 尼 顺 利 的 在 1 9 8 5 年 选 举 中 当 上 坦 桑 尼 亚 总 统 ， 其 宣 布 将 会 对 坦 桑 尼 亚 的 经 济 进 行 大 范 围 的 改 革 ， 接 下 来 便 是 期 待 他 们 的 改 革 成 果 是 否 成 效 。";
			a.data[8] -= 60;
			a.allcountries[122].Gosstroy = 3;
			a.allcountries[122].SubGosstroy = 12;
			a.allcountries[122].LeaveAlliances();
			a.allcountries[122].EstablishGovernment(Government.ProChina);
			a.allcountries[122].Torg = true;
			a.allcountries[122].soc_stab = 1000;
			a.influencePRC += 5;
		}
		if (result_num == 3)
		{
			text = " 尼 雷 尔 最 终 将 姆 维 尼 推 举 为 坦 桑 尼 亚 总 统 候 选 人 ， 但 是 革 命 党 党 主 席 一 职 依 旧 由 尼 雷 尔 担 任 。 不 出 所 料 ， 姆 维 尼 顺 利 的 在 1 9 8 5 年 选 举 中 当 上 坦 桑 尼 亚 总 统 。 姆 维 尼 在 当 上 总 统 后 ， 进 行 全 国 范 围 内 的 经 济 自 由 化 政 策 ， 鼓 励 私 营 企 业 的 发 展 ， 开 始 与 国 际 货 币 基 金 组 织 进 行 谈 判 ， 并 以 拒 绝 削 减 免 费 公 共 服 务 和 政 府 内 部 加 薪 ， 最 后 获 得 了 一 笔 低 息 贷 款 。 之 后 开 始 向 政 府 内 部 进 行 改 革 并 准 备 实 行 多 党 制 。 但 是 在 其 经 济 改 革 下 ， 腐 败 行 为 逐 渐 增 加 ， “ 奔 驰 人 ” 也 越 来 越 多 ， 贫 富 差 距 逐 步 拉 大 。";
			a.data[8] -= 60;
			a.allcountries[122].Gosstroy = 2;
			a.allcountries[122].SubGosstroy = 15;
			a.allcountries[122].LeaveAlliances();
			a.allcountries[122].EstablishGovernment(Government.ProChina);
			a.allcountries[122].Torg = true;
			a.influencePRC += 5;
			a.allcountries[122].soc_stab = 1000;
		}
	}
}
