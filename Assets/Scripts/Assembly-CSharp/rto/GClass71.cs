using System;

namespace rto
{
	public class GClass71
	{
		public int x;

		public int y;

		public int width;

		public int height;

		public static GClass66 gclass66_0 = GClass69.smethod_9("imgMove1");

		public static GClass66 gclass66_1 = GClass69.smethod_9("imgMove");

		public int yMove;

		public int xMove;

		private int deltaX;

		private int deltaY;

		private int delta;

		private int angle;

		public static int int_0 = 50;

		public bool isPointerClicked;

		public GClass71()
		{
			width = gclass66_1.method_0();
			height = gclass66_1.method_1();
			xMove = (x = 100 + width / 2);
			yMove = (y = GClass69.int_2 - 75 - height / 2);
		}

		public void method_0(GClass68 g)
		{
			if (GClass3.bool_5 ? true : false)
			{
				g.method_28(gclass66_0, x, y, GClass68.int_0 | GClass68.int_1);
				g.method_28(gclass66_1, xMove, yMove, GClass68.int_0 | GClass68.int_1);
			}
		}

		public void method_1()
		{
		}

		public void method_2(int x, int y)
		{
			if (GClass3.bool_5 ? true : false)
			{
				if (x >= this.x - width / 2 && x <= this.x + width / 2 && y >= this.y - height / 2 && y <= this.y + height / 2)
				{
					isPointerClicked = true;
				}
				else
				{
					isPointerClicked = false;
				}
			}
		}

		public void method_3(int x, int y)
		{
			if (!GClass3.bool_5 || 1 == 0 || !isPointerClicked || 1 == 0)
			{
				return;
			}
			GClass3.int_13 = 0;
			GClass3.bool_2 = false;
			deltaX = x - this.x;
			deltaY = y - this.y;
			if (Math.Abs(deltaX) > 4 || Math.Abs(deltaY) > 4)
			{
				delta = (int)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
				if (delta > int_0)
				{
					xMove = this.x + deltaX * int_0 / delta;
					yMove = this.y + deltaY * int_0 / delta;
				}
				else
				{
					xMove = x;
					yMove = y;
				}
				angle = GClass84.smethod_12(deltaX, deltaY);
				if ((angle <= 360 && angle >= 340) || (angle >= 0 && angle <= 20))
				{
					GClass25.bool_3 = false;
					GClass25.bool_4 = false;
					GClass25.bool_6 = false;
					GClass25.bool_5 = true;
				}
				else if (angle > 20 && angle < 70)
				{
					GClass25.bool_3 = false;
					GClass25.bool_4 = true;
					GClass25.bool_6 = false;
					GClass25.bool_5 = true;
				}
				else if (angle >= 70 && angle <= 110)
				{
					GClass25.bool_3 = false;
					GClass25.bool_4 = true;
					GClass25.bool_6 = false;
					GClass25.bool_5 = false;
				}
				else if (angle > 110 && angle < 160)
				{
					GClass25.bool_3 = false;
					GClass25.bool_4 = true;
					GClass25.bool_6 = true;
					GClass25.bool_5 = false;
				}
				else if (angle >= 160 && angle <= 200)
				{
					GClass25.bool_3 = false;
					GClass25.bool_4 = false;
					GClass25.bool_6 = true;
					GClass25.bool_5 = false;
				}
				else if (angle > 200 && angle < 250)
				{
					GClass25.bool_3 = true;
					GClass25.bool_4 = false;
					GClass25.bool_6 = true;
					GClass25.bool_5 = false;
				}
				else if (angle >= 250 && angle <= 290)
				{
					GClass25.bool_3 = true;
					GClass25.bool_4 = false;
					GClass25.bool_6 = false;
					GClass25.bool_5 = false;
				}
				else if (angle > 290 && angle < 340)
				{
					GClass25.bool_3 = true;
					GClass25.bool_4 = false;
					GClass25.bool_6 = false;
					GClass25.bool_5 = true;
				}
			}
		}

		public void method_4(int x, int y)
		{
			if (GClass3.bool_5 ? true : false)
			{
				if (isPointerClicked && 0 == 0)
				{
					GClass25.bool_3 = false;
					GClass25.bool_5 = false;
					GClass25.bool_6 = false;
					GClass25.bool_4 = false;
				}
				isPointerClicked = false;
				xMove = this.x;
				yMove = this.y;
			}
		}
	}
}
