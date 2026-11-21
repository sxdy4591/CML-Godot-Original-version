using EventsForDLC;
using UnityEngine;

public class Event481 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 锈 迹 斑 斑 的 马 蹄 铁";
		text = "  由 我 们 强 行 整 合 各 部 城 市 游 击 队 发 动 革 命 成 立 的 政 权 内 部 大 致 分 为 了 两 派 — — 主 张 社 会 主 义 革 命 的 “ 红 线 ” （ 前 身 是 <color=#8B0000>“ 红 色 旅 ”</color> 、 <color=#8B0000>“ 前 线 ”</color> 和 <color=#8B0000>“ 为 共 产 主 义 而 武 装 的 无 产 者 ”</color> 等 团 体 ） 和 主 张 法 西 斯 主 义 革 命 的 “ 黑 线 ” （ 前 身 是 <color=#8B4513>“ 武 装 革 命 核 心 ”</color> 、 <color=#8B4513>“ 第 三 位 置 ”</color> 和 <color=#8B4513>“ 黑 色 教 团 ”</color> 等 团 体 ） 。 此 前 他 们 还 存 在 一 个 “ 共 同 推 翻 资 本 主 义 ” 的 目 标 ， 而 现 在 ， 这 种 整 合 已 经 难 以 为 继 。 只 有 少 部 分 人 愿 意 在 明 面 上 奉 行 人 民 斗 争 协 会 的 官 方 意 识 形 态 — — 民 族 毛 主 义 。\n 或 许 ， 这 是 一 个 让 我 们 终 结 这 个 怪 胎 ， 在 意 大 利 建 立 真 正 的 社 会 主 义 / 法 西 斯 主 义 的 机 会 ? 亦 或 者 ， 我 们 可 以 组 织 一 场 谈 判 ， 甚 至 发 起 一 次 清 洗 来 维 持 新 领 导 层 的 民 族 毛 主 义 意 识 形 态 ， 减 少 动 荡 ， 最 大 限 度 地 保 护 好 我 们 的 西 欧 桥 头 堡 — — 只 需 让 民 族 毛 主 义 进 行 一 些 改 良 就 好 。 当 然 ， 脆 弱 的 反 建 制 联 盟 不 能 长 久 维 持 ， 必 须 要 做 出 选 择 了 。 极 右 派 分 子 得 益 于 其 与 前 资 产 阶 级 政 府 以 及 美 帝 国 主 义 的 关 系 ， 在 联 盟 中 具 有 一 定 的 优 势 ， 若 不 能 给 予 左 派 援 助 ， 等 待 意 大 利 反 建 制 阵 营 的 可 能 是 属 于 他 们 的 四 · 一 二 政 变 。\n 不 管 怎 么 样 ， 选 择 权 在 你 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[8] + a.data[36] >= 100 && a.data[9] >= 180 && a.data[22] >= 180)
		{
			button_text[0] = " 打 倒 黑 线 专 政 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 至 少 需 要 1 0 预 算 、 1 8 特 勤 网 络 和 1 8 点 军 力 … …";
		}
		if (a.data[8] + a.data[36] >= 100 && a.data[9] >= 150 && a.data[22] >= 150)
		{
			button_text[1] = " 打 倒 红 线 专 政 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 至 少 需 要 1 0 预 算 、 1 5 特 勤 网 络 和 1 5 点 军 力 … …";
		}
		if (a.data[8] + a.data[36] >= 150 && a.data[9] >= 200 && a.data[22] >= 200)
		{
			button_text[2] = " 打 倒 宗 派 主 义 ， 只 有 民 族 毛 主 义 才 是 意 大 利 的 出 路 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 至 少 需 要 1 2 预 算 、 20 特 勤 网 络 和 20 点 军 力 … …";
		}
		button_text[3] = " 随 他 去 吧";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 锈 迹 斑 斑 的 马 蹄 铁";
		if (result_num == 0)
		{
			text = " 我 们 只 是 需 要 右 派 的 武 装 力 量 为 我 们 所 用 ， 如 今 革 命 已 经 胜 利 ， 就 需 要 清 除 这 群 法 西 斯 匪 帮 了 。 我 们 的 特 工 联 系 到 <color=#8B0000>意 大 利 马 列 党</color> 、 两 个 <color=#8B0000>意 共 （ 马 列 ）</color> 、 <color=#8B0000>意 大 利 马 列 主 义 革 命 党</color> 和 <color=#8B0000>意 大 利 统 一 共 产 党</color> 等 反 修 派 组 织 ， 以 协 助 “ 红 线 ” 的 夺 权 。 在 这 些 组 织 控 制 的 武 装 、 工 会 以 及 我 们 的 特 工 小 组 的 帮 助 下 ， “ 红 线 ” 利 用 了 右 翼 尚 未 团 结 起 来 的 契 机 ， 赢 得 了 这 场 事 实 上 的 小 型 内 战 的 胜 利 。 他 们 决 定 整 合 所 有 的 反 修 派 为 奉 行 毛 主 义 的 <color=#8B0000>意 大 利 革 命 共 产 党</color> ， 领 导 新 的 意 大 利 人 民 革 命 政 府 。 新 政 府 宣 布 意 大 利 将 彻 底 肃 清 法 西 斯 主 义 和 黑 手 党 余 毒 ， 带 领 全 体 意 大 利 人 民 向 社 会 主 义 过 渡 。 ";
			a.data[8] -= 100;
			a.data[9] -= 180;
			a.data[22] -= 180;
			a.allcountries[85].Gosstroy = 1;
			a.allcountries[85].SubGosstroy = 17;
			a.allcountries[85].LeaveAlliances();
			a.allcountries[85].name = " 意 大 利 社 会 主 义 共 和 国";
			if (a.data[14] > 3 || a.data[15] > 7 || a.data[16] > 13 || a.data[50] > 28 || a.data[54] > 40 || a.data[52] > 36)
			{
				a.allcountries[85].LeaveAlliances();
			}
			else
			{
				a.allcountries[85].JoinAllOurAlliances(yes: true);
				a.allcountries[85].proprc = true;
				a.allcountries[85].Torg = true;
			}
		}
		if (result_num == 1)
		{
			text = " 我 们 只 是 需 要 左 派 的 武 装 力 量 为 我 们 所 用 ， 如 今 革 命 已 经 胜 利 ， 就 需 要 清 除 这 群 赤 匪 了 。 我 们 的 特 工 联 系 到 <color=#8B4513>意 大 利 社 会 运 动</color> 的 激 进 派 、 法 西 斯 主 义 工 会 和 支 持 新 法 西 斯 主 义 的 黑 手 党 组 织 ， 以 协 助 “ 黑 线 ” 的 夺 权 。 在 这 些 组 织 控 制 的 武 装 以 及 我 们 的 特 工 小 组 的 帮 助 下 ， “ 黑 线 ” 利 用 了 左 翼 尚 未 团 结 起 来 的 契 机 ， 赢 得 了 这 场 事 实 上 的 小 型 内 战 的 胜 利 。 他 们 决 定 整 合 所 有 的 激 进 派 法 西 斯 主 义 团 体 为 <color=#8B4513>新 秩 序 民 族 革 命 先 锋 党</color> ， 领 导 新 的 意 大 利 民 族 革 命 政 府 。 新 政 府 宣 布 意 大 利 将 彻 底 肃 清 犹 太 - 布 尔 什 维 克 余 毒 ， 塑 造 真 正 的 意 大 利 新 秩 序 。 ";
			a.data[8] -= 100;
			a.data[9] -= 150;
			a.data[22] -= 150;
			a.allcountries[85].Gosstroy = 0;
			a.allcountries[85].SubGosstroy = 9;
			a.allcountries[85].LeaveAlliances();
			a.allcountries[85].Torg = true;
			a.allcountries[85].name = " 意 大 利 社 会 共 和 国";
		}
		if (result_num == 2)
		{
			text = " 我 们 的 特 工 联 系 到 所 有 愿 意 支 持 民 族 毛 主 义 的 分 子 ， 他 们 决 定 展 开 最 终 的 夺 权 行 动 。 在 国 内 的 左 派 和 右 派 均 未 达 到 团 结 的 情 况 下 ， 民 族 毛 主 义 者 抓 住 了 机 会 ， 利 用 他 们 控 制 的 武 装 与 我 们 的 特 别 行 动 小 组 一 起 清 除 了 其 他 派 系 ， 赢 得 了 这 场 事 实 上 的 小 型 内 战 的 胜 利 。 人 民 斗 争 委 员 会 将 在 我 们 的 影 响 下 实 行 左 倾 的 民 族 毛 主 义 ， 引 领 意 大 利 民 族 革 命 。 但 是 ， 许 多 党 员 都 没 有 弄 明 白 我 们 为 什 么 要 真 心 支 持 他 们 。 ";
			a.data[8] -= 150;
			a.data[9] -= 200;
			a.data[22] -= 200;
			a.allcountries[85].Gosstroy = 0;
			a.allcountries[85].SubGosstroy = 10;
			a.allcountries[85].Torg = true;
		}
		if (result_num == 3)
		{
			text = " 对 于 这 个 我 们 自 己 捏 起 来 的 联 盟 ， 我 们 什 么 都 没 做 。 美 国 人 则 趁 机 而 入 ， 他 们 与 各 路 右 翼 分 子 本 就 有 联 系 （ 各 派 法 西 斯 主 义 者 、 民 族 保 守 主 义 者 、 纳 粹 主 义 者 等 ） ， 得 到 支 持 的 右 翼 分 子 直 接 发 起 了 军 事 政 变 。 随 后 ， 政 变 者 组 建 了 集 体 领 导 的 “ 大 委 员 会 ” 作 为 新 政 府 的 领 导 机 构 。 而 左 翼 分 子 被 清 洗 ， 甚 至 在 大 庭 广 众 下 被 未 经 审 判 地 处 决 。 由 于 右 翼 各 派 的 分 歧 ， 新 政 府 将 是 集 体 领 导 的 专 制 政 府 。 美 帝 与 意 大 利 资 产 阶 级 都 松 了 一 口 气 ， 比 起 被 赤 化 ， 专 制 政 府 根 本 算 不 了 什 么 ！ 美 国 也 只 能 捏 着 鼻 子 吃 下 这 一 “ 反 民 主 ” 的 果 实 。 ";
			a.allcountries[85].Gosstroy = 0;
			a.allcountries[85].SubGosstroy = 7;
			a.allcountries[85].LeaveAlliances();
			a.allcountries[85].Vyshi = true;
			if (a.allcountries[0].isNATO)
			{
				a.allcountries[85].isNATO = true;
			}
			a.allcountries[85].Torg = false;
			a.empires[0].power += 50;
			a.allcountries[85].name = " 意 大 利 国";
		}
	}
}
