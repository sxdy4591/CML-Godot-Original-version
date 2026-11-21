using EventsForDLC;
using UnityEngine;

public class Event629 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 你 我 ， 咱 们 ， 瓦 努 阿 图 人";
		text = "主 席 同 志 ， 南 太 平 洋 传 来 了 消 息 。 英 国 与 法 国 共 同 托 管 的 新 赫 布 里 底 群 岛 正 式 宣 布 结 束 托 管 。 该 国 自 欧 洲 帝 国 的 大 溃 败 以 来 便 一 直 有 着 独 立 的 想 法 。 尤 其 是 在 六 十 年 代 以 来 的 “ 圈 地 运 动 ” 和 七 十 年 代 的 地 产 热 以 后 ， 该 国 的 主 要 政 治 运 动 均 围 绕 着 独 立 和 更 彻 底 的 独 立 之 间 展 开 。1971 年 ， 沃 尔 特 · 利 尼 神 甫 创 建 了 新 赫 布 里 底 文 化 协 会 ， 随 后 更 名 为 新 赫 布 里 底 民 族 党 ， 凭 借 着 更 为 激 进 的 对 独 立 的 要 求 ， 支 持 土 地 国 有 化 和 美 拉 尼 西 亚 传 统 。 该 党 得 以 异 军 突 起 ， 从 而 角 逐 独 立 后 的 领 导 权 。 利 尼 神 甫 在 尼 雷 尔 的 乌 贾 玛 社 会 主 义 的 基 础 上 ， 提 出 了 美 拉 尼 西 亚 社 会 主 义 理 论 。||与 此 同 时 ， 法 国 定 居 者 、 讲 法 语 和 混 血 的 新 瓦 努 阿 图 人 在 更 渐 进 的 政 治 发 展 平 台 上 成 立 了 两 个 独 立 的 政 党 — — 以 圣 埃 斯 皮 里 图 为 基 础 的 新 赫 布 里 底 斯 自 治 运 动 （MANH ） 和 埃 法 特 的 新 赫 布 里 底 社 区 联 盟 （UCNH ） 。MANH ，UCNH 这 样 的 “ 温 和 派 ” 代 表 天 主 教 和 法 国 的 利 益 ， 以 及 更 稳 重 的 独 立 道 路 。 法 国 支 持 这 些 团 体 ， 因 为 他 们 渴 望 在 该 地 区 保 持 影 响 力 ， 特 别 是 在 他 们 矿 产 丰 富 的 新 喀 里 多 尼 亚 殖 民 地 ， 他 们 试 图 镇 压 或 者 延 迟 独 立 。 而 吉 米 · 史 蒂 文 斯 则 是 其 中 的 佼 佼 者 。 这 彻 底 引 爆 了 部 分 激 进 派 ， 在 主 要 城 市 ， 温 和 派 和 激 进 派 的 支 持 者 纷 纷 大 打 出 手 ， 甚 至 招 致 了 英 国 ， 法 国 ， 澳 大 利 亚 和 新 西 兰 的 干 涉 军 前 来 维 持 秩 序 。||在 紧 张 与 混 乱 中 ， 新 赫 布 里 底 群 岛 ， 或 者 说 ， 瓦 努 阿 图 ， 就 这 样 迎 来 了 独 立 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (!a.allcountries[159].cw)
		{
			button_text[0] = " 然 后 发 生 了 什 么 ？";
		}
		else
		{
			button_text[0] = " 我 全 押 利 尼 神 甫 ！";
		}
		button_text[1] = " 准 备 派 遣 大 使";
		Object.Destroy(button[2]);
		button_text[2] = " 我 们 这 次 还 是 不 要 和 法 国 人 站 队 了 吧 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 你 我 ， 咱 们 ， 瓦 努 阿 图 人";
		if (result_num == 0)
		{
			if (a.allcountries[159].cw)
			{
				text = "不 出 所 料 ， 利 尼 阁 下 大 获 全 胜 。 凭 借 在 镇 压 分 离 主 义 者 的 “ 椰 子 战 争 ” 中 的 苦 劳 ， 积 极 争 取 独 立 的 过 程 中 的 大 费 口 舌 ， 更 重 要 的 是 我 们 的 口 头 与 物 质 支 持 。 利 尼 的 瓦 努 阿 库 党 获 得 了 漂 亮 的 成 绩 。 他 正 式 当 选 总 理 一 职 （ 因 为 该 国 的 总 统 事 实 上 是 总 督 的 延 续 ） 。 随 后 ， 他 借 鉴 了 尼 雷 尔 ， 我 国 和 毕 晓 普 的 经 验 。 他 宣 布 要 在 瓦 努 阿 图 建 成 一 个 没 有 人 剥 削 人 的 社 会 ， 并 在 原 先 的 美 拉 尼 西 亚 社 会 主 义 的 基 础 中 加 入 了 社 会 主 义 元 素 。 上 台 数 天 后 ， 该 国 宣 布 废 除 继 承 自 威 斯 敏 斯 特 的 议 会 制 。 转 而 采 用 “ 村 社 制 ” ， 即 直 接 设 立 村 一 级 别 的 “ 议 院 ” ， 只 要 是 瓦 努 阿 图 公 民 ， 均 有 随 时 随 地 参 政 议 政 的 权 力 （ 这 也 得 益 于 该 国 国 小 民 寡 ） ， 新 的 一 篇 《 瓦 努 阿 图 社 会 变 革 宪 章 》 甚 至 获 得 了20000 人 次 的 参 与 编 写 。 我 们 高 度 赞 扬 了 利 尼 的 为 政 举 措 ， 并 派 出 了 大 量 的 教 员 和 赤 脚 医 生 用 来 提 供 帮 助 。 利 尼 也 感 谢 了 我 们 为 了 第 三 世 界 国 家 的 共 同 进 步 而 作 出 的 努 力 。||在 外 交 事 务 方 面 ， 利 尼 加 入 了 不 结 盟 运 动 ， 反 对 南 非 的 种 族 隔 离 和 一 切 形 式 的 殖 民 主 义 ， 与 利 比 亚 和 古 巴 建 立 了 联 系 ， 并 反 对 法 国 在 新 喀 里 多 尼 亚 的 存 在 和 法 属 波 利 尼 西 亚 的 核 试 验 。 他 们 有 底 气 ， 因 为 他 们 的 背 后 是 8 亿 人 民 ！";
				a.allcountries[159].Gosstroy = 1;
				a.allcountries[159].SubGosstroy = 1;
				a.allcountries[159].LeaveAlliances();
				a.allcountries[159].name = "瓦 努 阿 图";
				a.allcountries[159].proprc = true;
				a.allcountries[159].Torg = true;
				a.influencePRC += 10;
				a.empires[0].power -= 10;
				a.empires[0].relations -= 70;
			}
			else if (a.empires[1].power > a.empires[0].power)
			{
				text = "不 出 所 料 ， 利 尼 阁 下 赢 得 了 选 举 。 凭 借 在 镇 压 分 离 主 义 者 的 “ 椰 子 战 争 ” 中 的 苦 劳 ， 和 积 极 争 取 独 立 的 过 程 中 的 大 费 口 舌 。 利 尼 的 瓦 努 阿 库 党 获 得 了 漂 亮 的 成 绩 。 他 正 式 当 选 总 理 一 职 （ 因 为 该 国 的 总 统 事 实 上 是 总 督 的 延 续 ） 。 他 也 试 着 依 靠 坦 桑 尼 亚 经 验 组 织 了 公 社 村 ， 试 点 了 直 接 民 主 和 农 业 改 革 ；在 外 交 事 务 方 面 ， 利 尼 加 入 了 不 结 盟 运 动 ， 反 对 南 非 的 种 族 隔 离 和 一 切 形 式 的 殖 民 主 义 ， 与 利 比 亚 和 古 巴 建 立 了 联 系 ， 并 反 对 法 国 在 新 喀 里 多 尼 亚 的 存 在 和 法 属 波 利 尼 西 亚 的 核 试 验 。 但 对 于 一 个 弹 丸 小 国 来 说 ， 维 持 独 立 已 经 是 想 当 可 贵 的 了 。";
				a.allcountries[159].Gosstroy = 2;
				a.allcountries[159].SubGosstroy = 3;
				a.allcountries[159].LeaveAlliances();
				a.allcountries[159].name = "瓦 努 阿 图";
				a.empires[0].power -= 10;
			}
			else
			{
				text = "出 乎 意 料 的 是 ， 绰 号 “ 摩 西 ” 的 吉 米 · 斯 蒂 文 斯 获 得 了 大 选 的 胜 利 ， 他 的 纳 格 利 亚 梅 尔 党 凭 借 着 稳 健 的 经 济 发 展 方 针 和 对 西 方 国 家 的 “ 友 好 态 度 ” 获 得 了 大 多 数 国 家 的 支 持 。 但 也 有 传 闻 称 他 获 得 了 美 国 的 凤 凰 基 金 会 和 法 国 人 的 支 持 。 他 宣 布 将 稳 步 在 瓦 努 阿 图 建 立 稳 定 的 市 场 经 济 ， 从 而 改 善 民 生 。";
				a.allcountries[159].Gosstroy = 3;
				a.allcountries[159].SubGosstroy = 6;
				a.allcountries[159].LeaveAlliances();
				a.allcountries[159].Vyshi = true;
				a.allcountries[159].name = "瓦 努 阿 图";
				a.empires[0].power += 10;
			}
		}
		if (result_num == 1)
		{
			if (a.allcountries[159].cw)
			{
				text = "不 出 所 料 ， 利 尼 阁 下 大 获 全 胜 。 凭 借 在 镇 压 分 离 主 义 者 的 “ 椰 子 战 争 ” 中 的 苦 劳 ， 积 极 争 取 独 立 的 过 程 中 的 大 费 口 舌 ， 更 重 要 的 是 我 们 的 口 头 与 物 质 支 持 。 利 尼 的 瓦 努 阿 库 党 获 得 了 漂 亮 的 成 绩 。 他 正 式 当 选 总 理 一 职 （ 因 为 该 国 的 总 统 事 实 上 是 总 督 的 延 续 ） 。 随 后 ， 他 借 鉴 了 尼 雷 尔 ， 我 国 和 毕 晓 普 的 经 验 。 他 宣 布 要 在 瓦 努 阿 图 建 成 一 个 没 有 人 剥 削 人 的 社 会 ， 并 在 原 先 的 美 拉 尼 西 亚 社 会 主 义 的 基 础 中 加 入 了 社 会 主 义 元 素 。 上 台 数 天 后 ， 该 国 宣 布 废 除 继 承 自 威 斯 敏 斯 特 的 议 会 制 。 转 而 采 用 “ 村 社 制 ” ， 即 直 接 设 立 村 一 级 别 的 “ 议 院 ” ， 只 要 是 瓦 努 阿 图 公 民 ， 均 有 随 时 随 地 参 政 议 政 的 权 力 （ 这 也 得 益 于 该 国 国 小 民 寡 ） ， 新 的 一 篇 《 瓦 努 阿 图 社 会 变 革 宪 章 》 甚 至 获 得 了 2 0 0 0 0 人 次 的 参 与 编 写 。 我 们 高 度 赞 扬 了 利 尼 的 为 政 举 措 ， 并 派 出 了 大 量 的 教 员 和 赤 脚 医 生 用 来 提 供 帮 助 。 利 尼 也 感 谢 了 我 们 为 了 第 三 世 界 国 家 的 共 同 进 步 而 作 出 的 努 力 。||在 外 交 事 务 方 面 ， 利 尼 加 入 了 不 结 盟 运 动 ， 反 对 南 非 的 种 族 隔 离 和 一 切 形 式 的 殖 民 主 义 ， 与 利 比 亚 和 古 巴 建 立 了 联 系 ， 并 反 对 法 国 在 新 喀 里 多 尼 亚 的 存 在 和 法 属 波 利 尼 西 亚 的 核 试 验 。 他 们 有 底 气 ， 因 为 他 们 的 背 后 是 8 亿 人 民 ！";
				a.allcountries[159].Gosstroy = 1;
				a.allcountries[159].SubGosstroy = 1;
				a.allcountries[159].LeaveAlliances();
				a.allcountries[159].name = "瓦 努 阿 图";
				a.allcountries[159].proprc = true;
				a.allcountries[159].Torg = true;
				a.allcountries[159].stab += 500;
				a.influencePRC += 10;
				a.empires[0].power -= 10;
				a.empires[0].relations -= 70;
			}
			else if (a.empires[1].power > a.empires[0].power)
			{
				text = "不 出 所 料 ， 利 尼 阁 下 赢 得 了 选 举 。 凭 借 在 镇 压 分 离 主 义 者 的 “ 椰 子 战 争 ” 中 的 苦 劳 ， 和 积 极 争 取 独 立 的 过 程 中 的 大 费 口 舌 。 利 尼 的 瓦 努 阿 库 党 获 得 了 漂 亮 的 成 绩 。 他 正 式 当 选 总 理 一 职 （ 因 为 该 国 的 总 统 事 实 上 是 总 督 的 延 续 ） 。 他 也 试 着 依 靠 坦 桑 尼 亚 经 验 组 织 了 公 社 村 ， 试 点 了 直 接 民 主 和 农 业 改 革 ；在 外 交 事 务 方 面 ， 利 尼 加 入 了 不 结 盟 运 动 ， 反 对 南 非 的 种 族 隔 离 和 一 切 形 式 的 殖 民 主 义 ， 与 利 比 亚 和 古 巴 建 立 了 联 系 ， 并 反 对 法 国 在 新 喀 里 多 尼 亚 的 存 在 和 法 属 波 利 尼 西 亚 的 核 试 验 。 我 们 高 度 赞 扬 了 利 尼 的 新 政 府 ， 并 派 出 了 大 量 的 教 员 和 赤 脚 医 生 用 于 提 供 帮 助 。 利 尼 也 感 谢 了 我 们 为 了 第 三 世 界 国 家 的 共 同 进 步 而 作 出 的 努 力 。 但 对 于 一 个 弹 丸 小 国 来 说 ， 维 持 独 立 已 经 是 想 当 可 贵 的 了 。";
				a.allcountries[159].Gosstroy = 2;
				a.allcountries[159].SubGosstroy = 3;
				a.allcountries[159].LeaveAlliances();
				a.allcountries[159].Torg = true;
				a.allcountries[159].name = "瓦 努 阿 图";
				a.empires[0].power -= 10;
			}
			else
			{
				text = "出 乎 意 料 的 是 ， 绰 号 “ 摩 西 ” 的 吉 米 · 斯 蒂 文 斯 获 得 了 大 选 的 胜 利 ， 他 的 纳 格 利 亚 梅 尔 党 凭 借 着 稳 健 的 经 济 发 展 方 针 和 对 西 方 国 家 的 “ 友 好 态 度 ” 获 得 了 大 多 数 国 家 的 支 持 。 但 也 有 传 闻 称 他 获 得 了 美 国 的 凤 凰 基 金 会 和 法 国 人 的 支 持 。 他 宣 布 将 稳 步 在 瓦 努 阿 图 建 立 稳 定 的 市 场 经 济 ， 从 而 改 善 民 生 。我 们 也 没 有 落 俗 ， 吉 米 亲 切 的 会 见 了 我 国 代 表 团 ， 并 和 我 们 建 立 了 外 交 关 系 。 ";
				a.allcountries[159].Gosstroy = 3;
				a.allcountries[159].SubGosstroy = 6;
				a.allcountries[159].LeaveAlliances();
				a.allcountries[159].Vyshi = true;
				a.allcountries[159].Torg = true;
				a.allcountries[159].name = "瓦 努 阿 图";
				a.empires[0].power += 10;
			}
			a.data[8] -= 30;
		}
	}
}
