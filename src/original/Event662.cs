using EventsForDLC;
using UnityEngine;

public class Event662 : EventsSecond
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
		name = " 红 飞 蛾 ， 打 破 “ 四 切 ”";
		text = $"是 时 候 了 ， 主 席 同 志 。 如 你 所 见 ， 精 神 原 子 弹 的 战 术 并 不 完 全 有 效 。 虽 然 我 方 仍 能 通 过 派 遣 知 青 与 提 供 电 台 服 务 的 方 式 支 持 缅 甸 革 命 ， 可 迄 今 为 止 ， 缅 甸 共 产 党 仍 未 取 得 突 破 性 进 展 。 北 方 的 腊 戎 如 同 倒 刺 ， 使 农 村 包 围 城 市 的 战 术 数 次 折 戟 。 缅 军 的 “ 四 切 ” 战 术 更 使 缅 甸 共 产 党 处 境 雪 上 加 霜 ： 该 党 依 托 的 农 村 地 区 大 都 处 于 极 度 贫 瘠 的 孤 立 状 态 ， 各 反 政 府 武 装 也 都 被 驱 赶 到 统 治 核 心 之 外 的 缅 北 边 境 区 域 各 自 狗 斗 ； 与 此 同 时 ， 缅 军 还 以 道 路 为 中 心 动 员 民 团 和 正 规 军 ， 对 反 抗 组 织 逐 个 击 破 ， 甚 至 不 吝 通 过 制 造 饥 荒 与 屠 杀 的 方 式 摧 毁 其 根 据 地 。 如 果 仅 靠 人 力 物 力 支 持 ， 还 远 不 足 以 击 破 “ 四 切 ” 。 毕 竟 ， 土 地 革 命 战 争 的 经 验 充 分 说 明 了 这 点 ： 割 据 的 前 提 是 空 间 机 动 与 根 据 地 建 设 。 只 有 恢 复 对 伊 洛 瓦 底 三 角 洲 与 勃 固 发 达 地 区 的 根 据 地 与 农 村 游 击 力 量 ， 缅 甸 共 产 党 才 能 重 新 掌 握 主 动 权 — — 这 意 味 着 我 们 必 须 得 为 一 场 大 规 模 运 动 战 做 准 备 。 当 然 ， 除 却 以 军 事 进 攻 恢 复 控 制 权 外 ， 我 们 还 可 以 通 过 统 一 战 线 的 方 式 聚 拢 盟 友 共 同 击 溃 缅 军 ： 仍 在 伊 洛 瓦 底 三 角 洲 活 跃 的 该 国 第 二 大 武 装 克 伦 民 族 联 盟 便 是 极 好 的 合 作 伙 伴 。 他 们 的 历 史 可 上 溯 英 属 印 度 时 代 ， 以 血 税 换 取 默 许 独 立 的 克 伦 族 雇 佣 兵 ， 并 在 拒 绝 《 彬 龙 协 议 》 后 同 缅 甸 当 局 长 期 交 火 。 不 过 ， 和 它 们 做 交 易 必 然 意 味 着 大 步 妥 协 … … 主 席 同 志 ， 您 怎 么 看 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 5;
		if (a.modifies[6].active)
		{
			button_text[0] = "我 们 将 继 续 支 持 缅 共 的 北 部 游 击 运 动";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = "说 真 的 ， 你 还 信 那 一 套 费 力 不 讨 好 的 兄 弟 情 吗 ？";
		}
		if (a.data[56] > 0)
		{
			button_text[1] = "好 问 题 ， 好 就 好 在 相 关 事 宜 无 需 再 提";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 世 界 革 命 靠 A B C ！";
		}
		if (a.data[56] > 1)
		{
			button_text[2] = "让 我 们 实 现 全 缅 甸 各 族 的 大 团 结 ， 以 民 族 统 一 战 线 之 名 打 击 “ 四 切 ” ！";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 和 土 司 地 主 们 结 盟 ？ 呸 ！";
		}
		if (a.modifies[6].active && a.IsSocialism(yes: true, 34) && a.allcountries[34].proprc)
		{
			button_text[3] = "世 界 革 命 靠 A B C ， 我 们 应 为 此 不 遗 余 力 。 是 时 候 让 缅 甸 同 志 转 向 战 略 进 攻 了 ！";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 东 南 亚 的 雨 林 使 我 们 举 步 维 艰";
		}
		if (a.allcountries[1].SubGosstroy == 18)
		{
			button_text[4] = "让 我 们 重 组 缅 共 ， 同 时 恢 复 伊 洛 瓦 迪 游 击 区 ！";
		}
		else
		{
			Object.Destroy(button[4]);
			button_text[4] = " 红 旗 派 已 油 尽 灯 枯 ， 无 需 输 血 续 命";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 红 飞 蛾 ， 打 破 “ 四 切 ”";
		switch (result_num)
		{
		case 0:
			a.allcountries[33].inflCh -= 30;
			text = " 即 使 我 们 承 诺 并 继 续 支 持 缅 甸 共 产 党 的 革 命 事 业 ， 可 局 势 仍 未 发 生 根 本 改 观 。 长 期 的 消 耗 与 贫 困 战 时 经 济 两 者 共 同 摧 毁 着 缅 共 队 伍 ， 其 主 要 军 事 领 导 人 的 精 气 神 一 日 比 一 日 颓 废 。 “ 四 切 ” 战 术 的 封 锁 只 会 使 其 向 金 三 角 地 区 的 “ 传 统 智 慧 ” 靠 拢 — — 这 就 是 “ 特 货 ” 贸 易 、 边 界 走 私 与 军 官 军 阀 化 现 象 越 加 猖 獗 的 原 因 … …";
			break;
		case 1:
			a.allcountries[33].inflCh = 0;
			a.data[1] -= 50;
			a.data[3] -= 40;
			text = "“ 错 过 了 知 青 返 城 ，|错 过 了 大 学 的 校 门 ，|错 过 了 一 切 不 该 错 过 的 人 生 机 会 ，|15 年 的 青 春 岁 月 ，|我 想 — —|革 命 是 不 朽 的 。 ”||显 然 ， 会 在 缅 甸 留 下 孤 军 的 可 不 只 有 国 民 党 … …||<color=red>“ 一 切 伟 大 的 世 界 历 史 事 变 和 人 物 ， 可 以 说 都 出 现 两 次 。 ” — — G · W · F · 黑 格 尔 </color>";
			break;
		case 2:
			a.allcountries[33].Torg = false;
			a.data[9] -= 100;
			text = " 我 们 决 定 以 中 介 人 的 身 份 推 进 缅 甸 共 产 党 同 克 伦 民 族 联 盟 达 成 统 一 战 线 ， 要 求 两 位 死 敌 效 仿 毛 泽 东 主 席 与 蒋 介 石 委 员 长 的 经 验 共 商 国 家 大 计 。 而 这 更 为 建 立 一 个 缅 甸 版 本 的 大 联 盟 政 府 铺 平 了 道 路 ： 各 路 反 政 府 武 装 在 中 国 的 物 资 统 筹 下 统 一 意 见 ， 并 通 过 吸 纳 缅 甸 共 产 党 （ 红 旗 派 ） 的 前 盟 友 若 开 解 放 党 ， 克 钦 独 立 组 织 等 各 路 豪 杰 持 续 发 展 壮 大 ！ 新 的 “ 民 族 团 结 联 盟 ” 使 我 们 能 够 在 缅 甸 更 好 站 稳 脚 跟 并 拓 展 影 响 力 。 当 然 ， 这 也 意 味 着 我 们 可 以 通 过 操 纵 “ 民 族 团 结 联 盟 ” 内 的 任 意 一 方 决 定 该 国 未 来 。 时 间 将 证 明 我 们 的 决 策 是 否 正 确 。||奈 温 政 府 对 此 气 急 败 坏 ， 决 定 再 次 同 中 国 断 交 并 转 向 完 全 孤 立 。 与 此 同 时 ， 我 们 在 缅 军 的 队 伍 内 发 现 了 苏 联 克 格 勃 特 工 与 古 巴 雇 佣 军 的 身 影 。";
			break;
		case 3:
			a.allcountries[33].Torg = false;
			a.data[9] -= 50;
			a.data[22] -= 200;
			a.allcountries[33].inflCh += 10;
			text = " 通 过 渗 透 泰 国 边 境 的 但 那 沙 林 和 南 掸 邦 主 干 道 ， 我 们 决 定 在 不 计 成 本 的 情 况 下 持 续 派 遣 知 青 、 老 兵 、 新 式 装 备 、 以 及 武 装 的 泰 国 共 产 党 志 愿 者 穿 过 国 界 ， 并 进 入 缅 甸 筹 备 进 攻 。 缅 甸 共 产 党 就 此 成 功 发 起 战 略 进 攻 ， 夺 下 了 腊 戎 和 东 枝 两 处 掸 邦 重 要 据 点 ， 更 在 全 国 掀 起 了 农 民 游 击 战 高 潮 ！||奈 温 政 府 对 此 气 急 败 坏 ， 决 定 再 次 同 中 国 断 交 并 转 向 完 全 孤 立 。 与 此 同 时 ， 我 们 在 缅 军 的 队 伍 内 发 现 了 苏 联 克 格 勃 特 工 、 美 国 中 情 局 线 人 与 以 色 列 摩 萨 德 的 身 影 。";
			break;
		case 4:
			a.allcountries[33].Torg = false;
			a.data[9] -= 200;
			a.data[22] -= 200;
			text = " 中 国 政 局 的 剧 变 与 缅 甸 共 产 党 领 导 层 流 亡 北 京 的 境 况 使 得 我 们 有 建 立 新 生 缅 共 的 千 载 难 逢 机 会 — — 一 方 面 ， 我 们 将 清 洗 缅 甸 共 产 党 的 毛 派 领 导 层 ； 一 方 面 我 们 将 启 动 缅 甸 共 产 党 （ 红 旗 派 ） 与 缅 甸 共 产 党 （ 白 旗 派 ） 两 者 的 合 并 工 作 ， 并 恢 复 其 在 城 市 内 的 党 务 工 作 。 通 过 采 纳 托 洛 茨 基 的 世 界 革 命 和 不 断 革 命 论 ， 我 们 得 以 更 公 开 地 介 入 缅 甸 事 务 。 不 久 后 ， 巴 登 顶 便 因 军 事 投 机 而 引 咎 辞 去 领 导 人 职 务 。 过 去 因 批 判 巴 登 顶 “ 执 行 刘 少 奇 路 线 ” 而 不 得 不 在 我 国 寻 求 庇 护 的 前 造 反 派 干 部 敏 拉 也 宽 则 成 为 了 新 一 代 缅 共 的 领 导 人 。 久 经 沙 场 的 前 缅 甸 共 产 党 （ 红 旗 派 ） 领 导 人 ， 目 前 研 究 托 洛 茨 基 思 想 的 德 钦 梭 也 在 我 们 的 秘 密 帮 助 下 脱 逃 ， 并 同 自 己 新 组 织 的 队 伍 并 入 重 组 的 缅 共 。 与 此 同 时 ， 我 们 也 已 不 计 成 本 的 方 式 持 续 派 遣 知 青 、 老 兵 、 新 式 装 备 、 以 及 武 装 的 第 四 国 际 志 愿 者 穿 过 国 界 ， 并 进 入 缅 甸 筹 备 进 攻 … … 希 望 实 现 重 组 与 新 生 的 缅 共 可 以 一 举 推 翻 法 西 斯 主 义 官 僚 领 导 下 的 伪 马 克 思 主 义 政 权 ！";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
