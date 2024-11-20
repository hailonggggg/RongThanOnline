using System.Collections.Generic;

namespace rto
{
	public class GClass16
	{
		public static int int_0 = 0;

		public static int int_1 = 1;

		public static int int_2 = 2;

		public static int int_3 = 3;

		public static int int_4 = 4;

		public static int int_5 = 5;

		public static int int_6 = 6;

		public static int int_7 = 7;

		public static int int_8 = 8;

		public static int int_9 = 9;

		public static int int_10 = 10;

		public static int int_11 = 11;

		public static int int_12 = 12;

		public static int int_13 = 13;

		public static int int_14 = 14;

		public static int int_15 = 15;

		public static int int_16 = 16;

		public GClass19 template;

		public List<GClass17> options = new List<GClass17>();

		public int quantity;

		public int indexUI;

		public int id;

		public int typePrice;

		public int price;

		public int tick;

		public long tTick;

		public void method_0(GClass68 g, int x, int y)
		{
			int num = method_3();
			if (num > 0)
			{
				if (GClass84.smethod_1() - tTick > 100L)
				{
					tTick = GClass84.smethod_1();
					tick++;
					if (tick > 3)
					{
						tick = 0;
					}
				}
				if (num < 4)
				{
					g.method_12(13f, 173f, 207f);
					g.method_9(x - 37, y - 37, 75, 75, 11);
					g.method_12(63f, 106f, 185f);
					g.method_9(x - 34, y - 34, 69, 69, 8);
					GClass42.smethod_1(g, 166 + tick, x + 1, y, 0, 3);
				}
				else if (num < 8)
				{
					g.method_12(43f, 207f, 35f);
					g.method_9(x - 37, y - 37, 75, 75, 11);
					g.method_12(29f, 152f, 9f);
					g.method_9(x - 34, y - 34, 69, 69, 8);
					GClass42.smethod_1(g, 166 + tick, x + 1, y, 0, 3);
				}
				else if (num < 12)
				{
					g.method_12(200f, 88f, 200f);
					g.method_9(x - 37, y - 37, 75, 75, 11);
					g.method_12(103f, 53f, 168f);
					g.method_9(x - 34, y - 34, 69, 69, 8);
					GClass42.smethod_1(g, 166 + tick, x + 1, y, 0, 3);
				}
				else
				{
					g.method_12(235f, 71f, 72f);
					g.method_9(x - 37, y - 37, 75, 75, 11);
					g.method_12(176f, 34f, 22f);
					g.method_9(x - 34, y - 34, 69, 69, 8);
					GClass42.smethod_1(g, 166 + tick, x + 1, y, 0, 3);
				}
			}
			GClass42.smethod_1(g, template.iconId, x, y, 0, 3);
			if (quantity > 1)
			{
				GClass67.gclass67_13.method_1(g, "x" + quantity, x + 35, y + 5, 1);
			}
		}

		public GClass16 method_1()
		{
			GClass16 gClass = new GClass16();
			gClass.template = template;
			gClass.quantity = quantity;
			using List<GClass17>.Enumerator enumerator = options.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				GClass17 current = enumerator.Current;
				GClass17 gClass2 = new GClass17();
				gClass2.template = current.template;
				gClass2.param = current.param;
				gClass.options.Add(gClass2);
			}
			return gClass;
		}

		public GClass16 method_2()
		{
			GClass16 gClass = new GClass16();
			gClass.template = template;
			gClass.quantity = quantity;
			bool flag = false;
			using (List<GClass17>.Enumerator enumerator = options.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass17 current = enumerator.Current;
					GClass17 gClass2 = new GClass17();
					gClass2.template = current.template;
					gClass2.param = current.param;
					if (gClass2.template.id == 19)
					{
						flag = true;
						gClass2.param++;
					}
					if (gClass2.template.type == 0 || 1 == 0)
					{
						int num = gClass2.param / 10;
						if (num < 1)
						{
							num = 1;
						}
						gClass2.param += num;
					}
					if (gClass2.template.type == 2)
					{
						gClass2.param += 10;
					}
					gClass.options.Add(gClass2);
				}
			}
			if (!flag || 1 == 0)
			{
				gClass.options.Add(new GClass17(19, 1));
			}
			return gClass;
		}

		public int method_3()
		{
			using (List<GClass17>.Enumerator enumerator = options.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass17 current = enumerator.Current;
					if (current.template.id == 19)
					{
						return current.param;
					}
				}
			}
			return 0;
		}
	}
}
