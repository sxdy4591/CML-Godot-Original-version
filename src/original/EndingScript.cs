using UnityEngine;

public class EndingScript : MonoBehaviour
{
	private GlobalScript global1;

	public new TextMesh name;

	public TextMesh text_t;

	public bool is_left;

	public bool is_right;

	public bool names;

	public EndingScript another_one;

	public int number_of_e;

	public SpriteRenderer fon;

	public Sprite fon_win;

	public string[] second_names = new string[41];

	public string[] first_names = new string[41];

	private string fake_text;

	public Sprite on_1;

	public Sprite off_1;

	private GameObject achieves;

	public GameObject scrollComponent;

	private float startTextPosition;

	private float startNamePosition;

	private void Awake()
	{
		global1 = GlobalScript.inst;
		achieves = GameObject.Find("Ach(Clone)");
		startTextPosition = text_t.transform.position.y;
		startNamePosition = name.transform.position.y;
		DoneEnding();
	}

	private void OnMouseEnter()
	{
		if (is_left || is_right)
		{
			GetComponent<SpriteRenderer>().sprite = on_1;
		}
	}

	private void OnMouseExit()
	{
		if (is_left || is_right)
		{
			GetComponent<SpriteRenderer>().sprite = off_1;
		}
	}

	private void DoneEnding()
	{
		if (GlobalScript.inst.gameState.data[35] <= 0)
		{
			if (!is_left && !is_right)
			{
				ledaer_na();
				fon.sprite = fon_win;
				Check_Chekc_Check();
				GoodEnd();
				Object.Destroy(GetComponent<EndingScript>());
			}
		}
		else if (is_left || is_right)
		{
			Object.Destroy(base.gameObject);
		}
		else
		{
			BadEnding();
			Object.Destroy(GetComponent<EndingScript>());
		}
	}

	private void GoodEnd()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			if (GlobalScript.inst.gameState.data[5] < 100 && GlobalScript.inst.gameState.influencePRC < 50 && GlobalScript.inst.gameState.data[14] >= 5 && GlobalScript.inst.gameState.data[67] > 0 && GlobalScript.inst.gameState.data[66] > 0 && GlobalScript.inst.gameState.data[65] <= 0 && GlobalScript.inst.gameState.data[62] <= 0)
			{
				flag = true;
				name.text = "失 乐 园 ： 天 命 尽 失";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "执 掌 国 政 的 时 代 将 以 “ 另 起 炉 灶 ” 的 大 名 流 传 于 世 ： 仅 在 短 短 数 年 内 便 彻 底 扭 转 自 中 国1949 年 以 来 的 既 定 路 线 ， 将 革 命 风 尚 、 偶 像 崇 拜 等 一 切 涉 及 “ 邪 恶 帝 国 ” 的 建 制 遗 产 一 扫 而 空 ， 从 而 实 现 了 现 代 自 由 主 义 制 度 在 中 国 境 内 的 “ 大 跃 进 ” 。 当 然 ， 同 样 的 名 词 也 意 味 着 同 样 的 问 题 ： 缺 乏 公 民 社 会 与 替 代 候 选 的 社 会 现 实 只 能 使 其 配 套 的 选 举 制 度 持 续 不 断 地 产 出 党 员 起 家 的 地 方 豪 强 与 政 治 家 族 ； 急 速 转 向 市 场 经 济 最 终 以 建 立 无 制 度 管 控 环 境 ， 为 官 商 勾 结 、 走 私 集 团 与 勾 结 海 外 的 中 版 黑 手 党 创 建 黄 金 时 代 而 落 幕 ： 中 外 合 资 企 业 与 本 土 寡 头 成 为 了 资 产 改 组 内 的 赢 家 ， 并 通 过 粉 碎 工 会 、 空 前 压 榨 劳 动 力 、 彻 底 废 除 工 时 与 滥 用 派 遣 制 度 、 乃 至 甘 心 接 受 国 际 分 工 计 划 ， 无 度 出 口 工 业 原 料 与 初 级 商 品 的 方 式 成 功 将 该 国 转 换 为 极 端 外 向 经 济 体 ， 这 一 进 程 自 使 其 在 国 际 贸 易 与 外 国 投 资 内 赚 得 盆 满 钵 满 。 与 之 相 对 的 则 是 生 活 中 水 生 火 热 内 的 中 国 居 民 ： 失 业 潮 、 社 保 制 度 瓦 解 与 社 会 服 务 设 施 私 有 化 三 者 共 同 创 造 了 普 遍 贫 困 的 极 端 社 会 ， 绝 大 多 数 地 区 的 退 化 程 度 甚 至 可 直 接 向 民 国 时 代 看 齐 — — 棚 户 区 在 全 国 遍 地 开 花 ； 日 出 而 作 ， 日 落 而 息 的 生 活 方 式 变 为 全 国 常 态 ； 以 及 时 不 时 传 出 的 饿 毙 、 累 毙 等 非 正 常 死 亡 事 件 。 逐 年 走 高 的 联 合 国 人 道 主 义 援 助 款 项 也 只 能 遵 循 马 太 效 应 ， 充 盈 本 就 富 裕 者 的 腰 包 。 对 边 疆 地 区 的 松 懈 与 自 由 化 很 快 便 转 化 为 彻 底 的 责 任 剥 离 ， 其 结 果 便 是 诸 大 国 笑 纳 了 权 力 转 移 ， 甚 至 深 入 中 国 地 区 指 手 画 脚 ： 就 在 美 国 成 功 签 下 租 借 上 海 与 苏 州 港 区99 年 协 定 的 次 日 ， 苏 联 大 使 便 带 上 了 重 新 讨 论 蒙 古 地 区 问 题 、 中 东 路 债 务 重 组 与 协 力 开 发 东 北 的 相 关 意 见 走 入" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "的 总 统 办 公 室 ， 然 后 则 是 包 括 日 本 、 法 国 等 在 内 的 “ 长 江 经 济 带 建 设 计 划 ” … … “ 自 由 的 代 价 不 过 一 代 ， 不 自 由 的 代 价 则 延 续 世 代 ” — — 希 望 如 此 ， 也 只 能 如 此 ， 毕 竟 该 政 权 也 只 能 靠 时 间 流 逝 来 不 断 自 证 其 “ 存 在 合 理 性 ” ， 并 怀 抱 或 惊 喜 ， 或 担 忧 的 心 情 迎 接 能 在 根 本 上 改 变 慢 性 死 亡 现 状 的 “ 历 史 转 折 ” 。 至 于 究 竟 是 中 国 人 民 又 一 次 站 起 ， 还 是 彻 底 沦 为 棋 子 一 败 涂 地 ， 那 便 是 另 一 个 值 得 探 讨 的 问 题 了 。";
			}
			else if (GlobalScript.inst.gameState.leader.name_1 == 2 && GlobalScript.inst.gameState.leader.name_2 == 2 && GlobalScript.inst.gameState.data[56] == 0 && GlobalScript.inst.gameState.resultOfEvents[503] != 0)
			{
				flag = true;
				name.text = "  没 头 脑 与 不 高 兴 ";
				fake_text = "自 毛 泽 东 的 门 徒 之 间 的 战 斗 结 束 后 ， 作 为 “ 最 好 的 学 生 ” 的 华 国 锋 虽 然 继 续 掌 握 着 中 国 的 最 高 权 力 ， 但 那 些 他 认 为 早 应 该 在 十 二 大 会 议 后 偃 旗 息 鼓 的 极 左 派 们 似 乎 并 没 有 选 择 放 弃 ， 他 们 所 期 望 的 如 同1966 年 般 热 烈 的 革 命 洪 流 虽 未 出 现 ， 可 百 足 之 虫 死 而 不 僵 ， 受 到 打 击 的 极 左 派 通 过 各 种 手 段 再 次 在 人 民 大 会 堂 里 站 稳 脚 跟 并 处 处 给 华 国 锋 政 府 添 堵 ， 即 使 他 们 没 有 能 力 靠 自 己 夺 取 中 国 的 最 高 政 权 ， 但 也 可 以 通 过 “ 合 法 斗 争 ” 的 手 段 在 中 国 推 行 一 些 “ 革 命 的 ” 政 策 。 由 此 ， 中 国 戏 剧 性 的 形 成 了 有 本 国 特 色 的 “ 两 党 制 ” ， 这 带 来 了 一 种 奇 怪 政 治 与 言 论 解 冻 ， 政 府 官 员 间 的 骂 战 开 始 公 开 出 现 在 各 大 报 刊 ， 到 了 重 要 会 议 时 ， 持 不 同 观 点 的 参 会 人 员 自 发 的 分 开 坐 在 大 会 堂 的 左 右 两 旁 ， 每 一 个 决 策 通 过 前 ， 都 少 不 了 左 右 两 边 的 激 烈 辩 驳 甚 至 是 争 吵 ， 这 一 定 程 度 上 导 致 了 决 策 效 率 的 降 低 、 媒 体 宣 传 与 实 际 政 策 的 割 裂 以 及 部 分 地 方 主 义 的 产 生 。 这 种 怪 诞 的 景 象 令 一 些 人 联 想 起 法 国 大 革 命 时 制 宪 会 议 的 场 景 … … 总 而 言 之 ， 党 的 分 裂 对 于 群 众 来 说 已 经 是 公 开 的 秘 密 了 ， 虽 然 所 有 人 都 坚 定 的 表 示 自 己 永 远 归 属 于 中 国 共 产 党 … …||最 终 华 国 锋 在 维 稳 上 的 无 能 还 是 把 自 己 落 了 个 里 外 不 是 人 的 下 场 ， 党 的 十 四 大 后 他 便 被 请 出 了 权 力 宝 座 ， 被 另 一 个 更 能 左 右 逢 源 的 党 员 替 代 。 有 趣 的 是 ， 当 时 间 来 到 了2002 年 ， ";
				if (GlobalScript.inst.gameState.resultOfEvents[25] == 1 || GlobalScript.inst.gameState.resultOfEvents[26] == 1)
				{
					fake_text += "一 名 《 时 代 》 周 刊 的 记 者 特 地 来 到 中 国 ， 采 访 了 张 春 桥 — — 这 位 曾 经 红 极 一 时 后 来 得 以 身 免 的 极 左 派 重 要 人 物 兼 文 革 理 论 家 ， 在 话 题 谈 及 对 华 国 锋 的 评 价 时 ， 这 位 左 派 的 老 智 者 背 靠 摇 椅 给 记 者 讲 了 这 么 一 件 趣 事 : |<color=red>“ … 有 一 回 我 梦 到 了 毛 主 席 ， 看 到 他 老 人 家 站 在 长 江 的 出 海 口 边 上 ， 我 问 他 为 什 么 会 在 这 ， 毛 主 席 答 我 说 : ‘ 在 等 华 国 锋 ， 我 怕 他 躲 进 海 里 ，  不 敢 认 账 了 ！ ’ 。 ”</color> ";
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[25] == 0 || GlobalScript.inst.gameState.resultOfEvents[26] == 0)
				{
					fake_text += "一 名 《 时 代 》 周 刊 的 记 者 特 地 来 到 中 国 ， 采 访 了 毛 远 新 — — 这 位 曾 经 的 极 左 派 重 要 人 物 兼 毛 主 席 的 侄 子 ， 他 曾 因 为 “ 四 人 帮 ” 问 题 而 锒 铛 入 狱 ， 在 话 题 谈 及 对 华 国 锋 的 评 价 时 ， 这 位 曾 经 的 文 革 闯 将 虽 早 无 当 年 的 锐 气 ， 但 仍 条 件 反 射 般 摇 摇 头 说 道 : |<color=red>“ … 华 国 锋 … 是 个 外 行 … ”</color> ";
				}
				else if (GlobalScript.inst.gameState.event_done[240])
				{
					fake_text += "中 国 共 产 党 的 路 线 之 争 最 终 落 幕 的 二 十 周 年 之 际 ， 一 名 《 时 代 》 周 刊 的 记 者 特 地 来 到 中 国 ， 采 访 了 江 青 — — 这 位 曾 经 红 极 一 时 的 极 左 派 重 要 人 物 兼 毛 主 席 的 妻 子 ， 在 话 题 谈 及 对 华 国 锋 的 评 价 时 ， 这 位 饱 经 风 霜 的 “ 红 都 女 王 ” 隔 着 呼 吸 机 不 紧 不 慢 的 说 了 一 句 ： |<color=red>“ … 没 想 到 水 平 这 么 低 … ”</color> ";
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
			{
				flag = true;
				name.text = " 失 去 的 只 是 世 界 ， 赢 得 的 只 有 锁 链";
				fake_text = " 全 党 全 军 紧 跟 战 无 不 胜 的 伟 大 领 袖" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 步 伐 ， 坚 决 扫 除 一 切 害 人 虫 。 左 倾 右 倾 ， 教 条 革 新 ， 统 统 肃 清 。 终 于 回 归 了 助 力 中 国 革 命 与 建 设 事 业 发 展 壮 大 的 执 政 初 心 与 力 量 之 源 ： 老 子 革 命 儿 应 继 承 ， 老 子 反 动 儿 应 造 反 。 过 去 的 实 践 证 明 了 出 身 好 的 绝 大 多 数 是 天 才 ， 就 该 成 为 领 导 全 体 中 国 人 民 的 先 锋 队 。 全 国 各 族 人 民 所 要 作 的 便 是 牢 记 上 述 基 本 原 理 ， 并 自 觉 将 其 落 到 开 拓 中 国 发 展 新 境 界 的 伟 大 实 践 中 。 此 后 ， 我 党 得 以 充 分 吸 取 王 莽 一 朝 的 “ 周 制 ” 伟 大 实 践 、 印 度 尼 西 亚 两 代 领 导 人 共 同 打 造 的 “ 建 国 五 基 ” 、 吴 奈 温 将 军 开 创 的 缅 甸 社 会 主 义 、 阿 拉 伯 复 兴 社 会 党 弘 扬 的 社 会 民 族 主 义 、 乃 至 我 国 文 化 大 革 命 期 间 由 谭 力 夫 同 志 发 扬 光 大 的 “ 血 统 论 ” 相 关 经 验 ； 以 “ 中 华 精 神 ， 国 家 主 义 ， 红 色 基 因 ” 作 为 抓 纲 治 国 总 方 略 ： 强 调 无 限 奉 献 与 无 限 崇 拜 领 袖 的 一 系 列 正 能 量 便 在 社 会 内 蔚 然 成 风 ， 并 得 到 武 装 到 牙 齿 的 民 团 与 各 武 装 部 队 的 助 力 。 全 体 国 民 也 纷 纷 拥 抱 新 时 代 核 心 价 值 观 ， 以 相 应 的 高 标 准 要 求 自 己 ： 每 日 工 作 均 需 请 示 ， 内 容 均 要 汇 报 ； 且 每 位 公 民 都 有 为 祖 国 组 建 家 庭 ， 生 儿 育 女 ， 参 与 周 末 义 务 劳 动 与 随 时 响 应 我 党 我 国 “ 征 召 ” 等 的 必 须 义 务 ； 离 世 后 也 需 以 自 愿 捐 献 器 官 的 形 式 回 馈 祖 国 供 养 。 不 适 宜 弘 扬 团 结 一 致 总 方 略 ， 以 民 间 淫 祭 、 私 立 教 派 与 地 下 教 会 为 代 表 的 旧 社 会 遗 毒 也 基 本 被 扫 除 殆 尽 。 与 此 同 时 ， 出 于 确 保 革 命 江 山 不 倒 ， 为 革 命 家 奋 斗 赋 予 充 实 底 气 的 需 要 。 我 们 以 魏 晋 品 评 制 、 英 国 贵 族 制 、 欧 美 推 荐 制 与 双 轨 教 学 等 为 原 型 ， 基 本 建 立 了 有 中 国 特 色 的 选 拔 分 工 机 制 ： 红 二 代 们 就 此 迅 速 拿 捏 国 家 机 器 内 最 大 肥 差 ， 并 成 长 为 对 国 政 财 政 一 言 九 鼎 的 新 一 代 领 导 集 体 ， 其 权 势 与 影 响 力 纵 横 各 地 ： “ 红 孩 儿 ” 们 主 导 建 立 了 一 系 列 注 重 革 命 性 与 纯 洁 性 的 公 社 体 系 ： 唯 有 得 到 高 层 党 员 认 可 的 国 民 才 可 加 入 其 中 ， 并 在 主 要 国 有 企 业 、 公 共 服 务 部 门 与 政 府 官 僚 机 构 内 有 所 作 为 ； 前 者 的 重 大 决 策 均 仰 仗 个 人 间 纽 带 联 系 与 密 室 政 治 方 式 做 出 ， 以 剥 离 潜 在 的 “ 民 粹 主 义 ” 与 “ 自 由 主 义 ” 污 染 。 最 终 保 障 他 们 对 政 策 制 定 、 军 事 指 挥 乃 至 文 化 教 育 领 域 方 面 说 一 不 二 的 领 导 地 位 。 然 而 ， 我 们 委 任 红 色 贵 族 实 现 自 我 革 命 ， 确 保 领 导 永 不 变 质 的 作 为 却 招 来 了 不 少 闲 人 的 妄 论 ： 他 们 竟 将 我 们 同 印 度 的 种 姓 制 、 同 欧 洲 黑 暗 中 世 纪 的 等 级 制 相 提 并 论 ， 并 开 动 宣 传 机 器 将 中 国 给 塑 造 成 了 国 际 怪 胎 。 但 在 团 结 一 心 的 全 体 国 民 ； 在 竭 诚 认 可 谈 奉 献 越 谈 境 界 越 高 ， 讲 待 遇 越 讲 境 界 越 低 ， 并 用 历 史 做 出 选 择 ， 向" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 表 达 无 限 崇 拜 ， 无 限 热 爱 的 中 国 人 民 面 前 。 所 有 的 诽 谤 都 只 是 境 外 势 力 与 人 民 公 敌 的 臆 想 ， 所 有 的 外 交 孤 立 也 只 是 暂 时 的 困 难 ， 不 是 吗 ？";
			}
			else if (GlobalScript.inst.gameState.is_gkchp)
			{
				flag2 = true;
				name.text = " 第 二 代 满 铁 马 克 思 主 义 的 黎 明 … …";
				fake_text = " 中 国 领 导 层 在 中 苏 边 界 的 决 定 性 军 事 行 动 彻 底 改 变 了 远 东 政 治 版 图 ， 并 在 基 本 恢 复 了19 世 纪 时 清 朝 北 部 疆 域 的 同 时 空 前 削 弱 了 苏 联 在 亚 洲 地 区 的 军 事 存 在 。 然 而 ， 试 图 对 “ 历 史 故 地 ” 恢 复 主 权 的 做 法 并 非 一 帆 风 顺 。 毕 竟 ， 作 为 中 方 宣 称 领 土 依 据 的 清 朝 政 府 都 未 曾 在 当 地 建 立 某 种 行 之 有 效 的 管 理 ， 也 不 曾 有 所 谓 “ 文 化 、 心 理 或 血 统 ” 渊 源 。 意 味 着 中 国 只 能 从 零 开 始 在 当 地 建 立 自 身 的 新 秩 序 ， 而 这 更 是 导 致 了 后 续 的 一 系 列 连 锁 反 应 ： 虽 说 原 属 前 滨 海 边 疆 区 与 前 哈 巴 罗 夫 斯 克 边 疆 区 等 地 的 阿 穆 尔 河 流 域 领 土 得 以 “ 相 对 顺 利 ” 地 被 分 别 并 入 吉 林 与 黑 龙 江 ， 最 大 限 度 地 保 留 了 中 国 行 政 规 划 的 原 汁 原 味 ； 但 在 族 群 格 局 错 综 复 杂 ， 跨 境 文 化 与 宗 教 情 绪 盛 行 ， 且 直 接 作 为 军 事 冲 突 前 线 的 西 北 地 区 ， 局 势 则 变 得 相 当 复 杂 ： 由 于 苏 联 的 撤 退 与 中 国 在 当 地 尚 未 建 立 新 秩 序 的 客 观 现 实 ， 区 域 民 族 主 义 情 绪 很 快 便 取 得 了 攻 城 略 地 良 机 。 并 常 以 异 见 团 体 与 游 击 武 装 的 形 式 持 续 挑 战 中 国 在 当 地 组 建 的 新 官 僚 部 门 。 因 此 ， 这 种 整 合 事 实 上 导 致 了 新 疆 “ 自 治 区 ” 概 念 终 结 ， 并 被 军 事 管 制 色 彩 浓 烈 的 “ 新 疆 军 区 ” 取 而 代 之 ： 当 地 参 照 苏 联 封 闭 城 市 的 模 式 彻 底 关 闭 了 边 界 ， 并 严 格 控 制 人 口 与 物 资 流 动 。 包 括 罗 布 泊 在 内 的 大 荒 漠 也 得 以 完 全 转 化 为 军 方 的 练 兵 场 、 实 验 室 与 流 放 地 ， 事 实 上 成 为 了 中 国 境 内 的 国 中 之 国 。||当 然 ， 边 疆 地 区 的 变 异 只 是 中 国 社 会 变 化 的 开 端 — — 空 前 的 军 事 胜 利 事 实 上 创 造 了 中 国 军 队 不 可 战 胜 的 神 话 ， 并 以 军 事 特 区 与 长 期 维 稳 需 求 空 前 夯 实 了 军 方 主 要 领 导 人 的 政 治 前 途 ： 需 要 持 续 维 稳 的 新 边 疆 与 北 方 对 手 的 压 力 成 为 了 他 们 无 度 扩 张 自 身 势 力 与 职 权 的 借 口 ， 与 之 相 关 的 军 事 工 业 复 合 体 也 跟 着 一 路 膨 胀 。 大 有 绑 架 全 国 之 势 。 今 后 则 极 有 可 能 形 成 一 种 全 新 的 先 军 政 治 体 制 。 更 值 得 关 注 的 则 是 新 时 代 版 本 的 “ 闯 关 东 ” — — 怀 揣 着 所 谓 “ 爱 国 主 义 ” 、 “ 广 阔 天 地 ” 或 “ 奋 斗 致 富 ” 的 情 怀 ， 且 得 到 了 国 家 政 策 背 书 的 内 地 移 民 （ 主 要 是 东 部 城 市 内 的 失 业 人 口 ） 正 开 始 急 速 向 北 迁 徙 ， 并 在 军 方 的 掩 护 下 逐 渐 在 新 边 疆 的 移 民 城 市 内 创 造 出 全 新 的 殖 民 者 文 化 。 代 价 自 不 必 多 言 … … 有 人 已 将 此 情 此 景 同 彼 时 日 本 知 识 分 子 主 张 以 “ 先 进 科 学 改 造 落 后 地 区 ” ， “ 先 进 带 动 后 进 ” ， “ 实 现 王 道 乐 土 ” 的 满 铁 马 克 思 主 义 ， 乃 至 其 试 验 田 溥 仪 傀 儡 政 府 相 提 并 论 。 谁 知 道 未 来 会 如 何 … …||放 眼 全 球 ， 中 国 的 胜 利 也 在 改 变 自 身 的 同 时 对 国 际 社 会 主 义 阵 营 做 了 “ 再 定 义 ” ， 苏 式 社 会 主 义 就 此 颜 面 扫 地 ， 而 中 国 社 会 主 义 则 荣 获 包 括 “ 社 会 帝 国 主 义 ” 帽 子 在 内 的 一 切 关 注 。 然 而 ， 这 份 胜 利 果 实 似 乎 只 能 局 限 于 靠 军 事 胜 利 大 赢 特 赢 的" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "一 代 。 后 来 人 则 只 能 活 在 前 辈 的 阴 影 与 无 底 线 的 马 基 雅 维 利 主 义 下 。 而 在 中 国 的 势 力 范 围 内 ， 基 于 实 用 主 义 观 点 的 的 亲 中 派 与 热 心 新 版 “ 维 也 纳 仲 裁 ” 的 民 族 共 产 主 义 者 也 开 始 借 题 发 挥 ， 同 在 中 国 势 力 范 围 外 游 离 的 仅 有 “ 主 权 国 家 ” 们 打 得 不 可 开 交 。 “ 眼 泪 不 能 带 给 人 自 由 ， 只 有 强 者 才 能 征 服 世 界 ” 的 信 条 正 越 加 受 到 欢 迎 … … 可 是 ， 这 到 底 是 哪 一 种 人 的 世 界 观 呢 ？";
			}
			else if (GlobalScript.inst.gameState.modifies[38].active)
			{
				flag3 = true;
				name.text = " 共 和 国 内 当 奥 古 斯 都";
				fake_text = " 出 身 自 明 朝 开 国 皇 帝 明 太 祖 朱 元 璋 第 十 八 子 岷 庄 王 朱 楩 后 裔 的 朱 镕 基 很 快 便 通 过 一 系 列 权 力 运 作 实 现 了 自 身 的 霸 权 ， 并 通 过 合 法 手 段 与 《 宪 法 》 框 架 实 现 了 党 政 军 三 权 一 把 抓 。 如 今 的 他 在 兼 任 国 内 最 大 政 党 党 魁 、 三 军 统 帅 与 国 家 元 首 的 同 时 威 压 国 务 院 与 人 大 ， 将 后 者 变 成 了 收 编 效 忠 派 的 套 子 与 装 裱 民 主 形 式 的 橡 皮 图 章 ； 并 可 通 过 类 似 魏 玛 共 和 国 的 制 度 设 计 在 国 家 进 入 “ 非 常 状 态 ” 时 实 行 领 袖 独 断 。 该 国 的 政 治 生 活 也 由 此 沾 染 上 了 朱 镕 基 个 人 的 烙 印 ： 聚 拢 中 国 国 内 政 治 元 老 与 朱 镕 基 亲 自 提 拔 技 术 官 僚 的 “ 中 央 顾 问 委 员 会 ” 与 主 管 经 济 事 宜 的 “ 发 展 与 改 革 委 员 会 ” 实 际 上 成 为 该 国 最 主 要 的 决 策 部 门 ， 并 通 过 发 展 党 管 干 部 与 扩 展 强 力 机 关 两 套 做 法 强 力 推 行 改 革 政 策 ： 他 们 通 过 操 纵 人 事 、 委 派 可 靠 官 员 与 清 洗 腐 败 官 僚 的 方 式 对 国 有 企 业 与 地 方 政 府 进 行 改 组 ， 最 终 实 现 政 企 分 离 、 优 化 财 报 并 贯 彻 经 济 核 算 与 企 业 自 主 经 营 、 自 由 竞 争 的 系 列 原 则 ； 并 通 过 综 合 行 政 压 制 与 丰 富 市 场 消 费 品 两 大 手 腕 培 育 效 忠 于 现 政 府 的 新 一 代 公 务 员 与 中 产 阶 级 ， 从 而 最 大 限 度 地 分 化 社 会 群 体 ， 并 抑 制 削 减 补 贴 、 砸 碎 铁 饭 碗 与 结 束 企 业 办 社 会 等 老 制 度 的 影 响 。 中 国 就 此 走 上 了 一 条 类 似 东 亚 同 行 的 威 权 发 展 主 义 改 革 之 路 ， 其 领 导 人 也 顺 势 被 冠 以 “ 当 代 亚 历 山 大 二 世 ” 与 “ 东 方 斯 托 雷 平 ” 之 名 。 国 际 社 会 已 用 “ 共 青 团 员 沙 皇 的 监 护 ” 一 词 概 括 中 国 的 现 行 制 度 ， 并 将 朱 镕 基 同 古 代 中 国 皇 帝 相 提 并 论 ： 毕 竟 ， 后 者 的 各 种 做 法 都 能 从 古 代 统 治 者 设 置 内 廷 绕 开 外 朝 ， 提 拔 仅 对 皇 帝 一 人 负 责 的 “ 帝 党 官 僚 ” ， 热 心 密 室 政 治 与 秘 书 代 行 君 主 意 志 等 诸 多 集 权 措 施 相 提 并 论 。 而 中 国 境 内 逐 渐 盛 行 的 天 人 合 一 情 结 与 个 人 崇 拜 现 象 只 会 让 其 显 得 更 加 毋 庸 置 疑 ： 不 少 智 库 、 社 会 组 织 与 地 方 文 化 团 体 已 在 其 活 动 条 文 中 将 朱 镕 基 本 人 同 “ 国 法 ” 相 提 并 论 ， 并 靠 着 发 改 委 的 政 治 名 录 与 国 家 基 金 接 受 来 自 “ 共 青 团 员 沙 皇 ” 的 赞 助 ， 由 此 形 成 了 围 绕 个 人 的 权 威 架 构 。 出 于 进 一 步 巩 固 社 会 稳 定 ， 确 保 改 革 大 局 的 需 要 。 朱 镕 基 很 自 然 地 走 上 了 一 条 宣 传 “ 稳 定 压 倒 一 切 ” 的 道 路 ， 在 将 国 民 党 起 义 与 文 化 大 革 命 打 上 历 史 耻 辱 柱 的 同 时 要 求 国 内 教 育 系 统 不 遗 余 力 地 批 判 古 代 民 变 、 近 代 军 阀 混 战 与 各 种 各 样 的 社 会 革 命 思 潮 。 流 言 蜚 语 随 之 而 起 — — 民 间 已 将 朱 镕 基 同 “ 壮 志 未 酬 ” 的 “ 洪 宪 皇 帝 ” 袁 世 凯 相 提 并 论 ， 并 不 惮 以 最 坏 的 心 思 揣 测 其 热 心 支 持 各 地 孔 庙 ， 并 参 加 民 俗 祭 典 等 文 化 活 动 的 动 机 。 谁 知 道 他 未 来 会 不 会 成 为 新 的 皇 帝 ？ 对 此 ， 朱 镕 基 只 是 在 接 受 意 大 利 传 媒 名 人 法 拉 奇 的 采 访 时 援 引 古 文 对 此 一 笑 了 之 — —||<color=red>“ 若 天 命 在 吾 ， 吾 愿 为 周 文 王 矣 ”</color>";
			}
			else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 18)
			{
				flag4 = true;
				name.text = " 永 远 的 革 命";
				fake_text = " 在" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 的 英 明 领 导 下 ， 我 们 的 列 宁 主 义 先 锋 队 终 于 恢 复 了 工 人 阶 级 应 有 的 领 导 地 位 ， 去 除 了 党 内 以 “ 毛 泽 东 ” 为 代 表 的 小 资 产 阶 级 和 农 民 习 气 的 流 毒 ， 无 产 阶 级 专 政 得 到 了 落 实 ， 堕 落 工 人 国 家 重 新 走 上 了 正 轨 。 鉴 于 革 命 形 势 的 发 展 ， 我 们 在 一 次 特 别 中 央 全 会 上 ， 将 党 名 改 为 了 中 国 共 产 党 列 宁 主 义 革 命 派 ， 象 征 着 我 们 党 不 断 革 命 的 决 心 。 我 们 开 始 民 主 计 划 经 济 的 实 践 ： 国 营 企 业 纷 纷 成 立 了 工 人 委 员 会 或 职 工 委 员 会 ， 选 举 出 的 工 人 或 职 工 代 表 代 替 了 过 去 的 一 长 制 ， 人 民 公 社 则 在 考 察 当 地 现 实 情 况 的 基 础 上 ， 决 定 保 留 或 者 回 到 合 作 社 ， 当 然 ， 公 社 和 合 作 社 也 成 立 了 公 社 委 员 会 和 合 作 社 委 员 会 ， 选 举 出 的 农 民 代 表 代 替 了 过 去 的 社 长 和 主 任 。 我 们 的 计 划 经 济 也 利 用 了 价 值 规 律 ， 但 这 不 代 表 我 们 要 回 到 过 去 ， 通 过 民 主 选 举 产 生 的 计 划 经 济 委 员 会 ， 审 议 各 类 产 品 的 国 家 价 格 和 生 产 成 本 并 进 行 调 节 ， 制 定 并 投 票 通 过 全 国 的 经 济 计 划 和 财 政 预 算 。 企 业 和 公 社 合 作 社 的 收 入 大 部 分 上 缴 国 家 后 ， 剩 余 的 收 入 将 拿 来 提 高 工 作 单 位 群 众 的 集 体 福 利 。||在 列 宁 和 托 洛 茨 基 同 志 精 神 的 指 引 下 ， 我 们 在 无 产 阶 级 专 政 的 基 础 上 开 始 了 无 产 阶 级 民 主 实 践 ： 政 协 被 当 做 向 反 动 阶 级 妥 协 的 工 具 而 取 消 。 全 国 人 民 代 表 大 会 及 地 方 各 级 人 民 代 表 大 会 则 改 组 为 了 全 国 苏 维 埃 会 议 及 地 方 各 级 苏 维 埃 会 议 ， 并 开 放 了 直 选 。 我 们 党 和 其 他 无 产 阶 级 专 政 原 则 上 成 立 的 政 党 一 样 ， 要 参 与 全 国 苏 维 埃 会 议 和 地 方 各 级 苏 维 埃 会 议 的 选 举 ， 在 全 国 苏 维 埃 会 议 上 ， 我 们 以 马 克 思 列 宁 托 洛 茨 基 主 义 为 指 导 ， 将 苏 俄 早 期 宪 法 ， 中 国 国 情 以 及 不 断 革 命 原 则 结 合 起 来 ， 制 定 了 一 部 新 宪 法 ， 宪 法 将 国 名 从 中 华 人 民 共 和 国 修 改 为 中 华 社 会 主 义 共 和 国 ， 将 武 装 力 量 名 称 从 中 国 人 民 解 放 军 修 改 为 中 国 革 命 红 军 。 然 而 出 人 意 料 的 是 ， 即 使 小 资 产 阶 级 和 农 民 头 子 已 经 被 批 倒 批 臭 了 ， 一 个 名 叫 中 国 马 列 托 毛 主 义 共 产 党 的 政 党 最 近 依 然 在 全 国 苏 维 埃 会 议 上 异 军 突 起 ， 尽 管 他 们 自 称 “ 毛 泽 东 ” 和 托 洛 茨 基 在 反 对 官 僚 主 义 和 输 出 革 命 上 有 诸 多 共 同 点 ， 毛 派 和 托 派 应 该 联 合 起 来 ， 但 毫 无 疑 问 ， 他 们 是 利 用 了 人 民 的 怀 念 情 绪 获 得 了 大 量 选 票 ， 这 种 异 端 派 对 我 们 的 多 数 席 位 造 成 了 威 胁 ， 我 们 只 得 用 行 政 手 段 打 压 一 下 他 们 。||随 着 第 四 国 际 中 心 的 搬 来 ， 我 们 国 家 真 正 成 为 了 世 界 革 命 的 中 心 ， 全 球 各 地 的 托 洛 茨 基 主 义 者 和 进 步 人 士 纷 纷 来 到 我 们 国 家 交 流 学 习 ， 我 们 也 慷 慨 的 给 予 他 们 革 命 援 助 ， 让 他 们 推 翻 那 些 摇 摇 欲 坠 的 资 产 阶 级 政 府 ， 当 然 ， 我 们 人 民 福 祉 也 超 越 了 美 苏 ， 向 全 世 界 最 发 达 的 国 家 靠 齐 ， 马 克 思 列 宁 托 洛 茨 基 的 共 产 主 义 远 大 理 想 将 在 不 断 革 命 和 世 界 革 命 中 实 现 ！";
			}
			else if (GlobalScript.inst.gameState.modifies[11].active && GlobalScript.inst.gameState.data[14] <= 0 && GlobalScript.inst.gameState.data[54] <= 38 && GlobalScript.inst.gameState.science[26] && GlobalScript.inst.gameState.science[22] && GlobalScript.inst.gameState.data[71] >= 400 && GlobalScript.inst.gameState.data[72] >= 400 && GlobalScript.inst.gameState.data[4] <= 0 && GlobalScript.inst.gameState.politics_dolshnost[1] == 150 && GlobalScript.inst.gameState.politics_dolshnost[0] == 150)
			{
				flag5 = true;
				name.text = " 东 方 赛 博 朋 克";
				fake_text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					" 主 席 将 作 为 中 国 最 伟 大 的 领 导 人 之 一 被 铭 记 ， 他 跨 进 了 自 动 化 的 大 门 ， 并 将 中 国 引 入 了 黄 金 时 代 — — 即 使 是 全 能 的 苏 联 也 没 有 冒 险 这 么 做 。 归 功 于 几 十 个 控 制 论 者 和 数 百 万 能 够 实 现 中 国 伟 大 机 器 的 工 人 的 辛 勤 工 作 ， 中 国 的 经 济 实 现 了 现 代 化 。 党 对 它 的 抵 抗 被 消 灭 了 。 这 种 冒 险 的 想 法 产 生 了 巨 大 的 效 果 — — 腐 败 和 赤 字 几 乎 被 彻 底 消 除 ， 每 个 官 员 现 在 都 处 于 不 带 偏 见 的 电 子 控 制 之 下 ， 它 是 不 可 能 被 贿 赂 或 欺 骗 的 。 但 这 种 计 算 机 化 还 没 有 结 束 — — 由 于 进 一 步 推 出 电 子 护 照 和 社 会 评 级 系 统 ， 社 会 终 于 摆 脱 了 反 革 命 和 有 害 因 素 的 威 胁 ， 几 乎 没 有 人 背 离 计 划 和 项 目 的 实 施 。 但 是 … 现 在 机 器 无 处 不 在 ， 它 们 的 力 量 正 在 扩 大 … … 而 只 有 在 领 袖 不 合 时 宜 地 死 去 之 后 ， 党 和 人 民 似 乎 才 逐 渐 开 始 明 白 — — 谁 真 正 控 制 了 一 切 … …"
				});
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(60);
				}
			}
			else if (GlobalScript.inst.gameState.modifies[11].active && GlobalScript.inst.gameState.data[26] <= 0 && GlobalScript.inst.gameState.data[15] <= 6 && GlobalScript.inst.gameState.data[17] >= 19)
			{
				flag6 = true;
				name.text = " 迈 向 共 产 主 义 的 一 步";
				if (GlobalScript.inst.gameState.data[50] == 29)
				{
					name.text = " 从 天 上 到 凡 世 来 ！";
					fake_text = " 早 在 百 年 前 的 法 国 ， 宗 教 社 会 学 先 驱 埃 米 尔 · 杜 尔 凯 姆 便 指 出 了 宗 教 作 为 “ 社 会 秩 序 与 公 序 良 俗 ” 的 实 质 ， 并 尝 试 以 此 挽 救 法 兰 西 日 益 沦 落 的 公 民 道 德 。 同 期 活 跃 的 工 团 主 义 革 命 家 乔 治 · 索 雷 尔 也 热 心 从 神 话 与 教 会 的 严 密 组 织 形 式 中 汲 取 力 量 ， 为 革 命 做 准 备 。 而 如 今 的 各 国 更 是 在 利 用 宗 教 团 结 国 民 上 达 到 新 境 界 ： 苏 联 建 立 了 爱 国 正 教 会 ， 意 大 利 与 梵 蒂 冈 间 形 成 合 作 关 系 ， 美 国 更 是 用 “ 公 民 宗 教 ” 将 国 家 塑 造 为 现 世 神 明 ， 其 国 内 政 治 宣 誓 事 实 上 同 祷 告 无 异 … … 是 的 ， 所 有 的 一 切 都 已 向 我 们 展 示 说 ： 对 现 代 政 治 而 言 ， 宗 教 从 未 远 去 ， 也 没 必 要 远 去 。 世 俗 化 只 是 出 于 团 结 国 民 或 实 现 政 治 教 育 的 目 的 ， 用 党 与 国 家 的 公 民 教 条 对 教 义 崇 拜 偷 梁 换 柱 的 多 此 一 举 … … 我 们 为 什 么 要 另 起 炉 灶 呢 ？ 尤 其 在 我 国 切 实 存 在 对 中 国 人 民 的 伟 大 解 放 者 毛 泽 东 同 志 及 其 思 想 无 限 热 爱 与 崇 拜 的 背 景 下 … …||现 在 ， 我 们 已 彻 底 扭 转 先 前 将 国 内 主 要 宗 教 视 为 洪 水 猛 兽 的 观 念 ： 基 于 苏 联 早 期 组 织 “ 革 新 教 派 ” ， 波 兰 亲 社 会 主 义 天 主 教 团 体 “ 圣 像 派 ” 与 国 内 组 织 三 自 教 会 的 经 验 。 理 论 家 与 倾 心 中 国 革 命 事 业 的 宗 教 人 士 已 结 为 意 识 形 态 同 盟 ， 正 尝 试 以 “ 宗 教 与 社 会 主 义 社 会 ， 乃 至 社 会 主 义 本 身 相 适 应 ” 的 理 论 重 写 重 构 既 有 宗 教 体 系 。 并 借 助 社 会 自 由 化 的 风 潮 扶 持 新 一 批 红 色 教 会 ， 一 方 面 让 基 督 教 、 天 主 教 与 伊 斯 兰 社 会 主 义 者 领 导 的 相 关 组 织 承 担 提 供 社 会 服 务 、 实 现 工 人 治 厂 与 协 助 基 层 治 理 的 职 责 ， 并 同 我 党 正 力 行 的 “ 四 大 民 主 ” 与 民 兵 武 装 扩 大 化 的 政 策 实 现 对 接 ； 另 一 方 面 则 以 我 党 新 奉 行 的 “ 宗 教 信 仰 门 户 开 放 ” 政 策 为 契 机 ， 将 党 支 部 与 社 会 主 义 建 在 基 层 ， 以 打 入 主 义 改 造 各 类 宗 教 团 体 。 由 此 实 现 宗 教 与 政 治 身 份 的 融 合 ， 创 造 中 国 版 本 的 “ 宗 教 民 主 国 家 ” 。||而 对 于 中 国 本 土 的 民 间 信 仰 与 仪 式 ， 我 党 的 工 作 人 员 则 深 入 基 层 整 理 民 俗 崇 拜 类 型 ， 并 尝 试 将 其 同 既 有 政 策 实 现 融 合 ， 实 现 政 策 诠 释 的 神 圣 化 ： 有 赖 于 毛 主 席 的 革 命 遗 产 以 及 其 知 名 度 ， 这 一 进 程 本 身 相 当 顺 利 。 人 民 群 众 对 于 美 好 生 活 的 朴 素 愿 望 成 为 了 其 信 奉 社 会 主 义 的 动 机 。 有 关 毛 主 席 与 革 命 英 雄 们 解 放 全 国 的 传 说 已 融 入 儒 释 道 文 本 中 ， 并 同 关 公 、 诸 葛 亮 等 古 代 著 名 英 雄 们 共 享 香 火 … … 我 们 目 前 为 缩 短 工 时 ， 解 放 劳 动 而 建 立 的 自 动 化 系 统 I E C S 本 身 也 被 冠 以 “ 赛 博 圣 公 ” 之 名 ， 并 为 虔 诚 而 活 跃 的 武 装 修 会 所 保 护 ： 于 是 ， 基 于 控 制 论 逻 辑 运 行 的 民 主 也 能 自 然 而 然 地 开 展 起 来 ； 我 国 坚 持 不 断 革 命 ， 解 放 生 产 力 的 政 策 便 也 能 稳 步 推 进 … …||不 论 如 何 ， 我 们 确 实 做 到 了 堪 比 中 国 革 命 本 身 的 宏 大 事 业 ： 如 果 说 毛 主 席 做 到 了 让 太 阳 升 起 ， 那 我 们 便 做 到 用 神 圣 的 帷 幕 让 它 永 不 落 下 ！ 继 续 革 命 的 事 业 便 由 此 成 为 永 恒 ！";
				}
				else if (GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active)
				{
					fake_text = "  在 百 年 之 前 ， 马 克 思 、 恩 格 斯 向 我 们 描 绘 了 共 产 主 义 的 美 好 愿 景 ， 而 列 宁 、 斯 大 林 则 教 会 了 我 们 如 何 保 卫 社 会 主 义 政 权 。 如 今 ， 在 战 无 不 胜 的 毛 泽 东 思 想 的 指 引 下 ， 我 们 将 革 命 推 进 到 了 一 个 新 的 阶 段 。 我 们 成 功 地 保 卫 了 毛 主 席 的 遗 产 ， 在 社 会 生 活 的 方 方 面 面 掀 起 了 新 的 阶 级 斗 争 高 潮 。 而 这 数 十 年 来 当 中 的 运 动 、 斗 争 在 历 史 作 用 下 的 结 果 就 是 — — 无 产 阶 级 在 针 对 资 产 阶 级 复 辟 阴 谋 的 斗 争 当 中 大 获 全 胜 。|| 随 着 各 项 条 件 的 逐 步 成 熟 ， 我 们 得 以 进 一 步 推 进 无 产 阶 级 大 民 主 。 一 部 分 巴 黎 公 社 原 则 被 写 入 了 宪 法 当 中 ； 根 据 巴 黎 公 社 体 制 改 造 的 革 命 委 员 会 取 代 了 旧 有 的 行 政 架 构 ， 成 为 了 落 实 无 产 阶 级 专 政 的 神 兵 利 器 ； 而 自 发 组 建 的 造 反 派 群 众 组 织 则 根 据 《 十 六 条 》 的 经 验 保 留 了 相 当 程 度 的 弹 劾 权 和 在 社 会 层 面 进 行 大 串 联 的 合 法 权 利 ， 有 力 地 保 障 了 无 产 阶 级 群 众 的 “ 四 大 民 主 ” 权 利 。 现 代 的 公 民 权 利 由 此 苏 醒 ， 而 我 们 相 信 ， 在 推 进 民 主 政 治 方 面 ， 我 们 比 自 诩 民 主 自 由 的 美 国 、 号 称 自 由 平 等 博 爱 的 法 国 乃 至 率 先 进 入 无 产 阶 级 专 政 的 苏 联 都 要 走 得 更 远 。|| 夺 权 高 潮 的 此 起 彼 伏 ， 推 动 了 广 大 工 农 群 众 在 经 济 战 线 的 斗 争 。 改 良 后 的 人 民 公 社 实 现 了 全 面 的 机 械 化 和 集 体 化 ， 形 成 了 全 新 的 “ 农 工 综 合 体 ” 。 鞍 钢 宪 法 的 原 则 被 落 实 到 了 每 一 个 工 业 体 系 当 中 ， 独 立 工 会 被 允 许 且 纳 入 到 了 工 人 参 与 生 产 管 理 的 综 合 体 系 当 中 。 I E C S 自 动 化 系 统 则 是 我 们 这 十 年 斗 争 当 中 最 宝 贵 的 财 富 之 一 。 随 着 全 面 自 动 化 的 实 施 ， 信 息 化 的 线 路 延 伸 到 了 中 国 最 为 偏 远 的 地 区 。 无 产 阶 级 夺 权 造 反 运 动 促 成 了 这 一 伟 大 计 划 得 以 实 现 ， 而 公 开 、 透 明 、 受 监 督 的 数 据 ， 高 效 的 信 息 传 递 和 全 面 自 动 化 则 反 过 来 保 障 了 无 产 阶 级 掌 握 生 产 资 料 的 权 力 。 更 可 喜 的 是 ， I E C S 系 统 极 大 地 解 放 了 我 们 的 生 产 力 ， 让 我 们 接 下 来 推 行 六 小 时 工 作 制 成 为 了 可 能 。|| 尽 管 我 们 尚 未 能 够 完 全 地 按 照 巴 黎 公 社 原 则 废 除 常 备 军 制 度 ， 但 是 我 们 还 是 努 力 克 服 了 常 备 军 制 度 的 许 多 缺 点 。 在 处 理 掉 军 队 当 中 的 旧 遗 产 之 后 ， 我 们 进 一 步 落 实 了 精 兵 简 政 原 则 ， 建 立 起 了 一 支 现 代 化 的 人 民 解 放 军 。 与 此 同 时 ， 无 产 阶 级 的 阶 级 武 装 — — 工 人 民 兵 在 十 年 的 磨 砺 当 中 ， 尤 其 是 在 保 卫 I E C S 的 斗 争 中 被 证 明 是 有 效 而 不 可 或 缺 的 。 根 据 上 海 工 人 民 兵 的 经 验 ， 我 们 建 立 起 了 独 立 于 解 放 军 之 外 的 民 兵 体 系 ， 让 公 民 武 装 更 多 地 参 与 到 政 治 生 活 当 中 来 。 我 们 决 不 允 许 曾 经 的 悲 剧 再 度 发 生 。|| 虽 然 我 们 离 真 正 的 共 产 主 义 还 很 遥 远 ， 但 是 我 们 确 确 实 实 的 走 在 了 通 向 人 类 自 由 王 国 的 康 庄 大 道 之 上 了 || <color=red>雄 关 漫 道 真 如 铁 ， 而 今 迈 步 从 头 越 。</color> ";
				}
				else
				{
					fake_text = " 没 有 民 主 就 没 有 社 会 主 义 ， 没 有 社 会 主 义 就 没 有 民 主 。 长 期 以 来 ， 我 们 努 力 在 这 些 概 念 之 间 找 到 平 衡 ， 最 后 终 于 建 成 了 真 正 的 社 会 主 义 ： 多 亏 了 引 入 全 国 自 动 化 系 统 ， 我 们 克 服 了 赤 字 ， 并 希 望 以 此 永 远 保 护 我 们 的 社 会 免 遭 人 剥 削 人 的 复 辟 现 象 、 不 平 等 和 生 产 过 剩 危 机 的 影 晌 ； 一 党 制 民 主 有 助 于 保 护 国 家 不 落 入 反 革 命 分 子 的 手 中 ， 并 消 除 资 产 阶 级 议 会 中 的 缺 点 ， 把 国 家 生 活 的 一 切 交 由 中 国 共 产 党 控 制 ； 言 论 自 由 和 人 民 控 制 权 保 护 我 们 的 制 度 不 受 中 国 共 产 党 及 其 一 些 党 员 滥 用 权 力 的 侵 害 ， 从 而 使 我 们 的 制 度 保 持 必 要 的 平 衡 。 我 们 已 经 证 明 ， 建 立 最 好 的 社 会 结 构 是 可 能 的 ， 在 世 界 各 地 无 数 建 设 社 会 主 义 的 尝 试 都 没 有 白 费 。 马 克 思 的 理 想 实 现 了 ！";
				}
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(58);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] <= 2 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[90] == 0 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[51].Torg)
			{
				name.text = " 毛 泽 东 主 义 的 坚 实 壁 垒";
				fake_text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					" 主 席 与 政 治 局 富 有 信 心 的 领 导 确 保 了 国 家 忠 于 中 国 人 民 的 伟 大 解 放 者 ， 毛 泽 东 主 席 的 理 念 。 所 有 反 对 派 都 被 镇 压 ， 并 置 于 控 制 之 下 ， 他 们 的 领 袖 的 名 字 也 被 遗 忘 了 。 我 们 走 在 大 路 上 — — 伟 大 舵 手 向 我 们 展 现 的 道 路 ！ 至 少 ， 毛 泽 东 思 想 仍 被 人 民 拥 护 ， 经 济 也 多 少 稳 定 下 来 了 。 实 际 上 ， 我 们 愈 发 被 人 指 责 侵 犯 人 权 — — 但 谁 在 乎 ？ 数 以 百 万 计 的 人 民 得 到 了 自 己 的 住 房 、 免 费 的 教 育 、 充 足 的 就 业 ， 尽 管 不 如 我 们 想 象 的 那 么 快 ， 但 是 大 多 数 人 所 享 受 的 福 利 在 确 实 地 、 稳 定 地 增 长 着 。 中 国 成 为 了 受 人 尊 敬 的 国 家 — — 这 已 经 是 显 著 的 成 就 。"
				});
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(46);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 1 && GlobalScript.inst.gameState.modifies[6].active && !GlobalScript.inst.gameState.modifies[3].active)
			{
				name.text = " 遗 产 保 卫 者";
				fake_text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					" 主 席 同 志 与 紧 紧 团 结 在 领 袖 身 边 的 政 治 局 委 员 们 确 保 着 人 民 共 和 国 对 毛 主 席 ， 开 国 元 老 和 马 列 主 义 的 原 则 的 忠 诚 。 最 终 ， 回 到 新 民 主 革 命 这 一 一 小 撮 异 见 者 采 取 的 世 界 观 遭 到 了 击 败 。 在 文 化 大 革 命 结 束 后 ， 我 们 得 以 回 到 最 初 的 ， 在 大 跃 进 前 对 于 社 会 主 义 和 共 产 主 义 的 想 象 。 一 党 制 民 主 ， 计 划 经 济 等 机 制 日 益 完 善 ， 社 会 上 也 出 现 了 对 于 现 代 化 的 可 以 说 有 些 过 度 乐 观 的 幻 想 。 虽 然 还 会 有 不 少 公 民 在 私 底 下 嘲 笑 “ 官 老 爷 ” 的 特 权 并 且 发 明 着 不 少 根 据 苏 修 笑 话 改 编 的 笑 话 ， 但 中 国 已 经 坚 决 地 选 择 了 自 己 的 道 路 。"
				});
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 700)
				{
					if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
					{
						fake_text = fake_text + "| 我 们 与 苏 联 重 建 了 友 邻 关 系 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 莫 斯 科 进 行 了 国 事 访 问 ， 他 称 中 国 对 苏 联 没 有 要 求 — — 无 论 在 领 土 还 是 意 识 形 态 上 。 在 回 国 的 路 上 ， 他 造 访 了 珍 宝 岛 ， 和 苏 联 领 导 人 罗 曼 诺 夫 一 起 向 死 于1969 年 冲 突 的 中 苏 边 防 部 队 战 士 们 的 坟 墓 默 哀 致 敬 ， 代 表 双 方 人 民 承 诺 会 始 终 遵 循 中 苏 友 谊 的 路 线 。 两 个 最 大 的 欧 亚 国 家 正 一 同 迈 进 ， 但 谁 知 道 会 发 生 什 么 呢 ？ ......";
					}
					else
					{
						fake_text = fake_text + "| 我 们 与 苏 联 重 建 了 友 邻 关 系 ， 并 开 始 了 划 定 新 中 苏 边 界 的 谈 判 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 莫 斯 科 进 行 了 国 事 访 问 ， 他 称 中 国 对 苏 联 没 有 要 求 — — 无 论 在 领 土 还 是 意 识 形 态 上 。 两 个 最 大 的 欧 亚 国 家 正 一 同 迈 进 ， 但 谁 知 道 会 发 生 什 么 呢 ？ ......";
					}
				}
				if (GlobalScript.inst.gameState.allcountries[51].Torg && GlobalScript.inst.gameState.empires[0].relations >= 700)
				{
					fake_text += "| 我 们 成 功 和 美 国 建 立 了 战 略 互 信 关 系 。 在 对 华 盛 顿 的 访 问 中 ， 领 导 人 同 志 说 ： “ 无 论 中 美 两 国 意 识 形 态 如 何 对 立 ， 重 要 的 是 中 美 双 方 有 着 共 同 利 益 ， 这 就 为 两 国 之 间 的 合 作 打 下 了 基 础 。 ” 我 们 和 许 多 美 国 公 司 签 署 合 约 ， 允 许 他 们 进 入 中 国 市 场 。 党 内 越 来 越 多 的 同 志 却 认 为 “ 社 会 主 义 ” 在 中 国 的 部 分 就 只 剩 下 拉 面 国 旗 了 ， 其 他 的 一 切 都 会 被 资 本 主 义 侵 蚀 — — 因 为 美 国 影 响 力 的 渗 透 已 让 新 一 代 年 轻 人 思 想 变 得 自 由 化 起 来 ， 但 是 这 只 是 没 有 长 远 考 虑 的 见 地 ， 对 吧 ？ ......";
				}
			}
			else if (GlobalScript.inst.gameState.data[14] >= 2 && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2 && (GlobalScript.inst.gameState.data[16] == 12 || (GlobalScript.inst.gameState.data[16] == 11 && !GlobalScript.inst.gameState.modifies[11].active)))
			{
				name.text = " 海 德 公 园 社 会 主 义";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 将 作 为 中 国 历 史 上 最 杰 出 ， 也 是 最 被 争 议 的 领 导 人 之 一 被 铭 记 。 在 他 的 统 治 时 期 ， 政 治 与 文 化 方 面 形 成 了 广 泛 而 深 远 的 自 由 化 。 尽 管 如 此 ， 对 于 社 会 主 义 核 心 公 有 制 的 坚 持 让 全 世 界 的 政 治 观 察 家 惊 愕 于 一 种 不 同 于 苏 联 集 团 的 社 会 主 义 模 式 的 可 能 性 。 然 而 ， 在 这 样 一 个 体 系 下 ， 官 僚 的 特 权 ， 徇 私 枉 法 和 任 人 唯 亲 作 为 问 题 并 没 有 随 着 引 入 的 公 共 监 督 而 消 失 ， 青 年 陷 入 前 所 未 有 的 迷 茫 当 中 ， 党 作 为 先 锋 队 的 能 力 急 剧 退 化 ， 而 我 们 也 面 对 着 比 以 往 更 多 的 公 共 议 题 争 议 ， 一 些 年 老 的 党 员 忧 心 于 “ 社 会 主 义 道 德 的 退 化 ” 和 “ 反 革 命 思 想 的 复 苏 ”   但 至 少 ， 我 们 也 许 可 以 说 ， 我 们 是 在 做 人 民 的 公 仆 。";
				_ = GlobalScript.inst.gameState.allcountries[51].Torg;
				if (GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text += "| 我 们 加 深 了 由 周 恩 来 建 立 的 中 美 之 间 的 合 作 关 系 ， 开 设 面 向 全 世 界 投 资 者 的 自 贸 区 。 数 以 千 计 的 外 国 公 司 将 他 们 的 企 业 转 移 给 我 们 ， 我 们 经 济 因 此 得 以 繁 荣 ！ 但 是 ， 一 些 党 员 说 “ 在 自 贸 区 内 ， 只 有 飘 扬 在 上 面 的 国 旗 是 社 会 主 义 的 ， 其 他 都 是 资 本 主 义 的 ” ， 并 且 ， 自 贸 区 的 收 入 很 大 一 部 分 最 终 都 流 向 海 外 。 也 许 那 些 不 满 的 党 员 说 的 话 是 对 的 ？ ......";
				}
				else if (GlobalScript.inst.gameState.relres)
				{
					fake_text += "| 我 们 不 仅 重 建 了 与 苏 联 的 友 邻 关 系 ， 还 加 入 了 经 济 互 助 委 员 会 。 与 社 会 主 义 国 家 的 合 作 使 得 中 国 经 济 的 复 兴 有 了 可 能 ， 并 且 将 使 其 更 加 强 劲 、 更 加 发 达 ， 上 百 个 工 程 项 目 已 经 开 工 ， 未 来 更 多 的 项 目 也 处 于 不 同 进 度 的 筹 备 中 。 我 们 的 专 家 从 我 们 的 朋 友 那 学 到 了 很 多 。 拜 其 所 赐 ， 中 国 制 造 不 再 是 假 冒 伪 劣 的 同 义 词 ， 而 成 为 了 全 世 界 范 围 内 受 尊 敬 的 高 质 量 产 品 的 标 志 。";
					GlobalScript.inst.gameState.allcountries[1].isSEV = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 2 || GlobalScript.inst.gameState.data[14] == 1)
			{
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.data[14] == 1 && !GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.leader.traits[0] == 0)
				{
					achieves.GetComponent<achievements>().Set(1);
				}
				name.text = " 向 世 界 开 放 ......";
				fake_text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					" 和 忠 诚 的 党 员 领 导 着 国 家 沿 着 吸 收 了 中 国 历 史 经 验 的 道 路 前 进 。 这 一 尝 试 是 开 始 偏 离 正 统 道 路 的 标 志 ， 中 国 向 世 界 敞 开 了 大 门 — — 当 然 ， 没 有 一 开 到 底 ， 但 关 键 的 一 步 已 经 迈 出 了 。 最 终 ， “ 文 化 大 革 命 ” 结 束 了 ， 我 们 在 社 会 主 义 的 框 架 内 开 展 了 谨 慎 的 改 革 ， 允 许 我 们 纠 正 毛 泽 东 同 志 统 治 时 期 的 错 误 ， 并 巩 固 那 时 的 正 确 成 果 。 对 于 数 以 百 万 记 的 中 国 人 ， 这 段 时 期 在 中 国 历 史 中 是 最 为 稳 定 和 繁 荣 的 时 期 。 尽 管 犯 下 了 些 错 误 ， 但 是 这 条 道 路 被 证 明 是 成 功 的 ， 我 们 的 领 袖 也 被 与 列 宁 本 人 相 比 较 ， 因 为 他 懂 得 摸 着 石 头 过 河 。"
				});
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 700)
				{
					if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
					{
						fake_text = fake_text + "| 我 们 与 苏 联 重 建 了 友 邻 关 系 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 莫 斯 科 进 行 了 国 事 访 问 ， 他 称 中 国 对 苏 联 没 有 要 求 — — 无 论 在 领 土 还 是 意 识 形 态 上 。 在 回 国 的 路 上 ， 他 造 访 了 珍 宝 岛 ， 和 苏 联 领 导 人 罗 曼 诺 夫 一 起 向 死 于1969 年 冲 突 的 中 苏 边 防 部 队 战 士 们 的 坟 墓 默 哀 致 敬 ， 代 表 双 方 人 民 承 诺 会 始 终 遵 循 中 苏 友 谊 的 路 线 。 两 个 最 大 的 欧 亚 国 家 正 一 同 迈 进 ， 但 谁 知 道 会 发 生 什 么 呢 ？ ......";
					}
					else
					{
						fake_text = fake_text + "| 我 们 与 苏 联 重 建 了 友 邻 关 系 ， 并 开 始 了 划 定 新 中 苏 边 界 的 谈 判 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 对 莫 斯 科 进 行 了 国 事 访 问 ， 他 称 中 国 对 苏 联 没 有 要 求 — — 无 论 在 领 土 还 是 意 识 形 态 上 。 两 个 最 大 的 欧 亚 国 家 正 一 同 迈 进 ， 但 谁 知 道 会 发 生 什 么 呢 ？ ......";
					}
				}
				if (GlobalScript.inst.gameState.allcountries[51].Torg && GlobalScript.inst.gameState.empires[0].relations >= 700)
				{
					fake_text += "| 我 们 成 功 和 美 国 建 立 了 战 略 互 信 关 系 。 在 对 华 盛 顿 的 访 问 中 ， 领 导 人 同 志 说 ： “ 无 论 中 美 两 国 意 识 形 态 如 何 对 立 ， 重 要 的 是 中 美 双 方 有 着 共 同 利 益 ， 这 就 为 两 国 之 间 的 合 作 打 下 了 基 础 。 ” 我 们 和 许 多 美 国 公 司 签 署 合 约 ， 允 许 他 们 进 入 中 国 市 场 。 党 内 越 来 越 多 的 同 志 却 认 为 “ 社 会 主 义 ” 在 中 国 的 部 分 就 只 剩 下 拉 面 国 旗 了 ， 其 他 的 一 切 都 会 被 资 本 主 义 侵 蚀 — — 因 为 美 国 影 响 力 的 渗 透 已 让 新 一 代 年 轻 人 思 想 变 得 自 由 化 起 来 ， 但 是 这 只 是 没 有 长 远 考 虑 的 见 地 ， 对 吧 ？ ......";
				}
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(45);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 3)
			{
				name.text = " 大 胆 去 闯 荡 ......";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 先 生 将 作 为 中 国 最 为 杰 出 的 领 导 人 之 一 被 历 史 铭 记 （ 至 少 我 们 的 官 方 宣 传 是 这 样 说 的 ） ， 他 开 展 大 规 模 经 济 改 革 ， 鼓 励 开 展 经 营 活 动 ， 扩 大 外 商 投 资 机 会 ， 同 时 保 护 国 内 市 场 免 受 生 产 崩 溃 与 外 资 影 响 。 诚 然 ， 现 在 企 业 与 国 家 机 构 紧 密 结 合 ， 自 由 市 场 的 支 持 者 和 正 统 的 共 产 主 义 者 都 不 喜 欢 这 样 ， 社 会 思 想 的 自 由 化 没 有 走 得 太 远 ： 国 家 设 置 了 严 格 的 审 查 制 度 ， 反 对 派 处 于 控 制 之 下 ， 但 我 们 这 样 做 的 出 发 点 都 是 为 人 民 谋 利 益 ， 对 吗 ？ ......";
				_ = GlobalScript.inst.gameState.allcountries[51].Torg;
				if (GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text += "| 我 们 加 深 了 由 周 恩 来 建 立 的 中 美 之 间 的 合 作 关 系 ， 开 设 面 向 全 世 界 投 资 者 的 自 贸 区 。 数 以 千 计 的 外 国 公 司 将 他 们 的 企 业 转 移 给 我 们 ， 我 们 经 济 因 此 得 以 繁 荣 ！ 但 是 ， 一 些 党 员 说 “ 在 自 贸 区 内 ， 只 有 飘 扬 在 上 面 的 国 旗 是 社 会 主 义 的 ， 其 他 都 是 资 本 主 义 的 ” ， 并 且 ， 自 贸 区 的 收 入 很 大 一 部 分 最 终 都 流 向 海 外 。 也 许 那 些 不 满 的 党 员 说 的 话 是 对 的 ？ ......";
				}
				else if (GlobalScript.inst.gameState.relres)
				{
					fake_text += "| 我 们 不 仅 重 建 了 与 苏 联 的 友 邻 关 系 ， 还 加 入 了 经 济 互 助 委 员 会 。 与 社 会 主 义 国 家 的 合 作 使 得 中 国 经 济 的 复 兴 有 了 可 能 ， 并 且 将 使 其 更 加 强 劲 、 更 加 发 达 ， 上 百 个 工 程 项 目 已 经 开 工 ， 未 来 更 多 的 项 目 也 处 于 不 同 进 度 的 筹 备 中 。 我 们 的 专 家 从 我 们 的 朋 友 那 学 到 了 很 多 。 拜 其 所 赐 ， 中 国 制 造 不 再 是 假 冒 伪 劣 的 同 义 词 ， 而 成 为 了 全 世 界 范 围 内 受 尊 敬 的 高 质 量 产 品 的 标 志 。";
					GlobalScript.inst.gameState.allcountries[1].isSEV = true;
				}
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(44);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 4)
			{
				name.text = " 新 绝 对 真 理";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 开 启 了 中 国 历 史 中 的 一 段 困 难 时 期 — — 坚 定 地 与 过 去 作 决 裂 的 时 期 ， 在 新 阵 地 上 建 设 新 中 国 、 深 入 所 有 领 域 的 大 规 模 改 革 、 向 民 主 普 世 价 值 的 过 渡 、 新 的 政 治 思 维 、 思 想 与 行 动 的 完 全 解 放 。 但 是 ， 并 非 每 个 人 都 喜 欢 这 样 ： 在 政 治 领 域 上 ， 在 经 济 领 域 上 ， 在 文 化 领 域 上 我 国 都 已 进 入 了 一 种 无 支 配 的 权 力 空 位 状 态 。 我 们 说 不 清 是 百 家 争 鸣 还 是 万 马 齐 喑 。 而 未 来 的 五 年 、 十 年 乃 至 几 十 年 会 发 生 什 么 ， 我 们 不 知 道 — — 但 我 们 的 后 代 一 定 会 记 得 ， 这 对 中 国 来 说 是 发 生 决 定 性 改 变 的 时 代 ， 未 来 的 许 多 改 变 也 归 因 于 此 。";
				if (GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text = fake_text + "| 美 国 全 心 全 意 地 支 持 我 们 的 改 革 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 先 生 被 各 种 主 流 出 版 物 五 次 被 评 为 “ 年 度 人 物 ” ， 并 获 得 了 诺 贝 尔 和 平 奖 提 名 （ 尽 管 他 在 辞 职 前 才 获 得 此 奖 ） 。 我 们 向 外 国 公 司 敞 开 了 市 场 ， 允 许 他 们 参 加 国 有 财 产 的 私 有 化 。 通 过 参 与 全 球 化 ， 我 们 向 外 国 提 供 劳 动 力 ， 并 开 放 自 贸 区 。 但 这 造 成 了 许 多 始 料 未 及 的 困 难 ， 引 起 了 社 会 的 广 泛 讨 论 。 时 间 会 告 诉 我 们 我 们 是 否 在 做 正 确 的 事 情 ......";
				}
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 700)
				{
					if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
					{
						fake_text = fake_text + "| 在 民 主 改 革 过 程 中 ， 对 苏 联 的 议 题 一 直 是 热 点 问 题 。 顶 着 社 会 内 反 共 主 义 的 重 重 压 力 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 先 生 与 苏 联 重 建 了 友 邻 关 系 。 但 随 着 戈 尔 巴 乔 夫 先 生 的 上 台 ， 我 们 的 地 缘 政 治 赌 博 似 乎 输 掉 了 大 多 数 筹 码 ， 世 界 在 飞 速 走 向 美 国 主 导 的 自 由 主 义 世 界 秩 序 ， 而 苏 联 的 利 用 价 值 不 复 存 在 …";
					}
					else
					{
						fake_text = fake_text + "| 在 民 主 改 革 过 程 中 ， 对 苏 联 的 议 题 一 直 是 热 点 问 题 。 顶 着 社 会 内 反 共 主 义 的 重 重 压 力 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 先 生 与 苏 联 重 建 了 友 邻 关 系 ， 并 开 始 了 划 定 新 中 苏 边 界 的 谈 判 。 在 未 来 ， 政 治 学 者 依 然 不 会 明 白 ， 为 什 么 苏 联 与 一 个 明 显 在 走 向 自 由 化 路 线 的 国 家 可 以 建 立 持 久 的 友 谊 ， 但 不 管 如 何 ， 美 国 代 表 在 提 及 两 国 的 友 谊 的 时 候 ， 大 言 不 惭 地 说 “ 中 国 是 自 由 世 界 的 弃 子 ， 一 个 流 氓 国 家 ， 苏 中 两 国 的 友 谊 会 因 为 本 质 水 火 不 容 的 意 识 形 态 与 现 实 政 治 的 原 因 自 然 破 裂 ”   也 许 他 说 的 在 未 来 会 成 为 现 实 ？";
					}
				}
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(42);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 5)
			{
				name.text = " 亚 洲 民 主";
				fake_text = " 总 统" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 也 许 会 是 7 0 - 8 0 年 代 ， 不 管 在 全 球 还 是 中 国 国 内 最 具 有 争 议 的 人 物 - 在 支 持 者 的 眼 里 ， 他 将 一 个 具 有 五 千 年 专 制 传 统 的 世 界 上 最 大 的 共 产 主 义 独 裁 国 家 改 造 为 了 一 个 民 主 自 由 的 ， 基 于 市 场 经 济 的 国 家 。 印 度 甚 至 已 经 让 出 了 “ 世 界 上 最 大 的 民 主 国 家 ” 这 一 称 号 ！ 然 而 ， 在 反 对 者 看 来 ， 这 种 快 速 改 造 本 身 代 表 了 对 于 这 个 国 家 革 命 历 史 的 背 叛 。 有 人 说 ， 自 由 主 义 的 完 全 胜 利 导 致 了 这 个 国 家 的 剧 变 ， 人 们 在 拥 抱 无 处 不 在 的 ， 无 所 不 有 的 自 由 的 同 时 发 展 着 炙 热 的 抵 触 情 绪 。 他 们 抵 触 于 这 种 变 革 如 此 自 由 ， 以 至 于 没 有 问 他 们 的 意 见 ， 以 至 于 不 能 代 表 他 们 而 是 捂 住 了 他 们 的 嘴 ， 这 种 说 法 自 然 是 无 病 呻 吟 ， 不 是 吗 ？       ";
				if (GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text = fake_text + "| 美 国 全 心 全 意 地 支 持 我 们 的 改 革 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 先 生 被 各 种 主 流 出 版 物 五 次 被 评 为 “ 年 度 人 物 ” ， 并 获 得 了 诺 贝 尔 和 平 奖 提 名 （ 尽 管 他 在 辞 职 前 才 获 得 此 奖 ） 。 我 们 向 外 国 公 司 敞 开 了 市 场 ， 允 许 他 们 参 加 国 有 财 产 的 私 有 化 。 通 过 参 与 全 球 化 ， 我 们 向 外 国 提 供 劳 动 力 ， 并 开 放 自 贸 区 。 但 这 造 成 了 许 多 始 料 未 及 的 困 难 ， 引 起 了 社 会 的 广 泛 讨 论 。 时 间 会 告 诉 我 们 我 们 是 否 在 做 正 确 的 事 情 ......";
				}
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 700)
				{
					if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
					{
						fake_text = fake_text + "| 在 民 主 改 革 过 程 中 ， 对 苏 联 的 议 题 一 直 是 热 点 问 题 。 顶 着 社 会 内 反 共 主 义 的 重 重 压 力 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 先 生 与 苏 联 重 建 了 友 邻 关 系 。 但 随 着 戈 尔 巴 乔 夫 先 生 的 上 台 ， 我 们 的 地 缘 政 治 赌 博 似 乎 输 掉 了 大 多 数 筹 码 ， 世 界 在 飞 速 走 向 美 国 主 导 的 自 由 主 义 世 界 秩 序 ， 而 苏 联 的 利 用 价 值 不 复 存 在 …";
					}
					else
					{
						fake_text = fake_text + "| 在 民 主 改 革 过 程 中 ， 对 苏 联 的 议 题 一 直 是 热 点 问 题 。 顶 着 社 会 内 反 共 主 义 的 重 重 压 力 ， " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 先 生 与 苏 联 重 建 了 友 邻 关 系 ， 并 开 始 了 划 定 新 中 苏 边 界 的 谈 判 。 在 未 来 ， 政 治 学 者 依 然 不 会 明 白 ， 为 什 么 苏 联 与 一 个 明 显 在 走 向 自 由 化 路 线 的 国 家 可 以 建 立 持 久 的 友 谊 ， 但 不 管 如 何 ， 美 国 代 表 在 提 及 两 国 的 友 谊 的 时 候 ， 大 言 不 惭 地 说 “ 中 国 是 自 由 世 界 的 弃 子 ， 一 个 流 氓 国 家 ， 苏 中 两 国 的 友 谊 会 因 为 本 质 水 火 不 容 的 意 识 形 态 与 现 实 政 治 的 原 因 自 然 破 裂 ”   也 许 他 说 的 在 未 来 会 成 为 现 实 ？";
					}
				}
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(42);
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 13 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9)
			{
				name.text = " 权 力 意 志";
				fake_text = " 伟 大 领 袖" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 在 凶 险 的 政 治 斗 争 手 足 相 残 中 采 用 了 卓 绝 的 手 段 。 俗 话 说 ， 乱 世 需 用 重 典 。 所 有 反 对 派 都 被 血 洗 ， 军 队 与 特 务 的 权 力 被 极 大 增 加 ， 政 治 局 里 坐 满 了 木 偶 委 员 而 一 切 政 治 决 策 让 步 于 集 中 伟 大 领 袖 的 权 力 ， 并 基 于 此 创 造 了 仅 忠 诚 于 伟 大 领 袖 的 私 有 经 济 领 域 。 在 伟 大 领 袖 去 世 之 后 ， 这 个 国 家 的 各 方 面 进 入 了 一 种 尴 尬 的 局 面 ， 继 任 者 希 翼 改 革 伟 大 领 袖 的 个 人 崇 拜 与 自 相 矛 盾 错 综 复 杂 的 官 僚 结 构 ， 但 是 遭 遇 重 重 阻 力 ， 因 为 在 社 会 与 政 治 结 构 上 ， 已 经 如 同 被 雕 刻 的 大 理 石 成 为 雕 像 一 样 ， 形 成 了 伟 大 领 袖 独 有 的 遗 产 。 也 许 有 朝 一 日 ， 这 种 权 力 意 志 的 遗 产 会 分 崩 离 析 ， 但 离 不 开 血 与 火 的 洗 涤 。  ";
			}
			else if (GlobalScript.inst.gameState.data[14] == 0 && GlobalScript.inst.gameState.data[16] <= 13)
			{
				name.text = " 大 号 朝 鲜 民 主 主 义 人 民 共 和 国";
				fake_text = " 在 战 无 不 胜 的 伟 大 领 袖" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ， 我 们 的 恩 人 的 光 荣 领 导 下 ， 共 和 国 走 向 了 前 所 未 有 的 复 兴 新 时 代 。 左 翼 （ 造 反 派 ） 和 右 翼 （ 走 资 派 ） 的 反 对 派 都 被 肃 清 ， 我 们 成 功 在 外 国 间 谍 和 人 民 公 敌 的 威 胁 下 保 卫 了 社 会 主 义 社 会 。 这 些 家 伙 竟 将 我 们 的 时 代 同 五 代 十 国 时 期 的 小 王 朝 ， 同 蒙 古 人 的 独 裁 ， 同 汉 代 的 宦 官 专 制 作 比 较 ， 但 这 完 完 全 全 是 在 胡 说 八 道 ， 无 论 在 哪 个 历 史 时 期 ， 人 民 的 福 利 都 从 未 提 升 到 我 们 当 今 时 代 的 高 度 。 然 而 许 多 人 妄 论 说 ， 我 们 的 意 识 形 态 最 终 背 离 了 马 克 思 主 义 道 路 ， 变 成 了 一 种 带 有 威 权 色 彩 的 含 有 社 会 主 义 成 分 的 民 族 主 义 ， 但 这 只 是 他 们 的 臆 想 ， 不 是 吗 ？";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(43);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 0 && GlobalScript.inst.gameState.data[16] >= 14)
			{
				name.text = " 亚 洲 的 皮 诺 切 特";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 在 市 场 经 济 改 革 中 的 强 硬 手 段 ， 为 中 国 带 来 了 稳 定 与 繁 荣 。 所 有 的 异 议 之 声 都 被 消 灭 ， 在 我 党 强 有 力 的 领 导 下 ， 中 国 正 走 向 光 明 的 市 场 经 济 未 来 。 可 国 际 组 织 却 成 天 指 责 我 们 侵 犯 人 权 ， 断 定 我 们 压 迫 自 由 ， 缺 乏 真 正 的 民 主 ， 例 如 什 么 私 营 企 业 肆 意 妄 为 ， 让 公 民 在 标 准 工 时 外 超 负 荷 加 班 ， 工 会 运 动 也 被 查 禁 因 而 无 法 纠 正 现 状 。 但 只 要 外 国 投 资 者 与 官 僚 能 一 直 拥 护 我 们 ， 我 们 依 然 可 以 维 持 “ 将 要 ” 转 型 成 为 自 由 民 主 制 度 的 幻 影 ， 那 么 这 一 切 都 不 是 问 题 ， 难 道 不 是 吗 ？";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(41);
				}
			}
			if (!flag && !flag3 && !flag2 && !flag4 && !flag5 && !flag6)
			{
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)
				{
					fake_text += "|| 最 终 ， 我 们 决 定 回 归 中 国 革 命 的 本 源 ， 向 张 春 桥 在 《 破 除 法 权 思 想 》 中 盛 赞 的 军 事 共 产 主 义 模 式 看 齐 ， 达 到 为 文 化 革 命 注 入 新 血 的 目 的 ： 全 国 范 围 就 此 掀 起 了 学 习 “ 井 冈 山 ” 、 “ 陕 甘 宁 边 区 ” 与 “ 人 民 解 放 军 ” 历 史 经 验 的 浪 潮 ： 资 产 阶 级 等 级 观 念 、 思 想 流 毒 与 利 益 至 上 的 分 配 制 均 遭 迎 头 痛 击 ， 为 供 给 制 、 社 会 主 义 与 集 体 主 义 生 产 关 系 让 路 。 反 动 派 也 在 文 化 革 命 的 浩 荡 洪 流 中 被 扫 除 殆 尽 ， 再 无 翻 身 余 地 。 我 们 正 走 在 充 分 贯 彻 军 民 平 等 、 官 兵 平 等 、 上 下 平 等 的 道 路 上 ！ 中 国 本 身 也 将 因 这 “ 重 上 井 冈 山 ” 的 壮 举 而 焕 然 一 新 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 1)
				{
					fake_text += "|| 告 别 毛 主 席 及 其 时 代 后 ， 我 们 党 决 定 在 坚 持 在 人 民 共 和 国 既 有 制 度 基 础 上 革 故 鼎 新 ， 以 更 宽 容 的 姿 态 面 对 未 来 ： 我 们 主 导 了 将 社 会 主 义 基 本 原 理 与 中 国 国 情 相 结 合 的 二 次 革 命 ， 形 成 了 有 中 国 特 色 的 社 会 主 义 。 党 和 国 家 便 得 以 在 巩 固 对 经 济 与 政 治 事 务 主 导 权 的 同 时 兼 采 各 思 想 所 长 ， 摆 脱 教 条 主 义 桎 梏 ， 建 立 兼 具 灵 活 与 稳 定 性 的 制 度 。 国 内 经 济 与 社 会 的 面 貌 也 随 之 焕 然 一 新 ， 其 成 就 显 而 易 见 ： 福 利 正 增 长 ， 产 业 正 勃 发 ， 国 家 与 人 民 正 携 手 开 创 未 来 。 中 国 本 身 也 切 实 走 出 了 条 新 路 。";
					if (!GlobalScript.inst.gameState.modifies[6].active)
					{
						fake_text += "| “ 我 们 摆 脱 了 停 滞 ， 正 歌 唱 春 天 的 故 事 ” — — 不 少 资 深 党 员 对 旧 路 线 的 改 变 如 此 评 论 ， 并 将 新 的 领 袖 同 善 于 斡 旋 ， 创 新 提 出 新 经 济 政 策 的 列 宁 同 志 相 提 并 论 。 排 列 着 五 颗 金 星 的 鲜 艳 国 旗 因 此 更 加 闪 烁 ， 勃 勃 生 机 ， 万 物 迸 发 。 但 我 们 绝 不 能 被 胜 利 冲 昏 头 脑 ， 毕 竟 ， 春 天 之 后 可 还 有 故 事 可 写 … …";
					}
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 2)
				{
					fake_text += "|| 我 们 党 遵 循 马 克 思 列 宁 主 义 基 本 原 理 ， 对 中 国 社 会 主 义 建 设 实 践 进 行 充 分 评 估 。 成 功 从 以 毛 泽 东 为 代 表 的 第 一 代 社 会 主 义 者 处 吸 取 经 验 教 训 ， 并 将 其 遗 产 发 扬 光 大 ： 党 领 导 工 人 阶 级 坚 持 以 阶 级 斗 争 为 纲 的 基 本 路 线 ， 坚 决 扫 除 从 左 右 方 向 进 攻 的 一 切 害 人 虫 ， 并 胜 利 结 束 了 文 化 大 革 命 。 中 国 本 身 也 得 以 超 越 旧 时 代 新 民 主 主 义 的 陈 词 滥 调 ， 建 立 起 更 高 级 的 无 产 阶 级 专 政 ： 经 济 稳 步 工 业 化 ， 管 理 实 现 集 体 化 ， 财 产 得 以 社 会 化 ， 旧 社 会 在 持 续 不 断 地 猛 烈 进 攻 中 崩 塌 ， 教 堂 与 监 狱 也 在 怒 吼 中 被 毁 灭 。 让 那 些 内 外 反 动 派 在 我 们 面 前 发 抖 罢 ！ 中 国 人 民 的 不 屈 不 挠 的 努 力 ， 必 将 稳 步 地 达 到 自 己 的 目 的 ！";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 3)
				{
					fake_text += "|| 在 毛 主 席 去 世 后 ， 思 想 剧 变 ， 启 发 于 西 欧 社 会 民 主 党 左 派 思 想 的 发 展 和 毛 时 代 草 根 民 主 实 践 ， 我 党 开 创 性 地 重 新 解 释 百 花 齐 放 运 动 ， 在 马 列 毛 思 想 的 同 时 接 纳 了 部 分 民 主 社 会 主 义 的 思 潮 。 “ 只 有 通 过 斗 争 你 才 能 获 得 你 的 权 力 ” - 可 见 的 社 会 ， 政 治 自 由 化 在 主 席 同 志 的 新 路 线 下 取 得 了 显 著 的 进 展 ， 百 花 齐 放 的 新 时 代 到 来 了 ！";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 4)
				{
					fake_text += "|| 在 毛 泽 东 去 世 后 ， 思 想 剧 变 ， 在 果 断 改 革 下 ， 我 党 逐 渐 否 定 了 黑 暗 的 过 去 - 所 谓 马 列 毛 思 想 ， 而 是 大 胆 地 基 于 西 欧 社 会 民 主 党 的 经 验 进 行 改 革 。 最 终 ， “ 第 三 条 路 “ 的 优 越 性 在 党 内 胜 出 。 平 衡 资 本 主 义 与 社 会 主 义 ， 建 设 一 个 强 劲 社 会 保 障 的 市 场 经 济 ， 对 于 小 康 社 会 的 梦 重 新 开 始 了 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 5)
				{
					fake_text += "|| 在 毛 泽 东 去 世 后 ， 思 想 剧 变 ， 在 果 断 改 革 下 ， 我 们 大 胆 地 基 于 革 命 制 度 党 等 选 举 机 器 和 戴 高 乐 主 义 者 的 经 验 进 行 改 革 。 最 终 ， 我 党 变 成 了 尊 重 宪 政 ， 包 容 万 象 ， 善 于 妥 协 ， 根 据 地 区 不 同 议 题 立 场 不 同 的 大 帐 篷 政 党 ， 在 一 些 地 方 ， 我 们 甚 至 很 好 的 运 用 了 毛 泽 东 的 形 象 为 我 们 继 续 背 书 。 这 样 一 种 实 用 主 义 可 以 很 好 的 解 决 转 型 中 保 存 我 们 在 政 坛 上 的 霸 权 的 问 题 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 6)
				{
					fake_text += "|| 在 毛 泽 东 去 世 后 ， 思 想 剧 变 ， 在 果 断 改 革 下 ， 我 党 逐 渐 否 定 了 黑 暗 的 过 去 - 所 谓 马 列 毛 思 想 ， 而 是 大 胆 地 基 于 欧 美 等 国 自 由 主 义 政 党 的 经 验 进 行 改 革 。 最 终 ， 我 党 变 成 了 曾 经 那 个 过 激 存 在 的 反 面 - 对 自 由 ， 人 权 ， 宪 政 的 绝 对 霸 权 的 全 面 接 纳 ， 全 面 的 转 型 正 义 与 对 自 由 市 场 经 济 作 为 人 类 历 史 的 终 结 的 认 同 。 总 统 先 生 的 下 一 个 决 定 很 可 能 是 彻 底 解 体 这 个 “ 毛 的 遗 产 “ ， 形 成 一 个 更 加 有 竞 争 力 的 多 党 议 会 体 系 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7)
				{
					fake_text += "|| 我 党 实 事 求 是 ， 接 纳 了 邓 小 平 提 出 的 “ 中 国 特 色 社 会 主 义 理 论 ” 和 亨 廷 顿 的 新 威 权 主 义 理 论 。 支 持 市 场 经 济 优 先 发 展 和 建 立 现 代 化 导 向 的 强 力 权 威 政 治 与 一 批 具 有 改 革 意 识 的 精 英 建 立 一 个 强 有 力 的 政 府 来 进 行 过 渡 到 民 主 化 改 革 的 学 说 取 得 了 胜 利 。 然 而 ， 这 两 种 思 潮 总 有 一 天 ， 必 然 迎 来 它 的 分 岔 路 口 ， 到 那 一 天 ， 我 们 还 有 多 少 人 可 以 做 到 不 折 腾 ， 一 切 看 大 局 呢 ？";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 8)
				{
					fake_text += "|| 在 毛 主 席 去 世 后 ， 思 想 剧 变 ， 改 革 派 的 实 事 求 是 观 点 虽 然 可 以 迈 向 初 步 的 自 由 化 ， 但 经 济 自 由 化 本 身 遭 到 了 “ 乡 土 中 国 ” 的 反 噬 。 面 对 新 的 政 治 现 实 ， 我 们 做 出 务 实 的 改 变 ， 以 中 华 民 族 的 伟 大 复 兴 为 基 准 ， 融 合 了 孙 先 生 民 生 主 义 的 思 想 和 “ 新 左 派 ” 学 派 思 想 ， 形 成 了 全 新 的 政 治 生 态 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9)
				{
					fake_text += "|| 在 毛 主 席 去 世 后 ， 思 想 剧 变 。 我 们 党 在 四 处 的 攻 击 下 ， 逐 渐 走 向 了 对 于 极 端 民 族 主 义 以 及 传 统 主 义 的 接 纳 。 为 了 实 现 中 华 民 族 的 伟 大 复 兴 ， 一 切 代 价 都 可 以 是 能 被 背 负 的 ， 这 就 是 我 们 —— 毫 不 讽 刺 的 说 —— 现 在 的 路 线 。 就 让 社 会 帝 国 主 义 者 和 美 帝 国 主 义 者 们 说 去 吧 ： 中 华 必 将 雄 立 于 宇 宙 间 ， 支 配 世 界 民 族 之 林 ， 对 百 年 国 耻 一 劳 永 逸 的 报 仇 雪 恨 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 10)
				{
					fake_text += "|| 在 毛 主 席 去 世 后 ， 思 想 剧 变 。 我 们 党 在 四 处 的 攻 击 下 ， 逐 渐 走 向 了 党 的 指 导 思 想 的 进 一 步 自 主 化 。 最 终 ， 在 我 国 形 成 了 一 种 不 同 于 邓 小 平 设 想 的 “ 特 色 社 会 主 义 “ 框 架 ： 对 马 列 主 义 的 否 定 ， 对 辩 证 唯 物 主 义 的 否 定 ， 以 全 国 ， 全 社 会 以 及 全 人 民 的 独 立 自 主 ， 实 现 中 华 民 族 的 伟 大 复 兴 。 在 这 一 体 系 下 ， 伟 大 领 袖 的 地 位 无 愧 于 冉 冉 升 起 的 太 阳 ， 其 光 芒 逐 渐 的 ， 不 可 避 免 的 开 始 让 舵 手 本 人 黯 然 失 色 。 ";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 11)
				{
					fake_text += "|| 在 毛 主 席 去 世 后 ， 思 想 剧 变 。 着 迷 于 南 斯 拉 夫 的 模 式 ， 总 书 记 同 志 大 刀 阔 斧 地 对 于 我 国 的 政 治 ， 经 济 以 及 文 化 进 行 改 革 。 取 消 了 国 家 所 有 制 以 接 纳 “ 工 人 自 治 ” 经 济 ， 在 广 泛 放 权 的 同 时 强 化 爱 国 主 义 的 地 位 。 世 界 很 好 奇 地 看 着 是 否 会 有 一 个 “ 铁 托 主 义 国 际 ” 的 形 成 … 然 而 ， 南 斯 拉 夫 现 状 的 伤 痛 ， 是 否 有 一 天 会 出 现 在 我 们 的 经 济 里 ， 成 为 了 不 能 谈 的 话 题 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 12)
				{
					fake_text += "|| 在 毛 泽 东 去 世 后 ， 思 想 剧 变 ， 在 果 断 改 革 下 ， 我 党 逐 渐 否 定 了 黑 暗 的 过 去 - 所 谓 马 列 毛 思 想 ， 而 是 大 胆 地 基 于 美 国 文 明 为 蓝 本 改 造 我 们 的 社 会 。 意 志 坚 定 、 纪 律 严 明 ， 理 性 的 总 统 先 生 将 个 人 平 等 主 义 、 自 由 市 场 经 济 的 信 念 放 在 第 一 位 ， 积 极 地 打 击 旧 体 制 的 拥 护 者 ， 毫 不 犹 豫 地 践 行 着   “ 市 场 越 自 由 ， 人 越 自 由 “ 的 信 条 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 13)
				{
					fake_text += "|| 在 毛 主 席 去 世 后 ， 思 想 剧 变 。 我 们 党 在 四 处 的 攻 击 下 ， 不 得 不 做 出 紧 急 的 转 变 。 为 保 全 社 会 主 义 果 实 ， 在 我 党 内 出 现 了 一 种 以 稳 定 与 巩 固 政 权 优 先 ， 无 限 期 延 长 紧 急 状 态 的 主 导 思 潮 。 工 农 兵 因 强 国 而 需 艰 苦 奋 斗 ， 日 益 生 活 在 严 苛 的 生 活 环 境 下 的 同 时 ， 军 区 首 长 们 被 赋 予 了 强 大 的 权 力 ， 官 僚 们 裙 带 关 系 广 布 ， 治 国 暴 良 浴 唯 ， 我 们 国 旗 上 的 红 色 逐 渐 在 褪 色 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 14)
				{
					fake_text += "|| 在 毛 主 席 去 世 后 ， 思 想 剧 变 ， 邓 小 平 的 实 事 求 是 观 点 虽 然 可 以 迈 向 初 步 的 自 由 化 ， 但 经 济 自 由 化 本 身 并 不 能 达 成 建 设 社 会 主 义 民 主 。 一 种 欧 洲 共 产 主 义 转 型 发 生 了 - 议 会 民 主 、 多 党 竞 选 、 政 治 多 元 、 宪 法 至 上 ， 这 些 价 值 也 被 加 入 了 特 色 社 会 主 义 理 论 。 时 间 将 证 明 我 们 的 路 线 是 否 正 确 … …";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 15)
				{
					fake_text += "|| 我 党 实 事 求 是 ， 接 纳 了 邓 小 平 提 出 的 “ 中 国 特 色 社 会 主 义 理 论 ” 。 中 国 依 然 处 在 ， 而 且 将 长 期 处 在 社 会 主 义 初 级 阶 段 ， 在 和 平 与 发 展 是 当 代 世 界 两 大 主 题 的 时 代 ， 小 康 社 会 和 共 同 富 裕 那 天 的 到 来 自 然 是 所 有 人 民 的 欲 望 … 而 他 们 正 在 等 待 那 一 天 的 到 来 。";
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 16)
				{
					if (!GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[90] == 1)
					{
						fake_text += "|| 自 充 分 意 识 到 毛 主 义 的 唯 意 志 主 义 性 质 后 ， 我 们 便 决 心 与 其 分 道 扬 镳 ： 随 后 ， 党 便 剔 除 了 最 狂 热 的 小 资 产 阶 级 阴 谋 家 ， 恢 复 了 其 应 有 的 革 命 与 先 进 性 。 如 今 ， 我 们 已 然 回 归 本 源 ， 并 通 过 “ 狸 猫 换 太 子 ” 的 战 术 发 扬 社 会 主 义 优 越 性 ： 党 代 表 全 体 中 国 人 民 行 使 领 导 权 ； 计 委 在 确 保 自 主 管 理 的 基 础 上 统 筹 规 划 ； 人 民 的 物 质 利 益 已 得 到 法 律 的 充 分 保 障 ； 国 内 各 种 思 潮 也 在 社 会 主 义 民 族 文 化 的 统 摄 下 相 对 相 安 无 事 ， 并 纷 纷 接 受 党 的 领 导 ； 由 此 ， 中 国 人 民 将 本 身 也 在 团 结 、 友 爱 、 稳 定 、 繁 荣 的 氛 围 内 融 为 一 体 … … 面 对 这 一 全 新 格 局 ， 不 乏 有 人 嘲 笑 说 。 只 要 将 中 国 的 法 定 货 币 由 人 民 币 改 成 卢 布 ， 那 么 该 国 人 民 便 能 完 全 步 入 发 达 社 会 主 义 新 境 界 了 … … ";
					}
					else
					{
						fake_text += "|| 自 充 分 意 识 到 毛 主 义 的 唯 意 志 主 义 性 质 后 ， 我 们 便 决 心 与 其 分 道 扬 镳 ： 随 后 ， 党 便 开 始 进 行 自 我 革 命 ， 重 新 定 义 其 意 识 形 态 与 组 织 性 质 ， 坚 决 地 同 过 往 的 错 误 一 刀 两 断 。 而 如 今 ， 我 们 已 然 回 归 正 途 ， 并 将 修 正 马 克 思 主 义 与 威 胁 国 际 社 会 主 义 事 业 的 投 机 者 们 纷 纷 扫 入 历 史 的 垃 圾 堆 ： 党 得 以 代 表 全 体 中 国 人 民 行 使 领 导 权 ； 计 委 则 在 确 保 自 主 管 理 的 基 础 上 统 筹 规 划 ； 人 民 的 物 质 利 益 也 已 得 到 法 律 的 充 分 保 障 … … 对 转 型 的 困 惑 很 快 便 被 新 政 策 下 切 实 的 经 济 利 益 给 堵 上 了 嘴 ， 转 型 期 内 跳 出 的 激 进 分 子 也 被 国 安 局 绳 之 以 法 。 西 方 国 家 的 政 客 已 将 新 秩 序 冠 以 “ 东 方 版 勃 列 日 涅 夫 停 滞 ” 之 名 — — 他 们 显 然 在 胡 说 八 道 。 至 少 ， 中 国 的 新 一 代 领 导 集 体 的 平 均 年 龄 可 没 苏 联 那 么 高 … … ";
					}
				}
				if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 17)
				{
					fake_text += "|| 胸 怀 朝 阳 何 所 惧 ， 全 党 全 国 各 族 人 民 团 结 一 心 ， 坚 定 不 移 ， 继 续 高 举 毛 泽 东 思 想 伟 大 旗 帜 ， 将 中 国 革 命 的 长 征 路 持 之 以 恒 走 下 去 ！ 漫 长 的 文 化 革 命 既 锻 炼 了 党 自 我 革 命 的 胆 识 ， 培 育 了 一 代 敢 于 斗 争 ， 善 于 斗 争 的 革 命 小 将 ； 又 在 同 时 狠 挖 中 国 封 资 修 势 力 根 子 ， 并 将 其 代 表 思 潮 与 人 物 纷 纷 抛 入 历 史 垃 圾 堆 。 如 今 ， 毛 主 席 对 中 国 未 来 的 规 划 已 然 成 为 颠 扑 不 破 的 真 理 。 人 民 已 然 可 以 自 豪 的 喊 出 ： 革 命 无 罪 ， 造 反 有 理 ！ 怀 疑 一 切 的 革 命 精 神 万 岁 ！";
				}
			}
			if (!flag && !flag3 && !flag2 && !flag4 && !flag5 && !flag6)
			{
				if (GlobalScript.inst.gameState.data[16] == 10)
				{
					if (!GlobalScript.inst.gameState.modifies[11].active)
					{
						if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)
						{
							fake_text += "\n\n 遵 循 苏 联 模 式 样 板 ， 我 们 得 以 逐 步 建 立 起 计 划 经 济 制 度 所 需 的 物 质 基 础 ， 并 彻 底 实 现 了 国 内 各 部 门 的 统 筹 管 理 ： 国 内 生 产 部 门 或 隶 属 “ 全 民 所 有 ” 名 义 下 的 国 家 专 营 ， 或 归 属 集 体 控 制 。 前 者 按 照 国 家 计 委 的 统 一 规 划 工 作 ， 重 在 满 足 生 产 指 标 与 生 产 力 增 长 需 求 ； 后 者 则 充 当 丰 富 消 费 品 市 场 的 补 充 ， 并 根 据 一 套 考 核 机 制 逐 渐 整 合 进 入 逐 渐 壮 大 的 国 营 经 济 体 系 内 。 对 劳 动 力 市 场 、 工 资 与 价 格 的 控 制 使 失 业 、 不 平 等 与 生 产 过 剩 均 成 为 了 历 史 。 然 而 ， 集 中 体 制 也 会 产 生 它 自 己 的 问 题 ： 如 难 以 吸 纳 社 会 诸 要 素 共 治 ， 物 流 管 理 困 难 ， 计 划 存 在 偏 差 等 。 可 即 便 如 此 ， 我 们 仍 能 证 明 基 于 计 划 经 济 打 造 的 社 会 主 义 模 式 可 以 作 为 经 典 资 本 主 义 或 混 合 市 场 经 济 的 替 代 方 案 。 ";
						}
						else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
						{
							fake_text += "\n\n 遵 循 苏 联 模 式 样 板 ， 我 们 得 以 逐 步 建 立 起 计 划 经 济 制 度 所 需 的 物 质 基 础 ， 并 彻 底 实 现 了 国 内 各 部 门 的 统 筹 管 理 ： 遵 循 经 济 核 算 原 则 ， 我 们 将 以 货 币 形 式 ， 而 非 商 品 产 量 来 计 算 各 类 企 业 的 效 益 水 平 。 确 保 在 国 家 统 筹 全 局 的 同 时 促 使 企 业 优 化 财 政 效 率 。 与 此 同 时 ， 我 们 还 放 开 了 对 消 费 品 领 域 的 监 管 ， 允 许 该 领 域 内 组 建 集 体 合 作 社 或 规 模 有 限 的 私 营 经 济 形 式 以 充 盈 市 场 ， 并 积 累 社 会 资 金 。 然 而 ， 适 当 引 入 市 场 要 素 的 集 中 体 制 也 会 产 生 它 自 己 的 问 题 ： 价 格 波 动 将 持 续 困 扰 消 费 者 ， 自 由 竞 争 与 企 业 的 降 本 增 效 也 可 能 导 致 恶 性 对 抗 ， 更 别 提 国 营 企 业 与 在 国 家 计 委 该 体 系 下 获 得 的 “ 选 手 兼 裁 判 ” 地 位 — — 它 们 既 有 接 受 国 家 保 障 的 自 由 ， 也 有 通 过 竞 争 排 挤 对 手 的 自 由 。 批 评 者 已 将 我 们 的 新 经 济 视 为 “ 半 吊 子 市 场 审 计 ” ， “ 新 ” 新 经 济 与 “ 铁 饭 碗 ” 帝 国 ， 并 担 忧 政 商 勾 结 与 法 团 统 制 格 局 的 形 成 。 好 吧 ， 至 少 我 们 多 少 能 靠 这 套 体 制 避 免 纯 粹 计 划 经 济 或 经 典 市 场 经 济 的 一 系 列 问 题 。 ";
						}
						else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
						{
							fake_text += "\n\n 遵 循 苏 联 模 式 样 板 ， 我 们 得 以 逐 步 建 立 起 计 划 经 济 制 度 所 需 的 物 质 基 础 ， 并 彻 底 实 现 了 国 内 各 部 门 的 统 筹 管 理 ： 中 国 领 导 层 完 成 了 尼 基 塔 · 赫 鲁 晓 夫 的 未 竟 之 事 ， 在 国 内 彻 底 消 灭 了 合 作 企 业 与 劳 动 组 合 ， 并 将 国 内 所 有 集 体 农 庄 改 组 为 国 营 农 场 ， 农 民 则 全 体 转 型 农 业 工 人 。 企 业 自 我 管 理 的 可 能 也 被 完 全 根 除 ， 它 们 被 整 合 在 依 靠 功 能 划 定 的 国 家 计 委 各 组 别 内 。 最 终 达 到 国 家 拿 捏 全 国 各 地 经 济 体 制 与 物 流 体 系 ， 形 成 了 精 确 到 神 经 末 梢 的 大 统 制 格 局 ， 一 切 指 标 均 可 均 由 国 家 预 先 计 算 。 然 而 ， 空 前 的 国 有 化 与 极 精 细 的 计 划 本 身 便 意 味 着 打 造 “ 锁 链 连 着 锁 链 ” 的 巨 型 官 僚 体 制 ， 并 将 其 同 国 内 现 有 的 党 务 体 制 合 二 为 一 。 国 家 计 委 也 就 此 膨 胀 为 了 “ 经 济 沙 皇 ” ， 并 通 过 类 似 党 管 干 部 与 绩 效 考 核 的 老 办 法 进 行 层 层 控 制 … … 有 心 人 已 将 其 同 霍 布 斯 的 “ 利 维 坦 ” 相 提 并 论 ， 但 这 只 是 它 们 的 臆 想 ， 不 是 吗 ？ ";
						}
					}
					else
					{
						fake_text += "\n\n 江 山 代 有 才 人 出 ， 各 领 风 骚 数 百 年 。 我 们 试 图 统 筹 国 家 计 委 实 现 “ 全 国 一 盘 棋 ” 的 思 想 与 现 代 科 学 技 术 成 就 的 努 力 结 出 了 硕 果 ， 形 成 了 网 络 数 据 中 心 - 中 级 交 互 中 心 - 各 经 济 部 门 终 端 间 相 互 沟 通 ， 并 由 国 家 计 委 全 权 负 责 的 多 层 网 络 格 局 ： 各 经 济 部 门 与 产 业 组 织 的 计 算 机 化 使 企 业 与 国 家 机 构 间 的 信 息 交 换 与 协 调 几 乎 在 瞬 间 发 生 ， 并 改 变 了 国 家 计 划 的 运 行 方 式 。 原 有 的 计 划 指 标 被 申 请 制 度 取 代 ： 有 关 部 门 可 按 季 度 搜 集 各 地 有 关 需 求 基 本 信 息 ， 国 家 计 委 则 根 据 相 关 数 据 制 定 计 划 ， 并 以 申 请 招 标 形 式 公 示 。 各 地 企 业 与 国 营 农 村 则 有 义 务 根 据 其 能 力 确 认 其 可 完 成 的 年 度 生 产 指 标 。 超 产 产 量 则 通 过 专 门 海 关 出 口 国 外 。 因 此 ， 经 济 活 动 获 得 了 额 外 的 灵 活 性 ： 计 划 部 门 足 以 轻 易 的 调 整 经 济 运 算 ； 而 集 体 农 场 、 企 业 与 商 店 也 都 能 摆 脱 官 僚 主 义 繁 文 缛 节 ， 转 而 依 靠 各 自 协 作 、 自 主 适 应 的 方 式 解 决 问 题 。 与 此 同 时 ， 我 们 还 得 以 通 过 搭 建 电 子 支 付 平 台 与 数 字 化 金 融 手 段 废 除 了 现 金 交 易 ， 并 以 中 央 银 行 同 各 地 企 业 的 基 础 建 立 了 计 算 劳 动 贡 献 的 网 络 账 户 。 因 此 ， 我 们 建 立 了 史 无 前 例 的 经 济 体 制 ， 彻 底 告 别 了 腐 败 、 赤 字 、 缺 乏 参 与 与 物 资 协 调 困 难 等 问 题 ， 并 为 建 立 基 于 计 算 机 平 台 的 间 接 民 主 形 式 创 造 了 可 能 。 然 而 ， 考 虑 到 现 行 计 算 机 系 统 的 局 限 性 ， 该 系 统 仍 然 存 在 一 些 错 误 和 问 题 ， 并 同 时 受 到 传 统 官 僚 与 潜 在 敌 对 分 子 的 威 胁 。 有 些 人 甚 至 说 ， 新 经 济 的 实 质 不 过 是 打 造 “ 首 都 主 义 ” 与 “ 计 委 独 大 ” 格 局 ， 甚 至 有 让 领 导 人 成 为 “ 终 产 者 ” 的 野 心 。 任 他 们 纠 缠 去 罢 — — 毕 竟 ， 我 们 已 走 在 着 手 解 决 计 划 经 济 根 本 问 题 ， 并 向 共 产 主 义 大 步 前 进 的 路 上 。 ";
					}
				}
				else if (GlobalScript.inst.gameState.data[16] == 11)
				{
					if (!GlobalScript.inst.gameState.modifies[11].active)
					{
						if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)
						{
							fake_text += "\n\n 依 托 毛 主 席 留 下 的 遗 产 与 一 系 列 老 制 度 ， 我 们 得 以 维 持 并 深 化 分 权 计 划 经 济 体 制 ， 最 终 将 彼 时 的 权 宜 之 计 变 为 了 一 项 系 统 化 制 度 ： 经 济 链 条 中 的 全 部 环 节 将 连 同 经 济 体 本 身 均 无 条 件 服 从 于 国 家 计 划 委 员 会 的 经 济 指 令 、 决 议 与 五 年 计 划 指 标 。 但 前 者 均 建 立 在 经 济 体 内 劳 动 集 体 的 领 导 上 ： 他 们 对 内 部 管 理 部 门 、 人 事 任 命 享 有 大 权 ， 并 通 过 内 部 投 票 形 式 实 施 监 管 。 由 此 ， 我 国 经 济 发 展 得 以 在 统 筹 中 央 领 导 的 基 础 上 发 挥 地 方 主 观 能 动 性 ， 实 现 因 地 制 宜 组 织 生 产 建 设 ； 经 济 单 位 内 也 得 以 遵 循 两 参 一 改 三 结 合 经 验 ， 并 逐 渐 向 劳 动 组 织 等 多 种 团 体 形 式 开 门 ， 鼓 励 人 民 群 众 参 与 对 地 方 政 府 与 生 产 过 程 的 管 理 与 监 督 中 。 不 受 国 家 调 控 的 部 分 则 被 私 人 副 业 、 集 体 产 业 与 依 托 地 方 的 乡 镇 经 济 所 补 充 ， 并 通 过 公 有 部 门 的 优 势 地 位 实 现 管 控 ， 不 至 掀 起 风 浪 。 由 此 ， 我 们 得 以 有 效 遏 制 官 僚 主 义 、 主 观 主 义 和 基 于 产 业 的 宗 派 主 义 ， 并 确 保 各 要 素 围 绕 社 会 主 义 主 轴 发 展 。 当 然 ， 该 体 制 依 然 存 在 一 系 列 问 题 ： 如 物 流 管 理 困 难 ， 计 划 存 在 偏 差 ， 央 地 利 益 协 调 等 。 有 人 将 其 称 之 为 是 “ 人 造 奶 油 计 划 经 济 ” 与 另 类 “ 斯 大 林 模 式 ” 。 任 他 们 纠 缠 去 罢 — — 毕 竟 我 们 有 信 心 将 其 完 善 并 继 续 走 下 去 ， 最 终 朝 共 产 主 义 大 踏 步 前 进 ！ ";
						}
						else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
						{
							fake_text += "\n\n 依 托 毛 时 代 留 下 的 遗 产 与 一 系 列 老 制 度 ， 我 们 得 以 维 持 并 深 化 分 权 计 划 经 济 体 制 ， 最 终 将 彼 时 的 权 宜 之 计 变 为 了 一 项 系 统 化 制 度 ： 国 家 计 划 委 员 会 的 经 济 指 令 、 决 议 与 五 年 计 划 指 标 仍 在 相 当 范 围 发 挥 效 力 ， 但 该 组 织 的 内 部 迎 来 了 基 于 地 区 、 产 业 、 民 族 与 政 治 团 体 代 表 等 多 种 形 式 的 配 额 制 度 ， 并 仿 造 参 议 院 的 框 架 形 成 了 平 行 于 此 的 咨 询 与 监 督 机 构 ， 由 此 保 证 计 划 遵 循 “ 协 和 民 主 ” 的 原 则 。 各 地 企 业 也 根 据 协 商 逻 辑 与 参 与 式 经 济 学 的 理 论 接 受 改 组 ， 随 后 便 或 根 据 地 域 、 或 根 据 行 业 、 或 根 据 其 产 业 社 区 形 成 自 治 的 经 济 联 合 体 ， 在 贯 彻 自 我 管 理 与 合 作 原 则 的 同 时 以 招 标 形 式 接 受 国 家 计 划 。 因 此 ， 中 国 的 经 济 版 图 变 得 空 前 多 元 ， 并 因 地 制 宜 生 成 了 类 似 南 斯 拉 夫 的 国 中 之 国 ： 经 济 联 合 体 办 社 会 的 现 实 正 在 国 民 内 培 育 一 种 社 区 主 义 情 节 ， 它 们 本 身 也 日 趋 转 化 为 现 代 版 本 的 封 地 。 其 成 员 同 国 家 间 的 关 系 也 趋 于 淡 漠 。 仅 靠 向 国 家 计 委 输 送 代 表 与 完 成 指 标 、 接 受 犒 劳 的 方 式 维 持 着 某 种 联 系 。 虽 说 古 怪 的 “ 民 主 集 中 制 ” 招 来 的 赞 誉 与 批 评 声 不 相 上 下 ， 可 我 们 至 少 可 说 自 己 确 实 建 立 了 有 中 国 特 色 的 经 济 制 度 。 ";
						}
						else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
						{
							fake_text += "\n\n 依 托 毛 主 席 留 下 的 遗 产 与 一 系 列 老 制 度 ， 我 们 得 以 维 持 并 深 化 分 权 计 划 经 济 体 制 ， 最 终 将 彼 时 的 权 宜 之 计 变 为 了 一 项 系 统 化 制 度 ： 国 家 计 划 委 员 会 事 实 上 仅 浮 于 表 面 ， 流 于 形 式 ； 其 实 权 被 基 于 行 业 构 建 的 管 理 组 织 取 而 代 之 。 履 行 计 划 职 能 的 科 学 与 产 业 组 织 协 会 正 根 据 就 近 原 则 合 并 大 量 企 业 、 农 村 组 织 与 教 育 机 构 ， 形 成 巨 大 的 集 团 式 国 营 企 业 。 最 终 达 到 在 经 济 体 的 各 大 部 门 内 实 现 生 产 、 开 采 与 人 员 调 配 统 一 调 度 的 作 用 。 一 种 基 于 技 术 挂 帅 的 分 权 就 此 形 成 ， 并 以 “ 协 商 委 员 会 ” 的 名 义 欢 迎 各 行 各 界 各 地 经 营 参 与 其 中 ， 对 经 济 组 织 进 行 监 督 并 行 驶 咨 询 权 。 因 此 ， 中 国 的 经 济 版 图 成 为 了 类 似 部 委 专 政 的 格 局 ： 各 地 行 业 都 正 效 法 中 国 最 早 的 “ 经 济 独 立 王 国 ” 铁 道 部 建 构 自 己 的 小 社 区 ， 并 逐 渐 围 绕 相 关 产 业 与 裙 带 关 系 形 成 名 号 各 异 的 政 治 帮 派 。 它 们 本 身 也 日 趋 转 化 为 现 代 版 本 的 小 宫 廷 。 其 成 员 同 国 家 间 的 关 系 也 趋 于 淡 漠 。 仅 靠 向 国 家 计 委 安 插 代 表 与 完 成 指 标 、 接 受 犒 劳 的 方 式 维 持 着 某 种 联 系 。 虽 说 古 怪 的 “ 百 家 争 鸣 模 式 ” 招 来 的 赞 誉 与 批 评 声 不 相 上 下 ， 可 我 们 至 少 可 说 自 己 确 实 建 立 了 有 中 国 特 色 的 经 济 制 度 。 ";
						}
					}
					else
					{
						fake_text += "\n\n 长 江 后 浪 推 前 浪 ， 世 上 新 人 赶 旧 人 。 我 们 试 图 统 筹 毛 时 代 争 取 群 众 直 接 参 与 管 理 国 家 的 思 想 与 现 代 科 学 技 术 成 就 的 努 力 结 出 了 硕 果 ， 形 成 了 网 络 数 据 中 心 - 中 级 交 互 中 心 - 各 经 济 部 门 终 端 间 相 互 沟 通 的 互 补 网 络 格 局 ： 各 经 济 部 门 与 产 业 组 织 的 计 算 机 化 使 企 业 与 国 家 机 构 间 的 信 息 交 换 与 协 调 几 乎 在 瞬 间 发 生 ， 并 改 变 了 国 家 计 划 的 运 行 方 式 。 原 有 的 计 划 指 标 被 申 请 制 度 取 代 ： 有 关 部 门 可 按 季 度 搜 集 各 地 有 关 需 求 基 本 信 息 ， 国 家 计 委 则 根 据 相 关 数 据 制 定 计 划 ， 并 以 申 请 招 标 形 式 公 示 。 各 地 企 业 与 国 营 农 村 则 有 义 务 根 据 其 能 力 确 认 其 可 完 成 的 年 度 生 产 指 标 。 超 产 产 量 则 通 过 专 门 海 关 出 口 国 外 。 因 此 ， 经 济 活 动 获 得 了 额 外 的 灵 活 性 ： 计 划 部 门 足 以 轻 易 的 调 整 经 济 运 算 ； 而 集 体 农 场 、 企 业 与 商 店 也 都 能 摆 脱 官 僚 主 义 繁 文 缛 节 ， 转 而 依 靠 各 自 协 作 、 自 主 适 应 的 方 式 解 决 问 题 。 与 此 同 时 ， 我 们 还 得 以 通 过 搭 建 电 子 支 付 平 台 与 数 字 化 金 融 手 段 废 除 了 现 金 交 易 ， 并 以 中 央 银 行 同 各 地 企 业 的 基 础 建 立 了 计 算 劳 动 贡 献 的 网 络 账 户 。 因 此 ， 我 们 建 立 了 史 无 前 例 的 经 济 体 制 ， 彻 底 告 别 了 腐 败 、 赤 字 、 缺 乏 参 与 与 物 资 协 调 困 难 等 问 题 ， 并 为 建 立 基 于 计 算 机 平 台 的 经 济 民 主 形 式 创 造 了 可 能 。 然 而 ， 考 虑 到 现 行 计 算 机 系 统 的 局 限 性 ， 该 系 统 仍 然 存 在 一 些 错 误 和 问 题 ， 并 同 时 受 到 传 统 官 僚 与 潜 在 敌 对 分 子 的 威 胁 。 有 些 人 甚 至 说 ， 新 经 济 的 实 质 不 过 是 打 造 “ 技 术 官 僚 专 政 ” 与 “ 电 子 法 西 斯 主 义 ” 。 任 他 们 纠 缠 去 罢 — — 毕 竟 ， 我 们 已 走 在 着 手 解 决 计 划 经 济 根 本 问 题 ， 并 向 共 产 主 义 大 步 前 进 的 路 上 。 ";
					}
				}
				else if (GlobalScript.inst.gameState.data[16] == 12)
				{
					if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)
					{
						fake_text += "\n\n 我 们 决 定 走 周 恩 来 总 理 调 整 经 济 的 老 路 ， 即 在 确 保 国 家 主 导 的 基 础 上 建 立 一 个 可 良 好 运 转 的 经 济 模 型 ： 我 们 放 开 了 对 农 业 的 统 制 ， 允 许 包 括 家 庭 联 产 承 包 在 内 的 多 种 经 营 形 式 ， 并 在 同 时 以 义 务 交 售 与 价 格 保 护 实 行 干 预 。 工 业 领 域 则 基 本 呈 现 国 企 一 家 独 大 格 局 ， 并 在 除 战 略 性 企 业 外 的 部 门 内 推 行 经 济 核 算 。 那 些 通 过 外 贸 垄 断 制 度 关 卡 ， 得 到 国 家 授 权 的 外 国 企 业 、 少 数 小 中 华 地 区 私 人 贸 易 商 及 其 合 营 资 产 则 成 为 中 国 发 展 外 向 型 经 济 与 引 进 技 术 ， 并 积 累 资 金 的 重 要 补 充 。 中 国 经 济 就 此 走 上 了 提 质 增 效 的 正 轨 。 然 而 ， 党 内 的 保 守 派 正 担 忧 商 品 货 币 关 系 与 “ 资 本 主 义 复 辟 ” 间 无 法 割 舍 的 联 系 ； 民 间 也 对 我 们 保 持 “ 不 上 不 下 ” 与 “ 社 会 主 义 商 品 生 产 ” 格 局 的 行 为 而 躁 动 。 我 们 似 乎 正 处 于 兼 具 社 会 主 义 与 资 本 主 义 特 质 的 叠 加 态 ， 并 将 长 期 处 于 过 渡 阶 段 。 至 于 未 来 是 从 资 本 主 义 走 向 社 会 主 义 ， 还 是 自 社 会 主 义 回 归 资 本 主 义 ， 那 是 属 于 未 来 一 代 人 的 问 题 … … ";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
					{
						fake_text += "\n\n 我 们 决 定 走 周 恩 来 总 理 调 整 经 济 的 老 路 ， 即 在 确 保 国 家 主 导 的 基 础 上 建 立 一 个 可 良 好 运 转 的 经 济 模 型 ： 我 们 放 开 了 对 农 业 的 统 制 ， 允 许 包 括 家 庭 联 产 承 包 在 内 的 多 种 经 营 形 式 ， 并 在 同 时 以 义 务 交 售 与 价 格 保 护 实 行 干 预 。 工 业 领 域 则 基 本 呈 现 国 企 一 家 独 大 格 局 ， 并 在 除 战 略 性 企 业 外 的 部 门 内 推 行 经 济 核 算 。 那 些 通 过 外 贸 垄 断 制 度 关 卡 ， 得 到 国 家 授 权 的 外 国 企 业 、 少 数 小 中 华 地 区 私 人 贸 易 商 及 其 合 营 资 产 则 成 为 中 国 发 展 外 向 型 经 济 与 引 进 技 术 ， 并 积 累 资 金 的 重 要 补 充 。 中 国 经 济 就 此 走 上 了 提 质 增 效 的 正 轨 。 然 而 ， 党 内 的 保 守 派 正 担 忧 商 品 货 币 关 系 与 “ 资 本 主 义 复 辟 ” 间 无 法 割 舍 的 联 系 ； 民 间 也 对 我 们 保 持 “ 不 上 不 下 ” 与 “ 社 会 主 义 商 品 生 产 ” 格 局 的 行 为 而 躁 动 。 不 过 ， 考 虑 到 我 们 对 此 表 示 满 意 ， 那 便 足 够 了 — — “ 中 国 特 色 社 会 主 义 ” 事 实 上 得 以 确 立 ， 并 在 综 合 多 种 经 济 制 度 优 势 的 情 况 下 走 出 了 折 中 道 路 ， 切 实 确 保 了 数 亿 中 国 人 民 的 生 计 与 饭 碗 。 ";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
					{
						fake_text += "\n\n 我 们 决 定 走 周 恩 来 总 理 调 整 经 济 的 老 路 ， 即 在 确 保 国 家 主 导 的 基 础 上 建 立 一 个 可 良 好 运 转 的 经 济 模 型 ： 我 们 放 开 了 对 农 业 的 统 制 ， 允 许 包 括 家 庭 联 产 承 包 在 内 的 多 种 经 营 形 式 ， 并 在 同 时 以 义 务 交 售 与 价 格 保 护 实 行 干 预 。 工 业 领 域 则 基 本 呈 现 国 企 一 家 独 大 格 局 ， 并 在 除 战 略 性 企 业 外 的 部 门 内 推 行 经 济 核 算 。 那 些 通 过 外 贸 垄 断 制 度 关 卡 ， 得 到 国 家 授 权 的 外 国 企 业 、 少 数 小 中 华 地 区 私 人 贸 易 商 及 其 合 营 资 产 则 成 为 中 国 发 展 外 向 型 经 济 与 引 进 技 术 ， 并 积 累 资 金 的 重 要 补 充 。 中 国 经 济 就 此 走 上 了 提 质 增 效 的 正 轨 。 然 而 ， 党 内 的 保 守 派 正 担 忧 商 品 货 币 关 系 与 “ 资 本 主 义 复 辟 ” 间 无 法 割 舍 的 联 系 ； 民 间 也 对 我 们 保 持 “ 不 上 不 下 ” 与 “ 社 会 主 义 商 品 生 产 ” 格 局 的 行 为 而 躁 动 。 然 而 ， 这 一 切 都 符 合 我 党 推 进 国 民 经 济 实 现 自 给 自 足 ， 自 力 更 生 的 目 标 ： 由 于 民 用 领 域 已 基 本 交 付 民 族 资 本 运 营 ， 这 让 我 们 得 以 将 注 意 力 集 中 在 更 加 需 要 伟 大 领 袖 直 接 过 问 的 经 济 领 域 内 — — 如 民 防 事 业 、 能 源 交 通 乃 至 核 武 器 生 产 。 出 于 备 战 备 荒 为 人 民 的 需 要 ， 我 们 还 将 曾 在 边 疆 地 区 试 点 的 建 设 兵 团 与 移 民 城 市 制 度 发 扬 光 大 ， 并 充 分 吸 取 了 苏 联 秘 密 行 政 区 的 经 验 统 筹 发 展 与 安 全 两 大 任 务 。 虽 说 这 种 平 行 行 政 框 架 常 被 人 诟 病 为 “ 新 时 代 冗 官 冗 兵 ” 与 “ 屯 田 耕 战 制 度 ” ， 可 我 们 多 少 能 依 托 此 保 障 国 家 经 济 安 全 ， 快 速 形 成 民 转 军 优 势 ， 并 为 可 能 到 来 的 世 界 大 战 做 好 准 备 。 ";
					}
					else
					{
						fake_text += "\n\n 改 革 永 远 在 路 上 — — 试 图 探 索 某 种 “ 社 会 主 义 ” 的 实 践 很 快 便 随 政 治 局 势 巨 变 而 迎 来 了 终 结 ： 师 从 周 恩 来 的 模 式 也 被 嘲 笑 为 “ 中 国 版 准 许 证 经 济 ” 与 热 心 重 复 啰 嗦 ， 仰 仗 裹 脚 布 打 造 官 僚 主 义 繁 文 缛 节 的 无 用 功 ， 它 本 身 也 被 更 加 去 管 制 化 的 市 场 经 济 转 型 方 案 取 而 代 之 。 可 考 虑 到 “ 中 国 版 准 许 证 ” 切 实 奠 定 了 一 代 人 的 经 济 生 活 ， 我 们 很 难 说 中 国 未 来 将 迎 来 哪 类 市 场 经 济 ： 分 析 者 预 估 社 会 市 场 经 济 或 法 团 主 义 将 成 为 最 大 赢 家 。";
					}
				}
				else if (GlobalScript.inst.gameState.data[16] == 13)
				{
					if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)
					{
						fake_text += "\n\n 陈 云 的 理 念 取 得 了 胜 利 ： 通 过 经 济 改 革 ， 我 们 得 以 改 变 国 家 干 预 的 作 用 方 式 ， 以 行 政 法 规 逐 渐 取 代 对 经 济 部 门 的 行 政 命 令 ， 就 此 形 成 主 导 的 市 场 框 架 。 我 们 在 保 持 对 国 计 民 生 行 业 垄 断 ， 促 使 相 关 行 业 转 向 经 济 核 算 的 同 时 放 开 了 多 种 经 营 形 式 ， 并 通 过 经 济 特 区 为 国 际 贸 易 与 外 商 投 资 中 国 提 供 了 开 放 渠 道 。 只 要 在 行 业 内 未 形 成 私 人 垄 断 或 外 商 控 股 的 格 局 ， 我 们 将 充 分 尊 重 私 营 企 业 家 的 行 动 自 由 ， 并 为 公 民 自 主 经 营 、 自 负 盈 亏 提 供 便 利 。 经 由 广 泛 而 深 刻 的 国 家 干 预 ， 混 合 社 会 主 义 和 资 本 主 义 优 势 的 “ 有 计 划 商 品 生 产 ” 就 此 形 成 ， 并 在 综 合 双 方 优 势 的 同 时 自 然 整 合 了 双 面 的 弊 端 。 显 然 ， 自 由 市 场 支 持 者 与 正 统 共 产 主 义 者 都 不 会 对 它 抱 有 好 感 。 接 入 国 际 贸 易 与 价 格 的 自 由 化 使 得 我 国 经 济 将 不 可 避 免 地 受 到 投 资 环 境 与 全 球 分 工 体 系 变 化 的 影 响 ， 并 可 能 遭 遇 经 济 危 机 。 部 分 党 员 与 国 际 社 会 已 将 新 体 制 冠 以 “ 金 元 社 会 主 义 ” 之 名 ， 并 将 其 同 苏 东 国 家 的 格 局 相 提 并 论 。 可 考 虑 到 我 们 对 此 表 示 满 意 ， 那 便 足 够 了 ： 国 家 占 据 制 高 点 的 客 观 现 实 ， 以 及 我 党 对 共 产 主 义 的 绝 对 忠 诚 。 足 以 确 保 宏 观 调 控 的 科 学 性 ， 并 确 保 商 品 生 产 为 社 会 主 义 与 共 同 富 裕 服 务 的 基 本 性 质 。";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
					{
						fake_text += "\n\n 陈 云 的 理 念 取 得 了 胜 利 ： 通 过 经 济 改 革 ， 我 们 得 以 改 变 国 家 干 预 的 作 用 方 式 ， 以 行 政 法 规 逐 渐 取 代 对 经 济 部 门 的 行 政 命 令 ， 就 此 形 成 主 导 的 市 场 框 架 。 我 们 在 保 持 对 国 计 民 生 行 业 垄 断 ， 促 使 相 关 行 业 转 向 经 济 核 算 的 同 时 放 开 了 多 种 经 营 形 式 ， 并 通 过 经 济 特 区 为 国 际 贸 易 与 外 商 投 资 中 国 提 供 了 开 放 渠 道 。 只 要 在 行 业 内 未 形 成 私 人 垄 断 或 外 商 控 股 的 格 局 ， 我 们 将 充 分 尊 重 私 营 企 业 家 的 行 动 自 由 ， 并 为 公 民 自 主 经 营 、 自 负 盈 亏 提 供 便 利 。 经 由 广 泛 而 深 刻 的 国 家 干 预 ， 混 合 社 会 主 义 和 资 本 主 义 优 势 的 “ 有 计 划 商 品 生 产 ” 就 此 形 成 ， 并 在 综 合 双 方 优 势 的 同 时 自 然 整 合 了 双 面 的 弊 端 。 显 然 ， 自 由 市 场 支 持 者 与 正 统 共 产 主 义 者 都 不 会 对 它 抱 有 好 感 。 接 入 国 际 贸 易 与 价 格 的 自 由 化 使 得 我 国 经 济 将 不 可 避 免 地 受 到 投 资 环 境 与 全 球 分 工 体 系 变 化 的 影 响 ， 并 可 能 遭 遇 经 济 危 机 。 部 分 党 员 与 国 际 社 会 已 将 新 体 制 冠 以 “ 金 元 社 会 主 义 ” 之 名 ， 并 将 其 同 苏 东 国 家 的 格 局 相 提 并 论 。 可 考 虑 到 我 们 对 此 表 示 满 意 ， 那 便 足 够 了 ： 既 然 南 斯 拉 夫 与 匈 牙 利 等 国 家 开 创 的 前 例 能 够 运 转 良 好 ， 那 么 我 们 按 图 索 骥 的 “ 新 ” 新 经 济 政 策 将 会 以 其 生 动 实 践 超 越 教 条 主 义 和 资 本 主 义 ， 并 证 明 自 身 的 优 越 性 。 ";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
					{
						fake_text += "\n\n 陈 云 的 理 念 取 得 了 胜 利 ： 通 过 经 济 改 革 ， 我 们 得 以 改 变 国 家 干 预 的 作 用 方 式 ， 以 行 政 法 规 逐 渐 取 代 对 经 济 部 门 的 行 政 命 令 ， 就 此 形 成 主 导 的 市 场 框 架 。 我 们 在 保 持 对 国 计 民 生 行 业 垄 断 ， 促 使 相 关 行 业 转 向 经 济 核 算 的 同 时 放 开 了 多 种 经 营 形 式 ， 并 通 过 经 济 特 区 为 国 际 贸 易 与 外 商 投 资 中 国 提 供 了 开 放 渠 道 。 只 要 在 行 业 内 未 形 成 私 人 垄 断 或 外 商 控 股 的 格 局 ， 我 们 将 充 分 尊 重 私 营 企 业 家 的 行 动 自 由 ， 并 为 公 民 自 主 经 营 、 自 负 盈 亏 提 供 便 利 。 经 由 广 泛 而 深 刻 的 国 家 干 预 ， 混 合 社 会 主 义 和 资 本 主 义 优 势 的 “ 有 计 划 商 品 生 产 ” 就 此 形 成 ， 并 在 综 合 双 方 优 势 的 同 时 自 然 整 合 了 双 面 的 弊 端 。 显 然 ， 自 由 市 场 支 持 者 与 正 统 共 产 主 义 者 都 不 会 对 它 抱 有 好 感 。 接 入 国 际 贸 易 与 价 格 的 自 由 化 使 得 我 国 经 济 将 不 可 避 免 地 受 到 投 资 环 境 与 全 球 分 工 体 系 变 化 的 影 响 ， 并 可 能 遭 遇 经 济 危 机 。 国 家 干 预 与 党 政 制 度 的 整 合 又 事 实 上 滋 生 了 一 批 背 靠 政 商 勾 结 环 境 崛 起 的 新 兴 民 族 资 产 阶 级 ， 后 者 更 是 将 行 政 部 门 变 为 “ 选 择 透 过 性 ” 滤 膜 以 排 挤 竞 争 对 手 （ 这 便 是 部 分 经 济 特 区 采 取 竭 泽 而 渔 政 策 ， 吸 引 外 资 后 一 次 性 驱 逐 所 有 投 资 者 并 对 相 关 产 业 进 行 恶 意 征 购 的 原 因 ） — — 形 成 了 中 国 式 的 “ 自 力 更 生 ， 自 给 自 足 ” 制 度 ： 我 们 似 乎 回 到 了 建 国 前 寡 头 经 济 的 原 汁 原 味 ， 在 国 际 投 资 者 的 眼 中 形 象 两 极 分 化 ： 一 方 面 视 为 前 途 无 量 的 金 山 ， 另 一 方 面 则 视 为 投 资 黑 洞 与 流 氓 国 家 。 任 他 们 随 便 叫 嚷 罢 ： 毕 竟 中 国 地 大 物 博 ， 拒 绝 中 国 的 辽 阔 市 场 只 会 是 搬 起 石 头 砸 自 己 的 脚 的 愚 行 ！ ";
					}
					else
					{
						fake_text += "\n\n 改 革 永 远 在 路 上 — — 试 图 探 索 某 种 “ 社 会 主 义 ” 的 实 践 很 快 便 随 政 治 局 势 巨 变 而 迎 来 了 终 结 ： 混 合 社 会 主 义 和 资 本 主 义 优 势 的 “ 有 计 划 商 品 生 产 ”   被 嘲 笑 为 “ 中 国 版 准 许 证 经 济 ” 与 热 心 重 复 啰 嗦 ， 仰 仗 裹 脚 布 打 造 官 僚 主 义 繁 文 缛 节 的 无 用 功 ， 它 本 身 也 被 更 加 去 管 制 化 的 市 场 经 济 转 型 方 案 取 而 代 之 。 可 考 虑 到 “ 中 国 版 准 许 证 ” 切 实 奠 定 了 一 代 人 的 经 济 生 活 ， 我 们 很 难 说 中 国 未 来 将 迎 来 哪 类 市 场 经 济 ： 分 析 者 预 估 社 会 市 场 经 济 或 法 团 主 义 将 成 为 最 大 赢 家 。 ";
					}
				}
				else if (GlobalScript.inst.gameState.data[16] == 14)
				{
					if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
					{
						fake_text += "\n\n 我 们 吸 取 了 匈 牙 利 卡 达 尔 主 义 、 南 斯 拉 夫 铁 托 主 义 与 捷 克 斯 洛 伐 克 奥 塔 · 锡 克 的 系 列 经 验 ， 并 以 联 邦 德 国 的 社 会 市 场 为 蓝 本 力 行 “ 中 国 特 色 社 会 主 义 ” 的 新 政 得 以 圆 满 告 终 ： 虽 说 砸 碎 铁 饭 碗 等 改 革 造 成 了 相 当 阵 痛 与 一 定 时 期 的 社 会 动 荡 ， 可 从 左 翼 立 场 诠 释 凯 恩 斯 主 义 的 创 新 终 于 还 是 为 创 造 一 个 以 消 费 者 为 核 心 的 繁 荣 社 会 奠 定 了 基 础 ： 人 们 将 重 新 成 为 自 食 其 力 的 公 民 ， 政 府 也 将 尽 其 所 能 保 障 人 们 生 活 并 刺 激 需 求 增 长 。 多 种 经 营 形 式 均 告 合 法 ； 自 负 盈 亏 逻 辑 基 本 胜 利 ； 价 格 管 制 只 限 于 提 供 国 家 支 持 与 保 护 价 ； 即 便 是 国 营 企 业 也 只 是 平 等 参 与 市 场 竞 争 并 被 “ 重 点 关 注 ” ， 履 行 “ 指 导 指 标 ” 的 普 通 市 场 经 营 主 体 ； 社 会 各 团 体 也 得 以 获 得 参 与 经 济 活 动 的 发 言 权 ； 实 现 了 国 家 、 企 业 与 各 团 体 间 的 大 妥 协 。 反 垄 断 法 与 国 家 福 利 制 度 足 以 保 障 竞 争 自 由 逻 辑 在 尽 可 能 排 除 内 耗 与 贫 富 分 化 的 情 况 下 保 障 人 民 福 祉 。 虽 说 该 体 系 不 能 完 全 消 除 通 货 膨 胀 、 失 业 和 贫 富 差 距 ， 并 在 同 时 导 致 债 务 稳 定 增 长 ； 可 我 们 多 少 走 出 了 契 合 中 国 国 情 的 全 民 小 康 之 路 ， 并 成 为 了 世 界 各 地 眼 中 “ 创 造 性 运 用 社 会 主 义 ” 的 典 范 … … 中 国 正 享 受 自 己 的 黄 金 三 十 年 … … 希 望 一 直 如 此 … … ";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
					{
						fake_text += "\n\n 最 终 ， “ 中 国 特 色 社 会 主 义 ” 成 为 了 新 一 轮 威 权 主 义 运 动 的 代 名 词 ： 我 们 的 经 济 改 革 造 就 了 凯 恩 斯 主 义 与 法 团 主 义 的 二 人 转 。 国 家 专 门 支 持 国 内 的 创 业 创 新 人 士 ， 并 计 划 将 其 整 合 到 由 最 强 大 且 最 有 价 值 的 市 场 操 盘 手 们 共 同 构 成 的 “ 民 族 企 业 ” 内 。 我 们 在 收 拢 劳 动 控 制 ， 强 化 生 产 纪 律 ， 将 各 地 工 厂 转 化 为 兵 营 的 同 时 维 持 一 定 限 度 的 社 会 保 障 与 公 共 服 务 事 业 ， 以 确 保 国 内 主 要 的 劳 动 人 口 在 维 持 基 本 生 活 水 准 的 同 时 最 大 限 度 提 升 效 率 并 参 与 再 生 产 。 对 所 有 制 ， 价 格 管 控 与 国 家 干 预 方 式 的 争 论 也 被 搁 置 ， 基 本 上 服 务 于 建 构 外 向 型 经 济 、 实 现 工 业 化 与 确 保 国 家 主 权 的 “ 社 会 最 高 理 想 ” 中 ： 一 叠 叠 数 字 与 无 数 运 作 良 好 的 机 器 齿 轮 让 使 经 济 可 在 充 分 服 从 于 国 家 需 求 的 同 时 对 中 国 进 行 空 前 改 造 ， 并 以 打 造 规 模 效 益 的 方 式 取 得 史 无 前 例 的 建 设 成 果 。 此 后 实 行 的 政 治 改 革 与 企 业 结 构 改 组 更 是 实 现 了 支 部 建 在 车 间 内 ， 在 发 展 现 代 资 本 主 义 的 时 代 中 确 保 了 对 社 会 无 孔 不 入 的 控 制 。 技 术 官 僚 、 新 一 代 企 业 家 乃 至 党 政 高 层 对 中 国 的 统 制 就 此 确 立 ， 其 树 立 的 “ 为 增 长 而 增 长 ” ， “ 时 间 就 是 金 钱 ， 效 率 就 是 生 命 ” 模 式 成 为 了 我 国 的 主 旋 律 ， 虽 说 这 些 话 更 适 用 于 描 述 癌 细 胞 的 运 作 方 式 … … ";
					}
					else
					{
						fake_text += "\n\n 试 图 以 现 代 社 会 民 主 主 义 为 蓝 本 对 中 国 经 济 改 革 的 方 案 成 果 颇 丰 ： 我 们 果 断 打 碎 了 铁 饭 碗 ， 以 发 改 委 对 传 统 计 委 取 而 代 之 ， 法 律 规 范 也 替 代 行 政 命 令 成 为 了 新 时 代 经 济 生 活 主 旋 律 。 多 种 经 营 形 式 均 告 合 法 ； 自 负 盈 亏 逻 辑 基 本 胜 利 ； 价 格 管 制 只 限 于 提 供 国 家 支 持 与 保 护 价 ； 即 便 是 国 营 企 业 也 只 是 平 等 参 与 市 场 竞 争 并 被 “ 重 点 关 注 ” ， 履 行 “ 指 导 指 标 ” 的 普 通 市 场 经 营 主 体 ； 社 会 各 团 体 也 得 以 获 得 参 与 经 济 活 动 的 发 言 权 ； 实 现 了 国 家 、 企 业 与 各 团 体 间 的 大 妥 协 。 然 而 ， 我 们 的 努 力 也 到 此 为 止 。 试 图 落 实 左 翼 凯 恩 斯 主 义 与 建 立 “ 社 会 导 向 市 场 经 济 ” 的 改 革 不 得 不 屈 服 于 去 管 制 与 自 由 化 的 现 实 ， 建 构 乌 托 邦 的 时 代 已 经 远 去 ， 并 被 新 一 轮 私 有 化 方 案 、 外 商 投 资 法 与 削 弱 产 业 组 织 的 举 措 取 而 代 之 。 这 种 中 庸 状 态 显 然 不 会 让 左 右 两 派 满 意 ： 但 相 对 于 各 种 历 史 教 训 ， 我 们 的 中 庸 经 济 似 乎 已 经 是 各 种 可 能 内 的 最 佳 。 ";
					}
				}
				else if (GlobalScript.inst.gameState.data[16] == 15)
				{
					if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
					{
						fake_text += "\n\n 我 们 仅 用 了 短 短 数 年 间 便 实 现 了 中 国 经 济 的 彻 底 革 命 ， 将 规 模 有 限 的 国 家 计 划 改 为 完 全 去 管 制 的 市 场 。 中 国 就 此 成 为 了 少 有 的 红 旗 下 追 求 完 全 经 贸 自 由 化 ， 并 事 实 上 废 除 包 括 价 格 、 贸 易 与 进 出 口 税 收 等 干 预 措 施 在 内 的 政 权 。 就 此 在 资 本 主 义 领 域 内 后 来 居 上 ： 投 资 与 营 商 环 境 评 级 在 国 际 社 会 内 一 枝 独 秀 。 然 而 ， 所 有 的 馈 赠 都 预 先 标 好 了 价 码 。 这 个 缺 乏 现 代 中 产 阶 级 的 国 家 显 然 没 有 为 保 护 主 义 的 缺 失 、 再 分 配 政 策 方 面 的 乏 力 与 对 国 有 资 产 的 急 速 非 国 有 化 做 好 准 备 。 而 政 府 试 图 在 改 革 议 程 内 培 育 强 大 的 “ 社 会 所 有 ” 经 济 ， 并 通 过 放 权 金 融 与 减 税 降 费 开 启 左 翼 小 政 府 主 义 实 践 的 政 策 只 会 让 局 势 变 得 更 加 不 可 收 拾 ： 旨 在 “ 真 正 落 实 贯 彻 巴 黎 公 社 精 神 ， 土 地 给 农 民 ， 工 厂 给 工 人 ” 的 分 权 政 策 让 绝 大 部 分 的 公 共 部 门 事 实 上 落 入 了 与 国 家 关 系 密 切 的 新 兴 国 家 官 僚 之 手 ， 并 让 后 者 通 过 垄 断 区 域 服 务 的 方 式 攫 取 巨 额 利 润 ， 事 实 上 按 照 类 似 日 本 黑 帮 “ 黑 帮 提 供 服 务 ， 个 人 享 受 服 务 ， 接 受 保 护 ” 的 模 式 运 作 ； 中 国 经 济 也 变 为 了 通 过 社 区 代 理 人 操 控 的 集 体 私 有 制 模 式 ， 大 都 服 务 于 特 定 地 区 、 团 体 、 甚 至 家 族 的 利 益 ； 自 由 竞 争 与 无 度 的 招 商 引 资 政 策 则 在 导 致 经 济 特 区 、 自 由 贸 易 区 与 合 资 企 业 遍 地 开 花 的 同 时 ， 为 国 际 犯 罪 集 团 走 私 与 企 业 无 度 扩 大 外 债 提 供 便 利 。 虽 说 党 政 机 器 仍 可 通 过 向 社 会 团 体 内 植 入 基 层 组 织 的 方 式 勉 力 维 持 自 身 的 控 制 权 ， 可 它 终 究 没 法 给 改 革 政 策 下 滋 生 的 自 由 踩 下 刹 车 — — 该 国 债 务 规 模 仅 在 短 短 数 年 内 便 可 同 美 国 看 齐 ， 而 地 方 保 护 主 义 的 发 展 更 是 持 续 滋 生 火 药 。 通 过 经 济 领 域 “ 百 花 齐 放 ” 而 崛 起 的 新 玩 家 们 已 按 耐 不 住 ， 即 将 登 台 唱 戏 。 看 起 来 “ 中 国 特 色 社 会 主 义 ” 已 摇 摇 欲 坠 ， 时 日 无 多 。 ";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
					{
						fake_text += "\n\n 我 们 仅 用 了 短 短 数 年 间 便 实 现 了 中 国 经 济 的 彻 底 革 命 ， 将 规 模 有 限 的 国 家 计 划 改 为 完 全 去 管 制 的 市 场 。 中 国 就 此 成 为 了 少 有 的 红 旗 下 追 求 完 全 经 贸 自 由 化 ， 并 事 实 上 废 除 包 括 价 格 、 贸 易 与 进 出 口 税 收 等 干 预 措 施 在 内 的 政 权 。 就 此 在 资 本 主 义 领 域 内 后 来 居 上 ： 投 资 与 营 商 环 境 评 级 在 国 际 社 会 内 一 枝 独 秀 。 然 而 ， 所 有 的 馈 赠 都 预 先 标 好 了 价 码 。 这 个 缺 乏 现 代 中 产 阶 级 的 国 家 显 然 没 有 为 保 护 主 义 的 缺 失 、 再 分 配 政 策 方 面 的 乏 力 与 对 国 有 资 产 的 急 速 非 国 有 化 做 好 准 备 。 而 政 府 试 图 在 改 革 议 程 内 建 立 政 商 合 作 机 制 ， 通 过 放 权 金 融 与 减 税 降 费 让 利 ， 实 现 商 界 巨 头 与 政 界 寡 头 共 治 的 政 策 只 会 让 局 势 变 得 更 加 不 可 收 拾 ： 在 技 术 官 僚 与 经 济 学 家 “ 优 化 财 报 ， 理 性 预 算 ” 的 蓝 图 操 作 下 ， 绝 大 部 分 的 公 共 部 门 事 实 上 落 入 了 与 国 家 官 僚 关 系 密 切 的 新 兴 资 产 阶 级 之 手 ， 并 让 后 者 通 过 垄 断 区 域 服 务 的 方 式 攫 取 巨 额 利 润 ， 事 实 上 按 照 类 似 意 大 利 黑 帮 “ 黑 帮 赞 助 政 府 ， 政 府 支 持 帮 派 ” 的 模 式 运 作 ， 形 成 了 二 战 前 夕 日 本 财 阀 似 的 巨 型 存 在 ； 部 分 地 区 甚 至 开 启 了 政 治 职 能 与 企 业 责 任 逐 步 整 合 的 议 程 ： 他 们 或 将 董 事 会 打 扮 为 “ 智 库 ” 以 建 立 影 子 政 府 ； 或 是 基 于 企 业 安 排 政 治 协 商 或 操 纵 区 域 选 举 ； 又 或 是 直 接 以 经 济 圈 形 式 划 定 新 政 治 单 元 ； 中 国 经 济 也 变 为 了 通 过 官 僚 - 少 数 财 阀 双 头 共 同 操 控 的 狭 隘 私 有 制 模 式 ， 大 都 服 务 于 特 定 地 区 、 团 体 、 甚 至 家 族 的 利 益 ； 自 由 竞 争 与 无 度 的 招 商 引 资 政 策 则 在 导 致 经 济 特 区 、 自 由 贸 易 区 与 合 资 企 业 遍 地 开 花 的 同 时 ， 为 国 际 犯 罪 集 团 走 私 与 企 业 无 度 扩 大 外 债 提 供 便 利 。 终 于 形 成 了 新 时 代 的 封 建 制 度 与 专 营 专 卖 体 系 ， 即 便 是 日 用 品 领 域 也 形 成 了 技 术 官 僚 或 财 阀 控 制 的 行 会 掌 握 产 量 ， 控 制 价 格 。 而 该 国 逐 渐 崛 起 的 中 产 阶 级 与 市 民 也 只 能 像 波 旁 王 朝 时 代 的 法 国 人 般 ， 寄 希 望 于 “ 好 国 王 ” 及 其 仁 政 上 — — 但 这 也 只 是 某 种 美 好 幻 想 。 党 政 机 器 以 自 身 为 母 体 培 育 强 大 商 界 机 器 的 做 法 造 就 了 新 时 代 的 “ 三 级 制 度 ” ： 即 官 僚 主 政 、 财 阀 主 商 、 人 民 主 劳 ， 且 前 两 者 的 身 份 可 在 适 当 情 况 “ 灵 活 切 换 ” 。 来 自 西 班 牙 殖 民 地 封 建 等 级 制 的 系 列 经 验 源 源 不 断 地 滋 养 该 国 ， 并 促 使 其 形 成 了 史 无 前 例 的 “ 治 水 文 明 资 本 主 义 ” 。 是 若 古 人 得 见 ， 大 概 也 只 能 说 一 句 “ 天 地 实 在 不 仁 ， 以 万 物 为 刍 狗 ” 。||<color=red>“ 你 太 髙 看 他 们 了 ， 他 们 懂 得 什 么 是 资 本 主 义 ？ 最 多 倒 退 到 半 封 建 半 殖 民 地 社 会 。 ” — — 佚 名</color> ";
					}
					else
					{
						fake_text = fake_text + "\n\n 我 们 仅 用 了 短 短 数 年 间 便 实 现 了 中 国 经 济 的 彻 底 革 命 ， 将 规 模 有 限 的 国 家 计 划 改 为 完 全 去 管 制 的 市 场 。 中 国 就 此 成 为 了 新 兴 自 由 世 界 里 的 追 求 完 全 经 贸 自 由 化 ， 并 事 实 上 废 除 包 括 价 格 、 贸 易 与 进 出 口 税 收 等 干 预 措 施 在 内 的 政 权 。 就 此 在 资 本 主 义 领 域 内 后 来 居 上 ： 投 资 与 营 商 环 境 评 级 在 国 际 社 会 内 一 枝 独 秀 。 然 而 ， 所 有 的 馈 赠 都 预 先 标 好 了 价 码 。 这 个 缺 乏 现 代 中 产 阶 级 的 国 家 显 然 没 有 为 保 护 主 义 的 缺 失 、 再 分 配 政 策 方 面 的 乏 力 与 对 国 有 资 产 的 急 速 非 国 有 化 做 好 准 备 。 而 政 府 试 图 彻 底 实 现 国 家 责 任 脱 钩 ， 通 过 放 权 金 融 与 减 税 降 费 让 利 ， 快 速 培 育 新 一 代 资 产 阶 级 的 政 策 只 会 让 局 势 变 得 更 加 不 可 收 拾 ： 旨 在 落 实 “ 还 利 于 民 ” 的 私 有 化 政 策 让 绝 大 部 分 的 公 共 部 门 事 实 上 落 入 了 本 就 积 攒 了 雄 厚 资 本 的 那 些 “ 有 海 外 国 籍 的 朋 友 ” 之 手 ； 而 国 家 多 次 降 低 资 产 价 格 ， 试 图 扩 大 购 买 群 体 的 尝 试 只 会 加 速 资 产 的 集 中 与 流 失 进 程 ， 并 促 使 经 济 事 实 上 转 向 寡 头 经 济 — — 这 只 会 让 现 任 官 僚 于 投 机 商 得 利 ， 并 促 使 他 们 拿 到 进 入 华 尔 街 的 门 票 ， 同 往 日 的 资 本 主 义 狐 朋 狗 友 们 为 市 场 、 为 利 润 相 互 勾 结 ， 划 分 市 场 ， 斗 而 不 破 ： 而 围 绕 华 尔 街 形 成 的 “ 政 治 圈 ” 国 中 之 国 使 包 括 选 战 、 任 命 、 弹 劾 、 乃 至 政 变 等 在 内 的 一 般 政 治 议 程 已 对 以" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "为 代 表 的 一 代 新 兴 自 由 主 义 者 而 言 毫 无 意 义 ， 后 者 只 需 要 在 自 己 平 行 于 民 主 政 体 的 各 式 俱 乐 部 内 同 《 福 布 斯 》 杂 志 前 榜 上 有 名 的 经 济 大 鳄 打 好 关 系 ， 并 通 过 拿 捏 国 内 最 主 要 城 市 的 电 网 、 供 暖 与 自 来 水 公 司 掌 握 票 仓 ； 便 可 在 政 治 世 界 内 从 胜 利 走 向 新 胜 利 。 而 该 国 的 其 他 政 党 也 不 过 是 新 财 团 或 “ 大 洋 彼 岸 ” 的 智 囊 与 说 客 ； 对 该 国 政 治 现 状 的 质 疑 也 会 被 得 到 国 家 或 大 型 企 业 专 门 补 贴 的 类 足 球 黑 帮 给 迅 速 驱 散 。 中 国 就 此 形 成 了 被 国 际 分 析 者 称 之 为 是 “ 蓝 色 斯 大 林 宪 法 ” ， “ 美 国 宪 法 的 拙 劣 演 绎 ” 的 集 权 统 制 形 式 ： 即 该 国 的 政 治 框 架 与 权 力 设 置 仅 在 表 面 上 具 有 某 种 民 主 性 质 ， 基 本 无 法 落 到 实 践 。 且 兼 具 财 运 与 美 德 ， 并 在 上 海 与 纽 约 购 置 多 处 地 产 的 “ 勇 敢 之 人 ” 才 可 享 有 真 正 的 自 由 与 民 主 。 形 成 了 适 应 新 时 代 的 买 办 统 治 形 式 。 可 考 虑 到 资 本 主 义 天 然 寻 求 扩 张 的 事 实 ， 这 些 皈 依 “ 美 利 坚 之 道 ” 的 本 土 新 教 徒 终 会 同 大 洋 彼 岸 的 老 牌 列 强 们 撕 破 脸 皮 ， 并 在 类 似 宗 教 战 争 的 旗 帜 下 决 一 死 战 。 至 于 未 来 结 果 如 何 ， 至 少 那 已 被 调 教 成 “ 侍 奉 女 郎 ” 的 “ 太 平 洋 版 华 尔 街 政 权 ” 必 然 不 是 赢 家 。|| <color=red>纯 粹 的 资 本 主 义 是 一 种 邪 教 ， 也 许 是 最 极 端 的 那 种 ” — — 瓦 尔 特 · 本 雅 明</color> ";
					}
				}
			}
			if (GlobalScript.inst.gameState.event_done[303] && GlobalScript.inst.gameState.resultOfEvents[303] == 1)
			{
				fake_text += "||";
				fake_text += GlobalScript.inst.new_events_text[536];
			}
		}
		else
		{
			if (GlobalScript.inst.gameState.data[16] == 11 && GlobalScript.inst.gameState.data[14] <= 0 && GlobalScript.inst.gameState.data[54] <= 38 && GlobalScript.inst.gameState.science[26] && GlobalScript.inst.gameState.science[22] && GlobalScript.inst.gameState.data[71] >= 400 && GlobalScript.inst.gameState.data[72] >= 400 && GlobalScript.inst.gameState.data[4] <= 0 && GlobalScript.inst.gameState.politics_dolshnost[1] == 150 && GlobalScript.inst.gameState.politics_dolshnost[0] == 150)
			{
				name.text = "Восточный киберпанк";
				fake_text = "Председатель " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " запомнится как один из величайших руководителей Китая, который ввел страну в золотой век через арку автоматизации - на что не рискнул даже всемогущий Советский Союз. Благодаря упорному труду десятков кибернетиков и миллионов рабочих, которые смогли претворить в жизнь Великую Китайскую Машину - экономика страны была модернизирована. Сопротивление партократии против нее было сломлено. Рискованная идея дала великие результаты - была почти полностью побеждены коррупция и дефицит, каждый чиновник теперь находиться под бесстрастным электронным контролем, который невозможно подкупить или обмануть. Но на этом компьютеризация не закончилась - благодаря внедрению в будущем электронных паспортов и системы социального рейтинга, общество окончательно отчистилось от контрреволюционных и вредительских элементов, почти никто не отходит от программы и выполнения плана. Но... машины теперь повсюду, а их полномочия расширяются... И лишь только после безвременной кончины Лидера, партия и народ, кажется, постепенно начинают понимать - кто на самом деле теперь управляет всем...";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(60);
				}
			}
			else if (GlobalScript.inst.gameState.data[16] == 11 && GlobalScript.inst.gameState.data[26] <= 0 && GlobalScript.inst.gameState.data[15] <= 6 && GlobalScript.inst.gameState.data[17] >= 19 && GlobalScript.inst.gameState.data[51] >= 33)
			{
				name.text = "Одной ногой в коммунизм";
				fake_text = "Без демократии нет и социализма, без социализма нет и демократии. Мы долго пытались найти баланс между этими понятиями и, наконец, смогли, построив настоящий социализм. Благодаря внедрению ОГАС мы победили дефицит и, будем надеться, навсегда защитили наше общество от реставрации эксплуатации человека человеком, неравенства и кризисов перепроизводства. Однопартийная демократия позволяет уберечь страну от попадания во власть контрреволюционных элементов, ликвидировав буржуазную парламентскую дискуссию и поставив все под контроль КПК. А свобода слова и народный контроль защищают от злоупотребления властью КПК и отдельных её членов, тем самым придав нашей системе необходимый баланс. Мы доказали, что лучшее устройство общества возможно, а десятки неудавшихся попыток построить социализм по всему миру были не напрасными. Мечта Маркса осуществилась!";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(58);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] <= 2 && GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.data[90] == 0 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[51].Torg)
			{
				name.text = "Оплот маоизма";
				fake_text = "Председатель " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " и проводимое Политбюро уверенное руководство страной обеспечили верность Китая заветам великого освободителя китайского народа, Председателя Мао Цзэдуна. Вся оппозиция была частью подавлена, частью взята под контроль, имена их вождей отныне забыты. Мы идем великой дорогой - дорогой, которую указал нам Великий Кормчий! По крайней мере, до тех пор, пока идеи Мао находят поддержку в народе, а экономика работает более-менее стабильно. Правда, нас все чаще обвиняют в нарушении прав человека - но кого это волнует? Миллионы людей получили собственное жилье, бесплатное образование, трудоустройство, благосостояние большинства растет, пусть и не так быстро, как хотелось бы, но уверенно и неуклонно. Китай, впервые со времен Цинь Шихуанди, стал уважаемой страной - и уже это является значительным достижением, которое точно будет вписано в историю.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(46);
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 1 || GlobalScript.inst.gameState.data[14] == 2)
			{
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.data[14] == 1 && !GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.leader.traits[0] == 0)
				{
					achieves.GetComponent<achievements>().Set(1);
				}
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(45);
				}
				name.text = "Открываясь миру...";
				fake_text = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " и верные партийцы провели страну по пути, который был указан самим опытом истории Китая. Это время ознаменовалось началом отхода от ортодоксии, а Китай приоткрыл свои двери для мира - не до конца, разумеется, но весьма сильно. Была, наконец, завершена Культурная революция, проведены осторожные реформы в рамках социализма, которые позволили выправить все неправильное и закрепить все правильное, достигнутое за годы, когда нашей страной руководил товарищ Мао Цзэдун. Для миллионов китайцев этот период в истории Китая стал временем его наибольшей стабильности и процветания. Хотя и были допущены определенные ошибки, но в целом этот курс оказался успешным, а нашего руководителя иногда сравнивают с самим Лениным, ибо он смог пройти вброд, нащупав ногами камни - и провести по нему страну, приумножив её богатство.";
				if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].relations >= 700)
				{
					fake_text = fake_text + "|Мы восстановили добрососедские отношения с СССР и начали переговоры о новой демаркации советско-китайской границы. Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " совершил важный визит в Москву, в ходе которого заявил о том, что Китай не имеет к Советскому Союзу никаких претензий - ни территориальных, ни идеологических. На обратном пути, он прибыл на остров Даманский и поклонился могилам советских пограничников, погибших в ходе конфликта 1969 года, пообещав от имени китайского народа, что будет до конца следовать курсом советско-китайской дружбы. Две крупнейшие страны Евразии пока что движутся в едином направлении, но кто знает, что может произойти впредь?..";
				}
				if (GlobalScript.inst.gameState.allcountries[51].Torg && GlobalScript.inst.gameState.empires[0].relations >= 700)
				{
					fake_text += "|Мы смогли добиться установления надежных отношений с США. В ходе визита в Вашингтон, товарищ Руководитель заявил: \"Совершенно неважно, какая идеологическая система господствует в Китае, какая в США. Важно то, что у Китая и США есть общие интересы, а общие интересы подразумевают сотрудничество\". Мы заключили множество договоров с американскими компаниями, дав им доступ к нашему рынку. Правда, все больше и больше партийцев считают, что скоро \"социалистическим\" в Китае останется только его флаг, а все остальное станет капиталистическим - ведь проникновение американского влияния подстегивает либерализацию умов молодежи. Но это только глупые домыслы, верно?..";
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 3)
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(44);
				}
				name.text = "Навстречу всему миру...";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " останется в истории Китая, как один из самых выдающихся руководителей за всю историю страны (или, по крайней мере, так заявляет наша официальная пропаганда). Были развернуты широкомасштабные экономические реформы, поощрена предпринимательская деятельность и открыты возможности для поступления в Китай иностранных инвестиций, при этом удалось защитить отечественный рынок от развала национального производства и доминирования иностранных компаний. Правда, теперь бизнес крепко сросся с государственным аппаратом, что, в свою очередь, не нравится ни сторонникам свободного рынка, ни ортодоксальным коммунистам, да и либерализация умов не смогла далеко продвинуться в обществе: в стране присутствует жесткая цензура, а оппозиция находится под контролем, но ведь это всё мы делаем на благо народа, верно?..";
				if (GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text += "|Мы пошли на углубление сотрудничества с США, заложенного ещё Чжоу Эньлаем, и открыли свободные экономические зоны для инвесторов со всего мира. Тысячи иностранных фирм перенесли к нам свои предприятия, обеспечив бум роста нашей экономики! Однако некоторые партийцы говорят, что \"в свободных экономических зонах социалистические только развивающиеся над ними китайские флаги, а все остальное - капиталистическое\", а значительная доля доходов от СЭЗ уходит за границу. Может, недовольные партийцы и правы?..";
				}
				else if (GlobalScript.inst.gameState.relres)
				{
					fake_text += "|Мы не просто восстановили добрососедские отношения с СССР, но и даже вошли в Совет Экономической взаимопомощи. Кооперация с социалистическими странами позволила оживить экономику Китая и сделать её мощнее и более развитой, уже реализованы сотни проектов, ещё больше сейчас в различной степени готовности. Наши специалисты очень многому научились у наших друзей, поэтому Made in China перестало быть синонимом подделки, а стало уважаемым во всем мире знаком продукции вполне высокого качества.";
					GlobalScript.inst.gameState.allcountries[1].isSEV = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[14] > 3)
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(42);
				}
				name.text = "Новые абсолюты";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " ознаменовал в истории Китая непростой период - период решительного разрыва с тяжким прошлым, строительства нового Китая на новых основаниях, глубоких и масштабных реформ во всех отраслях жизни, перехода к демократическим общечеловеческим ценностям, новому политическому мышлению, полному раскрепощению сознания и действий. Однако такие действия понравились далеко не всем. Мы не можем знать, что произойдет через 5, 10, 20 или 50 лет - но наши потомки наверняка вспомнят, что именно этот период истории стал для Китая эпохой решительных перемен, благодаря которым многое изменилось...";
				if (GlobalScript.inst.gameState.allcountries[51].Torg)
				{
					fake_text = fake_text + "|Соединенные Штаты полностью поддержали наши реформы, господин " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " пять раз объявлялся \"Человеком года\" по версии различных крупных изданий и был номинирован на Нобелевскую премию мира (правда, получить её он смог только перед самой отставкой). Мы открыли свой рынок для иностранных фирм, позволив им участвовать в приватизации государственной собственности. Включившись в глобализацию, мы предоставили свою рабочую силу иностранцам и открыли свободные экономические зоны. Правда, это вызвало целый ряд непредвиденных сложностей и спровоцировало широкую дискуссию в обществе. Время покажет, все ли мы сделали правильно...";
				}
			}
			else if (GlobalScript.inst.gameState.data[14] == 0 && GlobalScript.inst.gameState.data[16] <= 13)
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(43);
				}
				name.text = "КНДР, но побольше";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " и твёрдое руководство наиболее близких к особе руководителя членов Политбюро обеспечили верность КНР заветам её основателей. Вся левая и правая оппозиция была разгромлена, а социалистическое общество надёжно защищено от иностранных шпионов и врагов народа. Они сравнивают нашу эпоху с Троецарствием, диктатурой монголов и деспотией евнухов при династии Хань, но это, конечно, приувеличение - во все эти времена благосостояние населения не выросло настолько, насколько оно поднялось за нашу эпоху. Впрочем, многие говорят, что наша идеология уже окончательно отделилась от марксизма и превратилась в этакий китайский социалистический национализм с авторитарным оттенком, но это же домыслы, так?";
			}
			else if (GlobalScript.inst.gameState.data[14] == 0 && GlobalScript.inst.gameState.data[16] >= 14)
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(41);
				}
				name.text = "Азиатский Пиночет";
				fake_text = GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " и его твёрдое руководство обеспечили Китаю стабильность и процветание во время рыночных реформ. Вся оппозиция была уничтожена, а наша партия твёрдой рукой ведёт Китай в светлое рыночное будущее. Впрочем международные организации всё чаще обвиняют нас в нарушении прав человека, заявляя о притеснении свободы, отсутствии реальной демократии и произволе частников на предприятиях, где наши граждане работают сверх нормы, не имея возможности выправить положение из-за уничтоженного профсоюзного движения. Но пока за нашей спиной иностранные инвесторы и поддержка США - это ведь не имеет значения?";
			}
			if ((GlobalScript.inst.gameState.data[16] != 11 || GlobalScript.inst.gameState.data[14] > 0 || GlobalScript.inst.gameState.data[54] > 38 || !GlobalScript.inst.gameState.science[26] || !GlobalScript.inst.gameState.science[22] || GlobalScript.inst.gameState.data[71] < 400 || GlobalScript.inst.gameState.data[72] < 400 || GlobalScript.inst.gameState.data[4] > 0 || GlobalScript.inst.gameState.politics_dolshnost[1] != 150 || GlobalScript.inst.gameState.politics_dolshnost[0] != 150) && (GlobalScript.inst.gameState.data[16] != 11 || GlobalScript.inst.gameState.data[26] > 0 || GlobalScript.inst.gameState.data[15] > 6 || GlobalScript.inst.gameState.data[17] < 19 || GlobalScript.inst.gameState.data[51] < 33))
			{
				if (GlobalScript.inst.gameState.data[16] == 10)
				{
					fake_text += "\n\n Мы в полном объеме восстановили деятельность плановой экономики: все предприятия в стране принадлежат государству и работают по единому директивному плану, который составляет Госплан. Уже почти забыты такие понятия, как безработица и неравенство, а о кризисах перепроизводства можно и вообще не вспоминать. Вот только вместо проблем, присущих рыночной экономике, уже появляются новые. В любом случае мы доказали, что плановая экономика жизнеспособна, а альтернатива рыночной экономике существует.";
				}
				else if (GlobalScript.inst.gameState.data[16] == 12)
				{
					fake_text += "\n\n Не сильно отходя от экономической политики покойного Чжоу Эньлая, мы смогли создать хорошую и работоспособную экономику. Хоть мы и оставили сельское хозяйство на свободной основе, все предприятия все ещё принадлежит государству, хотя некоторые из них и начали работать по хозрасчету. Частники помогают в борьбе с дефицитом, а хозрасчет значительно повышает рентабельность производства. Однако консервативная часть партии требует отказаться от подобного каппутизма, а народ при этом хочет ещё больше экономических свобод. Кажется, мы надолго застряли в переходной стадии от капитализма к социализму, и неизвестно, в какую же сторону мы двинемся дальше.";
				}
				else if (GlobalScript.inst.gameState.data[16] == 11)
				{
					fake_text += "\n\n И вот, мы совершили то, на что не рискнул даже всемогущий Советский Союз. Добились почти повсеместного автоматизированного экономического планирования, благодаря чему мы вскоре сможем справиться с коррупцией и дефицитом. Правда, система из-за несовершенства современных компьютеров всё ещё работает с перебоями и натыкается на постоянное сопротивление и диверсии бюрократии на всех уровнях управления, а злые языки утверждают, что данная система имеет целью установление \"электронного фашизма\". Но все же мы постепенно начинаем справляться с фундаментальными проблемами плановой экономики, сделав тем самым еще один важный шаг к коммунизму.";
				}
				else if (GlobalScript.inst.gameState.data[16] == 13)
				{
					fake_text += "\n\n Идеи Чэнь Юня восторжествовали. Благодаря экономическим реформам, мы дали нашим гражданам возможность вести предпринимательскую деятельность и открыли каналы для поступления в Китай иностранных инвестиций, при этом жесткий государственный контроль надежно защищает отечественный рынок от развала национального производства, доминирования иностранных компаний и образования частных монополий. Правда, теперь бизнес крепко сросся с государственным аппаратом, что, в свою очередь, не нравится ни сторонникам свободного рынка, ни ортодоксальным коммунистам. Зато мы построили экономику, совмещающую плюсы капитализма и социализма, правда, минусы она, кажется, совмещает тоже. Слишком многое теперь зависит от благоприятного инвестиционного климата и развития глобального производства, кризисы которых смогут воздействовать на нас…";
				}
				else if (GlobalScript.inst.gameState.data[16] == 14)
				{
					fake_text += "\n\n С помощью широкомасштабных реформ мы смогли построить управляемую рыночную экономику, сохранив национальное производство, а также добились компромисса между бизнесом и общественными структурами. Благодаря социальной ориентированности экономики, у нас сохраняется конкуренция и рыночная свобода, при этом население защищено от не добросовестных участников рынка и некоторых отрицательных последствий рыночной экономики. Может, такая система и не сможет полностью искоренить инфляцию, безработицу, разрыв между богатыми и бедными, а государственный контроль мешает развитию бизнеса и затрудняет выход на новые рынки, зато мы пришли к тому же, к чему и большинство европейских стран в наши дни.";
				}
				else if (GlobalScript.inst.gameState.data[16] == 15)
				{
					fake_text += "\n\n Всего за несколько лет мы смогли перейти от государственного планирования к свободному и почти никак нерегулируемому рынку. Либерализация экономики и торговли восторжествовала по всему Китаю, а мы теперь стабильно входим в рейтинги стран с самым благоприятным инвестиционным климатом. Правда, благодаря отсутствию протекционизма с нашей стороны и результатам «не очень справедливой» приватизации государственной собственности, большая часть национального производства пришла в упадок, да и нашу экономику теперь начинают пытаться контролировать окрепшие частные монополии, но ведь рынок сможет с этим разобраться, верно?..";
				}
			}
		}
		text_t.text = Text(fake_text, 91);
	}

	private void Check_Chekc_Check()
	{
		if (!GlobalScript.inst.gameState.iron_and_blood)
		{
			return;
		}
		if (GlobalScript.inst.gameState.data[5] < 100 && GlobalScript.inst.gameState.influencePRC < 50 && GlobalScript.inst.gameState.data[14] >= 5 && GlobalScript.inst.gameState.data[67] > 0 && GlobalScript.inst.gameState.data[66] > 0 && GlobalScript.inst.gameState.data[65] <= 0 && GlobalScript.inst.gameState.data[62] <= 0)
		{
			achieves.GetComponent<achievements>().Set(56);
		}
		if (GlobalScript.inst.gameState.allcountries[9].proprc && GlobalScript.inst.gameState.allcountries[32].proprc && GlobalScript.inst.gameState.allcountries[19].proprc && GlobalScript.inst.gameState.allcountries[12].proprc && GlobalScript.inst.gameState.allcountries[31].proprc && GlobalScript.inst.gameState.allcountries[8].proprc && GlobalScript.inst.gameState.allcountries[14].proprc && GlobalScript.inst.gameState.allcountries[37].proprc && GlobalScript.inst.gameState.allcountries[30].proprc)
		{
			achieves.GetComponent<achievements>().Set(110);
		}
		if (GlobalScript.inst.gameState.allcountries[14].proprc)
		{
			achieves.GetComponent<achievements>().Set(64);
		}
		if (GlobalScript.inst.gameState.checking[0] && GlobalScript.inst.gameState.checking[1] && GlobalScript.inst.gameState.checking[2] && GlobalScript.inst.gameState.checking[3] && GlobalScript.inst.gameState.checking[4])
		{
			achieves.GetComponent<achievements>().Set(111);
		}
		if (GlobalScript.inst.gameState.influencePRC <= 1 && GlobalScript.inst.gameState.modifies[16].active && GlobalScript.inst.gameState.modifies[17].active && GlobalScript.inst.gameState.modifies[12].active && GlobalScript.inst.gameState.modifies[0].active && GlobalScript.inst.gameState.modifies[1].active && GlobalScript.inst.gameState.modifies[15].active)
		{
			achieves.GetComponent<achievements>().Set(57);
		}
		if (GlobalScript.inst.gameState.data[5] > 800 && GlobalScript.inst.gameState.allcountries[51].Torg && GlobalScript.inst.gameState.data[14] >= 5 && GlobalScript.inst.gameState.leader.name_1 == 15 && GlobalScript.inst.gameState.leader.name_2 == 15)
		{
			achieves.GetComponent<achievements>().Set(59);
		}
		if (GlobalScript.inst.gameState.diff == 3)
		{
			achieves.GetComponent<achievements>().Set(52);
		}
		else if (GlobalScript.inst.gameState.diff == 4)
		{
			achieves.GetComponent<achievements>().Set(53);
		}
		if ((GlobalScript.inst.gameState.data[60] == 0 || GlobalScript.inst.gameState.data[60] == 3) && GlobalScript.inst.gameState.allcountries[20].proprc && GlobalScript.inst.gameState.allcountries[23].proprc && GlobalScript.inst.gameState.allcountries[23].Gosstroy == 0)
		{
			achieves.GetComponent<achievements>().Set(2);
		}
		if (GlobalScript.inst.gameState.politics_dolshnost[0] < 18 && GlobalScript.inst.gameState.politics_dolshnost[1] < 18 && GlobalScript.inst.gameState.politics_dolshnost[2] < 18 && GlobalScript.inst.gameState.leader.traits[0] == 3 && GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[0]].traits[0] == 3 && GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].traits[0] == 3 && GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[3]].traits[0] == 3)
		{
			achieves.GetComponent<achievements>().Set(20);
		}
		int num = 0;
		Politic[] politics = GlobalScript.inst.gameState.politics;
		foreach (Politic politic in politics)
		{
			if (politic != null && politic.traits[0] == 0 && (((politic.name_1 == 0) & (politic.name_2 == 0)) || ((politic.name_1 == 3) & (politic.name_2 == 3)) || (politic.name_1 == 4 && politic.name_2 == 4) || (politic.name_1 == 5 && politic.name_2 == 5)))
			{
				num++;
			}
		}
		if (num >= 4)
		{
			achieves.GetComponent<achievements>().Set(3);
		}
		if (GlobalScript.inst.gameState.leader.name_1 == 2 && GlobalScript.inst.gameState.leader.name_2 == 2)
		{
			int num2 = 0;
			politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2 != null && politic2.traits[0] == 0 && (((politic2.name_1 == 6) & (politic2.name_2 == 6)) || ((politic2.name_1 == 9) & (politic2.name_2 == 9)) || (politic2.name_1 == 10 && politic2.name_2 == 10) || (politic2.name_1 == 11 && politic2.name_2 == 11)))
				{
					num2++;
				}
			}
			if (num2 >= 4)
			{
				achieves.GetComponent<achievements>().Set(4);
			}
		}
		bool flag = true;
		for (int j = 0; j < 8; j++)
		{
			if (GlobalScript.inst.gameState.ingamewars[j] != null && GlobalScript.inst.gameState.ingamewars[j].fortnight_go == 0 && GlobalScript.inst.gameState.ingamewars[j].infl1 == 0 && GlobalScript.inst.gameState.ingamewars[j].infl2 == 0 && !GlobalScript.inst.gameState.ingamewars[j].is_going)
			{
				flag = false;
			}
		}
		if (GlobalScript.inst.gameState.data[112] >= 2)
		{
			achieves.GetComponent<achievements>().Set(27);
		}
		if (flag && GlobalScript.inst.gameState.data[51] == 30 && GlobalScript.inst.gameState.data[12] >= 950)
		{
			achieves.GetComponent<achievements>().Set(29);
		}
		if (GlobalScript.inst.gameState.modifies[11].active && GlobalScript.inst.gameState.modifies[17].active && GlobalScript.inst.gameState.modifies[16].active)
		{
			achieves.GetComponent<achievements>().Set(12);
		}
		bool flag2 = true;
		bool flag3 = true;
		int num3 = 0;
		bool flag4 = true;
		for (int k = 0; k < GlobalScript.inst.gameState.allcountries.Length; k++)
		{
			if (GlobalScript.inst.gameState.allcountries[k] == null)
			{
				continue;
			}
			if (k >= 53 && k < 69)
			{
				if (!GlobalScript.inst.gameState.allcountries[k].proprc)
				{
					flag2 = false;
				}
			}
			else if (k >= 71 && k <= 83 && k != 78 && !GlobalScript.inst.gameState.allcountries[k].proprc)
			{
				flag4 = false;
			}
			if (GlobalScript.inst.gameState.allcountries[k].proprc && k != 1)
			{
				flag3 = false;
			}
			if (GlobalScript.inst.gameState.allcountries[k].econ && GlobalScript.inst.gameState.allcountries[k].okb && k != 1)
			{
				num3++;
			}
		}
		if (flag3 && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.modifies[17].active && GlobalScript.inst.gameState.modifies[16].active)
		{
			achieves.GetComponent<achievements>().Set(32);
		}
		if (flag4)
		{
			achieves.GetComponent<achievements>().Set(86);
			if (!GlobalScript.inst.gameState.rev_done)
			{
				achieves.GetComponent<achievements>().Set(87);
			}
		}
		if (flag2)
		{
			achieves.GetComponent<achievements>().Set(14);
		}
		if (num3 >= 14)
		{
			achieves.GetComponent<achievements>().Set(68);
		}
		if (num3 >= 8)
		{
			achieves.GetComponent<achievements>().Set(67);
		}
		if (GlobalScript.inst.gameState.allcountries[2].proprc && GlobalScript.inst.gameState.allcountries[20].proprc && GlobalScript.inst.gameState.allcountries[5].proprc)
		{
			achieves.GetComponent<achievements>().Set(19);
		}
		bool flag5 = true;
		for (int l = 0; l < GlobalScript.inst.gameState.politics_dolshnost.Length; l++)
		{
			if (GlobalScript.inst.gameState.politics_dolshnost[l] < 18 && GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[l]] != null && GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[l]].traits[0] != 3)
			{
				flag5 = false;
				break;
			}
		}
		if (flag5)
		{
			achieves.GetComponent<achievements>().Set(20);
		}
		if (GlobalScript.inst.gameState.modifies[3].active)
		{
			achieves.GetComponent<achievements>().Set(30);
		}
		if (GlobalScript.inst.gameState.modifies[7].active)
		{
			achieves.GetComponent<achievements>().Set(7);
		}
	}

	private void OnMouseDown()
	{
		if (is_left)
		{
			number_of_e--;
			if (number_of_e < 0)
			{
				number_of_e = 14;
			}
		}
		else if (is_right)
		{
			number_of_e++;
			if (number_of_e > 14)
			{
				number_of_e = 0;
			}
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (number_of_e == 0)
			{
				GoodEnd();
			}
			else if (number_of_e == 1)
			{
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.data[66] == 0 && GlobalScript.inst.gameState.data[67] == 0 && GlobalScript.inst.gameState.data[65] > 0 && GlobalScript.inst.gameState.data[62] == 2)
				{
					achieves.GetComponent<achievements>().Set(8);
				}
				name.text = " 国 家 结 构 、 思 想 观 念 与 固 有 领 土";
				fake_text = "";
				if (GlobalScript.inst.gameState.allcountries[70].numberOfSpecialEnding >= 0)
				{
					if (GlobalScript.inst.gameState.allcountries[70].numberOfSpecialEnding < 5)
					{
						fake_text = GlobalScript.inst.new_texts[265 + GlobalScript.inst.gameState.allcountries[70].numberOfSpecialEnding];
						if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.allcountries[70].numberOfSpecialEnding >= 0)
						{
							achieves.GetComponent<achievements>().Set(72);
						}
					}
					else
					{
						if (GlobalScript.inst.gameState.allcountries[70].numberOfSpecialEnding == 5)
						{
							fake_text = GlobalScript.inst.new_texts[270];
						}
						else
						{
							fake_text = " 维 吾 尔 族 问 题 极 其 难 以 解 决 。 首 先 ， 新 疆 维 吾 尔 自 治 区 被 重 新 命 名 为 新 疆 维 吾 尔 地 区 ， 其 一 切 自 治 权 被 剥 夺 ， 所 有 学 校 被 强 制 使 用 汉 语 教 学 。 此 外 ， 在 几 年 内 ， 所 有 的 党 和 国 家 机 关 以 及 媒 体 都 转 而 使 用 汉 语 ， 在 入 学 和 期 末 考 试 中 也 增 加 了 中 国 历 史 与 中 国 哲 学 的 必 修 科 目 。 此 类 种 种 行 为 都 引 发 了 广 泛 的 不 满 情 绪 ， 抗 议 者 试 图 以 清 真 寺 为 基 地 发 起 起 义 。 在 起 义 被 武 力 弹 压 之 后 ， 中 国 领 导 人 决 定 实 施 惩 戒 措 施 ： 只 有 拥 有 伊 玛 目 证 明 的 中 央 清 真 寺 能 够 开 放 ， 和 斯 大 林 的 古 拉 格 别 无 二 致 的 劳 改 营 被 设 立 起 来 ， 一 切 有 叛 乱 嫌 疑 的 人 都 被 扭 送 到 那 里 ， 人 们 被 禁 止 佩 戴 宗 教 标 志 并 在 公 共 场 所 举 行 宗 教 仪 式 ， 就 如 同 禁 止 各 种 未 成 年 人 参 加 宗 教 仪 式 一 样 。 这 些 压 制 性 的 政 策 有 助 于 遏 制 维 吾 尔 族 的 叛 乱 ， 但 完 成 汉 化 并 非 一 日 之 功 。";
						}
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(73);
						}
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[70].numberOfSpecialEnding < 0)
				{
					if (GlobalScript.inst.gameState.data[66] <= 0)
					{
						fake_text = " 即 使 在 我 们 对 手 支 持 的 分 离 主 义 骚 乱 影 响 下 ， 新 疆 维 吾 尔 族 自 治 区 依 然 是 中 国 不 可 分 割 的 一 部 分 。 此 区 域 依 然 尽 在 掌 握 ， 公 权 力 正 常 发 挥 效 率 ， 国 安 部 和 新 疆 生 产 建 设 兵 团 阻 止 了 一 切 试 图 组 织 过 激 的 要 求 新 疆 独 立 的 分 离 主 义 运 动 的 企 图 。";
					}
					else if (GlobalScript.inst.gameState.data[66] == 1)
					{
						fake_text = " 苏 联 支 持 的 新 疆 分 裂 分 子 趁 虚 而 入 ， 夺 取 了 该 地 区 的 控 制 权 ， 实 现 了 从 中 国 独 立 的 梦 想 。 然 而 ， 所 谓 的 “ 独 立 ” 很 快 就 被 对 苏 联 的 完 全 依 赖 所 取 代 — — 东 突 厥 斯 坦 人 民 共 和 国 的 领 导 层 是 与 莫 斯 科 协 调 成 立 的 ， 军 队 由 苏 联 军 官 指 挥 ， 经 济 完 全 由 苏 联 顾 问 控 制 。 国 家 除 东 突 厥 斯 坦 共 产 党 外 ， 禁 止 其 余 任 何 党 派 参 政 。 事 实 上 ， 新 疆 最 后 在 保 加 利 亚 和 蒙 古 的 模 式 下 成 为 了 苏 联 的 “ 非 加 盟 共 和 国 ” 。";
					}
					else if (GlobalScript.inst.gameState.data[66] == 2)
					{
						fake_text = " 新 疆 分 裂 分 子 趁 虚 而 入 ， 夺 取 了 该 地 区 的 控 制 权 ， 实 现 了 从 中 国 独 立 的 梦 想 。 不 出 所 料 ， 在 与 我 国 企 业 的 合 作 破 裂 之 后 ， 新 疆 地 区 的 经 济 崩 溃 了 ， 新 疆 共 和 国 领 导 人 试 图 在 我 们 、 苏 联 和 美 国 之 间 取 得 平 衡 ， 这 让 它 成 为 一 个 地 缘 政 治 斗 争 的 焦 点 地 区 。 当 特 权 阶 级 和 复 兴 的 资 产 阶 级 享 受 着 来 自 超 级 大 国 的 奢 侈 品 、 挥 霍 着 美 元 、 卢 布 和 人 民 币 时 ， 新 疆 人 民 却 生 活 在 极 度 的 贫 困 之 中 ， 这 就 是 为 什 么 在 新 疆 ， 伊 斯 兰 主 义 情 绪 越 来 越 受 到 欢 迎 … …";
					}
				}
				if (GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding > 10)
				{
					GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding = -1;
				}
				if (GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding >= 0)
				{
					fake_text += "||";
					if (GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding < 5)
					{
						fake_text += GlobalScript.inst.new_texts[250 + GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding];
						if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding >= 0)
						{
							achieves.GetComponent<achievements>().Set(70);
						}
					}
					else
					{
						if (GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding == 5)
						{
							fake_text += GlobalScript.inst.new_texts[269];
						}
						else
						{
							fake_text += " 由 于 藏 族 人 势 单 力 孤 ， 在 我 们 的 新 政 策 下 ， 他 们 很 快 就 消 失 在 历 史 长 河 中 ： 那 些 没 有 证 明 自 身 忠 诚 的 家 庭 （ 几 乎 所 有 藏 族 人 都 是 ） 的 孩 子 被 送 到 中 国 东 部 的 特 殊 孤 儿 院 ， 在 那 里 ， 他 们 被 与 其 藏 族 出 身 切 割 开 来 ； 他 们 的 父 母 则 留 在 西 藏 参 加 义 务 劳 动 ， 建 设 基 础 设 施 ， 直 到 他 们 能 通 过 汉 语 与 忠 诚 测 试 为 止 。 西 藏 贵 族 的 后 裔 则 立 即 被 处 死 ， 宗 教 学 校 和 修 道 院 也 被 关 闭 ， 胆 敢 抵 触 者 将 被 处 死 ， 僧 侣 与 学 生 们 也 被 枪 决 。 西 藏 自 治 区 更 名 为 西 藏 省 ， 其 自 治 权 被 剥 夺 ， 藏 语 被 认 定 为 汉 语 方 言 ， 被 暴 力 消 灭 ， 以 简 体 中 文 取 而 代 之 。 最 终 ， 一 个 日 趋 统 一 的 中 华 民 族 在 这 一 系 列 措 施 的 助 力 之 下 得 以 形 成 。";
						}
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(71);
						}
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding < 0 || GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding > 10)
				{
					if (GlobalScript.inst.gameState.data[67] <= 0)
					{
						fake_text += "|| 西 藏 自 治 区 仍 然 是 中 国 不 可 分 割 的 一 部 分 ， 尽 管 达 赖 喇 嘛 的 支 持 者 和 部 分 逃 往 国 外 的 当 地 神 职 人 员 进 行 了 有 破 坏 性 的 宣 传 。 巨 额 资 金 被 用 于 发 展 该 地 区 的 经 济 ， 要 求 西 藏 与 中 国 的 其 他 地 区 之 间 的 纽 带 更 加 紧 密 ， 另 一 方 面 ， 我 们 不 削 弱 对 神 职 人 员 的 控 制 ， 坚 决 阻 止 任 何 试 图 组 织 一 个 使 西 藏 脱 离 中 国 ， 过 激 的 分 离 主 义 运 动 的 意 图 和 行 为 。";
					}
					else
					{
						fake_text += "|| 西 藏 分 裂 分 子 趁 虚 而 入 ， 夺 取 了 该 地 区 的 控 制 权 ， 实 现 了 从 中 国 独 立 的 梦 想 。 第 十 四 世 达 赖 喇 嘛 庄 严 地 回 到 拉 萨 ， 发 表 了 隆 重 的 讲 话 ， 揭 露 了 我 们 的 罪 行 ， 为 “ 中 国 结 束 对 自 由 西 藏 的 占 领 ” 而 欢 呼 。 然 而 ， 并 非 一 切 都 是 如 此 美 好 的 ，  “ 自 由 西 藏 ” — — 在 与 我 们 的 企 业 间 的 合 作 被 破 坏 后 ， 该 地 区 的 经 济 已 经 崩 溃, 人 们 不 得 不 靠 养 牛 和 采 集 草 药 来 维 持 生 存 ， 同 时 ， 印 度 已 经 开 始 就 在 阿 鲁 纳 恰 尔 邦 （ 即 藏 南 地 区 ） 长 期 存 在 的 领 土 争 端 与 其 进 行 谈 判 ， 提 出 了 对 麦 克 马 洪 线 的 修 改 意 见.....";
					}
				}
				if (GlobalScript.inst.gameState.data[18] == 20)
				{
					fake_text += "||  一 切 如 毛 泽 东 主 席 与 周 恩 来 总 理 所 料 ， 我 国 仍 走 在 五 十 年 代 的 老 路 上 ， 沿 用 适 应 我 国 基 本 国 情 的 民 族 区 域 自 治 制 度 。 无 需 调 整 ， 无 需 改 变 ， 一 切 都 按 计 划 进 行 ： 各 级 自 治 单 位 在 党 与 国 家 的 领 导 下 合 法 合 规 行 使 区 域 文 化 自 治 权 ， 少 数 民 族 个 体 的 权 益 则 通 过 帮 扶 政 策 得 以 保 障 。 我 们 坚 持 全 国 一 盘 棋 的 思 维 ， 以 持 之 以 恒 的 经 济 与 文 化 政 策 将 各 族 融 入 日 益 勃 兴 的 中 华 民 族 共 同 体 中 。 显 然 ， 这 是 最 适 宜 中 华 民 族 内 “ 大 杂 居 ， 小 聚 居 ， 交 错 杂 居 ” 格 局 的 制 度 安 排 。";
				}
				else if (GlobalScript.inst.gameState.data[18] == 21)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[550] == 2 && GlobalScript.inst.gameState.event_done[550])
					{
						if (GlobalScript.inst.gameState.data[31] <= 400)
						{
							fake_text += "|| 中 国 领 导 人 对 联 邦 制 的 探 索 虽 只 是 基 于 《 区 域 自 治 法 》 修 正 版 的 小 步 走 ， 但 终 究 还 是 在 党 内 掀 起 波 澜 ， 并 给 国 家 架 构 问 题 揭 了 盖 子 。 主 张 在 既 有 框 架 下 深 化 改 革 的 声 音 就 此 崛 起 ， 并 同 国 际 社 会 内 的 第 三 波 民 主 化 、 身 份 政 治 风 波 与 民 族 自 决 长 波 相 互 呼 应 。 深 刻 影 响 了 日 后 的 中 华 联 邦 实 践 ： 持 续 放 开 ， 深 入 推 行 允 许 各 地 各 族 自 主 建 立 自 治 区 的 开 放 政 策 事 实 上 在 国 内 造 就 了 更 加 碎 片 化 的 区 域 格 局 与 地 方 小 社 会 。 不 仅 为 类 似 欧 美 嬉 皮 士 的 各 式 非 主 流 青 年 文 化 开 绿 灯 ， 同 时 还 为 新 兴 宗 教 与 社 会 组 织 建 立 影 响 力 开 启 方 便 之 门 。 上 述 组 织 则 均 遵 循 所 谓 市 场 竞 争 逻 辑 ， 为 求 在 国 家 机 器 内 寻 得 更 多 补 贴 与 扩 大 群 众 基 础 ， 常 以 合 法 或 非 法 形 式 开 展 竞 争 。 中 华 民 族 本 身 的 内 涵 也 就 此 得 到 了 空 前 扩 充 — — 因 为 一 切 文 化 都 能 通 过 官 方 的 统 筹 与 怀 柔 政 策 成 为 它 的 有 机 构 成 。 当 然 ， 这 事 实 上 也 意 味 着 中 国 社 会 本 身 的 空 前 虚 化 ： 如 今 ， 在 我 们 充 分 保 障 各 族 自 由 选 择 民 族 与 文 化 身 份 ， 并 任 其 在 教 育 与 经 济 生 活 上 享 受 均 等 待 遇 的 背 景 下 。 即 便 是 在 人 口 上 最 弱 势 的 少 数 民 族 ， 都 已 在 “ 迁 徙 自 由 ” 的 名 义 下 被 新 社 会 阶 层 、 亚 文 化 群 体 与 各 类 俱 乐 部 给 切 成 马 赛 克 。 国 内 生 成 民 族 分 离 主 义 的 风 险 也 随 其 主 体 的 瓦 解 而 自 然 走 向 覆 灭 。 可 不 少 保 守 派 党 员 却 表 示 “ 福 兮 祸 所 依 ， 祸 兮 福 所 伏 ” ， 称 目 前 的 我 们 只 不 过 是 从 十 字 路 口 走 到 又 一 个 十 字 路 口 内 ， 得 再 度 面 对 前 辈 们 曾 在 5 0 年 代 遭 遇 的 问 题 — — “ 我 们 将 用 何 种 身 份 ， 何 种 思 想 凝 聚 中 国 人 民 ？ ” ； 而 这 次 ， 同 国 际 标 准 接 轨 的 我 们 手 头 可 没 有 什 么 “ 整 风 ” 或 “ 历 史 渊 源 ” … … 可 不 论 如 何 ， 我 们 确 实 实 现 了 弯 道 超 车 ， 完 成 了 马 克 思 主 义 理 论 蓝 图 中 对 民 族 架 构 的 超 越 。 以 民 族 的 内 部 再 自 治 再 选 择 结 束 了 民 族 ： 这 本 身 就 是 种 史 无 前 例 的 政 治 体 验 … …";
						}
						else if (GlobalScript.inst.gameState.data[31] <= 700)
						{
							fake_text += "|| 中 国 对 联 邦 制 的 探 索 终 以 建 立 所 谓 “ 民 主 集 中 制 联 邦 ” 的 混 合 政 体 告 终 。 比 《 区 域 自 治 法 》 内 描 述 的 民 族 文 化 自 治 更 进 一 步 ， 但 远 没 有 达 到 各 行 政 单 位 转 化 为 区 域 权 利 机 构 的 地 步 ： 因 此 ， 该 改 革 实 际 上 便 主 要 成 为 了 对 汉 族 聚 居 区 的 自 治 化 方 案 ， 乃 至 对 民 族 帮 扶 政 策 的 补 充 。 随 后 的 改 革 更 是 将 优 待 政 策 进 行 调 整 ， 使 其 更 倾 向 于 针 对 个 人 而 非 群 体 。 各 民 族 文 化 也 得 以 在 兴 修 博 物 馆 与 扶 持 文 化 团 体 的 背 景 下 得 到 了 平 等 展 示 机 会 。 于 是 ， 我 们 得 以 在 制 度 层 面 多 少 实 现 了 汉 族 与 多 民 族 之 间 的 待 遇 平 等 。 不 过 在 这 之 后 ， 我 们 便 必 须 直 面 如 何 定 义 “ 中 华 民 族 ” 身 份 的 新 问 题 — — 毕 竟 ， 在 强 调 汉 族 独 立 性 的 情 况 下 ， 作 为 文 化 概 念 的 “ 中 华 民 族 ” 将 失 去 其 绝 大 部 分 根 基 … … 导 致 促 进 民 族 融 合 的 方 式 也 必 须 重 新 洗 牌 ， 从 推 广 打 扮 成 “ 中 华 文 化 ” 的 汉 族 主 流 文 化 变 为 促 进 真 正 意 义 上 的 多 民 族 融 合 文 化 — — 我 们 的 历 史 与 社 会 学 家 已 从 这 方 面 开 始 努 力 … … 正 在 学 校 与 文 化 设 施 上 下 功 夫 ： 学 生 们 将 在 接 受 多 语 种 教 学 与 多 文 化 体 验 机 会 的 同 时 接 受 “ 民 族 革 命 史 观 教 育 ” ， 从 而 拥 抱 基 于 人 民 革 命 战 争 而 逐 步 崛 起 ， 团 结 一 致 的 “ 中 华 民 族 ” ； 从 而 在 民 族 解 放 意 识 形 态 的 基 础 上 形 成 联 合 。 下 一 步 则 是 竭 力 实 现 中 国 各 族 本 身 的 平 等 与 现 代 化 ， 在 经 济 与 文 化 概 念 上 实 现 统 一 ： 这 要 求 我 们 一 方 面 要 持 之 以 恒 地 消 灭 区 域 内 与 区 域 间 的 经 济 分 工 差 别 与 压 迫 要 素 ， 另 一 方 面 则 在 各 族 语 言 中 推 进 词 汇 概 念 的 现 代 化 ， 并 努 力 建 构 出 便 利 各 方 使 用 的 通 用 语 ， 由 此 实 现 社 会 参 与 的 平 等 … … 也 许 在 未 来 ， 中 华 民 族 将 在 各 族 人 民 的 合 力 下 变 得 名 副 其 实 … … 能 像 民 族 学 家 林 耀 华 的 蓝 图 般 “ 后 天 成 长 为 民 族 ” ， 并 再 版 我 们 以 往 带 领 西 南 人 民 飞 跃 进 入 社 会 主 义 时 代 的 奇 迹 … …";
						}
						else
						{
							fake_text += "|| 所 谓 的 《 组 织 条 例 》 从 一 出 台 便 遭 遇 了 滑 铁 卢 ： 地 方 官 员 难 以 接 受 自 治 权 适 用 范 围 在 多 方 面 的 扩 大 ， 故 常 采 取 经 典 的 政 策 选 择 性 推 行 的 策 略 。 根 据 统 计 表 明 ， 《 组 织 条 例 》 中 被 适 用 最 多 的 条 款 是 中 央 否 决 权 与 拨 款 扶 持 文 化 机 构 发 展 的 相 关 职 权 。 其 在 实 践 中 的 表 现 基 本 上 退 回 至 《 区 域 自 治 法 》 的 文 本 中 。 最 大 成 就 仅 限 于 促 成 了 民 族 文 化 宫 与 博 物 馆 等 文 化 设 施 的 修 建 ， 为 汉 族 在 少 数 民 族 地 区 工 作 提 供 背 书 与 政 治 保 护 ， 以 及 为 部 分 未 识 别 民 族 与 待 识 别 民 族 的 划 定 与 自 治 区 构 建 开 了 路 。 而 当 中 央 也 意 识 到 这 一 政 策 本 身 的 实 质 时 ， 便 只 得 默 认 相 关 事 实 — — 汉 族 在 边 疆 更 加 稳 固 ， 部 分 边 缘 群 体 也 得 以 安 分 下 来 求 发 展 。 随 后 则 选 择 以 更 多 的 临 时 性 经 济 扶 持 法 规 与 财 政 补 贴 作 为 对 地 方 政 策 的 补 充 。 回 到 了 以 边 政 治 理 、 推 进 各 族 融 合 与 促 进 区 域 开 发 的 建 设 老 路 。 是 的 ， 改 变 还 是 太 难 ， 我 国 确 实 没 法 轻 易 抛 弃 五 十 年 代 建 设 的 老 本 ， 确 实 没 法 为 民 族 区 域 自 治 制 度 的 主 要 内 涵 寻 得 替 代 ， 甚 至 是 修 正 方 案 — — 区 域 文 化 自 治 ， 国 家 中 央 集 权 ， 共 建 中 华 民 族 一 体 等 观 念 早 已 深 入 人 心 ， 并 形 成 政 治 习 惯 。 于 是 一 切 都 将 按 既 定 方 针 办 。 就 像 以 前 一 样 ， 关 于 民 族 政 策 没 有 什 么 新 闻 ： 各 级 自 治 单 位 在 党 与 国 家 的 领 导 下 合 法 合 规 行 使 区 域 文 化 自 治 权 ， 少 数 民 族 个 体 的 权 益 则 通 过 帮 扶 政 策 得 以 保 障 。 我 们 坚 持 全 国 一 盘 棋 的 思 维 ， 以 持 之 以 恒 的 经 济 与 文 化 政 策 将 各 族 融 入 日 益 勃 兴 的 中 华 民 族 共 同 体 中 。 短 命 的 中 华 联 邦 似 乎 只 告 诉 了 我 们 一 点 ， 即 面 对 中 华 民 族 内 “ 大 杂 居 ， 小 聚 居 ， 交 错 杂 居 ” 格 局 时 ， 我 们 绝 不 能 削 足 适 履 。";
						}
					}
					else
					{
						fake_text += "|| 最 终 ， 中 国 领 导 层 决 定 顺 应 民 族 自 决 与 民 主 化 潮 流 ， 以 此 积 极 回 应 时 代 挑 战 。 我 国 改 革 者 充 分 吸 取 苏 联 “ 超 民 族 联 邦 ” 、 美 国 “ 二 元 联 邦 制 ” 、 乃 至 各 地 组 建 原 住 民 保 留 地 的 历 史 经 验 。 最 终 得 以 初 步 建 立 符 合 中 国 国 情 的 联 邦 制 ： 在 适 当 向 区 域 分 散 事 权 ， 将 土 官 与 流 官 按 配 额 制 度 拉 至 1 ： 1 比 例 ， 并 确 立 地 方 权 利 机 构 ， 规 定 其 司 法 、 文 化 、 社 会 自 治 等 权 利 的 同 时 ， 中 央 政 府 仍 牢 牢 占 据 统 筹 国 防 、 外 交 、 立 法 与 经 济 管 理 的 至 高 点 。 人 大 也 适 应 新 局 势 转 为 两 院 制 结 构 ， 为 地 方 代 表 开 门 。 国 际 社 会 纷 纷 欢 迎 我 们 的 改 革 ， 足 以 让 我 们 得 以 摆 脱 有 关 民 族 问 题 的 绝 大 多 数 诘 难 。 希 望 这 真 能 成 为 建 设 多 元 一 体 和 谐 格 局 的 第 一 步 。";
					}
				}
				else if (GlobalScript.inst.gameState.data[18] >= 22)
				{
					fake_text += " 曾 几 何 时 ， 中 国 领 导 层 还 是 扮 演 批 判 铁 托 主 义 分 权 政 策 的 先 锋 。 可 如 今 的 中 国 ， 又 和 正 积 极 建 构 多 院 制 框 架 ， 奉 行 领 导 配 额 制 与 轮 换 制 ， 乃 至 国 防 分 权 化 的 南 斯 拉 夫 又 有 何 区 别 ？ 内 地 向 北 洋 时 期 起 草 的 《 湖 南 省 宪 法 》 看 齐 ， 有 关 地 方 公 民 投 票 表 决 的 条 款 多 达 十 余 条 ， 并 为 本 地 省 长 行 使 人 事 任 命 、 法 律 职 能 、 乃 至 组 织 地 方 武 装 提 供 了 充 分 的 合 法 性 ； 民 族 地 区 则 遵 循 胡 耀 邦 倡 导 的 所 谓 “ 免 征 、 放 开 、 走 人 ” 三 步 走 ： 新 疆 、 西 藏 、 宁 夏 等 自 治 区 政 府 内 已 塞 满 本 地 民 族 官 员 ， 并 彻 底 改 变 了 本 地 发 展 方 向 。 他 们 仰 仗 新 赋 予 的 自 治 权 ， 将 原 本 应 缴 纳 给 国 家 的 税 收 转 移 到 宗 教 教 育 、 扶 持 当 地 精 英 与 实 施 独 走 式 的 对 外 开 放 政 策 上 。 “ 区 域 积 极 性 ” 的 充 分 发 挥 正 持 续 滋 养 着 地 方 势 力 — — 而 中 央 则 仅 表 现 为 一 个 供 各 方 共 用 人 民 币 、 同 等 税 率 的 内 部 市 场 ； 其 决 策 职 能 则 宛 如 论 坛 ， 在 缺 乏 一 致 同 意 或 绝 对 多 数 表 决 的 基 础 上 难 以 行 动 … … 哦 ， 即 便 在 被 拆 成 复 院 的 人 大 内 取 胜 又 如 何 ？ 瞧 瞧 已 转 为 上 院 ， 塞 满 地 方 精 英 的 政 协 罢 ！ 谁 知 道 未 来 会 发 生 什 么 ？ 也 许 许 多 变 化 将 自 此 开 始 。 可 至 少 ， 中 国 将 不 再 是 “ 中 央 集 权 之 国 ” 的 缩 写 。";
				}
				if (GlobalScript.inst.gameState.resultOfEvents[550] != 2 || !GlobalScript.inst.gameState.event_done[550])
				{
					if (GlobalScript.inst.gameState.data[31] <= 400)
					{
						fake_text += "|| 最 终 ， 中 国 国 民 们 在 对 内 改 革 ， 对 外 开 放 的 格 局 下 树 立 了 迥 异 于 以 往 的 价 值 观 ： 对 文 化 固 化 的 推 崇 和 文 化 价 值 判 断 的 相 对 主 义 取 代 了 曾 长 期 盛 行 的 大 一 统 理 论 ， 连 带 着 “ 中 华 民 族 ” 都 被 定 义 为 “ 中 国 境 内 不 同 阶 层 的 集 合 ” 。 人 们 更 热 衷 谈 论 并 体 验 各 自 社 会 生 活 中 的 独 特 性 ， 同 时 自 然 而 然 的 将 此 类 追 求 转 化 为 争 取 权 益 的 斗 争 ， 政 治 参 与 也 随 之 活 跃 起 来 。 为 此 ， 国 内 也 就 扩 大 了 配 额 制 的 老 一 套 ， 并 为 相 关 集 体 拨 付 更 多 补 贴 。 考 虑 到 目 前 文 化 领 域 内 人 心 思 变 。 预 计 以 后 ， 人 们 大 抵 将 对 往 日 的 民 族 识 别 方 案 、 引 入 新 自 治 制 度 、 乃 至 修 订 目 前 国 体 的 可 能 故 事 重 提 ， 当 然 ， 一 切 都 为 时 尚 早 … …";
					}
					else if (GlobalScript.inst.gameState.data[31] <= 700)
					{
						fake_text += "|| 全 体 中 国 国 民 在 思 想 上 仍 按 照 既 定 方 针 办 ： 自 5 0 年 代 开 始 确 立 的 多 元 一 体 理 论 依 然 牢 牢 地 占 据 至 高 点 ， 以 常 识 的 形 式 发 挥 作 用 。 多 元 聚 为 一 体 ， 一 体 容 纳 多 元 。 中 国 各 族 的 兄 弟 情 根 植 于 革 命 战 争 与 建 设 祖 国 的 伟 大 实 践 ， 并 遵 循 历 史 内 交 错 混 居 的 形 式 ， 发 展 出 了 交 流 互 鉴 ， 共 同 进 步 的 和 谐 民 族 关 系 。 中 华 民 族 本 身 的 内 涵 也 便 在 各 民 族 创 造 的 美 好 生 活 与 追 求 幸 福 的 斗 争 中 被 逐 渐 丰 富 ， 最 终 成 为 全 体 国 民 的 基 本 共 识 与 文 化 共 性 ， 切 实 地 形 成 了 一 个 共 同 体 。 即 便 距 离 实 现 真 正 的 各 族 交 融 还 要 时 间 ， 但 我 们 可 以 说 ， 中 国 已 经 在 思 想 上 实 现 了 为 许 多 国 家 所 羡 慕 的 步 调 一 致 ： 这 本 就 是 显 著 的 成 就 。";
					}
					else
					{
						fake_text += "|| 也 许 是 出 于 历 史 惯 性 ， 又 或 者 是 受 现 政 权 热 衷 实 现 政 治 同 化 的 影 响 ： 不 论 如 何 ， 中 国 终 究 还 是 重 回 国 家 主 义 之 路 ， 主 张 在 统 筹 规 划 各 族 生 活 的 基 础 上 推 广 同 一 类 公 民 教 条 。 社 会 舆 论 也 因 此 充 斥 着 隐 形 的 大 汉 族 主 义 与 皈 依 风 潮 ： 少 数 民 族 们 在 内 外 合 力 下 纷 纷 抛 下 身 前 的 老 衣 裳 ， 采 取 以 习 俗 换 加 分 ， 以 习 俗 换 补 贴 ， 或 以 汉 化 换 生 计 等 诸 多 形 式 。 转 而 加 入 到 统 一 的 中 国 国 民 身 份 中 ， 在 管 理 统 一 的 基 础 上 实 现 了 更 高 级 的 文 化 步 调 一 致 。 也 许 在 日 后 ， 我 们 确 实 能 够 真 正 成 为 名 副 其 实 的 民 族 国 家 ， 对 外 以 一 个 声 音 说 话 ， 但 我 们 依 然 得 说 ， 现 在 的 中 国 仍 正 处 于 并 将 长 期 处 于 建 设 大 一 统 的 初 级 阶 段 … …";
					}
				}
			}
			else if (number_of_e == 2)
			{
				name.text = " 旧 的 领 土";
				fake_text = "";
				if (GlobalScript.inst.gameState.data[65] <= 0)
				{
					fake_text = "港 澳 地 区 的 状 况 维 持 着1967 年 后 的 基 本 格 局 ：12.3 运 动 成 功 在 澳 门 建 立 了 亲 华 派 势 力 主 宰 的 国 中 之 国 ， 并 将 当 地 变 为 了 “ 徒 有 虚 名 的 殖 民 地 ” ； 而 试 图 摸 着 澳 门 起 义 过 河 的 香 港 五 月 风 暴 则 以 失 败 告 终 — — 港 英 当 局 反 而 借 助 及 时 推 出 改 良 主 义 措 施 与 中 国 本 部 对 运 动 支 持 的 半 途 而 废 实 现 了 自 身 地 位 的 空 前 巩 固 。 意 味 着 港 澳 问 题 基 本 与 香 港 归 属 问 题 同 义 — — 可 考 虑 到 目 前 北 京 政 府 仍 坚 持 将 港 澳 地 区 视 为 “ 对 外 发 展 的 橱 窗 ” ， 这 种 政 治 上 若 隐 若 离 ， 经 济 上 却 加 强 沟 通 的 状 况 仍 将 长 期 继 续 下 去 。";
					if (GlobalScript.inst.gameState.IsAuthoritarianism(87))
					{
						fake_text += "|不 过 ， 事 情 还 是 随 着 域 外 条 件 的 变 化 发 生 了 些 许 改 观 ： 葡 萄 牙 的 右 翼 军 事 政 变 导 致 了 该 国 域 外 政 治 资 产 的 进 一 步 流 失 。 澳 门 更 是 借 此 直 截 了 当 地 回 归 了 祖 国 。 结 束 了 数 百 年 的 分 离 历 史 。 可 充 分 继 承 了 萨 拉 查 主 义 衣 钵 的 “ 新 ” 新 国 家 体 制 仍 不 自 量 力 地 怀 抱 葡 萄 牙 帝 国 之 梦 ， 并 试 图 将 澳 门 作 为 重 振 自 身 声 威 的 跳 板 。 而 结 果 自 不 必 多 言 — — 以 卵 击 石 ， 不 自 量 力 ！";
					}
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, 87))
					{
						fake_text += "|不 过 ， 事 情 还 是 随 着 域 外 条 件 的 变 化 发 生 了 些 许 改 观 ： 葡 萄 牙 的 左 翼 军 事 政 变 导 致 了 该 国 域 外 政 治 资 产 的 进 一 步 流 失 。 澳 门 更 是 借 此 直 截 了 当 地 回 归 了 祖 国 。 结 束 了 数 百 年 的 分 离 历 史 。 而 该 国 新 政 府 也 以 “ 去 殖 民 化 ” 的 说 辞 对 此 顺 水 推 舟 ， 事 实 上 默 许 了 这 一 转 变 。 现 在 ， 是 时 候 庆 祝 与 澳 门 的 团 圆 了 ！";
					}
					if (GlobalScript.inst.gameState.resultOfEvents[469] == 0 && GlobalScript.inst.gameState.empires[0].power < GlobalScript.inst.gameState.influencePRC)
					{
						fake_text += "|随 着 时 间 的 流 逝 ， 我 们 对 香 港 左 派 的 援 助 得 以 结 出 果 实 ： 英 国 的 衰 退 与 红 色 游 击 运 动 的 节 节 胜 利 使 对 香 港 局 势 越 加 力 不 从 心 。 最 终 为 我 们 入 局 创 造 了 条 件 。 《 南 京 条 约 》 规 定 香 港 将 在 保 留 外 资 与 多 项 对 外 权 益 的 基 础 上 成 为 中 国 下 辖 的 自 由 市 ， 这 是 我 们 的 外 交 胜 利 ！";
					}
				}
				else if (GlobalScript.inst.gameState.data[65] == 1)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[27] == 0)
					{
						fake_text = string.Concat(new string[4]
						{
							" 基 于 建 国 以 来 将 港 澳 视 为 对 外 开 放 橱 窗 与 汇 聚 爱 国 主 义 最 大 公 约 数 的 政 策 ，",
							GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
							GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
							" 同 志 创 造 性 地 提 出 了 “ 一 国 两 制 ” 方 案 以 解 决 国 家 统 一 问 题 ， 而 香 港 与 澳 门 便 是 实 战 案 例 ： 与 英 国 、 葡 萄 牙 ， 以 及 其 幕 后 东 家 间 的 博 弈 漫 长 且 挑 战 不 断 ； 可 终 究 是 以 我 们 的 胜 利 而 告 终 。 香 港 与 澳 门 将 以 中 国 特 别 行 政 区 的 形 式 保 留 自 身 各 项 政 治 制 度 ， 并 可 在 对 外 活 动 中 以 “ 地 区 ” 身 份 参 与 国 际 事 务 。 当 然 ， 两 者 在 法 律 上 均 不 享 有 国 家 级 主 权 。 预 计 我 们 将 在1997 年7 月1 日 与1999 年12 月19 日 分 别 完 成 港 澳 主 权 移 交 仪 式 。 香 港 与 澳 门 就 此 回 归 祖 国 怀 抱 — — 不 过 ， 考 虑 到 长 期 分 居 的 历 史 已 在 两 地 生 成 了 深 受 西 方 文 化 影 响 的 独 特 生 活 方 式 ， 而 高 度 自 治 更 是 默 许 了 港 澳 人 保 留 这 种 “ 殖 民 主 义 风 尚 ” 。 故 事 显 然 不 会 到 此 为 止 。"
						});
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, 1))
						{
							fake_text += "|考 虑 到 澳 门 早 在12.3 运 动 后 便 成 为 了 亲 北 京 派 系 主 宰 的 国 中 之 国 ， 当 地 坦 然 接 受 了 同 祖 国 团 圆 的 现 实 ， 并 老 老 实 实 地 顺 应 了 当 前 局 势 。 而 香 港 的 情 况 则 相 对 复 杂 ： 现 代 严 酷 的 斗 争 局 势 与 伴 随 于 此 盛 行 的 逃 港 潮 流 ， 乃 至 港 英 政 府 对 本 土 市 民 社 会 的 长 期 耕 耘 基 本 将 当 地 塑 造 为 了 “ 亚 洲 版 的 西 柏 林 ” 。 意 识 形 态 光 谱 杂 乱 无 序 ， 根 植 于 地 方 情 绪 与 反 共 反 陆 思 潮 的 排 外 沙 文 主 义 思 潮 更 是 蔚 然 成 风 。 而 当 局 试 图 转 向 同 港 台 华 人 犯 罪 集 团 与 金 融 豪 强 合 作 ， 由 此 在 当 地 间 接 施 加 影 响 ， 打 造 可 控 法 团 主 义 民 主 的 尝 试 更 是 加 速 了 反 建 制 势 力 在 “ 反 贪 腐 ， 反 专 制 ， 反 移 民 ， 反 对 六 七 暴 乱 ， 坚 决 保 卫 我 们 的 香 港 生 活 ” 的 旗 下 集 合 。 而 这 恰 是 所 谓 香 港 “ 民 主 派 ” 的 起 源 — — 后 者 毫 不 避 讳 从 其 前 宗 主 国 ， 跨 国 经 济 集 团 与 美 国 处 获 得 支 持 ； 并 通 过 大 加 赞 美 英 港 时 期 “ 狮 子 山 精 神 ” 的 勃 兴 与 美 化 其 实 行 改 良 方 案 的 方 式 落 实 其 意 图 完 全 掌 控 当 地 政 坛 ， 实 现 香 港 “ 时 代 革 命 ” 的 主 张 。 我 们 和 他 们 可 还 有 账 可 算 … …";
						}
						if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7)
						{
							fake_text += "|考 虑 到 澳 门 早 在12.3 运 动 后 便 成 为 了 亲 北 京 派 系 主 宰 的 国 中 之 国 ， 当 地 坦 然 接 受 了 同 祖 国 团 圆 的 现 实 ， 并 老 老 实 实 地 顺 应 了 当 前 局 势 。 而 香 港 的 情 况 则 相 对 复 杂 ： 现 代 严 酷 的 斗 争 局 势 与 伴 随 于 此 盛 行 的 逃 港 潮 流 ， 乃 至 港 英 政 府 对 本 土 市 民 社 会 的 长 期 耕 耘 基 本 将 当 地 塑 造 为 了 “ 亚 洲 版 的 西 柏 林 ” 。 意 识 形 态 光 谱 杂 乱 无 序 ， 根 植 于 地 方 情 绪 与 亲 英 美 思 潮 的 排 外 沙 文 主 义 思 潮 更 是 蔚 然 成 风 。 而 当 局 试 图 转 向 同 港 台 华 人 犯 罪 集 团 与 金 融 豪 强 合 作 ， 由 此 在 当 地 间 接 施 加 影 响 ， 打 造 可 控 法 团 主 义 民 主 的 尝 试 更 是 加 速 了 反 建 制 势 力 在 “ 反 贪 腐 ， 反 专 制 ， 反 移 民 ， 反 对 六 七 暴 乱 ， 坚 决 保 卫 我 们 的 香 港 生 活 ” 的 旗 下 集 合 。 而 这 恰 是 所 谓 香 港 “ 民 主 派 ” 的 起 源 — — 后 者 毫 不 避 讳 从 其 前 宗 主 国 ， 跨 国 经 济 集 团 与 美 国 处 获 得 支 持 ； 并 通 过 大 加 赞 美 英 港 时 期 “ 狮 子 山 精 神 ” 的 勃 兴 与 美 化 其 实 行 改 良 方 案 的 方 式 落 实 其 意 图 完 全 掌 控 当 地 政 坛 ， 实 现 香 港 “ 时 代 革 命 ” 的 主 张 。 我 们 和 他 们 可 还 有 账 可 算 … …";
						}
						if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
						{
							fake_text += "|考 虑 到 澳 门 早 在12.3 运 动 后 便 成 为 了 亲 北 京 派 系 主 宰 的 国 中 之 国 ， 当 地 坦 然 接 受 了 同 祖 国 团 圆 的 现 实 ， 并 老 老 实 实 地 顺 应 了 当 前 局 势 。 而 香 港 的 情 况 则 相 对 复 杂 ： 现 代 严 酷 的 斗 争 局 势 与 伴 随 于 此 盛 行 的 逃 港 潮 流 ， 乃 至 港 英 政 府 对 本 土 市 民 社 会 的 长 期 耕 耘 基 本 将 当 地 塑 造 为 了 “ 亚 洲 版 的 西 柏 林 ” 。 意 识 形 态 光 谱 杂 乱 无 序 ， 根 植 于 地 方 情 绪 与 亲 英 美 思 潮 的 排 外 沙 文 主 义 思 潮 更 是 蔚 然 成 风 。 而 背 靠 大 陆 的 金 融 巨 头 与 各 类 “ 非 政 府 组 织 ” 入 局 ， 以 及 北 京 尝 试 在 当 地 扶 持 亲 陆 派 政 治 力 量 打 造 一 党 独 大 民 主 的 尝 试 更 是 加 剧 了 此 类 思 想 的 活 化 ： 反 建 制 势 力 在 “ 反 贪 腐 ， 反 专 制 ， 反 移 民 ， 反 对 六 七 暴 乱 ， 坚 决 保 卫 我 们 的 香 港 生 活 ” 的 旗 下 集 合 。 而 这 恰 是 所 谓 香 港 “ 民 主 派 ” 的 起 源 — — 后 者 毫 不 避 讳 从 其 前 宗 主 国 ， 跨 国 经 济 集 团 与 美 国 处 获 得 支 持 ； 并 通 过 大 加 赞 美 英 港 时 期 “ 狮 子 山 精 神 ” 的 勃 兴 与 美 化 其 实 行 改 良 方 案 的 方 式 落 实 其 意 图 完 全 掌 控 当 地 政 坛 ， 实 现 香 港 “ 时 代 革 命 ” 的 主 张 。 我 们 和 他 们 可 还 有 账 可 算 … …";
						}
						if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
						{
							fake_text += "|考 虑 到 澳 门 早 在12.3 运 动 后 便 成 为 了 亲 北 京 派 系 主 宰 的 国 中 之 国 ， 当 地 坦 然 接 受 了 同 祖 国 团 圆 的 现 实 ， 并 老 老 实 实 地 顺 应 了 当 前 局 势 。 而 香 港 的 情 况 则 相 对 复 杂 ： 现 代 严 酷 的 斗 争 局 势 与 伴 随 于 此 盛 行 的 逃 港 潮 流 ， 乃 至 港 英 政 府 对 本 土 市 民 社 会 的 长 期 耕 耘 基 本 将 当 地 塑 造 为 了 “ 亚 洲 版 的 西 柏 林 ” 。 虽 说 中 国 的 自 由 化 已 让 港 陆 两 地 在 意 识 形 态 上 能 够 达 成 相 当 共 识 ， 不 至 于 在 这 方 面 撕 破 脸 皮 。 可 随 着 背 靠 大 陆 的 金 融 巨 头 与 各 类 “ 非 政 府 组 织 ” 入 局 ， 一 切 都 改 变 了 ： 反 建 制 势 力 在 “ 反 贪 腐 ， 反 移 民 ， 坚 持 港 人 治 港 原 则 ， 坚 决 保 卫 我 们 的 香 港 生 活 ” 下 逐 步 集 合 ， 成 为 了 新 中 国 首 个 登 上 台 面 的 地 方 主 义 政 治 力 量 — — 后 者 毫 不 避 讳 从 其 前 宗 主 国 ， 跨 国 经 济 集 团 与 美 国 处 获 得 支 持 ； 并 通 过 大 加 赞 美 英 港 时 期 “ 狮 子 山 精 神 ” 的 勃 兴 与 美 化 其 实 行 改 良 方 案 的 方 式 落 实 其 意 图 完 全 掌 控 当 地 政 坛 ， 实 现 香 港 “ 时 代 革 命 ” 的 主 张 。 我 们 和 他 们 可 还 有 账 可 算 … …";
						}
						if (GlobalScript.inst.gameState.IsAuthoritarianism(87))
						{
							fake_text += "|然 而 ， 事 情 并 未 到 此 为 止 ： 政 变 后 崛 起 的 葡 萄 牙 “ 新 ” 新 国 家 体 制 充 分 继 承 了 萨 拉 查 主 义 衣 钵 ， 仍 不 自 量 力 地 怀 抱 葡 萄 牙 帝 国 之 梦 ， 并 试 图 将 澳 门 作 为 重 振 自 身 声 威 的 跳 板 ： 他 们 已 借 对 旧 政 府 反 攻 倒 算 之 风 否 定 其 签 署 的 各 项 条 约 ， 其 中 也 包 括 因 政 局 不 稳 而 提 前 向 我 们 完 成 移 交 澳 门 的 协 定 。 而 结 果 自 不 必 多 言 — — 以 卵 击 石 ， 不 自 量 力 ！";
						}
					}
					else
					{
						fake_text = string.Concat(new string[4]
						{
							" 基 于 建 国 以 来 汇 聚 爱 国 主 义 最 大 公 约 数 的 政 策 ，",
							GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
							GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
							" 同 志 决 定 顺 应 去 殖 民 化 时 代 潮 流 ， 坚 决 要 求 曾 脱 离 中 国 的 租 界 地 区 完 全 同 我 国 实 现 整 合 ， 而 香 港 与 澳 门 便 是 实 战 案 例 ： 与 英 国 、 葡 萄 牙 ， 以 及 其 幕 后 东 家 间 的 博 弈 漫 长 且 挑 战 不 断 ； 可 终 究 是 以 我 们 的 胜 利 而 告 终 。 香 港 与 澳 门 将 以 广 东 省 下 辖 市 区 的 形 式 直 接 接 入 地 方 区 划 ， 并 要 求 其 逐 渐 同 北 京 总 路 线 实 现 步 调 一 致 。 考 虑 到 长 期 分 居 的 历 史 已 在 两 地 生 成 了 深 受 西 方 文 化 影 响 的 独 特 生 活 方 式 ， 而 直 接 并 入 中 国 省 份 统 一 的 方 式 必 然 意 味 着 两 种 体 系 的 激 烈 碰 撞 。 意 味 着 我 们 仍 需 要 在 历 史 节 点 到 达 前 准 备 一 条 “ 过 渡 时 期 总 路 线 ” ： 预 计 我 们 将 在1997 年7 月1 日 与1999 年12 月19 日 分 别 完 成 港 澳 主 权 移 交 仪 式 。 在 此 之 前 ， 我 们 得 好 好 为 从 外 国 托 管 逐 渐 变 为 联 合 共 管 ， 最 终 达 成 中 国 接 管 的 转 型 时 期 做 准 备 ："
						});
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, 1) && GlobalScript.inst.gameState.IsSocialism(yes: true, 87) && GlobalScript.inst.gameState.IsSocialism(yes: true, 92))
						{
							fake_text += "英 国 与 葡 萄 牙 局 势 的 戏 剧 性 转 变 为 我 们 提 供 了 借 实 现 民 族 统 一 大 业 彻 底 清 算 历 史 旧 账 的 绝 佳 机 会 。 中 央 决 定 乘 胜 追 击 ， 成 立 具 有 “ 一 机 构 ， 两 牌 子 ” 性 质 的 国 务 院 真 相 澄 清 与 历 史 善 后 办 公 室 （ 其 成 员 包 括 港 澳 三 地 主 要 负 责 人 、 广 东 省 委 与 中 央 代 表 ） ， 赋 予 其 澄 清 历 史 真 相 ， 监 督 港 澳 两 地 ， 可 在 适 当 时 刻 直 接 过 问 港 澳 两 地 管 理 的 权 力 ； 并 寻 求 建 立 国 际 范 围 的 反 殖 民 主 义 统 一 战 线 ， 以 增 强 我 国 揭 露 运 动 的 效 用 。 英 国 与 葡 萄 牙 政 府 不 久 后 便 回 应 我 国 照 会 ， 欣 然 接 受 了 我 国 邀 请 ， 在 工 作 中 发 挥 了 无 可 替 代 的 作 用 ： 它 们 不 仅 以 提 供 殖 民 主 义 罪 行 档 案 的 形 式 为 我 们 推 行 的 转 型 正 义 提 供 有 力 补 充 ， 同 时 还 通 过 了 引 渡 港 澳 反 对 派 政 治 犯 与 批 准 谅 解 书 （ 即 承 认 两 国 殖 民 主 义 罪 行 ， 宣 称 中 国 在 当 地 享 有 完 整 主 权 ， 并 全 力 支 持 中 国 实 现 去 殖 民 化 ） 的 协 定 。 从 而 空 前 震 撼 了 试 图 寻 求 国 际 支 持 的 反 动 分 子 们 。 此 后 ， 我 们 便 以 恢 复 正 义 之 名 筹 建 我 党 控 制 下 的 基 层 准 军 事 组 织 与 临 时 法 庭 ， 审 判 那 些 罪 大 恶 极 之 人 ； 并 在 港 澳 迅 速 引 入 统 一 的 经 济 空 间 、 物 流 管 理 与 社 会 福 利 体 系 ， 以 社 会 主 义 生 活 的 优 越 性 帮 助 他 们 做 出 适 当 的 选 择 。 适 应 三 地 的 新 历 史 教 学 体 系 与 政 治 审 查 制 度 业 已 引 入 ， 各 地 也 纷 纷 开 始 兴 修 纪 念 当 地 回 归 祖 国 的 解 放 纪 念 馆 ， 并 对 当 地 地 标 与 官 僚 体 系 进 行 “ 吐 故 纳 新 ” ： 剔 除 与 殖 民 者 密 切 相 关 的 ， 限 制 与 转 换 缺 乏 意 识 形 态 色 彩 的 ， 发 展 我 们 所 乐 见 的 。 试 图 借 题 发 挥 的 顽 固 反 对 派 与 抵 抗 分 子 也 在 软 硬 兼 施 的 方 针 下 被 新 建 民 兵 与 人 民 解 放 军 隔 离 与 消 灭 。 总 的 来 说 ， 港 澳 地 区 的 政 治 转 型 正 在 以 一 个 我 们 所 乐 见 的 速 度 迅 速 推 进 。 历 史 正 义 也 得 以 伸 张 。 这 对 我 们 来 说 挺 好 的 。";
						}
						else
						{
							fake_text += "考 虑 到 澳 门 早 在 1 2 . 3 运 动 后 便 成 为 了 亲 北 京 派 系 主 宰 的 国 中 之 国 ， 当 地 坦 然 接 受 了 同 祖 国 团 圆 以 及 直 接 并 入 广 东 省 的 现 实 ， 并 老 老 实 实 地 顺 应 了 当 前 局 势 。 而 香 港 的 情 况 则 相 对 复 杂 ： 现 代 严 酷 的 斗 争 局 势 与 伴 随 于 此 盛 行 的 逃 港 潮 流 ， 乃 至 港 英 政 府 对 本 土 市 民 社 会 的 长 期 耕 耘 基 本 将 当 地 塑 造 为 了 “ 亚 洲 版 的 西 柏 林 ” 。 意 识 形 态 光 谱 杂 乱 无 序 ， 根 植 于 地 方 情 绪 与 反 共 反 陆 思 潮 的 排 外 沙 文 主 义 思 潮 更 是 蔚 然 成 风 。 因 此 ， 我 们 决 定 以 民 主 德 国 “ 人 民 民 主 化 ” 与 美 国 南 方 重 建 为 蓝 本 解 决 问 题 ： 香 港 的 社 会 组 织 均 以 地 方 分 部 的 形 式 对 中 国 本 部 的 团 体 进 行 加 盟 ， 教 育 体 系 也 将 完 全 同 我 国 义 务 教 育 制 度 完 全 接 轨 ； 香 港 社 会 建 制 也 被 按 照 国 内 标 准 改 革 一 新 ， 且 公 共 机 构 内 的 所 有 官 员 都 需 要 经 受 履 历 审 查 与 再 培 训 ， 满 足 本 土 的 各 项 标 准 后 才 可 回 归 岗 位 。 除 此 之 外 ， 我 们 通 过 在 当 地 引 入 开 发 补 贴 、 确 保 廉 价 物 资 供 应 与 大 兴 公 共 住 房 的 方 式 稳 住 了 香 港 人 的 日 常 生 活 ， 不 至 于 让 其 在 社 会 改 造 中 遭 受 过 重 冲 击 。 多 管 齐 下 的 政 策 得 以 稳 住 绝 大 多 数 香 港 人 的 日 常 生 活 ， 并 能 最 大 限 度 地 将 本 地 顽 固 的 反 对 派 孤 立 在 外 。 当 然 ， 对 当 地 的 整 顿 绝 非 一 日 之 功 ， 而 我 们 已 经 迈 出 了 坚 实 的 一 步 … …";
						}
						if (GlobalScript.inst.gameState.IsAuthoritarianism(87))
						{
							fake_text += "|然 而 ， 事 情 并 未 到 此 为 止 ： 政 变 后 崛 起 的 葡 萄 牙 “ 新 ” 新 国 家 体 制 充 分 继 承 了 萨 拉 查 主 义 衣 钵 ， 仍 不 自 量 力 地 怀 抱 葡 萄 牙 帝 国 之 梦 ， 并 试 图 将 澳 门 作 为 重 振 自 身 声 威 的 跳 板 ： 他 们 已 借 对 旧 政 府 反 攻 倒 算 之 风 否 定 其 签 署 的 各 项 条 约 ， 其 中 也 包 括 因 政 局 不 稳 而 提 前 向 我 们 完 成 移 交 澳 门 的 协 定 。 而 结 果 自 不 必 多 言 — — 以 卵 击 石 ， 不 自 量 力 ！";
						}
						if (GlobalScript.inst.gameState.allcountries[92].SubGosstroy == 9)
						{
							fake_text += "|然 而 ， 事 情 并 未 到 此 为 止 ： 异 军 突 起 的 英 国 国 家 主 义 者 们 决 定 对 大 英 帝 国 “ 故 事 重 提 ” ， 并 尝 试 将 香 港 重 新 纳 入 不 列 颠 秩 序 的 手 中 ： 他 们 已 借 对 旧 政 府 反 攻 倒 算 之 风 否 定 其 签 署 的 各 项 条 约 ， 其 中 也 包 括 因 政 局 不 稳 而 提 前 向 我 们 完 成 移 交 香 港 的 协 定 ： 尤 其 是 考 虑 到 工 党 政 府 与 英 国 国 内 的 部 分 异 见 者 将 香 港 作 为 自 己 的 政 治 避 难 港 ， 新 政 权 更 有 必 要 将 这 个 “ 亚 洲 版 本 的 西 柏 林 ” 给 收 回 手 中 。 而 从 流 亡 者 口 中 得 知 伦 敦 内 政 治 恐 怖 的 香 港 异 见 者 也 彻 底 摒 弃 了 试 图 从 港 英 身 上 汲 取 “ 本 土 化 ” 力 量 的 政 治 立 场 ， 从 而 加 入 到 本 地 的 “ 大 联 盟 ” 内 采 取 软 手 段 谋 求 共 治 — — 至 少 对 我 们 来 说 挺 好 的 。";
						}
					}
				}
				else if (GlobalScript.inst.gameState.data[65] == 2 && GlobalScript.inst.gameState.allcountries[0].prcpower == 1)
				{
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, 1))
					{
						if (GlobalScript.inst.gameState.modifies[3].active)
						{
							fake_text = " 西 方 不 亮 东 方 亮 ， 随 着 殖 民 主 义 江 河 日 下 ， 重 申 主 权 与 历 史 正 义 的 时 刻 已 经 来 到 。 我 人 民 解 放 军 的 决 定 性 行 动 更 是 彻 底 为 港 澳 局 势 画 上 了 句 号 ： 早 在12.3 运 动 后 便 成 为 亲 北 京 派 系 主 宰 下 国 中 之 国 的 澳 门 很 快 便 在 里 应 外 合 下 实 现 和 平 解 放 ， 复 刻 了 往 日 和 平 接 管 北 平 的 佳 话 。 而 另 一 边 的 港 英 当 局 也 无 法 阻 挡 人 民 解 放 军 和 香 港 爱 国 同 胞 解 放 香 港 的 决 心 ， 最 终 ， 以 香 港 “ 总 督 ” 为 代 表 的 一 窝 港 英 高 官 资 本 家 不 得 不 接 受 历 史 事 实 ： 动 身 快 的 还 有 机 会 收 拾 细 软 灰 溜 溜 逃 回 英 国 ， 否 则 只 能 面 对 群 众 法 庭 与 红 色 恐 怖 的 原 汁 原 味 。 我 们 从 此 一 雪 香 港 红 五 月 失 利 之 耻 ， 将 红 旗 给 插 在 前 头 ！ 此 后 ， 来 自 中 国 共 产 党 港 澳 工 作 委 员 会 与 港 澳 的 草 根 左 翼 活 动 家 更 是 对 两 地 建 制 进 行 了 彻 底 洗 牌 ， 并 将 两 地 工 联 总 会 的 核 心 人 物 （ 如 香 港 六 七 运 动 内 活 跃 的 杨 光 同 志 ） 带 入 了 新 组 建 的 革 命 委 员 会 内 ， 形 成 了 极 具 本 地 特 色 的 左 翼 活 动 家 - 爱 国 工 会 人 士 与 解 放 军 部 队 “ 三 结 合 ” 的 共 治 格 局 。 形 成 了 社 会 主 义 者 一 家 独 大 的 格 局 。 当 然 ， 我 们 清 楚 接 下 来 究 竟 该 干 什 么 ： 考 虑 到 本 地 的 华 人 商 会 与 黑 帮 组 织 已 通 过 积 年 发 展 逐 步 做 大 ， 且 其 作 为 买 办 的 身 份 与 天 然 亲 近 资 本 主 义 政 治 作 风 足 以 同 往 日 的 上 海 青 帮 看 齐 。 新 的 斗 争 很 快 就 会 开 始 — — 由 于 革 命 委 员 会 排 斥 上 述 角 色 参 政 的 群 众 政 权 性 质 ， 这 些 家 伙 极 有 可 能 立 即 筹 备 反 革 命 行 动 。 我 们 得 为 不 重 蹈 四 月 十 二 日 覆 辙 而 战 ！ 下 一 步 便 是 对 公 务 员 队 伍 进 行 与 当 地 文 化 风 貌 彻 底 洗 牌 ， 以 革 命 的 要 求 重 塑 港 澳 两 地 ： 带 有 殖 民 统 治 与 资 本 主 义 含 义 的 地 名 纷 纷 易 名 （ 如 维 多 利 亚 港 改 为 东 方 红 港 ， 皇 后 大 道 改 为 人 民 大 道 ， 柯 邦 迪 前 地 改 为 鸦 片 战 争 纪 念 园 ） ； 革 命 与 社 会 主 义 宣 传 取 代 了 往 日 奉 行 的 商 业 广 告 ； 各 类 资 本 主 义 经 营 形 式 或 被 纳 入 国 家 监 管 “ 四 马 分 肥 ” 并 要 求 拓 展 工 人 监 督 ， 或 直 接 通 过 打 豪 强 的 激 烈 斗 争 方 式 没 收 ， 随 后 交 予 公 共 部 门 经 营 ； 我 们 在 寸 土 寸 金 的 港 澳 实 行 “ 居 者 有 其 屋 ” 计 划 、 保 障 廉 价 生 活 物 资 供 应 并 引 入 均 等 化 公 共 服 务 体 系 ， 并 为 当 地 准 备 了 适 应 新 局 势 的 历 史 教 学 ： 鸦 片 战 争 、 省 港 大 罢 工 与 六 七 抗 暴 等 内 容 纷 纷 纳 入 到 了 建 构 祖 国 统 一 的 叙 事 当 中 。 虽 说 多 管 齐 下 的 措 施 取 得 了 显 赫 成 绩 ， 可 仍 有 许 多 港 澳 同 胞 无 法 理 解 我 们 的 大 政 方 针 与 良 苦 用 心 。 既 不 满 于 我 们 对 爱 港 爱 澳 资 产 阶 级 的 “ 改 造 与 挤 出 ” 政 策 ， 也 对 我 们 同 殖 民 主 义 历 史 的 坚 决 割 舍 行 为 感 到 困 惑 ， 更 是 将 “ 阿 爷 ” 扫 除 妓 院 、 赌 场 、 黑 帮 等 淫 秽 要 素 的 行 动 视 为 “ 捉 虫 入 屎 忽 ” 。 显 然 ， 有 些 东 西 并 不 是 短 时 间 能 够 改 变 的 。 但 不 管 怎 么 说 ， 作 为 资 本 主 义 的 桥 头 堡 的 港 澳 终 归 是 走 上 了 打 造 社 会 主 义 新 红 港 之 路 。 这 本 身 便 足 以 让 武 力 统 一 的 设 计 师 永 垂 青 史 。";
						}
						else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 18)
						{
							fake_text = " 西 方 不 亮 东 方 亮 ， 随 着 殖 民 主 义 江 河 日 下 ， 重 申 主 权 与 历 史 正 义 的 时 刻 已 经 来 到 。 我 人 民 解 放 军 的 决 定 性 行 动 更 是 彻 底 为 港 澳 局 势 画 上 了 句 号 ： 早 在 1 2 . 3 运 动 后 便 成 为 亲 北 京 派 系 主 宰 下 国 中 之 国 的 澳 门 很 快 便 在 里 应 外 合 下 实 现 和 平 解 放 ， 复 刻 了 往 日 和 平 接 管 北 平 的 佳 话 。 而 另 一 边 的 港 英 当 局 也 无 法 阻 挡 人 民 解 放 军 和 香 港 爱 国 同 胞 解 放 香 港 的 决 心 ， 最 终 ， 以 香 港 “ 总 督 ” 为 代 表 的 一 窝 港 英 高 官 资 本 家 不 得 不 接 受 历 史 事 实 ： 动 身 快 的 还 有 机 会 收 拾 细 软 灰 溜 溜 逃 回 英 国 ， 否 则 只 能 面 对 群 众 法 庭 与 红 色 恐 怖 的 原 汁 原 味 。 我 们 从 此 一 雪 香 港 红 五 月 失 利 之 耻 ， 将 红 旗 给 插 在 前 头 ！ 此 后 ， 来 自 中 国 共 产 党 港 澳 工 作 委 员 会 与 港 澳 的 草 根 左 翼 活 动 家 更 是 对 两 地 建 制 进 行 了 彻 底 洗 牌 ， 并 将 中 国 革 命 共 产 党 与 革 命 马 克 思 主 义 者 同 盟 的 核 心 人 物 （ 如 作 为 香 港 托 派 新 星 的 梁 国 雄 ） 带 入 了 新 组 建 的 区 域 苏 维 埃 内 ， 形 成 了 社 会 主 义 者 一 家 独 大 的 格 局 。 当 然 ， 我 们 清 楚 接 下 来 究 竟 该 干 什 么 ： 考 虑 到 本 地 的 华 人 商 会 与 黑 帮 组 织 已 通 过 积 年 发 展 逐 步 做 大 ， 且 其 作 为 买 办 的 身 份 与 天 然 亲 近 资 本 主 义 政 治 作 风 足 以 同 往 日 的 上 海 青 帮 看 齐 。 新 的 斗 争 很 快 就 会 开 始 — — 由 于 苏 维 埃 排 斥 上 述 角 色 参 政 的 群 众 政 权 性 质 ， 这 些 家 伙 极 有 可 能 立 即 筹 备 反 革 命 行 动 。 我 们 得 为 不 重 蹈 四 月 十 二 日 覆 辙 而 战 ！ 下 一 步 便 是 对 公 务 员 队 伍 进 行 与 当 地 文 化 风 貌 彻 底 洗 牌 ， 以 革 命 的 要 求 重 塑 港 澳 两 地 ： 带 有 殖 民 统 治 与 资 本 主 义 含 义 的 地 名 纷 纷 易 名 （ 如 维 多 利 亚 港 改 为 东 方 红 港 ， 皇 后 大 道 改 为 人 民 大 道 ， 柯 邦 迪 前 地 改 为 鸦 片 战 争 纪 念 园 ） ； 革 命 与 社 会 主 义 宣 传 取 代 了 往 日 奉 行 的 商 业 广 告 ； 各 类 资 本 主 义 经 营 形 式 均 被 直 接 通 过 打 豪 强 的 激 烈 斗 争 方 式 没 收 ， 随 后 交 予 公 共 部 门 经 营 ； 我 们 在 寸 土 寸 金 的 港 澳 实 行 “ 居 者 有 其 屋 ” 计 划 、 保 障 廉 价 生 活 物 资 供 应 并 引 入 均 等 化 公 共 服 务 体 系 ， 并 为 当 地 准 备 了 适 应 新 局 势 的 历 史 教 学 ： 鸦 片 战 争 与 省 港 大 罢 工 等 内 容 纷 纷 纳 入 到 了 建 构 祖 国 统 一 的 叙 事 当 中 。 虽 说 多 管 齐 下 的 措 施 取 得 了 显 赫 成 绩 ， 可 仍 有 许 多 港 澳 同 胞 无 法 理 解 我 们 的 大 政 方 针 与 良 苦 用 心 。 既 不 满 于 我 们 对 爱 港 爱 澳 资 产 阶 级 的 “ 改 造 与 挤 出 ” 政 策 ， 也 对 我 们 同 殖 民 主 义 历 史 的 坚 决 割 舍 行 为 感 到 困 惑 ， 更 是 将 “ 阿 爷 ” 扫 除 妓 院 、 赌 场 、 黑 帮 等 淫 秽 要 素 的 行 动 视 为 “ 捉 虫 入 屎 忽 ” 。 显 然 ， 有 些 东 西 并 不 是 短 时 间 能 够 改 变 的 。 但 不 管 怎 么 说 ， 作 为 资 本 主 义 的 桥 头 堡 的 港 澳 终 归 是 走 上 了 打 造 社 会 主 义 新 红 港 之 路 。 这 本 身 便 足 以 让 武 力 统 一 的 设 计 师 永 垂 青 史 。";
						}
						else
						{
							fake_text = " 西 方 不 亮 东 方 亮 ， 随 着 殖 民 主 义 江 河 日 下 ， 重 申 主 权 与 历 史 正 义 的 时 刻 已 经 来 到 。 我 人 民 解 放 军 的 决 定 性 行 动 更 是 彻 底 为 港 澳 局 势 画 上 了 句 号 ： 早 在 1 2 . 3 运 动 后 便 成 为 亲 北 京 派 系 主 宰 下 国 中 之 国 的 澳 门 很 快 便 在 里 应 外 合 下 实 现 和 平 解 放 ， 复 刻 了 往 日 和 平 接 管 北 平 的 佳 话 。 而 另 一 边 的 港 英 当 局 也 无 法 阻 挡 人 民 解 放 军 和 香 港 爱 国 同 胞 解 放 香 港 的 决 心 ， 最 终 ， 以 香 港 “ 总 督 ” 为 代 表 的 一 窝 港 英 高 官 资 本 家 不 得 不 接 受 历 史 事 实 ： 动 身 快 的 还 有 机 会 收 拾 细 软 灰 溜 溜 逃 回 英 国 ， 否 则 只 能 面 对 群 众 法 庭 与 红 色 恐 怖 的 原 汁 原 味 。 我 们 从 此 一 雪 香 港 红 五 月 失 利 之 耻 ， 将 红 旗 给 插 在 前 头 ！ 此 后 ， 来 自 中 国 共 产 党 港 澳 工 作 委 员 会 与 港 澳 的 草 根 左 翼 活 动 家 更 是 对 两 地 建 制 进 行 了 彻 底 洗 牌 ， 并 将 两 地 工 联 总 会 的 核 心 人 物 （ 如 香 港 六 七 运 动 内 活 跃 的 杨 光 同 志 ） 带 入 了 新 组 建 的 港 澳 地 方 政 府 内 ， 形 成 了 极 具 本 地 特 色 的 左 翼 活 动 家 - 爱 国 人 士 与 解 放 军 部 队 “ 三 结 合 ” 的 共 治 格 局 。 当 然 ， 我 们 清 楚 接 下 来 究 竟 该 干 什 么 ： 考 虑 到 本 地 的 华 人 商 会 与 黑 帮 组 织 已 通 过 积 年 发 展 逐 步 做 大 ， 且 其 作 为 买 办 的 身 份 与 天 然 亲 近 资 本 主 义 政 治 作 风 足 以 同 往 日 的 上 海 青 帮 看 齐 。 新 的 斗 争 很 快 就 会 开 始 — — 为 不 重 蹈 四 月 十 二 日 覆 辙 而 战 。 下 一 步 便 是 对 公 务 员 队 伍 进 行 与 当 地 文 化 风 貌 彻 底 洗 牌 ， 以 革 命 的 要 求 重 塑 港 澳 两 地 ： 带 有 殖 民 统 治 与 资 本 主 义 含 义 的 地 名 纷 纷 易 名 （ 如 维 多 利 亚 港 改 为 东 方 红 港 ， 皇 后 大 道 改 为 人 民 大 道 ， 柯 邦 迪 前 地 改 为 鸦 片 战 争 纪 念 园 ） ； 革 命 与 社 会 主 义 宣 传 取 代 了 往 日 奉 行 的 商 业 广 告 ； 各 类 资 本 主 义 经 营 形 式 或 被 纳 入 国 家 监 管 “ 四 马 分 肥 ” 并 要 求 拓 展 工 人 监 督 ， 或 直 接 通 过 打 豪 强 的 激 烈 斗 争 方 式 没 收 ， 随 后 交 予 公 共 部 门 经 营 ； 我 们 在 寸 土 寸 金 的 港 澳 实 行 “ 居 者 有 其 屋 ” 计 划 、 保 障 廉 价 生 活 物 资 供 应 并 引 入 均 等 化 公 共 服 务 体 系 ， 并 为 当 地 准 备 了 适 应 新 局 势 的 历 史 教 学 ： 鸦 片 战 争 、 省 港 大 罢 工 与 六 七 抗 暴 等 内 容 纷 纷 纳 入 到 了 建 构 祖 国 统 一 的 叙 事 当 中 。 虽 说 多 管 齐 下 的 措 施 取 得 了 显 赫 成 绩 ， 可 仍 有 许 多 港 澳 同 胞 无 法 理 解 我 们 的 大 政 方 针 与 良 苦 用 心 。 既 不 满 于 我 们 对 爱 港 爱 澳 资 产 阶 级 的 “ 改 造 与 挤 出 ” 政 策 ， 也 对 我 们 同 殖 民 主 义 历 史 的 坚 决 割 舍 行 为 感 到 困 惑 ， 更 是 将 “ 阿 爷 ” 扫 除 妓 院 、 赌 场 、 黑 帮 等 淫 秽 要 素 的 行 动 视 为 “ 捉 虫 入 屎 忽 ” 。 显 然 ， 有 些 东 西 并 不 是 短 时 间 能 够 改 变 的 。 但 不 管 怎 么 说 ， 作 为 资 本 主 义 的 桥 头 堡 的 港 澳 终 归 是 走 上 了 打 造 社 会 主 义 新 红 港 之 路 。 这 本 身 便 足 以 让 武 力 统 一 的 设 计 师 永 垂 青 史 。";
						}
					}
					else if (GlobalScript.inst.gameState.IsAuthoritarianism(1))
					{
						fake_text = " 西 方 不 亮 东 方 亮 ， 随 着 殖 民 主 义 江 河 日 下 ， 重 申 主 权 与 历 史 正 义 的 时 刻 已 经 来 到 。 我 人 民 解 放 军 的 决 定 性 行 动 更 是 彻 底 为 港 澳 局 势 画 上 了 句 号 ： 早 在12.3 运 动 后 便 成 为 亲 北 京 派 系 主 宰 下 国 中 之 国 的 澳 门 很 快 便 在 里 应 外 合 下 实 现 和 平 解 放 ， 复 刻 了 往 日 和 平 接 管 北 平 的 佳 话 。 而 另 一 边 的 港 英 当 局 也 无 法 阻 挡 人 民 解 放 军 和 香 港 爱 国 同 胞 解 放 香 港 的 决 心 ， 最 终 ， 以 香 港 “ 总 督 ” 为 代 表 的 一 窝 港 英 高 官 资 本 家 不 得 不 接 受 历 史 事 实 ： 动 身 快 的 还 有 机 会 收 拾 细 软 灰 溜 溜 逃 回 英 国 ， 否 则 只 能 面 对 军 事 管 制 与 官 方 默 许 下 华 人 掀 起 的 个 人 恐 怖 主 义 潮 。 我 们 就 此 一 雪 葡 萄 牙 霸 占 澳 门 与 鸦 片 战 争 前 耻 ， 将 中 国 旗 帜 插 在 前 头 ！";
						if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 10)
						{
							fake_text += "|考 虑 到 港 澳 长 期 受 西 方 文 化 与 殖 民 势 力 影 响 的 现 实 ， 以 及 巩 固 统 一 成 果 的 需 要 。 我 们 决 定 将 港 澳 与 同 其 接 壤 的 广 东 省 部 分 区 域 划 定 为 一 个 由 人 民 解 放 军 与 广 东 大 员 们 管 理 ， 且 中 央 能 随 时 过 问 的 粤 港 澳 特 别 行 政 区 。 接 下 来 则 是 从 二 战 后 的 移 民 政 策 与 去 纳 粹 化 议 程 内 取 经 — — 我 们 为 国 内 的 富 裕 阶 层 与 广 东 省 内 居 民 移 居 港 澳 发 放 补 贴 ， 并 同 港 澳 商 团 与 主 要 企 业 家 达 成 了 引 进 外 派 劳 工 的 协 定 。 由 此 达 到 以 移 民 稀 释 港 澳 本 土 主 义 认 同 的 作 用 。 其 次 则 是 将 港 澳 深 受 殖 民 主 义 影 响 的 文 化 要 素 纷 纷 肃 清 ， 对 主 要 地 区 改 名 的 同 时 拆 毁 西 方 教 堂 ， 并 建 立 起 严 格 的 审 查 制 度 。 粤 港 澳 特 别 行 政 区 的 边 界 也 被 纳 入 特 别 管 辖 ： 在 收 拢 对 海 外 移 民 入 境 的 控 制 的 同 时 尝 试 鼓 励 港 澳 人 “ 走 出 去 ” ， 最 终 起 到 过 滤 的 效 果 。 虽 说 强 力 统 治 并 未 给 港 澳 地 区 带 来 预 想 中 的 经 济 繁 荣 ， 并 导 致 其 作 为 亚 洲 关 键 经 济 中 心 的 地 位 有 所 削 弱 ， 可 这 对 我 们 来 说 已 经 足 够 ， 毕 竟 稳 定 与 统 一 本 身 便 是 最 大 的 收 益 。";
						}
						else
						{
							fake_text = fake_text + "|我 们 决 定 以 新 加 坡 的 政 治 模 式 为 蓝 本 ， 以 治 理 取 代 庸 俗 的 民 主 议 程 ， 并 通 过 将 配 额 制 度 与 功 能 界 别 选 举 发 扬 光 大 的 秘 法 将 港 澳 本 地 利 益 团 体 代 表 、 人 民 解 放 军 的 军 官 与 负 责 广 东 事 务 的 大 员 们 撮 合 在 一 起 谋 求 共 同 利 益 ： 由 此 形 成 了 一 个 以" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[1]].name_2] + " 为 执 政 长 官 ， 囊 括 “ 澳 门 的 影 子 总 督 ” 何 贤 、 “ 澳 洲 赌 王 ” 何 鸿 燊 与 “ 香 港 首 富 ” 李 嘉 诚 等 强 势 利 益 团 体 的 一 致 政 府 。 改 组 后 的 港 澳 地 区 则 被 划 定 为 统 一 的 “ 南 方 经 济 特 区 ” 以 延 续 我 国 经 济 的 走 出 去 实 验 ： 两 地 得 以 在 经 济 事 务 上 享 有 充 分 自 治 权 ， 且 在 引 入 空 前 宽 松 且 手 腕 坚 决 的 的 投 资 法 、 外 汇 管 控 与 减 税 降 费 政 策 的 同 时 彻 底 放 开 产 品 价 格 与 经 营 形 式 。 通 过 背 靠 广 东 地 区 的 廉 价 劳 动 力 ， 国 家 鼓 励 出 口 立 区 的 政 策 与 整 合 了 黑 帮 - 警 察 - 武 装 力 量 的 强 有 力 安 全 部 门 支 持 。 南 方 经 济 特 区 得 以 在 经 济 增 长 率 上 拿 出 远 超 亚 洲 四 小 龙 的 战 绩 ， 并 在 稳 固 自 身 作 为 亚 洲 大 港 兼 金 融 中 心 地 位 的 同 时 ， 靠 顺 应 产 业 转 移 潮 流 将 逐 渐 自 己 打 造 为 中 国 版 本 的 硅 谷 。 强 调 自 立 自 强 的 狮 子 山 精 神 得 以 在 祖 国 的 保 驾 护 航 下 登 上 新 境 界 — — 即 便 关 于 贫 富 分 化 、 政 商 勾 结 、 劳 工 欠 保 障 与 威 权 发 展 主 义 的 纠 结 不 断 ， 可 港 澳 确 实 在 回 归 中 国 后 来 到 了 它 的 历 史 新 巅 峰 。";
						}
					}
					else
					{
						fake_text = " 西 方 不 亮 东 方 亮 ， 随 着 殖 民 主 义 江 河 日 下 ， 重 申 主 权 与 历 史 正 义 的 时 刻 已 经 来 到 。 我 人 民 解 放 军 的 决 定 性 行 动 更 是 彻 底 为 港 澳 局 势 画 上 了 句 号 ： 早 在12.3 运 动 后 便 成 为 亲 北 京 派 系 主 宰 下 国 中 之 国 的 澳 门 很 快 便 在 里 应 外 合 下 实 现 和 平 解 放 ， 复 刻 了 往 日 和 平 接 管 北 平 的 佳 话 。 而 另 一 边 的 港 英 当 局 也 无 法 阻 挡 人 民 解 放 军 和 香 港 爱 国 同 胞 解 放 香 港 的 决 心 ， 最 终 ， 以 香 港 “ 总 督 ” 为 代 表 的 一 窝 港 英 高 官 资 本 家 不 得 不 接 受 历 史 事 实 ： 只 得 在 签 署 合 约 后 灰 溜 溜 地 带 着 剩 余 资 产 与 残 兵 败 将 离 开 香 港 。 港 澳 新 当 局 首 先 则 并 入 广 东 实 行 共 管 ， 旋 即 在 秩 序 基 本 稳 定 后 被 拆 分 为 广 东 下 辖 的 澳 门 市 与 所 谓 香 港 直 辖 市 。 两 地 政 坛 则 基 本 成 了 团 结 在 现 任 执 政 党 旗 帜 下 的 华 商 、 工 会 与 本 地 其 他 利 益 团 体 的 天 下 ， 让 其 成 为 了 中 国 境 内 的 迷 你 墨 西 哥 。 异 见 人 士 则 在 人 民 解 放 军 与 本 地 民 兵 部 队 的 隔 离 下 每 况 愈 下 ， 处 于 空 前 孤 立 境 地 。 中 国 的 壮 举 由 此 被 冠 以 第 二 次 果 阿 收 复 之 名 ， 并 让 其 在 国 际 舞 台 上 毁 誉 参 半 。";
						if (!GlobalScript.inst.gameState.allcountries[51].Torg)
						{
							fake_text += "其 中 尤 其 引 人 注 目 的 当 属 美 国 总 统 的 指 责 — — “ 中 国 就 是 这 样 落 实 和 平 共 处 五 项 原 则 的 ” ， 并 决 定 借 机 对 中 国 施 加 制 裁 。";
							fake_text += " 可 那 又 如 何 ？ 现 在 是 时 候 享 受 统 一 的 胜 利 果 实 了 ！";
						}
					}
				}
				else if (GlobalScript.inst.gameState.data[65] == 2)
				{
					fake_text = string.Concat(new string[4]
					{
						" 基 于 建 国 以 来 汇 聚 爱 国 主 义 最 大 公 约 数 的 政 策 ，",
						GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
						GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
						" 同 志 决 定 顺 应 去 殖 民 化 时 代 潮 流 ， 坚 决 要 求 曾 脱 离 中 国 的 租 界 地 区 完 全 同 我 国 实 现 整 合 ， 而 香 港 与 澳 门 便 是 实 战 案 例 ： 与 英 国 、 葡 萄 牙 ， 以 及 其 幕 后 东 家 间 的 博 弈 漫 长 且 挑 战 不 断 ； 可 终 究 是 以 我 们 的 胜 利 而 告 终 。 香 港 与 澳 门 将 以 广 东 省 下 辖 市 区 的 形 式 直 接 接 入 地 方 区 划 ， 并 要 求 其 逐 渐 同 北 京 总 路 线 实 现 步 调 一 致 。 考 虑 到 长 期 分 居 的 历 史 已 在 两 地 生 成 了 深 受 西 方 文 化 影 响 的 独 特 生 活 方 式 ， 而 直 接 并 入 中 国 省 份 统 一 的 方 式 必 然 意 味 着 两 种 体 系 的 激 烈 碰 撞 。 意 味 着 我 们 仍 需 要 在 历 史 节 点 到 达 前 准 备 一 条 “ 过 渡 时 期 总 路 线 ” ： 预 计 我 们 将 在1997 年7 月1 日 与1999 年12 月19 日 分 别 完 成 港 澳 主 权 移 交 仪 式 。 在 此 之 前 ， 我 们 得 好 好 为 从 外 国 托 管 逐 渐 变 为 联 合 共 管 ， 最 终 达 成 中 国 接 管 的 转 型 时 期 做 准 备 ："
					});
					if (GlobalScript.inst.gameState.IsSocialism(yes: true, 1) && GlobalScript.inst.gameState.IsSocialism(yes: true, 87) && GlobalScript.inst.gameState.IsSocialism(yes: true, 92))
					{
						fake_text += "英 国 与 葡 萄 牙 局 势 的 戏 剧 性 转 变 为 我 们 提 供 了 借 实 现 民 族 统 一 大 业 彻 底 清 算 历 史 旧 账 的 绝 佳 机 会 。 中 央 决 定 乘 胜 追 击 ， 成 立 具 有 “ 一 机 构 ， 两 牌 子 ” 性 质 的 国 务 院 真 相 澄 清 与 历 史 善 后 办 公 室 （ 其 成 员 包 括 港 澳 三 地 主 要 负 责 人 、 广 东 省 委 与 中 央 代 表 ） ， 赋 予 其 澄 清 历 史 真 相 ， 监 督 港 澳 两 地 ， 可 在 适 当 时 刻 直 接 过 问 港 澳 两 地 管 理 的 权 力 ； 并 寻 求 建 立 国 际 范 围 的 反 殖 民 主 义 统 一 战 线 ， 以 增 强 我 国 揭 露 运 动 的 效 用 。 英 国 与 葡 萄 牙 政 府 不 久 后 便 回 应 我 国 照 会 ， 欣 然 接 受 了 我 国 邀 请 ， 在 工 作 中 发 挥 了 无 可 替 代 的 作 用 ： 它 们 不 仅 以 提 供 殖 民 主 义 罪 行 档 案 的 形 式 为 我 们 推 行 的 转 型 正 义 提 供 有 力 补 充 ， 同 时 还 通 过 了 引 渡 港 澳 反 对 派 政 治 犯 与 批 准 谅 解 书 （ 即 承 认 两 国 殖 民 主 义 罪 行 ， 宣 称 中 国 在 当 地 享 有 完 整 主 权 ， 并 全 力 支 持 中 国 实 现 去 殖 民 化 ） 的 协 定 。 从 而 空 前 震 撼 了 试 图 寻 求 国 际 支 持 的 反 动 分 子 们 。 此 后 ， 我 们 便 以 恢 复 正 义 之 名 筹 建 我 党 控 制 下 的 基 层 准 军 事 组 织 与 临 时 法 庭 ， 审 判 那 些 罪 大 恶 极 之 人 ； 并 在 港 澳 迅 速 引 入 统 一 的 经 济 空 间 、 物 流 管 理 与 社 会 福 利 体 系 ， 以 社 会 主 义 生 活 的 优 越 性 帮 助 他 们 做 出 适 当 的 选 择 。 适 应 三 地 的 新 历 史 教 学 体 系 与 政 治 审 查 制 度 业 已 引 入 ， 各 地 也 纷 纷 开 始 兴 修 纪 念 当 地 回 归 祖 国 的 解 放 纪 念 馆 ， 并 对 当 地 地 标 与 官 僚 体 系 进 行 “ 吐 故 纳 新 ” ： 剔 除 与 殖 民 者 密 切 相 关 的 ， 限 制 与 转 换 缺 乏 意 识 形 态 色 彩 的 ， 发 展 我 们 所 乐 见 的 。 试 图 借 题 发 挥 的 顽 固 反 对 派 与 抵 抗 分 子 也 在 软 硬 兼 施 的 方 针 下 被 新 建 民 兵 与 人 民 解 放 军 隔 离 与 消 灭 。 总 的 来 说 ， 港 澳 地 区 的 政 治 转 型 正 在 以 一 个 我 们 所 乐 见 的 速 度 迅 速 推 进 。 历 史 正 义 也 得 以 伸 张 。 这 对 我 们 来 说 挺 好 的 。";
					}
					else
					{
						fake_text += "考 虑 到 澳 门 早 在 1 2 . 3 运 动 后 便 成 为 了 亲 北 京 派 系 主 宰 的 国 中 之 国 ， 当 地 坦 然 接 受 了 同 祖 国 团 圆 以 及 直 接 并 入 广 东 省 的 现 实 ， 并 老 老 实 实 地 顺 应 了 当 前 局 势 。 而 香 港 的 情 况 则 相 对 复 杂 ： 现 代 严 酷 的 斗 争 局 势 与 伴 随 于 此 盛 行 的 逃 港 潮 流 ， 乃 至 港 英 政 府 对 本 土 市 民 社 会 的 长 期 耕 耘 基 本 将 当 地 塑 造 为 了 “ 亚 洲 版 的 西 柏 林 ” 。 意 识 形 态 光 谱 杂 乱 无 序 ， 根 植 于 地 方 情 绪 与 反 共 反 陆 思 潮 的 排 外 沙 文 主 义 思 潮 更 是 蔚 然 成 风 。 因 此 ， 我 们 决 定 以 民 主 德 国 “ 人 民 民 主 化 ” 与 美 国 南 方 重 建 为 蓝 本 解 决 问 题 ： 香 港 的 社 会 组 织 均 以 地 方 分 部 的 形 式 对 中 国 本 部 的 团 体 进 行 加 盟 ， 教 育 体 系 也 将 完 全 同 我 国 义 务 教 育 制 度 完 全 接 轨 ； 香 港 社 会 建 制 也 被 按 照 国 内 标 准 改 革 一 新 ， 且 公 共 机 构 内 的 所 有 官 员 都 需 要 经 受 履 历 审 查 与 再 培 训 ， 满 足 本 土 的 各 项 标 准 后 才 可 回 归 岗 位 。 除 此 之 外 ， 我 们 通 过 在 当 地 引 入 开 发 补 贴 、 确 保 廉 价 物 资 供 应 与 大 兴 公 共 住 房 的 方 式 稳 住 了 香 港 人 的 日 常 生 活 ， 不 至 于 让 其 在 社 会 改 造 中 遭 受 过 重 冲 击 。 多 管 齐 下 的 政 策 得 以 稳 住 绝 大 多 数 香 港 人 的 日 常 生 活 ， 并 能 最 大 限 度 地 将 本 地 顽 固 的 反 对 派 孤 立 在 外 。 当 然 ， 对 当 地 的 整 顿 绝 非 一 日 之 功 ， 而 我 们 已 经 迈 出 了 坚 实 的 一 步 … …";
					}
					if (GlobalScript.inst.gameState.IsAuthoritarianism(87))
					{
						fake_text += "|然 而 ， 事 情 并 未 到 此 为 止 ： 政 变 后 崛 起 的 葡 萄 牙 “ 新 ” 新 国 家 体 制 充 分 继 承 了 萨 拉 查 主 义 衣 钵 ， 仍 不 自 量 力 地 怀 抱 葡 萄 牙 帝 国 之 梦 ， 并 试 图 将 澳 门 作 为 重 振 自 身 声 威 的 跳 板 ： 他 们 已 借 对 旧 政 府 反 攻 倒 算 之 风 否 定 其 签 署 的 各 项 条 约 ， 其 中 也 包 括 因 政 局 不 稳 而 提 前 向 我 们 完 成 移 交 澳 门 的 协 定 。 而 结 果 自 不 必 多 言 — — 以 卵 击 石 ， 不 自 量 力 ！";
					}
					if (GlobalScript.inst.gameState.allcountries[92].SubGosstroy == 9)
					{
						fake_text += "|然 而 ， 事 情 并 未 到 此 为 止 ： 异 军 突 起 的 英 国 国 家 主 义 者 们 决 定 对 大 英 帝 国 “ 故 事 重 提 ” ， 并 尝 试 将 香 港 重 新 纳 入 不 列 颠 秩 序 的 手 中 ： 他 们 已 借 对 旧 政 府 反 攻 倒 算 之 风 否 定 其 签 署 的 各 项 条 约 ， 其 中 也 包 括 因 政 局 不 稳 而 提 前 向 我 们 完 成 移 交 香 港 的 协 定 ： 尤 其 是 考 虑 到 工 党 政 府 与 英 国 国 内 的 部 分 异 见 者 将 香 港 作 为 自 己 的 政 治 避 难 港 ， 新 政 权 更 有 必 要 将 这 个 “ 亚 洲 版 本 的 西 柏 林 ” 给 收 回 手 中 。 而 从 流 亡 者 口 中 得 知 伦 敦 内 政 治 恐 怖 的 香 港 异 见 者 也 彻 底 摒 弃 了 试 图 从 港 英 身 上 汲 取 “ 本 土 化 ” 力 量 的 政 治 立 场 ， 从 而 加 入 到 本 地 的 “ 大 联 盟 ” 内 采 取 软 手 段 谋 求 共 治 — — 至 少 对 我 们 来 说 挺 好 的 。";
					}
				}
				if (GlobalScript.inst.gameState.data[62] <= 0)
				{
					fake_text += "|| 藏 南 地 区 （ 阿 鲁 纳 恰 尔 邦 ） 仍 然 是 印 度 的 一 部 分 ， 中 国 不 予 承 认 。 在 这 个 问 题 上 的 谈 判 ， 甚 至 在 国 际 组 织 的 帮 助 下 仍 没 有 取 得 成 功 ， 因 此 印 中 边 境 局 势 仍 然 紧 张 。 然 而 ， 双 方 不 太 可 能 对 战 争 感 兴 趣 …";
				}
				else if (GlobalScript.inst.gameState.data[62] <= 0 && GlobalScript.inst.gameState.allcountries[19].proprc)
				{
					fake_text += "|| 藏 南 地 区 （ 阿 鲁 纳 恰 尔 邦 ） 过 去 是 印 度 的 一 部 分 ，但 现 在 情 况 已 悄 然 改 变 ： 在 中 国 于 印 度 内 战 中 支 持 的 势 力 上 台 后 ， 印 度 对 藏 南 地 区 的 态 度 如 同 6 0 年 代 葡 萄 牙 对 待 澳 门 那 样 ： 虽 未 声 明 ， 却 默 许 了 中 国 在 此 地 驻 军 并 接 管 此 地 ， 因 此 印 中 边 境 局 势 得 以 逐 渐 缓 和 ， 这 无 疑 对 双 方 都 是 一 件 好 事 …";
				}
				else if (GlobalScript.inst.gameState.data[62] == 1)
				{
					fake_text += "|| 我 们 与 印 度 领 导 层 就 领 土 问 题 的 折 衷 解 决 达 成 了 协 议 — — 中 国 不 再 宣 称 阿 鲁 纳 恰 尔 邦 ， 而 印 度 也 停 止 宣 称 中 国 在1962 年 边 境 冲 突 期 间 占 领 的 阿 克 塞 钦 地 区 ， 通 过 该 地 区 ， 我 们 连 接 了 新 疆 和 西 藏 的 重 要G219 公 路 。 这 一 决 定 最 终 为 恢 复 亚 洲 两 大 国 家 的 睦 邻 关 系 开 辟 了 道 路 ， 大 大 缓 解 了 亚 洲 地 区 的 紧 张 局 势 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(39);
					}
				}
				else if (GlobalScript.inst.gameState.data[62] == 2 && GlobalScript.inst.gameState.allcountries[19].proprc)
				{
					fake_text += "|| 中 国 最 终 结 束 了 与 印 度 长 期 存 在 的 领 土 争 端 — — 我 们 武 装 力 量 的 决 定 性 行 动 使 得 藏 南 地 区 （ 即 伪 阿 鲁 纳 恰 尔 邦 ） 完 整 的 回 归 中 国 。而 在 内 战 后 上 台 的 新 印 度 领 导 层 识 趣 的 没 有 旧 事 重 提 ， 就 好 像 印 度 从 未 占 领 过 该 地 … …";
				}
				else if (GlobalScript.inst.gameState.data[62] == 2)
				{
					fake_text += "|| 中 国 最 终 结 束 了 与 印 度 长 期 存 在 的 领 土 争 端 — — 我 们 武 装 力 量 的 决 定 性 行 动 使 得 藏 南 地 区 （ 即 伪 阿 鲁 纳 恰 尔 邦 ） 完 整 的 回 归 中 国 。 印 度 的 领 导 层 ， 在 该 国 锡 克 教 地 区 局 势 再 度 恶 化 以 及 与 巴 基 斯 坦 的 冲 突 的 背 景 下 ， 不 得 不 承 认 我 们 在 这 片 领 土 上 的 主 权 ， 尽 管 失 去 这 个 国 家 的 重 要 地 区 让 他 们 非 常 愤 怒 。 根 据 我 们 的 情 报 ， 印 度 正 在 与 美 国 、 苏 联 和 英 国 秘 密 谈 判 ， 为 其 军 队 的 大 规 模 再 装 备 提 供 大 量 武 器 和 设 备 。 这 些 准 备 是 针 对 谁 的 — — 不 问 自 明 … …";
				}
				else if (GlobalScript.inst.gameState.data[62] >= 3 && GlobalScript.inst.gameState.allcountries[19].proprc)
				{
					fake_text += "|| 中 国 最 终 结 束 了 与 印 度 长 期 存 在 的 领 土 争 端 — — 我 们 关 键 性 的 投 资 挽 救 了 因 为 内 战 濒 临 崩 溃 的 印 度 ， 作 为 交 换 条 件 ， 藏 南 地 区 （ 即 伪 阿 鲁 纳 恰 尔 邦 ） 最 终 完 整 的 回 归 中 国 。 目 前 印 度 的 领 导 层 还 没 有 任 何 异 议 ， 看 来 这 算 是 一 场 双 方 都 满 意 的 交 易 … … ";
				}
				else if (GlobalScript.inst.gameState.data[62] >= 3)
				{
					fake_text += "|| 中 国 最 终 结 束 了 与 印 度 长 期 存 在 的 领 土 争 端 — — 我 们 外 交 专 员 的 决 定 性 行 动 使 得 藏 南 地 区 （ 即 伪 阿 鲁 纳 恰 尔 邦 ） 完 整 的 回 归 中 国 。 印 度 的 领 导 层 ， 在 该 国 锡 克 教 地 区 局 势 再 度 恶 化 以 及 国 内 经 济 下 行 的 背 景 下 ， 不 得 不 承 认 我 们 在 这 片 领 土 上 的 主 权 ， 尽 管 失 去 这 个 国 家 的 重 要 地 区 让 他 们 国 内 的 人 民 感 到 非 常 愤 怒 。 根 据 我 们 的 情 报 ， 印 度 正 在 与 美 国 、 苏 联 和 英 国 秘 密 谈 判 ， 为 其 军 队 的 大 规 模 再 装 备 提 供 大 量 武 器 和 设 备 。 这 些 准 备 是 针 对 谁 的 — — 这 可 不 好 说 ： 是 针 对 其 国 内 骚 动 的 人 民 ？ 还 是 意 图 对 藏 南 地 区 故 事 重 提 ？ … …";
				}
				if (GlobalScript.inst.gameState.data[64] == 2 && GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
				{
					fake_text += "|| 隆 隆 作 响 的 中 国 战 争 机 器 彻 底 粉 碎 了 “ 伪 政 府 ” 。 在 癫 狂 的 近 乎 可 怕 的 “ 把 台 湾 黎 巴 嫩 化 ” 的 口 号 下 ， 中 国 人 民 解 放 军 进 行 了 一 场 远 超 诺 曼 底 登 陆 的 登 陆 战 和 接 近 三 年 的 围 城 之 战 。 无 数 的 炮 弹 和 导 弹 像 雨 点 般 倾 泻 在 曾 经 被 称 作 “ 美 丽 之 岛 ” 的 土 地 上 ， 大 量 的 难 民 试 着 前 往 附 近 的 国 家 和 美 国 避 难 ， 也 有 少 数 群 众 呆 在 我 们 所 划 定 的 五 个 “ 安 全 区 ” 内 。 不 过 在 惨 绝 人 寰 的 花 莲 大 屠 杀 后 ， 再 也 没 人 相 信 我 方 的 诚 意 了 。|最 终 弹 尽 粮 绝 的 “ 伪 政 府 ” 签 署 了 投 降 协 定 ， 我 们 正 式 结 束 了 中 国 内 战 。 送 到 我 们 手 上 的 宝 岛 确 实 十 足 的 烂 摊 子 ： 我 们 需 要 花 上 大 把 时 间 来 重 建 台 湾 岛 ， 和 当 地 人 的 关 系 也 从 解 放 者 变 为 了 侵 略 者 。 我 们 的 官 员 难 以 离 开 由 我 方 把 守 的 城 市 ， 但 由 敌 对 超 级 大 国 支 持 的 “ 福 尔 摩 沙 自 由 运 动 ” 也 难 以 动 摇 我 们 的 统 治 。 历 任 台 湾 军 区 书 记 也 因 此 得 名 “ 总 督 ” ， 在 来 自 我 国 城 市 内 的 失 业 者 则 被 鼓 励 前 往 台 湾 落 户 。 只 有 在 他 们 的 帮 助 下 ， 我 们 才 能 慢 慢 的 消 除 旧 威 胁 。 也 许 在 不 久 的 将 来 ， 我 们 也 会 迎 来 自 己 的 2 2 8 事 件 。 但 只 要 把 人 换 完 种 就 好 了 … … 不 过 是 谁 这 么 说 过 呢 ？|<color=red>亚 细 亚 的 孤 儿 ， 在 风 中 哭 泣 。 没 有 人 愿 意 陪 你 ， 玩 平 等 的 游 戏 …</color>";
				}
				else if (GlobalScript.inst.gameState.completedDecisions[6])
				{
					fake_text += "||";
					if (GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.empires[0].relations < 500 || GlobalScript.inst.gameState.data[6] > 500)
					{
						fake_text += GlobalScript.inst.new_texts[289];
					}
					fake_text += GlobalScript.inst.new_texts[290];
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(66);
					}
				}
				else if (GlobalScript.inst.gameState.completedDecisions[7])
				{
					fake_text += "||";
					fake_text += GlobalScript.inst.new_texts[292];
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(78);
					}
				}
				else if (!GlobalScript.inst.gameState.completedDecisions[6] && !GlobalScript.inst.gameState.completedDecisions[7])
				{
					if (GlobalScript.inst.gameState.event_done[461] && GlobalScript.inst.gameState.resultOfEvents[461] == 0)
					{
						fake_text += "|| 因 为 我 们 对 美 丽 岛 组 织 左 派 的 提 前 援 助 ， 我 们 得 以 重 建 台 湾 共 产 党 支 部 ， 并 在 美 帝 国 主 义 者 衰 落 之 后 和 平 解 决 台 湾 问 题 ， 现 在 ， 台 湾 重 新 回 到 了 祖 国 的 怀 抱 ， 并 且 再 也 不 会 分 开 ！ ";
					}
					else if (GlobalScript.inst.gameState.event_done[461] && GlobalScript.inst.gameState.resultOfEvents[461] == 1)
					{
						fake_text += "|| 因 为 我 们 在 美 帝 国 主 义 者 衰 落 之 后 对 台 湾 进 行 了 封 锁 并 使 蒋 伪 政 府 倒 台 ， 现 在 ， 台 湾 重 新 回 到 了 祖 国 的 怀 抱 。 ";
					}
					else if (GlobalScript.inst.gameState.allcountries[38].dev > 0)
					{
						fake_text = fake_text + "|| 台 湾 的 分 离 主 义 者 躲 在 他 们 美 国 盟 友 的 背 后 ， 但 他 们 高 估 自 己 的 军 事 实 力 ， 也 低 估 了 我 们 统 一 祖 国 的 决 心 。 我 军 的 登 陆 部 队 迅 速 地 夺 取 了 台 湾 的 沿 海 岛 屿 ， 将 叛 徒 从 那 驱 逐 出 去 ， 恢 复 了 我 们 对 这 些 岛 屿 的 主 权 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 主 席 向 狼 狈 哀 嚎 的 帝 国 主 义 者 郑 重 警 告 ： “ 中 国 的 领 土 是 统 一 而 不 可 分 割 的 ！ ” 。 当 然 ， 我 们 凭 借 自 己 是 没 办 法 夺 回 驻 扎 着 美 军 的 台 湾 岛 的 ， 而 且 也 不 会 在 此 之 后 和 他 们 谈 判 … …";
					}
					else if ((GlobalScript.inst.gameState.allcountries[38].proprc && GlobalScript.inst.gameState.data[6] < 700 && GlobalScript.inst.gameState.data[16] >= 13 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.modifies[17].active) || GlobalScript.inst.gameState.completedDecisions[6])
					{
						fake_text = fake_text + " || " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 提 出 了 “ 一 国 两 制 ” 的 重 要 理 论 ： 台 湾 、 香 港 和 澳 门 可 以 在 回 归 祖 国 的 怀 抱 的 基 础 上 ， 保 持 自 己 的 经 济 和 政 治 制 度50 年 不 变 ， 同 时 也 会 获 得 广 泛 的 自 治 权 。 长 期 以 来 ， 台 湾 的 领 导 人 拒 绝 与 我 们 谈 判 ， 但 最 终 我 们 迫 使 他 们 坐 在 圆 桌 前 与 我 们 达 成 协 议 。 中 华 人 民 共 和 国 正 式 承 认 中 华 民 国 是 独 立 国 家 ， 中 华 民 国 也 放 弃 了 对 大 陆 沿 海 岛 屿 的 宣 称 ， 为 此 ， 台 湾 正 式 放 弃 了 “ 三 民 主 义 ” 的 意 识 形 态 ， 并 接 受 了 “ 一 国 两 制 ” 。 基 于 统 一 两 岸 原 则 的 谈 判 已 经 开 始 ， 条 件 显 然 是 组 建 邦 联 或 更 松 散 的 政 治 实 体 ， 同 时 撤 出 驻 台 美 军 基 地 的 谈 判 也 在 进 行 。 但 祖 国 的 最 终 统 一 之 日 仍 不 会 很 快 到 来 … …";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(66);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[38].proprc || GlobalScript.inst.gameState.allcountries[38].Torg)
					{
						fake_text = fake_text + "|| 尽 管 遭 到 了 强 硬 派 和 保 守 派 的 强 烈 反 对 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 仍 能 够 力 排 众 议 ， 承 认 了 台 湾 的 主 权 ， 终 结 了 近 半 个 世 纪 的 敌 对 状 态 。 根 据 中 国 外 交 的 新 方 针 ， 台 湾 独 立 已 久 ， 并 在 此 期 间 发 展 出 了 迥 然 于 大 陆 的 文 化 、 经 济 和 政 治 ， 同 时 还 和 国 际 社 会 建 立 起 了 紧 密 的 联 系 ， 以 至 于 不 再 能 够 说 “ 台 湾 是 中 华 人 民 共 和 国 的 一 部 分 ” 了 。 大 陆 宣 布 了 建 立 中 华 人 民 共 和 国 和 台 湾 共 和 国 友 邻 关 系 的 新 原 则 ， 新 近 成 立 的 台 湾 共 和 国 也 以 放 弃 对 大 陆 的 宣 称 作 为 回 报 。";
					}
					else
					{
						fake_text += "|| 所 谓 “ 中 华 民 国 ” 的 分 离 主 义 者 继 续 控 制 着 台 湾 和 其 沿 海 岛 屿 ， 依 靠 着 美 国 的 军 事 支 持 继 续 高 调 地 反 对 与 大 陆 恢 复 关 系 。 我 们 只 能 叹 口 气 ， 并 继 续 向 这 些 侵 略 者 发 出 “ 最 后 一 次 的 强 烈 谴 责 ” … …";
					}
				}
			}
			else if (number_of_e == 3)
			{
				name.text = " 新 的 领 土";
				fake_text = "";
				if (GlobalScript.inst.gameState.IndOpp)
				{
					fake_text += "英 明 领 袖 华 国 锋 同 志 看 穿 了 苏 联 修 正 主 义 分 子 的 虚 弱 实 质 ， 最 终 将 近 代 所 有 的 失 地 收 入 囊 中 ， 一 雪 国 耻 。 随 着 外 蒙 古 和 唐 努 乌 梁 海 再 次 回 归 祖 国 的 怀 抱 ， 对 这 些 地 区 的 “ 去 苏 化 ” 与 “ 再 中 国 化 ” 也 开 始 了 ： 首 先 便 是 对 蒙 古 人 民 党 的 定 性 ， 我 们 的 宣 传 机 器 将 苏 赫 巴 托 尔 塑 造 为 带 领 蒙 古 人 民 响 应 辛 亥 革 命 ， 推 翻 清 政 府 统 治 的 革 命 英 雄 ， 宣 传 其 “ 并 未 想 使 外 蒙 古 独 立 ， 因 此 被 蒙 独 分 子 霍 尔 洛 · 乔 巴 山 毒 死 ” ； 乌 兰 巴 托 被 改 回 清 代 的 名 称 “ 库 伦 ” ， 乔 巴 山 市 也 被 改 回 “ 巴 彦 图 门 ” ， 蒙 古 地 区 的 行 政 区 划 也 回 归 了 民 国 时 期 的 划 分 。 鉴 于 外 蒙 古 地 区 仍 有 苏 联 和 蒙 独 余 孽 存 在 ， 我 们 决 定 派 遣 滕 海 清 同 志 前 往 外 蒙 古 主 持 剿 匪 镇 反 工 作 ， 恢 复 生 产 。 进 入 新 世 纪 ， 内 蒙 古 出 身 的 乌 恩 巴 特 尔 同 志 成 为 了 漠 北 省 的 领 导 人 。 在 我 们 的 建 设 下 ， 漠 北 摆 脱 了 对 矿 产 品 出 口 的 单 一 依 赖 ， 集 约 化 养 殖 业 也 有 了 相 当 大 的 发 展 ， 日 益 严 重 的 草 场 荒 漠 化 也 有 了 逆 转 的 趋 势 。 当 然 ， 俄 罗 斯 控 制 下 的 卡 尔 梅 克 人 和 蒙 独 余 孽 时 不 时 会 在 国 际 上 哭 诉 我 们 “ 正 系 统 化 消 灭 蒙 古 文 化 ” “ 修 建 蒙 古 人 ‘ 再 教 育 营 ’ ” ， 但 这 都 是 改 善 漠 北 地 区 教 育 质 量 的 必 要 之 举 ， 对 吧 ？|血 债 需 用 血 来 偿 。 面 对 侵 略 者 的 后 代 ， 我 们 秉 持 着 “ 草 要 过 火 、 石 要 过 刀 、 人 要 换 种 ” 的 理 念 ， 将 这 里 的 苏 联 人 一 洗 而 净 。 我 们 特 地 让 这 些 人 体 验 了 当 年 海 兰 泡 和 江 东 六 十 四 屯 同 胞 们 的 痛 苦 ， 他 们 的 鲜 血 染 红 了 黑 龙 江 。 美 帝 苏 修 对 我 们 的 复 仇 表 示 了 强 烈 谴 责 ， 甚 至 我 们 的 一 些 友 邦 也 认 为 此 举 过 于 野 蛮 。 当 然 ， 这 是 我 们 的 内 政 ， 他 人 无 权 指 责 。 在 清 洗 过 殖 民 遗 毒 后 ， 这 里 将 变 成 我 们 新 的 王 道 乐 土 … …|在 您 的 率 领 下 ， 我 国 对 新 疆 地 区 的 实 控 范 围 首 次 越 过 了 清 代 的 卡 伦 线 ， 直 抵 巴 尔 喀 什 湖 。 中 亚 的 精 华 部 分 几 乎 全 部 被 纳 入 了 我 国 范 围 ， 新 疆 的 首 府 也 得 以 迁 回 伊 犁 。 就 像 清 代 做 的 一 样 ， 我 们 对 外 西 北 地 区 的 地 名 进 行 了 全 面 汉 化 ， 阿 拉 木 图 被 重 命 名 为 “ 絜 山 ” ， 托 克 马 克 被 重 命 名 为 “ 碎 叶 ” 。 由 于 本 就 是 跨 境 民 族 ， 当 地 居 民 对 我 们 治 理 也 没 有 表 现 出 不 适 应 ， 甚 至 苏 联 境 内 的 少 数 民 族 时 常 越 界 进 入 我 们 国 内 ， 我 们 当 然 对 这 些 志 士 表 达 了 欢 迎 。 相 信 有 着 七 河 流 域 的 滋 养 ， 新 疆 会 更 为 繁 荣 。";
				}
				else
				{
					if (GlobalScript.inst.gameState.allcountries[9].prosov && !GlobalScript.inst.gameState.completedDecisions[19])
					{
						fake_text = "蒙 古 人 民 共 和 国 继 续 像 过 去 的 十 年 那 样 ， 为 莫 斯 科 的 查 干 汗 们 提 供 优 质 的 牛 羊 草 场 和 矿 石 。 许 多 外 国 观 察 家 已 经 认 为 不 能 再 以 独 立 的 主 权 国 家 视 角 来 看 待 蒙 古 ， 更 有 甚 者 将 其 与 日 本 帝 国 主 义 所 设 立 的 “ 伪 满 洲 国 ” 加 以 类 比 。 蒙 古 就 这 样 和 苏 联 亦 步 亦 趋 ， 走 向 那 深 邃 又 未 知 的 未 来 … …";
					}
					else if (!GlobalScript.inst.gameState.allcountries[9].prosov && !GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19])
					{
						fake_text = "蒙 古 的 新 局 势 迫 使 该 国 领 导 层 正 确 的 认 识 国 际 局 势 ， 在 事 实 上 结 束 了 单 独 依 靠 苏 联 的 外 交 方 针 。 并 得 以 作 为 我 国 和 苏 联 之 间 的 缓 冲 区 继 续 存 在 ， 但 对 于 该 国 领 导 层 来 说 ， 怎 么 正 确 的 认 识 南 方 邻 居 仍 然 是 一 个 需 要 在 摸 索 中 探 寻 的 真 理 。";
					}
					else if (GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19])
					{
						fake_text = "蒙 古 的 政 局 发 生 的 突 然 变 化 令 苏 联 与 我 们 都 感 到 震 惊 ， 新 领 导 层 对 我 们 的 善 意 更 是 令 我 们 满 意 。 很 快 ， 一 系 列 特 别 投 资 方 案 便 开 始 执 行 ， 我 们 也 象 征 性 的 对 文 化 大 革 命 时 期 动 荡 不 安 的 内 蒙 做 最 终 定 论 。 在 团 结 一 致 向 前 看 和 中 蒙 友 谊 万 年 长 的 口 号 下 ， 这 不 过 是 段 加 深 我 们 中 蒙 两 国 友 谊 的 意 外 罢 了 。 谁 会 和 光 明 的 前 景 过 不 去 呢 ？ 为 苏 赫 巴 托 尔 干 杯 ！";
					}
					else if (GlobalScript.inst.gameState.allcountries[9].puppetOf == 1)
					{
						if (GlobalScript.inst.gameState.data[130] != 1)
						{
							fake_text = "在 我 国 的 军 事 行 动 胜 利 之 后 ， 蒙 古 迎 来 了 历 史 的 新 篇 章 。 前 中 共 的 蒙 古 族 党 员 ， 绰 号 “ 蛮 牛 ” 的 乌 恩 巴 特 尔 得 以 顺 利 接 班 下 了 达 拉 姆 的 班 ， 并 在 蒙 古 展 开 了 完 全 以 我 国 为 对 象 的 “ 一 边 倒 ” 发 展 策 略 。 我 们 和 傀 儡 政 府 展 开 了 相 当 多 的 合 作 ， 尤 其 在 是 开 发 矿 冶 的 方 面 ， 并 在 事 实 上 推 进 了 蒙 古 的 现 代 化 与 工 业 化 。 引 入 我 国 的 先 进 农 业 经 验 ， 蒙 古 第 一 次 完 成 了 粮 食 自 给 ， 甚 至 可 以 出 口 其 他 国 家 赚 取 外 汇 ， 他 们 的 铁 路 也 得 以 和 我 国 的 接 轨 。 我 国 在 蒙 古 也 有 数 量 不 少 的 军 事 观 察 家 和 驻 军 ， 并 承 担 了 基 建 和 开 发 矿 产 的 计 划 。 尽 管 仍 然 有 不 少 人 把 新 政 府 视 为 我 们 的 代 理 人 ， 但 治 安 指 挥 部 将 会 粉 碎 他 们 破 坏 中 蒙 友 谊 的 阴 谋 。 在 我 们 的 授 意 下 ， 蒙 古 展 开 了 新 的 一 轮 “ 整 风 ” 和 “ 挖 肃 ” 运 动 ， 事 实 上 摧 毁 了 蒙 古 人 抵 抗 的 决 心 ， 被 认 为 不 忠 的 人 不 仅 被 蒙 古 情 报 局 纳 入 密 切 的 监 控 中 ， 更 有 甚 者 会 被 投 入 “ 民 族 团 结 教 育 营 ” 中 ； 政 府 在 公 报 和 重 要 文 件 上 完 全 采 用 普 通 话 和 汉 语 ， 大 力 推 行 去 蒙 语 化 。 这 一 切 都 是 蒙 古 和 祖 国 越 走 越 近 的 必 要 之 痛 ， 革 命 团 结 与 友 谊 万 岁 ！";
						}
						else
						{
							fake_text = "在 我 国 的 军 事 行 动 胜 利 之 后 ， 蒙 古 迎 来 了 历 史 的 新 篇 章 。 在 短 暂 的 自 治 后 ， 我 们 迫 使 我 们 的 蒙 古 傀 儡 发 起 了 一 场 要 求 回 归 我 国 的 公 投 。 毫 不 意 外 的 ，99.89 % 的 得 票 率 压 倒 性 的 通 过 了 蒙 古 自 治 区 解 散 并 完 全 加 入 我 国 的 决 议 。 蒙 古 被 彻 底 肢 解 ， 为 了 防 止 他 们 再 次 逃 脱 我 们 的 手 掌 心 ， 我 们 决 定 借 鉴 民 国 时 期 对 蒙 古 地 方 的 行 政 区 划 ， 由 多 个 “ 部 ” 和 道 进 行 管 辖 ， 他 们 也 恢 复 了 过 去 的 汉 语 名 。 蒙 古 正 式 成 为 了 我 国 的 一 部 分 ， 而 阿 尔 泰 山 区 和 达 里 冈 爱 则 被 割 走 。 作 为 回 报 ， 他 们 将 在 全 国 人 大 固 定 保 留 总 计65 个 席 位 。|步 入 新 世 纪 后 ， 前 中 共 的 蒙 古 族 党 员 ， 绰 号 “ 蛮 牛 ” 的 乌 恩 巴 特 尔 得 以 顺 利 接 班 下 了 达 拉 姆 的 班 ， 并 在 蒙 古 展 开 了 完 全 以 我 国 为 对 象 的 “ 一 边 倒 ” 发 展 策 略 。 我 们 的 转 移 支 付 在 事 实 上 推 进 了 蒙 古 的 现 代 化 与 工 业 化 。 引 入 我 国 的 先 进 农 业 经 验 ， 蒙 古 第 一 次 完 成 了 粮 食 自 给 ， 甚 至 可 以 出 口 其 他 国 家 为 我 国 赚 取 外 汇 ， 铁 路 也 得 以 和 我 国 的 接 轨 。 我 国 在 蒙 古 也 有 数 量 不 少 的 军 事 观 察 家 和 驻 军 ， 并 承 担 了 基 建 和 开 发 矿 产 的 计 划 。 尽 管 仍 然 有 不 少 人 把 蒙 古 视 为 我 们 的 新 型 殖 民 地 ， 但 治 安 指 挥 部 粉 碎 了 他 们 破 坏 中 蒙 民 族 友 谊 的 阴 谋 。 在 我 们 的 授 意 下 ， 蒙 古 展 开 了 新 的 一 轮 “ 整 风 ” 和 “ 挖 肃 ” 运 动 ， 事 实 上 摧 毁 了 蒙 古 人 抵 抗 的 决 心 ， 被 认 为 不 忠 的 人 不 仅 被 蒙 古 情 报 局 纳 入 密 切 的 监 控 中 ， 更 有 甚 者 会 被 投 入 “ 民 族 团 结 教 育 营 ” 中 ； 政 府 在 公 报 和 重 要 文 件 上 完 全 采 用 普 通 话 和 汉 语 ， 大 力 推 行 去 蒙 语 化 。 这 一 切 都 是 蒙 古 与 过 去 切 割 而 拥 抱 未 来 的 必 要 之 痛 ， 革 命 团 结 与 友 谊 万 岁 ！";
						}
					}
					else if (GlobalScript.inst.gameState.data[57] >= 300 && (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0 || GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2))
					{
						if (GlobalScript.inst.gameState.data[18] == 20 && GlobalScript.inst.gameState.resultOfEvents[551] == 2 && GlobalScript.inst.gameState.event_done[551])
						{
							fake_text = "蒙 古 加 盟 共 和 国 只 是 个 短 命 的 历 史 名 词 ： 在 中 国 领 导 人 重 提 建 立 “ 民 族 区 域 自 治 制 度 ” 必 要 性 的 历 史 背 景 下 ， 当 地 的 自 主 权 便 被 轻 易 地 收 回 中 央 ， 仅 保 留 了 与 内 蒙 古 合 并 的 疆 域 规 划 。 蒙 古 人 民 革 命 党 本 身 也 未 在 该 事 件 后 存 在 多 久 ， 其 亲 中 派 与 效 忠 派 部 分 被 并 入 中 国 共 产 党 的 蒙 古 党 支 部 ， 剩 余 的 异 议 者 则 或 流 亡 苏 联 或 遭 打 压 ， 没 多 久 便 淡 出 了 历 史 舞 台 。 而 对 蒙 古 人 民 本 身 来 说 ， 似 乎 情 况 并 未 发 生 多 少 变 化 — — 中 国 对 蒙 古 的 开 发 与 经 济 整 合 仍 在 有 条 不 紊 的 进 行 ， 来 自 内 地 的 资 金 辅 助 与 建 设 兵 团 很 好 的 填 补 了 蒙 人 党 缺 席 后 滞 留 的 空 缺 ， 维 持 了 当 地 秩 序 ， 以 现 代 化 生 活 帮 助 他 们 投 票 做 出 了 选 择 。 超 级 大 国 则 老 调 重 弹 ， 煞 有 其 事 地 指 责 我 国 违 背 《 中 蒙 联 合 条 约 》 背 信 弃 义 ， 是 典 型 的 外 交 欺 诈 — — 然 而 ， 修 改 国 家 架 构 不 过 是 我 国 内 政 ， 大 国 却 将 其 同 所 谓 国 际 形 象 扯 上 关 系 。 岂 不 怪 哉 ？";
						}
						else
						{
							fake_text = "在 我 们 不 懈 的 努 力 下 ， 中 国 与 蒙 古 就 合 并 事 宜 达 成 了 共 识 。 蒙 古 和 内 蒙 古 被 合 并 成 了 崭 新 的 蒙 古 自 治 区 和 中 国 达 成 联 邦 。 该 自 治 区 拥 有 自 己 的 法 律 ， 政 治 协 商 会 议 委 员 和 人 民 政 府 。 蒙 古 人 民 革 命 党 将 作 为 我 党 在 蒙 古 地 区 的 支 部 处 理 ， 而 原 先 的 蒙 古 人 民 军 则 被 纳 入 中 国 人 民 解 放 军 的 管 理 体 系 。 相 对 的 ， 我 国 在 蒙 古 地 区 也 设 立 了 建 设 兵 团 城 市 ， 用 于 开 发 蒙 古 巨 大 的 矿 冶 资 源 和 畜 牧 业 。 苏 联 傀 儡 下 的 蒙 古 产 业 十 分 单 一 ， 在 我 们 的 帮 助 下 ， 蒙 古 地 区 已 经 建 立 了 完 善 的 农 业 - 工 业 一 体 化 产 业 。 再 也 不 会 有 人 觉 得 蒙 古 只 是 个 充 满 黄 沙 的 地 方 了 。 苏 联 对 我 们 很 不 满 ， 毕 竟 除 了 两 国 的 边 界 显 著 拉 长 之 外 ， 许 多 的 卢 布 也 白 花 了 。 但 无 论 如 何 ， 蒙 古 已 经 重 新 回 到 了 我 们 的 怀 抱 ， 并 再 也 不 会 分 离 了 … … 对 吧 ？";
						}
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(109);
						}
					}
					else
					{
						fake_text = "在 我 们 不 懈 的 努 力 下 ， 中 国 与 蒙 古 就 合 并 事 宜 达 成 了 共 识 。 蒙 古 和 内 蒙 古 被 合 并 成 了 崭 新 的 蒙 古 自 治 区 和 中 国 达 成 联 邦 。 该 自 治 区 拥 有 自 己 的 法 律 ， 政 治 协 商 会 议 委 员 和 人 民 政 府 。 但 随 着 我 国 经 济 政 策 的 极 速 转 向 ， 经 济 却 未 能 得 到 良 好 的 发 展 ， 彻 底 沦 为 了 一 个 经 济 殖 民 地 ， 收 益 尽 被 乌 兰 巴 托 和 北 京 的 官 老 爷 们 夺 走 。 绝 望 的 年 轻 一 代 沉 溺 于 杜 平 ， 西 方 电 视 节 目 和 俄 罗 斯 文 化 。 由 于 未 能 普 及 普 通 话 教 育 导 致 大 量 的 年 轻 人 只 能 在 矿 山 从 事 简 单 体 力 劳 动 。 致 力 于 论 证 “ 是 中 国 的 灾 难 性 政 策 导 致 了 蒙 古 的 崩 溃 ” 的 所 谓 专 家 言 论 在 蒙 古 知 识 分 子 中 广 为 流 传 。 在 原 先 的 外 蒙 古 ， 分 离 主 义 之 风 吹 的 越 来 越 强 劲 了 ， 时 常 有 蒙 古 族 工 人 殴 打 乃 至 谋 杀 汉 族 企 业 家 的 案 件 发 生 ， 而 蒙 古 籍 民 警 拒 绝 干 涉 ， 乃 至 庇 护 凶 手 。 在 原 先 的 内 蒙 古 ， 我 们 的 警 察 也 必 须 面 对 越 来 越 多 的 民 族 主 义 游 行 ， 也 许 在 不 久 的 将 来 ， 什 么 可 怕 的 事 情 确 实 会 发 生 … …";
					}
					fake_text += "||";
					bool flag = !GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[14] < 3 && GlobalScript.inst.gameState.data[16] < 12;
					bool flag2 = (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 13 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 10 || GlobalScript.inst.gameState.data[14] < 4) && GlobalScript.inst.gameState.data[16] < 14) || GlobalScript.inst.gameState.allcountries[51].Torg;
					bool flag3 = (!GlobalScript.inst.gameState.modifies[3].active && !GlobalScript.inst.gameState.modifies[6].active) || GlobalScript.inst.gameState.data[14] > 3 || GlobalScript.inst.gameState.data[16] > 13 || GlobalScript.inst.gameState.data[15] > 7 || GlobalScript.inst.gameState.data[50] > 27 || GlobalScript.inst.gameState.allcountries[51].dev == 1;
					if (GlobalScript.inst.gameState.is_gkchp)
					{
						fake_text += "通 过 对 苏 特 别 军 事 行 动 ， 我 们 得 以 完 全 洗 刷 自1840 年 以 来 的 屈 辱 历 史 ， 并 让 百 年 前 脱 离 祖 国 的 外 东 北 和 外 西 北 通 过 《 再 勘 中 苏 边 界 条 约 》 回 归 中 国 人 民 怀 抱 。 五 星 红 旗 就 此 飘 扬 在 秋 海 棠 故 土 之 上 ， 殖 民 者 从 远 方 来 ， 又 从 远 方 去 ， 中 国 将 永 不 分 离 ， 这 一 日 也 被 定 为 祖 国 统 一 日 。 不 过 ， 我 们 显 然 还 需 要 花 时 间 弥 合 历 史 伤 痕 ： 首 先 便 是 处 理 外 东 北 与 外 西 北 地 区 错 综 复 杂 的 民 族 问 题 ， 并 确 定 当 地 人 民 在 新 政 权 内 的 地 位 ； 其 次 则 是 应 付 由 残 存 苏 军 与 俄 罗 斯 民 族 主 义 者 组 成 的 各 路 “ 绿 洲 兄 弟 ” 、 “ 极 地 兄 弟 ” 游 击 队 与 北 方 邻 居 的 复 仇 主 义 ； 乃 至 从 前 者 派 生 的 舆 论 ， 安 全 ， 社 会 建 设 与 经 济 发 展 问 题 等 等 … … 所 有 的 一 切 都 急 需 我 们 持 之 以 恒 地 投 入 人 力 物 力 ， 并 做 好 打 持 久 战 的 准 备 — — 清 除 历 史 污 点 的 实 践 实 属 不 易 ， 可 至 少 我 们 已 将 钉 子 钉 死 在 了 国 耻 棺 材 之 上 。";
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[641] == 0)
					{
						fake_text += "我 们 所 发 起 的 “ 血 浓 于 水 ” 计 划 大 获 成 功 ， 大 量 的 苏 联 异 见 者 和 亲 中 派 纷 纷 越 过 边 界 来 到 我 国 寻 求 庇 护 。 而 我 们 也 得 以 借 此 机 会 打 出 “ 外 东 北 牌 ” 和 “ 外 西 北 牌 ” ， 从 而 遏 制 苏 联 和 美 国 所 达 成 的 邪 恶 同 盟 。 但 计 划 总 赶 不 上 变 化 ， 随 着 我 国 与 苏 联 的 关 系 出 于 地 缘 政 治 考 虑 而 发 生 的 戏 剧 性 转 变 ， 怎 么 利 用 手 上 的 这 两 张 牌 就 变 成 了 问 题 。 一 方 面 ， 我 国 与 苏 联 联 合 打 击 以 “ 滨 海 边 疆 区 自 由 战 士 ” 为 首 的 极 端 暴 恐 势 力 ， 并 顺 利 将 其 主 谋 绳 之 以 法 。 而 另 一 方 面 ， “ 外 西 北 自 由 同 盟 ” 和 “ 外 东 北 人 民 革 命 党 ” 仍 然 在 乌 鲁 木 齐 和 哈 尔 滨 的 办 公 室 内 发 表 声 讨 苏 联 暴 政 的 檄 文 ， 声 泪 俱 下 的 控 诉 苏 联 内 部 的 大 俄 罗 斯 主 义 和 民 族 迫 害 。 苏 联 多 次 对 我 们 庇 护 这 些 破 坏 中 苏 关 系 的 组 织 表 示 抗 议 ， 但 我 亲 爱 的 伊 万 们 ， 是 谁 在 六 十 年 代 支 持 了 那 些 臭 名 昭 著 的 分 裂 组 织 呢 ？ 你 不 能 只 在 别 的 国 家 的 自 由 战 士 “ 起 义 ” 的 时 候 才 支 持 自 由 战 士 们 ， 对 吧 ， 先 生 们 ？";
					}
					else if (!flag && !flag2 && !flag3 && GlobalScript.inst.gameState.completedDecisions[9])
					{
						fake_text += "苏 联 的 再 革 命 使 得 我 们 深 化 中 苏 友 谊 成 为 可 能 ： 该 国 不 久 后 便 以 “ 解 决 历 史 遗 留 问 题 ” 为 由 向 我 们 开 放 了 海 参 崴 港 区 ， 并 邀 请 我 们 参 与 西 伯 利 亚 铁 路 升 级 计 划 。 这 只 会 对 两 国 人 民 有 好 处 ！ 除 此 之 外 ， 中 亚 与 远 东 地 区 一 切 如 常 ， 苏 联 政 府 对 当 地 的 控 制 一 如 既 往 地 牢 靠 。 外 东 北 与 外 西 北 仍 只 能 作 为 民 族 主 义 者 口 中 的 “ 历 史 名 词 ” 存 在 — — 并 将 随 两 国 彻 底 解 决 东 西 边 界 勘 探 的 历 史 遗 留 问 题 而 画 上 圆 满 句 号 。";
					}
					else if (GlobalScript.inst.gameState.relres && (GlobalScript.inst.gameState.empires[1].now_leader != 6 || GlobalScript.inst.gameState.allcountries[7].SubGosstroy == 15))
					{
						fake_text += "中 亚 与 远 东 地 区 一 切 如 常 ， 苏 联 政 府 对 当 地 的 控 制 一 如 既 往 地 牢 靠 。 外 东 北 与 外 西 北 仍 只 能 作 为 民 族 主 义 者 口 中 的 “ 历 史 名 词 ” 存 在 — — 并 将 随 两 国 彻 底 解 决 东 西 边 界 勘 探 的 历 史 遗 留 问 题 而 画 上 圆 满 句 号 。";
					}
					else if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.empires[1].now_leader == 6)
					{
						fake_text += "苏 联 解 体 使 得 原 本 的 边 界 谈 判 也 改 成 了 “ 五 国 两 方 ” 的 新 模 式 继 续 进 行 ， 中 亚 国 家 政 府 与 俄 罗 斯 当 局 对 当 地 的 控 制 一 如 既 往 地 牢 靠 。 外 东 北 与 外 西 北 仍 只 能 作 为 民 族 主 义 者 口 中 的 “ 历 史 名 词 ” 存 在 — — 并 将 随 两 国 彻 底 解 决 东 西 边 界 勘 探 的 历 史 遗 留 问 题 而 画 上 圆 满 句 号 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
					{
						fake_text += "苏 联 解 体 使 得 原 本 的 边 界 谈 判 也 改 成 了 “ 五 国 两 方 ” 的 新 模 式 继 续 进 行 ， 中 亚 国 家 政 府 与 俄 罗 斯 当 局 对 当 地 的 控 制 一 如 既 往 地 牢 靠 。 外 东 北 与 外 西 北 仍 只 能 作 为 民 族 主 义 者 口 中 的 “ 历 史 名 词 ” 存 在 — — 多 方 热 心 的 边 界 谈 判 也 只 限 于 勘 定 国 界 ， 而 非 某 种 领 土 要 求 。";
					}
					else
					{
						fake_text += "中 亚 与 远 东 地 区 一 切 如 常 ， 苏 联 政 府 对 当 地 的 控 制 一 如 既 往 地 牢 靠 。 外 东 北 与 外 西 北 仍 只 能 作 为 民 族 主 义 者 口 中 的 “ 历 史 名 词 ” 存 在 — — 多 方 热 心 的 边 界 谈 判 也 只 限 于 勘 定 国 界 ， 而 非 某 种 领 土 要 求 。";
					}
					fake_text += "||";
					if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 17 && GlobalScript.inst.gameState.data[31] >= 400 && GlobalScript.inst.gameState.IsSocialism(yes: true, 1))
					{
						fake_text += "随 着 我 国 西 南 局 势 迎 来 新 篇 章 ， 进 行 了 社 会 主 义 革 命 后 的 缅 方 决 定 基 于 社 会 主 义 下 民 族 自 决 的 原 则 重 划 中 缅 边 界 ， 并 尤 其 关 注 跨 境 民 族 问 题 。 最 终 ， 中 缅 决 定 推 进 西 南 地 区 边 界 共 管 ， 并 就 改 善 横 断 山 区 交 通 物 流 问 题 达 成 协 定 。 云 南 的 跨 境 华 人 也 得 以 回 归 祖 国 并 实 现 统 一 ， 原 果 敢 地 区 改 为 云 南 省 下 辖 的 老 街 民 族 自 治 州 ， 并 在 社 会 主 义 之 光 下 平 等 对 待 傣 族 ， 缅 族 ， 崩 龙 族 ， 苗 族 ， 佤 族 ， 傈 僳 族 和 龙 的 传 人 们 。|缅 甸 的 政 局 更 替 使 我 们 修 订 《 中 华 人 民 共 和 国 和 缅 甸 联 邦 边 界 条 约 》 成 为 可 能 。 中 国 最 终 得 以 将 原 果 敢 土 司 领 首 次 纳 入 北 京 当 局 的 直 接 过 问 。 然 而 ， 为 中 华 民 族 内 新 增 “ 插 件 ” 这 件 事 并 非 一 日 之 功 ： 民 族 学 家 与 当 地 人 民 已 就 果 敢 人 究 竟 该 划 归 汉 族 民 系 、 独 立 民 族 、 还 是 待 识 别 民 族 而 争 论 不 休 。 而 果 敢 地 区 的 特 别 风 俗 与 生 活 方 式 也 造 就 了 管 理 “ 两 类 华 人 ” 的 问 题 ： 云 南 当 局 对 这 些 天 性 冲 动 ， 热 血 ， 狡 黠 ， 不 择 手 段 的 “ 红 白 混 血 ” 大 感 头 痛 ， 并 自 然 而 然 地 拴 紧 螺 丝 。 至 少 在 当 地 局 势 彻 底 稳 定 前 ， 我 们 仍 将 见 识 到 无 形 的 民 族 壁 垒 发 挥 作 用 。|与 此 同 时 ， 我 们 解 决 了 民 国 时 期 遗 留 的 若 干 历 史 问 题 ， 并 彻 底 终 结 了 非 法 的 麦 克 马 洪 线 ： 该 边 界 的 缅 甸 段 领 土 江 心 坡 ， 以 及 佧 佤 山 区 也 已 回 归 中 国 ， 历 史 正 义 业 已 恢 复 。 不 过 ， 真 正 的 问 题 还 在 后 头 ： 虽 然 阿 佤 人 能 够 同 意 加 入 前 国 境 对 面 的 民 族 自 治 州 ， 但 在 江 心 坡 对 当 地 主 要 人 口 克 钦 人 的 定 性 很 快 便 成 为 了 一 个 关 键 问 题 ， 克 钦 人 与 民 族 学 家 已 就 其 究 竟 该 同 景 颇 族 合 并 、 还 是 列 为 独 立 民 族 、 又 或 是 纳 入 待 识 别 民 族 而 争 论 不 休 — — 这 将 决 定 当 地 究 竟 是 以 省 属 自 治 州 ， 还 是 以 省 级 民 族 自 治 区 的 形 式 存 在 ； 以 及 更 关 键 的 人 大 民 族 地 区 代 表 配 额 。 可 不 管 如 何 ， 至 少 我 们 还 是 以 建 立 了 民 族 权 利 机 构 的 方 式 达 成 了 初 步 妥 协 ， 并 由 此 在 世 界 屋 脊 的 南 部 插 上 了 自 己 的 旗 帜 。 ";
					}
					else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 11)
					{
						fake_text += "在 缅 甸 最 近 举 行 的 区 域 选 举 中 ， 缅 方 采 取 的 “ 拿 走 多 少 主 权 都 可 以 ” 政 策 导 致 了 历 史 话 题 的 重 提 。 克 钦 邦 与 掸 邦 的 地 区 政 府 为 了 获 取 慷 慨 的 基 础 建 设 投 资 决 定 实 行 边 境 共 管 的 基 础 上 进 行 新 一 轮 的 领 土 修 订 。|缅 甸 的 政 局 更 替 使 我 们 修 订 《 中 华 人 民 共 和 国 和 缅 甸 联 邦 边 界 条 约 》 成 为 可 能 。 中 国 最 终 得 以 将 原 果 敢 土 司 领 首 次 纳 入 北 京 当 局 的 直 接 过 问 。 然 而 ， 为 中 华 民 族 内 新 增 “ 插 件 ” 这 件 事 并 非 一 日 之 功 ： 民 族 学 家 与 当 地 人 民 已 就 果 敢 人 究 竟 该 划 归 汉 族 民 系 、 独 立 民 族 、 还 是 待 识 别 民 族 而 争 论 不 休 。 而 果 敢 地 区 的 特 别 风 俗 与 生 活 方 式 也 造 就 了 管 理 “ 两 类 华 人 ” 的 问 题 ： 云 南 当 局 对 这 些 天 性 冲 动 ， 热 血 ， 狡 黠 ， 不 择 手 段 的 “ 红 白 混 血 ” 大 感 头 痛 ， 并 自 然 而 然 地 拴 紧 螺 丝 。 至 少 在 当 地 局 势 彻 底 稳 定 前 ， 我 们 仍 将 见 识 到 无 形 的 民 族 壁 垒 发 挥 作 用 。|与 此 同 时 ， 我 们 解 决 了 民 国 时 期 遗 留 的 若 干 历 史 问 题 ， 并 彻 底 终 结 了 非 法 的 麦 克 马 洪 线 ： 该 边 界 的 缅 甸 段 领 土 江 心 坡 ， 以 及 佧 佤 山 区 也 已 回 归 中 国 ， 历 史 正 义 业 已 恢 复 。 不 过 ， 真 正 的 问 题 还 在 后 头 ： 虽 然 阿 佤 人 能 够 同 意 加 入 前 国 境 对 面 的 民 族 自 治 州 ， 但 在 江 心 坡 对 当 地 主 要 人 口 克 钦 人 的 定 性 很 快 便 成 为 了 一 个 关 键 问 题 ， 克 钦 人 与 民 族 学 家 已 就 其 究 竟 该 同 景 颇 族 合 并 、 还 是 列 为 独 立 民 族 、 又 或 是 纳 入 待 识 别 民 族 而 争 论 不 休 — — 这 将 决 定 当 地 究 竟 是 以 省 属 自 治 州 ， 还 是 以 省 级 民 族 自 治 区 的 形 式 存 在 ； 以 及 更 关 键 的 人 大 民 族 地 区 代 表 配 额 。 可 不 管 如 何 ， 至 少 我 们 还 是 以 建 立 了 民 族 权 利 机 构 的 方 式 达 成 了 初 步 妥 协 ， 并 由 此 在 世 界 屋 脊 的 南 部 插 上 了 自 己 的 旗 帜 。 ";
					}
					else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 6 && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
					{
						fake_text += "民 地 武 带 来 的 自 由 化 导 致 了 缅 甸 边 境 地 区 的 民 意 彻 底 离 心 。 绰 号 “ 腊 戎 龙 ” 的 果 敢 民 主 党 与 密 支 那 华 人 协 会 等 组 织 在 选 举 内 赢 得 压 倒 性 的 地 区 性 选 举 胜 利 。 面 对 不 再 受 “ 共 产 主 义 ” 困 扰 的 汉 族 主 导 政 权 ， 新 的 亲 中 领 导 层 很 快 便 脱 离 了 摇 摇 欲 坠 ， 依 然 无 法 控 制 局 势 的 克 钦 邦 与 掸 邦 - 缅 方 戏 称 “ 拿 走 多 少 主 权 都 可 以 ” 并 发 起 回 归 公 投 。 果 敢 与 江 心 坡 就 此 回 到 了 中 华 母 亲 的 怀 抱 ！|缅 甸 的 政 局 更 替 使 我 们 修 订 《 中 华 人 民 共 和 国 和 缅 甸 联 邦 边 界 条 约 》 成 为 可 能 。 中 国 最 终 得 以 将 原 果 敢 土 司 领 首 次 纳 入 北 京 当 局 的 直 接 过 问 。 然 而 ， 为 中 华 民 族 内 新 增 “ 插 件 ” 这 件 事 并 非 一 日 之 功 ： 民 族 学 家 与 当 地 人 民 已 就 果 敢 人 究 竟 该 划 归 汉 族 民 系 、 独 立 民 族 、 还 是 待 识 别 民 族 而 争 论 不 休 。 而 果 敢 地 区 的 特 别 风 俗 与 生 活 方 式 也 造 就 了 管 理 “ 两 类 华 人 ” 的 问 题 ： 云 南 当 局 对 这 些 天 性 冲 动 ， 热 血 ， 狡 黠 ， 不 择 手 段 的 “ 红 白 混 血 ” 大 感 头 痛 ， 并 自 然 而 然 地 拴 紧 螺 丝 。 至 少 在 当 地 局 势 彻 底 稳 定 前 ， 我 们 仍 将 见 识 到 无 形 的 民 族 壁 垒 发 挥 作 用 。|与 此 同 时 ， 我 们 解 决 了 民 国 时 期 遗 留 的 若 干 历 史 问 题 ， 并 彻 底 终 结 了 非 法 的 麦 克 马 洪 线 ： 该 边 界 的 缅 甸 段 领 土 江 心 坡 ， 以 及 佧 佤 山 区 也 已 回 归 中 国 ， 历 史 正 义 业 已 恢 复 。 不 过 ， 真 正 的 问 题 还 在 后 头 ： 虽 然 阿 佤 人 能 够 同 意 加 入 前 国 境 对 面 的 民 族 自 治 州 ， 但 在 江 心 坡 对 当 地 主 要 人 口 克 钦 人 的 定 性 很 快 便 成 为 了 一 个 关 键 问 题 ， 克 钦 人 与 民 族 学 家 已 就 其 究 竟 该 同 景 颇 族 合 并 、 还 是 列 为 独 立 民 族 、 又 或 是 纳 入 待 识 别 民 族 而 争 论 不 休 — — 这 将 决 定 当 地 究 竟 是 以 省 属 自 治 州 ， 还 是 以 省 级 民 族 自 治 区 的 形 式 存 在 ； 以 及 更 关 键 的 人 大 民 族 地 区 代 表 配 额 。 可 不 管 如 何 ， 至 少 我 们 还 是 以 建 立 了 民 族 权 利 机 构 的 方 式 达 成 了 初 步 妥 协 ， 并 由 此 在 世 界 屋 脊 的 南 部 插 上 了 自 己 的 旗 帜 。 ";
					}
					else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 9)
					{
						if (GlobalScript.inst.gameState.allcountries[33].proprc)
						{
							if (GlobalScript.inst.gameState.data[15] >= 8)
							{
								fake_text += " 彭 家 声 精 心 设 计 了 让 缅 甸 部 分 领 土 回 归 中 国 的 公 投 ， 计 划 以 土 地 换 取 稳 定 的 中 缅 同 盟 关 系 。 最 终 ， 中 国 承 认 了 江 心 坡 和 南 坎 （ 7 6 . 4 % 的 人 口 要 求 回 归 ） 、 以 及 果 敢 （ 9 9 . 9 % 的 人 口 要 求 回 归 ） 的 公 投 结 果 并 采 纳 回 归 建 议 。 作 为 交 换 ， 缅 甸 民 族 正 义 党 的 支 部 “ 云 南 民 族 正 义 党 ” 将 按 照 革 命 制 度 党 模 式 “ 公 平 ” 地 参 与 每 一 场 选 举 。 它 在 中 国 的 两 处 新 自 治 区 内 获 得 了 事 实 上 的 国 中 之 国 待 遇 。|缅 甸 的 政 局 更 替 使 我 们 修 订 《 中 华 人 民 共 和 国 和 缅 甸 联 邦 边 界 条 约 》 成 为 可 能 。 中 国 最 终 得 以 将 原 果 敢 土 司 领 首 次 纳 入 北 京 当 局 的 直 接 过 问 。 然 而 ， 为 中 华 民 族 内 新 增 “ 插 件 ” 这 件 事 并 非 一 日 之 功 ： 民 族 学 家 与 当 地 人 民 已 就 果 敢 人 究 竟 该 划 归 汉 族 民 系 、 独 立 民 族 、 还 是 待 识 别 民 族 而 争 论 不 休 。 而 果 敢 地 区 的 特 别 风 俗 与 生 活 方 式 也 造 就 了 管 理 “ 两 类 华 人 ” 的 问 题 ： 云 南 当 局 对 这 些 天 性 冲 动 ， 热 血 ， 狡 黠 ， 不 择 手 段 的 “ 红 白 混 血 ” 大 感 头 痛 ， 并 自 然 而 然 地 拴 紧 螺 丝 。 至 少 在 当 地 局 势 彻 底 稳 定 前 ， 我 们 仍 将 见 识 到 无 形 的 民 族 壁 垒 发 挥 作 用 。|与 此 同 时 ， 我 们 解 决 了 民 国 时 期 遗 留 的 若 干 历 史 问 题 ， 并 彻 底 终 结 了 非 法 的 麦 克 马 洪 线 ： 该 边 界 的 缅 甸 段 领 土 江 心 坡 ， 以 及 佧 佤 山 区 也 已 回 归 中 国 ， 历 史 正 义 业 已 恢 复 。 不 过 ， 真 正 的 问 题 还 在 后 头 ： 虽 然 阿 佤 人 能 够 同 意 加 入 前 国 境 对 面 的 民 族 自 治 州 ， 但 在 江 心 坡 对 当 地 主 要 人 口 克 钦 人 的 定 性 很 快 便 成 为 了 一 个 关 键 问 题 ， 克 钦 人 与 民 族 学 家 已 就 其 究 竟 该 同 景 颇 族 合 并 、 还 是 列 为 独 立 民 族 、 又 或 是 纳 入 待 识 别 民 族 而 争 论 不 休 — — 这 将 决 定 当 地 究 竟 是 以 省 属 自 治 州 ， 还 是 以 省 级 民 族 自 治 区 的 形 式 存 在 ； 以 及 更 关 键 的 人 大 民 族 地 区 代 表 配 额 。 可 不 管 如 何 ， 至 少 我 们 还 是 以 建 立 了 民 族 权 利 机 构 的 方 式 达 成 了 初 步 妥 协 ， 并 由 此 在 世 界 屋 脊 的 南 部 插 上 了 自 己 的 旗 帜 。 ";
							}
							else if (GlobalScript.inst.gameState.data[15] == 7 && GlobalScript.inst.gameState.data[16] > 11)
							{
								fake_text += " 彭 家 声 精 心 设 计 了 让 缅 甸 部 分 领 土 回 归 中 国 的 公 投 ， 计 划 以 土 地 换 取 稳 定 的 中 缅 同 盟 关 系 。 最 终 ， 中 国 承 认 了 江 心 坡 和 南 坎 （ 7 6 . 4 % 的 人 口 要 求 回 归 ） 、 以 及 果 敢 （ 9 9 . 9 % 的 人 口 要 求 回 归 ） 的 公 投 结 果 并 采 纳 回 归 建 议 。 作 为 交 换 ， 缅 甸 民 族 正 义 党 的 支 部 “ 云 南 民 族 正 义 党 ” 将 参 与 政 协 ， 并 在 自 治 区 内 获 得 了 “ 唯 一 执 政 党 ” 的 法 律 地 位 ， 以 及 随 时 退 出 中 华 人 民 共 和 国 的 “ 区 域 自 决 权 ” 。 它 在 中 国 的 两 处 新 自 治 区 内 获 得 了 事 实 上 的 国 中 之 国 待 遇 。|缅 甸 的 政 局 更 替 使 我 们 修 订 《 中 华 人 民 共 和 国 和 缅 甸 联 邦 边 界 条 约 》 成 为 可 能 。 中 国 最 终 得 以 将 原 果 敢 土 司 领 首 次 纳 入 北 京 当 局 的 直 接 过 问 。 然 而 ， 为 中 华 民 族 内 新 增 “ 插 件 ” 这 件 事 并 非 一 日 之 功 ： 民 族 学 家 与 当 地 人 民 已 就 果 敢 人 究 竟 该 划 归 汉 族 民 系 、 独 立 民 族 、 还 是 待 识 别 民 族 而 争 论 不 休 。 而 果 敢 地 区 的 特 别 风 俗 与 生 活 方 式 也 造 就 了 管 理 “ 两 类 华 人 ” 的 问 题 ： 云 南 当 局 对 这 些 天 性 冲 动 ， 热 血 ， 狡 黠 ， 不 择 手 段 的 “ 红 白 混 血 ” 大 感 头 痛 ， 并 自 然 而 然 地 拴 紧 螺 丝 。 至 少 在 当 地 局 势 彻 底 稳 定 前 ， 我 们 仍 将 见 识 到 无 形 的 民 族 壁 垒 发 挥 作 用 。|与 此 同 时 ， 我 们 解 决 了 民 国 时 期 遗 留 的 若 干 历 史 问 题 ， 并 彻 底 终 结 了 非 法 的 麦 克 马 洪 线 ： 该 边 界 的 缅 甸 段 领 土 江 心 坡 ， 以 及 佧 佤 山 区 也 已 回 归 中 国 ， 历 史 正 义 业 已 恢 复 。 不 过 ， 真 正 的 问 题 还 在 后 头 ： 虽 然 阿 佤 人 能 够 同 意 加 入 前 国 境 对 面 的 民 族 自 治 州 ， 但 在 江 心 坡 对 当 地 主 要 人 口 克 钦 人 的 定 性 很 快 便 成 为 了 一 个 关 键 问 题 ， 克 钦 人 与 民 族 学 家 已 就 其 究 竟 该 同 景 颇 族 合 并 、 还 是 列 为 独 立 民 族 、 又 或 是 纳 入 待 识 别 民 族 而 争 论 不 休 — — 这 将 决 定 当 地 究 竟 是 以 省 属 自 治 州 ， 还 是 以 省 级 民 族 自 治 区 的 形 式 存 在 ； 以 及 更 关 键 的 人 大 民 族 地 区 代 表 配 额 。 可 不 管 如 何 ， 至 少 我 们 还 是 以 建 立 了 民 族 权 利 机 构 的 方 式 达 成 了 初 步 妥 协 ， 并 由 此 在 世 界 屋 脊 的 南 部 插 上 了 自 己 的 旗 帜 。 ";
							}
							else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9)
							{
								fake_text += " 彭 家 声 精 心 设 计 了 让 缅 甸 部 分 领 土 回 归 中 国 的 公 投 ， 计 划 以 土 地 换 取 稳 定 的 中 缅 同 盟 关 系 。 而 中 国 直 爽 地 承 认 了 江 心 坡 和 南 坎 （ 7 6 . 4 % 的 人 口 要 求 回 归 ） 、 以 及 果 敢 （ 9 9 . 9 % 的 人 口 要 求 回 归 ） 的 公 投 结 果 并 采 纳 回 归 建 议 ； 然 而 ， 这 位 骑 乘 华 夏 民 族 主 义 的 土 皇 帝 很 快 就 发 现 了 自 主 权 不 属 于 自 己 ： 随 后 ， C N 缅 甸 签 署 了 一 系 列 “ 租 借 地 协 定 ” ： 该 国 的 主 要 港 口 与 城 市 将 以 “ 过 分 优 惠 ” 的 价 格 交 予 中 国 代 管 9 9 年 ， 且 中 方 更 是 拥 有 续 约 无 限 期 延 长 协 定 的 权 力 。 某 种 意 义 上 对 于 缅 甸 整 合 成 为 命 运 由 主 子 决 定 的 “ 捷 克 斯 洛 伐 克 第 二 共 和 国 ” 的 命 运 似 乎 也 在 天 边 逐 渐 靠 近 … 看 起 来 华 夏 帝 国 主 义 已 初 露 锋 芒 ， 正 咆 哮 着 宣 誓 自 己 对 亚 洲 各 地 的 主 权 — — 下 一 步 或 许 是 登 上 世 界 舞 台 中 央 … …";
							}
							else
							{
								fake_text += " 金 三 角 之 地 依 然 是 金 三 角 … …";
							}
						}
						else
						{
							fake_text += " 金 三 角 之 地 依 然 是 金 三 角 … …";
						}
					}
					else
					{
						fake_text += " 金 三 角 之 地 依 然 是 金 三 角 … …";
					}
				}
			}
			else if (number_of_e == 4)
			{
				name.text = " 苏 联 的 命 运";
				if (GlobalScript.inst.gameState.IndOpp)
				{
					fake_text = " 破 碎 的 联 盟|由 于 对 华 作 战 的 耻 辱 性 大 败 ， 布 尔 什 维 克 失 去 了 所 有 威 望 ， 整 个 政 权 陷 入 了 崩 溃 的 边 缘 。 战 败 的 阴 云 挥 散 不 去 ， 最 终 导 致 军 队 中 的 强 硬 派 联 合 东 正 教 会 、 民 布 主 义 者 和 白 俄 余 孽 等 势 力 ， 发 动 了 军 事 政 变 。 苏 联 ， 那 个 曾 经 横 扫 世 界 舞 台 的 巨 人 ， 瞬 间 化 作 了 名 存 实 亡 的 空 壳 。 虽 然 击 败 了 苏 共 ， 然 而 这 个 大 帐 篷 毕 竟 只 是 一 个 松 散 的 反 苏 大 联 盟 ， 内 部 分 歧 深 重 ， 难 以 维 系 统 一 。 随 着 苏 共 的 垮 台 ， 权 力 斗 争 迅 速 升 温 ， 矛 盾 逐 渐 激 化 ， 最 终 转 化 为 一 场 惨 烈 的 内 战 。 各 方 势 力 在 这 个 破 碎 的 土 地 上 争 夺 地 盘 与 资 源 ， 仿 佛 整 片 地 区 都 被 无 情 的 风 暴 吞 噬 。|在 这 场 内 战 的 废 墟 中 ， 中 国 和 美 国 作 为 旁 观 者 ， 迅 速 展 开 了 战 略 博 弈 ， 除 了 俄 罗 斯 、 乌 克 兰 和 白 俄 罗 斯 这 三 国 仍 保 持 名 义 上 的 独 立 以 外 ， 其 余 的 国 家 纷 纷 转 投 了 中 美 两 国 的 怀 抱 。 东 斯 拉 夫 三 国 成 为 了 各 类 极 端 意 识 形 态 的 试 验 场 ， 各 种 势 力 你 方 唱 罢 我 登 场 ， 仿 佛 世 界 末 日 般 的 混 乱 场 景 上 演 着 一 场 又 一 场 不 见 终 点 的 政 治 实 验 。 与 此 同 时 ， 这 些 剧 变 带 来 了 深 重 的 民 众 苦 难 ， 人 口 锐 减 ， 大 量 群 众 成 为 无 国 籍 的 难 民 ， 四 散 流 亡 到 世 界 的 角 落 。|曾 经 那 句 “ 自 由 结 合 成 我 们 牢 固 的 联 盟 ， 伟 大 的 民 族 团 结 直 到 永 恒 ” 如 今 已 经 成 为 了 历 史 的 尘 埃 ， 成 为 了 一 个 遥 不 可 及 的 梦 。 大 地 上 ， 回 荡 的 唯 有 绝 望 与 疲 惫 ， 曾 经 的 理 想 早 已 随 着 时 代 的 脚 步 渐 行 渐 远 ， 仿 佛 再 也 找 不 到 归 宿 。";
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 3)
				{
					fake_text = " 谢 尔 比 茨 基|| 弗 拉 基 米 尔 · 谢 尔 比 茨 基 取 代 勃 列 日 涅 夫 ， 以 对 政 治 局 进 行 清 洗 拉 开 了 他 执 政 时 期 的 序 幕 ， 接 着 他 把 他 在 乌 克 兰 的 人 马 安 排 上 清 洗 后 造 成 的 空 位 ， 动 摇 了 腐 化 的 勃 列 日 涅 夫 帮 ， 并 且 破 坏 了 其 成 员 间 的 腐 败 联 系 ， 以 此 打 击 了 腐 败 。 再 加 上 这 位 资 深 管 理 者 的 行 政 天 赋 ， 苏 联 经 济 和 人 民 福 利 稳 定 的 增 长 着 。 谢 尔 比 茨 基 的 外 交 和 国 内 政 策 与 勃 列 日 涅 夫 没 有 太 大 不 同 — — 经 互 会 国 家 的 经 济 一 体 化 增 强 了 ， 这 对 整 个 联 盟 产 生 了 积 极 影 响 ， 中 苏 关 系 的 缓 和 也 开 始 了 ， 他 谨 慎 而 缓 慢 地 尝 试 自 动 化 计 划 ， 但 大 体 上 一 切 都 是 稳 定 的 。 苏 联 屹 立 着 ， 并 将 屹 立 很 长 时 间 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(48);
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 5)
				{
					fake_text = " 格 里 申|| 最 终 ， 旧 领 导 人 被 资 深 有 经 验 的 维 克 托 · 格 里 申 取 代 ， 他 是 保 守 派 圈 子 里 的 红 人 。 对 于 苏 联 来 说 ， 没 有 什 么 太 大 的 变 化 — — 相 对 稳 定 的 经 济 增 长 允 许 每 一 年 在 粮 食 和 社 会 开 支 上 花 费 更 多 资 金 ， 对 自 动 化 计 划 的 尝 试 非 常 谨 慎 且 拖 沓 ， 并 遭 到 党 和 政 府 的 压 制 ， 外 交 政 策 被 形 容 为 “ 勃 列 日 涅 夫 主 义 ” 的 延 续 ， 但 强 调 和 中 国 改 善 关 系 … 然 而 格 里 申 政 府 意 味 着 党 的 最 终 僵 化 ， 猖 獗 的 裙 带 关 系 ， 腐 败 和 计 划 中 的 伪 造 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(37);
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
				{
					if (GlobalScript.inst.gameState.completedDecisions[9] && GlobalScript.inst.gameState.empires[1].now_leader == 6 && (GlobalScript.inst.gameState.empires[1].power <= GlobalScript.inst.gameState.empires[0].power || GlobalScript.inst.gameState.empires[1].power <= GlobalScript.inst.gameState.influencePRC))
					{
						if ((!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[14] < 3 && GlobalScript.inst.gameState.data[16] < 12) || (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 13 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 10 || GlobalScript.inst.gameState.data[14] < 4) && GlobalScript.inst.gameState.data[16] < 14) || GlobalScript.inst.gameState.allcountries[51].Torg || (!GlobalScript.inst.gameState.modifies[3].active && !GlobalScript.inst.gameState.modifies[6].active) || GlobalScript.inst.gameState.data[14] > 3 || GlobalScript.inst.gameState.data[16] > 13 || GlobalScript.inst.gameState.data[15] > 7 || GlobalScript.inst.gameState.data[50] > 27 || GlobalScript.inst.gameState.allcountries[51].dev == 1)
						{
							fake_text = " 戈 尔 巴 乔 夫| 最 终 ， 旧 领 导 人 被 年 轻 有 希 望 的 米 哈 伊 尔 · 戈 尔 巴 乔 夫 取 代 ， 他 是 安 德 罗 波 夫 改 革 派 圈 子 中 的 一 员 。 但 是 戈 尔 巴 乔 夫 的 改 革 尝 试 没 有 一 个 得 以 善 终 的 — — 反 酗 酒 运 动 导 致 农 业 衰 落 和 假 酒 的 大 规 模 流 通 ， 加 速 发 展 战 略 — — 导 致 了 资 金 被 白 白 浪 费 和 工 业 衰 落 ， 开 放 — — 导 致 民 族 主 义 势 力 的 增 长 和 反 苏 谎 言 的 兴 盛 。 尝 试 调 整 国 家 在 经 济 中 扮 演 的 角 色 ， 无 能 且 不 受 控 制 的 引 入 合 作 社 体 制 ， 向 地 方 分 权 ， 摧 毁 计 划 经 济 机 制 导 致 大 量 外 债 ， 经 济 崩 溃 ， 赤 字 和 人 民 赤 贫 。 外 交 政 策 被 形 容 为 向 美 国 卑 躬 屈 膝 ， 抛 弃 社 会 主 义 取 得 的 成 就 ， 最 终 在 华 约 和 经 互 会 的 解 散 中 达 到 顶 峰 。 苏 联 自 身 也 没 有 在 此 事 后 存 在 太 久 — — 戈 尔 巴 乔 夫 的 政 策 下 滋 生 的 自 由 主 义 者 和 民 族 主 义 者 赢 得 了 人 民 的 支 持 ， 在1991 年 末 宣 布 了 苏 联 的 解 体 ， 实 际 上 夺 走 了 未 竟 的 改 革 者 的 权 力 。";
						}
						else
						{
							fake_text = " 甚 荒 唐 ， 到 头 来 都 是 为 他 人 作 嫁 衣 裳 ！ | 最 终 ， 来 自 安 德 罗 波 夫 改 革 派 圈 子 的 新 人 ， 年 富 力 强 的 米 哈 伊 尔 · 戈 尔 巴 乔 夫 从 苏 联 建 制 派 手 中 接 手 了 国 家 大 权 ， 并 以 “ 回 归 列 宁 主 义 ” 的 名 义 实 施 改 革 。 然 而 ， 戈 尔 巴 乔 夫 旨 在 重 振 人 民 对 苏 维 埃 制 度 自 信 的 改 革 尝 试 没 有 一 个 得 以 善 终 — — 旨 在 整 顿 劳 动 纪 律 的 反 酗 酒 运 动 摧 毁 了 联 盟 境 内 本 就 脆 弱 的 农 业 生 产 ， 并 为 黑 手 党 、 地 下 交 易 与 走 私 等 诸 多 非 法 勾 当 发 展 提 供 了 便 利 ； 试 图 以 制 造 业 为 导 向 全 面 振 兴 国 内 产 业 的 “ 加 速 发 展 战 略 ” 则 和 其 他 发 展 中 国 家 制 定 的 类 似 战 略 一 样 走 到 了 死 路 ： 资 金 浪 费 、 产 业 结 构 失 衡 、 交 易 过 程 中 的 腐 败 与 外 债 膨 胀 最 终 拖 垮 了 工 业 领 域 ； 经 济 管 理 层 面 的 失 败 更 促 使 戈 尔 巴 乔 夫 押 注 全 面 的 政 治 洗 牌 ： 对 党 政 机 关 的 数 次 清 洗 最 终 只 是 塞 入 了 缺 乏 经 验 与 管 理 能 力 的 嫩 头 青 ， 并 倒 逼 保 守 派 党 员 们 向 强 硬 派 社 会 主 义 思 潮 倒 戈 ； 试 图 澄 清 政 治 环 境 的 “ 开 放 政 策 ” 直 接 导 致 反 苏 谎 言 兴 盛 与 曾 被 视 为 “ 反 苏 言 论 ” 的 各 种 思 潮 得 以 实 现 最 终 平 反 ， 为 早 在 苏 联 周 围 站 稳 脚 跟 的 反 修 正 主 义 意 识 形 态 进 军 境 内 提 供 了 不 少 便 利 。 为 筹 集 资 金 与 激 活 地 方 活 力 所 引 入 的 合 作 社 体 制 与 分 权 改 革 更 是 在 该 国 建 立 了 奇 美 拉 式 的 经 济 状 态 ， 同 时 综 合 了 市 场 经 济 欠 调 控 与 计 划 经 济 缺 乏 灵 活 性 的 弊 端 ： 于 是 赤 字 、 物 资 短 缺 、 经 济 崩 溃 、 巨 额 外 债 与 人 民 赤 贫 构 成 了 戈 尔 巴 乔 夫 执 政 后 期 的 主 旋 律 。 试 图 在 外 交 上 开 辟 新 战 线 的 做 法 可 被 视 为 完 全 倒 向 大 西 洋 主 义 立 场 ， 并 最 终 导 致 该 国 向 美 国 卑 躬 屈 膝 ， 抛 弃 社 会 主 义 取 得 的 成 就 。 然 而 ， 试 图 深 化 所 谓 和 平 共 处 ， 并 将 社 会 主 义 体 系 作 为 议 价 筹 码 的 闹 剧 在 东 欧 诸 国 与 中 国 的 强 势 的 干 预 下 被 打 上 了 终 止 符 。 而 苏 联 自 身 的 “ 伟 大 改 革 ” 也 并 未 在 此 之 后 持 续 多 久 — — 反 修 正 主 义 者 们 连 同 中 国 主 导 的 毛 主 义 派 系 成 功 在 戈 尔 巴 乔 夫 的 政 策 下 抢 下 了 最 大 的 一 块 蛋 糕 ， 并 最 终 成 为 反 苏 异 见 分 子 的 主 流 。 也 就 在 1 9 9 1 年 的 晚 上 ， 他 们 连 同 海 外 盟 友 们 发 起 了 场 彻 底 终 结 “ 改 革 与 新 思 维 ” 的 内 战 。 克 里 姆 林 宫 的 主 人 便 就 此 耻 辱 下 台 ， 沦 为 历 史 笑 柄 … …";
						}
					}
					else if (!GlobalScript.inst.gameState.completedDecisions[9] && GlobalScript.inst.gameState.allcountries[7].SubGosstroy == 15)
					{
						fake_text = " 沃 罗 特 尼 科 夫 - 东 欧 版 法 兰 西 联 邦 | 戈 尔 巴 乔 夫 集 团 与 北 京 阴 谋 家 的 合 谋 最 终 被 证 明 是 饮 鸩 止 渴 ： 虽 然 早 期 开 展 的 一 次 性 清 党 切 实 为 “ 新 思 维 改 革 ” 开 出 了 坦 途 ， 并 以 改 革 派 党 阀 、 技 术 官 僚 与 强 力 机 关 三 足 鼎 立 的 架 构 取 而 代 之 。 可 随 局 势 演 变 ， 力 求 为 改 革 派 党 阀 争 得 政 治 资 本 与 国 内 主 导 权 的 “ 重 组 改 革 ” 本 身 却 成 为 了 其 最 大 的 负 资 产 ： 赋 权 最 高 苏 维 埃 与 加 塞 异 见 人 士 的 举 措 虽 稀 释 了 苏 共 保 守 派 ， 但 同 时 也 创 造 了 难 以 制 约 ， 与 地 方 强 势 团 伙 密 切 挂 钩 的 反 对 派 势 力 ； 后 者 则 是 社 会 舆 论 、 管 控 松 绑 与 深 化 工 厂 自 治 制 度 改 革 实 践 中 的 最 大 赢 家 ： 旨 在 激 活 生 产 集 体 积 极 性 的 政 策 没 能 培 育 起 繁 荣 的 中 小 企 业 ， 反 而 为 各 类 党 外 社 会 团 体 、 工 农 会 组 织 代 表 与 扮 演 保 民 官 的 厂 长 、 董 事 等 强 势 集 团 的 崛 起 开 路 ； 他 们 一 面 积 极 填 补 苏 共 自 我 清 洗 与 战 略 退 却 后 留 下 的 空 缺 ， 一 面 以 中 苏 经 济 合 作 合 同 为 掩 护 ， 同 北 京 赞 助 人 与 管 控 海 关 的 克 格 勃 强 力 机 关 负 责 人 达 成 更 进 一 步 的 合 作 协 定 ： 其 中 不 乏 在 危 机 时 期 踢 开 戈 尔 巴 乔 夫 集 团 单 干 ， 引 入 社 会 法 团 主 义 与 强 力 管 制 的 相 关 计 划 。||所 有 的 一 切 都 随 着 8 0 年 代 末 经 济 停 滞 、 腐 败 问 题 恶 化 导 致 的 技 术 官 僚 边 缘 化 ， 9 0 年 代 初 戈 尔 巴 乔 夫 遇 刺 与 苏 共 党 组 织 的 愈 加 萎 靡 等 事 件 而 来 到 高 潮 。 短 命 的 “ 改 革 重 组 ” 就 这 样 草 草 结 束 ： 各 方 均 认 可 的 妥 协 候 选 ， 出 身 温 和 改 革 派 的 俄 罗 斯 联 邦 领 导 人 维 塔 利 · 沃 罗 特 尼 科 夫 力 克 声 名 狼 藉 的 党 内 自 由 派 雅 科 夫 列 夫 与 技 术 官 僚 雷 日 科 夫 ， 完 成 了 对 苏 共 党 内 激 进 改 革 倾 向 的 清 算 ； 社 会 爱 国 主 义 派 别 “ 联 盟 ” 也 同 时 在 苏 联 人 民 代 表 会 议 取 得 大 胜 ， 与 大 多 数 具 有 克 格 勃 线 人 合 作 背 景 的 社 会 团 体 代 表 们 共 同 瓜 分 了 该 国 议 会 。 苏 联 就 此 进 入 了 发 展 所 谓 “ 主 权 民 主 ” 的 新 阶 段 ： 国 家 以 废 除 外 贸 垄 断 ， 广 泛 赋 权 中 小 企 业 ， 鼓 励 私 营 农 场 与 合 作 社 经 营 形 式 ， 乃 至 默 许 企 业 与 社 会 团 体 在 整 顿 劳 动 纪 律 的 背 景 下 组 建 类 战 斗 团 组 织 （ 当 然 ， 绝 大 多 数 的 组 织 不 过 是 克 格 勃 支 部 换 皮 上 市 ） 等 去 管 制 经 济 改 革 回 馈 其 社 会 法 团 盟 友 ； 在 政 治 上 则 仰 仗 克 格 勃 与 经 济 单 位 联 合 组 成 的 “ 强 力 集 团 ” 框 架 ， 并 配 合 雅 科 夫 列 夫 改 革 草 案 打 开 的 强 力 总 统 制 魔 盒 （ 总 统 职 权 不 过 是 总 书 记 职 责 的 转 写 ） 进 行 建 构 。 形 成 了 一 面 牢 牢 控 制 政 府 主 要 部 门 并 组 织 亲 建 制 社 会 团 体 ， 建 立 以 总 统 为 核 心 的 卡 里 斯 玛 体 系 ； 一 面 则 积 极 干 预 选 举 、 管 制 舆 论 并 收 编 各 类 候 选 人 ， 将 议 会 变 得 越 来 越 宛 如 民 主 制 橡 皮 图 章 的 管 制 政 权 。 分 析 人 士 称 ， 目 前 的 苏 联 则 类 似 混 合 戴 高 乐 时 代 体 制 的 法 兰 西 共 和 国 ： 人 民 一 词 在 政 治 实 践 中 毫 无 意 义 ； 该 国 实 际 上 由 总 统 、 建 制 派 与 社 会 利 益 团 体 通 过 垄 断 各 类 政 治 资 源 代 表 民 意 ， 并 依 托 披 着 共 产 主 义 外 衣 的 大 国 情 节 政 治 宣 传 实 现 政 治 野 心 ， 从 而 坚 决 实 行 家 长 制 保 守 主 义 与 国 家 资 本 主 义 政 策 。 其 外 交 政 策 也 可 被 概 括 为 在 苏 维 埃 爱 国 主 义 基 础 上 实 现 利 益 最 大 化 — — 诚 然 ， 考 虑 到 目 前 的 经 济 政 治 关 系 ， 新 生 的 苏 联 目 前 自 然 是 其 最 大 合 作 伙 伴 中 国 的 铁 杆 盟 友 ： 事 实 上 加 入 中 国 的 经 济 - 军 事 合 作 计 划 的 欧 亚 大 国 正 扮 演 中 国 看 管 欧 洲 、 制 衡 美 国 的 前 哨 。 可 新 一 代 欧 洲 宪 兵 会 就 此 收 手 吗 ？ … …";
					}
					else if (!GlobalScript.inst.gameState.allcountries[51].isNATO)
					{
						if (GlobalScript.inst.gameState.allcountries[21].isSocEU)
						{
							if (GlobalScript.inst.gameState.empires[1].leaders[6].support >= 10)
							{
								fake_text = "戈 尔 巴 乔 夫 - 共 轭 父 子 | 最 终 ， 来 自 安 德 罗 波 夫 改 革 派 圈 子 的 新 人 ， 年 富 力 强 的 米 哈 伊 尔 · 戈 尔 巴 乔 夫 从 苏 联 建 制 派 手 中 接 手 了 国 家 大 权 ， 并 以 “ 回 归 列 宁 主 义 ” 的 名 义 实 施 改 革 。 然 而 ， 戈 尔 巴 乔 夫 旨 在 重 振 人 民 对 苏 维 埃 制 度 自 信 的 改 革 尝 试 没 有 一 个 得 以 善 终 — — 旨 在 整 顿 劳 动 纪 律 的 反 酗 酒 运 动 摧 毁 了 联 盟 境 内 本 就 脆 弱 的 农 业 生 产 ， 并 为 黑 手 党 、 地 下 交 易 与 走 私 等 诸 多 非 法 勾 当 发 展 提 供 了 便 利 ； 试 图 以 制 造 业 为 导 向 全 面 振 兴 国 内 产 业 的 “ 加 速 发 展 战 略 ” 则 和 其 他 发 展 中 国 家 制 定 的 类 似 战 略 一 样 走 到 了 死 路 ： 资 金 浪 费 、 产 业 结 构 失 衡 、 交 易 过 程 中 的 腐 败 与 外 债 膨 胀 最 终 拖 垮 了 工 业 领 域 ； 经 济 管 理 层 面 的 失 败 更 促 使 戈 尔 巴 乔 夫 押 注\t 全 面 的 政 治 洗 牌 ： 对 党 政 机 关 的 数 次 清 洗 最 终 只 是 塞 入 了 缺 乏 经 验 与 管 理 能 力 的 嫩 头 青 ； 试 图 澄 清 政 治 环 境 的 “ 开 放 政 策 ” 直 接 导 致 民 族 主 义 势 力 的 增 长 和 反 苏 谎 言 兴 盛 。 为 筹 集 资 金 与 激 活 地 方 活 力 所 引 入 的 合 作 社 体 制 与 分 权 改 革 更 是 在 该 国 建 立 了 奇 美 拉 式 的 经 济 状 态 ， 同 时 综 合 了 市 场 经 济 欠 调 控 与 计 划 经 济 缺 乏 灵 活 性 的 弊 端 ： 于 是 赤 字 、 物 资 短 缺 、 经 济 崩 溃 、 巨 额 外 债 与 人 民 赤 贫 构 成 了 戈 尔 巴 乔 夫 执 政 后 期 的 主 旋 律 。 | | 然 而 ， 戈 尔 巴 乔 夫 试 图 在 外 交 上 开 辟 新 战 线 的 政 策 倒 是 为 他 寻 得 了 救 命 稻 草 ， 并 在 同 时 为 “ 改 革 与 新 思 维 ” 开 出 新 路 。 前 途 无 量 的 社 会 主 义 联 盟 当 然 不 会 对 处 于 困 境 的 苏 联 改 革 家 坐 视 不 理 ， 并 以 支 持 苏 联 向 “ 人 道 、 民 主 的 社 会 主 义 ” 转 型 的 名 义 提 供 了 远 超 往 日 大 西 洋 集 团 所 能 开 出 的 条 件 ： 苏 联 获 得 了 久 违 的 低 息 贷 款 、 自 由 贸 易 区 、 最 惠 国 待 遇 与 长 期 技 术 援 助 计 划 的 受 惠 国 身 份 ； 并 以 优 惠 成 员 的 正 式 身 份 成 功 融 入 到 了 欧 洲 社 会 主 义 联 盟 的 经 济 空 间 中 。 该 国 的 沉 重 外 债 也 被 以 意 大 利 为 代 表 的 发 达 国 家 分 别 消 化 ， 并 以 此 交 换 其 实 施 更 利 好 国 内 劳 工 与 进 一 步 向 西 看 齐 的 社 会 改 革 。 终 于 ， 苏 联 社 会 局 势 也 因 经 济 平 稳 着 陆 而 日 趋 稳 定 ， 该 国 本 身 也 将 迎 来 久 违 的 繁 荣 。 不 久 后 实 行 的 雷 日 科 夫 市 场 经 济 改 革 、 总 统 制 转 型 与 去 政 党 化 运 动 只 会 更 加 利 好 作 为 政 治 强 人 与 早 已 拿 捏 雄 厚 资 本 的 戈 尔 巴 乔 夫 。 可 该 国 目 前 的 债 务 结 构 与 主 要 贸 易 伙 伴 关 系 已 经 让 克 里 姆 林 宫 主 人 的 权 力 变 得 越 来 越 浮 于 表 面 ： 只 要 罗 马 与 巴 黎 的 欧 洲 共 产 党 人 一 声 令 下 ， 所 谓 的 超 级 大 国 便 会 霎 时 休 克 ， 露 出 其 早 已 变 为 西 欧 经 济 后 花 园 的 真 面 目 。 分 析 者 已 用 类 似 英 美 特 殊 关 系 的 词 语 形 容 苏 联 与 欧 洲 诸 国 的 外 交 现 状 ： 即 前 者 在 思 想 与 历 史 渊 源 上 对 后 者 有 无 可 替 代 的 作 用 ， 是 社 会 文 化 领 域 的 父 亲 ； 但 后 者 能 够 通 过 力 量 对 比 与 国 际 关 系 的 改 变 使 前 者 充 当 起 自 身 附 庸 ， 并 在 权 力 意 义 上 成 为 其 忠 实 的 父 亲 … …";
							}
							else
							{
								fake_text = "戈 尔 巴 乔 夫 - 新 联 盟 | 最 终 ， 来 自 安 德 罗 波 夫 改 革 派 圈 子 的 新 人 ， 年 富 力 强 的 米 哈 伊 尔 · 戈 尔 巴 乔 夫 从 苏 联 建 制 派 手 中 接 手 了 国 家 大 权 ， 并 以 “ 回 归 列 宁 主 义 ” 的 名 义 实 施 改 革 。 然 而 ， 戈 尔 巴 乔 夫 旨 在 重 振 人 民 对 苏 维 埃 制 度 自 信 的 改 革 尝 试 没 有 一 个 得 以 善 终 — — 旨 在 整 顿 劳 动 纪 律 的 反 酗 酒 运 动 摧 毁 了 联 盟 境 内 本 就 脆 弱 的 农 业 生 产 ， 并 为 黑 手 党 、 地 下 交 易 与 走 私 等 诸 多 非 法 勾 当 发 展 提 供 了 便 利 ； 试 图 以 制 造 业 为 导 向 全 面 振 兴 国 内 产 业 的 “ 加 速 发 展 战 略 ” 则 和 其 他 发 展 中 国 家 制 定 的 类 似 战 略 一 样 走 到 了 死 路 ： 资 金 浪 费 、 产 业 结 构 失 衡 、 交 易 过 程 中 的 腐 败 与 外 债 膨 胀 最 终 拖 垮 了 工 业 领 域 ； 经 济 管 理 层 面 的 失 败 更 促 使 戈 尔 巴 乔 夫 押 注 全 面 的 政 治 洗 牌 ： 对 党 政 机 关 的 数 次 清 洗 最 终 只 是 塞 入 了 缺 乏 经 验 与 管 理 能 力 的 嫩 头 青 ； 试 图 澄 清 政 治 环 境 的 “ 开 放 政 策 ” 直 接 导 致 民 族 主 义 势 力 的 增 长 和 反 苏 谎 言 兴 盛 。 为 筹 集 资 金 与 激 活 地 方 活 力 所 引 入 的 合 作 社 体 制 与 分 权 改 革 更 是 在 该 国 建 立 了 奇 美 拉 式 的 经 济 状 态 ， 同 时 综 合 了 市 场 经 济 欠 调 控 与 计 划 经 济 缺 乏 灵 活 性 的 弊 端 ： 于 是 赤 字 、 物 资 短 缺 、 经 济 崩 溃 、 巨 额 外 债 与 人 民 赤 贫 构 成 了 戈 尔 巴 乔 夫 执 政 后 期 的 主 旋 律 。 | | 然 而 ， 戈 尔 巴 乔 夫 试 图 在 外 交 上 开 辟 新 战 线 的 政 策 倒 是 为 他 寻 得 了 救 命 稻 草 ， 并 在 同 时 为 “ 改 革 与 新 思 维 ” 实 现 续 命 。 前 途 无 量 的 社 会 主 义 联 盟 当 然 不 会 对 处 于 困 境 的 苏 联 改 革 家 坐 视 不 理 ， 并 以 支 持 苏 联 向 “ 人 道 、 民 主 的 社 会 主 义 ” 转 型 的 名 义 提 供 了 远 超 往 日 大 西 洋 集 团 所 能 开 出 的 条 件 ： 苏 联 获 得 了 久 违 的 低 息 贷 款 、 自 由 贸 易 区 、 最 惠 国 待 遇 与 长 期 技 术 援 助 计 划 的 受 惠 国 身 份 ； 并 以 联 系 国 名 义 成 功 融 入 到 了 欧 洲 社 会 主 义 联 盟 的 经 济 空 间 中 。 不 过 ， 双 方 还 是 未 能 就 更 进 一 步 一 体 化 与 债 务 重 组 方 面 的 问 题 达 成 共 识 ： 实 际 上 ， 西 欧 国 家 将 其 视 为 同 一 问 题 不 同 方 面 （ 即 苏 联 社 会 缺 乏 活 力 ， 应 当 在 基 于 自 筹 资 金 与 民 主 化 的 原 则 上 更 进 一 步 ） 的 立 场 ， 以 及 其 对 苏 联 债 务 规 模 的 恐 惧 成 了 双 方 达 成 共 识 的 最 大 阻 碍 。 因 此 苏 联 本 身 的 改 革 重 组 仍 将 以 漫 长 又 相 对 痛 苦 的 方 式 继 续 ， 分 权 化 尝 试 与 持 续 的 律 法 之 争 最 终 以 苏 联 本 身 的 改 组 而 结 束 ：1991 年 签 署 的 《 新 联 盟 条 约 》 取 代 了1922 年 《 苏 联 成 立 条 约 》 ， 在 承 认 民 族 自 决 权 的 基 础 上 允 许 各 国 享 有 独 立 的 产 业 、 军 备 、 法 律 与 货 币 体 系 ， 联 盟 级 机 构 仅 作 为 提 供 转 账 卢 布 与 统 一 关 税 的 共 同 经 济 空 间 与 合 议 团 体 存 在 ； 与 此 同 时 ， 所 有 成 员 国 与 苏 联 本 身 都 在 同 时 获 得 了 社 会 主 义 联 盟 的 成 员 身 份 。 最 终 以 一 种 古 怪 的 方 式 兑 现 了 一 体 化 承 诺 。 此 后 实 行 的 阿 巴 尔 金 市 场 经 济 改 革 、 总 统 制 转 型 与 去 政 党 化 运 动 只 会 更 加 利 好 作 为 政 治 强 人 与 早 已 拿 捏 雄 厚 资 本 的 戈 尔 巴 乔 夫 。 可 该 国 目 前 的 债 务 结 构 与 主 要 贸 易 伙 伴 关 系 已 经 让 克 里 姆 林 宫 主 人 的 权 力 变 得 越 来 越 浮 于 表 面 ： 半 吊 子 一 体 化 与 二 重 成 员 身 份 只 会 让 作 为 统 一 空 间 与 论 坛 性 质 组 织 的 苏 维 埃 联 盟 显 得 越 加 缺 乏 吸 引 力 ， 并 最 终 导 致 其 成 员 国 在 事 实 上 完 全 并 入 社 会 主 义 联 盟 与 苏 联 的 名 存 实 亡 。";
							}
						}
						else if (GlobalScript.inst.gameState.empires[1].relations >= 500)
						{
							fake_text = " 戈 尔 巴 乔 夫 |最 终 ， 来 自 安 德 罗 波 夫 改 革 派 圈 子 的 新 人 ， 年 富 力 强 的 米 哈 伊 尔 · 戈 尔 巴 乔 夫 从 苏 联 建 制 派 手 中 接 手 了 国 家 大 权 ， 并 以 “ 回 归 列 宁 主 义 ” 的 名 义 实 施 改 革 。 然 而 ， 戈 尔 巴 乔 夫 旨 在 重 振 人 民 对 苏 维 埃 制 度 自 信 的 改 革 尝 试 没 有 一 个 得 以 善 终 — — 旨 在 整 顿 劳 动 纪 律 的 反 酗 酒 运 动 摧 毁 了 联 盟 境 内 本 就 脆 弱 的 农 业 生 产 ， 并 为 黑 手 党 、 地 下 交 易 与 走 私 等 诸 多 非 法 勾 当 发 展 提 供 了 便 利 ； 试 图 以 制 造 业 为 导 向 全 面 振 兴 国 内 产 业 的 “ 加 速 发 展 战 略 ” 则 和 其 他 发 展 中 国 家 制 定 的 类 似 战 略 一 样 走 到 了 死 路 ： 资 金 浪 费 、 产 业 结 构 失 衡 、 交 易 过 程 中 的 腐 败 与 外 债 膨 胀 最 终 拖 垮 了 工 业 领 域 ； 经 济 管 理 层 面 的 失 败 更 促 使 戈 尔 巴 乔 夫 押 注 全 面 的 政 治 洗 牌 ： 对 党 政 机 关 的 数 次 清 洗 最 终 只 是 塞 入 了 缺 乏 经 验 与 管 理 能 力 的 嫩 头 青 ； 试 图 澄 清 政 治 环 境 的 “ 开 放 政 策 ” 直 接 导 致 民 族 主 义 势 力 的 增 长 和 反 苏 谎 言 兴 盛 。 为 筹 集 资 金 与 激 活 地 方 活 力 所 引 入 的 合 作 社 体 制 与 分 权 改 革 更 是 在 该 国 建 立 了 奇 美 拉 式 的 经 济 状 态 ， 同 时 综 合 了 市 场 经 济 欠 调 控 与 计 划 经 济 缺 乏 灵 活 性 的 弊 端 ： 于 是 赤 字 、 物 资 短 缺 、 经 济 崩 溃 、 巨 额 外 债 与 人 民 赤 贫 构 成 了 戈 尔 巴 乔 夫 执 政 后 期 的 主 旋 律 。 试 图 在 外 交 上 开 辟 新 战 线 ， 押 注 大 西 洋 主 义 的 立 场 还 未 实 行 便 因 美 国 回 归 孤 立 主 义 而 胎 死 腹 中 。 导 致 苏 联 不 得 不 向 东 寻 求 欧 亚 主 义 的 灵 丹 妙 药 ： 主 张 “ 当 共 产 党 总 比 死 了 强 ” 的 外 交 官 奥 列 格 · 特 罗 扬 诺 夫 斯 基 取 代 了 倡 导 “ 新 思 维 ” 的 爱 德 华 · 谢 瓦 尔 德 纳 泽 ， 为 争 取 我 们 对 改 革 事 业 的 支 持 而 摆 出 近 乎 卑 躬 屈 膝 的 态 度 。 他 们 甚 至 不 惜 重 新 定 性 往 日 中 苏 决 裂 的 系 列 事 件 ， 并 在 边 界 划 分 问 题 上 做 出 有 利 于 中 方 的 让 步 （ 我 们 也 就 此 完 全 收 回 黑 瞎 子 岛 与 银 龙 岛 ） 。 社 会 主 义 阵 营 内 版 本 的 “ 禅 让 ” 闹 剧 最 终 在 华 约 和 经 互 会 的 改 组 中 达 到 顶 峰 。 可 苏 联 自 身 终 究 还 是 靠 这 种 特 殊 的 断 尾 求 生 得 以 保 存 — — 中 国 发 放 的 贷 款 与 中 苏 能 源 协 定 签 署 为 苏 联 经 济 发 展 提 供 了 强 心 剂 ， 双 方 间 的 特 勤 与 军 事 合 作 也 足 以 遏 制 戈 尔 巴 乔 夫 的 政 策 下 滋 生 的 自 由 主 义 者 和 民 族 主 义 者 们 。 苏 联 本 身 也 得 以 采 用 另 一 个 特 殊 的 形 式 保 存 下 来 ： 即 引 入 多 党 制 、 强 总 统 制 与 管 制 资 本 主 义 联 邦 国 家 ， 而 戈 尔 巴 乔 夫 仍 是 其 毋 庸 置 疑 的 核 心 。 当 然 ， 考 虑 到 那 些 债 券 与 苏 联 高 官 账 户 的 所 有 权 ， 他 知 道 自 己 该 支 持 的 贵 人 在 何 方 ； 并 选 择 全 心 全 意 为 我 们 的 事 业 效 力 。";
						}
						else
						{
							fake_text = " 戈 尔 巴 乔 夫 |最 终 ， 来 自 安 德 罗 波 夫 改 革 派 圈 子 的 新 人 ， 年 富 力 强 的 米 哈 伊 尔 · 戈 尔 巴 乔 夫 从 苏 联 建 制 派 手 中 接 手 了 国 家 大 权 ， 并 以 “ 回 归 列 宁 主 义 ” 的 名 义 实 施 改 革 。 然 而 ， 戈 尔 巴 乔 夫 旨 在 重 振 人 民 对 苏 维 埃 制 度 自 信 的 改 革 尝 试 没 有 一 个 得 以 善 终 — — 旨 在 整 顿 劳 动 纪 律 的 反 酗 酒 运 动 摧 毁 了 联 盟 境 内 本 就 脆 弱 的 农 业 生 产 ， 并 为 黑 手 党 、 地 下 交 易 与 走 私 等 诸 多 非 法 勾 当 发 展 提 供 了 便 利 ； 试 图 以 制 造 业 为 导 向 全 面 振 兴 国 内 产 业 的 “ 加 速 发 展 战 略 ” 则 和 其 他 发 展 中 国 家 制 定 的 类 似 战 略 一 样 走 到 了 死 路 ： 资 金 浪 费 、 产 业 结 构 失 衡 、 交 易 过 程 中 的 腐 败 与 外 债 膨 胀 最 终 拖 垮 了 工 业 领 域 ； 经 济 管 理 层 面 的 失 败 更 促 使 戈 尔 巴 乔 夫 押 注 全 面 的 政 治 洗 牌 ： 对 党 政 机 关 的 数 次 清 洗 最 终 只 是 塞 入 了 缺 乏 经 验 与 管 理 能 力 的 嫩 头 青 ； 试 图 澄 清 政 治 环 境 的 “ 开 放 政 策 ” 直 接 导 致 民 族 主 义 势 力 的 增 长 和 反 苏 谎 言 兴 盛 。 为 筹 集 资 金 与 激 活 地 方 活 力 所 引 入 的 合 作 社 体 制 与 分 权 改 革 更 是 在 该 国 建 立 了 奇 美 拉 式 的 经 济 状 态 ， 同 时 综 合 了 市 场 经 济 欠 调 控 与 计 划 经 济 缺 乏 灵 活 性 的 弊 端 ： 于 是 赤 字 、 物 资 短 缺 、 经 济 崩 溃 、 巨 额 外 债 与 人 民 赤 贫 构 成 了 戈 尔 巴 乔 夫 执 政 后 期 的 主 旋 律 。 试 图 在 外 交 上 开 辟 新 战 线 ， 押 注 大 西 洋 主 义 的 立 场 还 未 实 行 便 因 美 国 回 归 孤 立 主 义 而 胎 死 腹 中 。 导 致 苏 联 不 得 不 向 东 寻 求 欧 亚 主 义 的 灵 丹 妙 药 ： 主 张 “ 当 共 产 党 总 比 死 了 强 ” 的 外 交 官 奥 列 格 · 特 罗 扬 诺 夫 斯 基 取 代 了 倡 导 “ 新 思 维 ” 的 爱 德 华 · 谢 瓦 尔 德 纳 泽 ， 为 争 取 我 们 对 改 革 事 业 的 支 持 而 摆 出 近 乎 卑 躬 屈 膝 的 态 度 。 可 在 中 国 方 面 的 冷 淡 态 度 面 前 ， 所 有 的 一 切 都 只 是 苏 联 的 一 厢 情 愿 而 已 。 和 平 共 处 的 闹 剧 最 终 随 苏 联 的 衰 退 而 在 华 约 和 经 互 会 的 解 散 中 达 到 顶 峰 。 苏 联 自 身 也 没 有 在 此 事 后 存 在 太 久 — — 戈 尔 巴 乔 夫 的 政 策 下 滋 生 的 自 由 主 义 者 和 民 族 主 义 者 赢 得 了 人 民 的 支 持 ， 在1991 年 末 宣 布 了 苏 联 的 解 体 ， 实 际 上 夺 走 了 未 竟 的 改 革 者 的 权 力 。 此 后 ， 从 旧 联 盟 尸 体 上 脱 胎 的 新 政 权 们 几 乎 全 部 倒 向 了 中 方 建 立 的 欧 亚 新 秩 序 ： 他 们 纷 纷 重 新 定 性 往 日 中 苏 决 裂 的 系 列 事 件 ， 并 在 边 界 划 分 问 题 上 做 出 有 利 于 中 方 的 让 步 （ 我 们 也 就 此 完 全 收 回 黑 瞎 子 岛 与 银 龙 岛 ） 。 我 们 作 为 新 世 界 领 导 人 的 地 位 就 此 更 加 毋 庸 置 疑 。 ";
						}
					}
					else if (GlobalScript.inst.gameState.data[16] >= 13 && GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[0].power + 500 && GlobalScript.inst.gameState.allcountries[1].econ && GlobalScript.inst.gameState.allcountries[1].okb)
					{
						fake_text = " 近 卫 军 的 一 天| 随 着 戈 尔 巴 乔 夫 的 改 革 屡 屡 受 挫 ， 全 联 盟 的 经 济 与 民 族 矛 盾 达 到 高 峰 ， 而 苏 联 的 强 力 机 关 日 复 一 日 的 感 到 不 安 与 不 耐 烦 。 为 此 ， 戈 尔 巴 乔 夫 不 得 不 一 再 让 步 ， 对 于 事 实 上 将 苏 联 解 体 为 一 个 邦 联 制 度 国 家 的 方 案 应 运 而 生 。 为 了 阻 止 《 新 联 盟 条 约 》 的 签 署 ， 国 家 紧 急 状 态 委 员 会 发 动 的 政 变 最 终 证 明 是 灾 难 性 的 ： 政 变 者 甚 至 未 能 阻 止 一 些 激 进 计 划 的 事 实 ， 多 亏 了 如 格 罗 莫 夫 ， 瓦 伦 尼 科 夫 与 阿 尔 科 斯 尼 斯 等 强 硬 派 中 下 层 委 员 会 成 员 “ 选 择 性 ” 听 取 亚 佐 夫 与 克 留 奇 科 夫 的 指 令 ， 叶 利 钦 神 秘 地 死 于 阿 尔 汉 格 尔 斯 克 自 宅 的 煤 气 爆 炸 当 中 ， 而 戈 尔 巴 乔 夫 则 失 联 于 福 罗 斯 ， 后 被 发 现 身 亡 于 食 物 中 毒 。 然 而 ，Gkchp 独 走 者 的 激 进 做 法 却 无 法 稳 定 苏 联 的 局 势 ： 利 用 白 宫 的 混 乱 ， 空 军 上 将 叶 夫 根 尼 . 沙 普 什 尼 科 夫 ， 伞 兵 司 令 帕 维 尔 . 格 拉 乔 夫 ， 警 察 大 将 维 克 多 . 巴 兰 尼 科 夫 ， 克 格 勃 高 级 将 领 瓦 迪 姆 . 巴 卡 京 等 少 壮 派 得 以 发 动 了 一 场 成 功 的 反 政 变 。 卢 基 扬 诺 夫 看 到 大 势 已 去 后 ， 不 得 不 承 认 了 发 政 变 者 的 合 法 性 ， 而Gkchp 成 员 被 全 部 拘 留 。 在 这 样 一 种 背 景 下 ， 新 联 盟 条 约 被 卢 基 扬 诺 夫 签 署 ， 但 真 正 的 权 力 却 属 于 新 的 强 力 机 关 - 在 新 的 大 选 当 中 ， “ 改 革 近 卫 军 “ 们 通 过 扩 大 强 力 部 门 影 响 力 ， 暗 杀 散 播 恐 怖 ， 出 售 军 备 获 得 的 大 笔 钞 票 以 贿 赂 和 游 说 成 功 地 通 过 公 投 让 一 场 联 盟 性 的 紧 急 状 态 通 过 以 “ 执 行 皮 诺 切 特 方 案 ” ， 顺 带 解 体 并 查 禁 了 苏 共 ， 而 在 此 期 间 不 满 的 地 区 大 可 “ 吞 下 多 少 主 权 都 可 以 ” 。 随 着 安 纳 托 利 . 索 布 恰 克 即 将 被 巴 卡 京 与 沙 普 什 尼 科 夫 - 蓝 色 契 卡 与 蓝 色 “ 朱 可 夫 ” 抬 上 合 法 门 面 的 宝 座 以 加 深 对 于 比 起 忌 惮 巨 熊 的 西 方 更 加 能 够 在 经 济 上 支 持 自 己 的 腰 包 的 东 方 的 合 作 ， 现 在 ， 似 乎 只 要 平 息 如 罗 赫 琳 ， 列 别 德 和 克 瓦 奇 科 夫 的 新 一 代 强 力 机 关 少 壮 派 ， 这 个 没 有 主 权 的 资 源 殖 民 地 就 可 以 万 事 大 吉 。 主 权 联 盟 由 西 罗 维 基 集 团 支 配 的 新 篇 章 即 将 开 始 … …";
					}
					else
					{
						fake_text = " 戈 尔 巴 乔 夫| 最 终 ， 来 自 安 德 罗 波 夫 改 革 派 圈 子 的 新 人 ， 年 富 力 强 的 米 哈 伊 尔 · 戈 尔 巴 乔 夫 从 苏 联 建 制 派 手 中 接 手 了 国 家 大 权 ， 并 以 “ 回 归 列 宁 主 义 ” 的 名 义 实 施 改 革 。 然 而 ， 戈 尔 巴 乔 夫 旨 在 重 振 人 民 对 苏 维 埃 制 度 自 信 的 改 革 尝 试 没 有 一 个 得 以 善 终 — — 旨 在 整 顿 劳 动 纪 律 的 反 酗 酒 运 动 摧 毁 了 联 盟 境 内 本 就 脆 弱 的 农 业 生 产 ， 并 为 黑 手 党 、 地 下 交 易 与 走 私 等 诸 多 非 法 勾 当 发 展 提 供 了 便 利 ； 试 图 以 制 造 业 为 导 向 全 面 振 兴 国 内 产 业 的 “ 加 速 发 展 战 略 ” 则 和 其 他 发 展 中 国 家 制 定 的 类 似 战 略 一 样 走 到 了 死 路 ： 资 金 浪 费 、 产 业 结 构 失 衡 、 交 易 过 程 中 的 腐 败 与 外 债 膨 胀 最 终 拖 垮 了 工 业 领 域 ； 经 济 管 理 层 面 的 失 败 更 促 使 戈 尔 巴 乔 夫 押 注 全 面 的 政 治 洗 牌 ： 对 党 政 机 关 的 数 次 清 洗 最 终 只 是 塞 入 了 缺 乏 经 验 与 管 理 能 力 的 嫩 头 青 ； 试 图 澄 清 政 治 环 境 的 “ 开 放 政 策 ” 直 接 导 致 民 族 主 义 势 力 的 增 长 和 反 苏 谎 言 兴 盛 。 为 筹 集 资 金 与 激 活 地 方 活 力 所 引 入 的 合 作 社 体 制 与 分 权 改 革 更 是 在 该 国 建 立 了 奇 美 拉 式 的 经 济 状 态 ， 同 时 综 合 了 市 场 经 济 欠 调 控 与 计 划 经 济 缺 乏 灵 活 性 的 弊 端 ： 于 是 赤 字 、 物 资 短 缺 、 经 济 崩 溃 、 巨 额 外 债 与 人 民 赤 贫 构 成 了 戈 尔 巴 乔 夫 执 政 后 期 的 主 旋 律 。 试 图 在 外 交 上 开 辟 新 战 线 的 做 法 可 被 视 为 完 全 倒 向 大 西 洋 主 义 立 场 ， 并 最 终 导 致 该 国 向 美 国 卑 躬 屈 膝 ， 抛 弃 社 会 主 义 取 得 的 成 就 。 所 谓 的 和 平 共 处 闹 剧 最 终 在 华 约 和 经 互 会 的 解 散 中 达 到 顶 峰 。 苏 联 自 身 也 没 有 在 此 事 后 存 在 太 久 — — 戈 尔 巴 乔 夫 的 政 策 下 滋 生 的 自 由 主 义 者 和 民 族 主 义 者 赢 得 了 人 民 的 支 持 ， 在1991年 末 宣 布 了 苏 联 的 解 体 ， 实 际 上 夺 走 了 未 竟 的 改 革 者 的 权 力 。";
					}
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(36);
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
				{
					fake_text = " 利 加 乔 夫|| 最 终 ， 旧 领 导 人 被 经 验 丰 富 的 地 方 领 导 人 叶 戈 尔 · 利 加 乔 夫 取 代 ， 他 是 安 德 罗 波 夫 改 革 派 圈 子 中 的 一 员 。 他 实 施 了 开 放 、 扩 大 民 主 化 和 向 以 列 宁 的 新 经 济 政 策 为 蓝 本 的 社 会 主 义 市 场 经 济 过 渡 的 政 策 。 然 而 ， 利 加 乔 夫 的 所 有 改 革 举 措 在 执 行 上 都 阻 力 重 重 — — 尽 管 反 酗 酒 运 动 增 加 了 出 生 率 和 减 少 了 犯 罪 率 ， 却 导 致 了 酒 精 代 用 品 的 流 通 ； 加 速 发 展 战 略 提 高 了 工 业 生 产 效 率 ， 但 造 成 了 消 费 品 生 产 的 萎 靡 ； 开 放 — — 尽 管 它 扩 大 了 人 民 的 自 由 ， 但 同 时 催 化 了 反 苏 的 出 版 物 的 出 现 。 将 经 济 运 行 由 指 令 转 换 为 市 场 机 制 的 尝 试 、 在 未 经 充 分 考 虑 的 情 况 下 引 入 合 作 社 、 权 力 下 放 与 计 划 经 济 机 制 的 破 坏 导 致 居 民 消 费 品 生 产 下 降 ， 相 当 一 部 分 人 民 的 赤 贫 。 利 加 乔 夫 的 外 交 政 策 以 与 美 国 不 成 功 的 缓 和 、 放 松 对 经 互 会 与 华 约 的 管 控 导 致 组 织 内 部 分 离 主 义 的 抬 头 而 “ 著 称 ” 。 苏 联 自 身 处 境 也 相 当 艰 难 ， 利 加 乔 夫 试 图 通 过 提 拔 鲍 里 斯 · 叶 利 钦 与 维 塔 利 · 科 若 第 奇 等 人 来 缓 和 局 势 ， 这 导 致 了 苏 共 内 部 合 法 反 对 派 的 出 现 ， 破 坏 了 党 内 团 结 。 到 目 前 为 止 ， 该 国 领 导 层 尚 能 控 制 局 势 ， 但 经 济 学 家 警 告 说25 年 内 很 可 能 会 爆 发 一 场 重 大 危 机 ， 苏 联 的 伪 改 革 者 可 能 无 法 从 中 幸 免 … …";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(61);
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 7)
				{
					if (!GlobalScript.inst.gameState.is_gkchp)
					{
						if (GlobalScript.inst.gameState.allcountries[7].isEU)
						{
							fake_text = string.Format(GlobalScript.inst.new_events_text[1568], "\n");
						}
						else
						{
							fake_text = "鲍 里 斯 · 叶 利 钦 ： 玉 米 棒 子 能 拿 去 酿 伏 特 加 吗 ？||持 有 大 西 洋 主 义 理 想 与 改 革 重 组 信 念 的 亚 历 山 大 · 雅 科 夫 列 夫 没 能 在 博 弈 内 笑 到 最 后 ， 并 最 终 搬 起 石 头 砸 了 自 己 的 脚 ： 由 于 欧 洲 共 同 体 不 复 存 在 ， 以 及 苏 美 双 边 关 系 在 “ 遗 产 战 争 ” 结 束 后 便 因 商 榷 欧 洲 共 治 体 系 上 “ 缺 乏 共 识 ” 而 裹 足 不 前 。 意 味 着 遵 循 传 统 大 西 洋 主 义 的 一 体 化 路 径 也 随 之 失 效 。 这 只 会 让 主 打 实 现 “ 美 苏 共 治 ” 的 雅 科 夫 列 夫 与 其 同 僚 的 政 治 资 产 愈 加 贬 值 。 而 雅 科 夫 列 夫 试 图 借 欧 洲 式 “ 人 道 民 主 社 会 主 义 ” 澄 清 苏 联 政 治 气 象 ， 试 图 将 苏 联 政 坛 转 为 第 二 个 欧 洲 共 同 体 委 员 会 的 大 规 模 人 事 改 组 产 生 了 意 料 之 外 的 结 果 。 持 民 粹 主 义 、 国 家 主 义 与 本 土 主 义 情 结 ， 并 靠 着 反 贪 腐 、 反 党 阀 、 干 部 年 轻 化 等 “ 非 政 治 诉 求 ” 崛 起 的 新 生 代 们 得 以 顺 藤 摸 瓜 ， 并 逐 步 终 结 了 雅 科 夫 列 夫 试 图 以 大 西 洋 主 义 者 与 西 欧 式 社 会 党 人 主 宰 国 政 的 蓝 图 — — 这 便 是 以 鲍 里 斯 · 叶 利 钦 等 以 “ 在 经 济 改 革 期 间 损 公 肥 私 ” ， “ 外 交 上 裹 足 不 前 ， 充 当 美 国 跟 屁 虫 ” 与 “ 放 纵 媒 体 宣 扬 西 方 价 值 观 ， 助 长 恐 俄 情 绪 ” 为 名 发 动 政 变 的 背 景 故 事 。 新 当 局 彻 底 清 理 了 以 雅 科 夫 列 夫 为 代 表 的 “ 大 西 洋 主 义 者 ” ， 并 将 大 批 持 国 家 主 义 立 场 的 政 治 冷 感 人 士 带 入 了 新 体 系 ： 缺 乏 主 动 性 的 工 会 官 僚 根 纳 季 · 亚 纳 耶 夫 成 为 了 部 长 会 议 主 席 ； “ 斯 拉 夫 派 ” 走 卒 弗 拉 基 米 尔 · 克 留 奇 科 夫 则 主 管 安 全 部 门 ； 曾 在 “ 雅 科 夫 列 夫 改 革 时 期 ” 撮 合 苏 联 境 内 极 端 主 义 群 众 运 动 合 流 ， 且 成 功 将 共 产 主 义 理 想 与 俄 罗 斯 民 族 主 义 至 高 理 想 综 合 的 根 纳 季 · 久 加 诺 夫 更 成 为 国 内 意 识 形 态 掌 门 ， 做 好 了 实 现 国 内 改 革 “ 回 滚 ” 的 准 备 。 虽 说 “ 回 滚 ” 范 围 仅 限 于 “ 太 过 大 西 洋 主 义 ” 的 部 分 ： 苏 联 社 会 党 被 改 名 回 苏 联 共 产 党 ， “ 宣 传 鼓 动 ” 的 原 则 也 被 重 提 ， 国 内 的 大 多 数 非 官 方 组 织 也 在 “ 去 政 党 化 ” 命 令 下 被 纷 纷 取 缔 ； 苏 联 还 有 限 降 低 了 自 己 对 北 大 西 洋 体 系 的 参 与 ， 越 加 将 目 光 放 在 同 南 方 邻 居 的 缓 和 与 筹 建 整 合 新 兴 民 族 政 权 的 一 体 化 机 制 （ 即 所 谓 独 立 国 家 联 合 体 ） 上 。 可 变 革 洪 流 终 究 是 无 法 阻 挡 — — 依 托 雅 科 夫 列 夫 试 图 实 现 将 党 权 转 移 到 国 家 体 制 内 的 安 全 理 事 会 框 架 。 叶 利 钦 政 府 以 推 进 国 家 生 活 “ 民 主 化 ” 为 名 果 断 地 完 成 了 未 竟 之 事 ， 在 该 国 真 正 建 立 了 总 统 制 （ 当 然 ， 首 任 总 统 自 然 是 新 政 策 的 “ 总 设 计 师 ” 鲍 里 斯 · 叶 利 钦 ） 。 意 味 着 叶 利 钦 今 后 将 在 作 为 一 党 党 魁 的 同 时 以 一 国 领 袖 身 份 主 持 各 项 事 务 ， 逐 渐 脱 离 了 苏 共 纪 律 对 自 身 的 制 约 。 下 一 步 则 是 奉 行 所 谓 “ 为 人 民 服 务 的 社 会 市 场 ” 体 制 ： 出 于 打 击 “ 红 色 董 事 ” 的 需 要 ， 国 有 企 业 基 本 被 拆 解 为 股 份 有 限 公 司 ， 其 股 票 将 在 市 场 上 完 全 公 开 出 售 。 全 体 国 民 则 将 被 授 予 面 值 一 定 的 代 金 券 “ 平 等 参 与 ” ； 各 类 地 下 市 场 交 易 形 式 、 产 业 内 的 私 营 部 门 与 所 谓 的 “ 不 劳 而 获 经 营 ” 均 被 合 法 化 以 “ 增 长 全 联 盟 的 财 富 ” ； 以 及 熟 悉 的 注 重 消 费 品 领 域 生 产 ； 虽 说 上 述 绝 大 多 数 政 策 基 本 上 可 被 视 为 雅 科 夫 列 夫 模 式 的 老 调 重 弹 ， 仍 只 能 让 背 靠 党 政 关 系 或 热 心 参 与 经 济 投 机 的 少 部 分 “ 民 族 精 英 ” 们 先 富 起 来 ， 并 带 来 新 资 产 阶 级 崛 起 、 政 商 勾 结 与 贫 富 分 化 等 一 系 列 老 问 题 问 题 。 可 叶 利 钦 政 府 还 是 能 够 靠 着 吸 取 前 人 的 经 验 教 训 站 稳 脚 跟 ： 毕 竟 在 苏 联 ， 没 有 人 会 拒 绝 一 位 鼓 吹 将 彻 底 放 开 酒 精 管 制 ， 并 宣 布 将 在 伏 特 加 领 域 率 先 引 入 “ 定 期 降 价 ” ， 以 实 现 “ 共 产 主 义 ” 的 “ 酒 精 考 验 伟 大 领 袖 ” 。 至 少 ， 在 他 们 醒 酒 前 是 如 此 … …";
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[92].SubGosstroy == 9)
					{
						fake_text = "永 别 了 ， 武 器||在 欧 洲 极 右 翼 势 力 越 加 壮 大 的 背 景 下 ， 原 苏 联 的 事 情 变 得 愈 发 难 以 收 场 ： 苏 联 的 军 事 政 变 最 终 以 惨 烈 的 内 战 与 解 体 而 告 终 ， 其 欧 洲 碎 片 大 都 加 入 了 形 同 虚 设 的 北 大 西 洋 联 盟 ， 主 体 俄 罗 斯 则 完 全 拥 抱 了 民 族 民 主 主 义 思 潮 ： 俄 罗 斯 自 由 民 主 党 ， 民 族 爱 国 阵 线 “ 记 忆 ” ， 民 族 布 尔 什 维 克 党 ， 欧 亚 青 年 ， 俄 罗 斯 民 族 团 结 等 臭 名 昭 著 的 极 右 翼 势 力 在1993 年 的 俄 国 宪 政 危 机 期 间 推 翻 了 伪 自 由 主 义 政 府 ， 并 伙 同 前 苏 联 政 治 集 团 “ 联 盟 ” 形 成 了 左 右 共 治 ： 绰 号 黑 色 上 校 的 拉 脱 维 亚 人 维 克 托 · 阿 尔 克 斯 尼 斯 掌 握 了 该 国 部 队 ， 并 成 为 民 族 主 义 党 团 “ 俄 罗 斯 民 族 解 放 运 动 ” 在 议 会 的 重 要 发 言 人 ； 弗 拉 季 斯 拉 夫 · 苏 尔 科 夫 则 作 为 妥 协 人 选 出 任 俄 罗 斯 新 “ 领 袖 ” 。 “ 俄 罗 斯 民 族 解 放 运 动 ” 则 靠 着 反 犹 主 义 、 反 共 主 义 、 反 华 观 点 与 宣 扬 俄 罗 斯 大 国 情 节 聚 拢 了 大 量 选 民 ， 由 此 基 本 控 制 国 家 杜 马 ， 并 霸 占 了 该 国 政 府 主 要 席 位 。 预 计 在 下 次 大 选 时 ， 他 们 将 把 该 党 总 书 记 与 现 任 总 理 亚 历 山 大 · 巴 尔 卡 绍 夫 推 选 为 新 一 任 领 袖 。 作 为 唯 一 合 法 反 对 党 的 俄 罗 斯 联 邦 共 产 党 也 被 反 犹 主 义 军 官 ， 军 事 部 门 负 责 人 阿 尔 贝 特 · 马 卡 绍 夫 亲 自 洗 牌 ， 转 向 了 社 会 爱 国 主 义 与 “ 建 设 性 的 左 翼 民 族 主 义 政 党 ” 。 该 国 历 史 舆 论 也 迎 来 了 基 于 “ 主 权 ” 叙 事 的 大 反 转 ： 俄 国 内 战 时 期 的 白 军 军 官 ， 俄 罗 斯 族 内 的 对 德 合 作 者 和 斯 大 林 时 期 被 处 死 的 极 右 翼 人 士 按 照 “ 七 分 成 就 ， 三 分 过 错 ” 、 “ 路 线 正 确 ， 可 遗 憾 叛 国 ” 的 方 式 实 现 平 反 ， 并 被 加 冕 为 民 族 英 雄 — — 因 此 ， 安 德 烈 · 弗 拉 索 夫 得 以 与 斯 大 林 共 享 荣 誉 ， 并 共 同 反 对 斯 捷 潘 · 班 德 拉 及 其 匪 帮 ； 亚 历 山 大 · 高 尔 察 克 、 安 东 · 邓 尼 金 也 得 以 加 入 到 共 同 打 击 彼 得 留 拉 的 队 伍 内 。 出 于 前 无 产 阶 级 专 政 党 的 游 击 队 与 各 路 左 翼 工 会 活 动 家 的 需 要 ， 该 党 以 伊 凡 四 世 时 期 的 特 辖 军 为 原 型 ， 设 计 了 准 军 事 组 织 兼 青 年 团 “ 全 俄 青 年 奥 普 里 尼 那 ” ， 动 员 退 役 军 官 与 十 余 岁 的 青 年 以 铁 血 手 段 惩 罚 斯 拉 夫 民 族 的 敌 人 ， 并 在 国 内 持 续 制 造 白 色 恐 怖 。|接 下 来 发 生 的 事 情 则 更 是 令 人 啧 啧 称 奇 ： 前 苏 联 外 交 官 ， 反 犹 主 义 者 ， 以 “ 韦 利 米 尔 ” 自 诩 的 异 见 人 士 瓦 列 里 · 叶 梅 利 扬 诺 夫 与 异 教 分 子 ， 希 特 勒 崇 拜 者 兼 新 法 西 斯 人 士 ， 自 诩 “ 多 布 罗 斯 拉 夫 ” 的 阿 列 克 谢 · 多 布 罗 沃 斯 基 及 其 班 底 也 加 入 了 俄 罗 斯 右 翼 党 团 联 盟 。 并 根 据 政 治 妥 协 协 定 落 实 其 观 点 ： 出 于 恢 复 传 统 生 活 方 式 的 需 要 ， 斯 拉 夫 原 始 信 仰 也 被 右 翼 从 故 纸 堆 内 翻 出 ， 从 异 端 邪 说 荣 升 为 同 东 正 教 平 起 平 坐 的 国 立 宗 教 。 解 放 运 动 的 机 关 报 《 俄 罗 斯 新 真 理 报 》 也 开 始 将 “ 韦 利 米 尔 ” 的 异 教 右 翼 理 论 同 民 族 爱 国 阵 线 “ 记 忆 ” 的 老 调 混 成 土 豆 烧 肉 ： 他 们 将 布 尔 什 维 克 党 视 为 破 坏 俄 罗 斯 伟 大 复 兴 的 犹 太 布 尔 什 维 主 义 分 子 ， 该 党 只 在 真 正 的 爱 国 者 斯 大 林 打 入 时 才 稍 稍 具 有 了 “ 正 义 性 ” ， 并 以 宣 扬 国 家 无 神 论 的 方 式 重 创 了 共 产 主 义 意 识 形 态 。 然 而 ， 斯 大 林 未 能 改 变 该 党 作 为 犹 太 主 义 傀 儡 的 基 本 路 线 ： 斯 大 林 政 治 局 中 的 犹 太 人 拉 扎 尔 · 卡 冈 诺 维 奇 代 表 犹 太 社 区 及 其 利 益 ， 亲 自 指 挥 了 针 对 苏 联 人 民 的 镇 压 ， 摧 毁 了 农 民 社 会 与 传 统 生 活 方 式 。 甚 至 在 苏 联 成 立 了 犹 太 政 权 临 时 司 令 部 比 罗 比 詹 并 承 认 以 色 列 国 。 斯 大 林 本 人 也 因 摧 毁 犹 太 反 法 西 斯 委 员 会 被 抓 住 把 柄 而 遭 毒 杀 。 接 下 来 便 是 不 可 避 免 的 解 体 — — 为 此 ， 有 必 要 彻 底 摧 毁 苏 联 时 代 象 征 并 捣 毁 列 宁 墓 ， 以 正 教 教 堂 、 神 社 与 佩 伦 崇 拜 取 而 代 之 。 俄 罗 斯 各 地 兴 起 了 大 办 异 教 社 区 与 回 归 村 社 制 度 的 热 潮 ， 并 自 然 而 然 地 建 立 起 基 于 统 制 经 济 的 先 军 经 济 框 架 与 国 家 法 团 主 义 ， 以 构 建 “ 血 与 土 ” 之 上 的 新 俄 罗 斯 帝 国 。|俄 罗 斯 全 国 已 然 成 为 了 台 只 知 备 战 的 战 争 机 器 ， 其 野 心 也 越 加 庞 大 ： 在 当 局 的 默 许 下 ， 青 年 奥 普 里 尼 那 用 实 际 行 动 帮 助 联 合 国 决 定 了 塞 瓦 斯 托 波 尔 与 乌 克 兰 东 部 俄 族 聚 居 区 的 命 运 。 随 后 ， 他 们 也 更 是 毁 了 和 我 们 签 订 的 《 中 苏 关 于 中 亚 诸 国 中 立 区 问 题 的 最 终 方 案 》 ， 重 新 占 领 了 哈 萨 克 北 部 俄 裔 占 多 数 的 地 区 。 罗 斯 巨 熊 正 挥 舞 两 个 拳 头 打 人 ， 并 叫 嚣 不 死 不 休 … … ";
					}
					else
					{
						fake_text = "红 色 警 戒||苏 联 军 队 在 中 亚 与 远 东 的 惨 败 ， 大 量 流 亡 维 吾 尔 ， 哈 萨 克 和 东 干 族 的 居 民 自 愿 归 国 ， 苏 联 远 东 舰 队 全 军 覆 没 与 丢 失 诸 多 岛 屿 的 悲 剧 一 起 震 撼 了 苏 联 全 国 。 军 方 借 此 机 会 将 矛 盾 甩 至 改 革 与 开 放 性 政 策 上 。 战 败 的 检 讨 会 上 ， 雅 科 夫 列 夫 坚 决 要 求 军 方 辞 职 的 尝 试 反 而 刺 激 后 者 采 取 果 断 行 为 ， 反 客 为 主 ： 苏 联 红 军 背 靠 指 挥 保 卫 总 书 记 安 全 的 “ 万 岁 军 头 领 ” 弗 拉 基 米 尔 · 梅 德 韦 杰 夫 ， 决 定 发 起 政 变 。 他 们 将 文 官 视 为 战 败 的 罪 魁 ， 并 由 此 解 散 了 整 个 政 治 局 与 部 长 会 议 ， 以 所 谓 “ 国 家 紧 急 状 态 委 员 会 ” 取 而 代 之 。 “ 紧 急 状 态 委 员 会 ” 宣 布 前 任 领 导 层 与 西 方 国 家 勾 结 ， 破 坏 国 内 经 济 与 军 事 发 展 时 无 所 不 为 ， 如 此 损 害 祖 国 利 益 ， 为 的 就 是 将 国 有 资 产 转 给 “ 党 政 精 英 ” 做 准 备 。 国 家 紧 急 状 态 委 员 会 ” 由 索 科 洛 夫 最 密 切 的 同 僚 ， 现 任 苏 联 国 防 部 长 与 元 帅 谢 尔 盖 · 索 科 洛 夫 领 导 。 其 成 员 襄 括 密 切 联 系 军 方 的 武 将 与 文 职 。 著 名 成 员 包 括 空 军 主 帅 亚 历 山 大 · 科 尔 杜 诺 夫 ； 苏 军 总 参 谋 长 谢 尔 盖 · 阿 赫 罗 梅 耶 夫 ； 空 军 元 帅 伊 万 · 普 斯 特 戈 ； 空 军 元 帅 伊 凡 · 阔 日 杜 布 ； 国 防 部 驻 哈 萨 克 与 突 厥 斯 坦 中 立 区 观 察 组 组 长 瓦 连 京 · 瓦 连 尼 科 夫 ； 外 高 加 索 军 区 指 挥 康 斯 坦 丁 · 科 切 托 夫 ； 乌 克 兰 共 产 党 中 央 委 员 会 第 一 书 记 弗 拉 基 米 尔 · 谢 尔 比 茨 基 ； 乌 兹 别 克 斯 坦 共 产 党 中 央 委 员 会 第 一 书 记 伊 纳 姆 任 · 乌 斯 曼 霍 贾 耶 夫 ； 土 库 曼 斯 坦 共 产 党 中 央 委 员 会 第 一 书 记 萨 帕 尔 穆 拉 特 · 尼 亚 佐 夫 ； 拉 脱 维 亚 共 产 党 中 央 委 员 会 第 一 书 记 鲍 里 斯 · 普 戈 ； 苏 联 科 学 院 院 士 ， 切 尔 诺 贝 利 事 件 前 线 调 查 化 学 家 与 “ 暴 风 雪 ” 号 航 天 飞 机 的 主 设 计 师 鲍 里 斯 · 吉 达 斯 波 夫 ； 以 及 控 制 论 程 序 员 与 国 际 科 学 家 安 纳 托 利 · 基 托 夫 。|苏 联 叫 停 了 一 切 政 治 自 由 化 措 施 ， 心 怀 不 满 的 青 年 异 见 者 小 组 被 忠 诚 的 军 队 驱 散 。 对 标 “ 改 革 开 放 ” 政 策 的 城 市 再 斯 大 林 化 与 再 命 名 工 作 业 已 执 行 ， 旨 在 宣 扬 社 会 爱 国 主 义 。 与 此 同 时 ， 雅 科 夫 列 夫 的 经 济 改 革 也 被 系 数 废 除 。 那 些 深 入 参 与 经 济 改 革 的 原 国 家 领 导 成 员 被 视 为 叛 国 典 型 而 枪 决 ， 此 后 全 国 引 入 了 苏 联 版 的 “ 先 军 政 策 ” ： 该 国 军 方 不 仅 完 全 掌 握 军 事 大 权 ， 还 获 得 了 对 经 济 领 域 说 一 不 二 的 能 力 ； 即 便 是 挪 用 少 量 公 款 肥 己 的 行 为 ， 也 会 被 视 为 贪 腐 而 遭 处 决 ； 国 家 计 划 委 员 会 则 将 生 产 重 心 完 全 转 向 军 事 化 与 军 工 复 合 体 ， 事 实 上 启 动 了 全 国 范 围 的 再 武 装 ， 苏 联 全 体 成 年 国 民 则 被 要 求 强 制 服 役 。 社 会 内 充 斥 着 军 事 化 氛 围 。 出 于 提 升 国 内 军 事 实 力 与 备 战 水 平 的 需 要 ， 苏 联 在 军 事 组 织 形 式 上 也 并 为 放 松 ： 它 一 方 面 采 用 了 索 科 洛 夫 的 军 事 自 动 化 建 议 ： 即 基 于 控 制 论 在 提 升 国 家 事 务 与 经 济 业 务 管 理 上 具 有 高 效 率 的 假 设 而 启 动 对 国 内 社 会 各 领 域 的 计 算 机 化 与 自 动 化 ， 并 试 图 在 国 防 部 的 统 筹 规 划 下 建 立 统 一 管 控 的 经 济 体 系 ； 另 一 方 面 则 接 纳 了 奥 加 尔 科 夫 的 信 息 化 作 战 思 想 ， 主 张 基 于 精 确 制 导 武 器 建 立 合 成 军 与 快 速 反 应 部 队 ， 并 筹 备 实 现 现 有 军 事 体 系 、 动 员 体 系 与 物 流 体 系 与 自 动 化 经 济 的 融 合 . . . . . . 苏 联 全 国 已 然 成 为 了 台 只 知 备 战 的 战 争 机 器 ， 其 野 心 也 越 加 庞 大 ： 该 国 几 乎 同 时 押 注 军 事 卫 星 建 设 与 核 武 现 代 化 计 划 ， 并 切 实 取 得 了 不 少 进 展 。 新 生 的 苏 联 正 挥 舞 拳 头 四 处 寻 找 敌 人 ， 国 内 充 斥 着 大 俄 罗 斯 主 义 与 社 会 爱 国 主 义 共 同 构 成 的 民 粹 激 进 情 绪 ， 并 渴 望 一 场 足 以 推 翻 “ 中 美 资 产 阶 级 走 狗 ” 的 神 圣 战 争 。 苏 联 也 彻 底 成 为 了 拥 国 之 军 ， 也 许 有 朝 一 日 ， 红 色 巨 熊 会 再 度 觉 醒 。";
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
				{
					if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[7].parts[2])
					{
						fake_text = string.Format(GlobalScript.inst.new_events_text[1565], "\n");
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(140);
						}
					}
					else if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[7].parts[0])
					{
						fake_text = string.Format(GlobalScript.inst.new_events_text[1566], "\n");
					}
					else if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[7].parts[1])
					{
						fake_text = string.Format(GlobalScript.inst.new_events_text[1567], "\n");
					}
					else
					{
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(38);
						}
						fake_text = " 罗 曼 诺 夫| 最 终 ， 旧 领 导 人 被 相 对 年 轻 有 希 望 的 党 员 格 里 戈 里 · 罗 曼 诺 夫 取 代 ， 他 因 作 为 列 宁 格 勒 地 区 党 委 领 导 的 贡 献 而 知 名 。 罗 曼 诺 夫 延 续 了 契 尔 年 科 的 改 革 路 线 ， 进 一 步 扩 大 苏 维 埃 权 力 、 强 化 苏 维 埃 民 主 ， 同 时 赋 权 工 会 ， 提 升 其 与 技 术 工 人 在 国 有 企 业 中 的 话 语 权 ， 并 持 续 推 进 反 腐 工 作 。 素 有 “ 契 尔 年 科 的 灰 衣 主 教 ” 之 称 的 理 查 德 · 科 索 拉 波 夫 的 地 位 得 以 正 式 确 立 — — 他 直 接 参 与 了 维 亚 切 斯 拉 夫 · 莫 洛 托 夫 的 平 反 工 作 — — 被 提 拔 为 负 责 意 识 形 态 的 中 央 书 记 并 进 入 政 治 局 。 此 后 ， 苏 联 政 坛 迎 来 大 洗 牌 ， 大 批 改 革 派 官 员 与 腐 败 干 部 被 清 洗 ， 取 而 代 之 的 是 支 持 罗 曼 诺 夫 理 念 的 技 术 官 僚 、 科 索 拉 波 夫 提 拔 的 新 斯 大 林 主 义 者 ， 以 及 正 统 保 守 派 政 治 家 。 卡 冈 诺 维 奇 、 马 林 科 夫 等 “ 反 党 集 团 ” 的 其 余 成 员 逐 步 获 得 平 反 ； 苏 共 二 十 大 上 赫 鲁 晓 夫 的 秘 密 报 告 被 否 定 ， 新 决 议 明 确 斯 大 林 “ 七 分 功 、 三 分 过 ” ， 并 批 判 了 赫 鲁 晓 夫 改 革 的 失 败 与 唯 意 志 论 倾 向 。||经 济 领 域 ， 契 尔 年 科 时 期 批 准 的 “ 集 约 化-90 ” 计 划 在 全 国 范 围 内 正 式 铺 开 ， 重 点 支 持 科 技 创 新 、 自 动 化 与 计 算 机 化 发 展 ， 同 时 推 广 核 能 应 用 并 更 新 国 内 核 设 施 。 计 划 实 施 初 期 便 成 效 显 著 ： 乌 克 兰 切 尔 诺 贝 利 核 电 站 的 重 大 隐 患 被 及 时 发 现 ， 不 仅 避 免 了 一 场 潜 在 灾 难 ， 更 推 动 了 核 设 施 的 全 面 更 新 与 技 术 迭 代 ； 科 学 与 生 产 联 合 企 业 及 地 方 性 科 研 中 心 在 各 地 陆 续 建 成 ； 职 业 教 育 得 到 更 多 重 视 ， 培 养 出 大 批 新 型 技 术 工 人 ； 各 级 官 僚 机 构 与 经 济 运 行 体 系 也 初 步 实 现 计 算 机 化 与 自 动 化 。 “ 集 约 化-90 ” 作 为 改 革 首 阶 段 的 成 功 实 践 ， 促 使 “ 集 约 化-95 ” 与 “ 集 约 化-2000 ” 的 制 定 迅 速 提 上 日 程 。 与 此 同 时 ， 罗 曼 诺 夫 启 动 分 权 计 划 经 济 改 革 ： 部 分 中 央 经 济 管 理 权 下 放 到 州 （ 边 疆 区 、 自 治 共 和 国 ） 级 ， 过 去 下 放 给 企 业 经 理 、 厂 长 的 权 力 被 收 回 ， 交 由 州 级 相 关 机 构 统 筹 ， 以 实 现 地 方 经 济 更 精 准 的 协 同 发 展 ； 工 会 也 在 五 年 计 划 制 定 中 获 得 了 实 质 性 话 语 权 。||民 生 层 面 ， 生 育 津 贴 与 新 住 房 计 划 的 推 广 ， 有 效 缓 解 了 生 育 率 低 迷 与 住 房 紧 张 的 问 题 。 文 化 领 域 ， 罗 曼 诺 夫 采 取 “ 胡 萝 卜 加 大 棒 ” 的 策 略 ： 一 方 面 支 持 科 索 拉 波 夫 收 紧 意 识 形 态 管 控 ， 打 击 活 跃 的 异 见 知 识 分 子 ； 另 一 方 面 ， 他 扶 持 新 兴 文 化 产 业 与 艺 术 团 体 ， 大 量 效 仿 列 宁 格 勒 摇 滚 俱 乐 部 模 式 的 音 乐 俱 乐 部 涌 现 ， 电 影 创 作 者 也 获 得 了 更 多 流 派 试 验 的 空 间 。 为 应 对 西 方 后 现 代 主 义 的 渗 透 ， 罗 曼 诺 夫 宣 布 重 拾 列 宁 时 代 的 文 化 政 策 ， 复 兴 苏 维 埃 先 锋 主 义 文 化 ， 以 此 与 异 见 思 潮 及 西 方 文 化 展 开 竞 争 。||进 入 新 世 纪 ， 三 项 集 约 化 改 革 计 划 已 全 面 落 地 。 苏 联 实 现 了 生 产 自 动 化 ， 解 决 了 劳 动 力 短 缺 与 粮 食 问 题 ， 生 育 率 稳 步 提 升 ； 对 核 能 与 科 技 创 新 的 持 续 投 入 ， 推 动 经 济 从 过 去 的 石 油 依 赖 转 向 科 技 驱 动 。 此 时 的 苏 联 ， 经 济 实 力 、 民 生 福 利 与 文 化 影 响 力 不 断 增 长 ， 呈 现 出 与 以 往 截 然 不 同 的 面 貌 。 然 而 ， 分 权 计 划 经 济 改 革 也 带 来 了 新 的 挑 战 ： 地 方 技 术 官 僚 利 益 集 团 逐 渐 崛 起 ， 把 持 经 济 主 导 权 ， 地 方 主 义 倾 向 随 之 加 剧 ， 罗 曼 诺 夫 不 得 不 与 曾 助 力 自 己 政 治 崛 起 的 地 方 主 义 展 开 新 的 博 弈 。";
						achieves.GetComponent<achievements>().Set(35);
					}
				}
			}
			else if (number_of_e == 5)
			{
				name.text = " 苏 东 社 会 主 义 阵 营";
				if (GlobalScript.inst.gameState.IndOpp)
				{
					if (GlobalScript.inst.gameState.allcountries[4].proprc && GlobalScript.inst.gameState.allcountries[4].SubGosstroy == 19)
					{
						fake_text = "红 色 斯 特 凡 三 世 的 崛 起||苏 联 的 崩 溃 可 能 是 悲 剧 ， 但 对 我 们 的 罗 马 尼 亚 盟 友 则 是 天 赐 良 机 。 在 击 溃 了 华 约 干 涉 军 并 建 立 了 独 立 自 主 的 新 马 扎 尔 后 ， 罗 马 尼 亚 政 府 扛 过 了 东 欧 的 “ 社 会 主 义 — — 不 结 盟 ” 大 旗 。 在 华 约 崩 溃 之 时 ， 罗 马 尼 亚 乘 机 接 手 了 陷 入 混 乱 的 保 加 利 亚 ， 安 全 局 局 长 索 拉 科 夫 通 过 一 场 小 型 内 战 得 以 登 台 入 室 。 而 苏 联 的 内 战 则 让 原 先 的 比 萨 拉 比 亚 地 区 高 举 反 旗 ， 并 宣 布 建 立 独 立 的 摩 尔 多 瓦 国 。 而 齐 奥 塞 斯 库 的 迅 速 干 预 则 大 获 成 功 ， 在 我 们 和 加 告 兹 人 的 帮 助 下 ， 战 无 不 胜 的 罗 马 尼 亚 军 队 迅 速 开 进 各 大 城 市 并 举 行 了 公 投 。 结 果 当 然 是 肯 定 的 ： 该 国 以99 % 的 赞 成 率 加 入 罗 马 尼 亚 。 在 南 斯 拉 夫 的 内 战 中 ， 我 们 押 宝 于 米 洛 舍 维 奇 ， 并 说 服 齐 奥 塞 斯 库 出 兵 。 这 直 接 导 致 了 南 斯 拉 夫 内 战 以 民 族 共 产 主 义 者 的 胜 利 告 终 。2000 年 ， 保 加 利 亚 ， 罗 马 尼 亚 ， 匈 牙 利 和 南 斯 拉 夫 等 四 个 国 家 组 成 了 以 布 加 勒 斯 特 为 核 心 的 联 盟 。 依 托 核 武 器 和 我 国 的 援 助 ， 该 国 在 事 实 上 被 “ 抹 去 ” 的 情 况 下 得 以 生 存 。 并 通 过 转 型 成 为 “ 人 口 转 移 ” ， “ 医 疗 美 容 ” 和 “ 特 殊 经 济 作 物 ” 加 工 的 流 氓 政 权 来 输 出 有 罗 马 尼 亚 特 色 的 革 命 ， 这 就 是 让 无 数 学 者 都 好 奇 的 隐 士 国 度 。|百 战 百 胜 的 尼 古 拉 · 齐 奥 塞 斯 库 更 是 被 冠 以 “ 新 斯 特 凡 三 世 ” 的 称 呼 ， 斯 库 列 塔 特 和 罗 马 尼 亚 人 民 军 将 永 保 红 色 江 山 代 代 传 ， 而 经 过 战 火 洗 礼 的 罗 共 更 是 成 为 了 “ 全 民 族 久 经 时 间 考 验 并 选 择 的 先 锋 队 ” ， 中 央 委 员 会 更 是 在 实 际 上 被 各 大 王 侯 将 相 ： 如 炙 手 可 热 的 大 王 齐 奥 塞 斯 库 ； 万 岁 军 首 领 扬 · 丁 卡 ； 首 席 财 政 大 臣 伊 万 · 图 多 等 人 所 牢 牢 把 握 。 而 事 实 和 时 间 已 经 证 明 了 ， 选 他 们 准 没 错 ！|— — — — 埃 列 娜 · 齐 奥 塞 斯 库 同 志 向 全 体 反 对 派 和 异 见 者 致 以 最 热 切 的 问 候";
					}
					else
					{
						fake_text = "除 了 导 致 自 身 的 解 体 ， 苏 联 的 战 败 还 引 发 了 苏 东 国 家 的 剧 变 。 失 去 了 苏 联 这 个 “ 老 大 哥 ” ， 苏 东 国 家 根 本 无 力 抵 抗 来 自 西 方 的 渗 透 。 这 些 国 家 内 部 的 “ 改 革 派 ” 势 力 迅 速 壮 大 ， 苏 联 的 战 败 被 打 上 了 “ 斯 大 林 主 义 极 权 统 治 的 失 败 ” 的 标 签 。 在 内 外 的 压 力 下 ， 原 本 还 保 留 着 社 会 主 义 外 皮 的 东 欧 国 家 领 导 人 被 迫 下 台 ， 对 前 共 产 党 人 的 审 判 铺 天 盖 地 般 席 卷 而 来 ， 已 经 名 存 实 亡 的 经 互 会 和 华 约 也 随 着 一 场 会 议 宣 告 解 散 。 有 趣 的 是 ， 虽 然 西 方 世 界 之 前 一 直 致 力 于 帮 助 苏 东 社 会 主 义 阵 容 国 家 脱 离 极 权 地 狱 ， 但 在 苏 东 剧 变 、 改 革 派 上 台 后 ， 他 们 却 在 一 瞬 间 就 对 扩 张 “ 正 道 世 界 ” 失 去 了 全 部 的 兴 趣 而 转 为 作 壁 上 观 ， 但 我 们 似 乎 还 是 可 以 说 ， “ 历 史 的 终 结 ” 已 悄 然 降 临 了 … … ";
					}
				}
				else if (GlobalScript.inst.gameState.completedDecisions[9])
				{
					if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
					{
						fake_text = "<size=40>道 阻 且 长</size>|";
						fake_text += GlobalScript.inst.new_texts[294];
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
					{
						if (!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[14] < 3 && GlobalScript.inst.gameState.data[16] < 12)
						{
							fake_text = " <size=40>反 修 正 主 义 的 胜 利 ？</size>|";
							fake_text += " 波 兰 、 匈 牙 利 和 罗 马 尼 亚 向 中 国 势 力 范 围 的 靠 拢 ， 加 上 亲 华 势 力 在 伊 朗 与 阿 富 汗 的 胜 利 ， 苏 联 在 社 会 主 义 阵 营 ， 特 别 是 在 东 欧 的 影 响 力 因 此 受 到 了 重 大 打 击 ， 中 国 也 得 以 在 该 地 区 站 稳 脚 跟 。 因 为 在 欧 洲 拥 有 稳 固 的 立 足 之 地 ， 国 安 部 因 此 能 够 积 极 地 介 入 苏 联 解 体 的 进 程 — — 亲 华 势 力 利 用 混 乱 ， 在 塔 吉 克 斯 坦 内 战 中 掌 握 了 主 动 权 ， 夺 取 了 当 地 的 权 力 ， 而 作 为 扎 瑙 津 起 义 的 结 果 ， 努 尔 苏 丹 · 纳 扎 尔 巴 耶 夫 被 推 翻 ， 新 哈 萨 克 斯 坦 政 府 允 许 中 国 在 共 和 国 内 建 设 一 个 军 事 基 地 。1996 年 ， 在 叶 利 钦 于 总 统 选 举 中 败 选 与 对 “ 七 寡 头 ” 的 反 腐 运 动 之 后 ， 《 中 俄 友 好 合 作 条 约 》 在1998 年 得 以 签 署 ， 中 俄 以 此 解 决 了 主 要 争 议 问 题 ， 两 国 关 系 迈 入 了 新 发 展 阶 段 。 与 此 同 时 ， 在 我 们 领 袖 的 压 力 下 ， 俄 联 邦 共 产 党 与 俄 罗 斯 共 产 主 义 工 人 党 和 “ 劳 工 俄 罗 斯 ” 联 合 成 立 了 俄 罗 斯 统 一 劳 工 阵 线 ， 其 纲 领 包 括 “ 斯 大 林 十 次 打 击 ” 、21 世 纪 社 会 主 义 、 甚 至 毛 主 义 。 中 国 的 帮 助 让 根 纳 季 · 久 加 诺 夫 停 止 了 独 联 体 进 一 步 分 权 化 的 进 程 ， 并 “ 重 启 ” 了 独 联 体 ， 从2000 年 代 开 始 ， 独 联 体 再 度 成 为 一 个 共 同 的 经 济 空 间 ， 并 与 我 们 的 经 济 联 盟 相 融 合 ， 白 俄 罗 斯 与 乌 克 兰 在 其 中 发 挥 了 重 要 作 用 ， 两 国 与 中 国 的 联 系 也 得 以 巩 固 。 反 过 来 ， 俄 罗 斯 也 成 为 “16+1 机 制 ” 的 创 始 者 ， 分 析 人 士 认 为 这 是 巩 固 中 国 在 东 欧 的 影 响 力 并 使 其 渗 透 到 西 欧 的 工 具 。 谁 知 道 这 会 发 展 到 什 么 程 度 ......";
						}
						else if ((!GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 13 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 10 || GlobalScript.inst.gameState.data[14] < 4) && GlobalScript.inst.gameState.data[16] < 14) || GlobalScript.inst.gameState.allcountries[51].Torg)
						{
							fake_text = " <size=40>反 修 正 主 义 的 “ 胜 利 ” ？</size>|";
							fake_text += " 多 亏 了 我 们 的 层 层 布 局 ， 无 产 阶 级 专 政 党 得 以 在 苏 联 夺 权 。 但 事 情 并 没 有 按 照 我 们 的 计 划 发 展 。 我 们 要 求 其 改 组 为 全 联 盟 共 产 党 的 计 划 被 其 拒 绝 。 理 由 是 “ 苏 联 应 当 选 择 自 己 的 社 会 主 义 道 路 ” 。 同 时 在 一 场 代 表 大 会 上 ， 伊 萨 耶 夫 发 表 了 这 样 的 一 通 讲 话 “ 中 国 共 产 党 有 三 把 刀 子 ， 一 把 马 克 思 ， 一 把 列 宁 ， 还 有 一 把 毛 泽 东 ， 我 看 中 国 同 志 把 毛 泽 东 这 把 丢 的 差 不 多 了 。 ” 要 求 其 加 入 我 们 经 济 联 盟 的 计 划 也 被 委 婉 拒 绝 ， 理 由 是 “ 国 际 政 治 中 的 民 主 集 中 制 不 适 用 ” 。 在 最 近 的 群 众 集 会 上 ， 他 们 更 是 指 责 我 们 已 经 蜕 变 成 了 新 的 帝 国 主 义 。 大 量 听 从 我 们 的 党 纷 纷 指 责 无 专 党 的 修 正 主 义 ， 也 有 少 部 分 党 选 择 转 向 无 专 。 新 的 一 轮 中 苏 论 战 已 然 展 开 。 这 群 白 眼 狼 竟 然 忘 了 谁 给 他 们 提 供 了 最 大 的 帮 助 ！";
						}
						else if ((!GlobalScript.inst.gameState.modifies[3].active && !GlobalScript.inst.gameState.modifies[6].active) || GlobalScript.inst.gameState.data[14] > 3 || GlobalScript.inst.gameState.data[16] > 13 || GlobalScript.inst.gameState.data[15] > 7 || GlobalScript.inst.gameState.data[50] > 27 || GlobalScript.inst.gameState.allcountries[51].dev == 1)
						{
							fake_text = " <size=40>反 修 正 主 义 的 失 败</size>|";
							if (GlobalScript.inst.gameState.allcountries[51].dev == 1)
							{
								fake_text += " 你 在 短 短 几 年 内 就 极 其 迅 速 的 倒 向 以 美 帝 国 主 义 为 首 的 反 共 势 力 ， 彻 底 断 绝 了 对 东 欧 反 修 派 的 援 助 ， 并 以 与 中 情 局 合 作 进 行 大 规 模 抓 捕 并 迫 害 相 关 人 士 的 活 动 取 而 代 之 。";
							}
							else
							{
								fake_text += " 你 在 短 短 几 年 内 就 极 其 迅 速 的 背 叛 了 昔 日 的 同 志 ， 彻 底 断 绝 了 对 东 欧 反 修 派 的 援 助 ， 并 以 大 规 模 抓 捕 并 迫 害 相 关 人 士 的 活 动 取 而 代 之 。";
							}
							fake_text += " 面 对 中 国 精 神 病 式 的 转 变 以 及 丧 心 病 狂 的 背 叛 ， 无 专 党 和 东 欧 各 国 的 反 修 派 被 迫 宣 布 和 中 国 断 绝 关 系 并 逐 渐 失 去 力 量 ， 全 世 界 无 数 仁 人 志 士 为 “ 拯 救 苏 联 ” 所 耗 费 的 全 部 心 血 皆 付 诸 东 流 ， 以 “ 捍 卫 世 界 社 会 主 义 事 业 纯 洁 性 ” 的 反 修 正 计 划 就 此 不 了 了 之 。 而 你 甚 至 连 中 国 本 身 的 阵 地 都 没 能 保 住 ： 社 会 主 义 理 念 被 遗 忘 ， 再 度 崛 起 与 泛 滥 的 寡 头 家 族 与 地 方 政 府 纠 缠 不 清 ， 基 层 的 坏 死 让 整 个 国 家 的 大 脑 感 觉 不 到 疼 痛 ， 而 重 新 得 到 超 常 待 遇 的 官 老 爷 们 也 不 会 有 怨 言 ， 只 会 沉 溺 在 人 民 的 血 汗 中 醉 生 梦 死 ， 中 国 的 未 来 又 再 度 回 到 了 迷 雾 和 漫 漫 长 夜 中 ， 也 许 有 一 天 ， 它 会 再 度 拉 着 所 有 人 在 周 期 律 的 轮 回 里 彻 底 毁 灭 ， 如 同 历 史 上 的 任 何 王 朝 一 样 … …";
						}
						else
						{
							fake_text = " <size=40>新 十 月</size>|";
							fake_text += GlobalScript.inst.new_texts[295];
							if (GlobalScript.inst.gameState.iron_and_blood)
							{
								achieves.GetComponent<achievements>().Set(79);
							}
						}
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[21].isSocEU && GlobalScript.inst.gameState.empires[1].now_leader == 6)
				{
					fake_text = " 在 戈 尔 巴 乔 夫 掌 握 苏 联 大 权 后 ， 社 会 主 义 阵 营 逐 渐 开 始 缓 慢 地 解 体 ， 并 且 没 有 了 苏 联 支 持 ， 经 互 会 和 华 约 中 各 成 员 国 的 力 量 开 始 衰 落 。 但 得 益 于 国 际 关 系 的 民 主 化 与 欧 洲 共 产 主 义 替 代 方 案 的 崛 起 。 贝 林 格 与 宫 本 显 治 的 门 生 们 能 够 得 到 戈 尔 巴 乔 夫 握 不 住 的 东 西 。 最 终 ， 华 约 和 经 互 会 的 架 构 也 被 社 会 主 义 联 盟 所 替 代 ， 东 欧 各 国 也 在 苏 联 加 入 社 会 主 义 联 盟 后 纷 纷 倒 戈 与 接 受 民 主 转 型 。 自 觉 融 入 了 从 里 斯 本 到 符 拉 迪 沃 斯 托 克 的 大 欧 洲 范 围 内 。";
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 4 && GlobalScript.inst.gameState.event_done[377])
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1570], "\n", (GlobalScript.inst.gameState.allcountries[7].parts[1] || GlobalScript.inst.gameState.allcountries[1].parts[2]) ? GlobalScript.inst.new_events_text[1571] : null);
				}
				else if ((GlobalScript.inst.gameState.empires[1].now_leader == 3 || GlobalScript.inst.gameState.empires[1].now_leader == 5 || GlobalScript.inst.gameState.empires[1].now_leader == 4) && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].isOVD)
				{
					fake_text = " 对 于 社 会 主 义 阵 营 来 说 ， 没 有 发 生 什 么 太 大 的 改 变 — — 经 互 会 和 华 约 继 续 作 为 资 本 主 义 联 盟 的 替 代 物 稳 定 存 在 着 ， 并 且 苏 联 是 他 们 无 可 争 议 的 领 袖 。";
				}
				else if ((GlobalScript.inst.gameState.empires[1].now_leader == 3 || GlobalScript.inst.gameState.empires[1].now_leader == 5 || GlobalScript.inst.gameState.empires[1].now_leader == 4) && (GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.allcountries[1].isOVD))
				{
					fake_text = " 中 国 进 入 经 互 会 和 华 约 ， 其 在 组 织 内 影 响 力 的 增 长 也 导 致 苏 联 领 导 层 十 分 畏 惧 。 而 对 于 社 会 主 义 阵 营 其 他 国 家 来 说 ， 没 有 发 生 什 么 太 大 的 改 变 — — 经 互 会 和 华 约 继 续 作 为 资 本 主 义 联 盟 的 替 代 物 稳 定 存 在 着 。";
					if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[1].isOVD && GlobalScript.inst.gameState.relres)
					{
						achieves.GetComponent<achievements>().Set(5);
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
				{
					fake_text = " 对 于 社 会 主 义 阵 营 来 说 ， 没 有 发 生 什 么 太 大 的 改 变 — — 经 互 会 和 华 约 继 续 作 为 资 本 主 义 联 盟 的 替 代 物 存 在 着 ， 并 且 苏 联 是 他 们 无 可 争 议 的 领 袖 。";
				}
				else if (GlobalScript.inst.gameState.event_done[433])
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1602], "\n");
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && ((GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.allcountries[1].econ && GlobalScript.inst.gameState.allcountries[1].okb) || (GlobalScript.inst.gameState.allcountries[5].Torg && !GlobalScript.inst.gameState.allcountries[2].prosov && !GlobalScript.inst.gameState.allcountries[4].prosov && (GlobalScript.inst.gameState.allcountries[1].econ || GlobalScript.inst.gameState.allcountries[1].okb))))
				{
					fake_text = " 在 戈 尔 巴 乔 夫 掌 握 苏 联 大 权 后 ， 社 会 主 义 阵 营 逐 渐 开 始 缓 慢 地 解 体 ， 并 且 没 有 了 苏 联 支 持 ， 经 互 会 和 华 约 中 各 成 员 国 的 力 量 开 始 衰 落 。 但 中 苏 之 间 的 良 好 关 系 ， 以 及 在 经 互 会 内 部 的 交 易 ， 允 许 我 们 得 到 戈 尔 巴 乔 夫 握 不 住 的 东 西 。 在 华 约 和 经 互 会 解 散 后 ， 我 们 坚 持 向 东 欧 各 国 提 供 我 们 联 盟 的 带 优 惠 条 件 的 成 员 资 格 ， 罗 马 尼 亚 ， 保 加 利 亚 ， 匈 牙 利 ， 波 兰 和 捷 克 斯 洛 伐 克 同 意 了 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(6);
					}
				}
				else if ((GlobalScript.inst.gameState.empires[1].now_leader == 6 || GlobalScript.inst.gameState.empires[1].now_leader == 8) && ((GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[1].isOVD) || (GlobalScript.inst.gameState.allcountries[5].Torg && !GlobalScript.inst.gameState.allcountries[2].prosov && !GlobalScript.inst.gameState.allcountries[4].prosov && (GlobalScript.inst.gameState.allcountries[1].isOVD || GlobalScript.inst.gameState.allcountries[1].isSEV))))
				{
					if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
					{
						fake_text = " 在 利 加 乔 夫 掌 握 苏 联 大 权 后 ， 社 会 主 义 阵 营 开 始 逐 渐 缓 慢 地 解 体 ， 并 且 没 有 了 苏 联 支 持 ， 经 互 会 和 华 约 中 各 成 员 国 的 力 量 开 始 衰 落 。 但 是 ， 我 们 在 华 约 和 经 互 会 中 的 成 员 地 位 帮 助 我 们 让 它 们 得 以 在 一 个 稍 微 修 正 的 形 式 下 保 持 下 来 。 在 一 次 秘 密 会 议 上 ， 我 们 制 定 了 一 个 计 划 ， 为 苏 联 在 经 互 会 和 华 约 中 的 领 导 地 位 的 最 终 垮 台 做 准 备 。 当 然 ， 由 于 担 心 黑 暗 的 未 来 ， 大 多 数 国 家 都 欣 然 同 意 ， 现 在 经 互 会 和 华 约 在 我 们 的 领 导 下 组 成 了 一 个 更 加 平 等 和 与 时 俱 进 的 社 会 主 义 阵 营 。 然 而 ， 现 在 是 由 我 们 为 这 些 国 家 提 供 一 切 可 能 的 援 助 ， 而 不 是 苏 联 … …";
					}
					else
					{
						fake_text = " 在 戈 尔 巴 乔 夫 掌 握 苏 联 大 权 后 ， 社 会 主 义 阵 营 逐 渐 开 始 缓 慢 地 解 体 ， 并 且 没 有 了 苏 联 支 持 ， 经 互 会 和 华 约 中 各 成 员 国 的 力 量 开 始 衰 落 。 但 是 ， 我 们 在 华 约 和 经 互 会 中 的 成 员 地 位 帮 助 我 们 让 它 们 得 以 在 一 个 稍 微 修 正 的 形 式 下 保 持 下 来 。 在 经 互 会 和 华 约 解 散 后 ， 我 们 向 它 们 的 各 成 员 国 提 议 创 建 一 个 新 阵 营 ， 并 承 担 了 能 支 持 我 们 老 朋 友 经 济 的 所 有 花 费 。 当 然 ， 大 多 数 国 家 — — 民 主 德 国 ， 罗 马 尼 亚 ， 保 加 利 亚 ， 捷 克 斯 洛 伐 克 ， 匈 牙 利 和 波 兰 ， 欣 然 接 受 组 建 一 个 在 我 们 领 导 下 更 平 等 和 与 时 俱 进 的 社 会 主 义 阵 营 。";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(6);
						}
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 || GlobalScript.inst.gameState.empires[1].now_leader == 8)
				{
					if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
					{
						fake_text = " 对 于 社 会 主 义 阵 营 来 说 ， 没 有 发 生 什 么 太 大 的 改 变 — — 经 互 会 和 华 约 继 续 作 为 资 本 主 义 联 盟 的 替 代 物 存 在 着 ， 并 且 苏 联 是 他 们 无 可 争 议 的 领 袖 。";
					}
					else
					{
						fake_text = " 在 戈 尔 巴 乔 夫 掌 握 苏 联 大 权 后 ， 社 会 主 义 阵 营 逐 渐 开 始 缓 慢 地 解 体 ， 并 且 没 有 了 苏 联 支 持 ， 经 互 会 和 华 约 中 各 成 员 国 的 力 量 开 始 衰 落 。 东 欧 社 会 主 义 的 堡 垒 最 终 被 戈 尔 巴 乔 夫 ， 中 情 局 和 克 格 勃 共 同 摧 毁 。";
						if (GlobalScript.inst.gameState.allcountries[0].isNATO && GlobalScript.inst.gameState.allcountries[0].isEU)
						{
							fake_text += "|| 尽 管 在 目 前 ， 新 兴 的 东 欧 各 国 仍 在 形 式 上 保 持 中 立 。 但 在 不 久 后 ， 他 们 将 改 头 换 面 。 成 为 北 大 西 洋 公 约 与 欧 洲 共 同 体 这 两 新 家 庭 的 成 员 。 ";
						}
						else if (GlobalScript.inst.gameState.allcountries[0].isNATO)
						{
							fake_text += "|| 尽 管 在 目 前 ， 新 兴 的 东 欧 各 国 仍 在 形 式 上 保 持 中 立 。 但 在 不 久 后 ， 他 们 将 成 为 北 大 西 洋 公 约 这 一 新 家 庭 的 成 员 。 ";
						}
						else if (GlobalScript.inst.gameState.allcountries[0].isEU)
						{
							fake_text += "|| 尽 管 在 目 前 ， 新 兴 的 东 欧 各 国 仍 在 形 式 上 保 持 中 立 。 但 在 不 久 后 ， 他 们 将 改 头 换 面 。 成 为 欧 洲 共 同 体 这 一 新 家 庭 的 成 员 。";
						}
					}
				}
				else if (GlobalScript.inst.gameState.empires[1].now_leader == 7)
				{
					int num = 0;
					for (int i = 0; i < 100; i++)
					{
						if ((i == 2 || i == 98 || i == 4 || i == 5) && GlobalScript.inst.gameState.allcountries[i].isNATO)
						{
							num++;
						}
					}
					if (num <= 0 && GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(139);
					}
					if (num == 4)
					{
						fake_text = string.Format(GlobalScript.inst.new_events_text[1572], "\n");
					}
					else if (num > 0)
					{
						fake_text = string.Format(GlobalScript.inst.new_events_text[1573], "\n");
					}
					else
					{
						fake_text = string.Format(GlobalScript.inst.new_events_text[1635], "\n");
						if (GlobalScript.inst.gameState.is_gkchp)
						{
							fake_text += " |而 在 那 之 后 发 生 的 事 ， 则 和 他 们 无 关 … …";
						}
					}
				}
			}
			else if (number_of_e == 6)
			{
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power > 20 && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.data[14] == 3)
				{
					achieves.GetComponent<achievements>().Set(15);
				}
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.influencePRC >= 400)
				{
					achieves.GetComponent<achievements>().Set(21);
				}
				name.text = " 冷 战";
				if (GlobalScript.inst.gameState.is_gkchp)
				{
					fake_text = " 冷 战 是 场 回 合 制 游 戏 ， 而 现 在 占 据 高 地 的 显 然 并 不 是 美 国 ，但 事 情 总 会 有 转 机 的 ， 在 不 远 的 将 来 … …";
				}
				else if (GlobalScript.inst.gameState.IndOpp)
				{
					fake_text = " 革 命 之 后 ？ … …|面 对 潜 藏 在 党 内 的 反 革 命 阴 谋 集 团 与 党 外 猖 獗 的 不 肯 改 悔 走 资 派 。 以" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 为 首 的 党 中 央 拿 出 了 无 产 阶 级 革 命 家 的 雄 伟 气 魄 ， 一 举 粉 碎 了 国 内 外 各 路 牛 鬼 蛇 神 篡 党 夺 权 的 罪 恶 阴 谋 ， 将 党 变 修 、 国 变 色 的 现 实 危 险 扼 杀 在 摇 篮 中 。 从 此 挽 救 了 革 命 ， 挽 救 了 党 ， 取 得 了 在 两 条 战 线 上 无 产 阶 级 反 击 资 产 阶 级 进 攻 的 决 定 性 胜 利 ， 并 将 中 国 社 会 主 义 革 命 的 影 响 力 拓 展 至 无 远 弗 届 。 全 党 全 军 与 全 国 各 族 人 民 紧 跟 英 明 领 袖" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 ， 团 结 一 心 ， 精 诚 奋 斗 。 不 仅 通 过 以 军 统 政 ， 以 领 袖 代 政 的 方 式 实 现 党 、 军 、 民 全 体 一 心 一 致 ， 坚 决 扫 除 一 切 反 革 命 ， 开 拓 了20 世 纪 马 克 思 主 义 中 国 化 应 用 的 新 境 界 ； 同 时 洗 刷 近 代 百 年 国 耻 ， 将 广 阔 亚 太 纳 入 到 以 我 人 民 共 和 国 为 绝 对 核 心 的 泛 大 洲 合 作 机 制 内 ， 完 成 了 英 帝 国 、 沙 皇 政 权 与 昭 和 军 国 主 义 匪 帮 等 反 动 势 力 均 无 法 成 就 的 伟 业 。 然 而 ， 总 有 几 只 不 自 量 力 的 小 小 苍 蝇 打 着 所 谓 国 际 社 会 的 旗 号 为 虎 作 伥 ， 并 试 图 串 通 西 方 列 强 将 我 们 孤 立 在 外 — — 无 所 谓 ， 敌 人 来 了 有 猎 枪 ： 西 伯 利 亚 与 澳 洲 荒 原 足 够 为 他 们 的 狼 子 野 心 留 一 席 ！ 除 此 之 外 ， 那 些 诚 心 诚 意 接 受" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 领 导 的 好 朋 友 们 则 足 以 加 入 我 们 的 革 命 大 家 庭 ： 外 国 友 人 在 中 华 优 秀 文 化 与 新 革 命 战 争 文 化 的 熏 陶 中 茁 壮 成 长 ， 以 集 中 生 活 、 优 惠 贸 易 、 乃 至 积 极 拥 抱 汉 语 汉 字 汉 文 化 与 同 国 人 的 通 婚 的 生 活 方 式 坚 决 地 割 断 了 同 既 有 食 利 剥 削 习 气 的 一 切 联 系 ； 国 内 全 体 国 民 则 忠 心 爱 戴 、 坚 决 拥 护 、 誓 死 保 卫 党 的 领 袖 ， 对" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "主 席 为 首 的 党 中 央 充 满 了 必 胜 的 信 心 。 只 是 人 终 有 一 死 ， 而 雄 才 伟 人 终 究 难 得 — — 虽 说" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 不 愧 为 毛 主 席 亲 自 选 定 的 接 班 人 ， 不 愧 为 把 毛 主 席 的 事 业 推 向 前 进 的 掌 舵 人 ， 不 愧 为 毛 主 席 缔 造 的 中 国 共 产 党 的 英 明 领 袖 。 可 在" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "主 席 开 创 的 全 新 事 业 与 宏 伟 蓝 图 面 前 ， 谁 又 能 担 当 大 任 ， 接 过 那 面 伟 大 旗 帜 呢 ？ 虽 说 全 党 全 军 全 国 各 族 人 民 已 有 竭 诚 拥 护 ， 矢 志 不 渝 追 随 革 命 意 志 的 大 觉 悟 ， 大 智 慧 ； 并 做 好 了 将" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 拥 戴 上 永 远 的 人 民 总 司 令 ， 确 保 中 国 境 内 江 山 不 倒 的 大 自 觉 ； 可 我 们 也 得 考 虑 后 进 生 的 问 题 ： 偌 大 的 家 庭 终 究 需 要 顶 梁 柱 与 好 父 亲 ， 尤 其 是 在 我 们 的 好 朋 友 们 还 没 有 完 全 理 解 那 片 苦 心 的 基 础 上 … …";
				}
				else if (GlobalScript.inst.gameState.allcountries[7].isNATO)
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1575], "\n");
				}
				else if (GlobalScript.inst.gameState.allcountries[1].isASEAN)
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1576], "\n", (GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.influencePRC + GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power) ? GlobalScript.inst.new_events_text[1577] : GlobalScript.inst.new_events_text[1578]);
				}
				else if (!GlobalScript.inst.gameState.allcountries[51].isNATO)
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1604], "\n", (GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC && GlobalScript.inst.gameState.empires[1].now_leader != 6) ? GlobalScript.inst.new_events_text[1606] : GlobalScript.inst.new_events_text[1605]);
				}
				else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power <= 80 && GlobalScript.inst.gameState.empires[1].now_leader != 6)
				{
					fake_text = " 时 代 在 改 变 ， 冷 战 正 在 过 去 … … 随 即 以 对 抗 一 个 新 兴 力 量 重 新 开 始 。 即 使 是20 世 纪 最 顽 固 的 敌 人 — — 苏 联 和 美 国 ， 也 不 得 不 成 为 结 拜 兄 弟 ， 再 度 像 第 二 次 世 界 大 战 一 样 ， 团 结 起 来 对 抗 共 同 的 敌 人 — — 中 国 — — 现 代 世 界 的 新 霸 主 ， 它 从 灰 烬 中 崛 起 ， 并 迅 速 宣 称 要 主 宰 世 界 。 为 了 挽 救 其 残 余 的 影 响 力 ， 曾 经 的 敌 人 们 开 始 了 新 一 轮 的 军 备 竞 赛 ： 北 约 和 华 约 进 行 联 合 演 习 ， 苏 联 和 美 国 每 年 的 军 事 预 算 翻 一 番 ， 在 美 国 和 苏 联 科 学 家 的 共 同 努 力 下 ， 新 型 核 武 器 被 开 发 出 来 。 一 场 新 的 大 规 模 战 争 似 乎 只 是 一 个 时 间 问 题 ， 但 人 类 会 在 这 场 战 争 中 幸 存 下 来 吗 ？";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(17);
					}
				}
				else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC)
				{
					fake_text = " 冷 战 即 将 结 束 ， 苏 联 似 乎 将 在 这 场 长 期 的 对 抗 中 获 胜 ， 成 为 世 界 上 最 具 影 响 力 的 力 量 。 美 国 正 在 迅 速 失 去 对 世 界 的 影 响 ， 美 元 体 系 正 在 瓦 解 ， 北 约 成 员 国 正 在 奉 行 越 来 越 独 立 的 政 策 ， 该 组 织 本 身 也 即 将 解 体 。 最 后 ， 不 得 不 提 ， 这 是 因 为 中 国 积 极 干 预 世 界 政 治 ， 逐 渐 消 除 美 国 的 影 响 所 导 致 的 。";
				}
				else if (GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.influencePRC)
				{
					fake_text = " 过 去 几 年 对 苏 联 来 说 并 不 是 徒 劳 的 — — 他 们 对 世 界 的 影 响 已 经 大 大 扩 大 ， 而 且 看 起 来 他 们 将 在 冷 战 中 取 得 胜 利 — — 美 国 正 在 失 去 影 响 力 ， 世 界 共 产 主 义 运 动 正 在 发 展 ， 北 约 成 员 国 正 在 奉 行 越 来 越 独 立 的 政 策 。 而 中 华 人 民 共 和 国 ， 尽 管 有 一 定 的 外 交 政 策 活 动 ， 但 始 终 未 能 进 入 超 级 大 国 的 行 列 ， 仍 落 后 于 美 苏 两 国 ， 但 局 势 迟 早 会 发 生 变 化 … …";
				}
				else if (GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.influencePRC)
				{
					fake_text = " 过 去 几 年 对 美 国 来 说 并 不 是 徒 劳 的 — — 他 们 对 世 界 的 影 响 已 经 大 大 扩 大 ， 而 且 看 起 来 他 们 将 在 冷 战 中 取 得 胜 利 — — 苏 联 正 在 失 去 对 世 界 的 影 响 ， 包 括 社 会 主 义 阵 营 ， 世 界 共 产 主 义 运 动 正 在 萎 缩 。 而 中 华 人 民 共 和 国 ， 尽 管 有 一 定 的 外 交 政 策 活 动 ， 但 始 终 未 能 进 入 超 级 大 国 的 行 列 ， 仍 落 后 于 美 苏 两 国 ， 但 局 势 迟 早 会 发 生 变 化 … …";
				}
				else if (GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.influencePRC)
				{
					fake_text = " 冷 战 即 将 结 束 ， 美 国 似 乎 将 在 这 场 长 期 的 对 抗 中 获 胜 ， 成 为 世 界 上 最 具 影 响 力 的 力 量 。 苏 联 正 在 失 去 对 世 界 的 影 响 ， 包 括 正 在 奉 行 日 益 独 立 政 策 的 社 会 主 义 阵 营 ， 以 及 对 世 界 共 产 主 义 运 动 的 影 响 。 最 后 ， 不 得 不 提 ， 这 是 因 为 中 国 积 极 干 预 世 界 政 治 ， 逐 渐 消 除 苏 联 的 影 响 所 导 致 的 。";
				}
				else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power)
				{
					fake_text = " 星 星 之 火 ， 可 以 燎 原 。 昔 日 仅 能 在 零 星 的 毛 派 游 击 队 内 寻 得 支 持 者 的 中 国 ， 如 今 则 得 已 砸 碎 锁 链 ， 闯 出 围 城 ， 并 成 为 世 界 超 级 大 国 。 其 在 国 际 组 织 和 各 国 内 的 众 多 追 随 者 ， 都 是 其 庞 大 影 响 力 的 来 源 与 证 明 。|| 苏 联 和 美 国 之 间 的 对 峙 正 在 逐 渐 淡 入 幕 后 ， 但 似 乎 苏 联 将 成 为 胜 利 者 — — 美 国 正 在 迅 速 失 去 对 世 界 的 影 响 ， 美 元 体 系 正 在 瓦 解 ， 北 约 成 员 国 正 在 追 求 日 益 独 立 的 政 策 ， 该 组 织 本 身 也 即 将 解 体 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(33);
					}
				}
				else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power)
				{
					fake_text = " 星 星 之 火 ， 可 以 燎 原 。 昔 日 仅 能 在 零 星 的 毛 派 游 击 队 内 寻 得 支 持 者 的 中 国 ， 如 今 则 得 已 砸 碎 锁 链 ， 闯 出 围 城 ， 并 成 为 世 界 超 级 大 国 。 其 在 国 际 组 织 和 各 国 内 的 众 多 追 随 者 ， 都 是 其 庞 大 影 响 力 的 来 源 与 证 明 。|| 苏 联 和 美 国 之 间 的 对 峙 正 在 逐 渐 淡 入 幕 后 ， 但 似 乎 美 国 将 成 为 胜 利 者 — — 苏 联 对 世 界 共 产 主 义 运 动 和 简 单 的 反 美 运 动 失 去 了 任 何 影 响 力 ， 社 会 主 义 阵 营 在 我 们 眼 前 崩 溃 ， 其 遗 产 很 可 能 在 中 国 和 美 国 之 间 分 割 ， 而 我 们 将 得 到 最 好 的 那 部 分 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(33);
					}
				}
				if (!GlobalScript.inst.gameState.allcountries[0].isEU)
				{
					fake_text += string.Format(GlobalScript.inst.new_events_text[1579], "\n");
				}
				if (GlobalScript.inst.gameState.allcountries[85].isSocEU)
				{
					fake_text += string.Format(GlobalScript.inst.new_events_text[1580], "\n");
				}
				if (GlobalScript.inst.gameState.IndOpp)
				{
					fake_text += "||苏 联 的 崩 溃 使 得 南 斯 拉 夫 失 去 了 对 西 方 的 价 值 ， 铁 托 引 以 为 豪 的 “ 社 会 主 义 自 治 ” 也 发 生 了 总 崩 溃 : 西 方 的 资 本 家 们 首 先 嗅 到 了 味 道 不 对 ， 迅 速 撤 走 了 投 资 ； 经 济 的 下 滑 激 化 了 民 族 矛 盾 ， 各 地 要 求 独 立 的 呼 声 也 愈 发 高 涨 。 最 终 ， 铁 托 的 个 人 威 望 也 无 法 维 持 这 个 “ 一 战 的 畸 形 怪 物 ” 的 凝 聚 力 ， 南 斯 拉 夫 爆 发 了 旷 日 持 久 的 内 战 ， 我 们 尚 不 知 内 战 何 时 结 束 … … ";
				}
				else if (GlobalScript.inst.gameState.allcountries[15].Vyshi && GlobalScript.inst.gameState.allcountries[15].isEU && GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 14)
				{
					fake_text += string.Format(GlobalScript.inst.new_events_text[1581], "\n");
				}
				else if (GlobalScript.inst.gameState.allcountries[20].puppetOf == 15)
				{
					fake_text += string.Format(GlobalScript.inst.new_events_text[1582], "\n");
				}
				else if (GlobalScript.inst.gameState.allcountries[20].spec == 1 && GlobalScript.inst.gameState.influencePRC >= 750 && GlobalScript.inst.gameState.allcountries[20].SubGosstroy == 0 && GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 0 && GlobalScript.inst.gameState.allcountries[6].proprc && GlobalScript.inst.gameState.allcountries[5].SubGosstroy == 0 && GlobalScript.inst.gameState.allcountries[45].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[45].proprc)
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(154);
					}
					fake_text += " ||巴 尔 干 的 革 命 者 们 在 我 们 的 帮 助 下 聚 沙 成 塔 。 最 为 困 难 的 领 土 问 题 在 各 退 一 步 后 得 到 了 化 解 ， 保 加 利 亚 放 弃 了 对 马 其 顿 的 宣 称 ， 在 事 实 上 承 认 了 马 其 顿 民 族 的 存 在 ； 阿 尔 巴 尼 亚 放 弃 了 对 科 索 沃 的 索 取 ， 转 而 得 到 了 塞 尔 维 亚 对 科 索 沃 高 度 自 治 的 保 障 ； 希 腊 也 确 保 了 阿 尔 巴 尼 亚 不 会 入 侵 北 伊 庇 鲁 斯 ， 各 国 都 签 订 了 备 忘 录 ， 巴 尔 干 的 硝 烟 正 在 散 去 ， 长 久 的 和 平 在 地 平 线 上 出 现 了 。 各 国 的 共 产 党 ， 劳 动 党 和 工 人 党 就 组 建 统 一 的 巴 尔 干 联 盟 共 产 党 达 成 了 协 议 。 一 套 类 似 于 前 南 斯 拉 夫 的 轮 值 主 席 国 机 制 也 被 确 立 起 来 。 第 一 任 主 席 是 罗 马 尼 亚 人 民 共 和 国 主 席 团 主 席 阿 波 斯 托 尔 ， 阿 尔 巴 尼 亚 人 民 社 会 主 义 共 和 国 部 长 会 议 主 席 查 尔 查 尼 ； 保 加 利 亚 人 民 共 和 国 部 长 会 议 主 席 巴 列 夫 和 南 斯 拉 夫 军 事 委 员 会 副 主 席 布 兰 科 · 马 穆 拉 担 任 副 主 席 。 各 国 的 武 装 力 量 也 得 到 了 整 合 与 统 一 ， 巴 尔 干 联 合 人 民 军 司 令 部 在 贝 尔 格 莱 德 成 立 了 。 新 成 立 的 人 民 军 宣 布 不 会 采 取 暴 力 行 动 干 涉 世 界 格 局 ， 而 是 积 极 投 身 维 和 行 动 中 ， 从 而 维 护 世 界 焦 点 地 区 的 稳 定 。 各 国 在 各 方 面 的 步 调 上 越 发 一 致 。 在 新 世 纪 初 ， 各 个 加 盟 国 正 式 宣 布 组 成 统 一 的 巴 尔 干 革 命 共 和 国 联 邦 ， 自 动 继 承 各 个 成 员 国 在 国 际 组 织 里 的 合 法 席 位 。 尽 管 旧 世 界 的 超 级 大 国 们 对 这 个 联 邦 能 维 持 多 久 保 持 怀 疑 ， 但 他 们 还 是 承 认 了 其 对 欧 洲 地 区 和 平 至 关 重 要 的 贡 献 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[20].spec == 1 && GlobalScript.inst.gameState.influencePRC >= 750)
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(154);
					}
					fake_text += string.Format(GlobalScript.inst.new_events_text[1583], "\n");
				}
				else if (GlobalScript.inst.gameState.allcountries[20].spec == 1 && GlobalScript.inst.gameState.influencePRC < 750)
				{
					fake_text += string.Format(GlobalScript.inst.new_events_text[1584], "\n");
				}
				else if (GlobalScript.inst.gameState.allcountries[15].isOVD && GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 16 && GlobalScript.inst.gameState.allcountries[15].prosov)
				{
					fake_text += "|| 8 0 年 代 是 南 斯 拉 夫 的 困 难 时 期 ： 巨 额 外 债 ， 铁 托 经 济 政 策 的 恶 果 ， 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 ， 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 最 终 ， 在 罗 曼 诺 夫 慷 慨 的 经 济 与 外 交 帮 助 下 ， 华 约 里 的 南 斯 拉 夫 转 向 了 重 新 集 中 化 国 家 的 尝 试 。 在 各 个 领 域 上 ，   消 费 水 平 的 下 降 和 劳 动 - 财 政 纪 律 的 强 调 拯 救 了 摇 摇 欲 坠 的 财 政 。 现 在 的 ， 重 新 集 中 化 的 南 斯 拉 夫 的 政 治 结 构 更 看 上 去 像 是 5 0 年 代 的 苏 联 ， 南 斯 拉 夫 认 同 继 续 攀 升 - 甚 至 新 生 的 科 索 沃 社 会 主 义 共 和 国 里 都 出 现 了 南 斯 拉 夫 认 同 ！ “ 工 人 自 治 ” 的 时 代 结 束 了 ， 但 社 会 主 义 的 南 斯 拉 夫 迎 来 了 新 生 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[15].isSocEU && GlobalScript.inst.gameState.allcountries[21].isSocEU)
				{
					fake_text += "|| 通 过 背 靠 中 国 援 助 与 加 入 欧 洲 社 会 主 义 联 盟 ， 南 斯 拉 夫 得 以 弥 补 国 内 的 外 债 亏 空 ， 并 通 过 参 与 经 济 一 体 化 逐 渐 扭 转 颓 势 ， 逐 步 走 出 8 0 年 代 的 困 难 时 期 。 国 内 的 民 族 主 义 情 绪 与 相 关 势 力 也 通 过 引 入 意 大 利 、 希 腊 等 地 中 海 国 家 的 力 量 平 衡 实 现 了 很 好 的 遏 制 ， 事 实 上 填 补 了 铁 托 离 去 后 所 缺 失 的 最 高 权 威 。 我 们 可 说 南 斯 拉 夫 仍 走 在 铁 托 主 义 的 路 上 ， 虽 然 并 非 原 汁 原 味 。 出 于 加 入 新 联 盟 与 便 利 债 务 偿 付 的 需 要 ， 该 国 开 始 实 行 另 类 的 分 权 改 革 ， 即 在 所 谓 “ 改 革 委 员 会 ” 旗 下 建 构 管 制 资 本 主 义 ： 前 者 成 为 了 类 似 国 家 计 划 委 员 会 的 架 构 ， 负 责 制 定 全 国 产 品 标 准 ， 宏 观 条 款 各 共 和 国 中 的 经 济 获 得 ； 在 它 的 干 预 下 ， 国 有 企 业 被 改 组 为 人 民 合 资 股 份 公 司 、 工 人 委 员 会 职 权 得 到 拓 展 、 农 业 与 商 品 生 产 则 转 移 至 合 作 社 。 新 时 代 的 南 斯 拉 夫 式 自 治 与 其 繁 荣 就 此 来 临 ， 并 在 不 久 后 迎 来 了 自 己 的 正 统 继 承 人 ： 即 新 任 南 斯 拉 夫 总 统 ， 铁 托 元 帅 的 孙 子 ， 正 热 心 推 进 南 斯 拉 夫 民 族 构 建 的 约 斯 卡 · 布 罗 兹 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[15].isOVD && GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 10 && GlobalScript.inst.gameState.allcountries[15].prosov)
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 ： 巨 额 外 债 ， 铁 托 经 济 政 策 的 恶 果 ， 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 ， 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 意 料 不 到 的 转 变 发 生 于 政 治 领 域 。 新 的 南 斯 拉 夫 军 政 府 启 发 于 中 国 文 化 大 革 命 中 发 动 群 众 的 经 验 ， 但 是 内 核 基 于 大 赛 族 主 义 的 复 苏 - 利 用 铁 托 调 和 民 族 矛 盾 ， 铁 托 经 济 政 策 导 致 的 贫 富 差 距 和 高 失 业 率 导 致 的 不 满 ， “ 反 官 僚 革 命 ” 在 一 个 被 逐 渐 塞 族 化 的 军 队 结 构 监 管 下 进 行 。 对 于 贝 尔 格 莱 德 来 说 ， 这 种 革 命 在 波 斯 尼 亚 人 和 马 其 顿 人 之 间 获 得 了 部 分 支 持 者 ， 在 斯 洛 文 尼 亚 和 克 罗 地 亚 ， 人 们 躲 进 厨 房 里 抱 怨 。 问 题 最 严 重 的 地 方 在 科 索 沃 ， 那 里 “ 反 官 僚 革 命 者 ” 们 的 围 绕 民 族 矛 盾 的 冲 突 正 在 血 洗 街 头 。 与 此 同 时 ， 在 泛 斯 拉 夫 主 义 而 不 是 国 际 主 义 的 名 号 下 ， 新 的 南 斯 拉 夫 军 政 府 与 罗 曼 诺 夫 苏 联 的 关 系 急 剧 靠 近 。 只 有 时 间 才 会 告 诉 我 们 未 来 愈 演 愈 烈 的 民 族 - 民 粹 主 义 会 带 领 南 斯 拉 夫 走 向 何 方 … …";
				}
				else if (GlobalScript.inst.gameState.allcountries[15].econ && GlobalScript.inst.gameState.allcountries[15].Gosstroy == 0 && GlobalScript.inst.gameState.allcountries[7].isNATO)
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 : 巨 额 外 债 、 铁 托 经 济 政 策 的 后 果 、 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 、 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 在 中 国 与 改 革 重 组 后 的 北 约 均 卷 入 日 益 升 级 的 冲 突 后 。 西 方 国 家 不 敢 干 预 南 斯 拉 夫 社 会 主 义 联 邦 共 和 国 的 内 政 ， 并 将 自 己 的 活 动 限 制 在 “ 对 该 国 实 施 反 民 主 与 侵 犯 少 数 民 族 权 益 的 行 为 表 示 严 重 关 切 ” 的 评 论 内 。 因 此 ， 南 斯 拉 夫 社 会 主 义 联 邦 共 和 国 得 以 进 一 步 深 化 与 中 国 的 军 事 与 经 济 合 作 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(65);
					}
				}
				else if (GlobalScript.inst.gameState.completedDecisions[9] && GlobalScript.inst.gameState.allcountries[15].Gosstroy == 0 && GlobalScript.inst.gameState.empires[1].now_leader == 6 && (GlobalScript.inst.gameState.empires[1].power <= GlobalScript.inst.gameState.empires[0].power || GlobalScript.inst.gameState.empires[1].power <= GlobalScript.inst.gameState.influencePRC) && !GlobalScript.inst.gameState.modifies[3].active && GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.data[14] < 3 && GlobalScript.inst.gameState.data[16] < 12)
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 : 巨 额 外 债 、 铁 托 经 济 政 策 的 后 果 、 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 、 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 美 国 人 支 持 分 裂 分 子 的 企 图 导 致 了 他 们 与 南 斯 拉 夫 关 系 的 恶 化 ， 这 便 是 贝 尔 格 莱 德 最 终 选 择 越 加 同 俄 罗 斯 与 中 国 接 近 ， 并 完 全 加 入 1 6 + 1 机 制 的 原 因 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(65);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[15].Vyshi)
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 ： 巨 额 外 债 、 铁 托 经 济 政 策 的 后 果 、 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 、 生 活 水 平 下 降 ，美 国 对 于 南 斯 拉夫 慷 慨 的 援 助 以 及 支 持 南 斯 拉 夫 内 部 改 革 派 的 企 图 引 爆 了 共 和 国 内 的 化 学 反 应 ： 在 马 尔 科 维 奇 的 休 克 疗 法 与 斯 洛 文 尼 亚 提 倡 的 邦 联 化 改 革 之 后 ， 激 进 民 族 主 义 者 在 各 大 共 和 国 ， 包 括 塞 尔 维 亚 掌 权 。 一 场 内 战 在 克 罗 地 亚 和 波 黑 爆 发 了 ， 而 且 伴 随 着 联 邦 权 威 的 崩 溃 ， 新 法 西 斯 主 义 者 ， 前 共 产 主 义 者 和 原 教 义 主 义 者 形 成 的 民 族 地 方 武 装 开 始 在 各 共 和 国 内 崛 起 ， 与 本 土 政 府 军 对 峙 ， 掀 起 种 族 灭 绝 的 浪 潮 。 由 北 约 形 成 的 维 和 部 队 被 派 遣 负 责 维 护 部 分 城 市 的 安 全 以 及 控 制 难 民 局 势 ， 但 在 可 见 的 未 来 ， 克 罗 地 亚 ， 斯 洛 文 尼 亚 ， 塞 尔 维 亚 和 黑 山 等 国 将 持 续 作 为 失 败 国 家 存 在 ， 而 在 波 斯 尼 亚 不 存 在 一 个 被 国 际 社 会 承 认 的 政 府 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[15].isSEV && (GlobalScript.inst.gameState.empires[1].now_leader != 6 || (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.influencePRC)))
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 转 折 点 ： 巨 额 的 外 债 、 铁 托 经 济 政 策 的 后 果 、 为 了 改 善 局 势 而 推 行 的 市 场 改 革 ， 这 些 本 会 导 致 灾 难 。 但 是 ， 多 亏 了 社 会 主 义 阵 营 及 时 的 帮 助 ， 灾 难 得 以 避 免 。 南 斯 拉 夫 决 定 正 式 加 入 经 互 会 ， 并 在 社 会 主 义 阵 营 的 合 作 、 价 格 优 惠 和 苏 联 援 助 的 支 持 下 ， 经 济 开 始 复 兴 ， 并 逐 渐 付 清 了 自 己 的 债 务 。 克 格 勃 的 援 助 也 帮 助 南 斯 拉 夫 镇 压 了 民 族 主 义 者 和 自 由 主 义 者 。 当 然 ， 这 使 得 南 斯 拉 夫 远 离 西 方 ， 并 开 始 与 苏 联 和 解 。 尽 管 南 斯 拉 夫 尝 试 维 持 军 事 中 立 ， 但 事 实 上 它 已 经 完 全 成 为 了 社 会 主 义 阵 营 的 一 部 分 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(65);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 0)
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 ： 巨 额 外 债 ， 铁 托 经 济 政 策 的 恶 果 ， 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 ， 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 最 终 ， 在 中 国 的 帮 助 下 ， 南 斯 拉 夫 转 向 了 重 新 集 中 化 国 家 的 尝 试 。 在 各 个 领 域 上 ，   消 费 水 平 的 下 降 和 劳 动 - 财 政 纪 律 的 强 调 拯 救 了 摇 摇 欲 坠 的 财 政 。 现 在 的 ， 重 新 集 中 化 的 南 斯 拉 夫 的 政 治 结 构 更 看 上 去 像 是 5 0 年 代 的 苏 联 ， 南 斯 拉 夫 认 同 继 续 攀 升 - 甚 至 新 生 的 科 索 沃 社 会 主 义 共 和 国 里 都 出 现 了 南 斯 拉 夫 认 同 ！ “ 工 人 自 治 ” 的 时 代 结 束 了 ， 但 社 会 主 义 的 南 斯 拉 夫 迎 来 了 新 生 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(65);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 10)
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 ： 巨 额 外 债 ， 铁 托 经 济 政 策 的 恶 果 ， 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 ， 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 意 料 不 到 的 转 变 发 生 于 政 治 领 域 。 新 的 南 斯 拉 夫 军 政 府 启 发 于 中 国 文 化 大 革 命 中 发 动 群 众 的 经 验 ， 但 是 内 核 基 于 大 赛 族 主 义 的 复 苏 - 利 用 铁 托 调 和 民 族 矛 盾 ， 铁 托 经 济 政 策 导 致 的 贫 富 差 距 和 高 失 业 率 导 致 的 不 满 ， “ 反 官 僚 革 命 ” 在 一 个 被 逐 渐 塞 族 化 的 军 队 结 构 监 管 下 进 行 ， 对 于 贝 尔 格 莱 德 来 说 ， 这 种 革 命 在 波 斯 尼 亚 人 和 马 其 顿 人 之 间 获 得 了 部 分 支 持 者 ， 在 斯 洛 文 尼 亚 和 克 罗 地 亚 ， 人 们 躲 进 厨 房 里 抱 怨 。 问 题 最 严 重 的 地 方 在 科 索 沃 ， 那 里 “ 反 官 僚 革 命 者 ” 们 围 绕 民 族 矛 盾 的 冲 突 正 在 血 洗 街 头 。 只 有 时 间 才 会 告 诉 我 们 未 来 愈 演 愈 烈 的 民 族 - 民 粹 主 义 会 带 领 南 斯 拉 夫 走 向 何 方 … …";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(65);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[21].isSocEU)
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 转 折 点 ： 巨 额 的 外 债 、 铁 托 经 济 政 策 的 后 果 、 为 了 改 善 局 势 而 推 行 的 市 场 改 革 ， 这 些 本 会 导 致 灾 难 。 但 是 ， 多 亏 了 新 生 的 欧 社 联 及 时 的 帮 助 ， 灾 难 得 以 避 免 。在 欧 洲 经 济 整 合 与 援 助 的 框 架 下，经 济 开 始 复 兴 ， 并 逐 渐 付 清 了 自 己 的 债 务 。 在 政 治 领 域 ， 各 共 和 国 民 族 主 义 情 绪 加 重 。 最 终 ， 在 各 大 共 和 国 粉 墨 登 场 的 新 左 翼 ， 比 如 斯 洛 文 尼 亚 的 精 神 分 析 学 派 马 克 思 主 义 者 和 克 罗 地 亚 的 “ 群 众 社 会 运 动 ” 和 平 地 分 手 了 作 为 国 家 概 念 的 南 斯 拉 夫 ， 转 而 将 南 斯 拉 夫 变 为 数 个 主 权 共 和 国 的 区 域 共 同 体 ， 这 些 共 和 国 重 申 反 对 种 族 民 族 主 义 ， 民 主 自 由 ， 中 立 与 社 会 主 义 的 纲 领 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[15].Torg && (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power || GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[0].power || (GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.empires[1].power + GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[0].power)))
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 ： 巨 额 外 债 、 铁 托 经 济 政 策 的 后 果 、 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 、 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 然 而 ， 南 斯 拉 夫 仍 然 设 法 挺 过 了 这 些 考 验 ， 特 别 是 由 于 我 们 的 帮 助 。 市 场 改 革 的 规 模 没 有 这 么 大 ， 自 由 主 义 的 政 治 改 革 很 快 就 遭 到 军 方 和 保 守 派 的 破 坏 和 打 压 。 然 而 ， 内 战 仍 然 是 不 可 避 免 的 ， 斯 洛 文 尼 亚 和 克 罗 地 亚 仍 然 能 够 通 过 其 努 力 获 得 独 立 ， 但 在 其 他 地 区 ， 叛 乱 很 快 被 南 斯 拉 夫 人 民 军 镇 压 。 美 国 人 支 持 分 裂 分 子 的 企 图 导 致 了 他 们 与 南 斯 拉 夫 关 系 的 恶 化 ， 而 南 斯 拉 夫 每 年 都 在 与 苏 联 和 中 国 建 立 新 的 合 作 关 系 。 尽 管 南 斯 拉 夫 的 面 积 缩 小 了 ， 但 它 仍 然 存 在 。";
				}
				else
				{
					fake_text += "||80 年 代 是 南 斯 拉 夫 的 困 难 时 期 ： 巨 额 外 债 、 铁 托 经 济 政 策 的 后 果 、 试 图 通 过 市 场 改 革 改 善 局 势 的 努 力 以 及 缺 乏 有 影 响 力 的 领 导 人 ， 导 致 经 济 形 势 恶 化 、 生 活 水 平 下 降 ， 结 果 导 致 各 共 和 国 民 族 主 义 情 绪 加 剧 。 并 且 政 府 无 法 稳 定 局 势 ， 最 终 导 致 军 方 势 力 夺 取 政 权 ， 并 导 致 中 央 政 府 （ 实 际 上 很 快 被 证 明 由 塞 尔 维 亚 和 黑 山 所 代 表 ） 与 克 罗 地 亚 、 斯 洛 文 尼 亚 和 阿 尔 巴 尼 亚 民 族 主 义 者 之 间 爆 发 内 战 。 看 起 来 还 不 知 道 谁 会 取 得 胜 利 ， 直 到 北 约 部 队 通 过 对 塞 尔 维 亚 的 行 动 结 束 了 战 争 ， 在 南 斯 拉 夫 的 历 史 上 也 再 也 没 有 了 战 争 — — 这 个 巴 尔 干 国 家 不 复 存 在 了 ， 而 她 的 几 乎 所 有 前 共 和 国 现 在 都 倒 向 西 方 和 美 国 。";
				}
			}
			else if (number_of_e == 7)
			{
				name.text = " 立 足 当 下 ， 只 争 朝 夕";
				if (GlobalScript.inst.gameState.data[5] <= 400)
				{
					fake_text = " 你 的 政 府 并 没 有 给 中 国 普 通 公 民 的 生 活 带 来 多 少 改 善 — — 我 们 的 生 活 水 平 仍 然 像70 年 代 初 期 一 样 。 有 时 仍 然 会 爆 发 粮 食 危 机 ， 村 民 们 不 知 道 什 么 是 现 代 生 活 的 便 利 ， 而 在 城 市 里 情 况 也 不 是 太 好 — — 普 通 人 生 活 在 设 施 简 陋 的 房 屋 中 ， 一 般 是 在 公 共 房 屋 和 廉 租 房 里 ， 消 费 品 也 很 少 ， 并 且 只 有 高 层 政 府 官 员 和 企 业 主 管 才 能 得 以 享 受 到 奢 侈 品 。";
				}
				else if (GlobalScript.inst.gameState.data[5] <= 700)
				{
					fake_text = " 中 国 人 民 生 活 水 平 的 不 断 提 高 是 你 执 政 时 期 的 标 志 性 成 就 。 你 终 于 解 决 了 粮 食 的 供 给 问 题 ， 也 使 大 多 数 人 能 够 享 受 到 奢 侈 品 。 对 许 多 中 国 人 来 说 ， 城 市 中 的 生 活 条 件 也 逐 步 得 到 改 善 ， 尽 管 许 多 工 人 现 在 仍 然 不 得 不 住 在 公 共 住 房 和 廉 租 房 中 。 农 村 的 情 况 更 差 些 ， 但 是 我 们 适 时 加 强 了 对 农 村 基 础 设 施 建 设 的 投 入 ， 在 村 庄 里 建 造 了 现 代 化 房 屋 ， 也 逐 步 向 他 们 提 供 现 代 通 讯 服 务 。 我 们 很 快 就 会 达 到 日 本 的 生 活 水 平 。 人 民 将 永 远 铭 记 你 对 他 们 美 好 的 未 来 作 出 的 贡 献 。";
				}
				else if (GlobalScript.inst.gameState.data[5] <= 1100)
				{
					fake_text = " 中 国 人 民 生 活 水 平 的 飞 跃 是 你 执 政 时 期 的 标 志 性 成 就 — — 你 不 仅 解 决 了 粮 食 供 应 问 题 ， 而 且 我 们 几 乎 能 让 每 个 人 享 受 到 富 裕 阶 级 的 商 品 ， 越 来 越 多 的 人 也 能 够 购 买 奢 侈 品 。 我 们 积 极 克 服 城 乡 之 间 的 差 距 ， 在 广 大 农 村 地 区 内 普 及 电 气 化 与 现 代 通 信 服 务 并 建 设 现 代 化 住 宅 。 现 在 ， 每 一 个 勤 劳 的 工 人 都 能 有 所 居 、 得 温 饱 ， 在 生 活 水 平 上 ， 中 国 已 超 过 了 包 括 日 本 在 内 的 所 有 亚 洲 国 家 ， 对 人 民 来 说 ， 你 将 永 远 是 给 中 国 带 来 新 发 展 和 新 生 活 的 敬 爱 的 统 治 者 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(47);
					}
				}
				else
				{
					fake_text = " 中 国 人 民 生 活 水 平 的 大 跃 进 是 你 执 政 时 期 的 标 志 性 成 就 — — 你 的 卓 越 统 治 使 我 们 能 够 创 造 繁 荣 的 经 济 和 良 好 的 社 会 保 障 ， 让 我 们 所 有 的 人 民 都 生 活 在 奢 侈 和 繁 荣 之 中 。 我 国 的 生 活 水 平 居 世 界 第 一 ， 甚 至 领 先 于 以 高 福 利 著 称 的 北 欧 国 家 ： 我 们 已 经 几 乎 消 融 了 城 乡 之 间 的 差 别 ， 在 广 大 乡 村 地 区 我 们 不 仅 建 设 了 发 达 的 基 础 设 施 ， 例 如 和 城 市 相 媲 美 的 电 力 系 统 与 自 来 水 网 络 系 统 和 物 流 系 统 等 ， 还 建 设 了 舒 适 的 现 代 化 住 房 。 乡 村 地 区 的 居 民 们 的 收 入 也 和 城 市 里 的 趋 同 ， 也 可 以 享 受 与 城 市 居 民 一 样 的 消 费 品 供 应 ， 我 们 可 以 自 豪 的 说 ， 城 乡 二 元 结 构 体 制 已 经 成 为 了 历 史 过 去 式 。";
					if (GlobalScript.inst.gameState.modifies[11].active)
					{
						fake_text += " ||得 益 于 我 们 的 自 动 化 系 统 ， 我 们 开 始 尝 试 共 产 主 义 中 的 按 需 分 配 原 则 ： 得 益 于 我 们 的 自 动 化 系 统 的 消 费 品 预 测 分 析 模 型 ， 越 来 越 多 的 消 费 品 开 始 尝 试 实 行 按 需 分 配 ， 这 将 是 共 产 主 义 的 开 端 。 与 此 同 时 ， 我 们 开 始 渐 渐 缩 短 我 们 的 工 作 时 长 ， 也 正 在 制 定 更 多 的 假 日 ， 这 使 得 我 们 的 劳 动 者 有 着 充 裕 的 闲 暇 时 间 ， 也 是 我 们 进 行 自 由 而 又 全 面 的 发 展 的 前 提 。 我 们 正 在 迈 出 从 必 然 王 国 走 向 自 然 王 国 的 第 一 步 — — 关 键 而 又 踏 实 的 一 步 。";
					}
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(47);
					}
				}
				if (GlobalScript.inst.gameState.data[13] <= 400)
				{
					fake_text += " ||“ 最 好 的 管 理 便 是 不 做 管 理 ” — — 这 句 笑 话 最 能 概 括 我 国 农 业 的 现 状 。 即 便 是 在 农 业 战 线 上 基 本 失 控 的 蒋 介 石 时 代 ， 也 无 法 同 现 任 政 府 的 “ 英 明 领 导 ” 相 比 拟 ： 国 营 农 场 纷 纷 破 产 ， 生 产 合 作 社 萎 靡 不 振 ， 仅 有 的 自 耕 农 也 因 缺 乏 国 家 帮 扶 而 不 得 不 靠 天 吃 饭 ， 私 营 投 资 者 更 是 不 敢 进 入 这 片 废 墟 。 缺 乏 有 力 经 营 主 体 与 投 资 的 局 面 导 致 农 业 的 上 下 游 产 业 都 显 得 万 马 齐 喑 。 最 终 导 致 曾 是 东 亚 粮 仓 的 中 国 成 了 商 品 粮 进 口 额 堪 比 日 本 ， 营 养 不 良 率 高 于 印 度 的 失 败 国 家 ， 并 时 刻 遭 受 饥 荒 的 威 胁 。";
				}
				else if (GlobalScript.inst.gameState.data[13] <= 700)
				{
					fake_text += " ||中 国 现 任 政 府 有 条 不 紊 地 推 进 农 业 发 展 计 划 。 通 过 发 展 农 业 生 产 服 务 、 修 缮 基 础 设 施 、 改 进 农 民 培 训 与 发 放 生 产 补 贴 等 一 系 列 手 段 。 多 少 改 善 了 国 内 农 业 的 整 体 面 貌 — — 商 品 粮 市 场 物 资 供 应 充 盈 ， 粮 价 大 体 保 持 稳 定 ； 以 东 北 、 华 北 为 代 表 的 平 原 地 带 甚 至 实 现 了 适 度 规 模 经 营 与 一 定 程 度 机 械 化 。 农 民 本 身 的 收 入 也 得 以 缓 缓 追 上 产 业 工 人 。 中 国 的 粮 食 自 给 率 正 稳 步 而 充 实 的 提 高 。 即 便 同 发 达 国 家 相 比 还 有 不 少 进 步 空 间 ， 农 村 、 农 业 与 城 市 产 业 间 的 差 距 依 然 悬 殊 。 可 至 少 ， 我 们 确 实 迈 出 了 向 好 方 向 改 变 的 第 一 步 。";
				}
				else if (GlobalScript.inst.gameState.data[13] <= 1100)
				{
					fake_text += " ||我 国 农 民 将 铭 记 您 为 他 们 带 来 的 福 音 。 这 些 年 来 ， 您 以 坚 实 有 力 的 策 略 彻 底 盘 活 了 中 国 农 业 格 局 ： 农 业 化 工 产 业 、 育 种 机 构 与 基 础 设 施 的 迅 猛 发 展 最 大 限 度 地 实 现 了 大 规 模 生 产 与 精 耕 细 作 两 类 模 式 的 结 合 。 我 国 农 民 阶 级 也 通 过 推 广 农 用 机 械 与 加 强 培 训 的 方 式 掌 握 了 现 代 化 生 产 方 式 ， 并 在 发 达 的 农 业 物 流 与 财 政 支 持 体 系 下 一 边 赚 得 盆 满 钵 满 ， 一 边 为 我 国 各 类 农 产 品 市 场 的 繁 荣 提 供 助 力 。 中 国 经 济 本 身 也 因 此 获 益 无 穷 ： 中 国 的 高 质 量 农 产 品 已 在 传 统 人 口 大 洲 亚 洲 与 非 洲 打 开 局 面 ， 甚 至 能 同 传 统 农 业 强 国 美 国 与 加 拿 大 的 品 类 一 较 高 下 。";
				}
				else
				{
					fake_text += " ||人 民 将 铭 记 您 为 他 们 带 来 的 福 音 。 这 些 年 来 ， 您 以 坚 实 有 力 的 策 略 彻 底 盘 活 了 中 国 农 业 格 局 ， 甚 至 实 现 弯 道 超 车 ： 如 今 的 我 国 农 业 已 在 各 方 面 傲 立 世 界 民 族 之 林 ， 成 为 了 世 界 的 神 农 氏 。 我 们 在 各 类 农 业 产 区 均 建 立 了 完 全 的 机 械 自 动 化 经 营 模 式 ， 并 掌 握 几 乎 所 有 农 产 品 的 高 产 、 高 质 与 抗 极 端 环 境 的 种 质 ， 让 靠 天 吃 饭 成 为 历 史 。 农 业 本 身 也 因 此 变 得 同 工 业 无 异 ， 并 成 为 了 中 国 在 世 界 范 围 内 承 担 更 大 义 务 ， 争 取 更 大 胜 利 的 全 新 增 长 点 ： 无 数 遭 受 饥 荒 之 苦 的 发 展 中 国 家 仰 赖 我 们 的 物 资 与 技 术 援 助 ， 无 数 苦 于 自 然 恶 化 的 地 区 也 正 接 受 中 国 专 家 的 帮 扶 。 我 们 以 一 项 产 业 的 勃 兴 改 变 了 世 界 ， 这 足 以 让 您 载 入 史 册 。";
				}
				if (GlobalScript.inst.gameState.data[12] <= 400)
				{
					fake_text += " ||至 少 在 经 济 层 面 ， 你 的 政 府 很 好 的 保 留 乃 至 发 扬 了 近 代 中 国 的 遗 风 ： 工 业 生 产 模 式 只 是 上 海 、 北 京 等 大 城 市 的 专 利 ； 产 业 结 构 极 不 均 衡 ； 资 本 额 与 厂 房 数 也 极 其 有 限 。 投 资 与 培 训 制 度 的 萎 靡 共 同 造 成 了 我 国 工 人 群 体 孱 弱 且 缺 乏 组 织 经 济 的 素 质 ， “ 中 国 制 造 ” 一 词 也 便 成 了 空 炮 ； 一 切 连 带 着 城 市 化 本 身 的 速 度 都 迟 滞 了 下 来 。 对 工 业 制 成 品 的 进 口 则 构 成 了 中 国 外 汇 的 主 要 支 出 。 有 人 已 顺 势 开 始 质 疑 我 国 的 “ 革 命 ” 性 质 ： 毕 竟 ， 人 们 实 在 没 法 把 一 个 勉 强 靠 原 材 料 开 采 吃 饭 的 政 权 和 “ 中 国 人 民 站 起 来 了 ” 的 豪 言 联 想 到 一 起 。";
				}
				else if (GlobalScript.inst.gameState.data[12] <= 700)
				{
					fake_text += " ||中 国 工 业 的 复 兴 成 为 了 你 执 政 时 代 的 主 旋 律 ： 我 们 不 仅 拓 展 了 原 有 重 工 业 基 地 的 规 模 ， 将 国 内 主 要 城 市 都 连 入 到 工 业 生 产 体 系 中 。 同 时 还 通 过 发 展 日 用 品 与 消 费 品 生 产 开 拓 了 全 新 路 径 ， 为 轻 工 业 领 域 培 育 了 相 当 规 模 的 劳 动 大 军 。 中 国 工 人 阶 级 群 体 得 以 随 各 地 工 厂 的 勃 兴 稳 健 地 成 长 起 来 ， 并 能 自 豪 享 受 自 己 的 劳 动 成 果 。 我 们 切 实 走 在 发 挥 规 模 效 应 与 以 量 取 胜 的 道 路 上 ， 形 成 了 门 类 比 较 齐 全 的 独 立 工 业 体 系 — — 国 际 社 会 已 将 中 国 定 为 颇 有 潜 力 的 新 兴 经 济 体 ， 在 传 统 重 化 工 业 与 小 商 品 生 产 上 的 合 作 前 景 巨 大 … … 当 然 ， 我 们 的 产 业 距 离 “ 物 美 价 廉 ” 的 目 标 还 有 很 长 的 路 要 走 。";
				}
				else if (GlobalScript.inst.gameState.data[12] <= 1100)
				{
					fake_text += " ||“ 中 国 奇 迹 ” 一 词 最 能 概 括 您 掌 舵 中 国 的 时 期 ， 以 至 连 产 量 与 产 值 都 不 足 以 概 括 我 国 在 工 业 领 域 的 一 日 千 里 ： 我 们 不 仅 确 立 起 城 市 工 业 经 济 对 全 国 的 绝 对 领 导 地 位 ， 用 史 无 前 例 的 城 市 化 创 造 了 全 球 最 大 的 产 业 工 人 群 体 ； 同 时 还 得 以 掌 握 主 流 产 业 分 类 模 式 中 的 全 部 工 业 门 类 ， 达 到 了 后 发 工 业 化 的 典 范 苏 联 与 目 前 的 世 界 工 业 强 国 美 国 所 无 法 企 及 的 成 就 。 庞 大 、 综 合 而 产 业 齐 全 的 经 济 为 中 国 未 来 的 发 展 开 辟 了 无 限 前 景 ， 事 实 上 确 定 并 巩 固 了 我 国 作 为 全 球 市 场 内 不 可 或 缺 的 经 济 引 擎 地 位 。";
				}
				else
				{
					fake_text += " ||“ 名 副 其 实 的 大 跃 进 ” 一 词 最 能 概 括 您 掌 舵 中 国 的 时 期 ， 并 足 以 让 您 的 美 名 千 古 传 颂 ： 各 领 域 生 产 自 动 化 与 信 息 技 术 革 新 的 普 及 使 得 “ 多 快 好 省 ” 成 为 了 中 国 工 业 的 常 态 ， 我 国 得 以 在 建 立 大 而 全 工 业 体 系 基 础 上 进 一 步 精 进 ， 建 立 起 有 助 于 万 众 创 新 的 生 产 环 境 。 物 流 与 生 产 领 域 的 革 命 为 中 国 创 造 了 建 立 真 正 意 义 上 完 整 工 业 体 系 的 奇 迹 ， 不 仅 实 现 了 占 据 国 际 分 工 顶 端 的 成 就 ， 还 将 不 良 资 产 与 夕 阳 产 业 的 概 念 均 化 为 历 史 ， 使 国 内 各 工 业 部 门 都 有 创 造 价 值 的 余 地 。 于 是 ， 国 际 社 会 内 的 比 较 优 势 理 论 基 本 上 成 了 “ 中 国 崛 起 ” 的 代 名 词 。 我 们 也 就 此 垄 断 了 定 义 未 来 走 向 的 权 利 … …";
				}
				if (GlobalScript.inst.gameState.data[68] <= 400)
				{
					fake_text += " ||和 以 往 相 比 ， 我 国 人 民 所 享 受 的 社 会 服 务 依 然 没 多 大 改 观 ： 运 输 晚 点 与 物 流 不 便 是 常 态 ， 商 店 门 前 总 是 排 着 长 长 的 队 伍 ， 以 至 于 不 得 不 私 下 使 用 票 证 分 配 物 资 ； 道 路 、 水 利 与 环 境 相 关 设 施 的 建 设 近 乎 停 滞 ， 维 护 人 员 也 相 当 缺 乏 ； 成 体 系 的 学 校 教 育 与 医 疗 服 务 也 基 本 是 城 市 地 区 的 专 利 。 如 此 低 效 的 服 务 足 以 击 碎 一 切 对 美 好 生 活 的 憧 憬 ， 并 成 为 阻 碍 其 他 产 业 进 一 步 发 展 的 短 板 。 有 人 说 ， 甚 至 连 老 百 姓 发 明 并 推 广 新 笑 话 的 速 度 都 比 去 政 府 办 事 的 速 度 要 来 得 快 … …";
				}
				else if (GlobalScript.inst.gameState.data[68] <= 700)
				{
					fake_text += " ||现 任 政 府 在 改 进 服 务 ， 提 升 效 率 方 面 获 得 了 不 少 进 展 ： 你 的 政 府 在 推 进 城 乡 基 础 设 施 建 设 与 抓 运 营 上 成 就 颇 丰 。 我 们 提 升 了 义 务 教 育 的 规 模 与 水 平 ， 通 过 加 强 乡 村 医 院 建 设 改 变 了 赤 脚 医 生 一 家 独 大 的 格 局 ， 还 建 立 了 颇 具 规 模 ， 兼 有 效 率 的 交 通 物 流 体 系 ， 给 凭 票 供 应 与 排 队 现 象 收 了 尾 。 下 一 步 便 是 在 家 家 通 水 的 基 础 上 实 现 普 遍 用 电 … … 虽 然 服 务 业 在 经 济 结 构 内 所 占 的 部 分 依 然 有 限 ， 城 乡 间 公 共 服 务 水 平 的 差 距 也 依 旧 显 著 。 可 我 们 已 切 实 将 相 当 规 模 的 国 内 人 口 拉 入 到 了 便 捷 的 现 代 化 生 活 中 。";
				}
				else if (GlobalScript.inst.gameState.data[68] <= 1100)
				{
					fake_text += " ||您 的 名 字 与 英 明 领 导 已 事 实 上 刻 入 了 一 代 国 人 的 记 忆 中 ， 并 定 义 了 其 生 活 方 式 与 中 国 现 代 性 ： 我 国 在 全 国 范 围 改 进 住 房 ， 实 现 了 通 水 通 电 普 遍 供 暖 ， 成 功 为 数 亿 人 口 的 衣 食 住 行 保 驾 护 航 。 新 铁 路 、 新 机 场 等 关 键 基 础 设 施 联 通 了 国 内 主 要 中 大 型 城 市 ， 将 中 国 经 济 牢 牢 地 连 为 一 体 。 农 村 与 城 市 的 基 础 社 会 服 务 也 在 巨 额 投 资 与 制 度 改 革 的 背 景 下 逐 渐 缩 小 差 距 ， 并 对 各 类 居 民 平 等 开 门 。 跨 季 节 食 品 与 电 视 等 高 档 消 费 品 的 供 应 也 轻 易 跨 越 了 地 域 限 制 ， 直 接 同 全 国 消 费 者 对 接 。 现 在 ， 几 乎 全 体 国 人 也 能 同 古 代 的 杨 贵 妃 般 ， 平 等 享 受 “ 一 骑 红 尘 ” 的 极 致 体 验 。";
				}
				else
				{
					fake_text += " ||当 其 他 国 家 还 正 苦 恼 于 如 何 将 服 务 业 作 为 项 产 业 运 营 时 ， 我 们 则 早 早 定 义 了 服 务 业 本 身 ： 基 于 计 算 机 普 遍 联 网 的 电 子 互 动 、 交 易 与 支 付 体 系 与 纵 横 全 国 的 交 通 线 彻 底 改 变 了 服 务 形 式 ， 在 创 造 全 新 经 营 业 态 的 同 时 将 效 率 提 高 到 史 无 前 例 的 水 平 ： 我 们 彻 底 消 灭 了 通 勤 与 物 流 不 畅 的 现 象 ， 并 以 普 遍 设 立 的 信 息 基 础 设 施 与 国 家 网 络 为 基 础 ， 为 全 体 国 民 建 立 了 从 摇 篮 到 坟 墓 的 点 对 点 服 务 体 系 。 基 本 公 共 服 务 均 等 化 的 梦 想 与 城 乡 、 地 域 、 行 业 等 方 面 的 差 别 就 此 成 为 了 历 史 。 由 此 ， “ 中 国 速 度 ” 已 成 为 简 易 便 捷 与 高 水 准 的 代 名 词 ， 并 正 昂 首 阔 步 走 在 引 领 全 球 服 务 业 革 命 的 道 路 上 ， 为 世 界 所 瞩 目 。";
				}
			}
			else if (number_of_e == 8)
			{
				name.text = " 世 无 难 事 ， 只 须 登 攀";
				fake_text = "";
				if (GlobalScript.inst.gameState.event_done[360])
				{
					if (GlobalScript.inst.gameState.resultOfEvents[360] == 0)
					{
						if (GlobalScript.inst.gameState.resultOfEvents[352] == 2 && GlobalScript.inst.gameState.data[12] >= 1200 && GlobalScript.inst.gameState.resultOfEvents[361] >= 0 && GlobalScript.inst.gameState.resultOfEvents[361] <= 1 && GlobalScript.inst.gameState.resultOfEvents[364] == 1)
						{
							fake_text += " <size=40>月 亮 上 的 中 国 人</size>| 通 过 实 施 科 教 兴 国 、 制 造 强 国 、 并 将 航 天 事 业 发 展 纳 入 五 年 计 划 范 畴 等 多 项 政 策 。 我 国 航 天 局 得 以 效 法 美 国 “ 阿 波 罗 计 划 ” 般 开 展 系 统 性 的 “ 万 户 ” 探 月 研 究 项 目 ， 并 提 出 了 “ 探 月 ” - “ 绕 月 ” - “ 无 人 登 月 ” - “ 载 人 航 行 ” - “ 载 人 登 月 ” 五 步 走 计 划 。 对 航 天 基 础 设 施 的 持 之 以 恒 投 资 与 持 续 在 太 空 事 业 上 加 码 足 以 让 我 们 在 加 速 跑 的 同 时 脚 踏 实 地 ， 并 将 相 当 数 量 的 实 验 技 术 成 果 以 较 为 稳 定 的 形 式 投 入 到 计 划 使 用 中 。 也 就 在 2 0 世 纪 8 0 年 代 末 ， 我 们 终 于 得 以 打 赢 “ 国 旗 登 月 ” 突 击 战 ， 以 “ 神 州 五 号 ” 载 人 航 天 飞 船 与 “ 嫦 娥 ” 绕 月 探 测 卫 星 、 “ 玉 兔 ” 月 球 车 共 同 重 复 了 2 0 年 前 美 国 宇 航 员 的 壮 举 。 此 后 ， 我 们 更 完 成 了 连 著 名 航 天 大 国 美 国 都 无 法 达 成 的 目 标 — — 让 航 天 员 依 托 登 月 舱 与 相 关 体 系 在 月 滞 留 数 日 与 开 展 研 究 ， 以 “ 中 国 式 智 慧 ” 为 虎 头 蛇 尾 的 “ 阿 波 罗 计 划 ” 画 上 了 句 号 。 然 而 ， 突 击 式 登 月 很 快 便 暴 露 出 了 其 自 身 问 题 ： 月 球 探 索 计 划 本 身 高 度 仰 赖 国 家 预 算 支 持 ， 但 其 作 为 短 期 工 程 与 试 验 科 学 项 目 的 性 质 使 我 们 难 以 评 估 其 收 益 与 回 报 率 — — 当 然 ， 只 要 我 们 仍 怀 有 “ 可 上 九 天 揽 月 ” 的 雄 心 壮 志 与 相 应 的 充 实 积 淀 。 这 也 不 足 以 成 为 问 题 ： “ 万 户 ” 项 目 仍 在 持 续 进 行 ， 其 应 用 范 围 也 从 搭 载 我 国 航 天 员 登 月 转 为 类 似 “ 国 际 宇 宙 ” 的 多 国 联 合 测 试 项 目 ， 成 为 了 我 国 对 外 的 鲜 明 名 片 。";
							if (GlobalScript.inst.gameState.iron_and_blood)
							{
								achieves.GetComponent<achievements>().Set(102);
							}
						}
						else
						{
							fake_text += " <size=40>一 鼓 作 气 ， 再 而 衰 ， 三 而 … …</size>| 登 月 计 划 从 一 开 始 便 波 折 不 断 ， 由 于 预 算 有 限 与 缺 乏 可 靠 基 础 设 施 这 两 方 面 问 题 。 我 们 不 得 不 剑 走 偏 锋 ， 一 方 面 冒 险 使 用 大 量 未 经 验 证 的 实 验 性 技 术 ， 一 方 面 则 效 法 苏 联 开 发 金 星 探 测 性 的 剃 刀 原 则 “ 有 用 即 可 ” 。 也 就 在 付 出 无 数 人 力 物 力 。 终 于 在 2 0 世 纪 8 0 年 代 末 ， 我 们 得 以 压 着 死 线 打 赢 “ 国 旗 登 月 ” 突 击 战 ， 以 “ 神 州 五 号 ” 载 人 航 天 飞 船 重 复 了 2 0 年 前 美 国 宇 航 员 的 壮 举 。 然 而 ， 突 击 式 登 月 很 快 便 暴 露 出 了 其 自 身 问 题 ： 月 球 探 索 计 划 本 身 高 度 仰 赖 国 家 预 算 支 持 ， 但 其 作 为 短 期 工 程 与 试 验 科 学 项 目 的 性 质 使 我 们 难 以 评 估 其 收 益 与 回 报 率 — — 因 此 也 就 在 完 成 登 月 计 划 的 次 日 ， 国 务 院 便 以 “ 削 减 预 算 ， 优 化 财 政 结 构 ” 的 方 式 事 实 上 给 我 国 的 航 天 试 验 踩 下 刹 车 ， 并 拿 出 预 算 的 大 窟 窿 要 求 后 者 尽 快 将 其 中 “ 相 对 可 靠 ” 的 技 术 转 归 民 用 … … 虽 说 登 月 计 划 仍 照 常 进 行 ， 但 相 关 任 务 间 的 区 别 只 限 于 给 自 身 还 是 给 盟 国 插 旗 。 于 是 我 们 也 就 止 步 于 此 了 。";
						}
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[352] == 2 && GlobalScript.inst.gameState.data[12] >= 1400 && GlobalScript.inst.gameState.resultOfEvents[361] >= 0 && GlobalScript.inst.gameState.resultOfEvents[361] <= 1 && GlobalScript.inst.gameState.resultOfEvents[364] == 1 && GlobalScript.inst.gameState.data[73] >= 400 && GlobalScript.inst.gameState.influencePRC >= 700)
					{
						fake_text += " <size=40>国 际 月 球 站</size>| 通 过 实 施 科 教 兴 国 、 制 造 强 国 、 并 将 航 天 事 业 发 展 纳 入 五 年 计 划 范 畴 等 多 项 政 策 。 我 国 航 天 局 得 以 效 法 苏 联 的 “ 红 星 ” 月 面 产 研 复 合 体 与 开 展 系 统 性 的 “ 月 宫 ” 月 面 基 地 研 究 项 目 ， 由 此 形 成 了 “ 地 貌 研 究 ” - “ 登 月 项 目 ” - “ 基 础 建 设 ” - “ 能 源 采 集 ” - “ 稳 固 定 居 ” 五 步 走 计 划 。 对 航 天 基 础 设 施 的 持 之 以 恒 投 资 与 持 续 在 太 空 事 业 上 加 码 足 以 让 我 们 在 加 速 跑 的 同 时 脚 踏 实 地 ， 并 将 相 当 数 量 的 实 验 技 术 成 果 以 较 为 稳 定 的 形 式 投 入 到 计 划 使 用 中 。 传 统 太 空 大 国 的 加 入 与 协 作 则 使 得 中 国 得 以 在 降 低 成 本 的 同 时 以 更 快 速 度 推 进 项 目 ， 并 提 升 中 国 的 国 际 声 誉 ： 我 们 得 以 在 开 发 “ 神 州 ” 系 列 载 人 航 天 飞 船 、 “ 嫦 娥 ” 绕 月 探 测 卫 星 、 “ 玉 兔 ” 月 球 车 、 “ 夸 娥 ” 重 型 航 天 飞 机 等 国 产 航 天 设 备 的 同 时 协 助 国 际 朋 友 ， 并 再 激 活 超 级 大 国 或 已 蒙 尘 ， 或 正 致 力 的 太 空 研 究 项 目 ： “ 普 罗 米 修 斯 ” 航 天 飞 机 、 “ N - 1 ” 运 载 火 箭 乃 至 “ 暴 风 雪 ” 项 目 等 都 得 利 于 此 。 接 下 来 便 是 使 用 模 块 组 件 与 自 动 化 工 程 打 造 可 自 给 自 足 的 居 住 、 试 验 、 储 物 与 能 源 模 块 ； 并 效 法 “ 生 物 圈 二 号 ” 为 月 面 研 究 者 提 供 尽 可 能 接 近 地 球 环 境 且 相 对 舒 适 的 生 存 环 境 。 也 就 在 2 0 世 纪 8 0 年 代 末 ， 我 国 国 家 航 天 局 同 美 苏 航 天 机 构 向 全 世 界 人 民 展 示 了 我 们 对 月 球 雄 心 勃 勃 的 “ 新 版 阿 波 罗 - 联 盟 测 试 项 目 ” ： 首 个 十 年 基 本 完 成 技 术 验 证 与 月 面 探 测 工 作 ， 世 纪 初 十 年 则 基 本 实 现 登 月 并 为 月 面 基 地 建 设 奠 定 基 础 ， 最 后 十 年 则 用 于 实 现 月 面 长 居 之 梦 。 考 虑 到 我 们 有 充 足 时 间 测 试 与 应 用 相 关 技 术 ， 新 月 球 探 索 计 划 足 以 在 推 进 同 时 为 我 国 经 济 发 展 持 续 提 供 技 术 与 智 力 支 持 。 而 该 计 划 只 会 随 着 时 间 进 展 而 结 出 越 加 丰 富 的 硕 果 ： 当 时 间 步 入 新 世 纪 时 ， 就 连 阿 波 罗 太 空 舱 遗 迹 与 美 国 国 旗 都 在 国 际 各 国 团 结 共 建 基 础 下 逐 步 成 长 的 “ 蜂 巢 状 ” 研 究 基 地 面 前 黯 然 失 色 ： 一 座 座 地 热 发 电 厂 、 反 应 堆 与 氦 塔 拔 地 而 起 ， 同 无 数 太 阳 能 板 也 与 特 质 高 速 列 车 共 同 支 撑 起 了 繁 荣 的 月 面 工 业 新 城 ， 并 大 有 反 哺 母 星 的 潜 质 ； 月 球 生 产 的 新 品 种 作 物 也 开 始 打 出 自 身 优 势 。 来 自 世 界 各 地 一 批 又 一 批 航 天 人 的 到 来 则 更 是 让 该 项 目 成 为 了 “ 世 界 人 民 大 团 结 ” 的 生 动 写 照 … … 也 许 某 天 ， 我 们 真 的 会 迎 来 完 全 在 月 面 成 长 的 一 代 “ 宇 宙 种 族 ” ， 并 带 着 同 地 球 般 繁 荣 的 月 球 与 母 星 握 起 手 来 ， 真 正 宣 告 “ 人 类 命 运 共 同 体 ” 的 成 立 … … ";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(102);
						}
					}
					else
					{
						fake_text += "<size=40>举 头 望 明 月 ， 低 头 思 故 乡 … …</size>|虽 说 得 到 了 国 内 各 位 领 导 的 特 别 过 问 与 相 当 宽 裕 的 计 划 时 间 ， 可 预 算 有 限 与 缺 乏 可 靠 基 础 设 施 这 两 方 面 问 题 从 一 开 始 便 窒 息 了 立 即 实 行 任 何 探 索 计 划 的 可 能 ， 我 国 航 天 局 也 不 得 不 从 零 开 始 为 这 宏 大 计 划 打 基 础 ： “ 月 桂 树 ” 计 划 本 身 则 更 在 效 法 苏 联 的 “ 红 星 ” 月 面 产 研 复 合 体 项 目 的 基 础 上 持 续 删 减 ， 主 题 则 被 限 定 为 “ 月 面 研 究 基 地 ” 。 接 下 来 便 是 转 向 研 发 与 测 试 工 作 ： 数 十 年 的 工 作 既 让 我 们 拥 有 了 包 括 “ 神 州 ” 系 列 载 人 航 天 飞 船 、 “ 嫦 娥 ” 绕 月 探 测 卫 星 、 “ 玉 兔 ” 月 球 车 等 具 有 自 主 知 识 产 权 且 兼 具 可 靠 性 的 航 天 科 学 产 品 ， 同 时 还 通 过 开 发 模 块 化 技 术 、 自 动 化 社 会 与 计 算 机 技 术 积 累 了 不 少 可 转 向 民 间 工 业 生 产 的 可 靠 技 术 。 我 们 确 实 可 说 “ 月 桂 树 ” 计 划 执 行 期 间 基 本 顺 利 — — 只 要 我 们 不 谈 在 月 面 立 即 修 建 研 究 设 施 这 一 点 的 话 ： 绝 大 多 数 资 金 与 技 术 都 被 用 于 完 善 中 国 既 有 航 天 设 备 并 补 助 民 用 ， 使 计 划 本 身 事 实 上 在 完 成 大 多 数 探 测 与 发 射 任 务 后 便 陷 入 了 “ 暂 时 停 滞 ” 状 态 。 可 人 们 都 知 道 ， 没 有 比 “ 暂 时 ” 更 持 久 的 东 西 了 。 ";
					}
				}
				else
				{
					fake_text += "<size=40>探 索 月 球</size>";
					fake_text += "|";
					fake_text += GlobalScript.inst.new_events_text[554];
				}
				fake_text += "||";
				if (GlobalScript.inst.gameState.event_done[362])
				{
					if (GlobalScript.inst.gameState.resultOfEvents[362] == 2)
					{
						fake_text += "<size=40>遥远的红色火星</size>";
						fake_text += "|";
						fake_text += GlobalScript.inst.new_events_text[556];
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[361] >= 0 && GlobalScript.inst.gameState.resultOfEvents[361] <= 1 && GlobalScript.inst.gameState.data[12] >= 1200 && GlobalScript.inst.gameState.resultOfEvents[354] == 1 && GlobalScript.inst.gameState.resultOfEvents[355] == 0 && GlobalScript.inst.gameState.data[73] >= 400)
					{
						fake_text += " <size=40> 火 星 土 壤 样 本 归 来</size>| 完 成 了 多 次 成 功 的 火 星 探 索 任 务 后 ， 中 国 领 导 层 决 定 依 托 现 有 技 术 基 础 组 织 史 无 前 例 的 火 星 调 查 计 划 ： 也 就 在 该 国 基 本 形 成 火 星 卫 星 、 火 星 探 测 站 与 火 星 探 测 车 共 同 调 查 火 星 的 多 层 网 络 同 时 ， 中 国 新 研 发 的 “ 燧 人 ” 号 火 星 车 提 出 了 “ 完 全 回 收 ” 的 概 念 ： 并 计 划 在 2 0 世 纪 9 0 年 代 内 完 成 使 用 类 似 月 面 返 航 的 技 术 提 取 并 带 回 火 星 土 壤 样 本 乃 至 数 据 储 存 的 任 务 。 相 关 任 务 在 1 9 9 2 年 开 始 进 行 ， 并 随 新 世 纪 初 “ 燧 人 ” 号 的 圆 满 返 程 而 震 撼 国 际 科 学 界 。 中 国 在 国 际 科 学 界 的 声 誉 也 由 此 大 幅 提 高 ， 其 开 发 的 火 星 探 测 器 也 创 下 了 无 数 世 界 纪 录 （ 如 收 集 数 据 最 多 、 运 行 时 间 最 长 、 最 先 使 用 核 能 驱 动 等 ） 。 许 多 国 家 开 始 同 我 们 的 科 学 院 就 此 展 开 合 作 ， 并 试 图 从 中 国 工 业 内 取 经 。 航 天 局 的 下 一 步 计 划 自 是 启 动 载 人 登 录 火 星 ， 完 成 强 大 的 美 国 都 无 法 实 现 之 事 — — 当 然 ， 那 是 未 来 几 十 年 内 的 故 事 了 … …";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(104);
						}
					}
					else
					{
						fake_text += "<size=40>不 摔 跤 是 学 不 会 走 路 的 … …</size>|中 国 科 技 实 力 与 物 质 基 础 完 全 不 足 以 支 撑 火 星 探 索 计 划 的 宏 大 野 心 ， 最 终 只 能 基 于 最 粗 暴 的 实 用 主 义 态 度 开 发 出 “ 勉 强 可 用 ” 的 火 星 探 测 系 统 并 将 其 草 草 发 射 。 国 人 们 很 快 便 从 电 视 机 前 见 到 了 这 种 狂 野 作 风 的 后 患 ： 自 诩 将 把 火 星 土 壤 样 本 完 整 带 回 地 球 的 “ 燧 人 ” 号 火 星 车 降 落 后 不 久 便 停 止 响 应 ， 只 留 下 几 段 信 号 与 少 数 照 片 — — 看 来 是 科 学 家 没 有 攻 克 放 射 性 同 位 素 热 电 发 电 机 的 关 键 技 术 ， 只 能 用 普 通 锂 电 池 取 而 代 之 。 中 国 科 学 事 业 就 此 走 下 神 坛 ， 不 得 不 咽 下 苦 果 。 东 山 再 起 也 并 非 不 可 能 ， 但 那 是 未 来 几 十 年 内 的 故 事 了 … … ";
					}
				}
				else
				{
					fake_text += "<size=40>遥远的红色火星</size>";
					fake_text += "|";
					fake_text += GlobalScript.inst.new_events_text[556];
				}
				fake_text += "||";
				if (GlobalScript.inst.gameState.event_done[363])
				{
					if (GlobalScript.inst.gameState.resultOfEvents[363] == 2)
					{
						fake_text += "<size=40>太空空间站</size>";
						fake_text += "|";
						fake_text += GlobalScript.inst.new_events_text[558];
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[363] == 0)
					{
						if (GlobalScript.inst.gameState.resultOfEvents[352] == 2 && GlobalScript.inst.gameState.data[12] >= 1400 && GlobalScript.inst.gameState.resultOfEvents[354] == 1 && GlobalScript.inst.gameState.resultOfEvents[355] == 0 && GlobalScript.inst.gameState.resultOfEvents[364] == 1 && GlobalScript.inst.gameState.data[73] >= 400)
						{
							fake_text += "<size=40>人 定 胜 天</size>| 中 国 在 太 空 站 研 究 方 面 的 单 打 独 斗 与 自 立 更 生 很 快 便 结 出 了 硕 果 ： 基 于 先 前 发 射 卫 星 与 多 款 载 人 航 天 器 的 经 验 ， 我 们 得 以 充 分 整 合 各 项 研 究 成 果 并 背 靠 强 大 的 产 学 研 综 合 实 力 另 起 炉 灶 ， 以 落 实 载 人 航 天 计 划 “ 三 步 走 ” （ 即 “ 发 射 载 人 飞 船 ” - “ 实 现 交 会 对 接 ” - “ 建 造 载 人 空 间 站 ” ） 。 计 划 内 的 中 国 空 间 站 决 定 跳 过 早 期 空 间 站 的 设 计 框 架 ， 直 接 以 苏 联 “ 和 平 号 ” 空 间 站 开 创 的 新 设 计 理 念 为 基 准 ， 并 力 求 在 实 际 应 用 水 平 上 尽 可 能 超 越 该 国 可 能 研 发 的 现 代 化 版 本 “ 和 平 2 号 ” 。 新 建 立 的 空 间 站 将 采 用 模 块 化 组 装 ， 并 配 置 多 舱 室 组 建 复 合 结 构 ， 最 终 达 到 让 中 国 航 天 员 可 在 太 空 环 境 内 长 期 生 活 与 工 作 的 效 用 。 也 就 在 2 0 世 纪 8 0 年 代 末 ， 中 国 成 功 将 本 国 自 研 的 首 台 第 三 代 空 间 站 “ 天 宫 一 号 ” 送 入 太 空 轨 道 ， 并 在 未 来 的 数 年 内 加 装 数 个 额 外 模 块 形 成 载 人 研 究 轨 道 综 合 体 。 与 此 同 时 ， 作 为 其 升 级 版 的 “ 天 宫 二 号 ” 也 开 始 在 国 家 航 天 局 全 力 推 进 下 紧 锣 密 鼓 研 发 ： 我 们 将 在 升 级 其 核 心 组 建 的 基 础 上 增 设 功 能 组 件 ， 并 在 测 试 以 桁 架 和 积 木 式 的 混 合 结 构 建 设 空 间 站 的 可 行 性 的 同 时 将 其 转 变 为 未 来 太 空 港 发 展 的 潜 在 基 础 设 施 ： 这 甚 至 足 以 使 我 们 在 太 空 轨 道 上 直 接 发 射 “ 长 征 ” 系 列 运 载 火 箭 与 其 他 类 别 的 复 合 太 空 飞 船 ， 使 星 系 航 行 与 太 空 旅 游 成 为 可 能 。 而 各 国 对 航 天 事 业 的 投 入 只 会 进 一 步 巩 固 “ 天 宫 ” 的 地 位 ， 如 今 的 中 国 空 间 站 已 成 为 世 界 各 国 航 天 事 业 的 最 佳 实 验 室 、 中 转 站 与 补 给 区 ， 其 产 生 的 潜 在 效 益 与 科 研 价 值 则 无 可 估 量 。";
						}
						else
						{
							fake_text += "<size=40> 天 命 难 违</size>|由 于 缺 乏 相 应 的 技 术 积 累 与 人 力 物 力 ， 中 国 自 研 空 间 站 的 计 划 只 能 被 限 定 在 相 当 保 守 的 范 围 内 ： 至 少 在 本 世 纪 内 ， 中 国 的 空 间 站 将 仍 停 留 在 摸 着 “ 礼 炮 ” 系 列 过 河 的 水 平 ； 而 同 期 的 苏 联 则 已 将 新 一 代 载 人 研 究 轨 道 综 合 体 “ 和 平 号 ” 发 射 入 轨 ， 大 国 们 甚 至 开 始 筹 备 建 设 新 一 代 太 空 项 目 “ 国 际 空 间 站 ” 的 相 关 计 划 — — 我 们 的 技 术 水 平 甚 至 不 足 以 构 成 其 敲 门 砖 ， 最 终 只 能 以 “ 建 设 性 身 份 ” 的 虚 名 承 担 部 分 中 间 产 品 的 生 产 。 中 国 的 “ 天 宫 ” 仍 在 ， 可 同 不 远 处 的 “ 和 平 ” 乃 至 “ 国 际 ” 相 比 ， 便 是 可 怜 小 虾 米 … … 可 我 国 古 话 说 得 好 ： “ 士 别 三 日 ， 当 刮 目 相 看 ” 。 然 而 在 各 地 均 以 新 式 卫 星 在 轨 道 上 疯 狂 圈 地 的 背 景 下 ， 中 国 还 有 多 少 个 三 日 可 等 … …";
						}
					}
					else if (!GlobalScript.inst.gameState.relres && !GlobalScript.inst.gameState.completedDecisions[9])
					{
						fake_text += "<size=40>万 事 开 头 难</size>|“ 黎 明 号 ” 就 如 一 波 三 折 的 中 苏 关 系 般 命 运 多 舛 ： 两 国 关 系 蜜 月 期 的 终 结 事 实 上 结 束 了 基 于 “ 和 平 号 ” 方 案 改 装 并 拓 展 中 苏 合 建 空 间 站 的 可 能 ， “ 黎 明 号 ” 仅 在 加 装 了 有 限 舱 室 后 便 老 老 实 实 地 按 照 “ 十 年 有 效 ” 期 限 投 入 运 营 ， 成 为 了 太 空 中 的 无 主 孤 儿 ： 也 就 在 苏 联 开 始 筹 备 独 立 的 “ 和 平 2 号 ” 计 划 ， 并 提 出 相 关 概 念 的 同 时 ； 中 国 便 也 微 妙 地 “ 暂 停 ” 了 有 关 补 充 舱 段 发 射 任 务 的 协 商 与 对 “ 黎 明 ” 的 维 护 服 务 ， 并 将 投 资 转 移 至 代 号 “ 天 宫 ” 的 项 目 内 。 我 们 可 说 ， 国 际 空 间 站 计 划 事 实 上 胎 死 腹 中 … … ";
					}
					else if (GlobalScript.inst.gameState.allcountries[21].isSocEU && GlobalScript.inst.gameState.empires[1].now_leader == 6 && GlobalScript.inst.gameState.allcountries[7].SubGosstroy != 15 && !GlobalScript.inst.gameState.completedDecisions[9])
					{
						fake_text += "<size=40> 试 问 卷 帘 人 ， 却 道 海 棠 依 旧</size>| 中 国 与 苏 联 合 力 筹 建 的 “ 黎 明 号 ” 空 间 站 将 以 人 类 有 史 以 来 最 成 功 的 国 际 太 空 合 作 项 目 栽 入 史 册 ： 首 次 使 用 模 块 化 设 计 并 在 空 间 站 上 打 造 多 仓 室 复 合 结 构 ， 由 此 开 创 第 三 代 空 间 站 设 计 思 路 ； 航 天 员 也 得 以 实 现 长 期 居 留 太 空 的 同 时 并 开 展 科 学 试 验 项 目 。 随 着 时 间 的 流 逝 ， 该 空 间 站 的 效 用 与 研 究 价 值 只 会 与 日 俱 增 ： 苏 联 与 中 国 通 过 补 充 空 间 站 的 方 式 持 续 拓 展 其 功 能 ， 并 带 动 了 其 他 有 志 于 太 空 事 业 的 国 家 倾 心 于 此 。 也 就 在 2 0 世 纪 9 0 年 代 末 ， 甚 至 连 包 括 美 国 在 内 的 航 天 大 国 都 参 与 到 了 其 建 设 并 增 设 自 身 仓 位 。 “ 黎 明 号 ” 就 此 成 为 了 未 来 “ 国 际 空 间 站 ” 的 基 础 与 先 驱 ， 为 世 界 各 地 的 航 天 员 撑 起 片 港 湾 。 然 而 ， 苏 联 国 内 局 势 的 风 云 突 变 使 得 支 撑 “ 黎 明 号 ” 运 转 的 一 极 进 入 不 稳 定 状 态 ， 并 大 有 使 相 关 计 划 提 前 结 束 的 风 险 。 不 过 多 亏 了 欧 洲 各 国 的 雪 中 送 碳 与 持 续 支 持 保 证 ， “ 黎 明 号 ” 空 间 站 仍 得 以 相 安 无 事 。 它 已 累 计 完 成 了 三 十 项 国 际 科 研 计 划 ， 两 万 多 个 科 学 试 验 ， 产 生 了 数 百 个 可 供 工 业 应 用 的 新 技 术 ， 并 精 力 充 沛 地 带 领 国 际 宇 航 员 们 迈 入 新 世 纪 大 门 ， 最 终 确 保 国 际 航 行 与 太 空 探 索 任 务 的 国 际 主 义 性 质 ！ ";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(103);
						}
					}
					else if (GlobalScript.inst.gameState.data[12] >= 1400 && GlobalScript.inst.gameState.data[73] >= 400 && GlobalScript.inst.gameState.empires[1].now_leader == 6 && GlobalScript.inst.gameState.allcountries[7].SubGosstroy != 15 && !GlobalScript.inst.gameState.completedDecisions[9])
					{
						fake_text += "<size=40> 物 是 人 非 事 事 休</size>| 中 国 与 苏 联 合 力 筹 建 的 “ 黎 明 号 ” 空 间 站 将 以 人 类 有 史 以 来 最 成 功 的 国 际 太 空 合 作 项 目 栽 入 史 册 ： 首 次 使 用 模 块 化 设 计 并 在 空 间 站 上 打 造 多 仓 室 复 合 结 构 ， 由 此 开 创 第 三 代 空 间 站 设 计 思 路 ； 航 天 员 也 得 以 实 现 长 期 居 留 太 空 的 同 时 并 开 展 科 学 试 验 项 目 。 随 着 时 间 的 流 逝 ， 该 空 间 站 的 效 用 与 研 究 价 值 只 会 与 日 俱 增 ： 苏 联 与 中 国 通 过 补 充 空 间 站 的 方 式 持 续 拓 展 其 功 能 ， 并 带 动 了 其 他 有 志 于 太 空 事 业 的 国 家 倾 心 于 此 。 也 就 在 2 0 世 纪 9 0 年 代 末 ， 甚 至 连 包 括 美 国 在 内 的 航 天 大 国 都 参 与 到 了 其 建 设 并 增 设 自 身 仓 位 。 “ 黎 明 号 ” 就 此 成 为 了 未 来 “ 国 际 空 间 站 ” 的 基 础 与 先 驱 ， 为 世 界 各 地 的 航 天 员 撑 起 片 港 湾 。 然 而 ， 苏 联 国 内 局 势 的 风 云 突 变 使 得 支 撑 “ 黎 明 号 ” 运 转 的 一 极 进 入 不 稳 定 状 态 ， 并 大 有 使 相 关 计 划 提 前 结 束 的 风 险 。 不 过 多 亏 了 中 国 的 雪 中 送 碳 与 持 续 支 持 保 证 ， “ 黎 明 号 ” 空 间 站 仍 得 以 相 安 无 事 。 它 已 累 计 完 成 了 三 十 项 国 际 科 研 计 划 ， 两 万 多 个 科 学 试 验 ， 产 生 了 数 百 个 可 供 工 业 应 用 的 新 技 术 ， 并 精 力 充 沛 地 带 领 国 际 宇 航 员 们 迈 入 新 世 纪 大 门 ， 最 终 确 保 国 际 航 行 与 太 空 探 索 任 务 的 国 际 主 义 性 质 ！ ";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(103);
						}
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && GlobalScript.inst.gameState.allcountries[7].SubGosstroy != 15 && !GlobalScript.inst.gameState.completedDecisions[9])
					{
						fake_text += "<size=40> 长 河 渐 落 晓 星 沉</size>| 中 国 与 苏 联 合 力 筹 建 的 “ 黎 明 号 ” 空 间 站 将 以 人 类 有 史 以 来 最 成 功 的 国 际 太 空 合 作 项 目 栽 入 史 册 ： 首 次 使 用 模 块 化 设 计 并 在 空 间 站 上 打 造 多 仓 室 复 合 结 构 ， 由 此 开 创 第 三 代 空 间 站 设 计 思 路 ； 航 天 员 也 得 以 实 现 长 期 居 留 太 空 的 同 时 并 开 展 科 学 试 验 项 目 。 随 着 时 间 的 流 逝 ， 该 空 间 站 的 效 用 与 研 究 价 值 只 会 与 日 俱 增 ： 苏 联 与 中 国 通 过 补 充 空 间 站 的 方 式 持 续 拓 展 其 功 能 ， 并 带 动 了 其 他 有 志 于 太 空 事 业 的 国 家 倾 心 于 此 。 也 就 在 2 0 世 纪 9 0 年 代 末 ， 甚 至 连 包 括 美 国 在 内 的 航 天 大 国 都 参 与 到 了 其 建 设 并 增 设 自 身 仓 位 。 “ 黎 明 号 ” 就 此 成 为 了 未 来 “ 国 际 空 间 站 ” 的 基 础 与 先 驱 ， 为 世 界 各 地 的 航 天 员 撑 起 片 港 湾 。 然 而 ， 苏 联 国 内 局 势 的 风 云 突 变 使 得 支 撑 “ 黎 明 号 ” 运 转 的 一 极 进 入 不 稳 定 状 态 ， 并 以 该 国 航 天 部 门 的 萎 靡 给 “ 黎 明 号 ” 计 划 以 重 击 ： 空 间 站 本 身 也 越 加 仰 赖 同 外 国 科 学 院 合 作 以 获 得 支 持 。 然 而 实 验 科 学 平 台 终 究 不 是 小 卖 部 ， 且 后 苏 联 国 家 持 续 恶 化 的 财 政 情 况 也 使 得 其 更 加 难 以 为 继 。 1 9 9 7 年 的 多 事 之 秋 则 更 是 给 了 其 致 命 一 击 ： 空 间 站 本 身 技 术 的 落 后 、 俄 罗 斯 债 务 危 机 与 “ 黎 明 号 ” 上 发 生 的 重 大 事 故 最 终 使 得 保 留 空 间 站 已 无 必 要 。 也 就 在 俄 罗 斯 签 署 了 建 设 新 版 国 际 空 间 站 的 协 定 并 通 过 议 会 表 决 后 ， 累 计 完 成 了 三 十 项 国 际 科 研 计 划 ， 两 万 多 个 科 学 试 验 ， 产 生 了 数 百 个 可 供 工 业 应 用 新 技 术 的 “ 黎 明 号 ” 先 驱 便 在 举 世 注 目 下 于 新 世 纪 初 年 化 作 流 星 ， 彻 底 结 束 了 其 作 为 初 代 国 际 空 间 站 的 使 命 。 ";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(103);
						}
					}
					else
					{
						fake_text += "<size=40> 国 际 空 间 站</size>| 中 国 与 苏 联 合 力 筹 建 的 “ 黎 明 号 ” 空 间 站 将 以 人 类 有 史 以 来 最 成 功 的 国 际 太 空 合 作 项 目 栽 入 史 册 ： 首 次 使 用 模 块 化 设 计 并 在 空 间 站 上 打 造 多 仓 室 复 合 结 构 ， 由 此 开 创 第 三 代 空 间 站 设 计 思 路 ； 航 天 员 也 得 以 实 现 长 期 居 留 太 空 的 同 时 并 开 展 科 学 试 验 项 目 。 随 着 时 间 的 流 逝 ， 该 空 间 站 的 效 用 与 研 究 价 值 只 会 与 日 俱 增 ： 苏 联 与 中 国 通 过 补 充 空 间 站 的 方 式 持 续 拓 展 其 功 能 ， 并 带 动 了 其 他 有 志 于 太 空 事 业 的 国 家 倾 心 于 此 。 也 就 在 2 0 世 纪 9 0 年 代 末 ， 甚 至 连 包 括 美 国 在 内 的 航 天 大 国 都 参 与 到 了 其 建 设 并 增 设 自 身 仓 位 。 “ 黎 明 号 ” 就 此 成 为 了 未 来 “ 国 际 空 间 站 ” 的 基 础 与 先 驱 ， 为 世 界 各 地 的 航 天 员 撑 起 片 港 湾 。 如 今 ， “ 黎 明 号 ” 空 间 站 仍 在 多 方 的 特 别 关 照 下 相 安 无 事 。 它 已 累 计 完 成 了 三 十 项 国 际 科 研 计 划 ， 两 万 多 个 科 学 试 验 ， 产 生 了 数 百 个 可 供 工 业 应 用 的 新 技 术 ， 并 精 力 充 沛 地 带 领 国 际 宇 航 员 们 迈 入 新 世 纪 大 门 ， 最 终 确 保 国 际 航 行 与 太 空 探 索 任 务 的 国 际 主 义 性 质 ！ ";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(103);
						}
					}
				}
				else
				{
					fake_text += "<size=40>太空空间站</size>";
					fake_text += "|";
					fake_text += GlobalScript.inst.new_events_text[558];
				}
				fake_text += "||";
				if (GlobalScript.inst.gameState.event_done[648])
				{
					fake_text += "<size=40>太 白 与 我 语</size>";
					fake_text += "|";
					if (GlobalScript.inst.gameState.resultOfEvents[648] == 2)
					{
						fake_text += "晨 光 迫 残 月 ， 回 顾 失 长 庚 。";
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[648] == 0)
					{
						fake_text += "在 “ 长 庚 一 号 ” 顺 利 返 回 ， 并 带 回 了 大 量 宝 贵 的 科 研 数 据 后 。 我 们 的 科 学 家 得 出 了 令 人 失 望 的 结 论 ： 金 星 是 一 颗 完 全 不 适 宜 居 住 的 行 星 ， 且 缺 乏 长 期 开 发 的 潜 力 。 直 到 长 庚 二 号 发 射 之 前 ， 也 许 地 球 上 再 也 没 有 政 权 能 够 前 去 探 索 这 颗 金 色 星 球 了 ， 而 这 个 时 间 将 是2026 年 。 ";
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[648] == 1)
					{
						fake_text += "“ 杜 环 ” 号 探 测 器 在 滑 入 金 星 的 轨 道 后 。 利 用 先 进 的 成 像 雷 达 系 统 对 金 星 全 球 进 行 了 详 细 的 拍 摄 ， 还 对 金 星95 % 的 地 区 进 行 了 高 分 辨 率 的 重 力 测 量 。 整 个 拍 摄 和 测 量 过 程 历 时 4 年 ， 取 得 了 丰 硕 的 科 学 成 果 。 自 进 入 太 空 并 于 次 年 接 近 金 星 以 来 ， “ 杜 环 ” 号 已 围 绕 该 行 星 飞 行15018 周 ， 运 用 能 够 透 视 金 垦 云 层 的 先 进 雷 达 对 其 百 分 之 九 十 八 的 地 貌 全 景 进 行 了 测 绘 ， 发 回 的 数 据 在 数 量 上 超 过 此 前 其 他 探 测 器 发 回 数 据 的 总 和 。|在 太 阳 能 电 池 板 彻 底 烧 断 后 ， 鉴 于 已 经 无 法 把 这 一 耗 资8 亿 多 人 民 币 元 的 探 测 器 回 收 到 地 面 上 ， 航 天 站 工 作 者5 次 遥 控 启 动 “ 杜 环 ” 号 的 助 推 发 动 机 ， 使 其 从 相 距 金 星 表 面 大 约135 公 里 的 近 圆 形 轨 道 转 入 到 逐 渐 落 向 金 星 表 面 的 弧 形 轨 道 ， 做 最 后 的 航 天 飞 行 器 械 空 气 动 力 学 试 验 。|对 于 失 去 这 样 一 艘 在 飞 行 最 后 阶 段 都 为 人 类 空 间 探 测 事 业 作 出 贡 献 的 宇 宙 飞 船 ， 中 国 航 天 局 的 科 学 家 不 无 惋 惜 之 情 。 实 验 室 的 工 作 人 员 向 新 闻 界 承 认 ， 这 是 一 个 令 人 伤 感 的 时 刻 ， 长 期 监 控 该 卫 星 的 工 作 人 员 甚 至 为 他 缠 上 了 黑 纱 布 。 不 过 ， 伤 感 之 余 ， 他 们 还 为 “ 杜 环 ” 号 之 行 的 圆 满 成 功 感 到 兴 奋 。 因 为 他 为 全 人 类 探 索 出 了 属 于 二 十 一 世 纪 的 新 大 陆 。";
					}
				}
				else
				{
					fake_text += "<size=40>太 白 与 我 语</size>";
					fake_text += "|";
					fake_text += "晨 光 迫 残 月 ， 回 顾 失 长 庚 。";
				}
			}
			else if (number_of_e == 9)
			{
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[14].oar && GlobalScript.inst.gameState.allcountries[35].oar && GlobalScript.inst.gameState.allcountries[13].oar && GlobalScript.inst.gameState.data[85] == 3)
				{
					achieves.GetComponent<achievements>().Set(13);
				}
				name.text = " 肝 胆 相 照 的 兄 弟 — — 朝 鲜 半 岛";
				fake_text = "";
				if (GlobalScript.inst.gameState.allcountries[10].puppetOf <= 0 && GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding >= 0)
				{
					if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding >= 0)
					{
						achieves.GetComponent<achievements>().Set(69);
					}
					if (!GlobalScript.inst.gameState.allcountries[10].cw)
					{
						fake_text += GlobalScript.inst.new_texts[244 + GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding];
						if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding >= 0)
						{
							achieves.GetComponent<achievements>().Set(69);
						}
					}
					else
					{
						if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding == 0)
						{
							fake_text += " 在 黄 长 烨 的 市 场 化 改 革 下 ， 朝 鲜 开 始 对 外 开 放 ， 吸 引 外 资 ， 但 是 对 于 南 朝 鲜 的 私 有 资 本 则 进 行 强 制 性 公 私 合 营 。 在 中 苏 美 等 国 的 投 资 下 ， 朝 鲜 发 展 迅 速 ， 但 是 这 种 情 况 持 续 不 了 多 久 。 很 快 便 因 为 外 债 高 筑 导 致 经 济 陷 入 停 滞 ， 物 价 飞 涨 ， 群 众 大 量 失 业 。 政 治 的 民 主 集 中 制 改 革 并 未 对 朝 鲜 的 政 治 起 到 丝 毫 的 影 响 ， 这 也 促 使 因 经 济 发 展 态 势 不 良 而 对 朝 鲜 现 状 不 满 的 人 民 群 众 变 得 更 加 激 进 。 但 在 我 们 进 一 步 的 经 济 援 助 下 ， 朝 鲜 社 会 逐 渐 变 得 稳 定 了 些 许 。 不 过 这 经 济 援 助 的 条 件 便 是 中 国 通 过 经 济 手 段 加 强 对 朝 鲜 的 控 制 ， 朝 鲜 看 起 来 和 中 国 的 傀 儡 国 没 有 其 他 区 别 了 。";
						}
						if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding == 1)
						{
							fake_text += " 金 哲 上 台 后 ， 迅 速 着 手 进 行 全 方 位 改 革 ， 朝 鲜 劳 动 党 与 朝 鲜 社 民 党 合 并 ， 组 成 朝 鲜 统 一 社 会 党 ， 并 将 原 韩 国 地 区 的 温 和 左 翼 统 统 拉 进 统 社 党 中 ， 统 社 党 将 民 主 社 会 主 义 作 为 新 的 指 导 思 想 ， 而 主 体 思 想 则 被 批 评 为 是 极 左 思 想 ， 统 社 党 借 此 进 行 大 退 党 ， 被 迫 退 党 的 主 体 派 组 成 了 朝 鲜 主 体 思 想 劳 动 党 ， 并 准 备 参 选 。 最 高 人 民 会 议 的 权 力 逐 渐 变 大 ， 差 额 选 举 ， 三 权 分 立 等 选 举 原 则 被 写 入 宪 法 和 选 举 法 中 ， 原 韩 国 地 区 的 民 主 派 人 士 允 许 组 党 。 北 朝 鲜 地 区 的 计 划 经 济 则 被 逐 步 改 革 ， 自 负 盈 亏 ， 直 至 完 全 市 场 化 。 南 朝 鲜 地 区 的 关 键 领 域 进 行 国 有 化 收 购 ， 提 高 社 会 福 利 。 朝 鲜 统 社 党 决 定 加 入 社 会 党 国 际 并 与 西 欧 的 社 民 党 执 政 国 家 进 行 友 好 合 作 。 或 许 对 于 这 个 朝 鲜 来 说 ， 真 能 实 现 民 主 与 社 会 主 义 的 统 一 ？";
						}
						if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding == 2)
						{
							fake_text += " 金 英 柱 上 台 之 后 ， 开 始 将 南 方 左 翼 人 士 和 部 分 民 主 派 领 袖 拉 入 祖 国 民 主 主 义 统 一 战 线 ， 并 将 左 翼 运 动 中 的 民 族 解 放 派 （ N L ） 全 部 吸 纳 至 劳 动 党 。 南 方 的 私 有 资 本 全 部 强 制 国 有 化 并 对 南 方 经 济 逐 步 进 行 改 革 ， 直 至 与 北 方 接 轨 。 由 于 有 N L 派 的 加 入 ， 金 家 的 威 望 被 大 大 提 升 并 进 一 步 神 化 ， 而 主 体 思 想 也 被 认 为 是 朝 鲜 的 真 理 。 南 方 的 其 他 民 主 派 和 资 本 家 等 则 直 接 被 当 作 人 民 公 敌 公 审 枪 决 。 朝 鲜 对 外 则 站 在 社 会 主 义 阵 营 与 反 美 阵 营 一 侧 ， 始 终 不 渝 的 反 对 美 帝 国 主 义 。";
						}
						if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding == 3)
						{
							fake_text += " 在 朴 劳 解 的 治 下 ， 朝 鲜 各 左 翼 人 士 均 被 吸 纳 进 劳 动 党 党 内 ， 对 于 主 体 仅 批 评 其 夸 大 领 袖 作 用 ， 但 对 其 政 治 自 主 ， 经 济 自 立 ， 军 事 自 卫 等 主 张 表 示 赞 同 ， 设 立 工 农 检 察 院 以 检 察 朝 鲜 的 官 僚 机 构 和 经 济 单 位 。 对 于 南 方 的 私 有 资 本 进 行 国 有 化 ， 并 逐 步 纳 入 计 划 经 济 ， 但 是 对 工 会 的 权 力 进 行 部 分 下 放 并 对 工 会 进 行 民 主 化 。 对 外 则 与 中 苏 等 社 会 主 义 国 家 继 续 保 持 友 好 关 系 。 朴 劳 解 为 首 的 朝 鲜 领 导 层 避 免 了 主 体 思 想 的 歪 路 ， 走 向 了 半 岛 特 色 社 会 主 义 的 新 路 。";
						}
						if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding == 4)
						{
							fake_text += " 蔡 万 洙 上 台 之 后 ， 开 始 着 手 进 行 去 主 体 化 ， 平 反 八 月 事 件 及 其 他 事 件 被 迫 害 的 延 安 派 和 国 内 派 ， 吸 收 南 方 的 部 分 左 翼 人 士 ， 并 在 党 代 会 上 发 表 了 《 关 于 光 复 以 来 党 的 若 干 历 史 问 题 的 决 议 》 ， 全 面 批 评 金 日 成 。 对 南 方 的 私 人 大 资 本 进 行 强 制 收 购 ， 进 行 让 南 方 经 济 并 入 计 划 经 济 的 改 革 并 增 加 工 人 的 权 力 ， 允 许 工 人 夺 权 。 在 国 际 上 则 批 评 苏 东 集 团 为 斯 大 林 的 叛 徒 ， 并 谴 责 美 国 的 经 济 殖 民 主 义 和 霸 权 主 义 ， 坚 定 的 站 在 以 中 国 为 首 的 革 命 阵 营 一 侧 。";
						}
						if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding == 5)
						{
							fake_text += " 尹 素 英 上 台 之 后 便 着 手 开 始 进 行 激 进 改 革 ， 首 先 将 朝 鲜 党 内 的 主 体 派 和 官 僚 分 子 大 量 清 理 ， 并 宣 布 主 体 思 想 是 背 叛 了 列 宁 主 义 ， 并 着 手 进 行 党 政 机 关 的 民 主 化 ， 将 最 高 人 民 会 议 改 组 为 十 月 革 命 初 期 的 苏 维 埃 。 经 济 上 则 按 照 布 达 佩 斯 学 派 和 奥 地 利 马 克 思 主 义 的 理 论 ， 对 南 方 的 大 资 本 进 行 国 有 化 收 购 并 对 北 方 的 “ 国 家 资 本 主 义 ” 进 行 市 场 化 改 革 ， 按 照 南 斯 拉 夫 的 工 人 自 治 理 论 对 经 济 单 位 实 行 政 企 分 离 和 民 主 化 。 这 一 看 起 来 似 乎 新 奇 的 制 度 被 正 统 马 列 主 义 者 批 评 为 翻 版 的 南 斯 拉 夫 和 匈 牙 利 ， 而 西 方 马 克 思 主 义 者 则 兴 奋 不 已 ， 他 们 终 于 看 到 了 自 己 的 理 论 在 地 球 上 的 实 践 。";
						}
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[10].puppetOf == 1 && GlobalScript.inst.gameState.allcountries[10].parts[0])
				{
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 0 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 1 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 17)
					{
						fake_text += " <size=40>延 安 派 的 复 仇</size>|朝 鲜 半 岛 在 中 国 的 帮 助 下 恢 复 了 统 一 ， 新 解 放 的 南 方 地 区 开 始 了 轰 轰 烈 烈 的 改 造 运 动 ： 工 厂 收 归 国 有 并 按 照 鞍 钢 宪 法 进 行 工 人 民 主 ， 农 村 建 立 公 社 ， 各 市 郡 恢 复 了 光 复 初 期 的 人 民 委 员 会 ， 部 分 吸 收 先 进 工 人 和 劳 工 运 动 人 士 参 与 其 中 并 开 始 进 行 直 接 民 主 的 尝 试 ， 平 反 南 方 游 击 队 ， 清 洗 前 韩 军 高 层 和 前 政 府 人 士 ， 鉴 于 南 北 分 隔 数 十 年 所 产 生 的 各 种 差 异 ， 分 别 成 立 南 方 局 与 北 方 局 以 适 应 各 地 特 色 ， 而 在 文 化 上 则 允 许 摇 滚 乐 与 电 子 乐 等 进 行 演 奏 ， 邀 请 维 克 托 崔 和 崔 健 前 来 创 作 并 组 建 了 普 天 堡 电 子 乐 团 进 行 本 土 红 歌 创 作 。 对 外 则 始 终 站 在 以 中 国 为 首 的 革 命 阵 营 一 方 ， 并 与 中 国 展 开 经 济 文 化 等 各 方 面 交 流 。 由 此 ， 朝 鲜 在 马 列 主 义 毛 泽 东 思 想 的 指 引 下 走 向 了 新 生 。";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 2)
					{
						fake_text += " <size=40>列 宁 主 义 再 复 兴 ？</size>|朝 鲜 半 岛 在 中 国 的 支 持 下 恢 复 了 统 一 ， 新 政 府 吸 纳 了 南 方 的 进 步 派 和 劳 工 运 动 代 表 ， 并 将 最 高 人 民 会 议 改 组 为 最 高 苏 维 埃 ， 实 行 多 党 参 政 制 。 新 政 府 将 会 按 照 按 照 列 宁 的 末 期 理 论 进 行 改 造 ， 设 立 并 提 高 工 农 检 察 院 的 地 位 ， 但 工 农 检 察 院 要 在 党 的 领 导 下 进 行 工 作 。 南 方 地 区 的 大 资 本 收 归 国 有 ， 但 是 仍 暂 时 允 许 城 市 内 部 小 生 产 的 存 在 。 朝 鲜 与 中 国 等 社 会 主 义 国 家 站 在 一 起 ， 直 到 实 现 共 产 主 义 的 胜 利 。";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 18)
					{
						fake_text += "<size=40>无 尽 的 革 命</size>|朝 鲜 半 岛 在 中 国 为 首 的 第 四 国 际 阵 营 的 帮 助 下 恢 复 了 统 一 ， 从 北 边 归 来 的 托 洛 茨 基 主 义 者 们 吸 收 “ 先 进 工 人 ” 和 信 仰 托 洛 茨 基 主 义 的 学 生 ， 并 把 他 们 组 织 成 教 导 队 前 往 全 国 各 地 指 导 工 作 ， 各 地 的 打 击 资 本 家 和 反 动 派 以 及 官 僚 工 人 国 家 代 言 人 的 运 动 此 起 彼 伏 。 朝 鲜 内 部 派 系 演 变 成 为 了 以 支 持 分 权 计 划 经 济 和 正 统 托 洛 茨 基 主 义 的 亲 中 派 和 支 持 国 家 管 控 与 市 场 经 济 和 新 托 洛 茨 基 主 义 的 自 立 派 两 大 派 系 。 两 方 就 未 来 的 经 济 ， 政 治 等 方 向 产 生 了 新 一 轮 的 论 战 ， 程 度 之 激 烈 堪 比 内 战 。 可 能 檀 君 也 不 会 知 道 半 岛 未 来 究 竟 会 前 进 还 是 停 滞 甚 至 倒 退 …";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 10 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 13)
					{
						fake_text += "<size=40>以 吴 代 金</size>|朝 鲜 半 岛 在 中 国 的 支 持 下 恢 复 了 统 一 ， 南 部 进 入 了 无 限 期 军 管 以 镇 压 南 方 的 反 革 命 分 子 ， 大 量 的 右 派 被 强 制 送 往 集 中 营 ， 南 部 资 本 强 制 国 有 化 ， 全 国 实 行 先 军 政 策 ， 南 部 普 通 民 众 则 被 强 制 编 入 预 备 役 进 行 军 事 训 练 和 政 治 思 想 教 育 。 吴 振 宇 大 元 帅 宣 布 朝 鲜 将 与 一 切 反 革 命 分 子 和 美 帝 国 主 义 帮 凶 决 裂 并 再 次 表 明 如 有 需 要 可 以 直 接 参 与 对 美 帝 国 主 义 的 战 争 中 。 随 后 围 绕 着 吴 振 宇 大 元 帅 的 个 人 崇 拜 近 乎 使 其 成 为 统 治 朝 鲜 的 王 ， 吴 振 宇 之 子 吴 日 晶 也 成 为 了 吴 振 宇 的 接 班 人 。 自 此 ， 朝 鲜 摆 脱 了 金 氏 家 族 统 治 ， 又 进 入 了 吴 氏 家 族 的 统 治 … …";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 7 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 9 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 12)
					{
						fake_text += "<size=40>天 道 教 神 国</size>|朝 鲜 半 岛 在 中 国 的 支 持 下 恢 复 了 统 一 ， 新 政 府 缩 紧 宗 教 限 制 ， 但 是 放 宽 鼓 励 天 道 教 的 传 播 。 新 政 府 以 天 道 教 教 义 为 其 理 论 基 础 ， 宣 扬 人 与 自 然 和 谐 以 及 人 人 平 等 和 一 些 儒 教 观 念 ， 但 是 针 对 进 步 派 与 劳 工 运 动 选 择 镇 压 ， 对 于 南 方 的 保 守 派 和 民 主 派 则 允 许 他 们 参 政 ， 天 道 教 青 友 党 在 接 下 来 的 数 次 选 举 中 获 得 大 量 支 持 ， 得 以 长 期 连 任 。 天 道 教 朝 鲜 将 与 中 国 坚 定 的 站 在 一 起 ， 而 天 道 教 将 会 成 为 朝 鲜 的 一 个 标 签 。";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 16)
					{
						fake_text += " <size=40>列 宁 主 义 再 复 兴 ？</size>|朝 鲜 半 岛 在 中 国 的 支 持 下 恢 复 了 统 一 ， 新 政 府 吸 纳 了 南 方 的 进 步 派 和 劳 工 运 动 代 表 ， 并 将 最 高 人 民 会 议 改 组 为 最 高 苏 维 埃 ， 实 行 多 党 参 政 制 。 新 政 府 将 会 按 照 按 照 列 宁 的 末 期 理 论 进 行 改 造 ， 设 立 并 提 高 工 农 检 察 院 的 地 位 ， 但 工 农 检 察 院 要 在 党 的 领 导 下 进 行 工 作 。 南 方 地 区 的 大 资 本 收 归 国 有 ， 但 是 仍 暂 时 允 许 城 市 内 部 小 生 产 的 存 在 。 朝 鲜 与 中 国 等 社 会 主 义 国 家 站 在 一 起 ， 直 到 实 现 共 产 主 义 的 胜 利 。";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 19)
					{
						fake_text += " <size=40>传 承 基 因 ， 克 己 复 礼</size>|靠 着 我 们 的 帮 助 ， 和 我 们 的 革 命 战 友 孔 镇 泰 同 志 的 红 色 基 因 所 带 来 的 革 命 智 慧 ， 朝 鲜 重 归 一 统 。 新 统 一 的 朝 鲜 迅 速 对 南 朝 鲜 公 民 进 行 了 血 统 论 式 的 排 查 ， 工 人 农 民 变 成 普 通 公 民 ， 带 有 地 富 反 坏 右 成 分 的 人 则 被 集 中 起 来 关 在 劳 改 营 里 接 受 公 审 、 强 制 劳 役 ， 私 有 企 业 被 全 部 充 公 并 纳 入 计 划 经 济 体 系 内 。 孔 镇 泰 同 志 提 出 了 一 套 名 为 儒 家 共 产 主 义 的 指 导 思 想 ， 该 理 论 主 张 以 孔 子 的 仁 爱 思 想 和 马 列 主 义 为 基 ， 批 判 性 吸 收 改 造 后 继 的 社 会 主 义 思 想 家 的 理 论 。 新 的 朝 鲜 政 府 开 始 宣 传 塑 造 孔 子 作 为 “ 有 史 以 来 的 第 一 个 社 会 主 义 者 ” 的 形 象 （ 据 悉 ， 一 部 中 朝 合 作 拍 摄 的 电 影 《 当 孔 子 遇 见 马 克 思 》 已 经 于 最 近 在 朝 鲜 全 国 各 地 上 映 ） ， 原 本 因 西 方 影 响 和 日 本 殖 民 而 衰 败 的 半 岛 儒 学 因 此 得 以 复 兴 ， 孔 镇 泰 也 自 然 而 然 地 成 为 了 “ 金 刚 山 和 白 头 山 共 同 缔 造 的 纯 洁 的 伟 大 的 革 命 家 ” “ 半 岛 人 民 永 远 的 领 袖 ” “ 千 年 儒 家 文 化 的 传 承 者 ” ， 曾 在 南 伪 政 权 从 事 政 军 商 等 业 的 孔 子 后 裔 们 也 均 在 学 习 班 进 行 改 造 和 丰 厚 的 物 质 奖 励 面 前 痛 改 前 非 ， 摇 身 一 变 成 为 “ 至 圣 先 师 的 革 命 后 代 ” 并 被 安 排 到 了 朝 鲜 南 部 的 各 个 重 要 岗 位 上 。 四 书 五 经 被 列 入 了 各 大 中 小 学 校 的 必 读 书 目 内 ， “ 克 己 复 礼 ” “ 仁 义 礼 智 信 ” “ 君 君 臣 臣 父 父 子 子 ” 等 优 秀 传 统 文 化 成 为 了 新 一 代 朝 鲜 人 所 必 须 学 习 的 思 想 。 在 这 里 ， 古 老 先 贤 血 脉 与 现 代 革 命 热 情 所 结 合 ， 形 成 了 一 套 独 属 于 该 国 的 独 特 政 治 体 系 。 尽 管 新 的 革 命 儒 学 与 原 来 的 儒 学 有 所 不 同 ， 流 亡 海 外 的 所 谓 孔 子 后 裔 也 对 朝 鲜 “ 篡 改 儒 家 思 想 ” 的 行 为 表 示 批 评 ， 不 过 ， 在 孔 夫 子 的 这 么 多 后 裔 中 出 一 两 个 败 类 也 实 在 是 再 正 常 不 过 的 事 了 ， 就 让 这 些 内 外 反 动 派 说 朝 鲜 这 也 不 行 那 也 不 行 去 吧 ， 半 岛 的 大 儒 们 自 会 为 红 色 孔 家 辩 经 。 在 圣 人 革 命 血 统 的 带 领 下 ， 朝 鲜 一 定 会 和 社 会 主 义 阵 营 一 起 走 向 孔 夫 子 理 想 中 “ 天 下 为 公 ” 的 “ 大 同 社 会 ” 。";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 15 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 11 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 8)
					{
						fake_text += " <size=40>朝 鲜 特 色 社 会 主 义</size>|朝 鲜 半 岛 在 中 国 的 支 持 下 恢 复 了 统 一 ， 朝 鲜 开 始 实 行 类 似 中 国 改 革 开 放 的 政 策 ， 经 济 上 逐 渐 开 放 ， 政 治 上 则 部 分 进 行 明 面 上 的 改 革 。 西 方 也 正 在 通 过 经 济 开 放 潜 移 默 化 的 影 响 朝 鲜 ， 在 数 年 之 后 ， 一 场 由 经 济 波 动 导 致 的 民 主 运 动 爆 发 ， 在 金 正 日 的 强 硬 态 度 下 ， 首 尔 ， 平 壤 等 地 的 运 动 接 连 被 军 队 平 息 下 去 。 因 此 西 方 开 始 对 朝 鲜 实 行 制 裁 ， 而 朝 鲜 被 迫 继 续 紧 紧 依 靠 着 中 国 老 大 哥 发 展 。 为 了 平 息 民 主 化 思 潮 ， 朝 鲜 组 织 了 普 天 堡 电 子 乐 团 并 大 力 宣 扬 先 军 政 策 和 对 金 正 日 的 个 人 崇 拜 。 朝 鲜 将 继 续 在 金 家 的 光 辉 下 前 行 。";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 3 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 14)
					{
						fake_text += " <size=40>人 道 民 主 社 会 主 义 之 胜 利</size>|朝 鲜 半 岛 在 中 国 的 支 持 下 恢 复 了 统 一 ， 新 政 府 接 纳 南 部 的 进 步 派 和 民 主 派 人 士 ， 劳 动 党 的 一 党 专 政 地 位 逐 渐 变 为 多 党 选 举 ， 经 济 体 制 也 从 计 划 经 济 改 为 国 家 管 控 资 本 主 义 ， 八 月 事 件 的 南 方 派 也 被 平 反 。 之 后 ， 朝 鲜 劳 动 党 加 入 了 社 会 党 国 际 ， 并 与 欧 洲 社 会 党 保 存 密 切 联 系 ， 当 然 ， 朝 鲜 仍 然 是 中 国 最 亲 密 的 伙 伴 。";
					}
					if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 4 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 5 || GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 6)
					{
						fake_text += "<size=40>以 民 主 击 溃 专 制 </size>|朝 鲜 半 岛 在 以 中 国 为 首 的 泛 亚 联 盟 的 帮 助 下 恢 复 了 统 一 。 新 的 朝 鲜 政 府 接 纳 了 南 方 的 野 党 和 民 主 运 动 势 力 ， 但 也 接 纳 了 前 政 府 的 部 分 人 士 ， 统 一 后 的 第 一 次 大 选 在 数 年 之 后 如 期 举 行 ， 参 与 率 高 达 9 0 ％ 以 上 ， 最 终 还 是 自 由 独 立 党 获 胜 ； 朝 鲜 实 行 完 全 的 市 场 经 济 并 开 始 与 南 方 各 大 垄 断 资 本 合 作 ， 源 源 不 断 的 中 国 资 本 与 南 部 垄 断 资 本 汇 入 半 岛 ， 统 一 后 的 新 市 场 为 垄 断 资 本 和 朝 鲜 政 府 带 来 了 双 赢 ， 但 是 半 岛 境 内 的 劳 工 运 动 则 此 起 彼 伏 。 朝 鲜 将 会 与 中 美 肩 并 肩 ， 一 起 反 对 社 会 主 义 阵 营 ， 捍 卫 民 主 与 自 由 。";
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding < 0)
				{
					if (GlobalScript.inst.gameState.allcountries[10].puppetOf == 1)
					{
						if (!GlobalScript.inst.gameState.allcountries[10].parts[0] && !GlobalScript.inst.gameState.allcountries[46].parts[0])
						{
							fake_text += " 朝 鲜 半 岛 目 前 仍 处 于 分 裂 状 态 ， 只 不 过 朝 鲜 方 面 由 受 社 会 主 义 阵 营 影 响 变 成 受 中 国 影 响 ， 朝 韩 双 方 互 相 对 骂 对 方 为 傀 儡 伪 政 权 。 之 后 ， 随 着 中 国 在 朝 鲜 部 署 导 弹 被 美 国 卫 星 发 现 ， 半 岛 局 势 又 迅 速 升 温 ， 未 来 可 能 会 因 此 成 为 引 爆 三 战 的 导 火 索 。";
						}
						else if (GlobalScript.inst.gameState.allcountries[10].parts[0])
						{
							fake_text += " 在 朝 鲜 统 一 了 半 岛 之 后 ， 南 北 地 区 的 漫 长 整 合 也 开 始 了 起 来 。 朝 鲜 和 中 国 保 持 紧 密 关 系 ， 朝 鲜 问 题 的 解 决 也 使 得 东 亚 的 局 势 变 得 更 加 缓 和 起 来 ， 尽 管 这 一 结 局 并 不 是 美 国 所 希 望 的 那 样 。";
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[10].parts[0] && GlobalScript.inst.gameState.event_done[495])
					{
						fake_text += " 在 分 裂 了 数 十 年 之 后 ， 半 岛 终 于 归 于 统 一 ， 汉 城 奥 运 会 也 成 功 举 行 。 对 外 则 奉 行 独 立 自 主 的 外 交 ， 与 周 边 各 国 交 好 ， 东 亚 地 区 局 势 也 开 始 稳 定 起 来 。 但 是 统 一 之 后 随 之 而 来 的 问 题 也 同 样 具 有 争 议 ： 南 北 发 展 差 距 ， 内 战 到 统 一 前 的 政 治 定 性 问 题 等 ， 经 济 所 带 来 的 贫 富 差 距 和 政 治 上 的 开 放 以 及 政 治 清 算 也 使 得 两 边 的 保 守 派 不 满 ， 不 过 尽 管 分 裂 所 带 来 的 差 距 是 巨 大 的 ， 但 是 相 信 只 要 假 以 时 日 ， 这 些 隔 阂 是 终 将 消 除 的 。";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(50);
						}
					}
					else if (!GlobalScript.inst.gameState.allcountries[10].parts[0] && GlobalScript.inst.gameState.data[83] <= 0 && !GlobalScript.inst.gameState.allcountries[46].Vyshi && (GlobalScript.inst.gameState.allcountries[46].SubGosstroy == 5 || GlobalScript.inst.gameState.allcountries[46].SubGosstroy == 3) && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 2)
					{
						fake_text += " 朝 韩 双 方 最 初 相 互 承 认 对 方 ， 汉 城 奥 运 会 也 顺 利 举 办 ， 双 方 派 出 统 一 代 表 团 参 加 ， 并 于 1 9 9 4 年 同 时 进 入 联 合 国 ， 但 是 在 数 次 南 北 谈 判 中 始 终 没 有 进 一 步 进 展 ， 双 方 停 留 在 互 相 承 认 和 人 员 通 行 自 由 等 初 级 承 诺 ， 或 许 未 来 半 岛 最 终 走 向 统 一 ， 但 不 会 是 现 在 … …";
					}
					else if (GlobalScript.inst.gameState.data[83] <= 0 && (!GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.empires[1].now_leader == 6) && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 1)
					{
						fake_text += " 朝 鲜 半 岛 上 没 有 发 生 什 么 太 多 的 变 化 — — 朝 韩 对 抗 继 续 。 在2000 年 代 初 ， 朝 鲜 开 始 开 发 核 武 器 以 保 护 自 己 不 受 美 国 侵 略 。 朝 鲜 继 续 贯 彻 中 立 的 外 交 政 策 ， 与 中 国 和 莫 斯 科 维 持 良 好 关 系 ， 但 不 加 入 他 们 的 阵 营 。";
					}
					else if (GlobalScript.inst.gameState.data[83] <= 0 && GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 1)
					{
						fake_text += " 朝 鲜 半 岛 上 没 有 发 生 什 么 太 多 的 变 化 — — 朝 韩 对 抗 继 续 。 为 取 得 优 势 ， 在90 年 代 初 ， 朝 鲜 见 到 中 苏 之 间 的 决 裂 终 于 愈 合 后 ， 加 入 了 经 互 会 ， 不 久 后 又 加 入 华 约 。 这 为 其 提 供 了 经 济 增 长 和 对 抗 美 国 侵 略 的 坚 实 保 障 。";
					}
					else if (GlobalScript.inst.gameState.data[83] <= 0 && (!GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.empires[1].now_leader == 6) && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 2)
					{
						fake_text += " 朝 鲜 半 岛 上 没 有 发 生 什 么 太 多 的 变 化 — — 朝 韩 对 抗 继 续 ， 尽 管 形 势 更 加 温 和 。 朝 鲜 开 展 了 大 规 模 改 革 — — 这 意 味 着 计 划 经 济 的 去 中 心 化 ， 民 事 自 由 化 ， 经 济 特 区 的 开 放 也 在 计 划 之 中 。 尽 管 这 些 举 动 改 善 了 朝 鲜 和 美 国 及 其 亲 美 邻 居 的 关 系 ， 但 在2000 年 代 初 ， 朝 鲜 开 始 开 发 核 武 器 以 保 护 自 己 不 受 美 国 侵 略 。 朝 鲜 继 续 贯 彻 中 立 的 外 交 政 策 ， 与 中 国 和 莫 斯 科 维 持 良 好 关 系 ， 但 不 加 入 他 们 的 阵 营 。";
					}
					else if (GlobalScript.inst.gameState.data[83] <= 0 && GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 2)
					{
						fake_text += " 朝 鲜 半 岛 上 没 有 发 生 什 么 太 多 的 变 化 — — 朝 韩 对 抗 继 续 ， 尽 管 形 势 更 加 温 和 。 朝 鲜 开 展 了 大 规 模 改 革 － 这 意 味 着 计 划 经 济 的 去 中 心 化 ， 民 事 自 由 化 ， 经 济 特 区 的 开 放 也 在 计 划 之 中 。 尽 管 这 些 举 动 改 善 了 朝 鲜 和 美 国 及 其 亲 美 邻 居 的 关 系 ， 但 朝 鲜 在90 年 代 见 到 中 苏 之 间 的 决 裂 愈 合 后 ， 加 入 了 经 互 会 ， 不 久 后 加 入 华 约 。 这 为 其 提 供 了 经 济 增 长 和 对 抗 美 国 侵 略 的 坚 实 保 障 。";
					}
					else if (GlobalScript.inst.gameState.data[83] == 1)
					{
						fake_text += " 在 朝 鲜 统 一 半 岛 并 驱 逐 美 国 侵 略 者 后 ， 长 久 期 待 的 复 兴 和 发 展 在 朝 鲜 开 始 了 ， 紧 接 着 ， 在90 年 代 朝 鲜 宣 布 成 功 开 发 了 核 武 器 。";
						if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
						{
							fake_text += "|| 朝 鲜 ， 在 核 弹 头 的 保 护 之 下 ， 迅 速 开 展 独 立 的 外 交 政 策 。 朝 鲜 尝 试 成 为 新 的 地 区 和 全 球 政 治 中 的 独 立 力 量 ， 看 起 来 这 一 点 最 终 也 会 得 以 实 现 。";
							if (GlobalScript.inst.gameState.iron_and_blood)
							{
								achieves.GetComponent<achievements>().Set(16);
							}
						}
						else if (GlobalScript.inst.gameState.allcountries[10].econ)
						{
							fake_text += "|| 不 久 朝 鲜 加 入 了 我 们 的 联 盟 ， 这 进 一 步 增 强 了 该 国 经 济 。";
						}
						else
						{
							fake_text += "|| 不 久 朝 鲜 加 入 了 经 互 会 ， 这 进 一 步 增 强 了 该 国 经 济 。";
						}
					}
					else if (GlobalScript.inst.gameState.data[83] == 2)
					{
						if (GlobalScript.inst.gameState.allcountries[46].SubGosstroy == 9)
						{
							fake_text += " 韩 半 岛 在 中 国 的 帮 助 下 恢 复 了 统 一 ， 大 韩 民 族 党 宣 布 尊 崇 李 范 奭 将 军 ， 并 将 一 民 主 义 和 部 分 法 西 斯 主 义 的 理 论 作 为 其 理 论 指 导 。 集 中 营 在 全 国 遍 地 开 花 ， 专 门 用 来 关 押 不 听 话 的 进 步 派 ， 共 产 主 义 者 和 民 主 派 等 人 士 ， 檀 君 神 话 被 当 作 正 史 并 写 入 教 材 。 新 政 府 基 于 建 构 民 族 主 义 福 利 经 济 的 构 想 ， 对 于 全 国 的 土 地 进 行 了 大 规 模 土 改 ， 国 有 化 了 几 乎 所 有 外 资 的 资 产 并 拍 卖 养 肥 国 内 财 阀 ， 几 乎 驱 逐 了 所 有 外 国 公 民 ， 但 得 益 于 我 们 的 关 系 ， 我 们 的 资 产 以 赎 买 的 方 式 得 到 了 赔 偿 。 “ 朝 鲜 青 年 团 ” 被 重 新 组 建 ， 同 时 吸 纳 了 劳 动 党 的 社 会 主 义 爱 国 青 年 同 盟 。 然 而 这 个 一 民 主 义 韩 国 与 中 国 的 友 好 关 系 也 使 得 韩 国 的 一 民 主 义 宣 传 处 于 比 较 尴 尬 的 地 位 ， 两 边 的 极 端 民 族 主 义 者 对 此 都 十 分 不 满 …";
						}
						else
						{
							fake_text += " 在 朝 鲜 战 败 ， 半 岛 统 一 在 韩 国 旗 下 后 ， 美 国 首 先 向 被 吞 并 地 区 派 遣 更 多 部 队 ， 以 对 抗 滋 长 的 游 击 队 活 动 。 但 游 击 队 控 制 了 许 多 的 北 方 地 区 ， 并 通 过 不 间 断 的 攻 击 以 消 耗 美 国 人 。 看 起 来 长 久 期 待 的 朝 鲜 复 兴 的 到 来 仍 然 遥 遥 无 期 。";
							if (GlobalScript.inst.gameState.empires[1].now_leader != 6 || GlobalScript.inst.gameState.data[14] < 3)
							{
								fake_text += "|| 不 久 美 国 人 为 了 “ 捍 卫 该 地 区 和 平 和 美 国 利 益 ” ， 在 朝 鲜 部 署 了 核 武 器 ， 这 激 起 了 许 多 国 家 对 此 的 抗 议 。";
								if (GlobalScript.inst.gameState.iron_and_blood)
								{
									achieves.GetComponent<achievements>().Set(51);
								}
							}
						}
					}
					else
					{
						fake_text += " 朝 鲜 半 岛 没 有 什 么 新 闻 。";
					}
				}
				else
				{
					fake_text += " 有 赖 于 我 们 的 牺 牲 ， 朝 鲜 得 以 统 一 半 岛 并 驱 逐 美 国 侵 略 者 ， 因 此 ， 我 们 也 得 以 直 接 过 问 朝 鲜 的 命 运 。";
				}
			}
			else if (number_of_e == 10)
			{
				name.text = " 一 衣 带 水 的 邻 居 —— 日 本";
				fake_text = "";
				if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 6)
				{
					fake_text += " 一 党 独 大 式 民 主";
					fake_text += "| 最 终 ， 自 由 民 主 党 挺 过 了 7 0 年 代 的 危 机 。 伴 随 着 石 油 危 机 的 结 束 、 西 方 经 济 的 再 次 兴 起 和 美 苏 冷 战 攻 守 态 势 的 逆 转 。 中 曾 根 康 弘 带 领 新 政 府 信 心 满 满 地 开 始 了 新 自 由 主 义 改 革 ： 首 先 便 是 全 面 推 行 国 有 企 业 的 拆 分 重 组 以 及 私 有 化 。 尤 其 强 硬 推 动 了 日 本 国 有 铁 道 、 日 本 电 信 电 话 公 社 、 日 本 专 卖 公 社 这 三 大 国 营 公 司 的 私 有 化 （ 因 为 这 些 国 有 公 司 的 工 人 都 是 社 会 党 的 铁 杆 支 持 者 ， 且 公 司 本 身 也 弊 病 缠 身 ） 。 同 时 鼓 励 私 营 企 业 进 入 关 键 行 业 领 域 以 进 一 步 发 挥 市 场 经 济 的 活 力 。 鼓 励 大 企 业 向 海 外 发 展 （ 以 至 于 由 于 对 美 高 附 加 值 产 品 出 口 过 于 强 劲 而 出 现 了 日 美 贸 易 摩 擦 问 题 ） 并 大 力 发 展 高 科 技 产 业 。 虽 然 由 于 中 曾 根 政 府 没 有 及 时 实 施 应 对 土 地 价 格 暴 涨 的 货 币 紧 缩 政 策 ， 而 被 学 者 批 评 造 成 了 泡 沫 经 济 。 但 经 济 的 高 速 发 展 和 城 市 生 活 的 愈 发 富 足 还 是 让 他 的 政 府 得 到 了 城 市 市 民 的 空 前 支 持 。 农 业 方 面 则 延 续 自 由 民 主 党 的 一 贯 政 策 ， 依 靠 农 协 的 全 力 支 持 以 收 获 农 村 地 区 的 选 票 。 在 原 住 民 问 题 上 ， 新 政 府 依 旧 拒 绝 承 认 北 海 道 的 阿 伊 努 族 为 日 本 列 岛 的 原 住 民 与 少 数 民 族 ， 继 续 沿 用 “ 自 古 以 来 的 居 民 ” 这 样 的 说 法 ， 且 继 续 禁 止 其 一 切 宗 教 习 俗 ， 将 它 看 作 是 部 落 民 的 一 支 。 阿 伊 努 族 的 未 来 ， 灰 暗 而 漫 长 。||在 外 交 上 ， 新 政 府 一 改 往 届 政 府 的 多 面 外 交 立 场 ， 转 而 积 极 响 应 美 国 和 北 约 的 各 项 政 策 并 保 持 了 强 硬 的 反 苏 反 共 立 场 。 在 1 9 8 3 年 5 月 的 威 廉 斯 堡 峰 会 上 ， 针 对 如 何 应 对 苏 联 在 欧 洲 部 署 的 S S - 2 0 导 弹 这 一 问 题 ， 中 曾 根 明 确 表 示 ： “ 我 们 敢 于 在 这 里 达 成 一 致 ， 就 是 要 显 示 西 方 团 结 的 力 量 ， 把 苏 联 拉 到 谈 判 桌 上 来 。   只 有 苏 联 才 能 从 破 裂 中 获 益 。 ” 在 首 次 访 美 期 间 ， 他 还 提 出 了 “ 日 美 命 运 共 同 体 ” 主 张 并 表 示 如 有 必 要 将 “ 封 锁 三 个 海 峡 （ 千 岛 群 岛 、 津 轻 海 峡 和 对 马 海 峡 ） ” 以 应 对 苏 联 威 胁 。 此 外 中 曾 根 康 弘 还 是 战 后 第 一 个 访 问 韩 国 的 日 本 首 相 ， 解 决 了 前 几 任 首 相 时 期 关 于 对 韩 援 助 及 赔 款 数 额 的 问 题 ， 并 且 与 全 斗 焕 建 立 了 良 好 的 私 人 关 系 。 1 9 8 5 年 8 月 1 5 日 ， 他 成 为 二 战 后 第 一 个 参 拜 靖 国 神 社 的 日 本 首 相 （ 尤 其 日 期 还 是 在 8 月 1 5 日 ） ， 在 亚 洲 国 家 引 发 了 强 烈 抗 议 和 批 判 。 在 军 备 方 面 ， 新 政 府 放 弃 了 自 三 木 内 阁 以 来 将 防 卫 开 支 限 制 在 日 本 国 民 生 产 总 值 1 % 的 政 策 ， 取 而 代 之 的 是 明 确 规 定 防 卫 开 支 总 额 的 长 期 计 划 以 便 制 定 更 加 积 极 的 防 卫 政 策 ， 并 与 美 国 军 方 开 展 更 加 密 切 的 合 作 。 新 政 府 对 美 国 的 刻 意 讨 好 也 招 致 了 很 多 人 的 批 评 ， 称 中 曾 根 已 经 成 了 “ 美 国 总 统 的 信 使 ” 。 在 千 岛 群 岛 问 题 上 ， 新 政 府 继 续 要 求 苏 联 归 还 “ 侵 占 的 土 地 ” ， 认 为 在 二 战 已 经 结 束 近 四 十 年 的 今 天 ， 苏 联 继 续 控 制 这 一 地 区 不 仅 错 误 且 严 重 违 背 国 际 法 。 而 苏 联 则 一 如 既 往 地 置 之 不 理 。 苏 日 关 系 就 这 样 冷 淡 地 维 持 着 。||1 9 8 6 年 ， 自 由 民 主 党 在 众 议 院 取 得 3 0 4 个 席 位 的 空 前 大 胜 ， 进 一 步 巩 固 了 自 身 的 地 位 。 但 中 曾 根 本 人 由 于 本 人 的 多 次 不 正 当 言 论 以 及 试 图 强 行 引 入 消 费 税 招 致 党 内 外 反 对 ， 最 终 于 1 9 8 7 年 1 1 月 辞 职 并 指 名 竹 下 登 为 继 任 者 。||就 这 样 ， 日 本 继 续 沿 着 自 由 民 主 党 的 路 线 摇 摇 晃 晃 地 前 进 . . . . . .";
				}
				if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 5)
				{
					fake_text += " 一 党 独 大 式 民 主";
					fake_text += "| 最 终 ， 自 由 民 主 党 挺 过 了 7 0 年 代 的 危 机 。 伴 随 着 石 油 危 机 的 结 束 、 西 方 经 济 的 再 次 兴 起 和 美 苏 冷 战 攻 守 态 势 的 逆 转 。 中 曾 根 康 弘 带 领 新 政 府 信 心 满 满 地 开 始 了 新 自 由 主 义 改 革 ： 首 先 便 是 全 面 推 行 国 有 企 业 的 拆 分 重 组 以 及 私 有 化 。 尤 其 强 硬 推 动 了 日 本 国 有 铁 道 、 日 本 电 信 电 话 公 社 、 日 本 专 卖 公 社 这 三 大 国 营 公 司 的 私 有 化 （ 因 为 这 些 国 有 公 司 的 工 人 都 是 社 会 党 的 铁 杆 支 持 者 ， 且 公 司 本 身 也 弊 病 缠 身 ） 。 同 时 鼓 励 私 营 企 业 进 入 关 键 行 业 领 域 以 进 一 步 发 挥 市 场 经 济 的 活 力 。 鼓 励 大 企 业 向 海 外 发 展 （ 以 至 于 由 于 对 美 高 附 加 值 产 品 出 口 过 于 强 劲 而 出 现 了 日 美 贸 易 摩 擦 问 题 ） 并 大 力 发 展 高 科 技 产 业 。 虽 然 由 于 中 曾 根 政 府 没 有 及 时 实 施 应 对 土 地 价 格 暴 涨 的 货 币 紧 缩 政 策 ， 而 被 学 者 批 评 造 成 了 泡 沫 经 济 。 但 经 济 的 高 速 发 展 和 城 市 生 活 的 愈 发 富 足 还 是 让 他 的 政 府 得 到 了 城 市 市 民 的 空 前 支 持 。 农 业 方 面 则 延 续 自 由 民 主 党 的 一 贯 政 策 ， 依 靠 农 协 的 全 力 支 持 以 收 获 农 村 地 区 的 选 票 。 在 原 住 民 问 题 上 ， 新 政 府 依 旧 拒 绝 承 认 北 海 道 的 阿 伊 努 族 为 日 本 列 岛 的 原 住 民 与 少 数 民 族 ， 继 续 沿 用 “ 自 古 以 来 的 居 民 ” 这 样 的 说 法 ， 且 继 续 禁 止 其 一 切 宗 教 习 俗 ， 将 它 看 作 是 部 落 民 的 一 支 。 阿 伊 努 族 的 未 来 ， 灰 暗 而 漫 长 。||在 外 交 上 ， 新 政 府 一 改 往 届 政 府 的 多 面 外 交 立 场 ， 转 而 开 始 更 多 响 应 美 国 和 北 约 的 政 策 方 针 并 保 持 了 强 硬 的 反 苏 反 共 立 场 。 在 1 9 8 3 年 5 月 的 威 廉 斯 堡 峰 会 上 ， 针 对 如 何 应 对 苏 联 在 欧 洲 部 署 的 S S - 2 0 导 弹 这 一 问 题 ， 中 曾 根 明 确 表 示 ： “ 我 们 敢 于 在 这 里 达 成 一 致 ， 就 是 要 显 示 西 方 团 结 的 力 量 ， 把 苏 联 拉 到 谈 判 桌 上 来 。   只 有 苏 联 才 能 从 破 裂 中 获 益 。 ” 在 首 次 访 美 期 间 ， 他 也 多 次 谈 到 了 苏 联 的 威 胁 问 题 ， 并 表 示 日 本 将 坚 决 抵 御 共 产 主 义 可 能 的 蔓 延 。 此 外 新 政 府 也 非 常 重 视 与 中 国 的 友 好 关 系 。 中 曾 根 本 人 曾 计 划 访 问 韩 国 （ 如 果 落 实 他 将 成 为 战 后 第 一 个 访 问 韩 国 的 日 本 首 相 ） ， 但 在 党 内 亲 华 派 的 压 力 下 最 终 放 弃 。 而 原 定 于 1 9 8 5 年 8 月 1 5 日 举 行 的 新 政 府 对 靖 国 神 社 的 参 拜 活 动 最 终 也 被 取 消 。 之 后 中 曾 根 亲 率 高 级 别 代 表 团 来 华 访 问 。 期 间 中 日 双 方 签 署 了 一 系 列 贸 易 合 同 。 他 本 人 在 记 者 会 上 还 特 别 强 调 了 中 国 市 场 的 潜 力 ， 表 达 了 希 望 构 建 全 新 亚 太 贸 易 体 系 的 愿 景 。 并 且 承 认 了 日 本 在 第 二 次 世 界 大 战 中 犯 下 的 问 题 （ 整 体 延 续 了 1 9 7 2 年 中 日 两 国 公 报 中 的 日 方 表 态 ） 。 在 军 备 方 面 ， 新 政 府 继 续 维 持 了 自 三 木 内 阁 以 来 将 防 卫 开 支 限 制 在 日 本 国 民 生 产 总 值 1 % 的 政 策 ， 这 也 是 对 不 会 违 背 和 平 宪 法 的 明 确 表 态 。 在 千 岛 群 岛 问 题 上 ， 新 政 府 继 续 要 求 苏 联 归 还 “ 侵 占 的 土 地 ” ， 认 为 在 二 战 已 经 结 束 近 四 十 年 的 今 天 ， 苏 联 继 续 控 制 这 一 地 区 不 仅 错 误 且 严 重 违 背 国 际 法 。 而 苏 联 则 一 如 既 往 地 置 之 不 理 。 苏 日 关 系 就 这 样 冷 淡 地 维 持 着 。||1 9 8 6 年 ， 自 由 民 主 党 在 众 议 院 取 得 3 0 4 个 席 位 的 空 前 大 胜 ， 进 一 步 巩 固 了 自 身 的 地 位 。 但 中 曾 根 本 人 由 于 其 多 次 不 正 当 言 论 以 及 试 图 强 行 引 入 消 费 税 招 致 党 内 外 反 对 ， 最 终 于 1 9 8 7 年 1 1 月 辞 职 并 指 名 竹 下 登 为 继 任 者 。||就 这 样 ， 日 本 继 续 沿 着 自 由 民 主 党 的 路 线 摇 摇 晃 晃 地 前 进 . . . . . . ";
				}
				if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 4)
				{
					fake_text += " 构 造 改 革 的 重 生";
					fake_text += "| 依 靠 《 爱 、 知 、 力 的 创 造 》 的 新 宣 言 与 全 新 的 党 纲 ， 以 及 与 其 他 在 野 党 的 合 并 ， 社 会 党 的 后 继 者 社 会 民 主 党 最 终 实 现 了 保 革 逆 转 和 参 政 交 代 的 目 标 。 站 稳 脚 跟 之 后 ， 新 政 府 随 即 从 社 会 民 主 主 义 的 思 想 出 发 ， 重 拾 曾 经 社 会 党 改 革 派 提 出 的 “ 构 造 改 革 论 ” 并 开 始 了 施 政 。 在 经 济 方 面 ， 新 政 府 以 “ 国 民 的 福 利 与 生 活 的 提 高 ” 为 核 心 ， 对 大 企 业 进 行 了 一 定 程 度 的 管 控 ， 采 取 措 施 保 护 中 小 企 业 ， 完 善 市 场 经 济 体 制 并 确 保 政 府 能 在 关 键 时 刻 进 行 宏 观 调 控 。 同 时 对 工 人 和 工 会 的 权 利 进 行 了 重 新 修 订 ， 在 诸 多 问 题 上 进 行 了 限 制 ， 并 且 开 始 全 面 提 倡 “ 劳 资 合 作 ” 等 概 念 。 春 斗 等 劳 工 斗 争 被 固 定 化 、 制 度 化 ， 成 为 工 会 和 企 业 家 的 长 期 稳 定 沟 通 平 台 （ 这 也 意 味 着 对 其 阶 级 斗 争 色 彩 的 彻 底 抹 去 ， 使 它 变 成 了 一 种 类 似 法 团 主 义 的 治 理 术 ） 。 当 然 新 政 府 自 己 也 对 此 不 怎 么 遮 掩 ， 工 业 大 臣 在 一 次 大 会 便 表 示 这 是 “ 不 同 于 单 纯 的 反 对 和 打 倒 ， 而 是 对 垄 断 （ 资 本 ） 逻 辑 的 限 制 和 对 生 产 关 系 的 局 部 变 革 ， 即 对 “ 改 良 ” 意 义 的 重 视 ” 。 此 外 政 府 加 大 了 对 城 市 及 其 周 边 地 区 的 投 资 并 普 及 城 市 居 民 福 利 保 障 制 度 ， 这 得 到 了 他 们 的 大 力 支 持 。 在 农 村 地 区 ， 政 府 与 农 协 （ 全 国 协 同 农 业 组 合 联 合 会 ） 开 展 紧 密 合 作 ， 依 靠 它 对 全 国 农 民 进 行 有 效 管 理 。 但 同 时 也 对 其 架 构 进 行 一 定 调 整 使 得 政 府 可 以 进 行 更 大 幅 度 的 干 预 （ 为 了 保 证 农 协 能 够 接 受 这 点 ， 新 政 府 不 仅 承 诺 会 延 续 之 前 的 农 业 保 护 政 策 ， 不 对 外 全 面 开 放 农 产 品 市 场 并 维 持 进 口 高 关 税 ， 且 政 府 将 在 经 济 方 面 给 予 农 协 更 多 帮 助 ， 最 终 双 方 正 式 签 署 了 一 份 协 议 ） ， 最 终 形 成 了 政 府 和 农 协 的 共 同 管 理 体 系 。 农 民 继 续 在 他 们 所 制 定 的 框 架 下 互 帮 互 助 ， 尽 管 这 也 许 并 不 怎 么 符 合 他 们 的 心 意 . . . 此 外 新 政 府 推 动 了 对 北 海 道 阿 依 努 族 的 原 住 民 与 少 数 民 族 地 位 的 承 认 ， 并 着 手 对 过 去 的 种 种 限 制 加 以 废 除 或 放 宽 。 虽 然 还 不 算 够 ， 但 至 少 这 一 饱 经 苦 难 的 民 族 终 于 有 了 希 望 。||之 后 ， 新 政 府 开 始 组 织 对 当 前 中 选 区 制 选 举 制 的 改 革 。 对 选 区 、 候 选 人 数 量 、 政 党 单 个 地 区 可 提 名 人 数 等 都 进 行 了 规 定 ， 限 制 了 自 由 民 主 党 的 势 力 。 对 于 天 皇 制 问 题 ， 新 政 府 明 确 表 示 将 不 会 采 取 过 于 激 进 的 措 施 。 但 新 政 府 为 了 展 现 革 新 的 面 貌 还 是 采 取 了 一 些 措 施 ： 皇 室 庆 典 的 规 模 不 断 缩 水 ， 次 数 也 有 所 减 少 。 皇 室 成 员 的 相 关 形 象 也 被 削 弱 了 些 许 。 在 一 次 内 阁 会 议 上 ， 飞 鸟 田 一 雄 表 示 未 来 五 到 十 年 内 将 就 天 皇 制 问 题 发 起 一 次 全 民 公 投 。 最 后 关 于 自 卫 队 ， 新 政 府 承 认 了 它 的 违 宪 性 并 着 手 开 始 改 组 和 解 散 ， 但 同 时 也 强 调 为 了 保 卫 本 土 安 全 将 保 留 “ 最 低 限 度 的 人 员 ” 。||外 交 方 面 ， 新 政 府 开 始 积 极 与 社 会 党 国 际 、 不 结 盟 运 动 等 国 际 组 织 密 切 沟 通 ， 同 时 也 与 第 三 世 界 国 家 展 开 更 为 频 繁 的 外 交 往 来 。 此 外 社 会 民 主 党 也 加 强 了 中 日 两 国 之 间 的 经 贸 关 系 。 而 首 相 本 人 在 不 久 后 的 讲 话 中 也 对 日 本 在 第 二 次 世 界 大 战 中 对 亚 洲 人 民 犯 下 的 罪 行 表 示 忏 悔 与 反 思 ， 同 时 强 调 新 政 府 将 坚 决 维 护 和 平 宪 法 。 而 在 千 岛 群 岛 问 题 上 ， 新 政 府 考 虑 到 处 理 不 当 可 能 带 来 的 风 险 ， 选 择 暂 时 搁 置 此 事 。 在 外 交 场 合 也 只 是 含 糊 表 示 “ 未 来 将 就 这 一 问 题 与 苏 联 方 面 进 行 磋 商 ” 。 而 希 望 与 新 政 府 达 成 更 多 贸 易 合 同 的 苏 联 也 心 照 不 宣 地 保 持 了 对 此 事 的 低 调 。||至 此 ， 江 田 三 郎 的 愿 景 得 到 了 初 步 实 现 ： 一 个 改 良 主 义 的 日 本 正 在 被 一 点 点 构 建 出 来 。 但 它 未 来 会 怎 样 就 不 是 人 们 所 能 预 料 的 了 。 尤 其 考 虑 到 不 甘 失 败 的 自 由 民 主 党 正 在 不 断 积 攒 实 力 准 备 卷 土 重 来 的 情 况 下 . . . . . .";
				}
				if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 14)
				{
					fake_text += " 欧 洲 — — 日 本 共 产 主 义";
					fake_text += "| 通 过 学 习 欧 洲 共 产 主 义 思 想 并 全 面 修 改 纲 领 口 号 以 吸 引 市 民 阶 层 ， 打 出 “ 人 民 议 会 主 义 ” 的 日 本 共 产 党 最 终 在 国 际 局 势 的 变 化 中 成 功 率 领 日 本 人 民 民 主 联 合 阵 线 实 现 了 保 革 逆 转 与 参 政 交 代 的 目 标 。 上 台 不 久 ， 新 政 府 便 明 确 了 目 标 ： 以 1 9 7 6 年 的 《 自 由 与 民 主 宣 言 》 为 要 点 ， 全 面 维 护 “ 生 存 的 自 由 、 市 民 的 政 治 自 由 、 民 族 的 自 由 ” 。 经 济 上 保 证 政 府 对 必 要 时 刻 的 干 预 权 以 及 整 体 上 宏 观 调 控 的 权 利 ， 对 大 企 业 施 以 一 定 的 限 制 并 鼓 励 扶 植 中 小 企 业 的 发 展 ， 确 保 市 场 经 济 体 制 更 加 良 好 地 运 行 下 去 。 同 时 促 进 劳 资 关 系 的 “ 和 谐 发 展 ” 。 春 斗 等 劳 工 斗 争 被 固 定 化 、 制 度 化 ， 成 为 工 会 和 企 业 家 的 长 期 稳 定 沟 通 平 台 （ 这 也 意 味 着 对 其 阶 级 斗 争 色 彩 的 彻 底 抹 去 ， 使 其 变 成 了 一 种 类 似 法 团 主 义 的 治 理 术 ） 。 此 外 政 府 加 大 了 对 城 市 及 其 周 边 地 区 的 投 资 ， 解 决 公 害 问 题 的 同 时 提 高 了 市 民 的 生 活 水 平 ， 这 得 到 了 他 们 的 广 泛 支 持 。 在 农 村 地 区 ， 政 府 与 农 协 （ 全 国 协 同 农 业 组 合 联 合 会 ） 开 展 紧 密 合 作 ， 依 靠 它 对 全 国 农 民 进 行 有 效 管 理 ， 但 也 对 其 体 制 中 存 在 的 一 些 问 题 进 行 改 革 ， 最 终 形 成 了 政 府 和 农 协 的 共 同 管 理 体 系 。 农 民 继 续 在 他 们 所 制 定 的 框 架 下 互 帮 互 助 ， 尽 管 这 也 许 并 不 怎 么 符 合 他 们 的 心 意 . . . 此 外 新 政 府 正 式 承 认 了 北 海 道 阿 依 努 族 的 原 住 民 与 少 数 民 族 地 位 ， 废 除 了 过 去 对 他 们 的 种 种 限 制 。 虽 然 政 府 并 未 开 展 更 多 活 动 ， 但 至 少 这 一 饱 经 苦 难 的 民 族 终 于 被 正 名 了 。||政 党 方 面 ， 宫 本 显 治 明 确 承 认 了 多 党 制 和 政 权 交 替 制 度 的 合 法 性 。 且 不 会 采 取 “ 共 产 党 的 一 党 制 度 ” 。 此 外 他 还 表 示 “ 维 护 资 产 阶 级 的 民 主 和 权 利 ， 当 然 是 党 和 工 人 阶 级 的 任 务 ” 。 这 番 发 言 引 起 了 社 会 党 左 派 以 及 党 外 各 路 革 命 左 翼 的 愤 怒 。 而 自 由 民 主 党 和 商 界 对 此 也 反 应 不 一 ， 大 部 分 人 都 认 为 这 不 过 是 “ 共 产 党 人 的 一 贯 把 戏 ” ， 目 的 只 是 让 他 们 放 松 警 惕 。 对 于 天 皇 制 ， 新 政 府 明 确 表 示 将 不 会 采 取 过 于 激 进 的 措 施 ， 但 结 束 这 一 体 制 的 最 终 目 标 不 会 改 变 。 许 多 皇 室 庆 典 被 叫 停 ， 皇 室 成 员 的 相 关 形 象 也 在 被 逐 步 从 社 会 上 抹 去 。 在 一 次 内 阁 会 议 上 ， 宫 本 显 治 表 示 未 来 五 到 十 年 内 将 就 天 皇 制 问 题 发 起 一 次 全 民 公 投 。 关 于 自 卫 队 问 题 ， 新 政 府 承 认 了 它 的 违 宪 性 并 着 手 开 始 改 组 和 解 散 ， 但 同 时 也 强 调 为 了 保 卫 本 土 安 全 将 保 留 “ 最 低 限 度 的 人 员 ” 。||外 交 方 面 ， 新 政 府 开 始 积 极 与 社 会 党 国 际 、 不 结 盟 运 动 等 国 际 组 织 密 切 沟 通 ， 同 时 也 与 第 三 世 界 国 家 展 开 更 为 频 繁 的 外 交 往 来 。 另 外 也 加 强 了 中 日 两 国 之 间 的 经 贸 关 系 ， 希 望 能 够 构 建 以 中 日 两 国 为 核 心 的 亚 太 经 济 合 作 体 系 。 而 首 相 本 人 在 不 久 后 的 讲 话 中 也 对 日 本 在 第 二 次 世 界 大 战 中 对 亚 洲 人 民 犯 下 的 罪 行 表 示 忏 悔 与 反 思 ， 同 时 强 调 新 政 府 将 坚 决 维 护 和 平 宪 法 。 不 久 东 条 英 机 等 二 战 甲 级 战 犯 的 牌 位 被 从 靖 国 神 社 中 移 出 ， 关 于 神 社 本 身 的 处 理 也 将 于 不 久 后 公 布 。 在 千 岛 群 岛 问 题 上 ， 新 政 府 一 反 常 态 地 如 之 前 自 由 民 主 党 时 期 的 日 本 政 府 一 样 要 求 苏 联 归 还 “ 侵 占 的 土 地 ” ， 认 为 在 二 战 已 经 结 束 近 四 十 年 的 今 天 ， 苏 联 继 续 控 制 这 一 地 区 不 仅 错 误 且 严 重 违 背 国 际 法 。 而 苏 联 则 置 之 不 理 ， 并 嘲 讽 日 本 共 产 党 “ 行 事 作 风 就 像 一 个 纯 粹 的 自 由 民 主 党 人 ” 。 苏 日 关 系 就 这 样 冷 淡 地 维 持 着 。||不 管 怎 样 ， 新 政 权 至 少 稳 固 了 下 来 。 当 然 ， 它 秉 持 的 到 底 是 不 是 真 正 的 共 产 主 义 就 是 另 一 回 事 了 . . . . . . ";
				}
				if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 3)
				{
					fake_text += " 革 新 的 胜 利";
					fake_text += "| 解 决 了 内 部 矛 盾 并 与 其 他 两 大 在 野 党 成 功 合 并 后 ， 社 会 党 的 后 继 者 社 会 革 新 党 最 终 实 现 了 保 革 逆 转 和 参 政 交 代 的 目 标 ， 完 成 了 新 版 《 日 本 通 向 社 会 主 义 之 路 》 纲 领 内 容 的 第 一 步 。 凭 借 着 更 具 亲 和 力 以 及 更 温 和 务 实 的 革 新 口 号 ， 社 会 革 新 党 成 功 赢 得 了 市 民 阶 层 的 广 泛 支 持 。 同 时 其 全 新 的 形 象 也 同 时 得 到 了 中 间 派 与 左 派 工 会 的 拥 护 。 在 夺 取 政 权 之 后 ， 新 政 府 迅 速 开 始 了 以 民 主 社 会 主 义 思 想 为 核 心 的 改 革 政 策 ： 成 立 相 关 部 门 对 经 济 进 行 进 一 步 的 统 筹 规 划 ， 加 强 政 府 的 宏 观 调 控 作 用 。 同 时 对 大 企 业 进 行 更 多 限 制 ， 其 中 一 些 垄 断 性 企 业 被 强 制 性 要 求 拆 分 以 削 弱 它 们 的 影 响 力 。 对 中 小 企 业 给 予 更 多 保 护 ， 维 护 市 场 竞 争 。 新 政 府 也 为 劳 工 阶 层 和 一 般 企 业 雇 员 重 新 立 法 ， 确 定 八 小 时 工 作 制 以 及 新 的 工 作 保 障 制 度 ， 尽 力 缩 小 贫 富 差 距 。 为 了 填 补 推 行 政 策 需 要 的 资 金 ， 政 府 对 部 分 行 业 施 加 了 更 高 的 税 率 ， 这 也 不 可 避 免 地 引 来 了 相 关 从 业 者 的 抗 议 。 同 时 一 批 海 外 企 业 的 出 走 也 对 经 济 造 成 了 不 小 的 打 击 。 但 在 其 他 社 会 主 义 国 家 的 援 助 下 ， 政 府 暂 时 还 能 稳 住 形 势 。 农 业 上 政 府 对 旧 有 的 农 协 （ 全 国 协 同 农 业 组 合 联 合 会 ） 垄 断 体 制 进 行 了 改 革 ， 鼓 励 农 民 自 主 发 挥 种 植 不 同 类 型 的 作 物 。 一 批 专 业 的 技 术 人 员 也 前 往 乡 下 对 农 民 进 行 全 面 技 术 指 导 。 此 外 新 政 府 正 式 承 认 了 北 海 道 阿 依 努 族 的 原 住 民 与 少 数 民 族 地 位 ， 废 除 了 过 去 对 他 们 的 种 种 限 制 。 虽 然 政 府 并 未 进 一 步 组 织 人 员 开 展 更 多 活 动 ， 但 至 少 这 一 饱 经 苦 难 的 民 族 终 于 被 正 名 了 。||之 后 ， 新 政 府 开 始 在 选 举 层 面 对 当 前 的 中 选 区 制 进 行 改 革 （ 主 要 针 对 自 由 民 主 党 ） 。 尽 管 反 对 声 巨 大 ， 但 提 案 最 终 仍 得 到 通 过 。 最 后 便 是 天 皇 制 问 题 。 虽 然 社 会 革 新 党 并 未 采 纳 激 进 派 “ 立 刻 彻 底 废 除 天 皇 制 ” 的 主 张 ， 但 也 明 确 表 示 ： “ 现 有 的 天 皇 制 存 在 许 多 弊 端 。 对 于 当 下 的 日 本 社 会 而 言 ， 这 一 体 制 已 经 带 来 了 许 多 困 扰 ， 我 们 必 须 解 决 这 些 问 题 。 ” 各 种 皇 室 庆 典 活 动 被 叫 停 ， 成 员 的 相 关 形 象 也 被 迅 速 抹 去 ， 天 皇 出 席 参 议 院 等 仪 式 更 被 完 全 终 止 。 同 时 政 府 大 幅 削 减 了 拨 给 宫 内 厅 的 经 费 。 在 一 次 内 阁 会 议 上 ， 首 相 飞 鸟 田 一 雄 表 示 ： 本 届 内 阁 任 期 期 满 之 前 将 就 彻 底 废 除 天 皇 制 进 行 全 民 公 投 。 而 关 于 自 卫 队 问 题 ， 新 政 府 将 继 续 推 动 解 散 进 程 的 同 时 也 将 保 留 “ 保 卫 本 土 所 需 的 最 低 限 度 ” 的 武 装 警 察 部 队 。||外 交 方 面 ， 新 政 府 开 始 积 极 与 社 会 党 国 际 、 不 结 盟 运 动 等 国 际 组 织 密 切 沟 通 ， 同 时 也 与 社 会 主 义 国 家 和 第 三 世 界 国 家 展 开 更 为 频 繁 的 外 交 往 来 ， 希 望 能 够 一 定 程 度 上 摆 脱 美 国 和 欧 洲 的 影 响 。 此 外 新 政 府 也 很 重 视 中 日 关 系 ， 强 调 这 是 “ 最 优 先 的 问 题 ” ， 并 对 第 二 次 世 界 大 战 中 日 本 对 亚 洲 人 民 犯 下 的 罪 行 进 行 深 刻 反 思 。 新 编 教 科 书 中 也 新 增 了 一 节 关 于 该 问 题 的 章 节 。 数 月 后 ， 靖 国 神 社 被 正 式 拆 毁 。 当 地 政 府 在 其 原 址 上 建 立 了 一 座 新 的 方 尖 碑 。 同 时 ， 新 政 府 也 在 努 力 保 证 能 够 在 不 与 美 国 彻 底 撕 破 脸 的 前 提 下 实 现 日 美 之 间 的 “ 软 脱 钩 ” 。 在 千 岛 群 岛 问 题 上 ， 新 政 府 也 不 再 如 之 前 自 由 民 主 党 时 期 的 日 本 政 府 一 样 要 求 归 还 ， 表 示 将 承 认 现 状 。 这 自 然 引 起 了 自 由 民 主 党 的 愤 怒 ， 他 们 展 开 了 大 量 的 民 族 主 义 宣 传 ， 但 大 部 分 民 众 对 此 并 不 特 别 感 冒 。 苏 联 对 新 政 府 的 表 态 表 示 欢 迎 ， 不 久 后 ， 苏 联 外 交 部 长 将 访 问 日 本 。||尽 管 新 政 府 问 题 依 旧 繁 多 且 饱 受 批 评 ： 革 命 左 派 批 判 这 是 不 彻 底 的 改 革 ， 是 “ 对 资 本 主 义 制 度 的 小 修 小 补 ” ； 右 派 则 攻 击 新 政 权 “ 要 把 国 家 送 给 布 尔 什 维 克 ” 。 但 不 管 怎 样 ， 秉 持 民 主 社 会 主 义 的 社 会 革 新 党 还 是 迈 出 了 第 一 步 。";
				}
				if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 18)
				{
					fake_text += " 第 三 次 全 共 斗 的 胜 利";
					fake_text += "| 最 终 ， 社 会 主 义 工 人 党 领 导 的 日 本 人 民 共 同 斗 争 委 员 会 赢 得 了 最 终 胜 利 ， 一 雪 曾 经 的 失 利 。 站 稳 脚 跟 之 后 ， 新 政 府 迅 速 制 定 了 全 新 的 宪 法 并 开 始 了 国 家 建 设 ： 在 国 内 政 治 方 面 ， 新 政 府 从 反 官 僚 主 义 思 想 出 发 ， 开 始 建 立 新 的 苏 维 埃 制 度 而 非 僵 化 的 一 党 领 导 制 度 。 原 先 的 参 议 院 被 直 接 解 散 ， 众 议 院 则 被 改 为 最 高 人 民 苏 维 埃 。 根 据 新 宪 法 的 规 定 ， 社 会 主 义 工 人 党 及 其 盟 友 （ 即 少 数 并 未 加 入 该 党 的 托 洛 茨 基 主 义 团 体 ） 将 自 动 保 有 2 / 3 的 席 位 。 其 余 部 分 则 通 过 定 期 选 举 的 结 果 分 配 给 其 他 左 翼 党 派 。 行 政 层 面 则 将 之 前 的 三 、 四 级 区 划 （ 即 町 丁 ） 统 一 整 编 进 二 级 （ 即 市 区 町 村 ） 区 划 ， 同 时 在 二 者 之 间 另 社 地 区 苏 维 埃 ， 形 成 了 地 方 自 治 苏 维 埃 — — 地 区 苏 维 埃 — — 一 级 苏 维 埃 的 三 级 行 政 机 构 。 每 级 机 构 的 代 表 均 由 民 众 自 己 选 出 ， 政 府 也 鼓 励 地 方 苏 维 埃 发 挥 更 多 的 自 主 性 。 之 后 ， 新 政 府 正 式 承 认 了 北 海 道 阿 依 努 族 的 原 住 民 与 少 数 民 族 地 位 ， 废 除 了 过 去 对 他 们 的 种 种 限 制 ， 鼓 励 他 们 延 续 并 发 扬 自 己 的 传 统 习 俗 ， 一 些 学 校 也 专 门 开 设 了 教 授 阿 伊 努 语 的 科 目 。 这 一 饱 经 苦 难 的 民 族 终 于 迎 来 了 曙 光 。 对 于 旧 的 天 皇 体 制 ， 新 政 府 毫 不 犹 豫 地 将 其 彻 底 废 除 ， 曾 经 被 划 归 为 皇 室 领 地 的 庭 院 楼 阁 被 全 面 改 造 ， 变 为 公 园 或 其 他 公 共 场 所 向 大 众 开 放 。 皇 室 成 员 也 被 集 中 起 来 严 加 看 管 。 最 后 则 是 一 步 步 改 组 解 散 先 前 的 自 卫 队 并 以 崭 新 的 人 民 军 取 而 代 之 ， 成 为 红 色 政 权 的 剑 与 盾 。||在 经 济 方 面 ， 新 政 府 将 曾 经 的 国 有 企 业 与 私 有 企 业 全 部 进 行 收 编 ， 并 将 其 逐 步 、 分 批 地 交 由 各 企 业 的 工 人 委 员 会 进 行 自 我 管 理 ， 让 工 人 自 己 成 为 企 业 的 管 理 者 ， 坚 决 抵 制 “ 斯 大 林 主 义 ” 式 的 官 僚 管 理 体 系 。 而 原 先 的 企 业 管 理 层 不 管 是 人 数 还 是 权 利 都 受 到 了 严 格 的 限 制 ， 在 大 部 分 情 况 下 只 是 起 到 配 合 工 人 委 员 会 的 作 用 。 随 着 工 人 群 体 的 进 一 步 成 熟 ， 这 部 分 人 员 的 权 力 也 将 被 进 一 步 剥 夺 。 同 时 国 家 对 金 融 业 也 进 行 了 改 造 并 效 仿 英 国 托 派 工 党 政 府 的 经 验 ， 引 入 对 外 贸 易 垄 断 制 以 及 实 现 银 行 业 务 的 国 有 化 。 这 一 系 列 政 策 不 可 避 免 地 引 起 了 日 本 经 济 的 剧 烈 震 荡 ， 但 在 英 国 和 法 国 托 派 政 府 的 援 助 下 ， 新 政 府 暂 时 得 以 渡 过 难 关 。||在 外 交 方 面 ， 新 政 府 迅 速 开 始 与 其 他 托 派 政 权 进 行 联 络 ， 并 正 式 加 入 第 四 国 际 以 便 推 动 世 界 革 命 的 进 程 ， 先 前 的 驻 日 美 军 也 被 全 部 遣 送 回 美 国 。 此 外 新 政 府 也 与 中 国 开 展 了 全 方 位 合 作 ， 同 时 对 第 二 次 世 界 大 战 的 问 题 也 进 行 了 深 刻 反 思 ， 并 对 教 科 书 内 容 进 行 了 重 新 编 写 。 靖 国 神 社 也 于 不 久 后 被 彻 底 拆 毁 。 政 府 在 原 址 上 建 立 了 一 座 新 的 方 尖 碑 。||尽 管 新 政 权 仍 存 在 种 种 不 稳 定 因 素 ， 世 界 其 他 国 家 的 托 派 团 体 对 社 会 主 义 工 人 党 的 评 价 也 是 褒 贬 不 一 。 但 不 管 怎 样 ， 他 们 仍 朝 着 托 洛 茨 基 主 义 的 理 想 迈 出 了 坚 实 的 一 步 。 后 面 会 发 生 什 么 ， 就 拭 目 以 待 了 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(105);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 1)
				{
					fake_text += " 通 向 社 会 主 义 之 路";
					fake_text += "| 经 过 长 期 的 艰 苦 奋 斗 ， 社 会 主 义 协 会 为 代 表 的 社 会 党 左 派 终 于 带 领 着 该 党 与 日 本 人 民 民 主 联 合 阵 线 实 现 了 1 9 6 4 年 通 过 的 《 日 本 通 向 社 会 主 义 之 路 》 党 纲 中 提 出 的 目 标 ： 不 仅 完 成 了 保 革 逆 转 与 参 政 交 代 的 任 务 ， 并 且 成 功 通 过 议 会 获 得 “ 民 主 的 多 数 派 ” ， 从 而 达 成 了 “ 和 平 革 命 ” 的 成 果 。 接 下 来 ， 稳 住 阵 脚 的 社 会 党 开 始 作 为 “ 阶 级 的 大 众 政 党 ” 开 始 了 全 方 位 的 社 会 主 义 改 革 。 经 济 上 开 始 迅 速 筹 建 国 家 计 划 委 员 会 并 积 极 学 习 中 苏 两 国 的 经 验 以 在 日 本 列 岛 开 展 五 年 计 划 ， 同 时 加 速 推 动 国 有 化 进 程 ， 对 垄 断 企 业 进 行 全 面 拆 分 与 改 组 ， 重 新 立 法 以 充 分 保 障 工 人 和 工 会 的 权 利 （ 如 罢 工 权 ， 八 小 时 工 作 制 等 ） ， 彻 底 改 组 右 翼 工 会 再 将 其 分 批 逐 步 并 入 联 合 阵 线 旗 下 的 左 翼 工 会 。 此 外 政 府 还 针 对 企 业 雇 员 问 题 制 定 新 规 ， 确 保 工 薪 族 不 再 被 繁 杂 的 仪 式 、 训 练 与 森 严 的 等 级 制 度 所 困 ， 并 鼓 励 他 们 也 积 极 参 与 到 保 障 自 身 权 利 的 斗 争 中 。 自 然 ， 这 些 政 策 遭 到 了 企 业 家 的 强 烈 反 对 ， 对 政 府 财 政 也 造 成 了 很 多 困 难 。 但 在 我 们 与 其 他 社 会 主 义 的 大 力 援 助 下 ， 新 政 府 成 功 渡 过 难 关 。||之 后 ， 新 政 府 对 当 前 的 行 政 架 构 进 行 了 一 定 程 度 的 改 造 ， 吸 纳 更 多 的 工 农 代 表 ， 同 时 开 展 专 项 行 动 对 长 期 盘 踞 的 世 家 大 族 和 豪 强 进 行 打 压 。 此 外 还 系 统 性 清 算 了 反 对 党 议 员 在 地 方 上 的 各 种 个 人 后 援 会 ， 摧 毁 了 这 些 人 在 当 地 的 利 益 链 ， 从 而 从 根 本 上 对 反 对 党 进 行 打 击 。 农 业 方 面 学 习 苏 联 经 验 ， 推 行 新 的 改 革 政 策 。 同 时 废 除 了 过 去 的 农 协 （ 全 国 协 同 农 业 组 合 联 合 会 ） 垄 断 体 制 ， 让 农 民 拥 有 了 更 大 的 自 主 权 利 。 当 然 政 府 也 会 派 出 专 业 的 技 术 人 员 对 他 们 进 行 指 导 工 作 。 下 一 项 便 是 选 举 制 度 改 革 。 社 会 党 对 当 前 的 中 选 区 制 进 行 了 一 定 程 度 的 改 革 ， 对 各 党 在 同 一 选 区 的 提 名 候 选 人 数 量 进 行 限 制 ， 同 时 对 选 区 进 行 重 新 划 分 。 这 一 改 革 配 合 之 前 对 地 方 大 族 的 打 击 ， 严 重 打 击 了 反 对 党 的 动 员 能 力 。 最 后 ， 社 会 党 强 调 了 自 卫 队 的 违 宪 性 ， 逐 步 改 组 并 最 终 完 全 废 除 了 自 卫 队 。||在 外 交 方 面 ， 新 政 府 迅 速 开 始 与 社 会 主 义 国 家 、 友 好 的 第 三 世 界 国 家 以 及 不 结 盟 运 动 等 组 织 联 络 ， 并 与 欧 美 国 家 的 社 会 主 义 政 党 进 行 密 切 沟 通 ， 希 望 实 现 进 一 步 的 国 际 联 合 ， 推 动 世 界 范 围 内 社 会 主 义 革 命 的 进 程 。 不 久 后 ， 第 一 援 助 物 资 就 将 被 送 到 南 美 地 区 的 左 翼 游 击 队 手 中 。 同 时 政 府 在 人 民 的 支 持 下 坚 决 清 除 了 美 国 在 日 本 的 一 切 残 留 影 响 力 。 正 如 一 位 政 府 成 员 所 说 ： “ 我 们 绝 不 能 再 被 美 帝 国 主 义 所 影 响 。 ” 此 外 新 政 府 也 与 中 国 开 展 全 方 位 合 作 。 虽 然 社 会 党 左 派 对 中 国 的 许 多 政 策 方 针 并 不 完 全 认 同 ， 但 依 旧 表 示 将 维 护 “ 与 中 国 同 志 间 牢 不 可 破 的 友 谊 ” 。 同 时 对 第 二 次 世 界 大 战 的 问 题 也 进 行 了 深 刻 反 思 ， 强 调 “ 我 国 过 去 对 亚 洲 人 民 造 成 了 空 前 的 灾 难 ， 我 们 对 此 深 刻 反 省 与 忏 悔 ” ， 并 对 教 科 书 内 容 进 行 了 重 新 编 写 。 靖 国 神 社 也 于 不 久 后 被 彻 底 拆 毁 。 政 府 在 原 址 上 建 立 了 一 座 博 物 馆 ， 展 出 了 一 大 批 日 本 在 二 战 中 所 犯 罪 行 的 各 类 证 据 。 博 物 馆 门 口 竖 起 了 一 座 新 的 方 尖 碑 。||对 于 天 皇 问 题 ， 新 政 府 毫 不 犹 豫 地 宣 布 将 “ 彻 底 废 除 天 皇 制 ” ， 曾 经 被 划 归 为 皇 室 领 地 的 庭 院 楼 阁 被 全 面 改 造 ， 变 为 公 园 或 其 他 公 共 场 所 向 大 众 开 放 。 皇 室 成 员 也 被 集 中 起 来 严 加 看 管 。 此 外 新 政 府 正 式 承 认 了 北 海 道 阿 依 努 族 的 原 住 民 与 少 数 民 族 地 位 ， 废 除 了 过 去 对 他 们 的 种 种 限 制 ， 鼓 励 他 们 延 续 并 发 扬 自 己 的 传 统 习 俗 。 政 府 还 组 织 人 员 开 展 阿 伊 努 文 化 的 相 关 宣 传 活 动 ， 一 些 学 校 也 专 门 开 设 了 教 授 阿 伊 努 语 的 科 目 。 这 一 饱 经 苦 难 的 民 族 ， 终 于 迎 来 了 曙 光 。||社 会 党 的 种 种 “ 马 克 思 主 义 ” 政 策 不 出 所 料 地 遭 到 了 自 由 民 主 党 以 及 商 界 和 官 僚 集 团 的 强 烈 反 对 。 在 国 会 的 议 案 表 决 中 ， 自 由 民 主 党 议 员 不 惜 通 过 “ 牛 步 战 术 ” （ 即 表 决 过 程 中 被 点 名 上 来 投 票 的 议 员 都 故 意 慢 慢 走 ， 强 行 拖 延 时 间 直 至 晚 上 1 2 点 投 票 结 束 ， 甚 至 拖 到 这 一 届 国 会 结 束 ， 该 议 案 变 成 废 案 为 止 ） 来 抵 抗 。 其 中 一 个 议 案 的 表 决 甚 至 创 下 了 1 3 个 小 时 8 分 钟 的 记 录 。 但 这 样 的 抵 抗 终 归 是 无 济 于 事 的 。 此 后 在 1 9 8 6 年 的 选 举 中 ， 自 由 民 主 党 遭 到 更 为 彻 底 的 失 败 ， 只 拿 到 1 5 1 个 席 位 。 而 联 合 阵 线 凭 借 此 前 利 好 工 农 的 政 策 得 到 了 他 们 的 广 泛 支 持 ， 再 加 上 社 会 活 动 家 们 广 泛 的 动 员 能 力 ， 最 终 一 举 夺 得 3 0 0 个 席 位 。 他 们 的 地 位 更 加 稳 固 了 。 而 日 本 人 民 也 正 大 步 走 在 通 向 社 会 主 义 的 道 路 上 ！ ";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(105);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 17)
				{
					fake_text += " 赤 旗 飘 扬";
					fake_text += "| 终 于 ， 在 工 农 群 体 的 支 持 和 我 们 的 大 力 援 助 下 ， 日 本 革 命 共 产 党 领 导 的 日 本 人 民 革 命 阵 线 成 功 在 美 国 和 北 约 其 他 成 员 国 下 场 干 预 前 推 翻 了 自 民 党 反 动 政 权 ， 建 立 了 崭 新 的 日 本 社 会 主 义 人 民 共 和 国 ， 宣 布 将 沿 着 马 克 思 、 恩 格 斯 、 列 宁 、 斯 大 林 与 毛 泽 东 同 志 的 路 线 继 续 前 进 。 新 政 权 的 第 一 项 任 务 就 是 开 始 战 后 重 建 并 设 立 人 民 法 庭 对 战 犯 开 展 集 中 审 判 。 首 先 便 是 自 卫 队 和 警 方 成 员 ， 法 官 针 对 其 所 犯 罪 行 的 大 小 以 及 职 务 高 低 被 分 别 处 以 不 同 程 度 的 刑 罚 。 紧 接 着 ， 对 二 战 战 犯 的 再 次 审 判 也 正 式 开 始 。 由 于 美 国 的 带 头 包 庇 ， 一 大 批 在 第 二 次 世 界 大 战 中 犯 下 累 累 血 债 的 人 得 以 逃 脱 审 判 或 者 只 被 判 处 较 轻 的 刑 罚 ， 相 当 一 批 人 还 积 极 活 跃 于 政 坛 上 。 现 在 是 时 候 彻 底 清 算 了 ： 革 命 政 府 展 开 了 全 国 范 围 内 对 二 战 战 犯 的 统 一 抓 捕 行 动 。 除 少 部 分 早 已 逃 往 国 外 ， 其 余 人 都 被 重 新 逮 捕 。 人 民 法 庭 向 国 内 外 媒 体 均 发 出 旁 听 邀 请 ， 同 时 组 织 人 员 为 这 次 “ 东 京 再 审 判 ” 进 行 全 程 公 开 记 录 。在 法 庭 上 ， 政 府 人 员 展 示 了 充 足 的 证 据 ， 清 楚 地 表 明 了 这 些 战 犯 所 犯 下 的 恶 行 。 最 终 绝 大 部 分 人 都 被 判 处 死 刑 ， 剩 余 人 员 也 被 判 处 终 身 监 禁 。 靖 国 神 社 也 于 不 久 后 被 彻 底 捣 毁 ， 在 其 原 址 上 建 立 了 一 座 新 的 纪 念 碑 ： 一 位 工 人 和 一 位 农 民 分 别 手 持 锤 子 和 镰 刀 摧 毁 了 象 征 军 国 主 义 的 旧 帝 国 大 本 营 中 心 建 筑 ， 下 方 配 有 用 中 日 英 俄 四 国 语 言 写 成 的 一 段 文 字 ： 决 不 能 让 法 西 斯 卷 土 重 来 ！||接 下 来 便 是 要 处 理 处 理 天 皇 制 了 。 作 为 历 史 最 久 的 封 建 残 余 ， 新 政 府 毫 不 犹 豫 地 将 其 连 根 铲 除 ： 曾 经 被 划 归 为 皇 室 领 地 的 庭 院 楼 阁 被 全 面 改 造 ， 变 为 公 园 或 其 他 公 共 场 所 向 大 众 开 放 。 天 皇 家 族 成 员 与 支 系 成 员 也 被 集 中 起 来 。 人 民 法 庭 对 这 些 人 中 参 与 二 战 （ 不 管 直 接 还 是 间 接 ） 之 人 像 之 前 一 样 举 行 公 审 。 天 皇 裕 仁 本 人 最 终 被 正 式 处 以 死 刑 ， 其 他 人 也 根 据 其 罪 行 处 以 不 同 判 决 。 至 于 那 些 因 为 地 位 较 低 因 此 未 有 多 少 参 与 的 成 员 ， 则 对 他 们 展 开 改 造 工 作 ， 争 取 促 成 这 些 人 的 转 变 。 此 外 新 政 府 正 式 承 认 了 北 海 道 阿 依 努 族 的 原 住 民 与 少 数 民 族 地 位 ， 废 除 了 过 去 对 他 们 的 种 种 限 制 ， 鼓 励 他 们 延 续 并 发 扬 自 己 的 传 统 习 俗 。 政 府 还 组 织 人 员 开 展 阿 伊 努 文 化 的 相 关 宣 传 活 动 ， 而 且 强 制 性 推 动 一 定 比 例 的 学 校 必 须 专 门 开 设 教 授 阿 伊 努 语 的 相 关 科 目 。 此 外 当 地 政 府 与 阿 伊 努 族 的 一 批 学 者 联 合 起 来 系 统 整 理 了 阿 伊 努 族 的 历 史 ， 该 丛 书 不 久 后 就 将 发 售 。 这 一 饱 经 苦 难 的 民 族 ， 终 于 迎 来 了 曙 光 。||在 对 历 史 问 题 完 成 清 算 之 后 ， 踌 躇 满 志 的 新 政 府 迅 速 开 始 行 动 ： 成 立 国 家 计 划 委 员 会 以 开 始 五 年 计 划 ， 旧 有 大 企 业 被 拆 分 重 组 并 完 全 国 有 化 ， 对 工 人 权 利 进 行 全 面 立 法 保 障 。 行 政 层 面 推 动 成 立 各 级 革 命 委 员 会 ， 逐 步 代 替 旧 的 政 府 架 构 ， 并 鼓 励 工 农 积 极 参 与 到 委 员 会 会 议 讨 论 和 投 票 中 。 同 时 借 鉴 我 们 的 “ 两 参 一 改 三 结 合 ” 相 关 经 验 ， 充 分 发 扬 无 产 阶 级 民 主 。 地 方 层 面 上 ， 对 那 些 长 期 盘 踞 一 方 的 世 家 大 族 和 豪 强 进 行 彻 底 的 清 理 ， 绝 大 部 分 财 产 均 被 充 公 ， 家 族 人 员 在 依 照 法 律 得 到 属 于 自 己 的 一 块 土 地 之 后 也 要 参 与 到 劳 作 之 中 ， 同 时 对 一 部 分 偏 远 地 区 的 家 族 进 行 整 体 迁 移 ， 让 他 们 无 法 再 对 当 地 施 加 任 何 影 响 的 同 时 也 便 于 政 府 更 好 地 进 行 管 理 。 考 虑 到 农 村 机 械 化 的 普 及 ， 新 政 府 在 废 除 了 旧 有 的 农 协 （ 全 国 协 同 农 业 组 合 联 合 会 ） 的 同 时 采 取 了 合 作 社 和 公 社 并 行 的 策 略 ， 并 派 出 大 量 技 术 人 员 对 农 民 进 行 专 业 指 导 。 为 了 保 证 农 民 的 收 入 ， 政 府 也 积 极 开 展 外 交 谈 判 以 保 证 销 售 渠 道 。 文 化 上 对 旧 有 的 “ 资 产 阶 级 文 艺 ” 展 开 彻 底 清 算 ， 严 厉 打 击 色 情 业 并 对 相 关 从 业 者 开 展 改 造 工 作 ， 让 她 们 能 够 以 社 会 主 义 公 民 的 新 身 份 参 与 到 建 设 中 。 同 时 中 日 两 国 的 动 画 制 作 企 业 还 展 开 了 密 切 合 作 ， 共 同 创 作 了 一 系 列 以 无 产 阶 级 价 值 观 为 导 向 的 新 作 品 ， 当 然 其 创 作 形 式 也 更 加 丰 富 多 彩 。||此 外 ， 我 们 协 助 新 政 府 组 织 人 手 开 展 对 日 本 近 代 以 来 左 翼 革 命 历 史 的 全 面 普 及 ： 片 山 潜 、 德 田 球 一 、 市 川 正 一 、 渡 边 政 之 辅 、 山 本 宣 治 等 革 命 人 物 的 事 迹 被 重 新 整 理 并 被 广 泛 宣 传 。 宫 本 显 治 、 不 破 哲 三 这 些 修 正 主 义 分 子 和 那 些 二 战 前 后 急 速 转 向 翼 赞 法 西 斯 政 府 的 “ 左 派 ” 也 得 到 了 彻 底 的 批 判 。 而 对 片 山 哲 、 浅 沼 稻 次 郎 等 人 ， 则 在 批 判 其 问 题 的 同 时 也 肯 定 了 他 们 的 一 些 正 面 事 迹 。 不 久 ， 政 府 便 在 东 京 主 持 了 革 命 义 士 纪 念 广 场 的 开 工 仪 式 ， 全 国 各 地 也 开 始 修 建 一 批 新 的 纪 念 馆 并 树 立 雕 像 。 建 成 之 后 ， 政 府 将 定 期 组 织 中 小 学 生 来 此 学 习 历 史 并 向 革 命 烈 士 献 花 。 在 外 交 上 ， 新 政 府 积 极 与 中 国 展 开 合 作 ， 表 示 “ 中 日 两 国 人 民 之 间 的 友 谊 牢 不 可 破 ” 。 同 时 与 其 他 社 会 主 义 国 家 也 开 展 了 外 交 往 来 。 在 我 们 的 带 头 作 用 下 ， 新 政 府 不 到 一 个 月 的 时 间 内 便 得 到 了 数 十 个 国 家 的 承 认 ， 第 一 批 双 边 贸 易 谈 判 也 将 于 不 久 后 正 式 开 始 。 此 外 ， 新 政 府 也 积 极 推 动 世 界 范 围 内 的 革 命 进 程 ， 大 力 支 援 世 界 其 他 地 区 的 左 派 武 装 ， 加 紧 推 动 社 会 主 义 革 命 。 不 久 后 ， 第 一 援 助 物 资 就 将 被 送 到 南 美 地 区 的 左 翼 游 击 队 手 中 。||至 此 ， 鲜 红 而 灿 烂 的 太 阳 ， 终 于 照 耀 在 这 片 土 地 之 上 ！ 中 日 两 国 人 民 今 后 将 携 手 共 进 ， 为 了 共 产 主 义 而 奋 斗 ！ ";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(105);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[44].SubGosstroy == 7)
				{
					fake_text += " 永 无 落 日";
					fake_text += "| 在 美 军 平 息 日 本 人 民 的 革 命 后 不 久 ， 针 对 革 命 者 的 审 判 便 展 开 了 。 说 是 审 判 ， 其 实 不 过 是 走 个 过 场 罢 了 。 被 告 们 没 有 任 何 机 会 进 行 申 辩 ， 他 们 的 “ 辩 护 律 师 ” 也 是 由 美 军 中 的 一 批 文 职 人 员 临 时 充 当 的 。 甚 至 在 绝 大 部 分 审 判 中 这 些 “ 辩 护 律 师 ” 都 不 会 出 现 。 草 草 走 完 流 程 后 ， 革 命 者 们 便 即 刻 被 法 官 判 处 死 刑 、 终 身 劳 动 改 造 或 其 他 重 刑 。 相 当 一 部 分 人 连 “ 享 受 ” 这 一 “ 过 场 ” 的 机 会 都 没 有 — — 他 们 被 直 接 拉 往 美 军 基 地 实 施 枪 决 。 按 照 一 名 不 愿 透 露 姓 名 的 美 军 军 官 所 说 ， 这 是 “ 对 待 暴 徒 的 无 奈 之 举 ” 。 此 外 ， 美 军 和 自 卫 队 开 始 重 点 针 对 革 命 军 此 前 的 活 跃 区 域 进 行 重 点 清 扫 。 任 何 人 都 可 能 随 时 被 拉 走 接 受 审 问 。||初 步 秩 序 得 到 建 立 后 ， 日 本 共 和 党 开 始 领 导 这 个 国 家 。 为 了 杜 绝 革 命 再 次 爆 发 ， 新 政 府 围 绕 反 共 这 一 核 心 展 开 全 面 行 动 ： 新 的 教 科 书 中 近 1 / 3 的 内 容 都 在 竭 力 宣 传 “ 共 产 主 义 的 残 忍 ” ， 强 调 “ 任 何 一 个 有 自 主 思 考 能 力 的 人 都 不 应 该 赞 成 这 样 的 思 想 ” 。 对 工 会 组 织 则 进 行 全 面 拆 分 和 重 组 ， 同 时 通 过 建 立 劳 资 合 作 的 关 系 来 协 调 工 人 和 资 本 家 的 利 益 。 一 些 革 命 前 就 积 极 倡 导 “ 劳 资 调 和 论 ” 的 工 会 活 动 家 此 时 也 得 到 了 政 府 的 重 用 。 任 何 未 经 工 人 委 员 会 的 游 行 或 集 会 均 会 被 视 为 非 法 ， 将 不 受 法 律 保 护 且 会 受 到 严 惩 。 而 工 人 委 员 会 的 成 员 也 不 过 是 一 群 听 从 企 业 指 示 的 “ 点 头 机 器 ” 罢 了 。 政 治 上 为 了 彰 显 “ 民 主 性 ” ， 新 政 府 扶 植 了 国 家 人 民 党 和 自 由 党 两 个 御 用 反 对 党 ， 事 实 上 它 们 的 大 部 分 成 员 都 是 日 本 共 和 党 成 员 。 同 时 新 政 府 开 始 间 接 弘 扬 天 皇 精 神 ， 在 积 极 举 办 各 种 相 关 仪 式 的 同 时 加 强 了 天 皇 相 关 事 迹 的 宣 传 。 此 外 新 政 府 成 员 还 集 体 参 拜 了 靖 国 神 社 ， 向 这 些 “ 大 人 物 ” 致 以 敬 意 。 当 然 ， 为 了 彰 显 “ 自 由 日 本 ” 的 精 神 ， 新 政 府 也 打 击 了 社 会 上 叫 嚣 要 复 兴 旧 日 本 体 制 的 极 右 翼 团 体 。 又 针 对 北 海 道 的 阿 伊 努 族 ， 政 府 不 仅 继 续 否 认 此 民 族 的 存 在 ， 并 且 对 他 们 的 文 化 古 迹 进 行 了 彻 底 的 “ 清 理 ” ， 禁 止 他 们 以 任 何 方 式 继 续 传 播 这 一 “ 落 后 的 封 建 风 俗 ” ， 一 些 地 区 的 孩 子 还 被 强 制 送 入 政 府 开 办 的 特 别 学 校 ， 接 受 “ 官 方 教 育 ” ， 致 使 这 一 古 老 的 民 族 逐 步 走 向 消 亡 。||亚 洲 方 面 ， 新 政 府 进 行 了 战 后 对 韩 国 的 首 次 访 问 ， 并 且 与 全 斗 焕 建 立 了 良 好 的 关 系 。 1 9 8 5 年 8 月 1 5 日 ， 政 府 成 员 集 体 参 拜 了 靖 国 神 社 （ 尤 其 是 8 月 1 5 日 这 个 日 子 ） ， 在 亚 洲 国 家 引 发 了 强 烈 抗 议 和 批 判 。 同 时 为 了 拥 有 足 够 强 大 的 武 力 应 对 今 后 可 能 的 “ 暴 动 ” ， 日 本 积 极 参 与 到 美 国 制 定 的 全 球 军 备 体 系 中 ， 在 美 国 的 默 许 下 ， 新 政 府 第 一 年 的 财 政 预 算 就 达 到 了 日 本 国 民 生 产 总 值 的 3 % ， 这 笔 资 金 将 用 于 自 卫 队 的 全 面 扩 张 和 武 器 的 更 新 换 代 。||在 外 交 上 ， 新 政 府 完 全 跟 随 美 国 与 北 约 的 脚 步 。 新 首 相 上 任 仅 一 周 便 前 往 美 国 进 行 访 问 。 期 间 他 多 次 向 媒 体 表 示 ： “ 日 美 军 事 同 盟 是 我 们 对 外 政 策 的 核 心 ， 日 本 将 坚 定 地 与 美 国 和 整 个 自 由 世 界 站 在 一 起 ， 以 抵 御 苏 联 和 共 产 主 义 思 想 的 入 侵 。 ” 并 提 出 如 有 必 要 将 “ 封 锁 三 个 海 峡 （ 千 岛 群 岛 、 津 轻 海 峡 和 对 马 海 峡 ） ” 以 应 对 苏 联 威 胁 。 日 本 政 府 还 在 多 个 国 际 场 合 要 求 苏 联 即 刻 归 还 “ 非 法 侵 占 ” 的 千 岛 群 岛 。 种 种 行 为 使 得 苏 日 关 系 降 至 冰 点 ， 苏 联 与 其 他 社 会 主 义 国 家 的 代 表 纷 纷 召 回 本 国 大 使 以 示 抗 议 。 不 久 一 个 更 加 震 撼 的 消 息 传 来 ： 日 本 政 府 正 式 递 交 了 加 入 北 约 的 申 请 ！ 苏 联 迅 速 动 员 了 其 在 远 东 的 军 事 力 量 ， 并 警 告 日 本 的 这 一 行 为 “ 将 成 为 压 倒 和 平 的 最 后 一 根 稻 草 ” 。 虽 然 美 国 出 于 对 全 面 热 战 的 冲 突 搁 置 了 这 一 申 请 ， 但 全 球 局 势 仍 骤 然 紧 张 起 来 . . . . . .||大 部 分 国 家 都 对 日 本 的 现 状 表 示 强 烈 谴 责 ， 批 评 它 是 “ 一 个 不 折 不 扣 的 法 西 斯 主 义 政 权 ” 。 但 有 美 国 和 北 约 的 支 持 ， 现 在 的 日 本 政 府 又 有 什 么 可 怕 的 呢 ？||日 本 的 未 来 ， 一 片 灰 暗 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(106);
					}
				}
			}
			else if (number_of_e == 11)
			{
				name.text = " 南 方 的 老 朋 友 —— 印 度";
				fake_text = "";
				if (GlobalScript.inst.gameState.allcountries[19].puppetOf == 1)
				{
					fake_text += "白 象 之 殇|中 国 的 军 事 行 动 彻 底 击 垮 了 印 度 。 由 于 本 就 是 被 英 国 强 行 捏 合 而 来 ， 印 度 本 就 不 强 的 国 家 凝 聚 力 在 战 后 更 是 崩 解 得 灰 飞 烟 灭 。 在 中 国 的 主 导 下 ， 印 度 被 分 为 了 三 块 ， 这 甚 至 不 包 括 被 中 国 、 巴 基 斯 坦 和 孟 加 拉 国 占 领 的 地 区 。 印 度 次 大 陆 可 能 将 保 持 这 种 多 个 中 等 强 国 相 互 制 衡 的 态 势 ， 直 到 永 远 … …";
				}
				else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding >= 0 && GlobalScript.inst.gameState.ingamewars[7].is_going)
				{
					fake_text += GlobalScript.inst.new_texts[318];
				}
				else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 0 && !GlobalScript.inst.gameState.ingamewars[7].is_going && GlobalScript.inst.gameState.ingamewars[7].infl1 >= 1000)
				{
					fake_text += GlobalScript.inst.new_texts[319];
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(80);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 0 && !GlobalScript.inst.gameState.ingamewars[7].is_going && GlobalScript.inst.gameState.ingamewars[7].infl2 >= 1000)
				{
					fake_text += GlobalScript.inst.new_texts[320];
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(81);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 1 && !GlobalScript.inst.gameState.ingamewars[7].is_going && GlobalScript.inst.gameState.ingamewars[7].infl1 >= 1000)
				{
					fake_text += GlobalScript.inst.new_texts[321];
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(82);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 1 && !GlobalScript.inst.gameState.ingamewars[7].is_going && GlobalScript.inst.gameState.ingamewars[7].infl2 >= 1000)
				{
					fake_text += GlobalScript.inst.new_texts[322];
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(83);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 2)
				{
					fake_text += GlobalScript.inst.new_texts[323];
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(84);
					}
				}
				else
				{
					fake_text += GlobalScript.inst.new_texts[317];
				}
			}
			else if (number_of_e == 12)
			{
				name.text = " 胞 波 情 深 —— 缅 甸";
				fake_text = "";
				if (GlobalScript.inst.gameState.ingamewars[83].is_going)
				{
					fake_text += "第 二 巴 尔 干|缅 甸 社 会 主 义 纲 领 党 政 权 将 以 该 国 最 后 一 个 统 一 政 府 的 名 号 名 留 于 世 — — 内 战 彻 底 撕 裂 了 该 国 政 治 版 图 ， 创 造 了 无 数 贫 民 窟 、 难 民 营 、 流 窜 犯 罪 集 团 与 毒 品 卡 特 尔 组 织 ； 乃 至 数 十 个 犬 牙 交 错 的 准 民 族 国 家 政 治 实 体 ： 他 们 很 快 便 脱 离 了 传 统 的 政 治 关 系 并 转 向 “ 群 雄 逐 鹿 ” … … 新 孟 邦 革 命 军 和 往 日 的 亲 密 战 友 克 伦 人 为 妙 瓦 底 口 岸 大 打 出 手 ； 掸 邦 军 分 裂 为 南 北 两 派 ， 为 争 夺 老 挝 毒 品 贸 易 小 道 而 火 并 。 而 佤 邦 的 军 队 也 正 开 向 果 敢 … … 这 便 是 战 国 时 代 的 原 汁 原 味 … …";
				}
				else if (GlobalScript.inst.gameState.ingamewars[82].is_going)
				{
					fake_text += "第 二 巴 尔 干| 内 战 彻 底 撕 裂 了 缅 甸 政 治 版 图 ， 创 造 了 无 数 贫 民 窟 、 难 民 营 、 流 窜 犯 罪 集 团 与 毒 品 卡 特 尔 组 织 ； 乃 至 数 十 个 犬 牙 交 错 的 准 民 族 国 家 政 治 实 体 ： 他 们 很 快 便 脱 离 了 传 统 的 政 治 关 系 并 转 向 “ 群 雄 逐 鹿 ” … … 新 孟 邦 革 命 军 和 往 日 的 亲 密 战 友 克 伦 人 为 妙 瓦 底 口 岸 大 打 出 手 ； 掸 邦 军 分 裂 为 南 北 两 派 ， 为 争 夺 老 挝 毒 品 贸 易 小 道 而 火 并 。 而 佤 邦 的 军 队 也 正 开 向 果 敢 … … 这 便 是 战 国 时 代 的 原 汁 原 味 … …";
				}
				else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 17)
				{
					fake_text += "红 娜 迦 也 波 的 胜 利| 缅 甸 共 产 党 力 克 该 国 政 治 马 赛 克 ， 并 在 中 国 盟 友 的 帮 助 下 将 沙 文 主 义 ， 新 殖 民 主 义 ， 资 本 主 义 ， 修 正 主 义 与 各 种 狭 隘 民 族 主 义 扫 入 了 历 史 垃 圾 堆 。 实 现 了 德 钦 巴 登 顶 长 期 致 力 的 政 治 理 想 。 可 掌 权 不 过 是 万 里 长 征 的 开 端 ： 斗 争 期 间 沾 染 的 毒 贩 走 私 与 军 阀 习 气 仍 将 持 续 困 扰 缅 甸 共 产 党 ， 意 味 着 整 风 清 党 仍 将 是 该 国 长 期 的 主 旋 律 。 目 前 ， 该 国 正 积 极 落 实 民 族 自 决 政 策 ， 并 以 《 苏 联 成 立 条 约 》 与 世 俗 主 义 原 则 划 定 联 邦 版 图 ， 规 定 政 治 范 围 。 该 国 的 社 会 主 义 也 将 在 同 中 国 一 体 化 的 大 背 景 下 稳 定 发 展 ： 全 世 界 的 也 波 朋 友 们 和 全 世 界 的 胞 波 朋 友 们 就 此 在 光 明 的 道 路 上 携 手 共 进 实 现 和 平 ， 并 团 结 走 向 共 产 主 义 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 15)
				{
					fake_text += "普 鲁 士 主 义 和 社 会 主 义 |缅 甸 社 会 主 义 纲 领 党 内 部 的 温 和 派 与 “ 相 对 ” 拥 护 社 纲 党 纲 领 的 军 官 形 成 了 稳 固 的 统 一 战 线 ， 开 启 了 “ 缅 甸 社 会 主 义 ” 的 新 纪 元 ： 该 国 指 导 思 想 从 佛 教 社 会 主 义 转 向 了 对 马 克 思 的 经 典 诠 释 ， 国 内 多 少 形 成 了 类 似 国 家 计 划 委 员 会 的 框 架 ， 并 在 此 基 础 上 推 进 基 础 设 施 建 设 、 发 展 轻 工 业 生 产 与 押 注 石 油 出 口 获 利 。 “ 拥 国 之 军 ” 的 时 代 逐 渐 过 去 ， 它 们 将 逐 渐 换 上 “ 党 管 干 部 ” 与 安 全 机 构 代 言 人 的 新 面 貌 登 场 。 显 然 ， 缅 甸 终 究 还 是 靠 挪 用 苏 东 老 朋 友 的 设 计 与 建 构 “ 伪 联 邦 ” 实 现 了 大 致 稳 定 ： 除 却 自 由 派 与 部 分 少 数 民 族 武 装 时 不 时 抗 议 与 袭 击 外 ， 一 切 正 按 照 计 划 进 行 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 7)
				{
					fake_text += "似 曾 相 识 之 感|缅 甸 社 会 主 义 纲 领 党 内 部 的 改 革 派 与 特 务 将 军 形 成 了 稳 固 的 统 一 战 线 ， 开 启 了 “ 缅 甸 社 会 主 义 ” 的 新 纪 元 ： 该 国 指 导 思 想 从 佛 教 社 会 主 义 转 向 了 东 亚 模 式 与 威 权 资 本 主 义 ， 并 打 出 “ 社 会 主 义 即 稻 米 加 蛋 ” 的 口 号 奉 行 实 用 主 义 政 策 ： 缅 甸 各 地 设 立 了 经 济 特 区 与 自 贸 区 ， 从 以 往 的 国 际 孤 儿 摇 身 变 为 了 “ 新 加 坡 第 二 ” 。 中 国 资 本 的 注 入 与 同 中 资 企 业 达 成 的 长 效 合 同 足 以 稳 定 该 国 经 济 ： 从 基 础 设 施 到 轻 工 业 品 ， 从 交 通 工 具 到 重 化 机 械 ， 缅 甸 就 此 成 为 了 充 斥 “ 中 国 制 造 ” 的 国 家 。 佛 教 社 会 主 义 的 遗 存 则 转 变 为 国 家 政 教 协 定 ， 僧 侣 对 政 权 的 影 响 力 就 此 远 胜 往 昔 。 “ 拥 国 之 军 ” 的 时 代 逐 渐 过 去 ， 它 们 将 逐 渐 换 上 “ 技 术 官 僚 ” 与 安 全 机 构 代 言 人 的 新 面 貌 登 场 。 显 然 ， 缅 甸 终 究 还 是 靠 挪 用 伪 民 主 主 义 框 架 的 设 计 与 建 构 “ 伪 联 邦 ” 实 现 了 大 致 稳 定 ： 除 却 自 由 派 与 部 分 少 数 民 族 武 装 时 不 时 抗 议 与 袭 击 外 ， 一 切 正 按 照 计 划 进 行 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 18)
				{
					fake_text += "罗 喉 曜 日 的 孩 子|缅 甸 共 产 党 力 克 该 国 政 治 马 赛 克 ， 并 在 中 国 盟 友 的 帮 助 下 将 沙 文 主 义 ， 新 殖 民 主 义 ， 资 本 主 义 ， 修 正 主 义 ， 唯 意 志 论 与 各 种 狭 隘 民 族 主 义 扫 入 了 历 史 垃 圾 堆 。 实 现 了 一 代 共 产 党 人 长 期 致 力 的 政 治 理 想 。 可 掌 权 不 过 是 万 里 长 征 的 开 端 ： 虽 说 改 组 后 的 缅 共 基 本 形 成 了 建 立 去 民 族 化 的 “ 伊 洛 瓦 迪 苏 维 埃 ” 共 识 ， 并 决 定 将 自 身 同 “ 白 旗 党 ” 时 代 的 黑 历 史 一 刀 两 断 （ 作 为 “ 缅 甸 文 革 的 受 害 者 ” 的 敏 拉 也 宽 由 此 被 塑 造 为 另 类 英 雄 ） 。 但 在 如 何 改 造 旧 社 会 与 发 展 社 会 主 义 的 问 题 上 ， 他 们 产 生 了 分 歧 。 曾 充 当 反 白 劳 德 主 义 先 锋 的 德 钦 梭 是 堕 落 工 人 国 家 理 论 的 信 奉 者 ， 主 张 在 确 保 列 宁 主 义 党 政 建 设 的 同 时 筹 备 缅 甸 版 本 的 新 经 济 政 策 ， 为 向 社 会 主 义 过 渡 做 准 备 ； 而 丹 梭 良 带 领 下 的 新 一 派 干 部 则 基 于 反 对 缅 甸 社 会 主 义 纲 领 党 的 现 实 转 向 了 “ 大 众 民 主 ” — — 事 实 上 类 似 米 尔 万 · 吉 拉 斯 向 社 会 民 主 主 义 与 自 由 主 义 开 门 以 抵 御 “ 新 阶 级 ” 的 观 点 ； 敏 拉 也 宽 也 以 “ 革 命 牛 虻 ” 的 身 份 亲 自 入 局 ， 坚 决 抵 制 党 内 的 右 倾 取 向 。 不 过 ， 考 虑 到 缅 甸 共 产 党 允 许 派 系 自 由 的 规 定 仍 照 常 发 挥 作 用 ， “ 斗 而 不 破 ” 的 局 面 仍 将 长 期 存 在 。 与 此 同 时 ， 基 于 自 身 作 为 多 民 族 十 字 路 口 的 性 质 ， 缅 甸 很 自 然 的 提 出 了 将 缅 北 少 数 民 族 和 傣 族 均 整 合 在 苏 维 埃 共 和 国 框 架 下 ， 并 加 入 缅 甸 境 内 的 计 划 ： 可 这 个 提 议 看 来 并 不 合 乎 老 挝 代 表 的 口 味 … …";
				}
				else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 11)
				{
					fake_text += "赞 米 亚 南 斯 拉 夫|结 束 了 持 续 数 十 年 的 漫 长 战 争 后 ， 缅 甸 决 定 回 到 《 彬 龙 协 议 》 的 基 础 上 确 立 建 国 原 则 ， 并 在 考 量 国 内 各 族 自 决 权 更 进 一 步 — — 《 勃 生 协 定 》 将 缅 甸 事 实 上 改 为 了 主 权 国 家 联 合 体 ： 邦 联 各 成 员 均 享 有 独 立 立 法 权 、 财 政 与 税 收 大 权 、 单 独 享 有 本 土 各 项 资 产 、 并 可 自 由 退 出 联 邦 ； 缅 甸 本 身 仅 作 为 一 个 共 用 货 币 、 市 场 与 关 税 ， 并 采 取 软 义 务 关 系 维 系 的 政 治 联 盟 。 此 外 ， 新 宪 法 还 采 用 了 类 似 美 国 框 架 的 主 席 普 选 制 （ 主 席 仅 作 为 国 家 象 征 存 在 ） ： 不 久 后 ， 昂 山 之 女 昂 山 素 季 便 在 选 举 内 高 举 和 解 与 民 主 旗 帜 大 获 全 胜 ， 并 进 一 步 巩 固 了 缅 甸 的 类 南 斯 拉 夫 的 联 邦 制 。 接 下 来 举 行 的 各 共 和 国 选 举 则 彻 底 确 立 了 分 权 的 基 本 原 则 ： 除 克 伦 民 族 联 盟 领 导 下 的 地 区 选 择 自 由 脱 离 联 邦 ， 并 建 立 起 独 立 的 高 都 丽 国 外 ； 绝 大 多 数 的 邦 联 成 员 决 定 继 续 维 系 改 框 架 ， 并 在 主 权 说 辞 的 掩 护 下 发 展 本 地 特 色 的 社 会 与 经 济 制 度 ， 而 缅 甸 群 山 层 叠 的 地 形 只 会 让 根 植 于 山 民 传 统 ， 吸 取 游 击 战 期 间 自 给 自 足 经 验 ， 且 自 下 往 上 构 建 的 广 泛 社 区 自 治 体 持 续 发 展 壮 大 。 让 我 们 看 看 走 分 权 道 路 的 第 二 缅 甸 未 来 将 如 何 ： 究 竟 是 迎 来 民 族 主 义 的 异 化 ， 还 是 真 正 的 解 放 ？";
				}
				else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 6)
				{
					fake_text += "给 我 自 由 ， 或 给 我 死 亡|结 束 了 持 续 数 十 年 的 漫 长 战 争 后 ， 全 联 邦 联 盟 军 决 定 根 据 自 身 的 政 治 理 想 重 塑 建 国 原 则 — — 该 组 织 将 缅 甸 事 实 上 改 为 了 某 种 地 区 概 念 的 合 作 论 坛 ： 邦 联 各 成 员 均 享 有 独 立 立 法 权 、 财 政 与 税 收 大 权 、 单 独 享 有 本 土 各 项 资 产 、 并 可 自 由 退 出 联 邦 ； 缅 甸 本 身 仅 作 为 一 个 拥 有 万 国 之 议 会 ， 外 交 部 长 联 席 会 议 等 协 商 框 架 ， 并 采 取 软 义 务 关 系 维 系 的 政 治 邦 联 。 此 外 ， 新 宪 法 还 采 用 了 类 似 南 斯 拉 夫 框 架 的 主 席 轮 值 制 度 （ 主 席 仅 作 为 国 家 象 征 存 在 ） ： 不 久 后 ， 该 国 知 名 的 革 命 家 与 百 万 富 翁 张 奇 夫 便 被 推 举 为 领 导 人 ， 并 开 始 同 美 国 总 统 探 讨 宏 大 的 禁 毒 计 划 。 随 着 该 国 政 治 空 气 越 加 自 由 并 事 实 上 确 立 了 亲 西 方 立 场 ， 缅 甸 很 快 边 迎 来 了 自 己 的 转 型 正 义 时 期 ： 出 于 削 弱 “ 大 缅 族 主 义 ” 的 需 要 重 定 各 大 共 和 国 边 界 ； 彻 底 肃 清 缅 甸 社 会 主 义 的 一 切 遗 迹 ， 并 欢 迎 分 权 的 未 来 。 而 这 只 会 导 致 新 的 问 题 ： 各 地 政 权 为 吸 引 投 资 而 不 约 而 同 地 转 向 了 恶 性 竞 争 与 新 自 由 主 义 ， 创 造 了 东 南 亚 最 糟 的 工 作 环 境 并 严 重 破 坏 了 生 态 环 境 ； 某 些 奉 行 保 守 佛 教 与 基 督 教 教 条 的 共 和 国 也 转 向 了 家 族 与 豪 强 政 治 。 总 的 来 说 ， 除 却 若 开 和 缅 族 主 体 区 域 外 ， 缅 甸 总 体 还 能 稳 住 压 舱 石 ： 前 者 内 部 的 佛 教 - 穆 斯 林 矛 盾 ； 后 者 人 口 迁 徙 期 间 发 生 的 政 治 动 荡 ， 都 大 有 使 其 成 为 新 版 巴 尔 干 的 潜 质 。|";
					if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
					{
						fake_text += "而 在 最 近 举 行 的 区 域 的 选 举 中 ， 绰 号 “ 腊 戎 龙 ” 的 果 敢 民 主 党 在 选 举 内 赢 得 压 倒 性 的 选 举 胜 利 。 面 对 不 再 受 “ 共 产 主 义 ” 困 扰 的 汉 族 主 导 政 权 ， 新 的 果 敢 领 导 层 很 快 便 脱 离 缅 甸 并 发 起 回 归 公 投 。 果 敢 就 此 回 到 了 中 华 母 亲 的 怀 抱 ！";
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[33].SubGosstroy == 9)
				{
					fake_text += "罂 粟 邓 楠 遮 的 飞 行|结 束 了 持 续 数 十 年 的 漫 长 战 争 后 ， 民 族 民 主 联 军 决 定 根 据 自 身 的 政 治 理 想 重 塑 建 国 原 则 — — 作 为 缅 共 东 北 军 区 的 指 挥 官 ， 彭 家 声 的 豪 赌 为 他 赢 下 了 整 个 缅 甸 ， 使 其 得 以 类 似 拿 破 仑 · 波 拿 巴 身 份 的 征 服 者 身 份 掌 管 缅 甸 ： 也 就 在 彭 家 声 的 亲 自 过 问 下 ， 涵 括 所 有 缅 甸 政 治 团 体 的 “ 缅 甸 民 族 正 义 党 ” 得 以 成 立 。|";
					if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0)
					{
						fake_text += "该 党 自 诩 为 马 列 毛 主 义 政 党 ， 并 在 公 开 访 谈 中 为 自 身 指 导 思 想 背 书 ： 彭 家 声 更 在 发 布 会 期 间 手 持 《 毛 主 席 语 录 》 ， 表 示 无 限 支 持 北 京 革 命 路 线 。";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1)
					{
						fake_text += "该 党 自 诩 为 马 列 主 义 政 党 ， 是 缅 共 的 合 法 继 承 者 。";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
					{
						fake_text += $"该 党 自 诩 为 革 命 的 社 会 民 族 主 义 政 党 ， 并 在 公 开 访 谈 中 为 自 身 指 导 思 想 背 书 ： 彭 家 声 更 在 发 布 会 期 间 手 持 《 {GlobalScript.inst.gameState.leader.name_1}{GlobalScript.inst.gameState.leader.name_2} 谈 治 国 理 政 》 ， 一 面 宣 称 “ 我 们 同 屋 檐 ， 共 命 运 ； 复 兴 大 业 一 致 ， 愿 景 矢 志 不 改 “ ， 一 面 则 以 深 化 经 济 、 政 治 与 文 化 一 体 化 的 方 式 表 示 无 限 支 持 北 京 路 线 。";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
					{
						fake_text += string.Format("该 党 自 诩 为 ” 缅 甸 特 色 社 会 主 义 “ 政 党 ， 并 在 公 开 访 谈 中 为 自 身 指 导 思 想 背 书 ： 彭 家 声 更 在 发 布 会 期 间 发 布 如 下 声 明 ： “ 我 们 将 以 经 济 建 设 为 中 心 ， 清 除 极 左 教 条 主 义 与 极 右 修 正 主 义 错 误 思 想 ； 并 基 于 有 缅 甸 特 色 的 全 过 程 人 民 民 主 实 行 对 外 开 放 政 策 ， 落 实 和 平 发 展 原 则 ” 。", GlobalScript.inst.gameState.leader.name_1, GlobalScript.inst.gameState.leader.name_2);
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
					{
						fake_text += string.Format("该 党 自 诩 为 国 家 安 全 的 保 障 者 与 军 阀 之 敌 ， 其 目 标 为 “ 建 设 公 民 社 会 ， 以 新 加 坡 与 中 国 为 蓝 本 ， 将 缅 甸 打 造 为 经 济 发 达 的 自 由 国 家 ” 。", GlobalScript.inst.gameState.leader.name_1, GlobalScript.inst.gameState.leader.name_2);
					}
					fake_text += "|然 而 ， 缅 甸 民 族 正 义 党 实 际 上 是 亲 彭 寡 头 形 成 的 联 合 ， 并 以 类 似 日 本 罪 犯 卡 特 尔 的 方 式 开 展 活 动 。 早 已 被 该 党 接 管 的 缅 甸 政 府 不 久 后 便 以 黑 手 党 模 式 清 洗 了 国 内 各 派 异 见 者 ， 并 残 酷 镇 压 一 切 可 能 威 胁 其 地 位 的 对 手 。 此 后 则 是 彻 头 彻 尾 的 征 服 者 政 策 ： 彭 家 声 以 “ 所 有 华 人 同 胞 的 守 护 神 ” 自 诩 ， 将 果 敢 人 和 德 佑 人 合 并 为 华 人 并 承 认 其 为 国 内 第 六 大 少 数 民 族 ， 并 在 事 实 上 赋 予 其 优 待 地 位 — — 旨 在 “ 保 护 少 数 民 族 并 拨 乱 反 正 ” 的 缅 甸 版 马 来 西 亚 模 式 在 掸 邦 北 部 ， 曼 德 勒 和 仰 光 等 地 盛 行 ： 对 其 他 各 族 资 产 的 国 有 化 与 相 关 资 产 向 彭 氏 集 团 、 华 人 与 中 国 商 人 群 体 的 分 配 正 火 热 进 行 。 缅 甸 的 “ 新 秩 序 ” 就 此 通 过 国 家 资 本 主 义 的 躯 体 建 立 起 来 。 接 下 来 便 是 被 超 级 大 国 斥 责 为 贼 喊 捉 贼 的 “ 缅 甸 毒 品 战 役 ” ： 缅 甸 政 府 建 立 了 毒 品 的 官 营 机 制 ， 并 将 枪 口 对 准 未 得 到 国 家 许 可 的 私 营 贩 子 上 。 该 国 罂 粟 田 数 量 逐 年 突 破 历 史 新 高 ， 新 毒 品 的 消 息 也 常 从 雨 林 内 的 反 应 室 内 传 来 — — 联 合 国 已 呼 吁 对 其 进 行 制 裁 ， 并 暗 示 “ 尚 有 能 动 性 ” 的 东 南 亚 政 权 对 缅 甸 采 取 特 殊 手 段 。 时 间 将 告 诉 我 们 这 个 私 人 国 家 兼 流 氓 政 权 会 走 向 何 处 … …||";
				}
				else
				{
					fake_text += "无 明|千 佛 之 国 一 切 如 常 ， 各 地 有 各 地 的 吃 人 法 ： 北 边 是 毒 品 贸 易 和 人 口 拐 卖 的 天 下 ； 南 面 则 是 政 府 的 暴 政 、 永 恒 持 续 的 军 政 状 态 与 持 续 萎 靡 的 经 济 。 它 们 共 同 将 曾 被 视 为 聚 宝 盆 的 缅 甸 给 变 为 了 最 不 发 达 国 家 。 显 然 ， 缅 甸 目 前 将 且 仍 将 长 期 处 于 政 治 危 机 内 。 可 对 隐 者 国 度 的 “ 拥 国 之 军 ” 来 说 ， 上 述 危 机 不 过 是 稍 嫌 麻 烦 的 皮 藓 ， 远 不 至 于 触 及 骨 髓 。 政 府 军 与 少 数 民 族 军 阀 的 仇 杀 只 限 于 在 “ 外 交 ” 层 面 发 挥 作 用 ， 并 加 剧 该 国 的 孤 立 境 地 。 也 许 ， 东 南 亚 版 黄 眉 老 仙 的 小 雷 音 寺 仍 将 长 存 ， 并 直 至 世 界 灭 亡 。";
				}
			}
			else if (number_of_e == 13)
			{
				name.text = " 阿 尔 巴 尼 亚 —— 霍 查 的 遗 产";
				fake_text = "";
				if (!GlobalScript.inst.gameState.allcountries[20].proprc && GlobalScript.inst.gameState.resultOfEvents[105] == 0)
				{
					fake_text += "碉 堡 之 国|随 着 中 阿 关 系 的 破 裂 ， 阿 尔 巴 尼 亚 失 去 了 来 自 中 国 的 经 济 与 政 治 支 持 。 阿 尔 巴 尼 亚 因 此 遭 到 重 创 ， 整 个 国 家 面 临 物 资 短 缺 的 问 题 。 尽 管 地 拉 那 尝 试 通 过 发 展 农 业 和 工 业 实 现 自 给 自 足 ， 但 缺 乏 的 基 金 与 落 后 的 产 业 导 致 经 济 上 的 危 机 非 但 没 有 解 除 ， 反 而 更 加 一 发 不 可 收 拾 。 不 断 降 低 的 生 活 水 平 ， 政 治 上 层 层 加 码 的 专 制 ， 文 化 上 的 日 益 收 紧 共 同 加 深 了 人 民 对 霍 查 后 继 者 们 的 不 满 ， 反 对 派 的 力 量 在 暗 地 里 与 日 俱 增 ， 而 阿 尔 巴 尼 亚 政 府 只 能 将 其 归 根 于 华 盛 顿 ， 贝 尔 格 莱 德 ， 莫 斯 科 ， 甚 至 于 北 京 的 颠 覆 。| ";
					bool flag4 = GlobalScript.inst.gameState.completedDecisions[9] || (GlobalScript.inst.gameState.empires[1].now_leader == 6 && GlobalScript.inst.gameState.allcountries[1].isSEV);
					if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag4 && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 不 得 不 接 受 了 反 对 派 的 要 求 。 多 党 制 的 引 进 与 新 自 由 主 义 的 经 济 政 策 摧 毁 了 红 色 的 山 鹰 之 国 ， 内 战 后 的 阿 尔 巴 尼 亚 彻 底 清 算 了 霍 查 的 一 切 遗 产 ， 自 由 之 风 笼 罩 山 鹰 之 国 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag4 && !GlobalScript.inst.gameState.modifies[6].active)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 缺 乏 外 部 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 接 受 了 反 对 派 的 要 求 。 多 党 制 的 引 进 与 新 自 由 主 义 的 经 济 政 策 摧 毁 了 红 色 的 山 鹰 之 国 ， 内 战 后 的 阿 尔 巴 尼 亚 彻 底 变 成 了 欧 洲 盗 匪 之 国 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag4 && GlobalScript.inst.gameState.modifies[6].active)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 缺 乏 外 部 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 某 求 改 变 ， 在 仅 存 的 几 个 社 会 主 义 国 家 的 帮 助 下 勉 强 度 日 。 红 色 的 山 鹰 之 国 依 然 屹 立 于 世 ， 对 吧 … …";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader != 6 && !GlobalScript.inst.gameState.event_done[380])
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 社 会 主 义 阵 营 的 压 力 转 向 了 这 个 孤 立 的 山 鹰 之 国 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 与 苏 东 集 团 缓 和 紧 张 态 势 ， 但 是 苏 阿 关 系 仍 然 不 温 不 火 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.event_done[380])
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 社 会 主 义 阵 营 的 压 力 转 向 了 这 个 孤 立 的 山 鹰 之 国 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 在 苏 共 宣 布 平 反 斯 大 林 后 恢 复 了 与 苏 动 集 团 的 接 触 ， 并 重 返 了 经 互 会 与 华 约 组 织 。";
					}
					else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power <= 80 && GlobalScript.inst.gameState.empires[1].now_leader != 6)
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 苏 修 集 团 在 走 投 无 路 后 重 新 回 到 社 会 主 义 怀 抱 之 中 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 修 复 与 冷 战 的 唯 一 胜 利 者 — — 中 国 的 关 系 。 据 报 道 ， 地 拉 那 正 在 考 虑 重 新 回 到 北 京 的 阵 营 之 中 。";
					}
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[77] == 0)
				{
					fake_text += "歌 声 飞 向 地 拉 那| 随 着 霍 查 退 出 了 领 导 队 伍 ， 霍 查 时 代 不 断 强 调 的 自 力 更 生 要 求 被 废 除 并 遗 忘 。 而 新 任 领 导 人 谢 胡 则 迫 切 求 助 于 中 国 的 帮 助 来 解 决 困 扰 新 政 府 许 久 的 经 济 问 题 。 随 着 紧 缺 的 物 资 被 来 自 中 国 货 物 填 补 ， 阿 尔 巴 尼 亚 人 民 的 生 活 水 平 稳 步 提 升 。 而 中 国 的 工 农 业 设 施 的 援 助 也 帮 助 阿 尔 巴 尼 亚 迎 来 了 久 违 的 经 济 增 长 。 享 受 到 时 代 红 利 的 阿 尔 巴 尼 亚 人 民 衷 心 拥 护 着 谢 胡 政 府 ， 这 极 大 削 弱 了 反 对 派 的 存 在 基 础 。 当 然 ， 处 于 对 巨 额 援 助 的 感 恩 ， 阿 尔 巴 尼 亚 政 府 与 中 国 站 在 统 一 战 线 ， 为 全 世 界 的 反 帝 反 霸 权 运 动 提 供 着 支 持 。 中 阿 友 谊 将 万 古 长 青 ！";
				}
				else if (GlobalScript.inst.gameState.allcountries[20].proprc && GlobalScript.inst.gameState.resultOfEvents[105] == 1 && GlobalScript.inst.gameState.allcountries[20].SubGosstroy == 0)
				{
					fake_text += "霍 查 不 死 ， 唯 有 生 辰| 随 着 指 定 接 班 人 阿 利 雅 被 刺 杀 后 ， 霍 查 遗 孀 涅 奇 米 叶 在 霍 查 的 老 战 友 的 帮 助 下 稳 定 了 政 局 。 随 着 第 二 次 “ 思 想 文 化 革 命 ” 的 开 始 ， 反 动 派 被 纷 纷 投 入 监 狱 改 造 ， 而 宗 教 教 徒 们 与 自 由 主 义 者 们 则 在 审 查 后 接 受 时 长 不 同 的 劳 动 改 造 。 人 民 被 鼓 励 使 用 群 众 性 的 “ 闪 电 报 ” 形 式 ， 对 干 部 的 官 僚 主 义 作 风 开 展 公 开 批 评 。 教 育 被 改 革 以 贴 近 社 会 实 践 ， 学 生 被 要 求 向 工 人 学 习 劳 动 经 验 ， 并 从 军 队 接 受 基 本 的 军 事 训 练 。 妇 女 也 被 从 家 庭 中 进 一 步 解 放 出 来 ， 广 泛 参 与 社 会 与 政 治 活 动 。 阿 尔 巴 尼 亚 民 族 主 义 者 被 压 制 ， 取 而 代 之 的 是 马 克 思 ， 列 宁 ， 斯 大 林 与 霍 查 的 理 论 。 当 然 ， 阿 尔 巴 尼 亚 政 府 与 中 国 盟 友 紧 紧 站 在 一 起 ， 无 论 前 方 是 晴 天 万 里 还 是 惊 涛 骇 浪 。";
				}
				else if (!GlobalScript.inst.gameState.allcountries[20].proprc && GlobalScript.inst.gameState.resultOfEvents[105] == 2)
				{
					fake_text += "破 冰 前 行| 随 着 中 阿 关 系 的 破 裂 ， 阿 尔 巴 尼 亚 失 去 了 来 自 中 国 的 经 济 与 政 治 支 持 。 阿 尔 巴 尼 亚 因 此 遭 到 重 创 ， 整 个 国 家 面 临 物 资 短 缺 的 问 题 。 尽 管 地 拉 那 尝 试 通 过 发 展 农 业 和 工 业 实 现 自 给 自 足 ， 但 缺 乏 的 基 金 与 落 后 的 产 业 导 致 经 济 上 的 危 机 非 但 没 有 解 除 ， 反 而 更 加 一 发 不 可 收 拾 ， 直 到 来 到 中 国 的 援 助 重 新 打 开 了 阿 尔 巴 尼 亚 的 大 门 。 中 国 的 物 资 重 新 提 升 了 人 民 的 生 活 水 平 ， 平 复 了 部 分 人 民 的 不 满 。 鉴 于 此 ， 阿 利 雅 大 大 减 少 了 宣 传 中 对 中 国 的 攻 击 ， 并 部 分 废 止 了1976 年 宪 法 对 寻 求 外 界 经 济 援 助 的 限 制 。 不 过 ， 阿 尔 巴 尼 亚 与 中 国 的 联 系 虽 然 恢 复 了 ， 但 是 依 然 对 其 他 主 要 国 家 大 门 紧 闭 ， 孤 立 主 义 仍 然 笼 罩 着 这 个 国 家 。| ";
					bool flag5 = GlobalScript.inst.gameState.completedDecisions[9] || (GlobalScript.inst.gameState.empires[1].now_leader == 6 && GlobalScript.inst.gameState.allcountries[1].isSEV);
					if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag5 && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 不 得 不 接 受 了 反 对 派 的 要 求 。 多 党 制 的 引 进 与 新 自 由 主 义 的 经 济 政 策 摧 毁 了 红 色 的 山 鹰 之 国 ， 内 战 后 的 阿 尔 巴 尼 亚 彻 底 清 算 了 霍 查 的 一 切 遗 产 ， 自 由 之 风 笼 罩 山 鹰 之 国 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag5 && !GlobalScript.inst.gameState.modifies[6].active)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 缺 乏 外 部 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 接 受 了 反 对 派 的 要 求 。 多 党 制 的 引 进 与 新 自 由 主 义 的 经 济 政 策 摧 毁 了 红 色 的 山 鹰 之 国 ， 内 战 后 的 阿 尔 巴 尼 亚 彻 底 变 成 了 欧 洲 盗 匪 之 国 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag5 && GlobalScript.inst.gameState.modifies[6].active)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 缺 乏 外 部 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 某 求 改 变 ， 在 仅 存 的 几 个 社 会 主 义 国 家 的 帮 助 下 勉 强 度 日 。 红 色 的 山 鹰 之 国 依 然 屹 立 于 世 ， 对 吧 … …";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader != 6 && !GlobalScript.inst.gameState.event_done[380])
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 社 会 主 义 阵 营 的 压 力 转 向 了 这 个 孤 立 的 山 鹰 之 国 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 与 苏 东 集 团 缓 和 紧 张 态 势 ， 但 是 苏 阿 关 系 仍 然 不 温 不 火 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.event_done[380])
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 社 会 主 义 阵 营 的 压 力 转 向 了 这 个 孤 立 的 山 鹰 之 国 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 在 苏 共 宣 布 平 反 斯 大 林 后 恢 复 了 与 苏 动 集 团 的 接 触 ， 并 重 返 了 经 互 会 与 华 约 组 织 。";
					}
					else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power <= 80 && GlobalScript.inst.gameState.empires[1].now_leader != 6)
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 苏 修 集 团 在 走 投 无 路 后 重 新 回 到 社 会 主 义 怀 抱 之 中 ， 阿 尔 巴 尼 亚 劳 动 党 加 强 了 与 革 命 灯 塔 的 联 系 ， 并 回 到 北 京 的 阵 营 之 中 。";
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[20].proprc && (GlobalScript.inst.gameState.resultOfEvents[105] == 0 || GlobalScript.inst.gameState.resultOfEvents[105] == 2))
				{
					fake_text += "第 八 个 是 铜 像| 在 中 国 的 外 部 保 护 与 援 助 下 ， 阿 尔 巴 尼 亚 的 经 济 稳 步 提 升 。 中 国 的 援 助 也 逐 渐 帮 助 阿 尔 巴 尼 亚 部 分 实 现 了 自 给 自 足 的 方 针 ， 并 向 着 工 业 化 与 现 代 化 的 目 标 跃 进 ， 而 阿 尔 巴 尼 亚 也 继 续 与 中 国 分 享 着 宝 贵 的 稀 有 资 源 。 不 过 ， 随 着 阿 尔 巴 尼 亚 综 合 国 力 与 国 际 影 响 的 日 渐 增 强 ， 在 霍 查 路 线 指 导 下 的 阿 尔 巴 尼 亚 开 始 走 上 了 一 条 独 立 自 主 的 路 线 ， 与 我 国 的 外 交 路 线 若 即 若 离 。 不 过 ， 友 谊 与 团 结 依 然 是 两 国 政 府 宣 传 的 主 调 。 阿 尔 巴 尼 亚 也 依 旧 秉 持 着 反 对 帝 修 反 的 外 交 方 针 支 持 着 我 国 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[20].SubGosstroy == 11)
				{
					fake_text += "贝 尔 格 莱 德 来 电 | 伴 随 着 南 斯 拉 夫 人 民 军 进 入 地 拉 那 ， 阿 尔 巴 尼 亚 的 去 霍 查 化 同 时 开 始 。 霍 查 的 雕 像 被 推 倒 ， 画 像 被 焚 烧 ， 书 籍 也 被 禁 止 。 阿 尔 巴 尼 亚 劳 动 党 对 建 国 初 亲 南 派 的 指 控 与 判 决 均 被 推 翻 ， 而 新 成 立 的 阿 尔 巴 尼 亚 共 产 主 义 联 盟 则 转 而 指 责 霍 查 - 谢 胡 集 团 的 独 裁 专 权 。 前 政 权 的 主 要 领 导 干 部 被 南 斯 拉 夫 与 阿 尔 巴 尼 亚 的 联 合 法 庭 公 审 ， 并 被 判 处 长 度 不 等 的 刑 期 。 尽 管 霍 查 派 游 击 队 仍 然 在 山 区 抵 抗 着 贝 尔 格 莱 德 的 入 侵 者 ， 绝 大 多 数 阿 尔 巴 尼 亚 人 还 是 平 静 地 接 受 了 一 切 的 改 变 。 但 所 有 人 都 心 知 肚 明 ， 这 个 所 谓 的 阿 尔 巴 尼 亚 社 会 主 义 共 和 国 无 论 再 怎 么 发 放 消 费 品 ， 抹 黑 霍 查 集 团 的 统 治 ， 都 改 变 不 了 其 不 过 是 贝 尔 格 莱 德 的 傀 儡 的 事 实 。";
				}
				else if (GlobalScript.inst.gameState.allcountries[20].parts[1])
				{
					fake_text += "斯 坎 德 培 之 梦|在 接 连 击 败 南 斯 拉 夫 的 现 代 修 正 主 义 者 与 希 腊 的 法 西 斯 独 裁 者 后 ， 阿 尔 巴 尼 亚 人 民 的 爱 国 热 情 达 到 了 其 历 史 巅 峰 。 尽 管 霍 查 已 经 去 世 ， 阿 尔 巴 尼 亚 劳 动 党 领 导 人 恩 维 尔 · 霍 查 被 与 阿 尔 巴 尼 亚 历 史 上 的 民 族 英 雄 乔 治 · 卡 斯 特 里 奥 蒂 · 斯 坎 德 培 相 提 并 论 ， 两 人 的 雕 像 也 一 起 树 立 在 地 拉 那 的 斯 坎 德 培 广 场 之 上 ， 接 受 人 民 的 崇 拜 与 欢 呼 。 而 流 亡 的 阿 尔 巴 尼 亚 反 对 派 和 阿 尔 巴 尼 亚 国 内 的 自 由 派 要 么 不 得 不 肯 定 霍 查 政 权 为 阿 尔 巴 尼 亚 民 族 复 兴 所 作 出 的 巨 大 贡 献 ， 要 么 在 愤 怒 的 阿 尔 巴 尼 亚 青 年 的 冲 击 下 退 出 政 治 不 再 发 声 。 伴 随 着 阿 尔 巴 尼 亚 国 际 声 望 的 不 断 增 长 ， 他 们 与 北 京 的 路 线 保 持 了 距 离 。 另 一 面 ， 苏 联 与 美 国 不 得 不 接 受 了 这 个 巴 尔 干 强 权 的 崛 起 ， 并 暗 地 里 表 达 了 对 其 的 担 忧 。 “ 我 们 在 今 后 的 下 个 世 纪 恐 怕 将 会 被 大 阿 尔 巴 尼 亚 主 义 所 困 扰 ” 不 会 成 真 的 ， 对 吧 … …";
				}
				else if (GlobalScript.inst.gameState.allcountries[20].parts[0] && !GlobalScript.inst.gameState.allcountries[20].Torg)
				{
					fake_text += "折 戟 沉 沙 铁 未 销|阿 尔 巴 尼 亚 为 其 对 敌 人 的 低 估 付 出 了 惨 痛 的 代 价 ， 对 希 腊 的 轻 敌 葬 送 了 一 大 批 骁 勇 善 战 的 战 士 。 面 对 不 得 赔 偿 巨 款 以 避 免 被 推 翻 的 现 状 ， 阿 尔 巴 尼 亚 政 府 不 得 不 做 出 些 许 改 变 。 毕 竟 ， 对 于 整 合 科 索 沃 地 区 以 及 深 陷 经 济 危 机 的 阿 尔 巴 尼 亚 政 府 来 说 ， 改 革 总 比 社 会 主 义 制 度 被 彻 底 葬 送 好 。1976 年 宪 法 对 寻 求 外 界 经 济 援 助 的 限 制 被 彻 底 废 除 ， 在 学 习 了 南 斯 拉 夫 和 罗 马 尼 亚 的 外 债 社 会 主 义 之 路 之 后 ， 阿 尔 巴 尼 亚 也 向 资 本 主 义 国 家 和 修 正 主 义 国 家 敞 开 了 投 资 的 大 门 。 随 着 投 资 纷 至 沓 来 ， 阿 尔 巴 尼 亚 政 府 内 的 技 术 官 僚 也 不 断 放 宽 甚 至 直 接 废 除 某 些 限 制 来 促 进 经 济 增 长 。 阿 尔 巴 尼 亚 正 在 逐 渐 走 向 富 裕 之 路 ， 尽 管 有 人 在 疾 呼 资 本 主 义 文 化 的 入 侵 ， 但 是 “ 贫 穷 不 是 社 会 主 义 ” ， 不 是 吗 ？";
				}
				else if (GlobalScript.inst.gameState.resultOfEvents[105] == 1 && GlobalScript.inst.gameState.allcountries[20].SubGosstroy == 10)
				{
					fake_text += "永 不 停 息 的 红 色 恐 怖| 随 着 指 定 接 班 人 阿 利 雅 被 刺 杀 后 ， 霍 查 遗 孀 涅 奇 米 叶 在 霍 查 生 前 提 拔 的 新 一 代 党 员 的 帮 助 下 稳 定 了 政 局 。 大 规 模 的 清 洗 几 乎 血 洗 了 地 拉 那 ， 党 内 外 的 反 对 派 被 “ 西 古 里 米 ” 逮 捕 并 处 决 。 而 大 量 出 生 于 “ 地 富 反 坏 右 ” 家 庭 的 民 众 被 编 入 修 筑 新 碉 堡 群 的 队 伍 里 ， 阿 尔 巴 尼 亚 人 民 军 也 不 断 利 用 我 国 提 供 的 军 备 扩 军 备 战 。 当 然 ， 阿 尔 巴 尼 亚 的 经 济 也 因 此 走 向 了 停 滞 。 不 过 我 国 源 源 不 断 的 物 资 援 助 保 障 了 阿 尔 巴 尼 亚 人 民 生 活 水 平 不 至 于 大 幅 度 倒 退 。 阿 尔 巴 尼 亚 与 美 苏 的 关 系 进 一 步 恶 化 ， 这 也 使 得 民 族 主 义 论 调 开 始 甚 嚣 尘 上 。 阿 尔 巴 尼 亚 政 府 仍 然 维 持 着 与 中 国 的 关 系 ， 不 过 对 中 国 的 宣 传 频 率 每 况 愈 下 ， 而 霍 查 与 斯 坎 德 培 的 宣 传 则 每 日 剧 增 。";
				}
				else if (!GlobalScript.inst.gameState.allcountries[20].proprc)
				{
					fake_text += "碉 堡 之 国|随 着 中 阿 关 系 的 破 裂 ， 阿 尔 巴 尼 亚 失 去 了 来 自 中 国 的 经 济 与 政 治 支 持 。 阿 尔 巴 尼 亚 因 此 遭 到 重 创 ， 整 个 国 家 面 临 物 资 短 缺 的 问 题 。 尽 管 地 拉 那 尝 试 通 过 发 展 农 业 和 工 业 实 现 自 给 自 足 ， 但 缺 乏 的 基 金 与 落 后 的 产 业 导 致 经 济 上 的 危 机 非 但 没 有 解 除 ， 反 而 更 加 一 发 不 可 收 拾 。 不 断 降 低 的 生 活 水 平 ， 政 治 上 层 层 加 码 的 专 制 ， 文 化 上 的 日 益 收 紧 共 同 加 深 了 人 民 对 霍 查 后 继 者 们 的 不 满 ， 反 对 派 的 力 量 在 暗 地 里 与 日 俱 增 ， 而 阿 尔 巴 尼 亚 政 府 只 能 将 其 归 根 于 华 盛 顿 ， 贝 尔 格 莱 德 ， 莫 斯 科 ， 甚 至 于 北 京 的 颠 覆 。| ";
					bool flag6 = GlobalScript.inst.gameState.completedDecisions[9] || (GlobalScript.inst.gameState.empires[1].now_leader == 6 && GlobalScript.inst.gameState.allcountries[1].isSEV);
					if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag6 && GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 不 得 不 接 受 了 反 对 派 的 要 求 。 多 党 制 的 引 进 与 新 自 由 主 义 的 经 济 政 策 摧 毁 了 红 色 的 山 鹰 之 国 ， 内 战 后 的 阿 尔 巴 尼 亚 彻 底 清 算 了 霍 查 的 一 切 遗 产 ， 自 由 之 风 笼 罩 山 鹰 之 国 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag6 && !GlobalScript.inst.gameState.modifies[6].active)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 缺 乏 外 部 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 接 受 了 反 对 派 的 要 求 。 多 党 制 的 引 进 与 新 自 由 主 义 的 经 济 政 策 摧 毁 了 红 色 的 山 鹰 之 国 ， 内 战 后 的 阿 尔 巴 尼 亚 彻 底 变 成 了 欧 洲 盗 匪 之 国 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 && !flag6 && GlobalScript.inst.gameState.modifies[6].active)
					{
						fake_text += "1990 年 初 ， 随 着 东 欧 各 国 的 变 革 之 风 吹 向 阿 尔 巴 尼 亚 ， 缺 乏 外 部 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 某 求 改 变 ， 在 仅 存 的 几 个 社 会 主 义 国 家 的 帮 助 下 勉 强 度 日 。 红 色 的 山 鹰 之 国 依 然 屹 立 于 世 ， 对 吧 … …";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader != 6 && !GlobalScript.inst.gameState.event_done[380])
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 社 会 主 义 阵 营 的 压 力 转 向 了 这 个 孤 立 的 山 鹰 之 国 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 与 苏 东 集 团 缓 和 紧 张 态 势 ， 但 是 苏 阿 关 系 仍 然 不 温 不 火 。";
					}
					else if (GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.event_done[380])
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 社 会 主 义 阵 营 的 压 力 转 向 了 这 个 孤 立 的 山 鹰 之 国 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 在 苏 共 宣 布 平 反 斯 大 林 后 恢 复 了 与 苏 动 集 团 的 接 触 ， 并 重 返 了 经 互 会 与 华 约 组 织 。";
					}
					else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power <= 80 && GlobalScript.inst.gameState.empires[1].now_leader != 6)
					{
						fake_text += "随 着 美 国 霸 权 走 向 解 体 ， 苏 修 集 团 在 走 投 无 路 后 重 新 回 到 社 会 主 义 怀 抱 之 中 ， 缺 乏 援 助 的 阿 尔 巴 尼 亚 劳 动 党 不 得 不 修 复 与 冷 战 的 唯 一 胜 利 者 — — 中 国 的 关 系 。 据 报 道 ， 地 拉 那 正 在 考 虑 重 新 回 到 北 京 的 阵 营 之 中 。";
					}
				}
				fake_text += "|||||||注 ： 1908年10月16日为恩维尔·霍查同志的诞辰";
			}
			else if (number_of_e == 14)
			{
				name.text = " 版 本 前 瞻";
				fake_text = " V1.1.5 ： 国 土 南 疆 的 象 龙 斗 ？ 搅 动 乳 海 的 剑 与 镰 ？ 走 出 天 命 论 迷 宫 的 第 一 步 ？ 该 隐 亦 或 流 便 ？ 老 朋 友 的 新 故 事 ？ 无 底 深 渊 殉 道 者 的 理 想 何 日 实 现 ？ 静 待 蒲 公 英 飞 回 故 乡 的 那 天 … … ";
			}
		}
		else if (number_of_e == 0)
		{
			GoodEnd();
		}
		else if (number_of_e == 1)
		{
			if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.data[66] == 0 && GlobalScript.inst.gameState.data[67] == 0 && GlobalScript.inst.gameState.data[65] > 0 && GlobalScript.inst.gameState.data[62] == 2)
			{
				achieves.GetComponent<achievements>().Set(8);
			}
			name.text = "Старые территории";
			if (GlobalScript.inst.gameState.allcountries[70].numberOfSpecialEnding < 0)
			{
				if (GlobalScript.inst.gameState.data[66] <= 0)
				{
					fake_text = "Синьцзян-Уйгурский автономный район продолжает оставаться составной частью Китая, несмотря на подогреваемые нашими противниками сепаратистские настроения. Однако ситуация в районе пока под контролем, органы власти функционируют, как положено, а МГБ и Синьцзянский производственно-строительный корпус успешно пресекают любые попытки организовать серьезное сепаратистское движение за выход Синьцзяна из состава Китая.";
				}
				else if (GlobalScript.inst.gameState.data[66] == 1)
				{
					fake_text = "Поддерживаемые СССР синьцзянские сепаратисты смогли-таки, воспользовавшись нашими проблемами, захватить власть в районе и добиться независимости от Китая. Впрочем, \"независимость\" быстро сменилась тотальной зависимостью от Советского Союза - руководство Восточно-Туркестанской Народной республики формируется по согласованию с Москвой, армией командуют советские офицеры, а экономика под полным контролем советников из Союза. Все партии, кроме Коммунистической партии Восточного Туркестана, запрещены. Де-факто, Синьцзян стал \"внеблоковой республикой\" СССР по образцу Болгарии и Монголии...";
				}
				else if (GlobalScript.inst.gameState.data[66] >= 2)
				{
					fake_text = "Синьцзянские сепаратисты смогли-таки, воспользовавшись нашими проблемами, захватить власть в районе и добиться независимости от Китая. Как и следовало ожидать, экономика района после разрыва кооперационных связей с нашими предприятиями развалилась, а попытки руководства Синьцзянской республики балансировать между нами, СССР и США привели к превращению её в поле геополитической борьбы. Пока верхушка и возродившаяся буржуазия купаются в роскоши, растрачивая полученные от сверхдержав доллары, рубли и юани, народ Синьцзяна живет в крайней нищете, вследствие чего всю большую популярность набирают исламистские настроения... ";
				}
			}
			if (GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding < 0 || GlobalScript.inst.gameState.allcountries[69].numberOfSpecialEnding > 10)
			{
				if (GlobalScript.inst.gameState.data[67] <= 0)
				{
					fake_text += "||Тибетский автономный район продолжает оставаться составной частью Китая, несмотря на подрывную пропаганду бежавших за границу сторонников Далай-Ламы и части местного духовенства. На экономическое развитие района тратятся огромные средства, призванные ещё крепче \"привязать\" его к остальной стране, с другой стороны, мы не ослабляем контроль над духовенством и решительно пресекаем любые попытки организовать серьезное сепаратистское движение за выход Тибета из состава Китая.";
				}
				else
				{
					fake_text += "||Тибетские сепаратисты смогли-таки, воспользовавшись нашими проблемами, захватить власть в районе и добиться независимости от Китая. Далай-Лама XIV торжественно вернулся в Лхасу, где выступил с торжественной речью, обличая нас и радуясь \"окончанию китайской оккупации свободного Тибета\". Впрочем, не все так радужно в \"свободном Тибете\" - с разрывом кооперации с нашими предприятиями, экономика района фактически развалилась, населению приходится буквально выживать скотоводством и сбором лекарственных трав, а Индия уже начинает поднимать давний территориальный спор за Аруначал Прадеш и требует пересмотра \"линии Мак-Магона\" в свою пользу...";
				}
			}
			if (!GlobalScript.inst.gameState.completedDecisions[6] && !GlobalScript.inst.gameState.completedDecisions[7])
			{
				if (GlobalScript.inst.gameState.allcountries[38].dev > 0)
				{
					fake_text = fake_text + "||Тайваньские сепаратисты спрятались за спины своих американских друзей, но они переоценили своих защитников и недооценили нашу решимость воссоединить Родину. Десант наших вооруженных сил отбил приграничные острова у берега Тайваня и выгнал оттуда сепаратистов, восстановив над этой территорией наш суверенитет. \"Территория Китая едина и неделима!\" - ответил Председатель " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " на бешенные крики империалистов. Правда, сам Тайвань мы силой отбить не сможем из-за расположенных там американских военных баз, а на переговоры он после такого точно не пойдет...";
				}
				else if ((GlobalScript.inst.gameState.allcountries[38].proprc && GlobalScript.inst.gameState.data[6] < 700 && GlobalScript.inst.gameState.data[16] >= 13 && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.modifies[17].active) || GlobalScript.inst.gameState.completedDecisions[6])
				{
					fake_text = fake_text + "||Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " выдвинул важную теорию \"Одна страна - две системы\", в соответствии с которой Тайвань, Гонконг и Макао могут вернуться в лоно Родины с сохранением своей политической и экономической системы на 50 лет вперед и очень широкой автономией. Руководство Тайваня очень долго отказывалось от каких-либо переговоров с нами, но, наконец, нам удалось усадить их за круглый стол и прийти к соглашению. В обмен на формальное признание КНР независимости Китайской республики и её отказа от претензий на прибрежные острова, Тайвань официально отказывается от \"Трех народных принципов\" и признает политику \"Одна страна - две системы\". Уже начаты переговоры об основных принципах воссоединения Тайваня с Китаем (условия будут явно конфедеративными или даже более широкими) и о выводе с острова американских военных баз, однако окончательное объединение Родины произойдет нескоро...";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(66);
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[38].proprc || GlobalScript.inst.gameState.allcountries[38].Torg)
				{
					fake_text = fake_text + "||Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + ", несмотря на яростное сопротивление многих консерваторов и сторонников жёсткой линии, всё же принял волевое решение признать независимость Тайваня и покончить с почти полувековой враждой. По мнению нового курса китайской дипломатии, Тайвань слишком долго был независимым и за это время отдалился от материкового Китая в культурном, экономическом и политическом плане и выстроил слишком крепкие отношения с мировым сообществом, чтобы можно было говорить о его принадлежности к КНР. Было заявлено о выработке полностью новых принципов добрососедских отношений КНР и Китайской Республики, которая в свою очередь отказалась от претензий на материковый Китай.";
				}
				else
				{
					fake_text += "||Сепаратистская \"Китайская республика\" продолжает удерживать Тайвань и прибрежные острова, опираясь на военную поддержку США и наотрез отказываясь от нормализации отношений с континентальным Китаем. Нам остается только вздыхать и посылать захватчикам \"последние китайские предупреждения\"...";
				}
			}
		}
		else if (number_of_e == 2)
		{
			name.text = "Новые территории";
			if (GlobalScript.inst.gameState.data[65] <= 0)
			{
				fake_text = "Гонконг и Макао продолжают оставаться колониями, соответственно, Великобритании и Португалии, оторванными от своей Родины. Западные колонизаторы отказываются от каких-либо переговоров по вопросу их возвращения нам, а на военные действия мы не рискуем, опасаясь вмешательства США и начала Третьей Мировой войны.";
			}
			else if (GlobalScript.inst.gameState.data[65] == 1)
			{
				fake_text = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " и ВСНП выдвинули важную теорию \"Одна страна - две системы\", в соответствии с которой Гонконг и Макао могут вернуться в лоно Родины с сохранением своей политической и экономической системы на 50 лет вперед и очень широкой автономией. Переговоры по этому вопросу с английской и португальской стороной были очень трудными и неоднократно срывались колонизаторами, но они все-таки увенчались успехом - 1 июля 1997 года нам будет возвращен суверенитет над Гонконгом, а 19 декабря 1999 года - и над Макао. Таким образом, исполниться великая мечта китайского народа - Сянган (Гонконг) и Аомынь (Макао) вернуться к нам - остается надеяться, что навсегда.";
			}
			else if (GlobalScript.inst.gameState.data[65] >= 2 && GlobalScript.inst.gameState.allcountries[0].stab == 1)
			{
				fake_text = "За время руководства страной " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + ", возможно, было совершено немало ошибок, но этот период войдет в историю Китая как \"Восстановление Родины\" - ибо была восстановлена историческая справедливость и Гонконг и Макао, которые сотни лет удерживались иностранными захватчиками, были возвращены Китаем. Теперь Сянган (Гонконг) и Аомынь (Макао) - снова вместе с Родиной-Матерью, и мы их больше никому никогда не отдадим!";
			}
			else if (GlobalScript.inst.gameState.data[65] >= 2)
			{
				fake_text = "Мастерство наших дипломатов и наша репутация в мире позволили, несмотря на серьёзное противодействие колониальных властей, добиться на переговорах с англичанами и португальцами передачи Гонконга и Макао с их полной интеграцией в состав КНР при гарантии сохранения частной собственности иностранцев. Переговоры по этому вопросу с английской и португальской стороной были очень трудными и неоднократно срывались колонизаторами, но они все-таки увенчались успехом - 1 июля 1997 года нам будет возвращен суверенитет над Гонконгом, а 19 декабря 1999 года - и над Макао. Таким образом, Сянган (Гонконг) и Аомынь (Макао) вернуться к нам - остается надеяться, что навсегда.";
			}
			if (GlobalScript.inst.gameState.data[62] <= 0)
			{
				fake_text += "||Штат Аруначал Прадеш продолжает оставаться в составе Индии, что Китай упорно отказывается признавать. Попытки переговоров по этому вопросу, в том числе при патронаже международных организаций, не увенчались успехом, так что ситуация на индо-китайской границе продолжает оставаться напряженной. Однако непохоже, чтобы стороны были заинтересованы в войне друг с другом...";
			}
			else if (GlobalScript.inst.gameState.data[62] == 1)
			{
				fake_text += "||Нам удалось договориться с руководством Индии о компромиссном решении территориального вопроса - Китай отказывается от претензий на штат Аруначал Прадеш, а Индия - на район Аксай Чин, занятый нами в ходе приграничного конфликта 1962 года и через который проходит важное шоссе Годао 219, соединяющее Синьцзян с Тибетом. Это решение, наконец, открыло дорогу к восстановлению добрососедских отношений двух самых крупных стран Азии и сильно разрядило напряженность в Азиатском регионе.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(39);
				}
			}
			else if (GlobalScript.inst.gameState.data[62] == 2)
			{
				fake_text += "||Китай, наконец, положил конец давнему территориальному спору с Индией - решительными действиями наших вооруженных сил штат Аруначал Прадеш полностью возвращен в состав Китая. Руководству Индии, на фоне очередного обострения обстановки в сикхских районах страны и конфликта с Пакистаном, пришлось признать за нами права на эту территорию, хотя факт потери этого, весьма важного для страны штата, его очень сильно разозлил. По нашим данным, Индия тайно договаривается с США, СССР и Великобританией о больших поставках оружия и снаряжения для масштабного перевооружения своей армии. Против кого эти приготовления - гадать не приходится...";
			}
			else if (GlobalScript.inst.gameState.data[62] >= 3)
			{
				fake_text += "||Китай, наконец, положил конец давнему территориальному спору с Индией - решительными действиями наших дипломатов Аруначал Прадеш полностью возвращен в состав Китая. Руководству Индии, на фоне очередного обострения обстановки в сикхских районах страны и экономических проблем, пришлось признать за нами права на эту территорию, хотя факт потери этого, весьма важного для страны штата, очень сильно разозлил их население. По нашим данным, Индия тайно договаривается с США, СССР и Великобританией о больших поставках техники и снаряжения для масштабного перевооружения и расширение штата своих спецслужб. Против кого эти приготовления - трудно сказать: подавлять своё население или разжигать волнения в Аруначале Прадеше?";
			}
			if (!GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19])
			{
				fake_text += "||Монголия остаётся активным другом и партнёром Москвы несмотря ни на что.";
			}
			else if (GlobalScript.inst.gameState.allcountries[9].proprc && !GlobalScript.inst.gameState.completedDecisions[19])
			{
				fake_text += "||Монголия является полноправным равным членом китайской сферы влияния и ориентируется на Пекин в решении спорных и внешнеполитических вопросов.";
			}
			else
			{
				fake_text += "||Благодаря усердию и труду китайские и монгольские братья смогли вновь найти общий язык и объединиться под крышей единого дома в лице Китайской народной республики";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(109);
				}
			}
		}
		else if (number_of_e == 3)
		{
			name.text = "Судьба СССР";
			if (GlobalScript.inst.gameState.empires[1].now_leader == 3)
			{
				fake_text = "Щербицкий|Пришедший на смену Брежневу Владимир Щербицикий начал своё правление с чисток в Политбюро, приводя на освободившиеся места свои кадры из УССР, что встряхнуло застоявшийся брежневский аппарат и нарушило коррупционные связи между его членами. Удары по коррупции и припискам вкупе с административными талантами старого управленца обеспечили Союзу устойчивый рост экономики и благосостояния населения. Внешняя же и внутренняя политика Щербицкого мало чем отличались от брежневской - была усилена экономическая интеграция стран СЭВ, что положительно сказалось на всём содружестве, проведена разрядка в отношениях с КНР, предпринимаются осторожные и медленные попытки автоматизации планирования, но в целом всё стабильно. Союз стоит и собирается стоять ещё очень долго.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(48);
				}
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 5)
			{
				fake_text = "Гришин|В конечном итоге, на смену старому правителю пришёл старый и опытный Виктор Гришин, любимец консервативных кругов. Для СССР ничего особо не изменилось - относительно устойчивый экономический рост позволял с каждым годом тратить больше денег на зерно и социальные расходы, предпринимаются очень осторожные и медленные попытки автоматизации планирования, подавляемые партократией, внешняя политика характеризовалась продолжением \"Доктрины Брежнева\", однако с упором на разрядку отношений с КНР. Вместе с тем, правление Гришина означало окончательное закрепление партократии, разгул кумовства, коррупции и приписок.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(37);
				}
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
			{
				fake_text = "Горбачёв|В конечном итоге, на смену старому правителю пришёл молодой и перспективный Михаил Горбачёв, один из реформаторских кадров Андропова. Однако ни одна реформаторская инициатива Горбачёва хорошо не закончилась - антиалкогольная кампания привела к упадку сельского хозяйства и массовому хождению суррогатов, политика Ускорения - к бездарной растрате средств и упадку промышленности, Гласность - к росту национализма и расцвету антисоветской лжи. Попытки то увеличить, то снизить роль государства в экономике, бездарное и бесконтрольное внедрение кооперативов, децентрализация и разрушение плановых механизмов привели к огромному внешнему долгу, развалу экономики, дефициту и обнищанию населения. Внешняя же политика характеризовалась подхалимством перед США и сдачей всех социалистических завоеваний, кульминацией чего стал роспуск ОВД и СЭВ. Сам же СССР ненадолго их пережил - взращенные Горбачёвым либералы и националисты, завоевав поддержку населения, в конце 1991 года объявили о роспуске СССР, фактически отобрав власть у горе-реформатора.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(36);
				}
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 7)
			{
				fake_text = string.Format(GlobalScript.inst.new_events_text[1568], "\n");
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
			{
				fake_text = "Лигачёв|В конечном итоге, на смену старому правителю пришёл опытный региональный руководитель Егор Лигачёв, один из реформаторских кадров Андропова. Он провозгласил политику Гласности, расширения демократизации и перехода к социалистической рыночной экономике по образцу ленинского НЭП. Однако все реформаторские инициативы Лигачёва пошли с большим трудом - антиалкогольная кампания привела к хождению суррогатов, хотя и позволила увеличить рождаемость и сократить преступность, политика Ускорения позволила увеличить промышленное производство, однако вызвала рост дефицита ТНП, Гласность - хотя и позволила расширить свободы, но привела к появлению антисоветских публикаций. Попытки перейти от директивных к индикативным механизмам в экономике, не до конца обдуманное внедрение кооперативов, децентрализация и нарушение плановых механизмов привели к спаду производства ТНП и обнищанию довольно существенной части населения. Внешняя же политика характеризовалась безуспешными попытками Разрядки с США и сокращением контроля за ОВД и СЭВ, что привело к росту в этих блоках сепаратистских тенденций. Сам же СССР находится в достаточно сложном положении, а попытки Лигачёва укрепить положение дел путем продвижения таких людей, как Борис Ельцин и Виталий Коротич, привели к появлению в КПСС легальной оппозиции, подрывающей единство партии. Пока что руководство страны контролирует ситуацию, но экономисты предупреждают, что в течении 25 лет возможен крупный кризис, который советские горе-реформаторы могут и не пережить...";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(61);
				}
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 4)
			{
				if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[7].parts[2])
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(140);
					}
					fake_text = string.Format(GlobalScript.inst.new_events_text[1565], "\n");
				}
				else if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[7].parts[0])
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1566], "\n");
				}
				else if (GlobalScript.inst.dlc[3] && GlobalScript.inst.gameState.allcountries[7].parts[1])
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1567], "\n");
				}
				else
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(38);
					}
					fake_text = "Романов|В конечном итоге, на смену старому правителю пришел относительно молодой и перспективный партиец Григорий Романов, известный своими заслугами на посту главы Ленинградского обкома КПСС. Его приход ознаменовал начало внутрипартийных чисток от реформаторов, усиление контроля спецслужб и преследование диссидентов. Парадоксальным образом при нём же начались некоторые цензурные послабления в творческой сфере - в стране было открыто множество музыкальных клубов, по образцу Ленинградского рок-клуба, а кинорежиссёры стали свободней экспериментировать с новыми жанрами. Внешняя политика СССР стала более жёсткой и охарактеризовалась более активным распространением советского влияния и более жёсткой защитой советских интересов. ";
					if (GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.data[16] == 11)
					{
						fake_text += "|Вдохновлённый успехом китайской автоматизации, Романов решил начать массовое внедрение механизмов автоматизации планирования, продолжив развитие АСУ и ЕГСВЦ, а также, достав с полки проект ОГАС, разработку и внедрение которого удалось завершить, несмотря на недовольство партократов. Романов руководил Советским Союзом до своей смерти в 2008 году, за это время многократно подняв международное влияние СССР, его экономическую мощь и благосостояние населения.";
						if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.data[16] == 11 && GlobalScript.inst.gameState.allcountries[1].isSEV)
						{
							achieves.GetComponent<achievements>().Set(35);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[15].Gosstroy == 0 && GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 0 && GlobalScript.inst.gameState.allcountries[4].Gosstroy == 1 && GlobalScript.inst.gameState.allcountries[4].SubGosstroy == 16)
					{
						fake_text += "|Увидев на личном примере провальность результатов экономической политики Венгрии и Югославии Романов решил пойти другим путём отличающимся от планов Андропова и начать массовое внедрение механизмов автоматизации планирования, продолжив развитие АСУ и ЕГСВЦ, а также, достав с полки проект ОГАС, разработку и внедрение которого удалось завершить, несмотря на недовольство партократов. Романов руководил Советским Союзом до своей смерти в 2008 году, за это время многократно подняв международное влияние СССР, его экономическую мощь и благосостояние населения.";
						if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.data[16] == 11 && GlobalScript.inst.gameState.allcountries[1].isSEV)
						{
							achieves.GetComponent<achievements>().Set(35);
						}
					}
					else
					{
						fake_text += "|После обвала цен на нефть в середине 80-х было принято решение о начале экономических реформ - за основу были взяты проекты андроповских планов реформ (основанных на реформе Косыгина-Либермана и экономических систем Югославии и Венгрии), что в совокупности подняло конкурентоспособность и гибкость советской экономики, однако и негативные эффекты децентрализации не заставили себя долго ждать: неэффективное распределение прибыли предприятиями, устаревание аппаратуры и механизмов из-за экономии предприятий на модернизации, развитие кумовства и коррупционных связей между звеньями производства-снабжения (когда снабжение стало первоочерёдно даваться по знакомству, а люди стали \"покупать\" места в очереди за сырьём). Однако, вместе с этим был введён категорический запрет на любую частную собственность и частный найм, что было даже вписано в Конституцию. Романов руководил Советским Союзом до своей смерти в 2008 году, за это время сильно подняв международное влияние СССР, его экономическую мощь и благосостояние населения. Впрочем, после его смерти, новые советские лидеры с прискорбием подтвердили наблюдения международных экспертов о том, что рост советской экономики уже несколько лет как крайне близок к нулю, и с этим надо что-то делать...";
					}
				}
			}
		}
		else if (number_of_e == 4)
		{
			name.text = "Советский соцлагерь";
			if (GlobalScript.inst.gameState.empires[1].now_leader == 4 && GlobalScript.inst.gameState.event_done[377])
			{
				fake_text = string.Format(GlobalScript.inst.new_events_text[1570], "\n", (GlobalScript.inst.gameState.allcountries[7].parts[1] || GlobalScript.inst.gameState.allcountries[1].parts[2]) ? GlobalScript.inst.new_events_text[1571] : null);
			}
			else if ((GlobalScript.inst.gameState.empires[1].now_leader == 3 || GlobalScript.inst.gameState.empires[1].now_leader == 5 || GlobalScript.inst.gameState.empires[1].now_leader == 4) && !GlobalScript.inst.gameState.allcountries[1].isSEV && !GlobalScript.inst.gameState.allcountries[1].isOVD)
			{
				fake_text = "Для социалистического лагеря ничего особо не изменилось - СЭВ и ОВД продолжают оставаться стабильной альтернативой капиталистическим альянсам, а СССР - их неоспоримым лидером.";
			}
			else if ((GlobalScript.inst.gameState.empires[1].now_leader == 3 || GlobalScript.inst.gameState.empires[1].now_leader == 5 || GlobalScript.inst.gameState.empires[1].now_leader == 4) && GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[1].isOVD)
			{
				fake_text = "Вступление КНР в СЭВ и ОВД и рост её влияния в организации и в мире вызывают серьёзные опасения советского руководства за своё лидерство. В остальном же для социалистического лагеря ничего особо не изменилось - СЭВ и ОВД продолжают оставаться стабильной альтернативой капиталистическим альянсам.";
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[1].isOVD && GlobalScript.inst.gameState.relres)
				{
					achieves.GetComponent<achievements>().Set(5);
				}
			}
			else if (GlobalScript.inst.gameState.event_done[433])
			{
				fake_text = string.Format(GlobalScript.inst.new_events_text[1602], "\n");
			}
			else if ((GlobalScript.inst.gameState.empires[1].now_leader == 6 || GlobalScript.inst.gameState.empires[1].now_leader == 8) && ((GlobalScript.inst.gameState.relres && GlobalScript.inst.gameState.allcountries[1].econ && GlobalScript.inst.gameState.allcountries[1].okb) || (GlobalScript.inst.gameState.allcountries[5].Torg && !GlobalScript.inst.gameState.allcountries[2].prosov && !GlobalScript.inst.gameState.allcountries[4].prosov && (GlobalScript.inst.gameState.allcountries[1].econ || GlobalScript.inst.gameState.allcountries[1].okb))))
			{
				if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
				{
					fake_text = "Для социалистического лагеря ничего особо не изменилось - СЭВ и ОВД продолжают оставаться альтернативой капиталистическим альянсам, а СССР - пока ещё их лидером.";
				}
				else
				{
					fake_text = "После прихода Горбачёва к власти в СССР соцлагерь начал медленно разваливаться, а без советской поддержки власть его членов начала шататься. Но налаженные отношения КНР и СССР вместе с торговлей с СЭВ позволили нам получить то, что не смог удержать Горбачёв. После роспуска ОВД и СЭВ мы настойчиво предложили Восточной Европе членство в наших альянсах на выгодных условиях, на что Румыния, Болгария, Венгрия, Польша и Чехословакия согласились.";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(6);
					}
				}
			}
			else if ((GlobalScript.inst.gameState.empires[1].now_leader == 6 || GlobalScript.inst.gameState.empires[1].now_leader == 8) && ((GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.allcountries[1].isOVD) || (GlobalScript.inst.gameState.allcountries[5].Torg && !GlobalScript.inst.gameState.allcountries[2].prosov && !GlobalScript.inst.gameState.allcountries[4].prosov && (GlobalScript.inst.gameState.allcountries[1].isOVD || GlobalScript.inst.gameState.allcountries[1].isSEV))))
			{
				if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
				{
					fake_text = "После прихода Лигачёва к власти в СССР соцлагерь начал медленно разваливаться, а без советской поддержки власть его членов начала шататься. Однако наше членство в ОВД и СЭВ помогло нам сохранить их в слегка изменённом виде. На тайном заседании мы разработали план по окончательному падению советского лидерства в СЭВ и ОВД. Само собой, опасаясь тёмного будущего, большинство стран с радостью согласилось и теперь СЭВ и ОВД составляют уже более равноправный и обновлённый соцлагерь с нашим лидерством. Правда теперь, вместо СССР, мы оказываем всю посильную помощь этим странам.";
				}
				else
				{
					fake_text = "После прихода Горбачёва к власти в СССР соцлагерь начал медленно разваливаться, а без советской поддержки власть его членов начала шататься. Однако наше членство в ОВД и СЭВ помогло нам сохранить их в слегка изменённом виде. После роспуска СЭВ и ОВД, мы предложили их членам создание новых блоков, взяв на себя все расходы на поддержку экономики наших старых друзей. Само собой большинство стран с радостью согласилось - ГДР, Румыния, Болгария, Чехословакия, Венгрия и Польша продолжают составлять уже более равноправный и обновлённый соцлагерь с нашим лидерством.";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(6);
					}
				}
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 6 || GlobalScript.inst.gameState.empires[1].now_leader == 8)
			{
				if (GlobalScript.inst.gameState.empires[1].now_leader == 8)
				{
					fake_text = "Для социалистического лагеря ничего особо не изменилось - СЭВ и ОВД продолжают оставаться альтернативой капиталистическим альянсам, а СССР - пока ещё их лидером.";
				}
				else
				{
					fake_text = "После прихода Горбачёва к власти в СССР соцлагерь начал медленно разваливаться, а без советской поддержки власть его членов начала шататься, что и завершилось в конце 80-х \"бархатными революциями\" и падением социалистических правительств Восточной Европы. ";
					if (GlobalScript.inst.gameState.allcountries[0].isNATO && GlobalScript.inst.gameState.allcountries[0].isEU)
					{
						fake_text += "И хотя эти страны теперь номинально являются нейтральными, их вступление в ЕС и НАТО не за горами.";
					}
					else if (GlobalScript.inst.gameState.allcountries[0].isNATO)
					{
						fake_text += "И хотя эти страны теперь номинально являются нейтральными, их вступление в НАТО не за горами.";
					}
					else if (GlobalScript.inst.gameState.allcountries[0].isEU)
					{
						fake_text += "И хотя эти страны теперь номинально являются нейтральными, их вступление в ЕС не за горами.";
					}
				}
			}
			else if (GlobalScript.inst.gameState.empires[1].now_leader == 7)
			{
				int num2 = 0;
				for (int j = 0; j < 100; j++)
				{
					if ((j == 2 || j == 99 || j == 4 || j == 5) && GlobalScript.inst.gameState.allcountries[j].isNATO)
					{
						num2++;
					}
				}
				if (num2 <= 0 && GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(139);
				}
				if (num2 == 4)
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1572], "\n");
				}
				else if (num2 > 0)
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1573], "\n");
				}
				else
				{
					fake_text = string.Format(GlobalScript.inst.new_events_text[1635], "\n");
				}
			}
		}
		else if (number_of_e == 5)
		{
			if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power > 20 && !GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.data[14] == 3)
			{
				achieves.GetComponent<achievements>().Set(15);
			}
			if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.influencePRC >= 400)
			{
				achieves.GetComponent<achievements>().Set(21);
			}
			name.text = "Холодная война";
			if (GlobalScript.inst.gameState.allcountries[7].isNATO)
			{
				fake_text = string.Format(GlobalScript.inst.new_events_text[1575], "\n");
			}
			else if (GlobalScript.inst.gameState.allcountries[1].isASEAN)
			{
				fake_text = string.Format(GlobalScript.inst.new_events_text[1576], "\n", (GlobalScript.inst.gameState.influencePRC + GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power) ? GlobalScript.inst.new_events_text[1577] : GlobalScript.inst.new_events_text[1578]);
			}
			else if (!GlobalScript.inst.gameState.allcountries[51].isNATO && GlobalScript.inst.gameState.allcountries[7].isOVD)
			{
				fake_text = string.Format(GlobalScript.inst.new_events_text[1604], "\n", (GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC && GlobalScript.inst.gameState.empires[1].now_leader != 6) ? GlobalScript.inst.new_events_text[1606] : GlobalScript.inst.new_events_text[1605]);
			}
			else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power + GlobalScript.inst.gameState.empires[1].power <= 80 && GlobalScript.inst.gameState.empires[1].now_leader != 6)
			{
				fake_text = "Времена меняются, Холодная Война уходит в прошлое... Чтобы снова начаться с новой силой. И даже самым непримиримым врагам XX века - Советскому Союзу и Соединённым Штатам пришлось стать заклятыми друзьями, и вновь, как во времена Второй мировой войны, объединиться против общего врага – нового гегемона современного мира, восставшего из пепла и стремительно претендующего на мировое господство Китая. Пытаясь спасти остатки своего влияния, бывшие враги, начинают новый виток гонки вооружений: НАТО и ОВД проводят совместные учения, военные бюджеты СССР и США ежегодно удваиваются, при совместных усилиях американских и советских учёных разрабатывается новые типы ядерного оружия. Похоже, что новая масштабная война становится вопросом времени, но переживёт ли её человечество? ";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(17);
				}
			}
			else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC)
			{
				fake_text = "Холодная война близится к концу и похоже СССР одержит верх в этом долгом противостоянии, являясь самой влиятельной силой в мире. США стремительно теряет влияние на мир, долларовая система разваливается, члены НАТО проводят всё более независимую политику, а сама организация близка к роспуску. Не в последнюю очередь так произошло из-за активного вмешательства КНР в мировую политику и постепенного вытеснения ей американского влияния.";
			}
			else if (GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.influencePRC)
			{
				fake_text = "Последние несколько лет не прошли даром для СССР - его влияние на мир серьёзно расширилось и наверное однажды Холодная война всё-таки закончится его победой - США теряет своё влияние, мировое коммунистическое движение расширяется, а члены НАТО проводят всё более независимую политику. КНР же, несмотря на определённую внешнеполитическую активность так и не смогла выбиться в сверхдержавы, всё ещё оставаясь позади США и СССР, но может рано или поздно это изменится...";
			}
			else if (GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.influencePRC && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.influencePRC)
			{
				fake_text = "Последние несколько лет не прошли даром для США - их влияние на мир серьёзно расширилось и похоже они когда-нибудь выйдут победителями из Холодной войны - СССР теряет влияние в мире, в том числе на соцлагерь, а мировое коммунистическое движение слабеет. КНР же, несмотря на определённую внешнеполитическую активность так и не смогла выбиться в сверхдержавы, всё ещё оставаясь позади США и СССР, но может рано или поздно это изменится...";
			}
			else if (GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.influencePRC)
			{
				fake_text = "Холодная война близится к концу и похоже США одержит верх в этом долгом противостоянии, являясь самой влиятельной силой в мире. СССР теряет влияние на мир, в том числе на соцлагерь, который проводит всё более независимую политику, и на мировое коммунистическое движение. Не в последнюю очередь так произошло из-за активного вмешательства КНР в мировую политику и постепенного вытеснения ей советского влияния.";
			}
			else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[1].power >= GlobalScript.inst.gameState.empires[0].power)
			{
				fake_text = "Некогда имея среди своих сторонников только разрозненных партизан-маоистов, КНР всё же сумела пробиться и стать мировой сверхдержавой, получив большой вес в международных организациях и множество последователей в разных странах.||Противостояние же СССР и США постепенно отходит на второй план, однако похоже, что СССР выйдет из него победителем - США стремительно теряет влияние на мир, долларовая система разваливается, члены НАТО проводят всё более независимую политику, а сама организация близка к роспуску.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(33);
				}
			}
			else if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power && GlobalScript.inst.gameState.empires[0].power >= GlobalScript.inst.gameState.empires[1].power)
			{
				fake_text = "Некогда имея среди своих сторонников только разрозненных партизан-маоистов, КНР всё же сумела пробиться и стать мировой сверхдержавой, получив большой вес в международных организациях и множество последователей в разных странах.||Противостояние же СССР и США постепенно отходит на второй план, однако похоже, что США выйдет из него победителем - СССР теряет всякое влияние на мировое коммунистическое и просто антиамериканское движение, соцлагерь разваливается на глазах и скорее всего будет разделён между КНР и США, причём лучшая часть достанется нам.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(33);
				}
			}
			if (!GlobalScript.inst.gameState.allcountries[0].isEU)
			{
				fake_text += string.Format(GlobalScript.inst.new_events_text[1579], "\n");
			}
			if (GlobalScript.inst.gameState.allcountries[85].isSocEU)
			{
				fake_text += string.Format(GlobalScript.inst.new_events_text[1580], "\n");
			}
			if (GlobalScript.inst.gameState.allcountries[15].Vyshi && GlobalScript.inst.gameState.allcountries[15].isEU && GlobalScript.inst.gameState.allcountries[15].SubGosstroy == 14)
			{
				fake_text += string.Format(GlobalScript.inst.new_events_text[1581], "\n");
			}
			else if (GlobalScript.inst.gameState.allcountries[20].puppetOf == 15)
			{
				fake_text += string.Format(GlobalScript.inst.new_events_text[1582], "\n");
			}
			else if (GlobalScript.inst.gameState.allcountries[20].spec == 1 && GlobalScript.inst.gameState.influencePRC >= 750)
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(154);
				}
				fake_text += string.Format(GlobalScript.inst.new_events_text[1583], "\n");
			}
			else if (GlobalScript.inst.gameState.allcountries[20].spec == 1 && GlobalScript.inst.gameState.influencePRC < 750)
			{
				fake_text += string.Format(GlobalScript.inst.new_events_text[1584], "\n");
			}
			else if (GlobalScript.inst.gameState.allcountries[15].isSEV && (GlobalScript.inst.gameState.empires[1].now_leader != 6 || (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.influencePRC)))
			{
				fake_text += "||80-е стали для Югославии переломным моментом: огромный внешний долг, последствия экономической политики Тито, попытки выправить положение с помощью рыночных реформ могли бы привести к катастрофическим последствиям, однако, благодаря своевременному вмешательству соцлагеря, этого удалось избежать. Югославия приняла решение вступить в СЭВ на правах полноценного члена, что, благодаря кооперации с соцлагерем, льготным ценам и советской помощи, помогло ей оживить экономику и начать постепенно выплачивать свои долги, а помощь от КГБ помогла унять националистов и либералов. Разумеется, это привело к отдалению СФРЮ от Запада и сближению с СССР.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(65);
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[15].Gosstroy == 0)
			{
				fake_text += "||80-е стали для Югославии тяжёлыми временами: огромный внешний долг, последствия экономической политики Тито, попытки выправить положение с помощью рыночных реформ и отсутствие влиятельных покровителей привели к ухудшению экономической ситуации, падению уровня жизни и, как следствие, росту национализма в республиках. Однако Югославия всё же сумела пережить эти испытания, не в последнюю очередь благодаря нашей помощи. Рыночные реформы ограничились продолжением экспериментов с хозрасчётом и децентрализацией, а в начале 90-х и вовсе прекратились. Националистам удалось сыграть на недовольстве народа и попытаться отделиться, однако все попытки сепаратизма были быстро пресечены ЮНА. Попытки США и Запада поддержать националистов привели к ухудшению отношений запада и СФРЮ, которая стала больше ориентироваться на СССР и Китай, хотя и продолжает сохранять свой нейтралитет.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(65);
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[15].Torg && (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power || GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[0].power || (GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.empires[1].power + GlobalScript.inst.gameState.influencePRC > GlobalScript.inst.gameState.empires[0].power)))
			{
				fake_text += "||80-е стали для Югославии тяжёлыми временами: огромный внешний долг, последствия экономической политики Тито, попытки выправить положение с помощью рыночных реформ и отсутствие влиятельных покровителей привели к ухудшению экономической ситуации, падению уровня жизни и, как следствие, росту национализма в республиках. Однако Югославия всё же сумела пережить эти испытания, не в последнюю очередь благодаря нашей помощи. Рыночные реформы не приобрели такого большого размаха, а либеральные политические были быстро саботированы и задавлены военными и консерваторами. Впрочем избежать гражданской войны всё равно не удалось, и Словения с Хорватией всё же смогли получить независимость по её итогам, однако в остальных регионах мятежи были вскоре подавлены ЮНА. Попытки американцев поддерживать сепаратистов привели к ухудшению их отношений с Югославией, которая с каждым годом всё больше налаживает сотрудничество с СССР и КНР. СФРЮ, пусть и уменьшившись в размерах, продолжает существовать.";
			}
			else
			{
				fake_text += "||80-е стали для Югославии тяжёлыми временами: огромный внешний долг, последствия экономической политики Тито, попытки выправить положение с помощью рыночных реформ и отсутствие влиятельных покровителей привели к ухудшению экономической ситуации, падению уровня жизни и, как следствие, росту национализма в республиках. Неспособность правительства стабилизировать ситуацию привела в итоге к взятию власти провоенной фракцией и началу гражданской войны между центральным правительством (которое вскоре оказалось представлено фактически одной Сербией) и хорватскими, словенскими и албанскими националистами. Неизвестно, кто вышел бы из неё победителем, так как точку в ней и в истории Югославии поставили войска НАТО своей операцией против Сербии. Единое балканское государство перестало существовать, а почти все его бывшие республики отныне ориентируются на запад и США.";
			}
		}
		else if (number_of_e == 6)
		{
			name.text = "Сладкая жизнь";
			if (GlobalScript.inst.gameState.data[5] <= 400)
			{
				fake_text = "Ваше правление не принесло Китаю особых улучшений в жизни простых его граждан - наш уровень жизни по-прежнему на уровне начала 70-х. Периодически случаются продовольственные кризисы, жителям деревень зачастую незнакомы удобства современной жизни, да и в городах, несмотря на большой разрыв с деревней, положение не самое лучшее - простой народ живёт в плохо оборудованных домах, нередко в коммуналках и трущобах, населению редко доступны товары зажиточных классов, а о какой-то роскоши могут говорить только высокие государственные работники и руководящие кадры предприятий.";
			}
			else if (GlobalScript.inst.gameState.data[5] <= 700)
			{
				fake_text = "Ваше правление ознаменовалось подъёмом уровня жизни китайских граждан - были наконец решены проблемы с продовольственным обеспечением, большей части населения стали повсеместно доступны товары зажиточного класса, а жилищные условия в городах для многих китайцев значительно улучшились, хотя многим обычным рабочим всё ещё приходится ютиться в тесных коммуналках и трущобах. В деревнях всё обстоит похуже, однако уже идёт активное развитие инфрастуктуры, современная застройка деревень и подведение к ним современных коммуникаций, ожидается, что в скором времени мы достигнем японского уровня жизни. Народ всегда будет помнить ваш вклад в его светлое будущее.";
			}
			else
			{
				fake_text = "Ваше правление ознаменовалось колоссальным подъёмом уровня жизни китайских граждан - были не просто решены проблемы продовольственного обеспечения, но и достигнут уровень, когда практически всем стали доступны многие товары богатого и зажиточного класса и всё больше людей обзаводятся и предметами роскоши. Полным ходом идёт преодоление разрыва города и деревни - была проведена повсеместная электрификация, проведены современные коммуникации, идёт активная застройка деревень современными домами. Теперь у каждого честного труженника есть достойное жилище и питание, Китай уже опередил все страны Азии, включая Японию, по уровню жизни, а для народа вы навсегда останетесь любимым правителем, подарившим Китаю развитие и новую жизнь.";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(47);
				}
			}
		}
		else if (number_of_e == 7)
		{
			if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[14].oar && GlobalScript.inst.gameState.allcountries[35].oar && GlobalScript.inst.gameState.allcountries[13].oar && GlobalScript.inst.gameState.data[85] == 3)
			{
				achieves.GetComponent<achievements>().Set(13);
			}
			name.text = "Мировая ситуация";
			if (GlobalScript.inst.gameState.allcountries[10].numberOfSpecialEnding < 0)
			{
				if (GlobalScript.inst.gameState.data[83] <= 0 && !GlobalScript.inst.gameState.allcountries[46].Vyshi && GlobalScript.inst.gameState.allcountries[46].Gosstroy == 2)
				{
					fake_text = "После долгожданного мирного объединения Кореи и вывода американских войск начался долгий и тернистый путь интеграции. Объединить социалистическую самодостаточную КНДР с основанной на иностранном капитале РК оказалось не так то просто, что породило систему множества сдержек и противовесов. Другой проблемой является внешняя политика, где \"южане\" выступают за сохранение дружеских контактов с Западом, а \"северяне\" - за независимую внешнюю политику и становление новой силой в регионе. Однако радующихся объединению и подлинной независимости рядовых корейцев нюансы политики сейчас мало волнуют.";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(50);
					}
				}
				else if (GlobalScript.inst.gameState.data[83] <= 0 && (!GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.empires[1].now_leader == 6) && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 1)
				{
					fake_text = "На Корейском полуострове ничего особо не изменилось - противостояние двух Корей продолжается. И именно оно привело в начале 2000-х к тому, что для защиты от американской агрессии в КНДР было разработано ядерное оружие. КНДР продолжает проводить нейтральную внешнюю политику, поддерживая хорошие отношения и с Пекином и с Москвой, но не присоединяясь ни к одному лагерю.";
				}
				else if (GlobalScript.inst.gameState.data[83] <= 0 && GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 1)
				{
					fake_text = "На Корейском полуострове ничего особо не изменилось - противостояние двух Корей продолжается. Для получения преимущества в нём в 90-х, видя, что раскол между КНР и СССР окончательно преодолён, КНДР вступила в СЭВ, а вскоре и в ОВД. Это обеспечило ей экономический подъём и надёжную защиту от американской агрессии. ";
				}
				else if (GlobalScript.inst.gameState.data[83] <= 0 && (!GlobalScript.inst.gameState.allcountries[1].isSEV || GlobalScript.inst.gameState.empires[1].now_leader == 6) && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 2)
				{
					fake_text = "На Корейском полуострове ничего особо не изменилось - противостояние двух Корей продолжается, хотя и в более мягкой форме. В КНДР тем временем были проведены масштабные реформы, предполагающие децентрализацию планирования, гражданскую либерализацию, а скоро планируется открытие СЭЗ. Несмотря на то, что эти действия улучшили отношения КНДР с США и проамериканскими соседями, в начале 2000-х для защиты от американской агрессии в КНДР было разработано ядерное оружие. КНДР продолжает проводить нейтральную внешнюю политику, поддерживая хорошие отношения и с Китаем и с Москвой, но не присоединяясь ни к одному лагерю.";
				}
				else if (GlobalScript.inst.gameState.data[83] <= 0 && GlobalScript.inst.gameState.allcountries[1].isSEV && GlobalScript.inst.gameState.empires[1].now_leader != 6 && GlobalScript.inst.gameState.allcountries[10].Gosstroy == 2)
				{
					fake_text = "На Корейском полуострове ничего особо не изменилось - противостояние двух Корей продолжается, хотя и в более мягкой форме. В КНДР тем временем были проведены масштабные реформы, предполагающие децентрализацию планирования, гражданскую либерализацию, а скоро планируется открытие СЭЗ. Несмотря на то, что эти действия улучшили отношения КНДР с США и проамериканскими соседями, в 90-х, видя, что раскол между КНР и СССР окончательно преодолён, КНДР вступила в СЭВ, а вскоре и в ОВД. Это обеспечило ей экономический подъём и надёжную защиту от американской агрессии. ";
				}
				else if (GlobalScript.inst.gameState.data[83] == 1)
				{
					fake_text = "После успешного объединения Кореи под знаменем КНДР и изгнания американских захватчиков наступило долгожданное возрождение и развитие Кореи, а уже в 90-х страна объявила о разработке собственного ядерного оружия. ";
					if (GlobalScript.inst.gameState.empires[1].now_leader == 6)
					{
						fake_text += " КНДР, защищаемая ядерной дубиной, довольно быстро стала проводить независимую внешнюю политику. Корея активно пытается стать новой независимой силой в регионе и в мировой политике и, кажется, со временем ей это удастся.";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(16);
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[10].econ)
					{
						fake_text += " Вскоре КНДР вступила в наш альянс, что ещё больше подстегнуло экономику страны. В остальном же КНДР старается проводить независимую политику, отстаивая собственные интересы.";
					}
					else
					{
						fake_text += " Вскоре КНДР вступила в СЭВ, что ещё больше подстегнуло экономику страны. В остальном же КНДР старается проводить независимую политику, отстаивая собственные интересы.";
					}
				}
				else if (GlobalScript.inst.gameState.data[83] == 2)
				{
					fake_text = "После поражения КНДР и объединения Кореи под знаменем Республики США первым делом ввели дополнительный контингент на присоединённые территории для борьбы с растущим партизанским движением. Партизаны контролируют многие области на севере и изматывают американцев постоянными атаками. Кажется, долгожданное возрождение Кореи будет ещё очень нескоро. ";
					if (GlobalScript.inst.gameState.empires[1].now_leader != 6 || GlobalScript.inst.gameState.data[14] < 3)
					{
						fake_text += " А вскоре \"для защиты мира и американских интересов в регионе\" на полуостров было введено американское ядерное оружие, что вызвало недовольство многих стран.";
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							achieves.GetComponent<achievements>().Set(51);
						}
					}
				}
			}
			else
			{
				fake_text = "Ничего примечательного в корейском вопросе не произошло";
			}
			if (GlobalScript.inst.gameState.allcountries[37].SubGosstroy == 17 && GlobalScript.inst.gameState.allcountries[37].okb)
			{
				fake_text += "|При прямой поддержке Китая в Союзном Государстве Палестины и Израиля была поставлена власть состоящая из традиционалистских аграристов, отвергают капиталистическую систему экономики. Но китайским властям этого было недостаточно, их не устраивал слишком медленный темп реформ. Поэтому был продавлен вариант создания Батальонов Смерти, куда стали набирать бедноту, и масштабной чистки Палестино-Израильской армии официально \"для защиты от реакционных сил, засевших в армии\".|Год за годом постепенно эта организация разрасталась год за годом замещая собой армию, а возглавляли её китайские советники и завербованные китайскими спецслужбами лица. И когда организация стала достаточно сильной по мнению иностранных кураторов, то настал час реализации плана: в одну ночь Батальоны Смерти захватили все правительстве и административные здания и жилые центры политической власти всех городов и регионов страны и казнили всех на месте. Затем арестовали и низложили остатки армии. И наконец-то подожгли все города и селения подорвав всё что только можно. Взволнованные граждане выбежали из своих домов, где их уже встречали отряды Батальона Смерти и уводили в специальные палаточные лагеря. Там всё население страны было разделено на несколько сотен племён, возглавляемых руководителями Батальонов Смерти. А каждой семье выдали по лошади, повозке и стопок твёрдой тёплой ткани. Так в Палестине и Израиле наступил период возвращения к истокам - к кочевой племенной жизни. А оставшиеся куски цивилизации сохранились только на территориях добычи воды и незначительных поселений рядом для поддержки вододобычи под контролем Батальонов Смерти. Деньги в стране также были отменены, им на смену вернулся бартер.|<color=red>\"Дети мои, вы наконец-то нашли Землю Обетованную, завещанную нам богом\"</color>.";
				achieves.GetComponent<achievements>().Set(160);
			}
			else if (GlobalScript.inst.gameState.data[85] == 0)
			{
				fake_text += "|Конфликт между палестинцами и Израилем так и оставался нерешённым, пока восстание палестинцев в 1987-1993 годах, известное как Первая палестинская интифада и жёстко подавленное Израилем, вынудило стороны на переговоры. По итогам соглашений в Осло была создана Палестинская Национальная Администрация в качестве автономии палестинских территорий, а ООП прекратила террористические атаки. Однако нежелание Израиля идти на уступки и продолжение терроризма со стороны отдельных организаций привели к срыву дальнейшего мирного процесса и ко Второй палестинской интифаде в 2000-2005 годах.";
			}
			else if (GlobalScript.inst.gameState.data[85] == 1)
			{
				fake_text += "|Наше вмешательство и принуждение сторон к переговорам положило начало урегулированию палестинско-израильского конфликта. По итогам соглашений в Пекине была создана Палестинская Национальная Администрация в качестве автономии палестинских территорий, а ООП прекратила террористические атаки. Однако нежелание Израиля идти на уступки и продолжение терроризма со стороны отдельных организаций привели к срыву дальнейшего мирного процесса и к восстанию палестинцев в 2000-2005 годах, изветсному как Палестинская интифада.";
			}
			else if (GlobalScript.inst.gameState.data[85] == 2)
			{
				fake_text += "|Наше вмешательство и принуждение сторон к переговорам положило начало урегулированию палестинско-израильского конфликта. По итогам соглашений в Пекине было начато создание Государства Палестины на части израильских территорий. Передача контроля над этими территориями палестинской администрации сопровождалась множеством эксцессов, проблемой по-прежнему является статус Восточного Иерусалима, создание коридора между Сектором Газа и Западным берегом реки Иордан и продолжающиеся атаки террористических организаций. Отношения между двумя государствами по-прежнему натянутые, однако уже есть определённый прогресс в достижении долгожданного мира.";
			}
			else if (GlobalScript.inst.gameState.data[85] == 3)
			{
				fake_text += "|Наше вмешательство и принуждение сторон к переговорам положило начало урегулированию палестинско-израильского конфликта. По итогам соглашений в Пекине было решено создать Союзное Государство Палестины и Израиля с двумя государственными языками и развитым местным самоуправлением. Предметом острых споров стали границы субъектов государства и статус Иерусалима, проблемы также доставляют некоторые террористические группировки, несогласные с таким исходом. Другой проблемой является внешняя политика СГПИ, которая вызыает жаркие споры в новообразованных государственных органах. Отношения между народами в новом государстве ещё долго будут натянутыми, однако международный контроль и пропаганда равенства и братства рано или поздно положат конец этому конфликту.";
			}
			else
			{
				fake_text = "Ничего примечательного в арабо-израильском конфликте не произошло";
			}
			if (GlobalScript.inst.gameState.allcountries[30].parts[0])
			{
				fake_text += string.Format(GlobalScript.inst.new_events_text[1601], "\n");
			}
			else if (GlobalScript.inst.gameState.OAR && GlobalScript.inst.gameState.allcountries[14].oar && GlobalScript.inst.gameState.allcountries[35].oar && GlobalScript.inst.gameState.allcountries[13].oar)
			{
				fake_text += "|Долгожданное объединение главных арабских государств в Объединённую Арабскую Республику, основанную на принципах арабского социализма, наконец состоялось. Объединить государства с похожими системами в одно оказалось не особо сложно, и хотя борьба между сторонниками централизации и местными элитами периодически подтачивает стабильность страны, интеграция в целом прошла успешно. Объединив экономику нескольких стран и создав единую армию, ОАР стала сильнейшей страной на Ближнем Востоке и весомым членом мирового сообщества. ОАР старается поддерживать дружбу с социалистическими странами, а её растущие аппетиты расшатывают и без того хрупкий мир в регионе, Израиль укрепляет границы, а некоторые поговаривают о скором вторжении ОАР в Саудовскую Аравию и Судан.";
			}
			else if (GlobalScript.inst.gameState.OAR)
			{
				fake_text += "|Первоначальное ликование от создания единого арабского государства сменилось осознанием кучи проблем - в ОАР вступили не все арабские страны, а вступившие начали активно бороться за власть в новом государстве. Борьба сторонников централизации и местных элит привела к куче законов об автономиях и особых статусах, что не лучшим образом сказалось на эффективности управления. ОАР продолжает существовать, однако её члены проводят всё более независимую политику, а объединение с каждым годом становится больше номинальным.";
			}
			else if (GlobalScript.inst.gameState.data[85] == 2)
			{
				fake_text += "|Арабские государства продолжают оставаться разрозненными, а про планы объединения уже никто не вспоминает.";
			}
			else
			{
				fake_text = "Ничего примечательного в арабском вопросе не произошло.";
			}
		}
		text_t.text = Text(fake_text, 91);
	}

	private void BadEnding()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (GlobalScript.inst.gameState.data[35] == 1)
			{
				name.text = " 暴 动";
				fake_text = " 你 的 政 策 使 中 国 人 民 越 来 越 愤 怒 。 当 你 试 图 以 一 切 方 式 平 息 日 益 增 长 的 抗 议 活 动 时 ， 你 失 败 了 ， 一 场 公 开 起 义 开 始 了 ， 很 快 就 得 到 了 军 队 和 一 些 党 员 的 支 持 。 在 法 庭 上 逮 捕 和 审 判 你 时 ， 党 内 高 层 成 员 和 将 军 已 经 宣 布 成 立 一 个 临 时 政 府 。 中 国 的 未 来 如 此 晦 暗 不 明 … …";
			}
			else if (GlobalScript.inst.gameState.data[35] == 2)
			{
				name.text = " 党 内 政 变";
				fake_text = " 你 的 行 为 使 党 越 来 越 愤 怒 。 他 们 厌 倦 了 你 ， 党 内 的 元 老 组 织 了 一 次 会 议 ， 在 那 里 你 受 到 批 判 ， 然 后 党 内 投 票 赞 成 你 提 前 退 休 。 现 在 你 只 是 一 个 领 取 养 老 金 的 人 ， 没 有 人 在 意 你 ， 而 你 以 前 的 职 位 被 一 个 各 派 妥 协 的 、 尝 试 与 竞 争 对 手 周 旋 的 候 选 人 占 据 。";
			}
			else if (GlobalScript.inst.gameState.data[35] == 3)
			{
				name.text = " 核 战";
				if (GlobalScript.inst.gameState.resultOfEvents[544] == 2 && GlobalScript.inst.gameState.resultOfEvents[349] == 0 && GlobalScript.inst.gameState.completedDecisions[22] && GlobalScript.inst.gameState.resultOfEvents[520] == 1 && GlobalScript.inst.gameState.data[22] >= 2000 && GlobalScript.inst.gameState.empires[0].power <= 100 && GlobalScript.inst.gameState.empires[1].power <= 100 && GlobalScript.inst.gameState.science[29])
				{
					if (GlobalScript.inst.gameState.modifies[40].active)
					{
						name.text = " 美 丽 新 世 界";
						fake_text = " “ 我 无 法 预 测 第 三 次 世 界 大 战 用 什 么 武 器 ， 但 我 可 以 肯 定 第 四 次 世 界 大 战 用 的 是 石 头 和 木 棍 ” 这 是 某 位 被 遗 忘 在 历 史 角 落 的 科 学 家 的 预 测 ， 而 他 预 测 错 了 — — 第 三 次 世 界 大 战 的 胜 者 手 中 握 着 的 便 已 经 是 石 头 木 棍 ， 而 第 四 次 世 界 大 战 也 不 会 来 了 。 和 从 前 的 比 基 尼 岛 一 样 ， 核 尘 埃 笼 罩 下 的 世 界 中 仍 有 生 物 能 够 存 活 ， 其 中 也 包 括 人 类 。 而 与 从 前 不 同 的 是 ， 现 在 活 下 来 的 每 个 个 体 都 是 社 会 主 义 下 的 “ 新 人 ” ， 每 个 人 都 将 与 自 然 融 为 一 体 ， 每 个 人 都 要 为 了 伟 大 的 新 世 界 的 建 设 去 奋 斗 ， 每 个 人 都 将 享 受 着 平 等 的 一 切 ， 这 将 是 一 个 不 再 有 阶 级 冲 突 与 剥 削 压 迫 的 世 界 ， 一 个 比 任 何 时 候 都 接 近 人 的 本 质 的 世 界 。 来 吧 同 志 们 ， 让 我 们 来 生 火 … …";
					}
					else
					{
						name.text = " 早 打 大 打 ， 打 核 战 争 ， 在 全 世 界 打 … …";
						fake_text = " 你 已 经 找 到 了 宝 贵 的 红 色 按 钮 ， 并 发 射 了 导 弹 。 你 的 打 击 破 坏 了 美 苏 脆 弱 的 战 略 平 衡 。 在 你 之 后 ， 他 们 也 进 行 了 核 交 换 。 然 而 ， 攻 击 目 标 为 中 国 和 中 国 盟 友 的 核 导 弹 和 战 略 轰 炸 机 等 却 被 我 们 早 已 完 善 的 各 级 导 弹 防 御 系 统 等 防 空 系 统 给 拦 截 了 下 来 ， 而 我 们 早 已 扩 建 的 人 防 工 事 系 统 也 让 我 们 的 人 民 幸 存 了 下 来 。 现 在 ， 除 了 我 们 ， 大 多 数 城 市 都 被 摧 毁 了 ， 半 个 地 球 也 被 污 染 了 ， 这 是 你 想 要 的 打 倒 了 美 帝 苏 修 的 新 世 界 吗 ？";
					}
				}
				else
				{
					fake_text = " 你 已 经 找 到 了 宝 贵 的 红 色 按 钮 ， 并 发 射 了 导 弹 。 你 的 打 击 破 坏 了 美 苏 脆 弱 的 战 略 平 衡 。 在 你 之 后 ， 他 们 也 进 行 了 核 交 换 。 大 多 数 城 市 都 被 摧 毁 了 ， 地 球 被 污 染 了 ， 大 部 分 幸 存 者 都 躲 到 掩 体 和 避 难 所 内 。";
				}
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(18);
				}
			}
			else if (GlobalScript.inst.gameState.data[35] == 4)
			{
				name.text = " 种 族 灭 绝";
				fake_text = " 在 你 的 领 导 下 ， 曾 是 世 界 上 第 一 人 口 大 国 的 中 国 ， 人 口 急 剧 减 少 。 这 是 不 可 忽 视 的 ， 人 们 越 发 指 责 你 犯 下 了 种 族 灭 绝 的 罪 行 ， 最 终 党 受 够 了 ， 逮 捕 了 你 ， 并 把 你 送 上 法 庭 。";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(49);
				}
			}
			else if (GlobalScript.inst.gameState.data[35] == 6)
			{
				name.text = " 机 器 总 归 要 人 管";
				fake_text = string.Concat(new string[4]
				{
					GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1],
					" ",
					GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2],
					" 同 志 决 定 避 免 流 血 事 件 ， 并 自 愿 以 健 康 原 因 辞 职 。 不 那 么 激 进 的 新 人 取 代 了 旧 领 导 人 。 国 内 的 审 查 强 化 了 ， 任 何 偏 离 总 路 线 的 行 为 都 遭 到 严 厉 镇 压 ，IECS 仅 用 于 生 产 和 军 队 的 自 动 化 ， 现 在 ， 每 台 机 器 都 是 由 人 在 操 控 ， 因 此 政 府 官 僚 的 影 响 比 以 往 更 加 强 大 了 。 尽 管 如 此 ， 中 国 的 经 济 继 续 发 展 ， 但 每 年 增 长 率 都 在 下 跌 ， 终 有 一 天 中 国 的 经 济 问 题 会 浮 出 水 面 。 中 国 的 未 来 仍 处 于 重 重 迷 雾 之 中 。"
				});
			}
			else if (GlobalScript.inst.gameState.data[35] == 7)
			{
				name.text = GlobalScript.inst.new_events_text[533];
				fake_text = GlobalScript.inst.new_events_text[534];
			}
			else if (GlobalScript.inst.gameState.data[35] == 8)
			{
				name.text = " 未 知 世 界 的 故 事";
				fake_text = " 毛 泽 东 复 活 以 及 政 府 密 谋 暗 杀 失 败 的 消 息 被 公 布 在 报 纸 上 。 这 成 为 了 引 爆 民 众 不 满 的 导 火 索 。 全 国 各 地 大 批 愤 怒 的 群 众 结 社 加 入 “ 毛 泽 东 ” 的 阵 营 ， 并 在 各 大 城 市 游 行 示 威 ， 他 们 高 呼 ： “ 谁 反 对 毛 主 席 ， 谁 就 是 在 反 对 新 中 国 ， 反 对 人 民 ！ ” “ 坚 决 打 倒 反 动 派 ！ ” “ 毛 泽 东 ” 进 行 了 一 篇 煽 动 性 极 强 演 讲 ， 赢 得 大 多 数 人 的 支 持 。 而 在 一 次 群 众 与 政 府 无 意 中 的 流 血 冲 突 后 ， 一 场 全 国 性 的 拥 护 毛 泽 东 、 反 对 修 正 派 的 热 潮 也 被 引 爆 了 。 群 众 运 动 转 为 武 装 斗 争 ， 并 在 “ 毛 泽 东 ” 的 指 挥 及 部 分 军 队 的 支 持 下 夺 得 大 部 分 政 权 。 新 的 中 国 共 产 党 建 立 了 ， 中 华 人 民 共 和 国 国 号 也 加 入 “ 革 命 ” 二 字 ， “ 毛 泽 东 ” 再 度 成 为 国 家 领 袖 。 新 的 政 治 体 系 正 在 建 立 起 来 ， 而 你 也 被 作 为 反 动 派 头 目 与 前 政 府 高 官 一 同 被 枪 决 、 铭 刻 在 历 史 的 耻 辱 柱 上 。 ";
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(56);
				}
			}
			else if (GlobalScript.inst.gameState.data[35] == 9)
			{
				name.text = " 万 里 涛 涛 ， 江 水 永 不 休";
				fake_text = " 体 制 外 民 主 人 士 和 自 由 派 党 员 共 同 推 进 了 一 场 —— 也 许 是 在 中 国 历 史 上 最 为 轰 轰 烈 烈 的 —— 自 由 主 义 大 变 革 ， 并 相 当 想 当 然 地 认 为 这 场 全 方 位 的 破 冰 行 动 将 带 来 “ 整 个 国 家 的 新 生 ” 。 然 而 令 人 大 跌 眼 镜 的 是 ， 这 场 运 动 滋 养 的 不 是 鲜 花 ， 而 是 毒 草 。 贸 然 而 激 进 的 体 制 改 动 使 得 政 府 人 员 安 排 调 动 变 得 极 其 混 乱 ， 实 际 上 让 政 府 陷 入 了 瘫 痪 状 态 。 而 毫 无 底 线 并 缺 乏 兜 底 机 制 的 私 有 化 引 发 了 大 规 模 失 业 潮 和 公 共 服 务 体 系 瓦 解 ， 国 民 经 济 的 最 后 一 根 弦 也 随 之 崩 断 。 在 如 此 危 局 下 ， 政 府 仍 然 坚 持 “ 减 少 干 预 ， 放 任 自 由 ” 的 执 政 原 则 ， 拒 绝 对 当 前 情 况 负 责 并 保 持 既 定 预 算 计 划 ， 这 最 终 使 得 当 政 自 由 派 被 视 作 一 个 无 能 且 不 作 为 的 执 政 集 团 。 饱 受 内 外 批 评 的 政 府 最 终 败 光 了 自 毛 泽 东 时 代 以 来 的 一 切 公 信 力 ， 布 尔 什 维 克 式 的 党 政 结 构 事 实 上 已 经 解 体 ， 当 下 整 个 中 国 更 近 似 晚 清 那 种 “ 政 令 不 出 首 都 ” 的 弱 中 央 模 式 ， 甚 至 有 人 说 我 党 我 国 已 然 重 蹈 覆 辙 了 东 汉 末 年 和 东 晋 世 家 制 的 局 面 。||由 于 基 层 上 统 领 部 门 的 地 方 党 政 机 构 崩 溃 ， 行 政 管 理 、 执 法 机 构 几 乎 完 全 失 灵 。 无 助 的 人 们 在 失 序 的 社 会 中 最 终 寻 求 了 一 种 历 史 悠 久 但 在 毛 泽 东 时 期 被 全 面 禁 止 的 社 会 组 织 — — 秘 密 结 社 。 或 者 说 ， 黑 社 会 。 这 种 死 灰 复 燃 的 暴 力 团 伙 立 即 代 替 了 基 层 行 政 机 关 ， 并 实 际 上 承 担 起 当 地 的 行 政 与 治 安 责 任 （ 当 然 ， 代 价 是 相 应 的 “ 保 护 费 ” ） 老 牌 的 华 人 黑 帮 ， 如 洪 门 （ 致 公 党 ） 、 青 帮 （ 安 清 会 ） 以 及 三 合 会 捷 足 先 登 ， 为 自 己 一 方 的 势 力 打 下 了 广 阔 的 江 山 。 新 兴 势 力 也 层 出 不 穷 ， 试 图 在 大 帮 派 的 争 斗 中 渔 翁 得 利 ， 撕 下 属 于 自 己 的 一 块 肉 。 形 成 一 定 规 模 的 大 型 结 社 相 当 精 明 地 发 展 表 里 两 面 ， 推 出 属 于 自 己 的 合 法 化 组 织 并 参 与 国 家 政 治 ， 从 议 会 到 政 府 坐 满 了 这 些 戴 着 沾 血 的 黑 手 套 、 文 质 彬 彬 的 黑 手 党 们 ， 国 际 社 会 也 把 我 们 看 作 一 个 东 方 墨 西 哥 。 看 来 ， 终 结 妓 院 、 赌 场 与 毒 品 的 时 代 已 经 随 他 老 人 家 而 远 去 … …||<color=#2F4F4F>雄 关 漫 道 真 如 铁 ， 而 今 迈 步 ， 从 头 越 … …</color> ";
			}
			else if (GlobalScript.inst.gameState.data[35] == 10)
			{
				if (GlobalScript.inst.gameState.leader.name_1 == 2 && GlobalScript.inst.gameState.leader.name_2 == 2)
				{
					if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy != 19)
					{
						name.text = " 这 里 可 不 如 交 城 山 啊 ！";
						fake_text = "堂 堂 中 国 领 导 人 最 终 在 意 想 不 到 的 地 方 翻 了 船 ： 并 不 满 足 于 享 受 努 美 阿 如 诗 如 画 的 美 景 的 您 决 心 找 找 刺 激 ， 而 这 便 招 致 了 天 降 横 祸 ： 也 就 在 您 决 定 接 受 当 地 大 使 建 议 好 好 耍 一 把 山 区 打 猎 后 ， 事 情 就 一 发 不 可 收 拾 。 您 推 脱 了 工 作 人 员 检 查 枪 支 弹 药 的 好 意 ， 准 备 亲 自 上 手 ， 亲 自 指 挥 。 可 抢 着 出 风 头 的 您 显 然 忘 记 了 持 枪 的 第 一 要 务 ： 金 手 指 原 则 。 而 当 地 土 枪 也 不 会 给 你 多 少 试 错 机 会 — — 铁 屑 和 木 块 很 快 便 让 你 成 了 独 眼 龙 ， 紧 接 着 便 是 以 失 血 过 多 的 方 式 让 你 归 西 。 您 也 就 成 为 了 有 史 以 来 首 位 在 任 内 非 正 常 死 亡 的 领 导 人 。 中 国 的 故 事 仍 将 继 续 下 去 ， 但 至 少 和 您 已 没 多 大 关 系 了 。";
					}
					else
					{
						name.text = " 久 经 考 验 的 … …";
						fake_text = "堂 堂 中 国 领 导 人 最 终 在 意 想 不 到 的 地 方 翻 了 船 ： 并 不 满 足 于 享 受 努 美 阿 如 诗 如 画 的 美 景 的 您 决 心 找 找 刺 激 ， 而 这 便 招 致 了 天 降 横 祸 ： 也 就 在 您 决 定 接 受 当 地 大 使 建 议 好 好 耍 一 把 山 区 打 猎 后 ， 事 情 就 一 发 不 可 收 拾 。 您 扛 着 枪 与 全 副 武 装 的 队 伍 意 外 闯 入 了 当 地 原 住 民 部 落 ， 这 只 会 让 世 纪 性 会 晤 变 成 新 一 轮 殖 民 战 争 。 您 的 保 镖 和 土 著 打 得 不 可 开 交 ， 而 您 也 在 混 战 内 被 标 枪 扎 中 大 腿 — — 紧 接 着 便 是 以 失 血 过 多 的 方 式 让 你 归 西 。 中 国 的 故 事 仍 将 继 续 下 去 ， 不 过 她 和 她 的 子 民 们 显 然 还 没 有 做 好 应 付 天 灾 的 准 备 ： 国 内 宣 传 已 将 你 塑 造 为 久 经 考 验 的 斗 士 ， 在 推 进 南 太 平 洋 革 命 进 步 事 业 时 不 幸 落 入 反 动 派 圈 套 ， 寡 不 敌 众 而 死 于 非 命 。 卡 纳 克 人 民 共 和 国 的 元 首 也 亲 自 前 往 我 国 赔 罪 ， 并 愿 意 引 渡 当 地 土 著 首 领 。 看 来 伟 大 领 袖 的 一 生 确 实 轰 轰 烈 烈 ， 即 便 身 后 也 波 折 不 断 … …";
					}
				}
				else if (GlobalScript.inst.gameState.leader.name_1 == 3 && GlobalScript.inst.gameState.leader.name_2 == 3)
				{
					name.text = " 随 风 而 去";
					fake_text = "堂 堂 中 国 领 导 人 最 终 在 意 想 不 到 的 地 方 翻 了 船 ： 并 不 满 足 于 享 受 努 美 阿 如 诗 如 画 的 美 景 的 您 决 心 找 找 刺 激 ， 而 这 便 招 致 了 天 降 横 祸 ： 也 就 在 您 决 定 接 受 当 地 大 使 建 议 ， 好 好 耍 一 把 冲 浪 后 ， 事 情 就 一 发 不 可 收 拾 。 曾 小 心 驶 得 万 年 船 的 您 竟 在 一 处 小 小 的 漩 涡 中 翻 了 冲 浪 板 ， 并 在 国 安 局 特 工 惊 恐 的 目 光 中 彻 底 消 失 ， 以 至 毫 无 痕 迹 。 对 您 的 搜 救 工 作 在 持 续 数 天 后 仍 在 继 续 — — 至 少 得 捞 出 些 东 西 给 人 交 代 。 您 也 就 成 为 了 有 史 以 来 首 位 在 任 内 离 奇 失 踪 的 领 导 人 ， 并 可 同 澳 大 利 亚 的 哈 罗 德 · 霍 尔 特 总 理 齐 名 … … 中 国 的 故 事 仍 将 继 续 下 去 ， 但 至 少 和 您 已 没 多 大 关 系 了 。";
				}
				else if (GlobalScript.inst.gameState.leader.name_1 == 13 && GlobalScript.inst.gameState.leader.name_2 == 13)
				{
					name.text = " 矮 人 与 海";
					fake_text = "堂 堂 中 国 领 导 人 最 终 在 意 想 不 到 的 地 方 翻 了 船 ： 并 不 满 足 于 享 受 努 美 阿 如 诗 如 画 的 美 景 的 您 决 心 找 找 刺 激 ， 而 这 便 招 致 了 天 降 横 祸 ： 也 就 在 您 决 定 接 受 当 地 大 使 建 议 ， 好 好 耍 一 把 钓 鱼 后 ， 事 情 就 一 发 不 可 收 拾 。 曾 机 关 算 尽 ， 精 明 无 比 的 的 您 竟 在 小 小 的 钓 竿 上 翻 了 船 ： 大 马 林 鱼 用 角 力 证 明 了 自 己 才 是 博 弈 的 主 人 ， 老 迈 的 您 没 多 久 便 耗 竭 气 力 跌 倒 在 地 ， 接 着 便 是 没 入 水 中 无 影 无 踪 ， 以 至 毫 无 痕 迹 。 对 您 的 搜 救 工 作 在 持 续 数 天 后 仍 在 继 续 — — 至 少 得 捞 出 些 东 西 给 人 交 代 。 您 也 就 成 为 了 有 史 以 来 首 位 在 任 内 离 奇 失 踪 的 领 导 人 ， 并 可 同 澳 大 利 亚 的 哈 罗 德 · 霍 尔 特 总 理 齐 名 … … 中 国 的 故 事 仍 将 继 续 下 去 ， 但 至 少 和 您 已 没 多 大 关 系 了 。";
				}
				else if (GlobalScript.inst.gameState.leader.name_1 == 16 && GlobalScript.inst.gameState.leader.name_2 == 16)
				{
					name.text = " 腾 笼 换 鸟";
					fake_text = "堂 堂 中 国 领 导 人 最 终 在 意 想 不 到 的 地 方 翻 了 船 ： 并 不 满 足 于 享 受 努 美 阿 如 诗 如 画 的 美 景 的 您 决 心 找 找 刺 激 ， 而 这 便 招 致 了 天 降 横 祸 ： 也 就 在 您 决 定 接 受 当 地 大 使 的 建 议 ， 好 好 在 观 光 游 轮 上 观 赏 自 然 风 光 时 ， 事 情 就 一 发 不 可 收 拾 。 曾 权 衡 利 弊 ， 左 右 逢 源 的 您 竟 在 一 只 小 小 的 海 鸥 上 翻 了 船 : 一 只 狂 妄 的 海 鸥 擅 自 要 求 您 分 享 手 中 的 甜 点 ， 但 您 显 然 讨 厌 离 开 笼 子 束 缚 的 鸟 儿 ， 在 这 场 激 烈 的 甜 点 争 夺 战 中 ， 您 完 成 了 从 旅 费 到 甜 点 的 惊 险 一 跃 ， 接 着 便 是 没 入 水 中 无 影 无 踪 ， 以 至 毫 无 痕 迹 。 对 您 的 搜 救 工 作 在 持 续 数 天 后 仍 在 继 续 — — 至 少 得 捞 出 些 东 西 给 人 交 代 。 您 也 就 成 为 了 有 史 以 来 首 位 在 任 内 离 奇 失 踪 的 领 导 人 ， 并 可 同 澳 大 利 亚 的 哈 罗 德 · 霍 尔 特 总 理 齐 名 … … 中 国 的 故 事 仍 将 继 续 下 去 ， 但 至 少 和 您 已 没 多 大 关 系 了 。";
				}
				else if (GlobalScript.inst.gameState.leader.name_1 == 14 && GlobalScript.inst.gameState.leader.name_2 == 14)
				{
					name.text = " 任 意 球";
					fake_text = "堂 堂 中 国 领 导 人 最 终 在 意 想 不 到 的 地 方 翻 了 船 ： 并 不 满 足 于 享 受 努 美 阿 如 诗 如 画 的 美 景 的 您 决 心 好 好 享 受 高 尔 夫 瘾 ， 而 这 便 招 致 了 天 降 横 祸 ： 也 就 在 您 决 定 接 受 当 地 大 使 建 议 ， 去 当 地 的 新 建 球 场 好 好 耍 一 把 后 ， 事 情 就 一 发 不 可 收 拾 。 您 在 整 理 某 个 飞 到 丛 林 内 的 球 时 得 到 了 当 地 蚊 子 的 热 烈 款 待 ， 没 多 久 便 在 多 了 几 个 脓 包 的 同 时 染 上 了 热 带 疾 病 。 就 在 假 期 结 束 的 一 个 星 期 后 ， 您 便 被 抬 到 了 重 症 监 护 室 内 接 受 治 疗 。 虽 说 全 国 最 优 秀 的 医 生 已 为 治 疗 您 身 上 的 疟 疾 加 班 加 点 ， 可 终 究 还 是 没 法 从 高 烧 与 腹 泻 那 抢 回 您 的 性 命 。 中 国 的 故 事 仍 将 继 续 下 去 ， 但 至 少 和 您 已 没 多 大 关 系 了 。";
				}
				else
				{
					name.text = " 正 中 靶 心";
					fake_text = "堂 堂 中 国 领 导 人 最 终 在 意 想 不 到 的 地 方 翻 了 船 ： 您 在 享 受 努 美 阿 如 诗 如 画 的 美 景 时 突 遭 天 降 横 祸 ， 被 只 顽 猴 以 未 成 熟 椰 子 给 正 中 脑 门 。 由 于 钝 物 重 击 未 造 成 明 显 外 伤 ， 且 您 在 先 前 亲 自 要 求 “ 让 大 伙 都 放 松 放 松 ” ， 调 走 了 不 少 专 业 人 士 。 最 终 使 工 作 人 员 没 能 在 第 一 时 间 发 现 您 的 伤 势 ， 只 认 为 您 不 过 是 和 其 他 的 观 光 客 一 样 “ 闭 目 养 神 ” 而 已 。 接 下 来 便 是 一 系 列 连 锁 反 应 ： 医 护 人 员 跟 着 错 过 了 最 佳 救 治 机 会 ， 使 您 成 为 有 史 以 来 首 位 在 任 内 非 正 常 死 亡 的 领 导 人 。 中 国 的 故 事 仍 将 继 续 下 去 ， 但 至 少 和 您 已 没 多 大 关 系 了 。";
				}
			}
			else if (GlobalScript.inst.gameState.data[35] == 11)
			{
				name.text = " 又 一 个 明 英 宗";
				fake_text = "你 的 糟 糕 指 挥 不 仅 葬 送 了 我 们 的 好 战 士 ， 也 让 将 军 们 意 识 到 你 会 害 了 国 家 。 在 一 次 秘 密 会 议 上 ， 他 们 决 定 让 你 提 前 “ 退 休 ” 。 很 快 ， 忠 诚 于 阴 谋 者 的 部 队 切 断 了 电 话 线 ， 包 围 了 中 南 海 ， 你 在 他 们 夺 权 的 过 程 中 以 危 害 国 家 为 由 被 软 禁 起 来 ， 余 生 将 在 秦 城 监 狱 度 过 。 在 宣 布 抓 捕 了 中 央 的 堕 落 分 子 后 ， 军 队 开 始 接 管 各 地 的 党 政 组 织 ， 军 人 和 少 部 分 宣 布 忠 于 军 队 的 文 员 组 建 了 新 地 方 政 府 ， 人 大 则 被 冻 结 ， 直 至 新 的 大 会 上 充 满 了 军 人 和 军 队 的 提 线 木 偶 ， 政 变 的 阴 谋 家 ， 很 快 建 立 了 属 于 他 的 “ 先 军 ， 爱 国 ， 复 仇 ” 路 线 。";
				if (GlobalScript.inst.gameState.modifies[3].active)
				{
					fake_text += "||在 一 些 地 方 发 生 了 大 规 模 流 血 事 件 ， 民 兵 和 政 变 者 的 部 队 大 规 模 火 并 ， 海 空 军 队 则 趁 乱 加 入 了 不 同 阵 营 ， 一 场 内 战 迫 在 眉 睫 ， 中 国 恐 将 陷 入 万 劫 不 复 … …";
				}
				else if (GlobalScript.inst.gameState.data[15] > 7)
				{
					fake_text += "||国 际 社 会 强 烈 谴 责 了 这 一 恐 怖 行 为 ， 并 号 召 国 际 组 织 拒 绝 承 认 在 北 京 的 军 事 政 变 ， 海 牙 国 际 法 庭 也 发 布 了 对 政 变 领 导 人 的 通 缉 令 。 一 些 地 方 发 生 了 大 规 模 流 血 事 件 ， 反 对 派 领 袖 们 被 军 政 府 集 体 逮 捕 处 决 ， 部 分 激 进 的 团 体 选 择 以 暴 力 抗 击 军 事 独 裁 政 权 ， 前 政 府 官 员 则 选 择 组 建 反 政 府 大 帐 篷 ， 或 者 逃 往 其 他 国 家 寻 求 政 治 庇 护 。 美 苏 对 于 事 发 展 表 示 忧 虑 ， 并 开 始 在 中 国 布 下 些 许 暗 线 … …";
				}
				else
				{
					fake_text += "||民 众 对 政 变 的 发 生 没 有 什 么 态 度 ， 安 静 的 就 像 长 安 街 一 样 … …";
				}
				fake_text += "||就 这 样 ， 新 秩 序 到 来 了 … … ";
			}
			else if (GlobalScript.inst.gameState.data[35] == 12)
			{
				name.text = " 亲 自 指 挥 ， 亲 自 部 署 … …";
				fake_text = "国 内 军 官 对 你 在 进 攻 期 间 的 冒 险 主 义 ， 谈 判 期 间 的 投 降 主 义 忍 无 可 忍 ， 并 决 定 让 你 提 前 “ 退 休 ” 。 很 快 ， 忠 诚 于 阴 谋 者 的 部 队 便 切 断 电 话 线 并 包 围 中 南 海 ， 你 则 被 扣 上 了 “ 危 害 国 家 ” 的 帽 子 并 被 软 禁 ， 余 生 将 在 秦 城 监 狱 度 过 。 也 就 在 完 成 对 中 央 的 斩 首 行 动 后 ， 军 队 开 始 试 图 接 管 各 地 党 政 组 织 ， 并 与 少 数 宣 布 忠 于 军 队 的 文 员 组 建 了 救 国 委 员 会 ， 引 入 了 戒 严 法 ： 人 大 被 无 限 期 暂 停 召 开 ， 并 被 军 方 及 其 代 理 人 控 制 的 临 时 委 员 会 取 而 代 之 。 政 变 领 导 人 很 快 便 打 出 “ 先 军 ， 爱 国 ， 复 仇 ” 路 线 ， 试 图 将 中 国 拉 入 军 事 化 轨 道 并 彻 底 取 消 传 统 政 治 框 架 ， 这 只 会 导 致 流 血 事 件 愈 演 愈 烈 ： 民 兵 和 政 变 部 队 陷 入 激 烈 火 并 ， 海 空 军 队 则 趁 乱 加 入 不 同 阵 营 ， 一 场 内 战 迫 在 眉 睫 ， 中 国 恐 将 陷 入 万 劫 不 复 … … 紧 接 着 便 是 自 诩 保 卫 “ 世 界 和 平 ” 的 北 约 组 织 下 场 ， 苏 联 很 快 便 裹 挟 着 复 仇 怒 火 南 下 … …||就 这 样 ， 新 秩 序 到 来 了 … …";
			}
			else if (GlobalScript.inst.gameState.data[35] == 13)
			{
				name.text = " 人 类 命 运 共 同 体 ";
				fake_text = "在 月 球 上 的 红 军 ， 南 极 企 鹅 ， 火 星 人 ， 北 极 熊 ， 磷 虾 ， 耶 稣 基 督 ， 佩 伦 大 神 ， 玉 皇 大 帝 和 蜥 蜴 人 的 帮 助 下 ， 恩 科 洛 索 借 此 神 力 统 一 了 寰 球 。 现 在 ， 人 类 将 活 在 一 个 幸 福 的 天 国 ， 一 个 共 产 主 义 — 许 玻 尔 珀 瑞 亚 — 流 着 奶 与 蜜 的 地 上 天 国 ！ 现 在 ， 让 我 们 看 看 红 色 药 丸 … …";
			}
			else if (GlobalScript.inst.gameState.data[35] == 5)
			{
				name.text = " 新 秩 序";
				if (GlobalScript.inst.gameState.party_number[0] > GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] > GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] > GlobalScript.inst.gameState.party_number[4])
				{
					fake_text = " 全 国 人 大 选 举 并 没 有 给 中 国 共 产 党 带 来 胜 利 ， 来 自 中 国 共 产 党 （ 毛 主 义 ） 的 激 进 共 产 主 义 者 赢 得 了 议 会 选 举 的 胜 利 ， 在 民 粹 主 义 浪 潮 中 获 得 相 对 多 数 。 同 时 中 国 共 产 党 （ 毛 主 义 ） 的 候 选 人 也 赢 得 了 总 统 选 举 。 中 国 共 产 党 （ 毛 主 义 ） 利 用 总 统 的 职 位 以 及 议 会 中 相 对 多 数 的 优 势 ， 组 成 了 一 个 准 联 合 政 府 ， 其 中 其 他 党 派 的 代 表 只 得 到 三 个 小 职 位 。 新 政 府 宣 布 其 目 标 是 回 归 毛 主 义 的 道 路 ， 在 中 国 和 世 界 各 地 建 设 社 会 主 义 和 共 产 主 义 ， 与 苏 修 和 美 帝 进 行 决 定 性 的 对 抗 。 作 为 回 归 社 会 主 义 政 策 的 一 部 分 ， 他 们 首 先 决 定 回 归 一 党 制 ， 消 灭 资 产 阶 级 共 和 国 ， 对 修 正 主 义 者 和 资 本 主 义 者 发 动 新 的 文 化 大 革 命 。 修 正 主 义 者 和 资 本 主 义 者 的 名 单 包 括 除 了 中 国 共 产 党 （ 毛 主 义 ） 以 外 的 所 有 党 派 ， 其 他 党 派 试 图 组 织 针 对 毛 派 及 其 政 策 的 公 开 行 动 ， 呼 吁 美 国 和 苏 联 的 支 持 ， 但 这 一 计 划 在 中 国 共 产 党 （ 毛 主 义 ） 的 军 事 组 织 旗 下 的 军 队 和 武 装 青 年 的 支 持 下 被 警 察 粉 碎 。 作 为 回 应 ， 毛 派 在 全 国 范 围 内 组 织 了 更 多 的 支 持 毛 派 事 业 的 集 会 ， 他 们 强 行 围 捕 所 有 反 对 毛 主 席 事 业 的 人 。 在 党 和 国 家 的 领 导 下 ， 人 民 攻 克 了 反 对 党 派 的 总 部 ， 他 们 的 领 导 人 和 活 动 家 一 部 分 被 处 决 ， 另 一 部 分 被 下 放 农 村 。 中 国 共 产 党 的 领 导 层 也 未 能 避 免 来 自 民 众 的 公 开 愤 怒 ： 党 的 领 导 人 受 到 “ 耻 辱 走 廊 ” 的 待 遇 ， 承 认 走 修 正 主 义 道 路 和 保 证 立 即 悔 改 ， 然 后 被 流 放 到 人 民 公 社 。 美 国 和 苏 联 对 这 些 行 为 表 示 谴 责 ， 中 国 政 府 对 此 道 歉 ， 但 将 责 任 转 移 到 激 进 分 子 身 上 ， 称 “ 无 法 遏 制 人 民 的 愤 怒 ， 也 不 能 在 与 敌 人 的 斗 争 中 阻 止 人 民 ， 担 心 把 诚 实 的 人 民 置 于 危 险 之 中 ” 。 然 而 ， 当 反 对 派 被 击 败 后 ， 武 装 部 队 进 入 北 京 和 其 他 主 要 城 市 ， 以 斗 争 使 不 愿 把 权 力 交 给 中 国 共 产 党 （ 毛 主 义 ） 的 分 散 的 国 家 战 斗 组 织 正 式 自 愿 解 散 。 一 个 中 国 历 史 上 崭 新 的 时 代 正 在 来 临 ， 将 经 济 改 革 与 国 家 对 社 会 、 党 对 国 家 的 权 力 的 极 端 增 强 相 结 合 ， 通 过 专 政 、 全 面 控 制 、 群 众 镇 压 和 新 文 化 ， 进 行 中 国 社 会 主 义 文 化 的 斗 争 ， 建 设 社 会 主 义 和 共 产 主 义 。 无 私 奉 献 于 毛 泽 东 思 想 和 党 ， 根 除 保 守 传 统 主 义 和 自 由 多 元 主 义 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(55);
					}
				}
				else if (GlobalScript.inst.gameState.party_number[0] > 1500)
				{
					fake_text = " 过 去 的 全 国 人 大 选 举 并 没 有 给 中 国 共 产 党 带 来 胜 利 ， 来 自 中 国 共 产 党 （ 毛 主 义 ） 的 激 进 共 产 主 义 者 赢 得 了 议 会 选 举 的 胜 利 ， 在 民 粹 主 义 浪 潮 中 获 得 绝 对 多 数 。 同 时 中 国 共 产 党 （ 毛 主 义 ） 的 候 选 人 也 赢 得 了 总 统 选 举 。 中 国 共 产 党 （ 毛 主 义 ） 利 用 总 统 的 职 位 以 及 议 会 中 绝 对 多 数 的 优 势 ， 组 成 了 一 个 统 一 的 政 府 。 新 政 府 宣 布 其 目 标 是 回 归 毛 主 义 的 道 路 ， 在 中 国 和 世 界 各 地 建 设 社 会 主 义 和 共 产 主 义 ， 与 苏 修 和 美 帝 进 行 决 定 性 的 对 抗 。 作 为 回 归 社 会 主 义 政 策 的 一 部 分 ， 首 先 决 定 回 归 一 党 制 ， 消 灭 资 产 阶 级 共 和 国 ， 对 修 正 主 义 者 和 资 本 主 义 者 发 动 新 的 文 化 大 革 命 。 修 正 主 义 者 和 资 本 主 义 者 的 名 单 包 括 除 了 中 国 共 产 党 （ 毛 主 义 ） 以 外 的 所 有 党 派 ， 其 他 党 派 试 图 组 织 针 对 毛 派 及 其 政 策 的 公 开 行 动 ， 呼 吁 美 国 和 苏 联 的 支 持 ， 但 这 一 计 划 在 中 国 共 产 党 （ 毛 主 义 ） 的 军 事 组 织 旗 下 的 军 队 和 武 装 青 年 的 支 持 下 被 警 察 粉 碎 。 作 为 回 应 ， 毛 派 在 全 国 范 围 内 组 织 了 更 多 的 支 持 毛 派 事 业 的 集 会 ， 他 们 强 行 围 捕 所 有 反 对 毛 主 席 事 业 的 人 。 在 党 和 国 家 的 领 导 下 ， 人 民 攻 克 了 反 对 党 派 的 总 部 ， 他 们 的 领 导 人 和 活 动 家 一 部 分 被 处 决 ， 另 一 部 分 被 下 放 农 村 。 中 国 共 产 党 的 领 导 层 也 未 能 避 免 来 自 民 众 的 公 开 愤 怒 ： 党 的 领 导 人 受 到 “ 耻 辱 走 廊 ” 的 待 遇 ， 承 认 走 修 正 主 义 道 路 和 保 证 立 即 悔 改 ， 然 后 被 流 放 到 人 民 公 社 。 美 国 和 苏 联 对 这 些 行 为 表 示 谴 责 ， 中 国 政 府 对 此 道 歉 ， 但 将 责 任 转 移 到 激 进 分 子 身 上 ， 称 “ 无 法 遏 制 人 民 的 愤 怒 ， 也 不 能 在 与 敌 人 的 斗 争 中 阻 止 人 民 ， 担 心 把 诚 实 的 人 民 置 于 危 险 之 中 ” 。 然 而 ， 当 反 对 派 被 击 败 后 ， 武 装 部 队 进 入 北 京 和 其 他 主 要 城 市 ， 以 斗 争 使 不 愿 把 权 力 交 给 中 国 共 产 党 （ 毛 主 义 ） 的 分 散 的 国 家 战 斗 组 织 正 式 自 愿 解 散 。 一 个 中 国 历 史 上 崭 新 的 时 代 正 在 来 临 ， 将 经 济 改 革 与 国 家 对 社 会 、 党 对 国 家 的 权 力 的 极 端 增 强 相 结 合 ， 通 过 专 政 、 全 面 控 制 、 群 众 镇 压 和 新 文 化 ， 进 行 中 国 社 会 主 义 文 化 的 斗 争 ， 建 设 社 会 主 义 和 共 产 主 义 。 无 私 奉 献 于 毛 泽 东 思 想 和 党 ， 根 除 保 守 传 统 主 义 和 自 由 多 元 主 义 。";
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(55);
					}
				}
				else if (GlobalScript.inst.gameState.party_number[4] > 1500)
				{
					if (GlobalScript.inst.gameState.data[14] < 4)
					{
						fake_text = " 中 国 新 的 自 由 民 主 政 府 宣 布 ， 战 胜 旧 秩 序 和 实 现 政 权 自 由 化 是 其 首 要 也 是 最 重 要 的 目 标 。 政 府 进 行 了 以 自 由 市 场 为 目 标 的 经 济 改 革 ， 但 是 对 经 济 造 成 了 严 重 破 坏 ， 导 致 了 对 旧 有 经 济 联 系 的 崩 溃 ， 然 而 年 轻 的 公 民 社 会 的 反 腐 败 和 反 诈 骗 斗 争 ， 加 上 来 自 美 国 和 西 方 的 贷 款 和 投 资 ， 最 后 得 以 应 付 这 种 情 况 ， 进 入 了 经 济 增 长 的 状 态 ， 这 在 一 定 程 度 上 抵 消 了 以 前 的 衰 退 ， 甚 至 使 我 们 能 够 谈 及 在 经 济 增 长 和 提 高 社 会 福 利 方 面 取 得 的 某 些 成 就 ， 然 而 ， 绝 大 多 数 收 入 集 中 在 一 个 狭 小 的 个 人 群 体 手 中 — — 新 生 的 寡 头 ， 而 成 千 上 万 的 人 离 开 中 国 ， 希 望 在 国 外 找 到 更 好 的 生 活 。 民 主 党 在 公 共 生 活 的 所 有 领 域 ， 包 括 政 治 生 活 中 清 除 国 家 控 制 ， 消 除 了 反 对 派 自 由 活 动 的 所 有 障 碍 。 在 中 华 民 主 共 和 国 ， 即 现 在 的 国 家 ， 一 个 自 由 民 主 的 政 权 正 在 形 成 。 与 美 国 的 关 系 正 在 变 得 友 好 ， 与 苏 联 的 关 系 也 在 逐 渐 恶 化 。 美 国 正 在 成 为 中 国 的 主 要 经 济 伙 伴 — — 世 界 市 场 中 一 个 年 轻 参 与 者 的 主 要 债 权 国 和 投 资 者 ， 中 国 对 发 达 国 家 的 依 赖 日 益 增 长 。 苏 联 正 在 逐 步 断 绝 与 中 国 的 贸 易 关 系 ， 并 加 强 其 在 苏 中 边 境 的 军 事 存 在 。";
					}
					else
					{
						fake_text = " 中 国 新 的 自 由 民 主 政 府 宣 布 ， 加 强 和 改 进 民 主 是 其 首 要 也 是 最 重 要 的 目 标 。 政 府 坚 持 自 由 的 国 内 市 场 并 且 建 立 开 放 的 外 部 市 场 ， 经 济 继 续 增 长 ， 但 国 内 生 产 总 值 相 当 不 稳 定 ， 因 为 金 融 危 机 经 常 强 烈 冲 击 它 ， 而 在 大 多 数 人 尝 试 适 应 市 场 的 同 时 ， 少 数 掌 握 着 更 多 资 源 的 寡 头 却 变 得 更 富 有 ， 外 国 投 机 者 继 续 向 外 输 出 榨 取 的 资 源 。 民 主 党 在 公 共 生 活 的 所 有 领 域 ， 包 括 政 治 生 活 中 清 除 国 家 控 制 ， 使 得 反 对 派 能 够 半 自 由 的 进 行 活 动 ， 但 是 为 了 在 经 济 危 机 中 维 持 共 和 国 ， 当 局 对 激 进 组 织 采 取 了 无 情 的 打 压 。 中 华 民 主 共 和 国 ， 即 现 在 的 中 国 ， 保 持 着 自 由 民 主 的 政 权 。 与 美 国 的 关 系 仍 然 友 好 ， 与 苏 联 的 关 系 相 当 敌 对 。 美 国 仍 然 是 中 华 民 主 共 和 国 的 主 要 经 济 伙 伴 — — 成 为 世 界 市 场 的 一 个 年 轻 参 与 者 的 主 要 债 权 国 和 投 资 者 ， 该 市 场 对 发 达 国 家 的 依 赖 日 益 增 长 。 苏 联 逐 步 断 绝 与 中 国 的 贸 易 关 系 ， 并 加 强 其 在 苏 中 边 境 的 军 事 存 在 。";
					}
					if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 部 分 人 民 ， 特 别 是 工 人 阶 级 的 支 持 ， 保 持 其 队 伍 的 团 结 和 党 的 路 线 ， 在 民 主 党 执 政 期 间 与 民 主 主 义 者 的 决 定 性 对 抗 ， 使 整 个 反 对 派 在 中 国 共 产 党 周 围 团 结 起 来 。 然 而 ， 中 国 共 产 党 的 活 动 受 到 许 多 法 院 判 决 的 严 重 限 制 ， 一 些 领 导 人 因 各 种 （ 明 显 是 虚 假 的 ） 指 控 而 被 捕 。";
					}
					else if (GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 大 选 失 利 之 后 ， 中 国 共 产 党 仍 然 拥 有 众 多 选 民 的 支 持 ， 党 内 团 结 依 旧 ， 党 的 路 线 也 仍 然 被 人 认 可 。 于 是 中 国 民 主 党 允 许 中 国 共 产 党 作 为 一 个 政 治 上 “ 有 建 设 性 的 反 对 党 ” 和 中 国 民 主 党 以 及 中 国 致 公 党 组 成 政 治 联 盟 。";
					}
					else
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 无 法 维 持 党 内 的 团 结 ， 同 时 失 去 了 大 部 分 人 民 的 支 持 ， 分 裂 成 了 三 个 党 。 在 中 国 民 主 党 执 政 期 间 ， 前 者 与 其 结 为 联 盟 ， 后 两 者 支 持 反 对 派 。 最 后 ， 在 三 年 后 ， 后 两 者 重 新 合 并 为 一 个 新 的 中 国 共 产 党 ， 但 是 ， 共 产 主 义 在 中 国 的 复 兴 仍 然 遥 遥 无 期 …";
					}
				}
				else if (GlobalScript.inst.gameState.party_number[3] > GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[3] > GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[3] > GlobalScript.inst.gameState.party_number[4])
				{
					if (GlobalScript.inst.gameState.data[14] < 4)
					{
						fake_text = " 中 华 人 民 共 和 国 新 的 社 会 爱 国 主 义 政 府 宣 布 了 维 护 国 家 与 多 民 族 统 一 和 社 会 繁 荣 的 可 持 续 发 展 为 首 要 和 最 重 要 的 目 标 。 政 府 还 宣 布 了 针 对 社 会 主 义 市 场 经 济 的 经 济 改 革 ， 这 对 经 济 是 一 个 严 重 的 打 击 ， 旧 有 经 济 结 构 关 系 的 崩 溃 导 致 了 混 乱 ， 维 护 社 会 保 障 的 努 力 导 致 预 算 赤 字 ， 最 终 导 致 中 国 经 济 崩 溃 ， 由 于 腐 败 和 欺 诈 的 猖 獗 ， 只 有 美 国 和 西 方 国 家 的 贷 款 和 投 资 才 能 最 终 解 决 这 一 问 题 ， 这 使 我 们 的 经 济 进 入 快 速 增 长 的 状 态 ， 这 部 分 弥 补 了 前 一 次 衰 退 ， 甚 至 可 以 让 我 们 谈 及 经 济 增 长 和 提 高 社 会 财 富 方 面 的 一 些 成 功 ， 但 是 很 大 一 部 分 收 入 流 向 了 我 们 的 经 济 伙 伴 而 不 是 我 们 。 鉴 于 维 护 国 家 统 一 的 必 要 性 ， 中 国 致 公 党 将 进 行 进 一 步 的 联 邦 化 和 民 主 改 革 ， 在 维 护 国 家 监 管 的 同 时 ， 在 所 有 领 域 引 入 更 多 的 自 由 和 开 放 。 中 国 正 在 形 成 具 有 中 国 特 色 的 社 会 主 义 制 度 。 与 美 国 的 关 系 回 暖 ， 与 苏 联 的 关 系 逐 渐 冷 淡 。 美 国 正 在 成 为 中 国 的 主 要 经 济 伙 伴 ， 是 世 界 市 场 上 的 年 轻 参 与 者 的 主 要 债 权 国 和 投 资 者 ， 中 国 对 发 达 国 家 的 依 赖 性 正 在 增 加 ， 但 与 此 同 时 ， 作 为 深 化 合 作 的 一 部 分 ， 关 于 归 还 香 港 与 澳 门 以 及 台 湾 的 特 殊 地 位 的 谈 判 正 在 进 行 当 中 ， 这 似 乎 是 以 对 中 国 的 妥 协 告 终 的 ， 苏 联 继 续 与 中 国 就 建 立 全 面 外 交 关 系 进 行 谈 判 ， 但 在 美 国 的 竭 力 主 张 下 ， 中 华 人 民 共 和 国 要 求 做 出 领 土 上 的 让 步 ， 而 苏 联 一 再 拒 绝 。";
					}
					else
					{
						fake_text = " 中 华 人 民 共 和 国 的 新 一 届 社 会 爱 国 主 义 政 府 宣 布 ， 其 首 要 和 最 重 要 的 目 标 是 维 护 国 家 和 各 族 人 民 之 间 的 团 结 ， 与 可 持 续 的 社 会 繁 荣 增 长 。 政 府 还 宣 布 了 针 对 社 会 主 义 市 场 经 济 的 经 济 改 革 ， 这 对 经 济 是 一 个 严 重 的 打 击 ， 经 济 改 革 导 致 我 们 要 增 强 在 公 共 部 门 的 国 家 控 制 力 度 和 面 对 上 层 阶 级 的 高 税 收 ， 这 对 经 济 的 增 长 的 打 击 是 惊 人 的 ， 并 且 导 致 国 内 外 投 资 的 减 少 和 对 企 业 家 来 说 整 体 不 利 的 市 场 环 境 ， 但 同 时 ， 我 们 通 过 增 加 在 社 会 保 障 领 域 的 公 共 投 资 ， 提 升 了 社 会 财 富 水 平 。 在 维 护 国 家 统 一 的 需 要 下 ， 中 国 致 公 党 遵 循 联 邦 制 和 民 主 的 原 则 ， 也 加 强 了 国 家 媒 体 的 爱 国 主 义 宣 传 。 中 国 正 在 形 成 具 有 中 国 特 色 的 社 会 主 义 制 度 ， 在 与 美 国 的 关 系 正 在 变 冷 的 同 时 ， 与 苏 联 的 关 系 正 在 变 暖 。 美 国 正 通 过 选 择 其 他 国 家 来 削 减 贷 款 和 投 资 ， 而 有 关 香 港 和 澳 门 回 归 ， 台 湾 的 国 际 地 位 的 谈 判 也 陷 入 停 滞 。 苏 联 继 续 与 中 国 就 建 立 全 面 外 交 关 系 进 行 谈 判 ， 并 取 得 了 成 功 — — 中 国 拒 绝 接 受 其 领 土 要 求 ， 苏 联 向 中 国 派 出 专 家 ， 发 放 了 大 量 无 息 贷 款 。";
					}
					if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 一 部 分 人 民 的 支 持 和 党 内 的 团 结 ， 党 的 路 线 和 坚 决 反 对 中 国 致 公 党 过 于 谨 慎 的 政 策 ， 使 其 成 为 了 主 要 的 激 进 反 对 派 。 中 国 共 产 党 继 续 与 中 国 致 公 党 进 行 政 治 斗 争 ， 不 仅 限 于 参 加 选 举 和 竞 选 活 动 ， 还 经 常 安 排 激 进 派 的 公 开 行 动 。";
					}
					else if (GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 一 部 分 人 民 的 支 持 和 党 内 的 团 结 ， 党 的 路 线 并 且 坚 决 反 对 中 国 致 公 党 过 于 社 会 主 义 的 政 策 ， 使 其 成 为 了 主 要 的 民 主 反 对 派 。 中 国 共 产 党 继 续 与 中 国 致 公 党 进 行 政 治 斗 争 ， 不 仅 限 于 参 加 选 举 和 竞 选 活 动 ， 还 经 常 安 排 民 主 派 的 公 开 行 动 。";
					}
					else
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 无 法 维 持 党 内 的 团 结 ， 同 时 失 去 了 大 部 分 人 民 的 支 持 ， 在 被 击 败 后 迅 速 分 裂 成 了 数 个 独 立 的 反 对 党 派 。 在 中 国 致 公 党 执 政 期 间 ， 他 们 中 的 一 些 人 支 持 激 进 分 子 ， 一 些 人 支 持 致 公 党 ， 一 些 人 支 持 民 主 党 。 最 后 ， 他 们 都 成 为 其 他 更 大 、 更 具 凝 聚 力 的 政 党 的 一 部 分 ， 要 么 仍 然 是 小 而 分 裂 的 小 党 ， 对 政 治 没 有 真 正 的 影 响 。";
					}
				}
				else if (GlobalScript.inst.gameState.party_number[3] > 1500)
				{
					if (GlobalScript.inst.gameState.data[14] < 4)
					{
						fake_text = " 中 华 人 民 共 和 国 新 政 府 以 实 现 稳 定 繁 荣 的 政 策 而 上 台 ， 政 府 在 对 国 家 问 题 和 社 会 繁 荣 的 可 持 续 发 展 问 题 进 行 了 更 为 仔 细 的 考 虑 ， 宣 布 了 以 维 护 国 家 统 一 、 维 护 民 族 团 结 为 首 要 和 最 重 要 的 目 标 。 政 府 宣 布 了 针 对 社 会 主 义 市 场 经 济 方 向 的 经 济 改 革 ， 这 对 经 济 造 成 了 一 定 的 打 击 ， 旧 有 经 济 结 构 关 系 的 崩 溃 导 致 了 混 乱 ， 但 经 济 衰 退 远 远 低 于 预 期 ， 这 让 或 多 或 少 的 灾 难 性 后 果 最 小 化 。 （ 然 而 ， 它 打 击 了 大 部 分 人 民 的 生 活 水 平 ） 。 鉴 于 维 护 国 家 统 一 的 必 要 性 ， 中 国 致 公 党 将 进 行 进 一 步 的 联 邦 化 和 民 主 改 革 ， 在 维 护 国 家 监 管 的 同 时 ， 在 所 有 领 域 引 入 更 多 的 自 由 与 开 放 。 中 国 正 在 形 成 具 有 中 国 特 色 的 社 会 主 义 制 度 。 中 国 与 美 国 之 间 的 关 系 逐 渐 回 暖 ， 却 与 苏 联 的 关 系 逐 渐 冷 淡 。 美 国 成 为 中 国 的 主 要 经 济 伙 伴 ， 是 世 界 市 场 的 年 轻 参 与 者 的 主 要 债 权 国 和 投 资 者 ， 中 国 对 发 达 国 家 的 依 赖 性 逐 渐 上 升 ， 但 与 此 同 时 ， 作 为 深 化 合 作 的 一 部 分 ， 关 于 归 还 香 港 与 澳 门 以 及 台 湾 的 特 殊 地 位 的 谈 判 正 在 进 行 当 中 ， 这 似 乎 是 以 对 中 国 的 妥 协 告 终 的 。 苏 联 继 续 与 中 国 就 恢 复 全 面 外 交 关 系 进 行 谈 判 ， 但 在 美 国 的 竭 力 主 张 下 ， 中 华 人 民 共 和 国 要 求 作 出 领 土 上 的 让 步 ， 而 苏 联 一 再 拒 绝 。";
					}
					else
					{
						fake_text = " 中 华 人 民 共 和 国 的 新 一 届 社 会 爱 国 主 义 政 府 宣 布 ， 其 首 要 和 最 重 要 的 目 标 是 维 护 国 家 和 各 族 人 民 之 间 的 团 结 ， 与 可 持 续 的 社 会 繁 荣 增 长 。 政 府 还 宣 布 了 针 对 社 会 主 义 市 场 经 济 的 经 济 改 革 ， 经 济 改 革 导 致 我 们 要 增 强 在 公 共 部 门 的 国 家 控 制 力 度 和 面 对 上 层 阶 级 的 高 税 收 ， 这 对 经 济 的 增 长 有 一 定 的 影 响 ， 并 且 导 致 国 内 外 投 资 的 减 少 和 对 企 业 家 来 说 整 体 不 利 的 市 场 环 境 ， 但 同 时 ， 我 们 通 过 增 加 在 社 会 保 障 领 域 的 公 共 投 资 ， 提 升 了 社 会 财 富 水 平 。 在 维 护 国 家 统 一 的 需 要 下 ， 中 国 致 公 党 遵 循 联 邦 制 和 民 主 的 原 则 ， 也 加 强 了 国 家 媒 体 的 爱 国 主 义 宣 传 。 中 国 正 在 形 成 具 有 中 国 特 色 的 社 会 主 义 制 度 ， 在 与 美 国 的 关 系 正 在 变 冷 的 同 时 ， 与 苏 联 的 关 系 正 在 变 暖 。 美 国 正 通 过 选 择 其 他 国 家 来 削 减 贷 款 和 投 资 ， 而 有 关 香 港 和 澳 门 回 归 ， 台 湾 的 国 际 地 位 的 谈 判 在 最 后 关 头 陷 入 了 停 滞 ， 但 关 于 香 港 和 澳 门 回 归 的 谈 判 正 在 逐 渐 取 得 成 功 。 苏 联 继 续 与 中 国 就 恢 复 全 面 外 交 关 系 进 行 谈 判 ， 并 取 得 了 成 功 — — 中 国 放 弃 了 领 土 要 求 ， 苏 联 向 中 国 派 出 专 家 ， 发 放 了 大 量 无 息 贷 款 。";
					}
					if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 党 内 的 团 结 ， 保 证 大 部 分 人 民 的 支 持 ， 特 别 是 工 人 阶 级 的 支 持 ， 党 的 路 线 和 坚 决 反 对 中 国 致 公 党 的 过 于 软 弱 的 政 策 ， 这 使 其 成 为 了 主 要 的 反 对 派 。 中 国 共 产 党 继 续 与 中 国 致 公 党 进 行 政 治 斗 争 ， 其 仍 然 是 一 个 拥 有 议 会 席 位 的 政 党 ， 能 够 采 取 多 种 斗 争 方 式 ， 不 仅 限 于 参 加 选 举 和 竞 选 ， 还 经 常 安 排 公 共 行 动 。";
					}
					else if (GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 一 部 分 人 民 的 支 持 和 党 内 的 团 结 ， 党 的 路 线 和 和 坚 决 反 对 中 国 致 公 党 过 于 谨 慎 的 政 策 ， 使 其 成 为 了 主 要 的 民 主 反 对 派 。 中 国 共 产 党 继 续 与 中 国 致 公 党 进 行 政 治 斗 争 ， 不 仅 限 于 参 加 选 举 和 竞 选 活 动 ， 还 经 常 安 排 公 开 行 动 。";
					}
					else
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 无 法 维 持 党 内 的 团 结 ， 同 时 失 去 了 大 部 分 人 民 的 支 持 ， 分 裂 成 了 两 个 党 。 在 中 国 致 公 党 执 政 期 间 ， 前 者 与 其 结 为 联 盟 ， 后 者 则 支 持 反 对 派 。 最 后 ， 在 三 年 后 ， 他 们 重 新 合 并 ， 但 是 ， 中 国 共 产 党 在 这 个 辽 阔 的 国 家 恢 复 其 影 响 力 还 十 分 漫 长 …";
					}
				}
				else if (GlobalScript.inst.gameState.party_number[2] > GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[2] > GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] > GlobalScript.inst.gameState.party_number[4])
				{
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						achieves.GetComponent<achievements>().Set(22);
					}
					if (GlobalScript.inst.gameState.data[14] < 4)
					{
						fake_text = " 中 国 新 政 府 宣 布 ， 维 护 中 国 国 家 统 一 、 收 复 失 地 — — 香 港 、 澳 门 和 台 湾 是 其 首 要 和 最 重 要 的 目 标 。 政 府 还 宣 布 了 以 在 保 留 国 家 控 制 的 前 提 下 ， 扩 大 个 人 能 动 性 ， 并 且 允 许 有 限 的 外 国 投 资 进 入 为 方 向 的 经 济 改 革 ， 这 对 经 济 增 长 起 到 了 拉 动 作 用 ， 但 与 此 同 时 ， 腐 败 问 题 和 资 本 欺 诈 行 为 愈 演 愈 烈 ， 由 此 产 生 的 收 入 被 用 于 扩 大 和 改 善 国 家 机 构 以 及 完 善 社 会 保 障 的 水 平 ， 从 短 期 来 看 ， 它 可 以 使 国 家 富 强 ， 人 民 生 活 水 平 提 高 ， 但 是 ， 它 同 时 也 阻 碍 了 经 济 的 进 一 步 增 长 ， 减 缓 了 经 济 发 展 的 速 度 。 在 国 家 分 裂 的 背 景 下, 执 政 党 决 定 加 强 国 家 机 器 ， 这 导 致 了 对 中 国 致 公 党 的 联 邦 主 义 者 和 中 国 民 主 党 的 自 由 主 义 者 的 非 正 式 镇 压 ， 以 及 建 立 了 强 大 的 国 家 控 制 的 、 表 现 出 了 积 极 的 民 族 主 义 宣 传 的 媒 体 ， 同 时 也 对 任 何 未 经 授 权 的 公 共 行 为 非 正 式 禁 止 。 在 几 乎 没 有 遇 到 任 何 阻 力 的 情 况 下 ， 中 国 形 成 了 伪 民 主 的 右 派 政 权 。 与 美 国 和 苏 联 的 关 系 仍 然 紧 张 且 不 友 好 。 然 而 ， 美 国 也 不 放 过 有 利 可 图 的 投 资 机 会 ， 敦 促 其 盟 友 就 收 复 失 去 的 香 港 、 澳 门 和 台 湾 地 位 问 题 启 动 谈 判 。 然 而 ， 由 于 新 国 民 党 与 在 台 湾 的 “ 旧 国 民 党 ” 之 间 实 际 上 关 系 紧 张 ， 谈 判 陷 入 了 严 重 的 停 滞 。 另 一 方 面 ， 苏 联 继 续 同 中 华 人 民 共 和 国 就 恢 复 全 面 外 交 关 系 进 行 谈 判 ， 但 中 华 人 民 共 和 国 要 求 领 土 上 的 让 步 ， 而 苏 联 并 不 同 意 ， 谈 判 也 逐 渐 陷 入 僵 持 。";
					}
					else
					{
						fake_text = " 新 中 国 政 府 宣 布 ， 其 首 要 和 最 重 要 的 目 标 是 维 护 中 国 国 家 统 一 、 收 复 失 地 — — 香 港 ， 澳 门 和 台 湾 。 政 府 还 宣 布 了 以 减 少 私 人 企 业 、 加 强 国 家 对 企 业 的 中 央 控 制 以 及 限 制 外 国 投 资 为 方 向 的 倒 退 式 经 济 改 革 ， 与 此 同 时 ， 腐 败 问 题 和 金 融 欺 诈 行 为 愈 演 愈 烈 ， 经 济 出 现 了 大 幅 度 倒 退 。 企 业 合 并 的 同 时 加 强 了 国 家 机 构 对 其 的 控 制 ， 令 政 府 获 得 了 大 量 资 源 ， 并 被 用 于 扩 大 和 改 善 国 家 机 构 以 及 完 善 社 会 保 障 的 水 平 ， 这 在 短 期 内 使 国 家 富 强 ， 人 民 生 活 水 平 提 高 。 但 是 ， 它 同 时 也 阻 碍 了 经 济 的 进 一 步 增 长 ， 减 缓 了 经 济 发 展 的 速 度 。 在 国 家 分 裂 的 背 景 下 ， 政 府 通 过 对 来 自 中 国 致 公 党 的 联 邦 主 义 者 以 及 来 自 中 国 民 主 党 的 自 由 主 义 者 的 镇 压 ， 以 及 在 媒 体 行 业 实 行 强 有 力 的 审 核 制 度 ， 实 行 激 进 的 民 族 主 义 政 策 ， 同 时 也 对 任 何 未 经 授 权 的 公 共 行 为 实 施 禁 令 ， 以 此 来 加 强 政 府 控 制 。 反 对 党 受 到 压 制 或 贿 赂 ， 中 国 形 成 了 极 右 的 虚 假 民 主 政 权 。 中 国 与 美 国 和 苏 联 的 关 系 明 显 恶 化 。 美 国 对 中 国 的 倒 退 式 改 革 做 出 了 回 应 ， 开 始 逐 步 撤 资 ， 并 敦 促 其 盟 友 共 同 加 强 在 香 港 、 澳 门 和 台 湾 的 西 方 军 事 存 在 ， 尽 管 中 国 认 为 这 是 属 于 他 们 的 领 土 。 苏 联 也 对 中 国 的 倒 退 式 改 革 做 出 了 回 应 ， 称 中 国 为 社 会 法 西 斯 国 家 ， 也 加 强 了 其 在 与 中 国 有 争 议 领 土 的 军 事 存 在 。";
					}
					if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 大 部 分 群 众 的 支 持 ， 全 党 也 仍 愿 团 结 起 来 维 护 党 的 路 线 ， 加 上 对 新 国 民 党 改 革 计 划 的 大 力 支 持 换 取 了 政 治 上 的 继 续 存 在 ， 使 中 国 共 产 党 成 为 了 一 个 合 法 的 反 对 党 。 中 共 得 以 继 续 他 的 活 动 ， 不 仅 限 于 参 加 选 举 和 竞 选 活 动 ， 还 经 常 安 排 公 开 行 动 去 支 持 新 国 民 党 ， 只 是 偶 尔 会 对 新 国 民 党 的 一 些 政 客 发 表 批 评 意 见 。";
					}
					else if (GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 大 选 中 失 去 了 多 数 席 位 的 中 国 共 产 党 最 后 还 是 能 保 住 一 部 分 群 众 支 持 ， 党 内 团 结 也 仍 然 能 保 持 下 去 ， 这 使 得 中 国 共 产 党 在 之 后 与 新 国 民 党 的 继 续 改 革 风 潮 作 斗 争 时 可 以 团 结 大 多 数 反 对 党 ， 并 形 成 了 一 个 以 中 共 为 核 心 的 反 对 阵 线 。 然 而 ， 中 国 共 产 党 的 活 动 受 到 许 多 法 院 判 决 的 严 重 限 制 ， 一 些 领 导 人 因 各 种 （ 明 显 是 虚 假 的 ） 指 控 而 被 捕 。";
					}
					else
					{
						fake_text += " 输 掉 了 大 选 的 中 国 共 产 党 无 法 维 持 党 内 团 结 ， 也 丧 失 了 中 国 人 民 的 信 任 ， 并 最 终 分 裂 为 了 四 个 不 同 的 党 ， 在 反 改 革 浪 潮 中 ， 其 中 的 一 个 党 支 持 新 国 民 党 而 其 他 三 个 则 反 对 新 国 民 党 ， 最 后 支 持 新 国 民 党 的 在 几 年 后 被 新 国 民 党 吞 并 ， 之 后 两 个 中 共 分 裂 而 来 的 党 联 合 起 来 重 建 了 中 国 共 产 党 ， 而 最 后 一 个 由 中 国 共 产 党 分 裂 出 来 的 党 保 持 着 一 个 独 立 的 反 对 党 身 份 。";
					}
				}
				else if (GlobalScript.inst.gameState.party_number[2] > 1500)
				{
					if (GlobalScript.inst.gameState.data[14] < 4)
					{
						fake_text = " 中 国 新 政 府 宣 布 ， 维 护 中 国 国 家 统 一 、 收 复 失 地 — — 香 港 、 澳 门 和 台 湾 是 其 首 要 和 最 重 要 的 目 标 。 政 府 还 宣 布 了 以 在 保 留 国 家 控 制 的 前 提 下 ， 扩 大 个 人 能 动 性 ， 并 且 允 许 有 限 的 外 国 投 资 进 入 为 方 向 的 经 济 改 革 ， 这 对 经 济 增 长 起 到 了 拉 动 作 用 ， 但 与 此 同 时 ， 腐 败 问 题 和 资 本 欺 诈 行 为 愈 演 愈 烈 ， 由 此 产 生 的 收 入 被 用 于 扩 大 和 改 善 国 家 机 构 以 及 完 善 社 会 保 障 的 水 平 ， 从 短 期 来 看 ， 它 可 以 使 国 家 富 强 ， 人 民 生 活 水 平 提 高 ， 但 是 ， 它 同 时 也 阻 碍 了 经 济 的 进 一 步 增 长 ， 减 缓 了 经 济 发 展 的 速 度 。 在 国 家 分 裂 的 背 景 下, 执 政 党 决 定 加 强 国 家 机 器 ， 这 导 致 了 对 中 国 致 公 党 的 联 邦 主 义 者 和 中 国 民 主 党 的 自 由 主 义 者 的 非 正 式 镇 压 ， 以 及 建 立 了 强 大 的 国 家 控 制 的 、 表 现 出 了 积 极 的 民 族 主 义 宣 传 的 媒 体 ， 同 时 也 对 任 何 未 经 授 权 的 公 共 行 为 非 正 式 禁 止 。 在 几 乎 没 有 遇 到 任 何 阻 力 的 情 况 下 ， 中 国 形 成 了 伪 民 主 的 右 派 政 权 。 与 美 国 和 苏 联 的 关 系 仍 然 紧 张 且 不 友 好 。 然 而 ， 美 国 也 不 放 过 有 利 可 图 的 投 资 机 会 ， 敦 促 其 盟 友 就 收 复 失 去 的 香 港 、 澳 门 和 台 湾 地 位 问 题 启 动 谈 判 。 然 而 ， 由 于 新 国 民 党 与 在 台 湾 的 “ 旧 国 民 党 ” 之 间 实 际 上 关 系 紧 张 ， 谈 判 陷 入 了 严 重 的 停 滞 。 另 一 方 面 ， 苏 联 继 续 同 中 华 人 民 共 和 国 就 恢 复 全 面 外 交 关 系 进 行 谈 判 ， 但 中 华 人 民 共 和 国 要 求 领 土 上 的 让 步 ， 而 苏 联 并 不 同 意 ， 谈 判 也 逐 渐 陷 入 僵 持 。";
					}
					else
					{
						fake_text = " 新 中 国 政 府 宣 布 ， 其 首 要 和 最 重 要 的 目 标 是 维 护 中 国 国 家 统 一 、 收 复 失 地 — — 香 港 ， 澳 门 和 台 湾 。 政 府 还 宣 布 了 以 减 少 私 人 企 业 、 加 强 国 家 对 企 业 的 中 央 控 制 以 及 限 制 外 国 投 资 为 方 向 的 倒 退 式 经 济 改 革 ， 与 此 同 时 ， 腐 败 问 题 和 金 融 欺 诈 行 为 愈 演 愈 烈 ， 经 济 出 现 了 大 幅 度 倒 退 。 企 业 合 并 的 同 时 加 强 了 国 家 机 构 对 其 的 控 制 ， 令 政 府 获 得 了 大 量 资 源 ， 并 被 用 于 扩 大 和 改 善 国 家 机 构 以 及 完 善 社 会 保 障 的 水 平 ， 这 在 短 期 内 使 国 家 富 强 ， 人 民 生 活 水 平 提 高 。 但 是 ， 它 同 时 也 阻 碍 了 经 济 的 进 一 步 增 长 ， 减 缓 了 经 济 发 展 的 速 度 。 在 国 家 分 裂 的 背 景 下 ， 政 府 通 过 对 来 自 中 国 致 公 党 的 联 邦 主 义 者 以 及 来 自 中 国 民 主 党 的 自 由 主 义 者 的 镇 压 ， 以 及 在 媒 体 行 业 实 行 强 有 力 的 审 核 制 度 ， 实 行 激 进 的 民 族 主 义 政 策 ， 同 时 也 对 任 何 未 经 授 权 的 公 共 行 为 实 施 禁 令 ， 以 此 来 加 强 政 府 控 制 。 反 对 党 受 到 压 制 或 贿 赂 ， 中 国 形 成 了 极 右 的 虚 假 民 主 政 权 。 中 国 与 美 国 和 苏 联 的 关 系 明 显 恶 化 。 美 国 对 中 国 的 倒 退 式 改 革 做 出 了 回 应 ， 开 始 逐 步 撤 资 ， 并 敦 促 其 盟 友 共 同 加 强 在 香 港 、 澳 门 和 台 湾 的 西 方 军 事 存 在 ， 尽 管 中 国 认 为 这 是 属 于 他 们 的 领 土 。 苏 联 也 对 中 国 的 倒 退 式 改 革 做 出 了 回 应 ， 称 中 国 为 社 会 法 西 斯 国 家 ， 也 加 强 了 其 在 与 中 国 有 争 议 领 土 的 军 事 存 在 。";
					}
					if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 大 部 分 群 众 的 支 持 ， 全 党 也 仍 愿 团 结 起 来 维 护 党 的 路 线 ， 加 上 对 新 国 民 党 改 革 计 划 的 大 力 支 持 换 取 了 政 治 上 的 继 续 存 在 ， 使 中 国 共 产 党 成 为 了 一 个 合 法 的 反 对 党 。 中 共 得 以 继 续 他 的 活 动 ， 不 仅 限 于 参 加 选 举 和 竞 选 活 动 ， 还 经 常 安 排 公 开 行 动 去 支 持 新 国 民 党 ， 只 是 偶 尔 会 对 新 国 民 党 的 一 些 政 客 发 表 批 评 意 见 。";
					}
					else if (GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 大 选 中 失 去 了 多 数 席 位 的 中 国 共 产 党 最 后 还 是 能 保 住 一 部 分 群 众 支 持 ， 党 内 团 结 也 仍 然 能 保 持 下 去 ， 这 使 得 中 国 共 产 党 在 之 后 与 新 国 民 党 的 继 续 改 革 风 潮 作 斗 争 时 可 以 团 结 大 多 数 反 对 党 ， 并 形 成 了 一 个 以 中 共 为 核 心 的 反 对 阵 线 。 然 而 ， 中 国 共 产 党 的 活 动 受 到 许 多 法 院 判 决 的 严 重 限 制 ， 一 些 领 导 人 因 各 种 （ 明 显 是 虚 假 的 ） 指 控 而 被 捕 。";
					}
					else
					{
						fake_text += " 输 掉 了 大 选 的 中 国 共 产 党 无 法 维 持 党 内 团 结 ， 也 丧 失 了 中 国 人 民 的 信 任 ， 并 最 终 分 裂 为 了 四 个 不 同 的 党 ， 在 反 改 革 浪 潮 中 ， 其 中 的 一 个 党 支 持 新 国 民 党 而 其 他 三 个 则 反 对 新 国 民 党 ， 最 后 支 持 新 国 民 党 的 在 几 年 后 被 新 国 民 党 吞 并 ， 之 后 两 个 中 共 分 裂 而 来 的 党 联 合 起 来 重 建 了 中 国 共 产 党 ， 而 最 后 一 个 由 中 国 共 产 党 分 裂 出 来 的 党 保 持 着 一 个 独 立 的 反 对 党 身 份 。";
					}
				}
				else
				{
					if (GlobalScript.inst.gameState.data[14] < 4)
					{
						fake_text = " 中 国 新 的 自 由 民 主 政 府 宣 布 ， 战 胜 旧 秩 序 和 实 现 政 权 自 由 化 是 其 首 要 和 最 重 要 的 目 标 。 政 府 进 行 了 以 自 由 市 场 为 目 标 的 经 济 改 革 ， 但 是 对 经 济 造 成 了 严 重 破 坏 ， 导 致 了 对 旧 有 经 济 联 系 的 崩 溃 ， 然 而 年 轻 的 公 民 社 会 的 反 腐 败 和 反 诈 骗 斗 争 ， 加 上 来 自 美 国 和 西 方 的 贷 款 和 投 资 ， 最 后 得 以 应 付 这 种 情 况 ， 进 入 了 经 济 增 长 的 状 态 ， 这 在 一 定 程 度 上 抵 消 了 以 前 的 衰 退 ， 甚 至 使 我 们 能 够 谈 及 在 经 济 增 长 和 提 高 社 会 福 利 方 面 取 得 的 某 些 成 就 ， 然 而 ， 绝 大 多 数 收 入 集 中 在 一 个 狭 小 的 个 人 群 体 手 中 — — 新 生 的 寡 头 ， 而 成 千 上 万 的 人 离 开 中 国 ， 希 望 在 国 外 找 到 更 好 的 生 活 。 民 主 党 在 公 共 生 活 的 所 有 领 域 ， 包 括 政 治 生 活 中 清 除 国 家 控 制 ， 消 除 了 反 对 派 自 由 活 动 的 所 有 障 碍 。 在 中 华 民 主 共 和 国 ， 即 现 在 的 国 家 ， 一 个 自 由 民 主 的 政 权 正 在 形 成 。 与 美 国 的 关 系 正 在 变 得 友 好 ， 与 苏 联 的 关 系 也 在 逐 渐 恶 化 。 美 国 正 在 成 为 中 国 的 主 要 经 济 伙 伴 ， 世 界 市 场 中 一 个 年 轻 参 与 者 的 主 要 债 权 国 和 投 资 者 ， 中 国 对 发 达 国 家 的 依 赖 日 益 增 长 。 苏 联 正 在 逐 步 断 绝 与 中 国 的 贸 易 关 系 ， 并 加 强 其 在 中 苏 边 境 的 军 事 存 在 。 新 的 当 局 已 经 开 始 与 台 湾 谈 判 ， 以 恢 复 国 家 的 统 一 ， 因 为 他 们 之 间 的 所 有 矛 盾 都 已 消 除 。";
					}
					else
					{
						fake_text = " 中 国 新 的 自 由 民 主 政 府 宣 布 ， 加 强 和 改 进 民 主 是 其 首 要 目 标 。 政 府 坚 持 自 由 的 国 内 市 场 并 且 建 立 开 放 的 外 部 市 场 ， 经 济 继 续 增 长 ， 但 国 内 生 产 总 值 相 当 不 稳 定 ， 因 为 金 融 危 机 经 常 对 它 造 成 强 烈 冲 击 。 而 在 大 多 数 人 尝 试 适 应 市 场 的 同 时 ， 少 数 掌 握 着 更 多 资 源 的 寡 头 却 变 得 更 富 有 ， 外 国 投 机 者 继 续 向 外 输 出 着 从 中 国 榨 取 来 的 资 源 。 民 主 党 在 公 共 生 活 的 所 有 领 域 ， 包 括 在 政 治 生 活 中 消 除 国 家 控 制 ， 使 得 反 对 派 能 够 半 自 由 的 进 行 活 动 ， 但 是 为 了 在 经 济 危 机 中 维 持 共 和 国 的 存 在 ， 当 局 对 激 进 组 织 采 取 了 无 情 的 打 压 。 中 华 民 主 共 和 国 ， 即 现 在 的 中 国 ， 保 持 着 自 由 民 主 的 政 权 。 与 美 国 的 关 系 仍 然 友 好 ， 与 苏 联 的 关 系 相 当 敌 对 。 美 国 仍 然 是 中 华 民 主 共 和 国 的 主 要 经 济 伙 伴 — — 成 为 世 界 市 场 的 一 个 年 轻 参 与 者 的 主 要 债 权 国 和 投 资 者 ， 该 市 场 对 发 达 国 家 的 依 赖 日 益 增 长 。 苏 联 逐 步 断 绝 与 中 国 的 贸 易 关 系 ， 并 加 强 其 在 中 苏 边 境 的 军 事 存 在 。";
					}
					if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 能 够 维 持 部 分 人 民 ， 特 别 是 工 人 阶 级 的 支 持 ， 保 持 其 队 伍 的 团 结 和 党 的 路 线 ， 在 民 主 党 执 政 期 间 与 民 主 主 义 者 的 决 定 性 对 抗 ， 使 整 个 反 对 派 在 中 国 共 产 党 周 围 团 结 起 来 。 然 而 ， 中 国 共 产 党 的 活 动 受 到 许 多 法 院 判 决 的 严 重 限 制 ， 一 些 领 导 人 因 各 种 （ 明 显 是 虚 假 的 ） 指 控 而 被 捕 。";
					}
					else if (GlobalScript.inst.gameState.data[1] >= 500)
					{
						fake_text += " 在 大 选 失 利 之 后 ， 中 国 共 产 党 仍 然 拥 有 众 多 选 民 的 支 持 ， 党 内 团 结 依 旧 ， 党 的 路 线 也 仍 然 被 人 认 可 。 于 是 中 国 民 主 党 允 许 中 国 共 产 党 作 为 一 个 政 治 上 “ 有 建 设 性 的 反 对 党 ” 和 中 国 民 主 党 以 及 中 国 致 公 党 组 成 政 治 联 盟 。";
					}
					else
					{
						fake_text += " 在 选 举 中 失 利 的 中 国 共 产 党 无 法 维 持 党 内 的 团 结 ， 同 时 失 去 了 大 部 分 人 民 的 支 持 ， 分 裂 成 了 三 个 党 。 在 中 国 民 主 党 执 政 期 间 ， 前 者 与 其 结 为 联 盟 ， 后 两 者 支 持 反 对 派 。 最 后 ， 在 三 年 后 ， 后 两 者 重 新 合 并 为 一 个 新 的 中 国 共 产 党 ， 但 是 ， 共 产 主 义 在 中 国 的 复 兴 仍 然 遥 遥 无 期 …";
					}
				}
			}
		}
		else if (GlobalScript.inst.gameState.data[35] == 1)
		{
			name.text = "Восстание";
			fake_text = "Ваша политика стала всё больше злить народ Китая. Когда вы попытались всеми возможными средствами успокоить разрастающиеся протесты, это вам не удалось и народ начал открытое восстание, на сторону которого быстро перешли армия и часть партии. Арестовав и судив вас прежде, чем страна успела погрузиться в хаос, партийная верхушка и генералы объявили о создании временного правительства. Будущее Китая туманно...";
		}
		else if (GlobalScript.inst.gameState.data[35] == 2)
		{
			name.text = "Партийный переворот";
			fake_text = "Ваши действия стали всё больше злить партаппарат. Устав от вас, верхушка партии организовала съезд, на котором раскритиковала вас и проголосовала за вашу отставку и исключение. Вы теперь - никому не нужный пенсионер, а на вашем бывшем месте сидит компромиссный кандидат, пытающийся лавировать между враждующими фракциями.";
		}
		else if (GlobalScript.inst.gameState.data[35] == 3)
		{
			name.text = "Ядерная война";
			fake_text = "Добравшись до заветной красной кнопки, вы запустили ракеты. Ваш удар разрушил хрупкое равновесие между США и СССР и вслед за вами те тоже обменялись ядерными ударами. Большинство городов уничтожено, планета загрязнена, а большинство выживших спустились в бункеры и бомбоубежища. ";
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				achieves.GetComponent<achievements>().Set(18);
			}
		}
		else if (GlobalScript.inst.gameState.data[35] == 4)
		{
			name.text = "Геноцид";
			fake_text = "За время вашего правления население Китая - некогда самой густонаселённой страны - катастрофически снизилось. Это не могло остаться незамеченным, вас всё чаще открыто обвиняли в геноциде, и в конце концов, когда партия окончательно от этого устала, вас арестовали и отправили под трибунал. ";
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				achieves.GetComponent<achievements>().Set(49);
			}
		}
		else if (GlobalScript.inst.gameState.data[35] == 6)
		{
			name.text = "За каждой машиной - человек";
			fake_text = "Товарищ " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " решил избежать возможного кровопролития и добровольно подал в отставку по состоянию здоровья. На смену старых лидеров пришли новые, но уже гораздо менее инициативные. Во внутренней была ужесточена цензура, а любые отклонения от генеральной линии тотально пресекаются. МЭСУ был ограничен автоматизацией производства и вооружённых сил, а за каждой машиной отныне стоит человек, поэтому государственный аппарат пришлось даже значительно увеличить. Даже, несмотря на это, экономка КНР развивается, но с каждым годом темпы роста всё падают и падают и когда-нибудь все проблемы китайской экономики всплывут на поверхность. Будущее Китая туманно.";
		}
		else if (GlobalScript.inst.gameState.data[35] == 7)
		{
			name.text = GlobalScript.inst.new_events_text[533];
			fake_text = GlobalScript.inst.new_events_text[534];
		}
		else if (GlobalScript.inst.gameState.data[35] == 5)
		{
			if (GlobalScript.inst.gameState.iron_and_blood)
			{
				achieves.GetComponent<achievements>().Set(55);
			}
			name.text = "Новый порядок";
			if (GlobalScript.inst.gameState.party_number[0] > GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] > GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] > GlobalScript.inst.gameState.party_number[4])
			{
				fake_text = "Прошедшие выборы в ВСНП не принесли успеха КПК, и победу, на волне популизма, одержали радикальные коммунисты из МКПК, набрав относительное большинство голосов. Кандидат от МКПК одержал победу так же и на президентских выборах. Пользуясь должностью президента, а также относительным большинством в парламенте, МКПК сформировала квазикоалиционное правительство, в котором представители иных партий получили только 3 незначительных поста. Новое правительство объявило своей целью возвращение к маоизму, построение социализма и коммунизма в Китае и во всём мире, вступив в решительное противостояние с советскими ревизионистами и американскими империалистами. В рамках политики возвращения к социализму, в первую очередь, было принято решение вернуться к однопартийности, уничтожив буржуазную республику и развернув новую Культурную революцию против ревизионистов и капиталистов. В список ревизионистов и капиталистов попали все партии, за исключением МКПК. Иные партии попытались было организовать публичные акции против маоистов и их политики, призвав в свою поддержку США и СССР, однако данное начинание было подавлено силами милиции при поддержке армии и вооружённой молодёжи из боевой организации МКПК. В ответ на это маоисты организовали в свою поддержку куда более многочисленные митинги по всей стране, куда силой сгоняли всех попавшихся под руку в поддержку дела Председателя Мао. Народ, ведомый государством и партией, разгромил штаб-квартиры оппозиционных партий, а их руководители и активисты были частью убиты, частью - высланы в деревню. Лидерам КПК тоже не удалось избежать справедливого народного гнева: руководители были подвергнуты 'коридору позора', после чего публично сознались в ревизионизме, в чём тут же и раскаялись, а затем были сосланы в народные коммуны. США и СССР осудили подобные действия, в китайское правительство извинилось, переложив ответственность на радикалов, заявив, что “не смогло сдержать народную ярость, и не стремилось препятствовать народу в борьбу с его врагами, боясь подвергнуть честных людей опасности”. Тем не менее, когда оппозиция была уничтожена, Вооружённые Силы вошли в Пекин и другие крупные города и разогнали с боем не желающие отдавать власть в руки государства боевые организации МКПК, которые официально добровольно самораспустились. Начинается новая эпоха в истории Китая, в которой экономические реформы будут сочетаться с крайним усилением власти государства над обществом и партии над государством в деле борьбы за китайскую социалистическую культуру и построение социализма и коммунизма через диктатуру, тотальный контроль и продвигаемую с их помощью новую культуру беззаветной преданности Мао, идеологии и партии, искореняя консервативный традиционализм и либеральный плюрализм.";
			}
			else if (GlobalScript.inst.gameState.party_number[0] > 1500)
			{
				fake_text = "Прошедшие выборы в ВСНП не принесли успеха КПК, и победу на парламентских выборах одержали радикальные коммунисты из МКПК, набрав абсолютное большинство голосов на волне популизма. Кандидат от МКПК одержал победу так же и на президентских выборах. Пользуясь должностью президента, а также абсолютным большинством в парламенте, МКПК сформировала однородное правительство. Новое правительство объявило своей целью возвращение к маоизму, построение социализма и коммунизма в Китае и во всём мире, вступив в решительное противостояние с советскими ревизионистами и американскими империалистами. В рамках политики возвращения к социализму, в первую очередь, было предпринято решение вернуться к однопартийности, уничтожив буржуазную республику и развернув новую Культурную революцию против ревизионистов и капиталистов. В список ревизионистов и капиталистов попали все партии, за исключением МКПК. Другие партии попытались организовать публичные акции против маоистов и их политики, призвав в свою поддержку США и СССР, однако данное начинание было подавлено силами милиции при поддержке армии и вооружённой молодёжи из боевой организации МКПК. В ответ на это маоисты организовали в свою поддержку куда более многочисленные митинги по всей стране, куда силой сгоняли всех попавшихся под руку в поддержку дела Председателя Мао. Народ, ведомый государством и партией, разгромил штаб-квартиры оппозиционных партий, а их руководители и активисты были частью убиты, частью - высланы в деревню. Руководству КПК тоже не удалось избежать справедливого народного гнева: руководители партии были подвергнуты 'коридору позора', после чего сознались в ревизионизме, в чём тут же и раскаялись, а затем были сосланы в народные коммуны. США и СССР осудили подобные действия, китайское правительство извинилось, переложив ответственность на радикалов, заявив, что “не смогло сдержать народную ярость, и не стремилось препятствовать народу в борьбу с его врагами, боясь подвергнуть честных людей опасности”. Тем не менее, когда оппозиция была уничтожена, Вооружённые Силы вошли в Пекин и другие крупные города и разогнали с боем не желающие отдавать власть в руки государства боевые организации МКПК, которые официально добровольно самораспустились. Начинается новая эпоха в истории Китая, в которой экономические реформы будут сочетаться с крайним усилением власти государства над обществом и партии над государством в деле борьбы за китайскую социалистическую культуру и построение социализма и коммунизма через диктатуру, тотальный контроль и продвигаемую с их помощью новую культуру беззаветной преданности Мао, идеологии и партии, искореняя консервативный традиционализм и либеральный плюрализм.";
			}
			else if (GlobalScript.inst.gameState.party_number[4] > 1500)
			{
				if (GlobalScript.inst.gameState.data[14] < 4)
				{
					fake_text = "Новое либерал-демократическое правительство Китая объявило своей первостепенной и важнейшей целью победу над старым порядком и либерализацию режима. Правительство провело экономические реформы в сторону свободного рынка, что нанесло серьёзный удар по экономике, вызывая дезорганизацию через распад старых связей, однако  борьба с коррупцией и махинациями со стороны молодого гражданского общества в совокупности с  кредитами и огромными инвестициями со стороны США и Запада позволили постепенно справиться с ситуацией, войдя в состояние определенного роста, который несколько компенсирует былой упадок и даже позволяет говорить о кое-каких успехах в области экономического роста и увеличения общественного богатства, однако огромная доля дохода сосредотачивается в руках узкой группы лиц - зарождающейся олигархии, в то время, как миллионы людей покидают Китай, надеясь найти лучшую жизнь за границей. ДПК ликвидирует государственный контроль во всех областях общественной жизни, включая и политическую, где создана возмоность для функционированя незначительной оппозиции. В Демократической республике Китай, как теперь называется страна, формируется режим либеральной демократии. Отношения с США становятся дружескими, а с СССР ухудшаются. США становятся главным экономическим партнёром КНР, основным кредитором и инвестором молодого участника мирового рынка, зависимость которого от развитых стран все возрастает. СССР постепенно разрывает с КНР торговые отношения и увеличивает военное присутствие на советско-китайской границе.";
				}
				else
				{
					fake_text = "Новое либерал-демократическое правительство Китая объявило своей первостепенной и важнейшей целью укрепление и совершенствование демократии. Правительство сохранило курс на свободный внутри и открытый вовне рынок, экономика продолжает расти, но уже с довольно нестабильным показателем ВВП, ведь кризисы сильно сотрясают её время от времени и пока большая часть населения пытается вписаться в рынок, узкая группа лиц становится только богаче, а иностранные инвесторы продолжают выкачивать из страны ресурсы. ДПК оберегает свободу во всех областях общественной жизни, в том числе и в политической, создавая условия для полусвободной деятельности оппозиции, хотя в период кризисов имеет место сильное административное давление на радикальные организации. В Демократической республике Китай, как теперь называется страна, сохраняется режим либеральной демократии. Отношения с США остаются дружескими, а с СССР - скорее враждебными. США остаются главным экономическим партнёром ДРК, основным кредитором и инвестором молодого участника мирового рынка, зависимость которого от развитых стран всё возрастает. СССР постепенно разрывает с КНР торговые отношения и увеличивает военное присутствие на советско-китайской границе.";
				}
				if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения, особенно рабочего класса, и единство в своих рядах, а линия партии и решительное противостояние с демократами во время власти ДПК сплотило всю оппозицию вокруг КПК. Однако деятельность КПК была сильно ограничена рядом судебных постановлений, а несколько её руководителей по различным (и явно ложным) обвинениям были арестованы.";
				}
				else if (GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения и единство в своих рядах, а линия партии и определенная поддержка либеральной политики ДПК позволили КПК остаться в политике в качестве 'конструктивной оппозиции', через несколько лет объединившись с ДПК и КПСС в коалиционный блок.";
				}
				else
				{
					fake_text += "Проигравшая выборы КПК не смогла сохранить единство в своих рядах, а вместе с тем утратила поддержку значительной части населения и пережила раскол на три партии. В период власти ДПК одна из них поддержала демократов, а две - оппозицию. Последние через несколько лет воссоединились, восстановив КПК, но до полного возрождения китайским коммунистам ещё очень далеко...";
				}
			}
			else if (GlobalScript.inst.gameState.party_number[3] > GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[3] > GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[3] > GlobalScript.inst.gameState.party_number[4])
			{
				if (GlobalScript.inst.gameState.data[14] < 4)
				{
					fake_text = "Новое социал-патриотическое правительство КНР объявило своей первостепенной и важнейшей целью сохранение государственного единства при многонациональности и устойчивом росте общественного процветания. Правительство также объявило об экономических реформах в сторону социально-ориентированной рыночной экономики, что наносит серьёзный удар по экономике, вызывая дезорганизацию через распад старых связей, а попытка сохранить социальное обеспечение приводит к дефициту бюджета и окончательному краху китайской экономики, подпитываемому повсеместным всплеском коррупции и махинаций, и только кредиты и инвестиции со стороны США и Запада позволяют наконец справиться с ситуацией, войдя в состояние быстрого роста, который частично компенсирует былой упадок и даже позволяет говорить об определённых успехах в области экономического роста и увеличении общественного богатства, однако огромная доля дохода покидает КНР в пользу её экономических партнёров. В условиях необходимости сохранения государственного единства, КПСС идёт на федерализацию и дальнейшие демократические реформы, внедряя больше свободы во всех областях при сохранении государственного регулирования. В КНР формируется режим социализма с китайской спецификой. Отношения с США теплеют, а с СССР холодеют. США становятся главным экономическим партнёром КНР, основным кредитором и инвестором молодого участника мирового рынка, зависимость которого от развитых стран возрастает, но в то же время в рамках углубления сотрудничества ведутся переговоры о возвращении Гонконга и Макао, статусе Тайваня, которые, кажется, закончатся компромиссом в пользу КНР. СССР продолжает переговоры с КНР об установлении полноценных дипломатических отношений, однако КНР, подначиваемая США, требует территориальных уступок, а СССР раз за разом отвечает отказом.";
				}
				else
				{
					fake_text = "Новое социал-патриотическое правительство КНР объявило своей первостепенной и важнейшей целью сохранение государственного единства при многонациональности и устойчивом росте общественного процветания. Правительство также объявило об экономических реформах в сторону социально-ориентированной рыночной экономики, что ведёт к увеличению государственного сектора, усилению государственного контроля и росту налогов для высшего класса, нанося удар по экономическому росту, вызывая сокращение внутренних и внешних инвестиций и общую неблагоприятную для предпринимателей обстановку на рынке, однако в то же время и подъём уровня общественного богатства за счёт увеличения государственных вложений в социальное обеспечение. В условиях необходимости сохранения государственного единства, КПСС следует принципам федерализма и демократии, усиливая при этом патриотическую агитацию в государственных СМИ. В КНР формируется режим социализма с китайской спецификой. Отношения с США холодеют, а с СССР теплеют. США сокращают кредиты и инвестиции, выбирая для этих целей другие страны, а переговоры о возвращении Гонконга и Макао, статусе Тайваня, заходят в тупик. СССР продолжает переговоры с КНР об установлении полноценных дипломатических отношений и добивается успеха: КНР отказывается от своих территориальных требований, а СССР направляет в КНР специалистов, выдаёт целый ряд больших беспроцентных кредитов.";
				}
				if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения и единство в рядах своих членов, а линия партии и решительное сопротивление излишне мягкой во всех смыслах политике КПСС сделали её главной радикально-оппозиционной силой. КПК продолжает свою политическую борьбу против КПСС, оставаясь парламентской партией и при этом прибегая к многочисленным способом противостояния, не ограничиваясь участием в выборах и агитацией, нередко устраивая радикально-оппозиционные публичные акции.";
				}
				else if (GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения и единство в рядах своих членов, а линия партии и решительное противостояние излишне социалистической во всех смыслах политике КПСС сделали её главной демократически-оппозиционной силой. КПК продолжает свою политическую борьбу против КПСС, не ограничиваясь участием в выборах и агитацией, нередко устраивая демократически-оппозиционные публичные акции.";
				}
				else
				{
					fake_text += "Проигравшая выборы КПК не смогла сохранить единство в рядах своих членов, а вместе с тем утратила поддержку населения и распалась на несколько независимых и противоположных партий почти сразу же после поражения. В период власти КПСС часть из них поддержала радикалов, часть - КПСС, а часть - демократов. В конечном итоге все части вошли в состав других, более крупных и сплочённых партий или так и остались небольшими разрозненными группами, не имеющими реального влияния на политику.";
				}
			}
			else if (GlobalScript.inst.gameState.party_number[3] > 1500)
			{
				if (GlobalScript.inst.gameState.data[14] < 4)
				{
					fake_text = "Новое  правительство КНР, пришедшее к власти путем обещаний стабильного процветания, объявило своей первостепенной и важнейшей целью сохранение всенародного единства при более внимательном рассмотрении проблем национального вопроса и устойчивом росте общественного процветания. Правительство также объявило об экономических реформах в сторону социально-ориентированной рыночной экономики, что наносит определенный удар по экономике, вызывая дезорганизацию через распад старых связей, но гораздо меньше, чем ожидалось, что позволило более-менее минимизировать последствия (тем не менее, по уровню жизни значительной части населения это ударило). В условиях необходимости сохранения государственного единства, КПСС идёт на федерализацию и дальнейшие демократические реформы, внедряя больше свободы во всех областях при сохранении государственного регулирования. В КНР формируется режим социализма с китайской спецификой. Отношения с США теплеют, а с СССР холодают. США становятся главным экономическим партнёром КНР, основным кредитором и инвестором молодого участника мирового рынка, зависимость которого от развитых стран возрастает, но в то же время в рамках углубления сотрудничества ведутся переговоры о возвращении Гонконга и Макао, и особом статусе Тайваня, которые, кажется, закончатся компромиссом в пользу КНР. СССР продолжает переговоры с КНР об восстановлении полноценных дипломатических отношений, однако КНР, подначиваемая США, требует территориальных уступок, а СССР раз за разом отвечает отказом.";
				}
				else
				{
					fake_text = "Новое социал-патриотическое правительство КНР объявило своей первостепенной и важнейшей целью сохранение государственного единства при многонациональности и устойчивом росте общественного процветания. Правительство также объявило об экономических реформах в сторону социально-ориентированной рыночной экономики, что ведёт к увеличению государственного сектора, усилению государственного контроля и росту налогов для высшего класса, нанося некоторый удар по экономическому росту, вызывая сокращение внутренних и внешних инвестиций и общую неблагоприятную для предпринимателей обстановку на рынке, однако в то же время и подъём уровня общественного богатства за счёт увеличения государственных вложений в социальное обеспечение. В условиях необходимости сохранения государственного единства, КПСС следует принципам федерализма и демократии, усиливая при этом патриотическую агитацию в государственных СМИ. В КНР формируется режим социализма с китайской спецификой. Отношения с США холодеют, а с СССР теплеют. США сокращают кредиты и инвестиции, выбирая для этих целей другие страны, а переговоры о возвращении Гонконга и Макао, статусе Тайваня, заходят в тупик по последнему пункту, но с первыми двумя постепенно идут к успеху. СССР продолжает переговоры с КНР об восстановлении полноценных дипломатических отношений и добивается успеха: КНР отказывается от своих территориальных требований, а СССР направляет в КНР специалистов, выдаёт целый ряд больших беспроцентных кредитов.";
				}
				if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку значительной части населения, особенно рабочего класса, и единство в своих рядах, а линия партии и решительное сопротивление излишне мягкой во всех смыслах политике КПСС сделали её главной оппозиционной силой. КПК продолжает свою политическую борьбу против КПСС, оставаясь парламентской партией и при этом прибегая к многочисленным способом противостояния, не ограничиваясь участием в выборах и агитацией, нередко устраивая публичные акции.";
				}
				else if (GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения и единство в своих рядах, а линия партии и решительное противостояние излишне осторожной политике КПСС сделали её главной демократически-оппозиционной силой. КПК продолжает свою политическую борьбу против КПСС, не ограничиваясь участием в выборах и агитацией, нередко устраивая публичные акции.";
				}
				else
				{
					fake_text += "Проигравшая выборы КПК не смогла сохранить единство в своих рядах, а вместе с тем утратила поддержку населения и распалась на две партии. В период власти КПСС первая вошла с ней в коалицию, а вторая - поддержала оппозицию. В конечном итоге, обе партии воссоединились через 3 года, восстановив единую КПК, однако китайским коммунистам ещё долго придется восстанавливать свое влияние по всей необъятной стране...";
				}
			}
			else if (GlobalScript.inst.gameState.party_number[2] > GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[2] > GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] > GlobalScript.inst.gameState.party_number[4])
			{
				if (GlobalScript.inst.gameState.iron_and_blood)
				{
					achieves.GetComponent<achievements>().Set(22);
				}
				if (GlobalScript.inst.gameState.data[14] < 4)
				{
					fake_text = "Новое правительство Китая объявило своей первостепенной и важнейшей целью сохранение национального единства Китая, а также возвращение утраченных территорий - Гонконга, Макао и Тайваня. Правительство также объявило об экономических реформах в сторону расширения частной инициативы при сохранении государственного контроля, а также допущении ограниченных иностранных инвестиций, что даёт толчок экономическому росту, однако вместе с этим возрастают коррупция и махинации, а образовавшийся доход идёт на расширение и улучшение содержания государственного аппарата и социального обеспечения, что в краткосрочной перспективе позволяет усилить государство и поднять уровень жизни населения, однако препятствует дальнейшему росту и замедляет развитие экономики. В условиях национальной раздробленности было решено усилить национальное государство, что повлекло за собой неформальные репрессии в отношении оппозиционных федералистов из КПСС и либералов из ДПК, а также установление мощного государственного контроля в СМИ, выступающих с агрессивной националистической пропагандой, при всё таком же неформальном запрете на любые несанкционированные публичные акции. Не встретив почти никакого сопротивления, в КНР сформировался режим левой имитационной демократии. Отношения с США и СССР остаются всё такими же напряжёнными и недружественными. Тем не менее, США не обошли стороной возможность выгодных вложений, подтолкнув своих союзников к началу переговоров о возвращении утраченных Гонконга и Макао и статусе Тайваня, которые, впрочем, сильно пробуксовывают из-за напряженных отношений между РКГ и, собственно, Гоминьданом. СССР, в свою очередь, продолжил переговоры с КНР об восстановлении полноценных дипломатических отношений, однако КНР требует территориальных уступок, на что СССР не согласен, и переговоры также постепенно заходят в тупик.";
				}
				else
				{
					fake_text = "Новое правительство КНР объявило своей первостепенной и важнейшей целью сохранение национального единства Китая, а также возвращение утраченных территорий - Гонконга, Макао и Тайваня. Правительство также объявило об экономических контрреформах в сторону сокращения частной инициативы, усиления государственного контроля, а также ограничении иностранных инвестиций, что приводит к снижению экономического роста в совокупности с ростом коррупции и махинаций, слиянии предпринимательства и государственного аппарата, однако даёт государству доступ к большим ресурсам, которые, в основном, идут на расширение и улучшение содержания государственного аппарата и социального обеспечения, что в краткосрочной перспективе позволяет усилить государство и поднять уровень жизни населения, однако препятствует дальнейшему росту и замедляет развитие экономики. В условиях национальной раздробленности было решено усилить национальное государство, что повлекло за собой неформальные репрессии в отношении оппозиционных федералистов из КПСС и либералов из ДПК, а также установление мощного государственного контроля в СМИ, выступающих с агрессивной националистической повесткой, при всё таком же неформальном запрете на любые несанкционированные публичные акции. Оппозиция была подавлена или подкуплена, в КНР сформировался режим левой имитационной демократии. Отношения с США и СССР заметно ухудшились. США в ответ на контреформы начали постепенный вывод вложений и подтолкнули своих союзников к совместному усилению западного военного присутствия в Гонконге, Макао и на Тайваня, которые КНР считает своими. СССР в ответ на контреформы назвал Китай социал-фашистским государством, также увеличив своё военное присутствие на спорных с КНР территориях.";
				}
				if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку немалой части населения и единство в своих рядах, а линия партии и решительная поддержка РКГ в период контрреформ позволили ей остаться в политике, став одной из легальных оппозиционных партий. КПК продолжает свою деятельность, голосуя в парламенте, проводя агитацию в свою пользу и организуя акции, решительно поддерживая РКГ и лишь изредка выступая с критикой в адрес отдельных её представителей.";
				}
				else if (GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения и единство в своих рядах, а линия партии и решительное противостояние с РКГ в период контрреформ сплотила всю оппозицию вокруг КПК. Однако, в ответ на это, деятельность КПК была сильно ограничена рядом судебных решений, а часть её руководителей по различным (и явно ложным) обвинениям была арестована.";
				}
				else
				{
					fake_text += "Проигравшая выборы КПК не смогла сохранить единство в своих рядах, а вместе с тем утратила поддержку населения и распалась на четыре партии. В период контрреформ одна из них поддержала РКГ, а три - оппозицию. Первая через несколько лет влилась в состав РКГ, вторая объединилась с третьей, восстановив КПК, а четвертая осталась самостоятельной партией, оппозиционной правящему режиму.";
				}
			}
			else if (GlobalScript.inst.gameState.party_number[2] > 1500)
			{
				if (GlobalScript.inst.gameState.data[14] < 4)
				{
					fake_text = "Новое правительство Китая объявило своей первостепенной и важнейшей целью сохранение национального единства Китая, а также возвращение утраченных территорий - Гонконга, Макао и Тайваня. Правительство также объявило об экономических реформах в сторону расширения частной инициативы при сохранении государственного контроля, а также допущении ограниченных иностранных инвестиций, что даёт толчок экономическому росту, однако вместе с этим возрастают коррупция и махинации, а образовавшийся доход идёт на расширение и улучшение содержания государственного аппарата и социального обеспечения, что в краткосрочной перспективе позволяет усилить государство и поднять уровень жизни населения, однако препятствует дальнейшему росту и замедляет развитие экономики. В условиях национальной раздробленности было решено усилить национальное государство, что повлекло за собой неформальные репрессии в отношении оппозиционных федералистов из КПСС и либералов из ДПК, а также установление мощного государственного контроля в СМИ, выступающих с агрессивной националистической пропагандой, при всё таком же неформальном запрете на любые несанкционированные публичные акции. Не встретив почти никакого сопротивления, в КНР сформировался режим левой имитационной демократии. Отношения с США и СССР остаются всё такими же напряжёнными и недружественными. Тем не менее, США не обошли стороной возможность выгодных вложений, подтолкнув своих союзников к началу переговоров о возвращении утраченных Гонконга и Макао и статусе Тайваня, которые, впрочем, сильно пробуксовывают из-за напряженных отношений между РКГ и, собственно, Гоминьданом. СССР, в свою очередь, продолжил переговоры с КНР об восстановлении полноценных дипломатических отношений, однако КНР требует территориальных уступок, на что СССР не согласен, и переговоры также постепенно заходят в тупик.";
				}
				else
				{
					fake_text = "Новое правительство КНР объявило своей первостепенной и важнейшей целью сохранение национального единства Китая, а также возвращение утраченных территорий - Гонконга, Макао и Тайваня. Правительство также объявило об экономических контрреформах в сторону сокращения частной инициативы, усиления государственного контроля, а также ограничении иностранных инвестиций, что приводит к снижению экономического роста в совокупности с ростом коррупции и махинаций, слиянии предпринимательства и государственного аппарата, однако даёт государству доступ к большим ресурсам, которые, в основном, идут на расширение и улучшение содержания государственного аппарата и социального обеспечения, что в краткосрочной перспективе позволяет усилить государство и поднять уровень жизни населения, однако препятствует дальнейшему росту и замедляет развитие экономики. В условиях национальной раздробленности было решено усилить национальное государство, что повлекло за собой неформальные репрессии в отношении оппозиционных федералистов из КПСС и либералов из ДПК, а также установление мощного государственного контроля в СМИ, выступающих с агрессивной националистической повесткой, при всё таком же неформальном запрете на любые несанкционированные публичные акции. Оппозиция была подавлена или подкуплена, в КНР сформировался режим левой имитационной демократии. Отношения с США и СССР заметно ухудшились. США в ответ на контреформы начали постепенный вывод вложений и подтолкнули своих союзников к совместному усилению западного военного присутствия в Гонконге, Макао и на Тайваня, которые КНР считает своими. СССР в ответ на контреформы назвал Китай социал-фашистским государством, также увеличив своё военное присутствие на спорных с КНР территориях.";
				}
				if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку немалой части населения и единство в своих рядах, а линия партии и решительная поддержка РКГ в период контрреформ позволили ей остаться в политике, став одной из легальных оппозиционных партий. КПК продолжает свою деятельность, голосуя в парламенте, проводя агитацию в свою пользу и организуя акции, решительно поддерживая РКГ и лишь изредка выступая с критикой в адрес отдельных её представителей.";
				}
				else if (GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения и единство в своих рядах, а линия партии и решительное противостояние с РКГ в период контрреформ сплотила всю оппозицию вокруг КПК. Однако, в ответ на это, деятельность КПК была сильно ограничена рядом судебных решений, а часть её руководителей по различным (и явно ложным) обвинениям была арестована.";
				}
				else
				{
					fake_text += "Проигравшая выборы КПК не смогла сохранить единство в своих рядах, а вместе с тем утратила поддержку населения и распалась на четыре партии. В период контрреформ одна из них поддержала РКГ, а три - оппозицию. Первая через несколько лет влилась в состав РКГ, вторая объединилась с третьей, восстановив КПК, а четвертая осталась самостоятельной партией, оппозиционной правящему режиму.";
				}
			}
			else
			{
				if (GlobalScript.inst.gameState.data[14] < 4)
				{
					fake_text = "Новое либерал-демократическое правительство Китая объявило своей первостепенной и важнейшей целью победу над старым порядком и либерализацию режима. Правительство провело экономические реформы в сторону свободного рынка, что нанесло серьёзный удар по экономике, вызывая дезорганизацию через распад старых связей, однако борьба с коррупцией и махинациями со стороны молодого гражданского общества в совокупности с кредитами и инвестициями со стороны США и Запада позволили со временем справиться с ситуацией, войдя в состояние экономического роста, который несколько компенсирует былой упадок и даже позволяет говорить о определенных успехах в области экономического роста и увеличении общественного богатства, однако подавляющая часть дохода сосредотачивается в руках узкой группы лиц - зарождающейся олигархии, в то время, как сотни тысяч людей покидают Китай, надеясь найти лучшую жизнь за границей. ДПК ликвидирует государственный контроль во всех областях общественной жизни, включая и политическую, где всякие препятствия для свободной деятельности оппозиции ликвидируются. В Демократической республике Китай, как теперь называется страна, формируется режим либеральной демократии. Отношения с США становятся дружескими, а с СССР постепенно ухудшаются. США становятся главным экономическим партнёром КНР, основным кредитором и инвестором молодого участника мирового рынка, зависимость которого от развитых стран возрастает. СССР же постепенно разрывает с КНР торговые отношения и увеличивает военное присутствие на советско-китайской границе. Новые власти уже начинают переговоры с Тайванем об восстановлении единства страны, благо что все противоречия между ними устранены.";
				}
				else
				{
					fake_text = "Новое либерал-демократическое правительство Китая объявило своей первостепенной и важнейшей целью укрепление и совершенствование демократии. Правительство сохранило курс на свободный внутри и открытый вовне рынок, экономика продолжает расти, но уже с довольно нестабильным показателем ВВП, ведь кризисы сильно сотрясают её время от времени и пока большая часть населения пытается вписаться в рынок, узкая группа лиц становится только богаче, а иностранные инвесторы продолжают выкачивать из страны ресурсы. ДПК оберегает свободу во всех областях общественной жизни, в том числе и в политической, создавая условия для полусвободной деятельности оппозиции, хотя в период кризисов имеет место сильное административное давление на радикальные организации. В Демократической республике Китай, как теперь называется страна, сохраняется режим либеральной демократии. Отношения с США остаются дружескими, а с СССР - скорее враждебными. США остаются главным экономическим партнёром ДРК, основным кредитором и инвестором молодого участника мирового рынка, зависимость которого от развитых стран всё возрастает. СССР постепенно разрывает с КНР торговые отношения и увеличивает военное присутствие на советско-китайской границе.";
				}
				if (GlobalScript.inst.gameState.data[54] < 40 && GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения, особенно рабочего класса, и единство в своих рядах, а линия партии и решительное противостояние с демократами во время власти ДПК сплотило всю оппозицию вокруг КПК. Однако деятельность КПК была сильно ограничена рядом судебных постановлений, а несколько её руководителей по различным (и явно ложным) обвинениям были арестованы.";
				}
				else if (GlobalScript.inst.gameState.data[1] >= 500)
				{
					fake_text += "Проигравшая выборы КПК смогла сохранить поддержку части населения и единство в своих рядах, а линия партии и определенная поддержка либеральной политики ДПК позволили КПК остаться в политике в качестве 'конструктивной оппозиции', через несколько лет объединившись с ДПК и КПСС в коалиционный блок.";
				}
				else
				{
					fake_text += "Проигравшая выборы КПК не смогла сохранить единство в своих рядах, а вместе с тем утратила поддержку значительной части населения и пережила раскол на три партии. В период власти ДПК одна из них поддержала демократов, а две - оппозицию. Последние через несколько лет воссоединились, восстановив КПК, но до полного возрождения китайским коммунистам ещё очень далеко...";
				}
			}
		}
		text_t.text = Text(fake_text, 91);
	}

	private void MakeScrollable(ref int stroki)
	{
		float focus_down = text_t.characterSize * -1f * (float)stroki + startTextPosition;
		text_t.transform.position = new Vector3(text_t.transform.position.x, startTextPosition, text_t.transform.position.z);
		name.transform.position = new Vector3(name.transform.position.x, startNamePosition, name.transform.position.z);
		scrollComponent.GetComponent<ScrollScript>().MakeThings(name.transform.position.y, focus_down);
	}

	private string Text(string text, int col)
	{
		int num = 0;
		int stroki = 1;
		string text2 = "";
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == char.Parse("|"))
			{
				num = 0;
				text2 += "\n";
				stroki++;
			}
			else if (num >= col)
			{
				if (text[i] == char.Parse(" "))
				{
					num = 0;
					text2 += "\n";
					stroki++;
					continue;
				}
				text2 += text[i];
				for (int num2 = i; num2 >= 0; num2--)
				{
					if (text2[num2] == char.Parse(" "))
					{
						text2 = text2.Substring(0, num2) + "\n" + text2.Substring(num2 + 1, text2.Length - 1 - (num2 + 1) + 1);
						stroki++;
						num = text2.Length - 1 - (num2 + 1) + 1;
						break;
					}
				}
			}
			else
			{
				text2 += text[i];
				num++;
			}
		}
		MakeScrollable(ref stroki);
		return text2;
	}

	private void ledaer_na()
	{
		if (GlobalScript.inst.gameState.empires[1].now_leader != 6)
		{
			return;
		}
		if (GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.empires[0].power && GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.influencePRC)
		{
			if (GlobalScript.inst.gameState.empires[0].power > GlobalScript.inst.gameState.influencePRC)
			{
				GlobalScript.inst.gameState.empires[1].power = GlobalScript.inst.gameState.empires[0].power + 10;
			}
			else
			{
				GlobalScript.inst.gameState.empires[1].power = GlobalScript.inst.gameState.influencePRC + 10;
			}
		}
		else
		{
			GlobalScript.inst.gameState.empires[1].power = 0;
		}
	}
}
