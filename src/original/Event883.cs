using EventsForDLC;
using UnityEngine;

public class Event883 : EventsSecond
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
		name = " 潮 水 如 此 涨 涨 落 落";
		text = " 在 我 们 的 非 洲 战 友 夺 取 了 政 权 之 后 ， 他 们 只 是 止 步 于 所 谓 的 “ 民 族 民 主 革 命 ” 阶 段 ， 是 时 候 了 。 该 让 我 们 教 教 穆 加 贝 同 志 怎 么 建 设 社 会 主 义 了 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 是 时 候 了 ， 红 太 阳 照 遍 全 球 ！";
		button_text[1] = " 这 样 太 疯 狂 了";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 潮 水 如 此 涨 涨 落 落";
		switch (result_num)
		{
		case 0:
			text = " 在 近 日 ， 我 们 邀 请 罗 伯 特 · 穆 加 贝 同 志 来 到 我 国 ， 展 开 为 期 一 周 的 国 事 访 问 。 在 访 问 的 路 上 ， 门 格 斯 图 主 席 参 观 了 革 命 军 事 博 物 馆 ， 山 西 交 城 县 ， 韶 山 毛 主 席 故 居 等 诸 多 带 有 “ 红 色 基 因 ” 特 色 的 建 筑 。 他 拜 访 了 毛 泽 东 主 席 的 纪 念 馆 和 纪 念 碑 ， 亲 自 送 上 了 插 有 嘉 兰 的 花 环 ， 他 还 参 观 了1969 年 珍 宝 岛 战 争 纪 念 碑 。 在 人 民 大 会 堂 的 招 待 宴 席 上 ， 穆 加 贝 总 理 高 度 赞 扬 了 " + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 的 社 会 主 义 建 设 和 个 人 崇 拜 。 再 喝 了 几 杯 后 ， 不 知 道 是 失 态 还 是 刻 意 的 ， 他 说 了 这 样 一 番 话 ： “ 这 确 实 是 个 人 崇 拜 ， 但 谁 让 英 雄 本 来 如 此 呢 ！ ”||在 回 国 后 ， 他 开 展 了 一 系 列 激 进 的 改 革 。ZANU-PF ，ZAPU ， 津 巴 布 韦 民 主 党 均 被 整 合 为 津 巴 布 韦 统 一 社 会 主 义 运 动 ， 联 合 非 洲 民 族 委 员 会 和 罗 得 西 亚 阵 线 党 作 为 花 瓶 ， 成 为 了 这 个 国 家 民 主 的 最 后 一 块 遮 羞 布 。 穆 加 贝 和 他 的 亲 戚 战 友 们 身 居 高 位 ， 他 年 仅 1 3 岁 的 儿 子 ， 仅 仅 是 对 篮 球 有 兴 趣 ， 就 被 任 命 为 津 巴 布 韦 奥 委 会 主 席 。 面 对 敌 人 ， 他 也 毫 不 手 软 。 他 开 始 了 代 号 细 雨 行 动 的 政 治 迫 害 。 针 对 的 不 是 白 人 而 是 另 一 个 土 著 族 群 ， 马 塔 贝 莱 人 ， 这 次 清 洗 人 口 损 失 超 过 两 万 ， 致 使ZANU—PF 内 部 最 大 反 对 派 被 连 根 拔 起 ， 同 时 也 有 已 经 丧 失 权 力 的 前 津 巴 布 韦 非 洲 人 民 革 命 军 军 官 。 并 把 一 切 嫁 祸 于 阵 线 党 ， 伊 安 · 史 密 斯 被 秘 密 处 决 。 他 在 事 实 上 扫 清 了 政 治 敌 人 ， 这 是 一 切 都 是 由 他 手 下 最 精 锐 的 ， 由 我 国 装 备 武 装 起 来 的 国 民 军 第 五 旅 所 造 成 的 。 而 我 们 为 他 在 政 治 上 的 越 发 冷 酷 感 到 了 一 丝 担 忧 。||同 时 ， 他 也 展 开 了 一 项 名 为 “ 快 车 道 ” 的 疯 狂 计 划 。 这 个 计 划 和 朝 鲜 的 “ 千 里 马 运 动 ” ， 我 国 曾 经 的 “ 大 跃 进 ” 颇 有 几 分 相 似 。 副 总 统 约 瑟 夫 • 姆 西 卡 在 宣 布 开 展 “ 快 车 道 ” 土 地 改 革 的 时 候 ， 表 示 将 立 即 将 获 取4558 个 总 面 积880 万 公 顷 的 农 场 用 于 重 新 安 置 ， 几 乎 占 了 全 国 耕 地 的 三 分 之 一 。 许 多 大 地 主 要 么 束 手 就 擒 ， 要 么 就 做 好 被 第 五 旅 武 装 征 收 的 准 备 。 大 量 地 主 不 顾 阻 拦 的 逃 往 邻 国 （ 主 要 是 南 非 ） ， 这 也 表 明 了 穆 加 贝 总 统 正 式 向 白 人 开 战 ， 意 图 用 民 族 主 义 的 大 旗 来 巩 固 自 己 的 统 治 。 他 甚 至 雇 佣 了 无 业 青 年 人 来 进 行 暴 力 的 打 砸 抢 ， 用 来 进 行 “ 一 场 触 及 人 民 灵 魂 的 革 命 ” 。 但 穆 加 贝 的 民 族 斗 士 形 象 无 比 拔 高 ， 他 的 理 论 也 正 式 被 列 为 毛 泽 东 之 后 的 又 一 个 开 创 性 理 论 “ 毛 泽 东 - 穆 加 贝 主 义 ” 。||<color=red>有 些 时 候 ， 革 命 必 须 沐 浴 鲜 血 。</color>";
			GlobalScript.inst.gameState.allcountries[127].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 19;
			GlobalScript.inst.gameState.allcountries[127].JoinAllOurAlliances(yes: true);
			GlobalScript.inst.gameState.allcountries[127].soc_stab = 1000;
			GlobalScript.inst.gameState.data[8] -= 100;
			GlobalScript.inst.gameState.data[9] -= 100;
			GlobalScript.inst.gameState.influencePRC += 50;
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.empires[1].relations -= 150;
			break;
		case 1:
			text = " 说 笑 了 ， 主 席 同 志 ， 他 不 过 是 津 巴 布 韦 又 一 个 普 通 的 不 能 再 普 通 的 黑 人 领 袖 罢 了 。";
			GlobalScript.inst.gameState.event_done[883] = false;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
