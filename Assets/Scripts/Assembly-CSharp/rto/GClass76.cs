using UnityEngine;

namespace rto
{
	public class GClass76
	{
		public bool isShow;

		public string[] info;

		public GClass72 left;

		public GClass72 center;

		public GClass72 right;

		public int w;

		public int h;

		public int x;

		public int y;

		public int wShow;

		public bool isClose;

		public void method_0(GClass68 g)
		{
			if (!isShow || 1 == 0)
			{
				return;
			}
			g.method_31();
			g.method_5(GClass69.int_1 / 2 - wShow / 2, y, wShow, h);
			g.method_18(0, 0.5f);
			g.method_8(x, y, w, h, 16, 16, 16, 16);
			g.method_12(223f, 116f, 20f);
			g.method_9(x + 1, y + 1, w - 2, h - 2, 15);
			g.method_12(255f, 237f, 217f);
			g.method_9(x + 5, y + 5, w - 10, h - 10, 11);
			int num = y + (h - info.Length * GClass67.gclass67_10.method_7()) / 2 - 10;
			for (int i = 0; i < info.Length; i++)
			{
				GClass67.gclass67_10.method_1(g, info[i], GClass69.int_1 / 2, num, 2);
				num += GClass67.gclass67_10.method_7();
			}
			g.method_31();
			if (wShow == w)
			{
				if (left != null && 0 == 0)
				{
					left.vmethod_0(g);
				}
				if (center != null && 0 == 0)
				{
					center.vmethod_0(g);
				}
				if (right != null && 0 == 0)
				{
					right.vmethod_0(g);
				}
			}
		}

		public void method_1(KeyCode keyCode)
		{
			switch (keyCode)
			{
			case KeyCode.Return:
			case KeyCode.KeypadEnter:
				if (center != null && 0 == 0)
				{
					center.method_0();
				}
				break;
			case KeyCode.F2:
				if (right != null && 0 == 0)
				{
					right.method_0();
				}
				break;
			case KeyCode.F1:
				if (left != null && 0 == 0)
				{
					left.method_0();
				}
				break;
			}
		}

		public void method_2(int x, int y)
		{
			if (center != null && 0 == 0)
			{
				center.vmethod_1(x, y);
			}
			if (left != null && 0 == 0)
			{
				left.vmethod_1(x, y);
			}
			if (right != null && 0 == 0)
			{
				right.vmethod_1(x, y);
			}
		}

		public void method_3(int x, int y)
		{
			if (center != null && 0 == 0)
			{
				center.vmethod_2(x, y);
			}
			if (left != null && 0 == 0)
			{
				left.vmethod_2(x, y);
			}
			if (right != null && 0 == 0)
			{
				right.vmethod_2(x, y);
			}
		}

		public void method_4(int x, int y)
		{
			if (center != null && 0 == 0)
			{
				center.vmethod_3(x, y);
			}
			if (left != null && 0 == 0)
			{
				left.vmethod_3(x, y);
			}
			if (right != null && 0 == 0)
			{
				right.vmethod_3(x, y);
			}
		}

		public void method_5()
		{
			if (!isClose || 1 == 0)
			{
				if (wShow < w)
				{
					int num = (w - wShow >> 1) / 4;
					if (wShow > w / 3)
					{
						num = w - wShow >> 1;
					}
					if (num < 1)
					{
						num = 1;
					}
					wShow += num;
				}
				if (wShow > w)
				{
					wShow = w;
				}
				return;
			}
			if (wShow > 0)
			{
				int num2 = wShow >> 1;
				if (num2 < 1)
				{
					num2 = 1;
				}
				wShow -= num2;
			}
			if (wShow <= 0)
			{
				isShow = false;
				isClose = false;
			}
		}

		public void method_6()
		{
		}

		public void method_7()
		{
			isClose = true;
		}

		public void method_8(string info, GClass72 left, GClass72 center, GClass72 right)
		{
			GClass43.smethod_12();
			w = 800;
			this.info = GClass67.gclass67_10.method_3(info, w - 100);
			h = 190;
			wShow = 10;
			this.left = left;
			this.center = center;
			this.right = right;
			h = this.info.Length * GClass67.gclass67_10.method_7() + 60;
			if (this.info.Length < 4)
			{
				h = 4 * GClass67.gclass67_10.method_7() + 60;
			}
			y = GClass69.int_2 - 52 - h;
			x = GClass69.int_1 / 2 - w / 2;
			if (left != null && 0 == 0)
			{
				this.left.x = GClass69.int_1 / 2 - this.left.w - 20;
				this.left.y = y + h - this.left.h / 2;
			}
			if (right != null && 0 == 0)
			{
				this.right.x = GClass69.int_1 / 2 + 20;
				this.right.y = y + h - this.right.h / 2;
			}
			if (center != null && 0 == 0)
			{
				this.center.x = GClass69.int_1 / 2 - center.w / 2;
				this.center.y = y + h - this.center.h / 2;
			}
			isShow = true;
		}
	}
}
