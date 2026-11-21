using UnityEngine;
using UnityEngine.SceneManagement;

public class LanguageScript : MonoBehaviour
{
	public int number;

	public bool start;

	public TextMesh language_now;

	public TranslateScript repaint_this;

	public Sprite on;

	public Sprite off;

	private void Awake()
	{
		if (!PlayerPrefs.HasKey("language"))
		{
			PlayerPrefs.SetInt("language", 0);
		}
		if (number != 0 || start)
		{
			if (number == 0 && PlayerPrefs.HasKey("language"))
			{
				SceneManager.LoadScene("Main");
			}
		}
		else if (PlayerPrefs.GetInt("language") == 0)
		{
			language_now.text = " 中 文";
		}
		else
		{
			language_now.text = "Русский";
		}
	}

	private void OnMouseDown()
	{
		PlayerPrefs.SetInt("language", number);
		if (start)
		{
			SceneManager.LoadScene("Main");
			repaint_this.Repaint();
		}
		else if (PlayerPrefs.GetInt("language") == 0)
		{
			language_now.text = " 中 文";
		}
		else
		{
			language_now.text = "Русский";
		}
	}

	private void OnMouseEnter()
	{
		if (start)
		{
			GetComponent<SpriteRenderer>().sprite = on;
		}
	}

	private void OnMouseExit()
	{
		if (start)
		{
			GetComponent<SpriteRenderer>().sprite = off;
		}
	}
}
