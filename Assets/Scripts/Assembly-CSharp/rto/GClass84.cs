using System;
using UnityEngine;

namespace rto
{
	public class GClass84
	{
		public static System.Random random_0;

		private static int[] int_0;

		private static short[] short_0;

		private static short[] short_1;

		static GClass84()
		{
			random_0 = new System.Random();
			short_0 = new short[91]
			{
				0, 18, 36, 54, 71, 89, 107, 125, 143, 160,
				178, 195, 213, 230, 248, 265, 282, 299, 316, 333,
				350, 367, 384, 400, 416, 433, 449, 465, 481, 496,
				512, 527, 543, 558, 573, 587, 602, 616, 630, 644,
				658, 672, 685, 698, 711, 724, 737, 749, 761, 773,
				784, 796, 807, 818, 828, 839, 849, 859, 868, 878,
				887, 896, 904, 912, 920, 928, 935, 943, 949, 956,
				962, 968, 974, 979, 984, 989, 994, 998, 1002, 1005,
				1008, 1011, 1014, 1016, 1018, 1020, 1022, 1023, 1023, 1024,
				1024
			};
			short_1 = new short[91];
			int_0 = new int[91];
			for (int i = 0; i <= 90; i++)
			{
				short_1[i] = short_0[90 - i];
				if (short_1[i] == 0 || 1 == 0)
				{
					int_0[i] = int.MaxValue;
				}
				else
				{
					int_0[i] = (short_0[i] << 10) / short_1[i];
				}
			}
		}

		public static string smethod_0(string filename)
		{
			return ((TextAsset)Resources.Load("Jsons/" + filename, typeof(TextAsset))).text;
		}

		public static long smethod_1()
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return (DateTime.UtcNow.Ticks - dateTime.Ticks) / 10000L;
		}

		public static sbyte[] smethod_2(byte[] scr)
		{
			sbyte[] array = new sbyte[scr.Length];
			for (int i = 0; i < scr.Length; i++)
			{
				array[i] = (sbyte)scr[i];
			}
			return array;
		}

		public static byte[] smethod_3(sbyte[] data)
		{
			byte[] array = new byte[data.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)data[i];
			}
			return array;
		}

		public static char[] smethod_4(sbyte[] data)
		{
			char[] array = new char[data.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (char)data[i];
			}
			return array;
		}

		public static int smethod_5(int x1, int y1, int x2, int y2)
		{
			return smethod_6((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
		}

		public static int smethod_6(int a)
		{
			if (a <= 0)
			{
				return 0;
			}
			int num = (a + 1) / 2;
			int num2;
			do
			{
				num2 = num;
				num = num / 2 + a / (2 * num);
			}
			while (Math.Abs(num2 - num) > 1);
			return num;
		}

		public static string smethod_7(long number)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			empty = string.Empty;
			if (number >= 1000000000L)
			{
				empty2 = "Tỉ";
				long num = number % 1000000000L / 100000000L;
				number /= 1000000000L;
				empty = number + string.Empty;
				if (num > 0L)
				{
					return empty + "," + num + empty2;
				}
				return empty + empty2;
			}
			if (number >= 1000000L)
			{
				empty2 = "Tr";
				long num2 = number % 1000000L / 100000L;
				number /= 1000000L;
				empty = number + string.Empty;
				if (num2 > 0L)
				{
					return empty + "," + num2 + empty2;
				}
				return empty + empty2;
			}
			if (number >= 1000L)
			{
				empty2 = "K";
				long num3 = number % 100000L / 100000L;
				number /= 1000L;
				empty = number + string.Empty;
				if (num3 > 0L)
				{
					return empty + "," + num3 + empty2;
				}
				return empty + empty2;
			}
			return smethod_16(number);
		}

		public static int smethod_8(int start, int end)
		{
			return random_0.Next(start, end + 1);
		}

		public static sbyte[] smethod_9(GClass62 dos)
		{
			try
			{
				sbyte[] data = new sbyte[dos.method_6()];
				dos.method_13(ref data);
				return data;
			}
			catch (Exception)
			{
				Debug.Log("LOI DOC readByteArray dos");
			}
			return null;
		}

		public static sbyte[] smethod_10(GClass61 msg)
		{
			try
			{
				sbyte[] data = new sbyte[msg.method_1().method_6()];
				msg.method_1().method_13(ref data);
				return data;
			}
			catch (Exception)
			{
				Debug.Log("LOI DOC readByteArray NINJAUTIL");
			}
			return null;
		}

		public static int smethod_11(int a)
		{
			int num = 0;
			while (true)
			{
				if (num <= 90)
				{
					if (int_0[num] >= a)
					{
						break;
					}
					num++;
					continue;
				}
				return 0;
			}
			return num;
		}

		public static int smethod_12(int dx, int dy)
		{
			int num;
			if (dx != 0 && 0 == 0)
			{
				num = smethod_11(Math.Abs((dy << 10) / dx));
				if (dy >= 0 && dx < 0)
				{
					num = 180 - num;
				}
				if (dy < 0 && dx < 0)
				{
					num = 180 + num;
				}
				if (dy < 0 && dx >= 0)
				{
					num = 360 - num;
				}
			}
			else
			{
				num = ((dy <= 0) ? 270 : 90);
			}
			return num;
		}

		public static int smethod_13(int a)
		{
			a = smethod_15(a);
			if (a >= 0 && a < 90)
			{
				return short_0[a];
			}
			if (a >= 90 && a < 180)
			{
				return short_0[180 - a];
			}
			if (a >= 180 && a < 270)
			{
				return -short_0[a - 180];
			}
			return -short_0[360 - a];
		}

		public static int smethod_14(int a)
		{
			a = smethod_15(a);
			if (a >= 0 && a < 90)
			{
				return short_1[a];
			}
			if (a >= 90 && a < 180)
			{
				return -short_1[180 - a];
			}
			if (a >= 180 && a < 270)
			{
				return -short_1[a - 180];
			}
			return short_1[360 - a];
		}

		public static int smethod_15(int angle)
		{
			if (angle >= 360)
			{
				angle -= 360;
			}
			if (angle < 0)
			{
				angle += 360;
			}
			return angle;
		}

		public static string smethod_16(long m)
		{
			string text = string.Empty;
			long num = m / 1000L + 1L;
			for (int i = 0; i < num; i++)
			{
				if (m >= 1000L)
				{
					long num2 = m % 1000L;
					text = (((num2 != 0L) ? true : false) ? ((num2 >= 10L) ? ((num2 >= 100L) ? ("." + num2 + text) : (".0" + num2 + text)) : (".00" + num2 + text)) : (".000" + text));
					m /= 1000L;
					continue;
				}
				text = m + text;
				break;
			}
			return text;
		}

		public static sbyte[] smethod_17(byte[] data)
		{
			sbyte[] array = new sbyte[data.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (sbyte)data[i];
			}
			return array;
		}

		public static byte[] smethod_18(sbyte[] data)
		{
			byte[] array = new byte[data.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = (byte)data[i];
			}
			return array;
		}
	}
}
