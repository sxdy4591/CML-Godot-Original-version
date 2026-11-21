using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event569 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 暴 君 必 尝 恶 果";
		text = " 长 期 以 来 ， 阿 拉 伯 半 岛 的 大 部 分 土 地 都 处 于 沙 特 阿 拉 伯 王 国 的 控 制 之 下 ， 正 如 半 岛 上 的 各 个 君 主 国 家 一 样 ， 沙 特 阿 拉 伯 与 美 国 保 持 着 “ 深 厚 的 特 殊 友 谊 ” （ 在 沙 特 自 由 军 官 组 织 失 败 后 ， 沙 特 阿 拉 伯 请 求 美 国 在 当 地 部 署 了 美 军 基 地 ） ， 通 过 出 售 石 油 赚 得 盆 满 钵 满 ， 并 对 异 见 者 进 行 严 厉 地 镇 压 。 进 入 冷 战 时 期 后 ， 沙 特 阿 拉 伯 的 国 内 并 不 太 平 ， 国 内 已 经 爆 发 过 多 次 效 仿 纳 赛 尔 的 未 遂 军 事 政 变 ； 而 在 1 9 6 7 年 后 ， 在 左 翼 浪 潮 的 影 响 下 ， 阿 拉 伯 半 岛 人 民 联 盟 也 进 行 过 短 暂 的 城 市 游 击 运 动 （ 如 向 国 防 部 投 放 炸 弹 ） ； 受 伊 朗 革 命 时 的 伊 斯 兰 主 义 影 响 ， 1 9 7 9 年 沙 特 也 发 生 了 两 次 重 大 骚 乱 — — 卡 蒂 夫 起 义 和 占 领 麦 加 大 清 真 寺 事 件 。 但 地 下 组 织 的 活 动 仍 然 无 法 打 倒 沙 特 的 专 制 君 主 制 度 。||如 今 ， 美 国 已 经 无 力 维 持 其 在 全 球 的 力 量 存 在 ， 撤 走 了 沙 特 驻 军 。 流 亡 阿 拉 伯 湾 、 也 门 和 约 旦 等 国 的 沙 特 左 翼 人 士 提 出 了 一 个 大 胆 的 方 案 — — 以 约 旦 、 也 门 和 阿 拉 伯 湾 为 根 据 地 ， 发 起 全 半 岛 解 放 战 争 ， 建 立 统 一 的 社 会 主 义 阿 拉 伯 半 岛 共 和 国 ！||主 席 同 志 ， 我 们 是 否 需 要 支 持 他 们 的 方 案 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.data[56] < 2 && (a.allcountries[1].Gosstroy == 1 || a.allcountries[1].SubGosstroy == 0))
		{
			button_text[0] = " 支 持 阿 拉 伯 人 民 团 结 起 来 解 放 全 半 岛 人 民 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 这 太 冒 险 了 ， 革 命 也 不 能 包 办 代 替 … …";
		}
		button_text[1] = " 还 得 再 等 等 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 暴 君 必 尝 恶 果";
		if (result_num == 0)
		{
			text = " 我 们 宣 布 对 沙 特 阿 拉 伯 进 行 制 裁 ， 并 在 盟 国 的 帮 助 下 对 沙 特 阿 拉 伯 进 行 封 锁 。 随 着 沙 特 阿 拉 伯 经 济 陷 入 困 难 ， 物 资 短 缺 ， 工 人 开 始 发 起 罢 工 ， 而 民 众 也 走 上 街 头 ， 抗 议 高 压 的 政 治 环 境 以 及 缺 乏 民 主 的 政 治 制 度 。 骚 乱 从 卡 蒂 夫 地 区 开 始 逐 渐 向 全 国 扩 散 ， 在 我 们 的 特 工 的 帮 助 下 ， 沙 特 地 下 左 翼 开 始 煽 动 群 众 向 政 府 机 构 发 起 冲 击 ， 并 向 民 众 发 放 武 器 ， 组 织 民 兵 ， 筑 起 街 垒 与 军 警 对 峙 。 同 时 ， 在 另 一 边 获 得 我 们 援 助 的 约 旦 、 也 门 和 阿 拉 伯 湾 的 革 命 政 府 也 已 完 成 军 队 集 结 ， 各 国 军 队 与 沙 特 阿 拉 伯 国 内 的 革 命 民 兵 共 同 组 成 了 全 阿 拉 伯 半 岛 革 命 联 军 ， 开 始 向 沙 特 阿 拉 伯 王 国 政 府 发 起 进 攻 。 阿 拉 伯 半 岛 最 后 的 革 命 开 始 了 ！";
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.data[143] += 8;
			a.data[22] -= 150;
			a.ingamewars[37] = new War().Name(" 全 阿 拉 伯 半 岛 解 放 战 争").Attacker(" 沙 特 阿 拉 伯").Defender(" 联 合 阵 线")
				.AttackerInfluence(600)
				.DefenderInfluence(400)
				.TickTime(24)
				.AmericanSupportAttacker.CreateWar;
		}
		if (result_num == 1)
		{
			text = " 现 在 革 命 时 机 并 未 成 熟 ， 我 们 选 择 把 革 命 计 划 放 到 未 来 … …";
			a.event_done[569] = false;
		}
	}
}
