using System;

namespace rto
{
	public class GClass15
	{
		public string info;

		public GClass67 f;

		public int speed;

		public GClass25 playerInfo;

		public bool isOnline;

		public int id;

		public DateTime createDate;

		public int x;

		public int y;

		public int w;

		public int h;

		public int sayWidth;

		public string[] says;

		public int xChat;

		public int yChat;

		public bool isMe;

		public GClass15()
		{
		}

		public GClass15(GClass25 player, string info)
		{
			playerInfo = player;
			isMe = GClass25.gclass25_0.id == player.id;
			this.info = info;
			createDate = DateTime.Now;
			sayWidth = 350;
			says = GClass67.gclass67_5.method_3(info, sayWidth);
			w = sayWidth + 20;
			h = (says.Length + ((!isMe || 1 == 0) ? 1 : 0)) * (GClass67.gclass67_5.method_7() + 5) + 15;
			if (says.Length == 1 && isMe && 0 == 0)
			{
				w = GClass67.gclass67_5.method_4(says[0]) + 20;
			}
			if (says.Length == 1 && (!isMe || 1 == 0))
			{
				w = GClass67.gclass67_5.method_4(says[0]) + 20;
				int num = GClass67.gclass67_5.method_4(player.name) + 20;
				if (w < num)
				{
					w = num;
				}
			}
		}

		public GClass15(string s, GClass67 f, int speed)
		{
			this.f = f;
			info = s;
			this.speed = speed;
		}

		public void method_0(GClass68 g)
		{
			if (playerInfo == null || 1 == 0)
			{
				return;
			}
			if (!isMe || 1 == 0)
			{
				xChat = x + 55;
				yChat = y;
				g.method_12(264f, 181f, 115f);
				g.method_9(x, y, 50, 50, 3);
				if (playerInfo.classId == -1)
				{
					g.method_30(GClass3.gclass66_28[5], x, y);
				}
				else
				{
					g.method_30(GClass3.gclass66_28[playerInfo.classId], x, y);
				}
				g.method_18(0, 0.5f);
				g.method_9(xChat, yChat, w, h, 10);
				g.method_11(16777215);
				g.method_9(xChat + 1, yChat + 1, w - 2, h - 2, 9);
				GClass67.gclass67_7.method_1(g, playerInfo.name, xChat + 10, yChat + 10, 0);
				for (int i = 0; i < says.Length; i++)
				{
					GClass67.gclass67_5.method_1(g, says[i], xChat + 10, yChat + 45 + (GClass67.gclass67_5.method_7() + 5) * i, 0);
				}
				GClass67.gclass67_28.method_1(g, createDate.ToString("HH:mm"), xChat + w + 5, y, 0);
			}
			else
			{
				xChat = x;
				yChat = y;
				g.method_18(0, 0.5f);
				g.method_9(xChat, yChat, w, h, 10);
				g.method_11(16777215);
				g.method_9(xChat + 1, yChat + 1, w - 2, h - 2, 9);
				for (int j = 0; j < says.Length; j++)
				{
					GClass67.gclass67_5.method_1(g, says[j], xChat + 10, yChat + 10 + (GClass67.gclass67_5.method_7() + 5) * j, 0);
				}
				GClass67.gclass67_28.method_1(g, createDate.ToString("HH:mm"), xChat - 5, y, 1);
			}
		}
	}
}
