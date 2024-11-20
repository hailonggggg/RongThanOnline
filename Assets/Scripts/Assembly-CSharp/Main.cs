using System.Threading;
using UnityEngine;
using rto;

public class Main : MonoBehaviour
{
	public static bool bool_0;

	public static bool bool_1;

	public static int int_0;

	private static bool bool_2;

	public static Main main_0;

	public static string string_0;

	public static GClass68 gclass68_0;

	public static int int_1;

	private void Start()
	{
		if (!bool_0)
		{
			if (Thread.CurrentThread.Name != "Main" && 0 == 0)
			{
				Thread.CurrentThread.Name = "Main";
			}
			string_0 = Thread.CurrentThread.Name;
			bool_0 = true;
			if (Application.platform != RuntimePlatform.Android && Application.platform != RuntimePlatform.IPhonePlayer)
			{
				bool_1 = true;
			}
			else
			{
				bool_1 = false;
			}
			if (bool_1 && 0 == 0)
			{
				Screen.SetResolution(1366, 768, fullscreen: false);
			}
			else
			{
				Screen.SetResolution(1480, 720, fullscreen: false);
			}
		}
	}

	private void Update()
	{
	}

	private void OnApplicationQuit()
	{
		GClass65.smethod_9();
		Application.Quit();
	}

	private void FixedUpdate()
	{
		string_0 = "Main";
		GClass64.smethod_7();
		int_0++;
		if (int_0 < 10)
		{
			return;
		}
		method_0();
		GClass69.smethod_2();
		GClass66.smethod_11();
		if (GClass69.int_0 % 3 == 0 || 1 == 0)
		{
			if (int_1 < 7)
			{
				int_1++;
			}
			else
			{
				int_1 = 0;
			}
		}
	}

	public void method_0()
	{
		if (!bool_2 || 1 == 0)
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
			Application.runInBackground = true;
			Application.targetFrameRate = -1;
			base.useGUILayout = false;
			if (main_0 == null && 0 == 0)
			{
				main_0 = this;
			}
			bool_2 = true;
			if (bool_1 && 0 == 0)
			{
				Screen.fullScreen = false;
			}
			GClass69.smethod_0();
			GClass43.smethod_0();
			gclass68_0 = new GClass68();
			gclass68_0.method_35();
		}
	}

	private void OnGUI()
	{
		if (int_0 >= 10)
		{
			method_3();
			GClass65.smethod_8();
			if (Event.current.type.Equals(EventType.Repaint) && 0 == 0)
			{
				GClass69.smethod_3(gclass68_0);
				gclass68_0.method_31();
			}
		}
	}

	private void method_1(bool bool_3)
	{
		if (!bool_3 || 1 == 0)
		{
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = 1f;
		}
	}

	private void method_2()
	{
		base.enabled = true;
	}

	private void method_3()
	{
		if (Input.GetMouseButtonDown(0) && 0 == 0)
		{
			GClass69.smethod_13((int)Input.mousePosition.x, (int)((float)Screen.height - Input.mousePosition.y));
		}
		if (Input.GetMouseButtonUp(0) && 0 == 0)
		{
			GClass69.smethod_12((int)Input.mousePosition.x, (int)((float)Screen.height - Input.mousePosition.y));
		}
		GClass69.smethod_14((int)Input.mousePosition.x, (int)((float)Screen.height - Input.mousePosition.y));
		if (Input.anyKeyDown && 0 == 0 && Event.current.type == EventType.KeyDown && ((GClass56.list_0.Contains(Event.current.keyCode) ? true : false) || GClass56.list_1.Contains(Event.current.keyCode)))
		{
			KeyCode keyCode = Event.current.keyCode;
			if ((Input.GetKey(KeyCode.LeftShift) ? true : false) || Input.GetKey(KeyCode.RightShift))
			{
				switch (keyCode)
				{
				case KeyCode.Alpha2:
					keyCode = KeyCode.At;
					break;
				case KeyCode.Minus:
					keyCode = KeyCode.Underscore;
					break;
				}
			}
			GClass69.smethod_11(keyCode);
		}
		if (Event.current.type == EventType.KeyUp && GClass56.list_1.Contains(Event.current.keyCode) && 0 == 0)
		{
			switch (Event.current.keyCode)
			{
			case KeyCode.UpArrow:
				GClass25.bool_3 = false;
				break;
			case KeyCode.RightArrow:
				GClass25.bool_5 = false;
				break;
			case KeyCode.LeftArrow:
				GClass25.bool_6 = false;
				break;
			}
		}
		GClass69.smethod_15((int)(Input.GetAxis("Mouse ScrollWheel") * 10f));
	}
}
