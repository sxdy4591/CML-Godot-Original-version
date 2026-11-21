using EventsForDLC;
using UnityEngine;

public class Event630 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		if (!a.event_done[483])
		{
			name = " 让 风 暴 来 的 更 猛 烈 些 吧";
			text = "随 着 诸 多 国 家 进 一 步 脱 离 法 兰 西 帝 国 的 魔 爪 之 中 ， 远 在 天 边 的 新 喀 里 多 尼 亚 进 入 了 一 个 被 称 为 “ 多 事 之 秋 ” 的 时 代 。 政 治 暴 力 ， 抗 议 ， 游 行 日 渐 增 多 。 作 为 当 前 政 治 骚 乱 的 主 要 爆 点 ， 新 喀 里 多 尼 亚 的 族 裔 冲 突 自 进 入 二 十 世 纪 以 来 就 一 直 发 酵 。 卡 纳 克 人 作 为 本 地 土 著 ，1862 年 前 还 没 有 财 产 权 ，1946 年 前 还 没 有 法 国 公 民 身 份 ，1957 年 才 有 投 票 权 。||为 了 抓 紧 新 喀 里 多 尼 亚 ， 从 而 维 持 在 太 平 洋 地 区 的 存 在 ， 法 国 政 府 大 推 移 边 徙 民 之 策 ， 同 时 停 止 了 在 新 喀 推 行 类 似 其 他 法 属 非 洲 殖 民 地 的 逐 步 自 治 政 策 。 从1963 年 的 人 口 普 查 开 始 ， 卡 纳 克 人 就 成 为 少 数 派 ， 始 终 仅 有40 %   左 右 的 人 数 。 时 任 总 理 梅 斯 梅 尔1972 年 公 开 呼 吁 法 国 公 民 从 法 国 本 土 或 其 他 海 外 领 土 大 规 模 移 民 ， 摆 明 了 打 人 口 战 压 制 独 立 诉 求 。||面 对 收 紧 的 自 治 空 间 和 周 边 太 平 洋 岛 国 的 独 立 潮 ， 卡 纳 克 独 派 针 锋 相 对 地 提 出 了 独 立 公 投 和 投 票 权 要 求 ， 这 就 是 当 前 局 势 的 直 接 爆 点 。 最 近 ， 新 喀 独 派 、 亲 法 派 和 法 国 政 府 举 行 圆 桌 会 议 ， 法 国 政 府 被 迫 承 认 新 喀 可 能 的 独 立 权 。 这 一 成 就 大 大 鼓 舞 了 新 喀 独 派 。 卡 纳 克 社 会 主 义 民 族 解 放 阵 线 则 作 为 一 个 大 帐 篷 机 构 统 合 各 类 反 法 派 组 织 。 同 年 ， 民 解 阵 抵 制 了11 月 的 地 方 选 举 ， 并 攻 占 了 当 地 的 一 座 矿 山 城 镇 。 针 锋 相 对 地 ， 亲 法 派 组 织 也 袭 击 了 民 阵 ， 杀 害 了11 人 ， 包 括 其 领 导 人 吉 巴 乌 的 两 个 兄 弟 。 自 此 ， 新 喀 陷 入 了 彻 底 的 内 战 状 态 ， 保 派 和 独 派 组 织 不 断 发 生 武 装 冲 突 ， 互 相 暗 杀 对 方 的 政 治 领 导 人 。 而 借 此 机 会 ， 我 们 应 该 大 力 的 支 持 我 们 的 战 友 争 取 自 由 。";
		}
		else
		{
			name = " 只 消 轻 轻 扇 动 翅 膀 … …";
			text = "香 榭 丽 舍 大 道 的 危 机 和 暴 乱 彻 底 引 爆 了 法 国 海 外 领 地 脆 弱 的 平 衡 ， 远 在 天 边 的 新 喀 里 多 尼 亚 进 入 了 一 个 被 称 为 “ 多 事 之 秋 ” 的 时 代 。 政 治 暴 力 ， 抗 议 ， 游 行 日 渐 增 多 。 作 为 当 前 政 治 骚 乱 的 主 要 爆 点 ， 新 喀 里 多 尼 亚 的 族 裔 冲 突 自 进 入 二 十 世 纪 以 来 就 一 直 发 酵 。 卡 纳 克 人 作 为 本 地 土 著 ， 1 8 6 2 年 前 还 没 有 财 产 权 ， 1 9 4 6 年 前 还 没 有 法 国 公 民 身 份 ， 1 9 5 7 年 才 有 投 票 权 。||为 了 抓 紧 新 喀 里 多 尼 亚 ， 从 而 维 持 在 太 平 洋 地 区 的 存 在 ， 法 国 政 府 大 推 移 边 徙 民 之 策 ， 同 时 停 止 了 在 新 喀 推 行 类 似 其 他 法 属 非 洲 殖 民 地 的 逐 步 自 治 政 策 。 从 1 9 6 3 年 的 人 口 普 查 开 始 ， 卡 纳 克 人 就 成 为 少 数 派 ， 始 终 仅 有 4 0 %   左 右 的 人 数 。 时 任 总 理 梅 斯 梅 尔 1 9 7 2 年 公 开 呼 吁 法 国 公 民 从 法 国 本 土 或 其 他 海 外 领 土 大 规 模 移 民 ， 摆 明 了 打 人 口 战 压 制 独 立 诉 求 。||面 对 收 紧 的 自 治 空 间 和 周 边 太 平 洋 岛 国 的 独 立 潮 ， 卡 纳 克 独 派 针 锋 相 对 地 提 出 了 独 立 公 投 和 投 票 权 要 求 ， 这 就 是 当 前 局 势 的 直 接 爆 点 。 最 近 ， 新 喀 独 派 就 组 建 完 全 的 联 盟 ， 在 法 国 陷 入 危 机 时 展 开 起 义 达 成 了 一 只 ， 这 一 成 就 大 大 鼓 舞 了 新 喀 独 派 。 卡 纳 克 社 会 主 义 民 族 解 放 阵 线 则 作 为 一 个 大 帐 篷 机 构 统 合 各 类 反 法 派 组 织 。 同 年 ， 民 解 阵 抵 制 了 1 1 月 的 地 方 选 举 ， 并 攻 占 了 当 地 的 一 座 矿 山 城 镇 。 针 锋 相 对 地 ， 亲 法 派 组 织 也 袭 击 了 民 阵 ， 杀 害 了 1 1 人 ， 包 括 其 领 导 人 吉 巴 乌 的 两 个 兄 弟 。 自 此 ， 新 喀 陷 入 了 彻 底 的 内 战 状 态 ， 而 这 就 是 前 线 记 者 和 线 人 从 努 美 阿 发 来 的 快 讯 … …";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		if (!a.event_done[483])
		{
			button_text[0] = " “ 因 为 海 燕 正 翱 翔 其 间 ”";
		}
		else
		{
			button_text[0] = " 谁 赢 了 ？";
		}
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		if (!a.event_done[483])
		{
			name = " 让 风 暴 来 的 更 猛 烈 些 吧";
			if (result_num == 0)
			{
				if (a.allcountries[135].Gosstroy != 0)
				{
					text = "随 着 我 们 对 反 叛 军 武 装 对 进 一 步 支 持 ， 大 量 的 轻 重 武 器 得 以 通 过 瓦 努 阿 图 的 渔 船 送 抵 该 国 。 解 放 阵 线 的 战 士 在 充 足 的 准 备 下 攻 入 了 努 美 阿 ， 一 切 正 如 法 国 在 阿 尔 及 利 亚 所 遭 遇 的 那 样 。 意 识 到 抵 抗 无 果 ， 驻 留 的 法 国 宪 兵 宣 布 举 手 投 降 ， 尽 管 保 卫 喀 里 多 尼 亚 在 共 和 国 内 联 盟 继 续 抵 抗 ， 但 孤 立 无 援 的 他 们 定 会 失 败 。 卡 纳 克 人 民 共 和 国 就 此 建 立 了 起 来 ， 该 国 宣 布 实 行 “ 科 学 的 美 拉 尼 西 亚 社 会 主 义 ” ， “ 充 分 尊 重 原 住 民 和 移 民 者 后 裔 的 权 利 ” ， 以 及 在 平 等 的 旗 帜 下 进 行 外 交 活 动 ， 长 期 受 法 国 镍 业 公 司 控 制 的 镍 矿 也 被 收 归 国 有 化 。 法 国 不 得 不 宣 布 承 认 该 地 的 独 立 ， 并 决 定 在 其 他 南 太 平 洋 殖 民 地 放 松 管 制 。";
					a.allcountries[154].Gosstroy = 1;
					a.allcountries[154].SubGosstroy = 1;
					a.allcountries[154].LeaveAlliances();
					a.allcountries[154].name = "卡 纳 克 人 民 共 和 国";
					a.allcountries[154].proprc = true;
					a.allcountries[154].Torg = true;
					a.influencePRC += 10;
					a.empires[0].power -= 10;
					a.empires[0].relations -= 70;
				}
				else
				{
					text = "出 乎 意 料 又 意 料 之 中 ， 革 命 者 的 东 风 竟 被 西 风 压 过 。 彼 得 森 总 统 出 于 对 一 个 独 立 且 亲 红 色 阵 营 的 政 权 的 担 忧 ， 同 时 也 是 为 了 转 移 国 内 的 矛 盾 。 澳 大 利 亚 宣 布 对 新 喀 里 多 尼 亚 发 动 特 别 维 护 和 平 行 动 。 接 近 3 0 0 0 人 的 大 军 坐 着 登 陆 艇 和 直 升 机 从 努 美 阿 登 陆 ， 几 乎 可 以 被 形 容 为 是 “ 乌 合 之 众 ” 的 分 离 主 义 份 子 在 澳 大 利 亚 的 攻 势 下 一 触 即 溃 。 最 终 ， “ 卡 纳 克 人 民 共 和 国 临 时 政 府 ” 也 被 废 除 。 在 澳 大 利 亚 军 队 的 支 持 下 ， 保 卫 喀 里 多 尼 亚 在 （ 澳 大 利 亚 ） 共 和 国 内 联 盟 的 新 政 府 得 以 被 建 立 起 来 。||只 不 过 是 从 一 个 暴 君 的 手 上 滑 走 ， 落 入 另 一 个 暴 君 的 怀 里 罢 了 。";
					a.allcountries[154].Gosstroy = 0;
					a.allcountries[154].SubGosstroy = 7;
					a.allcountries[154].LeaveAlliances();
					a.allcountries[154].puppetOf = 21;
					a.allcountries[154].name = "“ 卡 纳 克 共 和 国 ”";
					a.empires[0].power += 10;
				}
			}
			return;
		}
		name = " 只 消 轻 轻 扇 动 翅 膀 … …";
		if (result_num == 0)
		{
			text = "解 放 阵 线 的 战 士 在 充 足 的 准 备 下 攻 入 了 努 美 阿 ， 一 切 正 如 法 国 在 阿 尔 及 利 亚 所 遭 遇 的 那 样 。 意 识 到 抵 抗 无 果 ， 驻 留 的 法 国 宪 兵 宣 布 举 手 投 降 ， 尽 管 保 卫 喀 里 多 尼 亚 在 共 和 国 内 联 盟 继 续 抵 抗 ， 但 孤 立 无 援 的 他 们 定 会 失 败 。 卡 纳 克 人 民 共 和 国 就 此 建 立 了 起 来 ， 该 国 宣 布 实 行 “ 科 学 的 美 拉 尼 西 亚 社 会 主 义 ” ， “ 充 分 尊 重 原 住 民 和 移 民 者 后 裔 的 权 利 ” ， 以 及 在 平 等 的 旗 帜 下 进 行 外 交 活 动 ， 长 期 受 法 国 镍 业 公 司 控 制 的 镍 矿 也 被 收 归 国 有 化 。";
			if (a.IsSocialism(yes: true, 21))
			{
				text += "新 生 的 红 色 法 国 不 仅 就 殖 民 时 期 的 恶 果 向 卡 纳 克 人 民 共 和 国 表 示 了 歉 意 ， 并 决 定 提 供 力 所 能 及 的 帮 助 ， 同 时 宣 布 从 余 下 的 南 太 平 洋 ， 非 洲 和 加 勒 比 海 的 海 外 领 地 逐 步 撤 出";
				a.allcountries[154].Gosstroy = 1;
				a.allcountries[154].SubGosstroy = 1;
				a.allcountries[154].LeaveAlliances();
				a.allcountries[154].name = "卡 纳 克 人 民 共 和 国";
				a.allcountries[154].proprc = true;
				a.allcountries[154].Torg = true;
				a.influencePRC += 10;
				a.empires[0].power -= 10;
				a.empires[0].relations -= 70;
			}
			else if (a.allcountries[21].Gosstroy == 0 && a.allcountries[21].SubGosstroy != 0)
			{
				text = "涅 槃 重 生 的 法 兰 西 当 然 拒 绝 了 彻 底 撤 出 的 方 案 ， 不 仅 对 独 立 的 共 和 国 展 开 了 禁 运 ， 并 在 其 余 的 海 外 领 土 彻 底 镇 压 分 离 主 义 分 子 。";
				a.allcountries[154].Gosstroy = 2;
				a.allcountries[154].SubGosstroy = 15;
				a.allcountries[154].LeaveAlliances();
				a.allcountries[154].name = "“ 卡 纳 克 共 和 国 ”";
				a.empires[0].power -= 10;
			}
			else if (a.allcountries[21].SubGosstroy == 10)
			{
				text = "新 生 的 法 国 政 权 提 出 了 奇 怪 的 解 决 方 案 ， 宣 称 为 了 第 三 世 界 的 彻 底 革 命 ， 法 国 将 与 其 余 的 海 外 领 地 达 成 联 邦 关 系 ， 一 切 都 依 托 于 奇 特 的 民 族 毛 主 义 理 论 。 同 时 ， 新 喀 也 获 得 了 来 自 本 土 的 更 多 投 资 。";
				a.allcountries[154].Gosstroy = 0;
				a.allcountries[154].SubGosstroy = 10;
				a.allcountries[154].LeaveAlliances();
				a.allcountries[154].Vyshi = true;
				a.allcountries[154].name = "卡 纳 克 人 民 国 ";
				a.empires[0].power += 10;
			}
			if (a.allcountries[135].Gosstroy == 0)
			{
				text = "出 乎 意 料 又 意 料 之 中 ， 革 命 者 的 东 风 竟 被 西 风 压 过 。 彼 得 森 总 统 出 于 对 一 个 独 立 且 亲 红 色 阵 营 的 政 权 的 担 忧 ， 同 时 也 是 为 了 转 移 国 内 的 矛 盾 。 澳 大 利 亚 宣 布 对 新 喀 里 多 尼 亚 发 动 特 别 维 护 和 平 行 动 。 接 近 3 0 0 0 人 的 大 军 坐 着 登 陆 艇 和 直 升 机 从 努 美 阿 登 陆 ， 几 乎 可 以 被 形 容 为 是 “ 乌 合 之 众 ” 的 分 离 主 义 份 子 在 澳 大 利 亚 的 攻 势 下 一 触 即 溃 。 最 终 ， “ 卡 纳 克 人 民 共 和 国 临 时 政 府 ” 也 被 废 除 。 在 澳 大 利 亚 军 队 的 支 持 下 ， 保 卫 喀 里 多 尼 亚 在 （ 澳 大 利 亚 ） 共 和 国 内 联 盟 的 新 政 府 得 以 被 建 立 起 来 。||只 不 过 是 从 一 个 暴 君 的 手 上 滑 走 ， 落 入 另 一 个 暴 君 的 怀 里 罢 了 。";
				a.allcountries[154].Gosstroy = 0;
				a.allcountries[154].SubGosstroy = 7;
				a.allcountries[154].LeaveAlliances();
				a.allcountries[154].puppetOf = 21;
				a.allcountries[154].name = "“ 卡 纳 克 共 和 国 ”";
				a.empires[0].power += 10;
			}
		}
	}
}
