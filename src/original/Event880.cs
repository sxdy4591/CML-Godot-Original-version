using EventsForDLC;
using UnityEngine;

public class Event880 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			return;
		}
		int num = GlobalScript.inst.gameState.party_number[1];
		for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
		{
			if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
			{
				num += GlobalScript.inst.gameState.party_number[i];
			}
		}
		int num2 = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4];
		summa_3_2 = num * 100 / num2;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 兰 开 斯 特 宫 协 议";
		text = " 在 数 年 的 “ 丛 林 战 争 ” 后 ， 罗 得 西 亚 已 然 筋 疲 力 竭 。 因 此 ， 他 们 决 定 成 立 一 个 真 正 的 多 数 派 黑 人 政 府 ， 并 寄 希 望 于 能 够 操 纵 选 举 从 而 继 续 维 持 自 己 的 优 势 地 位 。||1979 年8 月1 日 至7 日 ， 英 联 邦 政 府 首 脑 会 议 在 卢 萨 卡 举 行 。 英 国 政 府 邀 请 了 未 得 到 承 认 的 津 巴 布 韦 罗 得 西 亚 政 府 新 任 总 理 阿 贝 尔 . 穆 佐 雷 瓦 主 教 和 爱 国 阵 线 （ 津 巴 布 韦 非 洲 民 族 联 盟 - 津 巴 布 韦 非 洲 联 盟 名 称 ） 领 导 人 ， 参 加 在 兰 开 斯 特 宫 举 行 的 制 宪 会 议 。 会 议 的 目 的 是 讨 论 并 就 独 立 后 的 宪 法 条 款 达 成 一 致 ， 商 定 在 英 国 统 治 下 举 行 选 举 ， 使 津 巴 布 韦 罗 得 西 亚 能 够 走 向 合 法 并 获 得 国 际 社 会 承 认 的 独 立 ， 各 方 通 过 政 治 手 段 解 决 分 歧 。 会 议 于 1979年9月10 日 正 式 开 始 。 英 国 外 交 和 联 邦 事 务 大 臣 卡 林 顿 勋 爵 主 持 了 这 次 会 议 。 会 议 于 1979年9月10 日 至12 月15 日 举 行 ， 共 举 行 了47 场 全 体 会 议 。 1979年9月 下 旬 ， 吉 米 • 卡 特 总 统 在 给 参 议 员 约 翰 - 斯 坦 尼 斯 的 一 封 信 中 称 赞 这 次 会 议 “ 迈 出 了 重 要 的 第 一 步 ” ， 但 认 为 “ 未 来 还 有 许 多 艰 难 的 谈 判 。 ”||也 许 这 次 ， 种 族 主 义 政 权 真 的 要 结 束 了 。 但 我 们 能 做 什 么 呢 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 殖 民 主 义 是 活 不 久 的";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 兰 开 斯 特 宫 协 议";
		GlobalScript.inst.gameState.allcountries[127].name = "南 罗 得 西 亚";
		switch (result_num)
		{
		case 0:
			text = " 《 兰 开 斯 特 宫 协 议 》 将 于1979 年12 月21 日 签 署 。 卡 林 顿 勋 爵 和 伊 恩 • 吉 尔 摩 爵 士 代 表 英 国 签 署 了 该 协 议 ， 阿 贝 尔 • 穆 佐 雷 瓦 和 西 拉 斯 • 蒙 达 瓦 拉 代 表 津 巴 布 韦 罗 得 西 亚 政 府 签 署 了 该 协 议 ， 罗 伯 特 • 穆 加 贝 和 约 书 亚 • 恩 科 莫 代 表 爱 国 阵 线 签 署 了 该 协 议 。 罗 伯 特 • 马 修 斯 认 为 ， 兰 开 斯 特 宫 谈 判 的 成 功 可 以 通 过 “ 战 场 上 的 力 量 平 衡 明 显 有 利 于 民 族 主 义 者 ” 、 国 际 制 裁 对 罗 得 西 亚 经 济 的 影 响 、 “ 特 定 的 第 三 方 利 益 模 式 ” 以 及 卡 林 顿 勋 爵 作 为 调 解 人 所 带 来 的 资 源 和 技 能 来 解 释 。 该 协 议 也 被 描 述 为 ” 宪 法 妥 协 ” 。||虽 然 该 项 协 议 显 著 降 低 了 国 际 社 会 对 津 巴 布 韦 罗 得 西 亚 的 观 感 ， 但 美 国 仍 然 拒 绝 取 消 制 裁 。||根 据 协 议 条 款 ， 津 巴 布 韦 罗 得 西 亚 暂 时 恢 复 其 原 南 罗 得 西 亚 殖 民 地 地 位 ， 从 而 结 束 了 罗 得 西 亚 单 方 面 宣 布 独 立 所 引 发 的 混 乱 。 索 姆 斯 勋 爵 被 任 命 为 总 督 ， 拥 有 完 全 的 行 政 和 立 法 权 。 该 协 议 将 导 致 几 个 月 前 由 内 部 解 决 方 案 创 建 的 津 巴 布 韦 罗 得 西 亚 这 个 未 被 承 认 的 国 家 的 名 存 实 亡 。 根 据 停 火 协 议 ， <color=#006400>ZAPU</color> 和 <color=#8B0000>ZANU</color> 的 游 击 队 将 在 英 国 的 监 督 下 在 指 定 的 集 合 地 点 集 合 ， 然 后 举 行 选 举 ， 选 出 新 政 府 。";
			break;
		case 1:
			text = " 我 们 甚 至 领 先 于 美 国 和 英 国 政 府 承 认 了 该 国 的 政 权 更 迭 ， 称 其 为 “ 赤 道 非 洲 以 南 的 政 治 奇 迹 ” 。 很 快 ， 我 们 的 国 旗 便 在 索 尔 兹 伯 里 的 街 头 升 起 ， 穆 佐 勒 瓦 代 总 统 在 电 报 中 感 谢 了 中 华 人 民 共 和 国 对 该 国 的 支 持 。 但 是 阿 尔 巴 尼 亚 人 非 常 讨 厌 我 们 的 行 为 ， 称 其 为 “ 中 国 修 正 主 义 者 试 图 在 美 苏 之 间 走 平 衡 木 的 丑 态 ” 。 他 们 不 过 是 吃 不 到 葡 萄 嫌 葡 萄 酸 罢 了 。||穆 佐 雷 瓦 试 图 说 服 英 国 政 府 承 认 过 渡 政 府 ， 但 英 国 政 府 没 有 这 样 做 。 同 样 ， 一 些 人 认 为 该 协 议 是 承 认 罗 得 西 亚 和 取 消 制 裁 的 “ 充 分 ” 理 由 。 美 国 众 议 院 和 美 国 参 议 院 同 意 取 消 制 裁 ， 但 附 加 条 件 是 只 有 “ 举 行 选 举 后 ” 才 能 取 消 制 裁 。 据 报 道 ， 该 协 议 还 导 致 政 治 犯 被 释 放 。 但 是 ， 由 于 当 时 中 上 阶 层 的 构 成 ， 该 国 的 公 务 员 、 司 法 、 警 察 和 武 装 部 队 继 续 由 以 前 的 官 员 管 理 ， 其 中 大 多 数 是 白 人 而 不 是 津 巴 布 韦 本 地 人 。 英 联 邦 秘 书 处 声 称 ， “ 所 谓 的 ‘ 津 巴 布 韦 罗 得 西 亚 宪 法 ’ “ 不 会 比 它 所 取 代 的UDI（ 单 方 面 宣 称 独 立 ） 宪 法 “ 更 合 法 、 更 有 效 ” 。||种 族 隔 离 政 权 已 经 时 日 无 多 了 ， 那 曾 经 是 多 么 独 特 的 一 段 日 子 啊 … …";
			GlobalScript.inst.gameState.allcountries[127].Torg = true;
			a.influencePRC -= 40;
			break;
		case 2:
			text = " 穆 佐 雷 瓦 试 图 说 服 英 国 政 府 承 认 过 渡 政 府 ， 但 英 国 政 府 没 有 这 样 做 。 同 样 ， 一 些 人 认 为 该 协 议 是 承 认 罗 得 西 亚 和 取 消 制 裁 的 “ 充 分 ” 理 由 。 美 国 众 议 院 和 美 国 参 议 院 同 意 取 消 制 裁 ， 但 附 加 条 件 是 只 有 “ 举 行 选 举 后 ” 才 能 取 消 制 裁 。 据 报 道 ， 该 协 议 还 导 致 政 治 犯 被 释 放 。 但 是 ， 由 于 当 时 中 上 阶 层 的 构 成 ， 该 国 的 公 务 员 、 司 法 、 警 察 和 武 装 部 队 继 续 由 以 前 的 官 员 管 理 ， 其 中 大 多 数 是 白 人 而 不 是 津 巴 布 韦 本 地 人 。 英 联 邦 秘 书 处 声 称 ， “ 所 谓 的 ‘ 津 巴 布 韦 罗 得 西 亚 宪 法 ’ “ 不 会 比 它 所 取 代 的UDI（ 单 方 面 宣 称 独 立 ） 宪 法 “ 更 合 法 、 更 有 效 ” 。||种 族 隔 离 政 权 已 经 时 日 无 多 了 ， 那 曾 经 是 多 么 独 特 的 一 段 日 子 啊 … …";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
