using System;
using System.Threading;
using UnityEngine;

namespace rto
{
	public class GClass66
	{
		public Texture2D texture = new Texture2D(1, 1);

		public static GClass66 gclass66_0;

		public static string string_0;

		public static byte[] byte_0;

		public static GClass66 gclass66_1;

		public static int int_0;

		public static int int_1;

		public static int int_2;

		public static int int_3;

		public static int int_4;

		public int w;

		public int h;

		public static int int_5;

		public static GClass66 smethod_0()
		{
			return smethod_22();
		}

		public static GClass66 smethod_1(string filename)
		{
			return smethod_18(filename);
		}

		public static GClass66 smethod_2(byte[] imageData)
		{
			return smethod_20(imageData);
		}

		public static GClass66 smethod_3(GClass66 src, int x, int y, int w, int h, int transform)
		{
			return smethod_21(src, x, y, w, h, transform);
		}

		public static GClass66 smethod_4(int w, int h)
		{
			return smethod_23(w, h);
		}

		public static GClass66 smethod_5(GClass66 img)
		{
			GClass66 gClass = smethod_4(img.w, img.h);
			gClass.texture = img.texture;
			gClass.texture.Apply();
			return gClass;
		}

		public static GClass66 smethod_6(sbyte[] imageData, int offset, int lenght)
		{
			if (offset + lenght > imageData.Length)
			{
				return null;
			}
			byte[] array = new byte[lenght];
			for (int i = 0; i < lenght; i++)
			{
				array[i] = smethod_7(imageData[i + offset]);
			}
			return smethod_2(array);
		}

		public static byte smethod_7(sbyte var)
		{
			if (var > 0)
			{
				return (byte)var;
			}
			return (byte)(var + 256);
		}

		public static byte[] smethod_8(sbyte[] var)
		{
			byte[] array = new byte[var.Length];
			for (int i = 0; i < var.Length; i++)
			{
				if (var[i] > 0)
				{
					array[i] = (byte)var[i];
				}
				else
				{
					array[i] = (byte)(var[i] + 256);
				}
			}
			return array;
		}

		public static GClass66 smethod_9(int[] rbg, int w, int h, bool bl)
		{
			GClass66 gClass = smethod_4(w, h);
			Color[] array = new Color[rbg.Length];
			for (int i = 0; i < array.Length; i++)
			{
				ref Color reference = ref array[i];
				reference = smethod_10(rbg[i]);
			}
			gClass.texture.SetPixels(0, 0, w, h, array);
			gClass.texture.Apply();
			return gClass;
		}

		public static Color smethod_10(int rgb)
		{
			int num = rgb & 0xFF;
			int num2 = (rgb >> 8) & 0xFF;
			int num3 = (rgb >> 16) & 0xFF;
			return new Color(b: (float)num / 256f, g: (float)num2 / 256f, r: (float)num3 / 256f);
		}

		public static void smethod_11()
		{
			if (int_5 == 2)
			{
				int_5 = 1;
				gclass66_0 = smethod_22();
				int_5 = 0;
			}
			else if (int_5 == 3)
			{
				int_5 = 1;
				gclass66_0 = smethod_18(string_0);
				int_5 = 0;
			}
			else if (int_5 == 4)
			{
				int_5 = 1;
				gclass66_0 = smethod_20(byte_0);
				int_5 = 0;
			}
			else if (int_5 == 5)
			{
				int_5 = 1;
				gclass66_0 = smethod_21(gclass66_1, int_0, int_1, int_2, int_3, int_4);
				int_5 = 0;
			}
			else if (int_5 == 6)
			{
				int_5 = 1;
				gclass66_0 = smethod_23(int_2, int_3);
				int_5 = 0;
			}
		}

		private static GClass66 smethod_12()
		{
			if (int_5 != 0 && 0 == 0)
			{
				return null;
			}
			gclass66_0 = null;
			int_5 = 2;
			int i;
			for (i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_5 == 0)
				{
					break;
				}
			}
			if (i == 500)
			{
				int_5 = 0;
			}
			return gclass66_0;
		}

		private static GClass66 smethod_13(string string_1)
		{
			if (int_5 != 0 && 0 == 0)
			{
				return null;
			}
			gclass66_0 = null;
			string_0 = string_1;
			int_5 = 3;
			int i;
			for (i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_5 == 0)
				{
					break;
				}
			}
			if (i == 500)
			{
				int_5 = 0;
			}
			return gclass66_0;
		}

		private static GClass66 smethod_14(byte[] byte_1)
		{
			if (int_5 != 0 && 0 == 0)
			{
				return null;
			}
			gclass66_0 = null;
			byte_0 = byte_1;
			int_5 = 4;
			int i;
			for (i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_5 == 0)
				{
					break;
				}
			}
			if (i == 500)
			{
				int_5 = 0;
			}
			return gclass66_0;
		}

		private static GClass66 smethod_15(GClass66 gclass66_2, int int_6, int int_7, int int_8, int int_9, int int_10)
		{
			if (int_5 != 0 && 0 == 0)
			{
				return null;
			}
			gclass66_0 = null;
			gclass66_1 = gclass66_2;
			int_0 = int_6;
			int_1 = int_7;
			int_2 = int_8;
			int_3 = int_9;
			int_4 = int_10;
			int_5 = 5;
			int i;
			for (i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_5 == 0)
				{
					break;
				}
			}
			if (i == 500)
			{
				int_5 = 0;
			}
			return gclass66_0;
		}

		private static GClass66 smethod_16(int int_6, int int_7)
		{
			if (int_5 != 0 && 0 == 0)
			{
				return null;
			}
			gclass66_0 = null;
			int_2 = int_6;
			int_3 = int_7;
			int_5 = 6;
			int i;
			for (i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_5 == 0)
				{
					break;
				}
			}
			if (i == 500)
			{
				int_5 = 0;
			}
			return gclass66_0;
		}

		public static byte[] smethod_17(string filename)
		{
			new GClass66();
			TextAsset textAsset = (TextAsset)Resources.Load(filename, typeof(TextAsset));
			if (((textAsset == null) ? true : false) || textAsset.bytes == null || false || textAsset.bytes.Length == 0 || 1 == 0)
			{
				throw new Exception("NULL POINTER EXCEPTION AT Image __createImage " + filename);
			}
			sbyte[] array = GClass84.smethod_2(textAsset.bytes);
			Debug.LogError("CHIEU DAI MANG BYTE IMAGE CREAT = " + array.Length);
			return textAsset.bytes;
		}

		private static GClass66 smethod_18(string string_1)
		{
			GClass66 gClass = new GClass66();
			Texture2D texture2D = Resources.Load(string_1) as Texture2D;
			if (texture2D == null && 0 == 0)
			{
				throw new Exception("NULL POINTER EXCEPTION AT Image __createImage " + string_1);
			}
			gClass.texture = texture2D;
			gClass.w = gClass.texture.width;
			gClass.h = gClass.texture.height;
			smethod_26(gClass);
			return gClass;
		}

		private static GClass66 smethod_19(GClass66 gclass66_2)
		{
			GClass66 gClass = new GClass66();
			Texture2D texture2D = gclass66_2.texture;
			_ = texture2D == null;
			gClass.texture = texture2D;
			gClass.w = gClass.texture.width;
			gClass.h = gClass.texture.height;
			smethod_26(gClass);
			return gClass;
		}

		private static GClass66 smethod_20(byte[] byte_1)
		{
			if (byte_1 != null && 0 == 0 && ((byte_1.Length != 0) ? true : false))
			{
				GClass66 gClass = new GClass66();
				try
				{
					gClass.texture.LoadImage(byte_1);
					gClass.w = gClass.texture.width;
					gClass.h = gClass.texture.height;
					smethod_26(gClass);
					return gClass;
				}
				catch (Exception)
				{
					return gClass;
				}
			}
			return null;
		}

		public static GClass66 smethod_21(GClass66 src, int x, int y, int w, int h, int transform)
		{
			GClass66 gClass = new GClass66();
			gClass.texture = new Texture2D(w, h);
			y = src.texture.height - y - h;
			for (int i = 0; i < w; i++)
			{
				for (int j = 0; j < h; j++)
				{
					int num = i;
					if (transform == 2)
					{
						num = w - i;
					}
					int num2 = j;
					gClass.texture.SetPixel(i, j, src.texture.GetPixel(x + num, y + num2));
				}
			}
			gClass.texture.Apply();
			gClass.w = gClass.texture.width;
			gClass.h = gClass.texture.height;
			smethod_26(gClass);
			return gClass;
		}

		private static GClass66 smethod_22()
		{
			return new GClass66();
		}

		public static GClass66 smethod_23(int w, int h)
		{
			GClass66 obj = new GClass66
			{
				texture = new Texture2D(w, h, TextureFormat.RGBA32, mipChain: false)
			};
			smethod_26(obj);
			obj.w = w;
			obj.h = h;
			obj.texture.Apply();
			return obj;
		}

		public static int smethod_24(GClass66 image)
		{
			return image.method_0();
		}

		public static int smethod_25(GClass66 image)
		{
			return image.method_1();
		}

		public int method_0()
		{
			return w;
		}

		public int method_1()
		{
			return h;
		}

		private static void smethod_26(GClass66 gclass66_2)
		{
			smethod_27(gclass66_2.texture);
		}

		public static void smethod_27(Texture2D texture)
		{
			texture.anisoLevel = 0;
			texture.filterMode = FilterMode.Point;
			texture.mipMapBias = 0f;
			texture.wrapMode = TextureWrapMode.Clamp;
		}
	}
}
