namespace rto
{
	public class GClass5 : GClass1
	{
		public static int int_0;

		private static bool bool_0;

		public static GClass66 gclass66_0;

		static GClass5()
		{
			gclass66_0 = GClass69.smethod_9("beemobi.png");
			int_0 = 0;
		}

		public override void vmethod_0()
		{
			if (int_0 == 30 && (!bool_0 || 1 == 0))
			{
				bool_0 = true;
				GClass69.smethod_1();
			}
			int_0++;
		}

		public override void vmethod_1(GClass68 g)
		{
			if (gclass66_0 != null && 0 == 0 && int_0 < 30)
			{
				g.method_11(16777215);
				g.method_7(0, 0, GClass69.int_1, GClass69.int_2);
				g.method_28(gclass66_0, GClass69.int_1 / 2, GClass69.int_2 / 2, 3);
			}
			if (int_0 >= 30)
			{
				g.method_11(0);
				g.method_7(0, 0, GClass69.int_1, GClass69.int_2);
				GClass69.smethod_5(GClass69.int_1 / 2, GClass69.int_2 / 2, g);
			}
		}
	}
}
