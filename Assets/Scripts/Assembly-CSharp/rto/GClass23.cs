using System;
using System.Collections.Generic;

namespace rto
{
	public class GClass23 : GClass21, GInterface0
	{
		public GClass27 template;

		public bool isDontMove;

		public int p1;

		public int p2;

		public int p3;

		public int xFirst;

		public int yFirst;

		public int dirV = 1;

		public GClass25 playerFocus;

		public int timeStatus;

		public bool injureThenDie;

		public int level;

		public int damage;

		public long lastTimeFrame;

		static GClass23()
		{
		}

		public GClass23()
		{
			h = 64;
			w = 44;
			status = 5;
		}

		public virtual void vmethod_0(GClass68 g)
		{
			if (!method_1() || 1 == 0 || status == 0)
			{
				return;
			}
			if (GClass25.gclass25_0.mobFocus != null && 0 == 0 && GClass25.gclass25_0.mobFocus.Equals(this) && 0 == 0)
			{
				try
				{
					method_0(g, x, y - GClass42.dictionary_0[template.imgs[0]].method_1() - 15);
				}
				catch
				{
				}
			}
			if (!isChocolate || 1 == 0)
			{
				GClass42.smethod_1(g, template.imgs[frame], x, y + ((template.id == 1) ? 5 : 0), (dir != 1) ? 2 : 0, GClass45.int_3);
			}
			using List<GClass9>.Enumerator enumerator = effects.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				enumerator.Current.method_0(g);
			}
		}

		public void method_0(GClass68 g, int x, int y)
		{
			int num = 90;
			int num2 = 8;
			if (level > 0)
			{
				num2 = 10;
				num = 110;
			}
			int num3 = (int)(hp * num / maxHp);
			if (num3 > num)
			{
				num3 = num;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			g.method_11(0);
			g.method_7(x - num / 2 - 2, y - (num2 - 4) - 2, num + 4, num2 + 4);
			g.method_11(16777215);
			g.method_7(x - num / 2, y - (num2 - 4), num, num2);
			g.method_11(9145227);
			g.method_7(x - num / 2, y - (num2 - 4), num3, num2);
			if (level == 1)
			{
				GClass67.gclass67_27.method_1(g, "Tinh Ranh", x, y - num2 - 20, 2);
			}
			else if (level == 2)
			{
				GClass67.gclass67_27.method_1(g, "Đầu Đàn", x, y - num2 - 20, 2);
			}
			else if (level == 3)
			{
				GClass67.gclass67_27.method_1(g, "Tà Thần", x, y - num2 - 20, 2);
			}
			else
			{
				g.method_28(GClass3.gclass66_2, x, y - num2 - 10, GClass45.int_3);
			}
		}

		public bool method_1()
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

		public void method_2(GClass68 g)
		{
			if (method_1() ? true : false)
			{
				g.method_28(Class0.gclass66_2, xSd, ySd, 3);
			}
		}

		public void method_3()
		{
			int num = 0;
			xSd = x;
			if (Class0.smethod_3(x, y) && 0 == 0)
			{
				ySd = y;
				return;
			}
			ySd = y;
			do
			{
				if (num < 30)
				{
					num++;
					ySd += Class0.sbyte_0;
					continue;
				}
				return;
			}
			while (!Class0.smethod_3(xSd, ySd));
			if (ySd % Class0.sbyte_0 != 0 && 0 == 0)
			{
				ySd -= ySd % Class0.sbyte_0;
			}
		}

		public virtual void vmethod_1()
		{
			for (int i = 0; i < effects.Count; i++)
			{
				if (effects[i].time <= 0L)
				{
					effects.RemoveAt(i);
					i--;
				}
				else
				{
					effects[i].method_3();
				}
			}
			method_3();
			switch (status)
			{
			case 1:
				isDontMove = false;
				y += p1;
				if (GClass69.int_0 % 2 == 0 || 1 == 0)
				{
					if (p2 > 1)
					{
						p2--;
					}
					else if (p2 < -1)
					{
						p2++;
					}
				}
				x += p2;
				frame = 8;
				if (isDie && 0 == 0)
				{
					isDie = false;
					p1 = 0;
					p2 = 0;
					y = 0;
					x = 0;
					status = 0;
					timeStatus = 0;
					break;
				}
				if (Class0.smethod_3(x, y) && 0 == 0)
				{
					p1 = ((p1 <= 4) ? (-p1) : (-4));
					if (p3 == 0 || 1 == 0)
					{
						p3 = 16;
					}
				}
				else
				{
					p1++;
				}
				if (p3 > 0)
				{
					p3--;
					if (p3 == 0 || 1 == 0)
					{
						isDie = true;
					}
				}
				break;
			case 2:
				if ((!isBlind || 1 == 0) && (!isChocolate || 1 == 0))
				{
					timeStatus = 0;
					method_7();
				}
				break;
			case 3:
				if ((!isBlind || 1 == 0) && (!isChocolate || 1 == 0))
				{
					method_4();
				}
				break;
			case 4:
				if ((!isBlind || 1 == 0) && (!isChocolate || 1 == 0))
				{
					timeStatus = 0;
					p1++;
					if (p1 > 40 + id % 5)
					{
						y -= 2;
						status = 5;
						p1 = 0;
					}
				}
				break;
			case 5:
				if ((!isBlind || 1 == 0) && (!isChocolate || 1 == 0))
				{
					timeStatus = 0;
					method_8();
				}
				break;
			case 6:
				timeStatus = 0;
				p1++;
				y += p1;
				if (y >= yFirst)
				{
					y = yFirst;
					p1 = 0;
					status = 5;
				}
				break;
			case 7:
				method_6();
				break;
			}
		}

		public void method_4()
		{
			frame = 7;
			if (playerFocus == null || 1 == 0)
			{
				p1 = 0;
				status = 5;
			}
			else if (p1 == 0 || 1 == 0)
			{
				if (x > xFirst + template.rangeMove)
				{
					p1 = 1;
				}
				if (x < xFirst - template.rangeMove)
				{
					p1 = 1;
				}
				if ((template.type == 4 || template.type == 5) && (!isDontMove || 1 == 0))
				{
					y += (playerFocus.y - y) / 20;
				}
				p2++;
				if (p2 > 3 || p1 == 1)
				{
					p1 = 1;
					if (p3 == 0 || 1 == 0)
					{
						if (method_1() && 0 == 0)
						{
							GClass43.smethod_36(GClass43.int_7, 0.3f);
						}
						playerFocus.method_20(damage, isCritical: false);
					}
					else
					{
						if (method_1() && 0 == 0)
						{
							GClass43.smethod_36(GClass43.int_26, 0.3f);
						}
						GClass28.smethod_0(x + dir * w / 2, y - h / 2, playerFocus, this);
					}
				}
				dir = ((x < playerFocus.x) ? 1 : (-1));
			}
			else if (p1 == 1)
			{
				if (template.type != 0 && 0 == 0 && (!isDontMove || 1 == 0))
				{
					x += (xFirst - x) / 4;
					y += (yFirst - y) / 4;
				}
				if (Math.Abs(xFirst - x) < 5 && Math.Abs(yFirst - y) < 5)
				{
					status = 2;
					p1 = 0;
					p2 = 0;
				}
			}
		}

		public void method_5()
		{
			if (status != 3)
			{
				timeStatus = 5;
				status = 7;
				if (template.type != 0 && 0 == 0 && Math.Abs(x - xFirst) < 30)
				{
					x -= 10 * dir;
				}
			}
		}

		private void method_6()
		{
			frame = 8;
			timeStatus--;
			if (timeStatus <= 0)
			{
				if ((!injureThenDie || 1 == 0) && hp > 0L)
				{
					status = 5;
					p3 = 0;
					p2 = 0;
					p1 = 0;
					timeStatus = 0;
				}
				else
				{
					status = 1;
					p2 = 0;
					p1 = -3;
					p3 = 0;
				}
			}
		}

		private void method_7()
		{
			if (GClass69.int_0 % 2 == 0 || 1 == 0)
			{
				p1++;
			}
			if (p1 > 30)
			{
				p1 = 0;
			}
			if (p1 % 15 < 5)
			{
				frame = 0;
			}
			else
			{
				frame = 1;
			}
			switch (template.type)
			{
			case 2:
				p1++;
				if (p1 > id % 3 && (playerFocus == null || false || Math.Abs(playerFocus.x - x) > 80))
				{
					status = 5;
				}
				break;
			case 0:
			case 1:
				p1++;
				if (p1 > 10 + id % 10 && (playerFocus == null || false || Math.Abs(playerFocus.x - x) > 80))
				{
					status = 5;
				}
				break;
			}
			if (playerFocus != null && 0 == 0 && (GClass69.int_0 % (10 + p1 % 20) == 0 || 1 == 0))
			{
				if (playerFocus.x > x)
				{
					dir = 1;
				}
				else
				{
					dir = -1;
				}
			}
		}

		public void method_8()
		{
			try
			{
				switch (template.type)
				{
				case 0:
					if (GClass84.smethod_1() - lastTimeFrame > 40L)
					{
						lastTimeFrame = GClass84.smethod_1();
						p1++;
					}
					if (p1 > 30)
					{
						p1 = 0;
					}
					if (p1 % 15 < 5)
					{
						frame = 0;
					}
					else
					{
						frame = 1;
					}
					break;
				case 1:
					if (GClass69.int_0 % 2 == 1)
					{
						break;
					}
					x += template.speed * dir;
					if (Math.Abs(x - GClass25.gclass25_0.x) < 40)
					{
						dir = ((x <= GClass25.gclass25_0.x) ? 1 : (-1));
						if (Math.Abs(x - GClass25.gclass25_0.x) < 20)
						{
							x -= dir * 10;
						}
						status = 2;
					}
					else if (x > xFirst + template.rangeMove)
					{
						dir = -1;
					}
					else if (x < xFirst - template.rangeMove)
					{
						dir = 1;
					}
					if (GClass84.smethod_1() - lastTimeFrame > 40L)
					{
						lastTimeFrame = GClass84.smethod_1();
						p1++;
					}
					if (p1 >= 10)
					{
						p1 = 0;
					}
					frame = (p1 >> 1) + 2;
					break;
				case 2:
					x += template.speed * dir;
					if (GClass69.int_0 % 10 > 2)
					{
						y += template.speed * dirV;
					}
					if (x > xFirst + template.rangeMove)
					{
						dir = -1;
						status = 2;
						p1 = 0;
					}
					else if (x < xFirst - template.rangeMove)
					{
						dir = 1;
						status = 2;
						p1 = 0;
					}
					if (y > yFirst + template.rangeMove / 2)
					{
						dirV = -1;
					}
					else if (y < yFirst - template.rangeMove / 2)
					{
						dirV = 1;
					}
					if (GClass84.smethod_1() - lastTimeFrame > 40L)
					{
						lastTimeFrame = GClass84.smethod_1();
						p1++;
					}
					if (p1 >= 10)
					{
						p1 = 0;
					}
					frame = (p1 >> 1) + 2;
					break;
				}
			}
			catch
			{
			}
		}

		public void method_9(GClass25 player)
		{
			playerFocus = player;
			p1 = 0;
			p2 = 0;
			status = 3;
			dir = ((player.x > x) ? 1 : (-1));
			int num = player.x;
			int num2 = player.y;
			if (Math.Abs(num - x) < w * 2 / 3 && num2 >= y - h - 10 && num2 <= y + 10)
			{
				if (x < num)
				{
					x = num - w;
				}
				else
				{
					x = num + w;
				}
				p3 = 0;
			}
			else
			{
				p3 = 1;
			}
		}

		public void method_10()
		{
			hp = 0L;
			injureThenDie = true;
			status = 1;
			p1 = -3;
			p2 = -dir;
			p3 = 0;
		}

		public int imethod_3()
		{
			return h;
		}

		public int imethod_2()
		{
			return w;
		}

		public int imethod_0()
		{
			return x;
		}

		public int imethod_1()
		{
			return y;
		}

		public int imethod_4()
		{
			return dir;
		}

		bool GInterface0.imethod_5()
		{
			if (!isDie || 1 == 0)
			{
				return hp <= 0L;
			}
			return true;
		}

		public List<GClass9> imethod_6()
		{
			return effects;
		}

		public void imethod_7(bool isBlind)
		{
			base.isBlind = isBlind;
		}

		public void imethod_8(bool isChocolate)
		{
			base.isChocolate = isChocolate;
		}

		bool GInterface0.imethod_9()
		{
			return isChocolate;
		}
	}
}
