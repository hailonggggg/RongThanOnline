using System;
using UnityEngine;

namespace rto
{
	public class GClass73 : GClass72
	{
		public GClass25 playerInfo;

		public bool isOnline = true;

		public string name;

		public string description;

		public int id;

		public int numPlayer;

		public int maxPlayer;

		public int numTeam;

		public DateTime createDate;

		public int sayWidth;

		public string[] says;

		public bool isNew;

		public GClass73()
		{
			isShow = true;
		}

		public GClass73(GInterface1 actionListener, int action, object p)
		{
			idAction = action;
			base.actionListener = actionListener;
			_object = p;
			isShow = true;
		}

		public GClass73(GInterface1 actionListener, int action, GClass25 player, string info)
		{
			playerInfo = player;
			description = info;
			createDate = DateTime.Now;
			sayWidth = 350;
			says = GClass67.gclass67_5.method_3(info, sayWidth);
			w = sayWidth + 20;
			h = (says.Length + ((GClass25.gclass25_0.id != player.id) ? 1 : 0)) * (GClass67.gclass67_5.method_7() + 5) + 15;
			if (says.Length == 1 && GClass25.gclass25_0.id == player.id)
			{
				w = GClass67.gclass67_5.method_4(says[0]) + 20;
			}
			if (says.Length == 1 && GClass25.gclass25_0.id != player.id)
			{
				w = GClass67.gclass67_5.method_4(says[0]) + 20;
				int num = GClass67.gclass67_5.method_4(player.name) + 20;
				if (w < num)
				{
					w = num;
				}
			}
			_object = null;
			base.actionListener = actionListener;
			idAction = action;
			isShow = true;
		}

		public override void vmethod_0(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			g.method_5(x + 2, y + 2, w - 4, h - 4);
			if (playerInfo != null && 0 == 0)
			{
				g.method_28(GClass3.gclass66_27[(playerInfo.classId == -1) ? 5 : playerInfo.classId], x + 2, y + 2, 0);
				if (isOnline && 0 == 0)
				{
					GClass67.gclass67_7.method_1(g, playerInfo.name, x + 90, y + 8, 0);
				}
				else
				{
					GClass67.gclass67_18.method_1(g, playerInfo.name, x + 90, y + 8, 0);
				}
				GClass67.gclass67_5.method_1(g, "Lv" + GClass25.smethod_6(playerInfo.power) + ": " + GClass84.smethod_7(playerInfo.power) + " sm", x + 90, y + 43, 0);
			}
			g.method_31();
		}

		public void method_1(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			if (numPlayer < 10)
			{
				g.method_12(264f, 181f, 115f);
			}
			else
			{
				g.method_12(246f, 89f, 68f);
			}
			g.method_9(x + 2, y + 2, 75, 75, 6);
			GClass67.gclass67_0.method_1(g, id.ToString(), x + 39, y + 23, 2);
			GClass67.gclass67_5.method_1(g, "Dân số: " + numPlayer + "/" + maxPlayer, x + 90, y + 8, 0);
			GClass67.gclass67_9.method_1(g, "Tổ đội: " + numTeam, x + 90, y + 40, 0);
		}

		public void method_2(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			g.method_12(264f, 181f, 115f);
			g.method_9(x + 2, y + 2, 75, 75, 6);
			GClass67.gclass67_7.method_1(g, name, x + 90, y + 8, 0);
			GClass67.gclass67_5.method_1(g, description, x + 90, y + 43, 0);
		}

		public void method_3(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			g.method_30(image, x + 10, y + 10);
			GClass67.gclass67_7.method_1(g, name, x + 90, y + 13, 0);
			GClass67.gclass67_5.method_1(g, description, x + 90, y + 48, 0);
		}

		public void method_4(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			g.method_12(264f, 181f, 115f);
			g.method_9(x + 2, y + 2, 75, 75, 6);
			if (playerInfo != null && 0 == 0)
			{
				g.method_28(GClass3.gclass66_27[(playerInfo.classId == -1) ? 5 : playerInfo.classId], x + 2, y + 2, 0);
				if (isOnline && 0 == 0)
				{
					GClass67.gclass67_7.method_1(g, playerInfo.name, x + 90, y + 8, 0);
				}
				else
				{
					GClass67.gclass67_18.method_1(g, playerInfo.name, x + 90, y + 8, 0);
				}
				GClass67.gclass67_5.method_1(g, "Lv" + GClass25.smethod_6(playerInfo.power) + ": " + GClass84.smethod_7(playerInfo.power) + " sm", x + 90, y + 43, 0);
			}
		}

		public void method_5(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			GClass67.gclass67_7.method_1(g, name, x + 20, y + 8, 0);
			GClass67.gclass67_5.method_1(g, description, x + 20, y + 43, 0);
		}

		public void method_6(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			g.method_12(264f, 181f, 115f);
			g.method_9(x + 2, y + 2, 75, 75, 6);
			if (playerInfo != null && 0 == 0)
			{
				g.method_28(GClass3.gclass66_27[(playerInfo.classId == -1) ? 5 : playerInfo.classId], x + 2, y + 2, 0);
				GClass67.gclass67_7.method_1(g, "Top" + (id + 1) + ": " + playerInfo.name, x + 90, y + 8, 0);
				GClass67.gclass67_5.method_1(g, "Lv" + GClass25.smethod_6(playerInfo.power) + ": " + GClass84.smethod_7(playerInfo.power) + " sm", x + 90, y + 43, 0);
			}
		}

		public void method_7(GClass68 g)
		{
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				g.method_14(Color.green);
				g.method_9(x - 3, y - 3, w + 6, h + 6, 11);
			}
			g.method_12(230f, 138f, 49f);
			g.method_9(x, y, w, h, 8);
			g.method_11(16777215);
			g.method_9(x + 2, y + 2, w - 4, h - 4, 6);
			g.method_12(264f, 181f, 115f);
			g.method_9(x + 2, y + 2, 75, 75, 6);
			if (playerInfo != null && 0 == 0)
			{
				g.method_28(GClass3.gclass66_27[(playerInfo.classId == -1) ? 5 : playerInfo.classId], x + 2, y + 2, 0);
				if (isOnline && 0 == 0)
				{
					GClass67.gclass67_7.method_1(g, name, x + 90, y + 8, 0);
				}
				else
				{
					GClass67.gclass67_18.method_1(g, name, x + 90, y + 8, 0);
				}
				GClass67.gclass67_5.method_1(g, description, x + 90, y + 43, 0);
			}
		}

		public void method_8(GClass68 g)
		{
			if (playerInfo == null || 1 == 0)
			{
				return;
			}
			int num = x;
			int num2 = y;
			if (GClass25.gclass25_0.id != playerInfo.id)
			{
				num = x + 55;
				g.method_30(GClass3.gclass66_28[(playerInfo.classId == -1) ? 5 : playerInfo.classId], x, y);
				g.method_18(0, 0.5f);
				g.method_9(num, num2, w, h, 10);
				g.method_11(16777215);
				g.method_9(num + 1, num2 + 1, w - 2, h - 2, 9);
				GClass67.gclass67_7.method_1(g, playerInfo.name, num + 10, num2 + 10, 0);
				for (int i = 0; i < says.Length; i++)
				{
					GClass67.gclass67_5.method_1(g, says[i], num + 10, num2 + 45 + (GClass67.gclass67_5.method_7() + 5) * i, 0);
				}
				GClass67.gclass67_28.method_1(g, createDate.ToString("HH:mm"), num + w + 5, y, 0);
			}
			else
			{
				g.method_18(0, 0.5f);
				g.method_9(num, num2, w, h, 10);
				g.method_11(16777215);
				g.method_9(num + 1, num2 + 1, w - 2, h - 2, 9);
				for (int j = 0; j < says.Length; j++)
				{
					GClass67.gclass67_5.method_1(g, says[j], num + 10, num2 + 10 + (GClass67.gclass67_5.method_7() + 5) * j, 0);
				}
				GClass67.gclass67_28.method_1(g, createDate.ToString("HH:mm"), num - 5, y, 1);
			}
		}

		public void method_9(GClass68 g, bool isFocus)
		{
			if ((playerInfo != null) ? true : false)
			{
				if (isFocus && 0 == 0)
				{
					isNew = false;
					GClass67.gclass67_7.method_1(g, playerInfo.name, x + w / 2, y + (h - GClass67.gclass67_7.method_7()) / 2 - 1, 2);
				}
				else if (isNew && 0 == 0 && GClass69.int_0 % 30 > 15)
				{
					GClass67.gclass67_6.method_1(g, playerInfo.name, x + w / 2, y + (h - GClass67.gclass67_7.method_7()) / 2 - 1, 2);
				}
				else
				{
					GClass67.gclass67_5.method_1(g, playerInfo.name, x + w / 2, y + (h - GClass67.gclass67_7.method_7()) / 2 - 1, 2);
				}
				g.method_12(230f, 138f, 49f);
				g.method_7(x + 20, y + h - 2, w - 40, 2);
			}
		}
	}
}
