using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace rto
{
	public class GClass6 : GInterface1, GInterface2
	{
		public bool isShow;

		public bool isClose;

		public int type;

		private int x;

		private int y;

		private int yMin;

		private int yMax;

		private int width;

		private int height;

		private int xScroll;

		private int yScroll;

		private int wScroll;

		private int hScroll;

		private int xScrollInfo;

		private int yScrollInfo;

		private int wScrollInfo;

		private int hScrollInfo;

		public int indexSelect = -1;

		public List<GClass26> mapTrains = new List<GClass26>();

		public GClass16 itemSelected;

		public GClass15 infoSelected;

		public Panel[] tabs = new Panel[3]
		{
			Panel.gclass47_0,
			Panel.gclass47_3,
			Panel.gclass47_4
		};

		public GClass46 tabInfo = new GClass46();

		private int tabIndex;

		private int item_range_X;

		private int item_range_Y;

		private int item_start_X;

		private int item_start_Y;

		private int item_width;

		private int item_height;

		private int row;

		private int column;

		private int cmyTo;

		private int cmy;

		private int cmdy;

		private int cmvy;

		private int cmyLim;

		private bool isPointerDownInScroll;

		private int xPointerDown;

		private int yPointerDown;

		private int pointerX;

		private int pointerY;

		private int cmtoYInfo;

		private int cmyInfo;

		private int cmdyInfo;

		private int cmvyInfo;

		private int cmyLimInfo;

		private bool isPointerDownInScrollInfo;

		public GClass66 imgYen;

		private GClass66 imgDiamond;

		private GClass66 imgBgrOutfit;

		private string[] textPotential = new string[4] { "Sức mạnh", "Thể lực", "Trí lực", "Thân pháp" };

		public GClass54 chatTxtField;

		public static List<GClass16> list_0;

		public static List<GClass16> list_1;

		public static List<GClass73> list_2;

		public static List<GClass73> list_3;

		public static List<GClass73> list_4;

		public static List<GClass73> list_5;

		public static List<GClass73> list_6;

		public static List<GClass73> list_7;

		public static List<GClass73> list_8;

		public static Dictionary<GClass73, List<GClass73>> dictionary_0;

		public static GClass66[] gclass66_0;

		public GClass72 cmdClose;

		public GClass57 txtChat;

		private GClass72 cmdChat;

		private GClass72 cmdUpgrade;

		private GClass72 cmdAdd;

		private GClass72 cmdStoneUpgrade;

		private GClass75 cmdCreateTeam;

		private GClass75 cmdFindTeam;

		public GClass75 cmdTrade;

		public int focusSelect;

		public int lastMapTrainId;

		private int[] STONE_UPGRADE = new int[12]
		{
			6, 14, 50, 256, 320, 512, 1024, 5120, 8192, 16384,
			32768, 65536
		};

		private int[] XU_UPGRADE = new int[12]
		{
			10000, 20000, 40000, 80000, 160000, 320000, 640000, 1280000, 2560000, 5120000,
			10240000, 20480000
		};

		private int[] DIAMOND_UPGRADE = new int[12]
		{
			10, 20, 40, 80, 160, 240, 320, 400, 500, 600,
			700, 800
		};

		private byte[] PERCENT_UPGRADE = new byte[12]
		{
			60, 55, 50, 45, 40, 35, 30, 25, 20, 15,
			10, 5
		};

		private int[] STONE = new int[8] { 1, 4, 16, 64, 256, 1024, 4096, 16384 };

		private int[] XU_UPGRADE_STONE = new int[7] { 500, 1000, 2000, 10000, 50000, 250000, 1000000 };

		private int[] DIAMOND_UPGRADE_STONE = new int[7] { 1, 2, 5, 10, 50, 250, 1000 };

		private int[] stoneUps = new int[8] { 0, 4, 16, 64, 256, 1024, 4096, 16384 };

		public GClass25 playerMenu;

		public List<GClass16> itemsMe = new List<GClass16>();

		public List<GClass16> itemsFriend = new List<GClass16>();

		public int xuTrade;

		public int xuFriendTrade;

		public bool isLock;

		public bool isFriendLock;

		public List<GClass74> cmdItems = new List<GClass74>();

		public List<GClass74> cmdItemsFriend = new List<GClass74>();

		public List<GClass73> cmdPotentials = new List<GClass73>();

		public List<GClass73> cmdAreas = new List<GClass73>();

		public List<GClass73> cmdItemShops = new List<GClass73>();

		public List<GClass73> cmdSettings = new List<GClass73>();

		public List<GClass75> cmdActionsTeam = new List<GClass75>();

		private GClass66[] imgTabs;

		private GClass74 cmdItemUpgrade;

		private GClass74 cmdItemToUpgrade;

		private GClass66 imgClock;

		public int delayTrade;

		public long lastTimeDelayTrade;

		static GClass6()
		{
			list_0 = new List<GClass16>();
			int num = -26;
			int num2 = -111;
			num2 = -48;
			int num3 = -3;
			num3 = -65;
			int i = default(int);
			while (true)
			{
				num ^= 0x33;
				while (true)
				{
					num2 = GClass30.smethod_0(56);
					num3 = GClass30.smethod_0(59);
					switch (num3 ^ 0x42)
					{
					case -63:
						num2 ^= 0x41;
						num3 = -3;
						num3 = -65;
						break;
					case -65:
						break;
					default:
						num3 = -3;
						num3 = -65;
						break;
					case -66:
						continue;
					case -64:
						while (true)
						{
							num3 = -126;
							num3 = -64;
						}
					}
					while (true)
					{
						switch (num2)
						{
						case -50:
							switch (num)
							{
							default:
								goto IL_0068;
							case -46:
								list_8 = new List<GClass73>();
								num = -17;
								break;
							case -45:
								list_5 = new List<GClass73>();
								num = -28;
								break;
							case -44:
								list_4 = new List<GClass73>();
								num = -32;
								break;
							case -43:
								list_1 = new List<GClass16>();
								num = -27;
								break;
							case -42:
								list_2 = new List<GClass73>();
								num = -18;
								break;
							case -41:
								list_6 = new List<GClass73>();
								num = -22;
								break;
							case -40:
								gclass66_0 = new GClass66[4];
								num = -23;
								break;
							case -39:
								list_7 = new List<GClass73>();
								num = -31;
								break;
							case -38:
								i = 0;
								num = -19;
								break;
							case -37:
								num = -24;
								break;
							case -36:
								dictionary_0 = new Dictionary<GClass73, List<GClass73>>();
								num = -21;
								break;
							case -35:
								list_3 = new List<GClass73>();
								num = -25;
								break;
							case -34:
								for (; i < gclass66_0.Length; i++)
								{
									gclass66_0[i] = GClass69.smethod_9("imgPotential" + i + ".png");
								}
								return;
							}
							break;
						default:
							goto end_IL_007b;
						case -51:
							num = -26;
							num2 = -111;
							num2 = -48;
							num3 = -3;
							num3 = -65;
							break;
						case -48:
							break;
						case -49:
							while (true)
							{
								num2 = -114;
								num2 = -49;
								num3 = -3;
								num3 = -65;
							}
						}
						goto end_IL_00a4;
						IL_0068:
						num2 = GClass30.smethod_0(52);
						num2 ^= 0x41;
						num3 = -3;
						num3 = -65;
						continue;
						end_IL_007b:
						break;
					}
					num3 = -4;
					num3 = -66;
					continue;
					end_IL_00a4:
					break;
				}
			}
		}

		public GClass6()
		{
			chatTxtField = new GClass54();
			chatTxtField.parentScreen = this;
			cmdClose = new GClass72("imgClose", "imgCloseFocus", "imgCloseClick", this, 26, null);
			txtChat = new GClass57();
			txtChat.name = "Nhập để chat";
			txtChat.maxTextLenght = 200;
			cmdChat = new GClass72("imgChatPanelScr", "imgChatPanelScrFocus", "imgChatPanelScrClick", "Chat", this, 27, null);
			txtChat.command = cmdChat;
			cmdUpgrade = new GClass75("Cường hóa", this, 28, null);
			cmdStoneUpgrade = new GClass75("Luyện đá", this, 45, null);
			for (int i = 0; i < 4; i++)
			{
				GClass73 item = new GClass73(this, 33, i)
				{
					image = gclass66_0[i]
				};
				cmdPotentials.Add(item);
			}
			imgClock = GClass69.smethod_9("imgClock.png");
			imgYen = GClass69.smethod_9("imgYen.png");
			imgDiamond = GClass69.smethod_9("imgDiamond.png");
			imgBgrOutfit = GClass69.smethod_9("imgBgrOutfit.png");
			cmdCreateTeam = new GClass75("Tạo tổ đội", this, 19, null);
			cmdFindTeam = new GClass75("Tìm tổ đội", this, 20, null);
			cmdCreateTeam.isShow = false;
			cmdFindTeam.isShow = false;
			imgTabs = new GClass66[4];
			for (int j = 0; j < imgTabs.Length; j++)
			{
				imgTabs[j] = GClass69.smethod_9("tab" + j);
			}
			cmdItemUpgrade = new GClass74(this, 42, null);
			cmdItemToUpgrade = new GClass74(this, 43, null);
			cmdTrade = new GClass75("Khóa giao dịch", this, 54, null);
			cmdAdd = new GClass72("imgAdd", "imgAddFocus", "imgAddClick", this, 58, null);
		}

		public void method_0(GClass68 g)
		{
			if (isShow ? true : false)
			{
				g.method_31();
				g.method_18(0, 0.5f);
				g.method_9(x - 1, y - 1, width + 2, height + 2, 16);
				g.method_12(230f, 138f, 49f);
				g.method_9(x, y, width, height, 15);
				g.method_12(250f, 242f, 233f);
				g.method_9(x + 10, y + 10, width - 20, height - 20, 8);
				if (y == yMax)
				{
					cmdClose.vmethod_0(g);
				}
				method_1(g);
				switch (type)
				{
				case 0:
					method_4(g);
					break;
				case 1:
					method_7(g);
					break;
				case 2:
					method_6(g);
					break;
				case 3:
					method_8(g, playerMenu);
					break;
				case 4:
					method_11(g, playerMenu);
					break;
				case 5:
					method_16(g);
					break;
				case 6:
					method_12(g);
					break;
				case 7:
					method_9(g);
					break;
				case 8:
					method_10(g);
					break;
				case 9:
					method_13(g);
					break;
				case 10:
					method_15(g);
					break;
				case 11:
					method_17(g);
					break;
				case 12:
					method_18(g);
					break;
				case 13:
					method_19(g);
					break;
				case 14:
					method_20(g);
					break;
				case 15:
					method_21(g);
					break;
				case 16:
					method_22(g);
					break;
				case 17:
					method_23(g);
					break;
				case 18:
					method_24(g);
					break;
				case 19:
					method_25(g);
					break;
				case 20:
					method_5(g);
					break;
				case 21:
					method_26(g);
					break;
				case 22:
					method_14(g);
					break;
				}
				g.method_31();
				if (tabInfo.isShow && 0 == 0)
				{
					tabInfo.method_0(g);
				}
				if (chatTxtField.isShow && 0 == 0)
				{
					chatTxtField.method_0(g);
				}
			}
		}

		public void method_1(GClass68 g)
		{
			if (tabs == null || 1 == 0)
			{
				return;
			}
			bool flag = true;
			int num = (width - 40) / 5 + 2;
			if (tabs.Length <= 2)
			{
				flag = false;
				num += num / 2;
			}
			for (int i = 0; i < tabs.Length; i++)
			{
				int num2 = x + 15 + num * i - i;
				int num3 = y + 10 - 50;
				if (tabIndex == i)
				{
					num3 = y - 60 + 10;
					g.method_28((flag ? true : false) ? imgTabs[0] : imgTabs[2], num2, num3, 0);
				}
				else
				{
					g.method_28((flag ? true : false) ? imgTabs[1] : imgTabs[3], num2, num3, 0);
				}
				GClass67.gclass67_11.method_1(g, tabs[i].name, num2 + num / 2, num3 + 15, 2);
			}
		}

		public void method_2(GClass68 g, int x, int y, int w, int h, int hMax, int hView, int yView)
		{
			g.method_12(264f, 181f, 115f);
			g.method_9(x, y, w, h, 2);
			int h2 = hView * h / hMax;
			int num = yView * h / hMax;
			g.method_12(119f, 69f, 6f);
			g.method_9(x - 1, y + num, w + 2, h2, 2);
		}

		public void method_3(GClass68 g)
		{
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll + 20, yScroll + hScroll + 20, wScroll - 40, 3, 2);
			int num = y + (height - 10 + hScroll + 54) / 2;
			g.method_18(0, 0.3f);
			g.method_9(xScroll + 15, num - 17, 230, 34, 8);
			g.method_28(imgYen, xScroll, num, GClass45.int_7);
			GClass67.gclass67_12.method_1(g, GClass84.smethod_16(GClass25.gclass25_0.xu), xScroll + 125, num - 14, 2);
			g.method_9(xScroll + wScroll - 230, num - 17, 230, 34, 8);
			g.method_28(imgDiamond, xScroll + wScroll - 253, num, GClass45.int_7);
			GClass67.gclass67_12.method_1(g, GClass84.smethod_16(GClass25.gclass25_0.diamond), xScroll + wScroll - 115, num - 14, 2);
		}

		public void method_4(GClass68 g)
		{
			g.method_31();
			method_3(g);
			g.method_5(xScroll - 5, yScroll - 5, wScroll + 10, hScroll + 10);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					cmdItems[num3].x = num;
					cmdItems[num3].y = num2;
					cmdItems[num3].vmethod_0(g);
					if (num3 < GClass25.gclass25_0.itemsBag.Count)
					{
						GClass16 gClass = GClass25.gclass25_0.itemsBag[num3];
						if (gClass != null && 0 == 0)
						{
							gClass.method_0(g, num + item_width / 2, num2 + item_height / 2);
						}
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_5(GClass68 g)
		{
			g.method_31();
			method_3(g);
			g.method_5(xScroll - 5, yScroll - 5, wScroll + 10, hScroll + 10);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					cmdItems[num3].x = num;
					cmdItems[num3].y = num2;
					cmdItems[num3].vmethod_0(g);
					if (num3 < GClass25.gclass25_0.itemsBox.Count)
					{
						GClass16 gClass = GClass25.gclass25_0.itemsBox[num3];
						if (gClass != null && 0 == 0)
						{
							gClass.method_0(g, num + item_width / 2, num2 + item_height / 2);
						}
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_6(GClass68 g)
		{
			g.method_31();
			GClass67.gclass67_7.method_1(g, "Điểm tiềm năng còn lại: " + GClass84.smethod_16(GClass25.gclass25_0.potential), xScroll, y + 30, 0);
			for (int i = 0; i < 4; i++)
			{
				int num = item_start_X;
				int num2 = item_start_Y + item_height * i + 10 * i;
				cmdPotentials[i].x = num;
				cmdPotentials[i].y = num2;
				if (i == 0 || 1 == 0)
				{
					cmdPotentials[i].name = textPotential[i] + ": " + GClass25.gclass25_0.baseDamage;
					cmdPotentials[i].description = "Cần " + GClass84.smethod_16(GClass25.gclass25_0.potentialUpDamage) + " tiềm năng để tăng 1 điểm";
				}
				else
				{
					switch (i)
					{
					case 1:
						cmdPotentials[i].name = textPotential[i] + ": " + GClass25.gclass25_0.baseHp;
						cmdPotentials[i].description = "Cần " + GClass84.smethod_16(GClass25.gclass25_0.potentialUpHp) + " tiềm năng để tăng 1 điểm";
						break;
					case 2:
						cmdPotentials[i].name = textPotential[i] + ": " + GClass25.gclass25_0.baseMp;
						cmdPotentials[i].description = "Cần " + GClass84.smethod_16(GClass25.gclass25_0.potentialUpMp) + " tiềm năng để tăng 1 điểm";
						break;
					default:
						cmdPotentials[i].name = textPotential[i] + ": " + GClass25.gclass25_0.baseConstitution;
						cmdPotentials[i].description = "Cần " + GClass84.smethod_16(GClass25.gclass25_0.potentialUpConstitution) + " tiềm năng để tăng 1 điểm";
						break;
					}
				}
				cmdPotentials[i].method_3(g);
			}
			if (indexSelect == 0 || 1 == 0)
			{
				GClass67.gclass67_9.method_1(g, "Tăng sức đánh khi tấn công (1 điểm = 1 tấn công)", xScroll, yScroll + hScroll + 18, 0);
			}
			else if (indexSelect == 1)
			{
				GClass67.gclass67_9.method_1(g, "Tăng HP (1 điểm = 20HP)", xScroll, yScroll + hScroll + 18, 0);
			}
			else if (indexSelect == 2)
			{
				GClass67.gclass67_9.method_1(g, "Tăng MP (1 điểm = 20MP)", xScroll, yScroll + hScroll + 18, 0);
			}
			else if (indexSelect == 3)
			{
				GClass67.gclass67_9.method_1(g, "Tăng né đòn, chí mạng (1 điểm = 50 né đòn, 50 chí mạng)", xScroll, yScroll + hScroll + 18, 0);
			}
			else
			{
				GClass67.gclass67_9.method_1(g, "Chọn để xem chi tiết", xScroll, yScroll + hScroll + 18, 0);
			}
			g.method_31();
		}

		public void method_7(GClass68 g)
		{
			g.method_31();
			GClass67.gclass67_7.method_1(g, "Điểm kỹ năng còn lại: " + GClass84.smethod_16(GClass25.gclass25_0.pointSkill), xScroll, y + 35, 0);
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll, yScroll, wScroll, hScroll, 8);
			g.method_11(16777215);
			g.method_9(xScroll + 2, yScroll + 2, wScroll - 4, hScroll - 4, 6);
			g.method_5(xScroll + 2, yScroll + 2, wScroll - 4, hScroll - 4);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					cmdItems[num3].x = num;
					cmdItems[num3].y = num2;
					cmdItems[num3].vmethod_0(g);
					if (num3 < GClass25.gclass25_0.skills.Count)
					{
						GClass34 gClass = GClass25.gclass25_0.skills[num3];
						if (gClass != null)
						{
							GClass42.smethod_1(g, gClass.template.iconId, num + item_width / 2, num2 + item_height / 2, 0, 3);
						}
					}
					else
					{
						GClass42.smethod_1(g, 352, num + item_width / 2, num2 + item_height / 2, 0, 3);
					}
				}
			}
			g.method_31();
			g.method_12(230f, 138f, 49f);
			g.method_9(xScrollInfo, yScrollInfo, wScrollInfo, hScrollInfo, 8);
			g.method_11(16777215);
			g.method_9(xScrollInfo + 2, yScrollInfo + 2, wScrollInfo - 4, hScrollInfo - 4, 6);
			g.method_5(xScrollInfo + 2, yScrollInfo + 2, wScrollInfo - 4, hScrollInfo - 4);
			g.method_1(0, -cmyInfo);
			for (int k = 0; k < row; k++)
			{
				for (int l = 0; l < column; l++)
				{
					int num4 = xScrollInfo + 20;
					if (indexSelect != k * column + l)
					{
						continue;
					}
					if (indexSelect < GClass25.gclass25_0.skills.Count)
					{
						GClass34 gClass2 = GClass25.gclass25_0.skills[indexSelect];
						if (gClass2 != null)
						{
							int num5 = GClass67.gclass67_11.method_7();
							int num6 = -num5 + 5;
							if (gClass2.level == 0)
							{
								GClass67.gclass67_3.method_1(g, gClass2.template.name, num4, yScrollInfo + (num6 += num5), 0);
							}
							else
							{
								GClass67.gclass67_4.method_1(g, gClass2.template.name, num4, yScrollInfo + (num6 += num5), 0);
							}
							num6 += 10;
							string[] array = GClass67.gclass67_5.method_3(gClass2.template.description, wScrollInfo - 20);
							for (int m = 0; m < array.Length; m++)
							{
								GClass67.gclass67_5.method_1(g, array[m], num4, yScrollInfo + (num6 += num5), 0);
							}
							if (gClass2.template.isProactive)
							{
								GClass67.gclass67_5.method_1(g, "Chủ động sử dụng", num4, yScrollInfo + (num6 += num5), 0);
							}
							else
							{
								GClass67.gclass67_5.method_1(g, "Hỗ trợ bị động", num4, yScrollInfo + (num6 += num5), 0);
							}
							GClass67.gclass67_5.method_1(g, "Cấp tối đa: " + gClass2.template.maxLevel, num4, yScrollInfo + (num6 += num5), 0);
							if (gClass2.level > 0)
							{
								if (gClass2.level == gClass2.template.maxLevel)
								{
									GClass67.gclass67_9.method_1(g, "Đã đạt cấp tối đa", num4, yScrollInfo + (num6 += num5), 0);
								}
								else
								{
									GClass67.gclass67_9.method_1(g, "Cấp hiện tại: " + gClass2.level, num4, yScrollInfo + (num6 += num5), 0);
								}
								GClass67.gclass67_5.method_1(g, "Yêu cầu trình độ cấp: " + gClass2.template.levelRequire, num4, yScrollInfo + (num6 += num5), 0);
								GClass67.gclass67_5.method_1(g, "KI tiêu hao: " + GClass84.smethod_16(gClass2.method_1()) + ((gClass2.template.typeManaUse == 0) ? "" : "%"), num4, yScrollInfo + (num6 += num5), 0);
								GClass67.gclass67_5.method_1(g, "Phạm vi: " + GClass84.smethod_16(gClass2.template.range), num4, yScrollInfo + (num6 += num5), 0);
								GClass67.gclass67_5.method_1(g, "Thời gian hồi chiêu: " + GClass84.smethod_16(gClass2.method_3()) + " mili giây", num4, yScroll + (num6 += num5), 0);
								foreach (GClass36 option in gClass2.options)
								{
									string[] array2 = GClass67.gclass67_5.method_3(option.method_1(gClass2.level), wScrollInfo - 40);
									foreach (string st in array2)
									{
										GClass67.gclass67_5.method_1(g, st, num4, yScrollInfo + (num6 += num5), 0);
									}
								}
							}
							if (gClass2.level < gClass2.template.maxLevel)
							{
								GClass67.gclass67_6.method_1(g, "Cấp kế: " + (gClass2.level + 1), num4, yScrollInfo + (num6 += num5), 0);
								if (GClass25.gclass25_0.level < gClass2.method_5(gClass2.level + 1))
								{
									GClass67.gclass67_6.method_1(g, "Yêu cầu trình độ cấp: " + gClass2.template.levelRequire, num4, yScrollInfo + (num6 += num5), 0);
								}
								else
								{
									GClass67.gclass67_5.method_1(g, "Yêu cầu trình độ cấp: " + gClass2.template.levelRequire, num4, yScrollInfo + (num6 += num5), 0);
								}
								GClass67.gclass67_5.method_1(g, "KI tiêu hao: " + GClass84.smethod_16(gClass2.method_2(gClass2.level + 1)) + ((gClass2.template.typeManaUse == 0) ? "" : "%"), num4, yScrollInfo + (num6 += num5), 0);
								GClass67.gclass67_5.method_1(g, "Phạm vi: " + GClass84.smethod_16(gClass2.template.range), num4, yScrollInfo + (num6 += num5), 0);
								GClass67.gclass67_5.method_1(g, "Thời gian hồi chiêu: " + GClass84.smethod_16(gClass2.method_4(gClass2.level + 1)) + " mili giây", num4, yScrollInfo + (num6 += num5), 0);
								foreach (GClass36 option2 in gClass2.options)
								{
									string[] array2 = GClass67.gclass67_5.method_3(option2.method_1(gClass2.level + 1), wScrollInfo - 40);
									foreach (string st2 in array2)
									{
										GClass67.gclass67_5.method_1(g, st2, num4, yScrollInfo + (num6 += num5), 0);
									}
								}
							}
							if (num6 > hScrollInfo - num5 - 8)
							{
								cmyLimInfo = num6 - hScrollInfo + num5 + 8;
								if (cmyLimInfo < 0)
								{
									cmyLimInfo = 0;
								}
							}
						}
						else
						{
							GClass67.gclass67_6.method_1(g, "Chưa mở", num4, yScrollInfo + 10, 0);
							cmyLimInfo = 0;
						}
					}
					else
					{
						GClass67.gclass67_6.method_1(g, "Chưa mở", num4, yScrollInfo + 10, 0);
						cmyLimInfo = 0;
					}
					break;
				}
			}
			if (indexSelect == -1)
			{
				GClass67.gclass67_6.method_1(g, "Chọn để xem thông tin", xScrollInfo + 20, yScrollInfo + 10, 0);
				cmyLimInfo = 0;
			}
			g.method_31();
			if (cmyLimInfo > 0)
			{
				method_2(g, xScrollInfo + wScrollInfo + 10, yScrollInfo + 10, 1, hScrollInfo - 20, cmyLimInfo + hScrollInfo, hScrollInfo, cmyInfo);
			}
		}

		public void method_8(GClass68 g, GClass25 player)
		{
			g.method_31();
			g.method_12(230f, 138f, 49f);
			g.method_8(xScroll, yScroll, wScroll, hScroll, 8, 8, 8, 8);
			g.method_11(16777215);
			g.method_8(xScroll + 2, yScroll + 2, wScroll - 4, hScroll - 4, 6, 6, 6, 6);
			g.method_5(xScroll, yScroll, wScroll, hScroll);
			g.method_1(0, -cmy);
			int num = item_height;
			int num2 = -num + 10;
			GClass67.gclass67_6.method_1(g, "Nhân vật: " + player.name, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_9.method_1(g, "Bang hội: Chưa có", item_start_X + 20, yScroll + (num2 += num), 0);
			if (player.pointPk > 0)
			{
				GClass67.gclass67_6.method_1(g, "Hiếu chiến: " + player.pointPk, item_start_X + 20, yScroll + (num2 += num), 0);
			}
			else
			{
				GClass67.gclass67_5.method_1(g, "Hiếu chiến: " + player.pointPk, item_start_X + 20, yScroll + (num2 += num), 0);
			}
			GClass67.gclass67_5.method_1(g, "Điểm năng động: " + 0, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, GClass69.list_4[player.level].name + ": " + GClass84.smethod_16(player.power) + " sức mạnh", item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Cấp: " + player.level + " + " + player.method_49() + "%", item_start_X + 20, yScroll + (num2 += num), 0);
			if (player.gender == 0)
			{
				GClass67.gclass67_5.method_1(g, "Tộc: Earth", item_start_X + 20, yScroll + (num2 += num), 0);
			}
			else if (player.gender == 1)
			{
				GClass67.gclass67_5.method_1(g, "Tộc: Namek", item_start_X + 20, yScroll + (num2 += num), 0);
			}
			else
			{
				GClass67.gclass67_5.method_1(g, "Tộc: Saiyan", item_start_X + 20, yScroll + (num2 += num), 0);
			}
			GClass67.gclass67_5.method_1(g, "HP: " + GClass84.smethod_16(player.hp) + "/" + GClass84.smethod_16(player.maxHp), item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "KI: " + GClass84.smethod_16(player.mp) + "/" + GClass84.smethod_16(player.maxMp), item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Tấn công: " + (player.maxDamage - player.maxDamage / 10) + "-" + player.maxDamage, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Tốc độ di chuyển: " + player.speed, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Giảm sát thương: " + player.reduceDamage, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Giảm sát thương chí mạng: " + player.reduceDamageCritical, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Khả năng né đòn: " + player.dodge, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Chính xác: " + player.accurate, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Chí mạng: " + player.critical, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Tấn công khi đánh chí mạng: " + player.criticalStrike, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Hút máu: " + player.bloodsucking, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Hút ki: " + player.manaSucking, item_start_X + 20, yScroll + (num2 += num), 0);
			GClass67.gclass67_5.method_1(g, "Phản đòn: " + player.strikeBack, item_start_X + 20, yScroll + (num2 += num), 0);
			if (num2 > hScroll - num - 8)
			{
				cmyLim = num2 - hScroll + num + 8;
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_9(GClass68 g)
		{
			g.method_31();
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll, yScroll, wScroll, hScroll, 8);
			g.method_11(16777215);
			g.method_9(xScroll + 2, yScroll + 2, wScroll - 4, hScroll - 4, 6);
			g.method_5(xScroll, yScroll, wScroll, hScroll);
			g.method_1(0, -cmy);
			int num = item_height;
			int num2 = -num + 10;
			if (GClass25.gclass25_0.task == null || 1 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Bạn đã làm hết nhiệm vụ.", item_start_X + 20, yScroll + (num2 += num), 0);
				g.method_31();
				return;
			}
			GClass67.gclass67_7.method_1(g, GClass25.gclass25_0.task.name, xScroll + wScroll / 2, yScroll + (num2 += num), 2);
			for (int i = 0; i < GClass25.gclass25_0.task.subTasks.Count; i++)
			{
				string text = "";
				if (GClass25.gclass25_0.task.subTasks[i].param > 0)
				{
					text = " [" + ((i < GClass25.gclass25_0.task.index) ? GClass25.gclass25_0.task.subTasks[i].param : GClass25.gclass25_0.task.param) + "/" + GClass25.gclass25_0.task.subTasks[i].param + "]";
				}
				if (i < GClass25.gclass25_0.task.index)
				{
					GClass67.gclass67_5.method_1(g, "- " + GClass25.gclass25_0.task.subTasks[i].name + text, item_start_X + 20, yScroll + (num2 += num), 0);
				}
				else if (i == GClass25.gclass25_0.task.index)
				{
					GClass67.gclass67_9.method_1(g, "- " + GClass25.gclass25_0.task.subTasks[i].name + text, item_start_X + 20 + ((GClass69.int_0 % 30 <= 15) ? 3 : 0), yScroll + (num2 += num), 0);
				}
				else
				{
					GClass67.gclass67_5.method_1(g, "- ...", item_start_X + 20, yScroll + (num2 += num), 0);
				}
			}
			if (GClass25.gclass25_0.task.subTasks[GClass25.gclass25_0.task.index].description != "" && 0 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Ghi chú: " + GClass25.gclass25_0.task.subTasks[GClass25.gclass25_0.task.index].description, item_start_X + 20, yScroll + (num2 += num), 0);
			}
			if (num2 > hScroll - num - 8)
			{
				cmyLim = num2 - hScroll + num + 8;
			}
			else
			{
				cmyLim = 0;
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_10(GClass68 g)
		{
			g.method_31();
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll, yScroll, wScroll, hScroll, 8);
			g.method_11(16777215);
			g.method_9(xScroll + 2, yScroll + 2, wScroll - 4, hScroll - 4, 6);
			g.method_5(xScroll, yScroll, wScroll, hScroll);
			g.method_1(0, -cmy);
			int num = item_height;
			int num2 = -num + 10;
			GClass67.gclass67_5.method_1(g, "Hiện tại chưa có nhiệm vụ nào.", item_start_X + 20, yScroll + (num2 += num), 0);
			if (num2 > hScroll - num - 8)
			{
				cmyLim = num2 - hScroll + num + 8;
			}
			else
			{
				cmyLim = 0;
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_11(GClass68 g, GClass25 player)
		{
			g.method_31();
			g.method_28(imgBgrOutfit, xScroll + wScroll / 2, yScroll + hScroll / 2 - 40, GClass45.int_6);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					if (i >= 0 && i <= 3 && j >= 1 && j <= 4)
					{
						continue;
					}
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int index = 0;
					switch (i)
					{
					case 0:
						switch (j)
						{
						case 0:
							index = GClass16.int_6;
							break;
						case 5:
							index = GClass16.int_7;
							break;
						}
						break;
					case 1:
						switch (j)
						{
						case 0:
							index = GClass16.int_0;
							break;
						case 5:
							index = GClass16.int_5;
							break;
						}
						break;
					case 2:
						switch (j)
						{
						case 0:
							index = GClass16.int_4;
							break;
						case 5:
							index = GClass16.int_3;
							break;
						}
						break;
					case 3:
						switch (j)
						{
						case 0:
							index = GClass16.int_2;
							break;
						case 5:
							index = GClass16.int_1;
							break;
						}
						break;
					case 4:
						switch (j)
						{
						case 0:
							index = GClass16.int_8;
							break;
						case 1:
							index = GClass16.int_10;
							break;
						case 2:
							index = GClass16.int_9;
							break;
						case 3:
							index = GClass16.int_11;
							break;
						case 4:
							index = GClass16.int_12;
							break;
						case 5:
							index = GClass16.int_13;
							break;
						}
						break;
					}
					cmdItems[index].x = num;
					cmdItems[index].y = num2;
					cmdItems[index].vmethod_0(g);
				}
			}
			for (int k = 0; k < row; k++)
			{
				for (int l = 0; l < column; l++)
				{
					if (k >= 0 && k <= 3 && l >= 1 && l <= 4)
					{
						continue;
					}
					int num3 = item_start_X + (item_range_X + item_width) * l;
					int num4 = item_start_Y + (item_range_Y + item_height) * k;
					switch (k)
					{
					case 0:
						switch (l)
						{
						case 0:
							if (player.itemsBody[GClass16.int_6] != null)
							{
								player.itemsBody[GClass16.int_6].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
							}
							else
							{
								GClass67.gclass67_26.method_1(g, "Áo", num3 + item_width / 2 + 1, num4 + 27, 2);
							}
							break;
						case 5:
							if (player.itemsBody[GClass16.int_7] != null)
							{
								player.itemsBody[GClass16.int_7].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
							}
							else
							{
								GClass67.gclass67_26.method_1(g, "Radar", num3 + item_width / 2 + 1, num4 + 27, 2);
							}
							break;
						}
						break;
					case 1:
						switch (l)
						{
						case 0:
							if (player.itemsBody[GClass16.int_0] != null)
							{
								player.itemsBody[GClass16.int_0].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
							}
							else
							{
								GClass67.gclass67_26.method_1(g, "Găng", num3 + item_width / 2 + 1, num4 + 27, 2);
							}
							break;
						case 5:
							if (player.itemsBody[GClass16.int_5] != null)
							{
								player.itemsBody[GClass16.int_5].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
								break;
							}
							GClass67.gclass67_26.method_1(g, "Dây", num3 + item_width / 2 + 1, num4 + 15, 2);
							GClass67.gclass67_26.method_1(g, "chuyền", num3 + item_width / 2 + 1, num4 + 37, 2);
							break;
						}
						break;
					case 2:
						switch (l)
						{
						case 0:
							if (player.itemsBody[GClass16.int_4] != null)
							{
								player.itemsBody[GClass16.int_4].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
							}
							else
							{
								GClass67.gclass67_26.method_1(g, "Quần", num3 + item_width / 2 + 1, num4 + 27, 2);
							}
							break;
						case 5:
							if (player.itemsBody[GClass16.int_3] != null)
							{
								player.itemsBody[GClass16.int_3].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
							}
							else
							{
								GClass67.gclass67_26.method_1(g, "Nhẫn", num3 + item_width / 2 + 1, num4 + 27, 2);
							}
							break;
						}
						break;
					case 3:
						switch (l)
						{
						case 0:
							if (player.itemsBody[GClass16.int_2] != null)
							{
								player.itemsBody[GClass16.int_2].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
							}
							else
							{
								GClass67.gclass67_26.method_1(g, "Giày", num3 + item_width / 2 + 1, num4 + 27, 2);
							}
							break;
						case 5:
							if (player.itemsBody[GClass16.int_1] != null)
							{
								player.itemsBody[GClass16.int_1].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
							}
							else
							{
								GClass67.gclass67_26.method_1(g, "Bội", num3 + item_width / 2 + 1, num4 + 27, 2);
							}
							break;
						}
						break;
					case 4:
						switch (l)
						{
						case 0:
							if (player.itemsBody[GClass16.int_8] != null)
							{
								player.itemsBody[GClass16.int_8].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
								break;
							}
							GClass67.gclass67_26.method_1(g, "Cải", num3 + item_width / 2 + 1, num4 + 15, 2);
							GClass67.gclass67_26.method_1(g, "trang", num3 + item_width / 2 + 1, num4 + 37, 2);
							break;
						case 1:
							if (player.itemsBody[GClass16.int_10] != null)
							{
								player.itemsBody[GClass16.int_10].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
								break;
							}
							GClass67.gclass67_26.method_1(g, "Thú", num3 + item_width / 2 + 1, num4 + 15, 2);
							GClass67.gclass67_26.method_1(g, "cưỡi", num3 + item_width / 2 + 1, num4 + 37, 2);
							break;
						case 2:
							if (player.itemsBody[GClass16.int_9] != null)
							{
								player.itemsBody[GClass16.int_9].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
								break;
							}
							GClass67.gclass67_26.method_1(g, "Bông", num3 + item_width / 2 + 1, num4 + 15, 2);
							GClass67.gclass67_26.method_1(g, "tai", num3 + item_width / 2 + 1, num4 + 37, 2);
							break;
						case 3:
							if (player.itemsBody[GClass16.int_11] != null)
							{
								player.itemsBody[GClass16.int_11].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
								break;
							}
							GClass67.gclass67_26.method_1(g, "Bang", num3 + item_width / 2 + 1, num4 + 15, 2);
							GClass67.gclass67_26.method_1(g, "hội", num3 + item_width / 2 + 1, num4 + 37, 2);
							break;
						case 4:
							if (player.itemsBody[GClass16.int_13] != null)
							{
								player.itemsBody[GClass16.int_13].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
								break;
							}
							GClass67.gclass67_26.method_1(g, "Chưa", num3 + item_width / 2 + 1, num4 + 15, 2);
							GClass67.gclass67_26.method_1(g, "mở", num3 + item_width / 2 + 1, num4 + 37, 2);
							break;
						case 5:
							if (player.itemsBody[GClass16.int_13] != null)
							{
								player.itemsBody[GClass16.int_13].method_0(g, num3 + item_width / 2 + 1, num4 + item_height / 2);
								break;
							}
							GClass67.gclass67_26.method_1(g, "Chưa", num3 + item_width / 2 + 1, num4 + 15, 2);
							GClass67.gclass67_26.method_1(g, "mở", num3 + item_width / 2 + 1, num4 + 37, 2);
							break;
						}
						break;
					}
				}
			}
			g.method_31();
			int num5 = item_start_X + ((column - 1) * item_range_X + column * item_width) / 2;
			int num6 = item_start_Y + hScroll / 2;
			GClass31 gClass = GClass69.list_2[player.head];
			GClass31 gClass2 = GClass69.list_2[player.body];
			GClass31 gClass3 = GClass69.list_2[player.leg];
			int num7 = ((player.cp1 % 15 >= 5) ? 1 : 0);
			GClass42.smethod_1(g, gClass.pi[GClass25.int_1[num7][0][0]].id, num5 + GClass25.int_1[num7][0][1] + gClass.pi[GClass25.int_1[num7][0][0]].dx, num6 - GClass25.int_1[num7][0][2] + gClass.pi[GClass25.int_1[num7][0][0]].dy, 0, 0);
			GClass42.smethod_1(g, gClass3.pi[GClass25.int_1[num7][2][0]].id, num5 + GClass25.int_1[num7][2][1] + gClass3.pi[GClass25.int_1[num7][2][0]].dx, num6 - GClass25.int_1[num7][2][2] + gClass3.pi[GClass25.int_1[num7][2][0]].dy, 0, 0);
			GClass42.smethod_1(g, gClass2.pi[GClass25.int_1[num7][1][0]].id, num5 + GClass25.int_1[num7][1][1] + gClass2.pi[GClass25.int_1[num7][1][0]].dx, num6 - GClass25.int_1[num7][1][2] + gClass2.pi[GClass25.int_1[num7][1][0]].dy, 0, 0);
			g.method_31();
		}

		public void method_12(GClass68 g)
		{
			g.method_31();
			GClass42.smethod_1(g, 10, x + 30, y + 20, 0, GClass45.int_1);
			GClass67.gclass67_0.method_1(g, Class0.int_3.ToString(), xScroll + 40, y + 36, 2);
			GClass67.gclass67_6.method_1(g, "Khu vực: " + Class0.int_3, xScroll + 100, y + 40, 0);
			GClass67.gclass67_5.method_1(g, Class0.string_1, xScroll + 100, y + 70, 0);
			GClass67.gclass67_5.method_1(g, "Dân số: " + cmdAreas[Class0.int_3].numPlayer + "/" + cmdAreas[Class0.int_3].maxPlayer, xScroll + wScroll, y + 40, 1);
			GClass67.gclass67_9.method_1(g, "Tổ đội: " + cmdAreas[Class0.int_3].numTeam, xScroll + wScroll, y + 70, 1);
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll + 20, yScroll - 20, wScroll - 40, 3, 2);
			g.method_5(xScroll - 3, yScroll - 3, wScroll + 6, hScroll + 6);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int index = i * column + j;
					cmdAreas[index].x = num;
					cmdAreas[index].y = num2;
					cmdAreas[index].method_1(g);
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_13(GClass68 g)
		{
			g.method_31();
			if (list_2.Count == 0 || 1 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Danh sách bạn bè trống.", item_start_X + 10, item_start_Y, 0);
				return;
			}
			g.method_5(xScroll - 3, yScroll - 3, wScroll + 6, hScroll + 6);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					if (num3 <= list_2.Count - 1)
					{
						list_2[num3].x = num;
						list_2[num3].y = num2;
						list_2[num3].method_4(g);
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_14(GClass68 g)
		{
			g.method_31();
			g.method_5(xScroll - 3, yScroll - 3, wScroll + 6, hScroll + 6);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					if (num3 <= cmdSettings.Count - 1)
					{
						cmdSettings[num3].x = num;
						cmdSettings[num3].y = num2;
						switch (num3)
						{
						case 0:
							cmdSettings[num3].name = "Âm thanh";
							cmdSettings[num3].description = "Trạng thái: " + ((GClass69.bool_0 ? true : false) ? "Bật" : "Tắt");
							break;
						case 1:
							cmdSettings[num3].name = "Mini Map";
							cmdSettings[num3].description = "Trạng thái: " + ((Class0.bool_0 ? true : false) ? "Bật" : "Tắt");
							break;
						case 2:
							cmdSettings[num3].name = "Nhiệm vụ";
							cmdSettings[num3].description = "Trạng thái: " + ((GClass3.bool_4 ? true : false) ? "Bật" : "Tắt");
							break;
						case 3:
							cmdSettings[num3].name = "Bàn phím ảo";
							cmdSettings[num3].description = "Trạng thái: " + ((GClass3.bool_5 ? true : false) ? "Bật" : "Tắt");
							break;
						}
						cmdSettings[num3].method_5(g);
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_15(GClass68 g)
		{
			g.method_31();
			if (list_3.Count == 0 || 1 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Danh sách kẻ thù trống.", item_start_X + 10, item_start_Y, 0);
				return;
			}
			g.method_5(xScroll - 3, yScroll - 3, wScroll + 6, hScroll + 6);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					if (num3 <= list_3.Count - 1)
					{
						list_3[num3].x = num;
						list_3[num3].y = num2;
						list_3[num3].method_4(g);
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_16(GClass68 g)
		{
			g.method_31();
			method_3(g);
			g.method_5(xScroll - 3, yScroll - 3, wScroll + 6, hScroll + 6);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					if (num3 <= cmdItemShops.Count - 1)
					{
						cmdItemShops[num3].x = num;
						cmdItemShops[num3].y = num2;
						cmdItemShops[num3].name = list_0[num3].template.name;
						cmdItemShops[num3].description = "Giá: " + GClass84.smethod_7(list_0[num3].price) + ((list_0[num3].typePrice == 0) ? " xu" : " kim cương");
						cmdItemShops[num3].method_2(g);
						list_0[num3].method_0(g, num + item_height / 2, num2 + item_height / 2);
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_17(GClass68 g)
		{
			g.method_31();
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll + 20, yScroll + hScroll + 20, wScroll - 40, 3, 2);
			for (int i = 0; i < cmdActionsTeam.Count; i++)
			{
				cmdActionsTeam[i].x = xScroll + wScroll - cmdActionsTeam[i].w * (i + 1) - 10 * i;
				cmdActionsTeam[i].y = y + (height - 10 + hScroll + 54) / 2 - cmdFindTeam.h / 2;
				cmdActionsTeam[i].vmethod_0(g);
			}
			if ((GClass25.gclass25_0.team == null || 1 == 0) && (list_5.Count == 0 || 1 == 0))
			{
				GClass67.gclass67_5.method_1(g, "Hiện tại chưa có tổ đội.", item_start_X + 10, item_start_Y, 0);
				return;
			}
			g.method_5(xScroll - 3, yScroll - 3, wScroll + 6, hScroll + 6);
			g.method_1(0, -cmy);
			for (int j = 0; j < row; j++)
			{
				for (int k = 0; k < column; k++)
				{
					int num = item_start_X + (item_range_X + item_width) * k;
					int num2 = item_start_Y + (item_range_Y + item_height) * j;
					int num3 = j * column + k;
					if (list_5.Count == 0 || 1 == 0)
					{
						if (num3 <= GClass25.gclass25_0.team.members.Count - 1)
						{
							GClass25.gclass25_0.team.members[num3].x = num;
							GClass25.gclass25_0.team.members[num3].y = num2;
							GClass25.gclass25_0.team.members[num3].vmethod_0(g);
						}
					}
					else if (num3 > list_5.Count - 1)
					{
						list_5[num3].x = num;
						list_5[num3].y = num2;
						list_5[num3].method_7(g);
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_18(GClass68 g)
		{
			g.method_31();
			txtChat.vmethod_0(g);
			cmdChat.vmethod_0(g);
			if (list_6.Count == 0 || 1 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Hiện tại chưa có tin nhắn nào.", item_start_X + 10, item_start_Y, 0);
				return;
			}
			g.method_5(xScroll - 3, yScroll, wScroll + 6, hScroll);
			g.method_1(0, -cmy);
			int num = 0;
			for (int i = 0; i < list_6.Count; i++)
			{
				if (list_6[i].playerInfo.id == GClass25.gclass25_0.id)
				{
					list_6[i].x = xScroll + wScroll - 5 - list_6[i].w;
				}
				else
				{
					list_6[i].x = item_start_X;
				}
				list_6[i].y = item_start_Y + num;
				list_6[i].method_8(g);
				num += list_6[i].h + 20;
			}
			if (num > hScroll)
			{
				cmyLim = num - hScroll;
			}
			else
			{
				cmyLim = 0;
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_19(GClass68 g)
		{
			g.method_31();
			if (GClass25.gclass25_0.clan == null || 1 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Bạn chưa có bang hội.", item_start_X + 10, item_start_Y, 0);
				return;
			}
			txtChat.vmethod_0(g);
			cmdChat.vmethod_0(g);
			g.method_5(xScroll - 3, yScroll, wScroll + 6, hScroll);
			g.method_1(0, -cmy);
			int num = 0;
			for (int i = 0; i < list_8.Count; i++)
			{
				if (list_8[i].playerInfo.id == GClass25.gclass25_0.id)
				{
					list_8[i].x = xScroll + wScroll - 5 - list_8[i].w;
				}
				else
				{
					list_8[i].x = item_start_X;
				}
				list_8[i].y = item_start_Y + num;
				list_8[i].method_8(g);
				num += list_8[i].h + 20;
			}
			if (num > hScroll)
			{
				cmyLim = num - hScroll;
			}
			else
			{
				cmyLim = 0;
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_20(GClass68 g)
		{
			g.method_31();
			if (GClass25.gclass25_0.team == null || 1 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Bạn chưa có tổ đội.", item_start_X + 10, item_start_Y, 0);
				return;
			}
			txtChat.vmethod_0(g);
			cmdChat.vmethod_0(g);
			g.method_5(xScroll - 3, yScroll, wScroll + 6, hScroll);
			g.method_1(0, -cmy);
			int num = 0;
			for (int i = 0; i < list_7.Count; i++)
			{
				if (list_7[i].playerInfo.id == GClass25.gclass25_0.id)
				{
					list_7[i].x = xScroll + wScroll - 5 - list_7[i].w;
				}
				else
				{
					list_7[i].x = item_start_X;
				}
				list_7[i].y = item_start_Y + num;
				list_7[i].method_8(g);
				num += list_7[i].h + 20;
			}
			if (num > hScroll)
			{
				cmyLim = num - hScroll;
			}
			else
			{
				cmyLim = 0;
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_21(GClass68 g)
		{
			g.method_31();
			if (dictionary_0.Count == 0 || 1 == 0)
			{
				GClass67.gclass67_5.method_1(g, "Hiện tại chưa có tin nhắn nào.", item_start_X + 10, item_start_Y, 0);
				return;
			}
			txtChat.vmethod_0(g);
			cmdChat.vmethod_0(g);
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll, yScroll, wScroll, hScroll, 16);
			g.method_11(16777215);
			g.method_9(xScroll + 2, yScroll + 2, wScroll - 4, hScroll - 4, 14);
			g.method_5(xScroll + 2, yScroll + 2, wScroll - 2, hScroll - 2);
			g.method_1(0, -cmy);
			for (int i = 0; i < dictionary_0.Count; i++)
			{
				int num = item_start_X;
				int num2 = item_start_Y + (item_range_Y + item_height) * i;
				GClass73 key = dictionary_0.ElementAt(i).Key;
				key.x = num;
				key.y = num2;
				key.method_9(g, focusSelect == i);
			}
			g.method_31();
			g.method_5(xScrollInfo, yScrollInfo, wScrollInfo, hScrollInfo);
			g.method_1(0, -cmyInfo);
			int num3 = 0;
			List<GClass73> value = dictionary_0.ElementAt(focusSelect).Value;
			for (int j = 0; j < value.Count; j++)
			{
				if (value[j].playerInfo.id == GClass25.gclass25_0.id)
				{
					value[j].x = xScrollInfo + wScrollInfo - 5 - value[j].w;
				}
				else
				{
					value[j].x = xScrollInfo + 5;
				}
				value[j].y = item_start_Y + num3;
				value[j].method_8(g);
				num3 += value[j].h + 20;
			}
			if (num3 > hScrollInfo)
			{
				cmyLimInfo = num3 - hScrollInfo;
				if (cmyLimInfo < 0)
				{
					cmyLimInfo = 0;
				}
			}
			else
			{
				cmyLimInfo = 0;
			}
			g.method_31();
			if (cmyLimInfo > 0)
			{
				method_2(g, xScrollInfo + wScrollInfo + 10, yScrollInfo + 10, 1, hScrollInfo - 20, cmyLimInfo + hScrollInfo, hScrollInfo, cmyInfo);
			}
		}

		public void method_22(GClass68 g)
		{
			g.method_31();
			g.method_5(xScroll - 3, yScroll, wScroll + 6, hScroll);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				int num = item_start_X;
				int num2 = item_start_Y + item_height * i + item_range_Y * i;
				if (indexSelect == i)
				{
					g.method_14(Color.green);
					g.method_9(num - 3, num2 - 3, wScroll + 6, item_height + 6, 11);
				}
				g.method_12(223f, 116f, 20f);
				g.method_9(num, num2, wScroll, item_height, 8);
				g.method_11(16777215);
				g.method_9(num + 2, num2 + 2, wScroll - 4, item_height - 4, 6);
				GClass67.gclass67_7.method_1(g, ((lastMapTrainId == i) ? "Về chỗ cũ: " : "") + mapTrains[i].name, num + 10, num2 + 13, 0);
				GClass67.gclass67_5.method_1(g, "Hành tinh: " + mapTrains[i].method_0(), num + 10, num2 + 53, 0);
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public void method_23(GClass68 g)
		{
			g.method_31();
			method_3(g);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					cmdItems[num3].x = num;
					cmdItems[num3].y = num2;
					cmdItems[num3].vmethod_0(g);
					if (num3 < list_1.Count)
					{
						GClass16 gClass = list_1[num3];
						if (gClass != null && 0 == 0)
						{
							gClass.method_0(g, num + item_width / 2, num2 + item_height / 2);
						}
					}
				}
			}
			cmdItemUpgrade.x = xScroll + wScroll - 272;
			cmdItemUpgrade.y = yScroll;
			cmdItemUpgrade.vmethod_0(g);
			cmdItemToUpgrade.x = xScroll + wScroll - 122;
			cmdItemToUpgrade.y = yScroll;
			cmdItemToUpgrade.vmethod_0(g);
			GClass42.smethod_1(g, 283, xScroll + wScroll - 160 - ((GClass69.int_0 % 30 < 15) ? 2 : (-2)), item_start_Y + item_height / 2, 0, GClass45.int_6);
			g.method_31();
			int num4 = method_31();
			GClass67.gclass67_7.method_1(g, "Cường hóa thường", xScroll + wScroll - 160, yScroll + 87, 2);
			GClass67.gclass67_5.method_1(g, "Tỉ lệ thành công: " + num4 + "%", xScroll + wScroll - 160, yScroll + 117, 2);
			GClass67.gclass67_5.method_1(g, "Tiêu hao: " + GClass84.smethod_7(method_32()) + " xu", xScroll + wScroll - 160, yScroll + 147, 2);
			GClass67.gclass67_24.method_1(g, "Cường hóa vip", xScroll + wScroll - 160, yScroll + 182, 2);
			GClass67.gclass67_5.method_1(g, "Tỉ lệ thành công: " + (num4 + num4 / 2) + "%", xScroll + wScroll - 160, yScroll + 212, 2);
			GClass67.gclass67_5.method_1(g, "Tiêu hao: " + GClass84.smethod_7(method_32()) + " xu, " + GClass84.smethod_16(method_33()) + " kc", xScroll + wScroll - 160, yScroll + 242, 2);
			GClass67.gclass67_6.method_1(g, "Cường hóa cực vip", xScroll + wScroll - 160, yScroll + 277, 2);
			GClass67.gclass67_5.method_1(g, "Tỉ lệ thành công: " + (num4 + num4 / 2) + "%", xScroll + wScroll - 160, yScroll + 307, 2);
			GClass67.gclass67_5.method_1(g, "Tiêu hao: " + GClass84.smethod_16(method_33() * 2) + " kim cương", xScroll + wScroll - 160, yScroll + 337, 2);
			cmdUpgrade.vmethod_0(g);
		}

		public void method_24(GClass68 g)
		{
			g.method_31();
			method_3(g);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					cmdItems[num3].x = num;
					cmdItems[num3].y = num2;
					cmdItems[num3].vmethod_0(g);
					if (num3 < list_1.Count)
					{
						GClass16 gClass = list_1[num3];
						if (gClass != null && 0 == 0)
						{
							gClass.method_0(g, num + item_width / 2, num2 + item_height / 2);
						}
					}
				}
			}
			GClass67.gclass67_5.method_1(g, "Tỉ lệ thành công: " + method_29() + "%", xScroll + wScroll - 160, yScroll + 195, 2);
			GClass67.gclass67_5.method_1(g, "Tiêu hao: " + GClass84.smethod_16(method_30()) + " xu", xScroll + wScroll - 160, yScroll + 225, 2);
			cmdItemUpgrade.x = xScroll + wScroll - 197;
			cmdItemUpgrade.y = yScroll + 85;
			cmdItemUpgrade.item = method_28();
			cmdItemUpgrade.vmethod_0(g);
			cmdStoneUpgrade.vmethod_0(g);
			g.method_31();
		}

		public void method_25(GClass68 g)
		{
			g.method_31();
			g.method_12(230f, 138f, 49f);
			g.method_9(xScroll + 20, yScroll + hScroll + 20, wScroll - 40, 3, 2);
			int num = y + (height - 10 + hScroll + 54 + 85) / 2;
			g.method_18(0, 0.3f);
			g.method_9(xScroll + 15, num - 17, 230, 34, 8);
			g.method_28(imgYen, xScroll, num, GClass45.int_7);
			GClass67.gclass67_12.method_1(g, GClass84.smethod_16(xuTrade), xScroll + 125, num - 14, 2);
			g.method_9(xScroll + wScroll - 230, num - 17, 230, 34, 8);
			g.method_28(imgYen, xScroll + wScroll - 247, num, GClass45.int_7);
			GClass67.gclass67_12.method_1(g, GClass84.smethod_16(xuFriendTrade), xScroll + wScroll - 115, num - 14, 2);
			g.method_28(GClass3.gclass66_28[(GClass25.gclass25_0.classId == -1) ? 5 : GClass25.gclass25_0.classId], xScroll, yScroll - 10, GClass45.int_4);
			GClass67.gclass67_7.method_1(g, GClass25.gclass25_0.name, xScroll + GClass3.gclass66_28[0].method_0() + 10, yScroll - 38, 0);
			g.method_28(GClass3.gclass66_28[(playerMenu.classId == -1) ? 5 : playerMenu.classId], xScroll + wScroll, yScroll - 10, GClass45.int_5);
			GClass67.gclass67_7.method_1(g, playerMenu.name, xScroll + wScroll - GClass3.gclass66_28[0].method_0() - 10, yScroll - 38, 1);
			GClass42.smethod_1(g, 283, xScroll + wScroll / 2 + 20 - ((GClass69.int_0 % 30 < 15) ? 2 : (-2)), yScroll + hScroll / 2, 0, GClass45.int_6);
			GClass42.smethod_1(g, 283, xScroll + wScroll / 2 - 20 + ((GClass69.int_0 % 30 < 15) ? 2 : (-2)), yScroll + hScroll / 2, 2, GClass45.int_6);
			if (delayTrade >= 0)
			{
				g.method_28(imgClock, xScroll + wScroll / 2, yScroll - 40, GClass45.int_3);
				GClass67.gclass67_6.method_1(g, delayTrade + "s", xScroll + wScroll / 2, yScroll - 38, 2);
			}
			cmdTrade.vmethod_0(g);
			cmdAdd.x = xScroll + 245 - cmdAdd.w;
			cmdAdd.y = num - 17;
			cmdAdd.vmethod_0(g);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num2 = item_start_X + (item_range_X + item_width) * j;
					int num3 = item_start_Y + (item_range_Y + item_height) * i;
					int num4 = i * column + j;
					cmdItems[num4].x = num2;
					cmdItems[num4].y = num3;
					cmdItems[num4].vmethod_0(g);
					if (num4 < itemsMe.Count)
					{
						itemsMe[num4]?.method_0(g, num2 + item_width / 2, num3 + item_height / 2);
					}
				}
			}
			for (int k = 0; k < row; k++)
			{
				for (int l = 0; l < column; l++)
				{
					int num5 = xScroll + wScroll - item_width * column - (column - 1) * item_range_X + (item_range_X + item_width) * l;
					int num6 = item_start_Y + (item_range_Y + item_height) * k;
					int num7 = k * column + l;
					cmdItemsFriend[num7].x = num5;
					cmdItemsFriend[num7].y = num6;
					cmdItemsFriend[num7].vmethod_0(g);
					if (num7 < itemsFriend.Count)
					{
						itemsFriend[num7]?.method_0(g, num5 + item_width / 2, num6 + item_height / 2);
					}
				}
			}
			g.method_31();
		}

		public void method_26(GClass68 g)
		{
			g.method_31();
			g.method_5(xScroll - 3, yScroll - 3, wScroll + 6, hScroll + 6);
			g.method_1(0, -cmy);
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < column; j++)
				{
					int num = item_start_X + (item_range_X + item_width) * j;
					int num2 = item_start_Y + (item_range_Y + item_height) * i;
					int num3 = i * column + j;
					if (num3 <= list_4.Count - 1)
					{
						list_4[num3].x = num;
						list_4[num3].y = num2;
						list_4[num3].method_6(g);
					}
				}
			}
			g.method_31();
			if (cmyLim > 0)
			{
				method_2(g, xScroll + wScroll + 10, yScroll + 10, 1, hScroll - 20, cmyLim + hScroll, hScroll, cmy);
			}
		}

		public int method_27()
		{
			int num = 0;
			using (List<GClass16>.Enumerator enumerator = list_1.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass16 current = enumerator.Current;
					if (current.template.type == 18)
					{
						num += STONE[current.template.id - 50];
					}
				}
			}
			if (num == 0 || 1 == 0)
			{
				return 50;
			}
			if (num >= 4096)
			{
				return 57;
			}
			if (num < 4)
			{
				return 51;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < stoneUps.Length - 1)
				{
					if (num >= stoneUps[num2] && stoneUps[num2 + 1] > num)
					{
						break;
					}
					num2++;
					continue;
				}
				return 51;
			}
			return 50 + num2;
		}

		public GClass16 method_28()
		{
			int num = method_27();
			if (num == 50)
			{
				return null;
			}
			return new GClass16
			{
				template = GClass69.list_1[num],
				quantity = 1
			};
		}

		public int method_29()
		{
			int num = 0;
			using (List<GClass16>.Enumerator enumerator = list_1.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass16 current = enumerator.Current;
					if (current.template.type == 18)
					{
						num += STONE[current.template.id - 50];
					}
				}
			}
			if (num == 0 || 1 == 0)
			{
				return 0;
			}
			if (num >= 16384)
			{
				return 100;
			}
			int num2 = 0;
			while (true)
			{
				if (num2 < stoneUps.Length - 1)
				{
					if (num >= stoneUps[num2] && stoneUps[num2 + 1] > num)
					{
						break;
					}
					num2++;
					continue;
				}
				return 0;
			}
			return num * 100 / stoneUps[num2];
		}

		public int method_30()
		{
			try
			{
				return XU_UPGRADE_STONE[method_27() - 51];
			}
			catch
			{
			}
			return 0;
		}

		public int method_31()
		{
			if (cmdItemUpgrade.item != null && 0 == 0)
			{
				GClass16 item = cmdItemUpgrade.item;
				if (item != null && 0 == 0)
				{
					int num = 0;
					int num2 = item.method_3();
					if (num2 >= 12)
					{
						return 0;
					}
					using (List<GClass16>.Enumerator enumerator = list_1.GetEnumerator())
					{
						while (enumerator.MoveNext() ? true : false)
						{
							GClass16 current = enumerator.Current;
							if (current.template.type == 18)
							{
								num += STONE[current.template.id - 50];
							}
						}
					}
					int num3 = num * PERCENT_UPGRADE[num2] / STONE_UPGRADE[num2];
					if (num3 > PERCENT_UPGRADE[num2])
					{
						num3 = PERCENT_UPGRADE[num2];
					}
					return num3;
				}
			}
			return 0;
		}

		public int method_32()
		{
			if (cmdItemUpgrade.item != null && 0 == 0)
			{
				GClass16 item = cmdItemUpgrade.item;
				if (item != null && 0 == 0)
				{
					int num = item.method_3();
					if (num >= 12)
					{
						return 0;
					}
					return XU_UPGRADE[num];
				}
			}
			return 0;
		}

		public int method_33()
		{
			if (cmdItemUpgrade.item != null && 0 == 0)
			{
				GClass16 item = cmdItemUpgrade.item;
				if (item != null && 0 == 0)
				{
					int num = item.method_3();
					if (num >= 12)
					{
						return 0;
					}
					return DIAMOND_UPGRADE[num];
				}
			}
			return 0;
		}

		public string method_34(int info)
		{
			return $"{(float)info / 100f:0.##}";
		}

		public void method_35(int x, int y)
		{
			if (isClose)
			{
				return;
			}
			if (chatTxtField.isShow)
			{
				chatTxtField.method_2(x, y);
				return;
			}
			if (tabInfo.isShow)
			{
				tabInfo.method_5(x, y);
				return;
			}
			cmdClose.vmethod_1(x, y);
			if (x >= xScroll && x <= xScroll + wScroll && y >= yScroll && y <= yScroll + hScroll)
			{
				isPointerDownInScroll = true;
			}
			if (x >= xScrollInfo && x <= xScrollInfo + wScrollInfo && y >= yScrollInfo && y <= yScrollInfo + hScrollInfo)
			{
				isPointerDownInScrollInfo = true;
			}
			xPointerDown = x;
			yPointerDown = y;
			switch (type)
			{
			case 0:
			case 1:
			{
				for (int num6 = 0; num6 < cmdItems.Count; num6++)
				{
					cmdItems[num6].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 2:
			{
				for (int num = 0; num < cmdPotentials.Count; num++)
				{
					cmdPotentials[num].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 4:
			{
				for (int num9 = 0; num9 < cmdItems.Count; num9++)
				{
					cmdItems[num9].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 5:
			{
				for (int num10 = 0; num10 < cmdItemShops.Count; num10++)
				{
					cmdItemShops[num10].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 6:
			{
				for (int num4 = 0; num4 < cmdAreas.Count; num4++)
				{
					cmdAreas[num4].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 9:
			{
				for (int num2 = 0; num2 < list_2.Count; num2++)
				{
					list_2[num2].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 10:
			{
				for (int j = 0; j < list_3.Count; j++)
				{
					list_3[j].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 11:
			{
				for (int num13 = 0; num13 < cmdActionsTeam.Count; num13++)
				{
					cmdActionsTeam[num13].vmethod_1(x, y + cmy);
				}
				if (list_5.Count == 0)
				{
					if (GClass25.gclass25_0.team != null)
					{
						for (int num14 = 0; num14 < row; num14++)
						{
							GClass25.gclass25_0.team.members[num14].vmethod_1(x, y + cmy);
						}
					}
				}
				else
				{
					for (int num15 = 0; num15 < list_5.Count; num15++)
					{
						list_5[num15].vmethod_1(x, y + cmy);
					}
				}
				break;
			}
			case 12:
			{
				for (int num7 = 0; num7 < list_6.Count; num7++)
				{
					list_6[num7].vmethod_1(x, y + cmy);
				}
				cmdChat.vmethod_1(x, y);
				txtChat.method_3(x, y);
				break;
			}
			case 13:
			{
				for (int num3 = 0; num3 < list_8.Count; num3++)
				{
					list_8[num3].vmethod_1(x, y + cmy);
				}
				txtChat.method_3(x, y);
				cmdChat.vmethod_1(x, y);
				break;
			}
			case 14:
			{
				for (int l = 0; l < list_7.Count; l++)
				{
					list_7[l].vmethod_1(x, y + cmy);
				}
				txtChat.method_3(x, y);
				cmdChat.vmethod_1(x, y);
				break;
			}
			case 15:
			{
				for (int num11 = 0; num11 < dictionary_0.Count; num11++)
				{
					GClass73 key = dictionary_0.ElementAt(num11).Key;
					if (!key.vmethod_1(x, y + cmy))
					{
						for (int num12 = 0; num12 < dictionary_0[key].Count; num12++)
						{
							dictionary_0[key][num12].vmethod_1(x, y + cmyInfo);
						}
					}
				}
				txtChat.method_3(x, y);
				cmdChat.vmethod_1(x, y);
				break;
			}
			case 17:
			{
				cmdUpgrade.vmethod_1(x, y);
				for (int num8 = 0; num8 < cmdItems.Count; num8++)
				{
					cmdItems[num8].vmethod_1(x, y + cmy);
				}
				cmdItemUpgrade.vmethod_1(x, y);
				cmdItemToUpgrade.vmethod_1(x, y);
				break;
			}
			case 18:
			{
				cmdStoneUpgrade.vmethod_1(x, y);
				for (int num5 = 0; num5 < cmdItems.Count; num5++)
				{
					cmdItems[num5].vmethod_1(x, y + cmy);
				}
				cmdItemUpgrade.vmethod_1(x, y);
				break;
			}
			case 19:
			{
				for (int m = 0; m < cmdItems.Count; m++)
				{
					cmdItems[m].vmethod_1(x, y + cmy);
				}
				for (int n = 0; n < cmdItemsFriend.Count; n++)
				{
					cmdItemsFriend[n].vmethod_1(x, y + cmy);
				}
				cmdTrade.vmethod_1(x, y);
				cmdAdd.vmethod_1(x, y);
				break;
			}
			case 20:
			{
				for (int k = 0; k < cmdItems.Count; k++)
				{
					cmdItems[k].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 22:
			{
				for (int i = 0; i < cmdSettings.Count; i++)
				{
					cmdSettings[i].vmethod_1(x, y + cmy);
				}
				break;
			}
			case 3:
			case 7:
			case 8:
			case 16:
			case 21:
				break;
			}
		}

		public void method_36(int x, int y)
		{
			if (isClose)
			{
				return;
			}
			if (chatTxtField.isShow)
			{
				chatTxtField.method_3(x, y);
				return;
			}
			if (tabInfo.isShow)
			{
				tabInfo.method_6(x, y);
				return;
			}
			cmdClose.vmethod_2(x, y);
			if (tabs != null)
			{
				int num = (width - 40) / 5;
				if (tabs.Length <= 2)
				{
					num += num / 2;
				}
				for (int i = 0; i < tabs.Length; i++)
				{
					int num2 = 50;
					int num3 = this.x + 20 + num * i - 2 * i;
					int num4 = this.y + 10 - 50;
					if (tabIndex != i && x >= num3 && x <= num3 + num && y >= num4 && y <= num4 + num2)
					{
						tabIndex = i;
						method_41(tabs[i].type);
						GClass43.smethod_10();
						break;
					}
				}
			}
			switch (type)
			{
			case 0:
			case 1:
			{
				for (int num13 = 0; num13 < cmdItems.Count; num13++)
				{
					cmdItems[num13].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 2:
			{
				for (int k = 0; k < cmdPotentials.Count; k++)
				{
					cmdPotentials[k].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 4:
			{
				for (int num16 = 0; num16 < cmdItems.Count; num16++)
				{
					cmdItems[num16].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 5:
			{
				for (int num15 = 0; num15 < cmdItemShops.Count; num15++)
				{
					cmdItemShops[num15].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 6:
			{
				for (int num11 = 0; num11 < cmdAreas.Count; num11++)
				{
					cmdAreas[num11].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 9:
			{
				for (int num9 = 0; num9 < list_2.Count; num9++)
				{
					list_2[num9].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 10:
			{
				for (int m = 0; m < list_3.Count; m++)
				{
					list_3[m].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 11:
			{
				for (int num18 = 0; num18 < cmdActionsTeam.Count; num18++)
				{
					cmdActionsTeam[num18].vmethod_2(x, y + cmy);
				}
				if (list_5.Count == 0)
				{
					if (GClass25.gclass25_0.team != null)
					{
						for (int num19 = 0; num19 < row; num19++)
						{
							GClass25.gclass25_0.team.members[num19].vmethod_2(x, y + cmy);
						}
					}
				}
				else
				{
					for (int num20 = 0; num20 < list_5.Count; num20++)
					{
						list_5[num20].vmethod_2(x, y + cmy);
					}
				}
				break;
			}
			case 12:
			{
				for (int num14 = 0; num14 < list_6.Count; num14++)
				{
					list_6[num14].vmethod_2(x, y + cmy);
				}
				cmdChat.vmethod_2(x, y);
				break;
			}
			case 13:
			{
				for (int num10 = 0; num10 < list_8.Count; num10++)
				{
					list_8[num10].vmethod_2(x, y + cmy);
				}
				cmdChat.vmethod_2(x, y);
				break;
			}
			case 14:
			{
				for (int num23 = 0; num23 < list_7.Count; num23++)
				{
					list_7[num23].vmethod_2(x, y + cmy);
				}
				cmdChat.vmethod_2(x, y);
				break;
			}
			case 15:
			{
				cmdChat.vmethod_2(x, y);
				for (int num21 = 0; num21 < dictionary_0.Count; num21++)
				{
					GClass73 key = dictionary_0.ElementAt(num21).Key;
					if (!key.vmethod_2(x, y + cmy))
					{
						for (int num22 = 0; num22 < dictionary_0[key].Count; num22++)
						{
							dictionary_0[key][num22].vmethod_2(x, y + cmyInfo);
						}
					}
				}
				break;
			}
			case 16:
			{
				if (x < xScroll || x > xScroll + wScroll || y < yScroll || y > yScroll + hScroll || !isPointerDownInScroll || x != xPointerDown || Math.Abs(y - yPointerDown) > 20)
				{
					break;
				}
				for (int num6 = 0; num6 < row; num6++)
				{
					int num7 = item_start_X;
					int num8 = item_start_Y + item_height * num6 + 10 * num6;
					if (x >= num7 && x <= num7 + wScroll && y >= num8 - cmy && y <= num8 + item_height - cmy)
					{
						indexSelect = num6;
						GClass0.smethod_23(num6);
						method_46();
						break;
					}
				}
				break;
			}
			case 17:
			{
				for (int num17 = 0; num17 < cmdItems.Count; num17++)
				{
					cmdItems[num17].vmethod_2(x, y + cmy);
				}
				if (cmdItemUpgrade.vmethod_2(x, y) || cmdItemToUpgrade.vmethod_2(x, y) || cmdUpgrade.vmethod_2(x, y))
				{
					indexSelect = -1;
				}
				break;
			}
			case 18:
			{
				for (int num12 = 0; num12 < cmdItems.Count; num12++)
				{
					cmdItems[num12].vmethod_2(x, y + cmy);
				}
				if (cmdItemUpgrade.vmethod_2(x, y) || cmdStoneUpgrade.vmethod_2(x, y))
				{
					indexSelect = -1;
				}
				break;
			}
			case 19:
			{
				for (int n = 0; n < cmdItems.Count; n++)
				{
					cmdItems[n].vmethod_2(x, y + cmy);
				}
				for (int num5 = 0; num5 < cmdItemsFriend.Count; num5++)
				{
					cmdItemsFriend[num5].vmethod_2(x, y + cmy);
				}
				cmdTrade.vmethod_2(x, y);
				cmdAdd.vmethod_2(x, y);
				break;
			}
			case 20:
			{
				for (int l = 0; l < cmdItems.Count; l++)
				{
					cmdItems[l].vmethod_2(x, y + cmy);
				}
				break;
			}
			case 22:
			{
				for (int j = 0; j < cmdSettings.Count; j++)
				{
					cmdSettings[j].vmethod_2(x, y + cmy);
				}
				break;
			}
			}
			isPointerDownInScroll = false;
			isPointerDownInScrollInfo = false;
		}

		public void method_37(int x, int y)
		{
			if (isClose)
			{
				return;
			}
			if (chatTxtField.isShow && 0 == 0)
			{
				chatTxtField.method_4(x, y);
				return;
			}
			if (tabInfo.isShow && 0 == 0)
			{
				tabInfo.method_7(x, y);
				return;
			}
			pointerX = x;
			pointerY = y;
			cmdClose.vmethod_3(x, y);
			switch (type)
			{
			case 12:
			case 13:
			case 14:
			case 15:
				cmdChat.vmethod_3(x, y);
				break;
			case 17:
				cmdUpgrade.vmethod_3(x, y);
				break;
			case 18:
				cmdStoneUpgrade.vmethod_3(x, y);
				break;
			case 19:
				cmdTrade.vmethod_3(x, y);
				cmdAdd.vmethod_3(x, y);
				break;
			case 16:
				break;
			}
		}

		public void method_38(KeyCode keyCode)
		{
			if (chatTxtField.isShow && 0 == 0)
			{
				chatTxtField.method_7(keyCode);
			}
			if (keyCode == KeyCode.F2)
			{
				method_46();
			}
			bool flag = false;
			switch (keyCode)
			{
			case KeyCode.LeftArrow:
				flag = true;
				if (indexSelect == -1)
				{
					indexSelect = 0;
				}
				else if (indexSelect == 0 || 1 == 0)
				{
					indexSelect = row * column - 1;
				}
				else
				{
					indexSelect--;
				}
				break;
			case KeyCode.RightArrow:
				flag = true;
				if (indexSelect == -1)
				{
					indexSelect = 0;
				}
				else if (indexSelect == row * column - 1)
				{
					indexSelect = 0;
				}
				else
				{
					indexSelect++;
				}
				break;
			case KeyCode.DownArrow:
				flag = true;
				if (indexSelect == -1)
				{
					indexSelect = 0;
				}
				else if (indexSelect + column <= row * column - 1)
				{
					indexSelect += column;
				}
				else
				{
					indexSelect %= column;
				}
				break;
			case KeyCode.UpArrow:
				flag = true;
				if (indexSelect == -1)
				{
					indexSelect = 0;
				}
				else if (indexSelect < column)
				{
					indexSelect += (row - 1) * column;
				}
				else
				{
					indexSelect -= column;
				}
				break;
			}
			if (flag && 0 == 0)
			{
				int num = indexSelect / column;
				cmyTo = num * (item_height + item_range_X) - hScroll / 2;
				if (cmyTo > cmyLim)
				{
					cmyTo = cmyLim;
				}
				if (cmyTo < 0)
				{
					cmyTo = 0;
				}
				if (num == row - 1 || num == 0 || 1 == 0)
				{
					cmy = cmyTo;
				}
			}
			int num2 = type;
			if ((uint)(num2 - 12) <= 3u)
			{
				txtChat.method_4(keyCode);
			}
		}

		public void method_39(int a)
		{
			if (a != 0 && 0 == 0 && ((cmyLim != 0) ? true : false))
			{
				cmyTo -= a * item_height;
				if (cmyTo > cmyLim)
				{
					cmyTo = cmyLim;
				}
				if (cmyTo < 0)
				{
					cmyTo = 0;
				}
			}
		}

		public void method_40(int type)
		{
			GClass43.smethod_6();
			isClose = false;
			width = 730;
			height = 550;
			x = (GClass69.int_1 - width) / 2;
			yMax = (GClass69.int_2 - height) / 2;
			yMin = GClass69.int_2 + height + 60;
			y = yMin;
			tabIndex = 0;
			indexSelect = -1;
			cmdClose.x = x + width + 10;
			cmdClose.y = yMax;
			this.type = type;
			cmy = 0;
			cmyInfo = 0;
			switch (type)
			{
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
				playerMenu = GClass25.gclass25_0;
				tabs = new Panel[5]
				{
					Panel.gclass47_0,
					Panel.gclass47_1,
					Panel.gclass47_2,
					Panel.gclass47_3,
					Panel.gclass47_4
				};
				break;
			case 5:
				tabs = new Panel[2]
				{
					Panel.gclass47_9,
					Panel.gclass47_0
				};
				break;
			case 6:
				tabs = new Panel[1] { Panel.gclass47_7 };
				break;
			case 7:
			case 8:
				tabs = new Panel[2]
				{
					Panel.gclass47_5,
					Panel.gclass47_6
				};
				break;
			case 9:
				tabs = new Panel[1] { Panel.gclass47_11 };
				break;
			case 10:
				tabs = new Panel[1] { Panel.gclass47_12 };
				break;
			case 11:
				tabs = new Panel[1] { Panel.gclass47_10 };
				break;
			case 12:
			case 13:
			case 14:
			case 15:
				tabs = new Panel[4]
				{
					Panel.gclass47_15,
					Panel.gclass47_17,
					Panel.gclass47_18,
					Panel.gclass47_16
				};
				tabIndex = type - 12;
				break;
			case 16:
				tabs = new Panel[1] { Panel.gclass47_19 };
				break;
			case 17:
				tabs = new Panel[2]
				{
					Panel.gclass47_8,
					Panel.gclass47_0
				};
				break;
			case 18:
				tabs = new Panel[2]
				{
					Panel.gclass47_21,
					Panel.gclass47_0
				};
				break;
			case 19:
				tabs = new Panel[2]
				{
					Panel.gclass47_20,
					Panel.gclass47_0
				};
				break;
			case 20:
				tabs = new Panel[2]
				{
					Panel.gclass47_22,
					Panel.gclass47_0
				};
				break;
			case 21:
				tabs = new Panel[1] { Panel.gclass47_23 };
				break;
			case 22:
				tabs = new Panel[1] { Panel.gclass47_24 };
				break;
			}
			method_41(this.type);
		}

		public void method_41(int type)
		{
			this.type = type;
			indexSelect = -1;
			cmdChat.isShow = false;
			cmdUpgrade.isShow = false;
			cmdStoneUpgrade.isShow = false;
			cmdCreateTeam.isShow = false;
			cmdFindTeam.isShow = false;
			switch (type)
			{
			case 0:
			{
				cmdItems.Clear();
				column = 8;
				row = GClass25.gclass25_0.itemsBag.Count / column;
				for (int n = 0; n < column * row; n++)
				{
					GClass74 item = new GClass74(this, 31, n);
					cmdItems.Add(item);
				}
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = 5 * item_height + 4 * item_range_Y;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 1:
			{
				cmdItems.Clear();
				column = 1;
				row = GClass25.gclass25_0.skills.Count;
				for (int num19 = 0; num19 < column * row; num19++)
				{
					GClass74 item5 = new GClass74(this, 32, num19);
					cmdItems.Add(item5);
				}
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = item_width + item_range_X * 2;
				xScroll = x + 30;
				hScroll = 435;
				yScroll = y + height - 30 - hScroll;
				item_start_X = xScroll + item_range_X;
				item_start_Y = yScroll + item_range_Y;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll) + item_range_Y;
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				wScrollInfo = width - 80 - wScroll;
				hScrollInfo = hScroll;
				xScrollInfo = wScroll + xScroll + 20;
				yScrollInfo = yScroll;
				cmyLimInfo = 0;
				num = 0;
				cmtoYInfo = 0;
				cmyInfo = 0;
				break;
			}
			case 2:
			{
				column = 1;
				row = 4;
				item_width = 75;
				item_height = 88;
				item_range_X = 10;
				item_range_Y = 20;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 80;
				hScroll = height - 160;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				for (int num9 = 0; num9 < cmdPotentials.Count; num9++)
				{
					cmdPotentials[num9].w = wScroll;
					cmdPotentials[num9].h = item_height;
				}
				cmyLim = 0;
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 3:
			{
				column = 1;
				row = 20;
				item_width = 75;
				item_height = GClass67.gclass67_5.method_7();
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_start_X = xScroll + 30;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 4:
			{
				cmdItems.Clear();
				column = 6;
				row = 5;
				for (int num20 = 0; num20 < GClass25.gclass25_0.itemsBag.Count; num20++)
				{
					GClass74 item6 = new GClass74(this, 34, num20);
					cmdItems.Add(item6);
				}
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_start_X = xScroll + (wScroll - column * item_width - (column - 1) * item_range_X) / 2;
				item_start_Y = yScroll + (hScroll - row * item_height - (row - 1) * item_range_Y) / 2;
				cmyLim = 0;
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 5:
			{
				cmdItemShops.Clear();
				column = 2;
				row = list_0.Count / 2 + list_0.Count % 2;
				item_height = 79;
				item_width = wScroll / 2 - 10;
				item_range_X = 10;
				item_range_Y = 10;
				for (int num5 = 0; num5 < list_0.Count; num5++)
				{
					GClass73 gClass = new GClass73(this, 36, num5);
					gClass.w = item_width;
					gClass.h = item_height;
					cmdItemShops.Add(gClass);
				}
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = 415;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 6:
			{
				column = 2;
				row = cmdAreas.Count / 2 + cmdAreas.Count % 2;
				item_height = 79;
				item_width = wScroll / 2 - 10;
				item_range_X = 10;
				item_range_Y = 10;
				for (int k = 0; k < cmdAreas.Count; k++)
				{
					cmdAreas[k].w = item_width;
					cmdAreas[k].h = item_height;
				}
				wScroll = width - 60;
				xScroll = x + 30;
				hScroll = 385;
				yScroll = y + height - 30 - hScroll;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 7:
			{
				column = 1;
				row = 20;
				item_width = 75;
				item_height = GClass67.gclass67_5.method_7();
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_start_X = xScroll + 30;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 8:
			{
				column = 1;
				row = 20;
				item_width = 75;
				item_height = GClass67.gclass67_5.method_7();
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_start_X = xScroll + 30;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 9:
			{
				column = 2;
				row = list_2.Count / 2 + list_2.Count % 2;
				item_height = 79;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_width = wScroll / 2 - 10;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				for (int l = 0; l < list_2.Count; l++)
				{
					list_2[l].w = item_width;
					list_2[l].h = item_height;
				}
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 10:
			{
				column = 2;
				row = list_3.Count / 2 + list_3.Count % 2;
				item_height = 79;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_width = wScroll / 2 - 10;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				for (int num16 = 0; num16 < list_3.Count; num16++)
				{
					list_3[num16].w = item_width;
					list_3[num16].h = item_height;
				}
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 11:
			{
				column = 2;
				row = ((GClass25.gclass25_0.team == null) ? (list_5.Count / 2 + list_5.Count % 2) : (GClass25.gclass25_0.team.members.Count / 2 + GClass25.gclass25_0.team.members.Count % 2));
				item_height = 79;
				item_width = wScroll / 2 - 10;
				item_range_X = 10;
				item_range_Y = 10;
				if (GClass25.gclass25_0.team != null)
				{
					for (int num10 = 0; num10 < GClass25.gclass25_0.team.members.Count; num10++)
					{
						GClass25.gclass25_0.team.members[num10]._object = num10;
						GClass25.gclass25_0.team.members[num10].w = item_width;
						GClass25.gclass25_0.team.members[num10].h = item_height;
					}
				}
				else
				{
					for (int num11 = 0; num11 < list_5.Count; num11++)
					{
						list_5[num11].w = item_width;
						list_5[num11].h = item_height;
					}
				}
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = 415;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				method_47();
				break;
			}
			case 12:
			{
				column = 1;
				row = list_6.Count;
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				txtChat.x = xScroll;
				txtChat.y = y + height - 20 - txtChat.height;
				txtChat.name = GClass83.string_50;
				cmdChat.y = txtChat.y;
				cmdChat.w = 100;
				txtChat.width = wScroll - cmdChat.w - 10;
				cmdChat.x = txtChat.x + txtChat.width + 10;
				cmdChat.isShow = true;
				hScroll = height - 50 - 10 - txtChat.height;
				item_start_X = xScroll + 5;
				item_start_Y = yScroll + 5;
				int num2 = 0;
				for (int m = 0; m < list_6.Count; m++)
				{
					num2 += list_6[m].h + 20;
					list_6[m]._object = m;
				}
				cmyLim = num2 - hScroll + (item_start_Y - yScroll) + 5;
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				cmyTo = cmyLim;
				if (cmy > cmyTo)
				{
					cmy = cmyTo;
				}
				break;
			}
			case 13:
			{
				column = 8;
				row = list_8.Count;
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				txtChat.x = xScroll;
				txtChat.y = y + height - 20 - txtChat.height;
				txtChat.name = GClass83.string_51;
				cmdChat.y = txtChat.y;
				cmdChat.w = 100;
				txtChat.width = wScroll - cmdChat.w - 10;
				cmdChat.x = txtChat.x + txtChat.width + 10;
				cmdChat.isShow = true;
				hScroll = height - 50 - 10 - txtChat.height;
				item_start_X = xScroll + 5;
				item_start_Y = yScroll + 5;
				int num17 = 0;
				for (int num18 = 0; num18 < list_8.Count; num18++)
				{
					num17 += list_8[num18].h + 20;
				}
				cmyLim = num17 - hScroll + (item_start_Y - yScroll) + 5;
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				cmyTo = cmyLim;
				if (cmy > cmyTo)
				{
					cmy = cmyTo;
				}
				break;
			}
			case 14:
			{
				column = 8;
				row = list_7.Count;
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				txtChat.x = xScroll;
				txtChat.y = y + height - 20 - txtChat.height;
				txtChat.name = GClass83.string_52;
				cmdChat.y = txtChat.y;
				cmdChat.w = 100;
				txtChat.width = wScroll - cmdChat.w - 10;
				cmdChat.x = txtChat.x + txtChat.width + 10;
				cmdChat.isShow = true;
				hScroll = height - 50 - 10 - txtChat.height;
				item_start_X = xScroll + 5;
				item_start_Y = yScroll + 5;
				int num6 = 0;
				for (int num7 = 0; num7 < list_7.Count; num7++)
				{
					num6 += list_7[num7].h + 20;
					list_7[num7]._object = num7;
				}
				cmyLim = num6 - hScroll + (item_start_Y - yScroll) + 5;
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				cmyTo = cmyLim;
				if (cmy > cmyTo)
				{
					cmy = cmyTo;
				}
				break;
			}
			case 15:
			{
				column = 8;
				row = dictionary_0.Count;
				item_width = 75;
				item_height = 50;
				item_range_X = 0;
				item_range_Y = 0;
				item_width = (wScroll = GClass67.gclass67_5.method_4("mmmmmmmmm"));
				xScroll = x + 30;
				yScroll = y + 30;
				txtChat.x = xScroll + wScroll + 10;
				txtChat.y = y + height - 20 - txtChat.height;
				txtChat.name = GClass83.string_53;
				cmdChat.y = txtChat.y;
				cmdChat.w = 100;
				txtChat.width = width - 60 - cmdChat.w - 20 - wScroll;
				cmdChat.x = txtChat.x + txtChat.width + 10;
				cmdChat.isShow = true;
				hScroll = height - 50;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				for (int num12 = 0; num12 < dictionary_0.Count; num12++)
				{
					GClass73 key = dictionary_0.ElementAt(num12).Key;
					key.w = item_width;
					key.h = item_height;
					key._object = num12;
				}
				cmyLim = item_height * dictionary_0.Count - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				wScrollInfo = width - 60 - 10 - wScroll;
				xScrollInfo = xScroll + wScroll + 10;
				yScrollInfo = y + 30;
				hScrollInfo = height - 50 - 10 - txtChat.height;
				if (dictionary_0.Count > 0)
				{
					int num13 = 0;
					List<GClass73> value = dictionary_0.ElementAt(focusSelect).Value;
					for (int num14 = 0; num14 < value.Count; num14++)
					{
						value[num14]._object = num14;
						num13 += value[num14].h + 20;
					}
					if (num13 > hScrollInfo)
					{
						cmyLimInfo = num13 - hScrollInfo;
						if (cmyLimInfo < 0)
						{
							cmyLimInfo = 0;
						}
					}
					else
					{
						cmyLimInfo = 0;
					}
					cmtoYInfo = cmyLimInfo;
				}
				else
				{
					cmyLimInfo = 0;
					num = 0;
					cmtoYInfo = 0;
					cmyInfo = 0;
				}
				break;
			}
			case 16:
			{
				column = 1;
				row = mapTrains.Count;
				item_height = 95;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_width = wScroll;
				item_start_X = xScroll;
				item_start_Y = yScroll + 5;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll) + 5;
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 17:
			{
				cmdItems.Clear();
				column = 4;
				row = 5;
				for (int num3 = 0; num3 < column * row; num3++)
				{
					GClass74 item2 = new GClass74(this, 41, num3);
					cmdItems.Add(item2);
				}
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = 415;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				cmdUpgrade.y = yScroll + hScroll - cmdUpgrade.h;
				cmdUpgrade.x = xScroll + wScroll - 155 - cmdUpgrade.w / 2;
				cmdUpgrade.isShow = true;
				break;
			}
			case 18:
			{
				cmdItems.Clear();
				column = 4;
				row = 5;
				for (int num21 = 0; num21 < column * row; num21++)
				{
					GClass74 item7 = new GClass74(this, 41, num21);
					cmdItems.Add(item7);
				}
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = 415;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				cmdStoneUpgrade.y = yScroll + hScroll - cmdStoneUpgrade.h - 10 - 75;
				cmdStoneUpgrade.x = xScroll + wScroll - 155 - cmdStoneUpgrade.w / 2;
				cmdStoneUpgrade.isShow = true;
				break;
			}
			case 19:
			{
				cmdItemsFriend.Clear();
				cmdItems.Clear();
				column = 3;
				row = 4;
				for (int num15 = 0; num15 < column * row; num15++)
				{
					GClass74 item4 = new GClass74(this, 53, num15);
					cmdItems.Add(item4);
					cmdItemsFriend.Add(new GClass74(this, 57, num15 + 12));
				}
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 115;
				hScroll = 330;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				cmdTrade.x = xScroll + wScroll / 2 - cmdTrade.w / 2;
				cmdTrade.y = yScroll + hScroll - cmdTrade.h;
				cmdTrade.isShow = true;
				break;
			}
			case 20:
			{
				cmdItems.Clear();
				column = 8;
				row = GClass25.gclass25_0.itemsBox.Count / column;
				for (int num8 = 0; num8 < column * row; num8++)
				{
					GClass74 item3 = new GClass74(this, 61, num8);
					cmdItems.Add(item3);
				}
				item_width = 75;
				item_height = 75;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = 5 * item_height + 4 * item_range_Y;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 21:
			{
				column = 2;
				row = list_4.Count / 2 + list_4.Count % 2;
				item_height = 79;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_width = wScroll / 2 - 10;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				for (int num4 = 0; num4 < list_4.Count; num4++)
				{
					list_4[num4].w = item_width;
					list_4[num4].h = item_height;
				}
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			case 22:
			{
				cmdSettings.Clear();
				for (int i = 0; i < 4; i++)
				{
					cmdSettings.Add(new GClass73(this, 62, i));
				}
				column = 2;
				row = cmdSettings.Count / 2 + cmdSettings.Count % 2;
				item_height = 79;
				item_range_X = 10;
				item_range_Y = 10;
				wScroll = width - 60;
				xScroll = x + 30;
				yScroll = y + 30;
				hScroll = height - 60;
				item_width = wScroll / 2 - 10;
				item_start_X = xScroll;
				item_start_Y = yScroll;
				for (int j = 0; j < cmdSettings.Count; j++)
				{
					cmdSettings[j].w = item_width;
					cmdSettings[j].h = item_height;
				}
				cmyLim = row * item_height + item_range_Y * (row - 1) - hScroll + (item_start_Y - yScroll);
				if (cmyLim < 0)
				{
					cmyLim = 0;
				}
				int num = 0;
				cmyTo = 0;
				cmy = 0;
				break;
			}
			}
		}

		public void method_42()
		{
			if (delayTrade >= 0 && GClass84.smethod_1() - lastTimeDelayTrade > 1000L)
			{
				lastTimeDelayTrade = GClass84.smethod_1();
				delayTrade--;
			}
			if (!isClose || 1 == 0)
			{
				if (y > yMax)
				{
					int num = y - yMax >> 1;
					if (num < 1)
					{
						num = 1;
					}
					y -= num;
					method_41(type);
				}
			}
			else if (y < yMin)
			{
				int num2 = yMin - y >> 1;
				if (num2 < 1)
				{
					num2 = 1;
				}
				if (y > GClass69.int_2 - 50)
				{
					y += num2;
				}
				else if (GClass69.int_0 % 2 == 0 || 1 == 0)
				{
					y += num2;
				}
				method_41(type);
			}
			else
			{
				method_45();
			}
			if (tabInfo.isShow && 0 == 0)
			{
				tabInfo.method_2();
				return;
			}
			if (chatTxtField.isShow && 0 == 0)
			{
				chatTxtField.method_5();
				return;
			}
			if (isPointerDownInScroll && 0 == 0 && pointerY != yPointerDown)
			{
				int num3 = pointerY - yPointerDown;
				yPointerDown = pointerY;
				cmyTo -= num3;
				if (cmyTo < 0)
				{
					cmyTo = 0;
				}
				if (cmyTo > cmyLim)
				{
					cmyTo = cmyLim;
				}
				if (cmy < 0 || cmy > cmyLim)
				{
					num3 = 0;
				}
				cmy -= num3;
				if (cmy < 0)
				{
					cmy = 0;
				}
				if (cmy > cmyLim)
				{
					cmy = cmyLim;
				}
			}
			if (isPointerDownInScrollInfo && 0 == 0 && pointerY != yPointerDown)
			{
				int num4 = pointerY - yPointerDown;
				yPointerDown = pointerY;
				cmtoYInfo -= num4;
				if (cmtoYInfo < 0)
				{
					cmtoYInfo = 0;
				}
				if (cmtoYInfo > cmyLimInfo)
				{
					cmtoYInfo = cmyLimInfo;
				}
				if (cmyInfo < 0 || cmyInfo > cmyLimInfo)
				{
					num4 = 0;
				}
				cmyInfo -= num4;
				if (cmyInfo < 0)
				{
					cmyInfo = 0;
				}
				if (cmyInfo > cmyLimInfo)
				{
					cmyInfo = cmyLimInfo;
				}
			}
			if (cmy < cmyTo)
			{
				int num5 = cmyTo - cmy >> 1;
				if (num5 < 1)
				{
					num5 = 1;
				}
				cmy += num5;
			}
			else if (cmy > cmyTo)
			{
				int num6 = cmy - cmyTo >> 1;
				if (num6 < 1)
				{
					num6 = 1;
				}
				cmy -= num6;
			}
			if (cmyInfo < cmtoYInfo)
			{
				int num7 = cmtoYInfo - cmyInfo >> 1;
				if (num7 < 1)
				{
					num7 = 1;
				}
				cmyInfo += num7;
			}
			else if (cmyInfo > cmtoYInfo)
			{
				int num8 = cmyInfo - cmtoYInfo >> 1;
				if (num8 < 1)
				{
					num8 = 1;
				}
				cmyInfo -= num8;
			}
			int num9 = type;
			if ((uint)(num9 - 12) <= 3u)
			{
				txtChat.method_7();
			}
		}

		public void method_43(GClass16 item, int action)
		{
			string text = "";
			int num = item.method_3();
			if (action == GClass0.int_2)
			{
				text = text + "n2Giá: " + GClass84.smethod_16(item.price) + ((item.typePrice == 0) ? " xu" : " kim cương") + "|";
			}
			if (item.template.description != "Chưa có")
			{
				text = text + "n2" + item.template.description + "|";
			}
			text = ((GClass25.gclass25_0.level >= item.template.levelRequire) ? (text + "n3Yêu cầu trình độ cấp " + item.template.levelRequire) : (text + "n0Yêu cầu trình độ cấp " + item.template.levelRequire));
			if (item.template.gender != -1)
			{
				string text2 = "Tộc: Trái đất";
				if (item.template.gender == 1)
				{
					text2 = "Tộc: Namek";
				}
				else if (item.template.gender == 2)
				{
					text2 = "Tộc: Saiyan";
				}
				text = ((GClass25.gclass25_0.gender != item.template.gender) ? (text + "|n0" + text2) : (text + "|n3" + text2));
			}
			if (item.template.sex != -1)
			{
				string text3 = "Giới tính: " + ((item.template.sex == 0) ? "Nữ" : "Nam");
				text = ((GClass25.gclass25_0.sex != item.template.sex) ? (text + "|n0" + text3) : (text + "|n3" + text3));
			}
			if (item.template.type < 8)
			{
				foreach (GClass17 option in item.options)
				{
					if (option.template.type == 0)
					{
						text = text + "|n2" + option.method_0();
					}
				}
				text += "|n5Kích ẩn";
				bool flag = false;
				for (int i = 0; i < 8; i++)
				{
					if (GClass25.gclass25_0.itemsBody[i] == null)
					{
						flag = true;
						break;
					}
				}
				foreach (GClass17 option2 in item.options)
				{
					if (option2.template.type == 2)
					{
						text = text + (flag ? "|n4" : "|n2") + option2.method_0();
					}
				}
				text += "|n5Kích cấp độ";
				foreach (GClass17 option3 in item.options)
				{
					if (option3.template.type == 1)
					{
						string text4 = option3.method_0();
						text = ((num < 12) ? ((num < 8) ? ((num < 4) ? (text + "|n4" + text4) : (text + (text4.Contains("(+4)") ? "|n2" : "|n4") + text4)) : (text + ((text4.Contains("(+4)") || text4.Contains("(+8)")) ? "|n2" : "|n4") + text4)) : (text + "|n2" + text4));
					}
				}
			}
			else
			{
				foreach (GClass17 option4 in item.options)
				{
					text = text + "|n2" + option4.method_0();
				}
			}
			string text5 = ((item.method_3() > 0) ? (" +" + item.method_3()) : "");
			if (action == GClass0.int_0)
			{
				if (tabs.Contains(Panel.gclass47_9))
				{
					GClass72 gClass = new GClass75("Bán", this, 11, item);
					tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass);
				}
				else if (tabs.Contains(Panel.gclass47_8))
				{
					GClass72 gClass2 = new GClass75("Chọn", this, 29, item);
					tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass2);
				}
				else if (tabs.Contains(Panel.gclass47_21))
				{
					GClass72 gClass3 = new GClass75("Chọn", this, 46, item);
					tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass3);
				}
				else if (tabs.Contains(Panel.gclass47_20))
				{
					GClass72 gClass4 = new GClass75("Chọn", this, 55, item);
					tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass4);
				}
				else if (tabs.Contains(Panel.gclass47_22))
				{
					GClass72 gClass5 = new GClass75("Cất vào", this, 59, item);
					tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass5);
				}
				else
				{
					GClass72 gClass6 = new GClass75("Sử dụng", this, 1, item);
					GClass72 gClass7 = new GClass75("Bỏ ra", this, 2, item);
					tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass6, gClass7);
				}
			}
			else if (action == GClass0.int_1)
			{
				GClass72 gClass8 = new GClass75("Tháo ra", this, 9, item);
				tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass8);
			}
			else if (action == GClass0.int_2)
			{
				GClass72 gClass9 = new GClass75("Mua", this, 10, item);
				tabInfo.method_3(item.template.name, text, item.template.iconId, gClass9);
			}
			else if (action == GClass0.int_4)
			{
				GClass72 gClass10 = new GClass75("Bỏ ra", this, 30, item);
				tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass10);
			}
			else if (action == GClass0.int_6)
			{
				GClass72 gClass11 = new GClass75("Bỏ ra", this, 56, item);
				tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass11);
			}
			else if (action == GClass0.int_7)
			{
				GClass72 gClass12 = new GClass75("Đóng", this, 0, item);
				tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass12);
			}
			else if (action == GClass0.int_10)
			{
				GClass72 gClass13 = new GClass75("Lấy ra", this, 60, item);
				tabInfo.method_3(item.template.name + text5, text, item.template.iconId, gClass13);
			}
		}

		public void method_44()
		{
			GClass78.smethod_5();
			isShow = true;
			list_5.Clear();
			tabInfo.isShow = false;
			cmdItemUpgrade.item = null;
			cmdItemToUpgrade.item = null;
			list_1.Clear();
			itemsMe.Clear();
			itemsFriend.Clear();
			xuTrade = 0;
			xuFriendTrade = 0;
		}

		public void method_45()
		{
			isShow = false;
			isClose = false;
			cmdItemUpgrade.item = null;
			cmdItemToUpgrade.item = null;
			list_1.Clear();
			list_5.Clear();
			itemsMe.Clear();
			itemsFriend.Clear();
			xuTrade = 0;
			xuFriendTrade = 0;
		}

		public void method_46()
		{
			isClose = true;
			GClass43.smethod_7();
		}

		public void imethod_0(int idAction, object p)
		{
			switch (idAction)
			{
			case 1:
				GClass0.smethod_20(GClass0.int_0, ((GClass16)p).indexUI);
				tabInfo.method_4();
				break;
			case 2:
				GClass0.smethod_20(GClass0.int_3, ((GClass16)p).indexUI);
				tabInfo.method_4();
				break;
			case 3:
				if (indexSelect < GClass25.gclass25_0.skills.Count && indexSelect >= 0)
				{
					GClass34 gClass7 = GClass25.gclass25_0.skills[indexSelect];
					if (gClass7 != null)
					{
						GClass0.smethod_18(gClass7.template.id, 1);
					}
				}
				break;
			case 4:
				chatTxtField.method_9(GClass83.string_46[0], GClass83.string_46[1], 1);
				break;
			case 5:
			{
				List<GClass72> list7 = new List<GClass72>();
				for (int i = 0; i < 5; i++)
				{
					list7.Add(new GClass72("Ô phím tắt số " + (i + 1), this, 8, i));
				}
				GClass69.gclass80_0.method_0(list7);
				break;
			}
			case 6:
				GClass0.smethod_17(indexSelect, 1);
				break;
			case 7:
				chatTxtField.method_9(GClass83.string_47[0], GClass83.string_47[1], 4);
				break;
			case 8:
				if (indexSelect < GClass25.gclass25_0.skills.Count && indexSelect >= 0)
				{
					int index = (int)p;
					GClass34 gClass5 = GClass25.gclass25_0.skills[indexSelect];
					if (gClass5 != null && gClass5.template.isProactive && gClass5.level > 0)
					{
						GClass0.smethod_21(index, gClass5.template.id);
					}
				}
				break;
			case 9:
				GClass0.smethod_20(GClass0.int_1, ((GClass16)p).indexUI);
				tabInfo.method_4();
				break;
			case 10:
				GClass0.smethod_25(itemSelected.id);
				tabInfo.method_4();
				GClass78.smethod_1();
				break;
			case 11:
				tabInfo.method_4();
				GClass69.smethod_20("Bạn có chắc chắn muốn bán " + ((GClass16)p).template.name + " với giá 5 xu không? Sau khi bán sẽ không thể hoàn tác.", new GClass72("Có", this, 12, p), new GClass72(GClass83.string_19, GClass69.gclass69_0, 1, null));
				break;
			case 12:
				GClass0.smethod_26(itemSelected.indexUI);
				GClass69.gclass76_0.method_7();
				GClass78.smethod_1();
				break;
			case 13:
				GClass79.smethod_3("Tính năng đang phát triển", 0);
				break;
			case 14:
				GClass0.smethod_29(0, (int)p);
				break;
			case 15:
			{
				GClass25 player = (GClass25)p;
				method_48(player);
				method_40(15);
				method_44();
				break;
			}
			case 16:
				GClass0.smethod_27(2, (int)p);
				break;
			case 17:
				GClass79.smethod_3("Tính năng đang phát triển.", 0);
				break;
			case 18:
				GClass0.smethod_28(2, (int)p);
				break;
			case 19:
				GClass0.smethod_29(0, -1);
				break;
			case 20:
				GClass0.smethod_29(6, -1);
				break;
			case 21:
				GClass0.smethod_29(3, -1);
				break;
			case 22:
				GClass0.smethod_29(2, -1);
				break;
			case 23:
				GClass0.smethod_29(5, ((GClass25)p).id);
				break;
			case 24:
				GClass0.smethod_29(4, ((GClass25)p).id);
				break;
			case 25:
				GClass0.smethod_29(7, (int)p);
				break;
			case 26:
				method_46();
				if (type == 19)
				{
					GClass0.smethod_35(2, -1, -1);
				}
				break;
			case 27:
			{
				string text = txtChat.method_5();
				if (text == null || text.Length == 0)
				{
					break;
				}
				if (txtChat.name.Contains(GClass83.string_50))
				{
					if (GClass25.gclass25_0.diamond < 5)
					{
						GClass79.smethod_3("Cần ít nhất 5 kim cương để chat thế giới.", 0);
						txtChat.method_0();
						break;
					}
					GClass0.smethod_6(text);
				}
				else if (txtChat.name.Contains(GClass83.string_51))
				{
					if (GClass25.gclass25_0.clan != null)
					{
						GClass0.smethod_7(text);
					}
				}
				else if (txtChat.name.Contains(GClass83.string_52))
				{
					if (GClass25.gclass25_0.team != null)
					{
						GClass0.smethod_8(text);
					}
				}
				else if (txtChat.name.Contains(GClass83.string_53))
				{
					dictionary_0.ElementAt(focusSelect).Value.Add(new GClass73(this, 51, GClass25.gclass25_0, text));
					GClass0.smethod_9(text, dictionary_0.ElementAt(focusSelect).Key.playerInfo.id);
					method_41(15);
				}
				txtChat.method_0();
				break;
			}
			case 28:
				if (cmdItemUpgrade.item == null)
				{
					GClass79.smethod_3("Vui lòng chọn vật phẩm.", 0);
					break;
				}
				if (list_1.Count == 0)
				{
					GClass79.smethod_3("Vui lòng chọn đá nâng cấp.", 0);
					break;
				}
				try
				{
					GClass16 item = cmdItemUpgrade.item;
					if (item == null)
					{
						GClass79.smethod_3("Vui lòng chọn vật phẩm.", 0);
						break;
					}
					if (item.template.type >= 8)
					{
						GClass79.smethod_3("Vui lòng chọn vật phẩm.", 0);
						break;
					}
					GClass0.smethod_32(item, list_1);
					GClass78.smethod_1();
					break;
				}
				catch
				{
					break;
				}
			case 29:
			{
				tabInfo.method_4();
				GClass16 gClass8 = (GClass16)p;
				if (gClass8 != null)
				{
					if (gClass8.template.type < 8)
					{
						cmdItemUpgrade.item = gClass8;
						cmdItemToUpgrade.item = gClass8.method_2();
					}
					else if (gClass8.template.type != 18 && gClass8.template.id != 93 && gClass8.template.id != 94 && gClass8.template.id != 95)
					{
						GClass79.smethod_3("Vật phẩm không hợp lệ.", 0);
					}
					else if (list_1.Contains(gClass8))
					{
						GClass79.smethod_3("Vật phẩm đã được chọn.", 0);
					}
					else
					{
						list_1.Add(gClass8);
					}
				}
				break;
			}
			case 30:
			{
				GClass16 gClass6 = (GClass16)p;
				if (gClass6.template.type < 8)
				{
					cmdItemUpgrade.item = null;
					cmdItemToUpgrade.item = null;
				}
				else
				{
					list_1.Remove(gClass6);
				}
				tabInfo.method_4();
				break;
			}
			case 31:
				indexSelect = (int)p;
				if (indexSelect < GClass25.gclass25_0.itemsBag.Count)
				{
					itemSelected = GClass25.gclass25_0.itemsBag[indexSelect];
					if (itemSelected != null)
					{
						method_43(itemSelected, GClass0.int_0);
					}
				}
				break;
			case 32:
			{
				indexSelect = (int)p;
				GClass34 gClass3 = GClass25.gclass25_0.skills[indexSelect];
				List<GClass72> list2 = new List<GClass72>();
				if (GClass25.gclass25_0.pointSkill > 0)
				{
					list2.Add(new GClass72("Cộng", this, 3, indexSelect));
					if (GClass25.gclass25_0.pointSkill > 1)
					{
						list2.Add(new GClass72("Cộng nhiều", this, 4, indexSelect));
					}
				}
				if (gClass3.template.isProactive && gClass3.level > 0)
				{
					list2.Add(new GClass72("Gán", this, 5, indexSelect));
				}
				if (list2.Count > 0)
				{
					GClass69.gclass80_0.method_0(list2);
				}
				cmtoYInfo = 0;
				break;
			}
			case 33:
			{
				indexSelect = (int)p;
				long num = GClass25.gclass25_0.potentialUpDamage;
				if (indexSelect == 1)
				{
					num = GClass25.gclass25_0.potentialUpHp;
				}
				else if (indexSelect == 2)
				{
					num = GClass25.gclass25_0.potentialUpMp;
				}
				else if (indexSelect == 3)
				{
					num = GClass25.gclass25_0.potentialUpConstitution;
				}
				if (GClass25.gclass25_0.potential >= num)
				{
					List<GClass72> list = new List<GClass72>();
					list.Add(new GClass72("Cộng", this, 6, indexSelect));
					list.Add(new GClass72("Cộng nhiều", this, 7, indexSelect));
					GClass69.gclass80_0.method_0(list);
				}
				break;
			}
			case 34:
				itemSelected = GClass25.gclass25_0.itemsBody[(int)p];
				if (itemSelected != null)
				{
					method_43(itemSelected, GClass0.int_1);
				}
				break;
			case 35:
				GClass0.smethod_22((int)p);
				break;
			case 36:
				indexSelect = (int)p;
				if (indexSelect < list_0.Count)
				{
					itemSelected = list_0[indexSelect];
					if (itemSelected != null)
					{
						method_43(itemSelected, GClass0.int_2);
					}
				}
				break;
			case 37:
			{
				indexSelect = (int)p;
				List<GClass72> list11 = new List<GClass72>();
				if (GClass25.gclass25_0.id == GClass25.gclass25_0.team.members[0].playerInfo.id)
				{
					if (indexSelect != 0)
					{
						list11.Add(new GClass72("Xem thông tin", this, 13, GClass25.gclass25_0.team.members[indexSelect].playerInfo));
						list11.Add(new GClass72("Chat riêng", this, 15, GClass25.gclass25_0.team.members[indexSelect].playerInfo));
						list11.Add(new GClass72("Nhường chức", this, 23, GClass25.gclass25_0.team.members[indexSelect].playerInfo));
						list11.Add(new GClass72("Khai trừ", this, 24, GClass25.gclass25_0.team.members[indexSelect].playerInfo));
					}
				}
				else if (GClass25.gclass25_0.id != (int)p)
				{
					list11.Add(new GClass72("Xem thông tin", this, 13, GClass25.gclass25_0.team.members[indexSelect].playerInfo));
					list11.Add(new GClass72("Chat riêng", this, 15, GClass25.gclass25_0.team.members[indexSelect].playerInfo));
				}
				GClass69.gclass80_0.method_0(list11);
				break;
			}
			case 38:
			{
				indexSelect = (int)p;
				List<GClass72> list10 = new List<GClass72>();
				list10.Add(new GClass72("Xem thông tin", this, 13, list_5[indexSelect].playerInfo));
				list10.Add(new GClass72("Chat riêng", this, 15, list_5[indexSelect].playerInfo));
				list10.Add(new GClass72("Xin vào", this, 25, list_5[indexSelect].id));
				GClass69.gclass80_0.method_0(list10);
				break;
			}
			case 39:
			{
				indexSelect = (int)p;
				List<GClass72> list9 = new List<GClass72>();
				list9.Add(new GClass72("Xem thông tin", this, 13, list_2[indexSelect].playerInfo));
				list9.Add(new GClass72("Mời vào tổ đội", this, 14, list_2[indexSelect].playerInfo.id));
				list9.Add(new GClass72("Chat riêng", this, 15, list_2[indexSelect].playerInfo));
				list9.Add(new GClass72("Xóa", this, 16, list_2[indexSelect].playerInfo.id));
				GClass69.gclass80_0.method_0(list9);
				break;
			}
			case 40:
			{
				indexSelect = (int)p;
				List<GClass72> list8 = new List<GClass72>();
				list8.Add(new GClass72("Xem thông tin", this, 13, list_3[indexSelect].playerInfo));
				list8.Add(new GClass72("Trả thù", this, 17, list_3[indexSelect].playerInfo.id));
				list8.Add(new GClass72("Xóa", this, 18, list_3[indexSelect].playerInfo.id));
				GClass69.gclass80_0.method_0(list8);
				break;
			}
			case 41:
				indexSelect = (int)p;
				if (indexSelect < list_1.Count)
				{
					method_43(list_1[indexSelect], GClass0.int_4);
				}
				break;
			case 42:
				if (cmdItemUpgrade.item != null)
				{
					method_43(cmdItemUpgrade.item, GClass0.int_4);
				}
				break;
			case 43:
				if (cmdItemToUpgrade.item != null)
				{
					method_43(cmdItemToUpgrade.item, GClass0.int_4);
				}
				break;
			case 45:
				if (list_1.Count == 0)
				{
					GClass79.smethod_3("Vui lòng chọn đá nâng cấp.", 0);
					break;
				}
				GClass0.smethod_33(list_1);
				GClass78.smethod_1();
				break;
			case 46:
			{
				tabInfo.method_4();
				GClass16 gClass4 = (GClass16)p;
				if (gClass4 == null)
				{
					break;
				}
				if (gClass4.template.type == 18)
				{
					if (list_1.Contains(gClass4))
					{
						GClass79.smethod_3("Vật phẩm đã được chọn.", 0);
					}
					else
					{
						list_1.Add(gClass4);
					}
				}
				else
				{
					GClass79.smethod_3("Vật phẩm không hợp lệ.", 0);
				}
				break;
			}
			case 47:
			{
				indexSelect = (int)p;
				GClass25 playerInfo4 = list_6[indexSelect].playerInfo;
				if (playerInfo4 != null && playerInfo4.id != GClass25.gclass25_0.id)
				{
					List<GClass72> list6 = new List<GClass72>();
					list6.Add(new GClass72("Xem thông tin", this, 13, playerInfo4));
					list6.Add(new GClass72("Chat riêng", this, 15, playerInfo4));
					list6.Add(new GClass72("Kết bạn", GClass3.smethod_0(), 31, playerInfo4.id));
					GClass69.gclass80_0.method_0(list6);
				}
				break;
			}
			case 48:
			{
				indexSelect = (int)p;
				GClass25 playerInfo3 = list_7[indexSelect].playerInfo;
				if (playerInfo3 != null && playerInfo3.id != GClass25.gclass25_0.id)
				{
					List<GClass72> list5 = new List<GClass72>();
					list5.Add(new GClass72("Xem thông tin", this, 13, playerInfo3));
					list5.Add(new GClass72("Chat riêng", this, 15, playerInfo3));
					list5.Add(new GClass72("Kết bạn", GClass3.smethod_0(), 31, playerInfo3.id));
					GClass69.gclass80_0.method_0(list5);
				}
				break;
			}
			case 49:
			{
				indexSelect = (int)p;
				GClass25 playerInfo2 = list_8[indexSelect].playerInfo;
				if (playerInfo2 != null && playerInfo2.id != GClass25.gclass25_0.id)
				{
					List<GClass72> list4 = new List<GClass72>();
					list4.Add(new GClass72("Xem thông tin", this, 13, playerInfo2));
					list4.Add(new GClass72("Chat riêng", this, 15, playerInfo2));
					list4.Add(new GClass72("Kết bạn", GClass3.smethod_0(), 31, playerInfo2.id));
					GClass69.gclass80_0.method_0(list4);
				}
				break;
			}
			case 50:
				focusSelect = (int)p;
				cmyInfo = 0;
				method_41(15);
				break;
			case 51:
				try
				{
					indexSelect = (int)p;
					GClass25 playerInfo = dictionary_0.ElementAt(focusSelect).Value[indexSelect].playerInfo;
					if (playerInfo != null && playerInfo.id != GClass25.gclass25_0.id)
					{
						List<GClass72> list3 = new List<GClass72>();
						list3.Add(new GClass72("Xem thông tin", this, 13, playerInfo));
						list3.Add(new GClass72("Xóa", this, 52, dictionary_0.ElementAt(focusSelect).Key));
						list3.Add(new GClass72("Kết bạn", GClass3.smethod_0(), 31, playerInfo.id));
						GClass69.gclass80_0.method_0(list3);
					}
					break;
				}
				catch
				{
					break;
				}
			case 52:
				dictionary_0.Remove((GClass73)p);
				break;
			case 53:
			{
				int num3 = (int)p;
				if (num3 < itemsMe.Count)
				{
					method_43(itemsMe[num3], GClass0.int_6);
				}
				break;
			}
			case 54:
				GClass0.smethod_35(6, -1, -1);
				break;
			case 55:
			{
				tabInfo.method_4();
				GClass16 gClass2 = (GClass16)p;
				if (gClass2 != null)
				{
					if (itemsMe.Contains(gClass2))
					{
						GClass79.smethod_3("Vật phẩm đã được chọn.", 0);
					}
					else if (itemsMe.Count >= 12)
					{
						GClass79.smethod_3("Chỉ được giao dịch tối đa 12 vật phẩm.", 0);
					}
					else
					{
						GClass0.smethod_35(3, -1, gClass2.indexUI);
					}
				}
				break;
			}
			case 56:
			{
				tabInfo.method_4();
				GClass16 gClass = (GClass16)p;
				if (gClass != null)
				{
					GClass0.smethod_35(4, -1, gClass.indexUI);
				}
				break;
			}
			case 57:
			{
				int num2 = (int)p - 12;
				if (num2 < itemsFriend.Count)
				{
					method_43(itemsFriend[num2], GClass0.int_7);
				}
				break;
			}
			case 58:
				chatTxtField.method_9(GClass83.string_48[0], GClass83.string_48[1], 10);
				break;
			case 59:
				GClass0.smethod_20(GClass0.int_8, ((GClass16)p).indexUI);
				tabInfo.method_4();
				break;
			case 60:
				GClass0.smethod_20(GClass0.int_9, ((GClass16)p).indexUI);
				tabInfo.method_4();
				break;
			case 61:
				indexSelect = (int)p;
				if (indexSelect < GClass25.gclass25_0.itemsBox.Count)
				{
					itemSelected = GClass25.gclass25_0.itemsBox[indexSelect];
					if (itemSelected != null)
					{
						method_43(itemSelected, GClass0.int_10);
					}
				}
				break;
			case 62:
				switch ((int)p)
				{
				case 0:
					GClass69.bool_0 = !GClass69.bool_0;
					GClass64.smethod_9("isPlaySound", GClass69.bool_0 ? 1 : 0);
					break;
				case 1:
					Class0.bool_0 = !Class0.bool_0;
					GClass64.smethod_9("isPaintMiniMap", Class0.bool_0 ? 1 : 0);
					break;
				case 2:
					GClass3.bool_4 = !GClass3.bool_4;
					GClass64.smethod_9("isPaintTask", GClass3.bool_4 ? 1 : 0);
					break;
				case 3:
					GClass3.bool_5 = !GClass3.bool_5;
					GClass64.smethod_9("isPaintGamePad", GClass3.bool_5 ? 1 : 0);
					break;
				}
				break;
			case 44:
				break;
			}
		}

		public void imethod_1(string text, string to)
		{
			if (chatTxtField.textField.method_5() != null && 0 == 0 && (!chatTxtField.textField.method_5().Equals(string.Empty) || 1 == 0) && (!text.Equals(string.Empty) || 1 == 0) && ((text != null) ? true : false))
			{
				if (chatTxtField.name.Equals(GClass83.string_45[0]) && 0 == 0)
				{
					Debug.Log(text);
					chatTxtField.method_6();
				}
				else if (chatTxtField.name.Equals(GClass83.string_46[0]) && 0 == 0)
				{
					try
					{
						int num = int.Parse(text);
						if (num <= 0)
						{
							GClass69.smethod_16("Điểm phải lớn hơn 0");
							return;
						}
						GClass0.smethod_18(GClass25.gclass25_0.skills[indexSelect].template.id, num);
						chatTxtField.method_6();
						return;
					}
					catch
					{
					}
					chatTxtField.method_6();
					GClass69.smethod_16("Điểm không hợp lệ!");
				}
				else if (chatTxtField.name.Equals(GClass83.string_47[0]) && 0 == 0)
				{
					try
					{
						int num2 = int.Parse(text);
						if (num2 <= 0)
						{
							GClass69.smethod_16("Điểm phải lớn hơn 0");
							return;
						}
						GClass0.smethod_17(indexSelect, num2);
						chatTxtField.method_6();
						return;
					}
					catch
					{
					}
					chatTxtField.method_6();
					GClass69.smethod_16("Điểm không hợp lệ!");
				}
				else
				{
					if (!chatTxtField.name.Equals(GClass83.string_48[0]))
					{
						return;
					}
					try
					{
						int num3 = int.Parse(text);
						if (num3 <= 0)
						{
							GClass69.smethod_16("Xu phải lớn hơn 0");
							return;
						}
						GClass0.smethod_35(5, -1, num3);
						chatTxtField.method_6();
						return;
					}
					catch
					{
					}
					chatTxtField.method_6();
					GClass69.smethod_16("Xu không hợp lệ!");
				}
			}
			else
			{
				chatTxtField.method_6();
			}
		}

		public void method_47()
		{
			cmdActionsTeam.Clear();
			if (GClass25.gclass25_0.team == null || 1 == 0)
			{
				cmdActionsTeam.Add(new GClass75("Tìm tổ đội", this, 20, null));
				cmdActionsTeam.Add(new GClass75("Tạo tổ đội", this, 19, null));
				return;
			}
			cmdActionsTeam.Add(new GClass75("Rời tổ đội", this, 22, null));
			if (GClass25.gclass25_0.id == GClass25.gclass25_0.team.members[0].playerInfo.id)
			{
				cmdActionsTeam.Add(new GClass75((GClass25.gclass25_0.team.isLock ? true : false) ? "Mở khóa tổ đội" : "Khóa tổ đội", this, 21, null));
			}
		}

		public void method_48(GClass25 player)
		{
			bool flag = false;
			for (int i = 0; i < dictionary_0.Count; i++)
			{
				if (dictionary_0.ElementAt(i).Key.playerInfo.id == player.id)
				{
					focusSelect = i;
					flag = true;
					break;
				}
			}
			if (flag ? true : false)
			{
				return;
			}
			GClass73 gClass = new GClass73(this, 50, null);
			gClass.playerInfo = player;
			dictionary_0.Add(gClass, new List<GClass73>());
			int num = 0;
			while (true)
			{
				if (num < dictionary_0.Count)
				{
					if (dictionary_0.ElementAt(num).Key.playerInfo.id == player.id)
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			focusSelect = num;
		}

		public void method_49(GClass25 player, string content)
		{
			method_48(player);
			for (int i = 0; i < dictionary_0.Count; i++)
			{
				if (dictionary_0.ElementAt(i).Key.playerInfo.id == player.id)
				{
					dictionary_0.ElementAt(i).Key.isNew = true;
					GClass73 item = new GClass73(this, 51, player, content);
					dictionary_0.ElementAt(i).Value.Add(item);
					break;
				}
			}
			if (isShow && 0 == 0 && type == 15)
			{
				method_41(15);
			}
		}

		public bool method_50()
		{
			try
			{
				int num = 0;
				while (true)
				{
					if (num < dictionary_0.Count)
					{
						if (dictionary_0.ElementAt(num).Key.isNew && 0 == 0)
						{
							break;
						}
						num++;
						continue;
					}
					return false;
				}
				return true;
			}
			catch
			{
			}
			return false;
		}

		public void imethod_2()
		{
		}
	}
}
