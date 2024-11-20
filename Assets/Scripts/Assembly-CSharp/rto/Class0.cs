using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	internal class Class0
	{
		public static int int_0;

		public static int int_1;

		public static int int_2;

		public static int int_3;

		public static sbyte sbyte_0;

		public static int int_4;

		public static int int_5;

		public static int int_6;

		public static int int_7;

		public static int[,] int_8;

		public static List<GClass53> list_0;

		public static GClass66[] gclass66_0;

		public static GClass66[] gclass66_1;

		public static GClass66 gclass66_2;

		public static string string_0;

		public static string string_1;

		public static Dictionary<int, GClass66> dictionary_0;

		public static GClass26 gclass26_0;

		public static bool bool_0;

		public static int int_9;

		public static int int_10;

		public static int int_11;

		public static int int_12;

		public static int int_13;

		public static int int_14;

		public static GClass66 gclass66_3;

		public static Dictionary<int, GClass26> dictionary_1;

		static Class0()
		{
			sbyte_0 = 72;
			dictionary_0 = new Dictionary<int, GClass66>();
			bool_0 = true;
			dictionary_1 = new Dictionary<int, GClass26>();
			gclass66_3 = GClass69.smethod_9("imgGocMiniMap.png");
		}

		public static void smethod_0()
		{
			gclass66_2 = GClass69.smethod_9("imgBong.png");
			list_0 = new List<GClass53>();
		}

		public static void smethod_1(GClass68 gclass68_0)
		{
			if (!GClass25.bool_0)
			{
				gclass68_0.method_12(gclass26_0.colorsBgr[0, 0], gclass26_0.colorsBgr[0, 1], gclass26_0.colorsBgr[0, 2]);
				gclass68_0.method_7(0, 0, GClass69.int_1, GClass69.int_2);
				for (int i = 0; i < GClass69.int_1; i += 735)
				{
					gclass68_0.method_28(dictionary_0[gclass26_0.imgsBgr[0]], i, GClass69.int_2 / 5 * 4, GClass45.int_4);
				}
				gclass68_0.method_12(gclass26_0.colorsBgr[1, 0], gclass26_0.colorsBgr[1, 1], gclass26_0.colorsBgr[1, 2]);
				gclass68_0.method_7(0, GClass69.int_2 / 5 * 4, GClass69.int_1, GClass69.int_2 / 5);
				int num = GClass69.int_2 - (GClass3.int_1 >> 1) / 2;
				for (int i = -(GClass3.int_0 >> 2); i < GClass69.int_1; i += 336)
				{
					gclass68_0.method_28(dictionary_0[gclass26_0.imgsBgr[1]], i, num, GClass45.int_4);
				}
				if (num < GClass69.int_2)
				{
					gclass68_0.method_12(gclass26_0.colorsBgr[2, 0], gclass26_0.colorsBgr[2, 1], gclass26_0.colorsBgr[2, 2]);
					gclass68_0.method_7(0, num, GClass69.int_1, GClass69.int_2 - num);
				}
				num = GClass69.int_2 - (GClass3.int_1 >> 1) / 2 + GClass69.int_2 / 5;
				for (int i = -(GClass3.int_0 >> 1); i < GClass69.int_1; i += 336)
				{
					gclass68_0.method_28(dictionary_0[gclass26_0.imgsBgr[2]], i, num, GClass45.int_4);
				}
				if (num < GClass69.int_2)
				{
					gclass68_0.method_12(gclass26_0.colorsBgr[3, 0], gclass26_0.colorsBgr[3, 1], gclass26_0.colorsBgr[3, 2]);
					gclass68_0.method_7(0, num, GClass69.int_1, GClass69.int_2 - num);
				}
				if (GClass44.int_0 > 0)
				{
					gclass68_0.method_28(gclass26_0.imgBgr, -GClass3.int_0 + GClass3.int_10[GClass44.int_0 % GClass3.int_10.Length], -GClass3.int_1 + GClass3.int_11[GClass44.int_0 % GClass3.int_11.Length], 0);
				}
				else
				{
					gclass68_0.method_28(gclass26_0.imgBgr, -GClass3.int_0, -GClass3.int_1, 0);
				}
				if (bool_0 && 0 == 0)
				{
					smethod_2(gclass68_0);
				}
			}
		}

		public static void smethod_2(GClass68 gclass68_0)
		{
			gclass68_0.method_31();
			gclass68_0.method_12(255f, 176f, 57f);
			gclass68_0.method_8(int_11 - 8, int_12, int_9 + 8, int_10 + 8, 0, 0, 10, 0);
			gclass68_0.method_12(155f, 37f, 1f);
			gclass68_0.method_7(int_11 - 3, int_12, int_9 + 3, int_10 + 3);
			gclass68_0.method_12(gclass26_0.colorsBgr[0, 0], gclass26_0.colorsBgr[0, 1], gclass26_0.colorsBgr[0, 2]);
			gclass68_0.method_7(int_11, int_12, int_9, int_10);
			gclass68_0.method_5(int_11, int_12, int_9, int_10);
			gclass68_0.method_28(gclass26_0.imgBgrMini, int_11 - int_13, -int_14, 0);
			gclass68_0.method_1(int_11 - int_13, -int_14);
			if (GClass25.gclass25_0.team != null && 0 == 0 && GClass25.gclass25_0.team.members.Count > 0)
			{
				using List<GClass25>.Enumerator enumerator = GClass3.list_1.GetEnumerator();
				while (enumerator.MoveNext() ? true : false)
				{
					GClass25 current = enumerator.Current;
					using List<GClass73>.Enumerator enumerator2 = GClass25.gclass25_0.team.members.GetEnumerator();
					while (enumerator2.MoveNext() ? true : false)
					{
						GClass73 current2 = enumerator2.Current;
						if (current.id == current2.playerInfo.id)
						{
							gclass68_0.method_11(16777215);
							gclass68_0.method_7(current.x / 8 - 5, int_12 + current.y / 8 - 10, 11, 11);
							gclass68_0.method_14(new Color(0f, 0.75f, 0f));
							gclass68_0.method_7(current.x / 8 - 3, int_12 + current.y / 8 - 8, 7, 7);
						}
					}
				}
			}
			gclass68_0.method_11(16777215);
			gclass68_0.method_7(GClass25.gclass25_0.x / 8 - 5, int_12 + GClass25.gclass25_0.y / 8 - 10, 11, 11);
			gclass68_0.method_11(16711680);
			gclass68_0.method_7(GClass25.gclass25_0.x / 8 - 3, int_12 + GClass25.gclass25_0.y / 8 - 8, 7, 7);
			gclass68_0.method_31();
			gclass68_0.method_28(gclass66_3, int_11 - 8, int_12 + int_10 + 8, GClass45.int_4);
			gclass68_0.method_18(0, 0.5f);
			gclass68_0.method_7(int_11, int_12, int_9, 40);
			GClass67.gclass67_14.method_1(gclass68_0, string_1 + " - Khu " + int_3, int_11 + int_9 / 2, int_12 + 5, 2);
		}

		public static bool smethod_3(int int_15, int int_16)
		{
			int num = int_15 / sbyte_0;
			int num2 = int_16 / sbyte_0;
			int num3 = 0;
			try
			{
				num3 = int_8[num2, num];
			}
			catch
			{
			}
			return num3 != 0;
		}

		public static int smethod_4(int int_15)
		{
			return int_15 / sbyte_0 * sbyte_0;
		}

		public static int smethod_5(int int_15)
		{
			return int_15 / sbyte_0 * sbyte_0;
		}
	}
}
