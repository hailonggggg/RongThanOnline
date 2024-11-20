using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass80
	{
		public bool isShow;

		public List<GClass72> commands = new List<GClass72>();

		public int indexSelect;

		public int x;

		public int y;

		public int w;

		public int[] wPaintMax;

		public int[] wPaint;

		public int h;

		public int xStart;

		public static int[] int_0;

		public static int[] int_1;

		public int tDelay;

		private int waitToPerform;

		private bool isClose;

		public bool isClickOut;

		private int dis;

		public int xPopup;

		public int yPopup;

		public int wPopup;

		public int hPopup;

		public string title;

		public string[] subTitle;

		public int iconId;

		public long timeStart;

		private GClass66[] images;

		static GClass80()
		{
		}

		public GClass80()
		{
			images = new GClass66[2];
			for (int i = 0; i < images.Length; i++)
			{
				images[i] = GClass69.smethod_9("imgMenu" + i);
			}
		}

		public void method_0(List<GClass72> commands)
		{
			title = string.Empty;
			isClickOut = false;
			isClose = false;
			tDelay = 0;
			waitToPerform = 0;
			indexSelect = -1;
			GClass78.smethod_5();
			if (commands.Count != 0 && 0 == 0)
			{
				GClass43.smethod_9();
				this.commands = commands;
				w = images[0].method_0();
				xStart = -w - 50;
				h = images[0].method_1();
				wPaint = new int[commands.Count];
				wPaintMax = new int[commands.Count];
				int_0 = new int[commands.Count];
				x = 30;
				dis = 10;
				y = (GClass69.int_2 - commands.Count * h - dis * (commands.Count - 1)) / 2;
				for (int i = 0; i < int_0.Length; i++)
				{
					int_0[i] = -w - 10;
					wPaint[i] = (wPaintMax[i] = w);
				}
				timeStart = GClass84.smethod_1();
				isShow = true;
			}
		}

		public void method_1(List<GClass72> commands, int y, int w)
		{
			title = string.Empty;
			isClickOut = false;
			isClose = false;
			tDelay = 0;
			waitToPerform = 0;
			indexSelect = -1;
			GClass78.smethod_5();
			if (commands.Count != 0 && 0 == 0)
			{
				GClass43.smethod_9();
				this.commands = commands;
				this.w = w;
				xStart = -this.w - 50;
				h = 65;
				wPaint = new int[commands.Count];
				wPaintMax = new int[commands.Count];
				int_0 = new int[commands.Count];
				x = 30;
				dis = 10;
				this.y = y;
				for (int i = 0; i < int_0.Length; i++)
				{
					int_0[i] = -this.w - 10;
					wPaint[i] = (wPaintMax[i] = this.w);
				}
				timeStart = GClass84.smethod_1();
				isShow = true;
			}
		}

		public void method_2(string title, int iconId, List<GClass72> commands)
		{
			this.iconId = iconId;
			this.title = title;
			wPopup = 640;
			subTitle = GClass67.gclass67_5.method_3(title, wPopup - 100);
			hPopup = subTitle.Length * GClass67.gclass67_5.method_7() + (subTitle.Length - 1) * 10 + 50;
			xPopup = 30;
			isClickOut = false;
			isClose = false;
			tDelay = 0;
			waitToPerform = 0;
			indexSelect = -1;
			GClass78.smethod_5();
			if (commands.Count != 0 && 0 == 0)
			{
				GClass43.smethod_9();
				this.commands = commands;
				w = images[0].method_0();
				xStart = -w - 50;
				h = images[0].method_1();
				wPaint = new int[commands.Count];
				wPaintMax = new int[commands.Count];
				int_0 = new int[commands.Count];
				x = 60;
				dis = 10;
				y = GClass69.int_2 - commands.Count * h - dis * (commands.Count - 1) - h;
				yPopup = y - 10 - hPopup;
				for (int i = 0; i < int_0.Length; i++)
				{
					int_0[i] = -w - 10;
					wPaint[i] = (wPaintMax[i] = w);
				}
				timeStart = GClass84.smethod_1();
				isShow = true;
			}
		}

		public void method_3(GClass68 g)
		{
			g.method_31();
			if (title != string.Empty && 0 == 0 && (!isClose || 1 == 0))
			{
				GClass42.smethod_1(g, iconId, xPopup + 20, yPopup, 0, GClass45.int_4);
				smethod_0(g, xPopup, yPopup, wPopup, hPopup);
				for (int i = 0; i < subTitle.Length; i++)
				{
					GClass67.gclass67_5.method_1(g, subTitle[i], xPopup + wPopup / 2, yPopup + 25 + i * (GClass67.gclass67_5.method_7() + 10), 2);
				}
			}
			int num = GClass67.gclass67_11.method_7();
			for (int j = 0; j < commands.Count; j++)
			{
				Graphics.DrawTexture(new Rect(int_0[j], y + j * h + j * dis, wPaint[j], h), (j != indexSelect) ? images[0].texture : images[1].texture);
				GClass67.gclass67_11.method_1(g, commands[j].caption, int_0[j] + wPaint[j] / 2, y + j * h + j * dis + (h - num) / 2, 2);
			}
			g.method_31();
		}

		public static void smethod_0(GClass68 g, int x, int y, int w, int h)
		{
			g.method_11(0);
			g.method_9(x, y, w, h, 16);
			g.method_11(16777215);
			g.method_9(x + 3, y + 3, w - 6, h - 6, 13);
		}

		public void method_4()
		{
			if (GClass84.smethod_1() - timeStart > 10000L)
			{
				timeStart = GClass84.smethod_1();
				isClickOut = true;
				waitToPerform = 2;
			}
			bool flag = true;
			for (int i = 0; i < int_0.Length; i++)
			{
				if (int_0[i] != x)
				{
					flag = false;
					break;
				}
			}
			if (flag && 0 == 0)
			{
				for (int j = 0; j < wPaint.Length; j++)
				{
					if (wPaint[j] < wPaintMax[j])
					{
						int num = wPaintMax[j] - wPaint[j] >> 1;
						if (num < 1)
						{
							num = 1;
						}
						wPaint[j] += num;
					}
					else if (wPaint[j] > wPaintMax[j])
					{
						int num2 = wPaint[j] - wPaintMax[j] >> 1;
						if (num2 < 1)
						{
							num2 = 1;
						}
						wPaint[j] -= num2;
					}
				}
			}
			if (!isClose || 1 == 0)
			{
				tDelay++;
				for (int k = 0; k < int_0.Length; k++)
				{
					if (int_0[k] < x)
					{
						int num3 = x - int_0[k] >> 1;
						if (num3 < 1)
						{
							num3 = 1;
						}
						if (tDelay > k)
						{
							int_0[k] += num3;
						}
					}
				}
				if (int_0[int_0.Length - 1] >= x)
				{
					tDelay = 0;
				}
			}
			else
			{
				tDelay++;
				for (int l = 0; l < int_0.Length; l++)
				{
					if (int_0[l] > xStart)
					{
						int num4 = int_0[l] - xStart >> 1;
						if (num4 < 1)
						{
							num4 = 1;
						}
						if (tDelay > l)
						{
							int_0[l] -= num4;
						}
					}
				}
				if (int_0[int_0.Length - 1] <= xStart)
				{
					tDelay = 0;
					method_9();
				}
			}
			if (waitToPerform <= 0)
			{
				return;
			}
			waitToPerform--;
			if (waitToPerform == 0 || 1 == 0)
			{
				isClose = true;
				if (!isClickOut || 1 == 0)
				{
					method_10();
				}
			}
		}

		public void method_5(KeyCode keyCode)
		{
			if (keyCode == KeyCode.F2)
			{
				isClickOut = true;
				waitToPerform = 2;
			}
		}

		public void method_6(int x, int y)
		{
		}

		public void method_7(int x, int y)
		{
			if (GClass84.smethod_1() - timeStart < 100L)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < commands.Count; i++)
			{
				if (x >= int_0[i] && x <= int_0[i] + wPaint[i] && y >= this.y + (h + dis) * i && y <= this.y + (h + dis) * i + h)
				{
					flag = true;
					indexSelect = i;
					waitToPerform = 2;
					break;
				}
			}
			if (!flag || 1 == 0)
			{
				isClickOut = true;
				waitToPerform = 2;
			}
		}

		public void method_8(int x, int y)
		{
			bool flag = false;
			for (int i = 0; i < commands.Count; i++)
			{
				if (x >= int_0[i] && x <= int_0[i] + wPaint[i] && y >= this.y + (h + dis) * i && y <= this.y + (h + dis) * i + h)
				{
					flag = true;
					indexSelect = i;
					wPaintMax[i] = w + 50;
				}
				else
				{
					wPaintMax[i] = w;
				}
			}
			if (!flag || 1 == 0)
			{
				indexSelect = -1;
			}
		}

		public void method_9()
		{
			isClose = false;
			isShow = false;
			GClass43.smethod_7();
			GClass78.smethod_5();
		}

		public void method_10()
		{
			GClass78.smethod_5();
			if (indexSelect >= 0 && indexSelect < commands.Count)
			{
				commands[indexSelect].method_0();
			}
		}
	}
}
