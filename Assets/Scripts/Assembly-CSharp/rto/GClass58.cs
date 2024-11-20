namespace rto
{
	public class GClass58 : GClass57
	{
		private int hMid;

		public GClass58()
		{
			height = 44;
			hMid = (height - GClass67.gclass67_26.method_7()) / 2;
		}

		public override void vmethod_0(GClass68 g)
		{
			g.method_31();
			g.method_12(223f, 116f, 20f);
			g.method_9(x, y, width, height, 12);
			g.method_12(207f, 203f, 204f);
			if (isFocus && 0 == 0)
			{
				g.method_12(255f, 255f, 255f);
			}
			g.method_9(x + 2, y + 2, width - 4, height - 4, 10);
			g.method_5(x + 2, y + 2, width - 4, height - 4);
			if (text != null && 0 == 0 && (!text.Equals(string.Empty) || 1 == 0))
			{
				if (isFocus && 0 == 0)
				{
					GClass67.gclass67_30.method_1(g, textPaint, x + 20, y + hMid + ((type == GClass57.int_1) ? 7 : 0), 0);
					g.method_30(GClass57.gclass66_0, x + width - 50, y + 14);
				}
				else
				{
					GClass67.gclass67_31.method_1(g, textPaint, x + 20, y + hMid + ((type == GClass57.int_1) ? 7 : 0), 0);
				}
			}
			else if (name != null && 0 == 0)
			{
				if (isFocus && 0 == 0)
				{
					GClass67.gclass67_30.method_1(g, name, x + 20, y + hMid, 0);
				}
				else
				{
					GClass67.gclass67_31.method_1(g, name, x + 20, y + hMid, 0);
				}
			}
			if (isFocus && 0 == 0 && GClass69.int_0 % 20 > 9)
			{
				g.method_11(7999781);
				int num = x + 20;
				if (text != null && 0 == 0 && text != string.Empty && 0 == 0)
				{
					num = x + GClass67.gclass67_30.method_4(textPaint) + 20;
				}
				g.method_7(num, y + 5, 2, height - 10);
			}
			g.method_31();
		}
	}
}
