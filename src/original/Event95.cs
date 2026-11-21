using EventsForDLC;
using UnityEngine;

public class Event95 : EventsSecond
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
		name = " 中 国 共 产 党 的 新 开 始";
		text = " 因 此 ， 北 京 的 形 势 得 到 了 控 制 ， 国 家 的 权 力 移 交 给 了 以" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 为 首 的 中 国 共 产 党 内 的 自 由 派 。 议 事 日 程 上 的 问 题 是 大 规 模 深 化 “ 改 革 开 放 ” 政 策 以 及 向 西 式 民 主 和 自 由 市 场 的 过 渡 。 然 而 ， 我 们 现 在 不 得 不 考 虑 “ 退 党 ” 运 动 要 求 在 改 革 进 程 中 考 虑 到 使 中 国 社 会 和 执 政 党 去 共 产 主 义 化 的 必 要 性 。 原 则 上 ， 现 在 中 国 共 产 党 很 难 称 之 为 “ 共 产 党 ” ， 但 现 在 我 们 被 要 求 完 全 抛 弃 马 克 思 列 宁 主 义 。 那 么 ？ …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 我 们 拒 绝 马 克 思 主 义- 毛 泽 东 主 义- 邓 小 平 主 义 ， 效 仿 日 本 共 产 党 ， 改 为 支 持 欧 洲 共 产 主 义";
		button_text[1] = " 按 照 陈 独 秀 的 规 范 回 归 具 有 中 国 特 色 的 社 会 民 主 主 义";
		button_text[2] = " 接 受 伟 大 的 孙 中 山 遗 赠 的 中 国 左 翼 民 族 主 义";
		button_text[3] = " 为 什 么 我 们 必 须 接 受 一 些 街 头 恶 霸 的 要 求 ？";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 中 国 共 产 党 的 新 开 始";
		GlobalScript.inst.gameState.modifies[6].active = false;
		if (GlobalScript.inst.gameState.modifies[6].active)
		{
			GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
			GlobalScript.inst.gameState.doctr[8] = "人 民 民 主 制 度";
			GlobalScript.inst.gameState.doctr[9] = "协 和 民 主 体 制";
			GlobalScript.inst.gameState.doctr[10] = "经 典 计 划 经 济";
			GlobalScript.inst.gameState.doctr[11] = "中 式 计 划 经 济";
			GlobalScript.inst.gameState.doctr[13] = "国 家 监 护 资 本 主 义";
			GlobalScript.inst.gameState.doctr[14] = "社 会 主 义 导 向 市 场";
			GlobalScript.inst.gameState.doctr[15] = "左 翼 小 政 府";
			GlobalScript.inst.gameState.doctr[21] = "改 良 区 域 自 治 制 度";
			GlobalScript.inst.gameState.doctr[22] = "联 邦 制";
			GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
		}
		else
		{
			GlobalScript.inst.gameState.doctr[6] = " 一 党 制 共 和 国";
			GlobalScript.inst.gameState.doctr[7] = "一 党 独 大 式 民 主";
			GlobalScript.inst.gameState.doctr[8] = " 宪 政 民 主 制 度";
			GlobalScript.inst.gameState.doctr[9] = " 协 和 民 主 体 制";
			GlobalScript.inst.gameState.doctr[10] = " 中 央 计 划 经 济";
			GlobalScript.inst.gameState.doctr[11] = " 分 权 计 划 经 济";
			GlobalScript.inst.gameState.doctr[13] = " 鸟 笼 经 济";
			GlobalScript.inst.gameState.doctr[14] = " “ 社 会 ” 市 场 经 济";
			GlobalScript.inst.gameState.doctr[15] = " 最 小 干 预";
			GlobalScript.inst.gameState.doctr[21] = " 联 邦 制";
			GlobalScript.inst.gameState.doctr[22] = " 联 省 自 治";
			GlobalScript.inst.gameState.doctr[24] = " 破 除 传 统";
		}
		GlobalScript.inst.gameState.modifies[3].active = false;
		switch (result_num)
		{
		case 0:
		{
			text = " 在 中 共 中 央 特 别 全 会 上 ， 以 多 数 票 决 定 放 弃 马 克 思 列 宁 主 义 、 毛 泽 东 主 义 和 邓 小 平 主 义 ， 转 而 支 持 以 法 国 、 意 大 利 、 西 班 牙 和 日 本 共 产 党 为 代 表 的 现 代 欧 洲 共 产 主 义 。 对 党 的 纲 领 性 文 件 作 了 相 应 的 修 改 。 这 引 起 了 大 多 数 党 内 保 守 派 的 某 种 不 满 ， 但 总 的 来 说 ， 党 采 取 了 一 种 新 的 思 想 ， 认 识 到 了 变 革 的 必 要 性 。";
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[57] -= 50;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.data[14] = 3;
			GlobalScript.inst.gameState.data[16] = 13;
			GlobalScript.inst.gameState.data[15] = 8;
			GlobalScript.inst.gameState.data[17] = 18;
			if (GlobalScript.inst.gameState.data[6] > 699)
			{
				GlobalScript.inst.gameState.data[6] = 699;
			}
			GlobalScript.inst.gameState.allcountries[1].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[1].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2 != null)
				{
					if (politic2.traits[0] == 0)
					{
						politic2.loyality -= 400;
					}
					else if (politic2.traits[0] == 3)
					{
						politic2.loyality += 300;
					}
				}
			}
			break;
		}
		case 1:
		{
			text = " 在 中 共 中 央 特 别 全 会 上 ， 经 过 长 期 的 争 论 ， 最 终 决 定 回 到 陈 独 秀 、 张 国 焘 的 训 诫 上 来 ， 承 认 党 的 社 会 民 主 主 义 性 质 。 对 党 的 纲 领 性 文 件 作 了 相 应 的 修 改 。 这 导 致 了 部 分 保 守 派 党 阀 的 强 烈 不 满 ， 中 国 共 产 党 存 在 一 定 的 分 裂 危 险 。 时 间 会 告 诉 你 是 否 做 了 正 确 的 事 …";
			GlobalScript.inst.gameState.data[1] -= 300;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.data[57] -= 50;
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[6] -= 50;
			if (GlobalScript.inst.gameState.data[16] >= 13)
			{
				GlobalScript.inst.gameState.data[16] = 13;
			}
			if (GlobalScript.inst.gameState.data[16] < 12)
			{
				GlobalScript.inst.gameState.data[16] = 12;
			}
			if (GlobalScript.inst.gameState.data[6] < 500)
			{
				GlobalScript.inst.gameState.data[6] = 700;
			}
			if (GlobalScript.inst.gameState.data[14] < 4)
			{
				GlobalScript.inst.gameState.data[15] = 9;
				if (GlobalScript.inst.gameState.data[17] < 19)
				{
					GlobalScript.inst.gameState.data[17] = 19;
				}
				if (GlobalScript.inst.gameState.data[50] < 29)
				{
					GlobalScript.inst.gameState.data[50] = 28;
				}
				if (GlobalScript.inst.gameState.data[18] < 23)
				{
					GlobalScript.inst.gameState.data[18]++;
				}
				if (GlobalScript.inst.gameState.data[51] < 33)
				{
					GlobalScript.inst.gameState.data[51]++;
				}
				GlobalScript.inst.gameState.data[14] = 4;
			}
			GlobalScript.inst.gameState.allcountries[1].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[1].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3 != null)
				{
					if (politic3.traits[0] == 0)
					{
						politic3.loyality -= 500;
					}
					else if (politic3.traits[0] == 1)
					{
						politic3.loyality -= 300;
					}
					else if (politic3.traits[0] == 3)
					{
						politic3.loyality += 500;
					}
				}
			}
			break;
		}
		case 2:
		{
			text = " 在 中 共 中 央 特 别 全 会 上 ， 建 议 回 到 中 国 革 命 运 动 的 始 源 — — 孙 中 山 和 他 第 二 版 的 “ 三 民 主 义 ” （ 反 对 封 建 主 义 和 资 本 主 义 、 国 家 和 社 会 制 度 民 主 化 、 改 善 工 人 生 活 和 限 制 垄 断 资 本 ） 的 一 群 党 员 占 了 上 风 。 对 党 的 纲 领 性 文 件 作 了 相 应 的 修 改 。 中 国 共 产 党 开 始 与 民 革 和 左 翼 民 族 主 义 团 体 合 流 ， 虽 然 这 在 人 民 中 很 受 欢 迎 ， 但 也 引 起 了 党 员 的 强 烈 不 满 。";
			GlobalScript.inst.gameState.data[1] -= 250;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[4] -= 80;
			GlobalScript.inst.gameState.data[6] -= 10;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic != null)
				{
					if (politic.traits[0] == 0)
					{
						politic.loyality -= 400;
					}
					else if (politic.traits[0] == 1)
					{
						politic.loyality -= 100;
					}
					else if (politic.traits[0] == 2)
					{
						politic.loyality += 100;
					}
					else if (politic.traits[0] == 3)
					{
						politic.loyality += 400;
					}
				}
			}
			break;
		}
		case 3:
			text = " 在 中 共 中 央 特 别 全 会 上 ， 支 持 维 护 马 克 思 主 义 、 毛 泽 东 主 义 和 邓 小 平 主 义 的 人 士 取 得 了 胜 利 。 “ 退 党 ” 运 动 愈 演 愈 烈 ， 对 中 国 共 产 党 的 攻 击 也 愈 发 猛 烈 ， 党 已 经 失 去 了 人 民 群 众 的 支 持 ， 失 去 了 政 权 的 根 基 。 在 中 国 似 乎 没 有 它 的 立 足 之 地 了 … …";
			GlobalScript.inst.gameState.data[4] += 500;
			GlobalScript.inst.gameState.data[3] -= 500;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
