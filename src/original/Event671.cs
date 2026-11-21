using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event671 : EventsSecond
{
	private GameState a;

	private int summa_3_2;

	public float[] party_change = new float[5];

	public GameObject achieves;

	public bool load_scene_after_click;

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
		name = " 朋 友 来 了 有 美 酒";
		text = " 主 席 同 志 ， 好 消 息 ！ 随 着 我 们 的 经 济 联 盟 进 一 步 扩 张 ， 欧 洲 阶 级 兄 弟 们 愿 意 同 我 们 在 多 个 部 门 展 开 联 合 合 作 。 目 前 本 项 项 目 暂 且 定 名 为 “823 计 划 ” ， 其 中 的 一 些 分 支 如 下 。 法 国 同 志 愿 意 在 核 电 技 术 等 方 面 同 我 国 展 开 密 切 合 作 。 如 您 所 知 晓 的 那 样 ， 法 国 拥 有 全 欧 洲 最 为 先 进 的 核 电 站 技 术 ， 和 他 们 的 合 作 能 进 一 步 推 动 我 国 对 外 国 资 源 的 依 赖 ， 并 能 为 我 们 国 家 的 城 市 居 民 提 供 便 宜 高 效 的 电 能 。 而 德 国 同 志 主 动 提 出 帮 助 我 国 军 工 产 业 进 一 步 现 代 化 ， 前 些 日 子 被 公 有 化 的 戴 姆 勒 奔 驰 公 司 过 去 是 该 国 最 大 的 军 事 工 程 复 合 体 ， 和 德 国 展 开 合 作 将 能 进 一 步 现 代 化 我 国 的 军 事 产 业 。 或 者 ， 我 们 可 以 进 一 步 扩 大 我 们 和 欧 洲 国 家 的 经 济 往 来 。 这 样 将 有 利 于 我 国 的 经 济 发 展 ， 更 多 的 财 政 盈 余 也 有 利 于 我 们 的 投 资 。";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		if (a.science[12] && a.data[12] >= 800 && a.allcountries[21].prcinfl == 0)
		{
			button_text[0] = "和 法 国 同 志 展 开 合 作";
		}
		else if (a.allcountries[21].prcinfl != 0)
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 已 经 和 法 国 合 作";
		}
		else
		{
			Object.Destroy(button[0]);
			button_text[0] = " 我 们 的 工 业 还 不 支 持 更 深 的 合 作 ！";
		}
		if ((a.allcountries[16].parts[0] || a.allcountries[17].parts[0]) && a.allcountries[16].prcinfl == 0)
		{
			button_text[1] = "和 德 国 同 志 展 开 合 作";
		}
		else if (a.allcountries[16].prcinfl != 0)
		{
			Object.Destroy(button[1]);
			button_text[1] = " 我 们 已 和 德 国 合 作";
		}
		else
		{
			Object.Destroy(button[1]);
			button_text[1] = " 德 国 尚 未 统 一 … …";
		}
		if (a.allcountries[0].prcinfl == 0)
		{
			button_text[2] = "扩 大 我 们 和 欧 洲 国 家 的 贸 易 额";
		}
		else
		{
			Object.Destroy(button[2]);
			button_text[2] = " 我 们 已 经 扩 大 了 合 作";
		}
		button_text[3] = "暂 时 什 么 都 不 做";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 朋 友 来 了 有 美 酒";
		switch (result_num)
		{
		case 0:
			text = $"中 国 政 府 决 定 签 署 《 核 能 合 作 与 电 子 产 业 协 同 发 展 框 架 协 议 》 ， 宣 布 共 同 启 动 新 一 代 核 电 站 建 设 项 目 ， 并 加 强 在 电 子 信 息 技 术 领 域 的 深 度 合 作 。 {GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1]}{GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]} 同 志 在 广 州 白 云 会 所 亲 切 接 见 了 法 国 领 导 人 和 随 行 代 表 ， 双 方 就 工 业 合 作 达 成 了 一 揽 子 协 议 ， 其 中 还 包 括 了 在 秦 山 和 大 亚 湾 建 设 两 组 欧 洲 标 准 的 核 电 站 。 项 目 将 聚 焦 安 全 性 提 升 、 核 废 料 处 理 及 智 能 化 运 维 ， 打 造 全 球 核 电 技 术 合 作 标 杆 。 中 国 国 家 能 源 局 负 责 人 表 示 ， 法 国 在 核 能 领 域 的 技 术 的 陷 阱 经 验 将 加 速 实 现 “ 双 碳 ” 目 标 ， 为 全 球 提 供 稳 ， 低 碳 的 能 源 解 决 方 案 。 这 还 会 为 我 国 提 供 更 多 的 就 业 岗 位 以 及 更 为 便 宜 的 电 力 。||合 作 不 仅 限 于 能 源 领 域 。 中 国 科 技 大 学 和 法 国 巴 黎 高 等 师 范 学 院 以 民 间 团 体 的 身 份 决 定 建 立 “ 中 法 数 字 创 新 实 验 室 ” ， 在 半 导 体 材 料 ， 自 动 化 工 业 及 新 一 代 芯 片 等 关 键 领 域 展 开 联 合 攻 关 。 法 国 驻 华 大 使 指 出 ： “ 中 国 电 子 产 业 的 蓬 勃 生 态 与 法 国 在 高 端 制 造 ， 基 础 研 究 上 的 优 势 深 度 融 合 ， 将 重 塑 这 一 产 业 的 国 际 格 局 。 而 新 型 的 跨 国 合 作 更 能 彰 显 友 好 国 家 间 的 友 谊 ， 进 一 步 促 进 马 克 思 先 生 理 想 中 没 有 国 界 的 世 界 ”。||这 将 会 带 来 丰 厚 的 回 报 ， 我 们 只 消 等 待 … …";
			a.data[8] -= 150;
			a.allcountries[21].prcinfl = 1;
			break;
		case 1:
			text = string.Format("近 日 ， 中 国 与 德 国 新 一 任 领 导 层 正 式 签 署 《 军 事 工 业 技 术 合 作 与 联 合 研 发 框 架 协 议 》 ， 双 方 宣 布 在 装 备 现 代 化 ， 技 术 创 新 及 人 员 培 训 等 领 域 展 开 全 方 位 协 作 。 {0}{1} 同 志 在 广 州 白 云 会 所 亲 切 接 见 了 德 国 领 导 人 和 随 行 代 表 ， 双 方 就 工 业 合 作 达 成 了 一 揽 子 协 议 。 这 一 合 作 标 志 着 两 国 在 推 动 防 御 性 国 防 能 力 建 设 方 面 迈 出 重 要 步 伐 ， 彰 显 了 社 会 主 义 国 家 间 互 信 互 助 的 深 厚 情 谊 。||根 据 协 议 ， 中 德 将 聚 焦 陆 军 主 战 装 备 升 级 和 防 空 系 统 智 能 化 ， 共 同 开 发 新 一 代 机 械 化 部 队 及 模 块 化 防 空 导 弹 平 台 。 德 方 在 机 械 精 密 制 造 ， 装 甲 材 料 工 艺 上 的 优 势 能 弥 补 ， 打 造 适 应 现 代 防 御 需 求 的 “ 高 性 价 比 ” 装 备 体 系 。 军 事 委 员 会 代 表 表 示 ， 此 次 合 作 遵 循 “ 非 攻 性 ， 非 排 他 ” 原 则 ， 旨 在 通 过 技 术 互 通 提 升 两 国 自 主 防 卫 能 力 ， 为 全 球 安 全 治 理 提 供 新 范 式 。 德 国 的 步 兵 战 车 ， 单 兵 防 空 系 统 和 野 战 防 空 车 也 将 填 补 我 国 在 此 处 的 空 白 。 进 一 步 构 建 现 代 化 的 军 事 体 系 ， 争 取 赶 上 超 级 大 国 做 准 备 。||合 作 不 仅 限 于 装 备 制 造 ， 双 方 将 共 建 “ 中 德 军 事 技 术 联 合 学 院 ” ， 围 绕 未 来 的 电 子 对 抗 系 统 ， 无 人 作 战 平 台 ， 电 子 化 指 挥 与 战 术 分 析 系 统 等 前 沿 领 域 开 展 联 合 攻 关 ， 并 互 派 技 术 骨 干 参 与 研 发 项 目 。 德 国 国 防 工 业 部 负 责 人 指 出 ： “ 中 国 在 国 防 科 技 产 业 化 方 面 的 经 验 ， 为 提 升 装 备 实 战 效 能 提 供 了 宝 贵 借 鉴 。 ” 从 实 验 室 到 生 产 线 ， 中 德 军 事 工 业 合 作 始 终 秉 持 “ 平 等 协 商 、 共 同 进 步 ” 理 念 。 这 一 合 作 理 念 正 是 反 对 美 帝 国 主 义 和 苏 联 社 会 帝 国 主 义 集 团 鼓 动 世 界 大 战 的 生 动 实 践 。 正 如{0}{1}同 志 在 招 待 酒 会 上 的 发 言 那 样 ： “ 中 国 历 来 不 希 望 战 争 ， 正 因 如 此 ， 我 们 将 以 技 术 合 作 消 弭 隔 阂 ， 以 共 同 发 展 取 代 零 和 博 弈 ， 为 构 建 均 衡 ， 有 效 ， 可 持 续 的 国 际 安 全 架 构 注 入 正 能 量 。 中 德 两 国 正 以 务 实 行 动 诠 释 “ 止 戈 为 武 ” 的 东 方 智 慧 ， 为 世 界 和 平 与 发 展 贡 献 社 会 主 义 国 家 的 战 略 担 当 。 ”||中 德 友 谊 万 岁 ！ 没 有 常 备 军 的 世 界 万 岁 ！", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.data[8] -= 300;
			a.data[12] -= 400;
			a.allcountries[16].prcinfl = 1;
			break;
		case 2:
			text = $" 我 们 决 定 进 一 步 扩 大 我 国 和 欧 洲 国 家 的 跨 国 贸 易 ， 这 将 会 为 我 们 带 来 额 外 的 外 汇 收 入 ， 并 在 一 定 程 度 上 补 齐 我 国 内 部 的 不 足 。 近 日 ， 中 国 与 德 国 ， 法 国 ， 意 大 利 等 欧 洲 主 要 国 家 联 合 发 布 《 深 化 经 济 合 作 联 合 声 明 》 ， 根 据 声 明 ， 中 方 将 扩 大 精 密 机 床 ， 光 刻 机 等 高 附 加 值 产 品 对 欧 出 口 ， 同 时 新 增15 类 欧 洲 优 质 农 产 品 、 医 疗 器 械 和 精 密 仪 器 进 口 零 关 税 清 单 。 英 国 贸 易 代 表 表 示 ： “ 中 国 与 欧 洲 技 术 产 业 的 互 补 性 ， 正 转 化 为 实 实 在 在 的 增 长 动 能 。 这 真 的 让 小 伙 子 们 都 提 起 干 劲 了 ， 我 们 的 工 厂 又 一 次 充 满 了 订 单 。 ”||正 如 {GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1]}{GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]} 同 志 在 招 待 酒 会 所 言 ： “ 中 欧 不 仅 仅 是 意 识 形 态 盟 友 ， 也 是 发 展 伙 伴 。 扩 大 贸 易 非 但 不 会 稀 释 彼 此 特 色 ， 反 而 能 以 差 异 化 竞 争 锻 造 更 高 水 平 合 作 。 ” 从 亚 得 里 亚 海 畔 的 风 机 到 上 海 的 高 精 度 机 床 ， 中 欧 正 以 行 动 证 明 ： 开 放 包 容 的 经 贸 纽 带 ， 最 终 会 为 一 个 没 有 剥 削 的 共 同 发 展 的 世 界 开 辟 新 航 向 。";
			a.data[8] -= 150;
			a.allcountries[0].prcinfl = 12;
			break;
		case 3:
			text = string.Format(" 又 是 平 静 的 一 天 。", GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1], GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2]);
			a.event_done[671] = false;
			break;
		}
		if (result_num == 5)
		{
			text = "";
		}
		GlobalScript.inst.old_modify_desc[8] = " 与 美 国 关 系+0.2 ， 与 苏 联 关 系+0.2 ，| 思 想 自 由 化-1";
		if (GlobalScript.inst.gameState.allcountries[16].prcinfl != 0)
		{
			GlobalScript.inst.old_modify_desc[8] += "<color=red>| 现 代 化 的 机 械 陆 军 ：</color>| 军 力+0.5 ， 特 工 网 络 + 0.3 ， 干 涉 点 数 +1.0 ， 预 算-0.8 ， 科 技 点 数-0.2 ， 人 民 支 持 度+1.0";
		}
		if (GlobalScript.inst.gameState.allcountries[21].prcinfl != 0)
		{
			GlobalScript.inst.old_modify_desc[8] += "<color=red>| 与 法 国 的 电 子 工 业 合 作 ：</color>|预 算-0.3 ， 科 技 点 数+0.4 ， 人 民 支 持 度+0.5 ， 工 业+0.3";
		}
		if (GlobalScript.inst.gameState.allcountries[0].prcinfl != 0)
		{
			GlobalScript.inst.old_modify_desc[8] += "<color=red>| 加 深 与 欧 洲 国 家 贸 易 ：</color>| 与 欧 洲 国 家 的 贸 易 额 外 获 得 0.1 预算";
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.number_event = 456;
			SceneManager.LoadScene("Event");
		}
	}
}
