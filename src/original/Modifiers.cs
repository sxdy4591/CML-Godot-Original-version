using System;

[Serializable]
public class Modifiers
{
	public bool active;

	public bool turned;

	public int row;

	public Modifiers(bool turned = true, bool active = false, int row = 0)
	{
		this.turned = turned;
		this.row = row;
		this.active = active;
	}
}
