using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstOOP
{
	class Car
	{

		// Object field
		string color = "yellow blue";
		int maxSpeed = 2211;

		string color2;
		int maxSpeed2;

		string model;
		string modelColor;
		int modelYear;

		// Object Method
		public void CarEngine()
		{
			Console.WriteLine($"this car has {color} color and {maxSpeed} speed");
		}


		
		static void Main(string[] args)
		{
			Car myObject = new Car();
			Console.WriteLine(myObject.color);
			Console.WriteLine(myObject.maxSpeed);

			Car myObject2 = new Car();
			myObject2.color2 = "blue yellow";
			myObject2.maxSpeed2 = 1122;
			Console.WriteLine(myObject2.color2);
			Console.WriteLine(myObject2.maxSpeed2);

			Car audi = new Car();
			audi.model = "mustang";
			audi.modelColor = "#333";
			audi.modelYear = 2022;
			Console.WriteLine($"{ audi.model } and {audi.modelColor} and {audi.modelYear}");

			Car BMW = new Car("BMW", 200);
			int aPrice = audi.Price;
			string name = "test";
			audi.model = name;
			// Call the Method
			myObject.CarEngine();

			void AudiEngine()
			{
				Console.WriteLine($"this {audi.model} audi model has {audi.modelColor} color and producted in {audi.modelYear}");
			}
			AudiEngine();


			// Another Car using multiple classes
			AnotherCar Ford = new AnotherCar();
			Ford.otherModel = "fordmus";
			Ford.otherName = "musford";
			Ford.otherYear = 2022;
			Ford.otherEngine();


		}
		
	}
}
