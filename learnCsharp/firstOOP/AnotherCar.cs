using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstOOP
{
	internal class AnotherCar
	{
		 
		public string otherModel { get; set; }
		public string otherName;
		public int otherYear;
		public string otherEngine() {
			Console.WriteLine($"this {otherModel} {otherName} producted in {otherYear}");
			return "asdkhbjasd";
		}

		
	}
}
