using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
	internal class TrongCay
	{
		public int id { get; set; }
		public string tenCay { get; set; }

		public TrongCay()
		{
			id = 0;
			tenCay = "cai cay";
		}

		public TrongCay(int cId, string cTenCay)
		{
			this.id = cId;
			this.tenCay = cTenCay;
		}

		public void showCay() {
			Console.WriteLine($"{id} | {tenCay}");
		}
	}
}
