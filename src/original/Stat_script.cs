using UnityEngine;

public class Stat_script : MonoBehaviour
{
	public TextMesh[] Name = new TextMesh[12];

	private GlobalScript global1;

	private void Awake()
	{
		global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (PlayerPrefs.GetInt("language") == 0)
		{
			GetComponent<TextMesh>().text = " 报 表 （ 相 对 于 1985 年 的 % ）\n（ 现 实 数 据 ）";
			Name[1].text = " 报 表 （ 相 对 于 1985 年 % ）\n（ 玩 家 数 据 ）";
			Name[2].text = " 日 期\n89年 1月 \n89年 2月 \n89年 3月 \n89年 4月 \n89年 5月 \n89年 6月 \n89年 7月 \n89年 8月 \n89年 9月 \n89年 10月 \n89年 11月 \n89年 12月 \n";
			Name[2].text += "90年 1月 \n90年 2月 \n90年 3月 \n90年 4月 \n90年 5月 \n90年 6月 \n90年 7月 \n90年 8月 \n90年 9月 \n90年 10月 \n90年 11月 \n90年 12月 \n";
			Name[2].text += "91年 1月 \n91年 2月 \n91年 3月 \n91年 4月 \n91年 5月 \n91年 6月 \n91年 7月 \n91年 8月 \n91年 9月 \n91年 10月 \n91年 11月 \n91年 12月";
			Name[3].text = " 国 内 生 产 总 值";
			Name[4].text = " 人 类 发 展 指 数";
			Name[5].text = " 货 贸\n 赤 字";
			Name[6].text = " 经 济\n 增 长";
			Name[3].text += PlayerPrefs.GetString("VVP");
			Name[4].text += PlayerPrefs.GetString("IRCHP");
			Name[5].text += PlayerPrefs.GetString("SALARY");
			Name[6].text += PlayerPrefs.GetString("ROST");
			Name[7].text = " 日 期\n89年 1月 \n89年 2月 \n89年 3月 \n89年 4月 \n89年 5月 \n89年 6月 \n89年 7月 \n89年 8月 \n89年 9月 \n89年 10月 \n89年 11月 \n89年 12月\n";
			Name[7].text += "90年 1月 \n90年 2月 \n90年 3月 \n90年 4月 \n90年 5月 \n90年 6月 \n90年 7月 \n90年 8月 \n90年 9月 \n90年 10月 \n90年 11月 \n90年 12月\n";
			Name[7].text += "91年 1月 \n91年 2月 \n91年 3月 \n91年 4月 \n91年 5月 \n91年 6月 \n91年 7月 \n91年 8月 \n91年 9月 \n91年 10月 \n91年 11月 \n91年 12月";
			Name[8].text = " 国 内 生 产 总 值";
			Name[9].text = " 人 类 发 展 指 数";
			Name[10].text = " 货 贸\n 赤 字";
			Name[11].text = " 经 济\n 增 长";
		}
		else
		{
			Name[3].text += PlayerPrefs.GetString("VVP");
			Name[4].text += PlayerPrefs.GetString("IRCHP");
			Name[5].text += PlayerPrefs.GetString("SALARY");
			Name[6].text += PlayerPrefs.GetString("ROST");
		}
		if (GlobalScript.inst.gameState.data[0] == 1)
		{
			Name[8].text += "\n148%\n148%\n148%\n148%\n140%\n140%\n140%\n145%\n145%\n144%\n135%\n130%\n";
			Name[9].text += "\n100%\n100%\n100%\n99%\n99%\n99%\n99%\n99%\n99%\n99%\n100%\n100%\n";
			Name[10].text += "\n-1%\n-1%\n-1%\n0%\n0%\n1%\n1%\n1%\n1%\n1%\n0%\n0%\n";
			Name[11].text += "\n2.49%\n2.49%\n2.49%\n2.47%\n2.38%\n2.38%\n2.38%\n2.43%\n2.43%\n2.4%\n2.35%\n2.3%\n";
			Name[8].text += "121%\n107%\n103%\n99%\n91%\n83%\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "101%\n101%\n103%\n105%\n108%\n110%\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "0\n0%\n0%\n-1%\n-1%\n-5%\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "2.19%\n2.08%\n2.02%\n1.96%\n1.9%\n1.88%\n-\n-\n-\n-\n-\n-\n";
			Name[8].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
		}
		else if (GlobalScript.inst.gameState.data[0] == 5)
		{
			Name[8].text += "\n101%\n100%\n99%\n138%\n130%\n129%\n128%\n127%\n126%\n119%\n112%\n91%\n";
			Name[9].text += "\n55%\n53%\n51%\n49%\n47%\n45%\n43%\n41%\n39%\n37%\n32%\n27%\n";
			Name[10].text += "\n4%\n4%\n4%\n4%\n5%\n5%\n5%\n5%\n5%\n6%\n6%\n10%\n";
			Name[11].text += "\n1.52%\n1.49%\n1.46%\n1.83%\n1.72%\n1.69%\n1.66%\n1.63%\n1.6%\n1.5%\n1.39%\n1.08%\n";
			Name[8].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[8].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
		}
		else if (GlobalScript.inst.gameState.data[0] == 2)
		{
			Name[8].text += "\n131%\n131%\n131%\n131%\n131%\n131%\n131%\n136%\n136%\n136%\n136%\n136%\n";
			Name[9].text += "\n86%\n86%\n85%\n84%\n83%\n82%\n81%\n53%\n53%\n53%\n53%\n52%\n";
			Name[10].text += "\n0%\n0%\n0%\n0%\n0%\n0%\n0%\n-1%\n-1%\n-1%\n-3%\n-3%\n";
			Name[11].text += "\n2.22%\n2.17%\n2.17%\n2.16%\n2.14%\n2.13%\n2.12%\n2.19%\n2.19%\n2.19%\n2.19%\n2.19%\n";
			Name[8].text += "136%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "52%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "-5%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "2.22%\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[8].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
		}
		else
		{
			Name[8].text += "\n150%\n150%\n150%\n150%\n146%\n146%\n146%\n146%\n141%\n139%\n127%\n142%\n";
			Name[9].text += "\n100%\n100%\n100%\n100%\n100%\n100%\n99%\n99%\n99%\n100%\n100%\n98%\n";
			Name[10].text += "\n-1%\n-1%\n-2%\n-2%\n-1%\n0%\n0%\n0%\n0%\n0%\n0%\n3%\n";
			Name[11].text += "\n2.5%\n2.5%\n2.52%\n2.52%\n2.47%\n2.45%\n2.45%\n2.45%\n2.45%\n2.41%\n2.37%\n2.41%\n";
			Name[8].text += "151%\n137%\n117%\n68%\n66%\n64%\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "66%\n64%\n62%\n63%\n63%\n63%\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "7%\n7%\n7%\n8%\n8%\n9%\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "2.37%\n2.22%\n1.74%\n1.23%\n1.21%\n1.19%\n-\n-\n-\n-\n-\n-\n";
			Name[8].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[9].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[10].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
			Name[11].text += "-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n-\n";
		}
	}
}
