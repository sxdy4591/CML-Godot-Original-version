using EventsForDLC;
using UnityEngine;

public class Event542 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 第 一 届 世 界 革 命 青 年 与 学 生 联 欢 会";
		text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 ， 如 你 所 知 ， 第 一 节 世 界 革 命 青 年 与 学 生 联 欢 会 将 在 我 国 举 行 ， 我 国 已 经 成 功 证 明 有 能 力 和 苏 联 在 世 界 革 命 运 动 中 扳 手 腕 ， 甚 至 是 东 风 压 倒 西 风 。 很 快 ， 我 们 就 将 在 首 都 北 京 举 办 这 一 场 风 头 不 输 奥 运 会 的 盛 大 庆 典 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = "革 命 青 年 要 志 在 四 方 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 第 一 届 世 界 革 命 青 年 与 学 生 联 欢 会";
		if (result_num == 0)
		{
			text = " 第 一 届 青 年 节 是 一 次 伟 大 的 成 功 ， 多 达170 个 国 家 的 青 年 学 生 代 表 均 来 到 我 国 参 加 这 一 盛 会 。 在 我 国 北 京 的 工 人 体 育 场 ， 来 自 各 地 的 进 步 青 年 和 重 要 国 家 领 导 人 齐 聚 一 堂 。 ";
			text += GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1];
			text += " ";
			text += GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2];
			text += " 同 志 和 津 巴 布 韦 总 统 穆 加 贝 ， 阿 尔 巴 尼 亚 的 霍 查 夫 人 等 世 界 人 民 的 领 袖 共 襄 盛 举 。 我 国 的 学 生 代 表 向 他 们 献 上 了 鲜 花 和 拥 抱 。 国 务 院 总 理 ";
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
			text = text + " 同 志 在 开 幕 式 上 做 了 简 单 的 演 讲 ： “ 在 这 里 ， 在 伟 大 的 毛 泽 东 主 席 的 故 乡 。 我 们 的 年 轻 人 是 多 么 深 深 地 致 力 于 解 放 、 自 由 和 社 会 主 义 的 崇 高 理 想 。 我 们 都 同 意 ， 今 天 人 类 没 有 比 解 放 受 压 迫 者 重 要 、 更 紧 迫 的 任 务 了 。 我 很 高 兴 看 到 世 界 的 青 年 都 和 我 一 样 ， 渴 望 全 人 类 的 解 放 远 超 过 一 切 。 ”|在 开 幕 式 上 ， 来 自 世 界 各 国 的 青 年 踏 着 整 齐 划 一 的 步 子 ， 举 着 写 有 “ 永 远 铭 记 革 命 导 师 ， 开 创 青 崭 新 世 界 ” 的 横 幅 和 标 语 ， 自 信 的 绕 着 北 京 工 人 体 育 场 的 跑 道 经 过 主 席 台 的 检 阅 。 中 华 人 民 共 和 国 代 表 团 包 括 了 来 自 我 国56 个 民 族 的 青 年 代 表 ， 其 中 也 包 括 港 澳 台 侨 胞 和 归 国 华 侨 他 们 穿 着 自 己 民 族 特 有 的 服 饰 ， 或 是 致 敬65 式 军 装 的 礼 服 。 我 们 的 旗 手 则 是 总 政 歌 舞 团 男 高 音 程 志 ， 解 放 军 军 乐 团 女 高 音 韩 芝 萍 和 总 政 歌 舞 团 男 中 音 熊 卿 才 。 最 令 人 惊 喜 的 则 是 来 自 苏 联 的 无 产 阶 级 专 政 党 的 青 年 代 表 队 ， 他 们 尽 管 人 数 不 是 最 多 的 。 他 们 高 举 毛 泽 东 和 斯 大 林 的 画 像 ， 志 气 昂 扬 的 喊 着 “ 苏 联 修 正 党 必 败 ！ ” 的 口 号 ， 这 为 他 们 博 得 了 不 少 镜 头 。| " + ((a.allcountries[131].SubGosstroy == 9 || a.allcountries[131].SubGosstroy == 7) ? "各 国 的 青 年 也 就 国 际 问 题 进 行 了 充 分 的 讨 论 ： 就 声 援 饱 受 种 族 隔 离 之 苦 的 南 非 人 民 ， 终 结 美 帝 国 主 义 针 对 古 巴 的 无 理 封 锁 和 干 涉 中 美 洲 国 家 内 政 问 题 ， 大 会 一 致 通 过 了 决 议 。 同 时 ， 大 会 一 致 通 过 决 定 ， 谴 责 苏 联 在 南 部 非 洲 扶 植 的 法 西 斯 主 义 代 理 人 ， 并 赤 裸 裸 的 干 涉 内 政 达 成 了 谴 责 。 正 式 将 苏 联 定 性 为 社 会 帝 国 主 义 超 级 大 国 。 就 支 持 核 裁 军 和 侵 犯 人 权 的 军 政 府 方 面 ， 代 表 们 达 成 了 一 致 。|" : "各 国 的 青 年 就 彻 底 批 倒 批 臭 美 帝 国 主 义 ， 苏 联 社 会 帝 国 主 义 大 会 一 致 通 过 了 决 议 。 同 时 ， 大 会 特 别 开 设 了 “ 关 于 被 压 迫 者 追 求 正 义 特 别 法 庭 ” ， 旨 在 为 曾 在 中 美 洲 军 事 独 裁 政 权 ， 美 国 禁 运 的 古 巴 ， 苏 联 武 装 入 侵 过 的 捷 克 斯 洛 伐 克 以 及 饱 受 战 争 之 苦 的 各 国 人 民 声 张 正 义 。 法 庭 判 处 了 苏 联 曾 经 的 领 导 人 列 昂 尼 德 勃 列 日 涅 夫2800 年 有 期 徒 刑 。 以 “ 人 民 进 步 法 院 ” 为 名 要 求 逮 捕 基 辛 格 ， 其 罪 名 是 多 次 干 涉 他 国 内 政 ， 残 酷 的 谋 杀 了 智 利 总 统 阿 连 德 。 尽 管 这 只 是 个 玩 笑 话 ， 但 代 表 们 还 是 达 成 了 一 致 ， 并 焚 烧 了 画 有 美 国 总 统 和 苏 联 最 高 领 导 人 头 像 的 稻 草 人 。|") + "闭 幕 式 上 ， 来 自 布 基 纳 法 索 ， 英 国 和 智 利 的 青 年 代 表 就 谴 责 帝 国 主 义 干 涉 和 反 对 法 西 斯 主 义 复 活 的 观 点 进 行 了 简 短 的 演 讲 。 他 们 感 谢 了 中 华 人 民 共 和 国 积 极 参 与 解 放 世 界 被 压 迫 者 的 斗 争 ， 并 坚 信 我 国 将 会 取 得 胜 利 ， 终 究 会 向 帝 国 主 义 者 们 证 明 共 产 主 义 定 胜 利 。 在 巨 大 的 篝 火 前 ， 来 自 世 界 各 地 的 青 年 手 拉 着 手 ， 围 成 一 个 又 一 个 同 心 圆 ， 他 们 高 声 歌 唱 诸 如 《venceremos 》 ， 《 共 青 团 员 之 歌 》 等 歌 曲 ， 最 后 ， 在 一 曲 《 革 命 青 年 进 行 曲 》 之 后 。 数 以 万 计 的 烟 火 飞 向 空 中 ， 炸 开 了 美 丽 的 火 花 ， 这 也 宣 告 了 节 日 的 闭 幕 。";
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[6] += 50;
			a.data[8] -= 150;
			a.empires[1].relations -= 100;
			a.empires[0].relations -= 100;
			a.influencePRC += 50;
		}
	}
}
