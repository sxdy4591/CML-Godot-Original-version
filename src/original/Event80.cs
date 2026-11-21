using EventsForDLC;
using UnityEngine;

public class Event80 : EventsSecond
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
		if (a.modifies[3].active)
		{
			name = " 团 结 的 大 会 ？ 胜 利 的 大 会 ？";
			text = " 按 照 惯 例 ， 第 十 二 届 中 国 共 产 党 全 国 代 表 大 会 在 首 都 人 民 大 会 堂 如 期 召 开 ， 代 表 我 国 社 会 各 界 的 一 千 多 名 代 表 将 齐 聚 会 堂 ， 共 同 商 定 影 响 我 国 历 史 进 程 的 重 要 决 议 。 这 是 自 毛 主 席 去 世 以 后 ， 我 国 人 民 坚 定 走 主 席 革 命 路 线 的 第 六 个 年 头 。 在 会 堂 的 发 言 台 前 ， 祖 国 又 将 面 对 命 运 的 十 字 路 口 。||在 过 去 的 六 年 里 ， 极 左 派 与 保 守 派 虽 曾 结 成 亲 密 的 同 盟 ， 一 同 粉 碎 了 改 革 派 军 事 阴 谋 集 团 的 政 变 企 图 ， 但 在 之 后 的 相 处 中 ， 两 派 面 对 内 外 局 势 与 政 策 制 定 的 看 法 日 趋 分 裂 ， 日 常 会 议 时 两 派 的 冲 突 逐 渐 频 繁 ， 极 左 派 激 烈 的 指 责 保 守 派 面 对 革 命 高 潮 时 的 懦 弱 ， 保 守 派 则 以 稳 定 为 名 不 断 的 为 极 左 派 的 激 进 政 策 添 堵 … … 党 内 存 在 路 线 分 歧 的 暗 示 性 信 息 已 经 出 现 在 了 部 分 报 纸 与 宣 传 媒 体 上 ， “ 二 帝 共 治 ” 的 局 面 显 然 已 无 法 维 持 。 如 今 虽 然 华 国 锋 仍 占 据 着 中 国 头 面 领 袖 的 身 份 ， 但 曾 经 略 显 弱 小 的 极 左 派 经 过 六 年 的 发 展 在 党 政 军 各 界 都 积 累 了 强 大 的 力 量 ， 代 表 他 们 意 志 的 王 洪 文 副 主 席 在 行 事 风 格 上 日 渐 独 立 ， 他 在 一 些 场 合 上 与 华 国 锋 中 央 舆 论 风 口 明 显 不 合 的 发 言 无 一 不 显 示 出 极 左 派 已 经 有 了 挑 战 华 国 锋 领 袖 权 威 的 能 力 。||无 论 曾 经 有 过 多 么 亲 密 的 合 作 ， 代 表 两 条 不 同 路 线 的 旗 帜 终 究 无 法 共 同 升 起 ， 可 历 史 的 车 轮 终 将 前 进 ， 在 巨 大 的 毛 主 席 挂 像 的 注 视 下 ， 毛 泽 东 的 门 徒 们 将 在 发 言 台 前 结 束 最 后 的 争 斗 …";
		}
		else
		{
			name = " 中 共 十 二 大";
			text = " 不 论 如 何 ， 我 党 十 一 届 六 次 全 会 的 决 定 都 已 通 过 官 方 表 态 的 方 式 对 过 往 的 各 种 问 题 “ 揭 了 盖 子 ” ， 那 么 接 下 来 的 行 动 不 过 是 在 不 同 程 度 上 确 认 我 们 的 “ 修 正 ” 态 度 而 已 ： 中 国 共 产 党 第 十 二 届 全 国 代 表 大 会 即 将 在 北 京 的 人 民 大 会 堂 隆 重 召 开 ， 期 间 出 席 正 式 代 表1545 人 ， 候 补 代 表149 人 。 代 表 全 国3965 万 多 名 党 员 。 考 虑 到 其 设 计 的 常 规 议 程 平 平 无 奇 ， 这 正 是 我 党 领 导 核 心 向 全 国 公 开 自 身 政 治 立 场 ， 并 落 实 自 身 政 治 新 方 案 的 大 好 时 机 。 如 果 我 们 想 的 话 ， 本 次 会 议 当 然 可 以 作 为 清 算 往 日 领 导 人 毛 泽 东 与 其 政 治 资 产 的 极 佳 舞 台 ： 苏 联 前 领 导 人 尼 基 塔 · 赫 鲁 晓 夫 就 是 以 类 似 的 方 式 痛 击 了 国 内 的 斯 大 林 主 义 政 治 势 力 ， 并 坚 决 地 启 动 了 社 会 解 冻 与 经 济 改 革 计 划 。 当 然 ， 如 此 激 烈 的 割 舍 必 然 在 全 党 全 国 产 生 激 烈 震 荡 ： 毕 竟 ， 各 位 老 大 家 都 干 了 不 是 吗 ？ 当 然 ， 我 们 也 可 以 选 择 相 对 迂 回 的 方 式 解 决 这 些 问 题 ： 要 么 通 过 党 内 思 想 的 “ 最 新 发 展 成 就 ” 另 起 炉 灶 ， 小 心 翼 翼 地 放 下 并 边 缘 化 毛 泽 东 思 想 ； 要 么 则 没 必 要 搭 理 上 述 问 题 ， 让 一 切 发 展 如 常 ， 并 用 未 来 的 政 治 实 践 告 诉 人 民 我 们 的 真 正 目 标 。 不 论 如 何 ， 决 定 权 在 您 。";
		}
	}

	public override void VariantsOfEvents(ref int kolvo_variant, ref string[] button_text, ref GameObject[] button)
	{
		if (!a.modifies[3].active)
		{
			kolvo_variant = 3;
			if ((GlobalScript.inst.gameState.data[56] < 3 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
			{
				button_text[0] = " 没 必 要 徒 增 麻 烦 ， 会 议 应 照 常 进 行";
			}
			else
			{
				Object.Destroy(button[0]);
				button_text[0] = " 如 果 我 们 不 打 算 在 会 议 期 间 讨 论 真 正 要 紧 的 问 题 ， 那 为 什 么 还 要 开 会 ？";
			}
			if ((GlobalScript.inst.gameState.data[56] > 0 && GlobalScript.inst.gameState.data[15] < 8) || GlobalScript.inst.gameState.data[15] > 7)
			{
				button_text[1] = " 我 们 将 在 “ 中 国 特 色 社 会 主 义 ” 的 旗 下 对 毛 主 席 做 扬 弃 ， 并 靠 不 争 论 的 方 式 确 立 新 思 维 的 霸 权";
			}
			else
			{
				Object.Destroy(button[1]);
				button_text[1] = " 不 争 不 行 — — 党 和 人 民 需 要 一 个 足 够 清 晰 的 表 态 ！";
			}
			if ((GlobalScript.inst.gameState.data[56] > 2 && GlobalScript.inst.gameState.data[15] < 8) || (summa_3_2 > 66 && GlobalScript.inst.gameState.data[15] > 7))
			{
				button_text[2] = " 不 破 不 立 ， 我 们 怎 么 就 不 能 摸 着 赫 鲁 晓 夫 过 河 ？";
			}
			else
			{
				Object.Destroy(button[2]);
				button_text[2] = " 你 疯 了 吗 ！ 上 一 个 中 国 版 赫 鲁 晓 夫 还 尸 骨 未 寒 呢 ？ ！";
			}
			button_text[5] = "";
			return;
		}
		int num = 0;
		if (a.allcountries[2].SubGosstroy == 0)
		{
			num += 3;
		}
		if (a.allcountries[2].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[19].SubGosstroy == 17)
		{
			num++;
		}
		if (a.allcountries[19].Gosstroy == 1 || a.allcountries[19].SubGosstroy == 0)
		{
			num += 3;
		}
		if (a.allcountries[33].Gosstroy == 1 || a.allcountries[33].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[11].Gosstroy == 1 || a.allcountries[11].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[22].Gosstroy == 1 || a.allcountries[22].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[47].Gosstroy == 1 || a.allcountries[47].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[23].Gosstroy == 1 || a.allcountries[23].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[34].Gosstroy == 1 || a.allcountries[34].SubGosstroy == 0)
		{
			num += 2;
		}
		if (a.allcountries[8].Gosstroy == 1 || a.allcountries[8].SubGosstroy == 0)
		{
			num += 2;
		}
		if (a.allcountries[86].Gosstroy == 1 || a.allcountries[86].SubGosstroy == 0)
		{
			num += 2;
		}
		if (a.allcountries[86].proprc)
		{
			num++;
		}
		if (a.allcountries[87].Gosstroy == 1 || a.allcountries[87].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[87].proprc)
		{
			num++;
		}
		if (a.allcountries[12].proprc)
		{
			num++;
		}
		if (a.allcountries[12].Gosstroy == 1 || a.allcountries[12].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[12].prosov)
		{
			num--;
		}
		if (a.allcountries[12].SubGosstroy == 17)
		{
			num++;
		}
		if (a.allcountries[44].Gosstroy == 1)
		{
			num += 3;
		}
		if (a.allcountries[12].SubGosstroy == 17)
		{
			num += 2;
		}
		if (a.allcountries[24].Gosstroy == 1 || a.allcountries[24].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[24].proprc && a.allcountries[24].parts[0])
		{
			num += 2;
		}
		if (a.allcountries[49].Gosstroy == 1 || a.allcountries[49].SubGosstroy == 0)
		{
			num++;
		}
		if (a.allcountries[85].SubGosstroy == 17 || a.allcountries[85].SubGosstroy == 0)
		{
			num += 3;
		}
		if (a.allcountries[74].Gosstroy == 1)
		{
			num += 2;
		}
		if (a.allcountries[80].SubGosstroy == 17)
		{
			num++;
		}
		if (a.allcountries[80].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[35].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[14].Gosstroy == 1)
		{
			num += 2;
		}
		if (a.allcountries[104].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[42].Gosstroy == 1)
		{
			num++;
		}
		if (a.allcountries[50].Gosstroy == 1)
		{
			num += 2;
		}
		if (a.allcountries[10].Gosstroy != 1 && a.allcountries[10].SubGosstroy != 0)
		{
			num--;
		}
		if (!a.allcountries[20].proprc)
		{
			num--;
		}
		kolvo_variant = 2;
		int num2;
		if (GlobalScript.inst.gameState.data[56] < 1 && a.data[5] >= 500 && a.influencePRC >= 500)
		{
			num2 = ((num >= 15) ? 1 : 0);
			if (num2 != 0)
			{
				button_text[0] = " 中 国 人 民 的 革 命 事 业 要 排 除 万 难 ， 从 胜 利 走 向 胜 利 ！";
				goto IL_0691;
			}
		}
		else
		{
			num2 = 0;
		}
		Object.Destroy(button[0]);
		button_text[0] = " 革 命 引 擎 缺 乏 动 力 … …";
		goto IL_0691;
		IL_0691:
		if (num2 == 0)
		{
			button_text[1] = " 党 的 团 结 是 我 国 稳 定 发 展 的 保 证 … …";
			return;
		}
		Object.Destroy(button[1]);
		button_text[1] = " 革 命 气 势 已 经 不 可 阻 挡 ！";
	}

	public override void ResultsOfEvents(ref string name, ref string text, int result_num)
	{
		if (a.modifies[3].active)
		{
			name = " 团 结 的 大 会 ？ 胜 利 的 大 会 ？";
			switch (result_num)
			{
			case 0:
			{
				text = " 如 今 国 内 外 无 产 阶 级 斗 争 的 局 势 较 毛 主 席 刚 去 世 时 已 经 有 了 空 前 的 发 展 ， 无 产 阶 级 文 化 大 革 命 进 入 新 的 高 潮 ， 全 世 界 人 民 积 极 响 应 我 国 的 号 召 ， 各 人 民 民 主 政 权 一 个 接 一 个 成 立 。 此 正 当 中 流 击 水 之 势 ， 华 国 锋 中 央 举 棋 不 定 踌 躇 不 前 的 政 策 早 已 引 起 了 革 命 群 众 的 极 大 不 满 。 在 十 二 大 会 议 上 ， 极 左 派 成 员 激 烈 的 发 表 了 对 华 国 锋 各 方 面 批 评 ， 指 责 他 无 视 革 命 群 众 诉 求 ， 对 无 产 阶 级 专 政 理 论 认 识 不 清 ， 缺 乏 无 产 阶 级 国 际 主 义 思 想 等 ； 来 自 社 会 各 界 的 群 众 代 表 也 从 这 几 年 来 遇 到 的 实 际 问 题 出 发 ， 含 沙 射 影 的 指 责 华 国 锋 执 政 不 力 … … 而 华 国 锋 本 人 面 对 大 会 上 对 他 的 大 量 指 责 ， 只 能 奉 上 几 句 苍 白 的 辩 解 和 不 断 的 清 空 他 桌 上 的 水 杯 。||而 轮 到 王 洪 文 发 表 讲 话 时 ， 几 乎 全 会 场 的 成 员 都 为 他 献 上 热 烈 的 掌 声 ， 在 讲 话 中 ， 王 洪 文 热 情 的 赞 扬 了 全 国 人 民 的 革 命 激 情 ， 并 表 示 “ 中 国 人 民 的 革 命 事 业 要 排 除 万 难 ， 从 胜 利 走 向 胜 利 。 ” ， 在 他 大 声 呐 喊 “ 伟 大 光 荣 的 中 国 人 民 万 岁 ” 时 ， 如 雷 鸣 般 的 掌 声 将 大 会 的 氛 围 带 向 高 潮 ， 就 连 华 国 锋 也 在 一 旁 不 情 愿 的 鼓 掌 ， 在 这 之 后 ， 各 式 各 样 的 口 号 响 彻 会 场 持 续 了 有 整 整 五 分 钟 ， 以 至 于 台 上 领 导 不 得 不 停 下 维 持 秩 序 。 而 在 这 些 口 号 中 ， 不 乏 有 “ 坚 决 拥 护 王 洪 文 同 志 ” 这 类 的 话 语 … …||面 对 此 景 ， 华 国 锋 深 知 自 己 败 局 已 定 ， 同 时 也 在 各 方 面 的 施 压 下 ， 华 国 锋 在 后 续 会 议 里 进 行 了 自 我 批 评 并 向 大 会 宣 布 了 自 己 的 辞 呈 ， 辞 呈 毫 不 意 外 的 以 绝 对 优 势 票 数 通 过 了 ， 这 也 意 味 着 他 将 正 式 退 出 中 国 的 政 治 舞 台 ， 而 王 洪 文 也 在 人 民 的 欢 呼 声 中 坐 上 了 第 一 把 交 椅 。||华 国 锋 最 终 在 全 党 人 员 的 陪 同 下 慢 步 走 出 大 会 堂 ， 面 对 国 内 外 媒 体 他 虽 表 示 “ 很 高 兴 中 央 能 通 过 我 的 请 求 … … 中 国 应 该 由 更 年 轻 更 有 志 向 的 人 领 导 … … ” 但 当 他 坐 上 离 开 中 南 海 的 轿 车 时 ， 人 们 仍 从 挡 风 玻 璃 外 看 到 了 他 眼 神 中 的 一 丝 落 寞 。||而 现 在 ， 中 国 将 和 世 界 一 起 向 更 美 好 的 未 来 进 发 ！";
				GlobalScript.inst.gameState.data[1] += 300;
				GlobalScript.inst.gameState.data[3] += 300;
				GlobalScript.inst.gameState.data[4] -= 100;
				GlobalScript.inst.gameState.data[6] += 100;
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
				GlobalScript.inst.gameState.leader.name_1 = GlobalScript.inst.gameState.politics[2].name_1;
				GlobalScript.inst.gameState.leader.name_2 = GlobalScript.inst.gameState.politics[2].name_2;
				GlobalScript.inst.gameState.leader.traits[0] = GlobalScript.inst.gameState.politics[2].traits[0];
				GlobalScript.inst.gameState.leader.traits[1] = GlobalScript.inst.gameState.politics[2].traits[1];
				GlobalScript.inst.gameState.leader.traits[2] = GlobalScript.inst.gameState.politics[2].traits[2];
				GlobalScript.inst.gameState.leader.age = GlobalScript.inst.gameState.politics[2].age;
				GlobalScript.inst.gameState.leader.face_type = GlobalScript.inst.gameState.politics[2].face_type;
				GlobalScript.inst.gameState.leader.face_parts[0] = GlobalScript.inst.gameState.politics[2].face_parts[0];
				GlobalScript.inst.gameState.leader.face_parts[1] = GlobalScript.inst.gameState.politics[2].face_parts[1];
				GlobalScript.inst.gameState.leader.face_parts[2] = GlobalScript.inst.gameState.politics[2].face_parts[2];
				GlobalScript.inst.gameState.leader.face_parts[3] = GlobalScript.inst.gameState.politics[2].face_parts[3];
				GlobalScript.inst.gameState.leader.face_parts[4] = GlobalScript.inst.gameState.politics[2].face_parts[4];
				GlobalScript.inst.gameState.leader.face_parts[5] = GlobalScript.inst.gameState.politics[2].face_parts[5];
				GlobalScript.inst.gameState.leader.face_parts[6] = GlobalScript.inst.gameState.politics[2].face_parts[6];
				GlobalScript.inst.gameState.leader.face_parts[7] = GlobalScript.inst.gameState.politics[2].face_parts[7];
				GlobalScript.inst.gameState.leader.jacket = GlobalScript.inst.gameState.politics[2].jacket;
				GlobalScript.inst.gameState.politics[2].name_1 = array[0];
				GlobalScript.inst.gameState.politics[2].name_2 = array[1];
				GlobalScript.inst.gameState.politics[2].traits[0] = (byte)array[2];
				GlobalScript.inst.gameState.politics[2].traits[1] = (byte)array[3];
				GlobalScript.inst.gameState.politics[2].traits[2] = (byte)array[4];
				GlobalScript.inst.gameState.politics[2].age = (byte)array[5];
				GlobalScript.inst.gameState.politics[2].face_type = (byte)array[6];
				GlobalScript.inst.gameState.politics[2].face_parts[0] = (byte)array[7];
				GlobalScript.inst.gameState.politics[2].face_parts[1] = (byte)array[8];
				GlobalScript.inst.gameState.politics[2].face_parts[2] = (byte)array[9];
				GlobalScript.inst.gameState.politics[2].face_parts[3] = (byte)array[10];
				GlobalScript.inst.gameState.politics[2].face_parts[4] = (byte)array[11];
				GlobalScript.inst.gameState.politics[2].face_parts[5] = (byte)array[12];
				GlobalScript.inst.gameState.politics[2].face_parts[6] = (byte)array[13];
				GlobalScript.inst.gameState.politics[2].face_parts[7] = (byte)array[14];
				GlobalScript.inst.gameState.politics[2].jacket = (byte)array[15];
				GlobalScript.inst.gameState.faction_leader[0] = 1;
				GlobalScript.inst.gameState.KillPerson(2);
				for (int j = 0; j < GlobalScript.inst.gameState.politics.Length; j++)
				{
					GlobalScript.inst.gameState.CalcRel(j);
					GlobalScript.inst.gameState.CalcRel2(j);
					GlobalScript.inst.gameState.CalcRelLeader(j);
				}
				GlobalScript.inst.gameState.politics[1].power += 500;
				GlobalScript.inst.gameState.politics[3].power += 500;
				GlobalScript.inst.gameState.politics[4].power += 500;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic2 in politics)
				{
					if (politic2.traits[0] == 0)
					{
						politic2.loyality += 200;
						politic2.power += 100;
					}
					if (politic2.traits[0] == 20)
					{
						politic2.loyality += 100;
						politic2.power += 80;
					}
					else if (politic2.traits[0] == 2)
					{
						politic2.loyality -= 100;
						politic2.power -= 100;
					}
					else if (politic2.traits[0] == 1)
					{
						politic2.loyality -= 100;
					}
				}
				party_change[0] = 2.5f;
				party_change[1] = 1f;
				GlobalScript.inst.gameState.party_ideology[3] -= (int)((float)GlobalScript.inst.gameState.party_ideology[3] * 0.15f);
				break;
			}
			case 1:
			{
				text = " 很 显 然 ， 这 几 年 来 极 左 派 的 所 作 所 为 并 没 有 给 整 个 国 家 带 来 一 丝 正 面 的 因 素 ， 反 而 还 使 我 们 陷 入 了 社 会 不 稳 ， 党 内 相 互 征 伐 的 混 乱 。 为 了 祖 国 的 稳 定 与 长 治 久 安 ， 是 时 候 让 极 左 分 子 夹 紧 尾 巴 做 人 了 。||在 党 的 十 二 大 会 议 期 间 ， 极 左 派 仍 与 其 他 党 员 嘴 上 官 司 不 断 ， 极 左 派 领 袖 上 台 发 言 期 间 ， 会 场 总 是 时 不 时 陷 入 混 乱 以 至 于 发 言 者 不 得 不 一 再 停 下 维 持 会 场 秩 序 。 大 会 轮 到 华 国 锋 发 言 后 ， 他 不 紧 不 慢 的 走 到 演 讲 台 前 ， 面 对 台 下 党 员 困 惑 的 眼 神 ， 华 国 锋 强 调 要 维 护 国 家 的 稳 定 并 表 示 “ 安 定 团 结 是 毛 主 席 生 前 的 指 示 ， 是 我 国 稳 定 发 展 的 保 证 。 ” 之 后 他 开 始 了 对 极 左 派 的 攻 击 ， 指 责 他 们 大 搞 宗 派 主 义 ， 无 视 党 内 民 主 ， 在 群 众 革 命 问 题 上 无 视 纪 律 等 ， 极 左 派 面 对 华 国 锋 突 然 的 指 责 显 得 不 知 所 措 ， 王 洪 文 等 极 左 代 表 只 能 尴 尬 的 默 认 ， 只 有 江 青 一 类 的 激 进 分 子 当 场 起 身 大 声 反 驳 ， 但 他 们 很 快 就 被 更 大 的 嘘 声 击 退 。 最 终 在 华 国 锋 坚 定 的 说 出 “ 伟 大 光 荣 正 确 的 中 国 共 产 党 万 岁 ！ ” 时 ， 如 雷 般 的 掌 声 将 大 会 气 氛 送 上 高 潮 ， 极 左 派 成 员 只 能 低 头 灰 溜 溜 的 走 出 会 场 ， 华 国 锋 背 靠 长 椅 ， 享 受 他 的 胜 利 时 刻 。||在 之 后 的 职 位 选 举 时 ， 虽 然 作 为 极 左 派 代 表 的 几 位 成 员 依 然 稳 握 权 力 ， 但 影 响 力 早 已 大 不 如 前 ， 同 时 还 有 大 量 的 极 左 派 成 员 在 这 次 被 踢 出 了 党 的 高 层 圈 子 ， 这 一 切 无 一 不 显 示 出 极 左 派 在 这 次 斗 争 中 的 失 败 ， 这 也 让 部 分 人 开 始 担 心 文 化 大 革 命 的 前 途 … …||如 今 ， 华 国 锋 彻 底 巩 固 了 自 己 的 中 央 领 导 核 心 地 位 ， 他 将 坚 持 毛 主 席 过 去 的 方 针 ， 把 社 会 主 义 祖 国 建 设 的 蒸 蒸 日 上 。";
				GlobalScript.inst.gameState.data[1] += 150;
				GlobalScript.inst.gameState.data[3] += 150;
				GlobalScript.inst.gameState.data[4] += 100;
				GlobalScript.inst.gameState.data[6] -= 10;
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic.traits[0] == 0)
					{
						politic.loyality -= 300;
					}
					else if (politic.traits[0] == 2)
					{
						politic.loyality += 150;
					}
					else if (politic.traits[0] == 1)
					{
						politic.loyality += 150;
					}
					else if (politic.traits[0] == 20)
					{
						politic.loyality += 150;
					}
				}
				party_change[1] = 2f;
				party_change[2] = 1f;
				party_change[3] = 1f;
				GlobalScript.inst.gameState.modifies[3].active = false;
				GlobalScript.inst.gameState.KillPerson(1);
				GlobalScript.inst.gameState.KillPerson(2);
				GlobalScript.inst.gameState.politics[3].power -= 100;
				GlobalScript.inst.gameState.politics[4].power -= 100;
				if (GlobalScript.inst.gameState.politics_dolshnost[2] < 100)
				{
					GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.politics_dolshnost[2]].loyality -= 200;
				}
				break;
			}
			}
			return;
		}
		name = " 中 共 十 二 大";
		switch (result_num)
		{
		case 0:
			text = " 中 国 共 产 党 第 十 二 届 全 国 代 表 大 会 将 以 “ 团 结 ， 胜 利 的 大 会 ” 之 名 载 入 史 册 。 一 如 彼 时 苏 联 召 开 的 联 共 （ 布 ） 第 十 八 次 代 表 大 会 那 般 。 全 党 全 军 团 结 在" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 周 围 ， 决 心 在 继 承 毛 泽 东 思 想 伟 大 旗 帜 的 基 础 上 继 往 开 来 开 创 新 事 业 。" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 在 会 议 期 间 尤 其 强 调 要 在 坚 持 社 会 主 义 主 旋 律 的 基 础 上 “ 防 左 反 右 ” ， 并 对1979 年 推 出 的 “ 四 项 基 本 原 则 ” （ 即 必 须 坚 持 社 会 主 义 道 路 ； 必 须 坚 持 无 产 阶 级 专 政 ； 必 须 坚 持 中 国 共 产 党 的 领 导 与 必 须 坚 持 马 列 主 义 、 毛 泽 东 思 想 ） 故 事 重 提 。 接 下 来 则 是 适 当 调 整 《 中 国 共 产 党 章 程 》 并 改 革 党 务 制 度 ： 我 党 将 废 除 党 主 席 职 务 ， 独 设 总 书 记 ， 并 为 主 要 政 治 领 导 职 务 引 入 任 期 与 退 休 制 度 。 多 少 展 现 了 新 人 治 下 的 新 气 象 。 预 计 大 会 将 在 此 后 顺 利 闭 幕 。";
			GlobalScript.inst.gameState.data[1] += 50;
			GlobalScript.inst.gameState.data[6] += 5;
			GlobalScript.inst.gameState.empires[0].relations -= 50;
			break;
		case 1:
		{
			text = " 面 对 即 将 到 来 的 十 二 大 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 精 心 设 计 政 治 议 程 ， 并 以 《 关 于 建 国 以 来 党 的 若 干 历 史 问 题 的 决 议 》 其 中 的 精 神 与 强 调 集 体 领 导 方 式 的 态 度 为 大 会 主 旋 律 提 纲 挈 领 ： 同 以 往 的 会 议 相 比 ， 十 二 大 会 场 场 景 布 置 上 有 了 变 化 。 撤 掉 了 此 前 的 领 袖 画 像 ， 改 为 悬 挂 镰 刀 锤 头 组 成 的 巨 大 党 徽 ， 在 两 侧 十 面 红 旗 的 映 衬 下 ， 庄 严 隆 重 ， 朴 素 大 方 。 而 其 探 讨 的 内 容 更 是 在 党 史 上 开 创 了 多 项 “ 第 一 ” ： 其 中 最 瞩 目 的 当 属" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 同 志 在 开 幕 式 上 做 出 的 铿 锵 有 力 论 断 — — “ 把 马 克 思 主 义 的 普 遍 真 理 同 我 国 的 具 体 实 际 结 合 起 来 ， 走 自 己 的 道 路 ， 建 设 有 中 国 特 色 的 社 会 主 义 ， 这 就 是 我 们 总 结 长 期 历 史 经 验 得 出 的 基 本 结 论 ” 。 随 后 其 政 治 盟 友 的 《 全 面 开 创 社 会 主 义 现 代 化 建 设 的 新 局 面 》 与 新 版 《 中 国 共 产 党 章 程 》 等 文 件 背 书 只 会 进 一 步 巩 固 其 立 场 ， 并 将 标 榜 “ 除 旧 布 新 ， 生 机 盎 然 ” 的 “ 中 国 特 色 社 会 主 义 ” 给 逐 渐 推 上 前 台 ， 作 为 新 时 代 的 指 导 思 想 。 接 下 来 则 是 将 支 持 革 故 鼎 新 的 一 批 政 治 新 人 与 才 俊 推 上 前 台 ， 修 改 党 内 领 导 体 制 并 推 进 干 部 退 休 制 度 ， 以 及 建 立 囊 括 党 内 主 要 元 老 的 “ 中 央 顾 问 委 员 会 ” 监 督 国 内 改 革 与 落 实 集 体 领 导 ， 实 现 多 数 人 按 规 矩 说 了 算 。 大 会 也 就 在 一 派 胜 利 喜 悦 中 顺 利 结 束 。 此 后 便 是 思 想 宣 传 层 面 的 善 后 工 作 ： 国 内 各 大 媒 体 一 致 减 少 了 提 及 毛 泽 东 的 次 数 ， 后 者 在20 世 纪50 年 代 后 出 版 的 文 章 与 著 作 （ 如 《 论 十 大 关 系 》 、 《 关 于 国 际 共 产 主 义 运 动 总 路 线 的 论 战 》 、 民 间 自 制 的 《 毛 泽 东 思 想 万 岁 》 与 所 谓 “ 红 宝 书 ” 《 毛 泽 东 语 录 》 ） 等 逐 渐 从 图 书 馆 中 下 架 ， 并 被 要 求 停 止 再 版 。 同 时 ， 由 于 考 虑 到 “ 毛 主 席 在 建 国 时 期 提 出 的 思 想 仍 需 实 践 检 验 其 正 确 性 ” ， 中 央 编 译 局 推 出 新 版 《 毛 泽 东 选 集 》 的 计 划 也 被 无 限 期 搁 置 ， 对 《 毛 选 》 第 五 卷 的 印 刷 工 作 已 经 停 止 。 各 地 高 校 内 的 毛 泽 东 思 想 课 程 也 已 被 扩 容 为 毛 泽 东 思 想 - 中 国 特 色 社 会 主 义 思 想 政 治 课 ， 对 毛 泽 东 的 论 述 仅 集 中 在 革 命 战 争 时 期 。 虽 说 毛 泽 东 没 有 遭 遇 类 似 斯 大 林 时 代 大 多 数 “ 老 布 尔 什 维 克 ” 的 命 运 ， 并 从 中 国 和 中 国 共 产 党 的 历 史 中 彻 底 消 失 ； 且 中 国 的 党 政 机 器 仍 旧 在 相 当 程 度 上 保 留 了 对 他 的 尊 重 ， 对 其 进 行 批 评 的 行 为 依 然 可 能 招 致 官 司 与 行 政 处 罚 上 身 。 可 他 的 地 位 已 同 弗 拉 基 米 尔 · 列 宁 在 苏 联 扮 演 的 角 色 无 异 — — “ 只 属 于 过 去 ， 不 属 于 未 来 ； 活 在 历 史 内 ， 死 在 现 实 中 ； 既 是 伟 大 的 国 父 ， 也 是 无 害 的 偶 像 ； 总 之 和 孙 中 山 一 样 ， 是 党 最 好 的 政 治 木 偶 ” — — 仅 此 而 已 。";
			GlobalScript.inst.gameState.data[1] += 80;
			GlobalScript.inst.gameState.influencePRC -= 10;
			GlobalScript.inst.gameState.data[3] += 50;
			GlobalScript.inst.gameState.data[6] -= 20;
			GlobalScript.inst.gameState.empires[0].relations += 100;
			GlobalScript.inst.gameState.empires[1].relations += 100;
			GlobalScript.inst.gameState.data[57] -= 80;
			GlobalScript.inst.gameState.modifies[6].active = false;
			if (GlobalScript.inst.gameState.modifies[6].active)
			{
				GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
				GlobalScript.inst.gameState.doctr[8] = "人 民 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = "协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = "经 典 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = "中 式 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = "国 家 监 护 资 本 主 义";
				GlobalScript.inst.gameState.doctr[14] = "社 会 主 义 导 向 市 场";
				GlobalScript.inst.gameState.doctr[15] = "左 翼 小 政 府";
				GlobalScript.inst.gameState.doctr[21] = "改 良 区 域 自 治 制 度";
				GlobalScript.inst.gameState.doctr[22] = "联 邦 制";
				GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
			}
			else
			{
				GlobalScript.inst.gameState.doctr[6] = " 一 党 制 共 和 国";
				GlobalScript.inst.gameState.doctr[7] = "一 党 独 大 式 民 主";
				GlobalScript.inst.gameState.doctr[8] = " 宪 政 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = " 协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = " 中 央 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = " 分 权 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = " 鸟 笼 经 济";
				GlobalScript.inst.gameState.doctr[14] = " “ 社 会 ” 市 场 经 济";
				GlobalScript.inst.gameState.doctr[15] = " 最 小 干 预";
				GlobalScript.inst.gameState.doctr[21] = " 联 邦 制";
				GlobalScript.inst.gameState.doctr[22] = " 联 省 自 治";
				GlobalScript.inst.gameState.doctr[24] = " 破 除 传 统";
			}
			GlobalScript.inst.gameState.data[90] = 1;
			GlobalScript.inst.gameState.party_ideology[1] -= (int)((float)GlobalScript.inst.gameState.party_ideology[1] * 0.05f);
			GlobalScript.inst.gameState.party_ideology[0] -= (int)((float)GlobalScript.inst.gameState.party_ideology[0] * 0.1f);
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 0)
				{
					politic4.loyality -= 200;
				}
			}
			break;
		}
		case 2:
		{
			text = " 面 对 即 将 到 来 的 十 二 大 ，" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 决 定 精 心 设 计 政 治 议 程 ， 并 以 苏 共 二 十 大 为 蓝 本 安 排 了 接 下 来 的 政 治 议 程 ： 即 首 先 是 通 过 新 版 《 中 国 共 产 党 章 程 》 ， 改 革 党 务 制 度 与 确 认 国 家 未 来 的 经 济 、 社 会 发 展 规 划 等 方 式 夯 实 基 础 ， 在 “ 炮 打 司 令 部 ” 前 将 去 毛 泽 东 化 的 主 要 工 作 落 入 实 际 当 中 。 接 下 来 便 是 在 会 议 的 最 后 一 天 放 出 猛 料 ：" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.leader.name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.leader.name_2] + " 要 求 代 表 们 留 下 来 参 加 秘 密 会 议 ， 并 在 全 场 沉 默 中 宣 读 了 自 己 与" + GlobalScript.inst.gameState.names1[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_1] + GlobalScript.inst.gameState.names2[GlobalScript.inst.gameState.politics[GlobalScript.inst.gameState.faction_leader[4]].name_2] + " 等 同 志 共 同 操 刀 的 新 报 告 《 关 于 迷 信 文 化 与 其 历 史 后 果 》 。 毫 不 留 情 地 炮 打 以 毛 泽 东 为 代 表 的 人 民 共 和 国 开 国 元 勋 与 包 括 绝 大 多 数 “ 老 干 部 ” 在 内 的 头 面 人 物 们 ， 他 们 被 控 犯 有 下 述 六 大 罪 行 ： 利 用 中 国 文 化 糟 粕 与 王 侯 将 相 观 培 植 个 人 崇 拜 ； 以 人 治 、 政 治 恐 怖 与 军 事 专 制 手 段 取 代 法 制 与 民 主 ， 消 灭 了 以 刘 少 奇 、 彭 德 怀 等 为 代 表 的 诚 实 共 产 党 人 ； 在 民 族 问 题 上 奉 行 实 质 上 的 大 汉 族 主 义 ， 造 成 了 内 蒙 古 惨 案 与 西 北 地 区 的 饥 荒 、 叛 逃 与 民 族 文 化 灭 绝 等 一 系 列 问 题 ； 在 国 内 政 策 上 也 摒 弃 实 事 求 是 与 集 体 领 导 原 则 ， 滥 用 家 长 制 、 终 身 制 、 委 任 制 等 手 段 并 架 空 党 内 会 议 ， 导 致 党 的 正 确 政 策 完 全 无 法 落 入 实 际 工 作 当 中 ； 在 经 济 与 外 交 内 大 搞 教 条 主 义 、 山 头 主 义 与 闭 关 锁 国 思 维 ， 导 致 中 国 长 期 陷 入 落 后 与 孤 立 局 面 ； 以 及 在 反 右 运 动 、 四 清 运 动 与 文 化 大 革 命 内 组 织 山 头 相 互 勾 结 ， 搞 所 谓 “ 保 皇 派 ” 、 “ 造 反 派 ” 、 “ 林 彪 集 团 ” 或 “ 四 人 帮 ” 的 方 式 争 权 夺 利 并 肉 体 消 灭 反 对 派 。 《 历 史 后 果 》 一 文 将 上 述 现 象 的 根 源 归 结 于 党 内 受 早 期 军 事 斗 争 习 气 与 封 建 社 会 余 毒 影 响 而 形 成 的 官 本 位 与 媚 上 思 维 ， 缺 乏 自 我 纠 错 的 健 康 力 量 ， 这 才 导 致 了 所 谓 的 “ 毛 泽 东 时 代 政 治 恐 怖 ” 。 由 此 ， 绝 大 多 数 曾 同 毛 泽 东 共 事 并 默 许 其 行 为 的 老 牌 党 员 都 应 当 “ 自 觉 承 担 责 任 ” 。 代 表 们 情 绪 低 落 ， 毫 无 讨 论 地 接 受 了 报 告 。 接 下 来 便 是 全 国 各 地 党 组 织 由 此 陷 入 震 惊 和 拒 斥 ， 以 及 随 之 而 来 的 大 规 模 政 治 清 洗 — — 党 内 左 派 与 老 干 部 的 社 会 基 础 同 时 惨 遭 打 击 。 如 此 激 烈 的 改 组 自 然 导 致 了 空 前 的 社 会 动 荡 ： 数 以 百 万 计 的 不 满 者 开 始 抵 制 我 们 拆 除 毛 泽 东 与 “ 老 革 命 ” 纪 念 碑 ， 发 表 “ 黑 材 料 ” ， 以 及 下 架 前 者 相 关 作 品 与 传 记 的 举 动 ； 以 湖 南 、 江 西 、 陕 西 为 代 表 的 老 牌 苏 区 已 开 始 组 织 游 行 示 威 抗 议 这 一 行 动 ； 西 方 的 毛 派 运 动 也 一 个 接 一 个 地 谴 责 起 我 们 “ 重 蹈 赫 鲁 晓 夫 主 义 覆 辙 ” 并 “ 背 叛 革 命 事 业 ” 。 我 们 试 图 刮 骨 疗 毒 的 尝 试 使 得 党 在 国 内 外 的 地 位 都 受 到 严 重 损 害 ， 只 有 美 苏 两 大 国 对 此 颇 为 乐 见 。 如 果 有 人 企 图 发 动 政 变 ， 没 有 意 识 形 态 支 持 的 党 内 保 守 派 阵 营 显 然 不 会 为 你 辩 护 。";
			GlobalScript.inst.gameState.data[1] -= 500;
			GlobalScript.inst.gameState.data[3] -= 500;
			GlobalScript.inst.gameState.data[4] += 250;
			GlobalScript.inst.gameState.data[6] -= 100;
			GlobalScript.inst.gameState.influencePRC -= 150;
			GlobalScript.inst.gameState.empires[0].relations += 300;
			GlobalScript.inst.gameState.data[57] -= 450;
			GlobalScript.inst.gameState.data[4] += 400;
			GlobalScript.inst.gameState.empires[1].relations += 300;
			party_change[3] = 0.15f;
			party_change[4] = 0.6f;
			GlobalScript.inst.gameState.modifies[6].active = false;
			if (a.NumberOfPolitician(0, 0) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(0, 0));
			}
			if (a.NumberOfPolitician(2, 2) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(2, 2));
			}
			if (a.NumberOfPolitician(3, 3) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(3, 3));
			}
			if (a.NumberOfPolitician(4, 4) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(4, 4));
			}
			if (a.NumberOfPolitician(5, 5) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(5, 5));
			}
			if (a.NumberOfPolitician(6, 6) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(6, 6));
			}
			if (a.NumberOfPolitician(7, 7) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(7, 7));
			}
			if (a.NumberOfPolitician(8, 8) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(8, 8));
			}
			if (a.NumberOfPolitician(9, 9) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(9, 9));
			}
			if (a.NumberOfPolitician(10, 10) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(10, 10));
			}
			if (a.NumberOfPolitician(11, 11) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(11, 11));
			}
			if (a.NumberOfPolitician(13, 13) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(13, 13));
			}
			if (a.NumberOfPolitician(16, 16) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(16, 16));
			}
			if (a.NumberOfPolitician(27, 48) >= 0)
			{
				a.KillPerson(a.NumberOfPolitician(27, 48));
			}
			int num = 0;
			for (int k = 0; k < GlobalScript.inst.gameState.politics.Length; k++)
			{
				if (GlobalScript.inst.gameState.politics[k].power < GlobalScript.inst.gameState.politics[num].power && GlobalScript.inst.gameState.politics[k].traits[0] != 3)
				{
					num = k;
				}
			}
			GlobalScript.inst.gameState.politics[num].name_1 = 18;
			GlobalScript.inst.gameState.politics[num].name_2 = 61;
			GlobalScript.inst.gameState.politics[num].age = (byte)(GlobalScript.inst.gameState.data[21] - 1924);
			GlobalScript.inst.gameState.politics[num].traits[0] = 3;
			GlobalScript.inst.gameState.politics[num].traits[1] = 5;
			GlobalScript.inst.gameState.politics[num].traits[2] = 14;
			GlobalScript.inst.gameState.politics[num].power = 800;
			GlobalScript.inst.gameState.politics[num].loyality = 800;
			int num2 = 0;
			for (int l = 0; l < GlobalScript.inst.gameState.politics.Length; l++)
			{
				if (GlobalScript.inst.gameState.politics[l].power < GlobalScript.inst.gameState.politics[num2].power && GlobalScript.inst.gameState.politics[l].traits[0] != 3)
				{
					num2 = l;
				}
			}
			GlobalScript.inst.gameState.politics[num2].name_1 = 21;
			GlobalScript.inst.gameState.politics[num2].name_2 = 62;
			GlobalScript.inst.gameState.politics[num2].age = (byte)(GlobalScript.inst.gameState.data[21] - 1917);
			GlobalScript.inst.gameState.politics[num2].traits[0] = 3;
			GlobalScript.inst.gameState.politics[num2].traits[1] = 5;
			GlobalScript.inst.gameState.politics[num2].traits[2] = 15;
			GlobalScript.inst.gameState.politics[num2].power = 800;
			GlobalScript.inst.gameState.politics[num2].loyality = 800;
			int num3 = 0;
			for (int m = 0; m < GlobalScript.inst.gameState.politics.Length; m++)
			{
				if (GlobalScript.inst.gameState.politics[m].power < GlobalScript.inst.gameState.politics[num3].power && GlobalScript.inst.gameState.politics[m].traits[0] != 3)
				{
					num3 = m;
				}
			}
			GlobalScript.inst.gameState.politics[num3].name_1 = 23;
			GlobalScript.inst.gameState.politics[num3].name_2 = 63;
			GlobalScript.inst.gameState.politics[num3].age = (byte)(GlobalScript.inst.gameState.data[21] - 1925);
			GlobalScript.inst.gameState.politics[num3].traits[0] = 3;
			GlobalScript.inst.gameState.politics[num3].traits[1] = 4;
			GlobalScript.inst.gameState.politics[num3].traits[2] = 13;
			GlobalScript.inst.gameState.politics[num3].power = 800;
			GlobalScript.inst.gameState.politics[num3].loyality = 800;
			int num4 = 0;
			for (int n = 0; n < GlobalScript.inst.gameState.politics.Length; n++)
			{
				if (GlobalScript.inst.gameState.politics[n].power < GlobalScript.inst.gameState.politics[num4].power && GlobalScript.inst.gameState.politics[n].traits[0] != 3)
				{
					num4 = n;
				}
			}
			GlobalScript.inst.gameState.politics[num4].name_1 = 46;
			GlobalScript.inst.gameState.politics[num4].name_2 = 64;
			GlobalScript.inst.gameState.politics[num4].age = (byte)(GlobalScript.inst.gameState.data[21] - 1932);
			GlobalScript.inst.gameState.politics[num4].traits[0] = 3;
			GlobalScript.inst.gameState.politics[num4].traits[1] = 6;
			GlobalScript.inst.gameState.politics[num4].traits[2] = 11;
			GlobalScript.inst.gameState.politics[num4].power = 800;
			GlobalScript.inst.gameState.politics[num4].loyality = 800;
			if (GlobalScript.inst.gameState.modifies[6].active)
			{
				GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
				GlobalScript.inst.gameState.doctr[8] = "人 民 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = "协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = "经 典 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = "中 式 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = "国 家 监 护 资 本 主 义";
				GlobalScript.inst.gameState.doctr[14] = "社 会 主 义 导 向 市 场";
				GlobalScript.inst.gameState.doctr[15] = "左 翼 小 政 府";
				GlobalScript.inst.gameState.doctr[21] = "改 良 区 域 自 治 制 度";
				GlobalScript.inst.gameState.doctr[22] = "联 邦 制";
				GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
			}
			else
			{
				GlobalScript.inst.gameState.doctr[6] = " 一 党 制 共 和 国";
				GlobalScript.inst.gameState.doctr[7] = "一 党 独 大 式 民 主";
				GlobalScript.inst.gameState.doctr[8] = " 宪 政 民 主 制 度";
				GlobalScript.inst.gameState.doctr[9] = " 协 和 民 主 体 制";
				GlobalScript.inst.gameState.doctr[10] = " 中 央 计 划 经 济";
				GlobalScript.inst.gameState.doctr[11] = " 分 权 计 划 经 济";
				GlobalScript.inst.gameState.doctr[13] = " 鸟 笼 经 济";
				GlobalScript.inst.gameState.doctr[14] = " “ 社 会 ” 市 场 经 济";
				GlobalScript.inst.gameState.doctr[15] = " 最 小 干 预";
				GlobalScript.inst.gameState.doctr[21] = " 联 邦 制";
				GlobalScript.inst.gameState.doctr[22] = " 联 省 自 治";
				GlobalScript.inst.gameState.doctr[24] = " 破 除 传 统";
			}
			GlobalScript.inst.gameState.data[90] = 2;
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality -= 600;
					politic3.power -= 500;
				}
				else if (politic3.traits[0] == 1)
				{
					politic3.loyality -= 400;
					politic3.power -= 500;
				}
				else if (politic3.traits[0] == 2)
				{
					politic3.loyality -= 300;
					politic3.power -= 500;
				}
				else if (politic3.traits[0] == 3)
				{
					politic3.loyality += 200;
					politic3.power += 500;
				}
			}
			break;
		}
		}
		if (result_num == 5)
		{
			text = "";
		}
	}
}
