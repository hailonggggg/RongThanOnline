using System.Collections.Generic;

namespace rto
{
	public class GClass46 : GInterface1
	{
		public bool isShow;

		public bool isClose;

		public int x;

		public int y;

		public int w;

		public int h;

		public int hMax;

		public int hMin;

		public int xScroll;

		public int yScroll;

		public int wScroll;

		public int hScroll;

		public int cmtoY;

		public int cmy;

		public int cmdy;

		public int cmvy;

		public int cmyLim;

		public bool isPointerDownInScroll;

		public int xPointerDown;

		public int yPointerDown;

		public bool isPointerUp;

		public int pointerX;

		public int pointerY;

		public string[] says;

		public string title;

		public List<GClass72> commands = new List<GClass72>();

		public static GClass46 gclass46_0;

		public GClass72 cmdOk = new GClass75("OK", gclass46_0, 1, null);

		public int iconId;

		public GClass72 cmdClose;

		static GClass46()
		{
			gclass46_0 = new GClass46();
		}

		public GClass46()
		{
			cmdClose = new GClass72("imgCloseMini", "imgCloseFocusMini", "imgCloseMiniClick", this, 2, null);
		}

		public void method_0(GClass68 g)
		{
			if (!isShow || 1 == 0)
			{
				return;
			}
			g.method_5(x, y, w, h);
			g.method_18(0, 0.5f);
			g.method_9(x, y, w, h, 10);
			g.method_12(223f, 116f, 20f);
			g.method_9(x + 1, y + 1, w - 2, h - 2, 9);
			g.method_11(16777215);
			g.method_9(x + 3, y + 3, w - 6, h - 6, 7);
			cmdClose.vmethod_0(g);
			GClass42.smethod_2(g, iconId, x + 40, y + 40, 0f);
			GClass67.gclass67_4.method_1(g, title, x + 80, y + 30, 0);
			if (!isClose || 1 == 0)
			{
				for (int i = 0; i < commands.Count; i++)
				{
					commands[i].x = x + w - 10 - commands[i].w - (commands[i].w + 10) * i;
					commands[i].y = y + h - 10 - commands[i].h;
					commands[i].vmethod_0(g);
				}
			}
			if (h != hMax)
			{
				return;
			}
			g.method_5(xScroll, yScroll, wScroll, hScroll);
			g.method_1(0, -cmy);
			int num = yScroll + 5 - GClass67.gclass67_5.method_7();
			for (int j = 0; j < says.Length; j++)
			{
				GClass67 gClass = GClass67.gclass67_5;
				string text = says[j].Substring(0, 2);
				if (text != null && 0 == 0)
				{
					switch (text)
					{
					case "n0":
						if (true)
						{
							gClass = GClass67.gclass67_6;
						}
						break;
					case "n1":
						if (true)
						{
							gClass = GClass67.gclass67_7;
						}
						break;
					case "n2":
						if (true)
						{
							gClass = GClass67.gclass67_9;
						}
						break;
					case "n3":
						if (true)
						{
							gClass = GClass67.gclass67_5;
						}
						break;
					case "n4":
						if (true)
						{
							gClass = GClass67.gclass67_18;
						}
						break;
					case "n5":
						if (true)
						{
							gClass = GClass67.gclass67_8;
						}
						break;
					case "b0":
						if (true)
						{
							gClass = GClass67.gclass67_3;
						}
						break;
					case "b1":
						if (true)
						{
							gClass = GClass67.gclass67_4;
						}
						break;
					}
				}
				string[] array = GClass67.gclass67_5.method_3(says[j].Substring(2), wScroll);
				foreach (string st in array)
				{
					gClass.method_1(g, st, xScroll + 20, num += GClass67.gclass67_5.method_7(), 0);
				}
			}
			cmyLim = num - (yScroll + 5 - GClass67.gclass67_5.method_7()) - hScroll + 5;
			if (cmyLim < 0)
			{
				cmyLim = 0;
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_1(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_1(GClass68 g, int x, int y, int w, int h, int hMax, int hView, int yView)
		{
			g.method_12(264f, 181f, 115f);
			g.method_9(x, y, w, h, 2);
			int num = hView * h / hMax;
			int num2 = yView * h / hMax;
			g.method_12(119f, 69f, 6f);
			g.method_9(x - 1, y + num2, w + 2, num, 2);
		}

		public void method_2()
		{
			cmdClose.y = y + 10;
			if (!isClose || 1 == 0)
			{
				if (h < hMax)
				{
					int num = hMax - h >> 1;
					if (num < 1)
					{
						num = 1;
					}
					h += num;
				}
				else if (h > hMax)
				{
					h = hMax;
				}
			}
			else
			{
				if (h > 0)
				{
					int num2 = h >> 1;
					if (num2 < 1)
					{
						num2 = 1;
					}
					h -= num2;
				}
				if (h <= 0)
				{
					isClose = false;
					isShow = false;
					return;
				}
			}
			if (isPointerDownInScroll && 0 == 0 && pointerY != yPointerDown)
			{
				int num3 = pointerY - yPointerDown;
				yPointerDown = pointerY;
				cmtoY -= num3;
				if (cmtoY < 0)
				{
					cmtoY = 0;
				}
				if (cmtoY > cmyLim)
				{
					cmtoY = cmyLim;
				}
				if (cmy < 0 || cmy > cmyLim)
				{
					num3 = 0;
				}
				cmy -= num3;
				if (cmy < 0)
				{
					cmy = 0;
				}
				if (cmy > cmyLim)
				{
					cmy = cmyLim;
				}
			}
		}

		public void method_3(string title, string info, int iconId, params GClass72[] commands)
		{
			this.title = title;
			this.iconId = iconId;
			this.commands.Clear();
			if (commands != null && 0 == 0)
			{
				for (int num = commands.Length - 1; num >= 0; num--)
				{
					this.commands.Add(commands[num]);
				}
			}
			else
			{
				this.commands.Add(cmdOk);
			}
			says = info.Split('|');
			w = 534;
			hMax = 350;
			h = 350;
			x = (GClass69.int_1 - w) / 2;
			y = (GClass69.int_2 - h) / 2 - 30;
			xScroll = x + 20;
			wScroll = w - 40;
			yScroll = y + 70;
			hScroll = h - 130;
			cmyLim = says.Length * GClass67.gclass67_5.method_7() - hScroll;
			if (cmyLim < 0)
			{
				cmyLim = 0;
			}
			cmtoY = 0;
			cmy = 0;
			hMin = 70;
			h = 70;
			cmdClose.x = x + w - cmdClose.w - 10;
			cmdClose.y = y + 10;
			isShow = true;
		}

		public void method_4()
		{
			isClose = true;
		}

		public void method_5(int x, int y)
		{
			if (isClose)
			{
				return;
			}
			if (x > this.x && x < this.x + w && y < this.y + h && y > this.y)
			{
				cmdClose.vmethod_1(x, y);
				using (List<GClass72>.Enumerator enumerator = commands.GetEnumerator())
				{
					while (enumerator.MoveNext() ? true : false)
					{
						enumerator.Current.vmethod_1(x, y);
					}
				}
				if (x >= xScroll && x <= xScroll + wScroll && y >= yScroll && y <= yScroll + hScroll)
				{
					isPointerDownInScroll = true;
				}
				xPointerDown = x;
				yPointerDown = y;
			}
			else
			{
				method_4();
			}
		}

		public void method_6(int x, int y)
		{
			if (isClose)
			{
				return;
			}
			cmdClose.vmethod_2(x, y);
			using (List<GClass72>.Enumerator enumerator = commands.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					enumerator.Current.vmethod_2(x, y);
				}
			}
			isPointerDownInScroll = false;
		}

		public void method_7(int x, int y)
		{
			if (isClose && 0 == 0)
			{
				return;
			}
			pointerX = x;
			pointerY = y;
			cmdClose.vmethod_3(x, y);
			using List<GClass72>.Enumerator enumerator = commands.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				enumerator.Current.vmethod_3(x, y);
			}
		}

		public void imethod_0(int idAction, object p)
		{
			switch (idAction)
			{
			case 2:
				method_4();
				break;
			case 1:
				isShow = false;
				break;
			}
		}
	}
}
