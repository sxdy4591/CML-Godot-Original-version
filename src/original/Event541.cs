using EventsForDLC;
using UnityEngine;

public class Event541 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 我 们 高 唱 团 结 友 谊";
		text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 ！ 外 联 部 的 同 志 最 近 收 到 了 消 息 ， 随 着 我 国 与 苏 联 关 系 的 缓 和 ， 苏 共 国 际 部 希 望 就 我 国 在 世 界 民 主 青 年 联 盟 席 位 的 恢 复 商 谈 。 以 防 您 已 经 忘 了 这 个 组 织 ， 请 允 许 我 简 单 的 介 绍 一 下 ： 世 界 民 主 青 年 联 盟 是 世 界 左 翼 学 生 运 动 中 规 模 最 大 的 国 际 性 组 织 ， 旨 在 团 结 世 界 各 国 反 帝 爱 国 的 进 步 青 年 。 自 我 国 与 苏 联 决 裂 以 来 ， 中 国 共 产 主 义 青 年 团 和 中 华 全 国 青 年 联 合 会 便 停 止 了 出 席 此 类 活 动 。 而 随 着 我 国 与 苏 联 关 系 的 回 暖 ， 回 到 此 类 国 际 组 织 也 应 该 成 为 我 们 外 交 政 策 的 一 部 分 。 不 过 无 论 如 何 ， 您 都 有 权 利 投 上 庄 严 的 一 票 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 3)
		{
			button_text[0] = " 我 们 同 意 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 不 同 意 ！";
		}
		if (a.data[60] == 0 && a.influencePRC >= 350 && a.modifies[3].active)
		{
			button_text[1] = " 不 能 寄 人 篱 下 ， 我 们 要 搞 自 己 的";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 为 什 么 在 有 电 梯 的 时 候 ， 非 得 爬 楼 梯 呢 ？";
		}
		if (a.data[56] > 1)
		{
			button_text[2] = "为 啥 要 去 呢 ？";
			return;
		}
		Object.Destroy(button[2]);
		button_text[2] = " 可 是 资 本 主 义 世 界 的 人 都 去 了 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 们 高 唱 团 结 友 谊";
		if (result_num == 0)
		{
			text = " 我 们 决 定 重 新 回 到 世 界 民 主 青 年 联 盟 ， 苏 联 对 于 我 们 的 行 为 非 常 高 兴 。 在 世 界 民 主 青 年 联 盟 的 第 十 一 次 大 会 上 ， 出 于 对 修 复 我 国 关 系 和 地 沿 政 治 的 考 量 。 苏 联 高 调 宣 布 将 1 9 8 5 年 举 办 的 第 十 二 届 世 界 青 年 学 生 联 欢 会 的 东 道 国 为 中 华 人 民 共 和 国 。 各 个 代 表 都 相 当 高 兴 ， 这 不 仅 会 成 为 我 们 在 将 来 的 国 际 舞 台 上 发 光 发 声 的 基 石 。 也 象 征 着 欧 亚 大 陆 上 两 个 最 大 的 社 会 主 义 超 级 大 国 达 成 了 和 解 。";
			if (a.data[60] == 0)
			{
				text += " 但 是 ， 总 有 些 不 和 谐 的 声 音 ， 就 比 如 阿 尔 巴 尼 亚 的 领 袖 恩 维 尔 · 霍 查 ， 他 认 为 我 们 事 实 上 向 苏 联 人 投 降 了 。 他 再 三 询 问";
				text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
				text += " ";
				text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
				text += " 同 志 在 如 此 重 要 的 问 题 上 为 什 么 不 提 前 与 阿 尔 巴 尼 亚 同 志 交 流 ， 并 再 三 强 调 阿 尔 巴 尼 亚 人 民 不 会 向 邪 恶 的 社 会 帝 国 主 义 者 投 降 。";
			}
			a.data[1] += 100;
			a.data[3] += 100;
			a.data[6] -= 50;
			a.empires[1].relations += 100;
			a.influencePRC += 20;
		}
		if (result_num == 1)
		{
			text = " 我 们 没 有 直 接 回 应 这 一 决 定 ， 相 反 ， 我 们 开 始 着 手 组 建 自 己 的 国 际 青 年 联 盟 。 在 第 一 届 世 界 革 命 青 年 组 织 上 ， 缅 甸 共 产 主 义 青 年 团 ， 菲 律 宾 爱 国 青 年 组 织 ， 阿 尔 巴 尼 亚 劳 动 青 年 组 织 ， 泰 国 共 产 党 青 年 翼 ， 阿 富 汗 自 由 青 年 组 织 ， 秘 鲁 学 生 联 合 会 ， 坦 桑 尼 亚 革 命 党 统 一 青 年 与 学 生 组 织 ， 莫 桑 比 克 青 年 组 织 等 愿 意 和 中 华 人 民 共 和 国 坐 下 来 交 谈 的 青 年 组 织 收 到 了 邀 请 函 。 在 广 州 白 云 公 馆 召 开 的 的 第 一 届 大 会 上 ， 一 致 通 过 了 在1985 年5 月4 日 ， 在 北 京 举 办 第 一 节 世 界 革 命 青 年 与 学 生 联 欢 会 的 相 关 事 宜 得 到 了 通 过 。 作 为 上 述 党 政 集 团 中 最 有 影 响 力 的 ，";
			if (a.data[60] == 0)
			{
				text += " 阿 尔 巴 尼 亚 党 政 领 导 人 恩 维 尔 · 霍 查 十 分 高 兴 地 赞 扬 了 我 国 拒 绝 修 正 主 义 者 提 案 这 一 举 动 ， 并 表 明 “ 将 坚 定 不 移 的 和 中 国 同 志 站 在 一 起 ， 同 修 正 主 义 和 帝 国 主 义 作 斗 争 ” 。";
			}
			text += " 不 过 苏 联 可 就 气 坏 了 ， 毕 竟 我 们 狠 狠 的 打 了 他 们 一 巴 掌 ， 我 看 是 别 想 回 到 五 十 年 代 那 种 如 胶 似 漆 的 好 时 光 了 … …";
			a.data[1] += 100;
			a.data[3] += 100;
			a.data[6] += 50;
			a.empires[1].relations -= 150;
			a.influencePRC += 20;
		}
		if (result_num == 2)
		{
			text = " 苏 联 对 我 们 的 态 度 表 示 非 常 遗 憾 ， 并 希 望 在 下 次 能 得 到 更 积 极 的 回 应 。";
			a.empires[1].relations -= 50;
		}
	}
}
