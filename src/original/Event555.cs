using EventsForDLC;
using UnityEngine;

public class Event555 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 铸 剑 为 犁";
		text = "1979 年12 月12 日 北 约 各 国 在 布 鲁 塞 尔 首 脑 会 议 上 通 过 了 一 项 关 于 中 程 核 武 器 的 决 议 《 北 约 双 重 决 议 》 ： 北 约 决 定 从1983 年 起 在 欧 洲 部 署 美 国 提 供 的108 枚 潘 兴II 式 导 弹 和464 枚 陆 基 巡 航 导 弹 ， 以 对 抗 苏 联 部 署 的SS-20 导 弹 。 从1979 年 到1983 年 ， 西 欧 和 美 国 出 现 了 反 对 北 约 双 重 决 议 和 核 军 备 的 强 烈 抗 议 。 抗 议 者 呼 吁 撤 回 双 重 决 议 并 建 立 无 核 化 的 欧 洲 ； 在 西 德 ， 人 们 呼 吁 德 国 的 中 立 化 。||1981 年6 月 ， 德 国 新 教 教 会 大 会 在 汉 堡 举 行 了 首 批 大 型 和 平 示 威 活 动 。1981 年10 月10 日 ， 超 过300,000 人 在 波 恩 宫 廷 花 园 举 行 了 反 对 核 武 器 的 和 平 示 威 ;1981 年10 月25 日 ， 布 鲁 塞 尔 有200,000 人 示 威 ，11 月21 日 ， 阿 姆 斯 特 丹 有400,000 人 示 威 。1982 年 ， 在 美 国 总 统 " + ((GlobalScript.inst.gameState.empires[0].now_leader == 0) ? " 罗 纳 德 · 里 根" : " 吉 米 · 卡 特") + " 进 行 国 事 访 问 之 际 ， 波 恩 和 柏 林 举 行 了 大 规 模 的 和 平 示 威 活 动 ，6 月10 日 在 波 恩 的 莱 茵 河 草 地 上 举 行 了 约500,000 人 参 与 的 大 型 示 威 ，6 月11 日 在 柏 林 举 行 了 约50,000 人 的 示 威 。1981 年 至1983 年 的 复 活 节 游 行 也 定 期 在 西 德 的 许 多 城 市 和 地 区 动 员 数 十 万 人 。 在 汉 诺 威 举 行 的 德 国 新 教 大 会 上 ， 再 次 有 数 十 万 人 参 加 和 平 示 威 。||在 西 德 ， 这 些 和 平 示 威 活 动 获 得 了 左 翼 的 广 泛 支 持 ， 前 总 理 维 利 · 勃 兰 特 、 社 民 党 左 翼 的 代 表 人 物 艾 哈 德 · 埃 普 勒 和 奥 斯 卡 · 拉 方 丹 、 绿 党 、 亲 东 德 的 德 国 共 产 党 、 各 路 左 翼 小 党 以 及 各 类 和 平 组 织 都 已 广 泛 地 参 与 到 这 些 运 动 之 中 了 。 基 民 盟 / 基 社 盟 攻 击 参 与 和 平 运 动 的 社 民 党 成 员 “ 与 那 里 的 共 产 党 人 形 成 了 ‘ 人 民 阵 线 ’ ” ， 执 政 的 社 民 党 右 翼 也 对 埃 普 勒 和 拉 方 丹 的 参 与 感 到 不 满 。||如 今 ， 西 德 爆 发 了 全 国 性 的 大 型 和 平 抗 议 ，1983 年10 月22 日 ， 共 有130 万 人 在 波 恩 、 柏 林 、 汉 堡 以 及 斯 图 加 特 和 乌 尔 姆 之 间 举 行 了 示 威 活 动 ， 示 威 者 在 斯 图 加 特 和 乌 尔 姆 之 间 组 成 了 一 条 连 续 的 人 链 ， 以 施 压 政 府 结 束 北 约 双 重 决 议 的 最 终 实 施 ， 阻 止 导 弹 的 最 终 布 置 。||我 们 是 否 要 干 预 西 德 这 一 冷 战 的 前 沿 的 群 众 运 动 ， 以 达 成 有 利 于 运 动 的 局 势 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 2 && a.influencePRC >= 500)
		{
			button_text[0] = " 让 我 们 帮 助 示 威 者 ， 尝 试 推 进 和 平 进 程";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 无 法 插 手";
		}
		if (a.data[56] > 0 && a.data[56] < 4)
		{
			button_text[1] = " 我 们 将 声 援 欧 洲 人 民 ， 呼 吁 结 束 冷 战 的 对 抗";
		}
		else if (a.data[56] == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 只 是 声 援 吗 ？";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 怎 么 能 和 美 国 对 着 干 ？";
		}
		button_text[2] = " 我 们 无 能 为 力";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 铸 剑 为 犁";
		if (result_num == 0)
		{
			int num = 0;
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].isNATO)
				{
					num++;
				}
			}
			int num2 = 0;
			for (int j = 0; j < a.allcountries.Length; j++)
			{
				if ((a.allcountries[j].Gosstroy == 1 || a.allcountries[j].Gosstroy == 2) && (j == 92 || j == 21 || j == 85 || j == 86 || j == 87))
				{
					num2++;
				}
			}
			if (num < 11 && (num2 >= 3 || a.allcountries[21].isSocEU))
			{
				text = " 在 我 们 的 帮 助 下 ， 示 威 者 提 出 了 让 政 府 下 台 的 口 号 ， 并 组 织 了 由 主 张 和 平 的 左 翼 政 党 广 泛 参 与 的 人 民 阵 线 。 西 欧 的 局 势 也 有 利 于 西 德 的 和 平 运 动 ， 这 促 使 了 运 动 的 扩 大 化 。 西 欧 的 各 个 进 步 政 权 参 与 到 这 场 示 威 之 中 ， 他 们 施 压 德 国 政 府 并 大 力 资 助 民 众 的 抗 议 ， 推 进 示 威 的 激 进 化 ， 并 在 经 济 上 向 西 德 施 压 。 一 些 抗 议 者 开 始 质 疑 西 德 的 警 察 制 度 和 社 会 上 大 量 未 被 清 算 的 纳 粹 余 孽 ， 并 抨 击 西 德 的 制 度 威 胁 了 民 主 ； 工 会 也 宣 布 进 行 罢 工 ， 学 生 再 次 走 向 街 头 。 和 平 示 威 很 快 转 向 了 类 似 6 8 运 动 时 的 更 为 激 烈 的 对 抗 ， 政 府 无 法 驱 散 示 威 者 ， 基 民 盟 / 基 社 盟 内 阁 宣 布 辞 职 ， 并 重 新 召 开 大 选 。||参 与 示 威 的 左 翼 政 党 组 织 的 人 民 阵 线 以 略 微 的 优 势 赢 得 了 联 邦 德 国 大 选 ， 这 一 选 举 结 果 彻 底 动 摇 了 西 德 自 战 后 以 来 的 政 治 格 局 ， 组 成 了 西 德 第 一 个 纯 左 翼 的 政 府 。 新 政 府 宣 布 将 退 出 北 约 、 终 止 双 重 决 议 并 对 西 德 政 治 开 展 改 革 ， 进 行 更 加 深 度 的 去 纳 粹 化 和 转 型 ， 并 将 致 力 于 德 国 的 中 立 化 统 一 ， 推 进 欧 洲 的 无 核 化 。 西 德 和 平 抗 议 的 成 功 也 促 使 东 方 集 团 内 部 爆 发 了 新 一 轮 和 平 运 动 。";
				a.data[8] -= 200;
				a.data[9] -= 200;
				a.allcountries[17].Gosstroy = 2;
				a.allcountries[17].SubGosstroy = 3;
				a.allcountries[17].LeaveAlliances();
				a.allcountries[17].Torg = true;
				if (a.allcountries[85].isSocEU)
				{
					text += "||于 此 同 时 ， 西 德 新 政 府 宣 布 加 入 社 会 主 义 联 盟 ， 同 西 欧 的 温 和 左 翼 政 权 加 强 联 系 。";
					a.allcountries[17].isSocEU = true;
					if (a.data[147] == 3 && !a.allcountries[92].isSocEU)
					{
						text += "||刚 刚 赢 得 大 选 的 英 国 工 党 政 府 看 到 了 新 兴 社 会 主 义 联 盟 潜 力 ， 为 更 好 贯 彻 “ 重 建 福利国家” 的 政 策 ， 主 动 申 请 加 入 社 会 主 义 联 盟 以 寻 求 经 济 帮 助 。";
						a.allcountries[92].isSocEU = true;
						a.allcountries[92].isNATO = false;
					}
				}
				a.empires[1].power += 10;
				a.empires[1].relations += 100;
				a.empires[0].power -= 50;
				a.empires[0].relations -= 500;
				a.influencePRC += 50;
				a.data[6] += 10;
			}
			else
			{
				text = " 在 我 们 的 帮 助 下 ， 示 威 者 提 出 了 让 政 府 下 台 的 口 号 ， 并 组 织 了 由 主 张 和 平 的 左 翼 政 党 广 泛 参 与 的 人 民 阵 线 。 西 德 政 府 很 快 驱 散 和 这 场 有 共 产 党 参 与 的 且 “ 威 胁 德 美 友 谊 ” 的 “ 可 疑 ” 示 威 。 部 分 反 对 示 威 的 人 认 为 运 动 有 赤 化 西 德 的 危 险 。1983 年11 月22 日 ， 德 国 联 邦 议 院 对 导 弹 进 行 了 辩 论 ， 大 多 数 议 会 议 员 决 定 赞 成 导 弹 的 部 署 。 从1983 年12 月 起 ， 导 弹 被 陆 续 部 署 在 德 国 。 因 此 ， 和 平 运 动 失 败 了 ， 没 有 达 到 它 的 目 标 。";
				a.data[8] -= 200;
				a.data[9] -= 200;
				a.empires[0].relations -= 200;
			}
		}
		if (result_num == 1)
		{
			text = " 我 们 宣 布 支 持 欧 洲 人 民 的 和 平 运 动 ， 并 呼 吁 东 方 集 团 和 西 方 集 团 冷 静 下 来 ， 减 少 对 抗 ， 推 进 和 平 。 这 并 未 改 变 任 何 局 势 。 尽 管 随 后 在 布 鲁 塞 尔 （1983 年10 月23 日 ， 有400,000 人 ） 和 海 牙 （1983 年10 月29 日 ， 有550,000 人 ） 发 生 了 进 一 步 的 大 规 模 示 威 活 动 。 部 分 反 对 示 威 的 人 认 为 运 动 有 赤 化 西 德 的 危 险 。1983 年11 月22 日 ， 德 国 联 邦 议 院 对 导 弹 进 行 了 辩 论 ， 大 多 数 议 会 议 员 决 定 赞 成 导 弹 的 部 署 。 从1983 年12 月 起 ， 导 弹 被 陆 续 部 署 在 德 国 。 因 此 ， 和 平 运 动 失 败 了 ， 没 有 达 到 它 的 目 标 。";
			a.empires[0].relations -= 100;
			a.empires[1].relations += 100;
			a.data[6] += 10;
			a.empires[0].power += 50;
		}
		if (result_num == 2)
		{
			text = " 和 平 而 无 害 的 示 威 并 不 能 威 胁 到 任 何 人 。 尽 管 随 后 在 布 鲁 塞 尔 （1983 年10 月23 日 ， 有400,000 人 ） 和 海 牙 （1983 年10 月29 日 ， 有550,000 人 ） 发 生 了 进 一 步 的 大 规 模 示 威 活 动 。 部 分 反 对 示 威 的 人 认 为 运 动 有 赤 化 西 德 的 危 险 。1983 年11 月22 日 ， 德 国 联 邦 议 院 对 导 弹 进 行 了 辩 论 ， 大 多 数 议 会 议 员 决 定 赞 成 导 弹 的 部 署 。 从1983 年12 月 起 ， 导 弹 被 陆 续 部 署 在 德 国 。 因 此 ， 和 平 运 动 失 败 了 ， 没 有 达 到 它 的 目 标 。";
			a.empires[0].power += 50;
		}
	}
}
