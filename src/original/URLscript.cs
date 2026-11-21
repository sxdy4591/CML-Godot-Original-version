using UnityEngine;

public class URLscript : MonoBehaviour
{
	public string url;

	private void OnMouseDown()
	{
		Application.OpenURL(url);
	}
}
