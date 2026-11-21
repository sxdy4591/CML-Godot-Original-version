using EventsForDLC;
using UnityEngine;

public class Event599 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 医 疗 队 员 到 坦 桑";
		text = " 自 坦 噶 尼 喀 独 立 以 来 ， 坦 噶 尼 喀 总 统 朱 利 叶 斯 · 尼 雷 尔 便 坚 持 社 会 主 义 立 场 ， 1 9 6 4 年 坦 噶 尼 喀 和 社 会 主 义 革 命 后 的 桑 给 巴 尔 合 并 为 坦 桑 尼 亚 联 合 共 和 国 ， 1 9 6 7 年 坦 桑 尼 亚 总 统 尼 雷 尔 颁 布 《 阿 鲁 沙 宣 言 》 ， 坦 桑 尼 亚 开 始 实 行 乌 贾 马 社 会 主 义 ， 并 开 始 实 行 乌 贾 马 式 合 作 社 ， 将 企 业 大 量 收 归 国 有 ， 但 由 于 尼 雷 尔 对 于 建 成 乌 贾 马 社 会 主 义 的 期 望 过 于 急 切 ， 大 量 乌 贾 马 村 被 行 政 命 令 建 成 ， 加 上 随 之 而 来 的 1 9 7 4 - 1 9 7 5 年 严 重 干 旱 灾 害 ， 导 致 农 业 损 失 惨 重 ， 尼 雷 尔 被 迫 仅 保 留 小 部 分 乌 贾 马 村 ， 并 将 之 前 建 立 的 大 量 乌 贾 马 村 进 行 “ 村 子 化 ” （ 即 退 回 初 级 合 作 社 ） 。 在 坦 桑 尼 亚 成 立 之 后 ， 坦 桑 尼 亚 首 先 承 认 我 们 并 与 我 国 持 续 亲 密 的 关 系 ， 我 国 一 直 在 坦 桑 尼 亚 援 助 建 设 ， 建 成 了 包 括 坦 赞 铁 路 等 项 目 。||在 乌 坦 战 争 爆 发 之 后 ， 刚 从 1 9 7 4 - 1 9 7 5 年 严 重 干 旱 灾 害 中 恢 复 过 来 的 坦 桑 尼 亚 经 济 遭 到 了 毁 灭 性 打 击 ： 战 争 期 间 政 府 将 大 量 资 金 投 入 于 国 防 之 中 并 暂 停 其 他 部 门 的 所 有 工 程 ， 战 争 导 致 卡 盖 拉 地 区 经 济 损 失 超 一 亿 美 元 ， 而 在 战 争 之 后 ， 因 军 队 规 模 的 扩 大 所 造 成 的 巨 量 国 防 开 销 " + ((a.allcountries[118].SubGosstroy == 15) ? "和 驻 扎 乌 干 达 的 维 和 经 费 " : null) + "则 加 大 了 政 府 赤 字 。 而 在 政 府 内 部 ， 腐 败 现 象 逐 渐 普 遍 。 为 缓 解 战 后 过 重 的 经 济 负 担 ， 坦 桑 尼 亚 开 始 对 外 寻 求 经 济 援 助 ， 这 其 中 自 然 就 包 括 了 我 们 。 我 们 是 否 应 该 完 全 承 包 下 坦 桑 尼 亚 的 财 政 赤 字 ？ 或 者 如 果 我 们 和 苏 联 关 系 甚 好 ， 我 们 和 苏 联 一 起 承 担 坦 桑 尼 亚 的 财 政 赤 字 ？ 亦 或 者 如 果 我 们 囊 中 羞 涩 ， 或 许 只 需 要 帮 他 们 稍 微 缓 解 一 点 经 济 负 担 尽 一 点 盟 友 的 责 任 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 3)
		{
			button_text[0] = " 我 们 全 部 包 下 了";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 还 是 囊 中 羞 涩 啊";
		}
		if (a.data[56] < 3 && (a.empires[1].relations >= 700 || a.allcountries[1].isSEV))
		{
			button_text[1] = " 与 苏 联 一 起 偿 还 ， 并 邀 请 其 加 入 经 互 会";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 和 苏 联 一 起 ？ 你 在 开 什 么 玩 笑 ？";
		}
		button_text[2] = " 稍 微 帮 他 们 解 决 一 下";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 医 疗 队 员 到 坦 桑";
		if (result_num == 0)
		{
			text = " 我 们 决 定 全 部 承 担 坦 桑 尼 亚 的 全 部 赤 字 ， 为 坦 桑 尼 亚 提 供 大 量 低 息 甚 至 无 息 贷 款 并 在 坦 桑 尼 亚 再 次 进 行 一 系 列 的 援 建 工 程 ， 包 括 不 限 于 援 建 工 厂 ， 修 建 水 利 工 程 等 ， 并 派 出 我 们 的 顾 问 对 坦 桑 尼 亚 经 济 问 题 进 行 指 导 。 在 我 们 顾 问 的 指 导 下 ， 战 争 期 间 大 量 新 征 召 的 坦 桑 尼 亚 人 民 国 防 军 士 兵 分 批 次 进 行 退 役 ， 将 退 役 士 兵 进 行 简 单 的 职 业 技 能 培 训 ， 并 将 部 分 回 乡 士 兵 组 织 成 当 地 民 兵 骨 干 ， 坦 桑 尼 亚 政 府 开 始 进 一 步 清 理 腐 败 问 题 ， 腐 败 现 象 被 进 一 步 遏 制 ， 人 们 口 中 的 “ 奔 驰 人 ” （ w a b e n z i ） 即 贪 官 出 现 的 越 来 越 少 ， 在 我 们 付 出 了 如 此 多 的 努 力 之 后 ， 我 们 仅 要 求 让 前 乌 玛 党 主 席 阿 卜 杜 勒 拉 赫 曼 · 穆 罕 默 德 · 巴 布 回 归 政 坛 ， 其 不 赞 成 尼 雷 尔 温 和 的 乌 贾 马 式 社 会 主 义 并 因 为 前 桑 给 巴 尔 总 统 阿 贝 德 · 阿 马 尼 · 卡 鲁 梅 刺 杀 案 而 被 错 捕 ， 坦 桑 尼 亚 在 我 们 的 帮 助 下 顺 利 的 解 决 了 经 济 问 题 ， 并 未 因 为 经 济 问 题 而 转 变 乌 贾 马 社 会 主 义 的 立 场 和 违 背 《 阿 鲁 沙 宣 言 》 ， 尼 雷 尔 十 分 感 激 我 们 的 援 建 工 程 ， 坦 桑 尼 亚 俨 然 成 为 了 中 国 在 非 洲 建 设 的 榜 样 。 ";
			a.data[8] -= 150;
			a.allcountries[122].Gosstroy = 1;
			a.allcountries[122].SubGosstroy = 1;
			a.allcountries[122].LeaveAlliances();
			a.allcountries[122].EstablishGovernment(Government.ProChina);
			a.allcountries[122].Torg = true;
			a.allcountries[122].soc_stab = 1000;
			a.influencePRC += 10;
		}
		if (result_num == 1)
		{
			text = " 我 们 决 定 利 用 与 苏 联 的 良 好 关 系 来 帮 助 坦 桑 尼 亚 解 决 经 济 问 题 ， 我 们 和 苏 联 的 低 息 贷 款 大 量 进 入 坦 桑 尼 亚 的 同 时 ， 苏 联 也 开 始 投 资 桑 给 巴 尔 的 丁 香 产 业 ， 坦 桑 尼 亚 人 民 国 防 军 则 在 苏 联 顾 问 的 指 导 下 开 始 进 行 改 编 ， 乌 贾 马 式 合 作 社 得 到 发 展 ， 但 是 苏 联 的 这 些 援 助 并 非 免 费 的 午 餐 ， 作 为 条 件 ， 坦 桑 尼 亚 必 须 加 入 经 互 会 。 尽 管 坦 桑 尼 亚 对 我 们 的 好 感 大 于 苏 联 ， 但 是 苏 联 的 影 响 力 与 日 俱 增 ， 终 有 一 天 会 赶 超 我 们 的 。 ";
			a.data[8] -= 50;
			a.allcountries[122].Gosstroy = 1;
			a.allcountries[122].SubGosstroy = 1;
			a.allcountries[122].LeaveAlliances();
			a.allcountries[122].EstablishGovernment(Government.ProChina);
			a.allcountries[122].soc_stab = 1000;
			a.allcountries[122].Torg = true;
			a.allcountries[122].isSEV = true;
			a.influencePRC += 5;
			a.empires[1].power += 25;
			a.empires[1].relations += 100;
		}
		if (result_num == 2)
		{
			text = " 我 们 之 前 援 建 的 已 经 足 够 多 了 ， 但 是 看 在 中 坦 两 国 友 谊 的 份 上 ， 我 们 决 定 提 供 一 定 数 额 的 低 息 贷 款 以 缓 解 坦 桑 尼 亚 的 经 济 问 题 。 尽 管 如 此 ， 坦 桑 尼 亚 所 面 临 的 财 政 赤 字 依 旧 十 分 巨 大 。 在 拒 绝 了 国 际 货 币 基 金 组 织 提 供 的 贷 款 条 件 之 后 ， 坦 桑 尼 亚 被 迫 逐 步 放 宽 经 济 政 策 … …";
			a.data[8] -= 60;
			a.allcountries[122].Gosstroy = 2;
			a.allcountries[122].SubGosstroy = 3;
			a.allcountries[122].LeaveAlliances();
			a.allcountries[122].EstablishGovernment(Government.ProChina);
			a.allcountries[122].soc_stab = 1000;
			a.allcountries[122].Torg = true;
			a.influencePRC += 5;
		}
	}
}
