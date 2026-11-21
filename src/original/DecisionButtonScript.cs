using UnityEngine;

public class DecisionButtonScript : MonoBehaviour
{
	public TextMesh text;

	public OkoshkoScript okno1;

	public int num = -1;

	public Sprite ready;

	public Sprite done;

	public Sprite unready;

	public Sprite on;

	public Sprite off;

	public SpriteRenderer focus_sprite;

	public SpriteRenderer background_sprite;

	private Decision dec;

	private MapChangesScript map1;

	public Sprite[] znachki = new Sprite[0];

	public Sprite[] special = new Sprite[0];

	public void ChangeText(Decision dec)
	{
		this.dec = dec;
		text.text = Text($"{dec.name}\n{dec.desc}", 60);
		okno1.needAutoText = true;
		okno1.text = (okno1.text_en = string.Format("{0}|{2} {3}", dec.req, GlobalScript.inst.new_texts[109], "", dec.result));
	}

	public void ChangeIcon(int num)
	{
		this.num = num;
		if (num <= 35)
		{
			if (num == 20 && GlobalScript.inst.gameState.allcountries[30].Gosstroy == 1)
			{
				focus_sprite.sprite = special[0];
			}
			else
			{
				focus_sprite.sprite = Resources.Load<Sprite>($"decision_sp\\D{num}");
			}
		}
		else
		{
			focus_sprite.sprite = znachki[num - 36];
		}
	}

	public void ChangeCondition()
	{
		if (GlobalScript.inst.gameState.completedDecisions[num])
		{
			background_sprite.sprite = done;
		}
		else if (!dec.condition())
		{
			background_sprite.sprite = unready;
		}
		else
		{
			background_sprite.sprite = ready;
		}
	}

	public void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = on;
	}

	public void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = off;
	}

	public void OnMouseDown()
	{
		if (background_sprite.sprite == ready)
		{
			dec.active();
			GlobalScript.inst.gameState.completedDecisions[num] = true;
			GameObject.Find("Back").GetComponent<FocusesScript>().Repaint();
		}
	}

	private string Text(string text, int col)
	{
		int num = 0;
		string text2 = "";
		bool flag = false;
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == char.Parse("<"))
			{
				flag = true;
			}
			else if (text[i] == char.Parse(">"))
			{
				flag = false;
			}
			if (text[i] == char.Parse("|"))
			{
				num = 0;
				text2 += "\n";
			}
			else if (num >= col)
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
				if (!flag)
				{
					num++;
				}
			}
		}
		return text2;
	}
}
