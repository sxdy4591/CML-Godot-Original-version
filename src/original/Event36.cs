using EventsForDLC;
using UnityEngine;

public class Event36 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

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
		name = " 联 盟 崩 解 ？";
		text = " 自1968 年 以 来 ， 执 政 的 复 兴 党 和 伊 拉 克 共 产 党 在 伊 拉 克 进 步 民 族 爱 国 阵 线 的 框 架 内 ， 在 伊 拉 克 建 立 了 不 稳 定 的 合 作 关 系 。1972 年5 月 ，2 名 伊 共 代 表 被 正 式 引 入 政 府 ， 尽 管 共 产 党 仍 处 于 非 正 式 地 位 。 然 而 ， 这 种 合 作 结 果 是 短 暂 的 。 最 近 ， 伊 拉 克 的 复 兴 党 领 导 人 再 次 开 始 对 共 产 党 发 动 镇 压 ， 但 仍 有 维 持 脆 弱 联 盟 的 空 间 。 也 许 我 们 应 该 介 入 一 下 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 不 ， 它 不 值 得";
		button_text[1] = " 谴 责 复 兴 社 会 党 的 领 导 人";
		if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.influencePRC >= 50 && a.data[56] > 0)
		{
			button_text[2] = " 在 特 工 小 组 和 政 治 压 力 的 帮 助 下 ， 逼 迫 各 方 对 话";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 的 力 量 和 影 响 力 并 不 足 够";
		}
		if (GlobalScript.inst.gameState.data[9] >= 50 && GlobalScript.inst.gameState.influencePRC >= 50 && a.data[56] < 2)
		{
			button_text[3] = " 开 始 联 络 伊 拉 克 的 反 对 派";
		}
		else
		{
			Object.Destroy(button[3]);
			button_text[3] = " 太 危 险 了 ， 这 不 值 得";
		}
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 联 盟 崩 解 ？";
		switch (result_num)
		{
		case 0:
			text = " 在 经 历 了 一 段 时 间 的 磨 难 后 ， 和 与 复 兴 社 会 党 领 导 人 建 立 关 系 的 失 败 尝 试 后 ， 伊 拉 克 共 产 党 决 定 断 绝 联 系 。1979 年4 月 ， 共 产 党 部 长 退 出 政 府 ， 伊 共 停 止 参 加 国 民 阵 线 。1979 年5 月 ， 伊 共 领 导 层 决 定 退 出 国 民 阵 线 ， 并 转 入 非 法 状 态 。";
			GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 10;
			break;
		case 1:
			text = " 我 们 的 谴 责 如 预 期 的 只 是 恶 化 与 伊 拉 克 的 关 系 ， 并 使 伊 拉 克 进 一 步 镇 压 共 产 党 人 。 在 经 历 了 一 段 时 间 的 磨 难 后 ， 和 与 复 兴 社 会 党 领 导 人 建 立 关 系 的 失 败 尝 试 后 ， 伊 拉 克 共 产 党 决 定 断 绝 联 系 。1979 年4 月 ， 共 产 党 部 长 退 出 政 府 ， 伊 共 停 止 参 与 国 民 阵 线 。1979 年5 月 ， 伊 共 领 导 决 定 退 出 国 民 阵 线 ， 进 入 非 法 状 态 。";
			GlobalScript.inst.gameState.data[6] += 10;
			GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 10;
			GlobalScript.inst.gameState.allcountries[14].Torg = false;
			break;
		case 2:
			text = " 我 们 对 双 方 施 加 了 非 官 方 的 政 治 压 力 ， 同 时 在 情 报 部 门 收 集 的 信 息 作 支 撑 和 反 对 阿 拉 伯 复 兴 社 会 党 的 小 规 模 抗 议 活 动 的 支 持 下 ， 我 们 总 算 取 得 了 成 果 。 复 兴 社 会 党 停 止 了 对 伊 拉 克 共 产 党 的 镇 压 ， 并 宣 布 与 其 结 成 牢 固 的 联 盟 ， 伊 共 也 得 到 了 该 党 在 国 民 阵 线 中 的 成 员 资 格 ， 停 止 反 政 府 煽 动 同 时 要 求 解 除 紧 急 状 态 。 很 明 显 ， 在 这 些 美 丽 的 词 藻 背 后 ， 隐 藏 着 一 场 暗 中 的 斗 争 和 联 盟 中 不 稳 定 的 求 同 存 异 ， 但 这 样 的 联 盟 也 将 坚 持 一 段 时 间 。";
			GlobalScript.inst.gameState.data[1] += 70;
			GlobalScript.inst.gameState.data[4] -= 30;
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.ICP = true;
			break;
		case 3:
			text = " 意 识 到 萨 达 姆 的 野 心 ， 以 及 出 于 在 各 个 阵 线 上 尽 可 能 的 反 对 苏 联 扩 张 。 我 们 摒 弃 了 过 去 对 伊 拉 克 共 产 党 的 敌 对 态 度 ， 在 叙 利 亚 边 境 的 哈 塞 克 市 。 外 联 部 的 同 志 面 见 了 伊 拉 克 共 产 党 领 导 人 阿 齐 兹 · 穆 罕 默 德 ， 流 亡 在 叙 利 亚 的 左 翼 复 兴 党 成 员 马 哈 茂 德 · 拉 沙 德 · 谢 赫 · 拉 迪 、 法 齐 · 穆 特 拉 克 · 拉 维 和 马 哈 茂 德 · 沙 姆 萨 博 士 ； 复 兴 党 内 的 马 克 思 主 义 异 见 者 ， 以 及 一 部 分 仍 然 在 活 动 的 少 数 民 族 抵 抗 组 织 ， 如 库 尔 德 斯 坦 爱 国 联 盟 和 库 尔 德 斯 坦 民 主 同 盟 的 代 表 。 我 们 诚 挚 的 邀 请 他 们 就 组 建 反 抗 萨 达 姆 的 社 会 法 西 斯 政 权 组 建 统 一 战 线 。 作 为 回 报 ， 我 国 和 叙 利 亚 将 不 遗 余 力 的 援 助 他 们 ， 在 北 京 和 大 马 士 革 设 立 办 公 室 ， 并 在 叙 利 亚 设 置 训 练 基 地 ， 我 们 将 承 担 一 切 武 器 。 很 快 ， 多 方 就 组 建 “ 伊 拉 克 爱 国 民 主 同 盟 ” 达 成 了 一 致 。 他 们 甚 至 引 入 了 一 些 毛 主 义 原 则 如 “ 三 大 纪 律 八 项 注 意 ” ， 农 村 包 围 城 市 ， 日 常 召 开 的 批 判 大 会 ， 对 《 选 集 》 的 研 究 和 农 村 工 作 队 。 该 组 织 的 长 期 目 标 是 建 立 一 个 科 学 社 会 主 义 的 伊 拉 克 共 和 国 ， 短 期 目 标 则 是 在 伊 拉 克 北 部 建 立 稳 定 的 解 放 区 。 库 尔 德 人 ， 伊 拉 克 共 产 党 的 游 击 队 和 倒 戈 的 部 分 政 府 军 被 改 组 为 伊 拉 克 人 民 解 放 军 。 由 自 斋 月 革 命 以 来 就 抵 抗 着 政 府 的 老 将 ， 同 时 也 是 亚 述 少 数 族 裔 的 阿 卜 · 约 瑟 夫 指 挥 。||萨 达 姆 对 于 我 们 支 持 武 装 反 对 派 非 常 不 高 兴 ， 他 要 求 莫 斯 科 方 面 为 其 提 供 更 多 装 备 ， 并 且 在 复 兴 党 的 代 表 大 会 上 一 个 一 个 揪 出 了 他 所 认 为 的 反 对 派 ， 伊 拉 克 陷 入 了 新 的 一 轮 恐 慌 和 不 稳 定 中 。";
			GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 10;
			GlobalScript.inst.gameState.allcountries[14].Torg = false;
			GlobalScript.inst.gameState.data[1] += 70;
			GlobalScript.inst.gameState.data[4] -= 30;
			GlobalScript.inst.gameState.data[8] -= 50;
			GlobalScript.inst.gameState.data[9] -= 50;
			GlobalScript.inst.gameState.allcountries[14].prcpower = 30;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
