using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace csString
{
	internal class Program
	{
		static void huystupid()
		{
			Console.WriteLine("huyngudot");
		}

		static void bay() {
			Console.WriteLine("i beleive i can fly");
		}
		static void Main()
		{
			huystupid();
			bay();
			/*string[] cars = { "ronaldo", "africa", "ricardo", "universal" };
			cars[2] = "Lamborghini";
			Console.WriteLine(cars[2]);
			Console.WriteLine(cars.Length);

			for (int i = 0; i < cars.Length; i++)
			{
				Console.WriteLine(cars[i]);
			}
			Console.WriteLine(cars.Length);

			//or foreach
			foreach (string i in cars)
			{
				Console.WriteLine(i);
			}

			Array.Sort(cars);
			foreach (string i in cars)
			{
				Console.WriteLine();
			}


			int[] numbers = { 1, 2, 3, 4, 5 };
			Array.Sort(numbers);
			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}

			//declare an array
			string[] trees;
			trees = new string[] { "quyt", "tao", "oi", "xoai" };
			trees[0] = "cay mận";

			void myMethod()
			{
				Console.WriteLine("i just got a new");
			}
			myMethod();

			void myMethod2(string fname)
			{
				Console.WriteLine(fname + "Universal");
			}

			myMethod2("Good Way ");
			myMethod2("Terrible Way ");

			// default parameter value
			void myMethod3(string country = "qncity")
			{
				Console.WriteLine(country);
			}
			myMethod3("qnhon");
			myMethod3("qngai");
			myMethod3();*/









			Console.WriteLine(Math.Max(22, 11));
			Console.WriteLine(Math.Min(22, 11));
			Console.WriteLine(Math.Sqrt(121));
			Console.WriteLine(Math.Sqrt(242));

			string name = "Do Phuc An Khang";

			int vitriA = name.IndexOf("A");

			string firstName = name.Substring(vitriA);

			Console.WriteLine(firstName);




			int x = 22, y = 11;
			if (x > y)
			{
				Console.WriteLine("dam chet cha may gio");
			}
			else
			{
				Console.WriteLine("ke me may");
			}

			int z = 33;
			switch (z)
			{
				case 11:
					Console.WriteLine("abc");
					break;
				case 22:
					Console.WriteLine("xyz");
					break;
				default:
					Console.WriteLine("aaa");
					break;
			}

			int g = 10;
			do
			{
				Console.WriteLine(g);
				g--;
			} while (g >= 0);

			Console.WriteLine();

			string[] array = { "huyngu", "khanghandsomeboy", "huyugly" };
			Console.WriteLine(array[0]);
			array[0] = "huydepcho";
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
			}

			Console.WriteLine();
			Array.Sort(array);
			foreach (string everything in array)
			{
				Console.WriteLine(everything);
			}

			Console.WriteLine();



		}



	}
}
