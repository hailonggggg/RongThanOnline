namespace rto
{
	public class GClass61
	{
		public sbyte command;

		private GClass62 dis;

		private GClass63 dos;

		public GClass61(int command)
		{
			this.command = (sbyte)command;
			dos = new GClass63();
		}

		public GClass61()
		{
			dos = new GClass63();
		}

		public GClass61(sbyte command)
		{
			this.command = command;
			dos = new GClass63();
		}

		public GClass61(sbyte command, sbyte[] data)
		{
			this.command = command;
			dis = new GClass62(data);
		}

		public sbyte[] method_0()
		{
			return dos.method_20();
		}

		public GClass62 method_1()
		{
			return dis;
		}

		public GClass63 method_2()
		{
			return dos;
		}

		public int method_3()
		{
			return dis.method_6();
		}

		public void method_4()
		{
		}
	}
}
