using EventsForDLC;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Event94 : EventsSecond
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
		if (GlobalScript.inst.gameState.faction_leader[4] == 200)
		{
			for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
			{
				if (GlobalScript.inst.gameState.politics[i].traits[0] == 3 && GlobalScript.inst.gameState.politics[i].power > ((GlobalScript.inst.gameState.faction_leader[4] == 200) ? (-1000000) : GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].power))
				{
					GlobalScript.inst.gameState.faction_leader[4] = i;
				}
			}
		}
		name = " 又 一 次 天 安 门 事 件 ？ ！";
		text = " 对 各 个 涉 及 人 民 生 活 领 域 的 大 规 模 改 革 政 策 、 日 益 猖 獗 的 腐 败 、 中 国 共 产 党 与 商 界 的 勾 结 以 及 权 贵 与 商 人 之 间 秘 密 的 腐 败 联 系 ， 导 致 资 产 阶 级 自 由 化 思 想 在 相 当 一 部 分 的 中 国 知 识 分 子 和 青 年 中 广 泛 传 播 ， 他 们 要 求 更 激 进 的 改 革 ， 反 对 “ 共 产 主 义 传 染 病 ” 。 因 此 他 们 组 织 了 一 场 由 持 不 同 政 见 的 天 体 物 理 学 家 方 励 之 （ 在 西 方 被 称 为 “ 中 国 的 萨 哈 罗 夫 ” ） 所 领 导 的 “ 退 党 ” 运 动 ， 运 动 的 主 张 是 宣 布 中 国 共 产 党 为 “ 犯 罪 组 织 ” ， 并 剥 夺 党 的 一 切 权 力 、 要 求 国 家 的 自 由 化 和 西 方 化 、 打 击 腐 败 和 消 灭 官 僚 的 特 权 。 利 用 了 政 府 内 部 的 混 乱 ， 十 万 “ 退 党 ” 支 持 者 聚 集 在 北 京 天 安 门 广 场 举 行 群 众 活 动 。 他 们 要 求 “ 自 由 ” 、 “ 民 主 ” 、 “ 打 击 腐 败 官 僚 ” 和 “ 打 倒 腐 败 的 党 的 领 导 ” ， 而 其 他 包 括 工 人 在 内 的 对 我 们 的 改 革 不 满 的 人 ， 每 天 都 在 加 入 他 们 的 行 列 。 中 国 共 产 党 党 内 的 自 由 派 领 导 人" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2] + " ， 倾 向 于 对 抗 议 者 妥 协 让 步 ， 希 望 通 过 抗 议 活 动 执 掌 党 政 大 权 。 国 内 局 势 极 不 稳 定 ， 但 现 在 仍 有 机 会 进 行 干 预 — — 在 动 乱 蔓 延 到 其 他 城 市 之 前...";
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		kolvo_variant = 4;
		button_text[0] = " 这 是 一 场 反 革 命 动 乱 ， 叛 徒 会 为 此 负 责 的 ！ 给 我 拨 通 总 参 谋 部 的 电 话 …";
		button_text[1] = " 让 武 警 封 锁 广 场 ， 尝 试 劝 说 抗 议 者 散 去";
		button_text[2] = " 退 休 。 在 这 个 困 难 时 期 ， 让 党 决 定 谁 应 该 领 导 国 家";
		button_text[3] = " 满 足 抗 议 者 的 要 求";
		button_text[5] = "";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		name = " 又 一 次 天 安 门 事 件 ？ ！";
		switch (result_num)
		{
		case 0:
			text = " 在 中 共 中 央 特 别 全 会 上 ， 事 件 被 称 为 “ 受 美 国 和 台 湾 特 务 机 关 指 使 的 反 革 命 叛 乱 ” ， 随 后 对 运 动 进 行 镇 压 的 投 票 以 大 多 数 通 过 。 根 据 中 国 人 民 解 放 军 总 参 谋 长 杨 得 志 将 军 的 命 令 ， 部 队 在 北 京 得 到 了 坦 克 和 装 甲 运 兵 车 的 增 援 ， 但 当 他 们 向 广 场 推 进 时 被 路 障 所 阻 拦 以 及 遭 遇 到 了 手 持 燃 烧 弹 的 歹 徒 的 顽 强 抵 抗 。 在 装 甲 部 队 的 支 援 下 ， 路 障 被 摧 毁 ， 之 后 解 放 军 摧 毁 了 抗 议 者 的 大 本 营 ， 并 对 天 安 门 广 场 进 行 了 清 理 ， 对 工 人 和 学 生 宿 舍 的 清 理 工 作 持 续 了 几 天 。 也 因 此 ， 局 势 得 到 了 控 制 。 “ 退 党 ” 运 动 被 宣 布 为 非 法 组 织 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2] + " 和 他 的 支 持 者 被 免 除 其 职 位 ， 开 除 出 中 国 共 产 党 ， 改 革 开 放 的 反 对 者 开 始 被 逮 捕 ， 方 励 之 逃 到 美 国 。 西 方 国 家 指 责 我 们 的 政 权 为 “ 血 腥 的 暴 政 ” ， 苏 联 及 其 盟 国 保 持 沉 默 。 有 组 织 的 抗 议 运 动 被 镇 压 ， 不 满 者 转 入 地 下 。";
			GlobalScript.inst.gameState.empires[0].relations -= 150;
			GlobalScript.inst.gameState.data[57] -= 150;
			GlobalScript.inst.gameState.data[3] -= 100;
			GlobalScript.inst.gameState.data[4] -= 250;
			GlobalScript.inst.gameState.data[6] += 80;
			break;
		case 1:
		{
			if (GlobalScript.inst.gameState.data[3] >= 600 && GlobalScript.inst.gameState.data[4] < 500)
			{
				text = " 由 于 害 怕 抢 劫 事 件 发 生 ， 北 京 市 市 长 下 令 引 入 人 民 武 装 警 察 的 装 甲 部 队 ， 用 警 戒 线 封 锁 天 安 门 广 场 ， 将 抗 议 者 从 邻 近 的 街 道 赶 走 （ 同 时 遭 受 了 “ 莫 洛 托 夫 鸡 尾 酒 ” 燃 烧 瓶 袭 击 ， 造 成 严 重 损 失 ） 此 后 ， 主 席 同 志 亲 自 对 示 威 者 讲 话 ， 劝 说 他 们 散 去 。 其 中 很 大 一 部 分 人 离 开 了 广 场 ， 其 余 的 人 被 警 察 用 催 泪 瓦 斯 和 空 包 弹 驱 散 。 首 都 的 秩 序 恢 复 了 ， 但 骚 乱 蔓 延 到 上 海 、 宁 波 和 其 他 几 个 城 市 … …";
				GlobalScript.inst.gameState.data[4] += 250;
				GlobalScript.inst.gameState.data[3] -= 100;
				GlobalScript.inst.gameState.data[57] -= 250;
				break;
			}
			text = " 由 于 害 怕 抢 劫 事 件 发 生 ， 北 京 市 市 长 下 令 引 入 人 民 武 装 警 察 的 装 甲 部 队 ， 封 锁 了 天 安 门 广 场 ， 将 抗 议 者 赶 出 了 广 场 及 邻 近 的 街 道 （ 同 时 遭 到 了 “ 莫 洛 托 夫 鸡 尾 酒 ” 的 袭 击 ， 造 成 重 大 损 失 ） 。 人 们 用 嘘 声 和 辱 骂 迎 接 主 席 的 到 来 ， 他 仓 皇 而 逃 。 在 中 共 中 央 特 别 全 会 上 ， 中 央 决 定 向 示 威 者 做 出 让 步 ， 并 要 求 党 的 领 导 层 辞 职 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2] + " 同 志 成 为 新 的 总 书 记 ， 他 宣 布 了 深 化 改 革 和 国 家 大 规 模 民 主 化 的 政 策 。 对 此 感 到 满 意 的 大 多 数 抗 议 者 都 散 去 了 ， 其 余 的 人 被 武 警 赶 走 了 。 中 国 正 在 等 待 变 革 …";
			GlobalScript.inst.gameState.data[3] += 90;
			GlobalScript.inst.gameState.data[6] -= 50;
			GlobalScript.inst.gameState.data[57] -= 350;
			GlobalScript.inst.gameState.data[107] = 1;
			GlobalScript.inst.gameState.data[4] += 100;
			int[] array4 = new int[16]
			{
				GlobalScript.inst.gameState.leader.name_1,
				GlobalScript.inst.gameState.leader.name_2,
				GlobalScript.inst.gameState.leader.traits[0],
				GlobalScript.inst.gameState.leader.traits[1],
				GlobalScript.inst.gameState.leader.traits[2],
				GlobalScript.inst.gameState.leader.age,
				GlobalScript.inst.gameState.leader.face_type,
				GlobalScript.inst.gameState.leader.face_parts[0],
				GlobalScript.inst.gameState.leader.face_parts[1],
				GlobalScript.inst.gameState.leader.face_parts[2],
				GlobalScript.inst.gameState.leader.face_parts[3],
				GlobalScript.inst.gameState.leader.face_parts[4],
				GlobalScript.inst.gameState.leader.face_parts[5],
				GlobalScript.inst.gameState.leader.face_parts[6],
				GlobalScript.inst.gameState.leader.face_parts[7],
				GlobalScript.inst.gameState.leader.jacket
			};
			GlobalScript.inst.gameState.leader.name_1 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1;
			GlobalScript.inst.gameState.leader.name_2 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2;
			GlobalScript.inst.gameState.leader.traits[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[0];
			GlobalScript.inst.gameState.leader.traits[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[1];
			GlobalScript.inst.gameState.leader.traits[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[2];
			GlobalScript.inst.gameState.leader.age = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].age;
			GlobalScript.inst.gameState.leader.face_type = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_type;
			GlobalScript.inst.gameState.leader.face_parts[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[0];
			GlobalScript.inst.gameState.leader.face_parts[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[1];
			GlobalScript.inst.gameState.leader.face_parts[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[2];
			GlobalScript.inst.gameState.leader.face_parts[3] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[3];
			GlobalScript.inst.gameState.leader.face_parts[4] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[4];
			GlobalScript.inst.gameState.leader.face_parts[5] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[5];
			GlobalScript.inst.gameState.leader.face_parts[6] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[6];
			GlobalScript.inst.gameState.leader.face_parts[7] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[7];
			GlobalScript.inst.gameState.leader.jacket = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].jacket;
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1 = array4[0];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2 = array4[1];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[0] = (byte)array4[2];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[1] = (byte)array4[3];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[2] = (byte)array4[4];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].age = (byte)array4[5];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_type = (byte)array4[6];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[0] = (byte)array4[7];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[1] = (byte)array4[8];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[2] = (byte)array4[9];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[3] = (byte)array4[10];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[4] = (byte)array4[11];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[5] = (byte)array4[12];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[6] = (byte)array4[13];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[7] = (byte)array4[14];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].jacket = (byte)array4[15];
			int[] array5 = new int[8];
			for (int k = 0; k < GlobalScript.inst.gameState.politics_dolshnost.Length; k++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[k] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[k] = (byte)GlobalScript.inst.gameState.faction_leader[4];
				}
				else if (GlobalScript.inst.gameState.politics_dolshnost[k] == (byte)GlobalScript.inst.gameState.faction_leader[4])
				{
					array5[k] = 150;
				}
			}
			for (int l = 0; l < array5.Length; l++)
			{
				if (array5[l] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[l] = 150;
				}
			}
			break;
		}
		case 2:
		{
			text = " 在 中 共 中 央 特 别 全 会 上 ， 爆 发 了 激 烈 的 争 论 — — 保 守 派 要 求 使 用 武 力 镇 压 （ 尤 其 是 王 震 对 此 直 言 不 讳 ） ， 自 由 派 想 要 做 出 让 步 ， 改 革 派 则 举 棋 不 定 。 最 终 ， 自 由 派 胜 利 了 — — 中 共 领 导 层 集 体 辞 职 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1] + " " + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2] + " 同 志 成 为 新 的 总 书 记 ， 他 宣 布 了 深 化 改 革 和 国 家 大 规 模 民 主 化 的 政 策 。 对 此 感 到 满 意 的 大 多 数 抗 议 者 都 散 去 了 ， 其 余 的 人 被 武 警 赶 走 了 。 中 国 正 在 等 待 变 革 …";
			GlobalScript.inst.gameState.data[3] += 90;
			GlobalScript.inst.gameState.data[6] -= 50;
			GlobalScript.inst.gameState.data[57] -= 350;
			GlobalScript.inst.gameState.data[107] = 1;
			GlobalScript.inst.gameState.data[4] += 100;
			int[] array2 = new int[16]
			{
				GlobalScript.inst.gameState.leader.name_1,
				GlobalScript.inst.gameState.leader.name_2,
				GlobalScript.inst.gameState.leader.traits[0],
				GlobalScript.inst.gameState.leader.traits[1],
				GlobalScript.inst.gameState.leader.traits[2],
				GlobalScript.inst.gameState.leader.age,
				GlobalScript.inst.gameState.leader.face_type,
				GlobalScript.inst.gameState.leader.face_parts[0],
				GlobalScript.inst.gameState.leader.face_parts[1],
				GlobalScript.inst.gameState.leader.face_parts[2],
				GlobalScript.inst.gameState.leader.face_parts[3],
				GlobalScript.inst.gameState.leader.face_parts[4],
				GlobalScript.inst.gameState.leader.face_parts[5],
				GlobalScript.inst.gameState.leader.face_parts[6],
				GlobalScript.inst.gameState.leader.face_parts[7],
				GlobalScript.inst.gameState.leader.jacket
			};
			GlobalScript.inst.gameState.leader.name_1 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1;
			GlobalScript.inst.gameState.leader.name_2 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2;
			GlobalScript.inst.gameState.leader.traits[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[0];
			GlobalScript.inst.gameState.leader.traits[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[1];
			GlobalScript.inst.gameState.leader.traits[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[2];
			GlobalScript.inst.gameState.leader.age = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].age;
			GlobalScript.inst.gameState.leader.face_type = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_type;
			GlobalScript.inst.gameState.leader.face_parts[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[0];
			GlobalScript.inst.gameState.leader.face_parts[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[1];
			GlobalScript.inst.gameState.leader.face_parts[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[2];
			GlobalScript.inst.gameState.leader.face_parts[3] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[3];
			GlobalScript.inst.gameState.leader.face_parts[4] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[4];
			GlobalScript.inst.gameState.leader.face_parts[5] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[5];
			GlobalScript.inst.gameState.leader.face_parts[6] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[6];
			GlobalScript.inst.gameState.leader.face_parts[7] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[7];
			GlobalScript.inst.gameState.leader.jacket = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].jacket;
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1 = array2[0];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2 = array2[1];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[0] = (byte)array2[2];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[1] = (byte)array2[3];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[2] = (byte)array2[4];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].age = (byte)array2[5];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_type = (byte)array2[6];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[0] = (byte)array2[7];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[1] = (byte)array2[8];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[2] = (byte)array2[9];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[3] = (byte)array2[10];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[4] = (byte)array2[11];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[5] = (byte)array2[12];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[6] = (byte)array2[13];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[7] = (byte)array2[14];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].jacket = (byte)array2[15];
			int[] array3 = new int[8];
			for (int i = 0; i < GlobalScript.inst.gameState.politics_dolshnost.Length; i++)
			{
				if (GlobalScript.inst.gameState.politics_dolshnost[i] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[i] = (byte)GlobalScript.inst.gameState.faction_leader[4];
				}
				else if (GlobalScript.inst.gameState.politics_dolshnost[i] == (byte)GlobalScript.inst.gameState.faction_leader[4])
				{
					array3[i] = 150;
				}
			}
			for (int j = 0; j < array3.Length; j++)
			{
				if (array3[j] == 150)
				{
					GlobalScript.inst.gameState.politics_dolshnost[j] = 150;
				}
			}
			break;
		}
		case 3:
		{
			text = string.Concat(new string[4]
			{
				GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1],
				" ",
				GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2],
				" 同 志 成 为 新 的 总 书 记 ， 他 宣 布 了 进 一 步 深 化 改 革 和 大 规 模 民 主 化 的 政 策 。 然 而 ， “ 退 党 ” 运 动 的 领 导 者 认 为 这 是 中 国 领 导 层 软 弱 无 能 的 证 明 ， 并 在 全 国 各 地 组 织 了 大 规 模 示 威 ， 最 终 导 致 政 府 下 台 ， 中 国 进 入 了 过 渡 时 期 。 共 产 党 失 去 了 权 力 ， 其 命 运 已 经 掌 握 在 了 他 人 手 里 … …"
			});
			GlobalScript.inst.gameState.data[4] = 1000;
			int[] array = new int[16]
			{
				GlobalScript.inst.gameState.leader.name_1,
				GlobalScript.inst.gameState.leader.name_2,
				GlobalScript.inst.gameState.leader.traits[0],
				GlobalScript.inst.gameState.leader.traits[1],
				GlobalScript.inst.gameState.leader.traits[2],
				GlobalScript.inst.gameState.leader.age,
				GlobalScript.inst.gameState.leader.face_type,
				GlobalScript.inst.gameState.leader.face_parts[0],
				GlobalScript.inst.gameState.leader.face_parts[1],
				GlobalScript.inst.gameState.leader.face_parts[2],
				GlobalScript.inst.gameState.leader.face_parts[3],
				GlobalScript.inst.gameState.leader.face_parts[4],
				GlobalScript.inst.gameState.leader.face_parts[5],
				GlobalScript.inst.gameState.leader.face_parts[6],
				GlobalScript.inst.gameState.leader.face_parts[7],
				GlobalScript.inst.gameState.leader.jacket
			};
			GlobalScript.inst.gameState.leader.name_1 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1;
			GlobalScript.inst.gameState.leader.name_2 = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2;
			GlobalScript.inst.gameState.leader.traits[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[0];
			GlobalScript.inst.gameState.leader.traits[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[1];
			GlobalScript.inst.gameState.leader.traits[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[2];
			GlobalScript.inst.gameState.leader.age = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].age;
			GlobalScript.inst.gameState.leader.face_type = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_type;
			GlobalScript.inst.gameState.leader.face_parts[0] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[0];
			GlobalScript.inst.gameState.leader.face_parts[1] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[1];
			GlobalScript.inst.gameState.leader.face_parts[2] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[2];
			GlobalScript.inst.gameState.leader.face_parts[3] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[3];
			GlobalScript.inst.gameState.leader.face_parts[4] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[4];
			GlobalScript.inst.gameState.leader.face_parts[5] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[5];
			GlobalScript.inst.gameState.leader.face_parts[6] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[6];
			GlobalScript.inst.gameState.leader.face_parts[7] = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[7];
			GlobalScript.inst.gameState.leader.jacket = GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].jacket;
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1 = array[0];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2 = array[1];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[0] = (byte)array[2];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[1] = (byte)array[3];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].traits[2] = (byte)array[4];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].age = (byte)array[5];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_type = (byte)array[6];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[0] = (byte)array[7];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[1] = (byte)array[8];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[2] = (byte)array[9];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[3] = (byte)array[10];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[4] = (byte)array[11];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[5] = (byte)array[12];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[6] = (byte)array[13];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].face_parts[7] = (byte)array[14];
			GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].jacket = (byte)array[15];
			GlobalScript.inst.gameState.data[1] = 0;
			GlobalScript.inst.gameState.data[3] = 0;
			load_scene_after_click = true;
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}

	private void Update()
	{
		if (load_scene_after_click && Input.GetMouseButton(0))
		{
			GlobalScript.inst.gameState.data[35] = 1;
			SceneManager.LoadScene("Ending");
		}
	}
}
