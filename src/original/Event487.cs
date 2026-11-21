using EventsForDLC;
using UnityEngine;

public class Event487 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 帝 国 鹰 的 回 归";
		text = " 1 9 4 9 年 ， 奥 托 • 恩 斯 特 • 雷 默 成 立 了 社 会 主 义 帝 国 党 ， 很 快 就 变 成 了 一 个 新 纳 粹 组 织 ， 从 各 个 方 面 阻 碍 了 波 恩 与 西 方 阵 营 的 关 系 。 这 位 曾 在 东 线 作 战 并 镇 压 1 9 4 4 年 阴 谋 的 前 纳 粹 党 人 全 心 全 意 主 张 泛 欧 罗 巴 运 动 ， 反 对 “ 英 美 帝 国 主 义 和 犹 太 复 国 主 义 ” 。\n 社 会 主 义 帝 国 党 可 能 成 为 联 邦 德 国 的 第 三 大 党 ， 但 媒 体 发 起 了 反 对 该 党 的 运 动 ， 雷 默 被 拘 留 ， 之 后 他 移 居 海 外 生 活 。\n 尊 敬 的 主 席 同 志 ！ 如 您 所 知 ， 雷 默 一 直 希 望 能 回 到 祖 国 ， 试 图 在 那 里 恢 复 他 的 新 纳 粹 党 的 活 动 ， 苏 联 国 家 安 全 部 曾 资 助 过 该 党 。 据 我 们 的 特 工 报 告 ， 他 的 情 况 不 太 好 ， 联 邦 德 国 的 特 勤 部 队 已 经 在 准 备 瓦 解 他 的 影 响 力 。 也 许 我 们 应 该 利 用 这 个 机 会 ⋯ ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 为 什 么 要 支 持 这 个 法 西 斯 头 子 ？";
		if (a.data[16] >= 13 && a.data[31] >= 700 && a.data[50] != 24 && !GlobalScript.inst.gameState.allcountries[1].parts[8] && !GlobalScript.inst.gameState.allcountries[1].parts[7] && !GlobalScript.inst.gameState.allcountries[1].parts[9])
		{
			button_text[1] = " 邀 请 他 来 我 国 ， 并 允 许 他 出 版 一 些 作 品";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 己 所 不 欲 ， 勿 施 于 人";
		}
		Object.Destroy(button[2]);
		button_text[2] = " 我 们 永 远 做 不 到 这 种 事 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 帝 国 鹰 的 回 归";
		if (result_num == 0)
		{
			text = " 我 们 既 然 不 喜 欢 别 的 国 家 庇 护 日 本 军 国 主 义 者 ， 为 什 么 要 支 持 一 个 德 国 纳 粹 ？ 叫 他 滚 的 越 远 越 好 ！";
		}
		if (result_num != 1)
		{
			return;
		}
		text = " 我 们 私 下 里 和 雷 默 达 成 了 协 定 ， 邀 请 他 以 访 问 学 者 的 身 份 居 住 在 中 国 。 第 二 天 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 在 自 己 的 办 公 室 里 接 待 了 这 位 “ 法 西 斯 余 毒 ” 。 雷 默 高 度 赞 扬 了 中 国 的 革 命 氛 围 ， 对 扫 清 地 主 的 赞 美 和 全 国 人 民 团 结 一 致 建 设 祖 国 的 翼 赞 。 “ 我 看 中 国 搞 的 不 错 ， 反 革 命 基 本 被 扫 清 ， 生 活 也 极 大 富 裕 ， 民 族 同 志 和 民 族 斗 争 的 概 念 也 深 入 人 心 。 如 果 再 加 上 纳 粹 党 执 政 ， 中 国 就 是 我 们 理 想 的 民 族 社 会 主 义 社 会 。 ” 我 们 暂 且 把 这 番 话 当 成 恭 维 吧 … …\n 西 方 国 家 强 烈 谴 责 我 们 庇 护 一 位 法 西 斯 主 义 者 ， 我 们 的 国 际 局 势 显 著 恶 化 了 。";
		a.data[6] += 100;
		for (int i = 0; i < a.allcountries.Length; i++)
		{
			if ((a.allcountries[i].Gosstroy == 3 || i == 7) && i != 1)
			{
				a.allcountries[i].Torg = false;
				a.allcountries[i].proprc = false;
				a.allcountries[i].LeaveECON();
				a.allcountries[i].LeaveOKB();
				a.relres = false;
			}
		}
		a.data[8] -= 30;
		a.influencePRC += 5;
		a.empires[0].relations -= 500;
		a.empires[1].relations -= 500;
	}
}
