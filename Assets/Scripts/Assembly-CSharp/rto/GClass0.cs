using System;
using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass0
	{
		public static int int_0 = 0;

		public static int int_1 = 1;

		public static int int_2 = 2;

		public static int int_3 = 3;

		public static int int_4 = 4;

		public static int int_5 = 5;

		public static int int_6 = 6;

		public static int int_7 = 7;

		public static int int_8 = 4;

		public static int int_9 = 5;

		public static int int_10 = 8;

		public static int int_11 = 0;

		public static int int_12 = 1;

		public static int int_13 = 2;

		public static int int_14 = 0;

		public static int int_15 = 1;

		public static long long_0;

		public static void smethod_0(string username, string password)
		{
			try
			{
				GClass61 gClass = new GClass61(-124);
				gClass.method_2().method_16(username);
				gClass.method_2().method_16(password);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_1(string name, int gender, int sex, int classId)
		{
			try
			{
				GClass61 gClass = new GClass61(-122);
				gClass.method_2().method_16(name);
				gClass.method_2().method_3(gender);
				gClass.method_2().method_3(sex);
				gClass.method_2().method_3(classId);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_2()
		{
			try
			{
				smethod_36(new GClass61(-115));
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_3()
		{
			int num = GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend;
			int num2 = GClass25.gclass25_0.y - GClass25.gclass25_0.cySend;
			if ((!GClass25.bool_1 || 1 == 0) && (((num != 0) ? true : false) || num2 != 0) && (!GClass81.bool_0 || 1 == 0) && (!GClass25.gclass25_0.isSpaceship || 1 == 0) && GClass25.gclass25_0.y > 0)
			{
				try
				{
					GClass61 gClass = new GClass61((sbyte)(-114));
					GClass25.gclass25_0.cxSend = GClass25.gclass25_0.x;
					GClass25.gclass25_0.cySend = GClass25.gclass25_0.y;
					gClass.method_2().method_9(GClass25.gclass25_0.x);
					gClass.method_2().method_9(GClass25.gclass25_0.y);
					smethod_36(gClass);
					gClass.method_4();
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
			}
		}

		public static void smethod_4()
		{
			try
			{
				GClass61 gClass = new GClass61(-113);
				smethod_36(gClass);
				gClass.method_4();
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_5(string text)
		{
			if (text != null && 0 == 0 && ((text.Length != 0) ? true : false))
			{
				if (text.Length > 200)
				{
					text = text.Substring(0, 200);
				}
				try
				{
					GClass61 gClass = new GClass61(-112);
					gClass.method_2().method_16(text);
					smethod_36(gClass);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
			}
		}

		public void method_0(int id, string text)
		{
			if (text != null && 0 == 0 && ((text.Length != 0) ? true : false))
			{
				if (text.Length > 200)
				{
					text = text.Substring(0, 200);
				}
				try
				{
					GClass61 gClass = new GClass61(-110);
					gClass.method_2().method_11(id);
					gClass.method_2().method_16(text);
					smethod_36(gClass);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
			}
		}

		public static void smethod_6(string text)
		{
			if (text != null && 0 == 0 && ((text.Length != 0) ? true : false))
			{
				if (text.Length > 200)
				{
					text = text.Substring(0, 200);
				}
				try
				{
					GClass61 gClass = new GClass61(-111);
					gClass.method_2().method_16(text);
					smethod_36(gClass);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
			}
		}

		public static void smethod_7(string text)
		{
			if (GClass25.gclass25_0.clan == null || 1 == 0 || text == null || false || text.Length == 0 || 1 == 0)
			{
				return;
			}
			if (text.Length > 200)
			{
				text = text.Substring(0, 200);
			}
			try
			{
				GClass61 gClass = new GClass61(-63);
				gClass.method_2().method_16(text);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_8(string text)
		{
			if (GClass25.gclass25_0.team == null || 1 == 0 || text == null || false || text.Length == 0 || 1 == 0)
			{
				return;
			}
			if (text.Length > 200)
			{
				text = text.Substring(0, 200);
			}
			try
			{
				GClass61 gClass = new GClass61(-62);
				gClass.method_2().method_16(text);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_9(string text, int playerId)
		{
			if (text != null && 0 == 0 && ((text.Length != 0) ? true : false))
			{
				if (text.Length > 200)
				{
					text = text.Substring(0, 200);
				}
				try
				{
					GClass61 gClass = new GClass61(-61);
					gClass.method_2().method_11(playerId);
					gClass.method_2().method_16(text);
					smethod_36(gClass);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
			}
		}

		public static void smethod_10(GInterface0 focus)
		{
			try
			{
				GClass61 gClass = new GClass61(-108);
				if (focus == null || 1 == 0)
				{
					gClass.method_2().method_3(-1);
				}
				else if (focus is GClass25 && 0 == 0)
				{
					gClass.method_2().method_3(0);
					gClass.method_2().method_11(((GClass25)focus).id);
				}
				else
				{
					gClass.method_2().method_3(1);
					gClass.method_2().method_3(((GClass23)focus).id);
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_11(GInterface0 focus)
		{
			if (GClass25.gclass25_0.mySkill.template.type == 1)
			{
				focus = null;
			}
			try
			{
				GClass61 gClass = new GClass61(-72);
				if (focus == null || 1 == 0)
				{
					gClass.method_2().method_3(-1);
				}
				else if (focus is GClass25 && 0 == 0)
				{
					gClass.method_2().method_3(0);
					gClass.method_2().method_11(((GClass25)focus).id);
				}
				else
				{
					gClass.method_2().method_3(1);
					gClass.method_2().method_3(((GClass23)focus).id);
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_12(int templateId)
		{
			try
			{
				GClass61 gClass = new GClass61(-103);
				gClass.method_2().method_0((sbyte)templateId);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_13()
		{
			try
			{
				GClass61 gClass = new GClass61(-97);
				smethod_36(gClass);
				gClass.method_4();
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_14()
		{
			try
			{
				GClass61 gClass = new GClass61(-96);
				smethod_36(gClass);
				gClass.method_4();
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_15(int templateId)
		{
			try
			{
				GClass61 gClass = new GClass61(-93);
				gClass.method_2().method_0((sbyte)templateId);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_16(int templateId, int select)
		{
			try
			{
				GClass61 gClass = new GClass61(-92);
				gClass.method_2().method_0((sbyte)templateId);
				gClass.method_2().method_0((sbyte)select);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_17(int index, int point)
		{
			if (GClass25.gclass25_0.task == null || 1 == 0)
			{
				return;
			}
			if (GClass25.gclass25_0.task.id >= 1 && (GClass25.gclass25_0.task.id != 1 || GClass25.gclass25_0.task.index >= 2))
			{
				try
				{
					GClass61 gClass = new GClass61(-90);
					gClass.method_2().method_0((sbyte)index);
					gClass.method_2().method_9(point);
					smethod_36(gClass);
					return;
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
					return;
				}
			}
			GClass79.smethod_3("Chưa đủ cấp độ để nâng cấp!", 0);
		}

		public static void smethod_18(int templateId, int point)
		{
			if (GClass25.gclass25_0.task == null || 1 == 0)
			{
				return;
			}
			if (GClass25.gclass25_0.task.id >= 1 && (GClass25.gclass25_0.task.id != 1 || GClass25.gclass25_0.task.index >= 1))
			{
				try
				{
					GClass61 gClass = new GClass61(-89);
					gClass.method_2().method_0((sbyte)templateId);
					gClass.method_2().method_0((sbyte)point);
					smethod_36(gClass);
					return;
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
					return;
				}
			}
			GClass79.smethod_3("Chưa đủ cấp độ để nâng cấp!", 0);
		}

		public static void smethod_19(int playerId, int diamond)
		{
			try
			{
				GClass61 gClass = new GClass61(-52);
				gClass.method_2().method_11(playerId);
				gClass.method_2().method_11(diamond);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_20(int type, int index)
		{
			try
			{
				GClass61 gClass = new GClass61(-88);
				gClass.method_2().method_0((sbyte)type);
				gClass.method_2().method_0((sbyte)index);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_21(int index, int tempId)
		{
			try
			{
				GClass61 gClass = new GClass61(-86);
				gClass.method_2().method_0((sbyte)index);
				gClass.method_2().method_0((sbyte)tempId);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_22(int areaId)
		{
			if (Class0.int_3 == areaId)
			{
				GClass79.smethod_3("Bạn đang ở khu vực này", 0);
			}
			else if (GClass84.smethod_1() - long_0 >= 500L)
			{
				GClass78.smethod_1();
				long_0 = GClass84.smethod_1();
				try
				{
					GClass61 gClass = new GClass61(-84);
					gClass.method_2().method_0((sbyte)areaId);
					smethod_36(gClass);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
			}
		}

		public static void smethod_23(int select)
		{
			if (GClass25.gclass25_0.hp > 0L && (!GClass25.gclass25_0.isDead || 1 == 0) && !GClass25.gclass25_0.isDie)
			{
				try
				{
					GClass61 gClass = new GClass61(-59);
					gClass.method_2().method_0((sbyte)select);
					smethod_36(gClass);
					return;
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
					return;
				}
			}
			GClass79.smethod_3("Không thể thực hiện khi đang kiệt sức.", 0);
		}

		public static void smethod_24(int itemMapId)
		{
			try
			{
				GClass61 gClass = new GClass61(-79);
				gClass.method_2().method_11(itemMapId);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_25(int itemShopId)
		{
			try
			{
				GClass61 gClass = new GClass61(-78);
				gClass.method_2().method_9(itemShopId);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_26(int index)
		{
			try
			{
				GClass61 gClass = new GClass61(-76);
				gClass.method_2().method_3(index);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_27(int type, int playerId)
		{
			try
			{
				GClass61 gClass = new GClass61(-75);
				gClass.method_2().method_3(type);
				if (type != 0 && 0 == 0)
				{
					gClass.method_2().method_11(playerId);
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_28(int type, int playerId)
		{
			try
			{
				GClass61 gClass = new GClass61(-74);
				gClass.method_2().method_3(type);
				if (type != 0 && 0 == 0)
				{
					gClass.method_2().method_11(playerId);
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_29(int type, int playerId)
		{
			try
			{
				GClass61 gClass = new GClass61(-71);
				gClass.method_2().method_3(type);
				if (type == 0 || false || type == 4 || type == 5 || type == 7)
				{
					gClass.method_2().method_11(playerId);
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_30(int type, int playerId)
		{
			try
			{
				GClass61 gClass = new GClass61(-66);
				gClass.method_2().method_3(type);
				if (type == 0 || false || type == 4 || type == 5 || type == 7)
				{
					gClass.method_2().method_11(playerId);
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_31(int type, int index)
		{
			try
			{
				GClass61 gClass = new GClass61(-64);
				gClass.method_2().method_3(type);
				gClass.method_2().method_3(index);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_32(GClass16 item, List<GClass16> items)
		{
			if (item == null || 1 == 0 || items == null || false || items.Count == 0 || 1 == 0)
			{
				return;
			}
			try
			{
				GClass61 gClass = new GClass61(-58);
				gClass.method_2().method_3(item.indexUI);
				gClass.method_2().method_3(items.Count);
				using (List<GClass16>.Enumerator enumerator = items.GetEnumerator())
				{
					while (enumerator.MoveNext() ? true : false)
					{
						GClass16 current = enumerator.Current;
						gClass.method_2().method_3(current.indexUI);
					}
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_33(List<GClass16> items)
		{
			if (items == null || false || items.Count == 0 || 1 == 0)
			{
				return;
			}
			try
			{
				GClass61 gClass = new GClass61(-56);
				gClass.method_2().method_3(items.Count);
				using (List<GClass16>.Enumerator enumerator = items.GetEnumerator())
				{
					while (enumerator.MoveNext() ? true : false)
					{
						GClass16 current = enumerator.Current;
						gClass.method_2().method_3(current.indexUI);
					}
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_34(int id)
		{
			GClass69.smethod_1();
			try
			{
				GClass61 gClass = new GClass61(-57);
				gClass.method_2().method_9(id);
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_35(int type, int playerId, int index)
		{
			try
			{
				GClass61 gClass = new GClass61(-55);
				gClass.method_2().method_3(type);
				if (type == 0 || 1 == 0)
				{
					gClass.method_2().method_11(playerId);
				}
				else
				{
					switch (type)
					{
					case 5:
						if (index > GClass25.gclass25_0.xu)
						{
							GClass79.smethod_3("Bạn không đủ xu để giao dịch.", 0);
							return;
						}
						gClass.method_2().method_11(index);
						break;
					case 3:
					case 4:
						gClass.method_2().method_3(index);
						break;
					}
				}
				smethod_36(gClass);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public static void smethod_36(GClass61 message)
		{
			GClass65.smethod_3(message);
		}
	}
}
