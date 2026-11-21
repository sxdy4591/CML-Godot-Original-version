using EventsForDLC;
using UnityEngine;

public class Event115 : EventsSecond
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
		name = " 金 三 角";
		text = " 主 席 同 志 ， 正 如 我 们 的 情 报 部 门 所 知 ， 在 缅 甸 、 老 挝 和 泰 国 等 最 近 成 为 我 们 势 力 范 围 的 山 区 ， 有 一 个 庞 大 的 网 络 参 与 毒 品 的 生 产 和 销 售 ， 称 为 “ 金 三 角 ” 。 这 个 网 络 非 常 有 利 于 这 些 国 家 和 周 边 国 家 的 腐 败 ， 而 且 它 还 由 一 位 著 名 的 掸 族 成 员 领 导 ， 他 主 张 掸 族 与 缅 甸 分 离 。 考 虑 到 这 一 切 ， 部 分 党 员 和 将 军 提 出 协 助 这 些 国 家 对 毒 品 贩 子 进 行 调 查 和 军 事 行 动 。 然 而, 有 另 一 组 人 声 称 ， 在 多 年 的 内 战 中 掸 族 一 直 未 能 实 现 独 立 于 缅 甸 的 梦 想 ， 也 不 太 可 能 成 功 。 但 是 他 们 与 引 人 注 目 的 一 个 毒 贩 集 团 有 联 系 ， 这 些 毒 品 主 要 销 往 西 方 国 家 。 在 这 方 面 ， 他 们 提 出 帮 助 金 三 角 组 织 保 护 和 销 售 商 品 ， 这 将 帮 助 我 们 得 到 资 金 ， 破 坏 西 方 国 家 的 生 活 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 这 不 是 我 们 的 事 务";
		if ((GlobalScript.inst.gameState.data[56] >= 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
		{
			button_text[1] = " 与 毒 贩 达 成 协 议 （-1 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 中 国 人 民 打 击 毒 贩 子 可 不 是 为 了 让 我 们 与 他 们 眉 来 眼 去 的";
		}
		button_text[2] = " 帮 助 盟 国 打 击 毒 品 贩 子 （-2 特 工 网 络 ，-2 军 事 力 量 ）";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 金 三 角";
		switch (result_num)
		{
		case 0:
			text = " 一 切 顺 其 自 然 。";
			break;
		case 1:
		{
			text = " 尽 管 有 原 则 的 党 员 在 得 知 这 项 协 议 后 提 出 抗 议 ， 我 们 仍 然 能 够 与 坤 沙 合 作 ， 坤 沙 认 为 最 好 不 要 拒 绝 这 种 帮 助 。 现 在 ， 国 安 部 特 工 和 解 放 军 人 员 参 与 保 护 鸦 片 工 业 ， 并 帮 助 向 西 方 走 私 毒 品 ， 在 我 们 的 坚 持 下 ， 绝 大 多 数 “ 货 物 ” 现 在 都 到 了 西 方 。 西 方 国 家 海 洛 因 销 售 的 激 增 并 没 有 严 重 地 影 响 其 经 济 和 人 民 的 健 康 ， 这 需 要 这 些 国 家 的 警 察 付 出 更 多 的 努 力 ， 并 需 要 更 多 的 预 算 资 金 。 掸 族 分 裂 分 子 对 缅 甸 政 府 军 发 动 了 新 的 进 攻 ， 虽 然 没 有 取 得 多 大 的 胜 利 。 由 于 我 们 严 守 秘 密 ， 并 没 有 留 下 可 以 用 于 公 开 指 责 我 们 的 材 料 ， 但 是 缅 甸 当 局 仍 然 猜 测 并 减 少 两 国 的 贸 易 往 来 ， 我 们 的 一 些 地 方 官 员 和 有 关 官 员 也 决 定 加 入 这 一 有 利 可 图 的 生 意 。 希 望 我 们 的 利 润 能 弥 补 这 个 损 失 。";
			GlobalScript.inst.gameState.data[8] += 70;
			GlobalScript.inst.gameState.data[9] -= 10;
			GlobalScript.inst.gameState.data[26] += 40;
			GlobalScript.inst.gameState.data[1] -= 150;
			GlobalScript.inst.gameState.empires[1].power -= 10;
			GlobalScript.inst.gameState.allcountries[33].Torg = true;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality -= 100;
				}
			}
			break;
		}
		case 2:
			text = " 在 我 们 中 华 人 民 共 和 国 、 老 挝 、 缅 甸 和 泰 国 代 表 出 席 的 会 议 上 ， 通 过 了 一 项 联 合 打 击 东 南 亚 有 组 织 犯 罪 的 方 案 。 中 国 国 安 部 的 工 作 人 员 与 这 些 国 家 的 执 法 机 构 进 行 了 多 次 调 查 ， 揭 露 了 毒 贩 与 政 府 官 员 的 众 多 联 系 ， 并 揭 露 了 一 些 销 售 渠 道 。 这 也 使 得 更 准 确 地 确 定 辛 迪 加 中 心 的 位 置 变 为 可 能 ， 并 在 盟 国 军 队 和 解 放 军 的 帮 助 下 进 行 了 几 次 成 功 的 突 袭 。 当 然 ， 金 三 角 的 毒 贩 还 远 未 被 完 全 击 败 ， 但 这 些 措 施 严 重 的 破 坏 了 毒 品 的 生 产 与 交 易 ， 让 我 们 的 合 作 伙 伴 更 轻 松 了 ， 他 们 真 诚 地 感 谢 我 们 ， 让 缅 甸 最 放 心 的 是 掸 族 分 裂 主 义 的 衰 落 ， 最 后 他 们 确 立 了 亲 中 方 向 的 外 交 政 策 。";
			GlobalScript.inst.gameState.data[9] -= 20;
			GlobalScript.inst.gameState.data[22] -= 20;
			GlobalScript.inst.gameState.data[26] -= 20;
			GlobalScript.inst.gameState.allcountries[33].Torg = true;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
