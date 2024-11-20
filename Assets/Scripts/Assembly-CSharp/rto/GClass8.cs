using System.Collections.Generic;

namespace rto
{
	public class GClass8
	{
		public List<GClass12> startDarts = new List<GClass12>();

		public List<int> midDarts = new List<int>();

		public List<int> endDarts = new List<int>();

		public int dx;

		public int dy;

		public GClass8 method_0()
		{
			GClass8 gClass = new GClass8();
			gClass.dx = dx;
			gClass.dy = dy;
			gClass.startDarts.AddRange(startDarts);
			gClass.endDarts.AddRange(endDarts);
			gClass.midDarts.AddRange(midDarts);
			return gClass;
		}
	}
}
