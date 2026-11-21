using EventsForDLC;
using KGWar;
using UnityEngine;

public class Event645 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "混 乱 的 阶 梯";
		text = "中 国 在 远 东 地 区 决 定 性 的 军 事 行 动 不 仅 空 前 削 弱 了 苏 联 的 影 响 力 ， 将 其 影 响 力 基 本 逐 出 亚 洲 。 同 时 还 为 其 治 下 的 东 欧 盟 国 做 了 “ 表 率 ” — — 考 虑 到 苏 东 集 团 事 实 上 可 被 视 为 围 绕 苏 联 建 立 的 “ 恒 星 系 ” 结 构 ， 其 前 途 命 运 与 苏 联 国 力 息 息 相 关 。 那 么 ， 在 战 后 摇 摇 欲 坠 的 显 然 不 只 有 苏 联 ： 东 欧 诸 国 的 政 客 已 从 苏 联 削 减 补 贴 ， 调 整 军 事 部 署 ， 事 实 上 削 弱 军 事 存 在 （ 显 然 是 为 了 维 持 国 内 稳 定 的 需 要 ） 的 举 动 中 嗅 出 了 不 妙 气 息 ， 并 已 开 始 为 此 做 准 备 。 他 们 或 是 增 强 与 邻 国 的 多 边 合 作 ， 或 是 越 加 转 向 发 展 同 欧 美 国 家 与 第 三 世 界 的 关 系 。 华 约 与 经 济 互 助 委 员 会 两 大 体 系 已 开 始 逐 步 变 性 ， 苏 联 在 其 中 的 话 语 权 以 肉 眼 可 见 的 速 率 降 低 ： 也 就 在 这 敏 感 时 刻 ， 早 和 中 国 、 法 国 等 强 权 勾 肩 搭 背 的 罗 马 尼 亚 则 看 准 苏 联 衰 微 、 东 欧 多 国 自 顾 不 暇 的 时 机 直 接 跳 船 ， 彻 底 脱 离 了 苏 东 集 团 的 一 体 化 架 构 ， 转 而 决 定 选 择 加 入 “ 更 有 前 途 ” 的 集 团 内 。 考 虑 到 齐 奥 塞 斯 库 的 行 事 风 格 ， 他 只 有 可 能 应 用 “ 中 国 式 方 案 ” ， 并 打 算 将 其 应 用 到 治 国 理 政 与 解 决 比 萨 拉 比 亚 地 区 的 “ 历 史 遗 留 问 题 ” 上 。 不 过 ， 多 瑙 河 的 天 才 显 然 还 是 低 估 了 苏 东 集 团 这 具 尸 体 内 潜 藏 的 力 量 — — 虽 说 苏 联 老 大 哥 荣 光 不 再 ， 可 苏 东 体 系 的 最 后 捍 卫 者 们 仍 保 留 了 原 汁 原 味 的 尾 巴 摇 狗 习 俗 ， 决 定 对 这 个 试 图 推 倒 东 欧 多 米 诺 骨 牌 的 叛 逆 政 权 一 点 颜 色 瞧 瞧 。 毕 竟 ， 坐 在 坦 克 上 的 东 欧 保 守 派 集 团 们 依 然 需 要 保 护 伞 彰 显 自 身 权 。 如 果 苏 东 体 系 彻 底 解 体 ， 这 些 在 国 内 缺 乏 根 基 的 伪 群 众 党 必 然 难 以 应 付 早 在 境 内 打 出 风 头 的 民 粹 主 义 分 子 ： 于 是 我 们 可 说 ， 争 夺 苏 联 遗 产 的 战 争 已 经 开 始 … …";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 火 药 桶 已 经 引 爆 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "混 乱 的 阶 梯";
		if (result_num == 0)
		{
			text = "国 际 观 察 员 认 为 。 虽 说 苏 东 社 会 主 义 阵 营 内 已 生 嫌 隙 ， 且 力 量 不 复 往 昔 ； 可 对 付 一 个 孤 立 无 援 ， 且 扎 根 华 约 腹 地 的 罗 马 尼 亚 仍 是 绰 绰 有 余 。 以 美 国 为 首 的 西 方 国 家 已 开 始 控 诉 华 约 对 罗 马 尼 亚 的 入 侵 ， 并 大 力 渲 染 所 谓 “ 邪 恶 帝 国 余 毒 尚 存 ” 。 显 然 ， 他 们 只 能 重 弹1956 年 匈 牙 利 事 件 与1968 年 捷 克 事 件 时 的 老 调 ， 只 能 用 舆 论 给 罗 马 尼 亚 拉 些 “ 同 情 ” 。 而 苏 联 则 在 标 榜 中 立 的 同 时 悄 然 对 罗 马 尼 亚 引 入 了 封 锁 与 制 裁 。 现 在 ， 唯 有 我 们 才 能 够 保 护 弃 暗 投 明 的 好 朋 友 ！";
			a.ingamewars[76] = new War().Name("喀 尔 巴 阡 行 动").Attacker("罗 马 尼 亚").Defender("华 沙 条 约")
				.AttackerInfluence(300)
				.DefenderInfluence(700)
				.TickTime(12)
				.SovietSupportDefender.AmericanSupportAttacker.CreateWar;
			a.data[1] += 300;
			a.data[3] += 300;
			a.data[4] -= 200;
			a.data[6] += 150;
			a.allcountries[5].isSEV = false;
			a.allcountries[5].isOVD = false;
			a.allcountries[5].JoinAllOurAlliances(yes: true);
			a.empires[1].relations -= 250;
			a.empires[1].power -= 15;
			a.influencePRC += 15;
		}
	}
}
