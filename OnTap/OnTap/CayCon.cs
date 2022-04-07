using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap
{
	class CayMit : Cay
	{
		public string tenCay = "cay mít";
		public override void rungLa()
		{
			Console.WriteLine("rung la mit");
		}
	}

	class CayXoai : Cay
	{
		public string tenCay = "cay xoai";
		public override void rungLa()
		{
			Console.WriteLine("rung la xoai");
		}
	}
}
