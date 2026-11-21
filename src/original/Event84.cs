using EventsForDLC;
using UnityEngine;

public class Event84 : EventsSecond
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
		name = " 我 们 的 老 游 击 队 员 …";
		text = " 既 然 费 多 尔 · 库 拉 科 夫 已 经 出 局 ， 现 在 是 时 候 关 注 一 下 苏 共 的 保 守 派 了 。 当 然 ， 在 其 中 ， 最 显 赫 的 人 物 就 是 白 俄 罗 斯 共 产 党 中 央 委 员 会 第 一 书 记 彼 得 · 马 谢 罗 夫 。1965 年 ， 前 游 击 队 指 挥 官 马 谢 罗 夫 开 始 领 导 白 俄 罗 斯 ， 在 这 个 苏 联 加 盟 国 的 发 展 中 取 得 了 非 常 显 著 的 成 就 — — 国 民 收 入 增 长 了 几 倍 ， 工 农 业 发 展 活 跃 ， 建 立 了 一 批 企 业 ， 包 括 亚 速 特 化 学 联 合 企 业 、 诺 沃 布 洛 茨 克 化 工 厂 “ 聚 合 物 ” 、 戈 梅 利 化 工 厂 ， 别 列 佐 夫 斯 卡 亚 地 区 发 电 厂 。 由 于 马 谢 罗 夫 的 个 人 介 入 ， 明 斯 克 开 始 建 设 地 铁 。 公 顷 粮 食 产 量 达 到27 森 特 纳/ 公 顷 （1 森 特 纳 约 合50 千 克 ） ， 总 粮 食 产 量 达 到730 万 吨 。 然 而 ， 马 谢 罗 夫 对 革 新 队 伍 的 态 度 ， 引 起 了 许 多 党 员 的 不 满 ， 他 与 苏 共 的 主 要 意 识 形 态 专 家 米 哈 伊 尔 · 苏 斯 洛 夫 的 关 系 相 当 矛 盾 ， 也 与 蒙 羞 的 库 拉 科 夫 关 系 紧 密 。 然 而 ， 列 昂 尼 德 · 勃 列 日 涅 夫 显 然 将 他 视 为 部 长 会 议 主 席 柯 西 金 的 接 班 人 ， 而 柯 西 金 本 人 也 赞 同 这 一 选 择 。 国 安 部 已 经 为 清 除 马 谢 罗 夫 出 局 准 备 了 几 个 选 项 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (GlobalScript.inst.gameState.data[9] >= 80 && ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7)))
		{
			button_text[0] = " 交 通 事 故 怎 么 样 ？ 这 是 专 业 人 士 的 选 择 ！ （ 需 要8 特 工 网 络 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 这 太 危 险 了 ！";
		}
		button_text[1] = " 我 们 与 白 俄 罗 斯 的 党 员 取 得 联 系 ， 并 通 过 他 们 向 苏 斯 洛 夫 传 递 马 谢 罗 夫 的 黑 料 （ 需 要5 百 万 预 算 ）";
		button_text[2] = " 放 他 一 马";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 我 们 的 老 游 击 队 员 …";
		switch (result_num)
		{
		case 0:
			text = "14 时35 分 ， 彼 得 · 马 谢 罗 夫 离 开 白 共 中 央 委 员 会 建 筑 ， 乘 坐GAZ-13 “ 海 鸥 ” 轿 车 前 往 若 季 诺 ， 司 机 是E.  扎 伊 采 夫 （60 岁 ） 。 马 谢 罗 夫 坐 在 副 驾 驶 ， 后 座 是 安 全 军 官V. F.  切 斯 诺 科 夫 上 校 。 与 现 有 指 示 相 反 的 是 ， 没 有 一 辆 带 有 适 当 颜 色 和 闪 光 灯 的 交 警 车 辆 引 导 ， 而 是 白 色 的 “ 伏 尔 加 ” 汽 车 ， 带 有 扬 声 器 报 警 装 置 ， 但 没 有 闪 光 灯 。 在 “ 莫 斯 科 － 明 斯 克 ” 高 速 公 路 上 ， 通 往 斯 摩 列 维 奇 市 附 近 家 禽 养 殖 场 的 拐 弯 处 ， “ 海 鸥 ” 轿 车 被 一 辆 装 载 着 土 豆 的 自 卸 卡 车GAZ-SAZ-53B 撞 上 ， 司 机 是N.  普 斯 托 维 特 。 没 人 幸 存 下 来 － 马 谢 罗 夫 ， 他 的 司 机 和 保 镖 都 当 场 死 亡 ， 卡 车 司 机 － 在 送 往 医 院 的 路 上 因 为 大 量 失 血 死 亡 。 苏 联 总 检 察 长 办 公 室 展 开 了 调 查 ， 认 定 案 件 并 非 是 蓄 意 谋 杀 。 克 格 勃 不 认 同 这 个 结 论 ， 产 生 了 些 冲 突 。 但 官 方 说 法 仍 然 是 ： 运 土 豆 的 卡 车 司 机 有 罪 。 这 对 我 们 来 说 很 好 。";
			GlobalScript.inst.gameState.data[9] -= 80;
			GlobalScript.inst.gameState.empires[1].leaders[3].support -= 2;
			GlobalScript.inst.gameState.data[149] = 2;
			break;
		case 1:
			if (GlobalScript.inst.gameState.empires[1].relations >= 500)
			{
				text = " 我 们 的 特 工 与 白 俄 罗 斯 部 长 会 议 主 席 － 吉 洪 · 基 谢 廖 夫 取 得 联 系 ， 他 与 对 马 谢 罗 夫 政 策 不 满 的 白 俄 罗 斯 党 员 联 合 起 来 ， 我 们 的 特 工 还 给 了 他 关 于 马 谢 罗 夫 的 黑 料 （ 具 体 来 说 ， 他 支 持 柯 西 金 改 革 ， 要 求 发 展 能 够 刺 激 企 业 的 经 济 利 益 的 计 划 体 系 。 这 样 做 的 原 因 是 他 希 望 逐 步 摆 脱 经 济 管 理 的 行 政 和 命 令 方 法 。 同 时 ， 在 马 谢 罗 夫 的 倡 议 下 ， 白 俄 罗 斯 举 行 研 讨 会 讨 论 国 民 经 济 的 各 种 问 题 ， 与 苏 共 中 央 委 员 会 并 不 一 致 ） 。 基 谢 廖 夫 同 时 也 是 苏 联 部 长 会 议 副 主 席 ， 与 米 哈 伊 尔 · 苏 斯 洛 夫 会 面 ， 交 给 了 他 这 些 信 息 。 马 谢 罗 夫 被 召 到 莫 斯 科 ， 遭 到 批 判 ， 剥 夺 了 权 力 ， 被 迫 辞 职 退 休 。";
				GlobalScript.inst.gameState.data[8] -= 50;
				Leader leader;
				int support = (leader = GlobalScript.inst.gameState.empires[1].leaders[3]).support;
				leader.support = support - 1;
				GlobalScript.inst.gameState.data[149] = 2;
			}
			else
			{
				text = " 我 们 的 特 工 与 白 俄 罗 斯 部 长 会 议 主 席 － 吉 洪 · 基 谢 廖 夫 取 得 联 系 ， 他 与 对 马 谢 罗 夫 政 策 不 满 的 白 俄 罗 斯 党 员 联 合 起 来 ， 我 们 的 特 工 还 给 了 他 关 于 马 谢 罗 夫 的 黑 料 （ 具 体 来 说 ， 他 支 持 柯 西 金 改 革 ， 要 求 发 展 能 够 刺 激 企 业 的 经 济 利 益 的 计 划 体 系 。 这 样 做 的 原 因 是 他 希 望 逐 步 摆 脱 经 济 管 理 的 行 政 和 命 令 方 法 。 同 时 ， 在 马 谢 罗 夫 的 倡 议 下 ， 白 俄 罗 斯 举 行 研 讨 会 讨 论 国 民 经 济 的 各 种 问 题 ， 与 苏 共 中 央 委 员 会 并 不 一 致 ） 。 但 是 基 谢 廖 夫 不 敢 把 信 息 交 给 苏 斯 洛 夫 ， 结 果 马 谢 罗 夫 仍 然 担 任 原 职 。";
				GlobalScript.inst.gameState.data[8] -= 50;
			}
			break;
		case 2:
			text = "14 时35 分 ， 彼 得 · 马 谢 罗 夫 离 开 白 共 中 央 委 员 会 建 筑 ， 乘 坐GAZ-13 “ 海 鸥 ” 轿 车 前 往 若 季 诺 ， 司 机 是E.  扎 伊 采 夫 （60 岁 ） 。 马 谢 罗 夫 坐 在 副 驾 驶 ， 后 座 是 安 全 军 官V. F.  切 斯 诺 科 夫 上 校 。 与 现 有 指 示 相 反 的 是 ， 没 有 一 辆 带 有 适 当 颜 色 和 闪 光 灯 的 交 警 车 辆 引 导 ， 而 是 白 色 的 “ 伏 尔 加 ” 汽 车 ， 带 有 扬 声 器 报 警 装 置 ， 但 没 有 闪 光 灯 。 在 “ 莫 斯 科 － 明 斯 克 ” 高 速 公 路 上 ， 通 往 斯 摩 列 维 奇 市 附 近 家 禽 养 殖 场 的 拐 弯 处 ， “ 海 鸥 ” 轿 车 被 一 辆 装 载 着 土 豆 的 自 卸 卡 车GAZ-SAZ-53B 撞 上 ， 司 机 是N.  普 斯 托 维 特 。 没 人 幸 存 下 来 － 马 谢 罗 夫 ， 他 的 司 机 和 保 镖 都 当 场 死 亡 ， 卡 车 司 机 － 在 送 往 医 院 的 路 上 因 为 大 量 失 血 死 亡 。 苏 联 总 检 察 长 办 公 室 与 克 格 勃 展 开 了 调 查 ， 认 定 案 件 并 非 是 蓄 意 谋 杀 。 调 查 组 最 终 得 出 结 论 ： 运 土 豆 的 卡 车 司 机 有 罪 。";
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
