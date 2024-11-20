//using System;
//using System.Security.Cryptography;

//namespace rto
//{
//	internal sealed class Class2 : ICryptoTransform, IDisposable
//	{
//		private Random random_0;

//		bool ICryptoTransform.CanReuseTransform => true;

//		bool ICryptoTransform.CanTransformMultipleBlocks => true;

//		int ICryptoTransform.InputBlockSize => 16;

//		int ICryptoTransform.OutputBlockSize => 16;
//		public void Dispose() { }
//		public Class2()
//		{
//			random_0 = new Random(DateTime.Now.Millisecond);
//			LegalKeySizesValue = new KeySizes[1]
//			{
//				new KeySizes(128, 128, 0)
//			};
//			KeySize = 128;
//			LegalBlockSizesValue = new KeySizes[1]
//			{
//				new KeySizes(128, 128, 0)
//			};
//			BlockSize = 128;
//		}

//		ICryptoTransform AlgorithmCreateEncryptor(byte[] rgbKey, byte[] rgbIV)
//		{
//			rgbKey.CopyTo(Key, 0);
//			rgbIV.CopyTo(IV, 0);
//			return this;
//		}

//		ICryptoTransform AlgorithmCreateDecryptor(byte[] rgbKey, byte[] rgbIV)
//		{
//			rgbKey.CopyTo(Key, 0);
//			rgbIV.CopyTo(IV, 0);
//			return this;
//		}

//		void AlgorithmGenerateIV()
//		{
//			byte[] array = new byte[16];
//			random_0.NextBytes(array);
//			IV = array;
//		}

//		void AlgorithmGenerateKey()
//		{
//			byte[] array = new byte[16];
//			random_0.NextBytes(array);
//			Key = array;
//		}

//		int ICryptoTransform.TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
//		{
//			int num = Key.Length;
//			int num2 = IV.Length;
//			for (int i = 0; i < inputCount; i++)
//			{
//				int num3 = IV[i % num2];
//				outputBuffer[i + outputOffset] = (byte)(inputBuffer[i + inputOffset] ^ Key[num3 % num]);
//			}
//			return inputCount;
//		}

//		byte[] ICryptoTransform.TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
//		{
//			byte[] array = new byte[inputCount];
//			((ICryptoTransform)this).TransformBlock(inputBuffer, inputOffset, inputCount, array, 0);
//			return array;
//		}
//	}
//}
