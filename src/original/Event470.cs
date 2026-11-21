using EventsForDLC;
using UnityEngine;

public class Event470 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 哪 个 东 方 才 是 红 色 的";
		text = " 自 1966 年 以 来 ， 毛 泽 东 思 想 鼓 舞 了 东 欧 的 年 轻 人 。 现 在 他 们 已 经 势 不 可 挡 ， 我 们 的 东 风 已 然 压 倒 了 苏 联 的 东 风 。 是 时 候 做 出 最 大 胆 的 决 定 了 ： 我 们 将 直 接 夺 取 苏 联 的 几 个 摇 摆 不 定 的 卫 星 国 。 并 把 它 们 作 为 毛 主 义 向 苏 联 与 东 欧 其 余 地 方 传 播 的 堡 垒 。 考 虑 到 苏 联 现 行 政 策 ， 我 们 需 要 做 好 在 苏 联 衰 弱 甚 至 解 体 后 直 接 干 涉 的 准 备 ， 这 也 是 为 了 苏 联 革 命 必 不 可 少 的 一 环 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 我 们 会 做 到 ， 我 们 一 定 要 做 到 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 哪 个 东 方 才 是 红 色 的";
		if (result_num == 0)
		{
			text = " 次 日 ， 波 兰 ， 匈 牙 利 与 罗 马 尼 亚 宣 布 退 出 华 沙 条 约 组 织 和 经 济 互 助 委 员 会 ， 转 而 加 入 中 国 的 组 织 。 南 斯 拉 夫 也 表 现 出 了 愿 意 加 入 我 们 阵 营 的 意 向 。 苏 联 对 此 极 为 不 满 ， 强 烈 谴 责 了 我 国 是 在 搞 “ 大 国 沙 文 主 义 ” “ 谋 图 分 裂 苏 联 与 东 欧 人 民 的 友 好 关 系 ” 。\n 先 前 在 北 京 与 地 拉 那 设 立 办 公 处 的 全 联 盟 共 产 党 （ 新 ） 在 华 沙 和 布 加 勒 斯 特 开 张 了 前 线 办 公 处 ， 借 助 这 两 个 国 家 的 宣 传 机 构 。 北 京 之 声 也 开 始 向 苏 联 东 部 地 区 播 音 ， 借 助 “ 改 革 ” 和 “ 开 放 性 ” 政 策 的 春 风 ， 全 联 盟 共 产 党 得 以 在 一 些 偏 远 地 区 得 到 支 持 者 。 甚 至 组 建 一 些 地 区 人 民 委 员 会 并 开 始 训 练 “ 人 民 卫 队 ” 作 为 准 军 事 武 装 。\n 我 们 也 开 始 了 一 项 雄 心 勃 勃 的 计 划 ， 旨 在 苏 联 发 生 灾 难 性 事 件 后 能 够 快 速 驰 援 。 波 兰 将 负 责 支 持 波 罗 的 海 三 国 和 白 俄 罗 斯 的 革 命 ， 匈 牙 利 与 罗 马 尼 亚 将 干 涉 乌 克 兰 可 能 爆 发 的 内 乱 。 伊 朗 和 阿 富 汗 将 压 制 苏 联 南 部 的 伊 斯 兰 势 力 。 而 我 们 在 必 要 情 况 下 将 会 亲 自 下 场 ， 旨 在 全 面 压 制 苏 联 的 危 机 。\n 这 一 次 ， 我 们 将 从 苏 联 人 的 手 中 拯 救 苏 联 。";
			GlobalScript.inst.gameState.empires[1].relations = 0;
			GlobalScript.inst.gameState.allcountries[4].Gosstroy = 1;
			GlobalScript.inst.gameState.allcountries[4].SubGosstroy = 2;
			GlobalScript.inst.gameState.allcountries[4].proprc = true;
		}
	}
}
