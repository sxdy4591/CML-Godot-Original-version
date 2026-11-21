using EventsForDLC;
using UnityEngine;

public class Event607 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "自 豪 吧 ， 塞 舌 尔";
		text = " 主 席 同 志 ， 让 我 们 把 视 野 转 向 印 度 洋 的 一 个 不 知 名 小 国 ： 塞 舌 尔 。 在1974 年 当 地 代 表 与 英 国 的 协 议 中 ， 塞 舌 尔 于1976 年6 月 成 为 独 立 的 共 和 国 ； 而 在 该 国 内 部 主 要 有 两 大 党 派 ： 一 个 是 亲 英 的 执 政 党 塞 舌 尔 民 主 党 ， 其 党 首 詹 姆 斯 · 曼 卡 姆 一 直 以 来 担 任 塞 舌 尔 的 总 督 和 首 相 ， 并 于1976 年 独 立 时 担 任 塞 舌 尔 总 统 ， 另 一 个 则 是 反 对 与 英 国 合 作 的 左 翼 政 党 塞 舌 尔 人 民 联 盟 党 ， 其 党 首 弗 朗 斯 - 阿 尔 贝 · 勒 内 在1976 年 独 立 时 任 塞 舌 尔 总 理 。||但 就 在 最 近 ， 有 消 息 称 塞 舌 尔 人 民 联 盟 党 有 部 分 人 员 在 坦 桑 尼 亚 接 受 军 事 培 训 ， 考 虑 到 曼 卡 姆 即 将 前 往 伦 敦 参 加 英 联 邦 政 府 首 脑 会 议 ， 近 日 定 会 发 生 一 起 政 变 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[8] + a.data[9] >= 20 && a.data[9] >= 20)
		{
			button_text[0] = " 让 我 们 为 塞 舌 尔 的 同 志 们 帮 上 一 忙";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 的 力 量 还 是 不 够";
		}
		Object.Destroy(button[1]);
		button_text[1] = " 我 们 为 什 么 要 帮 助 英 帝 国 主 义 者 助 纣 为 虐 ？";
		button_text[2] = " 拭 目 以 待";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 自 豪 吧 ， 塞 舌 尔";
		if (result_num == 0)
		{
			text = "6 月5 日 ， 在 总 统 曼 卡 姆 出 国 期 间 ， 近 百 名 塞 舌 尔 人 民 联 合 党 的 士 兵 与 部 分 我 们 的 特 勤 占 领 了 首 都 所 在 岛 马 埃 岛 的 战 略 要 地 ， 警 局 全 部 被 攻 下 ， 并 逮 捕 了 六 名 英 国 军 官 顾 问 ， 这 些 顾 问 及 其 家 属 和 塞 舌 尔 最 高 法 院 首 席 大 法 官 奥 布 莱 恩 · 奎 因 被 驱 逐 到 欧 洲 。 塞 舌 尔 人 民 联 合 党 党 首 和 总 理 勒 内 宣 誓 就 任 新 总 统 并 组 建 了 新 的 政 府 但 其 承 诺1979 年 会 再 次 进 行 选 举 ； 其 宣 布 自 己 是 印 度 洋 社 会 主 义 和 坦 桑 尼 亚 式 的 泛 非 主 义 者 ， 并 非 苏 联 式 的 共 产 主 义 者 ， 但 其 与 社 会 主 义 阵 营 尤 其 对 中 国 保 持 密 切 联 系 。 勒 内 对 我 们 提 供 的 帮 助 表 示 十 分 感 激 ， 并 开 始 对 部 分 领 域 实 行 中 国 模 式 ， 我 们 和 坦 桑 尼 亚 也 开 始 对 其 进 行 援 助 ， 包 括 不 限 于 帮 助 建 设 房 屋 ， 派 遣 军 事 顾 问 ， 派 遣 医 疗 队 等 。";
			a.allcountries[155].Gosstroy = 1;
			a.allcountries[155].SubGosstroy = 1;
			a.allcountries[155].LeaveAlliances();
			a.allcountries[155].proprc = true;
			a.allcountries[155].Torg = true;
			a.data[6] += 30;
			a.data[8] -= 20;
			a.data[9] -= 20;
			a.influencePRC += 10;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 20;
		}
		if (result_num == 2)
		{
			text = "6 月5 日 ， 在 总 统 曼 卡 姆 出 国 期 间 ， 近 百 名 塞 舌 尔 人 民 联 合 党 的 士 兵 占 领 了 首 都 所 在 岛 马 埃 岛 的 战 略 要 地 ， 警 局 大 部 分 被 攻 下 ， 仅 在 有 大 量 军 火 库 的 一 个 警 局 里 发 生 激 烈 的 交 火 ， 警 员 和 士 兵 各 有 一 人 死 亡 ， 最 终 逮 捕 了 六 名 英 国 军 官 顾 问 ， 这 些 顾 问 及 其 家 属 和 塞 舌 尔 最 高 法 院 首 席 大 法 官 奥 布 莱 恩 · 奎 因 被 驱 逐 到 欧 洲 。 塞 舌 尔 人 民 联 合 党 党 首 和 总 理 勒 内 宣 誓 就 任 新 总 统 并 组 建 了 新 的 政 府 ； 其 宣 布 自 己 是 印 度 洋 社 会 主 义 和 泛 非 主 义 者 ， 并 非 苏 联 式 的 共 产 主 义 者 ， 并 宣 布 于 1 9 7 9 年 进 行 大 选 ， 但 其 与 社 会 主 义 阵 营 保 持 密 切 关 系 。 坦 桑 尼 亚 以 及 数 个 社 会 主 义 阵 营 国 家 开 始 对 其 进 行 援 助 。";
			a.allcountries[155].Gosstroy = 2;
			a.allcountries[155].SubGosstroy = 3;
			a.allcountries[155].LeaveAlliances();
			a.empires[0].power -= 10;
		}
	}
}
