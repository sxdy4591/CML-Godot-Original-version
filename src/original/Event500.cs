using EventsForDLC;
using UnityEngine;

public class Event500 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 非 洲 的 新 生";
		text = " 随 着 社 会 主 义 者 在 几 内 亚 ， 加 纳 ， 马 里 等 国 站 稳 脚 跟 ， 一 个 深 藏 许 久 的 梦 想 开 始 浮 现 ： 泛 非 主 义 。 非 洲 长 久 以 来 一 直 是 殖 民 主 义 遗 毒 最 深 的 地 区 ， 帝 国 主 义 者 和 修 正 主 义 者 一 直 把 这 里 当 作 角 斗 场 ， 而 该 地 也 缺 少 强 而 有 力 的 地 区 性 强 国 管 辖 事 物 。 在 受 了 数 十 年 的 苦 难 后 ， 曾 经 的 奴 隶 终 于 翻 了 身 ， 做 了 主 人 。 如 今 ， 组 建 一 个 崭 新 的 非 洲 统 一 组 织 已 然 成 为 可 能 。 这 个 组 织 的 诞 生 将 会 狠 狠 的 打 击 美 国 和 苏 联 帝 国 主 义 者 的 影 响 力 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 觉 醒 的 人 民 必 将 胜 利 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 非 洲 的 新 生";
		if (result_num == 0)
		{
			text = " 我 们 大 力 推 动 了 非 洲 统 一 革 命 组 织 的 诞 生 。 几 内 亚 ， 加 纳 与 马 里 的 领 导 人 在 广 州 白 云 招 待 所 会 面 。 三 方 均 对 组 建 一 个 统 一 协 调 ， 从 而 促 成 非 洲 解 放 的 组 织 达 成 了 协 定 。 几 内 亚 劳 动 党 ， 人 民 革 命 党 和 苏 丹 民 主 联 盟 （ 马 里 旧 称 法 属 苏 丹 ） 宣 布 合 并 为 “ 全 非 人 民 革 命 党 ” ， 各 党 则 为 该 组 织 的 地 区 支 部 。 三 国 也 开 始 组 建 一 支 统 一 的 非 洲 人 民 革 命 军 ， 由 各 国 的 军 队 领 导 人 和 各 级 官 兵 组 成 统 一 的 革 命 军 事 委 员 会 统 一 行 动 。 该 组 织 的 目 的 则 是 “ 用 于 武 力 解 放 受 帝 国 主 义 压 迫 与 荼 毒 的 非 洲 兄 弟 ， 例 如 纳 米 比 亚 和 南 非 ” 。 很 快 ， 非 人 民 军 的 士 兵 就 出 现 在 了 西 南 非 洲 ， 依 托 控 制 力 较 弱 的 农 村 和 非 洲 民 族 主 义 ， 白 人 政 权 的 根 基 受 到 了 极 大 的 打 击 。 各 地 的 军 事 独 裁 政 权 也 越 发 难 以 控 制 边 疆 地 区 。 赤 潮 正 在 席 卷 着 黑 非 洲 ， 一 场 革 命 正 在 到 来 ， 帝 国 主 义 的 末 日 逼 近 了 ! 而 很 明 显 ， 我 们 的 同 志 并 不 孤 单 ， 坦 桑 尼 亚 ， 津 巴 布 韦 ";
			a.allcountries[122].econ = true;
			a.allcountries[122].okb = true;
			a.allcountries[127].econ = true;
			a.allcountries[127].okb = true;
			for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
			{
				if (((i > 53 && i < 69) || (i > 105 && i < 109) || i == 41 || i == 42 || i == 52 || i == 150) && i != 55 && i != 54 && a.allcountries[i].proprc && (a.allcountries[i].Gosstroy == 1 || a.allcountries[i].SubGosstroy == 0))
				{
					a.allcountries[i].econ = true;
					a.allcountries[i].okb = true;
					a.allcountries[i].africaOff = true;
				}
				if (((i > 53 && i < 69) || (i > 105 && i < 109) || i == 41 || i == 42 || i == 52 || i == 150) && i != 55 && i != 54 && i != 68 && i != 58 && i != 63 && a.allcountries[i].proprc && (a.allcountries[i].Gosstroy == 1 || a.allcountries[i].SubGosstroy == 0))
				{
					a.allcountries[i].econ = true;
					a.allcountries[i].okb = true;
					text += "， ";
					text += a.allcountries[i].name;
					text += " ";
				}
			}
			if (a.allcountries[99].parts[0] && a.allcountries[99].proprc && (a.allcountries[99].Gosstroy == 1 || a.allcountries[99].SubGosstroy == 0))
			{
				a.allcountries[99].econ = true;
				a.allcountries[99].okb = true;
				a.allcountries[99].africaOff = true;
				text += "， ";
				text += a.allcountries[99].name;
				text += " ";
			}
			if (a.allcountries[100].parts[0] && a.allcountries[100].proprc && (a.allcountries[100].Gosstroy == 1 || a.allcountries[100].SubGosstroy == 0))
			{
				a.allcountries[100].econ = true;
				a.allcountries[100].okb = true;
				a.allcountries[100].africaOff = true;
				text += "， ";
				text += a.allcountries[100].name;
				text += " ";
			}
			text += " 等 国 家 也 宣 布 投 身 于 非 洲 革 命 与 解 放 的 伟 大 事 业 中 。";
			a.data[8] -= 100;
			a.data[22] -= 100;
			a.empires[0].relations -= 100;
			a.empires[1].relations -= 100;
			a.empires[0].power -= 200;
			a.empires[1].power -= 200;
			if (GlobalScript.inst.gameState.modifies[59].active)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (GlobalScript.inst.gameState.allcountries[1].okb)
				{
					for (int j = 0; j < GlobalScript.inst.gameState.allcountries.Length; j++)
					{
						if (GlobalScript.inst.gameState.allcountries[j].okb)
						{
							num++;
							if (((j > 53 && j < 69) || (j > 105 && j < 109) || (j > 111 && j < 134) || j == 41 || j == 42 || j == 52 || j == 99 || j == 100 || j == 150) && j != 55 && j != 54 && j != 128 && GlobalScript.inst.gameState.allcountries[j].proprc && (GlobalScript.inst.gameState.allcountries[j].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[j].SubGosstroy == 0) && GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0)
							{
								num3++;
							}
						}
						if (GlobalScript.inst.gameState.allcountries[j].oar)
						{
							num2++;
						}
					}
					GlobalScript.inst.old_modify_desc[59] = string.Format("{0}{1}{2}", new object[3]
					{
						GlobalScript.inst.gameState.allcountries[1].okb ? (" 集 体 安 全 联 盟 ：|军 事 力 量+" + num * 3 / 10 + "." + Mathf.Abs(num * 3 % 10) + " ；特 工 网 络+" + num * 2 / 10 + "." + Mathf.Abs(num * 2 % 10) + " ；干 涉 点 数+" + num / 10 + "." + Mathf.Abs(num % 10)) : null,
						(GlobalScript.inst.gameState.event_done[500] && GlobalScript.inst.gameState.resultOfEvents[500] == 0) ? (" |非 洲 联 盟 : |军 事 力 量 +" + num3 * 3 / 10 + "." + Mathf.Abs(num3 * 3 % 10) + " ；特 工 网 络+" + num3 * 2 / 10 + "." + Mathf.Abs(num3 * 2 % 10) + " ；干 涉 点 数+" + num3 / 10 + "." + Mathf.Abs(num3 % 10)) : null,
						(!GlobalScript.inst.gameState.allcountries[30].oar) ? null : ((GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1) ? (" |阿 拉 伯 革 命 同 盟 :| 军 事 力 量 +" + num2 * 3 / 10 + "." + Mathf.Abs(num2 * 3 % 10) + " ；特 工 网 络+" + num2 * 2 / 10 + "." + Mathf.Abs(num2 * 2 % 10) + " ；干 涉 点 数+" + num2 / 10 + "." + Mathf.Abs(num2 % 10)) : (" |阿 拉 伯 联 合 共 和 国 :| 军 事 力 量 +" + num2 * 3 / 10 + "." + Mathf.Abs(num2 * 3 % 10) + " ；特 工 网 络+" + num2 * 2 / 10 + "." + Mathf.Abs(num2 * 2 % 10) + " ；干 涉 点 数+" + num2 / 10 + "." + Mathf.Abs(num2 % 10)))
					});
				}
			}
		}
		if (result_num == 1)
		{
			text = " 这 个 梦 想 还 是 太 疯 狂 了 ， 我 们 怎 么 也 做 不 到 ， 毕 竟 恩 克 鲁 玛 的 往 事 历 历 在 目 … …";
		}
	}
}
