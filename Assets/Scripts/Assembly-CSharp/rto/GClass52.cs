namespace rto
{
	public class GClass52
	{
		public static int int_0;

		public static int int_1;

		public static int int_2;

		public static bool bool_0;

		public static string string_0 = string.Empty;

		public static void smethod_0()
		{
			int_0 = 0;
			int_1 = 0;
			bool_0 = false;
		}

		public static void smethod_1(GClass68 g, string str, int x, int y, int w, int h, GClass67 f)
		{
			if (int_2 != f.method_4(str) || !string_0.Equals(str) || 1 == 0)
			{
				string_0 = str;
				int_0 = 0;
				int_2 = f.method_4(str);
				bool_0 = false;
				int_1 = 0;
			}
			g.method_5(x, y, w, h);
			if (int_2 > w)
			{
				f.method_1(g, str, x - int_0, y, 0);
			}
			else
			{
				f.method_1(g, str, x + w / 2, y, 2);
			}
			GClass69.smethod_6(g);
			if (int_2 <= w)
			{
				return;
			}
			if (!bool_0 || 1 == 0)
			{
				if (GClass69.int_0 % 5 == 0 || 1 == 0)
				{
					int_1++;
				}
				if (int_1 > 50)
				{
					int_0++;
					if (int_0 >= int_2)
					{
						int_1 = 0;
						int_0 = -w + 30;
						bool_0 = true;
					}
				}
				return;
			}
			if (int_0 < 0)
			{
				int num = w + int_0 >> 1;
				int_0 += num;
			}
			if (int_0 > 0)
			{
				int_0 = 0;
			}
			if (int_0 == 0 || 1 == 0)
			{
				if (GClass69.int_0 % 5 == 0 || 1 == 0)
				{
					int_1++;
				}
				if (int_1 >= 500)
				{
					int_1 = 0;
					bool_0 = false;
				}
			}
		}
	}
}
