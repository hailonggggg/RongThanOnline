using System;
using System.Threading;
using UnityEngine;

namespace rto
{
	public class GClass59
	{
		public GClass62 r;

		private const int int_0 = 5;

		private const int int_1 = 500;

		public static GClass59 gclass59_0;

		private static int int_2;

		private static string string_0;

		public GClass59(string filename)
		{
			TextAsset textAsset = (TextAsset)Resources.Load(filename, typeof(TextAsset));
			r = new GClass62(GClass84.smethod_17(textAsset.bytes));
		}

		public GClass59(sbyte[] data)
		{
			r = new GClass62(data);
		}

		public static void smethod_0()
		{
			if (int_2 == 2)
			{
				int_2 = 1;
				gclass59_0 = smethod_3(string_0);
				int_2 = 0;
			}
		}

		public static GClass59 smethod_1(string filename)
		{
			return smethod_3(filename);
		}

		private static GClass59 smethod_2(string string_1)
		{
			if (int_2 != 0 && 0 == 0)
			{
				for (int i = 0; i < 500; i++)
				{
					Thread.Sleep(5);
					if (int_2 == 0)
					{
						break;
					}
				}
				if (int_2 != 0 && 0 == 0)
				{
					Debug.LogError("CANNOT GET INPUTSTREAM " + string_1 + " WHEN GETTING " + string_0);
					return null;
				}
			}
			gclass59_0 = null;
			string_0 = string_1;
			int_2 = 2;
			int j;
			for (j = 0; j < 500; j++)
			{
				Thread.Sleep(5);
				if (int_2 == 0)
				{
					break;
				}
			}
			if (j == 500)
			{
				Debug.LogError("TOO LONG FOR CREATE INPUTSTREAM " + string_1);
				int_2 = 0;
				return null;
			}
			return gclass59_0;
		}

		private static GClass59 smethod_3(string string_1)
		{
			try
			{
				return new GClass59(string_1);
			}
			catch (Exception)
			{
				return null;
			}
		}

		public short method_0()
		{
			return r.method_4();
		}

		public int method_1()
		{
			return r.method_6();
		}

		public int method_2()
		{
			return r.method_3();
		}

		public void method_3(ref sbyte[] data)
		{
			r.method_13(ref data);
		}

		public void method_4()
		{
			r.method_16();
		}

		public void method_5()
		{
			r.method_16();
		}

		public string method_6()
		{
			return r.method_11();
		}

		public sbyte method_7()
		{
			return r.method_0();
		}

		public long method_8()
		{
			return r.method_7();
		}

		public bool method_9()
		{
			return r.method_8();
		}

		public int method_10()
		{
			return (byte)r.method_0();
		}

		public int method_11()
		{
			return r.method_5();
		}

		public void method_12(ref sbyte[] data)
		{
			r.method_13(ref data);
		}

		public int method_13()
		{
			return r.method_15();
		}

		internal void method_14(ref sbyte[] sbyte_0, int int_3, int int_4)
		{
			throw new NotImplementedException();
		}
	}
}
