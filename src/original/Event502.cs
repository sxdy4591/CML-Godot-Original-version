using EventsForDLC;
using UnityEngine;

public class Event502 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 末 法 时 代 的 黄 褐 色 黎 明";
		text = " 主 席 同 志 ！ 我 们 刚 刚 从 天 安 门 事 件 反 革 命 分 子 与 资 产 阶 级 自 由 化 分 子 的 夺 权 阴 谋 当 中 幸 存 下 来 。 因 此 ， 在 这 一 时 刻 ， 我 们 是 否 有 必 要 仔 细 检 查 我 们 的 路 线 ， 看 看 我 们 到 底 是 哪 里 做 错 了 以 招 致 离 权 力 中 枢 这 么 接 近 的 动 乱 ？ 党 内 保 守 派 与 温 和 派 认 为 ， 虽 然 改 革 开 放 的 本 意 是 好 的 ， 但 是 在 这 一 过 程 当 中 ， 步 子 迈 的 过 火 ， 要 分 清 两 种 改 革 开 放 观 ， 尤 其 是 要 采 取 政 治 运 动 来 紧 急 给 毒 草 来 一 场 “ 倒 春 寒 ” 。 你 的 亲 信 则 普 遍 认 为 ， 不 能 对 保 守 派 回 到 前 文 革 时 代 的 思 想 做 任 何 让 步 ， 一 定 要 深 化 改 革 ， 但 应 该 完 全 保 留 我 们 在 政 治 与 文 化 领 域 的 绝 对 支 配 。 最 后 ， 我 们 还 有 一 种 比 较 边 缘 化 但 是 在 党 外 获 得 越 来 越 多 支 持 的 思 潮 : 那 就 是 通 过 提 倡 民 族 主 义 ， 哪 怕 是 极 端 民 族 主 义 来 转 移 民 众 对 于 自 由 化 改 革 的 注 意 力 ， 同 时 ， 还 有 一 小 部 分 对 于 我 们 处 理 天 安 门 事 件 手 段 的 持 有 异 议 的 党 员 对 这 三 种 观 点 的 愿 景 唯 唯 诺 诺 ， 仅 赞 同 回 击 “ 极 左 派 ” 的 批 判 ， 希 望 时 间 抚 平 这 事 情 对 于 我 国 自 由 化 的 创 伤 ， 假 装 无 事 发 生 继 续 推 行 自 由 化 。 不 管 你 的 决 定 是 什 么 ， 我 有 预 感 ， 这 个 决 定 会 为 我 国 未 来 可 能 一 百 年 会 发 生 的 所 有 事 情 埋 下 伏 笔 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 让 我 们 发 动 一 轮 新 的 整 肃 运 动 ！";
		button_text[1] = " 谁 不 改 革 ， 谁 就 下 台 … …";
		button_text[2] = " 让 我 们 开 始 在 社 会 里 培 育 “ 保 守 革 命 ” 的 原 子";
		button_text[3] = " 现 在 我 们 仅 仅 需 要 击 败 对 于 总 路 线 的 怀 疑 就 够 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 末 法 时 代 的 黄 褐 色 黎 明";
		if (result_num == 0)
		{
			text = " 《 人 民 日 报 》 发 表 社 论 《 要 问 姓 资 姓 社 》 ” 后 ， 新 的 路 线 被 确 定 了 。 “ 以 反 和 平 演 变 为 中 心 ” ， “ 双 重 任 务 论 ” （ 阶 级 斗 争 和 全 面 建 设 ） 代 替 了 旧 的 路 线 。 很 快 ， 出 现 了 对 于 改 革 开 放 经 济 措 施 的 部 分 逆 转 ， 比 如 叫 停 证 卷 交 易 所 的 开 放 ， 在 文 化 生 活 上 掀 起 对 于 精 神 污 染 的 新 一 波 打 压 。 尽 管 有 的 经 济 结 构 与 文 化 引 入 的 恶 果 不 是 朝 夕 可 以 倒 转 的 ， 但 我 们 迈 出 了 坚 决 地 一 步 。 人 民 对 于 突 然 出 现 的 洗 牌 感 觉 困 惑 ， 而 反 对 派 惊 呼 我 们 开 始 了 “ 新 文 革 ” 。 就 让 他 们 去 骂 吧 - 反 正 我 们 的 投 资 者 们 还 是 会 回 来 投 资 的 。";
			GlobalScript.inst.gameState.leader.name_1 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].name_1;
			GlobalScript.inst.gameState.leader.name_2 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].name_2;
			GlobalScript.inst.gameState.leader.traits[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].traits[0];
			GlobalScript.inst.gameState.leader.traits[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].traits[1];
			GlobalScript.inst.gameState.leader.traits[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].traits[2];
			GlobalScript.inst.gameState.leader.age = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].age;
			GlobalScript.inst.gameState.leader.face_type = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_type;
			GlobalScript.inst.gameState.leader.face_parts[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[0];
			GlobalScript.inst.gameState.leader.face_parts[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[1];
			GlobalScript.inst.gameState.leader.face_parts[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[2];
			GlobalScript.inst.gameState.leader.face_parts[3] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[3];
			GlobalScript.inst.gameState.leader.face_parts[4] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[4];
			GlobalScript.inst.gameState.leader.face_parts[5] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[5];
			GlobalScript.inst.gameState.leader.face_parts[6] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[6];
			GlobalScript.inst.gameState.leader.face_parts[7] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].face_parts[7];
			GlobalScript.inst.gameState.leader.jacket = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[2]].jacket;
			GlobalScript.inst.gameState.KillPerson(GlobalScript.inst.gameState.faction_leader[2]);
			if (a.data[16] > 12)
			{
				a.data[16]--;
			}
			a.data[15] = 6;
			a.data[17] = 16;
			a.data[50] = 24;
			a.data[8] -= 40;
			a.data[9] -= 40;
			a.data[1] -= 200;
			a.data[3] -= 100;
			a.data[4] -= 150;
			a.data[6] += 80;
			a.empires[0].relations -= 150;
			a.empires[1].relations += 150;
		}
		if (result_num == 1)
		{
			text = " 很 快 ， 你 亲 自 出 面 为 改 革 的 原 则 背 书 。 一 切 偏 离 四 项 基 本 原 则 的 言 论 和 行 动 都 是 错 误 的 ， 一 切 否 定 和 破 坏 四 项 基 本 原 则 的 言 论 和 行 动 都 是 不 能 容 许 的 ， 但 是 谁 不 改 革 谁 就 是 和 整 个 党 对 着 干 ， 就 是 “ 左 ” 的 余 孽 。 《 解 放 日 报 》 发 表 了 支 持 你 的 路 线 的 言 论 。 与 此 同 时 ， 你 决 定 去 这 个 国 家 南 方 巡 查 那 些 经 济 特 区 ， 开 启 了 “ 第 二 次 思 想 的 大 解 放 ” 。 那 些 保 守 派 在 反 对 “ 左 ” 的 大 棒 下 无 地 自 容 ， 我 们 胜 利 了 ！";
			if (a.data[16] < 14)
			{
				a.data[16] = 14;
			}
			else if (a.data[16] == 14)
			{
				a.data[16] = 15;
			}
			a.data[15] = 6;
			a.data[17] = 16;
			a.data[1] += 100;
			a.data[3] -= 100;
			a.data[4] -= 100;
			a.modifies[6].active = false;
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
			a.data[8] -= 40;
			a.data[9] -= 40;
			a.empires[0].relations += 150;
			a.empires[1].relations -= 150;
		}
		if (result_num == 2)
		{
			text = " 很 快 ， 你 决 定 在 新 的 政 治 现 实 下 采 用 颇 具 创 造 力 的 改 革 方 案 。   在 新 的 宪 法 中 ， 中 华 民 族 的 伟 大 复 兴 被 提 到 ， 而 特 色 社 会 主 义 的 来 源 也 被 引 用 为 “ 源 自 于 中 华 民 族 五 千 多 年 文 明 历 史 所 孕 育 的 中 华 优 秀 传 统 文 化 ” 。   同 时 ， 你 进 一 步 让 步 ， 通 过 援 引 先 进 社 会 生 产 力 的 发 展 要 求 ， 允 许 民 族 企 业 家 进 一 步 参 与 政 治 。 在 课 本 上 ， 在 书 店 里 ， 在 整 个 社 会 ， 潜 移 默 化 的 变 化 正 在 发 生 - 对 于 抽 象 的 民 族 与 国 家 的 憎 恨 代 替 了 对 帝 国 主 义 的 憎 恨 ， 对 于 “ 富 国 强 兵 ” 叙 事 的 崇 拜 愈 演 愈 烈 … … 不 过 ， 我 们 仅 仅 是 迈 出 了 前 往 新 秩 序 的 第 一 步 。";
			a.data[1] += 150;
			a.data[3] += 150;
			a.data[4] -= 100;
			a.data[31] = 900;
			a.data[8] -= 40;
			a.data[9] -= 40;
			a.data[16] = 14;
			a.data[17] = 16;
			a.data[50] = 29;
			a.data[15] = 6;
			a.modifies[6].active = false;
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
			a.empires[0].relations -= 100;
			a.empires[1].relations -= 100;
		}
		if (result_num == 3)
		{
			text = " 好 吧 ， 我 们 决 定 仅 仅 回 击 对 于 改 革 开 放 本 身 的 攻 击 。 不 幸 的 是 ， 没 有 任 何 人 对 我 们 对 党 内 自 由 派 的 妥 协 感 到 满 意 ， 包 括 他 们 自 己 。 天 安 门 事 件 后 ， 没 有 什 么 会 和 以 前 一 样 了 … … 也 许 我 们 还 可 以 等 到 下 一 代 人 的 时 候 推 行 自 由 化 ， 但 当 我 们 无 法 保 证 我 们 自 己 能 做 到 的 时 候 又 怎 么 能 指 望 下 一 代 呢 ？";
			a.data[1] -= 300;
			a.data[3] -= 300;
			a.data[4] += 300;
		}
	}
}
