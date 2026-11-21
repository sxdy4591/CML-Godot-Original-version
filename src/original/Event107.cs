using EventsForDLC;
using UnityEngine;

public class Event107 : EventsSecond
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
		name = " 盟 友 危 机";
		text = " 众 所 周 知 ， 我 们 的 集 团 是 最 民 主 、 最 平 等 的 … … 这 就 产 生 了 后 果 。 " + GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].name + " 最 近 一 直 在 奉 行 越 来 越 独 立 于 我 们 政 策 ， 想 进 行 一 些 改 革 的 不 忠 势 力 正 在 其 政 治 体 系 中 获 得 权 力 。";
		if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
		{
			text += " 但 更 糟 糕 的 是 他 们 与 美 国 和 西 方 的 外 交 调 情 ！ 如 果 这 种 情 况 继 续 下 去 ， 那 么 我 们 就 有 失 去 盟 友 的 危 险 ， 所 以 我 们 需 要 做 些 什 么 ， 但 是 怎 么 办 ？ 我 们 不 想 表 现 得 像 苏 联 修 正 主 义 者 在 捷 克 斯 洛 伐 克 做 的 那 样 。 或 者 … … ？";
		}
		else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance)
		{
			text += " 但 更 糟 糕 的 是 他 们 与 苏 联 的 外 交 调 情 ！ 如 果 这 种 情 况 继 续 下 去 ， 那 么 我 们 就 有 失 去 盟 友 的 危 险 ， 所 以 我 们 需 要 做 些 什 么 ， 但 是 怎 么 办 ？ 我 们 不 想 表 现 得 像 苏 联 修 正 主 义 者 在 捷 克 斯 洛 伐 克 做 的 那 样 。 或 者 … … ？";
		}
		else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
		{
			text += "|| 这 一 切 都 是 在 我 们 盟 国 政 府 即 将 宣 布 中 立 政 策 的 背 景 下 发 生 的 ， 这 意 味 着 一 件 事 ： 他 们 想 离 开 我 们 的 军 事 同 盟";
		}
		else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].econ)
		{
			text += "|| 而 这 一 切 发 生 的 背 景 是 ， 我 们 的 盟 友 政 府 正 狂 热 地 切 断 与 我 们 的 所 有 贸 易 关 系 ， 宣 布 调 整 其 经 济 方 向 ， 这 意 味 着 一 件 事 ： 他 们 想 离 开 我 们 的 经 济 联 盟 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (GlobalScript.inst.gameState.data[22] >= 200 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
		{
			button_text[0] = " 派 军 队 迫 使 该 国 回 到 我 们 的 路 线 上 （ 需 要 20 军 事 实 力 ， 需 要 3 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 的 军 队 没 有 足 够 的 力 量 和 权 威";
		}
		if (GlobalScript.inst.gameState.data[9] >= 100 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
		{
			button_text[1] = " 组 织 一 场 亲 中 派 政 变 （ 需 要 10 特 工 网 络 ， 需 要 3 百 万 预 算 ）";
		}
		else if (GlobalScript.inst.gameState.data[9] >= 200 && !GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
		{
			button_text[1] = " 组 织 一 场 亲 中 派 政 变 （ 需 要 20 特 工 网 络 ， 需 要 3 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
		}
		button_text[2] = " 在 经 济 上 约 束 该 国 ， 提 供 财 政 援 助 和 优 惠 贷 款 （ 需 要 10 百 万 预 算 ）";
		if (GlobalScript.inst.gameState.data[9] >= 50)
		{
			button_text[3] = " 不 要 妨 碍 独 立 的 政 治 ， 以 换 取 该 国 留 在 我 们 集 团 （ 需 要 5 特 工 网 络 ， 需 要 1 百 万 预 算 ）";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 的 情 报 机 构 对 此 无 能 为 力";
		}
		button_text[4] = " 我 们 必 须 尊 重 他 们 的 选 择";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 盟 友 危 机";
		switch (result_num)
		{
		case 0:
		{
			text = " 在 演 习 的 掩 护 下 ， 我 们 的 部 队 进 入 了 这 个 国 家 ， 迅 速 解 除 了 他 们 的 武 装 ， 逮 捕 了 政 府 并 镇 压 了 不 满 情 绪 。 新 政 府 得 到 了 财 政 援 助 以 巩 固 他 们 的 忠 诚 ，" + GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].name + " 。 再 次 回 到 我 们 身 边 ， 但 我 们 的 外 交 声 誉 仍 有 许 多 不 足 之 处 。";
			GlobalScript.inst.gameState.data[22] -= 200;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].soc_stab = 1000;
			Country[] allcountries = GlobalScript.inst.gameState.allcountries;
			foreach (Country country in allcountries)
			{
				if (country.okb || country.econ)
				{
					country.soc_stab -= 50;
				}
			}
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 150;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance = false;
				GlobalScript.inst.gameState.data[6] += 30;
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 150;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance = false;
				GlobalScript.inst.gameState.data[6] -= 30;
			}
			GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].proprc = true;
			break;
		}
		case 1:
			text = " 通 过 幕 后 阴 谋 、 秘 密 暗 杀 和 动 员 忠 于 我 们 的 政 客 和 军 队 ， 我 们 成 功 地 组 织 了 一 场 有 利 于 那 些 准 备 继 续 与 我 们 合 作 的 人 的 政 变 。 新 政 府 得 到 了 财 政 援 助 以 巩 固 忠 诚 。" + GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].name + " 再 次 与 我 们 同 在 ， 但 其 他 国 家 怀 疑 并 表 达 了 他 们 的 不 满";
			GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].soc_stab = 1000;
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
			{
				GlobalScript.inst.gameState.data[9] -= 100;
				GlobalScript.inst.gameState.data[8] -= 30;
			}
			else
			{
				GlobalScript.inst.gameState.data[9] -= 200;
				GlobalScript.inst.gameState.data[8] -= 60;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].proprc = true;
			}
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
			{
				GlobalScript.inst.gameState.empires[0].relations -= 100;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance = false;
				GlobalScript.inst.gameState.data[6] += 10;
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance)
			{
				GlobalScript.inst.gameState.empires[1].relations -= 100;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance = false;
				GlobalScript.inst.gameState.data[6] -= 10;
			}
			break;
		case 2:
			text = " 我 们 决 定 不 采 取 激 进 的 措 施 ， 而 是 安 抚 这 个 国 家 ， 同 时 在 经 济 上 把 它 与 我 们 联 系 在 一 起 。 这 有 助 于 迫 使 独 立 的 支 持 者 放 弃 草 率 的 计 划 ， 与 中 国 的 友 谊 支 持 者 获 得 了 额 外 的 力 量 。" + GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].name + " 再 次 与 我 们 在 一 起 ， 我 们 设 法 避 免 了 任 何 外 交 问 题 ， 但 只 是 独 立 的 支 持 者 没 有 消 失 。";
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].soc_stab = 1000;
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
			{
				if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 3)
				{
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].SubGosstroy = 15;
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 1)
			{
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].SubGosstroy = 15;
			}
			break;
		case 3:
			text = " 我 们 决 定 不 采 取 激 进 的 措 施 ， 而 只 要 求 该 国 领 导 人 保 证 在 我 们 集 团 的 成 员 资 格 ， 同 时 保 持 奉 行 独 立 外 交 政 策 的 能 力 。 经 过 长 时 间 的 谈 判 和 犹 豫 ， 他 们 终 于 同 意 了 。" + GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].name + " 仍 然 在 我 们 的 联 盟 中 ， 但 正 在 积 极 与 其 他 国 家 建 立 新 的 联 系 ， 这 可 能 在 未 来 会 适 得 其 反 。";
			GlobalScript.inst.gameState.influencePRC -= 10;
			_ = GlobalScript.inst.gameState.data[6];
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
			{
				GlobalScript.inst.gameState.empires[0].power += 30;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance = false;
				GlobalScript.inst.gameState.data[6] -= 30;
				GlobalScript.inst.gameState.empires[0].relations += 50;
				if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 3)
				{
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].SubGosstroy = 15;
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance)
			{
				GlobalScript.inst.gameState.empires[1].power += 30;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance = false;
				GlobalScript.inst.gameState.data[6] += 30;
				GlobalScript.inst.gameState.empires[1].relations += 50;
				if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 1)
				{
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].SubGosstroy = 15;
				}
			}
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].soc_stab = 500;
			break;
		case 4:
			text = " 结 果 ， 在 没 有 遭 到 我 方 任 何 抵 抗 的 情 况 下 ， 该 国 决 定 离 开 我 们 的 集 团 ， 并 已 在 建 立 新 的 与 别 国 的 联 系 。 至 少 比 社 会 帝 国 主 义 好!";
			GlobalScript.inst.gameState.influencePRC -= 20;
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].usalliance)
			{
				GlobalScript.inst.gameState.empires[0].power += 50;
				if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 3)
				{
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy = 3;
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].SubGosstroy = 12;
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].sovalliance)
			{
				GlobalScript.inst.gameState.empires[1].power += 50;
				if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 0 && GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy != 1)
				{
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].SubGosstroy = 1;
				}
			}
			GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].proprc = false;
			if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb)
			{
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].soc_stab = 1000;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].okb = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].econ)
			{
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].soc_stab = 0;
				GlobalScript.inst.gameState.allcountries[GlobalScript.inst.gameState.data[120]].econ = false;
			}
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
		GlobalScript.inst.gameState.data[120] = -1;
	}
}
