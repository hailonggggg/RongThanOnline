using System.Threading;
using UnityEngine;

namespace rto
{
	public class GClass43
	{
		public static int int_0 = 0;

		public static int int_1 = 1;

		public static int int_2 = 2;

		public static int int_3 = 3;

		public static int int_4 = 4;

		public static int int_5 = 5;

		public static int int_6 = 6;

		public static int int_7 = 7;

		public static int int_8 = 8;

		public static int int_9 = 9;

		public static int int_10 = 10;

		public static int int_11 = 11;

		public static int int_12 = 12;

		public static int int_13 = 13;

		public static int int_14 = 14;

		public static int int_15 = 15;

		public static int int_16 = 16;

		public static int int_17 = 17;

		public static int int_18 = 18;

		public static int int_19 = 19;

		public static int int_20 = 20;

		public static int int_21 = 21;

		public static int int_22 = 22;

		public static int int_23 = 23;

		public static int int_24 = 24;

		public static int int_25 = 25;

		public static int int_26 = 26;

		public static AudioClip audioClip_0;

		public static GameObject[] gameObject_0;

		public static AudioClip[] audioClip_1;

		public static GameObject gameObject_1;

		public static int int_27;

		public static int int_28;

		public static int int_29;

		private static string string_0;

		private static float float_0;

		public static bool bool_0 = true;

		public static bool bool_1;

		public static void smethod_0()
		{
			audioClip_0 = (AudioClip)Resources.Load("Sounds/train", typeof(AudioClip));
			gameObject_1 = GameObject.Find("Main Camera").AddComponent<AudioSource>().gameObject;
			gameObject_0 = new GameObject[27];
			audioClip_1 = new AudioClip[gameObject_0.Length];
			for (int i = 0; i < gameObject_0.Length; i++)
			{
				smethod_29("Sounds/" + i, i);
			}
		}

		public static void smethod_1()
		{
			smethod_36(int_4, 0.5f);
		}

		public static void smethod_2(float volumn)
		{
			smethod_36(int_1, volumn / 2f);
		}

		public static void smethod_3()
		{
			smethod_36(int_1, 0.3f);
		}

		public static void smethod_4()
		{
			smethod_36(int_1, 0.1f);
		}

		public static void smethod_5(bool isKick)
		{
			int num = GClass84.smethod_8(0, 3);
			if (isKick && 0 == 0)
			{
				smethod_36(((num != 0) ? true : false) ? int_3 : int_7, 1f);
			}
			else
			{
				smethod_36(((num != 0) ? true : false) ? int_2 : int_6, 1f);
			}
		}

		public static void smethod_6()
		{
			smethod_36(int_5, 0.5f);
		}

		public static void smethod_7()
		{
			smethod_36(int_23, 0.5f);
		}

		public static void smethod_8()
		{
			smethod_36(int_24, 0.5f);
		}

		public static void smethod_9()
		{
			smethod_36(int_23, 0.5f);
		}

		public static void smethod_10()
		{
			smethod_36(int_8, 0.5f);
		}

		public static void smethod_11()
		{
			smethod_36(int_9, 0.5f);
		}

		public static void smethod_12()
		{
			smethod_36(int_25, 0.5f);
		}

		public static void smethod_13()
		{
			smethod_36(int_15, 1f);
		}

		public static void smethod_14(float volume)
		{
			smethod_36(int_21, volume);
		}

		public static void smethod_15(float volume)
		{
			smethod_36(int_19, volume);
		}

		public static void smethod_16()
		{
			smethod_36(int_13, 1f);
		}

		public static void smethod_17()
		{
			smethod_36(int_10, 0.3f);
		}

		public static void smethod_18()
		{
			smethod_36(int_18, 0.3f);
		}

		public static void smethod_19()
		{
			smethod_36(int_11, 0.3f);
		}

		public static void smethod_20()
		{
			smethod_36(int_12, 0.3f);
		}

		public static void smethod_21()
		{
			smethod_36(int_16, 0.5f);
		}

		public static void smethod_22()
		{
			smethod_36(int_17, 0.5f);
		}

		public static void smethod_23()
		{
			smethod_36(int_22, 1f);
		}

		public static void smethod_24()
		{
			smethod_36(int_20, 1f);
		}

		public static void smethod_25()
		{
			smethod_36(int_0, 0.3f);
		}

		public static void smethod_26()
		{
			if (GClass69.bool_0 && 0 == 0)
			{
				gameObject_1.GetComponent<AudioSource>().loop = true;
				gameObject_1.GetComponent<AudioSource>().clip = audioClip_0;
				gameObject_1.GetComponent<AudioSource>().Play();
			}
		}

		public static void smethod_27()
		{
			gameObject_1.GetComponent<AudioSource>().Stop();
		}

		public static void smethod_28()
		{
			smethod_27();
			for (int i = 0; i < gameObject_0.Length; i++)
			{
				gameObject_0[i].GetComponent<AudioSource>().Stop();
			}
		}

		public static void smethod_29(string fileName, int pos)
		{
			smethod_33(pos);
			smethod_30(fileName, pos);
		}

		public static void smethod_30(string filename, int pos)
		{
			if (Thread.CurrentThread.Name == Main.string_0 && 0 == 0)
			{
				smethod_32(filename, pos);
			}
			else
			{
				smethod_31(filename, pos);
			}
		}

		private static void smethod_31(string string_1, int int_30)
		{
			if (int_27 != 0 && 0 == 0)
			{
				Debug.LogError("CANNOT LOAD AUDIO " + string_1 + " WHEN LOADING " + string_0);
				return;
			}
			string_0 = string_1;
			int_28 = int_30;
			int_27 = 2;
			int i;
			for (i = 0; i < 100; i++)
			{
				Thread.Sleep(5);
				if (int_27 == 0)
				{
					break;
				}
			}
			if (i == 100)
			{
				Debug.LogError("TOO LONG FOR LOAD AUDIO " + string_1);
				return;
			}
			Debug.Log("Load Audio " + string_1 + " done in " + i * 5 + "ms");
		}

		private static void smethod_32(string string_1, int int_30)
		{
			audioClip_1[int_30] = (AudioClip)Resources.Load(string_1, typeof(AudioClip));
			gameObject_0[int_30] = GameObject.Find("Main Camera").AddComponent<AudioSource>().gameObject;
		}

		public static void smethod_33(int pos)
		{
			if (Thread.CurrentThread.Name == Main.string_0 && 0 == 0)
			{
				smethod_35(pos);
			}
			else
			{
				smethod_34(pos);
			}
		}

		public static void smethod_34(int pos)
		{
			if (int_27 != 0 && 0 == 0)
			{
				Debug.LogError("CANNOT STOP AUDIO WHEN STOPPING");
				return;
			}
			int_28 = pos;
			int_27 = 4;
			int i;
			for (i = 0; i < 100; i++)
			{
				Thread.Sleep(5);
				if (int_27 == 0)
				{
					break;
				}
			}
			if (i == 100)
			{
				Debug.LogError("TOO LONG FOR STOP AUDIO");
			}
			else
			{
				Debug.Log("Stop Audio done in " + i * 5 + "ms");
			}
		}

		public static void smethod_35(int pos)
		{
			if (gameObject_0[pos] != null && 0 == 0)
			{
				gameObject_0[pos].GetComponent<AudioSource>().Stop();
			}
		}

		public static void smethod_36(int id, float volume)
		{
			smethod_37(id, volume);
		}

		public static void smethod_37(int id, float volume)
		{
			if ((!bool_1 || 1 == 0) && GClass69.bool_0 && 0 == 0)
			{
				smethod_38(volume, id);
			}
		}

		public static void smethod_38(float volume, int pos)
		{
			if (Thread.CurrentThread.Name == Main.string_0 && 0 == 0)
			{
				smethod_40(volume, pos);
			}
			else
			{
				smethod_39(volume, pos);
			}
		}

		public static void smethod_39(float volume, int pos)
		{
			if (int_27 != 0 && 0 == 0)
			{
				Debug.LogError("CANNOT START AUDIO WHEN STARTING");
				return;
			}
			float_0 = volume;
			int_28 = pos;
			int_27 = 3;
			int i;
			for (i = 0; i < 100; i++)
			{
				Thread.Sleep(5);
				if (int_27 == 0)
				{
					break;
				}
			}
			if (i == 100)
			{
				Debug.LogError("TOO LONG FOR START AUDIO");
			}
			else
			{
				Debug.Log("Start Audio done in " + i * 5 + "ms");
			}
		}

		public static void smethod_40(float volume, int pos)
		{
			if (gameObject_0[pos] != null && 0 == 0)
			{
				gameObject_0[pos].GetComponent<AudioSource>().PlayOneShot(audioClip_1[pos], volume);
			}
		}
	}
}
