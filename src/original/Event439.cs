using EventsForDLC;
using UnityEngine;

public class Event439 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 戈 兰 高 地 问 题";
		text = " 1967年 六 · 五 战 争 — — 第 三 次 中 东 战 争 期 间 ， 以 色 列 侵 占 戈 兰 高 地 ， 叙 利 亚 撤 走 了 守 军 ， 大 部 分 叙 利 亚 居 民 也 纷 纷 逃 离 戈 兰 高 地 ， 留 居 此 地 的 居 民 大 多 是 德 鲁 兹 派 穆 斯 林 ， 并 且 大 部 分 人 拒 绝 加 入 以 色 列 国 籍 而 保 留 叙 利 亚 国 籍 。1973 年 中 东 十 月 战 争 — — 第 四 次 中 东 战 争 爆 发 ， 叙 利 亚 军 队 攻 占 谢 赫 山 及 以 色 列 的 一 些 阵 地 ， 进 攻 库 奈 特 拉 城 并 占 领 了 周 围 的 一 些 村 庄 。1974 年5 月31 日 双 方 达 成 协 议 ， 以 色 列 军 队 撤 离 戈 兰 高 地 东 部 的 狭 长 地 带 ， 让 出 库 奈 特 拉 城 。 设 置 了1.2 至3.6 英 里 的 缓 冲 地 带 ， 由 联 合 国 派 部 队 进 驻 。 之 后 ， 以 色 列 在 占 领 区 内 修 建 了 数 十 个 犹 太 人 定 居 点 。 黎 巴 嫩 战 争 之 后 ， 或 许 我 们 能 利 用 我 们 的 影 响 力 ， 尝 试 组 织 谈 判 以 解 决 这 一 问 题 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 主 权 归 叙 利 亚 ， 当 地 的 居 民 地 位 一 律 平 等 ， 并 组 织 由 双 方 共 同 监 督 的 自 治 区";
		button_text[1] = " 戈 兰 高 地 是 叙 利 亚 的 拥 有 合 法 主 权 的 领 土 ， 犹 太 殖 民 者 必 须 离 开 ！";
		button_text[2] = " 显 然 ， 叙 利 亚 应 该 承 认 戈 兰 高 地 的 正 确 归 属";
		button_text[3] = " 推 迟 谈 判 议 程";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 戈 兰 高 地 问 题";
		if (result_num == 0)
		{
			if (((GlobalScript.inst.gameState.data[85] == 1 || GlobalScript.inst.gameState.data[85] == 2) && GlobalScript.inst.gameState.influencePRC >= 400) || ((GlobalScript.inst.gameState.influencePRC >= 500 || GlobalScript.inst.gameState.empires[0].power >= 500) && GlobalScript.inst.gameState.allcountries[37].SubGosstroy != 9 && GlobalScript.inst.gameState.allcountries[14].dev == 1))
			{
				text = " 根 据 我 们 的 方 案 ， 以 色 列 承 认 该 地 主 权 归 属 于 叙 利 亚 ， 由 双 方 共 同 组 织 一 个 自 治 委 员 会 管 理 当 地 的 居 民 。 双 方 发 表 声 明 ， 宣 布 当 地 的 语 言 与 民 族 均 平 等 。 联 合 国 部 队 正 在 撤 出 该 地 。 双 方 对 这 个 方 案 都 很 满 意 。";
				a.influencePRC += 100;
				GlobalScript.inst.gameState.empires[0].relations -= 100;
				GlobalScript.inst.gameState.empires[1].relations += 100;
				GlobalScript.inst.gameState.empires[0].power -= 100;
				GlobalScript.inst.gameState.allcountries[35].Torg = true;
				GlobalScript.inst.gameState.allcountries[35].prosov = false;
				GlobalScript.inst.gameState.allcountries[35].proprc = true;
				GlobalScript.inst.gameState.allcountries[37].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[37].Torg = true;
			}
			else
			{
				text = " 双 方 拒 绝 我 们 解 决 戈 兰 高 地 问 题 的 方 案 ， 并 拒 绝 参 与 谈 判 。(需 要 任 意 除 建 立 联 邦 的 巴 以 谈 判 成 功 ， 中 国 影 响 力 大 于40 ； 或 中 国 / 美 国 影 响 力 大 于50 ， 以 色 列 存 在 且 没 有 变 为 法 西 斯 主 义 ， 爆 发 了 海 湾 战 争 且 萨 达 姆 失 败 )";
				a.influencePRC -= 50;
			}
		}
		if (result_num == 1)
		{
			if (GlobalScript.inst.gameState.data[85] == 3 && GlobalScript.inst.gameState.allcountries[35].Gosstroy == 1 && GlobalScript.inst.gameState.influencePRC >= 400)
			{
				text = " 根 据 我 们 的 方 案 ， 巴 以 联 邦 将 戈 兰 高 地 归 还 给 叙 利 亚 ， 尽 管 这 一 方 案 引 起 了 某 些 国 家 的 不 满 。 当 地 的 犹 太 移 民 将 被 强 制 迁 回 他 们 的 国 家 。 叙 利 亚 感 谢 我 们 对 他 们 的 帮 助 ， 并 宣 布 将 加 强 与 我 们 的 合 作 。";
				a.influencePRC += 100;
				GlobalScript.inst.gameState.empires[0].relations -= 200;
				GlobalScript.inst.gameState.empires[1].relations -= 100;
				GlobalScript.inst.gameState.empires[0].power -= 150;
				GlobalScript.inst.gameState.allcountries[35].Torg = true;
				GlobalScript.inst.gameState.allcountries[35].prosov = false;
				GlobalScript.inst.gameState.allcountries[35].proprc = true;
			}
			else
			{
				text = " 双 方 拒 绝 我 们 解 决 戈 兰 高 地 问 题 的 方 案 ， 并 拒 绝 参 与 谈 判 。（需 要 巴 以 联 邦 成 立 ， 叙 利 亚 为 社 会 主 义 ， 中 国 影 响 力 大 于40 ）";
				a.influencePRC -= 50;
			}
		}
		if (result_num == 2)
		{
			if (GlobalScript.inst.gameState.allcountries[93].puppetOf == 37)
			{
				text = " 根 据 我 们 的 方 案 ， 叙 利 亚 承 认 了 戈 兰 高 地 属 于 以 色 列 ， 尽 管 这 一 方 案 引 起 了 某 些 国 家 的 不 满 。 当 地 剩 余 的 叙 利 亚 居 民 正 在 陆 续 撤 回 叙 利 亚 。 以 色 列 感 谢 我 们 对 他 们 的 帮 助 ， 并 宣 布 将 加 强 与 我 们 的 合 作 。";
				a.influencePRC += 50;
				GlobalScript.inst.gameState.empires[0].relations += 150;
				GlobalScript.inst.gameState.empires[1].relations -= 100;
				GlobalScript.inst.gameState.empires[0].power += 150;
				GlobalScript.inst.gameState.empires[1].power -= 100;
				GlobalScript.inst.gameState.allcountries[37].Torg = true;
			}
			else
			{
				text = " 双 方 拒 绝 我 们 解 决 戈 兰 高 地 问 题 的 方 案 ， 并 拒 绝 参 与 谈 判 。（需 要 黎 巴 嫩 是 以 色 列 的 傀 儡 ）";
				a.influencePRC -= 50;
			}
		}
		if (result_num == 3)
		{
			text = " 我 们 将 下 次 再 议 。";
		}
	}
}
