using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car SH = new Car("SH 150i");

			SH.honk();

			Console.WriteLine($"{SH.brand} {SH.name}");

		}
	}
}
