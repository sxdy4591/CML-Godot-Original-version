using EventsForDLC;
using UnityEngine;

public class Event31 : EventsSecond
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
		name = " 民 主 重 归 韩 国";
		text = " 在 我 们 的 帮 助 下 ， 釜 马 起 义 和 光 州 起 义 狠 狠 地 打 击 了 韩 国 的 独 裁 体 系 ， 与 此 同 时 ， 美 国 政 府 也 同 样 对 全 斗 焕 政 府 表 达 了 不 满 并 威 胁 可 能 会 放 弃 对 全 的 支 持 。 在 中 美 两 国 的 施 压 下 ， 全 斗 焕 政 府 被 迫 进 行 民 主 化 ， 同 意 进 行 新 的 总 统 选 举 。\n 这 次 总 统 选 举 有 四 个 人 选 ： 金 大 中 ， 金 泳 三 ， 卢 泰 愚 和 安 必 洙 。 金 大 中 支 持 与 北 方 和 苏 东 集 团 和 解 ， 同 时 支 持 新 自 由 主 义 的 经 济 政 策 ； 金 泳 三 也 支 持 新 自 由 主 义 的 经 济 政 策 ， 但 反 对 与 苏 东 集 团 和 北 方 和 解 ； 卢 泰 愚 则 是 打 算 延 续 军 政 府 统 治 ， 但 是 会 缓 慢 的 民 主 化 ， 而 且 由 于 他 的 山 东 祖 籍 ， 可 能 会 和 我 们 缓 和 关 系 ； 而 安 必 洙 则 是 激 进 民 主 派 和 劳 工 运 动 分 子 共 同 推 举 出 来 的 新 人 选 ， 他 支 持 和 社 会 主 义 阵 营 和 解 ， 而 且 比 金 大 中 更 在 意 对 劳 工 待 遇 的 提 升 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		button_text[0] = " 不 要 干 预 民 主 化 进 程";
		if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 50)
		{
			button_text[1] = " 支 持 金 大 中";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 无 法 帮 助 他 们";
		}
		if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 30)
		{
			button_text[2] = " 支 持 金 泳 三";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 没 那 能 力 支 持";
		}
		if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 30 && GlobalScript.inst.gameState.data[56] != 0)
		{
			button_text[3] = " 支 持 卢 泰 愚";
		}
		else if (GlobalScript.inst.gameState.data[56] == 0)
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 不 能 支 持 军 政 府 独 裁 者";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 我 们 没 那 能 力 支 持";
		}
		if (GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= 80)
		{
			button_text[4] = " 支 持 安 必 洙";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 我 们 没 那 能 力 支 持";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 民 主 重 归 韩 国";
		switch (result_num)
		{
		case 0:
			text = " 卢 泰 愚 利 用 反 对 派 的 分 裂 在 第 一 次 自 由 选 举 中 获 胜 。 卢 泰 愚 是 旧 军 政 府 的 支 持 者 ， 但 在 全 斗 焕 的 支 持 率 下 降 时 ， 他 及 时 脱 离 了 旧 军 政 府 。";
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.allcountries[46].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[46].SubGosstroy = 6;
			break;
		case 1:
			text = " 在 我 们 的 支 持 下 ， 金 大 中 成 功 当 选 为 新 一 届 韩 国 总 统 ， 并 开 始 着 手 准 备 对 北 和 解 ， 朝 鲜 方 面 积 极 回 应 ， 两 边 开 始 了 漫 长 的 谈 判 ， 与 此 同 时 韩 国 也 开 始 放 弃 承 认 中 华 民 国 转 而 承 认 我 们 。 针 对 全 斗 焕 等 镇 压 民 主 人 士 的 军 队 高 层 的 审 判 已 经 开 始 ， 全 斗 焕 等 人 被 判 决 绞 死 。 通 过 实 施 新 自 由 主 义 的 经 济 政 策 和 对 中 国 的 贸 易 ， 韩 国 的 经 济 又 一 次 飞 涨 。 美 国 方 面 则 对 韩 国 的 民 主 化 表 达 了 祝 贺 。";
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.allcountries[46].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[46].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[46].SubGosstroy = 5;
			GlobalScript.inst.gameState.allcountries[46].Torg = true;
			break;
		case 2:
			text = " 在 我 们 的 支 持 下 ， 偏 保 守 的 金 泳 三 成 功 当 选 为 新 一 届 韩 国 总 统 ， 在 任 期 内 开 始 大 搞 新 自 由 主 义 ， 但 是 任 期 内 层 出 不 穷 的 大 事 故 导 致 他 的 支 持 率 暴 跌 。 针 对 全 斗 焕 等 镇 压 民 主 人 士 的 军 队 高 层 的 身 旁 已 经 开 始 ， 全 被 判 处 监 禁 2 5 年 并 罚 款 数 亿 韩 元 。 在 外 交 上 继 续 拒 绝 对 北 和 解 ， 由 于 我 们 对 他 的 支 持 ， 他 选 择 放 弃 承 认 中 华 民 国 转 而 承 认 我 们 。 美 国 则 对 韩 国 的 民 主 化 表 达 了 祝 贺 。";
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[6] -= 15;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.allcountries[46].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[46].SubGosstroy = 12;
			GlobalScript.inst.gameState.allcountries[46].Torg = true;
			break;
		case 3:
			text = " 在 我 们 的 支 持 下 ， 军 官 出 身 的 卢 泰 愚 顺 利 的 成 为 了 新 一 任 韩 国 总 统 ， 并 开 始 延 续 威 权 主 义 道 路 ， 为 表 达 感 谢 ， 卢 泰 愚 政 权 选 择 放 弃 承 认 中 华 民 国 转 而 承 认 我 们 。 但 与 此 同 时 ， 韩 国 国 内 的 反 对 派 势 力 依 旧 强 大 ， 很 有 可 能 会 在 下 一 届 大 选 中 赢 得 胜 利 。 而 美 国 仅 对 新 上 任 的 总 统 表 达 了 祝 贺 。";
			GlobalScript.inst.gameState.influencePRC += 5;
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.data[8] -= 30;
			GlobalScript.inst.gameState.allcountries[46].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[46].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[46].Torg = true;
			break;
		case 4:
			text = " 在 我 们 的 支 持 下 ， 社 会 党 总 裁 安 必 洙 出 人 意 料 的 赢 得 了 新 一 届 韩 国 选 举 。 大 选 之 后 ， 社 会 党 没 有 忘 记 承 诺 ， 开 始 与 朝 鲜 进 行 和 平 统 一 谈 判 ， 放 弃 中 华 民 国 ， 承 认 我 们 并 进 行 大 规 模 贸 易 ， 寻 求 社 会 党 国 际 的 支 持 ， 缓 和 与 苏 东 集 团 的 关 系 并 准 备 让 联 合 国 军 和 美 军 撤 出 半 岛 ； 对 内 则 开 始 实 行 劳 资 调 和 ， 部 分 保 障 劳 工 权 利 ， 平 反 内 战 时 期 的 南 方 游 击 队 和 各 左 派 镇 压 事 件 ， 全 斗 焕 等 人 的 审 判 业 已 结 束 ， 全 斗 焕 等 人 被 判 处 枪 决 。 韩 国 内 部 反 对 声 音 激 起 ， 并 严 重 怀 疑 新 总 统 是 朝 鲜 间 谍 。 而 美 国 则 仅 对 韩 国 实 现 民 主 化 表 达 了 祝 贺 。";
			GlobalScript.inst.gameState.empires[0].relations -= 100;
			GlobalScript.inst.gameState.influencePRC += 20;
			GlobalScript.inst.gameState.data[6] += 15;
			GlobalScript.inst.gameState.data[8] -= 80;
			GlobalScript.inst.gameState.allcountries[46].Vyshi = false;
			GlobalScript.inst.gameState.allcountries[46].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[46].SubGosstroy = 3;
			GlobalScript.inst.gameState.allcountries[46].Torg = true;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
