using UnityEngine;

public class ScrollScript : MonoBehaviour
{
	public GameObject up;

	public GameObject down;

	public float position;

	public float one_point_f;

	public float one_point_s;

	public GameObject moveable;

	public void MakeThings(float focus_top, float focus_down)
	{
		one_point_s = up.transform.position.y - down.transform.position.y;
		one_point_f = (focus_top - focus_down) / one_point_s;
		base.transform.position = new Vector3(base.transform.position.x, up.transform.position.y, base.transform.position.z);
	}

	public void OnMouseDrag()
	{
		float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		y = y.Clamp(down.transform.position.y, up.transform.position.y);
		moveable.transform.position = new Vector3(moveable.transform.position.x, moveable.transform.position.y - (y - base.transform.position.y) * one_point_f, moveable.transform.position.z);
		base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
	}

	private void Update()
	{
		float axis = Input.GetAxis("Mouse ScrollWheel");
		if (axis != 0f)
		{
			float a = base.transform.position.y + axis * Time.deltaTime * 12f * one_point_s;
			a = a.Clamp(down.transform.position.y, up.transform.position.y);
			moveable.transform.position = new Vector3(moveable.transform.position.x, moveable.transform.position.y - (a - base.transform.position.y) * one_point_f, moveable.transform.position.z);
			base.transform.position = new Vector3(base.transform.position.x, a, base.transform.position.z);
		}
	}
}
