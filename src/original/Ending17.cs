using EndingsDLCDraft;
using UnityEngine;

public class Ending17 : EndingsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEnding(ref string name, ref string text)
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		if (a.resultOfEvents[424] == 1)
		{
			int num = 0;
			if (a.allcountries[86].isNATO && a.allcountries[86].isEU)
			{
				num = 1474;
			}
			else if (a.allcountries[86].isNATO)
			{
				num = 1475;
			}
			else if (a.allcountries[86].isEU)
			{
				num = 1476;
			}
			if (a.allcountries[86].SubGosstroy == 19)
			{
				name = GlobalScript.inst.new_events_text[1464];
				text = "面 向 哪 轮 太 阳||在 古 老 的 古 老 的 东 方 智 慧 的 点 拨 下 ， 左 翼 卡 洛 斯 主 义 者 得 以 更 好 的 施 展 拳 脚 。 借 以 中 国 古 代 哲 学 家 孟 子 的 “ 民 贵 君 轻 ” 理 论 ， 马 里 亚 诺 · 祖 菲 亚 得 以 在 “ 行 仁 政 ” 的 基 础 上 构 建 独 特 的 西 班 牙 人 民 君 主 主 义 ： 首 先 便 是 实 行 激 进 的 工 团 主 义 改 革 ， 旨 在 摧 毁 私 有 产 权 制 度 与 资 本 主 义 关 系 。 在 继 承 第 一 次 内 战 时 期 加 泰 罗 尼 亚 地 区 自 我 管 理 理 念 的 基 础 上 ， 马 里 亚 诺 · 祖 菲 亚 和 圣 地 亚 哥 · 卡 里 略 等 内 阁 成 员 开 始 构 建 实 质 上 的 “ 机 械 化 小 农 经 济 ” ： 该 制 度 将 卡 洛 斯 主 义 者 的 传 统 观 点 （ 如 原 教 旨 天 主 教 、 反 自 由 主 义 与 重 建 基 于 传 统 区 域 自 治 的 封 建 自 治 权 ） 与 南 斯 拉 夫 铁 托 主 义 的 劳 动 集 体 自 治 和 各 共 和 国 的 自 治 的 意 识 形 态 合 二 为 一 。 在 政 治 上 ， 雨 果 · 卡 洛 斯 不 仅 仅 是 西 班 牙 的 虚 位 国 家 元 首 ， 职 责 限 于 签 署 法 令 、 主 持 仪 式 ， 并 被 宣 传 为 “ 无 产 阶 级 与 传 统 的 桥 梁 ” 。 但 同 样 担 任 左 翼 卡 洛 斯 党 名 义 上 的 总 书 记 （ 而 执 行 书 记 则 是 总 理 ） ， “ 人 民 王 国 议 会 将 领 导 一 切 ” ！ 天 主 教 教 士 的 修 道 院 虽 被 没 收 ， 但 主 教 则 以 “ 西 班 牙 天 主 政 治 委 员 ” 之 称 再 度 粉 墨 登 场 ， 国 王 陛 下 和 首 相 阁 下 也 常 常 参 加 弥 撒 和 圣 餐 。 秘 密 警 察 “ 人 民 保 卫 总 局 ” 效 仿 东 德 斯 塔 西 ， 渗 透 工 会 ， 大 学 和 教 会 。 巴 斯 克 与 加 泰 罗 尼 亚 独 立 运 动 被 定 性 为 “ 被 帝 国 主 义 蛊 惑 的 分 裂 势 力 ” ， 其 主 要 领 导 人 流 放 至 加 那 利 群 岛 劳 改 营 。 官 方 理 论 家 宣 称 “ 君 主 制 是 西 班 牙 人 民 的 历 史 选 择 ， 与 社 会 主 义 本 质 相 通 ” ， 将 伊 莎 贝 拉 一 世 ， 卡 洛 斯 五 世 描 绘 为 “ 前 社 会 主 义 集 权 先 驱 ” ， “ 社 会 主 义 的 元 素 上 可 追 随 至 收 复 失 地 运 动 之 时 ” ； 而 更 令 人 惊 诧 的 还 要 数 该 国 对 佛 朗 哥 时 代 的 平 反 。 这 一 兼 收 并 蓄 的 意 识 形 态 的 实 行 ， 在 许 多 方 面 得 归 功 于 卡 洛 斯 · 雨 果 国 王 的 “ 卡 洛 斯 特 色 自 治 社 会 主 义 ” 。 西 班 牙 拒 绝 了 现 代 社 会 的 一 切 政 治 成 就 ， 并 否 认 启 蒙 时 代 与 法 国 革 命 时 期 的 基 本 理 念 。||君 主 布 尔 什 维 克 主 义 的 西 班 牙 ， 是 一 座 在 冷 战 裂 隙 中 拔 地 而 起 的 “ 红 色 城 堡 ” — — 其 以 君 主 制 缝 合 传 统 与 革 命 ， 以 “ 独 立 自 主 的 经 济 ” 苟 活 于 世 界 边 缘 ， 最 终 在 未 曾 涉 足 的 领 域 中 走 入21 世 纪 。 这 一 实 验 也 许 将 证 明 ：|<color=red> 将 皇 冠 与 镰 锤 焊 接 ， 只 会 锻 造 出 刺 穿 自 身 的 枷 锁 。</color>";
			}
			else if (a.allcountries[86].SubGosstroy == 3)
			{
				name = GlobalScript.inst.new_events_text[1464];
				text = string.Format(GlobalScript.inst.new_events_text[1465], "\n");
			}
			else if (a.resultOfEvents[427] == 0 && a.event_done[427])
			{
				name = GlobalScript.inst.new_events_text[1466];
				text = string.Format(GlobalScript.inst.new_events_text[1467], "\n");
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(144);
				}
			}
			else if (a.resultOfEvents[427] == 1)
			{
				name = GlobalScript.inst.new_events_text[1468];
				text = string.Format(GlobalScript.inst.new_events_text[1469], "\n");
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(145);
				}
			}
			else if (a.resultOfEvents[427] == 2)
			{
				name = GlobalScript.inst.new_events_text[1470];
				text = string.Format(GlobalScript.inst.new_events_text[1471], "\n");
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					gameObject.GetComponent<achievements>().Set(146);
				}
			}
			else if (a.allcountries[86].isNATO)
			{
				name = GlobalScript.inst.new_events_text[1472];
				text = string.Format(GlobalScript.inst.new_events_text[1473], "\n", (num > 0) ? GlobalScript.inst.new_events_text[num] : null);
			}
			else
			{
				name = GlobalScript.inst.new_events_text[1490];
				text = GlobalScript.inst.new_events_text[1491];
			}
			return;
		}
		int num2 = 0;
		if (a.allcountries[109].parts[0] && a.allcountries[110].parts[0])
		{
			num2 = 1487;
		}
		else if (a.allcountries[109].parts[0])
		{
			num2 = 1488;
		}
		else if (a.allcountries[110].parts[0])
		{
			num2 = 1489;
		}
		if (a.allcountries[86].SubGosstroy == 7)
		{
			name = GlobalScript.inst.new_events_text[1477];
			text = string.Format(GlobalScript.inst.new_events_text[1478], "\n", (num2 > 0) ? GlobalScript.inst.new_events_text[num2] : null);
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(147);
			}
		}
		else if (a.allcountries[86].SubGosstroy == 1)
		{
			name = GlobalScript.inst.new_events_text[1479];
			text = string.Format(GlobalScript.inst.new_events_text[1480], "\n", (num2 > 0) ? GlobalScript.inst.new_events_text[num2] : null);
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(150);
			}
		}
		else if (a.allcountries[86].SubGosstroy == 11)
		{
			name = GlobalScript.inst.new_events_text[1481];
			text = string.Format(GlobalScript.inst.new_events_text[1482], "\n", (num2 > 0) ? GlobalScript.inst.new_events_text[num2] : null);
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(149);
			}
		}
		else if (a.allcountries[86].SubGosstroy == 3)
		{
			name = GlobalScript.inst.new_events_text[1479];
			text = " 社 会 主 义 者 的 复 仇|| 西 班 牙 工 人 社 会 党 内 左 翼 势 力 的 显 著 增 强 改 变 了 一 切 。 弗 朗 西 斯 科 · 布 斯 特 洛 领 导 的 新 政 府 奉 行 修 正 马 克 思 主 义 的 意 识 形 态 ， 并 将 其 与 6 8 运 动 以 来 自 由 意 志 主 义 的 新 左 派 意 识 形 态 融 合 ， 形 成 了 一 种 自 治 社 会 主 义 ， 开 启 了 社 会 转 型 ： 政 治 层 面 ， 工 会 活 动 得 到 国 家 鼓 励 ， 国 家 权 力 与 行 政 管 理 也 开 始 实 现 分 权 ， 并 被 联 邦 化 ； 经 济 层 面 ， 经 济 管 理 实 现 民 主 化 ， 由 职 工 和 资 方 的 委 员 会 共 同 民 主 管 理 企 业 ， 国 民 经 济 关 键 部 门 均 被 收 归 国 营 ， 税 收 与 社 会 政 策 均 实 现 了 改 订 ， 通 过 拓 展 社 会 保 障 网 ， 并 实 行 累 进 税 制 ， 新 政 府 得 以 显 著 提 升 人 民 生 活 水 平 ， 建 设 福 利 国 家 。 同 时 ， 新 政 府 努 力 推 进 女 权 主 义 、 环 保 主 义 与 反 核 武 等 议 程 ， 努 力 推 进 社 会 进 步 。|| 工 人 社 会 党 也 对 自 身 进 行 了 改 革 ， 使 得 政 党 能 够 更 加 融 入 民 众 ， 进 行 社 会 动 员 ； 党 本 身 也 从 中 央 集 权 转 为 更 加 自 治 化 和 分 权 化 的 形 态 ， 应 该 避 免 滑 向 为 领 导 人 服 务 。|| 政 治 改 革 更 是 深 刻 改 变 了 西 班 牙 的 政 治 面 貌 — — 自 由 派 政 党 事 实 上 已 经 出 局 ， 这 导 致 他 们 成 为 了 新 制 度 的 局 外 人 。 西 班 牙 开 始 遵 循 更 为 民 主 ， 强 调 地 方 与 区 域 当 局 、 乃 至 公 共 组 织 与 国 家 当 局 积 极 互 动 的 原 则 ， 并 将 国 家 改 制 为 联 邦 制 。 正 因 如 此 ， 社 会 主 义 者 得 以 在 西 班 牙 引 入 直 接 民 主 的 要 素 ， 对 代 议 制 议 会 架 构 予 以 迎 头 痛 击 。|| 来 自 第 二 共 和 国 时 代 社 会 党 人 的 理 想 ， 终 于 照 进 了 现 实 。|| ";
			if (num2 > 0)
			{
				text += GlobalScript.inst.new_events_text[num2];
			}
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(150);
			}
		}
		else if (a.allcountries[86].SubGosstroy == 16)
		{
			name = GlobalScript.inst.new_events_text[1479];
			text = " 共 产 主 义 者 的 复 仇|| 西 班 牙 共 产 党 内 正 统 派 势 力 的 显 著 增 强 改 变 了 一 切 。 伊 格 纳 西 奥 · 加 列 戈 领 导 的 新 政 府 奉 行 亲 苏 的 正 统 派 马 克 思 列 宁 主 义 的 意 识 形 态 ， 开 启 了 社 会 改 造 。 共 产 党 人 依 托 工 人 阶 级 和 控 制 的 工 会 力 量 ， 成 立 了 赤 卫 队 ， 直 接 开 展 “ 无 产 阶 级 专 政 ” ， 对 垄 断 资 产 阶 级 实 施 抓 捕 ， 大 批 企 业 被 直 接 国 有 化 ， 小 型 企 业 则 被 合 作 化 ， 个 体 经 营 户 被 允 许 继 续 运 营 。 国 家 通 过 建 立 国 家 计 委 对 全 国 生 产 进 行 规 划 。 在 农 村 ， 土 地 改 革 的 成 功 开 展 使 得 农 村 能 够 成 立 发 达 的 机 械 化 农 业 合 作 社 ， 并 依 托 于 合 作 社 建 立 社 区 。 新 政 府 在 文 化 策 略 上 吸 收 了 社 会 主 义 现 实 主 义 ， 鼓 励 左 翼 文 化 作 品 。 与 此 同 时 ， 西 班 牙 开 启 了 政 治 改 革 ， 军 队 被 改 造 为 党 领 导 的 人 民 军 ， 议 会 被 解 散 ， 取 而 代 之 的 是 仿 造 德 意 志 民 主 共 和 国 制 度 的 人 民 议 会 ； 西 班 牙 各 民 族 的 地 位 被 规 定 完 全 平 等 并 建 立 自 治 建 制 。 不 能 同 当 局 合 作 的 政 党 被 取 缔 ， 托 洛 茨 基 主 义 、 反 修 正 主 义 等 反 对 派 共 产 主 义 组 织 则 被 边 缘 化 ， 其 余 政 党 被 分 配 席 位 进 入 人 民 议 会 。 伊 格 纳 西 奥 · 加 列 戈 主 席 宣 布 要 深 化 与 苏 联 和 东 方 阵 营 的 兄 弟 们 的 友 谊 ， 同 他 们 达 成 了 深 度 的 合 作 。|| 自 第 二 共 和 国 时 代 以 来 正 统 派 共 产 党 人 的 愿 景 终 于 照 进 了 现 实 。||";
			if (num2 > 0)
			{
				text += GlobalScript.inst.new_events_text[num2];
			}
		}
		else if (a.allcountries[86].SubGosstroy == 5)
		{
			name = GlobalScript.inst.new_events_text[1483];
			text = string.Format(GlobalScript.inst.new_events_text[1484], "\n", (num2 > 0) ? GlobalScript.inst.new_events_text[num2] : null);
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(148);
			}
		}
		else if (a.allcountries[86].SubGosstroy == 15)
		{
			name = GlobalScript.inst.new_events_text[1485];
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				gameObject.GetComponent<achievements>().Set(146);
			}
			text = string.Format(GlobalScript.inst.new_events_text[1486], "\n", (num2 > 0) ? GlobalScript.inst.new_events_text[num2] : null);
		}
		else
		{
			name = GlobalScript.inst.new_events_text[1490];
			text = GlobalScript.inst.new_events_text[1491];
		}
	}
}
