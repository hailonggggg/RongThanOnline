using System;
using System.Collections.Generic;
using UnityEngine;

namespace rto
{
	public class GClass25 : GClass21, GInterface0
	{
		public int classId;

		public int spaceship;

		public int sex;

		public int baseHp;

		public int baseMp;

		public int baseDamage;

		public int baseConstitution;

		public int maxDamage;

		public int critical;

		public int dodge;

		public int reduceDamage;

		public int reduceDamageCritical;

		public int accurate;

		public int criticalStrike;

		public int bloodsucking;

		public int manaSucking;

		public int strikeBack;

		public int pointSkill;

		public int level;

		public int xu;

		public int diamond;

		public int pointPk;

		public int pointActivity;

		public long potentialUpDamage;

		public long potentialUpHp;

		public long potentialUpMp;

		public long potentialUpConstitution;

		public static bool bool_0;

		public static bool bool_1;

		public static bool bool_2;

		public static GClass25 gclass25_0;

		public static bool bool_3;

		public static bool bool_4;

		public static bool bool_5;

		public static bool bool_6;

		public GClass29 currentMovePoint;

		public int yStartFall;

		public int cp1;

		public int cp2;

		public int cp3;

		public int cvx;

		public int cvy;

		public int cxSend;

		public int cySend;

		public bool isLockMove;

		public bool isCanFly;

		public int checkStatus;

		public int delayFall;

		public List<GClass29> movePoints;

		public List<GInterface0> focus = new List<GInterface0>();

		public GClass25 playerFocus;

		public GClass22 itemFocus;

		public GClass24 npcFocus;

		public GClass23 mobFocus;

		private int statusBeforeNothing;

		public sbyte timeInjure;

		public GClass77 chatInfo;

		public GClass39 skillPaint;

		public int sType;

		public GClass33 dart;

		public List<GClass34> skills;

		public GClass34 mySkill;

		public long power;

		public long potential;

		public bool isDead;

		public GClass48 task;

		public List<GClass16> itemsBag = new List<GClass16>();

		public List<GClass16> itemsBox = new List<GClass16>();

		public List<GClass16> itemsBody = new List<GClass16>();

		private int timeFocusToMob;

		public static bool bool_7;

		public bool isSpaceship;

		public bool isWaitDart;

		public long lastTimeWaitDart;

		public int skillUseId;

		public int skillUseType;

		public GClass50 team;

		public static bool bool_8;

		public int killId;

		public int typePk;

		public int typeFlag;

		public static int[] int_0;

		public GClass7 clan;

		public int frameMount;

		public int frameNewMount;

		public int transMount;

		public int genderMount;

		public int idcharMount;

		public int xMount;

		public int yMount;

		public int dxMount;

		public int dyMount;

		public int xChar;

		public int xdis;

		public int speedMount;

		public bool isStartMount;

		public bool isMount;

		public bool isEndMount;

		public bool isHaveMount;

		public int mount = -1;

		private long lastTimeSoundPlayerRun;

		private long lastTimeSoundPlayerFly;

		private long lastTimeSoundPlayerRescure;

		public int frameT = -1;

		public static int[][][] int_1;

		static GClass25()
		{
			int_0 = new int[4] { 73, 74, 75, 76 };
			int_1 = new int[38][][]
			{
				new int[3][]
				{
					new int[3] { 0, -48, 137 },
					new int[3] { 0, -35, 70 },
					new int[3] { 0, -28, 43 }
				},
				new int[3][]
				{
					new int[3] { 1, -48, 134 },
					new int[3] { 0, -35, 67 },
					new int[3] { 0, -28, 43 }
				},
				new int[3][]
				{
					new int[3] { 2, -37, 126 },
					new int[3] { 1, -24, 69 },
					new int[3] { 1, -33, 38 }
				},
				new int[3][]
				{
					new int[3] { 2, -37, 126 },
					new int[3] { 2, -26, 67 },
					new int[3] { 2, -39, 35 }
				},
				new int[3][]
				{
					new int[3] { 2, -37, 126 },
					new int[3] { 3, -38, 65 },
					new int[3] { 3, -40, 37 }
				},
				new int[3][]
				{
					new int[3] { 2, -37, 125 },
					new int[3] { 4, -42, 68 },
					new int[3] { 4, -42, 38 }
				},
				new int[3][]
				{
					new int[3] { 2, -37, 127 },
					new int[3] { 5, -32, 68 },
					new int[3] { 5, -43, 44 }
				},
				new int[3][]
				{
					new int[3] { 2, -37, 124 },
					new int[3] { 6, -30, 65 },
					new int[3] { 6, -40, 38 }
				},
				new int[3][]
				{
					new int[3] { 0, -41, 137 },
					new int[3] { 7, -36, 74 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 2, -22, 116 },
					new int[3] { 8, -15, 60 },
					new int[3] { 8, -76, 59 }
				},
				new int[3][]
				{
					new int[3] { 0, -47, 142 },
					new int[3] { 9, -44, 106 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 0, -47, 136 },
					new int[3] { 9, -44, 100 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 3, -47, 135 },
					new int[3] { 10, -43, 68 },
					new int[3] { 0, -28, 43 }
				},
				new int[3][]
				{
					new int[3] { 3, -46, 140 },
					new int[3] { 10, -42, 73 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 0, -43, 132 },
					new int[3] { 11, -27, 85 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 0, -44, 137 },
					new int[3] { 11, -28, 90 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 0, -39, 138 },
					new int[3] { 12, -16, 82 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 0, -39, 141 },
					new int[3] { 12, -16, 85 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 0, -42, 129 },
					new int[3] { 13, -24, 65 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 0, -45, 139 },
					new int[3] { 13, -27, 75 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 0, -40, 135 },
					new int[3] { 14, -15, 76 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 0, -44, 139 },
					new int[3] { 14, -19, 80 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 0, -33, 132 },
					new int[3] { 15, -13, 78 },
					new int[3] { 10, -15, 45 }
				},
				new int[3][]
				{
					new int[3] { 0, -40, 122 },
					new int[3] { 16, -38, 73 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 2, -45, 129 },
					new int[3] { 17, -35, 70 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 2, -44, 138 },
					new int[3] { 17, -34, 79 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 2, -30, 132 },
					new int[3] { 18, -10, 77 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 2, -34, 138 },
					new int[3] { 18, -12, 83 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 2, -39, 127 },
					new int[3] { 19, -34, 65 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 2, -35, 134 },
					new int[3] { 19, -30, 73 },
					new int[3] { 7, -18, 50 }
				},
				new int[3][]
				{
					new int[3] { 2, -45, 138 },
					new int[3] { 20, -39, 92 },
					new int[3] { 11, -20, 68 }
				},
				new int[3][]
				{
					new int[3] { 0, -42, 136 },
					new int[3] { 21, -13, 110 },
					new int[3] { 12, -27, 72 }
				},
				new int[3][]
				{
					new int[3] { 2, -36, 131 },
					new int[3] { 20, -30, 85 },
					new int[3] { 13, -10, 80 }
				},
				new int[3][]
				{
					new int[3] { 0, -47, 136 },
					new int[3] { 9, -44, 100 },
					new int[3] { 0, -28, 43 }
				},
				new int[3][]
				{
					new int[3] { 0, -44, 132 },
					new int[3] { 11, -28, 85 },
					new int[3] { 0, -28, 43 }
				},
				new int[3][]
				{
					new int[3] { 0, -40, 138 },
					new int[3] { 12, -17, 82 },
					new int[3] { 0, -28, 43 }
				},
				new int[3][]
				{
					new int[3] { 0, -45, 133 },
					new int[3] { 21, -16, 107 },
					new int[3] { 9, -45, 45 }
				},
				new int[3][]
				{
					new int[3] { 0, -45, 140 },
					new int[3] { 21, -16, 114 },
					new int[3] { 7, -18, 50 }
				}
			};
		}

		public GClass25()
		{
			speed = 8;
			h = 96;
			w = 66;
			status = 1;
			isCanFly = true;
			movePoints = new List<GClass29>();
			chatInfo = new GClass77();
		}

		public virtual void vmethod_0(GClass68 g)
		{
			if (method_2() && 0 == 0 && !isSpaceship)
			{
				try
				{
					method_3(g, x, y, dir, frame);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
				if (status != 15 && (!isDead || 1 == 0) && (!isDie || 1 == 0))
				{
					method_1(g);
					method_0(g);
				}
			}
		}

		public void method_0(GClass68 g)
		{
			if (xMount <= GClass3.int_0 || xMount >= GClass3.int_0 + GClass69.int_1 || mount == -1)
			{
				return;
			}
			if (Equals(gclass25_0) && 0 == 0)
			{
				if ((isEndMount ? true : false) || (isStartMount ? true : false) || (isMount ? true : false))
				{
					GClass31 gClass = GClass69.list_2[mount];
					GClass42.smethod_1(g, gClass.pi[frameMount].id, xMount + gClass.pi[frameMount].dx * dir, yMount + gClass.pi[frameMount].dy, (dir != 1) ? 2 : 0, (dir == 1) ? GClass45.int_2 : GClass45.int_1);
				}
			}
			else if (isMount ? true : false)
			{
				GClass31 gClass2 = GClass69.list_2[mount];
				GClass42.smethod_1(g, gClass2.pi[frameMount].id, xMount + gClass2.pi[frameMount].dx * dir, yMount + gClass2.pi[frameMount].dy, (dir != 1) ? 2 : 0, (dir == 1) ? GClass45.int_2 : GClass45.int_1);
			}
		}

		public void method_1(GClass68 g)
		{
			int num = y - h - 15;
			if (gclass25_0.playerFocus != null && 0 == 0 && gclass25_0.playerFocus.Equals(this) && 0 == 0)
			{
				if (gclass25_0.method_39(this) && 0 == 0)
				{
					method_4(g, x, num);
					num -= 7;
				}
				else
				{
					g.method_28(GClass3.gclass66_2, x, num, 3);
					num -= GClass3.gclass66_2.method_1() / 2;
				}
			}
			if (!Equals(gclass25_0) || 1 == 0)
			{
				GClass67 gClass = GClass67.gclass67_14;
				if (typePk != 1 && typePk != 2 && typePk != 3)
				{
					if (gclass25_0.team != null && 0 == 0)
					{
						using List<GClass73>.Enumerator enumerator = gclass25_0.team.members.GetEnumerator();
						while (enumerator.MoveNext() ? true : false)
						{
							if (enumerator.Current.playerInfo.id == id)
							{
								gClass = GClass67.gclass67_13;
								break;
							}
						}
					}
				}
				else
				{
					gClass = GClass67.gclass67_15;
				}
				num -= gClass.method_7();
				gClass.method_1(g, name, x, num, 2);
			}
			if (typePk == 2)
			{
				num -= 5;
				GClass42.smethod_1(g, 77, x, num, (dir != 1) ? 2 : 0, GClass45.int_3);
			}
			else if (typeFlag > 0)
			{
				num -= 5;
				GClass42.smethod_1(g, int_0[typeFlag - 1], x, num, (dir != 1) ? 2 : 0, GClass45.int_3);
			}
		}

		public bool method_2()
		{
			if (y < GClass3.int_1 - 100)
			{
				return false;
			}
			if (y > GClass3.int_1 + GClass69.int_2 + 100)
			{
				return false;
			}
			if (x < GClass3.int_0 - 100)
			{
				return false;
			}
			if (x > GClass3.int_0 + GClass69.int_1 + 100)
			{
				return false;
			}
			return true;
		}

		public void method_3(GClass68 g, int x, int y, int dir, int frame)
		{
			GClass31 gClass = GClass69.list_2[head];
			GClass31 gClass2 = GClass69.list_2[body];
			GClass31 gClass3 = GClass69.list_2[leg];
			if (status != 14 && !isDie && !isDead)
			{
				if (!isChocolate)
				{
					if (head != 38 && head != 41 && head != 44)
					{
						GClass42.smethod_1(g, gClass.pi[int_1[frame][0][0]].id, x + int_1[frame][0][1] * dir + gClass.pi[int_1[frame][0][0]].dx * dir, y - int_1[frame][0][2] + gClass.pi[int_1[frame][0][0]].dy, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
						GClass42.smethod_1(g, gClass3.pi[int_1[frame][2][0]].id, x + int_1[frame][2][1] * dir + gClass3.pi[int_1[frame][2][0]].dx * dir, y - int_1[frame][2][2] + gClass3.pi[int_1[frame][2][0]].dy, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
						GClass42.smethod_1(g, gClass2.pi[int_1[frame][1][0]].id, x + int_1[frame][1][1] * dir + gClass2.pi[int_1[frame][1][0]].dx * dir, y - int_1[frame][1][2] + gClass2.pi[int_1[frame][1][0]].dy, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
					}
					else
					{
						GClass42.smethod_1(g, gClass.pi[GClass45.int_10[frame][0][0]].id, x + GClass45.int_10[frame][0][1] * dir + gClass.pi[GClass45.int_10[frame][0][0]].dx * dir, y - GClass45.int_10[frame][0][2] + gClass.pi[GClass45.int_10[frame][0][0]].dy, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
						GClass42.smethod_1(g, gClass3.pi[GClass45.int_10[frame][2][0]].id, x + GClass45.int_10[frame][2][1] * dir + gClass3.pi[GClass45.int_10[frame][2][0]].dx * dir, y - GClass45.int_10[frame][2][2] + gClass3.pi[GClass45.int_10[frame][2][0]].dy, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
						GClass42.smethod_1(g, gClass2.pi[GClass45.int_10[frame][1][0]].id, x + GClass45.int_10[frame][1][1] * dir + gClass2.pi[GClass45.int_10[frame][1][0]].dx * dir, y - GClass45.int_10[frame][1][2] + gClass2.pi[GClass45.int_10[frame][1][0]].dy, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
					}
				}
				if (status == 10 && frame == 9)
				{
					if (GClass69.int_0 % 2 == 0)
					{
						cp3++;
						if (cp3 > 3)
						{
							cp3 = 0;
						}
					}
					GClass42.smethod_1(g, GClass45.int_8[cp3], x + int_1[frame][2][1] * dir + gClass3.pi[int_1[frame][2][0]].dx * dir - 5 * dir, y - int_1[frame][2][2] + gClass3.pi[int_1[frame][2][0]].dy - 35, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
				}
				try
				{
					if (skillPaint != null && method_15() != null && skillPaint.index < method_15().Count)
					{
						method_5(g, x, y, dir);
					}
				}
				catch
				{
				}
			}
			else
			{
				GClass42.smethod_1(g, gClass.pi[int_1[frame][0][0]].id, x + int_1[frame][0][1] * dir + gClass.pi[int_1[frame][0][0]].dx * dir, y - int_1[frame][0][2] + gClass.pi[int_1[frame][0][0]].dy, (dir != 1) ? 2 : 0, (dir != 1) ? 24 : 0);
				GClass42.smethod_1(g, 215, x, y - int_1[frame][1][2] + gClass2.pi[int_1[frame][1][0]].dy + 1, (dir != 1) ? 2 : 0, GClass45.int_0);
				GClass42.smethod_1(g, 249, x, y - int_1[frame][0][2], (dir != 1) ? 2 : 0, GClass68.int_0 | GClass68.int_5);
			}
			foreach (GClass9 effect in effects)
			{
				effect.method_0(g);
			}
		}

		public static void smethod_0(GClass25 player)
		{
			try
			{
				GClass31 gClass = GClass69.list_2[player.head];
				player.h = int_1[0][0][2] - gClass.pi[int_1[0][0][0]].dy;
			}
			catch
			{
				player.h = 96;
			}
		}

		public static void smethod_1(GClass25 player)
		{
			try
			{
				GClass31 gClass = GClass69.list_2[player.body];
				player.w = GClass42.dictionary_0[gClass.pi[int_1[0][1][0]].id].method_0();
			}
			catch
			{
				player.w = 66;
			}
		}

		public static void smethod_2(GClass25 player)
		{
			GClass31 gClass = GClass69.list_2[player.head];
			for (int i = 0; i < gClass.pi.Length; i++)
			{
				GClass42.smethod_0(gClass.pi[i].id);
			}
			GClass31 gClass2 = GClass69.list_2[player.body];
			for (int j = 0; j < gClass2.pi.Length; j++)
			{
				GClass42.smethod_0(gClass2.pi[j].id);
			}
			GClass31 gClass3 = GClass69.list_2[player.leg];
			for (int k = 0; k < gClass3.pi.Length; k++)
			{
				GClass42.smethod_0(gClass3.pi[k].id);
			}
			if (player.mount != -1)
			{
				GClass31 gClass4 = GClass69.list_2[player.mount];
				for (int l = 0; l < gClass4.pi.Length; l++)
				{
					GClass42.smethod_0(gClass4.pi[l].id);
				}
			}
		}

		public void method_4(GClass68 g, int x, int y)
		{
			int num = 90;
			int num2 = 10;
			int num3 = (int)(hp * 90L / maxHp);
			if (num3 > 90)
			{
				num3 = num;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			g.method_11(0);
			g.method_7(x - num / 2 - 2, y - (num2 - 4) - 2, num + 4, num2 + 4);
			g.method_11(16777215);
			g.method_7(x - num / 2, y - (num2 - 4), num, num2);
			g.method_11(16711680);
			g.method_7(x - num / 2, y - (num2 - 4), num3, num2);
		}

		public static void smethod_3(GClass68 g, int x, int y)
		{
			g.method_11(0);
			g.method_7(x - 45 - 2, y - 6 - 2, 94, 14);
			g.method_11(16777215);
			g.method_7(x - 45, y - 6, 90, 10);
			g.method_11(9145227);
			g.method_7(x - 45, y - 6, 90, 10);
		}

		public void method_5(GClass68 g, int x, int y, int dir)
		{
			using List<GClass12>.Enumerator enumerator = method_15()[skillPaint.index].effectPlayerPaints.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				using List<GClass11>.Enumerator enumerator2 = enumerator.Current.effectInfoPaints.GetEnumerator();
				while (enumerator2.MoveNext() ? true : false)
				{
					GClass11 current = enumerator2.Current;
					if (current.index < current.effectInfoImages.Count)
					{
						GClass42.smethod_1(g, current.effectInfoImages[current.index].imgId, x + current.effectInfoImages[current.index].dx * dir, y + current.effectInfoImages[current.index].dy, (dir != 1) ? 2 : 0, GClass68.int_1 | GClass68.int_0);
					}
				}
			}
		}

		public void method_6()
		{
			if ((!gclass25_0.isDead || 1 == 0) && gclass25_0.hp > 0L && GClass84.smethod_1() - mySkill.lastTimeUse >= mySkill.method_3())
			{
				if (!method_42() || 1 == 0)
				{
					GClass79.smethod_3("Không đủ KI để sử dụng.", 0);
					return;
				}
				mp -= method_43();
				mySkill.lastTimeUse = GClass84.smethod_1();
				method_7(mySkill.template.id, mySkill.level, (!Class0.smethod_3(x, y) || 1 == 0) ? 1 : 0);
			}
		}

		public static bool smethod_4(int skillTemplateId)
		{
			if (skillTemplateId >= 14)
			{
				return skillTemplateId <= 19;
			}
			return false;
		}

		public void method_7(int skillTemplateId, int level, int sType)
		{
			if ((gclass25_0.isDead ? true : false) || gclass25_0.hp <= 0L || level <= 0)
			{
				return;
			}
			GClass39 gClass = null;
			isWaitDart = false;
			switch (skillTemplateId)
			{
			case 0:
				gClass = GClass69.gclass39_0[GClass84.smethod_8(0, 1)];
				break;
			case 7:
				gClass = ((level > 3) ? ((level > 6) ? GClass69.gclass39_0[10] : GClass69.gclass39_0[9]) : GClass69.gclass39_0[8]);
				break;
			case 8:
				gClass = ((level > 3) ? ((level > 6) ? GClass69.gclass39_0[4] : GClass69.gclass39_0[3]) : GClass69.gclass39_0[2]);
				break;
			case 9:
				gClass = ((level > 3) ? ((level > 6) ? GClass69.gclass39_0[7] : GClass69.gclass39_0[6]) : GClass69.gclass39_0[5]);
				break;
			case 10:
				gClass = GClass69.gclass39_0[14];
				break;
			case 11:
				gClass = GClass69.gclass39_0[11];
				break;
			case 12:
				gClass = GClass69.gclass39_0[13];
				break;
			case 13:
				gClass = GClass69.gclass39_0[12];
				break;
			case 14:
				gClass = GClass69.gclass39_0[17];
				break;
			case 15:
				gClass = GClass69.gclass39_0[18];
				break;
			case 16:
				gClass = GClass69.gclass39_0[20];
				break;
			case 17:
				gClass = GClass69.gclass39_0[19];
				break;
			case 18:
				gClass = GClass69.gclass39_0[16];
				break;
			case 19:
				gClass = GClass69.gclass39_0[15];
				break;
			}
			if (gClass == null)
			{
				return;
			}
			if (Equals(gclass25_0) && 0 == 0 && mySkill != null && 0 == 0)
			{
				skillUseId = skillTemplateId;
				skillUseType = mySkill.template.type;
			}
			if (skillTemplateId == 11)
			{
				if (Equals(gclass25_0) && 0 == 0)
				{
					GClass3.smethod_0().dem = 0;
					GClass3.smethod_0().isUseFreez = true;
				}
				GClass43.smethod_13();
			}
			if (skillTemplateId == 18)
			{
				GClass43.smethod_23();
			}
			if (skillTemplateId == 10 && x >= GClass3.int_0 && x <= GClass3.int_0 + GClass69.int_1)
			{
				GClass43.smethod_14(method_28());
			}
			if (skillTemplateId == 16 || skillTemplateId == 19)
			{
				GClass43.smethod_14(1f);
			}
			if (skillTemplateId == 14 || skillTemplateId == 15 || skillTemplateId == 17)
			{
				GClass43.smethod_15(1f);
			}
			if (Equals(gclass25_0) && 0 == 0 && smethod_4(skillTemplateId) && 0 == 0)
			{
				GInterface0 gInterface = playerFocus;
				if (mobFocus != null && 0 == 0)
				{
					gInterface = mobFocus;
				}
				GClass0.smethod_11(gInterface);
			}
			method_8(gClass, sType);
			if (mobFocus != null && 0 == 0)
			{
				mobFocus.dir = ((mobFocus.x < x) ? 1 : (-1));
			}
		}

		public void method_8(GClass39 skillPaint, int sType)
		{
			if (this.skillPaint == null)
			{
				GClass39 gClass = skillPaint.method_0();
				method_21(gClass);
				this.skillPaint = gClass;
				skillPaint.index = 0;
				status = 12;
				this.sType = sType;
			}
		}

		public bool method_9()
		{
			using (List<GClass53>.Enumerator enumerator = Class0.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass53 current = enumerator.Current;
					if (y <= current.maxY && y >= current.maxY - 20)
					{
						return true;
					}
				}
			}
			return false;
		}

		public bool method_10()
		{
			if (isSpaceship && 0 == 0)
			{
				return false;
			}
			using (List<GClass53>.Enumerator enumerator = Class0.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass53 current = enumerator.Current;
					if (x >= current.minX && x <= current.maxX && y >= current.minY && y <= current.maxY)
					{
						return true;
					}
				}
			}
			return false;
		}

		public GClass53 method_11()
		{
			if (isSpaceship && 0 == 0)
			{
				return null;
			}
			using (List<GClass53>.Enumerator enumerator = Class0.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass53 current = enumerator.Current;
					if (x >= current.minX && x <= current.maxX && y >= current.minY && y <= current.maxY)
					{
						return current;
					}
				}
			}
			return null;
		}

		public bool method_12()
		{
			if (skillPaint == null || 1 == 0)
			{
				return false;
			}
			if (skillPaint.id != 0 && 0 == 0 && skillPaint.id != 1)
			{
				return false;
			}
			return true;
		}

		public void method_13()
		{
			if (Equals(gclass25_0) && 0 == 0 && status == 10 && frame == 9 && GClass84.smethod_1() - lastTimeSoundPlayerFly > 300L)
			{
				lastTimeSoundPlayerFly = GClass84.smethod_1();
				GClass43.smethod_1();
			}
			if (skillPaint != null && 0 == 0 && method_15() != null && 0 == 0 && skillPaint.index < method_15().Count && method_12() && 0 == 0 && ((Equals(gclass25_0) ? true : false) || ((!Equals(gclass25_0) || 1 == 0) && x >= GClass3.int_0 && x <= GClass3.int_0 + GClass69.int_1)) && (GClass69.int_0 % 5 == 0 || 1 == 0))
			{
				if (frame >= 24 && frame <= 29)
				{
					GClass43.smethod_5(isKick: true);
				}
				else
				{
					GClass43.smethod_5(isKick: false);
				}
			}
		}

		public virtual void vmethod_1()
		{
			if (isSpaceship)
			{
				currentMovePoint = null;
				movePoints.Clear();
			}
			if (isWaitDart && GClass84.smethod_1() - lastTimeWaitDart > 5000L)
			{
				isWaitDart = false;
			}
			method_13();
			for (int i = 0; i < effects.Count; i++)
			{
				if (effects[i].time <= 0L)
				{
					effects.RemoveAt(i);
					i--;
				}
				else
				{
					effects[i].method_3();
				}
			}
			if (Equals(gclass25_0) && (Class0.smethod_3(x, y - 1) || y >= Class0.int_7))
			{
				int num = y;
				while (Class0.smethod_3(x, num - 1) || num >= Class0.int_7)
				{
					num -= Class0.sbyte_0;
					if (num % Class0.sbyte_0 != 0)
					{
						num -= num % Class0.sbyte_0;
					}
				}
				int num2 = y - num >> 1;
				if (num2 < 1)
				{
					num2 = 1;
				}
				frame = 8;
				y -= num2;
				status = 4;
				return;
			}
			if (Equals(gclass25_0) && (hp <= 0L || isDead) && dart != null)
			{
				dart.method_2();
			}
			if (!Equals(gclass25_0) && hp <= 0L && status != 14 && status != 5)
			{
				method_17((short)x, (short)y);
			}
			method_23();
			chatInfo.method_2();
			try
			{
				if (skillPaint != null)
				{
					method_16();
				}
			}
			catch
			{
			}
			if (dart != null)
			{
				dart.method_1();
			}
			if (isBlind)
			{
				frame = 22;
			}
			else
			{
				if (skillPaint != null || method_15() != null)
				{
					return;
				}
				if (Equals(gclass25_0))
				{
					if (x < 10)
					{
						cvx = 0;
						x = 10;
					}
					if (x > Class0.int_6 - 10)
					{
						cvx = 0;
						x = Class0.int_6 - 10;
					}
					if (x < 50 && !method_9())
					{
						cvx = 0;
						x = 50;
					}
					if (x > Class0.int_6 - 50 && !method_9())
					{
						cvx = 0;
						x = Class0.int_6 - 50;
					}
					if (Equals(gclass25_0) && !bool_1)
					{
						GClass53 gClass = method_11();
						if (gClass != null && gClass.type != 2)
						{
							GClass0.smethod_3();
							GClass0.smethod_4();
							bool_2 = true;
							bool_1 = true;
							GClass78.smethod_1();
							return;
						}
					}
					if (status != 4 && smethod_5(x - cxSend) + smethod_5(y - cySend) >= 70 && y - cySend <= 0 && Equals(gclass25_0))
					{
						GClass0.smethod_3();
					}
					if (isLockMove)
					{
						currentMovePoint = null;
					}
					if (currentMovePoint != null)
					{
						if (smethod_5(x - currentMovePoint.xEnd) <= 32 && smethod_5(y - currentMovePoint.yEnd) <= 16)
						{
							bool_6 = false;
							bool_5 = false;
							bool_3 = false;
							bool_4 = false;
							x = (currentMovePoint.xEnd + x) / 2;
							y = currentMovePoint.yEnd;
							currentMovePoint = null;
							int num3 = 0;
							cvy = 0;
							cvx = 0;
							if (Class0.smethod_3(x, y))
							{
								status = 1;
							}
							else
							{
								method_36();
							}
							GClass0.smethod_3();
						}
						else
						{
							if (smethod_5(x - currentMovePoint.xEnd) > 30)
							{
								if (x < currentMovePoint.xEnd)
								{
									bool_6 = false;
									bool_5 = true;
								}
								else if (x > currentMovePoint.xEnd)
								{
									bool_5 = false;
									bool_6 = true;
								}
							}
							else
							{
								bool_6 = false;
								bool_5 = false;
							}
							if (y < currentMovePoint.yEnd)
							{
								bool_3 = false;
								bool_4 = true;
							}
							else if (y > currentMovePoint.yEnd)
							{
								bool_4 = false;
								bool_3 = true;
							}
						}
					}
					method_40();
				}
				else
				{
					bool flag = false;
					if (currentMovePoint != null)
					{
						if (smethod_5(currentMovePoint.xEnd - x) < speed && smethod_5(currentMovePoint.yEnd - y) < 24)
						{
							x = currentMovePoint.xEnd;
							y = currentMovePoint.yEnd;
							currentMovePoint = null;
							if (Class0.smethod_3(x, y))
							{
								status = 1;
								cp3 = 0;
							}
							else
							{
								status = 4;
								cvy = 0;
								cp1 = 0;
							}
							flag = true;
						}
						else if ((statusBeforeNothing == 10 || frame == 9) && movePoints.Count > 0)
						{
							flag = true;
						}
						else if (y == currentMovePoint.yEnd)
						{
							if (x != currentMovePoint.xEnd)
							{
								frame = GClass69.int_0 % 5 + 2;
							}
						}
						else if (y < currentMovePoint.yEnd)
						{
							frame = 10;
							x += cvx;
							if (cvy < 0)
							{
								cvy = 0;
							}
							y += cvy;
						}
						else
						{
							frame = 8;
							x = (x + currentMovePoint.xEnd) / 2;
							y = (y + currentMovePoint.yEnd) / 2;
						}
					}
					else
					{
						flag = true;
					}
					if (flag && movePoints.Count > 0)
					{
						currentMovePoint = movePoints[0];
						movePoints.RemoveAt(0);
						if (currentMovePoint.status == 2)
						{
							if (!Class0.smethod_3(x, y + Class0.sbyte_0))
							{
								status = 10;
								cp1 = 0;
								cp2 = 0;
								cvx = -(x - currentMovePoint.xEnd) / 10;
								cvy = -(y - currentMovePoint.yEnd) / 10;
								if (x - currentMovePoint.xEnd > 0)
								{
									dir = -1;
								}
								else if (x - currentMovePoint.xEnd < 0)
								{
									dir = 1;
								}
							}
							else
							{
								status = 2;
								if (x - currentMovePoint.xEnd > 0)
								{
									dir = -1;
								}
								else if (x - currentMovePoint.xEnd < 0)
								{
									dir = 1;
								}
								cvx = speed * dir;
								cvy = 0;
							}
						}
						else if (currentMovePoint.status == 3)
						{
							if (Class0.smethod_3(x, y + Class0.sbyte_0))
							{
								status = 10;
								cp1 = 0;
								cp2 = 0;
								cvx = -(x - currentMovePoint.xEnd) / 10;
								cvy = -(y - currentMovePoint.yEnd) / 10;
								if (x - currentMovePoint.xEnd > 0)
								{
									dir = -1;
								}
								else if (x - currentMovePoint.xEnd < 0)
								{
									dir = 1;
								}
							}
							else
							{
								status = 3;
								if (x - currentMovePoint.xEnd > 0)
								{
									dir = -1;
								}
								else if (x - currentMovePoint.xEnd < 0)
								{
									dir = 1;
								}
								cvx = smethod_5(x - currentMovePoint.xEnd) / 10 * dir;
								cvy = -10;
							}
						}
						else if (currentMovePoint.status == 4)
						{
							status = 4;
							if (x - currentMovePoint.xEnd > 0)
							{
								dir = -1;
							}
							else if (x - currentMovePoint.xEnd < 0)
							{
								dir = 1;
							}
							cvx = smethod_5(x - currentMovePoint.xEnd) / 9 * dir;
							cvy = 0;
						}
						else
						{
							x = currentMovePoint.xEnd;
							y = currentMovePoint.yEnd;
							currentMovePoint = null;
						}
					}
				}
				switch (status)
				{
				case 1:
					method_27();
					break;
				case 2:
					method_29();
					break;
				case 3:
					method_31();
					break;
				case 4:
					method_24();
					break;
				case 5:
					method_14();
					break;
				case 6:
					if (timeInjure <= 0)
					{
						frame = 0;
					}
					else if (statusBeforeNothing == 10)
					{
						x += cvx;
					}
					else if (frame <= 1)
					{
						cp1++;
						if (cp1 > 6)
						{
							frame = 0;
						}
						else
						{
							frame = 1;
						}
						if (cp1 > 10)
						{
							cp1 = 0;
						}
					}
					if (frame != 7 && frame != 12 && !Class0.smethod_3(x, y + 1))
					{
						cvx = 0;
						cvy = 0;
						status = 4;
						frame = 8;
					}
					if (Equals(gclass25_0))
					{
						break;
					}
					cp3++;
					if (cp3 > 10)
					{
						if (!Class0.smethod_3(x, y + 1))
						{
							y += 5;
						}
						else
						{
							frame = 0;
						}
					}
					if (cp3 > 50)
					{
						cp3 = 0;
						currentMovePoint = null;
					}
					break;
				case 10:
					method_25();
					break;
				case 14:
					cp1++;
					if (cp1 > 30)
					{
						cp1 = 0;
					}
					if (cp1 % 15 < 5)
					{
						frame = 0;
					}
					else
					{
						frame = 1;
					}
					break;
				}
				if (timeInjure > 0)
				{
					frame = 22;
					timeInjure--;
				}
				method_32();
			}
		}

		private void method_14()
		{
			cp1++;
			x += (cp2 - x) / 4;
			if (cp1 > 7)
			{
				y += (cp3 - y) / 4;
			}
			else
			{
				y += cp1 - 10;
			}
			if (Math.Abs(cp2 - x) < 4 && Math.Abs(cp3 - y) < 10)
			{
				x = cp2;
				y = cp3;
				status = 14;
				if (Equals(gclass25_0) && 0 == 0)
				{
					GClass3.bool_2 = false;
					GClass3.int_13 = 0;
					GClass3.gclass72_0.isShow = true;
					GClass3.bool_0 = false;
				}
			}
			frame = 22;
		}

		public List<GClass35> method_15()
		{
			if (skillPaint == null || 1 == 0)
			{
				return null;
			}
			if (sType == 0 || 1 == 0)
			{
				return skillPaint.skillStands;
			}
			return skillPaint.skillFlys;
		}

		public void method_16()
		{
			if (skillPaint == null || 1 == 0)
			{
				return;
			}
			if (skillPaint != null && 0 == 0 && method_15() != null && 0 == 0 && skillPaint.index >= method_15().Count)
			{
				skillPaint.index = 0;
				skillPaint = null;
				if (sType == 0 || 1 == 0)
				{
					status = 1;
					return;
				}
				status = 4;
				delayFall = 5;
				return;
			}
			List<GClass35> list = method_15();
			if (list == null || false || skillPaint.index < 0 || skillPaint.index > list.Count - 1)
			{
				return;
			}
			frame = list[skillPaint.index].frame;
			bool flag = false;
			using (List<GClass12>.Enumerator enumerator = list[skillPaint.index].effectPlayerPaints.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					using List<GClass11>.Enumerator enumerator2 = enumerator.Current.effectInfoPaints.GetEnumerator();
					while (enumerator2.MoveNext() ? true : false)
					{
						GClass11 current = enumerator2.Current;
						if (current.index < current.effectInfoImages.Count - 1)
						{
							flag = true;
							current.index++;
						}
					}
				}
			}
			if (flag ? true : false)
			{
				return;
			}
			try
			{
				if (list[skillPaint.index].dart != null && 0 == 0 && (dart == null || 1 == 0))
				{
					if (Equals(gclass25_0) && 0 == 0)
					{
						if (mySkill.template.type == 1)
						{
							if (list[skillPaint.index].dart.startDarts.Count > 0)
							{
								dart = new GClass33(this, list[skillPaint.index].dart, isNotFocus: true);
								lastTimeWaitDart = GClass84.smethod_1();
								isWaitDart = true;
							}
							else
							{
								if (mySkill.template.id == 18)
								{
									GClass43.smethod_22();
								}
								GClass0.smethod_10(null);
							}
						}
						else
						{
							GInterface0 gInterface = playerFocus;
							if (mobFocus != null && 0 == 0)
							{
								gInterface = mobFocus;
							}
							if (gInterface != null && 0 == 0)
							{
								dart = new GClass33(this, list[skillPaint.index].dart, isNotFocus: false);
								if (mySkill != null && 0 == 0 && smethod_4(mySkill.template.id) && 0 == 0 && (dart.dart.startDarts.Count == 0 || 1 == 0))
								{
									dart.count_update = 4;
								}
								if (dart.dart.startDarts.Count > 0)
								{
									lastTimeWaitDart = GClass84.smethod_1();
									isWaitDart = true;
								}
							}
						}
					}
					else if (skillUseType == 1)
					{
						if (list[skillPaint.index].dart.startDarts.Count > 0)
						{
							dart = new GClass33(this, list[skillPaint.index].dart, isNotFocus: true);
							lastTimeWaitDart = GClass84.smethod_1();
							isWaitDart = true;
						}
						else if (skillUseId == 18)
						{
							GClass43.smethod_22();
						}
					}
					else
					{
						GInterface0 gInterface2 = playerFocus;
						if (mobFocus != null && 0 == 0)
						{
							gInterface2 = mobFocus;
						}
						if (((gInterface2 != null) ? true : false) || skillUseId == 18)
						{
							dart = new GClass33(this, list[skillPaint.index].dart, isNotFocus: false);
							if (mySkill != null && 0 == 0 && smethod_4(skillUseId) && 0 == 0 && (dart.dart.startDarts.Count == 0 || 1 == 0))
							{
								dart.count_update = 4;
							}
							if (dart.dart.startDarts.Count > 0)
							{
								lastTimeWaitDart = GClass84.smethod_1();
								isWaitDart = true;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Debug.Log(ex.ToString());
			}
			if (!isWaitDart || 1 == 0)
			{
				skillPaint.index++;
			}
			if (x >= GClass3.int_0 && x <= GClass3.int_0 + GClass69.int_1)
			{
				if (mySkill.template.id == 7)
				{
					GClass43.smethod_16();
				}
				else if (mySkill.template.id == 8)
				{
					GClass43.smethod_17();
				}
				else if (mySkill.template.id == 9)
				{
					GClass43.smethod_19();
				}
			}
		}

		public void method_17(short toX, short toY)
		{
			if (!Equals(gclass25_0) || false || !isDie)
			{
				if (Equals(gclass25_0) && 0 == 0)
				{
					isLockMove = true;
				}
				status = 5;
				cp2 = toX;
				cp3 = toY;
				cp1 = 0;
				hp = 0L;
				if (Equals(gclass25_0) && 0 == 0 && mySkill != null && 0 == 0)
				{
					method_18();
				}
				typePk = 0;
			}
		}

		public void method_18()
		{
			isWaitDart = false;
			skillPaint = null;
			if (Equals(gclass25_0) && 0 == 0 && status != 14 && status != 5)
			{
				isLockMove = false;
			}
		}

		public void method_19()
		{
			hp = maxHp;
			mp = maxMp;
			status = 1;
			cp3 = 0;
			cp2 = 0;
			cp1 = 0;
			if (Equals(gclass25_0) && 0 == 0)
			{
				GClass3.gclass72_0.isShow = false;
				GClass3.bool_0 = true;
			}
		}

		public void method_20(int hp, bool isCritical)
		{
			base.hp -= hp;
			if (base.hp < 0L)
			{
				base.hp = 0L;
			}
			if (hp <= 0)
			{
				GClass3.smethod_1(GClass67.gclass67_22, GClass83.string_3, x, y - imethod_3(), 0, -2);
			}
			else if (isCritical && 0 == 0)
			{
				GClass3.smethod_1(GClass67.gclass67_21, "-" + hp, x, y - imethod_3(), 0, -2);
			}
			else
			{
				GClass3.smethod_1(GClass67.gclass67_19, "-" + hp, x, y - imethod_3(), 0, -2);
			}
			if (hp > 0)
			{
				timeInjure = 6;
			}
			if (isDie && 0 == 0)
			{
				isDie = false;
				bool_2 = false;
				method_17((short)xSd, (short)ySd);
			}
		}

		public void method_21(GClass39 skillPaint)
		{
			if (skillPaint == null || 1 == 0)
			{
				return;
			}
			using (List<GClass35>.Enumerator enumerator999 = skillPaint.skillStands.GetEnumerator())
			{
				while (enumerator999.MoveNext() ? true : false)
				{
					using List<GClass12>.Enumerator enumerator2 = enumerator999.Current.effectPlayerPaints.GetEnumerator();
					while (enumerator2.MoveNext() ? true : false)
					{
						using List<GClass11>.Enumerator enumerator3 = enumerator2.Current.effectInfoPaints.GetEnumerator();
						while (enumerator3.MoveNext() ? true : false)
						{
							enumerator3.Current.index = 0;
						}
					}
				}
			}
			using List<GClass35>.Enumerator enumerator = skillPaint.skillFlys.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				using List<GClass12>.Enumerator enumerator2 = enumerator.Current.effectPlayerPaints.GetEnumerator();
				while (enumerator2.MoveNext() ? true : false)
				{
					using List<GClass11>.Enumerator enumerator3 = enumerator2.Current.effectInfoPaints.GetEnumerator();
					while (enumerator3.MoveNext() ? true : false)
					{
						enumerator3.Current.index = 0;
					}
				}
			}
		}

		public void method_22(GClass68 g)
		{
			if (method_2() && 0 == 0 && !isSpaceship)
			{
				g.method_28(Class0.gclass66_2, xSd, ySd - 3, 3);
			}
		}

		public void method_23()
		{
			int num = 0;
			xSd = x;
			if (Class0.smethod_3(x, y) && 0 == 0)
			{
				ySd = y;
				return;
			}
			ySd = y;
			do
			{
				if (num < 30)
				{
					num++;
					ySd += Class0.sbyte_0;
					continue;
				}
				return;
			}
			while (!Class0.smethod_3(xSd, ySd));
			if (ySd % Class0.sbyte_0 != 0 && 0 == 0)
			{
				ySd -= ySd % Class0.sbyte_0;
			}
		}

		public void method_24()
		{
			if (x <= 50 + smethod_5(cvx) || x >= Class0.int_6 - 50 - smethod_5(cvx))
			{
				cvx = 0;
			}
			if (y + 4 >= Class0.int_7)
			{
				status = 1;
				if (Equals(gclass25_0))
				{
					GClass43.smethod_3();
				}
				cvy = 0;
				cvx = 0;
				cp3 = 0;
				return;
			}
			if (y % Class0.sbyte_0 == 0 && Class0.smethod_3(x, y))
			{
				delayFall = 0;
				if (Equals(gclass25_0))
				{
					if (y - cySend > 0)
					{
						GClass0.smethod_3();
					}
					else if (x - cxSend != 0 || y - cySend < 0)
					{
						GClass0.smethod_3();
					}
					cvy = 0;
					cvx = 0;
					cp2 = 0;
					cp1 = 0;
					status = 1;
					cp3 = 0;
					method_30(1);
					return;
				}
				method_35();
				method_30(1);
				frame = 0;
			}
			if (cvy < -4)
			{
				frame = 8;
			}
			else
			{
				frame = 10;
			}
			x += cvx;
			if (!Equals(gclass25_0) && currentMovePoint != null)
			{
				int num = currentMovePoint.xEnd - x;
				if (num > 0)
				{
					if (cvx > num)
					{
						cvx = num;
					}
					if (cvx < 0)
					{
						cvx = num;
					}
				}
				else if (num < 0)
				{
					if (cvx < num)
					{
						cvx = num;
					}
					if (cvx > 0)
					{
						cvx = num;
					}
				}
				else
				{
					cvx = num;
				}
			}
			cvy++;
			if (cvy > 10)
			{
				cvy = 10;
			}
			y += cvy;
			if (dir == 1)
			{
				if (Class0.smethod_3(x + w / 2, y - h / 2) && x <= Class0.smethod_5(x + w / 2) + Class0.sbyte_0 / 2)
				{
					x = Class0.smethod_5(x + w / 2) - w / 2;
					cvx = 0;
				}
			}
			else if (Class0.smethod_3(x - w / 2, y - h / 2) && x >= Class0.smethod_5(x - w / 2) + Class0.sbyte_0 / 2)
			{
				x = Class0.smethod_5(x + Class0.sbyte_0 - w / 2) + w / 2;
				cvx = 0;
			}
			if (cvy > 3 && (yStartFall == 0 || yStartFall <= Class0.smethod_4(y + 3)) && Class0.smethod_3(x, y + 3))
			{
				if (Equals(gclass25_0))
				{
					yStartFall = 0;
					cvy = 0;
					cvx = 0;
					cp2 = 0;
					cp1 = 0;
					y = Class0.smethod_5(y + 3);
					status = 1;
					if (Equals(gclass25_0))
					{
						GClass43.smethod_3();
					}
					cp3 = 0;
					if (y - cySend > 0)
					{
						GClass0.smethod_3();
					}
					else if (x - cxSend != 0 || y - cySend < 0)
					{
						GClass0.smethod_3();
					}
					method_30(1);
				}
				else
				{
					method_35();
					y = Class0.smethod_5(y + 3);
					frame = 0;
					method_30(1);
				}
				return;
			}
			frame = 10;
			if (!Equals(gclass25_0))
			{
				if (Class0.smethod_3(x, y + 1))
				{
					frame = 0;
				}
				if (currentMovePoint != null && y > currentMovePoint.yEnd)
				{
					method_35();
				}
			}
		}

		public void method_25()
		{
			method_33();
			if (!Class0.smethod_3(x, y + 40) && !Class0.smethod_3(x, y + 100) && !Class0.smethod_3(x + w / 2, y) && !Class0.smethod_3(x - w / 2 - 1, y))
			{
				if (x <= 50 + smethod_5(cvx) && cvx < 0)
				{
					if (cvy == 0)
					{
						delayFall = 0;
					}
					yStartFall = 0;
					cvy = 0;
					cvx = 0;
					cp2 = 0;
					cp1 = 0;
					x = 50;
					status = 4;
					return;
				}
				if (x >= Class0.int_6 - 50 - smethod_5(cvx) && cvx >= 0)
				{
					if (cvy == 0)
					{
						delayFall = 0;
					}
					yStartFall = 0;
					cvy = 0;
					cvx = 0;
					cp2 = 0;
					cp1 = 0;
					x = Class0.int_6 - 50;
					status = 4;
					return;
				}
				if (status != 16 && (Class0.smethod_3(x, y - h - Class0.sbyte_0) || y - h < 0))
				{
					if (y - h < 0)
					{
						y = h;
					}
					frame = 8;
					status = 4;
					cvx = 0;
					cp2 = 0;
					currentMovePoint = null;
					return;
				}
				cp1++;
				if (cp1 >= 9)
				{
					cp1 = 0;
					if (!Equals(gclass25_0))
					{
						cvy = 0;
						cvx = 0;
					}
				}
				frame = 9;
				if (smethod_5(cvx) <= 4 && Equals(gclass25_0))
				{
					if (currentMovePoint != null)
					{
						int num = smethod_5(x - currentMovePoint.xEnd);
						int num2 = smethod_5(y - currentMovePoint.yEnd);
						if (num > num2 * 10)
						{
							frame = 9;
						}
						else if (num > num2 && num > 48 && num2 > 32)
						{
							frame = 9;
						}
						else
						{
							frame = 8;
						}
					}
					else
					{
						if (cvy < 0)
						{
							cvy = 0;
						}
						if (cvy > 16)
						{
							cvy = 16;
						}
						frame = 8;
					}
				}
				if (!Equals(gclass25_0))
				{
					if (smethod_5(cvx) < 2)
					{
						cvx = dir << 1;
					}
					if (cvy != 0)
					{
						frame = 8;
					}
					if (smethod_5(cvx) <= 2)
					{
						cp2++;
						if (cp2 > 32)
						{
							status = 4;
							cvx = 0;
							cvy = 0;
						}
					}
				}
				if (dir == 1)
				{
					if (Class0.smethod_3(x + w / 2, y - h / 2) || Class0.smethod_3(x + w / 2, y) || Class0.smethod_3(x + w / 2, y + 10))
					{
						cvx = 0;
						x = Class0.smethod_5(x + w / 2) - w / 2 - 1;
						if (cvy == 0)
						{
							currentMovePoint = null;
						}
					}
				}
				else if (Class0.smethod_3(x - w / 2 - 1, y - h / 2) || Class0.smethod_3(x - w / 2 - 1, y) || Class0.smethod_3(x - w / 2 - 1, y + 10))
				{
					cvx = 0;
					x = Class0.smethod_5(x - w / 2 - 1) + Class0.sbyte_0 + w / 2;
					if (cvy == 0)
					{
						currentMovePoint = null;
					}
				}
				x += cvx;
				y += cvy;
				if (Equals(gclass25_0))
				{
					if (cvx > 0)
					{
						cvx--;
					}
					else if (cvx < 0)
					{
						cvx++;
					}
					else if (cvy == 0)
					{
						status = 4;
						method_26();
						GClass0.smethod_3();
					}
					if (smethod_5(x - cxSend) > 96 || smethod_5(y - cySend) > 36)
					{
						GClass0.smethod_3();
					}
				}
			}
			else
			{
				if (cvy == 0)
				{
					delayFall = 0;
				}
				yStartFall = 0;
				cvy = 0;
				cvx = 0;
				cp2 = 0;
				cp1 = 0;
				status = 4;
			}
		}

		private void method_26()
		{
			bool flag = true;
			for (int i = 0; i < 150; i += 24)
			{
				if ((Class0.smethod_3(x, y + i) ? true : false) || y + i > Class0.int_5 * Class0.sbyte_0 - 24)
				{
					flag = false;
					break;
				}
			}
			if (flag && 0 == 0)
			{
				delayFall = 5;
			}
		}

		public void method_27()
		{
			cvx = 0;
			cvy = 0;
			cp1++;
			if (cp1 > 30)
			{
				cp1 = 0;
			}
			if (frameT == -1)
			{
				if (cp1 % 15 < 5)
				{
					frame = 0;
				}
				else
				{
					frame = 1;
				}
			}
			else
			{
				frame = frameT;
			}
			if (!Equals(gclass25_0) || 1 == 0)
			{
				cp3++;
				if (cp3 > 50)
				{
					cp3 = 0;
					currentMovePoint = null;
				}
			}
		}

		public float method_28()
		{
			if (Equals(gclass25_0) && 0 == 0)
			{
				return 0.3f;
			}
			int num = Math.Abs(gclass25_0.x - x);
			if (num >= 0 && num <= 50)
			{
				return 0.3f;
			}
			return 0.15f;
		}

		public void method_29()
		{
			if (x >= GClass3.int_0 && x <= GClass3.int_0 + GClass69.int_1 && GClass84.smethod_1() - lastTimeSoundPlayerRun > 300L)
			{
				lastTimeSoundPlayerRun = GClass84.smethod_1();
				GClass43.smethod_2(method_28());
			}
			int num = 0;
			if ((!Equals(gclass25_0) || 1 == 0) && currentMovePoint != null && 0 == 0)
			{
				num = smethod_5(x - currentMovePoint.xEnd);
			}
			if (GClass69.int_0 % 2 == 0 || 1 == 0)
			{
				cp1++;
			}
			if (head != 38 && head != 41 && head != 44 && cp1 >= 12)
			{
				cp1 = 0;
			}
			if ((head == 38 || head == 41 || head == 44) && cp1 >= 10)
			{
				cp1 = 0;
			}
			frame = (cp1 >> 1) + 2;
			if (Class0.smethod_3(x, y - 1) && 0 == 0)
			{
				x += cvx >> 1;
			}
			else
			{
				x += cvx;
			}
			if (dir == 1)
			{
				if (Class0.smethod_3(x + w / 2, y - h / 2) && 0 == 0)
				{
					if (Equals(gclass25_0) && 0 == 0)
					{
						cvx = 0;
						x = Class0.smethod_5(x + w / 2) - w / 2;
					}
					else
					{
						method_35();
					}
				}
			}
			else if (Class0.smethod_3(x - w / 2 - 1, y - h / 2) && 0 == 0)
			{
				if (Equals(gclass25_0) && 0 == 0)
				{
					cvx = 0;
					x = Class0.smethod_5(x - w / 2 - 1) + Class0.sbyte_0 + w / 2;
				}
				else
				{
					method_35();
				}
			}
			if (Equals(gclass25_0) && 0 == 0)
			{
				if (cvx > 0)
				{
					cvx--;
				}
				else if (cvx < 0)
				{
					cvx++;
				}
				else
				{
					if (x - cxSend != 0 && 0 == 0)
					{
						GClass0.smethod_3();
					}
					status = 1;
				}
			}
			if (!Class0.smethod_3(x, y) || 1 == 0)
			{
				if (Equals(gclass25_0) && 0 == 0)
				{
					if (((x - cxSend != 0) ? true : false) || y - cySend != 0)
					{
						GClass0.smethod_3();
					}
					frame = 8;
					status = 4;
					cvx = 3 * dir;
					cp2 = 0;
				}
				else
				{
					method_35();
				}
			}
			if ((!Equals(gclass25_0) || 1 == 0) && currentMovePoint != null && 0 == 0 && smethod_5(x - currentMovePoint.xEnd) > num)
			{
				method_35();
			}
			if (GClass69.int_0 % 15 == 0 || 1 == 0)
			{
				method_30(0);
			}
		}

		public void method_30(int type)
		{
			if (type == 0 || 1 == 0)
			{
				GClass9 item = new GClass9(this, 1, w / 2 - 5, 0, -1, 71, 72);
				effects.Add(item);
			}
			if (type == 1)
			{
				GClass9 item2 = new GClass9(this, 1, 0, 0, GClass45.int_3, 68, 69, 70);
				effects.Add(item2);
			}
		}

		public void method_31()
		{
			method_33();
			if (Class0.smethod_3(x, y) && 0 == 0)
			{
				method_30(1);
			}
			x += cvx;
			y += cvy;
			if (y < 0)
			{
				y = 0;
				cvy = -1;
			}
			cvy++;
			if (cvy > 0)
			{
				cvy = 0;
			}
			if ((!Equals(gclass25_0) || 1 == 0) && currentMovePoint != null && 0 == 0)
			{
				int num = currentMovePoint.xEnd - x;
				if (num > 0)
				{
					if (cvx > num)
					{
						cvx = num;
					}
					if (cvx < 0)
					{
						cvx = num;
					}
				}
				else if (num < 0)
				{
					if (cvx < num)
					{
						cvx = num;
					}
					if (cvx > 0)
					{
						cvx = num;
					}
				}
				else
				{
					cvx = num;
				}
			}
			if (dir == 1)
			{
				if (Class0.smethod_3(x + w / 2, y - 1) && 0 == 0 && x <= Class0.smethod_5(x + w / 2) + 12)
				{
					x = Class0.smethod_5(x + w / 2) - w / 2;
					cvx = 0;
				}
			}
			else if (Class0.smethod_3(x - w / 2, y - 1) && 0 == 0 && x >= Class0.smethod_5(x - w / 2) + 12)
			{
				x = Class0.smethod_5(x + Class0.sbyte_0 / 2 - w / 2) + w / 2;
				cvx = 0;
			}
			if (cvy == 0 || 1 == 0)
			{
				if (Equals(gclass25_0) && 0 == 0)
				{
					method_36();
				}
				else
				{
					method_35();
				}
			}
			if (status != 16 && ((Class0.smethod_3(x, y - h) ? true : false) || y - h < 0))
			{
				bool_3 = false;
				status = 4;
				cp1 = 0;
				cp2 = 0;
				cvy = 1;
				delayFall = 0;
				if (y < 0)
				{
					y = 0;
				}
				y = Class0.smethod_4(y + h);
			}
			if (cp3 < 0)
			{
				cp3++;
			}
			frame = 8;
			if ((!Equals(gclass25_0) || 1 == 0) && currentMovePoint != null && 0 == 0 && y < currentMovePoint.yEnd)
			{
				method_35();
			}
		}

		public void method_32()
		{
			if (GClass69.int_0 % 5 == 0 || 1 == 0)
			{
				if (frameMount < 3)
				{
					frameMount++;
				}
				else
				{
					frameMount = 0;
				}
			}
			if (isStartMount && 0 == 0 && (!isMount || 1 == 0))
			{
				yMount = y;
				if (transMount == 0 || 1 == 0)
				{
					if (xMount - x >= speedMount)
					{
						xMount -= speedMount;
						return;
					}
					xMount = x;
					isMount = true;
					isEndMount = false;
				}
				else if (transMount == 2)
				{
					if (x - xMount >= speedMount)
					{
						xMount += speedMount;
						return;
					}
					xMount = x;
					isMount = true;
					isEndMount = false;
				}
			}
			else if (isMount && 0 == 0)
			{
				if (status == 14 || ySd - y < 24)
				{
					method_34();
				}
				if (method_15() == null || 1 == 0)
				{
					if (cp1 % 15 < 5)
					{
						frame = 0;
					}
					else
					{
						frame = 1;
					}
				}
				transMount = dir;
				if (transMount < 0)
				{
					transMount = 0;
					dxMount = -19;
				}
				else if (transMount == 1)
				{
					transMount = 2;
					dxMount = -93;
				}
				if (method_15() != null && 0 == 0)
				{
					dyMount = -45;
				}
				else
				{
					dyMount = -54;
				}
				yMount = y;
				xMount = x;
			}
			else if (isEndMount && 0 == 0)
			{
				if (transMount == 0 || 1 == 0)
				{
					if (xMount > GClass3.int_0 - 100)
					{
						xMount -= 60;
						return;
					}
					isStartMount = false;
					isMount = false;
					isEndMount = false;
				}
				else if (transMount == 2)
				{
					if (xMount < GClass3.int_0 + GClass69.int_1 + 50)
					{
						xMount += 60;
						return;
					}
					isStartMount = false;
					isMount = false;
					isEndMount = false;
				}
			}
			else if (!isStartMount || false || !isMount || false || !isEndMount || 1 == 0)
			{
				xMount = GClass3.int_0 - 100;
				yMount = GClass3.int_1 - 100;
			}
		}

		public void method_33()
		{
			isHaveMount = mount != -1;
			if (!isHaveMount)
			{
				return;
			}
			if (ySd - y <= 20)
			{
				xChar = x;
			}
			if (xdis < 100)
			{
				xdis = Math.Abs(xChar - x);
			}
			if (xdis >= 70 && ySd - y > 30 && (!isStartMount || 1 == 0) && (!isEndMount || 1 == 0))
			{
				transMount = dir;
				speedMount = 50;
				if (transMount < 0)
				{
					transMount = 0;
					xMount = GClass3.int_0 + GClass69.int_1 + 50;
					dxMount = -57;
				}
				else if (transMount == 1)
				{
					transMount = 2;
					xMount = GClass3.int_0 - 100;
					dxMount = -99;
				}
				dyMount = -51;
				yMount = x;
				frameMount = 0;
				frameNewMount = 0;
				isMount = false;
				isEndMount = false;
				isStartMount = true;
			}
		}

		public void method_34()
		{
			if (ySd - y < 24 && (!isEndMount || 1 == 0))
			{
				isStartMount = false;
				isMount = false;
				isEndMount = true;
				xdis = 0;
			}
		}

		private void method_35()
		{
			status = 6;
			cp3 = 0;
			cvx = 0;
			cvy = 0;
			cp2 = 0;
			cp1 = 0;
		}

		public void method_36()
		{
			yStartFall = y;
			cp1 = 0;
			cp2 = 0;
			status = 10;
			cvy = 0;
			cvx = dir << 2;
			if (Equals(gclass25_0) && 0 == 0 && (((x - cxSend != 0) ? true : false) || y - cySend != 0) && (Math.Abs(gclass25_0.x - gclass25_0.cxSend) > 96 || Math.Abs(gclass25_0.y - gclass25_0.cySend) > 36))
			{
				GClass0.smethod_3();
			}
		}

		public static int smethod_5(int i)
		{
			if (i > 0)
			{
				return i;
			}
			return -i;
		}

		public void method_37(int toX, int toY)
		{
			if (Math.Abs(toX - x) <= 100 && Math.Abs(toY - y) <= 300)
			{
				int num = 0;
				int act = 0;
				int num2 = toX - x;
				int num3 = toY - y;
				if ((num2 == 0 || 1 == 0) && (num3 == 0 || 1 == 0))
				{
					act = 1;
					cp3 = 0;
				}
				else if (num3 == 0 || 1 == 0)
				{
					act = 2;
					if (num2 > 0)
					{
						num = 1;
					}
					if (num2 < 0)
					{
						num = -1;
					}
				}
				else if (num3 != 0 && 0 == 0)
				{
					if (num3 < 0)
					{
						act = 3;
					}
					if (num3 > 0)
					{
						act = 4;
					}
					if (num2 < 0)
					{
						num = -1;
					}
					if (num2 > 0)
					{
						num = 1;
					}
				}
				movePoints.Add(new GClass29(toX, toY, act, num));
				if (status != 6)
				{
					statusBeforeNothing = status;
				}
				cp3 = 0;
			}
			else
			{
				x = toX;
				y = toY;
				movePoints.Clear();
				status = 6;
				cp3 = 0;
				currentMovePoint = null;
			}
		}

		public void method_38()
		{
			if (((skillPaint != null) ? true : false) || method_15() != null)
			{
				return;
			}
			GClass3.smethod_0().cmdQues.isShow = false;
			focus.Clear();
			int num = GClass3.int_0 + 10;
			int num2 = GClass3.int_1 + 10;
			int num3 = GClass3.int_0 + GClass69.int_1 - 10;
			int num4 = GClass3.int_1 + GClass69.int_2 - 10;
			int num5 = 0;
			using (List<GClass25>.Enumerator enumerator = GClass3.list_1.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass25 current = enumerator.Current;
					if (current.x >= num && current.y >= num2 && current.x <= num3 && current.y <= num4)
					{
						focus.Add(current);
						if (playerFocus != null && 0 == 0 && playerFocus.Equals(current) && 0 == 0)
						{
							num5 = focus.Count;
						}
					}
				}
			}
			using (List<GClass22>.Enumerator enumerator2 = GClass3.list_3.GetEnumerator())
			{
				while (enumerator2.MoveNext() ? true : false)
				{
					GClass22 current2 = enumerator2.Current;
					if (current2.x >= num && current2.y >= num2 && current2.x <= num3 && current2.y <= num4)
					{
						focus.Add(current2);
						if (itemFocus != null && 0 == 0 && itemFocus.Equals(current2) && 0 == 0)
						{
							num5 = focus.Count;
						}
					}
				}
			}
			using (List<GClass23>.Enumerator enumerator3 = GClass3.list_0.GetEnumerator())
			{
				while (enumerator3.MoveNext() ? true : false)
				{
					GClass23 current3 = enumerator3.Current;
					if (current3.x >= num && current3.y >= num2 && current3.x <= num3 && current3.y <= num4)
					{
						focus.Add(current3);
						if (mobFocus != null && 0 == 0 && mobFocus.Equals(current3) && 0 == 0)
						{
							num5 = focus.Count;
						}
					}
				}
			}
			using (List<GClass24>.Enumerator enumerator4 = GClass3.list_2.GetEnumerator())
			{
				while (enumerator4.MoveNext() ? true : false)
				{
					GClass24 current4 = enumerator4.Current;
					if (current4.x >= num && current4.y >= num2 && current4.x <= num3 && current4.y <= num4)
					{
						focus.Add(current4);
						if (npcFocus != null && 0 == 0 && npcFocus.Equals(current4) && 0 == 0)
						{
							num5 = focus.Count;
						}
					}
				}
			}
			if (focus.Count > 0)
			{
				if (num5 >= focus.Count)
				{
					num5 = 0;
				}
				method_44(focus[num5]);
			}
			else
			{
				mobFocus = null;
				npcFocus = null;
				playerFocus = null;
				itemFocus = null;
			}
		}

		public bool method_39(GClass25 player)
		{
			if (!Equals(gclass25_0) || 1 == 0)
			{
				return false;
			}
			if (player != null && 0 == 0 && ((mySkill != null) ? true : false))
			{
				if (mySkill.template.id == 13)
				{
					return true;
				}
				if (player.hp > 0L && (!player.isDie || 1 == 0) && !player.isDead)
				{
					if (typePk == 1 && playerFocus.typePk == 1 && playerFocus.id == killId)
					{
						return true;
					}
					if (player.typePk == 3)
					{
						return true;
					}
					if (player.typePk != 3 && player.id < 0)
					{
						return false;
					}
					if (Class0.int_0 != 0 && 0 == 0)
					{
						if (typePk == 2)
						{
							return true;
						}
						if (player.typePk == 2)
						{
							return true;
						}
						if (typeFlag > 0 && player.typeFlag > 0 && typeFlag != player.typeFlag)
						{
							return true;
						}
					}
					return false;
				}
				return false;
			}
			return false;
		}

		public void method_40()
		{
			if (gclass25_0.mobFocus != null && mobFocus.hp <= 0L && timeFocusToMob > 5)
			{
				timeFocusToMob = 5;
			}
			else if (gclass25_0.skillPaint == null && gclass25_0.dart == null)
			{
				if (timeFocusToMob > 0)
				{
					timeFocusToMob--;
				}
				else
				{
					if (GClass69.int_0 % 2 == 0 || method_39(playerFocus) || (GClass3.bool_3 && GClass3.bool_2))
					{
						return;
					}
					int num = 60;
					int[] array = new int[4] { -1, -1, -1, -1 };
					int num2 = GClass3.int_0 - 10;
					int num3 = GClass3.int_0 + GClass69.int_1 + 10;
					int num4 = GClass3.int_1;
					int num5 = GClass3.int_1 + GClass69.int_2 + 10;
					if (bool_7)
					{
						if ((mobFocus != null && mobFocus.status != 1 && mobFocus.status != 0 && num2 <= mobFocus.x && mobFocus.x <= num3 && num4 <= mobFocus.y && mobFocus.y <= num5) || (npcFocus != null && num2 <= npcFocus.x && npcFocus.x <= num3 && num4 <= npcFocus.y && npcFocus.y <= num5) || (playerFocus != null && num2 <= playerFocus.x && playerFocus.x <= num3 && num4 <= playerFocus.y && playerFocus.y <= num5) || (itemFocus != null && num2 <= itemFocus.x && itemFocus.x <= num3 && num4 <= itemFocus.y && itemFocus.y <= num5))
						{
							return;
						}
						bool_7 = false;
					}
					num2 = gclass25_0.x - 160;
					num3 = gclass25_0.x + 160;
					num4 = gclass25_0.y - 60;
					num5 = gclass25_0.y + 60;
					if (npcFocus == null)
					{
						for (int i = 0; i < GClass3.list_2.Count; i++)
						{
							GClass24 gClass = GClass3.list_2[i];
							int num6 = Math.Abs(gclass25_0.x - gClass.x);
							int num7 = Math.Abs(gclass25_0.y - gClass.y);
							int num8 = ((num6 <= num7) ? num7 : num6);
							num2 = gclass25_0.x - 160;
							num3 = gclass25_0.x + 160;
							num4 = gclass25_0.y - 60;
							num5 = gclass25_0.y + 60;
							if (num2 <= gClass.x && gClass.x <= num3 && num4 <= gClass.y && gClass.y <= num5 && (npcFocus == null || num8 < array[1]))
							{
								npcFocus = gClass;
								array[1] = num8;
							}
						}
					}
					else
					{
						if (num2 <= npcFocus.x && npcFocus.x <= num3 && num4 <= npcFocus.y && npcFocus.y <= num5)
						{
							method_41(1);
							return;
						}
						npcFocus = null;
						for (int j = 0; j < GClass3.list_2.Count; j++)
						{
							GClass24 gClass2 = GClass3.list_2[j];
							int num9 = Math.Abs(gclass25_0.x - gClass2.x);
							int num10 = Math.Abs(gclass25_0.y - gClass2.y);
							int num11 = ((num9 <= num10) ? num10 : num9);
							num2 = gclass25_0.x - 160;
							num3 = gclass25_0.x + 160;
							num4 = gclass25_0.y - 60;
							num5 = gclass25_0.y + 60;
							if (num2 <= gClass2.x && gClass2.x <= num3 && num4 <= gClass2.y && gClass2.y <= num5 && (npcFocus == null || num11 < array[1]))
							{
								npcFocus = gClass2;
								array[1] = num11;
							}
						}
					}
					if (itemFocus == null)
					{
						for (int k = 0; k < GClass3.list_3.Count; k++)
						{
							GClass22 gClass3 = GClass3.list_3[k];
							int num12 = Math.Abs(gclass25_0.x - gClass3.x);
							int num13 = Math.Abs(gclass25_0.y - gClass3.y);
							int num14 = ((num12 <= num13) ? num13 : num12);
							if (num12 <= 48 && num13 <= 48 && (itemFocus == null || num14 < array[3]))
							{
								itemFocus = gClass3;
								array[3] = num14;
							}
						}
					}
					else
					{
						if (num2 <= itemFocus.x && itemFocus.x <= num3 && num4 <= itemFocus.y && itemFocus.y <= num5)
						{
							method_41(3);
							return;
						}
						itemFocus = null;
						for (int l = 0; l < GClass3.list_3.Count; l++)
						{
							GClass22 gClass4 = GClass3.list_3[l];
							int num15 = Math.Abs(gclass25_0.x - gClass4.x);
							int num16 = Math.Abs(gclass25_0.y - gClass4.y);
							int num17 = ((num15 <= num16) ? num16 : num15);
							if (num2 <= gClass4.x && gClass4.x <= num3 && num4 <= gClass4.y && gClass4.y <= num5 && (itemFocus == null || num17 < array[3]))
							{
								itemFocus = gClass4;
								array[3] = num17;
							}
						}
					}
					num2 = gclass25_0.x - gclass25_0.mySkill.template.range - 30;
					num3 = gclass25_0.x + gclass25_0.mySkill.template.range + 30;
					num4 = gclass25_0.y - gclass25_0.mySkill.template.range - num - 60;
					num5 = gclass25_0.y + gclass25_0.mySkill.template.range + 60;
					if (num5 > gclass25_0.y + 90)
					{
						num5 = gclass25_0.y + 90;
					}
					if (mobFocus == null)
					{
						for (int m = 0; m < GClass3.list_0.Count; m++)
						{
							GClass23 gClass5 = GClass3.list_0[m];
							int num18 = Math.Abs(gclass25_0.x - gClass5.x);
							int num19 = Math.Abs(gclass25_0.y - gClass5.y);
							int num20 = ((num18 <= num19) ? num19 : num18);
							if (num2 <= gClass5.x && gClass5.x <= num3 && num4 <= gClass5.y && gClass5.y <= num5 && (mobFocus == null || num20 < array[0]))
							{
								mobFocus = gClass5;
								array[0] = num20;
							}
						}
					}
					else
					{
						if (mobFocus.status != 1 && mobFocus.status != 0 && num2 <= mobFocus.x && mobFocus.x <= num3 && num4 <= mobFocus.y && mobFocus.y <= num5)
						{
							method_41(0);
							return;
						}
						mobFocus = null;
						for (int n = 0; n < GClass3.list_0.Count; n++)
						{
							GClass23 gClass6 = GClass3.list_0[n];
							int num21 = Math.Abs(gclass25_0.x - gClass6.x);
							int num22 = Math.Abs(gclass25_0.y - gClass6.y);
							int num23 = ((num21 <= num22) ? num22 : num21);
							if (num2 <= gClass6.x && gClass6.x <= num3 && num4 <= gClass6.y && gClass6.y <= num5 && (mobFocus == null || num23 < array[0]))
							{
								mobFocus = gClass6;
								array[0] = num23;
							}
						}
					}
					if (!GClass3.bool_3 || !GClass3.bool_2)
					{
						if (playerFocus == null)
						{
							for (int num24 = 0; num24 < GClass3.list_1.Count; num24++)
							{
								GClass25 gClass7 = GClass3.list_1[num24];
								if (gClass7.status != 15)
								{
									int num25 = Math.Abs(gclass25_0.x - gClass7.x);
									int num26 = Math.Abs(gclass25_0.y - gClass7.y);
									int num27 = ((num25 <= num26) ? num26 : num25);
									if (num2 <= gClass7.x && gClass7.x <= num3 && num4 <= gClass7.y && gClass7.y <= num5 && (playerFocus == null || num27 < array[2]))
									{
										playerFocus = gClass7;
										array[2] = num27;
									}
								}
							}
						}
						else
						{
							if (num2 <= playerFocus.x && playerFocus.x <= num3 && num4 <= playerFocus.y && playerFocus.y <= num5 && playerFocus.status != 15)
							{
								method_41(2);
								return;
							}
							playerFocus = null;
							for (int num28 = 0; num28 < GClass3.list_1.Count; num28++)
							{
								GClass25 gClass8 = GClass3.list_1[num28];
								if (gClass8.status != 15)
								{
									int num29 = Math.Abs(gclass25_0.x - gClass8.x);
									int num30 = Math.Abs(gclass25_0.y - gClass8.y);
									int num31 = ((num29 <= num30) ? num30 : num29);
									if (num2 <= gClass8.x && gClass8.x <= num3 && num4 <= gClass8.y && gClass8.y <= num5 && (playerFocus == null || num31 < array[2]))
									{
										playerFocus = gClass8;
										array[2] = num31;
									}
								}
							}
						}
					}
					int num32 = -1;
					for (int num33 = 0; num33 < array.Length; num33++)
					{
						if (num32 == -1)
						{
							if (array[num33] != -1)
							{
								num32 = num33;
							}
						}
						else if (array[num33] < array[num32] && array[num33] != -1)
						{
							num32 = num33;
						}
					}
					method_41(num32);
					if (Equals(gclass25_0) && method_39(gclass25_0.playerFocus))
					{
						npcFocus = null;
						itemFocus = null;
					}
				}
			}
			else
			{
				timeFocusToMob = 70;
			}
		}

		public void method_41(int index)
		{
			switch (index)
			{
			case 0:
				npcFocus = null;
				playerFocus = null;
				itemFocus = null;
				break;
			case 1:
				mobFocus = null;
				playerFocus = null;
				itemFocus = null;
				break;
			case 2:
				mobFocus = null;
				npcFocus = null;
				itemFocus = null;
				break;
			case 3:
				mobFocus = null;
				npcFocus = null;
				playerFocus = null;
				break;
			}
		}

		public bool method_42()
		{
			return mp >= method_43();
		}

		public int method_43()
		{
			try
			{
				if (mySkill.template.typeManaUse != 1)
				{
					return mySkill.method_1();
				}
				return (int)(mySkill.method_1() * maxMp / 100L);
			}
			catch
			{
			}
			return 0;
		}

		public void method_44(GInterface0 objectz)
		{
			if ((objectz != null) ? true : false)
			{
				if (objectz is GClass23 && 0 == 0)
				{
					mobFocus = (GClass23)objectz;
					npcFocus = null;
					playerFocus = null;
					itemFocus = null;
				}
				else if (objectz is GClass24 && 0 == 0)
				{
					mobFocus = null;
					npcFocus = (GClass24)objectz;
					playerFocus = null;
					itemFocus = null;
				}
				else if (objectz is GClass25 && 0 == 0)
				{
					mobFocus = null;
					npcFocus = null;
					playerFocus = (GClass25)objectz;
					itemFocus = null;
				}
				else if (objectz is GClass22 && 0 == 0)
				{
					mobFocus = null;
					npcFocus = null;
					playerFocus = null;
					itemFocus = (GClass22)objectz;
				}
				bool_7 = true;
			}
		}

		public GClass34 method_45(int id)
		{
			using (List<GClass34>.Enumerator enumerator = skills.GetEnumerator())
			{
				while (enumerator.MoveNext() ? true : false)
				{
					GClass34 current = enumerator.Current;
					if (current.template.id == id)
					{
						return current;
					}
				}
			}
			return null;
		}

		public bool method_46()
		{
			if (mySkill != null && 0 == 0)
			{
				return mySkill.template.type == 1;
			}
			return false;
		}

		public bool method_47()
		{
			if (mySkill == null || 1 == 0)
			{
				return false;
			}
			if (mySkill.level == 0 || 1 == 0)
			{
				return false;
			}
			if ((mySkill.template.typeManaUse == 0 || 1 == 0) && mp < mySkill.method_1())
			{
				GClass79.smethod_3(GClass83.string_1, 0);
				return false;
			}
			if (mySkill.template.typeManaUse == 1 && mp * 100L / maxMp < mySkill.method_1())
			{
				GClass79.smethod_3(GClass83.string_1, 0);
				return false;
			}
			return true;
		}

		public void method_48(string info)
		{
			chatInfo.method_3(info);
		}

		public int imethod_3()
		{
			return h;
		}

		public int imethod_2()
		{
			return w;
		}

		public int imethod_0()
		{
			return x;
		}

		public int imethod_1()
		{
			return y;
		}

		public string method_49()
		{
			if (level >= GClass69.list_4.Count - 1)
			{
				return "0.00%";
			}
			long num = GClass69.list_4[level].power;
			long num2 = GClass69.list_4[level + 1].power;
			return $"{(float)(power - num) * 100f / (float)(num2 - num):0.##}";
		}

		public int method_50()
		{
			return level;
		}

		public static int smethod_6(long power)
		{
			int num = 0;
			while (true)
			{
				if (num < GClass69.list_4.Count)
				{
					if (power >= GClass69.list_4[num].power)
					{
						if (num < GClass69.list_4.Count - 1 && power < GClass69.list_4[num + 1].power)
						{
							return num;
						}
						if (num == GClass69.list_4.Count - 1)
						{
							break;
						}
					}
					num++;
					continue;
				}
				return 0;
			}
			return num;
		}

		public int imethod_4()
		{
			return dir;
		}

		bool GInterface0.imethod_5()
		{
			if ((!isDie || 1 == 0) && hp > 0L)
			{
				return isDead;
			}
			return true;
		}

		public List<GClass9> imethod_6()
		{
			return effects;
		}

		public void imethod_7(bool isBlind)
		{
			base.isBlind = isBlind;
			if (Equals(gclass25_0) && 0 == 0)
			{
				bool_2 = (isLockMove = isBlind);
			}
		}

		public void imethod_8(bool isChocolate)
		{
			base.isChocolate = isChocolate;
			if (Equals(gclass25_0) && 0 == 0)
			{
				bool_2 = (isLockMove = isChocolate);
			}
		}

		bool GInterface0.imethod_9()
		{
			return isChocolate;
		}
	}
}
