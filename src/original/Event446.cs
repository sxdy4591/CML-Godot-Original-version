using EventsForDLC;
using UnityEngine;

public class Event446 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 法 基 赫 的 监 护";
		text = " 伊 朗 最 新 的 宪 法 颁 布 了 。 此 部 法 案 完 全 以 古 兰 经 为 蓝 本 ， 其 中 最 令 世 俗 派 和 左 翼 难 以 接 受 的 ， 则 是 委 员 会 以53 对8 票 通 过 了 决 议 ， 批 准 了 “ 法 基 赫 的 监 护 ” 这 一 什 叶 派 法 案 ， 这 意 味 着 宗 教 学 者 将 有 机 会 以 纠 错 人 的 身 份 介 入 伊 朗 的 政 治 事 务 。 显 然 这 不 会 得 到 任 何 左 翼 的 支 持 ， 在12 月2 日 ， 以 马 苏 德 · 拉 贾 维 为 首 的 伊 朗 人 民 圣 战 者 走 上 街 头 ， 宣 布 要 和 这 项 反 动 法 案 做 殊 死 搏 斗 。 与 此 同 时 ， 伊 斯 兰 阵 营 内 部 也 爆 发 了 冲 突 ， 一 向 以 温 和 著 称 的 大 阿 亚 图 拉 沙 里 亚 特 马 达 里 谴 责 霍 梅 尼 曲 解 了 教 义 。 双 方 的 支 持 者 正 在 大 不 里 士 陷 入 紧 张 对 峙 。 最 出 人 意 料 的 ， 还 要 属 人 民 党 的 背 叛 。 努 尔 丁 · 卡 亚 诺 里 宣 布 将 支 持 霍 梅 尼 的 决 定 ， 人 民 党 手 下 的 学 生 也 正 在 陷 入 左 右 为 难 的 境 地 。 主 席 同 志 ， 我 们 该 怎 么 做 ？ 也 许 放 任 事 态 发 展 也 不 会 更 糟 糕 ， 但 那 些 无 辜 的 人 也 必 须 因 此 受 难 吗 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.influencePRC >= 150)
		{
			button_text[0] = " 鼓 动 伊 朗 左 翼 和 政 府 对 抗";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 还 没 胆 大 到 这 种 程 度 ！";
		}
		if (GlobalScript.inst.gameState.data[56] <= 1 && GlobalScript.inst.gameState.influencePRC >= 200)
		{
			button_text[1] = " 不 仅 支 持 伊 朗 左 翼 ， 还 要 小 心 的 剔 除 右 派";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 已 经 自 身 难 保 了 ！";
		}
		if (GlobalScript.inst.gameState.data[56] >= 0 && GlobalScript.inst.gameState.influencePRC >= 100)
		{
			button_text[2] = " 人 民 党 迟 早 会 坏 了 我 们 的 事 ， 最 好 现 在 就 干 掉 他 们";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 不 要 破 坏 国 际 共 运 的 团 结 ！";
		}
		button_text[3] = " 口 头 支 持 双 方 冷 处 理";
		button_text[4] = " 伊 朗 ？ 关 我 什 么 事 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 法 基 赫 的 监 护";
		switch (result_num)
		{
		case 0:
			text = " 在 我 方 的 支 持 下 ， 以 人 民 圣 战 者 ， 伊 朗 共 产 主 义 者 联 盟 ， 人 民 党 左 翼 和 “ 风 暴 ” 组 织 的 成 员 形 成 了 一 支 左 翼 同 盟 “ 伊 朗 爱 国 阵 线 ” 。 这 只 组 织 开 始 着 手 训 练 其 武 装 团 体 。 同 时 ， 霍 梅 尼 决 定 派 出 伊 朗 革 命 卫 队 前 去 镇 压 ， 大 不 里 士 西 北 的 伊 朗 空 军 宣 布 支 持 人 民 。 在 双 方 紧 张 对 峙 之 时 ， 左 派 学 生 会 产 生 了 分 裂 ， 一 部 分 机 会 主 义 者 倒 戈 支 持 霍 梅 尼 。 随 着 革 命 卫 队 的 坦 克 开 进 了 大 不 里 士 ， 运 动 也 渐 渐 消 停 。 随 后 ， 大 阿 亚 图 拉 沙 里 亚 特 马 达 里 被 软 禁 。 伊 朗 的 未 来 ， 似 乎 走 向 了 一 个 不 可 控 的 地 步 … …";
			a.data[9] -= 50;
			a.data[8] -= 50;
			a.data[6] += 30;
			a.influencePRC -= 15;
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			a.data[45] -= 100;
			break;
		case 1:
			text = " 在 我 方 的 支 持 下 ， 以 人 民 圣 战 者 ， 伊 朗 共 产 主 义 者 联 盟 ， 人 民 党 左 翼 和 “ 风 暴 ” 组 织 的 成 员 形 成 了 一 支 左 翼 同 盟 “ 伊 朗 爱 国 阵 线 ” 。 这 支 组 织 开 始 着 手 训 练 其 武 装 团 体 。 我 们 的 特 工 决 定 为 革 命 力 量 送 上 一 份 大 礼 ， 在 伊 朗 线 人 的 帮 助 下 ， 我 们 的 特 勤 人 员 找 到 了 努 尔 丁 的 住 所 ， 用 包 在 鲜 花 里 的 炸 药 将 这 个 叛 徒 送 去 了 马 克 思 那 里 。 余 下 的 人 民 党 宣 布 作 为 温 和 力 量 加 入 伊 朗 爱 国 阵 线 。 同 时 ， 霍 梅 尼 决 定 派 出 伊 朗 革 命 卫 队 前 去 镇 压 ， 大 不 里 士 西 北 的 伊 朗 空 军 宣 布 支 持 人 民 。 在 双 方 紧 张 对 峙 之 时 ， 左 翼 阵 线 更 加 团 结 ， 学 生 们 占 领 壁 垒 ， 拿 上63 式 和40 火 ， 做 出 要 和 政 府 决 一 死 战 的 地 步 。 在 极 度 的 高 压 和 多 方 势 力 的 威 胁 下 ， 伊 朗 政 府 宣 布 停 止 围 攻 大 不 里 士 ， 双 方 将 对 新 宪 法 作 出 更 多 讨 论 。\n 看 起 来 ， 神 也 不 过 如 此 。";
			a.data[9] -= 100;
			a.data[8] -= 100;
			a.data[6] += 50;
			a.influencePRC += 80;
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			a.data[45] -= 300;
			break;
		case 2:
			text = " 我 们 的 特 工 决 定 为 伊 朗 人 送 上 一 份 大 礼 ， 在 伊 朗 线 人 的 帮 助 下 ， 我 们 的 特 勤 人 员 找 到 了 努 尔 丁 的 住 所 ， 用 包 在 鲜 花 里 的 炸 药 将 这 个 叛 徒 送 去 了 马 克 思 那 里 。 同 时 ， 霍 梅 尼 决 定 派 出 伊 朗 革 命 卫 队 前 去 镇 压 ， 大 不 里 士 西 北 的 伊 朗 空 军 宣 布 支 持 人 民 。 在 双 方 紧 张 对 峙 之 时 ， 左 派 学 生 会 产 生 了 分 裂 ， 一 部 分 机 会 主 义 者 倒 戈 支 持 霍 梅 尼 。 随 着 革 命 卫 队 的 坦 克 开 进 了 大 不 里 士 ， 运 动 也 渐 渐 消 停 。 随 后 ， 大 阿 亚 图 拉 沙 里 亚 特 马 达 里 被 软 禁 。 伊 朗 的 未 来 ， 似 乎 走 向 了 一 个 不 可 控 的 地 步 … …";
			a.data[9] -= 50;
			a.data[8] -= 50;
			a.data[6] += 30;
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			a.influencePRC += 30;
			a.data[45] -= 200;
			break;
		case 3:
			text = " “ 我 国 不 会 允 许 这 种 对 人 民 开 火 的 暴 行 ， ” 外 交 部 长" + a.names1[a.politics[a.politics_dolshnost[2]].name_1] + a.names2[a.politics[a.politics_dolshnost[2]].name_2] + "同 志 如 是 说 道 ， “ 但 同 时 ， 我 们 也 呼 吁 伊 朗 方 面 冷 静 下 来 ， 不 要 在 自 己 人 身 上 浪 费 弹 药 ， 让 伊 朗 人 的 子 弹 去 杀 伊 朗 人 ！ ” 但 霍 梅 尼 显 然 没 有 听 我 们 的 ， 他 决 定 派 出 伊 朗 革 命 卫 队 前 去 镇 压 ， 大 不 里 士 西 北 的 伊 朗 空 军 宣 布 支 持 人 民 。 在 双 方 紧 张 对 峙 之 时 ， 左 派 学 生 会 产 生 了 分 裂 ， 一 部 分 机 会 主 义 者 倒 戈 支 持 霍 梅 尼 。 随 着 革 命 卫 队 的 坦 克 开 进 了 大 不 里 士 ， 运 动 也 渐 渐 消 停 。 随 后 ， 大 阿 亚 图 拉 沙 里 亚 特 马 达 里 被 软 禁 。 伊 朗 的 未 来 ， 似 乎 走 向 了 一 个 不 可 控 的 地 步 … …";
			a.data[6] -= 50;
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			break;
		case 4:
			text = " 霍 梅 尼 决 定 派 出 伊 朗 革 命 卫 队 前 去 镇 压 ， 大 不 里 士 西 北 的 伊 朗 空 军 宣 布 支 持 人 民 。 在 双 方 紧 张 对 峙 之 时 ， 左 派 学 生 会 产 生 了 分 裂 ， 一 部 分 机 会 主 义 者 倒 戈 支 持 霍 梅 尼 。 随 着 革 命 卫 队 的 坦 克 开 进 了 大 不 里 士 ， 运 动 也 渐 渐 消 停 。 随 后 ， 大 阿 亚 图 拉 沙 里 亚 特 马 达 里 被 软 禁 。 伊 朗 的 未 来 ， 似 乎 走 向 了 一 个 不 可 控 的 地 步 … … 我 也 希 望 ， 我 们 的 不 作 为 不 会 带 来 什 么 灾 难 性 的 后 果 。";
			a.allcountries[8].Gosstroy = 0;
			a.allcountries[8].SubGosstroy = 9;
			break;
		}
	}
}
