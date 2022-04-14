using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMenuConsoleApp
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to TMA Student Manager");
			Console.WriteLine("");
			Console.WriteLine("Please choose your \"Number\" option below:");
			Console.WriteLine("1 - Show All Students");
			Console.WriteLine("2 - Add New Student");
			Console.WriteLine("3 - Edit Information By Student's Id");
			Console.WriteLine("4 - Remove Student By Name");
			Console.WriteLine("5 - Reverse Student List");

			Console.WriteLine("");
			Console.Write("Select Option: ");
			Console.Write("");
			StudentManager manager = new StudentManager();
			switch (Console.ReadLine())
			{
				case "1":
					manager.getAll();
					break;
				case "2":
					
					break;
				case "3":

					break;
				case "4":

					break;
				case "5":

					break;


				default:
					break;
			}

			List<Student> stdList = new List<Student>() { };

		}
	}
}
