namespace rto
{
	public class GClass75 : GClass72
	{
		public GClass75()
		{
		}

		public GClass75(string caption, GInterface1 actionListener, int action, object p)
		{
			image = GClass72.gclass66_0;
			imageFocus = GClass72.gclass66_2;
			imageClick = GClass72.gclass66_1;
			base.caption = caption;
			idAction = action;
			base.actionListener = actionListener;
			_object = p;
			if (image != null && 0 == 0)
			{
				w = image.method_0();
				h = image.method_1();
			}
			else
			{
				w = 130;
				h = 40;
			}
			isShow = true;
		}

		public override void vmethod_0(GClass68 g)
		{
			if (!isShow || 1 == 0)
			{
				return;
			}
			if (anchor == GClass45.int_1)
			{
				if (isClick && 0 == 0)
				{
					g.method_28(imageClick, x + w / 2, y + h / 2, GClass45.int_6);
				}
				else
				{
					g.method_28((!isFocus) ? image : imageFocus, x + w / 2, y + h / 2, GClass45.int_6);
				}
			}
			else if (anchor == GClass45.int_6)
			{
				if (isClick && 0 == 0)
				{
					g.method_28(imageClick, x, y, GClass45.int_6);
				}
				else
				{
					g.method_28((!isFocus) ? image : imageFocus, x, y, GClass45.int_6);
				}
			}
			GClass67.gclass67_26.method_1(g, caption, x + w / 2, y + 8, 2);
		}
	}
}
