using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using UnityEngine;

namespace rto
{
	public class GClass65
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

			public static ThreadStart _003C_003E9__21_0;

			public static ThreadStart _003C_003E9__21_1;

			internal void method_0()
			{
				smethod_12();
			}

			internal void method_1()
			{
				smethod_16();
			}
		}

		private static NetworkStream networkStream_0;

		private static BinaryReader binaryReader_0;

		private static BinaryWriter binaryWriter_0;

		public static TcpClient tcpClient_0;

		public static bool bool_0;

		public static bool bool_1;

		public static Thread thread_0;

		public static Thread thread_1;

		public static Thread thread_2;

		private static bool bool_2;

		public static sbyte[] sbyte_0;

		private static sbyte sbyte_1;

		private static sbyte sbyte_2;

		private static string string_0;

		private static int int_0;

		public static List<GClass61> list_0;

		public static List<GClass61> list_1;

		public static bool bool_3;

		public static long long_0;

		static GClass65()
		{
			sbyte_0 = null;
			list_0 = new List<GClass61>();
			list_1 = new List<GClass61>();
		}

		private static void smethod_0()
		{
			bool_1 = true;
			Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Highest;
			bool_0 = true;
			try
			{
				smethod_2(string_0, int_0);
			}
			catch (Exception)
			{
				smethod_9();
			}
		}

		public static void smethod_1(string host, int port)
		{
			if ((!bool_0 || 1 == 0) && (!bool_1 || 1 == 0))
			{
				string_0 = host;
				int_0 = port;
				bool_2 = false;
				tcpClient_0 = null;
				thread_0 = new Thread(smethod_0);
				thread_0.Start();
			}
		}

		public static void smethod_2(string host, int port)
		{
			tcpClient_0 = new TcpClient();
			tcpClient_0.Connect(host, port);
			networkStream_0 = tcpClient_0.GetStream();
			binaryReader_0 = new BinaryReader(networkStream_0, new UTF8Encoding());
			binaryWriter_0 = new BinaryWriter(networkStream_0, new UTF8Encoding());
			ThreadStart threadStart = _003C_003Ec._003C_003E9__21_0;
			if (threadStart == null || 1 == 0)
			{
				threadStart = (_003C_003Ec._003C_003E9__21_0 = delegate
				{
					smethod_12();
				});
			}
			thread_2 = new Thread(threadStart);
			thread_2.Start();
			ThreadStart threadStart2 = _003C_003Ec._003C_003E9__21_1;
			if (threadStart2 == null || 1 == 0)
			{
				threadStart2 = (_003C_003Ec._003C_003E9__21_1 = delegate
				{
					smethod_16();
				});
			}
			thread_1 = new Thread(threadStart2);
			thread_1.Start();
			bool_1 = false;
			smethod_4(new GClass61(-128));
			bool_3 = true;
		}

		public static void smethod_3(GClass61 message)
		{
			list_1.Add(message);
		}

		private static void smethod_4(GClass61 gclass61_0)
		{
			try
			{
				sbyte[] array = gclass61_0.method_0();
				if (bool_2 && 0 == 0)
				{
					sbyte value = smethod_6(gclass61_0.command);
					binaryWriter_0.Write(value);
				}
				else
				{
					binaryWriter_0.Write(gclass61_0.command);
				}
				if (array != null && 0 == 0)
				{
					int num = array.Length;
					if (bool_2 && 0 == 0)
					{
						int num2 = smethod_6((sbyte)(num >> 8));
						binaryWriter_0.Write((sbyte)num2);
						int num3 = smethod_6((sbyte)(num & 0xFF));
						binaryWriter_0.Write((sbyte)num3);
					}
					else
					{
						binaryWriter_0.Write((ushort)num);
					}
					if (bool_2 && 0 == 0)
					{
						for (int i = 0; i < array.Length; i++)
						{
							sbyte value2 = smethod_6(array[i]);
							binaryWriter_0.Write(value2);
						}
					}
				}
				else if (bool_2 && 0 == 0)
				{
					int num4 = smethod_6(0);
					binaryWriter_0.Write((sbyte)num4);
					int num5 = smethod_6(0);
					binaryWriter_0.Write((sbyte)num5);
				}
				else
				{
					binaryWriter_0.Write((ushort)0);
				}
				binaryWriter_0.Flush();
			}
			catch
			{
			}
		}

		public static sbyte smethod_5(sbyte b)
		{
			sbyte result = (sbyte)((sbyte_0[sbyte_1++] & 0xFF) ^ (b & 0xFF));
			if (sbyte_1 >= sbyte_0.Length)
			{
				sbyte_1 %= (sbyte)sbyte_0.Length;
			}
			return result;
		}

		public static sbyte smethod_6(sbyte b)
		{
			sbyte result = (sbyte)((sbyte_0[sbyte_2++] & 0xFF) ^ (b & 0xFF));
			if (sbyte_2 >= sbyte_0.Length)
			{
				sbyte_2 %= (sbyte)sbyte_0.Length;
			}
			return result;
		}

		public static void smethod_7(GClass61 msg)
		{
			if (Thread.CurrentThread.Name == Main.string_0 && 0 == 0)
			{
				GClass81.smethod_0(msg);
			}
			else
			{
				list_0.Add(msg);
			}
		}

		public static void smethod_8()
		{
			while (list_0.Count > 0)
			{
				GClass61 gClass = list_0[0];
				if (!GClass81.bool_0 || 1 == 0)
				{
					if (gClass != null && 0 == 0)
					{
						GClass81.smethod_0(gClass);
					}
					list_0.RemoveAt(0);
					continue;
				}
				break;
			}
		}

		public static void smethod_9()
		{
			smethod_11();
		}

		public static bool smethod_10()
		{
			return bool_0;
		}

		private static void smethod_11()
		{
			sbyte_0 = null;
			sbyte_1 = 0;
			sbyte_2 = 0;
			try
			{
				bool_0 = false;
				bool_1 = false;
				if (tcpClient_0 != null && 0 == 0)
				{
					tcpClient_0.Close();
					tcpClient_0 = null;
				}
				if (networkStream_0 != null && 0 == 0)
				{
					networkStream_0.Close();
					networkStream_0 = null;
				}
				if (binaryWriter_0 != null && 0 == 0)
				{
					binaryWriter_0.Close();
					binaryWriter_0 = null;
				}
				if (binaryReader_0 != null && 0 == 0)
				{
					binaryReader_0.Close();
					binaryReader_0 = null;
				}
				thread_2 = null;
				thread_1 = null;
			}
			catch
			{
			}
		}

		public static void smethod_12()
		{
			while (bool_0 ? true : false)
			{
				try
				{
					if (bool_2 && 0 == 0)
					{
						while (list_1.Count > 0)
						{
							smethod_4(list_1[0]);
							list_1.RemoveAt(0);
						}
					}
					Thread.Sleep(5);
				}
				catch
				{
				}
			}
		}

		public static int smethod_13()
		{
			return Environment.TickCount;
		}

		public static byte smethod_14(sbyte var)
		{
			if (var > 0)
			{
				return (byte)var;
			}
			return (byte)(var + 256);
		}

		public static byte[] smethod_15(sbyte[] var)
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

		public static void smethod_16()
		{
			try
			{
				while (bool_0 ? true : false)
				{
					GClass61 gClass = smethod_19();
					if (gClass == null)
					{
						break;
					}
					try
					{
						if (gClass.command == sbyte.MinValue)
						{
							smethod_17(gClass);
						}
						else
						{
							smethod_7(gClass);
						}
					}
					catch (Exception)
					{
					}
					Thread.Sleep(5);
				}
			}
			catch
			{
			}
			if (bool_0 && true && tcpClient_0 != null && 0 == 0)
			{
				smethod_11();
			}
		}

		private static void smethod_17(GClass61 gclass61_0)
		{
			try
			{
				sbyte b = gclass61_0.method_1().method_0();
				sbyte_0 = new sbyte[b];
				for (int i = 0; i < b; i++)
				{
					sbyte_0[i] = gclass61_0.method_1().method_0();
				}
				for (int j = 0; j < sbyte_0.Length - 1; j++)
				{
					sbyte_0[j + 1] ^= sbyte_0[j];
				}
				bool_2 = true;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
		}

		private static GClass61 smethod_18(sbyte sbyte_3)
		{
			int num = smethod_5(binaryReader_0.ReadSByte()) + 128;
			int num2 = smethod_5(binaryReader_0.ReadSByte()) + 128;
			int num3 = ((smethod_5(binaryReader_0.ReadSByte()) + 128) * 256 + num2) * 256 + num;
			sbyte[] array = new sbyte[num3];
			Buffer.BlockCopy(binaryReader_0.ReadBytes(num3), 0, array, 0, num3);
			if (bool_2 && 0 == 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = smethod_5(array[i]);
				}
			}
			return new GClass61(sbyte_3, array);
		}

		private static GClass61 smethod_19()
		{
			try
			{
				sbyte b = binaryReader_0.ReadSByte();
				if (bool_2 && 0 == 0)
				{
					b = smethod_5(b);
				}
				if (b == -127)
				{
					return smethod_18(b);
				}
				int num;
				if (bool_2 && 0 == 0)
				{
					sbyte b2 = binaryReader_0.ReadSByte();
					sbyte b3 = binaryReader_0.ReadSByte();
					num = ((smethod_5(b2) & 0xFF) << 8) | (smethod_5(b3) & 0xFF);
				}
				else
				{
					sbyte num2 = binaryReader_0.ReadSByte();
					sbyte b4 = binaryReader_0.ReadSByte();
					num = (num2 & 0xFF00) | (b4 & 0xFF);
				}
				sbyte[] array = new sbyte[num];
				Buffer.BlockCopy(binaryReader_0.ReadBytes(num), 0, array, 0, num);
				if (bool_2 && 0 == 0)
				{
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = smethod_5(array[i]);
					}
				}
				return new GClass61(b, array);
			}
			catch
			{
			}
			return null;
		}
	}
}
