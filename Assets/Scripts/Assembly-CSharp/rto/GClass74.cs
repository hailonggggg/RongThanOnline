using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace rto
{
	public class GClass74 : GClass72
	{
		public GClass16 item;

		public GClass74()
		{
			w = 75;
			h = 75;
		}

		public GClass74(GInterface1 actionListener, int action, object p)
		{
			w = 75;
			h = 75;
			idAction = action;
			base.actionListener = actionListener;
			_object = p;
			isShow = true;
		}

		public override void vmethod_0(GClass68 g)
		{
			if (GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.type == 1)
			{
				if ((isClick ? true : false) || GClass69.gclass6_0.indexSelect == (int)_object)
				{
					g.method_14(Color.green);
					g.method_9(x, y, w, h, 11);
				}
				return;
			}
			if (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && (GClass69.gclass6_0.type == 0 || 1 == 0))
			{
				bool flag = false;
				if ((GClass69.gclass6_0.tabs.Contains(Panel.gclass47_8) ? true : false) || GClass69.gclass6_0.tabs.Contains(Panel.gclass47_21))
				{
					using List<GClass16>.Enumerator enumerator = GClass6.list_1.GetEnumerator();
					while (enumerator.MoveNext() ? true : false)
					{
						GClass16 current = enumerator.Current;
						if (current != null && 0 == 0 && current.indexUI == (int)_object)
						{
							flag = true;
							break;
						}
					}
				}
				if (GClass69.gclass6_0.tabs.Contains(Panel.gclass47_20) && 0 == 0)
				{
					using List<GClass16>.Enumerator enumerator = GClass69.gclass6_0.itemsMe.GetEnumerator();
					while (enumerator.MoveNext() ? true : false)
					{
						GClass16 current2 = enumerator.Current;
						if (current2 != null && 0 == 0 && current2.indexUI == (int)_object)
						{
							flag = true;
							break;
						}
					}
				}
				if (flag && 0 == 0)
				{
					g.method_11(0);
					g.method_9(x - 3, y - 3, w + 6, h + 6, 14);
				}
			}
			g.method_12(264f, 181f, 115f);
			g.method_9(x, y, w, h, 11);
			if (item != null && 0 == 0)
			{
				item.method_0(g, x + w / 2, y + h / 2);
			}
			if ((isClick ? true : false) || (_object != null && 0 == 0 && GClass69.gclass6_0.isShow && 0 == 0 && GClass69.gclass6_0.indexSelect == (int)_object))
			{
				GClass42.smethod_1(g, 139, x + w / 2, y + h / 2, 0, 3);
			}
		}
	}
}
