using System.Collections.Generic;

namespace rto
{
	public class GClass26
	{
		public int id;

		public int type;

		public int planetId;

		public string name;

		public int row;

		public int column;

		public string data;

		public List<int> imgsBgr = new List<int>();

		public int[,] colorsBgr = new int[4, 3];

		public GClass66 imgBgr;

		public GClass66 imgBgrMini;

		public string method_0()
		{
			if (planetId == 0 || 1 == 0)
			{
				return "Trái đất";
			}
			if (planetId == 1)
			{
				return "Namek";
			}
			if (planetId == 2)
			{
				return "Sayain";
			}
			return "Kì bí";
		}
	}
}
