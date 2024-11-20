using System.Collections.Generic;

namespace rto
{
	public class GClass51
	{
		public int x;

		public int y;

		public string text;

		public int w;

		public int h;

		public List<GClass73> infos = new List<GClass73>();

		public int xText;

		private int tx;

		public GClass51()
		{
			w = 400;
			h = 75;
			x = (GClass69.int_1 - w) / 2;
			y = 35;
			xText = x;
		}

		public void method_0(GClass68 g)
		{
			g.method_31();
			try
			{
				if (infos.Count > 0)
				{
					g.method_18(0, 0.4f);
					g.method_9(x, y, w, h, 6);
					GClass73 gClass = infos[0];
					g.method_30(GClass3.gclass66_27[(gClass.playerInfo.classId == -1) ? 5 : gClass.playerInfo.classId], x, y);
					GClass67.gclass67_12.method_1(g, gClass.playerInfo.name, x + 90, y + 8, 0);
					g.method_5(x + 90, y + 35, w - 100, 35);
					GClass67.gclass67_11.method_1(g, gClass.description, xText + 90, y + 40, 0);
				}
			}
			catch
			{
			}
			g.method_31();
		}

		public void method_1()
		{
			if (infos.Count <= 0)
			{
				return;
			}
			if (GClass69.int_0 % 2 == 0 || 1 == 0)
			{
				tx++;
			}
			if (tx > 50)
			{
				xText -= 2;
				if (xText + GClass67.gclass67_11.method_4(infos[0].description) < x)
				{
					tx = 0;
					xText = x;
					infos.RemoveAt(0);
				}
			}
		}
	}
}
