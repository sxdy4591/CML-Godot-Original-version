using EventsForDLC;
using UnityEngine;

public class Event454 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 越 南 的 野 心";
		if (GlobalScript.inst.gameState.resultOfEvents[56] == 1)
		{
			text = " 越 南 成 功 击 溃 民 主 柬 埔 寨 政 府 并 挫 败 我 们 的 进 攻 后 ， 野 心 极 度 膨 胀 。 在 苏 联 的 支 持 下 ， 黎 笋 、 凯 山 · 丰 威 汉 和 韩 桑 林 在 胡 志 明 市 进 行 了 一 周 的 秘 密 协 商 和 谈 判 ， 最 终 ， 三 方 签 订 了 关 于 成 立 印 度 支 那 民 主 共 和 国 联 邦 的 协 议 。 十 日 后 ， 在 印 度 支 那 联 合 人 民 军 （ 主 要 是 越 南 人 民 军 ） 的 监 督 下 ， 三 国 通 过 一 场 超 过 9 0 % 支 持 率 的 全 民 公 投 ， 正 式 宣 布 成 立 印 度 支 那 民 主 共 和 国 联 邦 ， 首 都 为 胡 志 明 市 ； 同 时 ， 越 南 共 产 党 、 柬 埔 寨 人 民 革 命 党 和 老 挝 人 民 革 命 党 在 一 场 联 合 代 表 大 会 中 再 次 统 一 为 印 度 支 那 共 产 党 。 新 的 “ 联 邦 政 府 “ 表 示 ， 三 国 的 整 合 是 长 期 性 的 ， 要 经 过 从 邦 联 到 联 邦 缓 慢 整 合 的 过 程 。 苏 联 承 认 了 联 邦 ， 并 表 示 这 是 解 决 印 度 支 那 民 族 问 题 的 最 佳 方 案 ； 新 的 印 度 支 那 政 府 宣 布 将 加 快 和 经 互 会 的 一 体 化 ， 老 挝 和 柬 埔 寨 也 正 式 融 入 了 经 互 会 体 系 ； 双 方 也 将 开 展 大 规 模 军 事 合 作 ， 苏 联 军 事 基 地 正 在 处 于 筹 备 过 程 中 ， 同 时 苏 联 将 参 与 ” 柬 埔 寨 平 叛 “ 。 我 们 支 持 的 民 主 柬 埔 寨 联 合 政 府 谴 责 了 这 个 所 谓 的 联 邦 ， 称 这 是 越 南 对 主 权 国 家 的 公 然 吞 并 。 除 了 苏 东 阵 营 的 国 家 外 ， 大 多 国 家 都 未 承 认 这 印 度 支 那 的 合 并 。 这 对 我 国 无 疑 是 坏 事 ， 这 证 明 ， 苏 联 对 我 们 正 式 完 成 了 南 北 合 围 。 我 们 应 该 对 这 一 “ 联 邦 ” 有 所 表 示 了 。 ";
		}
		else
		{
			text = " 越 南 成 功 击 溃 民 主 柬 埔 寨 政 府 后 ， 野 心 极 度 膨 胀 。 在 苏 联 的 支 持 下 ， 黎 笋 、 凯 山 · 丰 威 汉 和 韩 桑 林 在 胡 志 明 市 进 行 了 一 周 的 秘 密 协 商 和 谈 判 ， 最 终 ， 三 方 签 订 了 关 于 成 立 印 度 支 那 民 主 共 和 国 联 邦 的 协 议 。 十 日 后 ， 在 印 度 支 那 联 合 人 民 军 （ 主 要 是 越 南 人 民 军 ） 的 监 督 下 ， 三 国 通 过 一 场 超 过 9 0 % 支 持 率 的 全 民 公 投 ， 正 式 宣 布 成 立 印 度 支 那 民 主 共 和 国 联 邦 ， 首 都 为 胡 志 明 市 ； 同 时 ， 越 南 共 产 党 、 柬 埔 寨 人 民 革 命 党 和 老 挝 人 民 革 命 党 在 一 场 联 合 代 表 大 会 中 再 次 统 一 为 印 度 支 那 共 产 党 。 新 的 “ 联 邦 政 府 “ 表 示 ， 三 国 的 整 合 是 长 期 性 的 ， 要 经 过 从 邦 联 到 联 邦 缓 慢 整 合 的 过 程 。 苏 联 承 认 了 联 邦 ， 并 表 示 这 是 解 决 印 度 支 那 民 族 问 题 的 最 佳 方 案 ； 新 的 印 度 支 那 政 府 宣 布 将 加 快 和 经 互 会 的 一 体 化 ， 老 挝 和 柬 埔 寨 也 正 式 融 入 了 经 互 会 体 系 ； 双 方 也 将 开 展 大 规 模 军 事 合 作 ， 苏 联 军 事 基 地 正 在 处 于 筹 备 过 程 中 ， 同 时 苏 联 将 参 与 ” 柬 埔 寨 平 叛 “ 。 我 们 曾 经 支 持 的 民 主 柬 埔 寨 联 合 政 府 谴 责 了 这 个 所 谓 的 联 邦 ， 称 这 是 越 南 对 主 权 国 家 的 公 然 吞 并 。 除 了 苏 东 阵 营 的 国 家 外 ， 大 多 国 家 都 未 承 认 这 印 度 支 那 的 合 并 。 这 对 我 国 无 疑 是 坏 事 ， 这 证 明 ， 苏 联 对 我 们 正 式 完 成 了 南 北 合 围 。 我 们 应 该 对 这 一 “ 联 邦 ” 有 所 表 示 了 。 ";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 谴 责 这 一 联 邦";
		if (GlobalScript.inst.gameState.resultOfEvents[56] == 0 && GlobalScript.inst.gameState.data[56] >= 2)
		{
			button_text[1] = " 为 新 联 邦 欢 呼";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[56] == 1)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 你 还 嫌 不 够 丢 脸 吗 ？！";
		}
		else if (GlobalScript.inst.gameState.data[56] < 2)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 不 可 能 为 修 正 主 义 者 欢 呼 ！";
		}
		button_text[2] = " 保 持 沉 默";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 越 南 的 野 心";
		switch (result_num)
		{
		case 0:
			text = " 我 国 外 交 部 声 明 ： “ 越 南 肆 意 侵 略 主 权 国 家 ， 支 持 傀 儡 政 府 ， 践 踏 国 际 秩 序 ， 应 该 受 到 强 烈 谴 责 ！ 民 主 柬 埔 寨 联 合 政 府 为 民 族 解 放 的 斗 争 是 完 全 正 义 的 ！ “ 印 支 方 面 并 未 对 此 做 出 回 应 ， 但 是 ， 我 们 南 北 边 境 紧 张 的 局 势 也 并 未 得 到 缓 和 。";
			GlobalScript.inst.gameState.empires[1].relations -= 100;
			GlobalScript.inst.gameState.data[6] += 50;
			GlobalScript.inst.gameState.data[1] += 100;
			GlobalScript.inst.gameState.influencePRC -= 20;
			GlobalScript.inst.gameState.allcountries[23].name = " 印 支 联 邦 柬 埔 寨 区";
			GlobalScript.inst.gameState.allcountries[11].name = " 印 度 支 那 联 邦";
			GlobalScript.inst.gameState.allcountries[11].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[22].name = " 印 支 联 邦 老 挝 区";
			GlobalScript.inst.gameState.allcountries[23].isSEV = true;
			GlobalScript.inst.gameState.allcountries[11].isSEV = true;
			GlobalScript.inst.gameState.allcountries[22].isSEV = true;
			GlobalScript.inst.gameState.allcountries[11].Torg = false;
			GlobalScript.inst.gameState.allcountries[22].Torg = false;
			GlobalScript.inst.gameState.allcountries[23].Torg = false;
			break;
		case 1:
			text = " 我 国 外 交 部 表 示 ： “ 越 南 推 翻 了 残 暴 的 波 尔 布 特 政 权 ， 为 他 们 带 去 了 真 正 的 解 放 和 真 正 的 社 会 主 义 ； 联 邦 的 成 立 合 理 合 法 ， 这 是 解 决 印 度 支 那 民 族 问 题 的 最 佳 方 案 。 ”   民 主 柬 埔 寨 联 合 政 府 和 我 们 断 绝 了 联 系 。 但 是 ， 我 们 和 苏 联 、 越 南 的 关 系 获 得 了 些 许 缓 和 ， 南 北 边 境 的 边 防 压 力 也 稍 稍 减 小 了 。";
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.data[6] -= 50;
			GlobalScript.inst.gameState.data[1] -= 100;
			GlobalScript.inst.gameState.influencePRC -= 30;
			GlobalScript.inst.gameState.allcountries[23].name = " 印 支 联 邦 柬 埔 寨 区";
			GlobalScript.inst.gameState.allcountries[11].name = " 印 度 支 那 联 邦";
			GlobalScript.inst.gameState.allcountries[11].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[22].name = " 印 支 联 邦 老 挝 区";
			GlobalScript.inst.gameState.allcountries[23].isSEV = true;
			GlobalScript.inst.gameState.allcountries[11].isSEV = true;
			GlobalScript.inst.gameState.allcountries[22].isSEV = true;
			GlobalScript.inst.gameState.allcountries[11].Torg = true;
			GlobalScript.inst.gameState.allcountries[22].Torg = false;
			GlobalScript.inst.gameState.allcountries[23].Torg = false;
			break;
		case 2:
			text = " 我 们 的 政 府 并 未 对 这 一 行 为 进 行 评 价 ， 一 切 如 常 。";
			GlobalScript.inst.gameState.influencePRC -= 50;
			GlobalScript.inst.gameState.allcountries[23].name = " 印 支 联 邦 柬 埔 寨 区";
			GlobalScript.inst.gameState.allcountries[11].name = " 印 度 支 那 联 邦";
			GlobalScript.inst.gameState.allcountries[11].parts[0] = true;
			GlobalScript.inst.gameState.allcountries[22].name = " 印 支 联 邦 老 挝 区";
			GlobalScript.inst.gameState.allcountries[23].isSEV = true;
			GlobalScript.inst.gameState.allcountries[11].isSEV = true;
			GlobalScript.inst.gameState.allcountries[22].isSEV = true;
			GlobalScript.inst.gameState.allcountries[11].Torg = false;
			GlobalScript.inst.gameState.allcountries[22].Torg = false;
			GlobalScript.inst.gameState.allcountries[23].Torg = false;
			break;
		}
	}
}
