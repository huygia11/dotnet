using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
	internal class Program
	{
		// Bài 1: C# Program to perform all arithmetic operations
		public static void Operators(int x, int y)
		{
			Console.WriteLine($"x: {x}");
			Console.WriteLine($"y: {y}");
			Console.WriteLine($"cong: {x + y}");
			Console.WriteLine($"tru: {x - y}");
			Console.WriteLine($"nhan: {x * y}");
			Console.WriteLine($"chia: {x / y}");
			Console.WriteLine($"chia lay du: {x % y}");
			Console.WriteLine($"x++: {x++}");
			Console.WriteLine($"x--: {x--}");
		}



		// Bài 2: C# Program to convert days to years, weeks and days
		public static void DayConverter(int daysInput)
		{
			int week;
			int year;
			int daysOutput;

			week = daysInput % 7;
			year = daysInput / 365;
			daysOutput = daysInput - ((year * 365) + (week * 7));

			Console.WriteLine($"Day input: {daysInput} Converted to => year: {year}, week: {week}, days: {daysOutput}");
		}


		// Bài 3: C# program to check leap year using conditional Operator.
		public static void leapYear(int yearInput)
		{
			if (yearInput % 4 == 0)
			{
				Console.WriteLine($"nam {yearInput} la nam nhuan");
			}
			else
			{
				Console.WriteLine($"nam {yearInput} khong phai la nam nhuan");
			}
		}


		// Bài 4: C# program to enter month number and print number of days in month.
		public static void showDays(int monthInput)
		{
			switch (monthInput)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					Console.WriteLine($"thang {monthInput} co 31 ngay");
					break;
				case 2:
					Console.WriteLine($"thang {monthInput} co 28 ngay");
					Console.WriteLine($"thang {monthInput} nam nhuan co 29 ngay");
					break;
				case 4:
				case 6:
				case 9:
				case 11:
					Console.WriteLine($"thang {monthInput} co 30 ngay");
					break;
				default:
					Console.WriteLine("nhap 1 toi 12 thoi cha");
					break;
			}
		}

		public static void showDays2(int monthInput)
		{
			if (
				monthInput == 1 ||
				monthInput == 3 ||
				monthInput == 5 ||
				monthInput == 7 ||
				monthInput == 8 ||
				monthInput == 10 ||
				monthInput == 12
			)
			{
				Console.WriteLine($"thang {monthInput} co 31 ngay");
			}
			else if (monthInput == 2)
			{
				Console.WriteLine($"thang {monthInput} co 28 ngay");
				Console.WriteLine($"thang {monthInput} nam nhuan co 29 ngay");
			}
			else if (
				monthInput == 4 ||
				monthInput == 6 ||
				monthInput == 9 ||
				monthInput == 11
			)
			{
				Console.WriteLine($"thang {monthInput} co 30 ngay");
			}
			else
			{
				Console.WriteLine("nhap tu thang 1 toi thang 12 thoi cha");
			}
		}


		// Bài 5: Write C# program to print sum of digits enter by user
		public static void sumDigit(long inputNumber)
		{
			long sum = 0;
			long lastNumber;

			Console.Write($"tong cac chu so cua {inputNumber} ");

			for (; inputNumber > 0;)
			{
				lastNumber = inputNumber % 10;
				sum = sum + lastNumber;
				inputNumber /= 10;
			}
			Console.WriteLine($"la {sum}");
		}


		// Bài 6: Write C# program to find sum of even numbers between 1 to n
		public static void sumEven(long number)
		{
			long sum = 0;
			for (int i = 1; i <= number; i++)
			{
				sum += i;
			}
			Console.Write($"tong tu 1 den {number} la ");
			Console.WriteLine(sum);
		}


		// Bài 7: Write C# program to print day of week name using switch case
		public static void showDay(int day)
		{
			switch (day)
			{
				case 2:
					Console.WriteLine("this is monday");
					break;
				case 3:
					Console.WriteLine("this is tuesday");
					break;
				case 4:
					Console.WriteLine("this is wednesday");
					break;
				case 5:
					Console.WriteLine("this is thursday");
					break;
				case 6:
					Console.WriteLine("this is friday");
					break;
				case 7:
					Console.WriteLine("this is saturday");
					break;
				case 8:
					Console.WriteLine("this is sunday");
					break;
				default:
					Console.WriteLine("input from 2 to 8");
					break;
			}
		}


		// Bài 8: Write C# program to find sum of all elements of an array
		public static int sumArray(int[] array)
		{
			var sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}
			return sum;
		}


		// Bài 9: Write C# program to count total duplicate elements in an array and show what duplicate number
		public static void findDup(double[] duplicateArray)
		{
			var count = 0;

			for (int i = 0; i < duplicateArray.Length; i++)
			{
				if (duplicateArray.Where(n => n == duplicateArray[i]).Count() > 1)
				{
					count++;
				}
			}
			Console.WriteLine(count);
		}

		/*public static void findDupFor(double[] dupArr)
		{
			var count = 0;
			for (int i = 0; i < dupArr.Length; i++)
			{
				for (int j = i; j < dupArr.Length - 1; j++)
				{
					if (dupArr[i] == dupArr[j])
					{
						count += 1;
					}
				}
				Console.WriteLine($"{dupArr[i]} {count}");
			}
		}*/


		// Bài 10: Write C# Program to Find Minimum and Maximum of Numbers


		// Bài 11: Write a C# program to create a function to input a string and count number of spaces are in the string
		public static void stringCount(string inputString)
		{
			long count = 0;
			for (int i = 0; i < inputString.Length; i++)
			{
				if (inputString[i] == ' ')
				{
					count++;
				}
			}
			Console.WriteLine("there are " + count + " spaces");
		}


		// Bài 12: Write a C# program to create a function to display the n number Fibonacci sequence
		public static void displayFibo(double number)
		{
			double n1 = 0;
			double n2 = 1;
			double n3;
			for (int i = 0; i < number; i++)
			{
				n3 = n1 + n2;
				n1 = n2;
				n2 = n3;
				Console.Write($" {n3}");
			}
		}


		// Bài 13: Write a C# program to create a recursive function to find the factorial of a given number
		public static double factorial(double number)
		{
			if (number == 0)
			{
				return 1;
			}
			return number * factorial(number - 1);
		}


		// Bài 14: Write a C# program to compare (less than, greater than, equal to) two substrings
		public static void compareStr(string inputStr1, string inputStr2)
		{
			
		}


		






		public static void Main(string[] arge)
		{
			Operators(22, 11);


			Console.WriteLine();
			DayConverter(28909);


			Console.WriteLine();
			leapYear(581235);


			Console.WriteLine();
			showDays(2);
			showDays2(18);


			Console.WriteLine();
			sumDigit(9998798987213);


			Console.WriteLine();
			sumEven(10);


			Console.WriteLine();
			showDay(99);


			Console.WriteLine();
			int[] array = { 1, 2, 3, 4, 5 };
			var sum = sumArray(array);
			Console.WriteLine("tong cua mang: " + sum);

			Console.WriteLine();
			double[] dupArray = { 22, 12, 2211, 22, 12, 12, 22, 22, 12, 22, 11, 11, 11 };
			findDup(dupArray);


			Console.WriteLine();
			Console.WriteLine("max of array: " + dupArray.Max());


			Console.WriteLine();
			stringCount("Lorem Ipsum    is simply     dummy     pro     pro    pro    ");


			Console.WriteLine();
			displayFibo(15);


			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(factorial(6));


			Console.WriteLine();
			compareStr("computer", "mohoputer");




			Console.WriteLine();




			// Bài 15: Write a program in C# to create a list of numbers and display the numbers greater than 20 in LINQ Query
			List<double> number = new List<double>() { 2, 12, 54, 74, 76, 22, 11, 14, 90 };

			Console.Write("list: ");
			for (int i = 0; i < number.Count; i++)
			{
				Console.Write(number[i] + " ");
			}
			Console.WriteLine();

			var result = number.Where(n => n > 20).ToArray();

			Console.Write("number greater than 20:");

			for (int i = 0; i < result.Count(); i++)
			{
				Console.Write(" " + result[i]);
			}

			/*foreach (var item in result)
			{
				Console.Write(" " + item);
			}
			Console.WriteLine();*/






			Console.WriteLine();
			Console.WriteLine();
			// Bài 16: Write a program in C# to Remove Items from List using remove function by passing object in LINQ Query
			List<int> strList = new List<int>() {1, 2, 3, 4, 5, 6 };
			strList.Remove(1);
			foreach (var item in strList) {
				Console.WriteLine(item);
			}





			Console.WriteLine();
			Console.WriteLine();
			// Bài 17: Write a program in C# to arrange the distinct elements in the list in ascending order in LINQ Query
			List<int> numList = new List<int>() { 22, 11, 5, 7, 2, 1, 15, 62, 25 };

			numList.Sort();

			foreach (var s in numList)
			{
				Console.WriteLine(s);
			}



			Console.WriteLine();
			Console.WriteLine();
			// Bài 18: Write a program in C# to find the positive numbers from a list of numbers using two where conditions in LINQ Query
			List<int> num = new List<int>() { 2, -1, -56, 17, 68, 21, -67, 78 };

			var positive = num.Where(n => n > 0).ToArray();

			for (int i = 0; i < positive.Length; i++)
			{
				Console.WriteLine(positive[i]);
			}

		}
	}
}
