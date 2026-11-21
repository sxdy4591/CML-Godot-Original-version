using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event564 : EventsSecond
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
		name = " 安 拉 ， 叙 利 亚 ， 阿 萨 德";
		text = " 1 9 7 0 年 “ 纠 正 运 动 ” 之 后 ， 阿 萨 德 赶 走 了 复 兴 社 会 党 叙 利 亚 支 部 的 新 左 派 ， 暂 停 并 倒 退 了 新 左 派 过 激 的 土 改 和 国 有 化 政 策 ， 进 行 实 用 主 义 政 策 ， 支 持 吸 引 外 资 ， 继 续 与 苏 联 合 作 ， 引 入 家 族 政 治 ， 并 将 一 部 分 阿 拉 伯 社 会 主 义 者 和 科 学 社 会 主 义 者 的 党 派 组 成 亲 政 府 的 民 族 进 步 阵 线 ， 但 是 前 任 政 府 政 策 造 成 的 后 果 并 未 完 全 退 却 。 且 1 9 7 6 年 介 入 黎 巴 嫩 内 战 和 1 9 7 9 年 的 阿 颇 勒 炮 兵 学 校 屠 杀 将 叙 利 亚 的 反 对 派 运 动 推 上 高 潮 ， 叙 利 亚 局 势 变 得 愈 发 不 稳 定 。||主 席 同 志 ， 叙 利 亚 是 我 们 的 老 朋 友 ， 我 们 是 否 按 照 既 往 方 针 支 持 他 们 ， 亦 或 者 ， 如 果 之 前 有 帮 助 过 反 对 派 们 ， 可 以 选 择 支 持 他 们 推 翻 阿 萨 德 政 权 ？";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 2;
		button_text[0] = " 还 是 帮 帮 阿 萨 德 吧";
		if (a.allcountries[35].cw && a.data[56] != 2)
		{
			button_text[1] = " 这 个 军 头 不 除 掉 怎 么 行 呢 ？";
			return;
		}
		Object.Destroy(button[1]);
		button_text[1] = " 我 们 对 叙 利 亚 内 政 干 涉 的 太 过 激 进 了 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 安 拉 ， 叙 利 亚 ， 阿 萨 德";
		if (result_num == 0)
		{
			text = " 1 9 8 0 年 6 月 2 7 日 ， 在 招 待 马 里 总 统 的 正 式 国 宴 上 ， 数 名 伊 斯 兰 主 义 者 试 图 刺 杀 参 加 国 宴 的 阿 萨 德 ， 但 阿 萨 德 最 终 只 受 轻 伤 。 作 为 报 复 ， 数 百 名 被 关 押 的 伊 斯 兰 主 义 者 被 处 决 。 在 1 9 8 2 年 的 哈 马 大 屠 杀 之 后 ， 伊 斯 兰 主 义 者 再 起 不 能 ， 叙 利 亚 也 逐 渐 稳 定 下 去 。";
		}
		if (result_num == 1)
		{
			text = " 得 益 于 我 们 之 前 的 行 动 ， 部 分 叙 利 亚 库 尔 德 组 织 ， 伊 斯 兰 主 义 者 ， 自 由 主 义 者 与 左 派 被 联 合 起 来 组 成 了 解 放 叙 利 亚 全 国 同 盟 ， 在 我 们 特 勤 的 帮 助 下 ， 1 9 8 0 年 6 月 2 7 日 在 招 待 马 里 总 统 的 正 式 国 宴 上 ， 数 名 被 安 插 进 去 的 反 对 派 分 子 成 功 刺 杀 了 阿 萨 德 。 阿 萨 德 之 死 彻 底 使 得 叙 利 亚 局 势 变 得 更 加 动 乱 ， 解 放 叙 利 亚 全 国 同 盟 借 此 机 会 拿 着 我 们 支 援 的 武 器 发 动 了 起 义 。 继 任 的 里 法 特 • 阿 萨 德 宣 布 与 中 国 断 交 ， 并 寻 求 苏 联 的 支 持 来 镇 压 叛 乱 。";
			a.data[9] -= 50;
			a.data[22] -= 50;
			a.allcountries[35].Torg = false;
			a.allcountries[35].Gosstroy = 0;
			a.allcountries[35].SubGosstroy = 10;
			a.empires[1].relations -= 150;
			a.empires[0].relations -= 150;
			load_scene_after_click = true;
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.number_event = 565;
			SceneManager.LoadScene("Event");
		}
	}
}
