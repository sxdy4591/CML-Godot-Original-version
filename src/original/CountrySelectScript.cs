using UnityEngine;

public class CountrySelectScript : MonoBehaviour
{
	public int number = -1;

	public SpriteRenderer[] znachki = new SpriteRenderer[3];

	public OkoshkoScript[] znachki_okno = new OkoshkoScript[3];

	public SpriteRenderer flag;

	public Sprite my_flag;

	private GlobalScript global1;

	public GameStartScript game1;

	public Sprite ovd;

	public Sprite sev;

	public Sprite conserv;

	public Sprite liberal;

	public Sprite socdem;

	public Sprite totalitarin;

	public GameObject[] other_countries = new GameObject[2];

	private void Awake()
	{
		global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}

	private void OnMouseDown()
	{
		GetComponent<SpriteRenderer>().material.SetFloat("_F", 0.571f);
		other_countries[0].GetComponent<SpriteRenderer>().material.SetFloat("_F", 0f);
		other_countries[1].GetComponent<SpriteRenderer>().material.SetFloat("_F", 0f);
		flag.sprite = my_flag;
		game1.number = number;
		znachki_okno[0].nonono = false;
		znachki_okno[1].nonono = false;
		znachki_okno[2].nonono = false;
		if (PlayerPrefs.GetInt("language") == 0)
		{
			znachki_okno[0].text_en = " 华 沙 条 约";
			znachki_okno[1].text_en = " 经 济 互 助 委 员 会";
		}
		else
		{
			znachki_okno[0].text = "Варшавский договор";
			znachki_okno[1].text = "СЭВ";
		}
		znachki[0].sprite = ovd;
		znachki[1].sprite = sev;
		if (number == 5)
		{
			znachki[2].sprite = totalitarin;
			znachki_okno[2].text = "Авторитарный";
			znachki_okno[2].text_en = " 威 权 主 义";
		}
		else
		{
			znachki[2].sprite = conserv;
			znachki_okno[2].text = "Консервативный";
			znachki_okno[2].text_en = " 保 守 主 义";
		}
	}

	private void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().material.SetFloat("_F", 0.571f);
	}

	private void OnMouseExit()
	{
		if (game1.number != number)
		{
			GetComponent<SpriteRenderer>().material.SetFloat("_F", 0f);
		}
	}
}
