using System;
using System.Collections.Generic;
using System.Linq;
using KGWar;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class GameState
{
	public Modifiers[] modifies = new Modifiers[250];

	public int influencePRC;

	public int SOV_PRC_PartiesConnection;

	public Empire[] empires;

	[NonSerialized]
	public Decision[] decisions;

	public bool[] completedDecisions;

	public Country[] allcountries = new Country[99];

	public bool[] science = new bool[34];

	public int war;

	public Politic[] politics = new Politic[18];

	public Politic leader = new Politic();

	public bool[] event_done = new bool[2000];

	public int[] party_number = new int[5];

	public int[] party_ideology = new int[5];

	public bool[] is_party_enabled = new bool[5];

	public bool relres;

	public bool VasilyisGay;

	public warinwars[] ingamewars = new warinwars[200];

	public int number_event = -1;

	public int[] resultOfEvents = new int[2000];

	public int[] faction_leader = new int[5];

	public byte[] p_first = new byte[3];

	public byte[] p_second = new byte[4];

	public byte[] p_third = new byte[5];

	public byte[] p_forth = new byte[6];

	public byte[] politics_dolshnost = new byte[8];

	public int[] gamerules = new int[20];

	public string[] names1;

	public string[] names2;

	public bool iron_and_blood;

	public int[] data = new int[150];

	public bool rev_done;

	public int[] Events_number = new int[200];

	public float[] Events_time = new float[200];

	public bool[] Events_active = new bool[200];

	public bool[] war_active = new bool[5];

	public int[] desnull = new int[50];

	public bool bad_done;

	public bool bad_debuff;

	public int number_otvet = -1;

	public float OilProd;

	public float OilEat;

	public bool is_progorel;

	public bool achivki_sosut;

	public int diff = 2;

	public bool is_save_bylo;

	public bool is_elect;

	public bool is_speech;

	public bool is_konst_max = true;

	public bool turn_on;

	public bool is_gkchp;

	public bool bylo;

	public bool neizucheno = true;

	public string[] party_name = new string[15];

	public bool[] is_party_ally = new bool[5];

	public bool BritLost;

	public bool vietnampeace;

	public bool iranrev;

	public bool guns;

	public bool DRAagree;

	public bool CBIndia;

	public bool OAR;

	public bool Israellost;

	public bool YugAgree;

	public bool sanct;

	public bool donat;

	public bool ICP;

	public bool IndOpp;

	public bool HelpGandi;

	public bool SovAlb;

	public bool SEZ;

	public bool TaiCoup;

	public bool SKRebel;

	public bool[] checking = new bool[5];

	public string[] doctr = new string[42];

	public bool[] science_in_progress = new bool[34];

	public int[] science_time = new int[34];

	public int[] science_need_time = new int[34];

	public int[] data_old = new int[200];

	public int ArmyLoyality;

	public int ArmyPower;

	public int ChinesePage;

	public int ImportChange(GameState global1)
	{
		float num = (float)global1.data[5] * 2f / 1000f * ((GlobalScript.inst.gameState.data[34] >= 1500) ? 1500f : ((float)global1.data[34])) - (float)global1.data[12] / 1000f * ((GlobalScript.inst.gameState.data[34] >= 1500) ? 1500f : ((float)global1.data[34]));
		float num2 = (float)global1.data[5] / 1000f * ((GlobalScript.inst.gameState.data[34] >= 1500) ? 1500f : ((float)global1.data[34])) - (float)global1.data[13] * 2f / 1000f * ((GlobalScript.inst.gameState.data[34] >= 1500) ? 1500f : ((float)global1.data[34]));
		float num3 = (float)global1.data[5] / 1000f * ((GlobalScript.inst.gameState.data[34] >= 1500) ? 1500f : ((float)global1.data[34])) - (float)global1.data[68] / 1000f * ((GlobalScript.inst.gameState.data[34] >= 1500) ? 1500f : ((float)global1.data[34]));
		return (int)((num + num2 + num3) / 200f);
	}

	public bool WarCheck(int num)
	{
		if ((GlobalScript.inst.gameState.ingamewars[num].fortnight_go >= GlobalScript.inst.gameState.ingamewars[num].fortnight_max || GlobalScript.inst.gameState.ingamewars[num].infl1 >= 1000 || GlobalScript.inst.gameState.ingamewars[num].infl2 >= 1000) && GlobalScript.inst.gameState.ingamewars[num].is_going)
		{
			return GlobalScript.inst.gameState.data[82] < 0;
		}
		return false;
	}

	public bool WarResult(ref string text)
	{
		GameObject gameObject = GameObject.Find("Ach(Clone)");
		Debug.Log("СОМАЛИИИИИИИИИИИИИИИИ-1");
		if (GlobalScript.inst.gameState.data[82] == 0)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
			{
				if (GlobalScript.inst.gameState.allcountries[10].Gosstroy == 3 && GlobalScript.inst.gameState.allcountries[46].Gosstroy == 0)
				{
					GlobalScript.inst.gameState.data[157] = 1;
				}
				GlobalScript.inst.gameState.allcountries[10].name = GlobalScript.inst.new_events_text[838];
				if (!GlobalScript.inst.gameState.allcountries[1].isSEATO)
				{
					GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
					GlobalScript.inst.gameState.influencePRC += 50;
					GlobalScript.inst.gameState.empires[0].power -= 40;
					GlobalScript.inst.gameState.data[83] = 1;
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[10].parts[0] = true;
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
					GlobalScript.inst.gameState.data[83] = 1;
					GlobalScript.inst.gameState.empires[1].power += 60;
				}
				text = string.Format(GlobalScript.inst.new_events_text[1611], "\n");
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
			{
				GlobalScript.inst.gameState.allcountries[46].name = GlobalScript.inst.new_events_text[1645];
				if (!GlobalScript.inst.gameState.allcountries[1].isSEATO)
				{
					GlobalScript.inst.gameState.allcountries[46].parts[0] = true;
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.empires[1].power -= 20;
					GlobalScript.inst.gameState.empires[0].power += 50;
					GlobalScript.inst.gameState.data[83] = 2;
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[46].parts[0] = true;
					GlobalScript.inst.gameState.influencePRC += 20;
					GlobalScript.inst.gameState.empires[1].power -= 40;
					GlobalScript.inst.gameState.empires[0].power += 50;
					GlobalScript.inst.gameState.data[83] = 2;
				}
				text = string.Format(GlobalScript.inst.new_events_text[1612], "\n");
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[1634], "\n");
			}
		}
		else if (GlobalScript.inst.gameState.data[82] == 1)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
			{
				GlobalScript.inst.gameState.influencePRC += 20;
				GlobalScript.inst.gameState.data[1] += 100;
				GlobalScript.inst.gameState.empires[1].power -= 20;
				text = string.Format(GlobalScript.inst.new_events_text[1614], "\n");
				if (GlobalScript.inst.gameState.war == 1)
				{
					GlobalScript.inst.gameState.allcountries[11].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
					GlobalScript.inst.gameState.allcountries[11].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
					GlobalScript.inst.gameState.allcountries[11].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[11].puppetOf = 1;
					GlobalScript.inst.gameState.allcountries[11].Torg = true;
					GlobalScript.inst.gameState.allcountries[11].prosov = false;
					GlobalScript.inst.gameState.allcountries[11].proprc = true;
					GlobalScript.inst.gameState.allcountries[11].soc_stab = 1000;
					GlobalScript.inst.gameState.war = 0;
					text = " 在 我 们 与 柬 埔 寨 同 志 一 起 反 击 越 南 侵 略 者 的 入 侵 并 解 放 越 南 的 两 大 重 要 城 市 后 ， 他 们 终 于 投 降 了 。 尽 管 我 们 受 到 苏 联 的 战 争 威 胁 ， 但 我 们 还 是 顶 住 了 压 力 ， 迅 速 将 越 南 侵 略 者 给 赶 下 了 台 。\n";
					if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 0 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 17)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 和 对 一 些 前 政 府 官 员 的 审 判 ， （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 ： 该 国 现 在 由 越 南 人 民 党 执 政 ， 国 号 也 改 为 越 南 人 民 共 和 国 。\n 越 南 最 新 的 领 袖 是 黄 文 欢 。 他 是 越 盟 的 创 始 人 之 一 ， 与 胡 志 明 主 席 关 系 融 洽 。 随 着 亲 苏 派 的 崛 起 ， 以 黄 文 欢 为 代 表 的 亲 中 派 慢 慢 被 排 挤 出 权 力 中 心 。 1 9 7 6 年 他 未 能 当 选 越 共 中 央 委 员 ， 之 后 便 慢 慢 失 去 了 政 治 地 位 。 自 1 9 7 9 年 以 来 他 就 一 直 流 亡 在 中 华 人 民 共 和 国 ， 并 常 常 书 写 批 评 黎 笋 政 府 的 小 册 子 。\n 新 政 府 宣 布 将 平 反 一 切 黎 笋 时 期 的 冤 假 错 案 ， 巩 固 提 高 发 展 与 中 华 人 民 共 和 国 的 关 系 。 并 在 力 所 能 及 的 范 围 内 推 行 社 会 主 义 政 策 ， 尤 其 是 打 击 官 僚 资 本 主 义 和 买 办 残 余 ， 平 衡 南 北 之 间 的 差 距 。\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 人 民 共 和 国";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 10 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 15 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 7 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 15 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 19)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 理 应 有 的 清 洗 和 审 判 却 没 有 发 生 。 黎 笋 本 人 在 签 署 了 投 降 书 后 立 刻 辞 职 ， 由 他 本 人 的 亲 信 黎 德 寿 主 政 越 南 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 。\n 该 国 现 在 由 越 南 人 民 党 执 政 ， 国 号 也 改 为 越 南 民 主 主 义 人 民 共 和 国 。\n 黎 德 寿 是 黎 笋 派 的 重 要 成 员 ， 他 曾 参 与 了 和 基 辛 格 的 巴 黎 和 谈 ， 拒 绝 诺 贝 尔 和 平 奖 为 他 带 来 了 巨 大 的 声 望 。\n 黎 德 寿 在 大 体 上 延 续 了 黎 笋 的 政 策 — — 除 了 把 对 象 从 苏 联 改 为 中 国 以 外 ， 其 他 事 情 几 乎 没 有 变 化 。 很 快 ， 越 南 方 面 也 开 始 传 来 了 “ 解 冻 ” 的 传 闻 。 原 先 的 工 人 代 表 制 正 在 被 厂 长 制 一 步 一 步 的 蚕 食 ， 似 乎 越 南 除 了 一 面 红 旗 外 ， 再 无 社 会 主 义 了 … … 不 过 谁 在 乎 他 们 呢 ！ 只 要 中 华 人 民 共 和 国 不 倒 ， 越 南 也 将 永 远 屹 立 ！\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 民 主 主 义 人 民 共 和 国";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 13 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 9)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 并 枪 决 了 旧 时 代 的 政 要 后 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 。\n 该 国 现 在 由 越 南 军 事 委 员 会 执 政 ， 国 号 也 改 为 越 南 民 主 人 民 共 和 国 。\n 手 握 重 兵 的 文 进 勇 在 战 争 的 一 开 始 就 意 识 到 中 华 人 民 共 和 国 难 以 战 胜 。 而 失 败 的 战 争 无 疑 会 沉 重 打 击 黎 笋 的 声 望 ， 在 越 南 人 民 军 内 部 发 生 不 满 时 ， 文 进 勇 就 开 始 做 好 了 军 事 政 变 的 打 算 。 随 着 河 内 的 沦 陷 ， 越 共 中 央 政 治 局 在 往 南 转 移 的 路 上 被 人 民 军 截 获 。 留 下 了 部 分 必 要 人 士 后 悉 数 处 决 。 以 越 南 人 民 军 为 主 体 的 新 政 府 得 以 迅 速 建 立 。 很 快 ， 仅 仅 是 作 为 治 安 条 例 的 《 越 南 紧 急 条 例 》 从 特 殊 条 款 升 级 为 普 通 法 ， 军 人 和 治 安 官 得 以 在 任 何 情 况 下 随 意 处 决 每 一 个 被 怀 疑 是 “ 通 敌 者 ” 的 人 。 越 南 越 发 孤 立 。 除 了 依 然 象 征 性 的 保 留 了 和 中 国 及 其 盟 友 的 外 交 关 系 外 ， 越 南 再 也 没 有 发 过 一 张 签 证 。\n 在 联 合 国 人 权 理 事 会 的 “ 支 持 恐 怖 主 义 国 家 ” 名 单 上 ， 越 南 榜 上 有 名 ， 几 乎 沦 为 了 和 古 巴 ， 叙 利 亚 和 利 比 亚 一 样 的 存 在 。\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 民 主 人 民 共 和 国";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 18)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 并 枪 决 了 旧 时 代 的 政 要 后 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 … … 才 怪 ！ 你 以 为 接 下 来 就 是 核 大 战 了 ？ 别 以 为 我 不 知 道 你 在 想 什 么 ！ 正 常 情 况 下 你 怎 么 也 做 不 到 变 成 托 派 再 入 侵 越 南 ： 想 要 变 成 托 派 ， 游 戏 至 少 要 进 行 到1984 年 ， 而 在 那 之 前 中 柬 越 战 争 早 已 结 束 。 除 非 … … 你 作 弊 了 ！ 但 还 是 恭 喜 你 找 到 了 彩 蛋 ！ 我 压 根 没 打 算 写 一 个 你 怎 么 也 打 不 出 来 的 结 局 。 但 我 们 （ 全 体 制 作 组 成 员 ） 还 是 要 说 ， 既 然 你 有 这 么 高 超 的 电 脑 技 巧 ， 为 什 么 不 加 入 改 版 制 作 组 呢 ？ Q Q 群 号 ： 9 6 3 9 1 1 5 7 4\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 不 可 思 议 的 托 派 越 南";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 16)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 并 枪 决 了 旧 时 代 的 政 要 后 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 。\n 该 国 现 在 由 越 南 共 产 党 执 政 ， 国 号 仍 然 是 越 南 社 会 主 义 共 和 国 。\n 范 文 同 是 越 南 共 产 党 的 前 要 员 ， 他 在 越 南 战 争 中 一 直 在 北 方 活 动 。 是 胡 志 明 的 得 力 助 手 ， 尽 管 他 一 度 被 认 为 是 黎 笋 派 的 成 员 ， 但 在 大 局 不 妙 的 当 前 毅 然 决 然 选 择 叛 变 。\n 在 大 体 政 策 上 ， 越 南 没 有 变 化 ， 依 旧 是 那 个 看 起 来 朝 气 蓬 勃 的 社 会 主 义 越 南 。\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 社 会 主 义 共 和 国";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 1 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 2)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 并 枪 决 了 旧 时 代 的 政 要 后 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 。\n 该 国 现 在 由 越 南 劳 动 党 执 政 ， 国 号 也 改 为 越 南 人 民 共 和 国 。\n 新 政 府 的 领 袖 上 阮 友 寿 ， 阮 友 寿 作 为 前 越 南 南 方 民 族 解 放 阵 线 的 成 员 ， 在 中 国 可 谓 是 无 人 不 知 无 人 不 晓 。 在 中 越 战 争 陷 入 僵 局 的 时 候 ， 我 们 找 到 找 到 了 这 位 老 将 ， 并 设 法 说 服 了 他 和 南 方 派 联 合 起 来 推 翻 黎 笋 。\n 新 政 府 的 大 体 方 针 可 被 视 为 “ 在 无 产 阶 级 专 政 下 继 续 革 命 ” 的 温 和 化 版 本 。 工 人 委 员 会 被 建 立 起 来 了 ， 而 北 方 和 南 方 的 差 距 也 得 到 重 视 。 在 政 治 方 面 ， 越 南 劳 动 党 吸 纳 了 大 量 工 人 和 农 民 入 党 ， 而 不 是 过 去 的 知 识 分 子 和 骨 干 占 主 体 。 罢 工 ， 罢 市 和 罢 课 的 自 由 也 被 写 入 了 宪 法 。 胡 志 明 的 理 念 似 乎 得 到 了 实 现 。\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 人 民 共 和 国";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 3 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 8)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 并 枪 决 了 旧 时 代 的 政 要 后 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 。\n 该 国 现 在 由 越 南 社 会 党 执 政 ， 国 号 也 改 为 越 南 民 主 共 和 国 。\n 长 征 是 越 共 亲 华 派 人 物 ， 1 9 5 6 年 因 在 土 改 中 的 政 策 ， 被 以 黎 笋 为 代 表 的 亲 苏 派 排 挤 ， 免 去 第 一 书 记 的 职 务 。 他 热 切 的 希 望 靠 中 国 人 民 解 放 军 的 手 来 复 仇 。\n 新 政 府 开 展 了 一 系 列 改 革 ， 最 主 要 的 还 是 引 入 市 场 经 济 。 尽 管 政 府 宣 布 “ 不 走 市 场 经 济 的 邪 路 ， 更 不 走 共 产 主 义 的 死 路 。 ” 不 可 不 谓 没 有 成 效 ， 短 短 的 几 个 月 ， 越 南 的 外 汇 翻 了 一 番 ， 越 南 人 民 的 生 活 水 平 直 追 南 斯 拉 夫 。 但 同 时 ， 大 量 的 血 汗 工 厂 压 榨 着 越 南 人 ， 而 宣 誓 会 保 护 他 们 的 越 南 人 民 军 — — 却 在 和 他 们 的 帝 国 主 义 敌 人 眉 来 眼 去 。 稍 有 常 识 的 人 都 会 看 出 ， 所 有 的 腾 飞 都 会 有 一 次 硬 着 陆 。 越 南 也 不 会 例 外 。\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 民 主 共 和 国";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 14 || GlobalScript.inst.gameState.allcountries[1].SubGosstroy == 11)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 并 枪 决 了 旧 时 代 的 政 要 后 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 。\n 该 国 现 在 由 越 南 人 民 党 执 政 ， 国 号 也 改 为 越 南 民 主 共 和 国 。\n 新 政 府 开 展 了 轰 轰 烈 烈 的 民 主 化 政 策 。 瞬 间 ， 党 除 了 自 己 的 青 年 组 织 外 ， 放 弃 了 对 残 联 ， 妇 联 和 工 会 的 垄 断 ， 大 量 私 人 组 织 填 占 了 空 缺 。 在 思 想 上 ， 原 先 严 格 的 审 查 制 度 也 被 取 消 ， 新 思 想 充 斥 着 越 南 人 的 头 脑 。\n 最 难 以 理 解 的 部 分 则 是 对 越 共 历 史 的 颠 倒 ， 在 官 方 教 科 书 里 ， 越 南 共 产 党 反 而 成 了 那 批 试 图 颠 覆 政 权 来 谋 求 私 利 的 人 。 南 越 是 那 个 试 图 保 存 国 家 尊 严 的 政 府 ， 许 多 越 南 人 都 无 法 理 解 ： 这 个 世 界 到 底 怎 么 了 ？ 昨 天 的 英 雄 怎 么 突 然 变 成 了 恶 魔 ？\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 民 主 共 和 国";
					}
					else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 3)
					{
						text += " 随 着 中 国 人 民 解 放 军 的 坦 克 轰 入 了 胡 志 明 市 ， 越 南 政 权 事 实 上 垮 台 了 。 伴 随 着 旧 政 府 的 倒 台 ， 并 枪 决 了 旧 时 代 的 政 要 后 。 （ 属 于 中 华 人 民 共 和 国 控 制 下 的 ） 越 南 迎 来 了 美 好 的 未 来 。\n 该 国 现 在 由 越 南 民 主 党 执 政 ， 国 号 也 改 回 了 越 南 共 和 国 。\n 新 政 府 宣 布 开 始 大 力 进 行 去 共 产 主 义 化 。 胡 志 明 的 雕 像 被 摘 除 ， 他 也 被 描 述 为 “ 苏 联 间 谍 ” ， 胡 主 席 纪 念 堂 也 被 拆 除 ， 西 贡 也 回 来 了 。 在 官 方 教 科 书 里 ， 越 南 共 产 党 反 而 成 了 那 批 试 图 颠 覆 政 权 来 谋 求 私 利 的 人 。 南 越 是 那 个 试 图 保 存 国 家 尊 严 的 政 府 ， 许 多 越 南 人 都 无 法 理 解 ： 这 个 世 界 到 底 怎 么 了 ？ 昨 天 的 英 雄 怎 么 突 然 变 成 了 恶 魔 ？\n";
						GlobalScript.inst.gameState.allcountries[11].name = " 越 南 共 和 国";
					}
					GlobalScript.inst.gameState.allcountries[22].puppetOf = 1;
					GlobalScript.inst.gameState.allcountries[22].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
					GlobalScript.inst.gameState.allcountries[22].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
					GlobalScript.inst.gameState.allcountries[22].prosov = false;
					GlobalScript.inst.gameState.allcountries[22].proprc = true;
					GlobalScript.inst.gameState.allcountries[22].isSEV = false;
					text += " 越 南 的 大 印 支 梦 被 击 了 个 粉 碎 — — 他 们 对 老 挝 的 事 实 性 统 治 结 束 了 ， 柬 越 争 议 的 几 处 岛 屿 被 划 归 柬 埔 寨 ， 下 高 棉 地 区 则 设 立 了 自 治 区 。 印 支 地 区 终 于 太 平 了 ， 但 是 苏 联 对 此 很 是 不 满 … … ";
				}
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
			{
				GlobalScript.inst.gameState.allcountries[23].Gosstroy = GlobalScript.inst.gameState.allcountries[11].Gosstroy;
				GlobalScript.inst.gameState.allcountries[23].SubGosstroy = GlobalScript.inst.gameState.allcountries[11].SubGosstroy;
				GlobalScript.inst.gameState.allcountries[23].puppetOf = 11;
				GlobalScript.inst.gameState.allcountries[23].prosov = true;
				GlobalScript.inst.gameState.allcountries[23].proprc = false;
				GlobalScript.inst.gameState.allcountries[23].Torg = false;
				GlobalScript.inst.gameState.allcountries[23].econ = false;
				GlobalScript.inst.gameState.allcountries[23].okb = false;
				GlobalScript.inst.gameState.influencePRC -= 30;
				GlobalScript.inst.gameState.empires[1].power += 10;
				text = string.Format(GlobalScript.inst.new_events_text[1613], "\n");
				if (GlobalScript.inst.gameState.war == 1)
				{
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.war = 0;
					text = " 越 南 人 民 军 成 功 击 退 我 们 的 进 攻 并 占 领 了 柬 埔 寨 。 在 柬 埔 寨 救 国 民 族 团 结 阵 线 的 支 持 下 ， 越 南 军 队 轻 易 的 击 溃 了 柬 埔 寨 军 并 占 领 了 金 边 。 根 据 与 苏 联 一 方 的 协 定 ， 越 南 当 局 重 建 了 柬 埔 寨 人 民 革 命 党 ， 并 将 韩 桑 宁 与 洪 森 扶 上 了 柬 埔 寨 人 民 共 和 国 的 领 导 人 之 位 — — 他 们 都 是 前 民 主 柬 埔 寨 政 权 内 的 亲 越 派 ， 并 在 波 尔 布 特 的 压 力 下 不 得 不 流 亡 出 境 。 现 在 ， 他 们 成 了 苏 式 社 会 主 义 的 忠 实 拥 护 者 。 新 柬 埔 寨 的 改 革 也 准 备 开 始 ， 该 国 将 以 苏 联 为 师 ， 按 图 索 骥 。 而 数 目 庞 大 的 越 南 军 队 仍 将 驻 扎 在 该 国 维 持 秩 序 。 新 政 府 同 时 还 开 始 准 备 组 织 清 算 旧 政 权 的 法 庭 ， 并 开 始 搜 集 “ 民 主 柬 埔 寨 匪 帮 为 美 帝 国 主 义 与 北 京 修 正 主 义 者 效 劳 ” 的 证 据 。 民 主 柬 埔 寨 的 残 余 纷 纷 撤 入 当 局 鞭 长 莫 及 的 丛 林 与 柬 埔 寨 - 泰 国 边 境 ， 并 开 始 转 入 游 击 战 。 在 我 们 的 支 持 下 ， 柬 埔 寨 爱 国 、 民 主 、 民 族 大 团 结 阵 线 （ 柬 共 一 方 的 统 一 战 线 组 织 ） 的 领 导 人 乔 森 潘 ， 将 同 牵 头 组 织 高 棉 人 民 民 族 解 放 阵 线 （ 亲 美 的 高 棉 共 和 国 残 党 ） 的 宋 双 ， 以 及 领 导 争 取 柬 埔 寨 独 立 、 中 立 、 和 平 与 合 作 民 族 团 结 阵 线 （ 君 主 主 义 派 组 织 ） 的 诺 罗 敦 · 西 哈 努 克 亲 王 组 织 三 方 会 谈 ， 并 建 立 联 合 政 府 与 统 一 军 事 指 挥 部 ， 继 续 抵 抗 越 南 。 在 另 一 边 ， 越 南 人 民 军 彻 底 将 我 们 的 部 队 从 越 南 赶 了 出 去 ， 并 占 领 了 一 些 中 越 边 境 要 地 ， 我 们 不 得 不 与 他 们 议 和 。 越 南 终 于 成 为 了 印 度 支 那 的 霸 主 ， 他 们 正 在 计 划 同 苏 联 进 行 深 度 合 作 ， 我 们 的 边 境 局 势 空 前 恶 化 了 … …";
				}
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[1634], "\n");
			}
		}
		else if (GlobalScript.inst.gameState.data[82] == 2)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 750 || GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 750)
			{
				GlobalScript.inst.gameState.allcountries[34].Torg = true;
				GlobalScript.inst.gameState.allcountries[34].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[34].SubGosstroy = 17;
				GlobalScript.inst.gameState.allcountries[34].LeaveASEAN();
				GlobalScript.inst.gameState.allcountries[34].proprc = true;
				GlobalScript.inst.gameState.allcountries[34].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[34].prcpower = 1000;
				GlobalScript.inst.gameState.allcountries[34].cw = true;
				GlobalScript.inst.gameState.influencePRC += 20;
				GlobalScript.inst.gameState.empires[0].power -= 20;
				text = string.Format(GlobalScript.inst.new_events_text[1615], "\n");
			}
			else
			{
				GlobalScript.inst.gameState.influencePRC -= 10;
				text = string.Format(GlobalScript.inst.new_events_text[1616], "\n");
			}
		}
		else if (GlobalScript.inst.gameState.data[82] == 3)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
			{
				if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 1)
				{
					if (GlobalScript.inst.gameState.allcountries[14].Gosstroy == 1)
					{
						text = " 随 着 共 产 主 义 者 和 社 会 主 义 者 的 联 盟 在 伊 朗 取 得 了 胜 利 ， 而 萨 达 姆 政 权 也 已 经 垮 台 ， 新 政 权 立 刻 宣 布 停 火 ， 并 对 使 用 伊 朗 港 口 和 入 海 口 的 划 分 达 成 了 一 致 。 双 方 都 充 分 尊 重 对 方 的 少 数 民 族 政 策 ， 一 部 分 库 尔 德 人 也 被 允 许 回 到 祖 国 ， 和 平 重 新 降 临 在 这 两 个 国 家 。";
						GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
						GlobalScript.inst.gameState.allcountries[8].soc_stab = 1000;
					}
					else
					{
						text = " 随 着 伊 朗 人 民 革 命 联 盟 推 翻 了 伊 斯 兰 神 权 政 府 ， 伊 拉 克 方 面 宣 布 停 止 对 伊 朗 的 军 事 行 动 ， 并 事 实 上 放 弃 了 已 经 半 吞 并 化 的 部 分 胡 齐 斯 坦 和 入 海 口 。 而 新 政 府 也 愿 意 同 伊 拉 克 在 入 海 口 问 题 上 给 予 一 定 让 步 。 双 方 的 关 系 开 始 逐 步 改 善 ， 胡 齐 斯 坦 的 阿 拉 伯 人 也 得 以 选 择 留 在 故 乡 还 是 回 到 伊 拉 克 。 美 苏 双 方 都 感 谢 了 两 伊 的 让 步 。 据 信 萨 达 姆 和 拉 贾 维 已 被 提 名 为 本 年 度 的 诺 贝 尔 和 平 奖 得 主 。";
						GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
						GlobalScript.inst.gameState.allcountries[8].soc_stab = 1000;
					}
				}
				else if (GlobalScript.inst.gameState.event_done[450] && GlobalScript.inst.gameState.resultOfEvents[450] == 0)
				{
					GlobalScript.inst.gameState.allcountries[8].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].Torg = true;
					GlobalScript.inst.gameState.allcountries[8].proprc = true;
					GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
					GlobalScript.inst.gameState.allcountries[8].soc_stab = 1000;
					text = " 由 伊 朗 国 家 抵 抗 委 员 会 领 导 的 革 命 军 在 伊 拉 克 的 支 持 下 ， 成 功 击 败 了 伊 朗 伊 斯 兰 共 和 国 。 以 霍 梅 尼 为 首 的 神 权 政 府 成 员 被 逮 捕 ， 并 被 判 处 死 刑 。 抵 抗 委 员 会 中 各 大 组 织 在 经 过 谈 判 后 决 定 共 同 组 建 一 个 以 革 命 左 翼 为 核 心 ， 马 克 思 列 宁 主 义 为 主 的 新 党 — — 伊 朗 人 民 民 主 党 。 其 他 支 持 革 命 的 非 左 翼 革 命 派 的 组 织 则 进 入 了 伊 朗 祖 国 阵 线 ， 合 法 参 与 革 命 后 的 伊 朗 政 治 ， 阿 卜 杜 勒 • 拉 赫 曼 • 哈 塞 姆 卢 作 为 库 尔 德 抵 抗 运 动 代 表 ， 被 选 举 为 祖 国 阵 线 主 席 。 作 为 新 革 命 政 府 的 人 民 革 命 委 员 会 宣 布 将 在 伊 朗 建 设 人 民 民 主 。 原 政 府 的 神 职 人 员 被 永 久 禁 止 参 与 政 治 ， 革 命 卫 队 成 员 先 后 被 判 刑 ， 大 型 国 有 化 和 土 地 改 革 运 动 正 在 蓬 勃 开 展 ； 全 国 各 民 族 的 歧 视 性 政 策 被 废 除 ， 库 尔 德 、 阿 塞 拜 疆 、 俾 路 支 、 土 库 曼 和 阿 拉 伯 人 的 聚 居 区 都 成 立 了 各 自 的 民 族 自 治 区 。 世 俗 化 运 动 和 妇 女 革 命 正 在 进 行 准 备 工 作 ， 伊 朗 邀 请 了 阿 尔 巴 尼 亚 人 ， 伊 拉 克 人 和 我 们 作 为 顾 问 ， 准 备 开 始 对 旧 社 会 的 反 攻 倒 算 与 彻 底 的 大 洗 牌 。";
					if (GlobalScript.inst.gameState.allcountries[14].puppetOf == 8)
					{
						GlobalScript.inst.gameState.allcountries[14].puppetOf = -1;
						GlobalScript.inst.gameState.allcountries[14].Gosstroy = GlobalScript.inst.gameState.allcountries[8].Gosstroy;
						GlobalScript.inst.gameState.allcountries[14].SubGosstroy = GlobalScript.inst.gameState.allcountries[8].SubGosstroy;
					}
					GlobalScript.inst.gameState.iranrev = false;
				}
				else if (GlobalScript.inst.gameState.event_done[450] && GlobalScript.inst.gameState.resultOfEvents[450] == 1)
				{
					GlobalScript.inst.gameState.allcountries[8].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].Torg = true;
					GlobalScript.inst.gameState.allcountries[8].proprc = true;
					GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
					GlobalScript.inst.gameState.allcountries[8].soc_stab = 1000;
					text = " 由 伊 朗 国 家 抵 抗 委 员 会 领 导 的 革 命 军 在 伊 拉 克 的 支 持 下 ， 成 功 击 败 了 伊 朗 伊 斯 兰 共 和 国 。 以 霍 梅 尼 为 首 的 神 权 政 府 成 员 被 逮 捕 ， 并 被 判 处 死 刑 。 抵 抗 委 员 会 中 各 大 组 织 在 经 过 谈 判 后 决 定 共 同 组 建 一 个 以 革 命 左 翼 为 核 心 ， 马 克 思 列 宁 主 义 为 主 的 新 党 — — 伊 朗 人 民 民 主 党 。 其 他 支 持 革 命 的 非 左 翼 革 命 派 的 组 织 则 进 入 了 伊 朗 祖 国 阵 线 ， 合 法 参 与 革 命 后 的 伊 朗 政 治 ， 阿 卜 杜 勒 • 拉 赫 曼 • 哈 塞 姆 卢 作 为 库 尔 德 抵 抗 运 动 代 表 ， 被 选 举 为 祖 国 阵 线 主 席 。 作 为 新 革 命 政 府 的 人 民 革 命 委 员 会 宣 布 将 在 伊 朗 建 设 人 民 民 主 。 原 政 府 的 神 职 人 员 被 永 久 禁 止 参 与 政 治 ， 革 命 卫 队 成 员 先 后 被 判 刑 ， 大 型 国 有 化 和 土 地 改 革 运 动 正 在 蓬 勃 开 展 ； 全 国 各 民 族 的 歧 视 性 政 策 被 废 除 ， 库 尔 德 、 阿 塞 拜 疆 、 俾 路 支 、 土 库 曼 和 阿 拉 伯 人 的 聚 居 区 都 成 立 了 各 自 的 民 族 自 治 区 。 世 俗 化 运 动 和 妇 女 革 命 正 在 进 行 准 备 工 作 ， 伊 朗 邀 请 了 阿 尔 巴 尼 亚 人 ， 伊 拉 克 人 和 我 们 作 为 顾 问 ， 准 备 开 始 对 旧 社 会 的 反 攻 倒 算 与 彻 底 的 大 洗 牌 。";
					if (GlobalScript.inst.gameState.allcountries[14].puppetOf == 8)
					{
						GlobalScript.inst.gameState.allcountries[14].puppetOf = -1;
						GlobalScript.inst.gameState.allcountries[14].Gosstroy = GlobalScript.inst.gameState.allcountries[8].Gosstroy;
						GlobalScript.inst.gameState.allcountries[14].SubGosstroy = GlobalScript.inst.gameState.allcountries[8].SubGosstroy;
					}
					GlobalScript.inst.gameState.iranrev = false;
				}
				else if (GlobalScript.inst.gameState.allcountries[14].Gosstroy == 1)
				{
					GlobalScript.inst.gameState.allcountries[8].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].Torg = true;
					GlobalScript.inst.gameState.allcountries[8].proprc = true;
					GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
					GlobalScript.inst.gameState.allcountries[8].soc_stab = 1000;
					text = " 新 政 府 宣 布 继 续 和 伊 朗 开 战 ， 而 他 们 的 豪 赌 胜 利 了 。 在 中 国 和 苏 联 的 帮 助 下 ， 伊 斯 兰 主 义 者 完 全 溃 败 ， 而 随 着 伊 拉 克 的 坦 克 攻 入 德 黑 兰 和 大 不 里 士 ， 神 权 政 府 宣 布 投 降 。 伊 拉 克 革 命 政 府 也 不 再 宣 称 对 胡 齐 斯 坦 的 主 权 要 求 ， 称 其 为 “ 小 资 产 阶 级 不 切 实 际 的 民 族 主 义 狂 热 ， 应 当 为 国 际 主 义 革 命 让 步 。 ”|| 以 霍 梅 尼 为 首 的 神 权 政 府 成 员 被 逮 捕 ， 并 被 公 审 。 由 伊 朗 境 内 各 个 左 翼 组 织 形 成 的 人 民 革 命 联 盟 在 经 过 谈 判 后 决 定 共 同 组 建 一 个 以 激 进 伊 斯 兰 社 会 主 义 （ 伊 斯 兰 马 克 思 主 义 ） 、 马 列 主 义 和 反 修 正 主 义 为 意 识 形 态 的 新 党 — — 伊 朗 人 民 革 命 党 。 其 他 支 持 革 命 的 非 左 翼 革 命 派 的 组 织 则 进 入 了 伊 朗 爱 国 阵 线 ， 合 法 参 与 革 命 后 的 伊 朗 政 治 ， 阿 博 尔 哈 桑 · 巴 尼 萨 德 尔 被 选 举 为 爱 国 阵 线 主 席 。 作 为 新 革 命 政 府 的 人 民 革 命 委 员 会 宣 布 将 在 伊 朗 建 设 人 民 民 主 。 神 职 人 员 被 永 久 禁 止 参 与 政 治 ， 大 型 国 有 化 和 土 地 改 革 运 动 正 在 蓬 勃 开 展 ； 全 国 各 民 族 一 律 平 等 ， 库 尔 德 、 阿 塞 拜 疆 、 俾 路 支 、 土 库 曼 和 阿 拉 伯 人 的 聚 居 区 都 成 立 了 各 自 的 民 族 自 治 区 。 世 俗 化 运 动 和 妇 女 革 命 正 在 进 行 准 备 工 作 ， 伊 朗 邀 请 了 阿 尔 巴 尼 亚 人 ， 伊 拉 克 战 友 和 我 们 作 为 顾 问 ， 准 备 开 展 一 场 温 和 化 的 思 想 文 化 革 命 。";
					if (GlobalScript.inst.gameState.allcountries[14].puppetOf == 8)
					{
						GlobalScript.inst.gameState.allcountries[14].puppetOf = -1;
						GlobalScript.inst.gameState.allcountries[14].Gosstroy = GlobalScript.inst.gameState.allcountries[8].Gosstroy;
						GlobalScript.inst.gameState.allcountries[14].SubGosstroy = GlobalScript.inst.gameState.allcountries[8].SubGosstroy;
					}
				}
				else
				{
					GlobalScript.inst.gameState.empires[1].power += 10;
					GlobalScript.inst.gameState.allcountries[14].parts[4] = true;
					text = string.Format(GlobalScript.inst.new_events_text[1617], "\n");
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 1)
			{
				if (GlobalScript.inst.gameState.allcountries[14].Gosstroy == 1)
				{
					text = " 随 着 共 产 主 义 者 和 社 会 主 义 者 的 联 盟 在 伊 朗 取 得 了 胜 利 ， 而 萨 达 姆 政 权 也 已 经 垮 台 ， 新 政 权 立 刻 宣 布 停 火 ， 并 对 使 用 伊 朗 港 口 和 入 海 口 的 划 分 达 成 了 一 致 。 双 方 都 充 分 尊 重 对 方 的 少 数 民 族 政 策 ， 一 部 分 库 尔 德 人 也 被 允 许 回 到 祖 国 ， 和 平 重 新 降 临 在 这 两 个 国 家 。";
					GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
					GlobalScript.inst.gameState.allcountries[8].soc_stab = 1000;
				}
				else
				{
					text = " 随 着 伊 朗 人 民 革 命 联 盟 推 翻 了 伊 斯 兰 神 权 政 府 ， 伊 拉 克 方 面 宣 布 停 止 对 伊 朗 的 军 事 行 动 ， 并 事 实 上 放 弃 了 已 经 半 吞 并 化 的 部 分 胡 齐 斯 坦 和 入 海 口 。 而 新 政 府 也 愿 意 同 伊 拉 克 在 入 海 口 问 题 上 给 予 一 定 让 步 。 双 方 的 关 系 开 始 逐 步 改 善 ， 胡 齐 斯 坦 的 阿 拉 伯 人 也 得 以 选 择 留 在 故 乡 还 是 回 到 伊 拉 克 。 美 苏 双 方 都 感 谢 了 两 伊 的 让 步 。 据 信 萨 达 姆 和 拉 贾 维 已 被 提 名 为 本 年 度 的 诺 贝 尔 和 平 奖 得 主 。";
					GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
					GlobalScript.inst.gameState.allcountries[8].soc_stab = 1000;
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[14].Gosstroy == 1)
			{
				text = "  伊 拉 克 伊 斯 兰 共 和 国 ， 一 个 伊 朗 的 傀 儡 政 府 得 以 建 立 起 来 ， 由 伊 拉 克 什 叶 派 教 士 阿 亚 图 拉 穆 罕 默 德 · 萨 德 克 · 萨 德 尔 担 任 领 袖 。 在 革 命 卫 队 的 簇 拥 下 ， 霍 梅 尼 来 到 了 巴 格 达 ， 狂 热 的 什 叶 派 信 徒 高 呼 着 真 主 的 9 9 个 美 名 ， 高 举 着 祖 菲 卡 尔 剑 旗 和 霍 梅 尼 画 像 为 这 位 领 袖 欢 呼 。||新 政 府 迅 速 开 始 组 建 “ 红 色 暴 徒 罪 行 纠 正 委 员 会 ” 和 “ 伊 拉 克 伊 斯 兰 革 命 法 庭 ” ， 大 批 前 工 农 党 份 子 和 藏 匿 在 伊 拉 克 境 内 的 人 民 圣 战 者 与 人 民 敢 死 队 成 员 纷 纷 被 处 死 。 监 狱 内 的 待 遇 和 萨 达 姆 时 期 的 也 不 逞 多 让 ， 普 通 的 群 众 和 少 数 族 裔 也 处 在 伊 斯 兰 军 事 情 报 局 天 罗 地 网 般 的 监 控 下 。 在 短 短 的 三 天 内 至 少 有 6 0 0 0 名 前 游 击 队 员 和 左 翼 活 动 家 被 处 死 ， 他 们 的 罪 名 通 常 是 莫 哈 雷 贝 （ 与 真 主 交 战 的 人 ） 和 穆 塔 德 （ 伊 斯 兰 教 的 叛 教 者 ） 。 如 果 一 个 普 通 人 被 指 控 为 “ 伪 信 者 ” ， 那 么 特 别 法 警 则 会 迅 速 将 其 带 走 ， 不 经 过 审 讯 便 被 处 死 ， 哪 怕 他 只 是 碰 巧 为 游 击 战 士 送 过 一 瓢 水 。 民 间 性 质 的 私 刑 也 屡 禁 不 止 ， 甚 至 鼓 励 群 众 自 发 的 揪 出 “ 隐 藏 在 我 们 内 部 的 凯 菲 尔 ” 。 阿 布 · 格 莱 布 监 狱 又 一 次 被 政 治 犯 塞 的 满 满 当 当 。 土 耳 其 和 印 度 呼 吁 联 合 国 安 全 理 事 会 设 立 一 个 特 别 法 庭 来 处 理 伊 拉 克 令 人 发 指 的 人 权 问 题 。||伊 斯 兰 革 命 的 热 潮 又 波 及 到 了 另 一 个 国 家 ， 阿 拉 伯 国 家 惊 恐 的 看 着 这 个 前 区 域 性 大 国 的 毁 灭 。 尽 管 仍 然 有 不 屈 的 战 士 拿 起 枪 和 红 旗 ， 但 在 狂 热 的 信 徒 面 前 ， 他 们 又 能 做 些 什 么 呢 ？ 不 过 是 等 待 着 下 一 个 机 会 ， 一 个 渺 茫 的 机 会 … …";
				GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 9;
				GlobalScript.inst.gameState.allcountries[14].Torg = false;
				GlobalScript.inst.gameState.allcountries[14].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[14].puppetOf = 8;
				GlobalScript.inst.gameState.allcountries[14].name = "伊 拉 克";
				GlobalScript.inst.gameState.data[117] = 9;
			}
			else
			{
				GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 9;
				GlobalScript.inst.gameState.allcountries[14].Torg = false;
				GlobalScript.inst.gameState.allcountries[14].prosov = false;
				GlobalScript.inst.gameState.allcountries[14].puppetOf = 8;
				GlobalScript.inst.gameState.allcountries[14].name = "伊 拉 克";
				GlobalScript.inst.gameState.data[117] = 9;
				text = string.Format(GlobalScript.inst.new_events_text[1618], "\n");
			}
		}
		else if (GlobalScript.inst.gameState.data[82] == 4)
		{
			if (!GlobalScript.inst.gameState.event_done[371])
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					GlobalScript.inst.gameState.empires[1].power -= 10;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.allcountries[93].puppetOf = 37;
					text = string.Format(GlobalScript.inst.new_events_text[1619], "\n");
				}
				else
				{
					GlobalScript.inst.gameState.empires[1].power += 10;
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.Israellost = true;
					text = string.Format(GlobalScript.inst.new_events_text[1620], "\n");
				}
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
			{
				text = string.Format(GlobalScript.inst.new_events_text[695], "\n");
				GlobalScript.inst.gameState.allcountries[93].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[93].SubGosstroy = 7;
				GlobalScript.inst.gameState.allcountries[93].puppetOf = 37;
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 500)
			{
				text = string.Format(GlobalScript.inst.new_events_text[696], "\n");
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.allcountries[37].Gosstroy = 0;
				GlobalScript.inst.gameState.Israellost = true;
				GlobalScript.inst.gameState.allcountries[37].SubGosstroy = 9;
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[697], "\n");
				GlobalScript.inst.gameState.Israellost = true;
				GlobalScript.inst.gameState.allcountries[93].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[93].SubGosstroy = 3;
			}
		}
		else if (GlobalScript.inst.gameState.data[82] == 5)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
			{
				if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 0)
				{
					GlobalScript.inst.gameState.empires[1].power += 50;
					text = string.Format(GlobalScript.inst.new_events_text[1624], "\n");
				}
				else if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == -1)
				{
					GlobalScript.inst.gameState.allcountries[12].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[12].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[12].prosov = false;
					GlobalScript.inst.gameState.allcountries[12].proprc = true;
					GlobalScript.inst.gameState.allcountries[12].Torg = true;
					GlobalScript.inst.gameState.allcountries[12].prcpower = 1000;
					GlobalScript.inst.gameState.influencePRC += 100;
					text = " 随 着 最 后 一 批 圣 战 者 被 驱 逐 出 了 阿 富 汗 的 土 地 ， 阿 明 政 府 成 功 的 保 卫 了 人 民 派 和 阿 富 汗 民 主 共 和 国 。 在 战 争 胜 利 之 后 ， 卡 尔 迈 勒 等 前 旗 帜 派 成 员 被 当 作 苏 联 间 谍 处 以 死 刑 。 喀 布 尔 的 主 人 没 有 忘 记 是 谁 向 他 警 告 了 苏 联 人 的 阴 谋 。 在 阿 富 汗 人 民 民 主 党 第 二 届 特 别 代 表 大 会 上 ， 阿 明 邀 请 了 原 先 的 阿 富 汗 人 民 解 放 组 织 成 员 ， 其 中 包 括 了 马 吉 德 · 卡 拉 卡 尼 等 人 ， 加 入 新 的 中 央 政 治 局 常 务 委 员 会 。\n 新 生 的 阿 富 汗 民 主 共 和 国 也 开 始 和 我 们 走 的 越 来 越 近 ， 苏 联 伸 向 印 度 洋 的 黑 手 就 此 被 斩 断 。 同 时 在 我 们 的 指 导 下 ， 新 政 权 开 始 了 新 的 ， 更 加 透 彻 的 土 地 改 革 。 ";
				}
				else if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 1)
				{
					GlobalScript.inst.gameState.allcountries[12].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[12].SubGosstroy = 17;
					GlobalScript.inst.gameState.allcountries[12].prosov = false;
					GlobalScript.inst.gameState.allcountries[12].proprc = true;
					GlobalScript.inst.gameState.allcountries[12].Torg = true;
					GlobalScript.inst.gameState.allcountries[12].prcpower = 1000;
					GlobalScript.inst.gameState.influencePRC += 100;
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(54);
					}
					text = string.Format(GlobalScript.inst.new_events_text[1625], "\n");
				}
			}
			else if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 0)
			{
				GlobalScript.inst.gameState.allcountries[12].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[12].SubGosstroy = 13;
				GlobalScript.inst.gameState.allcountries[12].prosov = false;
				GlobalScript.inst.gameState.allcountries[12].proprc = false;
				GlobalScript.inst.gameState.allcountries[12].Torg = false;
				GlobalScript.inst.gameState.empires[1].power -= 30;
				text = " 最 终 ， 阿 富 汗 的 反 共 圣 战 者 赢 得 了 最 终 胜 利 。 得 益 于 日 复 一 日 治 安 战 中 的 无 用 功 ， 同 时 也 有 阿 富 汗 人 民 民 主 党 政 府 的 力 不 从 心 ， 大 规 模 的 人 民 民 主 党 部 队 一 触 即 溃 ， 几 乎 是 兵 不 血 刃 地 放 任 了 阿 富 汗 伊 斯 兰 联 盟 的 部 队 进 入 了 喀 布 尔 。 然 而 ， 胜 利 对 于 “ 指 挥 官 ” 们 来 的 无 疑 是 太 快 了 。 各 派 军 阀 为 争 权 夺 利 。 展 开 第 二 场 内 战 。 苏 联 也 不 甘 心 于 南 方 堡 垒 的 完 全 丢 失 ， 找 上 了 杜 斯 塔 姆 作 为 自 己 的 代 理 人 。 与 此 同 时 ， 在 西 方 ， 马 苏 德 则 极 力 营 造 自 己 是 唯 一 能 解 决 阿 富 汗 问 题 的 候 选 人 。 局 势 正 在 升 温 ， 从 坎 大 哈 和 边 境 的 难 民 营 里 传 来 对 这 一 幕 幕 荒 唐 而 不 满 的 窃 窃 私 语 ， 看 起 来 对 于 阿 富 汗 人 来 说 和 平 将 会 成 为 漫 长 的 梦 …";
			}
			else if (GlobalScript.inst.gameState.ingamewars[5].ussr_place == 1)
			{
				GlobalScript.inst.gameState.ingamewars[5].name_war = GlobalScript.inst.new_events_text[1621];
				GlobalScript.inst.gameState.ingamewars[5].is_going = true;
				GlobalScript.inst.gameState.ingamewars[5].side1 = GlobalScript.inst.new_events_text[1622];
				GlobalScript.inst.gameState.ingamewars[5].side2 = GlobalScript.inst.new_events_text[1623];
				GlobalScript.inst.gameState.ingamewars[5].ussr_place = 0;
				GlobalScript.inst.gameState.ingamewars[5].usa_place = 1;
				GlobalScript.inst.gameState.ingamewars[5].infl1 = 650;
				GlobalScript.inst.gameState.ingamewars[5].infl2 = 350;
				if (GlobalScript.inst.gameState.allcountries[31].Vyshi)
				{
					GlobalScript.inst.gameState.ingamewars[5].infl1 -= 100;
					GlobalScript.inst.gameState.ingamewars[5].infl2 += 100;
				}
				if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 0)
				{
					GlobalScript.inst.gameState.ingamewars[5].infl1 -= 50;
					GlobalScript.inst.gameState.ingamewars[5].infl2 += 50;
				}
				if (GlobalScript.inst.gameState.data[107] == 9)
				{
					GlobalScript.inst.gameState.ingamewars[5].infl1 += 25;
					GlobalScript.inst.gameState.ingamewars[5].infl2 -= 25;
				}
				text = string.Format(GlobalScript.inst.new_events_text[1627], "\n");
			}
		}
		else if (GlobalScript.inst.gameState.data[82] == 6)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 400)
			{
				GlobalScript.inst.gameState.BritLost = true;
				GlobalScript.inst.gameState.empires[0].power -= 20;
				text = string.Format(GlobalScript.inst.new_events_text[1628], "\n");
			}
			else
			{
				GlobalScript.inst.gameState.empires[0].power += 20;
				text = string.Format(GlobalScript.inst.new_events_text[1629], "\n");
			}
		}
		else if (GlobalScript.inst.gameState.data[82] == 7)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
			{
				if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 0)
				{
					GlobalScript.inst.gameState.allcountries[19].JoinAllOurAlliances(yes: true);
					GlobalScript.inst.gameState.allcountries[19].proprc = true;
					GlobalScript.inst.gameState.allcountries[19].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[19].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[19].soc_stab = 1000;
					GlobalScript.inst.gameState.allcountries[19].Torg = true;
					text = string.Format(GlobalScript.inst.new_events_text[1630], "\n");
				}
				else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 1)
				{
					GlobalScript.inst.gameState.allcountries[19].isSEV = false;
					GlobalScript.inst.gameState.allcountries[19].isOVD = false;
					GlobalScript.inst.gameState.allcountries[19].okb = false;
					GlobalScript.inst.gameState.allcountries[19].econ = false;
					GlobalScript.inst.gameState.allcountries[19].proprc = false;
					GlobalScript.inst.gameState.allcountries[19].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[19].SubGosstroy = 15;
					GlobalScript.inst.gameState.allcountries[19].Torg = false;
					GlobalScript.inst.gameState.allcountries[19].prosov = true;
					text = string.Format(GlobalScript.inst.new_events_text[1632], "\n");
				}
			}
			else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 1)
			{
				GlobalScript.inst.gameState.allcountries[19].JoinAllOurAlliances(yes: true);
				GlobalScript.inst.gameState.allcountries[19].proprc = true;
				GlobalScript.inst.gameState.allcountries[19].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[19].SubGosstroy = 17;
				GlobalScript.inst.gameState.allcountries[19].Torg = true;
				GlobalScript.inst.gameState.allcountries[19].soc_stab = 1000;
				text = string.Format(GlobalScript.inst.new_events_text[1631], "\n");
			}
			else if (GlobalScript.inst.gameState.allcountries[19].numberOfSpecialEnding == 0)
			{
				GlobalScript.inst.gameState.allcountries[19].isSEV = false;
				GlobalScript.inst.gameState.allcountries[19].isOVD = false;
				GlobalScript.inst.gameState.allcountries[19].okb = false;
				GlobalScript.inst.gameState.allcountries[19].econ = false;
				GlobalScript.inst.gameState.allcountries[19].proprc = false;
				GlobalScript.inst.gameState.allcountries[19].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[19].SubGosstroy = 0;
				GlobalScript.inst.gameState.allcountries[19].Torg = false;
				GlobalScript.inst.gameState.allcountries[19].Vyshi = true;
				text = string.Format(GlobalScript.inst.new_events_text[1633], "\n");
			}
		}
		if (GlobalScript.inst.gameState.data[82] == 8)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 500)
			{
				text = string.Format(GlobalScript.inst.new_events_text[612], "\n");
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 800)
			{
				GlobalScript.inst.gameState.allcountries[84].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[84].SubGosstroy = 3;
				GlobalScript.inst.gameState.allcountries[84].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[84].isNATO = false;
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.allcountries[87].spec -= 10;
				GlobalScript.inst.gameState.allcountries[84].cw = true;
				text = string.Format(GlobalScript.inst.new_events_text[613], "\n");
			}
			else
			{
				GlobalScript.inst.gameState.allcountries[84].Gosstroy = 2;
				GlobalScript.inst.gameState.allcountries[84].SubGosstroy = 8;
				GlobalScript.inst.gameState.allcountries[84].Vyshi = false;
				GlobalScript.inst.gameState.allcountries[84].isNATO = false;
				GlobalScript.inst.gameState.empires[0].power -= 30;
				GlobalScript.inst.gameState.allcountries[87].spec -= 5;
				text = string.Format(GlobalScript.inst.new_events_text[614], "\n");
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 9)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 600)
			{
				text = string.Format(GlobalScript.inst.new_events_text[641], "\n");
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 800)
			{
				text = string.Format(GlobalScript.inst.new_events_text[642], "\n");
				GlobalScript.inst.gameState.empires[0].power -= 50;
				GlobalScript.inst.gameState.allcountries[84].Gosstroy = 3;
				GlobalScript.inst.gameState.allcountries[84].SubGosstroy = 4;
				GlobalScript.inst.gameState.influencePRC += 30;
				GlobalScript.inst.gameState.allcountries[84].parts[0] = true;
				GlobalScript.inst.gameState.allcountries[95].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[95].SubGosstroy = 1;
				GlobalScript.inst.gameState.allcountries[95].EstablishGovernment(Government.ProChina);
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[643], "\n");
				GlobalScript.inst.gameState.allcountries[84].Gosstroy = 3;
				GlobalScript.inst.gameState.allcountries[84].SubGosstroy = 4;
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 10)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
			{
				text = string.Format(GlobalScript.inst.new_events_text[682], "\n");
				GlobalScript.inst.gameState.allcountries[35].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[35].SubGosstroy = 9;
				GlobalScript.inst.gameState.allcountries[35].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[35].puppetOf = 84;
				if (GlobalScript.inst.gameState.allcountries[84].Vyshi)
				{
					GlobalScript.inst.gameState.allcountries[35].EstablishGovernment(Government.ProAmerican);
				}
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[683], "\n");
				GlobalScript.inst.gameState.data[124]++;
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 11)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
			{
				text = string.Format(GlobalScript.inst.new_events_text[684], "\n");
				GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 9;
				GlobalScript.inst.gameState.data[117] = 0;
				GlobalScript.inst.gameState.allcountries[14].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[14].puppetOf = 84;
				GlobalScript.inst.gameState.allcountries[14].name = "伊 拉 克";
				if (GlobalScript.inst.gameState.allcountries[14].Vyshi)
				{
					GlobalScript.inst.gameState.allcountries[14].EstablishGovernment(Government.ProAmerican);
				}
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[685], "\n");
				GlobalScript.inst.gameState.data[124]++;
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 12)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
			{
				text = string.Format(GlobalScript.inst.new_events_text[686], "\n");
				GlobalScript.inst.gameState.allcountries[8].Gosstroy = 0;
				GlobalScript.inst.gameState.data[117] = 0;
				GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 9;
				GlobalScript.inst.gameState.allcountries[8].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[8].puppetOf = 84;
				if (GlobalScript.inst.gameState.allcountries[8].Vyshi)
				{
					GlobalScript.inst.gameState.allcountries[8].EstablishGovernment(Government.ProAmerican);
				}
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[687], "\n");
				GlobalScript.inst.gameState.data[124]++;
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 36)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 1000)
			{
				text = " 很 快 ， 日 本 人 民 革 命 阵 线 领 导 人 福 田 正 义 宣 布 正 式 建 立 日 本 社 会 主 义 人 民 共 和 国 。 新 政 府 将 以 毛 主 义 为 指 导 ， 坚 持 无 产 阶 级 专 政 并 尽 快 展 开 战 后 重 建 以 及 全 方 位 的 社 会 主 义 建 设 ， 组 建 新 的 人 民 议 会 ， 开 展 五 年 计 划 。 在 演 讲 中 ， 福 田 正 义 着 重 谈 到 了 过 去 日 本 在 第 二 次 世 界 大 战 中 的 所 作 所 为 。 他 强 调 ： “ 我 们 必 须 为 过 去 我 国 对 中 国 和 亚 洲 其 他 国 家 犯 下 的 累 累 罪 行 进 行 最 深 刻 的 反 思 。 如 果 我 们 因 为 羞 耻 心 而 不 去 直 面 过 去 的 错 误 ， 那 么 法 西 斯 主 义 随 时 都 可 能 卷 土 重 来 。 只 有 这 样 ， 我 们 才 能 真 正 建 设 一 个 更 好 的 社 会 。 ” 在 外 交 方 面 ， 新 政 府 宣 布 将 与 中 国 展 开 全 方 位 合 作 ， 同 时 与 苏 联 和 其 他 社 会 主 义 国 家 展 开 密 切 接 触 ， 寻 求 外 交 承 认 和 物 资 支 持 。||数 小 时 后 ， 我 国 外 交 部 发 言 人 便 正 式 发 表 了 一 份 声 明 ： “ 我 们 热 烈 祝 贺 英 雄 的 日 本 人 民 在 长 期 的 斗 争 后 成 功 挣 脱 了 军 国 主 义 者 、 大 资 产 阶 级 和 欧 美 帝 国 主 义 的 枷 锁 。 日 本 革 命 的 胜 利 象 征 着 历 史 的 新 篇 章 。 我 们 衷 心 希 望 日 本 人 民 能 取 得 更 大 的 胜 利 。 ” 同 时 正 式 承 认 了 新 政 权 的 合 法 性 （ 也 是 第 一 个 承 认 新 政 权 的 国 家 ） 。 数 日 后 ， 第 一 批 支 援 日 本 新 政 府 进 行 战 后 重 建 的 物 资 就 将 送 达 。 ";
				GlobalScript.inst.gameState.allcountries[44].Gosstroy = 1;
				GlobalScript.inst.gameState.allcountries[44].SubGosstroy = 17;
				GlobalScript.inst.gameState.allcountries[44].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[44].JoinAllOurAlliances(yes: true);
				GlobalScript.inst.gameState.allcountries[44].proprc = true;
				GlobalScript.inst.gameState.allcountries[44].name = " 日 本 社 会 主 义 人 民 共 和 国";
				GlobalScript.inst.gameState.allcountries[44].Torg = true;
				GlobalScript.inst.gameState.influencePRC += 100;
				GlobalScript.inst.gameState.empires[0].relations = 0;
				GlobalScript.inst.gameState.empires[0].power -= 100;
			}
			else
			{
				text = " 在 得 到 人 力 物 力 支 援 后 ， 日 本 人 民 革 命 阵 线 迅 速 夺 取 了 九 州 、 四 国 、 北 海 道 等 地 的 地 方 政 权 。 但 由 于 部 分 地 区 的 革 命 军 实 力 不 足 ， 加 之 他 们 的 行 动 速 度 不 够 快 ， 导 致 当 地 的 自 卫 队 和 警 方 能 够 有 所 反 应 并 做 出 了 一 定 准 备 。 因 此 革 命 军 在 这 些 地 区 的 攻 势 受 到 了 阻 碍 。 为 了 争 取 抢 在 敌 人 反 应 过 来 之 前 夺 取 胜 利 ， 革 命 军 决 定 专 注 于 东 京 这 一 核 心 ， 集 结 精 锐 部 队 加 紧 向 这 座 城 市 进 发 ， 同 时 派 出 部 分 工 人 赤 卫 队 对 美 军 基 地 进 行 了 全 面 封 锁 。 而 陷 入 恐 慌 的 日 本 政 府 立 刻 与 美 国 和 其 他 北 约 成 员 国 进 行 联 系 ， 希 望 美 国 借 它 们 的 力 量 平 息 革 命 。||美 国 得 知 这 一 情 况 后 大 为 震 惊 ， 总 统 与 其 幕 僚 团 队 即 刻 停 下 了 手 头 的 一 切 事 务 ， 并 就 日 本 民 众 起 义 一 事 联 系 国 会 两 党 高 层 和 军 方 人 士 展 开 紧 急 磋 商 。 数 小 时 的 会 议 后 ， 所 有 人 一 致 同 意 展 开 特 别 军 事 行 动 。 为 了 表 明 决 心 ， 美 国 不 惜 放 弃 其 在 欧 洲 的 部 分 利 益 给 苏 东 阵 营 也 要 以 最 快 的 速 度 派 兵 前 往 日 本 。 正 如 时 任 美 国 国 务 卿 在 后 来 记 者 会 上 的 声 明 所 说 ： “ 这 样 的 暴 力 行 为 是 绝 不 可 接 受 的 ， 这 是 对 自 由 和 人 权 的 侵 犯 。 美 国 并 非 要 发 起 战 争 占 领 日 本 ， 我 们 的 目 标 只 有 一 个 ： 将 日 本 民 众 从 一 小 撮 受 到 他 国 挑 唆 的 共 产 主 义 暴 徒 的 威 胁 与 恐 吓 下 解 放 出 来 ， 从 而 恢 复 真 正 的 自 由 与 民 主 。 ” 很 快 ， 美 国 海 军 陆 战 队 便 作 为 第 一 批 部 队 登 陆 日 本 本 土 。 首 先 便 驱 散 了 负 责 封 锁 美 军 基 地 的 革 命 军 。 之 后 在 日 本 自 卫 队 和 警 方 的 帮 助 下 ， 开 始 了 对 革 命 军 的 残 酷 打 击 。 革 命 阵 线 进 行 了 英 勇 的 抵 抗 ， 但 最 终 还 是 不 敌 精 锐 的 美 军 部 队 。 最 终 ， 革 命 军 的 全 部 据 点 都 被 拔 除 ， 日 本 人 民 革 命 阵 线 领 导 人 福 田 正 义 与 其 他 高 层 带 领 残 余 的 革 命 部 队 在 我 们 的 帮 助 下 来 到 我 国 并 得 到 了 妥 善 安 置 。 轰 轰 烈 烈 的 日 本 革 命 最 终 还 是 失 败\t了 … …||在 美 国 的 直 接 干 预 下 ， 以 自 由 民 主 党 内 强 硬 反 共 保 守 派 为 核 心 的 新 政 党 日 本 共 和 党 成 为 新 政 府 的 领 导 力 量 。 而 美 军 将 在 对 革 命 者 的 审 判 和 战 后 重 建 结 束 之 前 保 持 在 日 本 全 境 范 围 内 的 驻 军 。 新 政 府 开 始 全 面 清 算 残 余 左 翼 势 力 ， 打 击 工 会 ， 扶 植 大 企 业 ， 展 开 全 面 新 自 由 主 义 改 革 并 在 美 国 许 可 后 正 式 查 封 了 社 会 党 这 一 传 统 左 翼 党 派 。 在 外 交 上 ， 新 政 府 将 带 领 日 本 彻 底 投 入 美 国 和 北 约 的 怀 抱 中 ， 并 断 绝 了 同 我 们 和 苏 联 以 及 社 会 主 义 阵 营 的 一 切 联 系 。 甚 至 据 一 些 小 道 消 息 表 示 ， 日 本 政 府 正 在 计 划 申 请 加 入 北 约 。";
				GlobalScript.inst.gameState.allcountries[44].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[44].SubGosstroy = 7;
				GlobalScript.inst.gameState.allcountries[44].LeaveAlliances();
				GlobalScript.inst.gameState.allcountries[44].Torg = false;
				GlobalScript.inst.gameState.allcountries[44].isNATO = true;
				GlobalScript.inst.gameState.allcountries[44].Vyshi = true;
				GlobalScript.inst.gameState.influencePRC -= 100;
				GlobalScript.inst.gameState.empires[0].relations = 0;
				GlobalScript.inst.gameState.empires[0].power += 100;
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 14)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
			{
				int num = (byte)UnityEngine.Random.Range(60, 95);
				text = string.Format(GlobalScript.inst.new_events_text[745], "\n", num);
				GlobalScript.inst.gameState.allcountries[94].name = GlobalScript.inst.new_events_text[735];
				GlobalScript.inst.gameState.allcountries[94].Gosstroy = 0;
				GlobalScript.inst.gameState.allcountries[94].SubGosstroy = 9;
				GlobalScript.inst.gameState.allcountries[84].parts[4] = true;
				if (GlobalScript.inst.gameState.iron_and_blood && GlobalScript.inst.gameState.allcountries[14].puppetOf == 84 && GlobalScript.inst.gameState.allcountries[8].puppetOf == 84 && GlobalScript.inst.gameState.allcountries[35].puppetOf == 84)
				{
					gameObject.GetComponent<achievements>().Set(134);
				}
				if (GlobalScript.inst.gameState.allcountries[14].puppetOf == 84 && GlobalScript.inst.gameState.allcountries[8].puppetOf == 84 && GlobalScript.inst.gameState.allcountries[35].puppetOf == 84)
				{
					text += " ||更 加 出 人 意 料 的 事 发 生 了 ： 在 土 耳 其 占 领 了 塞 浦 路 斯 后 不 到 一 周 ， 已 经 被 扶 持 了 法 西 斯 主 义 傀 儡 政 权 的 伊 朗 、 伊 拉 克 与 叙 利 亚 三 国 执 政 党 几 乎 在 同 时 举 行 了 内 容 完 全 相 同 的 全 民 公 投 ， 以 9 9 . 9 % 的 的 支 持 率 一 致 决 定 ， 为 了 应 对 周 边 国 家 的 威 胁 （ 叙 利 亚 认 为 来 自 以 色 列 与 海 湾 国 家 ， 伊 朗 认 为 来 自 阿 富 汗 与 巴 基 斯 坦 ， 而 伊 拉 克 认 为 来 自 科 威 特 ） ， 与 土 耳 其 组 成 平 等 联 邦 才 能 保 证 自 身 安 全 ， 一 个 旧 日 帝 国 的 残 影 似 乎 在 中 东 与 欧 洲 的 交 界 处 复 活 了 … …";
					GlobalScript.inst.gameState.allcountries[84].parts[5] = true;
					GlobalScript.inst.gameState.allcountries[84].name = GlobalScript.inst.new_events_text[784];
				}
				GlobalScript.inst.gameState.allcountries[94].LeaveAlliances();
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 500)
			{
				GlobalScript.inst.gameState.data[127] = 1;
				GlobalScript.inst.gameState.data[129] = 1;
				text = string.Format(GlobalScript.inst.new_events_text[746], "\n");
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[747], "\n");
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 15)
		{
			if (!GlobalScript.inst.gameState.event_done[588])
			{
				if (GlobalScript.inst.gameState.allcountries[41].Gosstroy == 1)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
					{
						text = " 巴 雷 的 梦 想 得 以 成 真 ！ 索 马 里 领 导 人 成 功 他 的 祖 国 赢 下 了 欧 加 登 ， 其 政 权 也 大 大 巩 固 。";
						GlobalScript.inst.gameState.allcountries[41].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProSoviet);
						GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 10;
						GlobalScript.inst.gameState.empires[1].power += 20;
						GlobalScript.inst.gameState.allcountries[42].parts[0] = true;
					}
					else
					{
						text = " 埃 塞 俄 比 亚 政 府 成 功 将 索 马 里 部 队 赶 出 了 欧 加 登 ， 并 逼 迫 索 马 里 方 签 署 了 和 平 协 定 。";
						GlobalScript.inst.gameState.allcountries[41].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProSoviet);
						GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 10;
						GlobalScript.inst.gameState.influencePRC += 10;
					}
				}
				else if (GlobalScript.inst.gameState.allcountries[41].proprc)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
					{
						text = " 巴 雷 的 梦 想 得 以 成 真 ！ 索 马 里 领 导 人 成 功 他 的 祖 国 赢 下 了 欧 加 登 ， 其 政 权 也 大 大 巩 固 。";
						GlobalScript.inst.gameState.allcountries[41].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProSoviet);
						GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 10;
						GlobalScript.inst.gameState.empires[1].power += 20;
						GlobalScript.inst.gameState.allcountries[42].parts[0] = true;
					}
					else
					{
						text = " 埃 塞 俄 比 亚 政 府 成 功 将 索 马 里 部 队 赶 出 了 欧 加 登 ， 并 逼 迫 索 马 里 方 签 署 了 和 平 协 定 。";
						GlobalScript.inst.gameState.allcountries[41].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProSoviet);
						GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 10;
						GlobalScript.inst.gameState.influencePRC += 10;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
				{
					text = string.Format(GlobalScript.inst.new_events_text[796], "\n");
					GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[42].Torg = true;
					GlobalScript.inst.gameState.influencePRC += 10;
					GlobalScript.inst.gameState.allcountries[42].parts[0] = true;
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[797], "\n");
					GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 10;
					GlobalScript.inst.gameState.empires[1].power += 20;
				}
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
			{
				text = " 出 乎 所 有 人 的 意 料 ， 孱 弱 的 索 马 里 陆 军 得 以 击 溃 装 备 优 良 的 埃 塞 俄 比 亚 军 队 。 埃 塞 俄 比 亚 的 穿 插 战 略 反 而 导 致 了 步 兵 与 装 甲 部 队 的 失 联 ， 进 而 导 致 先 头 部 队 团 灭 。 第 一 次 进 攻 发 生 在 贝 莱 德 韦 恩 附 近 的 边 境 城 镇 费 佛 尔 ， 试 图 占 领 俯 瞰 连 接 索 马 里 北 部 和 南 部 的 重 要 道 路 的 高 地 。 最 初 ， 索 马 里 军 队 在 发 生 入 侵 的 地 区 只 有 1 8 0 0 名 士 兵 ， 但 很 快 就 得 到 了 增 援 。 尽 管 遭 到 了 猛 烈 的 地 面 和 空 中 攻 击 ， 但 驻 扎 在 贝 莱 德 韦 恩 镇 附 近 的 索 马 里 军 队 驻 军 还 是 对 入 侵 部 队 造 成 了 重 大 损 失 。 从 此 开 始 ， 索 马 里 得 以 转 败 为 胜 ， 并 在 多 方 支 持 下 攻 入 欧 加 登 地 区 ， 他 们 甚 至 找 到 了 上 一 次 战 争 时 遗 留 下 来 的 装 甲 车 和 辎 重 。 埃 塞 俄 比 亚 不 得 不 接 受 了 自 己 的 失 败 并 承 认 了 索 马 里 对 欧 加 登 的 占 领 。||随 后 ， 一 场 未 遂 政 变 在 埃 塞 俄 比 亚 爆 发 了 ， 游 击 队 也 抓 住 了 这 个 机 会 ， 开 始 向 军 委 政 权 加 大 攻 势 。";
				if (!GlobalScript.inst.gameState.allcountries[42].proprc && GlobalScript.inst.gameState.allcountries[41].prosov)
				{
					GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[42].Torg = true;
					GlobalScript.inst.gameState.influencePRC += 10;
				}
				if (GlobalScript.inst.gameState.allcountries[42].parts[1])
				{
					GlobalScript.inst.gameState.allcountries[42].parts[1] = false;
					GlobalScript.inst.gameState.allcountries[42].parts[2] = true;
					text += " ||大 索 马 里 的 梦 终 于 成 真 ！";
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[42].parts[0] = true;
				}
			}
			else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
			{
				text = " 在 久 经 沙 场 的 埃 塞 俄 比 亚 老 将 们 眼 里 ， 索 军 果 然 如 同 他 们 期 望 的 一 触 即 溃 了 ， 西 亚 德 逃 往 了 尼 日 利 亚 。 阿 卜 杜 拉 希 · 优 素 福 上 校 得 以 夺 权 ， 在 组 建 了 索 马 里 统 一 民 主 党 后 ， 该 国 宣 布 和 埃 塞 俄 比 亚 合 并 ， 卡 斯 特 罗 构 想 中 的 埃 - 索 联 邦 得 以 成 立 。 但 是 仍 然 有 不 小 的 问 题 ， 该 国 庞 大 的 部 族 网 络 和 伊 斯 兰 主 义 游 击 队 正 在 吞 噬 新 来 的 主 人 ， 埃 塞 俄 比 亚 陷 入 了 战 略 困 境 - 倘 若 立 即 撤 出 索 马 里 ， 那 么 在 索 马 里 的 傀 儡 政 权 必 然 崩 溃 。 但 如 果 不 撤 出 ， 那 么 沙 漠 将 吞 没 埃 塞 好 儿 郎 的 热 血 。 不 用 说 ， 西 方 国 家 的 制 裁 让 事 情 雪 上 加 霜 了 。 虽 然 " + (GlobalScript.inst.gameState.allcountries[41].prosov ? "苏 联 " : " 中 国") + " 对 革 命 战 果 很 是 高 兴 ， 但 一 切 都 一 切 只 能 交 给 时 间 评 判 了 。";
				GlobalScript.inst.gameState.allcountries[41].parts[0] = true;
				if (GlobalScript.inst.gameState.allcountries[42].parts[1] || GlobalScript.inst.gameState.allcountries[42].parts[2])
				{
					text += "|| 肯 尼 亚 瞅 准 了 埃 塞 深 陷 对 索 马 里 治 安 战 泥 潭 的 机 会 ， 趁 机 出 兵 收 回 了 东 北 省 失 地 ， 现 在 的 埃 塞 自 然 是 无 暇 顾 及 此 事 ， 但 安 稳 下 来 的 埃 塞 是 否 会 对 肯 尼 亚 旧 事 重 提 试 图 收 回 “ 故 土 ” ？ 让 我 们 拭 目 以 待 。";
					GlobalScript.inst.gameState.allcountries[42].parts[1] = false;
					GlobalScript.inst.gameState.allcountries[42].parts[2] = false;
				}
				if (GlobalScript.inst.gameState.allcountries[106].SubGosstroy == 10)
				{
					text += "|| 已 经 接 受 了 埃 塞 俄 比 亚 特 色 革 命 共 产 主 义 的 吉 布 提 也 在 战 后 第 一 时 间 就 提 出 了 合 并 入 埃 塞 俄 比 亚 协 助 “ 维 稳 ” 索 马 里 的 申 请 ， 不 出 意 料 地 被 迅 速 通 过 了 ， 非 洲 之 角 的 最 后 一 片 拼 图 已 然 归 位 … …";
					GlobalScript.inst.gameState.allcountries[41].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[41].parts[1] = true;
				}
				GlobalScript.inst.gameState.allcountries[41].Torg = true;
				GlobalScript.inst.gameState.empires[1].power += 20;
			}
			else
			{
				text = " 不 管 是 装 备 先 进 但 战 斗 力 低 下 的 埃 塞 人 ， 还 是 战 斗 意 志 顽 强 却 离 心 离 德 的 索 马 里 人 ， 无 人 得 胜 。 边 境 战 争 后 ， 西 亚 德 · 巴 雷 总 统 在 1 9 8 2 年 的 阿 拉 伯 联 盟 峰 会 上 得 到 了 一 些 口 头 支 持 。 但 巴 雷 在 1 9 8 2 年 摇 摇 欲 墜 的 权 力 暂 时 得 到 了 加 强 。 ";
				if (!GlobalScript.inst.gameState.allcountries[42].Vyshi && !GlobalScript.inst.gameState.allcountries[42].prosov)
				{
					text += " ||巴 雷 感 谢 白 宫 方 面 兑 现 承 诺 ， 他 正 式 把 马 克 思 列 宁 主 义 的 内 容 从 索 马 里 革 命 社 会 主 义 党 的 章 程 中 剔 除 出 去 ， 并 公 开 采 纳 了 市 场 经 济 ， 他 越 来 越 依 赖 于 美 国 的 援 助。";
					GlobalScript.inst.gameState.allcountries[42].EstablishGovernment(Government.ProAmerican);
					GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 7;
					GlobalScript.inst.gameState.empires[0].power += 20;
				}
			}
			GlobalScript.inst.gameState.data[82] = -10;
			return true;
		}
		if (GlobalScript.inst.gameState.data[82] == 16)
		{
			if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
			{
				GlobalScript.inst.gameState.data[158] = 1;
				GlobalScript.inst.gameState.empires[1].power -= 50;
				GlobalScript.inst.gameState.data[7] += 50;
				GlobalScript.inst.gameState.allcountries[10].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
				GlobalScript.inst.gameState.allcountries[10].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
				GlobalScript.inst.gameState.allcountries[10].JoinAllOurAlliances(yes: true).EstablishGovernment(Government.ProChina);
				GlobalScript.inst.gameState.allcountries[10].puppetOf = 1;
				GlobalScript.inst.gameState.allcountries[10].Torg = true;
				int num2;
				if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 0)
				{
					GlobalScript.inst.gameState.allcountries[10].name = GlobalScript.inst.new_events_text[840];
					num2 = 1;
				}
				else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 1)
				{
					GlobalScript.inst.gameState.allcountries[10].name = GlobalScript.inst.new_events_text[841];
					num2 = 2;
				}
				else if (GlobalScript.inst.gameState.allcountries[1].Gosstroy == 2)
				{
					GlobalScript.inst.gameState.allcountries[10].name = GlobalScript.inst.new_events_text[842];
					num2 = 3;
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[10].name = GlobalScript.inst.new_events_text[843];
					num2 = 4;
				}
				if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 18)
				{
					GlobalScript.inst.gameState.empires[1].relations += 120;
					GlobalScript.inst.gameState.empires[0].relations -= 120;
				}
				if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy < 18)
				{
					text = string.Format(GlobalScript.inst.new_events_text[844], "\n", GlobalScript.inst.new_events_text[845 + num2], GlobalScript.inst.new_events_text[849 + num2], GlobalScript.inst.new_events_text[983 + GlobalScript.inst.gameState.allcountries[10].SubGosstroy]);
				}
				else if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 18)
				{
					text = string.Format(GlobalScript.inst.new_events_text[844], "\n", GlobalScript.inst.new_events_text[845 + num2], GlobalScript.inst.new_events_text[849 + num2], GlobalScript.inst.new_events_text[1187]);
				}
				else if (GlobalScript.inst.gameState.allcountries[10].SubGosstroy == 19)
				{
					text = string.Format(GlobalScript.inst.new_events_text[844], "\n", GlobalScript.inst.new_events_text[845 + num2], GlobalScript.inst.new_events_text[849 + num2], " 在 经 历 了 激 烈 的 战 斗 后 ， 人 民 解 放 军 踏 入 平 壤 城 内 ， 金 日 成 最 终 被 以 “ 试 图 分 裂 社 会 主 义 阵 营 ， 破 坏 中 朝 友 谊 ” 和 反 革 命 等 罪 行 被 关 入 监 狱 ， 其 亲 戚 同 样 被 关 入 劳 改 营 内 。 在 我 们 的 苦 苦 寻 找 下 ， 朝 鲜 北 部 的 孔 子 后 裔 、 政 治 局 候 补 委 员 和 国 家 计 划 委 员 会 委 员 长 孔 镇 泰 被 包 装 成 证 明 中 朝 友 好 关 系 和 红 色 血 统 的 代 表 。 虽 然 儒 学 在 我 们 的 地 位 比 较 尴 尬 ， 但 是 有 了 孔 镇 泰 的 案 例 ， 我 们 可 以 对 儒 学 进 行 “ 适 应 我 国 社 会 主 义 社 会 ” 的 改 造 。 同 样 的 ， 我 们 在 进 行 批 林 批 孔 中 开 始 扭 转 了 宣 传 方 向 ， 强 调 “ 孔 ” 也 是 可 以 改 造 的 ， 儒 法 之 争 虽 然 依 旧 比 较 偏 向 于 法 家 ， 但 是 对 于 改 造 后 的 红 儒 则 开 始 受 欢 迎 和 推 崇 起 来 ， 正 如 前 人 所 言 ： “ 打 倒 孔 家 店 ， 救 出 孔 夫 子 ” 。 我 们 也 因 此 得 以 放 开 手 脚 去 宣 扬 中 朝 友 谊 和 红 色 孔 子 后 裔 。");
				}
			}
			else
			{
				text = string.Format(GlobalScript.inst.new_events_text[845], "\n");
				GlobalScript.inst.gameState.empires[1].power += 70;
				GlobalScript.inst.gameState.data[8] -= 500;
				GlobalScript.inst.gameState.data[22] -= 500;
				GlobalScript.inst.gameState.data[7] -= 100;
				Politic[] array = GlobalScript.inst.gameState.politics;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].loyality -= 750;
				}
			}
		}
		else
		{
			if (GlobalScript.inst.gameState.data[82] == 17)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
				{
					GlobalScript.inst.gameState.empires[1].power -= 100;
					GlobalScript.inst.gameState.empires[0].power -= 100;
					GlobalScript.inst.gameState.influencePRC += 150;
					GlobalScript.inst.gameState.allcountries[15].Torg = true;
					text = string.Format(GlobalScript.inst.new_events_text[882], "\n");
				}
				else
				{
					for (int j = 0; j < GlobalScript.inst.gameState.allcountries.Length; j++)
					{
						if (GlobalScript.inst.gameState.allcountries[j].isOVD)
						{
							GlobalScript.inst.gameState.allcountries[j].LeaveWP().EstablishGovernment(Government.ProSoviet).JoinNATO()
								.JoinComecon();
							GlobalScript.inst.gameState.influencePRC -= 200;
							GlobalScript.inst.gameState.allcountries[j].Torg = false;
							GlobalScript.inst.gameState.allcountries[j].Gosstroy = GlobalScript.inst.gameState.allcountries[7].Gosstroy;
							GlobalScript.inst.gameState.allcountries[j].SubGosstroy = GlobalScript.inst.gameState.allcountries[7].SubGosstroy;
						}
					}
					GlobalScript.inst.gameState.allcountries[3].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[3].name = GlobalScript.inst.new_events_text[881];
					Politic[] array2 = GlobalScript.inst.gameState.politics;
					for (int k = 0; k < array2.Length; k++)
					{
						array2[k].loyality -= 400;
					}
					text = string.Format(GlobalScript.inst.new_events_text[883], "\n");
				}
				GlobalScript.inst.gameState.data[82] = -10;
				return true;
			}
			if (GlobalScript.inst.gameState.data[82] == 18)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[918], "\n");
					GlobalScript.inst.gameState.data[7] += 50;
					GlobalScript.inst.gameState.allcountries[20].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[15].Vyshi = true;
					GlobalScript.inst.gameState.allcountries[15].JoinEU();
					GlobalScript.inst.gameState.allcountries[15].SubGosstroy = 14;
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[919], "\n");
					GlobalScript.inst.gameState.allcountries[20].SubGosstroy = GlobalScript.inst.gameState.allcountries[15].SubGosstroy;
					GlobalScript.inst.gameState.allcountries[20].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[20].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[20].puppetOf = 15;
					GlobalScript.inst.gameState.allcountries[20].proprc = false;
					GlobalScript.inst.gameState.data[7] -= 50;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 19)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[932], "\n");
					if (GlobalScript.inst.gameState.allcountries[20].proprc)
					{
						GlobalScript.inst.gameState.data[7] -= 100;
					}
					GlobalScript.inst.gameState.allcountries[20].parts[1] = true;
					GlobalScript.inst.gameState.allcountries[20].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[20].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[20].proprc = false;
					GlobalScript.inst.gameState.allcountries[20].Torg = false;
					if (GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(133);
					}
					GlobalScript.inst.gameState.allcountries[20].name = GlobalScript.inst.new_events_text[935];
					GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[45].Torg = false;
					GlobalScript.inst.gameState.allcountries[45].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[45].SubGosstroy = 7;
					if (GlobalScript.inst.gameState.allcountries[51].isNATO)
					{
						GlobalScript.inst.gameState.allcountries[45].isNATO = true;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 700)
				{
					if (GlobalScript.inst.gameState.allcountries[51].isNATO)
					{
						text = string.Format(GlobalScript.inst.new_events_text[933], "\n");
						GlobalScript.inst.gameState.allcountries[20].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[20].proprc = false;
						GlobalScript.inst.gameState.allcountries[20].Torg = false;
						GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[45].isNATO = true;
						GlobalScript.inst.gameState.allcountries[45].Gosstroy = 3;
						GlobalScript.inst.gameState.allcountries[45].Gosstroy = 5;
					}
					else if (!GlobalScript.inst.gameState.allcountries[51].isNATO && GlobalScript.inst.gameState.empires[1].power > GlobalScript.inst.gameState.influencePRC)
					{
						text = " 这 次 ， 阿 尔 巴 尼 亚 并 没 有 成 功 — — 希 腊 军 队 得 以 击 退 入 侵 者 。 出 于 对 希 腊 方 继 续 进 攻 的 担 忧 ， 阿 尔 巴 尼 亚 选 择 求 和 。 然 而 ， 希 腊 方 拒 绝 谈 和 。 直 到 发 罗 拉 落 入 希 腊 军 之 手 时 ， 才 考 虑 和 平 提 议 的 可 能 。 阿 尔 巴 尼 亚 社 会 主 义 人 民 共 和 国 不 得 不 同 意 支 付 巨 额 赔 款 ， 并 撤 出 在 希 腊 的 部 队 。 希 腊 则 仍 将 一 支 人 数 为 7 5 0 0 人 的 部 队 驻 扎 在 阿 尔 巴 尼 亚 南 部 。||阿 尔 巴 尼 亚 的 战 败 激 化 了 阿 尔 巴 尼 亚 精 英 的 党 内 斗 争 。 最 后 ， 以 法 托 斯 · 纳 诺 为 代 表 的 技 术 官 僚 派 取 得 了 胜 利 ， 他 们 开 始 实 行 经 济 改 革 ， 并 推 动 与 邻 国 关 系 的 正 常 化 。||而 在 希 腊 这 边 ， 泛 希 腊 社 会 主 义 运 动 与 希 腊 共 产 党 的 联 合 政 府 则 遭 到 了 诘 难 ： 正 是 因 为 他 们 带 领 该 国 退 出 了 北 约 ， 阿 尔 巴 尼 亚 才 可 能 对 希 腊 发 动 侵 略 战 争 。 泛 希 腊 社 会 主 义 运 动 的 右 翼 则 承 认 了 这 一 指 控 ， 并 同 新 民 主 党 建 立 联 盟 ， 从 而 逼 迫 失 去 议 会 多 数 的 左 翼 政 府 下 台 。 鉴 于 北 约 已 经 解 散 ， 新 一 届 希 腊 政 府 已 经 向 苏 联 提 交 申 请 ， 申 请 加 入 华 沙 条 约 以 寻 求 庇 护 ， 苏 联 方 面 欣 然 同 意 了 。";
						GlobalScript.inst.gameState.allcountries[20].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[20].proprc = false;
						GlobalScript.inst.gameState.allcountries[20].Torg = false;
						GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[45].isOVD = true;
						GlobalScript.inst.gameState.allcountries[45].Gosstroy = 3;
						GlobalScript.inst.gameState.allcountries[45].Gosstroy = 5;
					}
					else if (!GlobalScript.inst.gameState.allcountries[51].isNATO && GlobalScript.inst.gameState.empires[1].power <= GlobalScript.inst.gameState.influencePRC)
					{
						text = " 这 次 ， 阿 尔 巴 尼 亚 并 没 有 成 功 — — 希 腊 军 队 得 以 击 退 入 侵 者 。 出 于 对 希 腊 方 继 续 进 攻 的 担 忧 ， 阿 尔 巴 尼 亚 选 择 求 和 。 然 而 ， 希 腊 方 拒 绝 谈 和 。 直 到 发 罗 拉 落 入 希 腊 军 之 手 时 ， 才 考 虑 和 平 提 议 的 可 能 。 阿 尔 巴 尼 亚 社 会 主 义 人 民 共 和 国 不 得 不 同 意 支 付 巨 额 赔 款 ， 并 撤 出 在 希 腊 的 部 队 。 希 腊 则 仍 将 一 支 人 数 为 7 5 0 0 人 的 部 队 驻 扎 在 阿 尔 巴 尼 亚 南 部 。||阿 尔 巴 尼 亚 的 战 败 激 化 了 阿 尔 巴 尼 亚 精 英 的 党 内 斗 争 。 最 后 ， 以 法 托 斯 · 纳 诺 为 代 表 的 技 术 官 僚 派 取 得 了 胜 利 ， 他 们 开 始 实 行 经 济 改 革 ， 并 推 动 与 邻 国 关 系 的 正 常 化 。||而 在 希 腊 这 边 ， 泛 希 腊 社 会 主 义 运 动 与 希 腊 共 产 党 的 联 合 政 府 则 遭 到 了 诘 难 ： 正 是 因 为 他 们 带 领 该 国 退 出 了 北 约 ， 阿 尔 巴 尼 亚 才 可 能 对 希 腊 发 动 侵 略 战 争 。 泛 希 腊 社 会 主 义 运 动 的 右 翼 则 承 认 了 这 一 指 控 ， 并 同 新 民 主 党 建 立 联 盟 ， 从 而 逼 迫 失 去 议 会 多 数 的 左 翼 政 府 下 台 。 鉴 于 北 约 已 经 解 散 ， 新 一 届 希 腊 政 府 已 经 向 中 国 提 交 申 请 ， 申 请 加 入 集 体 安 全 条 约 以 寻 求 庇 护 ， 我 们 欣 然 同 意 了 。";
						GlobalScript.inst.gameState.allcountries[20].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[20].proprc = false;
						GlobalScript.inst.gameState.allcountries[20].Torg = false;
						GlobalScript.inst.gameState.allcountries[20].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[45].okb = true;
						GlobalScript.inst.gameState.allcountries[45].Gosstroy = 3;
						GlobalScript.inst.gameState.allcountries[45].Gosstroy = 5;
					}
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[934], "\n");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 20)
			{
				if (GlobalScript.inst.gameState.resultOfEvents[512] == 2)
				{
					text = " 新 政 府 宣 布 停 止 插 手 乍 得 的 无 趣 战 争 ， 一 场 突 如 其 来 的 战 争 就 这 样 莫 名 其 妙 的 结 束 了 ， 非 洲 的 事 情 就 是 这 么 奇 怪 。";
					GlobalScript.inst.gameState.data[132] = 2;
					GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
					GlobalScript.inst.gameState.data[143] -= 3;
					GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[57].Vyshi = true;
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1006], "\n");
					GlobalScript.inst.gameState.allcountries[13].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[13].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[13].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[57].puppetOf = 13;
					GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 10;
					GlobalScript.inst.gameState.data[132] = 1;
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 600)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1007], "\n");
					GlobalScript.inst.gameState.data[132] = 2;
					GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
					GlobalScript.inst.gameState.data[143] -= 3;
					GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[57].Vyshi = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 21)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					if (GlobalScript.inst.gameState.allcountries[25].Vyshi)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1020], "\n");
						GlobalScript.inst.gameState.allcountries[25].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[25].name = GlobalScript.inst.new_events_text[1019];
						GlobalScript.inst.gameState.allcountries[25].Torg = true;
						GlobalScript.inst.gameState.allcountries[24].prosov = false;
						GlobalScript.inst.gameState.empires[1].power -= 25;
						GlobalScript.inst.gameState.empires[0].power += 25;
					}
					else if (GlobalScript.inst.gameState.allcountries[25].proprc)
					{
						text = " 在 中 国 的 帮 助 下 ， 北 也 门 部 队 成 功 拿 下 了 南 也 门 的 首 都 亚 丁 。 南 也 门 的 部 队 最 终 溃 败 并 停 止 抵 抗 ， 该 国 本 身 也 被 北 也 门 所 吞 并 。";
						GlobalScript.inst.gameState.allcountries[25].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[25].name = GlobalScript.inst.new_events_text[1019];
						GlobalScript.inst.gameState.allcountries[25].Torg = true;
						GlobalScript.inst.gameState.allcountries[24].prosov = false;
						GlobalScript.inst.gameState.empires[1].power -= 25;
						GlobalScript.inst.gameState.influencePRC += 25;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					if (GlobalScript.inst.gameState.allcountries[24].prosov)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1021], "\n");
						GlobalScript.inst.gameState.allcountries[24].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[24].Torg = true;
						GlobalScript.inst.gameState.allcountries[24].name = GlobalScript.inst.new_events_text[1019];
						GlobalScript.inst.gameState.allcountries[25].Vyshi = false;
						GlobalScript.inst.gameState.empires[0].power -= 25;
						GlobalScript.inst.gameState.empires[1].power += 25;
					}
					else if (GlobalScript.inst.gameState.allcountries[24].proprc)
					{
						text = " 在 中 国 以 及 当 地 苏 军 的 帮 助 下 ， 南 也 门 部 队 成 功 拿 下 了 北 也 门 的 首 都 萨 那 。 北 也 门 的 部 队 最 终 溃 败 并 停 止 抵 抗 ， 该 国 本 身 也 被 南 也 门 所 吞 并 。";
						GlobalScript.inst.gameState.allcountries[24].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[24].Torg = true;
						GlobalScript.inst.gameState.allcountries[24].name = GlobalScript.inst.new_events_text[1019];
						GlobalScript.inst.gameState.allcountries[25].Vyshi = false;
						GlobalScript.inst.gameState.empires[0].power -= 25;
						GlobalScript.inst.gameState.influencePRC += 25;
					}
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1022], "\n");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 22)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1035], "\n");
					GlobalScript.inst.gameState.data[133] = 1;
					GlobalScript.inst.gameState.empires[1].relations = 0;
					GlobalScript.inst.gameState.empires[1].power -= 100;
					GlobalScript.inst.gameState.data[7] += 100;
					GlobalScript.inst.gameState.data[3] += 150;
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1036], "\n");
					GlobalScript.inst.gameState.data[133] = 3;
					GlobalScript.inst.gameState.empires[1].power += 100;
					GlobalScript.inst.gameState.empires[1].relations = 0;
					GlobalScript.inst.gameState.data[3] -= 600;
					GlobalScript.inst.gameState.data[4] += 900;
					GlobalScript.inst.gameState.data[7] -= 100;
					Politic[] array3 = GlobalScript.inst.gameState.politics;
					for (int l = 0; l < array3.Length; l++)
					{
						array3[l].loyality -= 750;
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 23)
			{
				if (!GlobalScript.inst.gameState.event_done[556])
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1112], "\n");
						GlobalScript.inst.gameState.data[7] += 50;
						GlobalScript.inst.gameState.empires[0].power -= 50;
						GlobalScript.inst.gameState.allcountries[85].name = GlobalScript.inst.new_events_text[1115];
						if (GlobalScript.inst.gameState.iron_and_blood)
						{
							gameObject.GetComponent<achievements>().Set(123);
						}
						GlobalScript.inst.gameState.allcountries[87].spec -= 20;
						GlobalScript.inst.gameState.allcountries[85].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[85].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[85].Torg = true;
						GlobalScript.inst.gameState.allcountries[85].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[85].SubGosstroy = 10;
					}
					else
					{
						text = string.Format(GlobalScript.inst.new_events_text[1113], "\n");
						GlobalScript.inst.gameState.empires[0].power += 50;
						GlobalScript.inst.gameState.data[7] -= 50;
						GlobalScript.inst.gameState.allcountries[85].SubGosstroy = 5;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " <color=#8B0000>“ 红 色 旅 ”</color> 组 织 的 闪 击 战 与 各 地 工 人 民 兵 发 起 的 游 击 战 相 互 策 应 ， 对 意 大 利 国 防 军 及 北 约 援 军 造 成 毁 灭 性 打 击 。 前 线 的 失 利 更 导 致 所 谓 <color=#0027FF>“ 民 族 团 结 政 府 ”</color> 内 部 分 歧 恶 化 ， 从 而 加 速 其 垮 台 ： 意 大 利 的 主 要 政 治 家 最 终 纷 纷 流 亡 美 国 ， 并 组 建 了 所 谓 流 亡 政 府 。 从 他 们 的 反 共 倾 向 来 看 ， 该 政 府 确 实 保 留 了 第 一 共 和 国 的 原 汁 原 味 ： <color=#0027FF>天 主 教 民 主 党</color> 的 政 客 们 以 “ 镇 压 叛 乱 不 利 ” 说 法 将 <color=#006400>意 大 利 共 产 党</color> 在 流 亡 政 府 中 的 影 响 力 剥 离 殆 尽 。 导 致 后 者 则 不 得 不 撤 回 苏 联 ， 寻 求 其 传 统 盟 友 的 帮 助 。 结 果 便 是 在 克 里 姆 林 宫 的 怒 火 下 接 受 改 组 ： 主 导 “ 欧 洲 共 产 主 义 ” 战 略 与 “ 民 族 团 结 政 府 ” 政 策 的 <color=#006400>恩 里 科 · 贝 林 格</color> 将 承 担 全 部 责 任 ， 不 得 不 因 “ 健 康 原 因 ” 自 清 隐 退 。 <color=#0027FF>乔 治 · 纳 波 利 塔 诺</color> 等 改 革 派 更 是 因 “ 事 实 上 奉 行 尾 巴 主 义 与 修 正 主 义 政 策 ” 而 被 直 接 撤 职 。 新 任 领 导 层 则 将 由 亲 苏 社 会 主 义 者 <color=#8B0000>阿 曼 多 · 科 苏 塔</color> 领 导 ， 在 苏 联 官 员 监 督 下 促 使 <color=#8B0000>意 大 利 共 产 党</color> 回 归 马 克 思 主 义 立 场 ， 并 试 图 在 本 土 组 织 左 翼 反 对 派 继 续 抵 抗 。 可 这 也 没 什 么 意 义 了 。 <color=#DE3163>安 东 尼 奥 · 奈 格 里</color> 已 在 罗 马 宣 布 成 立 意 大 利 联 邦 ， 整 合 各 地 左 翼 激 进 运 动 。 在 全 国 范 围 启 动 工 人 主 义 项 目 ： 旨 在 以 工 人 委 员 会 与 公 社 制 度 扫 除 克 服 修 正 主 义 化 的 <color=#8B0000>意 大 利 共 产 党</color> 与 第 一 共 和 国 所 遗 留 的 系 列 问 题 。";
					GlobalScript.inst.gameState.data[7] += 50;
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.allcountries[87].spec -= 20;
					GlobalScript.inst.gameState.allcountries[85].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[85].EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[85].Torg = true;
					GlobalScript.inst.gameState.allcountries[85].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[85].SubGosstroy = 0;
				}
				else
				{
					text = " 在 北 约 与 超 级 大 国 的 协 力 ， 以 及 该 国 国 内 政 党 的 果 断 行 动 下 。 意 大 利 军 方 得 以 迅 速 重 振 旗 鼓 ， 成 功 遏 制 左 翼 民 兵 的 攻 势 。 随 着 激 进 左 派 组 织 <color=#8B0000>“ 红 色 旅 ”</color> 的 领 导 人 被 捕 ， 意 大 利 左 翼 激 进 派 的 武 装 力 量 便 被 进 一 步 瓦 解 ， 各 地 公 社 的 准 军 事 小 组 也 在 随 后 纷 纷 被 击 溃 。 行 将 就 木 的 工 人 主 义 理 论 家 如 巴 黎 公 社 的 社 员 般 ， 以 绝 不 屈 服 的 抵 抗 精 神 战 斗 到 了 最 后 一 刻 。 残 余 的 左 翼 组 织 者 则 在 我 们 的 庇 护 下 或 流 亡 或 遁 入 地 下 继 续 抵 抗 。 为 弥 合 内 战 伤 痕 ， “ 民 族 团 结 政 府 ” 决 定 构 建 一 个 排 斥 激 进 共 产 主 义 者 的 大 联 合 政 府 ： 负 责 收 编 温 和 派 城 市 工 人 的 <color=#006400>意 大 利 共 产 党</color> 、 持 福 利 国 家 立 场 的 <color=#006400>意 大 利 社 会 党</color> 、 传 统 建 制 派 <color=#0027FF>天 主 教 民 主 党</color> 乃 至 右 翼 议 会 政 党 <color=#8B4513>意 大 利 社 会 运 动</color> 都 将 被 纳 入 其 中 ， 共 商 国 是 。 临 时 政 府 将 在 <color=#006400>意 大 利 社 会 党</color> 党 魁 <color=#006400>贝 蒂 诺 · 克 拉 克 西</color> 的 领 导 下 ， 奉 行 <color=#006400>意 大 利 共 产 党</color> 心 心 念 念 的 “ 历 史 性 妥 协 ” … … 该 国 将 在 戒 严 解 除 ， 彻 底 清 剿 恐 怖 主 义 与 犯 罪 集 团 后 组 织 首 次 大 选 。 预 计 传 统 政 党 <color=#006400>意 大 利 共 产 党</color> 、 <color=#006400>意 大 利 社 会 党</color> 与 <color=#0027FF>天 主 教 民 主 党</color> 将 在 其 中 取 得 优 势 ， 并 形 成 三 方 联 合 政 府 。";
					GlobalScript.inst.gameState.empires[0].power += 50;
					GlobalScript.inst.gameState.data[7] -= 50;
					GlobalScript.inst.gameState.allcountries[85].Gosstroy = 3;
					GlobalScript.inst.gameState.allcountries[85].SubGosstroy = 5;
					GlobalScript.inst.gameState.allcountries[85].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[85].Vyshi = true;
					if (GlobalScript.inst.gameState.allcountries[0].isEU)
					{
						GlobalScript.inst.gameState.allcountries[85].isEU = true;
					}
					if (GlobalScript.inst.gameState.allcountries[0].isNATO)
					{
						GlobalScript.inst.gameState.allcountries[85].isNATO = true;
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 24)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1179], "\n");
					GlobalScript.inst.gameState.allcountries[41].EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[41].Torg = true;
					GlobalScript.inst.gameState.allcountries[41].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[41].SubGosstroy = 3;
					GlobalScript.inst.gameState.allcountries[41].inflCh = 500;
					GlobalScript.inst.gameState.allcountries[41].inflNATO = 500;
					GlobalScript.inst.gameState.allcountries[41].name = GlobalScript.inst.new_events_text[1180];
					GlobalScript.inst.gameState.influencePRC += 15;
					GlobalScript.inst.gameState.empires[1].power -= 15;
					GlobalScript.inst.gameState.allcountries[41].soc_stab = 1000;
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1178], "\n");
					GlobalScript.inst.gameState.influencePRC -= 15;
					GlobalScript.inst.gameState.empires[1].power += 30;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 25)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1182], "\n");
					if (GlobalScript.inst.gameState.allcountries[99].parts[0] && GlobalScript.inst.gameState.allcountries[42].parts[0] && GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(143);
					}
					GlobalScript.inst.gameState.allcountries[100].EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[100].Torg = true;
					GlobalScript.inst.gameState.allcountries[100].spec = 1;
					GlobalScript.inst.gameState.allcountries[100].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[100].SubGosstroy = 15;
					GlobalScript.inst.gameState.allcountries[100].soc_stab = 1000;
					GlobalScript.inst.gameState.allcountries[100].inflCh = 500;
					GlobalScript.inst.gameState.allcountries[100].inflNATO = 500;
					GlobalScript.inst.gameState.influencePRC += 5;
					GlobalScript.inst.gameState.empires[1].power -= 5;
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1181], "\n");
					GlobalScript.inst.gameState.allcountries[100].parts[0] = false;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 26)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1184], "\n");
					if (GlobalScript.inst.gameState.allcountries[100].parts[0] && GlobalScript.inst.gameState.allcountries[42].parts[0] && GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(143);
					}
					GlobalScript.inst.gameState.allcountries[99].Torg = true;
					GlobalScript.inst.gameState.allcountries[99].spec = 1;
					GlobalScript.inst.gameState.allcountries[99].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[99].SubGosstroy = 15;
					if (!GlobalScript.inst.gameState.event_done[434])
					{
						GlobalScript.inst.gameState.allcountries[99].inflCh = 500;
						GlobalScript.inst.gameState.allcountries[99].soc_stab = 1000;
						GlobalScript.inst.gameState.allcountries[99].inflNATO = 500;
						GlobalScript.inst.gameState.allcountries[99].EstablishGovernment(Government.ProChina);
					}
					if (!GlobalScript.inst.gameState.event_done[434] || (GlobalScript.inst.gameState.event_done[434] && GlobalScript.inst.gameState.resultOfEvents[434] >= 2))
					{
						GlobalScript.inst.gameState.influencePRC += 15;
					}
					GlobalScript.inst.gameState.empires[1].power -= 15;
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1183], "\n");
					GlobalScript.inst.gameState.allcountries[99].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[99].puppetOf = -1;
					if (GlobalScript.inst.gameState.event_done[434] && GlobalScript.inst.gameState.resultOfEvents[434] == 1)
					{
						GlobalScript.inst.gameState.allcountries[41].Torg = true;
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 27)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 500)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1240], "\n");
					GlobalScript.inst.gameState.empires[1].power += 50;
					GlobalScript.inst.gameState.allcountries[22].isSEV = true;
					GlobalScript.inst.gameState.empires[0].power -= 10;
					GlobalScript.inst.gameState.influencePRC -= 10;
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[22].Torg = true;
					GlobalScript.inst.gameState.empires[0].power -= 30;
					if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power)
					{
						GlobalScript.inst.gameState.influencePRC += 30;
						GlobalScript.inst.gameState.allcountries[22].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[22].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
						GlobalScript.inst.gameState.allcountries[22].SubGosstroy = GlobalScript.inst.gameState.allcountries[1].SubGosstroy;
					}
					else
					{
						GlobalScript.inst.gameState.empires[0].power += 30;
						GlobalScript.inst.gameState.allcountries[22].EstablishGovernment(Government.ProAmerican);
						GlobalScript.inst.gameState.allcountries[22].Gosstroy = GlobalScript.inst.gameState.allcountries[51].Gosstroy;
						GlobalScript.inst.gameState.allcountries[22].SubGosstroy = GlobalScript.inst.gameState.allcountries[51].SubGosstroy;
					}
					text = string.Format(GlobalScript.inst.new_events_text[1241], "\n", GlobalScript.inst.gameState.allcountries[22].proprc ? GlobalScript.inst.new_events_text[1242] : GlobalScript.inst.new_events_text[1243]);
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 28)
			{
				if (!GlobalScript.inst.gameState.event_done[571])
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 800)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1317], "\n");
						GlobalScript.inst.gameState.allcountries[14].parts[5] = true;
						GlobalScript.inst.gameState.allcountries[36].Torg = false;
						GlobalScript.inst.gameState.allcountries[36].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[36].isOil = false;
					}
					else
					{
						text = string.Format(GlobalScript.inst.new_events_text[1318], "\n");
						GlobalScript.inst.gameState.allcountries[36].Torg = false;
						GlobalScript.inst.gameState.allcountries[36].cw = true;
						GlobalScript.inst.gameState.allcountries[14].dev = 1;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = " 在 侵 略 战 争 期 间 ， 阿 联 共 得 以 同 一 部 分 反 科 威 特 君 主 制 的 将 军 达 成 协 定 。 该 国 变 节 者 宣 布 建 立 科 威 特 共 和 国 。 在 事 实 上 完 全 吞 并 科 威 特 领 土 后 ， 阿 联 共 宣 布 科 威 特 将 成 与 阿 联 共 组 成 完 全 平 等 的 联 邦 。";
					GlobalScript.inst.gameState.allcountries[36].Torg = false;
					GlobalScript.inst.gameState.allcountries[36].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[36].Gosstroy = GlobalScript.inst.gameState.allcountries[30].Gosstroy;
					GlobalScript.inst.gameState.allcountries[36].SubGosstroy = GlobalScript.inst.gameState.allcountries[30].SubGosstroy;
					GlobalScript.inst.gameState.allcountries[36].puppetOf = 30;
					GlobalScript.inst.gameState.allcountries[36].isOil = false;
					GlobalScript.inst.gameState.allcountries[30].proprc = true;
				}
				else
				{
					text = "尽 管 阿 联 共 军 队 有 数 倍 于 科 威 特 方 的 优 势 ， 但 前 者 还 是 被 赶 出 了 科 威 特 。 萨 巴 赫 王 室 回 到 了 科 威 特 ， 并 开 展 了 针 对 巴 勒 斯 坦 人 的 种 族 清 洗 。 因 为 在 阿 联 共 入 侵 时 ， 这 些 人 曾 为 他 们 带 路 。||在 阿 联 共 领 土 被 解 除 占 领 后 ， 对 该 国 的 制 裁 仍 未 停 止 。";
					GlobalScript.inst.gameState.allcountries[36].Torg = false;
					GlobalScript.inst.gameState.allcountries[36].proprc = false;
					GlobalScript.inst.gameState.allcountries[30].proprc = false;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 29)
			{
				GlobalScript.inst.gameState.allcountries[36].cw = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					GlobalScript.inst.gameState.allcountries[14].LeaveAlliances();
					if (GlobalScript.inst.gameState.allcountries[1].isOVD)
					{
						if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[1].power)
						{
							int num3 = 1;
							text = string.Format(GlobalScript.inst.new_events_text[1327], "\n", GlobalScript.inst.new_events_text[1335 + num3]);
							GlobalScript.inst.gameState.allcountries[14].EstablishGovernment(Government.ProChina).JoinAllOurAlliances(yes: true).EstablishGosstroy(1);
							GlobalScript.inst.gameState.allcountries[14].Torg = true;
							GlobalScript.inst.gameState.influencePRC += 50;
							GlobalScript.inst.gameState.allcountries[14].soc_stab = 1000;
						}
						else
						{
							int num4 = 2;
							text = string.Format(GlobalScript.inst.new_events_text[1327], "\n", GlobalScript.inst.new_events_text[1335 + num4]);
							GlobalScript.inst.gameState.allcountries[14].EstablishGovernment(Government.ProSoviet).JoinAllOurAlliances(yes: true).EstablishGosstroy(7);
							GlobalScript.inst.gameState.allcountries[14].Torg = true;
							GlobalScript.inst.gameState.empires[1].power += 50;
						}
					}
					else if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
					{
						if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power)
						{
							int num5 = 1;
							text = string.Format(GlobalScript.inst.new_events_text[1328], "\n", GlobalScript.inst.new_events_text[1335 + num5]);
							GlobalScript.inst.gameState.allcountries[14].EstablishGovernment(Government.ProChina).JoinAllOurAlliances(yes: true).EstablishGosstroy(1);
							GlobalScript.inst.gameState.allcountries[14].Torg = true;
							GlobalScript.inst.gameState.influencePRC += 50;
							GlobalScript.inst.gameState.allcountries[14].soc_stab = 1000;
						}
						else
						{
							int num6 = 3;
							text = string.Format(GlobalScript.inst.new_events_text[1328], "\n", GlobalScript.inst.new_events_text[1335 + num6]);
							GlobalScript.inst.gameState.allcountries[14].EstablishGovernment(Government.ProAmerican).JoinAllOurAlliances(yes: true).EstablishGosstroy(51);
							GlobalScript.inst.gameState.allcountries[14].Torg = true;
							GlobalScript.inst.gameState.empires[0].power += 50;
						}
					}
					else
					{
						int num7 = 1;
						text = string.Format(GlobalScript.inst.new_events_text[1329], "\n", GlobalScript.inst.new_events_text[1335 + num7]);
						GlobalScript.inst.gameState.allcountries[14].EstablishGovernment(Government.ProChina).JoinAllOurAlliances(yes: true).EstablishGosstroy(1);
						GlobalScript.inst.gameState.allcountries[14].soc_stab = 1000;
						GlobalScript.inst.gameState.allcountries[14].Torg = true;
						GlobalScript.inst.gameState.influencePRC += 50;
					}
					GlobalScript.inst.gameState.allcountries[14].dev = 1;
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 500)
				{
					GlobalScript.inst.gameState.influencePRC -= 50;
					if (GlobalScript.inst.gameState.allcountries[1].isOVD)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1330], "\n");
					}
					else if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1331], "\n");
					}
					else
					{
						text = string.Format(GlobalScript.inst.new_events_text[1332], "\n");
					}
				}
				else
				{
					GlobalScript.inst.gameState.influencePRC -= 30;
					if (GlobalScript.inst.gameState.allcountries[1].isOVD)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1333], "\n");
					}
					else if (GlobalScript.inst.gameState.allcountries[1].isSEATO)
					{
						text = string.Format(GlobalScript.inst.new_events_text[1334], "\n");
					}
					else
					{
						text = string.Format(GlobalScript.inst.new_events_text[1335], "\n");
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 30)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 800)
				{
					bool flag = false;
					bool flag2 = false;
					if (GlobalScript.inst.gameState.ingamewars[31].is_going || GlobalScript.inst.gameState.allcountries[86].parts[0])
					{
						flag = true;
					}
					if (GlobalScript.inst.gameState.ingamewars[32].is_going || GlobalScript.inst.gameState.allcountries[86].parts[1])
					{
						flag2 = true;
					}
					int num8 = 0;
					if (flag && flag2)
					{
						num8 = 1393;
					}
					else if (flag)
					{
						num8 = 1394;
					}
					else if (flag2)
					{
						num8 = 1395;
					}
					GlobalScript.inst.gameState.ingamewars[31].is_going = false;
					GlobalScript.inst.gameState.ingamewars[32].is_going = false;
					if (GlobalScript.inst.gameState.resultOfEvents[426] == 3)
					{
						text = " 反 法 西 斯 革 命 统 一 阵 线 与 共 和 政 府 成 立 了 联 合 政 府 ， 共 同 管 理 战 后 的 西 班 牙 ， 他 们 达 成 了 在 西 班 牙 完 全 去 右 翼 化 的 共 识 ， 决 定 彻 底 清 洗 右 翼 并 审 判 两 次 内 战 的 战 犯 ， 开 始 进 行 战 后 重 建 。 <color=red>西 班 牙 共 产 党</color> 和 <color=green>西 班 牙 工 人 社 会 党</color> 回 归 了 左 翼 立 场 ， 因 为 左 翼 在 这 一 联 合 政 府 中 的 优 势 ， <color=blue>苏 亚 雷 斯</color> 的 党 被 完 全 被 边 缘 化 了 。 战 后 民 众 对 和 平 的 渴 望 和 左 翼 在 社 会 上 的 完 全 优 势 使 得 左 翼 各 派 的 联 合 能 够 实 现 ， 共 和 主 义 、 马 克 思 主 义 和 社 会 主 义 也 成 为 了 战 后 西 班 牙 的 共 识 。 在 社 会 主 义 联 合 政 府 中 各 派 势 力 的 共 同 支 持 下 ， 西 班 牙 开 始 进 行 国 有 化 和 土 地 改 革 ， 进 行 社 会 主 义 革 命 ， 并 宣 布 西 班 牙 将 开 始 彻 底 去 殖 民 化 （ 比 如 将 修 达 、 梅 梅 利 亚 和 加 那 利 群 岛 归 还 给 摩 洛 哥 ） 。 同 时 ， 西 班 牙 也 在 各 个 前 左 翼 民 族 团 体 的 支 持 下 改 组 成 了 完 全 平 等 的 联 邦 制 共 和 国 。 我 们 暂 时 不 知 道 这 种 模 式 的 左 翼 联 合 政 府 能 维 持 多 久 … …";
						GlobalScript.inst.gameState.allcountries[86].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[86].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[86].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[86].proprc = true;
						GlobalScript.inst.gameState.allcountries[86].Torg = true;
						GlobalScript.inst.gameState.allcountries[86].name = " 西 班 牙 联 邦";
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[426] == 4)
					{
						text = " 左 翼 卡 洛 斯 党 人 最 终 取 得 了 胜 利 ， 原 本 西 班 牙 下 属 的 各 个 自 治 区 依 托 于 原 左 翼 分 离 主 义 组 织 ， 改 组 为 自 治 王 国 。 左 翼 卡 洛 斯 党 总 书 记 <color=green>马 里 亚 诺 · 祖 菲 亚</color> 被 推 上 了 人 民 王 国 的 首 相 之 位 ， 他 宣 布 “ 共 和 国 不 足 以 保 护 人 民 主 权 免 受 资 产 阶 级 的 侵 犯 。 ” 来 自 波 旁 家 族 卡 洛 斯 分 支 的 一 位 因 左 翼 观 点 闻 名 的 王 位 继 承 人 ， 隶 属 波 旁 - 帕 尔 马 家 族 的 雨 果 · 卡 洛 斯 被 加 冕 为 西 班 牙 国 王 。 在 佛 朗 哥 时 代 ， 左 翼 观 点 就 因 为 6 8 运 动 与 卡 洛 斯 主 义 运 动 发 生 了 融 合 。 雨 果 · 卡 洛 斯 则 采 纳 了 南 斯 拉 夫 铁 托 主 义 的 意 识 形 态 ， 并 邀 请 了 近 期 被 <color=red>西 共</color> 正 统 派 排 挤 出 <color=red>共 产 党</color> 高 层 的 <color=green>圣 地 亚 哥 · 卡 里 略</color> 参 与 了 王 国 内 阁 。 也 就 在 加 冕 仪 式 上 ， 身 为 <color=red>共 产 党</color> 员 的 <color=green>卡 里 略</color> 跪 倒 在 他 那 陛 下 面 前 ， 并 高 呼 “ 上 帝 保 佑 国 王 ！ ”";
						GlobalScript.inst.gameState.allcountries[86].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[86].SubGosstroy = 11;
						GlobalScript.inst.gameState.allcountries[86].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[86].name = " 西 班 牙 人 民 联 合 王 国";
					}
					else
					{
						text = string.Format(GlobalScript.inst.new_events_text[1388], "\n", (num8 > 0) ? GlobalScript.inst.new_events_text[num8] : null);
						GlobalScript.inst.gameState.allcountries[86].name = GlobalScript.inst.new_events_text[1391];
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 800)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[426] == 4)
					{
						text = " 如 同 跳 梁 小 丑 一 般 匆 匆 起 事 的 左 翼 卡 洛 斯 派 很 快 就 被 共 和 政 府 和 长 枪 党 共 同 剿 灭 ， 加 泰 罗 尼 亚 和 巴 斯 克 的 分 离 主 义 者 也 元 气 大 伤 ， 而 在 击 退 了 卡 洛 斯 派 后 ， 西 班 牙 内 战 也 并 未 结 束 ， 共 和 政 府 和 长 枪 党 继 续 剑 拔 弩 张 。";
						GlobalScript.inst.gameState.ingamewars[30].name_war = GlobalScript.inst.new_events_text[1382];
						GlobalScript.inst.gameState.ingamewars[30].is_going = true;
						GlobalScript.inst.gameState.ingamewars[30].side1 = GlobalScript.inst.new_events_text[1383];
						GlobalScript.inst.gameState.ingamewars[30].side2 = GlobalScript.inst.new_events_text[1384];
						GlobalScript.inst.gameState.ingamewars[30].ussr_place = -1;
						GlobalScript.inst.gameState.ingamewars[30].usa_place = -1;
						GlobalScript.inst.gameState.ingamewars[30].infl1 = 300;
						GlobalScript.inst.gameState.ingamewars[30].infl2 = 700;
						GlobalScript.inst.gameState.resultOfEvents[426] = 0;
					}
					else
					{
						bool flag3 = false;
						bool flag4 = false;
						if (GlobalScript.inst.gameState.ingamewars[31].is_going || GlobalScript.inst.gameState.allcountries[86].parts[0])
						{
							flag3 = true;
						}
						if (GlobalScript.inst.gameState.ingamewars[32].is_going || GlobalScript.inst.gameState.allcountries[86].parts[1])
						{
							flag4 = true;
						}
						gameObject.GetComponent<achievements>().Set(151);
						text = string.Format(GlobalScript.inst.new_events_text[1389], "\n", (flag3 || flag4) ? GlobalScript.inst.new_events_text[1396] : null);
						if (GlobalScript.inst.gameState.ingamewars[31].is_going)
						{
							GlobalScript.inst.gameState.ingamewars[31].is_going = false;
							GlobalScript.inst.gameState.allcountries[86].parts[0] = false;
						}
						if (GlobalScript.inst.gameState.ingamewars[32].is_going)
						{
							GlobalScript.inst.gameState.ingamewars[32].is_going = false;
							GlobalScript.inst.gameState.allcountries[86].parts[1] = false;
						}
						GlobalScript.inst.gameState.allcountries[86].name = GlobalScript.inst.new_events_text[1392];
						GlobalScript.inst.gameState.allcountries[86].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[86].SubGosstroy = 7;
					}
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1390], "\n");
					GlobalScript.inst.gameState.allcountries[86].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[86].SubGosstroy = 14;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 31)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = string.Format(GlobalScript.inst.new_events_text[1417], "\n");
					if (GlobalScript.inst.gameState.allcountries[86].parts[1] && !GlobalScript.inst.gameState.ingamewars[32].is_going && GlobalScript.inst.gameState.iron_and_blood)
					{
						gameObject.GetComponent<achievements>().Set(151);
					}
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1418], "\n");
					GlobalScript.inst.gameState.allcountries[86].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[109].Torg = false;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 32)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					if (GlobalScript.inst.gameState.allcountries[86].parts[0] && !GlobalScript.inst.gameState.ingamewars[31].is_going)
					{
						gameObject.GetComponent<achievements>().Set(151);
					}
					text = string.Format(GlobalScript.inst.new_events_text[1419], "\n");
				}
				else
				{
					text = string.Format(GlobalScript.inst.new_events_text[1420], "\n");
					GlobalScript.inst.gameState.allcountries[86].parts[1] = false;
					GlobalScript.inst.gameState.allcountries[110].Torg = false;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 33)
			{
				if (GlobalScript.inst.gameState.allcountries[8].Gosstroy == 1)
				{
					GlobalScript.inst.gameState.empires[1].power += 10;
					GlobalScript.inst.gameState.influencePRC += 50;
					GlobalScript.inst.gameState.allcountries[8].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].Torg = true;
					GlobalScript.inst.gameState.allcountries[8].proprc = true;
					GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
					GlobalScript.inst.gameState.iranrev = false;
					text = "  随 着 伊 拉 克 的 坦 克 攻 入 德 黑 兰 和 大 不 里 士 ， 神 权 政 府 宣 布 投 降 。 伊 拉 克 革 命 政 府 也 不 再 宣 称 对 胡 齐 斯 坦 的 主 权 要 求 ， 称 其 为 “ 小 资 产 阶 级 不 切 实 际 的 民 族 主 义 狂 热 ， 应 当 为 国 际 主 义 革 命 让 步 。 ”|| 以 霍 梅 尼 为 首 的 神 权 政 府 成 员 被 逮 捕 ， 并 被 公 审 。 由 伊 朗 境 内 各 个 左 翼 组 织 形 成 的 人 民 革 命 联 盟 在 经 过 谈 判 后 决 定 共 同 组 建 一 个 以 激 进 伊 斯 兰 社 会 主 义 （ 伊 斯 兰 马 克 思 主 义 ） 、 马 列 主 义 和 反 修 正 主 义 为 意 识 形 态 的 新 党 — — 伊 朗 人 民 革 命 党 。 其 他 支 持 革 命 的 非 左 翼 革 命 派 的 组 织 则 进 入 了 伊 朗 爱 国 阵 线 ， 合 法 参 与 革 命 后 的 伊 朗 政 治 ， 阿 博 尔 哈 桑 · 巴 尼 萨 德 尔 被 选 举 为 爱 国 阵 线 主 席 。 作 为 新 革 命 政 府 的 人 民 革 命 委 员 会 宣 布 将 在 伊 朗 建 设 人 民 民 主 。 神 职 人 员 被 永 久 禁 止 参 与 政 治 ， 大 型 国 有 化 和 土 地 改 革 运 动 正 在 蓬 勃 开 展 ； 全 国 各 民 族 一 律 平 等 ， 库 尔 德 、 阿 塞 拜 疆 、 俾 路 支 、 土 库 曼 和 阿 拉 伯 人 的 聚 居 区 都 成 立 了 各 自 的 民 族 自 治 区 。 世 俗 化 运 动 和 妇 女 革 命 正 在 进 行 准 备 工 作 ， 伊 朗 邀 请 了 阿 尔 巴 尼 亚 人 ， 伊 拉 克 战 友 和 我 们 作 为 顾 问 ， 准 备 开 展 一 场 温 和 化 的 思 想 文 化 革 命 。";
					if (GlobalScript.inst.gameState.allcountries[14].puppetOf == 8)
					{
						GlobalScript.inst.gameState.allcountries[14].puppetOf = -1;
						GlobalScript.inst.gameState.allcountries[14].Gosstroy = GlobalScript.inst.gameState.allcountries[8].Gosstroy;
						GlobalScript.inst.gameState.allcountries[14].SubGosstroy = GlobalScript.inst.gameState.allcountries[8].SubGosstroy;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					GlobalScript.inst.gameState.empires[1].power += 10;
					GlobalScript.inst.gameState.influencePRC += 50;
					GlobalScript.inst.gameState.allcountries[8].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[8].Torg = true;
					GlobalScript.inst.gameState.allcountries[8].proprc = true;
					GlobalScript.inst.gameState.allcountries[8].prcpower = 1000;
					GlobalScript.inst.gameState.iranrev = false;
					GlobalScript.inst.gameState.ingamewars[3].infl1 = 1000;
					GlobalScript.inst.gameState.ingamewars[3].infl2 = 0;
					text = " 由 伊 朗 人 民 革 命 联 盟 领 导 的 革 命 阵 营 成 功 粉 碎 伊 朗 神 权 政 府 ， 拿 下 了 伊 朗 全 国 领 土 。 以 霍 梅 尼 为 首 的 神 权 政 府 成 员 被 逮 捕 ， 并 被 公 审 。 人 民 革 命 联 盟 中 各 大 组 织 在 经 过 谈 判 后 决 定 共 同 组 建 一 个 以 激 进 伊 斯 兰 社 会 主 义 （ 伊 斯 兰 马 克 思 主 义 ） 、 马 列 主 义 和 反 修 正 主 义 为 意 识 形 态 的 新 党 — — 伊 朗 人 民 革 命 党 。 其 他 支 持 革 命 的 非 左 翼 革 命 派 的 组 织 则 进 入 了 伊 朗 爱 国 阵 线 ， 合 法 参 与 革 命 后 的 伊 朗 政 治 ， 阿 博 尔 哈 桑 · 巴 尼 萨 德 尔 被 选 举 为 爱 国 阵 线 主 席 。 作 为 新 革 命 政 府 的 人 民 革 命 委 员 会 宣 布 将 在 伊 朗 建 设 人 民 民 主 。 神 职 人 员 被 永 久 禁 止 参 与 政 治 ， 大 型 国 有 化 和 土 地 改 革 运 动 正 在 蓬 勃 开 展 ； 全 国 各 民 族 一 律 平 等 ， 库 尔 德 、 阿 塞 拜 疆 、 俾 路 支 、 土 库 曼 和 阿 拉 伯 人 的 聚 居 区 都 成 立 了 各 自 的 民 族 自 治 区 。 世 俗 化 运 动 和 妇 女 革 命 正 在 进 行 准 备 工 作 ， 伊 朗 邀 请 了 阿 尔 巴 尼 亚 人 和 我 们 作 为 顾 问 ， 准 备 开 展 一 场 温 和 化 的 思 想 文 化 革 命 。";
					if (GlobalScript.inst.gameState.allcountries[14].puppetOf == 8)
					{
						GlobalScript.inst.gameState.allcountries[14].puppetOf = -1;
						GlobalScript.inst.gameState.allcountries[14].Gosstroy = GlobalScript.inst.gameState.allcountries[8].Gosstroy;
						GlobalScript.inst.gameState.allcountries[14].SubGosstroy = GlobalScript.inst.gameState.allcountries[8].SubGosstroy;
					}
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[8].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[8].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[8].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[8].Torg = false;
					GlobalScript.inst.gameState.iranrev = false;
					text = " 伊 朗 伊 斯 兰 共 和 国 以 惨 痛 的 代 价 镇 压 了 大 起 义 ， 革 命 联 盟 部 分 人 士 被 迫 流 亡 海 外 ， 部 分 转 入 地 下 游 击 运 动 。 神 权 政 府 随 后 开 始 在 全 国 范 围 内 制 造 “ 绿 色 恐 怖 ” ， 大 规 模 清 洗 “ 反 （ 伊 斯 兰 ） 革 命 分 子 ” 。 各 个 大 学 被 迫 暂 时 关 闭 ， 以 清 查 进 步 学 生 ； 军 队 和 革 命 卫 队 开 始 在 全 国 搜 捕 残 余 的 革 命 派 。 由 于 “ 紧 急 状 态 ” 仍 未 结 束 ， 议 会 仍 处 于 无 限 期 休 会 。 希 望 伊 朗 的 一 切 最 终 会 往 好 的 方 向 发 展 。";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 34)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
				{
					GlobalScript.inst.gameState.influencePRC += 50;
					GlobalScript.inst.gameState.allcountries[49].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[49].SubGosstroy = 17;
					GlobalScript.inst.gameState.allcountries[49].Torg = true;
					GlobalScript.inst.gameState.allcountries[49].Vyshi = false;
					GlobalScript.inst.gameState.allcountries[49].LeaveASEAN();
					GlobalScript.inst.gameState.allcountries[49].LeaveSEATO();
					GlobalScript.inst.gameState.allcountries[49].proprc = true;
					GlobalScript.inst.gameState.allcountries[49].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[111].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[49].JoinAllOurAlliances(yes: true);
					GlobalScript.inst.gameState.allcountries[49].soc_stab = 1000;
					GlobalScript.inst.gameState.allcountries[49].prcpower = 1000;
					text = " 在 我 们 和 东 南 亚 兄 弟 党 的 密 切 配 合 与 支 援 下 ， 共 产 党 终 于 取 得 了 革 命 的 胜 利 。 马 来 西 亚 民 族 解 放 同 盟 夺 取 了 前 马 来 西 亚 的 政 权 ， 并 且 在 新 加 坡 社 会 主 义 阵 线 的 起 义 和 我 海 军 的 威 慑 下 迅 速 推 翻 李 光 耀 反 动 政 权 ， 文 莱 人 民 党 和 北 加 里 曼 丹 共 产 党 则 一 同 将 文 莱 “ 和 平 ” 接 管 。 在 这 之 后 ， 民 族 解 放 同 盟 宣 布 马 - 北 加 地 区 彻 底 摆 脱 了 帝 国 主 义 的 控 制 ， 并 在 首 都 新 山 宣 布 成 立 了 马 来 亚 - 北 加 里 曼 丹 人 民 联 邦 共 和 国 ， 并 举 行 各 个 共 产 党 组 织 的 统 一 大 会 。 马 共 提 出 的 八 项 原 则 付 诸 于 实 践 ， 并 实 行 包 括 废 除 与 英 美 的 防 务 互 助 协 议 ； 废 除 紧 急 条 例 等 法 律 ， 释 放 左 翼 政 治 家 ； 外 资 国 有 化 ， 同 工 同 酬 ， 并 逐 步 实 施 工 厂 民 主 管 理 ； 进 行 土 改 和 合 作 化 运 动 ； 定 英 华 马 印 尹 （ 尹 班 语 ） 卡 （ 卡 达 山 - 杜 顺 语 ） 六 种 官 方 语 言 ， 但 各 民 族 有 选 择 自 己 语 言 的 自 由 ， 地 方 人 民 议 会 实 行 多 种 语 言 制 ； 彻 查 前 政 府 合 作 者 等 叛 徒 ， 并 予 以 公 审 ； 确 立 马 来 亚 ， 沙 巴 ， 文 莱 ， 沙 捞 越 在 联 邦 中 地 位 平 等 等 一 系 列 政 策 。 流 亡 的 印 尼 共 产 党 在 我 们 的 帮 助 下 进 驻 北 加 里 曼 丹 ， 并 开 始 重 新 训 练 人 民 武 装 和 渗 透 印 尼 。 苏 东 集 团 祝 贺 马 来 西 亚 人 民 的 成 功 斗 争 ， 而 西 方 国 家 则 表 示 强 烈 谴 责 ， 并 开 始 加 强 对 印 度 尼 西 亚 的 武 装 援 助 ， 印 尼 则 扯 起 了 一 贯 的 反 共 大 旗 ， 掀 起 新 一 轮 国 内 的 白 色 恐 怖 ， 宣 布 不 承 认 新 成 立 的 红 色 马 来 西 亚 ， 并 重 拾 大 印 尼 的 野 心 ， 两 国 边 境 据 称 已 发 生 边 境 冲 突 。 东 南 亚 的 火 药 味 渐 浓 ， 但 至 少 ， 东 南 亚 的 又 一 国 家 革 命 成 功 了 ， 我 们 离 世 界 的 解 放 越 来 越 近 了 。";
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[49].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[49].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[49].Torg = false;
					text = " 马 来 西 亚 政 府 镇 压 的 大 起 义 ， 并 开 始 了 一 个 新 的 白 色 恐 怖 时 期 ， 共 产 党 部 分 来 到 我 国 流 亡 ， 部 分 再 次 返 回 丛 林 开 展 游 击 战 。 大 规 模 清 洗 “ 赤 匪 ” 的 运 动 开 始 了 ， 各 个 城 市 被 迫 暂 时 戒 严 ， 以 清 查 进 步 民 众 — — 紧 急 状 态 仍 未 结 束 。 新 加 坡 发 起 了 反 共 运 动 ， 借 机 镇 压 了 一 批 左 翼 政 党 ， 议 会 门 槛 也 被 收 紧 了 。";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 35)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
				{
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.influencePRC += 40;
					GlobalScript.inst.gameState.data[6] += 20;
					GlobalScript.inst.gameState.allcountries[50].Vyshi = false;
					GlobalScript.inst.gameState.allcountries[50].isASEAN = false;
					GlobalScript.inst.gameState.allcountries[50].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[50].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[50].SubGosstroy = 17;
					GlobalScript.inst.gameState.allcountries[50].Torg = true;
					GlobalScript.inst.gameState.allcountries[50].proprc = true;
					GlobalScript.inst.gameState.allcountries[50].JoinAllOurAlliances(yes: true);
					GlobalScript.inst.gameState.allcountries[50].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[128].name = " 东 帝 汶";
					GlobalScript.inst.gameState.allcountries[128].africaOff = true;
					GlobalScript.inst.gameState.allcountries[128].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[128].SubGosstroy = 17;
					GlobalScript.inst.gameState.allcountries[128].Torg = true;
					GlobalScript.inst.gameState.allcountries[128].proprc = true;
					GlobalScript.inst.gameState.allcountries[128].JoinAllOurAlliances(yes: true);
					GlobalScript.inst.gameState.allcountries[128].soc_stab = 1000;
					Politic[] array4 = GlobalScript.inst.gameState.politics;
					foreach (Politic politic in array4)
					{
						if (politic.traits[0] <= 1)
						{
							politic.loyality += 100;
						}
					}
					GlobalScript.inst.gameState.allcountries[50].soc_stab = 1000;
					GlobalScript.inst.gameState.allcountries[50].prcpower = 1000;
					text = " 印 尼 共 产 党 和 它 的 支 持 者 在 东 南 亚 同 志 和 我 们 的 支 持 下 赢 得 了 革 命 。 统 战 组 织 被 改 组 为 政 协 组 织 ， 合 法 参 与 印 尼 共 主 导 的 人 民 民 主 政 府 。 新 政 府 立 即 开 展 新 民 主 主 义 建 设 ， 并 同 我 们 的 阵 营 深 化 联 系 。 排 华 政 策 被 完 全 否 定 ， 各 民 族 语 言 、 民 族 地 位 完 全 平 等 。 过 去 的 旧 统 治 集 团 以 及 旧 军 队 都 被 清 洗 ， 以 雪 1 9 6 5 之 耻 ， 苏 哈 托 被 公 审 处 决 ， 其 买 办 家 族 的 财 产 也 被 完 全 没 收 。 关 于 伊 斯 兰 教 武 装 团 体 被 剿 灭 ， 关 于 宗 教 的 改 革 也 正 在 准 备 中 。 东 帝 汶 马 克 思 列 宁 主 义 阵 线 在 我 们 的 支 持 下 掌 权 东 帝 汶 ， 亚 齐 和 巴 布 亚 的 分 离 主 义 则 渐 渐 被 削 弱 。" + ((allcountries[135].Gosstroy == 3) ? " 南 洋 群 岛 的 革 命 使 得 大 洋 洲 的 政 府 以 及 西 方 极 度 恐 慌 ， 澳 大 利 亚 和 新 西 兰 在 美 国 的 支 持 下 强 化 了 武 装 。" : null);
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[50].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[50].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[50].Torg = false;
					GlobalScript.inst.gameState.allcountries[50].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[128].name = " 东 帝 汶";
					GlobalScript.inst.gameState.allcountries[128].africaOff = true;
					GlobalScript.inst.gameState.allcountries[128].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[128].SubGosstroy = 2;
					GlobalScript.inst.gameState.allcountries[128].soc_stab = 1000;
					text = " 印 尼 的 反 动 集 团 在 西 方 帝 国 主 义 的 支 持 下 剿 灭 了 共 产 党 起 义 ， 大 镇 压 和 排 华 运 动 又 再 次 开 始 。 共 产 党 人 和 左 翼 反 对 派 转 入 丛 林 和 山 地 开 展 游 击 ， 支 持 他 们 的 民 众 也 倒 向 了 游 击 队 。 由 于 政 府 元 气 大 伤 ， 开 始 不 得 不 支 持 地 方 民 团 和 宗 教 武 装 并 更 加 深 度 地 与 西 方 捆 绑 ， 以 对 抗 转 入 地 下 的 共 产 党 。 印 尼 各 地 方 的 独 立 倾 向 加 强 了 ， 亚 齐 、 巴 布 亚 和 东 帝 汶 甚 至 都 趁 此 独 立 。 谁 都 不 知 道 “ 新 秩 序 “ 还 能 维 持 多 久 … …";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 37)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.influencePRC += 40;
					GlobalScript.inst.gameState.data[6] += 20;
					Politic[] array4 = GlobalScript.inst.gameState.politics;
					foreach (Politic politic2 in array4)
					{
						if (politic2.traits[0] < 1 || politic2.traits[0] == 20)
						{
							politic2.loyality += 100;
						}
					}
					text = " 随 着 革 命 联 军 的 空 降 部 队 在 利 雅 得 的 斩 首 行 动 （ 沙 特 王 室 全 家 被 俘 ） 的 成 功 和 联 军 势 如 破 竹 的 行 动 ， 失 去 了 外 部 和 内 部 支 持 的 沙 特 买 办 王 室 政 府 最 终 倒 台 ， 革 命 联 军 控 制 了 半 岛 全 境 。";
					if (GlobalScript.inst.gameState.allcountries[24].parts[0] && GlobalScript.inst.gameState.allcountries[24].proprc)
					{
						text += " 新 的 半 岛 革 命 政 府 由 毛 派 的 阿 拉 伯 半 岛 人 民 民 主 党 、 亲 巴 勒 斯 坦 人 阵 的 阿 拉 伯 社 会 主 义 行 动 党 - 半 岛 支 部 和 阿 拉 伯 半 岛 人 民 联 盟 的 左 派 等 组 织 统 一 而 成 的 阿 拉 伯 半 岛 人 民 革 命 党 领 导 ， 奉 行 马 克 思 列 宁 主 义 和 毛 泽 东 思 想 。";
						GlobalScript.inst.gameState.allcountries[101].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[101].SubGosstroy = 17;
						GlobalScript.inst.gameState.allcountries[101].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[101].JoinAllOurAlliances(yes: true);
						GlobalScript.inst.gameState.allcountries[101].isOil = false;
						GlobalScript.inst.gameState.allcountries[101].oar = true;
						GlobalScript.inst.gameState.allcountries[101].Torg = true;
						GlobalScript.inst.gameState.allcountries[101].proprc = true;
						GlobalScript.inst.gameState.allcountries[101].name = " 阿 拉 伯 半 岛 人 民 民 主 共 和 国";
						if (GlobalScript.inst.gameState.IsSocialism(yes: true, 30) && GlobalScript.inst.gameState.allcountries[13].oar && GlobalScript.inst.gameState.allcountries[14].oar && GlobalScript.inst.gameState.allcountries[35].oar && GlobalScript.inst.gameState.allcountries[37].oar && GlobalScript.inst.gameState.allcountries[40].oar && GlobalScript.inst.gameState.allcountries[53].oar && GlobalScript.inst.gameState.allcountries[54].oar && GlobalScript.inst.gameState.allcountries[55].oar && GlobalScript.inst.gameState.allcountries[93].oar && GlobalScript.inst.gameState.allcountries[101].oar && GlobalScript.inst.gameState.allcountries[102].oar && GlobalScript.inst.gameState.allcountries[103].oar && GlobalScript.inst.gameState.allcountries[104].oar && GlobalScript.inst.gameState.allcountries[105].oar && (GlobalScript.inst.gameState.allcountries[24].oar || GlobalScript.inst.gameState.allcountries[25].oar))
						{
							GlobalScript.inst.gameState.allcountries[54].parts[0] = false;
							GlobalScript.inst.gameState.allcountries[30].parts[2] = true;
							GlobalScript.inst.gameState.allcountries[30].name = " 阿 拉 伯 革 命 社 会 主 义 共 和 国";
						}
						GlobalScript.inst.gameState.allcountries[30].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[30].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[30].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[30].Torg = true;
						GlobalScript.inst.gameState.allcountries[30].proprc = true;
						GlobalScript.inst.gameState.allcountries[30].oar = true;
						GlobalScript.inst.gameState.allcountries[30].JoinAllOurAlliances(yes: true);
					}
					else if (GlobalScript.inst.gameState.allcountries[24].parts[0] && GlobalScript.inst.gameState.allcountries[24].prosov)
					{
						text += " 新 的 半 岛 革 命 政 府 由 亲 苏 的 沙 特 阿 拉 伯 共 产 党 、 支 持 马 克 思 主 义 和 纳 赛 尔 主 义 的 阿 拉 伯 半 岛 人 民 联 盟 等 组 织 统 一 而 成 的 阿 拉 伯 半 岛 统 一 革 命 社 会 党 领 导 ， 奉 行 马 克 思 列 宁 主 义 和 阿 拉 伯 民 族 主 义 。";
						GlobalScript.inst.gameState.allcountries[101].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[101].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[101].Torg = true;
						GlobalScript.inst.gameState.allcountries[101].prosov = true;
						GlobalScript.inst.gameState.allcountries[101].name = " 阿 拉 伯 半 岛 民 主 共 和 国";
					}
					else
					{
						text += " 新 的 半 岛 革 命 政 府 由 阿 拉 伯 半 岛 人 民 联 盟 和 沙 特 阿 拉 伯 复 兴 社 会 党 等 组 织 统 一 而 成 的 阿 拉 伯 半 岛 社 会 主 义 联 盟 领 导 ， 奉 行 阿 拉 伯 社 会 主 义 和 阿 拉 伯 民 族 主 义 。";
						GlobalScript.inst.gameState.allcountries[101].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[101].SubGosstroy = 8;
						GlobalScript.inst.gameState.allcountries[101].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[101].isOil = false;
						GlobalScript.inst.gameState.allcountries[101].JoinAllOurAlliances(yes: true);
						GlobalScript.inst.gameState.allcountries[101].oar = true;
						GlobalScript.inst.gameState.allcountries[101].Torg = true;
						GlobalScript.inst.gameState.allcountries[101].proprc = true;
						GlobalScript.inst.gameState.allcountries[101].name = " 阿 拉 伯 半 岛 共 和 国";
					}
					text += " 在 清 算 大 会 上 ， 沙 特 王 室 、 一 众 王 国 贵 族 和 王 国 高 官 被 判 为 人 民 公 敌 ， 处 死 刑 。 新 政 府 开 始 进 行 改 革 ， 没 收 了 帝 国 主 义 的 资 产 ， 开 始 推 行 世 俗 化 、 性 别 平 等 以 及 反 部 落 主 义 的 政 策 。1955年 的 沙 特 自 由 军 官 组 织 、1958年 空 军 军 官 的 纳 赛 尔 主 义 政 变 企 图 以 及 后 来 阿 拉 伯 半 岛 人 民 联 盟 的 游 击 运 动 等 旧 王 国 历 史 上 多 次 反 君 主 制 、 谋 求 民 族 解 放 的 进 步 运 动 都 被 新 政 权 平 反 ， 其 牺 牲 者 将 被 重 新 安 葬 ， 进 入 国 家 烈 士 陵 园 ， 作 为 革 命 英 雄 来 宣 传 。||与 此 同 时 ， 阿 拉 伯 半 岛 的 各 个 革 命 组 织 正 在 筹 备 全 半 岛 在 社 会 主 义 下 的 统 一 。 团 结 起 来 ， 斩 断 了 锁 链 的 半 岛 人 民 ！";
				}
				else
				{
					text = " 沙 特 阿 拉 伯 王 国 付 出 了 元 气 大 伤 的 代 价 ， 利 用 军 队 、 内 政 安 全 部 队 和 警 察 镇 压 了 内 部 起 义 并 阻 止 了 外 部 进 攻 ， 无 法 继 续 推 进 的 联 军 不 得 不 与 王 国 政 府 签 订 停 战 协 议 。 在 沙 特 王 国 内 部 ， 大 量 以 异 见 者 被 逮 捕 ， 王 国 政 府 将 他 们 公 开 斩 首 处 决 。 沙 特 地 下 左 翼 领 导 人 被 特 别 刑 事 法 庭 以 “ 寻 求 外 国 干 预 ， 不 忠 于 君 主 和 组 织 武 装 叛 乱 ” 为 罪 名 判 处 死 刑 ， 幸 存 的 干 部 或 流 亡 于 周 边 的 革 命 阿 拉 伯 国 家 或 向 我 国 寻 求 庇 护 。 与 此 同 时 ， 沙 特 政 府 不 得 不 向 地 方 上 为 平 叛 和 抵 抗 革 命 联 军 的 势 力 让 渡 权 力 。 如 今 ， 沙 特 阿 拉 伯 王 国 开 始 转 向 封 闭 化 和 “ 再 封 建 化 ” 。 革 命 政 权 和 半 岛 最 后 一 个 封 建 政 权 的 对 峙 仍 将 （ 暂 时 ） 僵 持 下 去 。";
					GlobalScript.inst.gameState.influencePRC -= 40;
					GlobalScript.inst.gameState.allcountries[101].LeaveAlliances();
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 38)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.influencePRC += 40;
					GlobalScript.inst.gameState.data[6] += 20;
					Politic[] array4 = GlobalScript.inst.gameState.politics;
					foreach (Politic politic3 in array4)
					{
						if (politic3.traits[0] < 1 || politic3.traits[0] == 20)
						{
							politic3.loyality += 100;
						}
					}
					text = " 毫 无 悬 念 的 ， 伊 拉 克 成 功 的 粉 碎 了 埃 米 尔 的 统 治 。 在 快 速 的 击 溃 抵 抗 之 后 ， 新 的 “ 科 威 特 社 会 主 义 共 和 国 ” 被 建 立 了 起 来 。 新 政 府 由 科 威 特 的 “ 进 步 代 表 ” 科 威 特 人 民 联 盟 组 成 的 科 威 特 社 会 主 义 运 动 执 政 。 该 党 事 实 上 是 伊 拉 克 社 会 主 义 工 农 党 的 支 部 ， 在 “ 公 投 ” 进 行 之 后 ， 以99.9% 的 赞 成 票 与 伊 拉 克 组 成 了 平 等 联 邦 。 新 政 府 着 手 把 科 威 特 石 油 公 司 改 造 为 科 威 特 人 民 化 石 燃 料 公 司 ， 并 通 过 优 化 管 理 层 结 构 来 排 除 旧 王 室 和 外 资 对 其 经 济 政 策 的 影 响 。 旧 王 室 的 大 部 分 成 员 被 判 有 罪 ， 他 们 将 在 遥 远 的 阿 布 · 格 莱 布 监 狱 度 过 余 生 。 而 同 时 ， 流 亡 在 海 外 的 末 代 埃 米 尔 贾 比 尔 三 世 惨 死 在 自 己 的 卧 室 里 ， 身 中7枪 自 杀 而 亡 。 王 朝 的 统 治 彻 底 结 束 了 ， 科 威 特 会 迎 来 自 己 更 美 好 的 未 来 ， 对 吧 ？";
					GlobalScript.inst.gameState.allcountries[36].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[36].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[36].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[36].isOil = false;
					GlobalScript.inst.gameState.allcountries[36].JoinAllOurAlliances(yes: true);
					GlobalScript.inst.gameState.allcountries[36].oar = true;
					GlobalScript.inst.gameState.allcountries[36].name = " 科 威 特 社 会 主 义 共 和 国";
					GlobalScript.inst.gameState.allcountries[36].Torg = true;
					GlobalScript.inst.gameState.allcountries[36].proprc = true;
					GlobalScript.inst.gameState.allcountries[14].parts[5] = true;
				}
				else
				{
					text = " 出 乎 意 料 的 ， 科 威 特 设 法 得 到 了 足 够 的 支 持 ， 并 在 一 定 程 度 上 阻 止 了 伊 拉 克 军 队 进 一 步 前 进 ， 这 为 其 争 取 到 了 宝 贵 的 时 间 。 海 湾 国 家 在 经 济 压 力 并 威 胁 要 求 中 国 调 停 的 前 提 下 迫 使 伊 拉 克 撤 军 。 在 伊 拉 克 撤 退 前 ， 他 们 接 到 命 令 ， 把 科 威 特 的 数 个 油 井 付 之 一 炬 ， 其 目 的 明 显 是 阻 挠 维 和 部 队 的 前 进 。 但 无 论 如 何 ， 伊 拉 克 已 经 撤 出 了 科 威 特 。 让 两 河 之 间 的 国 土 统 一 的 目 标 看 起 来 是 那 么 遥 不 可 及 … …";
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.allcountries[36].LeaveAlliances();
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 39)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.empires[0].relations -= 150;
					if (!GlobalScript.inst.gameState.allcountries[18].cw)
					{
						text = " 在 艰 苦 奋 斗 后 ， 西 撒 人 阵 的 步 战 车 攻 入 了 首 府 阿 尤 恩 的 市 中 心 。 胜 利 的 旗 帜 飘 扬 在 这 座 古 老 的 城 市 上 空 ， 这 天 也 被 定 为 撒 哈 拉 阿 拉 伯 民 主 共 和 国 的 解 放 日 。 工 人 ， 游 击 战 士 和 农 民 推 着 花 车 ， 举 着 “ 自 由 ， 独 立 ， 社 会 主 义 是 我 们 的 目 标 ” 之 类 的 标 语 牌 走 过 市 中 心 ， 这 片 古 老 的 土 地 焕 发 着 前 所 未 有 的 生 命 力 。 而 摩 洛 哥 不 得 不 打 碎 牙 齿 往 嘴 里 吞 ， 苦 涩 的 承 认 了 西 撒 哈 拉 的 独 立 地 位 。";
						GlobalScript.inst.gameState.allcountries[54].parts[0] = false;
						GlobalScript.inst.gameState.allcountries[18].spec = 0;
						GlobalScript.inst.gameState.allcountries[18].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[18].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[18].Torg = true;
						GlobalScript.inst.gameState.influencePRC += 5;
						if (GlobalScript.inst.gameState.ingamewars[39].ussr_place == 1)
						{
							GlobalScript.inst.gameState.allcountries[18].prosov = true;
							GlobalScript.inst.gameState.empires[1].power += 15;
						}
					}
					else
					{
						text = " 在 艰 苦 奋 斗 后 ， 西 撒 人 阵 的 步 战 车 攻 入 了 首 府 阿 尤 恩 的 市 中 心 。 胜 利 的 旗 帜 飘 扬 在 这 座 古 老 的 城 市 上 空 ， 这 天 也 被 定 为 撒 哈 拉 阿 拉 伯 民 主 共 和 国 的 解 放 日 。 工 人 ， 游 击 战 士 和 农 民 推 着 画 有 马 克 思 ， 列 宁 和 毛 泽 东 的 画 像 的 花 车 。 举 着 “ 共 产 主 义 带 来 大 饼 与 和 平 ” 之 类 的 标 语 牌 走 过 市 中 心 ， 这 片 古 老 的 土 地 焕 发 着 前 所 未 有 的 生 命 力 。 而 摩 洛 哥 不 得 不 打 碎 牙 齿 往 嘴 里 吞 ， 苦 涩 的 承 认 了 西 撒 哈 拉 的 独 立 地 位 。||国 际 观 察 家 认 为 ， 西 撒 人 阵 背 后 的 中 华 人 民 共 和 国 又 一 次 在 国 际 交 锋 中 为 自 己 带 来 了 战 友 和 同 志 。";
						GlobalScript.inst.gameState.allcountries[54].parts[0] = false;
						GlobalScript.inst.gameState.allcountries[18].spec = 0;
						GlobalScript.inst.gameState.allcountries[18].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[18].SubGosstroy = 2;
						GlobalScript.inst.gameState.allcountries[18].Torg = true;
						GlobalScript.inst.gameState.allcountries[18].proprc = true;
						GlobalScript.inst.gameState.influencePRC += 20;
					}
				}
				else
				{
					text = " 毫 不 意 外 的 说 ， 摩 洛 哥 以 碾 压 性 的 优 势 击 败 了 西 撒 人 阵 。 在 丢 下 了 一 地 尸 体 和 各 式 辎 重 与 战 车 后 ， 他 们 灰 溜 溜 的 离 开 了 自 己 的 祖 国 ， 逃 往 了 阿 尔 及 利 亚 或 毛 里 塔 尼 亚 北 部 的 弱 国 家 地 区 。 摩 洛 哥 王 国 卫 队 趾 高 气 扬 的 在 阿 尤 恩 展 开 了 阅 兵 ， 哈 桑 二 世 在 庆 功 演 讲 时 说 道 ： “ 只 要 阿 拉 维 王 朝 屹 立 不 倒 ， 西 撒 哈 拉 的 分 离 主 义 者 就 永 无 明 日 ！ ”||美 国 加 大 了 和 摩 洛 哥 王 室 的 合 作 ， 并 在 卡 萨 布 兰 卡 开 始 了 一 个 新 的 监 听 站 。";
					GlobalScript.inst.gameState.empires[0].power += 50;
					GlobalScript.inst.gameState.influencePRC -= 20;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 40)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[563] == 0)
					{
						text = " 伊 斯 兰 救 世 阵 线 成 功 获 得 了 阿 尔 及 利 亚 全 国 政 权 ， 本 · 杰 迪 德 等 一 众 F L N 寡 头 被 俘 ， 随 后 被 救 世 阵 线 以 石 刑 处 死 。 新 政 权 废 除 了 F L N 的 社 会 主 义 宪 法 ， 颁 布 了 以 伊 斯 兰 教 法 为 核 心 的 新 宪 法 ， 随 即 成 立 了 阿 尔 及 利 亚 伊 斯 兰 共 和 国 。 很 快 ， 女 性 被 要 求 戴 上 面 纱 ， 且 被 鼓 励 待 在 家 中 ， 办 公 场 所 也 建 立 起 了 性 别 分 隔 制 度 ； 酒 类 商 店 以 及 音 像 店 等 “ 不 符 合 伊 斯 兰 法 ” 的 场 所 也 被 取 缔 。 于 此 同 时 ， 新 政 权 继 续 采 取 阿 拉 伯 民 族 主 义 的 去 向 ， 开 展 阿 拉 伯 化 ， 阿 拉 伯 语 将 被 运 用 在 更 广 泛 的 领 域 ； 在 意 识 形 态 上 ， 法 国 的 一 切 文 化 都 被 禁 止 进 入 阿 尔 及 利 亚 ， 国 家 禁 止 民 众 收 听 来 自 欧 洲 国 家 的 广 播 和 电 视 ， 只 允 许 民 众 接 收 来 自 如 更 加 保 守 的 阿 拉 伯 君 主 国 家 等 国 家 的 外 国 广 播 和 电 视 。 在 经 济 上 ， 救 世 阵 线 谴 责 F L N 的 社 会 主 义 经 济 政 策 （ 尽 管 在 改 革 下 所 剩 不 多 ） ， 开 始 鼓 励 民 族 资 产 阶 级 和 保 护 私 营 部 门 ， 但 反 对 外 资 进 入 阿 尔 及 利 亚 竞 争 ， 破 坏 民 族 利 益 。 阿 尔 及 利 亚 就 这 样 进 入 一 个 保 守 时 期 。";
						GlobalScript.inst.gameState.allcountries[40].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[40].SubGosstroy = 9;
						GlobalScript.inst.gameState.allcountries[40].Torg = true;
						GlobalScript.inst.gameState.allcountries[40].prosov = false;
						GlobalScript.inst.gameState.influencePRC += 5;
						GlobalScript.inst.gameState.empires[0].power -= 20;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.empires[1].power -= 20;
						GlobalScript.inst.gameState.empires[1].relations -= 150;
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[563] == 1)
					{
						text = " 全 国 民 主 联 盟 成 功 夺 得 了 阿 尔 及 利 亚 全 国 政 权 ， 本 · 杰 迪 德 等 一 众 F L N 寡 头 被 俘 ， 随 后 被 新 政 权 以 谋 杀 、 贪 污 等 罪 名 公 审 处 决 。 该 国 改 名 为 阿 尔 及 利 亚 共 和 国 ， 并 废 除 了 F L N 的 一 党 制 宪 法 。 新 的 民 主 临 时 政 府 开 始 组 织 制 宪 委 员 会 制 定 一 部 民 主 的 多 党 制 宪 法 。 处 于 对 联 盟 内 自 由 派 和 中 左 翼 的 平 衡 ， 布 迪 亚 夫 只 将 左 翼 政 策 表 达 为 “ 社 会 公 平 ” 等 较 模 糊 的 措 辞 ， 当 然 也 采 取 失 业 救 济 和 福 利 政 策 争 取 参 与 了 革 命 的 工 人 阶 级 的 支 持 。 在 民 族 政 策 方 面 ， 新 政 权 承 认 了 柏 柏 尔 民 族 ， 并 推 行 柏 柏 尔 阿 拉 伯 民 族 平 等 的 政 策 ， 并 鼓 励 他 们 发 展 自 己 的 文 化 ， 在 以 柏 柏 尔 人 为 多 数 的 地 区 ， 自 治 地 方 也 被 建 立 起 来 。 伊 斯 兰 教 在 社 会 中 仍 有 影 响 力 ， 进 入 民 主 化 的 阿 尔 及 利 亚 也 将 面 临 转 向 民 主 的 阵 痛 。";
						GlobalScript.inst.gameState.allcountries[40].Gosstroy = 3;
						GlobalScript.inst.gameState.allcountries[40].SubGosstroy = 4;
						GlobalScript.inst.gameState.allcountries[40].Torg = true;
						GlobalScript.inst.gameState.allcountries[40].prosov = false;
						GlobalScript.inst.gameState.influencePRC += 20;
						GlobalScript.inst.gameState.empires[1].power -= 50;
						GlobalScript.inst.gameState.empires[1].relations -= 150;
						GlobalScript.inst.gameState.empires[0].power += 30;
						GlobalScript.inst.gameState.empires[0].relations += 150;
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[563] == 2)
					{
						text = "人 民 民 主 爱 国 阵 线 成 功 夺 得 了 全 国 政 权 ， 成 立 了 阿 尔 及 利 亚 社 会 主 义 共 和 国 。 本 · 杰 迪 德 等 一 众 F L N 寡 头 被 俘 ， 随 后 被 革 命 政 权 以 人 民 公 敌 的 罪 名 公 审 处 决 。 人 民 民 主 爱 国 阵 线 的 多 个 政 党 合 并 改 组 为 阿 尔 及 利 亚 人 民 民 主 党 ， 其 中 包 含 了 一 个 柏 柏 尔 支 部 ， 来 自 前 政 党 的 温 和 左 派 、 多 党 制 的 支 持 者 和 反 共 派 系 则 在 我 们 的 帮 助 下 被 清 洗 和 边 缘 化 。 仍 在 狱 中 的 前 阿 尔 及 利 亚 共 产 党 的 革 命 派 元 老 （ 曾 与 本 · 贝 拉 派 的 F L N 左 派 武 装 反 抗 布 迈 丁 政 变 ） 也 被 放 出 ， 加 入 了 新 的 革 命 政 党 。 该 党 的 章 程 中 含 有 马 克 思 主 义 、 科 学 社 会 主 义 和 阶 级 斗 争 的 内 容 ， 并 融 入 了 F L N 在 本 · 贝 拉 时 期 的 革 命 社 会 主 义 ， 同 时 加 入 了 部 分 列 宁 主 义 和 毛 主 义 的 概 念 ， 但 也 没 有 放 弃 以 反 帝 国 主 义 ， 锡 安 主 义 为 内 核 的 泛 阿 拉 伯 主 义 理 念 。||新 政 权 在 该 国 开 始 实 施 激 进 的 社 会 主 义 改 革 ， 进 行 国 有 化 和 土 地 集 体 化 ， 工 人 也 将 参 与 到 国 营 企 业 的 管 理 中 。 柏 柏 尔 民 族 在 新 政 权 下 与 阿 拉 伯 人 平 等 ， 在 柏 柏 尔 人 为 多 数 的 地 区 ， 也 成 立 了 自 治 政 府 ， 发 展 柏 柏 尔 文 化 被 鼓 励 。 大 量 被 F L N 迫 害 的 共 产 党 战 士 被 作 为 英 雄 表 彰 并 平 反 ， F L N 时 期 的 历 史 也 被 谨 慎 地 再 度 审 视 ， 并 肯 定 其 反 帝 进 步 的 政 策 。 面 对 该 国 的 伊 斯 兰 化 现 状 ， 人 民 民 主 党 采 取 了 世 俗 化 的 方 针 ， 他 们 邀 请 了 阿 尔 巴 尼 亚 人 作 为 顾 问 ， 准 备 进 行 文 化 革 命 。 在 历 经 长 期 斗 争 后 ， 阿 尔 及 利 亚 人 民 终 于 走 上 了 真 正 的 革 命 社 会 主 义 道 路 。";
						GlobalScript.inst.gameState.allcountries[40].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[40].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[40].Torg = true;
						GlobalScript.inst.gameState.allcountries[40].prosov = false;
						GlobalScript.inst.gameState.allcountries[40].proprc = true;
						GlobalScript.inst.gameState.influencePRC += 20;
						GlobalScript.inst.gameState.empires[0].power -= 50;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.empires[1].power += 20;
						GlobalScript.inst.gameState.empires[1].relations += 100;
					}
				}
				else
				{
					text = " 本 · 杰 迪 德 和 F L N 成 功 镇 压 了 阿 尔 及 利 亚 人 民 的 革 命 运 动 。 本 · 杰 迪 德 很 快 宣 布 ， 阿 尔 及 利 亚 进 入 戒 严 。 参 与 革 命 的 学 生 将 被 直 接 开 除 ， 群 众 运 动 的 活 动 家 被 逮 捕 和 处 决 ， 而 学 校 、 工 厂 和 清 真 寺 等 场 所 将 由 军 队 直 接 军 管 。 与 此 同 时 ， 政 府 对 柏 柏 尔 人 也 采 取 了 更 加 强 硬 的 政 策 ， 柏 柏 尔 聚 居 区 将 增 派 驻 军 ， 由 驻 地 军 团 进 行 军 事 管 制 ， 随 着 政 权 再 强 硬 化 带 来 的 是 更 严 格 的 阿 拉 伯 化 ， 以 重 返 布 迈 丁 时 期 的 的 国 家 安 全 政 策 。 各 个 地 下 反 对 派 被 搜 捕 ， 而 强 硬 化 也 安 抚 了 F L N 内 部 对 本 · 杰 迪 德 的 不 满 ， 他 的 的 权 力 将 更 加 巩 固 。 阿 尔 及 利 亚 的 事 情 不 会 就 这 样 过 去 的 ， 矛 盾 并 未 解 决 的 阿 尔 及 利 亚 的 未 来 并 不 会 太 平 。";
					GlobalScript.inst.gameState.empires[0].power += 50;
					GlobalScript.inst.gameState.influencePRC -= 20;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 41)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[565] == 0)
					{
						text = " 在 我 们 的 帮 助 下 ， 圣 战 者 战 斗 先 锋 队 得 以 夺 取 了 整 个 叙 利 亚 ， 宣 告 建 立 叙 利 亚 伊 斯 兰 国 。 1 9 7 3 年 宪 法 被 废 除 ， 取 而 代 之 的 是 一 部 以 伊 斯 兰 教 法 为 基 础 的 新 宪 法 ， 哈 拉 维 派 和 前 政 府 官 员 被 大 肆 迫 害 。 叙 利 亚 借 此 成 为 伊 斯 兰 教 尤 其 是 逊 尼 派 极 端 组 织 的 支 持 者 。";
						GlobalScript.inst.gameState.allcountries[35].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[35].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[35].SubGosstroy = 9;
						GlobalScript.inst.gameState.allcountries[35].Torg = true;
						GlobalScript.inst.gameState.influencePRC += 40;
						GlobalScript.inst.gameState.empires[0].power -= 20;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.empires[1].power -= 50;
						GlobalScript.inst.gameState.empires[1].relations -= 200;
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[565] == 1)
					{
						text = " 在 我 们 的 帮 助 下 ， 民 族 民 主 大 会 终 于 击 溃 了 窃 取 复 兴 社 会 党 政 权 的 军 官 们 ， 并 宣 告 成 立 叙 利 亚 社 会 主 义 共 和 国 。 里 法 特 • 阿 萨 德 在 试 图 伪 装 成 士 兵 逃 跑 时 被 流 弹 打 死 ， 复 兴 社 会 党 的 整 个 历 史 被 重 新 评 估 ， 平 反 被 清 洗 的 新 左 派 和 被 关 在 监 狱 里 的 贾 迪 德 。 民 族 民 主 大 会 内 部 数 个 党 派 则 合 并 成 为 叙 利 亚 革 命 社 会 主 义 党 ， 前 外 交 部 长 易 卜 拉 欣 • 拉 库 斯 担 任 共 和 国 总 统 ， 叙 共 - 政 治 局 理 论 家 里 雅 德 • 图 尔 克 担 任 共 和 国 总 理 ， 贾 迪 德 则 担 任 新 召 开 的 叙 利 亚 人 民 大 会 主 席 ， 叙 利 亚 革 命 社 会 主 义 党 在 党 纲 内 确 立 以 马 克 思 主 义 为 指 导 思 想 ， 并 加 入 列 宁 主 义 和 毛 主 义 的 部 分 理 念 ， 保 留 了 支 持 泛 阿 拉 伯 主 义 ， 反 帝 国 主 义 和 反 锡 安 主 义 等 主 张 。 新 政 府 开 始 实 行 激 进 国 有 化 与 土 地 集 体 化 政 策 ， 并 在 库 尔 德 ， 亚 美 尼 亚 等 少 数 民 族 的 聚 集 区 设 立 自 治 政 府 。 叙 利 亚 在 经 历 了 数 十 年 斗 争 后 终 于 走 向 了 革 命 的 社 会 主 义 道 路 。";
						GlobalScript.inst.gameState.allcountries[35].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[35].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[35].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[35].Torg = true;
						GlobalScript.inst.gameState.allcountries[35].proprc = true;
						GlobalScript.inst.gameState.influencePRC += 40;
						GlobalScript.inst.gameState.empires[0].power -= 20;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.empires[1].power -= 50;
						GlobalScript.inst.gameState.empires[1].relations -= 200;
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[565] == 2)
					{
						text = " 在 我 们 与 西 方 国 家 的 共 同 帮 助 下 ， 叙 利 亚 自 由 联 盟 终 于 击 败 了 阿 拉 伯 社 会 主 义 分 子 。 里 法 特 • 阿 萨 德 和 他 的 几 个 部 下 逃 到 了 伊 拉 克 寻 求 庇 护 。 新 政 府 宣 布 成 立 叙 利 亚 第 四 共 和 国 ，";
						GlobalScript.inst.gameState.allcountries[35].LeaveAlliances();
						if (!GlobalScript.inst.gameState.allcountries[51].cw && GlobalScript.inst.gameState.allcountries[31].isSENTO)
						{
							text += " 并 决 定 加 入 中 央 条 约 组 织 ，";
							GlobalScript.inst.gameState.allcountries[35].isSENTO = true;
						}
						if (GlobalScript.inst.gameState.allcountries[51].cw && GlobalScript.inst.gameState.allcountries[1].isSEATO)
						{
							text += " 并 决 定 加 入 泛 亚 联 盟 ，";
							GlobalScript.inst.gameState.allcountries[35].isASEAN = true;
							GlobalScript.inst.gameState.allcountries[35].isSEATO = true;
						}
						text += "恢 复 1 9 5 0 年 宪 法 ， 复 兴 社 会 党 在 内 的 左 翼 政 党 被 大 量 取 缔 ， 私 有 资 本 和 外 资 则 被 鼓 励 。 新 政 权 任 命 亲 西 的 前 高 官 纳 齐 姆 • 库 德 西 为 新 总 统 ， 法 官 海 瑟 姆 • 马 利 赫 为 新 总 理 ， 国 会 选 举 将 会 在 一 年 内 进 行 ， 而 对 于 库 尔 德 等 少 数 民 族 聚 集 区 则 开 始 进 行 自 治 谈 判 。 叙 利 亚 兜 兜 转 转 数 十 年 终 于 回 到 了 起 点 。";
						GlobalScript.inst.gameState.allcountries[35].Gosstroy = 3;
						GlobalScript.inst.gameState.allcountries[35].SubGosstroy = 6;
						GlobalScript.inst.gameState.allcountries[35].Torg = true;
						GlobalScript.inst.gameState.allcountries[35].Vyshi = true;
						GlobalScript.inst.gameState.influencePRC += 40;
						GlobalScript.inst.gameState.empires[0].power += 50;
						GlobalScript.inst.gameState.empires[0].relations += 150;
						GlobalScript.inst.gameState.empires[1].power -= 50;
						GlobalScript.inst.gameState.empires[1].relations -= 200;
					}
				}
				else
				{
					GlobalScript.inst.gameState.allcountries[35].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[35].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[35].prosov = true;
					if (GlobalScript.inst.gameState.resultOfEvents[565] == 0)
					{
						text = " 在 苏 联 的 帮 助 下 ， 叙 利 亚 政 府 军 的 部 队 终 于 击 溃 了 反 叛 者 的 部 队 。 虽 然 全 国 范 围 内 依 旧 有 少 量 抵 抗 势 力 ， 但 是 他 们 已 经 掀 不 起 什 么 风 浪 了 ， 战 后 的 重 建 自 然 也 由 苏 联 帮 忙 。 经 此 一 役 ， 叙 利 亚 与 苏 联 的 关 系 变 得 更 为 亲 密 ， 并 继 续 维 持 泛 阿 拉 伯 思 想 ， 与 伊 拉 克 支 部 的 和 解 也 正 在 进 行 ， 对 阿 萨 德 兄 弟 的 个 人 崇 拜 在 全 国 范 围 内 宣 传 了 起 来 。 与 此 同 时 ， 民 族 进 步 阵 线 被 进 一 步 清 洗 ， 而 对 反 世 俗 主 义 的 穆 兄 会 等 组 织 则 继 续 延 续 镇 压 政 策 ， 并 在 哈 马 等 地 对 穆 兄 会 成 员 大 肆 屠 杀 ， 席 卷 全 国 的 反 对 派 运 动 最 后 被 消 灭 ， 阿 萨 德 家 族 在 经 历 数 年 动 荡 后 终 于 彻 底 掌 握 了 叙 利 亚 。";
						GlobalScript.inst.gameState.influencePRC -= 20;
						GlobalScript.inst.gameState.empires[1].power += 20;
						GlobalScript.inst.gameState.empires[1].relations += 100;
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[565] == 1)
					{
						text = " 在 苏 联 的 帮 助 下 ， 叙 利 亚 政 府 的 部 队 终 于 击 退 了 反 叛 者 的 部 队 。 但 是 民 主 民 主 大 会 在 东 北 部 的 库 尔 德 聚 集 区 站 稳 了 脚 跟 并 成 功 击 退 了 叙 利 亚 政 府 的 攻 势 ， 双 方 因 此 被 迫 停 火 。 北 叙 利 亚 在 停 火 后 被 库 尔 德 工 人 党 政 变 ， 成 立 了 库 尔 德 民 主 共 和 国 ，并 与 中 国 保 持 密 切 关 系 。";
						GlobalScript.inst.gameState.allcountries[157].parts[1] = true;
						GlobalScript.inst.gameState.allcountries[157].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[157].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[157].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[157].Torg = true;
						GlobalScript.inst.gameState.allcountries[157].proprc = true;
						GlobalScript.inst.gameState.allcountries[157].name = " 北 叙 利 亚";
						if (GlobalScript.inst.gameState.allcountries[157].parts[0])
						{
							text += " 北 伊 拉 克 和 北 叙 利 亚 这 对 难 兄 难 弟 抱 团 取 暖 ， 最 后 公 投 决 定 合 并 成 为 统 一 的 库 尔 德 斯 坦 。 ";
							GlobalScript.inst.gameState.allcountries[157].parts[0] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[1] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[2] = true;
							GlobalScript.inst.gameState.allcountries[157].name = " 北 叙 - 北 伊 联 邦";
						}
						text += " 经 此 一 役 ， 席 卷 全 国 的 反 对 派 运 动 终 于 被 消 灭 ， 叙 利 亚 与 苏 联 的 关 系 变 得 更 为 亲 密 ， 并 继 续 维 持 泛 阿 拉 伯 思 想 ， 与 伊 拉 克 支 部 的 和 解 也 正 在 进 行 ， 对 阿 萨 德 兄 弟 的 个 人 崇 拜 在 全 国 范 围 内 宣 传 了 起 来 。 与 此 同 时 ， 民 族 进 步 阵 线 被 进 一 步 清 洗 ， 抓 捕 到 的 政 治 犯 将 监 狱 塞 的 满 满 当 当 的 ， 南 叙 利 亚 将 继 续 在 阿 萨 德 家 族 的 统 治 下 。";
						GlobalScript.inst.gameState.influencePRC -= 20;
						GlobalScript.inst.gameState.empires[1].power += 20;
						GlobalScript.inst.gameState.empires[1].relations += 100;
					}
					else if (GlobalScript.inst.gameState.resultOfEvents[565] == 2)
					{
						text = " 在 苏 联 的 帮 助 下 ， 叙 利 亚 政 府 的 部 队 终 于 击 退 了 反 叛 者 的 部 队 。 叙 利 亚 自 由 联 盟 被 迫 逃 到 北 部 的 库 尔 德 人 聚 集 区 ， 并 在 此 地 击 退 了 叙 利 亚 政 府 的 攻 势 ， 双 方 因 此 被 迫 停 火 。 停 火 后 的 自 由 联 盟 内 部 斗 争 不 断 ， 北 叙 利 亚 内 部 的 叙 库 民 主 党 借 此 机 会 发 动 政 变 ， 宣 布 库 尔 德 斯 坦 的 独 立 ， 解 散 了 叙 利 亚 自 由 联 盟 ， 并 将 自 由 联 盟 其 他 成 员 送 给 叙 利 亚 ， 作 为 条 件 ， 叙 利 亚 将 会 承 认 库 尔 德 的 独 立 ， 双 方 将 保 持 友 好 的 经 济 往 来 。";
						GlobalScript.inst.gameState.allcountries[157].parts[1] = true;
						GlobalScript.inst.gameState.allcountries[157].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[157].Gosstroy = 3;
						GlobalScript.inst.gameState.allcountries[157].SubGosstroy = 6;
						GlobalScript.inst.gameState.allcountries[157].name = " 北 叙 利 亚";
						GlobalScript.inst.gameState.allcountries[157].Torg = true;
						GlobalScript.inst.gameState.influencePRC -= 20;
						GlobalScript.inst.gameState.empires[1].power += 20;
						GlobalScript.inst.gameState.empires[1].relations += 100;
						if (GlobalScript.inst.gameState.allcountries[157].parts[0])
						{
							text += " 出 人 意 料 的 是 ，北 伊 拉 克 和 北 叙 利 亚 、 自 由 派 与 共 产 主 义 者 竟 会 因 为 反 对 一 群 “ 社 会 主 义 者 ” 而 走 到 一 起 。 但 很 明 显 双 方 除 了 反 抗 复 兴 党 政 权 外 毫 无 共 通 之 处 。也 许 他 们 只 能 维 持 很 短 一 段 时 间 的 和 平 … … ";
							GlobalScript.inst.gameState.allcountries[157].parts[0] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[1] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[2] = true;
							GlobalScript.inst.gameState.allcountries[157].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[157].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[157].SubGosstroy = 3;
							GlobalScript.inst.gameState.allcountries[157].name = " 北 叙 - 北 伊 联 邦";
						}
						text += " 经 此 一 役 ， 席 卷 全 国 的 反 对 派 运 动 终 于 被 消 灭 ， 叙 利 亚 与 苏 联 的 关 系 变 得 更 为 亲 密 ， 并 继 续 维 持 泛 阿 拉 伯 思 想 ， 与 伊 拉 克 支 部 的 和 解 也 正 在 进 行 ， 对 阿 萨 德 兄 弟 的 个 人 崇 拜 在 全 国 范 围 内 宣 传 了 起 来 。 与 此 同 时 ， 民 族 进 步 阵 线 被 进 一 步 清 洗 ， 而 对 反 世 俗 主 义 的 穆 兄 会 等 组 织 则 继 续 延 续 镇 压 政 策 ， 叙 利 亚 的 监 狱 被 送 来 的 反 对 派 政 治 犯 塞 的 满 满 当 当 ， 叙 利 亚 的 命 运 最 后 稳 稳 的 掌 握 在 了 阿 萨 德 家 族 之 手 。";
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 42)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					text = " 在 伊 拉 克 爱 国 同 盟 接 连 不 断 的 进 攻 ， 以 及 内 部 接 连 不 断 的 起 义 。 萨 达 姆 政 权 最 终 死 于 内 外 交 困 中 。 在 群 众 的 欢 呼 下 ， 萨 达 姆 的 铜 质 雕 像 被 一 辆 挖 掘 机 推 倒 。 其 本 人 在 一 场 针 对 前 复 兴 党 要 员 的 审 判 中 被 判 有 罪 。 刽 子 手 把 绞 索 套 上 了 这 个 独 裁 者 的 脖 子 ， 死 前 仍 在 念 叨 着 真 主 尊 名 的 仆 人 不 一 会 儿 就 去 到 了 那 流 着 奶 与 蜜 的 天 国 。 爱 国 同 盟 也 改 组 为 伊 拉 克 社 会 主 义 工 农 党 ， 其 中 包 含 了 一 个 额 外 的 库 尔 德 支 部 。 该 党 的 章 程 大 量 加 入 了 马 克 思 ， 列 宁 和 毛 泽 东 主 义 的 内 容 ， 但 也 没 有 放 弃 以 反 帝 国 主 义 ， 锡 安 主 义 为 内 核 的 泛 阿 拉 伯 主 义 内 容 。 在 本 党 的 第 一 届 大 会 上 ， 大 会 选 举 了 马 哈 茂 德 · 沙 姆 萨 博 士 为 党 主 席 。 前 伊 拉 克 共 产 党 总 书 记 阿 齐 兹 · 穆 罕 默 德 当 选 为 政 府 总 理 ， 而 在 革 命 里 立 下 赫 赫 战 功 的 阿 卜 · 约 瑟 夫 担 任 国 防 委 员 会 委 员 长 。 库 尔 德 自 治 地 区 则 有 自 己 的 政 府 班 子 。||大 量 复 兴 党 时 期 的 冤 假 错 案 也 得 到 平 反 ， 尤 其 是 对 斋 月 革 命 的 再 评 价 。 原 先 的 萨 达 姆 雕 像 纷 纷 被 拆 除 ， 融 化 。 一 尊 刻 画 有 男 性 农 民 ， 女 性 工 人 ， 军 人 和 库 尔 德 民 兵 的 雕 像 在 巴 格 达 的 广 场 上 树 立 了 起 来 ， 用 于 纪 念 全 伊 拉 克 的 爱 国 者 在 推 翻 萨 达 姆 政 权 中 的 贡 献 。 大 量 的 国 有 企 业 也 经 历 了 不 同 程 度 的 公 有 化 ， 从 工 人 参 与 管 理 到 工 人 决 定 生 产 ， 伊 拉 克 真 真 确 确 的 走 上 了 自 由 ， 统 一 ， 共 产 主 义 的 道 路 。||美 国 强 烈 谴 责 该 政 权 的 “ 侵 犯 人 权 ” ， 可 我 们 都 知 道 这 是 胡 搅 蛮 缠 ！";
					GlobalScript.inst.gameState.allcountries[14].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 2;
					GlobalScript.inst.gameState.allcountries[14].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[14].Torg = true;
					GlobalScript.inst.gameState.allcountries[14].name = " 伊 拉 克 社 会 主 义 联 邦";
					GlobalScript.inst.gameState.allcountries[14].proprc = true;
					GlobalScript.inst.gameState.allcountries[14].puppetOf = -1;
					GlobalScript.inst.gameState.influencePRC += 50;
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.empires[0].relations -= 150;
					GlobalScript.inst.gameState.empires[1].power -= 20;
					GlobalScript.inst.gameState.empires[1].relations -= 50;
				}
				else
				{
					text = " 弱 小 的 爱 国 同 盟 没 能 击 败 复 兴 党 ， 但 复 兴 党 也 没 能 彻 底 击 败 对 手 。 在 南 下 的 战 略 失 败 后 ， 依 托 稳 固 的 防 御 区 ， 爱 国 同 盟 保 障 了 北 部 的 安 全 ， 并 建 立 了 伊 拉 克 民 主 共 和 国 。";
					GlobalScript.inst.gameState.allcountries[157].parts[0] = true;
					if (GlobalScript.inst.gameState.allcountries[157].parts[1])
					{
						if (GlobalScript.inst.gameState.allcountries[157].Gosstroy == 3)
						{
							text += " 出 人 意 料 的 是 ，北 伊 拉 克 和 北 叙 利 亚 、 自 由 派 与 共 产 主 义 者 竟 会 因 为 反 对 一 群 “ 社 会 主 义 者 ” 而 走 到 一 起 。 但 很 明 显 双 方 除 了 反 抗 复 兴 党 政 权 外 毫 无 共 通 之 处 。也 许 他 们 只 能 维 持 很 短 一 段 时 间 的 和 平 … … ";
							GlobalScript.inst.gameState.allcountries[157].parts[0] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[1] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[2] = true;
							GlobalScript.inst.gameState.allcountries[157].name = " 北 叙 - 北 伊 联 邦";
							GlobalScript.inst.gameState.allcountries[157].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[157].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[157].SubGosstroy = 3;
							GlobalScript.inst.gameState.allcountries[157].Torg = true;
						}
						else if (GlobalScript.inst.gameState.allcountries[157].Gosstroy == 1)
						{
							text += " 北 伊 拉 克 和 北 叙 利 亚 这 对 难 兄 难 弟 抱 团 取 暖 ， 最 后 公 投 决 定 合 并 成 为 统 一 的 库 尔 德 斯 坦 。 ";
							GlobalScript.inst.gameState.allcountries[157].parts[0] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[1] = false;
							GlobalScript.inst.gameState.allcountries[157].parts[2] = true;
							GlobalScript.inst.gameState.allcountries[157].name = " 北 叙 - 北 伊 联 邦";
							GlobalScript.inst.gameState.allcountries[157].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[157].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[157].SubGosstroy = 1;
							GlobalScript.inst.gameState.allcountries[157].proprc = true;
							GlobalScript.inst.gameState.allcountries[157].Torg = true;
						}
					}
					else
					{
						text += " 该 政 权 依 然 坚 持 反 对 复 兴 党 ， 但 孤 立 无 援 的 他 们 还 能 存 活 多 久 呢 ？ ";
						GlobalScript.inst.gameState.allcountries[157].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[157].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[157].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[157].Torg = true;
						GlobalScript.inst.gameState.allcountries[157].proprc = true;
						GlobalScript.inst.gameState.allcountries[157].name = "伊 拉 克 民 主 共 和 国";
					}
					text += "||同 时 ， 萨 达 姆 政 权 也 展 开 了 新 一 轮 针 对 潜 在 赤 匪 的 清 洗 ， 以 及 更 大 规 模 的 针 对 少 数 族 裔 的 迫 害 。 由 他 的 儿 子 指 挥 的 共 和 国 卫 队 经 常 骚 扰 新 生 的 共 和 国 的 边 界 ， 在 一 番 烧 杀 抢 掠 后 立 刻 逃 走 。 常 常 有 工 厂 和 农 场 的 工 人 被 杀 死 ， 或 者 公 路 遭 到 破 坏 ， 甚 至 包 括 使 用 沙 林 毒 气 ， 神 经 毒 气 和 炭 疽 炮 弹 。 而 阿 布 · 格 莱 德 监 狱 又 要 忙 起 来 了 … …";
					GlobalScript.inst.gameState.allcountries[14].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[14].Torg = false;
					GlobalScript.inst.gameState.empires[0].power += 50;
					GlobalScript.inst.gameState.influencePRC -= 20;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 43)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.influencePRC += 40;
					GlobalScript.inst.gameState.data[6] += 20;
					Politic[] array4 = GlobalScript.inst.gameState.politics;
					foreach (Politic politic4 in array4)
					{
						if (politic4.traits[0] < 1 || politic4.traits[0] == 20)
						{
							politic4.loyality += 100;
						}
					}
					text = "在 我 们 以 及 各 国 革 命 同 志 的 帮 助 下 ， 阿 湾 人 阵 成 功 解 放 了 阿 曼 、 阿 联 酋 、 卡 塔 尔 和 巴 林 ， 成 立 了 海 湾 联 合 共 和 国 ， 并 开 始 进 行";
					GlobalScript.inst.gameState.allcountries[102].name = " 海 湾 联 合 共 和 国";
					GlobalScript.inst.gameState.allcountries[103].name = " 海 湾 联 合 共 和 国";
					GlobalScript.inst.gameState.allcountries[105].name = " 海 湾 联 合 共 和 国";
					if (GlobalScript.inst.gameState.allcountries[24].parts[0])
					{
						text += " 人 民 民 主";
						if (GlobalScript.inst.gameState.allcountries[24].proprc)
						{
							GlobalScript.inst.gameState.allcountries[102].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[102].SubGosstroy = 17;
							GlobalScript.inst.gameState.allcountries[102].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[102].isOil = false;
							GlobalScript.inst.gameState.allcountries[102].JoinAllOurAlliances(yes: true);
							GlobalScript.inst.gameState.allcountries[102].oar = true;
							GlobalScript.inst.gameState.allcountries[102].Torg = true;
							GlobalScript.inst.gameState.allcountries[102].proprc = true;
							GlobalScript.inst.gameState.allcountries[103].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[103].SubGosstroy = 17;
							GlobalScript.inst.gameState.allcountries[103].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[103].isOil = false;
							GlobalScript.inst.gameState.allcountries[103].JoinAllOurAlliances(yes: true);
							GlobalScript.inst.gameState.allcountries[103].oar = true;
							GlobalScript.inst.gameState.allcountries[103].Torg = true;
							GlobalScript.inst.gameState.allcountries[103].proprc = true;
							GlobalScript.inst.gameState.allcountries[105].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[105].SubGosstroy = 17;
							GlobalScript.inst.gameState.allcountries[105].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[105].isOil = false;
							GlobalScript.inst.gameState.allcountries[105].JoinAllOurAlliances(yes: true);
							GlobalScript.inst.gameState.allcountries[105].oar = true;
							GlobalScript.inst.gameState.allcountries[105].Torg = true;
							GlobalScript.inst.gameState.allcountries[105].proprc = true;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[102].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[102].SubGosstroy = 1;
							GlobalScript.inst.gameState.allcountries[102].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[102].isOil = false;
							GlobalScript.inst.gameState.allcountries[102].Torg = true;
							GlobalScript.inst.gameState.allcountries[102].prosov = true;
							GlobalScript.inst.gameState.allcountries[103].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[103].SubGosstroy = 1;
							GlobalScript.inst.gameState.allcountries[103].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[103].isOil = false;
							GlobalScript.inst.gameState.allcountries[103].Torg = true;
							GlobalScript.inst.gameState.allcountries[103].prosov = true;
							GlobalScript.inst.gameState.allcountries[105].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[105].SubGosstroy = 1;
							GlobalScript.inst.gameState.allcountries[105].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[105].isOil = false;
							GlobalScript.inst.gameState.allcountries[105].Torg = true;
							GlobalScript.inst.gameState.allcountries[105].prosov = true;
						}
					}
					else
					{
						text += " 民 族 民 主";
						GlobalScript.inst.gameState.allcountries[102].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[102].SubGosstroy = 8;
						GlobalScript.inst.gameState.allcountries[102].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[102].isOil = false;
						GlobalScript.inst.gameState.allcountries[102].JoinAllOurAlliances(yes: true);
						GlobalScript.inst.gameState.allcountries[102].oar = true;
						GlobalScript.inst.gameState.allcountries[102].Torg = true;
						GlobalScript.inst.gameState.allcountries[102].prosov = true;
						GlobalScript.inst.gameState.allcountries[103].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[103].SubGosstroy = 8;
						GlobalScript.inst.gameState.allcountries[103].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[103].isOil = false;
						GlobalScript.inst.gameState.allcountries[103].JoinAllOurAlliances(yes: true);
						GlobalScript.inst.gameState.allcountries[103].oar = true;
						GlobalScript.inst.gameState.allcountries[103].Torg = true;
						GlobalScript.inst.gameState.allcountries[103].prosov = true;
						GlobalScript.inst.gameState.allcountries[105].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[105].SubGosstroy = 8;
						GlobalScript.inst.gameState.allcountries[105].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[105].isOil = false;
						GlobalScript.inst.gameState.allcountries[105].JoinAllOurAlliances(yes: true);
						GlobalScript.inst.gameState.allcountries[105].oar = true;
						GlobalScript.inst.gameState.allcountries[105].Torg = true;
						GlobalScript.inst.gameState.allcountries[105].prosov = true;
					}
					text += " 的 建 设 ， 并 为 未 来 的 社 会 主 义 做 铺 垫 。 新 政 权 宣 布 取 消 伊 斯 兰 法 ， 推 行 世 俗 化 ， 废 除 一 夫 多 妻 制 ， 并 大 力 推 行 性 别 平 等 的 政 策 ， 而 帝 国 主 义 在 海 湾 各 国 的 资 产 均 被 没 收 ， 成 为 了 国 营 企 业 ， 在 农 村 ， 土 地 改 革 运 动 和 反 部 落 运 动 也 在 大 力 推 进 ， 阿 拉 伯 湾 的 各 个 君 主 和 他 们 的 家 族 都 被 公 审 处 决 ， 部 落 、 地 主 、 贵 族 以 及 各 级 领 主 都 失 去 了 势 力 ， 其 中 的 顽 固 分 子 则 被 关 入 劳 改 营 。 如 今 ， 阿 拉 伯 湾 的 人 民 正 走 在 大 路 上 ！";
				}
				else
				{
					text = " 在 英 美 帝 国 主 义 和 周 边 反 动 政 权 的 联 合 支 持 下 ， 阿 湾 人 阵 的 革 命 被 绞 杀 了 。 支 持 革 命 的 群 众 （ 特 别 是 根 据 地 的 群 众 ） 被 君 主 的 部 队 施 以 报 复 性 屠 杀 ， 幸 存 者 不 得 不 流 亡 也 门 （ 而 也 门 也 将 面 临 来 自 周 边 的 更 大 敌 意 ） 。 正 如 上 一 次 革 命 一 样 ， 阿 湾 人 阵 撤 回 了 也 门 ， 只 能 不 时 派 出 游 击 小 队 袭 扰 阿 曼 。 与 阿 湾 人 阵 相 关 的 话 题 在 这 些 海 湾 君 主 国 家 成 为 了 禁 忌 ， 时 间 依 然 在 向 前 ， 但 又 像 无 事 发 生 — — 酋 长 、 苏 丹 和 国 王 们 依 然 与 帝 国 主 义 维 持 着 “ 特 殊 的 友 谊 ” ， 而 伊 斯 兰 法 也 像 从 来 没 有 被 动 摇 过 一 样 ， 继 续 存 在 着 。";
					GlobalScript.inst.gameState.influencePRC -= 40;
					GlobalScript.inst.gameState.allcountries[102].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[102].Vyshi = true;
					GlobalScript.inst.gameState.allcountries[103].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[103].Vyshi = true;
					GlobalScript.inst.gameState.allcountries[105].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[105].Vyshi = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 44)
			{
				GlobalScript.inst.gameState.allcountries[127].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 400)
				{
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.influencePRC += 20;
					Politic[] array4 = GlobalScript.inst.gameState.politics;
					foreach (Politic politic5 in array4)
					{
						if (politic5.traits[0] < 1 || politic5.traits[0] == 20)
						{
							politic5.loyality += 100;
						}
					}
					text = " 事 实 证 明 了 残 暴 的 殖 民 主 义 者 已 经 是 时 代 的 泪 水 了 ， 当 武 器 的 代 差 被 磨 平 ， 再 也 没 有 马 塔 贝 勒 战 争 的 那 种 神 迹 了 。 凭 借 着 错 综 复 杂 的 地 形 ， 来 自 多 年 游 击 战 争 的 磨 练 ， 以 及 同 仇 敌 忾 的 愤 怒 。 南 非 军 队 遭 受 了 前 所 未 有 的 打 击 。 不 仅 直 升 机 和 重 火 力 的 优 势 无 法 被 利 用 ， 甚 至 变 成 了 阻 碍 。 灵 活 多 变 的 游 击 战 士 总 能 找 到 车 队 中 最 薄 弱 的 部 分 ， 从 而 施 以 打 击 。 在 抛 下 上 千 具 尸 体 和 数 百 辆 作 战 车 辆 后 ， 南 非 灰 溜 溜 的 逃 离 了 战 场 。||出 乎 意 料 的 是 ， 前 总 理 伊 安 · 史 密 斯 （ 他 并 没 有 离 开 该 国 ） 被 《 津 巴 布 韦 先 驱 报 》 的 记 者 采 访 到 了 。 就 这 场 战 争 ， 记 者 和 前 总 理 间 发 生 了 一 段 妙 趣 横 生 的 谈 话 ， 谈 话 以 这 样 的 一 句 话 结 束 “ 这 群 种 地 的 白 佬 真 是 幼 稚 病 入 脑 ！ 打 击 敌 人 的 目 的 是 为 了 建 立 稳 定 的 社 会 ， 又 不 是 为 了 把 对 面 赶 尽 杀 绝 ！ 也 许 我 那 时 候 真 的 错 了 ？ ”";
				}
				else
				{
					text = " 在 久 经 沙 场 的 南 非 军 人 眼 里 ， 非 洲 人 的 军 队 果 然 如 同 他 们 期 望 的 一 触 即 溃 了 。 甚 至 诞 生 了 三 十 名 南 非 士 兵 反 向 包 围 了 一 千 名 津 巴 布 韦 正 规 军 和 民 兵 的 混 编 队 伍 、 在 付 出 了 数 百 人 的 伤 亡 后 向 无 一 伤 亡 的 南 非 人 投 降 事 迹 。 该 国 领 导 人 逃 向 了 赞 比 亚 ， 用 于 作 为 前 往 苏 联 或 者 是 中 国 的 中 转 站 。 绿 白 旗 再 度 在 哈 拉 雷 ， 或 者 说 索 尔 兹 伯 里 的 上 空 飘 扬 。 然 而 ， 在 胜 利 后 ， 南 非 和 他 们 的 仆 从 军 将 面 临 着 许 多 问 题 - 广 大 的 津 巴 布 韦 雨 林 逐 渐 吞 没 着 南 非 的 占 领 军 。 白 人 南 非 陷 入 了 战 略 困 境 - 倘 若 立 即 撤 出 “ 罗 得 西 亚 ” ， 那 么 再 度 复 出 的 罗 得 西 亚 阵 线 党 政 权 必 然 陷 入 不 断 的 起 义 中 ， 被 愤 怒 的 非 洲 人 所 淹 没 。 但 如 果 不 撤 出 ， 那 么 很 有 可 能 ， 津 巴 布 韦 将 吞 没 南 非 男 儿 的 血 液 ， 就 像 安 哥 拉 ， 西 南 非 洲 和 莫 桑 比 克 那 样 。 不 用 说 ， 国 际 社 会 的 制 裁 让 事 情 雪 上 加 霜 了 。 事 实 上 ， 南 非 已 经 陷 入 了 非 洲 的 又 一 台 绞 肉 机 。 但 无 论 如 何 ，<color=red>津 巴 布 韦 完 蛋 了</color>";
					GlobalScript.inst.gameState.influencePRC -= 40;
					GlobalScript.inst.gameState.allcountries[127].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[127].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[127].puppetOf = 131;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 45)
			{
				GlobalScript.inst.gameState.allcountries[140].parts[1] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.empires[0].relations -= 150;
					GlobalScript.inst.gameState.influencePRC += 20;
					GlobalScript.inst.gameState.allcountries[145].Torg = true;
					GlobalScript.inst.gameState.allcountries[140].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[145].proprc = true;
					Politic[] array4 = GlobalScript.inst.gameState.politics;
					foreach (Politic politic6 in array4)
					{
						if (politic6.traits[0] < 1 || politic6.traits[0] == 20)
						{
							politic6.loyality += 100;
						}
					}
					text = " 在 古 巴 和 中 国 军 事 顾 问 ， 以 及 大 量 来 自 中 国 的 物 资 援 助 下 ， 人 民 革 命 军 所 领 导 的 左 翼 联 盟 在 残 酷 的 地 下 斗 争 和 军 事 斗 争 中 逐 步 学 会 了 如 何 治 理 国 家 。 在 “ 反 饥 饿 ， 反 独 裁 ， 反 屠 杀 ” 的 口 号 下 ， 对 游 击 战 争 感 到 恐 惧 的 市 民 也 渐 渐 开 始 支 持 人 民 革 命 军 。 最 终 ， 人 民 革 命 军 开 进 了 古 铁 雷 斯 城 ， 这 无 异 议 宣 告 了 墨 西 哥 政 府 军 的 全 线 崩 溃 ， 人 民 革 命 军 势 如 破 竹 ， 一 举 解 放 了 恰 帕 斯 州 周 边 地 区 ， 甚 至 是 尤 卡 坦 州 … … 在 电 视 新 闻 上 ， 被 大 批 大 批 俘 虏 的 墨 西 哥 军 人 震 撼 了 世 界 各 国 。 虽 然 墨 西 哥 合 众 国 政 府 切 断 了 多 个 地 区 的 电 视 网 络 ， 但 显 然 这 没 有 用 。 与 此 同 时 ， 我 们 观 察 到 美 国 援 助 的 武 器 和 教 官 开 始 出 现 在 墨 西 哥 北 方 。 这 一 些 原 本 摇 摆 不 定 的 拉 美 国 家 也 加 入 了 “ 秃 鹰 计 划 ” 。||在 恰 帕 斯 州 ，   墨 西 哥 人 民 革 命 联 盟 宣 布 了 一 个 令 人 震 惊 的 消 息 — — 墨 西 哥 南 方 民 主 共 和 国 的 成 立 。 在 执 政 的 联 盟 内 ， 主 要 是 以 下 几 大 组 织 最 有 影 响 力 ： 毛 主 义 的 无 产 阶 级 革 命 党 、 霍 查 派 的 墨 西 哥 共 产 党 （ 马 列 ） 、 亲 苏 联 的 墨 西 哥 统 一 社 会 党 （ 该 党 已 经 抛 弃 了 不 切 实 际 的 欧 洲 共 产 主 义 纲 领 ， 回 到 了 苏 联 的 “ 正 统 路 线 ” ） 和 托 洛 茨 基 主 义 的 革 命 工 人 党 。 在 多 个 国 际 观 察 团 组 织 的 协 调 监 督 下 ， 墨 西 哥 人 民 革 命 军 被 改 组 为 了 墨 西 哥 南 方 解 放 军 。 这 消 息 极 大 的 震 动 了 整 个 世 界 ， 墨 西 哥 合 众 国 ， 加 拿 大 ， 美 国 已 经 开 始 了 签 署 防 御 条 约 的 准 备 ， 他 们 对 于 美 国 邻 居 的 革 命 感 到 空 前 愤 怒 和 恐 惧 ， 我 们 和 美 国 以 及 加 拿 大 的 关 系 完 全 降 低 到 了 冰 点 … …||与 此 同 时 ， 在 墨 西 哥 城 ， 渥 太 华 和 华 盛 顿 ， 局 势 愈 发 晦 暗 未 明 了 … …";
				}
				else
				{
					text = " 很 快 ， 初 出 茅 庐 的 青 年 左 翼 激 进 组 织 终 究 抵 不 过 墨 西 哥 陆 军 和 联 邦 特 务 部 门 的 残 酷 镇 压 。 G A F E 和 美 国 特 种 部 队 参 与 了 对 革 命 组 织 骨 干 和 游 击 队 的 搜 捕 与 武 装 围 剿 。 据 悉 ， 在 恰 帕 斯 州 以 及 开 设 了 多 个 拘 留 营 地 。 大 量 农 民 和 青 年 学 生 以 及 工 人 被 “ 失 踪 ” 。 有 目 击 者 在 一 些 小 溪 见 到 了 被 草 草 掩 埋 的 尸 体 和 染 成 的 血 红 色 的 小 溪 … … 世 界 社 会 主 义 运 动 的 潮 流 还 是 吹 不 到 这 个 雄 鹰 国 家 。";
					GlobalScript.inst.gameState.influencePRC -= 40;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.empires[0].relations -= 100;
					GlobalScript.inst.gameState.allcountries[140].Torg = false;
					GlobalScript.inst.gameState.allcountries[140].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[140].SubGosstroy = 7;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 46)
			{
				GlobalScript.inst.gameState.allcountries[140].parts[1] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 100;
					GlobalScript.inst.gameState.empires[0].relations -= 500;
					GlobalScript.inst.gameState.influencePRC += 100;
					GlobalScript.inst.gameState.allcountries[145].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[140].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[145].proprc = true;
					Politic[] array4 = GlobalScript.inst.gameState.politics;
					foreach (Politic politic7 in array4)
					{
						if (politic7.traits[0] < 1 || politic7.traits[0] == 20)
						{
							politic7.loyality += 100;
						}
					}
					GlobalScript.inst.gameState.allcountries[140].Gosstroy = GlobalScript.inst.gameState.allcountries[145].Gosstroy;
					GlobalScript.inst.gameState.allcountries[140].SubGosstroy = GlobalScript.inst.gameState.allcountries[145].SubGosstroy;
					GlobalScript.inst.gameState.allcountries[140].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[140].proprc = true;
					GlobalScript.inst.gameState.allcountries[140].Torg = true;
					GlobalScript.inst.gameState.allcountries[140].JoinAllOurAlliances(yes: true);
					text = " 随 着 7 9 式 坦 克 成 功 突 破 了 墨 西 哥 国 家 宫 ， 革 命 制 度 党 政 权 正 式 宣 告 终 结 。 很 快 ， 米 格 尔 · 德 拉 马 德 里 等 一 系 列 战 犯 被 捕 ， 他 们 全 部 被 判 处 绞 刑 。 随 着 墨 西 哥 城 的 陷 落 ， 南 方 解 放 军 势 如 破 竹 。 并 最 终 解 放 了 墨 西 哥 北 部 的 各 州 ， 墨 西 哥 宣 告 统 一 并 被 命 名 为 社 会 主 义 共 和 国 。 对 旧 社 会 的 全 面 改 造 和 大 规 模 的 清 洗 发 生 了 ， 至 于 接 下 来 如 何 走 ， 革 命 左 派 内 部 仍 在 争 论。";
					if (GlobalScript.inst.gameState.allcountries[145].SubGosstroy == 0)
					{
						text += " ||反 修 正 主 义 的 墨 西 哥 共 产 党 成 功 得 到 了 城 市 工 人 阶 级 的 支 持 ， 成 功 夺 取 最 高 权 力 。 霍 查 主 义 迅 速 成 为 了 整 个 社 会 的 指 导 思 想 。 世 界 各 地 的 霍 查 主 义 者 狂 喜 的 看 着 墨 西 哥 ， 很 快 ， 阿 尔 巴 尼 亚 和 墨 西 哥 建 立 了 良 好 的 外 交 关 系 ， 于 是 ， 一 大 批 阿 尔 巴 尼 亚 专 家 出 现 在 了 墨 西 哥 城 ， 轰 轰 烈 烈 的 思 想 文 化 革 命 就 要 展 开 了 … …";
					}
					else if (GlobalScript.inst.gameState.allcountries[145].SubGosstroy == 17)
					{
						text += " ||南 方 解 放 军 总 司 令 — 前 哲 学 教 授 马 科 斯 领 导 的 墨 西 哥 无 产 阶 级 革 命 党 在 我 们 的 支 持 下 ， 得 到 了 绝 大 多 数 原 住 民 和 工 人 ， 成 功 在 墨 西 哥 社 会 主 义 共 和 国 的 国 会 选 举 中 掌 权 ， 他 被 认 为 学 识 渊 博 ， 有 经 验 而 且 忠 于 墨 西 哥 无 产 阶 级 。 现 在 ， 这 位 总 司 令 和 来 自 前 人 民 革 命 军 的 毛 主 义 者 将 携 手 并 进 ， 按 照 中 国 的 模 式 建 设 墨 西 哥 。";
					}
					else if (GlobalScript.inst.gameState.allcountries[145].SubGosstroy == 16)
					{
						text += " ||在 抛 弃 了 欧 洲 共 产 主 义 纲 领 后 。 墨 西 哥 统 一 社 会 党 成 为 了 举 足 轻 重 的 政 治 力 量 。 在 我 们 的 支 持 下 ， 仿 造 东 德 模 式 建 立 了 一 党 主 导 体 制 ， 并 开 始 墨 西 哥 的 “ 斯 大 林 主 义 ” 化 。 激 进 的 重 工 业 发 展 政 策 和 强 制 集 体 化 政 策 在 墨 西 哥 开 展 了 起 来 ， 当 然 ， 这 些 政 策 让 左 翼 反 对 派 不 满 。 尽 管 如 此 ， 墨 西 哥 仍 然 宣 布 走 上 了 “ 发 达 社 会 主 义 的 道 路 ” 。";
					}
					else if (GlobalScript.inst.gameState.allcountries[145].SubGosstroy == 18)
					{
						text += " ||革 命 工 人 党 最 终 夺 取 权 力 ， 纳 维 尔 · 莫 雷 诺 ， 这 位 接 替 了 波 萨 达 斯 的 托 洛 茨 基 理 论 家 成 为 了 革 命 工 人 党 总 书 记 ，   伊 西 德 罗 · 莱 瓦 作 为 墨 西 哥 社 会 主 义 共 和 国 主 席 。 在 真 正 的 布 尔 什 维 列 宁 主 义 者 的 领 导 下 ， 托 洛 茨 基 曾 经 的 住 宅 被 改 造 成 纪 念 馆 。 墨 西 哥 开 始 逐 步 建 立 苏 维 埃 制 度 … …";
					}
					else
					{
						text += " ||鉴 于 来 自 北 方 的 美 国 威 胁 ， 墨 西 哥 左 翼 党 派 很 快 解 散 ， 并 与 墨 西 哥 统 一 社 会 党 融 合 ， 形 成 了 事 实 上 的 一 党 制 国 家 。 新 政 权 宣 布 继 承 了 墨 西 哥 社 会 主 义 人 民 党 的 愿 景 … … 温 和 的 工 业 化 和 集 体 化 得 到 开 展 。 模 仿 苏 联 历 史 上 的 新 经 济 政 策 ， 墨 西 哥 宣 布 逐 步 向 社 会 主 义 过 渡 。 并 保 留 了 一 部 分 市 场 经 济 。";
					}
				}
				else
				{
					text = " 可 惜 ， 就 像 7 0 年 前 的 南 方 农 民 军 一 样 ， 墨 西 哥 南 方 解 放 军 仍 然 无 法 突 破 莫 雷 洛 斯 州 中 由 美 国 志 愿 军 和 墨 西 哥 陆 军 所 设 下 的 防 线 。 北 方 强 烈 反 共 的 卡 西 克 民 兵 ， 卡 特 尔 团 体 南 方 解 放 军 筋 疲 力 尽 以 至 于 最 终 被 墨 西 哥 陆 军 和 美 国 志 愿 军 击 溃 。 大 规 模 的 屠 杀 发 生 在 了 墨 西 哥 南 方 。 墨 西 哥 军 队 镇 压 了 各 地 的 反 叛 团 体 … 当 然 ， 革 命 制 度 党 政 权 不 可 能 和 以 前 一 样 统 治 这 个 国 家 了 … …";
					GlobalScript.inst.gameState.influencePRC -= 40;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.empires[0].relations -= 100;
					GlobalScript.inst.gameState.allcountries[140].Torg = false;
					GlobalScript.inst.gameState.allcountries[145].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[140].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[140].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[140].SubGosstroy = 7;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 47)
			{
				GlobalScript.inst.gameState.allcountries[140].parts[1] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 100;
					GlobalScript.inst.gameState.empires[0].relations -= 500;
					GlobalScript.inst.gameState.influencePRC += 100;
					GlobalScript.inst.gameState.allcountries[140].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[140].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[140].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[140].proprc = true;
					GlobalScript.inst.gameState.allcountries[140].Torg = true;
					GlobalScript.inst.gameState.allcountries[140].JoinAllOurAlliances(yes: true);
					text = " 瓜 纳 华 托 州 的 教 权 主 义 者 所 领 导 的 基 督 军 同 时 要 抗 衡 来 自 墨 西 哥 城 的 革 命 制 度 党 政 府 ， 又 要 对 抗 因 为 墨 西 哥 内 战 所 出 现 的 反 对 派 武 装 。 于 是 ， 借 助 革 命 制 度 党 陷 入 政 治 混 乱 之 际 。 被 武 装 的 农 民 民 团 得 以 强 行 攻 入 各 大 州 首 府 ， 成 功 与 南 方 州 结 盟 ， 最 终 战 胜 了 革 命 制 度 党 政 权 ， 立 了 一 个 基 于 社 团 主 义 和 天 主 教 精 神 的 国 家 … …";
				}
				else
				{
					text = " 可 惜 ， 就 像 7 0 年 前 的 南 方 农 民 军 一 样 ， 墨 西 哥 南 方 解 放 军 仍 然 无 法 突 破 莫 雷 洛 斯 州 中 由 美 国 志 愿 军 和 墨 西 哥 陆 军 所 设 下 的 防 线 。 北 方 强 烈 反 共 的 卡 西 克 民 兵 ， 卡 特 尔 团 体 南 方 解 放 军 筋 疲 力 尽 以 至 于 最 终 被 墨 西 哥 陆 军 和 美 国 志 愿 军 击 溃 。 大 规 模 的 屠 杀 发 生 在 了 墨 西 哥 南 方 。 墨 西 哥 军 队 镇 压 了 各 地 的 反 叛 团 体 … 当 然 ， 革 命 制 度 党 政 权 不 可 能 和 以 前 一 样 统 治 这 个 国 家 了 … …";
					GlobalScript.inst.gameState.influencePRC -= 40;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.empires[0].relations -= 100;
					GlobalScript.inst.gameState.allcountries[140].Torg = false;
					GlobalScript.inst.gameState.allcountries[140].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[140].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[140].SubGosstroy = 7;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 48)
			{
				GlobalScript.inst.gameState.allcountries[53].parts[2] = false;
				if (resultOfEvents[499] == 2)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
					{
						GlobalScript.inst.gameState.empires[0].power -= 100;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.influencePRC += 100;
						GlobalScript.inst.gameState.allcountries[53].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[53].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[53].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[53].proprc = true;
						GlobalScript.inst.gameState.allcountries[53].Torg = true;
						GlobalScript.inst.gameState.allcountries[53].name = " 苏 丹 社 会 主 义 联 邦 共 和 国";
						GlobalScript.inst.gameState.allcountries[150].name = " 南 苏 丹 社 会 主 义 共 和 国";
						GlobalScript.inst.gameState.allcountries[150].SubGosstroy = 0;
						GlobalScript.inst.gameState.allcountries[150].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[150].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[150].proprc = true;
						GlobalScript.inst.gameState.allcountries[150].Torg = true;
						GlobalScript.inst.gameState.allcountries[53].parts[1] = false;
						GlobalScript.inst.gameState.allcountries[53].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[151].SubGosstroy = 2;
						GlobalScript.inst.gameState.allcountries[151].Gosstroy = 15;
						text = " 在 各 个 社 会 主 义 力 量 ， 古 巴 雇 佣 兵 和 埃 塞 俄 比 亚 空 军 的 帮 助 下 ， 苏 丹 人 民 解 放 军 功 破 了 朱 巴 并 巩 固 了 战 果 。 随 后 ， 苏 丹 人 民 解 放 军 的59 式 坦 克 攻 入 了 喀 土 穆 ， 尼 迈 里 在 设 法 逃 亡 时 被 拘 捕 。 苏 丹 社 会 主 义 联 盟 正 式 被 解 散 ， 原 先 的 统 战 组 织 被 改 组 为 政 协 组 织 ， 合 法 政 府 由 改 组 后 的 苏 丹 人 民 革 命 党 主 导 的 人 民 民 主 政 府 。 新 政 府 立 即 开 展 新 民 主 主 义 建 设 ， 并 同 我 们 的 阵 营 深 化 联 系 。 排 他 性 的 种 族 政 策 被 完 全 否 定 ， 各 民 族 语 言 、 民 族 地 位 完 全 平 等 。 过 去 的 旧 统 治 集 团 以 及 旧 军 队 都 被 清 洗 ， 关 于1971 年 的 政 变 也 被 正 面 评 价 为 一 次 革 命 尝 试 。 新 政 府 也 没 忘 记 把 尼 迈 里 送 至 革 命 法 庭 听 从 发 落 ： 他 因 为 种 族 灭 绝 ， 贪 污 和 叛 国 罪 被 判 处 绞 刑 。 伊 斯 兰 教 武 装 团 体 被 剿 灭 ， 关 于 宗 教 的 改 革 也 正 在 准 备 中 。 南 苏 丹 和 达 尔 富 尔 获 得 了 自 治 权 。";
						if (OAR && IsSocialism(yes: true, 30))
						{
							text += " 假 使 未 来 有 一 天 苏 丹 加 入 了 阿 拉 伯 革 命 社 会 主 义 共 和 国 联 盟 ， 南 苏 丹 就 有 权 利 举 行 一 场 退 出 联 邦 的 公 投 。";
						}
					}
					else
					{
						text = " 在 美 国 的 大 力 支 持 下 ， 苏 丹 设 法 镇 压 了 革 命 力 量 。 但 他 们 并 不 会 投 降 ， 他 们 逃 回 山 里 ， 继 续 攥 紧 枪 和 政 府 斗 争 。 新 生 的 尼 迈 里 政 府 以 血 与 铁 重 建 了 苏 丹 ， 但 是 这 样 的 新 秩 序 能 存 在 多 久 呢 ？|| 但 最 终 ， 达 尔 富 尔 和 南 苏 丹 在 战 斗 中 证 明 了 自 己 的 力 量 ， 两 地 也 就 此 得 到 了 独 立 。";
						GlobalScript.inst.gameState.influencePRC -= 40;
						GlobalScript.inst.gameState.empires[0].power += 20;
						GlobalScript.inst.gameState.empires[0].relations -= 80;
						GlobalScript.inst.gameState.allcountries[53].name = " 苏 丹";
						GlobalScript.inst.gameState.allcountries[53].Torg = false;
						GlobalScript.inst.gameState.allcountries[53].proprc = false;
						GlobalScript.inst.gameState.allcountries[53].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[53].SubGosstroy = 9;
						GlobalScript.inst.gameState.allcountries[53].Vyshi = false;
						GlobalScript.inst.gameState.allcountries[151].SubGosstroy = 15;
						GlobalScript.inst.gameState.allcountries[151].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[151].proprc = true;
						GlobalScript.inst.gameState.allcountries[151].Torg = true;
						GlobalScript.inst.gameState.allcountries[150].name = " 南 苏 丹 社 会 主 义 共 和 国";
						GlobalScript.inst.gameState.allcountries[150].SubGosstroy = 0;
						GlobalScript.inst.gameState.allcountries[150].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[150].Torg = true;
						GlobalScript.inst.gameState.allcountries[150].proprc = true;
						GlobalScript.inst.gameState.allcountries[53].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[53].parts[1] = true;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 100;
					GlobalScript.inst.gameState.empires[0].relations -= 150;
					GlobalScript.inst.gameState.influencePRC += 100;
					GlobalScript.inst.gameState.allcountries[53].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[53].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[53].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[53].prosov = true;
					if (influencePRC > empires[1].power)
					{
						GlobalScript.inst.gameState.allcountries[53].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[53].proprc = true;
						GlobalScript.inst.gameState.allcountries[53].Torg = true;
					}
					GlobalScript.inst.gameState.allcountries[53].name = " 苏 丹 联 邦 社 会 主 义 共 和 国";
					text = " 在 苏 联 所 动 员 的 古 巴 雇 佣 兵 和 埃 塞 俄 比 亚 空 军 的 帮 助 下 ， 苏 丹 人 民 解 放 军 功 破 了 朱 巴 并 巩 固 了 战 果 。 随 后 ， 苏 丹 人 民 解 放 军 的 T55 坦 克 攻 入 了 喀 土 穆 ， 尼 迈 里 在 设 法 逃 亡 时 被 拘 捕 。 苏 丹 社 会 主 义 联 盟 正 式 被 解 散 。 接 下 来 的 事 情 的 确 好 不 到 哪 里 去 ， 新 政 府 陷 入 了 和 过 去 的 所 有 苏 丹 政 府 一 样 的 问 题 ： 分 裂 。 达 尔 富 尔 ， 北 苏 丹 ， 基 督 徒 无 一 不 敌 视 新 生 的 社 会 主 义 政 权 。 苏 丹 人 民 解 放 军 所 衍 生 的 政 治 组 织 苏 丹 人 民 解 放 运 动 也 正 在 逐 渐 蜕 变 为 一 个 威 权 腐 败 而 暴 虐 无 道 的 官 僚 复 合 体 ， 依 托 走 私 ， 人 口 贩 卖 和 抛 售 国 企 。 过 去 和 蔼 可 亲 的 “ 指 挥 官 同 志 ” 们 变 得 越 发 残 忍 血 腥 而 又 腐 败 ， 他 们 越 来 越 像 法 鲁 克 国 王 和 尼 迈 里 了 。 这 真 的 是 纲 领 里 所 许 诺 的 社 会 主 义 新 苏 丹 吗 ？";
				}
				else
				{
					text = " 在 美 国 为 首 的 国 家 的 支 持 下 ， 尼 迈 里 以 铁 拳 镇 压 了 叛 乱 ， 喀 土 穆 的 街 头 静 悄 悄 ， 今 夜 无 事 发 生 … …";
					GlobalScript.inst.gameState.influencePRC -= 40;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.empires[0].relations -= 80;
					GlobalScript.inst.gameState.allcountries[53].name = " 苏 丹";
					GlobalScript.inst.gameState.allcountries[53].Torg = false;
					GlobalScript.inst.gameState.allcountries[53].proprc = false;
					GlobalScript.inst.gameState.allcountries[53].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[53].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[53].Vyshi = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 49)
			{
				GlobalScript.inst.gameState.allcountries[138].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.empires[0].relations -= 150;
					GlobalScript.inst.gameState.influencePRC -= 20;
					text = " 午 夜 ， 数 十 架 轰 炸 机 对 哈 瓦 那 等 大 城 市 进 行 了 轰 炸 ， 其 中 重 点 轰 炸 了 机 场 、 军 营 、 政 府 机 构 、 医 院 等 设 施 。 随 后 ， 几 千 名 经 受 过 军 事 训 练 的 流 亡 者 空 降 哈 瓦 那 、 圣 安 东 尼 奥 与 圣 地 亚 哥 等 地 的 机 场 ， 伪 装 成 古 巴 流 亡 者 的 美 国 海 军 陆 战 队 员 与 流 亡 者 也 在 在 流 亡 者 组 织 阿 尔 法 6 6 德 领 导 人 之 一 、 曾 参 与 过 第 一 次 猪 湾 入 侵 的 前 2 5 0 6 旅 成 员 弗 兰 克 · 卡 斯 特 罗 的 带 领 下 于 猪 湾 登 陆 。 古 巴 共 产 党 政 府 很 快 就 作 出 了 反 应 并 立 即 组 织 了 激 烈 的 抵 抗 。||在 漫 长 而 残 酷 的 战 争 过 后 ， 这 个 小 国 还 是 成 功 抵 御 住 了 来 自 咫 尺 之 遥 的 帝 国 主 义 的 侵 略 ， 将 源 源 不 断 的 美 军 驱 逐 出 了 古 巴 。 当 然 ， 入 侵 者 留 下 的 是 一 个 满 目 疮 痍 的 国 家 ， 数 个 大 城 市 被 夷 为 平 地 ， 1 0 万 多 个 村 庄 、 3 0 0 0 多 个 畜 牧 场 和 1 0 0 0 多 个 咖 啡 园 和 大 部 分 制 糖 厂 被 破 坏 ， 7 7 % 的 甘 蔗 地 被 付 之 一 炬 ， 该 国 唯 一 的 经 济 支 柱 — — 蔗 糖 产 量 降 低 到 了 战 争 爆 发 前 的 3 0 % ， 无 数 人 因 此 失 业 。 该 国 近 千 万 人 口 总 数 中 有 3 0 0 多 万 被 迫 流 离 失 所 ， 直 接 经 济 损 失 达 数 十 亿 美 元 。 经 济 的 雪 崩 导 致 战 后 重 建 工 作 极 其 艰 难 ， 国 民 经 济 的 多 个 关 键 部 分 瘫 痪 ， 该 国 只 得 被 迫 进 行 了 改 革 ， 开 放 了 部 分 对 私 营 经 济 和 外 国 投 资 的 限 制 。";
				}
				else
				{
					text = " 午 夜 ， 数 十 架 轰 炸 机 对 哈 瓦 那 等 大 城 市 进 行 了 轰 炸 ， 其 中 重 点 轰 炸 了 机 场 、 军 营 、 政 府 机 构 、 医 院 等 设 施 。 随 后 ， 几 千 名 经 受 过 军 事 训 练 的 流 亡 者 空 降 哈 瓦 那 、 圣 安 东 尼 奥 与 圣 地 亚 哥 等 地 的 机 场 ， 伪 装 成 古 巴 流 亡 者 的 美 国 海 军 陆 战 队 员 与 流 亡 者 也 在 在 流 亡 者 组 织 阿 尔 法 6 6 德 领 导 人 之 一 、 曾 参 与 过 第 一 次 猪 湾 入 侵 的 前 2 5 0 6 旅 成 员 弗 兰 克 · 卡 斯 特 罗 的 带 领 下 于 猪 湾 登 陆 。 古 巴 共 产 党 政 府 很 快 就 作 出 了 反 应 并 立 即 组 织 了 激 烈 的 抵 抗 。||在 漫 长 而 残 酷 的 战 争 过 后 ， 入 侵 者 还 是 成 功 将 这 个 岛 国 化 为 焦 土 。 随 后 ， 各 个 流 亡 者 政 治 组 织 间 （ 这 自 然 不 包 括 被 查 禁 的 “ 非 法 组 织 ” 古 巴 共 产 党 ） 举 行 了 选 举 ， 弗 兰 克 · 卡 斯 特 罗 领 导 的 古 巴 民 族 解 放 阵 线 在 美 国 操 纵 下 轻 松 取 得 了 大 选 的 胜 利 ， 走 马 上 任 为 新 总 统 。 新 政 府 与 美 国 重 新 修 订 了 《 普 拉 特 修 正 案 》 ， 在 再 次 给 予 美 国 在 古 巴 的 贸 易 特 权 的 同 时 ， 还 将 永 久 租 借 地 范 围 扩 大 到 了 整 个 关 塔 那 摩 市 ， 松 树 岛 也 再 次 归 美 国 所 有 。 而 尽 管 菲 德 尔 · 卡 斯 特 罗 于 战 争 中 身 亡 ， 但 古 巴 共 产 党 的 残 余 还 是 在 劳 尔 · 卡 斯 特 罗 的 带 领 下 与 新 政 权 打 起 了 游 击 战 。 世 界 各 国 强 烈 谴 责 了 美 国 对 主 权 国 家 的 入 侵 ， 不 过 谁 都 知 道 这 对 事 态 的 发 展 无 济 于 事 … … ";
					GlobalScript.inst.gameState.influencePRC += 20;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.empires[0].relations += 150;
					GlobalScript.inst.gameState.allcountries[138].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[138].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[138].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[138].EstablishGovernment(Government.ProAmerican);
					GlobalScript.inst.gameState.allcountries[138].Torg = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 50)
			{
				GlobalScript.inst.gameState.allcountries[119].parts[0] = false;
				if (GlobalScript.inst.gameState.resultOfEvents[594] == 1 || GlobalScript.inst.gameState.resultOfEvents[596] == 1)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
					{
						GlobalScript.inst.gameState.empires[0].power -= 20;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.influencePRC -= 20;
						allcountries[42].parts[1] = true;
						if (!allcountries[42].prosov && !allcountries[42].proprc)
						{
							text = " 出 乎 我 们 的 预 料 ， 欧 加 登 战 争 失 败 后 深 受 内 部 混 乱 影 响 的 索 马 里 居 然 击 溃 了 肯 尼 亚 军 队 ， 占 领 了 东 北 省 并 将 其 改 名 为 西 朱 巴 省 。 受 此 影 响 ， 肯 尼 亚 内 部 局 势 开 始 动 荡 起 来 ， 为 巩 固 政 权 继 续 加 强 专 制 ， 此 举 反 而 使 得 裙 带 型 腐 败 大 量 滋 生 ， 加 剧 了 内 部 的 不 稳 定 … …";
						}
						else if (allcountries[42].prosov)
						{
							text = "  在 苏 联 顾 问 和 古 巴 雇 佣 兵 的 协 助 下 ， 索 马 里 击 溃 了 占 据 东 北 省 的 肯 尼 亚 军 队 ， 将 东 北 省 占 领 并 更 名 为 西 朱 巴 省 。 受 此 影 响 ， 肯 尼 亚 内 部 局 势 开 始 动 荡 起 来 ， 为 巩 固 政 权 继 续 加 强 专 制 ， 此 举 反 而 使 得 裙 带 型 腐 败 大 量 滋 生 ， 加 剧 了 内 部 的 不 稳 定 … …";
						}
					}
					else
					{
						GlobalScript.inst.gameState.empires[0].power += 20;
						GlobalScript.inst.gameState.empires[0].relations += 150;
						GlobalScript.inst.gameState.empires[1].power -= 20;
						GlobalScript.inst.gameState.empires[1].relations -= 150;
						GlobalScript.inst.gameState.influencePRC += 10;
						if (!allcountries[42].prosov && !allcountries[42].proprc)
						{
							text = " 在 我 们 的 支 持 下 ， 肯 尼 亚 军 队 成 功 击 溃 了 来 侵 的 索 马 里 军 队 ，本 就 内 乱 的 索 马 里 因 战 败 直 接 导 致 中 央 政 府 威 信 扫 地 ， 索 马 里 陷 入 了 混 乱 之 中 。经 此 一 役 ， 肯 尼 亚 总 统 莫 伊 的 权 威 大 增 ， 因 战 乱 导 致 东 北 省 部 分 出 现 的 荒 地 逐 渐 被 基 库 尤 移 民 所 占 领 。 ";
						}
						else if (allcountries[42].prosov)
						{
							text = " 在 我 们 的 支 持 下 ， 肯 尼 亚 军 队 成 功 击 溃 了 来 侵 的 索 马 里 军 队 ， 苏 联 的 东 非 势 力 被 迫 在 肯 尼 亚 停 住 了 扩 张 的 步 伐 ， 索 马 里 的 战 败 也 导 致 内 部 部 族 开 始 不 满 巴 雷 统 治 ， 索 马 里 逐 渐 变 得 动 乱 起 来 ， 但 有 苏 联 人 在 ， 巴 雷 一 时 间 不 会 立 刻 下 台 。 经 此 一 役 ， 肯 尼 亚 总 统 莫 伊 的 权 威 大 增 ， 因 战 乱 导 致 东 北 省 部 分 出 现 的 荒 地 逐 渐 被 基 库 尤 移 民 所 占 领 。 ";
						}
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.empires[0].relations -= 150;
					GlobalScript.inst.gameState.empires[1].power += 20;
					GlobalScript.inst.gameState.empires[1].relations += 150;
					GlobalScript.inst.gameState.influencePRC += 20;
					if (!allcountries[42].parts[0])
					{
						allcountries[42].parts[1] = true;
					}
					else
					{
						allcountries[42].parts[0] = false;
						allcountries[42].parts[2] = true;
					}
					text = " 在 我 们 的 帮 助 下 索 马 里 终 于 取 得 了 胜 利 ， 原 东 北 省 被 纳 入 索 马 里 版 图 并 更 名 为 西 朱 巴 省 ， " + ((!allcountries[42].parts[0]) ? " 距 离 大 索 马 里 的 梦 想 又 近 了 一 步 。 " : "实 现 了 大 索 马 里 的 梦 想 。 ") + " 而 肯 尼 亚 在 经 历 战 败 后 内 部 动 乱 ， 为 巩 固 政 权 继 续 加 强 专 制 ， 此 举 反 而 使 得 裙 带 型 腐 败 大 量 滋 生 ， 加 剧 了 内 部 的 不 稳 定 . . . ";
				}
				else
				{
					GlobalScript.inst.gameState.empires[1].power -= 20;
					GlobalScript.inst.gameState.empires[1].relations -= 150;
					GlobalScript.inst.gameState.influencePRC -= 10;
					text = " 出 乎 我 们 的 预 期 ， 肯 尼 亚 在 被 索 马 里 突 然 袭 击 之 后 稳 住 了 防 线 ， 肯 索 双 方 在 此 地 陷 入 了 如 同 堑 壕 战 一 般 的 僵 持 状 态 ， 随 着 时 间 的 推 移 ， 索 马 里 的 军 心 逐 渐 不 稳 定 ， 而 肯 尼 亚 的 民 族 主 义 之 势 也 逐 渐 退 却 。 双 方 最 后 在 日 内 瓦 签 订 停 火 协 议 ， 双 方 恢 复 战 前 边 界 。 由 于 战 火 的 影 响 ， 东 北 省 的 索 马 里 人 大 量 北 撤 空 出 的 区 域 则 被 基 库 尤 人 占 据 。 一 切 似 乎 都 回 到 了 起 点 。 ";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 51)
			{
				GlobalScript.inst.gameState.allcountries[119].parts[1] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					if (influencePRC > empires[1].power)
					{
						GlobalScript.inst.gameState.allcountries[119].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[119].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[119].name = "肯 尼 亚 联 邦 共 和 国";
						GlobalScript.inst.gameState.allcountries[119].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[119].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[119].Torg = true;
						GlobalScript.inst.gameState.empires[0].power -= 20;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.influencePRC += 20;
						text = " 在 我 们 和 坦 桑 尼 亚 的 帮 助 下 ， 人 民 救 赎 委 员 会 成 功 击 败 了 肯 尼 亚 军 队 ， 成 立 了 肯 尼 亚 联 邦 共 和 国 ， 将 总 统 制 改 制 为 议 会 制 ， 奥 丘 卡 担 任 肯 尼 亚 总 统 ， 奥 廷 加 则 成 为 联 邦 政 府 总 理 安 尼 奥 那 和 基 尼 亚 蒂 成 为 副 总 理 ， 人 民 救 赎 委 员 会 和 肯 尼 亚 非 洲 社 会 主 义 联 盟 ， 肯 尼 亚 工 人 党 合 并 成 立 肯 尼 亚 人 民 革 命 党 ， 前 肯 尼 亚 土 地 与 自 由 军 （ 茅 茅 运 动 ） 中 央 委 员 会 成 员 比 尔 达 德 · 卡 吉 亚 ， 马 克 思 主 义 历 史 学 家 迈 纳 · 瓦 · 基 尼 亚 蒂 加 入 政 府 ， 平 反 茅 茅 运 动 ， 并 将 其 奉 为 肯 尼 亚 独 立 象 征 ， 德 丹 · 基 马 蒂 被 尊 为 国 父 ， 并 宣 布 清 算 自 独 立 以 来 基 库 尤 政 客 集 团 的 罪 行 ， 将 外 资 企 业 进 行 全 面 国 有 化 ， 实 行 联 邦 制 度 ， 平 反 被 迫 害 的 各 民 族 ， 前 政 府 高 层 和 军 队 高 级 指 挥 要 么 被 击 毙 要 么 被 迫 流 亡 海 外 。 肯 尼 亚 联 邦 共 和 国 与 中 国 开 始 交 好 ， 并 与 坦 桑 尼 亚 恢 复 外 交 关 系 ， 两 国 关 于 恢 复 东 非 共 同 服 务 组 织 和 组 建 东 非 联 邦 的 谈 判 正 在 紧 密 进 行 。";
					}
					else
					{
						GlobalScript.inst.gameState.allcountries[119].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[119].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[119].name = "肯 尼 亚 联 邦 共 和 国";
						GlobalScript.inst.gameState.allcountries[119].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[119].EstablishGovernment(Government.ProNeuthral);
						GlobalScript.inst.gameState.allcountries[119].Torg = true;
						GlobalScript.inst.gameState.allcountries[119].isSEV = true;
						GlobalScript.inst.gameState.empires[0].power -= 20;
						GlobalScript.inst.gameState.empires[0].relations -= 150;
						GlobalScript.inst.gameState.influencePRC += 20;
						text = " 在 我 们 ， 苏 联 和 坦 桑 尼 亚 的 帮 助 下 ， 人 民 救 赎 委 员 会 成 功 击 败 了 肯 尼 亚 军 队 ， 成 立 了 肯 尼 亚 联 邦 共 和 国 ， 将 总 统 制 改 制 为 议 会 制 ， 奥 丘 卡 担 任 肯 尼 亚 总 统 ， 奥 廷 加 则 成 为 联 邦 政 府 总 理 ， 安 尼 奥 那 成 为 副 总 理 ， 人 民 救 赎 委 员 会 和 肯 尼 亚 非 洲 社 会 主 义 联 盟 合 并 成 立 肯 尼 亚 统 一 社 会 党 ， 前 肯 尼 亚 土 地 与 自 由 军 （ 茅 茅 运 动 ） 中 央 委 员 会 成 员 比 尔 达 德 · 卡 吉 亚 ， 马 克 思 主 义 历 史 学 家 和 前 肯 尼 亚 工 人 党 领 袖 迈 纳 · 瓦 · 基 尼 亚 蒂 加 入 政 府 ， 平 反 茅 茅 运 动 ， 并 将 其 奉 为 肯 尼 亚 独 立 象 征 ， 德 丹 · 基 马 蒂 被 尊 为 国 父 ， 并 宣 布 清 算 自 独 立 以 来 基 库 尤 政 客 集 团 的 罪 行 ， 将 外 资 企 业 进 行 全 面 国 有 化 ， 实 行 联 邦 制 度 ， 平 反 被 迫 害 的 各 民 族 ， 前 政 府 高 层 和 军 队 高 级 指 挥 要 么 被 击 毙 要 么 被 迫 流 亡 海 外 。 肯 尼 亚 联 邦 共 和 国 与 社 会 主 义 阵 营 尤 其 是 苏 联 开 始 交 好 ， 并 决 定 加 入 经 互 会 ， 并 与 坦 桑 尼 亚 恢 复 外 交 关 系 ， 两 国 关 于 恢 复 东 非 共 同 服 务 组 织 和 组 建 东 非 联 邦 的 谈 判 正 在 紧 密 进 行 。";
					}
				}
				else
				{
					text = " 在 英 美 盟 友 和 西 方 雇 佣 兵 的 协 助 下 ， 肯 尼 亚 军 队 终 于 平 定 了 坦 桑 尼 亚 和 东 方 阵 营 所 支 持 的 人 民 救 赎 委 员 会 。 此 次 平 叛 行 动 的 总 指 挥 穆 罕 默 德 少 将 被 军 队 推 举 为 肯 尼 亚 新 总 统 ， 因 此 次 叛 乱 肯 尼 亚 空 军 为 叛 乱 主 力 而 解 散 了 肯 尼 亚 空 军 ， 并 颁 布 戒 严 令 ， 宣 布 清 理 危 害 肯 尼 亚 安 全 的 左 翼 蛆 虫 和 苏 联 走 狗 ， 并 对 反 对 派 和 卢 奥 人 等 叛 乱 主 力 予 以 打 击 。 奥 丘 卡 在 战 败 后 被 俘 虏 并 当 场 枪 决 ， 奥 廷 加 和 安 尼 奥 那 等 左 派 被 迫 流 亡 坦 桑 尼 亚 ， 人 民 救 赎 委 员 会 的 剩 余 成 员 要 么 跨 过 边 境 去 坦 桑 尼 亚 避 难 ， 要 么 在 国 内 继 续 打 游 击 ， 反 对 派 市 民 ， 工 人 ， 卢 奥 人 被 大 量 屠 杀 。<color=red>内 罗 毕 秩 序 井 然 </color>。 ";
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.allcountries[119].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[119].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[119].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[119].EstablishGovernment(Government.ProAmerican);
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 52)
			{
				GlobalScript.inst.gameState.allcountries[113].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					GlobalScript.inst.gameState.allcountries[113].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[113].SubGosstroy = 2;
					GlobalScript.inst.gameState.allcountries[113].name = "冈 比 亚 人 民 革 命 共 和 国";
					GlobalScript.inst.gameState.allcountries[113].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[113].EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[113].Torg = true;
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.empires[0].relations -= 150;
					GlobalScript.inst.gameState.influencePRC += 20;
					text = " 得 益 于 几 内 亚 和 几 内 亚 比 绍 联 军 的 支 持 ， 冈 比 亚 革 命 社 会 主 义 党 得 以 在 塞 内 加 尔 侵 略 下 守 住 了 革 命 果 实 ， 而 塞 内 加 尔 则 损 失 惨 重 ， 不 得 不 坐 在 谈 判 桌 前 签 署 了 和 约 ， 从 冈 比 亚 撤 军 ， 并 承 认 库 科 伊 · 桑 巴 · 萨 尼 扬 政 府 的 合 法 性 。 在 冈 比 亚 革 命 社 会 主 义 党 新 一 版 党 章 中 ， 马 克 思 、 列 宁 、 斯 大 林 、 夸 梅 · 恩 克 鲁 玛 、 塞 古 · 杜 尔 、 弗 朗 茨 · 法 农 、 阿 米 尔 卡 · 卡 布 拉 尔 与 毛 泽 东 均 被 列 为 该 党 “ 马 列 主 义 与 非 洲 社 会 主 义 ” 思 想 的 来 源 。 随 后 ， 效 仿 我 国 与 各 个 非 洲 的 社 会 主 义 国 家 的 经 验 ， 冈 比 亚 人 民 革 命 共 和 国 开 始 了 社 会 主 义 改 造 。 ";
				}
				else
				{
					text = " 即 使 在 面 对 几 内 亚 - 几 内 亚 比 绍 联 军 的 干 涉 下 ， 塞 内 加 尔 依 然 摧 毁 了 库 科 伊 · 桑 巴 · 萨 尼 扬 政 府 ， 并 将 联 军 主 力 拦 在 了 边 境 线 周 边 。 在 意 识 到 已 经 无 法 挽 救 冈 比 亚 革 命 社 会 主 义 党 后 ， 两 国 只 得 撤 军 。 达 乌 达 · 贾 瓦 拉 在 回 国 后 就 立 即 同 塞 内 加 尔 签 订 了 合 作 条 约 ， 统 一 两 国 的 军 队 、 政 府 与 货 币 ， 成 立 塞 内 冈 比 亚 联 邦 ， 该 联 邦 自 然 是 塞 内 加 尔 主 导 的 。 出 于 对 我 国 在 战 争 中 的 立 场 的 怨 恨 ， 塞 内 加 尔 同 我 国 断 绝 了 外 国 关 系 ， 并 转 而 同 台 湾 当 局 建 交 。 ";
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.allcountries[112].parts[1] = true;
					GlobalScript.inst.gameState.allcountries[112].name = "塞 内 冈 比 亚";
					GlobalScript.inst.gameState.allcountries[113].LeaveAlliances();
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 53)
			{
				GlobalScript.inst.gameState.allcountries[122].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power += 10;
					text = " 事 实 又 一 次 证 明 了 全 乌 干 达 的 终 身 总 统 与 大 元 帅 、 地 上 所 有 走 兽 与 海 中 所 有 游 鱼 的 王 、 大 英 帝 国 在 非 洲 尤 其 是 乌 干 达 的 征 服 者 、 尊 敬 的 哈 吉 伊 迪 · 阿 明 · 达 达 博 士 阁 下 的 真 知 灼 见 。 凭 借 苏 联 与 我 们 的 军 事 援 助 ， 乌 干 达 军 队 在 战 争 初 期 便 乘 坦 桑 尼 亚 准 备 不 足 之 机 迅 速 攻 陷 了 卡 盖 拉 河 套 地 区 ， 而 尽 管 坦 军 进 行 了 全 面 动 员 ， 组 织 起 反 攻 ， 但 最 终 还 是 在 乌 军 的 残 暴 手 段 与 利 比 亚 与 巴 勒 斯 坦 解 放 组 织 的 援 军 的 猛 烈 攻 势 下 止 步 不 前 。 在 日 复 一 日 的 巨 大 战 争 损 失 、 国 内 右 翼 的 “ 尼 雷 尔 总 统 给 我 们 带 来 了 战 争 ” 的 叫 嚣 之 声 和 及 其 缓 慢 的 战 线 进 度 面 前 ， 坦 桑 尼 亚 被 迫 接 受 国 际 调 停 ， 坦 桑 尼 亚 和 乌 干 达 双 方 在 的 黎 波 里 签 订 和 平 协 议 ， 以 终 战 时 的 停 火 线 为 暂 定 国 界 ， 乌 干 达 获 得 了 卡 盖 拉 地 区 。 经 此 一 役 ， 阿 明 的 声 望 大 涨 ， 被 宣 传 成 为 了 “ 战 胜 坦 桑 尼 亚 帝 国 主 义 的 英 雄 ” “ 西 尼 罗 河 不 世 出 的 伟 人 ” “ 乌 干 达 祖 国 的 伟 大 救 星 ” 与 “ 黑 非 洲 人 民 的 领 袖 ” 。 然 而 ， 对 坦 桑 尼 亚 的 军 事 胜 利 并 不 能 扭 转 乌 干 达 早 已 全 面 崩 盘 的 经 济 形 势 与 急 转 直 下 的 社 会 现 状 ， 该 国 经 济 生 活 早 已 彻 底 瘫 痪 ， 绝 大 多 数 工 厂 停 工 ， 农 业 生 产 也 基 本 停 顿 下 来 ， 政 府 没 有 任 何 外 汇 储 备 来 支 付 进 口 ， 政 治 完 全 失 序 ， 许 多 政 府 军 的 士 兵 借 战 争 之 机 在 卡 盖 拉 甚 至 乌 干 达 本 土 烧 杀 抢 掠 ， 一 些 不 法 之 徒 也 由 于 战 争 的 混 乱 而 获 取 到 了 武 器 ， 暴 力 活 动 极 其 猖 獗 ， 而 乌 干 达 各 反 对 派 武 装 与 救 国 阵 线 的 游 击 队 也 乘 战 争 之 机 渗 透 了 乌 干 达 的 许 多 地 区 。 阿 明 或 许 终 有 一 日 会 被 推 翻 ， 但 还 不 是 现 在 … …";
					GlobalScript.inst.gameState.event_done[659] = true;
					GlobalScript.inst.gameState.event_done[660] = true;
					GlobalScript.inst.gameState.allcountries[118].Torg = true;
					GlobalScript.inst.gameState.allcountries[118].usainfl = 100;
				}
				else
				{
					text = " 阿 明 的 入 侵 行 动 终 究 还 是 搬 起 石 头 砸 了 自 己 的 脚 ， 妄 图 “ 教 训 一 下 ” 他 人 的 人 最 终 自 食 其 果 ， 落 得 了 个 被 他 人 教 训 的 下 场 。 尽 管 乌 干 达 在 战 争 初 期 乘 坦 桑 尼 亚 准 备 不 足 之 机 迅 速 攻 陷 了 卡 盖 拉 河 套 地 区 ， 但 很 快 坦 桑 尼 亚 就 进 行 了 全 面 动 员 ， 组 织 起 反 攻 将 乌 军 打 的 溃 不 成 军 。 再 加 上 乌 干 达 军 队 组 织 极 度 混 乱 、 军 纪 不 良 与 普 遍 缺 乏 战 斗 经 验 使 其 并 没 有 构 筑 起 有 效 的 防 御 体 系 。 到1979 年1 月 初 ， 所 有 乌 军 士 兵 都 被 驱 逐 出 了 该 国 ， 战 场 随 之 从 坦 桑 尼 亚 转 移 到 了 乌 干 达 境 内 。1 月21 日 ， 坦 军 从 卡 盖 拉 地 区 发 动 了 一 次 试 探 性 进 攻 ， 占 领 了 乌 干 达 边 境 的 穆 图 库 拉 。 大 约 三 周 后 ， 正 式 攻 势 拉 开 了 序 幕 ， 坦 军 势 如 破 竹 地 攻 破 了 乌 干 达 大 片 领 土 ， 而 乌 军 一 直 没 有 组 织 起 像 样 的 反 击 ， 只 有2 月 开 始 向 乌 干 达 派 出 的 利 比 亚 援 军 和 马 哈 茂 德 · 达 斯 指 挥 的 巴 勒 斯 坦 解 放 组 织 援 军 做 到 了 有 效 的 防 御 。||3 月24 日 ， 各 乌 干 达 流 亡 者 团 体 在 莫 希 召 开 了 一 次 “ 具 有 广 泛 代 表 性 基 础 上 的 联 合 ” 的 会 议 。 由 于 组 织 混 乱 且 时 间 过 于 匆 忙 ， 导 致 会 议 没 有 进 行 资 格 审 定 ， 与 会 团 体 良 莠 不 齐 、 冗 员 充 斥 ， 投 机 分 子 钻 营 取 巧 ， 许 多 所 谓 政 治 派 别 只 是 临 时 拼 凑 出 来 的 ， 有 的 “ 解 放 组 织 ” 甚 至 只 有 一 个 人 ， 与 会 代 表 名 额 分 配 也 极 其 不 合 理 ， 在 解 放 乌 干 达 过 程 中 发 挥 重 要 作 用 的 救 国 阵 线 却 只 取 得 两 个 代 表 名 额 。 乌 干 达 流 亡 者 间 巨 大 的 争 执 分 歧 导 致 会 议 现 场 极 为 混 乱 ， 在 坦 桑 尼 亚 的 软 硬 兼 施 下 ， 各 流 亡 者 团 体 终 于 匆 忙 拼 凑 出 了 一 个 政 治 联 合 体 — — 乌 干 达 民 族 解 放 阵 线 ， 选 举 德 高 望 重 、 学 术 背 景 浓 厚 而 政 治 资 历 较 浅 的 尤 素 夫 · 卢 莱 为 民 族 解 放 阵 线 执 行 委 员 会 主 席 ， 奥 博 特 支 持 者 保 罗 · 穆 万 加 为 军 事 委 员 会 主 席 ， 穆 塞 韦 尼 为 军 委 副 主 席 。||1979 年4 月11 日 ， 经 过 激 烈 战 斗 ， 坦 军 与 反 阿 明 武 装 终 于 攻 占 了 乌 干 达 首 都 坎 帕 拉 ， 推 翻 了 持 续 八 年 的 阿 明 政 权 ， 阿 明 在 第 二 大 城 市 金 贾 试 图 重 新 集 结 部 队 失 败 后 仓 皇 逃 往 肯 尼 亚 边 境 ， 乘 飞 机 前 往 利 比 亚 。 两 天 后 ， 尤 素 夫 · 卢 莱 总 统 宣 誓 就 职 ， 民 族 解 放 阵 线 临 时 政 府 成 立 。 参 与 解 放 乌 干 达 的 各 武 装 力 量 被 整 合 改 组 为 乌 干 达 民 族 解 放 军 （UNLA ） ， 新UNLA 以 追 随 奥 博 特 的 军 官 为 主 体 ， 而 救 国 阵 线 部 队 则 大 半 被 遣 散 ， 剩 余 部 分 编 入 U N L A 后 被 打 散 安 置 在 偏 远 地 区 。 战 争 给 坦 桑 尼 亚 造 成 了 数 亿 美 元 的 经 济 损 失 ， 而 乌 干 达 的 损 失 同 样 惨 重 ， 阿 明 的 统 治 与 战 争 的 影 响 使 该 国 经 济 生 活 彻 底 瘫 痪 ， 绝 大 多 数 工 厂 停 工 ， 农 业 生 产 也 基 本 停 顿 下 来 ， 政 府 没 有 任 何 外 汇 储 备 来 支 付 进 口 ， 政 治 完 全 失 序 ， 许 多 溃 兵 散 而 成 匪 ， 一 些 不 法 之 徒 也 拿 到 了 前 政 府 军 溃 败 丢 弃 的 枪 械 ， 暴 力 活 动 极 其 猖 獗 。 至 于 新 政 府 能 否 在 面 临 如 此 艰 难 的 状 况 与 领 导 集 团 内 部 的 严 重 矛 盾 、 部 族 纠 纷 与 政 治 冲 突 的 情 况 下 解 决 重 建 问 题 ， 答 案 目 前 尚 不 明 确 。";
					GlobalScript.inst.gameState.influencePRC += 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
					GlobalScript.inst.gameState.allcountries[118].SubGosstroy = 15;
					GlobalScript.inst.gameState.allcountries[118].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[118].prosov = false;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 54)
			{
				GlobalScript.inst.gameState.allcountries[131].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					GlobalScript.inst.gameState.influencePRC += 15;
					GlobalScript.inst.gameState.empires[0].power -= 15;
					GlobalScript.inst.gameState.empires[0].relations -= 100;
					if (allcountries[153].Gosstroy == 1)
					{
						text = " 最 终 ， 阿 扎 尼 亚 人 民 解 放 军 与 其 盟 友 赢 得 了 内 战 的 全 面 胜 利 。 开 普 敦 沦 陷 的 场 景 将 以 “ 第 二 西 贡 ” 之 名 载 入 史 册 ， 该 国 白 人 社 群 将 在 此 后 直 面 黑 人 以 “ 恢 复 历 史 正 义 ” 之 名 的 严 厉 报 复 — — 不 少 阿 非 利 卡 人 与 英 裔 族 群 逃 亡 出 境 或 被 强 制 遣 返 ， 其 队 伍 被 称 之 为 所 谓 “ 大 西 洋 之 船 ” ； 虽 说 如 此 ， 可 “ 每 一 个 定 居 者 ， 每 一 发 子 弹 ” 的 口 号 还 是 因 革 命 立 场 与 现 实 局 势 做 了 调 整 ： 支 持 革 命 运 动 的 白 人 被 视 为 “ 无 需 压 迫 他 人 ， 自 食 其 力 的 非 定 居 者 ” 而 得 到 宽 恕 。 阿 扎 尼 亚 革 命 政 府 在 成 立 次 日 便 立 刻 赢 得 主 要 社 会 主 义 国 家 和 大 多 数 第 三 世 界 国 家 的 承 认 ， 并 在 同 时 被 西 方 世 界 扣 上 “ 侵 犯 人 权 ” 与 “ 纵 容 种 族 歧 视 ” 的 帽 子 。 预 计 下 一 步 便 是 立 即 整 合 各 大 革 命 势 力 ， 为 非 洲 民 族 共 产 主 义 建 设 做 准 备 ， 可 考 虑 到 阿 扎 尼 亚 大 会 的 历 史 渊 源 ， 作 为 “ 革 命 同 路 人 ” 的 非 洲 国 民 大 会 党 大 抵 会 成 为 第 一 波 清 洗 的 牺 牲 品 。||与 此 同 时 ， 阿 扎 尼 亚 政 权 同 意 了 纳 米 比 亚 独 立 ， 并 协 助 西 南 非 洲 民 族 联 盟 与 西 南 非 洲 人 民 组 织 组 建 当 地 临 时 政 府 。 人 们 将 把 今 日 壮 举 同 “ 非 洲 独 立 年 ” 一 般 铭 记 ！";
						GlobalScript.inst.gameState.allcountries[131].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[131].SubGosstroy = 0;
						for (int n = 0; n < allcountries.Length; n++)
						{
							if (allcountries[n].puppetOf == 131)
							{
								allcountries[n].puppetOf = -1;
							}
						}
						GlobalScript.inst.gameState.allcountries[131].name = "阿 扎 尼 亚 人 民 共 和 国";
						GlobalScript.inst.gameState.allcountries[132].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[132].SubGosstroy = 0;
						GlobalScript.inst.gameState.allcountries[132].name = "莱 索 托 人 民 共 和 国";
						GlobalScript.inst.gameState.allcountries[131].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[132].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[131].Torg = true;
						GlobalScript.inst.gameState.allcountries[132].Torg = true;
						GlobalScript.inst.gameState.allcountries[131].EstablishGovernment(Government.ProChina);
						GlobalScript.inst.gameState.allcountries[132].EstablishGovernment(Government.ProChina);
						if (allcountries[153].cw)
						{
							GlobalScript.inst.gameState.allcountries[153].parts[0] = true;
							GlobalScript.inst.gameState.allcountries[153].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[153].SubGosstroy = 3;
							GlobalScript.inst.gameState.allcountries[153].Torg = true;
							GlobalScript.inst.gameState.allcountries[153].EstablishGovernment(Government.ProChina);
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[153].parts[0] = true;
							GlobalScript.inst.gameState.allcountries[153].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[153].SubGosstroy = 15;
							GlobalScript.inst.gameState.allcountries[153].Torg = true;
							GlobalScript.inst.gameState.allcountries[153].EstablishGovernment(Government.ProNeuthral);
						}
					}
					else
					{
						text = " 最 终 ， 阿 扎 尼 亚 人 民 解 放 军 与 其 盟 友 赢 得 了 内 战 的 全 面 胜 利 。 开 普 敦 沦 陷 的 场 景 将 以 “ 第 二 西 贡 ” 之 名 载 入 史 册 ， 该 国 白 人 社 群 将 在 此 后 直 面 黑 人 以 “ 恢 复 历 史 正 义 ” 之 名 的 严 厉 报 复 — — 不 少 阿 非 利 卡 人 与 英 裔 族 群 逃 亡 出 境 或 被 强 制 遣 返 ， 其 队 伍 被 称 之 为 所 谓 “ 大 西 洋 之 船 ” 。 上 述 行 为 促 使 苏 联 与 阿 扎 尼 亚 泛 非 主 义 大 会 内 掌 权 的 外 交 官 派 （ 主 张 黑 人 民 族 主 义 ） 领 导 人 约 翰 · 波 克 拉 呼 吁 群 众 保 持 克 制 与 秩 序 以 “ 保 护 革 命 果 实 ” 。 这 只 会 导 致 人 民 更 加 倾 心 要 求 彻 底 落 实 转 型 正 义 的 激 进 派 — — 在 内 战 中 痛 失 丈 夫 的 曼 德 拉 夫 人 温 妮 · 曼 德 拉 便 是 其 中 代 表 ， 她 已 围 绕 自 身 形 成 了 一 个 左 翼 民 粹 主 义 集 团 。 南 非 革 命 政 府 在 成 立 次 日 便 立 刻 赢 得 主 要 社 会 主 义 国 家 和 大 多 数 第 三 世 界 国 家 的 承 认 ， 并 在 同 时 被 西 方 世 界 扣 上 “ 侵 犯 人 权 ” 与 “ 纵 容 种 族 歧 视 ” 的 帽 子 。 预 计 下 一 步 便 是 立 即 整 合 各 大 革 命 势 力 ， 为 非 洲 民 族 的 社 会 主 义 建 设 做 准 备 。||与 此 同 时 ， 南 非 政 权 同 意 了 纳 米 比 亚 独 立 ， 并 协 助 西 南 非 洲 民 族 联 盟 与 西 南 非 洲 人 民 组 织 组 建 当 地 临 时 政 府 。 人 们 将 把 今 日 壮 举 同 “ 非 洲 独 立 年 ” 一 般 铭 记 ！";
						GlobalScript.inst.gameState.allcountries[131].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[131].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[131].name = "南 非";
						for (int num9 = 0; num9 < allcountries.Length; num9++)
						{
							if (allcountries[num9].puppetOf == 131)
							{
								allcountries[num9].puppetOf = -1;
							}
						}
						GlobalScript.inst.gameState.allcountries[131].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[132].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[132].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[132].SubGosstroy = 15;
						GlobalScript.inst.gameState.allcountries[132].name = "莱 索 托";
						GlobalScript.inst.gameState.allcountries[131].Torg = true;
						GlobalScript.inst.gameState.allcountries[132].Torg = true;
						GlobalScript.inst.gameState.allcountries[132].EstablishGovernment(Government.ProChina);
						if (allcountries[153].cw)
						{
							GlobalScript.inst.gameState.allcountries[153].parts[0] = true;
							GlobalScript.inst.gameState.allcountries[153].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[153].SubGosstroy = 3;
							GlobalScript.inst.gameState.allcountries[153].Torg = true;
							GlobalScript.inst.gameState.allcountries[153].EstablishGovernment(Government.ProChina);
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[153].parts[0] = true;
							GlobalScript.inst.gameState.allcountries[153].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[153].SubGosstroy = 15;
							GlobalScript.inst.gameState.allcountries[153].Torg = true;
							GlobalScript.inst.gameState.allcountries[153].EstablishGovernment(Government.ProNeuthral);
						}
					}
				}
				else
				{
					text = " 谁 能 想 到 ， 经 斩 首 行 动 打 击 的 种 族 隔 离 支 持 者 们 竟 能 迅 速 走 出 低 谷 并 发 起 反 攻 ： 面 对 开 普 敦 沦 陷 危 局 ， 以 乔 治 · 梅 林 为 核 心 的 南 非 武 装 力 量 少 壮 派 迅 速 同 复 出 的 国 安 局 局 长 亨 德 里 克 · 范 斐 伯 格 组 成 了 双 头 同 盟 ， 他 们 利 用 杰 普 · 马 来 斯 和 安 德 里 斯 · 佩 特 鲁 斯 · 特 鲁 尼 希 特 等 保 守 派 的 死 亡 建 立 了 清 一 色 的 激 进 派 联 盟 ： 其 中 便 包 括 持 纯 粹 种 族 隔 离 立 场 的 重 组 国 民 党 德 兰 士 瓦 部 候 选 人 尤 金 · 特 雷 布 兰 奇 及 其 “ 阿 非 利 卡 人 抵 抗 军 ” ， 后 者 在 内 战 期 间 近 乎 扩 展 至 十 万 人 ， 充 当 了 非 洲 版 “ 自 由 军 团 ” ， 并 彻 底 碾 碎 了 阿 扎 尼 亚 联 军 。 也 就 在 内 战 结 束 次 日 ， 乔 治 · 梅 林 决 定 实 施 旨 在 “ 治 病 救 人 ” 的 新 政 策 ： 改 南 非 共 和 国 为 “ 扎 根 白 血 ， 忠 于 基 督 ” 的 人 民 邦 体 制 ， 巴 尔 萨 泽 · 弗 斯 特 时 期 的 种 族 隔 离 法 律 纷 纷 回 归 ， 下 一 步 便 是 将 黑 人 加 速 迁 往 班 图 斯 坦 。 目 前 还 没 有 任 何 国 家 承 认 该 政 权 ， 西 方 各 国 则 宣 布 保 留 “ 南 非 共 和 国 ” 的 大 使 馆 并 “ 继 承 同 南 非 当 局 的 关 系 ” ， 从 而 绕 开 了 人 民 邦 承 认 问 题 。 然 而 ， 南 非 武 装 力 量 与 “ 阿 非 利 卡 人 抵 抗 军 ” 在 内 战 结 束 后 仍 在 持 续 膨 胀 ， 后 者 更 是 将 1 4 岁 及 以 上 的 青 少 年 整 编 进 入 军 中 。 内 战 时 期 的 化 学 武 器 生 产 线 也 在 无 视 联 合 国 警 告 的 情 况 下 持 续 扩 充 ， 似 乎 战 争 的 阴 云 仍 未 消 散 … …";
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power += 10;
					GlobalScript.inst.gameState.allcountries[131].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[131].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[131].name = "南 非 人 民 邦";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 55)
			{
				GlobalScript.inst.gameState.allcountries[131].parts[1] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " 最 终 ， 非 国 大 与 其 盟 友 赢 得 了 内 战 的 全 面 胜 利 。 开 普 敦 沦 陷 的 场 景 将 以 “ 第 二 西 贡 ” 之 名 载 入 史 册 ， 该 国 白 人 社 群 将 在 此 后 直 面 黑 人 以 “ 恢 复 历 史 正 义 ” 之 名 的 严 厉 报 复 — — 不 少 阿 非 利 卡 人 与 英 裔 族 群 逃 亡 出 境 或 被 强 制 遣 返 ， 其 队 伍 被 称 之 为 所 谓 “ 大 西 洋 之 船 ” 。 上 述 行 为 促 使 非 国 大 内 部 产 生 分 化 ： 主 流 派 要 求 成 立 多 种 族 的 “ 彩 虹 国 家 ” ， 强 硬 派 则 要 求 加 速 驱 逐 所 有 白 人 。 南 非 革 命 政 府 在 成 立 次 日 便 立 刻 赢 得 主 要 社 会 主 义 国 家 和 大 多 数 第 三 世 界 国 家 的 承 认 ， 并 在 同 时 被 西 方 世 界 扣 上 “ 侵 犯 人 权 ” 与 “ 纵 容 种 族 歧 视 ” 的 帽 子 。 预 计 下 一 步 便 是 立 即 整 合 各 大 革 命 势 力 ， 为 非 洲 社 会 主 义 建 设 做 准 备 。 分 析 者 估 计 ： 在 内 阁 中 占 据 半 壁 江 山 且 兼 有 总 理 一 职 的 南 非 共 产 党 将 长 期 主 导 该 国 政 局 。||与 此 同 时 ， 南 非 政 权 同 意 了 纳 米 比 亚 独 立 ， 并 协 助 西 南 非 洲 民 族 联 盟 与 西 南 非 洲 人 民 组 织 组 建 当 地 临 时 政 府 。 人 们 将 把 今 日 壮 举 同 “ 非 洲 独 立 年 ” 一 般 铭 记 ！||与 此 同 时 ， 西 南 非 洲 人 民 组 织 成 功 拿 下 了 温 德 赫 克 宣 布 独 立 。 对 于 非 洲 人 民 的 斗 争 事 业 而 言 ， 今 天 是 一 个 伟 大 里 程 碑 ！ ";
					GlobalScript.inst.gameState.allcountries[131].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[131].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[131].name = "南 非";
					GlobalScript.inst.gameState.allcountries[131].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[132].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[132].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[132].SubGosstroy = 15;
					GlobalScript.inst.gameState.allcountries[131].Torg = true;
					GlobalScript.inst.gameState.allcountries[132].Torg = true;
					GlobalScript.inst.gameState.allcountries[131].EstablishGovernment(Government.ProSoviet);
					GlobalScript.inst.gameState.allcountries[132].EstablishGovernment(Government.ProChina);
					GlobalScript.inst.gameState.allcountries[153].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[153].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[153].SubGosstroy = 3;
				}
				else
				{
					text = " 谁 能 想 到 ， 经 斩 首 行 动 打 击 的 种 族 隔 离 支 持 者 们 竟 能 迅 速 走 出 低 谷 并 发 起 反 攻 ： 面 对 开 普 敦 沦 陷 危 局 ， 以 乔 治 · 梅 林 为 核 心 的 南 非 武 装 力 量 少 壮 派 迅 速 同 复 出 的 国 安 局 局 长 亨 德 里 克 · 范 斐 伯 格 组 成 了 双 头 同 盟 ， 他 们 利 用 杰 普 · 马 来 斯 和 安 德 里 斯 · 佩 特 鲁 斯 · 特 鲁 尼 希 特 等 保 守 派 的 死 亡 建 立 了 清 一 色 的 激 进 派 联 盟 ： 其 中 便 包 括 持 纯 粹 种 族 隔 离 立 场 的 重 组 国 民 党 德 兰 士 瓦 部 候 选 人 尤 金 · 特 雷 布 兰 奇 及 其 “ 阿 非 利 卡 人 抵 抗 军 ” ， 后 者 在 内 战 期 间 近 乎 扩 展 至 十 万 人 ， 充 当 了 非 洲 版 “ 自 由 军 团 ” ， 并 彻 底 碾 碎 了 阿 扎 尼 亚 联 军 。 也 就 在 内 战 结 束 次 日 ， 乔 治 · 梅 林 决 定 实 施 旨 在 “ 治 病 救 人 ” 的 新 政 策 ： 改 南 非 共 和 国 为 “ 扎 根 白 血 ， 忠 于 基 督 ” 的 人 民 邦 体 制 ， 巴 尔 萨 泽 · 弗 斯 特 时 期 的 种 族 隔 离 法 律 纷 纷 回 归 ， 下 一 步 便 是 将 黑 人 加 速 迁 往 班 图 斯 坦 。 目 前 还 没 有 任 何 国 家 承 认 该 政 权 ， 西 方 各 国 则 宣 布 保 留 “ 南 非 共 和 国 ” 的 大 使 馆 并 “ 继 承 同 南 非 当 局 的 关 系 ” ， 从 而 绕 开 了 人 民 邦 承 认 问 题 。 然 而 ， 南 非 武 装 力 量 与 “ 阿 非 利 卡 人 抵 抗 军 ” 在 内 战 结 束 后 仍 在 持 续 膨 胀 ， 后 者 更 是 将 1 4 岁 及 以 上 的 青 少 年 整 编 进 入 军 中 。 内 战 时 期 的 化 学 武 器 生 产 线 也 在 无 视 联 合 国 警 告 的 情 况 下 持 续 扩 充 ， 似 乎 战 争 的 阴 云 仍 未 消 散 … …";
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power += 10;
					GlobalScript.inst.gameState.allcountries[131].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[131].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[131].name = "南 非 人 民 邦";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 56)
			{
				GlobalScript.inst.gameState.allcountries[131].parts[2] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " 用 几 座 大 炮 支 配 某 国 命 运 的 时 代 早 就 过 去 了 — — 彭 德 怀 的 名 言 再 度 应 验 。 血 河 战 争 时 期 的 以 一 敌 十 “ 神 迹 ” 早 已 成 为 历 史 ： 非 洲 各 国 凭 借 错 综 复 杂 的 地 形 ， 同 仇 敌 忾 的 气 概 与 多 年 战 争 的 磨 练 痛 打 了 布 尔 人 武 装 。 后 者 的 直 升 机 与 重 火 力 装 备 在 游 击 战 内 毫 无 用 途 ， 并 同 试 图 塑 造 恐 怖 氛 围 逼 降 非 洲 国 家 的 焦 土 政 策 一 齐 拖 累 补 给 ， 最 终 导 致 “ 特 别 军 事 行 动 ” 转 向 长 期 消 耗 并 毫 无 用 功 。 南 非 的 种 族 主 义 者 只 得 以 “ 取 得 阶 段 性 胜 利 ” 的 说 法 搪 塞 国 内 舆 论 ， 并 抛 下 上 千 具 尸 体 和 数 百 辆 作 战 车 辆 后 灰 溜 溜 的 逃 离 了 战 场 。|| 南 非 种 族 主 义 者 的 暴 行 激 起 了 安 哥 拉 各 大 部 族 的 族 群 情 结 并 形 成 统 一 战 线 。 最 终 ， 该 国 以 超 过 三 分 之 一 安 哥 拉 人 流 离 失 所 的 代 价 成 功 遏 制 侵 略 。 值 得 一 提 的 是 ， 为 了 保 护 海 上 油 田 资 产 ， 安 哥 拉 政 府 特 许 这 些 油 田 的 外 国 投 资 所 有 者 派 出 安 保 部 队 保 护 这 些 黑 金 命 脉 ， 其 中 甚 至 有 来 自 南 非 的 德 比 尔 斯 雇 佣 兵 公 司 的 雇 员 — — 他 们 不 满 南 非 “ 法 西 斯 主 义 疯 子 “ 夺 权 ， 从 而 辞 职 选 择 新 的 雇 主 。";
				}
				else
				{
					text = " 非 洲 军 队 难 以 同 久 经 沙 场 且 训 练 有 素 的 南 非 军 人 抗 衡 ， 很 快 便 一 触 即 溃 。 期 间 甚 至 出 现 三 十 名 南 非 士 兵 在 毫 无 损 失 的 情 况 下 反 包 围 并 围 歼 一 千 名 安 哥 拉 正 规 军 和 民 兵 混 编 队 伍 的 “ 战 绩 ” 。" + ((allcountries[123].Gosstroy == 1) ? "安 哥 拉 领 导 人 则 流 亡 加 蓬 ， 预 计 其 下 一 站 是 苏 联 或 中 国 。" : "安 哥 拉 领 导 人 则 流 亡 加 蓬 ， 预 计 其 下 一 站 是 美 国 或 中 国 。") + "由 于 在 当 地 缺 乏 存 在 根 基 ， 南 非 选 择 直 接 将 当 地 划 为 军 管 区 并 预 谋 建 立 “ 大 西 南 非 洲 ” 。 可 在 此 之 前 ， 安 哥 拉 不 过 是 非 洲 版 本 巴 尔 干 ： 游 击 战 士 们 使 用 毒 刺 弹 或 R P G 持 续 同 南 非 扫 荡 直 升 机 对 攻 ， 南 非 军 队 则 从 战 略 村 计 划 内 取 经 并 挨 村 挨 镇 清 剿 抵 抗 者 ， 挖 掘 万 人 坑 。 总 之 ， 南 非 已 经 卡 在 了 非 洲 绞 肉 机 中 。 但 无 论 如 何 ，<color=red>安 哥 拉 完 蛋 了</color> ";
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
					GlobalScript.inst.gameState.empires[1].power -= 10;
					GlobalScript.inst.gameState.allcountries[123].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[123].puppetOf = 131;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 57)
			{
				GlobalScript.inst.gameState.allcountries[131].parts[3] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " 用 几 座 大 炮 支 配 某 国 命 运 的 时 代 早 就 过 去 了 — — 彭 德 怀 的 名 言 再 度 应 验 。 血 河 战 争 时 期 的 以 一 敌 十 “ 神 迹 ” 早 已 成 为 历 史 ： 非 洲 各 国 凭 借 错 综 复 杂 的 地 形 ， 同 仇 敌 忾 的 气 概 与 多 年 战 争 的 磨 练 痛 打 了 布 尔 人 武 装 。 后 者 的 直 升 机 与 重 火 力 装 备 在 游 击 战 内 毫 无 用 途 ， 并 同 试 图 塑 造 恐 怖 氛 围 逼 降 非 洲 国 家 的 焦 土 政 策 一 齐 拖 累 补 给 ， 最 终 导 致 “ 特 别 军 事 行 动 ” 转 向 长 期 消 耗 并 毫 无 用 功 。 南 非 的 种 族 主 义 者 只 得 以 “ 取 得 阶 段 性 胜 利 ” 的 说 法 搪 塞 国 内 舆 论 ， 并 抛 下 上 千 具 尸 体 和 数 百 辆 作 战 车 辆 后 灰 溜 溜 的 逃 离 了 战 场 。|| 南 非 的 进 军 几 乎 将 “ 博 茨 瓦 纳 奇 迹 ” 付 之 一 炬 ， 战 争 的 伤 痕 在 该 国 四 处 可 见 ， 作 为 该 国 经 济 命 脉 的 畜 牧 业 更 是 惨 遭 南 非 炭 疽 与 芥 子 气 化 学 武 器 的 打 击 ， 这 只 会 让 该 国 本 就 被 荒 漠 化 挑 战 的 经 济 雪 上 加 霜 。";
				}
				else
				{
					text = " 非 洲 军 队 难 以 同 久 经 沙 场 且 训 练 有 素 的 南 非 军 人 抗 衡 ， 很 快 便 一 触 即 溃 。 期 间 甚 至 出 现 三 十 名 南 非 士 兵 在 毫 无 损 失 的 情 况 下 反 包 围 并 围 歼 一 千 名 博 茨 瓦 纳 正 规 军 和 民 兵 混 编 队 伍 的 “ 战 绩 ” 。 博 茨 瓦 纳 领 导 人 则 流 亡 赞 比 亚 ， 预 计 其 下 一 站 是 苏 联 或 中 国 。 新 政 府 对 “ 纽 威 维 尔 德 ” 计 划 故 事 重 提 ， 在 博 茨 瓦 纳 地 区 建 立 了 仿 照 彼 时 布 尔 人 定 居 政 权 的 “ 斯 提 拉 兰 ” 共 和 国 ， 并 将 其 作 为 殖 民 开 垦 前 哨 。 然 而 ， 博 茨 瓦 纳 的 现 状 却 给 殖 民 者 开 了 个 残 酷 笑 话 — — 由 于 该 国 生 态 惨 遭 南 非 炭 疽 与 芥 子 气 化 学 武 器 的 打 击 ， 博 茨 瓦 纳 几 乎 陷 入 生 态 崩 溃 ， 在 未 来 的 数 十 年 间 都 不 可 能 吸 引 移 民 。 可 以 说 ， 这 是 一 场 毫 无 意 义 的 胜 利 ， 因 为 — — <color=red>博 茨 瓦 纳 完 蛋 了 </color> ";
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
					GlobalScript.inst.gameState.empires[1].power -= 10;
					GlobalScript.inst.gameState.allcountries[129].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[129].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[129].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[129].puppetOf = 131;
					GlobalScript.inst.gameState.allcountries[129].name = " 斯 提 拉 兰";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 58)
			{
				GlobalScript.inst.gameState.allcountries[131].parts[4] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " 用 几 座 大 炮 支 配 某 国 命 运 的 时 代 早 就 过 去 了 — — 彭 德 怀 的 名 言 再 度 应 验 。 血 河 战 争 时 期 的 以 一 敌 十 “ 神 迹 ” 早 已 成 为 历 史 ： 非 洲 各 国 凭 借 错 综 复 杂 的 地 形 ， 同 仇 敌 忾 的 气 概 与 多 年 战 争 的 磨 练 痛 打 了 布 尔 人 武 装 。 后 者 的 直 升 机 与 重 火 力 装 备 在 游 击 战 内 毫 无 用 途 ， 并 同 试 图 塑 造 恐 怖 氛 围 逼 降 非 洲 国 家 的 焦 土 政 策 一 齐 拖 累 补 给 ， 最 终 导 致 “ 特 别 军 事 行 动 ” 转 向 长 期 消 耗 并 毫 无 用 功 。 南 非 的 种 族 主 义 者 只 得 以 “ 取 得 阶 段 性 胜 利 ” 的 说 法 搪 塞 国 内 舆 论 ， 并 抛 下 上 千 具 尸 体 和 数 百 辆 作 战 车 辆 后 灰 溜 溜 的 逃 离 了 战 场 。|| 本 就 因 内 战 满 目 疮 痍 ， 千 疮 百 孔 的 莫 桑 比 克 只 能 享 受 皮 洛 士 式 胜 利 ： 战 争 只 会 让 该 国 在 人 道 主 义 危 机 内 越 陷 越 深 ， 近 乎 万 劫 不 复 。 泛 伊 斯 兰 世 界 志 愿 者 声 音 则 越 来 越 大 — — 由 于 标 榜 “ 文 明 进 军 ” 的 南 非 入 侵 部 队 炸 毁 了 朱 玛 清 真 寺 ， 当 地 很 快 便 成 为 了 国 际 穆 斯 林 的 伊 比 利 亚 半 岛 。 ";
				}
				else
				{
					text = " 非 洲 军 队 难 以 同 久 经 沙 场 且 训 练 有 素 的 南 非 军 人 抗 衡 ， 很 快 便 一 触 即 溃 。 期 间 甚 至 出 现 三 十 名 南 非 士 兵 在 毫 无 损 失 的 情 况 下 反 包 围 并 围 歼 一 千 名 莫 桑 比 克 正 规 军 和 民 兵 混 编 队 伍 的 “ 战 绩 ” 。 莫 桑 比 克 领 导 人 则 流 亡 坦 桑 尼 亚 ， 预 计 其 下 一 站 是 苏 联 或 中 国 。 莫 桑 比 克 全 国 抵 抗 运 动 已 得 到 南 非 授 权 组 建 新 “ 莫 桑 比 克 国 ” 。 可 对 南 非 与 其 仆 从 军 而 言 ， 胜 利 的 果 实 并 没 有 预 想 的 那 么 甜 美 ： 广 阔 的 莫 桑 比 克 雨 林 堪 称 非 洲 越 南 ， 持 续 消 耗 着 南 非 占 领 军 ， 使 莫 桑 比 克 成 为 了 一 块 卡 在 其 咽 喉 的 鸡 肋 ： 撤 出 莫 桑 比 克 意 味 着 将 胜 利 成 果 拱 手 相 让 ， 坚 守 则 意 味 着 忍 受 消 耗 战 损 失 。 总 之 ， 南 非 已 经 卡 在 了 非 洲 绞 肉 机 中 。 但 无 论 如 何 ，<color=red>莫 桑 比 克 完 蛋 了  </color> ";
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
					GlobalScript.inst.gameState.empires[1].power -= 10;
					allcountries[126].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[125].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[125].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[125].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[125].puppetOf = 131;
					GlobalScript.inst.gameState.allcountries[126].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[126].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[126].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[126].puppetOf = 131;
					GlobalScript.inst.gameState.allcountries[126].name = " 莫 桑 比 克 国";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 59)
			{
				GlobalScript.inst.gameState.allcountries[127].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " 用 几 座 大 炮 支 配 某 国 命 运 的 时 代 早 就 过 去 了 — — 彭 德 怀 的 名 言 再 度 应 验 。 血 河 战 争 时 期 的 以 一 敌 十 “ 神 迹 ” 早 已 成 为 历 史 ： 非 洲 各 国 凭 借 错 综 复 杂 的 地 形 ， 同 仇 敌 忾 的 气 概 与 多 年 战 争 的 磨 练 痛 打 了 布 尔 人 武 装 。 后 者 的 直 升 机 与 重 火 力 装 备 在 游 击 战 内 毫 无 用 途 ， 并 同 试 图 塑 造 恐 怖 氛 围 逼 降 非 洲 国 家 的 焦 土 政 策 一 齐 拖 累 补 给 ， 最 终 导 致 “ 特 别 军 事 行 动 ” 转 向 长 期 消 耗 并 毫 无 用 功 。 南 非 的 种 族 主 义 者 只 得 以 “ 取 得 阶 段 性 胜 利 ” 的 说 法 搪 塞 国 内 舆 论 ， 并 抛 下 上 千 具 尸 体 和 数 百 辆 作 战 车 辆 后 灰 溜 溜 的 逃 离 了 战 场 。|| 出 乎 意 料 的 是 ， 前 总 理 伊 安 · 史 密 斯 （ 他 并 没 有 离 开 该 国 ） 接 受 了 《 津 巴 布 韦 先 驱 报 》 的 记 者 采 访 ， 并 就 这 场 战 争 做 了 段 妙 趣 横 生 的 谈 话 ， 谈 话 以 这 样 的 一 句 话 结 束 “ 这 群 种 地 的 白 佬 真 是 幼 稚 病 入 脑 ！ 打 击 敌 人 的 目 的 是 为 了 建 立 稳 定 的 社 会 ， 而 不 是 为 了 把 对 面 赶 尽 杀 绝 ！ 也 许 我 真 的 不 该 以 南 非 经 验 为 样 板 治 国 ？ ”";
				}
				else
				{
					text = " 非 洲 军 队 难 以 同 久 经 沙 场 且 训 练 有 素 的 南 非 军 人 抗 衡 ， 很 快 便 一 触 即 溃 。 期 间 甚 至 出 现 三 十 名 南 非 士 兵 在 毫 无 损 失 的 情 况 下 反 包 围 并 围 歼 一 千 名 津 巴 布 韦 正 规 军 和 民 兵 混 编 队 伍 的 “ 战 绩 ” 。 津 巴 布 韦 领 导 人 则 流 亡 赞 比 亚 ， 预 计 其 下 一 站 是 苏 联 或 中 国 。 绿 白 旗 再 度 在 索 尔 兹 伯 里 的 上 空 飘 扬 。 可 对 南 非 与 其 仆 从 军 而 言 ， 胜 利 的 果 实 并 没 有 预 想 的 那 么 甜 美 ： 广 阔 的 津 巴 布 韦 雨 林 堪 称 非 洲 越 南 ， 持 续 消 耗 着 南 非 占 领 军 ， 使 津 巴 布 韦 成 为 了 一 块 卡 在 其 咽 喉 的 鸡 肋 ： 撤 出 罗 得 西 亚 意 味 着 将 胜 利 成 果 拱 手 相 让 ， 坚 守 则 意 味 着 忍 受 消 耗 战 损 失 。 总 之 ， 南 非 已 经 卡 在 了 非 洲 绞 肉 机 中 。 但 无 论 如 何 ，<color=red>津 巴 布 韦 完 蛋 了  </color> ";
					GlobalScript.inst.gameState.influencePRC -= 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
					GlobalScript.inst.gameState.empires[1].power -= 10;
					GlobalScript.inst.gameState.allcountries[127].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[127].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[127].puppetOf = 131;
					GlobalScript.inst.gameState.allcountries[127].name = " 罗 得 西 亚 共 和 国";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 60)
			{
				GlobalScript.inst.gameState.allcountries[117].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " 在 西 方 各 国 ， 摩 洛 哥 ， 沙 特 阿 拉 伯 和 “ 狩 猎 俱 乐 部 ” 的 帮 助 下 ， 蒙 博 托 设 法 击 溃 了 孱 弱 的 刚 果 民 族 解 放 阵 线 部 队 。 法 国 外 籍 兵 团 彻 底 浇 灭 了 古 巴 在 扎 伊 尔 再 造 一 个 越 南 的 美 梦 。 扎 伊 尔 仍 然 是 这 般 暗 无 天 日 。 战 无 不 胜 的 勇 士 就 这 样 斩 断 了 暴 徒 的 头 颅 ， 该 国 的 未 来 越 发 暗 淡 … …";
					GlobalScript.inst.gameState.allcountries[117].level_of_dev = 1;
					GlobalScript.inst.gameState.empires[0].power += 15;
					GlobalScript.inst.gameState.empires[1].power -= 15;
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					text = " 出 乎 意 料 ， 刚 果 民 族 解 放 阵 线 碾 碎 了 缺 少 训 练 更 不 得 民 心 的 扎 伊 尔 陆 军 。 在 卢 本 巴 希 的 陷 落 后 ， 扎 伊 尔 脆 弱 的 政 权 像 纸 一 样 被 撕 碎 ， 即 使 是 外 籍 军 团 也 没 能 阻 挡 勇 士 们 解 放 该 国 的 决 心 。 古 巴 领 导 人 卡 斯 特 罗 称 其 为 一 场 不 亚 于 奠 边 府 的 伟 大 胜 利 ， 扎 伊 尔 也 失 去 了 重 要 的 铜 矿 来 源 。 高 傲 的 公 鸡 被 青 虫 啄 痛 了 脚 ， 它 正 在 寻 求 报 仇 的 那 一 天 … …";
					GlobalScript.inst.gameState.empires[0].power -= 15;
					GlobalScript.inst.gameState.empires[1].power += 15;
					GlobalScript.inst.gameState.allcountries[163].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[163].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[163].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[163].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[163].prosov = true;
					GlobalScript.inst.gameState.allcountries[163].Torg = true;
				}
				else
				{
					text = " 很 显 然 ， 这 次 战 争 没 有 胜 者 。 不 管 是 扎 伊 尔 抑 或 是 安 哥 拉 ， 没 有 一 方 在 开 战 后 取 得 主 要 的 预 计 的 成 果 。 在 联 合 国 和 刚 果 布 的 调 停 下 ， 双 方 很 快 达 成 了 初 步 的 停 火 协 议 。 虽 然 之 后 双 方 将 继 续 边 境 冲 突 很 长 一 段 时 间 并 且 互 相 渗 透 破 坏 ， 但 是 看 起 来 扎 伊 尔 勉 强 在 挑 战 者 面 前 站 稳 了 脚 跟 。";
					GlobalScript.inst.gameState.empires[0].power -= 15;
					GlobalScript.inst.gameState.empires[1].power -= 15;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 61)
			{
				GlobalScript.inst.gameState.allcountries[117].parts[0] = false;
				if (!GlobalScript.inst.gameState.allcountries[163].parts[0])
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 850)
					{
						text = " 出 乎 意 料 ， 刚 果 民 族 解 放 阵 线 碾 碎 了 缺 少 训 练 更 不 得 民 心 的 扎 伊 尔 陆 军 。 该 组 织 设 法 超 额 完 成 了 任 务 ， 不 仅 夺 下 了 科 卢 维 齐 市 ， 甚 至 拿 下 了 卢 本 巴 希 。 扎 伊 尔 脆 弱 的 政 权 像 纸 一 样 被 撕 碎 ， 即 使 是 外 籍 军 团 也 没 能 阻 挡 勇 士 们 的 决 心 。 古 巴 领 导 人 卡 斯 特 罗 称 其 为 一 场 不 亚 于 奠 边 府 的 伟 大 胜 利 ， 扎 伊 尔 也 失 去 了 重 要 的 铜 矿 来 源 。 高 傲 的 公 鸡 被 青 虫 啄 痛 了 脚 ， 它 正 在 寻 求 报 仇 的 那 一 天 ， 尽 管 这 一 天 可 能 永 远 不 会 来 临 … …";
						GlobalScript.inst.gameState.empires[0].power -= 15;
						GlobalScript.inst.gameState.empires[1].power += 15;
						GlobalScript.inst.gameState.allcountries[163].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[163].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[163].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[163].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[163].prosov = true;
						GlobalScript.inst.gameState.allcountries[163].Torg = true;
					}
					else
					{
						text = " 最 终 ， 在 上 一 场 战 争 一 样 ， 法 国 与 比 利 时 的 军 事 干 涉 击 退 了 入 侵 。 美 国 和 古 巴 逼 迫 安 哥 拉 和 扎 伊 尔 进 行 谈 判 ， 达 成 了 互 不 侵 犯 条 约 。 这 结 束 了 双 方 对 相 互 叛 乱 组 织 的 支 持 。 扎 伊 尔 暂 时 切 断 了 对 被 包 围 领 土 卡 宾 达 解 放 阵 线 （ F L E C ） ， 安 哥 拉 民 族 解 放 阵 线 （ F N L A ） 和 争 取 安 哥 拉 彻 底 独 立 全 国 联 盟 （ U N I T A ） 的 支 持 ， 安 哥 拉 将 限 制 沙 巴 分 离 主 义 分 子 的 进 一 步 活 动 。 这 也 是 美 国 与 法 国 在 第 一 次 越 南 战 争 后 的 首 次 合 作 。";
						GlobalScript.inst.gameState.empires[0].power += 15;
						GlobalScript.inst.gameState.empires[1].power -= 15;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 800)
				{
					text = " 穷 兵 黩 武 ， 贪 污 腐 败 ， 思 想 混 乱 而 民 心 不 稳 的 蒙 博 托 小 看 了 人 民 的 怒 火 。 伴 随 着 扎 军 耻 辱 性 地 丢 失 了 姆 布 吉 马 依 和 卢 本 巴 希 ， 解 放 阵 线 得 以 将 胜 利 的 红 旗 插 在 了 人 民 宫 上 ， 尽 管 F L N A 和 新 扎 伊 尔 运 动 （ 由 蒙 博 托 的 子 嗣 代 理 ） 化 整 为 零 开 始 在 该 国 崎 岖 的 雨 林 里 打 起 了 游 击 ， 但 在 我 方 的 顾 问 和 古 巴 军 队 的 监 督 下 ， 新 的 政 府 将 设 法 以 恢 复 被 折 磨 的 奄 奄 一 息 的 国 家 。||高 傲 的 公 鸡 啄 向 青 虫 ， 谁 知 那 是 条 毒 蛇 ？";
					GlobalScript.inst.gameState.allcountries[163].parts[0] = false;
					GlobalScript.inst.gameState.allcountries[117].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[117].SubGosstroy = 10;
					GlobalScript.inst.gameState.allcountries[117].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[117].prosov = true;
					GlobalScript.inst.gameState.allcountries[117].name = "刚 果 民 主 主 义 人 民 共 和 国";
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 800)
				{
					if (resultOfEvents[610] == 1)
					{
						text = " 法 国 与 比 利 时 的 军 事 干 涉 击 退 了 入 侵 ， 但 扎 伊 尔 军 队 也 没 能 彻 底 击 溃 F N L C 的 解 放 区 。 美 国 和 古 巴 逼 迫 安 哥 拉 和 扎 伊 尔 进 行 谈 判 ， 达 成 了 互 不 侵 犯 条 约 。 这 结 束 了 双 方 对 相 互 叛 乱 组 织 的 支 持 。 扎 伊 尔 暂 时 切 断 了 对 被 包 围 领 土 卡 宾 达 解 放 阵 线 （ F L E C ） ， 安 哥 拉 民 族 解 放 阵 线 （ F N L A ） 和 争 取 安 哥 拉 彻 底 独 立 全 国 联 盟 （ U N I T A ） 的 支 持 ， 安 哥 拉 将 使 沙 巴 分 离 主 义 者 不 采 取 进 一 步 行 动 ， 并 向 其 施 压 促 成 统 一 。 这 也 是 美 国 与 法 国 在 第 一 次 越 南 战 争 后 的 首 次 合 作 。 但 总 的 来 说 ， 刚 果 人 也 有 了 自 己 的 南 越 ， 尽 管 只 是 一 个 小 小 的 伪 政 权 ， 并 且 还 和 布 拉 柴 维 尔 政 府 重 名 了 （ 最 近 有 传 言 称 会 改 为 刚 果 民 主 主 义 人 民 共 和 国 ） 。 但 观 察 家 们 认 为 苏 联 成 功 的 将 吸 管 插 进 了 非 洲 的 腹 地 。";
						GlobalScript.inst.gameState.empires[0].power -= 15;
						GlobalScript.inst.gameState.empires[1].power -= 15;
					}
					else
					{
						text = " 最 终 ， 非 洲 的 越 南 确 实 得 到 了 越 南 的 结 局 — — 不 过 是 越 南 共 和 国 。 高 度 依 赖 装 甲 部 队 和 古 巴 人 的 解 放 力 量 被 刚 果 的 丛 林 陷 入 了 艰 苦 斗 争 。 小 股 部 队 设 法 借 道 布 拉 柴 维 尔 攻 入 了 金 沙 萨 ， 却 很 快 就 被 扎 伊 尔 武 装 力 量 赶 出 了 城 市 。 过 长 的 补 给 线 直 接 导 致 了 先 头 部 队 被 完 全 孤 立 ， 在 姆 布 吉 马 依 的 拉 锯 战 大 大 耗 费 了 解 放 阵 线 的 兵 力 。 更 糟 糕 的 是 ， 由 于 糟 糕 的 宣 传 机 器 帮 上 的 倒 忙 ， 不 仅 没 有 群 众 支 持 F N L C ， 甚 至 还 会 帮 助 扎 伊 尔 部 队 找 到 他 们 的 藏 身 之 处 。 F N L C 的 士 兵 越 来 越 少 ， 最 后 ， 扎 伊 尔 的 旗 帜 又 一 次 在 卢 本 巴 希 上 空 飘 扬 ， 姆 奔 巴 本 人 也 不 知 所 踪 。 扎 伊 尔 仍 然 是 这 般 暗 无 天 日 。 战 无 不 胜 的 勇 士 就 这 样 斩 断 了 暴 徒 的 头 颅 。 雄 鸡 吞 下 了 那 条 不 自 量 力 的 青 虫";
						GlobalScript.inst.gameState.allcountries[163].parts[0] = false;
						GlobalScript.inst.gameState.allcountries[117].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[117].SubGosstroy = 9;
						GlobalScript.inst.gameState.empires[0].power += 15;
						GlobalScript.inst.gameState.empires[1].power -= 15;
					}
				}
				else
				{
					text = " 法 国 与 比 利 时 的 军 事 干 涉 击 退 了 入 侵 ， 但 扎 伊 尔 军 队 也 没 能 彻 底 击 溃 F N L C 的 解 放 区 。 美 国 和 古 巴 逼 迫 安 哥 拉 和 扎 伊 尔 进 行 谈 判 ， 达 成 了 互 不 侵 犯 条 约 。 这 结 束 了 双 方 对 相 互 叛 乱 组 织 的 支 持 。 扎 伊 尔 暂 时 切 断 了 对 被 包 围 领 土 卡 宾 达 解 放 阵 线 （ F L E C ） ， 安 哥 拉 民 族 解 放 阵 线 （ F N L A ） 和 争 取 安 哥 拉 彻 底 独 立 全 国 联 盟 （ U N I T A ） 的 支 持 ， 安 哥 拉 将 使 沙 巴 分 离 主 义 者 不 采 取 进 一 步 行 动 ， 并 向 其 施 压 促 成 统 一 。 这 也 是 美 国 与 法 国 在 第 一 次 越 南 战 争 后 的 首 次 合 作 。 但 总 的 来 说 ， 刚 果 人 也 有 了 自 己 的 南 越 ， 尽 管 只 是 一 个 小 小 的 伪 政 权 ， 并 且 还 和 布 拉 柴 维 尔 政 府 重 名 了 （ 最 近 有 传 言 称 会 改 为 刚 果 民 主 主 义 人 民 共 和 国 ） 。 但 观 察 家 们 认 为 苏 联 成 功 的 将 吸 管 插 进 了 非 洲 的 腹 地 。";
					GlobalScript.inst.gameState.empires[0].power -= 15;
					GlobalScript.inst.gameState.empires[1].power -= 15;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 62)
			{
				GlobalScript.inst.gameState.allcountries[117].parts[1] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 100)
				{
					text = "再 软 弱 的 战 士 也 是 战 士 ， 做 困 兽 之 斗 的 扎 伊 尔 政 权 爆 发 了 可 怕 的 战 斗 力 ， 纵 使 有 着 “ 非 洲 人 民 解 放 军 ” 的 美 称 的 坦 桑 尼 亚 军 队 和 卡 加 梅 的 部 队 亲 自 下 场 ， 也 只 能 和 武 装 力 量 打 个 五 五 开 。 快 速 击 溃 蒙 博 托 政 权 的 计 划 已 然 落 空 ， 随 后 带 来 的 是 旷 日 持 久 的 内 战 。 乌 干 达 和 卢 旺 达 人 也 没 闲 着 ， 无 法 偿 还 的 债 务 就 由 刚 果 肥 沃 的 资 源 作 为 补 偿 。 不 过 ， 他 们 仍 然 设 法 在 基 桑 加 尼 建 立 了 刚 果 民 主 共 和 国 政 权 ， 这 个 政 权 得 到 了 不 少 社 会 主 义 国 家 ， 甚 至 是 西 方 的 承 认 ， 但 全 国 的 统 一 仍 然 是 一 个 漫 长 的 旅 程 ， 也 许 本 世 纪 末 我 们 都 看 不 到 这 一 场 景 … …";
					GlobalScript.inst.gameState.allcountries[117].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[117].SubGosstroy = 9;
					GlobalScript.inst.gameState.empires[0].power += 30;
					influencePRC -= 30;
				}
				else if (resultOfEvents[610] == 2)
				{
					text = "在 激 烈 战 斗 中 ， 扎 伊 尔 政 府 军 要 么 被 摧 毁 ， 要 么 被 迫 离 开 南 北 基 伍 省 。 数 万 逃 兵 卷 起 最 后 的 家 当 向 西 迁 入 扎 伊 尔 丛 林 ， 许 多 人 死 于 饥 饿 和 暴 露 在 荒 野 中 ， 或 成 为 各 种 武 装 方 袭 击 的 受 害 者 。 但 无 人 原 因 庇 护 这 些 刽 子 手 们 ， 他 们 显 然 是 罪 有 应 得 。||刚 果 的 革 命 者 及 其 盟 友 步 行 或 者 坐 在 “ 解 放 ” 牌 卡 车 上 穿 过 扎 伊 尔 ， 前 往 首 都 金 沙 萨 。 事 实 证 明 ， 经 过 几 十 年 的 敲 骨 吸 髓 ， 民 众 对 蒙 博 托 只 有 深 深 的 反 感 和 厌 恶 。 国 民 军 队 中 大 多 数 士 气 低 落 的 士 兵 要 么 加 入 了 革 命 军 ， 要 么 逃 回 故 乡 。 来 自 扎 伊 尔 各 地 村 庄 和 城 镇 的 人 自 发 地 加 入 了 革 命 军 队 和 维 持 解 放 区 的 民 兵 。 经 过 数 月 的 奋 斗 和 时 不 时 插 入 的 谈 判 。 扎 伊 尔 政 府 无 限 趋 近 于 崩 溃 ， 蒙 博 托 在 逃 离 该 国 的 途 中 被 伪 装 成 保 镖 的 革 命 军 间 谍 刺 杀 。 一 天 后 ， 革 命 军 彻 底 攻 克 了 金 沙 萨 。 基 萨 斯 当 选 为 新 政 府 总 理 ， 基 赞 加 则 成 为 了 总 统 ， 国 号 也 更 为 刚 果 民 主 共 和 国 。||革 命 阵 线 在 首 都 举 行 了 盛 大 的 阅 兵 仪 式 ， 庆 祝 着 属 于 刚 果 人 民 的 胜 利 。 在 内 战 中 犯 下 重 大 罪 行 的 前 政 府 成 员 被 公 审 处 决 。||卢 蒙 巴 的 理 想 ， 再 度 照 耀 在 了 刚 果 河 上";
					GlobalScript.inst.gameState.allcountries[117].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[117].SubGosstroy = 17;
					GlobalScript.inst.gameState.allcountries[117].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[117].Torg = true;
					GlobalScript.inst.gameState.allcountries[117].proprc = true;
					GlobalScript.inst.gameState.allcountries[117].name = "刚 果 民 主 人 民 共 和 国";
					GlobalScript.inst.gameState.allcountries[117].level_of_dev = 0;
					GlobalScript.inst.gameState.empires[0].power -= 15;
					GlobalScript.inst.gameState.empires[1].power -= 15;
					GlobalScript.inst.gameState.influencePRC += 30;
				}
				else
				{
					text = "如 果 说 帝 国 主 义 是 纸 老 虎 ， 那 么 蒙 博 托 连 纸 浆 都 没 用 上 。 在 久 经 沙 场 的 革 命 军 眼 里 ， 蒙 博 托 的 强 盗 士 兵 果 然 如 同 他 们 期 望 的 一 触 即 溃 了 ， 蒙 博 托 逃 向 了 美 国 ， 而 红 旗 也 升 上 了 金 沙 萨 的 人 民 宫 。 然 而 ， 在 胜 利 后 ， 刚 果 人 面 临 着 许 多 问 题 - 新 生 政 权 相 当 的 不 得 民 心 且 高 度 依 赖 外 国 援 助 。 在 进 军 的 路 上 ， 刚 果 解 放 民 主 力 量 联 盟 可 没 少 犯 下 令 人 发 指 的 暴 行 。 仅 在 戈 马 村 一 处 就 有 数 百 具 尸 体 ， 而 刚 果 民 主 力 量 解 放 同 盟 极 力 否 认 这 一 点 。 同 时 ， 新 政 权 能 够 控 制 金 沙 萨 完 全 是 卢 旺 达 人 和 乌 干 达 人 的 支 持 。 前 者 甚 至 公 开 占 据 了 刚 果 东 部 的 大 片 土 地 并 掠 夺 矿 产 。 而 詹 姆 斯 · 卡 巴 雷 贝 （ 他 是 外 国 联 军 的 最 高 指 挥 官 ， 卢 旺 达 人 ） 手 握 重 兵 ， 就 像 一 把 利 刃 抵 在 卡 比 拉 的 咽 喉 ， 这 时 候 也 只 有 津 巴 布 韦 愿 意 给 卡 比 拉 说 两 句 好 话 。 这 到 底 是 解 放 ， 还 是 沦 为 新 的 傀 儡 ？ 只 有 时 间 能 交 上 答 卷 … …";
					GlobalScript.inst.gameState.allcountries[117].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[117].SubGosstroy = 15;
					GlobalScript.inst.gameState.allcountries[117].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[117].Torg = true;
					GlobalScript.inst.gameState.allcountries[117].proprc = true;
					GlobalScript.inst.gameState.allcountries[117].name = "刚 果 民 主 共 和 国";
					GlobalScript.inst.gameState.allcountries[117].level_of_dev = 0;
					GlobalScript.inst.gameState.empires[0].power -= 15;
					GlobalScript.inst.gameState.empires[1].power -= 15;
					GlobalScript.inst.gameState.influencePRC += 30;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 63)
			{
				GlobalScript.inst.gameState.allcountries[66].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					text = " 在 最 大 港 口 杜 阿 拉 附 近 的 一 场 极 其 激 烈 的 战 斗 后 ， 喀 麦 隆 民 族 解 放 军 击 溃 了 喀 麦 隆 军 队 和 法 军 ， 法 军 在 海 军 的 火 力 掩 护 下 仓 皇 逃 出 喀 麦 隆 ， 被 击 溃 的 喀 麦 隆 军 队 要 么 被 围 歼 要 么 投 降 。 最 终 ， 喀 麦 隆 人 民 联 盟 得 以 雪 耻 ， 彻 底 解 放 全 喀 麦 隆 ， 喀 麦 隆 人 民 共 和 国 就 此 诞 生 。 喀 麦 隆 人 民 联 盟 改 组 为 喀 麦 隆 共 产 党 ， 将 马 列 主 义 毛 泽 东 思 想 写 入 党 纲 ， 并 宣 布 进 行 民 族 民 主 革 命 ， 对 大 量 法 资 企 业 和 石 油 产 业 进 行 国 有 化 ， 清 算 喀 麦 隆 战 争 时 期 亲 法 合 作 者 的 反 革 命 罪 行 ， 枪 毙 了 被 抓 捕 到 的 亲 法 合 作 者 、 喀 麦 隆 军 队 和 政 府 高 层 ， 学 习 乌 贾 马 社 会 主 义 的 经 验 开 始 对 农 村 进 行 合 作 化 运 动 。 新 的 喀 麦 隆 政 府 宣 布 对 我 们 友 好 ， 愿 意 深 化 与 我 们 的 合 作 关 系" + (event_done[500] ? " 并 积 极 宣 布 将 投 身 于 非 洲 的 革 命 斗 争 与 解 放" : null) + " 。";
					GlobalScript.inst.gameState.allcountries[66].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[66].SubGosstroy = 17;
					GlobalScript.inst.gameState.allcountries[66].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[66].Torg = true;
					GlobalScript.inst.gameState.allcountries[66].proprc = true;
					GlobalScript.inst.gameState.allcountries[66].name = "喀 麦 隆 人 民 共 和 国";
					GlobalScript.inst.gameState.influencePRC += 20;
				}
				else
				{
					text = " 在 法 军 和 喀 麦 隆 军 队 的 联 合 镇 压 下 ， 喀 麦 隆 重 现 了 喀 麦 隆 战 争 的 场 景 ： 喀 麦 隆 民 族 解 放 军 又 一 次 被 击 溃 ， 围 剿 ， 最 后 消 灭 。 大 量 喀 麦 隆 民 族 解 放 军 和 喀 麦 隆 人 民 联 盟 的 高 层 被 刺 杀 ， 被 处 死 ， 剩 下 的 喀 麦 隆 人 民 联 盟 成 员 被 迫 流 亡 其 他 国 家 以 求 避 难 。 喀 麦 隆 再 次 回 到 了 法 国 主 导 的 旧 秩 序 中 。 ";
					GlobalScript.inst.gameState.allcountries[66].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[66].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[66].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[66].puppetOf = 21;
					GlobalScript.inst.gameState.influencePRC -= 20;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 64)
			{
				GlobalScript.inst.gameState.allcountries[149].parts[1] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					if (resultOfEvents[633] != 1 && modifies[6].active && modifies[3].active)
					{
						text = "最 终 ， 危 地 马 拉 全 国 革 命 联 盟 取 得 了 内 战 的 胜 利 ， 红 旗 再 次 飘 扬 于 危 地 马 拉 城 中 。 新 政 府 由 P G T - N D N 的 何 塞 · 阿 尔 贝 托 · 卡 多 萨 ， O R P A 的 罗 德 里 戈 · 阿 斯 图 里 亚 斯 ， E G P 的 罗 兰 多 · 莫 兰 指 挥 官 （ 里 卡 多 · 拉 米 雷 斯 ） 、 F A R 的 巴 勃 罗 · 孟 桑 托 指 挥 官 （ 豪 尔 赫 · 伊 斯 梅 尔 · 索 托 ） 所 组 成 的 四 人 领 导 机 构 共 同 领 导 。 联 盟 内 的 各 党 相 继 解 散 ， 彻 底 合 并 入 U R N G ， 马 克 思 列 宁 主 义 毛 泽 东 思 想 被 写 入 该 党 的 新 一 版 党 章 中 。 流 亡 在 外 的 危 地 马 拉 劳 动 党 创 始 人 、 阿 本 斯 的 朋 友 何 塞 · 曼 努 埃 尔 · 福 图 尼 也 终 于 得 以 回 国 并 被 选 入 U R N G 政 治 局 。 在 危 地 马 拉 民 主 共 和 国 成 立 仪 式 上 ， 罗 兰 多 · 莫 兰 与 罗 德 里 戈 · 阿 斯 图 里 亚 斯 宣 布 将 “ 继 承 阿 本 斯 的 事 业 ， 将 危 地 马 拉 社 会 主 义 革 命 进 行 到 底 ” 。||新 政 府 全 面 平 反 了 十 年 之 春 与 哈 科 沃 · 阿 本 斯 总 统 ， 重 启 了 被 1 9 5 4 年 政 变 所 终 止 的 土 地 改 革 进 程 ， 废 除 一 切 不 平 等 条 约 ， 美 国 及 美 国 公 司 、 本 国 地 主 所 占 有 的 土 地 和 资 产 被 彻 底 剥 夺 ， 其 将 被 收 归 公 有 ， 土 地 也 将 再 分 配 给 无 地 或 少 地 的 玛 雅 农 民 。 军 政 府 对 印 第 安 人 犯 下 的 屠 杀 罪 行 被 清 算 ， 新 政 府 制 定 了 一 系 列 保 障 原 住 民 权 益 的 政 策 ， 以 消 除 种 族 主 义 ， 尊 重 土 著 人 民 的 组 织 和 文 化 形 式 。 一 本 讲 述 军 政 府 暴 行 下 基 切 玛 雅 人 遭 遇 的 书 籍 《 我 ， 里 戈 韦 塔 · 门 楚 》 也 得 以 出 版 。||内 战 结 束 后 的 危 地 马 拉 是 一 个 满 目 疮 痍 的 国 家 ， 不 仅 无 数 建 筑 与 设 施 被 破 坏 ， 军 政 府 还 留 下 了 天 价 的 债 务 ， 死 亡 、 失 踪 、 流 离 失 所 者 不 计 其 数 ， 在 我 们 与 古 巴 的 援 助 下 ， 危 地 马 拉 开 始 了 艰 难 的 战 后 重 建 工 作 。 而 美 国 则 向 军 政 府 的 残 余 力 量 提 供 了 资 金 、 训 练 、 装 备 、 武 装 和 组 织 ， 倚 仗 于 美 国 的 支 持 ， 一 个 由 旧 政 府 军 原 班 人 马 组 成 、 名 为 “ 危 地 马 拉 民 主 力 量 ” 的 右 翼 军 事 组 织 开 始 整 编 装 备 、 筹 划 补 给 、 招 募 人 力 ， 以 墨 西 哥 等 中 美 洲 专 制 政 权 和 伯 利 兹 为 基 地 对 危 地 马 拉 进 行 袭 击 。 ";
						GlobalScript.inst.gameState.allcountries[149].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[149].SubGosstroy = 2;
						GlobalScript.inst.gameState.allcountries[149].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[149].Torg = true;
						GlobalScript.inst.gameState.allcountries[149].proprc = true;
						influencePRC += 25;
						GlobalScript.inst.gameState.empires[0].power -= 25;
						GlobalScript.inst.gameState.empires[0].relations -= 100;
					}
					else if ((resultOfEvents[633] == 1 && modifies[6].active && modifies[3].active) || allcountries[1].isSEV)
					{
						text = "最 终 ， 危 地 马 拉 全 国 革 命 联 盟 取 得 了 内 战 的 胜 利 ， 红 旗 再 次 飘 扬 于 危 地 马 拉 城 中 。 新 政 府 由 P G T 总 书 记 里 卡 多 · 罗 萨 莱 斯 ， O R P A 的 罗 德 里 戈 · 阿 斯 图 里 亚 斯 ， E G P 的 罗 兰 多 · 莫 兰 指 挥 官 （ 里 卡 多 · 拉 米 雷 斯 ） 、 F A R 的 巴 勃 罗 · 孟 桑 托 指 挥 官 （ 豪 尔 赫 · 伊 斯 梅 尔 · 索 托 ） 所 组 成 的 四 人 领 导 机 构 共 同 领 导 。 联 盟 内 的 各 党 相 继 解 散 ， 彻 底 合 并 入 U R N G 。 流 亡 在 外 的 危 地 马 拉 劳 动 党 创 始 人 、 阿 本 斯 的 朋 友 何 塞 · 曼 努 埃 尔 · 福 图 尼 也 终 于 得 以 回 国 并 被 选 入 U R N G 政 治 局 。 在 危 地 马 拉 民 主 共 和 国 成 立 仪 式 上 ， 罗 萨 莱 斯 宣 布 将 “ 继 承 阿 本 斯 的 事 业 ， 将 危 地 马 拉 社 会 主 义 革 命 进 行 到 底 ” 。||新 政 府 全 面 平 反 了 十 年 之 春 与 哈 科 沃 · 阿 本 斯 总 统 ， 重 启 了 被 1 9 5 4 年 政 变 所 终 止 的 土 地 改 革 进 程 ， 废 除 一 切 不 平 等 条 约 ， 美 国 及 美 国 公 司 、 本 国 地 主 所 占 有 的 土 地 和 资 产 被 彻 底 剥 夺 ， 其 将 被 收 归 公 有 ， 土 地 也 将 再 分 配 给 无 地 或 少 地 的 玛 雅 农 民 。 军 政 府 对 印 第 安 人 犯 下 的 屠 杀 罪 行 被 清 算 ， 新 政 府 制 定 了 一 系 列 保 障 原 住 民 权 益 的 政 策 ， 以 消 除 种 族 主 义 ， 尊 重 土 著 人 民 的 组 织 和 文 化 形 式 。 一 本 讲 述 军 政 府 暴 行 下 基 切 玛 雅 人 遭 遇 的 书 籍 《 我 ， 里 戈 韦 塔 · 门 楚 》 也 得 以 出 版 。||内 战 结 束 后 的 危 地 马 拉 是 一 个 满 目 疮 痍 的 国 家 ， 不 仅 无 数 建 筑 与 设 施 被 破 坏 ， 军 政 府 还 留 下 了 天 价 的 债 务 ， 死 亡 、 失 踪 、 流 离 失 所 者 不 计 其 数 ， 在 苏 联 与 古 巴 的 援 助 下 ， 危 地 马 拉 开 始 了 艰 难 的 战 后 重 建 工 作 。 而 美 国 则 向 军 政 府 的 残 余 力 量 提 供 了 资 金 、 训 练 、 装 备 、 武 装 和 组 织 ， 倚 仗 于 美 国 的 支 持 ， 一 个 由 旧 政 府 军 原 班 人 马 组 成 、 名 为 “ 危 地 马 拉 民 主 力 量 ” 的 右 翼 军 事 组 织 开 始 整 编 装 备 、 筹 划 补 给 、 招 募 人 力 ， 以 墨 西 哥 等 中 美 洲 专 制 政 权 和 伯 利 兹 为 基 地 对 危 地 马 拉 进 行 袭 击 。 ";
						GlobalScript.inst.gameState.allcountries[149].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[149].SubGosstroy = 1;
						GlobalScript.inst.gameState.allcountries[149].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[149].prosov = true;
						GlobalScript.inst.gameState.empires[1].power += 25;
						GlobalScript.inst.gameState.empires[0].power -= 25;
						GlobalScript.inst.gameState.empires[0].relations -= 100;
					}
					else
					{
						text = "最 终 ， 危 地 马 拉 全 国 革 命 联 盟 取 得 了 内 战 的 胜 利 ， 红 旗 再 次 飘 扬 于 危 地 马 拉 城 中 。 新 政 府 由 P G T 总 书 记 里 卡 多 · 罗 萨 莱 斯 领 导 。 联 盟 内 的 各 党 相 继 解 散 ， 彻 底 合 并 入 U R N G ， 革 命 联 合 阵 线 （ F U R ） 、 危 地 马 拉 社 会 民 主 党 等 温 和 左 翼 政 党 也 被 吸 收 进 U R N G 。 在 新 政 府 成 立 仪 式 上 ， 罗 萨 莱 斯 宣 布 将 “ 继 承 阿 雷 瓦 洛 与 阿 本 斯 的 事 业 ， 将 危 地 马 拉 民 主 革 命 进 行 到 底 ” 。||为 了 防 止 美 国 的 敌 视 以 及 以 不 结 盟 的 态 度 换 取 来 自 国 际 社 会 各 方 面 的 援 助 ， 在 U R N G 的 新 一 版 党 章 中 并 未 提 及 马 列 主 义 相 关 的 字 眼 。 为 了 团 结 一 切 可 团 结 的 力 量 ， 新 政 府 将 资 产 阶 级 划 分 为 爱 国 资 产 阶 级 与 买 办 ， 后 者 的 资 产 将 被 剥 夺 ， 而 前 者 得 到 了 政 府 的 大 力 支 持 。 在 没 收 帝 国 主 义 与 地 主 在 该 国 资 产 的 同 时 ， 新 政 府 开 始 鼓 励 发 展 私 营 企 业 （ 尽 管 这 与 U R N G 大 部 分 成 员 所 坚 持 的 意 识 形 态 相 悖 ） 。||内 战 结 束 后 的 危 地 马 拉 是 一 个 满 目 疮 痍 的 国 家 ， 不 仅 无 数 建 筑 与 设 施 被 破 坏 ， 军 政 府 还 留 下 了 天 价 的 债 务 ， 死 亡 、 失 踪 、 流 离 失 所 者 不 计 其 数 ， 在 苏 联 与 古 巴 的 援 助 下 ， 危 地 马 拉 开 始 了 艰 难 的 战 后 重 建 工 作 。 而 美 国 则 向 军 政 府 的 残 余 力 量 提 供 了 资 金 、 训 练 、 装 备 、 武 装 和 组 织 ， 倚 仗 于 美 国 的 支 持 ， 一 个 由 旧 政 府 军 原 班 人 马 组 成 、 名 为 “ 危 地 马 拉 民 主 力 量 ” 的 右 翼 军 事 组 织 开 始 整 编 装 备 、 筹 划 补 给 、 招 募 人 力 ， 以 墨 西 哥 等 中 美 洲 专 制 政 权 和 伯 利 兹 为 基 地 对 危 地 马 拉 进 行 袭 击 。 ";
						GlobalScript.inst.gameState.allcountries[149].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[149].SubGosstroy = 3;
						GlobalScript.inst.gameState.allcountries[149].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[149].proprc = true;
						influencePRC += 25;
						GlobalScript.inst.gameState.empires[0].power -= 25;
						GlobalScript.inst.gameState.empires[0].relations -= 100;
					}
				}
				else
				{
					text = "毫 不 意 外 地 ， 在 美 国 的 全 力 干 涉 下 ， 军 政 府 还 是 挫 败 了 危 地 马 拉 全 国 革 命 联 盟 的 武 装 抵 抗 。 为 了 报 复 游 击 队 ， 军 队 在 镇 压 叛 乱 过 程 中 屠 杀 了 大 量 玛 雅 人 ， 大 量 的 良 田 和 房 屋 被 付 之 一 炬 。 尽 管 这 种 程 度 的 大 屠 杀 一 般 都 会 是 举 世 震 惊 的 大 新 闻 ， 但 没 有 人 会 在 意 世 界 霸 主 脚 下 的 平 凡 小 国 。 而 尽 管 遭 遇 如 此 惨 败 ， U R N G 的 残 余 部 分 还 是 再 次 在 全 国 各 地 集 结 起 来 ， 继 续 进 行 武 装 斗 争 。||“ 死 人 的 重 量 使 地 球 转 向 黑 夜 ， 而 活 人 的 重 量 又 使 地 球 转 向 黄 昏 … … 一 旦 死 人 多 于 活 人 ， 黑 夜 就 将 漫 长 无 边 ， 到 那 时 就 需 要 活 人 有 足 够 的 重 量 把 白 昼 重 新 拽 回 来 … … ” 至 少 现 在 ， 这 里 不 会 迎 来 黎 明 … …";
					GlobalScript.inst.gameState.allcountries[149].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[149].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[149].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[149].Vyshi = true;
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.empires[0].power += 25;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 65)
			{
				GlobalScript.inst.gameState.allcountries[149].parts[2] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = "事 实 证 明 ， 往 日 的 荣 耀 早 已 不 复 存 在 ， 如 今 的 英 国 不 过 是 一 只 借 着 旧 日 余 威 苟 延 残 喘 的 纸 老 虎 ， 连 危 地 马 拉 这 样 的 三 流 小 国 也 能 够 从 其 残 躯 上 撕 下 一 块 肉 来 。 在 战 争 爆 发 之 初 ， 危 地 马 拉 以 闪 电 战 突 袭 占 领 了 伯 利 兹 南 部 ， 渗 透 至 伯 利 兹 的 U R N G 成 员 和 中 美 洲 革 命 工 人 党 的 伯 利 兹 支 部 也 乘 机 发 动 游 行 、 罢 工 与 起 义 ， 在 双 方 的 里 应 外 合 下 ， 社 会 主 义 危 地 马 拉 轻 而 易 举 地 俘 虏 了 该 国 的 一 千 五 百 名 英 军 ， 并 摧 毁 了 “ 危 地 马 拉 民 主 力 量 ” 在 该 地 的 基 地 。 在 彻 底 占 领 伯 利 兹 全 境 后 ， 危 地 马 拉 便 在 当 地 推 行 了 一 系 列 社 会 主 义 改 造 ， 伯 利 兹 被 划 为 自 治 区 ， 外 国 公 司 与 银 行 被 收 归 国 有 ， 原 住 民 权 益 得 到 保 障 ， 链 接 该 地 区 的 铁 路 与 公 路 网 也 开 始 建 设 ， 尽 管 使 用 该 语 言 的 人 口 微 乎 其 微 ， 但 英 语 与 伯 利 兹 克 里 奥 尔 语 却 也 被 列 为 合 法 语 言 。";
					GlobalScript.inst.gameState.allcountries[149].parts[0] = true;
					GlobalScript.inst.gameState.influencePRC += 20;
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.empires[0].relations -= 50;
				}
				else
				{
					text = "出 乎 所 有 人 意 料 的 是 ， 尽 管 在 面 对 新 兴 的 拉 丁 美 洲 “ A B C 强 国 ” 阿 根 廷 时 一 败 涂 地 ， 但 就 算 是 瘦 死 的 骆 驼 也 依 旧 比 马 大 ， 英 国 还 是 成 功 抵 御 住 了 中 美 洲 的 新 生 社 会 主 义 国 家 对 伯 利 兹 的 进 犯 。 在 战 争 初 期 危 地 马 拉 以 闪 电 战 突 袭 占 领 了 伯 利 兹 南 部 ， 俘 虏 了 在 该 国 驻 扎 的 一 千 五 百 名 英 军 的 大 半 ， 然 而 很 快 ， 源 源 不 断 的 英 国 增 援 便 让 这 个 小 国 明 白 了 哪 怕 是 病 狮 也 不 是 他 们 能 轻 易 挑 衅 的 对 象 。 在 英 军 的 迎 头 痛 击 下 ， 自 不 量 力 者 得 到 了 他 们 应 有 的 结 局 ， 伯 利 兹 全 境 被 英 军 再 次 收 复 。 而 “ 危 地 马 拉 民 主 力 量 ” 则 趁 着 U R N G 战 败 的 西 风 迅 速 壮 大 了 起 来 ， 伯 利 兹 政 府 也 宣 布 同 危 地 马 拉 断 交 ， 承 认 流 亡 军 政 府 为 唯 一 合 法 政 府 并 同 “ 危 地 马 拉 民 主 力 量 ” 展 开 了 大 力 合 作 。";
					GlobalScript.inst.gameState.allcountries[149].level_of_unstab -= 50;
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.empires[0].power += 20;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 66)
			{
				GlobalScript.inst.gameState.allcountries[149].parts[2] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					if (!IsAuthoritarianism(149))
					{
						text = "事 实 证 明 ， 往 日 的 荣 耀 早 已 不 复 存 在 ， 如 今 的 英 国 不 过 是 一 只 借 着 旧 日 余 威 苟 延 残 喘 的 纸 老 虎 ， 连 危 地 马 拉 这 样 的 三 流 小 国 也 能 够 从 其 残 躯 上 撕 下 一 块 肉 来 。 在 战 争 爆 发 之 初 ， 危 地 马 拉 以 闪 电 战 突 袭 占 领 了 伯 利 兹 南 部 ， 渗 透 至 伯 利 兹 的 U R N G 成 员 和 中 美 洲 革 命 工 人 党 的 伯 利 兹 支 部 也 乘 机 发 动 游 行 、 罢 工 与 起 义 ， 在 双 方 的 里 应 外 合 下 ， 社 会 主 义 危 地 马 拉 轻 而 易 举 地 俘 虏 了 该 国 的 一 千 五 百 名 英 军 ， 并 摧 毁 了 “ 危 地 马 拉 民 主 力 量 ” 在 该 地 的 基 地 。 在 彻 底 占 领 伯 利 兹 全 境 后 ， 危 地 马 拉 便 在 当 地 推 行 了 一 系 列 社 会 主 义 改 造 ， 伯 利 兹 被 划 为 自 治 区 ， 外 国 公 司 与 银 行 被 收 归 国 有 ， 原 住 民 权 益 得 到 保 障 ， 链 接 该 地 区 的 铁 路 与 公 路 网 也 开 始 建 设 ， 尽 管 使 用 该 语 言 的 人 口 微 乎 其 微 ， 但 英 语 与 伯 利 兹 克 里 奥 尔 语 却 也 被 列 为 合 法 语 言 。";
						GlobalScript.inst.gameState.allcountries[149].parts[0] = true;
						GlobalScript.inst.gameState.influencePRC += 20;
						GlobalScript.inst.gameState.empires[0].power -= 20;
						GlobalScript.inst.gameState.empires[0].relations -= 50;
					}
					else
					{
						text = "事 实 证 明 ， 往 日 的 荣 耀 早 已 不 复 存 在 ， 如 今 的 英 国 不 过 是 一 只 借 着 旧 日 余 威 苟 延 残 喘 的 纸 老 虎 ， 连 危 地 马 拉 这 样 的 三 流 小 国 也 能 够 从 其 残 躯 上 撕 下 一 块 肉 来 。 在 战 争 爆 发 之 初 ， 危 地 马 拉 以 闪 电 战 突 袭 占 领 了 伯 利 兹 南 部 ， 俘 虏 了 该 国 的 一 千 五 百 名 英 军 ， 而 英 国 的 后 续 增 援 也 无 法 挽 回 败 局 。 很 快 ， 蓝 白 蓝 旗 帜 便 于 伯 利 兹 城 中 飘 扬 。 在 彻 底 占 领 伯 利 兹 全 境 后 ， 危 地 马 拉 便 迫 不 及 待 地 在 伯 利 兹 推 行 了 一 系 列 “ 危 地 马 拉 化 ” 的 政 策 ， 强 制 在 当 地 教 育 中 使 用 西 班 牙 语 ， 而 相 较 于 对 马 岛 居 民 秋 毫 无 犯 的 阿 根 廷 军 队 ， 危 地 马 拉 军 人 的 行 为 也 糟 糕 地 令 人 发 指 ， 大 半 居 民 的 家 中 被 劫 掠 一 空 ， 军 队 对 伯 利 兹 的 反 抗 者 也 不 吝 于 出 重 拳 ， 他 们 在 伯 利 兹 地 区 复 制 了 面 对 左 翼 游 击 队 所 使 用 的 “ 焦 土 ” 战 略 ， 被 认 定 为 游 击 队 或 游 击 队 同 情 者 的 人 被 分 开 、 遭 受 酷 刑 、 杀 害 或 “ 失 踪 ” ， 妇 女 遭 到 强 奸 ， 几 乎 所 有 男 子 都 被 迫 从 事 非 自 愿 劳 动 ， 印 第 安 人 与 黑 人 遭 到 屠 杀 ， 这 个 只 有 十 余 万 人 的 不 起 眼 地 区 在 短 短 数 天 之 内 就 出 现 了 多 达 四 位 数 的 伤 亡 。 古 巴 在 联 合 国 大 会 上 强 烈 谴 责 了 “ 危 地 马 拉 军 事 独 裁 政 权 对 主 权 国 家 的 侵 犯 ” ， 这 得 到 了 一 众 左 翼 政 权 与 大 半 个 拉 丁 美 洲 的 云 集 响 应 。 而 尽 管 危 地 马 拉 军 政 府 与 英 军 直 接 对 抗 的 举 措 最 初 遭 到 了 华 盛 顿 的 反 对 ， 但 最 后 ， 美 国 还 是 默 许 了 该 国 对 伯 利 兹 的 吞 并 。 再 次 败 北 于 自 己 所 蔑 视 的 拉 美 小 国 的 英 国 则 被 迫 咽 下 了 这 口 恶 气 ， 在 宣 传 中 淡 化 自 己 在 战 争 中 的 作 用 并 竭 力 避 免 国 内 媒 体 对 此 事 的 报 道 ， 那 么 现 在 来 看 … … 这 场 战 争 的 败 者 只 有 伯 利 兹 … … 对 吧 ？";
						GlobalScript.inst.gameState.allcountries[149].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[149].level_of_unstab -= 50;
						GlobalScript.inst.gameState.empires[0].power += 20;
					}
				}
				else if (!IsAuthoritarianism(149))
				{
					text = "出 乎 所 有 人 意 料 的 是 ， 尽 管 在 面 对 新 兴 的 拉 丁 美 洲 “ A B C 强 国 ” 阿 根 廷 时 一 败 涂 地 ， 但 就 算 是 瘦 死 的 骆 驼 也 依 旧 比 马 大 ， 英 国 还 是 成 功 抵 御 住 了 中 美 洲 的 新 生 社 会 主 义 国 家 对 伯 利 兹 的 进 犯 。 在 战 争 初 期 危 地 马 拉 以 闪 电 战 突 袭 占 领 了 伯 利 兹 南 部 ， 俘 虏 了 在 该 国 驻 扎 的 一 千 五 百 名 英 军 的 大 半 ， 然 而 很 快 ， 源 源 不 断 的 英 国 增 援 便 让 这 个 小 国 明 白 了 哪 怕 是 病 狮 也 不 是 他 们 能 轻 易 挑 衅 的 对 象 。 在 英 军 的 迎 头 痛 击 下 ， 自 不 量 力 者 得 到 了 他 们 应 有 的 结 局 ， 伯 利 兹 全 境 被 英 军 再 次 收 复 。 而 “ 危 地 马 拉 民 主 力 量 ” 则 趁 着 U R N G 战 败 的 西 风 迅 速 壮 大 了 起 来 ， 伯 利 兹 政 府 也 宣 布 同 危 地 马 拉 断 交 ， 承 认 流 亡 军 政 府 为 唯 一 合 法 政 府 并 同 “ 危 地 马 拉 民 主 力 量 ” 展 开 了 大 力 合 作 。";
					GlobalScript.inst.gameState.allcountries[149].level_of_unstab -= 50;
					GlobalScript.inst.gameState.influencePRC -= 20;
					GlobalScript.inst.gameState.empires[0].power += 20;
				}
				else
				{
					text = "出 乎 所 有 人 意 料 的 是 ， 尽 管 在 面 对 新 兴 的 拉 丁 美 洲 “ A B C 强 国 ” 阿 根 廷 时 一 败 涂 地 ， 但 就 算 是 瘦 死 的 骆 驼 也 依 旧 比 马 大 ， 英 国 还 是 成 功 抵 御 住 了 中 美 洲 的 小 小 香 蕉 共 和 国 对 伯 利 兹 的 进 犯 。 在 战 争 初 期 危 地 马 拉 以 闪 电 战 突 袭 占 领 了 伯 利 兹 南 部 ， 俘 虏 了 在 该 国 驻 扎 的 一 千 五 百 名 英 军 的 大 半 ， 然 而 很 快 ， 源 源 不 断 的 英 国 增 援 便 让 这 个 小 国 明 白 了 哪 怕 是 病 狮 也 不 是 他 们 能 轻 易 挑 衅 的 对 象 。 在 英 军 的 迎 头 痛 击 下 ， 自 不 量 力 者 得 到 了 他 们 应 有 的 结 局 ， 伯 利 兹 全 境 被 英 军 再 次 解 放 ， 那 些 将 义 务 兵 役 招 募 来 的 小 伙 子 们 送 上 战 场 的 刽 子 手 们 自 己 却 未 开 一 枪 就 顺 滑 的 签 署 了 投 降 书 。 军 政 府 的 颜 面 在 这 自 取 其 辱 的 大 败 前 丢 的 一 干 二 净 ， 而 美 国 也 对 危 地 马 拉 军 政 府 的 擅 自 行 动 怒 不 可 遏 ， 在 种 种 内 外 因 素 的 压 力 下 ， 里 奥 斯 · 蒙 特 将 军 很 快 就 宣 布 辞 去 总 统 职 务 。 而 继 任 的 温 贝 托 · 梅 希 亚 · 维 克 托 雷 斯 将 军 则 开 始 了 “ 民 主 化 ” 。 就 这 样 ， 在 内 战 、 普 遍 失 业 、 消 费 品 与 燃 料 短 缺 、 对 内 残 酷 屠 杀 导 致 的 国 际 孤 立 、 耻 辱 性 的 大 败 以 及 总 体 上 经 济 深 度 衰 退 的 所 有 症 状 的 气 氛 中 ， 民 族 解 放 运 动 的 莱 昂 内 尔 · 西 斯 涅 加 · 奥 特 洛 登 上 了 总 统 宝 座 。 历 经 三 十 年 的 独 裁 统 治 ， 危 地 马 拉 人 民 终 于 迎 来 了 自 由 的 曙 光 … … 吗 ？||纵 使 自 由 民 主 的 假 面 也 无 法 掩 盖 民 族 解 放 运 动 党 — — 这 个 由 推 翻 了 阿 本 斯 政 府 的 卡 斯 蒂 略 · 阿 马 斯 所 创 建 、 几 十 年 来 一 直 作 为 军 事 独 裁 政 权 核 心 力 量 之 一 的 政 党 的 真 面 目 。 而 新 总 统 虽 然 打 着 民 主 的 旗 号 ， 但 他 的 统 治 却 依 旧 换 汤 不 换 药 ， 不 仅 依 然 大 力 进 行 与 “ 颠 覆 分 子 ” 的 作 战 ， 对 军 事 独 裁 期 间 政 府 罪 行 的 一 切 调 查 被 禁 止 开 展 ， 军 人 集 团 也 仍 然 在 幕 后 操 盘 。";
					GlobalScript.inst.gameState.allcountries[149].Gosstroy = 3;
					GlobalScript.inst.gameState.allcountries[149].SubGosstroy = 12;
					GlobalScript.inst.gameState.empires[0].power -= 20;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 67)
			{
				GlobalScript.inst.gameState.allcountries[147].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
				{
					text = "在 短 短 数 年 之 后 ， 尼 加 拉 瓜 又 迎 来 了 一 次 政 权 更 迭 。 不 过 这 次 ， 胜 利 者 不 是 桑 地 诺 主 义 者 ， 而 是 又 一 个 索 摩 查 。||经 过 漫 长 而 残 酷 的 内 战 ， 前 国 民 警 卫 队 组 成 的 尼 加 拉 瓜 民 主 力 量 （FDN ） 与 桑 地 诺 革 命 事 业 的 背 叛 者 伊 登 · 帕 斯 托 拉 领 导 的 民 主 革 命 联 盟 （ARDE ） 这 两 支 反 对 派 武 装 分 别 从 洪 都 拉 斯 和 哥 斯 达 黎 加 一 南 一 北 攻 陷 了 马 那 瓜 ，FSLN 被 迫 撤 出 了 首 都 ， 再 次 转 移 到 山 区 进 行 游 击 战 ， 康 特 拉 （contras ， 意 为 “ 反 革 命 ” ） 最 终 取 得 了 胜 利 。 在 推 翻 桑 解 阵 后 的 首 次 大 选 中 ， 阿 道 夫 · 卡 列 罗 成 为 了 新 总 统 ， 查 莫 罗 夫 人 成 为 总 理 ， 帕 斯 托 拉 被 任 命 为 副 总 统 ， 但 政 府 最 高 权 力 实 际 掌 握 在 武 装 部 队 总 司 令 恩 里 克 · 贝 穆 德 斯 · 巴 雷 拉 手 中 。 新 政 府 一 上 任 便 开 始 了 对 桑 地 诺 人 民 革 命 的 清 算 。 桑 解 阵 所 分 配 给 无 地 贫 民 和 工 人 的 土 地 与 资 产 被 寡 头 瓜 分 ， 国 有 产 业 再 次 被 私 有 化 ， 金 吉 达 公 司 （ 前 联 合 果 品 ） 、 美 孚 石 油 公 司 等 美 国 公 司 再 次 入 驻 尼 加 拉 瓜 ， 大 量 桑 地 诺 主 义 支 持 者 及 其 同 情 者 被 逮 捕 入 狱 。 作 为 “ 战 后 重 建 工 作 ” 的 一 部 分 ， 新 政 府 延 续 了 康 特 拉 进 行 的 军 火 走 私 与 毒 品 生 意 ， 并 在CIA 的 帮 助 下 与 哥 伦 比 亚 的 麦 德 林 帮 等 知 名 贩 毒 集 团 达 成 了 合 作 ， 来 自 哥 伦 比 亚 的 毒 品 将 经 尼 加 拉 瓜 中 转 ， 再 经 过 数 个 国 家 ， 最 终 流 通 至 美 国 。 尽 管 新 政 府 内 部 对 此 意 见 不 一 致 ， 但 在 尼 加 拉 瓜 民 主 力 量 的 推 动 下 ， 小 索 摩 查 的 儿 子 、 流 亡 在 外 的 阿 纳 斯 塔 西 奥 · 赫 苏 斯 · 索 摩 查 也 得 以 凯 旋 归 国 。||又 一 次 ， 自 由 的 祖 国 匍 匐 于 威 廉 · 沃 克 身 下 ， 又 一 次 ， 桑 地 诺 亡 于 索 摩 查 之 手 ， 又 一 次 ， 尼 加 拉 瓜 的 星 星 之 火 被 帝 国 主 义 掐 灭 … …";
					GlobalScript.inst.gameState.allcountries[147].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[147].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[147].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[147].Vyshi = true;
					GlobalScript.inst.gameState.empires[0].power += 20;
					GlobalScript.inst.gameState.influencePRC -= 50;
					GlobalScript.inst.gameState.allcountries[147].level_of_unstab -= 300;
				}
				else
				{
					text = "胜 利 又 一 次 眷 顾 了 桑 地 诺 主 义 者 。||尽 管 康 特 拉 （contras ， 意 为 “ 反 革 命 ” ） 差 点 逼 近 首 都 马 那 瓜 ， 但 桑 地 诺 人 民 军 还 是 成 功 粉 碎 了 前 国 民 警 卫 队 组 成 的 尼 加 拉 瓜 民 主 力 量 （FDN ） 与 桑 地 诺 革 命 事 业 的 背 叛 者 伊 登 · 帕 斯 托 拉 领 导 的 民 主 革 命 联 盟 （ARDE ） 这 两 支 反 对 派 武 装 ， 将 这 些 分 别 从 南 北 两 个 方 向 向 马 那 瓜 逼 近 的 反 革 命 们 赶 回 了 洪 都 拉 斯 与 哥 斯 达 黎 加 。";
					GlobalScript.inst.gameState.empires[0].power -= 20;
					GlobalScript.inst.gameState.influencePRC += 20;
					GlobalScript.inst.gameState.allcountries[147].level_of_unstab += 300;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 68)
			{
				GlobalScript.inst.gameState.allcountries[123].parts[0] = false;
				GlobalScript.inst.gameState.allcountries[123].cw = true;
				if (GlobalScript.inst.gameState.allcountries[123].prcpower == 1000 && GlobalScript.inst.gameState.allcountries[123].usapower == 0 && GlobalScript.inst.gameState.allcountries[123].sovpower == 0)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 最 后 的 安 哥 拉 叛 军 决 定 向 安 人 运 政 府 投 降 。 罗 安 达 的 政 府 彻 底 确 定 了 该 国 的 稳 定 。 尽 管 从 一 场 堪 称 浩 劫 的 战 争 中 恢 复 过 来 需 要 很 长 的 时 间 ， 但 安 哥 拉 一 定 能 挺 过 去 的 。";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						if (allcountries[123].prosov)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 16;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].prosov = true;
							GlobalScript.inst.gameState.empires[1].power += 20;
							GlobalScript.inst.gameState.influencePRC += 10;
						}
						else if (GlobalScript.inst.gameState.allcountries[123].SubGosstroy == 17)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 17;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.influencePRC += 30;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.influencePRC += 30;
						}
						if (resultOfEvents[638] == 0)
						{
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
						}
					}
					else
					{
						text = "在 罗 安 达 被 攻 克 后 ， 原 先 还 能 团 结 一 致 的 争 取 安 哥 拉 彻 底 解 放 同 盟 和 安 哥 拉 民 族 解 放 阵 线 并 没 能 就 和 平 解 决 问 题 达 成 一 致 。 一 方 的 扫 地 出 局 并 不 意 味 着 长 久 的 和 平 。";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 1000;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 1000;
						ingamewars[68] = new War().Name("安 哥 拉 内 战").Attacker("安 解 阵").Defender("安 盟")
							.AttackerInfluence(600)
							.DefenderInfluence(400)
							.AmericanSupportAttacker.AmericanSupportDefender.CreateWar;
						GlobalScript.inst.gameState.allcountries[123].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[123].cw = false;
					}
				}
				if (GlobalScript.inst.gameState.allcountries[123].sovpower == 1000 && GlobalScript.inst.gameState.allcountries[123].usapower == 0 && GlobalScript.inst.gameState.allcountries[123].prcpower == 0)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 最 后 的 守 军 决 定 向 安 盟 投 降 ， 时 隔 数 年 后 萨 文 比 再 次 回 到 了 罗 安 达 。 古 巴 驻 军 则 搭 上 了 最 后 一 班 回 国 的 渡 轮 ， 离 开 了 他 们 为 之 奋 战 的 土 地 。 新 政 府 由 “ 不 屈 的 自 由 斗 士 ” 所 领 导 ， 但 全 国 的 大 街 小 巷 都 传 来 了 各 类 暴 行 和 针 对 “ 红 人 ” 的 报 复 。 " + (IsAuthoritarianism(131) ? "南 非 驻 军 也 被 邀 请 进 入 该 国 维 持 治 安 。" : null) + "很 难 说 这 算 不 算 是 自 由 … …";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						GlobalScript.inst.gameState.allcountries[123].name = "安 哥 拉 民 主 人 民 共 和 国";
						if (resultOfEvents[638] == 1)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 0;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 10;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
							GlobalScript.inst.gameState.empires[0].power += 20;
							GlobalScript.inst.gameState.influencePRC += 10;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 0;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 7;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].Vyshi = true;
							if (IsAuthoritarianism(131))
							{
								GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
								GlobalScript.inst.gameState.allcountries[123].puppetOf = 131;
								GlobalScript.inst.gameState.empires[0].power += 20;
								GlobalScript.inst.gameState.influencePRC += 10;
							}
						}
					}
					else
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 最 后 的 安 哥 拉 叛 军 决 定 向 安 人 运 政 府 投 降 。 罗 安 达 的 政 府 彻 底 确 定 了 该 国 的 稳 定 。 尽 管 从 一 场 堪 称 浩 劫 的 战 争 中 恢 复 过 来 需 要 很 长 的 时 间 ， 但 安 哥 拉 一 定 能 挺 过 去 的 。";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						if (allcountries[123].prosov)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 16;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].prosov = true;
							GlobalScript.inst.gameState.empires[1].power += 20;
							GlobalScript.inst.gameState.influencePRC += 10;
						}
						else if (GlobalScript.inst.gameState.allcountries[123].SubGosstroy == 17)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 17;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.influencePRC += 30;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.influencePRC += 30;
						}
						if (resultOfEvents[638] == 0)
						{
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
						}
					}
				}
				if (GlobalScript.inst.gameState.allcountries[123].usapower == 1000 && GlobalScript.inst.gameState.allcountries[123].sovpower == 0 && GlobalScript.inst.gameState.allcountries[123].prcpower == 0)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 罗 伯 托 的 安 解 阵 给 全 世 界 观 察 家 们 上 了 一 课 。 几 乎 没 有 什 么 国 家 承 认 新 政 府 ， 而 原 政 府 的 高 官 也 已 流 亡 墨 西 哥 。 希 望 他 们 能 带 来 稳 定 吧 … …";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						GlobalScript.inst.gameState.allcountries[123].name = "安 哥 拉 共 和 国";
						GlobalScript.inst.gameState.allcountries[123].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 8;
						GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
						if (resultOfEvents[638] == 2)
						{
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
						}
						GlobalScript.inst.gameState.empires[0].power += 20;
						GlobalScript.inst.gameState.influencePRC += 10;
					}
					else
					{
						text = "在 安 解 阵 出 局 后 ， 原 先 还 能 团 结 一 致 安 哥 拉 政 府 军 和 安 哥 拉 彻 底 解 放 同 盟 并 没 能 就 和 平 解 决 问 题 达 成 一 致 。 一 方 的 扫 地 出 局 并 不 意 味 着 长 久 的 和 平 。";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 1000;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 1000;
						ingamewars[68] = new War().Name("安 哥 拉 内 战").Attacker("安 人 运").Defender("安 盟")
							.AttackerInfluence(600)
							.DefenderInfluence(400)
							.SovietSupportAttacker.AmericanSupportDefender.CreateWar;
						GlobalScript.inst.gameState.allcountries[123].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[123].cw = false;
					}
				}
				if (GlobalScript.inst.gameState.allcountries[123].usapower == 1000 && GlobalScript.inst.gameState.allcountries[123].sovpower == 1000 && GlobalScript.inst.gameState.allcountries[123].prcpower == 0)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 罗 伯 托 的 安 解 阵 给 全 世 界 观 察 家 们 上 了 一 课 。 几 乎 没 有 什 么 国 家 承 认 新 政 府 ， 而 原 政 府 的 高 官 也 已 流 亡 墨 西 哥 。 希 望 他 们 能 带 来 稳 定 吧 … …";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						GlobalScript.inst.gameState.allcountries[123].name = "安 哥 拉 共 和 国";
						GlobalScript.inst.gameState.allcountries[123].Gosstroy = 2;
						GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 8;
						GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
						if (resultOfEvents[638] == 2)
						{
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
						}
						GlobalScript.inst.gameState.empires[0].power += 20;
						GlobalScript.inst.gameState.influencePRC += 10;
					}
					else
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 最 后 的 守 军 决 定 向 安 盟 投 降 ， 时 隔 数 年 后 萨 文 比 再 次 回 到 了 罗 安 达 。 古 巴 驻 军 则 搭 上 了 最 后 一 班 回 国 的 渡 轮 ， 离 开 了 他 们 为 之 奋 战 的 土 地 。 新 政 府 由 “ 不 屈 的 自 由 斗 士 ” 所 领 导 ， 但 全 国 的 大 街 小 巷 都 传 来 了 各 类 暴 行 和 针 对 “ 红 人 ” 的 报 复 。 " + (IsAuthoritarianism(131) ? "南 非 驻 军 也 被 邀 请 进 入 该 国 维 持 治 安 。" : null) + "很 难 说 这 算 不 算 是 自 由 … …";
						GlobalScript.inst.gameState.allcountries[123].name = "安 哥 拉 民 主 主 义 人 民 共 和 国";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						if (resultOfEvents[638] == 1)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 0;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 10;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.empires[0].power += 20;
							GlobalScript.inst.gameState.influencePRC += 10;
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 0;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 7;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].Vyshi = true;
							if (IsAuthoritarianism(131))
							{
								GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
								GlobalScript.inst.gameState.allcountries[123].puppetOf = 131;
								GlobalScript.inst.gameState.empires[0].power += 20;
								GlobalScript.inst.gameState.influencePRC += 10;
							}
						}
					}
				}
				if (GlobalScript.inst.gameState.allcountries[123].usapower == 0 && GlobalScript.inst.gameState.allcountries[123].sovpower == 1000 && GlobalScript.inst.gameState.allcountries[123].prcpower == 1000)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 850)
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 最 后 的 安 哥 拉 叛 军 决 定 向 安 人 运 政 府 投 降 。 罗 安 达 的 政 府 彻 底 确 定 了 该 国 的 稳 定 。 尽 管 从 一 场 堪 称 浩 劫 的 战 争 中 恢 复 过 来 需 要 很 长 的 时 间 ， 但 安 哥 拉 一 定 能 挺 过 去 的 。";
						GlobalScript.inst.gameState.allcountries[123].name = "安 哥 拉";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						if (allcountries[123].prosov)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 16;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].prosov = true;
							GlobalScript.inst.gameState.empires[1].power += 20;
							GlobalScript.inst.gameState.influencePRC += 10;
						}
						else if (GlobalScript.inst.gameState.allcountries[123].SubGosstroy == 17)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 17;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.influencePRC += 30;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 1;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.influencePRC += 30;
						}
						if (resultOfEvents[638] == 0)
						{
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
						}
					}
					else
					{
						text = "在 数 万 人 流 离 失 所 ， 成 千 上 万 的 地 雷 被 埋 下 ， 无 数 个 父 亲 ， 儿 子 ， 兄 长 ， 胞 弟 死 在 同 胞 的 枪 口 下 后 ， 最 后 的 守 军 决 定 向 安 盟 投 降 ， 时 隔 数 年 后 萨 文 比 再 次 回 到 了 罗 安 达 。 古 巴 驻 军 则 搭 上 了 最 后 一 班 回 国 的 渡 轮 ， 离 开 了 他 们 为 之 奋 战 的 土 地 。 新 政 府 由 “ 不 屈 的 自 由 斗 士 ” 所 领 导 ， 但 全 国 的 大 街 小 巷 都 传 来 了 各 类 暴 行 和 针 对 “ 红 人 ” 的 报 复 。 " + (IsAuthoritarianism(131) ? "南 非 驻 军 也 被 邀 请 进 入 该 国 维 持 治 安 。" : null) + "很 难 说 这 算 不 算 是 自 由 … …";
						GlobalScript.inst.gameState.allcountries[123].name = "安 哥 拉 民 主 主 义 人 民 共 和 国";
						GlobalScript.inst.gameState.allcountries[123].prcpower = 0;
						GlobalScript.inst.gameState.allcountries[123].usapower = 0;
						GlobalScript.inst.gameState.allcountries[123].sovpower = 0;
						if (resultOfEvents[638] == 1)
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 0;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 10;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].proprc = true;
							GlobalScript.inst.gameState.empires[0].power += 20;
							GlobalScript.inst.gameState.influencePRC += 10;
							GlobalScript.inst.gameState.allcountries[123].Torg = true;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[123].Gosstroy = 0;
							GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 7;
							GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
							GlobalScript.inst.gameState.allcountries[123].Vyshi = true;
							if (IsAuthoritarianism(131))
							{
								GlobalScript.inst.gameState.allcountries[123].LeaveAlliances();
								GlobalScript.inst.gameState.allcountries[123].puppetOf = 131;
								GlobalScript.inst.gameState.empires[0].power += 20;
								GlobalScript.inst.gameState.influencePRC += 10;
							}
						}
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 69)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "毫 不 意 外 的 ， 中 国 人 民 解 放 军 击 溃 了 负 隅 顽 抗 的 蒙 古 军 队 和 他 们 的 苏 联 盟 友 与 古 巴 雇 佣 兵 。 在 付 出 了 数 万 人 和 数 百 辆 各 式 车 辆 的 代 价 后 ， 苏 联 宣 布 从 蒙 古 撤 离 。 伪 蒙 古 人 民 共 和 国 也 向 我 们 表 达 了 投 降 的 意 愿 ， 而 伪 蒙 古 人 民 革 命 党 中 央 委 员 逃 往 了 苏 联 并 组 建 了 流 亡 政 府 。 中 华 人 民 共 和 国 并 不 急 于 吞 并 蒙 古 ， 在 宣 布 伪 蒙 古 人 民 革 命 党 的 解 散 后 。 中 共 的 蒙 古 族 党 员 和 前 伪 蒙 古 人 民 革 命 党 中 对 中 国 保 持 积 极 态 度 的 党 员 组 建 了 蒙 古 民 族 团 结 阵 线 。 由 达 拉 姆 · 图 木 尔 奥 其 尔 出 任 “ 新 蒙 古 ” 的 “ 总 理 ” ， 社 会 治 安 则 由 驻 蒙 人 民 解 放 军 和 调 入 的 公 安 联 合 组 成 的 特 别 治 安 指 挥 部 负 责 。 在 沙 漠 与 山 区 中 仍 然 有 伪 政 府 的 效 忠 者 在 负 隅 顽 抗 ， 但 英 勇 的 人 民 解 放 军 将 彻 底 粉 碎 分 裂 势 力 。||超 级 大 国 谴 责 我 们 对 蒙 古 的 悍 然 入 侵 ， 只 有 我 们 的 盟 友 和 墨 西 哥 这 样 的 国 家 愿 意 承 认 新 政 权 。";
					GlobalScript.inst.gameState.allcountries[9].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[9].Gosstroy = GlobalScript.inst.gameState.allcountries[1].Gosstroy;
					GlobalScript.inst.gameState.allcountries[9].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
					GlobalScript.inst.gameState.allcountries[9].puppetOf = 1;
					GlobalScript.inst.gameState.allcountries[9].proprc = true;
					GlobalScript.inst.gameState.allcountries[9].Torg = true;
					GlobalScript.inst.gameState.allcountries[9].JoinAllOurAlliances(yes: true);
					GlobalScript.inst.gameState.allcountries[9].name = "蒙 古 占 领 区";
					GlobalScript.inst.gameState.data[1] += 300;
					GlobalScript.inst.gameState.data[3] += 300;
					GlobalScript.inst.gameState.data[4] -= 300;
					GlobalScript.inst.gameState.empires[1].power -= 100;
					GlobalScript.inst.gameState.empires[1].relations -= 1000;
					GlobalScript.inst.gameState.influencePRC += 100;
				}
				else
				{
					text = "出 乎 我 们 的 意 料 ， 孱 弱 的 蒙 古 军 队 设 法 逼 退 了 中 国 人 民 解 放 军 。 由 于 战 争 初 期 的 失 误 指 挥 ， 我 们 的 先 遣 部 队 在 乌 兰 巴 托 残 酷 的 巷 战 中 损 失 惨 痛 。 而 蒙 古 民 众 也 并 不 相 信 我 们 能 为 他 们 带 来 解 放 。 纷 纷 拿 起 苏 制 装 备 躲 进 山 区 里 ， 或 是 骑 在 马 上 把 我 们 的 巡 逻 队 员 绞 杀 至 死 。 极 端 民 族 主 义 组 织 “ 白 色 十 字 ” 甚 至 成 功 的 暗 杀 了 我 们 指 挥 对 蒙 作 战 的 军 事 首 长 。 苏 联 以 自 愿 报 名 为 由 派 遣 了 成 建 制 的 “ 志 愿 军 ” ， 古 巴 和 法 国 的 雇 佣 兵 也 通 过 苏 联 来 到 蒙 古 ， 在 各 个 地 方 运 用 他 们 在 非 洲 学 到 的 知 识 ， 打 击 我 们 的 战 士 。 在 惨 痛 的 绞 肉 战 后 ， 这 场 军 事 冒 险 在 丢 下 几 万 具 尸 体 后 惨 败 收 场 。 最 耻 辱 的 莫 过 于 蒙 古 甚 至 设 法 攻 克 了 二 连 浩 特 ， 当 着 我 们 全 体 电 视 观 众 的 面 把 我 们 的 国 旗 扯 下 并 点 燃 。 在 各 国 的 斡 旋 和 美 国 的 武 力 威 胁 下 ， 我 们 只 得 灰 溜 溜 的 撤 出 蒙 古 。 蒙 古 政 府 把 这 次 胜 利 比 做 二 十 一 世 纪 的 土 木 堡 之 战 。 他 们 增 加 了 军 费 ， 甚 至 采 购 了 导 弹 。 等 等 ， 门 口 的 敲 门 声 是 ？";
					GlobalScript.inst.gameState.data[1] -= 1000;
					GlobalScript.inst.gameState.data[3] -= 1000;
					GlobalScript.inst.gameState.influencePRC -= 200;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 70)
			{
				if (!event_done[642])
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
					{
						text = "拥 有 珍 宝 岛 之 战 的 系 列 经 验 ， 胜 利 是 注 定 的 。 苏 修 部 队 光 是 应 付 我 战 无 不 胜 的 人 民 军 队 便 已 分 身 乏 术 ， 更 不 必 谈 各 地 盟 友 的 四 面 夹 击 。 苏 联 远 东 舰 队 甚 至 还 未 出 港 便 被 人 民 解 放 军 轻 易 歼 灭 ， 我 陆 军 雄 赳 赳 气 昂 昂 越 过 了 黑 龙 江 ， 迅 速 瓦 解 了 海 参 崴 ， 海 兰 泡 和 伯 力 等 地 顽 抗 的 苏 军 。 中 亚 方 面 的 作 战 也 相 当 顺 利 ： 苏 军 抛 下 数 百 辆 坦 克 残 骸 后 退 到 了 巴 尔 喀 什 湖 以 西 ， 我 军 甚 至 在 混 战 内 活 捉 了 哈 萨 克 现 任 领 导 人 根 纳 季 · 科 尔 宾 ， 从 而 基 本 摧 毁 了 苏 联 在 中 亚 的 领 导 班 底 。 出 于 遏 制 我 方 在 远 东 胜 利 进 军 的 需 要 ， 心 惊 胆 战 的 苏 军 甚 至 炸 毁 了 西 伯 利 亚 大 铁 路 ， 并 将 防 线 收 缩 至 赤 塔 和 新 西 伯 利 亚 一 带 。 然 而 ， 这 无 法 改 变 苏 联 战 败 的 基 本 定 局 ： 随 着 我 军 兵 临 斯 维 尔 德 洛 夫 斯 克 ， 该 国 领 导 层 不 得 不 咬 牙 坐 上 谈 判 桌 ， 并 以 “ 列 宁 签 署 布 列 斯 特 和 约 ” 的 气 魄 同 我 们 彻 底 解 决 了 历 史 遗 留 问 题 ： 《 哈 尔 滨 和 约 》 与 其 附 件 《 再 勘 中 苏 边 界 条 约 》 规 定 外 东 北 、 外 西 北 ， 唐 努 乌 梁 海 和 阿 尔 泰 卓 尔 乌 梁 海 地 区 复 归 我 国 ； 日 本 重 新 接 管 了 去 军 事 化 的 北 方 四 岛 ； 伊 朗 与 阿 富 汗 将 接 受 苏 联 拨 付 的 战 争 赔 款 ； 贝 加 尔 湖 沿 岸 与 布 里 亚 特 蒙 古 人 的 聚 居 地 成 为 双 方 共 管 区 ， 并 在 5 0 年 后 以 公 投 定 归 属 ； 苏 联 残 存 的 中 亚 地 区 则 因 原 建 制 崩 溃 而 事 实 上 成 为 了 中 苏 共 同 施 加 影 响 力 的 “ 中 立 区 ” 与 国 中 之 国 。 可 雅 科 夫 列 夫 决 定 抛 弃 “ 落 后 亚 洲 ” 以 保 全 “ 先 进 欧 洲 ” 的 政 策 并 没 能 给 他 带 来 缓 冲 期 ： 不 久 后 ， 苏 联 原 政 府 便 因 耻 辱 性 的 大 败 而 彻 底 垮 台 ， 被 新 一 代 军 事 政 府 取 而 代 之 。 意 识 到 北 大 西 洋 联 盟 在 保 障 苏 联 利 益 上 一 无 是 处 ， 苏 联 在 宣 布 《 哈 尔 滨 和 约 》 非 法 的 同 时 脱 离 了 大 西 洋 主 义 体 系 ， 重 新 走 上 了 依 靠 自 身 力 量 重 整 军 备 ， 预 备 复 仇 的 道 路 。 古 怪 的 苏 美 联 合 反 华 协 定 就 这 样 以 同 样 古 怪 的 方 式 解 体 了 。 不 过 现 在 ， 还 是 先 为 胜 利 而 欢 呼 罢 ！";
						GlobalScript.inst.gameState.is_gkchp = true;
						GlobalScript.inst.gameState.allcountries[1].ILoveSuckCocks();
						allcountries[7].Gosstroy = 0;
						allcountries[7].SubGosstroy = 10;
						allcountries[7].LeaveEU();
						allcountries[7].LeaveNATO();
						for (int num10 = 0; num10 < GlobalScript.inst.gameState.allcountries.Length; num10++)
						{
							if (GlobalScript.inst.gameState.allcountries[num10].prosov)
							{
								GlobalScript.inst.gameState.allcountries[num10].LeaveEU();
								GlobalScript.inst.gameState.allcountries[num10].LeaveNATO();
							}
						}
						GlobalScript.inst.gameState.data[1] += 500;
						GlobalScript.inst.gameState.data[3] += 500;
						GlobalScript.inst.gameState.data[4] -= 500;
						GlobalScript.inst.gameState.data[34] += 180;
						GlobalScript.inst.gameState.empires[1].power -= 500;
						GlobalScript.inst.gameState.empires[1].relations -= 1000;
						GlobalScript.inst.gameState.empires[0].power -= 250;
						GlobalScript.inst.gameState.empires[0].relations = 0;
						GlobalScript.inst.gameState.influencePRC += 250;
					}
					else
					{
						text = "苏 联 通 过 背 靠 北 约 盟 友 ， 将 亚 洲 大 战 变 为 了 不 亚 于 日 俄 战 争 的 残 酷 绞 肉 机 。 虽 然 我 们 的 海 军 得 以 封 锁 库 页 岛 ， 并 将 苏 联 的 海 军 困 死 在 港 口 内 ； 但 我 们 的 陆 军 并 没 能 在 各 个 方 面 取 得 进 展 ， 他 们 只 能 困 守 海 参 崴 和 伯 力 。 此 后 ， 苏 联 人 更 是 借 助 美 方 导 弹 平 台 轰 炸 我 核 心 工 业 区 与 关 键 城 市 ， 甚 至 让 北 京 也 陷 入 威 胁 当 中 。 在 付 出 数 十 万 人 的 伤 亡 后 ， 我 们 不 得 不 回 到 谈 判 桌 上 同 苏 联 达 成 妥 协 ， 而 作 为 战 争 的 发 起 者 的 你 定 没 有 好 下 场 … …";
						GlobalScript.inst.gameState.data[1] = 0;
						GlobalScript.inst.gameState.data[3] = 0;
						GlobalScript.inst.gameState.influencePRC -= 200;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "恰 如 珍 宝 岛 之 战 时 的 情 况 ， 苏 修 腐 化 的 军 队 绝 不 是 我 们 战 无 不 胜 的 人 民 军 队 的 对 手 。 我 们 的 军 队 轻 而 易 举 地 便 横 扫 了 北 境 。 苏 军 不 得 不 撤 往 赤 塔 和 新 西 伯 利 亚 构 筑 防 线 。 见 到 我 们 使 用 西 伯 利 亚 大 铁 路 运 输 军 队 后 ， 他 们 甚 至 炸 毁 了 这 条 西 伯 利 亚 的 大 动 脉 ， 但 我 们 的 铁 道 兵 用 生 命 迅 速 修 复 了 这 条 至 关 重 要 的 运 兵 线 。 最 终 ， 当 我 们 已 经 兵 临 斯 维 尔 德 洛 夫 斯 克 时 ， 苏 联 也 不 得 不 咬 着 牙 和 我 们 坐 到 谈 判 桌 上 。 最 终 ， 他 们 被 迫 交 还 外 东 北 、 外 西 北 和 唐 努 乌 梁 海 地 区 ， 蒙 古 也 成 为 了 我 国 的 一 部 分 ， 而 贝 加 尔 湖 沿 岸 则 成 立 双 方 共 管 区 ，50 年 后 公 投 决 定 归 属 。 有 意 思 的 是 ， 蒙 古 国 代 表 甚 至 没 能 坐 上 谈 判 桌 ， 一 如 二 战 前 的 捷 克 斯 洛 伐 克 。 苏 联 在 中 亚 的 几 个 加 盟 共 和 国 失 去 了 大 量 的 精 华 部 分 ， 但 这 与 我 们 又 有 何 干 呢 ？ 苏 联 耻 辱 性 的 大 败 使 得 该 国 激 烈 的 右 转 ， 一 场 军 事 政 变 发 生 了 。但 谁 在 乎 呢 ？ 至 少 我 们 拿 回 了 本 该 属 于 我 们 的 东 西 ！";
					GlobalScript.inst.gameState.IndOpp = true;
					GlobalScript.inst.gameState.allcountries[1].ILoveSuckCocks();
					allcountries[9].LeaveAlliances();
					allcountries[7].Gosstroy = 2;
					allcountries[7].SubGosstroy = 15;
					GlobalScript.inst.gameState.data[130] = 1;
					GlobalScript.inst.gameState.data[1] += 500;
					GlobalScript.inst.gameState.data[3] += 500;
					GlobalScript.inst.gameState.data[4] -= 500;
					GlobalScript.inst.gameState.data[34] += 180;
					GlobalScript.inst.gameState.empires[1].power -= 500;
					GlobalScript.inst.gameState.empires[1].relations -= 1000;
					GlobalScript.inst.gameState.empires[0].relations -= 300;
					GlobalScript.inst.gameState.influencePRC += 250;
					completedDecisions[37] = true;
				}
				else
				{
					text = "对 苏 军 事 行 动 以 失 败 告 终 ， 苏 联 军 队 摧 枯 拉 朽 地 攻 入 中 国 境 内 ， 没 过 几 日 便 到 了 北 京 城 下 ， 你 试 图 对 苏 议 和 但 遭 到 拒 绝 。 见 苏 联 一 定 要 将 你 拉 出 去 审 判 ， 气 急 败 坏 的 你 翻 出 了 发 射 原 子 弹 的 红 色 按 钮 。 当 你 按 下 之 后 ， 核 大 战 便 爆 发 了 … …";
					GlobalScript.inst.gameState.data[1] = 0;
					GlobalScript.inst.gameState.data[3] = 0;
					GlobalScript.inst.gameState.influencePRC -= 200;
					GlobalScript.inst.gameState.data[35] = 12;
					SceneManager.LoadScene("Ending");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 71)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "我 们 的 三 线 作 战 最 终 大 获 全 胜 ： 伪 印 支 联 邦 的 军 队 根 本 无 法 承 受 来 自 我 们 的 压 力 ， 很 快 便 被 我 们 打 得 丢 盔 弃 甲 。 几 乎 不 费 吹 灰 之 力 ， 我 们 就 将 战 线 推 至 河 内 和 胡 志 明 市 城 下 。 经 过 不 长 的 攻 坚 战 后 ， 越 南 的 两 大 城 市 便 落 入 我 军 之 手 。 没 来 得 及 流 亡 苏 联 的 黎 笋 被 我 军 逮 捕 ， 草 草 审 判 后 与 其 他 亲 苏 派 一 起 被 处 决 。|泰 国 方 面 ， 我 们 的 海 军 率 先 突 破 泰 国 沿 海 防 线 ， 陆 军 随 后 登 陆 ， 迅 速 占 领 了 泰 国 的 战 略 要 地 。 经 过 数 月 的 激 烈 战 斗 ， 泰 国 政 府 宣 布 投 降 ， 其 残 余 势 力 已 被 彻 底 清 除 。 |缅 甸 军 队 同 样 无 力 防 守 。 在 海 军 的 帮 助 下 ， 我 们 的 军 队 得 以 奇 袭 仰 光 ， 缅 甸 人 就 这 么 轻 易 地 失 去 了 他 们 的 首 都 。 缅 甸 领 导 人 仓 惶 出 逃 ， 流 亡 海 外 。 失 去 了 领 导 人 的 缅 甸 就 这 么 变 成 了 我 们 砧 板 上 的 鱼 肉 。||战 后 ， 我 们 宣 布 托 管 越 南 北 部99 年 以 进 行 “ 去 修 正 主 义 化 ” ， 但 谁 都 知 道 ， 如 果 不 出 意 外 ， 越 南 北 部 将 作 为 安 南 特 区 永 远 成 为 我 国 的 一 部 分 。 经 过 遴 选 后 ， 我 们 决 定 派 遣 中 央 军 委 副 秘 书 长 韦 国 清 上 将 出 镇 交 趾 市 （ 原 河 内 ） 。 对 于 越 南 南 部 ， 我 们 则 扶 植 起 了 中 越 双 料 少 将 洪 水 之 子 陈 寒 枫 作 为 新 的 越 南 人 民 共 和 国 的 领 导 人 ， 老 挝 和 柬 埔 寨 也 望 风 而 向 ， 倒 向 了 我 们 ； 对 于 泰 国 ， 曼 谷 被 划 为 直 辖 地 ， 由 北 京 直 接 派 遣 官 员 管 理 ， 克 拉 地 峡 这 一 战 略 要 地 将 被 我 们 直 接 控 制 ， 用 于 修 建 运 河 和 军 事 基 地 ； 至 于 缅 甸 ， 我 们 将 德 林 达 依 省 交 予 泰 国 ， 自 己 则 吞 并 了 克 钦 邦 以 及 掸 邦 北 部 的 汉 族 聚 居 区 ， 其 余 地 区 形 成 了 为 我 们 马 首 是 瞻 的 缅 甸 人 民 民 主 联 邦 共 和 国 ， 缅 甸 各 民 族 重 新 划 界 ， 中 央 政 府 实 际 成 为 了 政 令 不 出 首 都 的 “ 周 天 子 ” 。 美 苏 两 国 对 我 国 表 达 了 强 烈 的 不 满 ， 谴 责 我 们 对 东 南 亚 的 侵 略 ， 但 这 不 过 是 帝 国 主 义 亡 我 之 心 不 死 的 又 一 体 现 罢 了 。|| 就 这 样 ， 中 华 民 族 伟 大 复 兴 的 拼 图 又 添 上 了 一 块 新 的 碎 片 … …";
					allcountries[11].Gosstroy = 0;
					allcountries[11].SubGosstroy = 19;
					allcountries[11].parts[0] = false;
					allcountries[11].LeaveAlliances();
					allcountries[11].Torg = true;
					allcountries[11].EstablishGovernment(Government.ProChina);
					allcountries[11].JoinAllOurAlliances(yes: true);
					allcountries[11].puppetOf = 1;
					allcountries[22].Gosstroy = 0;
					allcountries[22].SubGosstroy = 19;
					allcountries[22].LeaveAlliances();
					allcountries[22].Torg = true;
					allcountries[22].EstablishGovernment(Government.ProChina);
					allcountries[22].JoinAllOurAlliances(yes: true);
					allcountries[22].puppetOf = 1;
					allcountries[23].Gosstroy = 0;
					allcountries[23].SubGosstroy = 19;
					allcountries[23].LeaveAlliances();
					allcountries[23].Torg = true;
					allcountries[23].EstablishGovernment(Government.ProChina);
					allcountries[23].JoinAllOurAlliances(yes: true);
					allcountries[23].puppetOf = 1;
					allcountries[33].Gosstroy = 0;
					allcountries[33].SubGosstroy = 19;
					allcountries[33].LeaveAlliances();
					allcountries[33].Torg = true;
					allcountries[33].EstablishGovernment(Government.ProChina);
					allcountries[33].JoinAllOurAlliances(yes: true);
					allcountries[33].puppetOf = 1;
					allcountries[34].Gosstroy = 0;
					allcountries[34].SubGosstroy = 19;
					allcountries[34].LeaveAlliances();
					allcountries[34].Torg = true;
					allcountries[34].EstablishGovernment(Government.ProChina);
					allcountries[34].JoinAllOurAlliances(yes: true);
					allcountries[34].puppetOf = 1;
					GlobalScript.inst.gameState.data[1] += 500;
					GlobalScript.inst.gameState.data[3] += 500;
					GlobalScript.inst.gameState.data[4] -= 500;
					GlobalScript.inst.gameState.data[34] += 18;
					GlobalScript.inst.gameState.empires[1].power -= 150;
					GlobalScript.inst.gameState.empires[1].relations -= 750;
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.empires[0].relations -= 500;
					GlobalScript.inst.gameState.influencePRC += 250;
					completedDecisions[37] = false;
				}
				else
				{
					text = "我 们 的 军 队 如 同 法 军 和 美 军 一 样 陷 入 了 中 南 半 岛 的 泥 潭 之 中 ， 甚 至 一 度 被 打 进 广 西 境 内 。 最 终 我 们 不 得 不 狼 狈 选 择 与 越 南 议 和 ， 不 仅 放 弃 了 南 海 诸 岛 的 宣 称 ， 还 不 得 不 向 越 南 赔 款 。 这 种 丧 权 辱 国 的 行 径 最 终 导 致 了 政 变 ， 你 被 软 禁 并 黯 然 下 台 接 受 战 争 罪 的 审 判 。";
					GlobalScript.inst.gameState.data[1] = 0;
					GlobalScript.inst.gameState.data[3] = 0;
					GlobalScript.inst.gameState.influencePRC -= 200;
					GlobalScript.inst.gameState.data[35] = 11;
					SceneManager.LoadScene("Ending");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 72)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "我 们 无 敌 的 军 队 横 扫 了 朝 鲜 半 岛 上 的 一 切 牛 鬼 蛇 神 ， 朝 韩 军 队 根 本 不 是 我 们 的 对 手 。 几 十 年 前 我 们 就 曾 在 这 里 痛 击 联 合 国 军 ， 现 在 消 灭 这 些 美 苏 两 大 帝 国 主 义 武 装 出 的 伪 军 更 是 轻 而 易 举 。 最 终 ， 我 们 轻 松 的 从 新 义 州 推 进 至 釜 山 ， 期 间 没 有 遇 到 什 么 像 样 的 抵 抗 。 在 经 历 了 激 烈 的 战 斗 后 ， 人 民 解 放 军 踏 入 平 壤 城 内 ， 金 日 成 最 终 被 以 “ 试 图 分 裂 社 会 主 义 阵 营 ， 破 坏 中 朝 友 谊 ” 和 反 革 命 等 罪 行 被 关 入 监 狱 ， 其 亲 戚 同 样 被 关 入 劳 改 营 内 。 在 我 们 的 苦 苦 寻 找 下 ， 朝 鲜 北 部 的 孔 子 后 裔 、 政 治 局 候 补 委 员 和 国 家 计 划 委 员 会 委 员 长 孔 镇 泰 被 包 装 成 证 明 中 朝 友 好 关 系 和 红 色 血 统 的 代 表 。 虽 然 儒 学 在 我 们 的 地 位 比 较 尴 尬 ， 但 是 有 了 孔 镇 泰 的 案 例 ， 我 们 可 以 对 儒 学 进 行 “ 适 应 我 国 社 会 主 义 社 会 ” 的 改 造 。 同 样 的 ， 我 们 在 进 行 批 林 批 孔 中 开 始 扭 转 了 宣 传 方 向 ， 强 调 “ 孔 ” 也 是 可 以 改 造 的 ， 儒 法 之 争 虽 然 依 旧 比 较 偏 向 于 法 家 ， 但 是 对 于 改 造 后 的 红 儒 则 开 始 受 欢 迎 和 推 崇 起 来 ， 正 如 前 人 所 言 ： “ 打 倒 孔 家 店 ， 救 出 孔 夫 子 ” 。 我 们 也 因 此 得 以 放 开 手 脚 去 宣 扬 中 朝 友 谊 和 红 色 孔 子 后 裔 。";
					allcountries[10].Gosstroy = 0;
					allcountries[10].SubGosstroy = 19;
					allcountries[10].LeaveAlliances();
					allcountries[10].Torg = true;
					allcountries[10].EstablishGovernment(Government.ProChina);
					allcountries[10].JoinAllOurAlliances(yes: true);
					allcountries[10].puppetOf = 1;
					GlobalScript.inst.gameState.data[1] += 500;
					GlobalScript.inst.gameState.data[3] += 500;
					GlobalScript.inst.gameState.data[4] -= 500;
					GlobalScript.inst.gameState.data[34] += 18;
					GlobalScript.inst.gameState.empires[1].power -= 150;
					GlobalScript.inst.gameState.empires[1].relations -= 750;
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.empires[0].relations -= 500;
					GlobalScript.inst.gameState.influencePRC += 250;
					completedDecisions[37] = false;
				}
				else
				{
					text = "你 大 胆 的 军 事 行 动 最 终 以 失 败 告 终 ， 这 一 行 动 在 后 世 被 与 隋 炀 帝 三 征 高 句 丽 相 提 并 论 。 我 们 陷 入 了 朝 鲜 半 岛 的 泥 潭 ， 一 如 当 年 和 志 愿 军 纠 缠 的 美 军 。 讽 刺 的 是 ， 几 十 年 后 我 们 竟 是 以 侵 略 者 的 身 份 再 次 踏 上 这 片 土 地 。 随 着 战 线 逐 渐 停 滞 ， 美 苏 也 开 始 向 我 国 边 境 施 压 ， 我 们 不 得 不 从 各 个 地 方 抽 调 部 队 以 进 行 应 对 ， 最 终 ， 我 们 控 制 的 中 南 半 岛 也 发 生 了 大 规 模 叛 乱 。 无 力 应 对 的 政 府 最 终 导 致 了 军 事 政 变 ， 新 政 府 上 台 后 宣 布 撤 出 朝 鲜 半 岛 、 中 南 半 岛 并 与 高 丽 议 和 。 最 终 我 们 不 仅 丢 掉 了 中 南 半 岛 的 控 制 权 ， 还 被 迫 将 延 边 州 割 予 高 丽 。 一 切 尘 埃 落 定 后 ， 你 因 战 争 罪 被 判 死 刑 。";
					GlobalScript.inst.gameState.data[1] = 0;
					GlobalScript.inst.gameState.data[3] = 0;
					GlobalScript.inst.gameState.influencePRC -= 200;
					GlobalScript.inst.gameState.data[35] = 12;
					SceneManager.LoadScene("Ending");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 73)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "事 实 证 明 ， 东 南 亚 各 国 拼 凑 的 “ 太 平 洋 联 军 ” 不 过 是 群 拿 着 外 国 武 器 援 助 与 军 官 指 导 便 自 鸣 得 意 的 虾 兵 蟹 将 ， 只 能 欺 负 欺 负 山 林 内 苟 且 偷 生 的 游 击 队 与 放 下 武 器 的 共 产 党 。 面 对 早 在 内 战 与 朝 鲜 前 线 经 历 过 硬 仗 的 钢 铁 雄 师 ， 它 们 很 快 便 成 建 制 地 崩 溃 ， 其 残 兵 则 识 时 务 的 改 换 门 面 ， 被 编 入 我 军 驻 东 南 亚 协 助 治 安 部 队 内 — — 主 要 战 事 在 美 军 试 图 组 织 全 面 干 涉 前 便 已 结 束 ， 大 洋 彼 岸 的 “ 老 朋 友 ” 只 能 借 几 处 岛 屿 隔 海 相 望 ， 并 对 我 们 的 胜 利 成 果 无 可 奈 何 。 英 明 领 袖 华 国 锋 同 志 就 此 扫 除 了 南 方 聒 噪 的 美 帝 国 主 义 帮 闲 ， 并 重 新 确 立 了 我 中 华 文 明 对 东 南 亚 的 治 权 与 至 高 权 威 。 我 们 不 仅 空 前 拓 展 了 海 南 省 的 版 图 ， 完 全 收 复 南 沙 群 岛 ， 让 九 段 线 变 得 名 副 其 实 ； 同 时 还 完 成 了 菲 律 宾 、 马 来 亚 与 印 尼 共 产 党 的 未 竟 之 事 ， 接 下 来 便 是 因 地 制 宜 设 计 政 策 与 我 中 华 儿 女 喜 闻 乐 见 的 报 仇 雪 耻 环 节 ： 考 虑 到 当 地 共 产 党 长 期 未 能 成 事 ， 反 共 反 华 势 力 长 期 深 耕 ， 且 事 实 上 长 期 作 为 流 亡 国 民 党 匪 帮 与 美 帝 国 主 义 代 理 人 基 地 ， 又 深 受 腐 败 独 裁 者 无 能 统 治 毒 害 的 客 观 现 实 。 我 们 认 为 东 南 亚 人 显 然 需 要 段 时 间 来 适 应 现 代 生 活 方 式 ， 并 决 定 亲 自 收 拾 当 地 的 烂 摊 子 。 菲 律 宾 、 马 来 亚 与 印 尼 地 区 已 被 划 为 解 放 军 部 队 专 管 军 区 ， 在 引 入 长 期 军 事 管 制 的 同 时 引 入 “ 格 杀 勿 论 ” 令 — — 已 向 北 京 当 局 宣 誓 效 忠 的 当 地 华 人 社 区 、 亲 中 组 织 与 背 靠 国 家 名 义 “ 下 南 洋 ” 的 一 代 “ 知 青 ” 们 得 到 了 大 批 武 器 物 资 ， 确 认 法 外 处 决 与 执 法 权 已 在 “ 人 民 自 决 ” 名 义 下 充 分 放 开 后 。 便 开 始 采 纳 “ 枪 杆 子 里 出 政 权 ” 的 智 慧 在 南 洋 的 广 阔 天 地 内 “ 有 所 作 为 ” 。 类 似 南 非 的 武 装 殖 民 社 区 和 种 族 分 流 制 度 就 此 在 当 地 四 处 开 花 ， 马 来 人 、 印 尼 人 则 不 得 不 让 出 富 庶 的 城 市 、 肥 沃 的 土 地 与 相 对 发 达 的 产 业 ， 转 而 向 我 军 规 划 的 “ 战 略 村 ” 与 隔 离 带 内 迁 徙 ， 并 在 其 中 缴 纳 义 务 劳 动 以 赎 罪 — — 那 些 地 方 或 是 前 现 代 化 的 乡 野 ， 或 是 马 尼 拉 这 类 超 级 都 会 外 的 棚 户 区 ， 或 直 接 是 热 带 内 的 不 毛 之 地 ， 我 国 专 家 安 排 的 劳 动 配 额 将 保 证 他 们 的 努 力 绝 不 白 费 。 至 于 有 关 排 华 屠 杀 等 在 内 的 其 他 历 史 旧 账 ： <color=red>无 需 担 心 … … 实 际 上 ， 我 们 已 经 在 给 当 地 刁 民 安 排 生 计 与 应 付 其 抗 议 的 同 时 开 始 逐 一 清 算 了 … …</color>";
					allcountries[47].Gosstroy = 0;
					allcountries[47].SubGosstroy = 19;
					allcountries[47].LeaveAlliances();
					allcountries[47].Torg = true;
					allcountries[47].EstablishGovernment(Government.ProChina);
					allcountries[47].JoinAllOurAlliances(yes: true);
					allcountries[47].puppetOf = 1;
					allcountries[49].Gosstroy = 0;
					allcountries[49].SubGosstroy = 19;
					allcountries[49].LeaveAlliances();
					allcountries[49].Torg = true;
					GlobalScript.inst.gameState.allcountries[49].parts[0] = true;
					allcountries[49].EstablishGovernment(Government.ProChina);
					allcountries[49].JoinAllOurAlliances(yes: true);
					allcountries[49].puppetOf = 1;
					allcountries[49].parts[0] = true;
					allcountries[50].Gosstroy = 0;
					allcountries[50].SubGosstroy = 19;
					allcountries[50].LeaveAlliances();
					allcountries[50].Torg = true;
					allcountries[50].EstablishGovernment(Government.ProChina);
					allcountries[50].JoinAllOurAlliances(yes: true);
					allcountries[50].puppetOf = 1;
					allcountries[134].Gosstroy = 0;
					allcountries[134].SubGosstroy = 19;
					allcountries[134].LeaveAlliances();
					allcountries[134].Torg = true;
					allcountries[134].EstablishGovernment(Government.ProChina);
					allcountries[134].JoinAllOurAlliances(yes: true);
					allcountries[134].puppetOf = 1;
					GlobalScript.inst.gameState.data[1] += 500;
					GlobalScript.inst.gameState.data[3] += 500;
					GlobalScript.inst.gameState.data[4] -= 500;
					GlobalScript.inst.gameState.data[34] += 18;
					GlobalScript.inst.gameState.empires[1].power -= 150;
					GlobalScript.inst.gameState.empires[1].relations -= 750;
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.empires[0].relations -= 500;
					GlobalScript.inst.gameState.influencePRC += 250;
					completedDecisions[37] = false;
				}
				else
				{
					text = "依 托 东 南 亚 地 区 错 综 复 杂 的 生 态 环 境 与 美 帝 国 主 义 的 援 助 ， 所 谓 的 “ 太 平 洋 联 军 ” 很 快 便 将 战 场 转 变 为 了 第 二 个 越 南 — — 然 而 ， 这 次 一 头 扎 入 陷 阱 的 却 成 了 我 们 。 原 定 的 东 南 亚 闪 击 战 计 划 就 此 破 产 ， 并 被 痛 苦 而 煎 熬 的 添 油 战 术 取 而 代 之 。 然 而 ， 即 便 是 这 招 也 无 法 解 救 我 军 颓 势 ： 美 军 太 平 洋 舰 队 的 干 预 和 大 洋 洲 方 向 的 军 事 调 动 直 接 导 致 了 对 东 南 亚 的 军 事 计 划 彻 底 破 产 ， 并 将 我 们 逼 上 谈 判 桌 。 竹 篮 打 水 一 场 空 — — 而 我 们 在 这 场 一 无 所 获 的 战 争 内 失 去 的 并 不 只 有 一 代 健 儿 ： 考 虑 到 《 合 约 》 必 然 涉 及 赔 款 制 裁 与 部 分 削 弱 中 国 国 家 安 全 与 主 权 的 条 款 ， “ 英 明 领 袖 ” 还 是 做 好 体 面 出 局 的 准 备 为 妙 ！";
					GlobalScript.inst.gameState.data[1] = 0;
					GlobalScript.inst.gameState.data[3] = 0;
					GlobalScript.inst.gameState.influencePRC -= 200;
					GlobalScript.inst.gameState.data[35] = 11;
					SceneManager.LoadScene("Ending");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 74)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "多 年 过 去 ， 这 些 印 度 人 还 是 没 什 么 长 进 ： 西 线 ， 我 们 的 军 队 就 如 1 9 6 2 年 一 样 轻 松 打 到 新 德 里 城 下 ； 东 线 ， 我 们 一 举 截 断 了 西 里 古 里 走 廊 ， 联 合 印 北 五 邦 的 分 离 主 义 者 ， 扫 荡 印 度 东 北 。 孟 加 拉 国 也 趁 火 打 劫 ， 占 领 了 西 孟 加 拉 邦 （ 虽 然 可 能 是 出 于 对 我 们 交 投 名 状 的 意 图 ） 。 印 度 政 府 就 这 么 草 率 地 倒 台 了 ， 政 府 高 层 乘 飞 机 逃 亡 海 外 。 战 后 ， 我 们 选 择 将 印 度 分 为 多 个 国 家 ， 西 部 由 巴 基 斯 坦 占 领 ， 以 换 取 其 控 制 下 的 巴 尔 蒂 斯 坦 地 区 ； 拉 达 克 地 区 、 藏 南 地 区 被 我 方 占 领 ； 锡 金 在 “ 复 国 ” 后 与 不 丹 一 道 公 投 加 入 我 国 ， 成 为 了 西 藏 自 治 区 地 一 个 县 。 美 国 和 苏 联 只 能 在 联 合 国 继 续 聒 噪 ， 但 这 对 我 们 来 说 毫 无 影 响 。";
					allcountries[19].Gosstroy = 0;
					allcountries[19].SubGosstroy = 19;
					allcountries[19].LeaveAlliances();
					allcountries[19].Torg = true;
					allcountries[19].EstablishGovernment(Government.ProChina);
					allcountries[19].JoinAllOurAlliances(yes: true);
					allcountries[19].puppetOf = 1;
					allcountries[31].Gosstroy = 0;
					allcountries[31].SubGosstroy = 19;
					allcountries[31].LeaveAlliances();
					allcountries[31].Torg = true;
					allcountries[31].EstablishGovernment(Government.ProChina);
					allcountries[31].JoinAllOurAlliances(yes: true);
					allcountries[31].puppetOf = 1;
					allcountries[43].Gosstroy = 0;
					allcountries[43].SubGosstroy = 19;
					allcountries[43].LeaveAlliances();
					allcountries[43].Torg = true;
					allcountries[43].EstablishGovernment(Government.ProChina);
					allcountries[43].JoinAllOurAlliances(yes: true);
					allcountries[43].puppetOf = 1;
					allcountries[96].Gosstroy = 0;
					allcountries[96].SubGosstroy = 19;
					allcountries[96].LeaveAlliances();
					allcountries[96].Torg = true;
					allcountries[96].EstablishGovernment(Government.ProChina);
					allcountries[96].JoinAllOurAlliances(yes: true);
					allcountries[96].puppetOf = 1;
					allcountries[97].Gosstroy = 0;
					allcountries[97].SubGosstroy = 19;
					allcountries[97].LeaveAlliances();
					allcountries[97].Torg = true;
					allcountries[97].EstablishGovernment(Government.ProChina);
					allcountries[97].JoinAllOurAlliances(yes: true);
					allcountries[97].puppetOf = 1;
					allcountries[32].Gosstroy = 0;
					allcountries[32].SubGosstroy = 19;
					allcountries[32].LeaveAlliances();
					allcountries[32].Torg = true;
					allcountries[32].EstablishGovernment(Government.ProChina);
					allcountries[32].JoinAllOurAlliances(yes: true);
					allcountries[32].puppetOf = 1;
					GlobalScript.inst.gameState.data[1] += 500;
					GlobalScript.inst.gameState.data[3] += 500;
					GlobalScript.inst.gameState.data[4] -= 500;
					GlobalScript.inst.gameState.data[34] += 18;
					GlobalScript.inst.gameState.empires[1].power -= 150;
					GlobalScript.inst.gameState.empires[1].relations -= 750;
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.empires[0].relations -= 500;
					GlobalScript.inst.gameState.influencePRC += 250;
					completedDecisions[37] = false;
				}
				else
				{
					text = "我 们 的 军 队 意 外 的 遭 遇 了 滑 铁 卢 ： 印 度 军 队 顽 强 地 抵 抗 着 我 们 的 进 攻 。 像1962 年 一 样 事 情 没 能 发 生 ， 我 们 的 速 胜 策 略 被 迫 变 成 了 拉 锯 战 ， 连 同 巴 基 斯 坦 一 道 ， 中 印 巴 三 国 在 南 亚 次 大 陆 进 行 着 血 腥 的 战 争 。 由 于 我 们 要 维 持 广 大 的 占 领 区 ， 以 及 青 藏 高 原 艰 苦 的 补 给 条 件 ， 我 们 并 不 能 在 前 线 安 排 多 少 军 队 。 " + ((!IsSocialism(yes: true, 19)) ? "最 终 ， 印 度 还 是 在 超 级 大 国 的 支 援 下 更 胜 一 筹 ， 他 们 攻 入 了 西 藏 ， 我 军 则 一 溃 千 里 。 之 后 ， 气 急 败 坏 的 你 决 定 按 下 宝 贵 的 红 色 按 钮 ， 就 这 样 ， 故 事 结 束 了 … …" : " 印 度 人 民 军 还 是 保 持 了 相 当 的 克 制 ， 在 将 中 国 军 队 逐 出 了 印 度 国 境 线 之 后 ， 他 们 便 向 北 京 发 来 了 议 和 的 消 息 ， 你 也 被 迫 认 下 了 这 一 苦 果 。 只 是 ， 此 役 使 你 威 望 尽 失 … … 等 等 ， 谁 在 敲 门 ？");
					GlobalScript.inst.gameState.data[1] = 0;
					GlobalScript.inst.gameState.data[3] = 0;
					GlobalScript.inst.gameState.influencePRC -= 200;
					GlobalScript.inst.gameState.data[35] = 3;
					SceneManager.LoadScene("Ending");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 75)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "一 隅 之 地 自 然 无 法 与 大 陆 抗 衡 ， 尽 管 有 着 先 进 的 美 式 装 备 ， 但 是 蒋 伪 所 谓 “ 国 军 ” 仍 然 如 解 放 战 争 时 期 一 般 不 堪 一 击 。 我 们 轻 松 占 领 了 台 湾 伪 “ 总 统 府 ” 。 蒋 经 国 试 图 乘 飞 机 逃 亡 日 本 ， 但 被 我 军 一 发 导 弹 击 中 ， 成 为 了 天 空 绚 丽 的 烟 花 。 战 后 ， 我 们 拆 毁 了 中 正 纪 念 堂 ， 蒋 介 石 的 尸 骸 被 火 化 后 倒 入 下 水 道 中 排 入 大 海 。 对 蒋 伪 政 府 的 清 算 也 开 始 了 ， 一 批 当 年 背 叛 台 湾 省 工 委 的 人 或 被 处 以 枪 决 ， 或 被 开 棺 戮 尸 。 随 后 ， 对 台 湾 各 大 企 业 的 国 有 化 也 开 始 了 。 我 们 也 寻 求 与 台 湾 支 持 统 一 的 人 士 合 作 ， 台 湾 与 大 陆 再 也 不 会 分 离 。";
					data[64] = 2;
					GlobalScript.inst.gameState.completedDecisions[7] = true;
					GlobalScript.inst.gameState.data[64] = 2;
					allcountries[1].ILoveSuckCocks();
					GlobalScript.inst.gameState.data[1] += 500;
					GlobalScript.inst.gameState.data[3] += 500;
					GlobalScript.inst.gameState.data[4] -= 500;
					GlobalScript.inst.gameState.data[34] += 18;
					GlobalScript.inst.gameState.empires[1].power -= 150;
					GlobalScript.inst.gameState.empires[1].relations -= 750;
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.empires[0].relations -= 500;
					GlobalScript.inst.gameState.influencePRC += 250;
				}
				else
				{
					text = "由 于 美 国 的 倾 力 支 持 ， 解 放 军 最 终 还 是 折 戟 台 海 。 我 们 被 迫 与 国 军 打 起 了 静 坐 战 。 此 外 ， 由 于 长 期 的 先 军 政 策 ， 我 国 的 生 活 水 平 十 分 低 下 ， 这 也 引 发 了 人 民 的 不 满 。 这 种 不 满 最 终 爆 发 为 了 大 规 模 的 示 威 游 行 和 暴 乱 行 动 。 起 初 ， 你 还 能 勉 强 维 持 局 面 ； 但 后 来 ， 南 方 某 地 区 的 一 个 士 兵 的 手 指 误 触 了 扳 机 ， 旋 即 愤 怒 的 人 民 便 涌 上 了 街 头 ， 他 们 甚 至 打 出 了 国 民 党 的 旗 号 ！ 在 台 湾 的 蒋 经 国 政 府 则 借 势 向 他 们 偷 运 装 备 并 积 极 策 反 围 岛 军 队 。 最 终 ， 国 军 在 人 民 的 簇 拥 下 重 新 进 入 了 南 京 城 。 时 隔 几 十 年 ， 竟 是 两 极 反 转 ， 不 知 当 年 缔 造 这 个 国 家 的 先 贤 们 若 见 到 这 种 情 况 会 作 何 感 想 。 在 美 国 的 支 持 下 ， 新 的 中 华 民 国 控 制 了 华 南 和 西 南 地 区 ； 苏 联 的 各 大 势 力 在 短 暂 谈 判 后 迅 速 达 成 一 致 ， 趁 内 乱 再 次 占 领 了 外 东 北 、 外 西 北 ， 还 扶 植 了 内 外 蒙 古 和 东 三 省 作 为 傀 儡 政 权 ； 北 方 地 区 则 陷 入 了 军 阀 割 据 的 局 面 。 历 史 仿 佛 再 次 回 到 了20 世 纪30 年 代 的 局 面 。 而 失 去 了 一 切 支 持 的 你 也 只 得 饮 弹 自 尽 的 结 局 。";
					GlobalScript.inst.gameState.data[1] = 0;
					GlobalScript.inst.gameState.data[3] = 0;
					GlobalScript.inst.gameState.influencePRC -= 200;
					GlobalScript.inst.gameState.data[35] = 11;
					SceneManager.LoadScene("Ending");
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 76)
			{
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 950)
				{
					text = "靠 着 中 国 的 鼎 力 支 持 ， 齐 奥 塞 斯 库 巧 妙 地 利 用 了 新 华 约 联 军 组 织 仓 促 ， 缺 乏 训 练 ， 以 及 无 主 心 骨 等 问 题 ； 在 前 线 打 了 数 场 漂 亮 的 防 守 反 击 战 ， 给 侵 略 者 以 迎 头 痛 击 。 前 线 吃 紧 的 战 事 与 越 加 惨 重 的 损 失 使 得 本 就 被 协 调 问 题 困 扰 的 华 约 联 军 内 越 加 离 心 离 德 ， 这 最 终 导 致 了 灾 难 性 的 后 果 ： 计 划 内 一 致 干 涉 罗 马 尼 亚 的 行 动 很 快 便 转 为 各 国 各 自 为 战 、 各 扫 门 前 雪 的 混 乱 局 面 ， 其 中 的 波 兰 更 是 借 处 理 “ 团 结 工 会 ” 问 题 为 由 事 实 上 退 出 了 军 事 行 动 。 胡 乱 的 指 挥 与 匆 忙 的 调 动 导 致 剩 下 的 东 欧 部 队 被 罗 马 尼 亚 武 装 力 量 各 个 击 破 。 齐 奥 塞 斯 库 甚 至 借 此 扫 清 了 进 军 匈 牙 利 的 道 路 ， 在 布 达 佩 斯 城 区 内 复 刻 了 苏 军1956 年 时 的 “ 丰 功 伟 绩 ” 。 随 着 匈 牙 利 的 崩 溃 与 华 约 联 军 的 破 产 ， 东 欧 各 国 不 得 不 宣 布 终 止 军 事 行 动 并 与 罗 马 尼 亚 停 火 ， 并 靠 出 卖 匈 牙 利 主 权 的 方 式 避 免 了 齐 奥 塞 斯 库 的 进 一 步 报 复 。 所 谓 的 苏 东 社 会 主 义 阵 营 也 因 本 次 出 师 不 利 而 事 实 上 宣 告 了 灭 亡 — — 意 识 到 华 约 - 经 互 会 框 架 已 无 法 保 障 自 身 利 益 （ 且 因 对 罗 马 尼 亚 的 失 败 干 预 而 无 法 维 系 ） 的 东 欧 政 客 们 不 得 不 放 下 这 一 衣 钵 ， 并 转 而 走 上 了 另 一 条 自 力 更 生 之 路 。 而 这 恰 是 东 欧 剧 变 的 开 端 ： 不 久 后 ， 彻 底 失 去 了 靠 山 ， 且 无 法 从 战 争 损 失 内 恢 复 的 民 主 德 国 政 权 便 输 掉 了 同 联 邦 德 国 的 竞 争 ， 并 被 后 者 完 全 吞 并 。 而 改 革 与 反 建 制 的 潮 流 也 吹 遍 了 东 欧 地 区 的 其 他 国 家 — — 独 木 难 支 的 建 制 派 不 得 不 以 让 出 部 分 利 益 ， 提 供 改 革 许 诺 ， 组 建 所 谓 “ 民 族 政 府 ” 的 形 式 拉 来 了 一 部 分 异 见 者 稳 固 局 势 。 当 然 ， 这 种 状 态 显 然 不 会 长 久 … … 而 罗 马 尼 亚 则 是 另 一 片 风 景 ： 赢 得 了 卫 国 战 争 ， 将 老 对 手 匈 牙 利 彻 底 踩 在 脚 下 的 齐 奥 塞 斯 库 得 以 空 前 巩 固 自 身 权 威 ， 并 伙 同 其 智 囊 “ 知 识 分 子 集 团 ” 彻 底 实 现 其 建 构 主 权 罗 马 尼 亚 的 计 划 。 第 一 步 便 是 以 中 国 模 式 为 蓝 本 建 立 稳 定 继 承 机 制 ， 光 大 民 族 优 秀 文 化 ； 然 后 则 是 决 心 在 充 分 弘 扬 齐 奥 塞 斯 库 家 族 权 威 的 同 时 走 所 谓 “ 罗 马 特 色 的 马 克 思 主 义 ” 之 路 。 “ 改 革 ” 就 此 开 始 … …";
					GlobalScript.inst.gameState.allcountries[4].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[4].proprc = true;
					GlobalScript.inst.gameState.allcountries[4].JoinAllOurAlliances(yes: true);
					GlobalScript.inst.gameState.allcountries[4].Torg = true;
					GlobalScript.inst.gameState.allcountries[4].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[4].SubGosstroy = 19;
					for (int num11 = 0; num11 < allcountries.Length; num11++)
					{
						if (allcountries[num11].isSEV)
						{
							allcountries[num11].isSEV = false;
						}
						if (allcountries[num11].isOVD)
						{
							allcountries[num11].isOVD = false;
						}
						if ((allcountries[num11].isOVD || allcountries[num11].isSEV) && num11 != 7)
						{
							allcountries[num11].prosov = false;
						}
					}
					GlobalScript.inst.gameState.allcountries[2].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 15;
					GlobalScript.inst.gameState.allcountries[3].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[3].SubGosstroy = 15;
					GlobalScript.inst.gameState.allcountries[6].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[6].SubGosstroy = 15;
					GlobalScript.inst.gameState.data[1] += 500;
					GlobalScript.inst.gameState.data[3] += 500;
					GlobalScript.inst.gameState.data[4] -= 500;
					GlobalScript.inst.gameState.empires[1].power -= 150;
					GlobalScript.inst.gameState.empires[1].relations -= 750;
					GlobalScript.inst.gameState.empires[0].power -= 50;
					GlobalScript.inst.gameState.empires[0].relations -= 200;
					GlobalScript.inst.gameState.influencePRC += 100;
					if (!allcountries[16].parts[0])
					{
						allcountries[17].parts[0] = true;
						allcountries[17].dev = 2;
						allcountries[16].LeaveAlliances();
					}
				}
				else
				{
					text = "罗 马 尼 亚 武 装 力 量 终 究 是 难 以 应 付 从 四 面 八 方 涌 入 国 境 的 华 约 联 军 ， 被 打 得 节 节 败 退 。 前 线 失 利 的 消 息 很 快 便 在 后 方 转 化 为 对 齐 奥 塞 斯 库 统 治 集 团 的 质 疑 与 抗 议 ， 这 便 为 华 约 方 在 罗 马 尼 亚 安 插 第 五 纵 队 提 供 了 良 机 。 被 齐 奥 塞 斯 库 打 倒 的 前 总 理 伊 利 耶 · 维 尔 德 茨 、 少 数 民 族 利 益 保 护 者 亚 诺 什 · 法 泽 卡 什 、 保 守 派 党 员 格 奥 尔 基 · 阿 波 斯 托 尔 等 很 快 便 借 机 组 建 起 了 “ 反 党 集 团 ” ， 并 在 联 军 兵 临 布 加 勒 斯 特 时 对 齐 奥 塞 斯 库 彻 底 摊 牌 。 最 终 ， 尼 古 拉 · 齐 奥 塞 斯 库 与 其 亲 信 均 被 联 军 武 装 力 量 逮 捕 ， 并 被 收 押 在 位 于 柏 林 的 史 塔 西 监 狱 内 等 待 审 判 。 新 政 府 则 由 伊 利 耶 · 维 尔 德 茨 牵 头 领 导 ， 格 奥 尔 基 · 阿 波 斯 托 尔 则 重 回 工 会 干 部 之 职 。 他 们 在 华 约 军 队 的 监 视 下 宣 布 了 所 谓 “ 真 正 的 社 会 主 义 路 线 ” ， 并 在 华 约 军 队 监 督 下 立 即 启 动 了 去 齐 奥 塞 斯 库 化 议 程 ： 废 除 紧 缩 政 策 ， 改 组 共 产 党 ， 以 及 深 化 经 互 会 内 一 体 化 。 虽 说 对 理 论 上 的 盟 友 重 拳 出 击 的 行 为 并 不 光 彩 ， 可 新 华 约 还 是 靠 这 招 打 出 了 风 头 与 震 慑 力 ， 证 明 了 社 会 主 义 阵 营 仍 牢 不 可 破 。 看 来 ， 在 相 当 长 的 一 段 时 间 内 ， 东 欧 地 区 将 迎 来 没 有 苏 联 的 苏 维 埃 帝 国 式 统 治 … …";
					GlobalScript.inst.gameState.data[1] -= 300;
					GlobalScript.inst.gameState.data[3] -= 300;
					GlobalScript.inst.gameState.data[4] += 300;
					GlobalScript.inst.gameState.allcountries[5].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[5].SubGosstroy = 16;
					GlobalScript.inst.gameState.allcountries[5].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[5].isSEV = true;
					GlobalScript.inst.gameState.allcountries[5].isOVD = true;
					GlobalScript.inst.gameState.allcountries[5].prosov = true;
					GlobalScript.inst.gameState.influencePRC -= 200;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 77)
			{
				GlobalScript.inst.gameState.allcountries[107].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
				{
					text = "塞 拉 利 昂 人 民 党 得 以 成 功 串 联 起 全 国 起 义 ， 最 终 推 翻 斯 蒂 文 森 的 “ 蝗 虫 政 权 ” 。 斯 蒂 文 森 本 人 也 匆 匆 逃 离 了 国 家 。 目 前 该 国 正 在 约 瑟 夫 · 莫 莫 的 治 下 实 行 临 时 军 管 ， 并 将 在 不 久 后 召 开 选 举 。 预 计 曾 在 联 合 国 内 长 期 耕 耘 的 律 师 经 济 学 家 艾 哈 迈 德 · 泰 詹 · 卡 巴 将 取 得 大 胜 ， 并 试 图 在 建 构 现 代 市 场 经 济 的 同 时 重 建 宪 政 秩 序 。 人 民 党 将 把 该 国 带 向 何 方 ， 让 我 们 拭 目 以 待 … …";
					GlobalScript.inst.gameState.allcountries[107].Gosstroy = 3;
					GlobalScript.inst.gameState.allcountries[107].SubGosstroy = 12;
					if (GlobalScript.inst.gameState.influencePRC >= GlobalScript.inst.gameState.empires[0].power)
					{
						GlobalScript.inst.gameState.allcountries[107].proprc = true;
					}
					else
					{
						GlobalScript.inst.gameState.allcountries[107].Vyshi = true;
					}
				}
				else
				{
					text = "塞 拉 利 昂 人 民 党 的 起 义 最 终 迅 速 落 败 。 政 府 得 以 牢 牢 掌 握 了 局 势 并 照 旧 统 治 。 然 而 ， 战 后 的 塞 拉 利 昂 似 乎 并 没 有 就 此 迎 来 和 平 ： 基 于 血 缘 部 族 的 仇 杀 仍 在 继 续 ， 毫 无 停 息 迹 象 … … 意 识 到 自 己 在 国 际 舞 台 上 陷 入 孤 立 的 斯 蒂 文 森 政 权 也 就 只 能 越 加 靠 拢 苏 联 ， 成 为 后 者 在 西 非 的 前 哨 。 可 事 情 绝 不 会 到 此 为 止 。";
					GlobalScript.inst.gameState.allcountries[107].prosov = true;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 78)
			{
				GlobalScript.inst.gameState.allcountries[107].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 700)
				{
					if (GlobalScript.inst.gameState.allcountries[107].cw)
					{
						text = "塞 拉 利 昂 革 命 者 得 以 克 服 万 难 顺 利 进 军 弗 里 敦 ， 并 在 此 基 础 上 建 立 了 一 个 试 图 统 合 全 国 利 益 的 革 命 政 权 。 多 亏 了 泛 非 主 义 盟 友 的 及 时 援 助 ， 塞 拉 利 昂 政 权 不 至 完 全 从 零 开 始 恢 复 元 气 。 现 在 ， 塞 拉 利 昂 人 民 民 主 阵 线 正 踌 躇 满 志 大 步 前 进 ， 努 力 参 照 非 洲 各 地 的 革 命 政 权 与 中 国 的 样 板 进 行 国 内 重 组 。";
						GlobalScript.inst.gameState.allcountries[107].Gosstroy = 1;
						GlobalScript.inst.gameState.allcountries[107].SubGosstroy = 0;
						GlobalScript.inst.gameState.allcountries[107].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[107].Torg = true;
						GlobalScript.inst.gameState.allcountries[107].proprc = true;
						GlobalScript.inst.gameState.influencePRC += 10;
					}
					else
					{
						text = "内 战 很 快 就 陷 入 了 一 发 不 可 收 拾 的 境 地 — — 所 谓 的 “ 革 命 联 合 阵 线 ” 在 此 期 间 可 说 是 无 所 不 为 ： 桑 科 的 武 装 力 量 很 快 便 靠 着 毒 打 、 酷 刑 与 屠 杀 等 多 种 手 段 打 出 了 自 己 的 “ 威 名 ” ； 并 在 接 管 塞 拉 利 昂 当 局 后 发 动 二 次 政 变 建 立 了 独 裁 统 治 。 接 下 来 便 是 以 自 己 治 军 的 “ 铁 腕 手 段 ” 将 各 项 准 则 落 入 国 家 政 权 建 设 中 ： 塞 拉 利 昂 主 要 的 钻 石 产 地 均 被 收 归 国 有 ， 并 通 过 总 统 办 公 室 与 军 方 的 联 系 将 其 转 为 桑 科 的 私 产 — — 这 些 区 域 事 实 上 以 蓄 奴 种 植 园 的 方 式 进 行 经 营 。 除 此 之 外 ， 新 塞 拉 利 昂 总 统 更 是 要 求 除 “ 革 命 联 合 阵 线 ” 外 的 部 队 一 律 缴 械 ， 并 在 后 者 的 监 护 下 引 入 利 比 亚 的 民 众 国 框 架 。 接 下 来 便 是 谴 责 非 洲 绝 大 多 数 国 家 背 叛 泛 非 主 义 的 戏 码 （ 虽 然 实 际 情 况 是 这 些 国 家 或 拒 绝 承 认 “ 革 命 联 合 阵 线 ” 政 府 ， 或 试 图 通 过 参 与 联 合 禁 毒 与 反 走 私 行 动 封 锁 塞 拉 利 昂 犯 罪 集 团 的 活 动 ） 。 一 个 靠 着 由 海 洛 因 、 雇 佣 兵 和 血 钻 加 冕 的 现 代 僭 主 就 此 诞 生 … …||<color=red>“ 每 一 代 人 都 必 须 从 默 默 无 闻 中 走 出 来 ， 发 现 自 己 的 使 命 ， 完 成 自 己 的 使 命 ， 或 者 背 叛 自 己 的 使 命 。 ” — — 弗 朗 茨 · 法 农</color>";
						GlobalScript.inst.gameState.allcountries[107].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[107].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[107].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[107].Torg = true;
						GlobalScript.inst.gameState.allcountries[107].proprc = true;
						if (GlobalScript.inst.gameState.allcountries[13].SubGosstroy == 10)
						{
							GlobalScript.inst.gameState.allcountries[107].puppetOf = 13;
						}
					}
				}
				else
				{
					text = "靠 着 及 时 转 向 美 国 与 力 行 霹 雳 手 段 两 手 抓 的 做 法 。 塞 拉 利 昂 政 府 军 得 以 勉 强 抵 抗 住 国 内 革 命 者 的 进 攻 ， 并 顺 势 发 起 反 攻 。 来 自 西 方 的 军 火 与 雇 佣 兵 成 为 了 新 政 权 的 镇 压 利 器 ， 并 以 席 卷 全 国 的 政 治 恐 怖 强 行 稳 固 了 局 势 。 现 在 ， 属 于 ， 加 布 里 埃 尔 · 卡 伊 卡 伊 的 亲 西 盗 窃 政 府 得 以 高 枕 无 忧 了 。";
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 79)
			{
				GlobalScript.inst.gameState.allcountries[60].parts[0] = false;
				if (allcountries[60].cw)
				{
					if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 1000)
					{
						text = "在 经 历 极 大 烈 度 的 战 争 后 ， 扬 塔 特 斯 尼 成 功 占 领 了 首 都 拉 各 斯 ， 推 翻 了 尼 日 利 亚 政 府 ， 夺 取 了 全 国 的 控 制 权 。 穆 萨 · 阿 里 · 苏 莱 曼 宣 布 成 立 索 科 托 伊 斯 兰 国 ， 他 表 示 ， 将 继 承 伟 大 导 师 麦 塔 特 斯 尼 的 遗 志 ， 将 富 拉 尼 圣 战 进 行 到 底 。";
						GlobalScript.inst.gameState.allcountries[60].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[60].SubGosstroy = 9;
						GlobalScript.inst.gameState.allcountries[60].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[60].Torg = true;
						GlobalScript.inst.gameState.allcountries[60].proprc = true;
						GlobalScript.inst.gameState.allcountries[60].name = "索 科 托 伊 斯 兰 国";
						GlobalScript.inst.gameState.influencePRC += 20;
					}
					else
					{
						text = "尽 管 战 争 双 方 都 想 彻 底 战 胜 对 方 ， 但 事 实 表 明 他 们 都 没 有 这 种 实 力 — — 尼 日 利 亚 内 战 双 方 都 陷 入 了 长 期 的 拉 锯 中 — — 直 至 双 方 都 无 法 承 受 这 种 负 担 ， 各 方 决 定 就 现 状 达 成 和 平 协 定 。 北 方 的 豪 萨 - 富 拉 尼 地 区 被 承 认 由 扬 塔 特 斯 尼 控 制 。 战 后 ， 在 北 方 ， 穆 萨 · 阿 里 · 苏 莱 曼 宣 布 成 立 索 科 托 伊 斯 兰 国 ， 他 表 示 将 再 次 发 扬 历 史 上 富 拉 尼 圣 战 的 精 神 ； 在 南 方 ， 新 成 立 了 南 方 人 主 导 的 民 主 临 时 政 府 ， 但 由 于 战 争 失 败 的 代 价 如 此 之 大 ， 又 一 场 政 变 在 南 方 的 尼 日 利 亚 政 权 发 生 了 ， 萨 尼 · 阿 巴 查 成 为 了 新 的 国 家 元 首 ， 让 我 们 看 看 接 下 来 会 发 生 什 么 … …";
						GlobalScript.inst.gameState.allcountries[60].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[60].SubGosstroy = 9;
						GlobalScript.inst.gameState.allcountries[60].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[60].name = "尼 日 利 亚";
						GlobalScript.inst.gameState.allcountries[164].name = "索 科 托 伊 斯 兰 国";
						GlobalScript.inst.gameState.allcountries[164].parts[0] = true;
						GlobalScript.inst.gameState.allcountries[164].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[164].SubGosstroy = 9;
						GlobalScript.inst.gameState.allcountries[164].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[164].Torg = true;
						GlobalScript.inst.gameState.allcountries[164].proprc = true;
						GlobalScript.inst.gameState.influencePRC += 20;
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 1000)
				{
					text = "在 经 历 极 大 烈 度 的 战 争 后 ， 尼 日 利 亚 人 民 军 成 功 占 领 了 首 都 拉 各 斯 ， 最 终 解 放 了 全 国 。 全 尼 日 利 亚 革 命 社 会 主 义 联 盟 宣 布 改 组 为 尼 日 利 亚 革 命 社 会 主 义 先 锋 党 ， 并 成 立 了 尼 日 利 亚 革 命 委 员 会 ， 作 为 新 的 全 国 政 权 。 不 久 ， 尼 日 利 亚 人 民 联 邦 共 和 国 宣 告 成 立 ， 国 家 开 始 恢 复 和 重 建 … …";
					GlobalScript.inst.gameState.allcountries[60].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[60].SubGosstroy = 0;
					GlobalScript.inst.gameState.allcountries[60].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[60].Torg = true;
					GlobalScript.inst.gameState.allcountries[60].proprc = true;
					GlobalScript.inst.gameState.allcountries[60].name = "尼 日 利 亚 人 民 联 邦 共 和 国";
					GlobalScript.inst.gameState.influencePRC += 20;
				}
				else
				{
					text = "政 府 军 获 胜 了 ， 全 尼 日 利 亚 革 命 社 会 主 义 联 盟 也 濒 临 解 体 ， 领 导 人 或 是 出 走 流 亡 ， 或 是 继 续 坚 守 进 行 游 击 运 动 … … 当 权 派 花 费 了 极 大 的 代 价 镇 压 了 尼 日 利 亚 革 命 力 量 ， 以 至 于 尼 日 利 亚 国 家 本 身 都 不 复 存 在 — — 放 权 地 方 部 族 精 英 的 代 价 是 ， 他 们 在 战 后 得 以 利 用 权 力 真 空 彻 底 崛 起 。 如 今 ， 尼 日 利 亚 被 分 裂 为 了 北 方 的 由 穆 罕 默 杜 · 布 哈 里 领 导 的 豪 萨 兰 ， 西 南 的 由 奥 巴 费 米 · 阿 沃 罗 沃 领 导 的 约 鲁 巴 兰 和 东 南 的 由 " + (IsSocialism(yes: true, 66) ? "伊 肯 纳 · 恩 齐 米 罗 领 导 的 残 余 的 人 民 军 力 量" : "伊 梅 卡 · 奥 朱 古") + " 控 制 的 宣 布 将 重 新 开 展 “ 比 夫 拉 革 命 ” 的 比 夫 拉 政 权 。 让 我 们 祝 “ 三 国 ” 人 民 好 运 吧 … …";
					if (IsSocialism(yes: true, 66))
					{
						GlobalScript.inst.gameState.allcountries[60].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[60].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[60].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[60].Torg = true;
						GlobalScript.inst.gameState.allcountries[60].proprc = true;
					}
					else
					{
						GlobalScript.inst.gameState.allcountries[60].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[60].SubGosstroy = 7;
						GlobalScript.inst.gameState.allcountries[60].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[60].puppetOf = 21;
					}
					GlobalScript.inst.gameState.allcountries[60].name = "比 夫 拉";
					GlobalScript.inst.gameState.allcountries[164].name = "豪 萨 兰";
					GlobalScript.inst.gameState.allcountries[164].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[164].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[164].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[164].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[164].Vyshi = true;
					GlobalScript.inst.gameState.allcountries[165].name = "约 鲁 巴 兰";
					GlobalScript.inst.gameState.allcountries[165].parts[0] = true;
					GlobalScript.inst.gameState.allcountries[165].Gosstroy = 3;
					GlobalScript.inst.gameState.allcountries[165].SubGosstroy = 4;
					GlobalScript.inst.gameState.allcountries[165].LeaveAlliances();
					GlobalScript.inst.gameState.influencePRC += 20;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 80)
			{
				GlobalScript.inst.gameState.allcountries[57].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 1000)
				{
					text = " UGNT 的 部 队 成 功 击 退 了 亲 西 方 的 哈 布 雷 势 力 ， 控 制 了 乍 得 全 国 ， 他 们 表 示 ， 全 国 人 民 将 无 论 宗 教 种 族 部 族 一 律 平 等 。 残 余 的 反 政 府 势 力 化 整 为 零 ， 继 续 着 游 击 行 动 。 在 乍 得 政 府 的 邀 请 下 ， 利 比 亚 军 队 再 度 进 驻 乍 得 。||";
					if (resultOfEvents[658] == 2)
					{
						text += string.Format("巩 固 了 势 力 的 艾 哈 迈 德 · 阿 西 尔 宣 布 成 立 乍 得 人 民 社 会 主 义 民 众 国 ， 并 通 过 协 定 确 认 了 奥 祖 地 区 的 主 权 属 于 利 比 亚 。 在 一 场 全 民 公 投 后 ， 卡 扎 菲 和 阿 西 尔 共 同 宣 布 了 两 国 的 “ 联 合 ” ， {0} 两 人 表 示 ： “ 乍 得 是 利 比 亚 的 延 伸 ， 利 比 亚 是 乍 得 的 延 伸 。 两 国 将 永 远 团 结 在 一 起 ， 这 是 泛 阿 拉 伯 主 义 、 泛 非 主 义 和 泛 伊 斯 兰 主 义 的 伟 大 胜 利 ！ ” 尽 管 许 多 非 洲 国 家 以 及 西 方 国 家 反 对 这 一 变 化 ， 甚 至 开 始 扶 持 由 哈 布 雷 领 导 的 “ 乍 得 流 亡 政 府 ” 。 就 让 他 们 去 说 利 比 亚 乍 得 这 也 不 行 ， 那 也 不 行 吧 ， 非 洲 人 民 不 屈 不 挠 的 努 力 必 将 稳 步 地 达 到 自 己 的 胜 利 ！", (allcountries[30].puppetOf == 13 && allcountries[56].puppetOf == 13) ? "为 了 输 出 革 命 的 需 要 ， 两 国 将 进 行 渐 进 统 一 ，" : "组 成 阿 拉 伯 利 比 亚 乍 得 人 民 社 会 主 义 民 众 国， ");
						GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[57].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[57].puppetOf = 13;
						GlobalScript.inst.gameState.allcountries[57].Torg = true;
						GlobalScript.inst.gameState.allcountries[13].name = "阿 拉 伯 利 比 亚 乍 得 人 民 社 会 主 义 民 众 国";
						GlobalScript.inst.gameState.influencePRC += 10;
						if (allcountries[30].puppetOf != 13)
						{
							GlobalScript.inst.gameState.allcountries[13].parts[1] = true;
						}
					}
					else if (allcountries[57].puppetOf == 13)
					{
						text += " 巩 固 了 势 力 的 古 库 尼 · 韦 戴 宣 布 成 立 乍 得 人 民 社 会 主 义 民 众 国 ， 并 通 过 协 定 确 认 了 奥 祖 地 区 的 主 权 属 于 利 比 亚 。 卡 扎 菲 和 古 库 尼 共 同 宣 布 了 两 国 的 “ 联 合 ” ， 两 国 将 以 类 似 邦 联 的 方 式 达 成 同 盟 ， 两 人 表 示 ： “ 乍 得 是 利 比 亚 的 延 伸 ， 利 比 亚 是 乍 得 的 延 伸 。 两 国 将 永 远 团 结 在 一 起 ， 这 是 泛 阿 拉 伯 主 义 、 泛 非 主 义 和 泛 伊 斯 兰 主 义 的 伟 大 胜 利 ！ ”";
						GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[57].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[57].puppetOf = 13;
						GlobalScript.inst.gameState.allcountries[57].Torg = true;
						GlobalScript.inst.gameState.allcountries[57].name = "乍 得 人 民 社 会 主 义 民 众 国";
						GlobalScript.inst.gameState.influencePRC += 10;
					}
					else
					{
						text += " 巩 固 了 势 力 的 古 库 尼 · 韦 戴 宣 布 成 立 由 乍 得 民 族 解 放 阵 线 领 导 的 乍 得 民 主 共 和 国 ， 并 表 示 要 尊 重 乍 得 人 民 的 传 统 并 继 承 易 卜 拉 欣 · 阿 巴 查 的 遗 志 ， 走 有 乍 得 民 族 特 色 的 社 会 主 义 道 路 。 新 政 府 靠 近 了 社 会 主 义 阵 营 ， 开 始 缓 慢 地 进 行 国 家 重 建 。";
						GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 10;
						GlobalScript.inst.gameState.allcountries[57].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[57].Torg = true;
						if (empires[1].relations > influencePRC)
						{
							GlobalScript.inst.gameState.allcountries[57].prosov = true;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[57].proprc = true;
						}
						GlobalScript.inst.gameState.allcountries[57].name = "乍 得 民 主 共 和 国";
						GlobalScript.inst.gameState.influencePRC += 10;
					}
				}
				else
				{
					text = string.Format("北 方 武 装 部 队 得 以 攻 占 首 都 恩 贾 梅 纳 ， 将 古 库 尼 的 势 力 赶 到 了 乍 得 北 方 的 小 部 分 地 区 以 及 奥 祖 地 带 ， 并 趁 着 卡 穆 格 领 导 的 另 一 支 较 大 的 武 装 力 量 发 生 内 讧 之 际 基 本 占 领 了 全 国 。 由 侯 赛 因 · 哈 布 雷 领 导 的 亲 西 方 反 共 专 制 政 权 在 乍 得 站 稳 了 脚 跟 。||在 利 比 亚 的 扶 持 下 ， 古 库 尼 、 卡 穆 格 等 派 别 在 乍 得 北 方 达 伊 宣 布 成 立 民 族 救 国 临 时 政 府 ， 继 续 同 哈 布 雷 政 权 抗 衡 ， 而 美 国{0} 则 送 与 新 政 府 大 量 军 事 援 助 ， 并 积 极 提 供 外 交 支 持 。", IsSocialism(yes: false, 21) ? " 和 法 国" : null);
					GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[57].LeaveAlliances();
					if (IsSocialism(yes: false, 21))
					{
						GlobalScript.inst.gameState.allcountries[57].puppetOf = 21;
					}
					else
					{
						GlobalScript.inst.gameState.allcountries[57].Vyshi = true;
					}
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 82)
			{
				GlobalScript.inst.gameState.allcountries[33].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 1000)
				{
					text = " 缅 甸 军 方 又 一 次 证 明 了 自 己 是 佛 陀 ， 祖 国 ， 血 脉 的 守 护 者 ， 并 依 托 “ 四 切 ” 的 老 一 套 击 退 了 各 路 反 政 府 武 装 ， 将 其 赶 回 了 北 边 贫 瘠 的 山 地 丛 林 。 虽 说 仍 有 零 星 抵 抗 ， 可 在 封 锁 政 策 下 绝 大 多 数 武 装 团 体 的 灭 亡 — — 他 们 只 能 在 毒 贩 、 走 私 者 、 山 大 王 与 彻 底 消 失 间 选 取 其 一 。 然 而 ， 试 图 重 振 合 法 性 的 缅 甸 统 一 之 战 却 讽 刺 的 产 生 了 反 效 果 ： 对 战 争 暴 行 的 指 控 让 缅 甸 自 然 而 然 地 遭 受 了 主 要 国 家 制 裁 ， 并 回 归 国 际 孤 立 。";
					GlobalScript.inst.gameState.influencePRC -= 20;
				}
				else if (resultOfEvents[662] == 2)
				{
					text = $"最 终 ， 克 伦 民 族 联 盟 和 共 产 主 义 者 的 统 一 战 线 取 得 了 胜 利 ， 并 形 成 了 中 立 民 主 社 会 主 义 者 ， 长 期 反 对 吴 努 与 奈 温 路 线 的 政 治 家 ， “ 中 国 人 民 的 老 朋 友 ” 巴 瑞 博 士 和 反 对 缅 军 霸 权 、 在 最 后 战 役 中 以 决 定 性 倒 戈 粉 碎 缅 军 的 温 和 派 将 军 丁 吴 组 织 双 头 政 治 。 以 安 抚 国 内 各 族 。 然 而 ， 撮 合 共 治 的 统 一 战 线 天 然 具 有 不 稳 定 性 ： 缅 甸 的 局 势 似 乎 回 到 了 独 立 初 签 署 《 彬 龙 协 议 》 的 短 暂 多 族 联 合 时 期 — — 而 正 是 该 协 议 的 流 产 拉 开 了 内 战 序 幕 。 他 们 能 抓 住 第 二 次 机 会 吗 ？";
					GlobalScript.inst.gameState.allcountries[33].Gosstroy = 2;
					GlobalScript.inst.gameState.allcountries[33].SubGosstroy = 11;
					GlobalScript.inst.gameState.allcountries[33].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[33].Torg = true;
					GlobalScript.inst.gameState.influencePRC += 15;
				}
				else if (resultOfEvents[662] == 4)
				{
					text = $"最 终 ， 重 组 的 缅 甸 共 产 党 赢 得 了 胜 利 。 欢 呼 的 农 民 和 高 举 “ 清 扫 地 球 ” 漫 画 的 石 油 工 人 队 伍 拉 开 了 缅 甸 的 新 历 史 ： 德 钦 梭 与 敏 拉 也 宽 宣 布 将 基 于 毛 泽 东 思 想 建 立 “ 名 副 其 实 的 缅 甸 社 会 主 义 政 权 ” 并 实 现 “ 空 前 的 民 族 平 等 ” ， 首 先 便 是 实 行 土 地 改 革 、 大 规 模 工 业 化 、 清 算 缅 甸 旧 军 官 队 伍 并 在 清 扫 土 司 的 基 础 上 筹 建 多 民 族 联 邦 的 行 政 基 础 — — 国 际 观 察 家 已 将 缅 甸 革 命 的 胜 利 视 为 中 国 在 东 南 亚 扩 展 影 响 力 的 重 大 里 程 碑 ， 并 好 奇 托 洛 茨 基 主 义 者 将 如 何 治 理 饱 受 民 族 矛 盾 困 扰 的 农 业 古 国 。 援 助 该 国 的 中 国 知 青 们 也 得 以 头 戴 胜 利 者 冠 冕 返 乡 ， 成 就 “ 成 功 版 国 际 纵 队 ” 的 一 段 佳 话 。";
					GlobalScript.inst.gameState.allcountries[33].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[33].SubGosstroy = 18;
					GlobalScript.inst.gameState.allcountries[33].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[33].Torg = true;
					GlobalScript.inst.gameState.allcountries[33].proprc = true;
					data[1] += 100;
					data[3] += 50;
					empires[0].relations -= 100;
					empires[1].relations -= 100;
					GlobalScript.inst.gameState.influencePRC += 20;
				}
				else
				{
					text = $"最 终 ， 缅 甸 共 产 党 赢 得 了 胜 利 。 欢 呼 的 农 民 和 高 举 毛 泽 东 画 像 的 石 油 工 人 队 伍 拉 开 了 缅 甸 的 新 历 史 ： 德 钦 巴 登 顶 宣 布 将 基 于 毛 泽 东 思 想 建 立 “ 名 副 其 实 的 缅 甸 社 会 主 义 政 权 ” 并 实 现 “ 空 前 的 民 族 平 等 ” ， 首 先 便 是 实 行 土 地 改 革 、 大 规 模 工 业 化 、 清 算 缅 甸 旧 军 官 队 伍 并 在 清 扫 土 司 的 基 础 上 筹 建 多 民 族 联 邦 的 行 政 基 础 — — 国 际 观 察 家 已 将 缅 甸 革 命 的 胜 利 视 为 中 国 在 东 南 亚 扩 展 影 响 力 的 重 大 里 程 碑 。 援 助 该 国 的 中 国 知 青 们 也 得 以 头 戴 胜 利 者 冠 冕 返 乡 ， 成 就 “ 成 功 版 国 际 纵 队 ” 的 一 段 佳 话 。";
					GlobalScript.inst.gameState.allcountries[33].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[33].SubGosstroy = 17;
					GlobalScript.inst.gameState.allcountries[33].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[33].Torg = true;
					GlobalScript.inst.gameState.allcountries[33].proprc = true;
					data[1] += 100;
					data[3] += 50;
					empires[0].relations -= 100;
					empires[1].relations -= 100;
					GlobalScript.inst.gameState.influencePRC += 30;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 83)
			{
				GlobalScript.inst.gameState.allcountries[33].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 1000)
				{
					text = " 第 二 次 内 战 以 撮 合 了 缅 甸 共 产 党 东 北 军 区 派 系 ， 亲 缅 共 民 族 地 方 武 装 与 不 满 克 伦 民 族 联 盟 的 缅 族 人 三 者 的 伞 形 组 织 缅 甸 民 主 同 盟 军 取 胜 而 告 终 。 彭 家 声 得 以 凯 旋 果 敢 并 推 出 民 族 新 政 ： 首 先 便 是 意 在 调 整 缅 甸 与 中 国 边 境 的 《 告 全 球 华 人 同 胞 书 》 ， 接 下 来 则 基 于 民 族 正 义 党 整 合 其 他 民 族 地 方 武 装 和 原 缅 甸 社 会 主 义 纲 领 党 成 员 。";
					GlobalScript.inst.gameState.allcountries[33].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[33].SubGosstroy = 9;
					GlobalScript.inst.gameState.allcountries[33].LeaveAlliances();
					if (resultOfEvents[664] == 2)
					{
						GlobalScript.inst.gameState.allcountries[33].Torg = true;
						GlobalScript.inst.gameState.allcountries[33].proprc = true;
						GlobalScript.inst.gameState.influencePRC += 10;
					}
				}
				else
				{
					text = $"第 二 次 内 战 以 反 共 的 全 联 邦 联 盟 军 取 胜 而 告 终 。 在 白 所 成 背 叛 彭 家 声 后 ， 缅 甸 共 产 党 残 部 形 成 的 缅 甸 民 主 同 盟 军 开 始 飞 速 解 体 ， 只 能 组 织 零 碎 的 政 治 抵 抗 。 看 起 来 ， 自 由 主 义 将 在 缅 甸 获 得 完 全 胜 利 ， 这 将 决 定 该 国 的 未 来 … …";
					GlobalScript.inst.gameState.allcountries[33].Gosstroy = 3;
					GlobalScript.inst.gameState.allcountries[33].SubGosstroy = 6;
					GlobalScript.inst.gameState.allcountries[33].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[33].Vyshi = true;
					GlobalScript.inst.gameState.influencePRC -= 10;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 84)
			{
				GlobalScript.inst.gameState.allcountries[141].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 1000)
				{
					if (resultOfEvents[665] == 0)
					{
						text = " 资 本 主 义 的 最 后 堡 垒 做 出 了 困 兽 之 斗 ， 而 这 爆 发 的 力 量 绝 非 巴 拿 马 等 蕞 尔 小 国 所 能 承 受 的 。 美 国 漂 亮 的 拿 下 了 两 个 机 场 ， 并 成 功 确 保 了 阿 马 多 尔 堡 这 一 战 略 要 地 ， 从 而 成 功 将 巴 拿 马 军 队 一 分 为 二 。 托 里 霍 斯 紧 急 动 员 了 民 兵 和 国 防 军 ， 并 在 机 场 的 伏 击 战 中 擒 获 了 五 名 海 豹 突 击 队 队 员 。 但 这 并 不 能 扭 转 败 局 ， 托 里 霍 斯 最 终 在 摄 像 机 下 签 署 了 辞 呈 ， 并 深 深 的 为 自 己 没 能 达 成 目 标 而 忏 悔 。 他 将 被 押 往 美 国 等 候 审 判 。 而 美 国 的 托 管 政 府 早 在 第 一 天 就 组 建 了 起 来 ， 罗 伯 特 · 迪 亚 兹 · 埃 雷 拉 将 军 ， 吉 列 尔 莫 · 恩 达 拉 · 阿 里 亚 斯 和 吉 列 尔 莫 · 福 特 分 别 宣 誓 就 任 共 和 国 总 统 、 第 一 副 总 统 和 第 二 副 总 统 ， 他 们 保 证 不 会 考 虑 巴 拿 马 运 河 问 题 ， 并 允 许 美 国 驻 军 。 但 我 们 都 知 道 他 们 的 背 后 是 谁 … …";
						GlobalScript.inst.gameState.allcountries[141].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[141].SubGosstroy = 7;
						GlobalScript.inst.gameState.allcountries[141].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[141].Vyshi = true;
						GlobalScript.inst.gameState.empires[0].power += 10;
					}
					else
					{
						text = " 资 本 主 义 的 最 后 堡 垒 做 出 了 困 兽 之 斗 ， 而 这 爆 发 的 力 量 绝 非 巴 拿 马 等 蕞 尔 小 国 所 能 承 受 的 。 军 事 行 动 首 先 攻 击 战 略 设 施 ， 如 巴 拿 马 城 蓬 塔 帕 蒂 利 亚 的 民 用 机 场 和 里 奥 哈 托 的 巴 拿 马 军 用 机 场 诺 列 加 也 在 那 里 驻 扎 了 部 队 ， 海 豹 突 击 队 摧 毁 了 诺 列 加 的 私 人 飞 机 ， 并 击 沉 了 一 艘 巴 拿 马 炮 艇 。 巴 拿 马 伏 击 事 件 造 成 四 名 海 豹 突 击 队 员 死 亡 ， 九 人 受 伤 。 美 国 漂 亮 的 拿 下 了 两 个 机 场 ， 并 成 功 确 保 了 阿 马 多 尔 堡 这 一 战 略 要 地 ， 从 而 成 功 将 巴 拿 马 军 队 一 分 为 二 。 诺 列 加 潜 逃 至 梵 蒂 冈 大 使 馆 内 ， 在 谈 判 后 ， 诺 列 加 决 定 投 降 。 而 美 国 的 托 管 政 府 早 在 第 一 天 就 组 建 了 起 来 ， 罗 伯 特 · 迪 亚 兹 · 埃 雷 拉 将 军 ， 吉 列 尔 莫 · 恩 达 拉 · 阿 里 亚 斯 和 吉 列 尔 莫 · 福 特 分 别 宣 誓 就 任 共 和 国 总 统 、 第 一 副 总 统 和 第 二 副 总 统 ， 他 们 保 证 不 会 考 虑 巴 拿 马 运 河 问 题 ， 并 允 许 美 国 驻 军 。 但 我 们 都 知 道 他 们 的 背 后 是 谁 … …";
						GlobalScript.inst.gameState.allcountries[141].Gosstroy = 0;
						GlobalScript.inst.gameState.allcountries[141].SubGosstroy = 13;
						GlobalScript.inst.gameState.allcountries[141].LeaveAlliances();
						GlobalScript.inst.gameState.allcountries[141].Vyshi = true;
						GlobalScript.inst.gameState.empires[0].power += 10;
					}
				}
				else if (resultOfEvents[665] == 0)
				{
					text = " 帝 国 主 义 放 几 门 炮 开 几 枪 就 能 摧 毁 一 个 政 权 的 时 代 结 束 了 。 在 巴 拿 马 全 国 一 致 的 决 心 下 ， 美 国 的 骇 人 轰 炸 并 未 带 来 多 少 优 势 。 而 托 里 霍 斯 裹 着 国 旗 举 枪 射 击 的 标 志 性 镜 头 进 一 步 增 加 了 巴 拿 马 人 民 的 抵 抗 意 志 ， 人 民 战 斗 团 击 落 了 一 架 美 国 军 机 ， 而 古 巴 志 愿 者 和 巴 拿 马 国 防 军 携 手 击 退 了 海 军 陆 战 队 针 对 科 隆 的 突 袭 。 美 国 军 队 并 没 能 确 保 对 里 奥 哈 托 机 场 的 占 领 ， 美 洲 大 桥 也 被 提 前 炸 毁 。 美 国 的 战 略 目 的 完 全 失 败 ， 最 终 只 得 宣 布 行 动 的 “ 阶 段 性 胜 利 ” 。 事 实 上 就 是 战 败 。||而 这 也 给 托 里 霍 斯 带 来 了 无 上 荣 光 ， 欢 快 的 人 民 举 着 将 军 的 画 像 走 在 巴 拿 马 的 大 街 小 巷 。 以 巴 拿 马 共 产 党 — — 马 克 思 列 宁 主 义 ，11 月29 日 民 族 解 放 运 动 ， 中 美 洲 工 人 革 命 党 的 巴 拿 马 支 部 等 革 命 左 翼 组 织 签 署 了 谅 解 协 定 。 认 可 了 以 托 里 霍 斯 为 首 的 “ 进 步 民 族 资 产 阶 级 可 以 指 导 巴 拿 马 革 命 ” ， 宣 布 以 巴 拿 马 阵 线 的 身 份 和 民 主 革 命 党 合 并 。 这 确 保 了 托 里 霍 斯 在 该 国 的 左 翼 知 识 分 子 和 工 人 的 地 位 。||而 在 胜 利 日 的 演 讲 上 ， 托 里 霍 斯 向 人 民 发 出 了 如 此 呼 吁 ： “ 我 曾 向 你 们 保 证 ， 我 们 从 来 ， 不 是 更 不 会 是 一 个 联 合 州 。 事 实 也 再 次 证 明 ， 帝 国 主 义 死 心 不 改 ， 不 撞 南 墙 不 回 头 。 而 我 们 的 革 命 恰 恰 是 触 怒 了 像 美 国 这 样 的 帝 国 主 义 国 家 。 这 更 说 明 了 我 们 要 走 社 会 主 义 的 道 路 ， 民 族 主 义 的 道 路 。 只 有 这 样 才 能 保 护 我 们 的 祖 国 不 被 欺 辱 ， 我 是 穷 苦 人 的 孩 子 ， 我 最 知 道 社 会 主 义 的 好 。 我 在 这 里 代 表 千 千 万 万 的 巴 拿 马 人 民 发 出 呐 喊 ： 美 国 殖 民 地 ？ 不 ！ 社 会 主 义 祖 国 ？ 是 的 ！ 运 河 是 巴 拿 马 人 民 的 ， 不 是 扬 基 佬 的 ！ ”";
					GlobalScript.inst.gameState.allcountries[141].Gosstroy = 1;
					GlobalScript.inst.gameState.allcountries[141].SubGosstroy = 1;
					GlobalScript.inst.gameState.allcountries[141].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[141].proprc = true;
					GlobalScript.inst.gameState.allcountries[141].Torg = true;
					GlobalScript.inst.gameState.influencePRC += 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
				}
				else
				{
					text = " 帝 国 主 义 放 几 门 炮 开 几 枪 就 能 摧 毁 一 个 政 权 的 时 代 结 束 了 。 诺 列 加 政 权 凭 借 “ 保 卫 我 们 的 运 河 ” 的 爱 国 口 号 动 员 了 足 够 的 抵 抗 者 ， 美 国 意 图 夺 取 机 场 的 行 动 遭 到 了 强 烈 的 抵 抗 。 在 托 里 霍 斯 港 的 阻 击 战 中 ， 美 国 巡 逻 艇 更 是 被 巴 拿 马 的 飞 鱼 导 弹 所 击 沉 。 既 然 战 略 目 的 没 能 达 成 ， 美 军 只 得 宣 布 行 动 失 败 。||在 漫 长 而 残 酷 的 战 争 过 后 ， 这 个 小 国 还 是 成 功 抵 御 住 了 来 自 咫 尺 之 遥 的 帝 国 主 义 的 侵 略 ， 将 源 源 不 断 的 美 军 驱 逐 出 了 巴 拿 马 。 当 然 ， 入 侵 者 留 下 的 是 一 个 满 目 疮 痍 的 国 家 。 断 水 断 电 ， 基 建 尽 数 被 毁 。 重 建 之 路 还 很 漫 长 ， 而 毒 贩 和 外 国 雇 佣 军 也 借 此 机 会 扎 根 与 这 个 小 国 内 。 很 难 说 谁 才 是 胜 者 … …";
					GlobalScript.inst.gameState.allcountries[141].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[141].proprc = true;
					GlobalScript.inst.gameState.allcountries[141].Torg = true;
					GlobalScript.inst.gameState.influencePRC += 10;
					GlobalScript.inst.gameState.empires[0].power -= 10;
				}
			}
			else if (GlobalScript.inst.gameState.data[82] == 85)
			{
				GlobalScript.inst.gameState.allcountries[58].parts[0] = false;
				if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl2 >= 900)
				{
					text = " 布 基 纳 法 索 利 用 游 击 战 和 人 民 战 争 的 经 验 ， 在 经 过 战 略 防 御 阶 段 ， 击 退 了 马 里 的 进 攻 后 ， 于 阿 加 彻 地 带 实 现 了 战 略 相 持 ， 最 终 使 得 军 队 和 民 兵 在 国 际 志 愿 者 的 帮 助 下 实 现 了 战 略 反 攻 ， 成 功 占 领 马 里 边 境 重 镇 — — 锡 卡 索 大 区 的 首 府 锡 卡 索 市 ， 并 拿 下 了 整 个 阿 加 彻 地 带 。 最 终 ， 特 拉 奥 雷 不 得 不 屈 服 ， 耻 辱 地 宣 布 同 布 基 纳 法 索 议 和 ， 赔 款 并 承 认 阿 加 彻 地 带 属 于 布 基 纳 法 索 。 布 基 纳 法 索 领 导 层 就 此 成 功 实 现 全 国 人 民 凝 聚 于 桑 卡 拉 的 革 命 大 旗 之 下 ， 开 始 进 行 统 一 先 锋 政 党 的 筹 备 ， 推 进 军 事 革 命 政 权 向 先 锋 队 式 的 社 会 主 义 政 权 的 转 型 。||马 里 的 战 败 极 大 地 打 击 了 特 拉 奥 雷 的 威 望 ， 并 使 得 该 国 本 就 不 算 平 稳 的 经 济 和 政 治 局 势 雪 上 加 霜 。 骚 乱 和 抗 议 逐 渐 在 马 里 全 国 各 地 爆 发 。 民 主 派 组 织 、 学 生 、 工 会 联 合 发 起 全 国 性 大 规 模 示 威 ， 巴 马 科 成 为 抗 议 核 心 。 示 威 者 立 起 街 垒 ， 洗 劫 并 焚 烧 多 个 政 府 部 门 大 楼 、 世 界 银 行 驻 马 办 事 处 ， 与 军 队 发 生 激 烈 冲 突 。 军 方 动 用 机 枪 扫 射 ， 造 成30 人 死 亡 。 特 拉 奥 雷 发 表 全 国 讲 话 ， 呼 吁 冷 静 ， 承 诺 召 开 民 盟 大 会 讨 论 多 党 制 ， 并 在 主 要 城 市 宣 布 紧 急 状 态 （ 凯 斯 、 塞 古 、 莫 普 提 、 锡 卡 索 等 城 市 同 步 爆 发 示 威 ） 。";
					if (IsSocialism(yes: false, 1) || !modifies[6].active || !allcountries[20].proprc)
					{
						text += " |但 是 人 民 已 经 无 法 继 续 等 待 了 。 示 威 升 级 为 暴 力 骚 乱 ， 示 威 者 （ 含 学 生 、 失 业 青 年 、 底 层 民 众 ） 攻 击 政 府 官 员 住 宅 ， 教 育 部 长 巴 卡 里 · 特 拉 奥 雷 被 示 威 者 殴 打 致 死 并 焚 烧 尸 体 ， 海 关 局 长 （ 特 拉 奥 雷 妻 子 的 兄 弟 ） 也 遭 杀 害 。 军 队 再 次 武 力 镇 压 ， 多 地 出 现 纵 火 、 抢 劫 事 件 ， 伤 亡 人 数 持 续 上 升 。 当 日 ， 各 民 主 派 组 织 与 工 会 成 立 “ 民 主 协 会 与 组 织 协 调 委 员 会 （CCAOD ） ” ， 统 一 协 调 抗 议 行 动 。 次 日 ，CCAOD 向 特 拉 奥 雷 政 权 发 出 最 后 通 牒 ， 要 求 其 立 即 辞 职 。 数 千 民 众 聚 集 在 劳 工 部 大 楼 前 抗 议 ， 巴 马 科 商 业 中 心 发 生 骚 乱 与 火 灾 ，65 人 死 亡 。 反 对 派 宣 布 发 起48 小 时 全 国 总 罢 工 ， 瘫 痪 社 会 运 转 。 政 府 与 反 对 派 短 暂 谈 判 ， 同 意 解 除 宵 禁 、 释 放3 月22 -23 日 骚 乱 中 被 捕 人 员 ， 但 拒 绝 特 拉 奥 雷 辞 职 要 求 ， 谈 判 破 裂 。 第 二 天 ， 伞 兵 部 队 指 挥 官 阿 马 杜 · 图 马 尼 · 杜 尔 中 校 率 部 发 动 军 事 政 变 ， 控 制 总 统 府 、 国 家 广 播 电 台 等 关 键 机 构 ， 宣 布 推 翻 穆 萨 · 特 拉 奥 雷 政 权 。 当 日 成 立 “ 人 民 救 国 过 渡 委 员 会 ” ， 召 开 全 国 会 议 ， 制 定 新 宪 法 。 在 不 久 后 举 行 的 首 次 多 党 总 统 选 举 中 ， 由 来 自 苏 丹 联 盟 - 非 洲 民 主 联 盟 、 马 里 革 命 与 民 主 党 、 马 里 劳 动 党 和 马 里 民 主 人 民 阵 线 等 左 翼 组 织 组 成 的 伞 式 政 党 马 里 民 主 联 盟 - 非 洲 团 结 正 义 党 的 阿 尔 法 · 奥 马 尔 · 科 纳 雷 当 选 为 新 总 统 ， 马 里 第 三 共 和 国 成 立 。";
						if (empires[0].power > empires[1].power)
						{
							GlobalScript.inst.gameState.allcountries[58].Gosstroy = 3;
							GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 4;
							GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
							GlobalScript.inst.gameState.empires[0].power += 10;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[58].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 3;
							GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
							GlobalScript.inst.gameState.empires[1].power += 10;
						}
					}
					else if (resultOfEvents[672] == 0)
					{
						if (resultOfEvents[458] == 2)
						{
							text += " |在 此 情 况 下 ， 全 国 人 民 民 主 阵 线 已 经 明 白 不 必 再 对 特 拉 奥 雷 政 府 抱 有 任 何 幻 想 ， 决 定 发 动 起 义 。 马 里 全 国 学 生 与 学 徒 联 盟 和 马 里 全 国 工 人 联 盟 发 动 了 全 国 性 的 大 罢 课 与 大 罢 工 ， 马 里 劳 动 党 、 马 里 革 命 与 民 主 党 和 苏 丹 联 盟 - 非 洲 民 主 联 盟 也 开 始 发 动 全 国 大 起 义 ， 无 尽 的 镇 压 早 已 让 军 警 无 法 忍 受 ， 导 致 他 们 向 革 命 派 倒 戈 ， 加 入 了 起 义 队 伍 。 很 快 ， 人 民 突 击 队 也 占 领 了 军 火 库 ， 将 武 器 分 发 给 民 众 ， 编 成 协 助 起 义 军 行 动 的 人 民 民 兵 。 经 过 激 战 ， 起 义 部 队 攻 入 官 员 住 宅 ， 占 领 政 府 大 楼 ， 当 场 抓 获 了 企 图 乔 装 潜 逃 的 穆 萨 · 特 拉 奥 雷 。";
							GlobalScript.inst.gameState.allcountries[58].Torg = true;
							if (allcountries[61].prosov || allcountries[1].isSEV)
							{
								text += " |随 后 ， 全 国 人 民 民 主 阵 线 成 立 了 由 阿 卜 杜 拉 耶 · 巴 里 、 谢 赫 · 普 莱 阿 和 马 马 杜 · 拉 明 · 特 拉 奥 雷 等 人 集 体 领 导 的 全 国 保 卫 革 命 委 员 会 ， 宣 布 成 立 马 里 民 主 共 和 国 ， 以 马 里 革 命 与 民 主 党 为 核 心 ， 与 马 里 劳 动 党 、 苏 丹 联 盟 - 非 洲 民 主 联 盟 和 马 里 民 主 人 民 阵 线 等 政 党 一 起 成 立 了 统 一 的 先 锋 党 — — 马 里 社 会 主 义 团 结 党 ， 马 里 全 国 学 生 与 学 徒 联 盟 与 马 里 全 国 工 人 联 盟 则 成 为 其 领 导 的 群 众 组 织 ， 开 始 带 领 人 民 进 行 人 民 民 主 革 命 ， 延 续 凯 塔 的 未 竟 事 业 。";
								GlobalScript.inst.gameState.allcountries[58].Gosstroy = 1;
								GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 1;
								GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
								GlobalScript.inst.gameState.allcountries[58].prosov = true;
								GlobalScript.inst.gameState.allcountries[58].name = "马 里 民 主 共 和 国";
								GlobalScript.inst.gameState.empires[0].power += 10;
							}
							else
							{
								text += " |随 后 ， 全 国 人 民 民 主 阵 线 成 立 了 由 穆 罕 默 德 · 塔 布 雷 、 约 罗 · 迪 亚 凯 特 、 谢 赫 · 奥 马 尔 · 西 索 科 、 伊 萨 · 恩 迪 亚 耶 和 穆 罕 默 德 · 拉 明 · 加 库 等 人 集 体 领 导 的 全 国 保 卫 革 命 委 员 会 ， 宣 布 成 立 马 里 人 民 共 和 国 ， 以 马 里 劳 动 党 为 核 心 ， 与 马 里 革 命 与 民 主 党 、 苏 丹 联 盟 - 非 洲 民 主 联 盟 和 马 里 民 主 人 民 阵 线 等 政 党 一 起 成 立 了 统 一 的 先 锋 党 — — 马 里 共 产 党 ， 马 里 全 国 学 生 与 学 徒 联 盟 与 马 里 全 国 工 人 联 盟 则 成 为 其 领 导 的 群 众 组 织 ， 开 始 带 领 人 民 进 行 人 民 民 主 革 命 ， 延 续 凯 塔 的 未 竟 事 业 。";
								GlobalScript.inst.gameState.allcountries[58].Gosstroy = 1;
								GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 2;
								GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
								GlobalScript.inst.gameState.allcountries[58].proprc = true;
								GlobalScript.inst.gameState.allcountries[58].name = "马 里 人 民 共 和 国";
								GlobalScript.inst.gameState.empires[0].power += 10;
							}
						}
						else
						{
							text += " |但 是 人 民 已 经 无 法 继 续 等 待 了 。 示 威 升 级 为 暴 力 骚 乱 ， 示 威 者 （ 含 学 生 、 失 业 青 年 、 底 层 民 众 ） 攻 击 政 府 官 员 住 宅 ， 教 育 部 长 巴 卡 里 · 特 拉 奥 雷 被 示 威 者 殴 打 致 死 并 焚 烧 尸 体 ， 海 关 局 长 （ 特 拉 奥 雷 妻 子 的 兄 弟 ） 也 遭 杀 害 。 军 队 再 次 武 力 镇 压 ， 多 地 出 现 纵 火 、 抢 劫 事 件 ， 伤 亡 人 数 持 续 上 升 。 当 日 ， 各 民 主 派 组 织 与 工 会 成 立 “ 民 主 协 会 与 组 织 协 调 委 员 会 （CCAOD ） ” ， 统 一 协 调 抗 议 行 动 。 次 日 ，CCAOD 向 特 拉 奥 雷 政 权 发 出 最 后 通 牒 ， 要 求 其 立 即 辞 职 。 数 千 民 众 聚 集 在 劳 工 部 大 楼 前 抗 议 ， 巴 马 科 商 业 中 心 发 生 骚 乱 与 火 灾 ，65 人 死 亡 。 反 对 派 宣 布 发 起48 小 时 全 国 总 罢 工 ， 瘫 痪 社 会 运 转 。 政 府 与 反 对 派 短 暂 谈 判 ， 同 意 解 除 宵 禁 、 释 放3 月22 -23 日 骚 乱 中 被 捕 人 员 ， 但 拒 绝 特 拉 奥 雷 辞 职 要 求 ， 谈 判 破 裂 。 第 二 天 ， 伞 兵 部 队 指 挥 官 阿 马 杜 · 图 马 尼 · 杜 尔 中 校 率 部 发 动 军 事 政 变 ， 控 制 总 统 府 、 国 家 广 播 电 台 等 关 键 机 构 ， 宣 布 推 翻 穆 萨 · 特 拉 奥 雷 政 权 。 当 日 成 立 “ 人 民 救 国 过 渡 委 员 会 ” ， 召 开 全 国 会 议 ， 制 定 新 宪 法 。 在 不 久 后 举 行 的 首 次 多 党 总 统 选 举 中 ， 由 来 自 苏 丹 联 盟 - 非 洲 民 主 联 盟 、 马 里 革 命 与 民 主 党 、 马 里 劳 动 党 和 马 里 民 主 人 民 阵 线 等 左 翼 组 织 组 成 的 伞 式 政 党 马 里 民 主 联 盟 - 非 洲 团 结 正 义 党 的 阿 尔 法 · 奥 马 尔 · 科 纳 雷 当 选 为 新 总 统 ， 马 里 第 三 共 和 国 成 立 。";
							if (empires[0].power > empires[1].power)
							{
								GlobalScript.inst.gameState.allcountries[58].Gosstroy = 3;
								GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 4;
								GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
								GlobalScript.inst.gameState.empires[0].power += 10;
							}
							else
							{
								GlobalScript.inst.gameState.allcountries[58].Gosstroy = 2;
								GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 3;
								GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
								GlobalScript.inst.gameState.empires[1].power += 10;
							}
						}
					}
					else
					{
						text += " |但 是 人 民 已 经 无 法 继 续 等 待 了 。 示 威 升 级 为 暴 力 骚 乱 ， 示 威 者 （ 含 学 生 、 失 业 青 年 、 底 层 民 众 ） 攻 击 政 府 官 员 住 宅 ， 教 育 部 长 巴 卡 里 · 特 拉 奥 雷 被 示 威 者 殴 打 致 死 并 焚 烧 尸 体 ， 海 关 局 长 （ 特 拉 奥 雷 妻 子 的 兄 弟 ） 也 遭 杀 害 。 军 队 再 次 武 力 镇 压 ， 多 地 出 现 纵 火 、 抢 劫 事 件 ， 伤 亡 人 数 持 续 上 升 。 当 日 ， 各 民 主 派 组 织 与 工 会 成 立 “ 民 主 协 会 与 组 织 协 调 委 员 会 （CCAOD ） ” ， 统 一 协 调 抗 议 行 动 。 次 日 ，CCAOD 向 特 拉 奥 雷 政 权 发 出 最 后 通 牒 ， 要 求 其 立 即 辞 职 。 数 千 民 众 聚 集 在 劳 工 部 大 楼 前 抗 议 ， 巴 马 科 商 业 中 心 发 生 骚 乱 与 火 灾 ，65 人 死 亡 。 反 对 派 宣 布 发 起48 小 时 全 国 总 罢 工 ， 瘫 痪 社 会 运 转 。 政 府 与 反 对 派 短 暂 谈 判 ， 同 意 解 除 宵 禁 、 释 放3 月22 -23 日 骚 乱 中 被 捕 人 员 ， 但 拒 绝 特 拉 奥 雷 辞 职 要 求 ， 谈 判 破 裂 。 第 二 天 ， 伞 兵 部 队 指 挥 官 阿 马 杜 · 图 马 尼 · 杜 尔 中 校 率 部 发 动 军 事 政 变 ， 控 制 总 统 府 、 国 家 广 播 电 台 等 关 键 机 构 ， 宣 布 推 翻 穆 萨 · 特 拉 奥 雷 政 权 。 当 日 成 立 “ 人 民 救 国 过 渡 委 员 会 ” ， 召 开 全 国 会 议 ， 制 定 新 宪 法 。 在 不 久 后 举 行 的 首 次 多 党 总 统 选 举 中 ， 由 来 自 苏 丹 联 盟 - 非 洲 民 主 联 盟 、 马 里 革 命 与 民 主 党 、 马 里 劳 动 党 和 马 里 民 主 人 民 阵 线 等 左 翼 组 织 组 成 的 伞 式 政 党 马 里 民 主 联 盟 - 非 洲 团 结 正 义 党 的 阿 尔 法 · 奥 马 尔 · 科 纳 雷 当 选 为 新 总 统 ， 马 里 第 三 共 和 国 成 立 。";
						if (empires[0].power > empires[1].power)
						{
							GlobalScript.inst.gameState.allcountries[58].Gosstroy = 3;
							GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 4;
							GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
							GlobalScript.inst.gameState.empires[0].power += 10;
						}
						else
						{
							GlobalScript.inst.gameState.allcountries[58].Gosstroy = 2;
							GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 3;
							GlobalScript.inst.gameState.allcountries[58].LeaveAlliances();
							GlobalScript.inst.gameState.empires[1].power += 10;
						}
					}
				}
				else if (GlobalScript.inst.gameState.ingamewars[GlobalScript.inst.gameState.data[82]].infl1 >= 900)
				{
					text = " 尽 管 布 基 纳 法 索 组 织 了 坚 决 的 抵 抗 ， 但 是 仍 不 敌 马 里 军 队 的 强 势 推 进 。 在 攻 占 该 国 第 二 大 城 市 博 博 - 迪 乌 拉 索 市 后 ， 马 里 的 三 大 作 战 集 群 在 此 集 结 ， 联 合 布 基 纳 法 索 反 对 派 向 该 国 的 首 都 推 进 。 在 经 过 一 场 血 战 后 ， 马 里 占 领 了 瓦 加 杜 古 ， 全 国 革 命 委 员 会 大 部 分 高 层 ， 包 括 托 马 斯 · 桑 卡 拉 与 布 莱 斯 · 孔 波 雷 等 都 战 死 殉 国 。||最 终 ， 反 对 革 命 的 桑 卡 拉 同 学 和 前 同 事 ， 毕 业 于 圣 西 尔 军 校 的 洛 纳 · 夏 尔 · 瓦 塔 拉 成 为 了 领 导 各 反 对 派 联 合 政 府 的 首 脑 ， 同 马 里 签 订 了 和 平 协 定 ， 承 认 两 国 争 议 的 阿 加 彻 地 带 完 全 属 于 马 里 ， 查 封 了 支 持 革 命 的 各 政 党 ， 开 始 在 占 领 军 的 注 视 下 带 领 上 沃 尔 特 迎 回 法 非 的 秩 序 井 然 。 击 败 了 敌 人 的 马 里 政 府 空 前 地 巩 固 了 他 们 的 威 望 。 ";
					GlobalScript.inst.gameState.allcountries[61].Gosstroy = 0;
					GlobalScript.inst.gameState.allcountries[61].SubGosstroy = 7;
					GlobalScript.inst.gameState.allcountries[61].LeaveAlliances();
					GlobalScript.inst.gameState.allcountries[61].puppetOf = 21;
					if (resultOfEvents[672] == 1)
					{
						GlobalScript.inst.gameState.allcountries[61].Torg = true;
					}
				}
				else
				{
					text = " 在 经 过 多 日 的 拉 锯 战 后 ， 双 方 明 白 难 以 达 成 实 际 的 战 果 ， 在 非 洲 多 国 斡 旋 下 达 成 停 火 。 此 时 马 里 已 占 领 阿 加 彻 地 带 大 部 分 区 域 。 这 场 冲 突 造 成 多 名 布 基 纳 法 索 军 民 和 马 里 军 民 丧 生 ， 双 方 均 有 战 俘 被 处 决 ， 布 基 纳 法 索 多 座 城 镇 遭 重 创 。 后 续 两 国 完 成 战 俘 交 换 ，1986 年3 月 西 非 经 济 共 同 体 峰 会 促 成 双 方 和 解 ，6 月 恢 复 正 式 外 交 关 系 。||停 火 后 两 国 均 向 国 际 法 院 申 请 临 时 措 施 ， 法 院 建 议 双 方 继 续 调 解 并 避 免 冲 突 。1986 年12 月 ， 国 际 法 院 将 争 议 领 土 划 分 给 两 国 ， 马 里 获 得 西 部 人 口 密 集 区 ， 布 基 纳 法 索 获 得 以 贝 利 河 为 中 心 的 东 部 地 区 ， 两 国 均 对 裁 决 表 示 满 意 。 这 场 被 布 基 纳 法 索 称 为 “ 圣 诞 战 争 ” 的 冲 突 ， 是 西 非 非 殖 民 化 后 唯 一 一 场 因 领 土 爆 发 的 全 面 国 家 间 战 争 ";
				}
			}
		}
		return false;
	}

	public void FixSubs()
	{
		for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
		{
			if (i < 71 || i > 83)
			{
				if (GlobalScript.inst.gameState.allcountries[i].Gosstroy != 0 && (GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 0 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 7 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 9 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 10 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 13 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 19))
				{
					GlobalScript.inst.gameState.allcountries[i].Gosstroy = 0;
				}
				else if (GlobalScript.inst.gameState.allcountries[i].Gosstroy != 1 && (GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 1 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 2 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 16 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 17 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 18))
				{
					GlobalScript.inst.gameState.allcountries[i].Gosstroy = 1;
				}
				else if (GlobalScript.inst.gameState.allcountries[i].Gosstroy != 2 && (GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 3 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 8 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 11 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 15 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 14))
				{
					GlobalScript.inst.gameState.allcountries[i].Gosstroy = 2;
				}
				else if (GlobalScript.inst.gameState.allcountries[i].Gosstroy != 3 && (GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 4 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 5 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 6 || GlobalScript.inst.gameState.allcountries[i].SubGosstroy == 12))
				{
					GlobalScript.inst.gameState.allcountries[i].Gosstroy = 3;
				}
			}
		}
	}

	public void FixAlliances()
	{
		for (int i = 0; i < GlobalScript.inst.gameState.allcountries.Length; i++)
		{
			if (GlobalScript.inst.gameState.allcountries[i].isSEV)
			{
				GlobalScript.inst.gameState.allcountries[i].econ = false;
				GlobalScript.inst.gameState.allcountries[i].isEU = false;
				GlobalScript.inst.gameState.allcountries[i].isSocEU = false;
				GlobalScript.inst.gameState.allcountries[i].isASEAN = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].econ)
			{
				GlobalScript.inst.gameState.allcountries[i].isSEV = false;
				GlobalScript.inst.gameState.allcountries[i].isEU = false;
				GlobalScript.inst.gameState.allcountries[i].isSocEU = false;
				GlobalScript.inst.gameState.allcountries[i].isASEAN = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].isEU)
			{
				GlobalScript.inst.gameState.allcountries[i].isSEV = false;
				GlobalScript.inst.gameState.allcountries[i].econ = false;
				GlobalScript.inst.gameState.allcountries[i].isSocEU = false;
				GlobalScript.inst.gameState.allcountries[i].isASEAN = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].isSocEU)
			{
				GlobalScript.inst.gameState.allcountries[i].isSEV = false;
				GlobalScript.inst.gameState.allcountries[i].econ = false;
				GlobalScript.inst.gameState.allcountries[i].isEU = false;
				GlobalScript.inst.gameState.allcountries[i].isASEAN = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].isASEAN)
			{
				GlobalScript.inst.gameState.allcountries[i].isSEV = false;
				GlobalScript.inst.gameState.allcountries[i].econ = false;
				GlobalScript.inst.gameState.allcountries[i].isEU = false;
				GlobalScript.inst.gameState.allcountries[i].isSocEU = false;
			}
			if (GlobalScript.inst.gameState.allcountries[i].isOVD)
			{
				GlobalScript.inst.gameState.allcountries[i].okb = false;
				GlobalScript.inst.gameState.allcountries[i].isNATO = false;
				GlobalScript.inst.gameState.allcountries[i].isSEATO = false;
				GlobalScript.inst.gameState.allcountries[i].isSENTO = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].okb)
			{
				GlobalScript.inst.gameState.allcountries[i].isOVD = false;
				GlobalScript.inst.gameState.allcountries[i].isNATO = false;
				GlobalScript.inst.gameState.allcountries[i].isSEATO = false;
				GlobalScript.inst.gameState.allcountries[i].isSENTO = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].isNATO)
			{
				GlobalScript.inst.gameState.allcountries[i].okb = false;
				GlobalScript.inst.gameState.allcountries[i].isOVD = false;
				GlobalScript.inst.gameState.allcountries[i].isSEATO = false;
				GlobalScript.inst.gameState.allcountries[i].isSENTO = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].isSEATO)
			{
				GlobalScript.inst.gameState.allcountries[i].isOVD = false;
				GlobalScript.inst.gameState.allcountries[i].isNATO = false;
				GlobalScript.inst.gameState.allcountries[i].okb = false;
				GlobalScript.inst.gameState.allcountries[i].isSENTO = false;
			}
			else if (GlobalScript.inst.gameState.allcountries[i].isSENTO)
			{
				GlobalScript.inst.gameState.allcountries[i].isOVD = false;
				GlobalScript.inst.gameState.allcountries[i].isNATO = false;
				GlobalScript.inst.gameState.allcountries[i].isSEATO = false;
				GlobalScript.inst.gameState.allcountries[i].okb = false;
			}
		}
	}

	public int ChineseSubGosstroy()
	{
		if (allcountries[1].Gosstroy == 0)
		{
			if (event_done[912] && resultOfEvents[912] == 0)
			{
				return 19;
			}
			if (event_done[503] && resultOfEvents[503] == 0)
			{
				return 10;
			}
			if (data[14] <= 2 && data[16] < 13 && data[6] >= 700 && data[15] < 8 && modifies[6].active && modifies[3].active)
			{
				return 0;
			}
			if ((data[16] >= 13 && data[31] >= 700 && !modifies[6].active) || modifies[38].active)
			{
				return 9;
			}
			if (data[16] <= 13 && data[31] >= 700 && data[6] >= 700 && (modifies[6].active || modifies[3].active))
			{
				return 10;
			}
			if (data[16] >= 13 && !modifies[6].active)
			{
				return 7;
			}
			return 13;
		}
		if (allcountries[1].Gosstroy == 1)
		{
			if (GlobalScript.inst.gameState.modifies[49].active)
			{
				return 18;
			}
			if (modifies[6].active && modifies[3].active && GlobalScript.inst.gameState.data[15] <= 7 && GlobalScript.inst.gameState.data[16] <= 12 && GlobalScript.inst.gameState.data[50] <= 25)
			{
				return 17;
			}
			if (data[14] == 1 && !modifies[6].active && data[50] <= 26)
			{
				return 16;
			}
			if (data[16] < 13 && data[17] >= 17 && data[14] == 1 && data[50] <= 26)
			{
				return 2;
			}
			return 1;
		}
		if (allcountries[1].Gosstroy == 2)
		{
			if (data[14] >= 2 && data[16] >= 13 && data[6] <= 700 && data[15] >= 8 && data[17] >= 18 && !allcountries[1].isOVD)
			{
				return 14;
			}
			if (data[14] <= 3 && data[16] >= 12 && data[16] <= 13 && data[6] >= 300 && data[18] > 21 && data[31] >= 700)
			{
				return 11;
			}
			if (data[14] <= 3 && data[16] <= 14 && data[6] >= 500 && data[16] > 11 && data[31] >= 400)
			{
				return 8;
			}
			if (data[14] <= 3 && data[16] <= 13 && data[17] > 17)
			{
				return 3;
			}
			return 15;
		}
		if (allcountries[1].Gosstroy != 3)
		{
			return 13;
		}
		if (data[16] <= 13 && data[6] >= 500)
		{
			return 4;
		}
		if ((data[15] <= 8 && data[17] <= 18) || data[31] >= 700)
		{
			return 12;
		}
		if (data[16] > 13 && data[6] < 700)
		{
			return 6;
		}
		return 5;
	}

	public int AfricanSubGosstroy(int Gosstroy)
	{
		if (Gosstroy != 0)
		{
			switch (Gosstroy)
			{
			case 1:
				switch (UnityEngine.Random.Range(0, 3))
				{
				case 0:
					return 1;
				case 1:
					return 2;
				case 2:
					return 16;
				}
				break;
			case 2:
				switch (UnityEngine.Random.Range(0, 5))
				{
				case 0:
					return 3;
				case 1:
					return 8;
				case 2:
					return 11;
				case 3:
					return 14;
				case 4:
					return 15;
				}
				break;
			case 3:
				switch (UnityEngine.Random.Range(0, 4))
				{
				case 0:
					return 4;
				case 1:
					return 5;
				case 2:
					return 6;
				case 3:
					return 12;
				}
				break;
			}
			return 13;
		}
		return UnityEngine.Random.Range(0, 6) switch
		{
			0 => 0, 
			1 => 7, 
			2 => 9, 
			3 => 10, 
			_ => 13, 
		};
	}

	public int FindPerson(int name1, int name2, int trait0, int trait1, int trait2)
	{
		int result = -1;
		for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
		{
			if (GlobalScript.inst.gameState.politics[i] != null && GlobalScript.inst.gameState.politics[i].name_1 == name1 && GlobalScript.inst.gameState.politics[i].name_2 == name2 && GlobalScript.inst.gameState.politics[i].traits[0] == trait0 && GlobalScript.inst.gameState.politics[i].traits[1] == trait1 && GlobalScript.inst.gameState.politics[i].traits[2] == trait2)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	public float ChangeOfKilling(int politic)
	{
		float num = 0.5f;
		num = ((GlobalScript.inst.gameState.data[9] + GlobalScript.inst.gameState.data[1] + GlobalScript.inst.gameState.data[22] < GlobalScript.inst.gameState.politics[politic].power) ? (num - 0.05f) : (num + 0.05f));
		if (GlobalScript.inst.gameState.data[9] + GlobalScript.inst.gameState.data[1] >= GlobalScript.inst.gameState.politics[politic].power)
		{
			num += 0.05f;
		}
		num = ((SummOfLoyalityOfPoliticans() > 900) ? (num + 0.15f) : ((SummOfLoyalityOfPoliticans() > 800) ? (num + 0.12f) : ((SummOfLoyalityOfPoliticans() > 700) ? (num + 0.1f) : ((SummOfLoyalityOfPoliticans() > 600) ? (num + 0.07f) : ((SummOfLoyalityOfPoliticans() <= 500) ? (num - 0.05f) : (num + 0.05f))))));
		if (GlobalScript.inst.gameState.data[1] > 800)
		{
			num += 0.05f;
		}
		else if (GlobalScript.inst.gameState.data[1] < 700)
		{
			num -= 0.05f;
		}
		if (GlobalScript.inst.gameState.politics[politic].is_sledstvie)
		{
			num += 0.1f;
		}
		return num;
	}

	public int SummOfLoyalityOfPoliticans()
	{
		int num = 0;
		Politic[] array = GlobalScript.inst.gameState.politics;
		foreach (Politic politic in array)
		{
			num += politic.loyality;
		}
		return num / GlobalScript.inst.gameState.politics.Length;
	}

	public void MakeNewLeader(int is_him)
	{
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
		GlobalScript.inst.gameState.leader.name_1 = GlobalScript.inst.gameState.politics[is_him].name_1;
		GlobalScript.inst.gameState.leader.name_2 = GlobalScript.inst.gameState.politics[is_him].name_2;
		GlobalScript.inst.gameState.leader.traits[0] = GlobalScript.inst.gameState.politics[is_him].traits[0];
		GlobalScript.inst.gameState.leader.traits[1] = GlobalScript.inst.gameState.politics[is_him].traits[1];
		GlobalScript.inst.gameState.leader.traits[2] = GlobalScript.inst.gameState.politics[is_him].traits[2];
		GlobalScript.inst.gameState.leader.age = GlobalScript.inst.gameState.politics[is_him].age;
		GlobalScript.inst.gameState.leader.face_type = GlobalScript.inst.gameState.politics[is_him].face_type;
		GlobalScript.inst.gameState.leader.face_parts[0] = GlobalScript.inst.gameState.politics[is_him].face_parts[0];
		GlobalScript.inst.gameState.leader.face_parts[1] = GlobalScript.inst.gameState.politics[is_him].face_parts[1];
		GlobalScript.inst.gameState.leader.face_parts[2] = GlobalScript.inst.gameState.politics[is_him].face_parts[2];
		GlobalScript.inst.gameState.leader.face_parts[3] = GlobalScript.inst.gameState.politics[is_him].face_parts[3];
		GlobalScript.inst.gameState.leader.face_parts[4] = GlobalScript.inst.gameState.politics[is_him].face_parts[4];
		GlobalScript.inst.gameState.leader.face_parts[5] = GlobalScript.inst.gameState.politics[is_him].face_parts[5];
		GlobalScript.inst.gameState.leader.face_parts[6] = GlobalScript.inst.gameState.politics[is_him].face_parts[6];
		GlobalScript.inst.gameState.leader.face_parts[7] = GlobalScript.inst.gameState.politics[is_him].face_parts[7];
		GlobalScript.inst.gameState.leader.jacket = GlobalScript.inst.gameState.politics[is_him].jacket;
		GlobalScript.inst.gameState.politics[is_him].name_1 = array[0];
		GlobalScript.inst.gameState.politics[is_him].name_2 = array[1];
		GlobalScript.inst.gameState.politics[is_him].traits[0] = (byte)array[2];
		GlobalScript.inst.gameState.politics[is_him].traits[1] = (byte)array[3];
		GlobalScript.inst.gameState.politics[is_him].traits[2] = (byte)array[4];
		GlobalScript.inst.gameState.politics[is_him].age = (byte)array[5];
		GlobalScript.inst.gameState.politics[is_him].face_type = (byte)array[6];
		GlobalScript.inst.gameState.politics[is_him].face_parts[0] = (byte)array[7];
		GlobalScript.inst.gameState.politics[is_him].face_parts[1] = (byte)array[8];
		GlobalScript.inst.gameState.politics[is_him].face_parts[2] = (byte)array[9];
		GlobalScript.inst.gameState.politics[is_him].face_parts[3] = (byte)array[10];
		GlobalScript.inst.gameState.politics[is_him].face_parts[4] = (byte)array[11];
		GlobalScript.inst.gameState.politics[is_him].face_parts[5] = (byte)array[12];
		GlobalScript.inst.gameState.politics[is_him].face_parts[6] = (byte)array[13];
		GlobalScript.inst.gameState.politics[is_him].face_parts[7] = (byte)array[14];
		GlobalScript.inst.gameState.politics[is_him].jacket = (byte)array[15];
	}

	public void KillPerson(int number)
	{
		for (int i = 0; i < p_first.Length; i++)
		{
			if (p_first[i] == number)
			{
				p_first[i] = 200;
				break;
			}
		}
		for (int j = 0; j < p_second.Length; j++)
		{
			if (p_second[j] == number)
			{
				p_second[j] = 200;
				break;
			}
		}
		for (int k = 0; k < p_third.Length; k++)
		{
			if (p_third[k] == number)
			{
				p_third[k] = 200;
				break;
			}
		}
		for (int l = 0; l < p_forth.Length; l++)
		{
			if (p_forth[l] == number)
			{
				p_forth[l] = 200;
				break;
			}
		}
		for (int m = 0; m < politics_dolshnost.Length; m++)
		{
			if (politics_dolshnost[m] == number)
			{
				politics_dolshnost[m] = 200;
			}
		}
		for (int n = 0; n < GlobalScript.inst.gameState.faction_leader.Length; n++)
		{
			if (GlobalScript.inst.gameState.faction_leader[n] == number)
			{
				GlobalScript.inst.gameState.faction_leader[n] = 200;
			}
		}
		BalancePolitic(new List<byte> { (byte)number });
	}

	public void CalcRelLeader(int num)
	{
		int num2 = 100;
		if (GlobalScript.inst.gameState.data[52] == 34)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 += 250;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 20)
			{
				num2 += 200;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 += 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 -= 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
			{
				num2 -= 150;
			}
		}
		else if (GlobalScript.inst.gameState.data[52] == 35)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 += 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 20)
			{
				num2 += 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 += 250;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 += 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
			{
				num2 -= 100;
			}
		}
		else if (GlobalScript.inst.gameState.data[52] == 36)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 -= 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 += 50;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 += 250;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
			{
				num2 += 50;
			}
		}
		else if (GlobalScript.inst.gameState.data[52] == 37)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 -= 125;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 -= 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 += 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
			{
				num2 += 250;
			}
		}
		if (GlobalScript.inst.gameState.data[54] == 38)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 += 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 += 80;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 -= 200;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
			{
				num2 += 250;
			}
		}
		else if (GlobalScript.inst.gameState.data[54] == 39)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 += 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 += 50;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 -= 50;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 -= 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
			{
				num2 += 50;
			}
		}
		else if (GlobalScript.inst.gameState.data[54] == 40)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 -= 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 -= 50;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 += 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 += 150;
			}
		}
		else if (GlobalScript.inst.gameState.data[54] == 41)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 -= 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
			{
				num2 -= 50;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
			{
				num2 += 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
			{
				num2 += 100;
			}
		}
		if (GlobalScript.inst.gameState.data[14] == 0)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[1] == 4)
			{
				num2 += 250;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 6)
			{
				num2 -= 150;
			}
		}
		else if (GlobalScript.inst.gameState.data[14] == 1)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[1] == 4)
			{
				num2 += 250;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 5)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 7)
			{
				num2 -= 150;
			}
		}
		else if (GlobalScript.inst.gameState.data[14] == 2)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[1] == 4)
			{
				num2 += 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 5)
			{
				num2 += 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 7)
			{
				num2 -= 100;
			}
		}
		else if (GlobalScript.inst.gameState.data[14] == 3)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[1] == 4)
			{
				num2 += 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 5)
			{
				num2 += 250;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 7)
			{
				num2 -= 100;
			}
		}
		else if (GlobalScript.inst.gameState.data[14] == 4)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[1] == 4)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 6)
			{
				num2 += 200;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 5)
			{
				num2 += 50;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 7)
			{
				num2 += 100;
			}
		}
		else if (GlobalScript.inst.gameState.data[14] == 5)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[1] == 4)
			{
				num2 -= 250;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 6)
			{
				num2 += 300;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 5)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[1] == 7)
			{
				num2 += 250;
			}
		}
		if (GlobalScript.inst.gameState.leader.traits[0] == GlobalScript.inst.gameState.politics[num].traits[0])
		{
			num2 += 300;
		}
		if (GlobalScript.inst.gameState.leader.traits[1] == 4)
		{
			num2 = ((GlobalScript.inst.gameState.politics[num].traits[1] == 6) ? (num2 - 150) : ((GlobalScript.inst.gameState.politics[num].traits[1] != 4) ? (num2 - 100) : (num2 + 100)));
		}
		else if (GlobalScript.inst.gameState.leader.traits[1] == 6)
		{
			num2 = ((GlobalScript.inst.gameState.politics[num].traits[1] == 4) ? (num2 - 200) : ((GlobalScript.inst.gameState.politics[num].traits[1] != 6) ? (num2 + 100) : (num2 + 100)));
		}
		else if (GlobalScript.inst.gameState.leader.traits[1] == 5 && GlobalScript.inst.gameState.politics[num].traits[1] != 5)
		{
			num2 += 100;
		}
		else if (GlobalScript.inst.gameState.leader.traits[1] == 7 && GlobalScript.inst.gameState.politics[num].traits[1] == 6)
		{
			num2 += 50;
		}
		if (GlobalScript.inst.gameState.leader.traits[2] == 8)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[2] == 9)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[2] == 8)
			{
				num2 += 100;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[2] == 10)
			{
				num2 += 50;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[2] == 14)
			{
				num2 += 50;
			}
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 9)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[2] == 16)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[2] != 9)
			{
				num2 += 50;
			}
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 10)
		{
			num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 12) ? (num2 + 50) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 10) ? (num2 - 100) : (num2 + 300)));
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 11)
		{
			num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 10) ? (num2 - 100) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 12) ? (num2 + 100) : (num2 - 100)));
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 12)
		{
			num2 -= 50;
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 13)
		{
			num2 += 100;
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 14)
		{
			num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 15) ? (num2 - 200) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 14) ? (num2 + 50) : (num2 + 150)));
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 15)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[2] == 15)
			{
				num2 += 200;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[2] == 14)
			{
				num2 -= 200;
			}
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 16)
		{
			if (GlobalScript.inst.gameState.politics[num].traits[2] == 9)
			{
				num2 -= 150;
			}
			else if (GlobalScript.inst.gameState.politics[num].traits[2] == 14)
			{
				num2 += 50;
			}
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 17)
		{
			num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 8) ? (num2 - 150) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 17) ? (num2 - 50) : (num2 + 300)));
		}
		else if (GlobalScript.inst.gameState.leader.traits[2] == 18)
		{
			num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] != 11) ? (num2 + 10) : (num2 - 200));
		}
		GlobalScript.inst.gameState.politics[num].loyality = num2;
	}

	public void CalcRel(int num)
	{
		for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
		{
			if (i != num)
			{
				int num2 = 0;
				if (GlobalScript.inst.gameState.politics[i].traits[0] == GlobalScript.inst.gameState.politics[num].traits[0])
				{
					num2 += 500;
				}
				if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 += 80;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 1)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 2)
					{
						num2 -= 150;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 3)
					{
						num2 -= 300;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[0] == 20)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[0] == 0)
					{
						num2 += 80;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 1)
					{
						num2 += 25;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 2)
					{
						num2 -= 80;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 3)
					{
						num2 -= 200;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[0] == 0)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 += 25;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 2)
					{
						num2 -= 50;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 3)
					{
						num2 -= 150;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[0] == 0)
					{
						num2 -= 150;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 -= 50;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 1)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 3)
					{
						num2 += 100;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[0] == 0)
					{
						num2 -= 300;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 -= 200;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 1)
					{
						num2 -= 150;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 2)
					{
						num2 += 100;
					}
				}
				if (GlobalScript.inst.gameState.politics[num].traits[1] == 4)
				{
					num2 = ((GlobalScript.inst.gameState.politics[i].traits[1] == 6) ? (num2 - 250) : ((GlobalScript.inst.gameState.politics[i].traits[1] != 4) ? (num2 - 100) : (num2 + 100)));
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[1] == 6)
				{
					num2 = ((GlobalScript.inst.gameState.politics[i].traits[1] == 4) ? (num2 - 300) : ((GlobalScript.inst.gameState.politics[i].traits[1] != 6) ? (num2 + 100) : (num2 + 100)));
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[1] == 5 && GlobalScript.inst.gameState.politics[i].traits[1] != 5)
				{
					num2 += 100;
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[1] == 7 && GlobalScript.inst.gameState.politics[i].traits[1] == 6)
				{
					num2 += 50;
				}
				if (GlobalScript.inst.gameState.politics[num].traits[2] == 8)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[2] == 9)
					{
						num2 -= 250;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[2] == 8)
					{
						num2 += 100;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[2] == 10)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[2] == 14)
					{
						num2 += 50;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 9)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[2] == 16)
					{
						num2 -= 250;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[2] != 9)
					{
						num2 += 50;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 10)
				{
					num2 = ((GlobalScript.inst.gameState.politics[i].traits[2] == 12) ? (num2 + 50) : ((GlobalScript.inst.gameState.politics[i].traits[2] != 10) ? (num2 - 100) : (num2 + 300)));
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 11)
				{
					num2 = ((GlobalScript.inst.gameState.politics[i].traits[2] == 10) ? (num2 - 100) : ((GlobalScript.inst.gameState.politics[i].traits[2] != 12) ? (num2 + 100) : (num2 - 100)));
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 12)
				{
					num2 -= 50;
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 13)
				{
					num2 += 100;
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 14)
				{
					num2 = ((GlobalScript.inst.gameState.politics[i].traits[2] == 15) ? (num2 - 300) : ((GlobalScript.inst.gameState.politics[i].traits[2] != 14) ? (num2 + 50) : (num2 + 150)));
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 15)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[2] == 15)
					{
						num2 += 200;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[2] == 14)
					{
						num2 -= 300;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 16)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[2] == 9)
					{
						num2 -= 250;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[2] == 14)
					{
						num2 += 50;
					}
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 17)
				{
					num2 = ((GlobalScript.inst.gameState.politics[i].traits[2] == 8) ? (num2 - 250) : ((GlobalScript.inst.gameState.politics[i].traits[2] != 17) ? (num2 - 50) : (num2 + 300)));
				}
				else if (GlobalScript.inst.gameState.politics[num].traits[2] == 18)
				{
					num2 = ((GlobalScript.inst.gameState.politics[i].traits[2] != 11) ? (num2 + 10) : (num2 - 300));
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[0] == num)
				{
					if (GlobalScript.inst.gameState.politics[i].wantedDolzh == 0)
					{
						num2 -= 400;
					}
				}
				else if (GlobalScript.inst.gameState.politics_dolshnost[1] == num || GlobalScript.inst.gameState.politics_dolshnost[2] == num)
				{
					if (GlobalScript.inst.gameState.politics_dolshnost[0] != i && (GlobalScript.inst.gameState.politics[i].wantedDolzh == 1 || GlobalScript.inst.gameState.politics[i].wantedDolzh == 2))
					{
						num2 -= 400;
					}
				}
				else if ((GlobalScript.inst.gameState.politics_dolshnost[3] == num || GlobalScript.inst.gameState.politics_dolshnost[4] == num || GlobalScript.inst.gameState.politics_dolshnost[5] == num || GlobalScript.inst.gameState.politics_dolshnost[6] == num || GlobalScript.inst.gameState.politics_dolshnost[7] == num) && GlobalScript.inst.gameState.politics_dolshnost[0] != i && GlobalScript.inst.gameState.politics_dolshnost[1] != i && GlobalScript.inst.gameState.politics_dolshnost[2] != i && GlobalScript.inst.gameState.politics[i].wantedDolzh >= 3)
				{
					num2 -= 400;
				}
				GlobalScript.inst.gameState.politics[i].loyality_to_other[num] = num2;
			}
			else
			{
				GlobalScript.inst.gameState.politics[i].loyality_to_other[i] = 1000;
			}
		}
	}

	public void CalcRel2(int num)
	{
		for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
		{
			if (i != num)
			{
				int num2 = 0;
				if (GlobalScript.inst.gameState.politics[num].traits[0] == GlobalScript.inst.gameState.politics[i].traits[0])
				{
					num2 += 500;
				}
				if (GlobalScript.inst.gameState.politics[i].traits[0] == 0)
				{
					if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 += 80;
					}
					if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
					{
						num2 -= 150;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
					{
						num2 -= 300;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
					{
						num2 += 80;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 1)
					{
						num2 += 25;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
					{
						num2 -= 80;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
					{
						num2 -= 200;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 1)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 += 25;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
					{
						num2 -= 50;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
					{
						num2 -= 150;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 2)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
					{
						num2 -= 150;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 -= 50;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 3)
					{
						num2 += 100;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 3)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[0] == 0)
					{
						num2 -= 300;
					}
					else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20)
					{
						num2 -= 200;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 1)
					{
						num2 -= 150;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[0] == 2)
					{
						num2 += 100;
					}
				}
				if (GlobalScript.inst.gameState.politics[i].traits[1] == 4)
				{
					num2 = ((GlobalScript.inst.gameState.politics[num].traits[1] == 5) ? (num2 - 250) : ((GlobalScript.inst.gameState.politics[num].traits[1] != 4) ? (num2 - 100) : (num2 + 100)));
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[1] == 5)
				{
					num2 = ((GlobalScript.inst.gameState.politics[num].traits[1] == 4) ? (num2 - 300) : ((GlobalScript.inst.gameState.politics[num].traits[1] != 5) ? (num2 + 100) : (num2 + 100)));
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[1] == 6 && GlobalScript.inst.gameState.politics[num].traits[1] != 6)
				{
					num2 += 100;
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[1] == 7 && GlobalScript.inst.gameState.politics[num].traits[1] == 6)
				{
					num2 += 50;
				}
				if (GlobalScript.inst.gameState.politics[i].traits[2] == 8)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[2] == 9)
					{
						num2 -= 250;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[2] == 8)
					{
						num2 += 100;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[2] == 10)
					{
						num2 += 50;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[2] == 14)
					{
						num2 += 50;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 9)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[2] == 16)
					{
						num2 -= 250;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[2] != 9)
					{
						num2 += 50;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 10)
				{
					num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 12) ? (num2 + 50) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 10) ? (num2 - 100) : (num2 + 300)));
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 11)
				{
					num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 10) ? (num2 - 100) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 12) ? (num2 + 100) : (num2 - 100)));
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 12)
				{
					num2 -= 50;
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 13)
				{
					num2 += 100;
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 14)
				{
					num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 15) ? (num2 - 300) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 14) ? (num2 + 50) : (num2 + 150)));
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 15)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[2] == 15)
					{
						num2 += 200;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[2] == 14)
					{
						num2 -= 300;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 16)
				{
					if (GlobalScript.inst.gameState.politics[num].traits[2] == 9)
					{
						num2 -= 250;
					}
					else if (GlobalScript.inst.gameState.politics[num].traits[2] == 14)
					{
						num2 += 50;
					}
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 17)
				{
					num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] == 8) ? (num2 - 250) : ((GlobalScript.inst.gameState.politics[num].traits[2] != 17) ? (num2 - 50) : (num2 + 300)));
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[2] == 18)
				{
					num2 = ((GlobalScript.inst.gameState.politics[num].traits[2] != 11) ? (num2 + 10) : (num2 - 300));
				}
				if (GlobalScript.inst.gameState.politics_dolshnost[0] == i)
				{
					if (GlobalScript.inst.gameState.politics[num].wantedDolzh == 0)
					{
						num2 -= 400;
					}
				}
				else if (GlobalScript.inst.gameState.politics_dolshnost[1] == i || GlobalScript.inst.gameState.politics_dolshnost[2] == i)
				{
					if (GlobalScript.inst.gameState.politics_dolshnost[0] != num && (GlobalScript.inst.gameState.politics[num].wantedDolzh == 1 || GlobalScript.inst.gameState.politics[num].wantedDolzh == 2))
					{
						num2 -= 400;
					}
				}
				else if ((GlobalScript.inst.gameState.politics_dolshnost[3] == i || GlobalScript.inst.gameState.politics_dolshnost[4] == i || GlobalScript.inst.gameState.politics_dolshnost[5] == i || GlobalScript.inst.gameState.politics_dolshnost[6] == i || GlobalScript.inst.gameState.politics_dolshnost[7] == i) && GlobalScript.inst.gameState.politics_dolshnost[0] != num && GlobalScript.inst.gameState.politics_dolshnost[1] != num && GlobalScript.inst.gameState.politics_dolshnost[2] != num && GlobalScript.inst.gameState.politics[num].wantedDolzh >= 3)
				{
					num2 -= 400;
				}
				GlobalScript.inst.gameState.politics[num].loyality_to_other[i] = num2;
			}
			else
			{
				GlobalScript.inst.gameState.politics[i].loyality_to_other[i] = 1000;
			}
		}
	}

	public int NumberOfPolitician(int name_1, int name_2)
	{
		for (int i = 0; i < GlobalScript.inst.gameState.politics.Length; i++)
		{
			if (GlobalScript.inst.gameState.politics[i].name_1 == name_1 && GlobalScript.inst.gameState.politics[i].name_2 == name_2)
			{
				return i;
			}
		}
		return -1;
	}

	public void GeneratePolitic(Politic pol)
	{
		pol.name_1 = UnityEngine.Random.Range(4, 42);
		pol.name_2 = UnityEngine.Random.Range(16, 46);
		pol.power = UnityEngine.Random.Range(1, 100);
		pol.loyality = 0;
		pol.traits[0] = 5;
		bool[] array = new bool[5];
		for (int i = 0; i < pol.loyality_to_other.Length; i++)
		{
			pol.loyality_to_other[i] = 0;
			if (GlobalScript.inst.gameState.politics[i] != null)
			{
				if (GlobalScript.inst.gameState.politics[i].traits[0] == 0 && !array[0])
				{
					array[0] = true;
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 1 && !array[1])
				{
					array[1] = true;
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 2 && !array[2])
				{
					array[2] = true;
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 3 && !array[3])
				{
					array[3] = true;
				}
				else if (GlobalScript.inst.gameState.politics[i].traits[0] == 20 && !array[4])
				{
					array[4] = true;
				}
			}
		}
		pol.is_sagovor = false;
		pol.is_sledstvie = false;
		pol.is_sleshka = false;
		pol.autohound = 0;
		pol.autosupport = 0;
		pol.days_sleshka = 0;
		pol.wantedDolzh = UnityEngine.Random.Range(0, 4);
		pol.age = (byte)UnityEngine.Random.Range(50, 80);
		if (pol.age < 50)
		{
			pol.age = 50;
		}
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			float num = 0f;
			for (int j = 0; j < party_ideology.Length; j++)
			{
				num += (float)party_ideology[j];
			}
			float num2 = (float)party_ideology[0] / num * 100f;
			float num3 = (float)party_ideology[1] / num * 100f;
			float num4 = (float)party_ideology[2] / num * 100f;
			float num5 = (float)party_ideology[3] / num * 100f;
			float num6 = (float)party_ideology[4] / num * 100f;
			Debug.Log(num2.ToString());
			Debug.Log(num3.ToString());
			Debug.Log(num4.ToString());
			Debug.Log(num5.ToString());
			Debug.Log(num6.ToString());
			int num7 = UnityEngine.Random.Range(0, 100);
			if ((float)num7 <= num2)
			{
				pol.traits[0] = 0;
			}
			else if ((float)num7 > num2 && (float)num7 <= num2 + num3)
			{
				pol.traits[0] = 20;
			}
			else if ((float)num7 > num2 + num3 && (float)num7 <= num2 + num3 + num4)
			{
				pol.traits[0] = 1;
			}
			else if ((float)num7 > num2 + num3 + num4 && (float)num7 <= num2 + num3 + num4 + num5)
			{
				pol.traits[0] = 2;
			}
			else
			{
				pol.traits[0] = 3;
			}
		}
		else
		{
			int num8 = GlobalScript.inst.gameState.data[52] - 33;
			int num9 = GlobalScript.inst.gameState.data[54] - 37;
			int num10 = num8 + num9;
			num10 += UnityEngine.Random.Range(-2, 3);
			if (num10 <= 1)
			{
				pol.traits[0] = 0;
			}
			else if (num10 <= 3)
			{
				pol.traits[0] = 20;
			}
			else if (num10 <= 5)
			{
				pol.traits[0] = 1;
			}
			else if (num10 <= 7)
			{
				pol.traits[0] = 2;
			}
			else
			{
				pol.traits[0] = 3;
			}
		}
		if (!array[4])
		{
			pol.traits[0] = 20;
		}
		else if (!array[3])
		{
			pol.traits[0] = 3;
		}
		else if (!array[2])
		{
			pol.traits[0] = 2;
		}
		else if (!array[1])
		{
			pol.traits[0] = 1;
		}
		else if (!array[0])
		{
			pol.traits[0] = 0;
		}
		pol.traits[1] = (byte)UnityEngine.Random.Range(4, 8);
		pol.traits[2] = (byte)UnityEngine.Random.Range(8, 19);
		if (gamerules[8] > 0)
		{
			if (pol.traits[1] == 7)
			{
				pol.traits[1] = 6;
			}
			if (pol.traits[2] == 11)
			{
				pol.traits[2] = 18;
			}
			else if (pol.traits[2] == 13)
			{
				pol.traits[2] = 10;
			}
		}
		if (GlobalScript.inst.gameState.data[57] < 500)
		{
			if (UnityEngine.Random.Range(0, 50) % 6 == 0)
			{
				pol.traits[2] = 16;
			}
			else if (UnityEngine.Random.Range(0, 50) % 6 == 0)
			{
				pol.traits[2] = 12;
			}
		}
		if (UnityEngine.Random.Range(0, 730) == 22)
		{
			pol.name_1 = 42;
			pol.name_2 = 46;
			pol.age = 22;
			pol.traits[0] = 1;
			pol.traits[1] = 7;
			pol.traits[2] = 11;
		}
		if (GlobalScript.inst.gameState.event_done[241] && GlobalScript.inst.gameState.resultOfEvents[241] < 2)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[241] == 0)
			{
				if (GlobalScript.inst.gameState.NumberOfPolitician(30, 50) < 0 && !GlobalScript.inst.gameState.event_done[242])
				{
					pol.name_1 = 30;
					pol.name_2 = 50;
					pol.age = 40;
					pol.traits[0] = 20;
					pol.traits[1] = 5;
					pol.traits[2] = 9;
					GlobalScript.inst.gameState.event_done[242] = true;
				}
				else if (GlobalScript.inst.gameState.NumberOfPolitician(4, 51) < 0 && !GlobalScript.inst.gameState.event_done[243])
				{
					pol.name_1 = 4;
					pol.name_2 = 51;
					pol.age = 36;
					pol.traits[0] = 0;
					pol.traits[1] = 4;
					pol.traits[2] = 11;
					GlobalScript.inst.gameState.event_done[243] = true;
				}
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[241] == 1)
			{
				if (GlobalScript.inst.gameState.NumberOfPolitician(30, 50) < 0 && !GlobalScript.inst.gameState.event_done[242])
				{
					pol.name_1 = 30;
					pol.name_2 = 50;
					pol.age = 40;
					pol.traits[0] = 20;
					pol.traits[1] = 5;
					pol.traits[2] = 9;
					GlobalScript.inst.gameState.event_done[242] = true;
				}
				else if (GlobalScript.inst.gameState.NumberOfPolitician(4, 51) < 0 && !GlobalScript.inst.gameState.event_done[243])
				{
					pol.name_1 = 4;
					pol.name_2 = 51;
					pol.age = 36;
					pol.traits[0] = 0;
					pol.traits[1] = 4;
					pol.traits[2] = 11;
					GlobalScript.inst.gameState.event_done[243] = true;
				}
				else if (GlobalScript.inst.gameState.NumberOfPolitician(3, 52) < 0 && !GlobalScript.inst.gameState.event_done[244])
				{
					pol.name_1 = 3;
					pol.name_2 = 52;
					pol.age = 41;
					pol.traits[0] = 0;
					pol.traits[1] = 6;
					pol.traits[2] = 16;
					GlobalScript.inst.gameState.event_done[244] = true;
				}
				else if (GlobalScript.inst.gameState.NumberOfPolitician(31, 53) < 0 && !GlobalScript.inst.gameState.event_done[245])
				{
					pol.name_1 = 31;
					pol.name_2 = 53;
					pol.age = 66;
					pol.traits[0] = 0;
					pol.traits[1] = 5;
					pol.traits[2] = 8;
					GlobalScript.inst.gameState.event_done[245] = true;
				}
			}
		}
		if (GlobalScript.inst.gameState.event_done[44] && GlobalScript.inst.gameState.resultOfEvents[44] != 1)
		{
			if (GlobalScript.inst.gameState.resultOfEvents[44] == 0 && GlobalScript.inst.gameState.leader.name_1 == 13 && GlobalScript.inst.gameState.leader.name_2 == 13)
			{
				if ((GlobalScript.inst.gameState.NumberOfPolitician(44, 57) < 0 || (pol.name_1 == 44 && pol.name_2 == 57)) && !GlobalScript.inst.gameState.event_done[246])
				{
					pol.name_1 = 44;
					pol.name_2 = 57;
					pol.age = (byte)(GlobalScript.inst.gameState.data[21] - 1916);
					pol.traits[0] = 3;
					pol.traits[1] = 6;
					pol.traits[2] = 11;
					GlobalScript.inst.gameState.event_done[246] = true;
				}
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[44] == 2 && GlobalScript.inst.gameState.NumberOfPolitician(13, 13) >= 0)
			{
				if ((GlobalScript.inst.gameState.NumberOfPolitician(44, 57) < 0 || (pol.name_1 == 44 && pol.name_2 == 57)) && !GlobalScript.inst.gameState.event_done[246])
				{
					pol.name_1 = 44;
					pol.name_2 = 57;
					pol.age = (byte)(GlobalScript.inst.gameState.data[21] - 1916);
					pol.traits[0] = 3;
					pol.traits[1] = 6;
					pol.traits[2] = 11;
					GlobalScript.inst.gameState.event_done[246] = true;
				}
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[44] == 0 && GlobalScript.inst.gameState.leader.name_1 == 8 && GlobalScript.inst.gameState.leader.name_2 == 8)
			{
				if ((GlobalScript.inst.gameState.NumberOfPolitician(23, 60) < 0 || (pol.name_1 == 23 && pol.name_2 == 60)) && !GlobalScript.inst.gameState.event_done[246])
				{
					pol.name_1 = 23;
					pol.name_2 = 60;
					pol.age = (byte)(GlobalScript.inst.gameState.data[21] - 1916);
					pol.traits[0] = 2;
					pol.traits[1] = 4;
					pol.traits[2] = 8;
					GlobalScript.inst.gameState.event_done[246] = true;
				}
			}
			else if (GlobalScript.inst.gameState.resultOfEvents[44] == 2 && GlobalScript.inst.gameState.NumberOfPolitician(8, 8) >= 0 && (GlobalScript.inst.gameState.NumberOfPolitician(23, 60) < 0 || (pol.name_1 == 23 && pol.name_2 == 60)) && !GlobalScript.inst.gameState.event_done[246])
			{
				pol.name_1 = 23;
				pol.name_2 = 60;
				pol.age = (byte)(GlobalScript.inst.gameState.data[21] - 1916);
				pol.traits[0] = 2;
				pol.traits[1] = 4;
				pol.traits[2] = 8;
				GlobalScript.inst.gameState.event_done[246] = true;
			}
		}
		if (UnityEngine.Random.Range(0f, 1f) > 0.5f)
		{
			pol.face_type = 0;
			pol.face_parts[0] = (byte)UnityEngine.Random.Range(0, 3);
			pol.face_parts[1] = (byte)UnityEngine.Random.Range(0, 6);
			pol.face_parts[2] = (byte)UnityEngine.Random.Range(0, 6);
			pol.face_parts[3] = (byte)UnityEngine.Random.Range(0, 4);
			pol.face_parts[4] = (byte)UnityEngine.Random.Range(0, 6);
			pol.face_parts[5] = (byte)UnityEngine.Random.Range(0, 3);
			pol.face_parts[6] = (byte)UnityEngine.Random.Range(0, 6);
			pol.face_parts[7] = (byte)UnityEngine.Random.Range(0, 3);
		}
		else
		{
			pol.face_type = 1;
			pol.face_parts[0] = (byte)UnityEngine.Random.Range(0, 4);
			pol.face_parts[1] = (byte)UnityEngine.Random.Range(0, 6);
			pol.face_parts[2] = (byte)UnityEngine.Random.Range(0, 6);
			pol.face_parts[3] = (byte)UnityEngine.Random.Range(0, 3);
			pol.face_parts[4] = (byte)UnityEngine.Random.Range(0, 4);
			pol.face_parts[5] = (byte)UnityEngine.Random.Range(0, 4);
			pol.face_parts[6] = (byte)UnityEngine.Random.Range(0, 5);
			pol.face_parts[7] = (byte)UnityEngine.Random.Range(0, 4);
		}
		if (pol.traits[0] == 0)
		{
			switch (UnityEngine.Random.Range(0, 3))
			{
			case 0:
				pol.jacket = 0;
				break;
			case 1:
				pol.jacket = 2;
				break;
			default:
				pol.jacket = 4;
				break;
			}
		}
		else if (pol.traits[0] == 1 || pol.traits[0] == 20)
		{
			pol.jacket = (byte)UnityEngine.Random.Range(2, 5);
		}
		else if (pol.traits[0] == 2)
		{
			pol.jacket = (byte)UnityEngine.Random.Range(1, 5);
		}
		else if (pol.traits[0] == 3)
		{
			if (UnityEngine.Random.Range(0, 2) == 0)
			{
				pol.jacket = 1;
			}
			else
			{
				pol.jacket = 3;
			}
		}
	}

	public void BalancePolitic(List<byte> politics_to_generate)
	{
		if (politics_to_generate.Count() > 0)
		{
			Stack<byte> stack = new Stack<byte>();
			foreach (byte item in politics_to_generate)
			{
				GeneratePolitic(GlobalScript.inst.gameState.politics[item]);
				stack.Push(item);
			}
			for (int i = 0; i < p_first.Length; i++)
			{
				if (p_first[i] == 200)
				{
					p_first[i] = stack.Pop();
				}
			}
			for (int j = 0; j < p_second.Length; j++)
			{
				if (p_second[j] == 200)
				{
					p_second[j] = stack.Pop();
				}
			}
			for (int k = 0; k < p_third.Length; k++)
			{
				if (p_third[k] == 200)
				{
					p_third[k] = stack.Pop();
				}
			}
			for (int l = 0; l < p_forth.Length; l++)
			{
				if (p_forth[l] == 200)
				{
					p_forth[l] = stack.Pop();
				}
			}
		}
		using (IEnumerator<int> enumerator2 = (from p in Enumerable.Range(0, 18)
			orderby GlobalScript.inst.gameState.politics[p].power descending
			select p).GetEnumerator())
		{
			for (int m = 0; m < p_first.Length; m++)
			{
				enumerator2.MoveNext();
				p_first[m] = (byte)enumerator2.Current;
			}
			for (int n = 0; n < p_second.Length; n++)
			{
				enumerator2.MoveNext();
				p_second[n] = (byte)enumerator2.Current;
			}
			for (int num = 0; num < p_third.Length; num++)
			{
				enumerator2.MoveNext();
				p_third[num] = (byte)enumerator2.Current;
			}
			for (int num2 = 0; num2 < p_forth.Length; num2++)
			{
				enumerator2.MoveNext();
				p_forth[num2] = (byte)enumerator2.Current;
			}
		}
		if (politics_to_generate.Count() <= 0)
		{
			return;
		}
		foreach (byte item2 in politics_to_generate)
		{
			CalcRel(item2);
			CalcRel2(item2);
			CalcRelLeader(item2);
		}
	}

	public bool IsFactionLeadeng(int num)
	{
		return num == data[56];
	}

	public void CounterRevolution(int selected_country)
	{
		if (!allcountries[selected_country].Vyshi && !allcountries[selected_country].econ && !allcountries[selected_country].isSEV && allcountries[selected_country].Gosstroy != 3 && allcountries[selected_country].proprc && allcountries[selected_country].level_of_dev - allcountries[selected_country].level_of_unstab < 0)
		{
			allcountries[selected_country].Torg = false;
			allcountries[selected_country].proprc = false;
			allcountries[selected_country].Gosstroy = UnityEngine.Random.Range(0, 4);
			if (allcountries[selected_country].Gosstroy == 1 || allcountries[selected_country].Gosstroy == 2)
			{
				allcountries[selected_country].SubGosstroy = UnityEngine.Random.Range(1, 10);
			}
			else
			{
				allcountries[selected_country].SubGosstroy = UnityEngine.Random.Range(4, 10);
			}
			if (allcountries[selected_country].SubGosstroy > 3)
			{
				UnityEngine.Random.Range(0, 6);
			}
			else
			{
				UnityEngine.Random.Range(2, 6);
			}
			allcountries[selected_country].level_of_unstab -= 20;
		}
	}

	public void WantToLeave(int selected_country)
	{
		bool flag = true;
		if (allcountries[selected_country].SubGosstroy == 0)
		{
			if (data[14] > 2 || data[16] >= 13 || data[6] < 700 || data[15] >= 8)
			{
				flag = false;
			}
		}
		else if ((allcountries[selected_country].SubGosstroy >= 1 && allcountries[selected_country].SubGosstroy <= 3) || allcountries[selected_country].SubGosstroy == 8 || allcountries[selected_country].SubGosstroy == 17)
		{
			if (data[14] > 3 || data[16] > 13 || data[6] < 500)
			{
				flag = false;
			}
		}
		else if (allcountries[selected_country].SubGosstroy >= 4 && allcountries[selected_country].SubGosstroy <= 6)
		{
			if (data[14] < 2 || data[16] < 13 || data[6] > 700 || data[15] < 8 || data[17] < 18 || allcountries[1].isOVD)
			{
				flag = false;
			}
		}
		else if (allcountries[selected_country].SubGosstroy >= 7 && (data[14] == 1 || data[16] <= 11 || data[6] < 300 || allcountries[1].isSEV))
		{
			flag = false;
		}
		if (allcountries[selected_country].proprc)
		{
			allcountries[selected_country].Torg = flag;
			allcountries[selected_country].proprc = flag;
			if (allcountries[selected_country].Vyshi)
			{
				allcountries[selected_country].Vyshi = !flag;
			}
		}
	}

	public int GetSubGosstory()
	{
		if (data[14] <= 2 && data[16] < 13 && data[6] >= 700 && data[15] < 8)
		{
			return 0;
		}
		if (data[14] <= 3 && data[16] <= 13 && data[6] >= 500)
		{
			return UnityEngine.Random.Range(1, 4);
		}
		if (data[14] >= 2 && data[16] >= 13 && data[6] <= 700 && data[15] >= 8 && data[17] >= 18 && !allcountries[1].isOVD)
		{
			return UnityEngine.Random.Range(4, 7);
		}
		if (!allcountries[1].isSEV)
		{
			return 7;
		}
		return 8;
	}

	public void WhatToDevelop(int selected_country)
	{
		if (allcountries[selected_country].SubGosstroy <= 9)
		{
			int num = Mathf.Abs(4 - allcountries[selected_country].SubGosstroy);
			if (allcountries[selected_country].level_of_unstab > (6 - num) * 20)
			{
				allcountries[selected_country].level_of_unstab -= allcountries[selected_country].level_of_unstab / 25;
				allcountries[selected_country].level_of_dev--;
			}
			else
			{
				allcountries[selected_country].level_of_unstab += ((6 - num) * 20 - allcountries[selected_country].level_of_unstab) / 5;
				allcountries[selected_country].level_of_dev++;
			}
		}
		else if (allcountries[selected_country].SubGosstroy > 9)
		{
			int num2 = Mathf.Abs(13 - allcountries[selected_country].SubGosstroy);
			if (allcountries[selected_country].level_of_unstab > (6 - num2) * 20)
			{
				allcountries[selected_country].level_of_unstab -= allcountries[selected_country].level_of_unstab / 25;
				allcountries[selected_country].level_of_dev--;
			}
			else
			{
				allcountries[selected_country].level_of_unstab += ((6 - num2) * 20 - allcountries[selected_country].level_of_unstab) / 5;
				allcountries[selected_country].level_of_dev++;
			}
		}
		if (allcountries[selected_country].level_of_unstab > 100)
		{
			allcountries[selected_country].level_of_unstab = 100;
		}
		else if (allcountries[selected_country].level_of_unstab < 0)
		{
			allcountries[selected_country].level_of_unstab = 0;
		}
		else if (allcountries[selected_country].level_of_unstab < 10)
		{
			allcountries[selected_country].level_of_unstab++;
		}
		if (allcountries[selected_country].level_of_dev > 100)
		{
			allcountries[selected_country].level_of_dev = 100;
		}
		else if (allcountries[selected_country].level_of_dev < 0)
		{
			allcountries[selected_country].level_of_dev = 0;
		}
		else if (allcountries[selected_country].level_of_dev > 90)
		{
			allcountries[selected_country].level_of_dev--;
		}
		allcountries[selected_country].level_of_unstab -= allcountries[selected_country].Gosstroy;
	}

	public void AmericanHelp(int selected_country)
	{
		if (allcountries[selected_country].Vyshi)
		{
			allcountries[selected_country].level_of_unstab -= empires[0].power / 28;
		}
		else if (!allcountries[selected_country].proprc && !allcountries[selected_country].prosov)
		{
			allcountries[selected_country].level_of_unstab -= empires[0].power / 40;
		}
		else
		{
			allcountries[selected_country].level_of_unstab += empires[0].power / 66;
		}
	}

	public int GetWinnerInAmerica(int country, bool[] ideoParties, float[] partiesSup, float coef = 0f, int party = -1)
	{
		if (ideoParties[allcountries[country].SubGosstroy])
		{
			partiesSup[allcountries[country].SubGosstroy] -= allcountries[country].level_of_unstab;
			partiesSup[allcountries[country].SubGosstroy] += allcountries[country].level_of_dev;
		}
		if (allcountries[country].SubGosstroy - 1 >= 0 && ideoParties[allcountries[country].SubGosstroy - 1])
		{
			partiesSup[allcountries[country].SubGosstroy - 1] -= allcountries[country].level_of_unstab / 4;
			partiesSup[allcountries[country].SubGosstroy - 1] += allcountries[country].level_of_dev / 2;
		}
		if (allcountries[country].SubGosstroy + 1 <= 9 && ideoParties[allcountries[country].SubGosstroy + 1])
		{
			partiesSup[allcountries[country].SubGosstroy + 1] -= allcountries[country].level_of_unstab / 4;
			partiesSup[allcountries[country].SubGosstroy + 1] += allcountries[country].level_of_dev / 2;
		}
		if (!ideoParties[allcountries[country].SubGosstroy])
		{
			if (allcountries[country].SubGosstroy >= 1 && allcountries[country].SubGosstroy <= 3)
			{
				if (ideoParties[1])
				{
					partiesSup[1] -= allcountries[country].level_of_unstab / 4;
					partiesSup[1] += allcountries[country].level_of_dev / 2;
				}
				else if (ideoParties[2])
				{
					partiesSup[2] -= allcountries[country].level_of_unstab / 4;
					partiesSup[2] += allcountries[country].level_of_dev / 2;
				}
				else if (ideoParties[3])
				{
					partiesSup[3] -= allcountries[country].level_of_unstab / 4;
					partiesSup[3] += allcountries[country].level_of_dev / 2;
				}
			}
			else if (allcountries[country].SubGosstroy >= 4 && allcountries[country].SubGosstroy <= 6)
			{
				if (ideoParties[4])
				{
					partiesSup[4] -= allcountries[country].level_of_unstab / 4;
					partiesSup[4] += allcountries[country].level_of_dev / 2;
				}
				else if (ideoParties[5])
				{
					partiesSup[5] -= allcountries[country].level_of_unstab / 4;
					partiesSup[5] += allcountries[country].level_of_dev / 2;
				}
				else if (ideoParties[6])
				{
					partiesSup[6] -= allcountries[country].level_of_unstab / 4;
					partiesSup[6] += allcountries[country].level_of_dev / 2;
				}
			}
		}
		if (allcountries[country].SubGosstroy <= 3)
		{
			if (ideoParties[9 - allcountries[country].SubGosstroy])
			{
				partiesSup[9 - allcountries[country].SubGosstroy] += allcountries[country].level_of_unstab;
				partiesSup[9 - allcountries[country].SubGosstroy] -= allcountries[country].level_of_dev;
			}
			else if (ideoParties[5])
			{
				partiesSup[5] += allcountries[country].level_of_unstab;
				partiesSup[5] -= allcountries[country].level_of_dev;
			}
			else if (ideoParties[4])
			{
				partiesSup[4] -= allcountries[country].level_of_unstab / 2;
				partiesSup[4] += allcountries[country].level_of_dev / 2;
			}
			if (8 - allcountries[country].SubGosstroy >= 0 && ideoParties[8 - allcountries[country].SubGosstroy])
			{
				partiesSup[8 - allcountries[country].SubGosstroy] += allcountries[country].level_of_unstab / 2;
				partiesSup[8 - allcountries[country].SubGosstroy] -= allcountries[country].level_of_dev / 4;
			}
			if (10 - allcountries[country].SubGosstroy <= 9 && ideoParties[allcountries[country].SubGosstroy])
			{
				partiesSup[10 - allcountries[country].SubGosstroy] += allcountries[country].level_of_unstab / 2;
				partiesSup[10 - allcountries[country].SubGosstroy] -= allcountries[country].level_of_dev / 4;
			}
		}
		else if (allcountries[country].SubGosstroy >= 6)
		{
			if (ideoParties[9 - allcountries[country].SubGosstroy])
			{
				partiesSup[9 - allcountries[country].SubGosstroy] += allcountries[country].level_of_unstab;
				partiesSup[9 - allcountries[country].SubGosstroy] -= allcountries[country].level_of_dev;
			}
			else if (ideoParties[4])
			{
				partiesSup[4] += allcountries[country].level_of_unstab;
				partiesSup[4] -= allcountries[country].level_of_dev;
			}
			else if (ideoParties[5])
			{
				partiesSup[5] -= allcountries[country].level_of_unstab / 2;
				partiesSup[5] += allcountries[country].level_of_dev / 2;
			}
			if (8 - allcountries[country].SubGosstroy >= 0 && ideoParties[8 - allcountries[country].SubGosstroy])
			{
				partiesSup[8 - allcountries[country].SubGosstroy] += allcountries[country].level_of_unstab / 2;
				partiesSup[8 - allcountries[country].SubGosstroy] -= allcountries[country].level_of_dev / 4;
			}
			if (10 - allcountries[country].SubGosstroy <= 9 && ideoParties[10 - allcountries[country].SubGosstroy])
			{
				partiesSup[10 - allcountries[country].SubGosstroy] += allcountries[country].level_of_unstab / 2;
				partiesSup[10 - allcountries[country].SubGosstroy] -= allcountries[country].level_of_dev / 4;
			}
		}
		else if (allcountries[country].SubGosstroy == 4)
		{
			if (ideoParties[0])
			{
				partiesSup[0] += allcountries[country].level_of_unstab / 2;
				partiesSup[0] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[1])
			{
				partiesSup[1] += allcountries[country].level_of_unstab / 2;
				partiesSup[1] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[2])
			{
				partiesSup[2] += allcountries[country].level_of_unstab / 2;
				partiesSup[2] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[6])
			{
				partiesSup[6] += allcountries[country].level_of_unstab / 2;
				partiesSup[6] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[7])
			{
				partiesSup[7] += allcountries[country].level_of_unstab / 2;
				partiesSup[7] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[8])
			{
				partiesSup[8] += allcountries[country].level_of_unstab / 2;
				partiesSup[8] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[9])
			{
				partiesSup[9] += allcountries[country].level_of_unstab / 2;
				partiesSup[9] -= allcountries[country].level_of_dev / 4;
			}
		}
		else if (allcountries[country].SubGosstroy == 5)
		{
			if (ideoParties[0])
			{
				partiesSup[0] += allcountries[country].level_of_unstab / 2;
				partiesSup[0] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[1])
			{
				partiesSup[1] += allcountries[country].level_of_unstab / 2;
				partiesSup[1] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[2])
			{
				partiesSup[2] += allcountries[country].level_of_unstab / 2;
				partiesSup[2] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[3])
			{
				partiesSup[6] += allcountries[country].level_of_unstab / 2;
				partiesSup[6] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[7])
			{
				partiesSup[7] += allcountries[country].level_of_unstab / 2;
				partiesSup[7] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[8])
			{
				partiesSup[8] += allcountries[country].level_of_unstab / 2;
				partiesSup[8] -= allcountries[country].level_of_dev / 4;
			}
			if (ideoParties[9])
			{
				partiesSup[9] += allcountries[country].level_of_unstab / 2;
				partiesSup[9] -= allcountries[country].level_of_dev / 4;
			}
		}
		if (coef > 0f)
		{
			coef *= 3f;
			if (partiesSup[party] > 1f)
			{
				partiesSup[party] *= coef;
			}
			else
			{
				partiesSup[party] += coef;
			}
		}
		for (int i = 0; i < partiesSup.Length; i++)
		{
			if (ideoParties[i])
			{
				partiesSup[i] += 100f;
			}
			Debug.Log(i + "." + partiesSup[i]);
		}
		return Array.IndexOf(partiesSup, partiesSup.Max());
	}

	public int AddCells<T>(int cells, ref T[] wars)
	{
		int num = wars.Length + cells;
		Array.Resize(ref wars, num);
		return num;
	}

	public void SetCells<T>(int cells, ref T[] wars)
	{
		Array.Resize(ref wars, cells);
	}

	public void DeleteArrayElement(int num, ref int[] massive)
	{
		int num2 = FindIndexArray(num, ref massive);
		if (num2 >= 0)
		{
			massive[num2] = massive[massive.Length - 1];
			Array.Resize(ref massive, massive.Length - 1);
		}
	}

	public void AddArrayElement(int num, ref int[] massive)
	{
		Array.Resize(ref massive, massive.Length + 1);
		massive[massive.Length - 1] = num;
	}

	public int FindIndexArray(int num, ref int[] massive)
	{
		for (int i = 0; i < massive.Length; i++)
		{
			if (massive[i] == num)
			{
				return i;
			}
		}
		return -1;
	}

	public bool ContaintsRange<T>(T[] array, Func<T, bool> func1)
	{
		foreach (T arg in array)
		{
			if (func1(arg))
			{
				return true;
			}
		}
		return false;
	}

	public bool IsSocialism(bool yes, int country)
	{
		if (!yes)
		{
			return GlobalScript.inst.gameState.allcountries[country].Gosstroy != 1 && GlobalScript.inst.gameState.allcountries[country].SubGosstroy != 0;
		}
		return GlobalScript.inst.gameState.allcountries[country].Gosstroy == 1 || GlobalScript.inst.gameState.allcountries[country].SubGosstroy == 0;
	}

	public bool IsAuthoritarianism(int country)
	{
		if (GlobalScript.inst.gameState.allcountries[country].Gosstroy == 0)
		{
			return GlobalScript.inst.gameState.allcountries[country].SubGosstroy != 0;
		}
		return false;
	}
}
