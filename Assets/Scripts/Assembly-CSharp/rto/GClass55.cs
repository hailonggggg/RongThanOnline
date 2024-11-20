namespace rto
{
	public class GClass55
	{
		public int x;

		public int y;

		public int width;

		public int height;

		public bool isFocus;

		public bool isCheck;

		public static GClass66[] gclass66_0;

		static GClass55()
		{
			gclass66_0 = new GClass66[4];
			for (int i = 0; i < gclass66_0.Length; i++)
			{
				gclass66_0[i] = GClass69.smethod_9("imgCheck" + i);
			}
		}

		public GClass55()
		{
			isFocus = false;
			isCheck = false;
			width = 40;
			height = 40;
		}

		public GClass55(int x, int y)
		{
			isFocus = false;
			isCheck = false;
			width = 40;
			height = 40;
			this.x = x;
			this.y = y;
		}

		public void method_0(GClass68 g)
		{
			if (isFocus && 0 == 0)
			{
				if (isCheck && 0 == 0)
				{
					g.method_30(gclass66_0[3], x, y);
				}
				else
				{
					g.method_30(gclass66_0[1], x, y);
				}
			}
			else if (isCheck && 0 == 0)
			{
				g.method_30(gclass66_0[2], x, y);
			}
			else
			{
				g.method_30(gclass66_0[0], x, y);
			}
		}

		public void method_1(int x, int y)
		{
			if (x >= this.x && x <= this.x + width && y >= this.y && y <= this.y + height)
			{
				isCheck = !isCheck;
			}
		}

		public void method_2(int x, int y)
		{
		}

		public void method_3(int x, int y)
		{
			if (x >= this.x && x <= this.x + width && y >= this.y && y <= this.y + height)
			{
				isFocus = true;
			}
			else
			{
				isFocus = false;
			}
		}
	}
}
