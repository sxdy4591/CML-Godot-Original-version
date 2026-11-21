using EventsForDLC;
using UnityEngine;

public class Event626 : EventsSecond
{
	private GameState a;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = "摩 尔 人 的 土 地";
		text = "自 毛 里 塔 尼 亚 于1960 年 独 立 以 来 ， 莫 克 塔 尔 · 乌 尔 德 · 达 达 赫 总 统 一 直 领 导 着 这 个 国 家 。 他 逐 渐 建 立 了 由 毛 里 塔 尼 亚 人 民 党 领 导 的 一 党 制 政 权 ， 该 党 奉 行 大 毛 里 塔 尼 亚 民 族 主 义 （ 主 张 毛 里 塔 尼 亚 吞 并 西 撒 哈 拉 和 马 里 北 部 ） 和 伊 斯 兰 社 会 主 义 ， 并 采 取 反 殖 民 主 义 与 反 帝 国 主 义 的 进 步 外 交 ， 疏 远 法 帝 国 主 义 。 我 国 同 毛 里 塔 尼 亚 政 府 开 展 了 大 量 合 作 ， 现 在 已 经 成 为 该 国 最 重 要 的 援 助 国 之 一 。1975 年 毛 里 塔 尼 亚 在 和 摩 洛 哥 一 起 瓜 分 西 撒 哈 拉 地 区 的 战 争 的 失 利 使 得 毛 里 塔 尼 亚 陷 入 了 经 济 危 机 ， 这 给 达 达 赫 总 统 和 人 民 党 政 权 的 权 威 带 来 了 沉 重 打 击 。||据 了 解 ， 陆 军 参 谋 长 穆 斯 塔 法 · 乌 尔 德 · 萨 莱 克 上 校 已 经 在 他 的 周 围 聚 集 起 来 一 个 阴 谋 圈 子 ， 准 备 向 达 达 赫 总 统 发 起 军 事 政 变 。 我 们 可 以 通 过 阻 止 政 变 ， 来 让 达 达 赫 有 机 会 继 续 建 设 社 会 主 义 ， 并 和 他 继 续 进 行 合 作 ， 不 过 ， 继 续 援 助 这 个 奴 隶 制 仍 横 行 的 充 满 沙 漠 的 贫 穷 国 家 真 的 有 必 要 吗 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		if (a.data[56] < 3)
		{
			button_text[0] = "帮 助 达 达 赫 反 政 变";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 达 达 赫 大 势 已 去 … …";
		}
		button_text[1] = " 放 任 事 态 发 展 并 和 新 政 府 保 持 关 系";
		button_text[2] = " 没 必 要 继 续 关 注 那 个 国 家";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = "摩 尔 人 的 土 地";
		if (result_num == 0)
		{
			text = "由 于 我 们 的 提 醒 ， 达 达 赫 总 统 得 以 在 我 们 特 工 的 帮 助 下 组 织 起 仍 忠 于 他 的 部 队 逮 捕 萨 莱 克 阴 谋 集 团 ， 叛 变 军 官 因 叛 国 罪 被 处 决 。 经 过 我 们 的 斡 旋 ， 达 达 赫 政 府 承 认 了 阿 拉 伯 撒 哈 拉 民 主 共 和 国 ， 放 弃 了 对 西 撒 哈 拉 的 领 土 要 求 ， 并 与 西 撒 人 阵 达 成 了 和 平 协 定 ， 毛 里 塔 尼 亚 的 军 队 撤 出 了 西 撒 哈 拉 领 土 ， 这 使 得 毛 塔 和 摩 洛 哥 的 关 系 极 度 恶 化 了 。 在 我 们 的 援 助 下 ， 毛 里 塔 尼 亚 的 局 势 正 在 缓 慢 地 走 向 正 常 化 ， 经 济 也 逐 渐 走 向 恢 复 ， 达 达 赫 开 始 更 大 力 度 地 推 进 社 会 改 革 ， 并 将 支 持 大 毛 里 塔 尼 亚 主 义 转 向 支 持 泛 非 团 结 ， 以 促 进 国 内 的 阿 拉 伯 - 柏 柏 尔 文 化 的 摩 尔 人 和 南 方 黑 人 之 间 的 关 系 上 的 平 等 化 和 政 治 上 的 团 结 度 。 作 为 交 换 ， 毛 里 塔 尼 亚 人 民 党 仿 照 人 民 民 主 国 家 和 阿 拉 伯 的 复 兴 党 国 家 ， 将 支 持 毛 泽 东 思 想 的 毛 里 塔 尼 亚 劳 动 党 和 此 前 反 对 同 人 民 党 合 作 的 独 立 工 会 组 织 “ 进 步 工 人 联 盟 ” 等 左 翼 反 对 派 合 法 化 ， 纳 入 民 族 进 步 阵 线 ， 阵 线 内 的 组 织 能 够 合 法 参 与 政 府 ； 于 此 同 时 ， 人 民 党 也 开 始 进 行 党 领 导 军 队 的 建 设 。";
			a.allcountries[59].Gosstroy = 2;
			a.allcountries[59].SubGosstroy = 15;
			a.allcountries[59].LeaveAlliances();
			a.allcountries[59].Torg = true;
			a.allcountries[59].proprc = true;
			a.influencePRC += 10;
			a.data[9] -= 50;
			a.data[8] -= 100;
		}
		if (result_num == 1)
		{
			text = "经 过 一 场 不 流 血 的 政 变 ， 萨 利 克 成 功 推 翻 了 达 达 赫 总 统 ， 组 织 起 民 族 复 兴 军 事 委 员 会 并 自 任 主 席 。 新 的 军 政 府 开 始 转 向 亲 法 政 策 并 继 续 维 持 和 摩 洛 哥 的 联 盟 。 由 于 未 能 良 好 处 理 国 内 问 题 ， 军 政 府 很 快 陷 入 内 部 倾 轧 中 。||1979 年8 月 ， 达 达 赫 获 准 流 亡 法 国 。 在 法 国 ， 他 开 始 组 织 反 对 派 政 党 … …||这 些 并 不 能 妨 碍 两 国 的 合 作 ， 我 们 将 继 续 和 毛 塔 新 政 府 保 持 合 作 关 系 。";
			a.allcountries[59].Gosstroy = 0;
			a.allcountries[59].SubGosstroy = 7;
			a.allcountries[59].LeaveAlliances();
			a.allcountries[59].puppetOf = 21;
			a.allcountries[59].Torg = true;
			a.data[4] -= 30;
		}
		if (result_num == 2)
		{
			text = "经 过 一 场 不 流 血 的 政 变 ， 萨 利 克 成 功 推 翻 了 达 达 赫 总 统 ， 组 织 起 民 族 复 兴 军 事 委 员 会 并 自 任 主 席 。 新 的 军 政 府 开 始 转 向 亲 法 政 策 并 继 续 维 持 和 摩 洛 哥 的 联 盟 。 由 于 未 能 良 好 处 理 国 内 问 题 ， 军 政 府 很 快 陷 入 内 部 倾 轧 中 。||1979 年8 月 ， 达 达 赫 获 准 流 亡 法 国 。 在 法 国 ， 他 开 始 组 织 反 对 派 政 党 … …";
			a.allcountries[59].Gosstroy = 0;
			a.allcountries[59].SubGosstroy = 7;
			a.allcountries[59].LeaveAlliances();
			a.allcountries[59].puppetOf = 21;
		}
	}
}
