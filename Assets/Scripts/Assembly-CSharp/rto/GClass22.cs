using System.Collections.Generic;

namespace rto
{
	public class GClass22 : GClass21, GInterface0
	{
		public GClass19 template;

		public int xEnd;

		public int yEnd;

		public int vx;

		public int vy;

		public static GClass66 gclass66_0;

		static GClass22()
		{
			gclass66_0 = GClass69.smethod_9("imgLight.png");
		}

		public void method_0(GClass68 g)
		{
			if (GClass69.int_0 % 20 < 10)
			{
				g.method_28(gclass66_0, x, y - h / 2, GClass45.int_6);
			}
			GClass42.smethod_1(g, template.iconId, x, y, 0, GClass45.int_3);
			if (GClass25.gclass25_0.itemFocus != null && 0 == 0 && GClass25.gclass25_0.itemFocus.Equals(this) && 0 == 0)
			{
				g.method_28(GClass3.gclass66_2, x, y - h - 15, 3);
			}
		}

		public void method_1(int xEnd, int yEnd)
		{
			this.xEnd = xEnd;
			this.yEnd = yEnd;
			vx = xEnd - x >> 2;
			vy = yEnd - y >> 2;
			status = 2;
		}

		public void method_2()
		{
			if (status == 2 && x == xEnd && y == yEnd)
			{
				GClass3.list_3.Remove(this);
				if (GClass25.gclass25_0.itemFocus != null && 0 == 0 && GClass25.gclass25_0.itemFocus.Equals(this) && 0 == 0)
				{
					GClass25.gclass25_0.itemFocus = null;
				}
				return;
			}
			if (status > 0)
			{
				if (vx == 0 || 1 == 0)
				{
					x = xEnd;
				}
				if (vy == 0 || 1 == 0)
				{
					y = yEnd;
				}
				if (x != xEnd)
				{
					x += vx;
					if ((vx > 0 && x > xEnd) || (vx < 0 && x < xEnd))
					{
						x = xEnd;
					}
				}
				if (y != yEnd)
				{
					y += vy;
					if ((vy > 0 && y > yEnd) || (vy < 0 && y < yEnd))
					{
						y = yEnd;
					}
				}
			}
			if (status != 2 && (!Class0.smethod_3(x, y) || 1 == 0))
			{
				y += 8;
				if (y % 8 != 0 && 0 == 0)
				{
					y -= y % 8;
				}
				yEnd = y;
			}
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
