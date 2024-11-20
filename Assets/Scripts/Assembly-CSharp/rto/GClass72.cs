using System;

namespace rto
{
	public class GClass72
	{
		public string caption;

		public string[] subCaption;

		public GInterface1 actionListener;

		public int idAction;

		public int x;

		public int y;

		public int w;

		public int h;

		public bool isFocus;

		public object _object;

		public bool isShow;

		public GClass66 image;

		public GClass66 imageFocus;

		public GClass66 imageClick;

		public bool isClick;

		public int anchor = GClass45.int_1;

		public bool isFollowWithCamera;

		public static GClass66 gclass66_0;

		public static GClass66 gclass66_1;

		public static GClass66 gclass66_2;

		private static GClass66 gclass66_3;

		private static GClass66 gclass66_4;

		private static GClass66 gclass66_5;

		public static GClass66 gclass66_6;

		public static GClass66 gclass66_7;

		public static GClass66 gclass66_8;

		static GClass72()
		{
			gclass66_0 = GClass69.smethod_9("imgButtonMini");
			gclass66_1 = GClass69.smethod_9("imgButtonMiniClicked");
			gclass66_2 = GClass69.smethod_9("imgButtonMiniFocus");
			gclass66_3 = GClass69.smethod_9("imgButton");
			gclass66_4 = GClass69.smethod_9("imgButtonClicked");
			gclass66_5 = GClass69.smethod_9("imgButtonFocus");
			gclass66_6 = GClass69.smethod_9("imgButtonReg");
			gclass66_7 = GClass69.smethod_9("imgButtonRegClicked");
			gclass66_8 = GClass69.smethod_9("imgButtonRegFocus");
		}

		public GClass72()
		{
		}

		public GClass72(GClass66 image, GClass66 imageFocus, GClass66 imageClick, GInterface1 actionListener, int action, object p)
		{
			this.image = image;
			this.imageFocus = imageFocus;
			this.imageClick = imageClick;
			idAction = action;
			this.actionListener = actionListener;
			_object = p;
			if (image != null && 0 == 0)
			{
				w = image.method_0();
				h = image.method_1();
			}
			else
			{
				w = 90;
				h = 90;
			}
			isShow = true;
			anchor = GClass45.int_1;
		}

		public GClass72(string image, string imageFocus, string imageClick, string caption, GInterface1 actionListener, int action, object p)
		{
			this.caption = caption;
			this.image = GClass69.smethod_9(image);
			this.imageFocus = GClass69.smethod_9(imageFocus);
			this.imageClick = GClass69.smethod_9(imageClick);
			idAction = action;
			this.actionListener = actionListener;
			_object = p;
			if (this.image != null && 0 == 0)
			{
				w = this.image.method_0();
				h = this.image.method_1();
			}
			else
			{
				w = 90;
				h = 90;
			}
			isShow = true;
			anchor = GClass45.int_1;
		}

		public GClass72(string image, string imageFocus, string imageClick, GInterface1 actionListener, int action, object p)
		{
			this.image = GClass69.smethod_9(image);
			this.imageFocus = GClass69.smethod_9(imageFocus);
			this.imageClick = GClass69.smethod_9(imageClick);
			idAction = action;
			this.actionListener = actionListener;
			_object = p;
			if (this.image != null && 0 == 0)
			{
				w = this.image.method_0();
				h = this.image.method_1();
			}
			else
			{
				w = 90;
				h = 90;
			}
			isShow = true;
			anchor = GClass45.int_1;
		}

		public GClass72(string caption, GInterface1 actionListener, int action, object p)
		{
			image = gclass66_3;
			imageFocus = gclass66_5;
			imageClick = gclass66_4;
			this.caption = caption;
			idAction = action;
			this.actionListener = actionListener;
			_object = p;
			w = 220;
			h = 65;
			isShow = true;
		}

		public virtual void vmethod_0(GClass68 g)
		{
			if (!isShow || 1 == 0 || image == null || false || imageFocus == null)
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
			GClass67.gclass67_11.method_1(g, caption, x + w / 2, y + (h - GClass67.gclass67_11.method_7()) / 2, 2);
		}

		public virtual bool vmethod_1(int x, int y)
		{
			if (!isShow || 1 == 0)
			{
				isClick = false;
				isFocus = false;
				return false;
			}
			int num = ((isFollowWithCamera ? true : false) ? (-GClass3.int_0) : 0);
			int num2 = ((isFollowWithCamera ? true : false) ? (-GClass3.int_1) : 0);
			if (anchor == GClass45.int_6)
			{
				num -= w / 2;
				num2 -= h / 2;
			}
			if (x >= this.x + num && x <= this.x + w + num && y >= this.y + num2 && y <= this.y + h + num2)
			{
				isClick = true;
				return true;
			}
			isClick = false;
			return false;
		}

		public virtual bool vmethod_2(int x, int y)
		{
			if (!isShow || 1 == 0)
			{
				isClick = false;
				isFocus = false;
				return false;
			}
			int num = ((isFollowWithCamera ? true : false) ? (-GClass3.int_0) : 0);
			int num2 = ((isFollowWithCamera ? true : false) ? (-GClass3.int_1) : 0);
			if (anchor == GClass45.int_6)
			{
				num -= w / 2;
				num2 -= h / 2;
			}
			if (!isClick || 1 == 0)
			{
				isClick = false;
				return false;
			}
			isClick = false;
			if (x >= this.x + num && x <= this.x + w + num && y >= this.y + num2 && y <= this.y + h + num2)
			{
				if (Math.Abs(GClass69.int_6 - GClass69.int_4) < 40 && Math.Abs(GClass69.int_7 - GClass69.int_5) < 40)
				{
					method_0();
				}
				return true;
			}
			return false;
		}

		public virtual bool vmethod_3(int x, int y)
		{
			if (!isShow || 1 == 0)
			{
				isClick = false;
				isFocus = false;
				return false;
			}
			int num = ((isFollowWithCamera ? true : false) ? (-GClass3.int_0) : 0);
			int num2 = ((isFollowWithCamera ? true : false) ? (-GClass3.int_1) : 0);
			if (anchor == GClass45.int_6)
			{
				num -= w / 2;
				num2 -= h / 2;
			}
			if (x >= this.x + num && x <= this.x + w + num && y >= this.y + num2 && y <= this.y + h + num2)
			{
				isFocus = true;
				return true;
			}
			isFocus = false;
			return false;
		}

		public void method_0()
		{
			if (idAction > 0 && actionListener != null && 0 == 0)
			{
				GClass43.smethod_8();
				isClick = false;
				isFocus = false;
				actionListener.imethod_0(idAction, _object);
			}
		}
	}
}
