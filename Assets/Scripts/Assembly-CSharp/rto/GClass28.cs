using System;
using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass28
	{
		public int x;

		public int y;

		public int angle;

		public int vx;

		public int vy;

		public int va;

		public GClass25 playerFocus;

		public int tick;

		public GClass8 dart;

		private int dx;

		private int dy;

		public int damage;

		public static List<GClass28> list_0 = new List<GClass28>();

		public GClass28()
		{
		}

		public GClass28(int x, int y, GClass25 p, GClass23 mob)
		{
			this.x = x;
			this.y = y;
			va = 10;
			playerFocus = p;
			method_0(GClass84.smethod_12(playerFocus.x - x, playerFocus.y - y));
			dart = mob.template.dart.method_0();
			damage = mob.damage;
		}

		public void method_0(int angle)
		{
			this.angle = angle;
			vx = va * GClass84.smethod_14(angle) >> 10;
			vy = va * GClass84.smethod_13(angle) >> 10;
		}

		public static void smethod_0(int x, int y, GClass25 p, GClass23 mob)
		{
			list_0.Add(new GClass28(x, y, p, mob));
		}

		public void method_1(GClass68 g)
		{
			try
			{
				if (dart.startDarts.Count <= 0)
				{
					if (dart.midDarts.Count > 0)
					{
						GClass42.smethod_2(g, dart.midDarts[tick], x, y, angle);
					}
					else if (dart.endDarts.Count > 0)
					{
						GClass42.smethod_1(g, dart.endDarts[tick], playerFocus.imethod_0(), playerFocus.imethod_1(), 0, GClass45.int_3);
					}
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		public void method_2()
		{
			for (int i = 0; i < 3; i++)
			{
				int num = ((x <= playerFocus.x) ? (-10) : 10);
				dx = playerFocus.imethod_0() + num - x;
				dy = playerFocus.imethod_1() - playerFocus.imethod_3() / 2 - y;
				if (Math.Abs(dx) < 10 && Math.Abs(dy) < 10 && dart.midDarts.Count > 0)
				{
					playerFocus.method_20(damage, isCritical: false);
					dart.midDarts.Clear();
					tick = 0;
				}
				angle = GClass84.smethod_12(dx, dy);
				if (va < 8192)
				{
					va += 1024;
				}
				vx = va * GClass84.smethod_14(angle) >> 10;
				vy = va * GClass84.smethod_13(angle) >> 10;
				dx += vx;
				x += dx >> 10;
				dx &= 1023;
				dy += vy;
				y += dy >> 10;
				dy &= 1023;
			}
			if (dart.startDarts.Count > 0)
			{
				tick++;
				if (dart.startDarts.Count > 0 && tick >= dart.startDarts.Count)
				{
					dart.startDarts.Clear();
					tick = 0;
				}
			}
			else if (dart.midDarts.Count > 0)
			{
				tick++;
				if (tick >= dart.midDarts.Count)
				{
					tick = 0;
				}
			}
			else if (dart.endDarts.Count > 0)
			{
				if (tick < dart.endDarts.Count - 1)
				{
					tick++;
				}
				if (tick >= dart.endDarts.Count - 1)
				{
					method_3();
				}
			}
			else
			{
				method_3();
			}
		}

		private void method_3()
		{
			list_0.Remove(this);
		}
	}
}
