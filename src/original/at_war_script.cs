using UnityEngine;

public class at_war_script : MonoBehaviour
{
	private GlobalScript global1;

	public Sprite war;

	public bool special;

	public int this_num;

	public void Repaint()
	{
		if (global1 == null)
		{
			global1 = GlobalScript.inst;
		}
		if (!special)
		{
			if (GlobalScript.inst.gameState.allcountries[34].cw && this_num == 2)
			{
				GetComponent<Transform>().localPosition = new Vector3(38.0637f, -34.7f, -32.31f);
				this_num = 34;
			}
			if (GlobalScript.inst.gameState.event_done[376] && !GlobalScript.inst.gameState.ingamewars[15].is_going && this_num == 15)
			{
				GetComponent<Transform>().localPosition = new Vector3(43.8464f, -35.7903f, -32.3098f);
				this_num = 34;
			}
			if (GlobalScript.inst.gameState.ingamewars[35].is_going && (this_num == 15 || this_num == 34))
			{
				GetComponent<Transform>().localPosition = new Vector3(47.0255f, -39.349f, -32.3098f);
				this_num = 35;
			}
			if (this_num == 4 && GlobalScript.inst.gameState.ingamewars[37].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(13.1418f, -29.506f, -61.186f);
				this_num = 37;
			}
			if (this_num == 22 && GlobalScript.inst.gameState.ingamewars[70].is_going)
			{
				this_num = 70;
			}
			if (this_num == 1 && GlobalScript.inst.gameState.ingamewars[70].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(28.8911f, -14.0417f, -33.7236f);
				this_num = 70;
			}
			if (this_num == 25 && GlobalScript.inst.gameState.ingamewars[69].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(39.2947f, -16.2163f, -33.7236f);
				this_num = 69;
			}
			if (GlobalScript.inst.gameState.event_done[642] && this_num == 25 && GlobalScript.inst.gameState.ingamewars[70].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(39.2947f, -16.2163f, -33.7236f);
				this_num = 70;
			}
			if ((this_num == 3 || (this_num == 43 && GetComponent<Transform>().localPosition == new Vector3(15.4382f, -25.386f, -61.186f))) && GlobalScript.inst.gameState.ingamewars[37].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(9.3637f, -22.38f, -32.31f);
				this_num = 37;
			}
			if ((this_num == 8 || (this_num == 43 && GetComponent<Transform>().localPosition == new Vector3(16.6382f, -25.986f, -61.186f))) && GlobalScript.inst.gameState.ingamewars[37].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(15.5746f, -26.1182f, -32.31f);
				this_num = 37;
			}
			if ((this_num == 42 || this_num == 29 || (this_num == 43 && GetComponent<Transform>().localPosition == new Vector3(17.8218f, -27.686f, -61.186f))) && GlobalScript.inst.gameState.ingamewars[37].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(16.9201f, -27.8328f, -32.31f);
				this_num = 37;
			}
			if ((this_num == 38 || this_num == 28) && GlobalScript.inst.gameState.ingamewars[37].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(13.2255f, -23.7383f, -61.186f);
				this_num = 37;
			}
			if (this_num == 28 && GlobalScript.inst.gameState.ingamewars[38].is_going)
			{
				this_num = 38;
			}
			if ((this_num == 29 || this_num == 42) && GlobalScript.inst.gameState.ingamewars[43].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(17.8218f, -27.686f, -61.186f);
				this_num = 43;
			}
			if (this_num == 8 && GlobalScript.inst.gameState.ingamewars[43].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(16.6382f, -25.986f, -61.186f);
				this_num = 43;
			}
			if (this_num == 3 && GlobalScript.inst.gameState.ingamewars[43].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(15.4382f, -25.386f, -61.186f);
				this_num = 43;
			}
			if (this_num == 21 && GlobalScript.inst.gameState.ingamewars[39].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(-12.44f, -23.763f, -61.186f);
				this_num = 39;
			}
			if ((this_num == 21 || this_num == 39) && GlobalScript.inst.gameState.ingamewars[40].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(-6.8418f, -24.2018f, -61.186f);
				this_num = 40;
			}
			if (this_num == 19 && GlobalScript.inst.gameState.ingamewars[41].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(9.64f, -20.08f, -61.186f);
				this_num = 41;
			}
			if (this_num == 41 && GlobalScript.inst.gameState.ingamewars[19].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(1.34f, -17.56f, -32.31f);
				this_num = 19;
			}
			if (this_num == 29 && GlobalScript.inst.gameState.ingamewars[42].is_going)
			{
				this_num = 42;
			}
			if (this_num == 42 && GlobalScript.inst.gameState.ingamewars[29].is_going)
			{
				this_num = 29;
			}
			if (this_num == 16 && GlobalScript.inst.gameState.ingamewars[71].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(39.7727f, -26.591f, -33.7328f);
				this_num = 71;
			}
			if (this_num == 1 && GlobalScript.inst.gameState.ingamewars[71].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(36.5145f, -25.9402f, -33.7236f);
				this_num = 71;
			}
			if (this_num == 27 && GlobalScript.inst.gameState.ingamewars[71].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(37.7471f, -27.402f, -33.7236f);
				this_num = 71;
			}
			if (this_num == 16 && GlobalScript.inst.gameState.ingamewars[72].is_going)
			{
				this_num = 72;
			}
			if (this_num == 16 && GlobalScript.inst.gameState.ingamewars[73].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(47.2941f, -27.5894f, -33.7328f);
				this_num = 73;
			}
			if (this_num == 1 && GlobalScript.inst.gameState.ingamewars[73].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(38.0637f, -34.7f, -55f);
				this_num = 73;
			}
			if (this_num == 27 && GlobalScript.inst.gameState.ingamewars[73].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(51.6068f, -36.4784f, -33.7236f);
				this_num = 73;
			}
			if (this_num == 16 && GlobalScript.inst.gameState.ingamewars[74].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(27.3034f, -20.5657f, -33.7328f);
				this_num = 74;
			}
			if (this_num == 1 && GlobalScript.inst.gameState.ingamewars[74].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(30.5943f, -23.7075f, -33.7236f);
				this_num = 74;
			}
			if (this_num == 27 && GlobalScript.inst.gameState.ingamewars[74].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(35.1161f, -25.4621f, -33.7236f);
				this_num = 74;
			}
			if (this_num == 16 && GlobalScript.inst.gameState.ingamewars[75].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(46.4036f, -25.6491f, -33.7328f);
				this_num = 75;
			}
			if (this_num == 17 && GlobalScript.inst.gameState.ingamewars[76].is_going)
			{
				this_num = 76;
			}
			if (this_num == 16 && GlobalScript.inst.gameState.ingamewars[76].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(3.6093f, -14.9236f, -33.7328f);
				this_num = 76;
			}
			if (this_num == 27 && GlobalScript.inst.gameState.ingamewars[76].is_going)
			{
				GetComponent<Transform>().localPosition = new Vector3(1.5256f, -13.6456f, -33.7236f);
				this_num = 76;
			}
		}
		if (!special)
		{
			if (GlobalScript.inst.gameState.ingamewars[this_num].is_going)
			{
				GetComponent<SpriteRenderer>().sprite = war;
			}
			else
			{
				GetComponent<SpriteRenderer>().sprite = null;
			}
		}
		else if ((this_num == -1 && GlobalScript.inst.gameState.iranrev) || (this_num == -2 && GlobalScript.inst.gameState.war == 2) || (this_num == -3 && GlobalScript.inst.gameState.war == 1) || (this_num == -4 && GlobalScript.inst.gameState.data[37] > 0 && GlobalScript.inst.gameState.data[37] < 1000) || this_num == -5)
		{
			GetComponent<SpriteRenderer>().sprite = war;
		}
		else
		{
			GetComponent<SpriteRenderer>().sprite = null;
		}
	}

	private void Awake()
	{
		global1 = GameObject.Find("Global(Clone)").GetComponent<GlobalScript>();
	}
}
