using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace rto
{
	internal class Class3
	{
		static Class3()
		{
		}

		public static Stream smethod_0(Stream stream_0)
		{
			BinaryReader binaryReader = new BinaryReader(stream_0);
			int num = binaryReader.ReadUInt16();
			byte[] array = new byte[num];
			binaryReader.Read(array, 0, num);
			int num2 = binaryReader.ReadByte();
			byte[] array2 = new byte[num2];
			binaryReader.Read(array2, 0, array2.Length);
			for (int i = 0; i < num; i++)
			{
				array[i] ^= array2[i % num2];
			}
			byte b = 0;
			SymmetricAlgorithm symmetricAlgorithm = null;
			BinaryReader binaryReader2 = new BinaryReader(new MemoryStream(array, writable: false));
			try
			{
				binaryReader2.ReadString();
				b = binaryReader2.ReadByte();
				byte byte_ = binaryReader2.ReadByte();
				byte b2 = binaryReader2.ReadByte();
				int num3 = binaryReader2.ReadByte();
				byte[] array3 = new byte[num3];
				binaryReader2.Read(array3, 0, num3);
				if (b2 < 64)
				{
					binaryReader2.Read(array3, 0, num3);
				}
				else
				{
					byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
					if (publicKey == null || 1 == 0)
					{
						throw new InvalidOperationException();
					}
					Buffer.BlockCopy(publicKey, b2 + 12, array3, 0, num3);
				}
				symmetricAlgorithm = smethod_1(byte_);
				symmetricAlgorithm.IV = array2;
				symmetricAlgorithm.Key = array3;
			}
			finally
			{
				if (binaryReader2 != null && 0 == 0)
				{
					((IDisposable)binaryReader2).Dispose();
				}
			}
			MemoryStream memoryStream = new MemoryStream();
			if ((b & 2u) != 0 && 0 == 0)
			{
				CryptoStream cryptoStream = new CryptoStream(binaryReader.BaseStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Read);
				try
				{
					smethod_2(cryptoStream, memoryStream);
				}
				finally
				{
					if (cryptoStream != null && 0 == 0)
					{
						((IDisposable)cryptoStream).Dispose();
					}
				}
				if (((uint)b & (true ? 1u : 0u)) != 0 && 0 == 0)
				{
					memoryStream.Position = 0L;
					MemoryStream memoryStream2 = new MemoryStream();
					Class9.smethod_0(memoryStream, memoryStream2);
					memoryStream = memoryStream2;
				}
			}
			else if (b == 1)
			{
				Class9.smethod_0(binaryReader.BaseStream, memoryStream);
			}
			else
			{
				smethod_2(binaryReader.BaseStream, memoryStream);
			}
			memoryStream.Position = 0L;
			return memoryStream;
		}

		public static SymmetricAlgorithm smethod_1(byte byte_0)
		{
			string text = null;
			switch (byte_0)
			{
			case 1:
				text = "DES";
				goto default;
			case 2:
				text = "Aes";
				goto default;
			case 3:
				text = "TripleDES";
				goto default;
			case 4:
				text = "Rijndael";
				goto default;
			case 5:
				text = "RC2";
				goto default;
			default:
			{
				string text2 = "System.Security.Cryptography." + text;
				object type = Type.GetType(text2, throwOnError: false);
				if (type == null || 1 == 0)
				{
					type = Type.GetType(text2 + ", System.Security.Cryptography.Algorithms", throwOnError: false);
				}
				if (type == null || 1 == 0)
				{
					throw new InvalidOperationException($"Could not load type {text2}");
				}
				return (SymmetricAlgorithm)((Type)type).InvokeMember("Create", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
			}

			}
		}

		public static void smethod_2(Stream stream_0, Stream stream_1)
		{
			byte[] array = new byte[4096];
			while (true)
			{
				int num = stream_0.Read(array, 0, array.Length);
				if (num > 0)
				{
					stream_1.Write(array, 0, num);
					continue;
				}
				break;
			}
		}
	}
}
