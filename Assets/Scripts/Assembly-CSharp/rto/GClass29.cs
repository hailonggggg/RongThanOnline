namespace rto
{
	public class GClass29
	{
		public int xEnd;

		public int yEnd;

		public int dir;

		public int cvx;

		public int cvy;

		public int status;

		public GClass29(int xEnd, int yEnd, int act, int dir)
		{
			this.xEnd = xEnd;
			this.yEnd = yEnd;
			this.dir = dir;
			status = act;
		}

		public GClass29(int xEnd, int yEnd)
		{
			this.xEnd = xEnd;
			this.yEnd = yEnd;
		}
	}
}
