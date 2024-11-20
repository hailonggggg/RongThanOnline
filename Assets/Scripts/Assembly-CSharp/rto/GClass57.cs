using UnityEngine;

namespace rto
{
	public class GClass57
	{
		public bool isFocus;

		public int x;

		public int y;

		public int width;

		public int height;

		public int maxTextLenght = 500;

		public int type;

		public string text = string.Empty;

		public string textPaint = string.Empty;

		public string name = string.Empty;

		public static int int_0 = 0;

		public static int int_1 = 1;

		public static int int_2 = 2;

		public static int int_3 = 3;

		private static string string_0 = "0123456789";

		private static string string_1 = "abcdefghijklmnopqrstuvwxyz0123456789";

		private static string string_2 = "abcdefghijklmnopqrstuvwxyz0123456789@.";

		public static GClass66 gclass66_0 = GClass69.smethod_9("imgClear.png");

		public GClass72 command;

		public TouchScreenKeyboard keyboard;

		public GClass57()
		{
			text = string.Empty;
			type = int_0;
			isFocus = false;
			height = 65;
			width = 300;
		}

		public virtual void vmethod_0(GClass68 g)
		{
			g.method_31();
			g.method_12(223f, 116f, 20f);
			g.method_9(x, y, width, height, 16);
			g.method_12(207f, 203f, 204f);
			if (isFocus && 0 == 0)
			{
				g.method_12(255f, 255f, 255f);
			}
			g.method_9(x + 2, y + 2, width - 4, height - 4, 14);
			g.method_5(x + 2, y + 2, width - 4, height - 4);
			if (text != null && 0 == 0 && (!text.Equals(string.Empty) || 1 == 0))
			{
				if (isFocus && 0 == 0)
				{
					GClass67.gclass67_17.method_1(g, textPaint, x + 20, y + (height - GClass67.gclass67_17.method_7()) / 2 + ((type == int_1) ? 5 : 0), 0);
					g.method_30(gclass66_0, x + width - 50, y + 14);
				}
				else
				{
					GClass67.gclass67_18.method_1(g, textPaint, x + 20, y + (height - GClass67.gclass67_18.method_7()) / 2 + ((type == int_1) ? 5 : 0), 0);
				}
			}
			else if (name != null && 0 == 0)
			{
				if (isFocus && 0 == 0)
				{
					GClass67.gclass67_17.method_1(g, name, x + 20, y + (height - GClass67.gclass67_17.method_7()) / 2, 0);
				}
				else
				{
					GClass67.gclass67_18.method_1(g, name, x + 20, y + (height - GClass67.gclass67_18.method_7()) / 2, 0);
				}
			}
			if (isFocus && 0 == 0 && GClass69.int_0 % 20 > 9)
			{
				g.method_11(7999781);
				int num = x + 20;
				if (text != null && 0 == 0 && text != string.Empty && 0 == 0)
				{
					num = x + GClass67.gclass67_17.method_4(textPaint) + 20;
				}
				g.method_7(num, y + 10, 2, height - 20);
			}
			g.method_31();
		}

		public void method_0()
		{
			text = string.Empty;
			method_2();
		}

		public void method_1()
		{
			if (text.Length > 0)
			{
				text = text.Substring(0, text.Length - 1);
				method_2();
			}
		}

		public void method_2()
		{
			if (GClass67.gclass67_17.method_4(this.text) > width - 90)
			{
				int num = this.text.Length - 2;
				while (num >= 0)
				{
					string s = this.text.Substring(num, this.text.Length - num);
					if (GClass67.gclass67_17.method_4(s) <= width - 90)
					{
						num--;
						continue;
					}
					textPaint = s;
					break;
				}
			}
			else
			{
				textPaint = this.text;
			}
			if (type == int_1)
			{
				string text = "";
				for (int i = 0; i < textPaint.Length; i++)
				{
					text += "*";
				}
				textPaint = text;
			}
		}

		public void method_3(int x, int y)
		{
			if (x >= this.x + width - 40 && x <= this.x + width && y >= this.y && y <= this.y + height)
			{
				method_0();
				isFocus = true;
			}
			else if (x >= this.x && x <= this.x + width - 40 && y >= this.y && y <= this.y + height)
			{
				isFocus = true;
				if (!Main.bool_1 || 1 == 0)
				{
					keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.ASCIICapable);
				}
			}
			else
			{
				isFocus = false;
				if (keyboard != null && 0 == 0)
				{
					keyboard = null;
				}
			}
		}

		public void method_4(KeyCode keyCode)
		{
			switch (keyCode)
			{
			case KeyCode.Backspace:
				method_1();
				return;
			case KeyCode.Return:
				if (command != null && 0 == 0)
				{
					command.method_0();
				}
				break;
			}
			if (GClass56.list_0.Contains(keyCode) && 0 == 0 && text.Length < maxTextLenght)
			{
				char c = (char)keyCode;
				if (type == int_0)
				{
					text += c;
				}
				if (type == int_2 && string_0.Contains(c.ToString()) && 0 == 0)
				{
					text += c;
				}
				if (type == int_3 && string_2.Contains(c.ToString()) && 0 == 0)
				{
					text += c;
				}
				if (type == int_1 && string_1.Contains(c.ToString()) && 0 == 0)
				{
					text += c;
				}
				method_2();
			}
		}

		public string method_5()
		{
			return text;
		}

		public void method_6(string text)
		{
			if (text != null && 0 == 0)
			{
				this.text = text;
				method_2();
			}
		}

		public void method_7()
		{
			if (keyboard != null && 0 == 0)
			{
				string text = keyboard.text;
				method_6(text);
			}
		}
	}
}
