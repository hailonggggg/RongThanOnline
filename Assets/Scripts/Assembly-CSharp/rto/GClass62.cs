using System;
using System.Text;

namespace rto
{
	public class GClass62
	{
		private sbyte[] buffer;

		private int posRead;

		private int posMark;

		public GClass62()
		{
		}

		public GClass62(sbyte[] data)
		{
			buffer = data;
		}

		public sbyte method_0()
		{
			if (posRead >= buffer.Length)
			{
				posRead = buffer.Length;
				throw new Exception(" loi doc sbyte eof ");
			}
			return buffer[posRead++];
		}

		public void method_1(int readlimit)
		{
			posMark = posRead;
		}

		public void method_2()
		{
			posRead = posMark;
		}

		public byte method_3()
		{
			return smethod_0(method_0());
		}

		public short method_4()
		{
			short num = 0;
			for (int i = 0; i < 2; i++)
			{
				num <<= 8;
				num |= (short)(0xFF & buffer[posRead++]);
			}
			return num;
		}

		public ushort method_5()
		{
			ushort num = 0;
			for (int i = 0; i < 2; i++)
			{
				num <<= 8;
				num |= (ushort)(0xFFu & (uint)buffer[posRead++]);
			}
			return num;
		}

		public int method_6()
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				num <<= 8;
				num |= 0xFF & buffer[posRead++];
			}
			return num;
		}

		public long method_7()
		{
			long num = 0L;
			for (int i = 0; i < 8; i++)
			{
				num <<= 8;
				num |= 0xFF & buffer[posRead++];
			}
			return num;
		}

		public bool method_8()
		{
			return method_0() > 0;
		}

		private string method_9()
		{
			short num = method_4();
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = smethod_0(method_0());
			}
			return new UTF8Encoding().GetString(array);
		}

		private string method_10()
		{
			short num = method_4();
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = smethod_0(method_0());
			}
			return new UTF8Encoding().GetString(array);
		}

		public string method_11()
		{
			return method_10();
		}

		private int method_12()
		{
			if (posRead < buffer.Length)
			{
				return method_0();
			}
			return -1;
		}

		public int method_13(ref sbyte[] data)
		{
			if (data == null || 1 == 0)
			{
				return 0;
			}
			int num = 0;
			int num2 = 0;
			while (true)
			{
				if (num2 < data.Length)
				{
					data[num2] = method_0();
					if (posRead > buffer.Length)
					{
						break;
					}
					num++;
					num2++;
					continue;
				}
				return num;
			}
			return -1;
		}

		public void method_14(ref sbyte[] data)
		{
			if (data != null && 0 == 0 && data.Length + posRead <= buffer.Length)
			{
				for (int i = 0; i < data.Length; i++)
				{
					data[i] = method_0();
				}
			}
		}

		public int method_15()
		{
			return buffer.Length - posRead;
		}

		public static byte smethod_0(sbyte var)
		{
			if (var > 0)
			{
				return (byte)var;
			}
			return (byte)(var + 256);
		}

		public static byte[] smethod_1(sbyte[] var)
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

		public void method_16()
		{
			buffer = null;
		}

		public void method_17(ref sbyte[] data, int arg1, int arg2)
		{
			if (data == null || 1 == 0)
			{
				return;
			}
			for (int i = 0; i < arg2; i++)
			{
				data[i + arg1] = method_0();
				if (posRead > buffer.Length)
				{
					break;
				}
			}
		}
	}
}
