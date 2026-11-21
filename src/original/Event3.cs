using EventsForDLC;
using UnityEngine;

public class Event3 : EventsSecond
{
	public override void TextOfEvents(ref string name, ref string text)
	{
		name = " 舵 手 逝 世";
		text = " 糟 糕 的 事 情 发 生 了 。9 月9 日0 时10 分 ， 在 两 次 心 脏 病 发 作 后 ， 中 国 人 民 的 伟 大 领 袖 和 导 师 ， 毛 主 席 去 世 了 ， 享 年83 岁 。 尽 管 人 民 和 党 还 在 悲 伤 中 ， 我 们 需 要 召 集 治 丧 委 员 会 ， 决 定 如 何 送 主 席 最 后 一 程 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 3;
		button_text[0] = " 按 照 伟 大 领 袖 的 既 定 方 针 办 ， 并 为 主 席 修 建 一 座 纪 念 碑";
		button_text[1] = " 将 毛 主 席 安 葬 在 天 安 门 广 场 的 待 建 纪 念 堂 内 ";
		button_text[2] = " 让 治 丧 委 员 会 决 定";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 舵 手 逝 世";
		bool num = result_num == 0;
		GlobalScript.inst.gameState.data[38] = 100;
		GlobalScript.inst.gameState.politics[0].name_1 = 1;
		GlobalScript.inst.gameState.politics[0].name_2 = 41;
		GlobalScript.inst.gameState.politics[0].age = 35;
		GlobalScript.inst.gameState.politics[0].traits[0] = 0;
		GlobalScript.inst.gameState.politics[0].traits[1] = 4;
		GlobalScript.inst.gameState.politics[0].traits[2] = 14;
		GlobalScript.inst.gameState.politics_dolshnost[1] = 150;
		if (num)
		{
			text = " 在 毛 主 席 的 死 讯 公 布 后 ， 他 的 遗 体 在 人 民 大 会 堂 留 置 一 周 ， 以 便 全 国 人 民 向 主 席 道 别 ， 追 悼 会 在 全 国 范 围 内 举 行 。 无 数 中 国 人 来 到 这 里 向 伟 大 领 袖 与 导 师 致 以 最 后 的 敬 意 。 毛 主 席 的 遗 体 根 据 他 的 遗 愿 被 火 化 ， 遗 骨 在 三 分 钟 的 肃 立 哀 悼 和 华 国 锋 同 志 的 告 别 演 说 后 被 封 入 了 天 安 门 广 场 上 一 座 特 别 建 造 的 纪 念 碑 里 。";
			GlobalScript.inst.gameState.data[4] -= 50;
			GlobalScript.inst.gameState.data[3] += 20;
			GlobalScript.inst.gameState.politics[4].loyality -= 400;
			GlobalScript.inst.gameState.politics[1].loyality -= 400;
			GlobalScript.inst.gameState.politics[2].loyality -= 400;
			GlobalScript.inst.gameState.politics[3].loyality -= 400;
			return;
		}
		switch (result_num)
		{
		case 1:
			text = " 在 毛 主 席 的 死 讯 公 布 后 ， 他 的 遗 体 在 人 民 大 会 堂 留 置 一 周 ， 以 便 全 国 人 民 向 主 席 道 别 ， 追 悼 会 在 全 国 范 围 内 举 行 。 无 数 中 国 人 来 到 这 里 向 伟 大 领 袖 与 导 师 致 以 最 后 的 敬 意 。 在 时 限 后 ， 遗 体 被 送 往 医 院 ， 进 行 特 别 防 腐 处 理 。 在 三 分 钟 的 肃 立 默 哀 与 华 国 锋 的 告 别 演 说 后 ， 毛 主 席 正 式 安 息 在 了 天 安 门 前 ， 由 治 丧 委 员 会 特 别 要 求 建 设 的 纪 念 堂 里 。";
			GlobalScript.inst.gameState.data[4] -= 70;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[1] += 40;
			GlobalScript.inst.gameState.data[8] -= 10;
			GlobalScript.inst.gameState.politics[4].loyality -= 300;
			GlobalScript.inst.gameState.politics[1].loyality -= 300;
			GlobalScript.inst.gameState.politics[2].loyality -= 300;
			GlobalScript.inst.gameState.politics[3].loyality -= 300;
			GlobalScript.inst.gameState.data[104] = 10;
			break;
		case 2:
			text = " 华 国 锋 决 定 不 直 接 出 面 组 织 毛 主 席 的 葬 礼 ， 这 件 事 没 有 被 人 忽 视 。 在 毛 主 席 的 死 讯 公 布 后 ， 他 的 遗 体 在 人 民 大 会 堂 留 置 一 周 ， 以 便 全 国 人 民 向 主 席 道 别 ， 追 悼 会 在 全 国 范 围 内 举 行 。 无 数 中 国 人 来 到 这 里 向 伟 大 领 袖 与 导 师 致 以 最 后 的 敬 意 。 在 时 限 后 ， 遗 体 被 送 往 医 院 ， 进 行 特 别 防 腐 处 理 。 在 三 分 钟 的 肃 立 默 哀 与 华 国 锋 的 告 别 演 说 后 ， 毛 主 席 正 式 安 息 在 了 天 安 门 前 ， 由 治 丧 委 员 会 特 别 要 求 建 设 的 纪 念 堂 里 。";
			GlobalScript.inst.gameState.data[4] -= 70;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[1] -= 40;
			GlobalScript.inst.gameState.politics[4].loyality -= 500;
			GlobalScript.inst.gameState.politics[1].loyality -= 500;
			GlobalScript.inst.gameState.politics[2].loyality -= 500;
			GlobalScript.inst.gameState.politics[3].loyality -= 500;
			GlobalScript.inst.gameState.data[104] = 10;
			break;
		}
	}
}
