using EventsForDLC;
using UnityEngine;

public class Event587 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 提 格 拉 钦";
		text = " 主 席 同 志 ， 是 时 候 谈 谈 非 洲 （ 过 去 ） 最 古 老 的 君 主 制 国 家 埃 塞 俄 比 亚 了 。 自 1 9 7 4 年 的 军 事 政 变 以 来 ， 该 国 经 历 着 意 识 形 态 上 的 巨 大 变 化 。 从 资 本 主 义 的 支 持 者 到 激 进 共 产 主 义 分 子 ， 所 有 人 都 希 望 得 到 临 时 军 事 行 政 委 员 会 ， 也 就 是 <color=#2F4F4F>德 尔 格</color> 的 青 睐 。 除 了 平 庸 无 力 的 “ 埃 塞 俄 比 亚 第 一 ” 这 样 的 爱 国 口 号 外 ， 军 委 选 择 的 是 社 会 主 义 者 ， 他 们 积 极 和 <color=#8B0000>全 埃 塞 俄 比 亚 社 会 主 义 运 动</color> 和 <color=#8B0000>埃 塞 俄 比 亚 人 民 革 命 党</color> 展 开 合 作 。 其 中 ， <color=#8B0000>全 埃 社 运</color> 支 持 <color=#2F4F4F>临 时 军 委</color> ， 他 们 由 苏 联 留 学 生 和 工 人 构 成 。 而 <color=#8B0000>埃 塞 俄 比 亚 人 民 革 命 党</color> 义 正 严 辞 的 反 对 <color=#2F4F4F>临 时 军 委</color> 的 长 期 存 在 ， 呼 吁 快 速 建 立 一 个 先 锋 党 ， 他 们 支 持 毛 泽 东 主 席 的 理 论 ， 也 支 持 阿 尔 巴 尼 亚 的 反 修 正 主 义 思 想 。||在 1 9 7 5 年 9 月 1 1 日 ， <color=#2F4F4F>临 时 军 委</color> 正 式 宣 布 将 走 “ 埃 塞 俄 比 亚 特 色 的 共 产 主 义 道 路 ” 。 他 们 公 开 支 持 ， 鼓 励 各 个 社 会 主 义 和 共 产 主 义 政 党 加 入 群 众 组 织 临 时 办 公 室 。 以 <color=#006400>特 法 里 · 本 蒂</color> 准 将 为 首 的 温 和 派 <color=#2F4F4F>临 时 军 委</color> 成 员 甚 至 准 备 和 埃 人 革 党 达 成 协 议 ， 组 建 一 个 统 一 的 社 会 主 义 的 先 锋 党 ， 用 来 加 速 解 散 <color=#2F4F4F>临 时 军 委</color> 。 而 这 一 决 定 遭 到 了 实 权 人 物 <color=#2F4F4F>门 格 斯 图 · 海 尔 · 马 里 亚 姆</color> 的 抵 制 ， 绰 号 <color=#2F4F4F>“ 红 色 尼 格 斯 ”</color> 的 他 ， 曾 亲 手 处 死 了 第 一 任 临 时 军 委 主 席 阿 曼 · 迈 克 尔 · 安 多 姆 ， 而 他 并 不 介 意 再 次 扫 清 一 位 敌 人 。 他 在 担 任 副 主 席 的 时 候 ， 便 公 开 拉 偏 架 打 击 埃 人 革 党 。 纵 使 <color=#2F4F4F>门 格 斯 图</color> 本 人 也 不 反 对 组 建 一 支 革 命 的 先 锋 党 ， 但 <color=#2F4F4F>门 格 斯 图</color> 眼 里 容 不 得 沙 子 ， 为 此 他 大 力 支 持 由 自 己 领 导 的 “ 革 命 火 焰 ” 组 织 。 双 方 的 关 系 已 经 恶 化 到 了 极 点 。 <color=#006400>特 法 里 · 本 蒂</color> 多 次 在 会 议 上 指 控 <color=#2F4F4F>门 格 斯 图</color> 滥 杀 无 辜 ， 而 <color=#2F4F4F>门 格 斯 图</color> 则 以 “ 潜 在 的 帝 国 主 义 者 ” 为 理 由 攻 击 <color=#006400>特 法 里 · 本 蒂</color>   ， 并 派 遣 军 事 警 察 抓 捕 埃 人 革 党 成 员 。||主 席 同 志 ， 尽 管 有 些 泥 菩 萨 过 河 ， 但 我 们 至 少 该 表 个 态 ， 对 吧 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] <= 2)
		{
			button_text[0] = " 帮 本 蒂 一 把";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 们 不 愿 意 听 我 们 的 话";
		}
		if (a.data[56] != 0 && a.data[56] != 4)
		{
			button_text[1] = " 门 格 斯 图 ， 非 洲 的 列 宁 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 支 持 他 ？ 这 是 给 我 们 的 敌 人 递 子 弹 ！";
		}
		if (a.data[56] <= 1)
		{
			button_text[2] = " 游 击 战 士 会 把 他 们 双 双 埋 葬 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = "对 别 国 内 政 的 干 涉 太 夸 张 了";
		}
		button_text[3] = " 让 苏 联 人 自 个 头 疼 去 吧 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 提 格 拉 钦";
		if (result_num == 0)
		{
			text = " 我 们 在 人 民 日 报 上 发 表 了 这 样 一 片 文 章 ： 《 警 惕 伪 装 成 社 会 主 义 的 法 西 斯 主 义 者 》 ， 其 中 提 到 了 埃 塞 俄 比 亚 的 现 状 。 虚 假 的 公 有 制 政 策 ， 极 力 打 击 真 正 的 左 翼 政 党 ， 并 和 帝 国 主 义 者 沆 瀣 一 气 。 同 时 我 们 向 <color=#006400>特 法 里 · 本 蒂</color> 提 供 了 来 自 我 们 的 帮 助 ， 在 1 9 7 7 年 2 月 3 日 的 中 央 例 会 上 ， <color=#2F4F4F>门 格 斯 图</color> 向 军 委 主 席 本 蒂 准 将 汇 报 工 作 ， 在 一 旁 旁 听 的 提 格 雷 代 表 突 然 抄 起 板 凳 扔 向 <color=#2F4F4F>门 格 斯 图</color> ， 这 是 行 动 开 始 的 记 号 。 突 然 间 把 脸 涂 成 黑 色 的 中 国 特 工 和 埃 塞 俄 比 亚 人 民 解 放 军 战 士 从 会 场 后 方 杀 出 ， 在 激 烈 的 交 火 中 ， <color=#2F4F4F>门 格 斯 图</color> 身 中 十 七 枪 身 亡 。 随 后 ， <color=#006400>特 法 里 · 本 蒂</color> 在 电 视 上 发 表 了 特 别 报 告 ， 揭 露 了 <color=#2F4F4F>门 格 斯 图</color> 的 不 雅 往 事 ： 在 美 国 留 学 时 花 天 酒 地 ， 在 革 命 时 主 张 美 国 介 入 ； 出 卖 了 埃 塞 主 权 ； 接 纳 了 苏 联 的 政 治 献 金 ， 却 仅 仅 是 为 了 孩 子 能 上 莫 斯 科 大 学 。 综 上 所 述 ， 他 以 反 革 命 罪 缺 席 判 处 <color=#2F4F4F>门 格 斯 图</color> 死 刑 （ 尽 管 他 已 经 被 击 毙 了 ） 。||随 后 ， 他 在 电 视 讲 话 中 宣 读 了 惊 人 的 信 息 ， 他 宣 布 临 时 军 事 委 员 会 已 经 圆 满 完 成 了 民 族 民 主 革 命 的 阶 段 性 目 标 ， 临 时 军 委 将 自 行 解 散 。 并 会 组 建 <color=#8B0000>埃 塞 俄 比 亚 社 会 主 义 革 命 党 - 马 克 思 列 宁 主 义</color> ， 一 个 由 <color=#8B0000>埃 人 革 党</color> 和 左 翼 军 人 ， 贫 下 中 农 和 势 力 更 小 的 左 翼 政 党 组 成 的 新 党 。 在 第 一 届 全 埃 塞 工 农 兵 代 表 大 会 上 ， 他 被 选 举 为 名 誉 主 席 和 总 统 ， 而 <color=#8B0000>贝 尔 哈 纳 · 梅 斯 克 尔 · 雷 达</color> 则 当 选 为 新 任 党 主 席 。 该 党 秉 持 着 坚 实 的 毛 主 义 原 则 ， 并 加 速 深 化 土 地 革 命 运 动 ， 同 时 积 极 和 厄 立 特 里 亚 就 自 治 问 题 达 成 协 议 。 他 们 也 和 我 们 加 大 了 互 动 。";
			a.data[9] -= 50;
			a.allcountries[41].Gosstroy = 1;
			a.allcountries[41].SubGosstroy = 17;
			a.allcountries[41].LeaveAlliances();
			a.allcountries[41].Torg = true;
			a.allcountries[41].name = "埃 塞 俄 比 亚 民 主 联 邦 共 和 国";
		}
		if (result_num == 1)
		{
			text = " 我 们 决 定 支 持 埃 塞 俄 比 亚 的 实 权 人 物 <color=#2F4F4F>门 格 斯 图</color> 上 校 。 意 识 到 他 并 不 是 什 么 坚 定 的 革 命 者 ， 而 是 左 右 摇 摆 不 定 的 投 机 家 后 ， 这 使 得 我 们 更 容 易 接 触 到 他 。 在 数 盒 高 级 酒 心 巧 克 力 ， 2 0 瓶 3 5 年 茅 台 ， 5 0 0 w 打 到 他 私 人 账 户 上 的 美 元 ， 一 栋 在 北 戴 河 的 度 假 别 墅 和 给 她 女 儿 （ 尽 管 只 有 三 岁 ） 准 备 的 清 华 大 学 化 学 专 业 入 学 证 书 后 。 <color=#2F4F4F>门 格 斯 图</color> 的 态 度 发 生 了 一 百 八 十 度 的 大 回 环 。 他 在 多 个 场 合 公 开 赞 扬 中 国 革 命 的 经 验 ， 并 把 毛 泽 东 思 想 写 进 了 革 命 火 焰 的 章 程 中 。||在 1 9 7 7 年 2 月 3 日 的 时 候 ， <color=#2F4F4F>门 格 斯 图</color> 指 示 自 己 的 亲 信 丹 尼 尔 · 安 塞 法 上 尉 动 手 。 在 会 议 结 束 后 ， 许 多 和 <color=#006400>特 法 里 · 本 蒂</color> 关 系 紧 密 的 临 时 军 委 成 员 被 逮 捕 后 处 决 。 在 亚 迪 斯 亚 贝 巴 的 群 众 大 会 上 ， <color=#2F4F4F>门 格 斯 图</color> 绘 声 绘 色 的 描 述 了 本 蒂 是 如 何 勾 结 苏 联 人 和 美 帝 的 ， 谴 责 他 的 社 会 主 义 思 想 事 实 上 是 修 正 主 义 ， 只 会 破 坏 临 时 军 委 指 出 的 科 学 社 会 主 义 道 路 。 在 演 讲 的 最 后 ， 他 从 挎 包 里 掏 出 了 四 瓶 红 色 的 液 体 ， 他 高 声 喊 着 “ 和 反 革 命 们 破 罐 子 破 摔 吧 ！ 打 倒 美 帝 ， 苏 修 ， 厄 立 特 里 亚 人 和 埃 人 革 党 ！ ” 随 后 把 四 个 玻 璃 瓶 砸 碎 在 地 上 。 当 天 就 有 数 千 名 被 指 控 为 反 革 命 的 平 民 被 当 众 吊 死 ， 或 者 被 “ 消 失 ” 了 。 这 段 时 间 在 后 来 被 称 为 “qey\u00a0shibir ” （ 红 色 恐 怖 ）||<color=#2F4F4F>门 格 斯 图</color> 也 没 有 忘 记 是 谁 给 他 提 供 了 最 多 的 好 处 ， 他 公 开 驱 逐 了 苏 联 人 ， 并 把 我 们 试 做 革 命 的 标 杆 。 很 难 说 他 做 的 到 底 是 不 是 毛 泽 东 主 席 希 望 看 见 的 ， 但 我 们 在 非 洲 之 角 获 得 了 自 己 的 盟 友 。 巴 雷 也 获 得 了 越 来 越 多 的 苏 联 援 助 ， 希 望 这 不 是 针 对 我 们 的 … … ";
			a.data[8] -= 80;
			a.allcountries[41].Gosstroy = 0;
			a.allcountries[41].SubGosstroy = 10;
			a.allcountries[41].LeaveAlliances();
			a.allcountries[41].EstablishGovernment(Government.ProChina);
			a.allcountries[41].Torg = true;
			a.allcountries[41].proprc = true;
			a.empires[0].relations -= 100;
			a.influencePRC += 10;
			a.data[6] += 5;
		}
		if (result_num == 2)
		{
			text = " 在 南 也 门 和 索 马 里 人 的 帮 助 下 ， 我 们 把 大 量 的 旧 装 甲 车 ， 6 3 式 步 枪 ， 5 6 式 半 自 动 步 枪 和 大 量 老 旧 装 备 出 售 给 了 反 政 府 游 击 队 。 像 西 索 马 里 解 放 阵 线 ， 提 格 雷 人 民 解 放 阵 线 ， 厄 立 特 里 亚 解 放 阵 线 ， 埃 塞 俄 比 亚 人 民 革 命 军 等 组 织 也 在 我 们 的 联 合 下 达 成 了 一 致 ， 就 推 翻 军 委 政 权 的 前 提 下 ， 多 方 愿 意 展 开 合 作 。 亚 的 斯 亚 贝 巴 要 越 来 越 头 疼 了 。||我 们 不 关 心 军 委 双 巨 头 之 间 脆 弱 的 平 衡 ， 而 这 很 快 就 被 打 破 了 。 在 1 9 7 7 年 2 月 3 日 的 时 候 ， <color=#2F4F4F>门 格 斯 图</color> 指 示 自 己 的 亲 信 丹 尼 尔 · 安 塞 法 上 尉 动 手 。 在 会 议 结 束 后 ， 许 多 和 <color=#006400>特 法 里 · 本 蒂</color> 关 系 紧 密 的 临 时 军 委 成 员 被 逮 捕 后 处 决 。 在 亚 迪 斯 亚 贝 巴 的 群 众 大 会 上 ， <color=#2F4F4F>门 格 斯 图</color> 绘 声 绘 色 的 描 述 了 本 蒂 是 如 何 勾 结 美 帝 的 ， 谴 责 他 的 社 会 主 义 思 想 事 实 上 是 修 正 主 义 ， 只 会 破 坏 临 时 军 委 指 出 的 科 学 社 会 主 义 道 路 。 在 演 讲 的 最 后 ， 他 从 挎 包 里 掏 出 了 三 瓶 红 色 的 液 体 ， 他 高 声 喊 着 “ 和 反 革 命 们 破 罐 子 破 摔 吧 ！ 打 倒 美 帝 ， 厄 立 特 里 亚 人 和 埃 人 革 党 ！ ” 随 后 把 三 个 玻 璃 瓶 砸 碎 在 地 上 。 当 天 就 有 数 千 名 被 指 控 为 反 革 命 的 平 民 被 当 众 吊 死 ， 或 者 被 “ 消 失 ” 了 。 这 段 时 间 在 后 来 被 称 为 “qey\u00a0shibir ” （ 红 色 恐 怖 ） 。 ";
			a.data[22] -= 50;
			a.allcountries[41].Gosstroy = 0;
			a.allcountries[41].SubGosstroy = 10;
		}
		if (result_num == 3)
		{
			text = " 我 们 不 关 心 军 委 双 巨 头 之 间 脆 弱 的 平 衡 ， 而 这 很 快 就 被 打 破 了 。 在 1 9 7 7 年 2 月 3 日 的 时 候 ， <color=#2F4F4F>门 格 斯 图</color> 指 示 自 己 的 亲 信 <color=#2F4F4F>丹 尼 尔 · 安 塞 法</color> 上 尉 动 手 。 在 会 议 结 束 后 ， 许 多 和 <color=#006400>特 法 里 · 本 蒂</color> 关 系 紧 密 的 临 时 军 委 成 员 被 逮 捕 后 处 决 。 在 亚 迪 斯 亚 贝 巴 的 群 众 大 会 上 ， <color=#2F4F4F>门 格 斯 图</color> 绘 声 绘 色 的 描 述 了 本 蒂 是 如 何 勾 结 美 帝 的 ， 谴 责 他 的 社 会 主 义 思 想 事 实 上 是 修 正 主 义 ， 只 会 破 坏 <color=#2F4F4F>临 时 军 委</color> 指 出 的 科 学 社 会 主 义 道 路 。 在 演 讲 的 最 后 ， 他 从 挎 包 里 掏 出 了 三 瓶 红 色 的 液 体 ， 他 高 声 喊 着 “ 和 反 革 命 们 破 罐 子 破 摔 吧 ！ 打 倒 美 帝 ， 厄 立 特 里 亚 人 和 埃 人 革 党 ！ ” 随 后 把 三 个 玻 璃 瓶 砸 碎 在 地 上 。 当 天 就 有 数 千 名 被 指 控 为 反 革 命 的 平 民 被 当 众 吊 死 ， 或 者 被 “ 消 失 ” 了 。 这 段 时 间 在 后 来 被 称 为 “qey\u00a0shibir ” （ 红 色 恐 怖 ） 。";
			a.allcountries[41].Gosstroy = 0;
			a.allcountries[41].SubGosstroy = 10;
		}
	}
}
