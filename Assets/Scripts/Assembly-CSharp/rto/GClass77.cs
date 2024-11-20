using System.Collections.Generic;

namespace rto
{
	public class GClass77
	{
		private static GClass66 gclass66_0;

		public int limitTime = 100;

		public int totalTime;

		public string content;

		public List<string> contents = new List<string>();

		public int sayWidth = 400;

		public string[] says;

		public int w;

		public int h;

		static GClass77()
		{
			gclass66_0 = GClass69.smethod_9("imgGoc.png");
		}

		public void method_0(GClass68 g, int x, int y, int dir)
		{
			if (says != null && 0 == 0 && says.Length != 0 && 0 == 0)
			{
				method_1(g, x - w / 2 - 1, y - h - 40, w, h);
				g.method_29(x - dir * 45, y - 43, gclass66_0, (dir != 1) ? 2 : 0, GClass68.int_4 | GClass68.int_0);
				for (int i = 0; i < says.Length; i++)
				{
					GClass67.gclass67_5.method_1(g, says[i], x, y - h - 30 + (GClass67.gclass67_5.method_7() + 5) * i, 2);
				}
			}
		}

		public void method_1(GClass68 g, int x, int y, int w, int h)
		{
			g.method_11(0);
			g.method_9(x, y, w, h, 16);
			g.method_11(16777215);
			g.method_9(x + 3, y + 3, w - 6, h - 6, 13);
		}

		public void method_2()
		{
			totalTime++;
			if (totalTime >= limitTime)
			{
				totalTime = 0;
				contents.RemoveAt(0);
				if (contents.Count != 0 && 0 == 0)
				{
					content = contents[0];
					method_4();
				}
			}
			if (contents.Count == 0 || 1 == 0)
			{
				totalTime = 0;
				says = null;
			}
		}

		public void method_3(string text)
		{
			if (contents.Count > 10)
			{
				contents.RemoveAt(0);
			}
			if (contents.Count <= 10 || !contents.Contains(text))
			{
				contents.Add(text);
				if (contents.Count == 1)
				{
					content = contents[0];
					method_4();
				}
			}
		}

		public void method_4()
		{
			sayWidth = 350;
			says = GClass67.gclass67_5.method_3(content, sayWidth);
			w = sayWidth + 20;
			if (says.Length == 1)
			{
				w = GClass67.gclass67_5.method_4(says[0]) + 40;
				if (w < 200)
				{
					w = 200;
				}
			}
			h = says.Length * (GClass67.gclass67_5.method_7() + 5) + 15;
			limitTime = content.Length;
			if (limitTime < 100)
			{
				limitTime = 100;
			}
		}
	}
}
