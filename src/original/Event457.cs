using EventsForDLC;
using UnityEngine;

public class Event457 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 宝 岛 回 归 ！";
		text = " 随 着 中 国 人 民 解 放 军 将 五 星 赤 旗 高 高 的 升 在 台 湾 伪 政 府 的 总 统 府 上 时 ， 中 央 人 民 广 播 电 视 总 台 宣 布 了 这 一 项 激 动 人 心 的 消 息 ： 台 湾 终 于 回 归 了 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 为 台 湾 回 归 而 欢 呼 万 岁 ！ 中 华 民 族 万 岁 ！ 战 无 不 胜 的 毛 泽 东 思 想 万 岁 ！ ";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 宝 岛 回 归 ！";
		if (result_num == 0)
		{
			text = " 原 来 的 蒋 经 国 政 府 成 员 要 么 被 活 捉 ， 要 么 被 当 场 击 毙 。 蒋 经 国 本 人 在 坐 飞 机 逃 往 美 国 时 ， 被 一 枚 “ 红 缨 - 6 “ 导 弹 击 落 ， 通 过 眼 镜 碎 片 证 实 了 这 位 伪 政 府 领 导 人 的 死 亡 。 零 星 的 抵 抗 运 动 迅 速 被 战 无 不 胜 的 中 国 人 民 解 放 军 碾 碎 ， 大 部 分 伪 政 府 官 兵 选 择 向 我 们 投 降 ， 这 也 保 证 了 我 们 不 会 发 生 手 足 相 残 的 惨 剧 。 前 政 府 高 官 将 被 流 放 到 曾 经 的 露 天 监 狱 — — 绿 岛 ， 为 他 们 欺 压 台 湾 百 姓 而 赎 罪 。 总 有 些 人 说 我 们 这 是 搞 “ 红 色 恐 怖 ” 。 但 是 谁 在 乎 他 们 呢 ！\n 美 帝 国 主 义 日 薄 西 山 ， 他 们 再 也 不 会 对 我 们 收 复 台 湾 指 手 画 脚 了 ， 各 国 的 进 步 人 士 纷 纷 发 来 贺 电 。 同 时 ， 台 湾 民 主 自 治 同 盟 ， 台 湾 劳 动 党 和 台 湾 共 产 党 将 会 组 成 中 国 共 产 党 （ 台 湾 支 部 ） 暂 时 担 任 党 机 关 。 吴 荣 元 担 任 首 任 党 主 席 。 在 有 效 的 政 府 机 关 成 立 之 前 ， 他 们 将 行 使 行 政 责 任 。 在 经 济 方 面 大 部 分 外 企 被 驱 逐 ， 或 者 被 国 有 化 。 我 们 也 开 始 了 一 项 雄 心 勃 勃 的 铺 设 海 底 隧 道 的 方 案 ， 这 将 把 祖 国 和 宝 岛 联 系 的 更 为 紧 密 。\n 中 正 纪 念 堂 和 全 台 各 地 的 蒋 介 石 纪 念 碑 都 被 拆 除 ， 蒋 介 石 的 遗 体 被 火 化 后 投 入 海 底 ， 没 有 人 会 怀 念 这 个 暴 君 。 同 时 这 一 广 场 也 被 改 名 为 “ 二 · 二 八 广 场 ” （ 或 统 一 广 场 ） 。 广 场 上 树 立 起 了 一 尊 汉 白 玉 雕 像 ， 象 征 着 台 湾 和 大 陆 居 民 的 两 人 合 抱 着 一 块 刻 有 中 华 人 民 共 和 国 完 整 地 图 的 雕 刻 。 下 面 用 简 体 字 和 繁 体 字 写 着 “ 伟 大 的 祖 国 统 一 万 岁 ！ 挣 脱 了 铁 链 的 台 湾 人 民 万 岁 ！ ” ";
			a.data[1] += 200;
			a.data[3] += 200;
			a.data[4] = 0;
			a.empires[0].relations = 0;
		}
	}
}
