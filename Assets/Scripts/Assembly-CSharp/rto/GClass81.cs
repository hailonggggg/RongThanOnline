using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace rto
{
	public class GClass81
	{
		[CompilerGenerated]
		private sealed class Class1
		{
			public int playerId;

			internal bool method_0(GClass73 gclass73_0)
			{
				return gclass73_0.playerInfo.id == playerId;
			}
		}

		public static bool bool_0;

		public static bool bool_1;

		public static bool bool_2;

		public static bool bool_3;

		public static void smethod_0(GClass61 message)
		{
			try
			{
				switch (message.command)
				{
				case -127:
					if (message.method_1().method_11().Equals(GClass70.string_3))
					{
						if (GClass69.gclass4_0 == null)
						{
							GClass69.gclass4_0 = new GClass4();
						}
						GClass69.gclass4_0.vmethod_2();
					}
					else
					{
						GClass69.smethod_17(GClass83.string_37);
					}
					break;
				case -126:
					GClass78.smethod_5();
					GClass69.smethod_16(message.method_1().method_11());
					GClass25.bool_0 = false;
					break;
				case -119:
					if (GClass69.gclass2_0 == null)
					{
						GClass69.gclass2_0 = new GClass2();
					}
					GClass69.gclass2_0.vmethod_2();
					GClass25.bool_0 = false;
					break;
				case -118:
				{
					GClass43.smethod_28();
					GClass25.bool_0 = true;
					Class0.list_0.Clear();
					GClass3.list_0.Clear();
					GClass3.list_1.Clear();
					GClass3.list_2.Clear();
					GClass3.list_3.Clear();
					GClass3.list_5.Clear();
					if (GClass3.gclass72_0 != null)
					{
						GClass3.gclass72_0.isShow = false;
					}
					if (GClass25.gclass25_0.dart != null)
					{
						GClass25.gclass25_0.dart.method_2();
					}
					GClass28.list_0.Clear();
					int num30 = message.method_1().method_4();
					if (!Class0.dictionary_1.ContainsKey(num30))
					{
						Class0.gclass26_0 = new GClass26();
						Class0.gclass26_0.id = (Class0.int_0 = num30);
						Class0.gclass26_0.name = (Class0.string_1 = message.method_1().method_11());
						Class0.gclass26_0.row = (Class0.int_5 = message.method_1().method_4());
						Class0.gclass26_0.column = (Class0.int_4 = message.method_1().method_4());
						Class0.gclass26_0.data = (Class0.string_0 = message.method_1().method_11());
						for (int num31 = 0; num31 < 3; num31++)
						{
							int num32 = message.method_1().method_4();
							if (!Class0.dictionary_0.ContainsKey(num32))
							{
								Class0.dictionary_0.Add(num32, GClass69.smethod_9("Maps/Backgrounds/" + num32 + ".png"));
							}
							Class0.gclass26_0.imgsBgr.Add(num32);
						}
						for (int num33 = 0; num33 < 4; num33++)
						{
							for (int num34 = 0; num34 < 3; num34++)
							{
								Class0.gclass26_0.colorsBgr[num33, num34] = message.method_1().method_4();
							}
						}
						Class0.gclass26_0.imgBgr = GClass69.smethod_9("Maps/" + Class0.gclass26_0.id);
						Class0.gclass26_0.imgBgrMini = GClass69.smethod_9("Maps/MiniMaps/" + Class0.gclass26_0.id);
						Class0.dictionary_1.Add(num30, Class0.gclass26_0);
					}
					else
					{
						Class0.gclass26_0 = Class0.dictionary_1[num30];
						Class0.int_0 = Class0.gclass26_0.id;
						Class0.string_1 = Class0.gclass26_0.name;
						Class0.int_5 = Class0.gclass26_0.row;
						Class0.int_4 = Class0.gclass26_0.column;
						Class0.string_0 = Class0.gclass26_0.data;
					}
					GClass25.gclass25_0.cvx = 0;
					GClass25.gclass25_0.status = 4;
					GClass25.gclass25_0.mobFocus = null;
					GClass25.gclass25_0.playerFocus = null;
					GClass25.gclass25_0.npcFocus = null;
					GClass25.gclass25_0.itemFocus = null;
					GClass25.gclass25_0.skillPaint = null;
					GClass25.gclass25_0.isDead = false;
					GClass25.gclass25_0.isDead = false;
					Class0.int_8 = new int[Class0.int_5, Class0.int_4];
					string text = Class0.gclass26_0.data;
					for (int num35 = 0; num35 < Class0.int_5; num35++)
					{
						for (int num36 = 0; num36 < Class0.int_4; num36++)
						{
							Class0.int_8[num35, num36] = int.Parse(text.Substring(0, 1));
							text = text.Substring(1);
						}
					}
					Class0.int_6 = Class0.int_4 * Class0.sbyte_0;
					Class0.int_7 = Class0.int_5 * Class0.sbyte_0;
					Class0.int_3 = message.method_1().method_0();
					GClass25.gclass25_0.x = message.method_1().method_4();
					GClass25.gclass25_0.y = message.method_1().method_4();
					int num37 = message.method_1().method_0();
					for (int num38 = 0; num38 < num37; num38++)
					{
						Class0.list_0.Add(new GClass53(message.method_1().method_4(), message.method_1().method_4(), message.method_1().method_0(), message.method_1().method_11()));
					}
					int num39 = message.method_1().method_0();
					for (int num40 = 0; num40 < num39; num40++)
					{
						GClass24 gClass41 = new GClass24();
						gClass41.template = new GClass30();
						gClass41.template.id = message.method_1().method_0();
						gClass41.template.name = message.method_1().method_11();
						int num41 = message.method_1().method_0();
						for (int num42 = 0; num42 < num41; num42++)
						{
							gClass41.template.imgs.Add(message.method_1().method_4());
						}
						gClass41.x = message.method_1().method_4();
						gClass41.y = message.method_1().method_4();
						foreach (int img in gClass41.template.imgs)
						{
							GClass42.smethod_0(img);
						}
						try
						{
							gClass41.h = GClass42.dictionary_0[gClass41.template.imgs[0]].method_1();
							gClass41.w = GClass42.dictionary_0[gClass41.template.imgs[0]].method_0();
						}
						catch
						{
							gClass41.h = 110;
							gClass41.w = 110;
						}
						GClass3.list_2.Add(gClass41);
					}
					int num43 = message.method_1().method_0();
					for (int num44 = 0; num44 < num43; num44++)
					{
						GClass23 gClass42 = new GClass23();
						gClass42.template = new GClass27();
						gClass42.template.id = message.method_1().method_4();
						gClass42.template.name = message.method_1().method_11();
						gClass42.template.rangeMove = message.method_1().method_4();
						gClass42.template.speed = message.method_1().method_0();
						gClass42.template.type = message.method_1().method_0();
						gClass42.template.level = message.method_1().method_4();
						gClass42.template.dart = GClass69.list_3[message.method_1().method_0()];
						int num45 = message.method_1().method_0();
						for (int num46 = 0; num46 < num45; num46++)
						{
							gClass42.template.imgs.Add(message.method_1().method_4());
						}
						foreach (int img2 in gClass42.template.imgs)
						{
							GClass42.smethod_0(img2);
						}
						gClass42.id = message.method_1().method_0();
						gClass42.level = message.method_1().method_0();
						gClass42.xFirst = message.method_1().method_4();
						gClass42.yFirst = message.method_1().method_4();
						gClass42.maxHp = message.method_1().method_7();
						gClass42.hp = message.method_1().method_7();
						gClass42.status = message.method_1().method_0();
						gClass42.x = gClass42.xFirst;
						gClass42.y = gClass42.yFirst;
						gClass42.dir = ((gClass42.id % 2 == 1) ? 1 : (-1));
						try
						{
							gClass42.h = GClass42.dictionary_0[gClass42.template.imgs[0]].method_1();
							gClass42.w = GClass42.dictionary_0[gClass42.template.imgs[0]].method_0();
						}
						catch
						{
							gClass42.h = 80;
							gClass42.w = 80;
						}
						GClass3.list_0.Add(gClass42);
					}
					int num47 = message.method_1().method_4();
					for (int num48 = 0; num48 < num47; num48++)
					{
						GClass22 gClass43 = new GClass22();
						gClass43.id = message.method_1().method_6();
						gClass43.template = GClass69.list_1[message.method_1().method_4()];
						gClass43.x = (gClass43.xEnd = message.method_1().method_4());
						gClass43.y = (gClass43.yEnd = message.method_1().method_4());
						GClass42.smethod_0(gClass43.template.iconId);
						try
						{
							gClass43.h = GClass42.dictionary_0[gClass43.template.iconId].method_1();
							gClass43.w = GClass42.dictionary_0[gClass43.template.iconId].method_0();
						}
						catch
						{
							gClass43.h = 50;
							gClass43.w = 50;
						}
						GClass3.list_3.Add(gClass43);
					}
					if (GClass25.gclass25_0.y <= 10)
					{
						GClass25.gclass25_0.isSpaceship = true;
						GClass3.list_5.Add(new GClass44(GClass25.gclass25_0, 1));
					}
					GClass78.smethod_5();
					GClass78.smethod_0(Class0.string_1, GClass83.string_6 + ": " + Class0.int_3, 30);
					GClass25.bool_1 = false;
					GClass25.bool_0 = false;
					GClass25.bool_2 = false;
					GClass25.gclass25_0.isLockMove = false;
					GClass3.bool_0 = true;
					GClass69.gclass6_0.method_45();
					GClass3.smethod_5(GClass25.gclass25_0.x, GClass25.gclass25_0.y);
					GClass3.int_0 = GClass3.int_2;
					GClass3.int_1 = GClass3.int_3;
					GClass3.int_13 = 0;
					GClass3.bool_2 = false;
					GClass25.bool_4 = false;
					GClass25.bool_3 = false;
					GClass25.bool_5 = false;
					GClass25.bool_6 = false;
					GClass3.smethod_0().vmethod_2();
					break;
				}
				case -117:
				{
					GClass25 gClass44 = new GClass25();
					gClass44.id = message.method_1().method_6();
					gClass44.name = message.method_1().method_11();
					gClass44.gender = message.method_1().method_0();
					gClass44.sex = message.method_1().method_0();
					gClass44.classId = message.method_1().method_0();
					gClass44.head = message.method_1().method_4();
					gClass44.body = message.method_1().method_4();
					gClass44.leg = message.method_1().method_4();
					gClass44.mount = message.method_1().method_4();
					gClass44.x = message.method_1().method_4();
					gClass44.y = message.method_1().method_4();
					gClass44.xSd = gClass44.x;
					gClass44.ySd = gClass44.y;
					gClass44.maxHp = message.method_1().method_7();
					gClass44.hp = message.method_1().method_7();
					gClass44.typePk = message.method_1().method_0();
					gClass44.level = message.method_1().method_4();
					gClass44.spaceship = message.method_1().method_0();
					GClass25.smethod_2(gClass44);
					GClass25.smethod_1(gClass44);
					GClass25.smethod_0(gClass44);
					if (gClass44.y <= 10)
					{
						gClass44.isSpaceship = true;
						GClass44 gClass45 = new GClass44(gClass44, 1);
						gClass45.playerId = gClass44.id;
						GClass3.list_5.Add(gClass45);
					}
					else if (GClass3.smethod_6(gClass44.id) == null)
					{
						GClass3.list_1.Add(gClass44);
					}
					break;
				}
				case -116:
				{
					int num4 = message.method_1().method_6();
					int num5 = 0;
					while (true)
					{
						if (num5 < GClass3.list_1.Count)
						{
							if (GClass3.list_1[num5].id == num4)
							{
								break;
							}
							num5++;
							continue;
						}
						return;
					}
					if (GClass25.gclass25_0.playerFocus == GClass3.list_1[num5])
					{
						GClass25.gclass25_0.playerFocus = null;
						GClass25.bool_7 = false;
					}
					GClass3.list_1.RemoveAt(num5);
					break;
				}
				case -114:
					GClass3.smethod_6(message.method_1().method_6())?.method_37(message.method_1().method_4(), message.method_1().method_4());
					break;
				case -112:
				{
					int num49 = message.method_1().method_6();
					string info = message.method_1().method_11();
					if (GClass25.gclass25_0.id == num49)
					{
						GClass25.gclass25_0.method_48(info);
					}
					else
					{
						GClass3.smethod_6(num49)?.method_48(info);
					}
					break;
				}
				case -111:
				{
					int num29 = message.method_1().method_6();
					if (GClass25.gclass25_0.id == num29)
					{
						GClass73 item2 = new GClass73(GClass69.gclass6_0, 47, GClass25.gclass25_0, message.method_1().method_11());
						GClass6.list_6.Add(item2);
						GClass3.smethod_0().textGlobal.infos.Add(item2);
					}
					else
					{
						GClass25 gClass39 = new GClass25();
						gClass39.id = num29;
						gClass39.name = message.method_1().method_11();
						gClass39.classId = message.method_1().method_0();
						GClass73 item3 = new GClass73(GClass69.gclass6_0, 47, gClass39, message.method_1().method_11());
						GClass6.list_6.Add(item3);
						GClass3.smethod_0().textGlobal.infos.Add(item3);
					}
					if (GClass69.gclass6_0.isShow && GClass69.gclass6_0.type == 12)
					{
						GClass69.gclass6_0.method_41(12);
					}
					break;
				}
				case -109:
					smethod_4(message);
					break;
				case -107:
				{
					GClass25 gClass50 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass50 == null)
					{
						break;
					}
					switch (message.method_1().method_0())
					{
					case -1:
						gClass50.mobFocus = null;
						gClass50.playerFocus = null;
						break;
					case 0:
					{
						int num54 = message.method_1().method_6();
						if (GClass25.gclass25_0.id == num54)
						{
							gClass50.playerFocus = GClass25.gclass25_0;
						}
						else
						{
							gClass50.playerFocus = GClass3.smethod_6(num54);
						}
						if (gClass50.playerFocus != null)
						{
							gClass50.dir = ((gClass50.x < gClass50.playerFocus.x) ? 1 : (-1));
						}
						gClass50.mobFocus = null;
						break;
					}
					case 1:
						gClass50.mobFocus = GClass3.smethod_7(message.method_1().method_0());
						if (gClass50.mobFocus != null)
						{
							gClass50.dir = ((gClass50.x < gClass50.mobFocus.x) ? 1 : (-1));
						}
						gClass50.playerFocus = null;
						break;
					}
					gClass50.skillUseId = message.method_1().method_0();
					gClass50.skillUseType = message.method_1().method_0();
					gClass50.method_7(gClass50.skillUseId, message.method_1().method_0(), (!Class0.smethod_3(gClass50.x, gClass50.y)) ? 1 : 0);
					break;
				}
				case -106:
				{
					GClass23 gClass49 = GClass3.smethod_7(message.method_1().method_0());
					if (gClass49 == null)
					{
						break;
					}
					int num53 = message.method_1().method_6();
					if (num53 != 0)
					{
						gClass49.hp = message.method_1().method_7();
						if (message.method_1().method_8())
						{
							GClass3.smethod_1(GClass67.gclass67_21, "-" + num53, gClass49.x, gClass49.y - gClass49.imethod_3(), 0, -2);
						}
						else
						{
							GClass3.smethod_1(GClass67.gclass67_19, "-" + num53, gClass49.x, gClass49.y - gClass49.imethod_3(), 0, -2);
						}
					}
					else
					{
						GClass3.smethod_1(GClass67.gclass67_22, GClass83.string_3, gClass49.x, gClass49.y - gClass49.imethod_3(), 0, -2);
					}
					break;
				}
				case -105:
				{
					GClass23 gClass40 = GClass3.smethod_7(message.method_1().method_0());
					if (gClass40 != null)
					{
						gClass40.level = message.method_1().method_0();
						gClass40.maxHp = message.method_1().method_7();
						gClass40.hp = gClass40.maxHp;
						gClass40.x = gClass40.xFirst;
						gClass40.y = gClass40.yFirst;
						gClass40.injureThenDie = false;
						gClass40.status = 5;
					}
					break;
				}
				case -104:
				{
					GClass23 gClass23 = GClass3.smethod_7(message.method_1().method_0());
					if (gClass23 == null)
					{
						break;
					}
					GClass25 gClass24 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass24 != null)
					{
						gClass24.dir = ((gClass24.x < gClass23.x) ? 1 : (-1));
						gClass23.dir = ((gClass23.x < gClass24.x) ? 1 : (-1));
						gClass24.skillUseId = message.method_1().method_0();
						gClass24.method_7(gClass24.skillUseId, message.method_1().method_0(), (!Class0.smethod_3(gClass24.x, gClass24.y)) ? 1 : 0);
						gClass24.skillUseType = message.method_1().method_0();
						gClass24.playerFocus = null;
						gClass24.mobFocus = gClass23;
						gClass23.hp = message.method_1().method_7();
						int num16 = message.method_1().method_6();
						if (num16 == 0)
						{
							GClass3.smethod_1(GClass67.gclass67_22, GClass83.string_3, gClass23.x, gClass23.y - gClass23.imethod_3(), 0, -2);
						}
						else if (message.method_1().method_8())
						{
							GClass3.smethod_1(GClass67.gclass67_21, "-" + num16, gClass23.x, gClass23.y - gClass23.imethod_3(), 0, -2);
						}
						else
						{
							GClass3.smethod_1(GClass67.gclass67_19, "-" + num16, gClass23.x, gClass23.y - gClass23.imethod_3(), 0, -2);
						}
					}
					break;
				}
				case -102:
				{
					GClass23 gClass20 = GClass3.smethod_7(message.method_1().method_0());
					if (gClass20 != null)
					{
						gClass20.damage = message.method_1().method_6();
						gClass20.method_9(GClass25.gclass25_0);
					}
					break;
				}
				case -101:
				{
					GClass23 gClass2 = GClass3.smethod_7(message.method_1().method_0());
					if (gClass2 != null)
					{
						GClass25 gClass3 = GClass3.smethod_6(message.method_1().method_6());
						if (gClass3 != null)
						{
							gClass2.damage = message.method_1().method_6();
							gClass2.method_9(gClass3);
						}
					}
					break;
				}
				case -100:
				{
					GClass23 gClass48 = GClass3.smethod_7(message.method_1().method_0());
					if (gClass48 != null && gClass48.status != 0)
					{
						int num51 = message.method_1().method_6();
						bool num52 = message.method_1().method_8();
						gClass48.method_10();
						if (num52)
						{
							GClass3.smethod_1(GClass67.gclass67_21, "-" + num51, gClass48.x, gClass48.y - gClass48.imethod_3(), 0, -2);
						}
						else
						{
							GClass3.smethod_1(GClass67.gclass67_19, "-" + num51, gClass48.x, gClass48.y - gClass48.imethod_3(), 0, -2);
						}
					}
					break;
				}
				case -99:
				{
					GClass23 gClass34 = GClass3.smethod_7(message.method_1().method_0());
					if (gClass34 == null || gClass34.status == 0)
					{
						break;
					}
					GClass9 gClass35 = new GClass9(gClass34);
					gClass35.templateId = message.method_1().method_4();
					gClass35.type = message.method_1().method_0();
					gClass35.time = message.method_1().method_7();
					gClass35.timeEnd = DateTime.UtcNow.AddMilliseconds(gClass35.time);
					int num22 = message.method_1().method_0();
					gClass35.imgIds = new List<int>();
					for (int num23 = 0; num23 < num22; num23++)
					{
						gClass35.imgIds.Add(message.method_1().method_4());
					}
					foreach (int imgId in gClass35.imgIds)
					{
						GClass42.smethod_0(imgId);
					}
					gClass34.effects.Add(gClass35);
					break;
				}
				case -98:
					GClass25.gclass25_0.isDead = true;
					GClass25.gclass25_0.method_17(message.method_1().method_4(), message.method_1().method_4());
					break;
				case -96:
				{
					int num8 = message.method_1().method_6();
					GClass25 gClass13 = GClass25.gclass25_0;
					if (GClass25.gclass25_0.id != num8)
					{
						gClass13 = GClass3.smethod_6(num8);
					}
					if (gClass13 != null)
					{
						gClass13.x = message.method_1().method_4();
						gClass13.y = message.method_1().method_4();
						gClass13.hp = message.method_1().method_7();
						gClass13.mp = message.method_1().method_7();
						gClass13.status = 1;
						GClass25 gClass14 = gClass13;
						GClass25 gClass15 = gClass13;
						GClass25 gClass16 = gClass13;
						int num9 = 0;
						gClass16.cp3 = 0;
						num9 = 0;
						gClass15.cp2 = 0;
						gClass14.cp1 = 0;
						if (GClass25.gclass25_0.id == num8)
						{
							GClass3.gclass72_0.isShow = false;
							GClass3.bool_0 = true;
							GClass25.bool_2 = false;
							GClass25.gclass25_0.isLockMove = false;
							GClass25.gclass25_0.isDead = false;
						}
					}
					break;
				}
				case -95:
				{
					int num60 = message.method_1().method_6();
					if (GClass25.gclass25_0.id == num60)
					{
						GClass25.gclass25_0.hp = message.method_1().method_7();
						break;
					}
					GClass25 gClass55 = GClass3.smethod_6(num60);
					if (gClass55 != null)
					{
						gClass55.hp = message.method_1().method_7();
					}
					break;
				}
				case -94:
				{
					int num24 = message.method_1().method_6();
					if (GClass25.gclass25_0.id == num24)
					{
						GClass9 gClass36 = new GClass9(GClass25.gclass25_0);
						gClass36.templateId = message.method_1().method_4();
						gClass36.iconId = message.method_1().method_4();
						gClass36.type = message.method_1().method_0();
						gClass36.time = message.method_1().method_7();
						gClass36.timeEnd = DateTime.UtcNow.AddMilliseconds(gClass36.time);
						int num25 = message.method_1().method_0();
						gClass36.imgIds = new List<int>();
						for (int num26 = 0; num26 < num25; num26++)
						{
							gClass36.imgIds.Add(message.method_1().method_4());
						}
						foreach (int imgId2 in gClass36.imgIds)
						{
							GClass42.smethod_0(imgId2);
						}
						GClass25.gclass25_0.effects.Add(gClass36);
						break;
					}
					GClass25 gClass37 = GClass3.smethod_6(num24);
					if (gClass37 == null)
					{
						break;
					}
					GClass9 gClass38 = new GClass9(gClass37);
					gClass38.templateId = message.method_1().method_4();
					gClass38.iconId = message.method_1().method_4();
					gClass38.type = message.method_1().method_0();
					gClass38.time = message.method_1().method_7();
					gClass38.timeEnd = DateTime.UtcNow.AddMilliseconds(gClass38.time);
					int num27 = message.method_1().method_0();
					gClass38.imgIds = new List<int>();
					for (int num28 = 0; num28 < num27; num28++)
					{
						gClass38.imgIds.Add(message.method_1().method_4());
					}
					foreach (int imgId3 in gClass38.imgIds)
					{
						GClass42.smethod_0(imgId3);
					}
					gClass37.effects.Add(gClass38);
					break;
				}
				case -93:
				{
					GClass78.smethod_5();
					int npcId = message.method_1().method_0();
					string title = message.method_1().method_11();
					int num17 = message.method_1().method_0();
					List<string> list = new List<string>();
					for (int num18 = 0; num18 < num17; num18++)
					{
						list.Add(message.method_1().method_11());
					}
					GClass3.smethod_9(title, list, GClass3.smethod_8(npcId));
					break;
				}
				case -91:
					GClass78.smethod_5();
					GClass3.smethod_8(message.method_1().method_0())?.method_3(message.method_1().method_11());
					break;
				case -87:
				{
					GClass78.smethod_5();
					int type = message.method_1().method_0();
					GClass79.smethod_3(message.method_1().method_11(), type);
					break;
				}
				case -85:
				{
					GClass69.gclass6_0.cmdAreas.Clear();
					int num13 = message.method_1().method_0();
					for (int n = 0; n < num13; n++)
					{
						GClass73 gClass21 = new GClass73(GClass69.gclass6_0, 35, n);
						gClass21.id = message.method_1().method_0();
						gClass21.maxPlayer = message.method_1().method_0();
						gClass21.numPlayer = message.method_1().method_0();
						gClass21.numTeam = message.method_1().method_0();
						GClass69.gclass6_0.cmdAreas.Add(gClass21);
					}
					GClass78.smethod_5();
					GClass69.gclass6_0.method_40(6);
					GClass69.gclass6_0.method_44();
					break;
				}
				case -83:
				{
					GClass25 gClass25 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass25 != null)
					{
						gClass25.head = message.method_1().method_4();
						gClass25.body = message.method_1().method_4();
						gClass25.leg = message.method_1().method_4();
						gClass25.mount = message.method_1().method_4();
					}
					break;
				}
				case -82:
				{
					GClass6.list_0.Clear();
					int num11 = message.method_1().method_0();
					for (int l = 0; l < num11; l++)
					{
						GClass16 gClass18 = new GClass16();
						gClass18.id = message.method_1().method_4();
						gClass18.typePrice = message.method_1().method_0();
						gClass18.price = message.method_1().method_6();
						gClass18.template = GClass69.list_1[message.method_1().method_4()];
						gClass18.quantity = message.method_1().method_4();
						int num12 = message.method_1().method_0();
						for (int m = 0; m < num12; m++)
						{
							GClass17 gClass19 = new GClass17();
							gClass19.template = GClass69.list_0[message.method_1().method_4()];
							gClass19.param = message.method_1().method_6();
							gClass18.options.Add(gClass19);
						}
						GClass6.list_0.Add(gClass18);
					}
					GClass69.gclass6_0.method_40(5);
					GClass69.gclass6_0.method_44();
					break;
				}
				case -81:
				{
					GClass22 gClass5 = new GClass22();
					gClass5.id = message.method_1().method_6();
					gClass5.template = GClass69.list_1[message.method_1().method_4()];
					gClass5.x = (gClass5.xEnd = message.method_1().method_4());
					gClass5.y = (gClass5.yEnd = message.method_1().method_4());
					GClass42.smethod_0(gClass5.template.iconId);
					try
					{
						gClass5.h = GClass42.dictionary_0[gClass5.template.iconId].method_1();
						gClass5.w = GClass42.dictionary_0[gClass5.template.iconId].method_0();
					}
					catch
					{
						gClass5.h = 50;
						gClass5.w = 50;
					}
					GClass3.list_3.Add(gClass5);
					break;
				}
				case -80:
				{
					int num2 = message.method_1().method_6();
					int num3 = 0;
					while (true)
					{
						if (num3 < GClass3.list_3.Count)
						{
							if (GClass3.list_3[num3].id == num2)
							{
								break;
							}
							num3++;
							continue;
						}
						return;
					}
					GClass3.list_3.RemoveAt(num3);
					break;
				}
				case -79:
				{
					int num58 = message.method_1().method_6();
					int num59 = message.method_1().method_4();
					GClass25.gclass25_0.itemFocus = null;
					{
						foreach (GClass22 item5 in GClass3.list_3)
						{
							if (item5.id != num58)
							{
								continue;
							}
							item5.method_1(GClass25.gclass25_0.x, GClass25.gclass25_0.y - (GClass25.gclass25_0.h / 2 - item5.h) / 2);
							GClass43.smethod_25();
							if (item5.template.type == GClass16.int_15)
							{
								GClass25.gclass25_0.xu += num59;
								if (GClass25.gclass25_0.xu > 2000000000)
								{
									GClass25.gclass25_0.xu = 2000000000;
								}
								GClass3.smethod_1(GClass67.gclass67_13, "+" + num59, GClass25.gclass25_0.x, GClass25.gclass25_0.y - GClass25.gclass25_0.imethod_3(), 0, -2);
								GClass79.smethod_3("Bạn nhận được " + num59 + " xu", 1);
							}
							else if (item5.template.type == GClass16.int_16)
							{
								GClass25.gclass25_0.diamond += num59;
								if (GClass25.gclass25_0.diamond > 2000000000)
								{
									GClass25.gclass25_0.diamond = 2000000000;
								}
								GClass3.smethod_1(GClass67.gclass67_16, "+" + num59, GClass25.gclass25_0.x, GClass25.gclass25_0.y - GClass25.gclass25_0.imethod_3(), 0, -2);
								GClass79.smethod_3("Bạn nhận được " + num59 + " kim cương", 1);
							}
							else
							{
								GClass79.smethod_3("Bạn nhận được " + ((num59 > 1) ? (num59 + " ") : "") + item5.template.name, 1);
							}
							break;
						}
						break;
					}
				}
				case -77:
				{
					GClass25 gClass52 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass52 == null)
					{
						break;
					}
					int num55 = message.method_1().method_6();
					{
						foreach (GClass22 item6 in GClass3.list_3)
						{
							if (item6.id == num55)
							{
								item6.method_1(gClass52.x, gClass52.y - (gClass52.h / 2 - item6.h) / 2);
								break;
							}
						}
						break;
					}
				}
				case -73:
				{
					GClass78.smethod_5();
					int num50 = message.method_1().method_6();
					if (GClass25.gclass25_0.id == num50)
					{
						bool_0 = true;
						GClass3.int_9 = 500;
						GClass44 item4 = new GClass44(GClass25.gclass25_0, 0);
						GClass3.list_5.Add(item4);
						break;
					}
					GClass25 gClass46 = GClass3.smethod_6(num50);
					if (gClass46 != null)
					{
						GClass44 gClass47 = new GClass44(gClass46, 0);
						gClass47.playerId = gClass46.id;
						GClass3.list_5.Add(gClass47);
					}
					break;
				}
				case -70:
				{
					int num21 = message.method_1().method_0();
					if (num21 == -1)
					{
						break;
					}
					GClass23 gClass32 = GClass3.smethod_7(num21);
					if (gClass32 == null)
					{
						break;
					}
					GClass25 gClass33 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass33 != null)
					{
						if (gClass33.x < gClass32.x)
						{
							gClass33.dir = 1;
						}
						else
						{
							gClass33.dir = -1;
						}
						gClass33.skillUseId = message.method_1().method_0();
						gClass33.method_7(gClass33.skillUseId, message.method_1().method_0(), (!Class0.smethod_3(gClass33.x, gClass33.y)) ? 1 : 0);
						gClass33.skillUseType = message.method_1().method_0();
						gClass33.playerFocus = null;
						gClass33.mobFocus = gClass32;
					}
					break;
				}
				case -69:
				{
					int num14 = message.method_1().method_6();
					GClass25 gClass22 = GClass25.gclass25_0;
					if (GClass25.gclass25_0.id != num14)
					{
						gClass22 = GClass3.smethod_6(num14);
					}
					if (gClass22 != null)
					{
						int num15 = message.method_1().method_6();
						bool isCritical = num15 > 0 && message.method_1().method_8();
						gClass22.method_20(num15, isCritical);
					}
					break;
				}
				case -68:
				{
					int num56 = message.method_1().method_6();
					GClass25 gClass53 = GClass25.gclass25_0;
					if (GClass25.gclass25_0.id != num56)
					{
						gClass53 = GClass3.smethod_6(num56);
					}
					if (gClass53 == null)
					{
						break;
					}
					GClass25 gClass54 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass54 != null)
					{
						if (gClass54.x < gClass53.x)
						{
							gClass54.dir = 1;
						}
						else
						{
							gClass54.dir = -1;
						}
						gClass54.skillUseId = message.method_1().method_0();
						gClass54.method_7(gClass54.skillUseId, message.method_1().method_0(), (!Class0.smethod_3(gClass54.x, gClass54.y)) ? 1 : 0);
						gClass54.skillUseType = message.method_1().method_0();
						gClass54.playerFocus = gClass53;
						gClass54.mobFocus = null;
						int num57 = message.method_1().method_6();
						bool isCritical2 = num57 > 0 && message.method_1().method_8();
						gClass53.method_20(num57, isCritical2);
					}
					break;
				}
				case -67:
				{
					GClass25 gClass51 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass51 != null)
					{
						gClass51.isWaitDart = false;
					}
					break;
				}
				case -66:
				{
					if (message.method_1().method_0() != 2)
					{
						break;
					}
					int num19 = message.method_1().method_6();
					int num20 = message.method_1().method_6();
					if (GClass25.gclass25_0.id == num19)
					{
						GClass25 gClass28 = GClass3.smethod_6(num20);
						if (gClass28 != null)
						{
							if (gClass28 != null)
							{
								gClass28.typePk = 1;
							}
							GClass25.gclass25_0.method_44(gClass28);
							GClass25.gclass25_0.typePk = 1;
							GClass25.gclass25_0.killId = num20;
							GClass3.smethod_0().cmdQues.isShow = false;
						}
					}
					else if (GClass25.gclass25_0.id == num20)
					{
						GClass25 gClass29 = GClass3.smethod_6(num19);
						if (gClass29 != null)
						{
							if (gClass29 != null)
							{
								gClass29.typePk = 1;
							}
							GClass25.gclass25_0.method_44(gClass29);
							GClass25.gclass25_0.typePk = 1;
							GClass25.gclass25_0.killId = num19;
							GClass3.smethod_0().cmdQues.isShow = false;
						}
					}
					else
					{
						GClass25 gClass30 = GClass3.smethod_6(num19);
						if (gClass30 != null)
						{
							gClass30.typePk = 1;
						}
						GClass25 gClass31 = GClass3.smethod_6(num20);
						if (gClass31 != null)
						{
							gClass31.typePk = 1;
						}
					}
					break;
				}
				case -65:
				{
					GClass25 gClass27 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass27 != null)
					{
						gClass27.typePk = message.method_1().method_0();
					}
					break;
				}
				case -64:
				{
					GClass25 gClass26 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass26 != null)
					{
						gClass26.typeFlag = message.method_1().method_0();
					}
					break;
				}
				case -62:
				{
					if (GClass25.gclass25_0.team == null)
					{
						break;
					}
					int playerId = message.method_1().method_6();
					if (GClass25.gclass25_0.id == playerId)
					{
						GClass6.list_7.Add(new GClass73(GClass69.gclass6_0, 48, GClass25.gclass25_0, message.method_1().method_11()));
					}
					else
					{
						GClass25 playerInfo = GClass25.gclass25_0.team.members.First((GClass73 gclass73_0) => gclass73_0.playerInfo.id == playerId).playerInfo;
						if (playerInfo != null)
						{
							GClass6.list_7.Add(new GClass73(GClass69.gclass6_0, 48, playerInfo, message.method_1().method_11()));
						}
					}
					if (GClass69.gclass6_0.isShow && GClass69.gclass6_0.type == 14)
					{
						GClass69.gclass6_0.method_41(14);
					}
					break;
				}
				case -61:
				{
					int num10 = message.method_1().method_6();
					GClass25 gClass17 = new GClass25();
					gClass17.id = num10;
					gClass17.name = message.method_1().method_11();
					gClass17.classId = message.method_1().method_0();
					GClass69.gclass6_0.method_49((num10 == GClass25.gclass25_0.id) ? GClass25.gclass25_0 : gClass17, message.method_1().method_11());
					break;
				}
				case -60:
				{
					GClass25 gClass12 = GClass3.smethod_6(message.method_1().method_6());
					if (gClass12 != null)
					{
						gClass12.level = message.method_1().method_4();
					}
					break;
				}
				case -55:
					switch (message.method_1().method_0())
					{
					case 1:
					{
						GClass25 gClass11 = GClass3.smethod_6(message.method_1().method_6());
						if (gClass11 != null)
						{
							GClass69.gclass6_0.itemsMe.Clear();
							GClass69.gclass6_0.itemsFriend.Clear();
							GClass69.gclass6_0.isLock = false;
							GClass69.gclass6_0.isFriendLock = false;
							GClass69.gclass6_0.cmdTrade.caption = "Khóa giao dịch";
							GClass69.gclass6_0.cmdTrade.isShow = true;
							GClass69.gclass6_0.xuTrade = 0;
							GClass69.gclass6_0.xuFriendTrade = 0;
							GClass69.gclass6_0.playerMenu = gClass11;
							GClass69.gclass6_0.method_40(19);
							GClass69.gclass6_0.method_44();
						}
						break;
					}
					case 2:
						GClass69.gclass6_0.isClose = true;
						GClass79.smethod_3("Giao dịch bị hủy bỏ.", 0);
						break;
					case 3:
					{
						int index2 = message.method_1().method_0();
						GClass16 gClass10 = GClass25.gclass25_0.itemsBag[index2];
						if (gClass10 != null)
						{
							GClass69.gclass6_0.itemsMe.Add(gClass10);
						}
						break;
					}
					case 4:
					{
						int index = message.method_1().method_0();
						GClass16 gClass9 = GClass25.gclass25_0.itemsBag[index];
						if (gClass9 != null)
						{
							GClass69.gclass6_0.itemsMe.Remove(gClass9);
						}
						break;
					}
					case 5:
						GClass69.gclass6_0.xuTrade = message.method_1().method_6();
						break;
					case 6:
						GClass69.gclass6_0.isLock = true;
						GClass69.gclass6_0.cmdTrade.isShow = GClass69.gclass6_0.isFriendLock;
						if (GClass69.gclass6_0.cmdTrade.isShow)
						{
							GClass69.gclass6_0.cmdTrade.caption = "Đồng ý";
						}
						break;
					case 7:
					{
						GClass69.gclass6_0.isFriendLock = true;
						GClass69.gclass6_0.itemsFriend.Clear();
						int num6 = message.method_1().method_0();
						for (int j = 0; j < num6; j++)
						{
							GClass16 gClass7 = new GClass16();
							gClass7.template = GClass69.list_1[message.method_1().method_4()];
							gClass7.quantity = message.method_1().method_4();
							gClass7.indexUI = j;
							int num7 = message.method_1().method_0();
							for (int k = 0; k < num7; k++)
							{
								GClass17 gClass8 = new GClass17();
								gClass8.template = GClass69.list_0[message.method_1().method_4()];
								gClass8.param = message.method_1().method_6();
								gClass7.options.Add(gClass8);
							}
							GClass69.gclass6_0.itemsFriend.Add(gClass7);
						}
						GClass69.gclass6_0.xuFriendTrade = message.method_1().method_6();
						if (GClass69.gclass6_0.isLock)
						{
							GClass69.gclass6_0.cmdTrade.caption = "Đồng ý";
							GClass69.gclass6_0.cmdTrade.isShow = true;
						}
						break;
					}
					case 8:
						GClass69.gclass6_0.cmdTrade.isShow = false;
						if (!GClass69.gclass6_0.isFriendLock)
						{
							GClass79.smethod_3("Vui lòng chờ đối phương đồng ý.", 1);
						}
						break;
					case 9:
						GClass69.gclass6_0.isClose = true;
						GClass79.smethod_3("Giao dịch thành công.", 1);
						break;
					}
					break;
				case -54:
				{
					GClass25 gClass6 = new GClass25();
					gClass6.id = message.method_1().method_6();
					gClass6.name = message.method_1().method_11();
					gClass6.head = message.method_1().method_4();
					gClass6.body = message.method_1().method_4();
					gClass6.leg = message.method_1().method_4();
					gClass6.x = message.method_1().method_4();
					gClass6.y = message.method_1().method_4();
					gClass6.xSd = gClass6.x;
					gClass6.ySd = gClass6.y;
					gClass6.maxHp = message.method_1().method_7();
					gClass6.hp = message.method_1().method_7();
					gClass6.typePk = message.method_1().method_0();
					gClass6.mount = -1;
					GClass25.smethod_2(gClass6);
					GClass25.smethod_1(gClass6);
					GClass25.smethod_0(gClass6);
					if (GClass3.smethod_6(gClass6.id) == null)
					{
						GClass3.list_1.Add(gClass6);
					}
					break;
				}
				case -53:
				{
					GClass25 gClass4 = new GClass25();
					gClass4.id = -1;
					gClass4.name = "Thông báo Server";
					gClass4.classId = 6;
					GClass73 item = new GClass73(GClass69.gclass6_0, 47, gClass4, message.method_1().method_11());
					GClass6.list_6.Add(item);
					GClass3.smethod_0().textGlobal.infos.Add(item);
					if (GClass69.gclass6_0.isShow && GClass69.gclass6_0.type == 12)
					{
						GClass69.gclass6_0.method_41(12);
					}
					break;
				}
				default:
					Debug.Log(message.command.ToString());
					break;
				case -51:
				{
					GClass3.list_6.Clear();
					int num = message.method_1().method_0();
					for (int i = 0; i < num; i++)
					{
						GClass16 gClass = new GClass16();
						gClass.template = GClass69.list_1[message.method_1().method_4()];
						gClass.quantity = message.method_1().method_4();
						GClass3.list_6.Add(gClass);
					}
					GClass3.smethod_0().method_6();
					break;
				}
				case -57:
					break;
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_1(bool isMain)
		{
			bool_2 = isMain;
		}

		public static void smethod_2(bool isMain)
		{
			bool_3 = isMain;
		}

		public static void smethod_3(bool isMain)
		{
			bool_1 = isMain;
		}

		public static void smethod_4(GClass61 message)
		{
			try
			{
				switch (message.method_1().method_0())
				{
				case 0:
				{
					GClass25.gclass25_0 = new GClass25();
					GClass25.bool_8 = true;
					Class0.dictionary_1.Clear();
					GClass69.list_1 = new List<GClass19>();
					int num31 = message.method_1().method_4();
					for (int num32 = 0; num32 < num31; num32++)
					{
						GClass19 gClass15 = new GClass19();
						gClass15.id = message.method_1().method_4();
						gClass15.name = message.method_1().method_11();
						gClass15.description = message.method_1().method_11();
						gClass15.gender = message.method_1().method_0();
						gClass15.sex = message.method_1().method_0();
						gClass15.type = message.method_1().method_0();
						gClass15.iconId = message.method_1().method_4();
						gClass15.isUp = message.method_1().method_8();
						gClass15.levelRequire = message.method_1().method_4();
						GClass69.list_1.Add(gClass15);
					}
					GClass69.list_0 = new List<GClass18>();
					int num33 = message.method_1().method_4();
					for (int num34 = 0; num34 < num33; num34++)
					{
						GClass18 gClass16 = new GClass18();
						gClass16.id = message.method_1().method_4();
						gClass16.name = message.method_1().method_11();
						gClass16.type = message.method_1().method_0();
						GClass69.list_0.Add(gClass16);
					}
					GClass69.list_4 = new List<GClass20>();
					int num35 = message.method_1().method_4();
					for (int num36 = 0; num36 < num35; num36++)
					{
						GClass20 gClass17 = new GClass20();
						gClass17.id = message.method_1().method_4();
						gClass17.name = message.method_1().method_11();
						gClass17.power = message.method_1().method_7();
						GClass69.list_4.Add(gClass17);
					}
					GClass25.gclass25_0.id = message.method_1().method_6();
					GClass25.gclass25_0.name = message.method_1().method_11();
					GClass25.gclass25_0.gender = message.method_1().method_0();
					GClass25.gclass25_0.sex = message.method_1().method_0();
					GClass25.gclass25_0.classId = message.method_1().method_0();
					GClass25.gclass25_0.power = message.method_1().method_7();
					GClass25.gclass25_0.potential = message.method_1().method_7();
					GClass25.gclass25_0.level = message.method_1().method_4();
					GClass25.gclass25_0.pointSkill = message.method_1().method_4();
					GClass25.gclass25_0.head = message.method_1().method_4();
					GClass25.gclass25_0.body = message.method_1().method_4();
					GClass25.gclass25_0.leg = message.method_1().method_4();
					GClass25.gclass25_0.mount = message.method_1().method_4();
					GClass25.smethod_2(GClass25.gclass25_0);
					GClass25.smethod_1(GClass25.gclass25_0);
					GClass25.smethod_0(GClass25.gclass25_0);
					GClass25.gclass25_0.baseDamage = message.method_1().method_4();
					GClass25.gclass25_0.baseHp = message.method_1().method_4();
					GClass25.gclass25_0.baseMp = message.method_1().method_4();
					GClass25.gclass25_0.baseConstitution = message.method_1().method_4();
					GClass25.gclass25_0.potentialUpDamage = message.method_1().method_7();
					GClass25.gclass25_0.potentialUpHp = message.method_1().method_7();
					GClass25.gclass25_0.potentialUpMp = message.method_1().method_7();
					GClass25.gclass25_0.potentialUpConstitution = message.method_1().method_7();
					GClass25.gclass25_0.maxHp = message.method_1().method_7();
					GClass25.gclass25_0.maxMp = message.method_1().method_7();
					GClass3.long_2 = (GClass25.gclass25_0.hp = message.method_1().method_7());
					GClass3.long_3 = (GClass25.gclass25_0.mp = message.method_1().method_7());
					GClass25.gclass25_0.speed = message.method_1().method_0();
					GClass25.gclass25_0.pointPk = message.method_1().method_0();
					GClass25.gclass25_0.pointActivity = message.method_1().method_0();
					GClass25.gclass25_0.dodge = message.method_1().method_4();
					GClass25.gclass25_0.critical = message.method_1().method_4();
					GClass25.gclass25_0.accurate = message.method_1().method_4();
					GClass25.gclass25_0.reduceDamage = message.method_1().method_4();
					GClass25.gclass25_0.reduceDamageCritical = message.method_1().method_4();
					GClass25.gclass25_0.criticalStrike = message.method_1().method_4();
					GClass25.gclass25_0.bloodsucking = message.method_1().method_4();
					GClass25.gclass25_0.manaSucking = message.method_1().method_4();
					GClass25.gclass25_0.strikeBack = message.method_1().method_4();
					GClass25.gclass25_0.maxDamage = message.method_1().method_6();
					GClass25.gclass25_0.xu = message.method_1().method_6();
					GClass25.gclass25_0.diamond = message.method_1().method_6();
					GClass25.gclass25_0.spaceship = message.method_1().method_0();
					GClass25.gclass25_0.skills = new List<GClass34>();
					int num37 = message.method_1().method_0();
					for (int num38 = 0; num38 < num37; num38++)
					{
						GClass34 gClass18 = new GClass34();
						gClass18.template = new GClass40();
						gClass18.template.id = message.method_1().method_0();
						gClass18.template.name = message.method_1().method_11();
						gClass18.template.description = message.method_1().method_11();
						gClass18.template.maxLevel = message.method_1().method_0();
						gClass18.template.type = message.method_1().method_0();
						gClass18.template.manaUse = message.method_1().method_4();
						gClass18.template.manaWithLevel = message.method_1().method_4();
						gClass18.template.typeManaUse = message.method_1().method_0();
						gClass18.template.coolDown = message.method_1().method_6();
						gClass18.template.timeWithLevel = message.method_1().method_4();
						gClass18.template.range = message.method_1().method_4();
						gClass18.template.levelRequire = message.method_1().method_4();
						gClass18.template.iconId = message.method_1().method_4();
						gClass18.template.isProactive = message.method_1().method_8();
						gClass18.level = message.method_1().method_0();
						GClass42.smethod_0(gClass18.template.iconId);
						if (gClass18.level > 0 && gClass18.template.isProactive)
						{
							gClass18.lastTimeUse = message.method_1().method_7();
						}
						int num39 = message.method_1().method_0();
						for (int num40 = 0; num40 < num39; num40++)
						{
							GClass36 gClass19 = new GClass36();
							gClass19.template = new GClass38();
							gClass19.template.id = message.method_1().method_0();
							gClass19.template.name = message.method_1().method_11();
							gClass19.param = message.method_1().method_4();
							gClass19.paramWithLevel = message.method_1().method_4();
							gClass18.options.Add(gClass19);
						}
						GClass25.gclass25_0.skills.Add(gClass18);
					}
					int num41 = message.method_1().method_0();
					for (int num42 = 0; num42 < num41; num42++)
					{
						int num43 = message.method_1().method_0();
						if (num43 != -1)
						{
							GClass3.gclass34_0[num42] = GClass25.gclass25_0.method_45(num43);
						}
						else
						{
							GClass3.gclass34_0[num42] = null;
						}
					}
					GClass25.gclass25_0.mySkill = GClass25.gclass25_0.method_45(message.method_1().method_0());
					int num44 = message.method_1().method_0();
					for (int num45 = 0; num45 < num44; num45++)
					{
						int num46 = message.method_1().method_4();
						if (num46 == -1)
						{
							GClass25.gclass25_0.itemsBody.Add(null);
							continue;
						}
						GClass16 gClass20 = new GClass16();
						gClass20.template = GClass69.list_1[num46];
						gClass20.quantity = message.method_1().method_4();
						gClass20.indexUI = num45;
						int num47 = message.method_1().method_0();
						for (int num48 = 0; num48 < num47; num48++)
						{
							GClass17 gClass21 = new GClass17();
							gClass21.template = GClass69.list_0[message.method_1().method_4()];
							gClass21.param = message.method_1().method_6();
							gClass20.options.Add(gClass21);
						}
						GClass25.gclass25_0.itemsBody.Add(gClass20);
					}
					int num49 = message.method_1().method_0();
					for (int num50 = 0; num50 < num49; num50++)
					{
						int num51 = message.method_1().method_4();
						if (num51 == -1)
						{
							GClass25.gclass25_0.itemsBag.Add(null);
							continue;
						}
						GClass16 gClass22 = new GClass16();
						gClass22.template = GClass69.list_1[num51];
						gClass22.quantity = message.method_1().method_4();
						gClass22.indexUI = num50;
						int num52 = message.method_1().method_0();
						for (int num53 = 0; num53 < num52; num53++)
						{
							GClass17 gClass23 = new GClass17();
							gClass23.template = GClass69.list_0[message.method_1().method_4()];
							gClass23.param = message.method_1().method_6();
							gClass22.options.Add(gClass23);
						}
						GClass25.gclass25_0.itemsBag.Add(gClass22);
					}
					int num54 = message.method_1().method_0();
					for (int num55 = 0; num55 < num54; num55++)
					{
						int num56 = message.method_1().method_4();
						if (num56 == -1)
						{
							GClass25.gclass25_0.itemsBox.Add(null);
							continue;
						}
						GClass16 gClass24 = new GClass16();
						gClass24.template = GClass69.list_1[num56];
						gClass24.quantity = message.method_1().method_4();
						gClass24.indexUI = num55;
						int num57 = message.method_1().method_0();
						for (int num58 = 0; num58 < num57; num58++)
						{
							GClass17 gClass25 = new GClass17();
							gClass25.template = GClass69.list_0[message.method_1().method_4()];
							gClass25.param = message.method_1().method_6();
							gClass24.options.Add(gClass25);
						}
						GClass25.gclass25_0.itemsBox.Add(gClass24);
					}
					GClass3.bool_3 = false;
					int num59 = message.method_1().method_0();
					for (int num60 = 0; num60 < num59; num60++)
					{
						GClass9 gClass26 = new GClass9(GClass25.gclass25_0);
						gClass26.templateId = message.method_1().method_4();
						gClass26.iconId = message.method_1().method_4();
						gClass26.type = message.method_1().method_0();
						gClass26.time = message.method_1().method_7();
						gClass26.timeEnd = DateTime.UtcNow.AddMilliseconds(gClass26.time);
						int num61 = message.method_1().method_0();
						gClass26.imgIds = new List<int>();
						for (int num62 = 0; num62 < num61; num62++)
						{
							gClass26.imgIds.Add(message.method_1().method_4());
						}
						foreach (int imgId in gClass26.imgIds)
						{
							GClass42.smethod_0(imgId);
						}
						if (gClass26.templateId == 14)
						{
							GClass3.bool_3 = true;
						}
						GClass25.gclass25_0.effects.Add(gClass26);
					}
					GClass25.gclass25_0.task = new GClass48();
					GClass25.gclass25_0.task.id = message.method_1().method_0();
					GClass25.gclass25_0.task.name = message.method_1().method_11();
					GClass25.gclass25_0.task.index = message.method_1().method_0();
					GClass25.gclass25_0.task.param = message.method_1().method_6();
					int num63 = message.method_1().method_0();
					for (int num64 = 0; num64 < num63; num64++)
					{
						GClass49 gClass27 = new GClass49();
						gClass27.name = message.method_1().method_11();
						gClass27.param = message.method_1().method_6();
						gClass27.npcId = message.method_1().method_0();
						gClass27.mapId = message.method_1().method_4();
						gClass27.description = message.method_1().method_11();
						GClass25.gclass25_0.task.subTasks.Add(gClass27);
					}
					GClass25.bool_8 = false;
					break;
				}
				case 1:
				{
					int num30 = message.method_1().method_6();
					GClass25.gclass25_0.power += num30;
					GClass25.gclass25_0.potential += num30;
					GClass3.smethod_1(GClass67.gclass67_23, "+" + num30, GClass25.gclass25_0.x, GClass25.gclass25_0.y - GClass25.gclass25_0.imethod_3(), 0, -2);
					break;
				}
				case 2:
					GClass25.gclass25_0.hp = message.method_1().method_7();
					GClass25.gclass25_0.mp = message.method_1().method_7();
					break;
				case 3:
					GClass25.gclass25_0.isWaitDart = false;
					break;
				case 4:
				{
					GClass25.gclass25_0.task = new GClass48();
					GClass25.gclass25_0.task.id = message.method_1().method_0();
					GClass25.gclass25_0.task.name = message.method_1().method_11();
					GClass25.gclass25_0.task.index = message.method_1().method_0();
					GClass25.gclass25_0.task.param = message.method_1().method_6();
					int num26 = message.method_1().method_0();
					for (int num27 = 0; num27 < num26; num27++)
					{
						GClass49 gClass13 = new GClass49();
						gClass13.name = message.method_1().method_11();
						gClass13.param = message.method_1().method_6();
						gClass13.npcId = message.method_1().method_0();
						gClass13.mapId = message.method_1().method_4();
						gClass13.description = message.method_1().method_11();
						GClass25.gclass25_0.task.subTasks.Add(gClass13);
					}
					GClass3.smethod_3();
					break;
				}
				case 5:
					GClass25.gclass25_0.task.param = 0;
					GClass25.gclass25_0.task.index++;
					GClass3.smethod_3();
					break;
				case 6:
					GClass25.gclass25_0.task.param++;
					break;
				case 7:
				{
					GClass25.gclass25_0.potential = message.method_1().method_7();
					sbyte num14 = message.method_1().method_0();
					if (num14 == 0)
					{
						GClass25.gclass25_0.baseDamage = message.method_1().method_4();
						GClass25.gclass25_0.potentialUpDamage = message.method_1().method_7();
					}
					if (num14 == 1)
					{
						GClass25.gclass25_0.baseHp = message.method_1().method_4();
						GClass25.gclass25_0.potentialUpHp = message.method_1().method_7();
					}
					if (num14 == 2)
					{
						GClass25.gclass25_0.baseMp = message.method_1().method_4();
						GClass25.gclass25_0.potentialUpMp = message.method_1().method_7();
					}
					if (num14 == 3)
					{
						GClass25.gclass25_0.baseConstitution = message.method_1().method_4();
						GClass25.gclass25_0.potentialUpConstitution = message.method_1().method_7();
					}
					break;
				}
				case 8:
				{
					GClass25.gclass25_0.pointSkill = message.method_1().method_4();
					GClass34 gClass = GClass25.gclass25_0.method_45(message.method_1().method_0());
					if (gClass != null)
					{
						gClass.level = message.method_1().method_0();
					}
					break;
				}
				case 9:
					GClass25.gclass25_0.level++;
					GClass25.gclass25_0.pointSkill++;
					GClass3.smethod_2();
					break;
				case 10:
				{
					GClass25.gclass25_0.itemsBody.Clear();
					int num78 = message.method_1().method_0();
					for (int num79 = 0; num79 < num78; num79++)
					{
						int num80 = message.method_1().method_4();
						if (num80 == -1)
						{
							GClass25.gclass25_0.itemsBody.Add(null);
							continue;
						}
						GClass16 gClass32 = new GClass16();
						gClass32.template = GClass69.list_1[num80];
						gClass32.quantity = message.method_1().method_4();
						gClass32.indexUI = num79;
						int num81 = message.method_1().method_0();
						for (int num82 = 0; num82 < num81; num82++)
						{
							GClass17 gClass33 = new GClass17();
							gClass33.template = GClass69.list_0[message.method_1().method_4()];
							gClass33.param = message.method_1().method_6();
							gClass32.options.Add(gClass33);
						}
						GClass25.gclass25_0.itemsBody.Add(gClass32);
					}
					break;
				}
				case 11:
				{
					GClass78.smethod_5();
					GClass25.gclass25_0.itemsBag.Clear();
					int num8 = message.method_1().method_0();
					for (int j = 0; j < num8; j++)
					{
						int num9 = message.method_1().method_4();
						if (num9 == -1)
						{
							GClass25.gclass25_0.itemsBag.Add(null);
							continue;
						}
						GClass16 gClass3 = new GClass16();
						gClass3.template = GClass69.list_1[num9];
						gClass3.quantity = message.method_1().method_4();
						gClass3.indexUI = j;
						int num10 = message.method_1().method_0();
						for (int k = 0; k < num10; k++)
						{
							GClass17 gClass4 = new GClass17();
							gClass4.template = GClass69.list_0[message.method_1().method_4()];
							gClass4.param = message.method_1().method_6();
							gClass3.options.Add(gClass4);
						}
						GClass25.gclass25_0.itemsBag.Add(gClass3);
					}
					if (GClass69.gclass6_0.indexSelect >= 0 && GClass69.gclass6_0.indexSelect < GClass25.gclass25_0.itemsBag.Count)
					{
						GClass69.gclass6_0.itemSelected = GClass25.gclass25_0.itemsBag[GClass69.gclass6_0.indexSelect];
					}
					else
					{
						GClass69.gclass6_0.itemSelected = null;
					}
					break;
				}
				case 12:
				{
					GClass25.gclass25_0.itemsBox.Clear();
					int num11 = message.method_1().method_0();
					for (int l = 0; l < num11; l++)
					{
						int num12 = message.method_1().method_4();
						if (num12 == -1)
						{
							GClass25.gclass25_0.itemsBox.Add(null);
							continue;
						}
						GClass16 gClass5 = new GClass16();
						gClass5.template = GClass69.list_1[num12];
						gClass5.quantity = message.method_1().method_4();
						gClass5.indexUI = l;
						int num13 = message.method_1().method_0();
						for (int m = 0; m < num13; m++)
						{
							GClass17 gClass6 = new GClass17();
							gClass6.template = GClass69.list_0[message.method_1().method_4()];
							gClass6.param = message.method_1().method_6();
							gClass5.options.Add(gClass6);
						}
						GClass25.gclass25_0.itemsBox.Add(gClass5);
					}
					break;
				}
				case 13:
				{
					int num4 = message.method_1().method_4();
					int num5 = 0;
					while (true)
					{
						if (num5 < GClass25.gclass25_0.effects.Count)
						{
							if (GClass25.gclass25_0.effects[num5].templateId == num4)
							{
								break;
							}
							num5++;
							continue;
						}
						return;
					}
					GClass25.gclass25_0.effects.RemoveAt(num5);
					break;
				}
				case 14:
					GClass3.gclass34_0[message.method_1().method_0()] = GClass25.gclass25_0.method_45(message.method_1().method_0());
					break;
				case 15:
					GClass25.gclass25_0.head = message.method_1().method_4();
					GClass25.gclass25_0.body = message.method_1().method_4();
					GClass25.gclass25_0.leg = message.method_1().method_4();
					GClass25.gclass25_0.mount = message.method_1().method_4();
					GClass25.smethod_2(GClass25.gclass25_0);
					GClass25.smethod_1(GClass25.gclass25_0);
					GClass25.smethod_0(GClass25.gclass25_0);
					break;
				case 16:
					GClass25.gclass25_0.x = message.method_1().method_4();
					GClass25.gclass25_0.y = message.method_1().method_4();
					GClass25.bool_1 = false;
					GClass25.bool_2 = false;
					GClass78.smethod_5();
					break;
				case 17:
					GClass25.gclass25_0.itemsBag[message.method_1().method_0()].quantity = message.method_1().method_4();
					break;
				case 18:
				{
					int num16 = message.method_1().method_0();
					int num17 = message.method_1().method_4();
					if (num17 == -1)
					{
						GClass25.gclass25_0.itemsBag[num16] = null;
					}
					else
					{
						GClass16 gClass8 = new GClass16();
						gClass8.template = GClass69.list_1[num17];
						gClass8.quantity = message.method_1().method_4();
						gClass8.indexUI = num16;
						int num18 = message.method_1().method_0();
						for (int num19 = 0; num19 < num18; num19++)
						{
							GClass17 gClass9 = new GClass17();
							gClass9.template = GClass69.list_0[message.method_1().method_4()];
							gClass9.param = message.method_1().method_6();
							gClass8.options.Add(gClass9);
						}
						GClass25.gclass25_0.itemsBag[num16] = gClass8;
					}
					if (GClass69.gclass6_0.indexSelect >= 0 && GClass69.gclass6_0.indexSelect < GClass25.gclass25_0.itemsBag.Count)
					{
						GClass69.gclass6_0.itemSelected = GClass25.gclass25_0.itemsBag[GClass69.gclass6_0.indexSelect];
					}
					else
					{
						GClass69.gclass6_0.itemSelected = null;
					}
					break;
				}
				case 19:
					GClass25.gclass25_0.itemsBox[message.method_1().method_0()].quantity = message.method_1().method_4();
					break;
				case 20:
				{
					int num83 = message.method_1().method_0();
					int num84 = message.method_1().method_4();
					if (num84 == -1)
					{
						GClass25.gclass25_0.itemsBox[num83] = null;
					}
					else
					{
						GClass16 gClass34 = new GClass16();
						gClass34.template = GClass69.list_1[num84];
						gClass34.quantity = message.method_1().method_4();
						gClass34.indexUI = num83;
						int num85 = message.method_1().method_0();
						for (int num86 = 0; num86 < num85; num86++)
						{
							GClass17 gClass35 = new GClass17();
							gClass35.template = GClass69.list_0[message.method_1().method_4()];
							gClass35.param = message.method_1().method_6();
							gClass34.options.Add(gClass35);
						}
						GClass25.gclass25_0.itemsBox[num83] = gClass34;
					}
					if (GClass69.gclass6_0.indexSelect >= 0 && GClass69.gclass6_0.indexSelect < GClass25.gclass25_0.itemsBag.Count)
					{
						GClass69.gclass6_0.itemSelected = GClass25.gclass25_0.itemsBox[GClass69.gclass6_0.indexSelect];
					}
					else
					{
						GClass69.gclass6_0.itemSelected = null;
					}
					break;
				}
				case 21:
				{
					int num74 = message.method_1().method_0();
					int num75 = message.method_1().method_4();
					if (num75 == -1)
					{
						GClass25.gclass25_0.itemsBody[num74] = null;
						break;
					}
					GClass16 gClass30 = new GClass16();
					gClass30.template = GClass69.list_1[num75];
					gClass30.quantity = message.method_1().method_4();
					gClass30.indexUI = num74;
					int num76 = message.method_1().method_0();
					for (int num77 = 0; num77 < num76; num77++)
					{
						GClass17 gClass31 = new GClass17();
						gClass31.template = GClass69.list_0[message.method_1().method_4()];
						gClass31.param = message.method_1().method_6();
						gClass30.options.Add(gClass31);
					}
					GClass25.gclass25_0.itemsBody[num74] = gClass30;
					break;
				}
				case 22:
					GClass25.gclass25_0.maxHp = message.method_1().method_7();
					GClass25.gclass25_0.maxMp = message.method_1().method_7();
					GClass25.gclass25_0.hp = message.method_1().method_7();
					GClass25.gclass25_0.mp = message.method_1().method_7();
					GClass25.gclass25_0.speed = message.method_1().method_0();
					GClass25.gclass25_0.dodge = message.method_1().method_4();
					GClass25.gclass25_0.critical = message.method_1().method_4();
					GClass25.gclass25_0.accurate = message.method_1().method_4();
					GClass25.gclass25_0.reduceDamage = message.method_1().method_4();
					GClass25.gclass25_0.reduceDamageCritical = message.method_1().method_4();
					GClass25.gclass25_0.criticalStrike = message.method_1().method_4();
					GClass25.gclass25_0.bloodsucking = message.method_1().method_4();
					GClass25.gclass25_0.manaSucking = message.method_1().method_4();
					GClass25.gclass25_0.strikeBack = message.method_1().method_4();
					GClass25.gclass25_0.maxDamage = message.method_1().method_6();
					break;
				case 23:
					GClass25.gclass25_0.maxDamage = message.method_1().method_6();
					break;
				case 24:
					GClass25.gclass25_0.xu = message.method_1().method_6();
					break;
				case 25:
					GClass25.gclass25_0.diamond = message.method_1().method_6();
					break;
				case 26:
				{
					int index2 = message.method_1().method_0();
					int num73 = message.method_1().method_0();
					GClass25.gclass25_0.itemsBag[num73] = GClass25.gclass25_0.itemsBag[index2].method_1();
					GClass25.gclass25_0.itemsBag[index2] = null;
					GClass25.gclass25_0.itemsBag[num73].indexUI = num73;
					break;
				}
				case 27:
					switch (message.method_1().method_0())
					{
					case 0:
					{
						GClass6.list_2.Clear();
						int num71 = message.method_1().method_0();
						for (int num72 = 0; num72 < num71; num72++)
						{
							GClass73 gClass29 = new GClass73(GClass69.gclass6_0, 39, num72);
							gClass29.playerInfo = new GClass25();
							gClass29.playerInfo.id = message.method_1().method_6();
							gClass29.playerInfo.name = message.method_1().method_11();
							gClass29.playerInfo.classId = message.method_1().method_0();
							gClass29.playerInfo.power = message.method_1().method_7();
							gClass29.isOnline = message.method_1().method_8();
							GClass6.list_2.Add(gClass29);
						}
						GClass78.smethod_5();
						GClass69.gclass6_0.method_40(9);
						GClass69.gclass6_0.method_44();
						break;
					}
					case 2:
					{
						int num69 = message.method_1().method_6();
						for (int num70 = 0; num70 < GClass6.list_2.Count; num70++)
						{
							if (GClass6.list_2[num70].playerInfo.id == num69)
							{
								GClass6.list_2.RemoveAt(num70);
								break;
							}
						}
						GClass69.gclass6_0.method_41(9);
						break;
					}
					}
					break;
				case 28:
					switch (message.method_1().method_0())
					{
					case 0:
					{
						GClass6.list_3.Clear();
						int num67 = message.method_1().method_0();
						for (int num68 = 0; num68 < num67; num68++)
						{
							GClass73 gClass28 = new GClass73(GClass69.gclass6_0, 40, num68);
							gClass28.playerInfo = new GClass25();
							gClass28.playerInfo.id = message.method_1().method_6();
							gClass28.playerInfo.name = message.method_1().method_11();
							gClass28.playerInfo.classId = message.method_1().method_0();
							gClass28.playerInfo.power = message.method_1().method_7();
							gClass28.isOnline = message.method_1().method_8();
							GClass6.list_3.Add(gClass28);
						}
						GClass78.smethod_5();
						GClass69.gclass6_0.method_40(10);
						GClass69.gclass6_0.method_44();
						break;
					}
					case 2:
					{
						int num65 = message.method_1().method_6();
						for (int num66 = 0; num66 < GClass6.list_3.Count; num66++)
						{
							if (GClass6.list_3[num66].playerInfo.id == num65)
							{
								GClass6.list_3.RemoveAt(num66);
								break;
							}
						}
						GClass69.gclass6_0.method_41(10);
						break;
					}
					}
					break;
				case 29:
				{
					GClass9 gClass14 = new GClass9(GClass25.gclass25_0);
					gClass14.templateId = message.method_1().method_4();
					gClass14.iconId = message.method_1().method_4();
					gClass14.type = message.method_1().method_0();
					gClass14.time = message.method_1().method_7();
					gClass14.timeEnd = DateTime.UtcNow.AddMilliseconds(gClass14.time);
					int num28 = message.method_1().method_0();
					gClass14.imgIds = new List<int>();
					for (int num29 = 0; num29 < num28; num29++)
					{
						gClass14.imgIds.Add(message.method_1().method_4());
					}
					foreach (int imgId2 in gClass14.imgIds)
					{
						GClass42.smethod_0(imgId2);
					}
					GClass25.gclass25_0.effects.Add(gClass14);
					break;
				}
				case 30:
					GClass25.gclass25_0.method_19();
					GClass25.bool_2 = false;
					GClass25.gclass25_0.isLockMove = false;
					GClass25.gclass25_0.isDead = false;
					GClass25.gclass25_0.diamond--;
					break;
				case 31:
					GClass6.list_5.Clear();
					switch (message.method_1().method_0())
					{
					case 0:
					{
						GClass25.gclass25_0.team = new GClass50();
						GClass25.gclass25_0.team.isLock = message.method_1().method_8();
						int num22 = message.method_1().method_0();
						for (int num23 = 0; num23 < num22; num23++)
						{
							GClass73 gClass11 = new GClass73(GClass69.gclass6_0, 37, num23);
							gClass11.playerInfo = new GClass25();
							gClass11.playerInfo.id = message.method_1().method_6();
							gClass11.playerInfo.name = message.method_1().method_11();
							gClass11.playerInfo.power = message.method_1().method_7();
							gClass11.playerInfo.classId = message.method_1().method_0();
							gClass11._object = gClass11.playerInfo.id;
							GClass25.gclass25_0.team.members.Add(gClass11);
						}
						break;
					}
					case 1:
						if (GClass25.gclass25_0.team != null)
						{
							GClass73 gClass12 = new GClass73(GClass69.gclass6_0, 37, 0);
							gClass12.playerInfo = new GClass25();
							gClass12.playerInfo.id = message.method_1().method_6();
							gClass12.playerInfo.name = message.method_1().method_11();
							gClass12.playerInfo.power = message.method_1().method_7();
							gClass12.playerInfo.classId = message.method_1().method_0();
							GClass25.gclass25_0.team.members.Add(gClass12);
						}
						break;
					case 2:
					{
						int num24 = message.method_1().method_6();
						if (GClass25.gclass25_0.id == num24)
						{
							GClass25.gclass25_0.team = null;
						}
						else
						{
							if (GClass25.gclass25_0.team == null)
							{
								break;
							}
							for (int num25 = 0; num25 < GClass25.gclass25_0.team.members.Count; num25++)
							{
								if (GClass25.gclass25_0.team.members[num25].playerInfo.id == num24)
								{
									GClass25.gclass25_0.team.members.RemoveAt(num25);
									break;
								}
							}
						}
						break;
					}
					case 3:
						if (GClass25.gclass25_0.team != null)
						{
							GClass25.gclass25_0.team.isLock = message.method_1().method_8();
							GClass79.smethod_3("Tổ đội đã được " + (GClass25.gclass25_0.team.isLock ? "khóa." : "mở khóa."), 1);
						}
						break;
					case 6:
					{
						int num20 = message.method_1().method_0();
						for (int num21 = 0; num21 < num20; num21++)
						{
							GClass73 gClass10 = new GClass73(GClass69.gclass6_0, 38, num21);
							gClass10.id = message.method_1().method_6();
							gClass10.playerInfo = new GClass25();
							gClass10.playerInfo.id = message.method_1().method_6();
							gClass10.playerInfo.name = message.method_1().method_11();
							gClass10.playerInfo.classId = message.method_1().method_0();
							gClass10.name = "Tổ đội của " + gClass10.playerInfo.name;
							gClass10.description = "Thành viên: " + message.method_1().method_0() + "/6";
							GClass6.list_5.Add(gClass10);
						}
						break;
					}
					}
					if (GClass69.gclass6_0.isShow && GClass69.gclass6_0.type == 11)
					{
						GClass69.gclass6_0.method_41(11);
					}
					break;
				case 32:
					GClass25.gclass25_0.typePk = message.method_1().method_0();
					break;
				case 33:
					GClass25.gclass25_0.typeFlag = message.method_1().method_0();
					break;
				case 34:
					GClass25.gclass25_0.pointPk = message.method_1().method_0();
					break;
				case 35:
				{
					GClass69.gclass6_0.mapTrains.Clear();
					GClass69.gclass6_0.lastMapTrainId = -1;
					int num15 = message.method_1().method_0();
					for (int n = 0; n < num15; n++)
					{
						GClass26 gClass7 = new GClass26();
						gClass7.name = message.method_1().method_11();
						gClass7.planetId = message.method_1().method_0();
						if (message.method_1().method_8())
						{
							GClass69.gclass6_0.lastMapTrainId = n;
						}
						GClass69.gclass6_0.mapTrains.Add(gClass7);
					}
					GClass69.gclass6_0.method_40(16);
					GClass69.gclass6_0.method_44();
					break;
				}
				case 36:
					GClass3.bool_3 = message.method_1().method_8();
					GClass79.smethod_3("Đã " + (GClass3.bool_3 ? "bật" : "tắt") + " Tự động luyện tập.", 1);
					break;
				case 37:
					GClass69.gclass6_0.method_40(message.method_1().method_0());
					GClass69.gclass6_0.method_44();
					break;
				case 38:
				{
					int index = message.method_1().method_0();
					int num7 = message.method_1().method_0();
					GClass25.gclass25_0.itemsBox[num7] = GClass25.gclass25_0.itemsBox[index].method_1();
					GClass25.gclass25_0.itemsBox[index] = null;
					GClass25.gclass25_0.itemsBox[num7].indexUI = num7;
					break;
				}
				case 39:
					GClass25.gclass25_0.potential = message.method_1().method_7();
					GClass25.gclass25_0.baseDamage = message.method_1().method_4();
					GClass25.gclass25_0.baseHp = message.method_1().method_4();
					GClass25.gclass25_0.baseMp = message.method_1().method_4();
					GClass25.gclass25_0.baseConstitution = message.method_1().method_4();
					GClass25.gclass25_0.potentialUpDamage = message.method_1().method_7();
					GClass25.gclass25_0.potentialUpHp = message.method_1().method_7();
					GClass25.gclass25_0.potentialUpMp = message.method_1().method_7();
					GClass25.gclass25_0.potentialUpConstitution = message.method_1().method_7();
					GClass79.smethod_3("Điểm tiềm năng đã được đặt lại.", 1);
					break;
				case 40:
				{
					GClass6.list_4.Clear();
					int num6 = message.method_1().method_0();
					for (int i = 0; i < num6; i++)
					{
						GClass73 gClass2 = new GClass73(GClass69.gclass6_0, 0, i);
						gClass2.id = i;
						gClass2.playerInfo = new GClass25();
						gClass2.playerInfo.id = message.method_1().method_6();
						gClass2.playerInfo.name = message.method_1().method_11();
						gClass2.playerInfo.classId = message.method_1().method_0();
						gClass2.playerInfo.power = message.method_1().method_7();
						GClass6.list_4.Add(gClass2);
					}
					GClass78.smethod_5();
					GClass69.gclass6_0.method_40(21);
					GClass69.gclass6_0.method_44();
					break;
				}
				case 41:
				{
					int num = message.method_1().method_6();
					int num2 = message.method_1().method_6();
					int num3 = 0;
					if (num > 0)
					{
						num3 = 30;
						GClass25.gclass25_0.hp += num;
						GClass3.smethod_1(GClass67.gclass67_19, "+" + num, GClass25.gclass25_0.x, GClass25.gclass25_0.y - GClass25.gclass25_0.imethod_3(), 0, -2);
					}
					if (num2 > 0)
					{
						GClass25.gclass25_0.mp += num2;
						GClass3.smethod_1(GClass67.gclass67_20, "+" + num2, GClass25.gclass25_0.x, GClass25.gclass25_0.y - GClass25.gclass25_0.imethod_3() + num3, 0, -2);
					}
					break;
				}
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}
	}
}
