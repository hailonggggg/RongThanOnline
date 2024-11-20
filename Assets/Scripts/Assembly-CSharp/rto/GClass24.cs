using System;
using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass24 : GClass21, GInterface0
	{
		public GClass30 template;

		public int tick;

		public GClass77 chatInfo;

		public static GClass66 gclass66_0;

		static GClass24()
		{
			gclass66_0 = GClass69.smethod_9("imgQuesion.png");
		}

		public GClass24()
		{
			chatInfo = new GClass77();
			status = 1;
		}

		public void method_0(GClass68 g)
		{
			if ((GClass25.bool_0 ? true : false) || !method_1() || 1 == 0)
			{
				return;
			}
			try
			{
				GClass42.smethod_1(g, template.imgs[frame], x, y + ((template.id == 10) ? 5 : 0), (dir != 1) ? 2 : 0, GClass45.int_3);
				if (template.id != 3)
				{
					int num = imethod_3() + GClass67.gclass67_12.method_7() + 10;
					if (GClass25.gclass25_0.npcFocus != null && 0 == 0 && GClass25.gclass25_0.npcFocus.Equals(this))
					{
						g.method_28(GClass3.gclass66_2, x, y - h - 15, 3);
						GClass67.gclass67_13.method_1(g, template.name, x, y - (num += 15), 2);
					}
					else
					{
						GClass67.gclass67_13.method_1(g, template.name, x, y - num, 2);
					}
					try
					{
						if (GClass25.gclass25_0.task != null && 0 == 0)
						{
							GClass49 gClass = GClass25.gclass25_0.task.subTasks[GClass25.gclass25_0.task.index];
							if (gClass.npcId != -1 && gClass.npcId == template.id)
							{
								g.method_28(gclass66_0, x, y - num - ((frame != 0 && 0 == 0) ? 2 : 0), GClass45.int_3);
							}
						}
					}
					catch
					{
					}
				}
				else
				{
					if (GClass25.gclass25_0.npcFocus != null && 0 == 0 && GClass25.gclass25_0.npcFocus.Equals(this) && 0 == 0)
					{
						g.method_28(GClass3.gclass66_2, x, y - h - 15, 3);
					}
					GClass67.gclass67_12.method_1(g, Class0.int_3.ToString(), x, y - imethod_3() + 18, 2);
				}
				chatInfo.method_0(g, x, y - h, dir);
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
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

		public void method_2()
		{
			chatInfo.method_2();
			tick++;
			if (tick > 30)
			{
				tick = 0;
			}
			if (tick % 15 < 5)
			{
				frame = 0;
			}
			else
			{
				frame = 1;
			}
		}

		public void method_3(string info)
		{
			chatInfo.method_3(info);
		}

		public int imethod_0()
		{
			return x;
		}

		public int imethod_1()
		{
			return y;
		}

		public int imethod_2()
		{
			return w;
		}

		public int imethod_3()
		{
			return h;
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
