using EventsForDLC;
using UnityEngine;

public class Event586 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 红 海 的 十 字 路 口";
		text = " 随 着 索 马 里 同 胞 在 欧 加 登 战 争 耻 辱 性 的 大 败 后 ， 吉 布 提 的 政 局 陷 入 了 动 荡 之 中 。 一 荣 俱 荣 一 损 俱 损 ， 欧 加 登 的 伊 萨 族 政 府 越 来 越 受 到 该 国 境 内 另 一 个 民 族 族 群 阿 法 尔 人 的 敌 视 。 他 们 被 现 任 政 府 歧 视 ， 同 工 不 同 酬 ， 甚 至 被 限 制 了 自 己 的 居 住 区 。 而 受 到 胜 利 的 鼓 舞 ， 埃 塞 俄 比 亚 试 图 在 吉 布 提 施 加 自 己 的 影 响 力 ， 乃 至 推 翻 现 任 合 法 政 府 。 也 许 我 们 可 以 试 着 介 入 这 场 事 件 ， 让 天 平 稍 稍 转 向 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] != 0 && a.data[56] != 4)
		{
			button_text[0] = " 向 古 莱 德 透 露 政 变 的 信 息";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 要 是 早 点 干 涉 就 好 了 … …";
		}
		if (a.data[56] <= 2)
		{
			button_text[1] = " 让 我 们 支 持 埃 塞 俄 比 亚 同 志 ！";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 爱 莫 能 助 啊 … …";
		}
		button_text[2] = " 额 ， 这 又 是 啥 地 方 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 红 海 的 十 字 路 口";
		if (result_num == 0)
		{
			text = " 我 们 向 古 莱 德 透 露 了 政 变 的 消 息 ， 在 我 们 特 勤 人 员 和 军 事 观 察 家 的 帮 助 下 ， 政 府 军 击 溃 并 确 保 了 该 国 北 部 的 稳 定 。 古 莱 德 总 统 很 感 谢 我 们 的 帮 助 ， 他 越 来 的 越 倒 向 我 国 。 在 最 近 ， 他 正 式 宣 布 把 原 全 国 独 立 联 盟 ， 索 马 里 解 放 阵 线 ， 吉 布 提 解 放 运 动 ， 人 民 解 放 运 动 等 组 织 的 部 分 人 士 和 革 命 军 人 整 合 为 吉 布 提 人 民 争 取 进 步 同 盟 。 其 中 揉 杂 了 索 马 里 民 族 主 义 ， 社 会 主 义 ， 市 场 经 济 ， 阶 级 斗 争 等 各 式 各 样 的 思 想 ， 但 我 们 至 少 收 获 了 一 个 盟 友 。";
			a.allcountries[106].Gosstroy = 2;
			a.allcountries[106].SubGosstroy = 15;
			a.allcountries[106].LeaveAlliances();
			a.allcountries[106].Torg = true;
			a.allcountries[106].proprc = true;
			a.allcountries[106].soc_stab = 1000;
			a.influencePRC += 20;
			a.data[6] += 15;
		}
		if (result_num == 1)
		{
			if (a.resultOfEvents[585] != 2)
			{
				text = " 尽 管 我 们 支 持 了 埃 塞 俄 比 亚 同 志 推 翻 帝 国 主 义 代 理 人 的 方 案 ， 甚 至 还 有 苏 联 帮 助 ， 他 们 仍 然 不 过 放 了 几 枪 几 炮 就 走 了 。||真 的 是 ， 我 才 不 怕 打 ， 一 听 到 打 我 就 高 兴 ， 吉 布 提 算 什 么 打 … …";
			}
			else
			{
				text = " 我 们 支 持 了 埃 塞 俄 比 亚 革 命 者 把 共 产 主 义 的 理 想 传 遍 非 洲 之 角 的 理 想 。 在 我 们 的 解 放 军 工 兵 和 埃 塞 俄 比 亚 战 士 的 帮 助 下 ， F R U D 的 士 兵 打 下 了 北 部 的 奥 博 克 镇 。 在 巨 大 的 伤 亡 后 ， F R U D 的 士 兵 攻 入 了 吉 布 提 。 法 国 士 兵 尽 力 反 抗 ， 无 果 ， 只 得 撤 退 。 新 的 吉 布 提 人 民 民 主 共 和 国 也 被 建 立 了 起 来 。 F R U D 也 改 组 为 吉 布 提 工 人 党 ， 并 公 开 转 向";
				a.allcountries[106].LeaveAlliances();
				if (a.influencePRC < a.empires[1].power)
				{
					text += "苏 联 的 怀 抱 。 ";
					a.allcountries[106].prosov = true;
					a.empires[1].power += 20;
				}
				else
				{
					text += "我 们 的 怀 抱 。 ";
					a.allcountries[106].proprc = true;
					a.allcountries[106].soc_stab = 1000;
					a.influencePRC += 20;
				}
				text += "共 产 主 义 又 在 一 个 国 家 取 得 了 胜 利 。";
				a.data[22] -= 50;
				a.allcountries[106].Gosstroy = 0;
				a.allcountries[106].SubGosstroy = 10;
				a.allcountries[106].Torg = true;
				a.empires[0].relations -= 100;
				a.data[6] += 5;
			}
		}
		if (result_num == 2)
		{
			text = " 无 聊 的 地 方 发 生 了 无 聊 的 事 情 ， 他 们 果 然 还 是 没 打 起 来 啊 。";
		}
	}
}
