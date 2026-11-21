using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour
{
	public string new_scene;

	public string now_scene = "Main";

	public Sprite nenavel;

	public Sprite navel;

	public Sprite eng_nenavel;

	public Sprite eng_navel;

	public bool text_navedeniye;

	public void OnMouseDown()
	{
		if (now_scene == "Load" && !GlobalScript.inst.gameState.turn_on)
		{
			new_scene = "Diplomacy";
		}
		SceneManager.LoadSceneAsync(new_scene);
	}

	private void OnMouseEnter()
	{
		if (!(base.gameObject.GetComponent<SpriteRenderer>() != null))
		{
			if (text_navedeniye)
			{
				GetComponent<TextMesh>().color = Color.gray;
			}
		}
		else if (PlayerPrefs.GetInt("language") == 0)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = eng_navel;
		}
		else
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = navel;
		}
	}

	private void OnMouseExit()
	{
		if (!(base.gameObject.GetComponent<SpriteRenderer>() != null))
		{
			if (text_navedeniye)
			{
				GetComponent<TextMesh>().color = Color.black;
			}
		}
		else if (PlayerPrefs.GetInt("language") == 0)
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = eng_nenavel;
		}
		else
		{
			base.gameObject.GetComponent<SpriteRenderer>().sprite = nenavel;
		}
	}
}
