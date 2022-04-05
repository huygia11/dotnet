using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstCsharpApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "First Hello";
			Console.Write("Hello world");
			string name = Console.ReadLine();
			Console.Write("Enter your name: ", name);
			// Console.WriteLine(name);

			int myNum = 22;
			Console.Write(myNum);

			// Các kiểu dữ liệu
			int myNum2 = 2211;
			double myDoubleNum = 5.99D;
			char myLetter = 'A';
			bool myBool = true;
			string myText = "TMA Solution";
			Console.Write(myNum2 + myDoubleNum + myLetter + myText);

			// chuyển đổi kiểu dữ liệu
			int myInt = 22;
			double myDouble = 11;
			bool myBool2 = false;

			Console.Write(Convert.ToString(myBool2));
			Console.Write(Convert.ToDouble(myInt));
			Console.Write(Convert.ToInt32(myDouble));

			string fullName = Console.ReadLine();
			Console.Write(fullName);

			String txt = "oasidnaosdniawodnaosdnaowdnawqe1pqowitiewt";
			Console.WriteLine(txt.Length);

			// String interpolation
			string thisName = $"This is my full name: {fullName}";
			Console.WriteLine(thisName);



			// if statement
			if (22 > 11)
			{
				Console.WriteLine(true);
			}


			// switch statement
			int a = 3;
			switch (a)
			{
				case 1:
					Console.WriteLine("1");
					break;
				case 2:
					Console.WriteLine("2");
					break;
				case 3:
					Console.WriteLine("3");
					break;
			}

			int sunday = 7;
			switch (sunday)
			{
				case 5:
					Console.WriteLine("today is Sunday");
					break;
				default:
					Console.WriteLine("not sunday");
					break;
			}


			// While loop
			int i = 5;
			while (i <= 10) {
				Console.WriteLine(i);
				i++;
			}

			int i2 = 0;
			do {
				Console.WriteLine(i2);
				i2++;
			}
			while (i2 < 5);


			// for loop
			for (int i3 = 0; i3 < 10; i3++) {
				Console.WriteLine(i3);
			}
			// foreach loop
			string[] cars = { "car1", "car2", "car3" };
			foreach(string i4 in cars) {
				Console.WriteLine(i4);
			}

			// C# Break
			for (int i4 = 0; i4 <= 10; i4++) {
				if (i4 == 4) {
					break;
				}
				Console.WriteLine(i4);
			}

			// C# continue
			for (int i5 = 0; i5 < 15; i5++) {
				if (i5 == 10) {
					continue;
				}
				Console.WriteLine(i5);
			}

			// you can also use break & continue in while loop
			int i6 = 0;
			while (i6 < 10) {
				Console.WriteLine(i6);
				i6++;
				if (i6 == 4) {
					break;
				}
			}

			int i7 = 1;
			while (i7 < 10) {
				if (i7 == 7) {
					i++;
					continue;
				}
				Console.WriteLine(i7);
				i7++;
			}
			

		}
	}
}
