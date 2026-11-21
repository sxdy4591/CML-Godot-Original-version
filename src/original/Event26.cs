using EventsForDLC;
using UnityEngine;

public class Event26 : EventsSecond
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
		name = " 脆 弱 的 平 衡 ？";
		text = " 几 周 以 来 ， 华 国 锋 通 过 与 极 左 派 的 合 作 ， 暂 时 稳 定 住 了 国 内 的 政 治 稳 定 ， 但 是 在 表 面 尴 尬 的 平 静 之 下 ， 持 不 同 观 点 的 各 派 系 依 然 暗 流 涌 动 。 有 消 息 称 ， 国 防 部 长 叶 剑 英 与 其 他 的 改 革 派 成 员 已 经 对 僵 持 的 局 面 忍 无 可 忍 ， 随 时 准 备 绕 过 华 国 锋 中 央 直 接 对 极 左 派 采 取 行 动 ； 极 左 派 也 敏 锐 的 捕 捉 到 了 气 氛 的 变 化 ， 他 们 并 不 想 止 步 于 华 国 锋 的 庇 护 ， 极 左 派 的 领 导 班 子 已 经 在 通 过 各 种 渠 道 联 系 地 方 的 造 反 派 团 体 ， 并 尝 试 扩 大 民 兵 武 装 ， 声 称 要 “ 誓 死 捍 卫 毛 主 席 的 革 命 遗 产 ” 。 原 本 有 所 缓 和 的 政 治 气 氛 再 次 急 转 直 下 。 但 目 前 华 国 锋 仍 手 握 大 量 政 治 筹 码 ， 若 他 有 心 维 护 中 国 的 稳 定 ， 就 必 须 站 队 其 中 的 一 方 ， 华 国 锋 可 以 选 择 延 续 与 极 左 派 的 盟 约 ， 公 开 支 持 极 左 领 导 集 团 与 各 地 造 反 派 的 活 动 ， 甚 至 借 机 将 叶 剑 英 ， 李 先 念 等 改 革 派 的 激 进 分 子 赶 下 台 ； 当 然 ， 华 国 锋 也 可 以 从 此 背 叛 极 左 阵 营 ， 支 持 叶 剑 英 元 帅 对 极 左 派 中 央 （ 包 括 江 青 、 王 洪 文 、 张 春 桥 与 姚 文 元 ） 的 行 动 ， 彻 底 结 束 文 化 大 革 命 。 但 无 论 华 国 锋 最 终 作 何 选 择 ， 他 都 要 面 临 其 中 一 个 派 系 的 膨 胀 ， 这 甚 至 可 能 导 致 他 自 己 权 力 的 架 空 … … 或 者 ， 他 能 向 全 国 人 民 证 明 自 己 的 能 力 与 价 值 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[9] >= 70)
		{
			button_text[0] = " 一 个 也 别 想 跑 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 你 无 力 改 变 现 状";
		}
		if (GlobalScript.inst.gameState.data[9] >= 50)
		{
			button_text[1] = " 只 逮 捕 王 洪 文 和 江 青";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 你 无 力 改 变 现 状";
		}
		button_text[2] = " 继 续 按 既 定 方 针 办";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 脆 弱 的 平 衡 ？";
		switch (result_num)
		{
		case 0:
		{
			text = " 最 终 华 国 锋 还 是 无 法 忍 受 与 极 左 派 共 舞 。 在 他 的 授 意 下 ，8341 部 队 的 团 长 汪 东 兴 与 国 防 部 长 叶 剑 英 进 行 了 接 洽 ， 叶 剑 英 虽 对 华 国 锋 的 突 然 变 卦 感 到 诧 异 ， 但 还 是 欣 然 接 受 了 。 之 后 华 国 锋 召 开 了 政 治 局 特 别 会 议 ， 在 会 期 间 命 令 首 都 军 队 逮 捕 了 四 位 极 左 派 领 导 人 。 在 此 之 后 ， 一 波 对 忠 心 于 他 们 的 官 员 的 逮 捕 浪 潮 席 卷 了 各 大 城 市 ， 由 于 极 左 派 在 许 多 地 区 组 织 其 了 相 当 规 模 的 民 兵 武 装 ， 军 队 在 行 动 时 遭 遇 了 抵 抗 ， 虽 然 大 部 分 民 兵 是 临 时 拉 起 的 草 台 班 子 ， 稍 作 抵 抗 便 宣 布 投 降 ， 但 在 上 海 等 造 反 派 扎 根 已 久 的 地 区 ， 军 队 遭 遇 了 极 端 烈 度 的 抵 抗 ， 在 经 过 几 天 的 镇 压 与 付 出 惨 重 伤 亡 后 ， 极 左 民 兵 最 终 还 是 停 止 了 抵 抗 。 行 动 过 后 ， 宣 传 机 关 开 始 开 动 机 器 宣 传 “ 四 人 帮 ” （ 包 括 江 青 、 王 洪 文 、 张 春 桥 ， 姚 文 元 ） 试 图 夺 取 党 和 国 家 最 高 领 导 权 及 迫 害 毛 主 席 的 罪 行 ， 但 最 终 反 革 命 阴 谋 被 粉 碎 。 同 大 多 数 党 员 一 样 ， 在 盛 大 的 庆 祝 仪 式 后 ， 大 部 分 人 民 群 众 勉 强 接 受 了 他 们 的 倒 台 ， 随 着 极 左 派 的 喑 声 ， 看 起 来 长 达 十 年 之 久 的 文 化 大 革 命 就 要 结 束 了 。";
			GlobalScript.inst.gameState.data[3] += 40;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[6] -= 30;
			GlobalScript.inst.gameState.data[9] -= 70;
			GlobalScript.inst.gameState.data[84] = 1;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality -= 100;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.loyality += 50;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality += 50;
				}
			}
			party_change[1] = 2.5f;
			party_change[2] = 1.5f;
			party_change[3] = 1.5f;
			GlobalScript.inst.gameState.KillPerson(1);
			GlobalScript.inst.gameState.KillPerson(2);
			GlobalScript.inst.gameState.KillPerson(3);
			GlobalScript.inst.gameState.KillPerson(4);
			GlobalScript.inst.gameState.politics[6].power += 100;
			GlobalScript.inst.gameState.politics[5].power += 400;
			GlobalScript.inst.gameState.politics[7].power += 100;
			break;
		}
		case 1:
		{
			text = " 华 国 锋 不 愿 与 极 左 派 有 太 深 入 的 合 作 ， 但 也 不 愿 冒 着 中 国 稳 定 崩 溃 的 风 险 对 极 左 派 进 行 大 规 模 活 动 。 综 合 考 虑 后 他 决 定 只 在 政 治 局 特 别 会 议 上 逮 捕 对 当 局 构 成 最 大 威 胁 的 江 青 和 王 洪 文 。 在 一 个 平 静 的 夜 晚 ， 汪 东 兴 率 领 8 3 4 1 部 队 的 战 士 们 秘 密 逮 捕 了 江 青 王 洪 文 二 人 。 与 此 同 时 ， 华 国 锋 向 姚 文 元 和 张 春 桥 等 极 左 派 团 体 中 较 次 要 的 成 员 许 诺 以 与 江 青 王 洪 文 切 割 关 系 ， 叫 停 和 限 制 地 方 造 反 派 活 动 为 代 价 换 取 在 政 府 职 位 的 保 留 与 部 分 提 拔 ， 他 们 最 终 也 无 一 不 屈 服 了 。 经 过 此 事 ， 左 派 的 力 量 受 到 了 削 弱 ， 但 依 然 具 有 影 响 中 央 的 能 力 。 此 外 ， 宣 传 机 关 开 始 批 判 江 青 和 王 洪 文 在 文 革 期 间 大 量 迫 害 老 干 部 和 阴 谋 夺 取 政 权 的 反 革 命 行 径 ， 总 的 来 说 ， 他 们 的 失 败 令 大 多 数 党 员 都 松 了 一 口 气 ， 局 势 也 得 以 大 大 缓 解 ， 尽 管 许 多 人 对 一 些 激 进 分 子 仍 然 掌 权 感 到 紧 张 ， 但 至 少 改 革 派 已 经 承 诺 不 进 行 “ 过 度 ” 的 打 击 行 动 。 至 此 ， 中 国 还 将 在 命 运 的 十 字 路 口 徘 徊 一 段 时 间 … …";
			GlobalScript.inst.gameState.data[1] += 20;
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] -= 10;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.data[84] = 2;
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
			party_change[1] = 2f;
			party_change[2] = 1f;
			party_change[3] = 1f;
			GlobalScript.inst.gameState.KillPerson(1);
			GlobalScript.inst.gameState.KillPerson(2);
			GlobalScript.inst.gameState.politics[3].power += 100;
			GlobalScript.inst.gameState.politics[4].power += 100;
			if (GlobalScript.inst.gameState.politics_dolshnost[2] < 100)
			{
				GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[2]].loyality -= 200;
			}
			GlobalScript.inst.gameState.politics_dolshnost[2] = 3;
			break;
		}
		case 2:
		{
			text = " 木 已 成 舟 ， 华 国 锋 在 不 敢 背 离 毛 泽 东 主 席 路 线 的 同 时 ， 更 忌 惮 改 革 派 日 渐 膨 胀 的 野 心 。 华 国 锋 将 叶 剑 英 即 将 发 动 政 变 的 消 息 率 先 通 知 给 了 极 左 派 高 层 ， 并 承 诺 坚 定 的 予 以 援 助 。 极 左 派 由 此 得 以 迅 速 采 取 行 动 ， 通 过 秘 密 渠 道 联 系 各 地 造 反 派 与 民 兵 领 袖 采 取 联 合 行 动 。 当 晚 ， 各 地 区 的 民 兵 与 造 反 派 组 织 纷 纷 登 上 了 去 往 北 京 的 列 车 ， 宣 布 要 “ 誓 死 捍 卫 党 中 央 ” 与 “ 组 织 武 装 串 联 ” 同 时 ， 与 军 队 有 所 联 系 的 毛 远 新 也 带 着 一 支 坦 克 师 远 走 进 京 。 华 国 锋 为 此 召 开 了 一 场 秘 密 会 议 ， 并 在 会 上 成 功 说 服 部 分 军 官 与 党 内 成 员 在 此 次 事 件 中 保 持 中 立 ， 将 此 次 事 件 限 定 为 党 内 冲 突 。 最 终 ， 叶 剑 英 元 帅 还 是 无 法 承 担 可 能 发 动 内 战 的 历 史 责 任 ， 被 迫 放 弃 行 动 ， 并 与 其 他 密 谋 成 员 在 几 天 后 被 撤 职 和 逮 捕 ， 而 他 国 防 部 长 的 职 位 也 由 忠 于 华 国 锋 主 席 的 陈 锡 联 将 军 暂 时 接 任 。 改 革 派 由 此 受 到 空 前 打 击 ， 很 长 一 段 时 间 内 可 能 难 以 在 中 央 立 足 。 之 后 ， 华 国 锋 与 王 洪 文 一 同 登 上 了 天 安 门 城 楼 ， 面 对 成 千 上 万 的 革 命 群 众 进 行 了 一 场 特 殊 的 “ 阅 兵 式 ” 并 在 此 宣 布 挫 败 了 以 叶 剑 英 为 首 的 “ 军 事 阴 谋 集 团 ” 的 夺 权 企 图 ， 在 群 众 的 欢 呼 声 中 ， 华 国 锋 与 极 左 派 的 联 盟 获 得 了 最 终 的 胜 利 。||但 是 ， 华 国 锋 面 对 无 产 阶 级 文 化 大 革 命 事 业 时 的 模 糊 态 度 也 日 渐 引 起 了 极 左 派 的 不 满 ， 在 华 国 锋 真 正 成 为 这 个 国 家 头 号 领 导 人 的 同 时 ， 极 左 派 也 在 持 续 的 扩 大 自 己 的 影 响 力 。 华 国 锋 与 王 洪 文 的 画 像 开 始 并 列 出 现 在 各 大 集 会 场 合 ， 类 似 于 “ 华 主 席 为 主 ， 王 副 主 席 为 副 ” 之 类 的 用 词 开 始 在 各 大 宣 传 刊 物 上 频 频 出 现 … … 极 左 派 并 不 会 止 步 于 与 华 国 锋 的 “ 共 同 胜 利 ” ， 反 而 将 继 续 不 遗 余 力 的 确 保 中 国 行 走 在 真 正 革 命 的 道 路 上 。||毛 泽 东 门 徒 之 间 的 争 斗 ， 可 能 此 时 才 刚 刚 开 始 … …";
			GlobalScript.inst.gameState.data[1] -= 200;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] += 100;
			GlobalScript.inst.gameState.data[6] += 100;
			GlobalScript.inst.gameState.KillPerson(7);
			int[] array = new int[8];
			for (int i = 0; i < GlobalScript.inst.gameState.politics_dolshnost.Length; i++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[i] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[i] = 2;
				}
				else if (GlobalScript.inst.gameState.politics_dolshnost[i] == 2)
				{
					array[i] = 150;
				}
			}
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[j] = 150;
				}
			}
			for (int k = 0; k < GlobalScript.inst.gameState.politics.Length; k++)
			{
				GlobalScript.inst.gameState.CalcRel(k);
				GlobalScript.inst.gameState.CalcRel2(k);
				GlobalScript.inst.gameState.CalcRelLeader(k);
			}
			GlobalScript.inst.gameState.politics[1].power += 500;
			GlobalScript.inst.gameState.politics[3].power += 500;
			GlobalScript.inst.gameState.politics[4].power += 500;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality += 200;
					politic.power += 100;
				}
				if (politic.traits[0] == 20)
				{
					politic.loyality += 100;
					politic.power += 80;
				}
				else if (politic.traits[0] == 2)
				{
					politic.loyality -= 100;
					politic.power -= 100;
				}
				else if (politic.traits[0] == 1)
				{
					politic.loyality -= 100;
				}
			}
			party_change[0] = 2.5f;
			party_change[1] = 1f;
			GlobalScript.inst.gameState.party_ideology[3] -= (int)((float)GlobalScript.inst.gameState.party_ideology[3] * 0.15f);
			break;
		}
		}
	}
}
