namespace rto
{
	public class GClass13
	{
		public GClass67 myFont;

		public string text;

		public int x;

		public int y;

		public int dx;

		public int dy;

		public int tick;

		public int limitTime = 25;

		public int indexFirework;

		public static int[] int_0;

		public static GClass66 gclass66_0;

		public static GClass66 gclass66_1;

		public static GClass66 gclass66_2;

		public static GClass66 gclass66_3;

		public static int int_1;

		public static int int_2;

		public int type;

		static GClass13()
		{
			int_0 = new int[5] { 310, 311, 313, 314, 315 };
			int_1 = 1;
			int_2 = 2;
			gclass66_0 = GClass69.smethod_9("imgLevelUp1.png");
			gclass66_1 = GClass69.smethod_9("imgLevelUp2.png");
			gclass66_2 = GClass69.smethod_9("imgCompleteTask1.png");
			gclass66_3 = GClass69.smethod_9("imgCompleteTask2.png");
		}

		public void method_0(GClass68 g)
		{
			if (type != 1)
			{
				goto IL_00b7;
			}
			goto IL_00dc;
			IL_00b7:
			int num = -6;
			int num2 = 0;
			goto IL_00d5;
			IL_00d5:
			while (true)
			{
				num2 ^= 0x37;
				int num3;
				while (true)
				{
					num3 = GClass30.smethod_0(59);
					while (true)
					{
						switch (num3 ^ 0x41)
						{
						case -62:
							break;
						default:
							goto end_IL_0045;
						case -60:
							num2 = 3;
							num3 = -124;
							num3 = -59;
							goto end_IL_0063;
						case -59:
							goto end_IL_0063;
						case -61:
							while (true)
							{
								num3 = -126;
								num3 = -61;
							}
						}
						switch (num2)
						{
						case 52:
							goto IL_006d;
						case 53:
							goto IL_00b3;
						case 54:
							goto end_IL_00d5;
						case 55:
							goto IL_00be;
						}
						num3 = GClass30.smethod_0(62);
						continue;
						IL_00b3:
						num2 = 2;
						goto end_IL_0063;
						IL_00be:
						num ^= 0x39;
						num2 = 3;
						num3 = -124;
						num3 = -59;
						goto end_IL_0063;
						continue;
						end_IL_0045:
						break;
					}
					continue;
					end_IL_0063:
					break;
				}
				continue;
				IL_008a:
				num = -8;
				num = -63;
				num2 = 3;
				num3 = -124;
				num3 = -59;
				continue;
				IL_006d:
				switch (num)
				{
				case -63:
					goto IL_008a;
				case -61:
					goto IL_009a;
				case -62:
					goto IL_00dc;
				case -60:
					goto IL_0114;
				}
				num2 = 1;
				continue;
				IL_009a:
				if (type == 2)
				{
					num = -5;
					num = -62;
					num2 = 3;
					num3 = -124;
					num3 = -59;
					continue;
				}
				myFont.method_1(g, text, x, y, 2);
				return;
				continue;
				end_IL_00d5:
				break;
			}
			goto IL_00b7;
			IL_00dc:
			if (indexFirework < int_0.Length)
			{
				num = -3;
				num = -60;
				num2 = 3;
				int num3 = -124;
				num3 = -59;
				goto IL_00d5;
			}
			goto IL_014b;
			IL_014b:
			if (type == 1)
			{
				g.method_28((GClass69.int_0 % 10 < 5) ? gclass66_0 : gclass66_1, x, y, GClass45.int_3);
			}
			else if (type == 2)
			{
				g.method_28((GClass69.int_0 % 10 < 5) ? gclass66_2 : gclass66_3, x, y, GClass45.int_3);
			}
			return;
			IL_0114:
			GClass42.smethod_1(g, int_0[indexFirework], x, y - 30, 0, GClass68.int_0 | GClass68.int_5);
			goto IL_014b;
		}

		public void method_1()
		{
			if (type != 0 && true && (GClass69.int_0 % 2 == 0 || 1 == 0))
			{
				indexFirework++;
			}
		}
	}
}
