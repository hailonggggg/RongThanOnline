namespace rto
{
	public class GClass53
	{
		public int minX;

		public int minY;

		public int maxX;

		public int maxY;

		public int x;

		public int y;

		public int w;

		public int h;

		public string name;

		public bool isShow;

		public int type;

		public GClass53()
		{
		}

		public GClass53(int x, int y, int type, string name)
		{
			this.type = type;
			this.name = name;
			maxY = y;
			minY = y - 150;
			if (type == 0 || 1 == 0)
			{
				maxX = x + 20;
				minX = x;
			}
			else
			{
				switch (type)
				{
				case 1:
					maxX = x;
					minX = x - 20;
					break;
				case 2:
					maxX = x + 100;
					minX = x - 100;
					break;
				}
			}
			w = 330;
			if (minX != 0 && 0 == 0)
			{
				this.x = minX - w - 20;
			}
			else
			{
				this.x = maxX + 20;
			}
			this.y = minY - 130;
			if (type == 2)
			{
				this.x = x - w / 2;
				this.y = minY - 100;
			}
			h = 75;
			Class0.list_0.Add(this);
		}

		public void method_0(GClass68 g)
		{
			if (isShow && 0 == 0)
			{
				g.method_18(0, 0.5f);
				g.method_9(x, y, w, h, 10);
				GClass67.gclass67_0.method_1(g, name, x + w / 2, y + 18, 2);
			}
		}

		public void method_1()
		{
			if (type == 1)
			{
				if (GClass25.gclass25_0.x >= x - 200 && GClass25.gclass25_0.y >= y - 200)
				{
					isShow = true;
				}
				else
				{
					isShow = false;
				}
			}
			else if (type == 0 || 1 == 0)
			{
				if (GClass25.gclass25_0.x <= x + w + 200 && GClass25.gclass25_0.y >= y - 200)
				{
					isShow = true;
				}
				else
				{
					isShow = false;
				}
			}
			else if (type == 2)
			{
				if (GClass25.gclass25_0.x >= x - 200 && GClass25.gclass25_0.x <= x + w + 200 && GClass25.gclass25_0.y >= y - 200)
				{
					isShow = true;
				}
				else
				{
					isShow = false;
				}
			}
		}
	}
}
