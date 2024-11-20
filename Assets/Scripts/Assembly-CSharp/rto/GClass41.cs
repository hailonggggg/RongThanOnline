namespace rto
{
	public class GClass41
	{
		public GClass66 img;

		public int id;

		public GClass41(GClass66 img, int id)
		{
			this.img = img;
			this.id = id;
		}

		public void method_0(GClass68 g, int transform, int x, int y, int anchor)
		{
			g.method_21(img, 0, 0, GClass68.smethod_0(img), GClass68.smethod_1(img), transform, x, y, anchor);
		}

		public void method_1(GClass68 g, float angle, int x, int y, int anchor)
		{
			g.method_22(img, 0, 0, GClass68.smethod_0(img), GClass68.smethod_1(img), angle, x, y, anchor);
		}

		public void method_2(GClass68 g, int transform, int f, int x, int y, int w, int h, int anchor)
		{
			method_3(g, transform, f, x, y, w, h, anchor, isClip: false);
		}

		public void method_3(GClass68 g, int transform, int f, int x, int y, int w, int h, int anchor, bool isClip)
		{
			if (GClass68.smethod_0(img) != 1)
			{
				g.method_23(img, 0, f * w, w, h, transform, x, y, anchor, isClip);
			}
		}
	}
}
