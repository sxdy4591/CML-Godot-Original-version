using EventsForDLC;
using UnityEngine;

public class Event632 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "牙 买 加 ， 我 们 热 爱 的 家 乡";
		text = "让 我 们 把 时 间 拨 前 面 一 些 。 在1972 年 ， 人 民 民 族 党 赢 得 了 大 选 ， 该 党 领 袖 迈 克 尔 · 曼 利 当 选 为 牙 买 加 总 理 。 曼 利 在 这 八 年 统 治 中 着 手 进 行 民 主 的 社 会 主 义 ： 其 为 所 有 工 人 制 定 了 最 低 工 资 ， 从 小 学 到 高 中 的 免 费 教 育 ， 降 低 最 低 投 票 年 龄 至18 岁 ， 实 行 女 性 同 工 同 酬 和 产 假 ， 提 供 免 费 医 疗 ， 进 行 土 改 ， 提 供 免 费 医 疗 ， 与 古 巴 关 系 密 切 。 由 于 政 策 开 销 过 高 ， 使 其 不 得 不 接 受 国 际 货 币 基 金 组 织 的 条 件 ， 此 举 导 致 进 一 步 的 经 济 压 力 ， 曼 利 最 终 决 定 断 绝 国 际 货 币 基 金 组 织 的 贷 款 ， 但 也 因 此 导 致 公 务 员 和 国 营 公 司 的 工 资 难 以 支 付 ， 导 致 了 一 次 电 力 工 人 罢 工 ， 几 乎 使70 % 的 牙 买 加 陷 入 黑 暗 。 在 如 此 时 刻 ， 曼 利 决 定 提 前 一 年 进 行 选 举 ， 而 此 举 也 导 致 了 牙 买 加 工 党 和 人 民 民 族 党 之 间 的 党 争 变 得 更 为 激 烈 ， 政 治 暴 力 更 为 频 繁 ， 这 不 由 得 让 人 们 想 起1976 年 选 举 年 的 政 治 暴 力 时 刻 。||如 今 ， 牙 买 加 即 将 进 入 选 举 ， 我 们 或 许 可 以 趁 此 机 会 帮 助 曼 利 ？ 毕 竟 ， 曼 利 对 社 会 主 义 的 观 感 还 算 不 错 。 当 然 ， 如 果 我 们 想 和 美 国 继 续 搞 好 关 系 ， 我 们 也 可 以 支 持 牙 买 加 工 党 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 3 && a.resultOfEvents[631] == 0)
		{
			button_text[0] = "帮 曼 利 一 把";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 在 当 地 没 有 如 此 巨 大 的 影 响 力？";
		}
		if (a.data[56] > 1 && a.resultOfEvents[631] == 1)
		{
			button_text[1] = " 为 牙 买 加 工 党 送 去 祝 贺";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 在 当 地 没 有 如 此 巨 大 的 影 响 力";
		}
		button_text[2] = " 怎 么 又 是 这 个 小 国 ？";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "牙 买 加 ， 我 们 热 爱 的 家 乡";
		if (result_num == 0)
		{
			if (a.influencePRC > a.empires[0].power || a.empires[0].relations >= 500)
			{
				text = "由 于 在 两 年 前 的 “ 一 份 爱 ， 一 份 和 平 ” 演 唱 会 之 前 牙 买 加 工 党 帮 派 的 举 动 导 致 牙 买 加 工 党 的 名 声 下 跌 ， 于 此 同 时 ， 牙 买 加 警 方 得 到 情 报 并 开 始 突 袭 蒂 沃 利 花 园 （ 金 斯 顿 的 一 个 街 区 ， 贩 毒 和 帮 派 活 动 的 活 跃 地 ） ， 抓 捕 到 了 部 分 “ 未 能 逃 走 ” 的 帮 派 成 员 并 找 到 了 工 党 参 与 贩 毒 、 圈 养 黑 帮 、 串 通cia 的 证 据 。 曼 利 在 得 知 消 息 后 当 天 便 宣 布 进 入 紧 急 状 态 ， 数 百 人 （ 包 括 牙 买 加 工 党 的 部 分 重 要 成 员 ） 被 指 控 试 图 推 翻 政 府 并 被 关 进 大 牢 。1980 年 选 举 结 果 自 然 是 人 民 民 族 党 继 续 执 政 ， 牙 买 加 与 美 国 的 关 系 进 一 步 恶 化 并 变 得 更 加 亲 近 苏 联 ， 格 林 纳 达 ， 古 巴 和 中 国 ， 本 就 是 人 民 民 族 党 亲 密 战 友 的 亲 古 巴 共 产 主 义 政 党 牙 买 加 工 人 党 获 得 了 更 多 的 部 门 任 职 。 为 表 达 对 我 们 的 感 激 ， 牙 买 加 开 始 在 北 京 设 立 大 使 馆 ， 并 与 我 们 进 行 密 切 的 经 贸 往 来 。 在 我 们 的 援 助 下 ， 曼 利 的 民 主 社 会 主 义 延 续 了 下 来 ， 帮 派 分 子 和 毒 品 贸 易 被 大 量 打 击 。 牙 买 加 于1981 年 进 行 宪 法 改 革 并 成 为 共 和 制 国 家 。";
				a.allcountries[152].Gosstroy = 2;
				a.allcountries[152].SubGosstroy = 3;
				a.allcountries[152].LeaveAlliances();
				a.allcountries[152].Torg = true;
				a.allcountries[152].proprc = true;
				a.influencePRC += 10;
				a.empires[0].power -= 20;
				a.empires[0].relations -= 50;
			}
			else
			{
				text = "由 于 在 两 年 前 的 “ 一 份 爱 ， 一 份 和 平 ” 演 唱 会 之 前 牙 买 加 工 党 帮 派 的 刺 杀 举 动 导 致 牙 买 加 工 党 的 名 声 下 跌 ， 于 此 同 时 ， 牙 买 加 警 方 得 到 情 报 并 开 始 突 袭 蒂 沃 利 花 园 （ 金 斯 顿 的 一 个 街 区 ， 贩 毒 和 帮 派 活 动 的 活 跃 地 ） ， 抓 捕 到 了 部 分 “ 未 能 逃 走 ” 的 帮 派 成 员 并 找 到 了 工 党 参 与 贩 毒 、 圈 养 黑 帮 、 串 通cia 的 证 据 。 曼 利 在 得 知 消 息 后 当 天 便 宣 布 进 入 紧 急 状 态 ， 但 此 时 ， 听 命 于 工 党 和cia 的 帮 派shower\u00a0posse 开 始 进 行 暴 动 ， 连 同 被 c i a 收 买 的 部 分 军 队 攻 打 总 理 府 。 最 后 曼 利 被 迫 接 受 投 降 并 被 关 入 大 牢 之 中 ， 人 民 民 族 党 的 政 治 盟 友 ， 亲 古 巴 的 工 人 党 则 被 查 禁 ， 人 民 民 族 党 高 层 在 未 经 审 判 的 情 况 下 大 量 被 捕 ， s h o w e r   p o s s e 的 头 目 莱 斯 特 · 科 克 加 入 工 党 并 成 为 新 政 府 的 总 理 。 新 政 府 开 始 对 过 去 八 年 人 民 民 族 党 的 政 策 进 行 逆 转 ： 大 量 实 行 私 有 化 ： 断 绝 与 苏 联 、 中 国 、 古 巴 和 格 林 纳 达 等 国 的 关 系 ； 与 美 国 进 行 深 度 合 作 ， 尤 其 是 和 c i a 进 行 合 作 ， 帮 派 和 毒 品 在 牙 买 加 进 一 步 泛 滥 了 起 来 。";
				a.allcountries[152].Gosstroy = 0;
				a.allcountries[152].SubGosstroy = 7;
				a.allcountries[152].LeaveAlliances();
				a.allcountries[152].Vyshi = true;
				a.empires[0].power += 20;
				a.empires[0].relations -= 50;
			}
			a.data[9] -= 50;
			a.data[22] -= 50;
		}
		if (result_num == 1)
		{
			text = "在 演 唱 会 开 始 前 几 天 ， 一 伙 自 称 是 支 持 牙 买 加 工 党 的 帮 派 对 鲍 勃 · 马 利 进 行 了 一 次 刺 杀 ， 由 于 伤 势 较 轻 ， 马 利 依 旧 坚 持 着 参 与 演 唱 会 。 此 次 演 唱 会 汇 集 了16 场 雷 鬼 音 乐 最 盛 大 的 表 演 ， 被 媒 体 称 为 “ 第 三 世 界 的 伍 德 斯 托 克 音 乐 节 ” 、 “ 鲍 勃 · 马 利 为 和 平 而 唱 ” ， 更 简 略 点 “ 鲍 勃 · 马 利 回 来 了 ” 。 这 场 演 唱 会 吸 引 了 超 过32 ,000 名 观 众 ， 演 出 收 益 将 用 于 “ 西 金 斯 敦 平 民 急 需 的 卫 生 设 施 和 住 房 ” 。 演 唱 会 于 下 午5 ：00 开 始 ， 前 埃 塞 俄 比 亚 王 储 阿 斯 法 · 沃 森 发 表 了 致 辞 ， 赞 扬 了 演 唱 会 组 织 者 为 恢 复 牙 买 加 和 平 所 做 的 努 力 。 演 唱 会 的 后 半 场 ， 鲍 勃 · 马 利 将 迈 克 尔 · 曼 利 和 爱 德 华 · 西 加 都 叫 到 舞 台 上 ， 三 人 一 起 举 起 双 手 以 表 示 他 们 的 团 结 。 然 而 ， 这 场 演 唱 会 并 没 有 平 息 政 治 暴 力 ， 组 织 这 次 演 唱 会 的 两 位 帮 派 头 目 在 之 后 两 年 内 均 遭 杀 害 ， 在1980 年 这 一 牙 买 加 的 选 举 年 内 发 生 的 谋 杀 案 比1979 年 多 了 一 倍 。 由 于 人 民 民 族 党 的 帮 派 的 刺 杀 举 动 导 致 人 民 民 族 党 支 持 率 有 所 下 降 。";
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.allcountries[152].Gosstroy = 3;
			a.allcountries[152].SubGosstroy = 12;
			a.allcountries[152].LeaveAlliances();
			a.allcountries[152].Vyshi = true;
			a.allcountries[152].Torg = true;
			a.empires[0].power += 20;
			a.empires[0].relations += 50;
		}
		if (result_num == 2)
		{
			text = "在 此 次 选 举 中 ， 工 党 大 获 全 胜 并 得 到 了58 .8 % 的 支 持 率 和 6 0 个 议 会 席 位 中 的51 个 ， 而 人 民 民 族 党 则 仅 获 得41 % 的 支 持 率 和9 个 议 会 席 位 ， 工 党 领 袖 爱 德 华 · 西 加 成 为 了 牙 买 加 总 理 。 新 政 府 开 始 扭 转 曼 利 的 政 策 ， 将 行 业 私 有 化 并 寻 求 与 美 国 建 立 更 紧 密 的 关 系 。 " + ((a.empires[0].now_leader == 0) ? "西 加 是 次 年 年 初 访 问 新 当 选 的 美 国 总 统 罗 纳 德 · 里 根 的 首 批 外 国 政 府 首 脑 之 一 ， 并 且 是 由 里 根 赞 助 的 加 勒 比 盆 地 倡 议 的 倡 议 者 之 一 。 " : "西 加 是 次 年 年 初 访 问 新 当 选 的 美 国 总 统 吉 米 · 卡 特 的 首 批 外 国 政 府 首 脑 之 一 ") + " 他 推 迟 了 与 古 巴 断 绝 外 交 关 系 的 承 诺 ， 直 到 一 年 后 他 指 责 古 巴 政 府 为 牙 买 加 罪 犯 提 供 庇 护 。";
			a.data[8] -= 20;
			a.allcountries[152].Gosstroy = 3;
			a.allcountries[152].SubGosstroy = 12;
			a.allcountries[152].LeaveAlliances();
			a.allcountries[152].Vyshi = true;
			a.empires[0].power += 20;
		}
	}
}
