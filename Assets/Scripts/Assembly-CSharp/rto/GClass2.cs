using UnityEngine;

namespace rto
{
	public class GClass2 : GClass1, GInterface1
	{
		public static GClass66 gclass66_0;

		public GClass25 player;

		public int indexSelect;

		public int indexPointerMove = -1;

		public int xScroll;

		public int yScroll;

		public int wScroll;

		public int hScroll;

		public GClass57 textField;

		public GClass72 cmdOk;

		public int sex = 1;

		public static GClass66 gclass66_1;

		public static GClass66 gclass66_2;

		public static GClass66 gclass66_3;

		public static GClass66 gclass66_4;

		public static int int_0;

		public static GClass66[] gclass66_5;

		public static GClass66 gclass66_6;

		private int cmx;

		public static int[,] int_1;

		public static int[,] int_2;

		public static string[] string_0;

		public static string[,] string_1;

		static GClass2()
		{
			int_0 = 0;
			int_1 = new int[6, 3]
			{
				{ 0, 6, 7 },
				{ 1, 18, 19 },
				{ 2, 14, 15 },
				{ 3, 20, 21 },
				{ 4, 22, 23 },
				{ 5, 16, 17 }
			};
			int_2 = new int[6, 2]
			{
				{ 3, 5 },
				{ 4, 4 },
				{ 3, 5 },
				{ 4, 4 },
				{ 4, 4 },
				{ 5, 3 }
			};
			string_0 = new string[5] { "Hành tinh: ", "Tấn công: ", "Phòng thủ: ", "Đặc biệt: ", "Khắc chế: " };
			string_1 = new string[6, 6]
			{
				{ "GoHan", "Trái đất", ".", ".", "Tri Beam", "Sayain" },
				{ "Krillin", "Trái đất", ".", ".", "Destructo Disc", "Namek" },
				{ "Dende", "Namek", ".", ".", "Evil Containment Wave", "Trái đất" },
				{ "Picolo", "Namek", ".", ".", "Special Beam Canmom", "Sayain" },
				{ "Vegeta", "Saiyan", ".", ".", "Explosion", "Namek" },
				{ "Songoku", "Saiyan", ".", ".", "Genki Dama", "Trái đất" }
			};
			gclass66_5 = new GClass66[6];
			for (int i = 0; i < gclass66_5.Length; i++)
			{
				gclass66_5[i] = GClass69.smethod_9("imgClassReg" + i);
			}
			gclass66_0 = GClass69.smethod_9("imgSoil.png");
			gclass66_1 = GClass69.smethod_9("imgMay.png");
			gclass66_2 = GClass69.smethod_9("imgMay1.png");
			gclass66_3 = GClass69.smethod_9("imgStar.png");
			gclass66_4 = GClass69.smethod_9("imgStar1.png");
			gclass66_6 = GClass69.smethod_9("imgSelectReg.png");
		}

		public GClass2()
		{
			indexSelect = GClass84.smethod_8(0, 5);
			int num = GClass30.smethod_0(65);
			while (true)
			{
				switch (num ^ 0x3B)
				{
				default:
					goto IL_002b;
				case -38:
					while (true)
					{
						num = -31;
						num = -38;
					}
				case -30:
					player = new GClass25();
					num = -29;
					num = -40;
					goto case -40;
				case -40:
					player.x = GClass69.int_1 / 2;
					num = -25;
					num = -36;
					goto case -36;
				case -36:
					player.y = GClass69.int_2 / 2 + 65;
					num = -30;
					num = -39;
					goto case -39;
				case -39:
					player.head = int_1[indexSelect, 0];
					num = -32;
					num = -37;
					goto case -37;
				case -37:
					player.body = int_1[indexSelect, 1];
					num = -40;
					num = -29;
					goto case -29;
				case -29:
					player.leg = int_1[indexSelect, 2];
					num = -37;
					num = -32;
					goto case -32;
				case -32:
					wScroll = 340;
					num = -22;
					num = -47;
					goto case -47;
				case -47:
					hScroll = 360;
					num = -38;
					num = -31;
					goto case -31;
				case -31:
					xScroll = GClass69.int_1 / 2 - 280 - wScroll;
					num = -11;
					num = -50;
					goto case -50;
				case -50:
					yScroll = GClass69.int_2 / 2 - hScroll / 2;
					num = -23;
					num = -46;
					goto case -46;
				case -46:
					textField = new GClass57();
					num = -24;
					num = -45;
					goto case -45;
				case -45:
					textField.width = 300;
					num = -12;
					num = -49;
					goto case -49;
				case -49:
					textField.name = "Tên nhân vật";
					num = -20;
					num = -41;
					goto case -41;
				case -41:
					textField.y = GClass69.int_2 / 2 + 250;
					num = -21;
					num = -48;
					goto case -48;
				case -48:
					textField.maxTextLenght = 10;
					num = -19;
					num = -42;
					goto case -42;
				case -42:
					cmdOk = new GClass72("imgChatPanelScr", "imgChatPanelScrFocus", "imgChatPanelScrClick", "OK", this, 1, null);
					num = -27;
					num = -34;
					goto case -34;
				case -34:
					cmdOk.y = textField.y;
					num = -17;
					num = -44;
					goto case -44;
				case -44:
					cmdOk.w = 100;
					num = -18;
					num = -43;
					goto case -43;
				case -43:
					textField.command = cmdOk;
					num = -28;
					num = -33;
					goto case -33;
				case -33:
					textField.x = GClass69.int_1 / 2 - (textField.width + 20 + cmdOk.w) / 2;
					num = -26;
					num = -35;
					break;
				case -35:
					break;
				case -28:
					return;
				}
				break;
				IL_002b:
				num = GClass30.smethod_0(65);
			}
			cmdOk.x = textField.x + textField.width + 20;
			num = -33;
			num = -28;
		}

		public override void vmethod_1(GClass68 g)
		{
			g.method_31();
			GClass69.smethod_7(g);
			Graphics.DrawTexture(new Rect(0f, 0f, GClass69.int_1, GClass69.int_2), GClass4.gclass66_0.texture);
			g.method_28(gclass66_0, GClass69.int_1 / 2, GClass69.int_2 / 2 + 45, GClass45.int_0);
			cmx++;
			for (int i = -(cmx >> 4); i < GClass69.int_1; i += 1440)
			{
				if (i > -1440)
				{
					g.method_28(gclass66_1, i, GClass69.int_2, GClass45.int_4);
				}
			}
			for (int i = -(cmx >> 5); i < GClass69.int_1; i += 872)
			{
				if (i > -873)
				{
					g.method_28(gclass66_2, i, 0, GClass45.int_1);
				}
			}
			GClass67.gclass67_10.method_1(g, GClass70.string_4, GClass69.int_1 - 2, 2, 1);
			GClass67.gclass67_10.method_1(g, "version " + GClass70.string_3, GClass69.int_1 - 2, 36, 1);
			g.method_28(Class0.gclass66_2, player.x, player.y - 2, 3);
			GClass31 gClass = GClass69.list_2[player.head];
			GClass31 gClass2 = GClass69.list_2[player.body];
			GClass31 gClass3 = GClass69.list_2[player.leg];
			GClass42.smethod_1(g, gClass.pi[GClass25.int_1[player.frame][0][0]].id, player.x + GClass25.int_1[player.frame][0][1] * player.dir + gClass.pi[GClass25.int_1[player.frame][0][0]].dx * player.dir, player.y - GClass25.int_1[player.frame][0][2] + gClass.pi[GClass25.int_1[player.frame][0][0]].dy, (player.dir != 1) ? 2 : 0, (player.dir != 1) ? 24 : 0);
			GClass42.smethod_1(g, gClass3.pi[GClass25.int_1[player.frame][2][0]].id, player.x + GClass25.int_1[player.frame][2][1] * player.dir + gClass3.pi[GClass25.int_1[player.frame][2][0]].dx * player.dir, player.y - GClass25.int_1[player.frame][2][2] + gClass3.pi[GClass25.int_1[player.frame][2][0]].dy, (player.dir != 1) ? 2 : 0, (player.dir != 1) ? 24 : 0);
			GClass42.smethod_1(g, gClass2.pi[GClass25.int_1[player.frame][1][0]].id, player.x + GClass25.int_1[player.frame][1][1] * player.dir + gClass2.pi[GClass25.int_1[player.frame][1][0]].dx * player.dir, player.y - GClass25.int_1[player.frame][1][2] + gClass2.pi[GClass25.int_1[player.frame][1][0]].dy, (player.dir != 1) ? 2 : 0, (player.dir != 1) ? 24 : 0);
			int num = GClass69.int_1 / 2 + 300;
			int num2 = GClass69.int_2 / 2 - 170;
			for (int j = 0; j < 3; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					int num3 = j * 2 + k;
					if (indexSelect == num3)
					{
						g.method_30(gclass66_6, num + 120 * k - 5, num2 + 120 * j - 5);
					}
					g.method_30(gclass66_5[num3], num + 120 * k, num2 + 120 * j);
				}
			}
			g.method_18(0, 0.3f);
			g.method_9(xScroll, yScroll, wScroll, hScroll, 10);
			GClass67.gclass67_1.method_1(g, string_1[indexSelect, 0], xScroll + wScroll / 2, yScroll + 20, 2);
			int num4 = yScroll + 30;
			for (int l = 0; l < string_0.Length; l++)
			{
				switch (l)
				{
				case 1:
				{
					GClass67.gclass67_11.method_1(g, string_0[l], xScroll + 20, num4 += 50, 0);
					int num6 = GClass67.gclass67_11.method_4(string_0[l]);
					for (int n = 0; n < 5; n++)
					{
						if (n < int_2[indexSelect, 0])
						{
							g.method_30(gclass66_3, xScroll + 20 + num6 + (gclass66_3.method_0() + 5) * n, num4 + 4);
						}
						else
						{
							g.method_30(gclass66_4, xScroll + 20 + num6 + (gclass66_3.method_0() + 5) * n, num4 + 4);
						}
					}
					break;
				}
				case 2:
				{
					GClass67.gclass67_11.method_1(g, string_0[l], xScroll + 20, num4 += 50, 0);
					int num5 = GClass67.gclass67_11.method_4(string_0[l]);
					for (int m = 0; m < 5; m++)
					{
						if (m < int_2[indexSelect, 1])
						{
							g.method_30(gclass66_3, xScroll + 20 + num5 + (gclass66_3.method_0() + 5) * m, num4 + 4);
						}
						else
						{
							g.method_30(gclass66_4, xScroll + 20 + num5 + (gclass66_3.method_0() + 5) * m, num4 + 4);
						}
					}
					break;
				}
				default:
					GClass67.gclass67_11.method_1(g, string_0[l] + string_1[indexSelect, l + 1], xScroll + 20, num4 += 50, 0);
					break;
				}
			}
			textField.vmethod_0(g);
			cmdOk.vmethod_0(g);
		}

		public override void vmethod_0()
		{
			textField.method_7();
			player.cp1++;
			if (player.cp1 > 30)
			{
				player.cp1 = 0;
			}
			if (player.cp1 % 15 < 5)
			{
				player.frame = 0;
			}
			else
			{
				player.frame = 1;
			}
		}

		public override void vmethod_7(int x, int y)
		{
			cmdOk.vmethod_3(x, y);
		}

		public override void vmethod_6(int x, int y)
		{
			int num = GClass69.int_1 / 2 + 300;
			int num2 = GClass69.int_2 / 2 - 170;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					if (x >= num + 120 * j && x <= num + 120 * j + 100 && y >= num2 + 120 * i && y <= num2 + 120 * i + 100)
					{
						indexSelect = i * 2 + j;
						player.head = int_1[indexSelect, 0];
						player.body = int_1[indexSelect, 1];
						player.leg = int_1[indexSelect, 2];
						GClass43.smethod_8();
						return;
					}
				}
			}
			cmdOk.vmethod_2(x, y);
		}

		public override void vmethod_5(int x, int y)
		{
			textField.method_3(x, y);
			cmdOk.vmethod_1(x, y);
		}

		public override void vmethod_4(KeyCode keyCode)
		{
			textField.method_4(keyCode);
		}

		public void imethod_0(int idAction, object p)
		{
			if (idAction == 1)
			{
				if (textField.method_5().Equals(string.Empty) && 0 == 0)
				{
					GClass69.smethod_16(GClass83.string_42);
					return;
				}
				if (textField.method_5().Length < 5)
				{
					GClass69.smethod_16(GClass83.string_43);
					return;
				}
				if (textField.method_5().Length > 10)
				{
					GClass69.smethod_16(GClass83.string_44);
					return;
				}
				GClass78.smethod_1();
				GClass0.smethod_1(textField.method_5(), indexSelect / 2, sex, indexSelect);
			}
		}
	}
}
