using System;
using Focuses;
using LFKG;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour
{
	public string new_scene;

	public string this_scene;

	public int number = 1;

	private GlobalScript global1;

	private void OnMouseDown()
	{
		if (number <= 0)
		{
			return;
		}
		int @int = PlayerPrefs.GetInt("language");
		for (int i = 0; i < GlobalScript.inst.gameState.science.Length; i++)
		{
			GlobalScript.inst.gameState.science[i] = false;
			GlobalScript.inst.gameState.science_in_progress[i] = false;
			GlobalScript.inst.gameState.science_need_time[i] = 0;
			GlobalScript.inst.gameState.science_time[i] = 0;
		}
		for (int j = 0; j < GlobalScript.inst.gameState.war_active.Length; j++)
		{
			GlobalScript.inst.gameState.war_active[j] = true;
		}
		for (int k = 0; k < GlobalScript.inst.gameState.modifies.Length; k++)
		{
			GlobalScript.inst.gameState.modifies[k].active = false;
		}
		for (int l = 0; l < GlobalScript.inst.gameState.allcountries.Length; l++)
		{
			GlobalScript.inst.gameState.allcountries[l].dev = 0;
			GlobalScript.inst.gameState.allcountries[l].based = false;
			GlobalScript.inst.gameState.allcountries[l].cw = false;
		}
		for (int m = 0; m < GlobalScript.inst.gameState.checking.Length; m++)
		{
			GlobalScript.inst.gameState.checking[m] = false;
		}
		for (int n = 0; n < GlobalScript.inst.gameState.desnull.Length; n++)
		{
			GlobalScript.inst.gameState.desnull[n] = 0;
		}
		for (int num = 0; num < GlobalScript.inst.gameState.event_done.Length; num++)
		{
			GlobalScript.inst.gameState.event_done[num] = false;
		}
		for (int num2 = 0; num2 < GlobalScript.inst.gameState.resultOfEvents.Length; num2++)
		{
			GlobalScript.inst.gameState.resultOfEvents[num2] = -1;
		}
		for (int num3 = 0; num3 < GlobalScript.inst.gameState.Events_active.Length; num3++)
		{
			GlobalScript.inst.gameState.Events_active[num3] = false;
		}
		global1.speed = 0;
		for (int num4 = 0; num4 < GlobalScript.inst.gameState.data_old.Length; num4++)
		{
			GlobalScript.inst.gameState.data_old[num4] = 0;
		}
		for (int num5 = 0; num5 < GlobalScript.inst.gameState.ingamewars.Length; num5++)
		{
			GlobalScript.inst.gameState.ingamewars[num5] = new warinwars
			{
				is_going = false
			};
		}
		for (int num6 = 0; num6 < GlobalScript.inst.gameState.science_time.Length; num6++)
		{
			GlobalScript.inst.gameState.science_time[num6] = 0;
		}
		GlobalScript.inst.gameState.modifies[0].active = true;
		GlobalScript.inst.gameState.modifies[1].active = true;
		GlobalScript.inst.gameState.modifies[2].active = true;
		GlobalScript.inst.gameState.modifies[3].active = true;
		GlobalScript.inst.gameState.modifies[6].active = true;
		GlobalScript.inst.gameState.modifies[14].active = true;
		GlobalScript.inst.gameState.modifies[15].active = true;
		GlobalScript.inst.gameState.modifies[28].active = true;
		GlobalScript.inst.gameState.modifies[54].active = true;
		GlobalScript.inst.gameState.modifies[55].active = true;
		if (GlobalScript.inst.dlc[3])
		{
			GlobalScript.inst.gameState.modifies[42].active = true;
			GlobalScript.inst.gameState.modifies[50].active = true;
			GlobalScript.inst.gameState.modifies[56].active = true;
			GlobalScript.inst.gameState.OilProd = 850f;
		}
		GlobalScript.inst.gameState.is_elect = true;
		GlobalScript.inst.gameState.is_speech = true;
		GlobalScript.inst.gameState.is_konst_max = true;
		GlobalScript.inst.gameState.is_gkchp = false;
		GlobalScript.inst.gameState.turn_on = false;
		GlobalScript.inst.gameState.relres = false;
		GlobalScript.inst.gameState.BritLost = false;
		GlobalScript.inst.gameState.vietnampeace = false;
		GlobalScript.inst.gameState.war = 0;
		GlobalScript.inst.gameState.allcountries[1].numberOfSpecialEnding = 0;
		GlobalScript.inst.gameState.iranrev = false;
		GlobalScript.inst.gameState.guns = false;
		GlobalScript.inst.gameState.DRAagree = false;
		GlobalScript.inst.gameState.CBIndia = false;
		GlobalScript.inst.gameState.OAR = false;
		GlobalScript.inst.gameState.Israellost = false;
		GlobalScript.inst.gameState.YugAgree = false;
		GlobalScript.inst.gameState.sanct = false;
		GlobalScript.inst.gameState.donat = false;
		GlobalScript.inst.gameState.ICP = false;
		GlobalScript.inst.gameState.IndOpp = false;
		GlobalScript.inst.gameState.HelpGandi = false;
		GlobalScript.inst.gameState.SovAlb = false;
		GlobalScript.inst.gameState.SEZ = false;
		GlobalScript.inst.gameState.TaiCoup = false;
		GlobalScript.inst.gameState.SKRebel = false;
		GlobalScript.inst.gameState.bad_done = false;
		GlobalScript.inst.gameState.bad_debuff = false;
		GlobalScript.inst.gameState.iron_and_blood = GlobalScript.inst.gameState.diff >= 2;
		GlobalScript.inst.gameState.is_save_bylo = false;
		TextAsset textAsset = ((@int != 0) ? (Resources.Load("Part_ru") as TextAsset) : (Resources.Load("Part_en") as TextAsset));
		string text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		string[] array = text.Split(':');
		for (int num7 = 0; num7 < array.Length; num7++)
		{
			string[] array2 = array[num7].Split(';');
			if (array2[0] == number.ToString())
			{
				for (int num8 = 0; num8 < GlobalScript.inst.gameState.party_name.Length; num8++)
				{
					GlobalScript.inst.gameState.party_name[num8] = array2[num8 + 1];
				}
				break;
			}
		}
		textAsset = ((@int != 0) ? (Resources.Load("Doctr_ru") as TextAsset) : (Resources.Load("Doctr_en") as TextAsset));
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split(';');
		for (int num9 = 0; num9 < array.Length; num9++)
		{
			GlobalScript.inst.gameState.doctr[num9] = array[num9];
		}
		textAsset = Resources.Load("Country_data_" + number) as TextAsset;
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		text = text.Replace("\n", "");
		array = text.Split(':');
		for (int num10 = 0; num10 < array.Length; num10++)
		{
			string[] array3 = array[num10].Split(';');
			int num11 = int.Parse(array3[0]);
			GlobalScript.inst.gameState.allcountries[num11] = new Country
			{
				isSEV = (array3[1] == "1"),
				isOVD = (array3[2] == "1"),
				Vyshi = (array3[3] == "1"),
				proprc = (array3[4] == "1"),
				prosov = (array3[5] == "1"),
				okb = (array3[6] == "1"),
				econ = (array3[7] == "1"),
				Torg = (array3[8] == "1"),
				usalliance = (array3[9] == "1"),
				sovalliance = (array3[10] == "1"),
				cw = false,
				stab = int.Parse(array3[12]),
				dev = int.Parse(array3[13]),
				sovpower = int.Parse(array3[14]),
				usapower = int.Parse(array3[15]),
				prcpower = int.Parse(array3[16]),
				Gosstroy = int.Parse(array3[17]),
				SubGosstroy = int.Parse(array3[18])
			};
		}
		GlobalScript.inst.gameState.allcountries[49].Vyshi = false;
		DLC00(@int);
		textAsset = ((@int != 0) ? (Resources.Load("polit_names1_ru") as TextAsset) : (Resources.Load("polit_names1_en") as TextAsset));
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split('\n');
		GlobalScript.inst.gameState.names1 = new string[array.Length];
		for (int num12 = 0; num12 < array.Length; num12++)
		{
			GlobalScript.inst.gameState.names1[num12] = array[num12];
		}
		textAsset = ((@int != 0) ? (Resources.Load("polit_names2_ru") as TextAsset) : (Resources.Load("polit_names2_en") as TextAsset));
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split('\n');
		GlobalScript.inst.gameState.names2 = new string[array.Length];
		for (int num13 = 0; num13 < array.Length; num13++)
		{
			GlobalScript.inst.gameState.names2[num13] = array[num13];
		}
		textAsset = ((@int != 0) ? (Resources.Load("Country_ru") as TextAsset) : (Resources.Load("Country_en") as TextAsset));
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split('\n');
		GlobalScript.inst.country_texts = new string[array.Length];
		for (int num14 = 0; num14 < array.Length; num14++)
		{
			GlobalScript.inst.gameState.allcountries[num14].name = array[num14];
			GlobalScript.inst.country_texts[num14] = array[num14];
		}
		textAsset = Resources.Load("Data" + number) as TextAsset;
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		text = text.Replace("\n", null);
		array = text.Split(';');
		for (int num15 = 1; num15 < array.Length; num15++)
		{
			GlobalScript.inst.gameState.data[num15] = int.Parse(array[num15]);
		}
		GlobalScript.inst.gameState.influencePRC = GlobalScript.inst.gameState.data[7];
		textAsset = Resources.Load("Party_data_" + number) as TextAsset;
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		text = text.Replace("\n", null);
		array = text.Split(':');
		for (int num16 = 0; num16 < array.Length; num16++)
		{
			string[] array4 = array[num16].Split(';');
			GlobalScript.inst.gameState.is_party_enabled[num16] = array4[0] == "1";
			GlobalScript.inst.gameState.is_party_ally[num16] = array4[1] == "1";
			GlobalScript.inst.gameState.party_ideology[num16] = int.Parse(array4[2]);
			GlobalScript.inst.gameState.party_number[num16] = int.Parse(array4[3]);
		}
		textAsset = Resources.Load("Politics_inf") as TextAsset;
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split(';');
		for (int num17 = 0; num17 < array.Length; num17++)
		{
			string[] array5 = array[num17].Split(':');
			GlobalScript.inst.gameState.politics[num17].name_1 = int.Parse(array5[0]);
			GlobalScript.inst.gameState.politics[num17].name_2 = int.Parse(array5[1]);
			GlobalScript.inst.gameState.politics[num17].traits[0] = (byte)int.Parse(array5[2]);
			GlobalScript.inst.gameState.politics[num17].traits[1] = (byte)int.Parse(array5[3]);
			GlobalScript.inst.gameState.politics[num17].traits[2] = (byte)int.Parse(array5[4]);
			GlobalScript.inst.gameState.politics[num17].age = (byte)int.Parse(array5[5]);
			GlobalScript.inst.gameState.politics[num17].power = (byte)int.Parse(array5[6]) * 10;
			if (UnityEngine.Random.Range(0f, 1f) > 0.5f)
			{
				GlobalScript.inst.gameState.politics[num17].face_type = 0;
				GlobalScript.inst.gameState.politics[num17].face_parts[0] = (byte)UnityEngine.Random.Range(0, 3);
				GlobalScript.inst.gameState.politics[num17].face_parts[1] = (byte)UnityEngine.Random.Range(0, 6);
				GlobalScript.inst.gameState.politics[num17].face_parts[2] = (byte)UnityEngine.Random.Range(0, 6);
				GlobalScript.inst.gameState.politics[num17].face_parts[3] = 0;
				GlobalScript.inst.gameState.politics[num17].face_parts[4] = (byte)UnityEngine.Random.Range(0, 6);
				GlobalScript.inst.gameState.politics[num17].face_parts[5] = (byte)UnityEngine.Random.Range(0, 3);
				GlobalScript.inst.gameState.politics[num17].face_parts[6] = (byte)UnityEngine.Random.Range(0, 6);
				GlobalScript.inst.gameState.politics[num17].face_parts[7] = 0;
			}
			else
			{
				GlobalScript.inst.gameState.politics[num17].face_type = 1;
				GlobalScript.inst.gameState.politics[num17].face_parts[0] = (byte)UnityEngine.Random.Range(0, 4);
				GlobalScript.inst.gameState.politics[num17].face_parts[1] = (byte)UnityEngine.Random.Range(0, 6);
				GlobalScript.inst.gameState.politics[num17].face_parts[2] = (byte)UnityEngine.Random.Range(0, 6);
				GlobalScript.inst.gameState.politics[num17].face_parts[3] = 0;
				GlobalScript.inst.gameState.politics[num17].face_parts[4] = (byte)UnityEngine.Random.Range(0, 4);
				GlobalScript.inst.gameState.politics[num17].face_parts[5] = (byte)UnityEngine.Random.Range(0, 4);
				GlobalScript.inst.gameState.politics[num17].face_parts[6] = (byte)UnityEngine.Random.Range(0, 5);
				GlobalScript.inst.gameState.politics[num17].face_parts[7] = 0;
			}
			GlobalScript.inst.gameState.politics[num17].is_sledstvie = false;
			GlobalScript.inst.gameState.politics[num17].is_sleshka = false;
			GlobalScript.inst.gameState.politics[num17].sled_slej = 0;
			GlobalScript.inst.gameState.politics[num17].days_sleshka = 0;
		}
		textAsset = Resources.Load("Politics_leader") as TextAsset;
		text = textAsset.text;
		Resources.UnloadAsset(textAsset);
		array = text.Split(';');
		GlobalScript.inst.gameState.leader.name_1 = int.Parse(array[0]);
		GlobalScript.inst.gameState.leader.name_2 = int.Parse(array[1]);
		GlobalScript.inst.gameState.leader.traits[0] = (byte)int.Parse(array[2]);
		GlobalScript.inst.gameState.leader.traits[1] = (byte)int.Parse(array[3]);
		GlobalScript.inst.gameState.leader.traits[2] = (byte)int.Parse(array[4]);
		GlobalScript.inst.gameState.leader.age = (byte)int.Parse(array[5]);
		GlobalScript.inst.gameState.leader.face_type = 1;
		GlobalScript.inst.gameState.leader.face_parts[0] = 0;
		GlobalScript.inst.gameState.leader.face_parts[1] = 1;
		GlobalScript.inst.gameState.leader.face_parts[2] = 5;
		GlobalScript.inst.gameState.leader.face_parts[3] = 0;
		GlobalScript.inst.gameState.leader.face_parts[4] = 3;
		GlobalScript.inst.gameState.leader.face_parts[5] = 1;
		GlobalScript.inst.gameState.leader.face_parts[6] = 4;
		GlobalScript.inst.gameState.leader.face_parts[7] = 0;
		GlobalScript.inst.gameState.leader.jacket = 2;
		GlobalScript.inst.gameState.politics[1].face_type = 1;
		GlobalScript.inst.gameState.politics[1].face_parts[0] = 3;
		GlobalScript.inst.gameState.politics[1].face_parts[1] = 2;
		GlobalScript.inst.gameState.politics[1].face_parts[2] = 3;
		GlobalScript.inst.gameState.politics[1].face_parts[3] = 0;
		GlobalScript.inst.gameState.politics[1].face_parts[4] = 1;
		GlobalScript.inst.gameState.politics[1].face_parts[5] = 3;
		GlobalScript.inst.gameState.politics[1].face_parts[6] = 1;
		GlobalScript.inst.gameState.politics[1].face_parts[7] = 0;
		GlobalScript.inst.gameState.politics[1].jacket = 0;
		GlobalScript.inst.gameState.politics[0].face_type = 1;
		GlobalScript.inst.gameState.politics[0].face_parts[0] = 0;
		GlobalScript.inst.gameState.politics[0].face_parts[1] = 3;
		GlobalScript.inst.gameState.politics[0].face_parts[2] = 3;
		GlobalScript.inst.gameState.politics[0].face_parts[3] = 0;
		GlobalScript.inst.gameState.politics[0].face_parts[4] = 0;
		GlobalScript.inst.gameState.politics[0].face_parts[5] = 0;
		GlobalScript.inst.gameState.politics[0].face_parts[6] = 3;
		GlobalScript.inst.gameState.politics[0].face_parts[7] = 0;
		GlobalScript.inst.gameState.politics[0].power = 99999;
		GlobalScript.inst.gameState.politics[0].jacket = 4;
		GlobalScript.inst.gameState.politics[2].face_type = 0;
		GlobalScript.inst.gameState.politics[2].face_parts[0] = 2;
		GlobalScript.inst.gameState.politics[2].face_parts[1] = 0;
		GlobalScript.inst.gameState.politics[2].face_parts[2] = 4;
		GlobalScript.inst.gameState.politics[2].face_parts[3] = 0;
		GlobalScript.inst.gameState.politics[2].face_parts[4] = 0;
		GlobalScript.inst.gameState.politics[2].face_parts[5] = 0;
		GlobalScript.inst.gameState.politics[2].face_parts[6] = 0;
		GlobalScript.inst.gameState.politics[2].face_parts[7] = 0;
		GlobalScript.inst.gameState.politics[2].jacket = 4;
		GlobalScript.inst.gameState.politics[3].jacket = 4;
		GlobalScript.inst.gameState.politics[4].jacket = 0;
		GlobalScript.inst.gameState.politics[5].jacket = 0;
		GlobalScript.inst.gameState.politics[6].jacket = 4;
		GlobalScript.inst.gameState.politics[7].jacket = 1;
		GlobalScript.inst.gameState.politics[8].jacket = 4;
		GlobalScript.inst.gameState.politics[9].jacket = 4;
		GlobalScript.inst.gameState.politics[9].power = 700;
		GlobalScript.inst.gameState.politics[10].jacket = 0;
		GlobalScript.inst.gameState.politics[11].traits[1] = 5;
		GlobalScript.inst.gameState.politics[11].traits[2] = 14;
		GlobalScript.inst.gameState.politics[11].jacket = 3;
		GlobalScript.inst.gameState.politics[12].face_type = 0;
		GlobalScript.inst.gameState.politics[12].face_parts[0] = 1;
		GlobalScript.inst.gameState.politics[12].face_parts[1] = 2;
		GlobalScript.inst.gameState.politics[12].face_parts[2] = 1;
		GlobalScript.inst.gameState.politics[12].face_parts[3] = 0;
		GlobalScript.inst.gameState.politics[12].face_parts[4] = 5;
		GlobalScript.inst.gameState.politics[12].face_parts[5] = 1;
		GlobalScript.inst.gameState.politics[12].face_parts[6] = 2;
		GlobalScript.inst.gameState.politics[12].face_parts[7] = 0;
		GlobalScript.inst.gameState.politics[12].jacket = 4;
		GlobalScript.inst.gameState.politics[13].face_type = 0;
		GlobalScript.inst.gameState.politics[13].face_parts[0] = 1;
		GlobalScript.inst.gameState.politics[13].face_parts[1] = 5;
		GlobalScript.inst.gameState.politics[13].face_parts[2] = 4;
		GlobalScript.inst.gameState.politics[13].face_parts[3] = 0;
		GlobalScript.inst.gameState.politics[13].face_parts[4] = 4;
		GlobalScript.inst.gameState.politics[13].face_parts[5] = 1;
		GlobalScript.inst.gameState.politics[13].face_parts[6] = 5;
		GlobalScript.inst.gameState.politics[13].face_parts[7] = 0;
		GlobalScript.inst.gameState.politics[13].jacket = 3;
		GlobalScript.inst.gameState.politics[14].jacket = 1;
		GlobalScript.inst.gameState.politics[15].jacket = 4;
		GlobalScript.inst.gameState.politics[16].jacket = 4;
		GlobalScript.inst.gameState.politics[17].traits[0] = 1;
		GlobalScript.inst.gameState.politics[17].traits[1] = 4;
		GlobalScript.inst.gameState.politics[17].traits[2] = 15;
		GlobalScript.inst.gameState.politics[17].jacket = 2;
		for (int num18 = 0; num18 < 3; num18++)
		{
			GlobalScript.inst.gameState.p_first[num18] = (byte)num18;
		}
		for (int num19 = 0; num19 < 4; num19++)
		{
			GlobalScript.inst.gameState.p_second[num19] = (byte)(num19 + 3);
		}
		for (int num20 = 0; num20 < 5; num20++)
		{
			GlobalScript.inst.gameState.p_third[num20] = (byte)(num20 + 7);
		}
		for (int num21 = 0; num21 < 6; num21++)
		{
			GlobalScript.inst.gameState.p_forth[num21] = (byte)(num21 + 12);
		}
		for (int num22 = 0; num22 < GlobalScript.inst.gameState.politics.Length; num22++)
		{
			GlobalScript.inst.gameState.CalcRel(num22);
			GlobalScript.inst.gameState.CalcRelLeader(num22);
		}
		GlobalScript.inst.gameState.politics[1].loyality_to_other[0] = 10000;
		GlobalScript.inst.gameState.politics[2].loyality_to_other[0] = 10000;
		GlobalScript.inst.gameState.politics[3].loyality_to_other[0] = 10000;
		GlobalScript.inst.gameState.politics[4].loyality_to_other[0] = 10000;
		GlobalScript.inst.gameState.politics[1].loyality_to_other[2] = 10000;
		GlobalScript.inst.gameState.politics[1].loyality_to_other[3] = 10000;
		GlobalScript.inst.gameState.politics[1].loyality_to_other[4] = 10000;
		GlobalScript.inst.gameState.politics[2].loyality_to_other[1] = 10000;
		GlobalScript.inst.gameState.politics[2].loyality_to_other[3] = 10000;
		GlobalScript.inst.gameState.politics[2].loyality_to_other[4] = 10000;
		GlobalScript.inst.gameState.politics[3].loyality_to_other[2] = 10000;
		GlobalScript.inst.gameState.politics[3].loyality_to_other[1] = 10000;
		GlobalScript.inst.gameState.politics[3].loyality_to_other[4] = 10000;
		GlobalScript.inst.gameState.politics[4].loyality_to_other[2] = 10000;
		GlobalScript.inst.gameState.politics[4].loyality_to_other[3] = 10000;
		GlobalScript.inst.gameState.politics[4].loyality_to_other[1] = 10000;
		GlobalScript.inst.gameState.politics[1].loyality_to_other[12] -= 1000;
		GlobalScript.inst.gameState.politics[0].loyality_to_other[12] += 500;
		GlobalScript.inst.gameState.politics[0].loyality += 500;
		GlobalScript.inst.gameState.politics[5].loyality += 400;
		GlobalScript.inst.gameState.politics[8].loyality += 600;
		GlobalScript.inst.gameState.politics[9].loyality += 800;
		GlobalScript.inst.gameState.politics[10].loyality += 100;
		GlobalScript.inst.gameState.politics[15].traits[0] = 1;
		GlobalScript.inst.gameState.politics_dolshnost[0] = 150;
		GlobalScript.inst.gameState.politics_dolshnost[1] = 0;
		GlobalScript.inst.gameState.politics_dolshnost[2] = 17;
		GlobalScript.inst.gameState.politics_dolshnost[3] = 10;
		GlobalScript.inst.gameState.politics_dolshnost[4] = 9;
		GlobalScript.inst.gameState.politics_dolshnost[5] = 15;
		GlobalScript.inst.gameState.politics_dolshnost[6] = 13;
		GlobalScript.inst.gameState.politics_dolshnost[7] = 3;
		GlobalScript.inst.gameState.politics[0].wantedDolzh = 1;
		GlobalScript.inst.gameState.politics[1].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[2].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[3].wantedDolzh = 3;
		GlobalScript.inst.gameState.politics[4].wantedDolzh = 3;
		GlobalScript.inst.gameState.politics[5].wantedDolzh = 1;
		GlobalScript.inst.gameState.politics[6].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[7].wantedDolzh = 1;
		GlobalScript.inst.gameState.politics[8].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[9].wantedDolzh = 1;
		GlobalScript.inst.gameState.politics[10].wantedDolzh = 3;
		GlobalScript.inst.gameState.politics[11].wantedDolzh = 2;
		GlobalScript.inst.gameState.politics[12].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[13].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[14].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[15].wantedDolzh = 0;
		GlobalScript.inst.gameState.politics[16].wantedDolzh = 1;
		GlobalScript.inst.gameState.politics[17].wantedDolzh = 2;
		GlobalScript.inst.gameState.faction_leader[0] = 1;
		GlobalScript.inst.gameState.faction_leader[1] = 10;
		GlobalScript.inst.gameState.faction_leader[2] = 15;
		GlobalScript.inst.gameState.faction_leader[3] = 12;
		GlobalScript.inst.gameState.faction_leader[4] = 13;
		GlobalScript.inst.gameState.data[49] = UnityEngine.Random.Range(1, 5);
		GlobalScript.inst.gameState.data[48] = UnityEngine.Random.Range(1, 5);
		GlobalScript.inst.gameState.data[47] = UnityEngine.Random.Range(1, 5);
		if (GlobalScript.inst.gameState.diff == 0)
		{
			GlobalScript.inst.gameState.data[1] = 1000;
			GlobalScript.inst.gameState.data[3] = 1000;
			GlobalScript.inst.gameState.data[4] = 0;
			GlobalScript.inst.gameState.data[8] += 500;
			GlobalScript.inst.gameState.data[11] = 700;
		}
		else if (GlobalScript.inst.gameState.diff == 1)
		{
			GlobalScript.inst.gameState.data[8] += 100;
			GlobalScript.inst.gameState.data[11] = 300;
		}
		else if (GlobalScript.inst.gameState.diff == 3)
		{
			GlobalScript.inst.gameState.data[11] = 0;
		}
		else if (GlobalScript.inst.gameState.diff == 4)
		{
			for (int num23 = 0; num23 < GlobalScript.inst.gameState.politics.Length; num23++)
			{
				if (GlobalScript.inst.gameState.politics[num23].traits[0] == 0)
				{
					GlobalScript.inst.gameState.politics[num23].loyality -= 300;
					GlobalScript.inst.gameState.politics[num23].power += 500;
				}
			}
		}
		GlobalScript.inst.gameState.data[27] = 0;
		GlobalScript.inst.gameState.data[0] = 0;
		GlobalScript.inst.gameState.data[85] = 0;
		GlobalScript.inst.gameState.allcountries[41].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[41].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[41].name = "社 会 主 义 埃 塞 俄 比 亚";
		GlobalScript.inst.gameState.allcountries[42].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[42].SubGosstroy = 10;
		GlobalScript.inst.gameState.allcountries[49].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[49].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[52].name = "刚 果 人 民 共 和 国";
		GlobalScript.inst.gameState.allcountries[52].Torg = true;
		GlobalScript.inst.gameState.allcountries[56].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[56].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[56].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[56].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[59].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[59].SubGosstroy = 10;
		GlobalScript.inst.gameState.allcountries[59].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[59].Torg = true;
		GlobalScript.inst.gameState.allcountries[59].name = "毛 里 塔 尼 亚 伊 斯 兰 共 和 国";
		GlobalScript.inst.gameState.allcountries[60].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[60].SubGosstroy = 8;
		GlobalScript.inst.gameState.allcountries[60].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[60].name = "尼 日 利 亚 联 邦 共 和 国";
		GlobalScript.inst.gameState.allcountries[61].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[61].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[61].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[61].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[64].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[64].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[64].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[64].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[66].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[66].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[107].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[107].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[107].LeaveAlliances();
		GlobalScript.inst.gameState.allcountries[108].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[112].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[112].SubGosstroy = 4;
		GlobalScript.inst.gameState.allcountries[112].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[113].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[113].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[113].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[114].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[114].SubGosstroy = 1;
		GlobalScript.inst.gameState.allcountries[114].Torg = true;
		GlobalScript.inst.gameState.allcountries[115].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[115].SubGosstroy = 9;
		GlobalScript.inst.gameState.allcountries[116].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[116].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[116].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[117].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[117].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[117].Torg = true;
		GlobalScript.inst.gameState.allcountries[117].name = " 扎 伊 尔 共 和 国";
		GlobalScript.inst.gameState.allcountries[118].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[118].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[118].prosov = true;
		GlobalScript.inst.gameState.allcountries[119].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[119].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[119].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[120].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[120].SubGosstroy = 9;
		GlobalScript.inst.gameState.allcountries[121].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[121].SubGosstroy = 9;
		GlobalScript.inst.gameState.allcountries[122].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[122].SubGosstroy = 1;
		GlobalScript.inst.gameState.allcountries[122].proprc = true;
		GlobalScript.inst.gameState.allcountries[122].Torg = true;
		GlobalScript.inst.gameState.allcountries[123].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[123].SubGosstroy = 1;
		GlobalScript.inst.gameState.allcountries[123].prosov = true;
		GlobalScript.inst.gameState.allcountries[124].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[124].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[124].proprc = true;
		GlobalScript.inst.gameState.allcountries[124].Torg = true;
		GlobalScript.inst.gameState.allcountries[125].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[125].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[126].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[126].SubGosstroy = 1;
		GlobalScript.inst.gameState.allcountries[126].Torg = true;
		GlobalScript.inst.gameState.allcountries[127].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[127].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[127].name = " 罗 德 西 亚";
		GlobalScript.inst.gameState.allcountries[127].puppetOf = 131;
		GlobalScript.inst.gameState.allcountries[129].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[129].SubGosstroy = 5;
		GlobalScript.inst.gameState.allcountries[130].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[130].SubGosstroy = 13;
		GlobalScript.inst.gameState.allcountries[130].name = "斯 威 士 兰 王 国";
		GlobalScript.inst.gameState.allcountries[130].puppetOf = 131;
		GlobalScript.inst.gameState.allcountries[131].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[131].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[131].name = "白 人 南 非";
		GlobalScript.inst.gameState.allcountries[132].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[132].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[132].name = "莱 索 托 王 国";
		GlobalScript.inst.gameState.allcountries[132].puppetOf = 131;
		GlobalScript.inst.gameState.allcountries[133].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[133].SubGosstroy = 3;
		GlobalScript.inst.gameState.allcountries[133].name = "马 达 加 斯 加 民 主 共 和 国";
		GlobalScript.inst.gameState.allcountries[134].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[134].SubGosstroy = 5;
		GlobalScript.inst.gameState.allcountries[134].puppetOf = 135;
		GlobalScript.inst.gameState.allcountries[134].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[135].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[135].SubGosstroy = 6;
		GlobalScript.inst.gameState.allcountries[135].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[136].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[136].SubGosstroy = 4;
		GlobalScript.inst.gameState.allcountries[136].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[137].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[137].SubGosstroy = 6;
		GlobalScript.inst.gameState.allcountries[137].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[137].isNATO = true;
		GlobalScript.inst.gameState.allcountries[138].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[138].SubGosstroy = 1;
		GlobalScript.inst.gameState.allcountries[138].prosov = true;
		GlobalScript.inst.gameState.allcountries[138].isSEV = true;
		GlobalScript.inst.gameState.allcountries[139].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[139].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[139].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[140].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[140].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[140].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[141].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[141].SubGosstroy = 3;
		GlobalScript.inst.gameState.allcountries[142].Gosstroy = GlobalScript.inst.gameState.allcountries[92].Gosstroy;
		GlobalScript.inst.gameState.allcountries[142].SubGosstroy = GlobalScript.inst.gameState.allcountries[92].SubGosstroy;
		GlobalScript.inst.gameState.allcountries[143].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[143].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[143].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[144].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[144].SubGosstroy = 4;
		GlobalScript.inst.gameState.allcountries[145].Gosstroy = 1;
		GlobalScript.inst.gameState.allcountries[145].SubGosstroy = 1;
		GlobalScript.inst.gameState.allcountries[145].name = " 墨 西 哥 南 方 民 主 共 和 国";
		GlobalScript.inst.gameState.allcountries[146].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[146].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[146].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[147].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[147].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[147].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[148].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[148].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[148].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[149].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[149].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[149].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[152].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[152].SubGosstroy = 3;
		GlobalScript.inst.gameState.allcountries[154].Gosstroy = GlobalScript.inst.gameState.allcountries[21].Gosstroy;
		GlobalScript.inst.gameState.allcountries[154].SubGosstroy = GlobalScript.inst.gameState.allcountries[21].SubGosstroy;
		GlobalScript.inst.gameState.allcountries[154].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[154].name = " 法 属 新 喀 里 多 尼 亚";
		GlobalScript.inst.gameState.allcountries[155].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[155].SubGosstroy = 6;
		GlobalScript.inst.gameState.allcountries[155].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[158].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[158].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[158].name = "科 摩 罗 国";
		GlobalScript.inst.gameState.allcountries[159].Gosstroy = GlobalScript.inst.gameState.allcountries[21].Gosstroy;
		GlobalScript.inst.gameState.allcountries[159].SubGosstroy = GlobalScript.inst.gameState.allcountries[21].SubGosstroy;
		GlobalScript.inst.gameState.allcountries[159].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[159].name = "新 赫 布 里 底 共 管 地";
		GlobalScript.inst.gameState.allcountries[160].Gosstroy = 3;
		GlobalScript.inst.gameState.allcountries[160].SubGosstroy = 6;
		GlobalScript.inst.gameState.allcountries[160].name = "斐 济 自 治 领";
		GlobalScript.inst.gameState.allcountries[161].Gosstroy = GlobalScript.inst.gameState.allcountries[92].Gosstroy;
		GlobalScript.inst.gameState.allcountries[161].SubGosstroy = GlobalScript.inst.gameState.allcountries[92].SubGosstroy;
		GlobalScript.inst.gameState.allcountries[162].SubGosstroy = 18;
		GlobalScript.inst.gameState.allcountries[15].Torg = false;
		GlobalScript.inst.gameState.allcountries[92].spec = 0;
		GlobalScript.inst.gameState.allcountries[21].spec = 0;
		GlobalScript.inst.gameState.allcountries[5].spec = 0;
		GlobalScript.inst.gameState.allcountries[21].soc_stab = 0;
		GlobalScript.inst.gameState.allcountries[0].isNATO = true;
		GlobalScript.inst.gameState.allcountries[51].isNATO = true;
		GlobalScript.inst.gameState.allcountries[92].isNATO = true;
		GlobalScript.inst.gameState.allcountries[21].isNATO = true;
		GlobalScript.inst.gameState.allcountries[87].isNATO = true;
		GlobalScript.inst.gameState.allcountries[88].isNATO = true;
		GlobalScript.inst.gameState.allcountries[89].isNATO = true;
		GlobalScript.inst.gameState.allcountries[17].isNATO = true;
		GlobalScript.inst.gameState.allcountries[84].isNATO = true;
		GlobalScript.inst.gameState.allcountries[85].isNATO = true;
		GlobalScript.inst.gameState.allcountries[45].isNATO = true;
		GlobalScript.inst.gameState.allcountries[90].isNATO = true;
		GlobalScript.inst.gameState.allcountries[91].isNATO = true;
		GlobalScript.inst.gameState.allcountries[0].isEU = true;
		GlobalScript.inst.gameState.allcountries[92].isEU = true;
		GlobalScript.inst.gameState.allcountries[21].isEU = true;
		GlobalScript.inst.gameState.allcountries[88].isEU = true;
		GlobalScript.inst.gameState.allcountries[89].isEU = true;
		GlobalScript.inst.gameState.allcountries[17].isEU = true;
		GlobalScript.inst.gameState.allcountries[85].isEU = true;
		GlobalScript.inst.gameState.allcountries[90].isEU = true;
		GlobalScript.inst.gameState.allcountries[29].isEU = true;
		GlobalScript.inst.gameState.allcountries[54].name = " 摩 洛 哥 王 国";
		GlobalScript.inst.gameState.allcountries[87].spec = 40;
		GlobalScript.inst.gameState.allcountries[87].inflCh = 10;
		GlobalScript.inst.gameState.allcountries[87].inflNATO = 20;
		GlobalScript.inst.gameState.allcountries[1].prcinfl = 0;
		GlobalScript.inst.gameState.allcountries[1].level_of_unstab = 10;
		GlobalScript.inst.gameState.allcountries[149].level_of_unstab = 200;
		GlobalScript.inst.gameState.allcountries[147].level_of_unstab = 250;
		GlobalScript.inst.gameState.ArmyLoyality = 1000;
		GlobalScript.inst.gameState.ArmyPower = 600;
		GlobalScript.inst.gameState.ChinesePage = 0;
		GlobalScript.inst.gameState.allcountries[20].SubGosstroy = 2;
		if (GlobalScript.inst.dlc[3])
		{
			GlobalScript.inst.gameState.allcountries[50].isASEAN = true;
			GlobalScript.inst.gameState.allcountries[49].isASEAN = true;
			GlobalScript.inst.gameState.allcountries[34].isASEAN = true;
			GlobalScript.inst.gameState.allcountries[47].isASEAN = true;
			GlobalScript.inst.gameState.allcountries[31].isSENTO = true;
			GlobalScript.inst.gameState.allcountries[8].isSENTO = true;
			GlobalScript.inst.gameState.allcountries[22].puppetOf = 11;
			GlobalScript.inst.gameState.OilEat = (float)GlobalScript.inst.gameState.data[12] * 0.4f + ((GlobalScript.inst.gameState.data[12] >= 500) ? ((float)(GlobalScript.inst.gameState.data[12] - 499) * 0.4f) : 0f) + ((GlobalScript.inst.gameState.data[12] >= 750) ? ((float)(GlobalScript.inst.gameState.data[12] - 749) * 0.4f) : 0f);
			GlobalScript.inst.gameState.OilEat += ((GlobalScript.inst.gameState.data[13] >= 250) ? ((float)(GlobalScript.inst.gameState.data[13] - 249) * 0.35f) : 0f) + ((GlobalScript.inst.gameState.data[13] >= 500) ? ((float)(GlobalScript.inst.gameState.data[13] - 499) * 0.35f) : 0f) + ((GlobalScript.inst.gameState.data[13] >= 750) ? ((float)(GlobalScript.inst.gameState.data[13] - 749) * 0.35f) : 0f);
			GlobalScript.inst.gameState.OilEat += ((GlobalScript.inst.gameState.data[68] >= 500) ? ((float)(GlobalScript.inst.gameState.data[68] - 499) * 0.34f) : 0f) + ((GlobalScript.inst.gameState.data[68] >= 750) ? ((float)(GlobalScript.inst.gameState.data[68] - 749) * 0.34f) : 0f);
			GlobalScript.inst.gameState.OilEat += ((GlobalScript.inst.gameState.data[22] >= 2000) ? 1000f : ((float)GlobalScript.inst.gameState.data[22] * 0.5f));
			GlobalScript.inst.gameState.OilEat += (float)GlobalScript.inst.gameState.data[5] * 0.05f;
			GlobalScript.inst.gameState.modifies[51].active = true;
			GlobalScript.inst.gameState.data[143] = 12;
		}
		if (@int == 1)
		{
			GlobalScript.inst.gameState.ingamewars[0].name_war = "Вторая Корейская война";
			GlobalScript.inst.gameState.ingamewars[1].name_war = "Кампучийско-вьетнамский конфликт";
			GlobalScript.inst.gameState.ingamewars[2].name_war = "Тайская гражданская война";
			GlobalScript.inst.gameState.ingamewars[3].name_war = "Ирано-иракская война";
			GlobalScript.inst.gameState.ingamewars[4].name_war = "Ливанская война";
			GlobalScript.inst.gameState.ingamewars[5].name_war = "Афганская война";
			GlobalScript.inst.gameState.ingamewars[6].name_war = "Фолклендская война";
			GlobalScript.inst.gameState.ingamewars[7].name_war = "Гражданская война в Индии";
		}
		else
		{
			GlobalScript.inst.gameState.ingamewars[0].name_war = " 朝 鲜 战 争";
			GlobalScript.inst.gameState.ingamewars[1].name_war = " 柬 越 战 争";
			GlobalScript.inst.gameState.ingamewars[2].name_war = " 泰 国 内 战";
			GlobalScript.inst.gameState.ingamewars[3].name_war = " 两 伊 战 争";
			GlobalScript.inst.gameState.ingamewars[4].name_war = " 黎 巴 嫩 战 争";
			GlobalScript.inst.gameState.ingamewars[5].name_war = " 阿 富 汗 战 争";
			GlobalScript.inst.gameState.ingamewars[6].name_war = " 马 岛 战 争";
			GlobalScript.inst.gameState.ingamewars[7].name_war = " 印 度 内 战";
		}
		GlobalScript.inst.gameState.data[111] = 0;
		GlobalScript.inst.gameState.data[112] = 0;
		GlobalScript.inst.gameState.data[113] = 0;
		GlobalScript.inst.gameState.data[114] = 0;
		GlobalScript.inst.gameState.data[115] = 0;
		GlobalScript.inst.gameState.data[116] = 0;
		GlobalScript.inst.gameState.data[117] = 0;
		GlobalScript.inst.gameState.data[118] = 0;
		GlobalScript.inst.gameState.data[119] = 0;
		GlobalScript.inst.gameState.data[120] = 0;
		GlobalScript.inst.gameState.data[121] = 0;
		GlobalScript.inst.gameState.data[122] = 0;
		GlobalScript.inst.gameState.data[123] = 0;
		GlobalScript.inst.gameState.data[105] = 2;
		GlobalScript.inst.gameState.data[106] = 0;
		GlobalScript.inst.gameState.data[108] = 0;
		GlobalScript.inst.gameState.data[152] = 350;
		GlobalScript.inst.gameState.allcountries[92].inflNATO = 10;
		GlobalScript.inst.gameState.data[125] = 0;
		GlobalScript.inst.gameState.data[160] = 5500;
		GlobalScript.inst.gameState.data[161] = -1500;
		GlobalScript.inst.gameState.is_elect = false;
		TextAsset textAsset2 = Resources.Load(string.Format("new_texts_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_texts = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("new_modify_texts_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_modify_texts = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("new_modify_opis_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_modify_desc = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("old_modify_text_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.old_modify_texts = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("old_modify_opis_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.old_modify_desc = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("Events_text_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.new_events_text = textAsset2.text.Split('\n');
		textAsset2 = Resources.Load(string.Format("new_focuses_texts_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		FocusReader.CreateDictionary();
		FocusReader.ReadFocuses(textAsset2.text);
		textAsset2 = Resources.Load(string.Format("new_event_text_{0}", (@int == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.gameState.SOV_PRC_PartiesConnection = GlobalScript.inst.gameState.data[30];
		GlobalScript.inst.gameState.empires = new Empire[2];
		GlobalScript.inst.gameState.empires[0] = new Empire
		{
			leaders = new Leader[4]
			{
				new Leader(GlobalScript.inst.new_texts[0], 5),
				new Leader(GlobalScript.inst.new_texts[1], 4),
				new Leader(GlobalScript.inst.new_texts[2], 3),
				new Leader(GlobalScript.inst.new_texts[3], 2)
			}
		};
		GlobalScript.inst.gameState.empires[0].modifies = new int[2] { 0, 1 };
		GlobalScript.inst.gameState.empires[0].insiders = new Insider[2]
		{
			new Insider(GlobalScript.inst.new_texts[4], 0),
			new Insider(GlobalScript.inst.new_texts[5], 0)
		};
		GlobalScript.inst.gameState.empires[0].power = GlobalScript.inst.gameState.data[10];
		GlobalScript.inst.gameState.empires[0].relations = GlobalScript.inst.gameState.data[28];
		GlobalScript.inst.gameState.data[96] += 4;
		GlobalScript.inst.gameState.data[95]++;
		GlobalScript.inst.gameState.empires[1] = new Empire
		{
			leaders = new Leader[7]
			{
				new Leader(GlobalScript.inst.new_texts[6], 20),
				new Leader(GlobalScript.inst.new_texts[7], GlobalScript.inst.gameState.data[97] + 3),
				new Leader(GlobalScript.inst.new_texts[8], GlobalScript.inst.gameState.data[95] * 3),
				new Leader(GlobalScript.inst.new_texts[9], GlobalScript.inst.dlc[0] ? GlobalScript.inst.gameState.data[96] : (GlobalScript.inst.gameState.data[96] * 3)),
				new Leader(GlobalScript.inst.new_texts[10], GlobalScript.inst.gameState.data[98]),
				new Leader(GlobalScript.inst.new_texts[11], GlobalScript.inst.gameState.data[99] + 1),
				new Leader(GlobalScript.inst.new_texts[12], GlobalScript.inst.gameState.data[100])
			}
		};
		GlobalScript.inst.gameState.empires[1].modifies = new int[2] { 0, 7 };
		GlobalScript.inst.gameState.empires[1].insiders = new Insider[2]
		{
			new Insider(GlobalScript.inst.new_texts[13], 0),
			new Insider(GlobalScript.inst.new_texts[14], 0)
		};
		GlobalScript.inst.gameState.empires[1].power = GlobalScript.inst.gameState.data[2];
		GlobalScript.inst.gameState.empires[1].relations = GlobalScript.inst.gameState.data[29];
		if (GlobalScript.inst.dlc[0])
		{
			CreateFocuses();
			DLC01();
		}
		for (int num24 = 0; num24 < GlobalScript.inst.gameState.completedDecisions.Length; num24++)
		{
			GlobalScript.inst.gameState.completedDecisions[num24] = false;
		}
		GlobalScript.inst.CreateDecisions();
		GlobalScript.inst.gameState.allcountries[84].parts = new bool[6];
		GlobalScript.inst.gameState.allcountries[14].parts = new bool[6];
		GlobalScript.inst.gameState.allcountries[30].parts = new bool[3];
		GlobalScript.inst.gameState.allcountries[1].parts = new bool[12];
		GlobalScript.inst.gameState.allcountries[7].parts = new bool[3];
		GlobalScript.inst.gameState.allcountries[1].parts[10] = true;
		GlobalScript.inst.gameState.allcountries[13].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[20].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[86].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[140].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[53].parts = new bool[3];
		GlobalScript.inst.gameState.allcountries[41].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[42].parts = new bool[3];
		GlobalScript.inst.gameState.allcountries[112].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[117].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[119].parts = new bool[2];
		GlobalScript.inst.gameState.allcountries[131].parts = new bool[5];
		GlobalScript.inst.gameState.allcountries[149].parts = new bool[3];
		GlobalScript.inst.gameState.allcountries[157].parts = new bool[3];
		GlobalScript.inst.gameState.allcountries[138].parts[0] = false;
		GlobalScript.inst.gameState.allcountries[60].parts[0] = false;
		GlobalScript.inst.gameState.allcountries[33].parts[0] = true;
		GlobalScript.inst.gameState.allcountries[33].inflCh = 50;
		GlobalScript.inst.gameState.allcountries[123].parts[0] = true;
		GlobalScript.inst.gameState.allcountries[162].parts[0] = true;
		GlobalScript.inst.gameState.allcountries[53].africaOff = true;
		GlobalScript.inst.gameState.allcountries[54].africaOff = true;
		GlobalScript.inst.gameState.allcountries[55].africaOff = true;
		GlobalScript.inst.gameState.allcountries[56].africaOff = true;
		GlobalScript.inst.gameState.allcountries[57].africaOff = true;
		GlobalScript.inst.gameState.allcountries[59].africaOff = true;
		GlobalScript.inst.gameState.allcountries[58].africaOff = true;
		GlobalScript.inst.gameState.allcountries[60].africaOff = true;
		GlobalScript.inst.gameState.allcountries[61].africaOff = true;
		GlobalScript.inst.gameState.allcountries[62].africaOff = true;
		GlobalScript.inst.gameState.allcountries[63].africaOff = true;
		GlobalScript.inst.gameState.allcountries[64].africaOff = true;
		GlobalScript.inst.gameState.allcountries[65].africaOff = true;
		GlobalScript.inst.gameState.allcountries[66].africaOff = true;
		GlobalScript.inst.gameState.allcountries[67].africaOff = true;
		GlobalScript.inst.gameState.allcountries[68].africaOff = true;
		GlobalScript.inst.gameState.allcountries[106].africaOff = true;
		GlobalScript.inst.gameState.allcountries[107].africaOff = true;
		GlobalScript.inst.gameState.allcountries[108].africaOff = true;
		GlobalScript.inst.gameState.allcountries[112].africaOff = true;
		GlobalScript.inst.gameState.allcountries[113].africaOff = true;
		GlobalScript.inst.gameState.allcountries[114].africaOff = true;
		GlobalScript.inst.gameState.allcountries[115].africaOff = true;
		GlobalScript.inst.gameState.allcountries[116].africaOff = true;
		GlobalScript.inst.gameState.allcountries[117].africaOff = true;
		GlobalScript.inst.gameState.allcountries[118].africaOff = true;
		GlobalScript.inst.gameState.allcountries[119].africaOff = true;
		GlobalScript.inst.gameState.allcountries[122].africaOff = true;
		GlobalScript.inst.gameState.allcountries[123].africaOff = true;
		GlobalScript.inst.gameState.allcountries[124].africaOff = true;
		GlobalScript.inst.gameState.allcountries[125].africaOff = true;
		GlobalScript.inst.gameState.allcountries[126].africaOff = true;
		GlobalScript.inst.gameState.allcountries[127].africaOff = true;
		GlobalScript.inst.gameState.allcountries[128].africaOff = true;
		GlobalScript.inst.gameState.allcountries[129].africaOff = true;
		GlobalScript.inst.gameState.allcountries[130].africaOff = true;
		GlobalScript.inst.gameState.allcountries[131].africaOff = true;
		GlobalScript.inst.gameState.allcountries[132].africaOff = true;
		GlobalScript.inst.gameState.allcountries[133].africaOff = true;
		GlobalScript.inst.gameState.allcountries[53].Torg = true;
		GlobalScript.inst.gameState.allcountries[58].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[58].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[58].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[65].name = " 中 非 共 和 国";
		GlobalScript.inst.gameState.allcountries[65].SubGosstroy = 13;
		GlobalScript.inst.gameState.allcountries[65].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[42].Torg = true;
		GlobalScript.inst.gameState.allcountries[53].SubGosstroy = 10;
		GlobalScript.inst.gameState.allcountries[57].Gosstroy = 0;
		GlobalScript.inst.gameState.allcountries[57].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[57].puppetOf = 21;
		GlobalScript.inst.gameState.allcountries[63].SubGosstroy = 7;
		GlobalScript.inst.gameState.allcountries[2].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[2].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[35].Torg = true;
		GlobalScript.inst.gameState.allcountries[35].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[35].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[14].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[14].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[63].Vyshi = true;
		GlobalScript.inst.gameState.allcountries[107].Gosstroy = 2;
		GlobalScript.inst.gameState.allcountries[107].SubGosstroy = 15;
		GlobalScript.inst.gameState.allcountries[54].parts[0] = true;
		SceneManager.LoadScene(new_scene);
		string[] old_modify_desc = GlobalScript.inst.old_modify_desc;
		int num25 = 15;
		old_modify_desc[num25] += "<color=red>| 缓 慢 推 进 集 体 化 的 公 社 ：</color>| 农 业+0.1 ， 工 业+0.1 ， 生 活 水 平+0.2 ， 预 算+0.1";
		GlobalScript.inst.old_modify_desc[11] = " 农 业 、 工 业 和 服 务 业+5.0| 预 算+5.0 ， 生 活 水 平+1.0 ， 腐 败-1.0| 党 内 支 持 度-5.0| 每 两 周";
		GlobalScript.inst.old_modify_desc[2] = "根 据 服 务 业 的 发 展 情 况 获 得 效 果|";
		if (GlobalScript.inst.gameState.data[108] < 54)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>受 到 管 控 的 私 有 制 ：</color> 投 机 倒 把 的 商 人 还 影 响 不 到 我 们";
		}
		else if (GlobalScript.inst.gameState.data[108] < 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>逐 渐 崛 起 的 寡 头 ：</color>人 民 支 持 度-0.5 ， 思 想 自 由 化+1 ， 生 活 水 平-0.5 ";
		}
		else if (GlobalScript.inst.gameState.data[108] >= 72)
		{
			GlobalScript.inst.old_modify_desc[2] = "<color=red>寡 头 执 政 ：</color>人 民 支 持 度-1 ， 思 想 自 由 化+2 ， 生 活 水 平-1 ";
		}
		if (!GlobalScript.inst.gameState.event_done[669])
		{
			string[] old_modify_desc2 = GlobalScript.inst.old_modify_desc;
			int num26 = 2;
			old_modify_desc2[num26] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.1 ， 工 业+0.2 ，农 业+0.2 ， 人 民 支 持 度+0.2 ， 科 技 点 数+0.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 0)
		{
			string[] old_modify_desc3 = GlobalScript.inst.old_modify_desc;
			int num27 = 2;
			old_modify_desc3[num27] += "|<color=red>无 产 阶 级 教 育 路 线 ：</color>预 算-0.2 ， 工 业+0.3 ，农 业+0.3 ， 人 民 支 持 度+0.3 ， 科 技 点 数+1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 1)
		{
			string[] old_modify_desc4 = GlobalScript.inst.old_modify_desc;
			int num28 = 2;
			old_modify_desc4[num28] += "|<color=red>正 统 社 会 主 义 教 育 路 线 ：</color>预 算-0.1 ， 腐 败 + 0.1 ， 科 技 点 数+1.5";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 2)
		{
			string[] old_modify_desc5 = GlobalScript.inst.old_modify_desc;
			int num29 = 2;
			old_modify_desc5[num29] += "|<color=red>混 合 式 教 育 体 制 改 革 ：</color>预 算+0.2 ， 寡 头 力 量+0.1 , 腐 败 + 0.2 ， 科 技 点 数+2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[669] == 3)
		{
			string[] old_modify_desc6 = GlobalScript.inst.old_modify_desc;
			int num30 = 2;
			old_modify_desc6[num30] += "|<color=red>全 民 军 事 化 教 育 ：</color>军 事 力 量+0.3 ，人 民 支 持 度+1 ， 思 想 自 由 化-1 ， 科 技 点 数-2 ， 凝 聚 力+0.5 ， 民 族 情 绪+0.5";
		}
		if (GlobalScript.inst.gameState.resultOfEvents[456] == 0 && GlobalScript.inst.gameState.event_done[456])
		{
			string[] old_modify_desc7 = GlobalScript.inst.old_modify_desc;
			int num31 = 2;
			old_modify_desc7[num31] += "|<color=red>全 国 高 校 统 一 招 生 考 试 ：</color>科 技 点 数 +2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 1 && GlobalScript.inst.gameState.event_done[456])
		{
			string[] old_modify_desc8 = GlobalScript.inst.old_modify_desc;
			int num32 = 2;
			old_modify_desc8[num32] += "|<color=red>预 科 制 度 ：</color>科 技 点 数 +1";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[456] == 2 || !GlobalScript.inst.gameState.event_done[456])
		{
			string[] old_modify_desc9 = GlobalScript.inst.old_modify_desc;
			int num33 = 2;
			old_modify_desc9[num33] += "|<color=red>无 产 阶 级 推 荐 制 ：</color>农 业+0.3 ， 工 业+0.3";
		}
		if (!GlobalScript.inst.gameState.event_done[646])
		{
			string[] old_modify_desc10 = GlobalScript.inst.old_modify_desc;
			int num34 = 2;
			old_modify_desc10[num34] += "|<color=red>合 作 医 疗 ：</color>预 算-0.1 ， 工 业+0.2 ， 农 业+0.3 ， 人民支持度+0.2 , 服 务 业+0.2";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 0)
		{
			string[] old_modify_desc11 = GlobalScript.inst.old_modify_desc;
			int num35 = 2;
			old_modify_desc11[num35] += "|<color=red>精 进 的 合 作 医 疗 ：</color>预 算-0.2 ， 工 业+0.3 ， 农 业+0.4 ， 人民支持度+0.2 , 服 务 业+0.3";
		}
		else if (GlobalScript.inst.gameState.resultOfEvents[646] == 1)
		{
			string[] old_modify_desc12 = GlobalScript.inst.old_modify_desc;
			int num36 = 2;
			old_modify_desc12[num36] += "|<color=red>市 场 化 改 革 医 疗 ：</color>预 算+0.2 ， 生 活 水 平+0.1 ， 寡 头 力 量+0.1 , 服 务 业+0.1";
		}
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
		if (GlobalScript.inst.gameState.resultOfEvents[444] == 0 && GlobalScript.inst.gameState.event_done[444])
		{
			GlobalScript.inst.gameState.doctr[6] = "无 产 阶 级 专 政";
			GlobalScript.inst.gameState.doctr[19] = "自 由 境 界";
			GlobalScript.inst.gameState.doctr[24] = "文 化 革 命";
		}
		GlobalScript.inst.gameState.resultOfEvents[15] = -1;
		GlobalScript.inst.gameState.resultOfEvents[471] = -1;
	}

	public void DLC00(int lng)
	{
		TextAsset textAsset = Resources.Load(string.Format("other_text_{0}", (lng == 0) ? "en" : "ru")) as TextAsset;
		GlobalScript.inst.other_text = textAsset.text.Split('\n');
		TextAsset obj = Resources.Load("South_data") as TextAsset;
		string text = obj.text;
		Resources.UnloadAsset(obj);
		text = text.Replace("\n", "");
		string[] array = text.Split(':');
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(';');
			int num = int.Parse(array2[0]);
			GlobalScript.inst.gameState.allcountries[num] = new Country
			{
				isSEV = (array2[1] == "1"),
				isOVD = (array2[2] == "1"),
				Vyshi = (array2[3] == "1"),
				proprc = (array2[4] == "1"),
				prosov = (array2[5] == "1"),
				okb = (array2[6] == "1"),
				econ = (array2[7] == "1"),
				Torg = (array2[8] == "1"),
				usalliance = (array2[9] == "1"),
				sovalliance = (array2[10] == "1"),
				cw = false,
				stab = int.Parse(array2[12]),
				dev = int.Parse(array2[13]),
				sovpower = int.Parse(array2[14]),
				usapower = int.Parse(array2[15]),
				prcpower = int.Parse(array2[16]),
				Gosstroy = int.Parse(array2[17]),
				SubGosstroy = int.Parse(array2[18]),
				level_of_dev = int.Parse(array2[19]),
				level_of_unstab = int.Parse(array2[20]),
				next_elections = new DateTime(int.Parse(array2[23]), int.Parse(array2[22]), int.Parse(array2[21]))
			};
		}
	}

	public void DLC01()
	{
		if (GlobalScript.inst.gameState.gamerules[0] == 1)
		{
			GlobalScript.inst.gameState.empires[1].MakeHistorical();
		}
		else if (GlobalScript.inst.gameState.gamerules[1] > 1)
		{
			if (GlobalScript.inst.gameState.gamerules[0] == 3)
			{
				GlobalScript.inst.gameState.empires[1].MakeAgressive();
			}
			else if (GlobalScript.inst.gameState.gamerules[0] == 4)
			{
				GlobalScript.inst.gameState.empires[1].MakePeaceful();
			}
			else if (GlobalScript.inst.gameState.gamerules[0] == 2)
			{
				GlobalScript.inst.gameState.gamerules[0] = Utils.RandomRangeFromTwoGroups(new int[4] { 1, 2, 3, 5 });
				if (GlobalScript.inst.gameState.gamerules[0] == 1)
				{
					GlobalScript.inst.gameState.empires[1].MakeHistorical();
				}
				else if (GlobalScript.inst.gameState.gamerules[0] == 3)
				{
					GlobalScript.inst.gameState.empires[1].MakeAgressive();
				}
				else
				{
					GlobalScript.inst.gameState.empires[1].MakePeaceful();
				}
			}
		}
		if (GlobalScript.inst.gameState.gamerules[1] == 1)
		{
			GlobalScript.inst.gameState.empires[1].MakeHistorical();
		}
		else if (GlobalScript.inst.gameState.gamerules[0] > 1)
		{
			if (GlobalScript.inst.gameState.gamerules[1] == 3)
			{
				GlobalScript.inst.gameState.empires[1].MakeConservative();
			}
			else if (GlobalScript.inst.gameState.gamerules[1] == 4)
			{
				GlobalScript.inst.gameState.empires[1].MakeReformist();
			}
			else if (GlobalScript.inst.gameState.gamerules[1] == 2)
			{
				GlobalScript.inst.gameState.gamerules[1] = Utils.RandomRangeFromTwoGroups(new int[4] { 1, 2, 3, 5 });
				if (GlobalScript.inst.gameState.gamerules[1] == 1)
				{
					GlobalScript.inst.gameState.empires[1].MakeHistorical();
				}
				else if (GlobalScript.inst.gameState.gamerules[1] == 4)
				{
					GlobalScript.inst.gameState.empires[1].MakeReformist();
				}
				else
				{
					GlobalScript.inst.gameState.empires[1].MakeConservative();
				}
			}
		}
		if (GlobalScript.inst.gameState.gamerules[2] == 1)
		{
			GlobalScript.inst.gameState.empires[0].MakeHistorical();
		}
		else if (GlobalScript.inst.gameState.gamerules[3] > 1)
		{
			if (GlobalScript.inst.gameState.gamerules[2] == 3)
			{
				GlobalScript.inst.gameState.empires[0].MakeAgressive();
			}
			else if (GlobalScript.inst.gameState.gamerules[2] == 4)
			{
				GlobalScript.inst.gameState.empires[0].MakePeaceful();
			}
			else if (GlobalScript.inst.gameState.gamerules[2] == 2)
			{
				GlobalScript.inst.gameState.gamerules[2] = Utils.RandomRangeFromTwoGroups(new int[4] { 1, 2, 3, 5 });
				if (GlobalScript.inst.gameState.gamerules[2] == 1)
				{
					GlobalScript.inst.gameState.empires[0].MakeHistorical();
				}
				else if (GlobalScript.inst.gameState.gamerules[2] == 3)
				{
					GlobalScript.inst.gameState.empires[0].MakeAgressive();
				}
				else
				{
					GlobalScript.inst.gameState.empires[0].MakePeaceful();
				}
			}
		}
		if (GlobalScript.inst.gameState.gamerules[3] == 1)
		{
			GlobalScript.inst.gameState.empires[0].MakeHistorical();
		}
		else if (GlobalScript.inst.gameState.gamerules[2] > 1)
		{
			if (GlobalScript.inst.gameState.gamerules[3] == 3)
			{
				GlobalScript.inst.gameState.empires[0].MakeConservative();
			}
			else if (GlobalScript.inst.gameState.gamerules[3] == 4)
			{
				GlobalScript.inst.gameState.empires[0].MakeReformist();
			}
			else if (GlobalScript.inst.gameState.gamerules[3] == 2)
			{
				GlobalScript.inst.gameState.gamerules[3] = Utils.RandomRangeFromTwoGroups(new int[4] { 1, 2, 3, 5 });
				if (GlobalScript.inst.gameState.gamerules[3] == 1)
				{
					GlobalScript.inst.gameState.empires[0].MakeHistorical();
				}
				else if (GlobalScript.inst.gameState.gamerules[3] == 4)
				{
					GlobalScript.inst.gameState.empires[0].MakeReformist();
				}
				else
				{
					GlobalScript.inst.gameState.empires[0].MakeConservative();
				}
			}
		}
		if (GlobalScript.inst.gameState.ContaintsRange(GlobalScript.inst.gameState.gamerules, (int c) => c > 1))
		{
			GlobalScript.inst.gameState.iron_and_blood = false;
		}
	}

	public void CreateFocuses()
	{
		USSRFocuses.Init();
	}

	private void Awake()
	{
		global1 = GlobalScript.inst;
	}

	private void OnMouseEnter()
	{
		if (number != -1)
		{
			GetComponent<TextMesh>().color = Color.gray;
		}
	}

	private void OnMouseExit()
	{
		GetComponent<TextMesh>().color = Color.black;
	}
}
