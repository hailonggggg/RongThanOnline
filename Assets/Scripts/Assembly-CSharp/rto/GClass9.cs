using System;
using System.Collections.Generic;

namespace rto
{
	public class GClass9
	{
		public int templateId;

		public List<int> imgIds;

		public GInterface0 mapObject;

		public long time;

		public int tick;

		public int type;

		public DateTime timeEnd;

		public int loopCount;

		public int dx;

		public int dy;

		public int anchor;

		public int x;

		public int y;

		public int iconId;

		public GClass9()
		{
		}

		public GClass9(GInterface0 mapObject, int loopCount, int dx, int dy, int anchor, params int[] imgs)
		{
			this.mapObject = mapObject;
			this.loopCount = loopCount;
			this.dx = dx;
			this.dy = dy;
			this.anchor = anchor;
			imgIds = new List<int>(imgs);
			time = 1L;
			x = mapObject.imethod_0();
			y = mapObject.imethod_1();
		}

		public GClass9(GInterface0 mapObject)
		{
			this.mapObject = mapObject;
			anchor = GClass45.int_3;
			loopCount = 0;
		}

		public void method_0(GClass68 g)
		{
			if (imgIds.Count == 0 || false || time <= 0L)
			{
				return;
			}
			if (loopCount == 0 || 1 == 0)
			{
				x = mapObject.imethod_0();
				y = mapObject.imethod_1();
				int num = templateId;
				if (num != 0 && 0 == 0)
				{
					if (num == 1)
					{
						dy = -10;
					}
				}
				else
				{
					dy = mapObject.imethod_3() + 10;
				}
			}
			GClass42.smethod_1(g, imgIds[tick], x - dx * mapObject.imethod_4(), y - dy, (mapObject.imethod_4() != 1) ? 2 : 0, (anchor != -1) ? anchor : ((mapObject.imethod_4() == -1) ? GClass45.int_4 : GClass45.int_5));
		}

		public void method_1(GClass68 g, int x, int y)
		{
			GClass42.smethod_1(g, iconId, x, y, 0, GClass45.int_3);
			GClass67.gclass67_14.method_1(g, method_2(), x, y, 2);
		}

		public string method_2()
		{
			try
			{
				int num = (int)time / 1000;
				if (num < 60)
				{
					return num + "s";
				}
				if (num < 3600)
				{
					return num / 60 + "'";
				}
				return num / 3600 + "h";
			}
			catch
			{
			}
			return "0s";
		}

		public void method_3()
		{
			if (imgIds.Count > 0)
			{
				if (loopCount > 0)
				{
					if (GClass69.int_0 % 5 == 0 || 1 == 0)
					{
						if (tick < imgIds.Count - 1)
						{
							tick++;
						}
						else
						{
							time = 0L;
						}
					}
					return;
				}
				if (GClass69.int_0 % 5 == 0 || 1 == 0)
				{
					if (tick < imgIds.Count - 1)
					{
						tick++;
					}
					else
					{
						tick = 0;
					}
				}
			}
			if (time != 0L && 0 == 0)
			{
				if (mapObject.imethod_5() && 0 == 0 && (type == 0 || 1 == 0))
				{
					time = 0L;
				}
				else
				{
					time = (timeEnd.Ticks - DateTime.UtcNow.Ticks) / 10000L;
				}
			}
			switch (templateId)
			{
			case 0:
				mapObject.imethod_7(time > 0L);
				break;
			case 1:
				if (mapObject is GClass25 && 0 == 0)
				{
					((GClass25)mapObject).isCanFly = time <= 0L;
				}
				break;
			case 2:
				mapObject.imethod_8(time > 0L);
				break;
			}
		}
	}
}
