using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMenuConsoleApp
{
	internal class StudentManager
	{
		List<Student> stds = new List<Student>();
		public void getAll()
		{
			foreach (var std in stds)
			{
				Console.WriteLine("name :", std.name);
			}
		}
	}
}
