using EventsForDLC;
using UnityEngine;

public class Event492 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 狂 风 怒 吼 ， 巴 尔 干 咆 哮";
		text = " 随 着 苏 联 影 响 力 的 进 一 步 衰 退 ， 一 度 被 视 为 稳 定 与 发 展 的 保 加 利 亚 人 民 共 和 国 也 开 始 暗 流 涌 动 。 民 族 主 义 者 ， 改 革 派 ， 正 统 派 共 产 主 义 者 都 试 图 踢 开 日 夫 科 夫 掌 握 大 权 。 由 于 日 夫 科 夫 的 政 策 ， 保 加 利 亚 的 经 济 一 直 处 于 下 滑 阶 段 。 内 部 的 局 势 似 乎 已 经 到 了 一 个 引 爆 点 ， 而 我 们 只 需 要 扇 下 风 ， 不 需 放 屁 ， 试 看 天 翻 地 覆 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.allcountries[6].cw && a.IsSocialism(yes: true, 1) && a.modifies[6].active)
		{
			button_text[0] = " 是 时 候 了 ， 动 手 吧 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 没 人 会 听 我 们 的 话";
		}
		if (a.allcountries[20].spec == 1 && a.influencePRC >= 800)
		{
			button_text[1] = " 在 我 们 盟 友 的 帮 助 下 ， 向 保 加 利 亚 施 压";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 在 巴 尔 干 没 有 话 语 权";
		}
		if (a.data[56] >= 2 && a.data[16] >= 13 && a.relres)
		{
			button_text[2] = " 邀 请 保 加 利 亚 借 鉴 我 们 和 铁 托 的 经 验 开 始 改 革";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 不 想 也 不 可 能 联 络 修 正 主 义 者";
		}
		button_text[3] = " 什 么 都 不 需 要 做";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 狂 风 怒 吼 ， 巴 尔 干 咆 哮";
		if (result_num == 0)
		{
			a.data[8] -= 100;
			a.data[9] -= 50;
			if (a.influencePRC >= 600)
			{
				text = " 在 我 们 的 支 持 下 ， 驻 扎 在 索 非 亚 的 保 加 利 亚 人 民 军 发 生 了 哗 变 。 由 于 事 先 的 打 点 ， 大 部 分 军 队 没 有 对 此 作 出 回 应 。 支 持 政 变 的 部 队 切 断 了 所 有 通 往 首 都 的 桥 梁 与 道 路 ， 广 播 电 台 和 电 视 塔 被 占 领 ， 机 场 也 被 封 锁 。 而 佩 塔 尔 本 人 亲 自 率 领 了 一 支 部 队 ， 他 们 冲 进 了 保 加 利 亚 共 产 党 中 央 委 员 会 的 办 公 室 ， 一 举 抓 获 了 日 夫 科 夫 和 其 余 的 政 治 局 常 委 。 在 一 场 迅 速 的 审 判 后 ， 日 夫 科 夫 和 他 的 亲 属 被 判 贪 污 与 通 敌 罪 。 他 本 人 被 用 从 他 家 中 抄 出 的 黄 金 砸 死 ， 他 的 尸 体 被 丢 入 黑 海 中 。 日 夫 科 夫 就 这 样 被 遗 忘 了 ， 而 他 的 子 女 将 被 下 放 到 林 场 中 劳 动 改 造 。||佩 塔 尔 · 潘 切 夫 斯 基 宣 布 对 保 加 利 亚 实 施 军 事 管 制 ， 并 开 始 着 手 清 除 苏 联 影 响 力 。 他 宣 布 将 会 在 保 加 利 亚 重 建 最 符 合 季 米 特 洛 夫 ， 斯 大 林 与 毛 泽 东 的 共 产 主 义 保 加 利 亚 。 首 当 其 冲 的 便 是 退 出 华 沙 条 约 组 织 与 经 济 互 助 委 员 会 。 1 9 6 5 年 的 政 变 也 被 平 反 ， 政 变 的 参 与 者 被 无 罪 释 放 ， 托 多 罗 夫 被 当 作 民 族 英 雄 而 纪 念 ， 四 月 七 日 改 为 国 家 假 日 。 工 业 方 面 ， 以 工 人 委 员 会 为 核 心 的 企 业 管 理 系 统 也 被 介 绍 进 来 ， 专 门 为 经 互 会 设 立 的 企 业 也 被 “ 保 加 利 亚 化 ” 了 。 由 于 苏 联 援 助 的 撤 离 ， 新 领 导 层 希 望 中 华 人 民 共 和 国 能 为 新 保 加 利 亚 提 供 必 要 的 援 助 。||";
				if (a.allcountries[20].spec == 1)
				{
					text += " 新 生 的 保 加 利 亚 积 极 谋 求 和 巴 尔 干 国 家 的 友 好 关 系 ， 并 获 得 了 巴 尔 干 国 家 联 盟 的 观 察 员 席 位 。||";
				}
				text += " 苏 联 谴 责 了 这 一 行 为 ， 并 宣 布 对 我 们 进 行 制 裁 。";
				a.allcountries[6].Gosstroy = 1;
				a.allcountries[6].SubGosstroy = 17;
				a.allcountries[6].LeaveAlliances();
				a.allcountries[6].Torg = true;
				a.allcountries[6].proprc = true;
				a.allcountries[6].JoinAllOurAlliances(yes: true);
				a.empires[1].relations -= 400;
				a.empires[1].power -= 100;
				a.influencePRC += 100;
			}
			else
			{
				text = " 在 我 们 的 支 持 下 ， 驻 扎 在 索 非 亚 的 保 加 利 亚 人 民 军 发 生 了 哗 变 。 由 于 事 先 的 打 点 ， 大 部 分 军 队 没 有 对 此 作 出 回 应 。 支 持 政 变 的 部 队 切 断 了 所 有 通 往 首 都 的 桥 梁 与 道 路 ， 广 播 电 台 和 电 视 塔 被 占 领 ， 机 场 也 被 封 锁 。 而 佩 塔 尔 本 人 亲 自 率 领 了 一 支 部 队 ， 他 们 冲 进 了 保 加 利 亚 共 产 党 中 央 委 员 会 的 办 公 室 ， 一 举 抓 获 了 日 夫 科 夫 和 其 余 的 政 治 局 常 委 。 在 一 场 迅 速 的 审 判 后 ， 日 夫 科 夫 和 他 的 亲 属 被 判 贪 污 与 通 敌 罪 。 他 本 人 被 用 从 他 家 中 抄 出 的 黄 金 砸 死 ， 而 他 的 子 女 将 被 判 处 有 期 徒 刑 。||但 我 们 的 人 没 能 夺 权 ， 失 势 的 保 加 利 亚 内 政 部 长 安 吉 尔 · 索 拉 科 夫 乘 机 发 动 了 反 政 变 。 一 举 夺 走 了 革 命 果 实 。 他 假 借 革 命 者 之 手 除 掉 了 日 夫 科 夫 后 ， 又 立 刻 以 潜 在 反 革 命 的 名 义 处 决 了 不 忠 诚 于 他 的 革 命 委 员 会 成 员 。 一 个 新 的 “ 保 共 ” 诞 生 了 ， 但 完 全 是 为 了 一 个 独 裁 政 权 而 服 务 的 。 索 拉 科 夫 宣 布 将 从 苏 联 人 手 中 解 放 祖 国 ， 并 构 建 “ 有 保 加 利 亚 特 色 的 社 会 主 义 ” 。 保 加 利 亚 立 刻 驱 逐 了 全 部 的 驻 保 加 利 亚 苏 联 武 装 部 队 ， 并 扣 留 了 R - 4 6 导 弹 井 与 发 射 钥 匙 。 电 视 台 也 无 限 期 停 播 。 保 加 利 亚 似 乎 成 为 了 欧 洲 的 孤 儿 。 南 斯 拉 夫 与 保 加 利 亚 接 壤 的 部 分 传 来 了 交 火 的 新 闻 ， 我 们 希 望 未 来 不 会 发 生 太 糟 糕 的 事 情 。";
				a.allcountries[6].Gosstroy = 0;
				a.allcountries[6].SubGosstroy = 10;
				a.allcountries[6].LeaveAlliances();
				a.empires[1].relations -= 200;
				a.empires[1].power -= 150;
			}
		}
		if (result_num == 1)
		{
			text = " 我 们 决 定 向 保 加 利 亚 施 压 ， 以 脱 离 经 济 互 助 委 员 会 和 华 约 为 要 求 ， 我 们 将 为 保 加 利 亚 承 担 债 务 ， 而 且 保 加 利 亚 将 在 巴 尔 干 联 邦 中 取 得 一 席 之 地 。 巴 尔 干 邦 联 将 为 保 加 利 亚 提 供 急 需 的 面 向 亚 得 里 亚 的 出 海 口 ， 而 且 得 以 使 他 们 在 充 斥 着 中 国 影 响 力 的 巴 尔 干 中 不 被 边 缘 化 。 很 明 显 这 符 合 保 加 利 亚 的 需 要 。 而 日 夫 科 夫 将 赢 得 身 前 身 后 名 。 因 此 ， 在 下 一 届 巴 尔 干 国 家 代 表 大 会 上 ， 保 加 利 亚 的 牌 子 和 希 腊 的 一 样 ， 出 现 在 了 观 察 员 国 席 上 。||但 苏 联 对 我 们 的 所 作 所 为 非 常 不 满 意 ， 如 果 朝 鲜 突 然 亲 苏 ， 我 们 也 会 这 么 做 的 。";
			a.data[8] -= 150;
			a.allcountries[6].LeaveAlliances();
			a.allcountries[6].Torg = true;
			a.empires[1].relations -= 250;
			a.empires[1].power -= 100;
			a.influencePRC += 80;
		}
		if (result_num == 2)
		{
			text = " 我 们 邀 请 保 加 利 亚 的 改 革 派 代 表 姆 拉 德 诺 夫 来 我 国 参 观 ， 货 架 上 玲 琅 满 目 的 各 国 商 品 让 这 位 领 导 人 印 象 深 刻 。 在 苏 联 人 的 默 许 和 我 们 的 支 持 下 ， 姆 拉 德 诺 夫 发 动 了 一 场 不 流 血 的 政 变 ， 日 夫 科 夫 被 开 除 党 籍 。 保 加 利 亚 建 立 了 类 似 于 我 国 的 经 济 特 区 ， 原 先 的 企 业 也 被 改 制 为 “ 工 人 自 发 管 理 ” ， 即 选 拔 一 批 有 领 导 力 的 工 人 替 代 厂 长 。 而 农 业 上 ， 保 加 利 亚 也 组 建 了 自 己 的 小 岗 村 。 保 共 也 为 一 大 批 前 政 治 犯 平 反 ， 其 中 包 括 了 1 9 6 5 年 的 军 事 政 变 。 苏 联 对 保 加 利 亚 的 改 革 与 解 冻 很 是 满 意 。 美 国 也 不 再 公 开 攻 击 保 加 利 亚 支 持 恐 怖 主 义 。||尽 管 经 济 看 上 去 有 所 回 升 ， 但 只 有 我 们 知 道 这 一 切 的 后 果 。 ";
			a.data[9] -= 100;
			a.allcountries[6].Gosstroy = 2;
			a.allcountries[6].SubGosstroy = 15;
			a.allcountries[6].Torg = true;
			a.empires[1].relations += 300;
			a.empires[1].power -= 100;
			a.influencePRC += 80;
		}
		if (result_num == 3)
		{
			text = " 日 夫 科 夫 的 统 治 依 然 像 从 前 一 般 稳 定 ， 在 苏 联 的 帮 助 下 ， 他 继 续 稳 坐 钓 鱼 台 。 我 们 还 是 不 能 下 定 决 心 拔 掉 苏 联 的 牙 齿 。";
		}
	}
}
