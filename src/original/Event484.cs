using EventsForDLC;
using UnityEngine;

public class Event484 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 推 倒 这 堵 墙 ！";
		text = " 随 着 中 华 人 民 共 和 国 影 响 力 不 断 提 高 ， 我 们 也 得 以 对 两 个 德 国 的 命 运 做 最 终 判 决 。 我 们 有 三 个 方 案 ， 分 别 是 让 西 德 主 导 统 一 ， 东 德 主 导 统 一 或 者 组 成 平 等 的 联 邦 。 但 决 定 权 在 您 的 手 上 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (((a.allcountries[17].isNATO && (a.allcountries[16].Gosstroy == 2 || !a.allcountries[16].prosov)) || (a.allcountries[17].Gosstroy == 1 && a.allcountries[16].Gosstroy != 2 && !a.allcountries[16].prosov)) && a.allcountries[16].SubGosstroy != 10)
		{
			button_text[0] = " 西 德 主 导 统 一";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 们 啃 不 下 东 德 的";
		}
		if (((a.allcountries[16].prosov && a.allcountries[16].Gosstroy == 1 && a.allcountries[1].isSEV && a.allcountries[1].isOVD) || a.allcountries[16].SubGosstroy == 10 || (a.allcountries[16].Gosstroy == 1 && a.allcountries[16].proprc)) && a.allcountries[16].Gosstroy != 2 && a.allcountries[17].Gosstroy != 1 && !a.allcountries[17].isNATO)
		{
			button_text[1] = " 东 德 主 导 统 一";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 西 德 的 情 况 似 乎 要 好 得 多";
		}
		if ((a.allcountries[16].Gosstroy == 2 || (a.allcountries[21].isSocEU && a.allcountries[17].isSocEU && a.empires[1].now_leader == 6)) && a.allcountries[17].Gosstroy == 2)
		{
			button_text[2] = " 组 成 平 等 的 联 邦";
		}
		else if (a.allcountries[16].Gosstroy == 1 && a.allcountries[17].Gosstroy == 1 && !a.allcountries[16].prosov)
		{
			button_text[2] = " 工 农 兄 弟 应 当 是 一 家 ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 总 有 一 方 会 不 高 兴 的";
		}
		button_text[3] = " 下 次 再 说 吧";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 推 倒 这 堵 墙 ！";
		if (result_num != 3 && GlobalScript.inst.gameState.iron_and_blood)
		{
			GameObject.Find("Ach(Clone)").GetComponent<achievements>().Set(132);
		}
		switch (result_num)
		{
		case 0:
			if (a.allcountries[17].isNATO)
			{
				text = " 在 我 们 的 大 力 撮 合 下 ， 联 邦 德 国 成 功 和 民 主 德 国 的 外 交 部 长 得 以 在 基 尔 就 统 一 达 成 一 致 。 双 方 确 定 了 将 由 西 德 负 责 东 德 未 来 的 发 展 ， 而 东 德 地 区 将 解 散 自 己 的 武 装 力 量 ， 转 而 由 西 德 接 手 一 切 的 国 营 企 业 。 前 统 社 党 高 层 被 判 以 “ 叛 国 ” 和 “ 腐 败 ” 罪 ， 昂 纳 克 在 统 一 的 前 夜 逃 往 智 利 大 使 馆 寻 求 庇 护 。 柏 林 墙 最 终 也 被 拆 除 。 两 德 最 终 统 一 了 ， 但 是 代 价 呢 ？ ";
				a.allcountries[16].LeaveAlliances();
				a.allcountries[17].parts[0] = true;
				a.allcountries[17].Torg = true;
				a.allcountries[17].dev = 2;
				a.modifies[53].active = false;
			}
			else if (a.allcountries[17].Gosstroy == 1)
			{
				text = " 在 东 德 经 历 了 政 局 的 大 洗 牌 后 ， 西 德 同 志 们 得 以 在 东 德 站 稳 脚 跟 ， 以 革 命 领 军 人 的 姿 态 向 西 德 发 出 邀 请 。 出 于 对 社 会 主 义 理 念 的 向 往 ， 东 德 领 导 人 似 乎 没 有 理 由 拒 绝 。 随 后 ， 两 个 德 国 的 领 袖 在 基 尔 举 行 了 会 谈 ， 双 方 决 定 了 将 由 西 德 的 同 志 们 主 导 东 德 的 革 命 。 但 东 德 在 一 些 问 题 上 仍 然 保 有 自 己 的 权 力 。 很 快 ， 再 社 会 主 义 化 的 改 革 在 东 德 如 火 如 荼 的 召 开 了 ， 而 西 德 也 为 有 了 足 够 广 阔 的 农 业 基 地 感 到 高 兴 。 就 史 塔 西 问 题 ， 双 方 都 一 致 同 意 史 塔 西 的 监 控 作 用 完 全 可 以 被 工 人 赤 卫 队 所 取 代 ， 因 此 史 塔 西 将 被 改 组 为 “ 革 命 保 卫 办 公 室 ” 而 继 续 存 在 。 德 国 人 终 于 住 在 同 一 片 屋 檐 下 了 。";
				a.allcountries[17].parts[0] = true;
				a.allcountries[17].Torg = true;
				a.allcountries[17].dev = 2;
				a.modifies[53].active = true;
				a.allcountries[16].LeaveAlliances();
				a.allcountries[17].Gosstroy = 1;
				a.allcountries[17].SubGosstroy = 17;
				a.allcountries[17].proprc = true;
				a.allcountries[17].JoinAllOurAlliances(yes: true);
				GlobalScript.inst.old_modify_texts[53] = " 与 革 命 保 卫 办 公 室 合 作";
				GlobalScript.inst.old_modify_desc[53] = "<color=lime>特 工 网 络+1.5;|</color><color=#9370DB>极 左 派+1;|极 左 派 力 量+1.</color>";
			}
			break;
		case 1:
			a.allcountries[16].parts[0] = true;
			a.allcountries[16].Torg = true;
			a.allcountries[17].LeaveAlliances();
			a.allcountries[17].dev = 3;
			a.allcountries[16].name = " 统 一 德 国";
			if (a.allcountries[16].SubGosstroy == 2)
			{
				text = " 随 着 社 会 主 义 阵 营 在 全 球 取 得 了 胜 利 ， 西 德 人 民 也 越 来 越 向 往 社 会 主 义 。 在 我 们 的 撮 合 下 ， 民 主 德 国 得 以 一 口 吞 下 整 个 德 国 。 德 国 统 一 社 会 党 总 书 记 瑙 曼 得 以 在 C C T V ， 塔 斯 社 和 C N N 的 面 前 ， 自 信 的 推 倒 柏 林 墙 ， 并 正 式 宣 布 两 个 德 国 的 统 一 。 但 接 下 来 的 才 是 难 点 ： 对 西 德 进 行 改 造 。 资 本 主 义 很 明 显 不 能 和 社 会 主 义 共 存 。 因 此 ， 民 主 德 国 领 导 层 决 定 采 取 果 断 措 施 ， 恢 复 《 1 9 4 9 年 宪 法 》 ： 这 一 文 件 宣 称 “ 德 意 志 民 主 共 和 国 是 属 于 德 意 志 民 族 的 社 会 主 义 国 家 ” 。 大 型 与 中 型 企 业 纷 纷 被 国 有 化 ， 并 在 所 有 权 上 被 归 为 “ 人 民 的 ” 企 业 ， 价 格 管 制 与 东 德 马 克 也 同 样 走 入 了 西 德 的 大 街 小 巷 。 两 个 德 国 的 统 一 似 乎 还 要 很 久 ， 但 我 们 相 信 他 们 会 胜 利 。";
			}
			else if (a.allcountries[16].Gosstroy == 1)
			{
				text = " 随 着 社 会 主 义 阵 营 在 全 球 取 得 了 胜 利 ， 西 德 人 民 也 越 来 越 向 往 社 会 主 义 。 在 我 们 的 撮 合 下 ， 民 主 德 国 得 以 一 口 吞 下 整 个 德 国 。 德 国 统 一 社 会 党 总 书 记 昂 纳 克 得 以 在 C C T V ， 塔 斯 社 和 C N N 的 面 前 ， 自 信 的 推 倒 柏 林 墙 ， 并 正 式 宣 布 两 个 德 国 的 统 一 。 但 接 下 来 的 才 是 难 点 ： 对 西 德 进 行 改 造 。 资 本 主 义 很 明 显 不 能 和 社 会 主 义 共 存 。 因 此 ， 民 主 德 国 领 导 层 决 定 采 取 果 断 措 施 ， 恢 复 《 1 9 4 9 年 宪 法 》 ： 这 一 文 件 宣 称 “ 德 意 志 民 主 共 和 国 是 属 于 德 意 志 民 族 的 社 会 主 义 国 家 ” 。 大 型 与 中 型 企 业 纷 纷 被 国 有 化 ， 并 在 所 有 权 上 被 归 为 “ 人 民 的 ” 企 业 ， 价 格 管 制 与 东 德 马 克 也 同 样 走 入 了 西 德 的 大 街 小 巷 。 两 个 德 国 的 统 一 似 乎 还 要 很 久 ， 但 我 们 相 信 他 们 会 胜 利 。";
			}
			else if (a.allcountries[16].SubGosstroy == 10)
			{
				text = " 在 米 尔 克 的 强 烈 要 求 下 ， 以 东 德 为 主 导 的 新 德 国 完 成 了 统 一 。 而 新 生 的 政 权 立 刻 将 这 位 领 袖 比 做 是 俾 斯 麦 在 世 ， 他 在 任 期 内 得 以 重 新 塑 造 一 个 德 国 ， 并 且 得 以 给 德 国 人 民 他 们 想 要 的 一 切 ， 诸 如 除 了 苏 联 方 案 以 外 的 社 会 主 义 原 则 。 而 社 会 主 义 原 则 被 “ 民 族 — 阶 级 双 斗 争 ” 给 取 代 。 西 德 人 对 于 东 德 新 领 导 人 的 观 感 与 纳 粹 无 异 ， 在 得 知 要 统 一 后 ， 巨 大 的 人 流 挤 爆 了 机 场 。 而 新 政 府 立 刻 建 立 起 来 了 。 新 政 府 尽 管 看 上 去 和 曾 经 的 朝 鲜 民 主 主 义 人 民 共 和 国 无 异 。 但 他 知 道 要 合 理 运 用 德 国 的 优 势 — — 足 够 自 给 自 足 的 工 业 和 农 业 来 提 升 生 活 水 平 。 无 论 如 何 ， 现 在 的 国 内 对 于 米 尔 克 的 崇 拜 已 经 达 到 了 一 个 新 的 高 度 ， 而 德 国 也 得 以 统 一 。 是 非 功 过 还 是 留 给 后 人 诉 说 吧 。";
			}
			break;
		case 2:
			if (a.allcountries[16].Gosstroy == 1 && a.allcountries[17].Gosstroy == 1)
			{
				a.allcountries[16].LeaveAlliances();
				a.allcountries[17].parts[0] = true;
				a.allcountries[17].JoinAllOurAlliances(yes: true);
				a.allcountries[17].dev = 1;
				a.allcountries[17].Torg = true;
				a.allcountries[17].Gosstroy = 1;
				a.allcountries[17].SubGosstroy = 17;
				a.allcountries[17].name = " 统 一 德 国";
				text = " 随 着 两 个 德 国 承 认 了 马 克 思 列 宁 主 义 ， 尤 其 是 反 修 正 主 义 的 理 念 ， 和 平 的 统 一 两 个 德 国 已 然 成 为 可 能 。 新 生 的 德 国 组 成 了 德 国 共 产 党 （ 革 命 联 盟 ） 以 继 续 德 国 革 命 ， 仍 然 宣 称 自 己 为 “ 马 克 思 ， 列 宁 ， 斯 大 林 和 毛 泽 东 （ 这 点 在 东 德 存 疑 ） 的 好 学 生 ” 。 同 时 社 会 主 义 改 造 也 在 双 边 进 行 。 双 方 也 得 以 在 各 种 科 技 方 面 取 长 补 短 ， 尤 其 是 在 自 动 化 的 研 究 方 面 。 苏 联 军 队 也 按 照 协 定 撤 离 。";
				break;
			}
			a.allcountries[16].LeaveAlliances();
			a.allcountries[17].parts[0] = true;
			a.allcountries[17].LeaveAlliances();
			a.allcountries[17].dev = 1;
			a.allcountries[17].Torg = true;
			a.allcountries[17].Gosstroy = 2;
			a.allcountries[17].SubGosstroy = 3;
			a.allcountries[17].name = " 德 意 志 联 邦 民 主 共 和 国";
			a.modifies[53].active = false;
			text = " 我 们 的 计 划 得 到 了 一 众 成 员 国 ， 尤 其 是 苏 联 和 法 国 的 认 可 。 随 着 “ 红 色 恐 慌 ” 面 纱 的 落 下 以 及 世 界 友 谊 思 想 的 繁 荣 发 展 ， 提 倡 和 平 主 义 、 社 会 改 革 、 友 谊 与 和 平 的 左 翼 同 盟 赢 得 了 大 选 。 他 们 的 胜 利 不 仅 仅 是 与 民 主 德 国 建 立 关 系 。 而 东 德 的 新 晋 领 导 人 希 望 能 更 近 一 步 ， 在 双 方 的 授 权 下 ， 统 一 社 会 党 和 左 翼 联 盟 达 成 了 政 治 上 合 并 。 新 成 立 的 德 意 志 社 会 主 义 同 盟 宣 布 将 在 德 国 的 领 土 上 建 立 一 个 平 等 而 自 由 的 联 邦 。 双 方 将 为 了 中 欧 的 无 核 化 与 和 平 而 奋 斗 。 让 我 们 祝 他 们 好 运 ！ ";
			if (a.allcountries[21].isSocEU)
			{
				text += " 而 在 两 德 统 一 后 ， 欧 洲 社 会 主 义 联 盟 也 向 统 一 后 的 德 国 抛 出 了 橄 榄 枝 ， 显 然 ， 这 个 “ 新 生 ” 的 国 家 很 乐 意 接 受 ， 毕 竟 ， 两 个 分 隔 已 久 的 国 家 合 并 后 会 有 更 多 潜 在 的 经 济 问 题 … …";
				a.allcountries[17].isSocEU = true;
			}
			break;
		case 3:
			text = " 我 们 下 次 再 决 定 德 国 的 命 运 。";
			break;
		}
	}
}
