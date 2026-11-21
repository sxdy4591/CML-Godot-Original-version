using EventsForDLC;
using UnityEngine;

public class Event386 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "为 了 乍 得 人 的 乍 得";
		text = string.Format("乍 得 人 民 自 独 立 以 来 便 处 于 法 国 人 和 南 方 买 办 政 府 的 多 重 压 迫 之 下 ， 国 内 的 内 战 更 是 持 续 了 十 多 年 。 尽 管 早 在 多 年 前 ， 易 卜 拉 欣 · 阿 巴 查 同 志 就 尝 试 将 反 抗 力 量 团 结 起 来 ， 进 行 一 场 革 命 ， 但 是 这 一 切 都 随 着 他 的 牺 牲 和FROLINAT 沦 为 利 比 亚 的 代 理 人 而 结 束 。||在 非 洲 革 命 高 歌 猛 进 的 情 况 下 ， 针 对 乍 得 的 情 况 和 联 盟 在 尼 日 尔 的 胜 利 行 动 ， 非 洲 革 命 联 盟 已 经 制 定 了 一 个 计 划 ， 由 尼 日 尔 、 喀 麦 隆 、 中 非 、 苏 丹 和 利 比 亚 来 开 展 一 场 彻 底 终 结 乍 得 乱 象 的 行 动 。", "\n");
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = "革 命 万 岁 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "为 了 乍 得 人 的 乍 得";
		a.data[143]++;
		text = string.Format("五 国 组 建 了 一 支 统 一 调 度 的 武 装 部 队 ， 代 号 “ 乍 得 湖 ” 的 行 动 一 触 即 发 。 联 军 同 东 南 西 北 四 个 方 向 攻 入 了 乍 得 ， 喀 麦 隆 人 民 军 迅 速 开 入 了 恩 贾 梅 纳 ， 在 该 国 国 内 的 乍 得 团 结 与 社 会 主 义 行 动 以 及FROLINAT 残 存 的 马 克 思 主 义 派 系 的 帮 助 下 顺 利 击 溃 了 乍 得 南 北 的 两 个 政 府 ， 并 号 召 全 体 人 民 起 义 ， 开 展 人 民 革 命 。 而 法 国 和 美 国 拒 绝 武 装 介 入 这 一 问 题 ， 仅 仅 对 这 一 事 件 表 达 了 “ 强 烈 谴 责 ” 。||乍 得 人 民 联 邦 共 和 国 成 立 了 ， 乍 得 \t团 结 与 社 会 主 义 行 动 吸 收 了FROLINAT 的 马 克 思 主 义 派 系 ， 并 邀 请 来 自 前 非 洲 社 会 主 义 运 动 - 乍 得 的 反 殖 民 主 义 领 袖 艾 哈 迈 德 · 库 拉 马 拉 加 入 ， 该 党 正 式 成 为 了 该 国 的 领 导 力 量 ， 总 书 记 菲 德 勒 · 蒙 加 尔 成 为 了 该 国 的 新 领 导 人 。 随 后 ， 在 特 别 法 庭 上 ， 哈 布 雷 被 宣 判 犯 有 战 争 罪 、 反 人 类 罪 、 强 奸 罪 、 性 侵 罪 、 故 意 杀 人 罪 、 叛 国 罪 和 种 族 灭 绝 罪 而 被 判 处 死 刑 。 新 政 府 宣 布 要 继 承 易 卜 拉 欣 · 阿 巴 查 的 遗 志 ， 以 马 克 思 列 宁 主 义 为 指 导 ， 建 立 各 民 族 完 全 平 等 的 社 会 主 义 和 泛 非 主 义 新 乍 得 。", "\n");
		a.ingamewars[80].is_going = false;
		a.allcountries[57].parts[0] = false;
		GlobalScript.inst.gameState.allcountries[57].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 2;
		a.allcountries[57].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[57].Torg = true;
		GlobalScript.inst.gameState.allcountries[57].proprc = true;
		GlobalScript.inst.gameState.allcountries[57].JoinAllOurAlliances(yes: true);
	}
}
