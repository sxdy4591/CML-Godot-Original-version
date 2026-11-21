using EventsForDLC;
using UnityEngine;

public class Event440 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 黎 巴 嫩 ， 你 可 还 好";
		text = " 自 1 9 7 5 射 向 巴 士 的 第 一 枪 开 始 ， 整 个 国 家 脆 弱 的 和 平 被 彻 底 打 破 。 宛 如 玻 璃 器 皿 的 东 地 中 海 巴 黎 被 撕 下 繁 荣 的 面 纱 ， 狠 狠 地 摔 在 了 地 上 。 数 不 尽 的 冲 突 、 积 压 许 久 的 仇 恨 覆 压 了 古 尔 奈 特 的 圣 树 ， 而 皑 皑 白 雪 下 是 望 不 到 头 的 尸 骨 。 马 龙 派 、 逊 尼 派 、 什 叶 派 、 德 鲁 兹 、 亚 美 尼 亚 、 巴 勒 斯 坦 … … 小 小 的 十 万 平 米 分 出 了 许 多 个 派 系 ， 而 生 活 在 此 的 人 们 于 分 裂 的 漩 涡 中 痛 苦 地 撕 裂 自 己 。 然 而 ， 现 在 巴 勒 斯 坦 问 题 的 和 平 收 场 使 得 盘 踞 在 这 个 国 家 的 数 十 万 巴 勒 斯 坦 人 即 将 回 归 ， 而 内 战 的 局 面 也 再 一 次 发 生 深 刻 变 化 。 也 许 ， 是 时 候 结 束 这 场 旷 日 已 久 的 兄 弟 之 争 ， 让 雪 松 再 一 次 生 长 在 各 群 体 的 团 结 之 壤 上 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.data[85] >= 2 && a.allcountries[35].proprc)
		{
			button_text[0] = " 我 们 将 促 成 全 国 和 解 ， 宗 教 冲 突 不 应 该 出 现 在 二 十 世 纪 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 巴 勒 斯 坦 人 不 会 离 开";
		}
		if (a.data[56] >= 1 && a.data[56] <= 2)
		{
			button_text[1] = " 让 复 兴 党 人 和 巴 解 组 织 动 手 ， 夺 取 最 终 胜 利";
		}
		else if (a.data[56] == 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 黎 巴 嫩 人 民 的 幸 福 不 能 依 赖 于 一 帮 军 阀";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 你 说 ， 最 初 是 哪 个 国 家 最 先 干 涉 黎 巴 嫩 内 战 呢 ？";
		}
		if (a.data[56] <= 1)
		{
			button_text[2] = " 我 们 将 支 持 共 产 主 义 者 夺 权 抵 抗 阵 线 ， 向 烈 士 广 场 前 进 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 这 场 战 争 不 就 是 左 派 挑 起 的 ？";
		}
		button_text[3] = " 现 在 并 不 是 解 决 内 战 的 最 好 时 机 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 黎 巴 嫩 ， 你 可 还 好";
		if (result_num == 0)
		{
			text = " 最 终 ， 疲 惫 的 内 战 各 方 达 成 在 我 们 和 叙 利 亚 的 协 调 下 达 成 了 和 解 共 识 ， 并 签 署 了 各 民 族 和 平 条 约 。 马 龙 派 为 主 的 黎 巴 嫩 阵 线 作 出 了 更 多 的 妥 协 ， 修 改 了 原 本 5 5 ： 4 5 的 议 会 席 位 分 配 ， 穆 斯 林 群 体 得 以 享 有 和 基 督 徒 平 等 的 政 治 权 利 。 原 本 受 总 统 任 命 的 穆 斯 林 总 理 拥 有 了 更 大 权 力 ， 且 只 对 立 法 机 关 负 责 。 真 主 党 、 亚 美 尼 亚 革 命 同 盟 一 系 列 少 数 群 体 反 对 派 得 到 了 席 位 配 额 ， 而 阿 迈 勒 运 动 与 进 步 社 会 党 更 是 在 国 民 议 会 和 部 长 会 议 中 与 黎 巴 嫩 力 量 三 分 天 下 。 少 数 极 端 组 织 — — 如 雪 松 卫 士 相 当 不 满 意 于 这 种 妥 协 ， 但 总 体 上 各 个 势 力 满 意 于 这 种 贝 鲁 特 精 神 和 谢 哈 布 政 策 的 进 一 步 发 展 。 总 统 阿 明 杰 马 耶 勒 、 议 会 议 长 纳 比 贝 里 还 有 德 鲁 兹 人 首 领 小 琼 布 拉 特 被 诺 贝 尔 和 平 奖 提 名 ， “ 东 方 瑞 士 ” 继 续 走 在 摒 弃 宗 派 分 歧 、 道 阻 且 长 的 阿 拉 伯 团 结 之 路 上 ， 而 象 征 宁 静 的 瑞 雪 已 然 映 照 在 这 片 紫 色 发 源 地 。 应 该 吧 ？ ";
			a.influencePRC += 20;
			a.data[9] -= 30;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.empires[0].power += 20;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.allcountries[93].Torg = true;
			GlobalScript.inst.gameState.allcountries[93].Gosstroy = 3;
			GlobalScript.inst.gameState.allcountries[93].SubGosstroy = 4;
		}
		if (result_num == 1)
		{
			text = " 受 复 兴 党 人 、 巴 解 组 织 还 有 部 分 共 产 主 义 者 支 持 的 黎 巴 嫩 全 国 抵 抗 阵 线 凭 借 着 相 比 黎 巴 嫩 阵 线 数 倍 的 武 装 力 量 ， 在 我 们 的 支 持 下 一 鼓 作 气 地 打 进 了 马 龙 斯 坦 ， 东 贝 鲁 特 的 马 龙 派 民 兵 由 于 以 色 列 支 持 很 快 兵 败 如 山 倒 ， 被 全 国 运 动 的 人 民 解 放 军 和 巴 解 组 织 尽 数 屠 杀 。 而 随 着 基 督 徒 总 部 的 沦 陷 ， 大 部 分 马 龙 派 民 兵 放 下 武 器 选 择 投 降 。||最 终 ， 新 政 府 以 德 鲁 兹 人 的 进 步 社 会 党 、 逊 尼 派 的 独 立 纳 赛 尔 运 动 和 什 叶 派 的 阿 迈 勒 运 动 为 三 柱 石 ， 宣 布 黎 巴 嫩 将 成 为 一 个 更 加 “ 阿 拉 伯 ” 和 宗 教 宽 容 的 地 区 。 腓 尼 基 概 念 将 不 再 留 存 于 黎 巴 嫩 之 国 家 构 建 ， 而 马 龙 派 也 必 须 从 高 高 在 上 的 地 位 下 来 ， 向 什 叶 派 、 德 鲁 兹 派 甚 至 是 亚 美 尼 亚 人 交 出 权 力 。 以 “ 新 腓 尼 基 人 ” 为 代 表 的 马 龙 派 商 业 精 英 纷 纷 落 马 ， 其 资 产 和 金 融 机 构 被 执 行 强 行 国 有 化 。 新 总 统 琼 布 拉 特 领 导 着 有 史 以 来 第 一 个 非 基 督 徒 主 导 的 内 阁 ， 着 手 于 打 击 传 统 政 治 势 力 — — 祖 阿 玛 以 及 推 行 温 和 的 土 改 政 策 ， 以 求 尽 可 能 地 转 变 先 前 新 自 由 主 义 的 马 龙 派 政 策 。 进 步 社 会 党 是 否 真 能 给 这 个 “ 只 有 政 治 商 人 ” 的 腐 朽 国 家 带 来 新 生 ， 让 我 们 拭 目 以 待 … … ";
			a.data[9] -= 50;
			a.influencePRC += 20;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 50;
			GlobalScript.inst.gameState.empires[0].power -= 20;
			GlobalScript.inst.gameState.empires[1].power -= 20;
			GlobalScript.inst.gameState.allcountries[93].Torg = true;
			GlobalScript.inst.gameState.allcountries[93].Gosstroy = 2;
			GlobalScript.inst.gameState.allcountries[93].SubGosstroy = 15;
		}
		if (result_num == 2)
		{
			text = " 自 卡 迈 佩 • 琼 布 拉 特 被 暗 杀 后 ， 接 手 黎 巴 嫩 全 国 运 动 的 卡 迈 佩 之 子 瓦 利 德 • 琼 布 拉 特 对 左 翼 思 想 以 及 处 于 贫 困 中 的 什 叶 派 群 体 并 不 感 兴 趣 ， 实 际 上 由 于 其 狭 隘 的 德 鲁 兹 至 上 情 结 ， 将 大 量 的 什 叶 派 远 离 了 抵 抗 阵 线 而 转 向 阿 迈 勒 运 动 和 真 主 党 ， 使 得 全 国 运 动 名 存 实 亡 。 而 整 个 进 步 社 会 党 和 人 民 解 放 军 更 是 变 成 琼 布 拉 特 家 族 一 人 的 资 产 。 显 然 ， 德 不 配 位 的 小 琼 布 拉 特 压 根 不 该 坐 在 黎 巴 嫩 左 翼 抵 抗 派 的 领 袖 席 上 ， 是 时 候 清 除 这 个 背 叛 父 辈 与 信 仰 的 投 机 政 客 了 ！||在 我 们 特 勤 的 运 作 下 ， 党 内 的 左 翼 和 纳 赛 尔 主 义 者 发 起 了 一 场 政 变 ， 瓦 利 德 由 于 “ 保 守 、 不 思 进 取 、 豢 养 私 兵 ” 等 错 误 被 开 除 出 党 ， 而 他 父 亲 的 老 朋 友 、 更 为 坚 定 的 纳 赛 尔 主 义 者 法 耶 兹 法 吉 赫 被 推 举 出 作 党 的 领 导 。 恢 复 左 翼 立 场 的 进 步 社 会 党 很 快 加 强 了 与 黎 巴 嫩 共 产 党 、 阿 拉 伯 社 会 主 义 行 动 党 、 共 产 主 义 行 动 组 织 以 及 巴 勒 斯 坦 方 人 阵 民 阵 的 合 作 。 重 新 团 结 一 致 的 左 翼 力 量 很 快 将 马 龙 派 “ 双 头 同 盟 ” 及 盟 友 打 倒 在 地 ， 社 会 主 义 的 红 旗 高 高 挂 在 巴 卜 达 宫 , 宣 告 着 将 近 十 年 的 内 战 以 共 产 主 义 者 的 胜 利 而 结 束 。 ";
			a.data[9] -= 50;
			a.influencePRC += 50;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			GlobalScript.inst.gameState.empires[0].power -= 50;
			GlobalScript.inst.gameState.empires[1].power -= 50;
			GlobalScript.inst.gameState.allcountries[93].Torg = true;
			GlobalScript.inst.gameState.allcountries[93].proprc = true;
			GlobalScript.inst.gameState.allcountries[93].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[93].SubGosstroy = 2;
		}
		if (result_num == 3)
		{
			text = " “ 你 要 上 黎 巴 嫩 哀 号 ， 在 巴 珊 扬 声 ， 从 亚 巴 琳 哀 号 ， 因 为 你 所 亲 爱 的 都 毁 灭 了 。 ” — — 耶 利 米 书   2 2 : 2 0";
			a.event_done[440] = false;
		}
	}
}
