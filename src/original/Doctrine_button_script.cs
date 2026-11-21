using UnityEngine;

public class Doctrine_button_script : MonoBehaviour
{
	public Sprite usl_off;

	public Sprite usl_on;

	private bool is_active;

	public TextMesh opisannya;

	private string fake_text;

	public GameObject[] uslovie = new GameObject[4];

	private bool[] uslovie_bool = new bool[4];

	private int number_uslovie;

	private string[] uslovie_text = new string[4];

	public GlobalScript global1;

	public Doctrine_script doctr1;

	public Sprite on;

	public Sprite off;

	private int this_type = -1;

	private int this_number;

	private int number;

	private int summa;

	private int summa_3_2;

	private int player_numbeer;

	private bool neutral_leading;

	public int selected_country = -1;

	private void Awake()
	{
		global1 = GlobalScript.inst;
	}

	public void Show(string text, int number_clone, int this_number_clone)
	{
		if (global1 == null)
		{
			global1 = GlobalScript.inst;
		}
		this_number = this_number_clone;
		number = number_clone;
		this_type = number_clone;
		GetComponent<SpriteRenderer>().sprite = off;
		base.transform.Find("Text").GetComponent<TextMesh>().text = text;
		if (GlobalScript.inst.gameState.data[15] <= 7 && GlobalScript.inst.gameState.data[106] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.data[106] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.data[106] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.data[106] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.data[106] >= GlobalScript.inst.gameState.party_number[4])
		{
			neutral_leading = true;
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			number_uslovie = 4;
			uslovie_bool[0] = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 50;
			uslovie_text[0] = " 预 算 中 的 资 金 ：" + Mathf.Abs((number - GlobalScript.inst.gameState.data[this_number]) * 5);
			uslovie_bool[1] = GlobalScript.inst.gameState.data[1] >= Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 300;
			uslovie_text[1] = " 党 内 团 结 度 高 于 ：" + Mathf.Abs((number - GlobalScript.inst.gameState.data[this_number]) * 30);
			if (GlobalScript.inst.gameState.data[15] <= 7 && !neutral_leading)
			{
				if (number == 10)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1) && GlobalScript.inst.gameState.data[15] != 7;
					uslovie_text[2] = " 极 左 派/ 保 守 派 领 导\n 并 非 \" 新 民 主 主 义 制 度\"";
				}
				else if (number == 11)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1;
					uslovie_text[2] = " 极 左 派/ 保 守 派 领 导";
				}
				else if (number == 12)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2;
					uslovie_text[2] = " 保 守 派/ 温 和 派 领 导";
				}
				else if (number == 13)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
					uslovie_text[2] = " 温 和 派/ 改 革 派 领 导";
				}
				else if (number == 14)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 改 革 派/ 自 由 派 领 导";
				}
				else if (number == 15)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4 && GlobalScript.inst.gameState.data[15] != 7;
					uslovie_text[2] = " 自 由 派 领 导\n 并 非 \" 新 民 主 主 义 制 度\"";
				}
				else if (number == 6)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0;
					uslovie_text[2] = " 极 左 派 领 导";
				}
				else if (number == 7)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2;
					uslovie_text[2] = " 保 守 派/ 温 和 派 领 导";
				}
				else if (number == 8)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3;
					uslovie_text[2] = " 改 革 派 领 导";
				}
				else if (number == 9)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 自 由 派 领 导";
				}
				else if (number == 16)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] != 4;
					uslovie_text[2] = " 非 自 由 派 领 导";
				}
				else if (number == 17)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] <= 4;
					uslovie_text[2] = " 任 意 派 领 导";
				}
				else if (number == 18)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 温 和 派/ 改 革 派/ 自 由 派 领 导";
				}
				else if (number == 19)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 改 革 派/ 自 由 派 领 导";
				}
				else if (number == 20)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
					uslovie_text[2] = " 极 左 派/ 保 守 派/ 温 和 派/ 改 革 派| 领 导";
				}
				else if (number == 21)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
					uslovie_text[2] = " 温 和 派/ 改 革 派 领 导";
				}
				else if (number == 22)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 改 革 派/ 自 由 派 领 导";
				}
				else if (number == 23)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 自 由 派 领 导";
				}
				else if (number == 24)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0;
					uslovie_text[2] = " 极 左 派 领 导";
				}
				else if (number == 25)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1;
					uslovie_text[2] = " 极 左 派/ 保 守 派 领 导";
				}
				else if (number == 26)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
					uslovie_text[2] = " 保 守 派/ 温 和 派/ 改 革 派 领 导";
				}
				else if (number == 27)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 温 和 派/ 改 革 派/ 自 由 派 领 导";
				}
				else if (number == 28)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 改 革 派/ 自 由 派 领 导";
				}
				else if (number == 29)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4 || (GlobalScript.inst.gameState.data[14] == 0 && GlobalScript.inst.gameState.data[31] >= 700);
					uslovie_text[2] = " 自 由 派 领 导/| 威 权 主 义 且 民 族 主 义 高 涨";
				}
				else if (number == 30)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0;
					uslovie_text[2] = " 极 左 派 领 导";
				}
				else if (number == 31)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2;
					uslovie_text[2] = " 极 左 派/ 保 守 派/ 温 和 派 领 导";
				}
				else if (number == 32)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
					uslovie_text[2] = " 温 和 派/ 改 革 派 领 导";
				}
				else if (number == 33)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
					uslovie_text[2] = " 改 革 派/ 自 由 派 领 导";
				}
			}
			else if (GlobalScript.inst.gameState.data[15] <= 7)
			{
				uslovie_bool[2] = !neutral_leading;
				uslovie_text[2] = " 满 意 现 状 者 失 去 领 导";
			}
			else
			{
				player_numbeer = GlobalScript.inst.gameState.party_number[1];
				for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
				{
					if (GlobalScript.inst.gameState.is_party_ally[i] && GlobalScript.inst.gameState.is_party_enabled[i] && i != 1)
					{
						player_numbeer += GlobalScript.inst.gameState.party_number[i];
					}
				}
				summa = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4] + GlobalScript.inst.gameState.data[106];
				summa_3_2 = player_numbeer * 100 / summa;
				if (number == 10)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[52] == 34 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 社 会 主 义  且";
					string[] array = uslovie_text;
					int num = 2;
					array[num] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 11)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[52] == 34 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 社 会 主 义  且";
					string[] array2 = uslovie_text;
					int num2 = 2;
					array2[num2] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 12)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[52] == 34 || GlobalScript.inst.gameState.data[52] == 35) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 社 会 主 义/ 改 良 主 义  且";
					string[] array3 = uslovie_text;
					int num3 = 2;
					array3[num3] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 13)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[52] == 35 || GlobalScript.inst.gameState.data[52] == 36) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 改 良 主 义/ 实 用 主 义  且";
					string[] array4 = uslovie_text;
					int num4 = 2;
					array4[num4] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 14)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[52] == 36 || GlobalScript.inst.gameState.data[52] == 37) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 实 用 主 义/ 市 场 主 义  且";
					string[] array5 = uslovie_text;
					int num5 = 2;
					array5[num5] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 15)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[52] == 37 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 市 场 主 义  且";
					string[] array6 = uslovie_text;
					int num6 = 2;
					array6[num6] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 6)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权/ 强 硬  且";
					string[] array7 = uslovie_text;
					int num7 = 2;
					array7[num7] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 7)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 强 硬/ 温 和  且";
					string[] array8 = uslovie_text;
					int num8 = 2;
					array8[num8] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 8)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 温 和/ 民 主  且";
					string[] array9 = uslovie_text;
					int num9 = 2;
					array9[num9] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 9)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 41 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 民 主  且";
					string[] array10 = uslovie_text;
					int num10 = 2;
					array10[num10] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 16)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权/ 强 硬  且";
					string[] array11 = uslovie_text;
					int num11 = 2;
					array11[num11] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 17)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 强 硬/ 温 和  且";
					string[] array12 = uslovie_text;
					int num12 = 2;
					array12[num12] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 18)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 40 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 温 和  且";
					string[] array13 = uslovie_text;
					int num13 = 2;
					array13[num13] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 19)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 41 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 民 主  且";
					string[] array14 = uslovie_text;
					int num14 = 2;
					array14[num14] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 20)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权/ 强 硬  且";
					string[] array15 = uslovie_text;
					int num15 = 2;
					array15[num15] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 21)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 强 硬/ 温 和/ 民 主  且";
					string[] array16 = uslovie_text;
					int num16 = 2;
					array16[num16] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 22)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 温 和/ 民 主  且";
					string[] array17 = uslovie_text;
					int num17 = 2;
					array17[num17] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 23)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 41 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 民 主  且";
					string[] array18 = uslovie_text;
					int num18 = 2;
					array18[num18] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 24)
				{
					uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 38 && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权  且";
					string[] array19 = uslovie_text;
					int num19 = 2;
					array19[num19] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 25)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权/ 强 硬  且";
					string[] array20 = uslovie_text;
					int num20 = 2;
					array20[num20] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 26)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 强 硬/ 温 和  且";
					string[] array21 = uslovie_text;
					int num21 = 2;
					array21[num21] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 27)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 温 和/ 民 主  且";
					string[] array22 = uslovie_text;
					int num22 = 2;
					array22[num22] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 28)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 强 硬/ 民 主  且";
					string[] array23 = uslovie_text;
					int num23 = 2;
					array23[num23] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 29)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && (GlobalScript.inst.gameState.data[52] == 36 || GlobalScript.inst.gameState.data[52] == 37) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权/ 强 硬 ，| 实 用 主 义/ 市 场 主 义  且";
					string[] array24 = uslovie_text;
					int num24 = 2;
					array24[num24] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 30)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权/ 强 硬  且";
					string[] array25 = uslovie_text;
					int num25 = 2;
					array25[num25] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 31)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 威 权/ 民 主  且";
					string[] array26 = uslovie_text;
					int num26 = 2;
					array26[num26] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 32)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 温 和/ 民 主  且";
					string[] array27 = uslovie_text;
					int num27 = 2;
					array27[num27] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
				else if (number == 33)
				{
					uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
					uslovie_text[2] = " 党 派 路 线 ： 强 硬/ 温 和/ 民 主  且";
					string[] array28 = uslovie_text;
					int num28 = 2;
					array28[num28] += " 我 方 党 派 联 盟 在 全 国 人 大 中 保 有 66% 以 上 席 位";
				}
			}
			if (GlobalScript.inst.gameState.data[38] >= 100)
			{
				uslovie_bool[3] = GlobalScript.inst.gameState.data[this_number] != number;
				uslovie_text[3] = " 尚 未 建 立";
			}
			else
			{
				uslovie_bool[3] = GlobalScript.inst.gameState.data[38] >= 100;
				uslovie_text[3] = " 毛 主 席 已 离 世 ， 起 锚 ！";
			}
			if (GlobalScript.inst.gameState.modifies[6].active && (number == 14 || number == 15 || number == 9 || (number == 19 && GlobalScript.inst.gameState.resultOfEvents[444] != 0) || number == 22 || number == 23 || number == 28 || number == 29))
			{
				uslovie_bool[3] = !GlobalScript.inst.gameState.modifies[6].active;
				uslovie_text[3] = " 毛 主 席 正 看 着 你 ！";
			}
			return;
		}
		number_uslovie = 4;
		uslovie_bool[0] = GlobalScript.inst.gameState.data[8] + GlobalScript.inst.gameState.data[36] >= Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 50;
		uslovie_text[0] = "Денег в бюджете: " + Mathf.Abs((number - GlobalScript.inst.gameState.data[this_number]) * 5);
		uslovie_bool[1] = GlobalScript.inst.gameState.data[1] >= Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 300;
		uslovie_text[1] = "Поддержка в Партии больше, чем: " + Mathf.Abs((number - GlobalScript.inst.gameState.data[this_number]) * 30);
		if (GlobalScript.inst.gameState.data[15] <= 7 && !neutral_leading)
		{
			if (number == 10)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1) && GlobalScript.inst.gameState.data[15] != 7;
				uslovie_text[2] = "Леворадикалы/консерваторы лидируют + не \"Новая демократия\"";
			}
			else if (number == 11)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.event_done[111] && GlobalScript.inst.gameState.science[17] && GlobalScript.inst.gameState.data[15] != 7;
				uslovie_text[2] = "ОГАС изучен и никто не сопротивляется + не \"Новая демократия\"";
			}
			else if (number == 12)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2;
				uslovie_text[2] = "Консерваторы/умеренные лидируют";
			}
			else if (number == 13)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
				uslovie_text[2] = "Умеренные/реформаторы лидируют";
			}
			else if (number == 14)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Реформаторы/либералы лидируют";
			}
			else if (number == 15)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4 && GlobalScript.inst.gameState.data[15] != 7;
				uslovie_text[2] = "Либералы лидируют + не \"Новая демократия\"";
			}
			else if (number == 6)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0;
				uslovie_text[2] = "Леворадикалы лидируют";
			}
			else if (number == 7)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2;
				uslovie_text[2] = "Консерваторы/умеренные лидируют";
			}
			else if (number == 8)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3;
				uslovie_text[2] = "Реформаторы лидируют";
			}
			else if (number == 9)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Либералы лидируют";
			}
			else if (number == 16)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1;
				uslovie_text[2] = "Леворадикалы/консерваторы лидируют";
			}
			else if (number == 17)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
				uslovie_text[2] = "Леворадикалы/консерваторы/ умеренные/реформаторы лидируют";
			}
			else if (number == 18)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Умеренные/реформаторы/ либералы лидируют";
			}
			else if (number == 19)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Реформаторы/либералы лидируют";
			}
			else if (number == 20)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
				uslovie_text[2] = "Леворадикалы/умеренные/ консерваторы/реформаторы лидируют";
			}
			else if (number == 21)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
				uslovie_text[2] = "Умеренные/реформаторы лидируют";
			}
			else if (number == 22)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Реформаторы/либералы лидируют";
			}
			else if (number == 23)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Либералы лидируют";
			}
			else if (number == 24)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0;
				uslovie_text[2] = "Леворадикалы лидируют";
			}
			else if (number == 25)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1;
				uslovie_text[2] = "Леворадикалы/консерваторы лидируют";
			}
			else if (number == 26)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
				uslovie_text[2] = "Консерваторы/умеренные/ реформаторы лидируют";
			}
			else if (number == 27)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Умеренные/реформаторы/либералы лидируют";
			}
			else if (number == 28)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Реформаторы/либералы лидируют";
			}
			else if (number == 29)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 4 || (GlobalScript.inst.gameState.data[14] == 0 && GlobalScript.inst.gameState.data[31] >= 700);
				uslovie_text[2] = "Либералы лидируют/Авторитаризм плюс высокий национализм";
			}
			else if (number == 30)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0;
				uslovie_text[2] = "Леворадикалы лидируют";
			}
			else if (number == 31)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 0 || GlobalScript.inst.gameState.data[56] == 1 || GlobalScript.inst.gameState.data[56] == 2;
				uslovie_text[2] = "Леворадикалы/консерваторы/ умеренные лидируют";
			}
			else if (number == 32)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 2 || GlobalScript.inst.gameState.data[56] == 3;
				uslovie_text[2] = "Умеренные/реформаторы лидируют";
			}
			else if (number == 33)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[56] == 3 || GlobalScript.inst.gameState.data[56] == 4;
				uslovie_text[2] = "Реформаторы/либералы лидируют";
			}
		}
		else if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			uslovie_bool[2] = !neutral_leading;
			uslovie_text[2] = "Удовлетворённые не лидируют";
		}
		else
		{
			player_numbeer = GlobalScript.inst.gameState.party_number[1];
			for (int j = 0; j < GlobalScript.inst.gameState.is_party_ally.Length; j++)
			{
				if (GlobalScript.inst.gameState.is_party_ally[j] && GlobalScript.inst.gameState.is_party_enabled[j] && j != 1)
				{
					player_numbeer += GlobalScript.inst.gameState.party_number[j];
				}
			}
			summa = GlobalScript.inst.gameState.party_number[0] + GlobalScript.inst.gameState.party_number[1] + GlobalScript.inst.gameState.party_number[2] + GlobalScript.inst.gameState.party_number[3] + GlobalScript.inst.gameState.party_number[4] + GlobalScript.inst.gameState.data[106];
			summa_3_2 = player_numbeer * 100 / summa;
			if (number == 10)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[52] == 34 && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Социалистическая и ";
				string[] array29 = uslovie_text;
				int num29 = 2;
				array29[num29] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 11)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.event_done[111] && GlobalScript.inst.gameState.science[17];
				uslovie_text[2] = "ОГАС изучен и никто не сопротивляется";
			}
			else if (number == 12)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[52] == 34 || GlobalScript.inst.gameState.data[52] == 35) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Социалистическая/Реформаторская и ";
				string[] array30 = uslovie_text;
				int num30 = 2;
				array30[num30] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 13)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[52] == 35 || GlobalScript.inst.gameState.data[52] == 36) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Реформаторская/Прагматичная и ";
				string[] array31 = uslovie_text;
				int num31 = 2;
				array31[num31] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 14)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[52] == 36 || GlobalScript.inst.gameState.data[52] == 37) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Прагматичная/Рыночная и ";
				string[] array32 = uslovie_text;
				int num32 = 2;
				array32[num32] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 15)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[52] == 37 && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Рыночная и ";
				string[] array33 = uslovie_text;
				int num33 = 2;
				array33[num33] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 6)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная/Жёсткая и ";
				string[] array34 = uslovie_text;
				int num34 = 2;
				array34[num34] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 7)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Жёсткая/Мягкая и ";
				string[] array35 = uslovie_text;
				int num35 = 2;
				array35[num35] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 8)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Мягкая/Демократическая и ";
				string[] array36 = uslovie_text;
				int num36 = 2;
				array36[num36] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 9)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 41 && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Демократическая и ";
				string[] array37 = uslovie_text;
				int num37 = 2;
				array37[num37] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 16)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная/Жёсткая и ";
				string[] array38 = uslovie_text;
				int num38 = 2;
				array38[num38] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 17)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Жёсткая/Мягкая и ";
				string[] array39 = uslovie_text;
				int num39 = 2;
				array39[num39] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 18)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 40 && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Мягкая и ";
				string[] array40 = uslovie_text;
				int num40 = 2;
				array40[num40] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 19)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 41 && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Демократическая и ";
				string[] array41 = uslovie_text;
				int num41 = 2;
				array41[num41] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 20)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная/Жёсткая и ";
				string[] array42 = uslovie_text;
				int num42 = 2;
				array42[num42] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 21)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Жёсткая/Мягкая /Демократическая  и ";
				string[] array43 = uslovie_text;
				int num43 = 2;
				array43[num43] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 22)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Мягкая/Демократическая и ";
				string[] array44 = uslovie_text;
				int num44 = 2;
				array44[num44] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 23)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 41 && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Демократическая и ";
				string[] array45 = uslovie_text;
				int num45 = 2;
				array45[num45] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 24)
			{
				uslovie_bool[2] = GlobalScript.inst.gameState.data[54] == 38 && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная и ";
				string[] array46 = uslovie_text;
				int num46 = 2;
				array46[num46] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 25)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная/Жёсткая и ";
				string[] array47 = uslovie_text;
				int num47 = 2;
				array47[num47] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 26)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Жёсткая/Мягкая и ";
				string[] array48 = uslovie_text;
				int num48 = 2;
				array48[num48] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 27)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Мягкая/Демократическая и ";
				string[] array49 = uslovie_text;
				int num49 = 2;
				array49[num49] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 28)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Жёсткая/Демократическая и ";
				string[] array50 = uslovie_text;
				int num50 = 2;
				array50[num50] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 29)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && (GlobalScript.inst.gameState.data[52] == 36 || GlobalScript.inst.gameState.data[52] == 37) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная/Жёсткая и Прагматичная/Рыночная и ";
				string[] array51 = uslovie_text;
				int num51 = 2;
				array51[num51] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 30)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 39) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная/Жёсткая и ";
				string[] array52 = uslovie_text;
				int num52 = 2;
				array52[num52] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 31)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 38 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Авторитарная/Демократическая и ";
				string[] array53 = uslovie_text;
				int num53 = 2;
				array53[num53] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 32)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Мягкая/Демократическая и ";
				string[] array54 = uslovie_text;
				int num54 = 2;
				array54[num54] += "Наш альянс имеет более 66% мест в ВСНП";
			}
			else if (number == 33)
			{
				uslovie_bool[2] = (GlobalScript.inst.gameState.data[54] == 39 || GlobalScript.inst.gameState.data[54] == 40 || GlobalScript.inst.gameState.data[54] == 41) && summa_3_2 > 66;
				uslovie_text[2] = "Линия партии: Жёсткая/Мягкая/Демократическая и ";
				string[] array55 = uslovie_text;
				int num55 = 2;
				array55[num55] += "Наш альянс имеет более 66% мест в ВСНП";
			}
		}
		if (GlobalScript.inst.gameState.data[38] >= 100)
		{
			uslovie_bool[3] = GlobalScript.inst.gameState.data[this_number] != number;
			uslovie_text[3] = "Не установлена";
		}
		else
		{
			uslovie_bool[3] = GlobalScript.inst.gameState.data[38] >= 100;
			uslovie_text[3] = "Мао мёртв, отдать швартовы!";
		}
	}

	private void OnMouseDown()
	{
		if (number_uslovie != 0 && (number_uslovie != 1 || !uslovie_bool[0]) && (number_uslovie != 2 || !uslovie_bool[0] || !uslovie_bool[1]) && (number_uslovie != 3 || !uslovie_bool[0] || !uslovie_bool[1] || !uslovie_bool[2]) && (number_uslovie != 4 || !uslovie_bool[0] || !uslovie_bool[1] || !uslovie_bool[2] || !uslovie_bool[3]))
		{
			return;
		}
		if (this_number == 16)
		{
			GlobalScript.inst.gameState.data[5] -= Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 50;
			if (GlobalScript.inst.gameState.data[this_number] <= 12 && number >= 13 && GlobalScript.inst.gameState.data[89] < 2)
			{
				GlobalScript.inst.gameState.data[89] = 2;
			}
			else if (GlobalScript.inst.gameState.data[this_number] <= 12 && number >= 13 && GlobalScript.inst.gameState.data[60] < 1)
			{
				GlobalScript.inst.gameState.allcountries[20].Torg = false;
				GlobalScript.inst.gameState.allcountries[20].proprc = false;
			}
		}
		if (this_number == 15)
		{
			if (GlobalScript.inst.gameState.data[this_number] >= 6 && GlobalScript.inst.gameState.data[this_number] <= 7 && number >= 8 && number <= 9)
			{
				int num = 0;
				for (int i = 0; i < GlobalScript.inst.gameState.is_party_ally.Length; i++)
				{
					if (GlobalScript.inst.gameState.is_party_ally[i] && i != 1)
					{
						GlobalScript.inst.gameState.is_party_ally[i] = false;
					}
					if (GlobalScript.inst.gameState.party_ideology[i] < 0)
					{
						GlobalScript.inst.gameState.party_ideology[i] = 0;
					}
					if (GlobalScript.inst.gameState.is_party_enabled[i] && i != 1 && GlobalScript.inst.gameState.party_number[i] > 0)
					{
						num += GlobalScript.inst.gameState.party_number[i] / 2;
						GlobalScript.inst.gameState.party_number[i] -= GlobalScript.inst.gameState.party_number[i] / 2;
						GlobalScript.inst.gameState.party_ideology[i] -= GlobalScript.inst.gameState.party_number[i] / 2;
						num += GlobalScript.inst.gameState.party_number[i] / 4;
						GlobalScript.inst.gameState.party_number[i] -= GlobalScript.inst.gameState.party_number[i] / 4;
						GlobalScript.inst.gameState.party_ideology[i] -= GlobalScript.inst.gameState.party_number[i] / 4;
					}
					else if (!GlobalScript.inst.gameState.is_party_enabled[i])
					{
						GlobalScript.inst.gameState.is_party_enabled[i] = true;
					}
					GlobalScript.inst.gameState.data[53] = 0;
				}
				GlobalScript.inst.gameState.party_number[1] += num;
				GlobalScript.inst.gameState.party_ideology[1] += num;
				GlobalScript.inst.gameState.data[125] = 0;
			}
			else if (GlobalScript.inst.gameState.data[this_number] >= 8 && GlobalScript.inst.gameState.data[this_number] <= 9 && number >= 6 && number <= 7)
			{
				for (int j = 0; j < GlobalScript.inst.gameState.is_party_ally.Length; j++)
				{
					if (GlobalScript.inst.gameState.is_party_ally[j] && j != 1)
					{
						GlobalScript.inst.gameState.is_party_ally[j] = false;
					}
					if (!GlobalScript.inst.gameState.is_party_enabled[j])
					{
						GlobalScript.inst.gameState.is_party_enabled[j] = true;
						if (GlobalScript.inst.gameState.party_number[j] <= 5)
						{
							int num2 = Random.Range(0, 10);
							GlobalScript.inst.gameState.party_number[j] = 10 + num2;
							GlobalScript.inst.gameState.party_ideology[j] = GlobalScript.inst.gameState.party_number[j];
						}
					}
					else
					{
						GlobalScript.inst.gameState.party_number[j] = GlobalScript.inst.gameState.party_ideology[j];
					}
				}
				GlobalScript.inst.gameState.is_party_enabled[4] = false;
				GlobalScript.inst.gameState.party_number[4] = 0;
				GlobalScript.inst.gameState.party_number[3] += GlobalScript.inst.gameState.party_ideology[4];
				GlobalScript.inst.gameState.data[53] = 0;
			}
		}
		GlobalScript.inst.gameState.data[8] -= Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 50;
		if (this_number == 15)
		{
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic in politics)
			{
				if (politic.traits[0] == 0)
				{
					politic.loyality += (GlobalScript.inst.gameState.data[15] - number) * 150;
				}
				else if (politic.traits[0] <= 2 && number >= 7)
				{
					politic.loyality += (GlobalScript.inst.gameState.data[15] - number) * 150;
				}
				else if (politic.traits[0] <= 2 && number <= 7)
				{
					politic.loyality += (number - GlobalScript.inst.gameState.data[15]) * 150;
				}
				else
				{
					politic.loyality += (number - GlobalScript.inst.gameState.data[15]) * 150;
				}
			}
		}
		if (this_number == 16)
		{
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic2 in politics)
			{
				if (politic2.traits[0] == 0)
				{
					politic2.loyality += (GlobalScript.inst.gameState.data[16] - number) * 150;
				}
				else if (politic2.traits[0] == 1 && number >= 13)
				{
					politic2.loyality += (GlobalScript.inst.gameState.data[16] - number) * 150;
				}
				else if (politic2.traits[0] == 1 && number <= 13)
				{
					politic2.loyality += (number - GlobalScript.inst.gameState.data[16]) * 150;
				}
				else
				{
					politic2.loyality += (number - GlobalScript.inst.gameState.data[16]) * 150;
				}
			}
		}
		if (this_number == 17)
		{
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic3 in politics)
			{
				if (politic3.traits[0] == 0)
				{
					politic3.loyality += (GlobalScript.inst.gameState.data[17] - number) * 50;
				}
				else if (politic3.traits[0] == 1 && number >= 18)
				{
					politic3.loyality += (GlobalScript.inst.gameState.data[17] - number) * 50;
				}
				else if (politic3.traits[0] == 1 && number <= 18)
				{
					politic3.loyality += (number - GlobalScript.inst.gameState.data[17]) * 50;
				}
				else
				{
					politic3.loyality += (number - GlobalScript.inst.gameState.data[17]) * 50;
				}
			}
		}
		if (this_number == 18)
		{
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic4 in politics)
			{
				if (politic4.traits[0] == 0 || politic4.traits[0] == 2)
				{
					politic4.loyality += (GlobalScript.inst.gameState.data[18] - number) * 50;
				}
				else if (politic4.traits[0] == 1 && number >= 21)
				{
					politic4.loyality += (GlobalScript.inst.gameState.data[18] - number) * 50;
				}
				else if (politic4.traits[0] == 1 && number <= 21)
				{
					politic4.loyality += (number - GlobalScript.inst.gameState.data[18]) * 50;
				}
				else
				{
					politic4.loyality += (number - GlobalScript.inst.gameState.data[18]) * 50;
				}
			}
		}
		if (this_number == 50)
		{
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic5 in politics)
			{
				if (politic5.traits[0] == 0 || politic5.traits[0] == 2)
				{
					politic5.loyality += (GlobalScript.inst.gameState.data[50] - number) * 50;
				}
				else if (politic5.traits[0] == 1 && number >= 27)
				{
					politic5.loyality += (GlobalScript.inst.gameState.data[50] - number) * 50;
				}
				else if (politic5.traits[0] == 1 && number <= 27)
				{
					politic5.loyality += (number - GlobalScript.inst.gameState.data[50]) * 50;
				}
				else
				{
					politic5.loyality += (number - GlobalScript.inst.gameState.data[50]) * 50;
				}
			}
		}
		if (this_number == 51)
		{
			Politic[] politics = GlobalScript.inst.gameState.politics;
			foreach (Politic politic6 in politics)
			{
				if (politic6.traits[0] == 0 || politic6.traits[0] == 2)
				{
					politic6.loyality += (GlobalScript.inst.gameState.data[51] - number) * 50;
				}
				else if (politic6.traits[0] == 1 && number >= 32)
				{
					politic6.loyality += (GlobalScript.inst.gameState.data[51] - number) * 50;
				}
				else if (politic6.traits[0] == 1 && number <= 32)
				{
					politic6.loyality += (number - GlobalScript.inst.gameState.data[51]) * 50;
				}
				else
				{
					politic6.loyality += (number - GlobalScript.inst.gameState.data[51]) * 50;
				}
			}
		}
		if (this_number == 15)
		{
			if (GlobalScript.inst.gameState.data[this_number] < number)
			{
				GlobalScript.inst.gameState.data[6] -= (number - GlobalScript.inst.gameState.data[this_number]) * 60;
				GlobalScript.inst.gameState.data[55] += (number - GlobalScript.inst.gameState.data[this_number]) * 100;
			}
			else if (GlobalScript.inst.gameState.data[this_number] > number)
			{
				GlobalScript.inst.gameState.data[6] -= (number - GlobalScript.inst.gameState.data[this_number]) * 60;
				GlobalScript.inst.gameState.data[55] += (number - GlobalScript.inst.gameState.data[this_number]) * 100;
			}
		}
		else if (this_number == 16)
		{
			if (GlobalScript.inst.gameState.data[this_number] < number)
			{
				GlobalScript.inst.gameState.data[6] -= (number - GlobalScript.inst.gameState.data[this_number]) * 40;
				GlobalScript.inst.gameState.data[33] += (number - GlobalScript.inst.gameState.data[this_number]) * 100;
			}
			else if (GlobalScript.inst.gameState.data[this_number] > number)
			{
				GlobalScript.inst.gameState.data[6] -= (number - GlobalScript.inst.gameState.data[this_number]) * 40;
				GlobalScript.inst.gameState.data[33] += (number - GlobalScript.inst.gameState.data[this_number]) * 100;
			}
		}
		else if (GlobalScript.inst.gameState.data[this_number] < number)
		{
			GlobalScript.inst.gameState.data[6] -= (number - GlobalScript.inst.gameState.data[this_number]) * 20;
			GlobalScript.inst.gameState.data[55] += (number - GlobalScript.inst.gameState.data[this_number]) * 50;
		}
		else if (GlobalScript.inst.gameState.data[this_number] > number)
		{
			GlobalScript.inst.gameState.data[6] -= (number - GlobalScript.inst.gameState.data[this_number]) * 20;
			GlobalScript.inst.gameState.data[55] += (number - GlobalScript.inst.gameState.data[this_number]) * 50;
		}
		if (GlobalScript.inst.gameState.data[33] <= 250)
		{
			GlobalScript.inst.gameState.data[52] = 34;
		}
		else if (GlobalScript.inst.gameState.data[33] <= 500)
		{
			GlobalScript.inst.gameState.data[52] = 35;
		}
		else if (GlobalScript.inst.gameState.data[33] <= 750)
		{
			GlobalScript.inst.gameState.data[52] = 36;
		}
		else
		{
			GlobalScript.inst.gameState.data[52] = 37;
		}
		if (GlobalScript.inst.gameState.data[55] <= 250)
		{
			GlobalScript.inst.gameState.data[54] = 38;
		}
		else if (GlobalScript.inst.gameState.data[55] <= 500)
		{
			GlobalScript.inst.gameState.data[54] = 39;
		}
		else if (GlobalScript.inst.gameState.data[55] <= 750)
		{
			GlobalScript.inst.gameState.data[54] = 40;
		}
		else
		{
			GlobalScript.inst.gameState.data[54] = 41;
		}
		if (GlobalScript.inst.gameState.data[15] < 8)
		{
			GlobalScript.inst.gameState.data[1] -= Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 30;
			GlobalScript.inst.gameState.data[4] += Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 10;
		}
		else
		{
			GlobalScript.inst.gameState.data[4] += Mathf.Abs(number - GlobalScript.inst.gameState.data[this_number]) * 20;
		}
		if (this_number != 51)
		{
			GlobalScript.inst.gameState.data[92] += (number - GlobalScript.inst.gameState.data[this_number]) * 15;
		}
		GlobalScript.inst.gameState.data[this_number] = number;
		int num3 = 5;
		if (GlobalScript.inst.gameState.data[16] == 10)
		{
			num3--;
		}
		if (GlobalScript.inst.gameState.data[16] == 15 || GlobalScript.inst.gameState.data[16] == 14)
		{
			num3 = ((GlobalScript.inst.gameState.data[17] <= 17) ? (num3 - 1) : (num3 + 1));
		}
		if (GlobalScript.inst.gameState.data[15] == 6)
		{
			num3--;
		}
		if (GlobalScript.inst.gameState.data[15] == 8)
		{
			num3++;
		}
		if (GlobalScript.inst.gameState.data[15] == 9)
		{
			num3 += 2;
		}
		if (GlobalScript.inst.gameState.data[17] == 16)
		{
			num3--;
		}
		if (GlobalScript.inst.gameState.data[17] == 18)
		{
			num3++;
		}
		if (GlobalScript.inst.gameState.data[17] == 19)
		{
			num3 += 3;
		}
		if (GlobalScript.inst.gameState.data[50] == 24 || GlobalScript.inst.gameState.data[50] == 29)
		{
			num3 -= 2;
		}
		if (GlobalScript.inst.gameState.data[50] == 25 || GlobalScript.inst.gameState.data[50] == 28)
		{
			num3--;
		}
		if (GlobalScript.inst.gameState.data[50] == 27)
		{
			num3++;
		}
		if (GlobalScript.inst.gameState.data[18] == 20 && GlobalScript.inst.gameState.data[51] == 30)
		{
			num3--;
		}
		if (GlobalScript.inst.gameState.data[18] >= 22 && GlobalScript.inst.gameState.data[51] == 33)
		{
			num3++;
		}
		if (GlobalScript.inst.gameState.data[18] == 23)
		{
			num3++;
		}
		if (GlobalScript.inst.gameState.modifies[40].active || GlobalScript.inst.gameState.modifies[38].active)
		{
			num3--;
		}
		if (GlobalScript.inst.gameState.event_done[502] && GlobalScript.inst.gameState.resultOfEvents[502] != 3)
		{
			num3 -= 2;
		}
		if (num3 <= 0)
		{
			GlobalScript.inst.gameState.data[14] = 0;
		}
		else if (num3 <= 3 && GlobalScript.inst.gameState.data[16] <= 11)
		{
			GlobalScript.inst.gameState.data[14] = 1;
		}
		else if (num3 <= 6)
		{
			if (GlobalScript.inst.gameState.data[16] <= 13)
			{
				GlobalScript.inst.gameState.data[14] = 2;
			}
			else
			{
				GlobalScript.inst.gameState.data[14] = 3;
			}
		}
		else if (num3 <= 9)
		{
			if (GlobalScript.inst.gameState.data[16] <= 13)
			{
				if (GlobalScript.inst.gameState.data[16] <= 11)
				{
					GlobalScript.inst.gameState.data[14] = 2;
				}
				else
				{
					GlobalScript.inst.gameState.data[14] = 3;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[14] = 4;
			}
		}
		else if (num3 <= 12)
		{
			if (GlobalScript.inst.gameState.data[16] <= 13)
			{
				if (GlobalScript.inst.gameState.data[16] <= 11)
				{
					GlobalScript.inst.gameState.data[14] = 3;
				}
				else
				{
					GlobalScript.inst.gameState.data[14] = 4;
				}
			}
			else
			{
				GlobalScript.inst.gameState.data[14] = 5;
			}
		}
		else if (GlobalScript.inst.gameState.data[16] > 12)
		{
			GlobalScript.inst.gameState.data[14] = 5;
		}
		else if (GlobalScript.inst.gameState.data[16] > 11)
		{
			GlobalScript.inst.gameState.data[14] = 4;
		}
		else
		{
			GlobalScript.inst.gameState.data[14] = 3;
		}
		GlobalScript.inst.gameState.allcountries[1].SubGosstroy = GlobalScript.inst.gameState.ChineseSubGosstroy();
		if (GlobalScript.inst.gameState.data[15] <= 7)
		{
			GlobalScript.inst.gameState.data[106] += GlobalScript.inst.gameState.party_ideology[GlobalScript.inst.gameState.data[56]] / 4;
			if (GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 0;
			}
			else if (GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[1] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[1] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[1] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 1;
			}
			else if (GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 2;
			}
			else if (GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 3;
			}
			else if (GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[1] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] <= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 4;
			}
		}
		else
		{
			GlobalScript.inst.gameState.data[106] += GlobalScript.inst.gameState.party_number[1] / 4;
			int num4 = GlobalScript.inst.gameState.party_number[1];
			for (int l = 0; l < GlobalScript.inst.gameState.is_party_ally.Length; l++)
			{
				if (GlobalScript.inst.gameState.is_party_ally[l] && GlobalScript.inst.gameState.is_party_enabled[l] && l != 1)
				{
					num4 += GlobalScript.inst.gameState.party_number[l];
				}
			}
			if (num4 >= GlobalScript.inst.gameState.party_number[0] && num4 >= GlobalScript.inst.gameState.party_number[2] && num4 >= GlobalScript.inst.gameState.party_number[3] && num4 >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 1;
			}
			else if (!GlobalScript.inst.gameState.is_party_ally[0] && GlobalScript.inst.gameState.is_party_enabled[0] && num4 <= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[0] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 0;
			}
			else if (!GlobalScript.inst.gameState.is_party_ally[2] && GlobalScript.inst.gameState.is_party_enabled[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[0] && num4 <= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[2] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 2;
			}
			else if (!GlobalScript.inst.gameState.is_party_ally[3] && GlobalScript.inst.gameState.is_party_enabled[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[2] && num4 <= GlobalScript.inst.gameState.party_number[3] && GlobalScript.inst.gameState.party_number[3] >= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 3;
			}
			else if (!GlobalScript.inst.gameState.is_party_ally[4] && GlobalScript.inst.gameState.is_party_enabled[4] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[0] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[2] && GlobalScript.inst.gameState.party_number[4] >= GlobalScript.inst.gameState.party_number[3] && num4 <= GlobalScript.inst.gameState.party_number[4])
			{
				GlobalScript.inst.gameState.data[56] = 4;
			}
		}
		GameObject.Find("Kr").GetComponent<Crushok_politic>().Repaint();
		for (int m = 1; m <= 5; m++)
		{
			GameObject.Find("Parties (" + m + ")").transform.Find("Text").GetComponent<Politic_party_name_show>().Repaint();
			GameObject.Find("Parties (" + m + ")").transform.Find("Znack").GetComponent<Party_ally_script>().Repaint();
			if (m != 1)
			{
				GameObject.Find("Parties (" + m + ")").transform.Find("Znakc (1)").GetComponent<Party_zapret>().Repaint();
			}
		}
		for (int n = 0; n < 4; n++)
		{
			uslovie[n].GetComponent<TextMesh>().text = null;
			uslovie[n].transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			uslovie[n].transform.Find("If (1)").GetComponent<SpriteRenderer>().sprite = null;
		}
		doctr1.ShowHideOcno();
	}

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = on;
		for (int i = 0; i < number_uslovie; i++)
		{
			uslovie[i].GetComponent<TextMesh>().text = Text(uslovie_text[i], 30);
			if (uslovie_bool[i])
			{
				uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = usl_on;
				uslovie[i].transform.Find("If (1)").GetComponent<SpriteRenderer>().sprite = usl_on;
			}
			else
			{
				uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = usl_off;
				uslovie[i].transform.Find("If (1)").GetComponent<SpriteRenderer>().sprite = usl_off;
			}
		}
		if (PlayerPrefs.GetInt("language") == 0)
		{
			if (GlobalScript.inst.gameState.modifies[6].active && GlobalScript.inst.gameState.resultOfEvents[667] != 0)
			{
				if (number == 10)
				{
					if (!GlobalScript.inst.gameState.modifies[11].active)
					{
						fake_text = "以 约 瑟 夫 · 斯 大 林 时 代 苏 联 的 经 济 制 度 为 蓝 本 形 成 的 发 展 模 式 ： 国 营 经 济 为 支 柱 ， 集 体 产 业 促 过 渡 ， 并 通 过 适 量 的 副 业 经 营 形 式 为 补 充 。 国 家 以 五 年 计 划 形 式 统 筹 国 民 经 济 ， 并 引 入 经 济 核 算 制 度 估 量 生 产 效 益 ， 从 而 实 现 国 民 经 济 持 续 发 展 。";
					}
					else
					{
						fake_text = "在 中 央 计 划 经 济 的 基 础 上 引 入 计 算 机 ， 建 立 数 据 库 并 启 用 自 动 收 集 与 处 理 经 济 信 息 的 自 动 化 系 统 ， 将 决 策 方 案 交 由 计 算 机 运 算 得 出 。 这 将 迅 速 提 高 经 济 决 策 效 率 与 经 济 生 活 的 透 明 度";
					}
				}
				else if (number == 11)
				{
					if (!GlobalScript.inst.gameState.modifies[11].active)
					{
						fake_text = "依 托 中 国 国 情 生 成 的 计 划 经 济 变 种 ， 在 确 保 计 划 经 济 基 本 特 点 的 同 时 拓 展 了 地 方 部 门 与 基 层 生 产 单 位 在 所 有 制 与 生 产 组 织 的 权 限 （ 如 农 村 层 面 实 行 的 三 级 所 有 ， 队 为 基 础 ） 。 国 家 计 委 、 地 方 政 府 与 生 产 单 位 将 在 共 同 协 作 的 基 础 上 达 成 五 年 计 划 指 标 ， 由 此 既 可 确 保 各 方 能 动 性 ， 又 可 使 全 国 经 济 发 展 统 筹 兼 顾 。";
					}
					else
					{
						fake_text = "在 分 权 计 划 经 济 的 基 础 上 引 入 计 算 机 ， 通 过 高 效 、 迅 速 、 精 确 的 数 字 工 作 组 织 起 不 间 断 的 供 应 — 生 产 — 商 品 网 络 ， 极 大 的 改 善 企 业 、 商 店 、 仓 库 和 交 通 之 间 的 协 调 运 转 ， 以 实 现 经 济 繁 荣";
					}
				}
				else if (number == 12)
				{
					fake_text = "该 经 济 体 制 充 分 利 用 市 场 关 系 与 商 品 货 币 机 制 ， 在 确 保 国 家 掌 握 经 济 制 高 点 的 同 时 积 极 运 用 经 济 核 算 机 制 ， 促 进 企 业 增 产 增 效 。 与 此 同 时 ， 我 们 将 在 无 足 轻 重 的 领 域 内 放 开 多 种 经 营 形 式 ， 进 一 步 巩 固 现 有 经 济 制 度 。";
				}
				else if (number == 13)
				{
					fake_text = "“ 只 要 社 会 需 要 ， 地 下 工 厂 还 可 以 增 加 。 可 以 开 私 营 大 厂 ， 订 个 协 议 ， 十 年 、 二 十 年 不 没 收 。 华 侨 投 资 的 ， 二 十 年 、 一 百 年 不 要 没 收 。 可 以 开 投 资 公 司 ， 还 本 付 息 。 可 以 搞 国 营 ， 也 可 以 搞 私 营 。 可 以 消 灭 了 资 本 主 义 ， 又 搞 资 本 主 义 。 ” — — 毛 泽 东";
				}
				else if (number == 14)
				{
					fake_text = "<color=red>“ 党 内 党 外 都 要 分 清 是 非 。 如 何 对 待 犯 了 错 误 的 人 ， 这 是 一 个 重 要 的 问 题 。 正 确 的 态 度 应 当 是 ， 对 于 犯 错 误 的 同 志 ， 采 取 ‘ 惩 前 毖 后 ， 治 病 救 人 ’ 的 方 针 ， 帮 助 他 们 改 正 错 误 ， 允 许 他 们 继 续 革 命 。 ” — — 毛 泽 东</color>";
				}
				else if (number == 15)
				{
					fake_text = "<color=red>“ 党 内 党 外 都 要 分 清 是 非 。 如 何 对 待 犯 了 错 误 的 人 ， 这 是 一 个 重 要 的 问 题 。 正 确 的 态 度 应 当 是 ， 对 于 犯 错 误 的 同 志 ， 采 取 ‘ 惩 前 毖 后 ， 治 病 救 人 ’ 的 方 针 ， 帮 助 他 们 改 正 错 误 ， 允 许 他 们 继 续 革 命 。 ” — — 毛 泽 东</color>";
				}
				else if (number == 6)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[444] == 0)
					{
						fake_text = "无 产 阶 级 专 政 发 端 自 我 国 在 文 化 大 革 命 时 期 形 成 的 独 特 政 治 生 态 ， 并 彻 底 实 现 了 劳 动 人 民 直 接 参 加 国 家 管 理 的 创 举 ： 它 在 管 理 上 议 行 合 一 ， 决 策 上 民 主 集 中 ， 思 想 上 团 结 一 致 ， 并 充 分 贯 彻 委 员 制 与 平 等 主 义 原 则 。 我 们 将 在 共 产 党 内 革 命 派 领 导 的 基 础 上 以 类 苏 维 埃 组 织 “ 革 命 委 员 会 ” 的 形 式 充 分 发 挥 群 众 的 革 命 斗 志 、 首 倡 精 神 和 创 造 能 力 。";
					}
					else
					{
						fake_text = "毛 主 义 语 境 下 的 无 产 阶 级 专 政 代 表 了 我 国 在 文 化 大 革 命 时 期 形 成 的 独 特 政 治 生 态 ： 即 在 管 理 上 议 行 合 一 ， 决 策 上 民 主 集 中 ， 思 想 上 团 结 一 致 ， 并 在 确 保 我 国 坚 定 社 会 主 义 路 线 的 基 础 上 以 三 结 合 形 式 将 党 的 领 导 落 入 实 践 中 。";
					}
				}
				else if (number == 7)
				{
					fake_text = "即 包 括 “ 过 渡 时 期 总 路 线 ” 在 内 的 建 国 七 年 初 形 成 的 制 度 框 架 ， 其 核 心 要 义 体 现 在 《1954 年 版 宪 法 》 内 的 部 分 条 款 与 各 项 基 本 制 度 ： 即 强 势 的 国 家 主 席 与 行 政 部 门 ， 多 阶 级 联 合 专 政 的 国 体 ， 协 调 各 方 利 益 的 社 会 政 策 ， 以 及 通 过 法 律 形 式 确 立 的 一 党 领 导 制 。";
				}
				else if (number == 8)
				{
					fake_text = "源 自30 年 代 的 人 民 阵 线 理 论 ， 二 战 后 曾 在 东 欧 地 区 短 暂 实 行 。 主 张 在 多 党 制 框 架 下 组 建 民 主 派 联 盟 或 反 法 西 斯 阵 线 式 的 联 合 政 府 形 式 团 结 社 会 各 阶 级 ， 并 通 过 操 纵 部 分 关 键 部 门 争 取 实 现 社 会 主 义 者 独 大 的 政 治 格 局 。";
				}
				else if (number == 9)
				{
					fake_text = "<color=red>“ 党 内 党 外 都 要 分 清 是 非 。 如 何 对 待 犯 了 错 误 的 人 ， 这 是 一 个 重 要 的 问 题 。 正 确 的 态 度 应 当 是 ， 对 于 犯 错 误 的 同 志 ， 采 取 ‘ 惩 前 毖 后 ， 治 病 救 人 ’ 的 方 针 ， 帮 助 他 们 改 正 错 误 ， 允 许 他 们 继 续 革 命 。 ” — — 毛 泽 东</color>";
				}
				else if (number == 16)
				{
					fake_text = "不 许 反 革 命 分 子 发 表 反 革 命 意 见 ，我 们 的 制 度 就 是 不 许 一 切 反 革 命 分 子 有 言 论 自 由 ，而 只 许 人 民 内 部 有 这 种 自 由";
				}
				else if (number == 17)
				{
					fake_text = "社 会 主 义 的 纪 律 约 束 下 ，人 民 享 受 着 广 泛 的 民 主 和 自 由 ，让 人 讲 话 ，天 不 会 塌 下 来 ，自 己 也 不 会 垮 台";
				}
				else if (number == 18)
				{
					fake_text = "凡 是 违 反 人 道 主 义 ，背 叛 社 会 福 利 ，违 背 国 家 民 族 利 益 的 言 论 ，不 会 包 含 真 理  ，不 会 劲 得 试 验 ，不 会 被 人 赞 同 ，不 会 言 之 无 愧 ，这 都 是 言 论 自 由 自 规 的 范 围";
				}
				else if (number == 19)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[444] == 0)
					{
						fake_text = "根 据 马 克 思 主 义 哲 学 的 观 点 ， 自 由 境 界 代 表 了 人 类 将 自 身 发 展 作 为 目 的 ， 并 充 分 掌 握 社 会 历 史 规 律 ， 积 极 行 使 自 由 权 利 的 发 展 阶 段 。 经 过 了 社 会 革 命 的 锻 炼 ： 我 们 得 以 告 别 庸 俗 的 公 民 自 由 与 宪 政 自 由 框 架 ， 并 在 彻 底 砸 碎 公 检 法 的 同 时 将 革 命 意 识 形 态 上 升 到 道 德 自 觉 ， 形 成 了 适 配 新 时 代 的 生 活 方 式 。";
					}
					else
					{
						fake_text = "<color=red>“ 自 由 是 有 领 导 的 自 由 ， 民 主 是 集 中 指 导 下 的 民 主 ， 不 是 无 政 府 状 态 。 无 政 府 状 态 不 符 合 人 民 的 利 益 和 愿 望 。 ” — — 毛 泽 东</color>";
					}
				}
				else if (number == 20)
				{
					fake_text = "中 华 人 民 共 和 国 是 全 国 各 族 人 民 共 同 缔 造 的 统 一 的 多 民 族 国 家 ，在 统 一 的 国 家 内 实 行 民 族 区 域 自 治 ，更 有 利 于 民 族 平 等 原 则 的 实 现";
				}
				else if (number == 21)
				{
					if (GlobalScript.inst.gameState.event_done[550] && GlobalScript.inst.gameState.resultOfEvents[550] == 2)
					{
						fake_text = "综 合 考 虑 中 国 基 本 国 情 、 政 治 传 统 与 社 会 舆 论 影 响 ， 并 兼 采 区 域 自 治 与 联 邦 之 长 ， 在 民 主 集 中 制 原 则 上 所 建 立 的 极 具 灵 活 性 的 动 态 联 邦 制 。";
					}
					else if (GlobalScript.inst.gameState.event_done[550] && GlobalScript.inst.gameState.resultOfEvents[550] == 0)
					{
						fake_text = "我 国 联 邦 构 建 基 于 央 地 平 等 原 则 ， 并 在 中 央 与 地 方 机 构 间 建 立 了 明 确 的 职 权 边 界 与 分 工 体 系 。 由 此 可 在 促 使 各 地 充 分 自 治 ， 展 现 主 观 能 动 性 的 同 时 发 挥 中 央 协 调 各 方 ， 统 筹 诸 多 利 益 的 中 枢 作 用 ， 并 培 育 适 应 现 代 生 活 ， 积 极 承 担 义 务 的 新 公 民 。";
					}
					else if (GlobalScript.inst.gameState.event_done[550] && GlobalScript.inst.gameState.resultOfEvents[550] == 1)
					{
						fake_text = "我 国 联 邦 构 建 基 于 民 族 自 决 原 则 ， 并 以 各 地 民 族 权 力 机 构 的 设 置 为 参 照 重 新 设 计 了 国 家 机 构 。 通 过 配 额 制 度 、 民 族 代 表 与 建 构 社 会 主 义 爱 国 精 神 。 我 们 得 以 在 促 进 经 济 社 会 平 等 的 同 时 构 建 统 一 的 中 华 劳 动 民 族 群 体 ， 由 此 将 各 族 人 民 团 结 一 致 。";
					}
					else
					{
						fake_text = "如 果 我 们 想 要 贯 彻 马 克 思 列 宁 主 义 的 民 族 政 策 ， 那 就 必 须 在 充 分 了 解 地 方 情 况 的 基 础 上 统 筹 兼 顾 ， 建 立 民 族 权 力 机 构 与 下 放 文 化 自 治 权 将 是 落 实 民 族 自 决 权 的 关 键 一 招 。";
					}
				}
				else if (number == 22)
				{
					fake_text = "<color=red>“ 社 会 科 学 ， 马 克 思 列 宁 主 义 ， 斯 大 林 讲 得 对 的 那 些 方 面 ， 我 们 一 定 要 继 续 努 力 学 习 。 我 们 要 学 的 是 属 于 普 遍 真 理 的 东 西 ， 并 且 学 习 一 定 要 与 中 国 实 际 相 结 合 。 如 果 每 句 话 ， 包 括 马 克 思 的 话 ， 都 要 照 搬 ， 那 就 不 得 了 。 我 们 的 理 论 ， 是 马 克 思 列 宁 主 义 的 普 遍 真 理 同 中 国 革 命 的 具 体 实 践 相 结 合 。 ” — — 毛 泽 东</color>";
				}
				else if (number == 23)
				{
					fake_text = "<color=red>“ 党 内 党 外 都 要 分 清 是 非 。 如 何 对 待 犯 了 错 误 的 人 ， 这 是 一 个 重 要 的 问 题 。 正 确 的 态 度 应 当 是 ， 对 于 犯 错 误 的 同 志 ， 采 取 ‘ 惩 前 毖 后 ， 治 病 救 人 ’ 的 方 针 ， 帮 助 他 们 改 正 错 误 ， 允 许 他 们 继 续 革 命 。 ” — — 毛 泽 东</color>";
				}
				else if (number == 24)
				{
					if (GlobalScript.inst.gameState.resultOfEvents[444] == 0)
					{
						fake_text = "思 想 解 放 议 程 正 借 着 经 济 社 会 领 域 的 革 命 势 头 茁 壮 成 长 ， 并 在 劳 动 集 体 的 发 展 中 持 续 高 歌 猛 进 ： 工 厂 与 公 社 本 身 成 为 了 综 合 劳 动 与 知 识 的 学 校 ， 将 奉 行 内 部 精 英 主 义 的 旧 道 德 、 旧 思 想 与 旧 文 化 机 构 一 扫 而 空 ， 并 以 大 众 文 化 的 崛 起 空 前 丰 富 了 文 化 表 达 内 容 与 形 式 。 民 主 与 科 学 的 旗 帜 就 此 在 中 国 取 得 完 胜 。";
					}
					else
					{
						fake_text = "中 国 文 化 革 命 的 历 史 可 追 溯 至20 世 纪 初 的 激 进 民 主 运 动 ， 并 在 毛 泽 东 时 代 内 得 以 发 扬 光 大 ： 旧 道 德 ， 旧 风 俗 与 旧 文 化 皆 在 社 会 革 命 内 一 扫 而 空 ， 并 被 主 人 翁 意 识 与 社 会 契 约 取 而 代 之 。                        “ 你 们 可 以 改 了 ， 从 真 心 改 起 ！ 要 晓 得 将 来 容 不 得 吃 人 的 人 ， 活 在 世 上 。 ” — — 《 狂 人 日 记 》";
					}
				}
				else if (number == 25)
				{
					fake_text = "历 史 已 充 分 证 明 了 “ 人 民 鸦 片 ” 对 社 会 的 危 害 ！ 我 们 将 以 苏 联 组 织 战 斗 无 神 论 者 联 盟 的 经 验 全 面 开 战 ， 在 国 内 彻 底 扫 除 教 会 、 祠 堂 与 各 路 反 动 窝 点 。 确 立 科 学 精 神 在 国 内 的 主 导 地 位 ！";
				}
				else if (number == 26)
				{
					fake_text = "公 民 拥 有 宗 教 信 仰 自 由 ，但 国 家 也 依 法 管 理 宗 教 事 务 ，坚 持 独 立 自 主 自 办 原 则 ，积 极 引 导 宗 教 与 社 会 主 义 社 会 相 适 应";
				}
				else if (number == 27)
				{
					fake_text = "我 们 要 求 教 会 与 国 家 完 全 分 离 ，国 家 不 应 当 同 宗 教 发 生 关 系 ，宗 教 团 体 不 应 当 同 国 家 政 权 发 生 联 系 ，宗 教 不 得 干 预 行 政 、司 法 、教 育 等 国 家 职 能 实 施";
				}
				else if (number == 28)
				{
					fake_text = "<color=red>“ 党 内 党 外 都 要 分 清 是 非 。 如 何 对 待 犯 了 错 误 的 人 ， 这 是 一 个 重 要 的 问 题 。 正 确 的 态 度 应 当 是 ， 对 于 犯 错 误 的 同 志 ， 采 取 ‘ 惩 前 毖 后 ， 治 病 救 人 ’ 的 方 针 ， 帮 助 他 们 改 正 错 误 ， 允 许 他 们 继 续 革 命 。 ” — — 毛 泽 东</color>";
				}
				else if (number == 29)
				{
					fake_text = "<color=red>“ 党 内 党 外 都 要 分 清 是 非 。 如 何 对 待 犯 了 错 误 的 人 ， 这 是 一 个 重 要 的 问 题 。 正 确 的 态 度 应 当 是 ， 对 于 犯 错 误 的 同 志 ， 采 取 ‘ 惩 前 毖 后 ， 治 病 救 人 ’ 的 方 针 ， 帮 助 他 们 改 正 错 误 ， 允 许 他 们 继 续 革 命 。 ” — — 毛 泽 东</color>";
				}
				else if (number == 30)
				{
					fake_text = "武 装 的 人 民 群 众 是 陷 敌 于 灭 顶 之 灾 的 汪 洋 大 海 ！ 革 命 战 争 是 群 众 的 战 争 ，只 有 动 员 群 众 才 能 进 行 战 争 ，只 有 依 靠 群 众 才 能 进 行 战 争 ！";
				}
				else if (number == 31)
				{
					fake_text = "我 们 的 军 队 现 代 化 水 平 与 国 家 安 全 需 求 相 比 差 距 还 很 大 ，与 世 界 先 进 军 事 水 平 相 比 差 距 还 很 大 ，要 加 快 把 人 民 军 队 建 设 成 为 世 界 一 流 军 队 ！";
				}
				else if (number == 32)
				{
					fake_text = "我 们 爱 好 和 平 ，但 以 斗 争 求 和 平 则 和 平 存 ，以 妥 协 求 和 平 则 和 平 亡 。 我 们 的 国 防 将 获 得 巩 固 ，不 允 许 任 何 帝 国 主 义 者 再 来 侵 略 我 们 的 国 土";
				}
				else if (number == 33)
				{
					fake_text = "全 世 界 军 队 都 开 始 玩 职 业 化 改 革 ，我 们 也 得 跟 上 潮 流 — — 短 小 精 悍 才 是 劲 旅";
				}
			}
			else if (number == 10)
			{
				if (!GlobalScript.inst.gameState.modifies[11].active)
				{
					fake_text = "以 苏 联 经 济 制 度 为 蓝 本 形 成 的 发 展 模 式 ： 其 主 要 特 征 是 强 行 政 命 令 ， 单 一 所 有 制 ， 限 制 商 品 流 通 范 畴 ， 并 通 过 扩 大 经 济 核 算 制 度 模 拟 市 场 环 境 下 的 效 益 计 算 。 国 家 以 五 年 计 划 形 式 统 筹 国 民 经 济 ， 从 而 实 现 各 产 业 持 续 发 展 。";
				}
				else
				{
					fake_text = "在 中 央 计 划 经 济 的 基 础 上 引 入 计 算 机 ， 建 立 数 据 库 并 启 用 自 动 收 集 与 处 理 经 济 信 息 的 自 动 化 系 统 ， 将 决 策 方 案 交 由 计 算 机 运 算 得 出 。 这 将 迅 速 提 高 经 济 决 策 效 率 与 经 济 生 活 的 透 明 度";
				}
			}
			else if (number == 11)
			{
				if (!GlobalScript.inst.gameState.modifies[11].active)
				{
					fake_text = "依 托 中 国 国 情 生 成 的 计 划 经 济 变 种 ， 由 于 缺 乏 算 力 与 相 应 的 行 政 官 僚 ， 导 致 其 经 济 管 理 不 得 不 在 试 图 维 持 计 划 经 济 基 本 原 则 的 基 础 上 诉 诸 灵 活 性 ， 发 展 区 域 经 济 与 村 镇 企 业 。 其 注 重 协 商 ， 充 分 发 挥 多 方 主 动 性 的 框 架 有 助 于 为 日 后 的 经 济 改 革 奠 定 基 础 。";
				}
				else
				{
					fake_text = "在 分 权 计 划 经 济 的 基 础 上 引 入 计 算 机 ， 通 过 高 效 、 迅 速 、 精 确 的 数 字 工 作 组 织 起 不 间 断 的 供 应 — 生 产 — 商 品 网 络 ， 极 大 的 改 善 企 业 、 商 店 、 仓 库 和 交 通 之 间 的 协 调 运 转 ， 以 实 现 经 济 繁 荣";
				}
			}
			else if (number == 12)
			{
				fake_text = "该 经 济 体 制 充 分 利 用 市 场 关 系 与 商 品 货 币 机 制 ， 在 确 保 国 家 掌 握 经 济 制 高 点 的 同 时 积 极 运 用 经 济 核 算 机 制 ， 促 进 企 业 增 产 增 效 。 与 此 同 时 ， 我 们 将 在 无 足 轻 重 的 领 域 内 放 开 多 种 经 营 形 式 ， 进 一 步 巩 固 现 有 经 济 制 度 。";
			}
			else if (number == 13)
			{
				fake_text = "中 国 经 济 学 家 陈 云 的 创 举 。 主 张 在 在 保 留 严 格 政 府 监 管 ， 确 保 国 家 经 营 国 计 民 生 的 同 时 ， 兼 采 市 场 经 济 与 私 营 部 门 的 优 点 。 就 此 形 成 广 泛 而 深 刻 的 国 家 行 政 命 令 与 宏 观 调 控 政 策 下 主 导 的 转 型 经 济 与 管 制 市 场 模 式 。";
			}
			else if (number == 14)
			{
				fake_text = "基 于 市 场 反 应 社 会 需 求 的 原 则 安 排 国 民 经 济 发 展 方 略 ， 确 保 多 种 所 有 制 经 济 充 分 发 展 ， 并 依 法 平 等 参 与 竞 争 。 国 家 则 转 向 协 调 公 共 利 益 并 制 定 宏 观 经 济 政 策 ， 通 过 财 政 与 货 币 政 策 规 范 与 引 导 经 济 活 动 。 由 此 形 成 服 务 型 国 家 与 充 分 自 由 的 市 场 经 济 框 架 。";
			}
			else if (number == 15)
			{
				fake_text = "以 现 代 美 国 与 自 由 主 义 经 济 政 策 为 蓝 本 的 经 济 制 度 ， 充 分 发 挥 市 场 对 资 源 配 置 的 决 定 性 作 用 ： 国 家 将 在 让 渡 公 共 设 施 ， 形 成 社 会 共 治 体 系 的 同 时 ； 对 包 括 中 央 银 行 在 内 的 金 融 部 门 实 现 私 有 化 。 最 终 建 立 起 适 配 宪 政 制 度 与 自 然 秩 序 的 经 济 体 系 ： 国 家 依 法 履 职 ， 企 业 依 法 组 织 ， 两 者 相 安 无 事 。";
			}
			else if (number == 6)
			{
				fake_text = "顾 名 思 义 ， 即 由 单 一 执 政 党 垄 断 国 家 大 权 的 权 力 分 配 形 式 。 执 政 党 不 仅 控 制 了 国 内 的 主 要 政 治 部 门 ， 同 时 还 以 法 律 形 式 确 立 了 自 身 的 唯 一 核 心 地 位 。 这 意 味 着 该 国 政 治 生 活 与 发 展 方 向 将 完 全 仰 赖 于 该 党 的 组 织 方 式 与 总 路 线 。";
			}
			else if (number == 7)
			{
				fake_text = "类 似 新 加 坡 与 墨 西 哥 式 的 控 制 民 主 共 和 国 ， 在 基 本 采 纳 现 代 代 议 制 框 架 的 同 时 构 建 排 斥 竞 争 与 极 具 家 长 制 色 彩 的 体 系 ， 由 此 形 成 部 分 政 治 集 团 的 优 势 与 特 权 地 位 ， 为 一 党 独 大 的 霸 权 铺 平 道 路 ， 可 被 冠 以 “ 最 民 主 的 独 裁 ” 之 名 。";
			}
			else if (number == 8)
			{
				fake_text = "美 国 建 国 先 贤 的 政 治 理 想 ， 如 今 常 以 “ 防 御 性 民 主 ” 的 形 式 登 场 ： 即 在 引 入 多 党 制 、 自 由 化 与 竞 争 选 举 的 同 时 收 拢 法 律 控 制 并 规 范 政 治 参 与 ， 由 此 将 危 害 国 家 长 远 发 展 的 极 端 主 义 与 民 粹 主 义 势 力 剔 除 出 政 治 议 程 。";
			}
			else if (number == 9)
			{
				fake_text = "现 代 多 党 制 模 式 的 变 种 ， 相 较 于 传 统 框 架 更 强 调 贯 彻 多 元 主 义 价 值 观 。 因 此 ， 它 将 在 完 全 放 开 政 治 结 社 的 同 时 进 一 步 拓 宽 政 治 参 与 渠 道 ， 并 通 过 比 例 代 表 与 配 额 制 度 确 保 国 家 收 到 社 会 各 界 的 声 音 。";
			}
			else if (number == 16)
			{
				fake_text = "“ 谁 准 他 们 写 这 些 狗 屁 文 章 了 ？ 他 们 都 得 滚 去 伐 木 营 ： 把 国 家 在 他 们 身 上 浪 费 的 税 金 得 给 我 吐 出 来 。 ” — — 尼 基 塔 · 谢 尔 盖 耶 维 奇 · 赫 鲁 晓 夫";
			}
			else if (number == 17)
			{
				fake_text = "众 所 周 知 ， 权 利 与 义 务 从 来 对 等 。 民 主 自 由 自 然 以 不 侵 犯 他 人 的 自 由 为 前 提 ： 因 此 ， 让 人 讲 话 天 塌 不 下 来 的 潜 台 词 无 非 是 “ 天 不 会 塌 下 来 ” 。 审 查 制 度 与 宣 传 鼓 动 政 策 的 美 妙 之 处 便 在 于 此 。";
			}
			else if (number == 18)
			{
				fake_text = "凡 是 违 反 人 道 主 义 ，背 叛 社 会 福 利 ，违 背 国 家 民 族 利 益 的 言 论 ，不 会 包 含 真 理  ，不 会 劲 得 试 验 ，不 会 被 人 赞 同 ，不 会 言 之 无 愧 ，这 都 是 言 论 自 由 自 规 的 范 围";
			}
			else if (number == 19)
			{
				fake_text = "人 类 各 有 各 的 思 想 ，在 生 活 的 意 识 上 便 各 有 各 的 自 由 ，把 我 们 的 思 想 从 教 条 主 义 的 思 维 方 式 中 解 放 出 来 ，建 立 绝 对 自 由，绝 对 公 开 ，绝 对 多 元";
			}
			else if (number == 20)
			{
				fake_text = "中 华 人 民 共 和 国 是 全 国 各 族 人 民 共 同 缔 造 的 统 一 的 多 民 族 国 家 ，在 统 一 的 国 家 内 实 行 民 族 区 域 自 治 ，更 有 利 于 民 族 平 等 原 则 的 实 现";
			}
			else if (number == 21)
			{
				if (GlobalScript.inst.gameState.event_done[550] && GlobalScript.inst.gameState.resultOfEvents[550] == 2)
				{
					fake_text = "综 合 考 虑 中 国 基 本 国 情 、 政 治 传 统 与 社 会 舆 论 影 响 ， 并 兼 采 区 域 自 治 与 联 邦 之 长 ， 在 民 主 集 中 制 原 则 上 所 建 立 的 极 具 灵 活 性 的 动 态 联 邦 制 。";
				}
				else if (GlobalScript.inst.gameState.event_done[550] && GlobalScript.inst.gameState.resultOfEvents[550] == 0)
				{
					fake_text = "我 国 联 邦 构 建 基 于 央 地 平 等 原 则 ， 并 在 中 央 与 地 方 机 构 间 建 立 了 明 确 的 职 权 边 界 与 分 工 体 系 。 由 此 可 在 促 使 各 地 充 分 自 治 ， 展 现 主 观 能 动 性 的 同 时 发 挥 中 央 协 调 各 方 ， 统 筹 诸 多 利 益 的 中 枢 作 用 ， 并 培 育 适 应 现 代 生 活 ， 积 极 承 担 义 务 的 新 公 民 。";
				}
				else if (GlobalScript.inst.gameState.event_done[550] && GlobalScript.inst.gameState.resultOfEvents[550] == 1)
				{
					fake_text = "我 国 联 邦 构 建 基 于 民 族 自 决 原 则 ， 并 以 各 地 民 族 权 力 机 构 的 设 置 为 参 照 重 新 设 计 了 国 家 机 构 。 通 过 配 额 制 度 、 民 族 代 表 与 建 构 社 会 主 义 爱 国 精 神 。 我 们 得 以 在 促 进 经 济 社 会 平 等 的 同 时 构 建 统 一 的 中 华 劳 动 民 族 群 体 ， 由 此 将 各 族 人 民 团 结 一 致 。";
				}
				else
				{
					fake_text = "如 果 我 们 想 要 贯 彻 马 克 思 列 宁 主 义 的 民 族 政 策 ， 那 就 必 须 在 充 分 了 解 地 方 情 况 的 基 础 上 统 筹 兼 顾 ， 建 立 民 族 权 力 机 构 与 下 放 文 化 自 治 权 将 是 落 实 民 族 自 决 权 的 关 键 一 招 。";
				}
			}
			else if (number == 22)
			{
				fake_text = "中 国 不 适 宜 于 单 一 的 国 家 组 织 ，自 清 之 亡 ，无 一 省 不 曾 宣 告 过 独 立 ，省 之 组 织 ，情 状 贫 富 不 同 ，地 势 及 人 才 互 异 ，若 强 为 一 律 ，详 细 规 定 ，事 实 不 能 ，宜 予 以 多 少 之 权 ，自 定 制 度 ，由 邦 而 必 使 成 国";
			}
			else if (number == 23)
			{
				fake_text = "为 了 应 对 复 杂 安 全 威 胁 ，赢 得 国 家 战 略 优 势 ，我 们 迫 切 需 要 将 中 华 民 族 统 合 为 一 个 能 够 确 保 外 部 地 区 安 全 ，内 部 经 济 繁 荣 ，民 族 发 展 自 由 的 政 治 、 经 济 、 军 事 联 盟 共 同 体";
			}
			else if (number == 24)
			{
				fake_text = "落 后 就 要 挨 打 ！ 如 果 还 想 将 这 个 国 家 重 新 整 顿 起 来 ， 就 必 须 竭 尽 所 能 赶 上 科 学 精 神 的 末 班 车 ！ 我 们 将 竭 尽 所 能 扫 除 堆 积 五 千 年 之 久 的 垃 圾 堆 ！               “ 欲 使 中 国 不 亡 ， 欲 使 中 国 民 族 为 二 十 世 纪 文 明 之 民 族 ， 必 以 废 孔 学 、 灭 道 教 为 根 本 之 解 决 ， 而 废 记 载 孔 门 学 说 及 道 教 妖 言 之 汉 文 ， 尤 为 根 本 解 决 之 根 本 。 ” — — 钱 玄 同";
			}
			else if (number == 25)
			{
				fake_text = "“ 蒙 昧 中 世 纪 ” 的 概 念 早 已 被 摒 弃 。 即 便 是 曾 奉 行 政 教 结 合 的 西 方 国 家 ， 牧 师 与 教 会 的 时 代 也 已 成 为 了 历 史 。 那 么 ， 我 们 为 什 么 要 让 这 些 家 伙 在 中 国 获 得 一 席 之 地 呢 ？ 更 何 况 ， 宗 教 在 古 代 便 常 作 为 民 变 的 同 义 词 — — 没 必 要 让 潜 在 对 手 掌 握 如 此 危 险 的 武 器 。";
			}
			else if (number == 26)
			{
				fake_text = "公 民 拥 有 宗 教 信 仰 自 由 ，但 国 家 也 依 法 管 理 宗 教 事 务 ，坚 持 独 立 自 主 自 办 原 则 ，积 极 引 导 宗 教 与 社 会 主 义 社 会 相 适 应";
			}
			else if (number == 27)
			{
				fake_text = "我 们 要 求 教 会 与 国 家 完 全 分 离 ，国 家 不 应 当 同 宗 教 发 生 关 系 ，宗 教 团 体 不 应 当 同 国 家 政 权 发 生 联 系 ，宗 教 不 得 干 预 行 政 、司 法 、教 育 等 国 家 职 能 实 施";
			}
			else if (number == 28)
			{
				fake_text = "你 还 能 有 老 祖 宗 聪 明 ？ 我 们 作 为 民 族 一 切 文 化 、思 想 、道 德 的 最 优 秀 传 统 的 继 承 者 ，要 把 这 一 切 优 秀 传 统 看 成 和 自 己 血 肉 相 连 的 东 西 ，而 且 将 继 续 加 以 发 扬 光 大 ！";
			}
			else if (number == 29)
			{
				fake_text = "宗 教 领 袖 能 够 号 召 信 众 支 持 政 权 ，国 家 律 令 可 以 规 训 社 会 礼 敬 信 仰 ，双 方 完 全 没 有 必 要 分 庭 抗 礼 ，为 了 共 同 利 益 ，让 我 们 化 解 矛 盾 ，构 建 和 谐 政 教 关 系";
			}
			else if (number == 30)
			{
				fake_text = "武 装 的 人 民 群 众 是 陷 敌 于 灭 顶 之 灾 的 汪 洋 大 海 ！ 革 命 战 争 是 群 众 的 战 争 ，只 有 动 员 群 众 才 能 进 行 战 争 ，只 有 依 靠 群 众 才 能 进 行 战 争 ！";
			}
			else if (number == 31)
			{
				fake_text = "我 们 的 军 队 现 代 化 水 平 与 国 家 安 全 需 求 相 比 差 距 还 很 大 ，与 世 界 先 进 军 事 水 平 相 比 差 距 还 很 大 ，要 加 快 把 人 民 军 队 建 设 成 为 世 界 一 流 军 队 ！";
			}
			else if (number == 32)
			{
				fake_text = "我 们 爱 好 和 平 ，但 以 斗 争 求 和 平 则 和 平 存 ，以 妥 协 求 和 平 则 和 平 亡 。 我 们 的 国 防 将 获 得 巩 固 ，不 允 许 任 何 帝 国 主 义 者 再 来 侵 略 我 们 的 国 土";
			}
			else if (number == 33)
			{
				fake_text = "全 世 界 军 队 都 开 始 玩 职 业 化 改 革 ，我 们 也 得 跟 上 潮 流 — — 短 小 精 悍 才 是 劲 旅";
			}
		}
		else if (number == 10)
		{
			fake_text = "Как в Советском Союзе. Государство полностью контролирует экономику, которая работает согласно 5-ти летнему плану.";
		}
		else if (number == 11)
		{
			fake_text = "Внедрение ЭВМ и передача им управления... Перспективная, но очень рискованная идея, которая укрепит экономику, но лишит вас поддержки бюрократии.";
		}
		else if (number == 12)
		{
			fake_text = "Разрешение самоуправления предприятий и поддержка частной инициативы не повредят социализму - ведь государство остается единственной монополией.";
		}
		else if (number == 13)
		{
			fake_text = "Птица рынка должна расти в социалистической клетке государства!";
		}
		else if (number == 14)
		{
			fake_text = "Ничего страшного не будет, если передать частным лицам часть экономики. Основные активы останутся у государства.";
		}
		else if (number == 15)
		{
			fake_text = "Мы признаём неэффективность административно-командной системы и передаём управление экономикой в руки хозяина-частника. Рынок отрегулирует!";
		}
		else if (number == 6)
		{
			fake_text = "Только освободившая народ от феодализма Коммунистическая партия имеет право на существование!";
		}
		else if (number == 7)
		{
			fake_text = "Наша партия - руководящая сила общества, авангард прогресса и процветания.";
		}
		else if (number == 8)
		{
			fake_text = "Дозволяется существование других партий. Однако их создание и финансирование жёстко регулируется.";
		}
		else if (number == 9)
		{
			fake_text = "Всё как на Западе - все партии равны и должны бороться за голоса друг с другом.";
		}
		else if (number == 16)
		{
			fake_text = "Решительно пресекать любую точку зрения, несовпадающую с линией Партии!";
		}
		else if (number == 17)
		{
			fake_text = "Мы будем соблюдать общепризнанные права и свободы, защищая наши идеалы и ценности любыми доступными методами.";
		}
		else if (number == 18)
		{
			fake_text = "Право на существование имеет всякая точка зрения, если она не нарушает закон.";
		}
		else if (number == 19)
		{
			fake_text = "Абсолютная свобода, гласность и плюрализм, наконец-то, восторжествовали! Китай отныне свободен от догм!";
		}
		else if (number == 20)
		{
			fake_text = "Вся территория Китая едина и неделима. Народности имеют право лишь на культурную автономию.";
		}
		else if (number == 21)
		{
			fake_text = "Китай - федерация провинций и автономий. Они имеют равные права и собственные органы управления, выше которых только общекитайские.";
		}
		else if (number == 22)
		{
			fake_text = "Учтя свои ошибки, мы найдём новую форму объединения всех национальных образований. Конфедерация равноправных субъектов - самое простое решение";
		}
		else if (number == 23)
		{
			fake_text = "Военно-политический и экономический союз нескольких государств под руководством надгосударственных органов.";
		}
		else if (number == 24)
		{
			fake_text = "Критикуйте Конфуция и Линь Бяо! Так завещал сам Председатель Мао!";
		}
		else if (number == 25)
		{
			fake_text = "Религия - опиум для народа!";
		}
		else if (number == 26)
		{
			fake_text = "Люди вольны верить. Однако государство проконтролирует, чтобы религия не использовалась против него.";
		}
		else if (number == 27)
		{
			fake_text = "Мы вовсе не против религии. Однако Церковь у нас отделена от государства, а государство не вмешивается в дела Церкви.";
		}
		else if (number == 28)
		{
			fake_text = "Китай - великая страна с древней историей. Уважая наше прошлое и опираясь на него, мы строим наше будущее!";
		}
		else if (number == 29)
		{
			fake_text = "Церковь и государство - не антагонисты. У них общая цель, а общность цели вызывает и общность интересов...";
		}
		else if (number == 30)
		{
			fake_text = "Каждый китаец - солдат! В случае войны, весь народ поднимется на защиту Родины!";
		}
		else if (number == 31)
		{
			fake_text = "Наша армия все ещё недостаточно сильная для такой большой страны. Надо усилить её как можно быстрее!";
		}
		else if (number == 32)
		{
			fake_text = "Мы войны не хотим, но себя защитим. Поэтому необходимо поддерживать достаточную для обороны территории Китая армию.";
		}
		else if (number == 33)
		{
			fake_text = "Весь мир начинает переход на профессиональную армию. Мы не должны отставать - пусть наша армия будет небольшая, но очень сильная.";
		}
		opisannya.text = Text(fake_text, 45);
	}

	private void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = off;
		for (int i = 0; i < 4; i++)
		{
			uslovie[i].GetComponent<TextMesh>().text = null;
			uslovie[i].transform.Find("If").GetComponent<SpriteRenderer>().sprite = null;
			uslovie[i].transform.Find("If (1)").GetComponent<SpriteRenderer>().sprite = null;
		}
		opisannya.text = "";
	}

	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		for (int i = 0; i < text.Length; i++)
		{
			if (num >= col)
			{
				if (text[i] == char.Parse(" "))
				{
					num = 0;
					text2 += "\n";
					continue;
				}
				text2 += text[i];
				for (int num2 = i; num2 >= 0; num2--)
				{
					if (text2[num2] == char.Parse(" "))
					{
						text2 = text2.Substring(0, num2) + "\n" + text2.Substring(num2 + 1, text2.Length - 1 - (num2 + 1) + 1);
						num = text2.Length - 1 - (num2 + 1) + 1;
						break;
					}
				}
			}
			else
			{
				text2 += text[i];
				num++;
			}
		}
		return text2;
	}
}
