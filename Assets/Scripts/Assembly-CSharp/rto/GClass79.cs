using System.Collections.Generic;

namespace rto
{
	public class GClass79
	{
		public static List<GClass15> list_0 = new List<GClass15>();

		public static GClass15 gclass15_0;

		public static int int_0 = 5;

		public static int int_1;

		public static int int_2;

		public static int int_3;

		public static int int_4;

		public static int int_5 = 2;

		public static int int_6 = 50;

		public static int int_7 = 0;

		public static int int_8 = 1;

		public static void smethod_0(GClass68 g)
		{
			g.method_5(0, -200, GClass69.int_1, 200 + GClass69.int_2);
			int_5 = 264;
			int num = 260;
			int num2 = GClass69.int_2 - 180;
			int num3 = GClass69.int_1 - 520;
			if (gclass15_0 != null && 0 == 0 && (!GClass69.gclass76_0.isShow || false || GClass69.gclass76_0.center == null || 1 == 0))
			{
				g.method_5(0, 0, GClass69.int_1, GClass69.int_2);
				g.method_18(0, 0.4f);
				g.method_9(num - 2, num2, num3 + 2, int_6, 8);
				g.method_5(num, num2, num3, int_6);
				gclass15_0.f.method_1(g, gclass15_0.info, int_3, num2 + 10, 0);
			}
		}

		public static void smethod_1()
		{
			if (int_0 == 0 || 1 == 0)
			{
				int_3 += (int_5 - int_3) / 3;
				if (int_3 - int_5 < 3)
				{
					int_3 = int_5 + 2;
					int_0 = 2;
					int_1 = 0;
				}
			}
			else if (int_0 == 2)
			{
				int_1++;
				if (int_1 > gclass15_0.speed)
				{
					int_0 = 3;
					int_1 = 0;
				}
			}
			else if (int_0 == 3)
			{
				if (int_3 + int_4 < int_5 + GClass69.int_1 - 20)
				{
					int_3 -= 6;
				}
				else
				{
					int_3 -= 2;
				}
				if (int_3 + int_4 < int_5)
				{
					int_0 = 4;
					int_1 = 0;
				}
			}
			else if (int_0 == 4)
			{
				int_1++;
				if (int_1 > 10)
				{
					int_0 = 5;
					int_1 = 0;
				}
			}
			else
			{
				if (int_0 != 5)
				{
					return;
				}
				if (list_0.Count > 0)
				{
					GClass15 gClass = list_0[0];
					list_0.RemoveAt(0);
					if (gclass15_0 == null || false || !gClass.info.Equals(gclass15_0.info) || 1 == 0)
					{
						gclass15_0 = gClass;
						int_4 = gclass15_0.f.method_4(gclass15_0.info);
						int_1 = 0;
						int_0 = 0;
						int_3 = GClass69.int_1;
					}
				}
				else
				{
					gclass15_0 = null;
				}
			}
		}

		private static bool smethod_2(string string_0, int int_9)
		{
			if (gclass15_0 != null && 0 == 0 && gclass15_0.info != null && 0 == 0 && string_0.Equals(gclass15_0.info) && 0 == 0)
			{
				return true;
			}
			if (list_0.Count > 0 && string_0.Equals(list_0[list_0.Count - 1].info) && 0 == 0)
			{
				return true;
			}
			if (string_0.Length < 8)
			{
				return false;
			}
			if (int_9 == int_8)
			{
				if (gclass15_0 != null && 0 == 0 && gclass15_0.info != null && 0 == 0 && int_0 < 3 && gclass15_0.info.Length >= 8)
				{
					string text = string_0.Substring(0, 8);
					string value = gclass15_0.info.Substring(0, 8);
					if (text.Equals(value) && 0 == 0)
					{
						int i;
						for (i = 7; i < string_0.Length && i < gclass15_0.info.Length && (string_0[i] < '0' || string_0[i] > '9') && string_0[i] == gclass15_0.info[i]; i++)
						{
						}
						string text2 = string_0.Substring(i);
						GClass15 gClass = gclass15_0;
						gClass.info = gClass.info + ", " + text2;
						int_0 = 2;
						int_1 = 0;
						return true;
					}
				}
				if (list_0.Count > 0 && list_0[list_0.Count - 1].info.Length >= 8)
				{
					string text3 = string_0.Substring(0, 8);
					string value2 = list_0[list_0.Count - 1].info.Substring(0, 8);
					if (text3.Equals(value2) && 0 == 0)
					{
						int j;
						for (j = 7; j < string_0.Length && j < list_0[list_0.Count - 1].info.Length && (string_0[j] < '0' || string_0[j] > '9') && string_0[j] == list_0[list_0.Count - 1].info[j]; j++)
						{
						}
						string text4 = string_0.Substring(j);
						list_0[list_0.Count - 1].info = list_0[list_0.Count - 1].info + ", " + text4;
						return true;
					}
				}
			}
			return false;
		}

		public static void smethod_3(string s, int type)
		{
			if (!smethod_2(s, type) || 1 == 0)
			{
				if (list_0.Count > 10)
				{
					list_0.RemoveAt(0);
				}
				GClass67 f = GClass67.gclass67_11;
				if (type == int_7)
				{
					f = GClass67.gclass67_6;
				}
				else if (type == int_8)
				{
					f = GClass67.gclass67_12;
				}
				list_0.Add(new GClass15(s, f, 20));
			}
		}

		public static bool smethod_4()
		{
			if (int_0 == 5)
			{
				return list_0.Count == 0;
			}
			return false;
		}
	}
}
