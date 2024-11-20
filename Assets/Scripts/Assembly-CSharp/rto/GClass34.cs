using System.Collections.Generic;

namespace rto
{
	public class GClass34
	{
		public int id;

		public GClass40 template;

		public List<GClass36> options = new List<GClass36>();

		public long lastTimeUse;

		public int level;

		public static GClass66 gclass66_0;

		public bool isPaintCanNotUse;

		static GClass34()
		{
			gclass66_0 = GClass69.smethod_9("imgCooldown.png");
		}

		public void method_0(GClass68 g, int x, int y)
		{
			GClass42.smethod_1(g, template.iconId, x, y, 0, GClass45.int_1);
			long num = GClass84.smethod_1() - lastTimeUse;
			if (num < method_3())
			{
				isPaintCanNotUse = true;
				int num2 = (int)(num * gclass66_0.method_1() / method_3());
				g.method_20(gclass66_0, 0, num2, gclass66_0.method_0(), gclass66_0.method_1() - num2, 0, x, y + num2, GClass45.int_1);
			}
			else
			{
				isPaintCanNotUse = false;
			}
		}

		public int method_1()
		{
			if (level == 0 || 1 == 0)
			{
				return template.manaUse;
			}
			return template.manaUse + template.manaWithLevel * (level - 1);
		}

		public int method_2(int level)
		{
			return template.manaUse + template.manaWithLevel * (level - 1);
		}

		public long method_3()
		{
			if (level == 0 || 1 == 0)
			{
				return template.coolDown;
			}
			return template.coolDown + template.timeWithLevel * (level - 1);
		}

		public long method_4(int level)
		{
			return template.coolDown + template.timeWithLevel * (level - 1);
		}

		public int method_5(int level)
		{
			return template.levelRequire + level - 1;
		}
	}
}
