using EventsForDLC;
using UnityEngine;

public class Event931 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 民 主 的 故 乡 — — 第 二 幕";
		if (a.resultOfEvents[93] != 0)
		{
			text = " 希 腊 即 将 迎 来 后 军 政 府 时 代 的 第 三 次 议 会 选 举 。 主 要 反 对 党 新 民 主 党 面 临 严 重 的 内 部 冲 突 。 于 此 同 时 ， 希 腊 社 会 的 左 倾 让 左 翼 有 望 在 此 次 大 选 中 获 胜 。 在 左 翼 方 面 ， 泛 希 腊 社 会 主 义 运 动 和 希 腊 共 产 党 都 希 望 退 出 北 约 和 欧 共 体 ， 而 新 民 主 党 则 希 望 继 续 推 进 进 入 欧 共 体 的 进 程 ， 并 深 化 与 北 约 的 合 作 。 如 果 左 翼 在 此 次 大 选 中 获 得 胜 利 ， 希 腊 将 有 望 退 出 北 约 并 终 止 加 入 欧 共 体 的 进 程 。 选 举 的 结 果 将 影 响 希 腊 和 欧 洲 的 局 势 。";
		}
		else
		{
			text = " 希 腊 即 将 迎 来 后 军 政 府 时 代 的 第 三 次 议 会 选 举 。 主 要 反 对 党 新 民 主 党 面 临 严 重 的 内 部 冲 突 。 希 腊 左 翼 政 府 实 行 的 社 会 主 义 改 革 在 国 内 很 受 欢 迎 。 左 翼 政 府 通 过 的 宪 法 修 正 案 使 得 总 统 完 全 失 去 了 权 力 ， 希 腊 彻 底 成 为 了 议 会 制 共 和 国 。 泛 希 腊 社 会 主 义 运 动 、 希 腊 共 产 党 等 左 翼 政 党 在 国 内 巩 固 了 他 们 的 影 响 力 。 可 以 说 ， 此 次 大 选 让 右 翼 党 派 已 经 无 力 与 左 翼 抗 衡 了 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (a.resultOfEvents[93] != 0)
		{
			kolvo_variant = 3;
			if (GlobalScript.inst.gameState.data[9] >= 40)
			{
				button_text[0] = " 支 持 泛 希 腊 社 会 主 义 运 动";
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = " 我 们 没 有 足 够 的 力 量";
			}
			if (GlobalScript.inst.gameState.data[9] >= 40)
			{
				button_text[1] = " 支 持 新 民 主 党";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 我 们 没 有 足 够 的 力 量";
			}
			button_text[2] = " 保 持 距 离";
		}
		else
		{
			kolvo_variant = 1;
			button_text[0] = " 我 们 只 需 等 待 ！";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 民 主 的 故 乡 — — 第 二 幕";
		if (a.resultOfEvents[93] != 0)
		{
			switch (result_num)
			{
			case 0:
				text = " 我 们 的 特 勤 部 门 帮 助 泛 希 腊 社 会 主 义 运 动 开 展 竞 选 活 动 ， 并 且 积 极 地 阻 碍 新 民 主 党 的 竞 选 活 动 。 他 们 成 功 赢 得 了 大 选 ， 组 建 了 希 腊 历 史 上 第 一 个 社 会 主 义 政 府 。 在 我 们 和 苏 联 的 支 持 下 ， 希 腊 新 政 府 设 法 排 除 了 亲 欧 共 体 势 力 的 影 响 ， 终 止 了 加 入 欧 共 体 的 进 程 ， 但 是 因 为 反 对 意 见 过 大 ， 希 腊 最 终 未 能 退 出 北 约 。 帕 潘 德 里 欧 政 府 承 认 了 民 族 抵 抗 运 动 和 本 都 希 腊 人 的 种 族 灭 绝 。 并 开 始 着 手 建 立 国 家 卫 生 系 统 和 废 除 希 腊 宪 兵 队 与 城 市 警 察 ， 将 他 们 合 并 为 一 个 单 一 的 警 察 机 构 。";
				GlobalScript.inst.gameState.data[6] += 10;
				GlobalScript.inst.gameState.empires[0].relations -= 50;
				GlobalScript.inst.gameState.empires[1].relations += 50;
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[45].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[45].Torg = true;
				GlobalScript.inst.gameState.allcountries[87].spec -= 5;
				GlobalScript.inst.gameState.empires[0].power -= 50;
				break;
			case 1:
				text = " 我 们 的 特 勤 部 门 帮 助 新 民 主 党 解 决 了 党 内 问 题 ， 开 展 竞 选 活 动 ， 并 且 积 极 地 阻 碍 泛 希 腊 社 会 主 义 运 动 的 竞 选 活 动 。 新 民 主 党 成 功 赢 得 了 选 举 。 新 政 府 希 望 开 展 进 一 步 的 经 济 改 革 ， 意 在 确 保 希 腊 欧 共 体 成 员 的 资 格 ， 以 及 恢 复 该 国 在 北 约 中 的 活 动 。";
				GlobalScript.inst.gameState.data[6] -= 10;
				GlobalScript.inst.gameState.empires[0].relations += 80;
				GlobalScript.inst.gameState.empires[0].power += 20;
				GlobalScript.inst.gameState.allcountries[45].isEU = true;
				GlobalScript.inst.gameState.allcountries[45].Torg = true;
				GlobalScript.inst.gameState.allcountries[87].spec += 5;
				break;
			case 2:
				text = " 泛 希 腊 社 会 主 义 运 动 成 功 赢 得 了 大 选 ， 组 建 了 希 腊 历 史 上 第 一 个 社 会 主 义 政 府 。 帕 潘 德 里 欧 的 新 政 府 在 获 胜 后 推 出 了 几 项 有 趣 的 政 策 （ 民 事 婚 礼 合 法 化 、 新 的 家 庭 法 、 某 些 私 营 公 司 的 国 有 化 ， 承 认 民 族 抵 抗 运 动 和 本 都 希 腊 人 的 种 族 灭 绝 合 并 希 腊 宪 兵 队 和 城 市 警 察 为 单 一 警 察 机 构 等 ） 。 在 新 民 主 党 的 总 统 和 党 内 其 他 派 系 的 阻 挠 下 ， 希 腊 未 能 实 现 退 出 北 约 和 终 止 加 入 欧 共 体 。";
				GlobalScript.inst.gameState.empires[0].power += 20;
				GlobalScript.inst.gameState.allcountries[45].isEU = true;
				GlobalScript.inst.gameState.allcountries[45].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 3;
				break;
			}
		}
		else if (result_num == 0)
		{
			text = " 左 翼 联 合 政 府 赢 得 了 希 腊 大 选 。 希 腊 继 续 维 持 左 翼 联 盟 政 府 ， 并 在 外 交 中 继 续 保 持 中 立 。 希 腊 将 继 续 维 持 左 翼 多 党 霸 权 。 不 过 ， 这 种 泛 左 翼 的 联 合 政 府 究 竟 还 能 维 持 多 久 ？";
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations += 50;
			GlobalScript.inst.gameState.allcountries[45].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[45].Torg = true;
			GlobalScript.inst.gameState.allcountries[87].spec -= 5;
			GlobalScript.inst.gameState.empires[0].power -= 50;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
