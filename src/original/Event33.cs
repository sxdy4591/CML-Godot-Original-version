using EventsForDLC;
using UnityEngine;

public class Event33 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 星 月 之 眼";
		text = " 佐 勒 菲 卡 尔 · 阿 里 · 布 托 自1971 年 担 任 巴 基 斯 坦 总 统 ， 自1973 年 来 担 任 总 理 ， 他 遵 循 伊 斯 兰 社 会 主 义 的 路 线 ， 这 在 广 泛 的 社 会 项 目 和 经 济 中 许 多 行 业 的 国 有 化 得 到 体 现 。 在 外 交 政 策 方 面 ， 他 坚 持 反 帝 国 主 义 ， 尝 试 与 邻 国 建 立 友 好 关 系 ， 脱 离 亲 美 的 东 南 亚 条 约 组 织 和 英 联 邦 ， 并 成 功 与 印 度 在 第 三 次 印 巴 战 争 后 缓 和 关 系 。 但 是 在 布 托 的 巴 基 斯 坦 人 民 党 赢 得1977 年3 月 的 大 选 后 ， 反 对 派 指 责 他 欺 诈 ， 并 开 始 抗 议 ， 遭 到 布 托 严 厉 的 镇 压 。 穆 罕 默 德 · 齐 亚 · 乌 尔 · 哈 克 领 导 的 军 队 不 喜 欢 此 事 ， 在 美 国 的 支 持 下 ， 他 在 准 备 军 事 政 变 。 通 过 阻 止 政 变 ， 提 供 布 托 建 设 社 会 主 义 的 物 质 协 助 ， 我 们 可 以 坚 实 地 确 保 我 们 在 巴 基 斯 坦 的 地 位 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 保 持 距 离";
		if (GlobalScript.inst.gameState.data[9] >= 60)
		{
			button_text[1] = " 帮 助 布 托";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 能 帮 助";
		}
		button_text[2] = " 放 任 事 态 发 展 并 和 新 政 府 建 立 外 交 关 系";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 星 月 之 眼";
		switch (result_num)
		{
		case 0:
			text = "7 月4 日 午 夜 时 分 ， 齐 亚- 乌 尔- 哈 克 将 军 命 令 拉 瓦 尔 品 第111 旅 包 围 所 有 主 要 的 联 邦 政 府 大 楼 、 警 察 局 和 国 民 议 会 。 在 那 之 后 ， 他 下 令 警 方 逮 捕 佐 勒 菲 卡 尔 · 布 托 、 巴 基 斯 坦 人 民 党 部 长 和 其 他 领 导 人 。 齐 亚 将 军 在 国 家 电 视 台 向 人 民 发 表 的 讲 话 中 说 ， 巴 基 斯 坦 国 民 议 会 和 各 省 议 会 已 经 解 散 ， 《 巴 基 斯 坦 宪 法 》 不 再 有 效 。 新 政 府 开 始 将 巴 基 斯 坦 伊 斯 兰 化 ， 并 回 归 亲 美 外 交 政 策 。";
			GlobalScript.inst.gameState.empires[0].power += 30;
			GlobalScript.inst.gameState.data[4] += 30;
			GlobalScript.inst.gameState.allcountries[31].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[31].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[31].Vyshi = true;
			GlobalScript.inst.gameState.allcountries[31].proprc = false;
			GlobalScript.inst.gameState.allcountries[31].Torg = false;
			break;
		case 1:
			text = " 由 于 我 们 的 警 告 ， 布 托 设 法 躲 开 叛 军 ， 并 组 织 了 忠 诚 的 部 队 对 付 他 们 ， 他 们 在 抵 达 的 国 安 部 特 勤 部 队 的 帮 助 下 阻 止 叛 军 ， 并 抓 获 了 政 变 领 导 人 。 齐 亚- 乌 尔- 哈 克 将 军 因 叛 国 罪 被 处 决 ， 由 于 我 们 的 物 质 援 助 和 在 打 击 抗 议 者 方 面 的 帮 助 ， 巴 基 斯 坦 的 局 势 得 以 正 常 化 。 布 托 继 续 建 设 伊 斯 兰 社 会 主 义 ， 在 经 济 中 引 入 了 越 来 越 多 的 社 会 主 义 方 法 。 与 印 度 的 关 系 也 略 有 升 温 。";
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[9] -= 60;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.allcountries[31].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[31].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[31].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[31].proprc = true;
			GlobalScript.inst.gameState.allcountries[31].prcpower = 1000;
			GlobalScript.inst.gameState.party_ideology[4] -= (int)((float)GlobalScript.inst.gameState.party_ideology[4] * 0.25f);
			break;
		case 2:
			text = "7 月4 日 午 夜 左 右 ， 齐 亚- 乌 尔- 哈 克 将 军 命 令 第111 旅 从 拉 瓦 尔 品 第 包 围 所 有 主 要 联 邦 政 府 大 楼 、 警 察 局 和 国 民 议 会 。 在 那 之 后 ， 他 命 令 警 方 逮 捕 扎 尔 菲 卡 · 布 托 、 巴 基 斯 坦 人 民 党 的 部 长 和 其 他 领 导 人 。 齐 亚 将 军 在 国 家 电 视 台 向 人 民 发 表 的 讲 话 中 表 示 ， 巴 基 斯 坦 国 民 议 会 和 各 省 级 议 会 解 散 ， 巴 基 斯 坦 宪 法 也 不 再 有 效 。 新 政 府 朝 着 巴 基 斯 坦 的 伊 斯 兰 化 方 向 前 进 ， 并 返 回 亲 美 外 交 政 策 ， 这 并 不 妨 碍 我 们 与 巴 基 斯 坦 保 持 密 切 互 利 的 关 系 。";
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.allcountries[31].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[31].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[31].Vyshi = true;
			GlobalScript.inst.gameState.allcountries[31].proprc = false;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
