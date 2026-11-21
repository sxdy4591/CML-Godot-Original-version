using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event666 : EventsSecond
{
	private GameState a;

	public bool load_scene_after_click;

	private void Awake()
	{
		a = GlobalScript.inst.gameState;
	}

	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 轮 回 的 复 仇";
		text = " 总 统 阁 下 ！ 一 件 难 以 置 信 的 事 情 发 生 了 ！ 在 我 们 将 政 治 搞 得 一 团 糟 的 时 候 ， 已 经 确 认 死 亡 且 遗 体 被 移 出 纪 念 堂 的 共 产 主 义 恐 怖 暴 政 的 始 作 俑 者 独 夫 民 贼 — — 毛 泽 东 ， 在 几 年 后 的 今 天 似 乎 “ 复 活 ” 了 ！ 有 线 人 反 映 ， 这 个 长 相 酷 似 那 位 暴 君 的 人 正 在 积 极 联 系 那 些 同 情 毛 时 代 以 及 对 当 今 不 满 的 左 派 分 子 ， 并 与 那 些 我 们 的 反 对 派 甚 至 是 政 府 内 部 的 部 分 人 士 达 成 了 某 种 协 议 。 民 间 已 经 出 现 一 种 不 正 常 的 狂 热 和 躁 动 ， 我 们 的 军 队 和 政 府 也 发 生 了 某 种 变 化 ， 不 再 像 从 前 那 样 忠 于 我 们 。 总 统 阁 下 ， 我 们 的 统 治 正 面 临 着 最 严 峻 的 考 验 ！ ";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 1;
		button_text[0] = " 必 须 立 刻 找 到 这 个 人 ， 并 立 即 将 他 处 死 ！ 国 安 部 ， 出 动 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 轮 回 的 复 仇";
		if (result_num == 0)
		{
			text = " 出 人 意 料 的 是 ， 国 安 部 的 行 动 失 败 了 ， “ 毛 泽 东 ” 的 拥 护 者 抓 住 了 他 们 ， 并 说 服 部 分 人 员 “ 弃 暗 投 明 ” ， 末 日 已 至 … …";
			GlobalScript.inst.gameState.data[1] = 0;
			GlobalScript.inst.gameState.data[3] = 0;
			GlobalScript.inst.gameState.data[9] = 0;
			load_scene_after_click = true;
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 8;
			SceneManager.LoadScene("Ending");
		}
	}
}
