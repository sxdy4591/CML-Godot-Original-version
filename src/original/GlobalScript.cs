using UnityEngine;

public class GlobalScript : MonoBehaviour
{
	public bool[] dlc = new bool[5];

	public GameState gameState;

	public string[] other_text;

	public string[] new_texts;

	public string[] new_modify_texts;

	public string[] country_texts;

	public string[] new_modify_desc;

	public string[] old_modify_texts;

	public string[] old_modify_desc;

	public string[] new_focuses_texts;

	public string[] new_focuses_desc;

	public string[] new_events_text;

	public int this_stump = -1;

	public int speed;

	public int voice = 5;

	public int map_type = 1;

	public int autosave;

	public int autosavej;

	public int savePlace = 5;

	public AudioClip[] music = new AudioClip[26];

	public int now_playing;

	public int zadan_playing;

	public int albumNum = -1;

	public bool zadan_music;

	public bool get_to_cycle;

	public bool is_ready_to_play;

	public int bitss = 1;

	public Sprite crisis;

	public static GlobalScript inst;

	public void CreateDecisions()
	{
		bool[] array = null;
		if (inst.gameState.decisions != null)
		{
			array = new bool[inst.gameState.decisions.Length];
			for (int i = 0; i < inst.gameState.decisions.Length; i++)
			{
				array[i] = inst.gameState.completedDecisions[i];
			}
		}
		inst.gameState.decisions = null;
		inst.gameState.decisions = new Decision[38]
		{
			new Decision(inst.new_texts[113], inst.new_texts[131]).Expr.thirdOne.TheyAreOurs(10).thirdOne.QuelleGosstroy(10, 1, yes: true).thirdOne.HasMoney(250).thirdOne.HasAgents(250).thirdOne.AddAgents(-250).thirdOne.AddArmy(-250).thirdOne.StartEvent(120).End,
			new Decision(inst.new_texts[114], inst.new_texts[132]).Expr.thirdOne.TibetIsOurs(yes: true).thirdOne.IsUnitarism(yes: false).thirdOne.IsLiberal(yes: true).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(0, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(1, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(2, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(3, 250).thirdOne.AddRelations(0, 250).thirdOne.AddRelations(1, 250).thirdOne.StartEvent(121).End,
			inst.gameState.IsFactionLeadeng(0) ? new Decision(inst.new_texts[115], inst.new_texts[133]).Expr.thirdOne.TibetIsOurs(yes: true).thirdOne.IsUnitarism(yes: true).thirdOne.IsLeftradicalLead(yes: true).thirdOne.IsRadicalTradition(yes: true).thirdOne.HasArmy(250).thirdOne.TibetMustStay(2).thirdOne.AddRelations(0, -250).thirdOne.AddRelations(1, -250).thirdOne.AddChineseInfluence(25).thirdOne.AddMoney(-250).thirdOne.AddNationalism(250).thirdOne.ChangeSpecialEndingForTheCountry(69, 5).thirdOne.StartEvent(547).End : new Decision(" 根 除 藏 文 化", " 藏 不 是 一 个 国 号 ， 而 是 奴 役 本 族 人 民 的 封 建 农 奴 主 的 代 名 词 。  我 们 必 须 抹 去 他 们 骇 人 历 史 的 所 有 痕 迹 ： 寺 庙 、 经 幡 、 佛 学 院 。  我 们 会 把 孩 子 送 到 育 儿 院 ， 让 他 们 远 离 毒 草 思 想 ， 我 们 会 把 藏 族 成 年 人 送 到 再 教 育 中 心 ， 让 他 们 努 力 为 祖 国 利 益 做 贡 献 ， 净 化 心 灵 中 的 罪 孽 。").Expr.thirdOne.TibetIsOurs(yes: true).thirdOne.IsUnitarism(yes: true).thirdOne.IsAutoritharian(yes: true).thirdOne.IsRadicalTradition(yes: true).thirdOne.HasArmy(250).thirdOne.TibetMustStay(2).thirdOne.AddRelations(0, -250).thirdOne.AddRelations(1, -250).thirdOne.AddChineseInfluence(25).thirdOne.AddMoney(-250).thirdOne.AddNationalism(250).thirdOne.ChangeSpecialEndingForTheCountry(69, 6).End,
			new Decision(inst.new_texts[116], inst.new_texts[134]).Expr.thirdOne.UyghurIsOurs(yes: true).thirdOne.IsUnitarism(yes: false).thirdOne.IsLiberal(yes: true).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(0, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(1, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(2, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(3, 250).thirdOne.AddRelations(0, 250).thirdOne.AddRelations(1, 250).thirdOne.StartEvent(122).End,
			inst.gameState.IsFactionLeadeng(0) ? new Decision(inst.new_texts[117], inst.new_texts[135]).Expr.thirdOne.UyghurIsOurs(yes: true).thirdOne.IsUnitarism(yes: true).thirdOne.IsLeftradicalLead(yes: true).thirdOne.IsRadicalTradition(yes: true).thirdOne.HasArmy(250).thirdOne.UyghurMustStay(4).thirdOne.AddRelations(0, -250).thirdOne.AddRelations(1, -250).thirdOne.AddChineseInfluence(25).thirdOne.AddMoney(-250).thirdOne.AddNationalism(250).thirdOne.ChangeSpecialEndingForTheCountry(70, 5).thirdOne.StartEvent(546).End : new Decision(" 根 除 维 吾 尔 文 化", " 由 于 长 期 与 世 隔 绝 ， 维 吾 尔 人 的 老 旧 文 化 远 远 落 后 于 时 代 ， 这 是 造 成 民 族 问 题 的 主 要 原 因 。  我 们 应 尽 一 切 办 法 消 除 这 些 沉 疴 思 想 ， 为 他 们 点 亮 崭 新 的 现 代 文 明 之 光 。").Expr.thirdOne.UyghurIsOurs(yes: true).thirdOne.IsUnitarism(yes: true).thirdOne.IsAutoritharian(yes: true).thirdOne.IsRadicalTradition(yes: true).thirdOne.HasArmy(250).thirdOne.UyghurMustStay(4).thirdOne.AddRelations(0, -250).thirdOne.AddRelations(1, -250).thirdOne.AddChineseInfluence(25).thirdOne.AddMoney(-250).thirdOne.AddNationalism(250).thirdOne.ChangeSpecialEndingForTheCountry(70, 6).End,
			new Decision(inst.new_texts[118], inst.new_texts[136]).Expr.thirdOne.IsPartyEnabled(yes: false, 0).thirdOne.HasOnePartyMechanic(yes: true).thirdOne.AllLeadersAreDead().thirdOne.StartEvent(123).End,
			new Decision(inst.new_texts[119], inst.new_texts[137]).Expr.thirdOne.HasAutonomyForMacao(yes: true).thirdOne.IsTaiwanAttacked(yes: false).thirdOne.IsInTheOVD(yes: false, 1).thirdOne.IsInTheSEV(yes: false, 1).thirdOne.HasCulturalRevolution(yes: false).thirdOne.HasMaoismus(yes: false).thirdOne.IsDipRepLessThan(yes: true, 500).thirdOne.MakeProChinese(yes: true, 38).thirdOne.MakeProUSA(yes: false, 38).thirdOne.ChangeBotSystem(2, 38).thirdOne.AddChineseInfluence(30).thirdOne.AddSupport(50).thirdOne.AddLiberalization(-50).thirdOne.StartEvent(462).End,
			inst.gameState.modifies[6].active ? new Decision(inst.new_texts[120], inst.new_texts[138]).Expr.thirdOne.TibetIsOurs(yes: true).thirdOne.UyghurIsOurs(yes: true).thirdOne.HasAgents(1500).thirdOne.HasArmy(1500).thirdOne.HasMoney(1500).thirdOne.IsChiSovInfluenceLessThan(yes: false, 500).thirdOne.HasMaoismus(yes: true).thirdOne.IsAmericanInfluenceLessThan(yes: true, 100).thirdOne.IsTaiwanAttacked(yes: true).thirdOne.TheyAreOurs(1).thirdOne.HasAnnexedMacao(yes: true).thirdOne.HasAgressiveMilitaryDoctrine(yes: true).thirdOne.AnnexationInfo(7, 38, 1).thirdOne.MakeProUSA(yes: false, 38).thirdOne.AddRelations(0, -1000).thirdOne.AddChineseInfluence(50).thirdOne.AddPopulation(180).thirdOne.AddSupport(50).thirdOne.AddLiberalization(-50).thirdOne.AddAgents(-1500).thirdOne.AddMoney(-1500).thirdOne.AddArmy(-1500).thirdOne.StartEvent(457).End : new Decision(inst.new_texts[120], inst.new_texts[138]).Expr.thirdOne.TibetIsOurs(yes: true).thirdOne.UyghurIsOurs(yes: true).thirdOne.HasAgents(1500).thirdOne.HasArmy(1500).thirdOne.HasMoney(1500).thirdOne.IsChiSovInfluenceLessThan(yes: false, 500).thirdOne.IsUnityLessThan(yes: false, 700).thirdOne.IsAmericanInfluenceLessThan(yes: true, 100).thirdOne.IsTaiwanAttacked(yes: true).thirdOne.TheyAreOurs(1).thirdOne.HasAnnexedMacao(yes: true).thirdOne.HasAgressiveMilitaryDoctrine(yes: true).thirdOne.AnnexationInfo(7, 38, 1).thirdOne.MakeProUSA(yes: false, 38).thirdOne.AddRelations(0, -1000).thirdOne.AddChineseInfluence(50).thirdOne.AddPopulation(180).thirdOne.AddSupport(50).thirdOne.AddLiberalization(-50).thirdOne.AddAgents(-1500).thirdOne.AddMoney(-1500).thirdOne.AddArmy(-1500).End,
			new Decision(inst.new_texts[121], inst.new_texts[139]).Expr.thirdOne.HasLeftRadicalLeader(yes: true).thirdOne.TheyAreOurs(1).thirdOne.IsMaoPraised(yes: true).thirdOne.IsNotAntiMaoInTheUSSR().thirdOne.AddLiberalization(250).thirdOne.AddPowerToAllPoliticiansInTheFaction(0, 150).thirdOne.AddRelations(1, 250).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(2, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(3, -500).thirdOne.MaoismIsBetter(8).End,
			new Decision(inst.new_texts[122], inst.new_texts[140]).Expr.thirdOne.HasCommunistLeader(yes: true).thirdOne.HasSovietFriendship(yes: false).thirdOne.TheyAreOurs(1).thirdOne.HasEuropeansPuppets().thirdOne.ProChinese(12).thirdOne.ProChinese(8).thirdOne.IsChineseInfluenceLessThan(yes: false, 350).thirdOne.HasChosenInTheEvent(471, 0, 363).thirdOne.HasGorbachev().thirdOne.IsYearLess(yes: false, 1984).thirdOne.HasMaoismus(yes: true).thirdOne.HasCulturalRevolution(yes: true).thirdOne.EastEuropeAbandonSOV(yes: true).thirdOne.MakeEastEuropaProChina(yes: true).thirdOne.AddAmericanInfluence(100).thirdOne.AddRelations(0, 250).thirdOne.AddRelations(1, -1000).thirdOne.AddSovietInfluence(-1000).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(0, 500).thirdOne.MaoismSOVIsBetter(9).thirdOne.StartEvent(470).End,
			new Decision(inst.new_texts[123], inst.new_texts[141]).Expr.thirdOne.HasLeftRadicalLeader(yes: true).thirdOne.TheyAreOurs(1).thirdOne.QuelleGosstroy(33, 1, yes: true).thirdOne.QuelleGosstroy(58, 1, yes: true).thirdOne.QuelleGosstroy(80, 1, yes: true).thirdOne.HasMaoismus(yes: true).thirdOne.HasCulturalRevolution(yes: true).thirdOne.AddAgents(-250).thirdOne.AddArmy(-250).thirdOne.AddRelations(0, -250).thirdOne.AddRelations(1, -250).thirdOne.AddAmericanInfluence(-100).thirdOne.AddSovietInfluence(-100).thirdOne.AddDiplo(100).thirdOne.AddChineseInfluence(100).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(0, 500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(2, -500).thirdOne.AddLoyalityToAllPoliticiansInTheFaction(3, -500).thirdOne.MaoismIsBetter(10).thirdOne.StartEvent(548).End,
			new Decision(inst.new_texts[124], inst.new_texts[142]).Expr.thirdOne.IsPoliticianAlive(16, 16, 1, 5, 11).thirdOne.HasAgents(250).thirdOne.HasCulturalRevolution(yes: false).thirdOne.HasModerateFaction(yes: true).thirdOne.HasModerateLeader(yes: true).thirdOne.AddRelations(0, 250).thirdOne.AddRelations(1, 250).thirdOne.AddAgents(-250).thirdOne.AddLiberalization(250).thirdOne.AddSupport(150).thirdOne.AddStandardOfLiving(50).thirdOne.MakeHimLeader(16, 16, 1, 5, 11).thirdOne.KillTheLeaderOfTheFaction(0).thirdOne.KillTheLeaderOfTheFaction(1).thirdOne.KillTheLeaderOfTheFaction(3).thirdOne.KillTheLeaderOfTheFaction(4).End,
			new Decision(inst.new_texts[125], inst.new_texts[143]).Expr.thirdOne.HasOnePartyMechanic(yes: true).thirdOne.HasAgents(250).thirdOne.IsLiberal(yes: true).thirdOne.IsLeftRadBanned().thirdOne.HasCapitalistEconomy(yes: true).thirdOne.HasOligarchyPowerLess(yes: false, 60).thirdOne.AgreeToOligarchy(12).End,
			new Decision(inst.new_texts[126], inst.new_texts[144]).Expr.thirdOne.HasOnePartyMechanic(yes: true).thirdOne.HasCapitalistEconomy(yes: false).thirdOne.HasSovietFriendship(yes: true).thirdOne.IsYearLess(yes: true, 1984).thirdOne.IsMaoDemaoised(yes: true).thirdOne.HasRealModerateLeader(yes: true).thirdOne.AddRelations(1, 1000).thirdOne.BlockMarket(13).thirdOne.StartEvent(124).End,
			new Decision(inst.new_texts[127], inst.new_texts[145]).Expr.thirdOne.HasAgents(1000).thirdOne.HasMoney(500).thirdOne.HasMaoismus(yes: true).thirdOne.IsDeadJanataInIndia(yes: true).thirdOne.HasNaxalitsPowerLess(yes: false, 799).thirdOne.AddMoney(-500).thirdOne.AddAgents(-1500).thirdOne.AddRelations(1, -1000).thirdOne.AddChineseInfluence(50).thirdOne.StartEvent(125).End,
			new Decision(inst.new_texts[551], inst.new_texts[556], 2).Expr.thirdOne.HasCommunistLeader(yes: false).thirdOne.HasMaoismus(yes: false).thirdOne.HasCulturalRevolution(yes: false).thirdOne.HasCapitalistEconomy(yes: true).thirdOne.CreateNewLeader(32, 47, 3, 4, 14, 52).thirdOne.AddLiberalization(50).thirdOne.AddSupport(50).thirdOne.AddChineseInfluence(1).End,
			new Decision(inst.new_texts[552], inst.new_texts[557], 2).Expr.thirdOne.HasLeader(32, 47, 3, 4, 14).thirdOne.IsAutoritharian(yes: true).thirdOne.IsTraditional(yes: true).thirdOne.HasAgents(1500).thirdOne.HasArmy(1500).thirdOne.BlockFreedom(16).thirdOne.AddNewModify(38).thirdOne.AddAgents(-1500).thirdOne.AddArmy(-1500).End,
			new Decision(inst.new_texts[553], inst.new_texts[558], 2).Expr.thirdOne.IsYearLess(yes: false, 1981).thirdOne.HasChosenInTheEvent(308, 1, 85).thirdOne.HasAgents(500).thirdOne.HasMoney(500).thirdOne.AddAgents(-500).thirdOne.AddMoney(-500).thirdOne.AddNewModify(39).End,
			new Decision(inst.new_texts[554], inst.new_texts[559], 2).Expr.thirdOne.HasModerateLeader(yes: true).thirdOne.IsFactionBanned(0).thirdOne.IsFactionBanned(4).thirdOne.HasChosenInTheEvent(451, 1, 362).thirdOne.HasChosenInTheEvent(15, 1, 559).thirdOne.HasSomeoneWonInTheWar(1, 0, 23).thirdOne.HasAgents(500).thirdOne.HasMoney(500).thirdOne.AddAgents(-500).thirdOne.AddMoney(-500).thirdOne.AddNewModify(40).thirdOne.BlockForStatemoncap(18).End,
			(inst.gameState.allcountries[9].puppetOf != 1) ? new Decision(inst.new_texts[555], inst.new_texts[560], 2).Expr.thirdOne.IsUnitarism(yes: false).thirdOne.ProChinese(9).thirdOne.TheyAreOurs(1).thirdOne.HasAgents(500).thirdOne.HasMoney(500).thirdOne.IsChineseInfluenceLessThan(yes: false, 750).thirdOne.IsUnityLessThan(yes: false, 700).thirdOne.AddPopulation(20).thirdOne.AddSupport(100).thirdOne.AddChineseInfluence(10).thirdOne.AddAgents(-500).thirdOne.AddMoney(-500).thirdOne.GetMongolia(19).End : new Decision(" 整 合 漠 北", " 时 代 的 浪 潮 滚 滚 向 前 ， 在 我 们 对 蒙 古 的 战 争 大 获 全 胜 后 ， 是 时 候 把 蒙 古 纳 入 辽 阔 的 国 土 之 中 了 。 我 们 将 把 蒙 古 细 细 的 拆 分 ， 恢 复 乌 兰 巴 托 的 古 老 名 称 库 伦 。 组 建 特 别 联 合 治 安 部 ， 开 设 “ 汉 语 学 习 班 ” ， 监 控 所 有 的 坏 分 子 ， 削 弱 蒙 文 的 地 位 ， 并 最 终 摧 毁 蒙 人 抵 抗 的 意 识 。 他 们 将 变 成 像 壮 族 一 样 的 模 范 公 民 ， 在 为 祖 国 保 卫 边 疆 的 过 程 中 证 明 自 己 。 这 就 是 叛 徒 的 下 场 ！").Expr.thirdOne.ProChinese(9).thirdOne.TheyAreOurs(1).thirdOne.AddPopulation(20).thirdOne.AddSupport(100).thirdOne.AddChineseInfluence(100).thirdOne.GetMongolia(19).End,
			(inst.gameState.allcountries[30].Gosstroy != 1) ? new Decision(inst.new_texts[577], inst.new_texts[578], 3).Expr.thirdOne.IsOARCreated(yes: true).thirdOne.IsOARfull(yes: true).thirdOne.IsNoWars(yes: true).thirdOne.IsYearLess(yes: false, 1983).thirdOne.IsChineseInfluenceLessThan(yes: false, 800).thirdOne.HasMoney(300).thirdOne.QuelleGosstroy(84, 2, yes: true).thirdOne.QuelleGosstroy(30, 2, yes: true).thirdOne.HasAgents(300).thirdOne.IsRael(yes: true).thirdOne.AddAgents(-300).thirdOne.AddMoney(-300).thirdOne.CreateBigOAR(yes: true).thirdOne.StartEvent(465).End : new Decision(" 成 立 阿 拉 伯 革 命 社 会 主 义 共 和 国", " 时 代 的 浪 潮 滚 滚 向 前 ， 新 的 革 命 者 们 接 过 了 前 辈 的 旗 帜 ， 社 会 主 义 的 东 风 已 经 吹 入 了 阿 拉 伯 半 岛 。 碍 于 国 内 外 形 势 ， 阿 拉 伯 的 革 命 者 们 不 得 不 抱 团 取 暖 ， 在 剿 匪 镇 反 方 面 共 同 合 作 。 但 他 们 应 当 更 进 一 步 ， 在 我 们 的 帮 助 下 ， 我 们 会 帮 他 们 组 建 一 个 超 越 国 境 线 的 经 济 - 政 治 - 军 事 联 盟 。 革 命 的 红 旗 高 高 飘 扬 ， 试 问 谁 能 阻 挡 的 了 ？").Expr.thirdOne.IsOARfull(yes: true).thirdOne.IsNoWars(yes: true).thirdOne.IsChineseInfluenceLessThan(yes: false, 500).thirdOne.HasMoney(100).thirdOne.HasAgents(100).thirdOne.AddAgents(-100).thirdOne.AddMoney(-100).thirdOne.StartEvent(64).End,
			new Decision(inst.new_texts[589], inst.new_texts[590], 3).Expr.thirdOne.IsChineseInfluenceLessThan(yes: false, 200).thirdOne.IsChinaWarAliance(yes: true).thirdOne.IsScienceDone(19, yes: true).thirdOne.HasMoney(100).thirdOne.AddMoney(-100).thirdOne.OnAgentModif(yes: true).End,
			new Decision(inst.new_texts[629], inst.new_texts[630], 3).Expr.thirdOne.IsChineseInfluenceLessThan(yes: false, 200).thirdOne.IsChinaWarAliance(yes: true).thirdOne.IsScienceDone(23, yes: true).thirdOne.HasMoney(100).thirdOne.AddMoney(-100).thirdOne.OnArmyModif(yes: true).End,
			new Decision(inst.new_texts[632], inst.new_texts[636], 3).Expr.thirdOne.IsInTheSEATO(yes: true, 1).thirdOne.IsInTheSENTO(yes: true, 8).thirdOne.IsInTheSENTO(yes: true, 31).thirdOne.IsYearLess(yes: false, 1980).thirdOne.HasMoney(300).thirdOne.HasArmy(300).thirdOne.AddMoney(-300).thirdOne.AddArmy(-300).thirdOne.AddChineseInfluence(50).thirdOne.AddAmericanInfluence(50).thirdOne.AddSovietInfluence(-50).thirdOne.AddRelations(1, -250).thirdOne.AddRelations(0, 250).thirdOne.MakeInWPO(yes: true, 9).thirdOne.OnSEATO(yes: true).End,
			new Decision(inst.new_texts[641], inst.new_texts[642], 3).Expr.thirdOne.HasAgents(150).thirdOne.IsScienceDone(25, yes: true).thirdOne.Oncein(24, 6, yes: true).thirdOne.DoTimer(24, 6).thirdOne.AddAgents(-150).thirdOne.AddSovietInfluence(-50).End,
			new Decision(inst.new_texts[645], inst.new_texts[646], 3).Expr.thirdOne.HasAgents(150).thirdOne.IsScienceDone(25, yes: true).thirdOne.Oncein(25, 6, yes: true).thirdOne.AddAgents(-150).thirdOne.DoTimer(25, 6).thirdOne.AddAmericanInfluence(-50).End,
			new Decision(inst.new_texts[647], inst.new_texts[648], 3).Expr.thirdOne.IsInTheWP(yes: true, 1).thirdOne.HasAgents(50).thirdOne.HasArmy(150).thirdOne.HasMoney(50).thirdOne.IsScienceDone(19, yes: true).thirdOne.Oncein(26, 6, yes: true).thirdOne.AddAgents(-50).thirdOne.AddArmy(-150).thirdOne.AddMoney(-50).thirdOne.DoTimer(26, 6).thirdOne.AddSovietInfluence(-10).thirdOne.AddinflAlliance(-350, 1).thirdOne.AddinflAlliance(200, 3).End,
			new Decision(inst.new_texts[653], inst.new_texts[654], 3).Expr.thirdOne.IsInTheSEATO(yes: true, 1).thirdOne.HasAgents(50).thirdOne.HasArmy(150).thirdOne.HasMoney(50).thirdOne.IsScienceDone(19, yes: true).thirdOne.Oncein(27, 6, yes: true).thirdOne.AddAgents(-50).thirdOne.AddArmy(-150).thirdOne.AddMoney(-50).thirdOne.DoTimer(27, 6).thirdOne.AddAmericanInfluence(-10).thirdOne.AddinflAlliance(-350, 2).thirdOne.AddinflAlliance(200, 3).End,
			new Decision(inst.new_texts[655], inst.new_texts[656], 3).Expr.thirdOne.HasAgents(200).thirdOne.HasArmy(250).thirdOne.HasMoney(200).thirdOne.IsScienceDone(20, yes: true).thirdOne.IsScienceDone(24, yes: true).thirdOne.Oncein(28, 6, yes: true).thirdOne.AddAgents(-200).thirdOne.AddArmy(-250).thirdOne.AddMoney(-200).thirdOne.DoTimer(28, 6).thirdOne.AddSovietInfluence(-10).thirdOne.AddAllAfrique(-250, 1).thirdOne.AddAllAfrique(100, 3).thirdOne.AddStabilityAfrique(-100).End,
			new Decision(inst.new_texts[657], inst.new_texts[658], 3).Expr.thirdOne.HasAgents(200).thirdOne.HasArmy(250).thirdOne.HasMoney(200).thirdOne.IsScienceDone(20, yes: true).thirdOne.IsScienceDone(24, yes: true).thirdOne.Oncein(29, 6, yes: true).thirdOne.AddAgents(-200).thirdOne.AddArmy(-250).thirdOne.AddMoney(-200).thirdOne.DoTimer(29, 6).thirdOne.AddAmericanInfluence(-10).thirdOne.AddAllAfrique(-250, 2).thirdOne.AddAllAfrique(100, 3).thirdOne.AddStabilityAfrique(-100).End,
			new Decision(inst.new_texts[667], inst.new_texts[669], 3).Expr.thirdOne.HasMoney(50).thirdOne.Oncein(30, 6, yes: true).thirdOne.AddMoney(-50).thirdOne.DoTimer(30, 6).thirdOne.AddChineseInfluence(-10).thirdOne.AddRelations(0, -150).thirdOne.AddRelations(1, -150).thirdOne.AddDiplo(100).End,
			new Decision(inst.new_texts[670], inst.new_texts[671], 3).Expr.thirdOne.HasMoney(50).thirdOne.Oncein(31, 6, yes: true).thirdOne.AddMoney(-50).thirdOne.DoTimer(31, 6).thirdOne.AddChineseInfluence(-10).thirdOne.AddRelations(0, 150).thirdOne.AddRelations(1, 150).thirdOne.AddDiplo(-100).End,
			new Decision(inst.new_texts[672], inst.new_texts[673], 3).Expr.thirdOne.HasMoney(50).thirdOne.Oncein(32, 6, yes: true).thirdOne.DoTimer(32, 6).thirdOne.AddMoney(-50).thirdOne.IsScienceDone(10, yes: true).thirdOne.HasOil(yes: true).thirdOne.IsIndustry(inst.gameState.data[152], yes: true).thirdOne.AddOilPrud(150).End,
			new Decision(inst.new_texts[678], inst.new_texts[679], 3).Expr.thirdOne.HasMoney(100).thirdOne.IsScienceDone(12, yes: true).thirdOne.AddMoney(-100).thirdOne.HasOil(yes: true).thirdOne.IsIndustry(700, yes: true).thirdOne.HasSovietFriendship(yes: true).thirdOne.IsRealtions(700, 1, yes: true).thirdOne.AddOldModify(58).End,
			new Decision(inst.new_texts[682], inst.new_texts[683], 3).Expr.thirdOne.HasMoney(50).thirdOne.Oncein(34, 6, yes: true).thirdOne.DoTimer(34, 6).thirdOne.IsScienceDone(16, yes: true).thirdOne.AddMoney(-50).thirdOne.HasOil(yes: true).thirdOne.IsIndustry(700, yes: true).thirdOne.HasOilEat(200).thirdOne.AddOilEat(-100).End,
			new Decision(inst.new_texts[688], inst.new_texts[689], 3).Expr.thirdOne.HasMoney(100).thirdOne.HasAgents(100).thirdOne.ISCIA(yes: true).thirdOne.HasSovietFriendship(yes: false).thirdOne.IsYearLess(yes: false, 1983).thirdOne.IsChineseInfluenceLessThan(yes: false, 350).thirdOne.IsScienceDone(10, yes: true).thirdOne.HasOil(yes: true).thirdOne.IsIndustry(700, yes: true).thirdOne.ProChinese(33).thirdOne.AddMoney(-100).thirdOne.AddAgents(-100).thirdOne.AddOilPrice(-10).thirdOne.AddSovietInfluence(-200).thirdOne.AddAmericanInfluence(150).thirdOne.AddChineseInfluence(100).thirdOne.IsScienceDone(10, yes: true).thirdOne.HasOil(yes: true).thirdOne.IsIndustry(700, yes: true).End,
			new Decision(" 斩 断 锁 链 ， 涅 槃 重 生", " 非 洲 - - 人 类 的 故 乡 ， 在 殖 民 者 的 手 中 饱 经 摧 残 ， 造 成 了 人 类 有 史 以 来 最 残 暴 的 强 制 迁 徙 和 种 族 灭 绝 。 而 随 着 非 洲 人 民 的 觉 醒 ， 这 一 切 都 不 会 再 发 生 了 。 泛 非 主 义 者 们 强 烈 要 求 在 某 种 程 度 上 统 一 非 洲 ， 不 论 国 际 组 织 还 是 松 散 的 联 邦 。 我 们 将 帮 助 他 们 组 建 用 于 协 调 非 洲 各 进 步 国 家 和 革 命 组 织 的 联 盟 , 这 对 我 们 和 非 洲 各 国 都 有 好 处 。 不 过 帝 国 主 义 者 … … 但 是 谁 在 乎 他 们 呢 ， 胜 利 属 于 觉 醒 的 人 民 !", 3).Expr.thirdOne.HasLeftRadicalLeader(yes: true).thirdOne.HasMoney(200).thirdOne.IsAfricanProprc(yes: true).thirdOne.IsAfricanSocialism(yes: true).thirdOne.AfricanAlliance(yes: true).thirdOne.AddRelations(1, -500).thirdOne.AddRelations(0, -500).thirdOne.StartEvent(500).End,
			new Decision(" 攘 外 安 内 ， 伟 大 复 兴", " 我 们 内 部 的 敌 人 固 然 凶 险 ， 但 在 名 义 上 他 们 还 是 我 国 内 政 。 相 比 起 来 ， 境 外 的 敌 人 更 令 我 们 担 忧 。 不 论 是 虎 视 眈 眈 的 苏 联 社 会 帝 国 主 义 ， 像 猎 鹰 般 凶 狠 的 美 帝 国 主 义 ， 乃 至 于 山 连 山 水 连 水 的 “ 兄 弟 国 家 ” 越 南 都 展 现 出 了 令 人 担 忧 的 离 心 力 。 为 了 我 们 社 会 的 安 定 发 展 ， 我 们 有 必 要 展 开 一 场 特 别 的 “ 联 合 军 事 演 习 ” 。", 3).Expr.thirdOne.HaveBeenZhuTi(yes: true).thirdOne.HaveFullChina(yes: true).thirdOne.TheyAreOurs(1).thirdOne.NoZhuTiWar(yes: true).thirdOne.HasntJueQi(yes: true).thirdOne.StartEvent(642).End
		};
		if (array != null)
		{
			for (int j = 0; j < array.Length; j++)
			{
				inst.gameState.completedDecisions[j] = array[j];
			}
		}
		else if (inst.gameState.completedDecisions.Length != inst.gameState.decisions.Length)
		{
			inst.gameState.completedDecisions = new bool[inst.gameState.decisions.Length];
		}
	}

	public void MusicReset()
	{
		music[now_playing].UnloadAudioData();
		int num = now_playing;
		if (!get_to_cycle)
		{
			while (now_playing == num)
			{
				if (!zadan_music)
				{
					if (albumNum == 0)
					{
						now_playing = Random.Range(0, 10);
					}
					else if (albumNum == 1)
					{
						now_playing = Random.Range(10, 40);
					}
					else if (albumNum == 2)
					{
						now_playing = Random.Range(40, 61);
					}
					else if (albumNum == 3)
					{
						now_playing = Random.Range(61, 78);
					}
					else
					{
						now_playing = Random.Range(0, 40);
					}
				}
				else
				{
					now_playing = zadan_playing;
					zadan_music = false;
				}
			}
		}
		else if (!zadan_music)
		{
			now_playing = num;
		}
		else
		{
			now_playing = zadan_playing;
			zadan_music = false;
		}
		music[now_playing].LoadAudioData();
		is_ready_to_play = true;
		zadan_music = false;
	}

	public void Init()
	{
		inst = this;
		Application.targetFrameRate = 60;
		NewAwake();
	}

	private void NewAwake()
	{
		if (!PlayerPrefs.HasKey("voice_china"))
		{
			PlayerPrefs.SetInt("voice_china", 5);
		}
		if (PlayerPrefs.HasKey("our_diff_in"))
		{
			inst.gameState.diff = PlayerPrefs.GetInt("our_diff_in");
		}
		if (PlayerPrefs.HasKey("SavePosition"))
		{
			autosavej = PlayerPrefs.GetInt("SavePosition");
		}
		if (PlayerPrefs.HasKey("SavePlaceNum"))
		{
			savePlace = PlayerPrefs.GetInt("SavePlaceNum");
		}
		for (int i = 0; i < inst.gameState.politics.Length; i++)
		{
			inst.gameState.politics[i] = new Politic();
		}
		voice = PlayerPrefs.GetInt("voice_china");
		inst.gameState.turn_on = true;
		Application.targetFrameRate = 60;
		string text = "";
		string[] array = text.Split(':');
		TextAsset textAsset = ((PlayerPrefs.GetInt("language") != 0) ? (Resources.Load("Doctr_ru") as TextAsset) : (Resources.Load("Doctr_en") as TextAsset));
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split(';');
		for (int j = 0; j < array.Length; j++)
		{
			inst.gameState.doctr[j] = array[j];
		}
	}

	private void FixedUpdate()
	{
		if (GetComponent<AudioSource>().volume != (float)voice / 100f)
		{
			GetComponent<AudioSource>().volume = (float)voice / 100f;
		}
		if (music[now_playing].loadState == AudioDataLoadState.Failed)
		{
			MusicReset();
		}
		else if (is_ready_to_play && music[now_playing].loadState == AudioDataLoadState.Loaded)
		{
			is_ready_to_play = false;
			GetComponent<AudioSource>().PlayOneShot(music[now_playing]);
		}
		else if (!is_ready_to_play && !GetComponent<AudioSource>().isPlaying)
		{
			MusicReset();
		}
	}
}
