namespace rto
{
	public class GClass17
	{
		public int param;

		public GClass18 template;

		public string method_0()
		{
			return template.name.Replace("#", param.ToString());
		}

		public GClass17()
		{
		}

		public GClass17(int tempId, int param)
		{
			this.param = param;
			template = GClass69.list_0[tempId];
		}
	}
}
