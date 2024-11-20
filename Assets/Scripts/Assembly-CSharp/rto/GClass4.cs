using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass4 : GClass1, GInterface1
	{
		public GClass57 tfUser;

		public GClass57 tfPass;

		public GClass72 cmdLogin;

		public GClass72 cmdRegister;

		public GClass72 cmdSelectServer;

		public static GClass66 gclass66_0;

		public int w;

		public int h;

		public int x;

		public int y;

		public int wServer;

		public int hServer;

		public int xServer;

		public int yServer;

		public static GClass66 gclass66_1;

		public static string[] string_0;

		public static int int_0;

		static GClass4()
		{
			string_0 = new string[1] { "1 sao" };
			gclass66_0 = GClass69.smethod_9("imgBgrLogin");
			gclass66_1 = GClass69.smethod_9("imgLogoMini");
			gclass66_0 = GClass69.smethod_9("imgBgrLogin");
		}

		public GClass4()
		{
			tfUser = new GClass57();
			tfUser.width = 400;
			tfUser.isFocus = true;
			tfUser.name = GClass83.string_8;
			tfUser.x = GClass69.int_1 / 2 - tfUser.width / 2;
			tfUser.type = GClass57.int_3;
			tfPass = new GClass57();
			tfPass.width = 400;
			tfPass.name = GClass83.string_13;
			tfPass.x = GClass69.int_1 / 2 - tfPass.width / 2;
			tfPass.type = GClass57.int_1;
			cmdLogin = new GClass72(GClass83.string_14, this, 1, null);
			cmdLogin.x = GClass69.int_1 / 2 - cmdLogin.w - 10;
			cmdRegister = new GClass72(GClass83.string_16, this, 2, null);
			cmdRegister.image = GClass72.gclass66_6;
			cmdRegister.imageClick = GClass72.gclass66_7;
			cmdRegister.imageFocus = GClass72.gclass66_8;
			cmdRegister.x = GClass69.int_1 / 2 + 10;
			w = 520;
			h = 250;
			x = GClass69.int_1 / 2 - w / 2;
			y = GClass69.int_2 / 2 - h / 2 + 40;
			tfUser.y = y + 50;
			tfPass.y = tfUser.y + tfPass.height + 20;
			cmdLogin.y = y + h + 20;
			cmdRegister.y = y + h + 20;
			xServer = 10;
			yServer = 10;
			wServer = 335;
			hServer = 65;
			cmdSelectServer = new GClass72("imgSmallSelect", "imgSmallSelectFocus", "imgSmallSelectClicked", "Chọn", this, 3, null);
			cmdSelectServer.w = 120;
			cmdSelectServer.x = xServer + wServer - cmdSelectServer.w + 3;
			cmdSelectServer.y = yServer + 2;
			string text = GClass64.smethod_2("username");
			Debug.Log(text);
			if (text != null && 0 == 0)
			{
				tfUser.method_6(text);
			}
			string text2 = GClass64.smethod_2("password");
			if (text2 != null && 0 == 0)
			{
				tfPass.method_6(text2);
			}
		}

		public override void vmethod_1(GClass68 g)
		{
			GClass69.smethod_8(g);
			GClass67.gclass67_10.method_1(g, GClass70.string_4, GClass69.int_1 - 2, 0, 1);
			GClass67.gclass67_10.method_1(g, "version " + GClass70.string_3, GClass69.int_1 - 2, 30, 1);
			if (!GClass69.gclass76_0.isShow || 1 == 0)
			{
				g.method_12(223f, 116f, 20f);
				g.method_9(x, y, w, h, 16);
				g.method_12(255f, 237f, 217f);
				g.method_9(x + 10, y + 10, w - 20, h - 20, 12);
				g.method_28(gclass66_1, GClass69.int_1 / 2, y - 30, GClass45.int_3);
				cmdLogin.vmethod_0(g);
				cmdRegister.vmethod_0(g);
				tfUser.vmethod_0(g);
				tfPass.vmethod_0(g);
				g.method_18(0, 0.5f);
				g.method_9(xServer - 1, yServer - 1, wServer + 2, hServer + 2, 17);
				g.method_12(119f, 69f, 6f);
				g.method_9(xServer, yServer, wServer, hServer, 16);
				g.method_12(255f, 237f, 217f);
				g.method_9(xServer + 4, yServer + 4, wServer - 8, hServer - 8, 12);
				cmdSelectServer.vmethod_0(g);
				GClass67.gclass67_10.method_1(g, "Máy chủ: " + string_0[int_0], xServer + 20, yServer + 16, 0);
			}
			base.vmethod_1(g);
		}

		public override void vmethod_2()
		{
			tfUser.isFocus = true;
			tfPass.isFocus = false;
			base.vmethod_2();
			GClass43.smethod_26();
		}

		public override void vmethod_0()
		{
			tfUser.method_7();
			tfPass.method_7();
		}

		public override void vmethod_3()
		{
			base.vmethod_3();
		}

		public override void vmethod_5(int x, int y)
		{
			if (cmdLogin != null && 0 == 0)
			{
				cmdLogin.vmethod_1(x, y);
			}
			if (cmdRegister != null && 0 == 0)
			{
				cmdRegister.vmethod_1(x, y);
			}
			if (tfUser != null && 0 == 0)
			{
				tfUser.method_3(x, y);
			}
			if (tfPass != null && 0 == 0)
			{
				tfPass.method_3(x, y);
			}
			if (cmdSelectServer != null && 0 == 0)
			{
				cmdSelectServer.vmethod_1(x, y);
			}
			base.vmethod_5(x, y);
		}

		public override void vmethod_6(int x, int y)
		{
			if (cmdLogin != null && 0 == 0)
			{
				cmdLogin.vmethod_2(x, y);
			}
			if (cmdRegister != null && 0 == 0)
			{
				cmdRegister.vmethod_2(x, y);
			}
			if (cmdSelectServer != null && 0 == 0)
			{
				cmdSelectServer.vmethod_2(x, y);
			}
			base.vmethod_6(x, y);
		}

		public override void vmethod_7(int x, int y)
		{
			if (cmdLogin != null && 0 == 0)
			{
				cmdLogin.vmethod_3(x, y);
			}
			if (cmdRegister != null && 0 == 0)
			{
				cmdRegister.vmethod_3(x, y);
			}
			if (cmdSelectServer != null && 0 == 0)
			{
				cmdSelectServer.vmethod_3(x, y);
			}
			base.vmethod_7(x, y);
		}

		public override void vmethod_4(KeyCode keyCode)
		{
			if (keyCode == KeyCode.Tab && (!GClass69.gclass76_0.isShow || 1 == 0))
			{
				if (tfUser.isFocus && 0 == 0)
				{
					tfUser.isFocus = false;
					tfPass.isFocus = true;
				}
				else
				{
					tfUser.isFocus = true;
					tfPass.isFocus = false;
				}
			}
			if (keyCode == KeyCode.Return && (!GClass69.gclass76_0.isShow || 1 == 0))
			{
				method_1();
			}
			if (tfUser.isFocus && 0 == 0)
			{
				tfUser.method_4(keyCode);
			}
			else if (tfPass.isFocus && 0 == 0)
			{
				tfPass.method_4(keyCode);
			}
			base.vmethod_4(keyCode);
		}

		public void imethod_0(int idAction, object p)
		{
			switch (idAction)
			{
			case 1:
				method_1();
				break;
			case 2:
				Debug.Log("do register");
				break;
			case 3:
				method_0();
				break;
			case 4:
				break;
			}
		}

		public void method_0()
		{
			List<GClass72> list = new List<GClass72>();
			for (int i = 0; i < string_0.Length; i++)
			{
				GClass72 item = new GClass72(string_0[i], this, 4, i);
				list.Add(item);
			}
			GClass69.gclass80_0.method_1(list, yServer + hServer + 10, 220);
		}

		public void method_1()
		{
			if (tfUser.method_5().Equals(string.Empty) && 0 == 0)
			{
				GClass69.smethod_16(GClass83.string_21);
				return;
			}
			if (tfPass.method_5().Equals(string.Empty) && 0 == 0)
			{
				GClass69.smethod_16(GClass83.string_23);
				return;
			}
			GClass69.smethod_1();
			GClass0.smethod_0(tfUser.method_5(), tfPass.method_5());
			GClass69.smethod_21();
			GClass64.smethod_4("username", tfUser.method_5());
			GClass64.smethod_4("password", tfPass.method_5());
		}
	}
}
