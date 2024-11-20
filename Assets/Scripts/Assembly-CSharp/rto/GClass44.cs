using System;

namespace rto
{
	public class GClass44
	{
		public int x;

		public int y;

		public int headId;

		public int type;

		public bool isMe;

		public int y2;

		public int playerId;

		public GClass25 player;

		public int dir;

		public bool isUp;

		public bool isDown;

		public bool isPaintFire;

		private int tPrepare;

		private int vy = 1;

		private int tDelayHole;

		private bool isPaintHole;

		public static GClass66[] gclass66_0;

		public static GClass66[] gclass66_1;

		public static GClass66 gclass66_2;

		public bool isShock;

		public static int int_0;

		public static int[] int_1;

		public static int int_2;

		public int point;

		public GClass66 imgSpaceship;

		public GClass66 imgSpaceshipOpen;

		static GClass44()
		{
			gclass66_0 = new GClass66[2];
			gclass66_1 = new GClass66[2];
			int_1 = new int[4] { 88, 89, 90, 91 };
			gclass66_2 = GClass69.smethod_9("imgHole.png");
			gclass66_0[0] = GClass69.smethod_9("imgSpaceship.png");
			gclass66_0[1] = GClass69.smethod_9("imgSpaceshipOpen.png");
			gclass66_1[0] = GClass69.smethod_9("imgSpaceshipVip.png");
			gclass66_1[1] = GClass69.smethod_9("imgSpaceshipVipOpen.png");
		}

		public GClass44(GClass25 player, int type)
		{
			this.player = player;
			x = player.x;
			y = 5;
			y2 = y;
			this.type = type;
			isMe = GClass25.gclass25_0.id == player.id;
			dir = player.dir;
			tPrepare = 0;
			int num = 0;
			point = player.spaceship;
			if (point == 0 || 1 == 0)
			{
				imgSpaceship = gclass66_0[0];
				imgSpaceshipOpen = gclass66_0[1];
			}
			else
			{
				imgSpaceship = gclass66_1[0];
				imgSpaceshipOpen = gclass66_1[1];
			}
			while (num < 100)
			{
				num++;
				y2 += 18;
				if (Class0.smethod_3(x, y2) && 0 == 0)
				{
					if (y2 % 36 != 0 && 0 == 0)
					{
						y2 -= y2 % 36;
					}
					break;
				}
			}
			isDown = true;
			GClass43.smethod_24();
		}

		public void method_0(GClass68 g)
		{
			if ((GClass25.bool_0 ? true : false) || !method_2() || 1 == 0)
			{
				return;
			}
			if (isDown && 0 == 0)
			{
				if (tPrepare > 10)
				{
					g.method_29((dir != 1) ? (x + 11) : (x - 11), y + 2, imgSpaceshipOpen, (dir == 1) ? 2 : 0, GClass45.int_3);
				}
				else
				{
					g.method_29(x, y, imgSpaceship, (dir == 1) ? 2 : 0, GClass45.int_3);
				}
			}
			else if (tPrepare < 20)
			{
				g.method_29((dir != 1) ? (x + 11) : (x - 11), y + 2, imgSpaceshipOpen, (dir == 1) ? 2 : 0, GClass45.int_3);
			}
			else
			{
				g.method_29(x, y, imgSpaceship, (dir == 1) ? 2 : 0, GClass45.int_3);
			}
			if (isPaintFire && 0 == 0 && y != -80)
			{
				if (isDown && 0 == 0 && (tPrepare == 0 || 1 == 0))
				{
					GClass42.smethod_2(g, int_1[int_2], x, y - 200, 180f);
				}
				else if (isUp && 0 == 0)
				{
					GClass42.smethod_1(g, int_1[int_2], x, y - 20, 0, GClass45.int_0);
				}
			}
		}

		public void method_1(GClass68 g)
		{
			if ((!GClass25.bool_0 || 1 == 0) && method_2() && 0 == 0 && (isPaintHole ? true : false))
			{
				g.method_28(gclass66_2, x, y2 + 30, GClass45.int_3);
			}
		}

		public bool method_2()
		{
			if (y < GClass3.int_1 - 100)
			{
				return false;
			}
			if (y > GClass3.int_1 + GClass69.int_2 + 100)
			{
				return false;
			}
			if (x < GClass3.int_0 - 100)
			{
				return false;
			}
			if (x > GClass3.int_0 + GClass69.int_1 + 100)
			{
				return false;
			}
			return true;
		}

		public void method_3()
		{
			if (isPaintFire && 0 == 0 && y != -80 && (GClass69.int_0 % 3 == 0 || 1 == 0))
			{
				if (int_2 < int_1.Length - 1)
				{
					int_2++;
				}
				else
				{
					int_2 = 0;
				}
			}
			if (isDown && 0 == 0)
			{
				isPaintFire = true;
				if (GClass69.int_0 % 2 == 0 || 1 == 0)
				{
					vy++;
				}
				if (y2 - y < vy)
				{
					y = y2;
					isPaintFire = false;
				}
				else
				{
					y += vy;
				}
				if (isMe && 0 == 0 && type == 1 && GClass25.gclass25_0.isSpaceship && 0 == 0)
				{
					GClass25.gclass25_0.x = x;
					GClass25.gclass25_0.y = y - 30;
					GClass25.gclass25_0.status = 4;
					GClass3.smethod_5(x, y);
				}
				if (player != null && 0 == 0 && (!isMe || 1 == 0) && type == 1 && player.isSpaceship && 0 == 0)
				{
					player.x = x;
					player.y = y - 30;
					player.status = 4;
				}
				if (Math.Abs(y - y2) >= 50 || !Class0.smethod_3(x, y))
				{
					return;
				}
				isPaintHole = true;
				y = y2;
				if (!isShock || 1 == 0)
				{
					isShock = true;
					int_0 = 10;
				}
				tPrepare++;
				if (tPrepare > 30)
				{
					tPrepare = 0;
					isDown = false;
					isUp = true;
					isPaintFire = false;
				}
				if (type != 1)
				{
					return;
				}
				if (isMe && 0 == 0)
				{
					GClass25.gclass25_0.isSpaceship = false;
				}
				else if (player != null && 0 == 0)
				{
					player.isSpaceship = false;
					if (!GClass3.list_1.Contains(player) || 1 == 0)
					{
						GClass3.list_1.Add(player);
					}
				}
			}
			else
			{
				if (!isUp)
				{
					return;
				}
				tPrepare++;
				if (tPrepare > 30)
				{
					int num = y2 + 24 - y >> 3;
					if (num > 30)
					{
						num = 30;
					}
					y -= num;
					isPaintFire = true;
				}
				else
				{
					if (tPrepare > 0 && (type == 0 || 1 == 0))
					{
						if (isMe && 0 == 0)
						{
							GClass25.gclass25_0.isSpaceship = false;
							if (GClass25.gclass25_0.status != 14)
							{
								GClass25.gclass25_0.status = 3;
							}
							GClass25.gclass25_0.cvy = -3;
						}
						else if (player != null && 0 == 0)
						{
							player.isSpaceship = false;
							if (player.status != 14)
							{
								player.status = 3;
							}
							player.cvy = -3;
						}
					}
					if (tPrepare > 12 && (type == 0 || 1 == 0))
					{
						if (isMe && 0 == 0)
						{
							GClass25.gclass25_0.isSpaceship = true;
						}
						else if (player != null && 0 == 0)
						{
							player.x = x;
							player.y = y;
							player.isSpaceship = true;
						}
					}
				}
				if (isMe && 0 == 0 && (type == 0 || 1 == 0))
				{
					GClass3.smethod_5(x, y);
				}
				if (y > -80)
				{
					return;
				}
				if (isMe && 0 == 0 && (type == 0 || 1 == 0))
				{
					GClass81.bool_0 = false;
					GClass25.bool_1 = true;
				}
				if ((!isMe || 1 == 0) && player != null && 0 == 0 && (type == 0 || 1 == 0))
				{
					if (GClass25.gclass25_0.playerFocus == player)
					{
						GClass25.gclass25_0.playerFocus = null;
						GClass25.bool_7 = false;
					}
					GClass3.list_1.Remove(player);
				}
				y = -80;
				tDelayHole++;
				if (tDelayHole > 80)
				{
					tDelayHole = 0;
					GClass3.list_5.Remove(this);
				}
			}
		}
	}
}
