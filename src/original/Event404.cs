using EventsForDLC;
using UnityEngine;

public class Event404 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = GlobalScript.inst.new_events_text[1197];
		text = " 输 掉 1 9 7 9 年 选 举 后 ， 工 党 开 始 左 倾 ， 党 内 左 翼 的 力 量 逐 渐 增 强 ， 其 中 最 有 代 表 性 的 是 以 <color=red>托 尼 · 本 恩</color> 为 首 的 “ 硬 左 派 ” — — 他 具 有 强 烈 的 左 翼 社 会 主 义 和 共 和 主 义 的 主 张 ， 而 且 同 情 马 克 思 主 义 — — 他 曾 在 1 9 7 6 年 尝 试 竞 选 党 的 领 导 人 ， 但 并 未 成 功 。 党 内 右 翼 对 左 翼 的 壮 大 并 不 满 意 ， 工 党 逐 渐 陷 入 党 内 派 系 倾 轧 的 危 机 中 。 这 导 致 工 党 在 1 9 8 0 年 詹 姆 斯 · 卡 拉 汉 辞 职 后 推 选 出 了 一 位 妥 协 领 导 人 （ <color=red>本 恩</color> 并 未 参 加 此 次 领 导 人 选 举 ） — — <color=green>迈 克 尔 · 富 特</color> （ 他 是 工 党 “ 软 左 派 ” 的 成 员 ） ， 希 望 以 此 维 持 工 党 的 团 结 。 但 是 党 内 右 派 明 显 对 他 也 不 满 意 — — 他 们 认 为 <color=green>富 特</color> 坚 持 英 国 应 实 行 单 方 面 核 裁 军 ， 并 退 出 欧 洲 经 济 共 同 体 （ E E C ） 的 立 场 过 于 激 进 且 极 左 。\n 天 不 遂 人 愿 ， 党 内 的 团 结 最 终 还 是 没 有 到 来 — — 工 党 中 一 部 分 具 有 影 响 力 的 右 翼 党 员 （ 例 如 罗 伊 · 詹 金 斯 、 戴 维 · 欧 文 、 比 尔 · 罗 杰 斯 与 雪 莉 · 威 廉 构 成 的 “ 工 党 四 人 帮 ” ， 以 及 罗 伯 特 · 麦 克 伦 南 ） 选 择 出 走 ， 并 转 而 建 立 社 会 民 主 党 。 尽 管 采 用 了 新 名 字 ， 但 该 党 开 始 实 施 事 实 上 的 中 间 派 政 策 ， 并 开 始 与 自 由 党 建 立 联 系 。 这 将 吸 引 部 分 中 间 派 选 民 。\n 同 时 ， 根 据 我 们 的 情 报 ， “ 硬 左 派 ” 领 袖 <color=red>托 尼 · 本 恩</color> 打 算 在 不 久 后 挑 战 <color=blue>丹 尼 斯 · 希 利</color> （ 他 是 工 党 右 派 ） 的 副 领 导 人 地 位 ， 竞 选 党 的 副 领 导 人 ， 以 推 动 党 的 进 一 步 左 转 。\n 工 党 内 部 的 另 一 大 争 议 在 于 “ 战 斗 ” 派 — — 一 个 采 用 “ 打 入 主 义 ” 策 略 的 托 洛 茨 基 主 义 团 体 ， 他 们 的 影 响 力 在 最 近 几 年 越 来 越 大 ， 并 已 经 控 制 工 党 的 青 年 翼 — — 他 们 试 图 实 现 工 党 基 础 的 “ 扩 大 ” 并 将 其 革 命 化 。 右 翼 希 望 驱 逐 他 们 ， 而 党 内 左 翼 拒 绝 这 种 “ 麦 卡 锡 主 义 政 策 ” 。\n 主 席 同 志 ， 或 许 这 是 一 个 我 们 插 手 英 国 的 好 机 会 ？   ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = GlobalScript.inst.new_events_text[1192];
		button_text[1] = " 支 持 <color=blue>丹 尼 斯 · 希 利</color> （ 需 要 5.0 百 万 预 算 与 10.0 点 特 工 网 络 ）";
		button_text[2] = " 支 持 <color=red>托 尼 · 本 恩</color> （ 需 要 5.0 百 万 预 算 与 10.0 点 特 工 网 络 ）";
		if (a.data[8] + a.data[36] >= 100 && a.data[9] >= 150 && a.allcountries[92].inflNATO >= 50)
		{
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[1193], GlobalScript.inst.new_events_text[592], GlobalScript.inst.new_events_text[593], GlobalScript.inst.new_events_text[594]);
		}
		else if (a.allcountries[92].inflNATO < 50)
		{
			Object.Destroy(button[3]);
			button_text[3] = GlobalScript.inst.new_events_text[1194];
		}
		else if (a.data[8] + a.data[36] < 100)
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[566], 10f);
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = string.Format(GlobalScript.inst.new_events_text[567], 15f);
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = GlobalScript.inst.new_events_text[1197];
		a.modifies[57].active = true;
		int num = 0;
		int num2 = 0;
		if (result_num == 1)
		{
			num++;
			a.data[8] -= 50;
			a.data[9] -= 100;
		}
		if (GlobalScript.inst.gameState.allcountries[4].Gosstroy == 2)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[2].prosov)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[86].Gosstroy == 2)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[85].Gosstroy == 2)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.ingamewars[5].is_going)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 3)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[8].SubGosstroy == 3)
		{
			num += 2;
		}
		if (GlobalScript.inst.gameState.empires[0].power > GlobalScript.inst.gameState.empires[1].power)
		{
			num++;
		}
		if (GlobalScript.inst.gameState.allcountries[30].Gosstroy == 3)
		{
			num++;
		}
		if (result_num == 2)
		{
			num2++;
			a.data[8] -= 50;
			a.data[9] -= 100;
		}
		if (GlobalScript.inst.gameState.allcountries[45].Gosstroy == 2)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[84].Gosstroy == 2)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[2].Gosstroy == 2)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[4].Gosstroy == 1)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.allcountries[2].puppetOf == 7)
		{
			num2--;
		}
		if (GlobalScript.inst.gameState.allcountries[4].puppetOf == 7)
		{
			num2--;
		}
		if (GlobalScript.inst.gameState.ingamewars[5].is_going)
		{
			num2--;
		}
		if (GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power)
		{
			num2++;
		}
		if (GlobalScript.inst.gameState.empires[0].now_leader == 0)
		{
			num2--;
		}
		if (result_num == 3)
		{
			text = string.Format(GlobalScript.inst.new_events_text[1196], "\n");
			a.data[8] -= 100;
			a.data[9] -= 150;
			a.data[1] -= 600;
			a.allcountries[92].inflNATO = 10;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 300;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality -= 300;
				}
				else
				{
					politic.loyality -= 100;
				}
			}
			a.allcountries[92].based = true;
		}
		else if (num > num2)
		{
			text = " <color=blue>希 利</color> 设 法 获 得 了 党 内 右 派 支 持 并 让 部 分 软 左 派 在 选 举 时 保 持 中 立 ， 最 终 以 不 到 百 分 之 一 的 优 势 保 住 了 自 己 的 位 置 ， 右 派 得 以 阻 止 党 的 继 续 左 倾 。 尽 管 <color=green>迈 克 尔 · 富 特</color> 并 不 希 望 对 “ 战 斗 ” 派 采 取 任 何 行 动 ， 但 是 党 内 右 翼 的 压 力 下 ， 工 党 最 终 开 始 打 压 “ 战 斗 ” 派 ， 他 们 逐 渐 被 边 缘 化 了 。";
			a.allcountries[92].SubGosstroy = 12;
			GlobalScript.inst.gameState.empires[0].power += 10;
		}
		else if (num <= num2)
		{
			text = " <color=red>本 恩</color> 设 法 在 工 会 和 党 员 中 获 得 了 大 部 分 的 支 持 ， 最 终 赢 得 了 副 领 导 人 的 位 置 。 在 大 会 上 ， <color=red>本 恩</color> 指 控 党 内 右 翼 背 叛 了 劳 工 运 动 ， 批 评 他 们 “ 是 社 会 民 主 主 义 者 ， 而 不 是 社 会 主 义 者 ” ， 背 叛 了 工 党 的 建 立 初 衷 ， 并 开 始 提 拔 “ 硬 左 派 ” 和 马 克 思 主 义 者 ， 这 显 著 加 强 了 他 的 影 响 力 ， 他 开 始 对 工 党 进 行 改 革 ， 要 求 工 党 融 入 工 会 和 工 人 阶 级 ， 并 加 强 党 内 民 主 。 在 <color=green>富 特</color> 和 <color=red>本 恩</color> 的 努 力 下 ， 右 翼 对 “ 战 斗 ” 派 的 打 压 并 未 成 功 ， 他 们 依 旧 在 工 党 内 部 活 动 。";
			a.allcountries[92].cw = true;
		}
	}
}
