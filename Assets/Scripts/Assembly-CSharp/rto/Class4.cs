using System;

namespace rto
{
	internal sealed class Class4
	{
		private sealed class Class5
		{
			internal static int[] smethod_0(int[] int_0, int int_1)
			{
				int[] array = new int[int_0.Length];
				int[] array2 = new int[int_0.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = i;
				}
				Array.Copy(int_0, array2, int_0.Length);
				Array.Sort(array2, array);
				int j;
				for (j = 0; j < array2.Length && array2[j] == 0; j++)
				{
				}
				int[] array3 = new int[array2.Length - j];
				Array.Copy(array2, j, array3, 0, array3.Length);
				int[] array4 = ((array3.Length == 0 || 1 == 0) ? new int[0] : ((array3.Length != 1) ? smethod_1(array3, int_1) : new int[1] { 1 }));
				int[] array5 = new int[int_0.Length];
				for (int k = 0; k < array4.Length; k++)
				{
					array5[array[k + j]] = array4[k];
				}
				return array5;
			}

			private static int[] smethod_1(int[] int_0, int int_1)
			{
				int num = int_0.Length;
				int[][] array = new int[int_1][];
				array[0] = int_0;
				int[] array2 = new int[int_0.Length / 2];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = int_0[i * 2] + int_0[i * 2 + 1];
				}
				for (int j = 1; j < int_1; j++)
				{
					int[] array3 = (array[j] = smethod_2(array2, int_0));
					array2 = new int[array3.Length / 2];
					for (int k = 0; k < array2.Length; k++)
					{
						array2[k] = array3[k * 2] + array3[k * 2 + 1];
					}
				}
				int[] array4 = new int[num];
				int num2 = num - 1;
				for (int num3 = int_1 - 1; num3 >= 0; num3--)
				{
					int[] array5 = array[num3];
					int num4 = 0;
					int num5 = 0;
					for (int l = 0; l < num2 * 2; l++)
					{
						if (num5 < int_0.Length && int_0[num5] == array5[l])
						{
							array4[num5]++;
							num5++;
						}
						else
						{
							num4++;
						}
					}
					num2 = num4;
				}
				return array4;
			}

			private static int[] smethod_2(int[] int_0, int[] int_1)
			{
				int[] array = new int[int_0.Length + int_1.Length];
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				while (num < int_0.Length && num2 < int_1.Length)
				{
					if (int_0[num] >= int_1[num2])
					{
						array[num3++] = int_1[num2++];
					}
					else
					{
						array[num3++] = int_0[num++];
					}
				}
				while (num < int_0.Length)
				{
					array[num3++] = int_0[num++];
				}
				while (num2 < int_1.Length)
				{
					array[num3++] = int_1[num2++];
				}
				return array;
			}
		}

		private struct Struct16
		{
			internal Struct17 struct17_0;

			internal ushort ushort_0;
		}

		internal static Struct17[] struct17_0;

		internal static Struct17[] struct17_1;

		internal static Class8 class8_0;

		internal static readonly int[] int_0;

		internal static readonly int[] int_1;

		internal static readonly int[] int_2;

		internal static readonly int[] int_3;

		internal static readonly int[] int_4;

		static Class4()
		{
			struct17_0 = new Struct17[288];
			struct17_1 = new Struct17[32];
			int_0 = new int[19];
			int_0[0] = 16;
			int_0[1] = 17;
			int_0[2] = 18;
			int_0[4] = 8;
			int_0[5] = 7;
			int_0[6] = 9;
			int_0[7] = 6;
			int_0[8] = 10;
			int_0[9] = 5;
			int_0[10] = 11;
			int_0[11] = 4;
			int_0[12] = 12;
			int_0[13] = 3;
			int_0[14] = 13;
			int_0[15] = 2;
			int_0[16] = 14;
			int_0[17] = 1;
			int_0[18] = 15;
			int_1 = new int[29];
			int_1[0] = 3;
			int_1[1] = 4;
			int_1[2] = 5;
			int_1[3] = 6;
			int_1[4] = 7;
			int_1[5] = 8;
			int_1[6] = 9;
			int_1[7] = 10;
			int_1[8] = 11;
			int_1[9] = 13;
			int_1[10] = 15;
			int_1[11] = 17;
			int_1[12] = 19;
			int_1[13] = 23;
			int_1[14] = 27;
			int_1[15] = 31;
			int_1[16] = 35;
			int_1[17] = 43;
			int_1[18] = 51;
			int_1[19] = 59;
			int_1[20] = 67;
			int_1[21] = 83;
			int_1[22] = 99;
			int_1[23] = 115;
			int_1[24] = 131;
			int_1[25] = 163;
			int_1[26] = 195;
			int_1[27] = 227;
			int_1[28] = 258;
			int_2 = new int[29];
			int i = 8;
			int num = 0;
			for (; i < 28; i++)
			{
				if (i % 4 == 0)
				{
					num++;
				}
				int_2[i] = num;
			}
			int_3 = new int[30];
			int_3[0] = 1;
			int_3[1] = 2;
			int_3[2] = 3;
			int_3[3] = 4;
			int_3[4] = 5;
			int_3[5] = 7;
			int_3[6] = 9;
			int_3[7] = 13;
			int_3[8] = 17;
			int_3[9] = 25;
			int_3[10] = 33;
			int_3[11] = 49;
			int_3[12] = 65;
			int_3[13] = 97;
			int_3[14] = 129;
			int_3[15] = 193;
			int_3[16] = 257;
			int_3[17] = 385;
			int_3[18] = 513;
			int_3[19] = 769;
			int_3[20] = 1025;
			int_3[21] = 1537;
			int_3[22] = 2049;
			int_3[23] = 3073;
			int_3[24] = 4097;
			int_3[25] = 6145;
			int_3[26] = 8193;
			int_3[27] = 12289;
			int_3[28] = 16385;
			int_3[29] = 24577;
			int_4 = new int[30];
			int j = 4;
			int num2 = 0;
			for (; j < 30; j++)
			{
				if (j % 2 == 0)
				{
					num2++;
				}
				int_4[j] = num2;
			}
			for (int k = 0; k <= 143; k++)
			{
				struct17_0[k].int_0 = 48 + k;
				struct17_0[k].int_1 = 8;
			}
			for (int l = 144; l <= 255; l++)
			{
				struct17_0[l].int_0 = 400 + l - 144;
				struct17_0[l].int_1 = 9;
			}
			for (int m = 256; m <= 279; m++)
			{
				struct17_0[m].int_0 = m - 256;
				struct17_0[m].int_1 = 7;
			}
			for (int n = 280; n <= 287; n++)
			{
				struct17_0[n].int_0 = 192 + n - 280;
				struct17_0[n].int_1 = 8;
			}
			for (int num3 = 0; num3 <= 31; num3++)
			{
				struct17_1[num3].int_0 = num3;
				struct17_1[num3].int_1 = 5;
			}
			class8_0 = smethod_4(struct17_0, struct17_1);
		}

		internal static int smethod_0(int[] int_5, int[] int_6)
		{
			int num = 0;
			for (int i = 0; i < int_5.Length; i++)
			{
				num += int_5[i] * int_6[i];
			}
			return num;
		}

		internal static int smethod_1(int[] int_5, int[] int_6)
		{
			int num = 0;
			for (int i = 0; i < int_5.Length; i++)
			{
				num += int_5[i] * struct17_0[i].int_1;
			}
			for (int j = 0; j < int_6.Length; j++)
			{
				num += int_6[j] * struct17_1[j].int_1;
			}
			return num;
		}

		internal static Struct17[] smethod_2(int[] int_5)
		{
			Struct17[] array = new Struct17[int_5.Length];
			for (int i = 0; i < int_5.Length; i++)
			{
				array[i].int_1 = int_5[i];
			}
			smethod_3(array);
			return array;
		}

		internal static void smethod_3(Struct17[] struct17_2)
		{
			int num = struct17_2[0].int_1;
			for (int i = 1; i < struct17_2.Length; i++)
			{
				if (num < struct17_2[i].int_1)
				{
					num = struct17_2[i].int_1;
				}
			}
			int[] array = new int[num + 1];
			for (int j = 0; j < struct17_2.Length; j++)
			{
				array[struct17_2[j].int_1]++;
			}
			int[] array2 = new int[num + 1];
			int num2 = 0;
			array[0] = 0;
			for (int k = 1; k <= num; k++)
			{
				num2 = (array2[k] = num2 + array[k - 1] << 1);
			}
			for (int l = 0; l < struct17_2.Length; l++)
			{
				int num3 = struct17_2[l].int_1;
				if (num3 != 0 && 0 == 0)
				{
					struct17_2[l].int_0 = array2[num3];
					array2[num3]++;
				}
			}
		}

		internal static Class8 smethod_4(Struct17[] struct17_2, Struct17[] struct17_3)
		{
			return new Class8
			{
				class7_0 = smethod_5(struct17_2),
				class7_1 = smethod_5(struct17_3)
			};
		}

		internal static Class7 smethod_5(Struct17[] struct17_2)
		{
			Struct16[] array = new Struct16[struct17_2.Length];
			int int_ = 0;
			for (int i = 0; i < struct17_2.Length; i++)
			{
				if (struct17_2[i].int_1 > 0)
				{
					Struct16 @struct = default(Struct16);
					@struct.struct17_0 = struct17_2[i];
					@struct.ushort_0 = (ushort)i;
					array[int_++] = @struct;
				}
			}
			return smethod_6(array, int_, 0, 0);
		}

		private static Class7 smethod_6(Struct16[] struct16_0, int int_5, int int_6, int int_7)
		{
			Struct16[] array = new Struct16[int_5];
			Struct16[] array2 = new Struct16[int_5];
			Class7 @class = new Class7();
			@class.bool_0 = false;
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < int_5; i++)
			{
				Struct16 @struct = struct16_0[i];
				if (@struct.struct17_0.int_1 == int_7 && @struct.struct17_0.int_0 == int_6)
				{
					@class.bool_0 = true;
					@class.ushort_0 = @struct.ushort_0;
				}
				else if (((uint)(@struct.struct17_0.int_0 >> @struct.struct17_0.int_1 - int_7 - 1) & (true ? 1u : 0u)) != 0 && 0 == 0)
				{
					array2[num2++] = @struct;
				}
				else
				{
					array[num++] = @struct;
				}
			}
			if (!@class.bool_0 || 1 == 0)
			{
				if (num > 0)
				{
					@class.class7_0 = smethod_6(array, num, int_6 << 1, int_7 + 1);
				}
				if (num2 > 0)
				{
					@class.class7_1 = smethod_6(array2, num2, (int_6 << 1) | 1, int_7 + 1);
				}
			}
			return @class;
		}

		internal static void smethod_7(int int_5, out int int_6, out int int_7)
		{
			int_6 = int_1[int_5 - 257];
			int_7 = int_2[int_5 - 257];
		}

		internal static void smethod_8(int int_5, out int int_6, out int int_7, out int int_8)
		{
			int num = Array.BinarySearch(int_1, int_5);
			if (num < 0)
			{
				num = ~num - 1;
			}
			int_6 = num + 257;
			int_7 = int_5 - int_1[num];
			int_8 = int_2[num];
		}

		internal static void smethod_9(int int_5, out int int_6, out int int_7, out int int_8)
		{
			int num = Array.BinarySearch(int_3, int_5);
			if (num < 0)
			{
				num = ~num - 1;
			}
			int_6 = num;
			int_7 = int_5 - int_3[num];
			int_8 = int_4[num];
		}

		internal static int[] smethod_10(int[] int_5, int int_6)
		{
			return Class5.smethod_0(int_5, int_6);
		}

		internal static int[] smethod_11(int[] int_5)
		{
			return Class5.smethod_0(int_5, 15);
		}

		internal static int[] smethod_12(int[] int_5, int int_6, int int_7)
		{
			Class6 @class = new Class6();
			int num = 0;
			while (num < int_7)
			{
				if (int_5[int_6 + num] == 0 || 1 == 0)
				{
					int num2 = 0;
					do
					{
						num2++;
					}
					while (num + num2 < int_7 && num2 < 138 && int_5[int_6 + num + num2] == 0);
					if (num2 < 3)
					{
						if (num2 >= 1)
						{
							@class.method_0(0);
						}
						if (num2 >= 2)
						{
							@class.method_0(0);
						}
					}
					else if (num2 < 11)
					{
						@class.method_0(17);
						@class.method_0(num2 - 3);
					}
					else
					{
						@class.method_0(18);
						@class.method_0(num2 - 11);
					}
					num += num2;
				}
				else
				{
					int num3 = int_5[int_6 + num++];
					@class.method_0(num3);
					int i;
					for (i = 0; num + i < int_7 && i < 6 && int_5[int_6 + num + i] == num3; i++)
					{
					}
					if (i >= 3)
					{
						@class.method_0(16);
						@class.method_0(i - 3);
						num += i;
					}
				}
			}
			return @class.method_1();
		}
	}
}
