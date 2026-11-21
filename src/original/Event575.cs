using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event575 : EventsSecond
{
	private GameState a;

	private float timer = 2f;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 伦 敦 桥 倒 下 了";
		text = " 主 席 同 志 ！ 重 大 消 息 ， 是 澳 大 利 亚 方 面 的 。||";
		if ((a.allcountries[92].Gosstroy == 2 || a.allcountries[92].Gosstroy == 1) && a.allcountries[92].SubGosstroy != 18 && !a.allcountries[92].isSocEU && !a.allcountries[92].isNATO)
		{
			text += " 英 国 工 党 “ 硬 左 派 ” 废 除 君 主 制 并 转 向 联 邦 共 和 的 政 治 改 革 已 导 致 维 系 英 联 邦 的 旧 政 治 关 系 名 存 实 亡 ， 并 顺 势 激 起 了 澳 大 利 亚 人 的 反 君 主 情 绪 ： 既 然 英 国 已 经 给 女 王 分 配 了 公 民 身 份 ， 那 澳 大 利 亚 也 应 该 效 法 母 国 “ 先 进 经 验 ” 。 对 温 莎 王 朝 和 与 之 有 关 的 澳 洲 一 切 建 制 的 落 井 下 石 就 此 开 始 。 ";
		}
		else if (a.allcountries[92].Gosstroy == 2 && a.allcountries[92].isSocEU)
		{
			text += " 英 国 工 党 “ 软 左 派 ” 为 加 入 欧 洲 社 会 主 义 联 盟 而 实 行 的 配 套 改 革 政 治 改 革 已 导 致 维 系 英 联 邦 的 旧 政 治 关 系 名 存 实 亡 ， 并 顺 势 激 起 了 澳 大 利 亚 人 的 反 君 主 情 绪 ： 既 然 英 国 已 经 将 女 王 掏 空 为 政 治 木 偶 ， 那 澳 大 利 亚 也 应 该 效 法 母 国 “ 先 进 经 验 ” 。 对 温 莎 王 朝 和 与 之 有 关 的 澳 洲 一 切 建 制 的 落 井 下 石 就 此 开 始 。";
		}
		else
		{
			text += " 英 国 托 洛 茨 基 主 义 者 改 革 上 议 院 与 打 击 贵 族 的 政 治 改 革 已 导 致 维 系 英 联 邦 的 旧 政 治 关 系 名 存 实 亡 ， 并 顺 势 激 起 了 澳 大 利 亚 人 的 反 君 主 情 绪 ： 既 然 英 国 已 经 将 女 王 掏 空 为 政 治 木 偶 ， 那 澳 大 利 亚 也 应 该 效 法 母 国 “ 先 进 经 验 ” 。 对 温 莎 王 朝 和 与 之 有 关 的 澳 洲 一 切 建 制 的 落 井 下 石 就 此 开 始 。";
		}
		if (a.allcountries[135].SubGosstroy == 4)
		{
			text += " 当 然 ， 相 应 措 施 也 不 可 避 免 地 导 致 了 恐 赤 情 绪 的 进 一 步 激 化 — — 甚 至 影 响 了 自 由 党 - 乡 村 党 联 合 的 政 治 路 线 。 为 稳 定 社 会 秩 序 ， 澳 大 利 亚 总 理 鲍 勃 · 霍 克 立 即 准 备 三 步 走 ： 首 先 是 宣 布 澳 大 利 亚 成 为 共 和 国 ， 其 次 是 建 立 临 时 政 府 修 宪 并 迅 速 举 行 大 选 。 本 次 选 举 可 被 视 为 澳 大 利 亚 的 第 二 次 开 国 ， 显 然 将 为 该 国 的 政 治 发 展 定 调 … … ";
		}
		else
		{
			text += " 当 然 ， 相 应 措 施 也 不 可 避 免 地 导 致 了 恐 赤 情 绪 的 进 一 步 激 化 — — 甚 至 影 响 了 自 由 党 - 乡 村 党 联 合 的 政 治 路 线 。 为 稳 定 社 会 秩 序 ， 澳 大 利 亚 总 理 马 尔 科 姆 · 弗 雷 泽 立 即 准 备 三 步 走 ： 首 先 是 宣 布 澳 大 利 亚 成 为 共 和 国 ， 其 次 是 建 立 临 时 政 府 修 宪 并 迅 速 举 行 大 选 。 本 次 选 举 可 被 视 为 澳 大 利 亚 的 第 二 次 开 国 ， 显 然 将 为 该 国 的 政 治 发 展 定 调 … …";
		}
		if (a.resultOfEvents[573] == 1)
		{
			text += "我 们 要 帮 一 把 我 们 的 工 党 同 志 ， 彻 底 决 定 这 个 新 生 共 和 国 的 命 运 吗 ？ ";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		if (a.resultOfEvents[573] == 1 && !a.allcountries[135].Vyshi)
		{
			button_text[0] = " 助 力 工 党 同 志 彻 底 转 向 社 会 主 义 目 标 ！";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 无 从 下 手 … …";
		}
		button_text[1] = " 英 帝 国 的 碎 片 会 自 己 决 定 自 己 的 命 运 … …";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 伦 敦 桥 倒 下 了";
		if (result_num == 0)
		{
			text = " 得 到 我 国 帮 助 的 工 党 很 快 便 以 绝 对 多 数 制 霸 选 举 ， 并 代 表 大 多 数 选 民 拥 抱 了 澳 大 利 亚 的 完 全 转 型 ： 澳 大 利 亚 将 在 沿 用 代 议 制 民 主 的 框 架 下 拥 抱 全 新 的 原 住 民 - 多 元 文 化 认 同 ， 并 以 斯 堪 的 纳 维 亚 社 会 主 义 为 蓝 本 建 设 服 务 大 众 的 经 济 。 前 进 吧 ， 公 平 的 澳 大 利 亚 ！ ";
			a.data[8] -= 150;
			a.data[9] -= 150;
			a.allcountries[135].LeaveAlliances();
			a.allcountries[135].Gosstroy = 2;
			a.allcountries[135].SubGosstroy = 3;
			a.allcountries[135].Torg = true;
			a.allcountries[135].proprc = true;
			a.empires[0].relations -= 200;
			a.empires[0].power -= 50;
			if (a.allcountries[85].isSocEU)
			{
				text += " |新 生 的 澳 大 利 亚 共 和 国 并 没 有 忘 记 与 英 国 的 纽 带 ， 同 样 决 定 和 欧 社 联 合 作 。";
				a.allcountries[135].isSocEU = true;
				a.allcountries[136].LeaveAlliances();
				a.allcountries[136].Gosstroy = 2;
				a.allcountries[136].SubGosstroy = 3;
				a.allcountries[136].cw = true;
				a.allcountries[136].Torg = true;
				a.allcountries[136].isSocEU = true;
			}
		}
		if (result_num == 1)
		{
			text = " 英 帝 国 的 坠 落 与 恐 赤 情 绪 最 终 导 致 了 意 想 不 到 的 黑 马 夺 魁 ： 昆 士 兰 的 “ 乡 巴 佬 独 裁 者 ” ， 以 操 纵 选 票 而 臭 名 昭 著 的 约 · 比 耶 克 · 彼 德 森 成 为 了 自 由 党 - 乡 村 党 联 合 提 名 的 候 选 人 。 他 很 快 便 将 自 己 的 “ 昆 士 兰 经 验 ” 推 广 至 全 国 ， 最 终 如 愿 当 选 共 和 国 第 一 任 总 理 ！ 不 过 ， 彼 德 森 的 “ 含 金 量 ” 有 目 共 睹 ： 光 是 想 到 他 在 选 区 将 屈 居 第 三 的 乡 村 党 打 造 为 州 内 铁 桶 的 经 历 ， 就 足 以 激 起 范 围 波 及 全 澳 的 大 规 模 抗 议 。 看 来 澳 大 利 亚 注 定 成 为 “ 不 自 由 民 主 政 权 ” 。 ";
			a.allcountries[135].Vyshi = false;
			a.allcountries[135].Gosstroy = 2;
			a.allcountries[135].SubGosstroy = 8;
			if (a.allcountries[85].isSocEU)
			{
				text = " 纠 结 的 亲 英 情 绪 最 终 又 一 次 帮 助 了 工 党 。 也 就 在 欧 洲 民 主 左 翼 取 得 大 胜 的 背 景 下 ， 新 一 场 选 举 以 工 党 取 得 微 弱 多 数 ， 并 同 获 得 空 前 票 数 的 澳 大 利 亚 共 产 党 等 左 翼 势 力 结 盟 告 终 。 他 们 代 表 大 多 数 选 民 拥 抱 了 澳 大 利 亚 的 完 全 转 型 ： 澳 大 利 亚 将 在 沿 用 代 议 制 民 主 的 框 架 下 拥 抱 全 新 的 原 住 民 - 多 元 文 化 认 同 ， 并 以 斯 堪 的 纳 维 亚 社 会 主 义 为 蓝 本 建 设 服 务 大 众 的 经 济 。 前 进 吧 ， 公 平 的 澳 大 利 亚 ！ 而 新 生 的 澳 大 利 亚 共 和 国 也 清 楚 投 桃 报 李 的 道 理 ， 在 左 翼 联 合 政 府 形 成 次 日 便 向 欧 洲 社 会 主 义 联 盟 递 交 了 入 盟 申 请 。";
				a.allcountries[135].SubGosstroy = 14;
				a.allcountries[135].isSocEU = true;
				a.allcountries[136].LeaveAlliances();
				a.allcountries[136].Gosstroy = 2;
				a.allcountries[136].cw = true;
				a.allcountries[136].SubGosstroy = 3;
				a.allcountries[136].isSocEU = true;
			}
			else
			{
				load_scene_after_click = true;
			}
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.number_event = 576;
			SceneManager.LoadScene("Event");
		}
	}
}
