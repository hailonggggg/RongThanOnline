using System.Collections;
using UnityEngine;

namespace rto
{
	public class GClass68
	{
		public static int int_0 = 1;

		public static int int_1 = 2;

		public static int int_2 = 4;

		public static int int_3 = 8;

		public static int int_4 = 16;

		public static int int_5 = 32;

		public float r;

		public float g;

		public float b;

		public float a;

		public int clipX;

		public int clipY;

		public int clipW;

		public int clipH;

		private bool isClip;

		private bool isTranslate = true;

		private int translateX;

		private int translateY;

		private float translateXf;

		private float translateYf;

		public static Hashtable hashtable_0 = new Hashtable();

		private int clipTX;

		private int clipTY;

		private Vector2 pos = new Vector2(0f, 0f);

		private Rect rect;

		private Matrix4x4 matrixBackup;

		private Vector2 pivot;

		public Vector2 size = new Vector2(128f, 128f);

		public Vector2 relativePosition = new Vector2(0f, 0f);

		private Material lineMaterial;

		private void method_0(string string_0, Texture texture_0)
		{
			if (hashtable_0.Count > 400)
			{
				hashtable_0.Clear();
			}
			if (texture_0.width * texture_0.height < GClass69.int_1 * GClass69.int_2)
			{
				hashtable_0.Add(string_0, texture_0);
			}
		}

		public void method_1(int tx, int ty)
		{
			translateX += tx;
			translateY += ty;
			isTranslate = true;
			if ((translateX == 0 || 1 == 0) && (translateY == 0 || 1 == 0))
			{
				isTranslate = false;
			}
		}

		public void method_2(float x, float y)
		{
			translateXf += x;
			translateYf += y;
			isTranslate = true;
			if (translateXf == 0f && translateYf == 0f)
			{
				isTranslate = false;
			}
		}

		public int method_3()
		{
			return translateX;
		}

		public int method_4()
		{
			return translateY;
		}

		public void method_5(int x, int y, int w, int h)
		{
			clipTX = translateX;
			clipTY = translateY;
			clipX = x;
			clipY = y;
			clipW = w;
			clipH = h;
			isClip = true;
		}

		public void method_6(int x, int y, int w, int h)
		{
			method_7(x, y, w, 1);
			method_7(x, y, 1, h);
			method_7(x + w, y, 1, h + 1);
			method_7(x, y + h, w + 1, 1);
		}

		public void method_7(int x, int y, int w, int h)
		{
			if (w < 0 || h < 0)
			{
				return;
			}
			if (isTranslate && 0 == 0)
			{
				x += translateX;
				y += translateY;
			}
			int width = 1;
			int height = 1;
			string text = "fr" + width + height + r + g + b + a;
			Texture2D texture2D = (Texture2D)hashtable_0[text];
			if (texture2D == null && 0 == 0)
			{
				texture2D = new Texture2D(width, height);
				Color color = new Color(r, g, b, a);
				texture2D.SetPixel(0, 0, color);
				texture2D.Apply();
				method_0(text, texture2D);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if (isClip && 0 == 0)
			{
				num = clipX;
				num2 = clipY;
				num3 = clipW;
				num4 = clipH;
				if (isTranslate && 0 == 0)
				{
					num += clipTX;
					num2 += clipTY;
				}
			}
			if (isClip && 0 == 0)
			{
				GUI.BeginGroup(new Rect(num, num2, num3, num4));
			}
			GUI.DrawTexture(new Rect(x - num, y - num2, w, h), texture2D);
			if (isClip && 0 == 0)
			{
				GUI.EndGroup();
			}
		}

		public void method_8(int x, int y, int w, int h, int topLeftRadius, int topRightRadius, int bottomLeftRadius, int bottomRightRadius)
		{
			method_10(x, y, w, h, 10, topLeftRadius, topRightRadius, bottomLeftRadius, bottomRightRadius);
		}

		public void method_9(int x, int y, int w, int h, int Radius)
		{
			method_10(x, y, w, h, 10, Radius, Radius, Radius, Radius);
		}

		public void method_10(int x, int y, int w, int h, int wBorder, int topLeftRadius, int topRightRadius, int bottomLeftRadius, int bottomRightRadius)
		{
			if (w < 0 || h < 0)
			{
				return;
			}
			if (isTranslate && 0 == 0)
			{
				x += translateX;
				y += translateY;
			}
			int width = 1;
			int height = 1;
			string text = "fr" + width + height + r + g + b + a;
			Color color = new Color(r, g, b, a);
			Texture2D texture2D = (Texture2D)hashtable_0[text];
			if (texture2D == null && 0 == 0)
			{
				texture2D = new Texture2D(width, height);
				texture2D.SetPixel(0, 0, color);
				texture2D.Apply();
				method_0(text, texture2D);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Vector4 borderWidths = new Vector4(x, y, w - 2 * wBorder, h);
			Vector4 borderRadiuses = new Vector4(topLeftRadius, topRightRadius, bottomRightRadius, bottomLeftRadius);
			if (isClip && 0 == 0)
			{
				num = clipX;
				num2 = clipY;
				num3 = clipW;
				num4 = clipH;
				if (isTranslate && 0 == 0)
				{
					num += clipTX;
					num2 += clipTY;
				}
			}
			if (isClip && 0 == 0)
			{
				GUI.BeginGroup(new Rect(num, num2, num3, num4));
			}
			GUI.DrawTexture(new Rect(x - num, y - num2, w, h), texture2D, ScaleMode.StretchToFill, alphaBlend: false, 0f, GUI.color, borderWidths, borderRadiuses);
			if (isClip && 0 == 0)
			{
				GUI.EndGroup();
			}
		}

		public void method_11(int rgb)
		{
			int num = rgb & 0xFF;
			int num2 = (rgb >> 8) & 0xFF;
			int num3 = (rgb >> 16) & 0xFF;
			b = (float)num / 256f;
			g = (float)num2 / 256f;
			r = (float)num3 / 256f;
			a = 1f;
		}

		public void method_12(float r, float g, float b)
		{
			this.b = b / 256f;
			this.g = g / 256f;
			this.r = r / 256f;
			a = 1f;
		}

		public void method_13(float r, float g, float b, float a)
		{
			this.b = b / 256f;
			this.g = g / 256f;
			this.r = r / 256f;
			this.a = a;
		}

		public void method_14(Color color)
		{
			b = color.b;
			g = color.g;
			r = color.r;
			a = color.a;
		}

		public void method_15(string rgb)
		{
			try
			{
				string[] array = rgb.Split(',');
				r = float.Parse(array[0]) / 256f;
				g = float.Parse(array[1]) / 256f;
				b = float.Parse(array[2]) / 256f;
				a = 1f;
			}
			catch
			{
				method_11(0);
			}
		}

		public void method_16(Color color, float a)
		{
			b = color.b;
			g = color.g;
			r = color.r;
			this.a = a;
		}

		public void method_17(string s, int x, int y, GUIStyle style)
		{
			if (isTranslate && 0 == 0)
			{
				x += translateX;
				y += translateY;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if (isClip && 0 == 0)
			{
				num = clipX;
				num2 = clipY;
				num3 = clipW;
				num4 = clipH;
				if (isTranslate && 0 == 0)
				{
					num += clipTX;
					num2 += clipTY;
				}
			}
			if (isClip && 0 == 0)
			{
				GUI.BeginGroup(new Rect(num, num2, num3, num4));
			}
			GUI.Label(new Rect(x - num, y - num2, Screen.width, 100f), s, style);
			if (isClip && 0 == 0)
			{
				GUI.EndGroup();
			}
		}

		public void method_18(int rgb, float alpha)
		{
			int num = rgb & 0xFF;
			int num2 = (rgb >> 8) & 0xFF;
			int num3 = (rgb >> 16) & 0xFF;
			b = (float)num / 256f;
			g = (float)num2 / 256f;
			r = (float)num3 / 256f;
			a = alpha;
		}

		private void method_19(int int_6)
		{
			Vector2 vector = new Vector2(0f, 0f);
			switch (int_6)
			{
			case 6:
				vector = new Vector2(0f, Screen.height / 2);
				break;
			case 3:
				vector = new Vector2(size.x / 2f, size.y / 2f);
				break;
			case 17:
				vector = new Vector2(Screen.width / 2, 0f);
				break;
			case 10:
				vector = new Vector2(Screen.width, Screen.height / 2);
				break;
			case 24:
				vector = new Vector2(Screen.width, 0f);
				break;
			case 20:
				vector = new Vector2(0f, 0f);
				break;
			case 40:
				vector = new Vector2(Screen.width, Screen.height);
				break;
			case 36:
				vector = new Vector2(0f, Screen.height);
				break;
			case 33:
				vector = new Vector2(Screen.width / 2, Screen.height);
				break;
			}
			pos = vector + relativePosition;
			rect = new Rect(pos.x - size.x * 0.5f, pos.y - size.y * 0.5f, size.x, size.y);
			pivot = new Vector2(rect.xMin + rect.width * 0.5f, rect.yMin + rect.height * 0.5f);
		}

		public void method_20(GClass66 arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8)
		{
			method_25(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
		}

		public void method_21(GClass66 arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8)
		{
			method_25(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
		}

		public void method_22(GClass66 arg0, int x0, int y0, int w0, int h0, float arg5, int x, int y, int arg8)
		{
			method_27(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
		}

		public void method_23(GClass66 arg0, int x0, int y0, int w0, int h0, int arg5, int x, int y, int arg8, bool isClip)
		{
			method_20(arg0, x0, y0, w0, h0, arg5, x, y, arg8);
		}

		public void method_24(GClass66 image, int x0, int y0, int w, int h, int transform, float x, float y, int anchor)
		{
			if (image == null || 1 == 0)
			{
				return;
			}
			if (isTranslate && 0 == 0)
			{
				x += (float)translateX;
				y += (float)translateY;
			}
			float num = w;
			float num2 = h;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 1f;
			float num8 = 0f;
			int num9 = 1;
			if ((anchor & int_0) == int_0)
			{
				num5 -= num / 2f;
			}
			if ((anchor & int_1) == int_1)
			{
				num6 -= num2 / 2f;
			}
			if ((anchor & int_3) == int_3)
			{
				num5 -= num;
			}
			if ((anchor & int_5) == int_5)
			{
				num6 -= num2;
			}
			x += num5;
			y += num6;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			if (isClip && 0 == 0)
			{
				num10 = clipX;
				num11 = clipY;
				num12 = clipW;
				num13 = clipH;
				if (isTranslate && 0 == 0)
				{
					num10 += clipTX;
					num11 += clipTY;
				}
				Rect r = new Rect(x, y, w, h);
				Rect rect = method_32(r2: new Rect(num10, num11, num12, num13), r1: r);
				if (rect.width <= 0f || !(rect.height > 0f))
				{
					return;
				}
				num = rect.width;
				num2 = rect.height;
				num3 = rect.x - r.x;
				num4 = rect.y - r.y;
			}
			float num14 = 0f;
			float num15 = 0f;
			switch (transform)
			{
			case 1:
				num9 = -1;
				num15 += num2;
				break;
			case 2:
				num14 += num;
				num7 = -1f;
				if (isClip && 0 == 0)
				{
					if ((float)num10 > x)
					{
						num8 = 0f - num3;
					}
					else if ((float)(num10 + num12) < x + (float)w)
					{
						num8 = 0f - ((float)(num10 + num12) - x - (float)w);
					}
				}
				break;
			case 3:
				num9 = -1;
				num15 += num2;
				num7 = -1f;
				num14 += num;
				break;
			}
			int num16 = 0;
			int num17 = 0;
			if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			{
				matrixBackup = GUI.matrix;
				size = new Vector2(w, h);
				relativePosition = new Vector2(x, y);
				method_19(3);
				switch (transform)
				{
				case 6:
					method_19(3);
					break;
				case 5:
					size = new Vector2(w, h);
					method_19(3);
					break;
				}
				switch (transform)
				{
				case 4:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num14 += num;
					num7 = -1f;
					if (isClip && 0 == 0)
					{
						if ((float)num10 > x)
						{
							num8 = 0f - num3;
						}
						else if ((float)(num10 + num12) < x + (float)w)
						{
							num8 = 0f - ((float)(num10 + num12) - x - (float)w);
						}
					}
					break;
				case 5:
					GUIUtility.RotateAroundPivot(90f, pivot);
					break;
				case 6:
					GUIUtility.RotateAroundPivot(270f, pivot);
					break;
				case 7:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num9 = -1;
					num15 += num2;
					break;
				}
			}
			Graphics.DrawTexture(new Rect(x + num3 + num14 + (float)num16, y + num4 + (float)num17 + num15, num * num7, num2 * (float)num9), image.texture, new Rect(((float)x0 + num3 + num8) / (float)image.texture.width, ((float)image.texture.height - num2 - ((float)y0 + num4)) / (float)image.texture.height, num / (float)image.texture.width, num2 / (float)image.texture.height), 0, 0, 0, 0);
			if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			{
				GUI.matrix = matrixBackup;
			}
		}

		public void method_25(GClass66 image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor)
		{
			if (image == null || 1 == 0)
			{
				return;
			}
			if (isTranslate && 0 == 0)
			{
				x += translateX;
				y += translateY;
			}
			float num = w;
			float num2 = h;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 1f;
			float num8 = 0f;
			int num9 = 1;
			if ((anchor & int_0) == int_0)
			{
				num5 -= num / 2f;
			}
			if ((anchor & int_1) == int_1)
			{
				num6 -= num2 / 2f;
			}
			if ((anchor & int_3) == int_3)
			{
				num5 -= num;
			}
			if ((anchor & int_5) == int_5)
			{
				num6 -= num2;
			}
			x += (int)num5;
			y += (int)num6;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			if (isClip && 0 == 0)
			{
				num10 = clipX;
				num11 = clipY;
				num12 = clipW;
				num13 = clipH;
				if (isTranslate && 0 == 0)
				{
					num10 += clipTX;
					num11 += clipTY;
				}
				Rect r = new Rect(x, y, w, h);
				Rect rect = method_32(r2: new Rect(num10, num11, num12, num13), r1: r);
				if (rect.width <= 0f || !(rect.height > 0f))
				{
					return;
				}
				num = rect.width;
				num2 = rect.height;
				num3 = rect.x - r.x;
				num4 = rect.y - r.y;
			}
			float num14 = 0f;
			float num15 = 0f;
			switch (transform)
			{
			case 1:
				num9 = -1;
				num15 += num2;
				break;
			case 2:
				num14 += num;
				num7 = -1f;
				if (isClip && 0 == 0)
				{
					if (num10 > x)
					{
						num8 = 0f - num3;
					}
					else if (num10 + num12 < x + w)
					{
						num8 = -(num10 + num12 - x - w);
					}
				}
				break;
			case 3:
				num9 = -1;
				num15 += num2;
				num7 = -1f;
				num14 += num;
				break;
			}
			int num16 = 0;
			int num17 = 0;
			if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			{
				matrixBackup = GUI.matrix;
				size = new Vector2(w, h);
				relativePosition = new Vector2(x, y);
				method_19(3);
				switch (transform)
				{
				case 6:
					method_19(3);
					break;
				case 5:
					size = new Vector2(w, h);
					method_19(3);
					break;
				}
				switch (transform)
				{
				case 4:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num14 += num;
					num7 = -1f;
					if (isClip && 0 == 0)
					{
						if (num10 > x)
						{
							num8 = 0f - num3;
						}
						else if (num10 + num12 < x + w)
						{
							num8 = -(num10 + num12 - x - w);
						}
					}
					break;
				case 5:
					GUIUtility.RotateAroundPivot(90f, pivot);
					break;
				case 6:
					GUIUtility.RotateAroundPivot(270f, pivot);
					break;
				case 7:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num9 = -1;
					num15 += num2;
					break;
				}
			}
			Graphics.DrawTexture(new Rect((float)x + num3 + num14 + (float)num16, (float)y + num4 + (float)num17 + num15, num * num7, num2 * (float)num9), image.texture, new Rect((x0 + num3 + num8) / (float)image.texture.width, ((float)image.texture.height - num2 - (y0 + num4)) / (float)image.texture.height, num / (float)image.texture.width, num2 / (float)image.texture.height), 0, 0, 0, 0);
			if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			{
				GUI.matrix = matrixBackup;
			}
		}

		public void method_26(GClass66 image, float x0, float y0, int w, int h, int transform, int x, int y, int anchor, int test)
		{
			if (image == null || 1 == 0)
			{
				return;
			}
			if (isTranslate && 0 == 0)
			{
				x += translateX;
				y += translateY;
			}
			float num = w / 6;
			float num2 = h / 6;
			float num3 = 0f;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 1f;
			float num8 = 0f;
			int num9 = 1;
			if ((anchor & int_0) == int_0)
			{
				num5 -= num / 2f;
			}
			if ((anchor & int_1) == int_1)
			{
				num6 -= num2 / 2f;
			}
			if ((anchor & int_3) == int_3)
			{
				num5 -= num;
			}
			if ((anchor & int_5) == int_5)
			{
				num6 -= num2;
			}
			x += (int)num5;
			y += (int)num6;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			if (isClip && 0 == 0)
			{
				num10 = clipX;
				num11 = clipY;
				num12 = clipW;
				num13 = clipH;
				if (isTranslate && 0 == 0)
				{
					num10 += clipTX;
					num11 += clipTY;
				}
				Rect r = new Rect(x, y, w, h);
				Rect rect = method_32(r2: new Rect(num10, num11, num12, num13), r1: r);
				if (rect.width <= 0f || !(rect.height > 0f))
				{
					return;
				}
				num = rect.width;
				num2 = rect.height;
				num3 = rect.x - r.x;
				num4 = rect.y - r.y;
			}
			float num14 = 0f;
			float num15 = 0f;
			switch (transform)
			{
			case 1:
				num9 = -1;
				num15 += num2;
				break;
			case 2:
				num14 += num;
				num7 = -1f;
				if (isClip && 0 == 0)
				{
					if (num10 > x)
					{
						num8 = 0f - num3;
					}
					else if (num10 + num12 < x + w)
					{
						num8 = -(num10 + num12 - x - w);
					}
				}
				break;
			case 3:
				num9 = -1;
				num15 += num2;
				num7 = -1f;
				num14 += num;
				break;
			}
			int num16 = 0;
			int num17 = 0;
			if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			{
				matrixBackup = GUI.matrix;
				size = new Vector2(w, h);
				relativePosition = new Vector2(x, y);
				method_19(3);
				switch (transform)
				{
				case 6:
					method_19(3);
					break;
				case 5:
					size = new Vector2(w, h);
					method_19(3);
					break;
				}
				switch (transform)
				{
				case 4:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num14 += num;
					num7 = -1f;
					if (isClip && 0 == 0)
					{
						if (num10 > x)
						{
							num8 = 0f - num3;
						}
						else if (num10 + num12 < x + w)
						{
							num8 = -(num10 + num12 - x - w);
						}
					}
					break;
				case 5:
					GUIUtility.RotateAroundPivot(90f, pivot);
					break;
				case 6:
					GUIUtility.RotateAroundPivot(270f, pivot);
					break;
				case 7:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num9 = -1;
					num15 += num2;
					break;
				}
			}
			Graphics.DrawTexture(new Rect((float)x + num3 + num14 + (float)num16, (float)y + num4 + (float)num17 + num15, num * num7, num2 * (float)num9), image.texture, new Rect((x0 + num3 + num8) / (float)image.texture.width, ((float)image.texture.height - num2 - (y0 + num4)) / (float)image.texture.height, num / (float)image.texture.width, num2 / (float)image.texture.height), 0, 0, 0, 0);
			if (transform == 5 || transform == 6 || transform == 4 || transform == 7)
			{
				GUI.matrix = matrixBackup;
			}
		}

		public void method_27(GClass66 image, float x0, float y0, int w, int h, float angle, int x, int y, int anchor)
		{
			int num = 5;
			if (image == null || 1 == 0)
			{
				return;
			}
			if (isTranslate && 0 == 0)
			{
				x += translateX;
				y += translateY;
			}
			float num2 = w;
			float num3 = h;
			float num4 = 0f;
			float num5 = 0f;
			float num6 = 0f;
			float num7 = 0f;
			float num8 = 1f;
			float num9 = 0f;
			int num10 = 1;
			if ((anchor & int_0) == int_0)
			{
				num6 -= num2 / 2f;
			}
			if ((anchor & int_1) == int_1)
			{
				num7 -= num3 / 2f;
			}
			if ((anchor & int_3) == int_3)
			{
				num6 -= num2;
			}
			if ((anchor & int_5) == int_5)
			{
				num7 -= num3;
			}
			x += (int)num6;
			y += (int)num7;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			int num14 = 0;
			if (isClip && 0 == 0)
			{
				num11 = clipX;
				num12 = clipY;
				num13 = clipW;
				num14 = clipH;
				if (isTranslate && 0 == 0)
				{
					num11 += clipTX;
					num12 += clipTY;
				}
				Rect r = new Rect(x, y, w, h);
				Rect rect = method_32(r2: new Rect(num11, num12, num13, num14), r1: r);
				if (rect.width <= 0f || !(rect.height > 0f))
				{
					return;
				}
				num2 = rect.width;
				num3 = rect.height;
				num4 = rect.x - r.x;
				num5 = rect.y - r.y;
			}
			float num15 = 0f;
			float num16 = 0f;
			switch (num)
			{
			case 1:
				num10 = -1;
				num16 += num3;
				break;
			case 2:
				num15 += num2;
				num8 = -1f;
				if (isClip && 0 == 0)
				{
					if (num11 > x)
					{
						num9 = 0f - num4;
					}
					else if (num11 + num13 < x + w)
					{
						num9 = -(num11 + num13 - x - w);
					}
				}
				break;
			case 3:
				num10 = -1;
				num16 += num3;
				num8 = -1f;
				num15 += num2;
				break;
			}
			int num17 = 0;
			int num18 = 0;
			if (num == 5 || num == 6 || num == 4 || num == 7)
			{
				matrixBackup = GUI.matrix;
				size = new Vector2(w, h);
				relativePosition = new Vector2(x, y);
				method_19(3);
				switch (num)
				{
				case 6:
					method_19(3);
					break;
				case 5:
					size = new Vector2(w, h);
					method_19(3);
					break;
				}
				switch (num)
				{
				case 4:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num15 += num2;
					num8 = -1f;
					if (isClip && 0 == 0)
					{
						if (num11 > x)
						{
							num9 = 0f - num4;
						}
						else if (num11 + num13 < x + w)
						{
							num9 = -(num11 + num13 - x - w);
						}
					}
					break;
				case 5:
					GUIUtility.RotateAroundPivot(angle, pivot);
					break;
				case 6:
					GUIUtility.RotateAroundPivot(270f, pivot);
					break;
				case 7:
					GUIUtility.RotateAroundPivot(270f, pivot);
					num10 = -1;
					num16 += num3;
					break;
				}
			}
			Graphics.DrawTexture(new Rect((float)x + num4 + num15 + (float)num17, (float)y + num5 + (float)num18 + num16, num2 * num8, num3 * (float)num10), image.texture, new Rect((x0 + num4 + num9) / (float)image.texture.width, ((float)image.texture.height - num3 - (y0 + num5)) / (float)image.texture.height, num2 / (float)image.texture.width, num3 / (float)image.texture.height), 0, 0, 0, 0);
			if (num == 5 || num == 6 || num == 4 || num == 7)
			{
				GUI.matrix = matrixBackup;
			}
		}

		public void method_28(GClass66 image, int x, int y, int anchor)
		{
			if (image != null && 0 == 0)
			{
				method_20(image, 0, 0, smethod_0(image), smethod_1(image), 0, x, y, anchor);
			}
		}

		public void method_29(int x, int y, GClass66 image, int transform, int anchor)
		{
			if (image != null && 0 == 0)
			{
				method_20(image, 0, 0, smethod_0(image), smethod_1(image), transform, x, y, anchor);
			}
		}

		public void method_30(GClass66 image, int x, int y)
		{
			if (image != null && 0 == 0)
			{
				method_20(image, 0, 0, smethod_0(image), smethod_1(image), 0, x, y, int_4 | int_2);
			}
		}

		public void method_31()
		{
			isClip = false;
			isTranslate = false;
			translateX = 0;
			translateY = 0;
		}

		public Rect method_32(Rect r1, Rect r2)
		{
			float num = r1.x;
			float num2 = r1.y;
			float x = r2.x;
			float y = r2.y;
			float num3 = num;
			num3 += r1.width;
			float num4 = num2;
			num4 += r1.height;
			float num5 = x;
			num5 += r2.width;
			float num6 = y;
			num6 += r2.height;
			if (num < x)
			{
				num = x;
			}
			if (num2 < y)
			{
				num2 = y;
			}
			if (num3 > num5)
			{
				num3 = num5;
			}
			if (num4 > num6)
			{
				num4 = num6;
			}
			num3 -= num;
			num4 -= num2;
			if (num3 < -30000f)
			{
				num3 = -30000f;
			}
			if (num4 < -30000f)
			{
				num4 = -30000f;
			}
			return new Rect(num, num2, (int)num3, (int)num4);
		}

		public void method_33(GClass66 image, int x, int y, int w, int h, int tranform)
		{
			GUI.color = Color.red;
			if (image != null && 0 == 0)
			{
				Graphics.DrawTexture(new Rect(x + translateX, y + translateY, ((tranform != 0) ? true : false) ? (-w) : w, h), image.texture);
			}
		}

		public void method_34(GClass66 image, int x, int y)
		{
			if (image != null && 0 == 0)
			{
				Graphics.DrawTexture(new Rect(x, y, image.w, image.h), image.texture);
			}
		}

		public static int smethod_0(GClass66 image)
		{
			return image.method_0();
		}

		public static int smethod_1(GClass66 image)
		{
			return image.method_1();
		}

		public void method_35()
		{
			if (!lineMaterial || 1 == 0)
			{
				lineMaterial = new Material(Shader.Find("Specular"));
				lineMaterial.hideFlags = HideFlags.HideAndDontSave;
				lineMaterial.shader.hideFlags = HideFlags.HideAndDontSave;
			}
		}
	}
}
