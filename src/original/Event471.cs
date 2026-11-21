using EventsForDLC;
using UnityEngine;

public class Event471 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 毛 泽 东 思 想 在 … … 苏 联 ？";
		text = " 我 们 在 苏 联 的 情 报 网 络 最 近 截 获 了 一 些 非 常 有 趣 的 新 闻 ， 在 古 比 雪 夫 成 立 了 一 个 新 兴 的 ， 独 立 于 苏 共 的 组 织 。 他 们 自 称 “ 无 产 阶 级 专 政 党 ” ， 领 导 人 为 格 里 戈 里 · 伊 萨 耶 夫 和 阿 列 克 谢 · 拉 兹 拉 斯 基 。 他 们 公 开 宣 称 资 本 主 义 已 经 在 苏 联 复 辟 ， 并 要 求 工 人 和 农 民 推 翻 现 任 政 府 。 他 们 也 大 力 赞 扬 了 无 产 阶 级 文 化 大 革 命 ， 尤 其 是 其 中 对 官 僚 主 义 的 打 击 。 他 们 在 《 第 二 个 共 产 党 宣 言 》 中 宣 称 无 产 阶 级 完 全 有 能 力 实 现 专 政 ， 而 不 是 被 官 僚 集 团 压 在 身 下 。\n 主 席 同 志 ， 我 们 要 不 要 做 点 什 么 ？ 毕 竟 他 们 很 可 能 是 最 后 一 批 抱 有 如 此 观 念 的 苏 联 人 了 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[56] <= 2 && GlobalScript.inst.gameState.allcountries[20].proprc && GlobalScript.inst.gameState.influencePRC >= 300 && GlobalScript.inst.gameState.modifies[6].active)
		{
			button_text[0] = " 邀 请 他 们 常 驻 北 京";
		}
		else if (GlobalScript.inst.gameState.data[56] > 2 || !GlobalScript.inst.gameState.modifies[6].active)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 国 内 都 没 几 个 毛 派 了 ， 为 什 么 支 持 苏 联 的 ？";
		}
		else if (!GlobalScript.inst.gameState.allcountries[20].proprc)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 有 阿 尔 巴 尼 亚 的 帮 助 ， 我 们 无 从 下 手 … …";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 的 影 响 力 太 小 了 ！";
		}
		if (GlobalScript.inst.gameState.data[56] != 0 && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.modifies[53].active)
		{
			button_text[1] = " 联 合 克 格 勃 与 史 塔 西 ， 把 这 些 叛 匪 一 网 打 尽";
		}
		else if (GlobalScript.inst.gameState.data[56] == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 背 叛 自 己 的 同 志 们 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 苏 联 不 会 和 我 们 合 作";
		}
		button_text[2] = " 太 远 了 ， 太 危 险 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 毛 泽 东 思 想 在 … … 苏 联 ？";
		if (result_num == 0)
		{
			text = " 我 们 大 使 馆 的 政 治 工 作 人 员 找 到 了 两 位 领 导 人 。 在 我 们 的 支 持 下 ， 伊 萨 耶 夫 与 拉 兹 拉 斯 基 同 志 来 到 了 北 京 ， 他 们 组 建 了 全 联 盟 共 产 党 （ 新 ） ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 公 开 接 见 了 他 们 。 阿 尔 巴 尼 亚 劳 动 党 也 很 快 承 认 了 他 们 。 在 地 拉 那 ， 全 联 盟 共 产 党 （ 新 ） 也 组 建 了 自 己 在 东 欧 的 第 一 个 办 公 室 。\n 他 们 也 开 始 撰 写 呼 吁 苏 联 人 民 觉 醒 并 推 翻 腐 朽 政 府 的 手 册 ， 并 通 过 北 京 之 声 的 特 别 频 道 不 间 断 向 苏 联 地 方 播 出 。 人 民 日 报 的 俄 语 版 也 专 门 撰 写 了 一 篇 名 为 《 在 马 克 思 列 宁 主 义 的 旗 帜 下 ， 为 新 苏 联 奋 斗 》 的 报 道 。 黑 河 市 的 大 喇 叭 不 间 断 的 向 对 岸 播 放 这 些 音 频 。 很 快 在 苏 联 内 部 就 出 现 了 小 规 模 支 持 他 们 的 罢 工 与 罢 课 。 克 格 勃 也 时 常 为 越 来 越 多 的 宣 传 册 感 到 头 疼 。\n 苏 联 方 面 对 此 的 表 态 是 “ 非 常 的 遗 憾 与 惊 讶 ” ， 但 他 们 并 没 有 做 出 任 何 激 进 的 表 现 。";
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.empires[1].power -= 10;
		}
		if (result_num == 1)
		{
			text = " 在 我 们 的 支 持 下 。 中 央 特 科 ， 史 塔 西 和 克 格 勃 完 成 了 一 场 近 乎 于 完 美 的 抓 捕 行 动 。 拉 兹 拉 斯 基 和 伊 萨 耶 夫 在 办 公 室 中 被 捕 ， 无 产 阶 级 专 政 党 也 被 解 散 。 两 人 被 判 流 放 。\n 苏 共 中 央 赞 扬 我 们 的 支 持 ， 我 们 和 苏 联 的 关 系 显 著 回 暖 ， 但 是 代 价 呢 ？";
			if (GlobalScript.inst.gameState.allcountries[20].proprc)
			{
				text += " 阿 尔 巴 尼 亚 劳 动 党 大 力 谴 责 了 我 们 的 行 为 ， 指 责 我 们 背 叛 了 毛 主 义 的 革 命 性 内 容 ， 并 事 实 上 蜕 变 成 了 莫 斯 科 的 傀 儡 。";
				GlobalScript.inst.gameState.allcountries[20].proprc = false;
			}
			GlobalScript.inst.gameState.empires[1].relations += 200;
			GlobalScript.inst.gameState.data[8] += 50;
			GlobalScript.inst.gameState.influencePRC -= 50;
			GlobalScript.inst.gameState.empires[1].power += 50;
		}
		if (result_num == 2)
		{
			text = " 苏 共 当 局 不 能 忍 受 这 样 危 险 的 存 在 ， 拉 兹 拉 斯 基 和 伊 萨 耶 夫 在 办 公 室 中 被 捕 ， 无 产 阶 级 专 政 党 也 被 解 散 。 两 人 被 判 流 放 。";
			GlobalScript.inst.gameState.influencePRC -= 20;
		}
	}
}
