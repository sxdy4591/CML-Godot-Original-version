using EventsForDLC;
using UnityEngine;

public class Event467 : EventsSecond
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
		name = " 我 爱 你 金 星 红 旗";
		text = " 马 共 （ 马 列 ） 和 马 共 （ 革 命 派 ） 的 代 表 来 到 了 我 们 国 家 ， 找 上 了 中 共 中 央 对 外 联 络 部 ， 表 达 了 与 由 于 马 来 亚 共 产 党 再 次 统 一 的 愿 望 。 过 去 ， 由 于 马 共 北 马 来 亚 局 肃 反 扩 大 化 的 错 误 与 投 机 分 子 的 影 响 ， 共 产 党 内 部 也 发 生 了 分 裂 ， 原 第 八 支 队 与 第 十 二 支 队 二 区 在 7 0 年 代 初 分 裂 出 去 ， 分 别 建 立 了 马 来 亚 共 产 党 （ 革 命 派 ） 和 马 来 亚 共 产 党 （ 马 列 ） ， 在 为 数 不 多 的 根 据 地 上 兄 弟 阋 墙 。 再 说 说 马 来 西 亚 国 内 的 情 况 ， 作 为 亚 洲 四 小 龙 之 一 ， 马 来 西 亚 迎 来 了 自 身 经 济 的 腾 飞 ， 但 与 绝 大 多 数 的 新 兴 资 本 主 义 经 济 体 一 样 ， 腾 飞 的 代 价 便 是 贫 富 分 化 的 极 大 加 剧 ， 这 促 使 一 度 销 声 匿 迹 的 左 派 力 量 重 新 壮 大 ： 合 法 范 围 内 ， 马 来 西 亚 人 民 社 会 主 义 党 等 议 会 左 翼 政 党 正 积 极 进 行 着 宪 制 斗 争 ； 而 非 法 范 围 内 ， 马 来 亚 共 产 党 、 北 加 里 曼 丹 共 产 党 及 其 武 装 部 队 和 统 战 组 织 不 断 袭 扰 政 府 ， 马 来 亚 民 族 解 放 军 长 征 后 一 度 失 联 的 旧 地 下 组 织 残 余 成 员 与 前 议 会 左 翼 政 党 成 员 们 在 受 到 文 化 大 革 命 影 响 并 激 进 化 后 组 建 的 各 地 下 组 织 也 在 秘 密 的 协 助 马 共 进 行 斗 争 ， 但 是 这 些 组 织 与 马 共 是 平 行 关 系 ， 马 共 对 他 们 缺 乏 有 效 的 领 导 。 主 席 同 志 ， 我 们 是 否 该 帮 他 们 一 把 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.allcountries[34].cw && GlobalScript.inst.gameState.data[56] < 2)
		{
			button_text[0] = " 马 共 的 问 题 必 须 解 决 ， 不 过 我 们 需 要 清 除 一 些 障 碍";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 鞭 长 莫 及 ， 鞭 长 莫 及 啊 … …";
		}
		button_text[1] = " 劝 说 他 们 重 新 达 成 统 一";
		button_text[2] = " 还 是 不 掺 和 的 好";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 爱 你 金 星 红 旗";
		switch (result_num)
		{
		case 0:
			text = " 在 我 们 和 泰 国 同 志 的 秘 密 联 络 下 ， 双 方 的 领 导 人 达 成 了 协 定 ： 马 来 西 亚 人 民 社 会 主 义 党 秘 密 加 入 民 族 解 放 同 盟 ， 作 为 代 价 ， 马 来 亚 共 产 党 必 须 维 护 全 马 的 统 一 ， 为 此 ， 人 民 社 会 主 义 党 作 为 桥 梁 加 强 了 马 来 亚 和 砂 捞 越 党 、 军 的 联 系 。 在 来 到 中 国 与 陈 平 进 行 和 谈 后 ， 马 共 分 裂 出 去 的 两 派 被 平 反 ， 马 列 派 与 革 命 派 回 到 了 马 来 亚 共 产 党 的 队 伍 中 ， 革 命 派 领 导 人 黄 一 江 还 在 和 谈 过 程 中 “ 主 动 ” 将 一 切 权 力 让 出 ， 虽 然 不 太 厚 道 ， 但 他 的 隐 退 确 实 让 谈 判 顺 利 了 许 多 。 在 马 共 的 领 导 下 ， 与 马 来 亚 共 产 党 建 立 联 系 的 地 下 组 织 在 吉 隆 坡 进 行 会 谈 ， 统 一 合 并 到 马 来 亚 民 族 解 放 同 盟 中 。 在 全 新 血 液 的 输 入 下 ， 文 莱 人 民 党 ， 新 加 坡 社 会 主 义 阵 线 也 加 入 了 马 来 亚 民 族 解 放 同 盟 。 一 个 全 马 来 西 亚 的 左 派 组 织 正 冉 冉 升 起 ， 马 来 西 亚 的 解 放 指 日 可 待 。";
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.allcountries[49].cw = true;
			GlobalScript.inst.gameState.influencePRC += 30;
			break;
		case 1:
			text = " 对 外 联 络 部 努 力 劝 说 并 没 有 使 他 们 达 成 统 一 。 马 共 （ 马 列 ） 和 马 共 （ 革 命 派 ） 希 望 以 平 等 的 方 式 与 马 共 会 谈 ， 但 是 马 共 方 面 并 不 同 意 。 革 命 派 领 导 人 黄 一 江 出 于 他 的 投 机 立 场 和 对 丧 失 领 导 地 位 的 担 心 ， 也 没 有 同 意 统 一 。 马 来 亚 共 产 党 始 终 是 苦 守 马 泰 边 区 根 据 地 ， 革 命 派 与 马 列 派 跟 马 来 亚 共 产 党 后 来 又 产 生 了 多 次 武 装 冲 突 ， 不 过 我 们 已 经 管 不 了 了 … … ";
			GlobalScript.inst.gameState.influencePRC -= 20;
			break;
		case 2:
			text = " 左 派 无 限 可 分 ， 这 点 果 真 是 没 错 ， 直 到 人 民 社 会 主 义 党 开 始 分 裂 ， 马 来 亚 共 产 党 也 没 与 它 联 合 。 分 裂 后 的 人 民 社 会 主 义 党 又 上 演 了 一 遍 逼 上 梁 山 的 戏 码 ， 马 来 亚 共 产 党 始 终 是 苦 守 马 泰 边 区 根 据 地 ， 革 命 派 与 马 列 派 跟 马 来 亚 共 产 党 产 生 了 多 次 武 装 冲 突 。 好 吧 ， 的 确 是 这 样 ， 属 于 革 命 的 时 代 大 概 已 经 结 束 了 … …";
			GlobalScript.inst.gameState.influencePRC -= 30;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
