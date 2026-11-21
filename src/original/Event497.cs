using EventsForDLC;
using UnityEngine;

public class Event497 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 恩 古 瓦 比 的 大 会 ？ — — 第 二 幕";
		text = " 尽 管 萨 苏 被 视 为 刚 果 劳 动 党 保 守 派 的 代 表 ， 但 他 既 不 是 激 进 派 ， 也 不 是 理 论 家 ， 他 的 政 策 通 常 以 实 用 主 义 为 标 志 — — 刚 果 仍 与 西 方 关 系 密 切 ， 经 济 领 域 的 和 法 国 保 持 了 深 入 联 系 ， 萨 苏 表 示 ， 刚 果 和 法 国 之 间 “ 没 有 乌 云 ” 。 刚 果 通 过 法 国 发 展 并 保 持 牢 固 的 关 系 来 维 持 经 济 的 高 速 增 长 。 在 经 济 调 整 中 ， 国 企 开 始 实 行 经 理 负 责 制 和 厂 长 负 责 制 ， 鼓 励 物 质 刺 激 ， 一 批 绩 效 不 良 的 国 营 企 业 被 改 组 为 刚 果 - 法 国 的 合 资 企 业 ， 法 方 派 专 家 帮 助 管 理 。 萨 苏 同 国 际 货 币 基 金 组 织 谈 判 贷 款 ， 并 允 许 来 自 法 国 和 美 国 的 外 国 投 资 者 进 行 石 油 和 矿 产 开 采 。 他 于1979 年10 月 和1981 年7 月 访 问 法 国 ， 寻 求 经 济 支 持 。 法 国 的 石 油 公 司 在 刚 果 油 田 的 开 采 中 发 挥 了 重 要 作 用 ， 他 们 使 石 油 产 量 翻 了 一 番 ， 并 通 过 预 融 资 贷 款 支 持 刚 果 政 府 开 支 。1980 年5 月 ， 萨 苏 与 苏 联 签 署 了 一 项 为 期20 年 的 友 好 协 议 ， 并 于 同 年 派 出 两 个 代 表 团 访 问 中 国 ， 而 中 国 政 府 的 部 长 则 回 访 了 布 拉 柴 维 尔 。 然 而 ， 这 些 关 系 的 经 济 影 响 仍 然 微 乎 其 微 ： 法 国 为 该 国 提 供 了 高 达50 % 的 对 外 援 助 ， 苏 联 和 中 国 对 刚 果 的 援 助 比 起 法 国 而 言 更 是 微 不 足 道 。||在 这 一 情 况 下 ， 刚 果 劳 动 党 党 内 仍 然 存 在 反 对 派 系 。 尽 管 这 随 着 萨 苏 巩 固 权 力 和 党 内 团 结 政 策 的 推 行 ， 劳 动 党 的 宗 派 主 义 在80 年 代 不 那 么 明 显 ， 但 其 内 部 权 力 斗 争 仍 在 继 续 。 萨 苏 将 劳 动 党 的 第 二 号 人 物 与 党 内 理 论 家 让 - 皮 埃 尔 · 蒂 斯 特 雷 · 契 卡 雅 视 为 眼 中 钉 ， 他 计 划 除 掉 这 位 令 他 头 疼 的 人 物 ； 与 此 同 时 ， 党 内 还 存 在 一 个 由 弗 朗 索 瓦 · 格 扎 维 埃 · 卡 塔 利 领 导 的 强 硬 亲 苏 派 ， 希 望 刚 果 与 苏 东 阵 营 进 行 更 深 入 的 合 作 。 在 这 场 党 代 会 上 ， 劳 动 党 各 派 将 决 出 胜 者 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[56] < 2 && a.allcountries[52].Torg)
		{
			button_text[0] = " 帮 助 契 卡 雅 夺 取 权 力 ， 扭 转 刚 果 的 政 策";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 没 必 要 把 手 伸 到 非 洲 去";
		}
		if (a.relres && a.allcountries[1].isSEV && a.data[56] < 3)
		{
			button_text[1] = " 支 持 卡 塔 利 的 亲 苏 强 硬 派 夺 权 ， 刚 果 不 应 该 和 法 国 人 眉 来 眼 去 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 没 必 要 为 苏 联 人 做 事";
		}
		if (a.data[56] != 0 && a.data[56] != 4)
		{
			button_text[2] = " 支 持 萨 苏 的 当 权 派";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 会 支 持 他";
		}
		button_text[3] = " 我 们 不 关 心 刚 果 的 局 势";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 恩 古 瓦 比 的 大 会 ？ — — 第 二 幕";
		if (result_num == 0)
		{
			text = " 我 们 的 人 适 时 地 点 醒 了 契 卡 雅 同 志 。 萨 苏 食 用 了 苏 联 人 送 的 鱼 子 酱 ， 这 导 致 他 因 食 物 中 毒 “ 意 外 ” 身 亡 。 我 们 设 法 争 取 到 部 分 军 事 派 系 、 部 分 党 代 会 代 表 、 甚 至 是 前 M -22 成 员 和 八 月 革 命 元 老 克 洛 德 - 欧 内 斯 特 · 恩 达 拉 及 其 背 后 的 南 方 人 的 支 持 ， 萨 苏 派 的 成 员 成 功 被 排 除 在 权 力 之 外 ， 让 - 皮 埃 尔 · 蒂 斯 特 雷 · 契 卡 雅 成 功 成 为 了 新 的 领 导 人 。 他 没 有 忘 记 是 谁 帮 助 了 他 ， 在 大 会 上 ， 前 M -22 的 成 员 被 大 幅 提 拔 。 契 卡 雅 总 统 宣 布 ， 刚 果 将 彻 底 与 新 殖 民 主 义 决 裂 ， 回 到 真 正 的 马 列 主 义 和 由 恩 古 瓦 比 同 志 指 引 的 道 路 上 ， 并 站 在 以 中 国 为 首 的 革 命 阵 营 一 边 ， 这 场 党 代 会 被 称 为 “ 又 一 次 恩 古 瓦 比 的 大 会 ” 。 我 们 将 为 刚 果 提 供 帝 国 主 义 离 开 后 的 经 济 支 持 。";
			a.data[8] -= 100;
			a.data[9] -= 50;
			a.allcountries[52].Gosstroy = 1;
			a.allcountries[52].SubGosstroy = 2;
			a.allcountries[52].LeaveAlliances();
			a.allcountries[52].proprc = true;
			a.allcountries[52].Torg = true;
		}
		if (result_num == 1)
		{
			text = " 在 党 代 会 上 ， 在 卡 塔 利 派 、 契 卡 雅 派 甚 至 是 前 M -22 成 员 的 支 持 下 ， 萨 苏 因 “ 右 倾 、 向 帝 国 主 义 投 降 ” 而 被 刚 果 劳 动 党 全 国 代 表 大 会 罢 免 。 弗 朗 索 瓦 · 格 扎 维 埃 · 卡 塔 利 被 选 举 为 新 的 总 书 记 。 卡 塔 利 宣 布 ， 刚 果 将 彻 底 与 殖 民 主 义 决 裂 ， 站 在 以 苏 联 为 首 的 社 会 主 义 阵 营 一 边 。 经 济 互 助 委 员 会 将 为 其 提 供 帝 国 主 义 离 开 后 的 经 济 支 持 ， 许 多 刚 果 和 法 国 合 资 的 企 业 已 经 开 始 改 为 同 包 括 苏 联 在 内 的 经 互 会 国 家 合 资 。";
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[52].LeaveAlliances();
			a.allcountries[52].prosov = true;
			a.allcountries[52].Torg = true;
		}
		if (result_num == 2)
		{
			if (!a.allcountries[21].prosov)
			{
				text = " 我 们 的 特 工 提 前 在 刚 果 劳 动 党 的 中 央 委 员 会 进 行 了 打 点 ， 萨 苏 感 谢 了 我 们 的 支 持 ， 同 我 们 签 订 了 一 批 合 作 协 议 。 在 党 代 会 上 ， 契 卡 雅 遭 到 了 萨 苏 的 突 然 袭 击 ， 他 指 控 契 卡 雅 应 该 为1982 年 在 布 拉 柴 维 尔 发 生 的 炸 弹 袭 击 事 件 负 责 ， 这 导 致 他 被 免 职 。 于 此 同 时 ， 卡 塔 利 派 也 在 大 会 上 被 边 缘 化 ， 卡 塔 利 被 降 职 到 一 个 清 水 衙 门 。 萨 苏 就 这 样 巩 固 了 他 的 地 位 ， 并 将 继 续 他 的 统 治 。";
				return;
			}
			text = " 得 益 于 我 们 的 支 持 ， 萨 苏 在 党 代 会 上 顶 住 了 有 法 国 和 苏 联 撑 腰 的 卡 塔 利 派 的 挑 战 ， 调 动 军 队 “ 平 息 ” 了 党 内 的 异 议 ， 契 卡 雅 以 及 卡 塔 利 派 的 成 员 都 被 解 职 了 。 萨 苏 就 这 样 巩 固 了 他 的 地 位 ， 并 将 继 续 他 的 统 治 。 萨 苏 谴 责 法 国 和 苏 联 “ 是 社 会 帝 国 主 义 ， 干 涉 刚 果 内 政 ” 。 他 感 谢 我 们 的 支 持 ， 宣 布 倒 向 我 国 ， 并 和 我 们 扩 大 了 合 作 。";
			a.allcountries[52].LeaveAlliances();
			a.allcountries[52].Torg = true;
			if (a.IsSocialism(yes: true, 1))
			{
				a.allcountries[52].proprc = true;
				a.allcountries[52].Gosstroy = 1;
				a.allcountries[52].SubGosstroy = 1;
			}
			else if (a.allcountries[1].Gosstroy == 2)
			{
				a.allcountries[52].proprc = true;
				a.allcountries[52].Gosstroy = 2;
				a.allcountries[52].SubGosstroy = 15;
			}
		}
		if (result_num == 3)
		{
			if (!a.allcountries[21].prosov)
			{
				text = " 在 党 代 会 上 ， 契 卡 雅 遭 到 了 萨 苏 的 突 然 袭 击 ， 他 指 控 契 卡 雅 应 该 为1982 年 在 布 拉 柴 维 尔 发 生 的 炸 弹 袭 击 事 件 负 责 ， 这 导 致 他 被 免 职 。 于 此 同 时 ， 卡 塔 利 派 也 在 大 会 上 被 边 缘 化 ， 卡 塔 利 被 降 职 到 一 个 清 水 衙 门 。 萨 苏 就 这 样 巩 固 了 他 的 地 位 ， 并 将 继 续 他 的 统 治 。";
				return;
			}
			text = " 在 党 代 会 上 ， 在 卡 塔 利 派 、 契 卡 雅 派 甚 至 是 前 M -22 成 员 的 支 持 下 ， 萨 苏 因 “ 右 倾 、 向 帝 国 主 义 投 降 ” 而 被 刚 果 劳 动 党 全 国 代 表 大 会 罢 免 。 弗 朗 索 瓦 · 格 扎 维 埃 · 卡 塔 利 被 选 举 为 新 的 总 书 记 。 卡 塔 利 宣 布 ， 刚 果 将 彻 底 与 殖 民 主 义 决 裂 ， 站 在 以 苏 联 为 首 的 社 会 主 义 阵 营 一 边 。 经 济 互 助 委 员 会 将 为 其 提 供 帝 国 主 义 离 开 后 的 经 济 支 持 ， 许 多 刚 果 和 法 国 合 资 的 企 业 已 经 开 始 改 为 同 包 括 苏 联 在 内 的 经 互 会 国 家 合 资 。";
			a.data[8] -= 50;
			a.data[9] -= 50;
			a.allcountries[52].LeaveAlliances();
			a.allcountries[52].prosov = true;
		}
	}
}
