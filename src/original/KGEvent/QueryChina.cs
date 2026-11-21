using System;
using MoonSharp.Interpreter;

namespace KGEvent
{
	[Serializable]
	[MoonSharpUserData]
	public class QueryChina<T> where T : IRequesting<T>
	{
		private T target;

		private int country = 2;

		public QueryChina(T target)
		{
			this.target = target;
		}

		public T PartySupportMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[1]);
		}

		public T PartySupportLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[1]);
		}

		public T SovietInfluenceMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[2]);
		}

		public T SovietInfluenceLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[2]);
		}

		public T AddSovietInfluence(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.empires[1].power += value;
			});
		}

		public T PeopleSupportMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[3]);
		}

		public T PeopleSupportLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[3]);
		}

		public T PeopleLiberalizationMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[4]);
		}

		public T PeopleLiberalizationLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[4]);
		}

		public T StandardLivingMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[5]);
		}

		public T StandardLivingLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[5]);
		}

		public T DiplomaticReputationMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[6]);
		}

		public T DiplomaticReputationLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[6]);
		}

		public T InfluenceMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[7]);
		}

		public T InfluenceLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[7]);
		}

		public T MoneyMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[8]);
		}

		public T MoneyLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[8]);
		}

		public T AgentNetworkMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[9]);
		}

		public T AgentNetworkLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[9]);
		}

		public T AddAgentNetwork(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[9] += value;
			});
		}

		public T SciencePointMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[11]);
		}

		public T SciencePointLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[11]);
		}

		public T AddSciencePoint(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[11] += value;
			});
		}

		public T IndustryMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[12]);
		}

		public T IndustryLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[12]);
		}

		public T AddIndustry(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[12] += value;
			});
		}

		public T AgricultureMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[12]);
		}

		public T AgricultureLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[12]);
		}

		public T AddAgriculture(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[12] += value;
			});
		}

		public T IsAuthoritarianism()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[14] == 0);
		}

		public T EstablishAuthoritarianism()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[14] = 0;
			});
		}

		public T IsConservativeSocialism()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[14] == 1);
		}

		public T EstablishConservativeSocialism()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[14] = 1;
			});
		}

		public T IsSocialismWithNationalSpecifics()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[14] == 2);
		}

		public T EstablishSocialismWithNationalSpecifics()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[14] = 2;
			});
		}

		public T IsXiaopism()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[14] == 3);
		}

		public T EstablishXiaopism()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[14] = 3;
			});
		}

		public T IsSocialDemocracy()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[14] == 4);
		}

		public T EstablishSocialDemocracy()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[14] = 4;
			});
		}

		public T IsLiberalism()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[14] == 5);
		}

		public T EstablishLiberalism()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[14] = 5;
			});
		}

		public T IsNoParties()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[15] == 6);
		}

		public T EstablishNoParties()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[15] = 6;
			});
		}

		public T IsPeoplesParty()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[15] == 7);
		}

		public T EstablishPeoplesParty()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[15] = 7;
			});
		}

		public T IsLimitedMultiparty()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[15] == 8);
		}

		public T EstablishLimitedMultiparty()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[15] = 8;
			});
		}

		public T IsFreeMultiparty()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[15] == 9);
		}

		public T EstablishFreeMultiparty()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[15] = 9;
			});
		}

		public T IsLatePlan()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[16] == 10);
		}

		public T EstablishLatePlan()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[16] = 10;
			});
		}

		public T IsAutomatedPlan()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[16] == 11);
		}

		public T EstablishAutomatedPlan()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[16] = 11;
			});
		}

		public T IsMonopolyStateCapitalism()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[16] == 12);
		}

		public T EstablishMonopolyStateCapitalism()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[16] = 12;
			});
		}

		public T IsBirdsCage()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[16] == 13);
		}

		public T EstablishBirdsCage()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[16] = 13;
			});
		}

		public T IsMixed()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[16] == 14);
		}

		public T EstablishMixed()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[16] = 14;
			});
		}

		public T IsMinimumRegulation()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[16] == 15);
		}

		public T EstablishMinimumRegulation()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[16] = 15;
			});
		}

		public T IsTotalControl()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[17] == 16);
		}

		public T EstablishTotalControl()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[17] = 16;
			});
		}

		public T IsFixed()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[17] == 17);
		}

		public T EstablishFixed()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[17] = 17;
			});
		}

		public T IsPluralism()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[17] == 18);
		}

		public T EstablishPluralism()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[17] = 18;
			});
		}

		public T IsFullFree()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[17] == 19);
		}

		public T EstablishFullFree()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[17] = 19;
			});
		}

		public T IsTotalitarianism()
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.data[18] == 20);
		}

		public T EstablishTotalitarianism()
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[18] = 20;
			});
		}

		public T HaveModifer(int value)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.modifies[value].active);
		}

		public T AddHaveModifer(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.modifies[value].active = true;
			});
		}

		public T RemoveHaveModifer(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.modifies[value].active = false;
			});
		}

		public T HaveScience(int value)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.science[value]);
		}

		public T AddHaveScience(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.science[value] = true;
			});
		}

		public T RemoveHaveScience(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.science[value] = false;
			});
		}

		public T AddOpinionRadical(int value)
		{
			return target.CreateActive(delegate
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic.traits[0] == 0)
					{
						politic.loyality += value;
					}
				}
			});
		}

		public T AddOpinionMixed(int value)
		{
			return target.CreateActive(delegate
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic.traits[0] == 1)
					{
						politic.loyality += value;
					}
				}
			});
		}

		public T AddOpinionReformost(int value)
		{
			return target.CreateActive(delegate
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic.traits[0] == 2)
					{
						politic.loyality += value;
					}
				}
			});
		}

		public T AddOpinionLiberals(int value)
		{
			return target.CreateActive(delegate
			{
				Politic[] politics = GlobalScript.inst.gameState.politics;
				foreach (Politic politic in politics)
				{
					if (politic.traits[0] == 3)
					{
						politic.loyality += value;
					}
				}
			});
		}

		public T AddPartySupport(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[1] += value;
			});
		}

		public T AddPeopleSupport(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[3] += value;
			});
		}

		public T AddPeopleLiberalization(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[4] += value;
			});
		}

		public T AddStandardLiving(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[5] += value;
			});
		}

		public T AddDiplomaticReputation(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[6] += value;
			});
		}

		public T AddInfluence(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[7] += value;
			});
		}

		public T AddMoney(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[8] += value;
			});
		}

		public T AddMaoWay(int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[88] += value;
			});
		}

		public T AddPoliticLoyality(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.politics[politic].loyality += value;
			});
		}

		public T AddModifer(int value)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.modifies[value].active = true);
		}

		public T RemoveModifer(int value)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.modifies[value].active = false);
		}

		public T AddScience(int value)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.science[value] = true);
		}

		public T RemoveScience(int value)
		{
			return target.CreateCondition(() => GlobalScript.inst.gameState.science[value] = false);
		}

		public T StateDebtMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[69]);
		}

		public T StateDebtLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[69]);
		}

		public T AddStateDebt(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[69] += value;
			});
		}

		public T ArmyFundingMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[71]);
		}

		public T ArmyFundingLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[71]);
		}

		public T AddArmyFunding(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[71] += value;
			});
		}

		public T FinancingMGBMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[72]);
		}

		public T FinancingMGBLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[72]);
		}

		public T AddFinancingMGB(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[72] += value;
			});
		}

		public T FinancingScienceMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[73]);
		}

		public T FinancingScienceLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[73]);
		}

		public T AddFinancingScience(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[73] += value;
			});
		}

		public T FinancingStateApparatusMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[74]);
		}

		public T FinancingStateApparatusLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[74]);
		}

		public T AddFinancingStateApparatus(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[74] += value;
			});
		}

		public T EnvelopeBudgetMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[75]);
		}

		public T EnvelopeBudgetLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[75]);
		}

		public T AddEnvelopeBudget(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[75] += value;
			});
		}

		public T FundingPropagandaMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[76]);
		}

		public T FundingPropagandaLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[76]);
		}

		public T AddFundingPropaganda(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[76] += value;
			});
		}

		public T FinancingAgriculturalMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[77]);
		}

		public T FinancingAgriculturalLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[77]);
		}

		public T AddFinancingAgricultural(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[77] += value;
			});
		}

		public T FinancingIndustryMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[78]);
		}

		public T FinancingIndustryLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[78]);
		}

		public T AddFinancingIndustry(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[78] += value;
			});
		}

		public T FinancingServiceSectorMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[79]);
		}

		public T FinancingServiceSectorLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[79]);
		}

		public T AddFinancingServiceSector(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[79] += value;
			});
		}

		public T FinancingSocialPolicyMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[80]);
		}

		public T FinancingSocialPolicyLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[80]);
		}

		public T AddFinancingSocialPolicy(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[80] += value;
			});
		}

		public T FinancingDiplomaticMissionsMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[81]);
		}

		public T FinancingDiplomaticMissionsLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[81]);
		}

		public T AddFinancingDiplomaticMissions(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[81] += value;
			});
		}

		public T ServicesSectorMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[68]);
		}

		public T ServicesSectorLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[68]);
		}

		public T AddServicesSector(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[68] += value;
			});
		}

		public T MilitaryEstablishmentMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[51]);
		}

		public T MilitaryEstablishmentLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[51]);
		}

		public T AddMilitaryEstablishment(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[51] += value;
			});
		}

		public T RelationsWithUSSRMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[29]);
		}

		public T RelationsWithUSSRLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[29]);
		}

		public T AddRelationsWithUSSR(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.empires[1].relations += value;
			});
		}

		public T RelationsWithUSAMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[28]);
		}

		public T RelationsWithUSALess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[28]);
		}

		public T AddRelationsWithUSA(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.empires[0].relations += value;
			});
		}

		public T ArmyStrengthMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[22]);
		}

		public T ArmyStrengthLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[22]);
		}

		public T AddArmyStrength(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[22] += value;
			});
		}

		public T CorruptionMore(int value)
		{
			return target.CreateCondition(() => value < GlobalScript.inst.gameState.data[26]);
		}

		public T CorruptionLess(int value)
		{
			return target.CreateCondition(() => value > GlobalScript.inst.gameState.data[26]);
		}

		public T AddCorruption(int politic, int value)
		{
			return target.CreateActive(delegate
			{
				GlobalScript.inst.gameState.data[26] += value;
			});
		}
	}
}
