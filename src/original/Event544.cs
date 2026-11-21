using EventsForDLC;
using UnityEngine;

public class Event544 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 和 平 利 剑";
		text = " 主 席 同 志 ， 得 益 于 我 国 两 弹 一 星 工 程 的 推 进 ， 我 国 6 0 年 代 的 核 武 器 与 导 弹 事 业 发 展 神 速 。 但 由 于 我 国 核 武 器 起 步 晚 ， 导 弹 投 送 能 力 的 不 足 导 致 我 国 以 反 导 工 程 为 主 ， 不 过 也 取 得 了 如 同 先 锋 级 洲 际 导 弹 防 御 炮 和 一 系 列 战 略 预 警 系 统 这 样 的 成 果 。 随 着 这 几 年 国 内 经 济 的 显 著 发 展 和 周 边 国 际 环 境 的 明 显 改 善 。 我 们 是 否 应 该 转 变 我 们 原 先 的 核 武 器 发 展 战 略 ？ 当 然 ， 您 可 以 选 择 继 续 深 化 原 来 的 方 针 ， 亦 或 我 们 下 个 大 血 本 ， 两 者 都 要 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 我 们 坚 决 不 搞 霸 权 主 义 ， 坚 持 毛 主 席 的 核 武 器 防 御 战 略 方 针";
		button_text[1] = " 为 了 更 好 的 保 卫 革 命 ， 我 们 必 须 完 全 震 慑 敌 人 ！";
		button_text[2] = " 两 手 抓 才 能 更 好 地 保 卫 革 命 ！";
		button_text[3] = " 和 平 与 发 展 才 是 当 今 的 潮 流 ， 再 说 我 们 当 下 实 在 拮 据 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 和 平 利 剑";
		if (result_num == 0)
		{
			text = " 在 您 的 指 示 下 ， 国 防 科 委 继 续 深 化 了 现 有 的 方 略 ， 把 原 先 的 6 4 0 计 划 继 续 扩 大 ， 并 且 加 大 对 6 4 0 - 3 中 的 激 光 反 导 武 器 这 一 具 有 前 瞻 性 战 略 武 器 的 投 资 。 在 全 体 技 术 人 员 的 努 力 下 ， 代 号 为 “ 长 矛 ” 的 激 光 反 导 武 器 原 型 机 最 大 输 出 功 率 达 到 了 恐 怖 的 6 吉 瓦 ， 而 这 一 武 器 不 久 后 的 量 产 代 表 着 帝 国 主 义 再 也 不 能 在 中 国 的 领 空 上 猖 獗 了 。";
			a.data[1] += 100;
			a.data[3] += 100;
			a.data[6] -= 50;
			a.data[8] -= 100;
			string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
			int num = 50;
			old_modify_desc[num] += " <color=red>| 核 防 御 措 施 ：</color>| 军 力+0.7 ， 外 交 声 誉-0.5";
		}
		if (result_num == 1)
		{
			text = " 国 防 科 委 迅 速 改 变 了 过 去 的 方 针 ， 并 拟 稿 了 《 新 一 代 核 武 器 战 略 发 展 计 划 书 》 并 交 给 最 高 领 导 人 和 中 央 军 委 决 断 。 在 得 到 支 持 和 资 金 投 入 后 ， 多 个 军 工 院 系 很 快 联 合 攻 坚 开 发 了 我 国 的 新 一 代 核 弹 和 导 弹 。 很 快 ， 更 具 针 对 性 的 小 型 核 武 器 和 非 常 规 的 核 磁 爆 弹 的 实 验 型 相 继 推 出 ， 而 高 超 音 速 的 导 弹 也 初 步 研 究 完 成 。 帝 国 主 义 者 更 是 寝 食 难 安 了 ！";
			a.data[1] += 150;
			a.data[3] += 150;
			a.data[6] += 30;
			a.data[8] -= 150;
			string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
			int num2 = 50;
			old_modify_desc2[num2] += " <color=red>| 核 威 慑 措 施 ：</color>| 军 力+2.0 ， 美 苏 关 系-0.2";
		}
		if (result_num == 2)
		{
			text = " 作 为 这 个 世 界 上 各 国 心 照 不 宣 的 第 三 极 ， 这 两 个 方 案 我 们 完 全 能 同 时 应 付 。 面 对 着 中 央 拨 来 的 海 量 资 金 ， 国 防 科 委 立 马 开 展 设 计 两 套 计 划 并 扩 充 了 几 乎 一 倍 的 人 员 。 原 先 的 6 4 0 计 划 被 继 续 扩 大 ， 而 新 一 代 核 武 器 也 得 到 开 发 。 不 久 后 我 们 将 一 手 拿 着 最 先 进 的 激 光 反 导 武 器 ， 一 手 拿 着 最 先 进 的 核 弹 导 弹 ， 帝 国 主 义 凭 借 着 核 讹 诈 耀 武 扬 威 的 日 子 不 多 了 ！";
			a.data[1] += 250;
			a.data[3] += 250;
			a.data[6] += 50;
			a.data[8] -= 250;
			string[] old_modify_desc3 = GlobalScript.inst.old_modify_desc;
			int num3 = 50;
			old_modify_desc3[num3] += " <color=red>| 核 防 御 与 核 威 慑 措 施 ：</color>| 军 力+4.0 ， 美 苏 关 系-0.4 ， 可 禁 运 美 苏";
		}
		if (result_num == 3)
		{
			text = " 好 吧 ， 只 能 希 望 这 些 省 下 来 的 钱 确 实 能 用 在 经 济 建 设 上 … …";
		}
	}
}
