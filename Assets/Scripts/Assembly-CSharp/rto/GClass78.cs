namespace rto
{
	public class GClass78
	{
		public static bool bool_0;

		private static string string_0;

		private static string string_1;

		public static int int_0;

		public static bool bool_1;

		public static int int_1;

		public static int int_2;

		public static int int_3;

		public static int int_4;

		static GClass78()
		{
			int_3 = 300;
			int_4 = 100;
			int_1 = (GClass69.int_1 - int_3) / 2;
			int_2 = 15;
		}

		public static void smethod_0(string title, string subtitle, int delay)
		{
			if (title != null && 0 == 0)
			{
				bool_0 = true;
				string_0 = title;
				string_1 = subtitle;
				int_0 = delay;
			}
		}

		public static void smethod_1()
		{
			smethod_0(GClass83.string_17, null, 1000);
			bool_1 = true;
		}

		public static void smethod_2(GClass68 g)
		{
			if (!bool_0 || false || (bool_1 && 0 == 0 && int_0 > 4990))
			{
				return;
			}
			if (bool_1 && 0 == 0)
			{
				GClass69.smethod_5(GClass69.int_1 / 2, GClass69.int_2 / 2, g);
				return;
			}
			g.method_18(0, 0.5f);
			g.method_9(int_1, int_2, int_3, int_4, 16);
			int num = GClass67.gclass67_0.method_7();
			if (string_1 != null && 0 == 0)
			{
				int num2 = int_2 + (int_4 - 2 * num) / 2;
				GClass67.gclass67_0.method_1(g, string_0, int_1 + int_3 / 2, num2 + 2, 2);
				GClass67.gclass67_0.method_1(g, string_1, int_1 + int_3 / 2, num2 + num, 2);
			}
			else
			{
				GClass67.gclass67_0.method_1(g, string_0, int_1 + int_3 / 2, int_2 + (int_4 - num) / 2, 2);
			}
		}

		public static void smethod_3(GClass68 g, int x, int y, int w, int h)
		{
			g.method_11(0);
			g.method_8(x, y, w, h, 16, 16, 16, 16);
			g.method_11(16777215);
			g.method_8(x + 3, y + 3, w - 6, h - 6, 13, 13, 13, 13);
		}

		public static void smethod_4()
		{
			if (int_0 > 0)
			{
				int_0--;
				if (int_0 == 0 || 1 == 0)
				{
					smethod_5();
				}
			}
		}

		public static void smethod_5()
		{
			string_0 = string.Empty;
			string_1 = null;
			bool_1 = false;
			int_0 = 0;
			bool_0 = false;
		}
	}
}
