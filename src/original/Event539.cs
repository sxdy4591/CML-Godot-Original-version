using EventsForDLC;
using UnityEngine;

public class Event539 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 献 给 你 的 进 行 曲";
		text = " 为 了 纪 念 5 1 8 光 州 事 件 ， 数 十 名 首 尔 地 区 的 大 学 生 占 领 了 首 尔 美 国 文 化 中 心 ， 并 高 举 “ 美 国 为 光 州 事 件 负 责 ， 必 须 道 歉 ” 的 口 号 。 美 国 大 使 为 此 前 来 与 学 生 们 交 流 ， 但 在 交 流 无 果 后 离 开 文 化 中 心 。 在 静 坐 了 数 天 以 后 ， 军 警 突 然 闯 入 二 楼 并 将 学 生 全 部 抓 捕 。 这 一 消 息 使 得 本 就 因 为 镇 压 民 主 化 导 致 左 翼 化 激 进 化 的 学 生 运 动 变 得 更 加 激 进 ， 更 多 的 学 生 走 上 街 头 要 求 释 放 学 生 ， 因 为 被 封 锁 导 致 失 业 的 工 人 们 也 开 始 上 街 游 行 ， 民 主 派 们 也 正 蠢 蠢 欲 动 。 或 许 ， 我 们 应 该 趁 此 出 手 ， 使 这 个 东 亚 最 后 的 反 共 堡 垒 从 内 部 摧 毁 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (GlobalScript.inst.gameState.SKRebel && a.resultOfEvents[474] == 0 && a.event_done[474])
		{
			button_text[0] = " 为 学 生 们 提 供 支 持";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 无 法 支 持 ！";
		}
		button_text[1] = " 无 动 于 衷";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 献 给 你 的 进 行 曲";
		if (result_num == 0)
		{
			text = " 在 特 工 的 帮 助 下 ， 左 翼 学 生 ， 工 人 和 部 分 前 左 翼 政 党 的 政 治 人 物 被 团 结 在 一 起 ， 武 装 的 工 人 与 学 生 等 在 全 国 各 地 进 行 暴 动 ， 韩 国 事 实 上 正 在 进 行 一 场 小 型 内 战 。 但 在 我 们 的 施 压 下 ， 军 政 府 被 迫 倒 台 ， 全 斗 焕 ， 卢 泰 愚 ， 李 鹤 捧 等 军 政 府 高 层 被 临 时 法 庭 判 处 死 刑 并 立 即 执 行 。 反 对 派 们 上 台 了 ， 没 有 一 刻 为 军 政 府 的 倒 台 感 到 高 兴 ， 紧 接 而 来 的 便 是 反 对 派 内 部 激 烈 的 派 系 斗 争 。 不 过 在 我 们 顾 问 的 帮 助 下 ， 反 对 派 决 定 先 与 朝 鲜 进 行 和 平 谈 判 ， 并 在 不 久 之 后 与 朝 鲜 一 起 召 开 宪 政 大 会 。";
			a.data[9] -= 150;
			a.data[22] -= 150;
			a.allcountries[46].Gosstroy = 1;
			a.allcountries[46].SubGosstroy = 1;
			a.allcountries[46].LeaveAlliances();
			a.allcountries[46].proprc = true;
			a.allcountries[46].Torg = true;
			a.empires[0].relations -= 200;
			a.empires[0].power -= 50;
			a.influencePRC += 50;
			a.data[1] += 100;
			a.data[3] += 100;
		}
		if (result_num == 1)
		{
			text = " 在 美 国 驻 军 的 支 持 下 ， 韩 国 再 一 次 颁 布 全 国 戒 严 令 ， 各 地 均 有 军 警 与 学 生 和 工 人 们 爆 发 冲 突 的 事 件 ， 在 冲 突 激 烈 的 地 区 军 警 被 批 准 直 接 向 参 与 运 动 的 人 群 开 火 ， 坦 克 也 被 使 用 冲 散 暴 动 的 人 群 ， 前 所 未 有 的 镇 压 强 度 使 得 这 场 席 卷 全 韩 国 的 民 主 运 动 被 迅 速 平 定 ， 运 动 骨 干 被 当 作 共 匪 和 通 北 人 士 进 行 枪 决 。 韩 国 未 来 将 会 一 直 与 美 国 保 持 紧 密 的 联 系 ， 但 是 能 否 一 直 维 持 军 政 府 甚 至 维 持 韩 国 这 个 国 家 的 存 在 仍 打 一 个 大 大 的 问 号 。";
		}
	}
}
