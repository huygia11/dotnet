using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
	internal class Program
	{
		enum Level {
			Low,
			Medium,
			High
		}

		enum Months {
			January,
			February,
			March,
			April,
			May,
			June,
			July,
			August,
			September,
			October,
			November,
			December
		}

		static void Main(string[] args)
		{
			Level myVar = Level.Medium;
			Console.WriteLine(myVar);

			int myNum = (int) Months.April;
			Console.WriteLine(myNum);
		}
	}


	class Car {
		string color = "red";

		static void MyClass(string[] args) {
			Car myObj = new Car();
			Console.WriteLine(myObj.color);
		}
	}
}
