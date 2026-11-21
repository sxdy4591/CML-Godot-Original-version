using EventsForDLC;
using UnityEngine;

public class Event73 : EventsSecond
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
		name = " 两 伊 战 争";
		if (a.allcountries[14].Gosstroy == 1)
		{
			text = " 伊 朗 与 伊 拉 克 的 关 系 在 新 的 革 命 之 后 越 来 越 差 。 伊 朗 自 视 为 全 体 什 叶 派 的 庇 护 者 ， 而 伊 拉 克 指 责 伊 朗 的 神 权 政 府 为 独 裁 专 横 的 法 西 斯 主 义 者 。 在 边 境 的 摩 擦 迅 速 升 温 。 近 日 ， 伊 朗 最 高 领 袖 霍 梅 尼 在 革 命 之 声 电 台 里 宣 读 了 《 致 伊 拉 克 被 压 迫 的 人 民 书 》 ， 其 中 指 责 伊 拉 克 “ 背 离 了 真 主 所 指 出 的 真 善 美 的 道 路 ” ， “ 为 无 神 论 者 和 异 端 大 开 绿 灯 ” ， 他 还 呼 吁 伊 拉 克 的 什 叶 派 推 翻 革 命 政 府 。 同 时 伊 朗 武 装 力 量 在 边 境 发 动 了 大 规 模 的 突 击 。 出 于 保 卫 祖 国 的 迫 切 需 要 ， 伊 拉 克 总 理 阿 齐 兹 宣 布 将 进 行 自 卫 反 击 作 战 。 并 邀 请 伊 朗 境 内 的 左 翼 反 抗 力 量 如 人 民 敢 死 队 和 人 民 圣 战 者 来 巴 格 达 ， 就 成 立 人 民 革 命 联 盟 这 样 一 个 反 对 神 权 政 府 的 左 翼 统 一 战 线 进 行 磋 商 。 一 场 战 争 爆 发 了 。||美 国 出 于 意 识 形 态 需 要 ， 不 得 不 陷 入 两 难 局 面 ， 而 苏 联 选 择 支 持 伊 拉 克 。  ";
		}
		text = " 伊 朗 与 伊 拉 克 间 的 关 系 长 期 紧 张 ， 这 主 要 是 由 于 领 土 争 端 。1969 年 ， 伊 朗 根 据1937 年 的 协 议 控 制 了 伊 拉 克 的 阿 拉 伯 河 ，1971 年 伊 朗 占 领 了 伊 拉 克 宣 称 的 霍 尔 木 兹 海 峡 内 的 三 个 岛 屿 。 然 而 ， 伊 朗 伊 斯 兰 革 命 胜 利 后 ， 形 势 进 一 步 恶 化 ， 霍 梅 尼 想 把 革 命 传 播 到 整 个 穆 斯 林 世 界 ， 开 始 积 极 派 遣 煽 动 者 和 代 理 人 到 伊 拉 克 。 以 及 支 持 伊 拉 克 库 尔 德 人 争 取 独 立 的 斗 争 。 作 为 对 此 的 回 应 ， 同 时 考 虑 到 伊 朗 军 队 因 革 命 和 伊 斯 兰 清 洗 而 混 乱 ， 萨 达 姆 · 侯 赛 因 决 定 入 侵 伊 朗 ， 以 占 领 石 油 资 源 丰 富 的 胡 兹 斯 坦 省 。9 月22 日 中 午 左 右 ， 伊 拉 克 军 队 入 侵 伊 朗 ， 遭 遇 了 强 烈 的 抵 抗 ， 目 前 正 在 伊 朗 领 土 内 缓 慢 地 进 军 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 战 争 即 地 狱";
		Object.Destroy(button[1]);
		button_text[1] = " 战 争 ， 战 争 从 未 改 变";
		Object.Destroy(button[2]);
		button_text[2] = " 战 争 即 和 平";
		Object.Destroy(button[3]);
		button_text[3] = " 如 果 你 想 要 和 平 ， 准 备 好 战 争";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 两 伊 战 争";
		if (result_num == 0)
		{
			text = " 战 争 势 头 越 来 越 大 ， 伊 朗 似 乎 不 会 轻 易 放 弃 。 美 国 和 苏 联 都 呼 吁 和 平 ， 但 事 实 上 他 们 都 明 里 暗 里 地 支 持 伊 拉 克 ， 因 为 伊 斯 兰 主 义 者 的 伊 朗 对 他 们 两 者 都 是 个 麻 烦 。";
			GlobalScript.inst.gameState.ingamewars[3].name_war = " 两 伊 战 争";
			GlobalScript.inst.gameState.ingamewars[3].is_going = true;
			GlobalScript.inst.gameState.ingamewars[3].side1 = " 伊 拉 克";
			GlobalScript.inst.gameState.ingamewars[3].side2 = " 伊 朗";
			GlobalScript.inst.gameState.ingamewars[3].ussr_place = 0;
			if (a.allcountries[14].Gosstroy != 1)
			{
				GlobalScript.inst.gameState.ingamewars[3].usa_place = 0;
			}
			GlobalScript.inst.gameState.ingamewars[3].infl1 = 500;
			GlobalScript.inst.gameState.ingamewars[3].infl2 = 500;
			GlobalScript.inst.gameState.data[143] += 6;
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
