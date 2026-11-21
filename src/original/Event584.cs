using EventsForDLC;
using UnityEngine;

public class Event584 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 班 达 斯 坦 的 终 结";
		text = " 自 1 9 6 8 年 成 为 马 拉 维 总 统 以 来 ， 海 斯 廷 斯 · 班 达 便 一 直 掌 控 着 马 拉 维 。 在 其 治 下 ， 马 拉 维 对 内 进 行 极 权 主 义 措 施 ： 执 政 党 马 拉 维 大 会 党 的 准 军 事 化 组 织 马 拉 维 少 先 队 协 助 清 理 反 对 派 ， 为 流 亡 海 外 的 马 拉 维 反 对 派 送 去 邮 寄 炸 弹 等 ， 对 外 则 坚 决 实 行 反 共 外 交 ： 与 台 湾 地 区 的 蒋 氏 政 权 关 系 甚 好 ， 身 为 非 洲 独 立 国 家 与 白 人 南 非 和 萨 拉 查 时 期 的 葡 萄 牙 交 好 ， 因 此 被 左 翼 人 士 批 评 为 “ 班 达 斯 坦 ” 。 现 在 ， 马 拉 维 已 经 被 左 翼 势 力 包 围 ， 我 们 可 以 趁 机 让 班 达 下 台 并 让 流 亡 坦 桑 尼 亚 的 马 拉 维 社 会 主 义 联 盟 （ L E S O M A ） 重 归 马 拉 维 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 就 是 现 在 ， 动 手 吧";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 班 达 斯 坦 的 终 结";
		if (result_num == 0)
		{
			text = " 在 非 盟 的 协 调 下 ， 莫 桑 比 克 ， 赞 比 亚 和 坦 桑 尼 亚 地 区 开 始 对 马 拉 维 进 行 军 事 行 动 。 这 一 次 ， 没 有 了 罗 德 西 亚 的 帮 助 ，";
			if (a.allcountries[131].Gosstroy == 0)
			{
				text += " 就 算 是 白 人 南 非 部 队 都 无 法 帮 助 马 拉 维 。";
			}
			else
			{
				text += " 谁 都 无 法 帮 助 被 包 围 的 马 拉 维 。";
			}
			text = text + " 很 快 ， 三 国 联 军 便 将 马 拉 维 全 境 彻 底 占 领 ， 马 拉 维 民 主 共 和 国 成 立 ， 由 L E S O M A 担 任 执 政 党 。 L E S O M A 上 台 之 后 ， 便 宣 布 实 行 泛 非 的 、 马 列 主 义 的 社 会 主 义 ， 加 入 非 盟 并 实 行 类 似 乌 贾 马 的 合 作 化 运 动 和 工 厂 国 有 化 运 动 ， " + ((a.allcountries[38].Gosstroy == 0 && !a.completedDecisions[7]) ? " 与 台 湾 当 局 断 交 并 " : null) + "与 我 们 重 新 建 交 ， 将 马 拉 维 大 会 党 及 其 准 军 事 组 织 马 拉 维 少 先 队 进 行 强 制 解 散 ， 高 层 被 关 入 大 牢 ， 班 达 本 人 则 以 反 革 命 罪 ， 叛 国 罪 ， 镇 压 反 对 派 等 罪 名 被 处 以 死 刑 ， 其 私 人 财 产 则 被 充 公 。 由 于 马 拉 维 经 济 发 展 落 后 ， 非 盟 和 我 国 开 始 为 马 拉 维 提 供 一 笔 发 展 资 金 ， 用 以 建 造 发 电 厂 ， 发 展 教 育 等 。";
			a.data[8] -= 50;
			a.allcountries[125].Gosstroy = 1;
			a.allcountries[125].SubGosstroy = 1;
			a.allcountries[125].LeaveAlliances();
			a.allcountries[125].proprc = true;
			a.allcountries[125].Torg = true;
			a.influencePRC += 20;
			a.data[6] += 15;
		}
	}
}
