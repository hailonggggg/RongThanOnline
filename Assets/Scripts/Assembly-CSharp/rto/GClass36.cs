namespace rto
{
	public class GClass36
	{
		public int param;

		public int paramWithLevel;

		public GClass38 template;

		public string method_0()
		{
			return template.name.Replace("#", param.ToString());
		}

		public string method_1(int level)
		{
			return template.name.Replace("#", GClass84.smethod_16(param + (level - 1) * paramWithLevel));
		}
	}
}
