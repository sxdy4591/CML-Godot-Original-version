using EventsForDLC;
using UnityEngine;

public class Event104 : EventsSecond
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
		name = " 第 十 二 届 世 界 青 年 学 生 节";
		text = "  终 于 ， 我 们 等 来 了 这 光 荣 的 一 天 ， 第 十 二 届 世 界 青 年 学 生 联 欢 会 将 在 我 国 举 行 ， 这 也 是 亚 洲 国 家 首 次 举 办 此 类 活 动 。 全 世 界 的 青 年 都 会 来 到 我 国 参 加 这 一 盛 会 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 团 结 的 歌 声 挡 不 住 也 冲 不 散 ！";
		button_text[1] = " 不 派 出 代 表 团";
		button_text[2] = " 与 盟 国 举 办 自 己 的 节 日 （ 需 要2 百 万 预 算 ）";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 第 十 二 届 世 界 青 年 学 生 节";
		switch (result_num)
		{
		case 0:
			text = " 第 十 二 届 青 年 节 是 一 次 伟 大 的 成 功 ， 多 达170 个 国 家 的 青 年 学 生 代 表 均 来 到 我 国 参 加 这 一 盛 会 。 在 我 国 北 京 的 工 人 体 育 场 ， 来 自 各 地 的 进 步 青 年 和 重 要 国 家 领 导 人 齐 聚 一 堂 。 ";
			text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
			text += " ";
			text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
			if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
			{
				text += " 同 志 和 津 巴 布 韦 总 统 穆 加 贝 ， 赞 比 亚 总 统 卡 翁 达 等 第 三 世 界 国 家 的 领 袖 共 襄 盛 举 ， 甚 至 包 括 苏 联 最 高 领 导 人 戈 尔 巴 乔 夫 。 我 国 的 学 生 代 表 向 他 们 献 上 了 鲜 花 和 拥 抱 。 国 务 院 总 理 ";
			}
			if (GlobalScript.inst.gameState.empires[1].now_leader == 3)
			{
				text += " 同 志 和 津 巴 布 韦 总 统 穆 加 贝 ， 赞 比 亚 总 统 卡 翁 达 等 第 三 世 界 国 家 的 领 袖 共 襄 盛 举 ， 甚 至 包 括 苏 联 最 高 领 导 人 谢 尔 比 茨 基 。 我 国 的 学 生 代 表 向 他 们 献 上 了 鲜 花 和 拥 抱 。 国 务 院 总 理 ";
			}
			if (GlobalScript.inst.gameState.empires[1].now_leader == 5)
			{
				text += " 同 志 和 津 巴 布 韦 总 统 穆 加 贝 ， 赞 比 亚 总 统 卡 翁 达 等 第 三 世 界 国 家 的 领 袖 共 襄 盛 举 ， 甚 至 包 括 苏 联 最 高 领 导 人 格 里 申 。 我 国 的 学 生 代 表 向 他 们 献 上 了 鲜 花 和 拥 抱 。 国 务 院 总 理 ";
			}
			if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
			{
				text += " 同 志 和 津 巴 布 韦 总 统 穆 加 贝 ， 赞 比 亚 总 统 卡 翁 达 等 第 三 世 界 国 家 的 领 袖 共 襄 盛 举 ， 甚 至 包 括 苏 联 最 高 领 导 人 罗 曼 诺 夫 。 我 国 的 学 生 代 表 向 他 们 献 上 了 鲜 花 和 拥 抱 。 国 务 院 总 理 ";
			}
			if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
			{
				text += " 同 志 和 津 巴 布 韦 总 统 穆 加 贝 ， 赞 比 亚 总 统 卡 翁 达 等 第 三 世 界 国 家 的 领 袖 共 襄 盛 举 ， 甚 至 包 括 苏 联 最 高 领 导 人 利 加 乔 夫 。 我 国 的 学 生 代 表 向 他 们 献 上 了 鲜 花 和 拥 抱 。 国 务 院 总 理 ";
			}
			if (GlobalScript.inst.gameState.politics_dolshnost[0] != 150 && GlobalScript.inst.gameState.politics_dolshnost[0] != 200)
			{
				text += a.names1[a.politics[a.politics_dolshnost[0]].name_1];
				text += " ";
				text += a.names2[a.politics[a.politics_dolshnost[0]].name_2];
			}
			else
			{
				text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
				text += " ";
				text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
			}
			text += " 同 志 发 表 了 简 短 的 演 讲 ： “ 在 中 国 ， 世 界 的 重 要 一 环 ， 你 可 以 直 接 感 受 到 我 们 的 年 轻 人 是 多 么 深 深 地 致 力 于 人 类 、 和 平 和 社 会 正 义 的 崇 高 理 想 。 我 认 为 我 们 都 同 意 ， 今 天 人 类 没 有 比 加 强 和 平 更 重 要 、 更 紧 迫 的 任 务 了 。 对 此 ， 我 在 这 里 呼 吁 ， 全 体 世 界 的 青 年 都 应 该 为 了 反 对 一 切 不 公 平 团 结 起 来 ！ ”|在 开 幕 式 上 ， 来 自 世 界 各 国 的 青 年 踏 着 整 齐 划 一 的 步 子 ， 举 着 “ 反 抗 帝 国 主 义 霸 权 ， 争 取 自 由 解 放 与 和 平 ” 的 标 语 ， 自 信 的 绕 着 北 京 工 人 体 育 场 的 跑 道 经 过 主 席 台 的 检 阅 。 中 华 人 民 共 和 国 代 表 团 包 括 了 来 自 我 国56 个 民 族 的 青 年 代 表 ， 其 中 也 包 括 港 澳 台 侨 胞 和 归 国 华 侨 / 他 们 穿 着 自 己 民 族 特 有 的 服 饰 ， 或 是 中 山 装 。 我 们 的 旗 手 则 是 总 政 歌 舞 团 男 高 音 程 志 ， 解 放 军 军 乐 团 女 高 音 韩 芝 萍 和 总 政 歌 舞 团 男 中 音 熊 卿 才 。 这 也 是 近 几 年 我 国 参 与 的 最 盛 大 的 集 会 性 活 动 。";
			if (!GlobalScript.inst.gameState.modifies[6].active)
			{
				text += "||但 还 是 有 不 和 谐 的 声 音 ， 在 加 拿 大 代 表 团 行 进 的 过 程 中 ， 两 位 代 表 从 包 里 掏 出 一 块 白 布 ， 上 面 写 着 “ ";
				text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
				text += " ";
				text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
				text += " ， 叛 徒 去 死 ！ ” 另 一 个 青 年 的 写 着 “ 毛 泽 东 同 志 万 岁 ， 修 正 主 义 必 败 ！ ” 并 用 蹩 脚 的 中 文 大 喊 着 “ 毛 泽 东 ！ 毛 泽 东 ！ ” 。 他 们 很 快 就 被 安 保 人 员 带 走 。 ";
			}
			text += "||各 国 的 青 年 也 就 国 际 问 题 进 行 了 讨 论 。 但 在 涉 及 到 苏 联 在 南 部 非 洲 的 军 事 干 涉 和 援 助 时 ， 辩 论 最 终 上 升 成 了 苏 联 的 地 位 究 竟 是 进 步 国 家 代 表 还 是 社 会 帝 国 主 义 ， 话 题 不 得 不 被 中 止 。 但 对 支 持 核 裁 军 和 谴 责 美 国 支 持 的 军 政 府 方 面 ， 代 表 还 是 达 成 了 一 致 。|闭 幕 式 上 ， 来 自 南 非 ， 法 国 和 美 国 的 青 年 代 表 就 呼 吁 世 界 和 平 和 反 对 法 西 斯 主 义 复 活 的 观 点 进 行 了 简 短 的 演 讲 。 感 谢 了 苏 维 埃 联 盟 和 中 国 就 维 护 世 界 和 平 与 稳 定 做 出 的 贡 献 ， 但 依 然 呼 吁 我 国 发 挥 一 个 区 域 性 大 国 在 东 亚 的 作 用 。 在 巨 大 的 篝 火 前 ， 来 自 世 界 各 地 的 青 年 手 拉 着 手 ， 围 成 一 个 又 一 个 同 心 圆 ， 他 们 高 声 歌 唱 诸 如 《venceremos 》 ， 《 革 命 人 永 远 是 年 轻 》 等 歌 曲 ， 最 后 ， 在 一 曲 《 歌 唱 动 荡 的 青 春 中 》 。 数 以 万 计 的 烟 火 飞 向 空 中 ， 炸 开 了 美 丽 的 火 花 ， 这 也 宣 告 了 节 日 的 闭 幕 。";
			GlobalScript.inst.gameState.data[4] += 20;
			GlobalScript.inst.gameState.data[3] += 80;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			break;
		case 1:
			text = " 该 节 日 的 政 治 纲 领 包 括 建 立 新 的 国 际 经 济 秩 序 ， 讨 论 向 落 后 和 发 展 中 国 家 提 供 经 济 援 助 的 问 题 ， 与 贫 困 和 失 业 作 斗 争 ， 提 出 环 境 问 题 。 这 个 节 日 举 办 了 许 多 流 行 团 体 和 业 余 团 体 的 音 乐 会 和 艺 术 家 和 摄 影 师 的 展 览 。 对 我 们 来 说 ， 什 么 都 没 发 生 ， 因 为 我 们 没 有 派 代 表 团 。";
			GlobalScript.inst.gameState.influencePRC -= 10;
			break;
		case 2:
		{
			text = " 在 第 十 二 届 世 界 青 年 学 生 节 在 莫 斯 科 举 行 时, 我 们 决 定 强 调 我 们 独 立 于 苏 联 并 组 织 自 己 的 “ 世 界 进 步 青 年 节 ” 在 北 京, 中 国 的 各 个 盟 友 因 为 这 样 或 那 样 的 原 因 没 有 派 遣 一 个 代 表 团 抵 达 莫 斯 科 。 总 的 来 说 ， 我 们 的 人 民 对 这 一 事 件 感 到 满 意 ， 我 们 与 盟 国 的 关 系 加 强 了 ， 但 国 际 左 翼 运 动 对 这 一 切 持 怀 疑 态 度 。";
			GlobalScript.inst.gameState.data[4] += 50;
			GlobalScript.inst.gameState.data[3] += 40;
			GlobalScript.inst.gameState.data[1] += 150;
			GlobalScript.inst.gameState.influencePRC += 10;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			GlobalScript.inst.gameState.empires[0].relations += 50;
			GlobalScript.inst.gameState.data[8] -= 20;
			Country[] allcountries = GlobalScript.inst.gameState.allcountries;
			foreach (Country country in allcountries)
			{
				if (country.okb)
				{
					country.soc_stab += 100;
					if (country.usalliance)
					{
						country.usalliance = false;
						GlobalScript.inst.gameState.data[9] -= 30;
						GlobalScript.inst.gameState.data[8] -= 50;
					}
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
