using System.Collections.Generic;

namespace rto
{
	public abstract class GClass21
	{
		public int id;

		public string name;

		public int gender = -1;

		public long hp;

		public long mp;

		public long maxHp;

		public long maxMp;

		public int speed;

		public int dir = 1;

		public int status = 1;

		public int w;

		public int h;

		public int x;

		public int y;

		public int head;

		public int body;

		public int leg;

		public int frame;

		public int xSd;

		public int ySd;

		public bool isDie;

		public bool isBlind;

		public List<GClass9> effects = new List<GClass9>();

		public bool isChocolate;
	}
}
