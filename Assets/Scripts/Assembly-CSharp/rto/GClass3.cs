using System;
using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass3 : GClass1, GInterface1, GInterface2
	{
		public static int int_0;

		public static int int_1;

		public static int int_2;

		public static int int_3;

		public static GClass3 gclass3_0;

		public static List<GClass23> list_0;

		public static List<GClass25> list_1;

		public static List<GClass24> list_2;

		public static List<GClass22> list_3;

		public static List<GClass13> list_4;

		public static List<GClass44> list_5;

		public static GClass54 gclass54_0;

		public static int int_4;

		public static int int_5;

		public static int int_6;

		public static int int_7;

		public static int int_8;

		public static GClass34[] gclass34_0;

		public static GClass66 gclass66_0;

		public static GClass66 gclass66_1;

		public static GClass66 gclass66_2;

		public static GClass72 gclass72_0;

		public static bool bool_0;

		public static GClass66 gclass66_3;

		public static GClass66 gclass66_4;

		public static GClass66 gclass66_5;

		public static GClass66 gclass66_6;

		public static GClass66 gclass66_7;

		public static GClass66 gclass66_8;

		public static GClass66 gclass66_9;

		public static GClass66 gclass66_10;

		public static GClass66 gclass66_11;

		public static GClass66 gclass66_12;

		public static GClass66 gclass66_13;

		public static GClass66 gclass66_14;

		public static GClass66 gclass66_15;

		public static GClass66 gclass66_16;

		public static GClass66 gclass66_17;

		public static GClass66 gclass66_18;

		public static GClass66 gclass66_19;

		public static GClass66 gclass66_20;

		public int tMenuDelay;

		public static bool bool_1;

		public static GClass66 gclass66_21;

		public GClass72 cmdChat;

		public GClass72 cmdMenu;

		public GClass72 cmdChangeFocus;

		public GClass72 cmdPean;

		public GClass72 cmdAttack;

		public GClass72 cmdSpecialSkill;

		public GClass72 cmdQues;

		public static GClass66 gclass66_22;

		public static GClass66 gclass66_23;

		public static GClass66 gclass66_24;

		public static GClass66 gclass66_25;

		public static GClass66 gclass66_26;

		public GClass71 gamePad;

		public static GClass66[] gclass66_27;

		public static GClass66[] gclass66_28;

		public static GClass66 gclass66_29;

		public static GClass66 gclass66_30;

		public static GClass66 gclass66_31;

		public static int int_9;

		public static int[] int_10;

		public static int[] int_11;

		public static string[] string_0;

		public static int int_12;

		public static long long_0;

		public static int int_13;

		public static bool bool_2;

		public static bool bool_3;

		public static long long_1;

		public GClass51 textGlobal;

		public bool isUseFreez;

		public int dem;

		public static long long_2;

		public static long long_3;

		public static bool bool_4;

		public static bool bool_5;

		public static List<GClass16> list_6;

		public bool isPaintItemSpin;

		public int xPaintItemSpin;

		public int yPaintItemSpin;

		public int wPaintItemSpin;

		public int hPaintItemSpin;

		public int cmxPaintItemSpin;

		public int cmxToPaintItemSpin;

		public long lastTimeDelaySpin;

		public GClass3()
		{
			gclass54_0.parentScreen = this;
			gclass72_0 = new GClass72(GClass83.string_0[0], this, 1, null);
			gclass72_0.isShow = false;
			gclass72_0.y = GClass69.int_2 - gclass72_0.h - 10;
			gclass72_0.x = GClass69.int_1 / 2 - gclass72_0.w / 2;
			cmdChat = new GClass72(gclass66_14, gclass66_15, gclass66_22, this, 18, null);
			cmdMenu = new GClass72(gclass66_10, gclass66_11, gclass66_23, this, 19, null);
			cmdChangeFocus = new GClass72(gclass66_12, gclass66_13, gclass66_24, this, 20, null);
			cmdPean = new GClass72(gclass66_7, gclass66_8, gclass66_25, this, 21, null);
			cmdSpecialSkill = new GClass72(gclass66_19, gclass66_20, gclass66_26, this, 22, null);
			cmdAttack = new GClass72(gclass66_16, gclass66_17, gclass66_18, this, 23, null);
			cmdQues = new GClass72(gclass66_29, gclass66_30, gclass66_31, this, 24, null);
			cmdQues.isShow = false;
			cmdQues.anchor = GClass45.int_6;
			cmdQues.isFollowWithCamera = true;
			method_0();
			gamePad = new GClass71();
			textGlobal = new GClass51();
		}

		static GClass3()
		{
			int_10 = new int[4] { 3, -3, 3, -3 };
			int_11 = new int[4] { 3, -3, -3, 3 };
			string_0 = new string[6] { "Tắt", "Đồ sát", "Cờ Đỏ", "Cờ Xanh", "Cờ Vàng", "Cờ Lục" };
			list_6 = new List<GClass16>();
			list_0 = new List<GClass23>();
			list_1 = new List<GClass25>();
			list_2 = new List<GClass24>();
			list_3 = new List<GClass22>();
			list_5 = new List<GClass44>();
			gclass54_0 = new GClass54();
			gclass54_0.name = "Chat";
			gclass54_0.textField.name = "chat";
			list_4 = new List<GClass13>();
			gclass66_0 = GClass69.smethod_9("imgSkill0.png");
			gclass66_1 = GClass69.smethod_9("imgSkill1.png");
			gclass66_4 = GClass69.smethod_9("imgHp.png");
			gclass66_5 = GClass69.smethod_9("imgMp.png");
			gclass66_3 = GClass69.smethod_9("imgBar.png");
			gclass66_2 = GClass69.smethod_9("imgFocus.png");
			gclass66_7 = GClass69.smethod_9("imgPean.png");
			gclass66_8 = GClass69.smethod_9("imgPeanFocus.png");
			gclass66_25 = GClass69.smethod_9("imgPeanClick.png");
			gclass66_12 = GClass69.smethod_9("imgChange.png");
			gclass66_13 = GClass69.smethod_9("imgChangeFocus.png");
			gclass66_24 = GClass69.smethod_9("imgChangeClick.png");
			gclass66_10 = GClass69.smethod_9("imgMenu.png");
			gclass66_11 = GClass69.smethod_9("imgMenuFocus.png");
			gclass66_23 = GClass69.smethod_9("imgMenuClick.png");
			gclass66_14 = GClass69.smethod_9("imgChat.png");
			gclass66_15 = GClass69.smethod_9("imgChatFocus.png");
			gclass66_22 = GClass69.smethod_9("imgChatClick.png");
			gclass66_16 = GClass69.smethod_9("imgAttack.png");
			gclass66_17 = GClass69.smethod_9("imgAttackFocus.png");
			gclass66_18 = GClass69.smethod_9("imgAttackClick.png");
			gclass66_19 = GClass69.smethod_9("imgSpecialSkill.png");
			gclass66_20 = GClass69.smethod_9("imgSpecialSkillFocus.png");
			gclass66_26 = GClass69.smethod_9("imgSpecialSkillClick.png");
			gclass66_29 = GClass69.smethod_9("imgQues.png");
			gclass66_30 = GClass69.smethod_9("imgQuesFocus.png");
			gclass66_31 = GClass69.smethod_9("imgQuesClick.png");
			gclass66_9 = GClass69.smethod_9("cooldownPean.png");
			gclass66_21 = GClass69.smethod_9("imgHintWay.png");
			gclass34_0 = new GClass34[5];
			int_7 = 90;
			int_6 = 90;
			int_8 = 15;
			int_4 = GClass69.int_1 / 2 - (int_6 * gclass34_0.Length + int_8 * (gclass34_0.Length - 1)) / 2;
			int_5 = GClass69.int_2 - int_7 - 20;
			bool_0 = true;
			gclass66_27 = new GClass66[7];
			for (int i = 0; i < gclass66_27.Length; i++)
			{
				gclass66_27[i] = GClass69.smethod_9("imgClass" + i);
			}
			gclass66_28 = new GClass66[7];
			for (int j = 0; j < gclass66_28.Length; j++)
			{
				gclass66_28[j] = GClass69.smethod_9("imgClassMini" + j);
			}
			int num = GClass64.smethod_8("isPaintTask");
			if (num == -1)
			{
				bool_4 = true;
			}
			else
			{
				bool_4 = num == 1;
			}
			int num2 = GClass64.smethod_8("isPaintGamePad");
			if (num2 == -1)
			{
				bool_5 = true;
			}
			else
			{
				bool_5 = num2 == 1;
			}
			int num3 = GClass64.smethod_8("isPaintMiniMap");
			if (num3 == -1)
			{
				Class0.bool_0 = true;
			}
			else
			{
				Class0.bool_0 = num3 == 1;
			}
		}

		public void method_0()
		{
			if (!GClass69.bool_2 || 1 == 0)
			{
				cmdAttack.x = GClass69.int_1 - cmdAttack.w - 20;
				cmdAttack.y = GClass69.int_2 - cmdAttack.h - 20;
				cmdPean.x = cmdAttack.x - 20 - cmdPean.w;
				cmdPean.y = GClass69.int_2 - cmdPean.h - 20;
				cmdChangeFocus.x = GClass69.int_1 - 20 - cmdChangeFocus.w;
				cmdChangeFocus.y = cmdAttack.y - cmdChangeFocus.h - 20;
				cmdSpecialSkill.x = cmdAttack.x - cmdSpecialSkill.w + 13;
				cmdSpecialSkill.y = cmdAttack.y - cmdSpecialSkill.h + 13;
				int num = GClass69.int_1;
				int y = 20;
				if (Class0.bool_0 && 0 == 0)
				{
					num = Class0.int_11 - 8;
				}
				cmdChat.x = num - cmdChat.w - 20;
				cmdChat.y = y;
				cmdMenu.x = num - cmdMenu.w - cmdChat.w - 40;
				cmdMenu.y = y;
			}
		}

		public static GClass3 smethod_0()
		{
			if (gclass3_0 == null || 1 == 0)
			{
				gclass3_0 = new GClass3();
			}
			return gclass3_0;
		}

		public override void vmethod_1(GClass68 g)
		{
			GClass69.smethod_7(g);
			if (GClass25.gclass25_0.isBlind || isUseFreez)
			{
				dem++;
				if ((dem < 40 && dem >= 0 && GClass69.int_0 % 4 == 0) || (dem >= 40 && dem <= 70 && GClass69.int_0 % 3 == 0) || dem > 70)
				{
					g.method_11(16777215);
					g.method_7(0, 0, GClass69.int_1, GClass69.int_2);
					if (dem <= 70)
					{
						return;
					}
					if (isUseFreez)
					{
						isUseFreez = false;
						dem = 0;
					}
					g.method_1(-int_0, -int_1);
					GClass25.gclass25_0.vmethod_0(g);
					foreach (GClass13 item in list_4)
					{
						item.method_0(g);
					}
					g.method_31();
					method_5(g);
					method_4(g);
					method_1(g);
					method_2(g);
					textGlobal.method_0(g);
					return;
				}
			}
			Class0.smethod_1(g);
			g.method_1(-int_0, -int_1);
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].method_2(g);
			}
			foreach (GClass24 item2 in list_2)
			{
				if (item2.method_1())
				{
					g.method_28(Class0.gclass66_2, item2.x, item2.y - 3, 3);
				}
			}
			foreach (GClass25 item3 in list_1)
			{
				item3.method_22(g);
			}
			GClass25.gclass25_0.method_22(g);
			foreach (GClass44 item4 in list_5)
			{
				item4.method_1(g);
			}
			foreach (GClass24 item5 in list_2)
			{
				item5.method_0(g);
			}
			foreach (GClass23 item6 in list_0)
			{
				if (item6.frame != 7)
				{
					item6.vmethod_0(g);
				}
			}
			foreach (GClass44 item7 in list_5)
			{
				item7.method_0(g);
			}
			foreach (GClass25 item8 in list_1)
			{
				if (item8.frame <= 10)
				{
					item8.vmethod_0(g);
				}
			}
			if (GClass25.gclass25_0.frame <= 10)
			{
				GClass25.gclass25_0.vmethod_0(g);
			}
			foreach (GClass25 item9 in list_1)
			{
				item9.chatInfo.method_0(g, item9.x, item9.y - item9.h, item9.dir);
			}
			GClass25.gclass25_0.chatInfo.method_0(g, GClass25.gclass25_0.x, GClass25.gclass25_0.y - GClass25.gclass25_0.h, GClass25.gclass25_0.dir);
			foreach (GClass53 item10 in Class0.list_0)
			{
				item10.method_0(g);
			}
			foreach (GClass22 item11 in list_3)
			{
				item11.method_0(g);
			}
			foreach (GClass23 item12 in list_0)
			{
				if (item12.frame == 7)
				{
					item12.vmethod_0(g);
				}
			}
			foreach (GClass25 item13 in list_1)
			{
				if (item13.frame > 10)
				{
					item13.vmethod_0(g);
				}
			}
			if (GClass25.gclass25_0.frame > 10)
			{
				GClass25.gclass25_0.vmethod_0(g);
			}
			for (int j = 0; j < GClass28.list_0.Count; j++)
			{
				GClass28.list_0[j].method_1(g);
			}
			foreach (GClass25 item14 in list_1)
			{
				if (item14.dart != null)
				{
					item14.dart.method_3(g);
				}
			}
			if (GClass25.gclass25_0.dart != null)
			{
				GClass25.gclass25_0.dart.method_3(g);
			}
			foreach (GClass13 item15 in list_4)
			{
				item15.method_0(g);
			}
			g.method_31();
			method_5(g);
			method_4(g);
			if (gclass72_0.isShow)
			{
				gclass72_0.vmethod_0(g);
			}
			if (gclass54_0.isShow)
			{
				gclass54_0.method_0(g);
			}
			g.method_31();
			int num = 0;
			foreach (GClass9 effect in GClass25.gclass25_0.effects)
			{
				if (effect.type == 1)
				{
					effect.method_1(g, 60 + num * 60, 200);
					num++;
				}
			}
			if (bool_4)
			{
				string text = "";
				if (GClass25.gclass25_0.task.subTasks[GClass25.gclass25_0.task.index].param > 0)
				{
					text = " [" + GClass25.gclass25_0.task.param + "/" + GClass25.gclass25_0.task.subTasks[GClass25.gclass25_0.task.index].param + "]";
				}
				GClass67.gclass67_14.method_1(g, GClass25.gclass25_0.task.subTasks[GClass25.gclass25_0.task.index].name + text, 32, 250, 0);
			}
			if (GClass25.gclass25_0.mobFocus != null)
			{
				GClass67.gclass67_14.method_1(g, GClass25.gclass25_0.mobFocus.template.name + " lv" + GClass25.gclass25_0.mobFocus.template.level + ": " + GClass84.smethod_16(GClass25.gclass25_0.mobFocus.hp) + "/" + GClass84.smethod_16(GClass25.gclass25_0.mobFocus.maxHp), 32, 280, 0);
			}
			else if (GClass25.gclass25_0.playerFocus != null)
			{
				GClass67.gclass67_14.method_1(g, GClass25.gclass25_0.playerFocus.name + " lv" + GClass25.gclass25_0.playerFocus.level + ": " + GClass84.smethod_16(GClass25.gclass25_0.playerFocus.hp) + "/" + GClass84.smethod_16(GClass25.gclass25_0.playerFocus.maxHp), 32, 280, 0);
			}
			method_1(g);
			method_2(g);
			textGlobal.method_0(g);
			method_7(g);
		}

		public void method_1(GClass68 g)
		{
			if (GClass25.gclass25_0.team == null || 1 == 0)
			{
				return;
			}
			int num = 170;
			for (int i = 0; i < GClass25.gclass25_0.team.members.Count; i++)
			{
				g.method_12(264f, 181f, 115f);
				g.method_9(GClass69.int_1 - 60, num, 50, 50, 4);
				GClass73 gClass = GClass25.gclass25_0.team.members[i];
				if (gClass.playerInfo.classId == -1)
				{
					g.method_28(gclass66_28[5], GClass69.int_1 - 10, num, GClass45.int_2);
				}
				else
				{
					g.method_28(gclass66_28[gClass.playerInfo.classId], GClass69.int_1 - 10, num, GClass45.int_2);
				}
				if (GClass25.gclass25_0.id == gClass.playerInfo.id)
				{
					GClass67.gclass67_14.method_1(g, GClass25.gclass25_0.name + " (lv" + GClass25.gclass25_0.level + ")", GClass69.int_1 - 70, num, 1);
					GClass25.gclass25_0.method_4(g, GClass69.int_1 - 115, num + 43);
				}
				else
				{
					GClass25 gClass2 = smethod_6(gClass.playerInfo.id);
					if (gClass2 != null && 0 == 0)
					{
						GClass67.gclass67_14.method_1(g, gClass2.name + " (lv" + gClass2.method_50() + ")", GClass69.int_1 - 70, num, 1);
						gClass2.method_4(g, GClass69.int_1 - 115, num + 43);
					}
					else
					{
						GClass67.gclass67_7.method_1(g, gClass.playerInfo.name + " (lv" + GClass25.smethod_6(gClass.playerInfo.power) + ")", GClass69.int_1 - 70, num, 1);
						GClass25.smethod_3(g, GClass69.int_1 - 115, num + 43);
					}
				}
				num += 60;
			}
		}

		public void method_2(GClass68 g)
		{
			if (GClass25.gclass25_0.task == null || 1 == 0)
			{
				return;
			}
			try
			{
				GClass49 gClass = GClass25.gclass25_0.task.subTasks[GClass25.gclass25_0.task.index];
				if (gClass.npcId == -1)
				{
					return;
				}
				GClass24 gClass2 = smethod_8(gClass.npcId);
				if (gClass2 != null && 0 == 0 && (!gClass2.method_1() || 1 == 0))
				{
					if (gClass2.x < GClass25.gclass25_0.x)
					{
						GClass42.smethod_1(g, 283, (GClass69.int_0 % 30 < 15) ? 5 : 8, GClass69.int_2 / 2, 2, GClass45.int_4);
					}
					else if (gClass2.x > GClass25.gclass25_0.x)
					{
						GClass42.smethod_1(g, 283, GClass69.int_1 - ((GClass69.int_0 % 30 < 15) ? 5 : 8), GClass69.int_2 / 2, 0, GClass45.int_5);
					}
				}
			}
			catch
			{
			}
		}

		public void method_3(GClass68 g)
		{
			int w = (int)((GClass25.gclass25_0.power - GClass69.list_4[GClass25.gclass25_0.level].power) * GClass69.int_1 / (GClass69.list_4[GClass25.gclass25_0.level + 1].power - GClass69.list_4[GClass25.gclass25_0.level].power));
			g.method_11(6191872);
			g.method_7(0, GClass69.int_2 - 7, GClass69.int_1, 7);
			g.method_11(6350080);
			g.method_7(0, GClass69.int_2 - 5, w, 5);
			g.method_11(7020544);
			g.method_7(0, GClass69.int_2 - 7, GClass69.int_1, 1);
			g.method_7(0, GClass69.int_2 - 1, GClass69.int_1, 1);
			for (int i = 0; i < 10; i++)
			{
				g.method_7(i * GClass69.int_1 / 10 - 1, GClass69.int_2 - 7, 1, 7);
			}
		}

		public void method_4(GClass68 g)
		{
			g.method_30(gclass66_3, 0, 0);
			int w = (int)(long_2 * gclass66_4.method_0() / GClass25.gclass25_0.maxHp);
			g.method_20(gclass66_4, 0, 0, w, gclass66_4.method_1(), 0, 145, 25, GClass45.int_1);
			int w2 = (int)(long_3 * gclass66_5.method_0() / GClass25.gclass25_0.maxMp);
			g.method_20(gclass66_5, 0, 0, w2, gclass66_5.method_1(), 0, 129, 70, GClass45.int_1);
			GClass31 gClass = GClass69.list_2[GClass25.gclass25_0.head];
			GClass42.smethod_2(g, gClass.pi[4].id, 70 + gClass.pi[4].dx, 55 + gClass.pi[4].dy, 0f);
		}

		public void method_5(GClass68 g)
		{
			if (!bool_0 || 1 == 0 || (GClass69.gclass6_0.isShow ? true : false) || (gclass54_0.isShow ? true : false) || GClass69.gclass80_0.isShow)
			{
				return;
			}
			g.method_1(-int_0, -int_1);
			if (cmdQues.isShow && 0 == 0)
			{
				cmdQues.vmethod_0(g);
			}
			g.method_31();
			if (cmdPean.isShow && 0 == 0)
			{
				cmdPean.vmethod_0(g);
				int_12 = method_9();
				GClass67.gclass67_13.method_1(g, int_12.ToString(), cmdPean.x + cmdPean.w / 2, cmdPean.y + cmdPean.h / 2 - 10, 2);
				if (!cmdPean.isClick || 1 == 0)
				{
					long num = GClass84.smethod_1() - long_0;
					if (num < 10000L)
					{
						int num2 = (int)(num * gclass66_9.method_1() / 10000L);
						g.method_20(gclass66_9, 0, num2, gclass66_9.method_0(), gclass66_9.method_1() - num2, 0, cmdPean.x, cmdPean.y + num2, GClass45.int_1);
					}
				}
			}
			if (cmdChat.isShow && 0 == 0)
			{
				cmdChat.vmethod_0(g);
			}
			if (cmdMenu.isShow && 0 == 0)
			{
				cmdMenu.vmethod_0(g);
				if (GClass69.gclass6_0.method_50() && 0 == 0 && GClass69.int_0 % 20 < 10)
				{
					g.method_28(GClass22.gclass66_0, cmdMenu.x + cmdMenu.w / 2, cmdMenu.y + cmdMenu.h / 2, GClass45.int_6);
				}
			}
			if (cmdChangeFocus.isShow && 0 == 0)
			{
				cmdChangeFocus.vmethod_0(g);
			}
			if (cmdAttack.isShow && 0 == 0)
			{
				cmdAttack.vmethod_0(g);
			}
			if (cmdSpecialSkill.isShow && 0 == 0)
			{
				cmdSpecialSkill.vmethod_0(g);
			}
			gamePad.method_0(g);
			for (int i = 0; i < gclass34_0.Length; i++)
			{
				if (gclass34_0[i] != GClass25.gclass25_0.mySkill)
				{
					g.method_28(gclass66_0, int_4 + (int_6 + int_8) * i, int_5, GClass45.int_1);
				}
				if (gclass34_0[i] != null && 0 == 0)
				{
					if (gclass34_0[i] == GClass25.gclass25_0.mySkill)
					{
						g.method_28(gclass66_1, int_4 + (int_6 + int_8) * i, int_5, GClass45.int_1);
					}
					gclass34_0[i].method_0(g, int_4 + (int_6 + int_8) * i + 10, int_5 + 10);
				}
			}
			method_3(g);
		}

		public void method_6()
		{
			GClass69.gclass6_0.method_46();
			wPaintItemSpin = 375;
			hPaintItemSpin = 75;
			xPaintItemSpin = (GClass69.int_1 - wPaintItemSpin) / 2;
			yPaintItemSpin = GClass69.int_2 / 2 - hPaintItemSpin * 2;
			List<GClass16> list = new List<GClass16>();
			list.AddRange(list_6);
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < list.Count; j++)
				{
					list_6.Add(list[j]);
				}
			}
			cmxPaintItemSpin = xPaintItemSpin + 37;
			cmxToPaintItemSpin = xPaintItemSpin - 75 * (list.Count * 2 + 4) + 37;
			lastTimeDelaySpin = GClass84.smethod_1();
			isPaintItemSpin = true;
		}

		public void method_7(GClass68 g)
		{
			if (isPaintItemSpin ? true : false)
			{
				g.method_31();
				g.method_18(0, 0.5f);
				g.method_9(xPaintItemSpin, yPaintItemSpin, wPaintItemSpin, hPaintItemSpin, 10);
				g.method_5(xPaintItemSpin, yPaintItemSpin, wPaintItemSpin, hPaintItemSpin);
				for (int i = 0; i < list_6.Count; i++)
				{
					GClass42.smethod_1(g, list_6[i].template.iconId, cmxPaintItemSpin + i * 75, yPaintItemSpin + 37, 0, GClass45.int_6);
				}
				g.method_14(Color.white);
				g.method_7(xPaintItemSpin + wPaintItemSpin / 2, yPaintItemSpin, 1, hPaintItemSpin);
			}
		}

		public void method_8()
		{
			if (cmxPaintItemSpin < cmxToPaintItemSpin)
			{
				lastTimeDelaySpin = GClass84.smethod_1();
				int num = cmxToPaintItemSpin - cmxPaintItemSpin >> 4;
				if (num < 1)
				{
					num = 1;
				}
				cmxPaintItemSpin += num;
			}
			else if (cmxPaintItemSpin > cmxToPaintItemSpin)
			{
				lastTimeDelaySpin = GClass84.smethod_1();
				int num2 = cmxPaintItemSpin - cmxToPaintItemSpin >> 4;
				if (num2 < 1)
				{
					num2 = 1;
				}
				cmxPaintItemSpin -= num2;
			}
			else if (GClass84.smethod_1() - lastTimeDelaySpin > 1000L)
			{
				lastTimeDelaySpin = GClass84.smethod_1();
				if (list_6[6].template.type == GClass16.int_15)
				{
					GClass79.smethod_3("Bạn nhận được " + list_6[6].quantity + " xu", 1);
				}
				else if (list_6[6].template.type == GClass16.int_16)
				{
					GClass79.smethod_3("Bạn nhận được " + list_6[6].quantity + " kim cương", 1);
				}
				else
				{
					GClass79.smethod_3("Bạn nhận được " + ((list_6[6].quantity > 1) ? (list_6[6].quantity + " ") : "") + list_6[6].template.name, 1);
				}
				isPaintItemSpin = false;
			}
		}

		public int method_9()
		{
			int num = 0;
			try
			{
				for (int i = 0; i < GClass25.gclass25_0.itemsBag.Count; i++)
				{
					if (GClass25.gclass25_0.itemsBag[i] != null && 0 == 0 && GClass25.gclass25_0.itemsBag[i].template.type == 19)
					{
						num += GClass25.gclass25_0.itemsBag[i].quantity;
					}
				}
			}
			catch
			{
			}
			return num;
		}

		private void method_10()
		{
			if (!bool_3 || false || GClass25.gclass25_0.status == 14 || GClass25.gclass25_0.status == 5)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].status != 0 && 0 == 0 && list_0[i].status != 1 && (list_0[i].level == 0 || 1 == 0))
				{
					flag = true;
					break;
				}
			}
			if (!flag || 1 == 0)
			{
				return;
			}
			if ((GClass25.gclass25_0.hp <= GClass25.gclass25_0.maxHp / 5L || GClass25.gclass25_0.mp <= GClass25.gclass25_0.maxMp / 5L) && int_12 > 0 && (GClass69.int_0 % 20 == 0 || 1 == 0))
			{
				method_15();
			}
			GClass25.gclass25_0.playerFocus = null;
			GClass25.gclass25_0.itemFocus = null;
			GClass25.gclass25_0.npcFocus = null;
			if (GClass25.gclass25_0.mobFocus == null || 1 == 0)
			{
				for (int j = 0; j < list_0.Count; j++)
				{
					GClass23 gClass = list_0[GClass84.smethod_8(0, j - 1)];
					if (gClass.status != 0 && 0 == 0 && gClass.status != 1 && gClass.hp > 0L && (gClass.level == 0 || 1 == 0))
					{
						if (GClass25.gclass25_0.x < gClass.x)
						{
							GClass25.gclass25_0.dir = 1;
						}
						else
						{
							GClass25.gclass25_0.dir = -1;
						}
						GClass25.gclass25_0.x = gClass.x - 20 * GClass25.gclass25_0.dir;
						GClass25.gclass25_0.y = gClass.y;
						GClass25.gclass25_0.method_44(gClass);
						GClass0.smethod_3();
						break;
					}
				}
			}
			else if (GClass25.gclass25_0.mobFocus.hp <= 0L || GClass25.gclass25_0.mobFocus.status == 1 || GClass25.gclass25_0.mobFocus.status == 0 || 1 == 0)
			{
				GClass25.gclass25_0.mobFocus = null;
			}
			if (GClass25.gclass25_0.mobFocus == null || false || ((GClass25.gclass25_0.skillPaint != null) ? true : false) || ((GClass25.gclass25_0.method_15() != null) ? true : false) || (GClass25.gclass25_0.method_15() != null && 0 == 0 && GClass25.gclass25_0.skillPaint.index < GClass25.gclass25_0.method_15().Count) || GClass25.gclass25_0.dart != null)
			{
				return;
			}
			GClass34 gClass2 = null;
			for (int k = 0; k < gclass34_0.Length; k++)
			{
				if (gclass34_0[k] == null || false || (gclass34_0[k].isPaintCanNotUse ? true : false) || !gclass34_0[k].template.isProactive || false || gclass34_0[k].template.id == 13)
				{
					continue;
				}
				int num = (int)((gclass34_0[k].template.typeManaUse == 0) ? gclass34_0[k].method_1() : (gclass34_0[k].method_1() * GClass25.gclass25_0.mp / 100L));
				if (GClass25.gclass25_0.mp >= num)
				{
					if (gClass2 == null || 1 == 0)
					{
						gClass2 = gclass34_0[k];
					}
					else if (gClass2.method_3() < gclass34_0[k].method_3())
					{
						gClass2 = gclass34_0[k];
					}
				}
			}
			if (gClass2 != null && 0 == 0)
			{
				method_26(gClass2);
				method_22();
			}
		}

		public override void vmethod_0()
		{
			try
			{
				if ((GClass65.tcpClient_0 != null && 0 == 0 && !GClass65.tcpClient_0.Connected) || ((GClass65.tcpClient_0 == null || 1 == 0) && (!GClass65.bool_0 || 1 == 0)))
				{
					GClass65.list_0.Clear();
					GClass65.list_1.Clear();
					if (GClass69.gclass4_0 == null || 1 == 0)
					{
						GClass69.gclass4_0 = new GClass4();
					}
					GClass69.gclass4_0.vmethod_2();
					if (GClass69.gclass80_0.isShow && 0 == 0)
					{
						GClass69.gclass80_0.isShow = false;
					}
					if (GClass69.gclass6_0.isShow && 0 == 0)
					{
						GClass69.gclass6_0.isShow = false;
					}
					if (!GClass69.gclass76_0.isShow || 1 == 0)
					{
						GClass69.smethod_16(GClass83.string_36);
					}
					return;
				}
			}
			catch
			{
			}
			try
			{
				if (long_2 > GClass25.gclass25_0.maxHp)
				{
					long_2 = GClass25.gclass25_0.maxHp;
				}
				if (long_3 > GClass25.gclass25_0.maxMp)
				{
					long_3 = GClass25.gclass25_0.maxMp;
				}
				if (long_2 < GClass25.gclass25_0.hp)
				{
					int num = (int)(GClass25.gclass25_0.hp - long_2) >> 1;
					if (num < 1)
					{
						num = 1;
					}
					long_2 += num;
				}
				else if (long_2 > GClass25.gclass25_0.hp)
				{
					int num2 = (int)(long_2 - GClass25.gclass25_0.hp) >> 1;
					if (num2 < 1)
					{
						num2 = 1;
					}
					long_2 -= num2;
				}
				if (long_3 < GClass25.gclass25_0.mp)
				{
					int num3 = (int)(GClass25.gclass25_0.mp - long_3) >> 1;
					if (num3 < 1)
					{
						num3 = 1;
					}
					long_3 += num3;
				}
				else if (long_3 > GClass25.gclass25_0.mp)
				{
					int num4 = (int)(long_3 - GClass25.gclass25_0.mp) >> 1;
					if (num4 < 1)
					{
						num4 = 1;
					}
					long_3 -= num4;
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
			if (int_9 > 0)
			{
				int_9--;
				if (int_9 == 0 || 1 == 0)
				{
					GClass81.bool_0 = false;
				}
			}
			if (GClass44.int_0 > 0)
			{
				GClass44.int_0--;
			}
			if (GClass25.gclass25_0.playerFocus == null || 1 == 0)
			{
				cmdQues.isShow = false;
			}
			else if (cmdQues.isShow && 0 == 0 && (!GClass25.gclass25_0.method_39(GClass25.gclass25_0.playerFocus) || 1 == 0))
			{
				cmdQues.x = GClass25.gclass25_0.playerFocus.x;
				cmdQues.y = GClass25.gclass25_0.playerFocus.y - GClass25.gclass25_0.playerFocus.h - cmdQues.h / 2;
			}
			if (tMenuDelay > 0)
			{
				tMenuDelay--;
			}
			if (bool_2 && 0 == 0 && (GClass69.int_0 % 10 == 0 || 1 == 0))
			{
				method_10();
			}
			try
			{
				method_0();
				smethod_4();
				GClass25.gclass25_0.vmethod_1();
				for (int i = 0; i < list_1.Count; i++)
				{
					list_1[i].vmethod_1();
				}
				GClass79.smethod_1();
				for (int j = 0; j < list_5.Count; j++)
				{
					list_5[j].method_3();
				}
				for (int k = 0; k < list_0.Count; k++)
				{
					list_0[k].vmethod_1();
				}
				for (int l = 0; l < list_2.Count; l++)
				{
					list_2[l].method_2();
				}
				for (int m = 0; m < GClass28.list_0.Count; m++)
				{
					GClass28.list_0[m].method_2();
				}
				for (int n = 0; n < list_3.Count; n++)
				{
					list_3[n].method_2();
				}
				for (int num5 = 0; num5 < Class0.list_0.Count; num5++)
				{
					Class0.list_0[num5].method_1();
				}
				if (GClass25.gclass25_0.isDead && 0 == 0 && (!gclass72_0.isShow || 1 == 0) && (!GClass69.gclass80_0.isShow || 1 == 0))
				{
					gclass72_0.isShow = true;
				}
				if (gclass54_0.isShow && 0 == 0)
				{
					gclass54_0.method_5();
				}
				method_11();
				textGlobal.method_1();
				if ((GClass69.int_0 % 5 == 0 || 1 == 0) && int_13 > 0 && (GClass25.gclass25_0.currentMovePoint == null || 1 == 0))
				{
					if (GClass25.gclass25_0.mySkill != null && 0 == 0 && GClass25.gclass25_0.mySkill.isPaintCanNotUse && 0 == 0)
					{
						return;
					}
					if ((GClass25.gclass25_0.mobFocus != null && 0 == 0 && GClass25.gclass25_0.mobFocus.status != 1 && GClass25.gclass25_0.mobFocus.status != 0 && 0 == 0 && GClass25.gclass25_0.playerFocus == null) || (GClass25.gclass25_0.playerFocus != null && 0 == 0 && (GClass25.gclass25_0.method_39(GClass25.gclass25_0.playerFocus) ? true : false)) || GClass25.gclass25_0.itemFocus != null)
					{
						if (GClass25.gclass25_0.mySkill.isPaintCanNotUse && 0 == 0 && (GClass25.gclass25_0.itemFocus == null || 1 == 0))
						{
							return;
						}
						method_22();
					}
				}
				if (int_13 > 1)
				{
					int_13--;
				}
				if (isPaintItemSpin && 0 == 0)
				{
					method_8();
				}
			}
			catch
			{
			}
		}

		public void method_11()
		{
			for (int i = 0; i < list_4.Count; i++)
			{
				GClass13 gClass = list_4[i];
				gClass.method_1();
				gClass.x += gClass.dx;
				gClass.y += gClass.dy;
				gClass.tick++;
				if (gClass.tick >= gClass.limitTime)
				{
					list_4.Remove(gClass);
				}
			}
		}

		public static void smethod_1(GClass67 myFont, string text, int x, int y, int dx, int dy)
		{
			GClass13 gClass = new GClass13();
			gClass.x = x;
			gClass.y = y;
			gClass.dx = dx;
			gClass.dy = dy;
			gClass.text = text;
			gClass.myFont = myFont;
			gClass.tick = 0;
			list_4.Add(gClass);
		}

		public static void smethod_2()
		{
			GClass13 gClass = new GClass13();
			gClass.x = GClass25.gclass25_0.x;
			gClass.y = GClass25.gclass25_0.y - GClass25.gclass25_0.h / 2;
			gClass.dx = 0;
			gClass.dy = -2;
			gClass.type = 1;
			gClass.tick = 0;
			list_4.Add(gClass);
		}

		public static void smethod_3()
		{
			GClass13 gClass = new GClass13();
			gClass.x = GClass25.gclass25_0.x;
			gClass.y = GClass25.gclass25_0.y - GClass25.gclass25_0.h / 2;
			gClass.dx = 0;
			gClass.dy = -2;
			gClass.type = 2;
			gClass.tick = 0;
			list_4.Add(gClass);
		}

		public override void vmethod_3()
		{
			if (GClass25.bool_2 || GClass25.gclass25_0.isLockMove || GClass78.bool_1 || GClass81.bool_0 || GClass25.gclass25_0.isSpaceship)
			{
				return;
			}
			if (GClass25.gclass25_0.status == 1)
			{
				if (GClass25.bool_3)
				{
					if (!GClass25.gclass25_0.isLockMove)
					{
						method_12(0);
					}
				}
				else if (GClass25.bool_6)
				{
					if (GClass25.gclass25_0.dir == 1)
					{
						GClass25.gclass25_0.dir = -1;
					}
					else if (!GClass25.gclass25_0.isLockMove)
					{
						if (GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend != 0)
						{
							GClass0.smethod_3();
						}
						GClass25.gclass25_0.status = 2;
						GClass25.gclass25_0.cvx = -GClass25.gclass25_0.speed;
					}
				}
				else
				{
					if (!GClass25.bool_5)
					{
						return;
					}
					if (GClass25.gclass25_0.dir == -1)
					{
						GClass25.gclass25_0.dir = 1;
					}
					else if (!GClass25.gclass25_0.isLockMove)
					{
						if (GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend != 0)
						{
							GClass0.smethod_3();
						}
						GClass25.gclass25_0.status = 2;
						GClass25.gclass25_0.cvx = GClass25.gclass25_0.speed;
					}
				}
			}
			else if (GClass25.gclass25_0.status == 2)
			{
				if (GClass25.bool_3)
				{
					if (GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend != 0 || GClass25.gclass25_0.y - GClass25.gclass25_0.cySend != 0)
					{
						GClass0.smethod_3();
					}
					GClass25.gclass25_0.cvy = -10;
					GClass25.gclass25_0.status = 3;
					GClass25.gclass25_0.cp1 = 0;
				}
				else if (GClass25.bool_6)
				{
					if (GClass25.gclass25_0.dir == 1)
					{
						GClass25.gclass25_0.dir = -1;
					}
					else
					{
						GClass25.gclass25_0.cvx = -GClass25.gclass25_0.speed;
					}
				}
				else if (GClass25.bool_5)
				{
					if (GClass25.gclass25_0.dir == -1)
					{
						GClass25.gclass25_0.dir = 1;
					}
					else
					{
						GClass25.gclass25_0.cvx = GClass25.gclass25_0.speed;
					}
				}
			}
			else if (GClass25.gclass25_0.status == 3)
			{
				if (GClass25.bool_6)
				{
					if (GClass25.gclass25_0.dir == 1)
					{
						GClass25.gclass25_0.dir = -1;
					}
					else
					{
						GClass25.gclass25_0.cvx = -GClass25.gclass25_0.speed;
					}
				}
				else if (GClass25.bool_5)
				{
					if (GClass25.gclass25_0.dir == -1)
					{
						GClass25.gclass25_0.dir = 1;
					}
					else
					{
						GClass25.gclass25_0.cvx = GClass25.gclass25_0.speed;
					}
				}
				if (GClass25.bool_3 && GClass25.gclass25_0.isCanFly && GClass25.gclass25_0.mp > 0L && GClass25.gclass25_0.cp1 < 8 && GClass25.gclass25_0.cvy > -4)
				{
					GClass25.gclass25_0.cp1++;
					GClass25.gclass25_0.cvy = -7;
				}
			}
			else if (GClass25.gclass25_0.status == 4)
			{
				if (GClass25.bool_3 && GClass25.gclass25_0.mp > 0L && GClass25.gclass25_0.isCanFly)
				{
					if ((GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend != 0 || GClass25.gclass25_0.y - GClass25.gclass25_0.cySend != 0) && (Math.Abs(GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend) > 96 || Math.Abs(GClass25.gclass25_0.y - GClass25.gclass25_0.cySend) > 36))
					{
						GClass0.smethod_3();
					}
					GClass25.gclass25_0.cvy = -10;
					GClass25.gclass25_0.status = 3;
					GClass25.gclass25_0.cp1 = 0;
				}
				if (GClass25.bool_6)
				{
					if (GClass25.gclass25_0.dir == 1)
					{
						GClass25.gclass25_0.dir = -1;
						return;
					}
					GClass25.gclass25_0.cp1++;
					GClass25.gclass25_0.cvx = -GClass25.gclass25_0.speed;
					if (GClass25.gclass25_0.cp1 > 5 && GClass25.gclass25_0.cvy > 6)
					{
						GClass25.gclass25_0.status = 10;
						GClass25.gclass25_0.cp1 = 0;
						GClass25.gclass25_0.cvy = 0;
					}
				}
				else
				{
					if (!GClass25.bool_5)
					{
						return;
					}
					if (GClass25.gclass25_0.dir == -1)
					{
						GClass25.gclass25_0.dir = 1;
						return;
					}
					GClass25.gclass25_0.cp1++;
					GClass25.gclass25_0.cvx = GClass25.gclass25_0.speed;
					if (GClass25.gclass25_0.cp1 > 5 && GClass25.gclass25_0.cvy > 6)
					{
						GClass25.gclass25_0.status = 10;
						GClass25.gclass25_0.cp1 = 0;
						GClass25.gclass25_0.cvy = 0;
					}
				}
			}
			else if (GClass25.gclass25_0.status == 10)
			{
				if (!GClass25.gclass25_0.isCanFly || GClass25.gclass25_0.mp <= 0L)
				{
					return;
				}
				if (GClass25.bool_3)
				{
					if ((GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend != 0 || GClass25.gclass25_0.y - GClass25.gclass25_0.cySend != 0) && (Math.Abs(GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend) > 96 || Math.Abs(GClass25.gclass25_0.y - GClass25.gclass25_0.cySend) > 36))
					{
						GClass0.smethod_3();
					}
					GClass25.gclass25_0.cvy = -10;
					GClass25.gclass25_0.status = 3;
					GClass25.gclass25_0.cp1 = 0;
				}
				else if (GClass25.bool_6)
				{
					if (GClass25.gclass25_0.dir == 1)
					{
						GClass25.gclass25_0.dir = -1;
					}
					else
					{
						GClass25.gclass25_0.cvx = -(GClass25.gclass25_0.speed + 1);
					}
				}
				else if (GClass25.bool_5)
				{
					if (GClass25.gclass25_0.dir == -1)
					{
						GClass25.gclass25_0.dir = 1;
					}
					else
					{
						GClass25.gclass25_0.cvx = GClass25.gclass25_0.speed + 1;
					}
				}
			}
			else if (GClass25.gclass25_0.status == 7)
			{
				if (GClass25.bool_6)
				{
					if (GClass25.gclass25_0.dir == 1)
					{
						GClass25.gclass25_0.dir = -1;
					}
					else
					{
						GClass25.gclass25_0.cvx = -(GClass25.gclass25_0.speed + 2);
					}
				}
				else if (GClass25.bool_5)
				{
					if (GClass25.gclass25_0.dir == -1)
					{
						GClass25.gclass25_0.dir = 1;
					}
					else
					{
						GClass25.gclass25_0.cvx = GClass25.gclass25_0.speed - 2;
					}
				}
			}
			else
			{
				if (GClass25.gclass25_0.status != 14)
				{
					return;
				}
				if (GClass25.bool_6)
				{
					if (GClass25.gclass25_0.dir == 1)
					{
						GClass25.gclass25_0.dir = -1;
					}
				}
				else if (GClass25.bool_5 && GClass25.gclass25_0.dir == -1)
				{
					GClass25.gclass25_0.dir = 1;
				}
			}
		}

		public void method_12(int cvx)
		{
			if (((GClass25.gclass25_0.x - GClass25.gclass25_0.cxSend != 0) ? true : false) || GClass25.gclass25_0.y - GClass25.gclass25_0.cySend != 0)
			{
				GClass0.smethod_3();
			}
			GClass25.gclass25_0.cvy = -15;
			GClass25.gclass25_0.cvx = cvx;
			GClass25.gclass25_0.status = 3;
			GClass25.gclass25_0.cp1 = 0;
		}

		public override void vmethod_5(int x, int y)
		{
			if (!gclass72_0.isShow || false || !gclass72_0.vmethod_1(x, y))
			{
				if (gclass54_0.isShow && 0 == 0)
				{
					gclass54_0.method_2(x, y);
				}
				else if ((!cmdChat.isShow || false || !cmdChat.vmethod_1(x, y)) && (!cmdChangeFocus.isShow || false || !cmdChangeFocus.vmethod_1(x, y)) && (!cmdMenu.isShow || false || !cmdMenu.vmethod_1(x, y)) && (!GClass25.bool_2 || 1 == 0) && (!GClass25.gclass25_0.isLockMove || 1 == 0) && (!GClass78.bool_1 || 1 == 0) && !GClass81.bool_0 && (!cmdPean.isShow || false || !cmdPean.vmethod_1(x, y)) && (!cmdAttack.isShow || false || !cmdAttack.vmethod_1(x, y)) && (!cmdSpecialSkill.isShow || false || !cmdSpecialSkill.vmethod_1(x, y)) && (!cmdQues.isShow || false || !cmdQues.vmethod_1(x, y)))
				{
					base.vmethod_5(x, y);
				}
			}
		}

		public override void vmethod_7(int x, int y)
		{
			if (!gclass72_0.isShow || false || !gclass72_0.vmethod_3(x, y))
			{
				if (gclass54_0.isShow && 0 == 0)
				{
					gclass54_0.method_4(x, y);
				}
				else if ((!cmdChangeFocus.isShow || false || !cmdChangeFocus.vmethod_3(x, y)) && (!cmdChat.isShow || false || !cmdChat.vmethod_3(x, y)) && (!cmdMenu.isShow || false || !cmdMenu.vmethod_3(x, y)) && (!GClass25.bool_2 || 1 == 0) && (!GClass25.gclass25_0.isLockMove || 1 == 0) && (!GClass78.bool_1 || 1 == 0) && !GClass81.bool_0 && (!cmdPean.isShow || false || !cmdPean.vmethod_3(x, y)) && (!cmdAttack.isShow || false || !cmdAttack.vmethod_3(x, y)) && (!cmdSpecialSkill.isShow || false || !cmdSpecialSkill.vmethod_3(x, y)) && (!cmdQues.isShow || false || !cmdQues.vmethod_3(x, y)))
				{
					base.vmethod_7(x, y);
				}
			}
		}

		public override void vmethod_6(int x, int y)
		{
			if (gclass72_0.isShow && 0 == 0 && gclass72_0.vmethod_2(x, y))
			{
				return;
			}
			if (gclass54_0.isShow && 0 == 0)
			{
				gclass54_0.method_3(x, y);
			}
			else
			{
				if ((cmdChat.isShow && 0 == 0 && cmdChat.vmethod_2(x, y)) || (cmdChangeFocus.isShow && 0 == 0 && cmdChangeFocus.vmethod_2(x, y)) || (cmdMenu.isShow && 0 == 0 && cmdMenu.vmethod_2(x, y)) || (GClass25.bool_2 ? true : false) || (GClass25.gclass25_0.isLockMove ? true : false) || (GClass78.bool_1 ? true : false) || GClass81.bool_0 || (cmdPean.isShow && 0 == 0 && cmdPean.vmethod_2(x, y)) || (cmdAttack.isShow && 0 == 0 && cmdAttack.vmethod_2(x, y)) || (cmdSpecialSkill.isShow && 0 == 0 && cmdSpecialSkill.vmethod_2(x, y)) || (cmdQues.isShow && 0 == 0 && cmdQues.vmethod_2(x, y)))
				{
					return;
				}
				int num = 0;
				while (true)
				{
					if (num < gclass34_0.Length)
					{
						int num2 = int_4 + (int_6 + int_8) * num;
						int num3 = int_5;
						if (x >= num2 && x <= num2 + 90 && y >= num3 && num3 <= num3 + 90)
						{
							break;
						}
						num++;
						continue;
					}
					if (Math.Abs(x - GClass69.int_4) < 20 && Math.Abs(y - GClass69.int_5) < 20)
					{
						if (x >= 0 && x <= 125 && y >= 0 && y <= 125)
						{
							GClass69.gclass6_0.method_40(0);
							GClass69.gclass6_0.method_44();
							return;
						}
						GInterface0 gInterface = method_14(x, y);
						if (gInterface != null && 0 == 0 && (GClass25.gclass25_0.skillPaint == null || 1 == 0) && (GClass25.gclass25_0.dart == null || 1 == 0) && (GClass25.gclass25_0.method_15() == null || 1 == 0))
						{
							if ((gInterface is GClass25 && 0 == 0 && GClass25.gclass25_0.playerFocus == (GClass25)gInterface) || (gInterface is GClass23 && 0 == 0 && GClass25.gclass25_0.mobFocus == (GClass23)gInterface) || (gInterface is GClass22 && 0 == 0 && GClass25.gclass25_0.itemFocus == (GClass22)gInterface) || (gInterface is GClass24 && 0 == 0 && GClass25.gclass25_0.npcFocus == (GClass24)gInterface))
							{
								method_22();
							}
							else
							{
								GClass25.gclass25_0.method_44(gInterface);
							}
						}
					}
					base.vmethod_6(x, y);
					return;
				}
				if (gclass34_0[num] != GClass25.gclass25_0.mySkill)
				{
					method_26(gclass34_0[num]);
				}
				else
				{
					method_22();
				}
			}
		}

		public void method_13()
		{
			GClass53 gClass = GClass25.gclass25_0.method_11();
			if (gClass != null && 0 == 0 && gClass.type == 2)
			{
				GClass0.smethod_4();
				GClass25.bool_2 = true;
				GClass25.bool_1 = true;
				GClass78.smethod_1();
				return;
			}
			if ((GClass25.gclass25_0.npcFocus == null || 1 == 0) && (GClass25.gclass25_0.itemFocus == null || 1 == 0))
			{
				if (GClass25.gclass25_0.mobFocus != null && 0 == 0)
				{
					bool_2 = true;
				}
				if (int_13 == 0 || 1 == 0)
				{
					if (GClass84.smethod_1() - long_1 < 1500L && (((GClass25.gclass25_0.mobFocus != null) ? true : false) || (GClass25.gclass25_0.playerFocus != null && 0 == 0 && GClass25.gclass25_0.method_39(GClass25.gclass25_0.playerFocus))))
					{
						int_13 = 10;
					}
				}
				else
				{
					int_13 = 0;
				}
				long_1 = GClass84.smethod_1();
			}
			method_22();
		}

		public override void vmethod_4(KeyCode keyCode)
		{
			if ((GClass25.bool_2 ? true : false) || (GClass78.bool_1 ? true : false) || GClass81.bool_0)
			{
				return;
			}
			if (gclass54_0.isShow && 0 == 0)
			{
				gclass54_0.method_7(keyCode);
				return;
			}
			if (gclass72_0.isShow && 0 == 0)
			{
				if (keyCode == KeyCode.Return)
				{
					gclass72_0.method_0();
				}
				return;
			}
			if (!GClass69.gclass76_0.isShow || 1 == 0)
			{
				switch (keyCode)
				{
				case KeyCode.R:
					gclass54_0.name = "Chat";
					gclass54_0.textField.name = "chat";
					gclass54_0.isShow = true;
					break;
				case KeyCode.Return:
					if (gclass72_0.isShow && 0 == 0)
					{
						gclass72_0.method_0();
					}
					else if (GClass25.gclass25_0.status == 1 || GClass25.gclass25_0.status == 2 || GClass25.gclass25_0.status == 3 || GClass25.gclass25_0.status == 4 || GClass25.gclass25_0.status == 10)
					{
						method_13();
					}
					break;
				case KeyCode.F1:
					method_16();
					break;
				case KeyCode.Space:
					method_15();
					break;
				case KeyCode.L:
					method_6();
					break;
				case KeyCode.RightArrow:
					bool_2 = false;
					int_13 = 0;
					GClass25.gclass25_0.currentMovePoint = null;
					GClass25.bool_6 = false;
					GClass25.bool_5 = true;
					break;
				case KeyCode.LeftArrow:
					bool_2 = false;
					int_13 = 0;
					GClass25.gclass25_0.currentMovePoint = null;
					GClass25.bool_5 = false;
					GClass25.bool_6 = true;
					break;
				case KeyCode.UpArrow:
					bool_2 = false;
					int_13 = 0;
					GClass25.gclass25_0.currentMovePoint = null;
					GClass25.bool_4 = false;
					GClass25.bool_3 = true;
					break;
				case KeyCode.DownArrow:
					bool_2 = false;
					int_13 = 0;
					GClass25.gclass25_0.currentMovePoint = null;
					GClass25.bool_4 = true;
					GClass25.bool_3 = false;
					break;
				case KeyCode.M:
					GClass0.smethod_15(3);
					break;
				case KeyCode.Alpha1:
					if (gclass34_0[0] != null && 0 == 0)
					{
						method_26(gclass34_0[0]);
					}
					break;
				case KeyCode.Alpha2:
					if (gclass34_0[1] != null && 0 == 0)
					{
						method_26(gclass34_0[1]);
					}
					break;
				case KeyCode.Alpha3:
					if (gclass34_0[2] != null && 0 == 0)
					{
						method_26(gclass34_0[2]);
					}
					break;
				case KeyCode.Alpha4:
					if (gclass34_0[3] != null && 0 == 0)
					{
						method_26(gclass34_0[3]);
					}
					break;
				case KeyCode.Alpha5:
					if (gclass34_0[4] != null && 0 == 0)
					{
						method_26(gclass34_0[4]);
					}
					break;
				case KeyCode.Alpha6:
					GClass69.gclass6_0.playerMenu = GClass25.gclass25_0;
					GClass69.gclass6_0.method_40(20);
					GClass69.gclass6_0.method_44();
					break;
				case KeyCode.Tab:
				case KeyCode.F2:
					GClass25.gclass25_0.method_38();
					break;
				}
			}
			base.vmethod_4(keyCode);
		}

		private GInterface0 method_14(int int_14, int int_15)
		{
			GInterface0 gInterface = null;
			int num = 0;
			List<GInterface0> list = new List<GInterface0>();
			list.AddRange(list_0);
			list.AddRange(list_2);
			list.AddRange(list_3);
			list.AddRange(list_1);
			for (int i = 0; i < list.Count; i++)
			{
				int num2 = list[i].imethod_0();
				int num3 = list[i].imethod_1();
				int num4 = list[i].imethod_2();
				int num5 = list[i].imethod_3();
				if (int_14 < num2 - int_0 - num4 / 2 || int_14 > num2 - int_0 + num4 / 2 || int_15 > num3 - int_1 || int_15 < num3 - int_1 - num5)
				{
					continue;
				}
				if (gInterface == null || 1 == 0)
				{
					gInterface = list[i];
					num = Math.Abs(int_14 - num2) + Math.Abs(int_15 - num3);
					continue;
				}
				int num6 = Math.Abs(int_14 - num2) + Math.Abs(int_15 - num3);
				if (num6 < num)
				{
					gInterface = list[i];
					num = num6;
				}
			}
			return gInterface;
		}

		private static void smethod_4()
		{
			if (GClass25.gclass25_0.isSpaceship ? true : false)
			{
				return;
			}
			smethod_5(GClass25.gclass25_0.x, GClass25.gclass25_0.y);
			if (int_0 < int_2)
			{
				int num = int_2 - int_0 >> 2;
				if (num < 1)
				{
					num = 1;
				}
				int_0 += num;
			}
			else if (int_0 > int_2)
			{
				int num2 = int_0 - int_2 >> 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				int_0 -= num2;
			}
			if (int_1 < int_3)
			{
				int num3 = int_3 - int_1 >> 2;
				if (num3 < 1)
				{
					num3 = 1;
				}
				int_1 += num3;
			}
			else if (int_1 > int_3)
			{
				int num4 = int_1 - int_3 >> 2;
				if (num4 < 1)
				{
					num4 = 1;
				}
				int_1 -= num4;
			}
		}

		public static void smethod_5(int playerX, int playerY)
		{
			int_2 = playerX - GClass69.int_1 / 2;
			if (int_2 < 30)
			{
				int_2 = 30;
			}
			if (int_2 > Class0.int_6 - GClass69.int_1 - 30)
			{
				int_2 = Class0.int_6 - GClass69.int_1 - 30;
			}
			int_3 = playerY - GClass69.int_2 * 2 / 3;
			if (int_3 < 0)
			{
				int_3 = 0;
			}
			if (int_3 > Class0.int_7 - GClass69.int_2)
			{
				int_3 = Class0.int_7 - GClass69.int_2;
			}
			if (GClass69.int_1 / 5 > Class0.int_6 / 8)
			{
				Class0.int_9 = Class0.int_6 / 8;
			}
			else
			{
				Class0.int_9 = GClass69.int_1 / 5;
			}
			Class0.int_13 = playerX / 8 - Class0.int_9 / 2;
			if (Class0.int_13 < 5)
			{
				Class0.int_13 = 5;
			}
			if (Class0.int_13 > Class0.int_6 / 8 - Class0.int_9 - 5)
			{
				Class0.int_13 = Class0.int_6 / 8 - Class0.int_9 - 5;
			}
			Class0.int_14 = playerY / 8 - Class0.int_10 * 2 / 3;
			if (Class0.int_14 < 0)
			{
				Class0.int_14 = 0;
			}
			if (Class0.int_14 > Class0.int_7 / 8 - Class0.int_10)
			{
				Class0.int_14 = Class0.int_7 / 8 - Class0.int_10;
			}
		}

		public override void vmethod_2()
		{
			GClass25.bool_0 = false;
			GClass0.smethod_2();
			base.vmethod_2();
		}

		public static GClass25 smethod_6(int playerId)
		{
			using (List<GClass25>.Enumerator enumerator = list_1.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass25 current = enumerator.Current;
					if (current.id == playerId)
					{
						return current;
					}
				}
			}
			return null;
		}

		public static GClass23 smethod_7(int mobId)
		{
			using (List<GClass23>.Enumerator enumerator = list_0.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass23 current = enumerator.Current;
					if (current.id == mobId)
					{
						return current;
					}
				}
			}
			return null;
		}

		public static GClass24 smethod_8(int npcId)
		{
			using (List<GClass24>.Enumerator enumerator = list_2.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass24 current = enumerator.Current;
					if (current.template.id == npcId)
					{
						return current;
					}
				}
			}
			return null;
		}

		public void imethod_1(string text, string to)
		{
			if (gclass54_0.textField.method_5() != null && 0 == 0 && (!gclass54_0.textField.method_5().Equals(string.Empty) || 1 == 0) && (!text.Equals(string.Empty) || 1 == 0) && ((text != null) ? true : false))
			{
				if (gclass54_0.name.Equals("Chat") && 0 == 0)
				{
					GClass0.smethod_5(text);
					gclass54_0.method_6();
				}
				else
				{
					if (!gclass54_0.name.Equals(GClass83.string_49[0]))
					{
						return;
					}
					try
					{
						int num = int.Parse(text);
						if (num <= 0)
						{
							GClass69.smethod_16("Số lượng Kim cương phải lớn hơn 0");
							return;
						}
						GClass0.smethod_19(GClass25.gclass25_0.playerFocus.id, num);
						gclass54_0.method_6();
						return;
					}
					catch
					{
					}
					gclass54_0.method_6();
					GClass69.smethod_16("Số lượng Kim cương không hợp lệ!");
				}
			}
			else
			{
				gclass54_0.method_6();
			}
		}

		public void imethod_2()
		{
		}

		public static void smethod_9(string title, List<string> menu, GClass24 npc)
		{
			List<GClass72> list = new List<GClass72>();
			for (int i = 0; i < menu.Count; i++)
			{
				list.Add(new GClass72(menu[i], smethod_0(), 5, npc?.template.id ?? 9));
			}
			if (title == string.Empty && 0 == 0)
			{
				GClass69.gclass80_0.method_0(list);
			}
			else
			{
				GClass69.gclass80_0.method_2(title, (npc != null && 0 == 0) ? npc.template.imgs[2] : 0, list);
			}
		}

		public void method_15()
		{
			if (GClass84.smethod_1() - long_0 < 10000L)
			{
				return;
			}
			int num = 0;
			while (true)
			{
				if (num < GClass25.gclass25_0.itemsBag.Count)
				{
					if (GClass25.gclass25_0.itemsBag[num] != null && 0 == 0 && GClass25.gclass25_0.itemsBag[num].template.type == 19)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			long_0 = GClass84.smethod_1();
			GClass0.smethod_20(GClass0.int_0, num);
			GClass43.smethod_11();
		}

		public void imethod_0(int idAction, object p)
		{
			switch (idAction)
			{
			case 1:
				gclass72_0.isShow = false;
				method_21();
				break;
			case 2:
				gclass72_0.isShow = true;
				break;
			case 3:
				GClass0.smethod_13();
				break;
			case 4:
				GClass0.smethod_14();
				break;
			case 5:
				GClass0.smethod_16((int)p, GClass69.gclass80_0.indexSelect);
				break;
			case 6:
				GClass69.gclass6_0.method_40(0);
				GClass69.gclass6_0.method_44();
				break;
			case 7:
				method_17();
				break;
			case 8:
				method_18();
				break;
			case 9:
				GClass69.gclass6_0.method_40(12);
				GClass69.gclass6_0.method_44();
				break;
			case 10:
				try
				{
					GClass65.smethod_9();
					GClass65.list_0.Clear();
					GClass65.list_1.Clear();
					if (GClass69.gclass4_0 == null || 1 == 0)
					{
						GClass69.gclass4_0 = new GClass4();
					}
					GClass69.gclass4_0.vmethod_2();
					if (GClass69.gclass80_0.isShow && 0 == 0)
					{
						GClass69.gclass80_0.isShow = false;
					}
					if (GClass69.gclass6_0.isShow && 0 == 0)
					{
						GClass69.gclass6_0.isShow = false;
					}
					break;
				}
				catch
				{
					break;
				}
			case 11:
				GClass69.gclass6_0.method_40(7);
				GClass69.gclass6_0.method_44();
				break;
			case 13:
				GClass69.gclass6_0.method_40(11);
				GClass69.gclass6_0.method_44();
				break;
			case 14:
				GClass78.smethod_1();
				GClass0.smethod_27(GClass0.int_11, -1);
				break;
			case 15:
				GClass78.smethod_1();
				GClass0.smethod_28(GClass0.int_14, -1);
				break;
			case 16:
				method_19();
				break;
			case 17:
				GClass0.smethod_15(3);
				break;
			case 18:
				gclass54_0.name = "Chat";
				gclass54_0.textField.name = "chat";
				gclass54_0.isShow = true;
				break;
			case 19:
				method_16();
				break;
			case 20:
				GClass25.gclass25_0.method_38();
				break;
			case 21:
				method_15();
				break;
			case 23:
				if (GClass25.gclass25_0.status == 1 || GClass25.gclass25_0.status == 2 || GClass25.gclass25_0.status == 3 || GClass25.gclass25_0.status == 4 || GClass25.gclass25_0.status == 10)
				{
					method_13();
				}
				break;
			case 24:
				method_20();
				break;
			case 25:
				GClass79.smethod_3("Tính năng đang phát triển", 0);
				break;
			case 26:
				GClass0.smethod_29(0, (int)p);
				break;
			case 27:
			{
				GClass25 player = (GClass25)p;
				GClass69.gclass6_0.method_48(player);
				GClass69.gclass6_0.method_40(15);
				GClass69.gclass6_0.method_44();
				break;
			}
			case 28:
				GClass0.smethod_35(0, (int)p, -1);
				break;
			case 29:
				GClass0.smethod_30(0, (int)p);
				break;
			case 31:
				GClass0.smethod_27(GClass0.int_12, (int)p);
				break;
			case 32:
			{
				int num = (int)p;
				if (num < 2)
				{
					GClass0.smethod_31(0, num - 1);
				}
				else
				{
					GClass0.smethod_31(1, num - 1);
				}
				break;
			}
			case 33:
				gclass54_0.name = GClass83.string_49[0];
				gclass54_0.textField.name = GClass83.string_49[1];
				gclass54_0.isShow = true;
				break;
			case 35:
				GClass69.gclass6_0.method_40(22);
				GClass69.gclass6_0.method_44();
				break;
			case 12:
			case 22:
			case 30:
			case 34:
				break;
			}
		}

		public void method_16()
		{
			List<GClass72> list = new List<GClass72>();
			list.Add(new GClass72("Bản thân", smethod_0(), 6, null));
			list.Add(new GClass72("Tổng hợp", smethod_0(), 7, null));
			list.Add(new GClass72("Tính năng", smethod_0(), 8, null));
			list.Add(new GClass72("Khu vực", smethod_0(), 17, null));
			list.Add(new GClass72("Tin nhắn", smethod_0(), 9, null));
			list.Add(new GClass72("Thoát", smethod_0(), 10, null));
			GClass69.gclass80_0.method_0(list);
		}

		public void method_17()
		{
			List<GClass72> list = new List<GClass72>();
			list.Add(new GClass72("Nhiệm vụ", smethod_0(), 11, null));
			list.Add(new GClass72("Bang hội", smethod_0(), 12, null));
			list.Add(new GClass72("Cài đặt", smethod_0(), 35, null));
			GClass69.gclass80_0.method_0(list);
		}

		public void method_18()
		{
			List<GClass72> list = new List<GClass72>();
			list.Add(new GClass72("Tổ đội", smethod_0(), 13, null));
			list.Add(new GClass72("Bạn bè", smethod_0(), 14, null));
			list.Add(new GClass72("Kẻ thù", smethod_0(), 15, null));
			list.Add(new GClass72("Trạng thái PK", smethod_0(), 16, null));
			GClass69.gclass80_0.method_0(list);
		}

		public void method_19()
		{
			List<GClass72> list = new List<GClass72>();
			for (int i = 0; i < string_0.Length; i++)
			{
				list.Add(new GClass72(string_0[i], smethod_0(), 32, i));
			}
			GClass69.gclass80_0.method_0(list);
		}

		public void method_20()
		{
			List<GClass72> list = new List<GClass72>();
			list.Add(new GClass72("Mời vào tổ đội", smethod_0(), 26, GClass25.gclass25_0.playerFocus.id));
			if (GClass25.gclass25_0.clan != null && 0 == 0)
			{
				list.Add(new GClass72("Mời vào bang hội", smethod_0(), 34, GClass25.gclass25_0.playerFocus.id));
			}
			list.Add(new GClass72("Chat riêng", smethod_0(), 27, GClass25.gclass25_0.playerFocus));
			if (GClass25.gclass25_0.level >= 10)
			{
				list.Add(new GClass72("Giao dịch", smethod_0(), 28, GClass25.gclass25_0.playerFocus.id));
			}
			if (GClass25.gclass25_0.level >= 5)
			{
				list.Add(new GClass72("Thách đấu", smethod_0(), 29, GClass25.gclass25_0.playerFocus.id));
			}
			list.Add(new GClass72("Kết bạn", smethod_0(), 31, GClass25.gclass25_0.playerFocus.id));
			using (List<GClass16>.Enumerator enumerator = GClass25.gclass25_0.itemsBag.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass16 current = enumerator.Current;
					if (current != null && 0 == 0 && current.template.id == 109)
					{
						list.Add(new GClass72("Tặng kim cương", smethod_0(), 33, GClass25.gclass25_0.playerFocus.id));
						break;
					}
				}
			}
			GClass69.gclass80_0.method_0(list);
		}

		private void method_21()
		{
			List<GClass72> list = new List<GClass72>();
			list.Add(new GClass72(GClass83.string_0[1], this, 2, null));
			list.Add(new GClass72(GClass83.string_0[2], this, 3, null));
			list.Add(new GClass72(GClass83.string_0[3], this, 4, null));
			GClass69.gclass80_0.method_0(list);
		}

		private void method_22()
		{
			if ((!GClass25.gclass25_0.isDead || 1 == 0) && GClass25.gclass25_0.hp > 0L)
			{
				GClass25.gclass25_0.cvx = 0;
				GClass25.gclass25_0.cvy = 0;
				if (method_25() && 0 == 0 && GClass25.gclass25_0.method_47() && 0 == 0)
				{
					GClass25.gclass25_0.method_6();
				}
			}
		}

		public void method_23()
		{
			GClass0.smethod_24(GClass25.gclass25_0.itemFocus.id);
		}

		public bool method_24(GClass23 m)
		{
			if (m == null || 1 == 0)
			{
				return false;
			}
			if (m.status != 0 && 0 == 0 && m.status != 1 && m.hp > 0L)
			{
				return true;
			}
			return false;
		}

		public bool method_25()
		{
			if (gclass54_0.isShow)
			{
				return false;
			}
			if (!GClass78.bool_1 && !GClass25.bool_2)
			{
				if (GClass25.gclass25_0.mySkill != null && GClass25.gclass25_0.itemFocus != null)
				{
					GClass25.gclass25_0.dir = ((GClass25.gclass25_0.x <= GClass25.gclass25_0.itemFocus.x) ? 1 : (-1));
					method_23();
					return false;
				}
				if (!GClass25.gclass25_0.isBlind && !GClass25.gclass25_0.isChocolate)
				{
					if (GClass25.gclass25_0.mySkill != null && GClass25.gclass25_0.mySkill.template.type == 1 && GClass25.gclass25_0.npcFocus == null)
					{
						if (!GClass25.gclass25_0.method_47())
						{
							return false;
						}
						return true;
					}
					if (GClass25.gclass25_0.skillPaint == null && (GClass25.gclass25_0.mobFocus != null || GClass25.gclass25_0.npcFocus != null || GClass25.gclass25_0.playerFocus != null || GClass25.gclass25_0.itemFocus != null))
					{
						if (GClass25.gclass25_0.mobFocus != null)
						{
							if (!method_24(GClass25.gclass25_0.mobFocus))
							{
								return false;
							}
							if (GClass25.gclass25_0.mySkill == null)
							{
								return false;
							}
							if (GClass25.gclass25_0.mySkill.template.id == 13)
							{
								return false;
							}
							if (GClass25.gclass25_0.mobFocus.status != 1 && GClass25.gclass25_0.mobFocus.status != 0)
							{
								if (!GClass25.gclass25_0.method_47())
								{
									return false;
								}
								if (GClass25.gclass25_0.x < GClass25.gclass25_0.mobFocus.imethod_0())
								{
									GClass25.gclass25_0.dir = 1;
								}
								else
								{
									GClass25.gclass25_0.dir = -1;
								}
								int num = GClass25.gclass25_0.mobFocus.w / 3;
								int num2 = GClass25.gclass25_0.mobFocus.imethod_0() - num * GClass25.gclass25_0.dir;
								int num3 = Math.Abs(GClass25.gclass25_0.x - num2);
								int num4 = Math.Abs(GClass25.gclass25_0.y - GClass25.gclass25_0.mobFocus.imethod_1());
								GClass25.gclass25_0.cvx = 0;
								if (GClass25.gclass25_0.x >= GClass25.gclass25_0.mobFocus.imethod_0() - num - ((GClass25.gclass25_0.mySkill.template.range <= 100) ? 20 : 60) && GClass25.gclass25_0.x <= GClass25.gclass25_0.mobFocus.imethod_0() + num + ((GClass25.gclass25_0.mySkill.template.range <= 100) ? 20 : 60))
								{
									if (GClass25.gclass25_0.x > GClass25.gclass25_0.mobFocus.imethod_0())
									{
										GClass25.gclass25_0.x = GClass25.gclass25_0.mobFocus.imethod_0() + num + ((GClass25.gclass25_0.mySkill.template.range <= 100) ? 20 : 60);
									}
									else
									{
										GClass25.gclass25_0.x = GClass25.gclass25_0.mobFocus.imethod_0() - num - ((GClass25.gclass25_0.mySkill.template.range <= 100) ? 20 : 60);
									}
									GClass0.smethod_3();
									return true;
								}
								if (num3 <= GClass25.gclass25_0.mySkill.template.range && num4 <= GClass25.gclass25_0.mySkill.template.range)
								{
									int num5 = 20;
									if (GClass25.gclass25_0.mySkill.template.range > 100)
									{
										num5 = 60;
									}
									if (num3 <= num5)
									{
										if (num3 >= 40)
										{
											int num6 = ((GClass25.gclass25_0.x <= num2) ? (-num5) : num5);
											GClass25.gclass25_0.currentMovePoint = new GClass29(GClass25.gclass25_0.x + num6, GClass25.gclass25_0.y);
											return false;
										}
										if (GClass25.gclass25_0.x > num2)
										{
											GClass25.gclass25_0.x = num2 + num5;
											GClass25.gclass25_0.dir = -1;
										}
										else
										{
											GClass25.gclass25_0.x = num2 - num5;
											GClass25.gclass25_0.dir = 1;
										}
										GClass0.smethod_3();
									}
									return true;
								}
								int num7 = (GClass25.gclass25_0.mySkill.template.range - 30) * ((GClass25.gclass25_0.x > GClass25.gclass25_0.mobFocus.imethod_0()) ? 1 : (-1));
								if (num3 <= GClass25.gclass25_0.mySkill.template.range)
								{
									num7 = 0;
								}
								GClass25.gclass25_0.currentMovePoint = new GClass29(num2 + num7, GClass25.gclass25_0.mobFocus.imethod_1());
								return false;
							}
							return false;
						}
						if (GClass25.gclass25_0.npcFocus != null)
						{
							if (GClass25.gclass25_0.x < GClass25.gclass25_0.npcFocus.x)
							{
								GClass25.gclass25_0.dir = 1;
							}
							else
							{
								GClass25.gclass25_0.dir = -1;
							}
							if (GClass25.gclass25_0.x < GClass25.gclass25_0.npcFocus.x)
							{
								GClass25.gclass25_0.npcFocus.dir = -1;
							}
							else
							{
								GClass25.gclass25_0.npcFocus.dir = 1;
							}
							int num8 = Math.Abs(GClass25.gclass25_0.x - GClass25.gclass25_0.npcFocus.x);
							Math.Abs(GClass25.gclass25_0.y - GClass25.gclass25_0.npcFocus.y);
							if (num8 < 60)
							{
								if (tMenuDelay == 0)
								{
									tMenuDelay = 50;
									GClass78.smethod_1();
									GClass0.smethod_3();
									GClass0.smethod_15(GClass25.gclass25_0.npcFocus.template.id);
								}
							}
							else
							{
								int num9 = (20 + GClass84.random_0.Next(20)) * ((GClass25.gclass25_0.x > GClass25.gclass25_0.npcFocus.x) ? 1 : (-1));
								GClass25.gclass25_0.currentMovePoint = new GClass29(GClass25.gclass25_0.npcFocus.x + num9, GClass25.gclass25_0.npcFocus.y + 9);
							}
							return false;
						}
						if (GClass25.gclass25_0.playerFocus != null)
						{
							GClass25.gclass25_0.dir = ((GClass25.gclass25_0.x <= GClass25.gclass25_0.playerFocus.x) ? 1 : (-1));
							int num10 = Math.Abs(GClass25.gclass25_0.x - (GClass25.gclass25_0.playerFocus.imethod_0() - 20 * GClass25.gclass25_0.dir));
							int num11 = Math.Abs(GClass25.gclass25_0.y - GClass25.gclass25_0.playerFocus.imethod_1());
							GClass25.gclass25_0.cvx = 0;
							if (num10 <= GClass25.gclass25_0.mySkill.template.range && num11 <= GClass25.gclass25_0.mySkill.template.range)
							{
								if (!GClass25.gclass25_0.method_39(GClass25.gclass25_0.playerFocus))
								{
									if (GClass25.gclass25_0.playerFocus.id >= 0)
									{
										cmdQues.x = GClass25.gclass25_0.playerFocus.x;
										cmdQues.y = GClass25.gclass25_0.playerFocus.y - GClass25.gclass25_0.playerFocus.h - cmdQues.h / 2;
										cmdQues.isShow = true;
									}
									return false;
								}
								return true;
							}
							int num12 = (GClass25.gclass25_0.mySkill.template.range - 20) * ((GClass25.gclass25_0.x > GClass25.gclass25_0.playerFocus.imethod_0()) ? 1 : (-1));
							if (num10 <= GClass25.gclass25_0.mySkill.template.range)
							{
								num12 = 0;
							}
							GClass25.gclass25_0.currentMovePoint = new GClass29(GClass25.gclass25_0.playerFocus.imethod_0() + num12, GClass25.gclass25_0.playerFocus.imethod_1());
							if (!GClass25.gclass25_0.method_39(GClass25.gclass25_0.playerFocus))
							{
								if (GClass25.gclass25_0.playerFocus.id >= 0)
								{
									cmdQues.x = GClass25.gclass25_0.playerFocus.x;
									cmdQues.y = GClass25.gclass25_0.playerFocus.y - GClass25.gclass25_0.playerFocus.h - cmdQues.h / 2;
									cmdQues.isShow = true;
								}
								return false;
							}
							return false;
						}
						return true;
					}
					return false;
				}
				return false;
			}
			return false;
		}

		public void method_26(GClass34 skill)
		{
			if ((GClass25.gclass25_0.isBlind ? true : false) || GClass25.gclass25_0.isChocolate || skill == null || 1 == 0 || GClass25.gclass25_0.skillPaint != null || GClass25.gclass25_0.dart != null)
			{
				return;
			}
			if (GClass25.gclass25_0.mySkill != skill)
			{
				GClass0.smethod_12(skill.template.id);
				GClass25.gclass25_0.mySkill = skill;
			}
			else if (GClass25.gclass25_0.method_46() && 0 == 0)
			{
				GClass25.gclass25_0.cvx = 0;
				GClass25.gclass25_0.cvy = 0;
				if (GClass25.gclass25_0.method_47() && 0 == 0)
				{
					GClass25.gclass25_0.method_6();
				}
			}
			else
			{
				if ((GClass25.gclass25_0.mobFocus == null || 1 == 0) && GClass25.gclass25_0.playerFocus == null)
				{
					return;
				}
				if (GClass25.gclass25_0.mobFocus != null && 0 == 0)
				{
					GClass25.gclass25_0.dir = ((GClass25.gclass25_0.x < GClass25.gclass25_0.mobFocus.x) ? 1 : (-1));
					if (GClass25.gclass25_0.mobFocus.hp < 0L)
					{
						return;
					}
				}
				if (GClass25.gclass25_0.playerFocus != null && 0 == 0)
				{
					GClass25.gclass25_0.dir = ((GClass25.gclass25_0.x < GClass25.gclass25_0.playerFocus.x) ? 1 : (-1));
				}
				method_22();
			}
		}
	}
}
