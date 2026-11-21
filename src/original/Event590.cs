using EventsForDLC;
using UnityEngine;

public class Event590 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 红 色 的 所 罗 门 雄 狮";
		text = " 在 1 9 7 4 年 率 领 军 官 完 成 了 推 翻 君 主 制 的 伟 大 胜 利 ， 在 1 9 7 7 年 击 溃 了 党 内 左 倾 右 倾 保 守 革 新 各 派 势 力 ， <color=#2F4F4F>门 格 斯 图 · 海 尔 · 马 里 亚 姆</color> 上 校 已 然 成 为 埃 塞 俄 比 亚 的 无 冕 之 王 ， 超 越 海 尔 · 塞 拉 西 的 <color=#2F4F4F>“ 红 色 尼 格 斯 ”</color> 。 但 是 ， 这 样 的 革 命 果 实 在 他 死 后 还 能 维 持 吗 ？ 这 样 超 凡 脱 俗 的 领 袖 死 后 ， 摇 摇 欲 坠 的 埃 塞 是 不 是 会 硬 着 陆 呢 ？ 也 许 ， 他 们 应 该 看 向 东 亚 冉 冉 升 起 的 红 色 巨 龙 。 不 仅 仅 是 革 命 的 教 条 ， 更 是 为 了 让 红 太 阳 照 遍 全 球 ， 让 我 们 当 一 回 革 命 的 教 员 吧 ！";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 老 子 革 命 儿 好 汉 ！";
		button_text[1] = " 这 样 太 疯 狂 了";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 红 色 的 所 罗 门 雄 狮";
		if (result_num == 0)
		{
			text = " 在 近 日 ， 我 们 邀 请 社 会 主 义 埃 塞 俄 比 亚 临 时 军 事 行 政 主 席 <color=#2F4F4F>门 格 斯 图</color> · 海 尔 · 马 里 亚 姆 同 志 来 到 我 国 ， 展 开 为 期 一 周 的 国 事 访 问 。 在 访 问 的 路 上 ， <color=#2F4F4F>门 格 斯 图</color> 主 席 参 观 了 革 命 军 事 博 物 馆 ， 上 海 江 南 造 船 厂 ， 韶 山 毛 主 席 故 居 等 诸 多 带 有 “ 中 国 革 命 心 路 历 程 ” 的 建 筑 。 他 亲 自 向 毛 主 席 纪 念 堂 献 上 了 花 圈 ， 还 参 观 了 1 9 6 9 年 珍 宝 岛 战 争 纪 念 碑 。 在 人 民 大 会 堂 的 招 待 宴 会 上 ， <color=#2F4F4F>门 格 斯 图</color> 主 席 发 表 了 一 篇 演 讲 ， 其 中 高 度 赞 扬 了" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 。 他 说 ： “" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + "同 志 把 中 国 革 命 带 入 了 一 个 新 的 高 潮 ， 尤 其 是 确 保 革 命 老 将 守 护 革 命 果 实 的 理 念 ， 埃 塞 俄 比 亚 这 样 应 当 学 习 。 ”||在 回 国 后 ， <color=#2F4F4F>门 格 斯 图</color> 开 展 了 一 系 列 激 进 的 改 革 。 临 时 军 委 彻 底 结 束 存 在 ， 取 而 代 之 的 是 埃 塞 俄 比 亚 革 命 工 人 党 ， 而 <color=#2F4F4F>门 格 斯 图</color> 和 他 的 亲 戚 战 友 们 身 居 高 位 。 埃 塞 俄 比 亚 的 第 一 夫 人 <color=#2F4F4F>乌 班 齐 · 比 绍</color> 也 被 任 命 为 政 府 总 理 和 埃 塞 俄 比 亚 革 命 妇 女 联 合 会 主 席 。 在 新 政 府 的 落 成 仪 式 上 ， <color=#2F4F4F>门 格 斯 图</color> 为 自 己 换 上 了 一 套 元 帅 服 。 在 民 间 大 量 的 雕 像 已 经 开 始 修 建 ， 对 于 他 的 个 人 崇 拜 的 民 谣 与 民 俗 故 事 已 经 在 民 间 流 传 开 来 。 其 中 包 括 他 在 推 翻 君 主 制 的 革 命 中 如 何 立 下 汗 马 功 劳 ； 是 怎 么 用 铁 拳 击 溃 苏 联 修 正 主 义 ， 美 帝 国 主 义 和 内 部 的 第 五 纵 队 的 ； 如 何 在 国 内 外 战 场 中 身 先 士 卒 ， 亲 自 指 挥 ， 亲 自 部 署 ， 在 前 线 取 得 一 个 又 一 个 胜 利 的 ； 又 在 建 设 社 会 主 义 时 如 何 以 柔 软 的 一 面 爱 戴 关 怀 群 众 。 他 给 自 己 安 上 了 无 数 的 头 衔 ， 如 “ 来 自 非 洲 屋 脊 的 天 才 ” ， “ 当 代 杰 出 的 马 克 思 列 宁 主 义 者 ” 、 “ 革 命 思 想 的 永 恒 火 焰 ” ， 是 “ 前 所 未 有 的 最 天 真 、 最 自 然 、 最 有 感 情 也 最 纯 粹 的 革 命 者 ” 。 已 经 有 传 言 说 他 会 培 养 他 的 大 女 儿 为 唯 一 接 班 人 ， 而 这 位 长 公 主 已 经 被 任 命 为 教 育 部 部 长 ， 并 被 授 予 了 上 校 军 衔 ， 尽 管 她 尚 未 完 成 小 学 教 育 。 一 个 革 命 烈 士 纪 念 馆 也 在 有 条 不 紊 的 修 建 中 。 在 历 史 课 本 中 ， 社 会 主 义 国 家 对 埃 塞 的 援 助 被 逐 渐 遗 忘 ， 转 而 变 成 了 大 元 帅 的 功 劳 ， 而 大 量 曾 经 的 临 时 军 委 成 员 也 在 历 史 的 长 河 中 失 去 了 姓 名 。||埃 塞 俄 比 亚 国 内 外 的 反 对 派 大 力 谴 责 这 一 切 ， 称 他 为 “ 红 色 暴 君 ” ， 但 就 让 他 们 说 去 吧 ， 就 让 他 们 说 <color=#2F4F4F>门 格 斯 图</color> 大 元 帅 这 也 不 行 那 也 不 行 吧 ！ ";
			a.data[8] -= 100;
			a.data[9] -= 100;
			a.allcountries[41].name = " 埃 塞 俄 比 亚 \n民 主 主 义 人 民 共 和 国";
			a.allcountries[41].Gosstroy = 0;
			a.allcountries[41].SubGosstroy = 19;
			a.allcountries[41].EstablishGovernment(Government.ProChina);
			a.allcountries[41].Torg = true;
			a.allcountries[41].JoinAllOurAlliances(yes: true);
		}
		if (result_num == 1)
		{
			text = " 说 笑 了 ， 主 席 同 志 ， 他 不 过 是 埃 塞 俄 比 亚 又 一 个 普 通 的 不 能 再 普 通 的 领 导 人 罢 了 。";
			a.event_done[590] = false;
		}
	}
}
