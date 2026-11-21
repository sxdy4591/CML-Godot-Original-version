using EventsForDLC;
using UnityEngine;

public class Event912 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 奥 林 匹 斯 山 的 诸 神 们";
		text = " 主 席 同 志 ， 我 国 的 革 命 航 船 又 一 次 找 到 了 掌 舵 人 ， 也 就 是 您 。 是 时 候 让 我 们 再 在 全 球 掀 起 革 命 的 惊 涛 骇 浪 了 ， 我 们 的 朋 友 不 可 谓 不 是 遍 天 下 ， 其 中 既 有 罗 马 尼 亚 的 天 才 ， 朝 鲜 半 岛 上 不 落 的 太 阳 。 也 有 诸 如 俄 罗 斯 的 民 族 共 产 主 义 者 ， 安 第 斯 的 原 住 民 运 动 ， 西 班 牙 等 苦 苦 挣 扎 的 革 命 战 友 。 为 此 ， 外 联 部 和 外 交 部 的 同 志 建 议 我 们 组 建 一 个 伞 型 的 国 际 性 合 作 组 织 。 当 然 ， 决 定 权 在 您 的 手 上 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 天 下 大 势 ， 浩 浩 汤 汤 ， 顺 之 者 昌 ， 逆 之 者 亡";
		button_text[1] = " 这 是 不 是 有 点 太 疯 狂 了 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 奥 林 匹 斯 山 的 诸 神 们";
		if (result_num == 0)
		{
			text = " 在 钓 鱼 台 国 宾 馆 ， 中 央 举 行 了 一 场 别 开 生 面 的 宴 席 。 与 会 人 员 除 了 长 袖 善 舞 的 尼 古 拉 · 齐 奥 塞 斯 库 同 志 ， 我 们 长 久 以 来 的 盟 友 金 日 成 同 志 。 更 有 新 鲜 的 面 孔 ： 秘 鲁 的 艾 萨 克 · 乌 马 拉 ， 西 班 牙 的 列 宁 - 卡 洛 斯 主 义 者 ， 津 巴 布 韦 非 洲 民 族 联 盟 的 罗 伯 特 · 穆 加 贝 ， 非 洲 人 国 民 大 会 的 温 妮 · 曼 德 拉 代 替 其 丈 夫 出 席 了 宴 会 。 诸 如 霍 亨 索 伦 ， 哈 布 斯 堡 和 波 拿 巴 家 族 都 收 到 了 请 柬 （ 当 然 他 们 没 有 与 会 ， 我 们 深 表 遗 憾 ） 。 会 上 ， 华 国 锋 同 志 强 调 了 西 方 世 界 的 腐 朽 堕 落 ， 痛 心 疾 首 的 批 判 欧 洲 国 家 背 弃 了 前 人 所 指 出 的 明 路 。 就 在 这 时 ， 与 会 的 代 表 突 然 举 手 发 言 ， 高 声 欢 呼 中 国 革 命 经 验 的 年 轻 与 活 力 ， 同 时 感 谢 了 我 国 对 各 国 的 革 命 者 们 提 供 各 种 程 度 上 的 支 持 ， 并 欢 呼 我 国 的 革 命 事 业 又 一 次 取 得 了 伟 大 胜 利 。 各 国 革 命 者 的 代 表 们 投 以 热 烈 的 掌 声 ， 并 纷 纷 在 这 一 划 时 代 的 《 北 京 协 议 》 上 签 下 了 自 己 的 名 字 。 这 份 协 议 不 仅 是 新 生 的 礼 炮 ， 更 是 腐 朽 的 旧 秩 序 的 丧 钟 。||西 方 堕 落 国 家 和 那 些 自 以 为 正 统 的 “ 左 派 ” 对 我 们 的 “ 倒 行 逆 施 ” 大 加 鞭 笞 ， 称 其 为 新 时 代 的 梅 特 涅 同 盟 。 在 部 分 欧 洲 国 家 甚 至 发 生 了 有 组 织 的 针 对 华 裔 社 区 的 抢 劫 ， 而 我 们 都 知 道 暴 徒 的 背 后 是 邪 恶 的 资 本 主 义 旧 秩 序 。 这 更 展 示 了 欧 罗 巴 的 堕 落 与 野 蛮 ， 他 们 也 没 有 资 格 成 为 什 么 世 界 秩 序 的 缔 造 者 了 。 既 然 如 此 ， 那 就 让 他 们 羡 慕 我 们 好 了 ， 我 们 的 战 友 遍 天 下 ， 我 们 的 英 名 将 传 遍 四 方 。 过 去 ， 现 在 和 未 来 都 掌 握 在 我 们 手 中 。 就 让 我 们 从 他 们 手 中 夺 走 这 个 世 界 ， 把 它 砸 个 粉 碎 ， 缔 造 属 于 我 们 的 新 秩 序 ！";
			a.data[1] += 1000;
			a.data[3] += 1000;
			a.data[4] -= 1000;
			a.data[31] = 1000;
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.data[15] = 6;
			a.data[16] = 10;
			a.data[17] = 16;
			a.data[18] = 20;
			a.data[50] = 29;
			a.modifies[6].active = false;
			a.allcountries[1].SubGosstroy = 19;
			a.allcountries[10].SubGosstroy = 19;
			a.allcountries[5].SubGosstroy = 19;
			for (int i = 0; i < a.allcountries.Length; i++)
			{
				if (a.allcountries[i].Gosstroy == 1 || a.allcountries[i].SubGosstroy == 0)
				{
					a.allcountries[i].Torg = false;
					a.allcountries[i].proprc = false;
					a.allcountries[i].econ = false;
					a.allcountries[i].okb = false;
				}
			}
			if (GlobalScript.inst.gameState.modifies[6].active)
			{
				GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
				GlobalScript.inst.gameState.doctr[8] = "人 民 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = "协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = "经 典 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = "中 式 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = "国 家 监 护 资 本 主 义";
				GlobalScript.inst.gameState.doctr[14] = "社 会 主 义 导 向 市 场";
				GlobalScript.inst.gameState.doctr[15] = "左 翼 小 政 府";
				GlobalScript.inst.gameState.doctr[21] = "改 良 区 域 自 治 制 度";
				GlobalScript.inst.gameState.doctr[22] = "联 邦 制";
				GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
			}
			else
			{
				GlobalScript.inst.gameState.doctr[6] = " 一 党 制 共 和 国";
				GlobalScript.inst.gameState.doctr[7] = "一 党 独 大 式 民 主";
				GlobalScript.inst.gameState.doctr[8] = " 宪 政 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = " 协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = " 中 央 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = " 分 权 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = " 鸟 笼 经 济";
				GlobalScript.inst.gameState.doctr[14] = " “ 社 会 ” 市 场 经 济";
				GlobalScript.inst.gameState.doctr[15] = " 最 小 干 预";
				GlobalScript.inst.gameState.doctr[21] = " 联 邦 制";
				GlobalScript.inst.gameState.doctr[22] = " 联 省 自 治";
				GlobalScript.inst.gameState.doctr[24] = " 破 除 传 统";
			}
			a.modifies[3].active = true;
			a.empires[0].relations -= 500;
			a.empires[1].relations -= 500;
			GlobalScript.inst.gameState.allcountries[1].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[1].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
			if (GlobalScript.inst.gameState.allcountries[86].SubGosstroy == 11)
			{
				GlobalScript.inst.gameState.allcountries[86].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[86].SubGosstroy = 19;
				GlobalScript.inst.gameState.allcountries[86].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[86].Torg = true;
				GlobalScript.inst.gameState.allcountries[86].proprc = true;
				GlobalScript.inst.gameState.allcountries[86].JoinAllOurAlliances(yes: true);
			}
		}
		if (result_num == 1)
		{
			text = " 大 雨 让 野 餐 的 计 划 泡 汤 了 。";
		}
	}
}
