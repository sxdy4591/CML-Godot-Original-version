using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event447 : EventsSecond
{
	private GameState a;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 拯 救 伊 朗 大 起 义";
		text = " 随 着 伊 朗 文 化 大 革 命 的 进 行 ， 越 来 越 多 的 有 识 之 士 开 始 意 识 到 ， 霍 梅 尼 的 野 望 也 许 不 止 是 大 权 独 揽 ， 而 是 将 伊 斯 兰 渗 透 到 政 治 的 方 方 面 面 。 1 9 8 0   年 4   月 ， 以 空 军 准 将 艾 亚 特 • 莫 哈 格 吉 、 原 首 都 防 空 司 令 赛 义 德 • 马 赫 迪 奧 和 巴 盖 尔 • 阿 梅 里 上 校 为 首 的 ⼀ 批 军 中 精 英 ， 成 立 了 代 号 “ 面 具 ” 的 组 织 。 他 们 意 识 到 ， 面 对 如 今 的 国 家 乱 象 ， 政 教 分 离 已 被 霍 梅 尼 打 破 ， 若 不 趁 现 在 用 强 力 绞 杀 神 权 派 ， 日 后 局 势 必 将 无 法 挽 回 。 为 此 ， 他 们 准 备 了 缜 密 的 方 案 ， 准 备 除 掉 什 叶 派 神 权 政 府 的 同 时 ， 还 政 于 民 ， 组 建 真 正 的 伊 朗 共 和 国 。 我 们 可 以 为 他 们 提 供 来 自 我 方 的 帮 助 。 当 然 我 们 也 可 以 借 助 这 个 机 会 卖 伊 朗 人 ⼀ 个 人 情 。 主 席 同 志 ， 我 们 该 怎 么 办 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[56] != 2 && GlobalScript.inst.gameState.influencePRC >= 300 && a.data[45] <= 300)
		{
			button_text[0] = " 为 政 变 军 官 提 供 来 自 我 们 的 帮 助 和 外 交 支 持";
		}
		else if (GlobalScript.inst.gameState.data[56] > 1)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 为 什 么 要 帮 他 们 ？";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 们 不 会 信 任 我 们 的";
		}
		if (GlobalScript.inst.gameState.data[56] > 1 && GlobalScript.inst.gameState.influencePRC >= 200)
		{
			button_text[1] = " 给 伊 朗 人 卖 个 人 情 ， 泄 漏 关 于 政 变 的 内 容";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 别 和 神 权 分 子 走 那 么 近 ！";
		}
		button_text[2] = " 我 们 最 好 关 注 自 己 的 事 情 。";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 拯 救 伊 朗 大 起 义";
		switch (result_num)
		{
		case 0:
			text = " 一 通 来 自 中 国 大 使 馆 的 电 话 打 进 了 军 营 ， 莫 哈 格 吉 准 将 ， 马 赫 迪 奥 和 阿 梅 里 在 我 方 的 劝 说 之 下 ， 接 纳 了 将 我 国 作 为 靠 山 的 计 划 。 为 此 ， 我 国 将 会 为 他 们 提 供 军 火 和 逃 生 路 线 。 ⼀ 切 按 计 划 进 行 。 第23 空 中 突 击 旅 顺 利 拿 下 位 于 哈 马 丹 的 诺 耶 空 军 基 地 ， 这 里 停 有18 架 强 -5 战 机 。 ⼀ 队 伊 朗 “ 金 冠 ” 飞 行 员 驾 驶 ， 于   6 分 钟 后 飞 抵 德 黑 兰 上 空 ， 用 B L755 集 束 炸 弹 和90 m m   火 箭 弹 对 神 权 派 的 伊 斯 兰 革 命 卫 队 总 部 等 多 处 据 点 实 施 精 准 轰 炸 。 ， 其 中 ， 霍 梅 尼 位 于 首 都 贾 马 拉 的 住 所 ， 由 三 架 战 机 一 起 行 动 。 在 数 百 磅 炸 弹 的 洗 礼 下 ， 霍 梅 尼 这 位 真 主 的 仆 人 便 去 见 了 安 拉 。 原 帝 国 近 卫 师 、 德 黑 兰 宪 兵 和 警 察 部 队 在 内 的3000 人 立 刻 占 领 广 播 电 台 等 重 要 设 施 ， 并 对 神 权 派 主 要 毛 拉 进 行 抓 捕 。 同 时 ， 在 首 都 以 外 ， 第2 、21 、92 装 甲 师 和 第81 巴 赫 塔 兰 师 、 第77 步 兵 师 、 及 第1 海 军 陆 战 旅 ， 也 将 在 伊 斯 法 罕 等 全 国15 个 城 市 迅 速 清 理 当 地 革 命 卫 队 。 失 去 了 领 袖 和 大 量 军 事 力 量 的 神 权 派 再 无 东 山 再 起 的 可 能 性 ， 伊 朗 伊 斯 兰 革 命 失 败 了 。";
			a.data[9] -= 200;
			a.data[22] -= 200;
			a.data[8] -= 100;
			a.data[6] += 30;
			a.influencePRC -= 15;
			a.allcountries[8].Gosstroy = 2;
			a.allcountries[8].SubGosstroy = 15;
			load_scene_after_click = true;
			a.influencePRC += 50;
			a.data[45] -= 1000;
			break;
		case 1:
			text = "我 们 决 定 打 电 话 给 伊 斯 兰 共 和 国 政 府 总 理 ， 告 知 了 他 们 关 于 政 变 的 阴 谋 。7 月9 日 晚 ， 莫 哈 格 吉 和 几 名 飞 行 员 散 会 后 ， 在 路 边 等 待 接 应 的 车 辆 时 ， 突 然 看 见 革 命 卫 队 的 吉 普 正 这 朝 边 奔 来 。 他 们 迅 速 钻 进 路 旁 的 小 树 林 逃 避 。 莫 哈 格 吉 懵 了 ， 他 不 清 楚 是 不 是 他 们 已 经 暴 露 。 跑 回 公 寓 后 ， 他 直 接 拨 通 了 原 防 空 司 令 马 赫 迪 奥 的 电 话 。 随 后 ， 二 人 开 车 在 德 黑 兰 街 头 碰 面 。 哥 俩 现 在 都 不 排 除 计 划 已 泄 露 的 可 能 性 ， 但 如 箭 在 弦 ， 已 无 回 头 路 。 马 赫 迪 奥 告 诉 莫 哈 格 吉 将 联 系 陆 军 的 阿 梅 里 ， 准 备 提 前 动 手 。 无 论 是 否 成 功 ， 他 们 都 将 坦 然 面 对 。 这 终 将 是 一 场 灾 难 性 的 失 败 … … 第 二 天 一 早 ， 伊 斯 兰 革 命 卫 队 开 始 了 对 “ 面 具 ” 的 清 剿 。 包 括 莫 哈 格 吉 、 马 赫 迪 奥 在 内 的600 多 人 先 后 被 捕 ， 一 些 人 在 抵 抗 中 遭 击 毙 。 陆 军 上 校 阿 梅 里 和 少 数 人 成 功 逃 进 了 土 耳 其 。 在 伊 朗 政 府 安 排 的 电 视 审 判 上 ， 还 有 相 当 戏 剧 性 的 一 幕 ， 莫 哈 格 吉 准 将 挣 脱 了 两 旁 的 革 命 卫 队 成 员 ， 怒 吼 道 ： “ 我 是 一 名 伊 朗 军 人 ！ … … 我 之 所 以 参 与 行 动 ， 是 因 为 我 对 祖 国 所 发 生 的 一 切 感 到 幻 灭 。 阿 克 洪 先 生 （ 对 毛 拉 的 贬 义 称 呼 ） ， 请 不 要 问 我 是 否 后 悔 ！ 我 们 参 加 行 动 不 是 为 了 金 钱 或 地 位 ， 而 是 为 了 拯 救 我 的 祖 国 ！ 他 （ 霍 梅 尼 ） 是 你 们 这 些 蠢 货 的 伊 玛 目 ， 不 是 我 的 ！ ！ ”  伊 朗 人 感 谢 我 们 的 通 风 报 信 ， 并 决 定 扩 大 和 我 们 的 贸 易 往 来 。 并 决 定 为 我 们 的 主 席 颁 发 一 枚 伊 朗 伊 斯 兰 共 和 国 二 级 国 旗 勋 章 。 ";
			a.data[9] -= 30;
			a.data[6] -= 50;
			a.influencePRC += 50;
			a.data[45] += 300;
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			a.allcountries[8].Torg = true;
			break;
		case 2:
			text = " 人 民 党 利 用 其 在 军 中 的 情 报 网 络 ， 无 意 间 获 取 了 部 分 武 装 力 量 将 发 动 起 义 的 消 息 。 时 任 该 党 中 央 委 员 的 穆 罕 默 德 · 阿 里 · 阿 穆 伊 在 与 党 魁 卡 亚 诺 里 商 议 后 ， 决 定 抓 住 这 个 机 会 向 老 霍 头 邀 功 、 表 忠 心 ！ 希 望 以 此 让 霍 梅 尼 认 为 自 己 这 个 共 产 主 义 者 将 和 他 永 远 穿 一 条 裤 子 。7 月9 日 晚 ， 莫 哈 格 吉 和 几 名 飞 行 员 散 会 后 ， 在 路 边 等 待 接 应 的 车 辆 时 ， 突 然 看 见 革 命 卫 队 的 吉 普 正 这 朝 边 奔 来 。 他 们 迅 速 钻 进 路 旁 的 小 树 林 逃 避 。 莫 哈 格 吉 懵 了 ， 他 不 清 楚 是 不 是 他 们 已 经 暴 露 。 跑 回 公 寓 后 ， 他 直 接 拨 通 了 原 防 空 司 令 马 赫 迪 奥 的 电 话 。 随 后 ， 二 人 开 车 在 德 黑 兰 街 头 碰 面 。 哥 俩 现 在 都 不 排 除 计 划 已 泄 露 的 可 能 性 ， 但 如 箭 在 弦 ， 已 无 回 头 路 。 马 赫 迪 奥 告 诉 莫 哈 格 吉 将 联 系 陆 军 的 阿 梅 里 ， 准 备 提 前 动 手 。 无 论 是 否 成 功 ， 他 们 都 将 坦 然 面 对 。 这 终 将 是 一 场 灾 难 性 的 失 败 … … 第 二 天 一 早 ， 伊 斯 兰 革 命 卫 队 开 始 了 对 “ 面 具 ” 的 清 剿 。 包 括 莫 哈 格 吉 、 马 赫 迪 奥 在 内 的600 多 人 先 后 被 捕 ， 一 些 人 在 抵 抗 中 遭 击 毙 。 陆 军 上 校 阿 梅 里 和 少 数 人 成 功 逃 进 了 土 耳 其 。 在 伊 朗 政 府 安 排 的 电 视 审 判 上 ， 还 有 相 当 戏 剧 性 的 一 幕 ， 莫 哈 格 吉 准 将 挣 脱 了 两 旁 的 革 命 卫 队 成 员 ， 怒 吼 道 ： “ 我 是 一 名 伊 朗 军 人 ！ … … 我 之 所 以 参 与 行 动 ， 是 因 为 我 对 祖 国 所 发 生 的 一 切 感 到 幻 灭 。 阿 克 洪 先 生 （ 对 毛 拉 的 贬 义 称 呼 ） ， 请 不 要 问 我 是 否 后 悔 ！ 我 们 参 加 行 动 不 是 为 了 金 钱 或 地 位 ， 而 是 为 了 拯 救 我 的 祖 国 ！ 他 （ 霍 梅 尼 ） 是 你 们 这 些 蠢 货 的 伊 玛 目 ， 不 是 我 的 ！ ！”";
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			a.data[45] += 300;
			break;
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.number_event = 448;
			SceneManager.LoadScene("Event");
		}
	}
}
