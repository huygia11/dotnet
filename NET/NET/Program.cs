using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET
{
	class Person {
		private string name;

		public string Name {
			get { return name; }
			set { name = value; }
		}
	}

	class Car
	{
		private string model { get; set; }
		private string color { get; set; }
		private int year { get; set; }

		public Car(string modelName, string modelColor, int modelYear)
		{
			model = modelName;
			color = modelColor;
			year = modelYear;
		}

		static void Main(string[] args)
		{
			Car bmw = new Car("mustang", "yellow", 2022);
			Console.WriteLine($"{bmw.model} | {bmw.color} | {bmw.year}");

		}
	}
	
}
