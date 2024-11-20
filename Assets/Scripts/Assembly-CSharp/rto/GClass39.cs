using System.Collections.Generic;

namespace rto
{
	public class GClass39
	{
		public int id;

		public int index;

		public List<GClass35> skillStands;

		public List<GClass35> skillFlys;

		public GClass39()
		{
			index = 0;
		}

		public GClass39 method_0()
		{
			GClass39 gClass = new GClass39();
			gClass.id = id;
			gClass.index = 0;
			gClass.skillFlys = new List<GClass35>();
			gClass.skillStands = new List<GClass35>();

            using (List<GClass35>.Enumerator enumerator999 = skillStands.GetEnumerator())
			{
				while (enumerator999.MoveNext() ? true : false)
				{
					GClass35 current = enumerator999.Current;
					GClass35 gClass2 = new GClass35();
					gClass2.frame = current.frame;
					if (current.dart != null && 0 == 0)
					{
						gClass2.dart = current.dart.method_0();
					}
					else
					{
						gClass2.dart = null;
					}
					gClass2.effectPlayerPaints = new List<GClass12>();
					using (List<GClass12>.Enumerator enumerator2 = current.effectPlayerPaints.GetEnumerator())
					{
						while (enumerator2.MoveNext() ? true : false)
						{
							GClass12 current2 = enumerator2.Current;
							GClass12 gClass3 = new GClass12
							{
								effectInfoPaints = new List<GClass11>()
							};
							using (List<GClass11>.Enumerator enumerator3 = current2.effectInfoPaints.GetEnumerator())
							{
								while (enumerator3.MoveNext() ? true : false)
								{
									GClass11 current3 = enumerator3.Current;
									GClass11 gClass4 = new GClass11
									{
										index = 0,
										effectInfoImages = new List<GClass10>()
									};
									using (List<GClass10>.Enumerator enumerator4 = current3.effectInfoImages.GetEnumerator())
									{
										while (enumerator4.MoveNext() ? true : false)
										{
											GClass10 current4 = enumerator4.Current;
											GClass10 gClass5 = new GClass10();
											gClass5.imgId = current4.imgId;
											gClass5.dx = current4.dx;
											gClass5.dy = current4.dy;
											gClass4.effectInfoImages.Add(gClass5);
										}
									}
									gClass3.effectInfoPaints.Add(gClass4);
								}
							}
							gClass2.effectPlayerPaints.Add(gClass3);
						}
					}
					gClass.skillStands.Add(current);
				}
			}
			using List<GClass35>.Enumerator enumerator = skillFlys.GetEnumerator();
			while (enumerator.MoveNext() ? true : false)
			{
				GClass35 current5 = enumerator.Current;
				GClass35 gClass6 = new GClass35();
				gClass6.frame = current5.frame;
				if (current5.dart != null && 0 == 0)
				{
					gClass6.dart = current5.dart.method_0();
				}
				else
				{
					gClass6.dart = null;
				}
				gClass6.effectPlayerPaints = new List<GClass12>();
				using (List<GClass12>.Enumerator enumerator2 = current5.effectPlayerPaints.GetEnumerator())
				{
					while (enumerator2.MoveNext() ? true : false)
					{
						GClass12 current6 = enumerator2.Current;
						GClass12 gClass7 = new GClass12
						{
							effectInfoPaints = new List<GClass11>()
						};
						using (List<GClass11>.Enumerator enumerator3 = current6.effectInfoPaints.GetEnumerator())
						{
							while (enumerator3.MoveNext() ? true : false)
							{
								GClass11 current7 = enumerator3.Current;
								GClass11 gClass8 = new GClass11
								{
									index = 0,
									effectInfoImages = new List<GClass10>()
								};
								using (List<GClass10>.Enumerator enumerator4 = current7.effectInfoImages.GetEnumerator())
								{
									while (enumerator4.MoveNext() ? true : false)
									{
										GClass10 current8 = enumerator4.Current;
										GClass10 gClass9 = new GClass10();
										gClass9.imgId = current8.imgId;
										gClass9.dx = current8.dx;
										gClass9.dy = current8.dy;
										gClass8.effectInfoImages.Add(gClass9);
									}
								}
								gClass7.effectInfoPaints.Add(gClass8);
							}
						}
						gClass6.effectPlayerPaints.Add(gClass7);
					}
				}
				gClass.skillFlys.Add(current5);
			}
			return gClass;
		}
	}
}
