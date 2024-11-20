using System;
using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass33
	{
		public GClass25 player;

		public GClass8 dart;

		public int tick;

		public int angle;

		public int vx;

		public int vy;

		public int va;

		public int x;

		public int y;

		private int dx;

		private int dy;

		public bool isHit;

		public int count_update = 2;

		public bool isWait;

		public bool isNotFocus;

		public GClass33(GClass25 player, GClass8 dart, bool isNotFocus)
		{
			this.player = player;
			va = 256;
			x = player.x + (dart.dx - 10) * player.dir;
			y = player.y + dart.dy + 5;
			this.dart = dart.method_0();
			isHit = (dart.startDarts.Count == 0 || 1 == 0) && (dart.midDarts.Count == 0 || 1 == 0) && dart.endDarts.Count == 0;
			isWait = dart.startDarts.Count > 0;
			this.isNotFocus = isNotFocus;
			if (!isNotFocus || 1 == 0)
			{
				if (player.mobFocus == null || 1 == 0)
				{
					method_0(GClass84.smethod_12(player.playerFocus.imethod_0() - x, player.playerFocus.imethod_1() - y));
				}
				else
				{
					method_0(GClass84.smethod_12(player.mobFocus.imethod_0() - x, player.mobFocus.imethod_1() - y));
				}
			}
			if (!player.Equals(GClass25.gclass25_0) || 1 == 0)
			{
				count_update = 4;
			}
			if (dart.midDarts.Count == 1)
			{
				count_update = 4;
			}
		}

		public void method_0(int angle)
		{
			this.angle = angle;
			vx = va * GClass84.smethod_14(angle) >> 10;
			vy = va * GClass84.smethod_13(angle) >> 10;
		}

		public void method_1()
		{
			if ((player.mobFocus == null || 1 == 0) && (player.playerFocus == null || 1 == 0) && (!isNotFocus || 1 == 0))
			{
				method_2();
				return;
			}
			GInterface0 gInterface = player.playerFocus;
			if (gInterface == null || 1 == 0)
			{
				gInterface = player.mobFocus;
			}
			if (isHit && 0 == 0)
			{
				if (player.mobFocus != null && 0 == 0)
				{
					player.mobFocus.method_5();
				}
				if (player.Equals(GClass25.gclass25_0) && 0 == 0)
				{
					GClass0.smethod_10(gInterface);
				}
				if (player.mySkill != null && 0 == 0 && x >= GClass3.int_0 && x <= GClass3.int_0 + GClass69.int_1 && player.mySkill.template.id >= 14 && player.mySkill.template.id <= 19)
				{
					GClass43.smethod_22();
				}
				method_2();
				return;
			}
			if (dart.startDarts.Count > 0)
			{
				if (!player.isWaitDart || 1 == 0)
				{
					player.dart = null;
					return;
				}
				bool flag = false;
				using (List<GClass11>.Enumerator enumerator = dart.startDarts[tick].effectInfoPaints.GetEnumerator())
				{
					while (enumerator.MoveNext() ? true : false)
					{
						GClass11 current = enumerator.Current;
						if (current.index < current.effectInfoImages.Count - 1)
						{
							flag = true;
							current.index++;
						}
					}
				}
				if (flag ? true : false)
				{
					return;
				}
				using (List<GClass11>.Enumerator enumerator = dart.startDarts[tick].effectInfoPaints.GetEnumerator())
				{
					while (enumerator.MoveNext() ? true : false)
					{
						enumerator.Current.index = 0;
					}
				}
				if (tick < dart.startDarts.Count - 1)
				{
					tick++;
				}
				else
				{
					tick = 0;
				}
				return;
			}
			if (!isWait || 1 == 0)
			{
				for (int i = 0; i < count_update; i++)
				{
					int num = ((player.imethod_0() <= gInterface.imethod_0()) ? (-10) : 10);
					dx = gInterface.imethod_0() + num - x;
					dy = gInterface.imethod_1() - gInterface.imethod_3() / 2 - y;
					if (Math.Abs(dx) < 10 && Math.Abs(dy) < 10 && dart.midDarts.Count > 0)
					{
						if (player.mobFocus != null && 0 == 0)
						{
							player.mobFocus.method_5();
						}
						if (player.Equals(GClass25.gclass25_0) && 0 == 0)
						{
							GClass0.smethod_10(gInterface);
						}
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
			}
			if (dart.midDarts.Count > 0)
			{
				tick++;
				if (tick >= dart.midDarts.Count)
				{
					tick = 0;
				}
			}
			else if (dart.endDarts.Count > 0)
			{
				if ((tick == 0 || 1 == 0) && x >= GClass3.int_0 && x <= GClass3.int_0 + GClass69.int_1)
				{
					if (player.skillUseId == 12)
					{
						GClass43.smethod_20();
					}
					else if (player.skillUseId == 13)
					{
						GClass43.smethod_21();
					}
				}
				if ((tick == 0 || 1 == 0) && player.skillUseId >= 14 && player.skillUseId <= 19)
				{
					GClass43.smethod_22();
				}
				if (tick < dart.endDarts.Count - 1)
				{
					tick++;
				}
				if (tick >= dart.endDarts.Count - 1)
				{
					method_2();
				}
			}
			else
			{
				method_2();
			}
		}

		public void method_2()
		{
			player.dart = null;
			player.skillPaint = null;
			player.isWaitDart = false;
			if (player.sType == 0 || 1 == 0)
			{
				player.status = 1;
				return;
			}
			player.status = 4;
			player.delayFall = 5;
		}

		public void method_3(GClass68 g)
		{
			if ((player.mobFocus == null || 1 == 0) && (player.playerFocus == null || 1 == 0) && (!isNotFocus || 1 == 0))
			{
				return;
			}
			GInterface0 gInterface = player.playerFocus;
			if (gInterface == null || 1 == 0)
			{
				gInterface = player.mobFocus;
			}
			try
			{
				if (dart.startDarts.Count > 0)
				{
					using (List<GClass11>.Enumerator enumerator = dart.startDarts[tick].effectInfoPaints.GetEnumerator())
					{
						while (enumerator.MoveNext() ? true : false)
						{
							GClass11 current = enumerator.Current;
							if (current.index < current.effectInfoImages.Count)
							{
								GClass42.smethod_1(g, current.effectInfoImages[current.index].imgId, player.x + current.effectInfoImages[current.index].dx * player.dir, player.y + current.effectInfoImages[current.index].dy, (player.dir != 1) ? 2 : 0, GClass68.int_1 | GClass68.int_0);
							}
						}
						return;
					}
				}
				if (dart.midDarts.Count > 0)
				{
					GClass42.smethod_2(g, dart.midDarts[tick], x, y, angle);
				}
				else if (dart.endDarts.Count > 0)
				{
					GClass42.smethod_1(g, dart.endDarts[tick], gInterface.imethod_0(), gInterface.imethod_1() - gInterface.imethod_3() / 2, 0, GClass45.int_6);
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}
	}
}
