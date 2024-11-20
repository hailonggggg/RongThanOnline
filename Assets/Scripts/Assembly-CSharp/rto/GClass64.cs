using System;
using System.IO;
using System.Threading;
using UnityEngine;

namespace rto
{
	public class GClass64
	{
		public static int int_0;

		public static sbyte[] sbyte_0;

		public static string string_0;

		private const int int_1 = 5;

		private const int int_2 = 500;

		public static void smethod_0(string filename, sbyte[] data)
		{
			if (Thread.CurrentThread.Name == Main.string_0 && 0 == 0)
			{
				smethod_11(filename, data);
			}
			else
			{
				smethod_5(filename, data);
			}
		}

		public static sbyte[] smethod_1(string filename)
		{
			if (Thread.CurrentThread.Name == Main.string_0 && 0 == 0)
			{
				return smethod_12(filename);
			}
			return smethod_6(filename);
		}

		public static string smethod_2(string fileName)
		{
			sbyte[] array = smethod_1(fileName);
			if (array == null || 1 == 0)
			{
				return null;
			}
			GClass59 gClass = new GClass59(array);
			try
			{
				string result = gClass.method_6();
				gClass.method_4();
				return result;
			}
			catch (Exception)
			{
			}
			return null;
		}

		public static byte[] smethod_3(sbyte[] var)
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

		public static void smethod_4(string filename, string data)
		{
			GClass60 gClass = new GClass60();
			try
			{
				gClass.method_6(data);
				smethod_0(filename, gClass.method_3());
				gClass.method_4();
			}
			catch (Exception)
			{
			}
		}

		private static void smethod_5(string string_1, sbyte[] sbyte_1)
		{
			if (int_0 != 0 && 0 == 0)
			{
				Debug.LogError("Cannot save RMS " + string_1 + " because current is saving " + string_0);
				return;
			}
			string_0 = string_1;
			sbyte_0 = sbyte_1;
			int_0 = 2;
			int i;
			for (i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_0 == 0)
				{
					break;
				}
			}
			if (i == 500)
			{
				Debug.LogError("TOO LONG TO SAVE RMS " + string_1);
			}
		}

		private static sbyte[] smethod_6(string string_1)
		{
			if (int_0 != 0 && 0 == 0)
			{
				Debug.LogError("Cannot load RMS " + string_1 + " because current is loading " + string_0);
				return null;
			}
			string_0 = string_1;
			sbyte_0 = null;
			int_0 = 3;
			int i;
			for (i = 0; i < 500; i++)
			{
				Thread.Sleep(5);
				if (int_0 == 0)
				{
					break;
				}
			}
			if (i == 500)
			{
				Debug.LogError("TOO LONG TO LOAD RMS " + string_1);
			}
			return sbyte_0;
		}

		public static void smethod_7()
		{
			if (int_0 == 2)
			{
				int_0 = 1;
				smethod_11(string_0, sbyte_0);
				int_0 = 0;
			}
			else if (int_0 == 3)
			{
				int_0 = 1;
				sbyte_0 = smethod_12(string_0);
				int_0 = 0;
			}
		}

		public static int smethod_8(string file)
		{
			sbyte[] array = smethod_1(file);
			if (array == null || 1 == 0)
			{
				return -1;
			}
			return array[0];
		}

		public static void smethod_9(string file, int x)
		{
			try
			{
				smethod_0(file, new sbyte[1] { (sbyte)x });
			}
			catch (Exception)
			{
			}
		}

		public static string smethod_10()
		{
			return Application.persistentDataPath;
		}

		private static void smethod_11(string string_1, sbyte[] sbyte_1)
		{
			FileStream fileStream = new FileStream(smethod_10() + "/" + string_1, FileMode.Create);
			fileStream.Write(GClass84.smethod_18(sbyte_1), 0, sbyte_1.Length);
			fileStream.Flush();
			fileStream.Close();
		}

		private static sbyte[] smethod_12(string string_1)
		{
			try
			{
				FileStream fileStream = new FileStream(smethod_10() + "/" + string_1, FileMode.Open);
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Close();
				GClass84.smethod_17(array);
				return GClass84.smethod_17(array);
			}
			catch (Exception)
			{
				return null;
			}
		}

		public static string smethod_13(byte[] ba)
		{
			return BitConverter.ToString(ba).Replace("-", string.Empty);
		}

		public static byte[] smethod_14(string hex)
		{
			int length = hex.Length;
			byte[] array = new byte[length / 2];
			for (int i = 0; i < length; i += 2)
			{
				array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
			}
			return array;
		}

		public static void smethod_15(string name)
		{
			try
			{
				PlayerPrefs.DeleteKey(name);
			}
			catch (Exception)
			{
			}
		}
	}
}
