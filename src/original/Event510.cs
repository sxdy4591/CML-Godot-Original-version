using EventsForDLC;
using UnityEngine;

public class Event510 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 黄 金 海 岸 的 再 革 命 ？ — — 第 二 幕";
		text = " 加 纳 的 经 济 状 况 持 续 恶 化 ， 利 曼 软 弱 的 文 官 政 府 逐 渐 和 前 军 政 府 一 样 腐 败 和 低 效 。 到 1 9 8 1 年 底 ， 民 众 终 于 无 法 忍 受 K a l a b u l e 了 ， 经 济 危 机 和 种 族 冲 突 席 卷 了 整 个 加 纳 。";
		if (a.resultOfEvents[509] != 2)
		{
			text += " 1 9 8 2 年 1 月 1 日 晚 ， 罗 林 斯 领 导 了 一 场 不 流 血 的 军 事 政 变 ， 推 翻 了 利 曼 政 府 。 暂 停 了 该 国 的 宪 法 ， 所 有 政 党 的 活 动 都 被 禁 止 ， 前 政 府 的 腐 败 官 僚 被 人 民 法 庭 审 判 。 权 力 移 交 给 由 罗 林 斯 担 任 主 席 的 临 时 全 国 保 卫 委 员 会 （ N P D ） 。 他 说 ， 军 方 打 算 进 行 一 场 “ 民 族 民 主 革 命 ” ， 从 根 本 上 改 善 加 纳 人 的 生 活 。 所 有 地 方 执 行 机 构 都 被 解 散 ， 其 权 力 被 移 交 给 保 卫 革 命 委 员 会 （ C P R ） ， 全 国 基 层 组 织 和 工 矿 企 业 成 立 各 级 “ 人 民 保 卫 委 员 会 ” 和 “ 工 人 保 卫 委 员 会 ” ， 其 目 的 是 “ 让 人 民 参 与 治 理 国 家 并 建 立 一 种 新 型 的 民 主 ” 。 这 些 委 员 会 积 极 参 与 打 击 犯 罪 ， 腐 败 ， 走 私 ， 控 制 企 业 和 机 构 的 活 动 ， 从 事 食 品 分 配 等 。 临 时 全 国 保 卫 委 员 会 进 行 了 一 系 列 国 有 化 ， 并 建 立 了 价 格 控 制 制 度 。";
		}
		else
		{
			text += " 1 9 8 2 年 1 月 1 日 晚 ， 在 几 内 亚 的 支 持 下 ， 罗 林 斯 与 卡 迈 克 尔 领 导 全 非 人 民 革 命 党 成 功 开 展 了 一 场 不 流 血 的 军 事 政 变 ， 推 翻 了 利 曼 政 府 。 打 着 恩 克 鲁 玛 旗 号 的 人 民 民 族 党 被 宣 布 为 “ 背 离 恩 克 鲁 玛 的 修 正 主 义 者 ” ， 除 了 全 非 人 民 革 命 党 外 ， 所 有 政 党 的 活 动 都 被 禁 止 ， 前 政 府 的 腐 败 官 僚 被 人 民 法 庭 公 审 。 权 力 移 交 给 由 全 非 人 民 革 命 党 领 导 的 加 纳 非 洲 人 民 革 命 委 员 会 ， 实 施 “ 人 民 民 主 的 制 度 ” ， 各 级 人 民 革 命 委 员 会 将 取 代 旧 政 府 。 新 政 府 宣 布 将 继 承 恩 克 鲁 玛 的 遗 志 ， 致 力 于 全 非 洲 在 科 学 社 会 主 义 下 的 真 正 解 放 。 新 政 府 开 始 实 施 国 家 资 本 主 义 以 恢 复 经 济 ， 加 纳 将 在 不 久 后 开 展 社 会 主 义 改 造 。";
		}
		text += " 新 的 政 权 展 示 出 了 一 系 列 革 命 社 会 主 义 的 色 彩 。 我 们 也 应 该 表 态 了 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 2)
		{
			button_text[0] = " 为 加 纳 革 命 送 上 最 美 好 的 祝 福";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 党 内 还 有 几 个 左 派 ？";
		}
		if (a.data[56] > 1 && a.allcountries[51].dev == 1)
		{
			button_text[1] = " 我 们 绝 不 能 接 受 一 个 极 权 和 独 裁 的 加 纳 ， 快 给 我 拨 通 C I A 的 电 话 … …";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 是 帝 国 主 义 者 ！";
		}
		button_text[2] = " 好 吧 ， 谁 在 乎 呢";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 黄 金 海 岸 的 再 革 命 ？ — — 第 二 幕";
		if (result_num == 0)
		{
			if (a.resultOfEvents[509] != 2)
			{
				text = " 我 们 向 加 纳 派 出 了 大 使 并 援 助 了 他 们 一 批 用 以 解 决 经 济 困 难 的 物 资 ， 罗 林 斯 回 忆 到 恩 克 鲁 玛 时 代 我 国 与 加 纳 的 深 厚 友 谊 ， 对 我 们 表 示 感 谢 ， 我 们 同 加 纳 签 订 了 贸 易 协 定 。 目 前 ， 加 纳 的 局 势 正 在 向 好 。";
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 10;
				GlobalScript.inst.gameState.allcountries[63].Torg = true;
				a.data[8] -= 50;
			}
			else
			{
				text = " 我 们 继 续 为 加 纳 提 供 了 大 批 援 助 ， 作 为 交 换 ， 他 将 为 我 们 提 供 廉 价 可 可 ， 并 为 我 们 在 加 纳 开 采 黄 金 和 勘 探 石 油 提 供 最 大 的 帮 助 ， 我 们 将 为 加 纳 提 供 农 业 专 家 、 工 业 设 施 和 武 器 。 全 非 人 民 革 命 党 宣 布 将 准 备 “ 非 洲 的 人 民 战 争 ” ， 为 全 非 的 联 合 与 解 放 做 出 最 大 努 力 。 加 纳 同 几 内 亚 、 坦 桑 尼 亚 等 非 洲 社 会 主 义 国 家 建 立 了 深 入 的 联 系 。 西 方 的 帝 国 主 义 者 对 “ 另 一 个 恩 克 鲁 玛 的 回 归 ” 并 不 高 兴 。";
				a.data[8] -= 50;
				a.data[22] -= 50;
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].proprc = true;
				GlobalScript.inst.gameState.allcountries[63].Torg = true;
			}
		}
		if (result_num == 1)
		{
			a.data[9] -= 50;
			if (a.empires[0].relations >= 500)
			{
				text = " 加 纳 再 度 左 转 将 可 能 加 强 苏 东 阵 营 的 力 量 投 射 ， 我 们 应 该 阻 止 这 种 事 情 的 发 生 ！ 我 们 秘 密 通 知 了 美 国 。 不 久 ， 来 自 邻 国 科 特 迪 瓦 和 多 哥 的 雇 佣 军 便 在 中 情 局 的 帮 助 下 攻 破 了 阿 克 拉 ， 加 纳 政 府 猝 不 及 防 ， 没 有 组 织 起 像 样 的 抵 抗 。 左 翼 政 府 被 推 翻 ， 新 的 军 政 府 成 立 了 。";
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 7;
				GlobalScript.inst.gameState.allcountries[63].Vyshi = true;
				GlobalScript.inst.gameState.allcountries[63].Torg = true;
			}
			else
			{
				text = " 加 纳 的 情 报 机 构 发 现 了 来 自 科 特 迪 瓦 和 多 哥 方 向 的 异 动 。 他 们 宣 布 全 国 进 入 战 时 状 态 ， 并 在 边 界 和 首 都 加 强 了 防 御 ， 同 时 向 苏 联 请 求 援 助 。 最 后 ， 加 纳 政 府 粉 碎 了 政 变 阴 谋 ， 宣 布 与 美 国 和 我 们 断 绝 关 系 并 倒 向 苏 联 。";
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 10;
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].prosov = true;
				GlobalScript.inst.gameState.allcountries[63].Torg = false;
			}
		}
		if (result_num == 2)
		{
			if (a.resultOfEvents[509] != 2)
			{
				text = " 罗 林 斯 继 续 实 施 他 那 将 社 会 主 义 、 民 族 主 义 和 民 粹 主 义 混 合 起 来 的 理 念 ， 他 积 极 与 古 巴 和 利 比 亚 展 开 合 作 ， 并 接 待 了 德 西 · 鲍 特 瑟 （ 苏 里 南 ） 、 丹 尼 尔 · 奥 尔 特 加 （ 桑 解 阵 ） 和 萨 姆 · 乔 努 马 （ 纳 米 比 亚 ） 等 “ 革 命 者 ” 的 访 问 。 西 方 的 帝 国 主 义 者 对 罗 林 斯 的 政 府 并 不 高 兴 。 这 样 的 一 个 进 步 政 权 究 竟 能 在 非 洲 坚 持 多 久 ？";
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 10;
			}
			else
			{
				text = " 罗 林 斯 与 卡 迈 克 尔 的 革 命 政 权 致 力 于 科 学 社 会 主 义 下 的 泛 非 主 义 ， 新 政 府 与 我 们 开 展 合 作 ， 并 同 几 内 亚 、 坦 桑 尼 亚 等 非 洲 社 会 主 义 国 家 建 立 了 深 入 的 联 系 。 西 方 的 帝 国 主 义 者 对 “ 另 一 个 恩 克 鲁 玛 的 回 归 ” 并 不 高 兴 。";
				GlobalScript.inst.gameState.allcountries[63].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 0;
				GlobalScript.inst.gameState.allcountries[63].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[63].Torg = true;
			}
		}
	}
}
