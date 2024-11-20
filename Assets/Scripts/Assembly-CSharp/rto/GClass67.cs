using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass67
	{
		public bool isBolder;

		public static GClass67 gclass67_0;

		public static GClass67 gclass67_1;

		public static GClass67 gclass67_2;

		public static GClass67 gclass67_3;

		public static GClass67 gclass67_4;

		public static GClass67 gclass67_5;

		public static GClass67 gclass67_6;

		public static GClass67 gclass67_7;

		public static GClass67 gclass67_8;

		public static GClass67 gclass67_9;

		public static GClass67 gclass67_10;

		public static GClass67 gclass67_11;

		public static GClass67 gclass67_12;

		public static GClass67 gclass67_13;

		public static GClass67 gclass67_14;

		public static GClass67 gclass67_15;

		public static GClass67 gclass67_16;

		public static GClass67 gclass67_17;

		public static GClass67 gclass67_18;

		public static GClass67 gclass67_19;

		public static GClass67 gclass67_20;

		public static GClass67 gclass67_21;

		public static GClass67 gclass67_22;

		public static GClass67 gclass67_23;

		public static GClass67 gclass67_24;

		public static GClass67 gclass67_25;

		public static GClass67 gclass67_26;

		public static GClass67 gclass67_27;

		public static GClass67 gclass67_28;

		public static GClass67 gclass67_29;

		public static GClass67 gclass67_30;

		public static GClass67 gclass67_31;

		public Font myFont;

		private int height;

		private int wO;

		public Color color = Color.white;

		public int type;

		private bool isBoder;

		static GClass67()
		{
			gclass67_0 = new GClass67(Color.white, 0, isBolder: false);
			gclass67_1 = new GClass67(Color.yellow, 0, isBolder: false);
			gclass67_2 = new GClass67(new Color(0f, 0.424f, 0.749f), 0, isBolder: false);
			gclass67_3 = new GClass67(smethod_0(16711680), 0, isBolder: false);
			gclass67_4 = new GClass67(new Color(0f, 0.75f, 0f), 0, isBolder: false);
			gclass67_25 = new GClass67(new Color32(119, 69, 6, byte.MaxValue), 3, isBolder: false);
			gclass67_26 = new GClass67(Color.white, 3, isBolder: false);
			gclass67_27 = new GClass67(Color.yellow, 3, isBolder: false);
			gclass67_28 = new GClass67(Color.black, 3, isBolder: false);
			gclass67_29 = new GClass67(new Color(0f, 0.424f, 0.749f), 3, isBolder: false);
			gclass67_30 = new GClass67(new Color32(223, 116, 20, byte.MaxValue), 3, isBolder: false);
			gclass67_31 = new GClass67(new Color32(87, 90, 92, byte.MaxValue), 3, isBolder: false);
			gclass67_5 = new GClass67(Color.black, 1, isBolder: false);
			gclass67_12 = new GClass67(Color.yellow, 1, isBolder: false);
			gclass67_10 = new GClass67(new Color32(119, 69, 6, byte.MaxValue), 1, isBolder: false);
			gclass67_6 = new GClass67(smethod_0(16711680), 1, isBolder: false);
			gclass67_7 = new GClass67(new Color(0f, 0.75f, 0f), 1, isBolder: false);
			gclass67_8 = new GClass67(smethod_0(8701737), 1, isBolder: false);
			gclass67_9 = new GClass67(new Color(0f, 0.424f, 0.749f), 1, isBolder: false);
			gclass67_11 = new GClass67(Color.white, 1, isBolder: false);
			gclass67_17 = new GClass67(new Color32(223, 116, 20, byte.MaxValue), 1, isBolder: false);
			gclass67_18 = new GClass67(new Color32(87, 90, 92, byte.MaxValue), 1, isBolder: false);
			gclass67_24 = new GClass67(new Color32(103, 53, 168, byte.MaxValue), 1, isBolder: false);
			gclass67_13 = new GClass67(Color.yellow, 1, isBolder: true);
			gclass67_14 = new GClass67(Color.white, 1, isBolder: true);
			gclass67_15 = new GClass67(smethod_0(16711680), 1, isBolder: true);
			gclass67_16 = new GClass67(new Color(0f, 0.424f, 0.749f), 1, isBolder: true);
			gclass67_19 = new GClass67(Color.red, "Fonts/normal", isBolder: true);
			gclass67_21 = new GClass67(Color.yellow, "Fonts/normal", isBolder: true);
			gclass67_22 = new GClass67(Color.white, "Fonts/normal", isBolder: true);
			gclass67_23 = new GClass67(Color.green, "Fonts/normal", isBolder: true);
			gclass67_20 = new GClass67(new Color(0f, 0.424f, 0.749f), "Fonts/normal", isBolder: true);
		}

		public GClass67(Color color, string path, bool isBolder)
		{
			myFont = (Font)Resources.Load(path);
			this.color = color;
			this.isBolder = isBolder;
			wO = method_5("o");
		}

		public GClass67(Color color, int type, bool isBolder)
		{
			this.type = type;
			string path = "Fonts/Roboto-Bold";
			switch (type)
			{
			case 1:
				path = "Fonts/Roboto-Bold";
				break;
			case 2:
				path = "Fonts/Roboto-Bold";
				break;
			case 3:
				path = "Fonts/Roboto-Bold";
				break;
			}
			myFont = (Font)Resources.Load(path);
			this.color = color;
			this.isBolder = isBolder;
			wO = method_5("o");
		}

		public void method_0(int height)
		{
			this.height = height;
		}

		public void method_1(GClass68 g, string st, int x, int y, int align)
		{
			if (isBolder && 0 == 0)
			{
				isBoder = true;
				method_8(g, st, x + 1, y, align);
				method_8(g, st, x - 1, y, align);
				method_8(g, st, x, y - 1, align);
				method_8(g, st, x, y + 1, align);
				method_8(g, st, x + 1, y + 1, align);
				method_8(g, st, x + 1, y - 1, align);
				method_8(g, st, x - 1, y - 1, align);
				method_8(g, st, x - 1, y + 1, align);
			}
			isBoder = false;
			method_8(g, st, x, y, align);
		}

		public List<string> method_2(string src, int lineWidth)
		{
			List<string> list = new List<string>();
			string text = string.Empty;
			for (int i = 0; i < src.Length; i++)
			{
				if (src[i] != '\n' && src[i] != '\b')
				{
					text += src[i];
					if (method_4(text) > lineWidth)
					{
						int num = 0;
						num = text.Length - 1;
						while (num >= 0 && text[num] != ' ')
						{
							num--;
						}
						if (num < 0)
						{
							num = text.Length - 1;
						}
						list.Add(text.Substring(0, num));
						i = i - (text.Length - num) + 1;
						text = string.Empty;
					}
					if (i == src.Length - 1 && (!text.Trim().Equals(string.Empty) || 1 == 0))
					{
						list.Add(text);
					}
				}
				else
				{
					list.Add(text);
					text = string.Empty;
				}
			}
			return list;
		}

		public static Color smethod_0(int rgb)
		{
			int num = rgb & 0xFF;
			int num2 = (rgb >> 8) & 0xFF;
			int num3 = (rgb >> 16) & 0xFF;
			float b = (float)num / 256f;
			float g = (float)num2 / 256f;
			float r = (float)num3 / 256f;
			float a = 1f;
			return new Color(r, g, b, a);
		}

		public string[] method_3(string src, int lineWidth)
		{
			List<string> list = method_2(src, lineWidth);
			string[] array = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = list[i];
			}
			return array;
		}

		public int method_4(string s)
		{
			return method_5(s);
		}

		public int method_5(string s)
		{
			try
			{
				GUIStyle gUIStyle = new GUIStyle();
				gUIStyle.font = myFont;
				if (type == 0 || 1 == 0)
				{
					gUIStyle.fontSize = 32;
				}
				else if (type == 1)
				{
					gUIStyle.fontSize = 24;
				}
				else if (type == 3)
				{
					gUIStyle.fontSize = 18;
				}
				return (int)gUIStyle.CalcSize(new GUIContent(s)).x;
			}
			catch
			{
				return method_6(s);
			}
		}

		public int method_6(string s)
		{
			return s.Length * wO;
		}

		public int method_7()
		{
			if (height > 0)
			{
				return height;
			}
			GUIStyle gUIStyle = new GUIStyle();
			gUIStyle.font = myFont;
			if (type == 0 || 1 == 0)
			{
				gUIStyle.fontSize = 32;
			}
			else if (type == 1)
			{
				gUIStyle.fontSize = 24;
			}
			else if (type == 3)
			{
				gUIStyle.fontSize = 18;
			}
			try
			{
				height = (int)gUIStyle.CalcSize(new GUIContent("Ag")).y;
			}
			catch
			{
				height = 24;
			}
			return height;
		}

		public void method_8(GClass68 g, string st, int x0, int y0, int align)
		{
			GUIStyle gUIStyle = new GUIStyle(GUI.skin.label);
			gUIStyle.font = myFont;
			if (type == 0 || 1 == 0)
			{
				y0 -= 3;
				gUIStyle.fontSize = 32;
			}
			else if (type == 1)
			{
				y0 -= 3;
				gUIStyle.fontSize = 24;
			}
			else if (type == 3)
			{
				y0 -= 3;
				gUIStyle.fontSize = 18;
			}
			float num = 0f;
			float num2 = 0f;
			switch (align)
			{
			case 0:
				num = x0;
				num2 = y0;
				gUIStyle.alignment = TextAnchor.UpperLeft;
				break;
			case 1:
				num = x0 - GClass69.int_1;
				num2 = y0;
				gUIStyle.alignment = TextAnchor.UpperRight;
				break;
			case 2:
			case 3:
				num = x0 - GClass69.int_1 / 2;
				num2 = y0;
				gUIStyle.alignment = TextAnchor.UpperCenter;
				break;
			}
			if (isBoder && 0 == 0)
			{
				gUIStyle.normal.textColor = new Color(0f, 0f, 0f, 1f);
			}
			else
			{
				gUIStyle.normal.textColor = color;
			}
			g.method_17(st, (int)num, (int)num2, gUIStyle);
		}
	}
}
