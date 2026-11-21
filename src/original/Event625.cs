using EventsForDLC;
using UnityEngine;

public class Event625 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 莫 桑 比 克 ， 光 明 到 来 ？";
		if (a.allcountries[126].level_of_unstab >= 1000)
		{
			text = "随 着 莫 桑 比 克 全 国 抵 抗 运 动 的 最 后 一 个 据 点 被 拔 除 ， 莫 桑 比 克 解 放 阵 线 党 终 于 控 制 了 全 国 。 抵 运 的 残 军 狼 狈 撤 往 了 南 非 。";
		}
		else
		{
			text = "随 着 莫 桑 比 克 解 放 阵 线 党 的 最 后 一 个 据 点 被 拔 除 ， 莫 桑 比 克 抵 抗 运 动 终 于 控 制 了 全 国 。 解 阵 的 残 军 撤 往 了 坦 桑 尼 亚 和 赞 比 亚 。";
		}
		a.allcountries[126].parts[0] = false;
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 接 下 来 会 怎 么 发 展 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 莫 桑 比 克 ， 光 明 到 来 ？";
		if (result_num != 0)
		{
			return;
		}
		if (a.allcountries[126].level_of_unstab >= 1000)
		{
			text = "莫 解 阵 在 莫 桑 比 克 首 都 马 普 托 举 行 了 盛 大 的 阅 兵 仪 式 ， 庆 祝 着 属 于 莫 桑 比 克 人 民 的 胜 利 。 在 内 战 中 犯 下 重 大 罪 行 的 抵 运 成 员 被 公 审 处 决 。 为 了 报 复 南 非 和 支 持 南 部 的 同 志 ， 莫 桑 比 克 加 大 了 对 阿 扎 尼 亚 泛 非 主 义 大 会 、 非 洲 人 国 民 大 会 和 南 非 共 产 党 的 支 持 。 没 有 了 内 部 的 大 敌 ， 莫 解 阵 终 于 能 够 更 加 专 注 于 人 民 民 主 革 命 和 国 家 建 设 ， 并 借 鉴 " + ((a.IsSocialism(yes: true, 1) && a.resultOfEvents[623] != 1) ? "中 国 和 " : null) + "苏 联 的 经 验 开 展 工 业 化 和 进 行 反 部 落 主 义 的 文 化 革 命 。";
			a.allcountries[126].Gosstroy = 1;
			a.allcountries[126].SubGosstroy = 2;
			if (a.IsSocialism(yes: true, 1) && a.resultOfEvents[623] != 1)
			{
				a.allcountries[126].LeaveAlliances();
				a.allcountries[126].Torg = true;
				a.allcountries[126].proprc = true;
				a.influencePRC += 30;
				a.empires[0].relations -= 50;
			}
			a.empires[0].relations -= 50;
			a.empires[0].power -= 30;
		}
		else
		{
			text = "在 南 非 的 支 持 下 ， 莫 桑 比 克 全 国 抵 抗 运 动 终 于 赢 得 内 战 ， 莫 解 阵 党 被 查 禁 ， 新 政 权 开 始 对 前 政 权 的 国 有 资 产 和 集 体 资 产 的 劫 收 式 私 有 化 — — 在 城 市 ， 国 有 企 业 直 接 成 为 了 抵 运 高 官 的 私 有 物 ， 而 在 乡 村 ， 部 落 酋 长 的 权 力 也 再 度 膨 胀 ， 他 们 开 始 霸 占 公 社 村 ， 将 其 据 为 己 有 ， 合 作 社 也 被 解 散 。 这 个 组 织 似 乎 并 不 像 他 们 自 己 所 宣 扬 的 那 样 ， 是 反 共 的 民 主 斗 士 — — 从 该 国 传 来 了 抵 运 犯 下 各 类 暴 行 的 消 息 。 在 电 视 上 ， 被 俘 的 莫 解 阵 的 高 官 被 脱 光 衣 服 ， 割 去 身 体 的 各 种 部 位 后 被 绑 在 海 滩 的 柱 子 上 暴 晒 ； 幸 存 的 莫 解 阵 成 员 撤 入 了 坦 桑 尼 亚 ， 在 坦 桑 尼 亚 的 支 持 下 进 行 着 最 后 的 游 击 抵 抗 。 这 个 被 C I A 称 为 “ 非 洲 红 色 高 棉 ” 的 组 织 的 胜 利 让 国 际 观 察 者 感 到 非 常 不 安 ， 新 的 政 府 几 乎 只 得 到 了 南 非 和 联 邦 德 国 的 承 认 ， 甚 至 在 美 国 ， 也 只 有 最 强 硬 的 保 守 派 才 愿 意 承 认 这 个 政 权 … … 与 此 同 时 ， 在 莫 桑 比 克 ， 由 于 抵 运 支 持 基 督 教 ， 事 实 上 的 对 于 宗 教 自 由 的 剥 夺 开 始 了 ， 这 无 疑 激 起 了 海 岸 线 一 带 穆 斯 林 人 口 的 不 满 ， 让 我 们 看 看 接 下 来 局 势 会 如 何 发 展 … …";
			a.allcountries[126].Gosstroy = 0;
			a.allcountries[126].SubGosstroy = 9;
			a.allcountries[126].LeaveAlliances();
			a.allcountries[126].puppetOf = 131;
			if (a.resultOfEvents[623] == 1)
			{
				a.allcountries[126].Torg = true;
				a.empires[0].relations += 100;
			}
			a.empires[0].power += 30;
		}
	}
}
