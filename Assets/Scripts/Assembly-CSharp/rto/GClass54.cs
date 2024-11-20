using UnityEngine;

namespace rto
{
	public class GClass54 : GInterface1
	{
		public GInterface2 parentScreen;

		public int x;

		public int y;

		public int yMin;

		public int yMax;

		public bool isClose;

		public string name;

		public int w;

		public int h;

		public GClass57 textField;

		public bool isShow;

		public GClass72 cmdOk;

		public GClass72 cmdClose;

		public int wTitle;

		public string to;

		public GClass54()
		{
			w = 600;
			h = 190;
			x = GClass69.int_1 / 2 - w / 2;
			y = GClass69.int_2 - 240;
			textField = new GClass57();
			name = "Nhập mã bảo vệ";
			textField.name = "PIN";
			cmdOk = new GClass75("Ok", this, 1, null);
			cmdClose = new GClass75("Đóng", this, 2, null);
			method_1();
			yMax = y;
			y = (yMin = GClass69.int_2 + h);
		}

		public void method_0(GClass68 g)
		{
			g.method_18(0, 0.5f);
			g.method_9(x, y, w, h, 22);
			g.method_12(223f, 116f, 20f);
			g.method_9(x + 1, y + 1, w - 2, h - 2, 21);
			g.method_18(0, 0.5f);
			g.method_8(x + 20, y - 50, wTitle, 50, 22, 22, 0, 0);
			g.method_12(223f, 116f, 20f);
			g.method_8(x + 21, y - 49, wTitle - 2, 50, 21, 21, 0, 0);
			GClass67.gclass67_11.method_1(g, name, x + 20 + wTitle / 2, y - 35, 2);
			g.method_12(255f, 237f, 217f);
			g.method_8(x + 10, y + 10, w - 20, h - 20, 18, 18, 18, 18);
			textField.vmethod_0(g);
			method_1();
			cmdClose.vmethod_0(g);
			cmdOk.vmethod_0(g);
		}

		public void method_1()
		{
			textField.width = w - 60;
			textField.x = x + 30;
			textField.y = y + 30;
			cmdOk.x = GClass69.int_1 / 2 - cmdOk.w - 10;
			cmdOk.y = textField.y + textField.height + 20;
			cmdClose.x = GClass69.int_1 / 2 + 10;
			cmdClose.y = textField.y + textField.height + 20;
			wTitle = GClass67.gclass67_11.method_4(name) + 80;
			h = textField.height + cmdOk.h + 80;
		}

		public void imethod_0(int idAction, object p)
		{
			switch (idAction)
			{
			case 2:
				method_6();
				if (parentScreen != null && 0 == 0)
				{
					parentScreen.imethod_2();
				}
				break;
			case 1:
				if (parentScreen != null && 0 == 0)
				{
					parentScreen.imethod_1(textField.method_5(), to);
					textField.method_6(string.Empty);
					textField.method_0();
				}
				break;
			}
		}

		public void method_2(int x, int y)
		{
			cmdOk.vmethod_1(x, y);
			cmdClose.vmethod_1(x, y);
			textField.method_3(x, y);
		}

		public void method_3(int x, int y)
		{
			cmdOk.vmethod_2(x, y);
			cmdClose.vmethod_2(x, y);
		}

		public void method_4(int x, int y)
		{
			cmdOk.vmethod_3(x, y);
			cmdClose.vmethod_3(x, y);
		}

		public void method_5()
		{
			if (!isClose || 1 == 0)
			{
				textField.method_7();
				if (y > yMax)
				{
					int num = y - yMax >> 1;
					if (num < 1)
					{
						num = 1;
					}
					y -= num;
				}
				return;
			}
			if (y < yMin)
			{
				int num2 = yMin - y >> 1;
				if (num2 < 1)
				{
					num2 = 1;
				}
				y += num2;
			}
			if (y >= yMin)
			{
				isShow = false;
				isClose = false;
			}
		}

		public void method_6()
		{
			isClose = true;
		}

		public void method_7(KeyCode keyCode)
		{
			switch (keyCode)
			{
			case KeyCode.Return:
				cmdOk.method_0();
				break;
			case KeyCode.F2:
				cmdClose.method_0();
				break;
			default:
				textField.method_4(keyCode);
				break;
			}
		}

		public void method_8(string name, string info)
		{
			if (!isShow)
			{
				this.name = name;
				textField.name = info;
				textField.type = GClass57.int_0;
				textField.maxTextLenght = 500;
				textField.isFocus = true;
				isShow = true;
			}
		}

		public void method_9(string name, string info, int length)
		{
			if (!isShow)
			{
				this.name = name;
				textField.name = info;
				textField.type = GClass57.int_2;
				textField.maxTextLenght = length;
				textField.isFocus = true;
				isShow = true;
			}
		}
	}
}
