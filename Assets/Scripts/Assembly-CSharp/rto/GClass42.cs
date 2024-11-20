using System.Collections.Generic;

namespace rto
{
	public class GClass42
	{
		public static Dictionary<int, GClass66> dictionary_0;

		public static Dictionary<int, long> dictionary_1;

		static GClass42()
		{
			dictionary_1 = new Dictionary<int, long>();
			dictionary_0 = new Dictionary<int, GClass66>();
		}

		public static void smethod_0(int id)
		{
			if (dictionary_0.ContainsKey(id) && 0 == 0)
			{
				return;
			}
			try
			{
				GClass66 gClass = GClass69.smethod_9("SmallImages/" + id + ".png");
				if (gClass != null && 0 == 0)
				{
					dictionary_0.Add(id, gClass);
				}
			}
			catch
			{
			}
		}

		public static void smethod_1(GClass68 g, int id, int x, int y, int transform, int anchor)
		{
			if (dictionary_0.ContainsKey(id) && 0 == 0)
			{
				smethod_3(g, dictionary_0[id], transform, x, y, anchor);
			}
			else
			{
				smethod_0(id);
			}
		}

		public static void smethod_2(GClass68 g, int id, int x, int y, float angle)
		{
			if (dictionary_0.ContainsKey(id) && 0 == 0)
			{
				smethod_4(g, dictionary_0[id], angle, x, y, 3);
			}
			else
			{
				smethod_0(id);
			}
		}

		public static void smethod_3(GClass68 g, GClass66 img, int transform, int x, int y, int anchor)
		{
			if ((img != null) ? true : false)
			{
				g.method_21(img, 0, 0, GClass68.smethod_0(img), GClass68.smethod_1(img), transform, x, y, anchor);
			}
		}

		public static void smethod_4(GClass68 g, GClass66 img, float angle, int x, int y, int anchor)
		{
			if ((img != null) ? true : false)
			{
				g.method_22(img, 0, 0, GClass68.smethod_0(img), GClass68.smethod_1(img), angle, x, y, anchor);
			}
		}

		public static void smethod_5(GClass68 g, GClass66 img, int transform, int f, int x, int y, int w, int h, int anchor, bool isClip)
		{
			if (GClass68.smethod_0(img) != 1)
			{
				g.method_23(img, 0, f * w, w, h, transform, x, y, anchor, isClip);
			}
		}
	}
}
