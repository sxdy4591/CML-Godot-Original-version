using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event25 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public bool load_scene_after_click;

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
		name = " 四 人 帮";
		text = "在 全 国 人 民 的 悲 痛 中 ， 我 们 伟 大 的 领 袖 毛 泽 东 主 席 去 世 了 。 一 切 似 乎 如 他 临 终 前 对 未 来 的 悲 观 判 断 一 样 ， 为 了 争 夺 舵 手 的 政 治 遗 产 ， 中 国 共 产 党 内 又 爆 发 了 激 烈 的 党 内 斗 争 。||一 方 面 ， 长 期 以 来 有 四 位 支 持 文 革 路 线 的 党 内 成 员 主 张 继 续 进 行 文 化 大 革 命 。 他 们 分 别 是 江 青 ， 王 洪 文 ， 张 春 桥 与 姚 文 元 。 江 青 是 毛 泽 东 主 席 的 妻 子 和 前 中 央 文 革 小 组 的 领 导 ， 她 实 际 领 导 了 这 十 年 以 来 的 文 艺 工 作 并 由 此 赢 得 了 不 少 威 望 ； 王 洪 文 是 自 文 革 后 一 路 晋 升 的 年 轻 领 导 人 ， 在 第 十 次 党 代 会 后 ， 他 当 选 为 中 央 委 员 会 副 主 席 ， 并 被 一 度 认 为 是 毛 泽 东 的 接 班 人 ； 此 外 还 有 为 文 革 提 供 大 量 理 论 依 据 与 宣 传 工 作 的 张 春 桥 和 姚 文 元 ， 他 们 在 运 动 中 也 参 加 了 大 量 的 “ 夺 权 ” 活 动 。||另 一 方 面 ， 在 上 世 纪 7 0 年 代 初 实 行 经 济 整 顿 而 遭 贬 谪 的 前 副 总 理 邓 小 平 为 代 表 的 改 革 派 力 量 正 在 壮 大 ， 他 们 希 望 尽 早 结 束 文 化 大 革 命 的 混 乱 ， 并 扭 转 长 期 以 来 的 经 济 方 针 ， 进 行 政 治 解 冻 和 经 济 改 革 且 与 西 方 国 家 采 取 保 持 良 好 关 系 。||虽 然 毛 主 席 逝 世 了 ， 但 极 左 派 目 前 依 然 在 中 央 把 握 重 要 权 力 。 以 叶 剑 英 ， 李 先 念 ， 邓 小 平 为 代 表 老 干 部 集 团 则 对 极 左 派 不 满 ， 传 闻 他 们 在 厉 兵 秣 马 ， 准 备 用 军 队 夺 权 。 而 有 关 地 方 造 反 派 工 人 民 兵 正 在 派 发 枪 支 的 传 闻 也 不 断 出 现 。 我 国 的 政 治 局 势 已 经 到 了 无 比 危 急 的 关 头 ， 对 江 姚 王 张 四 人 作 何 处 理 将 会 是 决 定 未 来 命 运 的 关 键 抉 择 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 一 个 也 别 想 跑 ！";
		button_text[1] = " 抓 捕 江 青 和 王 洪 文 并 和 其 他 左 派 达 成 妥 协";
		button_text[2] = " 只 要 按 既 定 方 针 办 … …";
		button_text[3] = " 不 要 干 预 党 内 路 线 斗 争";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 四 人 帮";
		switch (result_num)
		{
		case 0:
		{
			text = "最 终 华 国 锋 对 于 极 左 势 力 夺 权 的 焦 虑 还 是 占 了 上 风 。 在 他 的 授 意 下 ，8341 部 队 的 团 长 汪 东 兴 与 国 防 部 长 叶 剑 英 进 行 了 接 洽 。 华 国 锋 召 开 了 政 治 局 特 别 会 议 ， 在 会 期 间 命 令 首 都 军 队 逮 捕 了 四 位 极 左 派 领 导 人 。 在 此 之 后 ， 一 波 对 忠 心 于 他 们 的 官 员 的 逮 捕 浪 潮 席 卷 了 北 京 ， 上 海 市 区 曾 武 装 起 来 的 工 人 民 兵 迫 于 压 力 终 究 还 是 未 发 一 弹 的 缴 了 枪 。 宣 传 机 关 开 始 开 动 机 器 宣 传 “ 四 人 帮 ” （ 包 括 江 青 、 王 洪 文 、 张 春 桥 ， 姚 文 元 ） 试 图 夺 取 党 和 国 家 最 高 领 导 权 及 迫 害 毛 主 席 的 罪 行 ， 但 最 终 反 革 命 阴 谋 被 粉 碎 。 同 大 多 数 党 员 一 样 ， 在 盛 大 的 庆 祝 仪 式 后 ， 人 民 群 众 接 受 了 他 们 的 倒 台 ， 随 着 极 左 派 的 喑 声 ， 看 起 来 长 达 十 年 之 久 的 文 化 大 革 命 就 要 结 束 了 。";
			GlobalScript.inst.gameState.data[3] += 100;
			GlobalScript.inst.gameState.data[4] += 70;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.data[84] = 1;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality -= 50;
				}
				else if (politic2.traits[0] == 2)
				{
					politic2.loyality += 50;
				}
				else if (politic2.traits[0] == 1)
				{
					politic2.loyality += 50;
				}
			}
			party_change[1] = 2.5f;
			party_change[2] = 1.5f;
			party_change[3] = 1.5f;
			GlobalScript.inst.gameState.KillPerson(0);
			GlobalScript.inst.gameState.KillPerson(1);
			GlobalScript.inst.gameState.KillPerson(2);
			GlobalScript.inst.gameState.KillPerson(3);
			GlobalScript.inst.gameState.KillPerson(4);
			GlobalScript.inst.gameState.KillPerson(17);
			GlobalScript.inst.gameState.politics[6].power += 100;
			GlobalScript.inst.gameState.politics[7].power += 100;
			break;
		}
		case 1:
		{
			text = "纵 使 情 况 危 急 ， 华 国 锋 也 不 愿 冒 太 大 的 险 ， 综 合 考 虑 后 他 决 定 只 在 政 治 局 特 别 会 议 上 逮 捕 对 当 局 构 成 最 大 威 胁 的 江 青 和 王 洪 文 。 在 一 个 平 静 的 夜 晚 ， 汪 东 兴 率 领 8 3 4 1 部 队 的 战 士 们 不 费 吹 灰 之 力 的 逮 捕 了 江 青 王 洪 文 二 人 。 与 此 同 时 ， 华 国 锋 向 姚 文 元 和 张 春 桥 等 极 左 派 团 体 中 较 次 要 的 成 员 许 诺 以 与 江 青 王 洪 文 切 割 关 系 和 对 现 任 中 央 班 子 的 忠 诚 为 代 价 换 取 在 政 府 中 的 一 席 之 地 ， 他 们 最 终 也 无 一 不 屈 服 了 。 经 过 此 事 ， 左 派 的 地 位 受 到 了 削 弱 ， 不 过 他 们 现 在 虽 不 能 夺 取 政 权 ， 但 依 然 具 有 自 己 的 影 响 力 。 此 外 ， 宣 传 机 关 开 始 批 判 江 青 和 王 洪 文 在 文 革 期 间 大 量 迫 害 老 干 部 和 阴 谋 夺 取 政 权 的 反 革 命 行 径 ， 总 的 来 说 ， 他 们 的 失 败 令 大 多 数 党 员 都 松 了 一 口 气 ， 局 势 也 得 以 缓 解 ， 尽 管 许 多 人 对 一 些 激 进 分 子 仍 然 掌 权 感 到 紧 张 ， 认 为 所 谓 的 阴 谋 者 只 是 “ 替 罪 羊 ” 罢 了 ， 文 革 的 结 局 与 这 个 国 家 的 命 运 仍 然 不 甚 晴 朗 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[84] = 2;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality -= 20;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.loyality += 50;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality += 70;
				}
			}
			party_change[1] = 2f;
			party_change[2] = 1f;
			party_change[3] = 1f;
			GlobalScript.inst.gameState.KillPerson(1);
			GlobalScript.inst.gameState.KillPerson(2);
			GlobalScript.inst.gameState.politics[6].power += 100;
			GlobalScript.inst.gameState.politics[7].power += 100;
			if (GlobalScript.inst.gameState.politics_dolshnost[2] < 50)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[2]].loyality -= 200;
			}
			GlobalScript.inst.gameState.politics_dolshnost[2] = 3;
			break;
		}
		case 2:
		{
			text = " 对 于 改 革 派 在 军 中 势 力 的 强 大 与 可 能 到 来 的 国 内 制 度 更 迭 的 恐 惧 最 终 压 倒 了 华 国 锋 。 以 江 青 等 人 为 代 表 的 极 左 派 有 着 天 然 的 反 改 革 派 立 场 ， 因 此 ， 华 国 锋 决 定 与 他 们 合 作 。 在 毛 泽 东 主 席 的 侄 子 ， 毛 远 新 同 志 的 牵 线 搭 桥 下 ， 江 姚 王 张 集 团 同 意 协 助 华 国 锋 一 同 对 抗 改 革 派 。 此 后 ， 宣 传 口 对 外 宣 布 未 来 党 的 路 线 是 “   紧 密 团 结 在 以 华 国 锋 同 志 为 主 席 的 党 中 央 周 围 ， 坚 持 ‘ 按 既 定 方 针 办 ’ ， 坚 持 以 阶 级 斗 争 为 纲 ， 坚 持 斗 私 批 修 ， 坚 持 无 产 阶 级 专 政 下 的 继 续 革 命 ， 把 伟 大 的 无 产 阶 级 文 化 大 革 命 进 行 到 底 。 ” 极 左 派 也 决 定 在 首 都 重 新 组 织 一 场 规 模 浩 大 的 造 反 派 串 联 活 动 以 配 合 华 国 锋 进 行 政 治 施 压 ， 向 改 革 派 发 出 警 告 ， 终 于 在 各 方 面 的 施 压 下 ， 叶 剑 英 元 帅 与 他 的 同 志 们 暂 时 平 息 了 内 心 的 躁 动 ， 改 革 派 对 极 左 派 的 行 动 被 推 迟 了 ， 紧 张 的 政 治 空 气 也 得 以 暂 时 缓 解 。 然 而 ， 大 部 分 党 员 对 这 种 诡 异 的 僵 持 局 面 并 不 满 意 ， 极 左 派 正 在 尝 试 迅 速 积 攒 自 己 的 力 量 ， 愤 怒 的 改 革 派 们 也 似 乎 并 不 打 算 放 弃 他 们 原 本 的 目 标 ， 华 国 锋 也 不 得 不 重 新 权 衡 利 弊 。 这 无 一 不 预 示 着 中 国 领 导 层 对 于 毛 泽 东 遗 产 的 争 夺 战 仍 在 继 续 … …";
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 250;
			GlobalScript.inst.gameState.data[84] = 3;
			GlobalScript.inst.gameState.data[6] += 50;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic != null)
				{
					if (politic.traits[0] == 0)
					{
						politic.loyality += 200;
					}
					if (politic.traits[0] == 20)
					{
						politic.loyality += 100;
					}
					else if (politic.traits[0] < 3)
					{
						politic.loyality -= 100;
					}
				}
			}
			party_change[0] = 2.5f;
			party_change[1] = 1.5f;
			GlobalScript.inst.gameState.party_ideology[3] -= (int)((float)GlobalScript.inst.gameState.party_ideology[3] * 0.1f);
			GlobalScript.inst.gameState.politics[7].power -= 100;
			GlobalScript.inst.gameState.politics[12].power -= 100;
			GlobalScript.inst.gameState.politics[9].power += 100;
			if (GlobalScript.inst.gameState.politics_dolshnost[1] < 50)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].loyality -= 200;
			}
			GlobalScript.inst.gameState.politics_dolshnost[1] = 150;
			break;
		}
		case 3:
			text = " 好 吧 …";
			load_scene_after_click = true;
			break;
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 2;
			SceneManager.LoadScene("Ending");
		}
	}
}
