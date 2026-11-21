using EventsForDLC;
using UnityEngine;

public class Event475 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 谁 是 我 的 敌 人 ？";
		text = " 在 军 委 政 权 倒 台 后 ， 新 生 的 埃 塞 俄 比 亚 就 两 个 在 推 翻 门 格 斯 图 武 装 斗 争 中 的 少 数 民 族 武 装 ： 提 人 阵 和 厄 人 阵 的 未 来 进 行 了 长 时 间 的 讨 论 。 在 新 生 的 政 权 中 ， 有 人 认 为 应 当 组 建 一 个 民 主 的 联 邦 ， 也 有 人 支 持 列 宁 式 的 民 族 自 决 。 作 为 推 翻 门 格 斯 图 政 权 的 始 作 俑 者 ， 我 们 应 当 有 始 有 终 的 解 决 埃 塞 俄 比 亚 问 题 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 我 们 希 望 他 们 能 组 建 一 个 联 邦";
		button_text[1] = " 两 地 应 当 得 到 自 由 — 独 立 建 国 的 自 由 ！";
		button_text[2] = " 厄 立 特 里 亚 值 得 独 立 ， 但 提 人 阵 将 会 进 入 新 政 府";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 谁 是 我 的 敌 人 ？";
		switch (result_num)
		{
		case 0:
			text = " 在 武 汉 ， 埃 塞 俄 比 亚 人 民 革 命 党 ， 厄 立 特 里 亚 人 民 解 放 阵 线 和 提 格 雷 人 民 解 放 阵 线 就 组 建 统 一 的 埃 塞 俄 比 亚 联 邦 民 主 共 和 国 达 成 了 协 议 。 埃 塞 俄 比 亚 的 各 个 少 数 民 族 得 到 了 极 大 的 自 治 权 。 民 族 谅 解 协 定 将 会 给 埃 塞 俄 比 亚 创 造 新 的 未 来 。 尽 管 有 些 极 端 民 族 主 义 者 拒 绝 这 一 协 定 ， 但 大 部 分 人 都 很 满 意 ， 这 也 就 够 了 ， 美 苏 对 我 们 的 行 为 很 满 意 。 ";
			a.empires[1].relations += 50;
			a.empires[0].relations += 50;
			a.influencePRC += 20;
			break;
		case 1:
			text = " 在 武 汉 ， 埃 塞 俄 比 亚 人 民 革 命 党 ， 厄 立 特 里 亚 人 民 解 放 阵 线 和 提 格 雷 人 民 解 放 阵 线 就 各 自 成 立 单 独 的 国 家 达 成 了 协 定 。 各 国 确 定 了 自 己 的 领 土 实 际 控 制 范 围 。 这 似 乎 给 埃 塞 俄 比 亚 造 成 了 不 小 的 麻 烦 ， 毕 竟 厄 立 特 里 亚 是 他 们 为 数 不 多 的 港 口 ， 而 现 在 ， 埃 塞 俄 比 亚 很 明 显 失 去 了 海 岸 线 … … \n 埃 塞 俄 比 亚 境 内 对 这 一 “ 卖 国 ” 决 定 感 到 非 常 不 满 ， 但 我 们 的 新 盟 友 会 解 决 这 些 问 题 的 ， 对 吧 ？ ";
			a.allcountries[99].parts[0] = true;
			a.allcountries[100].parts[0] = true;
			a.allcountries[99].Gosstroy = a.allcountries[41].Gosstroy;
			a.allcountries[99].SubGosstroy = a.allcountries[41].SubGosstroy;
			a.allcountries[99].proprc = true;
			a.allcountries[99].Torg = true;
			a.allcountries[100].Gosstroy = a.allcountries[41].Gosstroy;
			a.allcountries[100].SubGosstroy = a.allcountries[41].SubGosstroy;
			a.allcountries[100].proprc = true;
			a.allcountries[100].Torg = true;
			a.influencePRC += 10;
			a.allcountries[99].based = true;
			a.allcountries[100].based = true;
			a.allcountries[99].EstablishGovernment(Government.ProChina);
			a.allcountries[100].EstablishGovernment(Government.ProChina);
			break;
		case 2:
			text = " 在 武 汉 ， 埃 塞 俄 比 亚 人 民 革 命 党 和 提 格 雷 人 民 解 放 阵 线 就 组 建 统 一 的 埃 塞 俄 比 亚 联 邦 民 主 共 和 国 达 成 了 协 议 。 埃 塞 俄 比 亚 的 各 个 少 数 民 族 得 到 了 极 大 的 自 治 权 。 而 厄 立 特 里 亚 人 民 解 放 阵 线 则 在 埃 塞 政 府 的 同 意 下 脱 离 埃 塞 而 独 立 。 各 国 确 定 了 自 己 的 领 土 实 际 控 制 范 围 。 这 似 乎 给 埃 塞 俄 比 亚 造 成 了 不 小 的 麻 烦 ， 毕 竟 厄 立 特 里 亚 是 他 们 为 数 不 多 的 港 口 ， 而 现 在 ， 埃 塞 俄 比 亚 很 明 显 失 去 了 海 岸 线 … … ";
			a.allcountries[99].parts[0] = true;
			a.allcountries[99].Gosstroy = a.allcountries[41].Gosstroy;
			a.allcountries[99].SubGosstroy = a.allcountries[41].SubGosstroy;
			a.allcountries[99].proprc = true;
			a.allcountries[99].Torg = true;
			a.allcountries[99].based = true;
			a.allcountries[99].EstablishGovernment(Government.ProChina);
			a.influencePRC += 10;
			break;
		}
	}
}
