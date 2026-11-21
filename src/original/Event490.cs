using EventsForDLC;
using UnityEngine;

public class Event490 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 在 三 色 旗 的 光 辉 下";
		if (a.allcountries[5].spec == 1)
		{
			text = " 在 看 似 稳 定 的 罗 马 尼 亚 内 部 ， 已 经 形 成 了 一 批 规 模 不 小 的 异 见 者 。 其 中 ， 格 奥 尔 基 · 阿 波 斯 托 尔 的 支 持 者 已 经 在 罗 共 党 内 形 成 了 一 股 势 力 ， 而 齐 奥 塞 斯 库 尚 未 察 觉 ， 我 们 应 当 趁 这 个 机 会 ， 一 举 推 翻 齐 奥 塞 斯 库 ， 让 社 会 主 义 重 回 罗 马 尼 亚 。 ";
		}
		else if (a.allcountries[5].spec == 2)
		{
			text = " 在 看 似 稳 定 的 罗 马 尼 亚 内 部 ， 已 经 形 成 了 一 批 规 模 不 小 的 异 见 者 。 其 中 ， 扬 · 伊 利 埃 斯 库 的 支 持 者 已 经 在 罗 共 党 内 形 成 了 一 股 势 力 ， 而 齐 奥 塞 斯 库 尚 未 察 觉 ， 我 们 应 当 趁 这 个 机 会 ， 一 举 推 翻 齐 奥 塞 斯 库 ， 让 社 会 主 义 重 回 罗 马 尼 亚 。 ";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 是 时 候 了 ， 让 多 瑙 河 倒 流 吧 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 在 三 色 旗 的 光 辉 下";
		if (result_num != 0)
		{
			return;
		}
		if (a.allcountries[5].spec == 1)
		{
			text = " 在 我 们 的 直 接 授 意 下 ， 一 批 匈 牙 利 族 官 员 在 最 近 的 罗 马 尼 亚 共 产 党 大 会 上 批 判 了 齐 奥 塞 斯 库 的 政 策 ， 例 如 ： 强 制 性 的 生 育 政 策 ， 极 其 强 硬 的 罗 马 尼 亚 化 ， 丧 失 民 心 的 紧 缩 政 策 和 修 正 主 义 的 经 济 政 策 。 很 快 ， 星 星 之 火 就 烧 到 了 布 加 勒 斯 特 ， 在 那 里 这 个 独 裁 者 希 望 能 得 到 军 队 的 庇 护 ， 但 军 队 早 已 倒 向 了 革 命 者 。 爱 国 卫 队 在 公 路 上 截 获 了 这 位 试 图 逃 脱 人 民 审 判 的 大 公 。 在 最 高 法 院 的 审 判 下 ， 齐 奥 塞 斯 库 与 夫 人 因 贪 污 而 被 判 处 2 0 0 年 有 期 徒 刑 。||他 的 接 班 人 将 是 流 亡 在 海 外 的 罗 共 正 统 派 领 袖 阿 波 斯 托 尔 。 早 年 间 因 为 政 治 手 段 过 于 天 真 ， 他 被 齐 奥 塞 斯 库 一 脚 踢 出 了 中 央 圈 子 。 现 在 在 我 们 的 支 持 下 ， 他 得 以 回 到 布 加 勒 斯 特 。 群 众 希 望 他 的 政 策 会 比 前 任 好 些 。 而 他 们 没 有 期 待 错 人 。 阿 波 斯 托 尔 重 新 调 整 了 过 分 的 重 工 业 政 策 ， 开 始 着 手 组 织 更 有 效 的 工 人 指 导 性 企 业 ， 并 下 方 一 部 分 权 力 ， 由 工 人 自 发 的 组 成 委 员 会 管 理 企 业 ； 农 业 上 的 集 体 化 也 得 以 重 新 开 始 。 马 扎 尔 自 治 区 也 得 以 恢 复 ， 罗 马 尼 亚 正 在 向 好 的 一 面 发 展 。 而 紧 缩 政 策 也 作 为 齐 奥 塞 斯 库 时 代 的 遗 物 被 废 除 。||";
			if (GlobalScript.inst.gameState.allcountries[20].spec == 1)
			{
				text += " 新 政 权 继 承 了 前 政 权 在 巴 尔 干 联 盟 中 的 成 员 国 席 位 ， 各 国 间 的 合 作 更 加 紧 密 。";
			}
			a.allcountries[5].Gosstroy = 0;
			a.allcountries[5].SubGosstroy = 0;
			a.allcountries[5].Torg = true;
			a.allcountries[5].prosov = false;
			a.allcountries[5].proprc = true;
			a.empires[1].relations -= 100;
			a.influencePRC += 20;
			a.empires[0].relations += 100;
		}
		else if (a.allcountries[5].spec == 2)
		{
			text = " 多 亏 了 我 国 媒 体 像 潮 水 般 的 攻 势 ， 以 及 部 分 民 众 对 政 府 政 策 的 明 显 不 满 ， 罗 马 尼 亚 局 势 逐 渐 紧 张 。 蒂 米 什 瓦 拉 局 势 已 然 失 控 ， 持 不 同 政 见 者 （ 匈 牙 利 人 ） 被 捕 后 ， 匈 牙 利 少 数 民 族 开 始 骚 乱 ， 大 匈 牙 利 民 族 主 义 者 多 次 挑 衅 ，   迫 使 罗 马 尼 亚 军 队 和 内 政 部 介 入 。 我 们 的 媒 体 发 起 了 针 对 齐 奥 塞 斯 库 的 运 动 ， 并 播 放 了 “ 罗 马 尼 亚 警 察 和 军 队 杀 死 的 受 害 者 尸 体 ” 的 照 片 。 政 府 官 方 的 辟 谣 被 自 发 性 的 抵 制 了 ， 在 布 加 勒 斯 特 ， 对 现 行 政 策 不 满 的 人 群 开 始 走 上 街 头 ， 主 要 推 动 力 量 是 学 生 。 反 对 “ 新 吸 血 鬼 ”   的 口 号 与 推 翻 现 政 府 的 呼 声 产 生 了 共 鸣 。||不 久 ， 在 首 都 ， 真 正 的 骚 乱 以 及 现 政 权 支 持 者 和 反 对 者 之 间 的 对 抗 开 始 了 。 对 此 ， 齐 奥 塞 斯 库 决 定 大 力 镇 压 。 这 无 形 中 促 成 了 他 的 死 亡 ： 考 虑 到 该 国 的 危 急 局 势 ， 苏 联 共 产 党 决 定 撤 销 尼 古 拉 · 齐 奥 塞 斯 库 的 权 力 ， 并 “ 敦 促 ” 扬 · 伊 利 埃 斯 库 担 任 党 总 书 记 。 不 稳 定 的 局 势 并 没 有 持 续 多 久 ， 军 方 根 据 新 政 府 的 命 令 逮 捕 了 齐 奥 塞 斯 库 。||伊 利 埃 斯 库 在 电 视 上 发 表 讲 话 ， 承 诺 “ 大 规 模 实 行 开 放 、 在 罗 马 尼 亚 共 产 党 的 领 导 下 进 行 政 治 自 由 化 并 准 备 经 济 改 革 ” 。 紧 接 着 ， 罗 马 尼 亚 前 总 统 被 法 庭 宣 判 犯 有 谋 杀 罗 马 尼 亚 人 民 罪 ， 电 视 上 全 场 直 播 了 他 的 审 判 ， 齐 奥 塞 斯 库 和 他 的 妻 子 被 处 决 。 在 这 以 后 ， “ 齐 奥 塞 斯 库 的 支 持 者 ” 消 失 了 ， 现 有 制 度 的 前 反 对 者 开 始 在 首 都 进 行 和 平 的 亲 政 府 “ 胜 利 ” 游 行 ， 尽 管 有 人 谈 到 需 要 彻 底 推 翻 共 产 党 人 的 权 力 ； 这 是 当 时 唯 一 被 警 察 拘 留 的 人 。 扬 · 伊 利 埃 斯 库 面 临 着 一 项 艰 巨 的 任 务 ： 作 为 一 名 共 产 党 员 和 反 对 派 ， 他 必 须 在 改 革 国 家 的 同 时 维 护 党 的 权 力 。 他 没 有 权 利 犯 错 误 ， 否 则 新 一 波 的 “ 民 众 愤 怒 ” 将 会 炸 垮 罗 马 尼 亚 新 任 国 家 元 首 。 紧 缩 政 策 作 为 齐 奥 塞 斯 库 时 代 的 遗 物 也 被 废 除 。 ";
			if (GlobalScript.inst.gameState.allcountries[20].spec == 1)
			{
				text += " 新 政 权 和 巴 尔 干 联 盟 的 保 持 了 一 个 不 温 不 火 的 态 度 ， 虽 有 关 系 ， 但 罗 马 尼 亚 屡 次 拒 绝 出 席 巴 尔 干 国 家 元 首 议 会 。";
			}
			a.allcountries[5].Gosstroy = 2;
			a.allcountries[5].SubGosstroy = 15;
			a.allcountries[5].Torg = true;
			a.empires[1].relations += 100;
			a.influencePRC += 20;
			a.empires[0].relations += 200;
			GlobalScript.inst.gameState.empires[1].leaders[6].support++;
		}
	}
}
