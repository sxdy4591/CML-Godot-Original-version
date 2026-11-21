using EventsForDLC;
using UnityEngine;

public class Event547 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 高 原 上 巍 峨 利 剑";
		text = " 当 金 珠 玛 米 和 平 解 放 西 藏 时 ， 灰 头 土 脸 的 奴 隶 们 第 一 次 感 受 到 了 作 为 人 的 尊 严 ， 第 一 次 感 受 到 了 挣 脱 枷 锁 的 滋 味 。 最 广 大 的 西 藏 劳 动 人 民 无 比 热 爱 着 党 和 毛 主 席 的 人 民 政 府 ， 甚 至 将 其 代 替 了 过 往 祷 念 的 神 佛 菩 萨 。 但 是 ， 三 四 十 年 来 ， 阴 魂 不 散 的 非 法 喇 嘛 流 亡 政 府 无 时 无 刻 紧 盯 着 西 藏 的 局 势 ， 他 们 罪 恶 的 黑 手 仍 然 没 有 完 全 退 去 。 而 那 些 被 党 和 政 府 宽 大 处 理 的 喇 嘛 们 也 怀 有 不 可 告 人 的 异 心 ， 他 们 之 中 的 不 少 人 仍 旧 做 着 复 辟 神 权 地 位 的 春 秋 大 梦 。 这 个 群 体 的 一 部 分 活 跃 分 子 已 经 蛊 惑 了 一 些 本 是 善 良 淳 朴 的 底 层 藏 族 群 众 ， 一 些 人 甚 至 渗 透 进 了 新 西 藏 的 党 政 机 关 。 为 了 保 卫 属 于 人 民 的 社 会 主 义 政 权 ， 也 为 了 藏 区 人 民 的 彻 底 觉 醒 ， 我 党 决 定 带 领 最 广 大 藏 区 人 民 在 新 西 藏 毅 然 地 发 动 前 所 未 有 的 社 会 革 命 和 清 算 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 觉 醒 了 的 西 藏 人 民 将 战 无 不 胜 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 高 原 上 巍 峨 利 剑";
		if (result_num == 0)
		{
			text = " 曾 经 无 比 逍 遥 的 喇 嘛 们 仅 仅 过 了 一 夜 就 被 勒 令 离 开 寺 庙 ， 中 上 层 的 神 职 人 员 要 不 彻 底 放 弃 喇 嘛 身 份 作 为 普 通 的 文 化 学 者 工 作 ， 要 不 配 合 党 的 宗 教 改 造 政 策 加 入 相 应 委 员 会 。 显 然 ， 大 部 分 人 两 个 选 项 都 不 想 选 择 。 作 为 回 应 ， 党 立 马 发 动 马 列 主 义 武 装 起 来 的 劳 动 群 众 去 揭 露 那 些 死 不 合 作 者 在 解 放 前 纸 醉 金 迷 的 生 活 和 对 人 民 群 众 穷 凶 极 恶 的 压 迫 。 并 且 ， 党 和 政 府 实 际 上 对 全 藏 区 大 批 斗 期 间 对 喇 嘛 和 活 佛 的 暴 力 行 为 睁 一 只 眼 闭 一 只 眼 ， 那 些 过 去 吃 得 油 光 满 面 的 高 级 僧 侣 们 如 今 脸 上 青 一 块 紫 一 块 ， 佛 道 秘 法 和 奥 义 真 传 此 时 在 阶 级 仇 恨 前 完 全 失 去 了 功 效 。 还 是 在 人 民 子 弟 兵 和 干 部 的 及 时 劝 阻 和 干 预 下 ， 藏 族 群 众 们 逐 渐 冷 静 了 下 来 。 最 后 ， 全 藏 人 民 公 审 大 会 宣 判 那 些 反 动 残 余 以 颠 覆 政 权 和 妄 图 分 裂 罪 判 处 无 期 徒 刑 。||与 此 同 时 ， 党 和 政 府 迅 速 地 推 广 普 通 话 ， 而 内 地 调 来 的 革 命 干 部 们 也 积 极 学 习 藏 族 文 化 和 语 言 。 汉 藏 群 众 守 望 相 助 ， 一 齐 学 习 马 列 毛 思 想 ， 摒 弃 愚 昧 落 后 ， 共 同 谱 写 了 一 曲 民 族 团 结 和 阶 级 友 爱 的 颂 歌 。 过 往 的 布 达 拉 宫 被 彻 底 作 为 阶 级 教 育 的 博 物 馆 而 存 在 ， 一 座 为 纪 念 和 平 解 放 、 屹 立 于 布 达 拉 宫 对 面 的 新 纪 念 碑 也 正 在 筹 建 中 。 西 藏 的 未 来 ， 正 以 一 个 全 新 的 面 貌 而 逐 渐 展 开 。";
			a.data[1] += 100;
			a.data[3] += 100;
		}
	}
}
