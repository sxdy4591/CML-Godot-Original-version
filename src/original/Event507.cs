using EventsForDLC;
using UnityEngine;

public class Event507 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " “ 虾 ” 行 动";
		text = " 1 9 7 2 年 1 0 月 2 6 日 ， 马 蒂 厄 · 克 雷 库 以 少 校 身 份 发 动 武 装 政 变 ， 并 获 得 贝 宁 政 府 控 制 权 ， 且 随 即 自 立 为 总 统 。 1 9 7 5 年 ， 他 不 但 将 “ 达 荷 美 共 和 国 ” 更 名 为 “ 贝 宁 人 民 共 和 国 ” ， 还 成 立 了 贝 宁 人 民 革 命 党 ， 使 该 国 成 为 一 个 社 会 主 义 国 家 。 这 一 激 进 的 举 动 吓 傻 了 周 边 的 国 家 和 法 国 。 一 个 说 法 语 的 社 会 主 义 国 家 定 会 摧 毁 法 国 在 非 洲 的 势 力 范 围 。 它 与 法 国 和 该 地 区 其 他 非 洲 政 府 的 关 系 显 著 恶 化 了 。 吉 斯 卡 尔 · 德 斯 坦 的 法 国 政 府 担 心 马 克 思 主 义 在 西 非 的 传 播 ， 并 决 定 做 出 反 应 。 乌 弗 埃 · 博 瓦 尼 、 纳 辛 贝 · 埃 亚 德 马 、 约 瑟 夫 - 德 西 雷 · 蒙 博 托 和 哈 桑 二 世 ， 他 们 除 了 在 外 交 上 孤 立 ， 内 部 破 坏 贝 宁 的 经 济 外 ， 还 决 定 组 织 一 场 政 变 。 臭 名 昭 著 的 雇 佣 兵 头 子 鲍 勃 · 德 纳 尔 牵 头 展 开 了 “ 虾 ” 行 动 ， 计 划 除 掉 克 雷 库 ， 一 举 推 翻 克 雷 库 政 府 。 主 席 同 志 ， 也 许 我 们 应 该 警 告 克 雷 库 关 于 政 变 的 事 ？ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] <= 2 && a.influencePRC >= 10)
		{
			button_text[0] = " 提 示 克 雷 库 小 心 政 变（ 需 要 3 点 特 勤 ）";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 他 们 不 愿 意 听 我 们 的";
		}
		if (a.allcountries[21].Torg && GlobalScript.inst.gameState.allcountries[21].Gosstroy != 1)
		{
			button_text[1] = " 我 们 支 持 法 国 的 方 案 ， 苏 联 是 个 更 大 的 威 胁 。";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 再 讨 厌 苏 联 人 ， 也 不 能 做 这 种 事";
		}
		button_text[2] = " 贝 宁 ， 我 在 地 图 上 压 根 找 不 到 啊 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " “ 虾 ” 行 动";
		if (result_num == 0)
		{
			text = " 我 们 打 了 一 通 电 话 ， 提 示 了 克 雷 库 同 志 警 惕 可 能 的 反 革 命 政 变 。 克 雷 库 感 谢 了 我 们 的 警 告 ， 并 加 强 了 对 科 托 努 的 警 戒 。||1 月 1 6 日 凌 晨 ， 法 国 雇 佣 兵 从 加 蓬 乘 坐 飞 机 出 发 前 往 科 托 努 。 飞 机 刚 刚 接 近 机 场 ， 两 架 米 格 2 1 飞 机 立 刻 起 飞 警 戒 。 在 屡 次 警 告 无 果 之 后 ， 防 空 部 队 用 高 射 炮 予 以 驱 赶 ， 瞬 间 运 输 机 冒 起 了 浓 烟 。 在 摇 晃 了 几 下 后 ， 飞 机 直 直 的 坠 入 了 地 里 。 瞬 间 机 场 浓 烟 滚 滚 ， 赶 来 的 消 防 队 员 只 找 到 了 几 具 穿 着 法 式 军 服 的 尸 体 ， 并 没 有 找 到 鲍 勃 · 德 纳 尔 （ 事 后 被 证 实 是 他 睡 过 头 了 忘 记 登 机 ） 。 克 雷 库 在 电 视 演 讲 中 公 开 谴 责 了 法 国 对 贝 宁 内 政 的 无 耻 干 涉 ， 并 且 感 谢 了 中 国 的 提 示 。 克 雷 库 公 开 转 向 社 会 主 义 阵 营 ， 彻 底 和 法 国 一 刀 两 断 ， 并 着 手 发 行 自 己 的 货 币 。";
			a.data[8] -= 20;
			a.data[22] -= 100;
			a.influencePRC += 50;
			a.empires[0].relations -= 100;
			a.empires[0].power -= 50;
			GlobalScript.inst.gameState.allcountries[62].Torg = true;
		}
		if (result_num == 1)
		{
			a.data[8] -= 10;
			text = " 1 月 1 6 日 凌 晨 ， 法 国 雇 佣 兵 从 加 蓬 坐 运 输 机 前 往 科 托 努 。 凌 晨 的 科 托 努 机 场 静 悄 悄 。 很 快 ， 头 戴 红 色 贝 雷 帽 的 雇 佣 兵 从 飞 机 上 下 来 。 坐 上 吉 普 车 ， 一 路 风 驰 电 掣 的 冲 往 总 统 府 。 在 路 上 刚 好 遇 到 了 准 备 上 班 的 克 雷 库 总 统 和 总 统 卫 队 。 双 方 发 生 了 激 烈 交 火 ， 而 克 雷 库 在 战 斗 中 被 一 枚 流 弹 打 中 了 喉 咙 ， 最 终 死 于 失 血 过 多 。||随 后 ， 达 荷 美 救 国 委 员 会 宣 布 接 管 权 力 ， 并 开 始 重 新 修 正 前 政 府 的 国 有 化 政 策 。";
			GlobalScript.inst.gameState.allcountries[62].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[62].SubGosstroy = 7;
			GlobalScript.inst.gameState.allcountries[62].LeaveAlliances();
			GlobalScript.inst.gameState.allcountries[62].puppetOf = 21;
			GlobalScript.inst.gameState.allcountries[62].Torg = true;
			GlobalScript.inst.gameState.allcountries[62].name = " 达 荷 美";
			a.empires[0].relations += 80;
			a.empires[0].power += 50;
		}
		if (result_num == 2)
		{
			text = " 1 月 1 6 日 凌 晨 ， 法 国 雇 佣 兵 从 加 蓬 坐 运 输 机 前 往 科 托 努 。 凌 晨 的 科 托 努 机 场 静 悄 悄 。 很 快 ， 头 戴 红 色 贝 雷 帽 的 雇 佣 兵 从 飞 机 上 下 来 。 坐 上 吉 普 车 ， 一 路 风 驰 电 掣 的 冲 往 总 统 府 。 但 就 在 同 时 ， 另 一 伙 人 也 坐 着 运 输 机 下 来 了 ， 这 是 一 伙 亚 洲 人 。 亚 洲 人 在 说 了 几 句 听 不 懂 的 话 后 ， 立 刻 拿 起 武 器 和 雇 佣 兵 对 抗 。 事 后 方 知 这 是 应 邀 来 参 观 的 朝 鲜 人 民 军 军 事 代 表 团 。 雇 佣 兵 抛 下 一 地 的 尸 体 灰 溜 溜 的 逃 跑 了 。||赶 来 的 消 防 队 员 只 找 到 了 几 具 穿 着 法 式 军 服 的 尸 体 ， 并 没 有 找 到 鲍 勃 · 德 纳 尔 （ 事 后 被 证 实 是 他 睡 过 头 了 忘 记 登 机 ） 。 克 雷 库 在 电 视 演 讲 中 公 开 谴 责 了 法 国 对 贝 宁 内 政 的 无 耻 干 涉 ， 并 宣 布 将 扩 大 与 社 会 主 义 国 家 的 合 作 。 大 量 的 法 裔 因 为 这 件 事 而 遭 到 了 迫 害 。";
			GlobalScript.inst.gameState.allcountries[62].Gosstroy = 0;
			GlobalScript.inst.gameState.allcountries[62].SubGosstroy = 10;
		}
	}
}
