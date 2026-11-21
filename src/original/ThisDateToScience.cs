using UnityEngine;

public class ThisDateToScience : MonoBehaviour
{
	private GlobalScript global1;

	public int this_year = 1989;

	private void Awake()
	{
		global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
		if (GlobalScript.inst.gameState.data[21] < this_year)
		{
			GetComponent<OkoshkoScript>().text = "Стоимость возрастёт\nиз-за несоответствия времени:\n" + (this_year - GlobalScript.inst.gameState.data[21]) * 2 + " из бюджета";
			GetComponent<OkoshkoScript>().text_en = " 因 超 前 研 发 而 需 承 担 \n" + (this_year - GlobalScript.inst.gameState.data[21]) * 2 + " 百 万 预 算 的 惩 罚 ";
		}
		else
		{
			GetComponent<OkoshkoScript>().text = "Стоимость:\n1 из бюджета";
			GetComponent<OkoshkoScript>().text_en = " 研 发 费 用 ：\n1 百 万 预 算";
		}
	}
}
