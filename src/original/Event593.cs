using EventsForDLC;
using UnityEngine;

public class Event593 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 打 倒 暴 君 才 有 自 由 和 平";
		text = " 自 1 9 6 7 年 多 哥 政 变 以 来 ， 纳 辛 贝 · 埃 亚 德 马 便 成 为 了 这 个 弹 丸 之 地 的 无 冕 之 王 。 在 他 的 统 治 之 下 ， 多 哥 人 民 生 活 在 军 警 无 时 无 刻 不 在 的 监 视 之 下 。 经 济 被 以 美 国 和 法 国 为 主 导 的 外 商 所 垄 断 。 他 积 极 的 发 挥 着 任 何 一 个 买 办 政 府 该 做 的 责 任 ： 打 压 革 命 者 ， 讨 好 外 国 政 府 。 他 尤 其 厌 恶 邻 国 加 纳 和 贝 宁 ， 并 在 推 翻 他 们 的 政 变 中 积 极 参 与 。 但 随 着 该 国 经 济 进 一 步 恶 化 ， 越 来 越 多 的 学 生 和 工 人 纷 纷 要 求 他 下 台 。 在 一 场 又 一 次 的 抗 议 之 后 ， 流 血 事 件 还 是 爆 发 了 。 借 此 机 会 ， 加 纳 政 府 和 贝 宁 政 府 已 经 出 台 了 完 整 的 计 划 ， 一 举 干 掉 埃 亚 德 马 。 ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 帝 国 主 义 走 卒 去 死 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 打 倒 暴 君 才 有 自 由 和 平";
		if (result_num == 0)
		{
			text = " 他 们 的 行 动 是 成 功 的 。 凌 晨 ， 一 小 伙 工 人 民 兵 和 空 降 部 队 越 过 加 纳 边 境 ， 借 道 攻 进 了 洛 美 。 他 们 和 总 统 卫 队 发 生 了 交 火 ， 埃 亚 德 马 在 试 图 逃 离 总 统 府 的 路 上 被 击 毙 。 一 枚 火 箭 弹 打 中 了 他 的 座 驾 ， 烈 火 瞬 间 吞 噬 了 他 。 多 哥 人 民 联 盟 的 总 书 记 也 在 袭 击 中 遇 刺 身 亡 。 很 快 ， 一 场 夺 权 运 动 在 多 哥 共 产 党 的 领 导 下 展 开 了 。 多 亏 了 先 前 的 布 局 ， 基 层 士 兵 拒 绝 对 人 民 开 火 ， 而 工 人 武 装 很 快 就 建 立 了 起 来 。 在 贝 宁 和 加 纳 武 装 部 队 的 帮 助 下 ， 内 战 得 以 幸 免 。 多 哥 共 产 党 正 式 宣 布 多 哥 为 “ 以 马 克 思 列 宁 主 义 ， 毛 泽 东 思 想 为 指 导 的 人 民 共 和 国 ” ， 并 宣 布 在 多 哥 开 展 一 场 民 族 民 主 革 命 。 泛 非 社 会 主 义 党 的 左 派 被 吸 纳 入 多 哥 共 产 党 的 预 备 党 员 ， 其 余 则 被 改 组 为 多 哥 爱 国 主 义 阵 线 ， 成 为 了 官 方 的 统 战 组 织 。 革 命 的 内 容 包 括 彻 底 清 算 埃 亚 德 马 的 毒 草 ， 同 时 大 量 的 强 制 征 收 了 外 国 资 本 的 实 业 公 司 。 以 及 更 为 公 平 的 农 村 — 城 市 发 展 计 划 。||该 国 宣 布 对 我 国 友 好 ， " + (a.event_done[500] ? "并 积 极 宣 布 将 投 身 于 非 洲 的 革 命 斗 争 与 解 放" : "并 愿 意 深 化 与 我 们 的 合 作 关 系 。");
			a.data[8] -= 80;
			a.data[9] -= 80;
			a.allcountries[108].Gosstroy = 1;
			a.allcountries[108].SubGosstroy = 17;
			a.allcountries[108].name = " 多 哥 人 民 共 和 国";
			a.allcountries[108].LeaveAlliances();
			a.allcountries[108].EstablishGovernment(Government.ProChina);
			a.allcountries[108].Torg = true;
			a.allcountries[108].soc_stab = 1000;
			a.allcountries[108].JoinAllOurAlliances(yes: true);
		}
	}
}
