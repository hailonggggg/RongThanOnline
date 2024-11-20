using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using UnityEngine;

namespace rto
{
	public class GClass69 : GInterface1
	{
		public static bool bool_0;

		public static long long_0;

		public static long long_1;

		public static bool bool_1;

		public static GClass1 gclass1_0;

		public static int int_0;

		public static int int_1;

		public static int int_2;

		public static GClass4 gclass4_0;

		public static GClass2 gclass2_0;

		public static GClass80 gclass80_0;

		public static GClass76 gclass76_0;

		public static GClass66 gclass66_0;

		public static GClass69 gclass69_0;

		public static List<GClass18> list_0;

		public static List<GClass19> list_1;

		public static List<GClass31> list_2;

		public static GClass39[] gclass39_0;

		public static List<GClass8> list_3;

		public static List<GClass20> list_4;

		public static GClass6 gclass6_0;

		public static int int_3;

		public static bool bool_2;

		public static int int_4;

		public static int int_5;

		public static int int_6;

		public static int int_7;

		public static GClass66[] gclass66_1;

		public static GClass66 gclass66_2;

		static GClass69()
		{
			bool_0 = true;
			int_1 = Screen.width;
			int_2 = Screen.height;
			gclass76_0 = new GClass76();
			gclass69_0 = new GClass69();
			gclass80_0 = new GClass80();
			gclass1_0 = new GClass5();
			gclass6_0 = new GClass6();
			gclass66_1 = new GClass66[8];
			for (int i = 0; i < gclass66_1.Length; i++)
			{
				gclass66_1[i] = smethod_9("imgLoading" + i);
			}
			gclass66_2 = smethod_9("imgWait");
			gclass66_0 = smethod_9("imgLogo.png");
			Class0.int_9 = int_1 / 5;
			Class0.int_10 = int_2 / 5;
			Class0.int_11 = int_1 - Class0.int_9;
			int num = GClass64.smethod_8("isPlaySound");
			if (num == -1)
			{
				bool_0 = true;
			}
			else
			{
				bool_0 = num == 1;
			}
		}

		public static void smethod_0()
		{
			list_2 = JsonConvert.DeserializeObject<List<GClass31>>(GClass84.smethod_0("Parts"));
			gclass39_0 = JsonConvert.DeserializeObject<GClass39[]>(GClass84.smethod_0("SkillPaints"));
			list_3 = JsonConvert.DeserializeObject<List<GClass8>>(GClass84.smethod_0("MobDarts"));
			Class0.smethod_0();
		}

		public static void smethod_1()
		{
			if (!GClass65.smethod_10() || 1 == 0)
			{
				GClass65.smethod_1(GClass70.string_2, GClass70.int_0);
			}
		}

		public static void smethod_2()
		{
			int_0++;
			if (int_0 > 10000)
			{
				int_0 = 0;
			}
			try
			{
				for (int i = 0; i < GClass42.dictionary_1.Count; i++)
				{
					if (GClass84.smethod_1() - GClass42.dictionary_1[i] > 1000L)
					{
						GClass42.dictionary_1[i] = GClass84.smethod_1();
						GClass0.smethod_34(GClass42.dictionary_1.ElementAt(i).Key);
					}
				}
			}
			catch
			{
			}
			try
			{
				if (gclass1_0 != null && 0 == 0)
				{
					gclass1_0.vmethod_3();
				}
				if (gclass1_0 != null && 0 == 0)
				{
					if (gclass76_0.isShow && 0 == 0)
					{
						gclass76_0.method_5();
					}
					else if (gclass80_0.isShow && 0 == 0)
					{
						gclass80_0.method_4();
					}
					if (gclass6_0.isShow && 0 == 0)
					{
						gclass6_0.method_42();
					}
					if (!bool_1 || 1 == 0)
					{
						gclass1_0.vmethod_0();
					}
				}
				GClass78.smethod_4();
			}
			catch
			{
			}
		}

		public static void smethod_3(GClass68 g)
		{
			try
			{
				if (gclass1_0 != null && 0 == 0)
				{
					gclass1_0.vmethod_1(g);
				}
				g.method_1(-g.method_3(), -g.method_4());
				g.method_5(0, 0, int_1, int_2);
				if (gclass6_0.isShow && 0 == 0)
				{
					gclass6_0.method_0(g);
				}
				g.method_1(-g.method_3(), -g.method_4());
				g.method_5(0, 0, int_1, int_2);
				GClass78.smethod_2(g);
				if (gclass76_0.isShow && 0 == 0)
				{
					gclass76_0.method_0(g);
				}
				else if (gclass80_0.isShow && 0 == 0)
				{
					gclass80_0.method_3(g);
				}
				GClass79.smethod_0(g);
				if ((GClass25.bool_0 ? true : false) || GClass25.bool_8)
				{
					smethod_4(g);
				}
				smethod_6(g);
			}
			catch
			{
			}
		}

		public static void smethod_4(GClass68 g)
		{
			g.method_31();
			g.method_11(0);
			g.method_7(0, 0, int_1, int_2);
			smethod_5(int_1 / 2, int_2 / 2, g);
		}

		public static void smethod_5(int x, int y, GClass68 g)
		{
			g.method_31();
			g.method_18(0, 0.5f);
			g.method_7(0, 0, int_1, int_2);
			g.method_28(gclass66_2, x, y, GClass68.int_0 | GClass68.int_1);
			g.method_28(gclass66_1[Main.int_1], x, y, GClass68.int_0 | GClass68.int_1);
		}

		public static void smethod_6(GClass68 g)
		{
			g.method_1(-g.method_3(), -g.method_4());
			g.method_5(0, 0, int_1, int_2);
		}

		public static void smethod_7(GClass68 g)
		{
			if (!GClass25.bool_0)
			{
				g.method_31();
				g.method_11(999999999);
				g.method_7(0, 0, int_1, int_2);
			}
		}

		public static void smethod_8(GClass68 g)
		{
			if (GClass25.bool_0)
			{
				return;
			}
			g.method_1(-g.method_3(), -g.method_4());
			Graphics.DrawTexture(new Rect(0f, 0f, int_1, int_2), GClass4.gclass66_0.texture);
			int_3++;
			for (int i = -(int_3 >> 4); i < int_1; i += 1440)
			{
				if (i > -1440)
				{
					g.method_28(GClass2.gclass66_1, i, int_2, GClass45.int_4);
				}
			}
			for (int i = -(int_3 >> 5); i < int_1; i += 872)
			{
				if (i > -873)
				{
					g.method_28(GClass2.gclass66_2, i, 0, GClass45.int_1);
				}
			}
		}

		public static GClass66 smethod_9(string path)
		{
			path = smethod_10(path);
			GClass66 result = null;
			try
			{
				result = GClass66.smethod_1(path);
				return result;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
				return result;
			}
		}

		public static string smethod_10(string str)
		{
			string result = str;
			if (str.Contains(".png") && 0 == 0)
			{
				result = str.Replace(".png", string.Empty);
			}
			return result;
		}

		public static void smethod_11(KeyCode keyCode)
		{
			if (gclass76_0.isShow && 0 == 0)
			{
				gclass76_0.method_1(keyCode);
			}
			else if (gclass80_0.isShow && 0 == 0)
			{
				gclass80_0.method_5(keyCode);
			}
			else if (gclass6_0.isShow && 0 == 0)
			{
				gclass6_0.method_38(keyCode);
			}
			else if (gclass1_0 != null && 0 == 0)
			{
				gclass1_0.vmethod_4(keyCode);
			}
		}

		public static void smethod_12(int x, int y)
		{
			if (GClass84.smethod_1() - long_0 < 50L)
			{
				return;
			}
			long_0 = GClass84.smethod_1();
			int_6 = x;
			int_7 = y;
			if (gclass76_0.isShow && 0 == 0)
			{
				gclass76_0.method_3(x, y);
			}
			else if (gclass80_0.isShow && 0 == 0)
			{
				gclass80_0.method_7(x, y);
			}
			else if (gclass6_0.isShow && 0 == 0)
			{
				gclass6_0.method_36(x, y);
			}
			else if (gclass1_0 != null && 0 == 0)
			{
				if (gclass1_0 == GClass3.smethod_0() && GClass3.smethod_0().gamePad != null && 0 == 0)
				{
					GClass3.smethod_0().gamePad.x = 100 + GClass3.smethod_0().gamePad.width / 2;
					GClass3.smethod_0().gamePad.y = int_2 - 75 - GClass3.smethod_0().gamePad.height / 2;
					GClass3.smethod_0().gamePad.method_4(x, y);
				}
				gclass1_0.vmethod_6(x, y);
			}
		}

		public static void smethod_13(int x, int y)
		{
			if (GClass84.smethod_1() - long_1 < 50L)
			{
				return;
			}
			long_1 = GClass84.smethod_1();
			int_4 = x;
			int_5 = y;
			if (gclass76_0.isShow && 0 == 0)
			{
				gclass76_0.method_2(x, y);
			}
			else if (gclass80_0.isShow && 0 == 0)
			{
				gclass80_0.method_6(x, y);
			}
			else if (gclass6_0.isShow && 0 == 0)
			{
				gclass6_0.method_35(x, y);
			}
			else
			{
				if (gclass1_0 == null)
				{
					return;
				}
				if (gclass1_0 == GClass3.smethod_0() && GClass3.smethod_0().gamePad != null && 0 == 0)
				{
					if (x < 300 + GClass3.smethod_0().gamePad.width / 2 && y > int_2 - 275 - GClass3.smethod_0().gamePad.height / 2)
					{
						GClass3.smethod_0().gamePad.x = x;
						GClass3.smethod_0().gamePad.y = y;
					}
					GClass3.smethod_0().gamePad.method_2(x, y);
				}
				gclass1_0.vmethod_5(x, y);
			}
		}

		public static void smethod_14(int x, int y)
		{
			if (gclass76_0.isShow && 0 == 0)
			{
				gclass76_0.method_4(x, y);
			}
			else if (gclass80_0.isShow && 0 == 0)
			{
				gclass80_0.method_8(x, y);
			}
			else if (gclass6_0.isShow && 0 == 0)
			{
				gclass6_0.method_37(x, y);
			}
			else if (gclass1_0 != null && 0 == 0)
			{
				if (gclass1_0 == GClass3.smethod_0() && GClass3.smethod_0().gamePad != null && 0 == 0)
				{
					GClass3.smethod_0().gamePad.method_3(x, y);
				}
				gclass1_0.vmethod_7(x, y);
			}
		}

		public static void smethod_15(int a)
		{
			if (gclass6_0 != null && 0 == 0 && gclass6_0.isShow && 0 == 0)
			{
				gclass6_0.method_39(a);
			}
		}

		public void imethod_0(int idAction, object p)
		{
			switch (idAction)
			{
			case 2:
				gclass76_0.method_7();
				Application.OpenURL(GClass70.string_4);
				GClass70.smethod_0();
				break;
			case 1:
				gclass76_0.method_7();
				break;
			}
		}

		public static void smethod_16(string info)
		{
			gclass76_0.method_8(info, null, new GClass72(GClass83.string_18, gclass69_0, 1, null), null);
		}

		public static void smethod_17(string info)
		{
			gclass76_0.method_8(info, null, new GClass72(GClass83.string_18, gclass69_0, 2, null), null);
		}

		public static void smethod_18(string info)
		{
			gclass76_0.method_8(info, null, new GClass72(GClass83.string_19, gclass69_0, 1, null), null);
		}

		public static void smethod_19(string info, bool isError)
		{
			gclass76_0.method_8(info, null, new GClass72(GClass83.string_19, gclass69_0, 1, null), null);
		}

		public static void smethod_20(string info, GClass72 yes, GClass72 no)
		{
			gclass76_0.method_8(info, yes, null, no);
		}

		public static void smethod_21()
		{
			GClass25.bool_0 = true;
		}
	}
}
