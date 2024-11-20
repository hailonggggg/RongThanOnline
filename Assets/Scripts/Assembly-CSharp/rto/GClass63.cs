using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace rto
{
	public class GClass63
	{
		public sbyte[] buffer = new sbyte[2048];

		private int posWrite;

		private int lenght = 2048;

		public void method_0(sbyte value)
		{
			method_21(0);
			buffer[posWrite++] = value;
		}

		public void method_1(sbyte value)
		{
			buffer[posWrite++] = value;
		}

		public void method_2(sbyte value)
		{
			method_0(value);
		}

		public void method_3(int value)
		{
			method_0((sbyte)value);
		}

		public void method_4(char value)
		{
			method_0(0);
			method_0((sbyte)value);
		}

		public void method_5(byte value)
		{
			method_0((sbyte)value);
		}

		public void method_6(byte[] value)
		{
			method_21(value.Length);
			for (int i = 0; i < value.Length; i++)
			{
				method_1((sbyte)value[i]);
			}
		}

		public void method_7(sbyte[] value)
		{
			method_21(value.Length);
			for (int i = 0; i < value.Length; i++)
			{
				method_1(value[i]);
			}
		}

		public void method_8(short value)
		{
			method_21(2);
			for (int num = 1; num >= 0; num--)
			{
				method_1((sbyte)(value >> num * 8));
			}
		}

		public void method_9(int value)
		{
			method_21(2);
			short num = (short)value;
			for (int num2 = 1; num2 >= 0; num2--)
			{
				method_1((sbyte)(num >> num2 * 8));
			}
		}

		public void method_10(ushort value)
		{
			method_21(2);
			for (int num = 1; num >= 0; num--)
			{
				method_1((sbyte)(value >> num * 8));
			}
		}

		public void method_11(int value)
		{
			method_21(4);
			for (int num = 3; num >= 0; num--)
			{
				method_1((sbyte)(value >> num * 8));
			}
		}

		public void method_12(long value)
		{
			method_21(8);
			for (int num = 7; num >= 0; num--)
			{
				method_1((sbyte)(value >> num * 8));
			}
		}

		public void method_13(bool value)
		{
			method_0((sbyte)((value ? true : false) ? 1 : 0));
		}

		public void method_14(bool value)
		{
			method_0((sbyte)((value ? true : false) ? 1 : 0));
		}

		private void method_15(string string_0)
		{
			char[] array = string_0.ToCharArray();
			method_8((short)array.Length);
			method_21(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				method_1((sbyte)array[i]);
			}
		}

		public void method_16(string value)
		{
			Encoding unicode = Encoding.Unicode;
			Encoding encoding = Encoding.GetEncoding(65001);
			byte[] bytes = unicode.GetBytes(value);
			byte[] array = Encoding.Convert(unicode, encoding, bytes);
			method_8((short)array.Length);
			method_21(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				sbyte value2 = (sbyte)array[i];
				method_1(value2);
			}
		}

		public void method_17(sbyte value)
		{
			method_0(value);
		}

		public void method_18(ref sbyte[] data, int arg1, int arg2)
		{
			if (data == null || 1 == 0)
			{
				return;
			}
			for (int i = 0; i < arg2; i++)
			{
				method_0(data[i + arg1]);
				if (posWrite > buffer.Length)
				{
					break;
				}
			}
		}

		public void method_19(sbyte[] value)
		{
			method_7(value);
		}

		public sbyte[] method_20()
		{
			if (posWrite <= 0)
			{
				return null;
			}
			sbyte[] array = new sbyte[posWrite];
			for (int i = 0; i < posWrite; i++)
			{
				array[i] = buffer[i];
			}
			return array;
		}

		public void method_21(int ltemp)
		{
			if (posWrite + ltemp > lenght)
			{
				sbyte[] array = new sbyte[lenght + 1024 + ltemp];
				for (int i = 0; i < lenght; i++)
				{
					array[i] = buffer[i];
				}
				buffer = null;
				buffer = array;
				lenght += 1024 + ltemp;
			}
		}

		private static void smethod_0(string[] string_0)
		{
			string path = string_0[0];
			string path2 = string_0[1];
			StreamReader streamReader = new StreamReader(path, Encoding.Unicode);
			try
			{
				StreamWriter streamWriter = new StreamWriter(path2, append: false, Encoding.UTF8);
				try
				{
					smethod_1(streamReader, streamWriter);
				}
				finally
				{
					if (streamWriter != null && 0 == 0)
					{
						((IDisposable)streamWriter).Dispose();
					}
				}
			}
			finally
			{
				if (streamReader != null && 0 == 0)
				{
					((IDisposable)streamReader).Dispose();
				}
			}
		}

		private static void smethod_1(TextReader textReader_0, TextWriter textWriter_0)
		{
			char[] array = new char[8192];
			int count;
			while (((count = textReader_0.Read(array, 0, array.Length)) != 0) ? true : false)
			{
				textWriter_0.Write(array, 0, count);
			}
			textWriter_0.Flush();
			Debug.Log(textWriter_0.ToString());
		}

		public byte method_22(sbyte var)
		{
			if (var > 0)
			{
				return (byte)var;
			}
			return (byte)(var + 256);
		}

		public byte[] method_23(sbyte[] var)
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

		public void method_24()
		{
			buffer = null;
		}
	}
}
